using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using VRC.Localization;
using VRC.UI.Client.HUD;
using VRC.UI.Elements.Controls;

// Token: 0x02000042 RID: 66
internal static class Class34
{
	// Token: 0x1700005A RID: 90
	// (get) Token: 0x0600020D RID: 525 RVA: 0x0000B08C File Offset: 0x0000928C
	private static Hud_UserEventCarousel activeCarousel
	{
		get
		{
			if (Class34.hud_UserEventCarousel_0 == null)
			{
				Il2CppArrayBase<Hud_UserEventCarousel> il2CppArrayBase = Resources.FindObjectsOfTypeAll<Hud_UserEventCarousel>();
				Class34.hud_UserEventCarousel_0 = ((il2CppArrayBase == null) ? null : il2CppArrayBase[0]);
			}
			return Class34.hud_UserEventCarousel_0;
		}
	}

	// Token: 0x0600020E RID: 526 RVA: 0x0000B0C4 File Offset: 0x000092C4
	public static void HudMessage(string Text, Sprite icon = null)
	{
		if (Class34.activeCarousel == null)
		{
			return;
		}
		LocalizableString localizableString = LocalizableStringExtensions.Localize(Text, null, null, null);
		Class34.activeCarousel.Method_Private_Void_LocalizableString_Sprite_0(localizableString, icon);
	}

	// Token: 0x0600020F RID: 527 RVA: 0x0000B0F8 File Offset: 0x000092F8
	public static void HudToast(string content, string description = null, Sprite icon = null, float duration = 5f)
	{
		LocalizableString localizableString = LocalizableStringExtensions.Localize(content, null, null, null);
		LocalizableString localizableString2 = LocalizableStringExtensions.Localize(description, null, null, null);
		VRCUiManager.field_Private_Static_VRCUiManager_0.field_Private_HudController_0.notification.Method_Public_Void_Sprite_LocalizableString_LocalizableString_Single_Object1PublicTYBoTYUnique_1_Boolean_0(icon, localizableString, localizableString2, duration, null);
	}

	// Token: 0x06000210 RID: 528 RVA: 0x0000B138 File Offset: 0x00009338
	public static void AskInGameInput(this VRCUiPopupManager instance, string title, string okButtonName, Action<string> onSuccess, string placeholder = null)
	{
		instance.InputPopUp(title, okButtonName, delegate(string g)
		{
			onSuccess(g);
		}, placeholder);
	}

	// Token: 0x06000211 RID: 529 RVA: 0x0000B168 File Offset: 0x00009368
	private static void InputPopUp(this VRCUiPopupManager instance, string title, string okButtonName, Action<string> onSuccess, string placeholder = null)
	{
		LocalizableString localizableString = LocalizableStringExtensions.Localize(title, null, null, null);
		LocalizableString localizableString2 = LocalizableStringExtensions.Localize("", null, null, null);
		LocalizableString localizableString3 = LocalizableStringExtensions.Localize(okButtonName, null, null, null);
		LocalizableString localizableString4 = LocalizableStringExtensions.Localize(placeholder, null, null, null);
		instance.Method_Public_Void_LocalizableString_LocalizableString_InputType_Boolean_LocalizableString_Action_3_String_List_1_KeyCode_TextMeshProUGUIEx_Action_LocalizableString_Boolean_Action_1_VRCUiPopup_Boolean_Int32_0(localizableString, localizableString2, 0, false, localizableString3, delegate(string g, List<KeyCode> l, TextMeshProUGUIEx t)
		{
			if (string.Empty == g)
			{
				g = placeholder;
			}
			onSuccess(g);
		}, delegate()
		{
			Class3.VRCUiManager.HideScreen("POPUP");
		}, localizableString4 ?? localizableString2, true, null, false, 0);
	}

	// Token: 0x06000212 RID: 530 RVA: 0x0000B208 File Offset: 0x00009408
	public static void AlertNotification(this VRCUiPopupManager instance, string title, string Content, string okButtonName)
	{
		LocalizableString localizableString = LocalizableStringExtensions.Localize(title, null, null, null);
		LocalizableString localizableString2 = LocalizableStringExtensions.Localize(Content, null, null, null);
		LocalizableString localizableString3 = LocalizableStringExtensions.Localize(okButtonName, null, null, null);
		instance.Method_Public_Void_LocalizableString_LocalizableString_LocalizableString_Action_Action_1_VRCUiPopup_0(localizableString, localizableString2, localizableString3, delegate()
		{
			Class3.VRCUiManager.HideScreen("POPUP");
		}, null);
	}

	// Token: 0x06000213 RID: 531 RVA: 0x0000B268 File Offset: 0x00009468
	public static void ConfirmNotification(this VRCUiPopupManager instance, string title, string Content, string okButtonName, Action onSuccess)
	{
		LocalizableString localizableString = LocalizableStringExtensions.Localize(title, null, null, null);
		LocalizableString localizableString2 = LocalizableStringExtensions.Localize(Content, null, null, null);
		LocalizableString localizableString3 = LocalizableStringExtensions.Localize(okButtonName, null, null, null);
		LocalizableString localizableString4 = LocalizableStringExtensions.Localize(okButtonName, null, null, null);
		instance.Method_Public_Void_LocalizableString_LocalizableString_LocalizableString_Action_LocalizableString_Action_Action_1_VRCUiPopup_0(localizableString, localizableString2, localizableString3, delegate()
		{
			onSuccess();
			Class3.VRCUiManager.HideScreen("POPUP");
		}, localizableString4, delegate()
		{
			Class3.VRCUiManager.HideScreen("POPUP");
		}, null);
	}

	// Token: 0x06000214 RID: 532 RVA: 0x00002B9A File Offset: 0x00000D9A
	internal static bool XimoVZNCrkS4UuPPPaa()
	{
		return Class34.ivdBttNBral82KuqkYW == null;
	}

	// Token: 0x040000E6 RID: 230
	private static Hud_UserEventCarousel hud_UserEventCarousel_0;

	// Token: 0x040000E7 RID: 231
	internal static Class34 ivdBttNBral82KuqkYW;
}
