using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x0200006A RID: 106
	[ApplicableToUnityVersionsSince("2018.3.0")]
	public class NativeMethodInfoStructHandler_24_1 : INativeMethodInfoStructHandler, INativeStructHandler
	{
		// Token: 0x06000422 RID: 1058 RVA: 0x0000E1C8 File Offset: 0x0000C3C8
		public int Size()
		{
			return sizeof(NativeMethodInfoStructHandler_24_1.Il2CppMethodInfo_24_1);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		public unsafe INativeMethodInfoStruct CreateNewStruct()
		{
			NativeMethodInfoStructHandler_24_1.Il2CppMethodInfo_24_1* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeMethodInfoStructHandler_24_1.Il2CppMethodInfo_24_1);
			return new NativeMethodInfoStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000E208 File Offset: 0x0000C408
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeMethodInfoStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000E270 File Offset: 0x0000C470
		public NativeMethodInfoStructHandler_24_1()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeMethodInfoStructHandler_24_1.E85oR88CYXfOEM5sbXk();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_856ffe7e0c9b4de88d71070d175d49fd != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000E2D4 File Offset: 0x0000C4D4
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethodInfoStructHandler_24_1()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000E2E4 File Offset: 0x0000C4E4
		internal static bool fIS6Ev8MoEbZy1jGxhu()
		{
			return NativeMethodInfoStructHandler_24_1.tETLqR8RjKuvxSK72r4 == null;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		internal static NativeMethodInfoStructHandler_24_1 pmZow88Wr8UmRBc9qsK()
		{
			return NativeMethodInfoStructHandler_24_1.tETLqR8RjKuvxSK72r4;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000E308 File Offset: 0x0000C508
		internal static void E85oR88CYXfOEM5sbXk()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x04000189 RID: 393
		private static NativeMethodInfoStructHandler_24_1 tETLqR8RjKuvxSK72r4;

		// Token: 0x0200006B RID: 107
		internal struct Il2CppMethodInfo_24_1
		{
			// Token: 0x0400018A RID: 394
			public unsafe void* methodPointer;

			// Token: 0x0400018B RID: 395
			public unsafe void* invoker_method;

			// Token: 0x0400018C RID: 396
			public unsafe byte* name;

			// Token: 0x0400018D RID: 397
			public unsafe Il2CppClass* klass;

			// Token: 0x0400018E RID: 398
			public unsafe Il2CppTypeStruct* return_type;

			// Token: 0x0400018F RID: 399
			public unsafe Il2CppParameterInfo* parameters;

			// Token: 0x04000190 RID: 400
			public unsafe void* runtime_data;

			// Token: 0x04000191 RID: 401
			public unsafe void* generic_data;

			// Token: 0x04000192 RID: 402
			public uint token;

			// Token: 0x04000193 RID: 403
			public ushort flags;

			// Token: 0x04000194 RID: 404
			public ushort iflags;

			// Token: 0x04000195 RID: 405
			public ushort slot;

			// Token: 0x04000196 RID: 406
			public byte parameters_count;

			// Token: 0x04000197 RID: 407
			public NativeMethodInfoStructHandler_24_1.Il2CppMethodInfo_24_1.Bitfield0 _bitfield0;

			// Token: 0x0200006C RID: 108
			internal enum Bitfield0 : byte
			{
				// Token: 0x04000199 RID: 409
				BIT_is_generic,
				// Token: 0x0400019A RID: 410
				is_generic,
				// Token: 0x0400019B RID: 411
				BIT_is_inflated = 1,
				// Token: 0x0400019C RID: 412
				is_inflated,
				// Token: 0x0400019D RID: 413
				BIT_wrapper_type = 2,
				// Token: 0x0400019E RID: 414
				wrapper_type = 4,
				// Token: 0x0400019F RID: 415
				BIT_is_marshaled_from_native = 3,
				// Token: 0x040001A0 RID: 416
				is_marshaled_from_native = 8
			}
		}

		// Token: 0x0200006D RID: 109
		internal class NativeStructWrapper : INativeMethodInfoStruct, INativeStruct
		{
			// Token: 0x0600042A RID: 1066 RVA: 0x00019AC0 File Offset: 0x00017CC0
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2356ac6ca5954f1897cd5bbbe0161ae5 != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eeb967463afe407d8f7c3b354043704c == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x0600042B RID: 1067 RVA: 0x00019B50 File Offset: 0x00017D50
			private unsafe NativeMethodInfoStructHandler_24_1.Il2CppMethodInfo_24_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x0600042C RID: 1068 RVA: 0x00019B60 File Offset: 0x00017D60
			public IntPtr Pointer { get; }

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x0600042D RID: 1069 RVA: 0x00019B70 File Offset: 0x00017D70
			public unsafe Il2CppMethodInfo* MethodInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x0600042E RID: 1070 RVA: 0x00019B80 File Offset: 0x00017D80
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x0600042F RID: 1071 RVA: 0x00019B98 File Offset: 0x00017D98
			public unsafe ref ushort Slot
			{
				get
				{
					return ref this._->slot;
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x06000430 RID: 1072 RVA: 0x00019BAC File Offset: 0x00017DAC
			public unsafe ref IntPtr MethodPointer
			{
				get
				{
					return ref *(IntPtr*)(&this._->methodPointer);
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x06000431 RID: 1073 RVA: 0x00019BC4 File Offset: 0x00017DC4
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x06000432 RID: 1074 RVA: 0x00019BD8 File Offset: 0x00017DD8
			public unsafe ref IntPtr InvokerMethod
			{
				get
				{
					return ref *(IntPtr*)(&this._->invoker_method);
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x06000433 RID: 1075 RVA: 0x00019BF0 File Offset: 0x00017DF0
			public unsafe ref Il2CppTypeStruct* ReturnType
			{
				get
				{
					return ref this._->return_type;
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x06000434 RID: 1076 RVA: 0x00019C04 File Offset: 0x00017E04
			public unsafe ref Il2CppMethodFlags Flags
			{
				get
				{
					return ref *(Il2CppMethodFlags*)(&this._->flags);
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x06000435 RID: 1077 RVA: 0x00019C1C File Offset: 0x00017E1C
			public unsafe ref byte ParametersCount
			{
				get
				{
					return ref this._->parameters_count;
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x06000436 RID: 1078 RVA: 0x00019C30 File Offset: 0x00017E30
			public unsafe ref Il2CppParameterInfo* Parameters
			{
				get
				{
					return ref this._->parameters;
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x06000437 RID: 1079 RVA: 0x00019C44 File Offset: 0x00017E44
			public unsafe ref uint Token
			{
				get
				{
					return ref this._->token;
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x06000438 RID: 1080 RVA: 0x00019C58 File Offset: 0x00017E58
			// (set) Token: 0x06000439 RID: 1081 RVA: 0x00019C70 File Offset: 0x00017E70
			public bool IsGeneric
			{
				get
				{
					return NativeMethodInfoStructHandler_24_1.NativeStructWrapper.BpZJlPSHDuoi596OJ8i(this, NativeMethodInfoStructHandler_24_1.NativeStructWrapper._bitfield0offset, 0);
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
							this.SetBit(NativeMethodInfoStructHandler_24_1.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6d7a22a8da0c4b3e8cf479dd7edc9922 == 0)
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

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x0600043A RID: 1082 RVA: 0x00019CD4 File Offset: 0x00017ED4
			// (set) Token: 0x0600043B RID: 1083 RVA: 0x00019CEC File Offset: 0x00017EEC
			public bool IsInflated
			{
				get
				{
					return NativeMethodInfoStructHandler_24_1.NativeStructWrapper.BpZJlPSHDuoi596OJ8i(this, NativeMethodInfoStructHandler_24_1.NativeStructWrapper._bitfield0offset, 1);
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
							this.SetBit(NativeMethodInfoStructHandler_24_1.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6a95c50bbb48420f8f11bb090d6d3bd5 == 0)
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

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x0600043C RID: 1084 RVA: 0x00019D50 File Offset: 0x00017F50
			// (set) Token: 0x0600043D RID: 1085 RVA: 0x00019D68 File Offset: 0x00017F68
			public bool IsMarshalledFromNative
			{
				get
				{
					return NativeMethodInfoStructHandler_24_1.NativeStructWrapper.BpZJlPSHDuoi596OJ8i(this, NativeMethodInfoStructHandler_24_1.NativeStructWrapper._bitfield0offset, 3);
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
							NativeMethodInfoStructHandler_24_1.NativeStructWrapper.GCHB3tSh1SlZWbrPT9t(this, NativeMethodInfoStructHandler_24_1.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4c6a46c0a2d14747aa1dc5bf1581154d == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x0600043E RID: 1086 RVA: 0x00019DCC File Offset: 0x00017FCC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 3;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						NativeMethodInfoStructHandler_24_1.NativeStructWrapper.T8oUGEStyZWiWx4mdSG();
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c26b4d3619a4457fb4121e194d9ef286 != 0)
						{
							num2 = 1;
						}
						break;
					case 1:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeMethodInfoStructHandler_24_1.Il2CppMethodInfo_24_1>(NativeMethodInfoStructHandler_24_1.NativeStructWrapper.KMPgaPSvaFtVuGTh0A5(991557433 + -1844074617 ^ -219433018 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5));
						num2 = 5;
						break;
					}
					case 2:
						NativeMethodInfoStructHandler_24_1.NativeStructWrapper.KI4h7gSOod5HSuQM5kS();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0272cc4de9694915be17746e515675c8 == 0)
						{
							num2 = 0;
						}
						break;
					case 3:
						hIDAYxH6DWLHIthQgC.zSLipEDdx();
						num2 = 2;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b502855b254c47cfafcd30fd84ad7c96 == 0)
						{
							num2 = 2;
						}
						break;
					case 4:
						return;
					case 5:
					{
						IntPtr intPtr;
						NativeMethodInfoStructHandler_24_1.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3e2009ed69c04f5799431b4e58cafb2a == 0)
						{
							num2 = 4;
						}
						break;
					}
					}
				}
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x00019EE4 File Offset: 0x000180E4
			internal static bool LTLEhBSkEd5gy6nqRYh()
			{
				return NativeMethodInfoStructHandler_24_1.NativeStructWrapper.Cl2DIyScBVU7yrhuVnG == null;
			}

			// Token: 0x06000440 RID: 1088 RVA: 0x00019EF8 File Offset: 0x000180F8
			internal static NativeMethodInfoStructHandler_24_1.NativeStructWrapper zl9gMpS2JabXs5Vepqp()
			{
				return NativeMethodInfoStructHandler_24_1.NativeStructWrapper.Cl2DIyScBVU7yrhuVnG;
			}

			// Token: 0x06000441 RID: 1089 RVA: 0x00019F08 File Offset: 0x00018108
			internal static bool BpZJlPSHDuoi596OJ8i(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000442 RID: 1090 RVA: 0x00019F24 File Offset: 0x00018124
			internal static void GCHB3tSh1SlZWbrPT9t(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000443 RID: 1091 RVA: 0x00019F44 File Offset: 0x00018144
			internal static void KI4h7gSOod5HSuQM5kS()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000444 RID: 1092 RVA: 0x00019F54 File Offset: 0x00018154
			internal static void T8oUGEStyZWiWx4mdSG()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000445 RID: 1093 RVA: 0x00019F64 File Offset: 0x00018164
			internal static object KMPgaPSvaFtVuGTh0A5(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x040001A1 RID: 417
			private static readonly int _bitfield0offset;

			// Token: 0x040001A3 RID: 419
			internal static object Cl2DIyScBVU7yrhuVnG;
		}
	}
}
