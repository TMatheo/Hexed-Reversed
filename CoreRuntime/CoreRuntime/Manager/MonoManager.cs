using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Interfaces;
using CoreRuntime.Wrappers;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace CoreRuntime.Manager
{
	// Token: 0x0200000C RID: 12
	public class MonoManager
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00003DC8 File Offset: 0x00001FC8
		internal static void CheckBaseHooks()
		{
			int num = 11;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_E4;
					case 2:
						Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(899193066 ^ 1833790969 ^ 15479112 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_23fddb7baea1434bb794ffb26571c6db));
						num2 = 9;
						continue;
					case 3:
						Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1264955662 ^ -1501923003 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_0d12433093534f2c94a3623f38521c46));
						num2 = 1;
						if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_abcb54034558476aaf1951a09e1b79df != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 5:
						goto IL_79;
					case 6:
						goto IL_BB;
					case 7:
						Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(-997777185 ^ -1106952038 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_172533a79ba7495d81d7b55862d3ed70));
						num2 = 8;
						continue;
					case 8:
						goto IL_122;
					case 9:
						goto IL_50;
					case 10:
						goto IL_BB;
					case 11:
						if (MonoManager.originalUpdate != null)
						{
							num2 = 10;
							continue;
						}
						goto IL_79;
					case 12:
						goto IL_F8;
					}
					return;
					IL_50:
					if (MonoManager.originalOnApplicationQuit == null)
					{
						goto IL_F8;
					}
					num2 = 0;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_075c1a007c1f4defb3641fe607b4018f != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_BB:
					if (MonoManager.originalLateUpdate == null)
					{
						num2 = 3;
						if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_9a072d45b7c649c39a88ec471b6efdd0 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					IL_E4:
					if (MonoManager.originalFixedUpdate == null)
					{
						num2 = 7;
						continue;
					}
					goto IL_122;
					IL_F8:
					Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(817209202 ^ 1803120873 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_9f6e9c23a00442da9e4a42b6d69a56ca));
					num2 = 4;
					continue;
					IL_122:
					if (MonoManager.originalOnGUI != null)
					{
						goto IL_50;
					}
					num2 = 2;
				}
				IL_79:
				Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(~-1269817019 ^ 1712855122 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_9aed36fa797e461e98c578cb5ad6472b));
				num = 6;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003FDC File Offset: 0x000021DC
		public static void PatchUpdate(MethodInfo method)
		{
			int num = 7;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_6C;
				case 1:
					if (SmEfxakRSirVGEfGwMV.Vkgsu7Vsh(method, SmEfxakRSirVGEfGwMV.RdGk4lnAPV))
					{
						num2 = 5;
						continue;
					}
					break;
				case 2:
					return;
				case 3:
					break;
				case 4:
					return;
				case 5:
					goto IL_6C;
				case 6:
					return;
				case 7:
					if (MonoManager.originalUpdate != null)
					{
						num2 = 6;
						continue;
					}
					if (j6DRtekpQbb7WaLEdSb.Vkgsu7Vsh(hTjuG7kL7FEnPsTZEIN.Vkgsu7Vsh(method, hTjuG7kL7FEnPsTZEIN.VPrkrttxWb), leXdUdkQnIXIpKm4I85.Vkgsu7Vsh(typeof(void).TypeHandle, leXdUdkQnIXIpKm4I85.WhGkIJZ1F5), j6DRtekpQbb7WaLEdSb.Yj3kk4a0r5))
					{
						goto IL_6C;
					}
					num2 = 1;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_c41248e324ff4126a99c2492f21b311a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				default:
					goto IL_6C;
				}
				if (MCDlyIkNWsN2UoU5bhV.Vkgsu7Vsh(method, MCDlyIkNWsN2UoU5bhV.pipkDflj0V).Length == 0)
				{
					MonoManager.Update detour;
					if ((detour = MonoManager.<>O.<0>__patchedUpdate) == null)
					{
						detour = (MonoManager.<>O.<0>__patchedUpdate = new MonoManager.Update(MonoManager.patchedUpdate));
					}
					MonoManager.originalUpdate = HookManager.Detour<MonoManager.Update>(method, detour);
					num2 = 4;
					continue;
				}
				num2 = 0;
				if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_4cf3c3fa031b46e5bf2b83f67aac5018 == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_6C:
				Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1997877993 ^ -902150121 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_862f0cb2a8b74fceb562be040fec13c5));
				num2 = 2;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000413C File Offset: 0x0000233C
		private static void patchedUpdate(IntPtr instance)
		{
			MonoManager.originalUpdate(instance);
			foreach (HexedCheat hexedCheat in CheatManager.LoadedCheats)
			{
				try
				{
					hexedCheat.OnUpdate();
				}
				catch (Exception value)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 2);
					PHliwfftrtxnGUGv86.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, hexedCheat.Identifier, PHliwfftrtxnGUGv86.PPaXybFhf);
					OllYaFLKfaVbHwoY0T.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1860055284 ^ 1978570387 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_a25bb9e7fa324a7b8a59c54768fe60bf), OllYaFLKfaVbHwoY0T.jdbri0BdE);
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
					Logger.LogError(HUqyQtK9vUO9bfISNY.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, HUqyQtK9vUO9bfISNY.IYKFLW0NA));
				}
			}
			for (int i = CoroutineManager.QueuedEnums.Count - 1; i >= 0; i--)
			{
				try
				{
					if (!CoroutineManager.QueuedEnums[i].MoveNext())
					{
						CoroutineManager.QueuedEnums.RemoveAt(i);
					}
				}
				catch (Exception value2)
				{
					CoroutineManager.QueuedEnums.RemoveAt(i);
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 1);
					OllYaFLKfaVbHwoY0T.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1299626116 << 1 ^ -1207766101 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_9659e700394c4bbbb6e5a258b827bed3), OllYaFLKfaVbHwoY0T.jdbri0BdE);
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(value2);
					Logger.LogError(HUqyQtK9vUO9bfISNY.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, HUqyQtK9vUO9bfISNY.IYKFLW0NA));
				}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000042D8 File Offset: 0x000024D8
		public static void PatchLateUpdate(MethodInfo method)
		{
			int num = 6;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_BA;
				case 2:
					goto IL_114;
				case 3:
					goto IL_BA;
				case 4:
					goto IL_BA;
				case 5:
					if (j6DRtekpQbb7WaLEdSb.Vkgsu7Vsh(hTjuG7kL7FEnPsTZEIN.Vkgsu7Vsh(method, hTjuG7kL7FEnPsTZEIN.VPrkrttxWb), leXdUdkQnIXIpKm4I85.Vkgsu7Vsh(typeof(void).TypeHandle, leXdUdkQnIXIpKm4I85.WhGkIJZ1F5), j6DRtekpQbb7WaLEdSb.Yj3kk4a0r5))
					{
						num2 = 4;
						continue;
					}
					goto IL_F9;
				case 6:
					if (MonoManager.originalLateUpdate != null)
					{
						return;
					}
					num2 = 5;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_4cf3c3fa031b46e5bf2b83f67aac5018 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 7:
					goto IL_F9;
				case 8:
					return;
				case 9:
					return;
				}
				break;
				IL_BA:
				Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(631918530 ^ 1907026746 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_434d3901588e427a807b42f125cc2ce3));
				num2 = 0;
				if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_23fddb7baea1434bb794ffb26571c6db == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_F9:
				if (SmEfxakRSirVGEfGwMV.Vkgsu7Vsh(method, SmEfxakRSirVGEfGwMV.RdGk4lnAPV))
				{
					num2 = 3;
					continue;
				}
				IL_114:
				if (MCDlyIkNWsN2UoU5bhV.Vkgsu7Vsh(method, MCDlyIkNWsN2UoU5bhV.pipkDflj0V).Length != 0)
				{
					num2 = 1;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_6226b80b5fc842f9857771e1a90c2050 != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					MonoManager.LateUpdate detour;
					if ((detour = MonoManager.<>O.<1>__patchedLateUpdate) == null)
					{
						detour = (MonoManager.<>O.<1>__patchedLateUpdate = new MonoManager.LateUpdate(MonoManager.patchedLateUpdate));
					}
					MonoManager.originalLateUpdate = HookManager.Detour<MonoManager.LateUpdate>(method, detour);
					num2 = 9;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_3ee7942d157b4c98a6cfe7cc07264776 == 0)
					{
						num2 = 2;
					}
				}
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000449C File Offset: 0x0000269C
		private static void patchedLateUpdate(IntPtr instance)
		{
			MonoManager.originalLateUpdate(instance);
			foreach (HexedCheat hexedCheat in CheatManager.LoadedCheats)
			{
				try
				{
					hexedCheat.OnLateUpdate();
				}
				catch (Exception value)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
					PHliwfftrtxnGUGv86.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, hexedCheat.Identifier, PHliwfftrtxnGUGv86.PPaXybFhf);
					OllYaFLKfaVbHwoY0T.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1550927492 ^ -1922175024 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_29a622e4e384424e811102658c7b2ac7), OllYaFLKfaVbHwoY0T.jdbri0BdE);
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
					Logger.LogError(HUqyQtK9vUO9bfISNY.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, HUqyQtK9vUO9bfISNY.IYKFLW0NA));
				}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000457C File Offset: 0x0000277C
		public static void PatchFixedUpdate(MethodInfo method)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_DD;
				case 1:
					return;
				case 2:
					if (MonoManager.originalFixedUpdate != null)
					{
						num2 = 1;
						if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_8336580d1f0445238d6836f5e92b70db == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					else
					{
						if (j6DRtekpQbb7WaLEdSb.Vkgsu7Vsh(hTjuG7kL7FEnPsTZEIN.Vkgsu7Vsh(method, hTjuG7kL7FEnPsTZEIN.VPrkrttxWb), leXdUdkQnIXIpKm4I85.Vkgsu7Vsh(typeof(void).TypeHandle, leXdUdkQnIXIpKm4I85.WhGkIJZ1F5), j6DRtekpQbb7WaLEdSb.Yj3kk4a0r5))
						{
							num2 = 7;
							continue;
						}
						goto IL_DD;
					}
					break;
				case 3:
					return;
				case 4:
					break;
				case 5:
				{
					MonoManager.FixedUpdate detour;
					if ((detour = MonoManager.<>O.<2>__patchedFixedUpdate) == null)
					{
						detour = (MonoManager.<>O.<2>__patchedFixedUpdate = new MonoManager.FixedUpdate(MonoManager.patchedFixedUpdate));
					}
					MonoManager.originalFixedUpdate = HookManager.Detour<MonoManager.FixedUpdate>(method, detour);
					num2 = 3;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_14220072943b47f99fd6e94ff4c63aa5 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				case 6:
					return;
				case 7:
					break;
				case 8:
					if (MCDlyIkNWsN2UoU5bhV.Vkgsu7Vsh(method, MCDlyIkNWsN2UoU5bhV.pipkDflj0V).Length == 0)
					{
						num2 = 5;
						continue;
					}
					break;
				default:
					goto IL_DD;
				}
				IL_40:
				Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1046343599 ^ -909454055 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_65a08a5c2ec14c03a6ad53769cd71a85));
				num2 = 6;
				continue;
				IL_DD:
				if (SmEfxakRSirVGEfGwMV.Vkgsu7Vsh(method, SmEfxakRSirVGEfGwMV.RdGk4lnAPV))
				{
					goto IL_40;
				}
				num2 = 8;
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000471C File Offset: 0x0000291C
		private static void patchedFixedUpdate(IntPtr instance)
		{
			MonoManager.originalFixedUpdate(instance);
			foreach (HexedCheat hexedCheat in CheatManager.LoadedCheats)
			{
				try
				{
					hexedCheat.OnFixedUpdate();
				}
				catch (Exception value)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
					PHliwfftrtxnGUGv86.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, hexedCheat.Identifier, PHliwfftrtxnGUGv86.PPaXybFhf);
					OllYaFLKfaVbHwoY0T.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(503552573 ^ 1331799174 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_8336580d1f0445238d6836f5e92b70db), OllYaFLKfaVbHwoY0T.jdbri0BdE);
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
					Logger.LogError(HUqyQtK9vUO9bfISNY.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, HUqyQtK9vUO9bfISNY.IYKFLW0NA));
				}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000047FC File Offset: 0x000029FC
		public static void PatchOnGUI(MethodInfo method)
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_DD;
				case 2:
					if (!j6DRtekpQbb7WaLEdSb.Vkgsu7Vsh(hTjuG7kL7FEnPsTZEIN.Vkgsu7Vsh(method, hTjuG7kL7FEnPsTZEIN.VPrkrttxWb), leXdUdkQnIXIpKm4I85.Vkgsu7Vsh(typeof(void).TypeHandle, leXdUdkQnIXIpKm4I85.WhGkIJZ1F5), j6DRtekpQbb7WaLEdSb.Yj3kk4a0r5))
					{
						goto IL_C3;
					}
					num2 = 8;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_8336580d1f0445238d6836f5e92b70db == 0)
					{
						num2 = 7;
						continue;
					}
					continue;
				case 3:
					if (MonoManager.originalOnGUI == null)
					{
						num2 = 2;
						continue;
					}
					return;
				case 4:
				{
					MonoManager.OnGUI detour;
					if ((detour = MonoManager.<>O.<3>__patchedOnGUI) == null)
					{
						detour = (MonoManager.<>O.<3>__patchedOnGUI = new MonoManager.OnGUI(MonoManager.patchedOnGUI));
					}
					MonoManager.originalOnGUI = HookManager.Detour<MonoManager.OnGUI>(method, detour);
					num2 = 0;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_c562bff83da649f1af22aec8f521fe1d != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				case 5:
					return;
				case 6:
					goto IL_C3;
				case 7:
					goto IL_10D;
				case 8:
					goto IL_10D;
				case 9:
					goto IL_10D;
				case 10:
					return;
				}
				break;
				IL_C3:
				if (SmEfxakRSirVGEfGwMV.Vkgsu7Vsh(method, SmEfxakRSirVGEfGwMV.RdGk4lnAPV))
				{
					num2 = 7;
					continue;
				}
				IL_DD:
				if (MCDlyIkNWsN2UoU5bhV.Vkgsu7Vsh(method, MCDlyIkNWsN2UoU5bhV.pipkDflj0V).Length == 0)
				{
					num2 = 0;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_4cbcb2d46d6c4286be8cf3e1dde6ad8c != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				}
				IL_10D:
				Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(817209202 ^ 1754028539 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_23fddb7baea1434bb794ffb26571c6db));
				num2 = 5;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000049D4 File Offset: 0x00002BD4
		private static void patchedOnGUI(IntPtr instance)
		{
			MonoManager.originalOnGUI(instance);
			foreach (HexedCheat hexedCheat in CheatManager.LoadedCheats)
			{
				try
				{
					hexedCheat.OnGUI();
				}
				catch (Exception value)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
					PHliwfftrtxnGUGv86.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, hexedCheat.Identifier, PHliwfftrtxnGUGv86.PPaXybFhf);
					OllYaFLKfaVbHwoY0T.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(817209202 ^ 1695370734 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_d86c12eaffe948379f2fdd025e8e5bb5), OllYaFLKfaVbHwoY0T.jdbri0BdE);
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
					Logger.LogError(HUqyQtK9vUO9bfISNY.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, HUqyQtK9vUO9bfISNY.IYKFLW0NA));
				}
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004AB4 File Offset: 0x00002CB4
		public static void PatchOnApplicationQuit(MethodInfo method)
		{
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_EE;
					case 2:
						if (!j6DRtekpQbb7WaLEdSb.Vkgsu7Vsh(hTjuG7kL7FEnPsTZEIN.Vkgsu7Vsh(method, hTjuG7kL7FEnPsTZEIN.VPrkrttxWb), leXdUdkQnIXIpKm4I85.Vkgsu7Vsh(typeof(void).TypeHandle, leXdUdkQnIXIpKm4I85.WhGkIJZ1F5), j6DRtekpQbb7WaLEdSb.Yj3kk4a0r5))
						{
							goto IL_49;
						}
						num2 = 0;
						if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_6226b80b5fc842f9857771e1a90c2050 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_BB;
					case 4:
						goto IL_15A;
					case 5:
						goto IL_D3;
					case 6:
						return;
					case 7:
						goto IL_49;
					case 8:
					{
						MonoManager.OnApplicationQuit detour;
						if ((detour = MonoManager.<>O.<4>__patchedOnApplicationQuit) == null)
						{
							detour = (MonoManager.<>O.<4>__patchedOnApplicationQuit = new MonoManager.OnApplicationQuit(MonoManager.patchedOnApplicationQuit));
						}
						MonoManager.originalOnApplicationQuit = HookManager.Detour<MonoManager.OnApplicationQuit>(method, detour);
						num2 = 10;
						continue;
					}
					case 9:
						goto IL_AC;
					case 10:
						return;
					}
					goto Block_1;
					IL_49:
					if (SmEfxakRSirVGEfGwMV.Vkgsu7Vsh(method, SmEfxakRSirVGEfGwMV.RdGk4lnAPV))
					{
						num2 = 9;
						continue;
					}
					IL_D3:
					if (MCDlyIkNWsN2UoU5bhV.Vkgsu7Vsh(method, MCDlyIkNWsN2UoU5bhV.pipkDflj0V).Length != 0)
					{
						goto IL_15A;
					}
					num2 = 8;
				}
				IL_BB:
				if (MonoManager.originalOnApplicationQuit == null)
				{
					num = 2;
					continue;
				}
				break;
				IL_15A:
				Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(1908777253 ^ 542817349 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_fb52a29d24de4440b04edf3fddca29f7));
				num = 6;
				continue;
				IL_AC:
				IL_EE:
				goto IL_15A;
			}
			Block_1:;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004C84 File Offset: 0x00002E84
		private static void patchedOnApplicationQuit(IntPtr instance)
		{
			MonoManager.originalOnApplicationQuit(instance);
			foreach (HexedCheat hexedCheat in CheatManager.LoadedCheats)
			{
				try
				{
					hexedCheat.OnApplicationQuit();
				}
				catch (Exception value)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(31, 2);
					PHliwfftrtxnGUGv86.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, hexedCheat.Identifier, PHliwfftrtxnGUGv86.PPaXybFhf);
					OllYaFLKfaVbHwoY0T.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1329859125 ^ 233675800 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_24528a7679a644c78b49b0457f8d9d44), OllYaFLKfaVbHwoY0T.jdbri0BdE);
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
					Logger.LogError(HUqyQtK9vUO9bfISNY.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, HUqyQtK9vUO9bfISNY.IYKFLW0NA));
				}
			}
			veEg0WkfO4fCl5tmQQF.Vkgsu7Vsh(VitR1pcm0SIa2t7r5D.Vkgsu7Vsh(VitR1pcm0SIa2t7r5D.EHUAVMHB4), veEg0WkfO4fCl5tmQQF.D1IkX1xYq3);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004D78 File Offset: 0x00002F78
		public MonoManager()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.UoDdI5CpWg();
			base..ctor();
			int num = 0;
			if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_1d9ccb4b9f6e4991b29f4e03e19f9f1c != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004DD8 File Offset: 0x00002FD8
		internal static bool iSNen82OsXEBv7FHbQn()
		{
			return MonoManager.vU3Cqm2vYhOaRBNn8wW == null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004DE4 File Offset: 0x00002FE4
		internal static MonoManager q033lI2m0NMLPKhys5C()
		{
			return MonoManager.vU3Cqm2vYhOaRBNn8wW;
		}

		// Token: 0x04000016 RID: 22
		private static MonoManager.Update originalUpdate;

		// Token: 0x04000017 RID: 23
		private static MonoManager.LateUpdate originalLateUpdate;

		// Token: 0x04000018 RID: 24
		private static MonoManager.FixedUpdate originalFixedUpdate;

		// Token: 0x04000019 RID: 25
		private static MonoManager.OnGUI originalOnGUI;

		// Token: 0x0400001A RID: 26
		private static MonoManager.OnApplicationQuit originalOnApplicationQuit;

		// Token: 0x0400001B RID: 27
		internal static MonoManager vU3Cqm2vYhOaRBNn8wW;

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x0600004A RID: 74
		private delegate void Update(IntPtr instance);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x0600004E RID: 78
		private delegate void LateUpdate(IntPtr instance);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000052 RID: 82
		private delegate void FixedUpdate(IntPtr instance);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000056 RID: 86
		private delegate void OnGUI(IntPtr instance);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x0600005A RID: 90
		private delegate void OnApplicationQuit(IntPtr instance);

		// Token: 0x02000012 RID: 18
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400001C RID: 28
			public static MonoManager.Update <0>__patchedUpdate;

			// Token: 0x0400001D RID: 29
			public static MonoManager.LateUpdate <1>__patchedLateUpdate;

			// Token: 0x0400001E RID: 30
			public static MonoManager.FixedUpdate <2>__patchedFixedUpdate;

			// Token: 0x0400001F RID: 31
			public static MonoManager.OnGUI <3>__patchedOnGUI;

			// Token: 0x04000020 RID: 32
			public static MonoManager.OnApplicationQuit <4>__patchedOnApplicationQuit;
		}
	}
}
