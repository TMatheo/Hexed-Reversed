using System;
using UnityEngine;
using UnityEngine.UI;
using VRC.Localization;
using VRC.UI.Elements.Controls;

namespace Hexed.UIApi
{
	// Token: 0x02000036 RID: 54
	public class MMButtonBase
	{
		// Token: 0x060001B0 RID: 432 RVA: 0x00002ADF File Offset: 0x00000CDF
		public GameObject GetGameObject()
		{
			return this.baseObject;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00009978 File Offset: 0x00007B78
		public void SetActive(bool state)
		{
			this.baseObject.gameObject.SetActive(state);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00009998 File Offset: 0x00007B98
		public void SetLocation(float float_0, float float_1)
		{
			this.baseObject.GetComponent<RectTransform>().anchoredPosition += Vector2.right * (232f * (float_0 + (float)this.initShift[0]));
			this.baseObject.GetComponent<RectTransform>().anchoredPosition += Vector2.down * (210f * (float_1 + (float)this.initShift[1]));
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00009A14 File Offset: 0x00007C14
		public void SetIcon(Sprite icon)
		{
			this.baseObject.transform.Find("Text_ButtonName/Icon").GetComponent<Image>().sprite = icon;
			this.baseObject.transform.Find("Text_ButtonName/Icon").GetComponent<Image>().overrideSprite = icon;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00009A64 File Offset: 0x00007C64
		public void SetToolTip(string buttonToolTip)
		{
			LocalizableString localizableString = LocalizableStringExtensions.Localize(buttonToolTip, null, null, null);
			foreach (ToolTip toolTip in this.baseObject.GetComponentsInChildren<ToolTip>())
			{
				toolTip._localizableString = localizableString;
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00009AC8 File Offset: 0x00007CC8
		public void DestroyMe()
		{
			Object.Destroy(this.baseObject);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00009AE0 File Offset: 0x00007CE0
		public void ClickMe()
		{
			this.baseObject.GetComponent<Button>().onClick.Invoke();
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00009B04 File Offset: 0x00007D04
		public void SetBackgroundImage(Sprite newImg)
		{
			this.baseObject.transform.Find("Background_Button").GetComponent<Image>().sprite = newImg;
			this.baseObject.transform.Find("Background_Button").GetComponent<Image>().overrideSprite = newImg;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00009B54 File Offset: 0x00007D54
		public void SetButtonText(string buttonText)
		{
			this.baseObject.GetComponentInChildren<TextMeshProUGUIEx>().m_isRichText = true;
			this.baseObject.GetComponentInChildren<TextMeshProUGUIEx>().text = buttonText;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00009B84 File Offset: 0x00007D84
		public void SetAction(Action buttonAction)
		{
			this.baseObject.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
			if (buttonAction != null)
			{
				this.baseObject.GetComponent<Button>().onClick.AddListener(buttonAction);
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002AE7 File Offset: 0x00000CE7
		internal static bool mC4kCMSmaB6GZngKpGj()
		{
			return MMButtonBase.ipisrLS9ZrAD8FyPgAu == null;
		}

		// Token: 0x040000A8 RID: 168
		public GameObject baseObject;

		// Token: 0x040000A9 RID: 169
		public Transform parentPage;

		// Token: 0x040000AA RID: 170
		public int[] initShift = new int[2];

		// Token: 0x040000AB RID: 171
		private static MMButtonBase ipisrLS9ZrAD8FyPgAu;
	}
}
