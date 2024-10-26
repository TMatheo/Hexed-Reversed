using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using Il2CppSystem;
using VRC.Core;
using VRC.UI.Elements.Controls;
using VRC.UI.Elements.Groups;

// Token: 0x020000AE RID: 174
internal class Class80 : Interface3
{
	// Token: 0x06000439 RID: 1081 RVA: 0x000166D8 File Offset: 0x000148D8
	public void Initialize()
	{
		MethodInfo method = typeof(GroupInfoPanel).GetMethod("Method_Private_Void_IGroup_PDM_0");
		Class80.Delegate11 detour;
		if ((detour = Class80.<>O.delegate11_0) == null)
		{
			detour = (Class80.<>O.delegate11_0 = new Class80.Delegate11(Class80.Patch));
		}
		Class80.delegate11_0 = HookManager.Detour<Class80.Delegate11>(method, detour);
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x00016720 File Offset: 0x00014920
	private static void Patch(IntPtr instance, IntPtr __0)
	{
		Class80.<>c__DisplayClass3_0 CS$<>8__locals1 = new Class80.<>c__DisplayClass3_0();
		Class80.delegate11_0(instance, __0);
		GroupInfoPanel groupInfoPanel = (instance == IntPtr.Zero) ? null : new GroupInfoPanel(instance);
		if (groupInfoPanel == null)
		{
			return;
		}
		IGroup group = (__0 == IntPtr.Zero) ? groupInfoPanel.field_Private_IGroup_0 : new IGroup(__0);
		if (group == null)
		{
			return;
		}
		CS$<>8__locals1.object1PublicIEquatable1ObfOb1ObTeBoLiInOb1LiUnique_0 = group.TryCast<Object1PublicIEquatable1ObfOb1ObTeBoLiInOb1LiUnique>();
		if (CS$<>8__locals1.object1PublicIEquatable1ObfOb1ObTeBoLiInOb1LiUnique_0 != null && CS$<>8__locals1.object1PublicIEquatable1ObfOb1ObTeBoLiInOb1LiUnique_0.Method_Public_get_TYPE_0() != null)
		{
			CS$<>8__locals1.textMeshProUGUIEx_0 = groupInfoPanel.transform.Find("ScrollRect_MM/Viewport/Content/BodyContainer_NonMember/About Group/Description/Panel_MM_ScrollRect/Viewport/VerticalLayoutGroup/Body").GetComponent<TextMeshProUGUIEx>();
			CS$<>8__locals1.textMeshProUGUIEx_1 = groupInfoPanel.transform.Find("ScrollRect_MM/Viewport/Content/BodyContainer_Member/Panel_MM_GroupInfo/About Group/Description/Panel_MM_ScrollRect/Viewport/VerticalLayoutGroup/Body_Description_Member").GetComponent<TextMeshProUGUIEx>();
			CS$<>8__locals1.string_0 = "";
			if (CS$<>8__locals1.object1PublicIEquatable1ObfOb1ObTeBoLiInOb1LiUnique_0.Method_Public_get_TYPE_0().memberCountSyncedAt != null && CS$<>8__locals1.object1PublicIEquatable1ObfOb1ObTeBoLiInOb1LiUnique_0.Method_Public_get_TYPE_0().memberCountSyncedAt != "")
			{
				DateTime d = DateTime.Parse(CS$<>8__locals1.object1PublicIEquatable1ObfOb1ObTeBoLiInOb1LiUnique_0.Method_Public_get_TYPE_0().memberCountSyncedAt, null, DateTimeStyles.RoundtripKind);
				TimeSpan timeSpan = DateTime.UtcNow - d;
				int num = (int)timeSpan.TotalDays;
				int num2 = (int)timeSpan.TotalHours % 24;
				int num3 = (int)timeSpan.TotalMinutes % 60;
				if (num > 0)
				{
					Class80.<>c__DisplayClass3_0 CS$<>8__locals2 = CS$<>8__locals1;
					string string_ = CS$<>8__locals1.string_0;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(num);
					defaultInterpolatedStringHandler.AppendLiteral(" Days");
					CS$<>8__locals2.string_0 = string_ + defaultInterpolatedStringHandler.ToStringAndClear();
				}
				if (num2 > 0)
				{
					if (CS$<>8__locals1.string_0 != "")
					{
						CS$<>8__locals1.string_0 += ", ";
					}
					Class80.<>c__DisplayClass3_0 CS$<>8__locals3 = CS$<>8__locals1;
					string string_2 = CS$<>8__locals1.string_0;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
					defaultInterpolatedStringHandler.AppendLiteral(" Hours");
					CS$<>8__locals3.string_0 = string_2 + defaultInterpolatedStringHandler.ToStringAndClear();
				}
				if (num3 > 0)
				{
					if (CS$<>8__locals1.string_0 != "")
					{
						CS$<>8__locals1.string_0 += ", ";
					}
					Class80.<>c__DisplayClass3_0 CS$<>8__locals4 = CS$<>8__locals1;
					string string_3 = CS$<>8__locals1.string_0;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(num3);
					defaultInterpolatedStringHandler.AppendLiteral(" Minutes");
					CS$<>8__locals4.string_0 = string_3 + defaultInterpolatedStringHandler.ToStringAndClear();
				}
				if (!(CS$<>8__locals1.string_0 == ""))
				{
					CS$<>8__locals1.string_0 += " ago";
				}
				else
				{
					CS$<>8__locals1.string_0 = "Now";
				}
			}
			else
			{
				CS$<>8__locals1.string_0 = "Unknown";
			}
			APIUser.FetchUser(CS$<>8__locals1.object1PublicIEquatable1ObfOb1ObTeBoLiInOb1LiUnique_0.Method_Public_get_TYPE_0().ownerId, delegate(APIUser user)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(29, 3);
				defaultInterpolatedStringHandler2.AppendLiteral("Owner: ");
				defaultInterpolatedStringHandler2.AppendFormatted(user.DisplayName());
				defaultInterpolatedStringHandler2.AppendLiteral(" \nCreation: ");
				defaultInterpolatedStringHandler2.AppendFormatted<DateTime>(CS$<>8__locals1.object1PublicIEquatable1ObfOb1ObTeBoLiInOb1LiUnique_0.Method_Public_get_TYPE_0().createdAt);
				defaultInterpolatedStringHandler2.AppendLiteral(" \nSynced: ");
				defaultInterpolatedStringHandler2.AppendFormatted(CS$<>8__locals1.string_0);
				string str = defaultInterpolatedStringHandler2.ToStringAndClear();
				CS$<>8__locals1.textMeshProUGUIEx_0.text = str + "\n\n" + CS$<>8__locals1.textMeshProUGUIEx_0.text;
				CS$<>8__locals1.textMeshProUGUIEx_1.text = str + "\n\n" + CS$<>8__locals1.textMeshProUGUIEx_1.text;
			}, delegate(string error)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(20, 2);
				defaultInterpolatedStringHandler2.AppendLiteral("Creation: ");
				defaultInterpolatedStringHandler2.AppendFormatted<DateTime>(CS$<>8__locals1.object1PublicIEquatable1ObfOb1ObTeBoLiInOb1LiUnique_0.Method_Public_get_TYPE_0().createdAt);
				defaultInterpolatedStringHandler2.AppendLiteral(" \nSynced: ");
				defaultInterpolatedStringHandler2.AppendFormatted(CS$<>8__locals1.string_0);
				string str = defaultInterpolatedStringHandler2.ToStringAndClear();
				CS$<>8__locals1.textMeshProUGUIEx_0.text = str + "\n\n" + CS$<>8__locals1.textMeshProUGUIEx_0.text;
				CS$<>8__locals1.textMeshProUGUIEx_1.text = str + "\n\n" + CS$<>8__locals1.textMeshProUGUIEx_1.text;
			});
			return;
		}
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x0000306E File Offset: 0x0000126E
	internal static bool zr5q7HaEj3NKaWgF7fl()
	{
		return Class80.aiyYPLakeTNWox3TNYI == null;
	}

	// Token: 0x0400020B RID: 523
	private static Class80.Delegate11 delegate11_0;

	// Token: 0x0400020C RID: 524
	private static Class80 aiyYPLakeTNWox3TNYI;

	// Token: 0x020000AF RID: 175
	// (Invoke) Token: 0x0600043E RID: 1086
	private delegate void Delegate11(IntPtr instance, IntPtr __0);

	// Token: 0x020000B0 RID: 176
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400020D RID: 525
		public static Class80.Delegate11 delegate11_0;
	}
}
