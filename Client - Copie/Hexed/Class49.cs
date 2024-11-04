using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine;
using VRC;
using VRC.Core;
using VRC.SDKBase;
using VRC.Udon;

// Token: 0x0200005D RID: 93
internal class Class49
{
	// Token: 0x060002E8 RID: 744 RVA: 0x00002D1A File Offset: 0x00000F1A
	public static IEnumerator VoiceDistortion()
	{
		return new Class49.<VoiceDistortion>d__1(0);
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x00002D22 File Offset: 0x00000F22
	public static IEnumerator smethod_0(Player player)
	{
		Class49.bool_1 = true;
		string string_0 = null;
		new ApiWorldInstance
		{
			id = "wrld_5b89c79e-c340-4510-be1b-476e9fcdedcc:" + Class109.RandomStringNumber(5)
		}.Fetch(delegate(ApiContainer container)
		{
			new ApiModelContainer<ApiWorldInstance>().setFromContainer(container);
			ApiWorldInstance apiWorldInstance = container.Model.Cast<ApiWorldInstance>();
			if (apiWorldInstance != null)
			{
				string_0 = apiWorldInstance.shortName;
			}
		}, null, null, false, 2);
		while (string_0 == null)
		{
			yield return new WaitForEndOfFrame();
		}
		while (Class49.bool_1 && player != null && Class4.IsInWorld())
		{
			Class117.RaisePortalCreate(string_0, player.transform.position, -1f);
			yield return new WaitForSeconds(3f);
		}
		yield break;
	}

	// Token: 0x060002EA RID: 746 RVA: 0x00010364 File Offset: 0x0000E564
	public static void ListenPlayer(Player player, bool state)
	{
		if (!state)
		{
			player.GetVRCPlayerApi().SetVoiceDistanceFar(25f);
			return;
		}
		player.GetVRCPlayerApi().SetVoiceDistanceFar(float.PositiveInfinity);
	}

	// Token: 0x060002EB RID: 747 RVA: 0x00010398 File Offset: 0x0000E598
	public static void RepeatVoiceEvents(byte[] Data)
	{
		if (Data == null)
		{
			return;
		}
		Buffer.BlockCopy(BitConverter.GetBytes(Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID()), 0, Data, 0, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(Class3.VRCNetworkingClient.Method_Public_get_LoadBalancingPeer_0().ServerTimeInMilliSeconds), 0, Data, 4, 4);
		Class117.OpRaiseEvent(1, Data, null, 1, 2);
	}

	// Token: 0x060002EC RID: 748 RVA: 0x00002D31 File Offset: 0x00000F31
	public static IEnumerator StaticChatbox(string Message)
	{
		if (Message != null && !Class49.bool_2)
		{
			Class49.bool_2 = true;
			while (Class49.bool_2)
			{
				if (Class4.IsInWorld())
				{
					Class117.RaiseChatMessage(Message);
				}
				yield return new WaitForSeconds(3f);
				int num;
				if (num != 1)
				{
					yield break;
				}
			}
			yield break;
		}
		yield break;
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00002D40 File Offset: 0x00000F40
	public static IEnumerator SpotifyChatbox()
	{
		if (!Class49.bool_3)
		{
			Class49.bool_3 = true;
			while (Class49.bool_3)
			{
				if (Class4.IsInWorld())
				{
					Process process = Process.GetProcessesByName("Spotify").FirstOrDefault((Process p) => !string.IsNullOrWhiteSpace(p.MainWindowTitle));
					if (process != null && process.MainWindowTitle != null && process.MainWindowTitle != "Spotify" && process.MainWindowTitle != "Spotify Premium")
					{
						Class117.RaiseChatMessage("\ud83c\udfb5 " + process.MainWindowTitle);
					}
				}
				yield return new WaitForSeconds(3f);
			}
			Class49.bool_3 = false;
			yield break;
		}
		yield break;
	}

	// Token: 0x060002EE RID: 750 RVA: 0x00002D48 File Offset: 0x00000F48
	public static IEnumerator AlwaysTyping()
	{
		return new Class49.<AlwaysTyping>d__11(0);
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00002D50 File Offset: 0x00000F50
	public static IEnumerator UdonSpam(Player player)
	{
		if (!Class49.bool_5)
		{
			Class49.bool_5 = true;
			UdonBehaviour[] allEvents = Object.FindObjectsOfType<UdonBehaviour>();
			while (Class49.bool_5 && player != null && Class4.IsInWorld())
			{
				foreach (UdonBehaviour udonBehaviour in allEvents)
				{
					foreach (string text in udonBehaviour._eventTable.Keys)
					{
						if (!text.StartsWith("_") && player != null)
						{
							Class117.smethod_0(udonBehaviour, text, player, false);
						}
					}
				}
				yield return new WaitForSeconds(1f);
				int num;
				if (num != 1)
				{
					yield break;
				}
			}
			Class49.bool_5 = false;
			yield break;
		}
		yield break;
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x00002D5F File Offset: 0x00000F5F
	public static IEnumerator CameraSounds(Player player)
	{
		if (!Class49.bool_6)
		{
			Class49.bool_6 = true;
			while (Class49.bool_6 && player != null && Class4.IsInWorld())
			{
				Class3.CurrentVRCPlayer.field_Public_UserCameraIndicator_0.transform.position = player.transform.position;
				Class117.SendRPC(14, "", false, -1, Class3.CurrentVRCPlayer.field_Public_UserCameraIndicator_0.gameObject, null, "PhotoCapture", 0f, 0, null, 4, 0f);
				yield return new WaitForSeconds(0.3f);
				int num;
				if (num != 1)
				{
					yield break;
				}
			}
			Class49.bool_6 = false;
			yield break;
		}
		yield break;
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x00002D6E File Offset: 0x00000F6E
	public static IEnumerator Collapse(Player player)
	{
		Class49.bool_7 = true;
		IEnumerable<VRC_Pickup> pickups = from x in Class116.GetAllPickups()
		where (x.GetComponent<Collider>() != null && x.GetComponent<Collider>().enabled) || (x.GetComponentInChildren<Collider>() != null && x.GetComponentInChildren<Collider>().enabled)
		select x;
		while (Class49.bool_7 && player != null && Class4.IsInWorld())
		{
			int num2;
			for (int i = 0; i < 20; i = num2 + 1)
			{
				foreach (VRC_Pickup vrc_Pickup in pickups)
				{
					float num = (float)(i - 1) * 0.05f;
					Class116.TakeOwnershipIfNecessary(vrc_Pickup.gameObject);
					vrc_Pickup.transform.position = player.transform.position + new Vector3(0f, -0.1f + num, 0f);
					vrc_Pickup.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
				}
				yield return new WaitForEndOfFrame();
				num2 = i;
			}
			yield return new WaitForSeconds(0.1f);
			foreach (VRC_Pickup vrc_Pickup2 in pickups)
			{
				Class116.TakeOwnershipIfNecessary(vrc_Pickup2.gameObject);
				vrc_Pickup2.transform.position = Class11.Struct0.Vector3_0;
				vrc_Pickup2.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			}
			yield return new WaitForSeconds(0.1f);
		}
		Class49.bool_7 = false;
		yield break;
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x00002D7D File Offset: 0x00000F7D
	public static IEnumerator MemoryViolation()
	{
		return null;
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x00002D80 File Offset: 0x00000F80
	internal static bool x3x8kTnJhetEsVbokmk()
	{
		return Class49.fAdcM8n8CnocvIGP1ML == null;
	}

	// Token: 0x04000138 RID: 312
	public static bool bool_0;

	// Token: 0x04000139 RID: 313
	public static bool bool_1;

	// Token: 0x0400013A RID: 314
	public static bool bool_2;

	// Token: 0x0400013B RID: 315
	public static bool bool_3;

	// Token: 0x0400013C RID: 316
	public static bool bool_4;

	// Token: 0x0400013D RID: 317
	public static bool bool_5;

	// Token: 0x0400013E RID: 318
	public static bool bool_6;

	// Token: 0x0400013F RID: 319
	public static bool bool_7;

	// Token: 0x04000140 RID: 320
	public static bool bool_8;

	// Token: 0x04000141 RID: 321
	internal static Class49 fAdcM8n8CnocvIGP1ML;
}
