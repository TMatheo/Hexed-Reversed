using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using AmplitudeSDKWrapper;
using CoreRuntime.Manager;

// Token: 0x0200008C RID: 140
internal class Class70 : Interface3
{
	// Token: 0x060003DD RID: 989 RVA: 0x00015C70 File Offset: 0x00013E70
	public void Initialize()
	{
		foreach (MethodInfo target in from x in typeof(AmplitudeWrapper).GetMethods()
		where x.Name.Contains("Start") || x.Name.Contains("UpdateServer") || x.Name.Contains("PostEvents") || x.Name.Contains("LogEvent") || x.Name.Contains("SaveEvent") || x.Name.Contains("SaveAndUpload")
		select x)
		{
			Class70.Delegate0 detour;
			if ((detour = Class70.<>O.delegate0_0) == null)
			{
				detour = (Class70.<>O.delegate0_0 = new Class70.Delegate0(Class70.Patch));
			}
			HookManager.Detour<Class70.Delegate0>(target, detour);
		}
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00002328 File Offset: 0x00000528
	private static void Patch()
	{
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00002FF6 File Offset: 0x000011F6
	internal static bool OOJm6RaRuX5rG9yQ0I8()
	{
		return Class70.u1Cj9Sai49G5bcwkffb == null;
	}

	// Token: 0x040001E8 RID: 488
	internal static Class70 u1Cj9Sai49G5bcwkffb;

	// Token: 0x0200008D RID: 141
	// (Invoke) Token: 0x060003E2 RID: 994
	private delegate void Delegate0();

	// Token: 0x0200008E RID: 142
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040001E9 RID: 489
		public static Class70.Delegate0 delegate0_0;
	}
}
