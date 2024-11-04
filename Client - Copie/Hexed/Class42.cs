using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using VRC.UI.Elements.Controls;

// Token: 0x02000052 RID: 82
internal class Class42 : Interface0, Interface4
{
	// Token: 0x06000271 RID: 625 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
	public void Initialize(VRCPlayer player)
	{
		this.vrcplayer_0 = player;
	}

	// Token: 0x06000272 RID: 626 RVA: 0x0000DDE4 File Offset: 0x0000BFE4
	public void OnUpdate()
	{
		if (this.vrcplayer_0 == null)
		{
			return;
		}
		PlayerNameplate field_Public_PlayerNameplate_ = this.vrcplayer_0.field_Public_PlayerNameplate_0;
		if (field_Public_PlayerNameplate_ == null)
		{
			return;
		}
		PlayerNameplate nameplate = field_Public_PlayerNameplate_;
		Vector3 position = new Vector3(0f, 42f, 0f);
		string identifier = "State";
		Color white = Color.white;
		string[] array = new string[5];
		array[0] = (this.vrcplayer_0.IsInstanceOwner() ? "<color=#7b00ff>O</color> " : (this.vrcplayer_0.GetPhotonPlayer().IsInstanceModerator() ? "<color=#3c1769>P</color> " : ""));
		array[1] = (this.vrcplayer_0.GetPhotonPlayer().IsMaster() ? "<color=#8719fc>M</color> " : "");
		array[2] = ((!Class67.list_0.Contains(this.vrcplayer_0.GetPhotonPlayer().ActorID())) ? (Class67.list_1.Contains(this.vrcplayer_0.GetPhotonPlayer().ActorID()) ? "<color=#ff0000>M</color> " : "") : "<color=#ff0000>B</color> ");
		array[3] = (Class3.ModerationManager.IsBlocked(this.vrcplayer_0.UserID()) ? "<color=#424242>B</color> " : ((!Class3.ModerationManager.IsMuted(this.vrcplayer_0.UserID())) ? "" : "<color=#424242>M</color> "));
		int num = 4;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
		defaultInterpolatedStringHandler.AppendLiteral("<color=");
		defaultInterpolatedStringHandler.AppendFormatted(Class11.ColorToHex(Class10.GetPlatformColor(this.vrcplayer_0.GetPhotonPlayer().GetPlatform())));
		defaultInterpolatedStringHandler.AppendLiteral(">");
		defaultInterpolatedStringHandler.AppendFormatted(this.vrcplayer_0.smethod_0() ? "FBT" : this.vrcplayer_0.GetDevice().GetDeviceTag());
		defaultInterpolatedStringHandler.AppendLiteral("</color> ");
		array[num] = defaultInterpolatedStringHandler.ToStringAndClear();
		Class42.SetTag(nameplate, position, identifier, white, string.Concat(array));
		PlayerNameplate nameplate2 = field_Public_PlayerNameplate_;
		Vector3 position2 = new Vector3(0f, -42f, 0f);
		string identifier2 = "Network";
		Color white2 = Color.white;
		string[] array2 = new string[3];
		int num2 = 0;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
		defaultInterpolatedStringHandler.AppendLiteral("P: <color=");
		defaultInterpolatedStringHandler.AppendFormatted(Class11.ColorToHex(this.vrcplayer_0.GetPingColor()));
		defaultInterpolatedStringHandler.AppendLiteral(">");
		defaultInterpolatedStringHandler.AppendFormatted<short>(this.vrcplayer_0.GetPing());
		defaultInterpolatedStringHandler.AppendLiteral("</color> ");
		array2[num2] = defaultInterpolatedStringHandler.ToStringAndClear();
		int num3 = 1;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
		defaultInterpolatedStringHandler.AppendLiteral("F: <color=");
		defaultInterpolatedStringHandler.AppendFormatted(Class11.ColorToHex(this.vrcplayer_0.GetFramesColor()));
		defaultInterpolatedStringHandler.AppendLiteral(">");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.vrcplayer_0.GetFrames());
		defaultInterpolatedStringHandler.AppendLiteral("</color> ");
		array2[num3] = defaultInterpolatedStringHandler.ToStringAndClear();
		int num4 = 2;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
		defaultInterpolatedStringHandler.AppendLiteral("Q: <color=");
		defaultInterpolatedStringHandler.AppendFormatted(Class11.ColorToHex(this.vrcplayer_0.GetQualityColor()));
		defaultInterpolatedStringHandler.AppendLiteral(">");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.vrcplayer_0.GetQualityPercentage());
		defaultInterpolatedStringHandler.AppendLiteral("%</color> ");
		array2[num4] = defaultInterpolatedStringHandler.ToStringAndClear();
		Class42.SetTag(nameplate2, position2, identifier2, white2, string.Concat(array2));
		Class42.SetTag(field_Public_PlayerNameplate_, new Vector3(0f, -66f, 0f), "Pose", Color.white, string.Concat(new string[]
		{
			this.vrcplayer_0.smethod_1() ? "<color=#ff03e2>AFK</color>\n" : "",
			(!this.vrcplayer_0.IsPlayerMicDisabled()) ? "" : "<color=#2fc47c>MUTED</color>\n",
			this.vrcplayer_0.IsPlayerSeated() ? "<color=#ebe831>SEATED</color>\n" : "",
			Class10.IsFrozen(this.vrcplayer_0.GetPhotonPlayer().ActorID()) ? "<color=#fc0352>FROZEN</color>\n" : ""
		}));
	}

	// Token: 0x06000273 RID: 627 RVA: 0x0000E1B4 File Offset: 0x0000C3B4
	private static TextMeshProUGUI SetTag(PlayerNameplate nameplate, Vector3 position, string identifier, Color color, string content)
	{
		GameObject gameObject = (nameplate == null) ? null : nameplate.field_Public_GameObject_0;
		if (gameObject == null)
		{
			return null;
		}
		Transform transform = gameObject.transform.Find("HexedTag-" + identifier);
		if (transform == null)
		{
			transform = Class42.MakeTag(nameplate, identifier);
		}
		TextMeshProUGUI component = transform.GetComponent<TextMeshProUGUI>();
		if (!(component == null))
		{
			component.color = color;
			component.text = content;
			component.richText = true;
			transform.localPosition = position;
			return component;
		}
		return null;
	}

	// Token: 0x06000274 RID: 628 RVA: 0x0000E240 File Offset: 0x0000C440
	private static Transform MakeTag(PlayerNameplate nameplate, string identifier)
	{
		GameObject gameObject = (nameplate == null) ? null : nameplate.field_Public_GameObject_0;
		if (gameObject == null)
		{
			return null;
		}
		Transform transform;
		if (nameplate != null)
		{
			TextMeshProUGUIEx field_Public_TextMeshProUGUIEx_ = nameplate.field_Public_TextMeshProUGUIEx_4;
			transform = ((field_Public_TextMeshProUGUIEx_ == null) ? null : field_Public_TextMeshProUGUIEx_.transform);
		}
		else
		{
			transform = null;
		}
		Transform transform2 = transform;
		if (transform2 == null)
		{
			return null;
		}
		Transform transform3 = Object.Instantiate<Transform>(transform2, gameObject.transform);
		if (transform3 == null)
		{
			return null;
		}
		transform3.name = "HexedTag-" + identifier;
		transform3.gameObject.SetActive(true);
		return transform3;
	}

	// Token: 0x06000276 RID: 630 RVA: 0x00002C7F File Offset: 0x00000E7F
	internal static bool BCyMZBNn6IYqpaf8D9U()
	{
		return Class42.rYYgIjNNZDDr9JX5TnJ == null;
	}

	// Token: 0x04000118 RID: 280
	private VRCPlayer vrcplayer_0;

	// Token: 0x04000119 RID: 281
	internal static Class42 rYYgIjNNZDDr9JX5TnJ;
}
