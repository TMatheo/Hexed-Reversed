using System;
using UnityEngine;

// Token: 0x0200006E RID: 110
internal class Class54
{
	// Token: 0x0600034E RID: 846 RVA: 0x000114AC File Offset: 0x0000F6AC
	public static void GetGestures(Class57.Class58[] p_frame, ref Class54.Class55 p_data)
	{
		for (int i = 0; i < Class54.Class55.int_0; i++)
		{
			p_data.bool_0[i] = false;
		}
		for (int j = 0; j < Class54.Class55.int_1; j++)
		{
			p_data.float_0[j] = 0f;
			p_data.float_1[j] = 0f;
			p_data.float_2[j] = 0f;
			p_data.float_1[j] = 0f;
		}
		foreach (Class57.Class58 @class in p_frame)
		{
			int num = (!@class.IsLeft) ? 1 : 0;
			if (!p_data.bool_0[num])
			{
				p_data.bool_0[num] = true;
				Class54.FillHandPosition(@class, ref p_data.vector3_0[num]);
				Class54.FillHandRotation(@class, ref p_data.quaternion_0[num]);
				if (num != 0)
				{
					if (num == 1)
					{
						Class54.FillFingerBends(@class, ref p_data.float_2);
						Class54.FilFingerSpreads(@class, ref p_data.float_3);
					}
				}
				else
				{
					Class54.FillFingerBends(@class, ref p_data.float_0);
					Class54.FilFingerSpreads(@class, ref p_data.float_1);
				}
			}
		}
	}

	// Token: 0x0600034F RID: 847 RVA: 0x000115E0 File Offset: 0x0000F7E0
	private static void FillHandPosition(Class57.Class58 p_hand, ref Vector3 p_pos)
	{
		p_pos.x = p_hand.Position.X;
		p_pos.y = p_hand.Position.Y;
		p_pos.z = p_hand.Position.Z;
	}

	// Token: 0x06000350 RID: 848 RVA: 0x00011620 File Offset: 0x0000F820
	private static void FillHandRotation(Class57.Class58 p_hand, ref Quaternion p_rot)
	{
		p_rot.x = p_hand.Rotation.X;
		p_rot.y = p_hand.Rotation.Y;
		p_rot.z = p_hand.Rotation.Z;
		p_rot.w = p_hand.Rotation.W;
	}

	// Token: 0x06000351 RID: 849 RVA: 0x00011674 File Offset: 0x0000F874
	private static void FillFingerBends(Class57.Class58 p_hand, ref float[] p_bends)
	{
		foreach (Class57.Class59 @class in p_hand.Fingers)
		{
			Quaternion quaternion = Quaternion.identity;
			float num = 0f;
			foreach (Class57.Class60 class2 in @class.bones)
			{
				if (class2.Type != Class57.BoneType.TYPE_METACARPAL)
				{
					Quaternion quaternion2;
					quaternion2..ctor(class2.Rotation.X, class2.Rotation.Y, class2.Rotation.Z, class2.Rotation.W);
					Quaternion quaternion3 = Quaternion.Inverse(quaternion) * quaternion2;
					quaternion = quaternion2;
					float num2 = 360f - quaternion3.eulerAngles.x;
					if (num2 > 180f)
					{
						num2 -= 360f;
					}
					num += num2;
				}
				else
				{
					quaternion..ctor(class2.Rotation.X, class2.Rotation.Y, class2.Rotation.Z, class2.Rotation.W);
				}
			}
			p_bends[(int)@class.Type] = Mathf.InverseLerp(0f, (@class.Type != Class57.FingerType.TYPE_THUMB) ? 180f : 90f, num);
		}
	}

	// Token: 0x06000352 RID: 850 RVA: 0x000117C8 File Offset: 0x0000F9C8
	private static void FilFingerSpreads(Class57.Class58 p_hand, ref float[] p_spreads)
	{
		foreach (Class57.Class59 @class in p_hand.Fingers)
		{
			Class57.Class60 class2 = @class.bones[0];
			Class57.Class60 class3 = @class.bones[1];
			Quaternion quaternion = new Quaternion(class2.Rotation.X, class2.Rotation.Y, class2.Rotation.Z, class2.Rotation.W);
			Quaternion quaternion2;
			quaternion2..ctor(class3.Rotation.X, class3.Rotation.Y, class3.Rotation.Z, class3.Rotation.W);
			float num = (Quaternion.Inverse(quaternion) * quaternion2).eulerAngles.y;
			if (num > 180f)
			{
				num -= 360f;
			}
			switch (@class.Type)
			{
			case Class57.FingerType.TYPE_THUMB:
				if (p_hand.IsRight)
				{
					num *= -1f;
				}
				num += Class54.vector2_0[1].y * 2f;
				num *= 0.5f;
				break;
			case Class57.FingerType.TYPE_INDEX:
				if (p_hand.IsLeft)
				{
					num *= -1f;
				}
				num += Class54.vector2_0[1].y;
				num *= 0.5f;
				break;
			case Class57.FingerType.TYPE_MIDDLE:
				num += Class54.vector2_0[2].y * (p_hand.IsRight ? 0.125f : -0.125f);
				num *= (p_hand.IsLeft ? -4f : 4f);
				break;
			case Class57.FingerType.TYPE_RING:
				if (p_hand.IsRight)
				{
					num *= -1f;
				}
				num += Class54.vector2_0[3].y;
				num *= 0.5f;
				break;
			case Class57.FingerType.TYPE_PINKY:
				num += ((!p_hand.IsRight) ? Class54.vector2_0[4].y : Class54.vector2_0[4].x);
				num *= (p_hand.IsRight ? -0.5f : 0.5f);
				break;
			}
			p_spreads[(int)@class.Type] = Mathf.InverseLerp(Class54.vector2_0[(int)@class.Type].x, Class54.vector2_0[(int)@class.Type].y, num);
			if (@class.Type != Class57.FingerType.TYPE_THUMB)
			{
				p_spreads[(int)@class.Type] *= 2f;
				p_spreads[(int)@class.Type] -= 1f;
			}
		}
	}

	// Token: 0x06000355 RID: 853 RVA: 0x00002E8A File Offset: 0x0000108A
	internal static bool Y3Tmt0nyFgbKCmF4Z8G()
	{
		return Class54.tY39u8nCJulZIUV8AA3 == null;
	}

	// Token: 0x04000192 RID: 402
	private static readonly Vector2[] vector2_0 = new Vector2[]
	{
		new Vector2(0f, 15f),
		new Vector2(-20f, 20f),
		new Vector2(-50f, 50f),
		new Vector2(-7.5f, 7.5f),
		new Vector2(-20f, 20f)
	};

	// Token: 0x04000193 RID: 403
	internal static Class54 tY39u8nCJulZIUV8AA3;

	// Token: 0x0200006F RID: 111
	public class Class55
	{
		// Token: 0x06000356 RID: 854 RVA: 0x00011B08 File Offset: 0x0000FD08
		public Class55()
		{
			this.bool_0 = new bool[Class54.Class55.int_0];
			this.vector3_0 = new Vector3[Class54.Class55.int_0];
			this.quaternion_0 = new Quaternion[Class54.Class55.int_0];
			this.float_0 = new float[Class54.Class55.int_1];
			this.float_1 = new float[Class54.Class55.int_1];
			this.float_2 = new float[Class54.Class55.int_1];
			this.float_3 = new float[Class54.Class55.int_1];
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00002E94 File Offset: 0x00001094
		internal static bool jtIs4ZWTT0TPNfX7yXH()
		{
			return Class54.Class55.CbyB0eWaVEPPaY3Mx2v == null;
		}

		// Token: 0x04000194 RID: 404
		public static readonly int int_0 = 2;

		// Token: 0x04000195 RID: 405
		public static readonly int int_1 = 5;

		// Token: 0x04000196 RID: 406
		public bool[] bool_0;

		// Token: 0x04000197 RID: 407
		public Vector3[] vector3_0;

		// Token: 0x04000198 RID: 408
		public Quaternion[] quaternion_0;

		// Token: 0x04000199 RID: 409
		public float[] float_0;

		// Token: 0x0400019A RID: 410
		public float[] float_1;

		// Token: 0x0400019B RID: 411
		public float[] float_2;

		// Token: 0x0400019C RID: 412
		public float[] float_3;

		// Token: 0x0400019D RID: 413
		private static Class54.Class55 CbyB0eWaVEPPaY3Mx2v;
	}
}
