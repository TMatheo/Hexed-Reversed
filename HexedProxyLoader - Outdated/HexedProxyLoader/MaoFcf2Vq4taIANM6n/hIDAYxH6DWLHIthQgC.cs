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
	// Token: 0x02000013 RID: 19
	internal class hIDAYxH6DWLHIthQgC
	{
		// Token: 0x0600011E RID: 286 RVA: 0x00009A18 File Offset: 0x00007C18
		static hIDAYxH6DWLHIthQgC()
		{
			hIDAYxH6DWLHIthQgC.e1I76Dk1A = false;
			hIDAYxH6DWLHIthQgC.FmWIypaNX = null;
			hIDAYxH6DWLHIthQgC.CC86JSicc = new object();
			hIDAYxH6DWLHIthQgC.mLdMA9iPk = Type.GetTypeFromHandle(f1stFPxcHMQ5yL3IBf.H8ta5L4cdA(33554451)).Assembly;
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

		// Token: 0x0600011F RID: 287 RVA: 0x00009AD4 File Offset: 0x00007CD4
		internal hIDAYxH6DWLHIthQgC()
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00009AE4 File Offset: 0x00007CE4
		private void An1agbTJuA()
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00009AF0 File Offset: 0x00007CF0
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

		// Token: 0x06000122 RID: 290 RVA: 0x0000A15C File Offset: 0x0000835C
		private static void DLH2IthQg(ref uint \u0020, uint \u0020, uint \u0020, uint \u0020, uint \u0020, ushort \u0020, uint \u0020, object \u0020)
		{
			\u0020 += hIDAYxH6DWLHIthQgC.qHMTQ5yL3(\u0020 + ((\u0020 & \u0020) | (~\u0020 & \u0020)) + \u0020[(int)\u0020] + hIDAYxH6DWLHIthQgC.SrDpPJg0d[(int)(\u0020 - 1U)], \u0020);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000A18C File Offset: 0x0000838C
		private static void T1axoFcfV(ref uint \u0020, uint \u0020, uint \u0020, uint \u0020, uint \u0020, ushort \u0020, uint \u0020, object \u0020)
		{
			\u0020 += hIDAYxH6DWLHIthQgC.qHMTQ5yL3(\u0020 + ((\u0020 & \u0020) | (\u0020 & ~\u0020)) + \u0020[(int)\u0020] + hIDAYxH6DWLHIthQgC.SrDpPJg0d[(int)(\u0020 - 1U)], \u0020);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000A1BC File Offset: 0x000083BC
		private static void d4tqaIANM(ref uint \u0020, uint \u0020, uint \u0020, uint \u0020, uint \u0020, ushort \u0020, uint \u0020, object \u0020)
		{
			\u0020 += hIDAYxH6DWLHIthQgC.qHMTQ5yL3(\u0020 + (\u0020 ^ \u0020 ^ \u0020) + \u0020[(int)\u0020] + hIDAYxH6DWLHIthQgC.SrDpPJg0d[(int)(\u0020 - 1U)], \u0020);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000A1EC File Offset: 0x000083EC
		private static void LnTa1stFP(ref uint \u0020, uint \u0020, uint \u0020, uint \u0020, uint \u0020, ushort \u0020, uint \u0020, object \u0020)
		{
			\u0020 += hIDAYxH6DWLHIthQgC.qHMTQ5yL3(\u0020 + (\u0020 ^ (\u0020 | ~\u0020)) + \u0020[(int)\u0020] + hIDAYxH6DWLHIthQgC.SrDpPJg0d[(int)(\u0020 - 1U)], \u0020);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000A21C File Offset: 0x0000841C
		private static uint qHMTQ5yL3(uint \u0020, ushort \u0020)
		{
			return \u0020 >> (int)(32 - \u0020) | \u0020 << (int)\u0020;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000A238 File Offset: 0x00008438
		internal static byte[] KBfNgPHJl(object \u0020)
		{
			if (!hIDAYxH6DWLHIthQgC.BVBfH8LsP())
			{
				return new MD5CryptoServiceProvider().ComputeHash(\u0020);
			}
			return hIDAYxH6DWLHIthQgC.hIDHAYx6D(\u0020);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000A260 File Offset: 0x00008460
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

		// Token: 0x06000129 RID: 297 RVA: 0x0000A290 File Offset: 0x00008490
		internal static bool BVBfH8LsP()
		{
			if (!hIDAYxH6DWLHIthQgC.CPGmeecTL)
			{
				hIDAYxH6DWLHIthQgC.ATI5Y1kI0();
				hIDAYxH6DWLHIthQgC.CPGmeecTL = true;
			}
			return hIDAYxH6DWLHIthQgC.e1I76Dk1A;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000A2B4 File Offset: 0x000084B4
		internal byte[] Xf3RuiTPT()
		{
			int length = "{11111-22222-40001-00001}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000A2D8 File Offset: 0x000084D8
		internal byte[] caelxLNP2()
		{
			int length = "{11111-22222-40001-00002}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000A2FC File Offset: 0x000084FC
		internal byte[] JmTEkpCbj()
		{
			int length = "{11111-22222-50001-00001}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000A320 File Offset: 0x00008520
		internal byte[] EkggYQXiI()
		{
			int length = "{11111-22222-50001-00002}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000A344 File Offset: 0x00008544
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
						BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(f1stFPxcHMQ5yL3IBf.H8ta5L4cdA(33554451)).Assembly.GetManifestResourceStream("mg3W402gOcv2DQlsjK.iTpbuLnfiDGDDlABw1"));
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
								uint num11 = 1948796382U;
								uint num12 = 2095159776U;
								uint num13 = 396135920U;
								uint num14 = 967670151U;
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
					MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(f1stFPxcHMQ5yL3IBf.H8ta5L4cdA(33554451)).Module.ResolveMethod(num22, typeFromHandle.GetGenericArguments(), new Type[0]);
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
							array3[0] = Type.GetTypeFromHandle(f1stFPxcHMQ5yL3IBf.H8ta5L4cdA(16777233));
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

		// Token: 0x0600012F RID: 303 RVA: 0x0000AA00 File Offset: 0x00008C00
		internal static void oDuBOTgYK()
		{
			if (Debugger.IsAttached)
			{
				throw new Exception("Debugger Detected");
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000AA20 File Offset: 0x00008C20
		private static int gG68OgEs5()
		{
			return 5;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000AA2C File Offset: 0x00008C2C
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

		// Token: 0x06000132 RID: 306 RVA: 0x0000AA84 File Offset: 0x00008C84
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

		// Token: 0x06000133 RID: 307 RVA: 0x0000AAD8 File Offset: 0x00008CD8
		private byte[] hVec8LoPP()
		{
			return null;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000AAF0 File Offset: 0x00008CF0
		private byte[] aKRZE6Th1()
		{
			return null;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000AB08 File Offset: 0x00008D08
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

		// Token: 0x06000136 RID: 310 RVA: 0x0000AB54 File Offset: 0x00008D54
		internal static void LKsFIQxCl(object \u0020, object \u0020, int \u0020, int \u0020)
		{
			\u0020.TransformBlock(\u0020, \u0020, \u0020, \u0020, \u0020);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000AB6C File Offset: 0x00008D6C
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

		// Token: 0x06000138 RID: 312 RVA: 0x0000ABDC File Offset: 0x00008DDC
		internal static void zSLipEDdx()
		{
			int num = 9;
			for (;;)
			{
				int num2 = num;
				HashAlgorithm hashAlgorithm;
				for (;;)
				{
					string text2;
					bool flag2;
					switch (num2)
					{
					case 0:
						goto IL_A5;
					case 1:
						break;
					case 2:
						goto IL_1FEC;
					case 3:
						goto IL_1FFF;
					case 4:
						goto IL_1F82;
					case 5:
						hIDAYxH6DWLHIthQgC.dJ60ZwGG7 = new RSACryptoServiceProvider();
						num2 = 11;
						continue;
					case 6:
						goto IL_1761;
					case 7:
						goto IL_201E;
					case 8:
						goto IL_1864;
					case 9:
						if (hIDAYxH6DWLHIthQgC.dJ60ZwGG7 == null)
						{
							goto IL_1FD7;
						}
						num2 = 8;
						if (!hIDAYxH6DWLHIthQgC.r8jJTum9TGM0tTLFQC())
						{
							num2 = 5;
							continue;
						}
						continue;
					case 10:
					{
						string text = null;
						num2 = 20;
						continue;
					}
					case 11:
						text2 = hIDAYxH6DWLHIthQgC.NpfUZeC95pGqfqUimc(hIDAYxH6DWLHIthQgC.VYHwFctxYWkEPS04D0(typeof(hIDAYxH6DWLHIthQgC).TypeHandle).Assembly);
						num2 = 17;
						continue;
					case 12:
						return;
					case 13:
						return;
					case 14:
						goto IL_182E;
					case 15:
						goto IL_1898;
					case 16:
						goto IL_1FCC;
					case 17:
						if (text2 != null)
						{
							goto IL_1F82;
						}
						num2 = 2;
						if (!hIDAYxH6DWLHIthQgC.r8jJTum9TGM0tTLFQC())
						{
							num2 = 1;
							continue;
						}
						continue;
					case 18:
						try
						{
							FileStream fileStream = new FileStream(text2, FileMode.Open, FileAccess.Read, FileShare.Read);
							int num3 = 41;
							for (;;)
							{
								long num4;
								long num5;
								uint num6;
								BinaryReader binaryReader;
								int num9;
								long num10;
								long num8;
								uint num11;
								uint num15;
								uint num16;
								int num17;
								int num18;
								switch (num3)
								{
								case 0:
									goto IL_1E00;
								case 1:
									if (num4 < num5)
									{
										num3 = 31;
										continue;
									}
									goto IL_19ED;
								case 2:
									hIDAYxH6DWLHIthQgC.L0rqa20VYpc9GK7O2H(fileStream, (long)((ulong)(num6 + 32U)));
									num3 = 4;
									continue;
								case 3:
									goto IL_1F20;
								case 4:
								{
									uint u = hIDAYxH6DWLHIthQgC.MgERBKdsaOOG8WTHqp(binaryReader);
									uint num7 = hIDAYxH6DWLHIthQgC.MgERBKdsaOOG8WTHqp(binaryReader);
									num8 = (long)((ulong)hIDAYxH6DWLHIthQgC.T6lbtXjRa1yi5muQEU(u, num9, num10, binaryReader));
									num3 = 36;
									continue;
								}
								case 5:
									goto IL_1D0E;
								case 6:
									goto IL_1A65;
								case 7:
								{
									FileStream fileStream2 = fileStream;
									hIDAYxH6DWLHIthQgC.L0rqa20VYpc9GK7O2H(fileStream2, hIDAYxH6DWLHIthQgC.c2SZqcwVhBFUtysUpM(fileStream2) + (long)((ulong)num11));
									num3 = 38;
									continue;
								}
								case 8:
									goto IL_1AAF;
								case 9:
								{
									bool flag = hIDAYxH6DWLHIthQgC.iuKdoHWxbbIXFapNgt(binaryReader) != 523;
									int num12 = flag ? 96 : 112;
									hIDAYxH6DWLHIthQgC.L0rqa20VYpc9GK7O2H(fileStream, 152L);
									byte[] array;
									hIDAYxH6DWLHIthQgC.lmRLDheiFm0rD0C3VN(fileStream, array, 0, num12);
									array[64] = 0;
									array[65] = 0;
									array[66] = 0;
									array[67] = 0;
									hIDAYxH6DWLHIthQgC.bxIbBCEcEAyYkvvjoj(hashAlgorithm, array, 0, num12);
									hIDAYxH6DWLHIthQgC.lmRLDheiFm0rD0C3VN(fileStream, array, 0, 128);
									array[32] = 0;
									array[33] = 0;
									array[34] = 0;
									array[35] = 0;
									array[36] = 0;
									array[37] = 0;
									array[38] = 0;
									array[39] = 0;
									hIDAYxH6DWLHIthQgC.bxIbBCEcEAyYkvvjoj(hashAlgorithm, array, 0, 128);
									num10 = hIDAYxH6DWLHIthQgC.c2SZqcwVhBFUtysUpM(fileStream);
									hIDAYxH6DWLHIthQgC.L0rqa20VYpc9GK7O2H(fileStream, 134L);
									num9 = (int)hIDAYxH6DWLHIthQgC.iuKdoHWxbbIXFapNgt(binaryReader);
									hIDAYxH6DWLHIthQgC.L0rqa20VYpc9GK7O2H(fileStream, num10);
									hIDAYxH6DWLHIthQgC.qwhyE0iGckDYUPTHyC(hashAlgorithm, fileStream, (uint)(num9 * 40), array);
									long num13 = hIDAYxH6DWLHIthQgC.c2SZqcwVhBFUtysUpM(fileStream);
									if (flag)
									{
										num3 = 27;
										continue;
									}
									goto IL_1A85;
								}
								case 10:
								{
									uint num14;
									hIDAYxH6DWLHIthQgC.L0rqa20VYpc9GK7O2H(fileStream, (long)((ulong)num14));
									num3 = 28;
									if (hIDAYxH6DWLHIthQgC.kkNY1ORi659cIDZVxr() == null)
									{
										num3 = 30;
										continue;
									}
									continue;
								}
								case 11:
									goto IL_1CD1;
								case 12:
									num15 = hIDAYxH6DWLHIthQgC.MgERBKdsaOOG8WTHqp(binaryReader);
									num3 = 25;
									continue;
								case 13:
									if (num8 > num4)
									{
										goto IL_19ED;
									}
									num3 = 1;
									if (hIDAYxH6DWLHIthQgC.kkNY1ORi659cIDZVxr() != null)
									{
										num3 = 1;
										continue;
									}
									continue;
								case 14:
								{
									byte[] array;
									hIDAYxH6DWLHIthQgC.qwhyE0iGckDYUPTHyC(hashAlgorithm, fileStream, 152U, array);
									num3 = 9;
									continue;
								}
								case 15:
									goto IL_1B24;
								case 16:
									goto IL_1A65;
								case 17:
								{
									byte[] array2;
									Array.Reverse<byte>(array2);
									num3 = 26;
									if (!hIDAYxH6DWLHIthQgC.r8jJTum9TGM0tTLFQC())
									{
										num3 = 10;
										continue;
									}
									continue;
								}
								case 18:
								{
									byte[] array = new byte[65536];
									num3 = 14;
									continue;
								}
								case 19:
									goto IL_1A85;
								case 20:
									goto IL_1CD1;
								case 21:
									goto IL_1DA9;
								case 22:
									goto IL_1DA9;
								case 23:
								{
									byte[] array;
									hIDAYxH6DWLHIthQgC.qwhyE0iGckDYUPTHyC(hashAlgorithm, fileStream, num16, array);
									num17 = 34;
									break;
								}
								case 24:
								{
									byte[] array;
									hIDAYxH6DWLHIthQgC.qwhyE0iGckDYUPTHyC(hashAlgorithm, fileStream, num15, array);
									num3 = 7;
									if (hIDAYxH6DWLHIthQgC.kkNY1ORi659cIDZVxr() == null)
									{
										num3 = 16;
										continue;
									}
									continue;
								}
								case 25:
								{
									uint num14 = hIDAYxH6DWLHIthQgC.MgERBKdsaOOG8WTHqp(binaryReader);
									num3 = 10;
									continue;
								}
								case 26:
								{
									string text;
									byte[] array2;
									flag2 = !hIDAYxH6DWLHIthQgC.hTZ0VC6mtC3qP2EyR9(hIDAYxH6DWLHIthQgC.dJ60ZwGG7, hIDAYxH6DWLHIthQgC.KoYgyZo9r4YjyuWZD7(hashAlgorithm), text, array2);
									num3 = 1;
									if (hIDAYxH6DWLHIthQgC.kkNY1ORi659cIDZVxr() == null)
									{
										num3 = 3;
										continue;
									}
									continue;
								}
								case 27:
									hIDAYxH6DWLHIthQgC.L0rqa20VYpc9GK7O2H(fileStream, 360L);
									num17 = 11;
									break;
								case 28:
								{
									long num13;
									hIDAYxH6DWLHIthQgC.L0rqa20VYpc9GK7O2H(fileStream, num13);
									num3 = 42;
									continue;
								}
								case 29:
									hIDAYxH6DWLHIthQgC.L0rqa20VYpc9GK7O2H(fileStream, num8);
									num3 = 39;
									continue;
								case 30:
									goto IL_1BE0;
								case 31:
									num11 = (uint)(num5 - num4);
									num17 = 40;
									break;
								case 32:
									goto IL_1D0E;
								case 33:
									goto IL_1B3E;
								case 34:
									num15 -= num16;
									num3 = 35;
									continue;
								case 35:
									goto IL_1BE0;
								case 36:
								{
									uint num7;
									num5 = num8 + (long)((ulong)num7);
									num3 = 28;
									continue;
								}
								case 37:
									goto IL_19ED;
								case 38:
									goto IL_1BE0;
								case 39:
								{
									uint num7;
									byte[] array2 = hIDAYxH6DWLHIthQgC.EmVKmKNBPU5RfnDKFR(binaryReader, (int)num7);
									num3 = 7;
									if (hIDAYxH6DWLHIthQgC.kkNY1ORi659cIDZVxr() == null)
									{
										num3 = 17;
										continue;
									}
									continue;
								}
								case 40:
									if (num11 >= num15)
									{
										goto IL_1A65;
									}
									num3 = 0;
									if (hIDAYxH6DWLHIthQgC.kkNY1ORi659cIDZVxr() != null)
									{
										num3 = 0;
										continue;
									}
									continue;
								case 41:
									binaryReader = new BinaryReader(fileStream);
									num3 = 18;
									if (!hIDAYxH6DWLHIthQgC.r8jJTum9TGM0tTLFQC())
									{
										num3 = 1;
										continue;
									}
									continue;
								case 42:
									num18 = 0;
									num3 = 5;
									continue;
								default:
									goto IL_1E00;
								}
								IL_1933:
								num3 = num17;
								continue;
								IL_19ED:
								if (num4 < num5)
								{
									goto IL_1AAF;
								}
								num3 = 24;
								if (hIDAYxH6DWLHIthQgC.r8jJTum9TGM0tTLFQC())
								{
									num3 = 24;
									continue;
								}
								continue;
								IL_1A65:
								num18++;
								num3 = 12;
								if (hIDAYxH6DWLHIthQgC.r8jJTum9TGM0tTLFQC())
								{
									num3 = 32;
									continue;
								}
								continue;
								IL_1A85:
								hIDAYxH6DWLHIthQgC.L0rqa20VYpc9GK7O2H(fileStream, 376L);
								num3 = 20;
								continue;
								IL_1AAF:
								num16 = (uint)hIDAYxH6DWLHIthQgC.y4MCD31CSTcMATNOrV(num8 - num4, (long)((ulong)num15));
								num3 = 23;
								continue;
								IL_1B24:
								hIDAYxH6DWLHIthQgC.wX4dc7bWxXhR1PKSe7(hashAlgorithm, new byte[0], 0, 0);
								num3 = 29;
								continue;
								IL_1D0E:
								if (num18 < num9)
								{
									num3 = 21;
									continue;
								}
								goto IL_1B24;
								IL_1B3E:
								num4 = hIDAYxH6DWLHIthQgC.c2SZqcwVhBFUtysUpM(fileStream);
								num3 = 13;
								continue;
								IL_1BE0:
								if (num15 > 0U)
								{
									goto IL_1B3E;
								}
								num3 = 6;
								if (!hIDAYxH6DWLHIthQgC.r8jJTum9TGM0tTLFQC())
								{
									num3 = 1;
									continue;
								}
								continue;
								IL_1CD1:
								num6 = hIDAYxH6DWLHIthQgC.T6lbtXjRa1yi5muQEU(hIDAYxH6DWLHIthQgC.MgERBKdsaOOG8WTHqp(binaryReader), num9, num10, binaryReader);
								num3 = 2;
								if (hIDAYxH6DWLHIthQgC.kkNY1ORi659cIDZVxr() == null)
								{
									num3 = 2;
									continue;
								}
								continue;
								IL_1E00:
								num15 -= num11;
								num3 = 7;
								if (!hIDAYxH6DWLHIthQgC.r8jJTum9TGM0tTLFQC())
								{
									num3 = 6;
									continue;
								}
								continue;
								IL_1DA9:
								hIDAYxH6DWLHIthQgC.L0rqa20VYpc9GK7O2H(fileStream, num10 + (long)(num18 * 40) + 16L);
								num17 = 12;
								goto IL_1933;
							}
							IL_1F20:
							goto IL_1FCC;
						}
						catch
						{
							int num19 = 1;
							if (hIDAYxH6DWLHIthQgC.kkNY1ORi659cIDZVxr() == null)
							{
								num19 = 1;
							}
							for (;;)
							{
								switch (num19)
								{
								case 1:
									flag2 = true;
									num19 = 0;
									if (hIDAYxH6DWLHIthQgC.kkNY1ORi659cIDZVxr() == null)
									{
										num19 = 0;
										continue;
									}
									continue;
								}
								break;
							}
							goto IL_1FCC;
						}
						goto IL_1F82;
					case 19:
					{
						BinaryReader binaryReader = null;
						num2 = 1;
						if (hIDAYxH6DWLHIthQgC.kkNY1ORi659cIDZVxr() == null)
						{
							num2 = 18;
							continue;
						}
						continue;
					}
					case 20:
						goto IL_1662;
					case 21:
						goto IL_1FD7;
					default:
						goto IL_A5;
					}
					IL_1883:
					if (flag2)
					{
						break;
					}
					flag2 = false;
					num2 = 12;
					continue;
					IL_201E:
					if (!flag2)
					{
						num2 = 19;
						continue;
					}
					goto IL_1883;
					IL_A5:
					try
					{
						hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG vPkSh3s7U1vEqJ6ZwG = new hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG(hIDAYxH6DWLHIthQgC.A7lGwSVI42UrSgcQIc(hIDAYxH6DWLHIthQgC.mLdMA9iPk, "KrM0TaKrYN0MryrwxS.7Lkd2ugikaLt1H4NpM"));
						hIDAYxH6DWLHIthQgC.L0rqa20VYpc9GK7O2H(hIDAYxH6DWLHIthQgC.ytdt5mDP44bHw6lrQC(vPkSh3s7U1vEqJ6ZwG), 0L);
						byte[] array3 = hIDAYxH6DWLHIthQgC.RdXDmDUN6x4Nf1iJI0(vPkSh3s7U1vEqJ6ZwG, (int)hIDAYxH6DWLHIthQgC.hNYooEsJukYuLLjBMf(hIDAYxH6DWLHIthQgC.ytdt5mDP44bHw6lrQC(vPkSh3s7U1vEqJ6ZwG)));
						byte[] array4 = new byte[32];
						array4[0] = 221 - 73;
						array4[0] = 107 + 41;
						array4[0] = 250 - 83;
						array4[0] = 123 + 34;
						array4[0] = 232 + 3;
						array4[1] = 103 + 102;
						array4[1] = 75 + 14;
						array4[1] = 99 - 13;
						array4[2] = 117 + 109;
						int num20 = 236 - 78;
						array4[2] = (byte)num20;
						array4[2] = 13 + 14;
						num20 = 242 - 80;
						array4[2] = (byte)num20;
						array4[2] = 116 - 110;
						num20 = 95 + 25;
						array4[3] = (byte)num20;
						int num21 = 27 + 60;
						array4[3] = (byte)num21;
						array4[3] = 144 - 117;
						array4[4] = 13 + 119;
						array4[4] = 61 + 60;
						array4[4] = 174 - 58;
						num21 = 164 - 54;
						array4[4] = (byte)num21;
						num20 = 53 + 86;
						array4[4] = (byte)num20;
						array4[5] = 77 + 7;
						array4[5] = 91 + 61;
						num20 = 54 + 12;
						array4[5] = (byte)num20;
						array4[5] = 136 + 39;
						num20 = 244 - 81;
						array4[6] = (byte)num20;
						num21 = 82 + 17;
						array4[6] = (byte)num21;
						num20 = 95 + 54;
						array4[6] = (byte)num20;
						array4[7] = 65 + 41;
						array4[7] = 87 + 60;
						array4[7] = 200 - 66;
						array4[7] = 128 - 42;
						num21 = 149 + 14;
						array4[7] = (byte)num21;
						array4[8] = 12 + 100;
						num21 = 124 + 61;
						array4[8] = (byte)num21;
						array4[8] = 18 + 64;
						num20 = 106 + 64;
						array4[8] = (byte)num20;
						num20 = 232 - 77;
						array4[9] = (byte)num20;
						array4[9] = 98 + 3;
						num20 = 249 - 83;
						array4[9] = (byte)num20;
						num21 = 124 + 66;
						array4[9] = (byte)num21;
						num21 = 105 - 54;
						array4[9] = (byte)num21;
						array4[10] = 32 + 2;
						array4[10] = 201 - 67;
						array4[10] = 13 + 76;
						num21 = 109 + 94;
						array4[10] = (byte)num21;
						num20 = 175 - 58;
						array4[11] = (byte)num20;
						num21 = 159 - 53;
						array4[11] = (byte)num21;
						array4[11] = 202 - 123;
						num21 = 65 + 93;
						array4[12] = (byte)num21;
						num20 = 36 + 78;
						array4[12] = (byte)num20;
						num21 = 194 - 64;
						array4[12] = (byte)num21;
						num21 = 94 + 30;
						array4[12] = (byte)num21;
						array4[12] = 43 + 31;
						array4[12] = 148 + 99;
						num21 = 124 + 82;
						array4[13] = (byte)num21;
						num21 = 185 - 61;
						array4[13] = (byte)num21;
						num21 = 72 - 58;
						array4[13] = (byte)num21;
						num21 = 170 - 56;
						array4[14] = (byte)num21;
						array4[14] = 99 + 15;
						num21 = 64 + 6;
						array4[14] = (byte)num21;
						num20 = 174 - 58;
						array4[14] = (byte)num20;
						num20 = 110 + 65;
						array4[14] = (byte)num20;
						num21 = 62 - 34;
						array4[14] = (byte)num21;
						num21 = 223 - 74;
						array4[15] = (byte)num21;
						array4[15] = 156 - 52;
						num21 = 51 + 84;
						array4[15] = (byte)num21;
						array4[15] = 40 + 117;
						num20 = 95 + 87;
						array4[16] = (byte)num20;
						num20 = 78 + 53;
						array4[16] = (byte)num20;
						array4[16] = 57 + 21;
						array4[16] = 141 - 88;
						num21 = 43 + 82;
						array4[17] = (byte)num21;
						num21 = 99 + 27;
						array4[17] = (byte)num21;
						array4[17] = 224 + 19;
						array4[18] = 67 + 102;
						num20 = 113 + 72;
						array4[18] = (byte)num20;
						num21 = 111 + 115;
						array4[18] = (byte)num21;
						array4[18] = 81 + 68;
						num21 = 119 + 53;
						array4[19] = (byte)num21;
						num21 = 83 + 21;
						array4[19] = (byte)num21;
						array4[19] = 88 + 98;
						num21 = 171 - 57;
						array4[19] = (byte)num21;
						num20 = 4 + 90;
						array4[19] = (byte)num20;
						num20 = 66 + 60;
						array4[19] = (byte)num20;
						array4[20] = 245 - 81;
						num20 = 74 + 90;
						array4[20] = (byte)num20;
						array4[20] = 42 + 115;
						num21 = 149 - 49;
						array4[21] = (byte)num21;
						array4[21] = 154 - 51;
						array4[21] = 144 - 48;
						num21 = 2 + 116;
						array4[21] = (byte)num21;
						num21 = 85 + 118;
						array4[21] = (byte)num21;
						array4[22] = 139 - 46;
						array4[22] = 52 + 45;
						num21 = 231 - 77;
						array4[22] = (byte)num21;
						num20 = 126 + 42;
						array4[22] = (byte)num20;
						array4[23] = 24 + 32;
						num21 = 74 + 49;
						array4[23] = (byte)num21;
						array4[23] = 179 - 59;
						array4[23] = 224 - 74;
						array4[23] = 130 + 111;
						array4[24] = 203 - 67;
						num21 = 4 + 124;
						array4[24] = (byte)num21;
						array4[24] = 132 - 44;
						array4[24] = 70 + 9;
						array4[24] = 118 + 34;
						array4[24] = 76 + 95;
						array4[25] = 225 - 75;
						array4[25] = 229 - 76;
						num20 = 216 - 72;
						array4[25] = (byte)num20;
						num21 = 59 - 38;
						array4[25] = (byte)num21;
						array4[26] = 120 + 113;
						num20 = 211 - 70;
						array4[26] = (byte)num20;
						num21 = 139 - 46;
						array4[26] = (byte)num21;
						num21 = 10 + 34;
						array4[26] = (byte)num21;
						array4[26] = 171 + 72;
						array4[27] = 48 + 35;
						num20 = 1 + 12;
						array4[27] = (byte)num20;
						num20 = 135 - 45;
						array4[27] = (byte)num20;
						num21 = 39 - 28;
						array4[27] = (byte)num21;
						num20 = 69 + 51;
						array4[28] = (byte)num20;
						array4[28] = 96 + 38;
						array4[28] = 50 + 64;
						num21 = 228 + 3;
						array4[28] = (byte)num21;
						num20 = 44 + 94;
						array4[29] = (byte)num20;
						array4[29] = 219 - 73;
						array4[29] = 55 + 22;
						array4[29] = 58 + 36;
						array4[29] = 124 - 40;
						num21 = 18 + 123;
						array4[30] = (byte)num21;
						array4[30] = 234 - 78;
						array4[30] = 92 + 90;
						array4[30] = 152 - 108;
						array4[31] = 46 + 103;
						num21 = 198 - 66;
						array4[31] = (byte)num21;
						array4[31] = 13 + 32;
						num21 = 197 - 77;
						array4[31] = (byte)num21;
						byte[] array5 = array4;
						byte[] array6 = new byte[16];
						array6[0] = 92 + 27;
						int num22 = 41 + 40;
						array6[0] = (byte)num22;
						array6[0] = 254 - 84;
						array6[0] = 34 + 3;
						int num23 = 232 - 77;
						array6[0] = (byte)num23;
						num22 = 156 + 65;
						array6[0] = (byte)num22;
						array6[1] = 14 + 13;
						array6[1] = 117 + 109;
						num23 = 236 - 78;
						array6[1] = (byte)num23;
						array6[1] = 138 - 46;
						num23 = 152 - 50;
						array6[1] = (byte)num23;
						array6[1] = 126 + 113;
						num22 = 18 + 95;
						array6[2] = (byte)num22;
						num23 = 73 + 27;
						array6[2] = (byte)num23;
						array6[2] = 247 - 82;
						array6[2] = 139 - 46;
						num22 = 92 + 61;
						array6[2] = (byte)num22;
						array6[2] = 174 - 60;
						num22 = 174 - 58;
						array6[3] = (byte)num22;
						array6[3] = 37 + 46;
						num22 = 45 + 77;
						array6[3] = (byte)num22;
						array6[3] = 253 - 84;
						array6[3] = 189 - 63;
						array6[3] = 70 - 27;
						array6[4] = 12 + 39;
						array6[4] = 244 - 81;
						array6[4] = 82 + 17;
						array6[4] = 181 - 60;
						num22 = 65 + 41;
						array6[4] = (byte)num22;
						array6[4] = 150 + 69;
						array6[5] = 60 + 92;
						num22 = 30 + 3;
						array6[5] = (byte)num22;
						array6[5] = 139 - 46;
						array6[5] = 93 + 51;
						num23 = 229 - 76;
						array6[6] = (byte)num23;
						num22 = 254 - 84;
						array6[6] = (byte)num22;
						array6[6] = 11 + 18;
						num22 = 126 - 42;
						array6[6] = (byte)num22;
						num22 = 210 + 7;
						array6[6] = (byte)num22;
						num22 = 143 - 47;
						array6[7] = (byte)num22;
						num22 = 3 + 4;
						array6[7] = (byte)num22;
						num22 = 229 - 76;
						array6[7] = (byte)num22;
						num22 = 101 - 66;
						array6[7] = (byte)num22;
						array6[8] = 54 + 97;
						num23 = 2 + 22;
						array6[8] = (byte)num23;
						num22 = 93 - 75;
						array6[8] = (byte)num22;
						num23 = 204 - 68;
						array6[9] = (byte)num23;
						array6[9] = 223 - 74;
						num23 = 121 + 48;
						array6[9] = (byte)num23;
						array6[10] = 32 + 123;
						array6[10] = 65 + 93;
						num23 = 36 + 78;
						array6[10] = (byte)num23;
						array6[10] = 101 + 67;
						num22 = 227 - 75;
						array6[11] = (byte)num22;
						array6[11] = 30 + 14;
						num23 = 31 + 99;
						array6[11] = (byte)num23;
						num22 = 117 + 124;
						array6[11] = (byte)num22;
						num22 = 72 + 58;
						array6[12] = (byte)num22;
						num22 = 185 - 61;
						array6[12] = (byte)num22;
						num22 = 43 + 57;
						array6[12] = (byte)num22;
						num22 = 15 + 121;
						array6[12] = (byte)num22;
						array6[12] = 147 + 64;
						array6[13] = 57 + 47;
						array6[13] = 240 - 80;
						num22 = 156 - 75;
						array6[13] = (byte)num22;
						array6[14] = 77 + 94;
						num23 = 30 + 76;
						array6[14] = (byte)num23;
						array6[14] = 185 + 51;
						array6[15] = 247 - 82;
						array6[15] = 224 - 74;
						num22 = 47 + 78;
						array6[15] = (byte)num22;
						array6[15] = 78 - 53;
						byte[] array7 = array6;
						object obj = hIDAYxH6DWLHIthQgC.a17UpFBrITpKPcBXpa();
						hIDAYxH6DWLHIthQgC.CrSiMRMSxrZQFQsk0p(obj, CipherMode.CBC);
						ICryptoTransform transform = hIDAYxH6DWLHIthQgC.r2AZF4LbBH8yPcJbfY(obj, array5, array7);
						Stream stream = hIDAYxH6DWLHIthQgC.Ah0NILIr1AHsKbPeWm();
						CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
						hIDAYxH6DWLHIthQgC.rCAXCc4Uy6YKref0ue(cryptoStream, array3, 0, array3.Length);
						hIDAYxH6DWLHIthQgC.DjNBZ7yk729h9SJnUh(cryptoStream);
						hIDAYxH6DWLHIthQgC.mQ6YLEALtjW2DMJWRI(hIDAYxH6DWLHIthQgC.dJ60ZwGG7, hIDAYxH6DWLHIthQgC.zcs5CVvrxZ1BhWKdyR(hIDAYxH6DWLHIthQgC.zYdFjvJDOVbi5Seu2N(), hIDAYxH6DWLHIthQgC.CNDe30f20ZVk1bPjyb(stream)));
						hIDAYxH6DWLHIthQgC.FStBHyXXPMa2aDBZi6(stream);
						hIDAYxH6DWLHIthQgC.FStBHyXXPMa2aDBZi6(cryptoStream);
						hIDAYxH6DWLHIthQgC.TwqX2E32bjsvSCVvkc(vPkSh3s7U1vEqJ6ZwG);
						int num24 = 0;
						if (!hIDAYxH6DWLHIthQgC.r8jJTum9TGM0tTLFQC())
						{
							num24 = 0;
						}
						switch (num24)
						{
						default:
							goto IL_201E;
						}
					}
					catch
					{
						int num25 = 1;
						if (hIDAYxH6DWLHIthQgC.kkNY1ORi659cIDZVxr() == null)
						{
							num25 = 1;
						}
						for (;;)
						{
							switch (num25)
							{
							case 1:
								flag2 = true;
								num25 = 0;
								if (!hIDAYxH6DWLHIthQgC.r8jJTum9TGM0tTLFQC())
								{
									num25 = 0;
									continue;
								}
								continue;
							}
							break;
						}
						goto IL_201E;
					}
					goto IL_1662;
					IL_1761:
					try
					{
						BinaryReader binaryReader;
						if (binaryReader != null)
						{
							goto IL_17BC;
						}
						int num26 = 2;
						if (hIDAYxH6DWLHIthQgC.kkNY1ORi659cIDZVxr() != null)
						{
							num26 = 0;
						}
						IL_1787:
						switch (num26)
						{
						case 0:
							goto IL_17BC;
						case 1:
							break;
						case 2:
							break;
						default:
							goto IL_17BC;
						}
						goto IL_1883;
						IL_17BC:
						hIDAYxH6DWLHIthQgC.RLt5XTrKyTCcZ2H5g6(binaryReader);
						num26 = 1;
						if (hIDAYxH6DWLHIthQgC.kkNY1ORi659cIDZVxr() != null)
						{
							num26 = 0;
							goto IL_1787;
						}
						goto IL_1787;
					}
					catch
					{
						int num27 = 0;
						if (!hIDAYxH6DWLHIthQgC.r8jJTum9TGM0tTLFQC())
						{
							num27 = 0;
						}
						switch (num27)
						{
						default:
							goto IL_1883;
						}
					}
					goto IL_182E;
					IL_1662:
					try
					{
						hashAlgorithm = hIDAYxH6DWLHIthQgC.dgrvRuOauuVt0qYkmB();
						int num28 = 2;
						if (hIDAYxH6DWLHIthQgC.kkNY1ORi659cIDZVxr() != null)
						{
							num28 = 2;
						}
						for (;;)
						{
							switch (num28)
							{
							case 2:
							{
								string text = hIDAYxH6DWLHIthQgC.SPrVHhpJDia6MFc7v0("SHA1");
								num28 = 3;
								continue;
							}
							case 3:
								if (!hIDAYxH6DWLHIthQgC.MOvbA8qr0HFvaXdWTc(text2))
								{
									goto IL_16BC;
								}
								num28 = 0;
								if (hIDAYxH6DWLHIthQgC.kkNY1ORi659cIDZVxr() != null)
								{
									num28 = 0;
									continue;
								}
								continue;
							case 4:
								goto IL_16BC;
							}
							break;
						}
						goto IL_1701;
						IL_16BC:
						return;
						IL_1701:
						goto IL_1898;
					}
					catch
					{
						int num29 = 0;
						if (!hIDAYxH6DWLHIthQgC.r8jJTum9TGM0tTLFQC())
						{
							num29 = 0;
						}
						switch (num29)
						{
						default:
							return;
						}
					}
					goto IL_1761;
					IL_1898:
					flag2 = false;
					num2 = 0;
					if (hIDAYxH6DWLHIthQgC.kkNY1ORi659cIDZVxr() == null)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_1F82:
					if (hIDAYxH6DWLHIthQgC.xg8pY4hHb4fPkv9iUl(text2) == 0)
					{
						return;
					}
					num2 = 3;
					if (!hIDAYxH6DWLHIthQgC.r8jJTum9TGM0tTLFQC())
					{
						num2 = 2;
						continue;
					}
					continue;
					IL_1FCC:
					num2 = 6;
				}
				num = 14;
				continue;
				IL_1FD7:
				hIDAYxH6DWLHIthQgC.mpDgARTOI1adQylLnV(true);
				num = 5;
				continue;
				IL_1FFF:
				hashAlgorithm = null;
				num = 10;
			}
			IL_182E:
			throw new Exception(hIDAYxH6DWLHIthQgC.efAbe188mcrvOyJng70(hIDAYxH6DWLHIthQgC.Dpv9QF87iXa5ZSPk8wD(hIDAYxH6DWLHIthQgC.yXYue3zHKC3dIIIkhB(hIDAYxH6DWLHIthQgC.VYHwFctxYWkEPS04D0(typeof(hIDAYxH6DWLHIthQgC).TypeHandle).Assembly)), " is tampered."));
			IL_1864:
			return;
			IL_1FEC:;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000CC7C File Offset: 0x0000AE7C
		private static Stream GOV9AYHwR()
		{
			return new MemoryStream();
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000CC8C File Offset: 0x0000AE8C
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

		// Token: 0x0600013B RID: 315 RVA: 0x0000CD00 File Offset: 0x0000AF00
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

		// Token: 0x0600013C RID: 316 RVA: 0x0000CE30 File Offset: 0x0000B030
		private static byte[] dcJwyWJ2h(object \u0020)
		{
			return ((MemoryStream)\u0020).ToArray();
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000CE44 File Offset: 0x0000B044
		internal byte[] OZvj2rN0e()
		{
			int length = "{11111-22222-30001-00001}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000CE68 File Offset: 0x0000B068
		internal byte[] tPnkNfto2()
		{
			int length = "{11111-22222-30001-00002}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000CE8C File Offset: 0x0000B08C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void BAASgSTaW(object \u0020)
		{
			NeFPnNYfto2SAAgSTa.XoaHyBJbad(0, new object[]
			{
				\u0020
			}, null);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000CEC4 File Offset: 0x0000B0C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string gSCeTtiku(int \u0020)
		{
			if (hIDAYxH6DWLHIthQgC.RVsUi7vv8.Length == 0)
			{
				hIDAYxH6DWLHIthQgC.ReW45iIw5 = new List<string>();
				hIDAYxH6DWLHIthQgC.asMnx1K5s = new List<int>();
				hIDAYxH6DWLHIthQgC.BAASgSTaW(Type.GetTypeFromHandle(f1stFPxcHMQ5yL3IBf.H8ta5L4cdA(33554451)).GetTypeInfo().Assembly.GetManifestResourceStream("sbTGcb8P0ylW4MTOLJ.PkGA3GkJyQCrG0TCd7"));
				nHwRpygmi6xxZAssJn.JvcaFtwnsV();
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

		// Token: 0x06000141 RID: 321 RVA: 0x0000D0C4 File Offset: 0x0000B2C4
		private hIDAYxH6DWLHIthQgC(byte[] \u0020, byte[] \u0020)
		{
			this.EG7tVH7R7 = \u0020;
			this.OnMCBfq5Q = \u0020;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000D0E4 File Offset: 0x0000B2E4
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

		// Token: 0x06000143 RID: 323 RVA: 0x0000D2D0 File Offset: 0x0000B4D0
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

		// Token: 0x06000144 RID: 324 RVA: 0x0000D3B4 File Offset: 0x0000B5B4
		internal static string PdFXUg04j(object \u0020)
		{
			"{11111-22222-50001-00000}".Trim();
			byte[] array = Convert.FromBase64String(\u0020);
			return Encoding.Unicode.GetString(array, 0, array.Length);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000D3EC File Offset: 0x0000B5EC
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

		// Token: 0x06000146 RID: 326 RVA: 0x0000D424 File Offset: 0x0000B624
		private byte[] htFdmQ9eP()
		{
			return null;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000D43C File Offset: 0x0000B63C
		private byte[] dbXPZLbLV()
		{
			return null;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000D454 File Offset: 0x0000B654
		internal static object dMVNbePSf9waEos50i(object A_0)
		{
			return A_0.BaseStream;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000D468 File Offset: 0x0000B668
		internal static void uRpj8yGeHyfKMgK2Mj(object A_0, long A_1)
		{
			A_0.Position = A_1;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000D480 File Offset: 0x0000B680
		internal static long IW0AZQu45TrhGmSJLm(object A_0)
		{
			return A_0.Length;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000D494 File Offset: 0x0000B694
		internal static object MRdHw5xkNkmYGTPbid(object A_0, int A_1)
		{
			return A_0.ReadBytes(A_1);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000D4AC File Offset: 0x0000B6AC
		internal static object kHnYX2SoAkhWPIpHFW(object A_0)
		{
			return A_0.EntryPoint;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000D4C0 File Offset: 0x0000B6C0
		internal static bool Y6mXsxYn6jTVZ3qOLm(object A_0, object A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000D4D8 File Offset: 0x0000B6D8
		internal static void wMncGQaUEmH10i8IRc(object A_0)
		{
			((IDisposable)A_0).Dispose();
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000D4EC File Offset: 0x0000B6EC
		internal static bool vyhx769Im58W1HpvUB()
		{
			return null == null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000D4FC File Offset: 0x0000B6FC
		internal static object DKq6ckcXFibk3WuwwR()
		{
			return null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000D508 File Offset: 0x0000B708
		internal static void mpDgARTOI1adQylLnV(bool A_0)
		{
			RSACryptoServiceProvider.UseMachineKeyStore = A_0;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000D51C File Offset: 0x0000B71C
		internal static Type VYHwFctxYWkEPS04D0(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000D530 File Offset: 0x0000B730
		internal static object NpfUZeC95pGqfqUimc(object A_0)
		{
			return A_0.Location;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000D544 File Offset: 0x0000B744
		internal static int xg8pY4hHb4fPkv9iUl(object A_0)
		{
			return A_0.Length;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000D558 File Offset: 0x0000B758
		internal static object dgrvRuOauuVt0qYkmB()
		{
			return SHA1.Create();
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000D568 File Offset: 0x0000B768
		internal static object SPrVHhpJDia6MFc7v0(object A_0)
		{
			return CryptoConfig.MapNameToOID(A_0);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000D57C File Offset: 0x0000B77C
		internal static bool MOvbA8qr0HFvaXdWTc(object A_0)
		{
			return File.Exists(A_0);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000D590 File Offset: 0x0000B790
		internal static object A7lGwSVI42UrSgcQIc(object A_0, object A_1)
		{
			return A_0.GetManifestResourceStream(A_1);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		internal static object ytdt5mDP44bHw6lrQC(object A_0)
		{
			return A_0.AsxqrFX3HQ();
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000D5BC File Offset: 0x0000B7BC
		internal static void L0rqa20VYpc9GK7O2H(object A_0, long A_1)
		{
			A_0.Position = A_1;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000D5D4 File Offset: 0x0000B7D4
		internal static long hNYooEsJukYuLLjBMf(object A_0)
		{
			return A_0.Length;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000D5E8 File Offset: 0x0000B7E8
		internal static object RdXDmDUN6x4Nf1iJI0(object A_0, int \u0020)
		{
			return A_0.C9UqM3M0Ll(\u0020);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000D600 File Offset: 0x0000B800
		internal static object a17UpFBrITpKPcBXpa()
		{
			return hIDAYxH6DWLHIthQgC.LtAJclWeT();
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000D610 File Offset: 0x0000B810
		internal static void CrSiMRMSxrZQFQsk0p(object A_0, CipherMode A_1)
		{
			A_0.Mode = A_1;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000D628 File Offset: 0x0000B828
		internal static object r2AZF4LbBH8yPcJbfY(object A_0, object A_1, object A_2)
		{
			return A_0.CreateDecryptor(A_1, A_2);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000D644 File Offset: 0x0000B844
		internal static object Ah0NILIr1AHsKbPeWm()
		{
			return hIDAYxH6DWLHIthQgC.GOV9AYHwR();
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000D654 File Offset: 0x0000B854
		internal static void rCAXCc4Uy6YKref0ue(object A_0, object A_1, int A_2, int A_3)
		{
			A_0.Write(A_1, A_2, A_3);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000D674 File Offset: 0x0000B874
		internal static void DjNBZ7yk729h9SJnUh(object A_0)
		{
			A_0.FlushFinalBlock();
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000D688 File Offset: 0x0000B888
		internal static object zYdFjvJDOVbi5Seu2N()
		{
			return Encoding.UTF8;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000D698 File Offset: 0x0000B898
		internal static object CNDe30f20ZVk1bPjyb(object A_0)
		{
			return hIDAYxH6DWLHIthQgC.dcJwyWJ2h(A_0);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000D6AC File Offset: 0x0000B8AC
		internal static object zcs5CVvrxZ1BhWKdyR(object A_0, object A_1)
		{
			return A_0.GetString(A_1);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000D6C4 File Offset: 0x0000B8C4
		internal static void mQ6YLEALtjW2DMJWRI(object A_0, object A_1)
		{
			A_0.FromXmlString(A_1);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000D6DC File Offset: 0x0000B8DC
		internal static void FStBHyXXPMa2aDBZi6(object A_0)
		{
			A_0.Close();
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000D6F0 File Offset: 0x0000B8F0
		internal static void TwqX2E32bjsvSCVvkc(object A_0)
		{
			A_0.bFiqUko1xE();
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000D704 File Offset: 0x0000B904
		internal static void qwhyE0iGckDYUPTHyC(object A_0, object A_1, uint \u0020, object A_3)
		{
			hIDAYxH6DWLHIthQgC.EZdsFxqyB(A_0, A_1, \u0020, A_3);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000D724 File Offset: 0x0000B924
		internal static ushort iuKdoHWxbbIXFapNgt(object A_0)
		{
			return A_0.ReadUInt16();
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000D738 File Offset: 0x0000B938
		internal static int lmRLDheiFm0rD0C3VN(object A_0, object A_1, int A_2, int A_3)
		{
			return A_0.Read(A_1, A_2, A_3);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000D758 File Offset: 0x0000B958
		internal static void bxIbBCEcEAyYkvvjoj(object A_0, object A_1, int \u0020, int \u0020)
		{
			hIDAYxH6DWLHIthQgC.LKsFIQxCl(A_0, A_1, \u0020, \u0020);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000D778 File Offset: 0x0000B978
		internal static long c2SZqcwVhBFUtysUpM(object A_0)
		{
			return A_0.Position;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000D78C File Offset: 0x0000B98C
		internal static uint MgERBKdsaOOG8WTHqp(object A_0)
		{
			return A_0.ReadUInt32();
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000D7A0 File Offset: 0x0000B9A0
		internal static uint T6lbtXjRa1yi5muQEU(uint \u0020, int \u0020, long \u0020, object A_3)
		{
			return hIDAYxH6DWLHIthQgC.mf83VSwim(\u0020, \u0020, \u0020, A_3);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000D7C0 File Offset: 0x0000B9C0
		internal static long y4MCD31CSTcMATNOrV(long A_0, long A_1)
		{
			return Math.Min(A_0, A_1);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000D7D8 File Offset: 0x0000B9D8
		internal static object wX4dc7bWxXhR1PKSe7(object A_0, object A_1, int A_2, int A_3)
		{
			return A_0.TransformFinalBlock(A_1, A_2, A_3);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000D7F8 File Offset: 0x0000B9F8
		internal static object EmVKmKNBPU5RfnDKFR(object A_0, int A_1)
		{
			return A_0.ReadBytes(A_1);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000D810 File Offset: 0x0000BA10
		internal static object KoYgyZo9r4YjyuWZD7(object A_0)
		{
			return A_0.Hash;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000D824 File Offset: 0x0000BA24
		internal static bool hTZ0VC6mtC3qP2EyR9(object A_0, object A_1, object A_2, object A_3)
		{
			return A_0.VerifyHash(A_1, A_2, A_3);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000D844 File Offset: 0x0000BA44
		internal static void RLt5XTrKyTCcZ2H5g6(object A_0)
		{
			A_0.Close();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000D858 File Offset: 0x0000BA58
		internal static object yXYue3zHKC3dIIIkhB(object A_0)
		{
			return A_0.GetName();
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000D86C File Offset: 0x0000BA6C
		internal static object Dpv9QF87iXa5ZSPk8wD(object A_0)
		{
			return A_0.Name;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000D880 File Offset: 0x0000BA80
		internal static object efAbe188mcrvOyJng70(object A_0, object A_1)
		{
			return A_0 + A_1;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000D898 File Offset: 0x0000BA98
		internal static bool r8jJTum9TGM0tTLFQC()
		{
			return null == null;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
		internal static object kkNY1ORi659cIDZVxr()
		{
			return null;
		}

		// Token: 0x0400004B RID: 75
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

		// Token: 0x0400004C RID: 76
		private static object iGWr5uXHi;

		// Token: 0x0400004D RID: 77
		private static object CC86JSicc;

		// Token: 0x0400004E RID: 78
		private object OnMCBfq5Q;

		// Token: 0x0400004F RID: 79
		private static List<string> ReW45iIw5;

		// Token: 0x04000050 RID: 80
		private static bool e1I76Dk1A;

		// Token: 0x04000051 RID: 81
		private static int HDHKHhTXP;

		// Token: 0x04000052 RID: 82
		private static bool CPGmeecTL = false;

		// Token: 0x04000053 RID: 83
		private static object RVsUi7vv8;

		// Token: 0x04000054 RID: 84
		private static object mLdMA9iPk;

		// Token: 0x04000055 RID: 85
		private static List<int> asMnx1K5s;

		// Token: 0x04000056 RID: 86
		private static Dictionary<int, int> FmWIypaNX;

		// Token: 0x04000057 RID: 87
		private object EG7tVH7R7;

		// Token: 0x04000058 RID: 88
		private static object Bh317U1vE;

		// Token: 0x04000059 RID: 89
		private static object dJ60ZwGG7;

		// Token: 0x02000014 RID: 20
		internal class vPkSh3s7U1vEqJ6ZwG
		{
			// Token: 0x0600017B RID: 379 RVA: 0x0000D8B4 File Offset: 0x0000BAB4
			public vPkSh3s7U1vEqJ6ZwG(Stream \u0020)
			{
				this.TXSqn39pP3 = new BinaryReader(\u0020);
			}

			// Token: 0x0600017C RID: 380 RVA: 0x0000D8D0 File Offset: 0x0000BAD0
			internal Stream AsxqrFX3HQ()
			{
				return hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG.nN1tXTlKRgtNbofFiPt(this.TXSqn39pP3);
			}

			// Token: 0x0600017D RID: 381 RVA: 0x0000D8E4 File Offset: 0x0000BAE4
			internal byte[] C9UqM3M0Ll(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG.eOpjewlg164swAbE8bM(this.TXSqn39pP3, \u0020);
			}

			// Token: 0x0600017E RID: 382 RVA: 0x0000D8FC File Offset: 0x0000BAFC
			internal int N4Hq1iEYPX(byte[] \u0020, int \u0020, int \u0020)
			{
				return this.TXSqn39pP3.Read(\u0020, \u0020, \u0020);
			}

			// Token: 0x0600017F RID: 383 RVA: 0x0000D914 File Offset: 0x0000BB14
			internal int c73q0LArlF()
			{
				return hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG.UNad7Xl5qF8rLndoWhd(this.TXSqn39pP3);
			}

			// Token: 0x06000180 RID: 384 RVA: 0x0000D928 File Offset: 0x0000BB28
			internal void bFiqUko1xE()
			{
				hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG.TcPJGBlZs93QQoFFLuK(this.TXSqn39pP3);
			}

			// Token: 0x06000181 RID: 385 RVA: 0x0000D93C File Offset: 0x0000BB3C
			internal static object nN1tXTlKRgtNbofFiPt(object A_0)
			{
				return A_0.BaseStream;
			}

			// Token: 0x06000182 RID: 386 RVA: 0x0000D950 File Offset: 0x0000BB50
			internal static object eOpjewlg164swAbE8bM(object A_0, int A_1)
			{
				return A_0.ReadBytes(A_1);
			}

			// Token: 0x06000183 RID: 387 RVA: 0x0000D968 File Offset: 0x0000BB68
			internal static int UNad7Xl5qF8rLndoWhd(object A_0)
			{
				return A_0.ReadInt32();
			}

			// Token: 0x06000184 RID: 388 RVA: 0x0000D97C File Offset: 0x0000BB7C
			internal static void TcPJGBlZs93QQoFFLuK(object A_0)
			{
				A_0.Close();
			}

			// Token: 0x0400005A RID: 90
			private object TXSqn39pP3;
		}

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000186 RID: 390
		private delegate void W7KVsiF7vv8RGW5uXH(object o);

		// Token: 0x02000016 RID: 22
		internal class uneW5i3Iw5OsMx1K5s
		{
			// Token: 0x06000189 RID: 393 RVA: 0x0000D990 File Offset: 0x0000BB90
			internal static string Hh1qKiqeMC(object \u0020, object \u0020)
			{
				byte[] array = hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.iCB7mRl90HtkcwWFX2G(hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.w3X2SolnUY1c8BgBm09(), \u0020);
				byte[] array2 = new byte[32];
				hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.RhEeiTlc5HJ7Uus5ImA(array2, fieldof(<PrivateImplementationDetails>{7A2069A1-6943-47FD-BFF5-CABAD37D5B42}.C356AFF1A01C2B0DA472E584C8E3C8F875B9A24280435D42836A77B19F5A8C18).FieldHandle);
				byte[] key = array2;
				byte[] array3 = hIDAYxH6DWLHIthQgC.KBfNgPHJl(hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.iCB7mRl90HtkcwWFX2G(hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.w3X2SolnUY1c8BgBm09(), \u0020));
				MemoryStream memoryStream = new MemoryStream();
				SymmetricAlgorithm symmetricAlgorithm = hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.eZq4uYlPBRa26fbqOqD();
				symmetricAlgorithm.Key = key;
				hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.ACiAmdlGj819tZ1RkeS(symmetricAlgorithm, array3);
				CryptoStream cryptoStream = new CryptoStream(memoryStream, hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.EievXHluu52SkbWys2W(symmetricAlgorithm), CryptoStreamMode.Write);
				hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.hRilqklxVbtxdoKGrsM(cryptoStream, array, 0, array.Length);
				hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.Imo0AIlSQZYmOB4r272(cryptoStream);
				return hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.UkTsCmla39cWx7kDYt6(hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.atIrjUlY1BLxWa3GLAM(memoryStream));
			}

			// Token: 0x0600018B RID: 395 RVA: 0x0000DA24 File Offset: 0x0000BC24
			internal static object w3X2SolnUY1c8BgBm09()
			{
				return Encoding.Unicode;
			}

			// Token: 0x0600018C RID: 396 RVA: 0x0000DA34 File Offset: 0x0000BC34
			internal static object iCB7mRl90HtkcwWFX2G(object A_0, object A_1)
			{
				return A_0.GetBytes(A_1);
			}

			// Token: 0x0600018D RID: 397 RVA: 0x0000DA4C File Offset: 0x0000BC4C
			internal static void RhEeiTlc5HJ7Uus5ImA(object A_0, RuntimeFieldHandle A_1)
			{
				RuntimeHelpers.InitializeArray(A_0, A_1);
			}

			// Token: 0x0600018E RID: 398 RVA: 0x0000DA64 File Offset: 0x0000BC64
			internal static object eZq4uYlPBRa26fbqOqD()
			{
				return hIDAYxH6DWLHIthQgC.LtAJclWeT();
			}

			// Token: 0x0600018F RID: 399 RVA: 0x0000DA74 File Offset: 0x0000BC74
			internal static void ACiAmdlGj819tZ1RkeS(object A_0, object A_1)
			{
				A_0.IV = A_1;
			}

			// Token: 0x06000190 RID: 400 RVA: 0x0000DA8C File Offset: 0x0000BC8C
			internal static object EievXHluu52SkbWys2W(object A_0)
			{
				return A_0.CreateEncryptor();
			}

			// Token: 0x06000191 RID: 401 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
			internal static void hRilqklxVbtxdoKGrsM(object A_0, object A_1, int A_2, int A_3)
			{
				A_0.Write(A_1, A_2, A_3);
			}

			// Token: 0x06000192 RID: 402 RVA: 0x0000DAC0 File Offset: 0x0000BCC0
			internal static void Imo0AIlSQZYmOB4r272(object A_0)
			{
				A_0.Close();
			}

			// Token: 0x06000193 RID: 403 RVA: 0x0000DAD4 File Offset: 0x0000BCD4
			internal static object atIrjUlY1BLxWa3GLAM(object A_0)
			{
				return A_0.ToArray();
			}

			// Token: 0x06000194 RID: 404 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
			internal static object UkTsCmla39cWx7kDYt6(object A_0)
			{
				return Convert.ToBase64String(A_0);
			}
		}
	}
}
