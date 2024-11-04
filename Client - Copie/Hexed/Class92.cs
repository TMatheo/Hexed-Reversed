using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using VRC.Economy.Internal;
using VRC.SDKBase;

// Token: 0x020000D5 RID: 213
internal class Class92 : Interface3
{
	// Token: 0x060004A6 RID: 1190 RVA: 0x00017970 File Offset: 0x00015B70
	public void Initialize()
	{
		MethodInfo method = typeof(Store).GetMethod("Method_Private_Boolean_VRCPlayerApi_IProduct_PDM_0");
		Class92.Delegate23 detour;
		if ((detour = Class92.<>O.delegate23_0) == null)
		{
			detour = (Class92.<>O.delegate23_0 = new Class92.Delegate23(Class92.Patch));
		}
		Class92.delegate23_0 = HookManager.Detour<Class92.Delegate23>(method, detour);
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x000179B8 File Offset: 0x00015BB8
	private static bool Patch(IntPtr instance, IntPtr __0, IntPtr __1)
	{
		VRCPlayerApi vrcplayerApi = (__0 == IntPtr.Zero) ? null : new VRCPlayerApi(__0);
		return (vrcplayerApi != null && vrcplayerApi.isLocal) || Class92.delegate23_0(instance, __0, __1);
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x00003116 File Offset: 0x00001316
	internal static bool VGGoflTdCbXCya7qALO()
	{
		return Class92.U04Sx1TVkoOqkA2hbg7 == null;
	}

	// Token: 0x0400023A RID: 570
	private static Class92.Delegate23 delegate23_0;

	// Token: 0x0400023B RID: 571
	private static Class92 U04Sx1TVkoOqkA2hbg7;

	// Token: 0x020000D6 RID: 214
	// (Invoke) Token: 0x060004AB RID: 1195
	private delegate bool Delegate23(IntPtr instance, IntPtr __0, IntPtr __1);

	// Token: 0x020000D7 RID: 215
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400023C RID: 572
		public static Class92.Delegate23 delegate23_0;
	}
}
