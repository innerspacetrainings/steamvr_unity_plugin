//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: This file contains C#/managed code bindings for the OpenVR interfaces
// This file is auto-generated, do not edit it.
//
//=============================================================================

using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming
// ReSharper disable FieldCanBeMadeReadOnly.Global
// ReSharper disable IdentifierTypo
// ReSharper disable MemberCanBePrivate.Global

#if UNITY_5_3_OR_NEWER

#endif

namespace Valve.VR
{
	[StructLayout(LayoutKind.Sequential)]
public struct IVRApplications
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _AddApplicationManifest(string pchApplicationManifestFullPath, bool bTemporary);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _AddApplicationManifest AddApplicationManifest;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _RemoveApplicationManifest(string pchApplicationManifestFullPath);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RemoveApplicationManifest RemoveApplicationManifest;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsApplicationInstalled(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsApplicationInstalled IsApplicationInstalled;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationCount();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationCount GetApplicationCount;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _GetApplicationKeyByIndex(uint unApplicationIndex, System.Text.StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationKeyByIndex GetApplicationKeyByIndex;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _GetApplicationKeyByProcessId(uint unProcessId, System.Text.StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationKeyByProcessId GetApplicationKeyByProcessId;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchApplication(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LaunchApplication LaunchApplication;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchTemplateApplication(string pchTemplateAppKey, string pchNewAppKey, [In, Out] AppOverrideKeys_t[] pKeys, uint unKeys);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LaunchTemplateApplication LaunchTemplateApplication;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchApplicationFromMimeType(string pchMimeType, string pchArgs);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LaunchApplicationFromMimeType LaunchApplicationFromMimeType;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchDashboardOverlay(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LaunchDashboardOverlay LaunchDashboardOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _CancelApplicationLaunch(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CancelApplicationLaunch CancelApplicationLaunch;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _IdentifyApplication(uint unProcessId, string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IdentifyApplication IdentifyApplication;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationProcessId(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationProcessId GetApplicationProcessId;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetApplicationsErrorNameFromEnum(EVRApplicationError error);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationsErrorNameFromEnum GetApplicationsErrorNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, System.Text.StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationPropertyString GetApplicationPropertyString;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationPropertyBool GetApplicationPropertyBool;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ulong _GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationPropertyUint64 GetApplicationPropertyUint64;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetApplicationAutoLaunch SetApplicationAutoLaunch;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetApplicationAutoLaunch(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationAutoLaunch GetApplicationAutoLaunch;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _SetDefaultApplicationForMimeType(string pchAppKey, string pchMimeType);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetDefaultApplicationForMimeType SetDefaultApplicationForMimeType;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetDefaultApplicationForMimeType(string pchMimeType, System.Text.StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDefaultApplicationForMimeType GetDefaultApplicationForMimeType;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetApplicationSupportedMimeTypes(string pchAppKey, System.Text.StringBuilder pchMimeTypesBuffer, uint unMimeTypesBuffer);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationSupportedMimeTypes GetApplicationSupportedMimeTypes;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationsThatSupportMimeType(string pchMimeType, System.Text.StringBuilder pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationsThatSupportMimeType GetApplicationsThatSupportMimeType;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationLaunchArguments(uint unHandle, System.Text.StringBuilder pchArgs, uint unArgs);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationLaunchArguments GetApplicationLaunchArguments;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _GetStartingApplication(System.Text.StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetStartingApplication GetStartingApplication;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRSceneApplicationState _GetSceneApplicationState();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSceneApplicationState GetSceneApplicationState;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _PerformApplicationPrelaunchCheck(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PerformApplicationPrelaunchCheck PerformApplicationPrelaunchCheck;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetSceneApplicationStateNameFromEnum(EVRSceneApplicationState state);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSceneApplicationStateNameFromEnum GetSceneApplicationStateNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LaunchInternalProcess LaunchInternalProcess;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetCurrentSceneProcessId();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCurrentSceneProcessId GetCurrentSceneProcessId;

}

[StructLayout(LayoutKind.Sequential)]
public struct IVRCompositor
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetTrackingSpace(ETrackingUniverseOrigin eOrigin);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetTrackingSpace SetTrackingSpace;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ETrackingUniverseOrigin _GetTrackingSpace();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetTrackingSpace GetTrackingSpace;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _WaitGetPoses([In, Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In, Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _WaitGetPoses WaitGetPoses;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _GetLastPoses([In, Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In, Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLastPoses GetLastPoses;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLastPoseForTrackedDeviceIndex GetLastPoseForTrackedDeviceIndex;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _Submit Submit;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ClearLastSubmittedFrame();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ClearLastSubmittedFrame ClearLastSubmittedFrame;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _PostPresentHandoff();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PostPresentHandoff PostPresentHandoff;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetFrameTiming GetFrameTiming;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetFrameTimings([In, Out] Compositor_FrameTiming[] pTiming, uint nFrames);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetFrameTimings GetFrameTimings;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate float _GetFrameTimeRemaining();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetFrameTimeRemaining GetFrameTimeRemaining;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetCumulativeStats(ref Compositor_CumulativeStats pStats, uint nStatsSizeInBytes);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCumulativeStats GetCumulativeStats;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FadeToColor FadeToColor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate HmdColor_t _GetCurrentFadeColor(bool bBackground);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCurrentFadeColor GetCurrentFadeColor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _FadeGrid(float fSeconds, bool bFadeIn);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FadeGrid FadeGrid;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate float _GetCurrentGridAlpha();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCurrentGridAlpha GetCurrentGridAlpha;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _SetSkyboxOverride([In, Out] Texture_t[] pTextures, uint unTextureCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetSkyboxOverride SetSkyboxOverride;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ClearSkyboxOverride();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ClearSkyboxOverride ClearSkyboxOverride;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _CompositorBringToFront();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CompositorBringToFront CompositorBringToFront;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _CompositorGoToBack();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CompositorGoToBack CompositorGoToBack;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _CompositorQuit();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CompositorQuit CompositorQuit;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsFullscreen();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsFullscreen IsFullscreen;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetCurrentSceneFocusProcess();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCurrentSceneFocusProcess GetCurrentSceneFocusProcess;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetLastFrameRenderer();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLastFrameRenderer GetLastFrameRenderer;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _CanRenderScene();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CanRenderScene CanRenderScene;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ShowMirrorWindow();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowMirrorWindow ShowMirrorWindow;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _HideMirrorWindow();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HideMirrorWindow HideMirrorWindow;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsMirrorWindowVisible();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsMirrorWindowVisible IsMirrorWindowVisible;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _CompositorDumpImages();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CompositorDumpImages CompositorDumpImages;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ShouldAppRenderWithLowResources();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShouldAppRenderWithLowResources ShouldAppRenderWithLowResources;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ForceInterleavedReprojectionOn(bool bOverride);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ForceInterleavedReprojectionOn ForceInterleavedReprojectionOn;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ForceReconnectProcess();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ForceReconnectProcess ForceReconnectProcess;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SuspendRendering(bool bSuspend);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SuspendRendering SuspendRendering;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _GetMirrorTextureD3D11(EVREye eEye, IntPtr pD3D11DeviceOrResource, ref IntPtr ppD3D11ShaderResourceView);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetMirrorTextureD3D11 GetMirrorTextureD3D11;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ReleaseMirrorTextureD3D11(IntPtr pD3D11ShaderResourceView);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseMirrorTextureD3D11 ReleaseMirrorTextureD3D11;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _GetMirrorTextureGL(EVREye eEye, ref uint pglTextureId, IntPtr pglSharedTextureHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetMirrorTextureGL GetMirrorTextureGL;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ReleaseSharedGLTexture(uint glTextureId, IntPtr glSharedTextureHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseSharedGLTexture ReleaseSharedGLTexture;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _LockGLSharedTextureForAccess(IntPtr glSharedTextureHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LockGLSharedTextureForAccess LockGLSharedTextureForAccess;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _UnlockGLSharedTextureForAccess(IntPtr glSharedTextureHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _UnlockGLSharedTextureForAccess UnlockGLSharedTextureForAccess;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetVulkanInstanceExtensionsRequired(System.Text.StringBuilder pchValue, uint unBufferSize);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetVulkanInstanceExtensionsRequired GetVulkanInstanceExtensionsRequired;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetVulkanDeviceExtensionsRequired(IntPtr pPhysicalDevice, System.Text.StringBuilder pchValue, uint unBufferSize);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetVulkanDeviceExtensionsRequired GetVulkanDeviceExtensionsRequired;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetExplicitTimingMode(EVRCompositorTimingMode eTimingMode);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetExplicitTimingMode SetExplicitTimingMode;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _SubmitExplicitTimingData();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SubmitExplicitTimingData SubmitExplicitTimingData;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsMotionSmoothingEnabled();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsMotionSmoothingEnabled IsMotionSmoothingEnabled;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsMotionSmoothingSupported();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsMotionSmoothingSupported IsMotionSmoothingSupported;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsCurrentSceneFocusAppLoading();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsCurrentSceneFocusAppLoading IsCurrentSceneFocusAppLoading;

}

[StructLayout(LayoutKind.Sequential)]
public struct IVROverlay
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _FindOverlay(string pchOverlayKey, ref ulong pOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FindOverlay FindOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _CreateOverlay(string pchOverlayKey, string pchOverlayName, ref ulong pOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CreateOverlay CreateOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _DestroyOverlay(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _DestroyOverlay DestroyOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetOverlayKey(ulong ulOverlayHandle, System.Text.StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayKey GetOverlayKey;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetOverlayName(ulong ulOverlayHandle, System.Text.StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayName GetOverlayName;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayName(ulong ulOverlayHandle, string pchName);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayName SetOverlayName;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayImageData GetOverlayImageData;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetOverlayErrorNameFromEnum(EVROverlayError error);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayErrorNameFromEnum GetOverlayErrorNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayRenderingPid(ulong ulOverlayHandle, uint unPID);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayRenderingPid SetOverlayRenderingPid;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetOverlayRenderingPid(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayRenderingPid GetOverlayRenderingPid;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayFlag SetOverlayFlag;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayFlag GetOverlayFlag;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayColor SetOverlayColor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayColor GetOverlayColor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayAlpha SetOverlayAlpha;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayAlpha GetOverlayAlpha;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTexelAspect(ulong ulOverlayHandle, float fTexelAspect);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTexelAspect SetOverlayTexelAspect;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTexelAspect(ulong ulOverlayHandle, ref float pfTexelAspect);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTexelAspect GetOverlayTexelAspect;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlaySortOrder(ulong ulOverlayHandle, uint unSortOrder);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlaySortOrder SetOverlaySortOrder;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlaySortOrder(ulong ulOverlayHandle, ref uint punSortOrder);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlaySortOrder GetOverlaySortOrder;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayWidthInMeters SetOverlayWidthInMeters;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayWidthInMeters GetOverlayWidthInMeters;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayCurvature(ulong ulOverlayHandle, float fCurvature);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayCurvature SetOverlayCurvature;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayCurvature(ulong ulOverlayHandle, ref float pfCurvature);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayCurvature GetOverlayCurvature;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTextureColorSpace SetOverlayTextureColorSpace;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTextureColorSpace GetOverlayTextureColorSpace;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTextureBounds SetOverlayTextureBounds;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTextureBounds GetOverlayTextureBounds;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetOverlayRenderModel(ulong ulOverlayHandle, System.Text.StringBuilder pchValue, uint unBufferSize, ref HmdColor_t pColor, ref EVROverlayError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayRenderModel GetOverlayRenderModel;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayRenderModel(ulong ulOverlayHandle, string pchRenderModel, ref HmdColor_t pColor);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayRenderModel SetOverlayRenderModel;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTransformType GetOverlayTransformType;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTransformAbsolute SetOverlayTransformAbsolute;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTransformAbsolute GetOverlayTransformAbsolute;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTransformTrackedDeviceRelative SetOverlayTransformTrackedDeviceRelative;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTransformTrackedDeviceRelative GetOverlayTransformTrackedDeviceRelative;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTransformTrackedDeviceComponent SetOverlayTransformTrackedDeviceComponent;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, System.Text.StringBuilder pchComponentName, uint unComponentNameSize);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTransformTrackedDeviceComponent GetOverlayTransformTrackedDeviceComponent;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ref ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTransformOverlayRelative GetOverlayTransformOverlayRelative;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTransformOverlayRelative SetOverlayTransformOverlayRelative;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ShowOverlay(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowOverlay ShowOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _HideOverlay(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HideOverlay HideOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsOverlayVisible(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsOverlayVisible IsOverlayVisible;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetTransformForOverlayCoordinates GetTransformForOverlayCoordinates;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PollNextOverlayEvent PollNextOverlayEvent;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayInputMethod GetOverlayInputMethod;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayInputMethod SetOverlayInputMethod;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayMouseScale GetOverlayMouseScale;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayMouseScale SetOverlayMouseScale;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ComputeOverlayIntersection ComputeOverlayIntersection;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsHoverTargetOverlay(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsHoverTargetOverlay IsHoverTargetOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayDualAnalogTransform(ulong ulOverlay, EDualAnalogWhich eWhich, ref HmdVector2_t pvCenter, float fRadius);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayDualAnalogTransform SetOverlayDualAnalogTransform;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayDualAnalogTransform(ulong ulOverlay, EDualAnalogWhich eWhich, ref HmdVector2_t pvCenter, ref float pfRadius);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayDualAnalogTransform GetOverlayDualAnalogTransform;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTexture SetOverlayTexture;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ClearOverlayTexture(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ClearOverlayTexture ClearOverlayTexture;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unDepth);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayRaw SetOverlayRaw;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayFromFile(ulong ulOverlayHandle, string pchFilePath);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayFromFile SetOverlayFromFile;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTexture(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTexture GetOverlayTexture;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ReleaseNativeOverlayHandle(ulong ulOverlayHandle, IntPtr pNativeTextureHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseNativeOverlayHandle ReleaseNativeOverlayHandle;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTextureSize(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTextureSize GetOverlayTextureSize;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _CreateDashboardOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CreateDashboardOverlay CreateDashboardOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsDashboardVisible();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsDashboardVisible IsDashboardVisible;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsActiveDashboardOverlay(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsActiveDashboardOverlay IsActiveDashboardOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetDashboardOverlaySceneProcess SetDashboardOverlaySceneProcess;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDashboardOverlaySceneProcess GetDashboardOverlaySceneProcess;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ShowDashboard(string pchOverlayToShow);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowDashboard ShowDashboard;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetPrimaryDashboardDevice();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetPrimaryDashboardDevice GetPrimaryDashboardDevice;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ShowKeyboard(int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowKeyboard ShowKeyboard;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowKeyboardForOverlay ShowKeyboardForOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetKeyboardText(System.Text.StringBuilder pchText, uint cchText);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetKeyboardText GetKeyboardText;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _HideKeyboard();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HideKeyboard HideKeyboard;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetKeyboardTransformAbsolute SetKeyboardTransformAbsolute;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetKeyboardPositionForOverlay SetKeyboardPositionForOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayIntersectionMask(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayIntersectionMask SetOverlayIntersectionMask;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayFlags(ulong ulOverlayHandle, ref uint pFlags);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayFlags GetOverlayFlags;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate VRMessageOverlayResponse _ShowMessageOverlay(string pchText, string pchCaption, string pchButton0Text, string pchButton1Text, string pchButton2Text, string pchButton3Text);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowMessageOverlay ShowMessageOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _CloseMessageOverlay();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CloseMessageOverlay CloseMessageOverlay;

}

public class CVRApplications
{
	IVRApplications FnTable;
	internal CVRApplications(IntPtr pInterface)
	{
		FnTable = (IVRApplications)Marshal.PtrToStructure(pInterface, typeof(IVRApplications));
	}
	public EVRApplicationError LaunchInternalProcess(string pchBinaryPath,string pchArguments,string pchWorkingDirectory)
	{
		EVRApplicationError result = FnTable.LaunchInternalProcess(pchBinaryPath,pchArguments,pchWorkingDirectory);
		return result;
	}
}

public class CVRCompositor
{
	IVRCompositor FnTable;
	internal CVRCompositor(IntPtr pInterface)
	{
		FnTable = (IVRCompositor)Marshal.PtrToStructure(pInterface, typeof(IVRCompositor));
	}
	public void FadeToColor(float fSeconds,float fRed,float fGreen,float fBlue,float fAlpha,bool bBackground)
	{
		FnTable.FadeToColor(fSeconds,fRed,fGreen,fBlue,fAlpha,bBackground);
	}
	public void FadeGrid(float fSeconds,bool bFadeIn)
	{
		FnTable.FadeGrid(fSeconds,bFadeIn);
	}
	public EVRCompositorError SetSkyboxOverride(Texture_t [] pTextures)
	{
		EVRCompositorError result = FnTable.SetSkyboxOverride(pTextures,(uint) pTextures.Length);
		return result;
	}
	public void ClearSkyboxOverride()
	{
		FnTable.ClearSkyboxOverride();
	}
	public void SuspendRendering(bool bSuspend)
	{
		FnTable.SuspendRendering(bSuspend);
	}
}


public class CVROverlay
{
	IVROverlay FnTable;
	internal CVROverlay(IntPtr pInterface)
	{
		FnTable = (IVROverlay)Marshal.PtrToStructure(pInterface, typeof(IVROverlay));
	}
	public EVROverlayError FindOverlay(string pchOverlayKey,ref ulong pOverlayHandle)
	{
		pOverlayHandle = 0;
		EVROverlayError result = FnTable.FindOverlay(pchOverlayKey,ref pOverlayHandle);
		return result;
	}
	public EVROverlayError CreateOverlay(string pchOverlayKey,string pchOverlayName,ref ulong pOverlayHandle)
	{
		pOverlayHandle = 0;
		EVROverlayError result = FnTable.CreateOverlay(pchOverlayKey,pchOverlayName,ref pOverlayHandle);
		return result;
	}
	public void SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha)
	{
		FnTable.SetOverlayAlpha(ulOverlayHandle,fAlpha);
	}
	public void SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters)
	{
		FnTable.SetOverlayWidthInMeters(ulOverlayHandle,fWidthInMeters);
	}
	public void SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds)
	{
		FnTable.SetOverlayTextureBounds(ulOverlayHandle,ref pOverlayTextureBounds);
	}
	public void SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin,
		ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform)
	{
		FnTable.SetOverlayTransformAbsolute(ulOverlayHandle,eTrackingOrigin,ref pmatTrackingOriginToOverlayTransform);
	}
	public void ShowOverlay(ulong ulOverlayHandle)
	{
		FnTable.ShowOverlay(ulOverlayHandle);
	}
	public void HideOverlay(ulong ulOverlayHandle)
	{
		FnTable.HideOverlay(ulOverlayHandle);
	}
// This is a terrible hack to workaround the fact that VRControllerState_t and VREvent_t were
// originally mis-compiled with the wrong packing for Linux and OSX.

	public void SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture)
	{
		FnTable.SetOverlayTexture(ulOverlayHandle,ref pTexture);
	}
}


public class OpenVRInterop
{
	[DllImportAttribute("openvr_api", EntryPoint = "VR_ShutdownInternal", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void ShutdownInternal();
	[DllImportAttribute("openvr_api", EntryPoint = "VR_GetGenericInterface", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr GetGenericInterface([In, MarshalAs(UnmanagedType.LPStr)] string pchInterfaceVersion, ref EVRInitError peError);

	[DllImportAttribute("openvr_api", EntryPoint = "VR_GetInitToken", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint GetInitToken();
}


public enum EVREye
{
	Eye_Left = 0,
	Eye_Right = 1,
}
public enum ETextureType
{
	Invalid = -1,
	DirectX = 0,
	OpenGL = 1,
	Vulkan = 2,
	IOSurface = 3,
	DirectX12 = 4,
	DXGISharedHandle = 5,
	Metal = 6,
}
public enum EColorSpace
{
	Auto = 0,
	Gamma = 1,
	Linear = 2,
}
public enum ETrackingResult
{
	Uninitialized = 1,
	Calibrating_InProgress = 100,
	Calibrating_OutOfRange = 101,
	Running_OK = 200,
	Running_OutOfRange = 201,
	Fallback_RotationOnly = 300,
}
public enum ETrackingUniverseOrigin
{
	TrackingUniverseSeated = 0,
	TrackingUniverseStanding = 1,
	TrackingUniverseRawAndUncalibrated = 2,
}

public enum ETrackedDeviceProperty
{
	Prop_Invalid = 0,
	Prop_TrackingSystemName_String = 1000,
	Prop_ModelNumber_String = 1001,
	Prop_SerialNumber_String = 1002,
	Prop_RenderModelName_String = 1003,
	Prop_WillDriftInYaw_Bool = 1004,
	Prop_ManufacturerName_String = 1005,
	Prop_TrackingFirmwareVersion_String = 1006,
	Prop_HardwareRevision_String = 1007,
	Prop_AllWirelessDongleDescriptions_String = 1008,
	Prop_ConnectedWirelessDongle_String = 1009,
	Prop_DeviceIsWireless_Bool = 1010,
	Prop_DeviceIsCharging_Bool = 1011,
	Prop_DeviceBatteryPercentage_Float = 1012,
	Prop_StatusDisplayTransform_Matrix34 = 1013,
	Prop_Firmware_UpdateAvailable_Bool = 1014,
	Prop_Firmware_ManualUpdate_Bool = 1015,
	Prop_Firmware_ManualUpdateURL_String = 1016,
	Prop_HardwareRevision_Uint64 = 1017,
	Prop_FirmwareVersion_Uint64 = 1018,
	Prop_FPGAVersion_Uint64 = 1019,
	Prop_VRCVersion_Uint64 = 1020,
	Prop_RadioVersion_Uint64 = 1021,
	Prop_DongleVersion_Uint64 = 1022,
	Prop_BlockServerShutdown_Bool = 1023,
	Prop_CanUnifyCoordinateSystemWithHmd_Bool = 1024,
	Prop_ContainsProximitySensor_Bool = 1025,
	Prop_DeviceProvidesBatteryStatus_Bool = 1026,
	Prop_DeviceCanPowerOff_Bool = 1027,
	Prop_Firmware_ProgrammingTarget_String = 1028,
	Prop_DeviceClass_Int32 = 1029,
	Prop_HasCamera_Bool = 1030,
	Prop_DriverVersion_String = 1031,
	Prop_Firmware_ForceUpdateRequired_Bool = 1032,
	Prop_ViveSystemButtonFixRequired_Bool = 1033,
	Prop_ParentDriver_Uint64 = 1034,
	Prop_ResourceRoot_String = 1035,
	Prop_RegisteredDeviceType_String = 1036,
	Prop_InputProfilePath_String = 1037,
	Prop_NeverTracked_Bool = 1038,
	Prop_NumCameras_Int32 = 1039,
	Prop_CameraFrameLayout_Int32 = 1040,
	Prop_CameraStreamFormat_Int32 = 1041,
	Prop_AdditionalDeviceSettingsPath_String = 1042,
	Prop_Identifiable_Bool = 1043,
	Prop_BootloaderVersion_Uint64 = 1044,
	Prop_AdditionalSystemReportData_String = 1045,
	Prop_CompositeFirmwareVersion_String = 1046,
	Prop_Firmware_RemindUpdate_Bool = 1047,
	Prop_ReportsTimeSinceVSync_Bool = 2000,
	Prop_SecondsFromVsyncToPhotons_Float = 2001,
	Prop_DisplayFrequency_Float = 2002,
	Prop_UserIpdMeters_Float = 2003,
	Prop_CurrentUniverseId_Uint64 = 2004,
	Prop_PreviousUniverseId_Uint64 = 2005,
	Prop_DisplayFirmwareVersion_Uint64 = 2006,
	Prop_IsOnDesktop_Bool = 2007,
	Prop_DisplayMCType_Int32 = 2008,
	Prop_DisplayMCOffset_Float = 2009,
	Prop_DisplayMCScale_Float = 2010,
	Prop_EdidVendorID_Int32 = 2011,
	Prop_DisplayMCImageLeft_String = 2012,
	Prop_DisplayMCImageRight_String = 2013,
	Prop_DisplayGCBlackClamp_Float = 2014,
	Prop_EdidProductID_Int32 = 2015,
	Prop_CameraToHeadTransform_Matrix34 = 2016,
	Prop_DisplayGCType_Int32 = 2017,
	Prop_DisplayGCOffset_Float = 2018,
	Prop_DisplayGCScale_Float = 2019,
	Prop_DisplayGCPrescale_Float = 2020,
	Prop_DisplayGCImage_String = 2021,
	Prop_LensCenterLeftU_Float = 2022,
	Prop_LensCenterLeftV_Float = 2023,
	Prop_LensCenterRightU_Float = 2024,
	Prop_LensCenterRightV_Float = 2025,
	Prop_UserHeadToEyeDepthMeters_Float = 2026,
	Prop_CameraFirmwareVersion_Uint64 = 2027,
	Prop_CameraFirmwareDescription_String = 2028,
	Prop_DisplayFPGAVersion_Uint64 = 2029,
	Prop_DisplayBootloaderVersion_Uint64 = 2030,
	Prop_DisplayHardwareVersion_Uint64 = 2031,
	Prop_AudioFirmwareVersion_Uint64 = 2032,
	Prop_CameraCompatibilityMode_Int32 = 2033,
	Prop_ScreenshotHorizontalFieldOfViewDegrees_Float = 2034,
	Prop_ScreenshotVerticalFieldOfViewDegrees_Float = 2035,
	Prop_DisplaySuppressed_Bool = 2036,
	Prop_DisplayAllowNightMode_Bool = 2037,
	Prop_DisplayMCImageWidth_Int32 = 2038,
	Prop_DisplayMCImageHeight_Int32 = 2039,
	Prop_DisplayMCImageNumChannels_Int32 = 2040,
	Prop_DisplayMCImageData_Binary = 2041,
	Prop_SecondsFromPhotonsToVblank_Float = 2042,
	Prop_DriverDirectModeSendsVsyncEvents_Bool = 2043,
	Prop_DisplayDebugMode_Bool = 2044,
	Prop_GraphicsAdapterLuid_Uint64 = 2045,
	Prop_DriverProvidedChaperonePath_String = 2048,
	Prop_ExpectedTrackingReferenceCount_Int32 = 2049,
	Prop_ExpectedControllerCount_Int32 = 2050,
	Prop_NamedIconPathControllerLeftDeviceOff_String = 2051,
	Prop_NamedIconPathControllerRightDeviceOff_String = 2052,
	Prop_NamedIconPathTrackingReferenceDeviceOff_String = 2053,
	Prop_DoNotApplyPrediction_Bool = 2054,
	Prop_CameraToHeadTransforms_Matrix34_Array = 2055,
	Prop_DistortionMeshResolution_Int32 = 2056,
	Prop_DriverIsDrawingControllers_Bool = 2057,
	Prop_DriverRequestsApplicationPause_Bool = 2058,
	Prop_DriverRequestsReducedRendering_Bool = 2059,
	Prop_MinimumIpdStepMeters_Float = 2060,
	Prop_AudioBridgeFirmwareVersion_Uint64 = 2061,
	Prop_ImageBridgeFirmwareVersion_Uint64 = 2062,
	Prop_ImuToHeadTransform_Matrix34 = 2063,
	Prop_ImuFactoryGyroBias_Vector3 = 2064,
	Prop_ImuFactoryGyroScale_Vector3 = 2065,
	Prop_ImuFactoryAccelerometerBias_Vector3 = 2066,
	Prop_ImuFactoryAccelerometerScale_Vector3 = 2067,
	Prop_ConfigurationIncludesLighthouse20Features_Bool = 2069,
	Prop_AdditionalRadioFeatures_Uint64 = 2070,
	Prop_CameraWhiteBalance_Vector4_Array = 2071,
	Prop_CameraDistortionFunction_Int32_Array = 2072,
	Prop_CameraDistortionCoefficients_Float_Array = 2073,
	Prop_ExpectedControllerType_String = 2074,
	Prop_HmdTrackingStyle_Int32 = 2075,
	Prop_DriverProvidedChaperoneVisibility_Bool = 2076,
	Prop_HmdProvidesDisplaySettings_Bool = 2077,
	Prop_DisplayAvailableFrameRates_Float_Array = 2080,
	Prop_DisplaySupportsMultipleFramerates_Bool = 2081,
	Prop_DisplayColorMultLeft_Vector3 = 2082,
	Prop_DisplayColorMultRight_Vector3 = 2083,
	Prop_DashboardLayoutPathName_String = 2090,
	Prop_DashboardScale_Float = 2091,
	Prop_IpdUIRangeMinMeters_Float = 2100,
	Prop_IpdUIRangeMaxMeters_Float = 2101,
	Prop_DriverRequestedMuraCorrectionMode_Int32 = 2200,
	Prop_DriverRequestedMuraFeather_InnerLeft_Int32 = 2201,
	Prop_DriverRequestedMuraFeather_InnerRight_Int32 = 2202,
	Prop_DriverRequestedMuraFeather_InnerTop_Int32 = 2203,
	Prop_DriverRequestedMuraFeather_InnerBottom_Int32 = 2204,
	Prop_DriverRequestedMuraFeather_OuterLeft_Int32 = 2205,
	Prop_DriverRequestedMuraFeather_OuterRight_Int32 = 2206,
	Prop_DriverRequestedMuraFeather_OuterTop_Int32 = 2207,
	Prop_DriverRequestedMuraFeather_OuterBottom_Int32 = 2208,
	Prop_Audio_DefaultPlaybackDeviceId_String = 2300,
	Prop_Audio_DefaultRecordingDeviceId_String = 2301,
	Prop_Audio_DefaultPlaybackDeviceVolume_Float = 2302,
	Prop_AttachedDeviceId_String = 3000,
	Prop_SupportedButtons_Uint64 = 3001,
	Prop_Axis0Type_Int32 = 3002,
	Prop_Axis1Type_Int32 = 3003,
	Prop_Axis2Type_Int32 = 3004,
	Prop_Axis3Type_Int32 = 3005,
	Prop_Axis4Type_Int32 = 3006,
	Prop_ControllerRoleHint_Int32 = 3007,
	Prop_FieldOfViewLeftDegrees_Float = 4000,
	Prop_FieldOfViewRightDegrees_Float = 4001,
	Prop_FieldOfViewTopDegrees_Float = 4002,
	Prop_FieldOfViewBottomDegrees_Float = 4003,
	Prop_TrackingRangeMinimumMeters_Float = 4004,
	Prop_TrackingRangeMaximumMeters_Float = 4005,
	Prop_ModeLabel_String = 4006,
	Prop_CanWirelessIdentify_Bool = 4007,
	Prop_Nonce_Int32 = 4008,
	Prop_IconPathName_String = 5000,
	Prop_NamedIconPathDeviceOff_String = 5001,
	Prop_NamedIconPathDeviceSearching_String = 5002,
	Prop_NamedIconPathDeviceSearchingAlert_String = 5003,
	Prop_NamedIconPathDeviceReady_String = 5004,
	Prop_NamedIconPathDeviceReadyAlert_String = 5005,
	Prop_NamedIconPathDeviceNotReady_String = 5006,
	Prop_NamedIconPathDeviceStandby_String = 5007,
	Prop_NamedIconPathDeviceAlertLow_String = 5008,
	Prop_NamedIconPathDeviceStandbyAlert_String = 5009,
	Prop_DisplayHiddenArea_Binary_Start = 5100,
	Prop_DisplayHiddenArea_Binary_End = 5150,
	Prop_ParentContainer = 5151,
	Prop_OverrideContainer_Uint64 = 5152,
	Prop_UserConfigPath_String = 6000,
	Prop_InstallPath_String = 6001,
	Prop_HasDisplayComponent_Bool = 6002,
	Prop_HasControllerComponent_Bool = 6003,
	Prop_HasCameraComponent_Bool = 6004,
	Prop_HasDriverDirectModeComponent_Bool = 6005,
	Prop_HasVirtualDisplayComponent_Bool = 6006,
	Prop_HasSpatialAnchorsSupport_Bool = 6007,
	Prop_ControllerType_String = 7000,
	Prop_ControllerHandSelectionPriority_Int32 = 7002,
	Prop_VendorSpecific_Reserved_Start = 10000,
	Prop_VendorSpecific_Reserved_End = 10999,
	Prop_TrackedDeviceProperty_Max = 1000000,
}

public enum EVRSubmitFlags
{
	Submit_Default = 0,
	Submit_LensDistortionAlreadyApplied = 1,
	Submit_GlRenderBuffer = 2,
	Submit_Reserved = 4,
	Submit_TextureWithPose = 8,
	Submit_TextureWithDepth = 16,
}

public enum EDualAnalogWhich
{
	k_EDualAnalog_Left = 0,
	k_EDualAnalog_Right = 1,
}
public enum EShowUIType
{
	ShowUI_ControllerBinding = 0,
	ShowUI_ManageTrackers = 1,
	ShowUI_Pairing = 3,
	ShowUI_Settings = 4,
	ShowUI_DebugCommands = 5,
}
public enum EHDCPError
{
	None = 0,
	LinkLost = 1,
	Tampered = 2,
	DeviceRevoked = 3,
	Unknown = 4,
}
public enum EVROverlayError
{
	None = 0,
	UnknownOverlay = 10,
	InvalidHandle = 11,
	PermissionDenied = 12,
	OverlayLimitExceeded = 13,
	WrongVisibilityType = 14,
	KeyTooLong = 15,
	NameTooLong = 16,
	KeyInUse = 17,
	WrongTransformType = 18,
	InvalidTrackedDevice = 19,
	InvalidParameter = 20,
	ThumbnailCantBeDestroyed = 21,
	ArrayTooSmall = 22,
	RequestFailed = 23,
	InvalidTexture = 24,
	UnableToLoadFile = 25,
	KeyboardAlreadyInUse = 26,
	NoNeighbor = 27,
	TooManyMaskPrimitives = 29,
	BadMaskPrimitive = 30,
	TextureAlreadyLocked = 31,
	TextureLockCapacityReached = 32,
	TextureNotLocked = 33,
}
public enum EVRInitError
{
	None = 0,
	Unknown = 1,
	Init_InstallationNotFound = 100,
	Init_InstallationCorrupt = 101,
	Init_VRClientDLLNotFound = 102,
	Init_FileNotFound = 103,
	Init_FactoryNotFound = 104,
	Init_InterfaceNotFound = 105,
	Init_InvalidInterface = 106,
	Init_UserConfigDirectoryInvalid = 107,
	Init_HmdNotFound = 108,
	Init_NotInitialized = 109,
	Init_PathRegistryNotFound = 110,
	Init_NoConfigPath = 111,
	Init_NoLogPath = 112,
	Init_PathRegistryNotWritable = 113,
	Init_AppInfoInitFailed = 114,
	Init_Retry = 115,
	Init_InitCanceledByUser = 116,
	Init_AnotherAppLaunching = 117,
	Init_SettingsInitFailed = 118,
	Init_ShuttingDown = 119,
	Init_TooManyObjects = 120,
	Init_NoServerForBackgroundApp = 121,
	Init_NotSupportedWithCompositor = 122,
	Init_NotAvailableToUtilityApps = 123,
	Init_Internal = 124,
	Init_HmdDriverIdIsNone = 125,
	Init_HmdNotFoundPresenceFailed = 126,
	Init_VRMonitorNotFound = 127,
	Init_VRMonitorStartupFailed = 128,
	Init_LowPowerWatchdogNotSupported = 129,
	Init_InvalidApplicationType = 130,
	Init_NotAvailableToWatchdogApps = 131,
	Init_WatchdogDisabledInSettings = 132,
	Init_VRDashboardNotFound = 133,
	Init_VRDashboardStartupFailed = 134,
	Init_VRHomeNotFound = 135,
	Init_VRHomeStartupFailed = 136,
	Init_RebootingBusy = 137,
	Init_FirmwareUpdateBusy = 138,
	Init_FirmwareRecoveryBusy = 139,
	Init_USBServiceBusy = 140,
	Init_VRWebHelperStartupFailed = 141,
	Init_TrackerManagerInitFailed = 142,
	Init_AlreadyRunning = 143,
	Init_FailedForVrMonitor = 144,
	Init_PropertyManagerInitFailed = 145,
	Init_WebServerFailed = 146,
	Driver_Failed = 200,
	Driver_Unknown = 201,
	Driver_HmdUnknown = 202,
	Driver_NotLoaded = 203,
	Driver_RuntimeOutOfDate = 204,
	Driver_HmdInUse = 205,
	Driver_NotCalibrated = 206,
	Driver_CalibrationInvalid = 207,
	Driver_HmdDisplayNotFound = 208,
	Driver_TrackedDeviceInterfaceUnknown = 209,
	Driver_HmdDriverIdOutOfBounds = 211,
	Driver_HmdDisplayMirrored = 212,
	Driver_HmdDisplayNotFoundLaptop = 213,
	IPC_ServerInitFailed = 300,
	IPC_ConnectFailed = 301,
	IPC_SharedStateInitFailed = 302,
	IPC_CompositorInitFailed = 303,
	IPC_MutexInitFailed = 304,
	IPC_Failed = 305,
	IPC_CompositorConnectFailed = 306,
	IPC_CompositorInvalidConnectResponse = 307,
	IPC_ConnectFailedAfterMultipleAttempts = 308,
	IPC_ConnectFailedAfterTargetExited = 309,
	IPC_NamespaceUnavailable = 310,
	Compositor_Failed = 400,
	Compositor_D3D11HardwareRequired = 401,
	Compositor_FirmwareRequiresUpdate = 402,
	Compositor_OverlayInitFailed = 403,
	Compositor_ScreenshotsInitFailed = 404,
	Compositor_UnableToCreateDevice = 405,
	Compositor_SharedStateIsNull = 406,
	Compositor_NotificationManagerIsNull = 407,
	Compositor_ResourceManagerClientIsNull = 408,
	Compositor_MessageOverlaySharedStateInitFailure = 409,
	Compositor_PropertiesInterfaceIsNull = 410,
	Compositor_CreateFullscreenWindowFailed = 411,
	Compositor_SettingsInterfaceIsNull = 412,
	Compositor_FailedToShowWindow = 413,
	Compositor_DistortInterfaceIsNull = 414,
	Compositor_DisplayFrequencyFailure = 415,
	Compositor_RendererInitializationFailed = 416,
	Compositor_DXGIFactoryInterfaceIsNull = 417,
	Compositor_DXGIFactoryCreateFailed = 418,
	Compositor_DXGIFactoryQueryFailed = 419,
	Compositor_InvalidAdapterDesktop = 420,
	Compositor_InvalidHmdAttachment = 421,
	Compositor_InvalidOutputDesktop = 422,
	Compositor_InvalidDeviceProvided = 423,
	Compositor_D3D11RendererInitializationFailed = 424,
	Compositor_FailedToFindDisplayMode = 425,
	Compositor_FailedToCreateSwapChain = 426,
	Compositor_FailedToGetBackBuffer = 427,
	Compositor_FailedToCreateRenderTarget = 428,
	Compositor_FailedToCreateDXGI2SwapChain = 429,
	Compositor_FailedtoGetDXGI2BackBuffer = 430,
	Compositor_FailedToCreateDXGI2RenderTarget = 431,
	Compositor_FailedToGetDXGIDeviceInterface = 432,
	Compositor_SelectDisplayMode = 433,
	Compositor_FailedToCreateNvAPIRenderTargets = 434,
	Compositor_NvAPISetDisplayMode = 435,
	Compositor_FailedToCreateDirectModeDisplay = 436,
	Compositor_InvalidHmdPropertyContainer = 437,
	Compositor_UpdateDisplayFrequency = 438,
	Compositor_CreateRasterizerState = 439,
	Compositor_CreateWireframeRasterizerState = 440,
	Compositor_CreateSamplerState = 441,
	Compositor_CreateClampToBorderSamplerState = 442,
	Compositor_CreateAnisoSamplerState = 443,
	Compositor_CreateOverlaySamplerState = 444,
	Compositor_CreatePanoramaSamplerState = 445,
	Compositor_CreateFontSamplerState = 446,
	Compositor_CreateNoBlendState = 447,
	Compositor_CreateBlendState = 448,
	Compositor_CreateAlphaBlendState = 449,
	Compositor_CreateBlendStateMaskR = 450,
	Compositor_CreateBlendStateMaskG = 451,
	Compositor_CreateBlendStateMaskB = 452,
	Compositor_CreateDepthStencilState = 453,
	Compositor_CreateDepthStencilStateNoWrite = 454,
	Compositor_CreateDepthStencilStateNoDepth = 455,
	Compositor_CreateFlushTexture = 456,
	Compositor_CreateDistortionSurfaces = 457,
	Compositor_CreateConstantBuffer = 458,
	Compositor_CreateHmdPoseConstantBuffer = 459,
	Compositor_CreateHmdPoseStagingConstantBuffer = 460,
	Compositor_CreateSharedFrameInfoConstantBuffer = 461,
	Compositor_CreateOverlayConstantBuffer = 462,
	Compositor_CreateSceneTextureIndexConstantBuffer = 463,
	Compositor_CreateReadableSceneTextureIndexConstantBuffer = 464,
	Compositor_CreateLayerGraphicsTextureIndexConstantBuffer = 465,
	Compositor_CreateLayerComputeTextureIndexConstantBuffer = 466,
	Compositor_CreateLayerComputeSceneTextureIndexConstantBuffer = 467,
	Compositor_CreateComputeHmdPoseConstantBuffer = 468,
	Compositor_CreateGeomConstantBuffer = 469,
	Compositor_CreatePanelMaskConstantBuffer = 470,
	Compositor_CreatePixelSimUBO = 471,
	Compositor_CreateMSAARenderTextures = 472,
	Compositor_CreateResolveRenderTextures = 473,
	Compositor_CreateComputeResolveRenderTextures = 474,
	Compositor_CreateDriverDirectModeResolveTextures = 475,
	Compositor_OpenDriverDirectModeResolveTextures = 476,
	Compositor_CreateFallbackSyncTexture = 477,
	Compositor_ShareFallbackSyncTexture = 478,
	Compositor_CreateOverlayIndexBuffer = 479,
	Compositor_CreateOverlayVertextBuffer = 480,
	Compositor_CreateTextVertexBuffer = 481,
	Compositor_CreateTextIndexBuffer = 482,
	Compositor_CreateMirrorTextures = 483,
	Compositor_CreateLastFrameRenderTexture = 484,
	Compositor_CreateMirrorOverlay = 485,
	Compositor_FailedToCreateVirtualDisplayBackbuffer = 486,
	Compositor_DisplayModeNotSupported = 487,
	VendorSpecific_UnableToConnectToOculusRuntime = 1000,
	VendorSpecific_WindowsNotInDevMode = 1001,
	VendorSpecific_HmdFound_CantOpenDevice = 1101,
	VendorSpecific_HmdFound_UnableToRequestConfigStart = 1102,
	VendorSpecific_HmdFound_NoStoredConfig = 1103,
	VendorSpecific_HmdFound_ConfigTooBig = 1104,
	VendorSpecific_HmdFound_ConfigTooSmall = 1105,
	VendorSpecific_HmdFound_UnableToInitZLib = 1106,
	VendorSpecific_HmdFound_CantReadFirmwareVersion = 1107,
	VendorSpecific_HmdFound_UnableToSendUserDataStart = 1108,
	VendorSpecific_HmdFound_UnableToGetUserDataStart = 1109,
	VendorSpecific_HmdFound_UnableToGetUserDataNext = 1110,
	VendorSpecific_HmdFound_UserDataAddressRange = 1111,
	VendorSpecific_HmdFound_UserDataError = 1112,
	VendorSpecific_HmdFound_ConfigFailedSanityCheck = 1113,
	VendorSpecific_OculusRuntimeBadInstall = 1114,
	Steam_SteamInstallationNotFound = 2000,
	LastError = 2001,
}

public enum EVRTrackedCameraFrameType
{
	Distorted = 0,
	Undistorted = 1,
	MaximumUndistorted = 2,
	MAX_CAMERA_FRAME_TYPES = 3,
}
public enum EVRApplicationError
{
	None = 0,
	AppKeyAlreadyExists = 100,
	NoManifest = 101,
	NoApplication = 102,
	InvalidIndex = 103,
	UnknownApplication = 104,
	IPCFailed = 105,
	ApplicationAlreadyRunning = 106,
	InvalidManifest = 107,
	InvalidApplication = 108,
	LaunchFailed = 109,
	ApplicationAlreadyStarting = 110,
	LaunchInProgress = 111,
	OldApplicationQuitting = 112,
	TransitionAborted = 113,
	IsTemplate = 114,
	SteamVRIsExiting = 115,
	BufferTooSmall = 200,
	PropertyNotSet = 201,
	UnknownProperty = 202,
	InvalidParameter = 203,
}
public enum EVRApplicationProperty
{
	Name_String = 0,
	LaunchType_String = 11,
	WorkingDirectory_String = 12,
	BinaryPath_String = 13,
	Arguments_String = 14,
	URL_String = 15,
	Description_String = 50,
	NewsURL_String = 51,
	ImagePath_String = 52,
	Source_String = 53,
	ActionManifestURL_String = 54,
	IsDashboardOverlay_Bool = 60,
	IsTemplate_Bool = 61,
	IsInstanced_Bool = 62,
	IsInternal_Bool = 63,
	WantsCompositorPauseInStandby_Bool = 64,
	IsHidden_Bool = 65,
	LastLaunchTime_Uint64 = 70,
}
public enum EVRSceneApplicationState
{
	None = 0,
	Starting = 1,
	Quitting = 2,
	Running = 3,
	Waiting = 4,
}
public enum EVRCompositorError
{
	None = 0,
	RequestFailed = 1,
	IncompatibleVersion = 100,
	DoNotHaveFocus = 101,
	InvalidTexture = 102,
	IsNotSceneApplication = 103,
	TextureIsOnWrongDevice = 104,
	TextureUsesUnsupportedFormat = 105,
	SharedTexturesNotSupported = 106,
	IndexOutOfRange = 107,
	AlreadySubmitted = 108,
	InvalidBounds = 109,
}
public enum EVRCompositorTimingMode
{
	Implicit = 0,
	Explicit_RuntimePerformsPostPresentHandoff = 1,
	Explicit_ApplicationPerformsPostPresentHandoff = 2,
}
public enum VROverlayInputMethod
{
	None = 0,
	Mouse = 1,
	DualAnalog = 2,
}
public enum VROverlayTransformType
{
	VROverlayTransform_Absolute = 0,
	VROverlayTransform_TrackedDeviceRelative = 1,
	VROverlayTransform_SystemOverlay = 2,
	VROverlayTransform_TrackedComponent = 3,
}
public enum VROverlayFlags
{
	NoDashboardTab = 8,
	SendVRDiscreteScrollEvents = 64,
	SendVRTouchpadEvents = 128,
	ShowTouchPadScrollWheel = 256,
	TransferOwnershipToInternalProcess = 512,
	SideBySide_Parallel = 1024,
	SideBySide_Crossed = 2048,
	Panorama = 4096,
	StereoPanorama = 8192,
	SortWithNonSceneOverlays = 16384,
	VisibleInDashboard = 32768,
	MakeOverlaysInteractiveIfVisible = 65536,
	SendVRSmoothScrollEvents = 131072,
	ProtectedContent = 262144,
	HideLaserIntersection = 524288,
}
public enum VRMessageOverlayResponse
{
	ButtonPress_0 = 0,
	ButtonPress_1 = 1,
	ButtonPress_2 = 2,
	ButtonPress_3 = 3,
	CouldntFindSystemOverlay = 4,
	CouldntFindOrCreateClientOverlay = 5,
	ApplicationQuit = 6,
}
public enum EVROverlayIntersectionMaskPrimitiveType
{
	OverlayIntersectionPrimitiveType_Rectangle = 0,
	OverlayIntersectionPrimitiveType_Circle = 1,
}

[StructLayout(LayoutKind.Explicit)] public struct VREvent_Data_t
{
	[FieldOffset(0)] public VREvent_Reserved_t reserved;
	[FieldOffset(0)] public VREvent_Controller_t controller;
	[FieldOffset(0)] public VREvent_Mouse_t mouse;
	[FieldOffset(0)] public VREvent_Scroll_t scroll;
	[FieldOffset(0)] public VREvent_Process_t process;
	[FieldOffset(0)] public VREvent_Notification_t notification;
	[FieldOffset(0)] public VREvent_Overlay_t overlay;
	[FieldOffset(0)] public VREvent_Status_t status;
	[FieldOffset(0)] public VREvent_Ipd_t ipd;
	[FieldOffset(0)] public VREvent_Chaperone_t chaperone;
	[FieldOffset(0)] public VREvent_PerformanceTest_t performanceTest;
	[FieldOffset(0)] public VREvent_TouchPadMove_t touchPadMove;
	[FieldOffset(0)] public VREvent_SeatedZeroPoseReset_t seatedZeroPoseReset;
	[FieldOffset(0)] public VREvent_Screenshot_t screenshot;
	[FieldOffset(0)] public VREvent_ScreenshotProgress_t screenshotProgress;
	[FieldOffset(0)] public VREvent_ApplicationLaunch_t applicationLaunch;
	[FieldOffset(0)] public VREvent_EditingCameraSurface_t cameraSurface;
	[FieldOffset(0)] public VREvent_MessageOverlay_t messageOverlay;
	[FieldOffset(0)] public VREvent_Property_t property;
	[FieldOffset(0)] public VREvent_DualAnalog_t dualAnalog;
	[FieldOffset(0)] public VREvent_HapticVibration_t hapticVibration;
	[FieldOffset(0)] public VREvent_WebConsole_t webConsole;
	[FieldOffset(0)] public VREvent_InputBindingLoad_t inputBinding;
	[FieldOffset(0)] public VREvent_SpatialAnchor_t spatialAnchor;
	[FieldOffset(0)] public VREvent_InputActionManifestLoad_t actionManifest;
	[FieldOffset(0)] public VREvent_ProgressUpdate_t progressUpdate;
	[FieldOffset(0)] public VREvent_ShowUI_t showUi;
	[FieldOffset(0)] public VREvent_ShowDevTools_t showDevTools;
	[FieldOffset(0)] public VREvent_HDCPError_t hdcpError;
	[FieldOffset(0)] public VREvent_Keyboard_t keyboard; // This has to be at the end due to a mono bug
}


[StructLayout(LayoutKind.Explicit)] public struct VROverlayIntersectionMaskPrimitive_Data_t
{
	[FieldOffset(0)] public IntersectionMaskRectangle_t m_Rectangle;
	[FieldOffset(0)] public IntersectionMaskCircle_t m_Circle;
}

[StructLayout(LayoutKind.Sequential)] public struct HmdMatrix34_t
{
	public float m0; //float[3][4]
	public float m1;
	public float m2;
	public float m3;
	public float m4;
	public float m5;
	public float m6;
	public float m7;
	public float m8;
	public float m9;
	public float m10;
	public float m11;
}

[StructLayout(LayoutKind.Sequential)] public struct HmdMatrix44_t
{
	public float m0; //float[4][4]
	public float m1;
	public float m2;
	public float m3;
	public float m4;
	public float m5;
	public float m6;
	public float m7;
	public float m8;
	public float m9;
	public float m10;
	public float m11;
	public float m12;
	public float m13;
	public float m14;
	public float m15;
}
[StructLayout(LayoutKind.Sequential)] public struct HmdVector3_t
{
	public float v0; //float[3]
	public float v1;
	public float v2;
}
[StructLayout(LayoutKind.Sequential)] public struct HmdVector4_t
{
	public float v0; //float[4]
	public float v1;
	public float v2;
	public float v3;
}

[StructLayout(LayoutKind.Sequential)] public struct HmdVector2_t
{
	public float v0; //float[2]
	public float v1;
}

[StructLayout(LayoutKind.Sequential)] public struct HmdQuaternionf_t
{
	public float w;
	public float x;
	public float y;
	public float z;
}
[StructLayout(LayoutKind.Sequential)] public struct HmdColor_t
{
	public float r;
	public float g;
	public float b;
	public float a;
}
[StructLayout(LayoutKind.Sequential)] public struct HmdQuad_t
{
	public HmdVector3_t vCorners0; //HmdVector3_t[4]
	public HmdVector3_t vCorners1;
	public HmdVector3_t vCorners2;
	public HmdVector3_t vCorners3;
}
[StructLayout(LayoutKind.Sequential)] public struct HmdRect2_t
{
	public HmdVector2_t vTopLeft;
	public HmdVector2_t vBottomRight;
}

[StructLayout(LayoutKind.Sequential)] public struct Texture_t
{
	public IntPtr handle; // void *
	public ETextureType eType;
	public EColorSpace eColorSpace;
}
[StructLayout(LayoutKind.Sequential)] public struct TrackedDevicePose_t
{
	public HmdMatrix34_t mDeviceToAbsoluteTracking;
	public HmdVector3_t vVelocity;
	public HmdVector3_t vAngularVelocity;
	public ETrackingResult eTrackingResult;
	[MarshalAs(UnmanagedType.I1)]
	public bool bPoseIsValid;
	[MarshalAs(UnmanagedType.I1)]
	public bool bDeviceIsConnected;
}
[StructLayout(LayoutKind.Sequential)] public struct VRTextureBounds_t
{
	public float uMin;
	public float vMin;
	public float uMax;
	public float vMax;
}

[StructLayout(LayoutKind.Sequential)] public struct VREvent_Controller_t
{
	public uint button;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Mouse_t
{
	public float x;
	public float y;
	public uint button;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Scroll_t
{
	public float xdelta;
	public float ydelta;
	public uint unused;
	public float viewportscale;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_TouchPadMove_t
{
	[MarshalAs(UnmanagedType.I1)]
	public bool bFingerDown;
	public float flSecondsFingerDown;
	public float fValueXFirst;
	public float fValueYFirst;
	public float fValueXRaw;
	public float fValueYRaw;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Notification_t
{
	public ulong ulUserValue;
	public uint notificationId;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Process_t
{
	public uint pid;
	public uint oldPid;
	[MarshalAs(UnmanagedType.I1)]
	public bool bForced;
	[MarshalAs(UnmanagedType.I1)]
	public bool bConnectionLost;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Overlay_t
{
	public ulong overlayHandle;
	public ulong devicePath;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Status_t
{
	public uint statusState;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Keyboard_t
{
	public byte cNewInput0,cNewInput1,cNewInput2,cNewInput3,cNewInput4,cNewInput5,cNewInput6,cNewInput7;
	public ulong uUserValue;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Ipd_t
{
	public float ipdMeters;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Chaperone_t
{
	public ulong m_nPreviousUniverse;
	public ulong m_nCurrentUniverse;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Reserved_t
{
	public ulong reserved0;
	public ulong reserved1;
	public ulong reserved2;
	public ulong reserved3;
	public ulong reserved4;
	public ulong reserved5;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_PerformanceTest_t
{
	public uint m_nFidelityLevel;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_SeatedZeroPoseReset_t
{
	[MarshalAs(UnmanagedType.I1)]
	public bool bResetBySystemMenu;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Screenshot_t
{
	public uint handle;
	public uint type;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_ScreenshotProgress_t
{
	public float progress;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_ApplicationLaunch_t
{
	public uint pid;
	public uint unArgsHandle;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_EditingCameraSurface_t
{
	public ulong overlayHandle;
	public uint nVisualMode;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_MessageOverlay_t
{
	public uint unVRMessageOverlayResponse;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Property_t
{
	public ulong container;
	public ETrackedDeviceProperty prop;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_DualAnalog_t
{
	public float x;
	public float y;
	public float transformedX;
	public float transformedY;
	public EDualAnalogWhich which;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_HapticVibration_t
{
	public ulong containerHandle;
	public ulong componentHandle;
	public float fDurationSeconds;
	public float fFrequency;
	public float fAmplitude;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_WebConsole_t
{
	public ulong webConsoleHandle;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_InputBindingLoad_t
{
	public ulong ulAppContainer;
	public ulong pathMessage;
	public ulong pathUrl;
	public ulong pathControllerType;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_InputActionManifestLoad_t
{
	public ulong pathAppKey;
	public ulong pathMessage;
	public ulong pathMessageParam;
	public ulong pathManifestPath;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_SpatialAnchor_t
{
	public uint unHandle;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_ProgressUpdate_t
{
	public ulong ulApplicationPropertyContainer;
	public ulong pathDevice;
	public ulong pathInputSource;
	public ulong pathProgressAction;
	public ulong pathIcon;
	public float fProgress;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_ShowUI_t
{
	public EShowUIType eType;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_ShowDevTools_t
{
	public int nBrowserIdentifier;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_HDCPError_t
{
	public EHDCPError eCode;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_t
{
	public uint eventType;
	public uint trackedDeviceIndex;
	public float eventAgeSeconds;
	public VREvent_Data_t data;
}
// This structure is for backwards binary compatibility on Linux and OSX only
	[StructLayout(LayoutKind.Sequential)] public struct VRControllerAxis_t
{
	public float x;
	public float y;
}

// This structure is for backwards binary compatibility on Linux and OSX only

	[StructLayout(LayoutKind.Sequential)] public struct Compositor_FrameTiming
{
	public uint m_nSize;
	public uint m_nFrameIndex;
	public uint m_nNumFramePresents;
	public uint m_nNumMisPresented;
	public uint m_nNumDroppedFrames;
	public uint m_nReprojectionFlags;
	public double m_flSystemTimeInSeconds;
	public float m_flPreSubmitGpuMs;
	public float m_flPostSubmitGpuMs;
	public float m_flTotalRenderGpuMs;
	public float m_flCompositorRenderGpuMs;
	public float m_flCompositorRenderCpuMs;
	public float m_flCompositorIdleCpuMs;
	public float m_flClientFrameIntervalMs;
	public float m_flPresentCallCpuMs;
	public float m_flWaitForPresentCpuMs;
	public float m_flSubmitFrameMs;
	public float m_flWaitGetPosesCalledMs;
	public float m_flNewPosesReadyMs;
	public float m_flNewFrameReadyMs;
	public float m_flCompositorUpdateStartMs;
	public float m_flCompositorUpdateEndMs;
	public float m_flCompositorRenderStartMs;
	public TrackedDevicePose_t m_HmdPose;
	public uint m_nNumVSyncsReadyForUse;
	public uint m_nNumVSyncsToFirstView;
}
[StructLayout(LayoutKind.Sequential)] public struct AppOverrideKeys_t
{
	public IntPtr pchKey; // const char *
	public IntPtr pchValue; // const char *
}
[StructLayout(LayoutKind.Sequential)] public struct Compositor_CumulativeStats
{
	public uint m_nPid;
	public uint m_nNumFramePresents;
	public uint m_nNumDroppedFrames;
	public uint m_nNumReprojectedFrames;
	public uint m_nNumFramePresentsOnStartup;
	public uint m_nNumDroppedFramesOnStartup;
	public uint m_nNumReprojectedFramesOnStartup;
	public uint m_nNumLoading;
	public uint m_nNumFramePresentsLoading;
	public uint m_nNumDroppedFramesLoading;
	public uint m_nNumReprojectedFramesLoading;
	public uint m_nNumTimedOut;
	public uint m_nNumFramePresentsTimedOut;
	public uint m_nNumDroppedFramesTimedOut;
	public uint m_nNumReprojectedFramesTimedOut;
}
[StructLayout(LayoutKind.Sequential)] public struct VROverlayIntersectionParams_t
{
	public HmdVector3_t vSource;
	public HmdVector3_t vDirection;
	public ETrackingUniverseOrigin eOrigin;
}
[StructLayout(LayoutKind.Sequential)] public struct VROverlayIntersectionResults_t
{
	public HmdVector3_t vPoint;
	public HmdVector3_t vNormal;
	public HmdVector2_t vUVs;
	public float fDistance;
}
[StructLayout(LayoutKind.Sequential)] public struct IntersectionMaskRectangle_t
{
	public float m_flTopLeftX;
	public float m_flTopLeftY;
	public float m_flWidth;
	public float m_flHeight;
}
[StructLayout(LayoutKind.Sequential)] public struct IntersectionMaskCircle_t
{
	public float m_flCenterX;
	public float m_flCenterY;
	public float m_flRadius;
}
[StructLayout(LayoutKind.Sequential)] public struct VROverlayIntersectionMaskPrimitive_t
{
	public EVROverlayIntersectionMaskPrimitiveType m_nPrimitiveType;
	public VROverlayIntersectionMaskPrimitive_Data_t m_Primitive;
}

public class OpenVR
{

	public static void ShutdownInternal()
	{
		OpenVRInterop.ShutdownInternal();
	}

	public static uint GetInitToken()
	{
		return OpenVRInterop.GetInitToken();
	}

	public const ulong k_ulOverlayHandleInvalid = 0;
	public const string IVRApplications_Version = "IVRApplications_007";
	public const string IVRCompositor_Version = "IVRCompositor_022";
	public const string IVROverlay_Version = "IVROverlay_021";

	static uint VRToken { get; set; }

	const string FnTable_Prefix = "FnTable:";

	class COpenVRContext
	{
		public COpenVRContext() { Clear(); }

		public void Clear()
		{
			m_pVRCompositor = null;
			m_pVROverlay = null;
			m_pVRApplications = null;
		}

		void CheckClear()
		{
			if (VRToken != GetInitToken())
			{
				Clear();
				VRToken = GetInitToken();
			}
		}

		public CVRCompositor VRCompositor()
		{
			CheckClear();
			if (m_pVRCompositor == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRCompositor_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRCompositor = new CVRCompositor(pInterface);
			}
			return m_pVRCompositor;
		}

		public CVROverlay VROverlay()
		{
			CheckClear();
			if (m_pVROverlay == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVROverlay_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVROverlay = new CVROverlay(pInterface);
			}
			return m_pVROverlay;
		}

		public CVRApplications VRApplications()
		{
			CheckClear();
			if (m_pVRApplications == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRApplications_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRApplications = new CVRApplications(pInterface);
			}
			return m_pVRApplications;
		}
		
		private CVRApplications m_pVRApplications;
		private CVROverlay m_pVROverlay;
		private CVRCompositor m_pVRCompositor;
	};

	private static COpenVRContext _OpenVRInternal_ModuleContext = null;
	static COpenVRContext OpenVRInternal_ModuleContext
	{
		get
		{
			if (_OpenVRInternal_ModuleContext == null)
				_OpenVRInternal_ModuleContext = new COpenVRContext();
			return _OpenVRInternal_ModuleContext;
		}
	}

	public static CVRCompositor Compositor => OpenVRInternal_ModuleContext.VRCompositor();
	public static CVROverlay Overlay => OpenVRInternal_ModuleContext.VROverlay();
	public static CVRApplications Applications => OpenVRInternal_ModuleContext.VRApplications();


	/** Finds the active installation of vrclient.dll and initializes it */

	/** unloads vrclient.dll. Any interface pointers from the interface are
	* invalid after this point */
	public static void Shutdown()
	{
		ShutdownInternal();
	}

}



}

