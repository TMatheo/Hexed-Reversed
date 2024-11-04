using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Hexed.Wrappers;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Photon.Realtime;
using UnityEngine;
using VRC;
using VRC.Core;
using VRC.SDKBase;

// Token: 0x0200007F RID: 127
internal class Class66
{
	// Token: 0x0600039E RID: 926 RVA: 0x00012824 File Offset: 0x00010A24
	public static bool IsActorEventBlocked(int Actor, int Code)
	{
		if (!Class66.dictionary_0.ContainsKey(Actor))
		{
			Class66.dictionary_0[Actor] = new List<int>();
		}
		return Class66.dictionary_0[Actor].Contains(Code);
	}

	// Token: 0x0600039F RID: 927 RVA: 0x00012864 File Offset: 0x00010A64
	public static void RemoveActorBlocks(int Actor)
	{
		if (Class66.dictionary_0.ContainsKey(Actor))
		{
			Class66.dictionary_0.Remove(Actor);
		}
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x0001288C File Offset: 0x00010A8C
	public static void ClearEventBlocks()
	{
		Class66.dictionary_0.Clear();
		Class66.list_0.Clear();
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x000128B0 File Offset: 0x00010AB0
	public static void LimitActor(int Actor, byte EventCode, string Reason, int Seconds = 20)
	{
		if (!Class66.IsActorEventBlocked(Actor, (int)EventCode))
		{
			Class66.dictionary_0[Actor].Add((int)EventCode);
			Class5.DelayAction((float)Seconds, delegate
			{
				if (Class66.dictionary_0.ContainsKey(Actor) && Class66.dictionary_0[Actor].Contains((int)EventCode))
				{
					Class66.dictionary_0[Actor].Remove((int)EventCode);
				}
			}).Start();
			Player photonPlayer = Class3.VRCNetworkingClient.GetPhotonPlayer(Actor);
			if (photonPlayer != null)
			{
				string value = photonPlayer.DisplayName() ?? "NO NAME";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 4);
				defaultInterpolatedStringHandler.AppendLiteral("Limiting ");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral(" Event ");
				defaultInterpolatedStringHandler.AppendFormatted<byte>(EventCode);
				defaultInterpolatedStringHandler.AppendLiteral(" for ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(Seconds);
				defaultInterpolatedStringHandler.AppendLiteral(" Seconds [");
				defaultInterpolatedStringHandler.AppendFormatted(Reason);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Protection);
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral(" --> Invalid Event [");
				defaultInterpolatedStringHandler.AppendFormatted<byte>(EventCode);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Class53.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Class53.LogsType.Protection);
			}
			return;
		}
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00012A10 File Offset: 0x00010C10
	public static bool IsValidServertime(int Time, int difference = 60000)
	{
		return Time >= Class3.VRCNetworkingClient.Method_Public_get_LoadBalancingPeer_0().ServerTimeInMilliSeconds - difference && Time <= Class3.VRCNetworkingClient.Method_Public_get_LoadBalancingPeer_0().ServerTimeInMilliSeconds + difference;
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00012A48 File Offset: 0x00010C48
	public static bool SanitizeEvent1(int Actor, byte[] Data, byte Code)
	{
		bool result;
		try
		{
			if (BitConverter.ToInt32(Data, 0) != Actor)
			{
				Class66.LimitActor(Actor, Code, "Invalid Actor", 20);
				result = false;
			}
			else if (!Class66.IsValidServertime(BitConverter.ToInt32(Data, 4), 60000))
			{
				Class66.LimitActor(Actor, Code, "Invalid Time", 20);
				result = false;
			}
			else
			{
				Player photonPlayer = Class3.VRCNetworkingClient.GetPhotonPlayer(Actor);
				if (photonPlayer != null)
				{
					Player player = photonPlayer.GetPlayer();
					if (player == null)
					{
						Class66.LimitActor(Actor, Code, "Invalid VRCPlayer", 20);
						result = false;
					}
					else if (player._USpeaker.field_Private_Single_22 < 0.05f)
					{
						player._USpeaker.field_Private_Single_22 = 0.5f;
						Class66.LimitActor(Actor, Code, "Invalid Scale", 20);
						result = false;
					}
					else
					{
						string item = Convert.ToBase64String(Data.Skip(8).ToArray<byte>());
						if (!Class66.list_0.Contains(item))
						{
							Class66.list_0.Add(item);
							result = true;
						}
						else
						{
							Class66.LimitActor(Actor, Code, "Blacklisted", 20);
							result = false;
						}
					}
				}
				else
				{
					Class66.LimitActor(Actor, Code, "Invalid PhotonPlayer", 20);
					result = false;
				}
			}
		}
		catch
		{
			Class66.LimitActor(Actor, Code, "Exception", 20);
			result = false;
		}
		return result;
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00012B9C File Offset: 0x00010D9C
	public static bool SanitizeEvent4(int Actor, byte[][] Data, byte Code)
	{
		bool result;
		try
		{
			foreach (byte[] array in Data)
			{
				Object @object;
				try
				{
					BinarySerializer.Method_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Object_0(array, ref @object);
					if (@object == null)
					{
						Class66.LimitActor(Actor, Code, "Invalid EventLog", 20);
						return false;
					}
				}
				catch
				{
					Class66.LimitActor(Actor, Code, "Invalid EventLog", 20);
					return false;
				}
				VRC_EventLog.ObjectNPublicInVrInStSiInObSiByVrUnique objectNPublicInVrInStSiInObSiByVrUnique = @object.TryCast<VRC_EventLog.ObjectNPublicInVrInStSiInObSiByVrUnique>();
				if (objectNPublicInVrInStSiInObSiByVrUnique == null)
				{
					Class66.LimitActor(Actor, Code, "Invalid RPC Entry", 20);
					return false;
				}
				if (objectNPublicInVrInStSiInObSiByVrUnique.Method_Public_get_VrcEvent_0() == null)
				{
					Class66.LimitActor(Actor, Code, "Invalid VRCEvent", 20);
					return false;
				}
				if (objectNPublicInVrInStSiInObSiByVrUnique.Method_Public_get_VrcEvent_0().EventType > 34 || objectNPublicInVrInStSiInObSiByVrUnique.Method_Public_get_VrcEvent_0().EventType < 0)
				{
					Class66.LimitActor(Actor, Code, "Invalid Type", 20);
					return false;
				}
				if (objectNPublicInVrInStSiInObSiByVrUnique.Method_Public_get_String_0() == null)
				{
					Class66.LimitActor(Actor, Code, "Invalid Path", 20);
					return false;
				}
				if (!objectNPublicInVrInStSiInObSiByVrUnique.Method_Public_get_String_0().All(delegate(char c)
				{
					bool flag;
					if (!(flag = (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == ':' || c == '/')))
					{
						bool flag2;
						if (c != ' ')
						{
							if (c != '(')
							{
								flag2 = false;
								goto IL_36;
							}
						}
						flag2 = true;
						IL_36:
						flag = flag2;
					}
					return flag || c == ')' || c == '-' || c == '_';
				}))
				{
					Class66.LimitActor(Actor, Code, "Invalid Path", 20);
					return false;
				}
				GameObject gameObject;
				try
				{
					gameObject = Network.Method_Public_Static_GameObject_String_Boolean_0(objectNPublicInVrInStSiInObSiByVrUnique.Method_Public_get_String_0(), false);
				}
				catch
				{
					Class66.LimitActor(Actor, Code, "Invalid GameObject", 20);
					return false;
				}
				if (gameObject != null && (Class11.IsBadPosition(gameObject.transform.position) || Class11.IsBadDistance(Class3.CurrentPlayer.transform.position, gameObject.transform.position) || Class11.IsBadRotation(gameObject.transform.rotation)))
				{
					Class66.LimitActor(Actor, Code, "Invalid Position", 20);
					return false;
				}
				try
				{
					if (ParameterSerialization.Method_Public_Static_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Byte_0(objectNPublicInVrInStSiInObSiByVrUnique.Method_Public_get_VrcEvent_0().ParameterBytes) == null)
					{
						Class66.LimitActor(Actor, Code, "Invalid Parameters", 20);
						return false;
					}
				}
				catch
				{
					Class66.LimitActor(Actor, Code, "Invalid Parameters", 20);
					return false;
				}
			}
			result = true;
		}
		catch
		{
			Class66.LimitActor(Actor, Code, "Exception", 20);
			result = false;
		}
		return result;
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00012E40 File Offset: 0x00011040
	public static bool SanitizeEvent6(int Actor, byte[] Data, byte Code)
	{
		bool result;
		try
		{
			if (!Class66.IsValidServertime(BitConverter.ToInt32(Data, 1), 60000))
			{
				Class66.LimitActor(Actor, Code, "Invalid Time", 20);
				result = false;
			}
			else if (BitConverter.ToInt32(Data, 5) != Actor)
			{
				Class66.LimitActor(Actor, Code, "Invalid Actor", 20);
				result = false;
			}
			else
			{
				Object @object;
				try
				{
					BinarySerializer.Method_Public_Static_Boolean_Il2CppStructArray_1_Byte_byref_Object_0(Data, ref @object);
					if (@object == null)
					{
						Class66.LimitActor(Actor, Code, "Invalid EventLog", 20);
						return false;
					}
				}
				catch
				{
					Class66.LimitActor(Actor, Code, "Invalid EventLog", 20);
					return false;
				}
				VRC_EventLog.ObjectNPublicInVrInStSiInObSiByVrUnique objectNPublicInVrInStSiInObSiByVrUnique = @object.TryCast<VRC_EventLog.ObjectNPublicInVrInStSiInObSiByVrUnique>();
				if (objectNPublicInVrInStSiInObSiByVrUnique == null)
				{
					Class66.LimitActor(Actor, Code, "Invalid RPC Entry", 20);
					result = false;
				}
				else if (objectNPublicInVrInStSiInObSiByVrUnique.Method_Public_get_VrcEvent_0() != null)
				{
					if (objectNPublicInVrInStSiInObSiByVrUnique.Method_Public_get_VrcEvent_0().EventType <= 34 && objectNPublicInVrInStSiInObSiByVrUnique.Method_Public_get_VrcEvent_0().EventType >= 0)
					{
						if (objectNPublicInVrInStSiInObSiByVrUnique.Method_Public_get_String_0() != null)
						{
							if (objectNPublicInVrInStSiInObSiByVrUnique.Method_Public_get_String_0().All(delegate(char c)
							{
								bool flag;
								if (!(flag = (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == ':' || c == '/')))
								{
									bool flag2;
									if (c != ' ')
									{
										if (c != '(')
										{
											flag2 = false;
											goto IL_36;
										}
									}
									flag2 = true;
									IL_36:
									flag = flag2;
								}
								return flag || c == ')' || c == '-' || c == '_';
							}))
							{
								GameObject gameObject;
								try
								{
									gameObject = Network.Method_Public_Static_GameObject_String_Boolean_0(objectNPublicInVrInStSiInObSiByVrUnique.Method_Public_get_String_0(), false);
								}
								catch
								{
									Class66.LimitActor(Actor, Code, "Invalid GameObject", 20);
									return false;
								}
								if (gameObject != null && (Class11.IsBadPosition(gameObject.transform.position) || Class11.IsBadDistance(Class3.CurrentPlayer.transform.position, gameObject.transform.position) || Class11.IsBadRotation(gameObject.transform.rotation)))
								{
									Class66.LimitActor(Actor, Code, "Invalid Position", 20);
									result = false;
								}
								else
								{
									try
									{
										if (ParameterSerialization.Method_Public_Static_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Byte_0(objectNPublicInVrInStSiInObSiByVrUnique.Method_Public_get_VrcEvent_0().ParameterBytes) == null)
										{
											Class66.LimitActor(Actor, Code, "Invalid Parameters", 20);
											return false;
										}
									}
									catch
									{
										Class66.LimitActor(Actor, Code, "Invalid Parameters", 20);
										return false;
									}
									string item = Convert.ToBase64String(Data);
									if (Class66.list_0.Contains(item))
									{
										if (objectNPublicInVrInStSiInObSiByVrUnique.Method_Public_get_VrcEvent_0().ParameterString != "UdonSyncRunProgramAsRPC")
										{
											Class66.LimitActor(Actor, Code, "Blacklisted", 20);
										}
										result = false;
									}
									else
									{
										Class66.list_0.Add(item);
										result = true;
									}
								}
							}
							else
							{
								Class66.LimitActor(Actor, Code, "Invalid Path", 20);
								result = false;
							}
						}
						else
						{
							Class66.LimitActor(Actor, Code, "Invalid Path", 20);
							result = false;
						}
					}
					else
					{
						Class66.LimitActor(Actor, Code, "Invalid Type", 20);
						result = false;
					}
				}
				else
				{
					Class66.LimitActor(Actor, Code, "Invalid VRCEvent", 20);
					result = false;
				}
			}
		}
		catch
		{
			Class66.LimitActor(Actor, Code, "Exception", 20);
			result = false;
		}
		return result;
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00013154 File Offset: 0x00011354
	public static bool SanitizeEvent7(int Actor, byte[] Data, byte Code)
	{
		bool result;
		try
		{
			if (!BitConverter.ToInt32(Data, 0).ToString().EndsWith("00001"))
			{
				result = Class66.SanitizeEvent17(Actor, Data, Code);
			}
			else
			{
				result = Class66.SanitizeEvent12(Actor, Data, Code);
			}
		}
		catch
		{
			Class66.LimitActor(Actor, Code, "Exception", 20);
			result = false;
		}
		return result;
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x000131BC File Offset: 0x000113BC
	public static bool SanitizeEvent10(int Actor, byte[] Data, byte Code)
	{
		bool result;
		try
		{
			if (BitConverter.ToInt32(Data, 0) < 0)
			{
				Class66.LimitActor(Actor, Code, "Invalid Actor", 20);
				result = false;
			}
			else if (Class66.IsValidServertime(BitConverter.ToInt32(Data, 4), 60000))
			{
				string item = Convert.ToBase64String(Data);
				if (!Class66.list_0.Contains(item))
				{
					Class66.list_0.Add(item);
					result = true;
				}
				else
				{
					Class66.LimitActor(Actor, Code, "Blacklisted", 20);
					result = false;
				}
			}
			else
			{
				Class66.LimitActor(Actor, Code, "Invalid Time", 20);
				result = false;
			}
		}
		catch
		{
			Class66.LimitActor(Actor, Code, "Exception", 20);
			result = false;
		}
		return result;
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x00013270 File Offset: 0x00011470
	public static bool SanitizeEvent11(int Actor, byte[] Data, byte Code)
	{
		bool result;
		try
		{
			if (BitConverter.ToInt32(Data, 0) < 0)
			{
				Class66.LimitActor(Actor, Code, "Invalid Actor", 20);
				result = false;
			}
			else if (!Class66.IsValidServertime(BitConverter.ToInt32(Data, 4), 60000))
			{
				Class66.LimitActor(Actor, Code, "Invalid Time", 20);
				result = false;
			}
			else
			{
				string item = Convert.ToBase64String(Data);
				if (!Class66.list_0.Contains(item))
				{
					Class66.list_0.Add(item);
					result = true;
				}
				else
				{
					Class66.LimitActor(Actor, Code, "Blacklisted", 20);
					result = false;
				}
			}
		}
		catch
		{
			Class66.LimitActor(Actor, Code, "Exception", 20);
			result = false;
		}
		return result;
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x00013328 File Offset: 0x00011528
	public static bool SanitizeEvent12(int Actor, byte[] Data, byte Code)
	{
		bool result;
		try
		{
			if (BitConverter.ToInt32(Data, 0) != int.Parse(Actor.ToString() + "00001"))
			{
				Class66.LimitActor(Actor, Code, "Invalid Actor", 20);
				result = false;
			}
			else if (Class66.IsValidServertime(BitConverter.ToInt32(Data, 4), 60000))
			{
				int num = (int)(17 + Data[17]);
				int num2 = (int)(18 + Data[18]);
				int num3 = (int)(19 + Data[19]);
				if (Data.Length >= num && Data.Length >= num2 && Data.Length >= num3)
				{
					int num4 = num3 + 1;
					float num5 = BitConverter.ToSingle(Data, num4);
					float num6 = BitConverter.ToSingle(Data, num4 + 4);
					float num7 = BitConverter.ToSingle(Data, num4 + 8);
					Vector3 vector;
					vector..ctor(num5, num6, num7);
					if (!Class11.IsBadPosition(vector) && !Class11.IsBadDistance(Class3.CurrentPlayer.transform.position, vector))
					{
						Quaternion v = default(Quaternion);
						QuantizedSerialization.Method_Private_Static_Void_Il2CppStructArray_1_Byte_byref_Quaternion_PDM_2(Data.Skip(num4 + 12).Take(5).ToArray<byte>(), ref v);
						if (Class11.IsBadRotation(v))
						{
							Class66.LimitActor(Actor, Code, "Invalid Player Rotation", 20);
							result = false;
						}
						else
						{
							string item = Convert.ToBase64String(Data.Skip(8).ToArray<byte>());
							if (!Class66.list_0.Contains(item))
							{
								Class66.list_0.Add(item);
								result = true;
							}
							else
							{
								Class66.LimitActor(Actor, Code, "Blacklisted", 20);
								result = false;
							}
						}
					}
					else
					{
						Class66.LimitActor(Actor, Code, "Invalid Player Position", 20);
						result = false;
					}
				}
				else
				{
					Class66.LimitActor(Actor, Code, "Invalid Offsets", 20);
					result = false;
				}
			}
			else
			{
				Class66.LimitActor(Actor, Code, "Invalid Time", 20);
				result = false;
			}
		}
		catch
		{
			Class66.LimitActor(Actor, Code, "Exception", 20);
			result = false;
		}
		return result;
	}

	// Token: 0x060003AA RID: 938 RVA: 0x00013510 File Offset: 0x00011710
	public static bool SanitizeEvent13(int Actor, byte[] Data, byte Code)
	{
		bool result;
		try
		{
			if (BitConverter.ToInt32(Data, 0) != int.Parse(Actor.ToString() + "00003"))
			{
				Class66.LimitActor(Actor, Code, "Invalid Actor", 20);
				result = false;
			}
			else if (Class66.IsValidServertime(BitConverter.ToInt32(Data, 4), 60000))
			{
				string item = Convert.ToBase64String(Data);
				if (Class66.list_0.Contains(item))
				{
					Class66.LimitActor(Actor, Code, "Blacklisted", 20);
					result = false;
				}
				else
				{
					Class66.list_0.Add(item);
					result = true;
				}
			}
			else
			{
				Class66.LimitActor(Actor, Code, "Invalid Time", 20);
				result = false;
			}
		}
		catch
		{
			Class66.LimitActor(Actor, Code, "Exception", 20);
			result = false;
		}
		return result;
	}

	// Token: 0x060003AB RID: 939 RVA: 0x000135D8 File Offset: 0x000117D8
	public static bool SanitizeEvent16(int Actor, byte[] Data, byte Code)
	{
		bool result;
		try
		{
			if (BitConverter.ToInt32(Data, 0) < 0)
			{
				Class66.LimitActor(Actor, Code, "Invalid Actor", 20);
				result = false;
			}
			else if (!Class66.IsValidServertime(BitConverter.ToInt32(Data, 4), 60000))
			{
				Class66.LimitActor(Actor, Code, "Invalid Time", 20);
				result = false;
			}
			else
			{
				int num = (int)(Data[16] + 16 + 1);
				float num2 = BitConverter.ToSingle(Data, num);
				float num3 = BitConverter.ToSingle(Data, num + 4);
				float num4 = BitConverter.ToSingle(Data, num + 8);
				Vector3 vector;
				vector..ctor(num2, num3, num4);
				if (!Class11.IsBadPosition(vector) && !Class11.IsBadDistance(Class3.CurrentPlayer.transform.position, vector))
				{
					Quaternion v = default(Quaternion);
					QuantizedSerialization.Method_Private_Static_Void_Il2CppStructArray_1_Byte_byref_Quaternion_PDM_2(Data.Skip(num + 12).Take(5).ToArray<byte>(), ref v);
					if (Class11.IsBadRotation(v))
					{
						Class66.LimitActor(Actor, Code, "Invalid Rotation", 20);
						result = false;
					}
					else
					{
						string item = Convert.ToBase64String(Data);
						if (Class66.list_0.Contains(item))
						{
							Class66.LimitActor(Actor, Code, "Blacklisted", 20);
							result = false;
						}
						else
						{
							Class66.list_0.Add(item);
							result = true;
						}
					}
				}
				else
				{
					Class66.LimitActor(Actor, Code, "Invalid Position", 20);
					result = false;
				}
			}
		}
		catch
		{
			Class66.LimitActor(Actor, Code, "Exception", 20);
			result = false;
		}
		return result;
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00013754 File Offset: 0x00011954
	public static bool SanitizeEvent17(int Actor, byte[] Data, byte Code)
	{
		bool result;
		try
		{
			if (BitConverter.ToInt32(Data, 0) >= 0)
			{
				if (Class66.IsValidServertime(BitConverter.ToInt32(Data, 4), 60000))
				{
					string item = Convert.ToBase64String(Data);
					if (!Class66.list_0.Contains(item))
					{
						Class66.list_0.Add(item);
						result = true;
					}
					else
					{
						Class66.LimitActor(Actor, Code, "Blacklisted", 20);
						result = false;
					}
				}
				else
				{
					Class66.LimitActor(Actor, Code, "Invalid Time", 20);
					result = false;
				}
			}
			else
			{
				Class66.LimitActor(Actor, Code, "Invalid Actor", 20);
				result = false;
			}
		}
		catch
		{
			Class66.LimitActor(Actor, Code, "Exception", 20);
			result = false;
		}
		return result;
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00013804 File Offset: 0x00011A04
	public static bool SanitizeEvent202(int Actor, Hashtable Data, byte Code)
	{
		bool result;
		try
		{
			if (Data.ContainsKey("6") && !Class66.IsValidServertime(Data["6"].Unbox<int>(), 60000))
			{
				Class66.LimitActor(Actor, Code, "Invalid Time", 20);
				result = false;
			}
			else
			{
				result = true;
			}
		}
		catch
		{
			Class66.LimitActor(Actor, Code, "Exception", 20);
			result = false;
		}
		return result;
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00013884 File Offset: 0x00011A84
	public static bool SanitizeEvent21(int Actor, int[] ViewIDs, byte Code)
	{
		bool result;
		try
		{
			if (ViewIDs.Length != 2)
			{
				Class66.LimitActor(Actor, Code, "Invalid Lenght", 20);
				result = false;
			}
			else if (ViewIDs[0] >= 0)
			{
				if (ViewIDs[1] < 0)
				{
					Class66.LimitActor(Actor, Code, "Invalid Actor", 20);
					result = false;
				}
				else
				{
					result = true;
				}
			}
			else
			{
				Class66.LimitActor(Actor, Code, "Invalid ViewID", 20);
				result = false;
			}
		}
		catch
		{
			Class66.LimitActor(Actor, Code, "Exception", 20);
			result = false;
		}
		return result;
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00013908 File Offset: 0x00011B08
	public static bool SanitizeEvent22(int Actor, int[] ViewIDs, byte Code)
	{
		bool result;
		try
		{
			if (ViewIDs.Length != 2)
			{
				Class66.LimitActor(Actor, Code, "Invalid Lenght", 20);
				result = false;
			}
			else if (ViewIDs[0] < 0)
			{
				Class66.LimitActor(Actor, Code, "Invalid ViewID", 20);
				result = false;
			}
			else if (ViewIDs[1] >= 0)
			{
				result = true;
			}
			else
			{
				Class66.LimitActor(Actor, Code, "Invalid Actor", 20);
				result = false;
			}
		}
		catch
		{
			Class66.LimitActor(Actor, Code, "Exception", 20);
			result = false;
		}
		return result;
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x0001398C File Offset: 0x00011B8C
	public static bool SanitizeEvent210(int Actor, int[] ViewIDs, byte Code)
	{
		bool result;
		try
		{
			if (ViewIDs.Length != 2)
			{
				Class66.LimitActor(Actor, Code, "Invalid Lenght", 20);
				result = false;
			}
			else if (ViewIDs[0] < 0)
			{
				Class66.LimitActor(Actor, Code, "Invalid ViewID", 20);
				result = false;
			}
			else if (ViewIDs[1] >= 0)
			{
				result = true;
			}
			else
			{
				Class66.LimitActor(Actor, Code, "Invalid Actor", 20);
				result = false;
			}
		}
		catch
		{
			Class66.LimitActor(Actor, Code, "Exception", 20);
			result = false;
		}
		return result;
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x00013A10 File Offset: 0x00011C10
	public static bool CheckDecodedRPC(Player Player, VRC_EventHandler.VrcEvent Event, VRC_EventHandler.VrcBroadcastType BroadcastType, int instagatorId, float fastForward, object[] DecodedBytes)
	{
		try
		{
			VRC_EventHandler.VrcEventType eventType = Event.EventType;
			if (eventType != 8)
			{
				if (eventType == 14)
				{
					string parameterString = Event.ParameterString;
					if (parameterString != null)
					{
						switch (parameterString.Length)
						{
						case 9:
							if (parameterString == "CancelRPC")
							{
								Logger.Log(Player.DisplayName() + " canceled Emote", Logger.LogsType.Room);
								Class53.Log(Player.DisplayName() + " --> Cancel Emote", Class53.LogsType.Emote);
								goto IL_F81;
							}
							break;
						case 10:
							if (parameterString == "TimerBloop")
							{
								if (Player.GetPhotonPlayer().ActorID() == Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
								{
									goto IL_F81;
								}
								if (!Player.GetVRCPlayer().field_Public_UserCameraIndicator_0.field_Private_Boolean_4)
								{
									Logger.Log("Prevented " + Player.DisplayName() + " from using invisible Camera", Logger.LogsType.Protection);
									Class53.Log(Player.DisplayName() + " --> Invisible Camera", Class53.LogsType.Protection);
									Class66.LimitActor(Player.GetPhotonPlayer().ActorID(), 6, "Invisible Camera", 20);
									return false;
								}
								if (Class143.bool_17)
								{
									Logger.Log(Player.DisplayName() + " used a Timer", Logger.LogsType.Room);
									Class53.Log(Player.DisplayName() + " --> Timer", Class53.LogsType.Camera);
									return false;
								}
								goto IL_F81;
							}
							break;
						case 11:
							if (parameterString == "SanityCheck")
							{
								if (Player.GetPhotonPlayer().ActorID() == Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
								{
									goto IL_F81;
								}
								int int_0 = (int)DecodedBytes[2];
								if (Class3.VRCNetworkingClient.GetAllPhotonPlayers().FirstOrDefault((Player x) => x.ActorID() == int_0) == null)
								{
									Logger.Log("Prevented " + Player.DisplayName() + " from checking a Invalid Actor", Logger.LogsType.Protection);
									Class53.Log(Player.DisplayName() + " --> Invalid Actor", Class53.LogsType.Protection);
									Class66.LimitActor(Player.GetPhotonPlayer().ActorID(), 6, "Invalid Actor", 20);
									return false;
								}
								if (int_0 == Player.GetPhotonPlayer().ActorID())
								{
									Logger.Log("Prevented " + Player.DisplayName() + " from checking your Sanity", Logger.LogsType.Protection);
									Class53.Log(Player.DisplayName() + " --> Sanity Check", Class53.LogsType.Protection);
									return false;
								}
								goto IL_F81;
							}
							break;
						case 12:
						{
							char c = parameterString[4];
							if (c <= 'd')
							{
								if (c != 'E')
								{
									switch (c)
									{
									case 'a':
										if (parameterString == "ReleaseBones")
										{
											Logger.Log(Player.DisplayName() + " released Physbone positions", Logger.LogsType.Room);
											Class53.Log(Player.DisplayName() + " --> Physbone Release", Class53.LogsType.Avatar);
											goto IL_F81;
										}
										break;
									case 'c':
										if (parameterString == "SwitchAvatar")
										{
											if (Player.GetPhotonPlayer().ActorID() != Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
											{
												DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 2);
												defaultInterpolatedStringHandler.AppendLiteral("Prevented ");
												defaultInterpolatedStringHandler.AppendFormatted(Player.DisplayName());
												defaultInterpolatedStringHandler.AppendLiteral(" from switching Pedestal [");
												defaultInterpolatedStringHandler.AppendFormatted<object>(DecodedBytes[0]);
												defaultInterpolatedStringHandler.AppendLiteral("]");
												Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Protection);
												Class53.Log(Player.DisplayName() + " --> Pedestal Switch", Class53.LogsType.Protection);
												Class66.LimitActor(Player.GetPhotonPlayer().ActorID(), 6, "Invalid RPC", 20);
												return false;
											}
											Logger.Log(Player.DisplayName() + " switched a Pedestal", Logger.LogsType.Room);
											Class53.Log(Player.DisplayName() + " --> Avatar Switch", Class53.LogsType.Pedestal);
											goto IL_F81;
										}
										break;
									case 'd':
										if (parameterString == "_SendOnSpawn")
										{
											if (!DecodedBytes[0].ToString().EndsWith("00004"))
											{
												Logger.Log("Prevented " + Player.DisplayName() + " from instantiating a invalid Object", Logger.LogsType.Protection);
												Class53.Log(Player.DisplayName() + " --> Invalid Object", Class53.LogsType.Protection);
												Class66.LimitActor(Player.GetPhotonPlayer().ActorID(), 6, "Invalid Actor", 20);
												return false;
											}
											goto IL_F81;
										}
										break;
									}
								}
								else if (parameterString == "PlayEmoteRPC")
								{
									int num = (int)DecodedBytes[0];
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
									if (Player.GetPhotonPlayer().ActorID() != Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID() && (num < 1 || num > 8))
									{
										defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 2);
										defaultInterpolatedStringHandler.AppendFormatted(Player.DisplayName());
										defaultInterpolatedStringHandler.AppendLiteral(" used Invalid Emote [");
										defaultInterpolatedStringHandler.AppendFormatted<int>(num);
										defaultInterpolatedStringHandler.AppendLiteral("]");
										Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Protection);
										defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
										defaultInterpolatedStringHandler.AppendFormatted(Player.DisplayName());
										defaultInterpolatedStringHandler.AppendLiteral(" --> Invalid Emote [");
										defaultInterpolatedStringHandler.AppendFormatted<int>(num);
										defaultInterpolatedStringHandler.AppendLiteral("]");
										Class53.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Class53.LogsType.Protection);
										Class66.LimitActor(Player.GetPhotonPlayer().ActorID(), 6, "Invalid RPC", 20);
										return false;
									}
									defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
									defaultInterpolatedStringHandler.AppendFormatted(Player.DisplayName());
									defaultInterpolatedStringHandler.AppendLiteral(" used a Emote [");
									defaultInterpolatedStringHandler.AppendFormatted<int>(num);
									defaultInterpolatedStringHandler.AppendLiteral("]");
									Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
									defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
									defaultInterpolatedStringHandler.AppendFormatted(Player.DisplayName());
									defaultInterpolatedStringHandler.AppendLiteral(" --> ");
									defaultInterpolatedStringHandler.AppendFormatted<int>(num);
									Class53.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Class53.LogsType.Emote);
									goto IL_F81;
								}
							}
							else if (c != 'o')
							{
								if (c != 'r')
								{
									if (c == 'v')
									{
										if (parameterString == "SetAvatarUse")
										{
											if (Player.GetPhotonPlayer().ActorID() != Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
											{
												Logger.Log("Prevented " + Player.DisplayName() + " from using a Pedestal", Logger.LogsType.Protection);
												Class53.Log(Player.DisplayName() + " --> Avatar Use", Class53.LogsType.Protection);
												Class66.LimitActor(Player.GetPhotonPlayer().ActorID(), 6, "Invalid RPC", 20);
												return false;
											}
											Logger.Log(Player.DisplayName() + " used a Pedestal", Logger.LogsType.Room);
											Class53.Log(Player.DisplayName() + " --> Avatar Use", Class53.LogsType.Pedestal);
											goto IL_F81;
										}
									}
								}
								else if (parameterString == "SetPresetRPC")
								{
									if (Player.GetPhotonPlayer().ActorID() != Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
									{
										DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 2);
										defaultInterpolatedStringHandler.AppendLiteral("Prevented ");
										defaultInterpolatedStringHandler.AppendFormatted(Player.DisplayName());
										defaultInterpolatedStringHandler.AppendLiteral(" from using an Admin RPC [");
										defaultInterpolatedStringHandler.AppendFormatted(Event.ParameterString);
										defaultInterpolatedStringHandler.AppendLiteral("]");
										Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Protection);
										Class53.Log(Player.DisplayName() + " --> Admin RPC [" + Event.ParameterString + "]", Class53.LogsType.Protection);
										Class66.LimitActor(Player.GetPhotonPlayer().ActorID(), 6, "Admin RPC", 20);
										return false;
									}
									goto IL_F81;
								}
							}
							else if (parameterString == "PhotoCapture")
							{
								if (Player.GetPhotonPlayer().ActorID() == Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
								{
									Logger.Log(Player.DisplayName() + " took a Photo", Logger.LogsType.Room);
									Class53.Log(Player.DisplayName() + " --> Photo", Class53.LogsType.Camera);
									goto IL_F81;
								}
								if (!Player.GetVRCPlayer().field_Public_UserCameraIndicator_0.field_Private_Boolean_4)
								{
									Logger.Log("Prevented " + Player.DisplayName() + " from using invisible Camera", Logger.LogsType.Protection);
									Class53.Log(Player.DisplayName() + " --> Invisible Camera", Class53.LogsType.Protection);
									Class66.LimitActor(Player.GetPhotonPlayer().ActorID(), 6, "Invisible Camera", 20);
									return false;
								}
								if (Class143.bool_17)
								{
									Logger.Log(Player.DisplayName() + " took a Photo", Logger.LogsType.Room);
									Class53.Log(Player.DisplayName() + " --> Photo", Class53.LogsType.Camera);
									return false;
								}
								goto IL_F81;
							}
							break;
						}
						case 13:
						{
							char c = parameterString[6];
							if (c != 'G')
							{
								if (c != 'M')
								{
									if (c == 'h')
									{
										if (parameterString == "RefreshAvatar")
										{
											Logger.Log(Player.DisplayName() + " refreshed a Pedestal", Logger.LogsType.Room);
											Class53.Log(Player.DisplayName() + " --> Avatar Refresh", Class53.LogsType.Pedestal);
											goto IL_F81;
										}
									}
								}
								else if (parameterString == "EnableMeshRPC")
								{
									if (Player.GetPhotonPlayer().ActorID() != Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
									{
										DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 2);
										defaultInterpolatedStringHandler.AppendLiteral("Prevented ");
										defaultInterpolatedStringHandler.AppendFormatted(Player.DisplayName());
										defaultInterpolatedStringHandler.AppendLiteral(" from using an Admin RPC [");
										defaultInterpolatedStringHandler.AppendFormatted(Event.ParameterString);
										defaultInterpolatedStringHandler.AppendLiteral("]");
										Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Protection);
										Class53.Log(Player.DisplayName() + " --> Admin RPC [" + Event.ParameterString + "]", Class53.LogsType.Protection);
										Class66.LimitActor(Player.GetPhotonPlayer().ActorID(), 6, "Admin RPC", 20);
										return false;
									}
									goto IL_F81;
								}
							}
							else if (parameterString == "EnableGravity")
							{
								goto IL_F81;
							}
							break;
						}
						case 14:
							if (parameterString == "_DestroyObject")
							{
								if (!Class143.bool_12)
								{
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
									defaultInterpolatedStringHandler.AppendFormatted(Player.DisplayName());
									defaultInterpolatedStringHandler.AppendLiteral(" destroyed an Object [ID: ");
									defaultInterpolatedStringHandler.AppendFormatted<object>(DecodedBytes[0]);
									defaultInterpolatedStringHandler.AppendLiteral("]");
									Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
									defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 2);
									defaultInterpolatedStringHandler.AppendFormatted(Player.DisplayName());
									defaultInterpolatedStringHandler.AppendLiteral(" --> Object Destroy [ID: ");
									defaultInterpolatedStringHandler.AppendFormatted<object>(DecodedBytes[0]);
									defaultInterpolatedStringHandler.AppendLiteral("]");
									Class53.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Class53.LogsType.Room);
									goto IL_F81;
								}
								return false;
							}
							break;
						case 16:
						{
							char c = parameterString[0];
							if (c != 'C')
							{
								if (c == 'D')
								{
									if (parameterString == "DisableKinematic")
									{
										goto IL_F81;
									}
								}
							}
							else if (parameterString == "ChangeVisibility")
							{
								if (!(bool)DecodedBytes[0])
								{
									Logger.Log(Player.DisplayName() + " hide the Camera", Logger.LogsType.Room);
									Class53.Log(Player.DisplayName() + " --> Hide", Class53.LogsType.Camera);
									goto IL_F81;
								}
								if (Player.GetPhotonPlayer().ActorID() == Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
								{
									return false;
								}
								Logger.Log(Player.DisplayName() + " showed the Camera", Logger.LogsType.Room);
								Class53.Log(Player.DisplayName() + " --> Show", Class53.LogsType.Camera);
								goto IL_F81;
							}
							break;
						}
						case 18:
							if (parameterString == "_InstantiateObject")
							{
								if (Player.GetPhotonPlayer().ActorID() != Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
								{
									string[] array = DecodedBytes[1].ToString().TrimStart('(').TrimEnd(')').Split(',', StringSplitOptions.None);
									Vector3 vector;
									vector..ctor(float.Parse(array[0]), float.Parse(array[1]), float.Parse(array[2]));
									if (Class11.IsBadPosition(vector) || Class11.IsBadDistance(Class3.CurrentPlayer.transform.position, vector))
									{
										Logger.Log("Prevented " + Player.DisplayName() + " from instantiating a invalid Object", Logger.LogsType.Protection);
										Class53.Log(Player.DisplayName() + " --> Invalid Object", Class53.LogsType.Protection);
										Class66.LimitActor(Player.GetPhotonPlayer().ActorID(), 6, "Invalid Position", 20);
										return false;
									}
									string[] array2 = DecodedBytes[2].ToString().TrimStart('(').TrimEnd(')').Split(',', StringSplitOptions.None);
									if (Class11.IsBadRotation(new Quaternion(float.Parse(array2[0]), float.Parse(array2[1]), float.Parse(array2[2]), float.Parse(array2[3]))))
									{
										Logger.Log("Prevented " + Player.DisplayName() + " from instantiating a invalid Object", Logger.LogsType.Protection);
										Class53.Log(Player.DisplayName() + " --> Invalid Object", Class53.LogsType.Protection);
										Class66.LimitActor(Player.GetPhotonPlayer().ActorID(), 6, "Invalid Rotation", 20);
										return false;
									}
									if (!DecodedBytes[3].ToString().EndsWith("00004"))
									{
										Logger.Log("Prevented " + Player.DisplayName() + " from instantiating a invalid Object", Logger.LogsType.Protection);
										Class53.Log(Player.DisplayName() + " --> Invalid Object", Class53.LogsType.Protection);
										Class66.LimitActor(Player.GetPhotonPlayer().ActorID(), 6, "Invalid Actor", 20);
										return false;
									}
								}
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 3);
								defaultInterpolatedStringHandler.AppendFormatted(Player.DisplayName());
								defaultInterpolatedStringHandler.AppendLiteral(" instantiated Object ");
								defaultInterpolatedStringHandler.AppendFormatted<object>(DecodedBytes[0]);
								defaultInterpolatedStringHandler.AppendLiteral(" [ID: ");
								defaultInterpolatedStringHandler.AppendFormatted<object>(DecodedBytes[3]);
								defaultInterpolatedStringHandler.AppendLiteral("]");
								Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
								defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
								defaultInterpolatedStringHandler.AppendFormatted(Player.DisplayName());
								defaultInterpolatedStringHandler.AppendLiteral(" --> Object Instantiate [ID: ");
								defaultInterpolatedStringHandler.AppendFormatted<object>(DecodedBytes[3]);
								defaultInterpolatedStringHandler.AppendLiteral("]");
								Class53.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Class53.LogsType.Room);
								goto IL_F81;
							}
							break;
						case 23:
							if (parameterString == "UdonSyncRunProgramAsRPC")
							{
								if (Class143.bool_14 && Player.GetPhotonPlayer().ActorID() != Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
								{
									return false;
								}
								goto IL_F81;
							}
							break;
						case 24:
						{
							char c = parameterString[0];
							if (c != 'I')
							{
								if (c == 'R')
								{
									if (parameterString == "ReloadAvatarNetworkedRPC")
									{
										Logger.Log(Player.DisplayName() + " used Avatar Reload", Logger.LogsType.Room);
										Class53.Log(Player.DisplayName() + " --> Reload Avatar", Class53.LogsType.Avatar);
										goto IL_F81;
									}
								}
							}
							else if (parameterString == "InternalApplyOverrideRPC")
							{
								if (Class143.bool_29 && Player.GetPhotonPlayer().ActorID() == Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
								{
									return false;
								}
								goto IL_F81;
							}
							break;
						}
						}
					}
					Logger.LogWarning("Not implemented RPC, blocked for Protection");
					Logger.LogRPC(Player, Event, BroadcastType, instagatorId, fastForward, DecodedBytes);
					return false;
				}
				if (eventType == 20 && Class143.bool_30 && Player.GetPhotonPlayer().ActorID() == Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
				{
					return false;
				}
			}
			else
			{
				if (Class143.bool_31 && Player.GetPhotonPlayer().ActorID() == Class3.VRCNetworkingClient.GetCurrentPlayer().ActorID())
				{
					return false;
				}
				Logger.Log(Player.DisplayName() + " used Teleport", Logger.LogsType.Room);
				Class53.Log(Player.DisplayName() + " --> Teleport", Class53.LogsType.Room);
			}
			IL_F81:;
		}
		catch
		{
			Class66.LimitActor(Player.GetPhotonPlayer().ActorID(), 6, "RPC Exception", 20);
			return false;
		}
		return true;
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x000149E0 File Offset: 0x00012BE0
	public static bool CheckWorldID(string ID)
	{
		if (!ID.Contains(':'))
		{
			return false;
		}
		string text = ID.Split(':', StringSplitOptions.None)[0];
		string text2 = ID.Split(':', StringSplitOptions.None)[1];
		if (text.Length != 41 || text2.Length < 1)
		{
			return false;
		}
		if (!text.StartsWith("wrld_"))
		{
			return false;
		}
		if (text.All((char c) => char.IsLetterOrDigit(c) || c == '_' || c == '-'))
		{
			return text2.All((char c) => char.IsLetterOrDigit(c) || c == '_' || c == '-' || c == '(' || c == ')' || c == '~' || c == '&');
		}
		return false;
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00014A90 File Offset: 0x00012C90
	public static bool CheckGroupID(string ID)
	{
		if (ID.Length != 40)
		{
			return false;
		}
		if (ID.StartsWith("grp_"))
		{
			return ID.All((char c) => char.IsLetterOrDigit(c) || c == '_' || c == '-');
		}
		return false;
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x00014AE4 File Offset: 0x00012CE4
	public static bool CheckFileID(string ID)
	{
		if (ID.Length != 41)
		{
			return false;
		}
		if (!ID.StartsWith("file_"))
		{
			return false;
		}
		return ID.All((char c) => char.IsLetterOrDigit(c) || c == '_' || c == '-');
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x00002FA0 File Offset: 0x000011A0
	internal static bool GYbHkPnkGxvAnZZx3v2()
	{
		return Class66.fFAKKlnqvNuXDBiie6L == null;
	}

	// Token: 0x040001D3 RID: 467
	private static readonly Dictionary<int, List<int>> dictionary_0 = new Dictionary<int, List<int>>();

	// Token: 0x040001D4 RID: 468
	public static List<string> list_0 = new List<string>();

	// Token: 0x040001D5 RID: 469
	internal static Class66 fFAKKlnqvNuXDBiie6L;
}
