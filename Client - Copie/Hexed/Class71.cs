using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using TMPro;
using UnityEngine;
using VRC.UI.Elements.Controls;

// Token: 0x02000090 RID: 144
internal class Class71 : Interface3
{
	// Token: 0x060003E9 RID: 1001 RVA: 0x00015DA0 File Offset: 0x00013FA0
	public void Initialize()
	{
		MethodInfo method = typeof(AvatarContentCell).GetMethod("Method_Private_Void_IAvatar_0");
		Class71.Delegate1 detour;
		if ((detour = Class71.<>O.delegate1_0) == null)
		{
			detour = (Class71.<>O.delegate1_0 = new Class71.Delegate1(Class71.Patch));
		}
		Class71.delegate1_0 = HookManager.Detour<Class71.Delegate1>(method, detour);
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x00015DE8 File Offset: 0x00013FE8
	private static void Patch(IntPtr instance, IntPtr __0)
	{
		Class71.delegate1_0(instance, __0);
		AvatarContentCell avatarContentCell = (instance == IntPtr.Zero) ? null : new AvatarContentCell(instance);
		IAvatar avatar = (__0 == IntPtr.Zero) ? null : new IAvatar(__0);
		if (avatarContentCell == null)
		{
			return;
		}
		IAvatar avatar2 = avatar ?? avatarContentCell.field_Private_IAvatar_0;
		if (avatar2 == null)
		{
			return;
		}
		Object1PublicOb1BoObStBoLiStDaBoUnique object1PublicOb1BoObStBoLiStDaBoUnique = avatar2.TryCast<Object1PublicOb1BoObStBoLiStDaBoUnique>();
		if (object1PublicOb1BoObStBoLiStDaBoUnique == null || object1PublicOb1BoObStBoLiStDaBoUnique.Method_Public_get_TYPE_0() == null)
		{
			return;
		}
		Color color = Color.gray;
		string releaseStatus = object1PublicOb1BoObStBoLiStDaBoUnique.Method_Public_get_TYPE_0().releaseStatus;
		if (releaseStatus == "private")
		{
			color = Color.red;
		}
		else if (releaseStatus == "public")
		{
			color = Color.green;
		}
		else if (releaseStatus == "hidden")
		{
			color = Color.yellow;
		}
		string value = ColorUtility.ToHtmlStringRGB(color);
		if (!(avatarContentCell.field_Public_TextMeshProUGUI_0 == null))
		{
			avatarContentCell.field_Public_TextMeshProUGUI_0.richText = true;
			TMP_Text field_Public_TextMeshProUGUI_ = avatarContentCell.field_Public_TextMeshProUGUI_0;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted(avatarContentCell.field_Public_TextMeshProUGUI_0.text);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			field_Public_TextMeshProUGUI_.text = defaultInterpolatedStringHandler.ToStringAndClear();
			avatarContentCell.field_Public_TextMeshProUGUI_0.color = color;
			return;
		}
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x0000300A File Offset: 0x0000120A
	internal static bool xSpntLaeFSmkaC292vy()
	{
		return Class71.INl7SpaJ5l6OKGLMcoE == null;
	}

	// Token: 0x040001ED RID: 493
	private static Class71.Delegate1 delegate1_0;

	// Token: 0x040001EE RID: 494
	internal static Class71 INl7SpaJ5l6OKGLMcoE;

	// Token: 0x02000091 RID: 145
	// (Invoke) Token: 0x060003EE RID: 1006
	private delegate void Delegate1(IntPtr instance, IntPtr __0);

	// Token: 0x02000092 RID: 146
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040001EF RID: 495
		public static Class71.Delegate1 delegate1_0;
	}
}
