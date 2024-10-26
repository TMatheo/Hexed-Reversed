using System;
using Hexed.UIApi;
using VRC.Core;

// Token: 0x0200011B RID: 283
internal class Class119
{
	// Token: 0x060005B0 RID: 1456 RVA: 0x0001D2DC File Offset: 0x0001B4DC
	public static void Init()
	{
		Class119.MddoqFdApl = new QMMenuPage("Player Avatar");
		new QMSingleButton(Class122.qmmenuPage_0, 2f, 0f, "Avatar", new Action(Class119.MddoqFdApl.OpenMe), "Avatar Options", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Avatar"));
		new QMSingleButton(Class119.MddoqFdApl, 1f, 0f, "Reload \nAvatar", delegate()
		{
			Class9.GetSelectedPlayer().smethod_0().ReloadAvatar();
		}, "Reload the Avatar", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class119.MddoqFdApl, 1f, 0.5f, "Force \nClone", delegate()
		{
			ApiAvatar avatar = Class9.GetSelectedPlayer().GetAvatar();
			if (avatar.releaseStatus == "public" || avatar.releaseStatus == "hidden")
			{
				Class10.ChangeAvatar(avatar.id);
			}
		}, "Clone the Main Avatar", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class119.MddoqFdApl, 2f, 0f, "Dump \nMain", delegate()
		{
			Class9.GetSelectedPlayer().GetAvatar();
		}, "Dump the Main Avatar file", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class119.MddoqFdApl, 2f, 0.5f, "Dump \nFallback", delegate()
		{
			Class9.GetSelectedPlayer().GetFallbackAvatar();
		}, "Dump the Fallback Avatar file", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class119.MddoqFdApl, 3f, 0f, "Copy Main \nAssetURL", delegate()
		{
			Class5.CopyToClipboard(Class9.GetSelectedPlayer().GetAvatar().assetUrl);
		}, "Copy the Main Asset URL", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class119.MddoqFdApl, 3f, 0.5f, "Copy Fallback \nAssetURL", delegate()
		{
			Class5.CopyToClipboard(Class9.GetSelectedPlayer().GetFallbackAvatar().assetUrl);
		}, "Copy the Fallback Asset URL", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class119.MddoqFdApl, 4f, 0f, "Copy Main \nAvatarID", delegate()
		{
			Class5.CopyToClipboard(Class9.GetSelectedPlayer().GetAvatar().id);
		}, "Copy the Main AvatarID", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class119.MddoqFdApl, 4f, 0.5f, "Copy Fallback \nAvatarID", delegate()
		{
			Class5.CopyToClipboard(Class9.GetSelectedPlayer().GetFallbackAvatar().id);
		}, "Copy the Main AvatarID", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class119.MddoqFdApl, 1f, 1f, "Copy Main \nImageURL", delegate()
		{
			Class5.CopyToClipboard(Class9.GetSelectedPlayer().GetAvatar().imageUrl);
		}, "Copy the Main Image URL", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class119.MddoqFdApl, 1f, 1.5f, "Copy Fallback \nImageURL", delegate()
		{
			Class5.CopyToClipboard(Class9.GetSelectedPlayer().GetFallbackAvatar().imageUrl);
		}, "Copy the Fallback Image URL", ButtonAPI.ButtonSize.Half, null);
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x0000337B File Offset: 0x0000157B
	internal static bool W4usXoI7iXmy0yoWb1c()
	{
		return Class119.K81453IjjPtcApMcObO == null;
	}

	// Token: 0x040002A0 RID: 672
	private static QMMenuPage MddoqFdApl;

	// Token: 0x040002A1 RID: 673
	private static Class119 K81453IjjPtcApMcObO;
}
