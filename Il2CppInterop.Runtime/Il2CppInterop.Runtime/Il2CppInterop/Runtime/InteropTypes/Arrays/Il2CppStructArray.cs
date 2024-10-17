using System;
using System.Runtime.CompilerServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.InteropTypes.Arrays
{
	// Token: 0x02000130 RID: 304
	public class Il2CppStructArray<[IsUnmanaged] T> : Il2CppArrayBase<T> where T : struct, ValueType
	{
		// Token: 0x06000D55 RID: 3413 RVA: 0x00015F18 File Offset: 0x00014118
		static Il2CppStructArray()
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					hIDAYxH6DWLHIthQgC.zSLipEDdx();
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_483eecf3691e4ef2b23b2d4cb2ca3d52 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
					num2 = 4;
					continue;
				case 3:
					return;
				case 4:
					Il2CppArrayBase<T>.StaticCtorBody(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Il2CppStructArray<T>).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an));
					num2 = 3;
					continue;
				}
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				num2 = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ea3a0368554c4e6093e0b0561ffd5cef != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00015FD4 File Offset: 0x000141D4
		public Il2CppStructArray(IntPtr nativeObject)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor(nativeObject);
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6e39fb1a8feb46889b60abcfbb34e0df == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0001603C File Offset: 0x0001423C
		public Il2CppStructArray(long size)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor(Il2CppStructArray<T>.AllocateArray(size));
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_282cf292112a4cf49ec1b8b2e2e7602a != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x000160A8 File Offset: 0x000142A8
		public Il2CppStructArray(T[] arr)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor(Il2CppStructArray<T>.AllocateArray((long)arr.Length));
			int num = 4;
			for (;;)
			{
				int num2;
				switch (num)
				{
				case 0:
					goto IL_A6;
				case 1:
					break;
				case 2:
					break;
				case 3:
					num2++;
					num = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9a3e85e731764e36a5b07f4e692becd8 == 0)
					{
						num = 1;
						continue;
					}
					continue;
				case 4:
					num2 = 0;
					num = 2;
					continue;
				case 5:
					return;
				default:
					goto IL_A6;
				}
				if (num2 >= arr.Length)
				{
					num = 5;
					continue;
				}
				IL_A6:
				this[num2] = arr[num2];
				num = 3;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bc244a0192c343599cd1cf83671e02ab == 0)
				{
					num = 0;
				}
			}
		}

		// Token: 0x170004E2 RID: 1250
		public unsafe override T this[int index]
		{
			get
			{
				if (index < 0 || index >= base.Length)
				{
					throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(1614682224 ^ 2034914722 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_1d16dd38ead14cb191f3b77c23c04ed4), hIDAYxH6DWLHIthQgC.gSCeTtiku(~-572906782 ^ 1105873764 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bd64431fd05f4961aa9b79e5bd243164));
				}
				IntPtr intPtr = ksqFb8Il85Vq0skiabV.i2IAUFsOOC(base.Pointer, 4 * IreLT7A0Ync4AwEXIgw.i2IAUFsOOC(IreLT7A0Ync4AwEXIgw.thqANbO0eM), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				return *(T*)((byte*)JFwKeLIuFdrVcU89o72.i2IAUFsOOC(ref intPtr, JFwKeLIuFdrVcU89o72.xshIEqMN4b) + (IntPtr)index * (IntPtr)sizeof(T));
			}
			set
			{
				if (index < 0 || index >= base.Length)
				{
					throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1096198476 - 1277016560 ^ 1057772316 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6926da1cf80047d3a6f0516668d22380), hIDAYxH6DWLHIthQgC.gSCeTtiku(-1096198476 - 1277016560 ^ 1013395776 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f65b5965aa9843ea8b738fef02a2c6c9));
				}
				IntPtr intPtr = ksqFb8Il85Vq0skiabV.i2IAUFsOOC(base.Pointer, 4 * IreLT7A0Ync4AwEXIgw.i2IAUFsOOC(IreLT7A0Ync4AwEXIgw.thqANbO0eM), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				*(T*)((byte*)JFwKeLIuFdrVcU89o72.i2IAUFsOOC(ref intPtr, JFwKeLIuFdrVcU89o72.xshIEqMN4b) + (IntPtr)index * (IntPtr)sizeof(T)) = value;
			}
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x000162F4 File Offset: 0x000144F4
		public static implicit operator Il2CppStructArray<T>(T[] arr)
		{
			if (arr == null)
			{
				return null;
			}
			return new Il2CppStructArray<T>(arr);
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0001630C File Offset: 0x0001450C
		private static IntPtr AllocateArray(long size)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_56;
				case 2:
					if (size >= 0L)
					{
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5f6b46e73a464a41b29ca79bf0f3b8f9 == 0)
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
			IL_56:
			IntPtr nativeClassPtr = Il2CppClassPointerStore<T>.NativeClassPtr;
			if (nativeClassPtr == IntPtr.Zero)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(48, 2);
				FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1084408557 ^ -1339710497 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40), FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1911984843 ^ 1001826093 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_db312e48eee84539b805fee2f73a8cde), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an));
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(996372030 ^ 1033469007 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				throw new ArgumentException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
			}
			return IL2CPP.il2cpp_array_new(nativeClassPtr, (ulong)size);
			IL_7A:
			throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(735523184 ^ 2095215598 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2210d7ca22c24335b32d80ca3ef84b8e), hIDAYxH6DWLHIthQgC.gSCeTtiku(1736570558 << 6 ^ -683915886 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4ab786fa8604298818cd412db8f702f));
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00016494 File Offset: 0x00014694
		internal static bool QTBDlaRuyJxeWHXWDvA()
		{
			return Il2CppStructArray<T>.KNFkiuRNiyDYgDrGQfL == null;
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x000164A8 File Offset: 0x000146A8
		internal static object QCVRLlREYia56PcrW48()
		{
			return Il2CppStructArray<T>.KNFkiuRNiyDYgDrGQfL;
		}

		// Token: 0x0400098F RID: 2447
		internal static object KNFkiuRNiyDYgDrGQfL;
	}
}
