using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using VRC.FingerTracking;

// Token: 0x020000B2 RID: 178
internal class Class81 : Interface1, Interface3
{
	// Token: 0x06000445 RID: 1093 RVA: 0x00016B64 File Offset: 0x00014D64
	public void Initialize()
	{
		if (Class143.bool_8)
		{
			MethodInfo method = typeof(HandProcessor).GetMethod("LateUpdate");
			Class81.Delegate12 detour;
			if ((detour = Class81.<>O.delegate12_0) == null)
			{
				detour = (Class81.<>O.delegate12_0 = new Class81.Delegate12(Class81.Patch));
			}
			Class81.delegate12_0 = HookManager.Detour<Class81.Delegate12>(method, detour);
		}
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00016BB4 File Offset: 0x00014DB4
	private static void Patch(IntPtr instance)
	{
		HandProcessor handProcessor = (instance == IntPtr.Zero) ? null : new HandProcessor(instance);
		if (handProcessor != null && Class3.CurrentVRCPlayer != null)
		{
			Class63.UpdateFingers(handProcessor, Class56.class55_0.bool_0[0], Class56.class55_0.bool_0[1]);
			return;
		}
		Class81.delegate12_0(instance);
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x00003082 File Offset: 0x00001282
	internal static bool x8BTLuaQ669K9D6RyFU()
	{
		return Class81.E62yHratIs6BMRDwl2y == null;
	}

	// Token: 0x04000213 RID: 531
	private static Class81.Delegate12 delegate12_0;

	// Token: 0x04000214 RID: 532
	internal static Class81 E62yHratIs6BMRDwl2y;

	// Token: 0x020000B3 RID: 179
	// (Invoke) Token: 0x0600044A RID: 1098
	private delegate void Delegate12(IntPtr instance);

	// Token: 0x020000B4 RID: 180
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000215 RID: 533
		public static Class81.Delegate12 delegate12_0;
	}
}
