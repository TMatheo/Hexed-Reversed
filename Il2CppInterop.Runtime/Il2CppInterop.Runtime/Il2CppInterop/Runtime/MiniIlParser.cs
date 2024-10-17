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
		// Token: 0x06000202 RID: 514 RVA: 0x0000AD44 File Offset: 0x00008F44
		static MiniIlParser()
		{
			int num = 8;
			int num2 = num;
			for (;;)
			{
				OpCode value;
				FieldInfo fieldInfo;
				FieldInfo[] array;
				int num3;
				switch (num2)
				{
				case 0:
					goto IL_A9;
				case 1:
					goto IL_1DE;
				case 2:
					MiniIlParser.PrefixCodes = new HashSet<short>();
					num2 = 9;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d01f42186cf2421f90d71301ed147eb1 == 0)
					{
						num2 = 16;
						continue;
					}
					continue;
				case 3:
					goto IL_15B;
				case 4:
					goto IL_136;
				case 5:
					MiniIlParser.tC4PsPxVjonhkHqUgwb();
					num2 = 15;
					continue;
				case 6:
					goto IL_1DE;
				case 7:
					MiniIlParser.MFNFJXxldHlnmeFrVEZ();
					num2 = 5;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_99cea5f9c4c245c2a5f184ab2e57fafc != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 8:
					MiniIlParser.fsGRkqxgfYALyopulBW();
					num2 = 7;
					continue;
				case 9:
					if ((ushort)Lj2eUAipi0r5fQRFLXR.i2IAUFsOOC(ref value, Lj2eUAipi0r5fQRFLXR.dOwi47d8tR) <= 255)
					{
						num2 = 4;
						continue;
					}
					goto IL_29D;
				case 10:
					goto IL_136;
				case 11:
					if (MiniIlParser.rpVIcvxv74i8MQln4sJ(MiniIlParser.Kc56bnxm98wLRU3Labq(fieldInfo, MxKuwSiKGgSjAmlPfBS.yd0i5PmBRG), byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(OpCode).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), Q57NvyUKOvY5KovuDBT.G0AU5uNCnx))
					{
						num2 = 12;
						continue;
					}
					break;
				case 12:
					goto IL_136;
				case 13:
					goto IL_29D;
				case 14:
					MiniIlParser.OpCodesMap[Lj2eUAipi0r5fQRFLXR.i2IAUFsOOC(ref value, Lj2eUAipi0r5fQRFLXR.dOwi47d8tR)] = value;
					num2 = 9;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_282cf292112a4cf49ec1b8b2e2e7602a == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 15:
					MiniIlParser.OpCodesMap = new Dictionary<short, OpCode>();
					num2 = 2;
					continue;
				case 16:
					array = MiniIlParser.Qj00gfxXSffvF4Qe4QP(MiniIlParser.Y3YPRWxODSYBogbBnJg(typeof(OpCodes).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), BindingFlags.Static | BindingFlags.Public, dHdpk5i1J82vRy1x65v.YGLiMMBDB9);
					num2 = 16;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bc244a0192c343599cd1cf83671e02ab != 0)
					{
						num2 = 18;
						continue;
					}
					continue;
				case 17:
					break;
				case 18:
					num3 = 0;
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ac98984015b94d6a931f8affda832ec9 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 19:
					return;
				default:
					goto IL_A9;
				}
				value = (OpCode)GYhvdXq2oldr1eq9pKe.i2IAUFsOOC(fieldInfo, null, GYhvdXq2oldr1eq9pKe.gf2qyBPuV5);
				num2 = 14;
				continue;
				IL_136:
				num3++;
				num2 = 3;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_277c9fa6c1da46a98cc2f13643296b8f != 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_15B:
				if (num3 >= array.Length)
				{
					break;
				}
				num2 = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_A9:
				goto IL_15B;
				IL_1DE:
				fieldInfo = array[num3];
				num2 = 11;
				continue;
				IL_29D:
				MiniIlParser.PrefixCodes.Add((short)((byte)((ushort)Lj2eUAipi0r5fQRFLXR.i2IAUFsOOC(ref value, Lj2eUAipi0r5fQRFLXR.dOwi47d8tR) >> 8)));
				num2 = 10;
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000B038 File Offset: 0x00009238
		public static IEnumerable<ValueTuple<OpCode, long>> Decode(object ilBytes)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			for (;;)
			{
				int num = 18;
				for (;;)
				{
					int num2 = num;
					OpCode opCode;
					int index;
					for (;;)
					{
						int num3;
						int argLength;
						short num6;
						switch (num2)
						{
						case 0:
							goto IL_445;
						case 1:
							goto IL_35D;
						case 2:
							break;
						case 3:
							goto IL_1B0;
						case 4:
							switch (num3)
							{
							case 0:
								break;
							case 1:
								goto IL_5C1;
							case 2:
								goto IL_445;
							case 3:
							case 5:
							case 6:
							case 7:
								goto IL_349;
							case 4:
								goto IL_488;
							case 8:
								goto IL_60C;
							default:
								num2 = 2;
								if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9f56599a6a304695b6cfc284bd7d7c9a != 0)
								{
									num2 = 9;
									continue;
								}
								continue;
							}
							break;
						case 5:
							defaultInterpolatedStringHandler.AppendFormatted<int>(argLength);
							num2 = 29;
							continue;
						case 6:
							goto IL_405;
						case 7:
							goto IL_5A4;
						case 8:
							num2 = 4;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_74d61b1611df4615bd4df289712ea178 != 0)
							{
								num2 = 21;
								continue;
							}
							continue;
						case 9:
							goto IL_349;
						case 10:
							goto IL_60C;
						case 11:
							goto IL_1EE;
						case 12:
							goto IL_32C;
						case 13:
							goto IL_5C1;
						case 14:
							QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, MiniIlParser.<Decode>d__3.Yo3aIhkcHFY2blXu5JA(-263637932 ^ -1485015930 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2210d7ca22c24335b32d80ca3ef84b8e), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
							num2 = 3;
							continue;
						case 15:
							goto IL_488;
						case 16:
							num2 = 37;
							continue;
						case 17:
						{
							int num4;
							switch (num4)
							{
							case 0:
								goto IL_35F;
							case 1:
								num2 = 28;
								continue;
							case 2:
								num2 = 6;
								if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4e45528af4644e9b080e05d5ff6ef54 == 0)
								{
									num2 = 20;
									continue;
								}
								continue;
							case 3:
								num2 = 36;
								continue;
							case 4:
								num2 = 7;
								continue;
							case 5:
								num2 = 5;
								if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b3f1fcfa11104bd49a7f00386d38b4f4 != 0)
								{
									num2 = 39;
									continue;
								}
								continue;
							default:
								num2 = 1;
								if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6926da1cf80047d3a6f0516668d22380 == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							}
							break;
						}
						case 18:
						{
							int num5;
							int num4 = num5;
							num2 = 17;
							continue;
						}
						case 19:
							QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1887629927 ^ -1987633624 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
							num2 = 24;
							continue;
						case 20:
							goto IL_5A4;
						case 21:
							goto IL_18B;
						case 22:
							argLength = MiniIlParser.GetOperandSize(opCode);
							num2 = 19;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_22d16b8eb84d4725aef9f7a9d2f68925 == 0)
							{
								num2 = 41;
								continue;
							}
							continue;
						case 23:
							num2 = 30;
							continue;
						case 24:
							defaultInterpolatedStringHandler.AppendFormatted<short>(num6);
							num2 = 14;
							continue;
						case 25:
							goto IL_4FE;
						case 26:
							QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-54719256 ^ -1431461980 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_806dbdb7f5194c2fa0c07a915df13fc8), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
							num2 = 5;
							continue;
						case 27:
							goto IL_39C;
						case 28:
							goto IL_5A4;
						case 29:
							goto IL_592;
						case 30:
							goto IL_374;
						case 31:
							goto IL_4B6;
						case 32:
							goto IL_661;
						case 33:
							if (!MiniIlParser.PrefixCodes.Contains(num6))
							{
								num2 = 35;
								continue;
							}
							goto IL_4FE;
						case 34:
							index = 0;
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_61a3825996b24609815f6b482bf680d9 == 0)
							{
								num2 = 12;
								continue;
							}
							continue;
						case 35:
							goto IL_661;
						case 36:
							goto IL_5A4;
						case 37:
							goto IL_57F;
						case 38:
							num2 = 42;
							continue;
						case 39:
							goto IL_5A4;
						case 40:
							goto IL_349;
						case 41:
							num3 = argLength;
							num2 = 4;
							continue;
						case 42:
							goto IL_41D;
						case 43:
							goto IL_32C;
						case 44:
							num2 = 22;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9f56599a6a304695b6cfc284bd7d7c9a != 0)
							{
								num2 = 31;
								continue;
							}
							continue;
						default:
							goto IL_445;
						}
						yield return new ValueTuple<OpCode, long>(opCode, 0L);
						num2 = 44;
						continue;
						IL_32C:
						if (index >= ilBytes.Length)
						{
							num2 = 11;
							continue;
						}
						goto IL_39C;
						IL_349:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 1);
						num2 = 26;
						continue;
						IL_39C:
						num3 = index;
						index = num3 + 1;
						num6 = ilBytes[num3];
						num2 = 21;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_570d4e075bf443fcbaca8db32e007291 == 0)
						{
							num2 = 33;
							continue;
						}
						continue;
						IL_445:
						yield return new ValueTuple<OpCode, long>(opCode, (long)bZPmHMGaZNKjR0e4Wc1.i2IAUFsOOC(ilBytes, index, bZPmHMGaZNKjR0e4Wc1.r4JGCYfj0x));
						num2 = 16;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_feee416e61094c739ba253659ac2e257 != 0)
						{
							num2 = 12;
							continue;
						}
						continue;
						IL_488:
						yield return new ValueTuple<OpCode, long>(opCode, (long)MiniIlParser.<Decode>d__3.Orkngkk6nc1fy7SFkc3(ilBytes, index, bsXHr7GtCk6qkQSQpRs.E5ZGxUrJDE));
						num2 = 8;
						continue;
						IL_4FE:
						short num7 = (short)((ushort)(num6 << 8));
						num3 = index;
						index = num3 + 1;
						num6 = (num7 | ilBytes[num3]);
						num2 = 32;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c2ad52141772446383547acade021f9a == 0)
						{
							num2 = 18;
							continue;
						}
						continue;
						IL_5A4:
						index += argLength;
						num2 = 43;
						continue;
						IL_5C1:
						yield return new ValueTuple<OpCode, long>(opCode, (long)ilBytes[index]);
						num2 = 10;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_40875ab50e1c43f7bf4d96946e4523cb != 0)
						{
							num2 = 23;
							continue;
						}
						continue;
						IL_661:
						if (!MiniIlParser.OpCodesMap.TryGetValue(num6, out opCode))
						{
							goto IL_405;
						}
						num2 = 22;
					}
					IL_35F:
					num = 34;
					continue;
					IL_405:
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
					num = 19;
					continue;
					IL_60C:
					yield return new ValueTuple<OpCode, long>(opCode, xfUSUtGhyN6np19de3k.i2IAUFsOOC(ilBytes, index, xfUSUtGhyN6np19de3k.fqkG8Uh28h));
					num = 38;
				}
				IL_18B:
				IL_374:
				IL_41D:
				IL_4B6:
				IL_57F:;
			}
			IL_1B0:
			throw new NotSupportedException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
			IL_1EE:
			yield break;
			IL_35D:
			yield break;
			IL_592:
			throw new NotSupportedException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
			yield break;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000B050 File Offset: 0x00009250
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
						break;
					case OperandType.InlineI8:
					case OperandType.InlineR:
						return 8;
					case OperandType.InlineNone:
						return 0;
					case OperandType.InlinePhi:
					case (OperandType)8:
						goto IL_EB;
					case OperandType.InlineVar:
						return 2;
					case OperandType.ShortInlineBrTarget:
					case OperandType.ShortInlineI:
					case OperandType.ShortInlineVar:
						return 1;
					default:
						num2 = 3;
						continue;
					}
					break;
				}
				case 2:
				{
					OperandType operandType = Jr5LvFiz2HGZXmX3HC8.i2IAUFsOOC(ref opCode, Jr5LvFiz2HGZXmX3HC8.wnBIHNTpU4);
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ce81190098cb44f1b9a77ca4822d7770 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				case 3:
					goto IL_BD;
				}
				break;
			}
			return 4;
			IL_BD:
			IL_EB:
			throw new ArgumentOutOfRangeException();
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000B150 File Offset: 0x00009350
		internal static void fsGRkqxgfYALyopulBW()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000B160 File Offset: 0x00009360
		internal static void MFNFJXxldHlnmeFrVEZ()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000B170 File Offset: 0x00009370
		internal static void tC4PsPxVjonhkHqUgwb()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000B180 File Offset: 0x00009380
		internal static Type Y3YPRWxODSYBogbBnJg(RuntimeTypeHandle A_0, object A_1)
		{
			return byRw0gA2NyqHkl03ii9.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000B198 File Offset: 0x00009398
		internal static object Qj00gfxXSffvF4Qe4QP(object A_0, BindingFlags A_1, object A_2)
		{
			return dHdpk5i1J82vRy1x65v.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000B1B4 File Offset: 0x000093B4
		internal static Type Kc56bnxm98wLRU3Labq(object A_0, object A_1)
		{
			return MxKuwSiKGgSjAmlPfBS.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000B1CC File Offset: 0x000093CC
		internal static bool rpVIcvxv74i8MQln4sJ(Type A_0, Type A_1, object A_2)
		{
			return Q57NvyUKOvY5KovuDBT.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000B1E8 File Offset: 0x000093E8
		internal static bool UtS0Ipxy4oo8NWc1TwN()
		{
			return MiniIlParser.P0bEAXx2moc44yRNWbK == null;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000B1FC File Offset: 0x000093FC
		internal static MiniIlParser S4NmQOxSrUcjDKy02yw()
		{
			return MiniIlParser.P0bEAXx2moc44yRNWbK;
		}

		// Token: 0x0400002C RID: 44
		private static readonly Dictionary<short, OpCode> OpCodesMap;

		// Token: 0x0400002D RID: 45
		private static readonly HashSet<short> PrefixCodes;

		// Token: 0x0400002E RID: 46
		internal static object P0bEAXx2moc44yRNWbK;
	}
}
