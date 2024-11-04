using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using CoreRuntime.Manager;
using Hexed.Wrappers;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;
using VRC;
using VRC.Core;

// Token: 0x020000DB RID: 219
internal class Class94 : Interface3
{
	// Token: 0x060004B6 RID: 1206 RVA: 0x00017C9C File Offset: 0x00015E9C
	public void Initialize()
	{
		Class94.int_0 = SystemInfo.deviceUniqueIdentifier.Length;
		if (Class94.int_0 == 0)
		{
			Logger.LogError("Failed to get HWID lenght");
			return;
		}
		if (APIUser.CurrentUser == null)
		{
			IntPtr target = IL2CPP.il2cpp_resolve_icall("UnityEngine.SystemInfo::GetDeviceUniqueIdentifier");
			Class94.Delegate25 detour;
			if ((detour = Class94.<>O.delegate25_0) == null)
			{
				detour = (Class94.<>O.delegate25_0 = new Class94.Delegate25(Class94.Patch));
			}
			HookManager.Detour<Class94.Delegate25>(target, detour);
			return;
		}
		Logger.LogWarning("Already logged in, skipping HWID Spoof");
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x00017D08 File Offset: 0x00015F08
	private static IntPtr Patch()
	{
		if (APIUser.IsLoggedIn)
		{
			if (Class94.bool_0)
			{
				Class94.bool_0 = false;
				Class94.SetToken();
			}
		}
		else if (!Class94.IsTokenExisting())
		{
			if (!Class94.bool_0)
			{
				Class94.bool_0 = true;
				Class94.GenerateAndSetHWID();
			}
		}
		else if (Class141.class6_0.GetString("Spoof", "HWID", "", false).Length == Class94.int_0 && !(Class141.class6_0.GetString("Spoof", "Token", "", false) != ApiCredentials.GetString("authToken")))
		{
			if (Class94.object_0 == null)
			{
				Class94.SetHWIDFromConfig();
			}
		}
		else
		{
			Class94.GenerateAndSetHWID();
			Class94.SetToken();
		}
		if (Class94.object_0 == null || Class94.int_0 != Class94.object_0.ToString().Length || Class94.int_0 == 0)
		{
			Logger.LogError("Error generating HWID, restart your game");
			Thread.Sleep(-1);
		}
		return Class94.object_0.Pointer;
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x00017DF8 File Offset: 0x00015FF8
	private static string GenerateHWID()
	{
		byte[] array = new byte[Class94.int_0 / 2];
		Class109.random_0.NextBytes(array);
		return string.Join("", from it in array
		select it.ToString("x2"));
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x0000312A File Offset: 0x0000132A
	private static bool IsTokenExisting()
	{
		return ApiCredentials.GetString("authToken").StartsWith("authcookie_");
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x00017E50 File Offset: 0x00016050
	private static void GenerateAndSetHWID()
	{
		Class141.class6_0.SetString("Spoof", "HWID", Class94.GenerateHWID());
		Class94.object_0 = new Object(IL2CPP.ManagedStringToIl2Cpp(Class141.class6_0.GetString("Spoof", "HWID", "", false)));
		Logger.Log("Generated and Spoofed HWID: " + Class94.object_0.ToString(), Logger.LogsType.Protection);
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x00017EBC File Offset: 0x000160BC
	private static void SetToken()
	{
		Class141.class6_0.SetString("Spoof", "Token", ApiCredentials.GetString("authToken"));
		Tools.ClearCookies();
		Tools.ClearExpiredBestHTTPCache();
		ApiCache.Clear();
		ApiCache.Cleanup();
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x00017EFC File Offset: 0x000160FC
	private static void SetHWIDFromConfig()
	{
		Class94.object_0 = new Object(IL2CPP.ManagedStringToIl2Cpp(Class141.class6_0.GetString("Spoof", "HWID", "", false)));
		Logger.Log("Spoofed HWID from Config: " + Class94.object_0.ToString(), Logger.LogsType.Protection);
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x00003140 File Offset: 0x00001340
	internal static bool MHTeAOTCYRBYtnnRgLb()
	{
		return Class94.caImAMTBhSMyVAbhlyT == null;
	}

	// Token: 0x04000240 RID: 576
	private static Object object_0;

	// Token: 0x04000241 RID: 577
	private static bool bool_0;

	// Token: 0x04000242 RID: 578
	private static int int_0;

	// Token: 0x04000243 RID: 579
	private static Class94 caImAMTBhSMyVAbhlyT;

	// Token: 0x020000DC RID: 220
	// (Invoke) Token: 0x060004C0 RID: 1216
	private delegate IntPtr Delegate25();

	// Token: 0x020000DD RID: 221
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000244 RID: 580
		public static Class94.Delegate25 delegate25_0;
	}
}
