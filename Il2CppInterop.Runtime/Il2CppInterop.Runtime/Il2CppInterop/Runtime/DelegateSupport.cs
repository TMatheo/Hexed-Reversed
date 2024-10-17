using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppInterop.Runtime.Injection;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime
{
	// Token: 0x02000004 RID: 4
	public static class DelegateSupport
	{
		// Token: 0x06000048 RID: 72 RVA: 0x000033A4 File Offset: 0x000015A4
		public static Type GetOrCreateDelegateType(DelegateSupport.MethodSignature signature, MethodInfo managedMethod)
		{
			ConcurrentDictionary<DelegateSupport.MethodSignature, Type> concurrentDictionary = DelegateSupport.ourDelegateTypes;
			Func<DelegateSupport.MethodSignature, MethodInfo, Type> valueFactory;
			if ((valueFactory = DelegateSupport.<>c.<>9__5_0) == null)
			{
				valueFactory = (DelegateSupport.<>c.<>9__5_0 = (([Nullable(1)] DelegateSupport.MethodSignature signature, MethodInfo managedMethodInner) => DelegateSupport.CreateDelegateType(managedMethodInner, signature.HasThis, signature.ConstructedFromNative)));
			}
			return concurrentDictionary.GetOrAdd<MethodInfo>(signature2, valueFactory, managedMethod);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000033E0 File Offset: 0x000015E0
		private unsafe static Type CreateDelegateType(object managedMethodInner, bool addIntPtrForThis, bool addNamingDisambig)
		{
			int num = 7;
			TypeBuilder typeBuilder;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					int num3;
					ParameterInfo[] array2;
					int num4;
					Type[] array;
					switch (num2)
					{
					case 0:
						goto IL_158;
					case 1:
						num3 = 0;
						num2 = 3;
						continue;
					case 2:
						DelegateSupport.rpUukhCdxMEMeodHwUF(DelegateSupport.bDm9rBCPWWrmrBD9Pjh(typeBuilder, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName, CallingConventions.HasThis, new Type[]
						{
							DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(object).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an),
							DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(IntPtr).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an)
						}, d5rqpnAma75otQhcJbn.g9EAvYWTt9), MethodImplAttributes.CodeTypeMask, Od6dsxABmuKKQmVjDsf.OFoAjXT0m8);
						num2 = 8;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5afe19cf44424af2ad9aea85585a9cc2 == 0)
						{
							num2 = 16;
							continue;
						}
						continue;
					case 3:
						goto IL_202;
					case 4:
						array = new Type[array2.Length + 1 + num4];
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c504ab11ece64b14b01df2d4c88e6e49 != 0)
						{
							num2 = 11;
							continue;
						}
						continue;
					case 5:
						DelegateSupport.QFNoaCC2S7pEnjkExpp(DelegateSupport.cl70KrCQlMsGDxtLJei(typeBuilder, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1186506589 ^ -36061773 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_282cf292112a4cf49ec1b8b2e2e7602a), MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, CallingConventions.HasThis, DelegateSupport.xrDYPOCelbjWZx2TQLx(DelegateSupport.VQGwimCsOYUf18xYKUs(managedMethodInner, jPM26DAnQfHunyInIhU.xcUA3EoFoP)), new Type[]
						{
							DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(IAsyncResult).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an)
						}, rK10McA1W7rRDddaGkF.epWAMOvIB2), MethodImplAttributes.CodeTypeMask, MyCfRnAp32SBLkfxPeR.s96A4sqSvv);
						num2 = 15;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e0435cb0909b493e882d051900e9ae38 != 0)
						{
							num2 = 9;
							continue;
						}
						continue;
					case 6:
						goto IL_2D3;
					case 7:
						typeBuilder = YhrOShASOt3RVNYfWyr.i2IAUFsOOC(DelegateSupport.ModuleBuilder, DelegateSupport.pnLVCuCZ2vNx0grdATG(DelegateSupport.jT6PINCDdd16U5NQ0J0(189284862 - -678740789 ^ 1529280035 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_0783948440564d328b8e79831447d3f6), DelegateSupport.ExtractSignature(managedMethodInner), (!addIntPtrForThis) ? "" : DelegateSupport.jT6PINCDdd16U5NQ0J0(~1015743027 ^ -119525435 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c733963b5aa3462f9be5a2d711359fa7), (!addNamingDisambig) ? "" : DelegateSupport.jT6PINCDdd16U5NQ0J0(~1887414127 ^ -1231760751 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bc244a0192c343599cd1cf83671e02ab), SjRANlAsQ8j3KPpZL2p.xmXAQkOq8l), TypeAttributes.Public | TypeAttributes.Sealed, DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(MulticastDelegate).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), YhrOShASOt3RVNYfWyr.affAgQEBBx);
						num2 = 6;
						continue;
					case 8:
						DelegateSupport.QFNoaCC2S7pEnjkExpp(DelegateSupport.cl70KrCQlMsGDxtLJei(typeBuilder, DelegateSupport.jT6PINCDdd16U5NQ0J0(-763514581 ^ -2137918181 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_dbbda98ba6574101bc623ad559f7b5a3), MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, CallingConventions.HasThis, DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(IAsyncResult).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), array.Concat(new Type[]
						{
							DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(AsyncCallback).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an),
							DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(object).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an)
						}).ToArray<Type>(), rK10McA1W7rRDddaGkF.epWAMOvIB2), MethodImplAttributes.CodeTypeMask, MyCfRnAp32SBLkfxPeR.s96A4sqSvv);
						num2 = 5;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_0e76a731caf34f7495b20ae26aa97571 != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 9:
						goto IL_202;
					case 10:
						array2 = sLG6EQATwSiLRpKGREk.i2IAUFsOOC(managedMethodInner, sLG6EQATwSiLRpKGREk.VZpAFVSObI);
						num2 = 4;
						continue;
					case 11:
						if (addIntPtrForThis)
						{
							num2 = 14;
							continue;
						}
						goto IL_1A6;
					case 12:
						goto IL_16B;
					case 13:
						num3++;
						num2 = 8;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_39f2b5d6802b4ad087933b982faeb79d == 0)
						{
							num2 = 9;
							continue;
						}
						continue;
					case 14:
						array[0] = DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(IntPtr).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an);
						num2 = 17;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fcdd30171ceb4eb7a5570cbbc4f6aec1 == 0)
						{
							num2 = 8;
							continue;
						}
						continue;
					case 15:
						goto IL_446;
					case 16:
						num4 = ((addIntPtrForThis > false) ? 1 : 0);
						num2 = 10;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ac98984015b94d6a931f8affda832ec9 != 0)
						{
							num2 = 8;
							continue;
						}
						continue;
					case 17:
						goto IL_1A6;
					case 18:
						break;
					default:
						goto IL_158;
					}
					IL_7C:
					MyCfRnAp32SBLkfxPeR.i2IAUFsOOC(DelegateSupport.cl70KrCQlMsGDxtLJei(typeBuilder, hIDAYxH6DWLHIthQgC.gSCeTtiku(~-726396172 ^ 483187018 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c474f43efb4d4f17b5c0c1bf3216ef4d), MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, CallingConventions.HasThis, DelegateSupport.VQGwimCsOYUf18xYKUs(managedMethodInner, jPM26DAnQfHunyInIhU.xcUA3EoFoP).NativeType(), array, rK10McA1W7rRDddaGkF.epWAMOvIB2), MethodImplAttributes.CodeTypeMask, MyCfRnAp32SBLkfxPeR.s96A4sqSvv);
					num2 = 8;
					continue;
					IL_202:
					if (num3 >= array2.Length)
					{
						goto IL_7C;
					}
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a8737fecb12449d7ad23f5080d76d2f8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_16B:
					array[num3 + num4] = DelegateSupport.xrDYPOCelbjWZx2TQLx(DelegateSupport.nMdxw1Cwo9eivBuCZFb(array2[num3], qc2ECMAKgYlQ7Q4UDSY.YttA5ifGGI));
					num2 = 13;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_39f2b5d6802b4ad087933b982faeb79d != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
					IL_158:
					goto IL_16B;
					IL_1A6:
					array[array.Length - 1] = DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(Il2CppMethodInfo*).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an);
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f72daac7e98440569eaab57fbb9f7bf2 == 0)
					{
						num2 = 1;
					}
				}
				IL_2D3:
				DelegateSupport.Ai14DSCf2p0CRwT1096(typeBuilder, new CustomAttributeBuilder(DelegateSupport.TRqkPrCbthxTF2jsGtx(DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(UnmanagedFunctionPointerAttribute).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), new Type[]
				{
					DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(CallingConvention).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an)
				}, b27ekHAlO1XXce9pRo0.EtlAV2R4Yl), new object[]
				{
					CallingConvention.Cdecl
				}), f4MxL4AOJOmnsnGxg4f.OnjAXeogHF);
				num = 2;
			}
			IL_446:
			return DelegateSupport.URMY19CygDUypEtjsE9(typeBuilder, aDGbeTAzy0PmbSxqfnH.TmyUH6hw2Y);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003904 File Offset: 0x00001B04
		private static string ExtractSignature(object methodInfo)
		{
			int num = 1;
			int num2 = num;
			StringBuilder stringBuilder;
			for (;;)
			{
				int num3;
				ParameterInfo parameterInfo;
				switch (num2)
				{
				default:
					DelegateSupport.A3rP2vCSPwIJNwJwi2A(stringBuilder, XbWY87UAp2s3iIUpBiV.i2IAUFsOOC(DelegateSupport.VQGwimCsOYUf18xYKUs(methodInfo, jPM26DAnQfHunyInIhU.xcUA3EoFoP), XbWY87UAp2s3iIUpBiV.tomUUWdyuW), ryYXxRUq8BsbY0RUmr6.RZIU9CNSIJ);
					num2 = 8;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_49c6a53db2614593b5468905d8aba004 != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 1:
					stringBuilder = new StringBuilder();
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_0783948440564d328b8e79831447d3f6 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					num3 = 0;
					num2 = 4;
					continue;
				case 3:
					DelegateSupport.A3rP2vCSPwIJNwJwi2A(stringBuilder, DelegateSupport.m3X3JjCOEQY0Rjlsxr7(DelegateSupport.Pn47GoCVwYJ0h6rnQfB(methodInfo, aNXqaFUaF5FInd1YJEI.nN3UCtcdVR), XbWY87UAp2s3iIUpBiV.tomUUWdyuW), ryYXxRUq8BsbY0RUmr6.RZIU9CNSIJ);
					num2 = 10;
					continue;
				case 4:
					break;
				case 5:
					goto IL_1DD;
				case 6:
					DelegateSupport.Leur5jClCnvmMKygZk0(stringBuilder, '_', H2StJeUGVkry79EgdEo.je0UY6eoux);
					num2 = 12;
					continue;
				case 7:
					goto IL_1EE;
				case 8:
					if (DelegateSupport.RNkfCDCg87mU2B8G4bP(methodInfo, a4R1rnUiI6Z0H9xNlx5.mRbUIZp1UB))
					{
						num2 = 9;
						continue;
					}
					goto IL_1EE;
				case 9:
					goto IL_1B1;
				case 10:
					goto IL_1B1;
				case 11:
					goto IL_CA;
				case 12:
					DelegateSupport.A3rP2vCSPwIJNwJwi2A(stringBuilder, DelegateSupport.m3X3JjCOEQY0Rjlsxr7(DelegateSupport.nMdxw1Cwo9eivBuCZFb(parameterInfo, qc2ECMAKgYlQ7Q4UDSY.YttA5ifGGI), XbWY87UAp2s3iIUpBiV.tomUUWdyuW), ryYXxRUq8BsbY0RUmr6.RZIU9CNSIJ);
					num2 = 14;
					continue;
				case 13:
					break;
				case 14:
					num3++;
					num2 = 4;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_eea945ea6be345c0b18511ac11610b35 != 0)
					{
						num2 = 13;
						continue;
					}
					continue;
				case 15:
					goto IL_1DD;
				}
				ParameterInfo[] array;
				if (num3 >= array.Length)
				{
					break;
				}
				num2 = 5;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8155e7a9a9bd4894b741e1951a0eace6 == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_1B1:
				array = DelegateSupport.do0PgRCX4YleNdbVpWL(methodInfo, sLG6EQATwSiLRpKGREk.VZpAFVSObI);
				num2 = 2;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c1d51581d05f41579ee6e476d9be288e == 0)
				{
					num2 = 2;
					continue;
				}
				continue;
				IL_1DD:
				parameterInfo = array[num3];
				num2 = 6;
				continue;
				IL_1EE:
				DelegateSupport.Leur5jClCnvmMKygZk0(stringBuilder, '_', H2StJeUGVkry79EgdEo.je0UY6eoux);
				num2 = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2b24b0de55344c2b8aaf8116dbc4d16 != 0)
				{
					num2 = 3;
				}
			}
			IL_CA:
			return DelegateSupport.zNuhI4CmdpfO1SRe8g9(stringBuilder, QW5rQ4UtSMItWDAsJG4.E5gUxtJVkb);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003B80 File Offset: 0x00001D80
		private static Delegate GetOrCreateNativeToManagedTrampoline(object signature, object nativeMethod, object managedMethod)
		{
			ConcurrentDictionary<MethodInfo, Delegate> nativeToManagedTrampolines = DelegateSupport.NativeToManagedTrampolines;
			Func<MethodInfo, ValueTuple<MethodInfo, MethodInfo, DelegateSupport.MethodSignature>, Delegate> valueFactory;
			if ((valueFactory = DelegateSupport.<>c.<>9__8_0) == null)
			{
				valueFactory = (DelegateSupport.<>c.<>9__8_0 = (([Nullable(1)] MethodInfo _, [TupleElementNames(new string[]
				{
					"nativeMethod",
					"managedMethod",
					"signature"
				})] ValueTuple<MethodInfo, MethodInfo, DelegateSupport.MethodSignature> tuple) => DelegateSupport.GenerateNativeToManagedTrampoline(tuple.Item1, tuple.Item2, tuple.Item3)));
			}
			return nativeToManagedTrampolines.GetOrAdd<ValueTuple<MethodInfo, MethodInfo, DelegateSupport.MethodSignature>>(managedMethod, valueFactory, new ValueTuple<MethodInfo, MethodInfo, DelegateSupport.MethodSignature>(nativeMethod, managedMethod, signature));
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003BD0 File Offset: 0x00001DD0
		public static object GetRef(IntPtr pointer)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
				{
					DelegateSupport.Il2CppToMonoDelegateReference result;
					if (DelegateSupport.NativeToManagedTrampoline.TryGetValue(pointer, out result))
					{
						return result;
					}
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_806dbdb7f5194c2fa0c07a915df13fc8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				case 2:
				{
					DelegateSupport.Il2CppToMonoDelegateReference result;
					return result;
				}
				case 3:
					goto IL_33;
				}
				DelegateSupport.TlbAQ9CvHg3yjMJjaEM(DelegateSupport.jT6PINCDdd16U5NQ0J0(-563509933 + 1953254144 ^ 98600551 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2210d7ca22c24335b32d80ca3ef84b8e));
				num2 = 2;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2b9d7065e34e71a0069eb107f69f59 == 0)
				{
					num2 = 3;
				}
			}
			IL_33:
			return IntPtr.Zero;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003CB8 File Offset: 0x00001EB8
		private unsafe static Delegate GenerateNativeToManagedTrampoline(object nativeMethod, object managedMethod, object signature)
		{
			int num = 42;
			DynamicMethod dynamicMethod;
			for (;;)
			{
				int num2 = num;
				ILGenerator ilgenerator;
				Label label4;
				for (;;)
				{
					int num3;
					ParameterInfo[] array2;
					Type[] array;
					Type type;
					LocalBuilder localBuilder;
					Type type2;
					int num4;
					LocalBuilder localBuilder2;
					switch (num2)
					{
					default:
						DelegateSupport.bcFjuCtGOruai8njV4g(ilgenerator, OpCodes.Ldstr, DelegateSupport.jT6PINCDdd16U5NQ0J0(1668275920 ^ 1103322606 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc), juWq3eUzrSmJee3Fw6H.FKWqH4eps3);
						num2 = 72;
						continue;
					case 1:
						DelegateSupport.sYaI8CCKOYucZgyOn2l(ilgenerator, OpCodes.Nop, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
						num2 = 17;
						continue;
					case 2:
					{
						Label label;
						DelegateSupport.gAkfAECzkdxy5mTQxXJ(ilgenerator, label, PW0V5GUmBLqSWP66Z4c.tRxUvL583e);
						num2 = 40;
						continue;
					}
					case 3:
						DelegateSupport.cfjeB1CnS3d10BPxgcv(ilgenerator, OpCodes.Ldarg, num3 + 1, i8SdLhUP0eAhNFuWLMo.V7MUd40eDf);
						num2 = 47;
						continue;
					case 4:
						goto IL_220;
					case 5:
						DelegateSupport.DcHrGWtCrurSxs5sjAa(ilgenerator, KRdvyeqiNjTgc2IU7fe.bovqIqLNuI);
						num2 = 30;
						continue;
					case 6:
						UYciy8UrGRereOdGLqM.i2IAUFsOOC(ilgenerator, OpCodes.Castclass, DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(DelegateSupport.Il2CppToMonoDelegateReference).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), UYciy8UrGRereOdGLqM.t1mUDO5w7Y);
						num2 = 43;
						continue;
					case 7:
						DelegateSupport.sYaI8CCKOYucZgyOn2l(ilgenerator, OpCodes.Ldc_I4_0, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
						num2 = 39;
						continue;
					case 8:
					{
						Label label2 = T9hscQU2PnRQmsgFCNw.i2IAUFsOOC(ilgenerator, T9hscQU2PnRQmsgFCNw.EAjUybZf3t);
						num2 = 23;
						continue;
					}
					case 9:
						goto IL_8DE;
					case 10:
						goto IL_6A5;
					case 11:
						zlhoVEUJgYHXwr3BCPL.i2IAUFsOOC(ilgenerator, OpCodes.Call, DelegateSupport.kfgAk4C3ZUZ15VlIX9t(DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(IL2CPP).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), DelegateSupport.jT6PINCDdd16U5NQ0J0(942519982 ^ 62481945 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c733963b5aa3462f9be5a2d711359fa7), X127Q0UR3CERXOhenKY.Bo6UkBGZYT), zlhoVEUJgYHXwr3BCPL.krwUWtuUrb);
						num2 = 74;
						continue;
					case 12:
						i8SdLhUP0eAhNFuWLMo.i2IAUFsOOC(ilgenerator, OpCodes.Ldarg, num3 + 1, i8SdLhUP0eAhNFuWLMo.V7MUd40eDf);
						num2 = 24;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4e45528af4644e9b080e05d5ff6ef54 == 0)
						{
							num2 = 49;
							continue;
						}
						continue;
					case 13:
						array = new Type[array2.Length + 1 + 1];
						num2 = 14;
						continue;
					case 14:
						array[0] = DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(IntPtr).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an);
						num2 = 48;
						continue;
					case 15:
						goto IL_2A0;
					case 16:
						if (Q57NvyUKOvY5KovuDBT.i2IAUFsOOC(type, DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(void).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), Q57NvyUKOvY5KovuDBT.G0AU5uNCnx))
						{
							num2 = 51;
							continue;
						}
						goto IL_8DE;
					case 17:
						DelegateSupport.sYaI8CCKOYucZgyOn2l(ilgenerator, OpCodes.Nop, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
						num2 = 29;
						continue;
					case 18:
						goto IL_AF5;
					case 19:
					{
						Label label3 = DelegateSupport.TfFWbuCMxgqLtjauaUP(ilgenerator, T9hscQU2PnRQmsgFCNw.EAjUybZf3t);
						num2 = 3;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc != 0)
						{
							num2 = 32;
							continue;
						}
						continue;
					}
					case 20:
						DelegateSupport.JHHcbhtIDkRWInYeNUX(ilgenerator, DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(Exception).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), i2gLiDUpAgDrhYbEGTX.GhdU4PP37J);
						num2 = 64;
						continue;
					case 21:
						goto IL_3E2;
					case 22:
						DelegateSupport.UXYvX4CF36e0LTUOBGm(ilgenerator, xrSf5WUcU7r8AC9ojJq.OpMU6WDdXV);
						num2 = 10;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_75b92ac812f348208c578c3de71e2d57 == 0)
						{
							num2 = 69;
							continue;
						}
						continue;
					case 23:
						label4 = DelegateSupport.TfFWbuCMxgqLtjauaUP(ilgenerator, T9hscQU2PnRQmsgFCNw.EAjUybZf3t);
						num2 = 70;
						continue;
					case 24:
						goto IL_AF5;
					case 25:
					{
						Label label3;
						PW0V5GUmBLqSWP66Z4c.i2IAUFsOOC(ilgenerator, label3, PW0V5GUmBLqSWP66Z4c.tRxUvL583e);
						num2 = 68;
						continue;
					}
					case 26:
						zlhoVEUJgYHXwr3BCPL.i2IAUFsOOC(ilgenerator, OpCodes.Call, X127Q0UR3CERXOhenKY.i2IAUFsOOC(DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(DelegateSupport).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), hIDAYxH6DWLHIthQgC.gSCeTtiku(-170966476 ^ -832859829 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c733963b5aa3462f9be5a2d711359fa7), X127Q0UR3CERXOhenKY.Bo6UkBGZYT), zlhoVEUJgYHXwr3BCPL.krwUWtuUrb);
						num2 = 6;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9c5de7c7e06f4557898ef7a8362c30ee != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 27:
						goto IL_3E2;
					case 28:
					{
						Label label;
						DelegateSupport.FK25nCCpNPpHDoyZfsm(ilgenerator, OpCodes.Br, label, V5jKQ2USYTLU6Q7ybPM.QwCUgZutyf);
						num2 = 12;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_944294969d634011bf30e3f4f506a31e != 0)
						{
							num2 = 25;
							continue;
						}
						continue;
					}
					case 29:
						DelegateSupport.sYaI8CCKOYucZgyOn2l(ilgenerator, OpCodes.Ldarg_0, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
						num2 = 26;
						continue;
					case 30:
						if (localBuilder != null)
						{
							goto IL_26E;
						}
						num2 = 3;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6b13daaa4cb24d0bac4f6e72da052370 == 0)
						{
							num2 = 18;
							continue;
						}
						continue;
					case 31:
						ilgenerator = DelegateSupport.lSe3weCT0y0I91Ms7DC(dynamicMethod, LN74hFUuuPeOAyrLO2m.mWbUEkxEGw);
						num2 = 22;
						continue;
					case 32:
					{
						Label label = T9hscQU2PnRQmsgFCNw.i2IAUFsOOC(ilgenerator, T9hscQU2PnRQmsgFCNw.EAjUybZf3t);
						num2 = 73;
						continue;
					}
					case 33:
						DelegateSupport.pMsh2LtH3OCmSV5QgwL(ilgenerator, OpCodes.Call, DelegateSupport.wKadictYPQKajx8I9KL(DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(string).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), hIDAYxH6DWLHIthQgC.gSCeTtiku(-1096198476 - 1277016560 ^ 378384764 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_636316cf576545aba2f7d326dd7e140b), new Type[]
						{
							DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(string).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an),
							DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(string).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an)
						}, KXmbngqAYb7452NDmoE.p36qUCyLZa), zlhoVEUJgYHXwr3BCPL.krwUWtuUrb);
						num2 = 50;
						continue;
					case 34:
						if (!DelegateSupport.pPZgBRtAJ3TC8NUc10N(type, byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(string).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), dPsigOUwJdO4bwskNJ5.hvvUeCiIEf))
						{
							num2 = 65;
							continue;
						}
						goto IL_2A0;
					case 35:
						DelegateSupport.pMsh2LtH3OCmSV5QgwL(ilgenerator, OpCodes.Call, managedMethod, zlhoVEUJgYHXwr3BCPL.krwUWtuUrb);
						num2 = 6;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3af7919884e4482186590a3e6e04f119 == 0)
						{
							num2 = 34;
							continue;
						}
						continue;
					case 36:
						goto IL_66C;
					case 37:
					{
						Label label2;
						DelegateSupport.gAkfAECzkdxy5mTQxXJ(ilgenerator, label2, PW0V5GUmBLqSWP66Z4c.tRxUvL583e);
						num2 = 10;
						continue;
					}
					case 38:
						DelegateSupport.gAkfAECzkdxy5mTQxXJ(ilgenerator, label4, PW0V5GUmBLqSWP66Z4c.tRxUvL583e);
						num2 = 15;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5f6b46e73a464a41b29ca79bf0f3b8f9 != 0)
						{
							num2 = 21;
							continue;
						}
						continue;
					case 39:
						DelegateSupport.sYaI8CCKOYucZgyOn2l(ilgenerator, OpCodes.Conv_I, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
						num2 = 38;
						continue;
					case 40:
						break;
					case 41:
						array2 = DelegateSupport.do0PgRCX4YleNdbVpWL(managedMethod, sLG6EQATwSiLRpKGREk.VZpAFVSObI);
						num2 = 57;
						continue;
					case 42:
						type = DelegateSupport.xrDYPOCelbjWZx2TQLx(DelegateSupport.VQGwimCsOYUf18xYKUs(managedMethod, jPM26DAnQfHunyInIhU.xcUA3EoFoP));
						num2 = 41;
						continue;
					case 43:
						DelegateSupport.X13HYtC5GrggVq8SyNL(ilgenerator, OpCodes.Ldfld, gCZgqYUZrO6iDUQkwRK.i2IAUFsOOC(DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(DelegateSupport.Il2CppToMonoDelegateReference).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), DelegateSupport.jT6PINCDdd16U5NQ0J0(-1235690808 ^ -1331503299 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c), gCZgqYUZrO6iDUQkwRK.iVLUoyePO3), UjCL81UbRoyk5Lr84pU.jA3UfMc80p);
						num2 = 46;
						continue;
					case 44:
						goto IL_26E;
					case 45:
						goto IL_969;
					case 46:
						num3 = 0;
						num2 = 36;
						continue;
					case 47:
						if (!dPsigOUwJdO4bwskNJ5.i2IAUFsOOC(type2, DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(string).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), dPsigOUwJdO4bwskNJ5.hvvUeCiIEf))
						{
							goto IL_9F3;
						}
						num2 = 11;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c2ad52141772446383547acade021f9a == 0)
						{
							num2 = 9;
							continue;
						}
						continue;
					case 48:
						array[array2.Length + 1] = DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(Il2CppMethodInfo*).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an);
						num2 = 71;
						continue;
					case 49:
						DelegateSupport.V7Y9SdC4rr6W8bIZgbJ(ilgenerator, OpCodes.Newobj, zD3ZnqUlrIU4LLl6GPl.i2IAUFsOOC(type2, new Type[]
						{
							byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(IntPtr).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an)
						}, zD3ZnqUlrIU4LLl6GPl.txAUV634FV), N3j9MUUOGeO9qTBVBp1.MygUXj5P6N);
						num2 = 28;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2b24b0de55344c2b8aaf8116dbc4d16 == 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 50:
						DelegateSupport.pMsh2LtH3OCmSV5QgwL(ilgenerator, OpCodes.Call, DelegateSupport.HP0CO9taSGIbAlJTCZa(DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(DelegateSupport).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), DelegateSupport.jT6PINCDdd16U5NQ0J0(51062111 ^ 877320695 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4ab786fa8604298818cd412db8f702f), BindingFlags.Static | BindingFlags.NonPublic, LSc0e0qqd5ti0ClnMPQ.J4tq9V02uE), zlhoVEUJgYHXwr3BCPL.krwUWtuUrb);
						num2 = 3;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c32cfeb41f7a43999be3bae16a94ad02 == 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 51:
						localBuilder = KQ408IUnj4MeYY1d6lA.i2IAUFsOOC(ilgenerator, type, KQ408IUnj4MeYY1d6lA.lnnU3S4n1c);
						num2 = 3;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_667bd9633593433784ebdd2b3fdc8daf == 0)
						{
							num2 = 61;
							continue;
						}
						continue;
					case 52:
						goto IL_77C;
					case 53:
						DelegateSupport.pMsh2LtH3OCmSV5QgwL(ilgenerator, OpCodes.Call, DelegateSupport.YXBFCitq0NbCL8jkicb(DelegateSupport.xVItB1tUS34AETuijQe(DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(Il2CppObjectBase).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), DelegateSupport.jT6PINCDdd16U5NQ0J0(51062111 ^ 1586773003 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8155e7a9a9bd4894b741e1951a0eace6), abNfQOUBX9HpKxMrtL7.IONUjFcnek), xHHh6jUT0eH9Q7OhVRy.IiKUF1u5XQ), zlhoVEUJgYHXwr3BCPL.krwUWtuUrb);
						num2 = 52;
						continue;
					case 54:
						num4++;
						num2 = 58;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a36e967c0f044e9ebf523536bdec8e28 == 0)
						{
							num2 = 54;
							continue;
						}
						continue;
					case 55:
					{
						Label label2;
						DelegateSupport.FK25nCCpNPpHDoyZfsm(ilgenerator, OpCodes.Brfalse, label2, V5jKQ2USYTLU6Q7ybPM.QwCUgZutyf);
						num2 = 53;
						continue;
					}
					case 56:
						goto IL_40A;
					case 57:
						goto IL_B87;
					case 58:
						goto IL_220;
					case 59:
						DelegateSupport.pMsh2LtH3OCmSV5QgwL(ilgenerator, OpCodes.Callvirt, DelegateSupport.kfgAk4C3ZUZ15VlIX9t(DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(object).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), hIDAYxH6DWLHIthQgC.gSCeTtiku(163526699 ^ -306984248 ^ -1907608414 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_944294969d634011bf30e3f4f506a31e), X127Q0UR3CERXOhenKY.Bo6UkBGZYT), zlhoVEUJgYHXwr3BCPL.krwUWtuUrb);
						num2 = 33;
						continue;
					case 60:
						goto IL_66C;
					case 61:
						DelegateSupport.BDJy18t9aSBD08mdyxX(ilgenerator, OpCodes.Stloc, localBuilder, PYQH6FU12xZM6fMlDHN.fOUUM61s6n);
						num2 = 9;
						continue;
					case 62:
						goto IL_9F3;
					case 63:
						goto IL_9AF;
					case 64:
						DelegateSupport.BDJy18t9aSBD08mdyxX(ilgenerator, OpCodes.Stloc, localBuilder2, PYQH6FU12xZM6fMlDHN.fOUUM61s6n);
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 65:
						goto IL_40A;
					case 66:
						dynamicMethod = new DynamicMethod(DelegateSupport.cUVgrhCjodsx5qCk5gW(hIDAYxH6DWLHIthQgC.gSCeTtiku(1345850071 ^ 1841305966 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b8a2996bc299402b995470e3e8286d42), DelegateSupport.XRSFikCBFD8sBulYS6Z(managedMethod), z4S0e1U05BsRVVK2fNl.aarUNWns9V), MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static, CallingConventions.Standard, type, array, DelegateSupport.PRxNuyCoJbaMwh4d8WK(typeof(DelegateSupport).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), true);
						num2 = 31;
						continue;
					case 67:
						goto IL_B10;
					case 68:
						DelegateSupport.sYaI8CCKOYucZgyOn2l(ilgenerator, OpCodes.Ldnull, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8447c7a721f541de9426c754e1b08372 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 69:
						DelegateSupport.sYaI8CCKOYucZgyOn2l(ilgenerator, OpCodes.Nop, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_468d644ed32a4ba3ad77ef2c95e2ad4b == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 70:
						goto IL_9D4;
					case 71:
						num4 = 0;
						num2 = 4;
						continue;
					case 72:
						DelegateSupport.BDJy18t9aSBD08mdyxX(ilgenerator, OpCodes.Ldloc, localBuilder2, PYQH6FU12xZM6fMlDHN.fOUUM61s6n);
						num2 = 3;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c1d51581d05f41579ee6e476d9be288e == 0)
						{
							num2 = 59;
							continue;
						}
						continue;
					case 73:
					{
						Label label3;
						DelegateSupport.FK25nCCpNPpHDoyZfsm(ilgenerator, OpCodes.Brfalse, label3, V5jKQ2USYTLU6Q7ybPM.QwCUgZutyf);
						num2 = 11;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7b2fff018dbf4cfe8ef41e2d123dc629 == 0)
						{
							num2 = 12;
							continue;
						}
						continue;
					}
					case 74:
						break;
					}
					IL_192:
					num3++;
					num2 = 60;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3ffead0113044f06b294bee6bd5e7a44 != 0)
					{
						num2 = 58;
						continue;
					}
					continue;
					IL_9F3:
					if (!DelegateSupport.EMIvvwC1TU7t9UBMKBA(type2, uSHtktUsvv7Ll0hs4W6.S1nUQYAm9h))
					{
						num2 = 19;
						continue;
					}
					goto IL_192;
					IL_220:
					if (num4 < array2.Length)
					{
						goto IL_9AF;
					}
					num2 = 66;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5f6b46e73a464a41b29ca79bf0f3b8f9 == 0)
					{
						num2 = 32;
						continue;
					}
					continue;
					IL_26E:
					DelegateSupport.BDJy18t9aSBD08mdyxX(ilgenerator, OpCodes.Ldloc, localBuilder, PYQH6FU12xZM6fMlDHN.fOUUM61s6n);
					num2 = 24;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ef7f3142723b424fb42b4125f902e28b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_3E2:
					localBuilder = null;
					num2 = 16;
					continue;
					IL_40A:
					if (!DelegateSupport.EMIvvwC1TU7t9UBMKBA(type, uSHtktUsvv7Ll0hs4W6.S1nUQYAm9h))
					{
						num2 = 8;
						continue;
					}
					goto IL_3E2;
					IL_66C:
					if (num3 < array2.Length)
					{
						goto IL_B10;
					}
					num2 = 35;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_48b9993e573d4d08a64ac27c515a32b9 == 0)
					{
						num2 = 13;
						continue;
					}
					continue;
					IL_8DE:
					localBuilder2 = DelegateSupport.viKALgtiK2DODALeddN(ilgenerator, byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Exception).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), KQ408IUnj4MeYY1d6lA.lnnU3S4n1c);
					num2 = 16;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9a3e85e731764e36a5b07f4e692becd8 != 0)
					{
						num2 = 20;
						continue;
					}
					continue;
					IL_9AF:
					array[num4 + 1] = DelegateSupport.nMdxw1Cwo9eivBuCZFb(array2[num4], qc2ECMAKgYlQ7Q4UDSY.YttA5ifGGI).NativeType();
					num2 = 54;
					continue;
					IL_AF5:
					PybwZDULT8j9uRoXf8D.i2IAUFsOOC(ilgenerator, OpCodes.Ret, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
					num2 = 45;
					continue;
					IL_B10:
					type2 = DelegateSupport.nMdxw1Cwo9eivBuCZFb(array2[num3], qc2ECMAKgYlQ7Q4UDSY.YttA5ifGGI);
					num2 = 3;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_944294969d634011bf30e3f4f506a31e == 0)
					{
						num2 = 0;
					}
				}
				IL_2A0:
				DelegateSupport.pMsh2LtH3OCmSV5QgwL(ilgenerator, OpCodes.Call, DelegateSupport.kfgAk4C3ZUZ15VlIX9t(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(IL2CPP).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), DelegateSupport.jT6PINCDdd16U5NQ0J0(665295750 + 1584662951 ^ -878936633 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6926da1cf80047d3a6f0516668d22380), X127Q0UR3CERXOhenKY.Bo6UkBGZYT), zlhoVEUJgYHXwr3BCPL.krwUWtuUrb);
				num = 27;
				continue;
				IL_6A5:
				DelegateSupport.sYaI8CCKOYucZgyOn2l(ilgenerator, OpCodes.Pop, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
				num = 7;
				continue;
				IL_77C:
				DelegateSupport.FK25nCCpNPpHDoyZfsm(ilgenerator, OpCodes.Br, label4, V5jKQ2USYTLU6Q7ybPM.QwCUgZutyf);
				num = 37;
				continue;
				IL_9D4:
				DelegateSupport.sYaI8CCKOYucZgyOn2l(ilgenerator, OpCodes.Dup, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
				num = 55;
				continue;
				IL_B87:
				hZ6abvUhJRbtUPKZCVQ.i2IAUFsOOC(nativeMethod, hZ6abvUhJRbtUPKZCVQ.xnsU8Lh8XX);
				num = 13;
			}
			IL_969:
			return DelegateSupport.j8VfeotxSaUp5eZrokE(dynamicMethod, DelegateSupport.cMimxottpFQ3nfePBFU(signature, managedMethod), GajqGFqGF52ibtnrXfs.srKqYspB8v);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004A3C File Offset: 0x00002C3C
		private static void LogError(object message)
		{
			DelegateSupport.TlbAQ9CvHg3yjMJjaEM(message);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004A4C File Offset: 0x00002C4C
		public unsafe static TIl2Cpp ConvertDelegate<TIl2Cpp>(Delegate @delegate) where TIl2Cpp : Il2CppObjectBase
		{
			if (@delegate == null)
			{
				return default(TIl2Cpp);
			}
			if (!jQdCBeqaKbkTrjy04fc.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Delegate).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(TIl2Cpp).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), jQdCBeqaKbkTrjy04fc.AL9qC4lG9P))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(TIl2Cpp).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an));
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-660285926 << 2 ^ 71688328 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ba3f6bd5a09c47868765e25f534dbf2a), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				throw new ArgumentException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
			}
			MethodInfo methodInfo = F6byMAqhRvqDsDbRpFe.i2IAUFsOOC(axjPFwqt1vaYPQhZ6LC.i2IAUFsOOC(@delegate, axjPFwqt1vaYPQhZ6LC.Wesqxlek4W), hIDAYxH6DWLHIthQgC.gSCeTtiku(-1247764073 + -926383808 ^ 415209959 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ba3f6bd5a09c47868765e25f534dbf2a), F6byMAqhRvqDsDbRpFe.CaXq8ZNRgJ);
			ParameterInfo[] array = sLG6EQATwSiLRpKGREk.i2IAUFsOOC(methodInfo, sLG6EQATwSiLRpKGREk.VZpAFVSObI);
			ParameterInfo[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				Type type = qc2ECMAKgYlQ7Q4UDSY.i2IAUFsOOC(array2[i], qc2ECMAKgYlQ7Q4UDSY.YttA5ifGGI);
				if (GZZerOq0lk2GItma8VI.i2IAUFsOOC(type, GZZerOq0lk2GItma8VI.TpPqNScgWN))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(70, 1);
					QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-126702131 << 3 ^ -516297608 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
					defaultInterpolatedStringHandler.AppendFormatted<Type>(type);
					QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1186506589 ^ -1245438788 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c504ab11ece64b14b01df2d4c88e6e49), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
					throw new ArgumentException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
				}
				if (dPsigOUwJdO4bwskNJ5.i2IAUFsOOC(shNswyquVFWBad0nqf7.i2IAUFsOOC(type, shNswyquVFWBad0nqf7.WtLqEc6DLZ), byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(ValueType).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), dPsigOUwJdO4bwskNJ5.hvvUeCiIEf))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(77, 1);
					QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(735523184 ^ 1100478013 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_944294969d634011bf30e3f4f506a31e), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
					defaultInterpolatedStringHandler.AppendFormatted<Type>(type);
					QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(~-164793095 ^ 1616061212 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_afe904a262fb47328a49943b4b34b494), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
					throw new ArgumentException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
				}
			}
			IntPtr nativeClassPointer = Il2CppClassPointerStore.GetNativeClassPointer(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(TIl2Cpp).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an));
			if (nativeClassPointer == IntPtr.Zero)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 1);
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1473527732 ^ -1974256799 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e4c6981dbbef43b3a6de5ad27be6a3b1), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(TIl2Cpp).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an));
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1253386989 << 6 ^ -43401598 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_be54e2986e644667aed0d52d0affe157), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				throw new ArgumentException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
			}
			MethodInfo methodInfo2 = aVEVq9qLn3nSH3AstMB.i2IAUFsOOC(u17VAkqcirg8uZTulMb.i2IAUFsOOC(IL2CPP.il2cpp_class_get_type(nativeClassPointer), u17VAkqcirg8uZTulMb.sHiq69QE45), hIDAYxH6DWLHIthQgC.gSCeTtiku(-352363743 + -1553115080 ^ -2098203618 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c504ab11ece64b14b01df2d4c88e6e49), aVEVq9qLn3nSH3AstMB.jsmq7PQgLS);
			Il2CppReferenceArray<ParameterInfo> il2CppReferenceArray = hZ6abvUhJRbtUPKZCVQ.i2IAUFsOOC(methodInfo2, hZ6abvUhJRbtUPKZCVQ.xnsU8Lh8XX);
			if (il2CppReferenceArray.Count != array.Length)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(65, 2);
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(~1015743027 ^ -1542403474 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ddf0bbff3ec54ad39c6b2ba58dc80058), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				defaultInterpolatedStringHandler.AppendFormatted<int>(array.Length);
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(~445573850 ^ -955650168 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e4c6981dbbef43b3a6de5ad27be6a3b1), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				defaultInterpolatedStringHandler.AppendFormatted<int>(il2CppReferenceArray.Count);
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-351482292 - -287444189 ^ -944108332 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c733963b5aa3462f9be5a2d711359fa7), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				throw new ArgumentException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
			}
			for (int j = 0; j < il2CppReferenceArray.Count; j++)
			{
				Type type2 = MBv2HSqR329QOQ9YAqY.i2IAUFsOOC(il2CppReferenceArray[j], MBv2HSqR329QOQ9YAqY.SVjqkI3jbj);
				Type type3 = qc2ECMAKgYlQ7Q4UDSY.i2IAUFsOOC(array[j], qc2ECMAKgYlQ7Q4UDSY.YttA5ifGGI);
				if (u3ixq8qJD5eTPm4QJHt.i2IAUFsOOC(type2, u3ixq8qJD5eTPm4QJHt.PuuqWdSuUm) || l3AN43qrOBxKsw7pvOY.i2IAUFsOOC(type3, l3AN43qrOBxKsw7pvOY.l5BqD0Sj3Q))
				{
					if (O8vLYPqbYWoU9KsgoZ5.i2IAUFsOOC(KcNIiKqZ7UaY10c1XIC.i2IAUFsOOC(type2, KcNIiKqZ7UaY10c1XIC.q3uqohUZBd), XbWY87UAp2s3iIUpBiV.i2IAUFsOOC(type3, XbWY87UAp2s3iIUpBiV.tomUUWdyuW), O8vLYPqbYWoU9KsgoZ5.uy0qf0LujG))
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 3);
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(386187679 ^ 754810778 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c4640bbaac7c4988b56f91d1b6b3f1a9), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						defaultInterpolatedStringHandler.AppendFormatted<int>(j);
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1516501918 ^ -8795546 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d691a76a9c4746c9a1a67e34c67ca64b), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, KcNIiKqZ7UaY10c1XIC.i2IAUFsOOC(type2, KcNIiKqZ7UaY10c1XIC.q3uqohUZBd), FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(~499136732 ^ -1185759266 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2dd85386720b438b874026b47430e4fa), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, XbWY87UAp2s3iIUpBiV.i2IAUFsOOC(type3, XbWY87UAp2s3iIUpBiV.tomUUWdyuW), FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
						throw new ArgumentException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
					}
				}
				else
				{
					IntPtr intPtr = (IntPtr)GYhvdXq2oldr1eq9pKe.i2IAUFsOOC(e9JbcIqsAv7s4t2ydLY.i2IAUFsOOC(F9k0QHqwuAF4DuGYBHT.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Il2CppClassPointerStore<>).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), new Type[]
					{
						type3
					}, F9k0QHqwuAF4DuGYBHT.AMmqeBVp2m), hIDAYxH6DWLHIthQgC.gSCeTtiku(~-572906782 ^ 362998892 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c474f43efb4d4f17b5c0c1bf3216ef4d), e9JbcIqsAv7s4t2ydLY.Ib4qQ8dvnX), null, GYhvdXq2oldr1eq9pKe.gf2qyBPuV5);
					IntPtr intPtr2 = IL2CPP.il2cpp_class_from_type(iqwVkRqSd7c2e7KkG1c.i2IAUFsOOC(type2, iqwVkRqSd7c2e7KkG1c.K7AqgR259I).value);
					if (intPtr != intPtr2)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(67, 3);
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-2051013976 ^ -706542018 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_be54e2986e644667aed0d52d0affe157), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						defaultInterpolatedStringHandler.AppendFormatted<int>(j);
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-263637932 ^ -877622981 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c4640bbaac7c4988b56f91d1b6b3f1a9), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, KcNIiKqZ7UaY10c1XIC.i2IAUFsOOC(type2, KcNIiKqZ7UaY10c1XIC.q3uqohUZBd), FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-97333341 ^ 600180503 ^ -2103857079 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2dd85386720b438b874026b47430e4fa), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, XbWY87UAp2s3iIUpBiV.i2IAUFsOOC(type3, XbWY87UAp2s3iIUpBiV.tomUUWdyuW), FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
						throw new ArgumentException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
					}
					if (lZ3Yj7ql9HuELBblH6P.i2IAUFsOOC(type2, lZ3Yj7ql9HuELBblH6P.p1HqVmQDPK) || HUtclRqOvktk8jFJw0c.i2IAUFsOOC(type3, HUtclRqOvktk8jFJw0c.zf1qXu2bX0))
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(59, 1);
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(211514960 ^ 1044687439 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9cbee6d56f49422699718938ff979567), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						defaultInterpolatedStringHandler.AppendFormatted<int>(j);
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1808198684 ^ 38225576 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_afe904a262fb47328a49943b4b34b494), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						throw new ArgumentException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
					}
				}
			}
			Delegate orCreateNativeToManagedTrampoline = DelegateSupport.GetOrCreateNativeToManagedTrampoline(new DelegateSupport.MethodSignature(methodInfo2, true), methodInfo2, methodInfo);
			INativeMethodInfoStruct nativeMethodInfoStruct = UnityVersionHandler.NewMethod();
			*nativeMethodInfoStruct.MethodPointer = RgfAJbqmAFqwcVBtxjd.i2IAUFsOOC(orCreateNativeToManagedTrampoline, RgfAJbqmAFqwcVBtxjd.z4SqvI01Xe);
			*nativeMethodInfoStruct.ParametersCount = (byte)array.Length;
			*nativeMethodInfoStruct.Slot = ushort.MaxValue;
			nativeMethodInfoStruct.IsMarshalledFromNative = true;
			DelegateSupport.Il2CppToMonoDelegateReference value = new DelegateSupport.Il2CppToMonoDelegateReference(@delegate, nativeMethodInfoStruct.Pointer);
			Delegate delegate2 = new Delegate(IL2CPP.il2cpp_object_new(nativeClassPointer));
			RbWXAZqBtGrZtq14Otj.i2IAUFsOOC(delegate2, *nativeMethodInfoStruct.MethodPointer, RbWXAZqBtGrZtq14Otj.M5DqjLxVXv);
			LwLX88qTcNo0ZKmYqja.i2IAUFsOOC(delegate2, methodInfo2, LwLX88qTcNo0ZKmYqja.DngqF9SJ0U);
			ktVDMZqKEKBsM13bZtl.i2IAUFsOOC(delegate2, nativeMethodInfoStruct.Pointer, ktVDMZqKEKBsM13bZtl.MMKq53drfa);
			IAe53cqnY4BQihf1Jvw.i2IAUFsOOC(delegate2, new Object(IL2CPP.il2cpp_object_new(nativeMethodInfoStruct.Pointer)), IAe53cqnY4BQihf1Jvw.ufMq3ExRQS);
			if (DelegateSupport.NativeToManagedTrampoline.ContainsKey(jrmKQHq1WpZFX1iNVw8.i2IAUFsOOC(delegate2, jrmKQHq1WpZFX1iNVw8.TLKqMPTEQB).Pointer))
			{
				DelegateSupport.NativeToManagedTrampoline.Remove(jrmKQHq1WpZFX1iNVw8.i2IAUFsOOC(delegate2, jrmKQHq1WpZFX1iNVw8.TLKqMPTEQB).Pointer);
			}
			DelegateSupport.NativeToManagedTrampoline.Add(jrmKQHq1WpZFX1iNVw8.i2IAUFsOOC(delegate2, jrmKQHq1WpZFX1iNVw8.TLKqMPTEQB).Pointer, value);
			tL6CNpqzkHagEqbQ3tF.i2IAUFsOOC(delegate2, Bmy2ooqpfX8d7hEtWrm.i2IAUFsOOC(delegate2, Bmy2ooqpfX8d7hEtWrm.C2Kq46pV8d), tL6CNpqzkHagEqbQ3tF.Bn09HilAex);
			cpOdEc9Aejc6orqt8p7.i2IAUFsOOC(delegate2, jrmKQHq1WpZFX1iNVw8.i2IAUFsOOC(delegate2, jrmKQHq1WpZFX1iNVw8.TLKqMPTEQB).Pointer, cpOdEc9Aejc6orqt8p7.Ogs9UyhiBD);
			return delegate2.Cast<TIl2Cpp>();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000052C8 File Offset: 0x000034C8
		// Note: this type is marked as 'beforefieldinit'.
		static DelegateSupport()
		{
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_F6;
					case 2:
						DelegateSupport.ourDelegateTypes = new ConcurrentDictionary<DelegateSupport.MethodSignature, Type>();
						num2 = 6;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c2ad52141772446383547acade021f9a == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						DelegateSupport.xRSV1uthYy7WhyTuFPe();
						num2 = 7;
						continue;
					case 4:
						hIDAYxH6DWLHIthQgC.zSLipEDdx();
						num2 = 3;
						continue;
					case 5:
						DelegateSupport.ModuleBuilder = DelegateSupport.UTDfhLtNlJlPIoc5XhF(DelegateSupport.AssemblyBuilder, DelegateSupport.jT6PINCDdd16U5NQ0J0(660591337 ^ 2090383397 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fcdd30171ceb4eb7a5570cbbc4f6aec1), B17Oqp9iWWgj6vslXHW.JbY9IMBSA4);
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_49c6a53db2614593b5468905d8aba004 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 6:
						DelegateSupport.AssemblyBuilder = DelegateSupport.xR9Irat0iwNej5drBJA(new AssemblyName(DelegateSupport.jT6PINCDdd16U5NQ0J0(939997590 << 1 ^ 1196395100 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4ab786fa8604298818cd412db8f702f)), AssemblyBuilderAccess.Run, PhcPCd9qZOZYbGJa4AI.UK199Z5kws);
						num2 = 5;
						continue;
					case 7:
						DelegateSupport.ogcRjrt8B2p8r58aH5q();
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_468d644ed32a4ba3ad77ef2c95e2ad4b == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 8:
						DelegateSupport.NativeToManagedTrampoline = new Dictionary<IntPtr, DelegateSupport.Il2CppToMonoDelegateReference>();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_483eecf3691e4ef2b23b2d4cb2ca3d52 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_F6:
				DelegateSupport.NativeToManagedTrampolines = new ConcurrentDictionary<MethodInfo, Delegate>();
				num = 8;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00005458 File Offset: 0x00003658
		internal static bool L0OMwUCWvLCxejP127b()
		{
			return DelegateSupport.dbq9R8CJPGDHxnIT2xa == null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000546C File Offset: 0x0000366C
		internal static DelegateSupport aWutGBCr8MppBBAWWvu()
		{
			return DelegateSupport.dbq9R8CJPGDHxnIT2xa;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000547C File Offset: 0x0000367C
		internal static object jT6PINCDdd16U5NQ0J0(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00005490 File Offset: 0x00003690
		internal static object pnLVCuCZ2vNx0grdATG(object A_0, object A_1, object A_2, object A_3, object A_4)
		{
			return SjRANlAsQ8j3KPpZL2p.i2IAUFsOOC(A_0, A_1, A_2, A_3, A_4);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000054B4 File Offset: 0x000036B4
		internal static Type PRxNuyCoJbaMwh4d8WK(RuntimeTypeHandle A_0, object A_1)
		{
			return byRw0gA2NyqHkl03ii9.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000054CC File Offset: 0x000036CC
		internal static object TRqkPrCbthxTF2jsGtx(object A_0, object A_1, object A_2)
		{
			return b27ekHAlO1XXce9pRo0.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000054E8 File Offset: 0x000036E8
		internal static void Ai14DSCf2p0CRwT1096(object A_0, object A_1, object A_2)
		{
			f4MxL4AOJOmnsnGxg4f.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00005504 File Offset: 0x00003704
		internal static object bDm9rBCPWWrmrBD9Pjh(object A_0, MethodAttributes A_1, CallingConventions A_2, object A_3, object A_4)
		{
			return d5rqpnAma75otQhcJbn.i2IAUFsOOC(A_0, A_1, A_2, A_3, A_4);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00005528 File Offset: 0x00003728
		internal static void rpUukhCdxMEMeodHwUF(object A_0, MethodImplAttributes A_1, object A_2)
		{
			Od6dsxABmuKKQmVjDsf.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00005544 File Offset: 0x00003744
		internal static Type nMdxw1Cwo9eivBuCZFb(object A_0, object A_1)
		{
			return qc2ECMAKgYlQ7Q4UDSY.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000555C File Offset: 0x0000375C
		internal static Type xrDYPOCelbjWZx2TQLx(Type managedType)
		{
			return managedType.NativeType();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00005570 File Offset: 0x00003770
		internal static Type VQGwimCsOYUf18xYKUs(object A_0, object A_1)
		{
			return jPM26DAnQfHunyInIhU.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005588 File Offset: 0x00003788
		internal static object cl70KrCQlMsGDxtLJei(object A_0, object A_1, MethodAttributes A_2, CallingConventions A_3, Type A_4, object A_5, object A_6)
		{
			return rK10McA1W7rRDddaGkF.i2IAUFsOOC(A_0, A_1, A_2, A_3, A_4, A_5, A_6);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000055B4 File Offset: 0x000037B4
		internal static void QFNoaCC2S7pEnjkExpp(object A_0, MethodImplAttributes A_1, object A_2)
		{
			MyCfRnAp32SBLkfxPeR.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000055D0 File Offset: 0x000037D0
		internal static Type URMY19CygDUypEtjsE9(object A_0, object A_1)
		{
			return aDGbeTAzy0PmbSxqfnH.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000055E8 File Offset: 0x000037E8
		internal static object A3rP2vCSPwIJNwJwi2A(object A_0, object A_1, object A_2)
		{
			return ryYXxRUq8BsbY0RUmr6.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00005604 File Offset: 0x00003804
		internal static bool RNkfCDCg87mU2B8G4bP(object A_0, object A_1)
		{
			return a4R1rnUiI6Z0H9xNlx5.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000561C File Offset: 0x0000381C
		internal static object Leur5jClCnvmMKygZk0(object A_0, char A_1, object A_2)
		{
			return H2StJeUGVkry79EgdEo.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00005638 File Offset: 0x00003838
		internal static Type Pn47GoCVwYJ0h6rnQfB(object A_0, object A_1)
		{
			return aNXqaFUaF5FInd1YJEI.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00005650 File Offset: 0x00003850
		internal static object m3X3JjCOEQY0Rjlsxr7(object A_0, object A_1)
		{
			return XbWY87UAp2s3iIUpBiV.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005668 File Offset: 0x00003868
		internal static object do0PgRCX4YleNdbVpWL(object A_0, object A_1)
		{
			return sLG6EQATwSiLRpKGREk.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00005680 File Offset: 0x00003880
		internal static object zNuhI4CmdpfO1SRe8g9(object A_0, object A_1)
		{
			return QW5rQ4UtSMItWDAsJG4.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005698 File Offset: 0x00003898
		internal static void TlbAQ9CvHg3yjMJjaEM(object A_0)
		{
			Logger.LogError(A_0);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000056AC File Offset: 0x000038AC
		internal static object XRSFikCBFD8sBulYS6Z(object A_0)
		{
			return DelegateSupport.ExtractSignature(A_0);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000056C0 File Offset: 0x000038C0
		internal static object cUVgrhCjodsx5qCk5gW(object A_0, object A_1, object A_2)
		{
			return z4S0e1U05BsRVVK2fNl.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000056DC File Offset: 0x000038DC
		internal static object lSe3weCT0y0I91Ms7DC(object A_0, object A_1)
		{
			return LN74hFUuuPeOAyrLO2m.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000056F4 File Offset: 0x000038F4
		internal static Label UXYvX4CF36e0LTUOBGm(object A_0, object A_1)
		{
			return xrSf5WUcU7r8AC9ojJq.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000570C File Offset: 0x0000390C
		internal static void sYaI8CCKOYucZgyOn2l(object A_0, OpCode A_1, object A_2)
		{
			PybwZDULT8j9uRoXf8D.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00005728 File Offset: 0x00003928
		internal static void X13HYtC5GrggVq8SyNL(object A_0, OpCode A_1, object A_2, object A_3)
		{
			UjCL81UbRoyk5Lr84pU.i2IAUFsOOC(A_0, A_1, A_2, A_3);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00005748 File Offset: 0x00003948
		internal static void cfjeB1CnS3d10BPxgcv(object A_0, OpCode A_1, int A_2, object A_3)
		{
			i8SdLhUP0eAhNFuWLMo.i2IAUFsOOC(A_0, A_1, A_2, A_3);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00005768 File Offset: 0x00003968
		internal static object kfgAk4C3ZUZ15VlIX9t(object A_0, object A_1, object A_2)
		{
			return X127Q0UR3CERXOhenKY.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00005784 File Offset: 0x00003984
		internal static bool EMIvvwC1TU7t9UBMKBA(object A_0, object A_1)
		{
			return uSHtktUsvv7Ll0hs4W6.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000579C File Offset: 0x0000399C
		internal static Label TfFWbuCMxgqLtjauaUP(object A_0, object A_1)
		{
			return T9hscQU2PnRQmsgFCNw.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000057B4 File Offset: 0x000039B4
		internal static void FK25nCCpNPpHDoyZfsm(object A_0, OpCode A_1, Label A_2, object A_3)
		{
			V5jKQ2USYTLU6Q7ybPM.i2IAUFsOOC(A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000057D4 File Offset: 0x000039D4
		internal static void V7Y9SdC4rr6W8bIZgbJ(object A_0, OpCode A_1, object A_2, object A_3)
		{
			N3j9MUUOGeO9qTBVBp1.i2IAUFsOOC(A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000057F4 File Offset: 0x000039F4
		internal static void gAkfAECzkdxy5mTQxXJ(object A_0, Label A_1, object A_2)
		{
			PW0V5GUmBLqSWP66Z4c.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00005810 File Offset: 0x00003A10
		internal static void pMsh2LtH3OCmSV5QgwL(object A_0, OpCode A_1, object A_2, object A_3)
		{
			zlhoVEUJgYHXwr3BCPL.i2IAUFsOOC(A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00005830 File Offset: 0x00003A30
		internal static bool pPZgBRtAJ3TC8NUc10N(Type A_0, Type A_1, object A_2)
		{
			return dPsigOUwJdO4bwskNJ5.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000584C File Offset: 0x00003A4C
		internal static object xVItB1tUS34AETuijQe(object A_0, object A_1, object A_2)
		{
			return abNfQOUBX9HpKxMrtL7.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005868 File Offset: 0x00003A68
		internal static object YXBFCitq0NbCL8jkicb(object A_0, object A_1)
		{
			return xHHh6jUT0eH9Q7OhVRy.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00005880 File Offset: 0x00003A80
		internal static void BDJy18t9aSBD08mdyxX(object A_0, OpCode A_1, object A_2, object A_3)
		{
			PYQH6FU12xZM6fMlDHN.i2IAUFsOOC(A_0, A_1, A_2, A_3);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000058A0 File Offset: 0x00003AA0
		internal static object viKALgtiK2DODALeddN(object A_0, Type A_1, object A_2)
		{
			return KQ408IUnj4MeYY1d6lA.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000058BC File Offset: 0x00003ABC
		internal static void JHHcbhtIDkRWInYeNUX(object A_0, Type A_1, object A_2)
		{
			i2gLiDUpAgDrhYbEGTX.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000058D8 File Offset: 0x00003AD8
		internal static void bcFjuCtGOruai8njV4g(object A_0, OpCode A_1, object A_2, object A_3)
		{
			juWq3eUzrSmJee3Fw6H.i2IAUFsOOC(A_0, A_1, A_2, A_3);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000058F8 File Offset: 0x00003AF8
		internal static object wKadictYPQKajx8I9KL(object A_0, object A_1, object A_2, object A_3)
		{
			return KXmbngqAYb7452NDmoE.i2IAUFsOOC(A_0, A_1, A_2, A_3);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00005918 File Offset: 0x00003B18
		internal static object HP0CO9taSGIbAlJTCZa(object A_0, object A_1, BindingFlags A_2, object A_3)
		{
			return LSc0e0qqd5ti0ClnMPQ.i2IAUFsOOC(A_0, A_1, A_2, A_3);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005938 File Offset: 0x00003B38
		internal static void DcHrGWtCrurSxs5sjAa(object A_0, object A_1)
		{
			KRdvyeqiNjTgc2IU7fe.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00005950 File Offset: 0x00003B50
		internal static Type cMimxottpFQ3nfePBFU(object A_0, object A_1)
		{
			return DelegateSupport.GetOrCreateDelegateType(A_0, A_1);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00005968 File Offset: 0x00003B68
		internal static object j8VfeotxSaUp5eZrokE(object A_0, Type A_1, object A_2)
		{
			return GajqGFqGF52ibtnrXfs.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00005984 File Offset: 0x00003B84
		internal static void xRSV1uthYy7WhyTuFPe()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00005994 File Offset: 0x00003B94
		internal static void ogcRjrt8B2p8r58aH5q()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000059A4 File Offset: 0x00003BA4
		internal static object xR9Irat0iwNej5drBJA(object A_0, AssemblyBuilderAccess A_1, object A_2)
		{
			return PhcPCd9qZOZYbGJa4AI.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000059C0 File Offset: 0x00003BC0
		internal static object UTDfhLtNlJlPIoc5XhF(object A_0, object A_1, object A_2)
		{
			return B17Oqp9iWWgj6vslXHW.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x04000005 RID: 5
		private static readonly ConcurrentDictionary<DelegateSupport.MethodSignature, Type> ourDelegateTypes;

		// Token: 0x04000006 RID: 6
		private static readonly AssemblyBuilder AssemblyBuilder;

		// Token: 0x04000007 RID: 7
		private static readonly ModuleBuilder ModuleBuilder;

		// Token: 0x04000008 RID: 8
		private static readonly ConcurrentDictionary<MethodInfo, Delegate> NativeToManagedTrampolines;

		// Token: 0x04000009 RID: 9
		private static readonly Dictionary<IntPtr, DelegateSupport.Il2CppToMonoDelegateReference> NativeToManagedTrampoline;

		// Token: 0x0400000A RID: 10
		private static DelegateSupport dbq9R8CJPGDHxnIT2xa;

		// Token: 0x02000005 RID: 5
		public class MethodSignature : IEquatable<DelegateSupport.MethodSignature>
		{
			// Token: 0x06000086 RID: 134 RVA: 0x00016D54 File Offset: 0x00014F54
			public MethodSignature(MethodInfo methodInfo, bool hasThis)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				DelegateSupport.MethodSignature.EvI1A9RmTKpVZJYi87y();
				base..ctor();
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.ConstructedFromNative = true;
						num = 4;
						continue;
					case 2:
						this.myReturnType = ((!DelegateSupport.MethodSignature.yYgJoqRB2SX5t0MMPEB(DelegateSupport.MethodSignature.UoM2aQRvkn6mu6EOjeA(methodInfo, uoEP0fInkFUiyKxjBjD.MPMI3ycBHh), suhR91I1G2UWpwPvl7M.NvXIMEf8Bq)) ? IntPtr.Zero : DelegateSupport.MethodSignature.eu7h7BRjVofhmCLV2Lc(DelegateSupport.MethodSignature.UoM2aQRvkn6mu6EOjeA(methodInfo, uoEP0fInkFUiyKxjBjD.MPMI3ycBHh), iqwVkRqSd7c2e7KkG1c.K7AqgR259I).value);
						num = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_db312e48eee84539b805fee2f73a8cde == 0)
						{
							num = 0;
							continue;
						}
						continue;
					case 3:
						this.HasThis = hasThis;
						num = 2;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_468d644ed32a4ba3ad77ef2c95e2ad4b != 0)
						{
							num = 0;
							continue;
						}
						continue;
					case 4:
						return;
					}
					IEnumerable<ParameterInfo> source = hZ6abvUhJRbtUPKZCVQ.i2IAUFsOOC(methodInfo, hZ6abvUhJRbtUPKZCVQ.xnsU8Lh8XX);
					Func<ParameterInfo, IntPtr> selector;
					if ((selector = DelegateSupport.MethodSignature.<>c.<>9__4_0) == null)
					{
						selector = (DelegateSupport.MethodSignature.<>c.<>9__4_0 = delegate(ParameterInfo it)
						{
							int num2 = 1;
							int num3 = num2;
							for (;;)
							{
								switch (num3)
								{
								case 1:
									if (DelegateSupport.MethodSignature.<>c.wZ4RsEwYainZX6S6TM8(DelegateSupport.MethodSignature.<>c.xyfLBtwGmDECgNk310L(it, MBv2HSqR329QOQ9YAqY.SVjqkI3jbj), suhR91I1G2UWpwPvl7M.NvXIMEf8Bq))
									{
										goto IL_6A;
									}
									num3 = 0;
									if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_eea945ea6be345c0b18511ac11610b35 != 0)
									{
										num3 = 0;
										continue;
									}
									continue;
								}
								break;
							}
							return IntPtr.Zero;
							IL_6A:
							return DelegateSupport.MethodSignature.<>c.jTRmsewa1K6RlcaFmis(DelegateSupport.MethodSignature.<>c.xyfLBtwGmDECgNk310L(it, MBv2HSqR329QOQ9YAqY.SVjqkI3jbj), iqwVkRqSd7c2e7KkG1c.K7AqgR259I).value;
						});
					}
					this.myParameterTypes = source.Select(selector).ToArray<IntPtr>();
					num = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_61a3825996b24609815f6b482bf680d9 == 0)
					{
						num = 1;
					}
				}
			}

			// Token: 0x06000087 RID: 135 RVA: 0x00016EB4 File Offset: 0x000150B4
			public MethodSignature(MethodInfo methodInfo, bool hasThis)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				DelegateSupport.MethodSignature.EvI1A9RmTKpVZJYi87y();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c4640bbaac7c4988b56f91d1b6b3f1a9 != 0)
				{
					num = 1;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.HasThis = hasThis;
						num = 3;
						continue;
					case 2:
						this.ConstructedFromNative = false;
						num = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_98f1dfe5d9cd4cf9bdc32e0db7fb0ae4 == 0)
						{
							num = 0;
							continue;
						}
						continue;
					case 3:
					{
						IntPtr intPtr;
						if (!uSHtktUsvv7Ll0hs4W6.i2IAUFsOOC(jPM26DAnQfHunyInIhU.i2IAUFsOOC(methodInfo, jPM26DAnQfHunyInIhU.xcUA3EoFoP), uSHtktUsvv7Ll0hs4W6.S1nUQYAm9h))
						{
							intPtr = IntPtr.Zero;
						}
						else
						{
							RuntimeTypeHandle runtimeTypeHandle = DelegateSupport.MethodSignature.aibVMwRFhPAdAIuSgdZ(DelegateSupport.MethodSignature.GndaO6RTgZf7xQHeRm0(methodInfo, jPM26DAnQfHunyInIhU.xcUA3EoFoP), du1ws7iq1lRxNm9OoMA.Tqli9bucs8);
							intPtr = wOaiHFIp5KQA5cNgbQe.i2IAUFsOOC(ref runtimeTypeHandle, wOaiHFIp5KQA5cNgbQe.zQtI4FgVwf);
						}
						this.myReturnType = intPtr;
						num = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_89e7beae9a774fb691cacbb26b1d9330 == 0)
						{
							num = 4;
							continue;
						}
						continue;
					}
					case 4:
					{
						this.myParameterTypes = DelegateSupport.MethodSignature.LiYtcXRKGbywYM81kmi(methodInfo, sLG6EQATwSiLRpKGREk.VZpAFVSObI).Select(delegate(ParameterInfo it)
						{
							int num3 = 1;
							int num4 = num3;
							RuntimeTypeHandle runtimeTypeHandle2;
							for (;;)
							{
								switch (num4)
								{
								default:
									runtimeTypeHandle2 = DelegateSupport.MethodSignature.<>c.lCfk10wtkn95Hd1QMFa(qc2ECMAKgYlQ7Q4UDSY.i2IAUFsOOC(it, qc2ECMAKgYlQ7Q4UDSY.YttA5ifGGI), du1ws7iq1lRxNm9OoMA.Tqli9bucs8);
									num4 = 3;
									break;
								case 1:
									if (!uSHtktUsvv7Ll0hs4W6.i2IAUFsOOC(DelegateSupport.MethodSignature.<>c.uDwTtTwCCyukbky2nAe(it, qc2ECMAKgYlQ7Q4UDSY.YttA5ifGGI), uSHtktUsvv7Ll0hs4W6.S1nUQYAm9h))
									{
										goto IL_57;
									}
									num4 = 0;
									if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c == 0)
									{
										num4 = 0;
									}
									break;
								case 2:
									goto IL_57;
								case 3:
									goto IL_7E;
								}
							}
							IL_57:
							return IntPtr.Zero;
							IL_7E:
							return wOaiHFIp5KQA5cNgbQe.i2IAUFsOOC(ref runtimeTypeHandle2, wOaiHFIp5KQA5cNgbQe.zQtI4FgVwf);
						}).ToArray<IntPtr>();
						int num2 = 2;
						num = num2;
						continue;
					}
					}
					break;
				}
			}

			// Token: 0x06000088 RID: 136 RVA: 0x00017018 File Offset: 0x00015218
			public bool Equals(DelegateSupport.MethodSignature other)
			{
				int num = 9;
				for (;;)
				{
					int num2 = num;
					int num3;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							return false;
						case 2:
							goto IL_7B;
						case 3:
							goto IL_7B;
						case 4:
							goto IL_1D1;
						case 5:
							return false;
						case 6:
							goto IL_1D1;
						case 7:
							return false;
						case 8:
							if (this == other)
							{
								num2 = 0;
								if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c != 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							}
							else if (!yrXqVQIz2W9iFqCr3i9.i2IAUFsOOC(ref this.myReturnType, other.myReturnType, yrXqVQIz2W9iFqCr3i9.Nv9GH2gwBd))
							{
								num2 = 10;
								if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_74d61b1611df4615bd4df289712ea178 == 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							}
							else
							{
								if (this.HasThis != other.HasThis)
								{
									num2 = 7;
									continue;
								}
								if (this.myParameterTypes.Length == other.myParameterTypes.Length)
								{
									goto IL_EE;
								}
								num2 = 0;
								if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_75b92ac812f348208c578c3de71e2d57 == 0)
								{
									num2 = 12;
									continue;
								}
								continue;
							}
							break;
						case 9:
							goto IL_135;
						case 10:
							return false;
						case 11:
							return true;
						case 12:
							return false;
						}
						goto Block_1;
						IL_7B:
						if (num3 >= this.myParameterTypes.Length)
						{
							return true;
						}
						num2 = 4;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c32cfeb41f7a43999be3bae16a94ad02 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
						IL_1D1:
						if (this.myParameterTypes[num3] != other.myParameterTypes[num3])
						{
							num2 = 5;
						}
						else
						{
							num3++;
							num2 = 2;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c474f43efb4d4f17b5c0c1bf3216ef4d == 0)
							{
								num2 = 2;
							}
						}
					}
					IL_EE:
					num3 = 0;
					num = 3;
					continue;
					IL_135:
					if (other == null)
					{
						return false;
					}
					num = 8;
				}
				Block_1:
				return true;
			}

			// Token: 0x06000089 RID: 137 RVA: 0x00017240 File Offset: 0x00015440
			public override bool Equals(object obj)
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
						if (obj == null)
						{
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6104a350572547c0a789887568cca07c == 0)
							{
								num2 = 0;
							}
						}
						else if (this == obj)
						{
							num2 = 1;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_277c9fa6c1da46a98cc2f13643296b8f == 0)
							{
								num2 = 2;
							}
						}
						else
						{
							if (!DelegateSupport.MethodSignature.APWoeBR3edciLBdQ3RO(DelegateSupport.MethodSignature.cDkpocR5VnU6mD9nOMA(obj, axjPFwqt1vaYPQhZ6LC.Wesqxlek4W), DelegateSupport.MethodSignature.HNvF3tRngcR9Vsv86bc(this, a1EB98GAYivvl8q1XpE.oh8GUxu75N), Q57NvyUKOvY5KovuDBT.G0AU5uNCnx))
							{
								goto IL_82;
							}
							num2 = 3;
						}
						break;
					case 2:
						return true;
					case 3:
						return false;
					}
				}
				return false;
				IL_82:
				return this.Equals((DelegateSupport.MethodSignature)obj);
			}

			// Token: 0x0600008A RID: 138 RVA: 0x0001730C File Offset: 0x0001550C
			public override int GetHashCode()
			{
				int num = 2;
				int num2 = num;
				int num3;
				for (;;)
				{
					IntPtr[] array;
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_C3;
					case 1:
						array = this.myParameterTypes;
						num2 = 6;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_40875ab50e1c43f7bf4d96946e4523cb == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 2:
						num3 = (shi1r7Gqp6LH79INyM8.i2IAUFsOOC(ref this.myReturnType, shi1r7Gqp6LH79INyM8.zJtG9YHmRv) ^ jHEJbHGi8NoFsfhw0rX.i2IAUFsOOC(ref this.HasThis, jHEJbHGi8NoFsfhw0rX.TcVGI3B2eX));
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c1d51581d05f41579ee6e476d9be288e == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_108;
					case 4:
						num4++;
						num2 = 9;
						continue;
					case 5:
						return num3;
					case 6:
						num4 = 0;
						num2 = 3;
						continue;
					case 7:
						break;
					case 8:
						break;
					case 9:
						goto IL_108;
					default:
						goto IL_C3;
					}
					IntPtr intPtr = array[num4];
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ba3f6bd5a09c47868765e25f534dbf2a != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_C3:
					num3 = num3 * 397 + shi1r7Gqp6LH79INyM8.i2IAUFsOOC(ref intPtr, shi1r7Gqp6LH79INyM8.zJtG9YHmRv);
					num2 = 2;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
					IL_108:
					if (num4 >= array.Length)
					{
						break;
					}
					num2 = 7;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5afe19cf44424af2ad9aea85585a9cc2 == 0)
					{
						num2 = 7;
					}
				}
				return num3;
			}

			// Token: 0x0600008B RID: 139 RVA: 0x00017490 File Offset: 0x00015690
			public static bool operator ==(DelegateSupport.MethodSignature left, DelegateSupport.MethodSignature right)
			{
				return DelegateSupport.MethodSignature.BMhd6eR1AVNW0BcRe0D(left, right, XLEyvXISui46uUaIBn7.jKNIgVyiGT);
			}

			// Token: 0x0600008C RID: 140 RVA: 0x000174A8 File Offset: 0x000156A8
			public static bool operator !=(DelegateSupport.MethodSignature left, DelegateSupport.MethodSignature right)
			{
				return !DelegateSupport.MethodSignature.BMhd6eR1AVNW0BcRe0D(left, right, XLEyvXISui46uUaIBn7.jKNIgVyiGT);
			}

			// Token: 0x0600008D RID: 141 RVA: 0x000174C0 File Offset: 0x000156C0
			// Note: this type is marked as 'beforefieldinit'.
			static MethodSignature()
			{
				DelegateSupport.MethodSignature.YfWfIaRMet3kHN3wIvg();
			}

			// Token: 0x0600008E RID: 142 RVA: 0x000174D0 File Offset: 0x000156D0
			internal static void EvI1A9RmTKpVZJYi87y()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x0600008F RID: 143 RVA: 0x000174E0 File Offset: 0x000156E0
			internal static object UoM2aQRvkn6mu6EOjeA(object A_0, object A_1)
			{
				return uoEP0fInkFUiyKxjBjD.i2IAUFsOOC(A_0, A_1);
			}

			// Token: 0x06000090 RID: 144 RVA: 0x000174F8 File Offset: 0x000156F8
			internal static bool yYgJoqRB2SX5t0MMPEB(object A_0, object A_1)
			{
				return suhR91I1G2UWpwPvl7M.i2IAUFsOOC(A_0, A_1);
			}

			// Token: 0x06000091 RID: 145 RVA: 0x00017510 File Offset: 0x00015710
			internal static RuntimeTypeHandle eu7h7BRjVofhmCLV2Lc(object A_0, object A_1)
			{
				return iqwVkRqSd7c2e7KkG1c.i2IAUFsOOC(A_0, A_1);
			}

			// Token: 0x06000092 RID: 146 RVA: 0x00017528 File Offset: 0x00015728
			internal static bool Hbq9B5ROJJwECOkXDog()
			{
				return DelegateSupport.MethodSignature.UUNSNjRVpniW4qdLkoc == null;
			}

			// Token: 0x06000093 RID: 147 RVA: 0x0001753C File Offset: 0x0001573C
			internal static DelegateSupport.MethodSignature bg8qqeRX5ax5OhG0VaE()
			{
				return DelegateSupport.MethodSignature.UUNSNjRVpniW4qdLkoc;
			}

			// Token: 0x06000094 RID: 148 RVA: 0x0001754C File Offset: 0x0001574C
			internal static Type GndaO6RTgZf7xQHeRm0(object A_0, object A_1)
			{
				return jPM26DAnQfHunyInIhU.i2IAUFsOOC(A_0, A_1);
			}

			// Token: 0x06000095 RID: 149 RVA: 0x00017564 File Offset: 0x00015764
			internal static RuntimeTypeHandle aibVMwRFhPAdAIuSgdZ(object A_0, object A_1)
			{
				return du1ws7iq1lRxNm9OoMA.i2IAUFsOOC(A_0, A_1);
			}

			// Token: 0x06000096 RID: 150 RVA: 0x0001757C File Offset: 0x0001577C
			internal static object LiYtcXRKGbywYM81kmi(object A_0, object A_1)
			{
				return sLG6EQATwSiLRpKGREk.i2IAUFsOOC(A_0, A_1);
			}

			// Token: 0x06000097 RID: 151 RVA: 0x00017594 File Offset: 0x00015794
			internal static Type cDkpocR5VnU6mD9nOMA(object A_0, object A_1)
			{
				return axjPFwqt1vaYPQhZ6LC.i2IAUFsOOC(A_0, A_1);
			}

			// Token: 0x06000098 RID: 152 RVA: 0x000175AC File Offset: 0x000157AC
			internal static Type HNvF3tRngcR9Vsv86bc(object A_0, object A_1)
			{
				return a1EB98GAYivvl8q1XpE.i2IAUFsOOC(A_0, A_1);
			}

			// Token: 0x06000099 RID: 153 RVA: 0x000175C4 File Offset: 0x000157C4
			internal static bool APWoeBR3edciLBdQ3RO(Type A_0, Type A_1, object A_2)
			{
				return Q57NvyUKOvY5KovuDBT.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x0600009A RID: 154 RVA: 0x000175E0 File Offset: 0x000157E0
			internal static bool BMhd6eR1AVNW0BcRe0D(object A_0, object A_1, object A_2)
			{
				return XLEyvXISui46uUaIBn7.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x0600009B RID: 155 RVA: 0x000175FC File Offset: 0x000157FC
			internal static void YfWfIaRMet3kHN3wIvg()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0400000B RID: 11
			public readonly bool HasThis;

			// Token: 0x0400000C RID: 12
			public readonly bool ConstructedFromNative;

			// Token: 0x0400000D RID: 13
			private readonly IntPtr myReturnType;

			// Token: 0x0400000E RID: 14
			private readonly IntPtr[] myParameterTypes;

			// Token: 0x0400000F RID: 15
			private static DelegateSupport.MethodSignature UUNSNjRVpniW4qdLkoc;
		}

		// Token: 0x02000007 RID: 7
		private class Il2CppToMonoDelegateReference
		{
			// Token: 0x060000A9 RID: 169 RVA: 0x0001760C File Offset: 0x0001580C
			public Il2CppToMonoDelegateReference(Delegate referencedDelegate, IntPtr methodInfo)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				DelegateSupport.Il2CppToMonoDelegateReference.m4xroNkH1GWUZ5Ban9W();
				base..ctor();
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						this.ReferencedDelegate = referencedDelegate;
						num = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56c162609824bd799f0a7b9a8c33c89 != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					this.MethodInfo = methodInfo;
					num = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56a961858094410b8d2e4da57d386f1 == 0)
					{
						num = 1;
					}
				}
			}

			// Token: 0x060000AA RID: 170 RVA: 0x000176B0 File Offset: 0x000158B0
			// Note: this type is marked as 'beforefieldinit'.
			static Il2CppToMonoDelegateReference()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x060000AB RID: 171 RVA: 0x000176C0 File Offset: 0x000158C0
			internal static void m4xroNkH1GWUZ5Ban9W()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x060000AC RID: 172 RVA: 0x000176D0 File Offset: 0x000158D0
			internal static bool W0aNk0R4wJJoGZYugAZ()
			{
				return DelegateSupport.Il2CppToMonoDelegateReference.wAR1o1RpG9Kr9kIuL4X == null;
			}

			// Token: 0x060000AD RID: 173 RVA: 0x000176E4 File Offset: 0x000158E4
			internal static DelegateSupport.Il2CppToMonoDelegateReference gUVjpuRzVaJqAlX5FfS()
			{
				return DelegateSupport.Il2CppToMonoDelegateReference.wAR1o1RpG9Kr9kIuL4X;
			}

			// Token: 0x04000014 RID: 20
			public IntPtr MethodInfo;

			// Token: 0x04000015 RID: 21
			public object ReferencedDelegate;

			// Token: 0x04000016 RID: 22
			private static object wAR1o1RpG9Kr9kIuL4X;
		}
	}
}
