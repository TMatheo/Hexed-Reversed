using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Hexed.Wrappers;
using UnityEngine;
using VRC;
using VRC.Core;

// Token: 0x02000049 RID: 73
internal class Class35
{
	// Token: 0x0600022C RID: 556 RVA: 0x0000B6CC File Offset: 0x000098CC
	public static bool RecievedContentShare(Dictionary<byte, object> Data, byte EventCode)
	{
		switch ((EnumPublicSealedvaPoShSt4vUnique)Data[0])
		{
		case 0:
		{
			EnumPublicSealedvaCrUpDePoReCr7vUnique enumPublicSealedvaCrUpDePoReCr7vUnique = (EnumPublicSealedvaCrUpDePoReCr7vUnique)Data[1];
			if (enumPublicSealedvaCrUpDePoReCr7vUnique <= 128)
			{
				switch (enumPublicSealedvaCrUpDePoReCr7vUnique)
				{
				case 0:
				{
					Player player = Class3.PlayerManager.GetPlayer(Data[2].ToString());
					if (player == null)
					{
						return false;
					}
					byte b = Convert.ToByte(Data[1]);
					if (b != 0)
					{
						if (b == 1)
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 3);
							defaultInterpolatedStringHandler.AppendFormatted(player.DisplayName());
							defaultInterpolatedStringHandler.AppendLiteral(" spawned a static Portal [");
							defaultInterpolatedStringHandler.AppendFormatted<object>(Data[128]);
							defaultInterpolatedStringHandler.AppendLiteral("] [");
							defaultInterpolatedStringHandler.AppendFormatted<object>(Data[130]);
							defaultInterpolatedStringHandler.AppendLiteral(" Player]");
							Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
							defaultInterpolatedStringHandler.AppendFormatted(player.DisplayName());
							defaultInterpolatedStringHandler.AppendLiteral(" --> ");
							defaultInterpolatedStringHandler.AppendFormatted<object>(Data[3]);
							defaultInterpolatedStringHandler.AppendLiteral(" [Static]");
							Class53.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Class53.LogsType.Portal);
						}
					}
					else
					{
						byte[] value = Data[4] as byte[];
						float num = BitConverter.ToSingle(value, 0);
						float num2 = BitConverter.ToSingle(value, 4);
						float num3 = BitConverter.ToSingle(value, 8);
						Vector3 vector;
						vector..ctor(num, num2, num3);
						if (Class11.IsBadPosition(vector) || Vector3.Distance(player.transform.position, vector) > 50f || Class11.IsBadDistance(Class3.CurrentPlayer.transform.position, vector))
						{
							Class66.LimitActor(player.GetPhotonPlayer().ActorID(), EventCode, "Invalid Position", 20);
							return false;
						}
						if (Data.ContainsKey(133))
						{
							Dictionary<string, object> dictionary = Data[133] as Dictionary<string, object>;
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 6);
							defaultInterpolatedStringHandler.AppendFormatted(player.DisplayName());
							defaultInterpolatedStringHandler.AppendLiteral(" spawned a dynamic Portal [");
							defaultInterpolatedStringHandler.AppendFormatted<object>(Data[1]);
							defaultInterpolatedStringHandler.AppendLiteral("] [");
							defaultInterpolatedStringHandler.AppendFormatted<object>(dictionary["name"]);
							defaultInterpolatedStringHandler.AppendLiteral("] [");
							defaultInterpolatedStringHandler.AppendFormatted<object>(Data[132]);
							defaultInterpolatedStringHandler.AppendLiteral("] [");
							defaultInterpolatedStringHandler.AppendFormatted<object>(Data[130]);
							defaultInterpolatedStringHandler.AppendLiteral("/");
							defaultInterpolatedStringHandler.AppendFormatted<object>(dictionary["capacity"]);
							defaultInterpolatedStringHandler.AppendLiteral(" Player]");
							Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
							defaultInterpolatedStringHandler.AppendFormatted(player.DisplayName());
							defaultInterpolatedStringHandler.AppendLiteral(" --> ");
							defaultInterpolatedStringHandler.AppendFormatted<object>(dictionary["name"]);
							defaultInterpolatedStringHandler.AppendLiteral(" [Dynamic]");
							Class53.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Class53.LogsType.Portal);
						}
						if (player.UserID() != APIUser.CurrentUser.UserID() && (Class143.antiPortalMode_0 == Class143.AntiPortalMode.All || (Class143.antiPortalMode_0 == Class143.AntiPortalMode.Friends && !Class10.IsFriend(player.UserID()))))
						{
							return false;
						}
					}
					break;
				}
				case 1:
				{
					if (Class143.bool_12)
					{
						return false;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Server destroyed a Portal [");
					defaultInterpolatedStringHandler.AppendFormatted<object>(Data[128]);
					defaultInterpolatedStringHandler.AppendLiteral("]");
					Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Server --> Destroy [");
					defaultInterpolatedStringHandler.AppendFormatted<object>(Data[128]);
					defaultInterpolatedStringHandler.AppendLiteral("]");
					Class53.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Class53.LogsType.Portal);
					break;
				}
				case 2:
					break;
				default:
					if (enumPublicSealedvaCrUpDePoReCr7vUnique != 128)
					{
					}
					break;
				}
			}
			else if (enumPublicSealedvaCrUpDePoReCr7vUnique != 129)
			{
				if (enumPublicSealedvaCrUpDePoReCr7vUnique == 152)
				{
					Logger.Log("Portal request failed", Logger.LogsType.Room);
					Class53.Log("Server --> Portal failed", Class53.LogsType.Portal);
				}
			}
			break;
		}
		case 2:
		{
			EnumPublicSealedvaCrDeUpUn5vUnique enumPublicSealedvaCrDeUpUn5vUnique = (EnumPublicSealedvaCrDeUpUn5vUnique)Data[1];
			switch (enumPublicSealedvaCrDeUpUn5vUnique)
			{
			case 0:
				if (Data.ContainsKey(3))
				{
					Player player2 = Class3.PlayerManager.GetPlayer(Data[3].ToString());
					if (player2 == null)
					{
						return false;
					}
					byte[] value2 = Data[4] as byte[];
					float num4 = BitConverter.ToSingle(value2, 0);
					float num5 = BitConverter.ToSingle(value2, 4);
					float num6 = BitConverter.ToSingle(value2, 8);
					Vector3 vector2;
					vector2..ctor(num4, num5, num6);
					if (Class11.IsBadPosition(vector2) || Vector3.Distance(player2.transform.position, vector2) > 50f || Class11.IsBadDistance(Class3.CurrentPlayer.transform.position, vector2))
					{
						Class66.LimitActor(player2.GetPhotonPlayer().ActorID(), EventCode, "Invalid Position", 20);
						return false;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
					defaultInterpolatedStringHandler.AppendFormatted(player2.DisplayName());
					defaultInterpolatedStringHandler.AppendLiteral(" spawned a Sticker [");
					defaultInterpolatedStringHandler.AppendFormatted<object>(Data[129]);
					defaultInterpolatedStringHandler.AppendLiteral("]");
					Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
					defaultInterpolatedStringHandler.AppendFormatted(player2.DisplayName());
					defaultInterpolatedStringHandler.AppendLiteral(" --> ");
					defaultInterpolatedStringHandler.AppendFormatted<object>(Data[129]);
					Class53.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Class53.LogsType.Sticker);
				}
				break;
			case 1:
			{
				if (Class143.bool_12)
				{
					return false;
				}
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Server destroyed a Sticker [");
				defaultInterpolatedStringHandler.AppendFormatted<object>(Data[2]);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Server --> Destroy [");
				defaultInterpolatedStringHandler.AppendFormatted<object>(Data[2]);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Class53.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Class53.LogsType.Sticker);
				break;
			}
			case 2:
				break;
			default:
				if (enumPublicSealedvaCrDeUpUn5vUnique != 128)
				{
				}
				break;
			}
			break;
		}
		}
		return true;
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0000BD08 File Offset: 0x00009F08
	public static bool RaisedContentShare(Dictionary<byte, object> Data)
	{
		switch ((EnumPublicSealedvaPoShSt4vUnique)Data[0])
		{
		case 0:
		{
			EnumPublicSealedvaCrUpDePoReCr7vUnique enumPublicSealedvaCrUpDePoReCr7vUnique = (EnumPublicSealedvaCrUpDePoReCr7vUnique)Data[1];
			if (enumPublicSealedvaCrUpDePoReCr7vUnique <= 128)
			{
				switch (enumPublicSealedvaCrUpDePoReCr7vUnique)
				{
				case 0:
				case 1:
				case 2:
					break;
				default:
					if (enumPublicSealedvaCrUpDePoReCr7vUnique == 128)
					{
						return false;
					}
					break;
				}
			}
			else if (enumPublicSealedvaCrUpDePoReCr7vUnique != 129 && enumPublicSealedvaCrUpDePoReCr7vUnique != 152)
			{
			}
			break;
		}
		case 2:
			switch ((EnumPublicSealedvaCrDeUpUn5vUnique)Data[1])
			{
			}
			break;
		}
		return true;
	}

	// Token: 0x0600022E RID: 558 RVA: 0x0000BD9C File Offset: 0x00009F9C
	public static void DeletePortals()
	{
		foreach (PortalInternal portalInternal in Resources.FindObjectsOfTypeAll<PortalInternal>())
		{
			if (portalInternal.gameObject.activeInHierarchy)
			{
				Object.Destroy(portalInternal.gameObject);
			}
		}
	}

	// Token: 0x06000230 RID: 560 RVA: 0x00002C03 File Offset: 0x00000E03
	internal static bool VPL1j5Njwl2xPJLmbyh()
	{
		return Class35.KWhxInNgcElm07dXRvR == null;
	}

	// Token: 0x040000FA RID: 250
	internal static Class35 KWhxInNgcElm07dXRvR;
}
