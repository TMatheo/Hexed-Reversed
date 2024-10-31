using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x02000066 RID: 102
	[ApplicableToUnityVersionsSince("2018.1.0")]
	public class NativeMethodInfoStructHandler_24_0 : INativeMethodInfoStructHandler, INativeStructHandler
	{
		// Token: 0x060003FB RID: 1019 RVA: 0x0000E054 File Offset: 0x0000C254
		public int Size()
		{
			return sizeof(NativeMethodInfoStructHandler_24_0.Il2CppMethodInfo_24_0);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000E064 File Offset: 0x0000C264
		public unsafe INativeMethodInfoStruct CreateNewStruct()
		{
			NativeMethodInfoStructHandler_24_0.Il2CppMethodInfo_24_0* ptr2;
			IntPtr ptr = ptr2 = NativeMethodInfoStructHandler_24_0.uvTX7X8fheI2ftiTOQx(this.Size());
			*ptr2 = default(NativeMethodInfoStructHandler_24_0.Il2CppMethodInfo_24_0);
			return new NativeMethodInfoStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000E094 File Offset: 0x0000C294
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5395ed2b7ead4e349835ba3f56e39138 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeMethodInfoStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000E0FC File Offset: 0x0000C2FC
		public NativeMethodInfoStructHandler_24_0()
		{
			NativeMethodInfoStructHandler_24_0.vh7YDZ81mrQbLj9p6Rf();
			NativeMethodInfoStructHandler_24_0.xlhxyF8FmLAqZKohWBa();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5a2f191df3714123bdeb9f5f4b416da9 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000E160 File Offset: 0x0000C360
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethodInfoStructHandler_24_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000E170 File Offset: 0x0000C370
		internal static IntPtr uvTX7X8fheI2ftiTOQx(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000E184 File Offset: 0x0000C384
		internal static bool QIJGMY84junAG2EvLrs()
		{
			return NativeMethodInfoStructHandler_24_0.JKPMF68PoKGEqAckH0o == null;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000E198 File Offset: 0x0000C398
		internal static NativeMethodInfoStructHandler_24_0 Oj2Q2s83fF4StQhLC9t()
		{
			return NativeMethodInfoStructHandler_24_0.JKPMF68PoKGEqAckH0o;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		internal static void vh7YDZ81mrQbLj9p6Rf()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000E1B8 File Offset: 0x0000C3B8
		internal static void xlhxyF8FmLAqZKohWBa()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x0400016D RID: 365
		internal static NativeMethodInfoStructHandler_24_0 JKPMF68PoKGEqAckH0o;

		// Token: 0x02000067 RID: 103
		internal struct Il2CppMethodInfo_24_0
		{
			// Token: 0x0400016E RID: 366
			public unsafe void* methodPointer;

			// Token: 0x0400016F RID: 367
			public unsafe void* invoker_method;

			// Token: 0x04000170 RID: 368
			public unsafe byte* name;

			// Token: 0x04000171 RID: 369
			public unsafe Il2CppClass* klass;

			// Token: 0x04000172 RID: 370
			public unsafe Il2CppTypeStruct* return_type;

			// Token: 0x04000173 RID: 371
			public unsafe Il2CppParameterInfo* parameters;

			// Token: 0x04000174 RID: 372
			public unsafe void* runtime_data;

			// Token: 0x04000175 RID: 373
			public unsafe void* generic_data;

			// Token: 0x04000176 RID: 374
			public int customAttributeIndex;

			// Token: 0x04000177 RID: 375
			public uint token;

			// Token: 0x04000178 RID: 376
			public ushort flags;

			// Token: 0x04000179 RID: 377
			public ushort iflags;

			// Token: 0x0400017A RID: 378
			public ushort slot;

			// Token: 0x0400017B RID: 379
			public byte parameters_count;

			// Token: 0x0400017C RID: 380
			public NativeMethodInfoStructHandler_24_0.Il2CppMethodInfo_24_0.Bitfield0 _bitfield0;

			// Token: 0x02000068 RID: 104
			internal enum Bitfield0 : byte
			{
				// Token: 0x0400017E RID: 382
				BIT_is_generic,
				// Token: 0x0400017F RID: 383
				is_generic,
				// Token: 0x04000180 RID: 384
				BIT_is_inflated = 1,
				// Token: 0x04000181 RID: 385
				is_inflated,
				// Token: 0x04000182 RID: 386
				BIT_wrapper_type = 2,
				// Token: 0x04000183 RID: 387
				wrapper_type = 4,
				// Token: 0x04000184 RID: 388
				BIT_is_marshaled_from_native = 3,
				// Token: 0x04000185 RID: 389
				is_marshaled_from_native = 8
			}
		}

		// Token: 0x02000069 RID: 105
		internal class NativeStructWrapper : INativeMethodInfoStruct, INativeStruct
		{
			// Token: 0x06000405 RID: 1029 RVA: 0x0001960C File Offset: 0x0001780C
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeMethodInfoStructHandler_24_0.NativeStructWrapper.r7MZDXsaEVINx8AvFOU();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4da80845ebf7410ebbf942336f5ee27b == 0)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bac7568f2bc04130b6b980225b2cc409 == 0)
					{
						num = 0;
					}
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x06000406 RID: 1030 RVA: 0x0001969C File Offset: 0x0001789C
			private unsafe NativeMethodInfoStructHandler_24_0.Il2CppMethodInfo_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x06000407 RID: 1031 RVA: 0x000196AC File Offset: 0x000178AC
			public IntPtr Pointer { get; }

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x06000408 RID: 1032 RVA: 0x000196BC File Offset: 0x000178BC
			public unsafe Il2CppMethodInfo* MethodInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x06000409 RID: 1033 RVA: 0x000196CC File Offset: 0x000178CC
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x0600040A RID: 1034 RVA: 0x000196E4 File Offset: 0x000178E4
			public unsafe ref ushort Slot
			{
				get
				{
					return ref this._->slot;
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x0600040B RID: 1035 RVA: 0x000196F8 File Offset: 0x000178F8
			public unsafe ref IntPtr MethodPointer
			{
				get
				{
					return ref *(IntPtr*)(&this._->methodPointer);
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x0600040C RID: 1036 RVA: 0x00019710 File Offset: 0x00017910
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x0600040D RID: 1037 RVA: 0x00019724 File Offset: 0x00017924
			public unsafe ref IntPtr InvokerMethod
			{
				get
				{
					return ref *(IntPtr*)(&this._->invoker_method);
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x0600040E RID: 1038 RVA: 0x0001973C File Offset: 0x0001793C
			public unsafe ref Il2CppTypeStruct* ReturnType
			{
				get
				{
					return ref this._->return_type;
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x0600040F RID: 1039 RVA: 0x00019750 File Offset: 0x00017950
			public unsafe ref Il2CppMethodFlags Flags
			{
				get
				{
					return ref *(Il2CppMethodFlags*)(&this._->flags);
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x06000410 RID: 1040 RVA: 0x00019768 File Offset: 0x00017968
			public unsafe ref byte ParametersCount
			{
				get
				{
					return ref this._->parameters_count;
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x06000411 RID: 1041 RVA: 0x0001977C File Offset: 0x0001797C
			public unsafe ref Il2CppParameterInfo* Parameters
			{
				get
				{
					return ref this._->parameters;
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x06000412 RID: 1042 RVA: 0x00019790 File Offset: 0x00017990
			public unsafe ref uint Token
			{
				get
				{
					return ref this._->token;
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x06000413 RID: 1043 RVA: 0x000197A4 File Offset: 0x000179A4
			// (set) Token: 0x06000414 RID: 1044 RVA: 0x000197BC File Offset: 0x000179BC
			public bool IsGeneric
			{
				get
				{
					return NativeMethodInfoStructHandler_24_0.NativeStructWrapper.f750XYsZYgslLEC7jDc(this, NativeMethodInfoStructHandler_24_0.NativeStructWrapper._bitfield0offset, 0);
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
							this.SetBit(NativeMethodInfoStructHandler_24_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7ac65c3fd4cb4629a8b893be89aed17d == 0)
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

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x06000415 RID: 1045 RVA: 0x00019820 File Offset: 0x00017A20
			// (set) Token: 0x06000416 RID: 1046 RVA: 0x00019838 File Offset: 0x00017A38
			public bool IsInflated
			{
				get
				{
					return NativeMethodInfoStructHandler_24_0.NativeStructWrapper.f750XYsZYgslLEC7jDc(this, NativeMethodInfoStructHandler_24_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeMethodInfoStructHandler_24_0.NativeStructWrapper.YqfAZYsz3UHdSpwfm9d(this, NativeMethodInfoStructHandler_24_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ffe1ad8c1cf94bc78c25e67b0264547e != 0)
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

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x06000417 RID: 1047 RVA: 0x0001989C File Offset: 0x00017A9C
			// (set) Token: 0x06000418 RID: 1048 RVA: 0x000198B4 File Offset: 0x00017AB4
			public bool IsMarshalledFromNative
			{
				get
				{
					return NativeMethodInfoStructHandler_24_0.NativeStructWrapper.f750XYsZYgslLEC7jDc(this, NativeMethodInfoStructHandler_24_0.NativeStructWrapper._bitfield0offset, 3);
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
							NativeMethodInfoStructHandler_24_0.NativeStructWrapper.YqfAZYsz3UHdSpwfm9d(this, NativeMethodInfoStructHandler_24_0.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_43cc35cb254148318955c7f83ade60f1 == 0)
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

			// Token: 0x06000419 RID: 1049 RVA: 0x00019918 File Offset: 0x00017B18
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 3;
				int num2 = num;
				for (;;)
				{
					IntPtr intPtr;
					switch (num2)
					{
					case 1:
						return;
					case 2:
						NativeMethodInfoStructHandler_24_0.NativeStructWrapper.O0jYDPSq0ANKTbixRLx();
						num2 = 5;
						continue;
					case 3:
						NativeMethodInfoStructHandler_24_0.NativeStructWrapper.EmMHBpSlCWedvW3u53G();
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_26479210ae524f22ae1fe060a08fdd55 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						intPtr = Marshal.OffsetOf<NativeMethodInfoStructHandler_24_0.Il2CppMethodInfo_24_0>(NativeMethodInfoStructHandler_24_0.NativeStructWrapper.PoUX4wS5CilMf2fttyE(-1130020106 << 5 ^ -1640146711 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_420bdc7f003c47439a9f8331e71194a1));
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c04403f838344b38b3a8911774a446ea != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						NativeMethodInfoStructHandler_24_0.NativeStructWrapper.r7MZDXsaEVINx8AvFOU();
						num2 = 4;
						continue;
					}
					NativeMethodInfoStructHandler_24_0.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3566f8d0a0994626b4e9fd660bc94d73 == 0)
					{
						num2 = 1;
					}
				}
			}

			// Token: 0x0600041A RID: 1050 RVA: 0x00019A1C File Offset: 0x00017C1C
			internal static void r7MZDXsaEVINx8AvFOU()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x0600041B RID: 1051 RVA: 0x00019A2C File Offset: 0x00017C2C
			internal static bool JwjiJese0G6Yyet1hNF()
			{
				return NativeMethodInfoStructHandler_24_0.NativeStructWrapper.mYRNdssQqaLpQ0TUQG8 == null;
			}

			// Token: 0x0600041C RID: 1052 RVA: 0x00019A40 File Offset: 0x00017C40
			internal static NativeMethodInfoStructHandler_24_0.NativeStructWrapper POMQBysKWfRHQmXPMw2()
			{
				return NativeMethodInfoStructHandler_24_0.NativeStructWrapper.mYRNdssQqaLpQ0TUQG8;
			}

			// Token: 0x0600041D RID: 1053 RVA: 0x00019A50 File Offset: 0x00017C50
			internal static bool f750XYsZYgslLEC7jDc(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x0600041E RID: 1054 RVA: 0x00019A6C File Offset: 0x00017C6C
			internal static void YqfAZYsz3UHdSpwfm9d(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x0600041F RID: 1055 RVA: 0x00019A8C File Offset: 0x00017C8C
			internal static void EmMHBpSlCWedvW3u53G()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000420 RID: 1056 RVA: 0x00019A9C File Offset: 0x00017C9C
			internal static void O0jYDPSq0ANKTbixRLx()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x00019AAC File Offset: 0x00017CAC
			internal static object PoUX4wS5CilMf2fttyE(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000186 RID: 390
			private static readonly int _bitfield0offset;

			// Token: 0x04000188 RID: 392
			private static object mYRNdssQqaLpQ0TUQG8;
		}
	}
}
