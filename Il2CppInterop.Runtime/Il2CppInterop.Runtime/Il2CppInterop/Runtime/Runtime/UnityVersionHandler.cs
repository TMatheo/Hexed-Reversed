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
	// Token: 0x0200003A RID: 58
	public static class UnityVersionHandler
	{
		// Token: 0x06000256 RID: 598 RVA: 0x0000C21C File Offset: 0x0000A41C
		static UnityVersionHandler()
		{
			int num = 5;
			for (;;)
			{
				int num2 = num;
				int num3;
				Type[] array2;
				Type key;
				for (;;)
				{
					Type[] array;
					IEnumerator<Type> enumerator;
					Dictionary<Type, List<ValueTuple<Version, object>>>.ValueCollection.Enumerator enumerator3;
					switch (num2)
					{
					case 1:
						UnityVersionHandler.VersionedHandlers = new Dictionary<Type, List<ValueTuple<Version, object>>>();
						num2 = 8;
						continue;
					case 2:
					{
						Type[] interfacesOfInterest = array.Where(delegate(Type t)
						{
							int num10 = 1;
							int num11 = num10;
							for (;;)
							{
								switch (num11)
								{
								case 1:
									if (UnityVersionHandler.<>c.o1bFFmk2h9RenPvfI86(t, uCPlZHG0DO6N4dwLgLW.s99GNWFPpm))
									{
										goto IL_7F;
									}
									num11 = 0;
									if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_17522b2a3ddb488c87b7266d3b1f941d != 0)
									{
										num11 = 0;
										continue;
									}
									continue;
								case 2:
									goto IL_33;
								case 3:
									goto IL_7F;
								}
								break;
								IL_7F:
								if (!UnityVersionHandler.<>c.mJo4lIkSbPyxiT5vMes(UnityVersionHandler.<>c.ER9J9mkyp189nJ6V2xb(typeof(INativeStructHandler).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), t, jQdCBeqaKbkTrjy04fc.AL9qC4lG9P))
								{
									break;
								}
								num11 = 2;
								if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56a961858094410b8d2e4da57d386f1 != 0)
								{
									num11 = 0;
								}
							}
							goto IL_BD;
							IL_33:
							return UnityVersionHandler.<>c.UD3gG8kgiBppkw7xCtC(t, UnityVersionHandler.<>c.ER9J9mkyp189nJ6V2xb(typeof(INativeStructHandler).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), Q57NvyUKOvY5KovuDBT.G0AU5uNCnx);
							IL_BD:
							return false;
						}).ToArray<Type>();
						num2 = 17;
						continue;
					}
					case 3:
						array = UnityVersionHandler.Jg6qa18Tepv6ZGwINSX();
						num2 = 2;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_282cf292112a4cf49ec1b8b2e2e7602a == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						UnityVersionHandler.UobUMe8j5eNCHTRZx33();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5636e8ee665e464ba930601506bed387 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						hIDAYxH6DWLHIthQgC.zSLipEDdx();
						num2 = 4;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6e39fb1a8feb46889b60abcfbb34e0df != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 6:
						num3++;
						num2 = 6;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5f6b46e73a464a41b29ca79bf0f3b8f9 != 0)
						{
							num2 = 10;
							continue;
						}
						continue;
					case 7:
						goto IL_12B;
					case 8:
						UnityVersionHandler.Handlers = new Dictionary<Type, object>();
						num2 = 19;
						continue;
					case 9:
						goto IL_64A;
					case 10:
						goto IL_5F0;
					case 11:
						goto IL_772;
					case 12:
						try
						{
							Type[] interfacesOfInterest;
							for (;;)
							{
								IL_1D7:
								if (UnityVersionHandler.S33AaB8nAvQHcZ6L4ZG(enumerator, sMonWyi0m0eKdsb3oFd.G31iN30Web))
								{
									goto IL_49F;
								}
								int num4 = 0;
								if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ce81190098cb44f1b9a77ca4822d7770 == 0)
								{
									num4 = 1;
								}
								Type type;
								IEnumerator<ApplicableToUnityVersionsSinceAttribute> enumerator2;
								for (;;)
								{
									IL_1B9:
									switch (num4)
									{
									case 1:
										goto IL_4B2;
									case 2:
										goto IL_1D7;
									case 3:
										enumerator2 = type.GetCustomAttributes<ApplicableToUnityVersionsSinceAttribute>().GetEnumerator();
										num4 = 0;
										if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d691a76a9c4746c9a1a67e34c67ca64b == 0)
										{
											num4 = 0;
											continue;
										}
										continue;
									case 4:
										goto IL_49F;
									}
									break;
								}
								IL_234:
								try
								{
									for (;;)
									{
										IL_2B7:
										if (UnityVersionHandler.S33AaB8nAvQHcZ6L4ZG(enumerator2, sMonWyi0m0eKdsb3oFd.G31iN30Web))
										{
											goto IL_286;
										}
										int num5 = 2;
										if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5d181dabf1ed42eca63023d24d927754 == 0)
										{
											num5 = 2;
										}
										ApplicableToUnityVersionsSinceAttribute applicableToUnityVersionsSinceAttribute;
										for (;;)
										{
											IL_248:
											Type type2;
											switch (num5)
											{
											case 0:
												goto IL_311;
											case 1:
												goto IL_343;
											case 2:
												goto IL_428;
											case 3:
											{
												object item;
												UnityVersionHandler.VersionedHandlers[type2].Add(new ValueTuple<Version, object>(UnityVersionHandler.oGHfwy85aaOV6DG1gO6(applicableToUnityVersionsSinceAttribute.StartVersion, TC3tiuIReZp4xSFfQ4g.MH5IkoyEL2), item));
												num5 = 7;
												continue;
											}
											case 4:
												goto IL_2B7;
											case 5:
												array2 = UnityVersionHandler.RQR3WD8KivZxsdBHdmO(type, Ftg1jVILvkPaH76x8ar.iD5I7CULQS);
												num5 = 9;
												if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c1d51581d05f41579ee6e476d9be288e != 0)
												{
													num5 = 0;
													continue;
												}
												continue;
											case 6:
												break;
											case 7:
												goto IL_3D0;
											case 8:
											{
												object item = UnityVersionHandler.mX934w8FLCk8r9sPCQj(type, zCejABIcUWYtVFUsplU.u6mI6lZ8Gi);
												num5 = 5;
												continue;
											}
											case 9:
												num3 = 0;
												num5 = 3;
												if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc != 0)
												{
													num5 = 11;
													continue;
												}
												continue;
											case 10:
												goto IL_286;
											case 11:
												break;
											case 12:
												goto IL_343;
											default:
												goto IL_311;
											}
											if (num3 >= array2.Length)
											{
												goto IL_2B7;
											}
											num5 = 1;
											if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_780e0c86b08f49d785f406cf802c7e87 != 0)
											{
												num5 = 1;
												continue;
											}
											continue;
											IL_311:
											if (!interfacesOfInterest.Contains(type2))
											{
												goto IL_3D0;
											}
											num5 = 0;
											if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f7e83c7c87bd4de9b4cb2b7f339254ad != 0)
											{
												num5 = 3;
												continue;
											}
											continue;
											IL_343:
											type2 = array2[num3];
											num5 = 0;
											if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a8737fecb12449d7ad23f5080d76d2f8 != 0)
											{
												num5 = 0;
												continue;
											}
											continue;
											IL_3D0:
											num3++;
											num5 = 6;
											if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_99cea5f9c4c245c2a5f184ab2e57fafc != 0)
											{
												num5 = 3;
											}
										}
										IL_286:
										applicableToUnityVersionsSinceAttribute = enumerator2.Current;
										num5 = 8;
										goto IL_248;
									}
									IL_428:
									continue;
								}
								finally
								{
									if (enumerator2 != null)
									{
										int num6 = 1;
										if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_49c6a53db2614593b5468905d8aba004 != 0)
										{
											num6 = 0;
										}
										for (;;)
										{
											switch (num6)
											{
											case 1:
												DOGJJXiuWsS2u63HZGH.i2IAUFsOOC(enumerator2, DOGJJXiuWsS2u63HZGH.wb2iEctcbL);
												num6 = 0;
												if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bd64431fd05f4961aa9b79e5bd243164 != 0)
												{
													num6 = 0;
													continue;
												}
												continue;
											}
											break;
										}
									}
								}
								goto IL_49F;
								goto IL_234;
								IL_49F:
								type = enumerator.Current;
								num4 = 3;
								goto IL_1B9;
							}
							IL_4B2:
							goto IL_61A;
						}
						finally
						{
							if (enumerator != null)
							{
								goto IL_506;
							}
							int num7 = 1;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bc244a0192c343599cd1cf83671e02ab == 0)
							{
								num7 = 0;
							}
							IL_4E1:
							switch (num7)
							{
							case 2:
								IL_506:
								UnityVersionHandler.eTFvlQ83nVjw8Eo5bh2(enumerator, DOGJJXiuWsS2u63HZGH.wb2iEctcbL);
								num7 = 0;
								if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c != 0)
								{
									num7 = 0;
									goto IL_4E1;
								}
								goto IL_4E1;
							}
						}
						goto IL_53C;
					case 13:
						UnityVersionHandler.VersionedHandlers[key] = new List<ValueTuple<Version, object>>();
						num2 = 6;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_483eecf3691e4ef2b23b2d4cb2ca3d52 == 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					case 14:
						goto IL_5F0;
					case 15:
						try
						{
							for (;;)
							{
								if (enumerator3.MoveNext())
								{
									goto IL_6BE;
								}
								int num8 = 1;
								if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c23fbb8072754781976c5c809c25ef15 != 0)
								{
									num8 = 0;
								}
								IL_6A8:
								switch (num8)
								{
								default:
									IL_6BE:
									enumerator3.Current.Sort(([TupleElementNames(new string[]
									{
										"Version",
										"Handler"
									})] ValueTuple<Version, object> a, [TupleElementNames(new string[]
									{
										"Version",
										"Handler"
									})] ValueTuple<Version, object> b) => -ApGmHfGuL5hZ8qulCy2.i2IAUFsOOC(a.Item1, b.Item1, ApGmHfGuL5hZ8qulCy2.r0NGERllyU));
									num8 = 2;
									if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc == 0)
									{
										num8 = 0;
										goto IL_6A8;
									}
									goto IL_6A8;
								case 1:
									goto IL_724;
								case 2:
									break;
								}
							}
							IL_724:
							goto IL_12B;
						}
						finally
						{
							((IDisposable)enumerator3).Dispose();
							int num9 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_be54e2986e644667aed0d52d0affe157 == 0)
							{
								num9 = 0;
							}
							switch (num9)
							{
							}
						}
						goto IL_772;
					case 16:
						return;
					case 17:
					{
						Type[] interfacesOfInterest;
						UnityVersionHandler.InterfacesOfInterest = interfacesOfInterest;
						num2 = 18;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2b9d7065e34e71a0069eb107f69f59 != 0)
						{
							num2 = 14;
							continue;
						}
						continue;
					}
					case 18:
					{
						Type[] interfacesOfInterest;
						array2 = interfacesOfInterest;
						num2 = 9;
						continue;
					}
					case 19:
						goto IL_53C;
					case 20:
						goto IL_61A;
					case 21:
						goto IL_EB;
					}
					nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_eea945ea6be345c0b18511ac11610b35 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_12B:
					UnityVersionHandler.RecalculateHandlers();
					num2 = 16;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7b2fff018dbf4cfe8ef41e2d123dc629 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_53C:
					num2 = 3;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_49c6a53db2614593b5468905d8aba004 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
					IL_5F0:
					if (num3 < array2.Length)
					{
						break;
					}
					num2 = 7;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_636316cf576545aba2f7d326dd7e140b != 0)
					{
						num2 = 11;
						continue;
					}
					continue;
					IL_61A:
					enumerator3 = UnityVersionHandler.VersionedHandlers.Values.GetEnumerator();
					num2 = 15;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2dd85386720b438b874026b47430e4fa == 0)
					{
						num2 = 8;
						continue;
					}
					continue;
					IL_772:
					IEnumerable<Type> source = array;
					Func<Type, bool> predicate;
					Func<Type, bool> <>9__1;
					if ((predicate = <>9__1) == null)
					{
						Type[] interfacesOfInterest;
						predicate = (<>9__1 = delegate(Type t)
						{
							int num10 = 1;
							int num11 = num10;
							for (;;)
							{
								switch (num11)
								{
								case 1:
									num11 = 0;
									if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_570d4e075bf443fcbaca8db32e007291 == 0)
									{
										num11 = 0;
										continue;
									}
									continue;
								case 2:
									goto IL_33;
								case 3:
									if (UnityVersionHandler.<>c__DisplayClass14_0.L27CGZkmv81giVNqr8Y(CS$<>8__locals2.t, wZ3Oj4GcCgfl8cQSytT.UItG6lsBxr))
									{
										return false;
									}
									num11 = 2;
									if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_feee416e61094c739ba253659ac2e257 != 0)
									{
										num11 = 0;
										continue;
									}
									continue;
								}
								CS$<>8__locals2.t = t;
								num11 = 3;
							}
							IL_33:
							return interfacesOfInterest.Any((Type i) => jQdCBeqaKbkTrjy04fc.i2IAUFsOOC(i, CS$<>8__locals2.t, jQdCBeqaKbkTrjy04fc.AL9qC4lG9P));
						});
					}
					enumerator = source.Where(predicate).GetEnumerator();
					num2 = 12;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_db312e48eee84539b805fee2f73a8cde == 0)
					{
						num2 = 2;
					}
				}
				IL_EB:
				key = array2[num3];
				num = 13;
				continue;
				IL_64A:
				num3 = 0;
				num = 14;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000CA3C File Offset: 0x0000AC3C
		// (set) Token: 0x06000258 RID: 600 RVA: 0x0000CA4C File Offset: 0x0000AC4C
		public static bool HasGetMethodFromReflection { get; private set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0000CA5C File Offset: 0x0000AC5C
		// (set) Token: 0x0600025A RID: 602 RVA: 0x0000CA6C File Offset: 0x0000AC6C
		public static bool HasShimForGetMethod { get; private set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000CA7C File Offset: 0x0000AC7C
		// (set) Token: 0x0600025C RID: 604 RVA: 0x0000CA8C File Offset: 0x0000AC8C
		public static bool IsMetadataV29OrHigher { get; private set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000CA9C File Offset: 0x0000AC9C
		public static bool MustUseDelegateConstructor
		{
			get
			{
				return UnityVersionHandler.hl2qya81TAGpL0myIvh();
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000CAAC File Offset: 0x0000ACAC
		internal static void RecalculateHandlers()
		{
			int num = 13;
			int num2 = num;
			for (;;)
			{
				Type[] interfacesOfInterest;
				Type key;
				Version version;
				bool value;
				switch (num2)
				{
				case 0:
					goto IL_105;
				case 1:
					return;
				case 2:
					UnityVersionHandler.methodInfoStructHandler = UnityVersionHandler.GetHandler<INativeMethodInfoStructHandler>();
					num2 = 14;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56c162609824bd799f0a7b9a8c33c89 != 0)
					{
						num2 = 9;
						continue;
					}
					continue;
				case 3:
					interfacesOfInterest = UnityVersionHandler.InterfacesOfInterest;
					num2 = 25;
					continue;
				case 4:
					goto IL_2E6;
				case 5:
					UnityVersionHandler.imageStructHandler = UnityVersionHandler.GetHandler<INativeImageStructHandler>();
					num2 = 2;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2f48f5515514b5a9a5feed6dc9a8dce == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 6:
				{
					List<ValueTuple<Version, object>>.Enumerator enumerator = UnityVersionHandler.VersionedHandlers[key].GetEnumerator();
					num2 = 24;
					continue;
				}
				case 7:
					goto IL_50F;
				case 8:
					break;
				case 9:
					UnityVersionHandler.eventInfoStructHandler = UnityVersionHandler.GetHandler<INativeEventInfoStructHandler>();
					num2 = 22;
					continue;
				case 10:
					UnityVersionHandler.classStructHandler = UnityVersionHandler.GetHandler<INativeClassStructHandler>();
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9c5de7c7e06f4557898ef7a8362c30ee == 0)
					{
						num2 = 9;
						continue;
					}
					continue;
				case 11:
					goto IL_346;
				case 12:
					version = UnityVersionHandler.eItS8E8pcHr9EV1bG5f();
					num2 = 3;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3af7919884e4482186590a3e6e04f119 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 13:
					UnityVersionHandler.EMrIxW8MMskZkWF0va0(UnityVersionHandler.Handlers);
					num2 = 12;
					continue;
				case 14:
					UnityVersionHandler.parameterInfoStructHandler = UnityVersionHandler.GetHandler<INativeParameterInfoStructHandler>();
					num2 = 26;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_feee416e61094c739ba253659ac2e257 != 0)
					{
						num2 = 21;
						continue;
					}
					continue;
				case 15:
					goto IL_346;
				case 16:
					value = true;
					goto IL_532;
				case 17:
					break;
				case 18:
					UnityVersionHandler.assemblyStructHandler = UnityVersionHandler.GetHandler<INativeAssemblyStructHandler>();
					num2 = 21;
					continue;
				case 19:
					goto IL_E1;
				case 20:
					UnityVersionHandler.typeStructHandler = UnityVersionHandler.GetHandler<INativeTypeStructHandler>();
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_1d16dd38ead14cb191f3b77c23c04ed4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 21:
					UnityVersionHandler.assemblyNameStructHandler = UnityVersionHandler.GetHandler<INativeAssemblyNameStructHandler>();
					num2 = 10;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d03e4e4716154375bf56bf596fbd5780 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 22:
					UnityVersionHandler.exceptionStructHandler = UnityVersionHandler.GetHandler<INativeExceptionStructHandler>();
					num2 = 27;
					continue;
				case 23:
					if (!UnityVersionHandler.FXHTou0HcZxOYwsj8ta(version, new Version(2020, 3, 41), HbkPPVIrlw6tA9Q2R8p.dpHIDX8uwt))
					{
						goto IL_50F;
					}
					num2 = 16;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c4640bbaac7c4988b56f91d1b6b3f1a9 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 24:
					try
					{
						for (;;)
						{
							IL_461:
							List<ValueTuple<Version, object>>.Enumerator enumerator;
							if (enumerator.MoveNext())
							{
								goto IL_48C;
							}
							int num3 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_39f2b5d6802b4ad087933b982faeb79d == 0)
							{
								num3 = 0;
							}
							ValueTuple<Version, object> valueTuple;
							for (;;)
							{
								IL_3DC:
								switch (num3)
								{
								case 1:
									UnityVersionHandler.Handlers[key] = valueTuple.Item2;
									num3 = 5;
									continue;
								case 2:
									goto IL_48C;
								case 3:
									if (UnityVersionHandler.ATV4yL84HlgRRdvowoi(valueTuple.Item1, version, KyXIT2IJ8SYijQquLsK.FWhIWUc8qZ))
									{
										goto IL_461;
									}
									num3 = 1;
									if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7c2c0376e816400db5716cff194385b2 == 0)
									{
										num3 = 0;
										continue;
									}
									continue;
								case 4:
									goto IL_461;
								}
								goto Block_19;
							}
							IL_48C:
							valueTuple = enumerator.Current;
							num3 = 3;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc == 0)
							{
								num3 = 0;
								goto IL_3DC;
							}
							goto IL_3DC;
						}
						Block_19:
						goto IL_E1;
					}
					finally
					{
						List<ValueTuple<Version, object>>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_dbbda98ba6574101bc623ad559f7b5a3 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						}
					}
					goto IL_502;
				case 25:
					goto IL_502;
				case 26:
					UnityVersionHandler.propertyInfoStructHandler = UnityVersionHandler.GetHandler<INativePropertyInfoStructHandler>();
					num2 = 20;
					continue;
				case 27:
					UnityVersionHandler.fieldInfoStructHandler = UnityVersionHandler.GetHandler<INativeFieldInfoStructHandler>();
					num2 = 4;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_16defe672aac4a3485dcd78387beb521 == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				default:
					goto IL_105;
				}
				int num5;
				key = interfacesOfInterest[num5];
				num2 = 6;
				continue;
				IL_E1:
				num5++;
				num2 = 15;
				continue;
				IL_105:
				UnityVersionHandler.zxuhUb0Ac0LsAYnPDaU(UnityVersionHandler.FXHTou0HcZxOYwsj8ta(version, new Version(2021, 2, 0), HbkPPVIrlw6tA9Q2R8p.dpHIDX8uwt));
				num2 = 23;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6926da1cf80047d3a6f0516668d22380 == 0)
				{
					num2 = 20;
					continue;
				}
				continue;
				IL_2E6:
				UnityVersionHandler.xr7SdB8zcwHvTHDXVKu(UnityVersionHandler.ATV4yL84HlgRRdvowoi(version, new Version(2018, 1, 0), KyXIT2IJ8SYijQquLsK.FWhIWUc8qZ));
				num2 = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d691a76a9c4746c9a1a67e34c67ca64b != 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_346:
				if (num5 >= interfacesOfInterest.Length)
				{
					goto IL_2E6;
				}
				num2 = 17;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2e7e5b018e46a2b3bb280ae243eb22 == 0)
				{
					num2 = 4;
					continue;
				}
				continue;
				IL_502:
				num5 = 0;
				num2 = 11;
				continue;
				IL_532:
				UnityVersionHandler.Kjg2hu0UM9V4GCvbwfJ(value);
				num2 = 18;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c474f43efb4d4f17b5c0c1bf3216ef4d == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_50F:
				value = UnityVersionHandler.hl2qya81TAGpL0myIvh();
				goto IL_532;
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000D02C File Offset: 0x0000B22C
		private static T GetHandler<T>()
		{
			object obj;
			if (UnityVersionHandler.Handlers.TryGetValue(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), out obj))
			{
				return (T)((object)obj);
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(79, 2);
			QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(407102589 ^ 389767779 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
			FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, XbWY87UAp2s3iIUpBiV.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), XbWY87UAp2s3iIUpBiV.tomUUWdyuW), FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
			QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(443897056 << 2 ^ 1729318311 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2b24b0de55344c2b8aaf8116dbc4d16), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
			defaultInterpolatedStringHandler.AppendFormatted<Version>(GetReady.UnityVersion);
			QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1742737878 ^ 1689767933 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9a3e85e731764e36a5b07f4e692becd8), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
			Logger.LogError(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
			throw new ApplicationException(hIDAYxH6DWLHIthQgC.gSCeTtiku(1742737878 ^ 981402630 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8155e7a9a9bd4894b741e1951a0eace6));
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000D150 File Offset: 0x0000B350
		private static Type[] GetAllTypesSafe()
		{
			Type[] result;
			switch (1)
			{
			case 1:
				try
				{
					result = UnityVersionHandler.L7nbNE0iRRuDQYCTTB7(UnityVersionHandler.DRjBwM09cveOdcgp8rb(UnityVersionHandler.OGXb3X0qVZEjo6GcQdp(typeof(UnityVersionHandler).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), BxCF5Pirv4081M3ZWUE.wrJiDQPPJd), hnXYKIIZqxlXRMPNURr.F43IoY8R9K);
					int num = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bd64431fd05f4961aa9b79e5bd243164 == 0)
					{
						num = 0;
					}
					switch (num)
					{
					}
				}
				catch (ReflectionTypeLoadException ex)
				{
					result = (from t in UnityVersionHandler.nv7XIA0Ihe8pRI1Drio(ex, md5tlxIbGIf5AOviEuX.lRgIfed1wS)
					where UnityVersionHandler.<>c.UD3gG8kgiBppkw7xCtC(t, null, Q57NvyUKOvY5KovuDBT.G0AU5uNCnx)
					select t).ToArray<Type>();
					int num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_afe904a262fb47328a49943b4b34b494 == 0)
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

		// Token: 0x06000261 RID: 609 RVA: 0x0000D284 File Offset: 0x0000B484
		public static INativeAssemblyStruct NewAssembly()
		{
			return UnityVersionHandler.cDPx6C0GNoCEEmTwBm0(UnityVersionHandler.assemblyStructHandler);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000D298 File Offset: 0x0000B498
		public unsafe static INativeAssemblyStruct Wrap(Il2CppAssembly* assemblyPointer)
		{
			return UnityVersionHandler.bU0ah50Y4wFo71LXyoq(UnityVersionHandler.assemblyStructHandler, assemblyPointer);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000D2AC File Offset: 0x0000B4AC
		public static int AssemblySize()
		{
			return UnityVersionHandler.cAFtgW0aSKY0oypPbNo(UnityVersionHandler.assemblyStructHandler);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		public static INativeAssemblyNameStruct NewAssemblyName()
		{
			return UnityVersionHandler.Ow9Zh10CSTTKPDBbkoA(UnityVersionHandler.assemblyNameStructHandler);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
		public unsafe static INativeAssemblyNameStruct Wrap(Il2CppAssemblyName* assemblyNamePointer)
		{
			return UnityVersionHandler.rJet930twV0TV1JH9aX(UnityVersionHandler.assemblyNameStructHandler, assemblyNamePointer);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000D2E8 File Offset: 0x0000B4E8
		public static int AssemblyNameSize()
		{
			return UnityVersionHandler.assemblyNameStructHandler.Size();
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000D2FC File Offset: 0x0000B4FC
		public static INativeClassStruct NewClass(int vTableSlots)
		{
			return UnityVersionHandler.d3eHIQ0xIgVK749IVHn(UnityVersionHandler.classStructHandler, vTableSlots);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000D310 File Offset: 0x0000B510
		public unsafe static INativeClassStruct Wrap(Il2CppClass* classPointer)
		{
			return UnityVersionHandler.louNcu0h2CqpIlb0b8F(UnityVersionHandler.classStructHandler, classPointer);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000D324 File Offset: 0x0000B524
		public static int ClassSize()
		{
			return UnityVersionHandler.classStructHandler.Size();
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000D338 File Offset: 0x0000B538
		public static INativeEventInfoStruct NewEvent()
		{
			return UnityVersionHandler.XsLY9r08fgcP4BplfEw(UnityVersionHandler.eventInfoStructHandler);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000D34C File Offset: 0x0000B54C
		public unsafe static INativeEventInfoStruct Wrap(Il2CppEventInfo* eventInfoPointer)
		{
			return UnityVersionHandler.eventInfoStructHandler.Wrap(eventInfoPointer);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000D360 File Offset: 0x0000B560
		public static int EventSize()
		{
			return UnityVersionHandler.cAFtgW0aSKY0oypPbNo(UnityVersionHandler.eventInfoStructHandler);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000D374 File Offset: 0x0000B574
		public static INativeExceptionStruct NewException()
		{
			return UnityVersionHandler.oEh1dV00RI0Tr1rQht9(UnityVersionHandler.exceptionStructHandler);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000D388 File Offset: 0x0000B588
		public unsafe static INativeExceptionStruct Wrap(Il2CppException* exceptionPointer)
		{
			return UnityVersionHandler.p3nBlq0NsNswWgmV3YB(UnityVersionHandler.exceptionStructHandler, exceptionPointer);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000D39C File Offset: 0x0000B59C
		public static int ExceptionSize()
		{
			return UnityVersionHandler.cAFtgW0aSKY0oypPbNo(UnityVersionHandler.exceptionStructHandler);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		public static INativeFieldInfoStruct NewField()
		{
			return UnityVersionHandler.fieldInfoStructHandler.CreateNewStruct();
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000D3C4 File Offset: 0x0000B5C4
		public unsafe static INativeFieldInfoStruct Wrap(Il2CppFieldInfo* fieldInfoPointer)
		{
			return UnityVersionHandler.fieldInfoStructHandler.Wrap(fieldInfoPointer);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000D3D8 File Offset: 0x0000B5D8
		public static int FieldInfoSize()
		{
			return UnityVersionHandler.fieldInfoStructHandler.Size();
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000D3EC File Offset: 0x0000B5EC
		public static INativeImageStruct NewImage()
		{
			return UnityVersionHandler.ftMKkH0ubd4lvDVr5t7(UnityVersionHandler.imageStructHandler);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000D400 File Offset: 0x0000B600
		public unsafe static INativeImageStruct Wrap(Il2CppImage* imagePointer)
		{
			return UnityVersionHandler.P3REgu0EMFA3oUrytCr(UnityVersionHandler.imageStructHandler, imagePointer);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000D414 File Offset: 0x0000B614
		public static int ImageSize()
		{
			return UnityVersionHandler.cAFtgW0aSKY0oypPbNo(UnityVersionHandler.imageStructHandler);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000D428 File Offset: 0x0000B628
		public static INativeMethodInfoStruct NewMethod()
		{
			return UnityVersionHandler.DYm3Nl0c6dFt7rVmv4D(UnityVersionHandler.methodInfoStructHandler);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000D43C File Offset: 0x0000B63C
		public unsafe static INativeMethodInfoStruct Wrap(Il2CppMethodInfo* methodPointer)
		{
			return UnityVersionHandler.Ywee6a06lCqhVcajxyR(UnityVersionHandler.methodInfoStructHandler, methodPointer);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000D450 File Offset: 0x0000B650
		public static int MethodSize()
		{
			return UnityVersionHandler.cAFtgW0aSKY0oypPbNo(UnityVersionHandler.methodInfoStructHandler);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000D464 File Offset: 0x0000B664
		public unsafe static Il2CppParameterInfo*[] NewMethodParameterArray(int count)
		{
			return UnityVersionHandler.parameterInfoStructHandler.CreateNewParameterInfoArray(count);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000D478 File Offset: 0x0000B678
		public unsafe static INativeParameterInfoStruct Wrap(Il2CppParameterInfo* parameterInfo)
		{
			return UnityVersionHandler.parameterInfoStructHandler.Wrap(parameterInfo);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000D48C File Offset: 0x0000B68C
		public unsafe static INativeParameterInfoStruct Wrap(Il2CppParameterInfo* parameterInfo, int index)
		{
			return UnityVersionHandler.LXCxwZ0LAf6kMVZ3yaD(UnityVersionHandler.parameterInfoStructHandler, parameterInfo, index);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000D4A4 File Offset: 0x0000B6A4
		public static bool ParameterInfoHasNamePosToken()
		{
			return UnityVersionHandler.WcIwp107DFKdym72JaD(UnityVersionHandler.parameterInfoStructHandler);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		public static INativePropertyInfoStruct NewProperty()
		{
			return UnityVersionHandler.tinumm0RYhyvfFZkDG0(UnityVersionHandler.propertyInfoStructHandler);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000D4CC File Offset: 0x0000B6CC
		public unsafe static INativePropertyInfoStruct Wrap(Il2CppPropertyInfo* propertyInfoPointer)
		{
			return UnityVersionHandler.trQrZa0k88lmET0To1x(UnityVersionHandler.propertyInfoStructHandler, propertyInfoPointer);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000D4E0 File Offset: 0x0000B6E0
		public static int ParameterInfoSize()
		{
			return UnityVersionHandler.cAFtgW0aSKY0oypPbNo(UnityVersionHandler.parameterInfoStructHandler);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000D4F4 File Offset: 0x0000B6F4
		public static INativeTypeStruct NewType()
		{
			return UnityVersionHandler.I0P3dn0JU9vcfSfSu0M(UnityVersionHandler.typeStructHandler);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000D508 File Offset: 0x0000B708
		public unsafe static INativeTypeStruct Wrap(Il2CppTypeStruct* typePointer)
		{
			return UnityVersionHandler.QO4ISS0WuZX8rUBA00P(UnityVersionHandler.typeStructHandler, typePointer);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000D51C File Offset: 0x0000B71C
		public static int TypeSize()
		{
			return UnityVersionHandler.typeStructHandler.Size();
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000D530 File Offset: 0x0000B730
		internal static void UobUMe8j5eNCHTRZx33()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000D540 File Offset: 0x0000B740
		internal static object Jg6qa18Tepv6ZGwINSX()
		{
			return UnityVersionHandler.GetAllTypesSafe();
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000D550 File Offset: 0x0000B750
		internal static object mX934w8FLCk8r9sPCQj(Type A_0, object A_1)
		{
			return zCejABIcUWYtVFUsplU.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000D568 File Offset: 0x0000B768
		internal static object RQR3WD8KivZxsdBHdmO(object A_0, object A_1)
		{
			return Ftg1jVILvkPaH76x8ar.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000D580 File Offset: 0x0000B780
		internal static object oGHfwy85aaOV6DG1gO6(object A_0, object A_1)
		{
			return TC3tiuIReZp4xSFfQ4g.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000D598 File Offset: 0x0000B798
		internal static bool S33AaB8nAvQHcZ6L4ZG(object A_0, object A_1)
		{
			return sMonWyi0m0eKdsb3oFd.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000D5B0 File Offset: 0x0000B7B0
		internal static void eTFvlQ83nVjw8Eo5bh2(object A_0, object A_1)
		{
			DOGJJXiuWsS2u63HZGH.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000D5C8 File Offset: 0x0000B7C8
		internal static bool wpJhhu8vMDMnoDIeT8j()
		{
			return UnityVersionHandler.gpySAb8mP79tB60RlFC == null;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000D5DC File Offset: 0x0000B7DC
		internal static UnityVersionHandler pVs77A8BxPmV1lLuDM4()
		{
			return UnityVersionHandler.gpySAb8mP79tB60RlFC;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000D5EC File Offset: 0x0000B7EC
		internal static bool hl2qya81TAGpL0myIvh()
		{
			return UnityVersionHandler.IsMetadataV29OrHigher;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000D5FC File Offset: 0x0000B7FC
		internal static void EMrIxW8MMskZkWF0va0(object A_0)
		{
			A_0.Clear();
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000D610 File Offset: 0x0000B810
		internal static object eItS8E8pcHr9EV1bG5f()
		{
			return GetReady.UnityVersion;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000D620 File Offset: 0x0000B820
		internal static bool ATV4yL84HlgRRdvowoi(object A_0, object A_1, object A_2)
		{
			return KyXIT2IJ8SYijQquLsK.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000D63C File Offset: 0x0000B83C
		internal static void xr7SdB8zcwHvTHDXVKu(bool value)
		{
			UnityVersionHandler.HasGetMethodFromReflection = value;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000D650 File Offset: 0x0000B850
		internal static bool FXHTou0HcZxOYwsj8ta(object A_0, object A_1, object A_2)
		{
			return HbkPPVIrlw6tA9Q2R8p.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000D66C File Offset: 0x0000B86C
		internal static void zxuhUb0Ac0LsAYnPDaU(bool value)
		{
			UnityVersionHandler.IsMetadataV29OrHigher = value;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000D680 File Offset: 0x0000B880
		internal static void Kjg2hu0UM9V4GCvbwfJ(bool value)
		{
			UnityVersionHandler.HasShimForGetMethod = value;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000D694 File Offset: 0x0000B894
		internal static Type OGXb3X0qVZEjo6GcQdp(RuntimeTypeHandle A_0, object A_1)
		{
			return byRw0gA2NyqHkl03ii9.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000D6AC File Offset: 0x0000B8AC
		internal static object DRjBwM09cveOdcgp8rb(object A_0, object A_1)
		{
			return BxCF5Pirv4081M3ZWUE.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000D6C4 File Offset: 0x0000B8C4
		internal static object L7nbNE0iRRuDQYCTTB7(object A_0, object A_1)
		{
			return hnXYKIIZqxlXRMPNURr.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000D6DC File Offset: 0x0000B8DC
		internal static object nv7XIA0Ihe8pRI1Drio(object A_0, object A_1)
		{
			return md5tlxIbGIf5AOviEuX.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000D6F4 File Offset: 0x0000B8F4
		internal static object cDPx6C0GNoCEEmTwBm0(object A_0)
		{
			return ((INativeAssemblyStructHandler)A_0).CreateNewStruct();
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000D708 File Offset: 0x0000B908
		internal static object bU0ah50Y4wFo71LXyoq(object A_0, object A_1)
		{
			return ((INativeAssemblyStructHandler)A_0).Wrap(A_1);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000D720 File Offset: 0x0000B920
		internal static int cAFtgW0aSKY0oypPbNo(object A_0)
		{
			return ((INativeStructHandler)A_0).Size();
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000D734 File Offset: 0x0000B934
		internal static object Ow9Zh10CSTTKPDBbkoA(object A_0)
		{
			return ((INativeAssemblyNameStructHandler)A_0).CreateNewStruct();
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000D748 File Offset: 0x0000B948
		internal static object rJet930twV0TV1JH9aX(object A_0, object A_1)
		{
			return ((INativeAssemblyNameStructHandler)A_0).Wrap(A_1);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000D760 File Offset: 0x0000B960
		internal static object d3eHIQ0xIgVK749IVHn(object A_0, int vTableSlots)
		{
			return ((INativeClassStructHandler)A_0).CreateNewStruct(vTableSlots);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000D778 File Offset: 0x0000B978
		internal static object louNcu0h2CqpIlb0b8F(object A_0, object A_1)
		{
			return ((INativeClassStructHandler)A_0).Wrap(A_1);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000D790 File Offset: 0x0000B990
		internal static object XsLY9r08fgcP4BplfEw(object A_0)
		{
			return ((INativeEventInfoStructHandler)A_0).CreateNewStruct();
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000D7A4 File Offset: 0x0000B9A4
		internal static object oEh1dV00RI0Tr1rQht9(object A_0)
		{
			return ((INativeExceptionStructHandler)A_0).CreateNewStruct();
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
		internal static object p3nBlq0NsNswWgmV3YB(object A_0, object A_1)
		{
			return ((INativeExceptionStructHandler)A_0).Wrap(A_1);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		internal static object ftMKkH0ubd4lvDVr5t7(object A_0)
		{
			return ((INativeImageStructHandler)A_0).CreateNewStruct();
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000D7E4 File Offset: 0x0000B9E4
		internal static object P3REgu0EMFA3oUrytCr(object A_0, object A_1)
		{
			return ((INativeImageStructHandler)A_0).Wrap(A_1);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000D7FC File Offset: 0x0000B9FC
		internal static object DYm3Nl0c6dFt7rVmv4D(object A_0)
		{
			return ((INativeMethodInfoStructHandler)A_0).CreateNewStruct();
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000D810 File Offset: 0x0000BA10
		internal static object Ywee6a06lCqhVcajxyR(object A_0, object A_1)
		{
			return ((INativeMethodInfoStructHandler)A_0).Wrap(A_1);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000D828 File Offset: 0x0000BA28
		internal static object LXCxwZ0LAf6kMVZ3yaD(object A_0, object A_1, int index)
		{
			return ((INativeParameterInfoStructHandler)A_0).Wrap(A_1, index);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000D844 File Offset: 0x0000BA44
		internal static bool WcIwp107DFKdym72JaD(object A_0)
		{
			return ((INativeParameterInfoStructHandler)A_0).HasNamePosToken;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000D858 File Offset: 0x0000BA58
		internal static object tinumm0RYhyvfFZkDG0(object A_0)
		{
			return ((INativePropertyInfoStructHandler)A_0).CreateNewStruct();
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000D86C File Offset: 0x0000BA6C
		internal static object trQrZa0k88lmET0To1x(object A_0, object A_1)
		{
			return ((INativePropertyInfoStructHandler)A_0).Wrap(A_1);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000D884 File Offset: 0x0000BA84
		internal static object I0P3dn0JU9vcfSfSu0M(object A_0)
		{
			return ((INativeTypeStructHandler)A_0).CreateNewStruct();
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000D898 File Offset: 0x0000BA98
		internal static object QO4ISS0WuZX8rUBA00P(object A_0, object A_1)
		{
			return ((INativeTypeStructHandler)A_0).Wrap(A_1);
		}

		// Token: 0x040000E3 RID: 227
		private static readonly Type[] InterfacesOfInterest;

		// Token: 0x040000E4 RID: 228
		[TupleElementNames(new string[]
		{
			"Version",
			"Handler"
		})]
		private static readonly Dictionary<Type, List<ValueTuple<Version, object>>> VersionedHandlers;

		// Token: 0x040000E5 RID: 229
		private static readonly Dictionary<Type, object> Handlers;

		// Token: 0x040000E6 RID: 230
		internal static INativeAssemblyStructHandler assemblyStructHandler;

		// Token: 0x040000E7 RID: 231
		internal static INativeAssemblyNameStructHandler assemblyNameStructHandler;

		// Token: 0x040000E8 RID: 232
		internal static INativeClassStructHandler classStructHandler;

		// Token: 0x040000E9 RID: 233
		internal static INativeEventInfoStructHandler eventInfoStructHandler;

		// Token: 0x040000EA RID: 234
		internal static INativeExceptionStructHandler exceptionStructHandler;

		// Token: 0x040000EB RID: 235
		internal static INativeFieldInfoStructHandler fieldInfoStructHandler;

		// Token: 0x040000EC RID: 236
		internal static INativeImageStructHandler imageStructHandler;

		// Token: 0x040000ED RID: 237
		internal static INativeMethodInfoStructHandler methodInfoStructHandler;

		// Token: 0x040000EE RID: 238
		internal static INativeParameterInfoStructHandler parameterInfoStructHandler;

		// Token: 0x040000EF RID: 239
		internal static INativePropertyInfoStructHandler propertyInfoStructHandler;

		// Token: 0x040000F0 RID: 240
		internal static INativeTypeStructHandler typeStructHandler;

		// Token: 0x040000F4 RID: 244
		internal static UnityVersionHandler gpySAb8mP79tB60RlFC;
	}
}
