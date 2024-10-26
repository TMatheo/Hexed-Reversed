using System;
using Hexed.UIApi;

// Token: 0x0200012B RID: 299
internal class Class125
{
	// Token: 0x0600061D RID: 1565 RVA: 0x0001ED68 File Offset: 0x0001CF68
	public static void Init()
	{
		Class125.qmmenuPage_0 = new QMMenuPage("Debug");
		new QMSingleButton(Class127.qmmenuPage_0, 2.5f, 1f, "Debug", new Action(Class125.qmmenuPage_0.OpenMe), "Debug Options", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Debug"));
		new QMToggleButton(Class125.qmmenuPage_0, 1f, 0f, "OpRaise \nLog", delegate()
		{
			Class143.bool_1 = true;
		}, delegate()
		{
			Class143.bool_1 = false;
		}, "Log OpRaise Events", false);
		new QMToggleButton(Class125.qmmenuPage_0, 2f, 0f, "OnEvent \nLog", delegate()
		{
			Class143.bool_0 = true;
		}, delegate()
		{
			Class143.bool_0 = false;
		}, "Log Events", false);
		new QMToggleButton(Class125.qmmenuPage_0, 3f, 0f, "Operation \nLog", delegate()
		{
			Class143.bool_3 = true;
		}, delegate()
		{
			Class143.bool_3 = false;
		}, "Log Operations", false);
		new QMToggleButton(Class125.qmmenuPage_0, 4f, 0f, "RPC \nLog", delegate()
		{
			Class143.bool_2 = true;
		}, delegate()
		{
			Class143.bool_2 = false;
		}, "Log RPCs", false);
		new QMToggleButton(Class125.qmmenuPage_0, 1f, 1f, "API \nLog", delegate()
		{
			Class143.bool_5 = true;
		}, delegate()
		{
			Class143.bool_5 = false;
		}, "Log API requests", false);
		new QMToggleButton(Class125.qmmenuPage_0, 2f, 1f, "Socket \nLog", delegate()
		{
			Class143.bool_6 = true;
		}, delegate()
		{
			Class143.bool_6 = false;
		}, "Log Socket notifications", false);
		new QMToggleButton(Class125.qmmenuPage_0, 3f, 1f, "Show \nPerformance", delegate()
		{
			Class143.bool_35 = true;
		}, delegate()
		{
			Class143.bool_35 = false;
		}, "Show Avatar Performance", false);
		new QMToggleButton(Class125.qmmenuPage_0, 4f, 1f, "OP Response \nLog", delegate()
		{
			Class143.bool_4 = true;
		}, delegate()
		{
			Class143.bool_4 = false;
		}, "Log Operation Responses", false);
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x0000348D File Offset: 0x0000168D
	internal static bool dZMSaOISVTKnubFt2kO()
	{
		return Class125.GyrIoBI0Qqan3vIpk3q == null;
	}

	// Token: 0x04000307 RID: 775
	private static QMMenuPage qmmenuPage_0;

	// Token: 0x04000308 RID: 776
	internal static Class125 GyrIoBI0Qqan3vIpk3q;
}
