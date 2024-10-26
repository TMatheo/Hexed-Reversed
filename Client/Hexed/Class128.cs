using System;
using System.Runtime.CompilerServices;
using Hexed.UIApi;

// Token: 0x02000131 RID: 305
internal class Class128
{
	// Token: 0x06000662 RID: 1634 RVA: 0x0001FC60 File Offset: 0x0001DE60
	public static void Init()
	{
		Class128.qmmenuPage_0 = new QMMenuPage("Physics");
		new QMSingleButton(Class127.qmmenuPage_0, 3f, 0f, "Physics", new Action(Class128.qmmenuPage_0.OpenMe), "Physics Options", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Physics"));
		new QMToggleButton(Class128.qmmenuPage_0, 1f, 0f, "Bunny \nHop", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "BunnyHop", true);
			Class143.bool_21 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "BunnyHop", false);
			Class143.bool_21 = false;
		}, "Automatically Jump", Class141.class6_0.GetBool("Toggles", "BunnyHop", false, false));
		new QMToggleButton(Class128.qmmenuPage_0, 2f, 0f, "Inf \nJump", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "InfJump", true);
			Class143.bool_22 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "InfJump", false);
			Class143.bool_22 = false;
		}, "Jump without Cooldown", Class141.class6_0.GetBool("Toggles", "InfJump", false, false));
		new QMToggleButton(Class128.qmmenuPage_0, 3f, 0f, "Multi \nJump", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "MultiJump", true);
			Class143.bool_23 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "MultiJump", false);
			Class143.bool_23 = false;
		}, "Jump in the Air", Class141.class6_0.GetBool("Toggles", "MultiJump", false, false));
		new QMToggleButton(Class128.qmmenuPage_0, 4f, 0f, "High \nJump", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "HighJump", true);
			Class38.ToggleHighJump();
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "HighJump", false);
			Class38.ToggleHighJump();
		}, "Jump very High", Class141.class6_0.GetBool("Toggles", "HighJump", false, false));
		new QMToggleButton(Class128.qmmenuPage_0, 1f, 1f, "Speed", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "Speed", true);
			Class38.ToggleSpeed();
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "Speed", false);
			Class38.ToggleSpeed();
		}, "Increase run Speed", Class141.class6_0.GetBool("Toggles", "Speed", false, false));
		QMMenuPage location = Class128.qmmenuPage_0;
		float btnXPos = 2f;
		float btnYPos = 1f;
		string btnText = "Fly";
		Action onAction;
		if ((onAction = Class128.<>O.action_0) == null)
		{
			onAction = (Class128.<>O.action_0 = new Action(Class38.ToggleFly));
		}
		Action offAction;
		if ((offAction = Class128.<>O.action_0) == null)
		{
			offAction = (Class128.<>O.action_0 = new Action(Class38.ToggleFly));
		}
		Class128.qmtoggleButton_0 = new QMToggleButton(location, btnXPos, btnYPos, btnText, onAction, offAction, "Toggle Fly mode", false);
		QMMenuPage location2 = Class128.qmmenuPage_0;
		float btnXPos2 = 3f;
		float btnYPos2 = 1f;
		string btnText2 = "No \nClip";
		Action onAction2;
		if ((onAction2 = Class128.<>O.action_1) == null)
		{
			onAction2 = (Class128.<>O.action_1 = new Action(Class38.ToggleNoClip));
		}
		Action offAction2;
		if ((offAction2 = Class128.<>O.action_1) == null)
		{
			offAction2 = (Class128.<>O.action_1 = new Action(Class38.ToggleNoClip));
		}
		Class128.qmtoggleButton_1 = new QMToggleButton(location2, btnXPos2, btnYPos2, btnText2, onAction2, offAction2, "Toggle NoClip mode", false);
		QMMenuPage location3 = Class128.qmmenuPage_0;
		float btnXPos3 = 4f;
		float btnYPos3 = 1f;
		string btnText3 = "Desktop \nRotate";
		Action onAction3;
		if ((onAction3 = Class128.<>O.action_2) == null)
		{
			onAction3 = (Class128.<>O.action_2 = new Action(Class38.ToggleRotate));
		}
		Action offAction3;
		if ((offAction3 = Class128.<>O.action_2) == null)
		{
			offAction3 = (Class128.<>O.action_2 = new Action(Class38.ToggleRotate));
		}
		Class128.qmtoggleButton_2 = new QMToggleButton(location3, btnXPos3, btnYPos3, btnText3, onAction3, offAction3, "Toggle Rotation mode", false);
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x000035B9 File Offset: 0x000017B9
	internal static bool ed3DF0IWLkSktnfr5Is()
	{
		return Class128.OhpP5pIDLVY76rrNI83 == null;
	}

	// Token: 0x04000346 RID: 838
	private static QMMenuPage qmmenuPage_0;

	// Token: 0x04000347 RID: 839
	public static QMToggleButton qmtoggleButton_0;

	// Token: 0x04000348 RID: 840
	public static QMToggleButton qmtoggleButton_1;

	// Token: 0x04000349 RID: 841
	public static QMToggleButton qmtoggleButton_2;

	// Token: 0x0400034A RID: 842
	internal static Class128 OhpP5pIDLVY76rrNI83;

	// Token: 0x02000132 RID: 306
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400034B RID: 843
		public static Action action_0;

		// Token: 0x0400034C RID: 844
		public static Action action_1;

		// Token: 0x0400034D RID: 845
		public static Action action_2;
	}
}
