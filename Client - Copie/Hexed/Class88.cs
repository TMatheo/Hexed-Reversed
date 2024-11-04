using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;

// Token: 0x020000C9 RID: 201
internal class Class88 : Interface3
{
	// Token: 0x06000486 RID: 1158 RVA: 0x00017554 File Offset: 0x00015754
	public void Initialize()
	{
		MethodInfo method = typeof(PlayerNet).GetMethod("OnNetworkReady");
		Class88.Delegate19 detour;
		if ((detour = Class88.<>O.delegate19_0) == null)
		{
			detour = (Class88.<>O.delegate19_0 = new Class88.Delegate19(Class88.Patch));
		}
		Class88.delegate19_0 = HookManager.Detour<Class88.Delegate19>(method, detour);
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x0001759C File Offset: 0x0001579C
	private static void Patch(IntPtr instance)
	{
		Class88.delegate19_0(instance);
		PlayerNet playerNet = (instance == IntPtr.Zero) ? null : new PlayerNet(instance);
		if (playerNet == null)
		{
			return;
		}
		Class142.CreatePlayerModules(playerNet.GetVRCPlayer());
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x000030EE File Offset: 0x000012EE
	internal static bool z3SSK9ToFFU5XOYiJtf()
	{
		return Class88.y4l5ZrTppKOtQZi7nUa == null;
	}

	// Token: 0x0400022E RID: 558
	private static Class88.Delegate19 delegate19_0;

	// Token: 0x0400022F RID: 559
	private static Class88 y4l5ZrTppKOtQZi7nUa;

	// Token: 0x020000CA RID: 202
	// (Invoke) Token: 0x0600048B RID: 1163
	private delegate void Delegate19(IntPtr instance);

	// Token: 0x020000CB RID: 203
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000230 RID: 560
		public static Class88.Delegate19 delegate19_0;
	}
}
