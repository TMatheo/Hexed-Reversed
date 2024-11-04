using System;
using System.Runtime.CompilerServices;
using Hexed.UIApi;
using UnityEngine;
using VRC.Core;

// Token: 0x0200013E RID: 318
internal class Class132
{
	// Token: 0x060006D2 RID: 1746 RVA: 0x00021E50 File Offset: 0x00020050
	public static void Init()
	{
		Class132.qmmenuPage_0 = new QMMenuPage("Utils");
		new QMSingleButton(Class127.qmmenuPage_0, 2f, 0f, "Utils", new Action(Class132.qmmenuPage_0.OpenMe), "Utils Options", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Utils"));
		new QMToggleButton(Class132.qmmenuPage_0, 1f, 0f, "No \nSpawnsound", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoSpawnsound", true);
			Class143.bool_27 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoSpawnsound", false);
			Class143.bool_27 = false;
		}, "Disable Avatar spawn Audios", Class141.class6_0.GetBool("Toggles", "NoSpawnsound", false, false));
		new QMToggleButton(Class132.qmmenuPage_0, 2f, 0f, "Headlight", delegate()
		{
			Class116.ToggleHeadlight(true);
		}, delegate()
		{
			Class116.ToggleHeadlight(false);
		}, "Light up the Map", false);
		new QMToggleButton(Class132.qmmenuPage_0, 3f, 0f, "Invisible \nCamera", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "InvisibleCamera", true);
			Class143.bool_26 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "InvisibleCamera", false);
			Class143.bool_26 = false;
		}, "Hide your Camera from other Players", Class141.class6_0.GetBool("Toggles", "InvisibleCamera", false, false));
		QMMenuPage btnMenu = Class132.qmmenuPage_0;
		float btnXLocation = 4f;
		float btnYLocation = 0f;
		string btnText = "Reload \nAvatars";
		Action btnAction;
		if ((btnAction = Class132.<>O.action_0) == null)
		{
			btnAction = (Class132.<>O.action_0 = new Action(Class37.ReloadAvatars));
		}
		new QMSingleButton(btnMenu, btnXLocation, btnYLocation, btnText, btnAction, "Reload all Avatars", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class132.qmmenuPage_0, 4f, 0.5f, "Change \nAvatar", delegate()
		{
			Class3.VRCUiPopupManager.AskInGameInput("Avatar ID", "Ok", delegate(string text)
			{
				Class10.ChangeAvatar(text);
			}, "avtr_");
		}, "Change Avatar by ID", ButtonAPI.ButtonSize.Half, null);
		Class132.qmtoggleButton_0 = new QMToggleButton(Class132.qmmenuPage_0, 1f, 1f, "Fake \nSerialize", delegate()
		{
			Class52.CustomSerialize(true, false);
		}, delegate()
		{
			Class52.CustomSerialize(false, false);
		}, "Stop moving for other Players", false);
		QMMenuPage btnMenu2 = Class132.qmmenuPage_0;
		float btnXLocation2 = 2f;
		float btnYLocation2 = 1f;
		string btnText2 = "Delete \nPortals";
		Action btnAction2;
		if ((btnAction2 = Class132.<>O.action_1) == null)
		{
			btnAction2 = (Class132.<>O.action_1 = new Action(Class35.DeletePortals));
		}
		new QMSingleButton(btnMenu2, btnXLocation2, btnYLocation2, btnText2, btnAction2, "Delete all existing Portals", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class132.qmmenuPage_0, 3f, 1f, "Drop \nPortal", delegate()
		{
			Class3.VRCUiPopupManager.AskInGameInput("World ID", "Ok", delegate(string text)
			{
				ApiWorldInstance apiWorldInstance = new ApiWorldInstance();
				apiWorldInstance.id = text;
				apiWorldInstance.instanceId = text.Split(':', StringSplitOptions.None)[1];
				apiWorldInstance.worldId = text.Split(':', StringSplitOptions.None)[0];
				apiWorldInstance.world = new ApiWorld
				{
					id = text.Split(':', StringSplitOptions.None)[0]
				};
				apiWorldInstance.Fetch(delegate(ApiContainer container)
				{
					new ApiModelContainer<ApiWorldInstance>().setFromContainer(container);
					Class117.RaisePortalCreate(container.Model.Cast<ApiWorldInstance>().shortName, Class3.CurrentPlayer.transform.position + Vector3.forward * 1.505f, 0f);
				}, null, null, false, 2);
			}, "wrld_");
		}, "Drop a Portal by ID", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class132.qmmenuPage_0, 3f, 1.5f, "Copy \nWorldID", delegate()
		{
			Class5.CopyToClipboard(Class4.GetCurrentWorldID() ?? "");
		}, "Copy the current WorldID", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class132.qmmenuPage_0, 4f, 1f, "Copy \nServer IP", delegate()
		{
			Class5.CopyToClipboard(Class3.VRCNetworkingClient.field_Private_String_3 ?? "");
		}, "Copy the current Photon IP", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class132.qmmenuPage_0, 4f, 1.5f, "Join \nWorldID", delegate()
		{
			Class3.VRCUiPopupManager.AskInGameInput("World ID", "Ok", delegate(string text)
			{
				Class4.Forcejoin(text);
			}, "wrld_");
		}, "Join the World by ID", ButtonAPI.ButtonSize.Half, null);
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00003631 File Offset: 0x00001831
	internal static bool pOlnlW9RaR6apgflBVG()
	{
		return Class132.gxABKh9i3rWIdsCk3fl == null;
	}

	// Token: 0x040003B1 RID: 945
	private static QMMenuPage qmmenuPage_0;

	// Token: 0x040003B2 RID: 946
	public static QMToggleButton qmtoggleButton_0;

	// Token: 0x040003B3 RID: 947
	internal static Class132 gxABKh9i3rWIdsCk3fl;

	// Token: 0x0200013F RID: 319
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040003B4 RID: 948
		public static Action action_0;

		// Token: 0x040003B5 RID: 949
		public static Action action_1;
	}
}
