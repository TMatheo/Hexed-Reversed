using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using TMPro;
using UnityEngine;

// Token: 0x020000CC RID: 204
internal class Class89 : Interface3
{
	// Token: 0x0600048E RID: 1166 RVA: 0x000175E0 File Offset: 0x000157E0
	public void Initialize()
	{
		MethodInfo method = typeof(MonoBehaviourPublicTeObTeObObUnique).GetMethod("Method_Private_Void_IUser_0");
		Class89.Delegate20 detour;
		if ((detour = Class89.<>O.delegate20_0) == null)
		{
			detour = (Class89.<>O.delegate20_0 = new Class89.Delegate20(Class89.Patch));
		}
		Class89.delegate20_0 = HookManager.Detour<Class89.Delegate20>(method, detour);
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x00017628 File Offset: 0x00015828
	private static void Patch(IntPtr instance, IntPtr __0)
	{
		Class89.delegate20_0(instance, __0);
		MonoBehaviourPublicTeObTeObObUnique monoBehaviourPublicTeObTeObObUnique = (instance == IntPtr.Zero) ? null : new MonoBehaviourPublicTeObTeObObUnique(instance);
		IUser user = (__0 == IntPtr.Zero) ? null : new IUser(__0);
		if (monoBehaviourPublicTeObTeObObUnique == null)
		{
			return;
		}
		IUser user2 = user ?? monoBehaviourPublicTeObTeObObUnique.field_Private_IUser_0;
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
		if (!(monoBehaviourPublicTeObTeObObUnique.field_Public_TextMeshProUGUI_0 == null))
		{
			monoBehaviourPublicTeObTeObObUnique.field_Public_TextMeshProUGUI_0.richText = true;
			TMP_Text field_Public_TextMeshProUGUI_ = monoBehaviourPublicTeObTeObObUnique.field_Public_TextMeshProUGUI_0;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted(monoBehaviourPublicTeObTeObObUnique.field_Public_TextMeshProUGUI_0.text);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			field_Public_TextMeshProUGUI_.text = defaultInterpolatedStringHandler.ToStringAndClear();
			monoBehaviourPublicTeObTeObObUnique.field_Public_TextMeshProUGUI_0.color = rankColor;
			return;
		}
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x000030F8 File Offset: 0x000012F8
	internal static bool E6pQCeTHAmjRooG0fg5()
	{
		return Class89.zGsFi2T2v7NORxr1IoV == null;
	}

	// Token: 0x04000231 RID: 561
	private static Class89.Delegate20 delegate20_0;

	// Token: 0x04000232 RID: 562
	internal static Class89 zGsFi2T2v7NORxr1IoV;

	// Token: 0x020000CD RID: 205
	// (Invoke) Token: 0x06000493 RID: 1171
	private delegate void Delegate20(IntPtr instance, IntPtr __0);

	// Token: 0x020000CE RID: 206
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000233 RID: 563
		public static Class89.Delegate20 delegate20_0;
	}
}
