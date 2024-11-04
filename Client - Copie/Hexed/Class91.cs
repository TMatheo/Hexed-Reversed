using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using VRC.Core;

// Token: 0x020000D2 RID: 210
internal class Class91 : Interface3
{
	// Token: 0x0600049E RID: 1182 RVA: 0x000178D0 File Offset: 0x00015AD0
	public void Initialize()
	{
		MethodInfo method = typeof(RoomManager).GetMethod("Method_Public_Static_Boolean_ApiWorld_ApiWorldInstance_String_Int32_0");
		Class91.Delegate22 detour;
		if ((detour = Class91.<>O.delegate22_0) == null)
		{
			detour = (Class91.<>O.delegate22_0 = new Class91.Delegate22(Class91.Patch));
		}
		Class91.delegate22_0 = HookManager.Detour<Class91.Delegate22>(method, detour);
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00017918 File Offset: 0x00015B18
	private static bool Patch(IntPtr __0, IntPtr __1, IntPtr __2, int __3)
	{
		ApiWorld apiWorld = (__0 == IntPtr.Zero) ? null : new ApiWorld(__0);
		if (apiWorld != null && apiWorld.tags.Contains("feature_avatar_scaling_disabled"))
		{
			apiWorld.tags.Remove("feature_avatar_scaling_disabled");
		}
		return Class91.delegate22_0(__0, __1, __2, __3);
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x0000310C File Offset: 0x0000130C
	internal static bool PxRleUTuAYMo1eITyZn()
	{
		return Class91.YlKhCETe44DuL8952fw == null;
	}

	// Token: 0x04000237 RID: 567
	private static Class91.Delegate22 delegate22_0;

	// Token: 0x04000238 RID: 568
	internal static Class91 YlKhCETe44DuL8952fw;

	// Token: 0x020000D3 RID: 211
	// (Invoke) Token: 0x060004A3 RID: 1187
	private delegate bool Delegate22(IntPtr __0, IntPtr __1, IntPtr __2, int __3);

	// Token: 0x020000D4 RID: 212
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000239 RID: 569
		public static Class91.Delegate22 delegate22_0;
	}
}
