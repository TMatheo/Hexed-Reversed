using System;
using System.Runtime.CompilerServices;
using Hexed.UIApi;
using VRC;

// Token: 0x02000128 RID: 296
internal class Class124
{
	// Token: 0x06000609 RID: 1545 RVA: 0x0001E824 File Offset: 0x0001CA24
	public static void Init()
	{
		Class124.qmmenuPage_0 = new QMMenuPage("Bots");
		new QMSingleButton(Class127.qmmenuPage_0, 4f, 0f, "Bots", new Action(Class124.qmmenuPage_0.OpenMe), "Bot Options", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Bots"));
		QMMenuPage location = Class124.qmmenuPage_0;
		float btnXPos = 1f;
		float btnYPos = 0f;
		string btnText = "Start \nHost";
		Action onAction;
		if ((onAction = Class124.<>O.action_0) == null)
		{
			onAction = (Class124.<>O.action_0 = new Action(Class48.StartBot));
		}
		Action offAction;
		if ((offAction = Class124.<>O.action_1) == null)
		{
			offAction = (Class124.<>O.action_1 = new Action(Class48.StopBot));
		}
		new QMToggleButton(location, btnXPos, btnYPos, btnText, onAction, offAction, "Start/Stop the Photonbot Server", false);
		new QMSingleButton(Class124.qmmenuPage_0, 2f, 0f, "Change \nAvatar", delegate()
		{
			Class3.VRCUiPopupManager.AskInGameInput("AvatarID", "Ok", delegate(string text)
			{
				if (text.StartsWith("avtr_"))
				{
					Class48.ChangeAvatar(text);
				}
			}, "avtr_");
		}, "Change the Bots Avatar", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class124.qmmenuPage_0, 2f, 0.5f, "Change \nFallback", delegate()
		{
			Class3.VRCUiPopupManager.AskInGameInput("AvatarID", "Ok", delegate(string text)
			{
				if (text.StartsWith("avtr_"))
				{
					Class48.ChangeFallbackAvatar(text);
				}
			}, "avtr_");
		}, "Change the Bots fallback Avatar", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class124.qmmenuPage_0, 3f, 0f, "Change \nStatus", delegate()
		{
			Class3.VRCUiPopupManager.AskInGameInput("Text", "Ok", delegate(string text)
			{
				Class48.ChangeStatus(text);
			}, null);
		}, "Change the Bots Status", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class124.qmmenuPage_0, 3f, 0.5f, "Change \nBio", delegate()
		{
			Class3.VRCUiPopupManager.AskInGameInput("Text", "Ok", delegate(string text)
			{
				Class48.ChangeBio(text);
			}, null);
		}, "Change the Bots Bio", ButtonAPI.ButtonSize.Half, null);
		Class124.qmtoggleButton_0 = new QMToggleButton(Class124.qmmenuPage_0, 4f, 0f, "Self \nBot", delegate()
		{
			Class52.CustomSerialize(true, false);
			Class48.SelfbotExpose();
			Class5.DelayAction(1f, delegate
			{
				Player player = Class3.PlayerManager.GetPlayer(Class48.string_0);
				if (player != null)
				{
					Class52.AddBotSerialize(player);
				}
			}).Start();
		}, delegate()
		{
			Class52.CustomSerialize(false, false);
		}, "Control the Bot", false);
		new QMSingleButton(Class124.qmmenuPage_0, 1.5f, 3.5f, "Join", delegate()
		{
			Class48.JoinRoom(Class4.GetCurrentWorldID());
		}, "Connect the bot to your Room", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class124.qmmenuPage_0, 2.5f, 3.5f, "Join \nID", delegate()
		{
			Class3.VRCUiPopupManager.AskInGameInput("World ID", "Ok", delegate(string text)
			{
				if (text.StartsWith("wrld_"))
				{
					Class48.JoinRoom(text);
				}
			}, "wrld_");
		}, "Connect the bot to a Room", ButtonAPI.ButtonSize.Half, null);
		QMMenuPage btnMenu = Class124.qmmenuPage_0;
		float btnXLocation = 3.5f;
		float btnYLocation = 3.5f;
		string btnText2 = "Leave";
		Action btnAction;
		if ((btnAction = Class124.<>O.action_2) == null)
		{
			btnAction = (Class124.<>O.action_2 = new Action(Class48.LeaveRoom));
		}
		new QMSingleButton(btnMenu, btnXLocation, btnYLocation, btnText2, btnAction, "Disconnect the Bot from the Room", ButtonAPI.ButtonSize.Half, null);
		Class134.Init();
		Class137.Init();
		Class135.Init();
		Class136.Init();
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x0000345D File Offset: 0x0000165D
	internal static bool CvRZClIP0CRnQBqFJWS()
	{
		return Class124.xyijV5IKSlwtDgMrZBk == null;
	}

	// Token: 0x040002F1 RID: 753
	public static QMMenuPage qmmenuPage_0;

	// Token: 0x040002F2 RID: 754
	public static QMToggleButton qmtoggleButton_0;

	// Token: 0x040002F3 RID: 755
	internal static Class124 xyijV5IKSlwtDgMrZBk;

	// Token: 0x02000129 RID: 297
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040002F4 RID: 756
		public static Action action_0;

		// Token: 0x040002F5 RID: 757
		public static Action action_1;

		// Token: 0x040002F6 RID: 758
		public static Action action_2;
	}
}
