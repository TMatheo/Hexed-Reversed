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
		// Token: 0x060001F3 RID: 499 RVA: 0x0000A7FC File Offset: 0x000089FC
		private static FieldInfo GetFieldInfoFromMethod(object method, object prefix)
		{
			int num = 1;
			int num2 = num;
			Module module;
			IEnumerator<ValueTuple<OpCode, long>> enumerator;
			for (;;)
			{
				switch (num2)
				{
				default:
					goto IL_2F;
				case 1:
				{
					object obj = InteropUtils.CyICnBxb9PGWCDPwiuc(method, DlUl7kilicUrc9TlEIS.kMsiVUcWKn);
					if (obj == null)
					{
						goto Block_2;
					}
					module = FW2TugiOGNGItR9gxvB.i2IAUFsOOC(BxCF5Pirv4081M3ZWUE.i2IAUFsOOC(aNXqaFUaF5FInd1YJEI.i2IAUFsOOC(method, aNXqaFUaF5FInd1YJEI.nN3UCtcdVR), BxCF5Pirv4081M3ZWUE.wrJiDQPPJd), FW2TugiOGNGItR9gxvB.fufiXV3yD1).Single<Module>();
					enumerator = MiniIlParser.Decode(mrECElimCgQhBECnJNB.i2IAUFsOOC(obj, mrECElimCgQhBECnJNB.JDbiv7621w)).GetEnumerator();
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_483eecf3691e4ef2b23b2d4cb2ca3d52 != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 2:
					goto IL_29D;
				}
			}
			IL_2F:
			try
			{
				FieldInfo result;
				for (;;)
				{
					IL_B6:
					if (InteropUtils.Mh0fpyxeXgvfpI4qoYU(enumerator, sMonWyi0m0eKdsb3oFd.G31iN30Web))
					{
						goto IL_133;
					}
					int num3 = 4;
					int num4 = num3;
					long item;
					OpCode item2;
					for (;;)
					{
						IL_43:
						FieldInfo fieldInfo;
						Type type;
						switch (num4)
						{
						case 0:
							goto IL_18E;
						case 1:
							goto IL_8C;
						case 2:
							goto IL_133;
						case 3:
							break;
						case 4:
							goto IL_211;
						case 5:
							goto IL_B6;
						case 6:
							if (!InteropUtils.El8fyfxwOMEyE1ZVP9Y(el3Dwo9OYrba9URt3tt.i2IAUFsOOC(fieldInfo, el3Dwo9OYrba9URt3tt.qs29XcBOk2), prefix, z4BRwT9Ki3wnMXvZB09.EZw95Edmkf))
							{
								goto IL_B6;
							}
							num4 = 10;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9a3e85e731764e36a5b07f4e692becd8 == 0)
							{
								num4 = 1;
								continue;
							}
							continue;
						case 7:
							if (fieldInfo == null)
							{
								goto IL_1BD;
							}
							num4 = 7;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_99cea5f9c4c245c2a5f184ab2e57fafc == 0)
							{
								num4 = 11;
								continue;
							}
							continue;
						case 8:
							goto IL_1BD;
						case 9:
							goto IL_7D;
						case 10:
							result = fieldInfo;
							num4 = 1;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_db312e48eee84539b805fee2f73a8cde == 0)
							{
								num4 = 1;
								continue;
							}
							continue;
						case 11:
							type = InteropUtils.ThOGJNxPX6BUjhZ0C50(fieldInfo, MxKuwSiKGgSjAmlPfBS.yd0i5PmBRG);
							goto IL_1D4;
						default:
							goto IL_18E;
						}
						IL_9B:
						fieldInfo = rlk80TiTmVDhRW1pePl.i2IAUFsOOC(module, (int)item, rlk80TiTmVDhRW1pePl.guqiFpiIqA);
						num4 = 7;
						continue;
						IL_1D4:
						if (Q57NvyUKOvY5KovuDBT.i2IAUFsOOC(type, InteropUtils.ylRxBaxdqDJq5hteyAI(typeof(IntPtr).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), Q57NvyUKOvY5KovuDBT.G0AU5uNCnx))
						{
							break;
						}
						num4 = 6;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_dbbda98ba6574101bc623ad559f7b5a3 == 0)
						{
							num4 = 0;
							continue;
						}
						continue;
						IL_1BD:
						type = null;
						goto IL_1D4;
						IL_18E:
						if (!InteropUtils.vQcbYJxfPUxG3L8U1BF(item2, OpCodes.Ldsfld, fFnvy2iB4BF7Uq6kYkL.HwMij41wGc))
						{
							goto IL_9B;
						}
						num4 = 9;
					}
					IL_7D:
					continue;
					IL_133:
					ValueTuple<OpCode, long> valueTuple = enumerator.Current;
					item2 = valueTuple.Item1;
					item = valueTuple.Item2;
					num4 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2210d7ca22c24335b32d80ca3ef84b8e == 0)
					{
						num4 = 0;
						goto IL_43;
					}
					goto IL_43;
				}
				IL_8C:
				return result;
				IL_211:;
			}
			finally
			{
				if (enumerator != null)
				{
					int num5 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc == 0)
					{
						num5 = 0;
					}
					for (;;)
					{
						switch (num5)
						{
						default:
							DOGJJXiuWsS2u63HZGH.i2IAUFsOOC(enumerator, DOGJJXiuWsS2u63HZGH.wb2iEctcbL);
							num5 = 1;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c2ad52141772446383547acade021f9a == 0)
							{
								num5 = 0;
							}
							break;
						case 1:
							goto IL_27D;
						}
					}
				}
				IL_27D:;
			}
			IL_29D:
			return null;
			Block_2:
			throw new ArgumentException(hIDAYxH6DWLHIthQgC.gSCeTtiku(443897056 << 2 ^ 1527416017 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9cbee6d56f49422699718938ff979567));
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000AB5C File Offset: 0x00008D5C
		public static T Il2CppObjectPtrToIl2CppObject<T>(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				throw new NullReferenceException(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1879499907 ^ -877345556 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5d181dabf1ed42eca63023d24d927754));
			}
			return (T)((object)xN2amKinbB5xSy6RPKW.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), BindingFlags.Instance | BindingFlags.Public, null, new Type[]
			{
				byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(IntPtr).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an)
			}, new ParameterModifier[0], xN2amKinbB5xSy6RPKW.gSRi3oFyC8).Invoke(new object[]
			{
				ptr
			}));
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		public static FieldInfo GetIl2CppMethodInfoPointerFieldForGeneratedMethod(MethodBase method)
		{
			return InteropUtils.GetFieldInfoFromMethod(method, InteropUtils.SoojEXxsInPRhOJ8QIa(-1096198476 - 1277016560 ^ 1953600851 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c));
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000AC20 File Offset: 0x00008E20
		public static FieldInfo GetIl2CppFieldInfoPointerFieldForGeneratedFieldAccessor(MethodBase method)
		{
			return InteropUtils.mulj7AxQ0S6Jl244weR(method, hIDAYxH6DWLHIthQgC.gSCeTtiku(155266333 ^ 1423850483 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8155e7a9a9bd4894b741e1951a0eace6));
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000AC4C File Offset: 0x00008E4C
		// Note: this type is marked as 'beforefieldinit'.
		static InteropUtils()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000AC5C File Offset: 0x00008E5C
		internal static object CyICnBxb9PGWCDPwiuc(object A_0, object A_1)
		{
			return DlUl7kilicUrc9TlEIS.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000AC74 File Offset: 0x00008E74
		internal static bool vQcbYJxfPUxG3L8U1BF(OpCode A_0, OpCode A_1, object A_2)
		{
			return fFnvy2iB4BF7Uq6kYkL.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000AC90 File Offset: 0x00008E90
		internal static Type ThOGJNxPX6BUjhZ0C50(object A_0, object A_1)
		{
			return MxKuwSiKGgSjAmlPfBS.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000ACA8 File Offset: 0x00008EA8
		internal static Type ylRxBaxdqDJq5hteyAI(RuntimeTypeHandle A_0, object A_1)
		{
			return byRw0gA2NyqHkl03ii9.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000ACC0 File Offset: 0x00008EC0
		internal static bool El8fyfxwOMEyE1ZVP9Y(object A_0, object A_1, object A_2)
		{
			return z4BRwT9Ki3wnMXvZB09.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000ACDC File Offset: 0x00008EDC
		internal static bool Mh0fpyxeXgvfpI4qoYU(object A_0, object A_1)
		{
			return sMonWyi0m0eKdsb3oFd.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000ACF4 File Offset: 0x00008EF4
		internal static bool Fo2e1PxZ7cnBdiAg4qO()
		{
			return InteropUtils.JMmVBBxDkZ5WacxJIHH == null;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000AD08 File Offset: 0x00008F08
		internal static InteropUtils yn0EBjxofAdCEU2yP3r()
		{
			return InteropUtils.JMmVBBxDkZ5WacxJIHH;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000AD18 File Offset: 0x00008F18
		internal static object SoojEXxsInPRhOJ8QIa(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000AD2C File Offset: 0x00008F2C
		internal static object mulj7AxQ0S6Jl244weR(object A_0, object A_1)
		{
			return InteropUtils.GetFieldInfoFromMethod(A_0, A_1);
		}

		// Token: 0x0400002B RID: 43
		private static InteropUtils JMmVBBxDkZ5WacxJIHH;
	}
}
