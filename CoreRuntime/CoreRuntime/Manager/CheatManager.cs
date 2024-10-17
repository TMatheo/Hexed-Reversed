using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Interfaces;
using CoreRuntime.Wrappers;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace CoreRuntime.Manager
{
	// Token: 0x02000004 RID: 4
	internal class CheatManager
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002BE0 File Offset: 0x00000DE0
		internal static void InjectCheats()
		{
			int num = 7;
			int num2 = num;
			for (;;)
			{
				string text;
				string text2;
				int num6;
				switch (num2)
				{
				case 0:
					goto IL_2B2;
				case 1:
					return;
				case 2:
					goto IL_372;
				case 3:
					goto IL_324;
				case 4:
					try
					{
						HexedCheat initializedCheat = CheatManager.GetInitializedCheat(yP5fMZBjTmqZYcit9N.Vkgsu7Vsh(zelf6M69pMimavaTIu.Vkgsu7Vsh(text, zelf6M69pMimavaTIu.fHYuOLo83), yP5fMZBjTmqZYcit9N.SfabSpTad), text);
						int num3 = 3;
						int num4 = num3;
						for (;;)
						{
							switch (num4)
							{
							case 1:
								goto IL_10C;
							case 2:
								goto IL_C2;
							case 3:
								if (initializedCheat == null)
								{
									num4 = 2;
									if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_23687291198447029e19a2a39902facf != 0)
									{
										num4 = 0;
										continue;
									}
									continue;
								}
								break;
							}
							CheatManager.LoadCheat(initializedCheat);
							num4 = 0;
							if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_d66866237d0b48d682cf8ce1bb2cd7e5 == 0)
							{
								num4 = 1;
							}
						}
						IL_C2:
						IL_10C:
						goto IL_2FF;
					}
					catch (Exception ex)
					{
						int num5 = 1;
						if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_23687291198447029e19a2a39902facf == 0)
						{
							num5 = 1;
						}
						for (;;)
						{
							switch (num5)
							{
							case 1:
								Logger.LogError(RIQx5ZiROgKkHOkUM4.Vkgsu7Vsh(hIDAYxH6DWLHIthQgC.gSCeTtiku(~-792453756 ^ 1842059710 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_b4bbcacefe2f460eafc92ef2d3c6d009), text, hIDAYxH6DWLHIthQgC.gSCeTtiku(-2037873068 ^ -379176231 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_9c110458729f49b6849ba1fbab8493e1), A2ntJAeMt4fxRTnjkv.Vkgsu7Vsh(ex, A2ntJAeMt4fxRTnjkv.MkiokOlrR), RIQx5ZiROgKkHOkUM4.IUi0pWndJ));
								num5 = 0;
								if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_f78ec114ba134530b494cb8149d9ceec != 0)
								{
									num5 = 0;
									continue;
								}
								continue;
							}
							break;
						}
						goto IL_2FF;
					}
					return;
				case 5:
					goto IL_324;
				case 6:
					text2 = GFqAQHOdVUCtrs7yZx.Vkgsu7Vsh(I14MH3n6ECHaPQAxZ1.Vkgsu7Vsh(GT3G9MQmIwCwwyX5KR.Vkgsu7Vsh(WZedFaJiQANw5LiGpN.Vkgsu7Vsh(VitR1pcm0SIa2t7r5D.Vkgsu7Vsh(VitR1pcm0SIa2t7r5D.EHUAVMHB4), WZedFaJiQANw5LiGpN.LtbCTM2En), GT3G9MQmIwCwwyX5KR.voTIvcHbX), I14MH3n6ECHaPQAxZ1.LrhlfQyIY), hIDAYxH6DWLHIthQgC.gSCeTtiku(1177397061 ^ -1609575317 ^ -1529739117 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_b4bbcacefe2f460eafc92ef2d3c6d009), GFqAQHOdVUCtrs7yZx.EXWmoUsjs);
					num2 = 11;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_abcb54034558476aaf1951a09e1b79df != 0)
					{
						num2 = 12;
						continue;
					}
					continue;
				case 7:
					Logger.Log(hIDAYxH6DWLHIthQgC.gSCeTtiku(--511643923 ^ 1174972787 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_d0387cb39b814697b488c05864006b9d));
					num2 = 2;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_ac5a396fb1314f03b00a1c1c1fb25832 == 0)
					{
						num2 = 6;
						continue;
					}
					continue;
				case 8:
					break;
				case 9:
					goto IL_2FF;
				case 10:
					num6 = 0;
					num2 = 0;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_d0387cb39b814697b488c05864006b9d != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 11:
					return;
				case 12:
					if (!IBS4ZI7iaKStfGopPy.Vkgsu7Vsh(text2, IBS4ZI7iaKStfGopPy.pb6xOfEqO))
					{
						goto IL_372;
					}
					num2 = 0;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_c562bff83da649f1af22aec8f521fe1d != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				default:
					goto IL_2B2;
				}
				IL_20B:
				string[] array;
				text = array[num6];
				num2 = 4;
				continue;
				IL_324:
				if (num6 < array.Length)
				{
					goto IL_20B;
				}
				num2 = 0;
				if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_da83835e17544063b3591183e7e2848e == 0)
				{
					num2 = 1;
					continue;
				}
				continue;
				IL_2B2:
				array = QoFkDNPcNfLS0ciKO7.Vkgsu7Vsh(text2, hIDAYxH6DWLHIthQgC.gSCeTtiku(75611088 << 1 ^ 615822116 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_9aed36fa797e461e98c578cb5ad6472b), QoFkDNPcNfLS0ciKO7.sZT3cyDkd);
				num2 = 10;
				continue;
				IL_2FF:
				num6++;
				num2 = 0;
				if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_7ce8ad79e1da4729a888a21f9f3ca981 == 0)
				{
					num2 = 3;
					continue;
				}
				continue;
				IL_372:
				Logger.LogError(zvhtvFTqnly6SIjNjO.Vkgsu7Vsh(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1264955662 ^ -319949204 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_d0387cb39b814697b488c05864006b9d), text2, hIDAYxH6DWLHIthQgC.gSCeTtiku(-414254214 ^ -2033603463 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_c41248e324ff4126a99c2492f21b311a), zvhtvFTqnly6SIjNjO.xCpY5PslR));
				num2 = 3;
				if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_da83835e17544063b3591183e7e2848e == 0)
				{
					num2 = 11;
				}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003004 File Offset: 0x00001204
		private static HexedCheat GetInitializedCheat(object assembly, object fullPath)
		{
			HexedCheat result;
			try
			{
				Type[] source;
				try
				{
					source = VIebeSMDp0kkRTHbCc.Vkgsu7Vsh(assembly, VIebeSMDp0kkRTHbCc.XMC54SGlN);
				}
				catch (ReflectionTypeLoadException ex)
				{
					source = (from t in SkeXNSE2pyNeYVds9O.Vkgsu7Vsh(ex, SkeXNSE2pyNeYVds9O.pypzapEE1)
					where j6DRtekpQbb7WaLEdSb.Vkgsu7Vsh(t, null, j6DRtekpQbb7WaLEdSb.Yj3kk4a0r5)
					select t).ToArray<Type>();
				}
				Type type = source.FirstOrDefault(delegate(Type t)
				{
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							return false;
						case 1:
							if (jDgvQ9kKvt1qPVxuMGs.Vkgsu7Vsh(leXdUdkQnIXIpKm4I85.Vkgsu7Vsh(typeof(HexedCheat).TypeHandle, leXdUdkQnIXIpKm4I85.WhGkIJZ1F5), t, jDgvQ9kKvt1qPVxuMGs.EcVkFFIbl4))
							{
								goto IL_4C;
							}
							num2 = 0;
							if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_da83835e17544063b3591183e7e2848e != 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							goto IL_4C;
						}
					}
					return false;
					IL_4C:
					return !yIYJilkaVLyMQrPr4Lo.Vkgsu7Vsh(t, yIYJilkaVLyMQrPr4Lo.TmEktxvBYm);
				});
				if (j6DRtekpQbb7WaLEdSb.Vkgsu7Vsh(type, null, j6DRtekpQbb7WaLEdSb.Yj3kk4a0r5))
				{
					HexedCheat hexedCheat = (HexedCheat)DDbnLNk8QFMuQJok0x9.Vkgsu7Vsh(type, DDbnLNk8QFMuQJok0x9.HfXkGM4qDi);
					hexedCheat.Initialize(Y2A4uLkZyJ6vKYPFfYi.Vkgsu7Vsh(tZI3LRkyV9LOLwWdVmU.Vkgsu7Vsh(assembly, tZI3LRkyV9LOLwWdVmU.KYuk2OgN77), Y2A4uLkZyJ6vKYPFfYi.qWZkqj3EMM), sEIMuakdf4sv9FUlSAZ.Vkgsu7Vsh(sEIMuakdf4sv9FUlSAZ.O8pkwkqa4D), fullPath);
					result = hexedCheat;
				}
				else
				{
					Logger.LogError(GFqAQHOdVUCtrs7yZx.Vkgsu7Vsh(fullPath, hIDAYxH6DWLHIthQgC.gSCeTtiku(-369132611 + -1499432019 ^ -768186459 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_24528a7679a644c78b49b0457f8d9d44), GFqAQHOdVUCtrs7yZx.EXWmoUsjs));
					result = null;
				}
			}
			catch (Exception ex2)
			{
				Logger.LogError(zvhtvFTqnly6SIjNjO.Vkgsu7Vsh(fullPath, hIDAYxH6DWLHIthQgC.gSCeTtiku(237779630 ^ 1169372735 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_33a8f57c176f4d198f1febe007b7e26a), A2ntJAeMt4fxRTnjkv.Vkgsu7Vsh(ex2, A2ntJAeMt4fxRTnjkv.MkiokOlrR), zvhtvFTqnly6SIjNjO.xCpY5PslR));
				result = null;
			}
			return result;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000318C File Offset: 0x0000138C
		private static void LoadCheat(object Cheat)
		{
			switch (1)
			{
			case 1:
				try
				{
					CheatManager.LoadedCheats.Add(Cheat);
					int num = 0;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_9a072d45b7c649c39a88ec471b6efdd0 == 0)
					{
						num = 0;
					}
					for (;;)
					{
						switch (num)
						{
						default:
							Logger.LogSuccess(GFqAQHOdVUCtrs7yZx.Vkgsu7Vsh(hIDAYxH6DWLHIthQgC.gSCeTtiku(1476574665 ^ 1256064209 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_0fa20338976f426eb44415ef660968e0), Cheat.Identifier, GFqAQHOdVUCtrs7yZx.EXWmoUsjs));
							num = 2;
							break;
						case 1:
							goto IL_C8;
						case 2:
							Cheat.OnLoad();
							num = 1;
							if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_b4bbcacefe2f460eafc92ef2d3c6d009 == 0)
							{
								num = 0;
							}
							break;
						}
					}
					IL_C8:;
				}
				catch (Exception value)
				{
					int num2 = 4;
					for (;;)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
						switch (num2)
						{
						case 1:
							Logger.LogError(HUqyQtK9vUO9bfISNY.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, HUqyQtK9vUO9bfISNY.IYKFLW0NA));
							num2 = 5;
							if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_c6d0741241854289a704034f471da5dc == 0)
							{
								num2 = 5;
								continue;
							}
							continue;
						case 2:
							OllYaFLKfaVbHwoY0T.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1248717335 ^ -185412895 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_cacc3d1852de4d4da62058f287ab73b7), OllYaFLKfaVbHwoY0T.jdbri0BdE);
							num2 = 0;
							if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_7c03e83d2472462fba97daf81c246812 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							PHliwfftrtxnGUGv86.Vkgsu7Vsh(ref defaultInterpolatedStringHandler, Cheat.Identifier, PHliwfftrtxnGUGv86.PPaXybFhf);
							num2 = 1;
							if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_935ade0ca7864571bd1808f0d1435f90 == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 4:
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
							num2 = 3;
							continue;
						case 5:
							goto IL_1E3;
						}
						defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
						num2 = 0;
						if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_d00406e72f9c42bf92f725eab93afd75 == 0)
						{
							num2 = 1;
						}
					}
					IL_1E3:;
				}
				break;
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000033BC File Offset: 0x000015BC
		public CheatManager()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.UoDdI5CpWg();
			base..ctor();
			int num = 0;
			if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_a9e6643767b24faeb22874c272d31c0c == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000341C File Offset: 0x0000161C
		// Note: this type is marked as 'beforefieldinit'.
		static CheatManager()
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
						CheatManager.LoadedCheats = new List<HexedCheat>();
						num2 = 0;
						if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_a9e6643767b24faeb22874c272d31c0c != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						nHwRpygmi6xxZAssJn.UoDdI5CpWg();
						num2 = 1;
						if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_fb52a29d24de4440b04edf3fddca29f7 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_2C;
					}
					return;
				}
				IL_2C:
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				num = 2;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000034B8 File Offset: 0x000016B8
		internal static bool mXUvTH2g3UhPO3uMXGG()
		{
			return CheatManager.XcEhYg2HFVFaMq4gEe5 == null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000034C4 File Offset: 0x000016C4
		internal static CheatManager jqpEEK29ZKcJgl7wVWN()
		{
			return CheatManager.XcEhYg2HFVFaMq4gEe5;
		}

		// Token: 0x04000003 RID: 3
		internal static readonly List<HexedCheat> LoadedCheats;

		// Token: 0x04000004 RID: 4
		private static CheatManager XcEhYg2HFVFaMq4gEe5;
	}
}
