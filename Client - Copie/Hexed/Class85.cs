using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using UnityEngine;
using VRC.Core;
using VRC.UI;
using VRC.UI.Elements.Controls;
using VRC.UI.Elements.Menus;

// Token: 0x020000BE RID: 190
internal class Class85 : Interface3
{
	// Token: 0x06000465 RID: 1125 RVA: 0x00016E98 File Offset: 0x00015098
	public void Initialize()
	{
		MethodInfo method = typeof(MainMenuSelectedUser).GetMethod("Method_Public_Void_IUser_0");
		Class85.Delegate16 detour;
		if ((detour = Class85.<>O.delegate16_0) == null)
		{
			detour = (Class85.<>O.delegate16_0 = new Class85.Delegate16(Class85.Patch));
		}
		Class85.delegate16_0 = HookManager.Detour<Class85.Delegate16>(method, detour);
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x00016EE0 File Offset: 0x000150E0
	private static void Patch(IntPtr instance, IntPtr __0)
	{
		Class85.delegate16_0(instance, __0);
		MainMenuSelectedUser mainMenuSelectedUser_0 = (instance == IntPtr.Zero) ? null : new MainMenuSelectedUser(instance);
		if (mainMenuSelectedUser_0 == null)
		{
			return;
		}
		IUser user2 = (__0 == IntPtr.Zero) ? mainMenuSelectedUser_0.field_Private_IUser_0 : new IUser(__0);
		if (user2 == null)
		{
			return;
		}
		Object1PublicOb1ApStBo1StLoBoSiUnique object1PublicOb1ApStBo1StLoBoSiUnique_0 = user2.TryCast<Object1PublicOb1ApStBo1StLoBoSiUnique>();
		if (object1PublicOb1ApStBo1StLoBoSiUnique_0 == null || object1PublicOb1ApStBo1StLoBoSiUnique_0.Method_Public_get_TYPE_0() == null)
		{
			return;
		}
		Class10.TrustRanks rank = object1PublicOb1ApStBo1StLoBoSiUnique_0.Method_Public_get_TYPE_0().GetRank();
		Color rankColor = rank.GetRankColor();
		TextMeshProUGUIEx component = mainMenuSelectedUser_0.transform.Find("Header_MM_UserName/LeftItemContainer/Text_Title").GetComponent<TextMeshProUGUIEx>();
		component.color = rankColor;
		component.richText = true;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
		defaultInterpolatedStringHandler.AppendLiteral("<color=#");
		defaultInterpolatedStringHandler.AppendFormatted(ColorUtility.ToHtmlStringRGB(rankColor));
		defaultInterpolatedStringHandler.AppendLiteral(">");
		defaultInterpolatedStringHandler.AppendFormatted(object1PublicOb1ApStBo1StLoBoSiUnique_0.Method_Public_get_TYPE_0().DisplayName());
		defaultInterpolatedStringHandler.AppendLiteral("</color>");
		component.text = defaultInterpolatedStringHandler.ToStringAndClear();
		TextMeshProUGUIEx component2 = mainMenuSelectedUser_0.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup/Row1/Profile/DetailsArea/Field_Trust/Text_FieldContent").GetComponent<TextMeshProUGUIEx>();
		component2.color = rankColor;
		component2.richText = true;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 3);
		defaultInterpolatedStringHandler.AppendLiteral("<color=#");
		defaultInterpolatedStringHandler.AppendFormatted(ColorUtility.ToHtmlStringRGB(rankColor));
		defaultInterpolatedStringHandler.AppendLiteral(">");
		defaultInterpolatedStringHandler.AppendFormatted(rank.GetRankString());
		defaultInterpolatedStringHandler.AppendLiteral(" ");
		defaultInterpolatedStringHandler.AppendFormatted(object1PublicOb1ApStBo1StLoBoSiUnique_0.Method_Public_get_TYPE_0().IsFriend() ? "(Friend)" : "");
		defaultInterpolatedStringHandler.AppendLiteral("</color>");
		component2.text = defaultInterpolatedStringHandler.ToStringAndClear();
		mainMenuSelectedUser_0.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup/Row1/Profile/DetailsArea/Field_Trust/Icon").GetComponent<RawImageEx>().color = rankColor;
		if (object1PublicOb1ApStBo1StLoBoSiUnique_0.Method_Public_get_TYPE_0().date_joined == null)
		{
			APIUser.FetchUser(object1PublicOb1ApStBo1StLoBoSiUnique_0.Method_Public_get_TYPE_0().UserID(), delegate(APIUser user)
			{
				Class85.OverridePlayerProfile(user, mainMenuSelectedUser_0);
			}, delegate(string error)
			{
				Class85.OverridePlayerProfile(object1PublicOb1ApStBo1StLoBoSiUnique_0.Method_Public_get_TYPE_0(), mainMenuSelectedUser_0);
			});
			return;
		}
		Class85.OverridePlayerProfile(object1PublicOb1ApStBo1StLoBoSiUnique_0.Method_Public_get_TYPE_0(), mainMenuSelectedUser_0);
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x0001715C File Offset: 0x0001535C
	private static void OverridePlayerProfile(APIUser user, MainMenuSelectedUser menu)
	{
		string text = "";
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (user.last_login != null && user.last_login != "")
		{
			DateTime d = DateTime.Parse(user.last_login, null, DateTimeStyles.RoundtripKind);
			TimeSpan timeSpan = DateTime.UtcNow - d;
			int num = (int)timeSpan.TotalDays;
			int num2 = (int)timeSpan.TotalHours % 24;
			int num3 = (int)timeSpan.TotalMinutes % 60;
			if (num > 0)
			{
				string str = text;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler.AppendLiteral(" Days");
				text = str + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (num2 > 0)
			{
				if (text != "")
				{
					text += ", ";
				}
				string str2 = text;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				defaultInterpolatedStringHandler.AppendLiteral(" Hours");
				text = str2 + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (num3 > 0)
			{
				if (text != "")
				{
					text += ", ";
				}
				string str3 = text;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num3);
				defaultInterpolatedStringHandler.AppendLiteral(" Minutes");
				text = str3 + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			if (text == "")
			{
				text = "Now";
			}
			else
			{
				text += " ago";
			}
		}
		else
		{
			text = "Unknown";
		}
		TextMeshProUGUIEx component = menu.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup/Row1/Bio&Notes/Panel_MM_ScrollRect/Viewport/VerticalLayoutGroup/Header_Bio/LeftItemContainer/Text_MM_H4").GetComponent<TextMeshProUGUIEx>();
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
		defaultInterpolatedStringHandler.AppendLiteral("Creation: ");
		defaultInterpolatedStringHandler.AppendFormatted(user.date_joined);
		defaultInterpolatedStringHandler.AppendLiteral("\nPlatform: ");
		defaultInterpolatedStringHandler.AppendFormatted<Class10.APIDevice>(user.GetAPIDevice());
		defaultInterpolatedStringHandler.AppendLiteral("\nLogin: ");
		defaultInterpolatedStringHandler.AppendFormatted(text);
		component.text = defaultInterpolatedStringHandler.ToStringAndClear();
		component.enabled = true;
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x000030AA File Offset: 0x000012AA
	internal static bool mK65kQamO7xKMIuat5n()
	{
		return Class85.mn7PUxa9WSsFyJXufDd == null;
	}

	// Token: 0x0400021F RID: 543
	private static Class85.Delegate16 delegate16_0;

	// Token: 0x04000220 RID: 544
	internal static Class85 mn7PUxa9WSsFyJXufDd;

	// Token: 0x020000BF RID: 191
	// (Invoke) Token: 0x0600046B RID: 1131
	private delegate void Delegate16(IntPtr instance, IntPtr __0);

	// Token: 0x020000C0 RID: 192
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000221 RID: 545
		public static Class85.Delegate16 delegate16_0;
	}
}
