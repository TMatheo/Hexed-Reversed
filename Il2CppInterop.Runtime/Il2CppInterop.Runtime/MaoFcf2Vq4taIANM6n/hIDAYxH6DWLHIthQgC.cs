using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using CDSCTtBikuRQ668dSe;
using lPHJlnqFM89GDaeVBH;
using pFRqcJyyWJ2hUZv2rN;

namespace MaoFcf2Vq4taIANM6n
{
	// Token: 0x02000138 RID: 312
	internal class hIDAYxH6DWLHIthQgC
	{
		// Token: 0x06000D9E RID: 3486 RVA: 0x00029710 File Offset: 0x00027910
		static hIDAYxH6DWLHIthQgC()
		{
			hIDAYxH6DWLHIthQgC.CPGmeecTL = false;
			hIDAYxH6DWLHIthQgC.e1I76Dk1A = false;
			hIDAYxH6DWLHIthQgC.FmWIypaNX = null;
			hIDAYxH6DWLHIthQgC.CC86JSicc = new object();
			hIDAYxH6DWLHIthQgC.mLdMA9iPk = Type.GetTypeFromHandle(f1stFPxcHMQ5yL3IBf.icSmQILiN5(33554744)).Assembly;
			hIDAYxH6DWLHIthQgC.Bh317U1vE = new byte[0];
			hIDAYxH6DWLHIthQgC.dJ60ZwGG7 = null;
			hIDAYxH6DWLHIthQgC.RVsUi7vv8 = new byte[0];
			hIDAYxH6DWLHIthQgC.iGWr5uXHi = new object();
			hIDAYxH6DWLHIthQgC.ReW45iIw5 = null;
			hIDAYxH6DWLHIthQgC.asMnx1K5s = null;
			hIDAYxH6DWLHIthQgC.HDHKHhTXP = 0;
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x000297CC File Offset: 0x000279CC
		internal hIDAYxH6DWLHIthQgC()
		{
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x000297DC File Offset: 0x000279DC
		private void aI4msr0kka()
		{
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x000297E8 File Offset: 0x000279E8
		internal static byte[] hIDHAYx6D(object \u0020)
		{
			uint[] array = new uint[16];
			uint num = (uint)((448 - \u0020.Length * 8 % 512 + 512) % 512);
			if (num == 0U)
			{
				num = 512U;
			}
			uint num2 = (uint)((long)\u0020.Length + (long)((ulong)(num / 8U)) + 8L);
			ulong num3 = (ulong)((long)\u0020.Length * 8L);
			byte[] array2 = new byte[num2];
			for (int i = 0; i < \u0020.Length; i++)
			{
				array2[i] = \u0020[i];
			}
			byte[] array3 = array2;
			int num4 = \u0020.Length;
			array3[num4] |= 128;
			for (int j = 8; j > 0; j--)
			{
				array2[(int)(checked((IntPtr)(unchecked((ulong)num2 - (ulong)((long)j)))))] = (byte)(num3 >> (8 - j) * 8 & 255UL);
			}
			uint num5 = (uint)(array2.Length * 8 / 32);
			uint num6 = 1732584193U;
			uint num7 = 4023233417U;
			uint num8 = 2562383102U;
			uint num9 = 271733878U;
			for (uint num10 = 0U; num10 < num5 / 16U; num10 += 1U)
			{
				uint num11 = num10 << 6;
				for (uint num12 = 0U; num12 < 61U; num12 += 4U)
				{
					array[(int)(num12 >> 2)] = (uint)((int)array2[(int)(num11 + (num12 + 3U))] << 24 | (int)array2[(int)(num11 + (num12 + 2U))] << 16 | (int)array2[(int)(num11 + (num12 + 1U))] << 8 | (int)array2[(int)(num11 + num12)]);
				}
				uint num13 = num6;
				uint num14 = num7;
				uint num15 = num8;
				uint num16 = num9;
				hIDAYxH6DWLHIthQgC.DLH2IthQg(ref num6, num7, num8, num9, 0U, 7, 1U, array);
				hIDAYxH6DWLHIthQgC.DLH2IthQg(ref num9, num6, num7, num8, 1U, 12, 2U, array);
				hIDAYxH6DWLHIthQgC.DLH2IthQg(ref num8, num9, num6, num7, 2U, 17, 3U, array);
				hIDAYxH6DWLHIthQgC.DLH2IthQg(ref num7, num8, num9, num6, 3U, 22, 4U, array);
				hIDAYxH6DWLHIthQgC.DLH2IthQg(ref num6, num7, num8, num9, 4U, 7, 5U, array);
				hIDAYxH6DWLHIthQgC.DLH2IthQg(ref num9, num6, num7, num8, 5U, 12, 6U, array);
				hIDAYxH6DWLHIthQgC.DLH2IthQg(ref num8, num9, num6, num7, 6U, 17, 7U, array);
				hIDAYxH6DWLHIthQgC.DLH2IthQg(ref num7, num8, num9, num6, 7U, 22, 8U, array);
				hIDAYxH6DWLHIthQgC.DLH2IthQg(ref num6, num7, num8, num9, 8U, 7, 9U, array);
				hIDAYxH6DWLHIthQgC.DLH2IthQg(ref num9, num6, num7, num8, 9U, 12, 10U, array);
				hIDAYxH6DWLHIthQgC.DLH2IthQg(ref num8, num9, num6, num7, 10U, 17, 11U, array);
				hIDAYxH6DWLHIthQgC.DLH2IthQg(ref num7, num8, num9, num6, 11U, 22, 12U, array);
				hIDAYxH6DWLHIthQgC.DLH2IthQg(ref num6, num7, num8, num9, 12U, 7, 13U, array);
				hIDAYxH6DWLHIthQgC.DLH2IthQg(ref num9, num6, num7, num8, 13U, 12, 14U, array);
				hIDAYxH6DWLHIthQgC.DLH2IthQg(ref num8, num9, num6, num7, 14U, 17, 15U, array);
				hIDAYxH6DWLHIthQgC.DLH2IthQg(ref num7, num8, num9, num6, 15U, 22, 16U, array);
				hIDAYxH6DWLHIthQgC.T1axoFcfV(ref num6, num7, num8, num9, 1U, 5, 17U, array);
				hIDAYxH6DWLHIthQgC.T1axoFcfV(ref num9, num6, num7, num8, 6U, 9, 18U, array);
				hIDAYxH6DWLHIthQgC.T1axoFcfV(ref num8, num9, num6, num7, 11U, 14, 19U, array);
				hIDAYxH6DWLHIthQgC.T1axoFcfV(ref num7, num8, num9, num6, 0U, 20, 20U, array);
				hIDAYxH6DWLHIthQgC.T1axoFcfV(ref num6, num7, num8, num9, 5U, 5, 21U, array);
				hIDAYxH6DWLHIthQgC.T1axoFcfV(ref num9, num6, num7, num8, 10U, 9, 22U, array);
				hIDAYxH6DWLHIthQgC.T1axoFcfV(ref num8, num9, num6, num7, 15U, 14, 23U, array);
				hIDAYxH6DWLHIthQgC.T1axoFcfV(ref num7, num8, num9, num6, 4U, 20, 24U, array);
				hIDAYxH6DWLHIthQgC.T1axoFcfV(ref num6, num7, num8, num9, 9U, 5, 25U, array);
				hIDAYxH6DWLHIthQgC.T1axoFcfV(ref num9, num6, num7, num8, 14U, 9, 26U, array);
				hIDAYxH6DWLHIthQgC.T1axoFcfV(ref num8, num9, num6, num7, 3U, 14, 27U, array);
				hIDAYxH6DWLHIthQgC.T1axoFcfV(ref num7, num8, num9, num6, 8U, 20, 28U, array);
				hIDAYxH6DWLHIthQgC.T1axoFcfV(ref num6, num7, num8, num9, 13U, 5, 29U, array);
				hIDAYxH6DWLHIthQgC.T1axoFcfV(ref num9, num6, num7, num8, 2U, 9, 30U, array);
				hIDAYxH6DWLHIthQgC.T1axoFcfV(ref num8, num9, num6, num7, 7U, 14, 31U, array);
				hIDAYxH6DWLHIthQgC.T1axoFcfV(ref num7, num8, num9, num6, 12U, 20, 32U, array);
				hIDAYxH6DWLHIthQgC.d4tqaIANM(ref num6, num7, num8, num9, 5U, 4, 33U, array);
				hIDAYxH6DWLHIthQgC.d4tqaIANM(ref num9, num6, num7, num8, 8U, 11, 34U, array);
				hIDAYxH6DWLHIthQgC.d4tqaIANM(ref num8, num9, num6, num7, 11U, 16, 35U, array);
				hIDAYxH6DWLHIthQgC.d4tqaIANM(ref num7, num8, num9, num6, 14U, 23, 36U, array);
				hIDAYxH6DWLHIthQgC.d4tqaIANM(ref num6, num7, num8, num9, 1U, 4, 37U, array);
				hIDAYxH6DWLHIthQgC.d4tqaIANM(ref num9, num6, num7, num8, 4U, 11, 38U, array);
				hIDAYxH6DWLHIthQgC.d4tqaIANM(ref num8, num9, num6, num7, 7U, 16, 39U, array);
				hIDAYxH6DWLHIthQgC.d4tqaIANM(ref num7, num8, num9, num6, 10U, 23, 40U, array);
				hIDAYxH6DWLHIthQgC.d4tqaIANM(ref num6, num7, num8, num9, 13U, 4, 41U, array);
				hIDAYxH6DWLHIthQgC.d4tqaIANM(ref num9, num6, num7, num8, 0U, 11, 42U, array);
				hIDAYxH6DWLHIthQgC.d4tqaIANM(ref num8, num9, num6, num7, 3U, 16, 43U, array);
				hIDAYxH6DWLHIthQgC.d4tqaIANM(ref num7, num8, num9, num6, 6U, 23, 44U, array);
				hIDAYxH6DWLHIthQgC.d4tqaIANM(ref num6, num7, num8, num9, 9U, 4, 45U, array);
				hIDAYxH6DWLHIthQgC.d4tqaIANM(ref num9, num6, num7, num8, 12U, 11, 46U, array);
				hIDAYxH6DWLHIthQgC.d4tqaIANM(ref num8, num9, num6, num7, 15U, 16, 47U, array);
				hIDAYxH6DWLHIthQgC.d4tqaIANM(ref num7, num8, num9, num6, 2U, 23, 48U, array);
				hIDAYxH6DWLHIthQgC.LnTa1stFP(ref num6, num7, num8, num9, 0U, 6, 49U, array);
				hIDAYxH6DWLHIthQgC.LnTa1stFP(ref num9, num6, num7, num8, 7U, 10, 50U, array);
				hIDAYxH6DWLHIthQgC.LnTa1stFP(ref num8, num9, num6, num7, 14U, 15, 51U, array);
				hIDAYxH6DWLHIthQgC.LnTa1stFP(ref num7, num8, num9, num6, 5U, 21, 52U, array);
				hIDAYxH6DWLHIthQgC.LnTa1stFP(ref num6, num7, num8, num9, 12U, 6, 53U, array);
				hIDAYxH6DWLHIthQgC.LnTa1stFP(ref num9, num6, num7, num8, 3U, 10, 54U, array);
				hIDAYxH6DWLHIthQgC.LnTa1stFP(ref num8, num9, num6, num7, 10U, 15, 55U, array);
				hIDAYxH6DWLHIthQgC.LnTa1stFP(ref num7, num8, num9, num6, 1U, 21, 56U, array);
				hIDAYxH6DWLHIthQgC.LnTa1stFP(ref num6, num7, num8, num9, 8U, 6, 57U, array);
				hIDAYxH6DWLHIthQgC.LnTa1stFP(ref num9, num6, num7, num8, 15U, 10, 58U, array);
				hIDAYxH6DWLHIthQgC.LnTa1stFP(ref num8, num9, num6, num7, 6U, 15, 59U, array);
				hIDAYxH6DWLHIthQgC.LnTa1stFP(ref num7, num8, num9, num6, 13U, 21, 60U, array);
				hIDAYxH6DWLHIthQgC.LnTa1stFP(ref num6, num7, num8, num9, 4U, 6, 61U, array);
				hIDAYxH6DWLHIthQgC.LnTa1stFP(ref num9, num6, num7, num8, 11U, 10, 62U, array);
				hIDAYxH6DWLHIthQgC.LnTa1stFP(ref num8, num9, num6, num7, 2U, 15, 63U, array);
				hIDAYxH6DWLHIthQgC.LnTa1stFP(ref num7, num8, num9, num6, 9U, 21, 64U, array);
				num6 += num13;
				num7 += num14;
				num8 += num15;
				num9 += num16;
			}
			byte[] array4 = new byte[16];
			Array.Copy(BitConverter.GetBytes(num6), 0, array4, 0, 4);
			Array.Copy(BitConverter.GetBytes(num7), 0, array4, 4, 4);
			Array.Copy(BitConverter.GetBytes(num8), 0, array4, 8, 4);
			Array.Copy(BitConverter.GetBytes(num9), 0, array4, 12, 4);
			return array4;
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00029E54 File Offset: 0x00028054
		private static void DLH2IthQg(ref uint \u0020, uint \u0020, uint \u0020, uint \u0020, uint \u0020, ushort \u0020, uint \u0020, object \u0020)
		{
			\u0020 += hIDAYxH6DWLHIthQgC.qHMTQ5yL3(\u0020 + ((\u0020 & \u0020) | (~\u0020 & \u0020)) + \u0020[(int)\u0020] + hIDAYxH6DWLHIthQgC.SrDpPJg0d[(int)(\u0020 - 1U)], \u0020);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00029E84 File Offset: 0x00028084
		private static void T1axoFcfV(ref uint \u0020, uint \u0020, uint \u0020, uint \u0020, uint \u0020, ushort \u0020, uint \u0020, object \u0020)
		{
			\u0020 += hIDAYxH6DWLHIthQgC.qHMTQ5yL3(\u0020 + ((\u0020 & \u0020) | (\u0020 & ~\u0020)) + \u0020[(int)\u0020] + hIDAYxH6DWLHIthQgC.SrDpPJg0d[(int)(\u0020 - 1U)], \u0020);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00029EB4 File Offset: 0x000280B4
		private static void d4tqaIANM(ref uint \u0020, uint \u0020, uint \u0020, uint \u0020, uint \u0020, ushort \u0020, uint \u0020, object \u0020)
		{
			\u0020 += hIDAYxH6DWLHIthQgC.qHMTQ5yL3(\u0020 + (\u0020 ^ \u0020 ^ \u0020) + \u0020[(int)\u0020] + hIDAYxH6DWLHIthQgC.SrDpPJg0d[(int)(\u0020 - 1U)], \u0020);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00029EE4 File Offset: 0x000280E4
		private static void LnTa1stFP(ref uint \u0020, uint \u0020, uint \u0020, uint \u0020, uint \u0020, ushort \u0020, uint \u0020, object \u0020)
		{
			\u0020 += hIDAYxH6DWLHIthQgC.qHMTQ5yL3(\u0020 + (\u0020 ^ (\u0020 | ~\u0020)) + \u0020[(int)\u0020] + hIDAYxH6DWLHIthQgC.SrDpPJg0d[(int)(\u0020 - 1U)], \u0020);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00029F14 File Offset: 0x00028114
		private static uint qHMTQ5yL3(uint \u0020, ushort \u0020)
		{
			return \u0020 >> (int)(32 - \u0020) | \u0020 << (int)\u0020;
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00029F30 File Offset: 0x00028130
		internal static byte[] KBfNgPHJl(object \u0020)
		{
			if (!hIDAYxH6DWLHIthQgC.BVBfH8LsP())
			{
				return new MD5CryptoServiceProvider().ComputeHash(\u0020);
			}
			return hIDAYxH6DWLHIthQgC.hIDHAYx6D(\u0020);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00029F58 File Offset: 0x00028158
		private static void RFMD89GDa()
		{
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00029F88 File Offset: 0x00028188
		internal static bool BVBfH8LsP()
		{
			if (!hIDAYxH6DWLHIthQgC.CPGmeecTL)
			{
				hIDAYxH6DWLHIthQgC.ATI5Y1kI0();
				hIDAYxH6DWLHIthQgC.CPGmeecTL = true;
			}
			return hIDAYxH6DWLHIthQgC.e1I76Dk1A;
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00029FAC File Offset: 0x000281AC
		internal byte[] Xf3RuiTPT()
		{
			int length = "{11111-22222-40001-00001}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00029FD0 File Offset: 0x000281D0
		internal byte[] caelxLNP2()
		{
			int length = "{11111-22222-40001-00002}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00029FF4 File Offset: 0x000281F4
		internal byte[] JmTEkpCbj()
		{
			int length = "{11111-22222-50001-00001}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0002A018 File Offset: 0x00028218
		internal byte[] EkggYQXiI()
		{
			int length = "{11111-22222-50001-00002}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0002A03C File Offset: 0x0002823C
		public static void k2fyjktZb(RuntimeTypeHandle \u0020)
		{
			try
			{
				Type typeFromHandle = Type.GetTypeFromHandle(\u0020);
				if (hIDAYxH6DWLHIthQgC.FmWIypaNX == null)
				{
					object cc86JSicc = hIDAYxH6DWLHIthQgC.CC86JSicc;
					lock (cc86JSicc)
					{
						Dictionary<int, int> dictionary = new Dictionary<int, int>();
						BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(f1stFPxcHMQ5yL3IBf.icSmQILiN5(33554744)).Assembly.GetManifestResourceStream("YEL8kutH6rg1YKMrKs.PWRL1CxWkgVIRkRPeY"));
						binaryReader.BaseStream.Position = 0L;
						byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
						binaryReader.Close();
						if (array.Length != 0)
						{
							int num = array.Length % 4;
							int num2 = array.Length / 4;
							byte[] array2 = new byte[array.Length];
							uint num3 = 0U;
							if (num > 0)
							{
								num2++;
							}
							for (int i = 0; i < num2; i++)
							{
								int num4 = i * 4;
								uint num5 = 255U;
								int num6 = 0;
								uint num7;
								if (i == num2 - 1 && num > 0)
								{
									num7 = 0U;
									for (int j = 0; j < num; j++)
									{
										if (j > 0)
										{
											num7 <<= 8;
										}
										num7 |= (uint)array[array.Length - (1 + j)];
									}
								}
								else
								{
									uint num8 = (uint)num4;
									num7 = (uint)((int)array[(int)(num8 + 3U)] << 24 | (int)array[(int)(num8 + 2U)] << 16 | (int)array[(int)(num8 + 1U)] << 8 | (int)array[(int)num8]);
								}
								num3 = num3;
								uint num9 = num3;
								uint num10 = num3;
								uint num11 = 1492307560U;
								uint num12 = 2084681836U;
								uint num13 = 972746621U;
								uint num14 = 2116243604U;
								ulong num15 = (ulong)(num12 * 1722488229U);
								num15 |= 1UL;
								num11 = (uint)((ulong)(num11 * num11) % num15);
								uint num16 = num10 & 1431655765U;
								uint num17 = num10 & 2863311530U;
								num16 = (num16 >> 1 | num17 << 1) + num12;
								num10 = (num10 << 6 | num10 >> 26);
								num10 = 185460390U * (num10 & 7U) + (num10 >> 3);
								num12 = 379997597U * (num12 & 7U) + (num12 >> 3);
								num11 = 12641U * num11 - num13;
								if (num13 == 0U)
								{
									num13 -= 1U;
								}
								uint num18 = num11 / num13 + num13;
								num13 = num11 + num11 + num18 + num11;
								num15 = (ulong)(num11 * num11);
								num15 |= 1UL;
								num14 = (uint)((ulong)(num14 * num14) % num15);
								num10 ^= num10 >> 7;
								num10 += num12;
								num10 ^= num10 >> 9;
								num10 += num13;
								num10 ^= num10 << 1;
								num10 += num14;
								num10 = ((num13 << 21) - num11 ^ num13) + num10;
								num3 = num9 + (uint)num10;
								if (i == num2 - 1 && num > 0)
								{
									uint num19 = num3 ^ num7;
									for (int k = 0; k < num; k++)
									{
										if (k > 0)
										{
											num5 <<= 8;
											num6 += 8;
										}
										array2[num4 + k] = (byte)((num19 & num5) >> num6);
									}
								}
								else
								{
									uint num20 = num3 ^ num7;
									array2[num4] = (byte)(num20 & 255U);
									array2[num4 + 1] = (byte)((num20 & 65280U) >> 8);
									array2[num4 + 2] = (byte)((num20 & 16711680U) >> 16);
									array2[num4 + 3] = (byte)((num20 & 4278190080U) >> 24);
								}
							}
							array = array2;
							int num21 = array.Length / 8;
							hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG vPkSh3s7U1vEqJ6ZwG = new hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG(new MemoryStream(array));
							for (int l = 0; l < num21; l++)
							{
								int key = vPkSh3s7U1vEqJ6ZwG.c73q0LArlF();
								int value = vPkSh3s7U1vEqJ6ZwG.c73q0LArlF();
								dictionary.Add(key, value);
							}
							vPkSh3s7U1vEqJ6ZwG.bFiqUko1xE();
						}
						hIDAYxH6DWLHIthQgC.FmWIypaNX = dictionary;
					}
				}
				foreach (FieldInfo fieldInfo in typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField))
				{
					int metadataToken = fieldInfo.MetadataToken;
					int num22 = hIDAYxH6DWLHIthQgC.FmWIypaNX[metadataToken];
					bool flag2 = (num22 & 1073741824) > 0;
					num22 &= 1073741823;
					MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(f1stFPxcHMQ5yL3IBf.icSmQILiN5(33554744)).Module.ResolveMethod(num22, typeFromHandle.GetGenericArguments(), new Type[0]);
					if (methodInfo.IsStatic)
					{
						fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
					}
					else
					{
						ParameterInfo[] parameters = methodInfo.GetParameters();
						int num23 = parameters.Length + 1;
						Type[] array3 = new Type[num23];
						if (methodInfo.DeclaringType.IsValueType)
						{
							array3[0] = methodInfo.DeclaringType.MakeByRefType();
						}
						else
						{
							array3[0] = Type.GetTypeFromHandle(f1stFPxcHMQ5yL3IBf.icSmQILiN5(16777234));
						}
						for (int n = 0; n < parameters.Length; n++)
						{
							array3[n + 1] = parameters[n].ParameterType;
						}
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						for (int num24 = 0; num24 < num23; num24++)
						{
							switch (num24)
							{
							case 0:
								ilgenerator.Emit(OpCodes.Ldarg_0);
								break;
							case 1:
								ilgenerator.Emit(OpCodes.Ldarg_1);
								break;
							case 2:
								ilgenerator.Emit(OpCodes.Ldarg_2);
								break;
							case 3:
								ilgenerator.Emit(OpCodes.Ldarg_3);
								break;
							default:
								ilgenerator.Emit(OpCodes.Ldarg_S, num24);
								break;
							}
						}
						ilgenerator.Emit(OpCodes.Tailcall);
						ilgenerator.Emit(flag2 ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
						ilgenerator.Emit(OpCodes.Ret);
						fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
					}
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0002A6F8 File Offset: 0x000288F8
		internal static void oDuBOTgYK()
		{
			if (Debugger.IsAttached)
			{
				throw new Exception("Debugger Detected");
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0002A718 File Offset: 0x00028918
		private static int gG68OgEs5()
		{
			return 5;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0002A724 File Offset: 0x00028924
		internal static void ATI5Y1kI0()
		{
			try
			{
				new MD5CryptoServiceProvider();
			}
			catch
			{
				hIDAYxH6DWLHIthQgC.e1I76Dk1A = true;
				return;
			}
			try
			{
				hIDAYxH6DWLHIthQgC.e1I76Dk1A = CryptoConfig.AllowOnlyFipsAlgorithms;
			}
			catch
			{
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0002A77C File Offset: 0x0002897C
		internal static SymmetricAlgorithm LtAJclWeT()
		{
			SymmetricAlgorithm result = null;
			if (hIDAYxH6DWLHIthQgC.BVBfH8LsP())
			{
				result = new AesCryptoServiceProvider();
			}
			else
			{
				try
				{
					result = new RijndaelManaged();
				}
				catch
				{
					result = new AesCryptoServiceProvider();
				}
			}
			return result;
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0002A7D0 File Offset: 0x000289D0
		private byte[] hVec8LoPP()
		{
			return null;
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0002A7E8 File Offset: 0x000289E8
		private byte[] aKRZE6Th1()
		{
			return null;
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0002A800 File Offset: 0x00028A00
		internal static void EZdsFxqyB(object \u0020, object \u0020, uint \u0020, object \u0020)
		{
			while (\u0020 > 0U)
			{
				int num = (\u0020 > (uint)\u0020.Length) ? \u0020.Length : ((int)\u0020);
				\u0020.Read(\u0020, 0, num);
				hIDAYxH6DWLHIthQgC.LKsFIQxCl(\u0020, \u0020, 0, num);
				\u0020 -= (uint)num;
			}
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0002A84C File Offset: 0x00028A4C
		internal static void LKsFIQxCl(object \u0020, object \u0020, int \u0020, int \u0020)
		{
			\u0020.TransformBlock(\u0020, \u0020, \u0020, \u0020, \u0020);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0002A864 File Offset: 0x00028A64
		internal static uint mf83VSwim(uint \u0020, int \u0020, long \u0020, object \u0020)
		{
			for (int i = 0; i < \u0020; i++)
			{
				\u0020.BaseStream.Position = \u0020 + (long)(i * 40 + 8);
				uint num = \u0020.ReadUInt32();
				uint num2 = \u0020.ReadUInt32();
				\u0020.ReadUInt32();
				uint num3 = \u0020.ReadUInt32();
				if (num2 <= \u0020 && \u0020 < num2 + num)
				{
					return num3 + \u0020 - num2;
				}
			}
			return 0U;
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0002A8D4 File Offset: 0x00028AD4
		internal static void zSLipEDdx()
		{
			int num = 15;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					string text;
					BinaryReader binaryReader;
					bool flag;
					switch (num2)
					{
					case 0:
						goto IL_B47;
					case 1:
						goto IL_922;
					case 2:
						return;
					case 3:
						try
						{
							FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
							int num3 = 32;
							for (;;)
							{
								int num4 = num3;
								uint num8;
								uint num11;
								long num15;
								for (;;)
								{
									HashAlgorithm hashAlgorithm;
									uint num7;
									byte[] array2;
									long num9;
									long num10;
									long num13;
									int num14;
									long num16;
									uint num17;
									int num18;
									switch (num4)
									{
									case 0:
										goto IL_3D5;
									case 1:
										goto IL_6FC;
									case 2:
										goto IL_2F0;
									case 3:
										goto IL_6FC;
									case 4:
										goto IL_455;
									case 5:
										goto IL_5C3;
									case 6:
										goto IL_37E;
									case 7:
										goto IL_6E9;
									case 8:
									{
										uint num5;
										byte[] array = hIDAYxH6DWLHIthQgC.A8nvrP1iv3rVqENEg2(binaryReader, (int)num5);
										num4 = 14;
										continue;
									}
									case 9:
									{
										uint num6 = hIDAYxH6DWLHIthQgC.kGXZ6IKJt2EgVVRdGS(binaryReader);
										num4 = 15;
										if (!hIDAYxH6DWLHIthQgC.AjBOhB79tM5GKWPsC8())
										{
											num4 = 3;
											continue;
										}
										continue;
									}
									case 10:
										goto IL_496;
									case 11:
										goto IL_2F0;
									case 12:
										goto IL_625;
									case 13:
										goto IL_5EF;
									case 14:
									{
										byte[] array;
										Array.Reverse<byte>(array);
										num4 = 19;
										continue;
									}
									case 15:
									{
										uint num6;
										hIDAYxH6DWLHIthQgC.dDE90fP12NhhA7421U(fileStream, (long)((ulong)num6));
										num4 = 18;
										if (hIDAYxH6DWLHIthQgC.AjBOhB79tM5GKWPsC8())
										{
											num4 = 48;
											continue;
										}
										continue;
									}
									case 16:
										break;
									case 17:
										goto IL_473;
									case 18:
										goto IL_455;
									case 19:
									{
										byte[] array;
										string text2;
										flag = !hIDAYxH6DWLHIthQgC.JEiDcDpSUMexywPZdZ(hIDAYxH6DWLHIthQgC.dJ60ZwGG7, hIDAYxH6DWLHIthQgC.FuKlTiM0YPWjWd6qOe(hashAlgorithm), text2, array);
										num4 = 14;
										if (hIDAYxH6DWLHIthQgC.AjBOhB79tM5GKWPsC8())
										{
											num4 = 20;
											continue;
										}
										continue;
									}
									case 20:
										goto IL_836;
									case 21:
										if (num7 >= num8)
										{
											num4 = 44;
											continue;
										}
										goto IL_37E;
									case 22:
										hIDAYxH6DWLHIthQgC.ijQGTyvwZYO5y7dpq4(hashAlgorithm, fileStream, 152U, array2);
										num4 = 4;
										if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() == null)
										{
											num4 = 29;
											continue;
										}
										continue;
									case 23:
										if (num9 > num10)
										{
											num4 = 2;
											continue;
										}
										goto IL_473;
									case 24:
										break;
									case 25:
										goto IL_283;
									case 26:
										goto IL_23C;
									case 27:
										hIDAYxH6DWLHIthQgC.ijQGTyvwZYO5y7dpq4(hashAlgorithm, fileStream, num11, array2);
										num4 = 28;
										continue;
									case 28:
										goto IL_5DA;
									case 29:
									{
										bool flag2 = hIDAYxH6DWLHIthQgC.KP9qRhBYyIXTHgdysX(binaryReader) != 523;
										int num12 = (!flag2) ? 112 : 96;
										hIDAYxH6DWLHIthQgC.dDE90fP12NhhA7421U(fileStream, 152L);
										hIDAYxH6DWLHIthQgC.pTK4pRjaE9SlbF40mN(fileStream, array2, 0, num12);
										array2[64] = 0;
										array2[65] = 0;
										array2[66] = 0;
										array2[67] = 0;
										hIDAYxH6DWLHIthQgC.lFo2d2T7cR0bqJ02at(hashAlgorithm, array2, 0, num12);
										hIDAYxH6DWLHIthQgC.pTK4pRjaE9SlbF40mN(fileStream, array2, 0, 128);
										array2[32] = 0;
										array2[33] = 0;
										array2[34] = 0;
										array2[35] = 0;
										array2[36] = 0;
										array2[37] = 0;
										array2[38] = 0;
										array2[39] = 0;
										hIDAYxH6DWLHIthQgC.lFo2d2T7cR0bqJ02at(hashAlgorithm, array2, 0, 128);
										num13 = hIDAYxH6DWLHIthQgC.yJL0Y9FRGnXf2iLPNk(fileStream);
										hIDAYxH6DWLHIthQgC.dDE90fP12NhhA7421U(fileStream, 134L);
										num14 = (int)hIDAYxH6DWLHIthQgC.KP9qRhBYyIXTHgdysX(binaryReader);
										hIDAYxH6DWLHIthQgC.dDE90fP12NhhA7421U(fileStream, num13);
										hIDAYxH6DWLHIthQgC.ijQGTyvwZYO5y7dpq4(hashAlgorithm, fileStream, (uint)(num14 * 40), array2);
										num15 = hIDAYxH6DWLHIthQgC.yJL0Y9FRGnXf2iLPNk(fileStream);
										if (flag2)
										{
											goto IL_5EF;
										}
										num4 = 0;
										if (hIDAYxH6DWLHIthQgC.AjBOhB79tM5GKWPsC8())
										{
											num4 = 0;
											continue;
										}
										continue;
									}
									case 30:
									{
										uint u = hIDAYxH6DWLHIthQgC.kGXZ6IKJt2EgVVRdGS(binaryReader);
										uint num5 = hIDAYxH6DWLHIthQgC.kGXZ6IKJt2EgVVRdGS(binaryReader);
										num9 = (long)((ulong)hIDAYxH6DWLHIthQgC.TaxWkH5YBwYtLWvwDe(u, num14, num13, binaryReader));
										num4 = 33;
										continue;
									}
									case 31:
										num8 = hIDAYxH6DWLHIthQgC.kGXZ6IKJt2EgVVRdGS(binaryReader);
										num4 = 9;
										if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() != null)
										{
											num4 = 7;
											continue;
										}
										continue;
									case 32:
										binaryReader = new BinaryReader(fileStream);
										num4 = 47;
										if (!hIDAYxH6DWLHIthQgC.AjBOhB79tM5GKWPsC8())
										{
											num4 = 26;
											continue;
										}
										continue;
									case 33:
									{
										uint num5;
										num16 = num9 + (long)((ulong)num5);
										num4 = 5;
										continue;
									}
									case 34:
										goto IL_637;
									case 35:
										goto IL_3BE;
									case 36:
										goto IL_23C;
									case 37:
										goto IL_2F0;
									case 38:
										goto IL_637;
									case 39:
										goto IL_50B;
									case 40:
										goto IL_496;
									case 41:
										hIDAYxH6DWLHIthQgC.dDE90fP12NhhA7421U(fileStream, (long)((ulong)(num17 + 32U)));
										num4 = 6;
										if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() == null)
										{
											num4 = 30;
											continue;
										}
										continue;
									case 42:
										hIDAYxH6DWLHIthQgC.dDE90fP12NhhA7421U(fileStream, num9);
										num4 = 8;
										continue;
									case 43:
									{
										FileStream fileStream2 = fileStream;
										hIDAYxH6DWLHIthQgC.dDE90fP12NhhA7421U(fileStream2, hIDAYxH6DWLHIthQgC.yJL0Y9FRGnXf2iLPNk(fileStream2) + (long)((ulong)num7));
										num4 = 22;
										if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() == null)
										{
											num4 = 24;
											continue;
										}
										continue;
									}
									case 44:
										goto IL_496;
									case 45:
										goto IL_6E9;
									case 46:
										num18 = 0;
										num4 = 0;
										if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() == null)
										{
											num4 = 3;
											continue;
										}
										continue;
									case 47:
										array2 = new byte[65536];
										num4 = 22;
										if (!hIDAYxH6DWLHIthQgC.AjBOhB79tM5GKWPsC8())
										{
											num4 = 22;
											continue;
										}
										continue;
									case 48:
										break;
									default:
										goto IL_3D5;
									}
									if (num8 <= 0U)
									{
										goto IL_496;
									}
									num4 = 5;
									if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() == null)
									{
										num4 = 45;
										continue;
									}
									continue;
									IL_23C:
									num11 = (uint)hIDAYxH6DWLHIthQgC.QgRNWgn8euZxguOKpC(num9 - num10, (long)((ulong)num8));
									num4 = 13;
									if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() == null)
									{
										num4 = 27;
										continue;
									}
									continue;
									IL_283:
									hIDAYxH6DWLHIthQgC.vCET4f34GpHqOKSOSk(hashAlgorithm, new byte[0], 0, 0);
									num4 = 42;
									continue;
									IL_6FC:
									if (num18 < num14)
									{
										num4 = 34;
										continue;
									}
									goto IL_283;
									IL_2F0:
									if (num10 >= num16)
									{
										goto IL_50B;
									}
									num4 = 2;
									if (hIDAYxH6DWLHIthQgC.AjBOhB79tM5GKWPsC8())
									{
										num4 = 26;
										continue;
									}
									continue;
									IL_37E:
									num8 -= num7;
									num4 = 43;
									if (!hIDAYxH6DWLHIthQgC.AjBOhB79tM5GKWPsC8())
									{
										num4 = 12;
										continue;
									}
									continue;
									IL_3BE:
									hIDAYxH6DWLHIthQgC.dDE90fP12NhhA7421U(fileStream, 376L);
									num4 = 18;
									continue;
									IL_3D5:
									goto IL_3BE;
									IL_455:
									num17 = hIDAYxH6DWLHIthQgC.TaxWkH5YBwYtLWvwDe(hIDAYxH6DWLHIthQgC.kGXZ6IKJt2EgVVRdGS(binaryReader), num14, num13, binaryReader);
									num4 = 41;
									continue;
									IL_473:
									if (num10 < num16)
									{
										goto IL_625;
									}
									num4 = 13;
									if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() == null)
									{
										num4 = 37;
										continue;
									}
									continue;
									IL_496:
									num18++;
									num4 = 0;
									if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() == null)
									{
										num4 = 1;
										continue;
									}
									continue;
									IL_50B:
									hIDAYxH6DWLHIthQgC.ijQGTyvwZYO5y7dpq4(hashAlgorithm, fileStream, num8, array2);
									num4 = 40;
									continue;
									IL_5EF:
									hIDAYxH6DWLHIthQgC.dDE90fP12NhhA7421U(fileStream, 360L);
									num4 = 4;
									continue;
									IL_625:
									num7 = (uint)(num16 - num10);
									num4 = 21;
									continue;
									IL_637:
									hIDAYxH6DWLHIthQgC.dDE90fP12NhhA7421U(fileStream, num13 + (long)(num18 * 40) + 16L);
									num4 = 20;
									if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() == null)
									{
										num4 = 31;
										continue;
									}
									continue;
									IL_6E9:
									num10 = hIDAYxH6DWLHIthQgC.yJL0Y9FRGnXf2iLPNk(fileStream);
									num4 = 23;
								}
								IL_5C3:
								hIDAYxH6DWLHIthQgC.dDE90fP12NhhA7421U(fileStream, num15);
								num3 = 46;
								continue;
								IL_5DA:
								num8 -= num11;
								num3 = 16;
							}
							IL_836:
							goto IL_9F8;
						}
						catch
						{
							int num19 = 0;
							if (hIDAYxH6DWLHIthQgC.AjBOhB79tM5GKWPsC8())
							{
								num19 = 0;
							}
							for (;;)
							{
								switch (num19)
								{
								default:
									flag = true;
									num19 = 1;
									if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() != null)
									{
										num19 = 0;
									}
									break;
								case 1:
									goto IL_889;
								}
							}
							IL_889:
							goto IL_9F8;
						}
						goto IL_8A8;
					case 4:
						hIDAYxH6DWLHIthQgC.dJ60ZwGG7 = new RSACryptoServiceProvider();
						num2 = 7;
						continue;
					case 5:
						goto IL_8A8;
					case 6:
						goto IL_9F8;
					case 7:
						text = hIDAYxH6DWLHIthQgC.C2TWl3WL2TZBL2Bkme(hIDAYxH6DWLHIthQgC.hevLtnJTl2bV1aTVOP(typeof(hIDAYxH6DWLHIthQgC).TypeHandle).Assembly);
						num2 = 12;
						if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() != null)
						{
							num2 = 8;
							continue;
						}
						continue;
					case 8:
						flag = false;
						num2 = 21;
						continue;
					case 9:
						try
						{
							HashAlgorithm hashAlgorithm = hIDAYxH6DWLHIthQgC.rX2R6TDJrN9uqmHLGY();
							int num20 = 4;
							for (;;)
							{
								switch (num20)
								{
								case 1:
									if (hIDAYxH6DWLHIthQgC.CtxZsBoBAQP3NMN7ae(text))
									{
										num20 = 2;
										continue;
									}
									break;
								case 2:
									goto IL_A47;
								case 3:
									goto IL_AB1;
								case 4:
								{
									string text2 = hIDAYxH6DWLHIthQgC.Empm36ZN8QkV83gmlw("SHA1");
									num20 = 0;
									if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() == null)
									{
										num20 = 1;
										continue;
									}
									continue;
								}
								}
								break;
							}
							goto IL_A66;
							IL_A47:
							goto IL_AB1;
							IL_A66:
							return;
							IL_AB1:
							goto IL_9DB;
						}
						catch
						{
							int num21 = 0;
							if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() != null)
							{
								num21 = 0;
							}
							switch (num21)
							{
							default:
								return;
							}
						}
						goto IL_B02;
					case 10:
						goto IL_B02;
					case 11:
					{
						HashAlgorithm hashAlgorithm = null;
						num2 = 17;
						continue;
					}
					case 12:
						if (text != null)
						{
							goto IL_21E6;
						}
						num2 = 0;
						if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() == null)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 13:
						break;
					case 14:
						hIDAYxH6DWLHIthQgC.sWKdW5kmYK4D2o6S3j(true);
						num2 = 4;
						continue;
					case 15:
						goto IL_F3;
					case 16:
						break;
					case 17:
					{
						string text2 = null;
						num2 = 9;
						continue;
					}
					case 18:
						goto IL_9DB;
					case 19:
						goto IL_8B9;
					case 20:
						try
						{
							if (binaryReader != null)
							{
								int num22 = 0;
								if (!hIDAYxH6DWLHIthQgC.AjBOhB79tM5GKWPsC8())
								{
									num22 = 0;
								}
								for (;;)
								{
									switch (num22)
									{
									default:
										hIDAYxH6DWLHIthQgC.RZnSBc43Ctj6LT79cg(binaryReader);
										num22 = 1;
										if (hIDAYxH6DWLHIthQgC.AjBOhB79tM5GKWPsC8())
										{
											num22 = 1;
										}
										break;
									case 1:
										goto IL_99A;
									}
								}
							}
							IL_99A:
							break;
						}
						catch
						{
							int num23 = 0;
							if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() == null)
							{
								num23 = 0;
							}
							switch (num23)
							{
							default:
								goto IL_C3;
							}
						}
						goto IL_9DB;
					case 21:
						return;
					case 22:
						goto IL_21E6;
					default:
						goto IL_B47;
					}
					IL_C3:
					if (!flag)
					{
						num2 = 8;
						continue;
					}
					goto IL_B02;
					IL_8A8:
					if (flag)
					{
						num2 = 13;
						continue;
					}
					goto IL_8B9;
					IL_B47:
					try
					{
						hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG vPkSh3s7U1vEqJ6ZwG = new hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG(hIDAYxH6DWLHIthQgC.uBGuKjbKU9R9F5k0re(hIDAYxH6DWLHIthQgC.mLdMA9iPk, "svMoARiOVRRdEgcAik.JIcsGfIFmYsx3qIPSI"));
						hIDAYxH6DWLHIthQgC.dDE90fP12NhhA7421U(hIDAYxH6DWLHIthQgC.ECqARDfHC58YfHZnNA(vPkSh3s7U1vEqJ6ZwG), 0L);
						byte[] array3 = hIDAYxH6DWLHIthQgC.U9PFgNweLgkRLA44AE(vPkSh3s7U1vEqJ6ZwG, (int)hIDAYxH6DWLHIthQgC.iAk7qKdFNq20CuRdDL(hIDAYxH6DWLHIthQgC.ECqARDfHC58YfHZnNA(vPkSh3s7U1vEqJ6ZwG)));
						byte[] array4 = new byte[32];
						array4[0] = 64 + 7;
						array4[0] = 180 - 60;
						int num24 = 229 - 76;
						array4[0] = (byte)num24;
						int num25 = 123 - 46;
						array4[0] = (byte)num25;
						array4[1] = 24 + 121;
						num25 = 161 - 53;
						array4[1] = (byte)num25;
						num24 = 121 + 111;
						array4[1] = (byte)num24;
						num25 = 212 - 70;
						array4[1] = (byte)num25;
						array4[1] = 116 + 47;
						array4[1] = 135 + 73;
						array4[2] = 142 - 47;
						array4[2] = 227 - 75;
						array4[2] = 51 + 56;
						array4[2] = 52 + 88;
						num24 = 141 - 47;
						array4[3] = (byte)num24;
						array4[3] = 253 - 84;
						num24 = 52 + 2;
						array4[3] = (byte)num24;
						num25 = 14 + 24;
						array4[3] = (byte)num25;
						num25 = 44 - 26;
						array4[3] = (byte)num25;
						num24 = 238 - 79;
						array4[4] = (byte)num24;
						num24 = 191 - 63;
						array4[4] = (byte)num24;
						array4[4] = 68 - 35;
						num24 = 183 - 61;
						array4[5] = (byte)num24;
						array4[5] = 243 - 81;
						num24 = 133 - 44;
						array4[5] = (byte)num24;
						num24 = 116 + 34;
						array4[5] = (byte)num24;
						num25 = 232 - 77;
						array4[6] = (byte)num25;
						num25 = 75 + 10;
						array4[6] = (byte)num25;
						array4[6] = 35 + 106;
						array4[6] = 12 + 77;
						array4[6] = 184 - 61;
						array4[6] = 74 + 114;
						array4[7] = 134 - 44;
						array4[7] = 180 - 60;
						num25 = 167 + 86;
						array4[7] = (byte)num25;
						array4[8] = 221 - 73;
						num25 = 103 + 53;
						array4[8] = (byte)num25;
						num24 = 97 - 3;
						array4[8] = (byte)num24;
						num24 = 159 - 53;
						array4[9] = (byte)num24;
						array4[9] = 85 + 85;
						array4[9] = 174 - 58;
						array4[9] = 24 + 54;
						num24 = 231 - 77;
						array4[9] = (byte)num24;
						num24 = 63 - 48;
						array4[9] = (byte)num24;
						num24 = 61 + 103;
						array4[10] = (byte)num24;
						array4[10] = 32 + 2;
						num25 = 244 - 81;
						array4[10] = (byte)num25;
						array4[10] = 207 - 69;
						array4[10] = 155 - 51;
						num24 = 75 + 91;
						array4[10] = (byte)num24;
						num25 = 141 - 47;
						array4[11] = (byte)num25;
						num25 = 40 + 7;
						array4[11] = (byte)num25;
						num25 = 128 - 37;
						array4[11] = (byte)num25;
						array4[12] = 181 - 60;
						num25 = 250 - 83;
						array4[12] = (byte)num25;
						num25 = 89 + 121;
						array4[12] = (byte)num25;
						array4[12] = 25 + 99;
						num25 = 129 - 43;
						array4[12] = (byte)num25;
						array4[12] = 97 - 23;
						num25 = 25 + 22;
						array4[13] = (byte)num25;
						array4[13] = 71 + 102;
						array4[13] = 144 + 58;
						array4[14] = 28 + 120;
						array4[14] = 63 + 111;
						array4[14] = 117 + 38;
						array4[14] = 136 - 45;
						num25 = 154 - 51;
						array4[14] = (byte)num25;
						array4[14] = 144 + 60;
						array4[15] = 189 - 63;
						array4[15] = 128 - 42;
						num25 = 202 - 67;
						array4[15] = (byte)num25;
						array4[15] = 45 + 24;
						num25 = 212 - 70;
						array4[15] = (byte)num25;
						array4[15] = 188 - 117;
						num25 = 242 - 80;
						array4[16] = (byte)num25;
						array4[16] = 222 - 74;
						array4[16] = 138 + 106;
						array4[17] = 43 + 9;
						array4[17] = 125 - 41;
						num25 = 61 + 113;
						array4[17] = (byte)num25;
						num25 = 232 - 77;
						array4[17] = (byte)num25;
						array4[17] = 240 + 3;
						num25 = 9 + 6;
						array4[18] = (byte)num25;
						num24 = 109 + 11;
						array4[18] = (byte)num24;
						array4[18] = 56 + 124;
						array4[18] = 194 - 64;
						array4[18] = 117 + 71;
						array4[19] = 153 - 51;
						num25 = 162 - 54;
						array4[19] = (byte)num25;
						num25 = 37 + 68;
						array4[19] = (byte)num25;
						num25 = 100 + 31;
						array4[19] = (byte)num25;
						num25 = 192 - 64;
						array4[20] = (byte)num25;
						num24 = 40 + 105;
						array4[20] = (byte)num24;
						num24 = 60 + 78;
						array4[20] = (byte)num24;
						num25 = 65 + 107;
						array4[20] = (byte)num25;
						array4[21] = 82 + 107;
						num24 = 153 - 51;
						array4[21] = (byte)num24;
						num25 = 116 + 10;
						array4[21] = (byte)num25;
						num25 = 250 - 83;
						array4[21] = (byte)num25;
						array4[21] = 21 + 18;
						array4[21] = 185 + 38;
						array4[22] = 60 + 42;
						array4[22] = 84 + 44;
						array4[22] = 149 - 49;
						array4[22] = 229 - 76;
						array4[22] = 123 + 87;
						array4[23] = 247 - 82;
						array4[23] = 29 + 105;
						array4[23] = 70 - 45;
						array4[24] = 182 - 60;
						num25 = 146 - 48;
						array4[24] = (byte)num25;
						array4[24] = 140 + 51;
						num24 = 156 - 52;
						array4[25] = (byte)num24;
						array4[25] = 49 + 116;
						num25 = 30 + 60;
						array4[25] = (byte)num25;
						num25 = 68 - 49;
						array4[25] = (byte)num25;
						array4[26] = 141 - 47;
						num25 = 221 - 73;
						array4[26] = (byte)num25;
						array4[26] = 47 + 16;
						num24 = 41 + 7;
						array4[26] = (byte)num24;
						num24 = 121 + 87;
						array4[26] = (byte)num24;
						num24 = 133 - 44;
						array4[27] = (byte)num24;
						array4[27] = 237 - 79;
						array4[27] = 53 + 76;
						num25 = 206 - 68;
						array4[27] = (byte)num25;
						num24 = 157 - 52;
						array4[27] = (byte)num24;
						num24 = 185 + 43;
						array4[27] = (byte)num24;
						array4[28] = 125 - 41;
						num25 = 167 - 55;
						array4[28] = (byte)num25;
						num24 = 13 + 123;
						array4[28] = (byte)num24;
						array4[28] = 190 - 122;
						num25 = 161 - 53;
						array4[29] = (byte)num25;
						array4[29] = 111 + 84;
						array4[29] = 195 - 65;
						array4[29] = 135 - 45;
						num24 = 174 - 58;
						array4[29] = (byte)num24;
						array4[29] = 166 + 23;
						num25 = 153 - 51;
						array4[30] = (byte)num25;
						array4[30] = 154 - 51;
						array4[30] = 226 - 75;
						num25 = 93 - 28;
						array4[30] = (byte)num25;
						num25 = 125 - 41;
						array4[31] = (byte)num25;
						array4[31] = 201 - 67;
						num25 = 72 + 17;
						array4[31] = (byte)num25;
						num25 = 208 - 69;
						array4[31] = (byte)num25;
						array4[31] = 78 - 25;
						byte[] array5 = array4;
						byte[] array6 = new byte[16];
						array6[0] = 64 + 7;
						int num26 = 53 + 92;
						array6[0] = (byte)num26;
						array6[0] = 158 - 52;
						array6[0] = 211 - 70;
						num26 = 251 - 83;
						array6[0] = (byte)num26;
						num26 = 72 - 35;
						array6[0] = (byte)num26;
						int num27 = 251 - 83;
						array6[1] = (byte)num27;
						num27 = 142 - 47;
						array6[1] = (byte)num27;
						num27 = 116 + 116;
						array6[1] = (byte)num27;
						array6[1] = 201 - 67;
						array6[1] = 16 + 2;
						array6[1] = 41 + 98;
						array6[2] = 51 + 56;
						array6[2] = 120 + 16;
						array6[2] = 123 + 89;
						array6[2] = 146 - 52;
						array6[3] = 48 + 14;
						array6[3] = 45 + 26;
						num27 = 238 - 79;
						array6[3] = (byte)num27;
						num27 = 64 + 35;
						array6[3] = (byte)num27;
						num27 = 73 - 55;
						array6[3] = (byte)num27;
						array6[4] = 243 - 81;
						array6[4] = 8 + 106;
						num26 = 116 + 15;
						array6[4] = (byte)num26;
						num27 = 172 - 57;
						array6[5] = (byte)num27;
						num27 = 10 + 50;
						array6[5] = (byte)num27;
						array6[5] = 106 + 8;
						array6[5] = 189 + 12;
						array6[6] = 114 + 57;
						num27 = 20 + 8;
						array6[6] = (byte)num27;
						num26 = 121 - 52;
						array6[6] = (byte)num26;
						num26 = 215 - 71;
						array6[7] = (byte)num26;
						array6[7] = 221 - 73;
						array6[7] = 140 + 58;
						array6[8] = 180 - 60;
						array6[8] = 3 + 63;
						array6[8] = 121 + 85;
						array6[8] = 138 - 85;
						num27 = 174 - 58;
						array6[9] = (byte)num27;
						array6[9] = 24 + 54;
						num27 = 231 - 77;
						array6[9] = (byte)num27;
						array6[9] = 175 - 58;
						array6[9] = 144 + 82;
						array6[10] = 232 - 77;
						array6[10] = 32 + 2;
						num26 = 244 - 81;
						array6[10] = (byte)num26;
						array6[10] = 207 - 69;
						array6[10] = 29 + 64;
						num27 = 70 + 60;
						array6[10] = (byte)num27;
						array6[11] = 182 - 60;
						num26 = 133 - 44;
						array6[11] = (byte)num26;
						num26 = 163 - 54;
						array6[11] = (byte)num26;
						array6[11] = 54 + 55;
						array6[11] = 130 - 120;
						num26 = 89 + 121;
						array6[12] = (byte)num26;
						array6[12] = 25 + 99;
						num26 = 215 + 4;
						array6[12] = (byte)num26;
						array6[13] = 173 - 57;
						array6[13] = 148 - 49;
						num27 = 199 - 66;
						array6[13] = (byte)num27;
						num27 = 185 - 61;
						array6[13] = (byte)num27;
						array6[13] = 155 - 51;
						num27 = 55 - 55;
						array6[13] = (byte)num27;
						num27 = 111 + 82;
						array6[14] = (byte)num27;
						num27 = 165 - 55;
						array6[14] = (byte)num27;
						array6[14] = 11 + 55;
						num26 = 187 - 62;
						array6[14] = (byte)num26;
						num27 = 61 + 99;
						array6[14] = (byte)num27;
						array6[14] = 62 - 3;
						num26 = 202 - 67;
						array6[15] = (byte)num26;
						array6[15] = 45 + 24;
						num26 = 83 + 117;
						array6[15] = (byte)num26;
						num26 = 112 + 113;
						array6[15] = (byte)num26;
						num27 = 137 - 106;
						array6[15] = (byte)num27;
						byte[] array7 = array6;
						object obj = hIDAYxH6DWLHIthQgC.NyUOF3eMIXbRAaNveg();
						hIDAYxH6DWLHIthQgC.u1h9kAs2Tpba51pGNK(obj, CipherMode.CBC);
						ICryptoTransform transform = hIDAYxH6DWLHIthQgC.Jud26VQvgB0KDFCWQl(obj, array5, array7);
						Stream stream = hIDAYxH6DWLHIthQgC.Lw40pD2KllO0bHTCGR();
						CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
						hIDAYxH6DWLHIthQgC.I9495UyUtRpBaDPHdi(cryptoStream, array3, 0, array3.Length);
						hIDAYxH6DWLHIthQgC.A2GeYcSaaUKahImxtl(cryptoStream);
						hIDAYxH6DWLHIthQgC.oqKl1COjmWX6QIjAtK(hIDAYxH6DWLHIthQgC.dJ60ZwGG7, hIDAYxH6DWLHIthQgC.JkEuJ2VSo4XF3UGau8(hIDAYxH6DWLHIthQgC.kD9Ogcgju5I554ul04(), hIDAYxH6DWLHIthQgC.yCTAmclaHnPh8qgOJS(stream)));
						hIDAYxH6DWLHIthQgC.cSy7WtX2WoVpd2QDWX(stream);
						hIDAYxH6DWLHIthQgC.cSy7WtX2WoVpd2QDWX(cryptoStream);
						hIDAYxH6DWLHIthQgC.HOhjTGmt6ePcv85Jpy(vPkSh3s7U1vEqJ6ZwG);
						int num28 = 0;
						if (!hIDAYxH6DWLHIthQgC.AjBOhB79tM5GKWPsC8())
						{
							num28 = 0;
						}
						switch (num28)
						{
						default:
							goto IL_8A8;
						}
					}
					catch
					{
						int num29 = 0;
						if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() == null)
						{
							num29 = 0;
						}
						for (;;)
						{
							switch (num29)
							{
							default:
								flag = true;
								num29 = 1;
								if (hIDAYxH6DWLHIthQgC.AjBOhB79tM5GKWPsC8())
								{
									num29 = 1;
								}
								break;
							case 1:
								goto IL_21D7;
							}
						}
						IL_21D7:
						goto IL_8A8;
					}
					goto IL_21E6;
					IL_8B9:
					binaryReader = null;
					num2 = 3;
					continue;
					IL_9DB:
					flag = false;
					num2 = 0;
					if (hIDAYxH6DWLHIthQgC.IlmwxrRx8TVXBBvTol() == null)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_9F8:
					num2 = 11;
					if (hIDAYxH6DWLHIthQgC.AjBOhB79tM5GKWPsC8())
					{
						num2 = 20;
						continue;
					}
					continue;
					IL_21E6:
					if (hIDAYxH6DWLHIthQgC.Xq2Naxrg8F3gYT9vuS(text) == 0)
					{
						return;
					}
					num2 = 11;
				}
				IL_F3:
				if (hIDAYxH6DWLHIthQgC.dJ60ZwGG7 != null)
				{
					break;
				}
				num = 14;
			}
			return;
			IL_922:
			return;
			IL_B02:
			throw new Exception(hIDAYxH6DWLHIthQgC.OowQBmAA9ej6j7s9hbc(hIDAYxH6DWLHIthQgC.NHG4WJAHORqXSrSYUie(hIDAYxH6DWLHIthQgC.kAULKjzVV8EsVWPtL0(hIDAYxH6DWLHIthQgC.hevLtnJTl2bV1aTVOP(typeof(hIDAYxH6DWLHIthQgC).TypeHandle).Assembly)), " is tampered."));
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0002CB40 File Offset: 0x0002AD40
		private static Stream GOV9AYHwR()
		{
			return new MemoryStream();
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0002CB50 File Offset: 0x0002AD50
		private static byte[] HymVi6xxZ(object \u0020)
		{
			byte[] array;
			using (FileStream fileStream = new FileStream(\u0020, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				int num = 0;
				int i = (int)fileStream.Length;
				array = new byte[i];
				while (i > 0)
				{
					int num2 = fileStream.Read(array, num, i);
					num += num2;
					i -= num2;
				}
			}
			return array;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0002CBC4 File Offset: 0x0002ADC4
		internal static object xssAJn5FR(object \u0020)
		{
			try
			{
				if (File.Exists(((Assembly)\u0020).Location))
				{
					return ((Assembly)\u0020).Location;
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(((Assembly)\u0020).GetName().CodeBase.ToString().Replace("file:///", "")))
				{
					return ((Assembly)\u0020).GetName().CodeBase.ToString().Replace("file:///", "");
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(\u0020.GetType().GetProperty("Location").GetValue(\u0020, new object[0]).ToString()))
				{
					return \u0020.GetType().GetProperty("Location").GetValue(\u0020, new object[0]).ToString();
				}
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0002CCF4 File Offset: 0x0002AEF4
		private static byte[] dcJwyWJ2h(object \u0020)
		{
			return ((MemoryStream)\u0020).ToArray();
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0002CD08 File Offset: 0x0002AF08
		internal byte[] OZvj2rN0e()
		{
			int length = "{11111-22222-30001-00001}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0002CD2C File Offset: 0x0002AF2C
		internal byte[] tPnkNfto2()
		{
			int length = "{11111-22222-30001-00002}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0002CD50 File Offset: 0x0002AF50
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void BAASgSTaW(object \u0020)
		{
			NeFPnNYfto2SAAgSTa.XoaHyBJbad(0, new object[]
			{
				\u0020
			}, null);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0002CD88 File Offset: 0x0002AF88
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string gSCeTtiku(int \u0020)
		{
			if (hIDAYxH6DWLHIthQgC.RVsUi7vv8.Length == 0)
			{
				hIDAYxH6DWLHIthQgC.ReW45iIw5 = new List<string>();
				hIDAYxH6DWLHIthQgC.asMnx1K5s = new List<int>();
				hIDAYxH6DWLHIthQgC.BAASgSTaW(Type.GetTypeFromHandle(f1stFPxcHMQ5yL3IBf.icSmQILiN5(33554744)).GetTypeInfo().Assembly.GetManifestResourceStream("6jmm4DAF0gQufAR5uv.9q5CrmUeiG39yAef7Y"));
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}
			if (hIDAYxH6DWLHIthQgC.HDHKHhTXP < 75)
			{
				MethodBase method = new StackFrame(1).GetMethod();
				if (hIDAYxH6DWLHIthQgC.mLdMA9iPk != method.DeclaringType.Assembly)
				{
					bool flag = false;
					string name = method.DeclaringType.Assembly.GetName().Name;
					foreach (AssemblyName assemblyName in hIDAYxH6DWLHIthQgC.mLdMA9iPk.GetReferencedAssemblies())
					{
						if (name == assemblyName.Name)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						throw new Exception();
					}
				}
				hIDAYxH6DWLHIthQgC.HDHKHhTXP++;
			}
			object obj = hIDAYxH6DWLHIthQgC.iGWr5uXHi;
			lock (obj)
			{
				int num = BitConverter.ToInt32(hIDAYxH6DWLHIthQgC.RVsUi7vv8, \u0020);
				if (num < hIDAYxH6DWLHIthQgC.asMnx1K5s.Count && hIDAYxH6DWLHIthQgC.asMnx1K5s[num] == \u0020)
				{
					return hIDAYxH6DWLHIthQgC.ReW45iIw5[num];
				}
				try
				{
					byte[] array = new byte[num];
					Array.Copy(hIDAYxH6DWLHIthQgC.RVsUi7vv8, \u0020 + 4, array, 0, num);
					string @string = Encoding.Unicode.GetString(array, 0, array.Length);
					hIDAYxH6DWLHIthQgC.ReW45iIw5.Add(@string);
					hIDAYxH6DWLHIthQgC.asMnx1K5s.Add(\u0020);
					Array.Copy(BitConverter.GetBytes(hIDAYxH6DWLHIthQgC.ReW45iIw5.Count - 1), 0, hIDAYxH6DWLHIthQgC.RVsUi7vv8, \u0020, 4);
					return @string;
				}
				catch
				{
				}
			}
			return "";
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0002CF88 File Offset: 0x0002B188
		private hIDAYxH6DWLHIthQgC(byte[] \u0020, byte[] \u0020)
		{
			this.EG7tVH7R7 = \u0020;
			this.OnMCBfq5Q = \u0020;
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0002CFA8 File Offset: 0x0002B1A8
		private byte[] jQ6W68dSe(byte[] \u0020)
		{
			if (\u0020.Length == 0)
			{
				return new byte[0];
			}
			int num = \u0020.Length % 4;
			int num2 = \u0020.Length / 4;
			byte[] array = new byte[\u0020.Length];
			int num3 = this.EG7tVH7R7.Length / 4;
			uint num4 = 0U;
			if (num > 0)
			{
				num2++;
			}
			for (int i = 0; i < num2; i++)
			{
				int num5 = i % num3;
				int num6 = i * 4;
				uint num7 = (uint)(num5 * 4);
				uint num8 = this.EG7tVH7R7[(int)(num7 + 3U)] << 24 | this.EG7tVH7R7[(int)(num7 + 2U)] << 16 | this.EG7tVH7R7[(int)(num7 + 1U)] << 8 | this.EG7tVH7R7[(int)num7];
				if (i == num2 - 1 && num > 0)
				{
					uint num9 = 0U;
					uint num10 = 255U;
					int num11 = 0;
					for (int j = 0; j < num; j++)
					{
						if (j > 0)
						{
							num9 <<= 8;
						}
						num9 |= (uint)\u0020[\u0020.Length - (1 + j)];
					}
					num4 += num8;
					num4 += this.PFqopCc2r(num4);
					uint num12 = num4 ^ num9;
					for (int k = 0; k < num; k++)
					{
						if (k > 0)
						{
							num10 <<= 8;
							num11 += 8;
						}
						array[num6 + k] = (byte)((num12 & num10) >> num11);
					}
				}
				else
				{
					num7 = (uint)num6;
					uint num9 = (uint)((int)\u0020[(int)(num7 + 3U)] << 24 | (int)\u0020[(int)(num7 + 2U)] << 16 | (int)\u0020[(int)(num7 + 1U)] << 8 | (int)\u0020[(int)num7]);
					num4 += num8;
					num4 += this.PFqopCc2r(num4);
					uint num13 = num4 ^ num9;
					array[num6] = (byte)(num13 & 255U);
					array[num6 + 1] = (byte)((num13 & 65280U) >> 8);
					array[num6 + 2] = (byte)((num13 & 16711680U) >> 16);
					array[num6 + 3] = (byte)((num13 & 4278190080U) >> 24);
				}
			}
			return array;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0002D194 File Offset: 0x0002B394
		private uint PFqopCc2r(uint \u0020)
		{
			int num = 668931134;
			uint num2 = 1582787682U;
			uint num3 = 1577548636U;
			uint num4 = 332884210U;
			ulong num5 = (ulong)(num3 * 1313243236U);
			num5 |= 1UL;
			num2 = (uint)((ulong)(num2 * num2) % num5);
			ulong num6 = (ulong)(1907532890U * num3);
			if (num6 == 0UL)
			{
				num6 -= 1UL;
			}
			ulong num7 = (ulong)(num * num) % num6;
			uint num8 = (uint)(18446744073207225482UL - (ulong)num2);
			ulong num9 = (ulong)(num2 * 183835789U);
			num9 |= 1UL;
			num3 = (uint)((ulong)(num3 * num3) % num9);
			uint num10 = (num4 >> 6 | num4 << 26) ^ num2;
			uint num11 = num10 & 252645135U;
			num4 = ((num10 & 4042322160U) >> 4 | num11 << 4);
			uint num12 = \u0020 ^ \u0020 << 3;
			num12 += num8;
			num12 ^= num12 << 11;
			num12 += num3;
			num12 ^= num12 >> 27;
			num12 += num4;
			return ((num8 << 11) - num2 ^ num3) - num12;
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x0002D278 File Offset: 0x0002B478
		internal static string PdFXUg04j(object \u0020)
		{
			"{11111-22222-50001-00000}".Trim();
			byte[] array = Convert.FromBase64String(\u0020);
			return Encoding.Unicode.GetString(array, 0, array.Length);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0002D2B0 File Offset: 0x0002B4B0
		private static byte[] RoZLa7qiD(object \u0020)
		{
			return new hIDAYxH6DWLHIthQgC(new byte[]
			{
				123,
				5,
				74,
				12,
				244,
				156,
				221,
				154,
				121,
				221,
				183,
				41,
				121,
				65,
				9,
				43,
				67,
				81,
				23,
				43,
				74,
				63,
				64,
				23,
				95,
				185,
				226,
				244,
				45,
				194,
				211,
				43
			}, new byte[]
			{
				117,
				254,
				41,
				121,
				65,
				52,
				9,
				43,
				221,
				154,
				12,
				54,
				68,
				241,
				68,
				66
			}).jQ6W68dSe(\u0020);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0002D2E8 File Offset: 0x0002B4E8
		private byte[] htFdmQ9eP()
		{
			return null;
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0002D300 File Offset: 0x0002B500
		private byte[] dbXPZLbLV()
		{
			return null;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0002D318 File Offset: 0x0002B518
		internal static object IJQx5W09ZAPMEOwcjA(object A_0)
		{
			return A_0.BaseStream;
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0002D32C File Offset: 0x0002B52C
		internal static void YxU6WiNYUHpv5n2aBb(object A_0, long A_1)
		{
			A_0.Position = A_1;
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0002D344 File Offset: 0x0002B544
		internal static long V6Bpx0u0OfBbG9eC8o(object A_0)
		{
			return A_0.Length;
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0002D358 File Offset: 0x0002B558
		internal static object phAhWnEnVPadYbnSBY(object A_0, int A_1)
		{
			return A_0.ReadBytes(A_1);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0002D370 File Offset: 0x0002B570
		internal static object Ytoq6gcFExuUsXawUv(object A_0)
		{
			return A_0.EntryPoint;
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0002D384 File Offset: 0x0002B584
		internal static bool kCZ7Je6CkZ9TxAyeRa(object A_0, object A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0002D39C File Offset: 0x0002B59C
		internal static void SP22RRLvLGxaknu2yH(object A_0)
		{
			((IDisposable)A_0).Dispose();
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0002D3B0 File Offset: 0x0002B5B0
		internal static bool y2v57PhoKC6qAZ4bhG()
		{
			return null == null;
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0002D3C0 File Offset: 0x0002B5C0
		internal static object amP9AS8nNyEa3Dj6LV()
		{
			return null;
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0002D3CC File Offset: 0x0002B5CC
		internal static void sWKdW5kmYK4D2o6S3j(bool A_0)
		{
			RSACryptoServiceProvider.UseMachineKeyStore = A_0;
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0002D3E0 File Offset: 0x0002B5E0
		internal static Type hevLtnJTl2bV1aTVOP(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x0002D3F4 File Offset: 0x0002B5F4
		internal static object C2TWl3WL2TZBL2Bkme(object A_0)
		{
			return A_0.Location;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0002D408 File Offset: 0x0002B608
		internal static int Xq2Naxrg8F3gYT9vuS(object A_0)
		{
			return A_0.Length;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x0002D41C File Offset: 0x0002B61C
		internal static object rX2R6TDJrN9uqmHLGY()
		{
			return SHA1.Create();
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0002D42C File Offset: 0x0002B62C
		internal static object Empm36ZN8QkV83gmlw(object A_0)
		{
			return CryptoConfig.MapNameToOID(A_0);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0002D440 File Offset: 0x0002B640
		internal static bool CtxZsBoBAQP3NMN7ae(object A_0)
		{
			return File.Exists(A_0);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0002D454 File Offset: 0x0002B654
		internal static object uBGuKjbKU9R9F5k0re(object A_0, object A_1)
		{
			return A_0.GetManifestResourceStream(A_1);
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0002D46C File Offset: 0x0002B66C
		internal static object ECqARDfHC58YfHZnNA(object A_0)
		{
			return A_0.AsxqrFX3HQ();
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x0002D480 File Offset: 0x0002B680
		internal static void dDE90fP12NhhA7421U(object A_0, long A_1)
		{
			A_0.Position = A_1;
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0002D498 File Offset: 0x0002B698
		internal static long iAk7qKdFNq20CuRdDL(object A_0)
		{
			return A_0.Length;
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0002D4AC File Offset: 0x0002B6AC
		internal static object U9PFgNweLgkRLA44AE(object A_0, int \u0020)
		{
			return A_0.C9UqM3M0Ll(\u0020);
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0002D4C4 File Offset: 0x0002B6C4
		internal static object NyUOF3eMIXbRAaNveg()
		{
			return hIDAYxH6DWLHIthQgC.LtAJclWeT();
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x0002D4D4 File Offset: 0x0002B6D4
		internal static void u1h9kAs2Tpba51pGNK(object A_0, CipherMode A_1)
		{
			A_0.Mode = A_1;
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0002D4EC File Offset: 0x0002B6EC
		internal static object Jud26VQvgB0KDFCWQl(object A_0, object A_1, object A_2)
		{
			return A_0.CreateDecryptor(A_1, A_2);
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0002D508 File Offset: 0x0002B708
		internal static object Lw40pD2KllO0bHTCGR()
		{
			return hIDAYxH6DWLHIthQgC.GOV9AYHwR();
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0002D518 File Offset: 0x0002B718
		internal static void I9495UyUtRpBaDPHdi(object A_0, object A_1, int A_2, int A_3)
		{
			A_0.Write(A_1, A_2, A_3);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0002D538 File Offset: 0x0002B738
		internal static void A2GeYcSaaUKahImxtl(object A_0)
		{
			A_0.FlushFinalBlock();
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0002D54C File Offset: 0x0002B74C
		internal static object kD9Ogcgju5I554ul04()
		{
			return Encoding.UTF8;
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0002D55C File Offset: 0x0002B75C
		internal static object yCTAmclaHnPh8qgOJS(object A_0)
		{
			return hIDAYxH6DWLHIthQgC.dcJwyWJ2h(A_0);
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0002D570 File Offset: 0x0002B770
		internal static object JkEuJ2VSo4XF3UGau8(object A_0, object A_1)
		{
			return A_0.GetString(A_1);
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0002D588 File Offset: 0x0002B788
		internal static void oqKl1COjmWX6QIjAtK(object A_0, object A_1)
		{
			A_0.FromXmlString(A_1);
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0002D5A0 File Offset: 0x0002B7A0
		internal static void cSy7WtX2WoVpd2QDWX(object A_0)
		{
			A_0.Close();
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0002D5B4 File Offset: 0x0002B7B4
		internal static void HOhjTGmt6ePcv85Jpy(object A_0)
		{
			A_0.bFiqUko1xE();
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0002D5C8 File Offset: 0x0002B7C8
		internal static void ijQGTyvwZYO5y7dpq4(object A_0, object A_1, uint \u0020, object A_3)
		{
			hIDAYxH6DWLHIthQgC.EZdsFxqyB(A_0, A_1, \u0020, A_3);
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x0002D5E8 File Offset: 0x0002B7E8
		internal static ushort KP9qRhBYyIXTHgdysX(object A_0)
		{
			return A_0.ReadUInt16();
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0002D5FC File Offset: 0x0002B7FC
		internal static int pTK4pRjaE9SlbF40mN(object A_0, object A_1, int A_2, int A_3)
		{
			return A_0.Read(A_1, A_2, A_3);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0002D61C File Offset: 0x0002B81C
		internal static void lFo2d2T7cR0bqJ02at(object A_0, object A_1, int \u0020, int \u0020)
		{
			hIDAYxH6DWLHIthQgC.LKsFIQxCl(A_0, A_1, \u0020, \u0020);
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0002D63C File Offset: 0x0002B83C
		internal static long yJL0Y9FRGnXf2iLPNk(object A_0)
		{
			return A_0.Position;
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x0002D650 File Offset: 0x0002B850
		internal static uint kGXZ6IKJt2EgVVRdGS(object A_0)
		{
			return A_0.ReadUInt32();
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0002D664 File Offset: 0x0002B864
		internal static uint TaxWkH5YBwYtLWvwDe(uint \u0020, int \u0020, long \u0020, object A_3)
		{
			return hIDAYxH6DWLHIthQgC.mf83VSwim(\u0020, \u0020, \u0020, A_3);
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0002D684 File Offset: 0x0002B884
		internal static long QgRNWgn8euZxguOKpC(long A_0, long A_1)
		{
			return Math.Min(A_0, A_1);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0002D69C File Offset: 0x0002B89C
		internal static object vCET4f34GpHqOKSOSk(object A_0, object A_1, int A_2, int A_3)
		{
			return A_0.TransformFinalBlock(A_1, A_2, A_3);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0002D6BC File Offset: 0x0002B8BC
		internal static object A8nvrP1iv3rVqENEg2(object A_0, int A_1)
		{
			return A_0.ReadBytes(A_1);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x0002D6D4 File Offset: 0x0002B8D4
		internal static object FuKlTiM0YPWjWd6qOe(object A_0)
		{
			return A_0.Hash;
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x0002D6E8 File Offset: 0x0002B8E8
		internal static bool JEiDcDpSUMexywPZdZ(object A_0, object A_1, object A_2, object A_3)
		{
			return A_0.VerifyHash(A_1, A_2, A_3);
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x0002D708 File Offset: 0x0002B908
		internal static void RZnSBc43Ctj6LT79cg(object A_0)
		{
			A_0.Close();
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0002D71C File Offset: 0x0002B91C
		internal static object kAULKjzVV8EsVWPtL0(object A_0)
		{
			return A_0.GetName();
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0002D730 File Offset: 0x0002B930
		internal static object NHG4WJAHORqXSrSYUie(object A_0)
		{
			return A_0.Name;
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0002D744 File Offset: 0x0002B944
		internal static object OowQBmAA9ej6j7s9hbc(object A_0, object A_1)
		{
			return A_0 + A_1;
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0002D75C File Offset: 0x0002B95C
		internal static bool AjBOhB79tM5GKWPsC8()
		{
			return null == null;
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x0002D76C File Offset: 0x0002B96C
		internal static object IlmwxrRx8TVXBBvTol()
		{
			return null;
		}

		// Token: 0x040009A5 RID: 2469
		private static object CC86JSicc;

		// Token: 0x040009A6 RID: 2470
		private static object Bh317U1vE;

		// Token: 0x040009A7 RID: 2471
		private static object iGWr5uXHi;

		// Token: 0x040009A8 RID: 2472
		private static object RVsUi7vv8;

		// Token: 0x040009A9 RID: 2473
		private static object dJ60ZwGG7;

		// Token: 0x040009AA RID: 2474
		private static bool e1I76Dk1A;

		// Token: 0x040009AB RID: 2475
		private static Dictionary<int, int> FmWIypaNX;

		// Token: 0x040009AC RID: 2476
		private static List<int> asMnx1K5s;

		// Token: 0x040009AD RID: 2477
		private static bool CPGmeecTL;

		// Token: 0x040009AE RID: 2478
		private object EG7tVH7R7;

		// Token: 0x040009AF RID: 2479
		private static object SrDpPJg0d = new uint[]
		{
			3614090360U,
			3905402710U,
			606105819U,
			3250441966U,
			4118548399U,
			1200080426U,
			2821735955U,
			4249261313U,
			1770035416U,
			2336552879U,
			4294925233U,
			2304563134U,
			1804603682U,
			4254626195U,
			2792965006U,
			1236535329U,
			4129170786U,
			3225465664U,
			643717713U,
			3921069994U,
			3593408605U,
			38016083U,
			3634488961U,
			3889429448U,
			568446438U,
			3275163606U,
			4107603335U,
			1163531501U,
			2850285829U,
			4243563512U,
			1735328473U,
			2368359562U,
			4294588738U,
			2272392833U,
			1839030562U,
			4259657740U,
			2763975236U,
			1272893353U,
			4139469664U,
			3200236656U,
			681279174U,
			3936430074U,
			3572445317U,
			76029189U,
			3654602809U,
			3873151461U,
			530742520U,
			3299628645U,
			4096336452U,
			1126891415U,
			2878612391U,
			4237533241U,
			1700485571U,
			2399980690U,
			4293915773U,
			2240044497U,
			1873313359U,
			4264355552U,
			2734768916U,
			1309151649U,
			4149444226U,
			3174756917U,
			718787259U,
			3951481745U
		};

		// Token: 0x040009B0 RID: 2480
		private object OnMCBfq5Q;

		// Token: 0x040009B1 RID: 2481
		private static int HDHKHhTXP;

		// Token: 0x040009B2 RID: 2482
		private static List<string> ReW45iIw5;

		// Token: 0x040009B3 RID: 2483
		private static object mLdMA9iPk;

		// Token: 0x02000139 RID: 313
		internal class vPkSh3s7U1vEqJ6ZwG
		{
			// Token: 0x06000DFB RID: 3579 RVA: 0x0002D778 File Offset: 0x0002B978
			public vPkSh3s7U1vEqJ6ZwG(Stream \u0020)
			{
				this.TXSqn39pP3 = new BinaryReader(\u0020);
			}

			// Token: 0x06000DFC RID: 3580 RVA: 0x0002D794 File Offset: 0x0002B994
			internal Stream AsxqrFX3HQ()
			{
				return hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG.SVsb5wemu6UkFT0dswH(this.TXSqn39pP3);
			}

			// Token: 0x06000DFD RID: 3581 RVA: 0x0002D7A8 File Offset: 0x0002B9A8
			internal byte[] C9UqM3M0Ll(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG.AfZSFdevZ9IB9tbxLnr(this.TXSqn39pP3, \u0020);
			}

			// Token: 0x06000DFE RID: 3582 RVA: 0x0002D7C0 File Offset: 0x0002B9C0
			internal int N4Hq1iEYPX(byte[] \u0020, int \u0020, int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG.kuSub8eBGvD6NCVjaRu(this.TXSqn39pP3, \u0020, \u0020, \u0020);
			}

			// Token: 0x06000DFF RID: 3583 RVA: 0x0002D7D8 File Offset: 0x0002B9D8
			internal int c73q0LArlF()
			{
				return hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG.QPZrXmej4y1ZrZvhdAD(this.TXSqn39pP3);
			}

			// Token: 0x06000E00 RID: 3584 RVA: 0x0002D7EC File Offset: 0x0002B9EC
			internal void bFiqUko1xE()
			{
				hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG.bHKc7ueTqTogZUO5iSZ(this.TXSqn39pP3);
			}

			// Token: 0x06000E01 RID: 3585 RVA: 0x0002D800 File Offset: 0x0002BA00
			internal static object SVsb5wemu6UkFT0dswH(object A_0)
			{
				return A_0.BaseStream;
			}

			// Token: 0x06000E02 RID: 3586 RVA: 0x0002D814 File Offset: 0x0002BA14
			internal static object AfZSFdevZ9IB9tbxLnr(object A_0, int A_1)
			{
				return A_0.ReadBytes(A_1);
			}

			// Token: 0x06000E03 RID: 3587 RVA: 0x0002D82C File Offset: 0x0002BA2C
			internal static int kuSub8eBGvD6NCVjaRu(object A_0, object A_1, int A_2, int A_3)
			{
				return A_0.Read(A_1, A_2, A_3);
			}

			// Token: 0x06000E04 RID: 3588 RVA: 0x0002D84C File Offset: 0x0002BA4C
			internal static int QPZrXmej4y1ZrZvhdAD(object A_0)
			{
				return A_0.ReadInt32();
			}

			// Token: 0x06000E05 RID: 3589 RVA: 0x0002D860 File Offset: 0x0002BA60
			internal static void bHKc7ueTqTogZUO5iSZ(object A_0)
			{
				A_0.Close();
			}

			// Token: 0x040009B4 RID: 2484
			private object TXSqn39pP3;
		}

		// Token: 0x0200013A RID: 314
		// (Invoke) Token: 0x06000E07 RID: 3591
		private delegate void W7KVsiF7vv8RGW5uXH(object o);

		// Token: 0x0200013B RID: 315
		internal class uneW5i3Iw5OsMx1K5s
		{
			// Token: 0x06000E0A RID: 3594 RVA: 0x0002D874 File Offset: 0x0002BA74
			internal static string Hh1qKiqeMC(object \u0020, object \u0020)
			{
				byte[] array = hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.Yv55v2e3q3WeMVMlVlZ(hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.U9MSdPentPlxLu7NG7w(), \u0020);
				byte[] key = new byte[]
				{
					82,
					102,
					104,
					110,
					32,
					77,
					24,
					34,
					118,
					181,
					51,
					17,
					18,
					51,
					12,
					109,
					10,
					32,
					77,
					24,
					34,
					158,
					161,
					41,
					97,
					28,
					118,
					181,
					5,
					25,
					1,
					88
				};
				byte[] array2 = hIDAYxH6DWLHIthQgC.KBfNgPHJl(Encoding.Unicode.GetBytes(\u0020));
				MemoryStream memoryStream = new MemoryStream();
				SymmetricAlgorithm symmetricAlgorithm = hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.FPG9tre1vE3UaKPTvDr();
				symmetricAlgorithm.Key = key;
				hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.T0aqkkeMC1t2JvZ8KYq(symmetricAlgorithm, array2);
				CryptoStream cryptoStream = new CryptoStream(memoryStream, hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.lFBA8peps2fGcDd3S8D(symmetricAlgorithm), CryptoStreamMode.Write);
				hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.oc80wee4kk7Ho1rbMm9(cryptoStream, array, 0, array.Length);
				cryptoStream.Close();
				return hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.Fr8WYWsHhrxDJxMTLUg(hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.bSMNsrez6VWYSL0A3Fn(memoryStream));
			}

			// Token: 0x06000E0C RID: 3596 RVA: 0x0002D908 File Offset: 0x0002BB08
			internal static object U9MSdPentPlxLu7NG7w()
			{
				return Encoding.Unicode;
			}

			// Token: 0x06000E0D RID: 3597 RVA: 0x0002D918 File Offset: 0x0002BB18
			internal static object Yv55v2e3q3WeMVMlVlZ(object A_0, object A_1)
			{
				return A_0.GetBytes(A_1);
			}

			// Token: 0x06000E0E RID: 3598 RVA: 0x0002D930 File Offset: 0x0002BB30
			internal static object FPG9tre1vE3UaKPTvDr()
			{
				return hIDAYxH6DWLHIthQgC.LtAJclWeT();
			}

			// Token: 0x06000E0F RID: 3599 RVA: 0x0002D940 File Offset: 0x0002BB40
			internal static void T0aqkkeMC1t2JvZ8KYq(object A_0, object A_1)
			{
				A_0.IV = A_1;
			}

			// Token: 0x06000E10 RID: 3600 RVA: 0x0002D958 File Offset: 0x0002BB58
			internal static object lFBA8peps2fGcDd3S8D(object A_0)
			{
				return A_0.CreateEncryptor();
			}

			// Token: 0x06000E11 RID: 3601 RVA: 0x0002D96C File Offset: 0x0002BB6C
			internal static void oc80wee4kk7Ho1rbMm9(object A_0, object A_1, int A_2, int A_3)
			{
				A_0.Write(A_1, A_2, A_3);
			}

			// Token: 0x06000E12 RID: 3602 RVA: 0x0002D98C File Offset: 0x0002BB8C
			internal static object bSMNsrez6VWYSL0A3Fn(object A_0)
			{
				return A_0.ToArray();
			}

			// Token: 0x06000E13 RID: 3603 RVA: 0x0002D9A0 File Offset: 0x0002BBA0
			internal static object Fr8WYWsHhrxDJxMTLUg(object A_0)
			{
				return Convert.ToBase64String(A_0);
			}
		}
	}
}
