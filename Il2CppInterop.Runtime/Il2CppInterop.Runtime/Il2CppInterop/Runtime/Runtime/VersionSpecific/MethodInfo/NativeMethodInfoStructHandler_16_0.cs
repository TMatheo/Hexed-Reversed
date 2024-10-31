using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x0200005E RID: 94
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeMethodInfoStructHandler_16_0 : INativeMethodInfoStructHandler, INativeStructHandler
	{
		// Token: 0x060003AB RID: 939 RVA: 0x0000DD4C File Offset: 0x0000BF4C
		public int Size()
		{
			return sizeof(NativeMethodInfoStructHandler_16_0.Il2CppMethodInfo_16_0);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000DD5C File Offset: 0x0000BF5C
		public unsafe INativeMethodInfoStruct CreateNewStruct()
		{
			NativeMethodInfoStructHandler_16_0.Il2CppMethodInfo_16_0* ptr2;
			IntPtr ptr = ptr2 = NativeMethodInfoStructHandler_16_0.aSvGYQ8J6tJvnMr26U7(this.Size());
			*ptr2 = default(NativeMethodInfoStructHandler_16_0.Il2CppMethodInfo_16_0);
			return new NativeMethodInfoStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000DD8C File Offset: 0x0000BF8C
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b82ae23c6544f3a11e54f2fed3ad25 == 0)
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

		// Token: 0x060003AE RID: 942 RVA: 0x0000DDF4 File Offset: 0x0000BFF4
		public NativeMethodInfoStructHandler_16_0()
		{
			NativeMethodInfoStructHandler_16_0.pnXlRQ8p7VscfxerpMT();
			NativeMethodInfoStructHandler_16_0.hALfF18VvXAtYssEdkU();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_40fe2648722c4d04bef43cdd927d6154 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000DE58 File Offset: 0x0000C058
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethodInfoStructHandler_16_0()
		{
			NativeMethodInfoStructHandler_16_0.yr3dbW80Nf2VuGR217e();
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000DE68 File Offset: 0x0000C068
		internal static IntPtr aSvGYQ8J6tJvnMr26U7(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000DE7C File Offset: 0x0000C07C
		internal static bool OS1eo786pPmUI5ABncx()
		{
			return NativeMethodInfoStructHandler_16_0.q3J0Ab8bdy7Z2LfdHtp == null;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000DE90 File Offset: 0x0000C090
		internal static NativeMethodInfoStructHandler_16_0 jiEKDi8yUTrOIvOV9HB()
		{
			return NativeMethodInfoStructHandler_16_0.q3J0Ab8bdy7Z2LfdHtp;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000DEA0 File Offset: 0x0000C0A0
		internal static void pnXlRQ8p7VscfxerpMT()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000DEB0 File Offset: 0x0000C0B0
		internal static void hALfF18VvXAtYssEdkU()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		internal static void yr3dbW80Nf2VuGR217e()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400013D RID: 317
		internal static NativeMethodInfoStructHandler_16_0 q3J0Ab8bdy7Z2LfdHtp;

		// Token: 0x0200005F RID: 95
		internal struct Il2CppMethodInfo_16_0
		{
			// Token: 0x0400013E RID: 318
			public unsafe void* method;

			// Token: 0x0400013F RID: 319
			public unsafe void* invoker_method;

			// Token: 0x04000140 RID: 320
			public unsafe byte* name;

			// Token: 0x04000141 RID: 321
			public unsafe Il2CppClass* declaring_type;

			// Token: 0x04000142 RID: 322
			public unsafe Il2CppTypeStruct* return_type;

			// Token: 0x04000143 RID: 323
			public unsafe Il2CppParameterInfo* parameters;

			// Token: 0x04000144 RID: 324
			public unsafe void* runtime_data;

			// Token: 0x04000145 RID: 325
			public unsafe void* generic_data;

			// Token: 0x04000146 RID: 326
			public int customAttributeIndex;

			// Token: 0x04000147 RID: 327
			public uint token;

			// Token: 0x04000148 RID: 328
			public ushort flags;

			// Token: 0x04000149 RID: 329
			public ushort iflags;

			// Token: 0x0400014A RID: 330
			public ushort slot;

			// Token: 0x0400014B RID: 331
			public byte parameters_count;

			// Token: 0x0400014C RID: 332
			public NativeMethodInfoStructHandler_16_0.Il2CppMethodInfo_16_0.Bitfield0 _bitfield0;

			// Token: 0x02000060 RID: 96
			internal enum Bitfield0 : byte
			{
				// Token: 0x0400014E RID: 334
				BIT_is_generic,
				// Token: 0x0400014F RID: 335
				is_generic,
				// Token: 0x04000150 RID: 336
				BIT_is_inflated = 1,
				// Token: 0x04000151 RID: 337
				is_inflated
			}
		}

		// Token: 0x02000061 RID: 97
		internal class NativeStructWrapper : INativeMethodInfoStruct, INativeStruct
		{
			// Token: 0x060003B6 RID: 950 RVA: 0x00018D8C File Offset: 0x00016F8C
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeMethodInfoStructHandler_16_0.NativeStructWrapper.cRdamcsfDlpxP9ysVQy();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_754a6df239be4343a1e8b95a82be3f48 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b55404cff7864ea3949f7b4156fd6ee5 == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x060003B7 RID: 951 RVA: 0x00018E1C File Offset: 0x0001701C
			private unsafe NativeMethodInfoStructHandler_16_0.Il2CppMethodInfo_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x060003B8 RID: 952 RVA: 0x00018E2C File Offset: 0x0001702C
			public IntPtr Pointer { get; }

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x060003B9 RID: 953 RVA: 0x00018E3C File Offset: 0x0001703C
			public unsafe Il2CppMethodInfo* MethodInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x060003BA RID: 954 RVA: 0x00018E4C File Offset: 0x0001704C
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x060003BB RID: 955 RVA: 0x00018E64 File Offset: 0x00017064
			public unsafe ref ushort Slot
			{
				get
				{
					return ref this._->slot;
				}
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x060003BC RID: 956 RVA: 0x00018E78 File Offset: 0x00017078
			public unsafe ref IntPtr MethodPointer
			{
				get
				{
					return ref *(IntPtr*)(&this._->method);
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x060003BD RID: 957 RVA: 0x00018E90 File Offset: 0x00017090
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->declaring_type;
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x060003BE RID: 958 RVA: 0x00018EA4 File Offset: 0x000170A4
			public unsafe ref IntPtr InvokerMethod
			{
				get
				{
					return ref *(IntPtr*)(&this._->invoker_method);
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x060003BF RID: 959 RVA: 0x00018EBC File Offset: 0x000170BC
			public unsafe ref Il2CppTypeStruct* ReturnType
			{
				get
				{
					return ref this._->return_type;
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060003C0 RID: 960 RVA: 0x00018ED0 File Offset: 0x000170D0
			public unsafe ref Il2CppMethodFlags Flags
			{
				get
				{
					return ref *(Il2CppMethodFlags*)(&this._->flags);
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060003C1 RID: 961 RVA: 0x00018EE8 File Offset: 0x000170E8
			public unsafe ref byte ParametersCount
			{
				get
				{
					return ref this._->parameters_count;
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060003C2 RID: 962 RVA: 0x00018EFC File Offset: 0x000170FC
			public unsafe ref Il2CppParameterInfo* Parameters
			{
				get
				{
					return ref this._->parameters;
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x060003C3 RID: 963 RVA: 0x00018F10 File Offset: 0x00017110
			public unsafe ref uint Token
			{
				get
				{
					return ref this._->token;
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060003C4 RID: 964 RVA: 0x00018F24 File Offset: 0x00017124
			// (set) Token: 0x060003C5 RID: 965 RVA: 0x00018F3C File Offset: 0x0001713C
			public bool IsGeneric
			{
				get
				{
					return NativeMethodInfoStructHandler_16_0.NativeStructWrapper.zZXuUos1oeuFpyDiqEo(this, NativeMethodInfoStructHandler_16_0.NativeStructWrapper._bitfield0offset, 0);
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
							NativeMethodInfoStructHandler_16_0.NativeStructWrapper.sffaf6sFtQQoeJIs0ZZ(this, NativeMethodInfoStructHandler_16_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b55404cff7864ea3949f7b4156fd6ee5 != 0)
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

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x060003C6 RID: 966 RVA: 0x00018FA0 File Offset: 0x000171A0
			// (set) Token: 0x060003C7 RID: 967 RVA: 0x00018FB8 File Offset: 0x000171B8
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
							NativeMethodInfoStructHandler_16_0.NativeStructWrapper.sffaf6sFtQQoeJIs0ZZ(this, NativeMethodInfoStructHandler_16_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bc2bbd892f074260abf5aaa8b1124d64 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x060003C8 RID: 968 RVA: 0x0001901C File Offset: 0x0001721C
			// (set) Token: 0x060003C9 RID: 969 RVA: 0x00019028 File Offset: 0x00017228
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

			// Token: 0x060003CA RID: 970 RVA: 0x00019034 File Offset: 0x00017234
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 4;
				for (;;)
				{
					int num2 = num;
					IntPtr intPtr;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							intPtr = Marshal.OffsetOf<NativeMethodInfoStructHandler_16_0.Il2CppMethodInfo_16_0>(NativeMethodInfoStructHandler_16_0.NativeStructWrapper.PhqGwnsWp6W4qAWabRT(149850228 ^ 216500751 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c26b4d3619a4457fb4121e194d9ef286));
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3f609fad0bcc47d79d3add6a492d3616 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							return;
						case 3:
							NativeMethodInfoStructHandler_16_0.NativeStructWrapper.rHJEOssMyFvPA0bIOk0();
							num2 = 3;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_508916f527eb4b05b32762ef07dd9e52 != 0)
							{
								num2 = 5;
								continue;
							}
							continue;
						case 4:
							NativeMethodInfoStructHandler_16_0.NativeStructWrapper.o19TKusR31WWZoUsiUq();
							num2 = 3;
							continue;
						case 5:
							NativeMethodInfoStructHandler_16_0.NativeStructWrapper.cRdamcsfDlpxP9ysVQy();
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb34a81d7cc4fbea898664370a8645f != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						break;
					}
					IL_D3:
					NativeMethodInfoStructHandler_16_0.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
					num = 2;
					continue;
					goto IL_D3;
				}
			}

			// Token: 0x060003CB RID: 971 RVA: 0x00019134 File Offset: 0x00017334
			internal static void cRdamcsfDlpxP9ysVQy()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x060003CC RID: 972 RVA: 0x00019144 File Offset: 0x00017344
			internal static bool lOk48Js4QynOvhsbt2j()
			{
				return NativeMethodInfoStructHandler_16_0.NativeStructWrapper.LMVtMMsPqm9tmfoCKqD == null;
			}

			// Token: 0x060003CD RID: 973 RVA: 0x00019158 File Offset: 0x00017358
			internal static NativeMethodInfoStructHandler_16_0.NativeStructWrapper TjlHlps3fuuKG9yXscA()
			{
				return NativeMethodInfoStructHandler_16_0.NativeStructWrapper.LMVtMMsPqm9tmfoCKqD;
			}

			// Token: 0x060003CE RID: 974 RVA: 0x00019168 File Offset: 0x00017368
			internal static bool zZXuUos1oeuFpyDiqEo(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060003CF RID: 975 RVA: 0x00019184 File Offset: 0x00017384
			internal static void sffaf6sFtQQoeJIs0ZZ(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x000191A4 File Offset: 0x000173A4
			internal static void o19TKusR31WWZoUsiUq()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x060003D1 RID: 977 RVA: 0x000191B4 File Offset: 0x000173B4
			internal static void rHJEOssMyFvPA0bIOk0()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060003D2 RID: 978 RVA: 0x000191C4 File Offset: 0x000173C4
			internal static object PhqGwnsWp6W4qAWabRT(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000152 RID: 338
			private static readonly int _bitfield0offset;

			// Token: 0x04000154 RID: 340
			internal static object LMVtMMsPqm9tmfoCKqD;
		}
	}
}
