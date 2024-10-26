using System;
using Hexed.UIApi;
using Hexed.Wrappers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200011A RID: 282
internal class Class118
{
	// Token: 0x060005A3 RID: 1443 RVA: 0x0001C764 File Offset: 0x0001A964
	public static void ApplyLateChanges()
	{
		Class118.ChangeHeader();
		Class118.RemoveAds();
		Class118.ColorActionMenu();
		Class118.ChangeDebugPanel();
		Class118.ChangeMainButtons();
		Class118.CreateConsole();
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x00003365 File Offset: 0x00001565
	public static void ApplyEarlyChanges()
	{
		Class118.RemoveLoadingBackground();
		Class118.ColorHUD();
	}

	// Token: 0x060005A5 RID: 1445 RVA: 0x0001C790 File Offset: 0x0001A990
	private static void ChangeHeader()
	{
		Transform transform = MenuHelper.menuPageTemplate.transform.Find("Header_H1/LeftItemContainer/Text_Title");
		if (transform != null)
		{
			transform.GetComponent<TextMeshProUGUI>().text = "                  愛 H E X E D 毒";
			return;
		}
		Logger.LogError("Failed to find Text_Title");
	}

	// Token: 0x060005A6 RID: 1446 RVA: 0x0001C7DC File Offset: 0x0001A9DC
	private static void ChangeDebugPanel()
	{
		Transform transform = MenuHelper.QuickMenu.transform.Find("CanvasGroup/Container/Window/Panel_QM_Widget/Panel_QM_DebugInfo/Panel/Background");
		if (transform != null)
		{
			transform.localPosition = Vector3.zero;
			transform.gameObject.SetActive(false);
		}
		else
		{
			Logger.LogError("Failed to find DebugInfoPanelBackground");
		}
		Transform transform2 = MenuHelper.QuickMenu.transform.Find("CanvasGroup/Container/Window/Panel_QM_Widget/Panel_QM_DebugInfo/Panel/Text_Ping");
		if (!(transform2 != null))
		{
			Logger.LogError("Failed to find DebugPanel");
			return;
		}
		Transform transform3 = Object.Instantiate<Transform>(transform2, MenuHelper.QuickMenu.transform.Find("CanvasGroup/Container/Window/Panel_QM_Widget/Panel_QM_DebugInfo/Panel"));
		transform3.name = "HexedDebugPanel";
		transform3.GetComponent<RectTransform>().localPosition += new Vector3(200f, 0f, 0f);
		transform3.GetComponent<RectTransform>().sizeDelta = new Vector2(600f, 0f);
		Class118.textMeshProUGUI_0 = transform3.GetComponent<TextMeshProUGUI>();
	}

	// Token: 0x060005A7 RID: 1447 RVA: 0x0001C8D0 File Offset: 0x0001AAD0
	private static void RemoveAds()
	{
		Transform transform = MenuHelper.QuickMenu.transform.Find("CanvasGroup/Container/Window/QMParent/Menu_Camera/Scrollrect/Viewport/VerticalLayoutGroup/Buttons (1)/Panel_Info");
		if (transform != null)
		{
			transform.localScale = Vector3.zero;
			transform.gameObject.SetActive(false);
		}
		else
		{
			Logger.LogError("Failed to find PanelInfo");
		}
		Transform transform2 = MenuHelper.userInterface.Find("PlayerDisplay/BlackFade/inverted_sphere");
		if (transform2 != null)
		{
			transform2.localScale = Vector3.zero;
			transform2.gameObject.SetActive(false);
		}
		else
		{
			Logger.LogError("Failed to find inverted_sphere");
		}
		Transform transform3 = MenuHelper.QuickMenu.transform.Find("CanvasGroup/Container/ThankYouCharacter/Character");
		if (!(transform3 != null))
		{
			Logger.LogError("Failed to find Character");
		}
		else
		{
			transform3.localScale = Vector3.zero;
			transform3.gameObject.SetActive(false);
		}
		Transform transform4 = MenuHelper.QuickMenu.transform.Find("CanvasGroup/Container/ThankYouCharacter/Dialog Bubble");
		if (transform4 != null)
		{
			transform4.localScale = Vector3.zero;
			transform4.gameObject.SetActive(false);
		}
		else
		{
			Logger.LogError("Failed to find Dialog Buble");
		}
		Transform transform5 = MenuHelper.menuPageTemplate.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup/VRC+_Banners");
		if (transform5 != null)
		{
			transform5.localScale = Vector3.zero;
			transform5.gameObject.SetActive(false);
		}
		else
		{
			Logger.LogError("Failed to find VRC+_Banners");
		}
		Transform transform6 = MenuHelper.menuPageTemplate.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup/Carousel_Banners");
		if (transform6 != null)
		{
			transform6.localScale = Vector3.zero;
			transform6.gameObject.SetActive(false);
		}
		else
		{
			Logger.LogError("Failed to find Carousel_Banners");
		}
		Transform transform7 = MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_Dashboard/ScrollRect_MM/Viewport/Content/Panel/Carousel_Banners");
		if (transform7 != null)
		{
			transform7.localScale = Vector3.zero;
			transform7.gameObject.SetActive(false);
		}
		else
		{
			Logger.LogError("Failed to find Main Carousel_Banners");
		}
		Transform transform8 = MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_MM_Profile/ScrollRect/Viewport/VerticalLayoutGroup/Row1/Profile/DetailsArea/UserIconAndCredits/Panel_MM_CreditsButton");
		if (transform8 != null)
		{
			transform8.localScale = Vector3.zero;
			transform8.gameObject.SetActive(false);
		}
		else
		{
			Logger.LogError("Failed to find Main Panel_MM_CreditsButton");
		}
		Transform transform9 = MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_Avatars/Menu_MM_DynamicSidePanel/Panel_SectionList/ScrollRect_Navigation_Container/ScrollRect_Content/Viewport/VerticalLayoutGroup/VRC+ Upsell");
		if (!(transform9 != null))
		{
			Logger.LogError("Failed to find VRC+ Upsell");
		}
		else
		{
			transform9.localScale = Vector3.zero;
			transform9.gameObject.SetActive(false);
		}
		Transform transform10 = MenuHelper.MainMenu.transform.Find("Container/MMParent/Modal_MM_InviteResponse/MenuPanel/ScrollRect/Viewport/VerticalLayoutGroup/Panel_AddPhotoPrompt/Photo_VRCPlus_Message");
		if (transform10 != null)
		{
			transform10.localScale = Vector3.zero;
			transform10.gameObject.SetActive(false);
		}
		else
		{
			Logger.LogError("Failed to find Photo_VRCPlus_Message");
		}
		Transform transform11 = MenuHelper.QuickMenu.transform.Find("CanvasGroup/Container/Window/QMParent/Menu_QM_SocialIdentity/Panel_MM_Wallet");
		if (transform11 != null)
		{
			transform11.localScale = Vector3.zero;
			transform11.gameObject.SetActive(false);
		}
		else
		{
			Logger.LogError("Failed to find Panel_MM_Wallet");
		}
		Transform transform12 = MenuHelper.MainMenu.transform.Find("Container/Panel_MM_Wallet/Cell_Wallet_Contents");
		if (transform12 != null)
		{
			transform12.localScale = Vector3.zero;
			transform12.gameObject.SetActive(false);
			return;
		}
		Logger.LogError("Failed to find Cell_Wallet_Contents");
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x0001CC14 File Offset: 0x0001AE14
	private static void ChangeMainButtons()
	{
		MenuHelper.menuPageTemplate.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup").GetComponent<VerticalLayoutGroup>().enabled = false;
		MenuHelper.menuPageTemplate.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup/Header_QuickLinks").gameObject.SetActive(false);
		MenuHelper.menuPageTemplate.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup/Header_QuickActions").gameObject.SetActive(false);
		Transform transform = MenuHelper.menuPageTemplate.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks");
		transform.transform.localPosition = new Vector3(0f, -110f, 0f);
		transform.GetComponent<GridLayoutGroup>().cellSize = new Vector2(200f, 86f);
		foreach (Transform transform2 in transform.GetComponentsInChildren<Transform>())
		{
			if (transform2.name.Contains("Button_"))
			{
				Transform transform3 = transform2.transform.Find("Icons");
				if (transform3 != null)
				{
					transform3.gameObject.SetActive(false);
				}
				Transform transform4 = transform2.transform.Find("Badge_MMJump");
				if (transform4 != null)
				{
					transform4.gameObject.SetActive(false);
				}
			}
		}
		Transform transform5 = MenuHelper.menuPageTemplate.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions");
		transform5.transform.localPosition = new Vector3(0f, -860f, 0f);
		transform5.GetComponent<GridLayoutGroup>().cellSize = new Vector2(200f, 86f);
		foreach (Transform transform6 in transform5.GetComponentsInChildren<Transform>())
		{
			if (transform6.name.Contains("Button_"))
			{
				Transform transform7 = transform6.transform.Find("Icons");
				if (transform7 != null)
				{
					transform7.gameObject.SetActive(false);
				}
				Transform transform8 = transform6.transform.Find("Badge_MMJump");
				if (transform8 != null)
				{
					transform8.gameObject.SetActive(false);
				}
			}
		}
		Transform transform9 = MenuHelper.menuPageTemplate.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton");
		transform9.GetComponent<GridLayoutGroup>().cellSize = new Vector2(200f, 86f);
		foreach (Transform transform10 in transform9.GetComponentsInChildren<Transform>(true))
		{
			Transform transform11 = transform10.transform.Find("Icons");
			if (transform11 != null)
			{
				transform11.gameObject.SetActive(false);
			}
			Transform transform12 = transform10.transform.Find("Badge_MMJump");
			if (transform12 != null)
			{
				transform12.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x0001CF1C File Offset: 0x0001B11C
	private static void ColorActionMenu()
	{
		foreach (PedalGraphic pedalGraphic in Resources.FindObjectsOfTypeAll<PedalGraphic>())
		{
			if (pedalGraphic._texture != null)
			{
				pedalGraphic._texture = pedalGraphic._texture.smethod_0().Desaturate();
				pedalGraphic.color = new Color(0.35f, 0.35f, 0.35f);
			}
		}
		foreach (ActionMenu actionMenu in Resources.FindObjectsOfTypeAll<ActionMenu>())
		{
			Image componentInChildren = actionMenu.transform.Find("Main/Cursor").GetComponentInChildren<Image>();
			if (componentInChildren == null)
			{
				break;
			}
			componentInChildren.sprite = componentInChildren.sprite.ReplaceTexture(componentInChildren.sprite.UnpackTexture().Desaturate());
		}
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x0001D02C File Offset: 0x0001B22C
	private static void CreateConsole()
	{
		GameObject gameObject = Object.Instantiate<GameObject>(MenuHelper.singleButtonTemplate.transform.Find("Background").gameObject, MenuHelper.menuPageTemplate.transform);
		gameObject.name = "HexedConsole";
		gameObject.GetComponent<Image>().sprite = Class11.GetSprite("Console");
		gameObject.GetComponent<Image>().overrideSprite = Class11.GetSprite("Console");
		gameObject.GetComponent<Image>().color = Color.white;
		gameObject.transform.localScale = new Vector3(0.88f, 0.55f, 1f);
		gameObject.transform.localPosition = new Vector3(0f, 460f, 0f);
		gameObject.AddComponent<RectMask2D>();
		Class118.uimenuText_0 = new UIMenuText(gameObject.gameObject, "", new Vector2(-310f, -370f), 26, false, 6);
		Class118.uimenuText_0.TextObject.transform.localScale = new Vector3(1f, 1.55f, 1f);
		Class118.uimenuText_0.text.color = Color.grey;
	}

	// Token: 0x060005AB RID: 1451 RVA: 0x0001D150 File Offset: 0x0001B350
	public static void ChangeTrustColors()
	{
		VRCPlayer.field_Internal_Static_Color_0 = new Color(0.72f, 0.13f, 0.11f);
		VRCPlayer.field_Internal_Static_Color_1 = Color.yellow;
		VRCPlayer.field_Internal_Static_Color_2 = new Color(0.35f, 0.35f, 0.35f);
		VRCPlayer.field_Internal_Static_Color_3 = new Color(0f, 1f, 1f);
		VRCPlayer.field_Internal_Static_Color_4 = new Color(0f, 1f, 0f);
		VRCPlayer.field_Internal_Static_Color_5 = new Color(1f, 0.42f, 0f);
		VRCPlayer.field_Internal_Static_Color_6 = new Color(0.7f, 0f, 0.51f);
		VRCPlayer.field_Internal_Static_Color_8 = Color.red;
	}

	// Token: 0x060005AC RID: 1452 RVA: 0x0001D208 File Offset: 0x0001B408
	private static void ColorHUD()
	{
		foreach (MonoBehaviourPublicImCoImVeCoBoVeSiAuVeUnique monoBehaviourPublicImCoImVeCoBoVeSiAuVeUnique in Resources.FindObjectsOfTypeAll<MonoBehaviourPublicImCoImVeCoBoVeSiAuVeUnique>())
		{
			monoBehaviourPublicImCoImVeCoBoVeSiAuVeUnique.field_Public_Color_0 = Color.white;
			monoBehaviourPublicImCoImVeCoBoVeSiAuVeUnique.field_Public_Color_1 = new Color(0.3f, 0.3f, 0.3f, monoBehaviourPublicImCoImVeCoBoVeSiAuVeUnique.field_Public_Color_1.a);
		}
	}

	// Token: 0x060005AD RID: 1453 RVA: 0x0001D288 File Offset: 0x0001B488
	private static void RemoveLoadingBackground()
	{
		Transform transform = VRCApplication.Method_Internal_Static_get_VRCApplication_PDM_0().transform.Find("TrackingVolume/VRLoadingOverlay");
		if (!(transform != null))
		{
			Logger.LogError("Failed to find LoadingBackground");
			return;
		}
		transform.localScale = Vector3.zero;
		transform.gameObject.SetActive(false);
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x00003371 File Offset: 0x00001571
	internal static bool WmYDtRIr2kmgWQJorTw()
	{
		return Class118.UIXOKnIfFtR0acHbZos == null;
	}

	// Token: 0x0400029D RID: 669
	public static TextMeshProUGUI textMeshProUGUI_0;

	// Token: 0x0400029E RID: 670
	public static UIMenuText uimenuText_0;

	// Token: 0x0400029F RID: 671
	private static Class118 UIXOKnIfFtR0acHbZos;
}
