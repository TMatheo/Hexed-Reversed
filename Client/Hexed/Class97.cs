using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using TMPro;
using UnityEngine;
using VRC.UI.Elements.Controls;

// Token: 0x020000E5 RID: 229
internal class Class97 : Interface3
{
	// Token: 0x060004D7 RID: 1239 RVA: 0x000180CC File Offset: 0x000162CC
	public void Initialize()
	{
		MethodInfo method = typeof(UserCellListViewQM).GetMethod("Method_Private_Void_IUser_0");
		Class97.Delegate28 detour;
		if ((detour = Class97.<>O.delegate28_0) == null)
		{
			detour = (Class97.<>O.delegate28_0 = new Class97.Delegate28(Class97.Patch));
		}
		Class97.delegate28_0 = HookManager.Detour<Class97.Delegate28>(method, detour);
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x00018114 File Offset: 0x00016314
	private static void Patch(IntPtr instance, IntPtr __0)
	{
		Class97.delegate28_0(instance, __0);
		UserCellListViewQM userCellListViewQM = (instance == IntPtr.Zero) ? null : new UserCellListViewQM(instance);
		IUser user = (__0 == IntPtr.Zero) ? null : new IUser(__0);
		if (userCellListViewQM == null)
		{
			return;
		}
		IUser user2 = user ?? userCellListViewQM.field_Private_IUser_0;
		if (user2 == null)
		{
			return;
		}
		Object1PublicOb1ApStBo1StLoBoSiUnique object1PublicOb1ApStBo1StLoBoSiUnique = user2.TryCast<Object1PublicOb1ApStBo1StLoBoSiUnique>();
		if (object1PublicOb1ApStBo1StLoBoSiUnique == null || object1PublicOb1ApStBo1StLoBoSiUnique.Method_Public_get_TYPE_0() == null)
		{
			return;
		}
		Color color = (!object1PublicOb1ApStBo1StLoBoSiUnique.Method_Public_get_TYPE_0().IsFriend()) ? object1PublicOb1ApStBo1StLoBoSiUnique.Method_Public_get_TYPE_0().GetRank().GetRankColor() : VRCPlayer.field_Internal_Static_Color_1;
		string value = ColorUtility.ToHtmlStringRGB(color);
		if (!(userCellListViewQM.field_Public_TextMeshProUGUI_0 == null) && !(userCellListViewQM.field_Public_TextMeshProUGUI_1 == null))
		{
			userCellListViewQM.field_Public_TextMeshProUGUI_0.richText = true;
			userCellListViewQM.field_Public_TextMeshProUGUI_1.richText = true;
			TMP_Text field_Public_TextMeshProUGUI_ = userCellListViewQM.field_Public_TextMeshProUGUI_0;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted(userCellListViewQM.field_Public_TextMeshProUGUI_0.text);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			field_Public_TextMeshProUGUI_.text = defaultInterpolatedStringHandler.ToStringAndClear();
			TMP_Text field_Public_TextMeshProUGUI_2 = userCellListViewQM.field_Public_TextMeshProUGUI_1;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted(userCellListViewQM.field_Public_TextMeshProUGUI_0.text);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			field_Public_TextMeshProUGUI_2.text = defaultInterpolatedStringHandler.ToStringAndClear();
			userCellListViewQM.field_Public_TextMeshProUGUI_0.color = color;
			userCellListViewQM.field_Public_TextMeshProUGUI_1.color = color;
			return;
		}
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x00003176 File Offset: 0x00001376
	internal static bool IcGp0fTjsgidHwY9f11()
	{
		return Class97.OEf9vTTg24bfkDPXxGZ == null;
	}

	// Token: 0x0400024E RID: 590
	private static Class97.Delegate28 delegate28_0;

	// Token: 0x0400024F RID: 591
	internal static Class97 OEf9vTTg24bfkDPXxGZ;

	// Token: 0x020000E6 RID: 230
	// (Invoke) Token: 0x060004DC RID: 1244
	private delegate void Delegate28(IntPtr instance, IntPtr __0);

	// Token: 0x020000E7 RID: 231
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000250 RID: 592
		public static Class97.Delegate28 delegate28_0;
	}
}
