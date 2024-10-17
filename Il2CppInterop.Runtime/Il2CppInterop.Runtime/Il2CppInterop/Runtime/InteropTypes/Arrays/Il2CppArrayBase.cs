using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.InteropTypes.Arrays
{
	// Token: 0x0200012C RID: 300
	public abstract class Il2CppArrayBase<T> : Il2CppObjectBase, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x06000D14 RID: 3348 RVA: 0x00014710 File Offset: 0x00012910
		protected Il2CppArrayBase(IntPtr pointer)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor(pointer);
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_4cb85c330fed4a769825a3343f966401 != 0)
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
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x00014778 File Offset: 0x00012978
		public int Length
		{
			get
			{
				return (int)IL2CPP.il2cpp_array_length(base.Pointer);
			}
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x0001478C File Offset: 0x0001298C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0001479C File Offset: 0x0001299C
		public IEnumerator<T> GetEnumerator()
		{
			return new Il2CppArrayBase<T>.IndexEnumerator(this);
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x000147AC File Offset: 0x000129AC
		void ICollection<!0>.Add(T item)
		{
			Il2CppArrayBase<T>.ThrowImmutableLength();
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x000147BC File Offset: 0x000129BC
		void ICollection<!0>.Clear()
		{
			Il2CppArrayBase<T>.ThrowImmutableLength();
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x000147CC File Offset: 0x000129CC
		public bool Contains(T item)
		{
			return this.IndexOf(item) != -1;
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x000147E4 File Offset: 0x000129E4
		public void CopyTo(T[] array, int arrayIndex)
		{
			int num = 11;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			for (;;)
			{
				int num2 = num;
				int num3;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-344551199 + 798742277 ^ 2132040356 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_636316cf576545aba2f7d326dd7e140b), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						num2 = 5;
						continue;
					case 2:
						goto IL_231;
					case 3:
						num3++;
						num2 = 9;
						continue;
					case 4:
						if (array.Length - arrayIndex < this.Length)
						{
							goto IL_266;
						}
						num2 = 14;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_feee416e61094c739ba253659ac2e257 == 0)
						{
							num2 = 15;
							continue;
						}
						continue;
					case 5:
						defaultInterpolatedStringHandler.AppendFormatted<int>(array.Length - arrayIndex);
						num2 = 6;
						continue;
					case 6:
						goto IL_11E;
					case 7:
						goto IL_266;
					case 8:
						return;
					case 9:
						goto IL_231;
					case 10:
						goto IL_19D;
					case 11:
						if (array != null)
						{
							goto IL_1BF;
						}
						num2 = 10;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fcdd30171ceb4eb7a5570cbbc4f6aec1 == 0)
						{
							num2 = 8;
							continue;
						}
						continue;
					case 12:
						goto IL_211;
					case 13:
						defaultInterpolatedStringHandler.AppendFormatted<int>(this.Length);
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c2ad52141772446383547acade021f9a != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 14:
						goto IL_CE;
					case 15:
						goto IL_257;
					}
					QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1484788881 ^ 851493816 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_944294969d634011bf30e3f4f506a31e), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
					num2 = 13;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3cdc0c80f3644c499e0bcd7810be1cee == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_231:
					if (num3 >= this.Length)
					{
						num2 = 8;
						continue;
					}
					goto IL_211;
					IL_266:
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 2);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e236d804047744298c2380563ba7eca0 != 0)
					{
						num2 = 0;
					}
				}
				IL_1BF:
				if (arrayIndex >= 0)
				{
					num = 4;
					continue;
				}
				break;
				IL_211:
				array[num3 + arrayIndex] = this[num3];
				num = 3;
				continue;
				IL_257:
				num3 = 0;
				num = 2;
			}
			IL_CE:
			throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(-870035336 ^ -1707817066 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_806dbdb7f5194c2fa0c07a915df13fc8));
			IL_11E:
			throw new ArgumentException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
			IL_19D:
			throw new ArgumentNullException(hIDAYxH6DWLHIthQgC.gSCeTtiku(~-310908475 ^ 621752813 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c474f43efb4d4f17b5c0c1bf3216ef4d));
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00014A80 File Offset: 0x00012C80
		bool ICollection<!0>.Remove(T item)
		{
			return Il2CppArrayBase<T>.ThrowImmutableLength();
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x00014A90 File Offset: 0x00012C90
		public int Count
		{
			get
			{
				return this.Length;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00014AA0 File Offset: 0x00012CA0
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00014AAC File Offset: 0x00012CAC
		public int IndexOf(T item)
		{
			for (int i = 0; i < this.Length; i++)
			{
				if (XLEyvXISui46uUaIBn7.i2IAUFsOOC(item, this[i], XLEyvXISui46uUaIBn7.jKNIgVyiGT))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00014AFC File Offset: 0x00012CFC
		void IList<!0>.Insert(int index, T item)
		{
			Il2CppArrayBase<T>.ThrowImmutableLength();
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00014B0C File Offset: 0x00012D0C
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

		// Token: 0x06000D24 RID: 3364 RVA: 0x00014B1C File Offset: 0x00012D1C
		protected static void StaticCtorBody(Type ownType)
		{
			int num = 6;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
				{
					IntPtr intPtr;
					Il2CppClassPointerStore.SetNativeClassPointer(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Il2CppArrayBase<T>).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), intPtr);
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc != 0)
					{
						num2 = 1;
					}
					break;
				}
				case 1:
					Il2CppClassPointerStore<Il2CppArrayBase<T>>.CreatedTypeRedirect = ownType;
					num2 = 7;
					break;
				case 2:
					return;
				case 3:
				{
					IntPtr intPtr;
					if (intPtr == IntPtr.Zero)
					{
						num2 = 2;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						Il2CppClassPointerStore.SetNativeClassPointer(ownType, intPtr);
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_16defe672aac4a3485dcd78387beb521 != 0)
						{
							num2 = 0;
						}
					}
					break;
				}
				case 4:
					return;
				case 5:
				{
					IntPtr nativeClassPtr;
					if (nativeClassPtr == IntPtr.Zero)
					{
						num2 = 4;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9c5de7c7e06f4557898ef7a8362c30ee != 0)
						{
							num2 = 4;
						}
					}
					else
					{
						IntPtr intPtr = IL2CPP.il2cpp_array_class_get(nativeClassPtr, 1U);
						num2 = 3;
					}
					break;
				}
				case 6:
				{
					IntPtr nativeClassPtr = Il2CppClassPointerStore<T>.NativeClassPtr;
					num2 = 5;
					break;
				}
				case 7:
					return;
				}
			}
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00014C58 File Offset: 0x00012E58
		private static bool ThrowImmutableLength()
		{
			throw new NotSupportedException(hIDAYxH6DWLHIthQgC.gSCeTtiku(-135708587 << 5 ^ -548347617 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e4c6981dbbef43b3a6de5ad27be6a3b1));
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00014C88 File Offset: 0x00012E88
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

		// Token: 0x06000D27 RID: 3367 RVA: 0x00014CD4 File Offset: 0x00012ED4
		public static Il2CppArrayBase<T> WrapNativeGenericArrayPointer(IntPtr pointer)
		{
			if (pointer == IntPtr.Zero)
			{
				return null;
			}
			if (dPsigOUwJdO4bwskNJ5.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(string).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), dPsigOUwJdO4bwskNJ5.hvvUeCiIEf))
			{
				return new Il2CppStringArray(pointer) as Il2CppArrayBase<T>;
			}
			if (Yrmd8g9wkq9EHP2RruW.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), Yrmd8g9wkq9EHP2RruW.LkX9e9T03c))
			{
				return bFfvVxI2DKZLSU4QQXm.i2IAUFsOOC(F9k0QHqwuAF4DuGYBHT.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Il2CppStructArray<>).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), new Type[]
				{
					byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an)
				}, F9k0QHqwuAF4DuGYBHT.AMmqeBVp2m), new object[]
				{
					pointer
				}, bFfvVxI2DKZLSU4QQXm.d0AIy6X62W) as Il2CppArrayBase<T>;
			}
			if (jQdCBeqaKbkTrjy04fc.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Il2CppObjectBase).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), jQdCBeqaKbkTrjy04fc.AL9qC4lG9P))
			{
				return bFfvVxI2DKZLSU4QQXm.i2IAUFsOOC(F9k0QHqwuAF4DuGYBHT.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Il2CppReferenceArray<>).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), new Type[]
				{
					byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an)
				}, F9k0QHqwuAF4DuGYBHT.AMmqeBVp2m), new object[]
				{
					pointer
				}, bFfvVxI2DKZLSU4QQXm.d0AIy6X62W) as Il2CppArrayBase<T>;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(94, 1);
			defaultInterpolatedStringHandler.AppendFormatted<Type>(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an));
			QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-463666365 ^ -1910647874 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_944294969d634011bf30e3f4f506a31e), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
			throw new ArgumentException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00014E74 File Offset: 0x00013074
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppArrayBase()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00014E84 File Offset: 0x00013084
		internal static bool OmLBQM7psdRMsBX1w6r()
		{
			return Il2CppArrayBase<T>.Dqkwly7M40A9WrQvBcF == null;
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00014E98 File Offset: 0x00013098
		internal static object FwlFBX74X2pfEtn11Bw()
		{
			return Il2CppArrayBase<T>.Dqkwly7M40A9WrQvBcF;
		}

		// Token: 0x04000986 RID: 2438
		internal static object Dqkwly7M40A9WrQvBcF;

		// Token: 0x0200012D RID: 301
		private class IndexEnumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			// Token: 0x06000D2B RID: 3371 RVA: 0x00028C88 File Offset: 0x00026E88
			public IndexEnumerator(Il2CppArrayBase<T> array)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				this.myIndex = -1;
				base..ctor();
				this.myArray = array;
			}

			// Token: 0x06000D2C RID: 3372 RVA: 0x00028CB0 File Offset: 0x00026EB0
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_0783948440564d328b8e79831447d3f6 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x06000D2D RID: 3373 RVA: 0x00028D10 File Offset: 0x00026F10
			public bool MoveNext()
			{
				int num = 1;
				int num2 = num;
				int num3;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						num3 = this.myIndex + 1;
						this.myIndex = num3;
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e236d804047744298c2380563ba7eca0 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				return num3 < this.myArray.Count;
			}

			// Token: 0x06000D2E RID: 3374 RVA: 0x00028D88 File Offset: 0x00026F88
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c4640bbaac7c4988b56f91d1b6b3f1a9 != 0)
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
			// (get) Token: 0x06000D2F RID: 3375 RVA: 0x00028DE8 File Offset: 0x00026FE8
			object IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x170004DF RID: 1247
			// (get) Token: 0x06000D30 RID: 3376 RVA: 0x00028DFC File Offset: 0x00026FFC
			public T Current
			{
				get
				{
					return this.myArray[this.myIndex];
				}
			}

			// Token: 0x06000D31 RID: 3377 RVA: 0x00028E18 File Offset: 0x00027018
			// Note: this type is marked as 'beforefieldinit'.
			static IndexEnumerator()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000D32 RID: 3378 RVA: 0x00028E28 File Offset: 0x00027028
			internal static bool E8NttPdmDmHdKVOfw4A()
			{
				return Il2CppArrayBase<T>.IndexEnumerator.YNCesTdXXNLM52co2tr == null;
			}

			// Token: 0x06000D33 RID: 3379 RVA: 0x00028E3C File Offset: 0x0002703C
			internal static object Dpn8ovdvq3sd1VNs6TP()
			{
				return Il2CppArrayBase<T>.IndexEnumerator.YNCesTdXXNLM52co2tr;
			}

			// Token: 0x04000987 RID: 2439
			private Il2CppArrayBase<T> myArray;

			// Token: 0x04000988 RID: 2440
			private int myIndex;

			// Token: 0x04000989 RID: 2441
			private static object YNCesTdXXNLM52co2tr;
		}
	}
}
