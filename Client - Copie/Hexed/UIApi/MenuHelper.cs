using System;
using System.Linq;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;
using VRC.UI.Elements;
using VRC.UI.Elements.Controls;
using VRC.UI.Elements.Menus;

namespace Hexed.UIApi
{
	// Token: 0x02000040 RID: 64
	public static class MenuHelper
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0000AB80 File Offset: 0x00008D80
		public static GameObject menuPageTemplate
		{
			get
			{
				if (MenuHelper.gameObject_0 == null)
				{
					MenuHelper.gameObject_0 = MenuHelper.QuickMenu.transform.Find("CanvasGroup/Container/Window/QMParent/Menu_Dashboard").gameObject;
				}
				return MenuHelper.gameObject_0;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		public static GameObject iconButtonTemplate
		{
			get
			{
				if (MenuHelper.gameObject_1 == null)
				{
					MenuHelper.gameObject_1 = MenuHelper.QuickMenu.transform.Find("CanvasGroup/Container/Window/QMParent/Menu_Dashboard/Header_H1/RightItemContainer/Button_QM_Expand").gameObject;
				}
				return MenuHelper.gameObject_1;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000AC00 File Offset: 0x00008E00
		public static GameObject singleButtonTemplate
		{
			get
			{
				if (MenuHelper.VmsZhUjYc3 == null)
				{
					MenuHelper.VmsZhUjYc3 = MenuHelper.QuickMenu.transform.Find("CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds").gameObject;
				}
				return MenuHelper.VmsZhUjYc3;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000AC40 File Offset: 0x00008E40
		public static GameObject mainBigSingleButtonTemplate
		{
			get
			{
				if (MenuHelper.gameObject_2 == null)
				{
					MenuHelper.gameObject_2 = MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_WorldDetail/ScrollRect/Viewport/VerticalLayoutGroup/Actions/ViewOnWebsite").gameObject;
				}
				return MenuHelper.gameObject_2;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000AC80 File Offset: 0x00008E80
		public static GameObject mainMediumSingleButtonTemplate
		{
			get
			{
				if (MenuHelper.OrhZosowTS == null)
				{
					MenuHelper.OrhZosowTS = MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_UserDetail/ScrollRect/Viewport/VerticalLayoutGroup/Row3/CellGrid_MM_Content/AddANote").gameObject;
				}
				return MenuHelper.OrhZosowTS;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000ACC0 File Offset: 0x00008EC0
		public static GameObject mainSmallSingleButtonTemplate
		{
			get
			{
				if (MenuHelper.gameObject_3 == null)
				{
					MenuHelper.gameObject_3 = MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_Avatars/Menu_MM_DynamicSidePanel/Panel_SectionList/ScrollRect_Navigation_Container/ScrollRect_Content/Panel_SelectedAvatar/ScrollRect/Viewport/VerticalLayoutGroup/Button_AvatarDetails").gameObject;
				}
				return MenuHelper.gameObject_3;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000AD00 File Offset: 0x00008F00
		public static MenuStateController menuStateController
		{
			get
			{
				if (MenuHelper._menuStateController == null)
				{
					MenuHelper._menuStateController = MenuHelper.QuickMenu.GetComponent<MenuStateController>();
				}
				return MenuHelper._menuStateController;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0000AD30 File Offset: 0x00008F30
		public static QuickMenu QuickMenu
		{
			get
			{
				if (MenuHelper.quickMenu_0 == null)
				{
					Il2CppArrayBase<QuickMenu> il2CppArrayBase = Resources.FindObjectsOfTypeAll<QuickMenu>();
					QuickMenu quickMenu;
					if (il2CppArrayBase == null)
					{
						quickMenu = null;
					}
					else
					{
						quickMenu = il2CppArrayBase.FirstOrDefault(delegate(QuickMenu x)
						{
							GameObject gameObject = x.gameObject;
							return ((gameObject != null) ? gameObject.name : null) == "Canvas_QuickMenu(Clone)";
						});
					}
					MenuHelper.quickMenu_0 = quickMenu;
				}
				return MenuHelper.quickMenu_0;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0000AD84 File Offset: 0x00008F84
		public static MainMenu MainMenu
		{
			get
			{
				if (MenuHelper.mainMenu_0 == null)
				{
					Il2CppArrayBase<MainMenu> il2CppArrayBase = Resources.FindObjectsOfTypeAll<MainMenu>();
					MainMenu mainMenu;
					if (il2CppArrayBase == null)
					{
						mainMenu = null;
					}
					else
					{
						mainMenu = il2CppArrayBase.FirstOrDefault(delegate(MainMenu x)
						{
							GameObject gameObject = x.gameObject;
							return ((gameObject != null) ? gameObject.name : null) == "Canvas_MainMenu(Clone)";
						});
					}
					MenuHelper.mainMenu_0 = mainMenu;
				}
				return MenuHelper.mainMenu_0;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000ADD8 File Offset: 0x00008FD8
		public static Transform userInterface
		{
			get
			{
				if (MenuHelper.transform_0 == null)
				{
					QuickMenu quickMenu = MenuHelper.QuickMenu;
					Transform transform2;
					if (quickMenu != null)
					{
						Transform transform = quickMenu.transform;
						transform2 = ((transform != null) ? transform.parent : null);
					}
					else
					{
						transform2 = null;
					}
					MenuHelper.transform_0 = transform2;
				}
				return MenuHelper.transform_0;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000AE1C File Offset: 0x0000901C
		public static Transform selectedMenuTemplate
		{
			get
			{
				if (MenuHelper.transform_1 == null)
				{
					MenuHelper.transform_1 = MenuHelper.QuickMenu.transform.Find("CanvasGroup/Container/Window/QMParent/Menu_SelectedUser_Local");
				}
				return MenuHelper.transform_1;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000AE54 File Offset: 0x00009054
		public static SelectedUserMenuQM selectedUserMenu
		{
			get
			{
				if (MenuHelper.selectedUserMenuQM_0 == null)
				{
					MenuHelper.selectedUserMenuQM_0 = MenuHelper.selectedMenuTemplate.GetComponent<SelectedUserMenuQM>();
				}
				return MenuHelper.selectedUserMenuQM_0;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000AE84 File Offset: 0x00009084
		public static GameObject sliderButtonTemplate
		{
			get
			{
				if (MenuHelper.gameObject_4 == null)
				{
					MenuHelper.gameObject_4 = MenuHelper.QuickMenu.transform.Find("CanvasGroup/Container/Window/QMParent/Menu_AudioSettings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Audio/VolumeSlider_Master").gameObject;
				}
				return MenuHelper.gameObject_4;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0000AEC4 File Offset: 0x000090C4
		public static Transform wingMenuTemplate
		{
			get
			{
				if (MenuHelper.transform_2 == null)
				{
					MenuHelper.transform_2 = MenuHelper.leftWing.transform.Find("Container/InnerContainer/WingMenu");
				}
				return MenuHelper.transform_2;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000AEFC File Offset: 0x000090FC
		public static Transform wingButtonTemplate
		{
			get
			{
				if (MenuHelper.transform_3 == null)
				{
					MenuHelper.transform_3 = MenuHelper.leftWing.transform.Find("Container/InnerContainer/WingMenu/ScrollRect/Viewport/VerticalLayoutGroup/Button_Profile");
				}
				return MenuHelper.transform_3;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000AF34 File Offset: 0x00009134
		public static WingMenu[] wings
		{
			get
			{
				if (MenuHelper.wingMenu_0 == null || MenuHelper.wingMenu_0.Length == 0)
				{
					MenuHelper.wingMenu_0 = MenuHelper.QuickMenu.transform.Find("CanvasGroup/Container").GetComponentsInChildren<WingMenu>(true);
				}
				return MenuHelper.wingMenu_0;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000AF7C File Offset: 0x0000917C
		public static WingMenu leftWing
		{
			get
			{
				if (MenuHelper.wingMenu_1 == null)
				{
					MenuHelper.wingMenu_1 = MenuHelper.wings.FirstOrDefault((WingMenu w) => w._wingType == 0);
				}
				return MenuHelper.wingMenu_1;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000AFCC File Offset: 0x000091CC
		public static WingMenu rightWing
		{
			get
			{
				if (MenuHelper.wingMenu_2 == null)
				{
					MenuHelper.wingMenu_2 = MenuHelper.wings.FirstOrDefault((WingMenu w) => w._wingType == 1);
				}
				return MenuHelper.wingMenu_2;
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002B70 File Offset: 0x00000D70
		internal static bool AOXd3ENxbYC5OYfG81M()
		{
			return MenuHelper.aAKGQJNX7Qs4Vkm0tpq == null;
		}

		// Token: 0x040000CD RID: 205
		private static GameObject gameObject_0;

		// Token: 0x040000CE RID: 206
		private static GameObject gameObject_1;

		// Token: 0x040000CF RID: 207
		private static GameObject VmsZhUjYc3;

		// Token: 0x040000D0 RID: 208
		private static GameObject gameObject_2;

		// Token: 0x040000D1 RID: 209
		private static GameObject OrhZosowTS;

		// Token: 0x040000D2 RID: 210
		private static GameObject gameObject_3;

		// Token: 0x040000D3 RID: 211
		public static MenuStateController _menuStateController;

		// Token: 0x040000D4 RID: 212
		private static QuickMenu quickMenu_0;

		// Token: 0x040000D5 RID: 213
		private static MainMenu mainMenu_0;

		// Token: 0x040000D6 RID: 214
		private static Transform transform_0;

		// Token: 0x040000D7 RID: 215
		private static Transform transform_1;

		// Token: 0x040000D8 RID: 216
		private static SelectedUserMenuQM selectedUserMenuQM_0;

		// Token: 0x040000D9 RID: 217
		private static GameObject gameObject_4;

		// Token: 0x040000DA RID: 218
		private static Transform transform_2;

		// Token: 0x040000DB RID: 219
		private static Transform transform_3;

		// Token: 0x040000DC RID: 220
		private static WingMenu[] wingMenu_0;

		// Token: 0x040000DD RID: 221
		private static WingMenu wingMenu_1;

		// Token: 0x040000DE RID: 222
		private static WingMenu wingMenu_2;

		// Token: 0x040000DF RID: 223
		private static MenuHelper aAKGQJNX7Qs4Vkm0tpq;
	}
}
