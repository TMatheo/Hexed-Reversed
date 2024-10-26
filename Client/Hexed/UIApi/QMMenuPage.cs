using System;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements;
using VRC.UI.Elements.Menus;

namespace Hexed.UIApi
{
	// Token: 0x02000037 RID: 55
	public class QMMenuPage
	{
		// Token: 0x060001BC RID: 444 RVA: 0x00009BE4 File Offset: 0x00007DE4
		public QMMenuPage(string menuTitle)
		{
			this.Initialize(menuTitle);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00009C00 File Offset: 0x00007E00
		private void Initialize(string menuTitle)
		{
			this.MenuObject = Object.Instantiate<GameObject>(MenuHelper.menuPageTemplate, MenuHelper.menuPageTemplate.transform.parent);
			this.MenuObject.SetActive(false);
			this.MenuObject.name = "Hexed_Menu_" + Class109.RandomString(12);
			Object.DestroyImmediate(this.MenuObject.GetComponent<MainMenuContent>());
			this.uipage_0 = this.MenuObject.AddComponent<UIPage>();
			this.uipage_0.field_Public_String_0 = this.MenuObject.name;
			this.uipage_0.field_Private_Boolean_1 = true;
			this.uipage_0.field_Protected_MenuStateController_0 = MenuHelper.menuStateController;
			this.uipage_0.field_Private_List_1_UIPage_0 = new List<UIPage>();
			this.uipage_0.field_Private_List_1_UIPage_0.Add(this.uipage_0);
			MenuHelper.menuStateController.field_Private_Dictionary_2_String_UIPage_0.Add(this.MenuObject.name, this.uipage_0);
			this.MenuObject.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup").DestroyChildren();
			this.MenuTitleText = this.MenuObject.GetComponentInChildren<TextMeshProUGUI>(true);
			this.MenuTitleText.text = menuTitle;
			this.gameObject_0 = this.MenuObject.transform.GetChild(0).Find("LeftItemContainer/Button_Back").gameObject;
			this.gameObject_0.SetActive(true);
			this.MenuObject.transform.GetChild(0).Find("RightItemContainer/Button_QM_Expand").gameObject.SetActive(false);
			for (int i = 0; i < this.MenuObject.transform.childCount; i++)
			{
				if (this.MenuObject.transform.GetChild(i).name != "Header_H1" && this.MenuObject.transform.GetChild(i).name != "ScrollRect")
				{
					Object.Destroy(this.MenuObject.transform.GetChild(i).gameObject);
				}
			}
			this.MenuObject.transform.Find("ScrollRect").GetComponent<ScrollRect>().enabled = false;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00009E20 File Offset: 0x00008020
		public void OpenMe()
		{
			this.MenuObject.SetActive(true);
			MenuHelper.menuStateController.Method_Public_Void_String_UIContext_Boolean_TransitionType_0(this.uipage_0.field_Public_String_0, null, false, 3234);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00009E58 File Offset: 0x00008058
		public void OpenMe(Action action)
		{
			this.MenuObject.SetActive(true);
			MenuHelper.menuStateController.Method_Public_Void_String_UIContext_Boolean_TransitionType_0(this.uipage_0.field_Public_String_0, null, false, 3234);
			action();
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002AF1 File Offset: 0x00000CF1
		public string GetMenuName()
		{
			return this.MenuObject.name;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002AFE File Offset: 0x00000CFE
		public GameObject GetMenuObject()
		{
			return this.MenuObject;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002B06 File Offset: 0x00000D06
		public GameObject GetBackButton()
		{
			return this.gameObject_0;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002B0E File Offset: 0x00000D0E
		internal static bool LN0UShSzJAhF1bdnpb2()
		{
			return QMMenuPage.u95QRKSWYkPb977YPaH == null;
		}

		// Token: 0x040000AC RID: 172
		public GameObject MenuObject;

		// Token: 0x040000AD RID: 173
		public TextMeshProUGUI MenuTitleText;

		// Token: 0x040000AE RID: 174
		private GameObject gameObject_0;

		// Token: 0x040000AF RID: 175
		private UIPage uipage_0;

		// Token: 0x040000B0 RID: 176
		internal static QMMenuPage u95QRKSWYkPb977YPaH;
	}
}
