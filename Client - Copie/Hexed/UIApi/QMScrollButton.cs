using System;
using System.Collections.Generic;
using UnityEngine;

namespace Hexed.UIApi
{
	// Token: 0x0200003D RID: 61
	public class QMScrollButton : QMButtonBase
	{
		// Token: 0x060001E4 RID: 484 RVA: 0x0000A7D0 File Offset: 0x000089D0
		public QMScrollButton(QMMenuPage location, float btnXPos, float btnYPos, string btnText, string btnToolTip, ButtonAPI.ButtonSize Size = ButtonAPI.ButtonSize.Default, Sprite Sprite = null)
		{
			this.parentPage = location.GetMenuObject().transform;
			this.Initialize(btnXPos, btnYPos, btnText, btnToolTip, Size, Sprite);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000A81C File Offset: 0x00008A1C
		public QMScrollButton(Transform location, float btnXPos, float btnYPos, string btnText, string btnToolTip, ButtonAPI.ButtonSize Size = ButtonAPI.ButtonSize.Default, Sprite Sprite = null)
		{
			this.parentPage = location;
			this.Initialize(btnXPos, btnYPos, btnText, btnToolTip, Size, Sprite);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000A85C File Offset: 0x00008A5C
		private void Initialize(float btnXLocation, float btnYLocation, string btnText, string btnToolTip, ButtonAPI.ButtonSize Size = ButtonAPI.ButtonSize.Default, Sprite Sprite = null)
		{
			this.qmmenuPage_0 = new QMMenuPage("Scroll");
			this.qmsingleButton_0 = new QMSingleButton(this.qmmenuPage_0, 1.5f, 3.5f, "<---", delegate()
			{
				this.ShowMenu(this.int_2 - 1);
			}, "Go Back", ButtonAPI.ButtonSize.Half, null);
			this.qmsingleButton_1 = new QMSingleButton(this.qmmenuPage_0, 3.5f, 3.5f, "--->", delegate()
			{
				this.ShowMenu(this.int_2 + 1);
			}, "Go Next", ButtonAPI.ButtonSize.Half, null);
			this.MainButton = new QMSingleButton(this.parentPage, btnXLocation, btnYLocation, btnText, null, btnToolTip, Size, Sprite);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000A8FC File Offset: 0x00008AFC
		private void ShowMenu(int MenuIndex)
		{
			if (MenuIndex >= 0 && MenuIndex <= this.int_1)
			{
				foreach (QMScrollButton.ScrollObject scrollObject in this.ScrollButtons)
				{
					QMButtonBase buttonBase = scrollObject.ButtonBase;
					if (buttonBase != null)
					{
						buttonBase.SetActive(scrollObject.Index == MenuIndex);
					}
				}
				this.int_2 = MenuIndex;
				return;
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000A97C File Offset: 0x00008B7C
		private void Clear()
		{
			foreach (QMScrollButton.ScrollObject scrollObject in this.ScrollButtons)
			{
				if (scrollObject != null)
				{
					Object.Destroy(scrollObject.ButtonBase.GetGameObject());
				}
			}
			this.ScrollButtons.Clear();
			this.float_0 = 1f;
			this.float_1 = 0f;
			this.int_1 = 0;
			this.int_2 = 0;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000AA10 File Offset: 0x00008C10
		public void Add(string Text, string Description, Action Action)
		{
			if (this.float_1 == 3f)
			{
				this.float_1 = 0f;
				this.int_1++;
			}
			QMSingleButton qmsingleButton = new QMSingleButton(this.qmmenuPage_0, this.float_0, this.float_1, Text, Action, Description, ButtonAPI.ButtonSize.Half, null);
			qmsingleButton.SetActive(false);
			this.ScrollButtons.Add(new QMScrollButton.ScrollObject
			{
				ButtonBase = qmsingleButton,
				Index = this.int_1
			});
			this.float_0 += 1f;
			if (this.float_0 == 5f)
			{
				this.float_0 = 1f;
				this.float_1 += 0.5f;
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000AACC File Offset: 0x00008CCC
		public new void SetAction(Action buttonAction)
		{
			this.MainButton.SetAction(delegate
			{
				this.Clear();
				buttonAction();
				this.qmmenuPage_0.OpenMe();
				this.ShowMenu(0);
			});
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002B52 File Offset: 0x00000D52
		internal static bool LKqZbANdD50HAkKbgmf()
		{
			return QMScrollButton.E83AdnNVA8VrtrhY6Ps == null;
		}

		// Token: 0x040000BD RID: 189
		public QMSingleButton MainButton;

		// Token: 0x040000BE RID: 190
		private QMSingleButton qmsingleButton_0;

		// Token: 0x040000BF RID: 191
		private QMSingleButton qmsingleButton_1;

		// Token: 0x040000C0 RID: 192
		private QMMenuPage qmmenuPage_0;

		// Token: 0x040000C1 RID: 193
		public List<QMScrollButton.ScrollObject> ScrollButtons = new List<QMScrollButton.ScrollObject>();

		// Token: 0x040000C2 RID: 194
		private float float_0 = 1f;

		// Token: 0x040000C3 RID: 195
		private float float_1;

		// Token: 0x040000C4 RID: 196
		private int int_1;

		// Token: 0x040000C5 RID: 197
		private int int_2;

		// Token: 0x040000C6 RID: 198
		internal static QMScrollButton E83AdnNVA8VrtrhY6Ps;

		// Token: 0x0200003E RID: 62
		public class ScrollObject
		{
			// Token: 0x060001EF RID: 495 RVA: 0x00002B5C File Offset: 0x00000D5C
			internal static bool utlrbsDLXgk4e3VFAUZ()
			{
				return QMScrollButton.ScrollObject.rLVWe0DsKKSW4GkEa0e == null;
			}

			// Token: 0x040000C7 RID: 199
			public QMButtonBase ButtonBase;

			// Token: 0x040000C8 RID: 200
			public int Index;

			// Token: 0x040000C9 RID: 201
			internal static QMScrollButton.ScrollObject rLVWe0DsKKSW4GkEa0e;
		}
	}
}
