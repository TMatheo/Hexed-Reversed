using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Hexed.UIApi;
using Photon.Realtime;
using UnityEngine;
using VRC;

// Token: 0x0200004E RID: 78
internal class Class40 : Interface0, Interface2
{
	// Token: 0x06000258 RID: 600 RVA: 0x00002328 File Offset: 0x00000528
	public void Initialize()
	{
	}

	// Token: 0x06000259 RID: 601 RVA: 0x0000CC48 File Offset: 0x0000AE48
	public void OnUpdate()
	{
		if (Class4.IsInWorld() && MenuHelper.QuickMenu.isActiveAndEnabled)
		{
			if (Class40.uitextMeshText_0 == null)
			{
				Class40.uitextMeshText_0 = new UITextMeshText(MenuHelper.QuickMenu.transform.Find("CanvasGroup/Container/Window/Wing_Left/Button/Icon").gameObject, "Playerlist", new Vector2(-890f, 570f), 29, false, 257);
				Class40.uitextMeshText_0.text.color = Color.gray;
			}
			if (Class40.uitextMeshText_1 == null)
			{
				Class40.uitextMeshText_1 = new UITextMeshText(MenuHelper.QuickMenu.transform.Find("CanvasGroup/Container/Window/Wing_Right/Button/Icon").gameObject, "Hearlist", new Vector2(215f, 570f), 29, false, 257);
				Class40.uitextMeshText_1.text.color = Color.gray;
			}
			List<string> playerStrings = Class40.GetPlayerStrings();
			List<string> hearStrings = Class40.GetHearStrings();
			UITextMeshText uitextMeshText = Class40.uitextMeshText_0;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 5);
			defaultInterpolatedStringHandler.AppendLiteral("In Room: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(playerStrings.Count);
			defaultInterpolatedStringHandler.AppendLiteral(" / ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(RoomManager.Method_Internal_Static_get_ApiWorldInstance_0().capacity);
			defaultInterpolatedStringHandler.AppendLiteral(" | Average (P: ");
			defaultInterpolatedStringHandler.AppendFormatted<short>(Class40.GetAveragePing());
			defaultInterpolatedStringHandler.AppendLiteral(" | F: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(Class40.GetAverageFrames());
			defaultInterpolatedStringHandler.AppendLiteral(")\n");
			defaultInterpolatedStringHandler.AppendFormatted(string.Join("\n", playerStrings));
			uitextMeshText.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
			UITextMeshText uitextMeshText2 = Class40.uitextMeshText_1;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 3);
			defaultInterpolatedStringHandler.AppendLiteral("Hear You: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(hearStrings.Count);
			defaultInterpolatedStringHandler.AppendLiteral(" / ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(playerStrings.Count - 1);
			defaultInterpolatedStringHandler.AppendLiteral("\n");
			defaultInterpolatedStringHandler.AppendFormatted(string.Join("\n", hearStrings));
			uitextMeshText2.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
			return;
		}
	}

	// Token: 0x0600025A RID: 602 RVA: 0x0000CE44 File Offset: 0x0000B044
	private static List<string> GetPlayerStrings()
	{
		IEnumerable<Player> source = from p in Class3.VRCNetworkingClient.GetAllPhotonPlayers()
		orderby p.ActorID()
		select p;
		Func<Player, string> selector;
		if ((selector = Class40.<>O.func_0) == null)
		{
			selector = (Class40.<>O.func_0 = new Func<Player, string>(Class40.GetPlayerString));
		}
		return source.Select(selector).ToList<string>();
	}

	// Token: 0x0600025B RID: 603 RVA: 0x0000CEA4 File Offset: 0x0000B0A4
	private static string GetPlayerString(Player photonPlayer)
	{
		Player player = photonPlayer.GetPlayer();
		if (!(player == null) && player.smethod_0() != null)
		{
			string value = (!Class10.IsFriend(player.UserID())) ? "<color=#7f7f7f>" : "<color=#ebc400>";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 2);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendFormatted<int>(photonPlayer.ActorID());
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			string value2 = defaultInterpolatedStringHandler.ToStringAndClear();
			string value3 = "<color=" + Class11.ColorToHex(Class10.GetPlatformColor(player.GetPhotonPlayer().GetPlatform())) + ">" + ((!player.GetVRCPlayer().smethod_0()) ? player.GetDevice().GetDeviceTag() : "FBT ") + "</color>";
			string blockMuteString = Class40.GetBlockMuteString(photonPlayer.ActorID(), player.UserID());
			string value4 = (!Class10.IsFrozen(photonPlayer.ActorID())) ? "" : "<color=#fc0352>S</color> | ";
			string value5 = (!player.IsInstanceOwner()) ? ((!photonPlayer.IsInstanceModerator()) ? "" : "<color=#3c1769>P</color> | ") : "<color=#3c1769>O</color> | ";
			string value6 = photonPlayer.IsMaster() ? "<color=#8719fc>M</color> | " : "";
			string value7 = "<color=" + Class11.ColorToHex(player.smethod_0().GetRankColor()) + ">" + player.DisplayName() + "</color>";
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(60, 6);
			defaultInterpolatedStringHandler.AppendLiteral("P: <color=");
			defaultInterpolatedStringHandler.AppendFormatted(Class11.ColorToHex(player.GetPingColor()));
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted<short>(player.GetPing());
			defaultInterpolatedStringHandler.AppendLiteral("</color> F: <color=");
			defaultInterpolatedStringHandler.AppendFormatted(Class11.ColorToHex(player.GetFramesColor()));
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted<int>(player.GetFrames());
			defaultInterpolatedStringHandler.AppendLiteral("</color> Q: <color=");
			defaultInterpolatedStringHandler.AppendFormatted(Class11.ColorToHex(player.GetQualityColor()));
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted<int>(player.GetQualityPercentage());
			defaultInterpolatedStringHandler.AppendLiteral("%</color>");
			string value8 = defaultInterpolatedStringHandler.ToStringAndClear();
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 8);
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral(" - ");
			defaultInterpolatedStringHandler.AppendFormatted(value3);
			defaultInterpolatedStringHandler.AppendLiteral(" | ");
			defaultInterpolatedStringHandler.AppendFormatted(blockMuteString);
			defaultInterpolatedStringHandler.AppendFormatted(value4);
			defaultInterpolatedStringHandler.AppendFormatted(value5);
			defaultInterpolatedStringHandler.AppendFormatted(value6);
			defaultInterpolatedStringHandler.AppendFormatted(value7);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted(value8);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return Class40.HandleNullPlayer(photonPlayer);
	}

	// Token: 0x0600025C RID: 604 RVA: 0x0000D16C File Offset: 0x0000B36C
	private static string HandleNullPlayer(Player photonPlayer)
	{
		string text = photonPlayer.UserID();
		string text2 = photonPlayer.DisplayName() ?? "NO NAME";
		string value = (text == null) ? "<color=#7f7f7f>" : (Class10.IsFriend(text) ? "<color=#ebc400>" : "<color=#7f7f7f>");
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 2);
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendFormatted<int>(photonPlayer.ActorID());
		defaultInterpolatedStringHandler.AppendLiteral("</color>");
		string value2 = defaultInterpolatedStringHandler.ToStringAndClear();
		string value3 = "<color=#a33333>BOT</color>";
		string value4 = "<color=" + Class11.ColorToHex(Class10.GetPlatformColor(photonPlayer.GetPlatform())) + photonPlayer.GetDevice().GetDeviceTag() + "</color>";
		string blockMuteString = Class40.GetBlockMuteString(photonPlayer.ActorID(), text);
		string value5 = Class10.IsFrozen(photonPlayer.ActorID()) ? "<color=#fc0352>S</color> | " : "";
		string value6 = photonPlayer.IsInstanceModerator() ? "<color=#3c1769>P</color> | " : "";
		string value7 = photonPlayer.IsMaster() ? "<color=#8719fc>M</color> | " : "";
		"<color=#a33333>" + text2 + "</color>";
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 8);
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		defaultInterpolatedStringHandler.AppendLiteral(" - ");
		defaultInterpolatedStringHandler.AppendFormatted(value3);
		defaultInterpolatedStringHandler.AppendLiteral(" - ");
		defaultInterpolatedStringHandler.AppendFormatted(value4);
		defaultInterpolatedStringHandler.AppendLiteral(" | ");
		defaultInterpolatedStringHandler.AppendFormatted(blockMuteString);
		defaultInterpolatedStringHandler.AppendFormatted(value5);
		defaultInterpolatedStringHandler.AppendFormatted(value6);
		defaultInterpolatedStringHandler.AppendFormatted(value7);
		defaultInterpolatedStringHandler.AppendFormatted(text2);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600025D RID: 605 RVA: 0x0000D308 File Offset: 0x0000B508
	private static string GetBlockMuteString(int actorId, string userId)
	{
		if (Class67.list_0.Contains(actorId))
		{
			return "<color=#ff0000>B</color> | ";
		}
		if (Class67.list_1.Contains(actorId))
		{
			return "<color=#ff0000>M</color> | ";
		}
		if (userId != null && Class3.ModerationManager.IsBlocked(userId))
		{
			return "<color=#424242>B</color> | ";
		}
		if (userId != null && Class3.ModerationManager.IsMuted(userId))
		{
			return "<color=#424242>M</color> | ";
		}
		return "";
	}

	// Token: 0x0600025E RID: 606 RVA: 0x0000D36C File Offset: 0x0000B56C
	private static List<string> GetHearStrings()
	{
		return (from p in Class3.VRCNetworkingClient.GetAllPhotonPlayers()
		where p.GetPlayer() != null && p.GetPlayer().smethod_0() != null && p.CanHearMe()
		select p).Select(delegate(Player p)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 3);
			defaultInterpolatedStringHandler.AppendLiteral("<color=");
			defaultInterpolatedStringHandler.AppendFormatted(Class11.ColorToHex(p.GetPlayer().smethod_0().GetRankColor()));
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted(p.GetPlayer().DisplayName());
			defaultInterpolatedStringHandler.AppendLiteral("</color> (");
			defaultInterpolatedStringHandler.AppendFormatted<int>((int)Vector3.Distance(p.GetPlayer().transform.position, Class3.CurrentPlayer.transform.position));
			defaultInterpolatedStringHandler.AppendLiteral("m)");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}).ToList<string>();
	}

	// Token: 0x0600025F RID: 607 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
	private static short GetAveragePing()
	{
		Player[] allPlayers = Class3.PlayerManager.GetAllPlayers();
		if (!allPlayers.Any<Player>())
		{
			return 0;
		}
		return (short)allPlayers.Average((Player x) => (int)x.GetPing());
	}

	// Token: 0x06000260 RID: 608 RVA: 0x0000D41C File Offset: 0x0000B61C
	private static int GetAverageFrames()
	{
		Player[] allPlayers = Class3.PlayerManager.GetAllPlayers();
		if (!allPlayers.Any<Player>())
		{
			return 0;
		}
		return (int)allPlayers.Average((Player x) => x.GetFrames());
	}

	// Token: 0x06000262 RID: 610 RVA: 0x00002C49 File Offset: 0x00000E49
	internal static bool HlHll7NKjOAGMPoQbPt()
	{
		return Class40.Lp64nyNQYO4uIqFq3Ux == null;
	}

	// Token: 0x0400010B RID: 267
	private static UITextMeshText uitextMeshText_0;

	// Token: 0x0400010C RID: 268
	private static UITextMeshText uitextMeshText_1;

	// Token: 0x0400010D RID: 269
	private static Class40 Lp64nyNQYO4uIqFq3Ux;

	// Token: 0x0200004F RID: 79
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400010E RID: 270
		public static Func<Player, string> func_0;
	}
}
