using System;
using Hexed.UIApi;
using UnityEngine;

// Token: 0x02000122 RID: 290
internal class Class122
{
	// Token: 0x060005ED RID: 1517 RVA: 0x0001E1B0 File Offset: 0x0001C3B0
	public static void Init()
	{
		Class122.qmmenuPage_0 = new QMMenuPage("Hexed");
		new QMIconButton(MenuHelper.selectedMenuTemplate, 1.25f, -0.8f, new Action(Class122.qmmenuPage_0.OpenMe), "Hexed Client", Class11.GetSprite("moon"));
		Class123.Init();
		Class119.Init();
		Class121.Init();
		Class120.Init();
		Class122.uitextMeshText_0 = new UITextMeshText(Class122.qmmenuPage_0.MenuObject, "Informations", new Vector2(-440f, 155f), 29, false, 257);
		Class122.uitextMeshText_0.text.color = Color.gray;
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x00003421 File Offset: 0x00001621
	internal static bool NeqEaSIkT9mu3ANwdtN()
	{
		return Class122.E8mTTfIq3VfvosTDhQZ == null;
	}

	// Token: 0x040002D8 RID: 728
	public static QMMenuPage qmmenuPage_0;

	// Token: 0x040002D9 RID: 729
	public static UITextMeshText uitextMeshText_0;

	// Token: 0x040002DA RID: 730
	private static Class122 E8mTTfIq3VfvosTDhQZ;
}
