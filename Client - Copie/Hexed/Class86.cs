using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using ExitGames.Client.Photon;
using Hexed.Wrappers;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x020000C2 RID: 194
internal class Class86 : Interface3
{
	// Token: 0x06000472 RID: 1138 RVA: 0x00017390 File Offset: 0x00015590
	public void Initialize()
	{
		MethodInfo target = (from x in typeof(PhotonPeer).GetMethods()
		where x.Name == "SendOperation"
		select x).ToArray<MethodInfo>()[0];
		Class86.Delegate17 detour;
		if ((detour = Class86.<>O.delegate17_0) == null)
		{
			detour = (Class86.<>O.delegate17_0 = new Class86.Delegate17(Class86.Patch));
		}
		Class86.delegate17_0 = HookManager.Detour<Class86.Delegate17>(target, detour);
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x000173FC File Offset: 0x000155FC
	private static bool Patch(IntPtr instance, byte __0, IntPtr __1, SendOptions __2)
	{
		Dictionary<byte, Object> dictionary = (__1 == IntPtr.Zero) ? null : new Dictionary<byte, Object>(__1);
		if (__0 <= 230)
		{
			if (__0 != 226)
			{
				if (__0 != 230)
				{
					goto IL_4E;
				}
				goto IL_4E;
			}
		}
		else if (__0 != 231)
		{
			if (__0 != 252 && __0 != 253)
			{
				goto IL_4E;
			}
			goto IL_4E;
		}
		Class68.ChangeOperation226(dictionary);
		IL_4E:
		if (Class143.bool_3)
		{
			Logger.LogOperation(__0, dictionary, __2);
		}
		return Class86.delegate17_0(instance, __0, __1, __2);
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x000030BE File Offset: 0x000012BE
	internal static bool INcLp1azpxclZR6N3jQ()
	{
		return Class86.ucg8XRaWhaldF0MlNQQ == null;
	}

	// Token: 0x04000225 RID: 549
	private static Class86.Delegate17 delegate17_0;

	// Token: 0x04000226 RID: 550
	private static Class86 ucg8XRaWhaldF0MlNQQ;

	// Token: 0x020000C3 RID: 195
	// (Invoke) Token: 0x06000477 RID: 1143
	private delegate bool Delegate17(IntPtr instance, byte __0, IntPtr __1, SendOptions __2);

	// Token: 0x020000C4 RID: 196
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000227 RID: 551
		public static Class86.Delegate17 delegate17_0;
	}
}
