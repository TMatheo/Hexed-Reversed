using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using TMPro;
using UnityEngine;

// Token: 0x020000CF RID: 207
internal class Class90 : Interface3
{
	// Token: 0x06000496 RID: 1174 RVA: 0x00017750 File Offset: 0x00015950
	public void Initialize()
	{
		MethodInfo method = typeof(MonoBehaviourPublicObTe_cTeObObObObUnique).GetMethod("Method_Private_Void_IUser_0");
		Class90.Delegate21 detour;
		if ((detour = Class90.<>O.delegate21_0) == null)
		{
			detour = (Class90.<>O.delegate21_0 = new Class90.Delegate21(Class90.Patch));
		}
		Class90.delegate21_0 = HookManager.Detour<Class90.Delegate21>(method, detour);
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00017798 File Offset: 0x00015998
	private static void Patch(IntPtr instance, IntPtr __0)
	{
		Class90.delegate21_0(instance, __0);
		MonoBehaviourPublicObTe_cTeObObObObUnique monoBehaviourPublicObTe_cTeObObObObUnique = (instance == IntPtr.Zero) ? null : new MonoBehaviourPublicObTe_cTeObObObObUnique(instance);
		IUser user = (__0 == IntPtr.Zero) ? null : new IUser(__0);
		if (monoBehaviourPublicObTe_cTeObObObObUnique == null)
		{
			return;
		}
		IUser user2 = user ?? monoBehaviourPublicObTe_cTeObObObObUnique.field_Private_IUser_0;
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
		if (!(monoBehaviourPublicObTe_cTeObObObObUnique.field_Public_TextMeshProUGUI_0 == null))
		{
			monoBehaviourPublicObTe_cTeObObObObUnique.field_Public_TextMeshProUGUI_0.richText = true;
			TMP_Text field_Public_TextMeshProUGUI_ = monoBehaviourPublicObTe_cTeObObObObUnique.field_Public_TextMeshProUGUI_0;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted(monoBehaviourPublicObTe_cTeObObObObUnique.field_Public_TextMeshProUGUI_0.text);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			field_Public_TextMeshProUGUI_.text = defaultInterpolatedStringHandler.ToStringAndClear();
			monoBehaviourPublicObTe_cTeObObObObUnique.field_Public_TextMeshProUGUI_0.color = color;
			return;
		}
	}

	// Token: 0x06000499 RID: 1177 RVA: 0x00003102 File Offset: 0x00001302
	internal static bool kvuFFdT8EkBwnZq0DoO()
	{
		return Class90.U9Z83VTRYqY2W1C09JP == null;
	}

	// Token: 0x04000234 RID: 564
	private static Class90.Delegate21 delegate21_0;

	// Token: 0x04000235 RID: 565
	private static Class90 U9Z83VTRYqY2W1C09JP;

	// Token: 0x020000D0 RID: 208
	// (Invoke) Token: 0x0600049B RID: 1179
	private delegate void Delegate21(IntPtr instance, IntPtr __0);

	// Token: 0x020000D1 RID: 209
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000236 RID: 566
		public static Class90.Delegate21 delegate21_0;
	}
}
