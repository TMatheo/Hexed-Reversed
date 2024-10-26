using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

// Token: 0x0200005B RID: 91
internal class Class48
{
	// Token: 0x060002AF RID: 687 RVA: 0x0000F95C File Offset: 0x0000DB5C
	public static void StartBot()
	{
		new Thread(delegate()
		{
			IPAddress ipaddress = Dns.GetHostEntry("localhost").AddressList[0];
			IPEndPoint localEP = new IPEndPoint(ipaddress, 9999);
			try
			{
				Class48.socket_0 = new Socket(ipaddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
				Class48.socket_0.Bind(localEP);
				Class48.socket_0.Listen(10);
				Class48.socket_1 = Class48.socket_0.Accept();
				goto IL_FD;
			}
			catch
			{
				Class48.StopBot();
				goto IL_FD;
			}
			IL_6B:
			if (!Class48.socket_1.Connected)
			{
				return;
			}
			try
			{
				byte[] array = new byte[5000];
				int count = Class48.socket_1.Receive(array);
				string @string = Encoding.ASCII.GetString(array, 0, count);
				string[] array2;
				if (!@string.Contains('/'))
				{
					(array2 = new string[1])[0] = @string;
				}
				else
				{
					array2 = @string.Split('/', StringSplitOptions.None);
				}
				string[] array3 = array2;
				if (array3[0] == "SelfBot" && array3[1] == "Expose")
				{
					Class48.string_0 = array3[2];
				}
			}
			catch
			{
				Class48.StopBot();
			}
			IL_FD:
			if (Class48.socket_1 != null)
			{
				goto IL_6B;
			}
		})
		{
			IsBackground = true
		}.Start();
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x0000F99C File Offset: 0x0000DB9C
	public static void StopBot()
	{
		Class48.SendMessage("Shutdown");
		Socket socket = Class48.socket_0;
		if (socket != null)
		{
			socket.Close();
		}
		Socket socket2 = Class48.socket_1;
		if (socket2 != null)
		{
			socket2.Close();
		}
		Class48.socket_0 = null;
		Class48.socket_1 = null;
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x0000F9E0 File Offset: 0x0000DBE0
	private static void SendMessage(string Message)
	{
		if (Class48.socket_1 != null && Class48.socket_1.Connected)
		{
			Class48.socket_1.Send(Encoding.ASCII.GetBytes(Message));
		}
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x0000FA18 File Offset: 0x0000DC18
	public static void JoinRoom(string WorldID)
	{
		Class48.SendMessage("JoinRoom/" + WorldID);
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x0000FA38 File Offset: 0x0000DC38
	public static void LeaveRoom()
	{
		Class48.SendMessage("LeaveRoom");
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x0000FA50 File Offset: 0x0000DC50
	public static void PlayAudioFile(string PathB64)
	{
		Class48.SendMessage("HandleAudio/PlayAudio/" + PathB64);
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x0000FA70 File Offset: 0x0000DC70
	public static void PlayTextToVoice(string Text)
	{
		Class48.SendMessage("HandleAudio/TextToVoice/" + Text);
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x0000FA90 File Offset: 0x0000DC90
	public static void PlayYoutube(string URL)
	{
		Class48.SendMessage("HandleAudio/PlayYoutube/" + URL);
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
	public static void StopAudioReplay()
	{
		Class48.SendMessage("HandleAudio/StopAudio");
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
	public static void ChangeAudioVolume(bool Increase)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
		defaultInterpolatedStringHandler.AppendLiteral("HandleAudio/ChangeVolume/");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(Increase);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x0000FB00 File Offset: 0x0000DD00
	public static void ResetAudioVolume()
	{
		Class48.SendMessage("HandleAudio/ResetVolume");
	}

	// Token: 0x060002BA RID: 698 RVA: 0x0000FB18 File Offset: 0x0000DD18
	public static void MimicMovement(int Actor)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
		defaultInterpolatedStringHandler.AppendLiteral("HandleMimic/Movement/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(Actor);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002BB RID: 699 RVA: 0x0000FB50 File Offset: 0x0000DD50
	public static void MimicAvatarSync(int Actor)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 1);
		defaultInterpolatedStringHandler.AppendLiteral("HandleMimic/AvatarSync/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(Actor);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002BC RID: 700 RVA: 0x0000FB88 File Offset: 0x0000DD88
	public static void MimicVoice(int Actor)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
		defaultInterpolatedStringHandler.AppendLiteral("HandleMimic/Voice/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(Actor);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002BD RID: 701 RVA: 0x0000FBC0 File Offset: 0x0000DDC0
	public static void MimicRPC(int Actor)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
		defaultInterpolatedStringHandler.AppendLiteral("HandleMimic/RPC/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(Actor);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002BE RID: 702 RVA: 0x0000FBF8 File Offset: 0x0000DDF8
	public static void MimicChat(int Actor)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
		defaultInterpolatedStringHandler.AppendLiteral("HandleMimic/Chat/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(Actor);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002BF RID: 703 RVA: 0x0000FC30 File Offset: 0x0000DE30
	public static void ChangePositionOffset(string coordinate, bool Increase)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
		defaultInterpolatedStringHandler.AppendLiteral("HandleMovementOffset/Pos");
		defaultInterpolatedStringHandler.AppendFormatted(coordinate);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(Increase);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x0000FC7C File Offset: 0x0000DE7C
	public static void ChangeRotationOffset(string coordinate, bool Increase)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
		defaultInterpolatedStringHandler.AppendLiteral("HandleMovementOffset/Rot");
		defaultInterpolatedStringHandler.AppendFormatted(coordinate);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(Increase);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x0000FCC8 File Offset: 0x0000DEC8
	public static void ResetPositionOffset(string coordinate)
	{
		Class48.SendMessage("HandleMovementOffset/Reset" + coordinate + "Pos");
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x0000FCEC File Offset: 0x0000DEEC
	public static void ResetRotationOffset(string coordinate)
	{
		Class48.SendMessage("HandleMovementOffset/Reset" + coordinate + "Rot");
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x0000FD10 File Offset: 0x0000DF10
	public static void ChangeOrbitRange(bool Increase)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
		defaultInterpolatedStringHandler.AppendLiteral("HandleOrbit/Range/");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(Increase);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x0000FD48 File Offset: 0x0000DF48
	public static void ChangeOrbitSpeed(bool Increase)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
		defaultInterpolatedStringHandler.AppendLiteral("HandleOrbit/Speed/");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(Increase);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x0000FD80 File Offset: 0x0000DF80
	public static void ResetOrbitRange()
	{
		Class48.SendMessage("HandleOrbit/ResetRange");
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x0000FD98 File Offset: 0x0000DF98
	public static void ResetOrbitSpeed()
	{
		Class48.SendMessage("HandleOrbit/ResetSpeed");
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
	public static void FreezePosition(bool State)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
		defaultInterpolatedStringHandler.AppendLiteral("FreezePosition/");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(State);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x0000FDE8 File Offset: 0x0000DFE8
	public static void FreezeRotation(bool State)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 1);
		defaultInterpolatedStringHandler.AppendLiteral("FreezeRotation/");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(State);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x0000FE20 File Offset: 0x0000E020
	public static void ChangeAvatar(string ID)
	{
		Class48.SendMessage("ChangeAvatar/" + ID);
	}

	// Token: 0x060002CA RID: 714 RVA: 0x0000FE40 File Offset: 0x0000E040
	public static void ChangeFallbackAvatar(string ID)
	{
		Class48.SendMessage("ChangeFallbackAvatar/" + ID);
	}

	// Token: 0x060002CB RID: 715 RVA: 0x0000FE60 File Offset: 0x0000E060
	public static void ChangeStatus(string Text)
	{
		Class48.SendMessage("ChangeStatus/" + Text);
	}

	// Token: 0x060002CC RID: 716 RVA: 0x0000FE80 File Offset: 0x0000E080
	public static void ChangeBio(string Text)
	{
		Class48.SendMessage("ChangeBio/" + Text);
	}

	// Token: 0x060002CD RID: 717 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
	public static void ChatMessage(string message)
	{
		Class48.SendMessage("SendChat/" + message);
	}

	// Token: 0x060002CE RID: 718 RVA: 0x0000FEC0 File Offset: 0x0000E0C0
	public static void AvatarHeight(int Height)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
		defaultInterpolatedStringHandler.AppendLiteral("AvatarHeight/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(Height);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002CF RID: 719 RVA: 0x0000FEF8 File Offset: 0x0000E0F8
	public static void Block(string UserID, bool State)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
		defaultInterpolatedStringHandler.AppendLiteral("HandleBlock/");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(State);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted(UserID);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x0000FF44 File Offset: 0x0000E144
	public static void Mute(string UserID, bool State)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
		defaultInterpolatedStringHandler.AppendLiteral("HandleMute/");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(State);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted(UserID);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x0000FF90 File Offset: 0x0000E190
	public static void CacheCrash()
	{
		Class48.SendMessage("HandleExploit/CacheCrash");
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
	public static void VoiceCrash()
	{
		Class48.SendMessage("HandleExploit/VoiceCrash");
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
	public static void Forcekick(string UserID)
	{
		Class48.SendMessage("HandleExploit/Forcekick/" + UserID);
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x0000FFE0 File Offset: 0x0000E1E0
	public static void AFKMode(bool State)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
		defaultInterpolatedStringHandler.AppendLiteral("HandleAFK/");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(State);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00010018 File Offset: 0x0000E218
	public static void CameraFollowMode(bool State)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
		defaultInterpolatedStringHandler.AppendLiteral("HandleCameraFollow/");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(State);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x00010050 File Offset: 0x0000E250
	public static void LoopAnimationRecord(bool State)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
		defaultInterpolatedStringHandler.AppendLiteral("HandleMovementRecord/Loop/");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(State);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x00010088 File Offset: 0x0000E288
	public static void PlayMotionFile(string Name)
	{
		Class48.SendMessage("HandleMovementRecord/Play/" + Name);
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x000100A8 File Offset: 0x0000E2A8
	public static void StopMotionReplay()
	{
		Class48.SendMessage("HandleMovementRecord/Stop");
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x000100C0 File Offset: 0x0000E2C0
	public static void StartRecordMotion(int Actor, string Filename)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 2);
		defaultInterpolatedStringHandler.AppendLiteral("HandleMovementRecord/StartRecord/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(Actor);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted(Filename);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002DA RID: 730 RVA: 0x0001010C File Offset: 0x0000E30C
	public static void StopRecordMotion()
	{
		Class48.SendMessage("HandleMovementRecord/StopRecord");
	}

	// Token: 0x060002DB RID: 731 RVA: 0x00010124 File Offset: 0x0000E324
	public static void AddFriend(string UserID)
	{
		Class48.SendMessage("HandleFriend/Add/" + UserID);
	}

	// Token: 0x060002DC RID: 732 RVA: 0x00010144 File Offset: 0x0000E344
	public static void SelfbotExpose()
	{
		Class48.string_0 = null;
		Class48.SendMessage("SelfBot/Expose");
	}

	// Token: 0x060002DD RID: 733 RVA: 0x00010164 File Offset: 0x0000E364
	public static void SelfbotVoice(string Base64)
	{
		Class48.SendMessage("SelfBot/Voice/" + Base64);
	}

	// Token: 0x060002DE RID: 734 RVA: 0x00010184 File Offset: 0x0000E384
	public static void SelfbotMovement(string Base64)
	{
		Class48.SendMessage("SelfBot/Movement/" + Base64);
	}

	// Token: 0x060002DF RID: 735 RVA: 0x000101A4 File Offset: 0x0000E3A4
	public static void SelfbotAvatarSync(string Base64)
	{
		Class48.SendMessage("SelfBot/AvatarSync/" + Base64);
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x000101C4 File Offset: 0x0000E3C4
	public static void SelfbotChat(string Message)
	{
		Class48.SendMessage("SelfBot/Chat/" + Message);
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x000101E4 File Offset: 0x0000E3E4
	public static void ChatCommands(bool State)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
		defaultInterpolatedStringHandler.AppendLiteral("HandleChatCommands/");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(State);
		Class48.SendMessage(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x00002D06 File Offset: 0x00000F06
	internal static bool FmYoKvni1figVB71cxO()
	{
		return Class48.sEQwJxnHi3WVfjGY26n == null;
	}

	// Token: 0x04000131 RID: 305
	private static Socket socket_0;

	// Token: 0x04000132 RID: 306
	private static Socket socket_1;

	// Token: 0x04000133 RID: 307
	public static string string_0;

	// Token: 0x04000134 RID: 308
	internal static Class48 sEQwJxnHi3WVfjGY26n;
}
