using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using VRC.SDKBase.Validation.Performance;

// Token: 0x02000093 RID: 147
internal class Class72 : Interface3
{
	// Token: 0x060003F1 RID: 1009 RVA: 0x00015F50 File Offset: 0x00014150
	public void Initialize()
	{
		MethodInfo method = typeof(AvatarPerformance).GetMethod("GetPerformanceScannerSet");
		Class72.Delegate2 detour;
		if ((detour = Class72.<>O.delegate2_0) == null)
		{
			detour = (Class72.<>O.delegate2_0 = new Class72.Delegate2(Class72.Patch));
		}
		Class72.delegate2_0 = HookManager.Detour<Class72.Delegate2>(method, detour);
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x00015F98 File Offset: 0x00014198
	private static IntPtr Patch(bool __0)
	{
		if (!Class143.bool_35)
		{
			return IntPtr.Zero;
		}
		return Class72.delegate2_0(__0);
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x00003014 File Offset: 0x00001214
	internal static bool BafakpaVKwYAg59X0jM()
	{
		return Class72.hvbFcbaMeLDHLCErmgi == null;
	}

	// Token: 0x040001F0 RID: 496
	private static Class72.Delegate2 delegate2_0;

	// Token: 0x040001F1 RID: 497
	internal static Class72 hvbFcbaMeLDHLCErmgi;

	// Token: 0x02000094 RID: 148
	// (Invoke) Token: 0x060003F6 RID: 1014
	private delegate IntPtr Delegate2(bool __0);

	// Token: 0x02000095 RID: 149
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040001F2 RID: 498
		public static Class72.Delegate2 delegate2_0;
	}
}
