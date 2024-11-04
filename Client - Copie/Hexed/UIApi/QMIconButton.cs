using System;
using UnityEngine;

namespace Hexed.UIApi
{
	// Token: 0x0200003A RID: 58
	public class QMIconButton : QMButtonBase
	{
		// Token: 0x060001CB RID: 459 RVA: 0x0000A1D8 File Offset: 0x000083D8
		public QMIconButton(QMMenuPage btnMenu, float btnXLocation, float btnYLocation, Action btnAction, string btnToolTip, Sprite Sprite = null)
		{
			this.parentPage = btnMenu.GetMenuObject().transform;
			this.InitButton(btnXLocation, btnYLocation, btnAction, btnToolTip, Sprite);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000A20C File Offset: 0x0000840C
		public QMIconButton(Transform btnMenu, float btnXLocation, float btnYLocation, Action btnAction, string btnToolTip, Sprite Sprite = null)
		{
			this.parentPage = btnMenu;
			this.InitButton(btnXLocation, btnYLocation, btnAction, btnToolTip, Sprite);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000A234 File Offset: 0x00008434
		private void InitButton(float btnXLocation, float btnYLocation, Action btnAction, string btnToolTip, Sprite Sprite = null)
		{
			this.baseObject = Object.Instantiate<GameObject>(MenuHelper.iconButtonTemplate, this.parentPage);
			base.SetActive(false);
			this.baseObject.name = "Hexed-IconButton-" + Class109.RandomString(12);
			this.baseObject.GetComponent<RectTransform>().sizeDelta += new Vector2(10f, 10f);
			this.baseObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(-68f, -228f);
			if (Sprite != null)
			{
				base.SetIcon(Sprite);
			}
			base.SetLocation(btnXLocation, btnYLocation);
			base.SetToolTip(btnToolTip);
			base.SetAction(btnAction);
			base.SetActive(true);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002B2C File Offset: 0x00000D2C
		internal static bool y3TmxwNHjRiHIYWTkHb()
		{
			return QMIconButton.sTrxh4N22NWH0quNLpF == null;
		}

		// Token: 0x040000B3 RID: 179
		private static QMIconButton sTrxh4N22NWH0quNLpF;
	}
}
