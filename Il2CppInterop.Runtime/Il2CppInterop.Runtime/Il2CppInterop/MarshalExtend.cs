using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppInterop.Runtime.Wrappers;
using MaoFcf2Vq4taIANM6n;

namespace Il2CppInterop
{
	// Token: 0x02000002 RID: 2
	public static class MarshalExtend
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002148 File Offset: 0x00000348
		public unsafe static string PtrToString(byte* ptr)
		{
			return MarshalExtend.PtrToString(ptr, MarshalExtend.StrLen(ptr), uDLdZ5AqNUaSKY7KefP.i2IAUFsOOC(uDLdZ5AqNUaSKY7KefP.p8sA9n6fhA));
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002168 File Offset: 0x00000368
		public unsafe static string PtrToString(byte* ptr, Encoding encoding)
		{
			return MarshalExtend.chZOx1a37GkqWXhQ5ZI(ptr, MarshalExtend.StrLen(ptr), encoding);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002180 File Offset: 0x00000380
		public unsafe static string PtrToString(byte* ptr, int nLen)
		{
			return MarshalExtend.chZOx1a37GkqWXhQ5ZI(ptr, nLen, MarshalExtend.DQfC5ka193sBVYmLgtd(uDLdZ5AqNUaSKY7KefP.p8sA9n6fhA));
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000219C File Offset: 0x0000039C
		public unsafe static string PtrToString(byte* ptr, int nLen, Encoding encoding)
		{
			return MarshalExtend.PtrToString(ptr, nLen, encoding);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000021B0 File Offset: 0x000003B0
		public static string PtrToString(IntPtr ptr)
		{
			return MarshalExtend.chZOx1a37GkqWXhQ5ZI(ptr, MarshalExtend.Jl5jSEaMk6JOT9V3qud(ptr), MarshalExtend.DQfC5ka193sBVYmLgtd(uDLdZ5AqNUaSKY7KefP.p8sA9n6fhA));
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021D0 File Offset: 0x000003D0
		public static string PtrToString(IntPtr ptr, int nLen)
		{
			return MarshalExtend.chZOx1a37GkqWXhQ5ZI(ptr, nLen, uDLdZ5AqNUaSKY7KefP.i2IAUFsOOC(uDLdZ5AqNUaSKY7KefP.p8sA9n6fhA));
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021EC File Offset: 0x000003EC
		public static string PtrToString(IntPtr ptr, Encoding encoding)
		{
			return MarshalExtend.chZOx1a37GkqWXhQ5ZI(ptr, MarshalExtend.Jl5jSEaMk6JOT9V3qud(ptr), encoding);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002204 File Offset: 0x00000404
		public static string PtrToString(IntPtr ptr, int nLen, Encoding encoding)
		{
			int num = 2;
			int num2 = num;
			byte[] array;
			for (;;)
			{
				switch (num2)
				{
				default:
					goto IL_2F;
				case 1:
					MarshalExtend.boHggyap4IJrYZ2mNoO(ptr, array, 0, array.Length, bMqnSHAi2LqA0GNZGR3.r6aAIfhV6b);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3bc6c4fc6422441e99d3c51c51f46d12 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					array = new byte[nLen];
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_282cf292112a4cf49ec1b8b2e2e7602a == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
			IL_2F:
			return MarshalExtend.fvUZoha4FbfwosiVQTK(encoding, array, 0, array.Length, q3OdohAGvaJsEOiEnED.ISuAYNVsNK);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000022AC File Offset: 0x000004AC
		public static IntPtr AllocHGlobal(int size)
		{
			return MarshalExtend.Od7vmaazTBwRpMFmiaC(IntPtr.Zero, (IntPtr)size, NativeMethods.AllocationType.Commit | NativeMethods.AllocationType.Reserve, NativeMethods.MemoryProtection.ReadWrite);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000022C8 File Offset: 0x000004C8
		public static IntPtr AllocHGlobal(IntPtr address, IntPtr size, NativeMethods.AllocationType allocationType, NativeMethods.MemoryProtection protect)
		{
			return NativeMethods.VirtualAlloc(address, size, allocationType, protect);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000022DC File Offset: 0x000004DC
		public static NativeMethods.MemoryProtection ProtectHGlobal(IntPtr address, UIntPtr size, NativeMethods.MemoryProtection protect)
		{
			int num = 1;
			int num2 = num;
			NativeMethods.MemoryProtection result;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					NativeMethods.NtProtectVirtualMemory(MarshalExtend.St6PRECHv8wGqvxJQs9(lFwkxeAaqLIHo45P9Xf.i2IAUFsOOC(lFwkxeAaqLIHo45P9Xf.e0FACQ9xIv), pOYRBYAtdgcy2Y90KCC.MK9AxRiQ01), ref address, ref size, protect, out result);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e4c6981dbbef43b3a6de5ad27be6a3b1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return result;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002358 File Offset: 0x00000558
		public static NativeMethods.MEMORY_BASIC_INFORMATION VirtualQueryHGlobal(IntPtr address)
		{
			int num = 1;
			int num2 = num;
			NativeMethods.MEMORY_BASIC_INFORMATION memory_BASIC_INFORMATION;
			for (;;)
			{
				switch (num2)
				{
				default:
				{
					uint num3;
					NativeMethods.NtQueryVirtualMemory(pOYRBYAtdgcy2Y90KCC.i2IAUFsOOC(MarshalExtend.VPBXZKCAtpe2KBVjhEK(lFwkxeAaqLIHo45P9Xf.e0FACQ9xIv), pOYRBYAtdgcy2Y90KCC.MK9AxRiQ01), address, 0, ref memory_BASIC_INFORMATION, (uint)Marshal.SizeOf<NativeMethods.MEMORY_BASIC_INFORMATION>(memory_BASIC_INFORMATION), out num3);
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ddf0bbff3ec54ad39c6b2ba58dc80058 != 0)
					{
						num2 = 2;
					}
					break;
				}
				case 1:
					memory_BASIC_INFORMATION = default(NativeMethods.MEMORY_BASIC_INFORMATION);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bc244a0192c343599cd1cf83671e02ab != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return memory_BASIC_INFORMATION;
				}
			}
			return memory_BASIC_INFORMATION;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002404 File Offset: 0x00000604
		public static void FreeHGlobal(IntPtr buffer)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					MarshalExtend.Uve8WkCUDD1dmGfGyC3(buffer, (UIntPtr)((IntPtr)0));
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_46ba390073ec4df6883860abf17dbf6f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002464 File Offset: 0x00000664
		public static void FreeHGlobal(IntPtr buffer, UIntPtr size)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					NativeMethods.NtFreeVirtualMemory(MarshalExtend.St6PRECHv8wGqvxJQs9(MarshalExtend.VPBXZKCAtpe2KBVjhEK(lFwkxeAaqLIHo45P9Xf.e0FACQ9xIv), pOYRBYAtdgcy2Y90KCC.MK9AxRiQ01), ref buffer, ref size, NativeMethods.AllocationType.Decommit | NativeMethods.AllocationType.Release);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_be54e2986e644667aed0d52d0affe157 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000024E0 File Offset: 0x000006E0
		public static void Copy(IntPtr source, IntPtr destination, uint size)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					NativeMethods.RtlMoveMemory(destination, source, size);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e236d804047744298c2380563ba7eca0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002540 File Offset: 0x00000740
		public static int StrLen(IntPtr ptr)
		{
			int num = 2;
			int num2 = num;
			int num3;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_60;
				case 2:
					num3 = 0;
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_650e65d7606047fda7d187c401bdfc6e != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					return num3;
				case 5:
					goto IL_60;
				}
				num3++;
				num2 = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_277c9fa6c1da46a98cc2f13643296b8f == 0)
				{
					num2 = 5;
					continue;
				}
				continue;
				IL_60:
				if (p6ySoOAhhohpbGcygPY.i2IAUFsOOC(ptr, num3, p6ySoOAhhohpbGcygPY.gAIA81kD5P) == 0)
				{
					break;
				}
				num2 = 2;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_78bdbfb54f5c42368a7dbf88905820e8 == 0)
				{
					num2 = 3;
				}
			}
			return num3;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000264C File Offset: 0x0000084C
		public unsafe static int StrLen(byte* ptr)
		{
			return MarshalExtend.Jl5jSEaMk6JOT9V3qud(ptr);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000265C File Offset: 0x0000085C
		public static IntPtr AllocStringArr(string[] strs, int[] nLens, Encoding coding)
		{
			return MarshalExtend.H1AruICqksByR6SmlHJ(strs, strs.Length, nLens, coding);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002670 File Offset: 0x00000870
		public static IntPtr AllocStringArr(string[] strs, int nCount, int[] nLens, Encoding coding)
		{
			int num = 10;
			IntPtr intPtr;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					IntPtr[] array2;
					switch (num2)
					{
					case 1:
						try
						{
							int num3;
							intPtr = MarshalExtend.AllocHGlobal(strs.Length * num3);
							int num4 = 1;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ddf0bbff3ec54ad39c6b2ba58dc80058 == 0)
							{
								num4 = 0;
							}
							for (;;)
							{
								int num5;
								IntPtr intPtr2;
								byte[] array;
								switch (num4)
								{
								case 0:
									goto IL_142;
								case 1:
									num5 = 0;
									num4 = 4;
									continue;
								case 2:
									MarshalExtend.SqnaMqCaBvarTx7P11k(intPtr, num5 * num3, intPtr2, wU5MYDALRCVO01Cje4I.qt5A7O2nTa);
									num4 = 0;
									if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc != 0)
									{
										num4 = 0;
										continue;
									}
									continue;
								case 3:
									intPtr2 = MarshalExtend.PE1JqMCG4xtBCb4mqri(array.Length);
									num4 = 10;
									continue;
								case 4:
									goto IL_105;
								case 5:
									num5++;
									num4 = 9;
									if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_feee416e61094c739ba253659ac2e257 != 0)
									{
										num4 = 4;
										continue;
									}
									continue;
								case 6:
									goto IL_1FA;
								case 7:
									goto IL_194;
								case 8:
									nLens[num5] = array.Length;
									num4 = 3;
									if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2b24b0de55344c2b8aaf8116dbc4d16 == 0)
									{
										num4 = 1;
										continue;
									}
									continue;
								case 9:
									goto IL_105;
								case 10:
									MarshalExtend.SZbcSnCYprsKOkt665c(array, 0, intPtr2, array.Length, KXBQ09Ac5lZ5IM0JSyR.kt5A612lmc);
									num4 = 2;
									continue;
								default:
									goto IL_142;
								}
								IL_99:
								int num6;
								num4 = num6;
								continue;
								IL_105:
								if (num5 >= nCount)
								{
									num6 = 6;
									goto IL_99;
								}
								goto IL_194;
								IL_142:
								array2[num5] = intPtr2;
								num4 = 5;
								continue;
								IL_194:
								array = MarshalExtend.DPQNryCI7gn9Jic2y7d(coding, strs[num5], zgNeuMAuviZtWTl7r56.OIbAE4B1Ls);
								num6 = 8;
								goto IL_99;
							}
							IL_1FA:
							break;
						}
						catch
						{
							int num7 = 7;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_667bd9633593433784ebdd2b3fdc8daf != 0)
							{
								num7 = 6;
							}
							for (;;)
							{
								int num8;
								switch (num7)
								{
								case 0:
									goto IL_28E;
								case 1:
									num8++;
									num7 = 3;
									if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ba3f6bd5a09c47868765e25f534dbf2a == 0)
									{
										num7 = 1;
										continue;
									}
									continue;
								case 2:
									goto IL_2B4;
								case 3:
									break;
								case 4:
									goto IL_38C;
								case 5:
									break;
								case 6:
									MarshalExtend.nnVBJ8CCaL0WJZxbnH4(array2[num8]);
									num7 = 1;
									if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_82de010761f84d069578c758673e6648 != 0)
									{
										num7 = 0;
										continue;
									}
									continue;
								case 7:
									num8 = 0;
									num7 = 5;
									continue;
								case 8:
									goto IL_2B4;
								case 9:
									goto IL_314;
								default:
									goto IL_28E;
								}
								if (num8 >= array2.Length)
								{
									goto IL_314;
								}
								num7 = 8;
								if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_46ba390073ec4df6883860abf17dbf6f != 0)
								{
									num7 = 6;
									continue;
								}
								continue;
								IL_28E:
								MarshalExtend.FreeHGlobal(intPtr);
								num7 = 4;
								if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c4640bbaac7c4988b56f91d1b6b3f1a9 == 0)
								{
									num7 = 2;
									continue;
								}
								continue;
								IL_2B4:
								if (array2[num8] != IntPtr.Zero)
								{
									num7 = 1;
									if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_0e76a731caf34f7495b20ae26aa97571 != 0)
									{
										num7 = 6;
										continue;
									}
									continue;
								}
								IL_314:
								if (intPtr == IntPtr.Zero)
								{
									break;
								}
								num7 = 0;
								if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f72daac7e98440569eaab57fbb9f7bf2 == 0)
								{
									num7 = 0;
								}
							}
							IL_38C:
							break;
						}
						goto IL_3B0;
					case 2:
						goto IL_53;
					case 3:
						intPtr = IntPtr.Zero;
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_483eecf3691e4ef2b23b2d4cb2ca3d52 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						goto IL_4F4;
					case 5:
						goto IL_3D2;
					case 6:
						goto IL_445;
					case 7:
						goto IL_3B0;
					case 8:
						goto IL_491;
					case 9:
						if (strs.Length == 0)
						{
							goto Block_11;
						}
						goto IL_491;
					case 10:
						if (strs != null)
						{
							num2 = 9;
							continue;
						}
						goto IL_53;
					case 11:
						if (nCount > strs.Length)
						{
							num2 = 5;
							continue;
						}
						if (nCount > nLens.Length)
						{
							num2 = 6;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_46ba390073ec4df6883860abf17dbf6f != 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						}
						else
						{
							int num3 = MarshalExtend.qyc6ddCi12wV1KVjnZ4(IreLT7A0Ync4AwEXIgw.thqANbO0eM);
							num2 = 2;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc != 0)
							{
								num2 = 7;
								continue;
							}
							continue;
						}
						break;
					}
					goto Block_1;
					IL_3B0:
					array2 = new IntPtr[nCount];
					num2 = 3;
					continue;
					IL_491:
					if (nCount == 0)
					{
						goto IL_53;
					}
					num2 = 10;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d1f9cbcd89d6464f81f56a1119f034c6 == 0)
					{
						num2 = 11;
					}
				}
				Block_11:
				num = 4;
			}
			Block_1:
			return intPtr;
			IL_53:
			return IntPtr.Zero;
			IL_3D2:
			throw new ArgumentOutOfRangeException(MarshalExtend.g4HAgrC93R6PFrv6xdM(981215493 >> 6 ^ 238018771 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2b24b0de55344c2b8aaf8116dbc4d16));
			IL_445:
			throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1235690808 ^ -65472220 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_db312e48eee84539b805fee2f73a8cde));
			IL_4F4:
			goto IL_53;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002BA0 File Offset: 0x00000DA0
		public static void FreeStringArr(IntPtr ptr, int nCount)
		{
			int num = 6;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					IntPtr intPtr;
					int num3;
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_E4;
					case 1:
						if (intPtr != IntPtr.Zero)
						{
							goto Block_6;
						}
						break;
					case 2:
						return;
					case 3:
						goto IL_E4;
					case 4:
						MarshalExtend.nnVBJ8CCaL0WJZxbnH4(intPtr);
						num2 = 9;
						continue;
					case 5:
						num3 = 0;
						num2 = 3;
						continue;
					case 6:
						num4 = MarshalExtend.qyc6ddCi12wV1KVjnZ4(IreLT7A0Ync4AwEXIgw.thqANbO0eM);
						num2 = 4;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9cbee6d56f49422699718938ff979567 != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 7:
						MarshalExtend.FreeHGlobal(ptr);
						num2 = 2;
						continue;
					case 8:
						goto IL_71;
					case 9:
						break;
					default:
						goto IL_E4;
					}
					num3++;
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8447c7a721f541de9426c754e1b08372 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_71:
					intPtr = MarshalExtend.JCQAP5CtnJlKTkKt4yk(ptr, num3 * num4, n85YNlARpvmucfGlOiq.NhJAkZDxMP);
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_E4:
					if (num3 < nCount)
					{
						goto IL_71;
					}
					num2 = 6;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5c4dec7c475342669cbf3c1205f935ba == 0)
					{
						num2 = 7;
					}
				}
				Block_6:
				num = 4;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002D0C File Offset: 0x00000F0C
		public static long SizeOf(byte[] arr)
		{
			return (long)arr.Length;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002D1C File Offset: 0x00000F1C
		public static int SizeOf(short[] arr)
		{
			return arr.Length * 2;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002D2C File Offset: 0x00000F2C
		public static long SizeOf(ushort[] arr)
		{
			return (long)(arr.Length * 2);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002D3C File Offset: 0x00000F3C
		public static long SizeOf(int[] arr)
		{
			return (long)(arr.Length * 4);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002D4C File Offset: 0x00000F4C
		public static long SizeOf(uint[] arr)
		{
			return (long)(arr.Length * 4);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002D5C File Offset: 0x00000F5C
		public static long SizeOf(float[] arr)
		{
			return (long)(arr.Length * 4);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002D6C File Offset: 0x00000F6C
		// Note: this type is marked as 'beforefieldinit'.
		static MarshalExtend()
		{
			MarshalExtend.JS33iSCx2K5jpmL98mg();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002D7C File Offset: 0x00000F7C
		internal static bool Fevvcca5w6hiI1U9fPa()
		{
			return MarshalExtend.FtjYmMaKjtWSXqxROyL == null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002D90 File Offset: 0x00000F90
		internal static MarshalExtend OkyytHanBiEc7O1BZyW()
		{
			return MarshalExtend.FtjYmMaKjtWSXqxROyL;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002DA0 File Offset: 0x00000FA0
		internal static object chZOx1a37GkqWXhQ5ZI(IntPtr ptr, int nLen, object A_2)
		{
			return MarshalExtend.PtrToString(ptr, nLen, A_2);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002DBC File Offset: 0x00000FBC
		internal static object DQfC5ka193sBVYmLgtd(object A_0)
		{
			return uDLdZ5AqNUaSKY7KefP.i2IAUFsOOC(A_0);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002DD0 File Offset: 0x00000FD0
		internal static int Jl5jSEaMk6JOT9V3qud(IntPtr ptr)
		{
			return MarshalExtend.StrLen(ptr);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002DE4 File Offset: 0x00000FE4
		internal static void boHggyap4IJrYZ2mNoO(IntPtr A_0, object A_1, int A_2, int A_3, object A_4)
		{
			bMqnSHAi2LqA0GNZGR3.i2IAUFsOOC(A_0, A_1, A_2, A_3, A_4);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002E08 File Offset: 0x00001008
		internal static object fvUZoha4FbfwosiVQTK(object A_0, object A_1, int A_2, int A_3, object A_4)
		{
			return q3OdohAGvaJsEOiEnED.i2IAUFsOOC(A_0, A_1, A_2, A_3, A_4);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002E2C File Offset: 0x0000102C
		internal static IntPtr Od7vmaazTBwRpMFmiaC(IntPtr address, IntPtr size, NativeMethods.AllocationType allocationType, NativeMethods.MemoryProtection protect)
		{
			return MarshalExtend.AllocHGlobal(address, size, allocationType, protect);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002E4C File Offset: 0x0000104C
		internal static IntPtr St6PRECHv8wGqvxJQs9(object A_0, object A_1)
		{
			return pOYRBYAtdgcy2Y90KCC.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002E64 File Offset: 0x00001064
		internal static object VPBXZKCAtpe2KBVjhEK(object A_0)
		{
			return lFwkxeAaqLIHo45P9Xf.i2IAUFsOOC(A_0);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002E78 File Offset: 0x00001078
		internal static void Uve8WkCUDD1dmGfGyC3(IntPtr buffer, UIntPtr size)
		{
			MarshalExtend.FreeHGlobal(buffer, size);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002E90 File Offset: 0x00001090
		internal static IntPtr H1AruICqksByR6SmlHJ(object A_0, int nCount, object A_2, object A_3)
		{
			return MarshalExtend.AllocStringArr(A_0, nCount, A_2, A_3);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002EB0 File Offset: 0x000010B0
		internal static object g4HAgrC93R6PFrv6xdM(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002EC4 File Offset: 0x000010C4
		internal static int qyc6ddCi12wV1KVjnZ4(object A_0)
		{
			return IreLT7A0Ync4AwEXIgw.i2IAUFsOOC(A_0);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002ED8 File Offset: 0x000010D8
		internal static object DPQNryCI7gn9Jic2y7d(object A_0, object A_1, object A_2)
		{
			return zgNeuMAuviZtWTl7r56.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002EF4 File Offset: 0x000010F4
		internal static IntPtr PE1JqMCG4xtBCb4mqri(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002F08 File Offset: 0x00001108
		internal static void SZbcSnCYprsKOkt665c(object A_0, int A_1, IntPtr A_2, int A_3, object A_4)
		{
			KXBQ09Ac5lZ5IM0JSyR.i2IAUFsOOC(A_0, A_1, A_2, A_3, A_4);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002F2C File Offset: 0x0000112C
		internal static void SqnaMqCaBvarTx7P11k(IntPtr A_0, int A_1, IntPtr A_2, object A_3)
		{
			wU5MYDALRCVO01Cje4I.i2IAUFsOOC(A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002F4C File Offset: 0x0000114C
		internal static void nnVBJ8CCaL0WJZxbnH4(IntPtr buffer)
		{
			MarshalExtend.FreeHGlobal(buffer);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002F60 File Offset: 0x00001160
		internal static IntPtr JCQAP5CtnJlKTkKt4yk(IntPtr A_0, int A_1, object A_2)
		{
			return n85YNlARpvmucfGlOiq.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002F7C File Offset: 0x0000117C
		internal static void JS33iSCx2K5jpmL98mg()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000002 RID: 2
		internal static MarshalExtend FtjYmMaKjtWSXqxROyL;
	}
}
