using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using TMPro;
using UnityEngine;
using VRC.UI.Elements.Controls;

// Token: 0x020000E8 RID: 232
internal class Class98 : Interface3
{
	// Token: 0x060004DF RID: 1247 RVA: 0x000182DC File Offset: 0x000164DC
	public void Initialize()
	{
		MethodInfo method = typeof(UserContentCell).GetMethod("Method_Private_Void_IUser_0");
		Class98.Delegate29 detour;
		if ((detour = Class98.<>O.delegate29_0) == null)
		{
			detour = (Class98.<>O.delegate29_0 = new Class98.Delegate29(Class98.Patch));
		}
		Class98.delegate29_0 = HookManager.Detour<Class98.Delegate29>(method, detour);
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x00018324 File Offset: 0x00016524
	private static void Patch(IntPtr instance, IntPtr __0)
	{
		Class98.delegate29_0(instance, __0);
		UserContentCell userContentCell = (instance == IntPtr.Zero) ? null : new UserContentCell(instance);
		if (userContentCell == null)
		{
			return;
		}
		IUser user;
		if (__0 != IntPtr.Zero)
		{
			if ((user = new IUser(__0)) != null)
			{
				goto IL_4F;
			}
		}
		else if ((user = userContentCell.field_Private_IUser_0) != null)
		{
			goto IL_4F;
		}
		user = userContentCell.field_Private_IUser_0;
		IL_4F:
		IUser user2 = user;
		if (user2 == null)
		{
			return;
		}
		Object1PublicOb1ApStBo1StLoBoSiUnique object1PublicOb1ApStBo1StLoBoSiUnique = user2.TryCast<Object1PublicOb1ApStBo1StLoBoSiUnique>();
		if (object1PublicOb1ApStBo1StLoBoSiUnique == null || object1PublicOb1ApStBo1StLoBoSiUnique.Method_Public_get_TYPE_0() == null)
		{
			return;
		}
		Color rankColor = object1PublicOb1ApStBo1StLoBoSiUnique.Method_Public_get_TYPE_0().GetRank().GetRankColor();
		string value = ColorUtility.ToHtmlStringRGB(rankColor);
		if (!(userContentCell.field_Public_TextMeshProUGUIEx_0 == null) && !(userContentCell.field_Public_TextMeshProUGUIEx_1 == null))
		{
			userContentCell.field_Public_TextMeshProUGUIEx_0.richText = true;
			userContentCell.field_Public_TextMeshProUGUIEx_1.richText = true;
			TMP_Text field_Public_TextMeshProUGUIEx_ = userContentCell.field_Public_TextMeshProUGUIEx_0;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted(userContentCell.field_Public_TextMeshProUGUIEx_0.text);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			field_Public_TextMeshProUGUIEx_.text = defaultInterpolatedStringHandler.ToStringAndClear();
			TMP_Text field_Public_TextMeshProUGUIEx_2 = userContentCell.field_Public_TextMeshProUGUIEx_1;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted(userContentCell.field_Public_TextMeshProUGUIEx_0.text);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			field_Public_TextMeshProUGUIEx_2.text = defaultInterpolatedStringHandler.ToStringAndClear();
			userContentCell.field_Public_TextMeshProUGUIEx_0.color = rankColor;
			userContentCell.field_Public_TextMeshProUGUIEx_1.color = rankColor;
			return;
		}
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x00003180 File Offset: 0x00001380
	internal static bool Dq7LHOT6BUnHjR43Sju()
	{
		return Class98.L2CA5TTlZFiR7ih2giY == null;
	}

	// Token: 0x04000251 RID: 593
	private static Class98.Delegate29 delegate29_0;

	// Token: 0x04000252 RID: 594
	private static Class98 L2CA5TTlZFiR7ih2giY;

	// Token: 0x020000E9 RID: 233
	// (Invoke) Token: 0x060004E4 RID: 1252
	private delegate void Delegate29(IntPtr instance, IntPtr __0);

	// Token: 0x020000EA RID: 234
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000253 RID: 595
		public static Class98.Delegate29 delegate29_0;
	}
}
