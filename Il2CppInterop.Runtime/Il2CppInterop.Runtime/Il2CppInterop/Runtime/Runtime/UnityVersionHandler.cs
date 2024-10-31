using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Assembly;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Class;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.EventInfo;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Exception;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.FieldInfo;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Image;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.ParameterInfo;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.PropertyInfo;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime
{
	// Token: 0x02000038 RID: 56
	public static class UnityVersionHandler
	{
		// Token: 0x06000236 RID: 566 RVA: 0x0000B758 File Offset: 0x00009958
		static UnityVersionHandler()
		{
			int num = 20;
			for (;;)
			{
				int num2 = num;
				Type[] array;
				for (;;)
				{
					int num3;
					Dictionary<Type, List<ValueTuple<Version, object>>>.ValueCollection.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_6A0;
					case 1:
						goto IL_28B;
					case 2:
						num3 = 0;
						num2 = 11;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_43cc35cb254148318955c7f83ade60f1 == 0)
						{
							num2 = 17;
							continue;
						}
						continue;
					case 3:
						goto IL_64A;
					case 4:
						goto IL_7B;
					case 5:
						try
						{
							for (;;)
							{
								if (enumerator.MoveNext())
								{
									goto IL_D2;
								}
								int num4 = 0;
								if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae != 0)
								{
									num4 = 1;
								}
								IL_BC:
								switch (num4)
								{
								default:
								{
									IL_D2:
									enumerator.Current.Sort(([TupleElementNames(new string[]
									{
										"Version",
										"Handler"
									})] ValueTuple<Version, object> a, [TupleElementNames(new string[]
									{
										"Version",
										"Handler"
									})] ValueTuple<Version, object> b) => -WmohnQkHearPP9KQSXU.muOq5LWqgj(a.Item1, b.Item1, WmohnQkHearPP9KQSXU.j0ekhcilb0));
									int num5 = 2;
									num4 = num5;
									goto IL_BC;
								}
								case 1:
									goto IL_127;
								case 2:
									break;
								}
							}
							IL_127:
							goto IL_64A;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
							int num6 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_575f8bd7bfb04e37800ff009689b44f6 == 0)
							{
								num6 = 0;
							}
							switch (num6)
							{
							}
						}
						break;
					case 6:
						UnityVersionHandler.VersionedHandlers = new Dictionary<Type, List<ValueTuple<Version, object>>>();
						num2 = 21;
						continue;
					case 7:
						try
						{
							for (;;)
							{
								IL_30B:
								IEnumerator<Type> enumerator2;
								if (UnityVersionHandler.HycZ3jxMFuj19dYGC0d(enumerator2, DsbfFKXX7uNX6vkdwrK.S71XcJhR1P))
								{
									goto IL_5AD;
								}
								int num7 = 0;
								if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3566f8d0a0994626b4e9fd660bc94d73 != 0)
								{
									num7 = 0;
								}
								Type type;
								for (;;)
								{
									IL_2ED:
									IEnumerator<ApplicableToUnityVersionsSinceAttribute> enumerator3;
									switch (num7)
									{
									case 1:
										goto IL_30B;
									case 2:
										goto IL_595;
									case 3:
										try
										{
											for (;;)
											{
												IL_3A2:
												if (UnityVersionHandler.HycZ3jxMFuj19dYGC0d(enumerator3, DsbfFKXX7uNX6vkdwrK.S71XcJhR1P))
												{
													goto IL_49E;
												}
												int num8 = 10;
												if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bac7568f2bc04130b6b980225b2cc409 == 0)
												{
													num8 = 0;
												}
												ApplicableToUnityVersionsSinceAttribute applicableToUnityVersionsSinceAttribute;
												for (;;)
												{
													IL_34F:
													object item;
													Type type2;
													switch (num8)
													{
													case 0:
														goto IL_448;
													case 1:
														item = sI0mcOcH9yYGnTNucJW.muOq5LWqgj(type, sI0mcOcH9yYGnTNucJW.Ephch8WL2H);
														num8 = 9;
														continue;
													case 2:
														goto IL_3A2;
													case 3:
													{
														num3 = 0;
														int num9 = 12;
														num8 = num9;
														continue;
													}
													case 4:
														goto IL_49E;
													case 5:
														goto IL_4C6;
													case 6:
														break;
													case 7:
														if (CS$<>8__locals1.interfacesOfInterest.Contains(type2))
														{
															goto IL_4D6;
														}
														num8 = 5;
														if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae != 0)
														{
															num8 = 5;
															continue;
														}
														continue;
													case 8:
														goto IL_4D6;
													case 9:
														array = aVCB8QcOrnOOhusMslb.muOq5LWqgj(type, aVCB8QcOrnOOhusMslb.mvPctN3Tvw);
														num8 = 3;
														continue;
													case 10:
														goto IL_509;
													case 11:
														goto IL_4C6;
													case 12:
														break;
													default:
														goto IL_448;
													}
													if (num3 >= array.Length)
													{
														num8 = 2;
														continue;
													}
													IL_448:
													type2 = array[num3];
													num8 = 2;
													if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8b1b71d923f0486b89239dd4a11f6d34 == 0)
													{
														num8 = 7;
														continue;
													}
													continue;
													IL_4C6:
													num3++;
													num8 = 6;
													continue;
													IL_4D6:
													UnityVersionHandler.VersionedHandlers[type2].Add(new ValueTuple<Version, object>(UnityVersionHandler.mWb6uCxRqpW6tHijZOP(UnityVersionHandler.QD5S3NxF35jOLnOYGm1(applicableToUnityVersionsSinceAttribute), g9YYsccva7iSDj0AiBJ.a6rcx7LbwL), item));
													num8 = 11;
												}
												IL_49E:
												applicableToUnityVersionsSinceAttribute = enumerator3.Current;
												num8 = 1;
												if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ce8abd079f9447b3bade260ffc64f0b8 == 0)
												{
													num8 = 0;
													goto IL_34F;
												}
												goto IL_34F;
											}
											IL_509:
											goto IL_30B;
										}
										finally
										{
											if (enumerator3 != null)
											{
												int num10 = 1;
												if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b9b6cd6cbc040a7be58cff054f9e843 != 0)
												{
													num10 = 1;
												}
												for (;;)
												{
													switch (num10)
													{
													case 1:
														UnityVersionHandler.Mvdu3LxWSLOdimDsp31(enumerator3, DgmGQ6Xkkf4mL7ILqee.HVMX2hXO7v);
														num10 = 0;
														if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_892d6b14d02a4b94bf68e8edfebcd1f5 == 0)
														{
															num10 = 0;
															continue;
														}
														continue;
													}
													break;
												}
											}
										}
										goto IL_595;
									case 4:
										goto IL_5AD;
									}
									goto Block_20;
									IL_595:
									enumerator3 = type.GetCustomAttributes<ApplicableToUnityVersionsSinceAttribute>().GetEnumerator();
									num7 = 3;
								}
								IL_5AD:
								type = enumerator2.Current;
								num7 = 2;
								goto IL_2ED;
							}
							Block_20:
							goto IL_1FC;
						}
						finally
						{
							IEnumerator<Type> enumerator2;
							if (enumerator2 != null)
							{
								goto IL_5F0;
							}
							int num11 = 2;
							IL_5DA:
							switch (num11)
							{
							case 1:
								IL_5F0:
								UnityVersionHandler.Mvdu3LxWSLOdimDsp31(enumerator2, DgmGQ6Xkkf4mL7ILqee.HVMX2hXO7v);
								num11 = 0;
								if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4c6a46c0a2d14747aa1dc5bf1581154d != 0)
								{
									num11 = 0;
									goto IL_5DA;
								}
								goto IL_5DA;
							}
						}
						goto IL_64A;
					case 8:
						goto IL_669;
					case 9:
					{
						Type[] allTypesSafe = UnityVersionHandler.GetAllTypesSafe();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae != 0)
						{
							num2 = 10;
							continue;
						}
						continue;
					}
					case 10:
					{
						Type[] allTypesSafe;
						CS$<>8__locals1.interfacesOfInterest = allTypesSafe.Where(delegate(Type t)
						{
							int num12 = 4;
							int num13 = num12;
							for (;;)
							{
								switch (num13)
								{
								case 1:
									goto IL_75;
								case 2:
									goto IL_99;
								case 3:
									goto IL_37;
								case 4:
									if (!UnityVersionHandler.<>c.CbkTf00APOQD1ByITmh(t, LiKbkikkh7ZdrbyQn4V.kb3k29qqEc))
									{
										num13 = 3;
										continue;
									}
									goto IL_99;
								}
								break;
								IL_99:
								if (LQUO1O5zLvD95E2LLPK.muOq5LWqgj(UnityVersionHandler.<>c.TMycJW0LRHDPimIphoV(typeof(INativeStructHandler).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), t, LQUO1O5zLvD95E2LLPK.S3EAleLciW))
								{
									break;
								}
								num13 = 1;
								if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_dd9c757bd882429784d62f0e80f112e6 != 0)
								{
									num13 = 1;
								}
							}
							goto IL_D7;
							IL_37:
							IL_75:
							return false;
							IL_D7:
							return CiJop65IqHJCv8k5I3G.muOq5LWqgj(t, UnityVersionHandler.<>c.TMycJW0LRHDPimIphoV(typeof(INativeStructHandler).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), CiJop65IqHJCv8k5I3G.Lvb5dhFO0X);
						}).ToArray<Type>();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb34a81d7cc4fbea898664370a8645f == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					case 11:
						return;
					case 12:
						num3++;
						num2 = 8;
						continue;
					case 13:
						num2 = 9;
						continue;
					case 14:
					{
						Type[] allTypesSafe;
						IEnumerable<Type> source = allTypesSafe;
						Func<Type, bool> predicate;
						if ((predicate = CS$<>8__locals1.<>9__1) == null)
						{
							predicate = (CS$<>8__locals1.<>9__1 = delegate(Type t)
							{
								int num12 = 3;
								int num13 = num12;
								for (;;)
								{
									switch (num13)
									{
									case 1:
										goto IL_5A;
									case 2:
										CS$<>8__locals2.t = t;
										num13 = 0;
										if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2ec67b9ff6c4cd7af2a4ceec32c111c == 0)
										{
											num13 = 0;
											continue;
										}
										continue;
									case 3:
										num13 = 2;
										if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_791a252a9221476faad2c6d41e84a167 == 0)
										{
											num13 = 0;
											continue;
										}
										continue;
									}
									if (UnityVersionHandler.<>c__DisplayClass14_0.CNXa7A0OpigxdByx8AE(CS$<>8__locals2.t, ddK2JAkOjGrwtODej2G.HdHkt91GmF))
									{
										return false;
									}
									num13 = 1;
									if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_30f9f5d7d3f347ddac00a7ce0719d7cd == 0)
									{
										num13 = 1;
									}
								}
								IL_5A:
								return CS$<>8__locals1.interfacesOfInterest.Any((Type i) => LQUO1O5zLvD95E2LLPK.muOq5LWqgj(i, CS$<>8__locals2.t, LQUO1O5zLvD95E2LLPK.S3EAleLciW));
							});
						}
						IEnumerator<Type> enumerator2 = source.Where(predicate).GetEnumerator();
						num2 = 7;
						continue;
					}
					case 15:
						goto IL_1FC;
					case 16:
						break;
					case 17:
						goto IL_669;
					case 18:
						UnityVersionHandler.sOTC5Ix10XCGdCjQcTX();
						num2 = 6;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4f96e4bec76a4c34a19bcff463d6dc03 != 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					case 19:
						hIDAYxH6DWLHIthQgC.oDuBOTgYK();
						num2 = 12;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7fef7bb77728417ab4965dd0775b5899 != 0)
						{
							num2 = 18;
							continue;
						}
						continue;
					case 20:
						UnityVersionHandler.LyfAjexffLrs7YFx7Lv();
						num2 = 17;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b82ae23c6544f3a11e54f2fed3ad25 != 0)
						{
							num2 = 19;
							continue;
						}
						continue;
					case 21:
						UnityVersionHandler.Handlers = new Dictionary<Type, object>();
						num2 = 13;
						continue;
					default:
						goto IL_6A0;
					}
					Type key;
					UnityVersionHandler.VersionedHandlers[key] = new List<ValueTuple<Version, object>>();
					num2 = 12;
					continue;
					IL_1FC:
					enumerator = UnityVersionHandler.VersionedHandlers.Values.GetEnumerator();
					num2 = 2;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0ec1d35577cb488fb4bdfc9810c6c86f != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
					IL_28B:
					key = array[num3];
					num2 = 16;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ce8abd079f9447b3bade260ffc64f0b8 == 0)
					{
						num2 = 13;
						continue;
					}
					continue;
					IL_669:
					if (num3 >= array.Length)
					{
						num2 = 14;
						continue;
					}
					goto IL_28B;
					IL_64A:
					UnityVersionHandler.RecalculateHandlers();
					num2 = 11;
					continue;
					IL_6A0:
					UnityVersionHandler.InterfacesOfInterest = CS$<>8__locals1.interfacesOfInterest;
					num2 = 4;
				}
				IL_7B:
				array = CS$<>8__locals1.interfacesOfInterest;
				num = 2;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000BEEC File Offset: 0x0000A0EC
		// (set) Token: 0x06000238 RID: 568 RVA: 0x0000BEFC File Offset: 0x0000A0FC
		public static bool HasGetMethodFromReflection { get; private set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000BF0C File Offset: 0x0000A10C
		// (set) Token: 0x0600023A RID: 570 RVA: 0x0000BF1C File Offset: 0x0000A11C
		public static bool HasShimForGetMethod { get; private set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000BF2C File Offset: 0x0000A12C
		// (set) Token: 0x0600023C RID: 572 RVA: 0x0000BF3C File Offset: 0x0000A13C
		public static bool IsMetadataV29OrHigher { get; private set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0000BF4C File Offset: 0x0000A14C
		public static bool MustUseDelegateConstructor
		{
			get
			{
				return UnityVersionHandler.Gxo0mcxCpyjB3UcigjQ();
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000BF5C File Offset: 0x0000A15C
		internal static void RecalculateHandlers()
		{
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					Version version;
					Type key;
					int num6;
					Type[] interfacesOfInterest;
					bool value;
					switch (num2)
					{
					default:
						if (UnityVersionHandler.jLNcGBxwYAqtjA3nBQJ(version, new Version(2020, 3, 41), MJ3bk1cn0l65lcxbr3K.A5wcbjo9Og))
						{
							goto Block_1;
						}
						goto IL_43B;
					case 1:
						goto IL_43B;
					case 2:
						version = UnityVersionHandler.BRFvqHxIQxGnC11ofs0();
						num2 = 17;
						continue;
					case 3:
						UnityVersionHandler.dGBRRJx9L4MJ3aPHykr(UnityVersionHandler.Handlers);
						num2 = 2;
						continue;
					case 4:
						UnityVersionHandler.propertyInfoStructHandler = UnityVersionHandler.GetHandler<INativePropertyInfoStructHandler>();
						num2 = 27;
						continue;
					case 5:
						UnityVersionHandler.Mp542yxEQsKei02RDw5(UnityVersionHandler.jLNcGBxwYAqtjA3nBQJ(version, new Version(2021, 2, 0), MJ3bk1cn0l65lcxbr3K.A5wcbjo9Og));
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3f609fad0bcc47d79d3add6a492d3616 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 6:
						goto IL_25C;
					case 7:
						UnityVersionHandler.methodInfoStructHandler = UnityVersionHandler.GetHandler<INativeMethodInfoStructHandler>();
						num2 = 26;
						continue;
					case 8:
					{
						List<ValueTuple<Version, object>>.Enumerator enumerator = UnityVersionHandler.VersionedHandlers[key].GetEnumerator();
						num2 = 11;
						continue;
					}
					case 9:
						goto IL_473;
					case 10:
						UnityVersionHandler.imageStructHandler = UnityVersionHandler.GetHandler<INativeImageStructHandler>();
						num2 = 3;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_43cc35cb254148318955c7f83ade60f1 == 0)
						{
							num2 = 7;
							continue;
						}
						continue;
					case 11:
						try
						{
							for (;;)
							{
								IL_30B:
								List<ValueTuple<Version, object>>.Enumerator enumerator;
								if (enumerator.MoveNext())
								{
									goto IL_39D;
								}
								int num3 = 5;
								ValueTuple<Version, object> valueTuple;
								for (;;)
								{
									IL_2E9:
									switch (num3)
									{
									default:
										goto IL_30B;
									case 1:
										goto IL_379;
									case 2:
										UnityVersionHandler.Handlers[key] = valueTuple.Item2;
										num3 = 0;
										if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5395ed2b7ead4e349835ba3f56e39138 == 0)
										{
											num3 = 1;
										}
										break;
									case 3:
									{
										if (UnityVersionHandler.IvnNxXxdoERwyKOBf6q(valueTuple.Item1, version, KOaa02cYedMbCqb2ZlK.DQCc8A963j))
										{
											goto IL_30B;
										}
										int num4 = 2;
										num3 = num4;
										break;
									}
									case 4:
										goto IL_39D;
									case 5:
										goto IL_3C5;
									}
								}
								IL_39D:
								valueTuple = enumerator.Current;
								num3 = 3;
								if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4356a7af7f8147b79f2ed4ab0c268438 == 0)
								{
									num3 = 3;
									goto IL_2E9;
								}
								goto IL_2E9;
							}
							IL_379:
							IL_3C5:
							goto IL_473;
						}
						finally
						{
							List<ValueTuple<Version, object>>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
							int num5 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_45f0db95dace45b6a0257ae80a3038eb == 0)
							{
								num5 = 0;
							}
							switch (num5)
							{
							}
						}
						goto IL_413;
					case 12:
						UnityVersionHandler.assemblyNameStructHandler = UnityVersionHandler.GetHandler<INativeAssemblyNameStructHandler>();
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6d9238cad9434518b97d223669b8fe50 != 0)
						{
							num2 = 16;
							continue;
						}
						continue;
					case 13:
						goto IL_16D;
					case 14:
						num6 = 0;
						num2 = 18;
						continue;
					case 15:
						UnityVersionHandler.exceptionStructHandler = UnityVersionHandler.GetHandler<INativeExceptionStructHandler>();
						num2 = 25;
						continue;
					case 16:
						UnityVersionHandler.classStructHandler = UnityVersionHandler.GetHandler<INativeClassStructHandler>();
						num2 = 22;
						continue;
					case 17:
						interfacesOfInterest = UnityVersionHandler.InterfacesOfInterest;
						num2 = 13;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_68cafcd7c4d444e39c183fde29795ee9 == 0)
						{
							num2 = 14;
							continue;
						}
						continue;
					case 18:
						goto IL_16D;
					case 19:
						UnityVersionHandler.assemblyStructHandler = UnityVersionHandler.GetHandler<INativeAssemblyStructHandler>();
						num2 = 12;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_960a54aec0f640cd975b2d62f3e0a596 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 20:
						value = true;
						goto IL_4BC;
					case 21:
						return;
					case 22:
						UnityVersionHandler.eventInfoStructHandler = UnityVersionHandler.GetHandler<INativeEventInfoStructHandler>();
						num2 = 15;
						continue;
					case 23:
						break;
					case 24:
						break;
					case 25:
						goto IL_413;
					case 26:
						UnityVersionHandler.parameterInfoStructHandler = UnityVersionHandler.GetHandler<INativeParameterInfoStructHandler>();
						num2 = 4;
						continue;
					case 27:
						UnityVersionHandler.typeStructHandler = UnityVersionHandler.GetHandler<INativeTypeStructHandler>();
						num2 = 21;
						continue;
					}
					key = interfacesOfInterest[num6];
					num2 = 8;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8378a46aa7ed47018832a42729b1bc3b == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
					IL_16D:
					if (num6 < interfacesOfInterest.Length)
					{
						num2 = 24;
						continue;
					}
					IL_25C:
					UnityVersionHandler.IrQ2qsxior50xUcj3RA(KOaa02cYedMbCqb2ZlK.muOq5LWqgj(version, new Version(2018, 1, 0), KOaa02cYedMbCqb2ZlK.DQCc8A963j));
					num2 = 5;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ac2c10c141e144acbcef06aa86a10430 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
					IL_413:
					UnityVersionHandler.fieldInfoStructHandler = UnityVersionHandler.GetHandler<INativeFieldInfoStructHandler>();
					num2 = 10;
					continue;
					IL_473:
					num6++;
					num2 = 13;
					continue;
					IL_4BC:
					UnityVersionHandler.yOTOQMxBtZeA8U1MWi9(value);
					num2 = 19;
					continue;
					IL_43B:
					value = UnityVersionHandler.Gxo0mcxCpyjB3UcigjQ();
					goto IL_4BC;
				}
				Block_1:
				num = 20;
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000C444 File Offset: 0x0000A644
		private static T GetHandler<T>()
		{
			object obj;
			if (UnityVersionHandler.Handlers.TryGetValue(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), out obj))
			{
				return (T)((object)obj);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(79, 2);
			gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(706498615 ^ 651797241 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_15379a47ca764a4e8e16ceaf4804e136), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
			CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, y1wUHLqoFyW6gbQN93u.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), y1wUHLqoFyW6gbQN93u.la8qUHBwms), CbStEuAV6XsjbRRcotu.WZrA06bJrN);
			gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-94957632 ^ -271328671 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eec4384c7d0d42baa74a4dbdbdbdd8df), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
			defaultInterpolatedStringHandler.AppendFormatted<Version>(GetReady.UnityVersion);
			gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1762404681 ^ -647172752 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2ec67b9ff6c4cd7af2a4ceec32c111c), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
			Logger.LogError(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
			throw new ApplicationException(hIDAYxH6DWLHIthQgC.gSCeTtiku(870414366 - 779185206 ^ 1153829202 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_30f9f5d7d3f347ddac00a7ce0719d7cd));
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000C568 File Offset: 0x0000A768
		private static Type[] GetAllTypesSafe()
		{
			Type[] result;
			switch (1)
			{
			case 1:
				try
				{
					result = fjjMkgc6keomuAuDhLe.muOq5LWqgj(MNuouJXnhvnoqseBC5Q.muOq5LWqgj(UnityVersionHandler.zW8hmsxGVqJoebX6B3Y(typeof(UnityVersionHandler).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), MNuouJXnhvnoqseBC5Q.LQDXbKGuGg), fjjMkgc6keomuAuDhLe.LixcyOtRCh);
					int num = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ac2c10c141e144acbcef06aa86a10430 == 0)
					{
						num = 0;
					}
					switch (num)
					{
					}
				}
				catch (ReflectionTypeLoadException ex)
				{
					IEnumerable<Type> source = UnityVersionHandler.vEuo1RxrX7kPhagrErE(ex, RO9IRbcJurHE9sWnZbv.c7ecpoCpEd);
					Func<Type, bool> predicate;
					if ((predicate = UnityVersionHandler.<>c.<>9__31_0) == null)
					{
						predicate = (UnityVersionHandler.<>c.<>9__31_0 = ((Type t) => UnityVersionHandler.<>c.b5kKNC0XskLZVJU2Whn(t, null, CiJop65IqHJCv8k5I3G.Lvb5dhFO0X)));
					}
					result = source.Where(predicate).ToArray<Type>();
					int num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eec4384c7d0d42baa74a4dbdbdbdd8df == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					}
				}
				break;
			}
			return result;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000C6A0 File Offset: 0x0000A8A0
		public static INativeAssemblyStruct NewAssembly()
		{
			return UnityVersionHandler.RdNVFxxTIZfvrrIXKSu(UnityVersionHandler.assemblyStructHandler);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000C6B4 File Offset: 0x0000A8B4
		public unsafe static INativeAssemblyStruct Wrap(Il2CppAssembly* assemblyPointer)
		{
			return UnityVersionHandler.SpHOBFxgp0sgTvUSQtK(UnityVersionHandler.assemblyStructHandler, assemblyPointer);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000C6C8 File Offset: 0x0000A8C8
		public static int AssemblySize()
		{
			return UnityVersionHandler.qDFsVZxoDyZbA1G9jfK(UnityVersionHandler.assemblyStructHandler);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000C6DC File Offset: 0x0000A8DC
		public static INativeAssemblyNameStruct NewAssemblyName()
		{
			return UnityVersionHandler.ny7HTixUpTxCkyjKdqj(UnityVersionHandler.assemblyNameStructHandler);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		public unsafe static INativeAssemblyNameStruct Wrap(Il2CppAssemblyName* assemblyNamePointer)
		{
			return UnityVersionHandler.qwGmcWxjnbnkKXXf8WG(UnityVersionHandler.assemblyNameStructHandler, assemblyNamePointer);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000C704 File Offset: 0x0000A904
		public static int AssemblyNameSize()
		{
			return UnityVersionHandler.qDFsVZxoDyZbA1G9jfK(UnityVersionHandler.assemblyNameStructHandler);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000C718 File Offset: 0x0000A918
		public static INativeClassStruct NewClass(int vTableSlots)
		{
			return UnityVersionHandler.OLam3MxQoY3DWljMYH7(UnityVersionHandler.classStructHandler, vTableSlots);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000C72C File Offset: 0x0000A92C
		public unsafe static INativeClassStruct Wrap(Il2CppClass* classPointer)
		{
			return UnityVersionHandler.classStructHandler.Wrap(classPointer);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000C740 File Offset: 0x0000A940
		public static int ClassSize()
		{
			return UnityVersionHandler.qDFsVZxoDyZbA1G9jfK(UnityVersionHandler.classStructHandler);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000C754 File Offset: 0x0000A954
		public static INativeEventInfoStruct NewEvent()
		{
			return UnityVersionHandler.Rp5cVbxeWD4YOPKSHBU(UnityVersionHandler.eventInfoStructHandler);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000C768 File Offset: 0x0000A968
		public unsafe static INativeEventInfoStruct Wrap(Il2CppEventInfo* eventInfoPointer)
		{
			return UnityVersionHandler.eventInfoStructHandler.Wrap(eventInfoPointer);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000C77C File Offset: 0x0000A97C
		public static int EventSize()
		{
			return UnityVersionHandler.qDFsVZxoDyZbA1G9jfK(UnityVersionHandler.eventInfoStructHandler);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000C790 File Offset: 0x0000A990
		public static INativeExceptionStruct NewException()
		{
			return UnityVersionHandler.rALHlsxKrXK76hHCJYa(UnityVersionHandler.exceptionStructHandler);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000C7A4 File Offset: 0x0000A9A4
		public unsafe static INativeExceptionStruct Wrap(Il2CppException* exceptionPointer)
		{
			return UnityVersionHandler.Yx9b5UxaJH5lSe0ndEe(UnityVersionHandler.exceptionStructHandler, exceptionPointer);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000C7B8 File Offset: 0x0000A9B8
		public static int ExceptionSize()
		{
			return UnityVersionHandler.exceptionStructHandler.Size();
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000C7CC File Offset: 0x0000A9CC
		public static INativeFieldInfoStruct NewField()
		{
			return UnityVersionHandler.skIHdPxZUnuQqaUdDK2(UnityVersionHandler.fieldInfoStructHandler);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		public unsafe static INativeFieldInfoStruct Wrap(Il2CppFieldInfo* fieldInfoPointer)
		{
			return UnityVersionHandler.GdYWZPxzTK0icLWZa9C(UnityVersionHandler.fieldInfoStructHandler, fieldInfoPointer);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
		public static int FieldInfoSize()
		{
			return UnityVersionHandler.qDFsVZxoDyZbA1G9jfK(UnityVersionHandler.fieldInfoStructHandler);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000C808 File Offset: 0x0000AA08
		public static INativeImageStruct NewImage()
		{
			return UnityVersionHandler.gqL4AfYlZMB45c6ZJNK(UnityVersionHandler.imageStructHandler);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000C81C File Offset: 0x0000AA1C
		public unsafe static INativeImageStruct Wrap(Il2CppImage* imagePointer)
		{
			return UnityVersionHandler.imageStructHandler.Wrap(imagePointer);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000C830 File Offset: 0x0000AA30
		public static int ImageSize()
		{
			return UnityVersionHandler.imageStructHandler.Size();
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000C844 File Offset: 0x0000AA44
		public static INativeMethodInfoStruct NewMethod()
		{
			return UnityVersionHandler.HZLwu1Yqp9FNIDnNIMX(UnityVersionHandler.methodInfoStructHandler);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000C858 File Offset: 0x0000AA58
		public unsafe static INativeMethodInfoStruct Wrap(Il2CppMethodInfo* methodPointer)
		{
			return UnityVersionHandler.MPrmC1Y5tf6WPFR7Q61(UnityVersionHandler.methodInfoStructHandler, methodPointer);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000C86C File Offset: 0x0000AA6C
		public static int MethodSize()
		{
			return UnityVersionHandler.qDFsVZxoDyZbA1G9jfK(UnityVersionHandler.methodInfoStructHandler);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000C880 File Offset: 0x0000AA80
		public unsafe static Il2CppParameterInfo*[] NewMethodParameterArray(int count)
		{
			return UnityVersionHandler.parameterInfoStructHandler.CreateNewParameterInfoArray(count);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000C894 File Offset: 0x0000AA94
		public unsafe static INativeParameterInfoStruct Wrap(Il2CppParameterInfo* parameterInfo)
		{
			return UnityVersionHandler.ftF1ymYA2GNuBSeo7AD(UnityVersionHandler.parameterInfoStructHandler, parameterInfo);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000C8A8 File Offset: 0x0000AAA8
		public unsafe static INativeParameterInfoStruct Wrap(Il2CppParameterInfo* parameterInfo, int index)
		{
			return UnityVersionHandler.parameterInfoStructHandler.Wrap(parameterInfo, index);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000C8C0 File Offset: 0x0000AAC0
		public static bool ParameterInfoHasNamePosToken()
		{
			return UnityVersionHandler.y0XLDvYLuKEh0ZDjIxn(UnityVersionHandler.parameterInfoStructHandler);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000C8D4 File Offset: 0x0000AAD4
		public static INativePropertyInfoStruct NewProperty()
		{
			return UnityVersionHandler.OZla5VYXrSkGUeW8bcH(UnityVersionHandler.propertyInfoStructHandler);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		public unsafe static INativePropertyInfoStruct Wrap(Il2CppPropertyInfo* propertyInfoPointer)
		{
			return UnityVersionHandler.lgih8kYcgSnPPK8K23W(UnityVersionHandler.propertyInfoStructHandler, propertyInfoPointer);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000C8FC File Offset: 0x0000AAFC
		public static int ParameterInfoSize()
		{
			return UnityVersionHandler.qDFsVZxoDyZbA1G9jfK(UnityVersionHandler.parameterInfoStructHandler);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000C910 File Offset: 0x0000AB10
		public static INativeTypeStruct NewType()
		{
			return UnityVersionHandler.UbA41IYk9sUtUbQ0Jtw(UnityVersionHandler.typeStructHandler);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000C924 File Offset: 0x0000AB24
		public unsafe static INativeTypeStruct Wrap(Il2CppTypeStruct* typePointer)
		{
			return UnityVersionHandler.whZernY23urflqlGgD6(UnityVersionHandler.typeStructHandler, typePointer);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000C938 File Offset: 0x0000AB38
		public static int TypeSize()
		{
			return UnityVersionHandler.qDFsVZxoDyZbA1G9jfK(UnityVersionHandler.typeStructHandler);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000C94C File Offset: 0x0000AB4C
		internal static void LyfAjexffLrs7YFx7Lv()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000C95C File Offset: 0x0000AB5C
		internal static void sOTC5Ix10XCGdCjQcTX()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000C96C File Offset: 0x0000AB6C
		internal static object QD5S3NxF35jOLnOYGm1(object A_0)
		{
			return A_0.StartVersion;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000C980 File Offset: 0x0000AB80
		internal static object mWb6uCxRqpW6tHijZOP(object A_0, object A_1)
		{
			return g9YYsccva7iSDj0AiBJ.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000C998 File Offset: 0x0000AB98
		internal static bool HycZ3jxMFuj19dYGC0d(object A_0, object A_1)
		{
			return DsbfFKXX7uNX6vkdwrK.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000C9B0 File Offset: 0x0000ABB0
		internal static void Mvdu3LxWSLOdimDsp31(object A_0, object A_1)
		{
			DgmGQ6Xkkf4mL7ILqee.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000C9C8 File Offset: 0x0000ABC8
		internal static bool JntXB3x4FYBIwnUCFvc()
		{
			return UnityVersionHandler.Xmmu4AxPfOOnrBMhB2J == null;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000C9DC File Offset: 0x0000ABDC
		internal static UnityVersionHandler QWikaGx3S5CCT6FpQtQ()
		{
			return UnityVersionHandler.Xmmu4AxPfOOnrBMhB2J;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000C9EC File Offset: 0x0000ABEC
		internal static bool Gxo0mcxCpyjB3UcigjQ()
		{
			return UnityVersionHandler.IsMetadataV29OrHigher;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000C9FC File Offset: 0x0000ABFC
		internal static void dGBRRJx9L4MJ3aPHykr(object A_0)
		{
			A_0.Clear();
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000CA10 File Offset: 0x0000AC10
		internal static object BRFvqHxIQxGnC11ofs0()
		{
			return GetReady.UnityVersion;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000CA20 File Offset: 0x0000AC20
		internal static bool IvnNxXxdoERwyKOBf6q(object A_0, object A_1, object A_2)
		{
			return KOaa02cYedMbCqb2ZlK.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000CA3C File Offset: 0x0000AC3C
		internal static void IrQ2qsxior50xUcj3RA(bool value)
		{
			UnityVersionHandler.HasGetMethodFromReflection = value;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000CA50 File Offset: 0x0000AC50
		internal static bool jLNcGBxwYAqtjA3nBQJ(object A_0, object A_1, object A_2)
		{
			return MJ3bk1cn0l65lcxbr3K.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000CA6C File Offset: 0x0000AC6C
		internal static void Mp542yxEQsKei02RDw5(bool value)
		{
			UnityVersionHandler.IsMetadataV29OrHigher = value;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000CA80 File Offset: 0x0000AC80
		internal static void yOTOQMxBtZeA8U1MWi9(bool value)
		{
			UnityVersionHandler.HasShimForGetMethod = value;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000CA94 File Offset: 0x0000AC94
		internal static Type zW8hmsxGVqJoebX6B3Y(RuntimeTypeHandle A_0, object A_1)
		{
			return KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000CAAC File Offset: 0x0000ACAC
		internal static object vEuo1RxrX7kPhagrErE(object A_0, object A_1)
		{
			return RO9IRbcJurHE9sWnZbv.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000CAC4 File Offset: 0x0000ACC4
		internal static object RdNVFxxTIZfvrrIXKSu(object A_0)
		{
			return ((INativeAssemblyStructHandler)A_0).CreateNewStruct();
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
		internal static object SpHOBFxgp0sgTvUSQtK(object A_0, object A_1)
		{
			return ((INativeAssemblyStructHandler)A_0).Wrap(A_1);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000CAF0 File Offset: 0x0000ACF0
		internal static int qDFsVZxoDyZbA1G9jfK(object A_0)
		{
			return ((INativeStructHandler)A_0).Size();
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000CB04 File Offset: 0x0000AD04
		internal static object ny7HTixUpTxCkyjKdqj(object A_0)
		{
			return ((INativeAssemblyNameStructHandler)A_0).CreateNewStruct();
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000CB18 File Offset: 0x0000AD18
		internal static object qwGmcWxjnbnkKXXf8WG(object A_0, object A_1)
		{
			return ((INativeAssemblyNameStructHandler)A_0).Wrap(A_1);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000CB30 File Offset: 0x0000AD30
		internal static object OLam3MxQoY3DWljMYH7(object A_0, int vTableSlots)
		{
			return ((INativeClassStructHandler)A_0).CreateNewStruct(vTableSlots);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000CB48 File Offset: 0x0000AD48
		internal static object Rp5cVbxeWD4YOPKSHBU(object A_0)
		{
			return ((INativeEventInfoStructHandler)A_0).CreateNewStruct();
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000CB5C File Offset: 0x0000AD5C
		internal static object rALHlsxKrXK76hHCJYa(object A_0)
		{
			return ((INativeExceptionStructHandler)A_0).CreateNewStruct();
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000CB70 File Offset: 0x0000AD70
		internal static object Yx9b5UxaJH5lSe0ndEe(object A_0, object A_1)
		{
			return ((INativeExceptionStructHandler)A_0).Wrap(A_1);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000CB88 File Offset: 0x0000AD88
		internal static object skIHdPxZUnuQqaUdDK2(object A_0)
		{
			return ((INativeFieldInfoStructHandler)A_0).CreateNewStruct();
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000CB9C File Offset: 0x0000AD9C
		internal static object GdYWZPxzTK0icLWZa9C(object A_0, object A_1)
		{
			return ((INativeFieldInfoStructHandler)A_0).Wrap(A_1);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000CBB4 File Offset: 0x0000ADB4
		internal static object gqL4AfYlZMB45c6ZJNK(object A_0)
		{
			return ((INativeImageStructHandler)A_0).CreateNewStruct();
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000CBC8 File Offset: 0x0000ADC8
		internal static object HZLwu1Yqp9FNIDnNIMX(object A_0)
		{
			return ((INativeMethodInfoStructHandler)A_0).CreateNewStruct();
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000CBDC File Offset: 0x0000ADDC
		internal static object MPrmC1Y5tf6WPFR7Q61(object A_0, object A_1)
		{
			return ((INativeMethodInfoStructHandler)A_0).Wrap(A_1);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000CBF4 File Offset: 0x0000ADF4
		internal static object ftF1ymYA2GNuBSeo7AD(object A_0, object A_1)
		{
			return ((INativeParameterInfoStructHandler)A_0).Wrap(A_1);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000CC0C File Offset: 0x0000AE0C
		internal static bool y0XLDvYLuKEh0ZDjIxn(object A_0)
		{
			return ((INativeParameterInfoStructHandler)A_0).HasNamePosToken;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000CC20 File Offset: 0x0000AE20
		internal static object OZla5VYXrSkGUeW8bcH(object A_0)
		{
			return ((INativePropertyInfoStructHandler)A_0).CreateNewStruct();
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000CC34 File Offset: 0x0000AE34
		internal static object lgih8kYcgSnPPK8K23W(object A_0, object A_1)
		{
			return ((INativePropertyInfoStructHandler)A_0).Wrap(A_1);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000CC4C File Offset: 0x0000AE4C
		internal static object UbA41IYk9sUtUbQ0Jtw(object A_0)
		{
			return ((INativeTypeStructHandler)A_0).CreateNewStruct();
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000CC60 File Offset: 0x0000AE60
		internal static object whZernY23urflqlGgD6(object A_0, object A_1)
		{
			return ((INativeTypeStructHandler)A_0).Wrap(A_1);
		}

		// Token: 0x040000D8 RID: 216
		private static readonly Type[] InterfacesOfInterest;

		// Token: 0x040000D9 RID: 217
		[TupleElementNames(new string[]
		{
			"Version",
			"Handler"
		})]
		private static readonly Dictionary<Type, List<ValueTuple<Version, object>>> VersionedHandlers;

		// Token: 0x040000DA RID: 218
		private static readonly Dictionary<Type, object> Handlers;

		// Token: 0x040000DB RID: 219
		internal static INativeAssemblyStructHandler assemblyStructHandler;

		// Token: 0x040000DC RID: 220
		internal static INativeAssemblyNameStructHandler assemblyNameStructHandler;

		// Token: 0x040000DD RID: 221
		internal static INativeClassStructHandler classStructHandler;

		// Token: 0x040000DE RID: 222
		internal static INativeEventInfoStructHandler eventInfoStructHandler;

		// Token: 0x040000DF RID: 223
		internal static INativeExceptionStructHandler exceptionStructHandler;

		// Token: 0x040000E0 RID: 224
		internal static INativeFieldInfoStructHandler fieldInfoStructHandler;

		// Token: 0x040000E1 RID: 225
		internal static INativeImageStructHandler imageStructHandler;

		// Token: 0x040000E2 RID: 226
		internal static INativeMethodInfoStructHandler methodInfoStructHandler;

		// Token: 0x040000E3 RID: 227
		internal static INativeParameterInfoStructHandler parameterInfoStructHandler;

		// Token: 0x040000E4 RID: 228
		internal static INativePropertyInfoStructHandler propertyInfoStructHandler;

		// Token: 0x040000E5 RID: 229
		internal static INativeTypeStructHandler typeStructHandler;

		// Token: 0x040000E9 RID: 233
		internal static UnityVersionHandler Xmmu4AxPfOOnrBMhB2J;
	}
}
