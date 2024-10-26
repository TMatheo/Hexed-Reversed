using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;

// Token: 0x020000AB RID: 171
internal class Class79 : Interface1, Interface3
{
	// Token: 0x06000431 RID: 1073 RVA: 0x00016660 File Offset: 0x00014860
	public void Initialize()
	{
		MethodInfo method = typeof(MonoBehaviour2PublicSiTrUnique).GetMethod("Method_Private_Void_0");
		Class79.Delegate10 detour;
		if ((detour = Class79.<>O.delegate10_0) == null)
		{
			detour = (Class79.<>O.delegate10_0 = new Class79.Delegate10(Class79.Patch));
		}
		Class79.delegate10_0 = HookManager.Detour<Class79.Delegate10>(method, detour);
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x000166A8 File Offset: 0x000148A8
	private static void Patch(IntPtr instance)
	{
		if (instance != IntPtr.Zero)
		{
			new MonoBehaviour2PublicSiTrUnique(instance);
		}
		if (!Class38.bool_2)
		{
			Class79.delegate10_0(instance);
			return;
		}
	}

	// Token: 0x06000434 RID: 1076 RVA: 0x00003064 File Offset: 0x00001264
	internal static bool mT0Wp0aYWJtu0U2uow4()
	{
		return Class79.EE2kfsaLyFmKlmlUjTV == null;
	}

	// Token: 0x04000208 RID: 520
	private static Class79.Delegate10 delegate10_0;

	// Token: 0x04000209 RID: 521
	private static Class79 EE2kfsaLyFmKlmlUjTV;

	// Token: 0x020000AC RID: 172
	// (Invoke) Token: 0x06000436 RID: 1078
	private delegate void Delegate10(IntPtr instance);

	// Token: 0x020000AD RID: 173
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400020A RID: 522
		public static Class79.Delegate10 delegate10_0;
	}
}
