using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CoreRuntime.Interfaces;
using Hexed.HexedServer;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace HexedProxyLoader
{
	// Token: 0x0200000F RID: 15
	public class Entry : HexedCheat
	{
		// Token: 0x060000DE RID: 222 RVA: 0x00005D1C File Offset: 0x00003F1C
		public override void OnLoad()
		{
			int num = 6;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						return;
					case 3:
						Entry.Instance = QCiIb4kyv1cDCMwgIDw.bHC8kRmMET(Entry.c5Jg7vZhM0rxHV3e2Sr(Entry.OnLoadReflected, sEhx6skI2h9j0kjyu8N.M42k4HhU7I), QCiIb4kyv1cDCMwgIDw.LZrkJgk5X2);
						num2 = 4;
						continue;
					case 4:
						Entry.v7K6GWZOMK38RaUE81m(Entry.OnLoadReflected, Entry.Instance, new object[0]);
						num2 = 2;
						continue;
					case 5:
						goto IL_BA;
					case 6:
						if (Entry.LitgqWZRfJ3DqXn7hbC())
						{
							num2 = 5;
							if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_e0a6c5571bf541faa55a66565b7f3bd2 != 0)
							{
								num2 = 5;
								continue;
							}
							continue;
						}
						break;
					}
					kxZYhGkVQJLua9etdXa.bHC8kRmMET(cnfpx8kpBc0Xvh1qPo5.bHC8kRmMET(cnfpx8kpBc0Xvh1qPo5.ucwkqCYKJE), kxZYhGkVQJLua9etdXa.JWHkDawd1X);
					num2 = 0;
					if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_b5ce94b35e4d462fb2b95ae5fa41a593 == 0)
					{
						num2 = 1;
					}
				}
				IL_BA:
				object obj = Entry.k0MTOFZtUwkQqBwSx0A(Entry.ObZ60uZTNdZKOMrfHWS(ServerHandler.GetClient().Result, umZlS685wVdN3IX1GXn.n1W8Z5ADUD), K2SC9ckUT0Ai0tEQjB8.QmkkBCZ2Ed);
				IEnumerable<Type> source = atThiPkMkgyaqaXkPH3.bHC8kRmMET(obj, atThiPkMkgyaqaXkPH3.EmVkLDdW1D);
				Func<Type, IEnumerable<MethodInfo>> selector;
				if ((selector = Entry.<>c.<>9__7_0) == null)
				{
					selector = (Entry.<>c.<>9__7_0 = ((Type t) => DFHh5IQ9JN8IFVfp8uu.bHC8kRmMET(t, DFHh5IQ9JN8IFVfp8uu.dFDQcg1K7P)));
				}
				Entry.OnLoadReflected = source.SelectMany(selector).Where(delegate(MethodInfo m)
				{
					int num3 = 1;
					for (;;)
					{
						int num4 = num3;
						for (;;)
						{
							switch (num4)
							{
							case 1:
								if (Entry.<>c.CCP94xFvDUVYGw3xDX8(m, b5fMCjQPdU5chf3sGKr.tyuQGI834y))
								{
									goto IL_15E;
								}
								num4 = 0;
								if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_80ae2bbf08304c42b54383f3bd026882 == 0)
								{
									num4 = 0;
									continue;
								}
								continue;
							case 2:
								goto IL_15E;
							case 3:
								if (Entry.<>c.h7V392FXa3GriaDmlBC(m, RlVu15QSpoIlHkqROp3.w3NQYcWkYl))
								{
									num4 = 4;
									continue;
								}
								break;
							case 4:
								if (!Entry.<>c.cfs8BoF3YM79xpEFLgN(m, wIoB3wQa1vWjU4KvIH2.K7GQmGfQGS))
								{
									num4 = 7;
									continue;
								}
								break;
							case 5:
								goto IL_12B;
							case 7:
								if (opXdiOQpofdw3bIti5p.bHC8kRmMET(sL0HX2Qt0juTOH6S47a.bHC8kRmMET(Entry.<>c.L6fjDpFiNqqtX28R38i(m, pueX3GQRgMd3a5wXe5Q.dCoQTkRN9n), sL0HX2Qt0juTOH6S47a.fdlQCXhiKN), Entry.<>c.CCqQrjFWQtVEyJxtsOo(typeof(void).TypeHandle, aVZ292Qh1201BTbcvLE.URxQOOdBRu), opXdiOQpofdw3bIti5p.IDdQqxyrKF))
								{
									goto IL_12B;
								}
								num4 = 2;
								if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_896808023b5042f2867de07fd7fca649 != 0)
								{
									num4 = 6;
									continue;
								}
								continue;
							}
							goto Block_1;
						}
						IL_15E:
						if (Entry.<>c.nhP0JrFAIqoI5Cs88Dn(m, lXYEKRQuieXW1KIZqNE.nyfQxZkQqw))
						{
							break;
						}
						num3 = 3;
					}
					Block_1:
					return false;
					IL_12B:
					return HAFuKZ8WfdYD59Ixayi.bHC8kRmMET(Entry.<>c.JtcLbiFeL07sKssdJVU(m, ExR0kJQV50WuOmNvR2x.xEIQD5C8pS), Entry.<>c.RyHSOiFEh5walGZtwNs(241448870 ^ 2045838487 ^ <Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_896808023b5042f2867de07fd7fca649), HAFuKZ8WfdYD59Ixayi.LJw8eNaiSX);
				}).FirstOrDefault<MethodInfo>();
				IEnumerable<MethodInfo> source2 = Entry.mP3HCmZCRKgiBDnmu9n(obj, atThiPkMkgyaqaXkPH3.EmVkLDdW1D).SelectMany((Type t) => DFHh5IQ9JN8IFVfp8uu.bHC8kRmMET(t, DFHh5IQ9JN8IFVfp8uu.dFDQcg1K7P));
				Func<MethodInfo, bool> predicate;
				if ((predicate = Entry.<>c.<>9__7_3) == null)
				{
					predicate = (Entry.<>c.<>9__7_3 = delegate(MethodInfo m)
					{
						int num3 = 8;
						int num4 = num3;
						for (;;)
						{
							switch (num4)
							{
							case 0:
								goto IL_90;
							case 1:
								goto IL_116;
							case 2:
								break;
							case 3:
								goto IL_149;
							case 4:
								goto IL_17C;
							case 5:
								if (!Entry.<>c.cfs8BoF3YM79xpEFLgN(m, wIoB3wQa1vWjU4KvIH2.K7GQmGfQGS))
								{
									goto IL_90;
								}
								num4 = 1;
								if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_f57147600bec46dcbedf8e1d19383d3c != 0)
								{
									num4 = 0;
									continue;
								}
								continue;
							case 6:
								goto IL_E7;
							case 7:
								goto IL_13A;
							case 8:
								if (!Entry.<>c.CCP94xFvDUVYGw3xDX8(m, b5fMCjQPdU5chf3sGKr.tyuQGI834y))
								{
									num4 = 7;
									continue;
								}
								break;
							default:
								goto IL_90;
							}
							if (lXYEKRQuieXW1KIZqNE.bHC8kRmMET(m, lXYEKRQuieXW1KIZqNE.nyfQxZkQqw))
							{
								num4 = 4;
								continue;
							}
							goto IL_E7;
							IL_90:
							if (Entry.<>c.OYjproFdLJ43u9oAnpJ(Entry.<>c.xqIxbMFw6mNDWP5dMR8(Entry.<>c.L6fjDpFiNqqtX28R38i(m, pueX3GQRgMd3a5wXe5Q.dCoQTkRN9n), sL0HX2Qt0juTOH6S47a.fdlQCXhiKN), aVZ292Qh1201BTbcvLE.bHC8kRmMET(typeof(void).TypeHandle, aVZ292Qh1201BTbcvLE.URxQOOdBRu), opXdiOQpofdw3bIti5p.IDdQqxyrKF))
							{
								num4 = 3;
								continue;
							}
							break;
							IL_E7:
							if (!Entry.<>c.h7V392FXa3GriaDmlBC(m, RlVu15QSpoIlHkqROp3.w3NQYcWkYl))
							{
								break;
							}
							num4 = 4;
							if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_081b6e80582e4ab0b344c3174f2607fe != 0)
							{
								num4 = 5;
							}
						}
						IL_116:
						IL_13A:
						return false;
						IL_149:
						return HAFuKZ8WfdYD59Ixayi.bHC8kRmMET(ExR0kJQV50WuOmNvR2x.bHC8kRmMET(m, ExR0kJQV50WuOmNvR2x.xEIQD5C8pS), Entry.<>c.RyHSOiFEh5walGZtwNs(-1195594900 ^ -1836841590 ^ <Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_0988bb91a7564243b679db7669ea9a29), HAFuKZ8WfdYD59Ixayi.LJw8eNaiSX);
						IL_17C:
						return false;
					});
				}
				Entry.OnApplicationQuitReflected = source2.Where(predicate).FirstOrDefault<MethodInfo>();
				IEnumerable<Type> source3 = atThiPkMkgyaqaXkPH3.bHC8kRmMET(obj, atThiPkMkgyaqaXkPH3.EmVkLDdW1D);
				Func<Type, IEnumerable<MethodInfo>> selector2;
				if ((selector2 = Entry.<>c.<>9__7_4) == null)
				{
					selector2 = (Entry.<>c.<>9__7_4 = ((Type t) => DFHh5IQ9JN8IFVfp8uu.bHC8kRmMET(t, DFHh5IQ9JN8IFVfp8uu.dFDQcg1K7P)));
				}
				IEnumerable<MethodInfo> source4 = source3.SelectMany(selector2);
				Func<MethodInfo, bool> predicate2;
				if ((predicate2 = Entry.<>c.<>9__7_5) == null)
				{
					predicate2 = (Entry.<>c.<>9__7_5 = delegate(MethodInfo m)
					{
						int num3 = 7;
						for (;;)
						{
							int num4 = num3;
							for (;;)
							{
								switch (num4)
								{
								case 2:
									if (Entry.<>c.h7V392FXa3GriaDmlBC(m, RlVu15QSpoIlHkqROp3.w3NQYcWkYl))
									{
										goto IL_76;
									}
									num4 = 0;
									if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_24746feba6364f3e9f90f3632ff333c7 != 0)
									{
										num4 = 0;
										continue;
									}
									continue;
								case 3:
									goto IL_190;
								case 4:
									goto IL_76;
								case 5:
									if (Entry.<>c.OYjproFdLJ43u9oAnpJ(Entry.<>c.xqIxbMFw6mNDWP5dMR8(Entry.<>c.L6fjDpFiNqqtX28R38i(m, pueX3GQRgMd3a5wXe5Q.dCoQTkRN9n), sL0HX2Qt0juTOH6S47a.fdlQCXhiKN), Entry.<>c.CCqQrjFWQtVEyJxtsOo(typeof(void).TypeHandle, aVZ292Qh1201BTbcvLE.URxQOOdBRu), opXdiOQpofdw3bIti5p.IDdQqxyrKF))
									{
										goto IL_E7;
									}
									num4 = 1;
									if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_dec327e5ba134ce7a775da3a2fd19635 != 0)
									{
										num4 = 1;
										continue;
									}
									continue;
								case 7:
									if (Entry.<>c.CCP94xFvDUVYGw3xDX8(m, b5fMCjQPdU5chf3sGKr.tyuQGI834y))
									{
										goto IL_190;
									}
									num4 = 0;
									if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_0a5be57fd65e4888bd356f81bd5abce3 != 0)
									{
										num4 = 6;
										continue;
									}
									continue;
								case 8:
									goto IL_E7;
								}
								goto Block_1;
								IL_190:
								if (lXYEKRQuieXW1KIZqNE.bHC8kRmMET(m, lXYEKRQuieXW1KIZqNE.nyfQxZkQqw))
								{
									return false;
								}
								num4 = 2;
							}
							IL_76:
							if (Entry.<>c.cfs8BoF3YM79xpEFLgN(m, wIoB3wQa1vWjU4KvIH2.K7GQmGfQGS))
							{
								break;
							}
							num3 = 5;
						}
						Block_1:
						return false;
						IL_E7:
						return Entry.<>c.QC5q0YFj9sjQWwTej7c(Entry.<>c.JtcLbiFeL07sKssdJVU(m, ExR0kJQV50WuOmNvR2x.xEIQD5C8pS), Entry.<>c.RyHSOiFEh5walGZtwNs(978357542 + 257701949 ^ 1430783183 ^ <Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_a886741aeab44e5eaceecb407afb698c), HAFuKZ8WfdYD59Ixayi.LJw8eNaiSX);
					});
				}
				Entry.OnGUIReflected = source4.Where(predicate2).FirstOrDefault<MethodInfo>();
				IEnumerable<MethodInfo> source5 = Entry.mP3HCmZCRKgiBDnmu9n(obj, atThiPkMkgyaqaXkPH3.EmVkLDdW1D).SelectMany((Type t) => DFHh5IQ9JN8IFVfp8uu.bHC8kRmMET(t, DFHh5IQ9JN8IFVfp8uu.dFDQcg1K7P));
				Func<MethodInfo, bool> predicate3;
				if ((predicate3 = Entry.<>c.<>9__7_7) == null)
				{
					predicate3 = (Entry.<>c.<>9__7_7 = delegate(MethodInfo m)
					{
						int num3 = 1;
						int num4 = num3;
						for (;;)
						{
							switch (num4)
							{
							default:
								goto IL_47;
							case 1:
								if (Entry.<>c.CCP94xFvDUVYGw3xDX8(m, b5fMCjQPdU5chf3sGKr.tyuQGI834y))
								{
									goto IL_C8;
								}
								num4 = 0;
								if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_c572076710df4f14ac11182686a2d767 != 0)
								{
									num4 = 0;
									continue;
								}
								continue;
							case 2:
								goto IL_65;
							case 3:
								goto IL_56;
							case 4:
								goto IL_C8;
							case 5:
								if (!Entry.<>c.h7V392FXa3GriaDmlBC(m, RlVu15QSpoIlHkqROp3.w3NQYcWkYl))
								{
									num4 = 3;
									continue;
								}
								break;
							case 6:
								goto IL_163;
							case 7:
								goto IL_111;
							case 8:
								break;
							}
							if (!Entry.<>c.cfs8BoF3YM79xpEFLgN(m, wIoB3wQa1vWjU4KvIH2.K7GQmGfQGS))
							{
								goto IL_111;
							}
							num4 = 6;
							if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_2b81ec8af5e04f369f0d06aea74493ed == 0)
							{
								num4 = 6;
								continue;
							}
							continue;
							IL_C8:
							if (!Entry.<>c.nhP0JrFAIqoI5Cs88Dn(m, lXYEKRQuieXW1KIZqNE.nyfQxZkQqw))
							{
								num4 = 5;
								continue;
							}
							break;
							IL_111:
							if (!Entry.<>c.OYjproFdLJ43u9oAnpJ(Entry.<>c.xqIxbMFw6mNDWP5dMR8(Entry.<>c.L6fjDpFiNqqtX28R38i(m, pueX3GQRgMd3a5wXe5Q.dCoQTkRN9n), sL0HX2Qt0juTOH6S47a.fdlQCXhiKN), Entry.<>c.CCqQrjFWQtVEyJxtsOo(typeof(void).TypeHandle, aVZ292Qh1201BTbcvLE.URxQOOdBRu), opXdiOQpofdw3bIti5p.IDdQqxyrKF))
							{
								break;
							}
							num4 = 1;
							if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_4277f20c4546450686027c390218a60a == 0)
							{
								num4 = 2;
							}
						}
						IL_47:
						IL_56:
						return false;
						IL_65:
						return Entry.<>c.QC5q0YFj9sjQWwTej7c(Entry.<>c.JtcLbiFeL07sKssdJVU(m, ExR0kJQV50WuOmNvR2x.xEIQD5C8pS), Entry.<>c.RyHSOiFEh5walGZtwNs(--1922254668 ^ 1839038012 ^ <Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_4672c511600c49b1b4a7904620d7df97), HAFuKZ8WfdYD59Ixayi.LJw8eNaiSX);
						IL_163:
						return false;
					});
				}
				Entry.OnFixedUpdateReflected = source5.Where(predicate3).FirstOrDefault<MethodInfo>();
				Entry.OnLateUpdateReflected = Entry.mP3HCmZCRKgiBDnmu9n(obj, atThiPkMkgyaqaXkPH3.EmVkLDdW1D).SelectMany((Type t) => DFHh5IQ9JN8IFVfp8uu.bHC8kRmMET(t, DFHh5IQ9JN8IFVfp8uu.dFDQcg1K7P)).Where(delegate(MethodInfo m)
				{
					int num3 = 3;
					int num4 = num3;
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_12C;
						case 1:
							if (Entry.<>c.cfs8BoF3YM79xpEFLgN(m, wIoB3wQa1vWjU4KvIH2.K7GQmGfQGS))
							{
								return false;
							}
							num4 = 0;
							if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_91ecb92b03d4435895297ab3dd5d0d35 != 0)
							{
								num4 = 0;
								continue;
							}
							continue;
						case 2:
							if (Entry.<>c.nhP0JrFAIqoI5Cs88Dn(m, lXYEKRQuieXW1KIZqNE.nyfQxZkQqw))
							{
								num4 = 4;
								continue;
							}
							break;
						case 3:
							if (!Entry.<>c.CCP94xFvDUVYGw3xDX8(m, b5fMCjQPdU5chf3sGKr.tyuQGI834y))
							{
								return false;
							}
							num4 = 2;
							if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_5fdea96dfb24461dbc4dc46973600405 == 0)
							{
								num4 = 2;
								continue;
							}
							continue;
						case 4:
							goto IL_EA;
						case 5:
							goto IL_3F;
						case 6:
							break;
						default:
							goto IL_12C;
						}
						if (!Entry.<>c.h7V392FXa3GriaDmlBC(m, RlVu15QSpoIlHkqROp3.w3NQYcWkYl))
						{
							return false;
						}
						num4 = 1;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_48091a28d07442fb8723235601d68f74 != 0)
						{
							num4 = 1;
							continue;
						}
						continue;
						IL_12C:
						if (!Entry.<>c.OYjproFdLJ43u9oAnpJ(Entry.<>c.xqIxbMFw6mNDWP5dMR8(pueX3GQRgMd3a5wXe5Q.bHC8kRmMET(m, pueX3GQRgMd3a5wXe5Q.dCoQTkRN9n), sL0HX2Qt0juTOH6S47a.fdlQCXhiKN), Entry.<>c.CCqQrjFWQtVEyJxtsOo(typeof(void).TypeHandle, aVZ292Qh1201BTbcvLE.URxQOOdBRu), opXdiOQpofdw3bIti5p.IDdQqxyrKF))
						{
							return false;
						}
						num4 = 5;
					}
					IL_3F:
					return Entry.<>c.QC5q0YFj9sjQWwTej7c(Entry.<>c.JtcLbiFeL07sKssdJVU(m, ExR0kJQV50WuOmNvR2x.xEIQD5C8pS), Entry.<>c.RyHSOiFEh5walGZtwNs(205910188 ^ 645750684 ^ <Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_0988bb91a7564243b679db7669ea9a29), HAFuKZ8WfdYD59Ixayi.LJw8eNaiSX);
					IL_EA:
					return false;
				}).FirstOrDefault<MethodInfo>();
				Entry.OnUpdateReflected = Entry.mP3HCmZCRKgiBDnmu9n(obj, atThiPkMkgyaqaXkPH3.EmVkLDdW1D).SelectMany((Type t) => DFHh5IQ9JN8IFVfp8uu.bHC8kRmMET(t, DFHh5IQ9JN8IFVfp8uu.dFDQcg1K7P)).Where(delegate(MethodInfo m)
				{
					int num3 = 3;
					int num4 = num3;
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_F0;
						case 1:
							goto IL_C3;
						case 2:
							goto IL_DD;
						case 3:
							if (!Entry.<>c.CCP94xFvDUVYGw3xDX8(m, b5fMCjQPdU5chf3sGKr.tyuQGI834y))
							{
								num4 = 2;
								continue;
							}
							break;
						case 4:
							goto IL_85;
						case 5:
							break;
						case 6:
							goto IL_61;
						case 7:
							if (!Entry.<>c.cfs8BoF3YM79xpEFLgN(m, wIoB3wQa1vWjU4KvIH2.K7GQmGfQGS))
							{
								goto IL_F0;
							}
							num4 = 4;
							if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_3e42979b609c4706b44508e55e88e9cf != 0)
							{
								num4 = 1;
								continue;
							}
							continue;
						case 8:
							goto IL_142;
						default:
							goto IL_F0;
						}
						if (Entry.<>c.nhP0JrFAIqoI5Cs88Dn(m, lXYEKRQuieXW1KIZqNE.nyfQxZkQqw))
						{
							num4 = 6;
							continue;
						}
						IL_C3:
						if (RlVu15QSpoIlHkqROp3.bHC8kRmMET(m, RlVu15QSpoIlHkqROp3.w3NQYcWkYl))
						{
							num4 = 7;
							continue;
						}
						break;
						IL_F0:
						if (!Entry.<>c.OYjproFdLJ43u9oAnpJ(sL0HX2Qt0juTOH6S47a.bHC8kRmMET(pueX3GQRgMd3a5wXe5Q.bHC8kRmMET(m, pueX3GQRgMd3a5wXe5Q.dCoQTkRN9n), sL0HX2Qt0juTOH6S47a.fdlQCXhiKN), Entry.<>c.CCqQrjFWQtVEyJxtsOo(typeof(void).TypeHandle, aVZ292Qh1201BTbcvLE.URxQOOdBRu), opXdiOQpofdw3bIti5p.IDdQqxyrKF))
						{
							break;
						}
						num4 = 8;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_9a7a9ded8b94447e91b75e1fbec8298f != 0)
						{
							num4 = 8;
						}
					}
					IL_61:
					IL_85:
					IL_DD:
					return false;
					IL_142:
					return Entry.<>c.QC5q0YFj9sjQWwTej7c(Entry.<>c.JtcLbiFeL07sKssdJVU(m, ExR0kJQV50WuOmNvR2x.xEIQD5C8pS), Entry.<>c.RyHSOiFEh5walGZtwNs(-120306562 >> 4 ^ -1489491204 ^ <Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_516e7c1c53c544dcbcf294bcc1855e5f), HAFuKZ8WfdYD59Ixayi.LJw8eNaiSX);
				}).FirstOrDefault<MethodInfo>();
				num = 3;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000060C8 File Offset: 0x000042C8
		public override void OnApplicationQuit()
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
				{
					MethodInfo onApplicationQuitReflected = Entry.OnApplicationQuitReflected;
					if (onApplicationQuitReflected == null)
					{
						num2 = 0;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_5cbdb9f667864610b66369dd83d9a5a4 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					else
					{
						Entry.Nnex7bZpWLlhV7D8W4G(onApplicationQuitReflected, Entry.Instance, new object[0]);
						num2 = 2;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_19ee2fff40164b58a7e95a8fcf0cd6fb != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				break;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00006160 File Offset: 0x00004360
		public override void OnGUI()
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
				{
					MethodInfo onGUIReflected = Entry.OnGUIReflected;
					if (onGUIReflected != null)
					{
						onGUIReflected.Invoke(Entry.Instance, new object[0]);
						num2 = 2;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_eb52d23b1cd443f8ae7fc1f86f69405c != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					else
					{
						num2 = 0;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_2c78dcfafbd4494285774371892c4fda == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				break;
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00006200 File Offset: 0x00004400
		public override void OnFixedUpdate()
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					return;
				case 2:
				{
					MethodInfo onFixedUpdateReflected = Entry.OnFixedUpdateReflected;
					if (onFixedUpdateReflected == null)
					{
						num2 = 0;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_b7c0e64b7b264e55b8b97f0eb63cbd7d == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						Entry.Nnex7bZpWLlhV7D8W4G(onFixedUpdateReflected, Entry.Instance, new object[0]);
						num2 = 0;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_24746feba6364f3e9f90f3632ff333c7 == 0)
						{
							num2 = 0;
						}
					}
					break;
				}
				}
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00006298 File Offset: 0x00004498
		public override void OnLateUpdate()
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
				{
					MethodInfo onLateUpdateReflected = Entry.OnLateUpdateReflected;
					if (onLateUpdateReflected == null)
					{
						num2 = 0;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_ba0b3b07b0e74aeb850e2b167615e1b2 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					else
					{
						Entry.Nnex7bZpWLlhV7D8W4G(onLateUpdateReflected, Entry.Instance, new object[0]);
						num2 = 2;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_03d3178a0b3a46f09aa4aa8a27cb7321 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				break;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00006330 File Offset: 0x00004530
		public override void OnUpdate()
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					return;
				case 2:
				{
					MethodInfo onUpdateReflected = Entry.OnUpdateReflected;
					if (onUpdateReflected != null)
					{
						Entry.Nnex7bZpWLlhV7D8W4G(onUpdateReflected, Entry.Instance, new object[0]);
						num2 = 0;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_e6f884cc5c5a4d5a9126f9f13e859e11 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_bb6e445865874c27b93bef92a841963a != 0)
						{
							num2 = 1;
						}
					}
					break;
				}
				}
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000063D0 File Offset: 0x000045D0
		public Entry()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.JvcaFtwnsV();
			base..ctor();
			int num = 0;
			if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_e4b6ce4b61ac47ffb5bcd81f6694e933 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00006434 File Offset: 0x00004634
		// Note: this type is marked as 'beforefieldinit'.
		static Entry()
		{
			Entry.MNdsX0ZqogNqbhSi0Xb();
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00006444 File Offset: 0x00004644
		internal static bool LitgqWZRfJ3DqXn7hbC()
		{
			return ServerHandler.Init();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00006454 File Offset: 0x00004654
		internal static object ObZ60uZTNdZKOMrfHWS(object A_0, object A_1)
		{
			return umZlS685wVdN3IX1GXn.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000646C File Offset: 0x0000466C
		internal static object k0MTOFZtUwkQqBwSx0A(object A_0, object A_1)
		{
			return K2SC9ckUT0Ai0tEQjB8.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00006484 File Offset: 0x00004684
		internal static object mP3HCmZCRKgiBDnmu9n(object A_0, object A_1)
		{
			return atThiPkMkgyaqaXkPH3.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000649C File Offset: 0x0000469C
		internal static Type c5Jg7vZhM0rxHV3e2Sr(object A_0, object A_1)
		{
			return sEhx6skI2h9j0kjyu8N.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000064B4 File Offset: 0x000046B4
		internal static object v7K6GWZOMK38RaUE81m(object A_0, object A_1, object A_2)
		{
			return A_0.Invoke(A_1, A_2);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000064D0 File Offset: 0x000046D0
		internal static bool Gq1McYZal3nwrOrXEVW()
		{
			return Entry.o5TjY3ZYfXEBvm5cb5U == null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000064E4 File Offset: 0x000046E4
		internal static Entry AlTCUCZmC7NcgNlSk8s()
		{
			return Entry.o5TjY3ZYfXEBvm5cb5U;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000064F4 File Offset: 0x000046F4
		internal static object Nnex7bZpWLlhV7D8W4G(object A_0, object A_1, object A_2)
		{
			return A_0.Invoke(A_1, A_2);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00006510 File Offset: 0x00004710
		internal static void MNdsX0ZqogNqbhSi0Xb()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000030 RID: 48
		private static object Instance;

		// Token: 0x04000031 RID: 49
		private static MethodInfo OnLoadReflected;

		// Token: 0x04000032 RID: 50
		private static MethodInfo OnApplicationQuitReflected;

		// Token: 0x04000033 RID: 51
		private static MethodInfo OnGUIReflected;

		// Token: 0x04000034 RID: 52
		private static MethodInfo OnFixedUpdateReflected;

		// Token: 0x04000035 RID: 53
		private static MethodInfo OnLateUpdateReflected;

		// Token: 0x04000036 RID: 54
		private static MethodInfo OnUpdateReflected;

		// Token: 0x04000037 RID: 55
		private static Entry o5TjY3ZYfXEBvm5cb5U;
	}
}
