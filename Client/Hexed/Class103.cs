using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using ExitGames.Client.Photon;
using Hexed.Wrappers;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Photon.Realtime;
using VRC.Core;

// Token: 0x020000F7 RID: 247
internal class Class103 : Interface3
{
	// Token: 0x06000507 RID: 1287 RVA: 0x00019528 File Offset: 0x00017728
	public void Initialize()
	{
		MethodInfo method = typeof(VRCNetworkingClient).GetMethod("Method_Public_Virtual_New_Boolean_Byte_Object_RaiseEventOptions_SendOptions_0");
		Class103.Delegate34 detour;
		if ((detour = Class103.<>O.delegate34_0) == null)
		{
			detour = (Class103.<>O.delegate34_0 = new Class103.Delegate34(Class103.Patch));
		}
		Class103.delegate34_0 = HookManager.Detour<Class103.Delegate34>(method, detour);
	}

	// Token: 0x06000508 RID: 1288 RVA: 0x00019570 File Offset: 0x00017770
	private static bool Patch(IntPtr instance, byte __0, IntPtr __1, IntPtr __2, SendOptions __3)
	{
		Object @object = (__1 == IntPtr.Zero) ? null : new Object(__1);
		RaiseEventOptions raiseEventOptions = (__2 == IntPtr.Zero) ? null : new RaiseEventOptions(__2);
		if (Class143.bool_1)
		{
			Logger.LogOpRaise(__0, @object, raiseEventOptions, __3);
		}
		if (__0 <= 53)
		{
			switch (__0)
			{
			case 1:
			{
				byte[] array = (byte[])Class0.Class2.smethod_0(@object);
				Class66.list_0.Add(Convert.ToBase64String(array.Skip(8).ToArray<byte>()));
				if (Class52.bool_1)
				{
					Class48.SelfbotVoice(Convert.ToBase64String(array));
					return false;
				}
				goto IL_95C;
			}
			case 2:
			case 9:
			case 14:
			case 15:
			case 18:
			case 19:
			case 20:
			case 24:
			case 25:
			case 26:
			case 27:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
				break;
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 10:
			case 16:
			case 17:
			case 21:
			case 22:
			case 23:
				goto IL_95C;
			case 8:
			{
				Class143.InterestMode interestMode_ = Class143.interestMode_0;
				if (interestMode_ == Class143.InterestMode.Reversed)
				{
					int[] array2 = InterestManager.field_Private_Static_InterestManager_0.field_Private_Il2CppStructArray_1_Int32_0;
					byte[] array3 = new byte[array2.Length * 12];
					int num = 0;
					foreach (int num2 in array2)
					{
						if (num2 != Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
						{
							Array.Copy(BitConverter.GetBytes(int.Parse(num2.ToString() + "00001")), 0, array3, num, 4);
							num += 4;
							array3[num++] = 1;
							array3[num++] = byte.MaxValue;
							Array.Copy(BitConverter.GetBytes(int.Parse(num2.ToString() + "00003")), 0, array3, num, 4);
							num += 4;
							array3[num++] = 1;
							array3[num++] = byte.MaxValue;
						}
					}
					@object = Class0.Class2.ManagedToIL(array3);
					__1 = @object.Pointer;
					goto IL_95C;
				}
				if (interestMode_ != Class143.InterestMode.All)
				{
					goto IL_95C;
				}
				byte[] array5 = new byte[(Class3.VRCNetworkingClient.GetActorCount() - 1) * 12];
				int num3 = 0;
				foreach (Player player in Class3.VRCNetworkingClient.GetAllPhotonPlayers())
				{
					if (player.ActorID() != Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
					{
						Array.Copy(BitConverter.GetBytes(int.Parse(player.ActorID().ToString() + "00001")), 0, array5, num3, 4);
						num3 += 4;
						array5[num3++] = 1;
						array5[num3++] = byte.MaxValue;
						Array.Copy(BitConverter.GetBytes(int.Parse(player.ActorID().ToString() + "00003")), 0, array5, num3, 4);
						num3 += 4;
						array5[num3++] = 1;
						array5[num3++] = byte.MaxValue;
					}
				}
				@object = Class0.Class2.ManagedToIL(array5);
				__1 = @object.Pointer;
				goto IL_95C;
			}
			case 11:
				if (Class49.bool_8)
				{
					goto IL_95C;
				}
				goto IL_95C;
			case 12:
			{
				byte[] array6 = (byte[])Class0.Class2.smethod_0(@object);
				int num4 = (int)(array6[19] + 19);
				if (array6.Length > num4 && Class143.bool_36)
				{
					int num5 = num4 + 1;
					if (array6.Length >= num5 + 12)
					{
						Buffer.BlockCopy(BitConverter.GetBytes(Class11.Struct0.float_0), 0, array6, num5, 4);
						Buffer.BlockCopy(BitConverter.GetBytes(Class11.Struct0.float_0), 0, array6, num5 + 4, 4);
						Buffer.BlockCopy(BitConverter.GetBytes(Class11.Struct0.float_0), 0, array6, num5 + 8, 4);
					}
				}
				int num6 = (int)(array6[18] + 18);
				if (array6.Length > num6)
				{
					Class143.FrameAndPingMode frameAndPingMode = Class143.frameAndPingMode_1;
					if (frameAndPingMode != Class143.FrameAndPingMode.Custom)
					{
						if (frameAndPingMode == Class143.FrameAndPingMode.Realistic)
						{
							int count = 2;
							int num7 = num6 + 0;
							if (array6.Length >= num7 + 2)
							{
								Buffer.BlockCopy(BitConverter.GetBytes(Convert.ToInt16(Class109.random_0.Next(4, 16))), 0, array6, num7, count);
							}
						}
					}
					else
					{
						int count2 = 2;
						int num8 = num6 + 0;
						if (array6.Length >= num8 + 2)
						{
							Buffer.BlockCopy(BitConverter.GetBytes(Class143.short_0), 0, array6, num8, count2);
						}
					}
					switch (Class143.latencyMode_0)
					{
					case Class143.LatencyMode.Custom:
					{
						int num9 = num6 + 2;
						if (array6.Length >= num9 + 1)
						{
							array6[num9] = Class143.byte_0;
						}
						break;
					}
					case Class143.LatencyMode.Low:
					{
						int num10 = num6 + 2;
						if (array6.Length >= num10 + 1)
						{
							array6[num10] = 0;
						}
						break;
					}
					case Class143.LatencyMode.High:
					{
						int num11 = num6 + 2;
						if (array6.Length >= num11 + 1)
						{
							array6[num11] = byte.MaxValue;
						}
						break;
					}
					}
					frameAndPingMode = Class143.frameAndPingMode_0;
					if (frameAndPingMode != Class143.FrameAndPingMode.Custom)
					{
						if (frameAndPingMode == Class143.FrameAndPingMode.Realistic)
						{
							int num12 = num6 + 3;
							if (array6.Length >= num12 + 1)
							{
								array6[num12] = Convert.ToByte(Class109.random_0.Next(5, 9));
							}
						}
					}
					else
					{
						int num13 = num6 + 3;
						if (array6.Length >= num13 + 1)
						{
							array6[num13] = ((Class143.int_0 == 0) ? 0 : Convert.ToByte(Math.Min(255, Math.Max(0, 1000 / Class143.int_0))));
						}
					}
				}
				int num14 = (int)(array6[17] + 17);
				if (array6.Length > num14)
				{
					Class143.MicStateMode micStateMode_ = Class143.micStateMode_0;
					if (micStateMode_ != Class143.MicStateMode.Muted)
					{
						if (micStateMode_ == Class143.MicStateMode.Unmuted)
						{
							int num15 = num14 + 7;
							if (array6.Length >= num15 + 1)
							{
								byte[] array7 = array6;
								int num16 = num15;
								array7[num16] &= 191;
							}
						}
					}
					else
					{
						int num17 = num14 + 7;
						if (array6.Length >= num17 + 1)
						{
							byte[] array8 = array6;
							int num18 = num17;
							array8[num18] |= 64;
						}
					}
					Class143.EarmuffStateMode earmuffStateMode_ = Class143.earmuffStateMode_0;
					if (earmuffStateMode_ != Class143.EarmuffStateMode.Enabled)
					{
						if (earmuffStateMode_ == Class143.EarmuffStateMode.Disabled)
						{
							int num19 = num14 + 7;
							if (array6.Length >= num19 + 1)
							{
								byte[] array9 = array6;
								int num20 = num19;
								array9[num20] &= 223;
							}
						}
					}
					else
					{
						int num21 = num14 + 7;
						if (array6.Length >= num21 + 1)
						{
							byte[] array10 = array6;
							int num22 = num21;
							array10[num22] |= 32;
						}
					}
				}
				if (array6.Length > num4 && array6.Length > num6)
				{
					if (Class52.bool_0)
					{
						if (Class52.byte_0 != null)
						{
							if (Class52.bool_1)
							{
								Class48.SelfbotMovement(Convert.ToBase64String(array6));
							}
							int value = BitConverter.ToInt32(array6, 0);
							int value2 = BitConverter.ToInt32(array6, 4);
							int num23 = num6;
							byte b = array6[num23++];
							byte b2 = array6[num23++];
							byte b3 = array6[num23++];
							byte b4 = array6[num23++];
							byte b5 = array6[num23++];
							array6 = Class52.byte_0;
							Buffer.BlockCopy(BitConverter.GetBytes(value), 0, array6, 0, 4);
							Buffer.BlockCopy(BitConverter.GetBytes(value2), 0, array6, 4, 4);
							int num24 = (int)(array6[18] + 18);
							array6[num24++] = b;
							array6[num24++] = b2;
							array6[num24++] = b3;
							array6[num24++] = b4;
							array6[num24++] = b5;
						}
						else
						{
							Class52.byte_0 = array6;
						}
					}
					else if (Class143.bool_20)
					{
						int num25 = Class109.random_0.Next(1, 9);
						byte[] array11 = array6;
						int num26 = 17;
						array11[num26] += (byte)num25;
						byte[] array12 = array6;
						int num27 = 18;
						array12[num27] += (byte)num25;
						byte[] array13 = array6;
						int num28 = 19;
						array13[num28] += (byte)num25;
						byte item = array6[20];
						array6[20] = (byte)Class109.random_0.Next(0, 255);
						List<byte> list = array6.ToList<byte>();
						List<byte> list2 = new List<byte>();
						for (int j = 0; j < num25 - 1; j++)
						{
							list2.Add((byte)Class109.random_0.Next(0, 255));
						}
						list2.Add(item);
						list.InsertRange(21, list2);
						array6 = list.ToArray();
					}
				}
				if (Class143.bool_34)
				{
					__0 = 7;
				}
				@object = Class0.Class2.ManagedToIL(array6);
				__1 = @object.Pointer;
				Class66.list_0.Add(Convert.ToBase64String(array6.Skip(8).ToArray<byte>()));
				goto IL_95C;
			}
			case 13:
				if (Class52.bool_1)
				{
					Class48.SelfbotAvatarSync(Convert.ToBase64String((byte[])Class0.Class2.smethod_0(@object)));
					return false;
				}
				goto IL_95C;
			case 33:
				if (!Class67.RaisedModerationEvent((Dictionary<byte, object>)Class0.Class2.smethod_0(@object)))
				{
					return false;
				}
				goto IL_95C;
			default:
				switch (__0)
				{
				case 40:
					goto IL_95C;
				case 41:
					break;
				case 42:
					if (!Class69.RaisedPropEvent(@object.TryCast<Hashtable>()))
					{
						return false;
					}
					goto IL_95C;
				case 43:
					if (!Class64.RaisedChatEvent(Class0.Class2.smethod_0(@object).ToString()))
					{
						return false;
					}
					goto IL_95C;
				case 44:
					if (Class52.bool_1)
					{
						return false;
					}
					goto IL_95C;
				default:
					if (__0 == 53)
					{
						goto IL_95C;
					}
					break;
				}
				break;
			}
		}
		else if (__0 <= 74)
		{
			if (__0 == 60)
			{
				goto IL_95C;
			}
			switch (__0)
			{
			case 66:
			case 70:
			case 73:
				goto IL_95C;
			case 71:
				if (!Class65.RaisedEmojiEvent((Dictionary<byte, object>)Class0.Class2.smethod_0(@object)))
				{
					return false;
				}
				goto IL_95C;
			case 74:
				if (!Class35.RaisedContentShare((Dictionary<byte, object>)Class0.Class2.smethod_0(@object)))
				{
					return false;
				}
				goto IL_95C;
			}
		}
		else if (__0 != 202)
		{
			if (__0 == 210)
			{
				goto IL_95C;
			}
		}
		else
		{
			if (Class143.bool_39)
			{
				raiseEventOptions.field_Public_ReceiverGroup_0 = 255;
				bool result = Class103.delegate34_0(instance, __0, __1, raiseEventOptions.Pointer, __3);
				raiseEventOptions.field_Public_ReceiverGroup_0 = 0;
				return result;
			}
			goto IL_95C;
		}
		Logger.LogWarning("Not implemented OpRaiseEvent");
		Logger.LogOpRaise(__0, @object, raiseEventOptions, __3);
		IL_95C:
		return Class103.delegate34_0(instance, __0, __1, __2, __3);
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x000031B2 File Offset: 0x000013B2
	internal static bool oJZ2kRT0OFn1GHRSDVq()
	{
		return Class103.DB0oRoTAG92qmENL0yJ == null;
	}

	// Token: 0x04000260 RID: 608
	private static Class103.Delegate34 delegate34_0;

	// Token: 0x04000261 RID: 609
	internal static Class103 DB0oRoTAG92qmENL0yJ;

	// Token: 0x020000F8 RID: 248
	// (Invoke) Token: 0x0600050C RID: 1292
	private delegate bool Delegate34(IntPtr instance, byte __0, IntPtr __1, IntPtr __2, SendOptions __3);

	// Token: 0x020000F9 RID: 249
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000262 RID: 610
		public static Class103.Delegate34 delegate34_0;
	}
}
