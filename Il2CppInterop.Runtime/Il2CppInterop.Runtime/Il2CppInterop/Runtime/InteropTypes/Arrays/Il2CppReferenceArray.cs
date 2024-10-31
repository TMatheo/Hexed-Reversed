using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.InteropTypes.Arrays
{
	// Token: 0x0200012C RID: 300
	public class Il2CppReferenceArray<T> : Il2CppArrayBase<T> where T : Il2CppObjectBase
	{
		// Token: 0x06000D12 RID: 3346 RVA: 0x0001420C File Offset: 0x0001240C
		static Il2CppReferenceArray()
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
					{
						IntPtr nativeClassPtr = Il2CppClassPointerStore<T>.NativeClassPtr;
						num2 = 5;
						continue;
					}
					case 2:
						return;
					case 3:
						goto IL_B1;
					case 4:
						nHwRpygmi6xxZAssJn.EmlEpH4Phw();
						num2 = 3;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_420bdc7f003c47439a9f8331e71194a1 != 0)
						{
							num2 = 10;
							continue;
						}
						continue;
					case 5:
					{
						IntPtr nativeClassPtr;
						if (nativeClassPtr == IntPtr.Zero)
						{
							num2 = 11;
							continue;
						}
						uint num3 = 0U;
						num2 = 9;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5a2f191df3714123bdeb9f5f4b416da9 == 0)
						{
							num2 = 9;
							continue;
						}
						continue;
					}
					case 6:
					{
						IntPtr nativeClassPtr;
						uint num3;
						Il2CppReferenceArray<T>.ourElementTypeSize = IL2CPP.il2cpp_class_value_size(nativeClassPtr, ref num3);
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb34a81d7cc4fbea898664370a8645f != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					case 7:
						hIDAYxH6DWLHIthQgC.oDuBOTgYK();
						num2 = 3;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_068b7dfa4ec449e7b5200030c1c277e5 == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 8:
						hIDAYxH6DWLHIthQgC.zSLipEDdx();
						num2 = 7;
						continue;
					case 9:
					{
						IntPtr nativeClassPtr;
						if (IL2CPP.il2cpp_class_is_valuetype(nativeClassPtr))
						{
							num2 = 3;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6dbfd13d96434eb59d868fecd0ad1cda == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
					case 10:
						Il2CppReferenceArray<T>.ourElementTypeSize = cQkHnrc4uCYVWodZmHM.muOq5LWqgj(cQkHnrc4uCYVWodZmHM.qhnc3Q5HwY);
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cfadd7e02c524ea298356b7415bd67b6 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 11:
						return;
					}
					Il2CppArrayBase<T>.StaticCtorBody(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Il2CppReferenceArray<T>).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV));
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8b1b71d923f0486b89239dd4a11f6d34 == 0)
					{
						num2 = 2;
					}
				}
				IL_B1:
				Il2CppReferenceArray<T>.ourElementIsValueType = true;
				num = 6;
			}
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x000143DC File Offset: 0x000125DC
		public Il2CppReferenceArray(IntPtr nativeObject)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor(nativeObject);
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ac2c10c141e144acbcef06aa86a10430 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00014444 File Offset: 0x00012644
		public Il2CppReferenceArray(long size)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor(Il2CppReferenceArray<T>.AllocateArray(size));
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bc2bbd892f074260abf5aaa8b1124d64 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x000144B0 File Offset: 0x000126B0
		public Il2CppReferenceArray(T[] arr)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor(Il2CppReferenceArray<T>.AllocateArray((long)arr.Length));
			int num = 2;
			for (;;)
			{
				int num2;
				switch (num)
				{
				case 1:
					num2++;
					num = 5;
					continue;
				case 2:
				{
					num2 = 0;
					int num3 = 4;
					num = num3;
					continue;
				}
				case 3:
					return;
				case 4:
					goto IL_D4;
				case 5:
					goto IL_D4;
				}
				IL_95:
				this[num2] = arr[num2];
				num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2ec67b9ff6c4cd7af2a4ceec32c111c != 0)
				{
					num = 1;
					continue;
				}
				continue;
				IL_D4:
				if (num2 < arr.Length)
				{
					goto IL_95;
				}
				num = 3;
			}
		}

		// Token: 0x170004E0 RID: 1248
		public override T this[int index]
		{
			get
			{
				if (index < 0 || index >= base.Length)
				{
					throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1459391761 ^ -2050456769 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_64a8b41e58e0491ab0e9d05ec5ed61d3), hIDAYxH6DWLHIthQgC.gSCeTtiku(674965228 ^ 741484653 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c26b4d3619a4457fb4121e194d9ef286));
				}
				return Il2CppReferenceArray<T>.WrapElement(apS1BFcfBa3gXUspL9j.muOq5LWqgj(apS1BFcfBa3gXUspL9j.muOq5LWqgj(base.Pointer, 4 * cQkHnrc4uCYVWodZmHM.muOq5LWqgj(cQkHnrc4uCYVWodZmHM.qhnc3Q5HwY), apS1BFcfBa3gXUspL9j.A06c1GDsfl), index * Il2CppReferenceArray<T>.ourElementTypeSize, apS1BFcfBa3gXUspL9j.A06c1GDsfl));
			}
			set
			{
				if (index < 0 || index >= base.Length)
				{
					throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(~-1799406944 ^ 158677480 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_575f8bd7bfb04e37800ff009689b44f6), hIDAYxH6DWLHIthQgC.gSCeTtiku(1314478277 ^ 916236496 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_856ffe7e0c9b4de88d71070d175d49fd));
				}
				IntPtr targetPointer = apS1BFcfBa3gXUspL9j.muOq5LWqgj(apS1BFcfBa3gXUspL9j.muOq5LWqgj(base.Pointer, 4 * cQkHnrc4uCYVWodZmHM.muOq5LWqgj(cQkHnrc4uCYVWodZmHM.qhnc3Q5HwY), apS1BFcfBa3gXUspL9j.A06c1GDsfl), index * Il2CppReferenceArray<T>.ourElementTypeSize, apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				T t = value;
				Il2CppReferenceArray<T>.StoreValue(targetPointer, (t != null) ? t.Pointer : IntPtr.Zero);
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x000146F0 File Offset: 0x000128F0
		public static implicit operator Il2CppReferenceArray<T>(T[] arr)
		{
			if (arr == null)
			{
				return null;
			}
			return new Il2CppReferenceArray<T>(arr);
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00014708 File Offset: 0x00012908
		private unsafe static void StoreValue(IntPtr targetPointer, IntPtr valuePointer)
		{
			int num = 5;
			int num2 = num;
			for (;;)
			{
				int num3;
				byte* ptr;
				switch (num2)
				{
				case 0:
					goto IL_65;
				case 1:
					num3++;
					num2 = 7;
					continue;
				case 2:
					goto IL_C6;
				case 3:
					return;
				case 4:
					if (valuePointer == IntPtr.Zero)
					{
						num2 = 2;
						continue;
					}
					ptr = IL2CPP.il2cpp_object_unbox(valuePointer);
					num2 = 6;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cb2874465fa5416db806f31e03cc475c != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 5:
					if (!Il2CppReferenceArray<T>.ourElementIsValueType)
					{
						*targetPointer = valuePointer;
						num2 = 10;
						continue;
					}
					num2 = 4;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 6:
					num2 = 3;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_457365959f004478ad0e311bf72b3912 == 0)
					{
						num2 = 8;
						continue;
					}
					continue;
				case 7:
					break;
				case 8:
					num3 = 0;
					num2 = 9;
					continue;
				case 9:
					break;
				case 10:
					return;
				default:
					goto IL_65;
				}
				if (num3 >= Il2CppReferenceArray<T>.ourElementTypeSize)
				{
					num2 = 3;
					continue;
				}
				IL_65:
				*(targetPointer + (IntPtr)num3) = ptr[num3];
				num2 = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_734db430e12345289ec4ae0afacc44df == 0)
				{
					num2 = 1;
				}
			}
			IL_C6:
			throw new NullReferenceException();
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00014884 File Offset: 0x00012A84
		private unsafe static T WrapElement(IntPtr memberPointer)
		{
			if (poDoDrcFXk46aPljVUN.muOq5LWqgj(Il2CppReferenceArray<T>.ourCachedInstanceCtor, null, poDoDrcFXk46aPljVUN.R3ocR9GXgZ))
			{
				Il2CppReferenceArray<T>.ourCachedInstanceCtor = Fj0pGZq4FxSKcr9u2UH.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), new Type[]
				{
					KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(IntPtr).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV)
				}, Fj0pGZq4FxSKcr9u2UH.QGxq3iFYNq);
			}
			if (Il2CppReferenceArray<T>.ourElementIsValueType)
			{
				return (T)((object)Il2CppReferenceArray<T>.ourCachedInstanceCtor.Invoke(new object[]
				{
					IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<T>.NativeClassPtr, memberPointer)
				}));
			}
			IntPtr intPtr = *memberPointer;
			if (intPtr == IntPtr.Zero)
			{
				return default(T);
			}
			if (LQUO1O5zLvD95E2LLPK.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Il2CppObjectBase).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), LQUO1O5zLvD95E2LLPK.S3EAleLciW))
			{
				IntPtr nativeClassPtr = Il2CppClassPointerStore<T>.NativeClassPtr;
				IL2CPP.il2cpp_object_get_class(intPtr);
			}
			return (T)((object)Il2CppReferenceArray<T>.ourCachedInstanceCtor.Invoke(new object[]
			{
				intPtr
			}));
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00014988 File Offset: 0x00012B88
		private static IntPtr AllocateArray(long size)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_2F;
				case 2:
					if (size >= 0L)
					{
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e82c749fe41a4203930245c7cb92bede == 0)
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
			goto IL_7A;
			IL_2F:
			IntPtr nativeClassPtr = Il2CppClassPointerStore<T>.NativeClassPtr;
			if (nativeClassPtr == IntPtr.Zero)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(48, 2);
				CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1376963134 ^ -1201013867 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eec4384c7d0d42baa74a4dbdbdbdd8df), CbStEuAV6XsjbRRcotu.WZrA06bJrN);
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(863254910 ^ 946384040 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e6eb36653ec04a89bf8fa64932849f3b), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV));
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-635121885 ^ -152093601 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_64a8b41e58e0491ab0e9d05ec5ed61d3), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				throw new ArgumentException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
			}
			return IL2CPP.il2cpp_array_new(nativeClassPtr, (ulong)size);
			IL_7A:
			throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(149850228 ^ 404347378 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7dfb1d10537744ca9e949b6b3a3eac09), hIDAYxH6DWLHIthQgC.gSCeTtiku(811079790 ^ 104570482 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_508916f527eb4b05b32762ef07dd9e52));
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00014B08 File Offset: 0x00012D08
		internal static bool rSkBS9pRA7noZ82V8f2()
		{
			return Il2CppReferenceArray<T>.sducotpFxSFDdnslUHd == null;
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00014B1C File Offset: 0x00012D1C
		internal static object MgRChJpMj8EyYbLrPc1()
		{
			return Il2CppReferenceArray<T>.sducotpFxSFDdnslUHd;
		}

		// Token: 0x0400097F RID: 2431
		private static ConstructorInfo ourCachedInstanceCtor;

		// Token: 0x04000980 RID: 2432
		private static readonly int ourElementTypeSize;

		// Token: 0x04000981 RID: 2433
		private static readonly bool ourElementIsValueType;

		// Token: 0x04000982 RID: 2434
		internal static object sducotpFxSFDdnslUHd;
	}
}
