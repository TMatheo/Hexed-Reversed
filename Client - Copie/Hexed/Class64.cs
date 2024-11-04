using System;
using System.Text;
using Hexed.Wrappers;
using Photon.Realtime;

// Token: 0x0200007B RID: 123
internal class Class64
{
	// Token: 0x06000390 RID: 912 RVA: 0x00012320 File Offset: 0x00010520
	public static bool ReceivedChatEvent(string Data, Player PhotonPlayer, byte EventCode)
	{
		bool result;
		try
		{
			if (Data != null)
			{
				if (!Data.Contains("\n") && !Data.Contains("\r") && !Data.Contains("\t") && !Data.Contains("\0") && !Data.Contains("\v"))
				{
					string item = Convert.ToBase64String(Encoding.UTF8.GetBytes(Data));
					if (Class66.list_0.Contains(item))
					{
						Class66.LimitActor(PhotonPlayer.ActorID(), EventCode, "Blacklisted", 20);
						result = false;
					}
					else
					{
						Class66.list_0.Add(item);
						Logger.Log(PhotonPlayer.GetPlayer().DisplayName() + ": " + Data, Logger.LogsType.Chat);
						if (PhotonPlayer.ActorID() == Class143.int_2)
						{
							Class117.RaiseChatMessage(Data);
						}
						result = true;
					}
				}
				else
				{
					Class66.LimitActor(PhotonPlayer.ActorID(), EventCode, "Invalid Char", 20);
					result = false;
				}
			}
			else
			{
				Class66.LimitActor(PhotonPlayer.ActorID(), EventCode, "No Data", 20);
				result = false;
			}
		}
		catch
		{
			Class66.LimitActor(PhotonPlayer.ActorID(), EventCode, "Exception", 20);
			result = false;
		}
		return result;
	}

	// Token: 0x06000391 RID: 913 RVA: 0x00012458 File Offset: 0x00010658
	public static bool RaisedChatEvent(string Data)
	{
		if (!Class52.bool_1)
		{
			return true;
		}
		Class48.SelfbotChat(Data);
		return false;
	}

	// Token: 0x06000393 RID: 915 RVA: 0x00002F78 File Offset: 0x00001178
	internal static bool WFZMQYnwKDYpw7GGinR()
	{
		return Class64.jID28Fn6nEVEAWfAP2b == null;
	}

	// Token: 0x040001CB RID: 459
	private static Class64 jID28Fn6nEVEAWfAP2b;
}
