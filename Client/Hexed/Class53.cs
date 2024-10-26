using System;
using System.Collections.Generic;
using Hexed.UIApi;

// Token: 0x0200006C RID: 108
internal class Class53
{
	// Token: 0x0600034A RID: 842 RVA: 0x0001109C File Offset: 0x0000F29C
	public static void Log(object logObj, Class53.LogsType Type)
	{
		if (logObj == null)
		{
			return;
		}
		string text = logObj.ToString();
		switch (Type)
		{
		case Class53.LogsType.Notification:
			text = "<color=#dd00ff>[" + DateTime.Now.ToShortTimeString() + "] [Notification]:</color>  " + text;
			break;
		case Class53.LogsType.Emoji:
			text = "<color=#475400>[" + DateTime.Now.ToShortTimeString() + "] [Emoji]:</color>  " + text;
			break;
		case Class53.LogsType.Emote:
			text = "<color=#540038>[" + DateTime.Now.ToShortTimeString() + "] [Emote]:</color>  " + text;
			break;
		case Class53.LogsType.Mute:
			text = "<color=#00ffea>[" + DateTime.Now.ToShortTimeString() + "] [Mute]:</color>  " + text;
			break;
		case Class53.LogsType.Block:
			text = "<color=#ad0000>[" + DateTime.Now.ToShortTimeString() + "] [Block]:</color>  " + text;
			break;
		case Class53.LogsType.Avatar:
			text = "<color=#4800ff>[" + DateTime.Now.ToShortTimeString() + "] [Avatar]:</color>  " + text;
			break;
		case Class53.LogsType.Connect:
			text = "<color=#00ff04>[" + DateTime.Now.ToShortTimeString() + "] [Connected]:</color>  " + text;
			break;
		case Class53.LogsType.Disconnect:
			text = "<color=#ff1a1a>[" + DateTime.Now.ToShortTimeString() + "] [Disconnected]:</color>  " + text;
			break;
		case Class53.LogsType.Portal:
			text = "<color=#030b82>[" + DateTime.Now.ToShortTimeString() + "] [Portal]:</color>  " + text;
			break;
		case Class53.LogsType.Sticker:
			text = "<color=#17e2c4>[" + DateTime.Now.ToShortTimeString() + "] [Sticker]:</color>  " + text;
			break;
		case Class53.LogsType.Moderation:
			text = "<color=#426ff5>[" + DateTime.Now.ToShortTimeString() + "] [Moderation]:</color>  " + text;
			break;
		case Class53.LogsType.Online:
			text = "<color=#77eb34>[" + DateTime.Now.ToShortTimeString() + "] [Online]:</color>  " + text;
			break;
		case Class53.LogsType.Offline:
			text = "<color=#eb4634>[" + DateTime.Now.ToShortTimeString() + "] [Offline]:</color>  " + text;
			break;
		case Class53.LogsType.Friend:
			text = "<color=#ccff00>[" + DateTime.Now.ToShortTimeString() + "] [Friend]:</color>  " + text;
			break;
		case Class53.LogsType.Group:
			text = "<color=#008f8c>[" + DateTime.Now.ToShortTimeString() + "] [Group]:</color>  " + text;
			break;
		case Class53.LogsType.World:
			text = "<color=#db5400>[" + DateTime.Now.ToShortTimeString() + "] [World]:</color>  " + text;
			break;
		case Class53.LogsType.Protection:
			text = "<color=#c42525>[" + DateTime.Now.ToShortTimeString() + "] [Protection]:</color>  " + text;
			break;
		case Class53.LogsType.Camera:
			text = "<color=#ff0073>[" + DateTime.Now.ToShortTimeString() + "] [Camera]:</color>  " + text;
			break;
		case Class53.LogsType.Room:
			text = "<color=#266f70>[" + DateTime.Now.ToShortTimeString() + "] [Room]:</color>  " + text;
			break;
		case Class53.LogsType.Pedestal:
			text = "<color=#ffffff>[" + DateTime.Now.ToShortTimeString() + "] [Pedestal]:</color>  " + text;
			break;
		case Class53.LogsType.Content:
			text = "<color=#ff63e8>[" + DateTime.Now.ToShortTimeString() + "] [Content]:</color>  " + text;
			break;
		case Class53.LogsType.Queue:
			text = "<color=#ff63a1>[" + DateTime.Now.ToShortTimeString() + "] [Queue]:</color>  " + text;
			break;
		}
		Class53.list_0.Insert(0, text);
		if (Class53.list_0.Count > 21)
		{
			Class53.list_0.RemoveAt(21);
		}
		UIMenuText uimenuText_ = Class118.uimenuText_0;
		if (uimenuText_ != null)
		{
			uimenuText_.SetText(string.Join("\n", Class53.list_0));
			return;
		}
	}

	// Token: 0x0600034D RID: 845 RVA: 0x00002E80 File Offset: 0x00001080
	internal static bool qSleSdnvPQYCwV6wNsQ()
	{
		return Class53.DAq933nxrJrEyMKEALb == null;
	}

	// Token: 0x04000179 RID: 377
	private static readonly List<string> list_0 = new List<string>();

	// Token: 0x0400017A RID: 378
	private static Class53 DAq933nxrJrEyMKEALb;

	// Token: 0x0200006D RID: 109
	public enum LogsType
	{
		// Token: 0x0400017C RID: 380
		Notification,
		// Token: 0x0400017D RID: 381
		Emoji,
		// Token: 0x0400017E RID: 382
		Emote,
		// Token: 0x0400017F RID: 383
		Mute,
		// Token: 0x04000180 RID: 384
		Block,
		// Token: 0x04000181 RID: 385
		Avatar,
		// Token: 0x04000182 RID: 386
		Connect,
		// Token: 0x04000183 RID: 387
		Disconnect,
		// Token: 0x04000184 RID: 388
		Portal,
		// Token: 0x04000185 RID: 389
		Sticker,
		// Token: 0x04000186 RID: 390
		Moderation,
		// Token: 0x04000187 RID: 391
		Online,
		// Token: 0x04000188 RID: 392
		Offline,
		// Token: 0x04000189 RID: 393
		Friend,
		// Token: 0x0400018A RID: 394
		Group,
		// Token: 0x0400018B RID: 395
		World,
		// Token: 0x0400018C RID: 396
		Protection,
		// Token: 0x0400018D RID: 397
		Camera,
		// Token: 0x0400018E RID: 398
		Room,
		// Token: 0x0400018F RID: 399
		Pedestal,
		// Token: 0x04000190 RID: 400
		Content,
		// Token: 0x04000191 RID: 401
		Queue
	}
}
