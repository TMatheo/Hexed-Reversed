using System;
using VRC;
using VRC.Core;
using VRC.Management;

// Token: 0x02000006 RID: 6
internal class Class3
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600001F RID: 31 RVA: 0x000023A8 File Offset: 0x000005A8
	public static VRCPlayer CurrentVRCPlayer
	{
		get
		{
			return VRCPlayer.field_Internal_Static_VRCPlayer_0;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000020 RID: 32 RVA: 0x000023AF File Offset: 0x000005AF
	public static Player CurrentPlayer
	{
		get
		{
			return Player.Method_Internal_Static_get_Player_0();
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000021 RID: 33 RVA: 0x000023B6 File Offset: 0x000005B6
	public static NetworkManager NetworkManager
	{
		get
		{
			return NetworkManager.field_Internal_Static_NetworkManager_0;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000022 RID: 34 RVA: 0x000023BD File Offset: 0x000005BD
	public static PlayerManager PlayerManager
	{
		get
		{
			return PlayerManager.Method_Public_Static_get_PlayerManager_0();
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000023 RID: 35 RVA: 0x000023C4 File Offset: 0x000005C4
	public static ModerationManager ModerationManager
	{
		get
		{
			return ModerationManager.Method_Public_Static_get_ModerationManager_PDM_0();
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000024 RID: 36 RVA: 0x000023CB File Offset: 0x000005CB
	public static VRCNetworkingClient VRCNetworkingClient
	{
		get
		{
			return VRCNetworkingClient.field_Internal_Static_VRCNetworkingClient_0;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000025 RID: 37 RVA: 0x000023D2 File Offset: 0x000005D2
	public static VRCUiManager VRCUiManager
	{
		get
		{
			return VRCUiManager.Method_Internal_Static_get_VRCUiManager_PDM_0();
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000026 RID: 38 RVA: 0x000023D9 File Offset: 0x000005D9
	public static VRCUiPopupManager VRCUiPopupManager
	{
		get
		{
			return VRCUiPopupManager.Method_Public_Static_get_VRCUiPopupManager_PDM_0();
		}
	}

	// Token: 0x06000028 RID: 40 RVA: 0x000023E0 File Offset: 0x000005E0
	internal static bool kZNOJVSXqnswTlW6fnZ()
	{
		return Class3.ypc3JhSFInyvmNKBhc8 == null;
	}

	// Token: 0x04000008 RID: 8
	private static Class3 ypc3JhSFInyvmNKBhc8;
}
