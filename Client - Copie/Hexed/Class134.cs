using System;
using System.IO;
using System.Runtime.CompilerServices;
using Hexed.UIApi;

// Token: 0x02000143 RID: 323
internal class Class134
{
	// Token: 0x060006F5 RID: 1781 RVA: 0x00022798 File Offset: 0x00020998
	public static void Init()
	{
		Class134.qmmenuPage_0 = new QMMenuPage("Bot Audio");
		new QMSingleButton(Class124.qmmenuPage_0, 1f, 1.5f, "Audio", new Action(Class134.qmmenuPage_0.OpenMe), "Bot Audio Options", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Options"));
		QMScrollButton qmscrollButton_0 = new QMScrollButton(Class134.qmmenuPage_0, 1f, 0f, "Audio \nFiles", "Audio Files", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Options"));
		QMScrollButton qmscrollButton_1 = new QMScrollButton(Class134.qmmenuPage_0, 1f, 0f, "Audio Options", "Audio File Options", ButtonAPI.ButtonSize.Default, null);
		qmscrollButton_1.MainButton.GetGameObject().SetActive(false);
		qmscrollButton_0.SetAction(delegate()
		{
			string[] array = Directory.GetDirectories("Hexed\\Bots\\Audios");
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				string string_0 = text.Replace("Hexed\\Bots\\Audios\\", "");
				qmscrollButton_0.Add(string_0, "Open the Subfolder", delegate
				{
					qmscrollButton_1.SetAction(delegate()
					{
						string[] files = Directory.GetFiles("Hexed\\Bots\\Audios\\" + string_0);
						for (int j = 0; j < files.Length; j++)
						{
							string string_0 = files[j];
							string text3 = string_0.Replace("Hexed\\Bots\\Audios\\" + string_0 + "\\", "").Split('.', StringSplitOptions.None)[0];
							qmscrollButton_1.Add(text3, "Play the Audio", delegate
							{
								Class48.PlayAudioFile(Class109.ToBase64(Path.Combine(Directory.GetCurrentDirectory(), string_0)));
							});
						}
					});
					qmscrollButton_1.MainButton.ClickMe();
				});
			}
			array = Directory.GetFiles("Hexed\\Bots\\Audios");
			for (int i = 0; i < array.Length; i++)
			{
				string string_0 = array[i];
				string text2 = string_0.Replace("Hexed\\Bots\\Audios\\", "").Split('.', StringSplitOptions.None)[0];
				qmscrollButton_0.Add(text2, "Play the Audio", delegate
				{
					Class48.PlayAudioFile(Class109.ToBase64(Path.Combine(Directory.GetCurrentDirectory(), string_0)));
				});
			}
		});
		new QMSingleButton(Class134.qmmenuPage_0, 2f, 0f, "TTS", delegate()
		{
			Class3.VRCUiPopupManager.AskInGameInput("Text Message", "Ok", delegate(string text)
			{
				Class48.PlayTextToVoice(text);
			}, null);
		}, "Send a Text to Speech message", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class134.qmmenuPage_0, 2f, 0.5f, "Youtube", delegate()
		{
			Class3.VRCUiPopupManager.AskInGameInput("Youtube URL", "Ok", delegate(string text)
			{
				Class48.PlayYoutube(text);
			}, null);
		}, "Send a Text to Speech message", ButtonAPI.ButtonSize.Half, null);
		QMMenuPage btnMenu = Class134.qmmenuPage_0;
		float btnXLocation = 3f;
		float btnYLocation = 0f;
		string btnText = "Stop \nAudio";
		Action btnAction;
		if ((btnAction = Class134.<>O.action_0) == null)
		{
			btnAction = (Class134.<>O.action_0 = new Action(Class48.StopAudioReplay));
		}
		new QMSingleButton(btnMenu, btnXLocation, btnYLocation, btnText, btnAction, "Stop the currently played Audio", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class134.qmmenuPage_0, 3.75f, 0f, "+", delegate()
		{
			Class48.ChangeAudioVolume(true);
		}, "Increase the Volume", ButtonAPI.ButtonSize.Square, null);
		new QMSingleButton(Class134.qmmenuPage_0, 4.25f, 0f, "-", delegate()
		{
			Class48.ChangeAudioVolume(false);
		}, "Decrease the Volume", ButtonAPI.ButtonSize.Square, null);
		QMMenuPage btnMenu2 = Class134.qmmenuPage_0;
		float btnXLocation2 = 4f;
		float btnYLocation2 = 0.5f;
		string btnText2 = "Volume";
		Action btnAction2;
		if ((btnAction2 = Class134.<>O.action_1) == null)
		{
			btnAction2 = (Class134.<>O.action_1 = new Action(Class48.ResetAudioVolume));
		}
		new QMSingleButton(btnMenu2, btnXLocation2, btnYLocation2, btnText2, btnAction2, "Reset the Volume", ButtonAPI.ButtonSize.Half, null);
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x00003671 File Offset: 0x00001871
	internal static bool HtJgYf9VZ4s0ga7eMwZ()
	{
		return Class134.fJMJOV9MK83h6EHNGJL == null;
	}

	// Token: 0x040003D3 RID: 979
	private static QMMenuPage qmmenuPage_0;

	// Token: 0x040003D4 RID: 980
	internal static Class134 fJMJOV9MK83h6EHNGJL;

	// Token: 0x02000144 RID: 324
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040003D5 RID: 981
		public static Action action_0;

		// Token: 0x040003D6 RID: 982
		public static Action action_1;
	}
}
