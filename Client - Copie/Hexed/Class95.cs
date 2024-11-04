using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using Hexed.Wrappers;
using VRC.Networking;
using VRC.SDKBase;

// Token: 0x020000DF RID: 223
internal class Class95 : Interface3
{
	// Token: 0x060004C7 RID: 1223 RVA: 0x00017F64 File Offset: 0x00016164
	public void Initialize()
	{
		MethodInfo method = typeof(UdonClientImageDownloader).GetMethod("Method_Public_Static_IVRCImageDownload_VRCUrl_Material_IUdonEventReceiver_TextureInfo_PDM_0");
		Class95.Delegate26 detour;
		if ((detour = Class95.<>O.delegate26_0) == null)
		{
			detour = (Class95.<>O.delegate26_0 = new Class95.Delegate26(Class95.Patch));
		}
		Class95.delegate26_0 = HookManager.Detour<Class95.Delegate26>(method, detour);
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x00017FAC File Offset: 0x000161AC
	private static IntPtr Patch(IntPtr __0, IntPtr __1, IntPtr __2, IntPtr __3)
	{
		VRCUrl vrcurl = (__0 == IntPtr.Zero) ? null : new VRCUrl(__0);
		if (vrcurl != null)
		{
			if (Class143.bool_15)
			{
				Logger.Log("Udon tried to download a image from " + vrcurl.url, Logger.LogsType.Protection);
				return IntPtr.Zero;
			}
			Logger.Log("Udon downloaded a image from " + vrcurl.url, Logger.LogsType.Room);
		}
		return Class95.delegate26_0(__0, __1, __2, __3);
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x00003162 File Offset: 0x00001362
	internal static bool TVqEPeTcxBGfa337Jdr()
	{
		return Class95.J2lAeIT5Cvsu7N53ldA == null;
	}

	// Token: 0x04000248 RID: 584
	private static Class95.Delegate26 delegate26_0;

	// Token: 0x04000249 RID: 585
	internal static Class95 J2lAeIT5Cvsu7N53ldA;

	// Token: 0x020000E0 RID: 224
	// (Invoke) Token: 0x060004CC RID: 1228
	private delegate IntPtr Delegate26(IntPtr __0, IntPtr __1, IntPtr __2, IntPtr __3);

	// Token: 0x020000E1 RID: 225
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400024A RID: 586
		public static Class95.Delegate26 delegate26_0;
	}
}
