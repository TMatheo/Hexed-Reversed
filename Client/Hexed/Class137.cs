using System;
using System.IO;
using System.Runtime.CompilerServices;
using Hexed.UIApi;

// Token: 0x0200014E RID: 334
internal class Class137
{
	// Token: 0x0600071D RID: 1821 RVA: 0x00022F74 File Offset: 0x00021174
	public static void Init()
	{
		Class137.qmmenuPage_0 = new QMMenuPage("Bot Physics");
		new QMSingleButton(Class124.qmmenuPage_0, 2f, 1.5f, "Physics", new Action(Class137.qmmenuPage_0.OpenMe), "Bot Physic Options", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Physics"));
		new QMSingleButton(Class137.qmmenuPage_0, 0.75f, 0f, "+", delegate()
		{
			Class48.ChangePositionOffset("X", true);
		}, "Increase the X Offset", ButtonAPI.ButtonSize.Square, null);
		new QMSingleButton(Class137.qmmenuPage_0, 1.25f, 0f, "-", delegate()
		{
			Class48.ChangePositionOffset("X", false);
		}, "Decrease the X Offset", ButtonAPI.ButtonSize.Square, null);
		new QMSingleButton(Class137.qmmenuPage_0, 1f, 0.5f, "X Position", delegate()
		{
			Class48.ResetPositionOffset("X");
		}, "Reset the X Offset", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class137.qmmenuPage_0, 1.75f, 0f, "+", delegate()
		{
			Class48.ChangePositionOffset("Y", true);
		}, "Increase the Y Offset", ButtonAPI.ButtonSize.Square, null);
		new QMSingleButton(Class137.qmmenuPage_0, 2.25f, 0f, "-", delegate()
		{
			Class48.ChangePositionOffset("Y", false);
		}, "Decrease the Y Offset", ButtonAPI.ButtonSize.Square, null);
		new QMSingleButton(Class137.qmmenuPage_0, 2f, 0.5f, "Y Position", delegate()
		{
			Class48.ResetPositionOffset("Y");
		}, "Reset the Y Offset", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class137.qmmenuPage_0, 2.75f, 0f, "+", delegate()
		{
			Class48.ChangePositionOffset("Z", true);
		}, "Increase the Z Offset", ButtonAPI.ButtonSize.Square, null);
		new QMSingleButton(Class137.qmmenuPage_0, 3.25f, 0f, "-", delegate()
		{
			Class48.ChangePositionOffset("Z", false);
		}, "Decrease the Z Offset", ButtonAPI.ButtonSize.Square, null);
		new QMSingleButton(Class137.qmmenuPage_0, 3f, 0.5f, "Z Position", delegate()
		{
			Class48.ResetPositionOffset("Z");
		}, "Reset the Z Offset", ButtonAPI.ButtonSize.Half, null);
		new QMToggleButton(Class137.qmmenuPage_0, 4f, 0f, "Freeze \nPosition", delegate()
		{
			Class48.FreezePosition(true);
		}, delegate()
		{
			Class48.FreezePosition(false);
		}, "Freeze the current Position", false);
		new QMSingleButton(Class137.qmmenuPage_0, 0.75f, 1f, "+", delegate()
		{
			Class48.ChangeRotationOffset("X", true);
		}, "Increase the X Offset", ButtonAPI.ButtonSize.Square, null);
		new QMSingleButton(Class137.qmmenuPage_0, 1.25f, 1f, "-", delegate()
		{
			Class48.ChangeRotationOffset("X", false);
		}, "Decrease the X Offset", ButtonAPI.ButtonSize.Square, null);
		new QMSingleButton(Class137.qmmenuPage_0, 1f, 1.5f, "X Rotation", delegate()
		{
			Class48.ResetRotationOffset("X");
		}, "Reset the X Offset", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class137.qmmenuPage_0, 1.75f, 1f, "+", delegate()
		{
			Class48.ChangeRotationOffset("Y", true);
		}, "Increase the Y Offset", ButtonAPI.ButtonSize.Square, null);
		new QMSingleButton(Class137.qmmenuPage_0, 2.25f, 1f, "-", delegate()
		{
			Class48.ChangeRotationOffset("Y", false);
		}, "Decrease the Y Offset", ButtonAPI.ButtonSize.Square, null);
		new QMSingleButton(Class137.qmmenuPage_0, 2f, 1.5f, "Y Rotation", delegate()
		{
			Class48.ResetRotationOffset("Y");
		}, "Reset the Y Offset", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class137.qmmenuPage_0, 2.75f, 1f, "+", delegate()
		{
			Class48.ChangeRotationOffset("Z", true);
		}, "Increase the Z Offset", ButtonAPI.ButtonSize.Square, null);
		new QMSingleButton(Class137.qmmenuPage_0, 3.25f, 1f, "-", delegate()
		{
			Class48.ChangeRotationOffset("Z", false);
		}, "Decrease the Z Offset", ButtonAPI.ButtonSize.Square, null);
		new QMSingleButton(Class137.qmmenuPage_0, 3f, 1.5f, "Z Rotation", delegate()
		{
			Class48.ResetRotationOffset("Z");
		}, "Reset the Z Offset", ButtonAPI.ButtonSize.Half, null);
		new QMToggleButton(Class137.qmmenuPage_0, 4f, 1f, "Freeze \nRotation", delegate()
		{
			Class48.FreezeRotation(true);
		}, delegate()
		{
			Class48.FreezeRotation(false);
		}, "Freeze the current Rotation", false);
		new QMSingleButton(Class137.qmmenuPage_0, 0.75f, 2f, "+", delegate()
		{
			Class48.ChangeOrbitRange(true);
		}, "Increase the Orbit Range", ButtonAPI.ButtonSize.Square, null);
		new QMSingleButton(Class137.qmmenuPage_0, 1.25f, 2f, "-", delegate()
		{
			Class48.ChangeOrbitRange(false);
		}, "Decrease the Orbit Range", ButtonAPI.ButtonSize.Square, null);
		QMMenuPage btnMenu = Class137.qmmenuPage_0;
		float btnXLocation = 1f;
		float btnYLocation = 2.5f;
		string btnText = "Range";
		Action btnAction;
		if ((btnAction = Class137.<>O.action_0) == null)
		{
			btnAction = (Class137.<>O.action_0 = new Action(Class48.ResetOrbitRange));
		}
		new QMSingleButton(btnMenu, btnXLocation, btnYLocation, btnText, btnAction, "Reset the Orbit Range", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class137.qmmenuPage_0, 1.75f, 2f, "+", delegate()
		{
			Class48.ChangeOrbitSpeed(true);
		}, "Increase the Orbit Speed", ButtonAPI.ButtonSize.Square, null);
		new QMSingleButton(Class137.qmmenuPage_0, 2.25f, 2f, "-", delegate()
		{
			Class48.ChangeOrbitSpeed(false);
		}, "Decrease the Orbit Speed", ButtonAPI.ButtonSize.Square, null);
		QMMenuPage btnMenu2 = Class137.qmmenuPage_0;
		float btnXLocation2 = 2f;
		float btnYLocation2 = 2.5f;
		string btnText2 = "Speed";
		Action btnAction2;
		if ((btnAction2 = Class137.<>O.action_1) == null)
		{
			btnAction2 = (Class137.<>O.action_1 = new Action(Class48.ResetOrbitSpeed));
		}
		new QMSingleButton(btnMenu2, btnXLocation2, btnYLocation2, btnText2, btnAction2, "Reset the Orbit Speed", ButtonAPI.ButtonSize.Half, null);
		new QMToggleButton(Class137.qmmenuPage_0, 3f, 2f, "AFK \nMode", delegate()
		{
			Class48.AFKMode(true);
		}, delegate()
		{
			Class48.AFKMode(false);
		}, "Switch the Bot to AFK Mode", false);
		new QMToggleButton(Class137.qmmenuPage_0, 4f, 2f, "Follow \nCamera", delegate()
		{
			Class48.CameraFollowMode(true);
		}, delegate()
		{
			Class48.CameraFollowMode(false);
		}, "Switch the Bot to follow the Camera", false);
		QMScrollButton qmscrollButton_0 = new QMScrollButton(Class137.qmmenuPage_0, 1f, 3f, "Motion \nFiles", "Motion Files", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Options"));
		QMScrollButton qmscrollButton_1 = new QMScrollButton(Class137.qmmenuPage_0, 1f, 3f, "Motion Options", "Motion File Options", ButtonAPI.ButtonSize.Default, null);
		qmscrollButton_1.MainButton.GetGameObject().SetActive(false);
		qmscrollButton_0.SetAction(delegate()
		{
			string[] array = Directory.GetDirectories("Hexed\\Bots\\Movements");
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				string string_0 = text.Replace("Hexed\\Bots\\Movements\\", "");
				qmscrollButton_0.Add(string_0, "Open the Subfolder", delegate
				{
					qmscrollButton_1.SetAction(delegate()
					{
						string[] files = Directory.GetFiles("Hexed\\Bots\\Movements\\" + string_0);
						for (int j = 0; j < files.Length; j++)
						{
							string string_0 = files[j];
							string text3 = string_0.Replace("Hexed\\Bots\\Movements\\" + string_0 + "\\", "").Split('.', StringSplitOptions.None)[0];
							qmscrollButton_1.Add(text3, "Play the Motion", delegate
							{
								Class48.PlayMotionFile(string_0.Replace("Hexed\\Bots\\", ""));
							});
						}
					});
					qmscrollButton_1.MainButton.ClickMe();
				});
			}
			array = Directory.GetFiles("Hexed\\Bots\\Movements");
			for (int i = 0; i < array.Length; i++)
			{
				string string_0 = array[i];
				string text2 = string_0.Replace("Hexed\\Bots\\Movements\\", "").Split('.', StringSplitOptions.None)[0];
				qmscrollButton_0.Add(text2, "Play the Motion", delegate
				{
					Class48.PlayMotionFile(string_0.Replace("Hexed\\Bots\\", ""));
				});
			}
		});
		new QMToggleButton(Class137.qmmenuPage_0, 2f, 3f, "Loop \nReplay", delegate()
		{
			Class48.LoopAnimationRecord(true);
		}, delegate()
		{
			Class48.LoopAnimationRecord(false);
		}, "Loop Motion Records", false);
		QMMenuPage btnMenu3 = Class137.qmmenuPage_0;
		float btnXLocation3 = 3f;
		float btnYLocation3 = 3f;
		string btnText3 = "Stop \nMotion";
		Action btnAction3;
		if ((btnAction3 = Class137.<>O.action_2) == null)
		{
			btnAction3 = (Class137.<>O.action_2 = new Action(Class48.StopMotionReplay));
		}
		new QMSingleButton(btnMenu3, btnXLocation3, btnYLocation3, btnText3, btnAction3, "Stop the currently played Motion", ButtonAPI.ButtonSize.Half, null);
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x00003703 File Offset: 0x00001903
	internal static bool fYkJ3W95D4osknKCmlJ()
	{
		return Class137.YtULvD9yMJ1a8sPIG0s == null;
	}

	// Token: 0x040003F7 RID: 1015
	private static QMMenuPage qmmenuPage_0;

	// Token: 0x040003F8 RID: 1016
	internal static Class137 YtULvD9yMJ1a8sPIG0s;

	// Token: 0x0200014F RID: 335
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040003F9 RID: 1017
		public static Action action_0;

		// Token: 0x040003FA RID: 1018
		public static Action action_1;

		// Token: 0x040003FB RID: 1019
		public static Action action_2;
	}
}
