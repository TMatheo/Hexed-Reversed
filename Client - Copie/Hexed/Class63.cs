using System;
using RootMotion.FinalIK;
using UnityEngine;
using VRC.FingerTracking;
using VRC.Networking.Pose;

// Token: 0x0200007A RID: 122
internal class Class63
{
	// Token: 0x0600038B RID: 907 RVA: 0x00011FEC File Offset: 0x000101EC
	private static void ReorientateLeapToUnity(ref Vector3 p_pos, ref Quaternion p_rot)
	{
		p_pos *= 0.001f;
		p_pos.z *= -1f;
		p_rot.x *= -1f;
		p_rot.y *= -1f;
	}

	// Token: 0x0600038C RID: 908 RVA: 0x0001203C File Offset: 0x0001023C
	public static void UpdateFingers(HandProcessor fingerController, bool LeftHand, bool RightHand)
	{
		if (!(fingerController.field_Private_VRC_AnimationController_0 == null))
		{
			fingerController.field_Private_Boolean_0 = true;
			PoseRecorder.field_Internal_Static_Int32_0 |= 512;
			for (int i = 0; i < 5; i++)
			{
				if (LeftHand)
				{
					float num = (Class56.class55_0.float_1[i] * 2f - 1f) / 5f * 0.5f + 0.5f;
					float num2 = (Class56.class55_0.float_0[i] * 2f - 1f) / 5f * 0.5f + 0.5f;
					fingerController.field_Private_Il2CppStructArray_1_Single_0[i] = 1f - num2;
					fingerController.field_Private_Il2CppStructArray_1_Single_1[i] = num;
				}
				if (RightHand)
				{
					float num3 = (Class56.class55_0.float_3[i] * 2f - 1f) / 5f * 0.5f + 0.5f;
					float num4 = (Class56.class55_0.float_2[i] * 2f - 1f) / 5f * 0.5f + 0.5f;
					fingerController.field_Private_Il2CppStructArray_1_Single_0[i + 5] = 1f - num4;
					fingerController.field_Private_Il2CppStructArray_1_Single_1[i + 5] = num3;
				}
			}
			return;
		}
	}

	// Token: 0x0600038D RID: 909 RVA: 0x00012194 File Offset: 0x00010394
	public static void LateUpdateIK(IKSolverVR p_solver, bool LeftHand, bool RightHand, Transform p_left, Transform p_right)
	{
		if (Class56.class58_0 != null)
		{
			Class54.GetGestures(Class56.class58_0, ref Class56.class55_0);
			for (int i = 0; i < Class54.Class55.int_0; i++)
			{
				if (Class56.class55_0.bool_0[i] && Class56.gameObject_1[i] != null)
				{
					Vector3 localPosition = Class56.class55_0.vector3_0[i];
					Quaternion localRotation = Class56.class55_0.quaternion_0[i];
					Class63.ReorientateLeapToUnity(ref localPosition, ref localRotation);
					Class56.gameObject_1[i].transform.localPosition = localPosition;
					Class56.gameObject_1[i].transform.localRotation = localRotation;
				}
			}
			if (LeftHand && p_solver.leftArm != null)
			{
				p_solver.leftArm.positionWeight = 1f;
				p_solver.leftArm.rotationWeight = 1f;
				if (p_solver.leftArm.target != null)
				{
					p_solver.leftArm.target.position = p_left.position;
					p_solver.leftArm.target.rotation = p_left.rotation;
				}
			}
			if (RightHand && p_solver.rightArm != null)
			{
				p_solver.rightArm.positionWeight = 1f;
				p_solver.rightArm.rotationWeight = 1f;
				if (p_solver.rightArm.target != null)
				{
					p_solver.rightArm.target.position = p_right.position;
					p_solver.rightArm.target.rotation = p_right.rotation;
				}
			}
			return;
		}
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00002F6E File Offset: 0x0000116E
	internal static bool sFcssSn7HPO7PGTI9lg()
	{
		return Class63.BsnKLxnjel4QpcHTmFe == null;
	}

	// Token: 0x040001CA RID: 458
	internal static Class63 BsnKLxnjel4QpcHTmFe;
}
