using System;
using Hexed.UIApi;
using Photon.Realtime;
using VRC;
using VRC.Core;
using VRC.SDKBase;
using VRC.UI.Elements.Menus;

// Token: 0x02000010 RID: 16
internal static class Class9
{
	// Token: 0x06000088 RID: 136 RVA: 0x000024D0 File Offset: 0x000006D0
	public static APIUser smethod_0(this Player Instance)
	{
		return Instance.Method_Internal_get_APIUser_0();
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00007D08 File Offset: 0x00005F08
	public static APIUser smethod_1(this VRCPlayer Instance)
	{
		Player player = Instance._player;
		if (player == null)
		{
			return null;
		}
		return player.Method_Internal_get_APIUser_0();
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00007D28 File Offset: 0x00005F28
	public static APIUser smethod_2(this PlayerNet Instance)
	{
		Player player = Instance.GetPlayer();
		if (player == null)
		{
			return null;
		}
		return player.Method_Internal_get_APIUser_0();
	}

	// Token: 0x0600008B RID: 139 RVA: 0x000024D8 File Offset: 0x000006D8
	public static Player GetPlayer(this VRCPlayer Instance)
	{
		return Instance._player;
	}

	// Token: 0x0600008C RID: 140 RVA: 0x000024E0 File Offset: 0x000006E0
	public static Player GetPlayer(this PlayerNet Instance)
	{
		return Instance.Method_Public_get_Player_0();
	}

	// Token: 0x0600008D RID: 141 RVA: 0x000024E8 File Offset: 0x000006E8
	public static Player GetPlayer(this Player Instance)
	{
		return Instance.field_Public_Player_0;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00007D48 File Offset: 0x00005F48
	public static Player GetPlayer(this PlayerManager instance, string UserID)
	{
		if (UserID == null)
		{
			return null;
		}
		foreach (Player player in instance.GetAllPlayers())
		{
			if (player.Method_Public_get_String_PDM_0() == UserID)
			{
				return player;
			}
		}
		return null;
	}

	// Token: 0x0600008F RID: 143 RVA: 0x000024F0 File Offset: 0x000006F0
	public static Player[] GetAllPlayers(this PlayerManager instance)
	{
		return instance.field_Private_List_1_Player_0.ToArray();
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002502 File Offset: 0x00000702
	public static VRCPlayer GetVRCPlayer(this PlayerNet Instance)
	{
		return Instance._vrcPlayer;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x0000250A File Offset: 0x0000070A
	public static VRCPlayer GetVRCPlayer(this Player player)
	{
		return player._vrcplayer;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00002512 File Offset: 0x00000712
	public static IUser GetIUser(this VRCPlayer Instance)
	{
		return Instance.Method_Public_Virtual_Final_New_get_IUser_0();
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00007D94 File Offset: 0x00005F94
	public static IUser GetIUser(this Player Instance)
	{
		VRCPlayer vrcplayer = Instance._vrcplayer;
		if (vrcplayer == null)
		{
			return null;
		}
		return vrcplayer.Method_Public_Virtual_Final_New_get_IUser_0();
	}

	// Token: 0x06000094 RID: 148 RVA: 0x0000251A File Offset: 0x0000071A
	public static ApiAvatar GetAvatar(this VRCPlayer player)
	{
		return player.Method_Public_get_ApiAvatar_0();
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00002522 File Offset: 0x00000722
	public static ApiAvatar GetFallbackAvatar(this VRCPlayer player)
	{
		return player.Method_Public_get_ApiAvatar_1();
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00007DB4 File Offset: 0x00005FB4
	public static ApiAvatar GetAvatar(this Player Instance)
	{
		VRCPlayer vrcplayer = Instance._vrcplayer;
		if (vrcplayer == null)
		{
			return null;
		}
		return vrcplayer.Method_Public_get_ApiAvatar_0();
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00007DD4 File Offset: 0x00005FD4
	public static ApiAvatar GetFallbackAvatar(this Player Instance)
	{
		VRCPlayer vrcplayer = Instance._vrcplayer;
		if (vrcplayer == null)
		{
			return null;
		}
		return vrcplayer.Method_Public_get_ApiAvatar_1();
	}

	// Token: 0x06000098 RID: 152 RVA: 0x0000252A File Offset: 0x0000072A
	public static VRCPlayerApi GetVRCPlayerApi(this Player Instance)
	{
		return Instance.Method_Public_get_VRCPlayerApi_0();
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00002532 File Offset: 0x00000732
	public static VRCPlayerApi GetVRCPlayerApi(this VRCPlayer Instance)
	{
		return Instance.Method_Public_get_VRCPlayerApi_0();
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00007DF4 File Offset: 0x00005FF4
	public static VRCPlayerApi GetVRCPlayerApi(this PlayerNet Instance)
	{
		Player player = Instance.GetPlayer();
		if (player == null)
		{
			return null;
		}
		return player.Method_Public_get_VRCPlayerApi_0();
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00007E14 File Offset: 0x00006014
	public static Player GetPhotonPlayer(this PlayerNet Instance)
	{
		Player player = Instance.GetPlayer();
		if (player == null)
		{
			return null;
		}
		return player.Method_Public_get_Player_0();
	}

	// Token: 0x0600009C RID: 156 RVA: 0x0000253A File Offset: 0x0000073A
	public static Player GetPhotonPlayer(this Player Instance)
	{
		return Instance.Method_Public_get_Player_0();
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00007E34 File Offset: 0x00006034
	public static Player GetPhotonPlayer(this VRCPlayer Instance)
	{
		Player player = Instance._player;
		if (player == null)
		{
			return null;
		}
		return player.Method_Public_get_Player_0();
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00002542 File Offset: 0x00000742
	public static PlayerNet GetPlayerNet(this Player Instance)
	{
		return Instance._playerNet;
	}

	// Token: 0x0600009F RID: 159 RVA: 0x0000254A File Offset: 0x0000074A
	public static PlayerNet GetPlayerNet(this VRCPlayer Instance)
	{
		return Instance._playerNet;
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00002552 File Offset: 0x00000752
	public static string UserID(this Player Instance)
	{
		return Instance.Method_Public_get_String_PDM_0();
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00007E54 File Offset: 0x00006054
	public static string UserID(this VRCPlayer Instance)
	{
		string result;
		try
		{
			Player player = Instance._player;
			result = ((player != null) ? player.Method_Public_get_String_PDM_0() : null);
		}
		catch
		{
			result = "No UserID";
		}
		return result;
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00007E94 File Offset: 0x00006094
	public static string UserID(this PlayerNet Instance)
	{
		string result;
		try
		{
			Player player = Instance.GetPlayer();
			result = ((player != null) ? player.Method_Public_get_String_PDM_0() : null);
		}
		catch
		{
			result = "No UserID";
		}
		return result;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x0000255A File Offset: 0x0000075A
	public static string UserID(this APIUser Instance)
	{
		return Instance.id;
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00007ED4 File Offset: 0x000060D4
	public static string DisplayName(this Player Instance)
	{
		string result;
		try
		{
			APIUser apiuser = Instance.Method_Internal_get_APIUser_0();
			result = ((apiuser != null) ? apiuser.displayName : null);
		}
		catch
		{
			result = "No DisplayName";
		}
		return result;
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00007F14 File Offset: 0x00006114
	public static string DisplayName(this VRCPlayer Instance)
	{
		string result;
		try
		{
			APIUser apiuser = Instance.smethod_1();
			result = ((apiuser == null) ? null : apiuser.displayName);
		}
		catch
		{
			result = "No DisplayName";
		}
		return result;
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00007F54 File Offset: 0x00006154
	public static string DisplayName(this PlayerNet Instance)
	{
		string result;
		try
		{
			APIUser apiuser = Instance.smethod_2();
			result = ((apiuser != null) ? apiuser.displayName : null);
		}
		catch
		{
			result = "No DisplayName";
		}
		return result;
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00002562 File Offset: 0x00000762
	public static string DisplayName(this APIUser Instance)
	{
		return Instance.displayName;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00007F94 File Offset: 0x00006194
	public static VRCAvatarManager GetVRCAvatarManager(this Player player)
	{
		VRCPlayer vrcplayer = player._vrcplayer;
		if (vrcplayer == null)
		{
			return null;
		}
		return vrcplayer.Method_Public_get_VRCAvatarManager_0();
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x0000256A File Offset: 0x0000076A
	public static USpeaker smethod_3(this Player player)
	{
		return player.Method_Public_get_USpeaker_0();
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00002572 File Offset: 0x00000772
	public static USpeaker smethod_4(this VRCPlayer player)
	{
		return player.Method_Public_get_USpeaker_0();
	}

	// Token: 0x060000AB RID: 171 RVA: 0x0000257A File Offset: 0x0000077A
	public static Player GetSelectedPlayer()
	{
		return MenuHelper.selectedUserMenu.SelectedPlayer();
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00007FB4 File Offset: 0x000061B4
	private static Player SelectedPlayer(this SelectedUserMenuQM selectedUserMenuQM_0)
	{
		if (selectedUserMenuQM_0.field_Private_IUser_0 != null)
		{
			return Class3.PlayerManager.GetPlayer(selectedUserMenuQM_0.field_Private_IUser_0.Method_Public_Abstract_Virtual_New_get_String_0());
		}
		return null;
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00002586 File Offset: 0x00000786
	internal static bool WTfN35SYROiHN9nBAtP()
	{
		return Class9.ugX9d5SLR1nEJmA9YCP == null;
	}

	// Token: 0x04000025 RID: 37
	internal static Class9 ugX9d5SLR1nEJmA9YCP;
}
