//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Utilities for working with SteamVR
//
//=============================================================================

using System;
using UnityEngine;
using Valve.VR;

internal static class LoadUtils
{
	// this version does not clamp [0..1]

	private static float _copysign(float sizeval, float signval)
	{
		return Mathf.Sign(signval) == 1 ? Mathf.Abs(sizeval) : -Mathf.Abs(sizeval);
	}

	public static Quaternion GetRotation(this Matrix4x4 matrix)
	{
		var q = new Quaternion
		{
			w = Mathf.Sqrt(Mathf.Max(0, 1 + matrix.m00 + matrix.m11 + matrix.m22)) / 2,
			x = Mathf.Sqrt(Mathf.Max(0, 1 + matrix.m00 - matrix.m11 - matrix.m22)) / 2,
			y = Mathf.Sqrt(Mathf.Max(0, 1 - matrix.m00 + matrix.m11 - matrix.m22)) / 2,
			z = Mathf.Sqrt(Mathf.Max(0, 1 - matrix.m00 - matrix.m11 + matrix.m22)) / 2
		};
		
		q.x = _copysign(q.x, matrix.m21 - matrix.m12);
		q.y = _copysign(q.y, matrix.m02 - matrix.m20);
		q.z = _copysign(q.z, matrix.m10 - matrix.m01);
		return q;
	}

	public static Vector3 GetPosition(this Matrix4x4 matrix)
	{
		var x = matrix.m03;
		var y = matrix.m13;
		var z = matrix.m23;

		return new Vector3(x, y, z);
	}

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

			m[0, 0] =  pose.m0;
			m[0, 1] =  pose.m1;
			m[0, 2] = -pose.m2;
			m[0, 3] =  pose.m3;

			m[1, 0] =  pose.m4;
			m[1, 1] =  pose.m5;
			m[1, 2] = -pose.m6;
			m[1, 3] =  pose.m7;

			m[2, 0] = -pose.m8;
			m[2, 1] = -pose.m9;
			m[2, 2] =  pose.m10;
			m[2, 3] = -pose.m11;

			this.pos = m.GetPosition();
			this.rot = m.GetRotation();
		}

		public RigidTransform(HmdMatrix44_t pose)
		{
			var m = Matrix4x4.identity;

			m[0, 0] =  pose.m0;
			m[0, 1] =  pose.m1;
			m[0, 2] = -pose.m2;
			m[0, 3] =  pose.m3;

			m[1, 0] =  pose.m4;
			m[1, 1] =  pose.m5;
			m[1, 2] = -pose.m6;
			m[1, 3] =  pose.m7;

			m[2, 0] = -pose.m8;
			m[2, 1] = -pose.m9;
			m[2, 2] =  pose.m10;
			m[2, 3] = -pose.m11;

			m[3, 0] =  pose.m12;
			m[3, 1] =  pose.m13;
			m[3, 2] = -pose.m14;
			m[3, 3] =  pose.m15;

			this.pos = m.GetPosition();
			this.rot = m.GetRotation();
		}

		public override bool Equals(object o)
		{
			if (o is RigidTransform)
			{
				RigidTransform t = (RigidTransform)o;
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

