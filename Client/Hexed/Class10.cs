using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppSystem.Collections.Generic;
using Photon.Realtime;
using UnityEngine;
using VRC;
using VRC.Core;
using VRC.Management;

// Token: 0x02000011 RID: 17
internal static class Class10
{
	// Token: 0x060000AE RID: 174 RVA: 0x00007FE0 File Offset: 0x000061E0
	public static void ChangeAvatar(string avatarID)
	{
		if (avatarID.StartsWith("avtr_") && Class3.CurrentPlayer.smethod_0().avatarId != avatarID)
		{
			Resources.FindObjectsOfTypeAll<SystemController>().FirstOrDefault<SystemController>().Method_Public_Void_ApiAvatar_String_PDM_0(new ApiAvatar
			{
				id = avatarID
			}, "AvatarPedestal");
		}
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00008034 File Offset: 0x00006234
	public static bool smethod_0(this VRCPlayer Player)
	{
		VRC_AnimationController vrc_AnimationController = Player.Method_Public_get_VRC_AnimationController_0();
		bool result;
		if (vrc_AnimationController != null)
		{
			IkController field_Private_IkController_ = vrc_AnimationController.field_Private_IkController_0;
			result = (((field_Private_IkController_ != null) ? new IkController.EnumNPublicSealedvaInNoLiThFoFiSi8vUnique?(field_Private_IkController_.Method_Public_get_EnumNPublicSealedvaInNoLiThFoFiSi8vUnique_0()) : null).GetValueOrDefault() == 6);
		}
		else
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00008080 File Offset: 0x00006280
	public static bool smethod_1(this VRCPlayer player)
	{
		return !(player.field_Internal_Animator_0 == null) && player.field_Internal_Animator_0.GetBool("AFK");
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x000080B0 File Offset: 0x000062B0
	public static bool IsPlayerEarmuff(this VRCPlayer player)
	{
		return !(player.field_Internal_Animator_0 == null) && player.field_Internal_Animator_0.GetBool("Earmuffs");
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x000080E0 File Offset: 0x000062E0
	public static bool IsPlayerMicDisabled(this VRCPlayer player)
	{
		return !(player.field_Internal_Animator_0 == null) && player.field_Internal_Animator_0.GetBool("MuteSelf");
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00008110 File Offset: 0x00006310
	public static bool IsPlayerSeated(this VRCPlayer player)
	{
		return !(player.field_Internal_Animator_0 == null) && player.field_Internal_Animator_0.GetBool("InStation");
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00008140 File Offset: 0x00006340
	public static Class10.APIDevice GetAPIDevice(string device)
	{
		if (device == "android")
		{
			return Class10.APIDevice.Android;
		}
		if (device == "standalonewindows")
		{
			return Class10.APIDevice.Windows;
		}
		if (device == "ios")
		{
			return Class10.APIDevice.IOS;
		}
		return Class10.APIDevice.Unknown;
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x0000817C File Offset: 0x0000637C
	public static Class10.APIDevice GetAPIDevice(this APIUser Player)
	{
		string last_platform = Player.last_platform;
		if (last_platform == null)
		{
			return Class10.APIDevice.Unknown;
		}
		return Class10.GetAPIDevice(last_platform);
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x000081A0 File Offset: 0x000063A0
	public static Class10.APIDevice GetAPIDevice(this Player Player)
	{
		string last_platform = Player.smethod_0().last_platform;
		if (last_platform == null)
		{
			return Class10.APIDevice.Unknown;
		}
		return Class10.GetAPIDevice(last_platform);
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x000081C8 File Offset: 0x000063C8
	public static Class10.APIDevice GetAPIDevice(this VRCPlayer Player)
	{
		string last_platform = Player.smethod_1().last_platform;
		if (last_platform != null)
		{
			return Class10.GetAPIDevice(last_platform);
		}
		return Class10.APIDevice.Unknown;
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x000081F0 File Offset: 0x000063F0
	public static Class10.APIDevice GetAPIDevice(this Player Player)
	{
		string platform = Player.GetPlatform();
		if (platform != null)
		{
			return Class10.GetAPIDevice(platform);
		}
		return Class10.APIDevice.Unknown;
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00008214 File Offset: 0x00006414
	public static Class10.Device GetDevice(this VRCPlayer Player)
	{
		switch (Player.GetAPIDevice())
		{
		case Class10.APIDevice.Unknown:
			return Class10.Device.Unknown;
		case Class10.APIDevice.Android:
			if (!Player.GetVRCPlayerApi().IsUserInVR())
			{
				return Class10.Device.Mobile;
			}
			return Class10.Device.Quest;
		case Class10.APIDevice.Windows:
			if (!Player.GetVRCPlayerApi().IsUserInVR())
			{
				return Class10.Device.Desktop;
			}
			return Class10.Device.VR;
		case Class10.APIDevice.IOS:
			return Class10.Device.Mobile;
		default:
			return Class10.Device.Unknown;
		}
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00008268 File Offset: 0x00006468
	public static Class10.Device GetDevice(this Player Player)
	{
		switch (Player.GetAPIDevice())
		{
		case Class10.APIDevice.Android:
			if (Player.GetVRCPlayerApi().IsUserInVR())
			{
				return Class10.Device.Quest;
			}
			return Class10.Device.Mobile;
		case Class10.APIDevice.Windows:
			if (!Player.GetVRCPlayerApi().IsUserInVR())
			{
				return Class10.Device.Desktop;
			}
			return Class10.Device.VR;
		case Class10.APIDevice.IOS:
			return Class10.Device.Mobile;
		default:
			return Class10.Device.Unknown;
		}
	}

	// Token: 0x060000BB RID: 187 RVA: 0x000082B8 File Offset: 0x000064B8
	public static Class10.Device GetDevice(this Player Player)
	{
		switch (Player.GetAPIDevice())
		{
		case Class10.APIDevice.Android:
			if (!Player.IsVR())
			{
				return Class10.Device.Mobile;
			}
			return Class10.Device.Quest;
		case Class10.APIDevice.Windows:
			if (!Player.IsVR())
			{
				return Class10.Device.Desktop;
			}
			return Class10.Device.VR;
		case Class10.APIDevice.IOS:
			return Class10.Device.Mobile;
		default:
			return Class10.Device.Unknown;
		}
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00008300 File Offset: 0x00006500
	public static Color GetPlatformColor(string Platform)
	{
		if (Platform == "android")
		{
			return new Color(0f, 0.83f, 0.27f);
		}
		if (Platform == "standalonewindows")
		{
			return new Color(0.34f, 0.46f, 0.89f);
		}
		return Color.gray;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00008358 File Offset: 0x00006558
	public static string GetDeviceTag(this Class10.Device device)
	{
		switch (device)
		{
		case Class10.Device.Quest:
			return "QS";
		case Class10.Device.Mobile:
			return "MB";
		case Class10.Device.Desktop:
			return "PC";
		case Class10.Device.VR:
			return "VR";
		default:
			return "UKN";
		}
	}

	// Token: 0x060000BE RID: 190 RVA: 0x0000839C File Offset: 0x0000659C
	public static bool IsBlocked(this ModerationManager instance, string userId)
	{
		Dictionary<string, List<ApiPlayerModeration>> field_Private_Dictionary_2_String_List_1_ApiPlayerModeration_ = instance.field_Private_Dictionary_2_String_List_1_ApiPlayerModeration_0;
		if (!field_Private_Dictionary_2_String_List_1_ApiPlayerModeration_.ContainsKey(userId))
		{
			return false;
		}
		List<ApiPlayerModeration> list = field_Private_Dictionary_2_String_List_1_ApiPlayerModeration_[userId];
		if (list != null && list._items != null)
		{
			IEnumerable<ApiPlayerModeration> enumerable = from x in list._items
			where x != null && x.moderationType == 1
			select x;
			return enumerable != null && enumerable.ToArray<ApiPlayerModeration>().Length != 0;
		}
		return false;
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00008414 File Offset: 0x00006614
	public static bool IsMuted(this ModerationManager instance, string userId)
	{
		Dictionary<string, List<ApiPlayerModeration>> field_Private_Dictionary_2_String_List_1_ApiPlayerModeration_ = instance.field_Private_Dictionary_2_String_List_1_ApiPlayerModeration_0;
		if (!field_Private_Dictionary_2_String_List_1_ApiPlayerModeration_.ContainsKey(userId))
		{
			return false;
		}
		List<ApiPlayerModeration> list = field_Private_Dictionary_2_String_List_1_ApiPlayerModeration_[userId];
		if (list != null && list._items != null)
		{
			IEnumerable<ApiPlayerModeration> enumerable = from x in list._items
			where x != null && x.moderationType == 2
			select x;
			return enumerable != null && enumerable.ToArray<ApiPlayerModeration>().Length != 0;
		}
		return false;
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00002590 File Offset: 0x00000790
	public static short GetPing(this PlayerNet instance)
	{
		return instance.field_Private_Int16_0;
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00002598 File Offset: 0x00000798
	public static short GetPing(this Player instance)
	{
		return instance.GetPlayerNet().field_Private_Int16_0;
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x000025A5 File Offset: 0x000007A5
	public static short GetPing(this VRCPlayer instance)
	{
		return instance.GetPlayerNet().field_Private_Int16_0;
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x0000848C File Offset: 0x0000668C
	public static Color GetPingColor(this VRCPlayer Instance)
	{
		if (Instance.GetPing() < 1)
		{
			return Color.red;
		}
		float num = (float)Instance.GetPing() / 200f;
		return Color.Lerp(Color.green, Color.red, num);
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x000084C8 File Offset: 0x000066C8
	public static Color GetPingColor(this Player Instance)
	{
		if (Instance.GetPing() < 1)
		{
			return Color.red;
		}
		float num = (float)Instance.GetPing() / 200f;
		return Color.Lerp(Color.green, Color.red, num);
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00008504 File Offset: 0x00006704
	public static int GetFrames(this PlayerNet Instance)
	{
		if (Instance.Method_Public_get_Byte_0() == 0)
		{
			return 0;
		}
		return 1000 / (int)Instance.Method_Public_get_Byte_0();
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x000025B2 File Offset: 0x000007B2
	public static int GetFrames(this VRCPlayer Instance)
	{
		return Instance.GetPlayerNet().GetFrames();
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x000025BF File Offset: 0x000007BF
	public static int GetFrames(this Player Instance)
	{
		return Instance.GetPlayerNet().GetFrames();
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00008528 File Offset: 0x00006728
	public static Color GetFramesColor(this VRCPlayer Instance)
	{
		float num = (float)Instance.GetFrames() / 140f;
		return Color.Lerp(Color.green, Color.red, 1f - num);
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x0000855C File Offset: 0x0000675C
	public static Color GetFramesColor(this Player Instance)
	{
		float num = (float)Instance.GetFrames() / 140f;
		return Color.Lerp(Color.green, Color.red, 1f - num);
	}

	// Token: 0x060000CA RID: 202 RVA: 0x000025CC File Offset: 0x000007CC
	public static float GetQuality(this PlayerNet Instance)
	{
		return Instance.Method_Internal_get_Single_PDM_1();
	}

	// Token: 0x060000CB RID: 203 RVA: 0x000025D4 File Offset: 0x000007D4
	public static float GetQuality(this VRCPlayer Instance)
	{
		return Instance.GetPlayerNet().Method_Internal_get_Single_PDM_1();
	}

	// Token: 0x060000CC RID: 204 RVA: 0x000025E1 File Offset: 0x000007E1
	public static float GetQuality(this Player Instance)
	{
		return Instance.GetPlayerNet().Method_Internal_get_Single_PDM_1();
	}

	// Token: 0x060000CD RID: 205 RVA: 0x000025EE File Offset: 0x000007EE
	public static int GetQualityPercentage(this VRCPlayer Instance)
	{
		return (int)(Instance.GetPlayerNet().Method_Internal_get_Single_PDM_1() * 100f);
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00002602 File Offset: 0x00000802
	public static int GetQualityPercentage(this Player Instance)
	{
		return (int)(Instance.GetPlayerNet().Method_Internal_get_Single_PDM_1() * 100f);
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00002616 File Offset: 0x00000816
	public static Color GetQualityColor(this VRCPlayer Instance)
	{
		return Color.Lerp(Color.red, Color.green, Instance.GetQuality());
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x0000262D File Offset: 0x0000082D
	public static Color GetQualityColor(this Player Instance)
	{
		return Color.Lerp(Color.red, Color.green, Instance.GetQuality());
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00002644 File Offset: 0x00000844
	public static float GetHeight(this VRCPlayer Instance)
	{
		return Instance.field_Private_Single_9;
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00008590 File Offset: 0x00006790
	public static Class10.TrustRanks GetRank(this APIUser Instance)
	{
		if (Instance.developerType != null || Instance.hasModerationPowers || Instance.hasScriptingAccess || Instance.hasVIPAccess || Instance.hasSuperPowers)
		{
			return Class10.TrustRanks.MODERATOR;
		}
		if (Instance.hasVeteranTrustLevel)
		{
			return Class10.TrustRanks.TRUSTED;
		}
		if (Instance.hasTrustedTrustLevel)
		{
			return Class10.TrustRanks.KNOWN;
		}
		if (Instance.hasKnownTrustLevel)
		{
			return Class10.TrustRanks.USER;
		}
		if (Instance.hasBasicTrustLevel)
		{
			return Class10.TrustRanks.NEW;
		}
		if (!Instance.hasNegativeTrustLevel && !Instance.hasVeryNegativeTrustLevel)
		{
			return Class10.TrustRanks.VISITOR;
		}
		return Class10.TrustRanks.NUISANCE;
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x0000264C File Offset: 0x0000084C
	public static Color GetRankColor(this APIUser Instance)
	{
		return Instance.GetRank().GetRankColor();
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00008604 File Offset: 0x00006804
	public static Color GetRankColor(this Class10.TrustRanks Instance)
	{
		switch (Instance)
		{
		case Class10.TrustRanks.TRUSTED:
			return VRCPlayer.field_Internal_Static_Color_6;
		case Class10.TrustRanks.KNOWN:
			return VRCPlayer.field_Internal_Static_Color_5;
		case Class10.TrustRanks.USER:
			return VRCPlayer.field_Internal_Static_Color_4;
		case Class10.TrustRanks.NEW:
			return VRCPlayer.field_Internal_Static_Color_3;
		case Class10.TrustRanks.NUISANCE:
			return VRCPlayer.field_Internal_Static_Color_0;
		case Class10.TrustRanks.VISITOR:
			return VRCPlayer.field_Internal_Static_Color_2;
		case Class10.TrustRanks.MODERATOR:
			return VRCPlayer.field_Internal_Static_Color_8;
		default:
			return Color.black;
		}
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00008664 File Offset: 0x00006864
	public static string GetRankString(this Class10.TrustRanks Instance)
	{
		switch (Instance)
		{
		case Class10.TrustRanks.TRUSTED:
			return "Trusted";
		case Class10.TrustRanks.KNOWN:
			return "Known";
		case Class10.TrustRanks.USER:
			return "User";
		case Class10.TrustRanks.NEW:
			return "New";
		case Class10.TrustRanks.NUISANCE:
			return "Nuisance";
		case Class10.TrustRanks.VISITOR:
			return "Visitor";
		case Class10.TrustRanks.MODERATOR:
			return "Moderator";
		default:
			return "NO RANK";
		}
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00002659 File Offset: 0x00000859
	public static bool IsInstanceOwner(this Player player)
	{
		return Class10.IsInstanceOwner(player.UserID());
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00002666 File Offset: 0x00000866
	public static bool IsInstanceOwner(this VRCPlayer player)
	{
		return Class10.IsInstanceOwner(player.UserID());
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x000086C4 File Offset: 0x000068C4
	public static bool IsInstanceOwner(string UserID)
	{
		ApiWorldInstance apiWorldInstance = RoomManager.Method_Internal_Static_get_ApiWorldInstance_0();
		return ((apiWorldInstance != null) ? apiWorldInstance.ownerId : null) == UserID;
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00002673 File Offset: 0x00000873
	public static bool IsFriend(this APIUser player)
	{
		return APIUser.IsFriendsWith(player.UserID());
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00002680 File Offset: 0x00000880
	public static bool IsFriend(string UserID)
	{
		return APIUser.IsFriendsWith(UserID);
	}

	// Token: 0x060000DB RID: 219 RVA: 0x000086E8 File Offset: 0x000068E8
	public static bool IsFrozen(int Actor)
	{
		return Class143.dictionary_0.ContainsKey(Actor) && Class143.dictionary_0[Actor] < Class5.GetUnixTimeInMilliseconds() - 2500L;
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00002688 File Offset: 0x00000888
	public static bool CanHearMe(int Actor)
	{
		return InterestManager.Method_Public_Static_Boolean_Int32_PDM_0(Actor);
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00002690 File Offset: 0x00000890
	public static bool CanHearMe(this Player Player)
	{
		return InterestManager.Method_Public_Static_Boolean_Int32_PDM_0(Player.ActorID());
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00008720 File Offset: 0x00006920
	public static void ReloadAvatar(this APIUser Instance)
	{
		VRCPlayer.Method_Public_Static_Void_APIUser_0(Instance);
	}

	// Token: 0x060000DF RID: 223 RVA: 0x0000269D File Offset: 0x0000089D
	internal static bool wwOJtASEbGAPZAlkOLi()
	{
		return Class10.W0PtgdSkQebqcxHmnDk == null;
	}

	// Token: 0x04000026 RID: 38
	private static Class10 W0PtgdSkQebqcxHmnDk;

	// Token: 0x02000012 RID: 18
	public enum TrustRanks
	{
		// Token: 0x04000028 RID: 40
		TRUSTED,
		// Token: 0x04000029 RID: 41
		KNOWN,
		// Token: 0x0400002A RID: 42
		USER,
		// Token: 0x0400002B RID: 43
		NEW,
		// Token: 0x0400002C RID: 44
		NUISANCE,
		// Token: 0x0400002D RID: 45
		VISITOR,
		// Token: 0x0400002E RID: 46
		MODERATOR
	}

	// Token: 0x02000013 RID: 19
	public enum Device
	{
		// Token: 0x04000030 RID: 48
		Unknown,
		// Token: 0x04000031 RID: 49
		Quest,
		// Token: 0x04000032 RID: 50
		Mobile,
		// Token: 0x04000033 RID: 51
		Desktop,
		// Token: 0x04000034 RID: 52
		VR
	}

	// Token: 0x02000014 RID: 20
	public enum APIDevice
	{
		// Token: 0x04000036 RID: 54
		Unknown,
		// Token: 0x04000037 RID: 55
		Android,
		// Token: 0x04000038 RID: 56
		Windows,
		// Token: 0x04000039 RID: 57
		IOS
	}
}
