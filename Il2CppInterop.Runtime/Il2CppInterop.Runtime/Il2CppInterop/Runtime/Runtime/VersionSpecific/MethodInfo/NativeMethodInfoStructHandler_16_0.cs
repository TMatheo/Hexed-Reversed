using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x02000060 RID: 96
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeMethodInfoStructHandler_16_0 : INativeMethodInfoStructHandler, INativeStructHandler
	{
		// Token: 0x060003CE RID: 974 RVA: 0x0000E94C File Offset: 0x0000CB4C
		public int Size()
		{
			return sizeof(NativeMethodInfoStructHandler_16_0.Il2CppMethodInfo_16_0);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000E95C File Offset: 0x0000CB5C
		public unsafe INativeMethodInfoStruct CreateNewStruct()
		{
			NativeMethodInfoStructHandler_16_0.Il2CppMethodInfo_16_0* ptr2;
			IntPtr ptr = ptr2 = NativeMethodInfoStructHandler_16_0.FXd7qCNQDT60aicRlYy(this.Size());
			*ptr2 = default(NativeMethodInfoStructHandler_16_0.Il2CppMethodInfo_16_0);
			return new NativeMethodInfoStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000E98C File Offset: 0x0000CB8C
		public unsafe INativeMethodInfoStruct Wrap(Il2CppMethodInfo* ptr)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (ptr != null)
					{
						goto IL_54;
					}
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_570d4e075bf443fcbaca8db32e007291 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return null;
			IL_54:
			return new NativeMethodInfoStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000E9F4 File Offset: 0x0000CBF4
		public NativeMethodInfoStructHandler_16_0()
		{
			NativeMethodInfoStructHandler_16_0.S3Tc4wN2PZcEfqua5Mt();
			NativeMethodInfoStructHandler_16_0.H4UOnoNyC35YM7AIVWO();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_483eecf3691e4ef2b23b2d4cb2ca3d52 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000EA58 File Offset: 0x0000CC58
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethodInfoStructHandler_16_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000EA68 File Offset: 0x0000CC68
		internal static IntPtr FXd7qCNQDT60aicRlYy(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000EA7C File Offset: 0x0000CC7C
		internal static bool ex1PrGNencclbYauwIh()
		{
			return NativeMethodInfoStructHandler_16_0.lbhJODNwpXYE8UPQb9s == null;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000EA90 File Offset: 0x0000CC90
		internal static NativeMethodInfoStructHandler_16_0 rDTubaNsxlNyLnx9hCB()
		{
			return NativeMethodInfoStructHandler_16_0.lbhJODNwpXYE8UPQb9s;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
		internal static void S3Tc4wN2PZcEfqua5Mt()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000EAB0 File Offset: 0x0000CCB0
		internal static void H4UOnoNyC35YM7AIVWO()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x04000148 RID: 328
		internal static NativeMethodInfoStructHandler_16_0 lbhJODNwpXYE8UPQb9s;

		// Token: 0x02000061 RID: 97
		internal struct Il2CppMethodInfo_16_0
		{
			// Token: 0x04000149 RID: 329
			public unsafe void* method;

			// Token: 0x0400014A RID: 330
			public unsafe void* invoker_method;

			// Token: 0x0400014B RID: 331
			public unsafe byte* name;

			// Token: 0x0400014C RID: 332
			public unsafe Il2CppClass* declaring_type;

			// Token: 0x0400014D RID: 333
			public unsafe Il2CppTypeStruct* return_type;

			// Token: 0x0400014E RID: 334
			public unsafe Il2CppParameterInfo* parameters;

			// Token: 0x0400014F RID: 335
			public unsafe void* runtime_data;

			// Token: 0x04000150 RID: 336
			public unsafe void* generic_data;

			// Token: 0x04000151 RID: 337
			public int customAttributeIndex;

			// Token: 0x04000152 RID: 338
			public uint token;

			// Token: 0x04000153 RID: 339
			public ushort flags;

			// Token: 0x04000154 RID: 340
			public ushort iflags;

			// Token: 0x04000155 RID: 341
			public ushort slot;

			// Token: 0x04000156 RID: 342
			public byte parameters_count;

			// Token: 0x04000157 RID: 343
			public NativeMethodInfoStructHandler_16_0.Il2CppMethodInfo_16_0.Bitfield0 _bitfield0;

			// Token: 0x02000062 RID: 98
			internal enum Bitfield0 : byte
			{
				// Token: 0x04000159 RID: 345
				BIT_is_generic,
				// Token: 0x0400015A RID: 346
				is_generic,
				// Token: 0x0400015B RID: 347
				BIT_is_inflated = 1,
				// Token: 0x0400015C RID: 348
				is_inflated
			}
		}

		// Token: 0x02000063 RID: 99
		internal class NativeStructWrapper : INativeMethodInfoStruct, INativeStruct
		{
			// Token: 0x060003D8 RID: 984 RVA: 0x00019A7C File Offset: 0x00017C7C
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeMethodInfoStructHandler_16_0.NativeStructWrapper.F5bELAWaWkMuKacYACW();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56c162609824bd799f0a7b9a8c33c89 != 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						return;
					}
					this.<Pointer>k__BackingField = ptr;
					num = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f7e83c7c87bd4de9b4cb2b7f339254ad == 0)
					{
						num = 1;
					}
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x060003D9 RID: 985 RVA: 0x00019B0C File Offset: 0x00017D0C
			private unsafe NativeMethodInfoStructHandler_16_0.Il2CppMethodInfo_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x060003DA RID: 986 RVA: 0x00019B1C File Offset: 0x00017D1C
			public IntPtr Pointer { get; }

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x060003DB RID: 987 RVA: 0x00019B2C File Offset: 0x00017D2C
			public unsafe Il2CppMethodInfo* MethodInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x060003DC RID: 988 RVA: 0x00019B3C File Offset: 0x00017D3C
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x060003DD RID: 989 RVA: 0x00019B54 File Offset: 0x00017D54
			public unsafe ref ushort Slot
			{
				get
				{
					return ref this._->slot;
				}
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x060003DE RID: 990 RVA: 0x00019B68 File Offset: 0x00017D68
			public unsafe ref IntPtr MethodPointer
			{
				get
				{
					return ref *(IntPtr*)(&this._->method);
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x060003DF RID: 991 RVA: 0x00019B80 File Offset: 0x00017D80
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->declaring_type;
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x060003E0 RID: 992 RVA: 0x00019B94 File Offset: 0x00017D94
			public unsafe ref IntPtr InvokerMethod
			{
				get
				{
					return ref *(IntPtr*)(&this._->invoker_method);
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x060003E1 RID: 993 RVA: 0x00019BAC File Offset: 0x00017DAC
			public unsafe ref Il2CppTypeStruct* ReturnType
			{
				get
				{
					return ref this._->return_type;
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060003E2 RID: 994 RVA: 0x00019BC0 File Offset: 0x00017DC0
			public unsafe ref Il2CppMethodFlags Flags
			{
				get
				{
					return ref *(Il2CppMethodFlags*)(&this._->flags);
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060003E3 RID: 995 RVA: 0x00019BD8 File Offset: 0x00017DD8
			public unsafe ref byte ParametersCount
			{
				get
				{
					return ref this._->parameters_count;
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060003E4 RID: 996 RVA: 0x00019BEC File Offset: 0x00017DEC
			public unsafe ref Il2CppParameterInfo* Parameters
			{
				get
				{
					return ref this._->parameters;
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x060003E5 RID: 997 RVA: 0x00019C00 File Offset: 0x00017E00
			public unsafe ref uint Token
			{
				get
				{
					return ref this._->token;
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060003E6 RID: 998 RVA: 0x00019C14 File Offset: 0x00017E14
			// (set) Token: 0x060003E7 RID: 999 RVA: 0x00019C2C File Offset: 0x00017E2C
			public bool IsGeneric
			{
				get
				{
					return NativeMethodInfoStructHandler_16_0.NativeStructWrapper.IxaGpbWCWMqSeQycexl(this, NativeMethodInfoStructHandler_16_0.NativeStructWrapper._bitfield0offset, 0);
				}
				set
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
							NativeMethodInfoStructHandler_16_0.NativeStructWrapper.vD7rMuWt5jooA0FRTjI(this, NativeMethodInfoStructHandler_16_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_dbbda98ba6574101bc623ad559f7b5a3 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00019C90 File Offset: 0x00017E90
			// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00019CA8 File Offset: 0x00017EA8
			public bool IsInflated
			{
				get
				{
					return this.CheckBit(NativeMethodInfoStructHandler_16_0.NativeStructWrapper._bitfield0offset, 1);
				}
				set
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
							NativeMethodInfoStructHandler_16_0.NativeStructWrapper.vD7rMuWt5jooA0FRTjI(this, NativeMethodInfoStructHandler_16_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7b2fff018dbf4cfe8ef41e2d123dc629 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x060003EA RID: 1002 RVA: 0x00019D0C File Offset: 0x00017F0C
			// (set) Token: 0x060003EB RID: 1003 RVA: 0x00019D18 File Offset: 0x00017F18
			public bool IsMarshalledFromNative
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			// Token: 0x060003EC RID: 1004 RVA: 0x00019D24 File Offset: 0x00017F24
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 5;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
					{
						IntPtr intPtr;
						NativeMethodInfoStructHandler_16_0.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_01c6e15d1fd54ef9b78826bf2944de2a != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					case 2:
						NativeMethodInfoStructHandler_16_0.NativeStructWrapper.qlVjPtWhMU2ZTVMURY1();
						num2 = 3;
						continue;
					case 3:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeMethodInfoStructHandler_16_0.Il2CppMethodInfo_16_0>(hIDAYxH6DWLHIthQgC.gSCeTtiku(1887176262 ^ 2126122519 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2b24b0de55344c2b8aaf8116dbc4d16));
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_483eecf3691e4ef2b23b2d4cb2ca3d52 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					case 4:
						NativeMethodInfoStructHandler_16_0.NativeStructWrapper.F5bELAWaWkMuKacYACW();
						num2 = 2;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_667bd9633593433784ebdd2b3fdc8daf != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 5:
						NativeMethodInfoStructHandler_16_0.NativeStructWrapper.tEJ4gRWxjyCAbhIV6Tn();
						num2 = 4;
						continue;
					}
					break;
				}
			}

			// Token: 0x060003ED RID: 1005 RVA: 0x00019E20 File Offset: 0x00018020
			internal static void F5bELAWaWkMuKacYACW()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060003EE RID: 1006 RVA: 0x00019E30 File Offset: 0x00018030
			internal static bool kjGkqHWGmVjcVh8FxrY()
			{
				return NativeMethodInfoStructHandler_16_0.NativeStructWrapper.oZ4jgAWIop4ObEVZHuk == null;
			}

			// Token: 0x060003EF RID: 1007 RVA: 0x00019E44 File Offset: 0x00018044
			internal static NativeMethodInfoStructHandler_16_0.NativeStructWrapper fIZvwdWYJGcnqS8cqrq()
			{
				return NativeMethodInfoStructHandler_16_0.NativeStructWrapper.oZ4jgAWIop4ObEVZHuk;
			}

			// Token: 0x060003F0 RID: 1008 RVA: 0x00019E54 File Offset: 0x00018054
			internal static bool IxaGpbWCWMqSeQycexl(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060003F1 RID: 1009 RVA: 0x00019E70 File Offset: 0x00018070
			internal static void vD7rMuWt5jooA0FRTjI(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x060003F2 RID: 1010 RVA: 0x00019E90 File Offset: 0x00018090
			internal static void tEJ4gRWxjyCAbhIV6Tn()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x060003F3 RID: 1011 RVA: 0x00019EA0 File Offset: 0x000180A0
			internal static void qlVjPtWhMU2ZTVMURY1()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x0400015D RID: 349
			private static readonly int _bitfield0offset;

			// Token: 0x0400015F RID: 351
			internal static object oZ4jgAWIop4ObEVZHuk;
		}
	}
}
