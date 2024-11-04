using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Hexed.UIApi
{
	// Token: 0x02000039 RID: 57
	public class MMSingleButton : MMButtonBase
	{
		// Token: 0x060001C8 RID: 456 RVA: 0x0000A0B8 File Offset: 0x000082B8
		public MMSingleButton(Transform btnMenu, float btnXLocation, float btnYLocation, string btnText, Action btnAction, string btnToolTip, ButtonAPI.MMButtonType Size = ButtonAPI.MMButtonType.Big, Sprite Sprite = null)
		{
			this.parentPage = btnMenu;
			this.InitButton(btnXLocation, btnYLocation, btnText, btnAction, btnToolTip, Size, Sprite);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000A0E4 File Offset: 0x000082E4
		private void InitButton(float btnXLocation, float btnYLocation, string btnText, Action btnAction, string btnToolTip, ButtonAPI.MMButtonType Size = ButtonAPI.MMButtonType.Big, Sprite Sprite = null)
		{
			switch (Size)
			{
			case ButtonAPI.MMButtonType.Big:
				this.baseObject = Object.Instantiate<GameObject>(MenuHelper.mainBigSingleButtonTemplate, this.parentPage);
				break;
			case ButtonAPI.MMButtonType.Medium:
				this.baseObject = Object.Instantiate<GameObject>(MenuHelper.mainMediumSingleButtonTemplate, this.parentPage);
				break;
			case ButtonAPI.MMButtonType.Small:
				this.baseObject = Object.Instantiate<GameObject>(MenuHelper.mainSmallSingleButtonTemplate, this.parentPage);
				break;
			}
			base.SetActive(false);
			this.baseObject.name = "Hexed_Button_" + Class109.RandomString(12);
			this.baseObject.GetComponentInChildren<TextMeshProUGUI>().richText = true;
			if (!(Sprite != null))
			{
				this.baseObject.transform.Find("Text_ButtonName/Icon").GetComponentInChildren<Image>().gameObject.SetActive(false);
			}
			else
			{
				base.SetIcon(Sprite);
			}
			base.SetButtonText(btnText);
			base.SetToolTip(btnToolTip);
			base.SetAction(btnAction);
			base.SetActive(true);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002B22 File Offset: 0x00000D22
		internal static bool YZjCrMNo0Q0ZhyTOZhj()
		{
			return MMSingleButton.sletX8NpJaH0fIIcfTn == null;
		}

		// Token: 0x040000B2 RID: 178
		private static MMSingleButton sletX8NpJaH0fIIcfTn;
	}
}
