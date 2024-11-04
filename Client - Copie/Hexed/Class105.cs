using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using Hexed.Wrappers;
using VRC.SDK3.Video.Components;
using VRC.SDKBase;

// Token: 0x020000FD RID: 253
internal class Class105 : Interface3
{
	// Token: 0x06000517 RID: 1303 RVA: 0x0001A088 File Offset: 0x00018288
	public void Initialize()
	{
		MethodInfo method = typeof(VRCUnityVideoPlayer).GetMethod("LoadURL");
		Class105.Delegate36 detour;
		if ((detour = Class105.<>O.delegate36_0) == null)
		{
			detour = (Class105.<>O.delegate36_0 = new Class105.Delegate36(Class105.Patch));
		}
		Class105.delegate36_0 = HookManager.Detour<Class105.Delegate36>(method, detour);
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x0001A0D0 File Offset: 0x000182D0
	private static void Patch(IntPtr instance, IntPtr __0)
	{
		VRCUrl vrcurl = (__0 == IntPtr.Zero) ? null : new VRCUrl(__0);
		if (vrcurl == null)
		{
			return;
		}
		if (!Class143.bool_18)
		{
			Logger.Log("Video loading from " + vrcurl.url, Logger.LogsType.Room);
			Class105.delegate36_0(instance, __0);
			return;
		}
		Logger.Log("Video tried loading from " + vrcurl.url, Logger.LogsType.Protection);
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x000031C6 File Offset: 0x000013C6
	internal static bool btZG3YTI9CgUKfFU6G6()
	{
		return Class105.sEbZRaTTa6lUZyZ2BoY == null;
	}

	// Token: 0x04000266 RID: 614
	private static Class105.Delegate36 delegate36_0;

	// Token: 0x04000267 RID: 615
	internal static Class105 sEbZRaTTa6lUZyZ2BoY;

	// Token: 0x020000FE RID: 254
	// (Invoke) Token: 0x0600051C RID: 1308
	private delegate void Delegate36(IntPtr instance, IntPtr __0);

	// Token: 0x020000FF RID: 255
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000268 RID: 616
		public static Class105.Delegate36 delegate36_0;
	}
}
