using System;
using System.Collections.Generic;
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
		// Token: 0x0600003B RID: 59 RVA: 0x00003D8C File Offset: 0x00001F8C
		internal static void CheckBaseHooks()
		{
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_96;
					case 1:
						if (MonoManager.originalUpdate != null)
						{
							goto IL_C0;
						}
						num2 = 0;
						if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_f6045cb8f6a845a2bd760bd08e5edb09 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(-424048639 ^ -1701803000 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_a3ef764822b249b0bdf61221ef3b4538));
						num2 = 12;
						continue;
					case 4:
						goto IL_131;
					case 5:
						break;
					case 6:
						goto IL_1D6;
					case 7:
						goto IL_C0;
					case 8:
						goto IL_101;
					case 9:
						goto IL_131;
					case 10:
						goto IL_D8;
					case 11:
						Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1243926661 + 2002416826 ^ 1666505965 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_389e5b4ff8ba426c905f46214455c4b7));
						num2 = 10;
						if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_f60e06269478475f974669ce1a130c73 == 0)
						{
							num2 = 9;
							continue;
						}
						continue;
					case 12:
						goto IL_154;
					default:
						goto IL_96;
					}
					IL_51:
					Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(-807808146 - -1908325673 ^ 953100200 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_9a741f44c50c48bd9a4c027118ac2b16));
					num2 = 1;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_302aed8b9a4f4b8894d39c085f0150b4 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
					IL_96:
					Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1894012931 ^ -1153809851 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_30eab0122c1d426fb07a2bca334dae30));
					num2 = 7;
					continue;
					IL_D8:
					if (MonoManager.originalFixedUpdate == null)
					{
						goto IL_101;
					}
					num2 = 9;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_9c49ea5ee52241ee91951f45ec39a118 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_C0:
					if (MonoManager.originalLateUpdate == null)
					{
						break;
					}
					goto IL_D8;
					IL_101:
					Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(-541142807 - -1750320491 ^ 1032036156 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_5ce5ba802c7944ee8d65ed5a643f7605));
					num2 = 4;
					continue;
					IL_131:
					if (MonoManager.originalOnGUI == null)
					{
						num2 = 3;
						continue;
					}
					IL_154:
					if (MonoManager.originalOnApplicationQuit == null)
					{
						goto IL_51;
					}
					num2 = 6;
				}
				num = 11;
			}
			return;
			IL_1D6:;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003FA8 File Offset: 0x000021A8
		public static void PatchUpdate(MethodInfo method)
		{
			int num = 6;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_B8;
				case 2:
					return;
				case 3:
					if (Qa3Ox831KTuNFDK4ogH.k0sBmDS26(method, Qa3Ox831KTuNFDK4ogH.qqn3QYtlof).Length != 0)
					{
						goto IL_B8;
					}
					num2 = 4;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_cb53c5012b8c473a8f1d4a4b097db321 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 4:
				{
					MonoManager.Update detour;
					if ((detour = MonoManager.<>O.<0>__patchedUpdate) == null)
					{
						detour = (MonoManager.<>O.<0>__patchedUpdate = new MonoManager.Update(MonoManager.patchedUpdate));
					}
					MonoManager.originalUpdate = HookManager.Detour<MonoManager.Update>(method, detour);
					num2 = 7;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_a251c722ffd64d969f265fb60691858a != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				case 5:
					return;
				case 6:
					if (MonoManager.originalUpdate != null)
					{
						num2 = 5;
						continue;
					}
					if (reQRSLscoT5VJVd0ei.k0sBmDS26(kjVBWd3cZi75uiOOjOH.k0sBmDS26(method, kjVBWd3cZi75uiOOjOH.Y6P3jBTWt9), EnlOxL3KU2n5cwR6bLM.k0sBmDS26(typeof(void).TypeHandle, EnlOxL3KU2n5cwR6bLM.EMH3NTwRFd), reQRSLscoT5VJVd0ei.y6czZ96l3))
					{
						num2 = 0;
						if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_4ee3fdefe97746e2a979b2f5d088f1b2 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				case 7:
					return;
				case 8:
					goto IL_B8;
				}
				if (!xZ9LPo3Pc2ro7A0Asos.k0sBmDS26(method, xZ9LPo3Pc2ro7A0Asos.L1U3AujAcM))
				{
					num2 = 2;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_781114abd2034347956064bb551f8f7d == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				IL_B8:
				Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(472176686 - 625101809 ^ -884897501 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_ac5f2597813e4d7a94eff6f2688ca1d4));
				num2 = 2;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004178 File Offset: 0x00002378
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
					rc9mmsOYA6cpiVOdw5.k0sBmDS26(ref defaultInterpolatedStringHandler, hexedCheat.Identifier, rc9mmsOYA6cpiVOdw5.UUPXdwKSJ);
					EqOyIWPBk4O8GIbets.k0sBmDS26(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1266938048 - 83500566 ^ 169298552 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_b27af62cf66b438484a169015c1171b1), EqOyIWPBk4O8GIbets.OYCAQYjuo);
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
					Logger.LogError(Sbphjm5LFg5j2OSqxD.k0sBmDS26(ref defaultInterpolatedStringHandler, Sbphjm5LFg5j2OSqxD.tgcgXxaGu));
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
					EqOyIWPBk4O8GIbets.k0sBmDS26(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-922572248 ^ -1057480822 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_23b0c345fbea449596466ee9cdf54e9d), EqOyIWPBk4O8GIbets.OYCAQYjuo);
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(value2);
					Logger.LogError(Sbphjm5LFg5j2OSqxD.k0sBmDS26(ref defaultInterpolatedStringHandler, Sbphjm5LFg5j2OSqxD.tgcgXxaGu));
				}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004318 File Offset: 0x00002518
		public static void PatchLateUpdate(MethodInfo method)
		{
			int num = 6;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_54;
					case 1:
						return;
					case 2:
						break;
					case 3:
						goto IL_EC;
					case 4:
						break;
					case 5:
						return;
					case 6:
						if (MonoManager.originalLateUpdate != null)
						{
							num2 = 5;
							continue;
						}
						if (reQRSLscoT5VJVd0ei.k0sBmDS26(kjVBWd3cZi75uiOOjOH.k0sBmDS26(method, kjVBWd3cZi75uiOOjOH.Y6P3jBTWt9), EnlOxL3KU2n5cwR6bLM.k0sBmDS26(typeof(void).TypeHandle, EnlOxL3KU2n5cwR6bLM.EMH3NTwRFd), reQRSLscoT5VJVd0ei.y6czZ96l3))
						{
							num2 = 8;
							continue;
						}
						goto IL_EC;
					case 7:
						return;
					case 8:
						break;
					default:
						goto IL_54;
					}
					Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(-293933323 - -1705011605 ^ 1449713481 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_76c36d3bdf714327a5d858d17a351127));
					num2 = 0;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_77ab9dd0755e4f7f93de9274b2ff9615 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_EC:
					if (xZ9LPo3Pc2ro7A0Asos.k0sBmDS26(method, xZ9LPo3Pc2ro7A0Asos.L1U3AujAcM))
					{
						num2 = 2;
						continue;
					}
					IL_54:
					if (Qa3Ox831KTuNFDK4ogH.k0sBmDS26(method, Qa3Ox831KTuNFDK4ogH.qqn3QYtlof).Length != 0)
					{
						break;
					}
					MonoManager.LateUpdate detour;
					if ((detour = MonoManager.<>O.<1>__patchedLateUpdate) == null)
					{
						detour = (MonoManager.<>O.<1>__patchedLateUpdate = new MonoManager.LateUpdate(MonoManager.patchedLateUpdate));
					}
					MonoManager.originalLateUpdate = HookManager.Detour<MonoManager.LateUpdate>(method, detour);
					num2 = 7;
				}
				num = 4;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004494 File Offset: 0x00002694
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
					rc9mmsOYA6cpiVOdw5.k0sBmDS26(ref defaultInterpolatedStringHandler, hexedCheat.Identifier, rc9mmsOYA6cpiVOdw5.UUPXdwKSJ);
					EqOyIWPBk4O8GIbets.k0sBmDS26(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(2122127052 << 1 ^ -2133644391 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_a3ef764822b249b0bdf61221ef3b4538), EqOyIWPBk4O8GIbets.OYCAQYjuo);
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
					Logger.LogError(Sbphjm5LFg5j2OSqxD.k0sBmDS26(ref defaultInterpolatedStringHandler, Sbphjm5LFg5j2OSqxD.tgcgXxaGu));
				}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00004578 File Offset: 0x00002778
		public static void PatchFixedUpdate(MethodInfo method)
		{
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_40;
				case 2:
					goto IL_AE;
				case 3:
					return;
				case 4:
					if (MonoManager.originalFixedUpdate != null)
					{
						num2 = 3;
						continue;
					}
					if (!reQRSLscoT5VJVd0ei.k0sBmDS26(kjVBWd3cZi75uiOOjOH.k0sBmDS26(method, kjVBWd3cZi75uiOOjOH.Y6P3jBTWt9), EnlOxL3KU2n5cwR6bLM.k0sBmDS26(typeof(void).TypeHandle, EnlOxL3KU2n5cwR6bLM.EMH3NTwRFd), reQRSLscoT5VJVd0ei.y6czZ96l3))
					{
						goto IL_5C;
					}
					num2 = 6;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_d1cb4aaf4fc045f5839300511ab1de3f == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					return;
				case 6:
					goto IL_AE;
				case 7:
					goto IL_5C;
				case 8:
					goto IL_AE;
				}
				break;
				IL_40:
				if (Qa3Ox831KTuNFDK4ogH.k0sBmDS26(method, Qa3Ox831KTuNFDK4ogH.qqn3QYtlof).Length != 0)
				{
					num2 = 2;
					continue;
				}
				MonoManager.FixedUpdate detour;
				if ((detour = MonoManager.<>O.<2>__patchedFixedUpdate) == null)
				{
					detour = (MonoManager.<>O.<2>__patchedFixedUpdate = new MonoManager.FixedUpdate(MonoManager.patchedFixedUpdate));
				}
				MonoManager.originalFixedUpdate = HookManager.Detour<MonoManager.FixedUpdate>(method, detour);
				num2 = 5;
				continue;
				IL_AE:
				Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1008514440 ^ -1980035384 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_cb53c5012b8c473a8f1d4a4b097db321));
				num2 = 0;
				if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_c931a3b513c14488a1a5550313dbc790 == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_5C:
				if (!xZ9LPo3Pc2ro7A0Asos.k0sBmDS26(method, xZ9LPo3Pc2ro7A0Asos.L1U3AujAcM))
				{
					goto IL_40;
				}
				num2 = 8;
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004714 File Offset: 0x00002914
		private static void patchedFixedUpdate(IntPtr instance)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				List<HexedCheat>.Enumerator enumerator;
				switch (num2)
				{
				default:
					return;
				case 1:
					break;
				case 2:
					MonoManager.originalFixedUpdate(instance);
					num2 = 1;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_852c5d0a75534123b3259cafbdb3787c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					try
					{
						for (;;)
						{
							if (enumerator.MoveNext())
							{
								goto IL_9A;
							}
							int num3 = 0;
							if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_4b547a8566d741389e4a86d1605827c4 != 0)
							{
								num3 = 0;
							}
							IL_80:
							switch (num3)
							{
							case 1:
								continue;
							case 2:
								try
								{
									HexedCheat hexedCheat;
									hexedCheat.OnFixedUpdate();
									int num4 = 0;
									if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_7a07a290fe614bc6999deecab3de9eab != 0)
									{
										num4 = 0;
									}
									switch (num4)
									{
									}
								}
								catch (Exception value)
								{
									int num5 = 4;
									for (;;)
									{
										DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
										switch (num5)
										{
										case 1:
											Logger.LogError(Sbphjm5LFg5j2OSqxD.k0sBmDS26(ref defaultInterpolatedStringHandler, Sbphjm5LFg5j2OSqxD.tgcgXxaGu));
											num5 = 0;
											if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_8a76a7fae4924808ab15b6551d08b6db == 0)
											{
												num5 = 2;
												continue;
											}
											continue;
										case 2:
											goto IL_205;
										case 3:
											defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
											num5 = 0;
											if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_ae75df162a95440b90ee0ac540e5801c != 0)
											{
												num5 = 1;
												continue;
											}
											continue;
										case 4:
											defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 2);
											num5 = 0;
											if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_eba429a8ad6649be8436afed34a2bb21 == 0)
											{
												num5 = 0;
												continue;
											}
											continue;
										case 5:
											EqOyIWPBk4O8GIbets.k0sBmDS26(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(589643317 ^ 1302221410 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_b7b9a8492a38400d91bae0026bb0248f), EqOyIWPBk4O8GIbets.OYCAQYjuo);
											num5 = 2;
											if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_afc1c0a1256744ca83837550f557c751 == 0)
											{
												num5 = 3;
												continue;
											}
											continue;
										}
										HexedCheat hexedCheat;
										rc9mmsOYA6cpiVOdw5.k0sBmDS26(ref defaultInterpolatedStringHandler, hexedCheat.Identifier, rc9mmsOYA6cpiVOdw5.UUPXdwKSJ);
										num5 = 5;
									}
									IL_205:;
								}
								continue;
							case 3:
							{
								IL_9A:
								HexedCheat hexedCheat = enumerator.Current;
								int num6 = 2;
								num3 = num6;
								goto IL_80;
							}
							}
							break;
						}
						return;
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num7 = 0;
						if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_b17c90c6112a4263b26500827a58a466 != 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						}
					}
					break;
				}
				enumerator = CheatManager.LoadedCheats.GetEnumerator();
				num2 = 3;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004A24 File Offset: 0x00002C24
		public static void PatchOnGUI(MethodInfo method)
		{
			int num = 7;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E7;
				case 1:
					goto IL_E7;
				case 2:
					break;
				case 3:
					if (Qa3Ox831KTuNFDK4ogH.k0sBmDS26(method, Qa3Ox831KTuNFDK4ogH.qqn3QYtlof).Length == 0)
					{
						num2 = 5;
						continue;
					}
					goto IL_E7;
				case 4:
					return;
				case 5:
				{
					MonoManager.OnGUI detour;
					if ((detour = MonoManager.<>O.<3>__patchedOnGUI) == null)
					{
						detour = (MonoManager.<>O.<3>__patchedOnGUI = new MonoManager.OnGUI(MonoManager.patchedOnGUI));
					}
					MonoManager.originalOnGUI = HookManager.Detour<MonoManager.OnGUI>(method, detour);
					num2 = 4;
					continue;
				}
				case 6:
					return;
				case 7:
					if (MonoManager.originalOnGUI != null)
					{
						num2 = 4;
						if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_4ef4db7550394672961cc88f5d0e800a != 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					}
					else if (reQRSLscoT5VJVd0ei.k0sBmDS26(kjVBWd3cZi75uiOOjOH.k0sBmDS26(method, kjVBWd3cZi75uiOOjOH.Y6P3jBTWt9), EnlOxL3KU2n5cwR6bLM.k0sBmDS26(typeof(void).TypeHandle, EnlOxL3KU2n5cwR6bLM.EMH3NTwRFd), reQRSLscoT5VJVd0ei.y6czZ96l3))
					{
						num2 = 1;
						if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_77caaf9658ab4228a2d653f72c318338 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				case 8:
					return;
				default:
					goto IL_E7;
				}
				if (!xZ9LPo3Pc2ro7A0Asos.k0sBmDS26(method, xZ9LPo3Pc2ro7A0Asos.L1U3AujAcM))
				{
					num2 = 3;
					continue;
				}
				IL_E7:
				Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(-807808146 - -1908325673 ^ 211575427 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_d1cb4aaf4fc045f5839300511ab1de3f));
				num2 = 8;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00004BB4 File Offset: 0x00002DB4
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
					rc9mmsOYA6cpiVOdw5.k0sBmDS26(ref defaultInterpolatedStringHandler, hexedCheat.Identifier, rc9mmsOYA6cpiVOdw5.UUPXdwKSJ);
					EqOyIWPBk4O8GIbets.k0sBmDS26(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1312829189 ^ -48149991 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_b27af62cf66b438484a169015c1171b1), EqOyIWPBk4O8GIbets.OYCAQYjuo);
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
					Logger.LogError(Sbphjm5LFg5j2OSqxD.k0sBmDS26(ref defaultInterpolatedStringHandler, Sbphjm5LFg5j2OSqxD.tgcgXxaGu));
				}
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004C94 File Offset: 0x00002E94
		public static void PatchOnApplicationQuit(MethodInfo method)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_BF;
				case 1:
					if (MonoManager.originalOnApplicationQuit != null)
					{
						return;
					}
					num2 = 0;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_4c9ef9cde5ab45ae8b265068615b5e5b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					break;
				case 3:
					break;
				case 4:
					return;
				case 5:
					return;
				case 6:
				{
					if (Qa3Ox831KTuNFDK4ogH.k0sBmDS26(method, Qa3Ox831KTuNFDK4ogH.qqn3QYtlof).Length != 0)
					{
						num2 = 3;
						continue;
					}
					MonoManager.OnApplicationQuit detour;
					if ((detour = MonoManager.<>O.<4>__patchedOnApplicationQuit) == null)
					{
						detour = (MonoManager.<>O.<4>__patchedOnApplicationQuit = new MonoManager.OnApplicationQuit(MonoManager.patchedOnApplicationQuit));
					}
					MonoManager.originalOnApplicationQuit = HookManager.Detour<MonoManager.OnApplicationQuit>(method, detour);
					num2 = 2;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_e1faf0249a9e4741bd6472e4b44f3b13 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				}
				case 7:
					goto IL_E3;
				case 8:
					return;
				default:
					goto IL_BF;
				}
				IL_40:
				Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(-922572248 ^ -1878396520 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_ae75df162a95440b90ee0ac540e5801c));
				num2 = 5;
				continue;
				IL_BF:
				if (reQRSLscoT5VJVd0ei.k0sBmDS26(kjVBWd3cZi75uiOOjOH.k0sBmDS26(method, kjVBWd3cZi75uiOOjOH.Y6P3jBTWt9), EnlOxL3KU2n5cwR6bLM.k0sBmDS26(typeof(void).TypeHandle, EnlOxL3KU2n5cwR6bLM.EMH3NTwRFd), reQRSLscoT5VJVd0ei.y6czZ96l3))
				{
					num2 = 1;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_138d859d3f2047df875a5a6877d4c694 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				IL_E3:
				if (xZ9LPo3Pc2ro7A0Asos.k0sBmDS26(method, xZ9LPo3Pc2ro7A0Asos.L1U3AujAcM))
				{
					goto IL_40;
				}
				num2 = 6;
				if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_ac73a5c478cc4d1098bd3c7751d201a6 == 0)
				{
					num2 = 6;
				}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004E44 File Offset: 0x00003044
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
					rc9mmsOYA6cpiVOdw5.k0sBmDS26(ref defaultInterpolatedStringHandler, hexedCheat.Identifier, rc9mmsOYA6cpiVOdw5.UUPXdwKSJ);
					EqOyIWPBk4O8GIbets.k0sBmDS26(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1166244614 >> 4 ^ 228753508 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_23b0c345fbea449596466ee9cdf54e9d), EqOyIWPBk4O8GIbets.OYCAQYjuo);
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
					Logger.LogError(Sbphjm5LFg5j2OSqxD.k0sBmDS26(ref defaultInterpolatedStringHandler, Sbphjm5LFg5j2OSqxD.tgcgXxaGu));
				}
			}
			uLW4A43Smp39SW5ia1u.k0sBmDS26(zhW75a0S0ZETvIxOC9.k0sBmDS26(zhW75a0S0ZETvIxOC9.JQ5yyLI01), uLW4A43Smp39SW5ia1u.vVT3EBemQx);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004F3C File Offset: 0x0000313C
		public MonoManager()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.dxI7NE9hn1();
			base..ctor();
			int num = 0;
			if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_2214534233c84f54af8fa632b028a9d4 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004F9C File Offset: 0x0000319C
		internal static bool DNncqTkRxLCfM0t39YN()
		{
			return MonoManager.pOXQNQk9ugmwoRlIqMR == null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004FA8 File Offset: 0x000031A8
		internal static MonoManager GWQA2mkLBRNE0tCU4YE()
		{
			return MonoManager.pOXQNQk9ugmwoRlIqMR;
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
		internal static MonoManager pOXQNQk9ugmwoRlIqMR;

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
