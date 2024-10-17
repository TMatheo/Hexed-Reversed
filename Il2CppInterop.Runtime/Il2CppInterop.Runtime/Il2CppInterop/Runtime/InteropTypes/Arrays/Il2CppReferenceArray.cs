using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.InteropTypes.Arrays
{
	// Token: 0x0200012E RID: 302
	public class Il2CppReferenceArray<T> : Il2CppArrayBase<T> where T : Il2CppObjectBase
	{
		// Token: 0x06000D34 RID: 3380 RVA: 0x00014EA8 File Offset: 0x000130A8
		static Il2CppReferenceArray()
		{
			int num = 5;
			for (;;)
			{
				int num2 = num;
				IntPtr nativeClassPtr;
				uint num3;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_188;
					case 1:
						nativeClassPtr = Il2CppClassPointerStore<T>.NativeClassPtr;
						num2 = 7;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e0435cb0909b493e882d051900e9ae38 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						if (IL2CPP.il2cpp_class_is_valuetype(nativeClassPtr))
						{
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4ab786fa8604298818cd412db8f702f != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 4:
						hIDAYxH6DWLHIthQgC.oDuBOTgYK();
						num2 = 8;
						continue;
					case 5:
						hIDAYxH6DWLHIthQgC.zSLipEDdx();
						num2 = 4;
						continue;
					case 6:
						Il2CppReferenceArray<T>.ourElementTypeSize = IreLT7A0Ync4AwEXIgw.i2IAUFsOOC(IreLT7A0Ync4AwEXIgw.thqANbO0eM);
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2e7e5b018e46a2b3bb280ae243eb22 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 7:
						if (nativeClassPtr == IntPtr.Zero)
						{
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56c162609824bd799f0a7b9a8c33c89 == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						}
						else
						{
							num3 = 0U;
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc != 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						break;
					case 8:
						nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
						num2 = 6;
						continue;
					case 9:
						return;
					case 10:
						break;
					case 11:
						goto IL_16C;
					default:
						goto IL_188;
					}
					Il2CppArrayBase<T>.StaticCtorBody(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Il2CppReferenceArray<T>).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an));
					num2 = 9;
					continue;
					IL_188:
					Il2CppReferenceArray<T>.ourElementIsValueType = true;
					num2 = 11;
				}
				IL_16C:
				Il2CppReferenceArray<T>.ourElementTypeSize = IL2CPP.il2cpp_class_value_size(nativeClassPtr, ref num3);
				num = 10;
			}
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0001504C File Offset: 0x0001324C
		public Il2CppReferenceArray(IntPtr nativeObject)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor(nativeObject);
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a36e967c0f044e9ebf523536bdec8e28 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x000150B4 File Offset: 0x000132B4
		public Il2CppReferenceArray(long size)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor(Il2CppReferenceArray<T>.AllocateArray(size));
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e0435cb0909b493e882d051900e9ae38 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00015120 File Offset: 0x00013320
		public Il2CppReferenceArray(T[] arr)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor(Il2CppReferenceArray<T>.AllocateArray((long)arr.Length));
			int num = 5;
			for (;;)
			{
				int num2;
				switch (num)
				{
				case 1:
					goto IL_D2;
				case 3:
					goto IL_D2;
				case 4:
					return;
				case 5:
					num2 = 0;
					num = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2dd85386720b438b874026b47430e4fa != 0)
					{
						num = 0;
						continue;
					}
					continue;
				case 6:
					num2++;
					num = 2;
					continue;
				}
				IL_63:
				if (num2 >= arr.Length)
				{
					break;
				}
				num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_084a47a7baf94bf79b9c3fbf8d684053 == 0)
				{
					num = 1;
					continue;
				}
				continue;
				IL_D2:
				this[num2] = arr[num2];
				num = 6;
				continue;
				goto IL_63;
			}
		}

		// Token: 0x170004E0 RID: 1248
		public override T this[int index]
		{
			get
			{
				if (index < 0 || index >= base.Length)
				{
					throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(~2031287826 ^ -1635314834 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_74d61b1611df4615bd4df289712ea178), hIDAYxH6DWLHIthQgC.gSCeTtiku(1887176262 ^ 1988499321 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c));
				}
				return Il2CppReferenceArray<T>.WrapElement(ksqFb8Il85Vq0skiabV.i2IAUFsOOC(ksqFb8Il85Vq0skiabV.i2IAUFsOOC(base.Pointer, 4 * IreLT7A0Ync4AwEXIgw.i2IAUFsOOC(IreLT7A0Ync4AwEXIgw.thqANbO0eM), ksqFb8Il85Vq0skiabV.j8CIVKyZg8), index * Il2CppReferenceArray<T>.ourElementTypeSize, ksqFb8Il85Vq0skiabV.j8CIVKyZg8));
			}
			set
			{
				if (index < 0 || index >= base.Length)
				{
					throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(660591337 ^ 1323199429 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_afe904a262fb47328a49943b4b34b494), hIDAYxH6DWLHIthQgC.gSCeTtiku(386187679 ^ 2109963709 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7c2c0376e816400db5716cff194385b2));
				}
				IntPtr targetPointer = ksqFb8Il85Vq0skiabV.i2IAUFsOOC(ksqFb8Il85Vq0skiabV.i2IAUFsOOC(base.Pointer, 4 * IreLT7A0Ync4AwEXIgw.i2IAUFsOOC(IreLT7A0Ync4AwEXIgw.thqANbO0eM), ksqFb8Il85Vq0skiabV.j8CIVKyZg8), index * Il2CppReferenceArray<T>.ourElementTypeSize, ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				T t = value;
				Il2CppReferenceArray<T>.StoreValue(targetPointer, (t != null) ? t.Pointer : IntPtr.Zero);
			}
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00015374 File Offset: 0x00013574
		public static implicit operator Il2CppReferenceArray<T>(T[] arr)
		{
			if (arr == null)
			{
				return null;
			}
			return new Il2CppReferenceArray<T>(arr);
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x0001538C File Offset: 0x0001358C
		private unsafe static void StoreValue(IntPtr targetPointer, IntPtr valuePointer)
		{
			int num = 7;
			int num2 = num;
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					goto IL_176;
				case 1:
					return;
				case 2:
					return;
				case 3:
					num3 = 0;
					num2 = 5;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					break;
				case 5:
					goto IL_9F;
				case 6:
					*targetPointer = valuePointer;
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c504ab11ece64b14b01df2d4c88e6e49 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 7:
					if (!Il2CppReferenceArray<T>.ourElementIsValueType)
					{
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_483eecf3691e4ef2b23b2d4cb2ca3d52 == 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					}
					break;
				case 8:
					goto IL_9F;
				case 9:
					goto IL_C5;
				case 10:
					num2 = 3;
					continue;
				case 11:
					goto IL_14B;
				default:
					goto IL_176;
				}
				byte* ptr;
				if (valuePointer == IntPtr.Zero)
				{
					num2 = 7;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_780e0c86b08f49d785f406cf802c7e87 == 0)
					{
						num2 = 9;
						continue;
					}
					continue;
				}
				else
				{
					ptr = IL2CPP.il2cpp_object_unbox(valuePointer);
					num2 = 2;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_483eecf3691e4ef2b23b2d4cb2ca3d52 == 0)
					{
						num2 = 10;
						continue;
					}
					continue;
				}
				IL_9F:
				if (num3 >= Il2CppReferenceArray<T>.ourElementTypeSize)
				{
					num2 = 2;
					continue;
				}
				IL_14B:
				*(targetPointer + (IntPtr)num3) = ptr[num3];
				num2 = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_468d644ed32a4ba3ad77ef2c95e2ad4b == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_176:
				num3++;
				num2 = 8;
			}
			return;
			IL_C5:
			throw new NullReferenceException();
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00015544 File Offset: 0x00013744
		private unsafe static T WrapElement(IntPtr memberPointer)
		{
			if (OmA7ZlIOQWjfTHiCBaf.i2IAUFsOOC(Il2CppReferenceArray<T>.ourCachedInstanceCtor, null, OmA7ZlIOQWjfTHiCBaf.mbBIXsiRtT))
			{
				Il2CppReferenceArray<T>.ourCachedInstanceCtor = b27ekHAlO1XXce9pRo0.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), new Type[]
				{
					byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(IntPtr).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an)
				}, b27ekHAlO1XXce9pRo0.EtlAV2R4Yl);
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
			if (jQdCBeqaKbkTrjy04fc.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Il2CppObjectBase).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), jQdCBeqaKbkTrjy04fc.AL9qC4lG9P))
			{
				IntPtr nativeClassPtr = Il2CppClassPointerStore<T>.NativeClassPtr;
				IL2CPP.il2cpp_object_get_class(intPtr);
			}
			return (T)((object)Il2CppReferenceArray<T>.ourCachedInstanceCtor.Invoke(new object[]
			{
				intPtr
			}));
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00015648 File Offset: 0x00013848
		private static IntPtr AllocateArray(long size)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (size >= 0L)
					{
						goto IL_9A;
					}
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_dbbda98ba6574101bc623ad559f7b5a3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(256602955 + -2081249470 ^ -1579035294 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9cbee6d56f49422699718938ff979567), hIDAYxH6DWLHIthQgC.gSCeTtiku(81407119 ^ 819357190 ^ 1390077127 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ba3f6bd5a09c47868765e25f534dbf2a));
			IL_9A:
			IntPtr nativeClassPtr = Il2CppClassPointerStore<T>.NativeClassPtr;
			if (nativeClassPtr == IntPtr.Zero)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(48, 2);
				FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1253386989 << 6 ^ -545825934 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bacedfb8a3cf4671ae3e03ec2f965495), FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-2053189787 ^ -1994547518 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c504ab11ece64b14b01df2d4c88e6e49), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an));
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(~1015743027 ^ -1733064796 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fcdd30171ceb4eb7a5570cbbc4f6aec1), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				throw new ArgumentException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
			}
			return IL2CPP.il2cpp_array_new(nativeClassPtr, (ulong)size);
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x000157B4 File Offset: 0x000139B4
		internal static bool xd5wGoRHvt9DOjAHGyr()
		{
			return Il2CppReferenceArray<T>.U2NSL47zbVdCg6I6VwA == null;
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x000157C8 File Offset: 0x000139C8
		internal static object U9rk6MRAwRPADTB2olU()
		{
			return Il2CppReferenceArray<T>.U2NSL47zbVdCg6I6VwA;
		}

		// Token: 0x0400098A RID: 2442
		private static ConstructorInfo ourCachedInstanceCtor;

		// Token: 0x0400098B RID: 2443
		private static readonly int ourElementTypeSize;

		// Token: 0x0400098C RID: 2444
		private static readonly bool ourElementIsValueType;

		// Token: 0x0400098D RID: 2445
		private static object U2NSL47zbVdCg6I6VwA;
	}
}
