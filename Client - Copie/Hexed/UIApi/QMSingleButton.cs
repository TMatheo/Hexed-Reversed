using System;
using TMPro;
using UnityEngine;

namespace Hexed.UIApi
{
	// Token: 0x02000038 RID: 56
	public class QMSingleButton : QMButtonBase
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x00009E94 File Offset: 0x00008094
		public QMSingleButton(QMMenuPage btnMenu, float btnXLocation, float btnYLocation, string btnText, Action btnAction, string btnToolTip, ButtonAPI.ButtonSize Size = ButtonAPI.ButtonSize.Default, Sprite Sprite = null)
		{
			this.parentPage = btnMenu.GetMenuObject().transform;
			this.InitButton(btnXLocation, btnYLocation, btnText, btnAction, btnToolTip, Size, Sprite);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00009ECC File Offset: 0x000080CC
		public QMSingleButton(Transform btnMenu, float btnXLocation, float btnYLocation, string btnText, Action btnAction, string btnToolTip, ButtonAPI.ButtonSize Size = ButtonAPI.ButtonSize.Default, Sprite Sprite = null)
		{
			this.parentPage = btnMenu;
			this.InitButton(btnXLocation, btnYLocation, btnText, btnAction, btnToolTip, Size, Sprite);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00009EF8 File Offset: 0x000080F8
		private void InitButton(float btnXLocation, float btnYLocation, string btnText, Action btnAction, string btnToolTip, ButtonAPI.ButtonSize Size = ButtonAPI.ButtonSize.Default, Sprite Sprite = null)
		{
			if (Size != ButtonAPI.ButtonSize.Default)
			{
				btnYLocation -= 0.26f;
			}
			this.baseObject = Object.Instantiate<GameObject>(MenuHelper.singleButtonTemplate, this.parentPage);
			base.SetActive(false);
			this.baseObject.name = "Hexed_Button_" + Class109.RandomString(12);
			this.baseObject.GetComponentInChildren<TextMeshProUGUI>().richText = true;
			this.baseObject.GetComponent<RectTransform>().sizeDelta = new Vector2(200f, 176f);
			this.baseObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-68f, -225f);
			if (!(Sprite != null))
			{
				this.baseObject.transform.Find("Icons").gameObject.SetActive(false);
			}
			else
			{
				base.SetIcon(Sprite);
			}
			Object.DestroyImmediate(this.baseObject.transform.Find("Badge_MMJump").gameObject);
			Object.DestroyImmediate(this.baseObject.transform.Find("Badge_Close").gameObject);
			base.SetLocation(btnXLocation, btnYLocation);
			base.SetButtonText(btnText);
			base.SetToolTip(btnToolTip);
			base.SetAction(btnAction);
			base.SetActive(true);
			if (Size == ButtonAPI.ButtonSize.Half)
			{
				Vector2 sizeDelta = this.baseObject.GetComponentInChildren<RectTransform>().sizeDelta;
				sizeDelta.y /= 2f;
				this.baseObject.GetComponentInChildren<RectTransform>().sizeDelta = sizeDelta;
				return;
			}
			if (Size != ButtonAPI.ButtonSize.Square)
			{
				return;
			}
			Vector2 sizeDelta2 = this.baseObject.GetComponentInChildren<RectTransform>().sizeDelta;
			sizeDelta2.y /= 2f;
			sizeDelta2.x /= 2f;
			this.baseObject.GetComponentInChildren<RectTransform>().sizeDelta = sizeDelta2;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002B18 File Offset: 0x00000D18
		internal static bool vK36YhNOnZksUxTRTgy()
		{
			return QMSingleButton.vTljbINZLlatWgFcZ59 == null;
		}

		// Token: 0x040000B1 RID: 177
		internal static QMSingleButton vTljbINZLlatWgFcZ59;
	}
}
