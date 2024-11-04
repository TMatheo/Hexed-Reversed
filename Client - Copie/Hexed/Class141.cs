using System;
using System.IO;

// Token: 0x0200015E RID: 350
internal class Class141
{
	// Token: 0x06000779 RID: 1913 RVA: 0x00024318 File Offset: 0x00022518
	public static void Init(string UnityLoaderPath)
	{
		Class141.string_0 = UnityLoaderPath + "\\VRChat\\Hexed";
		if (!Directory.Exists(Class141.string_0))
		{
			Directory.CreateDirectory(Class141.string_0);
		}
		if (!Directory.Exists(Class141.string_0 + "\\Assets"))
		{
			Directory.CreateDirectory(Class141.string_0 + "\\Assets");
		}
		if (!Directory.Exists(Class141.string_0 + "\\Rips"))
		{
			Directory.CreateDirectory(Class141.string_0 + "\\Rips");
		}
		if (!File.Exists(Class141.string_0 + "\\Config.ini"))
		{
			File.Create(Class141.string_0 + "\\Config.ini");
		}
		Class141.class6_0 = new Class6(Class141.string_0 + "\\Config.ini");
		if (Class5.GetProcessByName("LeapSvc") != null && !Class4.IsInVr())
		{
			if (!Directory.Exists(Class141.string_0 + "\\LeapMotion"))
			{
				Directory.CreateDirectory(Class141.string_0 + "\\LeapMotion");
			}
			if (File.Exists(Class141.string_0 + "\\LeapMotion\\LeapManager.exe"))
			{
				File.Delete(Class141.string_0 + "\\LeapMotion\\LeapManager.exe");
			}
			string s = Class111.DownloadAsset("LeapManager.exe");
			File.WriteAllBytes(Class141.string_0 + "\\LeapMotion\\LeapManager.exe", Convert.FromBase64String(s));
			if (File.Exists(Class141.string_0 + "\\LeapMotion\\LeapC.dll"))
			{
				File.Delete(Class141.string_0 + "\\LeapMotion\\LeapC.dll");
			}
			string s2 = Class111.DownloadAsset("LeapC.dll");
			File.WriteAllBytes(Class141.string_0 + "\\LeapMotion\\LeapC.dll", Convert.FromBase64String(s2));
			Class143.bool_8 = true;
		}
		Class141.SetInternalValuesFromConfig();
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x000244D8 File Offset: 0x000226D8
	private static void SetInternalValuesFromConfig()
	{
		Class143.short_0 = Convert.ToInt16(Class141.class6_0.GetInt("Toggles", "FakePingValue", 0, false));
		Class143.int_0 = Class141.class6_0.GetInt("Toggles", "FakeFrameValue", 0, false);
		Class143.byte_0 = Convert.ToByte(Class141.class6_0.GetInt("Toggles", "FakeLatencyValue", 0, false));
		Class143.string_1 = Class141.class6_0.GetString("Toggles", "FakeGroupValue", "", false);
		Class143.string_0 = Class141.class6_0.GetString("Toggles", "FakeUdonValue", "", false);
		Class143.frameAndPingMode_1 = (Class143.FrameAndPingMode)Class141.class6_0.GetInt("Toggles", "FakePingMode", 0, false);
		Class143.frameAndPingMode_0 = (Class143.FrameAndPingMode)Class141.class6_0.GetInt("Toggles", "FakeFrameMode", 0, false);
		Class143.latencyMode_0 = (Class143.LatencyMode)Class141.class6_0.GetInt("Toggles", "FakeLatencyMode", 0, false);
		Class143.bool_32 = Class141.class6_0.GetBool("Toggles", "GroupSpoof", false, false);
		Class143.vrmode_0 = (Class143.VRMode)Class141.class6_0.GetInt("Toggles", "VRSpoof", 0, false);
		Class143.antiPortalMode_0 = (Class143.AntiPortalMode)Class141.class6_0.GetInt("Toggles", "AntiPortalMode", 0, false);
		Class143.udonSpoofMode_0 = (Class143.UdonSpoofMode)Class141.class6_0.GetInt("Toggles", "UdonSpoofMode", 0, false);
		Class143.antiPickupMode_0 = (Class143.AntiPickupMode)Class141.class6_0.GetInt("Toggles", "AntiPickupMode", 0, false);
		Class143.interestMode_0 = (Class143.InterestMode)Class141.class6_0.GetInt("Toggles", "CustomInterestMode", 0, false);
		Class143.micStateMode_0 = (Class143.MicStateMode)Class141.class6_0.GetInt("Toggles", "FakeMicMode", 0, false);
		Class143.earmuffStateMode_0 = (Class143.EarmuffStateMode)Class141.class6_0.GetInt("Toggles", "FakeEarmuffMode", 0, false);
		Class143.bool_12 = Class141.class6_0.GetBool("Toggles", "NoObjectDestroy", false, false);
		Class143.bool_13 = Class141.class6_0.GetBool("Toggles", "NoEmojiSpawn", false, false);
		Class143.bool_14 = Class141.class6_0.GetBool("Toggles", "NoUdonEvents", false, false);
		Class143.bool_17 = Class141.class6_0.GetBool("Toggles", "NoCameraTimer", false, false);
		Class143.bool_18 = Class141.class6_0.GetBool("Toggles", "NoVideoPlayer", false, false);
		Class143.bool_19 = Class141.class6_0.GetBool("Toggles", "AntiBlock", false, false);
		Class143.bool_20 = Class141.class6_0.GetBool("Toggles", "SpoofMovementLenght", false, false);
		Class143.bool_21 = Class141.class6_0.GetBool("Toggles", "BunnyHop", false, false);
		Class143.bool_22 = Class141.class6_0.GetBool("Toggles", "InfJump", false, false);
		Class143.bool_23 = Class141.class6_0.GetBool("Toggles", "MultiJump", false, false);
		Class143.bool_25 = Class141.class6_0.GetBool("Toggles", "Speed", false, false);
		Class143.bool_26 = Class141.class6_0.GetBool("Toggles", "InvisibleCamera", false, false);
		Class143.bool_27 = Class141.class6_0.GetBool("Toggles", "NoSpawnsound", false, false);
		Class143.bool_28 = Class141.class6_0.GetBool("Toggles", "SilentMute", false, false);
		Class143.bool_29 = Class141.class6_0.GetBool("Toggles", "AntiOverride", false, false);
		Class143.bool_30 = Class141.class6_0.GetBool("Toggles", "GodMode", false, false);
		Class143.bool_31 = Class141.class6_0.GetBool("Toggles", "NoTeleport", false, false);
		Class143.bool_15 = Class141.class6_0.GetBool("Toggles", "NoUdonDownload", false, false);
		Class143.bool_16 = Class141.class6_0.GetBool("Toggles", "NoUdonScaling", false, false);
		Class143.bool_9 = Class141.class6_0.GetBool("Toggles", "PlayerESP", false, false);
		Class143.bool_10 = Class141.class6_0.GetBool("Toggles", "ItemESP", false, false);
		Class143.bool_11 = Class141.class6_0.GetBool("Toggles", "TriggerESP", false, false);
		Class143.bool_33 = Class141.class6_0.GetBool("Toggles", "NoUdonSync", false, false);
		Class143.bool_34 = Class141.class6_0.GetBool("Toggles", "MovementRedirect", false, false);
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x0000382E File Offset: 0x00001A2E
	internal static bool sVwkKJ9YQjOJAEenNCD()
	{
		return Class141.XKf4yY9LZPVcuOOJ1ie == null;
	}

	// Token: 0x04000442 RID: 1090
	public static Class6 class6_0;

	// Token: 0x04000443 RID: 1091
	public static string string_0;

	// Token: 0x04000444 RID: 1092
	private static Class141 XKf4yY9LZPVcuOOJ1ie;
}
