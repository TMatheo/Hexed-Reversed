using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using BestHTTP;
using ExitGames.Client.Photon;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Photon.Realtime;
using VRC;
using VRC.SDKBase;

namespace Hexed.Wrappers
{
	// Token: 0x0200000B RID: 11
	public static class Logger
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00006458 File Offset: 0x00004658
		public static void Log(object obj, Logger.LogsType Type)
		{
			object obj2 = Logger.object_0;
			lock (obj2)
			{
				if (obj == null)
				{
					obj = "NULL";
				}
				string value = obj.ToString().Replace("\a", "a").Replace("\u001b[", "u001B[");
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 3);
				defaultInterpolatedStringHandler.AppendLiteral("[");
				defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now.ToShortTimeString());
				defaultInterpolatedStringHandler.AppendLiteral("] [Hexed] [");
				defaultInterpolatedStringHandler.AppendFormatted<Logger.LogsType>(Type);
				defaultInterpolatedStringHandler.AppendLiteral("] ");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				Class50.writeMessage(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00006528 File Offset: 0x00004728
		public static void LogError(object obj)
		{
			object obj2 = Logger.object_0;
			lock (obj2)
			{
				if (obj == null)
				{
					obj = "NULL";
				}
				string str = obj.ToString().Replace("\a", "a").Replace("\u001b[", "u001B[");
				Class50.writeMessage("[" + DateTime.Now.ToShortTimeString() + "] [Hexed] [ERROR] " + str);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000065BC File Offset: 0x000047BC
		public static void LogWarning(object obj)
		{
			object obj2 = Logger.object_0;
			lock (obj2)
			{
				if (obj == null)
				{
					obj = "NULL";
				}
				string str = obj.ToString().Replace("\a", "a").Replace("\u001b[", "u001B[");
				Class50.writeMessage("[" + DateTime.Now.ToShortTimeString() + "] [Hexed] [WARNING] " + str);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00006650 File Offset: 0x00004850
		public static void LogDebug(object obj)
		{
			object obj2 = Logger.object_0;
			lock (obj2)
			{
				if (obj == null)
				{
					obj = "NULL";
				}
				string str = obj.ToString().Replace("\a", "a").Replace("\u001b[", "u001B[");
				Class50.writeMessage("[" + DateTime.Now.ToShortTimeString() + "] [Hexed] [DEBUG] " + str);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000066E4 File Offset: 0x000048E4
		public static void LogOpRaise(byte Code, Object Object, RaiseEventOptions RaiseOptions, SendOptions SendOptions)
		{
			try
			{
				if (!Logger.byte_1.Contains(Code))
				{
					object obj = (Object != null) ? Class0.Class2.smethod_0(Object) : "NULL";
					string str = (((RaiseOptions != null) ? RaiseOptions.field_Public_Il2CppStructArray_1_Int32_0 : null) == null) ? "NULL" : string.Join<int>(", ", RaiseOptions.field_Public_Il2CppStructArray_1_Int32_0);
					string text = null;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (obj.GetType() == typeof(byte[]))
					{
						text = "  |  ";
						byte[] array = (byte[])obj;
						text += string.Join<byte>(", ", array);
						string str2 = text;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
						defaultInterpolatedStringHandler.AppendLiteral(" [L: ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(array.Length);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						text = str2 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
					else if (obj.GetType() == typeof(ArraySegment<byte>))
					{
						text = "  |  ";
						ArraySegment<byte> arraySegment = (ArraySegment<byte>)obj;
						text += string.Join<byte>(", ", arraySegment.Array);
						string str3 = text;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
						defaultInterpolatedStringHandler.AppendLiteral(" [L: ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(arraySegment.Count);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						text = str3 + defaultInterpolatedStringHandler.ToStringAndClear();
						string str4 = text;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
						defaultInterpolatedStringHandler.AppendLiteral(" [O: ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(arraySegment.Offset);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						text = str4 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
					object[] array2 = new object[24];
					array2[0] = Environment.NewLine;
					int num = 1;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
					defaultInterpolatedStringHandler.AppendLiteral("======= OPRAISEEVENT ");
					defaultInterpolatedStringHandler.AppendFormatted<byte>(Code);
					defaultInterpolatedStringHandler.AppendLiteral(" =======");
					array2[num] = defaultInterpolatedStringHandler.ToStringAndClear();
					array2[2] = Environment.NewLine;
					int num2 = 3;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
					defaultInterpolatedStringHandler.AppendLiteral("TYPE: ");
					defaultInterpolatedStringHandler.AppendFormatted<object>(obj);
					array2[num2] = defaultInterpolatedStringHandler.ToStringAndClear();
					array2[4] = Environment.NewLine;
					array2[5] = "DATA SERIALIZED: " + ((text != null) ? text : JsonSerializer.Serialize<object>(obj, new JsonSerializerOptions
					{
						WriteIndented = true
					}));
					array2[6] = Environment.NewLine;
					array2[7] = "TARGET ACTORS: " + str;
					array2[8] = Environment.NewLine;
					int num3 = 9;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
					defaultInterpolatedStringHandler.AppendLiteral("EVENT CACHING: ");
					defaultInterpolatedStringHandler.AppendFormatted<EventCaching>(RaiseOptions.field_Public_EventCaching_0);
					array2[num3] = defaultInterpolatedStringHandler.ToStringAndClear();
					array2[10] = Environment.NewLine;
					int num4 = 11;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
					defaultInterpolatedStringHandler.AppendLiteral("INTEREST GROUP: ");
					defaultInterpolatedStringHandler.AppendFormatted<byte>(RaiseOptions.field_Public_Byte_0);
					array2[num4] = defaultInterpolatedStringHandler.ToStringAndClear();
					array2[12] = Environment.NewLine;
					int num5 = 13;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
					defaultInterpolatedStringHandler.AppendLiteral("RECEIVER GROUP: ");
					defaultInterpolatedStringHandler.AppendFormatted<ReceiverGroup>(RaiseOptions.field_Public_ReceiverGroup_0);
					array2[num5] = defaultInterpolatedStringHandler.ToStringAndClear();
					array2[14] = Environment.NewLine;
					int num6 = 15;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
					defaultInterpolatedStringHandler.AppendLiteral("CHANNEL: ");
					defaultInterpolatedStringHandler.AppendFormatted<byte>(SendOptions.Channel);
					array2[num6] = defaultInterpolatedStringHandler.ToStringAndClear();
					array2[16] = Environment.NewLine;
					int num7 = 17;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
					defaultInterpolatedStringHandler.AppendLiteral("DELIVERY MODE: ");
					defaultInterpolatedStringHandler.AppendFormatted<DeliveryMode>(SendOptions.DeliveryMode);
					array2[num7] = defaultInterpolatedStringHandler.ToStringAndClear();
					array2[18] = Environment.NewLine;
					int num8 = 19;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
					defaultInterpolatedStringHandler.AppendLiteral("ENCRYPT: ");
					defaultInterpolatedStringHandler.AppendFormatted<bool>(SendOptions.Encrypt);
					array2[num8] = defaultInterpolatedStringHandler.ToStringAndClear();
					array2[20] = Environment.NewLine;
					int num9 = 21;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
					defaultInterpolatedStringHandler.AppendLiteral("RELIABLE: ");
					defaultInterpolatedStringHandler.AppendFormatted<bool>(SendOptions.Reliability);
					array2[num9] = defaultInterpolatedStringHandler.ToStringAndClear();
					array2[22] = Environment.NewLine;
					array2[23] = "======= END =======";
					Logger.Log(string.Concat(array2), Logger.LogsType.Info);
				}
			}
			catch (Exception value)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Failed to Log Event with code ");
				defaultInterpolatedStringHandler.AppendFormatted<byte>(Code);
				defaultInterpolatedStringHandler.AppendLiteral(" with Exception: ");
				defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
				Logger.LogError(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00006B3C File Offset: 0x00004D3C
		public static void LogEventData(EventData EventData)
		{
			try
			{
				if (!Logger.byte_0.Contains(EventData.Code))
				{
					object obj = (EventData.CustomData != null) ? Class0.Class2.smethod_0(EventData.CustomData) : "NULL";
					Player player = null;
					string str = "NULL";
					if (EventData.Sender > 0)
					{
						player = Class3.VRCNetworkingClient.GetPhotonPlayer(EventData.Sender);
					}
					if (player != null)
					{
						str = (player.DisplayName() ?? "NO NAME");
					}
					string text = null;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
					if (!(obj.GetType() == typeof(byte[])))
					{
						if (obj.GetType() == typeof(ArraySegment<byte>))
						{
							text = "  |  ";
							ArraySegment<byte> arraySegment = (ArraySegment<byte>)obj;
							text += string.Join<byte>(", ", arraySegment.Array);
							string str2 = text;
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
							defaultInterpolatedStringHandler.AppendLiteral(" [L: ");
							defaultInterpolatedStringHandler.AppendFormatted<int>(arraySegment.Count);
							defaultInterpolatedStringHandler.AppendLiteral("]");
							text = str2 + defaultInterpolatedStringHandler.ToStringAndClear();
							string str3 = text;
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
							defaultInterpolatedStringHandler.AppendLiteral(" [O: ");
							defaultInterpolatedStringHandler.AppendFormatted<int>(arraySegment.Offset);
							defaultInterpolatedStringHandler.AppendLiteral("]");
							text = str3 + defaultInterpolatedStringHandler.ToStringAndClear();
						}
					}
					else
					{
						text = "  |  ";
						byte[] array = (byte[])obj;
						text += string.Join<byte>(", ", array);
						string str4 = text;
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
						defaultInterpolatedStringHandler.AppendLiteral(" [L: ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(array.Length);
						defaultInterpolatedStringHandler.AppendLiteral("]");
						text = str4 + defaultInterpolatedStringHandler.ToStringAndClear();
					}
					object value = "NULL";
					if (EventData.Parameters != null)
					{
						value = Class0.Class2.smethod_0(EventData.Parameters);
					}
					object[] array2 = new object[16];
					array2[0] = Environment.NewLine;
					int num = 1;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
					defaultInterpolatedStringHandler.AppendLiteral("======= ONEVENT ");
					defaultInterpolatedStringHandler.AppendFormatted<byte>(EventData.Code);
					defaultInterpolatedStringHandler.AppendLiteral(" =======");
					array2[num] = defaultInterpolatedStringHandler.ToStringAndClear();
					array2[2] = Environment.NewLine;
					int num2 = 3;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
					defaultInterpolatedStringHandler.AppendLiteral("ACTOR NUMBER: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(EventData.Sender);
					array2[num2] = defaultInterpolatedStringHandler.ToStringAndClear();
					array2[4] = Environment.NewLine;
					array2[5] = "SENDER NAME: " + str;
					array2[6] = Environment.NewLine;
					int num3 = 7;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
					defaultInterpolatedStringHandler.AppendLiteral("TYPE: ");
					defaultInterpolatedStringHandler.AppendFormatted<object>(obj);
					array2[num3] = defaultInterpolatedStringHandler.ToStringAndClear();
					array2[8] = Environment.NewLine;
					array2[9] = "DATA SERIALIZED: " + ((text == null) ? JsonSerializer.Serialize<object>(obj, new JsonSerializerOptions
					{
						WriteIndented = true
					}) : text);
					array2[10] = Environment.NewLine;
					array2[11] = "PARAMETER SERIALIZED: " + JsonSerializer.Serialize<object>(value, new JsonSerializerOptions
					{
						WriteIndented = true
					});
					array2[12] = Environment.NewLine;
					int num4 = 13;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
					defaultInterpolatedStringHandler.AppendLiteral("MEMORY POINTER: ");
					defaultInterpolatedStringHandler.AppendFormatted<IntPtr>(EventData.Pointer);
					array2[num4] = defaultInterpolatedStringHandler.ToStringAndClear();
					array2[14] = Environment.NewLine;
					array2[15] = "======= END =======";
					Logger.Log(string.Concat(array2), Logger.LogsType.Info);
				}
			}
			catch (Exception value2)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(47, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Failed to Log Event with code ");
				defaultInterpolatedStringHandler.AppendFormatted<byte>(EventData.Code);
				defaultInterpolatedStringHandler.AppendLiteral(" with Exception: ");
				defaultInterpolatedStringHandler.AppendFormatted<Exception>(value2);
				Logger.LogError(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00006EF0 File Offset: 0x000050F0
		public static void LogOperation(byte Code, Dictionary<byte, Object> Params, SendOptions SendOptions)
		{
			try
			{
				if (!Logger.byte_2.Contains(Code))
				{
					object value = Class0.Class2.smethod_0(Params);
					object[] array = new object[14];
					array[0] = Environment.NewLine;
					int num = 1;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
					defaultInterpolatedStringHandler.AppendLiteral("======= OPERATION ");
					defaultInterpolatedStringHandler.AppendFormatted<byte>(Code);
					defaultInterpolatedStringHandler.AppendLiteral(" =======");
					array[num] = defaultInterpolatedStringHandler.ToStringAndClear();
					array[2] = Environment.NewLine;
					array[3] = "DATA SERIALIZED: " + JsonSerializer.Serialize<object>(value, new JsonSerializerOptions
					{
						WriteIndented = true
					});
					array[4] = Environment.NewLine;
					int num2 = 5;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
					defaultInterpolatedStringHandler.AppendLiteral("CHANNEL: ");
					defaultInterpolatedStringHandler.AppendFormatted<byte>(SendOptions.Channel);
					array[num2] = defaultInterpolatedStringHandler.ToStringAndClear();
					array[6] = Environment.NewLine;
					int num3 = 7;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
					defaultInterpolatedStringHandler.AppendLiteral("DELIVERY MODE: ");
					defaultInterpolatedStringHandler.AppendFormatted<DeliveryMode>(SendOptions.DeliveryMode);
					array[num3] = defaultInterpolatedStringHandler.ToStringAndClear();
					array[8] = Environment.NewLine;
					int num4 = 9;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
					defaultInterpolatedStringHandler.AppendLiteral("ENCRYPT: ");
					defaultInterpolatedStringHandler.AppendFormatted<bool>(SendOptions.Encrypt);
					array[num4] = defaultInterpolatedStringHandler.ToStringAndClear();
					array[10] = Environment.NewLine;
					int num5 = 11;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
					defaultInterpolatedStringHandler.AppendLiteral("RELIABLE: ");
					defaultInterpolatedStringHandler.AppendFormatted<bool>(SendOptions.Reliability);
					array[num5] = defaultInterpolatedStringHandler.ToStringAndClear();
					array[12] = Environment.NewLine;
					array[13] = "======= END =======";
					Logger.Log(string.Concat(array), Logger.LogsType.Info);
				}
			}
			catch (Exception value2)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(50, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Failed to Log Operation with code ");
				defaultInterpolatedStringHandler.AppendFormatted<byte>(Code);
				defaultInterpolatedStringHandler.AppendLiteral(" and Exception: ");
				defaultInterpolatedStringHandler.AppendFormatted<Exception>(value2);
				Logger.LogError(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000070D0 File Offset: 0x000052D0
		public static void LogOperationResponse(OperationResponse reponse)
		{
			try
			{
				object value = "NULL";
				if (reponse.Parameters != null)
				{
					value = Class0.Class2.smethod_0(reponse.Parameters);
				}
				object[] array = new object[10];
				array[0] = Environment.NewLine;
				int num = 1;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 1);
				defaultInterpolatedStringHandler.AppendLiteral("======= OPERATION RESPONSE ");
				defaultInterpolatedStringHandler.AppendFormatted<byte>(reponse.OperationCode);
				defaultInterpolatedStringHandler.AppendLiteral(" =======");
				array[num] = defaultInterpolatedStringHandler.ToStringAndClear();
				array[2] = Environment.NewLine;
				array[3] = "PARAMETER SERIALIZED: " + JsonSerializer.Serialize<object>(value, new JsonSerializerOptions
				{
					WriteIndented = true
				});
				array[4] = Environment.NewLine;
				int num2 = 5;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
				defaultInterpolatedStringHandler.AppendLiteral("RETURN CODE: ");
				defaultInterpolatedStringHandler.AppendFormatted<short>(reponse.ReturnCode);
				array[num2] = defaultInterpolatedStringHandler.ToStringAndClear();
				array[6] = Environment.NewLine;
				array[7] = "DEBUG MESSAGE: " + reponse.DebugMessage;
				array[8] = Environment.NewLine;
				array[9] = "======= END =======";
				Logger.Log(string.Concat(array), Logger.LogsType.Info);
			}
			catch (Exception value2)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(59, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Failed to Log Operation Response with code ");
				defaultInterpolatedStringHandler.AppendFormatted<byte>(reponse.OperationCode);
				defaultInterpolatedStringHandler.AppendLiteral(" and Exception: ");
				defaultInterpolatedStringHandler.AppendFormatted<Exception>(value2);
				Logger.LogError(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00007230 File Offset: 0x00005430
		public static void LogRPC(Player Player, VRC_EventHandler.VrcEvent Event, VRC_EventHandler.VrcBroadcastType BroadcastType, int instagatorId, float fastForward, object[] DecodedBytes)
		{
			try
			{
				object[] array = new object[28];
				array[0] = Environment.NewLine;
				array[1] = "======= RPC EVENT =======";
				array[2] = Environment.NewLine;
				int num = 3;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
				defaultInterpolatedStringHandler.AppendLiteral("ACTOR NUMBER: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(instagatorId);
				array[num] = defaultInterpolatedStringHandler.ToStringAndClear();
				array[4] = Environment.NewLine;
				array[5] = "SENDER NAME: " + Player.DisplayName();
				array[6] = Environment.NewLine;
				int num2 = 7;
				string str = "BYTES DECODED: ";
				string str2;
				if (DecodedBytes.Length != 0)
				{
					str2 = string.Join<object>(" | ", from b in DecodedBytes
					where b != null
					select b);
				}
				else
				{
					str2 = "NULL";
				}
				array[num2] = str + str2;
				array[8] = Environment.NewLine;
				int num3 = 9;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
				defaultInterpolatedStringHandler.AppendLiteral("EVENTTYPE: ");
				defaultInterpolatedStringHandler.AppendFormatted<VRC_EventHandler.VrcEventType>(Event.EventType);
				array[num3] = defaultInterpolatedStringHandler.ToStringAndClear();
				array[10] = Environment.NewLine;
				array[11] = "PARAMETER STRING: " + Event.ParameterString;
				array[12] = Environment.NewLine;
				int num4 = 13;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
				defaultInterpolatedStringHandler.AppendLiteral("PARAMETER INT: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(Event.ParameterInt);
				array[num4] = defaultInterpolatedStringHandler.ToStringAndClear();
				array[14] = Environment.NewLine;
				int num5 = 15;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
				defaultInterpolatedStringHandler.AppendLiteral("PARAMETER FLOAT: ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(Event.ParameterFloat);
				array[num5] = defaultInterpolatedStringHandler.ToStringAndClear();
				array[16] = Environment.NewLine;
				int num6 = 17;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
				defaultInterpolatedStringHandler.AppendLiteral("PARAMETER BOOL: ");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(Event.ParameterBool);
				array[num6] = defaultInterpolatedStringHandler.ToStringAndClear();
				array[18] = Environment.NewLine;
				int num7 = 19;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
				defaultInterpolatedStringHandler.AppendLiteral("PARAMETER BOOLOP: ");
				defaultInterpolatedStringHandler.AppendFormatted<VRC_EventHandler.VrcBooleanOp>(Event.ParameterBoolOp);
				array[num7] = defaultInterpolatedStringHandler.ToStringAndClear();
				array[20] = Environment.NewLine;
				int num8 = 21;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
				defaultInterpolatedStringHandler.AppendLiteral("TAKE OWNERSHIP: ");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(Event.TakeOwnershipOfTarget);
				array[num8] = defaultInterpolatedStringHandler.ToStringAndClear();
				array[22] = Environment.NewLine;
				int num9 = 23;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
				defaultInterpolatedStringHandler.AppendLiteral("BROADCAST TYPE: ");
				defaultInterpolatedStringHandler.AppendFormatted<VRC_EventHandler.VrcBroadcastType>(BroadcastType);
				array[num9] = defaultInterpolatedStringHandler.ToStringAndClear();
				array[24] = Environment.NewLine;
				int num10 = 25;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
				defaultInterpolatedStringHandler.AppendLiteral("FAST FORWARD: ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(fastForward);
				array[num10] = defaultInterpolatedStringHandler.ToStringAndClear();
				array[26] = Environment.NewLine;
				array[27] = "======= END =======";
				Logger.Log(string.Concat(array), Logger.LogsType.Info);
			}
			catch (Exception value)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Failed to Log RPC with Exception: ");
				defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
				Logger.LogError(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00007528 File Offset: 0x00005728
		public static void LogApi(HTTPRequest request)
		{
			byte[] array = request.GetEntityBody();
			object[] array2 = new object[12];
			array2[0] = Environment.NewLine;
			array2[1] = "======= API REQUEST =======";
			array2[2] = Environment.NewLine;
			int num = 3;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
			defaultInterpolatedStringHandler.AppendLiteral("METHOD: ");
			defaultInterpolatedStringHandler.AppendFormatted<HTTPMethods>(request.MethodType);
			array2[num] = defaultInterpolatedStringHandler.ToStringAndClear();
			array2[4] = Environment.NewLine;
			int num2 = 5;
			string str = "ENDPOINT: ";
			Uri uri = request.Uri;
			array2[num2] = str + ((uri != null) ? uri.ToString() : null);
			array2[6] = Environment.NewLine;
			array2[7] = "CONTENT: " + ((array != null) ? Encoding.UTF8.GetString(array) : "NULL");
			array2[8] = Environment.NewLine;
			array2[9] = "HEADER: \n" + request.DumpHeaders();
			array2[10] = Environment.NewLine;
			array2[11] = "======= END =======";
			Logger.Log(string.Concat(array2), Logger.LogsType.Info);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002478 File Offset: 0x00000678
		internal static bool R8YKJgSgaWWR3PLlU2d()
		{
			return Logger.CvVBQFSr8F9oJgy734J == null;
		}

		// Token: 0x04000012 RID: 18
		private static readonly object object_0 = new object();

		// Token: 0x04000013 RID: 19
		private static readonly byte[] byte_0 = new byte[]
		{
			1,
			8,
			35,
			66
		};

		// Token: 0x04000014 RID: 20
		private static readonly byte[] byte_1 = new byte[]
		{
			8,
			66
		};

		// Token: 0x04000015 RID: 21
		private static readonly byte[] byte_2 = new byte[]
		{
			253
		};

		// Token: 0x04000016 RID: 22
		internal static Logger CvVBQFSr8F9oJgy734J;

		// Token: 0x0200000C RID: 12
		public enum LogsType
		{
			// Token: 0x04000018 RID: 24
			Info,
			// Token: 0x04000019 RID: 25
			Protection,
			// Token: 0x0400001A RID: 26
			Room,
			// Token: 0x0400001B RID: 27
			Friends,
			// Token: 0x0400001C RID: 28
			Chat,
			// Token: 0x0400001D RID: 29
			Group,
			// Token: 0x0400001E RID: 30
			Bot
		}
	}
}
