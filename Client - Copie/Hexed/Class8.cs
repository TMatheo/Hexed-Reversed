using System;
using System.Collections.Generic;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Photon.Realtime;
using VRC.Core;

// Token: 0x0200000F RID: 15
internal static class Class8
{
	// Token: 0x0600006F RID: 111 RVA: 0x0000249C File Offset: 0x0000069C
	public static int ActorID(this Player player)
	{
		return player.Method_Public_get_Int32_0();
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00007688 File Offset: 0x00005888
	public static Hashtable GetProperties(this Player player)
	{
		Hashtable hashtable = (player == null) ? null : player.GetNetworkedProperties();
		if (hashtable != null)
		{
			return hashtable;
		}
		if (player == null)
		{
			return null;
		}
		return player.Method_Public_get_Hashtable_0();
	}

	// Token: 0x06000071 RID: 113 RVA: 0x000076B8 File Offset: 0x000058B8
	private static Hashtable GetNetworkedProperties(this Player player)
	{
		if (Class8.dictionary_0.ContainsKey(player.Method_Public_get_Int32_0()))
		{
			return Class8.dictionary_0[player.Method_Public_get_Int32_0()];
		}
		return null;
	}

	// Token: 0x06000072 RID: 114 RVA: 0x000076EC File Offset: 0x000058EC
	public static Player[] GetAllPhotonPlayers(this VRCNetworkingClient Instance)
	{
		Il2CppReferenceArray<KeyValuePair<int, Player>> il2CppReferenceArray = Instance.Method_Public_get_Room_0().Method_Public_get_ConcurrentDictionary_2_Int32_Player_0().ToArray();
		Player[] array = new Player[il2CppReferenceArray.Count];
		for (int i = 0; i < array.Length; i++)
		{
			Player[] array2 = array;
			int num = i;
			KeyValuePair<int, Player> keyValuePair = il2CppReferenceArray[i];
			array2[num] = ((keyValuePair != null) ? keyValuePair.Value : null);
		}
		return array;
	}

	// Token: 0x06000073 RID: 115 RVA: 0x000024A4 File Offset: 0x000006A4
	public static int GetActorCount(this VRCNetworkingClient Instance)
	{
		return Instance.Method_Public_get_Room_0().Method_Public_get_ConcurrentDictionary_2_Int32_Player_0().Count;
	}

	// Token: 0x06000074 RID: 116 RVA: 0x000024B6 File Offset: 0x000006B6
	public static bool IsMaster(this Player player)
	{
		return player.Method_Public_get_Boolean_PDM_0();
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00007748 File Offset: 0x00005948
	public static Player GetPhotonPlayer(this VRCNetworkingClient Instance, int photonID)
	{
		Player[] allPhotonPlayers = Instance.GetAllPhotonPlayers();
		for (int i = 0; i < allPhotonPlayers.Length; i++)
		{
			if (allPhotonPlayers[i].Method_Public_get_Int32_0() == photonID)
			{
				return allPhotonPlayers[i];
			}
		}
		return null;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00007788 File Offset: 0x00005988
	public static Player GetPhotonPlayer(this VRCNetworkingClient Instance, string UserID)
	{
		Player[] allPhotonPlayers = Instance.GetAllPhotonPlayers();
		for (int i = 0; i < allPhotonPlayers.Length; i++)
		{
			if (allPhotonPlayers[i].UserID() == UserID)
			{
				return allPhotonPlayers[i];
			}
		}
		return null;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x000024BE File Offset: 0x000006BE
	public static Player GetCurrentPlayer(this VRCNetworkingClient Instance)
	{
		return Instance.Method_Public_get_Player_0();
	}

	// Token: 0x06000078 RID: 120 RVA: 0x000077CC File Offset: 0x000059CC
	public static string DisplayName(this Player player)
	{
		Hashtable hashtable = (player != null) ? player.GetProperties() : null;
		if (hashtable != null && hashtable.ContainsKey("user"))
		{
			Dictionary<string, Object> dictionary = player.GetProperties()["user"].TryCast<Dictionary<string, Object>>();
			if (dictionary != null && dictionary.ContainsKey("displayName"))
			{
				Object @object = dictionary["displayName"];
				if (@object == null)
				{
					return null;
				}
				return @object.ToString();
			}
		}
		return null;
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00007848 File Offset: 0x00005A48
	public static string GetPlatform(this Player player)
	{
		Hashtable hashtable = (player != null) ? player.GetProperties() : null;
		if (hashtable != null && hashtable.ContainsKey("user"))
		{
			Dictionary<string, Object> dictionary = player.GetProperties()["user"].TryCast<Dictionary<string, Object>>();
			if (dictionary != null && dictionary.ContainsKey("last_platform"))
			{
				Object @object = dictionary["last_platform"];
				if (@object == null)
				{
					return null;
				}
				return @object.ToString();
			}
		}
		return null;
	}

	// Token: 0x0600007A RID: 122 RVA: 0x000078C4 File Offset: 0x00005AC4
	public static string UserID(this Player player)
	{
		Hashtable hashtable = (player != null) ? player.GetProperties() : null;
		if (hashtable != null && hashtable.ContainsKey("user"))
		{
			Dictionary<string, Object> dictionary = player.GetProperties()["user"].TryCast<Dictionary<string, Object>>();
			if (dictionary != null && dictionary.ContainsKey("id"))
			{
				Object @object = dictionary["id"];
				if (@object == null)
				{
					return null;
				}
				return @object.ToString();
			}
		}
		return null;
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00007940 File Offset: 0x00005B40
	public static string AvatarID(this Player player)
	{
		Hashtable hashtable = (player != null) ? player.GetProperties() : null;
		if (hashtable != null && hashtable.ContainsKey("avatarDict"))
		{
			Dictionary<string, Object> dictionary = player.GetProperties()["avatarDict"].TryCast<Dictionary<string, Object>>();
			if (dictionary != null && dictionary.ContainsKey("id"))
			{
				Object @object = dictionary["id"];
				if (@object == null)
				{
					return null;
				}
				return @object.ToString();
			}
		}
		return null;
	}

	// Token: 0x0600007C RID: 124 RVA: 0x000079BC File Offset: 0x00005BBC
	public static string AvatarName(this Player player)
	{
		Hashtable hashtable = (player == null) ? null : player.GetProperties();
		if (hashtable != null && hashtable.ContainsKey("avatarDict"))
		{
			Dictionary<string, Object> dictionary = player.GetProperties()["avatarDict"].TryCast<Dictionary<string, Object>>();
			if (dictionary != null && dictionary.ContainsKey("name"))
			{
				Object @object = dictionary["name"];
				if (@object == null)
				{
					return null;
				}
				return @object.ToString();
			}
		}
		return null;
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00007A38 File Offset: 0x00005C38
	public static string AvatarAuthorName(this Player player)
	{
		Hashtable hashtable = (player == null) ? null : player.GetProperties();
		if (hashtable != null && hashtable.ContainsKey("avatarDict"))
		{
			Dictionary<string, Object> dictionary = player.GetProperties()["avatarDict"].TryCast<Dictionary<string, Object>>();
			if (dictionary != null && dictionary.ContainsKey("authorName"))
			{
				Object @object = dictionary["authorName"];
				if (@object == null)
				{
					return null;
				}
				return @object.ToString();
			}
		}
		return null;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00007AB4 File Offset: 0x00005CB4
	public static string AvatarReleaseStatus(this Player player)
	{
		Hashtable hashtable = (player != null) ? player.GetProperties() : null;
		if (hashtable != null && hashtable.ContainsKey("avatarDict"))
		{
			Dictionary<string, Object> dictionary = player.GetProperties()["avatarDict"].TryCast<Dictionary<string, Object>>();
			if (dictionary != null && dictionary.ContainsKey("releaseStatus"))
			{
				Object @object = dictionary["releaseStatus"];
				if (@object == null)
				{
					return null;
				}
				return @object.ToString();
			}
		}
		return null;
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00007B30 File Offset: 0x00005D30
	public static bool IsVR(this Player player)
	{
		return player.GetProperties().ContainsKey("inVRMode") && player.GetProperties()["inVRMode"].Unbox<bool>();
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00007B70 File Offset: 0x00005D70
	public static bool IsInstanceModerator(this Player player)
	{
		return player.GetProperties().ContainsKey("canModerateInstance") && player.GetProperties()["canModerateInstance"].Unbox<bool>();
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00007BB0 File Offset: 0x00005DB0
	public static int AvatarHeight(this Player player)
	{
		if (player.GetProperties().ContainsKey("avatarEyeHeight"))
		{
			return player.GetProperties()["avatarEyeHeight"].Unbox<int>();
		}
		return 0;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00007BF0 File Offset: 0x00005DF0
	public static string RepresentedGroupID(this Player player)
	{
		if (!player.GetProperties().ContainsKey("groupOnNameplate"))
		{
			return null;
		}
		return player.GetProperties()["groupOnNameplate"].ToString();
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00007C30 File Offset: 0x00005E30
	public static bool ShowGroupToOthers(this Player player)
	{
		return player.GetProperties().ContainsKey("showGroupBadgeToOthers") && player.GetProperties()["showGroupBadgeToOthers"].Unbox<bool>();
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00007C70 File Offset: 0x00005E70
	public static bool ShowSocialRankToOthers(this Player player)
	{
		return player.GetProperties().ContainsKey("showSocialRank") && player.GetProperties()["showSocialRank"].Unbox<bool>();
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00007CB0 File Offset: 0x00005EB0
	public static bool UseImpostorAsFallback(this Player player)
	{
		return player.GetProperties().ContainsKey("useImpostorAsFallback") && player.GetProperties()["useImpostorAsFallback"].Unbox<bool>();
	}

	// Token: 0x06000087 RID: 135 RVA: 0x000024C6 File Offset: 0x000006C6
	internal static bool o1MKLQS3ULTXrkLQ4Xc()
	{
		return Class8.AvJBFSSwepXxVoGR8RB == null;
	}

	// Token: 0x04000023 RID: 35
	public static Dictionary<int, Hashtable> dictionary_0 = new Dictionary<int, Hashtable>();

	// Token: 0x04000024 RID: 36
	private static Class8 AvJBFSSwepXxVoGR8RB;
}
