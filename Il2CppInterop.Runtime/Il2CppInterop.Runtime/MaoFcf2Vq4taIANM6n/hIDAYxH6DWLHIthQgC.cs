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
	// Token: 0x02000135 RID: 309
	internal class hIDAYxH6DWLHIthQgC
	{
		// Token: 0x06000D75 RID: 3445 RVA: 0x000289C0 File Offset: 0x00026BC0
		static hIDAYxH6DWLHIthQgC()
		{
			hIDAYxH6DWLHIthQgC.e1I76Dk1A = false;
			hIDAYxH6DWLHIthQgC.FmWIypaNX = null;
			hIDAYxH6DWLHIthQgC.CC86JSicc = new object();
			hIDAYxH6DWLHIthQgC.mLdMA9iPk = Type.GetTypeFromHandle(f1stFPxcHMQ5yL3IBf.BaJEy92N0v(33554741)).Assembly;
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

		// Token: 0x06000D76 RID: 3446 RVA: 0x00028A7C File Offset: 0x00026C7C
		internal hIDAYxH6DWLHIthQgC()
		{
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00028A8C File Offset: 0x00026C8C
		private void LlfE6kN1Ao()
		{
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00028A98 File Offset: 0x00026C98
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

		// Token: 0x06000D79 RID: 3449 RVA: 0x00029104 File Offset: 0x00027304
		private static void DLH2IthQg(ref uint \u0020, uint \u0020, uint \u0020, uint \u0020, uint \u0020, ushort \u0020, uint \u0020, object \u0020)
		{
			\u0020 += hIDAYxH6DWLHIthQgC.qHMTQ5yL3(\u0020 + ((\u0020 & \u0020) | (~\u0020 & \u0020)) + \u0020[(int)\u0020] + hIDAYxH6DWLHIthQgC.SrDpPJg0d[(int)(\u0020 - 1U)], \u0020);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00029134 File Offset: 0x00027334
		private static void T1axoFcfV(ref uint \u0020, uint \u0020, uint \u0020, uint \u0020, uint \u0020, ushort \u0020, uint \u0020, object \u0020)
		{
			\u0020 += hIDAYxH6DWLHIthQgC.qHMTQ5yL3(\u0020 + ((\u0020 & \u0020) | (\u0020 & ~\u0020)) + \u0020[(int)\u0020] + hIDAYxH6DWLHIthQgC.SrDpPJg0d[(int)(\u0020 - 1U)], \u0020);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00029164 File Offset: 0x00027364
		private static void d4tqaIANM(ref uint \u0020, uint \u0020, uint \u0020, uint \u0020, uint \u0020, ushort \u0020, uint \u0020, object \u0020)
		{
			\u0020 += hIDAYxH6DWLHIthQgC.qHMTQ5yL3(\u0020 + (\u0020 ^ \u0020 ^ \u0020) + \u0020[(int)\u0020] + hIDAYxH6DWLHIthQgC.SrDpPJg0d[(int)(\u0020 - 1U)], \u0020);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00029194 File Offset: 0x00027394
		private static void LnTa1stFP(ref uint \u0020, uint \u0020, uint \u0020, uint \u0020, uint \u0020, ushort \u0020, uint \u0020, object \u0020)
		{
			\u0020 += hIDAYxH6DWLHIthQgC.qHMTQ5yL3(\u0020 + (\u0020 ^ (\u0020 | ~\u0020)) + \u0020[(int)\u0020] + hIDAYxH6DWLHIthQgC.SrDpPJg0d[(int)(\u0020 - 1U)], \u0020);
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x000291C4 File Offset: 0x000273C4
		private static uint qHMTQ5yL3(uint \u0020, ushort \u0020)
		{
			return \u0020 >> (int)(32 - \u0020) | \u0020 << (int)\u0020;
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x000291E0 File Offset: 0x000273E0
		internal static byte[] KBfNgPHJl(object \u0020)
		{
			if (!hIDAYxH6DWLHIthQgC.BVBfH8LsP())
			{
				return new MD5CryptoServiceProvider().ComputeHash(\u0020);
			}
			return hIDAYxH6DWLHIthQgC.hIDHAYx6D(\u0020);
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00029208 File Offset: 0x00027408
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

		// Token: 0x06000D80 RID: 3456 RVA: 0x00029238 File Offset: 0x00027438
		internal static bool BVBfH8LsP()
		{
			if (!hIDAYxH6DWLHIthQgC.CPGmeecTL)
			{
				hIDAYxH6DWLHIthQgC.ATI5Y1kI0();
				hIDAYxH6DWLHIthQgC.CPGmeecTL = true;
			}
			return hIDAYxH6DWLHIthQgC.e1I76Dk1A;
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0002925C File Offset: 0x0002745C
		internal byte[] Xf3RuiTPT()
		{
			int length = "{11111-22222-40001-00001}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00029280 File Offset: 0x00027480
		internal byte[] caelxLNP2()
		{
			int length = "{11111-22222-40001-00002}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x000292A4 File Offset: 0x000274A4
		internal byte[] JmTEkpCbj()
		{
			int length = "{11111-22222-50001-00001}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x000292C8 File Offset: 0x000274C8
		internal byte[] EkggYQXiI()
		{
			int length = "{11111-22222-50001-00002}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x000292EC File Offset: 0x000274EC
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
						BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(f1stFPxcHMQ5yL3IBf.BaJEy92N0v(33554741)).Assembly.GetManifestResourceStream("5RvZdYOqvOGXbr6Zua.UVUlnWt06Tu15Lob9t"));
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
								uint num11 = 1546570532U;
								uint num12 = num10;
								uint num13 = 792058017U;
								uint num14 = 2021339767U;
								uint num15 = 1349586219U;
								uint num16 = num14 & 16711935U;
								uint num17 = num14 & 4278255360U;
								num16 = ((num16 >> 8 | num17 << 8) ^ num12);
								num14 = (num14 << 6 | num14 >> 26);
								if (num13 == 0U)
								{
									num13 -= 1U;
								}
								uint num18 = num12 / num13 + num13;
								num13 = num12 + num12 + num18 + num12;
								num16 = (num11 & 16711935U);
								num17 = (num11 & 4278255360U);
								num16 = ((num16 >> 8 | num17 << 8) ^ num14);
								num11 = (num11 << 10 | num11 >> 22);
								num12 += num14;
								num13 = 8617075U * (num13 & 15U) + (num13 >> 4);
								num11 = 213132624U * (num11 & 15U) - (num11 >> 4);
								num14 = 4736U * num14 + num12;
								num12 ^= num12 >> 19;
								num12 += num11;
								num12 ^= num12 << 5;
								num12 += num12;
								num12 ^= num12 >> 1;
								num12 += num15;
								num12 = ((num11 << 21) - num12 ^ num12) + num12;
								num3 = num9 + (uint)num12;
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
					MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(f1stFPxcHMQ5yL3IBf.BaJEy92N0v(33554741)).Module.ResolveMethod(num22, typeFromHandle.GetGenericArguments(), new Type[0]);
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
							array3[0] = Type.GetTypeFromHandle(f1stFPxcHMQ5yL3IBf.BaJEy92N0v(16777234));
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

		// Token: 0x06000D86 RID: 3462 RVA: 0x000299AC File Offset: 0x00027BAC
		internal static void oDuBOTgYK()
		{
			if (Debugger.IsAttached)
			{
				throw new Exception("Debugger Detected");
			}
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x000299CC File Offset: 0x00027BCC
		private static int gG68OgEs5()
		{
			return 5;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x000299D8 File Offset: 0x00027BD8
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

		// Token: 0x06000D89 RID: 3465 RVA: 0x00029A30 File Offset: 0x00027C30
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

		// Token: 0x06000D8A RID: 3466 RVA: 0x00029A84 File Offset: 0x00027C84
		private byte[] hVec8LoPP()
		{
			return null;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00029A9C File Offset: 0x00027C9C
		private byte[] aKRZE6Th1()
		{
			return null;
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00029AB4 File Offset: 0x00027CB4
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

		// Token: 0x06000D8D RID: 3469 RVA: 0x00029B00 File Offset: 0x00027D00
		internal static void LKsFIQxCl(object \u0020, object \u0020, int \u0020, int \u0020)
		{
			\u0020.TransformBlock(\u0020, \u0020, \u0020, \u0020, \u0020);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00029B18 File Offset: 0x00027D18
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

		// Token: 0x06000D8F RID: 3471 RVA: 0x00029B88 File Offset: 0x00027D88
		internal static void zSLipEDdx()
		{
			int num = 9;
			for (;;)
			{
				int num2 = num;
				string text2;
				for (;;)
				{
					string text;
					HashAlgorithm hashAlgorithm;
					BinaryReader binaryReader;
					bool flag;
					switch (num2)
					{
					case 0:
						goto IL_1697;
					case 1:
						goto IL_1FD5;
					case 2:
						goto IL_186B;
					case 3:
						text = hIDAYxH6DWLHIthQgC.sJ7E1xSdD4y0hcVJGg(hIDAYxH6DWLHIthQgC.gbd0RGsLdCdYJ9obis(typeof(hIDAYxH6DWLHIthQgC).TypeHandle).Assembly);
						num2 = 16;
						continue;
					case 4:
						break;
					case 5:
						goto IL_187C;
					case 6:
						try
						{
							hashAlgorithm = hIDAYxH6DWLHIthQgC.daHTj4uS1VrRBPeZlY();
							int num3 = 1;
							if (!hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
							{
								num3 = 1;
							}
							for (;;)
							{
								switch (num3)
								{
								default:
									if (hIDAYxH6DWLHIthQgC.VY0BP7mtvYiG4ROk9v(text))
									{
										goto IL_182A;
									}
									num3 = 2;
									break;
								case 1:
									text2 = hIDAYxH6DWLHIthQgC.mCFbXIDOftEdcOmbxM("SHA1");
									num3 = 0;
									if (!hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
									{
										num3 = 0;
									}
									break;
								case 2:
									goto IL_1817;
								case 3:
									goto IL_182A;
								}
							}
							IL_1817:
							return;
							IL_182A:
							goto IL_16CD;
						}
						catch
						{
							int num4 = 0;
							if (hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
							{
								num4 = 0;
							}
							switch (num4)
							{
							default:
								return;
							}
						}
						goto IL_186B;
					case 7:
						goto IL_1FE9;
					case 8:
						goto IL_18BE;
					case 9:
						goto IL_1787;
					case 10:
						try
						{
							FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
							int num5 = 7;
							for (;;)
							{
								long num6;
								uint num8;
								int num10;
								int num12;
								long num13;
								uint num14;
								uint num15;
								long num16;
								long num17;
								int num18;
								switch (num5)
								{
								case 0:
									goto IL_1AAD;
								case 1:
									goto IL_1D11;
								case 2:
									hIDAYxH6DWLHIthQgC.axt0ck4ZlK9v9IHYpl(fileStream, num6);
									num5 = 26;
									continue;
								case 3:
								{
									uint num7 = hIDAYxH6DWLHIthQgC.aYB2v9omYkvkhXtoum(binaryReader);
									num5 = 30;
									if (hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
									{
										num5 = 33;
										continue;
									}
									continue;
								}
								case 4:
									goto IL_1AF5;
								case 5:
								{
									byte[] array;
									hIDAYxH6DWLHIthQgC.pgJkNLBJLDCIyvhROl(hashAlgorithm, fileStream, num8, array);
									num5 = 0;
									if (hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
									{
										num5 = 1;
										continue;
									}
									continue;
								}
								case 6:
									goto IL_1C8D;
								case 7:
									binaryReader = new BinaryReader(fileStream);
									num5 = 36;
									continue;
								case 8:
								{
									uint num9;
									num8 -= num9;
									num5 = 11;
									continue;
								}
								case 9:
									goto IL_1AF5;
								case 10:
								{
									byte[] array2;
									flag = !hIDAYxH6DWLHIthQgC.GtLd9QaJk9eBIPyyFE(hIDAYxH6DWLHIthQgC.dJ60ZwGG7, hIDAYxH6DWLHIthQgC.rTSdaoKQJg9TSIjbr9(hashAlgorithm), text2, array2);
									num5 = 9;
									if (hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
									{
										num5 = 31;
										continue;
									}
									continue;
								}
								case 11:
								{
									FileStream fileStream2 = fileStream;
									uint num9;
									hIDAYxH6DWLHIthQgC.axt0ck4ZlK9v9IHYpl(fileStream2, hIDAYxH6DWLHIthQgC.Gk4lD1g0msxyGJtnHq(fileStream2) + (long)((ulong)num9));
									num5 = 4;
									continue;
								}
								case 12:
									hIDAYxH6DWLHIthQgC.RQ9EyXQGAVRZEDa98X(hashAlgorithm, new byte[0], 0, 0);
									num5 = 2;
									continue;
								case 13:
									num8 = hIDAYxH6DWLHIthQgC.aYB2v9omYkvkhXtoum(binaryReader);
									num10 = 3;
									break;
								case 14:
								{
									uint u = hIDAYxH6DWLHIthQgC.aYB2v9omYkvkhXtoum(binaryReader);
									uint num11 = hIDAYxH6DWLHIthQgC.aYB2v9omYkvkhXtoum(binaryReader);
									num6 = (long)((ulong)hIDAYxH6DWLHIthQgC.YBvsw8UX4gayR1YrvN(u, num12, num13, binaryReader));
									num5 = 12;
									if (hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
									{
										num5 = 32;
										continue;
									}
									continue;
								}
								case 15:
									goto IL_1C8D;
								case 16:
									goto IL_1A33;
								case 17:
									hIDAYxH6DWLHIthQgC.axt0ck4ZlK9v9IHYpl(fileStream, (long)((ulong)(num14 + 32U)));
									num5 = 14;
									continue;
								case 18:
									goto IL_1BD2;
								case 19:
								{
									byte[] array2;
									Array.Reverse<byte>(array2);
									num5 = 10;
									continue;
								}
								case 20:
									goto IL_1DD9;
								case 21:
								{
									byte[] array;
									hIDAYxH6DWLHIthQgC.pgJkNLBJLDCIyvhROl(hashAlgorithm, fileStream, num15, array);
									num5 = 35;
									continue;
								}
								case 22:
									goto IL_1E3D;
								case 23:
									goto IL_1A6C;
								case 24:
								{
									byte[] array;
									hIDAYxH6DWLHIthQgC.pgJkNLBJLDCIyvhROl(hashAlgorithm, fileStream, 152U, array);
									num5 = 42;
									continue;
								}
								case 25:
									goto IL_1A6C;
								case 26:
								{
									uint num11;
									byte[] array2 = hIDAYxH6DWLHIthQgC.DS6laFe0v28xFKkTTc(binaryReader, (int)num11);
									num5 = 8;
									if (hIDAYxH6DWLHIthQgC.UdSLgfVqHSFqUZRH6s() == null)
									{
										num5 = 19;
										continue;
									}
									continue;
								}
								case 27:
									if (num6 > num16)
									{
										goto IL_1E3D;
									}
									num5 = 39;
									if (hIDAYxH6DWLHIthQgC.UdSLgfVqHSFqUZRH6s() != null)
									{
										num5 = 17;
										continue;
									}
									continue;
								case 28:
									goto IL_1AAD;
								case 29:
								{
									uint num9 = (uint)(num17 - num16);
									num5 = 37;
									continue;
								}
								case 30:
									num18 = 0;
									num5 = 14;
									if (hIDAYxH6DWLHIthQgC.UdSLgfVqHSFqUZRH6s() == null)
									{
										num5 = 15;
										continue;
									}
									continue;
								case 31:
									goto IL_1F6F;
								case 32:
								{
									uint num11;
									num17 = num6 + (long)((ulong)num11);
									num5 = 18;
									if (hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
									{
										num5 = 41;
										continue;
									}
									continue;
								}
								case 33:
								{
									uint num7;
									hIDAYxH6DWLHIthQgC.axt0ck4ZlK9v9IHYpl(fileStream, (long)((ulong)num7));
									num5 = 3;
									if (hIDAYxH6DWLHIthQgC.UdSLgfVqHSFqUZRH6s() == null)
									{
										num5 = 40;
										continue;
									}
									continue;
								}
								case 34:
									goto IL_1D5B;
								case 35:
									num8 -= num15;
									num5 = 9;
									continue;
								case 36:
								{
									byte[] array = new byte[65536];
									num5 = 22;
									if (hIDAYxH6DWLHIthQgC.UdSLgfVqHSFqUZRH6s() == null)
									{
										num5 = 24;
										continue;
									}
									continue;
								}
								case 37:
								{
									uint num9;
									if (num9 >= num8)
									{
										goto IL_1D11;
									}
									num10 = 8;
									break;
								}
								case 38:
									goto IL_1DD9;
								case 39:
									if (num16 >= num17)
									{
										goto IL_1E3D;
									}
									num5 = 29;
									if (hIDAYxH6DWLHIthQgC.UdSLgfVqHSFqUZRH6s() != null)
									{
										num5 = 17;
										continue;
									}
									continue;
								case 40:
									goto IL_1AF5;
								case 41:
								{
									long num19;
									hIDAYxH6DWLHIthQgC.axt0ck4ZlK9v9IHYpl(fileStream, num19);
									num5 = 30;
									if (hIDAYxH6DWLHIthQgC.UdSLgfVqHSFqUZRH6s() != null)
									{
										num5 = 9;
										continue;
									}
									continue;
								}
								case 42:
								{
									bool flag2 = hIDAYxH6DWLHIthQgC.FUBUmsG90hqSA7rlkL(binaryReader) != 523;
									int num20 = flag2 ? 96 : 112;
									hIDAYxH6DWLHIthQgC.axt0ck4ZlK9v9IHYpl(fileStream, 152L);
									byte[] array;
									hIDAYxH6DWLHIthQgC.Ya9JVMrmd95Ew41pow(fileStream, array, 0, num20);
									array[64] = 0;
									array[65] = 0;
									array[66] = 0;
									array[67] = 0;
									hIDAYxH6DWLHIthQgC.HRaQOjTfgghFewIPxB(hashAlgorithm, array, 0, num20);
									hIDAYxH6DWLHIthQgC.Ya9JVMrmd95Ew41pow(fileStream, array, 0, 128);
									array[32] = 0;
									array[33] = 0;
									array[34] = 0;
									array[35] = 0;
									array[36] = 0;
									array[37] = 0;
									array[38] = 0;
									array[39] = 0;
									hIDAYxH6DWLHIthQgC.HRaQOjTfgghFewIPxB(hashAlgorithm, array, 0, 128);
									num13 = hIDAYxH6DWLHIthQgC.Gk4lD1g0msxyGJtnHq(fileStream);
									hIDAYxH6DWLHIthQgC.axt0ck4ZlK9v9IHYpl(fileStream, 134L);
									num12 = (int)hIDAYxH6DWLHIthQgC.FUBUmsG90hqSA7rlkL(binaryReader);
									hIDAYxH6DWLHIthQgC.axt0ck4ZlK9v9IHYpl(fileStream, num13);
									hIDAYxH6DWLHIthQgC.pgJkNLBJLDCIyvhROl(hashAlgorithm, fileStream, (uint)(num12 * 40), array);
									long num19 = hIDAYxH6DWLHIthQgC.Gk4lD1g0msxyGJtnHq(fileStream);
									if (flag2)
									{
										goto IL_1D5B;
									}
									num5 = 15;
									if (hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
									{
										num5 = 38;
										continue;
									}
									continue;
								}
								case 43:
									goto IL_1D11;
								default:
									goto IL_1AAD;
								}
								IL_191F:
								num5 = num10;
								continue;
								IL_1A33:
								num15 = (uint)hIDAYxH6DWLHIthQgC.q2dmIFjqwwXomZUqrp(num6 - num16, (long)((ulong)num8));
								num5 = 6;
								if (hIDAYxH6DWLHIthQgC.UdSLgfVqHSFqUZRH6s() == null)
								{
									num5 = 21;
									continue;
								}
								continue;
								IL_1E3D:
								if (num16 < num17)
								{
									goto IL_1A33;
								}
								num5 = 1;
								if (hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
								{
									num5 = 5;
									continue;
								}
								continue;
								IL_1A6C:
								num14 = hIDAYxH6DWLHIthQgC.YBvsw8UX4gayR1YrvN(hIDAYxH6DWLHIthQgC.aYB2v9omYkvkhXtoum(binaryReader), num12, num13, binaryReader);
								num5 = 17;
								continue;
								IL_1AAD:
								num16 = hIDAYxH6DWLHIthQgC.Gk4lD1g0msxyGJtnHq(fileStream);
								num5 = 26;
								if (hIDAYxH6DWLHIthQgC.UdSLgfVqHSFqUZRH6s() == null)
								{
									num5 = 27;
									continue;
								}
								continue;
								IL_1AF5:
								if (num8 > 0U)
								{
									num5 = 28;
									continue;
								}
								goto IL_1D11;
								IL_1BD2:
								hIDAYxH6DWLHIthQgC.axt0ck4ZlK9v9IHYpl(fileStream, num13 + (long)(num18 * 40) + 16L);
								num5 = 13;
								if (hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
								{
									num5 = 13;
									continue;
								}
								continue;
								IL_1C8D:
								if (num18 >= num12)
								{
									num5 = 12;
									continue;
								}
								goto IL_1BD2;
								IL_1D11:
								num18++;
								num5 = 6;
								continue;
								IL_1D5B:
								hIDAYxH6DWLHIthQgC.axt0ck4ZlK9v9IHYpl(fileStream, 360L);
								num10 = 23;
								goto IL_191F;
								IL_1DD9:
								hIDAYxH6DWLHIthQgC.axt0ck4ZlK9v9IHYpl(fileStream, 376L);
								num10 = 25;
								goto IL_191F;
							}
							IL_1F6F:
							goto IL_1FE9;
						}
						catch
						{
							int num21 = 1;
							if (!hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
							{
								num21 = 1;
							}
							for (;;)
							{
								switch (num21)
								{
								case 1:
									flag = true;
									num21 = 0;
									if (!hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
									{
										num21 = 0;
										continue;
									}
									continue;
								}
								break;
							}
							goto IL_1FE9;
						}
						goto IL_1FD5;
					case 11:
						goto IL_18DD;
					case 12:
						return;
					case 13:
						goto IL_16CD;
					case 14:
						goto IL_16B7;
					case 15:
						break;
					case 16:
						if (text != null)
						{
							goto IL_16B7;
						}
						num2 = 18;
						if (hIDAYxH6DWLHIthQgC.UdSLgfVqHSFqUZRH6s() != null)
						{
							num2 = 16;
							continue;
						}
						continue;
					case 17:
						try
						{
							if (binaryReader != null)
							{
								goto IL_1716;
							}
							int num22 = 1;
							if (!hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
							{
								num22 = 1;
							}
							IL_1700:
							switch (num22)
							{
							default:
								IL_1716:
								hIDAYxH6DWLHIthQgC.wqcDK3ZhyQPRxPkqw5(binaryReader);
								num22 = 2;
								goto IL_1700;
							case 1:
								break;
							case 2:
								break;
							}
							break;
						}
						catch
						{
							int num23 = 0;
							if (hIDAYxH6DWLHIthQgC.UdSLgfVqHSFqUZRH6s() == null)
							{
								num23 = 0;
							}
							switch (num23)
							{
							default:
								goto IL_189D;
							}
						}
						goto IL_1787;
					case 18:
						goto IL_18EA;
					case 19:
						return;
					case 20:
						try
						{
							hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG vPkSh3s7U1vEqJ6ZwG = new hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG(hIDAYxH6DWLHIthQgC.FTRy2Z7cbu7sjo9q2J(hIDAYxH6DWLHIthQgC.mLdMA9iPk, "vqg8mmXPf7jgxVIMU1.qNTvi8cfKt0gIRUqh7"));
							hIDAYxH6DWLHIthQgC.axt0ck4ZlK9v9IHYpl(hIDAYxH6DWLHIthQgC.IjDYigPXJ4dDm5ZeVo(vPkSh3s7U1vEqJ6ZwG), 0L);
							byte[] array3 = hIDAYxH6DWLHIthQgC.mduqxMfgNImGGgmjW9(vPkSh3s7U1vEqJ6ZwG, (int)hIDAYxH6DWLHIthQgC.Tfy7Vt3tsMY7GQQfRj(hIDAYxH6DWLHIthQgC.IjDYigPXJ4dDm5ZeVo(vPkSh3s7U1vEqJ6ZwG)));
							byte[] array4 = new byte[32];
							array4[0] = 92 + 26;
							int num24 = 41 + 30;
							array4[0] = (byte)num24;
							array4[0] = 75 + 123;
							int num25 = 129 - 43;
							array4[0] = (byte)num25;
							array4[0] = 109 + 72;
							array4[1] = 227 - 75;
							array4[1] = 157 - 52;
							num24 = 59 + 23;
							array4[1] = (byte)num24;
							num25 = 85 + 110;
							array4[1] = (byte)num25;
							array4[1] = 91 + 105;
							array4[1] = 136 + 96;
							array4[2] = 191 - 63;
							array4[2] = 120 + 68;
							num24 = 239 - 79;
							array4[2] = (byte)num24;
							num25 = 47 + 50;
							array4[2] = (byte)num25;
							array4[2] = 58 + 117;
							num25 = 143 - 47;
							array4[3] = (byte)num25;
							num25 = 139 - 46;
							array4[3] = (byte)num25;
							array4[3] = 196 - 86;
							num24 = 201 - 67;
							array4[4] = (byte)num24;
							num24 = 50 + 87;
							array4[4] = (byte)num24;
							array4[4] = 165 - 55;
							num24 = 121 + 69;
							array4[4] = (byte)num24;
							num24 = 53 + 63;
							array4[5] = (byte)num24;
							num24 = 16 + 53;
							array4[5] = (byte)num24;
							array4[5] = 67 + 16;
							array4[5] = 104 + 45;
							array4[5] = 163 - 78;
							array4[6] = 220 - 73;
							num25 = 254 - 84;
							array4[6] = (byte)num25;
							array4[6] = 88 - 52;
							num24 = 169 - 56;
							array4[7] = (byte)num24;
							array4[7] = 2 + 75;
							num25 = 72 + 97;
							array4[7] = (byte)num25;
							num24 = 217 - 72;
							array4[7] = (byte)num24;
							array4[7] = 128 - 42;
							num24 = 118 - 97;
							array4[7] = (byte)num24;
							num25 = 159 - 53;
							array4[8] = (byte)num25;
							array4[8] = 118 + 68;
							num25 = 56 - 35;
							array4[8] = (byte)num25;
							array4[9] = 183 - 61;
							num25 = 248 - 82;
							array4[9] = (byte)num25;
							num25 = 100 - 99;
							array4[9] = (byte)num25;
							num24 = 76 + 8;
							array4[10] = (byte)num24;
							array4[10] = 75 + 114;
							num25 = 43 - 2;
							array4[10] = (byte)num25;
							num24 = 243 - 81;
							array4[11] = (byte)num24;
							num25 = 68 + 60;
							array4[11] = (byte)num25;
							array4[11] = 189 - 88;
							num25 = 32 + 2;
							array4[12] = (byte)num25;
							num24 = 22 + 64;
							array4[12] = (byte)num24;
							array4[12] = 30 + 23;
							num25 = 98 - 93;
							array4[12] = (byte)num25;
							array4[13] = 214 - 71;
							num24 = 165 - 55;
							array4[13] = (byte)num24;
							array4[13] = 93 + 41;
							array4[13] = 60 + 23;
							num24 = 77 + 121;
							array4[13] = (byte)num24;
							array4[13] = 120 - 70;
							array4[14] = 184 - 61;
							array4[14] = 160 - 53;
							num24 = 49 - 11;
							array4[14] = (byte)num24;
							num25 = 122 + 64;
							array4[15] = (byte)num25;
							num25 = 134 - 44;
							array4[15] = (byte)num25;
							array4[15] = 131 - 108;
							num24 = 237 - 79;
							array4[16] = (byte)num24;
							array4[16] = 57 + 9;
							num24 = 165 - 55;
							array4[16] = (byte)num24;
							num24 = 231 - 77;
							array4[16] = (byte)num24;
							num24 = 14 + 19;
							array4[16] = (byte)num24;
							array4[16] = 66 - 55;
							num24 = 34 + 36;
							array4[17] = (byte)num24;
							array4[17] = 40 + 63;
							array4[17] = 82 + 56;
							array4[17] = 182 - 60;
							array4[17] = 168 - 56;
							array4[17] = 196 + 0;
							num25 = 101 + 108;
							array4[18] = (byte)num25;
							num24 = 216 - 72;
							array4[18] = (byte)num24;
							num24 = 208 - 69;
							array4[18] = (byte)num24;
							array4[18] = 210 - 70;
							array4[18] = 30 - 29;
							array4[19] = 142 - 47;
							num24 = 211 - 70;
							array4[19] = (byte)num24;
							array4[19] = 100 - 18;
							array4[20] = 85 + 5;
							array4[20] = 61 + 89;
							num25 = 94 + 9;
							array4[20] = (byte)num25;
							num25 = 240 - 80;
							array4[20] = (byte)num25;
							array4[20] = 80 + 97;
							array4[21] = 54 + 28;
							array4[21] = 101 + 79;
							num24 = 166 - 55;
							array4[21] = (byte)num24;
							array4[21] = 60 + 67;
							num25 = 172 - 57;
							array4[22] = (byte)num25;
							num25 = 173 - 57;
							array4[22] = (byte)num25;
							num25 = 158 - 52;
							array4[22] = (byte)num25;
							array4[22] = 112 + 104;
							num25 = 86 + 51;
							array4[22] = (byte)num25;
							array4[23] = 144 - 48;
							num24 = 204 - 68;
							array4[23] = (byte)num24;
							num24 = 146 - 98;
							array4[23] = (byte)num24;
							num24 = 18 + 105;
							array4[24] = (byte)num24;
							array4[24] = 250 - 83;
							array4[24] = 38 + 89;
							array4[24] = 206 - 68;
							array4[24] = 92 - 69;
							num24 = 30 + 57;
							array4[25] = (byte)num24;
							array4[25] = 120 + 70;
							num24 = 238 - 79;
							array4[25] = (byte)num24;
							array4[25] = 12 + 13;
							array4[25] = 200 - 66;
							num25 = 87 - 48;
							array4[25] = (byte)num25;
							num25 = 173 - 57;
							array4[26] = (byte)num25;
							num24 = 218 - 72;
							array4[26] = (byte)num24;
							num24 = 126 - 42;
							array4[26] = (byte)num24;
							array4[26] = 185 - 61;
							num25 = 242 - 80;
							array4[26] = (byte)num25;
							num25 = 217 + 13;
							array4[26] = (byte)num25;
							num24 = 50 + 44;
							array4[27] = (byte)num24;
							array4[27] = 37 + 60;
							array4[27] = 130 + 52;
							num24 = 108 + 86;
							array4[28] = (byte)num24;
							num25 = 91 + 42;
							array4[28] = (byte)num25;
							array4[28] = 80 + 123;
							array4[28] = 55 + 96;
							num24 = 164 - 107;
							array4[28] = (byte)num24;
							array4[29] = 10 + 27;
							array4[29] = 237 - 79;
							num25 = 229 - 76;
							array4[29] = (byte)num25;
							array4[29] = 91 - 55;
							num25 = 92 + 5;
							array4[30] = (byte)num25;
							num25 = 249 - 83;
							array4[30] = (byte)num25;
							array4[30] = 26 + 75;
							num24 = 62 + 57;
							array4[30] = (byte)num24;
							array4[30] = 154 - 51;
							num24 = 115 + 56;
							array4[30] = (byte)num24;
							array4[31] = 146 - 48;
							num24 = 233 - 77;
							array4[31] = (byte)num24;
							array4[31] = 124 - 63;
							byte[] array5 = array4;
							byte[] array6 = new byte[16];
							array6[0] = 89 + 30;
							int num26 = 45 + 52;
							array6[0] = (byte)num26;
							array6[0] = 210 - 70;
							array6[0] = 61 + 1;
							num26 = 142 - 47;
							array6[0] = (byte)num26;
							int num27 = 134 - 34;
							array6[0] = (byte)num27;
							num27 = 61 + 59;
							array6[1] = (byte)num27;
							array6[1] = 84 + 60;
							num26 = 137 - 45;
							array6[1] = (byte)num26;
							array6[1] = 234 - 78;
							num26 = 10 + 70;
							array6[1] = (byte)num26;
							array6[1] = 86 - 66;
							num27 = 136 - 45;
							array6[2] = (byte)num27;
							num26 = 129 - 43;
							array6[2] = (byte)num26;
							num27 = 18 + 113;
							array6[2] = (byte)num27;
							num26 = 160 - 53;
							array6[3] = (byte)num26;
							num26 = 46 + 81;
							array6[3] = (byte)num26;
							num27 = 137 - 45;
							array6[3] = (byte)num27;
							num27 = 136 + 92;
							array6[3] = (byte)num27;
							array6[4] = 0 + 93;
							array6[4] = 59 + 96;
							num27 = 129 - 14;
							array6[4] = (byte)num27;
							num27 = 61 + 36;
							array6[5] = (byte)num27;
							num26 = 3 + 51;
							array6[5] = (byte)num26;
							num27 = 142 - 29;
							array6[5] = (byte)num27;
							array6[6] = 12 + 18;
							array6[6] = 178 - 59;
							array6[6] = 140 - 110;
							num26 = 110 + 83;
							array6[7] = (byte)num26;
							num27 = 241 - 80;
							array6[7] = (byte)num27;
							num26 = 19 + 102;
							array6[7] = (byte)num26;
							num26 = 158 - 52;
							array6[7] = (byte)num26;
							num26 = 21 + 42;
							array6[7] = (byte)num26;
							num27 = 176 + 77;
							array6[7] = (byte)num27;
							array6[8] = 253 - 84;
							num26 = 108 + 44;
							array6[8] = (byte)num26;
							num26 = 149 - 118;
							array6[8] = (byte)num26;
							num27 = 16 + 88;
							array6[9] = (byte)num27;
							array6[9] = 121 + 95;
							num26 = 119 - 11;
							array6[9] = (byte)num26;
							num26 = 173 - 57;
							array6[10] = (byte)num26;
							array6[10] = 127 - 42;
							array6[10] = 180 - 60;
							num27 = 143 - 47;
							array6[10] = (byte)num27;
							num27 = 160 - 53;
							array6[10] = (byte)num27;
							num26 = 222 + 3;
							array6[10] = (byte)num26;
							num27 = 200 - 66;
							array6[11] = (byte)num27;
							array6[11] = 221 - 73;
							array6[11] = 104 + 114;
							array6[12] = 155 - 51;
							array6[12] = 129 - 43;
							array6[12] = 66 - 32;
							array6[13] = 120 + 60;
							array6[13] = 89 + 34;
							array6[13] = 81 + 0;
							num27 = 57 + 101;
							array6[13] = (byte)num27;
							array6[14] = 21 + 28;
							array6[14] = 54 + 25;
							array6[14] = 232 - 77;
							array6[14] = 145 - 38;
							num27 = 184 - 61;
							array6[15] = (byte)num27;
							num26 = 9 + 37;
							array6[15] = (byte)num26;
							array6[15] = 200 - 66;
							num26 = 195 - 65;
							array6[15] = (byte)num26;
							num26 = 143 - 47;
							array6[15] = (byte)num26;
							num27 = 25 + 123;
							array6[15] = (byte)num27;
							byte[] array7 = array6;
							object obj = hIDAYxH6DWLHIthQgC.NPiXCs1R3q1IGEiYl7();
							hIDAYxH6DWLHIthQgC.vYNBEZFlLJr6HfGcvl(obj, CipherMode.CBC);
							ICryptoTransform transform = hIDAYxH6DWLHIthQgC.jRpY7cRT9OOrvid4e5(obj, array5, array7);
							Stream stream = hIDAYxH6DWLHIthQgC.gYCp8VMpTlOii9GWtO();
							CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
							hIDAYxH6DWLHIthQgC.jnImqMWen3EquqoVM8(cryptoStream, array3, 0, array3.Length);
							hIDAYxH6DWLHIthQgC.MEblfvC3eMQmRgtWx6(cryptoStream);
							hIDAYxH6DWLHIthQgC.TIxolwiNgHBDSHpPuS(hIDAYxH6DWLHIthQgC.dJ60ZwGG7, hIDAYxH6DWLHIthQgC.iGCWHQdCSKYjoHmjUq(hIDAYxH6DWLHIthQgC.SGSGLM9Bd22Xa3RwdD(), hIDAYxH6DWLHIthQgC.PcBVqPIGmwpew39XSv(stream)));
							hIDAYxH6DWLHIthQgC.o0UUJjwsgiOAxxglRO(stream);
							hIDAYxH6DWLHIthQgC.o0UUJjwsgiOAxxglRO(cryptoStream);
							hIDAYxH6DWLHIthQgC.ITdXJlEe08VAVjBtJk(vPkSh3s7U1vEqJ6ZwG);
							int num28 = 0;
							if (hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
							{
								num28 = 0;
							}
							switch (num28)
							{
							default:
								goto IL_187C;
							}
						}
						catch
						{
							int num29 = 0;
							if (hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
							{
								num29 = 0;
							}
							for (;;)
							{
								switch (num29)
								{
								default:
									flag = true;
									num29 = 0;
									if (hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
									{
										num29 = 1;
									}
									break;
								case 1:
									goto IL_1684;
								}
							}
							IL_1684:
							goto IL_187C;
						}
						goto IL_1697;
					case 21:
						goto IL_7B;
					default:
						goto IL_1697;
					}
					IL_189D:
					if (!flag)
					{
						flag = false;
						num2 = 19;
						continue;
					}
					num2 = 14;
					if (hIDAYxH6DWLHIthQgC.UdSLgfVqHSFqUZRH6s() == null)
					{
						num2 = 21;
						continue;
					}
					continue;
					IL_1697:
					hIDAYxH6DWLHIthQgC.HgTjlb0MMefSF2VaPw(true);
					num2 = 0;
					if (hIDAYxH6DWLHIthQgC.UdSLgfVqHSFqUZRH6s() == null)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_1787:
					if (hIDAYxH6DWLHIthQgC.dJ60ZwGG7 != null)
					{
						num2 = 8;
						continue;
					}
					goto IL_1697;
					IL_16B7:
					if (hIDAYxH6DWLHIthQgC.Bex8jaNN0CI4Eu08gi(text) == 0)
					{
						num2 = 12;
						continue;
					}
					hashAlgorithm = null;
					num2 = 2;
					continue;
					IL_16CD:
					flag = false;
					num2 = 20;
					continue;
					IL_187C:
					if (flag)
					{
						num2 = 1;
						if (hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					IL_18DD:
					binaryReader = null;
					num2 = 10;
					continue;
					IL_1FD5:
					hIDAYxH6DWLHIthQgC.dJ60ZwGG7 = new RSACryptoServiceProvider();
					num2 = 3;
					continue;
					IL_1FE9:
					num2 = 17;
					if (!hIDAYxH6DWLHIthQgC.cY5rSDpcgo079CMm5h())
					{
						num2 = 6;
					}
				}
				IL_186B:
				text2 = null;
				num = 6;
			}
			IL_7B:
			throw new Exception(hIDAYxH6DWLHIthQgC.DtnTQdqqUW9YZvjuy8V(hIDAYxH6DWLHIthQgC.W2T884ql4KoG4WmuP3X(hIDAYxH6DWLHIthQgC.oTXdmJzOUJS1jQ69LM(hIDAYxH6DWLHIthQgC.gbd0RGsLdCdYJ9obis(typeof(hIDAYxH6DWLHIthQgC).TypeHandle).Assembly)), " is tampered."));
			IL_18BE:
			return;
			IL_18EA:;
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x0002BC0C File Offset: 0x00029E0C
		private static Stream GOV9AYHwR()
		{
			return new MemoryStream();
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0002BC1C File Offset: 0x00029E1C
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

		// Token: 0x06000D92 RID: 3474 RVA: 0x0002BC90 File Offset: 0x00029E90
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

		// Token: 0x06000D93 RID: 3475 RVA: 0x0002BDC0 File Offset: 0x00029FC0
		private static byte[] dcJwyWJ2h(object \u0020)
		{
			return ((MemoryStream)\u0020).ToArray();
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0002BDD4 File Offset: 0x00029FD4
		internal byte[] OZvj2rN0e()
		{
			int length = "{11111-22222-30001-00001}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0002BDF8 File Offset: 0x00029FF8
		internal byte[] tPnkNfto2()
		{
			int length = "{11111-22222-30001-00002}".Length;
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x0002BE1C File Offset: 0x0002A01C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void BAASgSTaW(object \u0020)
		{
			NeFPnNYfto2SAAgSTa.XoaHyBJbad(0, new object[]
			{
				\u0020
			}, null);
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0002BE54 File Offset: 0x0002A054
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string gSCeTtiku(int \u0020)
		{
			if (hIDAYxH6DWLHIthQgC.RVsUi7vv8.Length == 0)
			{
				hIDAYxH6DWLHIthQgC.ReW45iIw5 = new List<string>();
				hIDAYxH6DWLHIthQgC.asMnx1K5s = new List<int>();
				hIDAYxH6DWLHIthQgC.BAASgSTaW(Type.GetTypeFromHandle(f1stFPxcHMQ5yL3IBf.BaJEy92N0v(33554741)).GetTypeInfo().Assembly.GetManifestResourceStream("QtJhJnq2nQZLDHHvJZ.0yEFWy5lCf83VMbt48"));
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
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

		// Token: 0x06000D98 RID: 3480 RVA: 0x0002C054 File Offset: 0x0002A254
		private hIDAYxH6DWLHIthQgC(byte[] \u0020, byte[] \u0020)
		{
			this.EG7tVH7R7 = \u0020;
			this.OnMCBfq5Q = \u0020;
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0002C074 File Offset: 0x0002A274
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

		// Token: 0x06000D9A RID: 3482 RVA: 0x0002C260 File Offset: 0x0002A460
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

		// Token: 0x06000D9B RID: 3483 RVA: 0x0002C344 File Offset: 0x0002A544
		internal static string PdFXUg04j(object \u0020)
		{
			"{11111-22222-50001-00000}".Trim();
			byte[] array = Convert.FromBase64String(\u0020);
			return Encoding.Unicode.GetString(array, 0, array.Length);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x0002C37C File Offset: 0x0002A57C
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

		// Token: 0x06000D9D RID: 3485 RVA: 0x0002C3B4 File Offset: 0x0002A5B4
		private byte[] htFdmQ9eP()
		{
			return null;
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0002C3CC File Offset: 0x0002A5CC
		private byte[] dbXPZLbLV()
		{
			return null;
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x0002C3E4 File Offset: 0x0002A5E4
		internal static object he8dPAY5givukqoW6f(object A_0)
		{
			return A_0.BaseStream;
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0002C3F8 File Offset: 0x0002A5F8
		internal static void Ureuwl8bndokyuUbEo(object A_0, long A_1)
		{
			A_0.Position = A_1;
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0002C410 File Offset: 0x0002A610
		internal static long WHuTrLnTOO1A5kVhVJ(object A_0)
		{
			return A_0.Length;
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0002C424 File Offset: 0x0002A624
		internal static object ahIZIhbdDDaGSnTs9f(object A_0, int A_1)
		{
			return A_0.ReadBytes(A_1);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x0002C43C File Offset: 0x0002A63C
		internal static object bOd2Cq6ah1NJ6l6vSg(object A_0)
		{
			return A_0.EntryPoint;
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0002C450 File Offset: 0x0002A650
		internal static bool JD25qWyQnorrLXd0as(object A_0, object A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0002C468 File Offset: 0x0002A668
		internal static void AATiL3JRJGW1EhfvE9(object A_0)
		{
			((IDisposable)A_0).Dispose();
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0002C47C File Offset: 0x0002A67C
		internal static bool zCZgjivYUf4xDpiWFK()
		{
			return null == null;
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x0002C48C File Offset: 0x0002A68C
		internal static object tsFTW1xqpLhq3KXB2b()
		{
			return null;
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0002C498 File Offset: 0x0002A698
		internal static void HgTjlb0MMefSF2VaPw(bool A_0)
		{
			RSACryptoServiceProvider.UseMachineKeyStore = A_0;
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0002C4AC File Offset: 0x0002A6AC
		internal static Type gbd0RGsLdCdYJ9obis(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0002C4C0 File Offset: 0x0002A6C0
		internal static object sJ7E1xSdD4y0hcVJGg(object A_0)
		{
			return A_0.Location;
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x0002C4D4 File Offset: 0x0002A6D4
		internal static int Bex8jaNN0CI4Eu08gi(object A_0)
		{
			return A_0.Length;
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0002C4E8 File Offset: 0x0002A6E8
		internal static object daHTj4uS1VrRBPeZlY()
		{
			return SHA1.Create();
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0002C4F8 File Offset: 0x0002A6F8
		internal static object mCFbXIDOftEdcOmbxM(object A_0)
		{
			return CryptoConfig.MapNameToOID(A_0);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0002C50C File Offset: 0x0002A70C
		internal static bool VY0BP7mtvYiG4ROk9v(object A_0)
		{
			return File.Exists(A_0);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0002C520 File Offset: 0x0002A720
		internal static object FTRy2Z7cbu7sjo9q2J(object A_0, object A_1)
		{
			return A_0.GetManifestResourceStream(A_1);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0002C538 File Offset: 0x0002A738
		internal static object IjDYigPXJ4dDm5ZeVo(object A_0)
		{
			return A_0.AsxqrFX3HQ();
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0002C54C File Offset: 0x0002A74C
		internal static void axt0ck4ZlK9v9IHYpl(object A_0, long A_1)
		{
			A_0.Position = A_1;
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0002C564 File Offset: 0x0002A764
		internal static long Tfy7Vt3tsMY7GQQfRj(object A_0)
		{
			return A_0.Length;
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0002C578 File Offset: 0x0002A778
		internal static object mduqxMfgNImGGgmjW9(object A_0, int \u0020)
		{
			return A_0.C9UqM3M0Ll(\u0020);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0002C590 File Offset: 0x0002A790
		internal static object NPiXCs1R3q1IGEiYl7()
		{
			return hIDAYxH6DWLHIthQgC.LtAJclWeT();
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0002C5A0 File Offset: 0x0002A7A0
		internal static void vYNBEZFlLJr6HfGcvl(object A_0, CipherMode A_1)
		{
			A_0.Mode = A_1;
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0002C5B8 File Offset: 0x0002A7B8
		internal static object jRpY7cRT9OOrvid4e5(object A_0, object A_1, object A_2)
		{
			return A_0.CreateDecryptor(A_1, A_2);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0002C5D4 File Offset: 0x0002A7D4
		internal static object gYCp8VMpTlOii9GWtO()
		{
			return hIDAYxH6DWLHIthQgC.GOV9AYHwR();
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0002C5E4 File Offset: 0x0002A7E4
		internal static void jnImqMWen3EquqoVM8(object A_0, object A_1, int A_2, int A_3)
		{
			A_0.Write(A_1, A_2, A_3);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0002C604 File Offset: 0x0002A804
		internal static void MEblfvC3eMQmRgtWx6(object A_0)
		{
			A_0.FlushFinalBlock();
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0002C618 File Offset: 0x0002A818
		internal static object SGSGLM9Bd22Xa3RwdD()
		{
			return Encoding.UTF8;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0002C628 File Offset: 0x0002A828
		internal static object PcBVqPIGmwpew39XSv(object A_0)
		{
			return hIDAYxH6DWLHIthQgC.dcJwyWJ2h(A_0);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0002C63C File Offset: 0x0002A83C
		internal static object iGCWHQdCSKYjoHmjUq(object A_0, object A_1)
		{
			return A_0.GetString(A_1);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0002C654 File Offset: 0x0002A854
		internal static void TIxolwiNgHBDSHpPuS(object A_0, object A_1)
		{
			A_0.FromXmlString(A_1);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0002C66C File Offset: 0x0002A86C
		internal static void o0UUJjwsgiOAxxglRO(object A_0)
		{
			A_0.Close();
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0002C680 File Offset: 0x0002A880
		internal static void ITdXJlEe08VAVjBtJk(object A_0)
		{
			A_0.bFiqUko1xE();
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0002C694 File Offset: 0x0002A894
		internal static void pgJkNLBJLDCIyvhROl(object A_0, object A_1, uint \u0020, object A_3)
		{
			hIDAYxH6DWLHIthQgC.EZdsFxqyB(A_0, A_1, \u0020, A_3);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0002C6B4 File Offset: 0x0002A8B4
		internal static ushort FUBUmsG90hqSA7rlkL(object A_0)
		{
			return A_0.ReadUInt16();
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0002C6C8 File Offset: 0x0002A8C8
		internal static int Ya9JVMrmd95Ew41pow(object A_0, object A_1, int A_2, int A_3)
		{
			return A_0.Read(A_1, A_2, A_3);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0002C6E8 File Offset: 0x0002A8E8
		internal static void HRaQOjTfgghFewIPxB(object A_0, object A_1, int \u0020, int \u0020)
		{
			hIDAYxH6DWLHIthQgC.LKsFIQxCl(A_0, A_1, \u0020, \u0020);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x0002C708 File Offset: 0x0002A908
		internal static long Gk4lD1g0msxyGJtnHq(object A_0)
		{
			return A_0.Position;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0002C71C File Offset: 0x0002A91C
		internal static uint aYB2v9omYkvkhXtoum(object A_0)
		{
			return A_0.ReadUInt32();
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0002C730 File Offset: 0x0002A930
		internal static uint YBvsw8UX4gayR1YrvN(uint \u0020, int \u0020, long \u0020, object A_3)
		{
			return hIDAYxH6DWLHIthQgC.mf83VSwim(\u0020, \u0020, \u0020, A_3);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0002C750 File Offset: 0x0002A950
		internal static long q2dmIFjqwwXomZUqrp(long A_0, long A_1)
		{
			return Math.Min(A_0, A_1);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0002C768 File Offset: 0x0002A968
		internal static object RQ9EyXQGAVRZEDa98X(object A_0, object A_1, int A_2, int A_3)
		{
			return A_0.TransformFinalBlock(A_1, A_2, A_3);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0002C788 File Offset: 0x0002A988
		internal static object DS6laFe0v28xFKkTTc(object A_0, int A_1)
		{
			return A_0.ReadBytes(A_1);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0002C7A0 File Offset: 0x0002A9A0
		internal static object rTSdaoKQJg9TSIjbr9(object A_0)
		{
			return A_0.Hash;
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0002C7B4 File Offset: 0x0002A9B4
		internal static bool GtLd9QaJk9eBIPyyFE(object A_0, object A_1, object A_2, object A_3)
		{
			return A_0.VerifyHash(A_1, A_2, A_3);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0002C7D4 File Offset: 0x0002A9D4
		internal static void wqcDK3ZhyQPRxPkqw5(object A_0)
		{
			A_0.Close();
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0002C7E8 File Offset: 0x0002A9E8
		internal static object oTXdmJzOUJS1jQ69LM(object A_0)
		{
			return A_0.GetName();
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0002C7FC File Offset: 0x0002A9FC
		internal static object W2T884ql4KoG4WmuP3X(object A_0)
		{
			return A_0.Name;
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0002C810 File Offset: 0x0002AA10
		internal static object DtnTQdqqUW9YZvjuy8V(object A_0, object A_1)
		{
			return A_0 + A_1;
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0002C828 File Offset: 0x0002AA28
		internal static bool cY5rSDpcgo079CMm5h()
		{
			return null == null;
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0002C838 File Offset: 0x0002AA38
		internal static object UdSLgfVqHSFqUZRH6s()
		{
			return null;
		}

		// Token: 0x04000998 RID: 2456
		private static bool e1I76Dk1A;

		// Token: 0x04000999 RID: 2457
		private static object Bh317U1vE;

		// Token: 0x0400099A RID: 2458
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

		// Token: 0x0400099B RID: 2459
		private static object CC86JSicc;

		// Token: 0x0400099C RID: 2460
		private object OnMCBfq5Q;

		// Token: 0x0400099D RID: 2461
		private static int HDHKHhTXP;

		// Token: 0x0400099E RID: 2462
		private static bool CPGmeecTL = false;

		// Token: 0x0400099F RID: 2463
		private static List<int> asMnx1K5s;

		// Token: 0x040009A0 RID: 2464
		private static object RVsUi7vv8;

		// Token: 0x040009A1 RID: 2465
		private static List<string> ReW45iIw5;

		// Token: 0x040009A2 RID: 2466
		private object EG7tVH7R7;

		// Token: 0x040009A3 RID: 2467
		private static Dictionary<int, int> FmWIypaNX;

		// Token: 0x040009A4 RID: 2468
		private static object dJ60ZwGG7;

		// Token: 0x040009A5 RID: 2469
		private static object mLdMA9iPk;

		// Token: 0x040009A6 RID: 2470
		private static object iGWr5uXHi;

		// Token: 0x02000136 RID: 310
		internal class vPkSh3s7U1vEqJ6ZwG
		{
			// Token: 0x06000DD2 RID: 3538 RVA: 0x0002C844 File Offset: 0x0002AA44
			public vPkSh3s7U1vEqJ6ZwG(Stream \u0020)
			{
				this.TXSqn39pP3 = new BinaryReader(\u0020);
			}

			// Token: 0x06000DD3 RID: 3539 RVA: 0x0002C860 File Offset: 0x0002AA60
			internal Stream AsxqrFX3HQ()
			{
				return hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG.Txkkgg1YKM9VPAbHdX2(this.TXSqn39pP3);
			}

			// Token: 0x06000DD4 RID: 3540 RVA: 0x0002C874 File Offset: 0x0002AA74
			internal byte[] C9UqM3M0Ll(int \u0020)
			{
				return this.TXSqn39pP3.ReadBytes(\u0020);
			}

			// Token: 0x06000DD5 RID: 3541 RVA: 0x0002C88C File Offset: 0x0002AA8C
			internal int N4Hq1iEYPX(byte[] \u0020, int \u0020, int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG.ICo3kq18xPsv25pEsZY(this.TXSqn39pP3, \u0020, \u0020, \u0020);
			}

			// Token: 0x06000DD6 RID: 3542 RVA: 0x0002C8A4 File Offset: 0x0002AAA4
			internal int c73q0LArlF()
			{
				return this.TXSqn39pP3.ReadInt32();
			}

			// Token: 0x06000DD7 RID: 3543 RVA: 0x0002C8B8 File Offset: 0x0002AAB8
			internal void bFiqUko1xE()
			{
				hIDAYxH6DWLHIthQgC.vPkSh3s7U1vEqJ6ZwG.JGZsRm1nAGvaD2kDZEV(this.TXSqn39pP3);
			}

			// Token: 0x06000DD8 RID: 3544 RVA: 0x0002C8CC File Offset: 0x0002AACC
			internal static object Txkkgg1YKM9VPAbHdX2(object A_0)
			{
				return A_0.BaseStream;
			}

			// Token: 0x06000DD9 RID: 3545 RVA: 0x0002C8E0 File Offset: 0x0002AAE0
			internal static int ICo3kq18xPsv25pEsZY(object A_0, object A_1, int A_2, int A_3)
			{
				return A_0.Read(A_1, A_2, A_3);
			}

			// Token: 0x06000DDA RID: 3546 RVA: 0x0002C900 File Offset: 0x0002AB00
			internal static void JGZsRm1nAGvaD2kDZEV(object A_0)
			{
				A_0.Close();
			}

			// Token: 0x040009A7 RID: 2471
			private object TXSqn39pP3;
		}

		// Token: 0x02000137 RID: 311
		// (Invoke) Token: 0x06000DDC RID: 3548
		private delegate void W7KVsiF7vv8RGW5uXH(object o);

		// Token: 0x02000138 RID: 312
		internal class uneW5i3Iw5OsMx1K5s
		{
			// Token: 0x06000DDF RID: 3551 RVA: 0x0002C914 File Offset: 0x0002AB14
			internal static string Hh1qKiqeMC(object \u0020, object \u0020)
			{
				byte[] bytes = hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.IWY8Cn1JZQjLcd9QlDt().GetBytes(\u0020);
				byte[] array = new byte[]
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
				byte[] iv = hIDAYxH6DWLHIthQgC.KBfNgPHJl(hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.fcttX41pGDaQCUDsDLJ(hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.IWY8Cn1JZQjLcd9QlDt(), \u0020));
				MemoryStream memoryStream = new MemoryStream();
				SymmetricAlgorithm symmetricAlgorithm = hIDAYxH6DWLHIthQgC.LtAJclWeT();
				hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.ic7sr41VwlFIlW5OLUC(symmetricAlgorithm, array);
				symmetricAlgorithm.IV = iv;
				CryptoStream cryptoStream = new CryptoStream(memoryStream, hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.pZMEiD10DjXEKPCh6ig(symmetricAlgorithm), CryptoStreamMode.Write);
				hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.D1NIqc1sMmEoAfwJpCc(cryptoStream, bytes, 0, bytes.Length);
				cryptoStream.Close();
				return Convert.ToBase64String(hIDAYxH6DWLHIthQgC.uneW5i3Iw5OsMx1K5s.lPAuPD1SxIAsykeZucP(memoryStream));
			}

			// Token: 0x06000DE1 RID: 3553 RVA: 0x0002C9A8 File Offset: 0x0002ABA8
			internal static object IWY8Cn1JZQjLcd9QlDt()
			{
				return Encoding.Unicode;
			}

			// Token: 0x06000DE2 RID: 3554 RVA: 0x0002C9B8 File Offset: 0x0002ABB8
			internal static object fcttX41pGDaQCUDsDLJ(object A_0, object A_1)
			{
				return A_0.GetBytes(A_1);
			}

			// Token: 0x06000DE3 RID: 3555 RVA: 0x0002C9D0 File Offset: 0x0002ABD0
			internal static void ic7sr41VwlFIlW5OLUC(object A_0, object A_1)
			{
				A_0.Key = A_1;
			}

			// Token: 0x06000DE4 RID: 3556 RVA: 0x0002C9E8 File Offset: 0x0002ABE8
			internal static object pZMEiD10DjXEKPCh6ig(object A_0)
			{
				return A_0.CreateEncryptor();
			}

			// Token: 0x06000DE5 RID: 3557 RVA: 0x0002C9FC File Offset: 0x0002ABFC
			internal static void D1NIqc1sMmEoAfwJpCc(object A_0, object A_1, int A_2, int A_3)
			{
				A_0.Write(A_1, A_2, A_3);
			}

			// Token: 0x06000DE6 RID: 3558 RVA: 0x0002CA1C File Offset: 0x0002AC1C
			internal static object lPAuPD1SxIAsykeZucP(object A_0)
			{
				return A_0.ToArray();
			}
		}
	}
}
