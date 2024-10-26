using System;
using UnityEngine;
using UnityEngine.UI;

namespace Hexed.UIApi
{
	// Token: 0x0200003C RID: 60
	public class QMSelectButton : QMButtonBase
	{
		// Token: 0x060001D6 RID: 470 RVA: 0x0000A448 File Offset: 0x00008648
		public QMSelectButton(QMMenuPage location, float btnXPos, float btnYPos, string btnText, string btnToolTip, object enumObject, int ActiveIndex)
		{
			this.parentPage = location.GetMenuObject().transform;
			this.Initialize(btnXPos, btnYPos, btnText, btnToolTip, enumObject, ActiveIndex);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000A47C File Offset: 0x0000867C
		public QMSelectButton(Transform location, float btnXPos, float btnYPos, string btnText, string btnToolTip, object enumObject, int ActiveIndex)
		{
			this.parentPage = location;
			this.Initialize(btnXPos, btnYPos, btnText, btnToolTip, enumObject, ActiveIndex);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000A4A8 File Offset: 0x000086A8
		private void Initialize(float btnXLocation, float btnYLocation, string btnText, string btnToolTip, object enumObject, int ActiveIndex)
		{
			this.qmmenuPage_0 = new QMMenuPage("Select");
			this.Button = new QMSingleButton(this.parentPage, btnXLocation, btnYLocation, btnText, new Action(this.qmmenuPage_0.OpenMe), btnToolTip, ButtonAPI.ButtonSize.Default, Class11.GetSprite("Options"));
			string[] names = Enum.GetNames(enumObject.GetType());
			if (names.Length == 4)
			{
				this.SelectButtons = new QMSingleButton[4];
				this.SelectButtons[0] = new QMSingleButton(this.qmmenuPage_0, 2.5f, 0f, names[0], delegate()
				{
					this.HandleClick(0);
				}, btnToolTip, ButtonAPI.ButtonSize.Default, Class11.GetSprite("Disabled"));
				this.SelectButtons[1] = new QMSingleButton(this.qmmenuPage_0, 2.5f, 1f, names[1], delegate()
				{
					this.HandleClick(1);
				}, btnToolTip, ButtonAPI.ButtonSize.Default, Class11.GetSprite("Disabled"));
				this.SelectButtons[2] = new QMSingleButton(this.qmmenuPage_0, 2.5f, 2f, names[2], delegate()
				{
					this.HandleClick(2);
				}, btnToolTip, ButtonAPI.ButtonSize.Default, Class11.GetSprite("Disabled"));
				this.SelectButtons[3] = new QMSingleButton(this.qmmenuPage_0, 2.5f, 3f, names[3], delegate()
				{
					this.HandleClick(3);
				}, btnToolTip, ButtonAPI.ButtonSize.Default, Class11.GetSprite("Disabled"));
			}
			else if (names.Length == 3)
			{
				this.SelectButtons = new QMSingleButton[3];
				this.SelectButtons[0] = new QMSingleButton(this.qmmenuPage_0, 2.5f, 0.5f, names[0], delegate()
				{
					this.HandleClick(0);
				}, btnToolTip, ButtonAPI.ButtonSize.Default, Class11.GetSprite("Disabled"));
				this.SelectButtons[1] = new QMSingleButton(this.qmmenuPage_0, 2.5f, 1.5f, names[1], delegate()
				{
					this.HandleClick(1);
				}, btnToolTip, ButtonAPI.ButtonSize.Default, Class11.GetSprite("Disabled"));
				this.SelectButtons[2] = new QMSingleButton(this.qmmenuPage_0, 2.5f, 2.5f, names[2], delegate()
				{
					this.HandleClick(2);
				}, btnToolTip, ButtonAPI.ButtonSize.Default, Class11.GetSprite("Disabled"));
			}
			this.SetToggleState(ActiveIndex, Class11.GetSprite("Enabled"));
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000A6E4 File Offset: 0x000088E4
		private void HandleClick(int Index)
		{
			for (int i = 0; i < this.SelectButtons.Length; i++)
			{
				this.SetToggleState(i, false);
			}
			this.SetToggleState(Index, true);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000A71C File Offset: 0x0000891C
		public void AddAction(int Index, Action action)
		{
			this.SelectButtons[Index].baseObject.GetComponent<Button>().onClick.AddListener(action);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000A74C File Offset: 0x0000894C
		public void SetToggleState(int Index, bool active)
		{
			this.SelectButtons[Index].SetIcon((!active) ? Class11.GetSprite("Disabled") : Class11.GetSprite("Enabled"));
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002B48 File Offset: 0x00000D48
		internal static bool IeROQENuT2KsxAZiKDo()
		{
			return QMSelectButton.iZoUb7NekBvFYayDvuR == null;
		}

		// Token: 0x040000B9 RID: 185
		public QMSingleButton Button;

		// Token: 0x040000BA RID: 186
		private QMMenuPage qmmenuPage_0;

		// Token: 0x040000BB RID: 187
		public QMSingleButton[] SelectButtons;

		// Token: 0x040000BC RID: 188
		internal static QMSelectButton iZoUb7NekBvFYayDvuR;
	}
}
