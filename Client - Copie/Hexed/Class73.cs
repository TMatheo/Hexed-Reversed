using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;

// Token: 0x02000096 RID: 150
internal class Class73
{
	// Token: 0x060003F9 RID: 1017 RVA: 0x00015FC0 File Offset: 0x000141C0
	public void Initialize()
	{
		MethodInfo method = typeof(CameraNameplate).GetMethod("Method_Private_Void_2");
		Class73.Delegate3 detour;
		if ((detour = Class73.<>O.delegate3_0) == null)
		{
			detour = (Class73.<>O.delegate3_0 = new Class73.Delegate3(Class73.Patch));
		}
		Class73.delegate3_0 = HookManager.Detour<Class73.Delegate3>(method, detour);
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x00016008 File Offset: 0x00014208
	private static void Patch(IntPtr instance)
	{
		CameraNameplate cameraNameplate = (instance == IntPtr.Zero) ? null : new CameraNameplate(instance);
		if (cameraNameplate != null)
		{
			Interface4 playerModuleByClass = Class142.GetPlayerModuleByClass(cameraNameplate.field_Private_VRCPlayer_0.GetPhotonPlayer().ActorID(), typeof(Class41));
			if (playerModuleByClass != null)
			{
				((Class41)playerModuleByClass).UpdateCameraPlate(cameraNameplate);
			}
		}
		Class73.delegate3_0(instance);
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x0000301E File Offset: 0x0000121E
	internal static bool VsUw3baXE579jNhsROR()
	{
		return Class73.oOpSI7aF5DurBt00yma == null;
	}

	// Token: 0x040001F3 RID: 499
	private static Class73.Delegate3 delegate3_0;

	// Token: 0x040001F4 RID: 500
	private static Class73 oOpSI7aF5DurBt00yma;

	// Token: 0x02000097 RID: 151
	// (Invoke) Token: 0x060003FE RID: 1022
	private delegate void Delegate3(IntPtr instance);

	// Token: 0x02000098 RID: 152
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040001F5 RID: 501
		public static Class73.Delegate3 delegate3_0;
	}
}
