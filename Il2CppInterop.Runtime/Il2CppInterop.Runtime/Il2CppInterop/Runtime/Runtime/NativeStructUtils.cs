using System;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo;
using MaoFcf2Vq4taIANM6n;

namespace Il2CppInterop.Runtime.Runtime
{
	// Token: 0x02000036 RID: 54
	public static class NativeStructUtils
	{
		// Token: 0x06000242 RID: 578 RVA: 0x0000BE4C File Offset: 0x0000A04C
		public unsafe static IntPtr GetMethodInfoForMissingMethod(string methodName)
		{
			object obj = NativeStructUtils.bulU9w8bIMeGcieY7Ep();
			*((INativeMethodInfoStruct)obj).Name = NativeStructUtils.YiBEkb8fJdGEEdPmljf(methodName, ojfZdkI0l15JUs4wR9G.KlkINMcvdf);
			*((INativeMethodInfoStruct)obj).Slot = ushort.MaxValue;
			return NativeStructUtils.o2dOJd8PHbLCWAFiLSS(obj);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000BE80 File Offset: 0x0000A080
		public unsafe static bool CheckBit(this INativeStruct self, int startOffset, int bit)
		{
			int num = 2;
			int num2 = num;
			int num5;
			IntPtr intPtr;
			for (;;)
			{
				int num4;
				switch (num2)
				{
				case 1:
				{
					int num3 = bit % 8;
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_084a47a7baf94bf79b9c3fbf8d684053 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				case 2:
					num4 = bit / 8;
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e236d804047744298c2380563ba7eca0 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					goto IL_7F;
				case 4:
				{
					int num3;
					num5 = 1 << num3;
					num2 = 2;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_650e65d7606047fda7d187c401bdfc6e == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				}
				intPtr = self.Pointer + (IntPtr)startOffset + (IntPtr)num4;
				num2 = 4;
			}
			IL_7F:
			return ((int)(*(byte*)JFwKeLIuFdrVcU89o72.i2IAUFsOOC(ref intPtr, JFwKeLIuFdrVcU89o72.xshIEqMN4b)) & num5) == num5;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000BF64 File Offset: 0x0000A164
		public unsafe static void SetBit(this INativeStruct self, int startOffset, int bit, bool value)
		{
			int num = 5;
			int num2 = num;
			for (;;)
			{
				int num3;
				int num5;
				switch (num2)
				{
				case 1:
					return;
				case 2:
				{
					byte* ptr;
					byte b;
					*ptr = b;
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c32cfeb41f7a43999be3bae16a94ad02 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				case 3:
				{
					IntPtr intPtr;
					byte* ptr = (byte*)JFwKeLIuFdrVcU89o72.i2IAUFsOOC(ref intPtr, JFwKeLIuFdrVcU89o72.xshIEqMN4b);
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_afe904a262fb47328a49943b4b34b494 != 0)
					{
						num2 = 6;
						continue;
					}
					continue;
				}
				case 4:
					num3 = bit % 8;
					num2 = 7;
					continue;
				case 5:
				{
					int num4 = bit / 8;
					num2 = 4;
					continue;
				}
				case 6:
				{
					byte* ptr;
					byte b = (byte)(((int)(*ptr) & num5) | ((((value > false) ? 1 : 0) << (num3 & 31)) ? 1 : 0));
					num2 = 2;
					continue;
				}
				case 7:
				{
					int num4;
					IntPtr intPtr = NativeStructUtils.o2dOJd8PHbLCWAFiLSS(self) + (IntPtr)startOffset + (IntPtr)num4;
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				}
				num5 = ~(1 << num3);
				num2 = 3;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b15bb2810b414d8fba6ffddaf7154f62 != 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000C098 File Offset: 0x0000A298
		// Note: this type is marked as 'beforefieldinit'.
		static NativeStructUtils()
		{
			NativeStructUtils.mDT8jY8dOkSV0ytx1tO();
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		internal static object bulU9w8bIMeGcieY7Ep()
		{
			return UnityVersionHandler.NewMethod();
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000C0B8 File Offset: 0x0000A2B8
		internal static IntPtr YiBEkb8fJdGEEdPmljf(object A_0, object A_1)
		{
			return ojfZdkI0l15JUs4wR9G.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000C0D0 File Offset: 0x0000A2D0
		internal static IntPtr o2dOJd8PHbLCWAFiLSS(object A_0)
		{
			return ((INativeStruct)A_0).Pointer;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000C0E4 File Offset: 0x0000A2E4
		internal static bool gACtP48Zdy7CYkrgoC9()
		{
			return NativeStructUtils.WTsKsJ8DjRTOdr87k3j == null;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000C0F8 File Offset: 0x0000A2F8
		internal static NativeStructUtils TeggUw8o930BTIl0ohA()
		{
			return NativeStructUtils.WTsKsJ8DjRTOdr87k3j;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000C108 File Offset: 0x0000A308
		internal static void mDT8jY8dOkSV0ytx1tO()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040000E0 RID: 224
		internal static NativeStructUtils WTsKsJ8DjRTOdr87k3j;
	}
}
