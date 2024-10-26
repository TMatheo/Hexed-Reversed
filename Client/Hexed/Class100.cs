using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;

// Token: 0x020000EE RID: 238
internal class Class100 : Interface3
{
	// Token: 0x060004EF RID: 1263 RVA: 0x000185A4 File Offset: 0x000167A4
	public void Initialize()
	{
		MethodInfo method = typeof(VRCAvatarManager).GetMethod("Update");
		Class100.Delegate31 detour;
		if ((detour = Class100.<>O.delegate31_0) == null)
		{
			detour = (Class100.<>O.delegate31_0 = new Class100.Delegate31(Class100.Patch));
		}
		Class100.delegate31_0 = HookManager.Detour<Class100.Delegate31>(method, detour);
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x000185EC File Offset: 0x000167EC
	private static void Patch(IntPtr instance)
	{
		Class100.delegate31_0(instance);
		VRCAvatarManager vrcavatarManager = (instance == IntPtr.Zero) ? null : new VRCAvatarManager(instance);
		if (vrcavatarManager == null)
		{
			return;
		}
		VRCPlayer field_Private_VRCPlayer_ = vrcavatarManager.field_Private_VRCPlayer_0;
		if (!(field_Private_VRCPlayer_ == null))
		{
			Class142.UpdatePlayerModules(field_Private_VRCPlayer_.GetPhotonPlayer().ActorID());
			return;
		}
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x00003194 File Offset: 0x00001394
	internal static bool A9xUJ6TqZaKlJe1njae()
	{
		return Class100.caJcWyTYAL41ScDnS05 == null;
	}

	// Token: 0x04000257 RID: 599
	private static Class100.Delegate31 delegate31_0;

	// Token: 0x04000258 RID: 600
	internal static Class100 caJcWyTYAL41ScDnS05;

	// Token: 0x020000EF RID: 239
	// (Invoke) Token: 0x060004F4 RID: 1268
	private delegate void Delegate31(IntPtr instance);

	// Token: 0x020000F0 RID: 240
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000259 RID: 601
		public static Class100.Delegate31 delegate31_0;
	}
}
