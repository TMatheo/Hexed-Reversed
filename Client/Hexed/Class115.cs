using System;

// Token: 0x02000116 RID: 278
internal static class Class115
{
	// Token: 0x0600057D RID: 1405 RVA: 0x00003308 File Offset: 0x00001508
	public static VRCInput smethod_0(string inputName)
	{
		return VRCInputManager.field_Private_Static_Dictionary_2_String_VRCInput_0[inputName];
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x00003315 File Offset: 0x00001515
	public static float GetHeldTime(this VRCInput input)
	{
		return input.Method_Public_get_Single_0();
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x0000331D File Offset: 0x0000151D
	public static bool IsPressed(this VRCInput input)
	{
		return input.Method_Public_get_Boolean_PDM_0();
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x00003325 File Offset: 0x00001525
	public static bool IsReleased(this VRCInput input)
	{
		return input.Method_Public_get_Boolean_PDM_1();
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x0000332D File Offset: 0x0000152D
	public static bool IsHeld(this VRCInput input)
	{
		return input.Method_Public_get_Boolean_0();
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x00003335 File Offset: 0x00001535
	public static float GetAxis(this VRCInput input)
	{
		return input.Method_Public_get_Single_PDM_0();
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x0000333D File Offset: 0x0000153D
	internal static bool AOw7BZIvHOR1Hb51N81()
	{
		return Class115.kPobQMIxkrh6IQPKh2H == null;
	}

	// Token: 0x04000297 RID: 663
	private static Class115 kPobQMIxkrh6IQPKh2H;
}
