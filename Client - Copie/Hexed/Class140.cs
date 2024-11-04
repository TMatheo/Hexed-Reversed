using System;
using System.IO;
using Hexed.UIApi;
using Hexed.Wrappers;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;
using VRC.Core;
using VRC.UI.Elements.Controls;
using VRC.UI.Elements.Menus;

// Token: 0x02000159 RID: 345
internal class Class140
{
	// Token: 0x0600075F RID: 1887 RVA: 0x00023E80 File Offset: 0x00022080
	public static void Init()
	{
		Class140.transform_0 = MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_WorldDetail/ScrollRect/Viewport/VerticalLayoutGroup/Actions");
		Object.Instantiate<Transform>(MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_WorldDetail/ScrollRect/Viewport/VerticalLayoutGroup/Header_Actions"), MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_WorldDetail/ScrollRect/Viewport/VerticalLayoutGroup")).Find("LeftItemContainer/Text_Title").GetComponent<TextMeshProUGUIEx>().text = "Players";
		Class140.transform_1 = Object.Instantiate<Transform>(MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_WorldDetail/ScrollRect/Viewport/VerticalLayoutGroup/Actions"), MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_WorldDetail/ScrollRect/Viewport/VerticalLayoutGroup"));
		Class140.transform_1.DestroyChildren();
		new MMSingleButton(Class140.transform_0, 0f, 0f, "Copy ID", delegate()
		{
			IWorld world = MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_WorldDetail").GetComponent<MainMenuWorldDetailsPage>().Method_Public_get_IWorld_0();
			if (world == null)
			{
				return;
			}
			Class5.CopyToClipboard(world.Method_Public_Abstract_Virtual_New_get_String_0());
		}, "Copy the WorldID", ButtonAPI.MMButtonType.Big, Class11.GetSprite("History"));
		new MMSingleButton(Class140.transform_0, 0f, 0f, "Download File", delegate()
		{
			IWorld world = MenuHelper.MainMenu.transform.Find("Container/MMParent/Menu_WorldDetail").GetComponent<MainMenuWorldDetailsPage>().Method_Public_get_IWorld_0();
			Object1Public1ObInObIL1BoLiObApUnique object1Public1ObInObIL1BoLiObApUnique_0 = world.TryCast<Object1Public1ObInObIL1BoLiObApUnique>();
			if (object1Public1ObInObIL1BoLiObApUnique_0 != null && object1Public1ObInObIL1BoLiObApUnique_0.Method_Public_get_TYPE_0() != null)
			{
				ApiFile.DownloadFile(object1Public1ObInObIL1BoLiObApUnique_0.Method_Public_get_TYPE_0().world.assetUrl, delegate(Il2CppStructArray<byte> worldFile)
				{
					File.WriteAllBytes(Class141.string_0 + "\\Rips\\" + object1Public1ObInObIL1BoLiObApUnique_0.Method_Public_get_TYPE_0().world.name + ".vrcw", worldFile);
					Logger.Log("Downloaded World " + object1Public1ObInObIL1BoLiObApUnique_0.Method_Public_get_TYPE_0().world.name, Logger.LogsType.Info);
				}, delegate(string error)
				{
					Logger.LogError("Failed to download World");
				}, null);
				return;
			}
		}, "Download the World file", ButtonAPI.MMButtonType.Big, Class11.GetSprite("Download"));
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x000037D7 File Offset: 0x000019D7
	internal static bool L8igka9lmI1XHvcNNti()
	{
		return Class140.FPSYEe978RK10k3wfB7 == null;
	}

	// Token: 0x04000433 RID: 1075
	private static Transform transform_0;

	// Token: 0x04000434 RID: 1076
	private static Transform transform_1;

	// Token: 0x04000435 RID: 1077
	internal static Class140 FPSYEe978RK10k3wfB7;
}
