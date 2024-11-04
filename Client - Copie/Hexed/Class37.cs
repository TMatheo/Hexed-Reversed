using System;
using Hexed.UIApi;
using Hexed.Wrappers;
using UnityEngine;
using VRC;
using VRC.Core;

// Token: 0x0200004B RID: 75
internal class Class37 : Interface2
{
	// Token: 0x06000235 RID: 565 RVA: 0x00002C17 File Offset: 0x00000E17
	public void Initialize()
	{
		Class37.AddDebugLevels();
		Class37.DestroyAnalytics();
	}

	// Token: 0x06000236 RID: 566 RVA: 0x0000C038 File Offset: 0x0000A238
	public void OnUpdate()
	{
		if (!Class4.IsInWorld())
		{
			return;
		}
		if (MenuHelper.QuickMenu != null && MenuHelper.QuickMenu.isActiveAndEnabled)
		{
			TimeSpan timeSpan = TimeSpan.FromMilliseconds((double)(Class5.GetUnixTimeInMilliseconds() - Class143.long_0));
			string str = string.Format("{0:00}:{1:00}:{2:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
			if (Class118.textMeshProUGUI_0 != null)
			{
				Class118.textMeshProUGUI_0.text = "Room: " + str;
			}
		}
		if (VRCUiCursorManager.field_Private_Static_VRCUiCursorManager_0.field_Private_EnumNPublicSealedvaNoRiLe4vUnique_0 == null)
		{
			Camera.main.nearClipPlane = 0.001f;
			return;
		}
		Camera.main.nearClipPlane = 0.01f;
	}

	// Token: 0x06000237 RID: 567 RVA: 0x0000C0FC File Offset: 0x0000A2FC
	private static void AddDebugLevels()
	{
		if (!Class4.IsInVr())
		{
			Logger.AddDebugLevel(0);
			Logger.AddDebugLevel(1);
			Logger.AddDebugLevel(2);
			Logger.AddDebugLevel(3);
			Logger.AddDebugLevel(8);
			Logger.AddDebugLevel(4);
			Logger.AddDebugLevel(6);
			Logger.AddDebugLevel(7);
			Logger.AddDebugLevel(9);
			return;
		}
	}

	// Token: 0x06000238 RID: 568 RVA: 0x0000C148 File Offset: 0x0000A348
	private static void DestroyAnalytics()
	{
		VRCApplication vrcapplication = VRCApplication.Method_Internal_Static_get_VRCApplication_PDM_0();
		GameObject gameObject;
		if (vrcapplication != null)
		{
			Transform transform = vrcapplication.transform.Find("AnalyticsManager");
			gameObject = ((transform != null) ? transform.gameObject : null);
		}
		else
		{
			gameObject = null;
		}
		GameObject gameObject2 = gameObject;
		if (gameObject2 == null)
		{
			Logger.LogError("AnalyticsManager not found");
			return;
		}
		Object.DestroyImmediate(gameObject2);
		Logger.Log("Removed AnalyticsManager from Scene", Logger.LogsType.Protection);
	}

	// Token: 0x06000239 RID: 569 RVA: 0x0000C1A8 File Offset: 0x0000A3A8
	public static void ReloadAvatars()
	{
		Player[] allPlayers = Class3.PlayerManager.GetAllPlayers();
		for (int i = 0; i < allPlayers.Length; i++)
		{
			allPlayers[i].smethod_0().ReloadAvatar();
		}
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00002C23 File Offset: 0x00000E23
	internal static bool jeaXR4Nsw2I5pAKcTPm()
	{
		return Class37.Q16OxCN3vhB21nbIUhI == null;
	}

	// Token: 0x040000FC RID: 252
	internal static Class37 Q16OxCN3vhB21nbIUhI;
}
