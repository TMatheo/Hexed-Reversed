using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x02000064 RID: 100
	[ApplicableToUnityVersionsSince("5.3.6")]
	public class NativeMethodInfoStructHandler_21_0 : INativeMethodInfoStructHandler, INativeStructHandler
	{
		// Token: 0x060003F4 RID: 1012 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		public int Size()
		{
			return sizeof(NativeMethodInfoStructHandler_21_0.Il2CppMethodInfo_21_0);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000EAD0 File Offset: 0x0000CCD0
		public unsafe INativeMethodInfoStruct CreateNewStruct()
		{
			NativeMethodInfoStructHandler_21_0.Il2CppMethodInfo_21_0* ptr2;
			IntPtr ptr = ptr2 = NativeMethodInfoStructHandler_21_0.YrDGSSNV7dcoLnqBg2s(this.Size());
			*ptr2 = default(NativeMethodInfoStructHandler_21_0.Il2CppMethodInfo_21_0);
			return new NativeMethodInfoStructHandler_21_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000EB00 File Offset: 0x0000CD00
		public unsafe INativeMethodInfoStruct Wrap(Il2CppMethodInfo* ptr)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					goto IL_2B;
				case 1:
					if (ptr != null)
					{
						goto IL_2D;
					}
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bd64431fd05f4961aa9b79e5bd243164 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeMethodInfoStructHandler_21_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000EB68 File Offset: 0x0000CD68
		public NativeMethodInfoStructHandler_21_0()
		{
			NativeMethodInfoStructHandler_21_0.YEIQRgNOonD9GpftOEI();
			NativeMethodInfoStructHandler_21_0.q5oJC8NXQdkK4eVacf5();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000EBCC File Offset: 0x0000CDCC
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethodInfoStructHandler_21_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000EBDC File Offset: 0x0000CDDC
		internal static IntPtr YrDGSSNV7dcoLnqBg2s(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000EBF0 File Offset: 0x0000CDF0
		internal static bool gDuMjjNgGqmjEPTk4TQ()
		{
			return NativeMethodInfoStructHandler_21_0.iPrkmrNSHUWggoOCm2B == null;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000EC04 File Offset: 0x0000CE04
		internal static NativeMethodInfoStructHandler_21_0 ShEKVHNl9CdJ5JeNaQv()
		{
			return NativeMethodInfoStructHandler_21_0.iPrkmrNSHUWggoOCm2B;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000EC14 File Offset: 0x0000CE14
		internal static void YEIQRgNOonD9GpftOEI()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000EC24 File Offset: 0x0000CE24
		internal static void q5oJC8NXQdkK4eVacf5()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x04000160 RID: 352
		internal static NativeMethodInfoStructHandler_21_0 iPrkmrNSHUWggoOCm2B;

		// Token: 0x02000065 RID: 101
		internal struct Il2CppMethodInfo_21_0
		{
			// Token: 0x04000161 RID: 353
			public unsafe void* methodPointer;

			// Token: 0x04000162 RID: 354
			public unsafe void* invoker_method;

			// Token: 0x04000163 RID: 355
			public unsafe byte* name;

			// Token: 0x04000164 RID: 356
			public unsafe Il2CppClass* declaring_type;

			// Token: 0x04000165 RID: 357
			public unsafe Il2CppTypeStruct* return_type;

			// Token: 0x04000166 RID: 358
			public unsafe Il2CppParameterInfo* parameters;

			// Token: 0x04000167 RID: 359
			public unsafe void* runtime_data;

			// Token: 0x04000168 RID: 360
			public unsafe void* generic_data;

			// Token: 0x04000169 RID: 361
			public int customAttributeIndex;

			// Token: 0x0400016A RID: 362
			public uint token;

			// Token: 0x0400016B RID: 363
			public ushort flags;

			// Token: 0x0400016C RID: 364
			public ushort iflags;

			// Token: 0x0400016D RID: 365
			public ushort slot;

			// Token: 0x0400016E RID: 366
			public byte parameters_count;

			// Token: 0x0400016F RID: 367
			public NativeMethodInfoStructHandler_21_0.Il2CppMethodInfo_21_0.Bitfield0 _bitfield0;

			// Token: 0x02000066 RID: 102
			internal enum Bitfield0 : byte
			{
				// Token: 0x04000171 RID: 369
				BIT_is_generic,
				// Token: 0x04000172 RID: 370
				is_generic,
				// Token: 0x04000173 RID: 371
				BIT_is_inflated = 1,
				// Token: 0x04000174 RID: 372
				is_inflated
			}
		}

		// Token: 0x02000067 RID: 103
		internal class NativeStructWrapper : INativeMethodInfoStruct, INativeStruct
		{
			// Token: 0x060003FE RID: 1022 RVA: 0x00019EB0 File Offset: 0x000180B0
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeMethodInfoStructHandler_21_0.NativeStructWrapper.pUxfJKW6LRBCrqHF3xi();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2f48f5515514b5a9a5feed6dc9a8dce != 0)
				{
					num = 1;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.<Pointer>k__BackingField = ptr;
						num = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d691a76a9c4746c9a1a67e34c67ca64b == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x060003FF RID: 1023 RVA: 0x00019F40 File Offset: 0x00018140
			private unsafe NativeMethodInfoStructHandler_21_0.Il2CppMethodInfo_21_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x06000400 RID: 1024 RVA: 0x00019F50 File Offset: 0x00018150
			public IntPtr Pointer { get; }

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x06000401 RID: 1025 RVA: 0x00019F60 File Offset: 0x00018160
			public unsafe Il2CppMethodInfo* MethodInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x06000402 RID: 1026 RVA: 0x00019F70 File Offset: 0x00018170
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x06000403 RID: 1027 RVA: 0x00019F88 File Offset: 0x00018188
			public unsafe ref ushort Slot
			{
				get
				{
					return ref this._->slot;
				}
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x06000404 RID: 1028 RVA: 0x00019F9C File Offset: 0x0001819C
			public unsafe ref IntPtr MethodPointer
			{
				get
				{
					return ref *(IntPtr*)(&this._->methodPointer);
				}
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x06000405 RID: 1029 RVA: 0x00019FB4 File Offset: 0x000181B4
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->declaring_type;
				}
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x06000406 RID: 1030 RVA: 0x00019FC8 File Offset: 0x000181C8
			public unsafe ref IntPtr InvokerMethod
			{
				get
				{
					return ref *(IntPtr*)(&this._->invoker_method);
				}
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x06000407 RID: 1031 RVA: 0x00019FE0 File Offset: 0x000181E0
			public unsafe ref Il2CppTypeStruct* ReturnType
			{
				get
				{
					return ref this._->return_type;
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x06000408 RID: 1032 RVA: 0x00019FF4 File Offset: 0x000181F4
			public unsafe ref Il2CppMethodFlags Flags
			{
				get
				{
					return ref *(Il2CppMethodFlags*)(&this._->flags);
				}
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000409 RID: 1033 RVA: 0x0001A00C File Offset: 0x0001820C
			public unsafe ref byte ParametersCount
			{
				get
				{
					return ref this._->parameters_count;
				}
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x0600040A RID: 1034 RVA: 0x0001A020 File Offset: 0x00018220
			public unsafe ref Il2CppParameterInfo* Parameters
			{
				get
				{
					return ref this._->parameters;
				}
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x0600040B RID: 1035 RVA: 0x0001A034 File Offset: 0x00018234
			public unsafe ref uint Token
			{
				get
				{
					return ref this._->token;
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x0600040C RID: 1036 RVA: 0x0001A048 File Offset: 0x00018248
			// (set) Token: 0x0600040D RID: 1037 RVA: 0x0001A060 File Offset: 0x00018260
			public bool IsGeneric
			{
				get
				{
					return NativeMethodInfoStructHandler_21_0.NativeStructWrapper.CpBVIjWLDFuI8iLU9A0(this, NativeMethodInfoStructHandler_21_0.NativeStructWrapper._bitfield0offset, 0);
				}
				set
				{
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							NativeMethodInfoStructHandler_21_0.NativeStructWrapper.kKMYjqW7rpVLdqDZB5p(this, NativeMethodInfoStructHandler_21_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_dbbda98ba6574101bc623ad559f7b5a3 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x0600040E RID: 1038 RVA: 0x0001A0C4 File Offset: 0x000182C4
			// (set) Token: 0x0600040F RID: 1039 RVA: 0x0001A0DC File Offset: 0x000182DC
			public bool IsInflated
			{
				get
				{
					return NativeMethodInfoStructHandler_21_0.NativeStructWrapper.CpBVIjWLDFuI8iLU9A0(this, NativeMethodInfoStructHandler_21_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeMethodInfoStructHandler_21_0.NativeStructWrapper.kKMYjqW7rpVLdqDZB5p(this, NativeMethodInfoStructHandler_21_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9cbee6d56f49422699718938ff979567 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x06000410 RID: 1040 RVA: 0x0001A140 File Offset: 0x00018340
			// (set) Token: 0x06000411 RID: 1041 RVA: 0x0001A14C File Offset: 0x0001834C
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

			// Token: 0x06000412 RID: 1042 RVA: 0x0001A158 File Offset: 0x00018358
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						NativeMethodInfoStructHandler_21_0.NativeStructWrapper.pUxfJKW6LRBCrqHF3xi();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ddf0bbff3ec54ad39c6b2ba58dc80058 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						hIDAYxH6DWLHIthQgC.zSLipEDdx();
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_944294969d634011bf30e3f4f506a31e == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
					{
						IntPtr intPtr;
						NativeMethodInfoStructHandler_21_0.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 4;
						continue;
					}
					case 4:
						return;
					case 5:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeMethodInfoStructHandler_21_0.Il2CppMethodInfo_21_0>(NativeMethodInfoStructHandler_21_0.NativeStructWrapper.WB7ypgWkeSe6Et7K3vi(-1887629927 ^ -323840298 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bd64431fd05f4961aa9b79e5bd243164));
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e236d804047744298c2380563ba7eca0 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					}
					NativeMethodInfoStructHandler_21_0.NativeStructWrapper.fxGB7SWRtIlRWQvh01T();
					num2 = 5;
				}
			}

			// Token: 0x06000413 RID: 1043 RVA: 0x0001A254 File Offset: 0x00018454
			internal static void pUxfJKW6LRBCrqHF3xi()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000414 RID: 1044 RVA: 0x0001A264 File Offset: 0x00018464
			internal static bool FLXkIGWEHKZPRPWwth5()
			{
				return NativeMethodInfoStructHandler_21_0.NativeStructWrapper.A8IQ2ZWuaXXZwEU4rSL == null;
			}

			// Token: 0x06000415 RID: 1045 RVA: 0x0001A278 File Offset: 0x00018478
			internal static NativeMethodInfoStructHandler_21_0.NativeStructWrapper VucENmWcL2V63lKN3gV()
			{
				return NativeMethodInfoStructHandler_21_0.NativeStructWrapper.A8IQ2ZWuaXXZwEU4rSL;
			}

			// Token: 0x06000416 RID: 1046 RVA: 0x0001A288 File Offset: 0x00018488
			internal static bool CpBVIjWLDFuI8iLU9A0(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000417 RID: 1047 RVA: 0x0001A2A4 File Offset: 0x000184A4
			internal static void kKMYjqW7rpVLdqDZB5p(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000418 RID: 1048 RVA: 0x0001A2C4 File Offset: 0x000184C4
			internal static void fxGB7SWRtIlRWQvh01T()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000419 RID: 1049 RVA: 0x0001A2D4 File Offset: 0x000184D4
			internal static object WB7ypgWkeSe6Et7K3vi(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000175 RID: 373
			private static readonly int _bitfield0offset;

			// Token: 0x04000177 RID: 375
			internal static object A8IQ2ZWuaXXZwEU4rSL;
		}
	}
}
