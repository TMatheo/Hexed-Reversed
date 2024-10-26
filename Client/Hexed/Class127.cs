using System;
using Hexed.UIApi;

// Token: 0x0200012F RID: 303
internal class Class127
{
	// Token: 0x06000657 RID: 1623 RVA: 0x0001F9C0 File Offset: 0x0001DBC0
	public static void Init()
	{
		Class127.qmmenuPage_0 = new QMMenuPage("Hexed");
		new QMIconButton(MenuHelper.menuPageTemplate.transform, 0.75f, -0.8f, new Action(Class127.qmmenuPage_0.OpenMe), "Hexed Client", Class11.GetSprite("moon"));
		new QMIconButton(Class127.qmmenuPage_0, 1.5f, 3.25f, delegate()
		{
			Class7.keybd_event(177, 0, 1U, IntPtr.Zero);
		}, "Previous Media", Class11.GetSprite("MediaPrevious"));
		new QMIconButton(Class127.qmmenuPage_0, 2f, 3.25f, delegate()
		{
			Class7.keybd_event(174, 0, 1U, IntPtr.Zero);
		}, "Volume Down Media", Class11.GetSprite("MediaDown"));
		new QMIconButton(Class127.qmmenuPage_0, 2.5f, 3.25f, delegate()
		{
			Class7.keybd_event(179, 0, 1U, IntPtr.Zero);
		}, "Play / Pause Media", Class11.GetSprite("MediaPlay"));
		new QMIconButton(Class127.qmmenuPage_0, 3f, 3.25f, delegate()
		{
			Class7.keybd_event(175, 0, 1U, IntPtr.Zero);
		}, "Volume Up Media", Class11.GetSprite("MediaUp"));
		new QMIconButton(Class127.qmmenuPage_0, 3.5f, 3.25f, delegate()
		{
			Class7.keybd_event(176, 0, 1U, IntPtr.Zero);
		}, "Next Media", Class11.GetSprite("MediaNext"));
		Class129.Init();
		Class132.Init();
		Class128.Init();
		Class124.Init();
		Class126.Init();
		Class125.Init();
		Class133.Init();
		Class130.Init();
		Class131.Init();
		Class122.Init();
		Class140.Init();
		Class138.Init();
		Class139.Init();
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x000035A5 File Offset: 0x000017A5
	internal static bool d8rTbgI9Wxo85dQ6CIp()
	{
		return Class127.ANvliPIIvOYjxWEC90H == null;
	}

	// Token: 0x0400033D RID: 829
	public static QMMenuPage qmmenuPage_0;

	// Token: 0x0400033E RID: 830
	private static Class127 ANvliPIIvOYjxWEC90H;
}
