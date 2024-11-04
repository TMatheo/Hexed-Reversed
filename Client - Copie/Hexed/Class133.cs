using System;
using Hexed.UIApi;

// Token: 0x02000141 RID: 321
internal class Class133
{
	// Token: 0x060006E9 RID: 1769 RVA: 0x000224E0 File Offset: 0x000206E0
	public static void Init()
	{
		Class133.qmmenuPage_0 = new QMMenuPage("Visuals");
		new QMSingleButton(Class127.qmmenuPage_0, 3.5f, 1f, "Visuals", new Action(Class133.qmmenuPage_0.OpenMe), "Visual Options", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Visuals"));
		new QMToggleButton(Class133.qmmenuPage_0, 1f, 0f, "Player \nESP", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "PlayerESP", true);
			Class143.bool_9 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "PlayerESP", false);
			Class143.bool_9 = false;
		}, "Highlight Player Objects", Class141.class6_0.GetBool("Toggles", "PlayerESP", false, false));
		new QMToggleButton(Class133.qmmenuPage_0, 2f, 0f, "Pickup \nESP", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "ItemESP", true);
			Class143.bool_10 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "ItemESP", false);
			Class143.bool_10 = false;
		}, "Highlight pickupable Objects", Class141.class6_0.GetBool("Toggles", "ItemESP", false, false));
		new QMToggleButton(Class133.qmmenuPage_0, 3f, 0f, "Trigger \nESP", delegate()
		{
			Class141.class6_0.SetBool("Toggles", "TriggerESP", true);
			Class143.bool_11 = true;
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "TriggerESP", false);
			Class143.bool_11 = false;
		}, "Highlight triggerable Objects", Class141.class6_0.GetBool("Toggles", "TriggerESP", false, false));
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x0000365D File Offset: 0x0000185D
	internal static bool LArcfI9evYcQ0LxJdL6()
	{
		return Class133.Qj5nFg9JvWZMjVxDg52 == null;
	}

	// Token: 0x040003C9 RID: 969
	private static QMMenuPage qmmenuPage_0;

	// Token: 0x040003CA RID: 970
	private static Class133 Qj5nFg9JvWZMjVxDg52;
}
