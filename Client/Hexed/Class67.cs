using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Hexed.Wrappers;
using Photon.Realtime;

// Token: 0x02000083 RID: 131
internal class Class67
{
	// Token: 0x060003C7 RID: 967 RVA: 0x00014CE0 File Offset: 0x00012EE0
	public static void ClearModerations()
	{
		Class67.list_1.Clear();
		Class67.list_0.Clear();
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x00014D04 File Offset: 0x00012F04
	public static bool ReceivedModerationEvent(ref Dictionary<byte, object> dictionary_0)
	{
		byte b = Convert.ToByte(dictionary_0[0]);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		switch (b)
		{
		case 2:
			if (dictionary_0[2].ToString() == "You have been warned for your behavior. If you continue, you may be kicked out of the instance")
			{
				Logger.Log("Server tried to Warn you", Logger.LogsType.Room);
				Class53.Log("Server --> Warn", Class53.LogsType.Moderation);
				return false;
			}
			return true;
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
			break;
		case 8:
			Logger.Log("Server tried to Mic Off you", Logger.LogsType.Room);
			Class53.Log("Server --> Mic Off", Class53.LogsType.Moderation);
			return false;
		case 9:
			Logger.Log("Server tried to change your Mic Volume", Logger.LogsType.Room);
			Class53.Log("Server --> Voice Volume Change", Class53.LogsType.Moderation);
			return false;
		case 10:
			Logger.Log("Server tried to move you to a new World", Logger.LogsType.Room);
			Class53.Log("Server --> Force World Change", Class53.LogsType.Moderation);
			return false;
		case 11:
			Logger.Log("Server tried to move you to a new World", Logger.LogsType.Room);
			Class53.Log("Server --> Force World Change", Class53.LogsType.Moderation);
			return false;
		case 12:
			Logger.Log("Server tried to Teleport you", Logger.LogsType.Room);
			Class53.Log("Server --> Force Teleport", Class53.LogsType.Moderation);
			return false;
		case 13:
		{
			string text = dictionary_0[2].ToString().Replace("A vote kick has been initiated against ", "").Replace(", do you agree?", "");
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Votekick started on ");
			defaultInterpolatedStringHandler.AppendFormatted(text);
			defaultInterpolatedStringHandler.AppendLiteral(" [ID: ");
			defaultInterpolatedStringHandler.AppendFormatted<object>(dictionary_0[3]);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
			Class53.Log("Votekick --> " + text, Class53.LogsType.Moderation);
			return true;
		}
		default:
			switch (b)
			{
			case 20:
			case 24:
				return true;
			case 21:
			{
				bool? flag = Class67.CheckMute(dictionary_0);
				if (!flag.GetValueOrDefault())
				{
					bool? flag2 = flag;
					if ((!flag2.GetValueOrDefault() & flag2 != null) && Class67.list_1.Contains((int)dictionary_0[1]))
					{
						Class67.list_1.Remove((int)dictionary_0[1]);
						Player photonPlayer = Class3.VRCNetworkingClient.GetPhotonPlayer((int)dictionary_0[1]);
						if (photonPlayer != null)
						{
							string str = photonPlayer.DisplayName() ?? "NO NAME";
							Logger.Log(str + " unmuted you", Logger.LogsType.Room);
							Class53.Log(str + " --> Unmute", Class53.LogsType.Mute);
						}
					}
				}
				else if (!Class67.list_1.Contains((int)dictionary_0[1]))
				{
					Class67.list_1.Add((int)dictionary_0[1]);
					Player photonPlayer2 = Class3.VRCNetworkingClient.GetPhotonPlayer((int)dictionary_0[1]);
					if (photonPlayer2 != null)
					{
						string str2 = photonPlayer2.DisplayName() ?? "NO NAME";
						Logger.Log(str2 + " muted you", Logger.LogsType.Room);
						Class53.Log(str2 + " --> Mute", Class53.LogsType.Mute);
					}
				}
				bool? flag3 = Class67.CheckBlock(dictionary_0);
				if (!flag3.GetValueOrDefault())
				{
					bool? flag2 = flag3;
					if (!flag2.GetValueOrDefault() & flag2 != null)
					{
						if (!Class67.list_0.Contains((int)dictionary_0[1]))
						{
							return true;
						}
						Class67.list_0.Remove((int)dictionary_0[1]);
						Player photonPlayer3 = Class3.VRCNetworkingClient.GetPhotonPlayer((int)dictionary_0[1]);
						if (photonPlayer3 != null)
						{
							string str3 = photonPlayer3.DisplayName() ?? "NO NAME";
							Logger.Log(str3 + " unblocked you", Logger.LogsType.Room);
							Class53.Log(str3 + " --> Unblock", Class53.LogsType.Block);
							return true;
						}
						return true;
					}
					else
					{
						bool? flag4 = Class67.CheckMassMute(dictionary_0);
						if (flag4.GetValueOrDefault())
						{
							foreach (int num in (int[])dictionary_0[11])
							{
								if (!Class67.list_1.Contains(num))
								{
									Class67.list_1.Add(num);
									Player photonPlayer4 = Class3.VRCNetworkingClient.GetPhotonPlayer(num);
									if (photonPlayer4 != null)
									{
										string str4 = photonPlayer4.DisplayName() ?? "NO NAME";
										Logger.Log(str4 + " muted you", Logger.LogsType.Room);
										Class53.Log(str4 + " --> Mute", Class53.LogsType.Mute);
									}
								}
							}
						}
						else
						{
							flag2 = flag4;
							if (!flag2.GetValueOrDefault() & flag2 != null)
							{
								foreach (int photonID in Class67.list_1)
								{
									Player photonPlayer5 = Class3.VRCNetworkingClient.GetPhotonPlayer(photonID);
									if (photonPlayer5 != null)
									{
										string str5 = photonPlayer5.DisplayName() ?? "NO NAME";
										Logger.Log(str5 + " unmuted you", Logger.LogsType.Room);
										Class53.Log(str5 + " --> Unmute", Class53.LogsType.Mute);
									}
								}
								Class67.list_1.Clear();
							}
						}
						bool? flag5 = Class67.CheckMassBlock(dictionary_0);
						if (!flag5.GetValueOrDefault())
						{
							flag2 = flag5;
							if (!flag2.GetValueOrDefault() & flag2 != null)
							{
								foreach (int photonID2 in Class67.list_0)
								{
									Player photonPlayer6 = Class3.VRCNetworkingClient.GetPhotonPlayer(photonID2);
									if (photonPlayer6 != null)
									{
										string str6 = photonPlayer6.DisplayName() ?? "NO NAME";
										Logger.Log(str6 + " unblocked you", Logger.LogsType.Room);
										Class53.Log(str6 + " --> Unblock", Class53.LogsType.Block);
									}
								}
								Class67.list_0.Clear();
								return true;
							}
							return true;
						}
						else
						{
							foreach (int num2 in (int[])dictionary_0[10])
							{
								if (!Class67.list_0.Contains(num2))
								{
									Class67.list_0.Add(num2);
									Player photonPlayer7 = Class3.VRCNetworkingClient.GetPhotonPlayer(num2);
									if (photonPlayer7 != null)
									{
										string str7 = photonPlayer7.DisplayName() ?? "NO NAME";
										Logger.Log(str7 + " blocked you", Logger.LogsType.Room);
										Class53.Log(str7 + " --> Block", Class53.LogsType.Block);
									}
								}
							}
							if (Class143.bool_19)
							{
								dictionary_0[10] = new int[0];
								return true;
							}
							return true;
						}
					}
				}
				else
				{
					if (!Class67.list_0.Contains((int)dictionary_0[1]))
					{
						Class67.list_0.Add((int)dictionary_0[1]);
						Player photonPlayer8 = Class3.VRCNetworkingClient.GetPhotonPlayer((int)dictionary_0[1]);
						if (photonPlayer8 != null)
						{
							string str8 = photonPlayer8.DisplayName() ?? "NO NAME";
							Logger.Log(str8 + " blocked you", Logger.LogsType.Room);
							Class53.Log(str8 + " --> Block", Class53.LogsType.Block);
						}
					}
					if (Class143.bool_19)
					{
						return false;
					}
					return true;
				}
				break;
			}
			case 25:
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Votekick response is ");
				defaultInterpolatedStringHandler.AppendFormatted<object>(dictionary_0[2]);
				defaultInterpolatedStringHandler.AppendLiteral(" [ID: ");
				defaultInterpolatedStringHandler.AppendFormatted<object>(dictionary_0[3]);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
				Class53.Log("Server --> Votekick response", Class53.LogsType.Moderation);
				return true;
			}
			break;
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 1);
		defaultInterpolatedStringHandler.AppendLiteral("Not implemented Moderation Event received with code ");
		defaultInterpolatedStringHandler.AppendFormatted<object>(dictionary_0[0]);
		Logger.LogWarning(defaultInterpolatedStringHandler.ToStringAndClear());
		return true;
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x0001548C File Offset: 0x0001368C
	public static bool RaisedModerationEvent(Dictionary<byte, object> dictionary_0)
	{
		switch (Convert.ToByte(dictionary_0[0]))
		{
		case 20:
		case 22:
			break;
		default:
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(48, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Not implemented Moderation Event send with code ");
			defaultInterpolatedStringHandler.AppendFormatted<object>(dictionary_0[0]);
			Logger.LogWarning(defaultInterpolatedStringHandler.ToStringAndClear());
			break;
		}
		case 23:
			if (Class143.bool_28)
			{
				object obj = dictionary_0[3];
				if (obj is bool)
				{
					return !(bool)obj;
				}
			}
			break;
		}
		return true;
	}

	// Token: 0x060003CA RID: 970 RVA: 0x00015514 File Offset: 0x00013714
	private static bool? CheckBlock(Dictionary<byte, object> dictionary_0)
	{
		if (dictionary_0.ContainsKey(1) && dictionary_0[1] is int && dictionary_0.ContainsKey(10))
		{
			object obj = dictionary_0[10];
			if (obj is bool)
			{
				bool value = (bool)obj;
				if (dictionary_0.ContainsKey(11) && dictionary_0[11] is bool)
				{
					return new bool?(value);
				}
			}
		}
		return null;
	}

	// Token: 0x060003CB RID: 971 RVA: 0x00015584 File Offset: 0x00013784
	private static bool? CheckMute(Dictionary<byte, object> dictionary_0)
	{
		if (dictionary_0.ContainsKey(1) && dictionary_0[1] is int && dictionary_0.ContainsKey(10) && dictionary_0[10] is bool && dictionary_0.ContainsKey(11))
		{
			object obj = dictionary_0[11];
			if (obj is bool)
			{
				return new bool?((bool)obj);
			}
		}
		return null;
	}

	// Token: 0x060003CC RID: 972 RVA: 0x000155F4 File Offset: 0x000137F4
	private static bool? CheckMassBlock(Dictionary<byte, object> dictionary_0)
	{
		if (dictionary_0.ContainsKey(10))
		{
			int[] array = dictionary_0[10] as int[];
			if (array != null && dictionary_0.ContainsKey(11) && dictionary_0[11] is int[])
			{
				if (array.Length != 0)
				{
					return new bool?(true);
				}
				return new bool?(false);
			}
		}
		return null;
	}

	// Token: 0x060003CD RID: 973 RVA: 0x00015650 File Offset: 0x00013850
	private static bool? CheckMassMute(Dictionary<byte, object> dictionary_0)
	{
		if (dictionary_0.ContainsKey(10) && dictionary_0[10] is int[] && dictionary_0.ContainsKey(11))
		{
			int[] array = dictionary_0[11] as int[];
			if (array != null)
			{
				if (array.Length != 0)
				{
					return new bool?(true);
				}
				return new bool?(false);
			}
		}
		return null;
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x00002FD8 File Offset: 0x000011D8
	internal static bool KLi4esntUyifGsoTJTB()
	{
		return Class67.nhARoNn41nL6cd7yNJj == null;
	}

	// Token: 0x040001E3 RID: 483
	public static List<int> list_0 = new List<int>();

	// Token: 0x040001E4 RID: 484
	public static List<int> list_1 = new List<int>();

	// Token: 0x040001E5 RID: 485
	internal static Class67 nhARoNn41nL6cd7yNJj;
}
