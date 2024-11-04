using System;
using Hexed.UIApi;

// Token: 0x02000136 RID: 310
internal class Class130
{
	// Token: 0x06000699 RID: 1689 RVA: 0x00020EB0 File Offset: 0x0001F0B0
	public static void Init()
	{
		Class130.qmmenuPage_0 = new QMMenuPage("Spoof");
		new QMSingleButton(Class127.qmmenuPage_0, 2f, 2f, "Spoof", new Action(Class130.qmmenuPage_0.OpenMe), "Spoof Options", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Spoof"));
		QMSelectButton qmselectButton = new QMSelectButton(Class130.qmmenuPage_0, 1f, 0f, "Udon \nSpoof", "Spoof your Udon name", Class143.udonSpoofMode_0, Class141.class6_0.GetInt("Toggles", "UdonSpoofMode", 0, false));
		qmselectButton.AddAction(0, delegate
		{
			Class141.class6_0.SetInt("Toggles", "UdonSpoofMode", 0);
			Class143.udonSpoofMode_0 = Class143.UdonSpoofMode.None;
		});
		qmselectButton.AddAction(1, delegate
		{
			Class141.class6_0.SetInt("Toggles", "UdonSpoofMode", 1);
			Class143.udonSpoofMode_0 = Class143.UdonSpoofMode.Owner;
		});
		qmselectButton.AddAction(2, delegate
		{
			Class141.class6_0.SetInt("Toggles", "UdonSpoofMode", 2);
			Class143.udonSpoofMode_0 = Class143.UdonSpoofMode.Random;
		});
		qmselectButton.AddAction(3, delegate
		{
			Class141.class6_0.SetInt("Toggles", "UdonSpoofMode", 3);
			Class143.udonSpoofMode_0 = Class143.UdonSpoofMode.Custom;
			Class3.VRCUiPopupManager.AskInGameInput("Fake Name", "Ok", delegate(string text)
			{
				Class143.string_0 = text;
				Class141.class6_0.SetString("Toggles", "FakeUdonValue", Class143.string_0);
			}, "Name");
		});
		new QMToggleButton(Class130.qmmenuPage_0, 2f, 0f, "Group \nSpoof", delegate()
		{
			Class3.VRCUiPopupManager.AskInGameInput("Custom Text", "Ok", delegate(string text)
			{
				Class143.string_1 = text;
				Class141.class6_0.SetString("Toggles", "FakeGroupValue", Class143.string_1);
				Class141.class6_0.SetBool("Toggles", "GroupSpoof", true);
				Class143.bool_32 = true;
				Class117.RaiseGroupOnNameplate(Class143.string_1);
			}, null);
		}, delegate()
		{
			Class141.class6_0.SetBool("Toggles", "GroupSpoof", false);
			Class143.bool_32 = false;
		}, "Spoof your represented Group", Class141.class6_0.GetBool("Toggles", "GroupSpoof", false, false));
		QMSelectButton qmselectButton2 = new QMSelectButton(Class130.qmmenuPage_0, 3f, 0f, "VR \nSpoof", "Spoof your VR state", Class143.vrmode_0, Class141.class6_0.GetInt("Toggles", "VRMode", 0, false));
		qmselectButton2.AddAction(0, delegate
		{
			Class141.class6_0.SetInt("Toggles", "VRMode", 0);
			Class143.vrmode_0 = Class143.VRMode.None;
			Class117.smethod_1(Class4.IsInVr());
		});
		qmselectButton2.AddAction(1, delegate
		{
			Class141.class6_0.SetInt("Toggles", "VRMode", 1);
			Class143.vrmode_0 = Class143.VRMode.VR;
			Class117.smethod_1(true);
		});
		qmselectButton2.AddAction(2, delegate
		{
			Class141.class6_0.SetInt("Toggles", "VRMode", 2);
			Class143.vrmode_0 = Class143.VRMode.Desktop;
			Class117.smethod_1(false);
		});
		QMSelectButton qmselectButton3 = new QMSelectButton(Class130.qmmenuPage_0, 4f, 0f, "Latency \nSpoof", "Spoof your Latency", Class143.latencyMode_0, Class141.class6_0.GetInt("Toggles", "FakeLatencyMode", 0, false));
		qmselectButton3.AddAction(0, delegate
		{
			Class141.class6_0.SetInt("Toggles", "FakeLatencyMode", 0);
			Class143.latencyMode_0 = Class143.LatencyMode.None;
		});
		qmselectButton3.AddAction(1, delegate
		{
			Class141.class6_0.SetInt("Toggles", "FakeLatencyMode", 1);
			Class143.latencyMode_0 = Class143.LatencyMode.Custom;
			Class3.VRCUiPopupManager.AskInGameInput("Latency Value", "Ok", delegate(string text)
			{
				Class143.byte_0 = Convert.ToByte(text);
				Class141.class6_0.SetInt("Toggles", "FakeLatencyValue", (int)Class143.byte_0);
			}, "0 - 255");
		});
		qmselectButton3.AddAction(2, delegate
		{
			Class141.class6_0.SetInt("Toggles", "FakeLatencyMode", 2);
			Class143.latencyMode_0 = Class143.LatencyMode.Low;
		});
		qmselectButton3.AddAction(3, delegate
		{
			Class141.class6_0.SetInt("Toggles", "FakeLatencyMode", 3);
			Class143.latencyMode_0 = Class143.LatencyMode.High;
		});
		QMSelectButton qmselectButton4 = new QMSelectButton(Class130.qmmenuPage_0, 1f, 1f, "Ping \nSpoof", "Spoof your Ping", Class143.frameAndPingMode_1, Class141.class6_0.GetInt("Toggles", "FakePingMode", 0, false));
		qmselectButton4.AddAction(0, delegate
		{
			Class141.class6_0.SetInt("Toggles", "FakePingMode", 0);
			Class143.frameAndPingMode_1 = Class143.FrameAndPingMode.None;
		});
		qmselectButton4.AddAction(1, delegate
		{
			Class141.class6_0.SetInt("Toggles", "FakePingMode", 1);
			Class143.frameAndPingMode_1 = Class143.FrameAndPingMode.Custom;
			Class3.VRCUiPopupManager.AskInGameInput("Ping Value", "Ok", delegate(string text)
			{
				Class143.short_0 = Convert.ToInt16(text);
				Class141.class6_0.SetInt("Toggles", "FakePingValue", (int)Class143.short_0);
			}, "-32767 - 32767");
		});
		qmselectButton4.AddAction(2, delegate
		{
			Class141.class6_0.SetInt("Toggles", "FakePingMode", 2);
			Class143.frameAndPingMode_1 = Class143.FrameAndPingMode.Realistic;
		});
		QMSelectButton qmselectButton5 = new QMSelectButton(Class130.qmmenuPage_0, 2f, 1f, "Frame \nSpoof", "Spoof your Frames", Class143.frameAndPingMode_0, Class141.class6_0.GetInt("Toggles", "FakeFrameMode", 0, false));
		qmselectButton5.AddAction(0, delegate
		{
			Class141.class6_0.SetInt("Toggles", "FakeFrameMode", 0);
			Class143.frameAndPingMode_0 = Class143.FrameAndPingMode.None;
		});
		qmselectButton5.AddAction(1, delegate
		{
			Class141.class6_0.SetInt("Toggles", "FakeFrameMode", 1);
			Class143.frameAndPingMode_0 = Class143.FrameAndPingMode.Custom;
			Class3.VRCUiPopupManager.AskInGameInput("Frame Value", "Ok", delegate(string text)
			{
				Class143.int_0 = Convert.ToInt32(text);
				Class141.class6_0.SetInt("Toggles", "FakeFrameValue", Class143.int_0);
			}, "0 - 1000");
		});
		qmselectButton5.AddAction(2, delegate
		{
			Class141.class6_0.SetInt("Toggles", "FakeFrameMode", 2);
			Class143.frameAndPingMode_0 = Class143.FrameAndPingMode.Realistic;
		});
		QMSelectButton qmselectButton6 = new QMSelectButton(Class130.qmmenuPage_0, 3f, 1f, "Mic \nSpoof", "Spoof your Mic state", Class143.micStateMode_0, Class141.class6_0.GetInt("Toggles", "FakeMicMode", 0, false));
		qmselectButton6.AddAction(0, delegate
		{
			Class141.class6_0.SetInt("Toggles", "FakeMicMode", 0);
			Class143.micStateMode_0 = Class143.MicStateMode.None;
		});
		qmselectButton6.AddAction(1, delegate
		{
			Class141.class6_0.SetInt("Toggles", "FakeMicMode", 1);
			Class143.micStateMode_0 = Class143.MicStateMode.Muted;
		});
		qmselectButton6.AddAction(2, delegate
		{
			Class141.class6_0.SetInt("Toggles", "FakeMicMode", 2);
			Class143.micStateMode_0 = Class143.MicStateMode.Unmuted;
		});
		QMSelectButton qmselectButton7 = new QMSelectButton(Class130.qmmenuPage_0, 4f, 1f, "Earmuff \nSpoof", "Spoof your Earmuff state", Class143.earmuffStateMode_0, Class141.class6_0.GetInt("Toggles", "FakeEarmuffMode", 0, false));
		qmselectButton7.AddAction(0, delegate
		{
			Class141.class6_0.SetInt("Toggles", "FakeEarmuffMode", 0);
			Class143.earmuffStateMode_0 = Class143.EarmuffStateMode.None;
		});
		qmselectButton7.AddAction(1, delegate
		{
			Class141.class6_0.SetInt("Toggles", "FakeEarmuffMode", 1);
			Class143.earmuffStateMode_0 = Class143.EarmuffStateMode.Enabled;
		});
		qmselectButton7.AddAction(2, delegate
		{
			Class141.class6_0.SetInt("Toggles", "FakeEarmuffMode", 2);
			Class143.earmuffStateMode_0 = Class143.EarmuffStateMode.Disabled;
		});
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x000035E1 File Offset: 0x000017E1
	internal static bool edTagt9pnEyVAuhha5H()
	{
		return Class130.QMjRPX9hxtib819HfQ5 == null;
	}

	// Token: 0x0400037F RID: 895
	private static QMMenuPage qmmenuPage_0;

	// Token: 0x04000380 RID: 896
	internal static Class130 QMjRPX9hxtib819HfQ5;
}
