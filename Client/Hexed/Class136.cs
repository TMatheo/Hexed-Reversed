using System;
using Hexed.UIApi;

// Token: 0x0200014C RID: 332
internal class Class136
{
	// Token: 0x06000711 RID: 1809 RVA: 0x00022D88 File Offset: 0x00020F88
	public static void Init()
	{
		Class136.qmmenuPage_0 = new QMMenuPage("Bot Misc");
		new QMSingleButton(Class124.qmmenuPage_0, 4f, 1.5f, "Misc", new Action(Class136.qmmenuPage_0.OpenMe), "Bot Misc Options", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Debug"));
		new QMSingleButton(Class136.qmmenuPage_0, 1f, 0f, "Send \nChat", delegate()
		{
			Class3.VRCUiPopupManager.AskInGameInput("Text Message", "Ok", delegate(string text)
			{
				Class48.ChatMessage(text);
			}, null);
		}, "Send a Chatbox Message", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class136.qmmenuPage_0, 1f, 0.5f, "Avatar \nSize", delegate()
		{
			Class3.VRCUiPopupManager.AskInGameInput("100 - 100000", "Ok", delegate(string text)
			{
				Class48.AvatarHeight(Convert.ToInt32(text));
			}, null);
		}, "Change the Avatar Size", ButtonAPI.ButtonSize.Half, null);
		new QMToggleButton(Class136.qmmenuPage_0, 2f, 0f, "Chat \nCommands", delegate()
		{
			Class48.ChatCommands(true);
		}, delegate()
		{
			Class48.ChatCommands(false);
		}, "Handle the Bot with Chatbox Messages", false);
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x000036D7 File Offset: 0x000018D7
	internal static bool AvHL0T9BqX6l5dwhJ9P()
	{
		return Class136.vsOMdO9v8pBcmiAqhcY == null;
	}

	// Token: 0x040003ED RID: 1005
	private static QMMenuPage qmmenuPage_0;

	// Token: 0x040003EE RID: 1006
	private static Class136 vsOMdO9v8pBcmiAqhcY;
}
