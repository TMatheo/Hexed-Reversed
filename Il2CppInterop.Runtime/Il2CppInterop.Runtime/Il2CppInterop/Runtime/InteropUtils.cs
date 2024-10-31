using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using MaoFcf2Vq4taIANM6n;

namespace Il2CppInterop.Runtime
{
	// Token: 0x02000010 RID: 16
	public static class InteropUtils
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x00009D0C File Offset: 0x00007F0C
		private static FieldInfo GetFieldInfoFromMethod(object method, object prefix)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				IEnumerator<ValueTuple<OpCode, long>> enumerator;
				Module module;
				switch (num2)
				{
				default:
					goto IL_2F;
				case 1:
					try
					{
						FieldInfo result;
						for (;;)
						{
							IL_1D8:
							if (InteropUtils.sOljvVtJbSfaiG2csmR(enumerator, DsbfFKXX7uNX6vkdwrK.S71XcJhR1P))
							{
								goto IL_FE;
							}
							int num3 = 3;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_960a54aec0f640cd975b2d62f3e0a596 == 0)
							{
								num3 = 0;
							}
							OpCode item;
							long item2;
							for (;;)
							{
								IL_5D:
								FieldInfo fieldInfo;
								Type type;
								switch (num3)
								{
								case 0:
									goto IL_1A7;
								case 1:
									if (fieldInfo == null)
									{
										goto IL_1A7;
									}
									num3 = 2;
									if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b55404cff7864ea3949f7b4156fd6ee5 == 0)
									{
										num3 = 4;
										continue;
									}
									continue;
								case 2:
									break;
								case 3:
									goto IL_251;
								case 4:
									type = InteropUtils.sVAGRmtbhX6LuHA1tcf(fieldInfo, h7CupmXInC1Jw4Mg12b.JHMXdddJHX);
									goto IL_214;
								case 5:
									if (InteropUtils.Sms5nFtymxb7sN25eQj(PTKvoMLfDDsJo1Y7iZK.muOq5LWqgj(fieldInfo, PTKvoMLfDDsJo1Y7iZK.RMSL1lrYOT), prefix, rsZ3wmLIoERoV03dQL9.K8rLdSBH8T))
									{
										num3 = 7;
										continue;
									}
									goto IL_1D8;
								case 6:
									goto IL_C9;
								case 7:
									result = fieldInfo;
									num3 = 8;
									continue;
								case 8:
									goto IL_97;
								case 9:
									goto IL_FE;
								case 10:
									goto IL_1D8;
								case 11:
									if (TsRDVLXMeB57rXlrHFA.muOq5LWqgj(item, OpCodes.Ldsfld, TsRDVLXMeB57rXlrHFA.fOfXWuho2e))
									{
										num3 = 6;
										if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ce8abd079f9447b3bade260ffc64f0b8 == 0)
										{
											num3 = 5;
											continue;
										}
										continue;
									}
									break;
								default:
									goto IL_1A7;
								}
								fieldInfo = InteropUtils.TvMw6Stn1lhgBg414OB(module, (int)item2, UvH1BhXCVRuAKQvgN5E.ePDX9IEyj5);
								num3 = 0;
								if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0ec1d35577cb488fb4bdfc9810c6c86f != 0)
								{
									num3 = 1;
									continue;
								}
								continue;
								IL_214:
								if (InteropUtils.HOhOn6t6bVHTGpCDo3C(type, KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(IntPtr).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), CiJop65IqHJCv8k5I3G.Lvb5dhFO0X))
								{
									break;
								}
								num3 = 4;
								if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_faca03c2e5084297b7a5d894ac66fa57 == 0)
								{
									num3 = 5;
									continue;
								}
								continue;
								IL_1A7:
								type = null;
								goto IL_214;
							}
							IL_C9:
							continue;
							IL_FE:
							ValueTuple<OpCode, long> valueTuple = enumerator.Current;
							item = valueTuple.Item1;
							item2 = valueTuple.Item2;
							num3 = 11;
							goto IL_5D;
						}
						IL_97:
						return result;
						IL_251:
						goto IL_2F;
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_30f9f5d7d3f347ddac00a7ce0719d7cd != 0)
							{
								num4 = 0;
							}
							for (;;)
							{
								switch (num4)
								{
								default:
									InteropUtils.YWnc5ktpdRdY2H7SfVX(enumerator, DgmGQ6Xkkf4mL7ILqee.HVMX2hXO7v);
									num4 = 1;
									if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_441278fe93ad425f9343d4f7d1692fca != 0)
									{
										num4 = 1;
									}
									break;
								case 1:
									goto IL_2BD;
								}
							}
						}
						IL_2BD:;
					}
					break;
				case 2:
					break;
				}
				object obj = InteropUtils.sR9ASytvjG2uMs57Uky(method, dncvcBX4QlSl3IGpJ20.mMaX302KRa);
				if (obj == null)
				{
					goto IL_2F3;
				}
				module = YCBcCJXfkpt8WshaQOI.muOq5LWqgj(InteropUtils.c6rSQ8t8Y1Nt2cv8m3a(InteropUtils.Ta3vuatYBYGcXYblSVP(method, RO0g2Vqz1eEynR0MNrr.f6M5lgRiE7), MNuouJXnhvnoqseBC5Q.LQDXbKGuGg), YCBcCJXfkpt8WshaQOI.oy7X1AyXR7).Single<Module>();
				enumerator = MiniIlParser.Decode(rfLwXwXFR52c4xkhoqv.muOq5LWqgj(obj, rfLwXwXFR52c4xkhoqv.BeYXRteSA9)).GetEnumerator();
				num2 = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b5e8e4146b4a178d711afdb1274991 == 0)
				{
					num2 = 1;
				}
			}
			IL_2F:
			return null;
			IL_2F3:
			throw new ArgumentException(InteropUtils.MrPhA3tx5uZ0WR0Po3O(2083107889 ^ 184066849 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_960a54aec0f640cd975b2d62f3e0a596));
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000A0A4 File Offset: 0x000082A4
		public static T Il2CppObjectPtrToIl2CppObject<T>(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				throw new NullReferenceException(hIDAYxH6DWLHIthQgC.gSCeTtiku(1154435597 ^ 279210028 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b5e8e4146b4a178d711afdb1274991));
			}
			return (T)((object)nBvQJXXi75Gfeg8nylj.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), BindingFlags.Instance | BindingFlags.Public, null, new Type[]
			{
				KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(IntPtr).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV)
			}, new ParameterModifier[0], nBvQJXXi75Gfeg8nylj.UFbXwr6aXc).Invoke(new object[]
			{
				ptr
			}));
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000A138 File Offset: 0x00008338
		public static FieldInfo GetIl2CppMethodInfoPointerFieldForGeneratedMethod(MethodBase method)
		{
			return InteropUtils.GetFieldInfoFromMethod(method, hIDAYxH6DWLHIthQgC.gSCeTtiku(2107640300 ^ 1775937021 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ac2c10c141e144acbcef06aa86a10430));
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000A164 File Offset: 0x00008364
		public static FieldInfo GetIl2CppFieldInfoPointerFieldForGeneratedFieldAccessor(MethodBase method)
		{
			return InteropUtils.klqKEYtVCCrODj6dnxy(method, InteropUtils.MrPhA3tx5uZ0WR0Po3O(~205218467 ^ -478460244 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae));
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000A190 File Offset: 0x00008390
		// Note: this type is marked as 'beforefieldinit'.
		static InteropUtils()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000A1A0 File Offset: 0x000083A0
		internal static object sR9ASytvjG2uMs57Uky(object A_0, object A_1)
		{
			return dncvcBX4QlSl3IGpJ20.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000A1B8 File Offset: 0x000083B8
		internal static object MrPhA3tx5uZ0WR0Po3O(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000A1CC File Offset: 0x000083CC
		internal static Type Ta3vuatYBYGcXYblSVP(object A_0, object A_1)
		{
			return RO0g2Vqz1eEynR0MNrr.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000A1E4 File Offset: 0x000083E4
		internal static object c6rSQ8t8Y1Nt2cv8m3a(object A_0, object A_1)
		{
			return MNuouJXnhvnoqseBC5Q.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000A1FC File Offset: 0x000083FC
		internal static object TvMw6Stn1lhgBg414OB(object A_0, int A_1, object A_2)
		{
			return UvH1BhXCVRuAKQvgN5E.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000A218 File Offset: 0x00008418
		internal static Type sVAGRmtbhX6LuHA1tcf(object A_0, object A_1)
		{
			return h7CupmXInC1Jw4Mg12b.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000A230 File Offset: 0x00008430
		internal static bool HOhOn6t6bVHTGpCDo3C(Type A_0, Type A_1, object A_2)
		{
			return CiJop65IqHJCv8k5I3G.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000A24C File Offset: 0x0000844C
		internal static bool Sms5nFtymxb7sN25eQj(object A_0, object A_1, object A_2)
		{
			return rsZ3wmLIoERoV03dQL9.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000A268 File Offset: 0x00008468
		internal static bool sOljvVtJbSfaiG2csmR(object A_0, object A_1)
		{
			return DsbfFKXX7uNX6vkdwrK.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000A280 File Offset: 0x00008480
		internal static void YWnc5ktpdRdY2H7SfVX(object A_0, object A_1)
		{
			DgmGQ6Xkkf4mL7ILqee.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000A298 File Offset: 0x00008498
		internal static bool L8xxSDtOpCoaaPy9fUE()
		{
			return InteropUtils.bE8QoYthCR3wg4XwnJN == null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000A2AC File Offset: 0x000084AC
		internal static InteropUtils Go7mqSttnQRJgrmrXE7()
		{
			return InteropUtils.bE8QoYthCR3wg4XwnJN;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000A2BC File Offset: 0x000084BC
		internal static object klqKEYtVCCrODj6dnxy(object A_0, object A_1)
		{
			return InteropUtils.GetFieldInfoFromMethod(A_0, A_1);
		}

		// Token: 0x0400002B RID: 43
		private static InteropUtils bE8QoYthCR3wg4XwnJN;
	}
}
