using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Wrappers
{
	// Token: 0x02000015 RID: 21
	public class NativeMethods
	{
		// Token: 0x06000237 RID: 567
		[DllImport("ntdll.dll")]
		public static extern int NtProtectVirtualMemory(IntPtr ProcessHandle, ref IntPtr BaseAddress, ref UIntPtr RegionSize, NativeMethods.MemoryProtection NewProtect, out NativeMethods.MemoryProtection OldProtect);

		// Token: 0x06000238 RID: 568
		[DllImport("ntdll.dll", SetLastError = true)]
		public static extern int NtQueryVirtualMemory(IntPtr ProcessHandle, IntPtr BaseAddress, int MemoryInformationClass, ref NativeMethods.MEMORY_BASIC_INFORMATION MemoryInformation, uint MemoryInformationLength, out uint ReturnLength);

		// Token: 0x06000239 RID: 569
		[DllImport("ntdll.dll")]
		public static extern int NtAllocateVirtualMemory(IntPtr ProcessHandle, ref IntPtr BaseAddress, IntPtr ZeroBits, ref IntPtr RegionSize, NativeMethods.AllocationType AllocationType, NativeMethods.MemoryProtection Protect);

		// Token: 0x0600023A RID: 570
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr VirtualAlloc(IntPtr lpAddress, IntPtr dwSize, NativeMethods.AllocationType flAllocationType, NativeMethods.MemoryProtection flProtect);

		// Token: 0x0600023B RID: 571
		[DllImport("ntdll.dll", CallingConvention = 2)]
		public static extern void RtlMoveMemory(IntPtr dest, IntPtr src, uint length);

		// Token: 0x0600023C RID: 572
		[DllImport("ntdll.dll")]
		public static extern int NtFreeVirtualMemory(IntPtr ProcessHandle, ref IntPtr BaseAddress, ref UIntPtr RegionSize, NativeMethods.AllocationType FreeType);

		// Token: 0x0600023D RID: 573 RVA: 0x0000BDC8 File Offset: 0x00009FC8
		public NativeMethods()
		{
			NativeMethods.CoAkgbhiY2AADvYDgU5();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000BE28 File Offset: 0x0000A028
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethods()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000BE30 File Offset: 0x0000A030
		internal static void CoAkgbhiY2AADvYDgU5()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000BE38 File Offset: 0x0000A038
		internal static bool nDOw0Rhqdm8ItXXKWL9()
		{
			return NativeMethods.JFTLEwhUI704gVqpN5P == null;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000BE44 File Offset: 0x0000A044
		internal static NativeMethods HN8PMLh9wy0XuJeGB9a()
		{
			return NativeMethods.JFTLEwhUI704gVqpN5P;
		}

		// Token: 0x04000039 RID: 57
		internal static NativeMethods JFTLEwhUI704gVqpN5P;

		// Token: 0x02000016 RID: 22
		[Flags]
		public enum AllocationType : uint
		{
			// Token: 0x0400003B RID: 59
			Commit = 4096U,
			// Token: 0x0400003C RID: 60
			Reserve = 8192U,
			// Token: 0x0400003D RID: 61
			Decommit = 16384U,
			// Token: 0x0400003E RID: 62
			Release = 32768U,
			// Token: 0x0400003F RID: 63
			Reset = 524288U,
			// Token: 0x04000040 RID: 64
			Physical = 4194304U,
			// Token: 0x04000041 RID: 65
			TopDown = 1048576U,
			// Token: 0x04000042 RID: 66
			WriteWatch = 2097152U,
			// Token: 0x04000043 RID: 67
			LargePages = 536870912U
		}

		// Token: 0x02000017 RID: 23
		[Flags]
		public enum MemoryProtection : uint
		{
			// Token: 0x04000045 RID: 69
			Execute = 16U,
			// Token: 0x04000046 RID: 70
			ExecuteRead = 32U,
			// Token: 0x04000047 RID: 71
			ExecuteReadWrite = 64U,
			// Token: 0x04000048 RID: 72
			ExecuteWriteCopy = 128U,
			// Token: 0x04000049 RID: 73
			NoAccess = 1U,
			// Token: 0x0400004A RID: 74
			ReadOnly = 2U,
			// Token: 0x0400004B RID: 75
			ReadWrite = 4U,
			// Token: 0x0400004C RID: 76
			WriteCopy = 8U,
			// Token: 0x0400004D RID: 77
			GuardModifierflag = 256U,
			// Token: 0x0400004E RID: 78
			NoCacheModifierflag = 512U,
			// Token: 0x0400004F RID: 79
			WriteCombineModifierflag = 1024U
		}

		// Token: 0x02000018 RID: 24
		public enum MemoryState : uint
		{
			// Token: 0x04000051 RID: 81
			Commited = 4096U,
			// Token: 0x04000052 RID: 82
			Free = 65536U,
			// Token: 0x04000053 RID: 83
			Reserved = 8192U
		}

		// Token: 0x02000019 RID: 25
		public struct MEMORY_BASIC_INFORMATION
		{
			// Token: 0x04000054 RID: 84
			public IntPtr BaseAddress;

			// Token: 0x04000055 RID: 85
			public IntPtr AllocationBase;

			// Token: 0x04000056 RID: 86
			public uint AllocationProtect;

			// Token: 0x04000057 RID: 87
			public IntPtr RegionSize;

			// Token: 0x04000058 RID: 88
			public NativeMethods.MemoryState State;

			// Token: 0x04000059 RID: 89
			public NativeMethods.MemoryProtection Protect;

			// Token: 0x0400005A RID: 90
			public uint Type;
		}
	}
}
