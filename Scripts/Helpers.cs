using System;
using UnityEngine;
using UnityEngine.Rendering;
using Valve.VR;

namespace VRLoad
{
    internal static class Helpers
    {
        public static ETextureType GetTextureType()
        {
            switch (SystemInfo.graphicsDeviceType)
            {
#if (UNITY_5_4)
                case GraphicsDeviceType.OpenGL2:
#endif
                case GraphicsDeviceType.OpenGLCore:
                case GraphicsDeviceType.OpenGLES2:
                case GraphicsDeviceType.OpenGLES3:
                    return ETextureType.OpenGL;
#if !(UNITY_5_4)
                case GraphicsDeviceType.Vulkan:
                    return ETextureType.Vulkan;
#endif
                default:
                    return ETextureType.DirectX;
            }
        }

        public static void SetSkyboxOverride(
            Texture front = null,
            Texture back = null,
            Texture left = null,
            Texture right = null,
            Texture top = null,
            Texture bottom = null)
        {
            var compositor = OpenVR.Compositor;
            if (compositor != null)
            {
                var handles = new[] {front, back, left, right, top, bottom};
                var textures = new Texture_t[6];
                for (int i = 0; i < 6; i++)
                {
                    textures[i].handle = (handles[i] != null) ? handles[i].GetNativeTexturePtr() : IntPtr.Zero;
                    textures[i].eType = GetTextureType();
                    textures[i].eColorSpace = EColorSpace.Auto;
                }

                var error = compositor.SetSkyboxOverride(textures);
                if (error != EVRCompositorError.None)
                {
                    Debug.LogError("<b>[SteamVR]</b> Failed to set skybox override with error: " + error);
                    if (error == EVRCompositorError.TextureIsOnWrongDevice)
                        Debug.Log(
                            "<b>[SteamVR]</b> Set your graphics driver to use the same video card as the headset is plugged into for Unity.");
                    else if (error == EVRCompositorError.TextureUsesUnsupportedFormat)
                        Debug.Log("<b>[SteamVR]</b> Ensure skybox textures are not compressed and have no mipmaps.");
                }
            }
        }
        
        public static bool pauseRendering
        {
            set
            {
                var compositor = OpenVR.Compositor;
                compositor?.SuspendRendering(value);
            }
        }

        public static void ClearOverride()
        {
            var compositor = OpenVR.Compositor;
            compositor?.ClearSkyboxOverride();
        }

        public static string overlayKey => "unity:" + Application.companyName + "." + Application.productName;


        [Serializable]
        public struct RigidTransform
        {
            public Vector3 pos;
            public Quaternion rot;

            public RigidTransform(Vector3 pos, Quaternion rot)
            {
                this.pos = pos;
                this.rot = rot;
            }

            public RigidTransform(Transform t)
            {
                this.pos = t.position;
                this.rot = t.rotation;
            }

            public RigidTransform(Transform from, Transform to)
            {
                var inv = Quaternion.Inverse(from.rotation);
                rot = inv * to.rotation;
                pos = inv * (to.position - from.position);
            }

            public RigidTransform(HmdMatrix34_t pose)
            {
                var m = Matrix4x4.identity;

                m[0, 0] = pose.m0;
                m[0, 1] = pose.m1;
                m[0, 2] = -pose.m2;
                m[0, 3] = pose.m3;

                m[1, 0] = pose.m4;
                m[1, 1] = pose.m5;
                m[1, 2] = -pose.m6;
                m[1, 3] = pose.m7;

                m[2, 0] = -pose.m8;
                m[2, 1] = -pose.m9;
                m[2, 2] = pose.m10;
                m[2, 3] = -pose.m11;

                this.pos = m.GetPosition();
                this.rot = m.GetRotation();
            }

            public RigidTransform(HmdMatrix44_t pose)
            {
                var m = Matrix4x4.identity;

                m[0, 0] = pose.m0;
                m[0, 1] = pose.m1;
                m[0, 2] = -pose.m2;
                m[0, 3] = pose.m3;

                m[1, 0] = pose.m4;
                m[1, 1] = pose.m5;
                m[1, 2] = -pose.m6;
                m[1, 3] = pose.m7;

                m[2, 0] = -pose.m8;
                m[2, 1] = -pose.m9;
                m[2, 2] = pose.m10;
                m[2, 3] = -pose.m11;

                m[3, 0] = pose.m12;
                m[3, 1] = pose.m13;
                m[3, 2] = -pose.m14;
                m[3, 3] = pose.m15;

                this.pos = m.GetPosition();
                this.rot = m.GetRotation();
            }

            public HmdMatrix34_t ToHmdMatrix34()
            {
                var m = Matrix4x4.TRS(pos, rot, Vector3.one);
                var pose = new HmdMatrix34_t();

                pose.m0 = m[0, 0];
                pose.m1 = m[0, 1];
                pose.m2 = -m[0, 2];
                pose.m3 = m[0, 3];

                pose.m4 = m[1, 0];
                pose.m5 = m[1, 1];
                pose.m6 = -m[1, 2];
                pose.m7 = m[1, 3];

                pose.m8 = -m[2, 0];
                pose.m9 = -m[2, 1];
                pose.m10 = m[2, 2];
                pose.m11 = -m[2, 3];

                return pose;
            }

            public override bool Equals(object o)
            {
                if (o is RigidTransform)
                {
                    RigidTransform t = (RigidTransform) o;
                    return pos == t.pos && rot == t.rot;
                }

                return false;
            }


            public override int GetHashCode()
            {
                return pos.GetHashCode() ^ rot.GetHashCode();
            }

            public static bool operator ==(RigidTransform a, RigidTransform b)
            {
                return a.pos == b.pos && a.rot == b.rot;
            }

            public static bool operator !=(RigidTransform a, RigidTransform b)
            {
                return a.pos != b.pos || a.rot != b.rot;
            }

            public static RigidTransform operator *(RigidTransform a, RigidTransform b)
            {
                return new RigidTransform
                {
                    rot = a.rot * b.rot,
                    pos = a.pos + a.rot * b.pos
                };
            }

            public Vector3 TransformPoint(Vector3 point)
            {
                return pos + (rot * point);
            }

            public static Vector3 operator *(RigidTransform t, Vector3 v)
            {
                return t.TransformPoint(v);
            }
        }
    }
}