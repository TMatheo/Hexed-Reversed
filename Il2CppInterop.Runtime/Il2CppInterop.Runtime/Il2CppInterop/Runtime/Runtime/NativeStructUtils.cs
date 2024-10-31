using System;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo;
using MaoFcf2Vq4taIANM6n;

namespace Il2CppInterop.Runtime.Runtime
{
	// Token: 0x02000034 RID: 52
	public static class NativeStructUtils
	{
		// Token: 0x06000226 RID: 550 RVA: 0x0000B3A4 File Offset: 0x000095A4
		public unsafe static IntPtr GetMethodInfoForMissingMethod(string methodName)
		{
			INativeMethodInfoStruct nativeMethodInfoStruct = UnityVersionHandler.NewMethod();
			*nativeMethodInfoStruct.Name = jpxh4gcXyIEtq9pm6cV.muOq5LWqgj(methodName, jpxh4gcXyIEtq9pm6cV.vlgccgYXAL);
			*nativeMethodInfoStruct.Slot = ushort.MaxValue;
			return NativeStructUtils.q7UsWoxy71mV7EpeUY5(nativeMethodInfoStruct);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000B3D8 File Offset: 0x000095D8
		public unsafe static bool CheckBit(this INativeStruct self, int startOffset, int bit)
		{
			int num = 1;
			int num2 = num;
			IntPtr intPtr;
			int num4;
			for (;;)
			{
				int num5;
				switch (num2)
				{
				case 1:
				{
					int num3 = bit / 8;
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				case 2:
				{
					int num3;
					intPtr = NativeStructUtils.q7UsWoxy71mV7EpeUY5(self) + (IntPtr)startOffset + (IntPtr)num3;
					num2 = 4;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5395ed2b7ead4e349835ba3f56e39138 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				case 3:
					goto IL_37;
				case 4:
					num4 = 1 << num5;
					num2 = 3;
					continue;
				}
				num5 = bit % 8;
				num2 = 2;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb8decd62b945dda713f7b22b6b95ca != 0)
				{
					num2 = 0;
				}
			}
			IL_37:
			return ((int)(*(byte*)Mw7IMTckZt48JAHG0WH.muOq5LWqgj(ref intPtr, Mw7IMTckZt48JAHG0WH.u8Gc2tmlLS)) & num4) == num4;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000B4BC File Offset: 0x000096BC
		public unsafe static void SetBit(this INativeStruct self, int startOffset, int bit, bool value)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				int num5;
				switch (num2)
				{
				case 1:
				{
					int num3 = bit / 8;
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2356ac6ca5954f1897cd5bbbe0161ae5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				case 2:
				{
					int num4 = ~(1 << num5);
					num2 = 4;
					continue;
				}
				case 3:
				{
					int num4;
					byte* ptr;
					byte b = (byte)(((int)(*ptr) & num4) | ((((value > false) ? 1 : 0) << (num5 & 31)) ? 1 : 0));
					num2 = 6;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3e2009ed69c04f5799431b4e58cafb2a != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				}
				case 4:
				{
					IntPtr intPtr;
					byte* ptr = (byte*)Mw7IMTckZt48JAHG0WH.muOq5LWqgj(ref intPtr, Mw7IMTckZt48JAHG0WH.u8Gc2tmlLS);
					num2 = 3;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_960a54aec0f640cd975b2d62f3e0a596 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				case 5:
					return;
				case 6:
				{
					byte* ptr;
					byte b;
					*ptr = b;
					num2 = 5;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4da80845ebf7410ebbf942336f5ee27b == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				}
				case 7:
				{
					int num3;
					IntPtr intPtr = NativeStructUtils.q7UsWoxy71mV7EpeUY5(self) + (IntPtr)startOffset + (IntPtr)num3;
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ffe1ad8c1cf94bc78c25e67b0264547e != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				}
				num5 = bit % 8;
				num2 = 7;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ecb3ec1520014011821df145fb87d517 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000B61C File Offset: 0x0000981C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeStructUtils()
		{
			NativeStructUtils.f6P14ExJDKAUSQPJI6C();
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000B62C File Offset: 0x0000982C
		internal static IntPtr q7UsWoxy71mV7EpeUY5(object A_0)
		{
			return ((INativeStruct)A_0).Pointer;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000B640 File Offset: 0x00009840
		internal static bool pfo02Rxbs15ZFp3VI6v()
		{
			return NativeStructUtils.vwgtuSxn9Nj7ekDghoL == null;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000B654 File Offset: 0x00009854
		internal static NativeStructUtils u22rdXx6f9KC46G1lG6()
		{
			return NativeStructUtils.vwgtuSxn9Nj7ekDghoL;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000B664 File Offset: 0x00009864
		internal static void f6P14ExJDKAUSQPJI6C()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040000D5 RID: 213
		private static NativeStructUtils vwgtuSxn9Nj7ekDghoL;
	}
}
