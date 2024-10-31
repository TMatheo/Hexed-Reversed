using System;
using System.Text;
using Il2CppInterop.Runtime.Wrappers;
using MaoFcf2Vq4taIANM6n;

namespace Il2CppInterop
{
	// Token: 0x02000002 RID: 2
	public static class MarshalExtend
	{
		// Token: 0x06000008 RID: 8 RVA: 0x0000215C File Offset: 0x0000035C
		public static string PtrToString(IntPtr ptr)
		{
			return MarshalExtend.WtYHC7HGheGG77o1YuJ(ptr, MarshalExtend.StrLen(ptr), MarshalExtend.pnpZ1SHBQx98I7jEuoK(BvrxoRqAm5Fek3drElk.AZFqL5aO5D));
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000217C File Offset: 0x0000037C
		public static string PtrToString(IntPtr ptr, int nLen, Encoding encoding)
		{
			int num = 2;
			int num2 = num;
			byte[] array;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					MarshalExtend.pdg7kIHrN4WWqFTHKy5(ptr, array, 0, array.Length, ooayrEqX4VEr4ven4kQ.L7TqchqtXs);
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cc8d2b38a48843c198fb28cbbbd93013 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					array = new byte[nLen];
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b169d8ea412f45e99e430384ddc8908b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return d0GVpXqkDwLXJnTWagY.muOq5LWqgj(encoding, array, 0, array.Length, d0GVpXqkDwLXJnTWagY.zUMq2CpWoP);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002224 File Offset: 0x00000424
		public static IntPtr AllocHGlobal(int size)
		{
			return MarshalExtend.bR4j3mHT2Ycg3Fisd42(IntPtr.Zero, (IntPtr)size, NativeMethods.AllocationType.Commit | NativeMethods.AllocationType.Reserve, NativeMethods.MemoryProtection.ReadWrite);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002240 File Offset: 0x00000440
		public static IntPtr AllocHGlobal(IntPtr address, IntPtr size, NativeMethods.AllocationType allocationType, NativeMethods.MemoryProtection protect)
		{
			return NativeMethods.VirtualAlloc(address, size, allocationType, protect);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002254 File Offset: 0x00000454
		public static void FreeHGlobal(IntPtr buffer)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					MarshalExtend.gAA8hMHgkkpBlLUTK9B(buffer, (UIntPtr)((IntPtr)0));
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_355d73c700924bf28058452e63cd9cf1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000022B4 File Offset: 0x000004B4
		public static void FreeHGlobal(IntPtr buffer, UIntPtr size)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					NativeMethods.NtFreeVirtualMemory(MarshalExtend.KebcBKHUx5BQqhmk8cP(MarshalExtend.Im9FIOHop4L9P2PuECp(PYBSZ5qHmpqoMlj0IM0.t8cqhTZ7d2), QKw2j3qO9xGERtudaYd.eviqt21kqX), ref buffer, ref size, NativeMethods.AllocationType.Decommit | NativeMethods.AllocationType.Release);
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_49f6034724814fe88f4ca6e5ef134249 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002330 File Offset: 0x00000530
		public static int StrLen(IntPtr ptr)
		{
			int num = 2;
			int num2 = num;
			int num3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_78;
				case 1:
					break;
				case 2:
					num3 = 0;
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4f0a774880f74bccb3d4511e5f526375 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					break;
				case 4:
					return num3;
				default:
					goto IL_78;
				}
				if (MarshalExtend.vH47xNHjIF8pWlJM7fo(ptr, num3, eYYuUXqvXIv3gEnJhG7.wf3qxZypwu) == 0)
				{
					num2 = 4;
					continue;
				}
				IL_78:
				num3++;
				num2 = 3;
			}
			return num3;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000023E8 File Offset: 0x000005E8
		public unsafe static int StrLen(byte* ptr)
		{
			return MarshalExtend.hPvAbbHQvGp1sVFGU8d(ptr);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000023F8 File Offset: 0x000005F8
		// Note: this type is marked as 'beforefieldinit'.
		static MarshalExtend()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002408 File Offset: 0x00000608
		internal static object pnpZ1SHBQx98I7jEuoK(object A_0)
		{
			return BvrxoRqAm5Fek3drElk.muOq5LWqgj(A_0);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000241C File Offset: 0x0000061C
		internal static object WtYHC7HGheGG77o1YuJ(IntPtr ptr, int nLen, object A_2)
		{
			return MarshalExtend.PtrToString(ptr, nLen, A_2);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002438 File Offset: 0x00000638
		internal static bool CT4BiZHwFJmnubIHXiO()
		{
			return MarshalExtend.H6vAEtHig6AiLhpmn00 == null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000244C File Offset: 0x0000064C
		internal static MarshalExtend N9k0RgHEfcF4HJjQ8Vy()
		{
			return MarshalExtend.H6vAEtHig6AiLhpmn00;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000245C File Offset: 0x0000065C
		internal static void pdg7kIHrN4WWqFTHKy5(IntPtr A_0, object A_1, int A_2, int A_3, object A_4)
		{
			ooayrEqX4VEr4ven4kQ.muOq5LWqgj(A_0, A_1, A_2, A_3, A_4);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002480 File Offset: 0x00000680
		internal static IntPtr bR4j3mHT2Ycg3Fisd42(IntPtr address, IntPtr size, NativeMethods.AllocationType allocationType, NativeMethods.MemoryProtection protect)
		{
			return MarshalExtend.AllocHGlobal(address, size, allocationType, protect);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000024A0 File Offset: 0x000006A0
		internal static void gAA8hMHgkkpBlLUTK9B(IntPtr buffer, UIntPtr size)
		{
			MarshalExtend.FreeHGlobal(buffer, size);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000024B8 File Offset: 0x000006B8
		internal static object Im9FIOHop4L9P2PuECp(object A_0)
		{
			return PYBSZ5qHmpqoMlj0IM0.muOq5LWqgj(A_0);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000024CC File Offset: 0x000006CC
		internal static IntPtr KebcBKHUx5BQqhmk8cP(object A_0, object A_1)
		{
			return QKw2j3qO9xGERtudaYd.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000024E4 File Offset: 0x000006E4
		internal static byte vH47xNHjIF8pWlJM7fo(IntPtr A_0, int A_1, object A_2)
		{
			return eYYuUXqvXIv3gEnJhG7.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002500 File Offset: 0x00000700
		internal static int hPvAbbHQvGp1sVFGU8d(IntPtr ptr)
		{
			return MarshalExtend.StrLen(ptr);
		}

		// Token: 0x04000002 RID: 2
		private static MarshalExtend H6vAEtHig6AiLhpmn00;
	}
}
