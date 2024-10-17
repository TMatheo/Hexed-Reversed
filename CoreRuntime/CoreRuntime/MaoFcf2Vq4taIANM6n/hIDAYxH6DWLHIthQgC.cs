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
using pFRqcJyyWJ2hUZv2rN;

namespace MaoFcf2Vq4taIANM6n
{
	// Token: 0x02000016 RID: 22
	internal class hIDAYxH6DWLHIthQgC
	{
		// Token: 0x06000078 RID: 120 RVA: 0x000054B0 File Offset: 0x000036B0
		static hIDAYxH6DWLHIthQgC()
		{
			hIDAYxH6DWLHIthQgC.e1I76Dk1A = false;
			hIDAYxH6DWLHIthQgC.FmWIypaNX = null;
			hIDAYxH6DWLHIthQgC.CC86JSicc = new object();
			hIDAYxH6DWLHIthQgC.mLdMA9iPk = typeof(hIDAYxH6DWLHIthQgC).Assembly;
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

		// Token: 0x06000079 RID: 121 RVA: 0x00005560 File Offset: 0x00003760
		internal hIDAYxH6DWLHIthQgC()
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00005568 File Offset: 0x00003768
		private void mL8dQnqyNB()
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000556C File Offset: 0x0000376C
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

		// Token: 0x0600007C RID: 124 RVA: 0x00005BD0 File Offset: 0x00003DD0
		private static void DLH2IthQg(ref uint \u0020, uint \u0020, uint \u0020, uint \u0020, uint \u0020, ushort \u0020, uint \u0020, object \u0020)
		{
			\u0020 += hIDAYxH6DWLHIthQgC.qHMTQ5yL3(\u0020 + ((\u0020 & \u0020) | (~\u0020 & \u0020)) + \u0020[(int)\u0020] + hIDAYxH6DWLHIthQgC.SrDpPJg0d[(int)(\u0020 - 1U)], \u0020);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00005BFC File Offset: 0x00003DFC
		private static void T1axoFcfV(ref uint \u0020, uint \u0020, uint \u0020, uint \u0020, uint \u0020, ushort \u0020, uint \u0020, object \u0020)
		{
			\u0020 += hIDAYxH6DWLHIthQgC.qHMTQ5yL3(\u0020 + ((\u0020 & \u0020) | (\u0020 & ~\u0020)) + \u0020[(int)\u0020] + hIDAYxH6DWLHIthQgC.SrDpPJg0d[(int)(\u0020 - 1U)], \u0020);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00005C28 File Offset: 0x00003E28
		private static void d4tqaIANM(ref uint \u0020, uint \u0020, uint \u0020, uint \u0020, uint \u0020, ushort \u0020, uint \u0020, object \u0020)
		{
			\u0020 += hIDAYxH6DWLHIthQgC.qHMTQ5yL3(\u0020 + (\u0020 ^ \u0020 ^ \u0020) + \u0020[(int)\u0020] + hIDAYxH6DWLHIthQgC.SrDpPJg0d[(int)(\u0020 - 1U)], \u0020);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005C50 File Offset: 0x00003E50
		private static void LnTa1stFP(ref uint \u0020, uint \u0020, uint \u0020, uint \u0020, uint \u0020, ushort \u0020, uint \u0020, object \u0020)
		{
			\u0020 += hIDAYxH6DWLHIthQgC.qHMTQ5yL3(\u0020 + (\u0020 ^ (\u0020 | ~\u0020)) + \u0020[(int)\u0020] + hIDAYxH6DWLHIthQgC.SrDpPJg0d[(int)(\u0020 - 1U)], \u0020);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00005C78 File Offset: 0x00003E78
		private static uint qHMTQ5yL3(uint \u0020, ushort \u0020)
		{
			return \u0020 >> (int)(32 - \u0020) | \u0020 << (int)\u0020;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00005C8C File Offset: 0x00003E8C
		internal static byte[] KBfNgPHJl(object \u0020)
		{
			if (!hIDAYxH6DWLHIthQgC.BVBfH8LsP())
			{
				return new MD5CryptoServiceProvider().ComputeHash(\u0020);
			}
			return hIDAYxH6DWLHIthQgC.hIDHAYx6D(\u0020);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00005CAC File Offset: 0x00003EAC
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

		// Token: 0x06000083 RID: 131 RVA: 0x00005CDC File Offset: 0x00003EDC
		internal static bool BVBfH8LsP()
		{
			if (!hIDAYxH6DWLHIthQgC.CPGmeecTL)
			{
				hIDAYxH6DWLHIthQgC.ATI5Y1kI0();
				hIDAYxH6DWLHIthQgC.CPGmeecTL = true;
			}
			return hIDAYxH6DWLHIthQgC.e1I76Dk1A;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00005CF8 File Offset: 0x00003EF8
		internal byte[] Xf3RuiTPT()
		{
			int length = "{11111-22222-40001-00001}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00005D18 File Offset: 0x00003F18
		internal byte[] caelxLNP2()
		{
			int length = "{11111-22222-40001-00002}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00005D38 File Offset: 0x00003F38
		internal byte[] JmTEkpCbj()
		{
			int length = "{11111-22222-50001-00001}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00005D58 File Offset: 0x00003F58
		internal byte[] EkggYQXiI()
		{
			int length = "{11111-22222-50001-00002}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00005D78 File Offset: 0x00003F78
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
						BinaryReader binaryReader = new BinaryReader(typeof(hIDAYxH6DWLHIthQgC).Assembly.GetManifestResourceStream("sMSJsAHBaySJODr4W3.RF8vdSgfS3tILA2PH1"));
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
								uint num11 = 1757104966U;
								uint num12 = 1144258727U;
								uint num13 = 1869244103U;
								uint num14 = 1261469018U;
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
					MethodInfo methodInfo = (MethodInfo)typeof(hIDAYxH6DWLHIthQgC).Module.ResolveMethod(num22, typeFromHandle.GetGenericArguments(), new Type[0]);
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
							array3[0] = typeof(object);
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

		// Token: 0x06000089 RID: 137 RVA: 0x00006424 File Offset: 0x00004624
		internal static void oDuBOTgYK()
		{
			if (Debugger.IsAttached)
			{
				throw new Exception("Debugger Detected");
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000643C File Offset: 0x0000463C
		private static int gG68OgEs5()
		{
			return 5;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00006440 File Offset: 0x00004640
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

		// Token: 0x0600008C RID: 140 RVA: 0x00006498 File Offset: 0x00004698
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

		// Token: 0x0600008D RID: 141 RVA: 0x000064E8 File Offset: 0x000046E8
		private byte[] hVec8LoPP()
		{
			int length = "{11111-22222-20001-00001}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00006508 File Offset: 0x00004708
		private byte[] aKRZE6Th1()
		{
			int length = "{11111-22222-20001-00002}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00006528 File Offset: 0x00004728
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

		// Token: 0x06000090 RID: 144 RVA: 0x0000656C File Offset: 0x0000476C
		internal static void LKsFIQxCl(object \u0020, object \u0020, int \u0020, int \u0020)
		{
			\u0020.TransformBlock(\u0020, \u0020, \u0020, \u0020, \u0020);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000657C File Offset: 0x0000477C
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

		// Token: 0x06000092 RID: 146 RVA: 0x000065E4 File Offset: 0x000047E4
		internal static void zSLipEDdx()
		{
			if (hIDAYxH6DWLHIthQgC.dJ60ZwGG7 == null)
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
				hIDAYxH6DWLHIthQgC.dJ60ZwGG7 = new RSACryptoServiceProvider();
				string location = typeof(hIDAYxH6DWLHIthQgC).Assembly.Location;
				if (location == null || location.Length == 0)
				{
					return;
				}
				HashAlgorithm hashAlgorithm = null;
				string str = null;
				try
				{
					hashAlgorithm = SHA1.Create();
					str = CryptoConfig.MapNameToOID("SHA1");
					if (!File.Exists(location))
					{
						return;
					}
				}
				catch
				{
					return;
				}
				bool flag = false;
				try
				{
					hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG vPkSh3s7U1vEqJ6ZwG = new hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG(hIDAYxH6DWLHIthQgC.mLdMA9iPk.GetManifestResourceStream("{11111-22222-20001-00000}"));
					vPkSh3s7U1vEqJ6ZwG.AsxqrFX3HQ().Position = 0L;
					byte[] array = vPkSh3s7U1vEqJ6ZwG.C9UqM3M0Ll((int)vPkSh3s7U1vEqJ6ZwG.AsxqrFX3HQ().Length);
					byte[] rgbKey = new hIDAYxH6DWLHIthQgC().aKRZE6Th1();
					byte[] rgbIV = new hIDAYxH6DWLHIthQgC().hVec8LoPP();
					SymmetricAlgorithm symmetricAlgorithm = hIDAYxH6DWLHIthQgC.LtAJclWeT();
					symmetricAlgorithm.Mode = CipherMode.CBC;
					ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(rgbKey, rgbIV);
					Stream stream = hIDAYxH6DWLHIthQgC.GOV9AYHwR();
					CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					cryptoStream.Write(array, 0, array.Length);
					cryptoStream.FlushFinalBlock();
					hIDAYxH6DWLHIthQgC.dJ60ZwGG7.FromXmlString(Encoding.UTF8.GetString(hIDAYxH6DWLHIthQgC.dcJwyWJ2h(stream)));
					stream.Close();
					cryptoStream.Close();
					vPkSh3s7U1vEqJ6ZwG.bFiqUko1xE();
				}
				catch
				{
					flag = true;
				}
				if (!flag)
				{
					BinaryReader binaryReader = null;
					try
					{
						FileStream fileStream = new FileStream(location, FileMode.Open, FileAccess.Read, FileShare.Read);
						binaryReader = new BinaryReader(fileStream);
						byte[] array2 = new byte[65536];
						hIDAYxH6DWLHIthQgC.EZdsFxqyB(hashAlgorithm, fileStream, 152U, array2);
						bool flag2 = binaryReader.ReadUInt16() != 523;
						int num = flag2 ? 96 : 112;
						fileStream.Position = 152L;
						fileStream.Read(array2, 0, num);
						array2[64] = 0;
						array2[65] = 0;
						array2[66] = 0;
						array2[67] = 0;
						hIDAYxH6DWLHIthQgC.LKsFIQxCl(hashAlgorithm, array2, 0, num);
						fileStream.Read(array2, 0, 128);
						array2[32] = 0;
						array2[33] = 0;
						array2[34] = 0;
						array2[35] = 0;
						array2[36] = 0;
						array2[37] = 0;
						array2[38] = 0;
						array2[39] = 0;
						hIDAYxH6DWLHIthQgC.LKsFIQxCl(hashAlgorithm, array2, 0, 128);
						long position = fileStream.Position;
						fileStream.Position = 134L;
						int num2 = (int)binaryReader.ReadUInt16();
						fileStream.Position = position;
						hIDAYxH6DWLHIthQgC.EZdsFxqyB(hashAlgorithm, fileStream, (uint)(num2 * 40), array2);
						long position2 = fileStream.Position;
						if (flag2)
						{
							fileStream.Position = 360L;
						}
						else
						{
							fileStream.Position = 376L;
						}
						uint num3 = hIDAYxH6DWLHIthQgC.mf83VSwim(binaryReader.ReadUInt32(), num2, position, binaryReader);
						fileStream.Position = (long)((ulong)(num3 + 32U));
						uint u = binaryReader.ReadUInt32();
						uint num4 = binaryReader.ReadUInt32();
						long num5 = (long)((ulong)hIDAYxH6DWLHIthQgC.mf83VSwim(u, num2, position, binaryReader));
						long num6 = num5 + (long)((ulong)num4);
						fileStream.Position = position2;
						for (int i = 0; i < num2; i++)
						{
							fileStream.Position = position + (long)(i * 40) + 16L;
							uint num7 = binaryReader.ReadUInt32();
							uint num8 = binaryReader.ReadUInt32();
							fileStream.Position = (long)((ulong)num8);
							while (num7 > 0U)
							{
								long position3 = fileStream.Position;
								if (num5 <= position3 && position3 < num6)
								{
									uint num9 = (uint)(num6 - position3);
									if (num9 >= num7)
									{
										break;
									}
									num7 -= num9;
									fileStream.Position += (long)((ulong)num9);
								}
								else
								{
									if (position3 >= num6)
									{
										hIDAYxH6DWLHIthQgC.EZdsFxqyB(hashAlgorithm, fileStream, num7, array2);
										break;
									}
									uint num10 = (uint)Math.Min(num5 - position3, (long)((ulong)num7));
									hIDAYxH6DWLHIthQgC.EZdsFxqyB(hashAlgorithm, fileStream, num10, array2);
									num7 -= num10;
								}
							}
						}
						hashAlgorithm.TransformFinalBlock(new byte[0], 0, 0);
						fileStream.Position = num5;
						byte[] array3 = binaryReader.ReadBytes((int)num4);
						Array.Reverse<byte>(array3);
						flag = !hIDAYxH6DWLHIthQgC.dJ60ZwGG7.VerifyHash(hashAlgorithm.Hash, str, array3);
					}
					catch
					{
						flag = true;
					}
					try
					{
						if (binaryReader != null)
						{
							binaryReader.Close();
						}
					}
					catch
					{
					}
				}
				if (flag)
				{
					throw new Exception(typeof(hIDAYxH6DWLHIthQgC).Assembly.GetName().Name + " is tampered.");
				}
				flag = false;
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00006A98 File Offset: 0x00004C98
		private static Stream GOV9AYHwR()
		{
			return new MemoryStream();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00006AA0 File Offset: 0x00004CA0
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

		// Token: 0x06000095 RID: 149 RVA: 0x00006B0C File Offset: 0x00004D0C
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

		// Token: 0x06000096 RID: 150 RVA: 0x00006C3C File Offset: 0x00004E3C
		private static byte[] dcJwyWJ2h(object \u0020)
		{
			return ((MemoryStream)\u0020).ToArray();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00006C4C File Offset: 0x00004E4C
		internal byte[] OZvj2rN0e()
		{
			int length = "{11111-22222-30001-00001}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00006C6C File Offset: 0x00004E6C
		internal byte[] tPnkNfto2()
		{
			int length = "{11111-22222-30001-00002}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00006C8C File Offset: 0x00004E8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void BAASgSTaW(object \u0020)
		{
			NeFPnNYfto2SAAgSTa.XoaHyBJbad(0, new object[]
			{
				\u0020
			}, null);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00006CBC File Offset: 0x00004EBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string gSCeTtiku(int \u0020)
		{
			if (hIDAYxH6DWLHIthQgC.RVsUi7vv8.Length == 0)
			{
				hIDAYxH6DWLHIthQgC.ReW45iIw5 = new List<string>();
				hIDAYxH6DWLHIthQgC.asMnx1K5s = new List<int>();
				hIDAYxH6DWLHIthQgC.BAASgSTaW(typeof(hIDAYxH6DWLHIthQgC).GetTypeInfo().Assembly.GetManifestResourceStream("vq4ehGkYGmaK9uooFQ.rPFfsC8LGcSaZJsZhI"));
				nHwRpygmi6xxZAssJn.UoDdI5CpWg();
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

		// Token: 0x0600009B RID: 155 RVA: 0x00006EB0 File Offset: 0x000050B0
		private hIDAYxH6DWLHIthQgC(byte[] \u0020, byte[] \u0020)
		{
			this.EG7tVH7R7 = \u0020;
			this.OnMCBfq5Q = \u0020;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00006EC8 File Offset: 0x000050C8
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
				uint num8 = (uint)((int)this.EG7tVH7R7[(int)(num7 + 3U)] << 24 | (int)this.EG7tVH7R7[(int)(num7 + 2U)] << 16 | (int)this.EG7tVH7R7[(int)(num7 + 1U)] << 8 | (int)this.EG7tVH7R7[(int)num7]);
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

		// Token: 0x0600009D RID: 157 RVA: 0x000070AC File Offset: 0x000052AC
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

		// Token: 0x0600009E RID: 158 RVA: 0x00007188 File Offset: 0x00005388
		internal static string PdFXUg04j(object \u0020)
		{
			"{11111-22222-50001-00000}".Trim();
			byte[] array = Convert.FromBase64String(\u0020);
			return Encoding.Unicode.GetString(array, 0, array.Length);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000071B8 File Offset: 0x000053B8
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

		// Token: 0x060000A0 RID: 160 RVA: 0x000071EC File Offset: 0x000053EC
		private byte[] htFdmQ9eP()
		{
			return null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000071FC File Offset: 0x000053FC
		private byte[] dbXPZLbLV()
		{
			return null;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000720C File Offset: 0x0000540C
		internal static bool e5iW939MeW9I3b1V6q()
		{
			return null == null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00007214 File Offset: 0x00005414
		internal static object l3hR13hFOY6aTPk5L1()
		{
			return null;
		}

		// Token: 0x0400002A RID: 42
		private static bool e1I76Dk1A;

		// Token: 0x0400002B RID: 43
		private static byte[] Bh317U1vE;

		// Token: 0x0400002C RID: 44
		private static List<int> asMnx1K5s;

		// Token: 0x0400002D RID: 45
		private byte[] EG7tVH7R7;

		// Token: 0x0400002E RID: 46
		private static List<string> ReW45iIw5;

		// Token: 0x0400002F RID: 47
		private static uint[] SrDpPJg0d = new uint[]
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

		// Token: 0x04000030 RID: 48
		private static RSACryptoServiceProvider dJ60ZwGG7;

		// Token: 0x04000031 RID: 49
		private static object iGWr5uXHi;

		// Token: 0x04000032 RID: 50
		private static bool CPGmeecTL = false;

		// Token: 0x04000033 RID: 51
		private byte[] OnMCBfq5Q;

		// Token: 0x04000034 RID: 52
		private static int HDHKHhTXP;

		// Token: 0x04000035 RID: 53
		private static byte[] RVsUi7vv8;

		// Token: 0x04000036 RID: 54
		private static Dictionary<int, int> FmWIypaNX;

		// Token: 0x04000037 RID: 55
		private static object CC86JSicc;

		// Token: 0x04000038 RID: 56
		private static Assembly mLdMA9iPk;

		// Token: 0x02000017 RID: 23
		internal class vPkSh3s7U1vEqJ6ZwG
		{
			// Token: 0x060000A4 RID: 164 RVA: 0x00007218 File Offset: 0x00005418
			public vPkSh3s7U1vEqJ6ZwG(Stream \u0020)
			{
				this.TXSqn39pP3 = new BinaryReader(\u0020);
			}

			// Token: 0x060000A5 RID: 165 RVA: 0x0000722C File Offset: 0x0000542C
			internal Stream AsxqrFX3HQ()
			{
				return this.TXSqn39pP3.BaseStream;
			}

			// Token: 0x060000A6 RID: 166 RVA: 0x0000723C File Offset: 0x0000543C
			internal byte[] C9UqM3M0Ll(int \u0020)
			{
				return this.TXSqn39pP3.ReadBytes(\u0020);
			}

			// Token: 0x060000A7 RID: 167 RVA: 0x0000724C File Offset: 0x0000544C
			internal int N4Hq1iEYPX(byte[] \u0020, int \u0020, int \u0020)
			{
				return this.TXSqn39pP3.Read(\u0020, \u0020, \u0020);
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x0000725C File Offset: 0x0000545C
			internal int c73q0LArlF()
			{
				return this.TXSqn39pP3.ReadInt32();
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x0000726C File Offset: 0x0000546C
			internal void bFiqUko1xE()
			{
				this.TXSqn39pP3.Close();
			}

			// Token: 0x04000039 RID: 57
			private BinaryReader TXSqn39pP3;
		}

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x060000AB RID: 171
		private delegate void W7KVsiF7vv8RGW5uXH(object o);

		// Token: 0x02000019 RID: 25
		internal class uneW5i3Iw5OsMx1K5s
		{
			// Token: 0x060000AE RID: 174 RVA: 0x0000727C File Offset: 0x0000547C
			internal static string Hh1qKiqeMC(object \u0020, object \u0020)
			{
				byte[] bytes = Encoding.Unicode.GetBytes(\u0020);
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
				byte[] iv = hIDAYxH6DWLHIthQgC.KBfNgPHJl(Encoding.Unicode.GetBytes(\u0020));
				MemoryStream memoryStream = new MemoryStream();
				SymmetricAlgorithm symmetricAlgorithm = hIDAYxH6DWLHIthQgC.LtAJclWeT();
				symmetricAlgorithm.Key = key;
				symmetricAlgorithm.IV = iv;
				CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(bytes, 0, bytes.Length);
				cryptoStream.Close();
				return Convert.ToBase64String(memoryStream.ToArray());
			}
		}
	}
}
