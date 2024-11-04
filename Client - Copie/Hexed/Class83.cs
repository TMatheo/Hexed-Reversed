using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using RootMotion.FinalIK;

// Token: 0x020000B8 RID: 184
internal class Class83 : Interface1, Interface3
{
	// Token: 0x06000455 RID: 1109 RVA: 0x00016CC8 File Offset: 0x00014EC8
	public void Initialize()
	{
		if (Class143.bool_8)
		{
			MethodInfo method = typeof(IKSolverVR).GetMethod("OnUpdate");
			Class83.Delegate14 detour;
			if ((detour = Class83.<>O.delegate14_0) == null)
			{
				detour = (Class83.<>O.delegate14_0 = new Class83.Delegate14(Class83.Patch));
			}
			Class83.delegate14_0 = HookManager.Detour<Class83.Delegate14>(method, detour);
		}
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x00016D18 File Offset: 0x00014F18
	private static void Patch(IntPtr instance)
	{
		IKSolverVR iksolverVR = (instance == IntPtr.Zero) ? null : new IKSolverVR(instance);
		if (iksolverVR != null && Class3.CurrentVRCPlayer != null)
		{
			Class63.LateUpdateIK(iksolverVR, Class56.class55_0.bool_0[0], Class56.class55_0.bool_0[1], Class56.gameObject_1[0].transform, Class56.gameObject_1[1].transform);
		}
		Class83.delegate14_0(instance);
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x00003096 File Offset: 0x00001296
	internal static bool R9BRBZaNQQhV1K65MAl()
	{
		return Class83.saq1ZDaSXecEhwqeCRw == null;
	}

	// Token: 0x04000219 RID: 537
	private static Class83.Delegate14 delegate14_0;

	// Token: 0x0400021A RID: 538
	internal static Class83 saq1ZDaSXecEhwqeCRw;

	// Token: 0x020000B9 RID: 185
	// (Invoke) Token: 0x0600045A RID: 1114
	private delegate void Delegate14(IntPtr instance);

	// Token: 0x020000BA RID: 186
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400021B RID: 539
		public static Class83.Delegate14 delegate14_0;
	}
}
