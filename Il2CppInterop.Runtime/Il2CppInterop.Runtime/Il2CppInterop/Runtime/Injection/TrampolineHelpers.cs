using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Injection
{
	// Token: 0x02000132 RID: 306
	public static class TrampolineHelpers
	{
		// Token: 0x06000D51 RID: 3409 RVA: 0x000158C8 File Offset: 0x00013AC8
		private static Type GetFixedSizeStructType(int size)
		{
			int num = 8;
			int num2 = num;
			Type result2;
			for (;;)
			{
				Type value;
				switch (num2)
				{
				case 0:
					goto IL_9C;
				case 1:
				{
					Type result = TrampolineHelpers._fixedStructCache[size] = value;
					num2 = 4;
					continue;
				}
				case 2:
					goto IL_196;
				case 3:
					TrampolineHelpers._fixedStructModuleBuilder = TrampolineHelpers.BSG6NyVXJCajPtdXeHr(TrampolineHelpers._fixedStructAssembly, TrampolineHelpers.ARtC2xVLHhvaGUEN2LY(-1733373103 ^ -293609545 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_960a54aec0f640cd975b2d62f3e0a596), NEllk4AeauycfOpdUn5.OCQAKEXBx8);
					num2 = 2;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b5e8e4146b4a178d711afdb1274991 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
				{
					Type result;
					return result;
				}
				case 5:
					return result2;
				case 6:
					break;
				case 7:
					if (TrampolineHelpers._fixedStructAssembly == null)
					{
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_355d73c700924bf28058452e63cd9cf1 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				case 8:
					if (TrampolineHelpers._fixedStructCache.TryGetValue(size, out result2))
					{
						return result2;
					}
					num2 = 7;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ce8abd079f9447b3bade260ffc64f0b8 == 0)
					{
						num2 = 7;
						continue;
					}
					continue;
				default:
					goto IL_9C;
				}
				if (TrampolineHelpers._fixedStructModuleBuilder != null)
				{
					goto IL_196;
				}
				num2 = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4f96e4bec76a4c34a19bcff463d6dc03 == 0)
				{
					num2 = 3;
					continue;
				}
				continue;
				IL_9C:
				TrampolineHelpers._fixedStructAssembly = TrampolineHelpers.ISGY08VA4VVrMsnEIBR(new AssemblyName(hIDAYxH6DWLHIthQgC.gSCeTtiku(-94957632 ^ -1958993102 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6776fc69415b4d309be658e7e8ac3a28)), AssemblyBuilderAccess.Run, UETNIlAjAFIFP95Jdbk.LGoAQFtfia);
				num2 = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_11d7514559f14fcba52669ac71e3cb39 != 0)
				{
					num2 = 6;
					continue;
				}
				continue;
				IL_196:
				object fixedStructModuleBuilder = TrampolineHelpers._fixedStructModuleBuilder;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1498942091 ^ 1327519562 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3e36778f33984767b2e7264fa31cee60), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				defaultInterpolatedStringHandler.AppendFormatted<int>(size);
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-854988610 >> 3 ^ -304378938 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ac2c10c141e144acbcef06aa86a10430), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				value = aBR5LPqTqhDZgK9xjFE.muOq5LWqgj(TrampolineHelpers.RWrMlHVkAyLxNgnkgvP(fixedStructModuleBuilder, AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7), TypeAttributes.ExplicitLayout, TrampolineHelpers.iW4C7yVcfNfQtlBH7S7(typeof(ValueType).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), size, xRhs31cM31GSEjwtvZ6.zF8cW4QDSJ), aBR5LPqTqhDZgK9xjFE.MpyqgFlfYx);
				num2 = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c04403f838344b38b3a8911774a446ea == 0)
				{
					num2 = 1;
				}
			}
			return result2;
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00015B28 File Offset: 0x00013D28
		public unsafe static Type NativeType(this Type managedType)
		{
			int num = 10;
			int num2 = num;
			uint num3;
			for (;;)
			{
				Type type;
				switch (num2)
				{
				case 0:
					goto IL_263;
				case 1:
					goto IL_F8;
				case 2:
					break;
				case 3:
					goto IL_194;
				case 4:
					if (TrampolineHelpers.m4Nt7HVOtV1L2cMbrJD(type, KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Il2CppObjectBase).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), a8rqaTcIBiq0vm5osDV.QmMcdBq7m4))
					{
						goto IL_107;
					}
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4356a7af7f8147b79f2ed4ab0c268438 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					IL_216:
					if (TrampolineHelpers.m4Nt7HVOtV1L2cMbrJD(managedType, TrampolineHelpers.iW4C7yVcfNfQtlBH7S7(typeof(Il2CppObjectBase).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), a8rqaTcIBiq0vm5osDV.QmMcdBq7m4))
					{
						num2 = 7;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3f609fad0bcc47d79d3add6a492d3616 == 0)
						{
							num2 = 11;
							continue;
						}
						continue;
					}
					else
					{
						if (JCwQlA5sGlTyuRZuORY.muOq5LWqgj(managedType, TrampolineHelpers.iW4C7yVcfNfQtlBH7S7(typeof(bool).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), JCwQlA5sGlTyuRZuORY.fqC5SwdxA5))
						{
							num2 = 6;
							continue;
						}
						return managedType;
					}
					break;
				case 6:
					goto IL_27C;
				case 7:
					goto IL_A5;
				case 8:
					goto IL_107;
				case 9:
					if (!a8rqaTcIBiq0vm5osDV.muOq5LWqgj(managedType, TrampolineHelpers.iW4C7yVcfNfQtlBH7S7(typeof(ValueType).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), a8rqaTcIBiq0vm5osDV.QmMcdBq7m4))
					{
						goto IL_B8;
					}
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b502855b254c47cfafcd30fd84ad7c96 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 10:
					if (!BD4fpgAfbgEWuCwmKMc.muOq5LWqgj(managedType, BD4fpgAfbgEWuCwmKMc.ktpA11NTFq))
					{
						num2 = 9;
						continue;
					}
					break;
				case 11:
					goto IL_5F;
				case 12:
					if (TrampolineHelpers.FeT7DSVHYTmT91aorWq(type, KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(bool).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), JCwQlA5sGlTyuRZuORY.fqC5SwdxA5))
					{
						num2 = 3;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e5b00aa4c99144c78d3bd63e270496cb != 0)
						{
							num2 = 13;
							continue;
						}
						continue;
					}
					else
					{
						if (TrampolineHelpers.FeT7DSVHYTmT91aorWq(type, TrampolineHelpers.iW4C7yVcfNfQtlBH7S7(typeof(string).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), JCwQlA5sGlTyuRZuORY.fqC5SwdxA5))
						{
							goto IL_107;
						}
						num2 = 4;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4f0a774880f74bccb3d4511e5f526375 != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					break;
				case 13:
					goto IL_1BD;
				case 14:
					num3 = 0U;
					num2 = 7;
					continue;
				default:
					goto IL_263;
				}
				type = TrampolineHelpers.n9PA5EV2D5ifmGRERat(managedType, Vc0yi5L7073fonVVdAs.IPoLP4Ir53);
				num2 = 12;
				continue;
				IL_263:
				if (!TrampolineHelpers.ukOD99Vt9Endfi1ImVD(tGaoqfciNIJEWVcpCnQ.rMNcwqM5R0))
				{
					num2 = 14;
					continue;
				}
				IL_B8:
				if (!JCwQlA5sGlTyuRZuORY.muOq5LWqgj(managedType, KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(string).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), JCwQlA5sGlTyuRZuORY.fqC5SwdxA5))
				{
					goto IL_216;
				}
				num2 = 3;
			}
			IL_5F:
			return TrampolineHelpers.iW4C7yVcfNfQtlBH7S7(typeof(IntPtr).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV);
			IL_A5:
			return TrampolineHelpers.EfYEeKVxGL7qsc0F4tY(IL2CPP.il2cpp_class_value_size(TrampolineHelpers.vRAsrhVvuWulnrcuML4(managedType), ref num3));
			IL_F8:
			return managedType;
			IL_107:
			return KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(IntPtr*).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV);
			IL_194:
			goto IL_5F;
			IL_1BD:
			return TrampolineHelpers.fEZBbBVhO81xJYBfpCG(TrampolineHelpers.iW4C7yVcfNfQtlBH7S7(typeof(byte).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), mBhXypcCQskhobRR7h8.Ktxc9umHur);
			IL_27C:
			return TrampolineHelpers.iW4C7yVcfNfQtlBH7S7(typeof(byte).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV);
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00015E04 File Offset: 0x00014004
		// Note: this type is marked as 'beforefieldinit'.
		static TrampolineHelpers()
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					TrampolineHelpers.Pey9csV8X2LUvfrZRAi();
					num2 = 2;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bac7568f2bc04130b6b980225b2cc409 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					TrampolineHelpers.k5lFuYVYdqD7HaGWJHy();
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8378a46aa7ed47018832a42729b1bc3b == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					TrampolineHelpers.GXLNOYVntwECnprxuBJ();
					num2 = 3;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7492c06848354e9185cf647bb6904451 == 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					TrampolineHelpers._fixedStructCache = new Dictionary<int, Type>();
					num2 = 4;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6a95c50bbb48420f8f11bb090d6d3bd5 != 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00015EE0 File Offset: 0x000140E0
		internal static object ISGY08VA4VVrMsnEIBR(object A_0, AssemblyBuilderAccess A_1, object A_2)
		{
			return UETNIlAjAFIFP95Jdbk.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00015EFC File Offset: 0x000140FC
		internal static object ARtC2xVLHhvaGUEN2LY(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00015F10 File Offset: 0x00014110
		internal static object BSG6NyVXJCajPtdXeHr(object A_0, object A_1, object A_2)
		{
			return NEllk4AeauycfOpdUn5.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x00015F2C File Offset: 0x0001412C
		internal static Type iW4C7yVcfNfQtlBH7S7(RuntimeTypeHandle A_0, object A_1)
		{
			return KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00015F44 File Offset: 0x00014144
		internal static object RWrMlHVkAyLxNgnkgvP(object A_0, object A_1, TypeAttributes A_2, Type A_3, int A_4, object A_5)
		{
			return xRhs31cM31GSEjwtvZ6.muOq5LWqgj(A_0, A_1, A_2, A_3, A_4, A_5);
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00015F6C File Offset: 0x0001416C
		internal static bool ajodi0Vq9wmpiB6261j()
		{
			return TrampolineHelpers.KOY90bVlihasay0ry9E == null;
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00015F80 File Offset: 0x00014180
		internal static TrampolineHelpers tp1OLxV5sCalk6OStoP()
		{
			return TrampolineHelpers.KOY90bVlihasay0ry9E;
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00015F90 File Offset: 0x00014190
		internal static Type n9PA5EV2D5ifmGRERat(object A_0, object A_1)
		{
			return Vc0yi5L7073fonVVdAs.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00015FA8 File Offset: 0x000141A8
		internal static bool FeT7DSVHYTmT91aorWq(Type A_0, Type A_1, object A_2)
		{
			return JCwQlA5sGlTyuRZuORY.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00015FC4 File Offset: 0x000141C4
		internal static Type fEZBbBVhO81xJYBfpCG(object A_0, object A_1)
		{
			return mBhXypcCQskhobRR7h8.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00015FDC File Offset: 0x000141DC
		internal static bool m4Nt7HVOtV1L2cMbrJD(object A_0, Type A_1, object A_2)
		{
			return a8rqaTcIBiq0vm5osDV.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00015FF8 File Offset: 0x000141F8
		internal static bool ukOD99Vt9Endfi1ImVD(object A_0)
		{
			return tGaoqfciNIJEWVcpCnQ.muOq5LWqgj(A_0);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0001600C File Offset: 0x0001420C
		internal static IntPtr vRAsrhVvuWulnrcuML4(Type type)
		{
			return Il2CppClassPointerStore.GetNativeClassPointer(type);
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00016020 File Offset: 0x00014220
		internal static Type EfYEeKVxGL7qsc0F4tY(int size)
		{
			return TrampolineHelpers.GetFixedSizeStructType(size);
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00016034 File Offset: 0x00014234
		internal static void k5lFuYVYdqD7HaGWJHy()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00016044 File Offset: 0x00014244
		internal static void Pey9csV8X2LUvfrZRAi()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00016054 File Offset: 0x00014254
		internal static void GXLNOYVntwECnprxuBJ()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x0400098F RID: 2447
		private static AssemblyBuilder _fixedStructAssembly;

		// Token: 0x04000990 RID: 2448
		private static ModuleBuilder _fixedStructModuleBuilder;

		// Token: 0x04000991 RID: 2449
		private static readonly Dictionary<int, Type> _fixedStructCache;

		// Token: 0x04000992 RID: 2450
		private static TrampolineHelpers KOY90bVlihasay0ry9E;
	}
}
