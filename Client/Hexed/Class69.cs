using System;
using System.Runtime.CompilerServices;
using Hexed.Wrappers;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Photon.Realtime;

// Token: 0x02000085 RID: 133
internal class Class69
{
	// Token: 0x060003D4 RID: 980 RVA: 0x000157AC File Offset: 0x000139AC
	public static bool ReceivedPropEvent(Hashtable Data, Player PhotonPlayer)
	{
		string text = PhotonPlayer.AvatarID();
		string text2 = PhotonPlayer.RepresentedGroupID();
		bool flag = PhotonPlayer.IsVR();
		bool flag2 = PhotonPlayer.ShowGroupToOthers();
		bool flag3 = PhotonPlayer.ShowSocialRankToOthers();
		bool flag4 = PhotonPlayer.UseImpostorAsFallback();
		int num = PhotonPlayer.AvatarHeight();
		Class8.dictionary_0[PhotonPlayer.ActorID()] = Data;
		string text3 = PhotonPlayer.AvatarID();
		string text4 = PhotonPlayer.RepresentedGroupID();
		bool flag5 = PhotonPlayer.IsVR();
		bool flag6 = PhotonPlayer.ShowGroupToOthers();
		bool flag7 = PhotonPlayer.ShowSocialRankToOthers();
		bool flag8 = PhotonPlayer.UseImpostorAsFallback();
		int num2 = PhotonPlayer.AvatarHeight();
		string text5 = PhotonPlayer.DisplayName() ?? "NO NAME";
		if (text != text3)
		{
			string value = PhotonPlayer.AvatarName() ?? "NO NAME";
			string value2 = PhotonPlayer.AvatarReleaseStatus() ?? "NO RELEASE";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 3);
			defaultInterpolatedStringHandler.AppendFormatted(text5);
			defaultInterpolatedStringHandler.AppendLiteral(" changed Avatar from ");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral(" to ");
			defaultInterpolatedStringHandler.AppendFormatted(text3);
			Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 3);
			defaultInterpolatedStringHandler.AppendFormatted(text5);
			defaultInterpolatedStringHandler.AppendLiteral(" --> ");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(" [");
			defaultInterpolatedStringHandler.AppendFormatted(value2);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			Class53.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Class53.LogsType.Avatar);
		}
		if (text2 != text4)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 3);
			defaultInterpolatedStringHandler.AppendFormatted(text5);
			defaultInterpolatedStringHandler.AppendLiteral(" changed represented Group from ");
			defaultInterpolatedStringHandler.AppendFormatted(text2);
			defaultInterpolatedStringHandler.AppendLiteral(" to ");
			defaultInterpolatedStringHandler.AppendFormatted(text4);
			Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Group);
			Class53.Log(text5 + " --> Group update", Class53.LogsType.Group);
		}
		if (flag != flag5)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 3);
			defaultInterpolatedStringHandler.AppendFormatted(text5);
			defaultInterpolatedStringHandler.AppendLiteral(" changed VR State from ");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(flag);
			defaultInterpolatedStringHandler.AppendLiteral(" to ");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(flag5);
			Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Protection);
			Class53.Log(text5 + " --> " + ((!flag5) ? "Desktop Switch" : "VR Switch"), Class53.LogsType.Protection);
		}
		if (flag2 != flag6)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 3);
			defaultInterpolatedStringHandler.AppendFormatted(text5);
			defaultInterpolatedStringHandler.AppendLiteral(" changed Group visibility from ");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(flag2);
			defaultInterpolatedStringHandler.AppendLiteral(" to ");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(flag6);
			Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Group);
			Class53.Log(text5 + " --> " + ((!flag6) ? "Hide Group" : "Show Group"), Class53.LogsType.Group);
		}
		if (flag3 != flag7)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 3);
			defaultInterpolatedStringHandler.AppendFormatted(text5);
			defaultInterpolatedStringHandler.AppendLiteral(" changed Rank visibility from ");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(flag3);
			defaultInterpolatedStringHandler.AppendLiteral(" to ");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(flag7);
			Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
			Class53.Log(text5 + " --> " + ((!flag7) ? "Hide Rank" : "Show Rank"), Class53.LogsType.Room);
		}
		if (flag4 != flag8)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 3);
			defaultInterpolatedStringHandler.AppendFormatted(text5);
			defaultInterpolatedStringHandler.AppendLiteral(" changed Impostor fallback from ");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(flag4);
			defaultInterpolatedStringHandler.AppendLiteral(" to ");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(flag8);
			Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
			Class53.Log(text5 + " --> " + (flag8 ? "Impostor Fallback" : "Default Fallback"), Class53.LogsType.Avatar);
		}
		if (num != num2)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 3);
			defaultInterpolatedStringHandler.AppendFormatted(text5);
			defaultInterpolatedStringHandler.AppendLiteral(" changed Avatar height from ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral(" to ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
			Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
			defaultInterpolatedStringHandler.AppendFormatted(text5);
			defaultInterpolatedStringHandler.AppendLiteral(" --> Avatar Height [");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			Class53.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Class53.LogsType.Avatar);
		}
		return true;
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x00015BE4 File Offset: 0x00013DE4
	public static bool RaisedPropEvent(Hashtable Data)
	{
		if (Data.ContainsKey("avatarEyeHeight") && Class143.bool_38)
		{
			Object @object = "avatarEyeHeight";
			Int32 @int = default(Int32);
			@int.m_value = int.MaxValue;
			Data[@object] = @int.BoxIl2CppObject();
		}
		if (Data.ContainsKey("groupOnNameplate") && Class143.bool_32)
		{
			Data["groupOnNameplate"] = new Object(IL2CPP.ManagedStringToIl2Cpp(Class143.string_1));
		}
		return true;
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x00002FEC File Offset: 0x000011EC
	internal static bool uLsyS1nSqXqm9q2grE6()
	{
		return Class69.Vs139Sn0GtSAYlXGO2Z == null;
	}

	// Token: 0x040001E7 RID: 487
	private static Class69 Vs139Sn0GtSAYlXGO2Z;
}
