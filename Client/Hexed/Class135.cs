using System;
using System.Runtime.CompilerServices;
using Hexed.UIApi;

// Token: 0x0200014A RID: 330
internal class Class135
{
	// Token: 0x0600070E RID: 1806 RVA: 0x00022CB8 File Offset: 0x00020EB8
	public static void Init()
	{
		Class135.qmmenuPage_0 = new QMMenuPage("Bot Exploits");
		new QMSingleButton(Class124.qmmenuPage_0, 3f, 1.5f, "Exploits", new Action(Class135.qmmenuPage_0.OpenMe), "Bot Exploit Options", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Exploits"));
		QMMenuPage btnMenu = Class135.qmmenuPage_0;
		float btnXLocation = 1f;
		float btnYLocation = 0f;
		string btnText = "Camera \nCrash";
		Action btnAction;
		if ((btnAction = Class135.<>O.action_0) == null)
		{
			btnAction = (Class135.<>O.action_0 = new Action(Class48.CacheCrash));
		}
		new QMSingleButton(btnMenu, btnXLocation, btnYLocation, btnText, btnAction, "Crash the Room with Camera spam", ButtonAPI.ButtonSize.Half, null);
		QMMenuPage btnMenu2 = Class135.qmmenuPage_0;
		float btnXLocation2 = 2f;
		float btnYLocation2 = 0f;
		string btnText2 = "Voice \nDistortion";
		Action btnAction2;
		if ((btnAction2 = Class135.<>O.action_1) == null)
		{
			btnAction2 = (Class135.<>O.action_1 = new Action(Class48.VoiceCrash));
		}
		new QMSingleButton(btnMenu2, btnXLocation2, btnYLocation2, btnText2, btnAction2, "Earrape the Room with USpeak", ButtonAPI.ButtonSize.Half, null);
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x000036CD File Offset: 0x000018CD
	internal static bool zFETJs9XYOjLam7Zn96()
	{
		return Class135.RsBdgf9FpOUTkh7uLpt == null;
	}

	// Token: 0x040003E9 RID: 1001
	private static QMMenuPage qmmenuPage_0;

	// Token: 0x040003EA RID: 1002
	internal static Class135 RsBdgf9FpOUTkh7uLpt;

	// Token: 0x0200014B RID: 331
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040003EB RID: 1003
		public static Action action_0;

		// Token: 0x040003EC RID: 1004
		public static Action action_1;
	}
}
