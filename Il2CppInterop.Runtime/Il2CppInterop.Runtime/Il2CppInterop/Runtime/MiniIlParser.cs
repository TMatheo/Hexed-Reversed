using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime
{
	// Token: 0x02000011 RID: 17
	internal static class MiniIlParser
	{
		// Token: 0x060001E6 RID: 486 RVA: 0x0000A2D4 File Offset: 0x000084D4
		static MiniIlParser()
		{
			int num = 10;
			for (;;)
			{
				int num2 = num;
				OpCode value;
				FieldInfo fieldInfo;
				for (;;)
				{
					int num3;
					FieldInfo[] array;
					switch (num2)
					{
					case 0:
						goto IL_1A8;
					case 1:
						num3 = 0;
						num2 = 7;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92a7d78565474619a2c93ca9aa734139 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 2:
						goto IL_1F8;
					case 3:
						array = MiniIlParser.FRpsq8t7tQ7fG9ILGBw(MiniIlParser.JGtptatmGCnMbTy6AFG(typeof(OpCodes).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), BindingFlags.Static | BindingFlags.Public, RmVKjrXE2fevnAGrWCM.yNUXB0l0tX);
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6776fc69415b4d309be658e7e8ac3a28 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						MiniIlParser.OpCodesMap[RVW04IXG230OvycWW31.muOq5LWqgj(ref value, RVW04IXG230OvycWW31.B3QXr2GB9U)] = value;
						num2 = 11;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6776fc69415b4d309be658e7e8ac3a28 == 0)
						{
							num2 = 9;
							continue;
						}
						continue;
					case 5:
						goto IL_F8;
					case 6:
						break;
					case 7:
						goto IL_1E3;
					case 8:
						MiniIlParser.PrefixCodes = new HashSet<short>();
						num2 = 3;
						continue;
					case 9:
						MiniIlParser.GynfCLtulDMmYmjDnjr();
						num2 = 13;
						continue;
					case 10:
						MiniIlParser.xQU5JVtN1IeAnIT3Nws();
						num2 = 9;
						continue;
					case 11:
						if ((ushort)RVW04IXG230OvycWW31.muOq5LWqgj(ref value, RVW04IXG230OvycWW31.B3QXr2GB9U) > 255)
						{
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_892d6b14d02a4b94bf68e8edfebcd1f5 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 12:
						if (!MiniIlParser.p1vRvHtPDqe2R9JGLCG(h7CupmXInC1Jw4Mg12b.muOq5LWqgj(fieldInfo, h7CupmXInC1Jw4Mg12b.JHMXdddJHX), KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(OpCode).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), CiJop65IqHJCv8k5I3G.Lvb5dhFO0X))
						{
							num2 = 2;
							continue;
						}
						break;
					case 13:
						MiniIlParser.IKxAbrtD10eVMGJgTFD();
						num2 = 14;
						continue;
					case 14:
						MiniIlParser.OpCodesMap = new Dictionary<short, OpCode>();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b5c96750853e4496814af588489331dc == 0)
						{
							num2 = 8;
							continue;
						}
						continue;
					case 15:
						goto IL_1E3;
					case 16:
						return;
					default:
						goto IL_1A8;
					}
					num3++;
					num2 = 15;
					continue;
					IL_F8:
					fieldInfo = array[num3];
					num2 = 7;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_457365959f004478ad0e311bf72b3912 == 0)
					{
						num2 = 12;
						continue;
					}
					continue;
					IL_1E3:
					if (num3 >= array.Length)
					{
						num2 = 16;
						continue;
					}
					goto IL_F8;
					IL_1A8:
					MiniIlParser.PrefixCodes.Add((short)((byte)((ushort)RVW04IXG230OvycWW31.muOq5LWqgj(ref value, RVW04IXG230OvycWW31.B3QXr2GB9U) >> 8)));
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b1a14f54e3674a8baf7d5ab6ab85764a == 0)
					{
						num2 = 6;
					}
				}
				IL_1F8:
				value = (OpCode)MiniIlParser.IjfltTt4abm0bN5S7gn(fieldInfo, null, VMBgfWADmN0iq7FkmgY.stdAmTGDqJ);
				num = 4;
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000A568 File Offset: 0x00008768
		public static IEnumerable<ValueTuple<OpCode, long>> Decode(object ilBytes)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			for (;;)
			{
				int num = 18;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						int num3;
						int argLength;
						short num4;
						OpCode opCode;
						int index;
						switch (num2)
						{
						case 1:
							goto IL_5DA;
						case 2:
							num2 = 19;
							continue;
						case 3:
							goto IL_18B;
						case 4:
							gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, MiniIlParser.<Decode>d__3.CMNK0hVgcoMs1jbTi35(-588770852 ^ 1913313288 ^ -279653846 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_30f9f5d7d3f347ddac00a7ce0719d7cd), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
							num2 = 10;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_15379a47ca764a4e8e16ceaf4804e136 != 0)
							{
								num2 = 10;
								continue;
							}
							continue;
						case 5:
							switch (num3)
							{
							case 0:
								goto IL_121;
							case 1:
								goto IL_470;
							case 2:
								goto IL_1EC;
							case 3:
							case 5:
							case 6:
							case 7:
								goto IL_61D;
							case 4:
								goto IL_3AA;
							case 8:
								goto IL_15E;
							default:
								num2 = 6;
								continue;
							}
							break;
						case 6:
							goto IL_61D;
						case 7:
							goto IL_658;
						case 8:
							num3 = argLength;
							num2 = 5;
							continue;
						case 9:
							num2 = 9;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_da5aa2d475094b06a3df3cc53bc85956 == 0)
							{
								num2 = 31;
								continue;
							}
							continue;
						case 10:
							defaultInterpolatedStringHandler.AppendFormatted<short>(num4);
							num2 = 40;
							continue;
						case 11:
							goto IL_25E;
						case 12:
							goto IL_470;
						case 13:
							goto IL_658;
						case 14:
							goto IL_339;
						case 15:
							goto IL_15E;
						case 16:
							goto IL_286;
						case 17:
						{
							int num5;
							switch (num5)
							{
							case 0:
								num2 = 21;
								if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_faca03c2e5084297b7a5d894ac66fa57 == 0)
								{
									num2 = 36;
									continue;
								}
								continue;
							case 1:
								num2 = 13;
								if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7ac65c3fd4cb4629a8b893be89aed17d == 0)
								{
									num2 = 6;
									continue;
								}
								continue;
							case 2:
								num2 = 22;
								if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_791a252a9221476faad2c6d41e84a167 == 0)
								{
									num2 = 19;
									continue;
								}
								continue;
							case 3:
								num2 = 7;
								if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_be7c67937fc746d2ad6f8cd47b555de7 == 0)
								{
									num2 = 6;
									continue;
								}
								continue;
							case 4:
								num2 = 30;
								if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5395ed2b7ead4e349835ba3f56e39138 == 0)
								{
									num2 = 39;
									continue;
								}
								continue;
							case 5:
								goto IL_2BA;
							default:
								num2 = 33;
								continue;
							}
							break;
						}
						case 18:
						{
							int num6;
							int num5 = num6;
							num2 = 17;
							continue;
						}
						case 19:
							goto IL_4B9;
						case 20:
							num2 = 3;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 21:
							argLength = MiniIlParser.GetOperandSize(opCode);
							num2 = 6;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2a3cb7fb82fa47c39f707a2393c1a340 != 0)
							{
								num2 = 8;
								continue;
							}
							continue;
						case 22:
							goto IL_658;
						case 23:
						{
							short num7 = (short)((ushort)(num4 << 8));
							num3 = index;
							index = num3 + 1;
							num4 = (num7 | ilBytes[num3]);
							num2 = 29;
							continue;
						}
						case 24:
							goto IL_3AA;
						case 25:
							goto IL_1B3;
						case 26:
							if (MiniIlParser.PrefixCodes.Contains(num4))
							{
								num2 = 23;
								continue;
							}
							goto IL_21A;
						case 27:
							defaultInterpolatedStringHandler.AppendFormatted<int>(argLength);
							num2 = 32;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_575f8bd7bfb04e37800ff009689b44f6 == 0)
							{
								num2 = 8;
								continue;
							}
							continue;
						case 28:
							num2 = 42;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7ac65c3fd4cb4629a8b893be89aed17d == 0)
							{
								num2 = 29;
								continue;
							}
							continue;
						case 29:
							goto IL_21A;
						case 30:
							goto IL_658;
						case 31:
							goto IL_6DB;
						case 32:
							goto IL_646;
						case 33:
							goto IL_F9;
						case 34:
							goto IL_1EC;
						case 35:
							goto IL_61D;
						case 36:
							index = 0;
							num2 = 16;
							continue;
						case 37:
							gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, MiniIlParser.<Decode>d__3.CMNK0hVgcoMs1jbTi35(-357604844 ^ -738949505 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7fef7bb77728417ab4965dd0775b5899), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
							num2 = 21;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_15379a47ca764a4e8e16ceaf4804e136 != 0)
							{
								num2 = 27;
								continue;
							}
							continue;
						case 38:
							goto IL_69D;
						case 39:
							goto IL_658;
						case 40:
							gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, MiniIlParser.<Decode>d__3.CMNK0hVgcoMs1jbTi35(--1616386354 ^ 520840674 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6d9238cad9434518b97d223669b8fe50), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
							num2 = 1;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b329e831708e4d29ae561982d3d8c1c1 != 0)
							{
								num2 = 38;
								continue;
							}
							continue;
						case 41:
							goto IL_286;
						case 42:
							goto IL_2B8;
						case 43:
							goto IL_121;
						}
						goto Block_0;
						IL_121:
						yield return new ValueTuple<OpCode, long>(opCode, 0L);
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_43cc35cb254148318955c7f83ade60f1 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
						IL_15E:
						yield return new ValueTuple<OpCode, long>(opCode, MiniIlParser.<Decode>d__3.PpldPlVUVeXZHxuIip7(ilBytes, index, nyfbemkXiQhASMacFGk.OM2kcNm93I));
						num2 = 28;
						continue;
						IL_1B3:
						num3 = index;
						index = num3 + 1;
						num4 = ilBytes[num3];
						num2 = 26;
						continue;
						IL_286:
						if (index < ilBytes.Length)
						{
							goto IL_1B3;
						}
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8160363759e64728b1ce193157380515 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
						IL_1EC:
						yield return new ValueTuple<OpCode, long>(opCode, (long)MiniIlParser.<Decode>d__3.ba6GBPVoeD3MNiNJvru(ilBytes, index, vg7o2GkqOmZyuZ8g8TW.lnKk5P6tx0));
						num2 = 2;
						continue;
						IL_21A:
						if (!MiniIlParser.OpCodesMap.TryGetValue(num4, out opCode))
						{
							goto IL_339;
						}
						num2 = 21;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_734db430e12345289ec4ae0afacc44df != 0)
						{
							num2 = 19;
							continue;
						}
						continue;
						IL_3AA:
						yield return new ValueTuple<OpCode, long>(opCode, (long)RQ7TILkA3Fr1HTH9pO1.muOq5LWqgj(ilBytes, index, RQ7TILkA3Fr1HTH9pO1.AX0kL4vJCA));
						num2 = 20;
						continue;
						IL_470:
						yield return new ValueTuple<OpCode, long>(opCode, (long)ilBytes[index]);
						num2 = 9;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ff3063f9530e4a429cd27a548ab9d19d != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
						IL_61D:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 1);
						num2 = 37;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bac7568f2bc04130b6b980225b2cc409 == 0)
						{
							num2 = 8;
							continue;
						}
						continue;
						IL_658:
						index += argLength;
						num2 = 41;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b9b6cd6cbc040a7be58cff054f9e843 == 0)
						{
							num2 = 37;
						}
					}
					IL_2BA:
					num = 30;
					continue;
					IL_339:
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
					num = 4;
					continue;
					IL_5DA:
					num = 11;
				}
				IL_18B:
				IL_25E:
				IL_2B8:
				IL_4B9:
				IL_6DB:;
			}
			Block_0:
			goto IL_404;
			IL_F9:
			yield break;
			IL_404:
			yield break;
			IL_646:
			throw new NotSupportedException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
			IL_69D:
			throw new NotSupportedException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
			yield break;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000A580 File Offset: 0x00008780
		private static int GetOperandSize(OpCode opCode)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
				{
					OperandType operandType;
					switch (operandType)
					{
					case OperandType.InlineBrTarget:
					case OperandType.InlineField:
					case OperandType.InlineI:
					case OperandType.InlineMethod:
					case OperandType.InlineSig:
					case OperandType.InlineString:
					case OperandType.InlineSwitch:
					case OperandType.InlineTok:
					case OperandType.InlineType:
					case OperandType.ShortInlineR:
						return 4;
					case OperandType.InlineI8:
					case OperandType.InlineR:
						return 8;
					case OperandType.InlineNone:
						return 0;
					case OperandType.InlinePhi:
					case (OperandType)8:
						break;
					case OperandType.InlineVar:
						return 2;
					case OperandType.ShortInlineBrTarget:
					case OperandType.ShortInlineI:
					case OperandType.ShortInlineVar:
						return 1;
					default:
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_68cafcd7c4d444e39c183fde29795ee9 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				case 2:
				{
					OperandType operandType = Qmu3YUXTbq1Hc7qDPxS.muOq5LWqgj(ref opCode, Qmu3YUXTbq1Hc7qDPxS.EpIXg7lXMJ);
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3bc41e98a8e849aea1e93dfe0f04c43b == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				case 3:
					return 4;
				}
				break;
			}
			IL_6A:
			throw new ArgumentOutOfRangeException();
			goto IL_6A;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000A680 File Offset: 0x00008880
		internal static void xQU5JVtN1IeAnIT3Nws()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000A690 File Offset: 0x00008890
		internal static void GynfCLtulDMmYmjDnjr()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000A6A0 File Offset: 0x000088A0
		internal static void IKxAbrtD10eVMGJgTFD()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000A6B0 File Offset: 0x000088B0
		internal static Type JGtptatmGCnMbTy6AFG(RuntimeTypeHandle A_0, object A_1)
		{
			return KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000A6C8 File Offset: 0x000088C8
		internal static object FRpsq8t7tQ7fG9ILGBw(object A_0, BindingFlags A_1, object A_2)
		{
			return RmVKjrXE2fevnAGrWCM.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000A6E4 File Offset: 0x000088E4
		internal static bool p1vRvHtPDqe2R9JGLCG(Type A_0, Type A_1, object A_2)
		{
			return CiJop65IqHJCv8k5I3G.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000A700 File Offset: 0x00008900
		internal static object IjfltTt4abm0bN5S7gn(object A_0, object A_1, object A_2)
		{
			return VMBgfWADmN0iq7FkmgY.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000A71C File Offset: 0x0000891C
		internal static bool TkOjyXtsDiEQmDHhgk2()
		{
			return MiniIlParser.tCmCF8t068Vb1bDEVP4 == null;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000A730 File Offset: 0x00008930
		internal static MiniIlParser yvO4tEtSyMxJLhq0Ov1()
		{
			return MiniIlParser.tCmCF8t068Vb1bDEVP4;
		}

		// Token: 0x0400002C RID: 44
		private static readonly Dictionary<short, OpCode> OpCodesMap;

		// Token: 0x0400002D RID: 45
		private static readonly HashSet<short> PrefixCodes;

		// Token: 0x0400002E RID: 46
		private static object tCmCF8t068Vb1bDEVP4;
	}
}
