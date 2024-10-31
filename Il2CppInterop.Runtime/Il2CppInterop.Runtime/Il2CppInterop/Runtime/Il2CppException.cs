using System;
using Il2CppSystem;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime
{
	// Token: 0x0200000E RID: 14
	public class Il2CppException : Exception
	{
		// Token: 0x060001B9 RID: 441 RVA: 0x000096C8 File Offset: 0x000078C8
		public Il2CppException(IntPtr exception)
		{
			Il2CppException.Gt0kvrOeqqKgdtAh4Xi();
			Il2CppException.QN1G5SOKINkXmKVH8jM();
			base..ctor(Il2CppException.NtLaehOaoYTqFxRqcyM(exception));
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_960a54aec0f640cd975b2d62f3e0a596 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00009734 File Offset: 0x00007934
		private unsafe static string BuildMessage(IntPtr exception)
		{
			int num = 7;
			int num2 = num;
			for (;;)
			{
				byte[] array;
				switch (num2)
				{
				case 0:
					goto IL_BF;
				case 1:
					goto IL_88;
				case 2:
					break;
				case 3:
					goto IL_14B;
				case 4:
					goto IL_CE;
				case 5:
					goto IL_1A3;
				case 6:
					Il2CppException.ourMessageBytes = new byte[65536];
					num2 = 2;
					continue;
				case 7:
					if (Il2CppException.ourMessageBytes == null)
					{
						num2 = 6;
						continue;
					}
					break;
				case 8:
					array = null;
					num2 = 4;
					continue;
				case 9:
					goto IL_88;
				case 10:
					goto IL_175;
				default:
					goto IL_BF;
				}
				if ((array = Il2CppException.ourMessageBytes) != null)
				{
					goto IL_1A3;
				}
				num2 = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_9f61d52c010d488b818a577e37d289c0 != 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_88:
				byte* message = null;
				num2 = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_14B:
				message = &array[0];
				num2 = 7;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_fe27a6a8bfb848d1a3dd32bc5b1790e7 == 0)
				{
					num2 = 10;
					continue;
				}
				continue;
				IL_1A3:
				if (array.Length == 0)
				{
					num2 = 9;
					continue;
				}
				goto IL_14B;
				IL_175:
				IL2CPP.il2cpp_format_exception(exception, (void*)message, Il2CppException.ourMessageBytes.Length);
				num2 = 2;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b3f20ce588d04b909ddcdcdf767eb5d4 == 0)
				{
					num2 = 8;
					continue;
				}
				continue;
				IL_BF:
				goto IL_175;
			}
			IL_CE:
			string text = d0GVpXqkDwLXJnTWagY.muOq5LWqgj(Il2CppException.lTIShQOZEYLbfc6WPlI(BvrxoRqAm5Fek3drElk.AZFqL5aO5D), Il2CppException.ourMessageBytes, 0, Array.IndexOf<byte>(Il2CppException.ourMessageBytes, 0), d0GVpXqkDwLXJnTWagY.zUMq2CpWoP);
			Exception ex = new Exception(exception);
			return KUcPF8qN05KKuwdEiA1.muOq5LWqgj(text, Il2CppException.nWf33tOzZQaCvW0yth4(--1271083629 ^ 527164072 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e5b00aa4c99144c78d3bd63e270496cb), A1N5aRX7wlBIo8xhJHO.muOq5LWqgj(ex, false, true, A1N5aRX7wlBIo8xhJHO.QSZXP7eJWd), Il2CppException.nWf33tOzZQaCvW0yth4(-2019746020 ^ -1094262601 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7fef7bb77728417ab4965dd0775b5899), KUcPF8qN05KKuwdEiA1.R6Mqu5fmTH);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00009924 File Offset: 0x00007B24
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ecb3ec1520014011821df145fb87d517 == 0)
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

		// Token: 0x060001BC RID: 444 RVA: 0x00009990 File Offset: 0x00007B90
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppException()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000099A0 File Offset: 0x00007BA0
		internal static void Gt0kvrOeqqKgdtAh4Xi()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000099B0 File Offset: 0x00007BB0
		internal static void QN1G5SOKINkXmKVH8jM()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000099C0 File Offset: 0x00007BC0
		internal static object NtLaehOaoYTqFxRqcyM(IntPtr exception)
		{
			return Il2CppException.BuildMessage(exception);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000099D4 File Offset: 0x00007BD4
		internal static bool iXUulOOjd5YGRxw1XGE()
		{
			return Il2CppException.qrQnJ2OU2kmfJRayuJg == null;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000099E8 File Offset: 0x00007BE8
		internal static Il2CppException Ks22v1OQZV9xFlYwSg5()
		{
			return Il2CppException.qrQnJ2OU2kmfJRayuJg;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000099F8 File Offset: 0x00007BF8
		internal static object lTIShQOZEYLbfc6WPlI(object A_0)
		{
			return BvrxoRqAm5Fek3drElk.muOq5LWqgj(A_0);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00009A0C File Offset: 0x00007C0C
		internal static object nWf33tOzZQaCvW0yth4(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x04000027 RID: 39
		[ThreadStatic]
		private static byte[] ourMessageBytes;

		// Token: 0x04000028 RID: 40
		public static Func<IntPtr, string> ParseMessageHook;

		// Token: 0x04000029 RID: 41
		private static Il2CppException qrQnJ2OU2kmfJRayuJg;
	}
}
