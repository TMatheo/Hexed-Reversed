using System;
using UnityEngine;
using UnityEngine.UI;
using VRC.Localization;
using VRC.UI.Elements.Controls;

namespace Hexed.UIApi
{
	// Token: 0x02000035 RID: 53
	public class QMButtonBase
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00002ACD File Offset: 0x00000CCD
		public GameObject GetGameObject()
		{
			return this.baseObject;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000096CC File Offset: 0x000078CC
		public void SetActive(bool state)
		{
			this.baseObject.gameObject.SetActive(state);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000096EC File Offset: 0x000078EC
		public void SetLocation(float float_0, float float_1)
		{
			this.baseObject.GetComponent<RectTransform>().anchoredPosition += Vector2.right * (232f * (float_0 + (float)this.int_0[0]));
			this.baseObject.GetComponent<RectTransform>().anchoredPosition += Vector2.down * (210f * (float_1 + (float)this.int_0[1]));
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00009768 File Offset: 0x00007968
		public void SetIcon(Sprite icon)
		{
			foreach (Image image in this.baseObject.GetComponentsInChildren<Image>())
			{
				if (!(image.gameObject.name != "Icon"))
				{
					image.sprite = icon;
					image.overrideSprite = icon;
				}
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000097E4 File Offset: 0x000079E4
		public void SetToolTip(string buttonToolTip)
		{
			LocalizableString localizableString = LocalizableStringExtensions.Localize(buttonToolTip, null, null, null);
			foreach (ToolTip toolTip in this.baseObject.GetComponentsInChildren<ToolTip>())
			{
				toolTip._localizableString = localizableString;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00009848 File Offset: 0x00007A48
		public void DestroyMe()
		{
			Object.Destroy(this.baseObject);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00009860 File Offset: 0x00007A60
		public void ClickMe()
		{
			this.baseObject.GetComponent<Button>().onClick.Invoke();
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00009884 File Offset: 0x00007A84
		public void SetBackgroundImage(Sprite newImg)
		{
			this.baseObject.transform.Find("Background").GetComponent<Image>().sprite = newImg;
			this.baseObject.transform.Find("Background").GetComponent<Image>().overrideSprite = newImg;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000098D4 File Offset: 0x00007AD4
		public void SetButtonText(string buttonText)
		{
			this.baseObject.GetComponentInChildren<TextMeshProUGUIEx>().m_isRichText = true;
			this.baseObject.GetComponentInChildren<TextMeshProUGUIEx>().text = buttonText;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00009904 File Offset: 0x00007B04
		public void SetAction(Action buttonAction)
		{
			this.action_0 = buttonAction;
			this.baseObject.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
			if (this.action_0 != null)
			{
				this.baseObject.GetComponent<Button>().onClick.AddListener(this.action_0);
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002AD5 File Offset: 0x00000CD5
		internal static bool gcPRHsSTsYLCAiRQyiB()
		{
			return QMButtonBase.HANXAhSaxcbT8t9jSIp == null;
		}

		// Token: 0x040000A3 RID: 163
		public GameObject baseObject;

		// Token: 0x040000A4 RID: 164
		public Transform parentPage;

		// Token: 0x040000A5 RID: 165
		private Action action_0;

		// Token: 0x040000A6 RID: 166
		private int[] int_0 = new int[2];

		// Token: 0x040000A7 RID: 167
		internal static QMButtonBase HANXAhSaxcbT8t9jSIp;
	}
}
