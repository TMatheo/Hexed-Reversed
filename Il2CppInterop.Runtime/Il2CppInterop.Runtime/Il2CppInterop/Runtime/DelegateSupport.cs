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
		// Token: 0x0600002E RID: 46 RVA: 0x000029B4 File Offset: 0x00000BB4
		public static Type GetOrCreateDelegateType(DelegateSupport.MethodSignature signature, MethodInfo managedMethod)
		{
			ConcurrentDictionary<DelegateSupport.MethodSignature, Type> concurrentDictionary = DelegateSupport.ourDelegateTypes;
			Func<DelegateSupport.MethodSignature, MethodInfo, Type> valueFactory;
			if ((valueFactory = DelegateSupport.<>c.<>9__5_0) == null)
			{
				valueFactory = (DelegateSupport.<>c.<>9__5_0 = (([Nullable(1)] DelegateSupport.MethodSignature signature, MethodInfo managedMethodInner) => DelegateSupport.<>c.L6xmm9VMqbDV5YU2VDl(managedMethodInner, signature.HasThis, signature.ConstructedFromNative)));
			}
			return concurrentDictionary.GetOrAdd<MethodInfo>(signature2, valueFactory, managedMethod);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000029F0 File Offset: 0x00000BF0
		private unsafe static Type CreateDelegateType(object managedMethodInner, bool addIntPtrForThis, bool addNamingDisambig)
		{
			int num = 14;
			TypeBuilder typeBuilder;
			for (;;)
			{
				int num2 = num;
				Type[] array;
				int num4;
				for (;;)
				{
					ParameterInfo[] array2;
					int num3;
					switch (num2)
					{
					case 1:
						DelegateSupport.j4P25AhVd8bish8ik8r(DelegateSupport.J8sIJChpymnZGRWiswA(typeBuilder, DelegateSupport.WtCPTbhtWZVOGYEWBWv(-550714233 >> 6 ^ -1076334739 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4356a7af7f8147b79f2ed4ab0c268438), MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, CallingConventions.HasThis, DelegateSupport.thPyAphJySP462n5lZo(managedMethodInner, C67uwgqiEvgqVW8owjp.qj1qwiCc4X).NativeType(), new Type[]
						{
							DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(IAsyncResult).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV)
						}, BYXhA2qEQdqeq1eI8YK.RcBqBVTZ4J), MethodImplAttributes.CodeTypeMask, zRrT13qGN5tCR8aX4nr.bIbqraxQgy);
						num2 = 16;
						continue;
					case 2:
						array[0] = KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(IntPtr).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV);
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_068b7dfa4ec449e7b5200030c1c277e5 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						array2 = DelegateSupport.ARGWgchbjqAReSO17tn(managedMethodInner, BliveCqCnt3Bq9RIiHL.EbUq9R3fXl);
						num2 = 11;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_892d6b14d02a4b94bf68e8edfebcd1f5 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						TlrPxnqMJSuQ1KwAFAh.muOq5LWqgj(DelegateSupport.kxQT2RhnRZQTTQQmWfb(typeBuilder, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName, CallingConventions.HasThis, new Type[]
						{
							DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(object).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV),
							DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(IntPtr).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV)
						}, GtQlqsqFHSMj09PkX1r.jWjqROFFvg), MethodImplAttributes.CodeTypeMask, TlrPxnqMJSuQ1KwAFAh.vsSqWyI4h0);
						num2 = 5;
						continue;
					case 5:
						goto IL_167;
					case 6:
						num3 = 0;
						num2 = 10;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_960a54aec0f640cd975b2d62f3e0a596 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 7:
						goto IL_6B;
					case 8:
						DelegateSupport.j4P25AhVd8bish8ik8r(BYXhA2qEQdqeq1eI8YK.muOq5LWqgj(typeBuilder, hIDAYxH6DWLHIthQgC.gSCeTtiku(-488741256 ^ -323678025 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_dd9c757bd882429784d62f0e80f112e6), MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, CallingConventions.HasThis, DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(IAsyncResult).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), array.Concat(new Type[]
						{
							KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(AsyncCallback).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV),
							DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(object).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV)
						}).ToArray<Type>(), BYXhA2qEQdqeq1eI8YK.RcBqBVTZ4J), MethodImplAttributes.CodeTypeMask, zRrT13qGN5tCR8aX4nr.bIbqraxQgy);
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b544c260d8647ebad150746ba137290 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 9:
						num3++;
						num2 = 12;
						continue;
					case 10:
						goto IL_B2;
					case 11:
						array = new Type[array2.Length + 1 + num4];
						num2 = 7;
						continue;
					case 12:
						goto IL_B2;
					case 13:
						DelegateSupport.WJys1yh8nRr3ZJNDb7q(typeBuilder, new CustomAttributeBuilder(DelegateSupport.ybKPTAhYqwCgHcdluyT(DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(UnmanagedFunctionPointerAttribute).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), new Type[]
						{
							KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(CallingConvention).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV)
						}, Fj0pGZq4FxSKcr9u2UH.QGxq3iFYNq), new object[]
						{
							CallingConvention.Cdecl
						}), LE4uTGqfdrbftuurhWL.ddHq1uWdcQ);
						num2 = 4;
						continue;
					case 14:
						typeBuilder = DelegateSupport.QgVImhhvTmBL9aSj277(DelegateSupport.ModuleBuilder, KUcPF8qN05KKuwdEiA1.muOq5LWqgj(DelegateSupport.WtCPTbhtWZVOGYEWBWv(2127728725 ^ 2061208140 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c26b4d3619a4457fb4121e194d9ef286), DelegateSupport.ExtractSignature(managedMethodInner), (!addIntPtrForThis) ? "" : DelegateSupport.WtCPTbhtWZVOGYEWBWv(--1918023945 ^ 1863084075 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ffe1ad8c1cf94bc78c25e67b0264547e), addNamingDisambig ? DelegateSupport.WtCPTbhtWZVOGYEWBWv(-1037388976 ^ 1897662843 ^ -2131694804 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6fe1694df7b94e7bbaa2aab21c6a82ec) : "", KUcPF8qN05KKuwdEiA1.R6Mqu5fmTH), TypeAttributes.Public | TypeAttributes.Sealed, KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(MulticastDelegate).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), EnfnQnq7HvWpY2y09Xe.svVqP6QoWG);
						num2 = 13;
						continue;
					case 15:
						goto IL_8C;
					case 16:
						goto IL_7F;
					case 17:
						DelegateSupport.j4P25AhVd8bish8ik8r(DelegateSupport.J8sIJChpymnZGRWiswA(typeBuilder, DelegateSupport.WtCPTbhtWZVOGYEWBWv(-191781671 ^ -1509425058 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb34a81d7cc4fbea898664370a8645f), MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Virtual | MethodAttributes.HideBySig | MethodAttributes.VtableLayoutMask, CallingConventions.HasThis, DelegateSupport.thPyAphJySP462n5lZo(managedMethodInner, C67uwgqiEvgqVW8owjp.qj1qwiCc4X).NativeType(), array, BYXhA2qEQdqeq1eI8YK.RcBqBVTZ4J), MethodImplAttributes.CodeTypeMask, zRrT13qGN5tCR8aX4nr.bIbqraxQgy);
						num2 = 8;
						continue;
					}
					goto Block_1;
					IL_8C:
					array[num3 + num4] = DelegateSupport.h7D08Jhy81eWyDYQAeM(DelegateSupport.d9xks1h6vO7RrIAfoUB(array2[num3], Ru3dbaqIKWq9Yf63MJb.CVKqd8MMF8));
					num2 = 9;
					continue;
					IL_B2:
					if (num3 < array2.Length)
					{
						goto IL_8C;
					}
					num2 = 17;
				}
				IL_6B:
				if (addIntPtrForThis)
				{
					num = 2;
					continue;
				}
				goto IL_296;
				IL_167:
				num4 = ((addIntPtrForThis > false) ? 1 : 0);
				num = 3;
				continue;
				IL_296:
				array[array.Length - 1] = KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Il2CppMethodInfo*).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV);
				num = 6;
				continue;
				Block_1:
				goto IL_296;
			}
			IL_7F:
			return DelegateSupport.nxaGUsh0Bs8pkPFyF21(typeBuilder, aBR5LPqTqhDZgK9xjFE.MpyqgFlfYx);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002E84 File Offset: 0x00001084
		private static string ExtractSignature(object methodInfo)
		{
			int num = 1;
			StringBuilder stringBuilder;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					ParameterInfo parameterInfo;
					int num3;
					switch (num2)
					{
					case 1:
						stringBuilder = new StringBuilder();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6dbfd13d96434eb59d868fecd0ad1cda == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						DelegateSupport.Wlyc81hS6ePdCpy9bom(stringBuilder, y1wUHLqoFyW6gbQN93u.muOq5LWqgj(DelegateSupport.d9xks1h6vO7RrIAfoUB(parameterInfo, Ru3dbaqIKWq9Yf63MJb.CVKqd8MMF8), y1wUHLqoFyW6gbQN93u.la8qUHBwms), m2eLpFqjHkNaRPiWsth.q85qQy67LK);
						num2 = 9;
						continue;
					case 3:
						goto IL_218;
					case 4:
						goto IL_15D;
					case 5:
						goto IL_14C;
					case 6:
						num3 = 0;
						num2 = 4;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b329e831708e4d29ae561982d3d8c1c1 == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 7:
						goto IL_5B;
					case 8:
						goto IL_15D;
					case 9:
						num3++;
						num2 = 4;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8b1b71d923f0486b89239dd4a11f6d34 == 0)
						{
							num2 = 8;
							continue;
						}
						continue;
					case 10:
						DelegateSupport.yMuYmVhutAkRC9For2s(stringBuilder, '_', L3pNC5qaYklcQpPam6c.HaqqZExIA8);
						num2 = 2;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_508916f527eb4b05b32762ef07dd9e52 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 11:
						if (!DelegateSupport.BuWGHQhN7jjbNEOfX8p(methodInfo, Y856w6qe4qUMTGoZo0c.HLaqK56mpw))
						{
							num2 = 3;
							continue;
						}
						goto IL_D5;
					case 12:
						m2eLpFqjHkNaRPiWsth.muOq5LWqgj(stringBuilder, DelegateSupport.Jb14YBhsFgFyB2xaBhO(DelegateSupport.P4Hf5ihDC9l3f4s4MOB(methodInfo, RO0g2Vqz1eEynR0MNrr.f6M5lgRiE7), y1wUHLqoFyW6gbQN93u.la8qUHBwms), m2eLpFqjHkNaRPiWsth.q85qQy67LK);
						num2 = 13;
						continue;
					case 13:
						goto IL_D5;
					}
					DelegateSupport.Wlyc81hS6ePdCpy9bom(stringBuilder, DelegateSupport.Jb14YBhsFgFyB2xaBhO(DelegateSupport.thPyAphJySP462n5lZo(methodInfo, C67uwgqiEvgqVW8owjp.qj1qwiCc4X), y1wUHLqoFyW6gbQN93u.la8qUHBwms), m2eLpFqjHkNaRPiWsth.q85qQy67LK);
					num2 = 11;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e6eb36653ec04a89bf8fa64932849f3b == 0)
					{
						num2 = 11;
						continue;
					}
					continue;
					IL_D5:
					ParameterInfo[] array = DelegateSupport.ARGWgchbjqAReSO17tn(methodInfo, BliveCqCnt3Bq9RIiHL.EbUq9R3fXl);
					num2 = 6;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c26b4d3619a4457fb4121e194d9ef286 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_14C:
					parameterInfo = array[num3];
					num2 = 10;
					continue;
					IL_15D:
					if (num3 < array.Length)
					{
						goto IL_14C;
					}
					num2 = 7;
				}
				IL_218:
				DelegateSupport.yMuYmVhutAkRC9For2s(stringBuilder, '_', L3pNC5qaYklcQpPam6c.HaqqZExIA8);
				num = 12;
			}
			IL_5B:
			return DelegateSupport.GF7xxYhmtBRZXGbvLPf(stringBuilder, Wp12YC5qLpXaitTqQ38.MHi55JM3O7);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000030C8 File Offset: 0x000012C8
		private static Delegate GetOrCreateNativeToManagedTrampoline(object signature, object nativeMethod, object managedMethod)
		{
			return DelegateSupport.NativeToManagedTrampolines.GetOrAdd<ValueTuple<MethodInfo, MethodInfo, DelegateSupport.MethodSignature>>(managedMethod, ([Nullable(1)] MethodInfo _, [TupleElementNames(new string[]
			{
				"nativeMethod",
				"managedMethod",
				"signature"
			})] ValueTuple<MethodInfo, MethodInfo, DelegateSupport.MethodSignature> tuple) => DelegateSupport.GenerateNativeToManagedTrampoline(tuple.Item1, tuple.Item2, tuple.Item3), new ValueTuple<MethodInfo, MethodInfo, DelegateSupport.MethodSignature>(nativeMethod, managedMethod, signature));
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003108 File Offset: 0x00001308
		public static object GetRef(IntPtr pointer)
		{
			int num = 3;
			int num2 = num;
			DelegateSupport.Il2CppToMonoDelegateReference result;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_BB;
				case 2:
					DelegateSupport.S7dtNyh7fV0YWTXjci7(DelegateSupport.WtCPTbhtWZVOGYEWBWv(-251168399 << 1 ^ -256124583 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7ac65c3fd4cb4629a8b893be89aed17d));
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_575f8bd7bfb04e37800ff009689b44f6 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					if (!DelegateSupport.NativeToManagedTrampoline.TryGetValue(pointer, out result))
					{
						num2 = 2;
						continue;
					}
					break;
				}
				break;
			}
			return result;
			IL_BB:
			return IntPtr.Zero;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000031DC File Offset: 0x000013DC
		private unsafe static Delegate GenerateNativeToManagedTrampoline(object nativeMethod, object managedMethod, object signature)
		{
			int num = 48;
			DynamicMethod dynamicMethod;
			for (;;)
			{
				int num2 = num;
				ILGenerator ilgenerator;
				Label label3;
				int num3;
				ParameterInfo[] array;
				Type[] array2;
				for (;;)
				{
					LocalBuilder localBuilder;
					Type type;
					LocalBuilder localBuilder2;
					int num4;
					Type type2;
					switch (num2)
					{
					case 0:
						goto IL_97A;
					case 1:
						goto IL_8CD;
					case 2:
					{
						Label label;
						PAXvTU5FWGeXyTZ4W8Y.muOq5LWqgj(ilgenerator, label, PAXvTU5FWGeXyTZ4W8Y.f3V5RejoXi);
						num2 = 63;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5a2f191df3714123bdeb9f5f4b416da9 != 0)
						{
							num2 = 11;
							continue;
						}
						continue;
					}
					case 3:
						DelegateSupport.DRhY0ahGnTswCSsKK6W(ilgenerator, OpCodes.Ldstr, DelegateSupport.WtCPTbhtWZVOGYEWBWv(-1817151529 ^ -690462119 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6dbfd13d96434eb59d868fecd0ad1cda), NHuG3T5TPIER7uS3ECl.tlx5gASR4G);
						num2 = 4;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6a95c50bbb48420f8f11bb090d6d3bd5 == 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					case 4:
						goto IL_859;
					case 5:
						DelegateSupport.KafqLth16U8OIk59IlJ(ilgenerator, OpCodes.Call, DnZ9sC5vW5Zmyo7jjbr.muOq5LWqgj(DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(DelegateSupport).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), DelegateSupport.WtCPTbhtWZVOGYEWBWv(-1650106468 ^ -344701916 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_960a54aec0f640cd975b2d62f3e0a596), DnZ9sC5vW5Zmyo7jjbr.gLJ5xeKxO6), nlOWSv5YwlZX9e40I0P.h1i58mR3Ok);
						num2 = 51;
						continue;
					case 6:
						DelegateSupport.QiaQ6dhE2YHmRFf3oZR(ilgenerator, OpCodes.Ldloc, localBuilder, w0HxWS5EDl8tYs1LbZu.U1S5B4WCyj);
						num2 = 21;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_960a54aec0f640cd975b2d62f3e0a596 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 7:
					{
						Label label2 = CXapgn5DZ1qP6THOsuy.muOq5LWqgj(ilgenerator, CXapgn5DZ1qP6THOsuy.uAa5mOslq9);
						num2 = 52;
						continue;
					}
					case 8:
						goto IL_8AD;
					case 9:
						localBuilder2 = DelegateSupport.KiSCtAhwJIJJKn1SlIa(ilgenerator, type, SQM72H5ivMmDwrxZbaU.mLQ5wcKm9x);
						num2 = 40;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae == 0)
						{
							num2 = 28;
							continue;
						}
						continue;
					case 10:
						if (!CiJop65IqHJCv8k5I3G.muOq5LWqgj(type, DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(void).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), CiJop65IqHJCv8k5I3G.Lvb5dhFO0X))
						{
							goto IL_BBE;
						}
						num2 = 6;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b82ae23c6544f3a11e54f2fed3ad25 != 0)
						{
							num2 = 9;
							continue;
						}
						continue;
					case 11:
						DelegateSupport.KafqLth16U8OIk59IlJ(ilgenerator, OpCodes.Call, DelegateSupport.lx8Qiihi7EgyGsRpwal(lTMlDY5MgBNHIiWbcsQ.muOq5LWqgj(DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(Il2CppObjectBase).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), DelegateSupport.WtCPTbhtWZVOGYEWBWv(407862330 ^ 1154098120 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6d7a22a8da0c4b3e8cf479dd7edc9922), lTMlDY5MgBNHIiWbcsQ.RvV5WZYWpe), FaKxy95CO6Z2TevxwVr.RRS59HDAaL), nlOWSv5YwlZX9e40I0P.h1i58mR3Ok);
						num2 = 36;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b55404cff7864ea3949f7b4156fd6ee5 != 0)
						{
							num2 = 17;
							continue;
						}
						continue;
					case 12:
						DelegateSupport.nO8Kp9hIRsZf2qlEIvl(ilgenerator, label3, PAXvTU5FWGeXyTZ4W8Y.f3V5RejoXi);
						num2 = 43;
						continue;
					case 13:
						sWLRHR5OB7hMDvnerut.muOq5LWqgj(ilgenerator, OpCodes.Nop, sWLRHR5OB7hMDvnerut.sr65tXjFly);
						num2 = 53;
						continue;
					case 14:
					{
						Label label2;
						DelegateSupport.ncqQkRh9IYiKe6HCXIH(ilgenerator, OpCodes.Br, label2, pNreXN57CQsH91V5Xqd.RUL5PQSWZy);
						num2 = 2;
						continue;
					}
					case 15:
						nlOWSv5YwlZX9e40I0P.muOq5LWqgj(ilgenerator, OpCodes.Call, DelegateSupport.atUlX2hWOHdH0h8KHqx(DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(IL2CPP).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), DelegateSupport.WtCPTbhtWZVOGYEWBWv(-2123647538 ^ -1927306000 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b9b6cd6cbc040a7be58cff054f9e843), DnZ9sC5vW5Zmyo7jjbr.gLJ5xeKxO6), nlOWSv5YwlZX9e40I0P.h1i58mR3Ok);
						num2 = 68;
						continue;
					case 16:
						goto IL_327;
					case 17:
						break;
					case 18:
						DelegateSupport.nateMBhfk2aePGwEtFt(ilgenerator, OpCodes.Pop, sWLRHR5OB7hMDvnerut.sr65tXjFly);
						num2 = 44;
						continue;
					case 19:
						DelegateSupport.KafqLth16U8OIk59IlJ(ilgenerator, OpCodes.Call, HgxrhB5oPtQCiFPtUWn.muOq5LWqgj(DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(string).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), hIDAYxH6DWLHIthQgC.gSCeTtiku(-573568561 ^ -340551595 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_508916f527eb4b05b32762ef07dd9e52), new Type[]
						{
							KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(string).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV),
							DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(string).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV)
						}, HgxrhB5oPtQCiFPtUWn.CfI5UWvpOl), nlOWSv5YwlZX9e40I0P.h1i58mR3Ok);
						num2 = 34;
						continue;
					case 20:
						goto IL_859;
					case 21:
						DelegateSupport.KafqLth16U8OIk59IlJ(ilgenerator, OpCodes.Callvirt, DelegateSupport.atUlX2hWOHdH0h8KHqx(DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(object).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), DelegateSupport.WtCPTbhtWZVOGYEWBWv(1047008524 ^ 1849393879 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4da80845ebf7410ebbf942336f5ee27b), DnZ9sC5vW5Zmyo7jjbr.gLJ5xeKxO6), nlOWSv5YwlZX9e40I0P.h1i58mR3Ok);
						num2 = 19;
						continue;
					case 22:
						goto IL_A3F;
					case 23:
						IqYhv65e68Tfe96GdQj.muOq5LWqgj(ilgenerator, IqYhv65e68Tfe96GdQj.uhq5KZwMmy);
						num2 = 72;
						continue;
					case 24:
					{
						Label label4 = DelegateSupport.rdxnZwhdbC5mkP8SgD9(ilgenerator, CXapgn5DZ1qP6THOsuy.uAa5mOslq9);
						num2 = 31;
						continue;
					}
					case 25:
						goto IL_9E5;
					case 26:
						DelegateSupport.nateMBhfk2aePGwEtFt(ilgenerator, OpCodes.Conv_I, sWLRHR5OB7hMDvnerut.sr65tXjFly);
						num2 = 12;
						continue;
					case 27:
						goto IL_9E5;
					case 28:
						if (!JCwQlA5sGlTyuRZuORY.muOq5LWqgj(type, DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(string).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), JCwQlA5sGlTyuRZuORY.fqC5SwdxA5))
						{
							num2 = 39;
							continue;
						}
						goto IL_681;
					case 29:
						num3++;
						num2 = 4;
						continue;
					case 30:
						sWLRHR5OB7hMDvnerut.muOq5LWqgj(ilgenerator, OpCodes.Dup, sWLRHR5OB7hMDvnerut.sr65tXjFly);
						num2 = 59;
						continue;
					case 31:
						label3 = CXapgn5DZ1qP6THOsuy.muOq5LWqgj(ilgenerator, CXapgn5DZ1qP6THOsuy.uAa5mOslq9);
						num2 = 3;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_07ecbd0ef7af44eb94dd5a58ea706c8a == 0)
						{
							num2 = 30;
							continue;
						}
						continue;
					case 32:
						DelegateSupport.NXGY0PhR0lfI8kG8nVB(ilgenerator, OpCodes.Ldarg, num4 + 1, Co14wF5VcZMbUqSsQj7.y3K50tZMm4);
						num2 = 11;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ffe1ad8c1cf94bc78c25e67b0264547e != 0)
						{
							num2 = 71;
							continue;
						}
						continue;
					case 33:
						DelegateSupport.nateMBhfk2aePGwEtFt(ilgenerator, OpCodes.Nop, sWLRHR5OB7hMDvnerut.sr65tXjFly);
						num2 = 41;
						continue;
					case 34:
						DelegateSupport.KafqLth16U8OIk59IlJ(ilgenerator, OpCodes.Call, DelegateSupport.LaJJb1hrwv5PxlcnDQD(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(DelegateSupport).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), DelegateSupport.WtCPTbhtWZVOGYEWBWv(1147518606 ^ 417390640 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6d7a22a8da0c4b3e8cf479dd7edc9922), BindingFlags.Static | BindingFlags.NonPublic, Tx2H9W5jh73cqTPUdxk.lXO5Q505ZS), nlOWSv5YwlZX9e40I0P.h1i58mR3Ok);
						num2 = 23;
						continue;
					case 35:
						num3 = 0;
						num2 = 20;
						continue;
					case 36:
						goto IL_55A;
					case 37:
					{
						Label label4;
						PAXvTU5FWGeXyTZ4W8Y.muOq5LWqgj(ilgenerator, label4, PAXvTU5FWGeXyTZ4W8Y.f3V5RejoXi);
						num2 = 18;
						continue;
					}
					case 38:
						goto IL_1A9;
					case 39:
						goto IL_BE5;
					case 40:
						DelegateSupport.QiaQ6dhE2YHmRFf3oZR(ilgenerator, OpCodes.Stloc, localBuilder2, w0HxWS5EDl8tYs1LbZu.U1S5B4WCyj);
						num2 = 73;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eeb967463afe407d8f7c3b354043704c == 0)
						{
							num2 = 62;
							continue;
						}
						continue;
					case 41:
						DelegateSupport.nateMBhfk2aePGwEtFt(ilgenerator, OpCodes.Ldarg_0, sWLRHR5OB7hMDvnerut.sr65tXjFly);
						num2 = 5;
						continue;
					case 42:
						goto IL_35F;
					case 43:
						goto IL_8CD;
					case 44:
						DelegateSupport.nateMBhfk2aePGwEtFt(ilgenerator, OpCodes.Ldc_I4_0, sWLRHR5OB7hMDvnerut.sr65tXjFly);
						num2 = 26;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b82ae23c6544f3a11e54f2fed3ad25 == 0)
						{
							num2 = 17;
							continue;
						}
						continue;
					case 45:
						XDXsAI5JhviMqbZ85AS.muOq5LWqgj(ilgenerator, OpCodes.Ldfld, DelegateSupport.BBXmJ7hFGmnLDGN0KU9(DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(DelegateSupport.Il2CppToMonoDelegateReference).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), DelegateSupport.WtCPTbhtWZVOGYEWBWv(-1090272335 << 3 ^ -217932686 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e6eb36653ec04a89bf8fa64932849f3b), MAorCg56yGa3HPtjiY3.iVx5yLylyX), XDXsAI5JhviMqbZ85AS.RAX5p2dieA);
						num2 = 58;
						continue;
					case 46:
						DelegateSupport.Tqv2klhBii37TPjV2cv(ilgenerator, DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(Exception).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), Q0258C5GfvUnEmUbGUk.yQC5rb0Ho7);
						num2 = 46;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b544c260d8647ebad150746ba137290 != 0)
						{
							num2 = 55;
							continue;
						}
						continue;
					case 47:
						array = BliveCqCnt3Bq9RIiHL.muOq5LWqgj(managedMethod, BliveCqCnt3Bq9RIiHL.EbUq9R3fXl);
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7fef7bb77728417ab4965dd0775b5899 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 48:
						type = DelegateSupport.h7D08Jhy81eWyDYQAeM(C67uwgqiEvgqVW8owjp.muOq5LWqgj(managedMethod, C67uwgqiEvgqVW8owjp.qj1qwiCc4X));
						num2 = 47;
						continue;
					case 49:
					{
						Label label = CXapgn5DZ1qP6THOsuy.muOq5LWqgj(ilgenerator, CXapgn5DZ1qP6THOsuy.uAa5mOslq9);
						num2 = 7;
						continue;
					}
					case 50:
						goto IL_9A5;
					case 51:
						jVPCDT5ng9KYNuYJDSc.muOq5LWqgj(ilgenerator, OpCodes.Castclass, DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(DelegateSupport.Il2CppToMonoDelegateReference).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), jVPCDT5ng9KYNuYJDSc.Li15bXtDZ7);
						num2 = 45;
						continue;
					case 52:
					{
						Label label;
						pNreXN57CQsH91V5Xqd.muOq5LWqgj(ilgenerator, OpCodes.Brfalse, label, pNreXN57CQsH91V5Xqd.RUL5PQSWZy);
						num2 = 32;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2a3cb7fb82fa47c39f707a2393c1a340 == 0)
						{
							num2 = 12;
							continue;
						}
						continue;
					}
					case 53:
						sWLRHR5OB7hMDvnerut.muOq5LWqgj(ilgenerator, OpCodes.Nop, sWLRHR5OB7hMDvnerut.sr65tXjFly);
						num2 = 33;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae == 0)
						{
							num2 = 17;
							continue;
						}
						continue;
					case 54:
						ilgenerator = DelegateSupport.nphgRlh4dO36biFrjHr(dynamicMethod, dr5pjw5kUmWnx1oVRTn.pod52cShcT);
						num2 = 56;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c975b252adfc48c4b262398638f90354 != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 55:
						DelegateSupport.QiaQ6dhE2YHmRFf3oZR(ilgenerator, OpCodes.Stloc, localBuilder, w0HxWS5EDl8tYs1LbZu.U1S5B4WCyj);
						num2 = 3;
						continue;
					case 56:
						DelegateSupport.RPi47Ch3CyFwFvcf8CZ(ilgenerator, n2KuiL5HdJx815IA8On.I7Q5h8MC7M);
						num2 = 13;
						continue;
					case 57:
						if (DelegateSupport.loFdWNhMkGZL66N1jJo(type2, DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(string).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), JCwQlA5sGlTyuRZuORY.fqC5SwdxA5))
						{
							goto Block_5;
						}
						goto IL_CB0;
					case 58:
						num4 = 0;
						num2 = 62;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4356a7af7f8147b79f2ed4ab0c268438 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 59:
					{
						Label label4;
						DelegateSupport.ncqQkRh9IYiKe6HCXIH(ilgenerator, OpCodes.Brfalse, label4, pNreXN57CQsH91V5Xqd.RUL5PQSWZy);
						num2 = 11;
						continue;
					}
					case 60:
					{
						Label label2;
						DelegateSupport.nO8Kp9hIRsZf2qlEIvl(ilgenerator, label2, PAXvTU5FWGeXyTZ4W8Y.f3V5RejoXi);
						num2 = 74;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_dd9c757bd882429784d62f0e80f112e6 == 0)
						{
							num2 = 67;
							continue;
						}
						continue;
					}
					case 61:
						goto IL_681;
					case 62:
						goto IL_718;
					case 63:
						DelegateSupport.nateMBhfk2aePGwEtFt(ilgenerator, OpCodes.Ldnull, sWLRHR5OB7hMDvnerut.sr65tXjFly);
						num2 = 60;
						continue;
					case 64:
						goto IL_CB0;
					case 65:
						goto IL_718;
					case 66:
						goto IL_35F;
					case 67:
						goto IL_289;
					case 68:
						goto IL_B48;
					case 69:
						goto IL_BE5;
					case 70:
						array2[0] = KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(IntPtr).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV);
						num2 = 43;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_68cafcd7c4d444e39c183fde29795ee9 == 0)
						{
							num2 = 76;
							continue;
						}
						continue;
					case 71:
						UHLYWh5fwXimKj8H332.muOq5LWqgj(ilgenerator, OpCodes.Newobj, acurH454kQoe5Lch99S.muOq5LWqgj(type2, new Type[]
						{
							DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(IntPtr).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV)
						}, acurH454kQoe5Lch99S.yqo53muOE4), UHLYWh5fwXimKj8H332.WjH515pX3x);
						num2 = 9;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3f609fad0bcc47d79d3add6a492d3616 == 0)
						{
							num2 = 14;
							continue;
						}
						continue;
					case 72:
						if (localBuilder2 == null)
						{
							num2 = 66;
							continue;
						}
						break;
					case 73:
						goto IL_BBE;
					case 74:
						goto IL_B48;
					case 75:
						DelegateSupport.NXGY0PhR0lfI8kG8nVB(ilgenerator, OpCodes.Ldarg, num4 + 1, Co14wF5VcZMbUqSsQj7.y3K50tZMm4);
						num2 = 57;
						continue;
					case 76:
						goto IL_8DA;
					default:
						goto IL_97A;
					}
					DelegateSupport.QiaQ6dhE2YHmRFf3oZR(ilgenerator, OpCodes.Ldloc, localBuilder2, w0HxWS5EDl8tYs1LbZu.U1S5B4WCyj);
					num2 = 42;
					continue;
					IL_289:
					DelegateSupport.KafqLth16U8OIk59IlJ(ilgenerator, OpCodes.Call, managedMethod, nlOWSv5YwlZX9e40I0P.h1i58mR3Ok);
					num2 = 28;
					continue;
					IL_718:
					if (num4 >= array.Length)
					{
						goto IL_289;
					}
					num2 = 27;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7fef7bb77728417ab4965dd0775b5899 == 0)
					{
						num2 = 26;
						continue;
					}
					continue;
					IL_35F:
					sWLRHR5OB7hMDvnerut.muOq5LWqgj(ilgenerator, OpCodes.Ret, sWLRHR5OB7hMDvnerut.sr65tXjFly);
					num2 = 38;
					continue;
					IL_681:
					DelegateSupport.KafqLth16U8OIk59IlJ(ilgenerator, OpCodes.Call, DelegateSupport.atUlX2hWOHdH0h8KHqx(DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(IL2CPP).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), DelegateSupport.WtCPTbhtWZVOGYEWBWv(-1762404681 ^ -570594745 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bac7568f2bc04130b6b980225b2cc409), DnZ9sC5vW5Zmyo7jjbr.gLJ5xeKxO6), nlOWSv5YwlZX9e40I0P.h1i58mR3Ok);
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_960a54aec0f640cd975b2d62f3e0a596 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_859:
					if (num3 >= array.Length)
					{
						goto IL_A3F;
					}
					num2 = 2;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c04403f838344b38b3a8911774a446ea != 0)
					{
						num2 = 8;
						continue;
					}
					continue;
					IL_8CD:
					localBuilder2 = null;
					num2 = 10;
					continue;
					IL_BE5:
					if (!iAjcxl5NRwJWXWxUcfF.muOq5LWqgj(type, iAjcxl5NRwJWXWxUcfF.jEX5uAuA4B))
					{
						num2 = 24;
						continue;
					}
					goto IL_8CD;
					IL_97A:
					tTd7Ix5AbpqY0IcwJ37.muOq5LWqgj(nativeMethod, tTd7Ix5AbpqY0IcwJ37.QbC5LHCejO);
					num2 = 16;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ecb3ec1520014011821df145fb87d517 != 0)
					{
						num2 = 7;
						continue;
					}
					continue;
					IL_9E5:
					type2 = Ru3dbaqIKWq9Yf63MJb.muOq5LWqgj(array[num4], Ru3dbaqIKWq9Yf63MJb.CVKqd8MMF8);
					num2 = 75;
					continue;
					IL_A3F:
					dynamicMethod = new DynamicMethod(uLfVht5XqcdpSvFumbD.muOq5LWqgj(DelegateSupport.WtCPTbhtWZVOGYEWBWv(373277451 ^ 1181505350 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4da80845ebf7410ebbf942336f5ee27b), DelegateSupport.T9GaFDhPrs42gYAxQhm(managedMethod), uLfVht5XqcdpSvFumbD.YFG5cZFN0S), MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static, CallingConventions.Standard, type, array2, KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(DelegateSupport).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), true);
					num2 = 54;
					continue;
					IL_B48:
					num4++;
					num2 = 65;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4c6a46c0a2d14747aa1dc5bf1581154d != 0)
					{
						num2 = 10;
						continue;
					}
					continue;
					IL_CB0:
					if (!DelegateSupport.TaqriJhCq2XpFUUjPmL(type2, iAjcxl5NRwJWXWxUcfF.jEX5uAuA4B))
					{
						num2 = 49;
						continue;
					}
					goto IL_B48;
					IL_BBE:
					localBuilder = DelegateSupport.KiSCtAhwJIJJKn1SlIa(ilgenerator, KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Exception).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), SQM72H5ivMmDwrxZbaU.mLQ5wcKm9x);
					num2 = 46;
				}
				Block_5:
				num = 15;
				continue;
				IL_327:
				array2 = new Type[array.Length + 1 + 1];
				num = 70;
				continue;
				IL_55A:
				DelegateSupport.ncqQkRh9IYiKe6HCXIH(ilgenerator, OpCodes.Br, label3, pNreXN57CQsH91V5Xqd.RUL5PQSWZy);
				num = 37;
				continue;
				IL_8DA:
				array2[array.Length + 1] = DelegateSupport.PMQ05Rhx5qM3qUw0Srs(typeof(Il2CppMethodInfo*).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV);
				num = 35;
				continue;
				IL_9A5:
				array2[num3 + 1] = DelegateSupport.h7D08Jhy81eWyDYQAeM(DelegateSupport.d9xks1h6vO7RrIAfoUB(array[num3], Ru3dbaqIKWq9Yf63MJb.CVKqd8MMF8));
				num = 29;
				continue;
				IL_8AD:
				goto IL_9A5;
			}
			IL_1A9:
			return DelegateSupport.Dy7vRhhTcZRlob3sjfk(dynamicMethod, DelegateSupport.GetOrCreateDelegateType(signature, managedMethod), RXPjpP5aBG6EjiAFu8c.rSD5ZZujmu);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003FBC File Offset: 0x000021BC
		private static void LogError(object message)
		{
			DelegateSupport.S7dtNyh7fV0YWTXjci7(message);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003FCC File Offset: 0x000021CC
		public unsafe static TIl2Cpp ConvertDelegate<TIl2Cpp>(Delegate @delegate) where TIl2Cpp : Il2CppObjectBase
		{
			if (@delegate == null)
			{
				return default(TIl2Cpp);
			}
			if (!LQUO1O5zLvD95E2LLPK.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Delegate).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(TIl2Cpp).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), LQUO1O5zLvD95E2LLPK.S3EAleLciW))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(TIl2Cpp).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV));
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(~-1542388374 ^ 590028138 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_856ffe7e0c9b4de88d71070d175d49fd), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				throw new ArgumentException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
			}
			MethodInfo methodInfo = tfA34cAA5e4rRlJaZ9c.muOq5LWqgj(xyOWutAqDih6hgfZh8A.muOq5LWqgj(@delegate, xyOWutAqDih6hgfZh8A.kn1A5ABE1Q), hIDAYxH6DWLHIthQgC.gSCeTtiku(106916134 + 835889755 ^ 713505274 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7ac65c3fd4cb4629a8b893be89aed17d), tfA34cAA5e4rRlJaZ9c.gWCALdH9MJ);
			ParameterInfo[] array = BliveCqCnt3Bq9RIiHL.muOq5LWqgj(methodInfo, BliveCqCnt3Bq9RIiHL.EbUq9R3fXl);
			ParameterInfo[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				Type type = Ru3dbaqIKWq9Yf63MJb.muOq5LWqgj(array2[i], Ru3dbaqIKWq9Yf63MJb.CVKqd8MMF8);
				if (iArNNMAXqKAVpiQpoAR.muOq5LWqgj(type, iArNNMAXqKAVpiQpoAR.fkgAcoXZRp))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(70, 1);
					gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-225340272 ^ -133920271 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_420bdc7f003c47439a9f8331e71194a1), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
					defaultInterpolatedStringHandler.AppendFormatted<Type>(type);
					gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-794732516 ^ -1298877465 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_575f8bd7bfb04e37800ff009689b44f6), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
					throw new ArgumentException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
				}
				if (JCwQlA5sGlTyuRZuORY.muOq5LWqgj(sxYvEPAkSQfHMoJIih4.muOq5LWqgj(type, sxYvEPAkSQfHMoJIih4.GLiA2wflMe), KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(ValueType).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), JCwQlA5sGlTyuRZuORY.fqC5SwdxA5))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(77, 1);
					gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-930778244 >> 6 ^ -378243798 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b329e831708e4d29ae561982d3d8c1c1), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
					defaultInterpolatedStringHandler.AppendFormatted<Type>(type);
					gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-257240942 ^ -456100601 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ac2c10c141e144acbcef06aa86a10430), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
					throw new ArgumentException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
				}
			}
			IntPtr nativeClassPointer = Il2CppClassPointerStore.GetNativeClassPointer(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(TIl2Cpp).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV));
			if (nativeClassPointer == IntPtr.Zero)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(37, 1);
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(2056095481 >> 1 ^ 1230951589 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2a3cb7fb82fa47c39f707a2393c1a340), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(TIl2Cpp).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV));
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-579874071 + 1102803655 ^ 1262513735 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b5e8e4146b4a178d711afdb1274991), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				throw new ArgumentException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
			}
			MethodInfo methodInfo2 = RdhG6TAOs4NdIBC6Pim.muOq5LWqgj(UesPrPAH73jB0XWSnsx.muOq5LWqgj(IL2CPP.il2cpp_class_get_type(nativeClassPointer), UesPrPAH73jB0XWSnsx.bGYAhJSFUo), hIDAYxH6DWLHIthQgC.gSCeTtiku(1651941374 ^ 1813899553 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_dd9c757bd882429784d62f0e80f112e6), RdhG6TAOs4NdIBC6Pim.LQBAtOIppM);
			Il2CppReferenceArray<ParameterInfo> il2CppReferenceArray = tTd7Ix5AbpqY0IcwJ37.muOq5LWqgj(methodInfo2, tTd7Ix5AbpqY0IcwJ37.QbC5LHCejO);
			if (il2CppReferenceArray.Count != array.Length)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(65, 2);
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1762404681 ^ -1429351678 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b544c260d8647ebad150746ba137290), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				defaultInterpolatedStringHandler.AppendFormatted<int>(array.Length);
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-226554387 ^ -2031560981 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8378a46aa7ed47018832a42729b1bc3b), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				defaultInterpolatedStringHandler.AppendFormatted<int>(il2CppReferenceArray.Count);
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1371503382 + -1420905238 ^ -1448677807 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e5b00aa4c99144c78d3bd63e270496cb), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				throw new ArgumentException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
			}
			for (int j = 0; j < il2CppReferenceArray.Count; j++)
			{
				Type type2 = qnjRS7AvBUm3itUmewL.muOq5LWqgj(il2CppReferenceArray[j], qnjRS7AvBUm3itUmewL.L8oAxe6K2f);
				Type type3 = Ru3dbaqIKWq9Yf63MJb.muOq5LWqgj(array[j], Ru3dbaqIKWq9Yf63MJb.CVKqd8MMF8);
				if (MGuSpaAYB4m4IElADWy.muOq5LWqgj(type2, MGuSpaAYB4m4IElADWy.J7yA8yF2Vp) || O89uLpAnm1WpPc87QBx.muOq5LWqgj(type3, O89uLpAnm1WpPc87QBx.vPZAb56ULa))
				{
					if (Qb3kHiAJfQfbhOqjpaj.muOq5LWqgj(mEq7xVA6GE8jwv5yObv.muOq5LWqgj(type2, mEq7xVA6GE8jwv5yObv.EdvAyBXNgg), y1wUHLqoFyW6gbQN93u.muOq5LWqgj(type3, y1wUHLqoFyW6gbQN93u.la8qUHBwms), Qb3kHiAJfQfbhOqjpaj.KIMApEklig))
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 3);
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(~724514004 ^ -2042009030 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb34a81d7cc4fbea898664370a8645f), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						defaultInterpolatedStringHandler.AppendFormatted<int>(j);
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(~-968942365 ^ 473226740 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b169d8ea412f45e99e430384ddc8908b), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, mEq7xVA6GE8jwv5yObv.muOq5LWqgj(type2, mEq7xVA6GE8jwv5yObv.EdvAyBXNgg), CbStEuAV6XsjbRRcotu.WZrA06bJrN);
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(~403127912 ^ -1535484208 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c04403f838344b38b3a8911774a446ea), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, y1wUHLqoFyW6gbQN93u.muOq5LWqgj(type3, y1wUHLqoFyW6gbQN93u.la8qUHBwms), CbStEuAV6XsjbRRcotu.WZrA06bJrN);
						throw new ArgumentException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
					}
				}
				else
				{
					IntPtr intPtr = (IntPtr)VMBgfWADmN0iq7FkmgY.muOq5LWqgj(POARFTAN57TXPU9bLlO.muOq5LWqgj(vOp1rUAs3HqOX2RyvZZ.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Il2CppClassPointerStore<>).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), new Type[]
					{
						type3
					}, vOp1rUAs3HqOX2RyvZZ.WNkASUA3Cp), hIDAYxH6DWLHIthQgC.gSCeTtiku(-149247767 ^ -756115947 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b169d8ea412f45e99e430384ddc8908b), POARFTAN57TXPU9bLlO.Km5AuuYbF0), null, VMBgfWADmN0iq7FkmgY.stdAmTGDqJ);
					IntPtr intPtr2 = IL2CPP.il2cpp_class_from_type(Wruo9gA7CtinPlpnGZZ.muOq5LWqgj(type2, Wruo9gA7CtinPlpnGZZ.w6qAP8Ns6p).value);
					if (intPtr != intPtr2)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(67, 3);
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(811079790 ^ 749043221 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eeb967463afe407d8f7c3b354043704c), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						defaultInterpolatedStringHandler.AppendFormatted<int>(j);
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1147518606 ^ 1333344432 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e6eb36653ec04a89bf8fa64932849f3b), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, mEq7xVA6GE8jwv5yObv.muOq5LWqgj(type2, mEq7xVA6GE8jwv5yObv.EdvAyBXNgg), CbStEuAV6XsjbRRcotu.WZrA06bJrN);
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1129513093 ^ 2090284095 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, y1wUHLqoFyW6gbQN93u.muOq5LWqgj(type3, y1wUHLqoFyW6gbQN93u.la8qUHBwms), CbStEuAV6XsjbRRcotu.WZrA06bJrN);
						throw new ArgumentException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
					}
					if (FFfs34A4ogRK54LLpFm.muOq5LWqgj(type2, FFfs34A4ogRK54LLpFm.zWpA3UQXNl) || BD4fpgAfbgEWuCwmKMc.muOq5LWqgj(type3, BD4fpgAfbgEWuCwmKMc.ktpA11NTFq))
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(59, 1);
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1313584813 ^ 1920315830 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b544c260d8647ebad150746ba137290), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						defaultInterpolatedStringHandler.AppendFormatted<int>(j);
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(252875202 ^ 722579779 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0ec1d35577cb488fb4bdfc9810c6c86f), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						throw new ArgumentException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
					}
				}
			}
			Delegate orCreateNativeToManagedTrampoline = DelegateSupport.GetOrCreateNativeToManagedTrampoline(new DelegateSupport.MethodSignature(methodInfo2, true), methodInfo2, methodInfo);
			INativeMethodInfoStruct nativeMethodInfoStruct = UnityVersionHandler.NewMethod();
			*nativeMethodInfoStruct.MethodPointer = QLiRJFAF4RLcEdAqyX3.muOq5LWqgj(orCreateNativeToManagedTrampoline, QLiRJFAF4RLcEdAqyX3.lCcARDSrKK);
			*nativeMethodInfoStruct.ParametersCount = (byte)array.Length;
			*nativeMethodInfoStruct.Slot = ushort.MaxValue;
			nativeMethodInfoStruct.IsMarshalledFromNative = true;
			DelegateSupport.Il2CppToMonoDelegateReference value = new DelegateSupport.Il2CppToMonoDelegateReference(@delegate, nativeMethodInfoStruct.Pointer);
			Delegate delegate2 = new Delegate(IL2CPP.il2cpp_object_new(nativeClassPointer));
			opUjNRAMQPxWTVA9EIr.muOq5LWqgj(delegate2, *nativeMethodInfoStruct.MethodPointer, opUjNRAMQPxWTVA9EIr.wW6AWVst8j);
			E4qqkQACbjYqfvwkCPc.muOq5LWqgj(delegate2, methodInfo2, E4qqkQACbjYqfvwkCPc.oNKA9G3vNL);
			okxcd2AI22SeZ7HKNH7.muOq5LWqgj(delegate2, nativeMethodInfoStruct.Pointer, okxcd2AI22SeZ7HKNH7.I7RAdXsJhZ);
			dXGiwbAiR7Nu4l94a5g.muOq5LWqgj(delegate2, new Object(IL2CPP.il2cpp_object_new(nativeMethodInfoStruct.Pointer)), dXGiwbAiR7Nu4l94a5g.zimAwLKHXX);
			if (DelegateSupport.NativeToManagedTrampoline.ContainsKey(KSgDP2AEUgan1CiuSB6.muOq5LWqgj(delegate2, KSgDP2AEUgan1CiuSB6.oyvAB6Tofr).Pointer))
			{
				DelegateSupport.NativeToManagedTrampoline.Remove(KSgDP2AEUgan1CiuSB6.muOq5LWqgj(delegate2, KSgDP2AEUgan1CiuSB6.oyvAB6Tofr).Pointer);
			}
			DelegateSupport.NativeToManagedTrampoline.Add(KSgDP2AEUgan1CiuSB6.muOq5LWqgj(delegate2, KSgDP2AEUgan1CiuSB6.oyvAB6Tofr).Pointer, value);
			dn1VV2ATthcrGwMYo0J.muOq5LWqgj(delegate2, z3kDGrAGshmSkqebXm6.muOq5LWqgj(delegate2, z3kDGrAGshmSkqebXm6.t5WAr8m4nW), dn1VV2ATthcrGwMYo0J.smQAgf0eWp);
			CNFy6sAoANhC45nG5lq.muOq5LWqgj(delegate2, KSgDP2AEUgan1CiuSB6.muOq5LWqgj(delegate2, KSgDP2AEUgan1CiuSB6.oyvAB6Tofr).Pointer, CNFy6sAoANhC45nG5lq.mv4AUp4bwM);
			return delegate2.Cast<TIl2Cpp>();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004838 File Offset: 0x00002A38
		// Note: this type is marked as 'beforefieldinit'.
		static DelegateSupport()
		{
			int num = 8;
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
						DelegateSupport.ourDelegateTypes = new ConcurrentDictionary<DelegateSupport.MethodSignature, Type>();
						num2 = 3;
						continue;
					case 3:
						DelegateSupport.AssemblyBuilder = DelegateSupport.lP8cHkhUrT90C9eDOBZ(new AssemblyName(DelegateSupport.WtCPTbhtWZVOGYEWBWv(-1066070775 ^ -702322474 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b329e831708e4d29ae561982d3d8c1c1)), AssemblyBuilderAccess.Run, UETNIlAjAFIFP95Jdbk.LGoAQFtfia);
						num2 = 4;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						DelegateSupport.ModuleBuilder = DelegateSupport.Dnu1gYhjgcE67BIEiVb(DelegateSupport.AssemblyBuilder, DelegateSupport.WtCPTbhtWZVOGYEWBWv(2365124 - 1496305710 ^ -535026465 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_40fe2648722c4d04bef43cdd927d6154), NEllk4AeauycfOpdUn5.OCQAKEXBx8);
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0272cc4de9694915be17746e515675c8 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						DelegateSupport.NativeToManagedTrampoline = new Dictionary<IntPtr, DelegateSupport.Il2CppToMonoDelegateReference>();
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_911808c58d664adeb7c16d1e3a32f7fa != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 6:
						goto IL_AA;
					case 7:
						DelegateSupport.WoV24vhoDsq9EveLxRB();
						num2 = 4;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2ec67b9ff6c4cd7af2a4ceec32c111c != 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					case 8:
						DelegateSupport.SVNOjKhg28oY2oH81oP();
						num2 = 7;
						continue;
					}
					DelegateSupport.NativeToManagedTrampolines = new ConcurrentDictionary<MethodInfo, Delegate>();
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4c6a46c0a2d14747aa1dc5bf1581154d == 0)
					{
						num2 = 5;
					}
				}
				IL_AA:
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				num = 2;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000049DC File Offset: 0x00002BDC
		internal static bool vwaqd8hhhohV0Ikr0GJ()
		{
			return DelegateSupport.grIRD3hHPfOaVMg674a == null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000049F0 File Offset: 0x00002BF0
		internal static DelegateSupport ATXKRLhOIVpHR5AQcjl()
		{
			return DelegateSupport.grIRD3hHPfOaVMg674a;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004A00 File Offset: 0x00002C00
		internal static object WtCPTbhtWZVOGYEWBWv(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004A14 File Offset: 0x00002C14
		internal static object QgVImhhvTmBL9aSj277(object A_0, object A_1, TypeAttributes A_2, Type A_3, object A_4)
		{
			return EnfnQnq7HvWpY2y09Xe.muOq5LWqgj(A_0, A_1, A_2, A_3, A_4);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004A38 File Offset: 0x00002C38
		internal static Type PMQ05Rhx5qM3qUw0Srs(RuntimeTypeHandle A_0, object A_1)
		{
			return KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004A50 File Offset: 0x00002C50
		internal static object ybKPTAhYqwCgHcdluyT(object A_0, object A_1, object A_2)
		{
			return Fj0pGZq4FxSKcr9u2UH.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004A6C File Offset: 0x00002C6C
		internal static void WJys1yh8nRr3ZJNDb7q(object A_0, object A_1, object A_2)
		{
			LE4uTGqfdrbftuurhWL.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004A88 File Offset: 0x00002C88
		internal static object kxQT2RhnRZQTTQQmWfb(object A_0, MethodAttributes A_1, CallingConventions A_2, object A_3, object A_4)
		{
			return GtQlqsqFHSMj09PkX1r.muOq5LWqgj(A_0, A_1, A_2, A_3, A_4);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004AAC File Offset: 0x00002CAC
		internal static object ARGWgchbjqAReSO17tn(object A_0, object A_1)
		{
			return BliveCqCnt3Bq9RIiHL.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00004AC4 File Offset: 0x00002CC4
		internal static Type d9xks1h6vO7RrIAfoUB(object A_0, object A_1)
		{
			return Ru3dbaqIKWq9Yf63MJb.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004ADC File Offset: 0x00002CDC
		internal static Type h7D08Jhy81eWyDYQAeM(Type managedType)
		{
			return managedType.NativeType();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004AF0 File Offset: 0x00002CF0
		internal static Type thPyAphJySP462n5lZo(object A_0, object A_1)
		{
			return C67uwgqiEvgqVW8owjp.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00004B08 File Offset: 0x00002D08
		internal static object J8sIJChpymnZGRWiswA(object A_0, object A_1, MethodAttributes A_2, CallingConventions A_3, Type A_4, object A_5, object A_6)
		{
			return BYXhA2qEQdqeq1eI8YK.muOq5LWqgj(A_0, A_1, A_2, A_3, A_4, A_5, A_6);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004B34 File Offset: 0x00002D34
		internal static void j4P25AhVd8bish8ik8r(object A_0, MethodImplAttributes A_1, object A_2)
		{
			zRrT13qGN5tCR8aX4nr.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004B50 File Offset: 0x00002D50
		internal static Type nxaGUsh0Bs8pkPFyF21(object A_0, object A_1)
		{
			return aBR5LPqTqhDZgK9xjFE.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004B68 File Offset: 0x00002D68
		internal static object Jb14YBhsFgFyB2xaBhO(object A_0, object A_1)
		{
			return y1wUHLqoFyW6gbQN93u.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004B80 File Offset: 0x00002D80
		internal static object Wlyc81hS6ePdCpy9bom(object A_0, object A_1, object A_2)
		{
			return m2eLpFqjHkNaRPiWsth.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004B9C File Offset: 0x00002D9C
		internal static bool BuWGHQhN7jjbNEOfX8p(object A_0, object A_1)
		{
			return Y856w6qe4qUMTGoZo0c.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004BB4 File Offset: 0x00002DB4
		internal static object yMuYmVhutAkRC9For2s(object A_0, char A_1, object A_2)
		{
			return L3pNC5qaYklcQpPam6c.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004BD0 File Offset: 0x00002DD0
		internal static Type P4Hf5ihDC9l3f4s4MOB(object A_0, object A_1)
		{
			return RO0g2Vqz1eEynR0MNrr.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004BE8 File Offset: 0x00002DE8
		internal static object GF7xxYhmtBRZXGbvLPf(object A_0, object A_1)
		{
			return Wp12YC5qLpXaitTqQ38.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004C00 File Offset: 0x00002E00
		internal static void S7dtNyh7fV0YWTXjci7(object A_0)
		{
			Logger.LogError(A_0);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004C14 File Offset: 0x00002E14
		internal static object T9GaFDhPrs42gYAxQhm(object A_0)
		{
			return DelegateSupport.ExtractSignature(A_0);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004C28 File Offset: 0x00002E28
		internal static object nphgRlh4dO36biFrjHr(object A_0, object A_1)
		{
			return dr5pjw5kUmWnx1oVRTn.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004C40 File Offset: 0x00002E40
		internal static Label RPi47Ch3CyFwFvcf8CZ(object A_0, object A_1)
		{
			return n2KuiL5HdJx815IA8On.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004C58 File Offset: 0x00002E58
		internal static void nateMBhfk2aePGwEtFt(object A_0, OpCode A_1, object A_2)
		{
			sWLRHR5OB7hMDvnerut.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004C74 File Offset: 0x00002E74
		internal static void KafqLth16U8OIk59IlJ(object A_0, OpCode A_1, object A_2, object A_3)
		{
			nlOWSv5YwlZX9e40I0P.muOq5LWqgj(A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004C94 File Offset: 0x00002E94
		internal static object BBXmJ7hFGmnLDGN0KU9(object A_0, object A_1, object A_2)
		{
			return MAorCg56yGa3HPtjiY3.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004CB0 File Offset: 0x00002EB0
		internal static void NXGY0PhR0lfI8kG8nVB(object A_0, OpCode A_1, int A_2, object A_3)
		{
			Co14wF5VcZMbUqSsQj7.muOq5LWqgj(A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004CD0 File Offset: 0x00002ED0
		internal static bool loFdWNhMkGZL66N1jJo(Type A_0, Type A_1, object A_2)
		{
			return JCwQlA5sGlTyuRZuORY.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004CEC File Offset: 0x00002EEC
		internal static object atUlX2hWOHdH0h8KHqx(object A_0, object A_1, object A_2)
		{
			return DnZ9sC5vW5Zmyo7jjbr.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004D08 File Offset: 0x00002F08
		internal static bool TaqriJhCq2XpFUUjPmL(object A_0, object A_1)
		{
			return iAjcxl5NRwJWXWxUcfF.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004D20 File Offset: 0x00002F20
		internal static void ncqQkRh9IYiKe6HCXIH(object A_0, OpCode A_1, Label A_2, object A_3)
		{
			pNreXN57CQsH91V5Xqd.muOq5LWqgj(A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004D40 File Offset: 0x00002F40
		internal static void nO8Kp9hIRsZf2qlEIvl(object A_0, Label A_1, object A_2)
		{
			PAXvTU5FWGeXyTZ4W8Y.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004D5C File Offset: 0x00002F5C
		internal static Label rdxnZwhdbC5mkP8SgD9(object A_0, object A_1)
		{
			return CXapgn5DZ1qP6THOsuy.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004D74 File Offset: 0x00002F74
		internal static object lx8Qiihi7EgyGsRpwal(object A_0, object A_1)
		{
			return FaKxy95CO6Z2TevxwVr.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004D8C File Offset: 0x00002F8C
		internal static object KiSCtAhwJIJJKn1SlIa(object A_0, Type A_1, object A_2)
		{
			return SQM72H5ivMmDwrxZbaU.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004DA8 File Offset: 0x00002FA8
		internal static void QiaQ6dhE2YHmRFf3oZR(object A_0, OpCode A_1, object A_2, object A_3)
		{
			w0HxWS5EDl8tYs1LbZu.muOq5LWqgj(A_0, A_1, A_2, A_3);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004DC8 File Offset: 0x00002FC8
		internal static void Tqv2klhBii37TPjV2cv(object A_0, Type A_1, object A_2)
		{
			Q0258C5GfvUnEmUbGUk.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004DE4 File Offset: 0x00002FE4
		internal static void DRhY0ahGnTswCSsKK6W(object A_0, OpCode A_1, object A_2, object A_3)
		{
			NHuG3T5TPIER7uS3ECl.muOq5LWqgj(A_0, A_1, A_2, A_3);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004E04 File Offset: 0x00003004
		internal static object LaJJb1hrwv5PxlcnDQD(object A_0, object A_1, BindingFlags A_2, object A_3)
		{
			return Tx2H9W5jh73cqTPUdxk.muOq5LWqgj(A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004E24 File Offset: 0x00003024
		internal static object Dy7vRhhTcZRlob3sjfk(object A_0, Type A_1, object A_2)
		{
			return RXPjpP5aBG6EjiAFu8c.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004E40 File Offset: 0x00003040
		internal static void SVNOjKhg28oY2oH81oP()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004E50 File Offset: 0x00003050
		internal static void WoV24vhoDsq9EveLxRB()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004E60 File Offset: 0x00003060
		internal static object lP8cHkhUrT90C9eDOBZ(object A_0, AssemblyBuilderAccess A_1, object A_2)
		{
			return UETNIlAjAFIFP95Jdbk.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004E7C File Offset: 0x0000307C
		internal static object Dnu1gYhjgcE67BIEiVb(object A_0, object A_1, object A_2)
		{
			return NEllk4AeauycfOpdUn5.muOq5LWqgj(A_0, A_1, A_2);
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
		private static DelegateSupport grIRD3hHPfOaVMg674a;

		// Token: 0x02000005 RID: 5
		public class MethodSignature : IEquatable<DelegateSupport.MethodSignature>
		{
			// Token: 0x06000065 RID: 101 RVA: 0x00016064 File Offset: 0x00014264
			public MethodSignature(MethodInfo methodInfo, bool hasThis)
			{
				DelegateSupport.MethodSignature.sGoGmIVJkxbaT5BHrYo();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b1a14f54e3674a8baf7d5ab6ab85764a != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae == 0)
						{
							num = 3;
							continue;
						}
						continue;
					case 2:
						this.ConstructedFromNative = true;
						num = 4;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eeb967463afe407d8f7c3b354043704c != 0)
						{
							num = 4;
							continue;
						}
						continue;
					case 3:
						this.myReturnType = (yQRJPPcGJpJ9UDE2CTQ.muOq5LWqgj(DelegateSupport.MethodSignature.hMVdxOVpRDDbhCpyplH(methodInfo, cTQUd4cE0BgyIYGOdws.tSicBySltr), yQRJPPcGJpJ9UDE2CTQ.sMbcrJFvZX) ? DelegateSupport.MethodSignature.B3KVMMVVlGt9fYFsVbu(DelegateSupport.MethodSignature.hMVdxOVpRDDbhCpyplH(methodInfo, cTQUd4cE0BgyIYGOdws.tSicBySltr), Wruo9gA7CtinPlpnGZZ.w6qAP8Ns6p).value : IntPtr.Zero);
						num = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb34a81d7cc4fbea898664370a8645f == 0)
						{
							num = 0;
							continue;
						}
						continue;
					case 4:
						return;
					}
					this.myParameterTypes = tTd7Ix5AbpqY0IcwJ37.muOq5LWqgj(methodInfo, tTd7Ix5AbpqY0IcwJ37.QbC5LHCejO).Select(delegate(ParameterInfo it)
					{
						int num2 = 2;
						int num3 = num2;
						for (;;)
						{
							switch (num3)
							{
							case 1:
								goto IL_68;
							case 2:
								if (yQRJPPcGJpJ9UDE2CTQ.muOq5LWqgj(DelegateSupport.MethodSignature.<>c.d2gwT33My6qblviJfS0(it, qnjRS7AvBUm3itUmewL.L8oAxe6K2f), yQRJPPcGJpJ9UDE2CTQ.sMbcrJFvZX))
								{
									num3 = 1;
									if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3bc41e98a8e849aea1e93dfe0f04c43b == 0)
									{
										num3 = 1;
										continue;
									}
									continue;
								}
								break;
							}
							break;
						}
						goto IL_8C;
						IL_68:
						return DelegateSupport.MethodSignature.<>c.v5c8cK3WcDyji5ofrjK(qnjRS7AvBUm3itUmewL.muOq5LWqgj(it, qnjRS7AvBUm3itUmewL.L8oAxe6K2f), Wruo9gA7CtinPlpnGZZ.w6qAP8Ns6p).value;
						IL_8C:
						return IntPtr.Zero;
					}).ToArray<IntPtr>();
					num = 2;
				}
			}

			// Token: 0x06000066 RID: 102 RVA: 0x000161D0 File Offset: 0x000143D0
			public MethodSignature(MethodInfo methodInfo, bool hasThis)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				DelegateSupport.MethodSignature.TwNDaXV0bEWxmlvi8Cp();
				base..ctor();
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						this.ConstructedFromNative = false;
						num = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5a2f191df3714123bdeb9f5f4b416da9 != 0)
						{
							num = 1;
							continue;
						}
						continue;
					case 3:
					{
						IntPtr intPtr;
						if (!DelegateSupport.MethodSignature.a227EeVsqP31JGX0Lf0(C67uwgqiEvgqVW8owjp.muOq5LWqgj(methodInfo, C67uwgqiEvgqVW8owjp.qj1qwiCc4X), iAjcxl5NRwJWXWxUcfF.jEX5uAuA4B))
						{
							intPtr = IntPtr.Zero;
						}
						else
						{
							RuntimeTypeHandle runtimeTypeHandle = DelegateSupport.MethodSignature.w5ryibVSHlGpb14bsiB(C67uwgqiEvgqVW8owjp.muOq5LWqgj(methodInfo, C67uwgqiEvgqVW8owjp.qj1qwiCc4X), WWZfDKLjkEDkZQlmo8Z.ci3LQbLuSn);
							intPtr = LiX9DHcTh22swKHa0fZ.muOq5LWqgj(ref runtimeTypeHandle, LiX9DHcTh22swKHa0fZ.mqrcgtpbmF);
						}
						this.myReturnType = intPtr;
						num = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_508916f527eb4b05b32762ef07dd9e52 == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					case 4:
						this.HasThis = hasThis;
						num = 3;
						continue;
					}
					this.myParameterTypes = DelegateSupport.MethodSignature.hAuJAHVNTW85pXvO91k(methodInfo, BliveCqCnt3Bq9RIiHL.EbUq9R3fXl).Select(delegate(ParameterInfo it)
					{
						int num2 = 1;
						int num3 = num2;
						RuntimeTypeHandle runtimeTypeHandle2;
						for (;;)
						{
							switch (num3)
							{
							default:
								goto IL_2F;
							case 1:
								if (!iAjcxl5NRwJWXWxUcfF.muOq5LWqgj(DelegateSupport.MethodSignature.<>c.yL3oxE3Cy70E5uUpdP3(it, Ru3dbaqIKWq9Yf63MJb.CVKqd8MMF8), iAjcxl5NRwJWXWxUcfF.jEX5uAuA4B))
								{
									num3 = 0;
									if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3bc41e98a8e849aea1e93dfe0f04c43b == 0)
									{
										num3 = 0;
									}
								}
								else
								{
									runtimeTypeHandle2 = DelegateSupport.MethodSignature.<>c.SQFlQj399L9WTHFTYvZ(Ru3dbaqIKWq9Yf63MJb.muOq5LWqgj(it, Ru3dbaqIKWq9Yf63MJb.CVKqd8MMF8), WWZfDKLjkEDkZQlmo8Z.ci3LQbLuSn);
									num3 = 1;
									if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0ec1d35577cb488fb4bdfc9810c6c86f != 0)
									{
										num3 = 2;
									}
								}
								break;
							case 2:
								goto IL_A4;
							}
						}
						IL_2F:
						return IntPtr.Zero;
						IL_A4:
						return LiX9DHcTh22swKHa0fZ.muOq5LWqgj(ref runtimeTypeHandle2, LiX9DHcTh22swKHa0fZ.mqrcgtpbmF);
					}).ToArray<IntPtr>();
					num = 2;
				}
			}

			// Token: 0x06000067 RID: 103 RVA: 0x0001631C File Offset: 0x0001451C
			public bool Equals(DelegateSupport.MethodSignature other)
			{
				int num = 7;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						int num3;
						switch (num2)
						{
						case 1:
							goto IL_8D;
						case 2:
							return false;
						case 3:
							goto IL_CC;
						case 4:
							return false;
						case 5:
							return false;
						case 6:
							if (this == other)
							{
								goto Block_4;
							}
							if (!QApmLVcoYefcw8M6ZV4.muOq5LWqgj(ref this.myReturnType, other.myReturnType, QApmLVcoYefcw8M6ZV4.LWccUtrook))
							{
								num2 = 4;
								continue;
							}
							if (this.HasThis != other.HasThis)
							{
								num2 = 2;
								if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_da5aa2d475094b06a3df3cc53bc85956 == 0)
								{
									num2 = 2;
									continue;
								}
								continue;
							}
							else
							{
								if (this.myParameterTypes.Length != other.myParameterTypes.Length)
								{
									num2 = 10;
									continue;
								}
								num3 = 0;
								num2 = 1;
								if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5 == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							}
							break;
						case 7:
							if (other != null)
							{
								num2 = 6;
								continue;
							}
							return false;
						case 8:
							goto IL_CC;
						case 9:
							return false;
						case 10:
							return false;
						case 11:
							goto IL_8D;
						case 12:
							return true;
						}
						goto Block_1;
						IL_CC:
						if (this.myParameterTypes[num3] != other.myParameterTypes[num3])
						{
							break;
						}
						num3++;
						num2 = 11;
						continue;
						IL_8D:
						if (num3 >= this.myParameterTypes.Length)
						{
							return true;
						}
						num2 = 3;
					}
					num = 9;
					continue;
					Block_4:
					num = 12;
				}
				Block_1:
				return true;
			}

			// Token: 0x06000068 RID: 104 RVA: 0x00016504 File Offset: 0x00014704
			public override bool Equals(object obj)
			{
				int num = 3;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return false;
					case 2:
						return false;
					case 3:
						if (obj == null)
						{
							num2 = 2;
							continue;
						}
						if (this == obj)
						{
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3e36778f33984767b2e7264fa31cee60 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						else
						{
							if (!CiJop65IqHJCv8k5I3G.muOq5LWqgj(xyOWutAqDih6hgfZh8A.muOq5LWqgj(obj, xyOWutAqDih6hgfZh8A.kn1A5ABE1Q), kIEgVlcjCSWRcdALoqJ.muOq5LWqgj(this, kIEgVlcjCSWRcdALoqJ.WJ6cQ61qic), CiJop65IqHJCv8k5I3G.Lvb5dhFO0X))
							{
								goto IL_35;
							}
							num2 = 1;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ffe1ad8c1cf94bc78c25e67b0264547e != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						break;
					}
					break;
				}
				return true;
				IL_35:
				return this.Equals((DelegateSupport.MethodSignature)obj);
			}

			// Token: 0x06000069 RID: 105 RVA: 0x000165D0 File Offset: 0x000147D0
			public override int GetHashCode()
			{
				int num = 8;
				int num4;
				for (;;)
				{
					int num2 = num;
					int num3;
					IntPtr intPtr;
					IntPtr[] array;
					for (;;)
					{
						switch (num2)
						{
						case 2:
							goto IL_47;
						case 3:
							num3++;
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8378a46aa7ed47018832a42729b1bc3b == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							return num4;
						case 5:
							num3 = 0;
							num2 = 1;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb34a81d7cc4fbea898664370a8645f == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 6:
							num4 = num4 * 397 + XN0pkqceWwZA6MI6hin.muOq5LWqgj(ref intPtr, XN0pkqceWwZA6MI6hin.i1dcKQ9N20);
							num2 = 3;
							continue;
						case 7:
							array = this.myParameterTypes;
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_263609815aa041aea5525a459e9a816b == 0)
							{
								num2 = 5;
								continue;
							}
							continue;
						case 8:
							goto IL_94;
						}
						goto Block_1;
					}
					IL_47:
					intPtr = array[num3];
					num = 6;
					continue;
					IL_94:
					num4 = (XN0pkqceWwZA6MI6hin.muOq5LWqgj(ref this.myReturnType, XN0pkqceWwZA6MI6hin.i1dcKQ9N20) ^ CNSAYecagsA7ZSmjv1u.muOq5LWqgj(ref this.HasThis, CNSAYecagsA7ZSmjv1u.xvycZvHKw0));
					num = 7;
					continue;
					IL_E6:
					if (num3 >= array.Length)
					{
						num = 4;
						continue;
					}
					goto IL_47;
					Block_1:
					goto IL_E6;
				}
				return num4;
			}

			// Token: 0x0600006A RID: 106 RVA: 0x00016728 File Offset: 0x00014928
			public static bool operator ==(DelegateSupport.MethodSignature left, DelegateSupport.MethodSignature right)
			{
				return DelegateSupport.MethodSignature.mtCZMFVuc9t98y7BJ5x(left, right, qXNx62c7iINKRNEVUDt.uagcPHeHpn);
			}

			// Token: 0x0600006B RID: 107 RVA: 0x00016740 File Offset: 0x00014940
			public static bool operator !=(DelegateSupport.MethodSignature left, DelegateSupport.MethodSignature right)
			{
				return !DelegateSupport.MethodSignature.mtCZMFVuc9t98y7BJ5x(left, right, qXNx62c7iINKRNEVUDt.uagcPHeHpn);
			}

			// Token: 0x0600006C RID: 108 RVA: 0x00016758 File Offset: 0x00014958
			// Note: this type is marked as 'beforefieldinit'.
			static MethodSignature()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0600006D RID: 109 RVA: 0x00016768 File Offset: 0x00014968
			internal static void sGoGmIVJkxbaT5BHrYo()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600006E RID: 110 RVA: 0x00016778 File Offset: 0x00014978
			internal static object hMVdxOVpRDDbhCpyplH(object A_0, object A_1)
			{
				return cTQUd4cE0BgyIYGOdws.muOq5LWqgj(A_0, A_1);
			}

			// Token: 0x0600006F RID: 111 RVA: 0x00016790 File Offset: 0x00014990
			internal static RuntimeTypeHandle B3KVMMVVlGt9fYFsVbu(object A_0, object A_1)
			{
				return Wruo9gA7CtinPlpnGZZ.muOq5LWqgj(A_0, A_1);
			}

			// Token: 0x06000070 RID: 112 RVA: 0x000167A8 File Offset: 0x000149A8
			internal static bool lMnccwV6LcXxyrruJxO()
			{
				return DelegateSupport.MethodSignature.aAbHbdVbVGdoHmQYx4y == null;
			}

			// Token: 0x06000071 RID: 113 RVA: 0x000167BC File Offset: 0x000149BC
			internal static DelegateSupport.MethodSignature xS3XPbVyIUSGi8ms11F()
			{
				return DelegateSupport.MethodSignature.aAbHbdVbVGdoHmQYx4y;
			}

			// Token: 0x06000072 RID: 114 RVA: 0x000167CC File Offset: 0x000149CC
			internal static void TwNDaXV0bEWxmlvi8Cp()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000073 RID: 115 RVA: 0x000167DC File Offset: 0x000149DC
			internal static bool a227EeVsqP31JGX0Lf0(object A_0, object A_1)
			{
				return iAjcxl5NRwJWXWxUcfF.muOq5LWqgj(A_0, A_1);
			}

			// Token: 0x06000074 RID: 116 RVA: 0x000167F4 File Offset: 0x000149F4
			internal static RuntimeTypeHandle w5ryibVSHlGpb14bsiB(object A_0, object A_1)
			{
				return WWZfDKLjkEDkZQlmo8Z.muOq5LWqgj(A_0, A_1);
			}

			// Token: 0x06000075 RID: 117 RVA: 0x0001680C File Offset: 0x00014A0C
			internal static object hAuJAHVNTW85pXvO91k(object A_0, object A_1)
			{
				return BliveCqCnt3Bq9RIiHL.muOq5LWqgj(A_0, A_1);
			}

			// Token: 0x06000076 RID: 118 RVA: 0x00016824 File Offset: 0x00014A24
			internal static bool mtCZMFVuc9t98y7BJ5x(object A_0, object A_1, object A_2)
			{
				return qXNx62c7iINKRNEVUDt.muOq5LWqgj(A_0, A_1, A_2);
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
			internal static DelegateSupport.MethodSignature aAbHbdVbVGdoHmQYx4y;
		}

		// Token: 0x02000007 RID: 7
		private class Il2CppToMonoDelegateReference
		{
			// Token: 0x06000084 RID: 132 RVA: 0x00016840 File Offset: 0x00014A40
			public Il2CppToMonoDelegateReference(Delegate referencedDelegate, IntPtr methodInfo)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				DelegateSupport.Il2CppToMonoDelegateReference.NYd9ibVPx58q3t4hCQm();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2ec67b9ff6c4cd7af2a4ceec32c111c != 0)
				{
					num = 2;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.MethodInfo = methodInfo;
						num = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6776fc69415b4d309be658e7e8ac3a28 != 0)
						{
							num = 0;
							continue;
						}
						continue;
					case 2:
						this.ReferencedDelegate = referencedDelegate;
						num = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_575f8bd7bfb04e37800ff009689b44f6 != 0)
						{
							num = 1;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x06000085 RID: 133 RVA: 0x000168F8 File Offset: 0x00014AF8
			// Note: this type is marked as 'beforefieldinit'.
			static Il2CppToMonoDelegateReference()
			{
				DelegateSupport.Il2CppToMonoDelegateReference.aVAdx0V4PifaWKK8bhp();
			}

			// Token: 0x06000086 RID: 134 RVA: 0x00016908 File Offset: 0x00014B08
			internal static void NYd9ibVPx58q3t4hCQm()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000087 RID: 135 RVA: 0x00016918 File Offset: 0x00014B18
			internal static bool R84RIgVmJY8Xrm9J41D()
			{
				return DelegateSupport.Il2CppToMonoDelegateReference.rJrESYVDGI8PTrslXBa == null;
			}

			// Token: 0x06000088 RID: 136 RVA: 0x0001692C File Offset: 0x00014B2C
			internal static DelegateSupport.Il2CppToMonoDelegateReference nfXoCWV7yJf0m0rI6JQ()
			{
				return DelegateSupport.Il2CppToMonoDelegateReference.rJrESYVDGI8PTrslXBa;
			}

			// Token: 0x06000089 RID: 137 RVA: 0x0001693C File Offset: 0x00014B3C
			internal static void aVAdx0V4PifaWKK8bhp()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000014 RID: 20
			public IntPtr MethodInfo;

			// Token: 0x04000015 RID: 21
			public object ReferencedDelegate;

			// Token: 0x04000016 RID: 22
			internal static object rJrESYVDGI8PTrslXBa;
		}
	}
}
