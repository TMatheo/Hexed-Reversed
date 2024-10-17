using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x02000070 RID: 112
	[ApplicableToUnityVersionsSince("2021.2.0")]
	public class NativeMethodInfoStructHandler_29_0 : INativeMethodInfoStructHandler, INativeStructHandler
	{
		// Token: 0x06000463 RID: 1123 RVA: 0x0000EEE4 File Offset: 0x0000D0E4
		public int Size()
		{
			return sizeof(NativeMethodInfoStructHandler_29_0.Il2CppMethodInfo_29_0);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000EEF4 File Offset: 0x0000D0F4
		public unsafe INativeMethodInfoStruct CreateNewStruct()
		{
			NativeMethodInfoStructHandler_29_0.Il2CppMethodInfo_29_0* ptr2;
			IntPtr ptr = ptr2 = NativeMethodInfoStructHandler_29_0.MUxBuNNpeX9GhVYqlg1(this.Size());
			*ptr2 = default(NativeMethodInfoStructHandler_29_0.Il2CppMethodInfo_29_0);
			return new NativeMethodInfoStructHandler_29_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0000EF24 File Offset: 0x0000D124
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d01f42186cf2421f90d71301ed147eb1 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeMethodInfoStructHandler_29_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000EF8C File Offset: 0x0000D18C
		public NativeMethodInfoStructHandler_29_0()
		{
			NativeMethodInfoStructHandler_29_0.kwMTCXN4DTbVCZjGSrD();
			NativeMethodInfoStructHandler_29_0.iHDIFBNzKEgdek0aJBZ();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_22d16b8eb84d4725aef9f7a9d2f68925 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000EFF0 File Offset: 0x0000D1F0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethodInfoStructHandler_29_0()
		{
			NativeMethodInfoStructHandler_29_0.ITDU3KuHkOjh1ydPTTU();
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0000F000 File Offset: 0x0000D200
		internal static IntPtr MUxBuNNpeX9GhVYqlg1(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0000F014 File Offset: 0x0000D214
		internal static bool yYF5WON1SoRsWNFLOwv()
		{
			return NativeMethodInfoStructHandler_29_0.r4Iv2PN3WBFAv3ufrij == null;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000F028 File Offset: 0x0000D228
		internal static NativeMethodInfoStructHandler_29_0 KDmLKDNM0HtpQ6qONNM()
		{
			return NativeMethodInfoStructHandler_29_0.r4Iv2PN3WBFAv3ufrij;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0000F038 File Offset: 0x0000D238
		internal static void kwMTCXN4DTbVCZjGSrD()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0000F048 File Offset: 0x0000D248
		internal static void iHDIFBNzKEgdek0aJBZ()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0000F058 File Offset: 0x0000D258
		internal static void ITDU3KuHkOjh1ydPTTU()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040001AF RID: 431
		private static NativeMethodInfoStructHandler_29_0 r4Iv2PN3WBFAv3ufrij;

		// Token: 0x02000071 RID: 113
		internal struct Il2CppMethodInfo_29_0
		{
			// Token: 0x040001B0 RID: 432
			public unsafe void* methodPointer;

			// Token: 0x040001B1 RID: 433
			public unsafe void* virtualMethodPointer;

			// Token: 0x040001B2 RID: 434
			public unsafe void* invoker_method;

			// Token: 0x040001B3 RID: 435
			public unsafe byte* name;

			// Token: 0x040001B4 RID: 436
			public unsafe Il2CppClass* klass;

			// Token: 0x040001B5 RID: 437
			public unsafe Il2CppTypeStruct* return_type;

			// Token: 0x040001B6 RID: 438
			public unsafe Il2CppTypeStruct** parameters;

			// Token: 0x040001B7 RID: 439
			public unsafe void* runtime_data;

			// Token: 0x040001B8 RID: 440
			public unsafe void* generic_data;

			// Token: 0x040001B9 RID: 441
			public uint token;

			// Token: 0x040001BA RID: 442
			public ushort flags;

			// Token: 0x040001BB RID: 443
			public ushort iflags;

			// Token: 0x040001BC RID: 444
			public ushort slot;

			// Token: 0x040001BD RID: 445
			public byte parameters_count;

			// Token: 0x040001BE RID: 446
			public NativeMethodInfoStructHandler_29_0.Il2CppMethodInfo_29_0.Bitfield0 _bitfield0;

			// Token: 0x02000072 RID: 114
			internal enum Bitfield0 : byte
			{
				// Token: 0x040001C0 RID: 448
				BIT_is_generic,
				// Token: 0x040001C1 RID: 449
				is_generic,
				// Token: 0x040001C2 RID: 450
				BIT_is_inflated = 1,
				// Token: 0x040001C3 RID: 451
				is_inflated,
				// Token: 0x040001C4 RID: 452
				BIT_wrapper_type = 2,
				// Token: 0x040001C5 RID: 453
				wrapper_type = 4,
				// Token: 0x040001C6 RID: 454
				BIT_has_full_generic_sharing_signature = 3,
				// Token: 0x040001C7 RID: 455
				has_full_generic_sharing_signature = 8,
				// Token: 0x040001C8 RID: 456
				BIT_indirect_call_via_invokers = 4,
				// Token: 0x040001C9 RID: 457
				indirect_call_via_invokers = 16
			}
		}

		// Token: 0x02000073 RID: 115
		internal class NativeStructWrapper : INativeMethodInfoStruct, INativeStruct
		{
			// Token: 0x0600046E RID: 1134 RVA: 0x0001AC54 File Offset: 0x00018E54
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeMethodInfoStructHandler_29_0.NativeStructWrapper.caEsKrWKd0Ui4TwOQQc();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ba3f6bd5a09c47868765e25f534dbf2a == 0)
				{
					num = 1;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						return;
					case 1:
						this.<Pointer>k__BackingField = ptr;
						num = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40 == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x0600046F RID: 1135 RVA: 0x0001ACE4 File Offset: 0x00018EE4
			private unsafe NativeMethodInfoStructHandler_29_0.Il2CppMethodInfo_29_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x06000470 RID: 1136 RVA: 0x0001ACF4 File Offset: 0x00018EF4
			public IntPtr Pointer { get; }

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000471 RID: 1137 RVA: 0x0001AD04 File Offset: 0x00018F04
			public unsafe Il2CppMethodInfo* MethodInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x06000472 RID: 1138 RVA: 0x0001AD14 File Offset: 0x00018F14
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x06000473 RID: 1139 RVA: 0x0001AD2C File Offset: 0x00018F2C
			public unsafe ref ushort Slot
			{
				get
				{
					return ref this._->slot;
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x06000474 RID: 1140 RVA: 0x0001AD40 File Offset: 0x00018F40
			public unsafe ref IntPtr MethodPointer
			{
				get
				{
					return ref *(IntPtr*)(&this._->methodPointer);
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x06000475 RID: 1141 RVA: 0x0001AD58 File Offset: 0x00018F58
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x06000476 RID: 1142 RVA: 0x0001AD6C File Offset: 0x00018F6C
			public unsafe ref IntPtr InvokerMethod
			{
				get
				{
					return ref *(IntPtr*)(&this._->invoker_method);
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x06000477 RID: 1143 RVA: 0x0001AD84 File Offset: 0x00018F84
			public unsafe ref Il2CppTypeStruct* ReturnType
			{
				get
				{
					return ref this._->return_type;
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x06000478 RID: 1144 RVA: 0x0001AD98 File Offset: 0x00018F98
			public unsafe ref Il2CppMethodFlags Flags
			{
				get
				{
					return ref *(Il2CppMethodFlags*)(&this._->flags);
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x06000479 RID: 1145 RVA: 0x0001ADB0 File Offset: 0x00018FB0
			public unsafe ref byte ParametersCount
			{
				get
				{
					return ref this._->parameters_count;
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x0600047A RID: 1146 RVA: 0x0001ADC4 File Offset: 0x00018FC4
			public unsafe ref Il2CppParameterInfo* Parameters
			{
				get
				{
					return ref *(Il2CppParameterInfo**)(&this._->parameters);
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x0600047B RID: 1147 RVA: 0x0001ADDC File Offset: 0x00018FDC
			public unsafe ref uint Token
			{
				get
				{
					return ref this._->token;
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x0600047C RID: 1148 RVA: 0x0001ADF0 File Offset: 0x00018FF0
			// (set) Token: 0x0600047D RID: 1149 RVA: 0x0001AE08 File Offset: 0x00019008
			public bool IsGeneric
			{
				get
				{
					return NativeMethodInfoStructHandler_29_0.NativeStructWrapper.AcSNrXW54NUIuDyX4lK(this, NativeMethodInfoStructHandler_29_0.NativeStructWrapper._bitfield0offset, 0);
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
							this.SetBit(NativeMethodInfoStructHandler_29_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_99cea5f9c4c245c2a5f184ab2e57fafc != 0)
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

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x0600047E RID: 1150 RVA: 0x0001AE6C File Offset: 0x0001906C
			// (set) Token: 0x0600047F RID: 1151 RVA: 0x0001AE84 File Offset: 0x00019084
			public bool IsInflated
			{
				get
				{
					return NativeMethodInfoStructHandler_29_0.NativeStructWrapper.AcSNrXW54NUIuDyX4lK(this, NativeMethodInfoStructHandler_29_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeMethodInfoStructHandler_29_0.NativeStructWrapper.Mk955yWngvv0jFbRG8h(this, NativeMethodInfoStructHandler_29_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c504ab11ece64b14b01df2d4c88e6e49 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x06000480 RID: 1152 RVA: 0x0001AEE8 File Offset: 0x000190E8
			// (set) Token: 0x06000481 RID: 1153 RVA: 0x0001AEF4 File Offset: 0x000190F4
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

			// Token: 0x06000482 RID: 1154 RVA: 0x0001AF00 File Offset: 0x00019100
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
						NativeMethodInfoStructHandler_29_0.NativeStructWrapper.caEsKrWKd0Ui4TwOQQc();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d03e4e4716154375bf56bf596fbd5780 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						NativeMethodInfoStructHandler_29_0.NativeStructWrapper.YUEmbZW35xecQoiFDkg();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_22d16b8eb84d4725aef9f7a9d2f68925 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeMethodInfoStructHandler_29_0.Il2CppMethodInfo_29_0>(NativeMethodInfoStructHandler_29_0.NativeStructWrapper.wLWaRBWMyR4LHF6Jvsr(1428742484 ^ -363849663 ^ -1996499564 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c474f43efb4d4f17b5c0c1bf3216ef4d));
						num2 = 4;
						continue;
					}
					case 4:
					{
						IntPtr intPtr;
						NativeMethodInfoStructHandler_29_0.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 5;
						continue;
					}
					case 5:
						return;
					}
					NativeMethodInfoStructHandler_29_0.NativeStructWrapper.klrKYqW1qD22tVu9ViR();
					num2 = 3;
				}
			}

			// Token: 0x06000483 RID: 1155 RVA: 0x0001AFEC File Offset: 0x000191EC
			internal static void caEsKrWKd0Ui4TwOQQc()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000484 RID: 1156 RVA: 0x0001AFFC File Offset: 0x000191FC
			internal static bool BHoQI3WTYFb8hSlm7cq()
			{
				return NativeMethodInfoStructHandler_29_0.NativeStructWrapper.LBCDFvWj4W2R5FJiMkW == null;
			}

			// Token: 0x06000485 RID: 1157 RVA: 0x0001B010 File Offset: 0x00019210
			internal static NativeMethodInfoStructHandler_29_0.NativeStructWrapper ivV7DvWF8Y9QNAXatMo()
			{
				return NativeMethodInfoStructHandler_29_0.NativeStructWrapper.LBCDFvWj4W2R5FJiMkW;
			}

			// Token: 0x06000486 RID: 1158 RVA: 0x0001B020 File Offset: 0x00019220
			internal static bool AcSNrXW54NUIuDyX4lK(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000487 RID: 1159 RVA: 0x0001B03C File Offset: 0x0001923C
			internal static void Mk955yWngvv0jFbRG8h(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000488 RID: 1160 RVA: 0x0001B05C File Offset: 0x0001925C
			internal static void YUEmbZW35xecQoiFDkg()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000489 RID: 1161 RVA: 0x0001B06C File Offset: 0x0001926C
			internal static void klrKYqW1qD22tVu9ViR()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x0600048A RID: 1162 RVA: 0x0001B07C File Offset: 0x0001927C
			internal static object wLWaRBWMyR4LHF6Jvsr(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x040001CA RID: 458
			private static readonly int _bitfield0offset;

			// Token: 0x040001CC RID: 460
			private static object LBCDFvWj4W2R5FJiMkW;
		}
	}
}
