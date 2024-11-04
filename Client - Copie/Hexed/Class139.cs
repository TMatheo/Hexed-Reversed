using System;
using Hexed.UIApi;
using UnityEngine;
using VRC.UI.Elements.Menus;

// Token: 0x02000157 RID: 343
internal class Class139
{
	// Token: 0x06000757 RID: 1879 RVA: 0x00023D20 File Offset: 0x00021F20
	public static void Init()
	{
		Class139.transform_0 = MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_UserDetail/ScrollRect/Viewport/VerticalLayoutGroup/Row3/CellGrid_MM_Content");
		new MMSingleButton(Class139.transform_0, 0f, 0f, "Copy ID", delegate()
		{
			IUser field_Private_IUser_ = MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_UserDetail").GetComponent<MainMenuSelectedUser>().field_Private_IUser_0;
			if (field_Private_IUser_ != null)
			{
				Class5.CopyToClipboard(field_Private_IUser_.Method_Public_Abstract_Virtual_New_get_String_0() ?? "");
				return;
			}
		}, "Copy the UserID", ButtonAPI.MMButtonType.Medium, Class11.GetSprite("History"));
		new MMSingleButton(Class139.transform_0, 0f, 0f, "Copy Name", delegate()
		{
			IUser field_Private_IUser_ = MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_UserDetail").GetComponent<MainMenuSelectedUser>().field_Private_IUser_0;
			if (field_Private_IUser_ == null)
			{
				return;
			}
			Class5.CopyToClipboard(field_Private_IUser_.Method_Public_Abstract_Virtual_New_get_String_1() ?? "");
		}, "Copy the Name", ButtonAPI.MMButtonType.Medium, Class11.GetSprite("History"));
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x000037C3 File Offset: 0x000019C3
	internal static bool nXHdhI9g1Z9tlCbFI7Y()
	{
		return Class139.fK4P609rFFlHlCiKqvR == null;
	}

	// Token: 0x0400042D RID: 1069
	private static Transform transform_0;

	// Token: 0x0400042E RID: 1070
	internal static Class139 fK4P609rFFlHlCiKqvR;
}
