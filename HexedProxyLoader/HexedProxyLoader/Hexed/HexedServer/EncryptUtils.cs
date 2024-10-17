using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Hexed.HexedServer
{
	// Token: 0x02000007 RID: 7
	internal class EncryptUtils
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00004FB0 File Offset: 0x000031B0
		public static string GetMD5HashFromFile(object fileName)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_5D;
				case 2:
				{
					MD5 md = EncryptUtils.hkqjx35j4dbY1gyESD0(kO1moSk5Vkmn6GfcY7p.zL4kZPeUwp);
					num2 = 0;
					if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_a6e501c0a84745f2be250cd2b7bdccea == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				}
				break;
			}
			string result;
			return result;
			IL_5D:
			try
			{
				FileStream fileStream = EncryptUtils.OvBDrA51cgis6JG3lHK(fileName, tYZsW1kFh21MSfuptiE.eN5klO6Rch);
				int num3 = 0;
				if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_59f7c9e9d82c41069dd48354600d6bbd == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					try
					{
						MD5 md;
						result = W1GHKfkP4v9M5IBTWnl.bHC8kRmMET(EncryptUtils.fsKRA45N6MNkR5dRRWL(EncryptUtils.wwrbg95bL2G1R6XJR6f(md, fileStream, hJAtXMk2M41wbg5cUMu.uO8knBTLCC), LujsxJk9aRSj9yPJjSc.cM1kcn7puT), EncryptUtils.FUS8c35oJE9USgXDnb3(1882325017 ^ 1221959009 ^ <Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_2b2475f17e8b4da1908180177bdbc9c7), string.Empty, W1GHKfkP4v9M5IBTWnl.Bf5kGGTr0w);
						int num4 = 0;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_8b5daed0dc6e40639f7a358e4e3de521 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						default:
							return result;
						}
					}
					finally
					{
						if (fileStream != null)
						{
							goto IL_157;
						}
						int num5 = 2;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_bfd4747a6a95489387cb35e332ee29a8 == 0)
						{
							num5 = 0;
						}
						IL_141:
						switch (num5)
						{
						default:
							IL_157:
							EncryptUtils.ijUSqK56VrcCoWLtESA(fileStream, rB3NI18uG4FKi3JV6A0.YpC8xQO6rw);
							num5 = 0;
							if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_2b2475f17e8b4da1908180177bdbc9c7 != 0)
							{
								num5 = 1;
								goto IL_141;
							}
							goto IL_141;
						case 1:
							goto IL_1A6;
						case 2:
							goto IL_1A6;
						}
						IL_1A6:;
					}
					break;
				}
			}
			finally
			{
				MD5 md;
				if (md != null)
				{
					goto IL_20B;
				}
				int num6 = 0;
				if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_7d3f6a88267b4d238540be494dd7d668 == 0)
				{
					num6 = 1;
				}
				IL_1D1:
				switch (num6)
				{
				case 0:
					goto IL_236;
				case 1:
					goto IL_236;
				case 2:
					IL_20B:
					EncryptUtils.ijUSqK56VrcCoWLtESA(md, rB3NI18uG4FKi3JV6A0.YpC8xQO6rw);
					num6 = 0;
					if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_15a957baa25740e19563a0e401cc3db0 == 0)
					{
						num6 = 0;
						goto IL_1D1;
					}
					goto IL_1D1;
				default:
					goto IL_236;
				}
				IL_236:;
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00005248 File Offset: 0x00003448
		public static string RandomString(int length)
		{
			int num = 5;
			string text;
			for (;;)
			{
				int num2 = num;
				int num3;
				for (;;)
				{
					char[] array;
					switch (num2)
					{
					case 0:
						goto IL_BA;
					case 1:
						goto IL_13E;
					case 2:
						return text;
					case 3:
						num3 = 0;
						num2 = 6;
						continue;
					case 4:
						text = string.Empty;
						num2 = 3;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_daa5521260fe4c39bac7cdf0201c992d != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 5:
						array = EncryptUtils.FUS8c35oJE9USgXDnb3(1281814382 ^ 1597718007 ^ <Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_9f836ccc59724e699c779efc98ba6b86).ToArray<char>();
						num2 = 4;
						if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_a886741aeab44e5eaceecb407afb698c == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 6:
						break;
					case 7:
						break;
					default:
						goto IL_BA;
					}
					if (num3 >= length)
					{
						num2 = 2;
						continue;
					}
					IL_BA:
					text = EncryptUtils.fuuVsv5z1aJgShnmFnH(text, rP7gtNkSDy5U7N4qAg3.bHC8kRmMET(ref array[EncryptUtils.G9Vds25ryeRK5pCbCOe(EncryptUtils.Random, array.Length, daTZ8Wku4LtfCnjCjYm.d6mkxBIEqY)], rP7gtNkSDy5U7N4qAg3.mxrkYNDwdO), A255wv86035PqRokiHV.asi8rML1nu);
					num2 = 0;
					if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_4c15694ce4de4de99550ff9a16745dfb != 0)
					{
						num2 = 1;
					}
				}
				IL_13E:
				num3++;
				num = 7;
			}
			return text;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000053AC File Offset: 0x000035AC
		public static string RandomStringNumber(int length)
		{
			int num = 1;
			int num2 = num;
			string text;
			for (;;)
			{
				char[] array;
				int num3;
				switch (num2)
				{
				case 0:
					goto IL_AB;
				case 1:
					array = EncryptUtils.FUS8c35oJE9USgXDnb3(1148712147 << 4 ^ 2129587334 ^ <Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_238eeed4fb124455b9bc55886990dae2).ToArray<char>();
					num2 = 0;
					if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_b5ce94b35e4d462fb2b95ae5fa41a593 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					num3 = 0;
					num2 = 5;
					continue;
				case 3:
					goto IL_11B;
				case 4:
					num3++;
					num2 = 7;
					continue;
				case 5:
					break;
				case 6:
					return text;
				case 7:
					break;
				default:
					goto IL_AB;
				}
				if (num3 < length)
				{
					goto IL_11B;
				}
				num2 = 6;
				if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_0a5be57fd65e4888bd356f81bd5abce3 == 0)
				{
					num2 = 5;
					continue;
				}
				continue;
				IL_AB:
				text = string.Empty;
				num2 = 2;
				if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_fbcf7a955483480d8a19e419bf6d606a != 0)
				{
					num2 = 2;
					continue;
				}
				continue;
				IL_11B:
				text = EncryptUtils.fuuVsv5z1aJgShnmFnH(text, rP7gtNkSDy5U7N4qAg3.bHC8kRmMET(ref array[EncryptUtils.G9Vds25ryeRK5pCbCOe(EncryptUtils.Random, array.Length, daTZ8Wku4LtfCnjCjYm.d6mkxBIEqY)], rP7gtNkSDy5U7N4qAg3.mxrkYNDwdO), A255wv86035PqRokiHV.asi8rML1nu);
				num2 = 0;
				if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_4672c511600c49b1b4a7904620d7df97 != 0)
				{
					num2 = 4;
				}
			}
			return text;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00005524 File Offset: 0x00003724
		public static string FromBase64(object Data)
		{
			int num = 1;
			int num2 = num;
			byte[] array;
			for (;;)
			{
				switch (num2)
				{
				default:
					goto IL_2B;
				case 1:
					array = umZlS685wVdN3IX1GXn.bHC8kRmMET(Data, umZlS685wVdN3IX1GXn.n1W8Z5ADUD);
					num2 = 0;
					if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_4672c511600c49b1b4a7904620d7df97 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return EncryptUtils.bGCEeDZ81ZMlieExibp(EncryptUtils.rTaHydZ7q3IIRufHuEu(gED3AQ89wWdRCnniOSF.mf58cvaWAg), array, fXW6gJ8PIStty01cgNi.tcj8Gcru4r);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000055A0 File Offset: 0x000037A0
		public static string ToBase64(object Data)
		{
			return EncryptUtils.GJXJc1ZQm4f1su04vKw(EncryptUtils.kt8Lm3ZkcchQv2goMgP(gED3AQ89wWdRCnniOSF.bHC8kRmMET(gED3AQ89wWdRCnniOSF.mf58cvaWAg), Data, mrkkrg80urn55ADtOuI.E0J8sDclI1), F7jp8b8yCs2GQoL7RVL.CTO8JCxmj0);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000055C8 File Offset: 0x000037C8
		public static long GetUnixTime()
		{
			int num = 1;
			int num2 = num;
			DateTimeOffset dateTimeOffset;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					dateTimeOffset = EncryptUtils.McytgsZHM2BOYCEZtUn(pGfKgCkayJHnmaEx228.jM1kmm5WQE);
					num2 = 0;
					if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_7a4073f083b54c1db16ba3e16e87025f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return kDnf2EkRr9C2Yi4OYu5.bHC8kRmMET(ref dateTimeOffset, kDnf2EkRr9C2Yi4OYu5.Kg6kTbkklV);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00005638 File Offset: 0x00003838
		public EncryptUtils()
		{
			EncryptUtils.sw7D3wZKdQCyjVD89DG();
			nHwRpygmi6xxZAssJn.JvcaFtwnsV();
			base..ctor();
			int num = 0;
			if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_95cae04798bd4effac96dd0caed96b38 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000569C File Offset: 0x0000389C
		// Note: this type is marked as 'beforefieldinit'.
		static EncryptUtils()
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					EncryptUtils.sw7D3wZKdQCyjVD89DG();
					num2 = 0;
					if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_29f62ca47fe84304adabcf8e9ae652be == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					EncryptUtils.FnmpRHZgLoigdjB14uj();
					num2 = 2;
					continue;
				case 4:
					nHwRpygmi6xxZAssJn.JvcaFtwnsV();
					num2 = 0;
					if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_95cae04798bd4effac96dd0caed96b38 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				EncryptUtils.Random = new Random(EncryptUtils.QRRwmEZ51s1KU1TQ3MN(YWg9VVktnqDd8Wy9d8c.tvtkCtkx4R));
				num2 = 1;
				if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_f57147600bec46dcbedf8e1d19383d3c == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000576C File Offset: 0x0000396C
		internal static object hkqjx35j4dbY1gyESD0(object A_0)
		{
			return kO1moSk5Vkmn6GfcY7p.bHC8kRmMET(A_0);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00005780 File Offset: 0x00003980
		internal static object OvBDrA51cgis6JG3lHK(object A_0, object A_1)
		{
			return tYZsW1kFh21MSfuptiE.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00005798 File Offset: 0x00003998
		internal static object wwrbg95bL2G1R6XJR6f(object A_0, object A_1, object A_2)
		{
			return hJAtXMk2M41wbg5cUMu.bHC8kRmMET(A_0, A_1, A_2);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000057B4 File Offset: 0x000039B4
		internal static object fsKRA45N6MNkR5dRRWL(object A_0, object A_1)
		{
			return LujsxJk9aRSj9yPJjSc.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000057CC File Offset: 0x000039CC
		internal static object FUS8c35oJE9USgXDnb3(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000057E0 File Offset: 0x000039E0
		internal static void ijUSqK56VrcCoWLtESA(object A_0, object A_1)
		{
			rB3NI18uG4FKi3JV6A0.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000057F8 File Offset: 0x000039F8
		internal static bool A05imJ5wpkChgJPdSUb()
		{
			return EncryptUtils.TIyZkg5EwZJR1YHeGRe == null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000580C File Offset: 0x00003A0C
		internal static EncryptUtils fk5wa45d1dpL02uZc0C()
		{
			return EncryptUtils.TIyZkg5EwZJR1YHeGRe;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000581C File Offset: 0x00003A1C
		internal static int G9Vds25ryeRK5pCbCOe(object A_0, int A_1, object A_2)
		{
			return daTZ8Wku4LtfCnjCjYm.bHC8kRmMET(A_0, A_1, A_2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00005838 File Offset: 0x00003A38
		internal static object fuuVsv5z1aJgShnmFnH(object A_0, object A_1, object A_2)
		{
			return A255wv86035PqRokiHV.bHC8kRmMET(A_0, A_1, A_2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00005854 File Offset: 0x00003A54
		internal static object rTaHydZ7q3IIRufHuEu(object A_0)
		{
			return gED3AQ89wWdRCnniOSF.bHC8kRmMET(A_0);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00005868 File Offset: 0x00003A68
		internal static object bGCEeDZ81ZMlieExibp(object A_0, object A_1, object A_2)
		{
			return fXW6gJ8PIStty01cgNi.bHC8kRmMET(A_0, A_1, A_2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00005884 File Offset: 0x00003A84
		internal static object kt8Lm3ZkcchQv2goMgP(object A_0, object A_1, object A_2)
		{
			return mrkkrg80urn55ADtOuI.bHC8kRmMET(A_0, A_1, A_2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000058A0 File Offset: 0x00003AA0
		internal static object GJXJc1ZQm4f1su04vKw(object A_0, object A_1)
		{
			return F7jp8b8yCs2GQoL7RVL.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000058B8 File Offset: 0x00003AB8
		internal static DateTimeOffset McytgsZHM2BOYCEZtUn(object A_0)
		{
			return pGfKgCkayJHnmaEx228.bHC8kRmMET(A_0);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000058CC File Offset: 0x00003ACC
		internal static void sw7D3wZKdQCyjVD89DG()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000058DC File Offset: 0x00003ADC
		internal static void FnmpRHZgLoigdjB14uj()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000058EC File Offset: 0x00003AEC
		internal static int QRRwmEZ51s1KU1TQ3MN(object A_0)
		{
			return YWg9VVktnqDd8Wy9d8c.bHC8kRmMET(A_0);
		}

		// Token: 0x04000013 RID: 19
		public static object Random;

		// Token: 0x04000014 RID: 20
		internal static object TIyZkg5EwZJR1YHeGRe;
	}
}
