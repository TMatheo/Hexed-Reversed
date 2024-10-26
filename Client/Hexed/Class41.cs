using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.Core;

// Token: 0x02000051 RID: 81
internal class Class41 : Interface4
{
	// Token: 0x0600026B RID: 619 RVA: 0x0000D558 File Offset: 0x0000B758
	public void Initialize(VRCPlayer player)
	{
		this.vrcplayer_0 = player;
		PlayerNameplate field_Public_PlayerNameplate_ = this.vrcplayer_0.field_Public_PlayerNameplate_0;
		if (field_Public_PlayerNameplate_ == null)
		{
			return;
		}
		field_Public_PlayerNameplate_.field_Public_Sprite_4 = Class11.GetSprite("Nameplate", field_Public_PlayerNameplate_.field_Public_Sprite_4);
		field_Public_PlayerNameplate_.field_Public_Sprite_3 = field_Public_PlayerNameplate_.field_Public_Sprite_4;
		if (this.vrcplayer_0.smethod_1() == null)
		{
			return;
		}
		Color rankColor = this.vrcplayer_0.smethod_1().GetRankColor();
		field_Public_PlayerNameplate_.field_Public_Color_0 = new Color(rankColor.r, rankColor.g, rankColor.b, field_Public_PlayerNameplate_.field_Public_Color_0.a);
		field_Public_PlayerNameplate_.field_Public_Color_1 = new Color(rankColor.r, rankColor.g, rankColor.b, field_Public_PlayerNameplate_.field_Public_Color_1.a);
		if (field_Public_PlayerNameplate_.field_Public_GameObject_0 == null)
		{
			return;
		}
		Transform transform = field_Public_PlayerNameplate_.field_Public_GameObject_4.transform.Find("Friend Anchor Icon");
		GameObject gameObject = (transform == null) ? null : transform.gameObject;
		Transform transform2 = field_Public_PlayerNameplate_.field_Public_GameObject_4.transform.Find("Background");
		Image image = (transform2 != null) ? transform2.GetComponent<Image>() : null;
		GameObject gameObject2 = field_Public_PlayerNameplate_.field_Public_HorizontalLayoutGroup_0.gameObject;
		Graphic field_Public_Graphic_ = field_Public_PlayerNameplate_.field_Public_Graphic_1;
		Graphic field_Public_Graphic_2 = field_Public_PlayerNameplate_.field_Public_Graphic_4;
		Graphic field_Public_Graphic_3 = field_Public_PlayerNameplate_.field_Public_Graphic_5;
		Graphic field_Public_Graphic_4 = field_Public_PlayerNameplate_.field_Public_Graphic_6;
		Graphic field_Public_Graphic_5 = field_Public_PlayerNameplate_.field_Public_Graphic_7;
		Transform transform3 = field_Public_PlayerNameplate_.transform.parent.Find("Avatar Progress/Back");
		ImageThreeSlice imageThreeSlice = (transform3 == null) ? null : transform3.GetComponent<ImageThreeSlice>();
		Transform transform4 = field_Public_PlayerNameplate_.transform.parent.Find("Avatar Progress/Fill Container/Text");
		TextMeshProUGUI textMeshProUGUI = (transform4 == null) ? null : transform4.GetComponent<TextMeshProUGUI>();
		if (gameObject != null)
		{
			gameObject.SetActive(false);
		}
		if (gameObject2 != null)
		{
			gameObject2.SetActive(false);
		}
		if (field_Public_Graphic_2 != null)
		{
			field_Public_Graphic_2.color = new Color(rankColor.r, rankColor.g, rankColor.b, field_Public_Graphic_2.color.a);
		}
		if (field_Public_Graphic_4 != null)
		{
			field_Public_Graphic_4.color = new Color(rankColor.r, rankColor.g, rankColor.b, field_Public_Graphic_4.color.a);
		}
		if (field_Public_Graphic_5 != null)
		{
			field_Public_Graphic_5.color = new Color(rankColor.r, rankColor.g, rankColor.b, field_Public_Graphic_5.color.a);
		}
		if (field_Public_Graphic_3 != null)
		{
			field_Public_Graphic_3.color = new Color(rankColor.r, rankColor.g, rankColor.b, field_Public_Graphic_3.color.a);
		}
		if (image != null)
		{
			image.color = new Color(rankColor.r, rankColor.g, rankColor.b, image.color.a);
		}
		if (field_Public_Graphic_ != null)
		{
			field_Public_Graphic_.color = new Color(rankColor.r, rankColor.g, rankColor.b, field_Public_Graphic_.color.a);
		}
		if (imageThreeSlice != null)
		{
			imageThreeSlice.color = new Color(rankColor.r, rankColor.g, rankColor.b, imageThreeSlice.color.a);
		}
		if (textMeshProUGUI != null)
		{
			textMeshProUGUI.color = new Color(rankColor.r, rankColor.g, rankColor.b, textMeshProUGUI.color.a);
		}
		Transform parent = field_Public_PlayerNameplate_.transform.parent.parent.parent.parent;
		Transform transform5 = parent.Find("ChatBubble/Canvas/Chat");
		ImageThreeSlice imageThreeSlice2 = (transform5 == null) ? null : transform5.GetComponent<ImageThreeSlice>();
		Transform transform6 = parent.Find("ChatBubble/Canvas/TypingIndicator");
		ImageThreeSlice imageThreeSlice3 = (transform6 == null) ? null : transform6.GetComponent<ImageThreeSlice>();
		Transform transform7 = parent.Find("ChatBubbleMirror/Canvas/Chat");
		ImageThreeSlice imageThreeSlice4 = (transform7 == null) ? null : transform7.GetComponent<ImageThreeSlice>();
		Transform transform8 = parent.Find("ChatBubbleMirror/Canvas/TypingIndicator");
		ImageThreeSlice imageThreeSlice5 = (transform8 != null) ? transform8.GetComponent<ImageThreeSlice>() : null;
		Transform transform9 = parent.Find("CameraNameplate/Canvas/Container/Image");
		Image image2 = (transform9 != null) ? transform9.GetComponent<Image>() : null;
		Transform transform10 = parent.Find("CameraNameplate/Canvas/Container/Name");
		TextMeshProUGUI textMeshProUGUI2 = (transform10 == null) ? null : transform10.GetComponent<TextMeshProUGUI>();
		Transform transform11 = parent.Find("CameraNameplate/Canvas/Container");
		ImageThreeSlice imageThreeSlice6 = (transform11 != null) ? transform11.GetComponent<ImageThreeSlice>() : null;
		if (imageThreeSlice2 != null)
		{
			imageThreeSlice2.color = new Color(rankColor.r, rankColor.g, rankColor.b, imageThreeSlice2.color.a);
		}
		if (imageThreeSlice3 != null)
		{
			imageThreeSlice3.color = new Color(rankColor.r, rankColor.g, rankColor.b, imageThreeSlice3.color.a);
		}
		if (imageThreeSlice4 != null)
		{
			imageThreeSlice4.color = new Color(rankColor.r, rankColor.g, rankColor.b, imageThreeSlice4.color.a);
		}
		if (imageThreeSlice5 != null)
		{
			imageThreeSlice5.color = new Color(rankColor.r, rankColor.g, rankColor.b, imageThreeSlice5.color.a);
		}
		if (image2 != null)
		{
			image2.color = new Color(rankColor.r, rankColor.g, rankColor.b, image2.color.a);
		}
		if (textMeshProUGUI2 != null)
		{
			textMeshProUGUI2.color = new Color(rankColor.r, rankColor.g, rankColor.b, textMeshProUGUI2.color.a);
		}
		if (imageThreeSlice6 != null)
		{
			imageThreeSlice6._sprite = Class11.GetSprite("Nameplate", imageThreeSlice6._sprite);
		}
	}

	// Token: 0x0600026C RID: 620 RVA: 0x00002328 File Offset: 0x00000528
	public void OnUpdate()
	{
	}

	// Token: 0x0600026D RID: 621 RVA: 0x0000DB10 File Offset: 0x0000BD10
	public void UpdatePlayerPlate(PlayerNameplate nameplate)
	{
		if (this.vrcplayer_0 == null)
		{
			return;
		}
		APIUser apiuser = this.vrcplayer_0.smethod_1();
		if (apiuser != null)
		{
			bool flag = apiuser.IsFriend();
			Color rankColor = apiuser.GetRankColor();
			if (nameplate.field_Public_TextMeshProUGUIEx_0 != null)
			{
				nameplate.field_Public_TextMeshProUGUIEx_0.color = ((!flag) ? new Color(rankColor.r, rankColor.g, rankColor.b, nameplate.field_Public_TextMeshProUGUIEx_0.color.a) : new Color(Color.yellow.r, Color.yellow.g, Color.yellow.b, nameplate.field_Public_TextMeshProUGUIEx_0.color.a));
			}
			if (nameplate.field_Public_TextMeshProUGUIEx_1 != null)
			{
				nameplate.field_Public_TextMeshProUGUIEx_1.color = ((!flag) ? new Color(rankColor.r, rankColor.g, rankColor.b, nameplate.field_Public_TextMeshProUGUIEx_1.color.a) : new Color(Color.yellow.r, Color.yellow.g, Color.yellow.b, nameplate.field_Public_TextMeshProUGUIEx_1.color.a));
			}
			if (nameplate.field_Public_TextMeshProUGUIEx_2 != null)
			{
				nameplate.field_Public_TextMeshProUGUIEx_2.color = ((!flag) ? new Color(rankColor.r, rankColor.g, rankColor.b, nameplate.field_Public_TextMeshProUGUIEx_2.color.a) : new Color(Color.yellow.r, Color.yellow.g, Color.yellow.b, nameplate.field_Public_TextMeshProUGUIEx_2.color.a));
			}
			return;
		}
	}

	// Token: 0x0600026E RID: 622 RVA: 0x0000DCCC File Offset: 0x0000BECC
	public void UpdateCameraPlate(CameraNameplate nameplate)
	{
		if (this.vrcplayer_0 == null)
		{
			return;
		}
		APIUser apiuser = this.vrcplayer_0.smethod_1();
		if (apiuser != null)
		{
			bool flag = apiuser.IsFriend();
			Color rankColor = apiuser.GetRankColor();
			if (nameplate.field_Public_Graphic_0 != null)
			{
				nameplate.field_Public_Graphic_0.color = new Color(rankColor.r, rankColor.g, rankColor.b, nameplate.field_Public_Graphic_0.color.a);
			}
			if (nameplate.field_Public_TextMeshProUGUI_0 != null)
			{
				nameplate.field_Public_TextMeshProUGUI_0.color = ((!flag) ? new Color(rankColor.r, rankColor.g, rankColor.b, nameplate.field_Public_TextMeshProUGUI_0.color.a) : new Color(Color.yellow.r, Color.yellow.g, Color.yellow.b, nameplate.field_Public_TextMeshProUGUI_0.color.a));
			}
			return;
		}
	}

	// Token: 0x06000270 RID: 624 RVA: 0x00002C75 File Offset: 0x00000E75
	internal static bool blcroDN0X7ttFu9QaTl()
	{
		return Class41.J0sVI8NAjEL2CRhbIaU == null;
	}

	// Token: 0x04000116 RID: 278
	private VRCPlayer vrcplayer_0;

	// Token: 0x04000117 RID: 279
	internal static Class41 J0sVI8NAjEL2CRhbIaU;
}
