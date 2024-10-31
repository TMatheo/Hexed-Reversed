using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Wrappers
{
	// Token: 0x02000015 RID: 21
	public class NativeMethods
	{
		// Token: 0x0600021E RID: 542
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr VirtualAlloc(IntPtr lpAddress, IntPtr dwSize, NativeMethods.AllocationType flAllocationType, NativeMethods.MemoryProtection flProtect);

		// Token: 0x0600021F RID: 543
		[DllImport("ntdll.dll")]
		public static extern int NtFreeVirtualMemory(IntPtr ProcessHandle, ref IntPtr BaseAddress, ref UIntPtr RegionSize, NativeMethods.AllocationType FreeType);

		// Token: 0x06000220 RID: 544 RVA: 0x0000B318 File Offset: 0x00009518
		public NativeMethods()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeMethods.Yy31WJtjGrD5GG7mTy8();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_faca03c2e5084297b7a5d894ac66fa57 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000B378 File Offset: 0x00009578
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethods()
		{
			NativeMethods.Wx6tbWtQLoQvUgEDGuT();
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000B380 File Offset: 0x00009580
		internal static void Yy31WJtjGrD5GG7mTy8()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000B388 File Offset: 0x00009588
		internal static bool nEmLfDtoh2ENvBdqXx8()
		{
			return NativeMethods.ILFAtetgOf6Fdpw27rB == null;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000B394 File Offset: 0x00009594
		internal static NativeMethods pegMRxtUcTmB3vk4daq()
		{
			return NativeMethods.ILFAtetgOf6Fdpw27rB;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000B39C File Offset: 0x0000959C
		internal static void Wx6tbWtQLoQvUgEDGuT()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000039 RID: 57
		internal static NativeMethods ILFAtetgOf6Fdpw27rB;

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
	}
}
