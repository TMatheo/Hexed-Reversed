using System;
using System.Runtime.CompilerServices;
using Hexed.UIApi;
using Il2CppSystem;
using Photon.Realtime;
using VRC;

// Token: 0x02000054 RID: 84
internal class Class44 : Interface2
{
	// Token: 0x0600027C RID: 636 RVA: 0x00002328 File Offset: 0x00000528
	public void Initialize()
	{
	}

	// Token: 0x0600027D RID: 637 RVA: 0x0000E7A4 File Offset: 0x0000C9A4
	public void OnUpdate()
	{
		if (!Class4.IsInWorld())
		{
			return;
		}
		Player selectedPlayer = Class9.GetSelectedPlayer();
		if (Class122.uitextMeshText_0 != null && MenuHelper.QuickMenu.isActiveAndEnabled && !(selectedPlayer == null))
		{
			Class122.uitextMeshText_0.SetText(Class44.GetPlayerString(selectedPlayer.GetPhotonPlayer()));
			return;
		}
	}

	// Token: 0x0600027E RID: 638 RVA: 0x0000E7F4 File Offset: 0x0000C9F4
	private static string GetPlayerString(Player PhotonPlayer)
	{
		Player player = PhotonPlayer.GetPlayer();
		if (!(player == null) && player.smethod_0() != null)
		{
			string[] array = new string[16];
			array[0] = "Name: " + player.DisplayName();
			array[1] = "Status: " + player.smethod_0().status;
			int num = 2;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Actor: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(PhotonPlayer.ActorID());
			array[num] = defaultInterpolatedStringHandler.ToStringAndClear();
			int num2 = 3;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
			defaultInterpolatedStringHandler.AppendLiteral("FPS: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(player.GetFrames());
			array[num2] = defaultInterpolatedStringHandler.ToStringAndClear();
			int num3 = 4;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Ping: ");
			defaultInterpolatedStringHandler.AppendFormatted<short>(player.GetPing());
			array[num3] = defaultInterpolatedStringHandler.ToStringAndClear();
			int num4 = 5;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Quality: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(player.GetQualityPercentage());
			defaultInterpolatedStringHandler.AppendLiteral("%");
			array[num4] = defaultInterpolatedStringHandler.ToStringAndClear();
			array[6] = "Avatar Name: " + player.GetAvatar().name;
			array[7] = "Avatar Author: " + player.GetAvatar().authorName;
			array[8] = "Avatar Version: " + player.GetAvatar().unityVersion;
			int num5 = 9;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Avatar Updated: ");
			defaultInterpolatedStringHandler.AppendFormatted<DateTime>(player.GetAvatar().updated_at);
			array[num5] = defaultInterpolatedStringHandler.ToStringAndClear();
			array[10] = "Avatar Status: " + player.GetAvatar().releaseStatus;
			array[11] = "Fallback Name: " + player.GetFallbackAvatar().name;
			array[12] = "Fallback Author: " + player.GetFallbackAvatar().authorName;
			array[13] = "Fallback Version: " + player.GetFallbackAvatar().unityVersion;
			int num6 = 14;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Fallback Updated: ");
			defaultInterpolatedStringHandler.AppendFormatted<DateTime>(player.GetFallbackAvatar().updated_at);
			array[num6] = defaultInterpolatedStringHandler.ToStringAndClear();
			array[15] = "Fallback Status: " + player.GetFallbackAvatar().releaseStatus;
			string[] value = array;
			return string.Join("\n", value);
		}
		return "";
	}

	// Token: 0x06000280 RID: 640 RVA: 0x00002C93 File Offset: 0x00000E93
	internal static bool eXKUyDNDNykSGM6UxGa()
	{
		return Class44.b6kXSkNmbwSaPwI0Yh2 == null;
	}

	// Token: 0x0400011E RID: 286
	internal static Class44 b6kXSkNmbwSaPwI0Yh2;
}
