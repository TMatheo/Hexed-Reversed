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
		// Token: 0x06000010 RID: 16 RVA: 0x00002BF4 File Offset: 0x00000DF4
		internal static void InjectCheats(object baseDir)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				string text;
				string text2;
				string[] array;
				int num5;
				switch (num2)
				{
				case 0:
					goto IL_D6;
				case 1:
					Logger.Log(hIDAYxH6DWLHIthQgC.gSCeTtiku(-424048639 ^ -279887877 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_77caaf9658ab4228a2d653f72c318338));
					num2 = 0;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_302aed8b9a4f4b8894d39c085f0150b4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					goto IL_142;
				case 4:
					break;
				case 5:
					goto IL_153;
				case 6:
					goto IL_32E;
				case 7:
					break;
				case 8:
					try
					{
						HexedCheat initializedCheat = CheatManager.GetInitializedCheat(z5UjQhq2ecKKv2c1tp.k0sBmDS26(Vd8YPpvV4xhGkNakYI.k0sBmDS26(text, Vd8YPpvV4xhGkNakYI.bbOnRnUMl), z5UjQhq2ecKKv2c1tp.RH7ZWQXiv), text);
						int num3 = 0;
						if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_19219e20007142d38523f07c38cd8ec6 == 0)
						{
							num3 = 0;
						}
						for (;;)
						{
							switch (num3)
							{
							case 1:
								CheatManager.LoadCheat(initializedCheat);
								num3 = 2;
								if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_cb53c5012b8c473a8f1d4a4b097db321 != 0)
								{
									num3 = 2;
									continue;
								}
								continue;
							case 2:
								goto IL_271;
							}
							if (initializedCheat == null)
							{
								break;
							}
							num3 = 1;
							if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_de322c5a808a465f983b33be6a7ea7ef != 0)
							{
								num3 = 1;
							}
						}
						IL_271:
						goto IL_39D;
					}
					catch (Exception ex)
					{
						int num4 = 0;
						if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_07c5f71fed22450f81f9184893afd453 == 0)
						{
							num4 = 0;
						}
						for (;;)
						{
							switch (num4)
							{
							default:
								Logger.LogError(rghARJlj9PKwpFfxVB.k0sBmDS26(hIDAYxH6DWLHIthQgC.gSCeTtiku(-302969512 ^ -326571577 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_f1d9115f72ff4ae08fad04714cff8c0b), text, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1008514440 ^ -1635783653 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_edac2a2703904f2eb7963a4223e202ad), NQFXa88t3aiMnaICQL.k0sBmDS26(ex, NQFXa88t3aiMnaICQL.eHtxbBBPb), rghARJlj9PKwpFfxVB.GsCIoZXQ7));
								num4 = 1;
								if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_f53b57d82f9641e38009d875ec2f8244 == 0)
								{
									num4 = 1;
								}
								break;
							case 1:
								goto IL_31F;
							}
						}
						IL_31F:
						goto IL_39D;
					}
					goto IL_32E;
				case 9:
					goto IL_142;
				case 10:
					goto IL_39D;
				case 11:
					array = gIg11KoJbLcUoXvYkY.k0sBmDS26(text2, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1432950048 ^ -742303311 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_9a741f44c50c48bd9a4c027118ac2b16), gIg11KoJbLcUoXvYkY.FDECGHIh0);
					num2 = 12;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_77caaf9658ab4228a2d653f72c318338 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 12:
					num5 = 0;
					num2 = 7;
					continue;
				case 13:
					return;
				default:
					goto IL_D6;
				}
				if (num5 >= array.Length)
				{
					return;
				}
				num2 = 3;
				if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_ac5f2597813e4d7a94eff6f2688ca1d4 == 0)
				{
					num2 = 2;
					continue;
				}
				continue;
				IL_D6:
				text2 = UTpGGxhoI4R5rF9a0u.k0sBmDS26(baseDir, hIDAYxH6DWLHIthQgC.gSCeTtiku(262802384 >> 2 ^ 1301019010 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_389e5b4ff8ba426c905f46214455c4b7), UTpGGxhoI4R5rF9a0u.OFsmmTv3c);
				num2 = 6;
				continue;
				IL_142:
				text = array[num5];
				num2 = 8;
				continue;
				IL_153:
				Logger.LogError(zH1lR7T8lFVuJcYw4Z.k0sBmDS26(hIDAYxH6DWLHIthQgC.gSCeTtiku(1817815500 ^ 1356103774 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_a95e338918c04556aaf47418274cca2d), text2, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1124848506 ^ -1181907587 ^ 209918265 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_23b0c345fbea449596466ee9cdf54e9d), zH1lR7T8lFVuJcYw4Z.d6xMvUixE));
				num2 = 2;
				if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_e1faf0249a9e4741bd6472e4b44f3b13 != 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_32E:
				if (!a8IeJy4EwC8FdRdvgP.k0sBmDS26(text2, a8IeJy4EwC8FdRdvgP.Bw8rlyu3w))
				{
					goto IL_153;
				}
				num2 = 11;
				if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_23b0c345fbea449596466ee9cdf54e9d == 0)
				{
					num2 = 8;
					continue;
				}
				continue;
				IL_39D:
				num5++;
				num2 = 2;
				if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_0d6f1b1d53ea401dac5370118afd5971 != 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002FD4 File Offset: 0x000011D4
		private static HexedCheat GetInitializedCheat(object assembly, object fullPath)
		{
			HexedCheat result;
			try
			{
				Type[] source;
				try
				{
					source = eH4ALaHuRa2t99i1cQ.k0sBmDS26(assembly, eH4ALaHuRa2t99i1cQ.yAQaITYRi);
				}
				catch (ReflectionTypeLoadException ex)
				{
					source = (from t in NiPNZ1DAef8pYC5Mbd.k0sBmDS26(ex, NiPNZ1DAef8pYC5Mbd.dxHbDhyyi)
					where reQRSLscoT5VJVd0ei.k0sBmDS26(t, null, reQRSLscoT5VJVd0ei.y6czZ96l3)
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
							goto IL_24;
						case 1:
							if (!x2rMsp3OZkrJaD7C5qy.k0sBmDS26(EnlOxL3KU2n5cwR6bLM.k0sBmDS26(typeof(HexedCheat).TypeHandle, EnlOxL3KU2n5cwR6bLM.EMH3NTwRFd), t, x2rMsp3OZkrJaD7C5qy.Nag3XVD47b))
							{
								return false;
							}
							num2 = 0;
							if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_f6045cb8f6a845a2bd760bd08e5edb09 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
					IL_24:
					return !MSyrdQ353p0hbYxWLEd.k0sBmDS26(t, MSyrdQ353p0hbYxWLEd.Akl3gjOVeL);
				});
				if (reQRSLscoT5VJVd0ei.k0sBmDS26(type, null, reQRSLscoT5VJVd0ei.y6czZ96l3))
				{
					HexedCheat hexedCheat = (HexedCheat)dE8v3o3YO3XO58vKlLL.k0sBmDS26(type, dE8v3o3YO3XO58vKlLL.wMV33MWFp6);
					hexedCheat.Initialize(W4JP3R3wWUrDG2tJWAL.k0sBmDS26(nvC01f3JULlc81JB7eV.k0sBmDS26(assembly, nvC01f3JULlc81JB7eV.XfI3dDMUZK), W4JP3R3wWUrDG2tJWAL.p2c3kj5BLS), GgydWZ32bEfa638WeRs.k0sBmDS26(GgydWZ32bEfa638WeRs.uZ03VZP1XP), fullPath);
					result = hexedCheat;
				}
				else
				{
					Logger.LogError(UTpGGxhoI4R5rF9a0u.k0sBmDS26(fullPath, hIDAYxH6DWLHIthQgC.gSCeTtiku(1551566658 ^ 938302652 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_440bf9c5532843729f6af5bcc66b2a9f), UTpGGxhoI4R5rF9a0u.OFsmmTv3c));
					result = null;
				}
			}
			catch (Exception ex2)
			{
				Logger.LogError(zH1lR7T8lFVuJcYw4Z.k0sBmDS26(fullPath, hIDAYxH6DWLHIthQgC.gSCeTtiku(1817964891 ^ 1621930128 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_d509aebced084342a79500b2a43b1504), NQFXa88t3aiMnaICQL.k0sBmDS26(ex2, NQFXa88t3aiMnaICQL.eHtxbBBPb), zH1lR7T8lFVuJcYw4Z.d6xMvUixE));
				result = null;
			}
			return result;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003140 File Offset: 0x00001340
		private static void LoadCheat(object Cheat)
		{
			switch (1)
			{
			case 1:
				try
				{
					CheatManager.LoadedCheats.Add(Cheat);
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 1:
							Cheat.OnLoad(null);
							num = 0;
							if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_de322c5a808a465f983b33be6a7ea7ef != 0)
							{
								num = 0;
								continue;
							}
							continue;
						case 2:
							Logger.LogSuccess(UTpGGxhoI4R5rF9a0u.k0sBmDS26(hIDAYxH6DWLHIthQgC.gSCeTtiku(7139485 >> 6 ^ 1166523169 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_5ae564a9ecfe4f169a22d95bbec1499a), Cheat.Identifier, UTpGGxhoI4R5rF9a0u.OFsmmTv3c));
							num = 1;
							if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_92535530d9074294845959a55f7df47e == 0)
							{
								num = 1;
								continue;
							}
							continue;
						}
						break;
					}
				}
				catch (Exception value)
				{
					int num2 = 4;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_92535530d9074294845959a55f7df47e != 0)
					{
						num2 = 4;
					}
					for (;;)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
						switch (num2)
						{
						case 1:
							goto IL_1DA;
						case 2:
							rc9mmsOYA6cpiVOdw5.k0sBmDS26(ref defaultInterpolatedStringHandler, Cheat.Identifier, rc9mmsOYA6cpiVOdw5.UUPXdwKSJ);
							num2 = 5;
							continue;
						case 3:
							defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
							num2 = 0;
							if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_4ef4db7550394672961cc88f5d0e800a == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
							num2 = 2;
							continue;
						case 5:
							EqOyIWPBk4O8GIbets.k0sBmDS26(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(2087727082 ^ 1434059875 ^ 1550179102 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_829df0732b4b433b8c0719880717f482), EqOyIWPBk4O8GIbets.OYCAQYjuo);
							num2 = 3;
							continue;
						}
						Logger.LogError(Sbphjm5LFg5j2OSqxD.k0sBmDS26(ref defaultInterpolatedStringHandler, Sbphjm5LFg5j2OSqxD.tgcgXxaGu));
						num2 = 1;
						if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_0119f60806a248b6919db0af670ae27a == 0)
						{
							num2 = 1;
						}
					}
					IL_1DA:;
				}
				break;
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003368 File Offset: 0x00001568
		public CheatManager()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.dxI7NE9hn1();
			base..ctor();
			int num = 0;
			if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_5d0fdc373cde4068a8053e8907aa08b1 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000033C8 File Offset: 0x000015C8
		// Note: this type is marked as 'beforefieldinit'.
		static CheatManager()
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					hIDAYxH6DWLHIthQgC.oDuBOTgYK();
					num2 = 0;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_19c25a5301614c6080dd70b98665cdb7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					CheatManager.LoadedCheats = new List<HexedCheat>();
					num2 = 3;
					continue;
				case 3:
					return;
				}
				nHwRpygmi6xxZAssJn.dxI7NE9hn1();
				num2 = 1;
				if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_5d0fdc373cde4068a8053e8907aa08b1 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003460 File Offset: 0x00001660
		internal static bool mlpk6CkWWgygycbvNEj()
		{
			return CheatManager.iAweaMk6PKtBRFaMdy2 == null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000346C File Offset: 0x0000166C
		internal static CheatManager hlGb4mkeyBRrZaWOFD2()
		{
			return CheatManager.iAweaMk6PKtBRFaMdy2;
		}

		// Token: 0x04000003 RID: 3
		internal static readonly List<HexedCheat> LoadedCheats;

		// Token: 0x04000004 RID: 4
		internal static CheatManager iAweaMk6PKtBRFaMdy2;
	}
}
