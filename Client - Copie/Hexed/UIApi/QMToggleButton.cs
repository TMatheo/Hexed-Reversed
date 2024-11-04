using System;
using UnityEngine;

namespace Hexed.UIApi
{
	// Token: 0x0200003B RID: 59
	public class QMToggleButton : QMButtonBase
	{
		// Token: 0x060001CF RID: 463 RVA: 0x0000A2F4 File Offset: 0x000084F4
		public QMToggleButton(QMMenuPage location, float btnXPos, float btnYPos, string btnText, Action onAction, Action offAction, string btnToolTip, bool defaultState = false)
		{
			this.parentPage = location.GetMenuObject().transform;
			this.Initialize(btnXPos, btnYPos, btnText, onAction, offAction, btnToolTip, defaultState);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000A32C File Offset: 0x0000852C
		public QMToggleButton(Transform location, float btnXPos, float btnYPos, string btnText, Action onAction, Action offAction, string btnToolTip, bool defaultState = false)
		{
			this.parentPage = location;
			this.Initialize(btnXPos, btnYPos, btnText, onAction, offAction, btnToolTip, defaultState);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000A358 File Offset: 0x00008558
		private void Initialize(float btnXLocation, float btnYLocation, string btnText, Action onAction, Action offAction, string btnToolTip, bool defaultState = false)
		{
			this.action_1 = onAction;
			this.action_2 = offAction;
			this.bool_0 = defaultState;
			this.qmsingleButton_0 = new QMSingleButton(this.parentPage, btnXLocation, btnYLocation, btnText, new Action(this.HandleClick), btnToolTip, ButtonAPI.ButtonSize.Default, this.bool_0 ? Class11.GetSprite("Enabled") : Class11.GetSprite("Disabled"));
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000A3C0 File Offset: 0x000085C0
		public void SetToggleState(bool newState)
		{
			this.bool_0 = newState;
			this.qmsingleButton_0.SetIcon(this.bool_0 ? Class11.GetSprite("Enabled") : Class11.GetSprite("Disabled"));
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000A400 File Offset: 0x00008600
		private void HandleClick()
		{
			this.bool_0 = !this.bool_0;
			this.SetToggleState(this.bool_0);
			if (this.bool_0)
			{
				this.action_1();
				return;
			}
			this.action_2();
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002B36 File Offset: 0x00000D36
		public bool GetCurrentState()
		{
			return this.bool_0;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002B3E File Offset: 0x00000D3E
		internal static bool wU3ilRN82wdFUnx0uV8()
		{
			return QMToggleButton.YdkT1DNRRlQTGFDvlhT == null;
		}

		// Token: 0x040000B4 RID: 180
		private QMSingleButton qmsingleButton_0;

		// Token: 0x040000B5 RID: 181
		private bool bool_0;

		// Token: 0x040000B6 RID: 182
		private Action action_1;

		// Token: 0x040000B7 RID: 183
		private Action action_2;

		// Token: 0x040000B8 RID: 184
		internal static QMToggleButton YdkT1DNRRlQTGFDvlhT;
	}
}
