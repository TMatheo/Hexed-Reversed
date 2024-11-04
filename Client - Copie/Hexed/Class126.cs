using System;
using Hexed.UIApi;
using VRC.Core;

// Token: 0x0200012D RID: 301
internal class Class126
{
	// Token: 0x06000633 RID: 1587 RVA: 0x0001F0C8 File Offset: 0x0001D2C8
	public static void Init()
	{
		Class126.qmmenuPage_0 = new QMMenuPage("Exploits");
		new QMSingleButton(Class127.qmmenuPage_0, 1.5f, 1f, "Exploits", new Action(Class126.qmmenuPage_0.OpenMe), "Exploit Options", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Exploits"));
		new QMToggleButton(Class126.qmmenuPage_0, 1f, 0f, "Infinity \nPosition", delegate()
		{
			Class143.bool_36 = true;
		}, delegate()
		{
			Class143.bool_36 = false;
		}, "Teleport your Player to Infinity", false);
		new QMToggleButton(Class126.qmmenuPage_0, 2f, 0f, "Big \nAvatar", delegate()
		{
			Class143.bool_38 = true;
			APIUser.CurrentUser.ReloadAvatar();
		}, delegate()
		{
			Class143.bool_38 = false;
			APIUser.CurrentUser.ReloadAvatar();
		}, "Scale your Avatar to the maximum", false);
		new QMToggleButton(Class126.qmmenuPage_0, 3f, 0f, "Always \nTyping", delegate()
		{
			Class49.AlwaysTyping().Start();
		}, delegate()
		{
			Class49.bool_4 = false;
		}, "Always send a typing Indicator", false);
		new QMToggleButton(Class126.qmmenuPage_0, 4f, 0f, "Loud \nMic", delegate()
		{
			USpeaker.field_Internal_Static_Single_1 = float.MaxValue;
		}, delegate()
		{
			USpeaker.field_Internal_Static_Single_1 = 1f;
		}, "Everyone hears you very Loud", false);
		QMSelectButton qmselectButton = new QMSelectButton(Class126.qmmenuPage_0, 1f, 1f, "Custom \nChatbox", "Send custom Chatbox messages", Class143.chatboxMode_0, 0);
		qmselectButton.AddAction(0, delegate
		{
			Class49.bool_2 = false;
			Class49.bool_3 = false;
		});
		qmselectButton.AddAction(1, delegate
		{
			Class49.bool_2 = false;
			Class49.bool_3 = false;
			Class3.VRCUiPopupManager.AskInGameInput("Custom Text", "Ok", delegate(string text)
			{
				Class49.StaticChatbox(text).Start();
			}, null);
		});
		qmselectButton.AddAction(2, delegate
		{
			Class49.bool_2 = false;
			Class49.bool_3 = false;
			Class49.SpotifyChatbox().Start();
		});
		new QMToggleButton(Class126.qmmenuPage_0, 2f, 1f, "Voice \nDistortion", delegate()
		{
			Class49.VoiceDistortion().Start();
		}, delegate()
		{
			Class49.bool_0 = false;
		}, "Earrape the Room with USpeak", false);
		new QMSingleButton(Class126.qmmenuPage_0, 3f, 1f, "Infinity \nPortal", delegate()
		{
			ApiWorldInstance apiWorldInstance = new ApiWorldInstance();
			apiWorldInstance.id = "wrld_5b89c79e-c340-4510-be1b-476e9fcdedcc:" + Class109.RandomStringNumber(5);
			apiWorldInstance.Fetch(delegate(ApiContainer container)
			{
				new ApiModelContainer<ApiWorldInstance>().setFromContainer(container);
				ApiWorldInstance apiWorldInstance2 = container.Model.Cast<ApiWorldInstance>();
				if (apiWorldInstance2 != null)
				{
					Class117.RaisePortalCreate(apiWorldInstance2.shortName, Class11.Struct0.Vector3_0, -1f);
				}
			}, null, null, false, 2);
		}, "Spawn a Portal at Infinity", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class126.qmmenuPage_0, 3f, 1.5f, "Unicode \nChat", delegate()
		{
			Class117.RaiseChatMessage("\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v\v");
		}, "Send a Unicode Chatbox Message", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class126.qmmenuPage_0, 4f, 1f, "Custom \nEmoji", delegate()
		{
			Class3.VRCUiPopupManager.AskInGameInput("File ID", "Ok", delegate(string text)
			{
				Class117.RaiseEmojiCreate(text);
			}, "file_");
		}, "Spawn a custom Emoji", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class126.qmmenuPage_0, 4f, 1.5f, "Infinity \nItems", delegate()
		{
			Class116.ItemsToPosition(Class11.Struct0.Vector3_0);
		}, "Teleport Items to Infinity", ButtonAPI.ButtonSize.Half, null);
		new QMToggleButton(Class126.qmmenuPage_0, 1f, 2f, "Memory \nOverflow", delegate()
		{
			Class49.MemoryViolation().Start();
		}, delegate()
		{
			Class49.bool_8 = false;
		}, "Override Events with Memory Crashers", false);
		QMSelectButton qmselectButton2 = new QMSelectButton(Class126.qmmenuPage_0, 2f, 2f, "Anti \nPickup", "Prevent Players from using Pickups", Class143.antiPickupMode_0, Class141.class6_0.GetInt("Toggles", "AntiPickupMode", 0, false));
		qmselectButton2.AddAction(0, delegate
		{
			Class141.class6_0.SetInt("Toggles", "AntiPickupMode", 0);
			Class143.antiPickupMode_0 = Class143.AntiPickupMode.None;
		});
		qmselectButton2.AddAction(1, delegate
		{
			Class141.class6_0.SetInt("Toggles", "AntiPickupMode", 1);
			Class143.antiPickupMode_0 = Class143.AntiPickupMode.Self;
		});
		qmselectButton2.AddAction(2, delegate
		{
			Class141.class6_0.SetInt("Toggles", "AntiPickupMode", 2);
			Class143.antiPickupMode_0 = Class143.AntiPickupMode.Nobody;
		});
		QMSelectButton qmselectButton3 = new QMSelectButton(Class126.qmmenuPage_0, 3f, 2f, "Custom \nInterest", "Receive Player events regardless of their State", Class143.interestMode_0, Class141.class6_0.GetInt("Toggles", "CustomInterestMode", 0, false));
		qmselectButton3.AddAction(0, delegate
		{
			Class141.class6_0.SetInt("Toggles", "CustomInterestMode", 0);
			Class143.interestMode_0 = Class143.InterestMode.None;
		});
		qmselectButton3.AddAction(1, delegate
		{
			Class141.class6_0.SetInt("Toggles", "CustomInterestMode", 1);
			Class143.interestMode_0 = Class143.InterestMode.Reversed;
		});
		qmselectButton3.AddAction(2, delegate
		{
			Class141.class6_0.SetInt("Toggles", "CustomInterestMode", 2);
			Class143.interestMode_0 = Class143.InterestMode.All;
		});
		new QMToggleButton(Class126.qmmenuPage_0, 4f, 2f, "Invisible \nConnect", delegate()
		{
			Class143.bool_39 = true;
		}, delegate()
		{
			Class143.bool_39 = false;
		}, "Connect to a Room without appearing", false);
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x00003521 File Offset: 0x00001721
	internal static bool EwWvcvIapLZC6FELpwH()
	{
		return Class126.xmwdhtIn4EVNl5Wj5VD == null;
	}

	// Token: 0x0400031B RID: 795
	private static QMMenuPage qmmenuPage_0;

	// Token: 0x0400031C RID: 796
	private static Class126 xmwdhtIn4EVNl5Wj5VD;
}
