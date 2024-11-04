using System;
using System.Collections;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using Il2CppSystem;
using Photon.Realtime;
using UnityEngine;
using VRC;
using VRC.SDKBase;
using VRC.Udon;

// Token: 0x02000119 RID: 281
internal class Class117
{
	// Token: 0x06000591 RID: 1425 RVA: 0x0001C2D0 File Offset: 0x0001A4D0
	public static void OpRaiseEvent(byte code, object customObject, RaiseEventOptions RaiseEventOptions, byte Channel, DeliveryMode deliveryMode)
	{
		SendOptions sendOptions = default(SendOptions);
		sendOptions.Channel = Channel;
		sendOptions.DeliveryMode = deliveryMode;
		sendOptions.Encrypt = true;
		sendOptions.Reliability = (deliveryMode == 1 || deliveryMode == 3);
		SendOptions sendOptions2 = sendOptions;
		Class117.OpRaiseEvent(code, Class0.Class2.ManagedToIL(customObject), RaiseEventOptions, sendOptions2);
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x0001C328 File Offset: 0x0001A528
	public static void OpRaiseEvent(byte code, Object customObject, RaiseEventOptions RaiseEventOptions, SendOptions sendOptions)
	{
		Class3.VRCNetworkingClient.Method_Public_Virtual_New_Boolean_Byte_Object_RaiseEventOptions_SendOptions_0(code, customObject, RaiseEventOptions, sendOptions);
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x0001C344 File Offset: 0x0001A544
	public static void SendRPC(VRC_EventHandler.VrcEventType EventType, string Name, bool ParameterBool, VRC_EventHandler.VrcBooleanOp BoolOP, GameObject ParamObject, GameObject[] ParamObjects, string ParamString, float Float, int Int, byte[] bytes, VRC_EventHandler.VrcBroadcastType BroadcastType, float Fastforward = 0f)
	{
		VRC_EventHandler.VrcEvent vrcEvent = new VRC_EventHandler.VrcEvent
		{
			EventType = EventType,
			Name = Name,
			ParameterBool = ParameterBool,
			ParameterBoolOp = BoolOP,
			ParameterBytes = bytes,
			ParameterObject = ParamObject,
			ParameterObjects = ParamObjects,
			ParameterString = ParamString,
			ParameterFloat = Float,
			ParameterInt = Int
		};
		Networking.SceneEventHandler.TriggerEvent(vrcEvent, BroadcastType, ParamObject, Fastforward);
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x0001C3C0 File Offset: 0x0001A5C0
	public static void smethod_0(UdonBehaviour behaviour, string EventName, Player Target = null, bool Local = false)
	{
		if (!(behaviour != null))
		{
			foreach (UdonBehaviour udonBehaviour in Object.FindObjectsOfType<UdonBehaviour>())
			{
				if (udonBehaviour._eventTable.ContainsKey(EventName))
				{
					udonBehaviour.SendCustomNetworkEvent(0, EventName);
				}
			}
			return;
		}
		if (Target != null)
		{
			if (!Networking.IsOwner(Target.GetVRCPlayerApi(), behaviour.gameObject))
			{
				Networking.SetOwner(Target.GetVRCPlayerApi(), behaviour.gameObject);
			}
			behaviour.SendCustomNetworkEvent(1, EventName);
			return;
		}
		if (!Local)
		{
			behaviour.SendCustomNetworkEvent(0, EventName);
			return;
		}
		behaviour.SendCustomEvent(EventName);
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x0001C478 File Offset: 0x0001A678
	public static void RaiseChatMessage(string Message)
	{
		if (Message != null && Message.Length <= 144)
		{
			SendOptions sendOptions = default(SendOptions);
			sendOptions.Channel = 0;
			sendOptions.DeliveryMode = 1;
			sendOptions.Encrypt = true;
			sendOptions.Reliability = true;
			SendOptions sendOptions2 = sendOptions;
			RaiseEventOptions raiseEventOptions = new RaiseEventOptions
			{
				field_Public_ReceiverGroup_0 = 1
			};
			Class117.OpRaiseEvent(43, Message, raiseEventOptions, sendOptions2);
			return;
		}
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x0001C4E4 File Offset: 0x0001A6E4
	public static void RaiseTypingIndicator(byte Type)
	{
		RaiseEventOptions raiseEventOptions = new RaiseEventOptions
		{
			field_Public_ReceiverGroup_0 = 1
		};
		Class117.OpRaiseEvent(44, Type, raiseEventOptions, 0, 1);
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x0001C510 File Offset: 0x0001A710
	public static void smethod_1(bool VR)
	{
		Class117.OpRaiseEvent(42, new Hashtable
		{
			{
				"inVRMode",
				VR
			}
		}, new RaiseEventOptions(), 0, 1);
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x0001C544 File Offset: 0x0001A744
	public static void RaiseAvatarHeight(int Height)
	{
		Class117.OpRaiseEvent(42, new Hashtable
		{
			{
				"avatarEyeHeight",
				Height
			}
		}, new RaiseEventOptions(), 0, 1);
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x0001C578 File Offset: 0x0001A778
	public static void RaiseGroupOnNameplate(string GroupID)
	{
		if (GroupID == null)
		{
			return;
		}
		Class117.OpRaiseEvent(42, new Hashtable
		{
			{
				"groupOnNameplate",
				GroupID
			}
		}, new RaiseEventOptions(), 0, 1);
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x0001C5A8 File Offset: 0x0001A7A8
	public static void RaiseBlock(string userid, bool Block)
	{
		if (userid.StartsWith("usr_"))
		{
			Class117.OpRaiseEvent(33, new Dictionary<byte, object>
			{
				{
					3,
					Block
				},
				{
					0,
					22
				},
				{
					1,
					userid
				}
			}, new RaiseEventOptions(), 0, 1);
			return;
		}
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x0001C5FC File Offset: 0x0001A7FC
	public static void RaisePortalCreate(string InstanceID, Vector3 Position, float Rotation)
	{
		if (InstanceID == null)
		{
			return;
		}
		byte[] dst = new byte[12];
		Buffer.BlockCopy(BitConverter.GetBytes(Position.x), 0, dst, 0, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(Position.y), 0, dst, 4, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(Position.z), 0, dst, 8, 4);
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x0001C658 File Offset: 0x0001A858
	public static void RaiseEmojiCreate(int ID)
	{
		Class117.OpRaiseEvent(71, new Dictionary<byte, object>
		{
			{
				0,
				0
			},
			{
				2,
				ID
			}
		}, new RaiseEventOptions(), 0, 1);
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x0001C694 File Offset: 0x0001A894
	public static void RaiseEmojiCreate(string ID)
	{
		if (ID != null)
		{
			Class117.OpRaiseEvent(71, new Dictionary<byte, object>
			{
				{
					0,
					1
				},
				{
					1,
					ID
				}
			}, new RaiseEventOptions(), 0, 1);
			return;
		}
	}

	// Token: 0x0600059E RID: 1438 RVA: 0x0001C6D0 File Offset: 0x0001A8D0
	public static void RaiseSyncOwnership(int viewId, int Owner)
	{
		Class117.OpRaiseEvent(21, new int[]
		{
			viewId,
			Owner
		}, new RaiseEventOptions
		{
			field_Public_ReceiverGroup_0 = 1
		}, 0, 1);
	}

	// Token: 0x0600059F RID: 1439 RVA: 0x0001C700 File Offset: 0x0001A900
	public static void RaiseItemOwnership(int viewId, int Owner)
	{
		Class117.OpRaiseEvent(22, new int[]
		{
			viewId,
			Owner
		}, new RaiseEventOptions
		{
			field_Public_ReceiverGroup_0 = 1
		}, 0, 1);
	}

	// Token: 0x060005A0 RID: 1440 RVA: 0x0001C730 File Offset: 0x0001A930
	public static void RaiseLegacyOwnership(int viewId, int Owner)
	{
		Class117.OpRaiseEvent(210, new int[]
		{
			viewId,
			Owner
		}, new RaiseEventOptions
		{
			field_Public_ReceiverGroup_0 = 1
		}, 0, 1);
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x0000335B File Offset: 0x0000155B
	internal static bool K3WoFaIbs9vURWB9aYT()
	{
		return Class117.D1K6V6Ic3FXavwxnfCM == null;
	}

	// Token: 0x0400029C RID: 668
	internal static Class117 D1K6V6Ic3FXavwxnfCM;
}
