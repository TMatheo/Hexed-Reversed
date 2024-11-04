using System;
using Hexed.UIApi;
using VRC.Core;

// Token: 0x02000120 RID: 288
internal class Class121
{
	// Token: 0x060005D8 RID: 1496 RVA: 0x0001DD30 File Offset: 0x0001BF30
	public static void Init()
	{
		Class121.qmmenuPage_0 = new QMMenuPage("Player Exploits");
		new QMSingleButton(Class122.qmmenuPage_0, 3f, 0f, "Exploits", new Action(Class121.qmmenuPage_0.OpenMe), "Exploit Options", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Exploits"));
		new QMToggleButton(Class121.qmmenuPage_0, 1f, 0f, "Voice \nRepeat", delegate()
		{
			Class143.int_1 = Class9.GetSelectedPlayer().GetPhotonPlayer().ActorID();
		}, delegate()
		{
			Class143.int_1 = -2;
		}, "Repeat the Players Voice Events", false);
		new QMToggleButton(Class121.qmmenuPage_0, 2f, 0f, "Chat \nRepeat", delegate()
		{
			Class143.int_2 = Class9.GetSelectedPlayer().GetPhotonPlayer().ActorID();
		}, delegate()
		{
			Class143.int_2 = -1;
		}, "Repeat the Players Chat Events", false);
		new QMSingleButton(Class121.qmmenuPage_0, 3f, 0f, "Teleport \nItems", delegate()
		{
			Class116.ItemsToPlayer(Class9.GetSelectedPlayer());
		}, "Teleport all Items to the Player", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class121.qmmenuPage_0, 3f, 0.5f, "Crash \nPortal", delegate()
		{
			ApiWorldInstance apiWorldInstance = new ApiWorldInstance();
			apiWorldInstance.id = "wrld_5b89c79e-c340-4510-be1b-476e9fcdedcc:" + Class109.RandomStringNumber(5);
			apiWorldInstance.Fetch(delegate(ApiContainer container)
			{
				new ApiModelContainer<ApiWorldInstance>().setFromContainer(container);
				ApiWorldInstance apiWorldInstance2 = container.Model.Cast<ApiWorldInstance>();
				if (apiWorldInstance2 != null)
				{
					Class117.RaisePortalCreate(apiWorldInstance2.shortName, Class9.GetSelectedPlayer().transform.position, -1f);
				}
			}, null, null, false, 2);
		}, "Drop a Portal in the Player", ButtonAPI.ButtonSize.Half, null);
		new QMToggleButton(Class121.qmmenuPage_0, 4f, 0f, "Portal \nKOS", delegate()
		{
			Class49.smethod_0(Class9.GetSelectedPlayer()).Start();
		}, delegate()
		{
			Class49.bool_1 = false;
		}, "Drop Portals in the Player", false);
		new QMToggleButton(Class121.qmmenuPage_0, 1f, 1f, "Udon \nDesync", delegate()
		{
			Class49.UdonSpam(Class9.GetSelectedPlayer()).Start();
		}, delegate()
		{
			Class49.bool_5 = false;
		}, "Desync the player using Udon", false);
		new QMToggleButton(Class121.qmmenuPage_0, 2f, 1f, "Camera \nSounds", delegate()
		{
			Class49.CameraSounds(Class9.GetSelectedPlayer()).Start();
		}, delegate()
		{
			Class49.bool_6 = false;
		}, "Spawn Camera sounds in the Player", false);
		new QMToggleButton(Class121.qmmenuPage_0, 3f, 1f, "Collapse", delegate()
		{
			Class49.Collapse(Class9.GetSelectedPlayer()).Start();
		}, delegate()
		{
			Class49.bool_7 = false;
		}, "Collapse the Player with Items", false);
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x000033D0 File Offset: 0x000015D0
	internal static bool m7aMlTIL0Xp3Uq8bns9()
	{
		return Class121.ulTeZCIs2pVh1JO1FtB == null;
	}

	// Token: 0x040002C5 RID: 709
	private static QMMenuPage qmmenuPage_0;

	// Token: 0x040002C6 RID: 710
	internal static Class121 ulTeZCIs2pVh1JO1FtB;
}
