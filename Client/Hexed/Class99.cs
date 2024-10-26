using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020000EB RID: 235
internal class Class99 : Interface3
{
	// Token: 0x060004E7 RID: 1255 RVA: 0x000184D8 File Offset: 0x000166D8
	public void Initialize()
	{
		MethodInfo method = typeof(VRCAvatarManager).GetMethod("Method_Private_Boolean_GameObject_String_Single_ApiAvatar_Boolean_0");
		Class99.Delegate30 detour;
		if ((detour = Class99.<>O.delegate30_0) == null)
		{
			detour = (Class99.<>O.delegate30_0 = new Class99.Delegate30(Class99.Patch));
		}
		Class99.delegate30_0 = HookManager.Detour<Class99.Delegate30>(method, detour);
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x00018520 File Offset: 0x00016720
	private static bool Patch(IntPtr instance, IntPtr __0, IntPtr __1, float __2, IntPtr __3, bool __4)
	{
		VRCAvatarManager vrcavatarManager = (instance == IntPtr.Zero) ? null : new VRCAvatarManager(instance);
		GameObject gameObject = (__0 == IntPtr.Zero) ? null : new GameObject(__0);
		string text = (__1 == IntPtr.Zero) ? null : new Object(__1).ToString();
		if (gameObject != null && text.StartsWith("https://"))
		{
			Class47.SanitizeAvatarObject(gameObject, vrcavatarManager.field_Private_VRCPlayer_0);
		}
		return Class99.delegate30_0(instance, __0, __1, __2, __3, __4);
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x0000318A File Offset: 0x0000138A
	internal static bool t0vXykTs9v7Dr6drLWP()
	{
		return Class99.oiNoiFT3fLKJgcgPkDu == null;
	}

	// Token: 0x04000254 RID: 596
	private static Class99.Delegate30 delegate30_0;

	// Token: 0x04000255 RID: 597
	private static Class99 oiNoiFT3fLKJgcgPkDu;

	// Token: 0x020000EC RID: 236
	// (Invoke) Token: 0x060004EC RID: 1260
	private delegate bool Delegate30(IntPtr instance, IntPtr __0, IntPtr __1, float __2, IntPtr __3, bool __4);

	// Token: 0x020000ED RID: 237
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000256 RID: 598
		public static Class99.Delegate30 delegate30_0;
	}
}
