using System;
using System.Runtime.CompilerServices;
using Hexed.UIApi;

// Token: 0x0200011D RID: 285
internal class Class120
{
	// Token: 0x060005C0 RID: 1472 RVA: 0x0001D73C File Offset: 0x0001B93C
	public static void Init()
	{
		Class120.qmmenuPage_0 = new QMMenuPage("Player Bots");
		new QMSingleButton(Class122.qmmenuPage_0, 4f, 0f, "Bots", new Action(Class120.qmmenuPage_0.OpenMe), "Bot Options", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Bots"));
		new QMToggleButton(Class120.qmmenuPage_0, 1f, 0f, "Repeat \nMovement", delegate()
		{
			Class48.MimicMovement(Class9.GetSelectedPlayer().GetPhotonPlayer().ActorID());
		}, delegate()
		{
			Class48.MimicMovement(-2);
		}, "Copy the Players Movement Events", false);
		new QMToggleButton(Class120.qmmenuPage_0, 2f, 0f, "Repeat \nAvatarSync", delegate()
		{
			Class48.MimicAvatarSync(Class9.GetSelectedPlayer().GetPhotonPlayer().ActorID());
		}, delegate()
		{
			Class48.MimicAvatarSync(-2);
		}, "Copy the Players Avatar Sync Events", false);
		new QMToggleButton(Class120.qmmenuPage_0, 3f, 0f, "Repeat \nVoice", delegate()
		{
			Class48.MimicVoice(Class9.GetSelectedPlayer().GetPhotonPlayer().ActorID());
		}, delegate()
		{
			Class48.MimicVoice(-2);
		}, "Copy the Players Voice Events", false);
		new QMToggleButton(Class120.qmmenuPage_0, 4f, 0f, "Repeat \nRPC", delegate()
		{
			Class48.MimicRPC(Class9.GetSelectedPlayer().GetPhotonPlayer().ActorID());
		}, delegate()
		{
			Class48.MimicRPC(-2);
		}, "Copy the Players RPC Events", false);
		new QMSingleButton(Class120.qmmenuPage_0, 1f, 1f, "Block", delegate()
		{
			Class48.Block(Class9.GetSelectedPlayer().UserID(), true);
		}, "Block the Player", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class120.qmmenuPage_0, 1f, 1.5f, "Unblock", delegate()
		{
			Class48.Block(Class9.GetSelectedPlayer().UserID(), false);
		}, "Unblock the Player", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class120.qmmenuPage_0, 2f, 1f, "Mute", delegate()
		{
			Class48.Mute(Class9.GetSelectedPlayer().UserID(), true);
		}, "Mute the Player", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class120.qmmenuPage_0, 2f, 1.5f, "Unmute", delegate()
		{
			Class48.Mute(Class9.GetSelectedPlayer().UserID(), false);
		}, "Unmute the Player", ButtonAPI.ButtonSize.Half, null);
		new QMToggleButton(Class120.qmmenuPage_0, 3f, 1f, "Repeat \nChat", delegate()
		{
			Class48.MimicChat(Class9.GetSelectedPlayer().GetPhotonPlayer().ActorID());
		}, delegate()
		{
			Class48.MimicChat(-2);
		}, "Copy the Players Chat Events", false);
		QMMenuPage location = Class120.qmmenuPage_0;
		float btnXPos = 4f;
		float btnYPos = 1f;
		string btnText = "Record \nMovement";
		Action onAction = delegate()
		{
			Class3.VRCUiPopupManager.AskInGameInput("File Name", "Ok", delegate(string text)
			{
				Class48.StartRecordMotion(Class9.GetSelectedPlayer().GetPhotonPlayer().ActorID(), text);
			}, null);
		};
		Action offAction;
		if ((offAction = Class120.<>O.action_0) == null)
		{
			offAction = (Class120.<>O.action_0 = new Action(Class48.StopRecordMotion));
		}
		new QMToggleButton(location, btnXPos, btnYPos, btnText, onAction, offAction, "Record the Players Movement Events", false);
		new QMSingleButton(Class120.qmmenuPage_0, 1f, 2f, "Add \nFriend", delegate()
		{
			Class48.AddFriend(Class9.GetSelectedPlayer().UserID());
		}, "Add the Player as Friend", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class120.qmmenuPage_0, 2f, 2f, "Forcekick", delegate()
		{
			Class48.Forcekick(Class9.GetSelectedPlayer().UserID());
		}, "Votekick the Player", ButtonAPI.ButtonSize.Half, null);
	}

	// Token: 0x060005C2 RID: 1474 RVA: 0x0000338F File Offset: 0x0000158F
	internal static bool gM2gvxIwKQ0OG5eHTqY()
	{
		return Class120.iw1y2FI6VJlFhUyDVow == null;
	}

	// Token: 0x040002AE RID: 686
	private static QMMenuPage qmmenuPage_0;

	// Token: 0x040002AF RID: 687
	internal static Class120 iw1y2FI6VJlFhUyDVow;

	// Token: 0x0200011E RID: 286
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040002B0 RID: 688
		public static Action action_0;
	}
}
