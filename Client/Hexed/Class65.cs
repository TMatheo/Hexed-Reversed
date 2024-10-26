using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using Hexed.Wrappers;
using Photon.Realtime;
using VRC.Core;

// Token: 0x0200007C RID: 124
internal class Class65
{
	// Token: 0x06000394 RID: 916 RVA: 0x00012478 File Offset: 0x00010678
	public static bool ReceivedEmojiEvent(Dictionary<byte, object> Data, Player PhotonPlayer, byte EventCode)
	{
		EnumPublicSealedvaLeCu3vUnique enumPublicSealedvaLeCu3vUnique = (EnumPublicSealedvaLeCu3vUnique)Data[0];
		if (enumPublicSealedvaLeCu3vUnique != null)
		{
			if (enumPublicSealedvaLeCu3vUnique == 1)
			{
				string string_0 = Data[1].ToString();
				if (!Class66.CheckFileID(string_0))
				{
					Class66.LimitActor(PhotonPlayer.ActorID(), EventCode, "Invalid custom Emoji", 20);
					return false;
				}
				string s = JsonSerializer.Serialize<Dictionary<byte, object>>(Data, null);
				string item = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
				if (Class66.list_0.Contains(item))
				{
					Class66.LimitActor(PhotonPlayer.ActorID(), EventCode, "Blacklisted", 20);
					return false;
				}
				Class66.list_0.Add(item);
				APIEmoji.Fetch(string_0, delegate(APIEmoji Emoji)
				{
					string b = PhotonPlayer.UserID();
					if (Emoji.ownerId != b || Emoji.animationStyle == null)
					{
						Class66.LimitActor(PhotonPlayer.ActorID(), EventCode, "Invalid custom Emoji", 20);
					}
					string text2 = PhotonPlayer.DisplayName() ?? "NO NAME";
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(24, 3);
					defaultInterpolatedStringHandler2.AppendFormatted(text2);
					defaultInterpolatedStringHandler2.AppendLiteral(" used a custom Emoji ");
					defaultInterpolatedStringHandler2.AppendFormatted(string_0);
					defaultInterpolatedStringHandler2.AppendLiteral(" [");
					defaultInterpolatedStringHandler2.AppendFormatted(Emoji.animationStyle);
					defaultInterpolatedStringHandler2.AppendLiteral("]");
					Logger.Log(defaultInterpolatedStringHandler2.ToStringAndClear(), Logger.LogsType.Room);
					Class53.Log(text2 + " --> " + string_0, Class53.LogsType.Emoji);
				}, delegate(string error)
				{
					Class66.LimitActor(PhotonPlayer.ActorID(), EventCode, "Invalid custom Emoji", 20);
				});
			}
		}
		else
		{
			int num = Convert.ToInt32(Data[2]);
			if (num < 0 || num > 64)
			{
				Class66.LimitActor(PhotonPlayer.ActorID(), EventCode, "Invalid legacy Emoji", 20);
				return false;
			}
			string s2 = JsonSerializer.Serialize<Dictionary<byte, object>>(Data, null);
			string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s2));
			text += PhotonPlayer.ActorID().ToString();
			if (Class66.list_0.Contains(text))
			{
				Class66.LimitActor(PhotonPlayer.ActorID(), EventCode, "Blacklisted", 20);
				return false;
			}
			Class66.list_0.Add(text);
			string value = PhotonPlayer.DisplayName() ?? "NO NAME";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(" used a legacy Emoji [");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Room);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(" --> ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			Class53.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Class53.LogsType.Emoji);
		}
		return !Class143.bool_13;
	}

	// Token: 0x06000395 RID: 917 RVA: 0x000126E8 File Offset: 0x000108E8
	public static bool RaisedEmojiEvent(Dictionary<byte, object> Data)
	{
		if ((EnumPublicSealedvaLeCu3vUnique)Data[0] == null)
		{
		}
		return true;
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00002F82 File Offset: 0x00001182
	internal static bool bPVjZ3nLhNjxdD7B7Wu()
	{
		return Class65.NV5noAnsbkJ8Efd789W == null;
	}

	// Token: 0x040001CC RID: 460
	internal static Class65 NV5noAnsbkJ8Efd789W;
}
