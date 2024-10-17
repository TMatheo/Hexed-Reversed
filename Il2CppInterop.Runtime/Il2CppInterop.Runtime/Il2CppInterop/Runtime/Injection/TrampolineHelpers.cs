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
	// Token: 0x02000135 RID: 309
	public static class TrampolineHelpers
	{
		// Token: 0x06000D78 RID: 3448 RVA: 0x00016580 File Offset: 0x00014780
		private static Type GetFixedSizeStructType(int size)
		{
			int num = 9;
			Type result2;
			for (;;)
			{
				int num2 = num;
				Type value;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1DB;
					case 1:
					{
						Type result;
						return result;
					}
					case 2:
						break;
					case 3:
						goto IL_21E;
					case 4:
					{
						Type result = TrampolineHelpers._fixedStructCache[size] = value;
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a36e967c0f044e9ebf523536bdec8e28 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					case 5:
						goto IL_6F;
					case 6:
						goto IL_19C;
					case 7:
						goto IL_1DB;
					case 8:
						return result2;
					case 9:
						if (TrampolineHelpers._fixedStructCache.TryGetValue(size, out result2))
						{
							num2 = 8;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c == 0)
							{
								num2 = 6;
								continue;
							}
							continue;
						}
						else if (TrampolineHelpers._fixedStructAssembly != null)
						{
							num2 = 7;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2b24b0de55344c2b8aaf8116dbc4d16 == 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						}
						break;
					default:
						goto IL_1DB;
					}
					TrampolineHelpers._fixedStructAssembly = TrampolineHelpers.Vb4mKlRDlUEehnaTDjY(new AssemblyName(hIDAYxH6DWLHIthQgC.gSCeTtiku(-2007369155 ^ -1088941377 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4ab786fa8604298818cd412db8f702f)), AssemblyBuilderAccess.Run, PhcPCd9qZOZYbGJa4AI.UK199Z5kws);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_eea945ea6be345c0b18511ac11610b35 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_19C:
					TrampolineHelpers._fixedStructModuleBuilder = TrampolineHelpers.h4A10ERZWICWJPstdTh(TrampolineHelpers._fixedStructAssembly, hIDAYxH6DWLHIthQgC.gSCeTtiku(75745436 >> 5 ^ 929429190 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4ab786fa8604298818cd412db8f702f), B17Oqp9iWWgj6vslXHW.JbY9IMBSA4);
					num2 = 5;
					continue;
					IL_1DB:
					if (TrampolineHelpers._fixedStructModuleBuilder == null)
					{
						goto IL_19C;
					}
					num2 = 3;
				}
				IL_6F:
				object fixedStructModuleBuilder = TrampolineHelpers._fixedStructModuleBuilder;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 1);
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-97333341 ^ 600180503 ^ -1088265128 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ba3f6bd5a09c47868765e25f534dbf2a), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				defaultInterpolatedStringHandler.AppendFormatted<int>(size);
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, TrampolineHelpers.gFj3DCRouDgQv3ml4Rf(-479592382 ^ -2051232532 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ba3f6bd5a09c47868765e25f534dbf2a), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				value = aDGbeTAzy0PmbSxqfnH.i2IAUFsOOC(TrampolineHelpers.HrHbTyRfgMQmnxiaYUa(fixedStructModuleBuilder, JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL), TypeAttributes.ExplicitLayout, TrampolineHelpers.HfNqagRb2q49nfxG0uj(typeof(ValueType).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), size, t9JHgnImh61fOYQW7Ad.AHFIviU080), aDGbeTAzy0PmbSxqfnH.TmyUH6hw2Y);
				num = 4;
				continue;
				IL_21E:
				goto IL_6F;
			}
			return result2;
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x000167EC File Offset: 0x000149EC
		public unsafe static Type NativeType(this Type managedType)
		{
			int num = 13;
			uint num3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					Type type;
					switch (num2)
					{
					case 1:
						goto IL_C0;
					case 2:
						if (!TrampolineHelpers.VhESrpRwOR452uFvfaL(type, TrampolineHelpers.HfNqagRb2q49nfxG0uj(typeof(bool).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), dPsigOUwJdO4bwskNJ5.hvvUeCiIEf))
						{
							num2 = 5;
							continue;
						}
						goto IL_63;
					case 3:
						goto IL_1C1;
					case 4:
						goto IL_2AB;
					case 5:
						if (TrampolineHelpers.VhESrpRwOR452uFvfaL(type, TrampolineHelpers.HfNqagRb2q49nfxG0uj(typeof(string).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), dPsigOUwJdO4bwskNJ5.hvvUeCiIEf))
						{
							num2 = 3;
							continue;
						}
						goto IL_C0;
					case 6:
						if (!TrampolineHelpers.T62qqURQaFedGOmYLRw(jFQhjLIKKa8P97oX7HC.Dh0I5eBEfS))
						{
							num2 = 11;
							continue;
						}
						goto IL_138;
					case 7:
						if (TrampolineHelpers.VhESrpRwOR452uFvfaL(managedType, TrampolineHelpers.HfNqagRb2q49nfxG0uj(typeof(bool).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), dPsigOUwJdO4bwskNJ5.hvvUeCiIEf))
						{
							goto IL_185;
						}
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4e45528af4644e9b080e05d5ff6ef54 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 8:
						goto IL_185;
					case 9:
						goto IL_125;
					case 10:
						goto IL_264;
					case 11:
						num3 = 0U;
						num2 = 6;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_570d4e075bf443fcbaca8db32e007291 == 0)
						{
							num2 = 9;
							continue;
						}
						continue;
					case 12:
						type = TrampolineHelpers.MOJaawRdGLvsjBdJWP9(managedType, U8h2YU9SxVTdCTH73DU.h0m9gM44pd);
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_22a2950bfabc46ffa61eec0d3eacc4c9 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 13:
						if (TrampolineHelpers.Nx0RHVRPgRdReDXTFwg(managedType, HUtclRqOvktk8jFJw0c.zf1qXu2bX0))
						{
							num2 = 12;
							continue;
						}
						if (!TrampolineHelpers.Gw7UdGRshIrHfiHDe9g(managedType, byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(ValueType).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), IvRaRdITOToIFO9INUq.BY0IFsMlhd))
						{
							goto IL_138;
						}
						num2 = 2;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3ffead0113044f06b294bee6bd5e7a44 == 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					case 14:
						goto IL_63;
					case 15:
						goto IL_1E5;
					}
					goto Block_1;
					IL_C0:
					if (TrampolineHelpers.Gw7UdGRshIrHfiHDe9g(type, byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Il2CppObjectBase).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), IvRaRdITOToIFO9INUq.BY0IFsMlhd))
					{
						num2 = 4;
						continue;
					}
					return managedType;
					IL_138:
					if (TrampolineHelpers.VhESrpRwOR452uFvfaL(managedType, TrampolineHelpers.HfNqagRb2q49nfxG0uj(typeof(string).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), dPsigOUwJdO4bwskNJ5.hvvUeCiIEf))
					{
						goto IL_1E5;
					}
					num2 = 8;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40 != 0)
					{
						num2 = 10;
					}
				}
				IL_264:
				if (TrampolineHelpers.Gw7UdGRshIrHfiHDe9g(managedType, byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Il2CppObjectBase).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), IvRaRdITOToIFO9INUq.BY0IFsMlhd))
				{
					goto IL_1E5;
				}
				num = 7;
			}
			Block_1:
			goto IL_176;
			IL_63:
			return TrampolineHelpers.QbflgbReSSVWff5xg9H(TrampolineHelpers.HfNqagRb2q49nfxG0uj(typeof(byte).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), TDIMMMIBZjUjinX0eAh.ajWIj2M2Bq);
			IL_125:
			return TrampolineHelpers.ouipfXRyxPXiriPG54C(IL2CPP.il2cpp_class_value_size(TrampolineHelpers.x6X06AR23fh6GNu5eA3(managedType), ref num3));
			IL_176:
			return managedType;
			IL_185:
			return TrampolineHelpers.HfNqagRb2q49nfxG0uj(typeof(byte).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an);
			IL_1C1:
			goto IL_2AB;
			IL_1E5:
			return TrampolineHelpers.HfNqagRb2q49nfxG0uj(typeof(IntPtr).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an);
			IL_2AB:
			return TrampolineHelpers.HfNqagRb2q49nfxG0uj(typeof(IntPtr*).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00016AF4 File Offset: 0x00014CF4
		// Note: this type is marked as 'beforefieldinit'.
		static TrampolineHelpers()
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					TrampolineHelpers.n3hQKjRg39VSjZ4mN4G();
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_277c9fa6c1da46a98cc2f13643296b8f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					TrampolineHelpers.DG7GewRShbg057G6hYv();
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d03e4e4716154375bf56bf596fbd5780 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					TrampolineHelpers._fixedStructCache = new Dictionary<int, Type>();
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f0601de1a406461b9e99711ec5418371 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				TrampolineHelpers.YwqXK6RlFMcqA1KDPOV();
				num2 = 4;
			}
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00016BB8 File Offset: 0x00014DB8
		internal static object Vb4mKlRDlUEehnaTDjY(object A_0, AssemblyBuilderAccess A_1, object A_2)
		{
			return PhcPCd9qZOZYbGJa4AI.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00016BD4 File Offset: 0x00014DD4
		internal static object h4A10ERZWICWJPstdTh(object A_0, object A_1, object A_2)
		{
			return B17Oqp9iWWgj6vslXHW.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00016BF0 File Offset: 0x00014DF0
		internal static object gFj3DCRouDgQv3ml4Rf(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00016C04 File Offset: 0x00014E04
		internal static Type HfNqagRb2q49nfxG0uj(RuntimeTypeHandle A_0, object A_1)
		{
			return byRw0gA2NyqHkl03ii9.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00016C1C File Offset: 0x00014E1C
		internal static object HrHbTyRfgMQmnxiaYUa(object A_0, object A_1, TypeAttributes A_2, Type A_3, int A_4, object A_5)
		{
			return t9JHgnImh61fOYQW7Ad.i2IAUFsOOC(A_0, A_1, A_2, A_3, A_4, A_5);
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00016C44 File Offset: 0x00014E44
		internal static bool yX7ToiRW537Dy8xJyZb()
		{
			return TrampolineHelpers.eaIU6BRJ3jfdsPWfFj9 == null;
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00016C58 File Offset: 0x00014E58
		internal static TrampolineHelpers WWWKnDRrvOoCtpsLFKY()
		{
			return TrampolineHelpers.eaIU6BRJ3jfdsPWfFj9;
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00016C68 File Offset: 0x00014E68
		internal static bool Nx0RHVRPgRdReDXTFwg(object A_0, object A_1)
		{
			return HUtclRqOvktk8jFJw0c.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00016C80 File Offset: 0x00014E80
		internal static Type MOJaawRdGLvsjBdJWP9(object A_0, object A_1)
		{
			return U8h2YU9SxVTdCTH73DU.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00016C98 File Offset: 0x00014E98
		internal static bool VhESrpRwOR452uFvfaL(Type A_0, Type A_1, object A_2)
		{
			return dPsigOUwJdO4bwskNJ5.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00016CB4 File Offset: 0x00014EB4
		internal static Type QbflgbReSSVWff5xg9H(object A_0, object A_1)
		{
			return TDIMMMIBZjUjinX0eAh.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00016CCC File Offset: 0x00014ECC
		internal static bool Gw7UdGRshIrHfiHDe9g(object A_0, Type A_1, object A_2)
		{
			return IvRaRdITOToIFO9INUq.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00016CE8 File Offset: 0x00014EE8
		internal static bool T62qqURQaFedGOmYLRw(object A_0)
		{
			return jFQhjLIKKa8P97oX7HC.i2IAUFsOOC(A_0);
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00016CFC File Offset: 0x00014EFC
		internal static IntPtr x6X06AR23fh6GNu5eA3(Type type)
		{
			return Il2CppClassPointerStore.GetNativeClassPointer(type);
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00016D10 File Offset: 0x00014F10
		internal static Type ouipfXRyxPXiriPG54C(int size)
		{
			return TrampolineHelpers.GetFixedSizeStructType(size);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00016D24 File Offset: 0x00014F24
		internal static void DG7GewRShbg057G6hYv()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00016D34 File Offset: 0x00014F34
		internal static void n3hQKjRg39VSjZ4mN4G()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00016D44 File Offset: 0x00014F44
		internal static void YwqXK6RlFMcqA1KDPOV()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x0400099C RID: 2460
		private static AssemblyBuilder _fixedStructAssembly;

		// Token: 0x0400099D RID: 2461
		private static ModuleBuilder _fixedStructModuleBuilder;

		// Token: 0x0400099E RID: 2462
		private static readonly Dictionary<int, Type> _fixedStructCache;

		// Token: 0x0400099F RID: 2463
		internal static TrampolineHelpers eaIU6BRJ3jfdsPWfFj9;
	}
}
