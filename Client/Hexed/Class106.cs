using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using Hexed.Wrappers;
using Il2CppSystem;
using VRC;
using VRC.Core;
using VRC.SDKBase;

// Token: 0x02000100 RID: 256
internal class Class106 : Interface3
{
	// Token: 0x0600051F RID: 1311 RVA: 0x0001A138 File Offset: 0x00018338
	public void Initialize()
	{
		MethodInfo method = typeof(VRC_EventDispatcherRFC).GetMethod("Method_Public_Void_Player_VrcEvent_VrcBroadcastType_Int32_Single_0");
		Class106.Delegate37 detour;
		if ((detour = Class106.<>O.delegate37_0) == null)
		{
			detour = (Class106.<>O.delegate37_0 = new Class106.Delegate37(Class106.Patch));
		}
		Class106.delegate37_0 = HookManager.Detour<Class106.Delegate37>(method, detour);
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x0001A180 File Offset: 0x00018380
	private static void Patch(IntPtr instance, IntPtr __0, IntPtr __1, VRC_EventHandler.VrcBroadcastType __2, int __3, float __4)
	{
		Player player = (__0 == IntPtr.Zero) ? null : new Player(__0);
		VRC_EventHandler.VrcEvent vrcEvent = (__1 == IntPtr.Zero) ? null : new VRC_EventHandler.VrcEvent(__1);
		if (!(player == null) && vrcEvent != null && !Class66.IsActorEventBlocked(player.GetPhotonPlayer().ActorID(), 6))
		{
			object[] array = new object[0];
			if (vrcEvent.ParameterBytes != null)
			{
				array = new object[vrcEvent.ParameterBytes.Length];
				Object[] array2 = ParameterSerialization.Method_Public_Static_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Byte_0(vrcEvent.ParameterBytes);
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i] != null)
					{
						try
						{
							array[i] = Class0.Class2.smethod_0(array2[i]);
						}
						catch (Exception value)
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 1);
							defaultInterpolatedStringHandler.AppendLiteral("Failed to Serialize RPC Parameter: ");
							defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
							Logger.LogError(defaultInterpolatedStringHandler.ToStringAndClear());
							return;
						}
					}
				}
			}
			if (Class143.bool_2)
			{
				Logger.LogRPC(player, vrcEvent, __2, __3, __4, array);
			}
			if (!Class66.CheckDecodedRPC(player, vrcEvent, __2, __3, __4, array))
			{
				return;
			}
			Class106.delegate37_0(instance, __0, __1, __2, __3, __4);
			return;
		}
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x000031D0 File Offset: 0x000013D0
	internal static bool z8xE9CTD8S6TxkO8o4p()
	{
		return Class106.rgCyRjTmQ4VyrumPyBg == null;
	}

	// Token: 0x04000269 RID: 617
	private static Class106.Delegate37 delegate37_0;

	// Token: 0x0400026A RID: 618
	internal static Class106 rgCyRjTmQ4VyrumPyBg;

	// Token: 0x02000101 RID: 257
	// (Invoke) Token: 0x06000524 RID: 1316
	private delegate void Delegate37(IntPtr instance, IntPtr __0, IntPtr __1, VRC_EventHandler.VrcBroadcastType __2, int __3, float __4);

	// Token: 0x02000102 RID: 258
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400026B RID: 619
		public static Class106.Delegate37 delegate37_0;
	}
}
