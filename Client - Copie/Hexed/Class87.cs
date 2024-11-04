using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;

// Token: 0x020000C6 RID: 198
internal class Class87 : Interface3
{
	// Token: 0x0600047E RID: 1150 RVA: 0x00017490 File Offset: 0x00015690
	public void Initialize()
	{
		MethodInfo method = typeof(PlayerNameplate).GetMethod("Method_Private_Void_Single_Boolean_0");
		Class87.Delegate18 detour;
		if ((detour = Class87.<>O.delegate18_0) == null)
		{
			detour = (Class87.<>O.delegate18_0 = new Class87.Delegate18(Class87.Patch));
		}
		Class87.delegate18_0 = HookManager.Detour<Class87.Delegate18>(method, detour);
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x000174D8 File Offset: 0x000156D8
	private static void Patch(IntPtr instance, float __0, bool __1)
	{
		PlayerNameplate playerNameplate = (instance == IntPtr.Zero) ? null : new PlayerNameplate(instance);
		if (playerNameplate != null)
		{
			VRCPlayer field_Private_VRCPlayer_ = playerNameplate.field_Private_VRCPlayer_0;
			if (field_Private_VRCPlayer_ != null)
			{
				Interface4 playerModuleByClass = Class142.GetPlayerModuleByClass(field_Private_VRCPlayer_.GetPhotonPlayer().ActorID(), typeof(Class41));
				if (playerModuleByClass != null)
				{
					((Class41)playerModuleByClass).UpdatePlayerPlate(playerNameplate);
				}
			}
		}
		Class87.delegate18_0(instance, __0, __1);
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x000030E4 File Offset: 0x000012E4
	internal static bool sbYaxOTOfDBQw5OgRlc()
	{
		return Class87.ewi7NCTZEbIYKOre5pK == null;
	}

	// Token: 0x0400022B RID: 555
	private static Class87.Delegate18 delegate18_0;

	// Token: 0x0400022C RID: 556
	private static Class87 ewi7NCTZEbIYKOre5pK;

	// Token: 0x020000C7 RID: 199
	// (Invoke) Token: 0x06000483 RID: 1155
	private delegate void Delegate18(IntPtr instance, float __0, bool __1);

	// Token: 0x020000C8 RID: 200
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400022D RID: 557
		public static Class87.Delegate18 delegate18_0;
	}
}
