using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.InteropTypes.Arrays
{
	// Token: 0x0200012A RID: 298
	public abstract class Il2CppArrayBase<T> : Il2CppObjectBase, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x06000CF2 RID: 3314 RVA: 0x00013A90 File Offset: 0x00011C90
		protected Il2CppArrayBase(IntPtr pointer)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor(pointer);
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_1f1b1b07c9f5435991b0738ea3210852 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x00013AF8 File Offset: 0x00011CF8
		public int Length
		{
			get
			{
				return (int)IL2CPP.il2cpp_array_length(base.Pointer);
			}
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00013B0C File Offset: 0x00011D0C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00013B1C File Offset: 0x00011D1C
		public IEnumerator<T> GetEnumerator()
		{
			return new Il2CppArrayBase<T>.IndexEnumerator(this);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00013B2C File Offset: 0x00011D2C
		void ICollection<!0>.Add(T item)
		{
			Il2CppArrayBase<T>.ThrowImmutableLength();
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00013B3C File Offset: 0x00011D3C
		void ICollection<!0>.Clear()
		{
			Il2CppArrayBase<T>.ThrowImmutableLength();
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00013B4C File Offset: 0x00011D4C
		public bool Contains(T item)
		{
			return this.IndexOf(item) != -1;
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00013B64 File Offset: 0x00011D64
		public void CopyTo(T[] array, int arrayIndex)
		{
			int num = 3;
			int num2 = num;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					goto IL_186;
				case 1:
					gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1090394566 >> 5 ^ 1940674939 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_23fed2b647424ffc818af5297e87fd1e), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
					num2 = 7;
					continue;
				case 2:
					goto IL_113;
				case 3:
					if (array == null)
					{
						num2 = 2;
						continue;
					}
					if (arrayIndex < 0)
					{
						num2 = 9;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eec4384c7d0d42baa74a4dbdbdbdd8df == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					else
					{
						if (array.Length - arrayIndex < this.Length)
						{
							num2 = 12;
							continue;
						}
						num3 = 0;
						num2 = 4;
						continue;
					}
					break;
				case 4:
					goto IL_186;
				case 5:
					defaultInterpolatedStringHandler.AppendFormatted<int>(this.Length);
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_30f9f5d7d3f347ddac00a7ce0719d7cd == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 6:
					num3++;
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8b1b71d923f0486b89239dd4a11f6d34 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 7:
					defaultInterpolatedStringHandler.AppendFormatted<int>(array.Length - arrayIndex);
					num2 = 10;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3e2009ed69c04f5799431b4e58cafb2a != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 8:
					gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-277145156 ^ -114464257 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b329e831708e4d29ae561982d3d8c1c1), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
					num2 = 5;
					continue;
				case 9:
					goto IL_20F;
				case 10:
					goto IL_C3;
				case 11:
					break;
				case 12:
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 2);
					num2 = 8;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_dd9c757bd882429784d62f0e80f112e6 == 0)
					{
						num2 = 6;
						continue;
					}
					continue;
				case 13:
					return;
				default:
					goto IL_186;
				}
				IL_E2:
				array[num3 + arrayIndex] = this[num3];
				num2 = 6;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_754a6df239be4343a1e8b95a82be3f48 != 0)
				{
					num2 = 3;
					continue;
				}
				continue;
				IL_186:
				if (num3 < this.Length)
				{
					goto IL_E2;
				}
				num2 = 13;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_23fed2b647424ffc818af5297e87fd1e == 0)
				{
					num2 = 1;
				}
			}
			IL_C3:
			throw new ArgumentException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
			IL_113:
			throw new ArgumentNullException(hIDAYxH6DWLHIthQgC.gSCeTtiku(-357604844 ^ -1424392904 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_30f9f5d7d3f347ddac00a7ce0719d7cd));
			IL_20F:
			throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1039001447 >> 2 ^ -1903627856 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0272cc4de9694915be17746e515675c8));
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00013DFC File Offset: 0x00011FFC
		bool ICollection<!0>.Remove(T item)
		{
			return Il2CppArrayBase<T>.ThrowImmutableLength();
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x00013E0C File Offset: 0x0001200C
		public int Count
		{
			get
			{
				return this.Length;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x00013E1C File Offset: 0x0001201C
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00013E28 File Offset: 0x00012028
		public int IndexOf(T item)
		{
			for (int i = 0; i < this.Length; i++)
			{
				if (qXNx62c7iINKRNEVUDt.muOq5LWqgj(item, this[i], qXNx62c7iINKRNEVUDt.uagcPHeHpn))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00013E78 File Offset: 0x00012078
		void IList<!0>.Insert(int index, T item)
		{
			Il2CppArrayBase<T>.ThrowImmutableLength();
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00013E88 File Offset: 0x00012088
		void IList<!0>.RemoveAt(int index)
		{
			Il2CppArrayBase<T>.ThrowImmutableLength();
		}

		// Token: 0x170004DD RID: 1245
		public abstract T this[int index]
		{
			get;
			set;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00013E98 File Offset: 0x00012098
		protected static void StaticCtorBody(Type ownType)
		{
			int num = 1;
			for (;;)
			{
				int num2 = num;
				IntPtr intPtr;
				for (;;)
				{
					IntPtr nativeClassPtr;
					switch (num2)
					{
					case 1:
						nativeClassPtr = Il2CppClassPointerStore<T>.NativeClassPtr;
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_791a252a9221476faad2c6d41e84a167 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_91;
					case 3:
						return;
					case 4:
						return;
					case 5:
						return;
					case 6:
						if (intPtr == IntPtr.Zero)
						{
							num2 = 3;
							continue;
						}
						Il2CppClassPointerStore.SetNativeClassPointer(ownType, intPtr);
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4da80845ebf7410ebbf942336f5ee27b != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 7:
						Il2CppClassPointerStore<Il2CppArrayBase<T>>.CreatedTypeRedirect = ownType;
						num2 = 5;
						continue;
					}
					if (nativeClassPtr == IntPtr.Zero)
					{
						num2 = 4;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_960a54aec0f640cd975b2d62f3e0a596 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						intPtr = IL2CPP.il2cpp_array_class_get(nativeClassPtr, 1U);
						num2 = 6;
					}
				}
				IL_91:
				Il2CppClassPointerStore.SetNativeClassPointer(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Il2CppArrayBase<T>).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), intPtr);
				num = 7;
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00013FC0 File Offset: 0x000121C0
		private static bool ThrowImmutableLength()
		{
			throw new NotSupportedException(hIDAYxH6DWLHIthQgC.gSCeTtiku(-225340272 ^ -420796685 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ac2c10c141e144acbcef06aa86a10430));
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00013FEC File Offset: 0x000121EC
		public static implicit operator T[](Il2CppArrayBase<T> il2CppArray)
		{
			if (il2CppArray == null)
			{
				return null;
			}
			T[] array = new T[il2CppArray.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = il2CppArray[i];
			}
			return array;
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00014038 File Offset: 0x00012238
		public static Il2CppArrayBase<T> WrapNativeGenericArrayPointer(IntPtr pointer)
		{
			if (pointer == IntPtr.Zero)
			{
				return null;
			}
			if (JCwQlA5sGlTyuRZuORY.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(string).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), JCwQlA5sGlTyuRZuORY.fqC5SwdxA5))
			{
				return new Il2CppStringArray(pointer) as Il2CppArrayBase<T>;
			}
			if (x0spFZLsrp0hVQy7PPM.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), x0spFZLsrp0hVQy7PPM.HLcLST3Bek))
			{
				return uOwB4KcDZYIKE8rJ5Wb.muOq5LWqgj(vOp1rUAs3HqOX2RyvZZ.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Il2CppStructArray<>).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), new Type[]
				{
					KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV)
				}, vOp1rUAs3HqOX2RyvZZ.WNkASUA3Cp), new object[]
				{
					pointer
				}, uOwB4KcDZYIKE8rJ5Wb.VeocmNDrMe) as Il2CppArrayBase<T>;
			}
			if (LQUO1O5zLvD95E2LLPK.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Il2CppObjectBase).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), LQUO1O5zLvD95E2LLPK.S3EAleLciW))
			{
				return uOwB4KcDZYIKE8rJ5Wb.muOq5LWqgj(vOp1rUAs3HqOX2RyvZZ.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Il2CppReferenceArray<>).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), new Type[]
				{
					KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV)
				}, vOp1rUAs3HqOX2RyvZZ.WNkASUA3Cp), new object[]
				{
					pointer
				}, uOwB4KcDZYIKE8rJ5Wb.VeocmNDrMe) as Il2CppArrayBase<T>;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(94, 1);
			defaultInterpolatedStringHandler.AppendFormatted<Type>(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV));
			gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(55428970 ^ 649717762 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b169d8ea412f45e99e430384ddc8908b), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
			throw new ArgumentException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x000141D8 File Offset: 0x000123D8
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppArrayBase()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x000141E8 File Offset: 0x000123E8
		internal static bool qo5l8Dpfbb8Pooa4yEs()
		{
			return Il2CppArrayBase<T>.pZqsxjp3tIhxja83UWO == null;
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x000141FC File Offset: 0x000123FC
		internal static object hdS8FNp1EmtOvQLDllV()
		{
			return Il2CppArrayBase<T>.pZqsxjp3tIhxja83UWO;
		}

		// Token: 0x0400097B RID: 2427
		internal static object pZqsxjp3tIhxja83UWO;

		// Token: 0x0200012B RID: 299
		private class IndexEnumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			// Token: 0x06000D09 RID: 3337 RVA: 0x00028030 File Offset: 0x00026230
			public IndexEnumerator(Il2CppArrayBase<T> array)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				this.myIndex = -1;
				base..ctor();
				this.myArray = array;
			}

			// Token: 0x06000D0A RID: 3338 RVA: 0x00028058 File Offset: 0x00026258
			public void Dispose()
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						this.myArray = null;
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4c6a46c0a2d14747aa1dc5bf1581154d == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x06000D0B RID: 3339 RVA: 0x000280B8 File Offset: 0x000262B8
			public bool MoveNext()
			{
				int num = 1;
				int num2 = num;
				int num3;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_2B;
					case 1:
						num3 = this.myIndex + 1;
						this.myIndex = num3;
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_911808c58d664adeb7c16d1e3a32f7fa != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
				IL_2B:
				return num3 < this.myArray.Count;
			}

			// Token: 0x06000D0C RID: 3340 RVA: 0x00028130 File Offset: 0x00026330
			public void Reset()
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						this.myIndex = -1;
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c975b252adfc48c4b262398638f90354 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x170004DE RID: 1246
			// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00028190 File Offset: 0x00026390
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x170004DF RID: 1247
			// (get) Token: 0x06000D0E RID: 3342 RVA: 0x000281A4 File Offset: 0x000263A4
			public T Current
			{
				get
				{
					return this.myArray[this.myIndex];
				}
			}

			// Token: 0x06000D0F RID: 3343 RVA: 0x000281C0 File Offset: 0x000263C0
			// Note: this type is marked as 'beforefieldinit'.
			static IndexEnumerator()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000D10 RID: 3344 RVA: 0x000281D0 File Offset: 0x000263D0
			internal static bool OOA7OT36IKvogLeYqqi()
			{
				return Il2CppArrayBase<T>.IndexEnumerator.LqtnJs3bUfSOvZYcc0v == null;
			}

			// Token: 0x06000D11 RID: 3345 RVA: 0x000281E4 File Offset: 0x000263E4
			internal static object Xs3nHA3y9BZos9HFOV0()
			{
				return Il2CppArrayBase<T>.IndexEnumerator.LqtnJs3bUfSOvZYcc0v;
			}

			// Token: 0x0400097C RID: 2428
			private Il2CppArrayBase<T> myArray;

			// Token: 0x0400097D RID: 2429
			private int myIndex;

			// Token: 0x0400097E RID: 2430
			private static object LqtnJs3bUfSOvZYcc0v;
		}
	}
}
