using System;
using Hexed.UIApi;

// Token: 0x02000134 RID: 308
internal class Class129
{
	// Token: 0x06000672 RID: 1650 RVA: 0x000201AC File Offset: 0x0001E3AC
	public static void Init()
	{
		Class129.qmmenuPage_0 = new QMMenuPage("Safety");
		new QMSingleButton(Class127.qmmenuPage_0, 1f, 0f, "Safety", new Action(Class129.qmmenuPage_0.OpenMe), "Safety Options", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Safety"));
		new QMToggleButton(Class129.qmmenuPage_0, 1f, 0f, "No \nDestroy", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoObjectDestroy", true);
			Class143.bool_12 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoObjectDestroy", false);
			Class143.bool_12 = false;
		}, "Prevent Players from destroying Objects", Class141.class6_0.GetBool("Toggles", "NoObjectDestroy", false, false));
		new QMToggleButton(Class129.qmmenuPage_0, 2f, 0f, "No \nEmojis", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoEmojiSpawn", true);
			Class143.bool_13 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoEmojiSpawn", false);
			Class143.bool_13 = false;
		}, "Prevent Emoji spawns", Class141.class6_0.GetBool("Toggles", "NoEmojiSpawn", false, false));
		new QMToggleButton(Class129.qmmenuPage_0, 3f, 0f, "Anti \nMimic", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "SpoofMovementLenght", true);
			Class143.bool_20 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "SpoofMovementLenght", false);
			Class143.bool_20 = false;
		}, "Obfuscate your Movement Events", Class141.class6_0.GetBool("Toggles", "SpoofMovementLenght", false, false));
		new QMToggleButton(Class129.qmmenuPage_0, 4f, 0f, "Mute \nCamera", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoCameraTimer", true);
			Class143.bool_17 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoCameraTimer", false);
			Class143.bool_17 = false;
		}, "Prevent Camera Sounds", Class141.class6_0.GetBool("Toggles", "NoCameraTimer", false, false));
		new QMToggleButton(Class129.qmmenuPage_0, 1f, 1f, "No Udon\nEvents", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoUdonEvents", true);
			Class143.bool_14 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoUdonEvents", false);
			Class143.bool_14 = false;
		}, "Prevent Udon Events", Class141.class6_0.GetBool("Toggles", "NoUdonEvents", false, false));
		new QMToggleButton(Class129.qmmenuPage_0, 2f, 1f, "No \nVideo", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoVideoPlayer", true);
			Class143.bool_18 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoVideoPlayer", false);
			Class143.bool_18 = false;
		}, "Prevent Videoplayers from loading", Class141.class6_0.GetBool("Toggles", "NoVideoPlayer", false, false));
		new QMToggleButton(Class129.qmmenuPage_0, 3f, 1f, "No Udon\nSync", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoUdonSync", true);
			Class143.bool_33 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoUdonSync", false);
			Class143.bool_33 = false;
		}, "Prevent Udon Sync", Class141.class6_0.GetBool("Toggles", "NoUdonSync", false, false));
		new QMToggleButton(Class129.qmmenuPage_0, 4f, 1f, "Anti \nBlock", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "AntiBlock", true);
			Class143.bool_19 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "AntiBlock", false);
			Class143.bool_19 = false;
		}, "See Players which blocked you", Class141.class6_0.GetBool("Toggles", "AntiBlock", false, false));
		QMSelectButton qmselectButton = new QMSelectButton(Class129.qmmenuPage_0, 1f, 2f, "Anti \nPortal", "Prevent Portals being dropped", Class143.antiPortalMode_0, Class141.class6_0.GetInt("Toggles", "AntiPortalMode", 0, false));
		qmselectButton.AddAction(0, delegate
		{
			Class141.class6_0.SetInt("Toggles", "AntiPortalMode", 0);
			Class143.antiPortalMode_0 = Class143.AntiPortalMode.None;
		});
		qmselectButton.AddAction(1, delegate
		{
			Class141.class6_0.SetInt("Toggles", "AntiPortalMode", 1);
			Class143.antiPortalMode_0 = Class143.AntiPortalMode.All;
		});
		qmselectButton.AddAction(2, delegate
		{
			Class141.class6_0.SetInt("Toggles", "AntiPortalMode", 2);
			Class143.antiPortalMode_0 = Class143.AntiPortalMode.Friends;
		});
		new QMToggleButton(Class129.qmmenuPage_0, 2f, 2f, "No \nScaling", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoUdonScaling", true);
			Class143.bool_16 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoUdonScaling", false);
			Class143.bool_16 = false;
		}, "Disable Udon scaling", Class141.class6_0.GetBool("Toggles", "NoUdonScaling", false, false));
		new QMToggleButton(Class129.qmmenuPage_0, 3f, 2f, "Silent \nMute", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "SilentMute", true);
			Class143.bool_28 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "SilentMute", false);
			Class143.bool_28 = false;
		}, "Mute Player's without them knowing", Class141.class6_0.GetBool("Toggles", "SilentMute", false, false));
		new QMToggleButton(Class129.qmmenuPage_0, 4f, 2f, "Anti \nOverride", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "AntiOverride", true);
			Class143.bool_29 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "AntiOverride", false);
			Class143.bool_29 = false;
		}, "Prevent overrides on your Audio Controller", Class141.class6_0.GetBool("Toggles", "AntiOverride", false, false));
		new QMToggleButton(Class129.qmmenuPage_0, 1f, 3f, "God \nMode", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "GodMode", true);
			Class143.bool_30 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "GodMode", false);
			Class143.bool_30 = false;
		}, "Prevent taking Damage", Class141.class6_0.GetBool("Toggles", "GodMode", false, false));
		new QMToggleButton(Class129.qmmenuPage_0, 2f, 3f, "No \nTeleport", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoTeleport", true);
			Class143.bool_31 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoTeleport", false);
			Class143.bool_31 = false;
		}, "Prevent getting Teleported", Class141.class6_0.GetBool("Toggles", "NoTeleport", false, false));
		new QMToggleButton(Class129.qmmenuPage_0, 3f, 3f, "No Udon \nDownload", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoUdonDownload", true);
			Class143.bool_15 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "NoUdonDownload", false);
			Class143.bool_15 = false;
		}, "Prevent Udon downloads", Class141.class6_0.GetBool("Toggles", "NoUdonDownload", false, false));
		new QMToggleButton(Class129.qmmenuPage_0, 4f, 3f, "Movement \nRedirect", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "MovementRedirect", true);
			Class143.bool_34 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "MovementRedirect", false);
			Class143.bool_34 = false;
		}, "Redirect own Movement to a different Event", Class141.class6_0.GetBool("Toggles", "MovementRedirect", false, false));
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x000035CD File Offset: 0x000017CD
	internal static bool lPNgql9ZTU7MHYj6bpo()
	{
		return Class129.FitLd89198Yaie6loQR == null;
	}

	// Token: 0x0400035A RID: 858
	private static QMMenuPage qmmenuPage_0;

	// Token: 0x0400035B RID: 859
	private static Class129 FitLd89198Yaie6loQR;
}
