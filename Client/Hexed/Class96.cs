using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using Hexed.Wrappers;
using VRC.Networking;
using VRC.SDKBase;

// Token: 0x020000E2 RID: 226
internal class Class96 : Interface3
{
	// Token: 0x060004CF RID: 1231 RVA: 0x0001801C File Offset: 0x0001621C
	public void Initialize()
	{
		MethodInfo method = typeof(UdonClientStringDownloader).GetMethod("Method_Private_Static_Void_VRCUrl_IUdonEventReceiver_PDM_0");
		Class96.Delegate27 detour;
		if ((detour = Class96.<>O.delegate27_0) == null)
		{
			detour = (Class96.<>O.delegate27_0 = new Class96.Delegate27(Class96.Patch));
		}
		Class96.delegate27_0 = HookManager.Detour<Class96.Delegate27>(method, detour);
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x00018064 File Offset: 0x00016264
	private static void Patch(IntPtr __0, IntPtr __1)
	{
		VRCUrl vrcurl = (__0 == IntPtr.Zero) ? null : new VRCUrl(__0);
		if (vrcurl != null)
		{
			if (Class143.bool_15)
			{
				Logger.Log("Udon tried to download a string from " + vrcurl.url, Logger.LogsType.Protection);
				return;
			}
			Logger.Log("Udon downloaded a string from " + vrcurl.url, Logger.LogsType.Room);
		}
		Class96.delegate27_0(__0, __1);
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x0000316C File Offset: 0x0000136C
	internal static bool mjbrqrTfcsvxGIvHbgu()
	{
		return Class96.cw7lEeTGV4O42Vm7WZs == null;
	}

	// Token: 0x0400024B RID: 587
	private static Class96.Delegate27 delegate27_0;

	// Token: 0x0400024C RID: 588
	private static Class96 cw7lEeTGV4O42Vm7WZs;

	// Token: 0x020000E3 RID: 227
	// (Invoke) Token: 0x060004D4 RID: 1236
	private delegate void Delegate27(IntPtr __0, IntPtr __1);

	// Token: 0x020000E4 RID: 228
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400024D RID: 589
		public static Class96.Delegate27 delegate27_0;
	}
}
