using System;
using Il2CppSystem;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime
{
	// Token: 0x0200000E RID: 14
	public class Il2CppException : Exception
	{
		// Token: 0x060001DA RID: 474 RVA: 0x0000A1C4 File Offset: 0x000083C4
		public Il2CppException(IntPtr exception)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor(Il2CppException.Gumd8Kx0m3Tj5PjFRVB(exception));
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c32cfeb41f7a43999be3bae16a94ad02 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000A230 File Offset: 0x00008430
		private unsafe static string BuildMessage(IntPtr exception)
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				byte[] array;
				switch (num2)
				{
				case 1:
					goto IL_1FA;
				case 2:
					Il2CppException.ourMessageBytes = new byte[65536];
					num2 = 6;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56c162609824bd799f0a7b9a8c33c89 == 0)
					{
						num2 = 7;
						continue;
					}
					continue;
				case 3:
					if (Il2CppException.ourMessageBytes != null)
					{
						goto IL_136;
					}
					num2 = 2;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2b9d7065e34e71a0069eb107f69f59 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					goto IL_4F;
				case 6:
					array = null;
					num2 = 5;
					continue;
				case 7:
					goto IL_136;
				case 8:
					goto IL_190;
				case 9:
					goto IL_1FA;
				case 10:
					goto IL_123;
				}
				IL_100:
				byte* message = null;
				num2 = 8;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c474f43efb4d4f17b5c0c1bf3216ef4d != 0)
				{
					num2 = 9;
					continue;
				}
				continue;
				goto IL_100;
				IL_123:
				if (array.Length == 0)
				{
					num2 = 4;
					continue;
				}
				goto IL_190;
				IL_136:
				if ((array = Il2CppException.ourMessageBytes) != null)
				{
					goto IL_123;
				}
				num2 = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6b13daaa4cb24d0bac4f6e72da052370 == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_190:
				message = &array[0];
				num2 = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6104a350572547c0a789887568cca07c != 0)
				{
					num2 = 1;
					continue;
				}
				continue;
				IL_1FA:
				IL2CPP.il2cpp_format_exception(exception, (void*)message, Il2CppException.ourMessageBytes.Length);
				num2 = 6;
			}
			IL_4F:
			string text = Il2CppException.IF4ADxxNsO0fJ2lfHxV(uDLdZ5AqNUaSKY7KefP.i2IAUFsOOC(uDLdZ5AqNUaSKY7KefP.p8sA9n6fhA), Il2CppException.ourMessageBytes, 0, Array.IndexOf<byte>(Il2CppException.ourMessageBytes, 0), q3OdohAGvaJsEOiEnED.ISuAYNVsNK);
			Exception ex = new Exception(exception);
			return SjRANlAsQ8j3KPpZL2p.i2IAUFsOOC(text, Il2CppException.RxLJPgxuS9UqBE0ow6n(-351482292 - -287444189 ^ -1800068251 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_0783948440564d328b8e79831447d3f6), Il2CppException.MfuKqkxEg4KE5ogWp6S(ex, false, true, VJNQGMiSZYECLfDBDCg.FGTig76Cpb), Il2CppException.RxLJPgxuS9UqBE0ow6n(665295750 + 1584662951 ^ -1969688944 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c504ab11ece64b14b01df2d4c88e6e49), SjRANlAsQ8j3KPpZL2p.xmXAQkOq8l);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000A450 File Offset: 0x00008650
		public static void RaiseExceptionIfNecessary(IntPtr returnedException)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (returnedException != IntPtr.Zero)
					{
						goto IL_56;
					}
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3ffead0113044f06b294bee6bd5e7a44 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return;
			IL_56:
			throw new Il2CppException(returnedException);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000A4BC File Offset: 0x000086BC
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppException()
		{
			Il2CppException.S4en6rxcE3FSkNnA7tl();
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000A4CC File Offset: 0x000086CC
		internal static object Gumd8Kx0m3Tj5PjFRVB(IntPtr exception)
		{
			return Il2CppException.BuildMessage(exception);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000A4E0 File Offset: 0x000086E0
		internal static bool eo8LUHxhnhaB9JEuR8m()
		{
			return Il2CppException.OYZIfVxxjrnCTyokjqE == null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000A4F4 File Offset: 0x000086F4
		internal static Il2CppException zjs78nx8tRDF6d8v7kv()
		{
			return Il2CppException.OYZIfVxxjrnCTyokjqE;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000A504 File Offset: 0x00008704
		internal static object IF4ADxxNsO0fJ2lfHxV(object A_0, object A_1, int A_2, int A_3, object A_4)
		{
			return q3OdohAGvaJsEOiEnED.i2IAUFsOOC(A_0, A_1, A_2, A_3, A_4);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000A528 File Offset: 0x00008728
		internal static object RxLJPgxuS9UqBE0ow6n(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000A53C File Offset: 0x0000873C
		internal static object MfuKqkxEg4KE5ogWp6S(object A_0, bool A_1, bool A_2, object A_3)
		{
			return VJNQGMiSZYECLfDBDCg.i2IAUFsOOC(A_0, A_1, A_2, A_3);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000A55C File Offset: 0x0000875C
		internal static void S4en6rxcE3FSkNnA7tl()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000027 RID: 39
		[ThreadStatic]
		private static byte[] ourMessageBytes;

		// Token: 0x04000028 RID: 40
		public static Func<IntPtr, string> ParseMessageHook;

		// Token: 0x04000029 RID: 41
		internal static Il2CppException OYZIfVxxjrnCTyokjqE;
	}
}
