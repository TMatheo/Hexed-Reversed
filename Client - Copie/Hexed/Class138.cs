using System;
using Hexed.UIApi;
using UnityEngine;
using VRC;
using VRC.Core;

// Token: 0x02000155 RID: 341
internal class Class138
{
	// Token: 0x06000750 RID: 1872 RVA: 0x00023C50 File Offset: 0x00021E50
	public static void Init()
	{
		Class138.transform_0 = MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_Avatars/Menu_MM_DynamicSidePanel/Panel_SectionList/ScrollRect_Navigation_Container/ScrollRect_Content/Panel_SelectedAvatar/ScrollRect/Viewport/VerticalLayoutGroup");
		new MMSingleButton(Class138.transform_0, 0f, 0f, "Copy ID", delegate()
		{
			ApiAvatar field_Internal_ApiAvatar_ = MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_Avatars/Menu_MM_DynamicSidePanel/Panel_SectionList/ScrollRect_Navigation_Container/ScrollRect_Content/Panel_SelectedAvatar/Panel_MM_AvatarViewer/Avatar").GetComponent<SimpleAvatarPedestal>().field_Internal_ApiAvatar_0;
			if (field_Internal_ApiAvatar_ != null)
			{
				Class5.CopyToClipboard(field_Internal_ApiAvatar_.id ?? "");
			}
		}, "Copy the AvatarID", ButtonAPI.MMButtonType.Small, Class11.GetSprite("History"));
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x000037AF File Offset: 0x000019AF
	internal static bool cuTeTO9GIyKBP00FqwS()
	{
		return Class138.ODdskv9b1yKZCuhxnNF == null;
	}

	// Token: 0x04000428 RID: 1064
	private static Transform transform_0;

	// Token: 0x04000429 RID: 1065
	private static Class138 ODdskv9b1yKZCuhxnNF;
}
