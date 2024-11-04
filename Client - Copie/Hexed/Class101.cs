using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CoreRuntime.Manager;
using ExitGames.Client.Photon;
using Hexed.Wrappers;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Photon.Realtime;
using VRC.Core;

// Token: 0x020000F1 RID: 241
internal class Class101 : Interface3
{
	// Token: 0x060004F7 RID: 1271 RVA: 0x00018648 File Offset: 0x00016848
	public void Initialize()
	{
		MethodInfo method = typeof(VRCNetworkingClient).GetMethod("OnEvent");
		Class101.Delegate32 detour;
		if ((detour = Class101.<>O.delegate32_0) == null)
		{
			detour = (Class101.<>O.delegate32_0 = new Class101.Delegate32(Class101.Patch));
		}
		Class101.delegate32_0 = HookManager.Detour<Class101.Delegate32>(method, detour);
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x00018690 File Offset: 0x00016890
	private static void Patch(IntPtr instance, IntPtr __0)
	{
		EventData eventData = (__0 == IntPtr.Zero) ? null : new EventData(__0);
		if (eventData == null)
		{
			return;
		}
		if (Class143.bool_0)
		{
			Logger.LogEventData(eventData);
		}
		byte code = eventData.Code;
		if (code > 202)
		{
			if (code > 223)
			{
				if (code == 226)
				{
					goto IL_D07;
				}
				switch (code)
				{
				case 253:
					goto IL_D07;
				case 254:
				{
					Player photonPlayer = Class3.VRCNetworkingClient.GetPhotonPlayer(eventData.Sender);
					if (photonPlayer != null)
					{
						string text = photonPlayer.DisplayName() ?? "NO NAME";
						string value = photonPlayer.UserID() ?? "NO USERID";
						Class142.DestroyPlayerModules(photonPlayer.ActorID());
						Class66.RemoveActorBlocks(eventData.Sender);
						if (Class143.dictionary_0.ContainsKey(eventData.Sender))
						{
							Class143.dictionary_0.Remove(eventData.Sender);
						}
						if (Class8.dictionary_0.ContainsKey(eventData.Sender))
						{
							Class8.dictionary_0.Remove(eventData.Sender);
						}
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
						defaultInterpolatedStringHandler.AppendLiteral("[ - ] ");
						defaultInterpolatedStringHandler.AppendFormatted(text);
						defaultInterpolatedStringHandler.AppendLiteral(" [");
						defaultInterpolatedStringHandler.AppendFormatted(value);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
						Class53.Log(text ?? "", Class53.LogsType.Disconnect);
					}
					if (!eventData.Parameters.ContainsKey(203))
					{
						goto IL_D07;
					}
					int photonID = eventData[203].Unbox<int>();
					Player photonPlayer2 = Class3.VRCNetworkingClient.GetPhotonPlayer(photonID);
					if (photonPlayer2 == null)
					{
						Logger.Log("Prevented Server from setting invalid Master", Logger.LogsType.Protection);
						Class53.Log("Server --> Invalid Master Client", Class53.LogsType.Protection);
						return;
					}
					string str = photonPlayer2.DisplayName() ?? "NO NAME";
					Logger.Log(str + " is now Master", Logger.LogsType.Room);
					Class53.Log(str + " --> Master Client", Class53.LogsType.Room);
					goto IL_D07;
				}
				case 255:
				{
					string text2 = "NO NAME";
					string value2 = "NO USERID";
					Hashtable hashtable = eventData[249].TryCast<Hashtable>();
					if (hashtable != null && hashtable.ContainsKey("user"))
					{
						Dictionary<string, Object> dictionary = hashtable["user"].TryCast<Dictionary<string, Object>>();
						if (dictionary != null)
						{
							if (dictionary.ContainsKey("displayName"))
							{
								Object @object = dictionary["displayName"];
								text2 = ((@object != null) ? @object.ToString() : null);
							}
							if (dictionary.ContainsKey("id"))
							{
								Object object2 = dictionary["id"];
								value2 = ((object2 != null) ? object2.ToString() : null);
							}
						}
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
					defaultInterpolatedStringHandler.AppendLiteral("[ + ] ");
					defaultInterpolatedStringHandler.AppendFormatted(text2);
					defaultInterpolatedStringHandler.AppendLiteral(" [");
					defaultInterpolatedStringHandler.AppendFormatted(value2);
					defaultInterpolatedStringHandler.AppendLiteral("]");
					Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
					Class53.Log(text2 ?? "", Class53.LogsType.Connect);
					goto IL_D07;
				}
				}
			}
			else if (code != 210)
			{
				if (code == 223)
				{
					goto IL_D07;
				}
			}
			else
			{
				if (eventData.CustomData == null || Class66.IsActorEventBlocked(eventData.Sender, (int)eventData.Code))
				{
					return;
				}
				int[] array = (int[])Class0.Class2.smethod_0(eventData.CustomData);
				if (!Class66.SanitizeEvent210(eventData.Sender, array, eventData.Code))
				{
					return;
				}
				Class143.AntiPickupMode antiPickupMode_ = Class143.antiPickupMode_0;
				if (antiPickupMode_ != Class143.AntiPickupMode.Self)
				{
					if (antiPickupMode_ != Class143.AntiPickupMode.Nobody)
					{
						goto IL_D07;
					}
					if (Class116.IsViewIdPickupable(array[0]) && array[1] != 0)
					{
						Class117.RaiseLegacyOwnership(array[0], 0);
						return;
					}
					goto IL_D07;
				}
				else
				{
					if (Class116.IsViewIdPickupable(array[0]) && array[1] != Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
					{
						Class117.RaiseLegacyOwnership(array[0], Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID());
						return;
					}
					goto IL_D07;
				}
			}
		}
		else if (code <= 60)
		{
			switch (code)
			{
			case 1:
			{
				if (eventData.CustomData == null || Class66.IsActorEventBlocked(eventData.Sender, (int)eventData.Code))
				{
					return;
				}
				byte[] data = (byte[])Class0.Class2.smethod_0(eventData.CustomData);
				if (!Class66.SanitizeEvent1(eventData.Sender, data, eventData.Code))
				{
					return;
				}
				if (eventData.Sender == Class143.int_1)
				{
					Class49.RepeatVoiceEvents(data);
					goto IL_D07;
				}
				goto IL_D07;
			}
			case 2:
				if (eventData.CustomData != null)
				{
					Logger.Log("The Server disconnected you: " + JsonSerializer.Serialize<object>(Class0.Class2.smethod_0(eventData.CustomData), null), Logger.LogsType.Room);
					Class53.Log("Server --> Disconnect", Class53.LogsType.Moderation);
					goto IL_D07;
				}
				return;
			case 3:
			{
				string str2 = Class3.VRCNetworkingClient.GetPhotonPlayer(eventData.Sender).DisplayName() ?? "NO NAME";
				Logger.Log(str2 + " requested Cache", Logger.LogsType.Room);
				Class53.Log(str2 + " --> Cache request", Class53.LogsType.Room);
				goto IL_D07;
			}
			case 4:
			{
				if (eventData.CustomData == null || Class66.IsActorEventBlocked(eventData.Sender, (int)eventData.Code))
				{
					return;
				}
				byte[][] array2 = (byte[][])Class0.Class2.smethod_0(eventData.CustomData);
				if (Class66.SanitizeEvent4(eventData.Sender, array2, eventData.Code))
				{
					string value3 = Class3.VRCNetworkingClient.GetPhotonPlayer(eventData.Sender).DisplayName() ?? "NO NAME";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
					defaultInterpolatedStringHandler.AppendFormatted(value3);
					defaultInterpolatedStringHandler.AppendLiteral(" sent Cache with ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(array2.Length);
					defaultInterpolatedStringHandler.AppendLiteral(" Events");
					Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
					defaultInterpolatedStringHandler.AppendFormatted(value3);
					defaultInterpolatedStringHandler.AppendLiteral(" --> Cache [");
					defaultInterpolatedStringHandler.AppendFormatted<int>(array2.Length);
					defaultInterpolatedStringHandler.AppendLiteral("]");
					Class53.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Class53.LogsType.Room);
					goto IL_D07;
				}
				return;
			}
			case 5:
			{
				string str3 = Class3.VRCNetworkingClient.GetPhotonPlayer(eventData.Sender).DisplayName() ?? "NO NAME";
				Logger.Log(str3 + " confirmed join", Logger.LogsType.Room);
				Class53.Log(str3 + " --> Join confirmation", Class53.LogsType.Room);
				goto IL_D07;
			}
			case 6:
			{
				if (eventData.CustomData == null || Class66.IsActorEventBlocked(eventData.Sender, (int)eventData.Code))
				{
					return;
				}
				byte[] data2 = (byte[])Class0.Class2.smethod_0(eventData.CustomData);
				if (!Class66.SanitizeEvent6(eventData.Sender, data2, eventData.Code))
				{
					return;
				}
				goto IL_D07;
			}
			case 7:
			{
				if (eventData.CustomData == null || Class66.IsActorEventBlocked(eventData.Sender, (int)eventData.Code))
				{
					return;
				}
				byte[] data3 = (byte[])Class0.Class2.smethod_0(eventData.CustomData);
				if (!Class66.SanitizeEvent7(eventData.Sender, data3, eventData.Code))
				{
					return;
				}
				goto IL_D07;
			}
			case 8:
			case 20:
			case 23:
			case 26:
			case 40:
			case 44:
			case 51:
			case 53:
				goto IL_D07;
			case 9:
			case 14:
			case 15:
			case 18:
			case 19:
			case 24:
			case 25:
			case 27:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 36:
			case 37:
			case 38:
			case 39:
			case 41:
			case 45:
			case 46:
			case 47:
			case 48:
			case 49:
			case 50:
			case 52:
				break;
			case 10:
			{
				if (eventData.CustomData == null || Class66.IsActorEventBlocked(eventData.Sender, (int)eventData.Code))
				{
					return;
				}
				byte[] data4 = (byte[])Class0.Class2.smethod_0(eventData.CustomData);
				if (!Class66.SanitizeEvent10(eventData.Sender, data4, eventData.Code))
				{
					return;
				}
				goto IL_D07;
			}
			case 11:
			{
				if (Class143.bool_33 || eventData.CustomData == null || Class66.IsActorEventBlocked(eventData.Sender, (int)eventData.Code))
				{
					return;
				}
				byte[] data5 = (byte[])Class0.Class2.smethod_0(eventData.CustomData);
				if (!Class66.SanitizeEvent11(eventData.Sender, data5, eventData.Code))
				{
					return;
				}
				goto IL_D07;
			}
			case 12:
			{
				if (eventData.CustomData == null || Class66.IsActorEventBlocked(eventData.Sender, (int)eventData.Code))
				{
					return;
				}
				byte[] data6 = (byte[])Class0.Class2.smethod_0(eventData.CustomData);
				if (Class66.SanitizeEvent12(eventData.Sender, data6, eventData.Code))
				{
					Class143.dictionary_0[eventData.Sender] = Class5.GetUnixTimeInMilliseconds();
					goto IL_D07;
				}
				return;
			}
			case 13:
			{
				if (eventData.CustomData == null || Class66.IsActorEventBlocked(eventData.Sender, (int)eventData.Code))
				{
					return;
				}
				byte[] data7 = (byte[])Class0.Class2.smethod_0(eventData.CustomData);
				if (!Class66.SanitizeEvent13(eventData.Sender, data7, eventData.Code))
				{
					return;
				}
				goto IL_D07;
			}
			case 16:
			{
				if (eventData.CustomData == null || Class66.IsActorEventBlocked(eventData.Sender, (int)eventData.Code))
				{
					return;
				}
				byte[] data8 = (byte[])Class0.Class2.smethod_0(eventData.CustomData);
				if (!Class66.SanitizeEvent16(eventData.Sender, data8, eventData.Code))
				{
					return;
				}
				goto IL_D07;
			}
			case 17:
			{
				if (eventData.CustomData == null || Class66.IsActorEventBlocked(eventData.Sender, (int)eventData.Code))
				{
					return;
				}
				byte[] data9 = (byte[])Class0.Class2.smethod_0(eventData.CustomData);
				if (!Class66.SanitizeEvent17(eventData.Sender, data9, eventData.Code))
				{
					return;
				}
				goto IL_D07;
			}
			case 21:
			{
				if (eventData.CustomData == null || Class66.IsActorEventBlocked(eventData.Sender, (int)eventData.Code))
				{
					return;
				}
				int[] array3 = (int[])Class0.Class2.smethod_0(eventData.CustomData);
				if (!Class66.SanitizeEvent21(eventData.Sender, array3, eventData.Code))
				{
					return;
				}
				Class143.AntiPickupMode antiPickupMode_ = Class143.antiPickupMode_0;
				if (antiPickupMode_ != Class143.AntiPickupMode.Self)
				{
					if (antiPickupMode_ != Class143.AntiPickupMode.Nobody)
					{
						goto IL_D07;
					}
					if (Class116.IsViewIdPickupable(array3[0]) && array3[1] != 0)
					{
						Class117.RaiseSyncOwnership(array3[0], 0);
						return;
					}
					goto IL_D07;
				}
				else
				{
					if (Class116.IsViewIdPickupable(array3[0]) && array3[1] != Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
					{
						Class117.RaiseSyncOwnership(array3[0], Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID());
						return;
					}
					goto IL_D07;
				}
				break;
			}
			case 22:
			{
				if (eventData.CustomData == null || Class66.IsActorEventBlocked(eventData.Sender, (int)eventData.Code))
				{
					return;
				}
				int[] array4 = (int[])Class0.Class2.smethod_0(eventData.CustomData);
				if (!Class66.SanitizeEvent22(eventData.Sender, array4, eventData.Code))
				{
					return;
				}
				Class143.AntiPickupMode antiPickupMode_ = Class143.antiPickupMode_0;
				if (antiPickupMode_ != Class143.AntiPickupMode.Self)
				{
					if (antiPickupMode_ != Class143.AntiPickupMode.Nobody)
					{
						goto IL_D07;
					}
					if (Class116.IsViewIdPickupable(array4[0]) && array4[1] != 0)
					{
						Class117.RaiseItemOwnership(array4[0], 0);
						return;
					}
					goto IL_D07;
				}
				else
				{
					if (Class116.IsViewIdPickupable(array4[0]) && array4[1] != Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
					{
						Class117.RaiseItemOwnership(array4[0], Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID());
						return;
					}
					goto IL_D07;
				}
				break;
			}
			case 33:
			{
				Dictionary<byte, object> data10 = (Dictionary<byte, object>)Class0.Class2.smethod_0(eventData.CustomData);
				if (Class67.ReceivedModerationEvent(ref data10))
				{
					eventData.customData = Class0.Class2.ManagedToIL(data10);
					__0 = eventData.Pointer;
					goto IL_D07;
				}
				return;
			}
			case 34:
				Logger.Log("Prevented Server from adjusting Ratelimits", Logger.LogsType.Protection);
				Class53.Log("Server --> Ratelimit Adjust", Class53.LogsType.Protection);
				eventData.customData = null;
				__0 = eventData.Pointer;
				goto IL_D07;
			case 35:
				Class66.list_0.Clear();
				goto IL_D07;
			case 42:
				if (eventData.CustomData == null || !Class69.ReceivedPropEvent(eventData.CustomData.TryCast<Hashtable>(), Class3.VRCNetworkingClient.GetPhotonPlayer(eventData.Sender)))
				{
					return;
				}
				goto IL_D07;
			case 43:
			{
				if (eventData.CustomData == null || Class66.IsActorEventBlocked(eventData.Sender, (int)eventData.Code))
				{
					return;
				}
				Player photonPlayer3 = Class3.VRCNetworkingClient.GetPhotonPlayer(eventData.Sender);
				if (!Class64.ReceivedChatEvent(eventData.CustomData.ToString(), photonPlayer3, eventData.Code))
				{
					return;
				}
				goto IL_D07;
			}
			default:
				if (code == 60)
				{
					goto IL_D07;
				}
				break;
			}
		}
		else
		{
			switch (code)
			{
			case 66:
			case 70:
			case 72:
			case 73:
				goto IL_D07;
			case 67:
			case 68:
			case 69:
				break;
			case 71:
			{
				if (eventData.CustomData == null || Class66.IsActorEventBlocked(eventData.Sender, (int)eventData.Code))
				{
					return;
				}
				Player photonPlayer4 = Class3.VRCNetworkingClient.GetPhotonPlayer(eventData.Sender);
				if (!Class65.ReceivedEmojiEvent((Dictionary<byte, object>)Class0.Class2.smethod_0(eventData.CustomData), photonPlayer4, eventData.Code))
				{
					return;
				}
				goto IL_D07;
			}
			case 74:
				if (eventData.CustomData != null && Class35.RecievedContentShare((Dictionary<byte, object>)Class0.Class2.smethod_0(eventData.CustomData), eventData.Code))
				{
					goto IL_D07;
				}
				return;
			default:
				if (code == 202)
				{
					if (eventData.CustomData == null || !Class66.SanitizeEvent202(eventData.Sender, eventData.CustomData.Cast<Hashtable>(), eventData.Code))
					{
						return;
					}
					goto IL_D07;
				}
				break;
			}
		}
		Logger.LogWarning("Not implemented OnEvent, blocked for Protection");
		Logger.LogEventData(eventData);
		return;
		IL_D07:
		Class101.delegate32_0(instance, __0);
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x0000319E File Offset: 0x0000139E
	internal static bool Urgn0wT4fMwOjDTxP7O()
	{
		return Class101.RecCIjTEV3EExYvmKxM == null;
	}

	// Token: 0x0400025A RID: 602
	private static Class101.Delegate32 delegate32_0;

	// Token: 0x0400025B RID: 603
	private static Class101 RecCIjTEV3EExYvmKxM;

	// Token: 0x020000F2 RID: 242
	// (Invoke) Token: 0x060004FC RID: 1276
	private delegate void Delegate32(IntPtr instance, IntPtr __0);

	// Token: 0x020000F3 RID: 243
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400025C RID: 604
		public static Class101.Delegate32 delegate32_0;
	}
}
