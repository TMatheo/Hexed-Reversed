using System;
using UnityEngine;
using VRC;

// Token: 0x0200006B RID: 107
internal class Class52
{
	// Token: 0x06000344 RID: 836 RVA: 0x00010EA4 File Offset: 0x0000F0A4
	public static void CustomSerialize(bool Toggle, bool TeleportBack = false)
	{
		if (Toggle)
		{
			Class52.CreateCapsule();
			Class52.bool_0 = true;
			Class132.qmtoggleButton_0.SetToggleState(true);
			Class124.qmtoggleButton_0.SetToggleState(true);
			return;
		}
		if (!Class52.bool_1)
		{
			if (Class52.gameObject_0 != null)
			{
				if (TeleportBack)
				{
					Class3.CurrentPlayer.transform.position = Class52.gameObject_0.transform.position;
				}
				Object.Destroy(Class52.gameObject_0);
			}
			Class52.bool_0 = false;
			Class52.bool_1 = false;
			Class52.byte_0 = null;
			Class132.qmtoggleButton_0.SetToggleState(false);
			Class124.qmtoggleButton_0.SetToggleState(false);
			return;
		}
		Class52.bool_1 = false;
		Class52.CustomSerialize(false, true);
		if (Class52.player_0 != null)
		{
			Class52.player_0.GetVRCAvatarManager().Method_Public_get_GameObject_0().SetActive(true);
			Class52.player_0 = null;
		}
	}

	// Token: 0x06000345 RID: 837 RVA: 0x00010F74 File Offset: 0x0000F174
	private static void CreateCapsule()
	{
		Class52.gameObject_0 = Object.Instantiate<GameObject>(Class3.CurrentPlayer.GetVRCAvatarManager().Method_Public_get_GameObject_0(), null);
		Class52.gameObject_0.name = "Clone Capsule";
		Class52.gameObject_0.transform.position = Class3.CurrentPlayer.transform.position;
		Class52.gameObject_0.transform.rotation = Class3.CurrentPlayer.transform.rotation;
		Animator component = Class52.gameObject_0.GetComponent<Animator>();
		if (component != null)
		{
			if (component.isHuman)
			{
				Transform boneTransform = component.GetBoneTransform(10);
				if (boneTransform != null)
				{
					boneTransform.localScale = Vector3.one;
				}
			}
			component.enabled = false;
		}
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00011030 File Offset: 0x0000F230
	public static void AddBotSerialize(Player Bot = null)
	{
		Class52.player_0 = Bot;
		Class52.bool_1 = true;
		Class3.CurrentPlayer.transform.position = Class52.player_0.transform.position;
		Class52.player_0.GetVRCAvatarManager().Method_Public_get_GameObject_0().SetActive(false);
	}

	// Token: 0x06000349 RID: 841 RVA: 0x00002E76 File Offset: 0x00001076
	internal static bool vXmcQInFbCw7hafN3y2()
	{
		return Class52.Pu3CfHndJJPne9J9cd3 == null;
	}

	// Token: 0x04000172 RID: 370
	private static GameObject gameObject_0;

	// Token: 0x04000173 RID: 371
	public static bool bool_0 = false;

	// Token: 0x04000174 RID: 372
	public static byte[] byte_0;

	// Token: 0x04000175 RID: 373
	public static bool bool_1 = false;

	// Token: 0x04000176 RID: 374
	public static int int_0 = -2;

	// Token: 0x04000177 RID: 375
	public static Player player_0;

	// Token: 0x04000178 RID: 376
	private static Class52 Pu3CfHndJJPne9J9cd3;
}
