using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x02000072 RID: 114
	[ApplicableToUnityVersionsSince("2022.1.0")]
	public class NativeMethodInfoStructHandler_29_1 : INativeMethodInfoStructHandler, INativeStructHandler
	{
		// Token: 0x0600046C RID: 1132 RVA: 0x0000E47C File Offset: 0x0000C67C
		public int Size()
		{
			return sizeof(NativeMethodInfoStructHandler_29_1.Il2CppMethodInfo_29_1);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0000E48C File Offset: 0x0000C68C
		public unsafe INativeMethodInfoStruct CreateNewStruct()
		{
			NativeMethodInfoStructHandler_29_1.Il2CppMethodInfo_29_1* ptr2;
			IntPtr ptr = ptr2 = NativeMethodInfoStructHandler_29_1.Hxkl1F8rutAFhM0kvCa(this.Size());
			*ptr2 = default(NativeMethodInfoStructHandler_29_1.Il2CppMethodInfo_29_1);
			return new NativeMethodInfoStructHandler_29_1.NativeStructWrapper(ptr);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0000E4BC File Offset: 0x0000C6BC
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f6eb9387956a4e8c81dafbb2ecc8c7ab != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeMethodInfoStructHandler_29_1.NativeStructWrapper(ptr);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000E524 File Offset: 0x0000C724
		public NativeMethodInfoStructHandler_29_1()
		{
			NativeMethodInfoStructHandler_29_1.KOiZP88TWZM9Q8BGvVi();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_791a252a9221476faad2c6d41e84a167 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000E588 File Offset: 0x0000C788
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethodInfoStructHandler_29_1()
		{
			NativeMethodInfoStructHandler_29_1.YAjYnU8g7H1qCCQ3EwW();
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0000E598 File Offset: 0x0000C798
		internal static IntPtr Hxkl1F8rutAFhM0kvCa(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0000E5AC File Offset: 0x0000C7AC
		internal static bool NrcEoL8BKHxdTXMIXev()
		{
			return NativeMethodInfoStructHandler_29_1.ebDKqU8EM6rhcnUaSab == null;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0000E5C0 File Offset: 0x0000C7C0
		internal static NativeMethodInfoStructHandler_29_1 QaXIUZ8GCfKxKSWdsD3()
		{
			return NativeMethodInfoStructHandler_29_1.ebDKqU8EM6rhcnUaSab;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0000E5D0 File Offset: 0x0000C7D0
		internal static void KOiZP88TWZM9Q8BGvVi()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
		internal static void YAjYnU8g7H1qCCQ3EwW()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040001C2 RID: 450
		internal static NativeMethodInfoStructHandler_29_1 ebDKqU8EM6rhcnUaSab;

		// Token: 0x02000073 RID: 115
		internal struct Il2CppMethodInfo_29_1
		{
			// Token: 0x040001C3 RID: 451
			public unsafe void* methodPointer;

			// Token: 0x040001C4 RID: 452
			public unsafe void* virtualMethodPointer;

			// Token: 0x040001C5 RID: 453
			public unsafe void* invoker_method;

			// Token: 0x040001C6 RID: 454
			public unsafe byte* name;

			// Token: 0x040001C7 RID: 455
			public unsafe Il2CppClass* klass;

			// Token: 0x040001C8 RID: 456
			public unsafe Il2CppTypeStruct* return_type;

			// Token: 0x040001C9 RID: 457
			public unsafe Il2CppTypeStruct** parameters;

			// Token: 0x040001CA RID: 458
			public unsafe void* runtime_data;

			// Token: 0x040001CB RID: 459
			public unsafe void* generic_data;

			// Token: 0x040001CC RID: 460
			public uint token;

			// Token: 0x040001CD RID: 461
			public ushort flags;

			// Token: 0x040001CE RID: 462
			public ushort iflags;

			// Token: 0x040001CF RID: 463
			public ushort slot;

			// Token: 0x040001D0 RID: 464
			public byte parameters_count;

			// Token: 0x040001D1 RID: 465
			public NativeMethodInfoStructHandler_29_1.Il2CppMethodInfo_29_1.Bitfield0 _bitfield0;

			// Token: 0x02000074 RID: 116
			internal enum Bitfield0 : byte
			{
				// Token: 0x040001D3 RID: 467
				BIT_is_generic,
				// Token: 0x040001D4 RID: 468
				is_generic,
				// Token: 0x040001D5 RID: 469
				BIT_is_inflated = 1,
				// Token: 0x040001D6 RID: 470
				is_inflated,
				// Token: 0x040001D7 RID: 471
				BIT_wrapper_type = 2,
				// Token: 0x040001D8 RID: 472
				wrapper_type = 4,
				// Token: 0x040001D9 RID: 473
				BIT_has_full_generic_sharing_signature = 3,
				// Token: 0x040001DA RID: 474
				has_full_generic_sharing_signature = 8
			}
		}

		// Token: 0x02000075 RID: 117
		internal class NativeStructWrapper : INativeMethodInfoStruct, INativeStruct
		{
			// Token: 0x06000476 RID: 1142 RVA: 0x0001A3D0 File Offset: 0x000185D0
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeMethodInfoStructHandler_29_1.NativeStructWrapper.zY6RAUSPSdjUgvyEoPq();
				NativeMethodInfoStructHandler_29_1.NativeStructWrapper.dXwrGDS4HHcIwuCwtXN();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6a95c50bbb48420f8f11bb090d6d3bd5 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_911808c58d664adeb7c16d1e3a32f7fa != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x06000477 RID: 1143 RVA: 0x0001A460 File Offset: 0x00018660
			private unsafe NativeMethodInfoStructHandler_29_1.Il2CppMethodInfo_29_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x06000478 RID: 1144 RVA: 0x0001A470 File Offset: 0x00018670
			public IntPtr Pointer { get; }

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x06000479 RID: 1145 RVA: 0x0001A480 File Offset: 0x00018680
			public unsafe Il2CppMethodInfo* MethodInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x0600047A RID: 1146 RVA: 0x0001A490 File Offset: 0x00018690
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x0600047B RID: 1147 RVA: 0x0001A4A8 File Offset: 0x000186A8
			public unsafe ref ushort Slot
			{
				get
				{
					return ref this._->slot;
				}
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x0600047C RID: 1148 RVA: 0x0001A4BC File Offset: 0x000186BC
			public unsafe ref IntPtr MethodPointer
			{
				get
				{
					return ref *(IntPtr*)(&this._->methodPointer);
				}
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x0600047D RID: 1149 RVA: 0x0001A4D4 File Offset: 0x000186D4
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x0600047E RID: 1150 RVA: 0x0001A4E8 File Offset: 0x000186E8
			public unsafe ref IntPtr InvokerMethod
			{
				get
				{
					return ref *(IntPtr*)(&this._->invoker_method);
				}
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x0600047F RID: 1151 RVA: 0x0001A500 File Offset: 0x00018700
			public unsafe ref Il2CppTypeStruct* ReturnType
			{
				get
				{
					return ref this._->return_type;
				}
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x06000480 RID: 1152 RVA: 0x0001A514 File Offset: 0x00018714
			public unsafe ref Il2CppMethodFlags Flags
			{
				get
				{
					return ref *(Il2CppMethodFlags*)(&this._->flags);
				}
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x06000481 RID: 1153 RVA: 0x0001A52C File Offset: 0x0001872C
			public unsafe ref byte ParametersCount
			{
				get
				{
					return ref this._->parameters_count;
				}
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x06000482 RID: 1154 RVA: 0x0001A540 File Offset: 0x00018740
			public unsafe ref Il2CppParameterInfo* Parameters
			{
				get
				{
					return ref *(Il2CppParameterInfo**)(&this._->parameters);
				}
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x06000483 RID: 1155 RVA: 0x0001A558 File Offset: 0x00018758
			public unsafe ref uint Token
			{
				get
				{
					return ref this._->token;
				}
			}

			// Token: 0x170000CE RID: 206
			// (get) Token: 0x06000484 RID: 1156 RVA: 0x0001A56C File Offset: 0x0001876C
			// (set) Token: 0x06000485 RID: 1157 RVA: 0x0001A584 File Offset: 0x00018784
			public bool IsGeneric
			{
				get
				{
					return NativeMethodInfoStructHandler_29_1.NativeStructWrapper.ztOdI4S3LEUwvnkVuKG(this, NativeMethodInfoStructHandler_29_1.NativeStructWrapper._bitfield0offset, 0);
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
							NativeMethodInfoStructHandler_29_1.NativeStructWrapper.TGs30NSfs0qqo4GaLFa(this, NativeMethodInfoStructHandler_29_1.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4356a7af7f8147b79f2ed4ab0c268438 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x06000486 RID: 1158 RVA: 0x0001A5E8 File Offset: 0x000187E8
			// (set) Token: 0x06000487 RID: 1159 RVA: 0x0001A600 File Offset: 0x00018800
			public bool IsInflated
			{
				get
				{
					return NativeMethodInfoStructHandler_29_1.NativeStructWrapper.ztOdI4S3LEUwvnkVuKG(this, NativeMethodInfoStructHandler_29_1.NativeStructWrapper._bitfield0offset, 1);
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
							this.SetBit(NativeMethodInfoStructHandler_29_1.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cb2874465fa5416db806f31e03cc475c == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x06000488 RID: 1160 RVA: 0x0001A664 File Offset: 0x00018864
			// (set) Token: 0x06000489 RID: 1161 RVA: 0x0001A670 File Offset: 0x00018870
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

			// Token: 0x0600048A RID: 1162 RVA: 0x0001A67C File Offset: 0x0001887C
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 5;
				int num2 = num;
				for (;;)
				{
					IntPtr intPtr;
					switch (num2)
					{
					case 1:
						NativeMethodInfoStructHandler_29_1.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 3;
						continue;
					case 2:
						NativeMethodInfoStructHandler_29_1.NativeStructWrapper.dXwrGDS4HHcIwuCwtXN();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7628c527f657443a88f11a40a3f948a5 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						NativeMethodInfoStructHandler_29_1.NativeStructWrapper.zY6RAUSPSdjUgvyEoPq();
						num2 = 2;
						continue;
					case 5:
						NativeMethodInfoStructHandler_29_1.NativeStructWrapper.vZ37pOS1numrHJBhCsB();
						num2 = 4;
						continue;
					}
					intPtr = Marshal.OffsetOf<NativeMethodInfoStructHandler_29_1.Il2CppMethodInfo_29_1>(NativeMethodInfoStructHandler_29_1.NativeStructWrapper.ah1EYmSFkfxguagCKEo(1634652592 ^ 1905888584 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7dfb1d10537744ca9e949b6b3a3eac09));
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b169d8ea412f45e99e430384ddc8908b != 0)
					{
						num2 = 1;
					}
				}
			}

			// Token: 0x0600048B RID: 1163 RVA: 0x0001A764 File Offset: 0x00018964
			internal static void zY6RAUSPSdjUgvyEoPq()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600048C RID: 1164 RVA: 0x0001A774 File Offset: 0x00018974
			internal static void dXwrGDS4HHcIwuCwtXN()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x0600048D RID: 1165 RVA: 0x0001A784 File Offset: 0x00018984
			internal static bool NSpjfISmYZqOUEAgdVf()
			{
				return NativeMethodInfoStructHandler_29_1.NativeStructWrapper.G3xUi7SDQRdOG25W9du == null;
			}

			// Token: 0x0600048E RID: 1166 RVA: 0x0001A798 File Offset: 0x00018998
			internal static NativeMethodInfoStructHandler_29_1.NativeStructWrapper sVie3fS77sP2p0ZnnML()
			{
				return NativeMethodInfoStructHandler_29_1.NativeStructWrapper.G3xUi7SDQRdOG25W9du;
			}

			// Token: 0x0600048F RID: 1167 RVA: 0x0001A7A8 File Offset: 0x000189A8
			internal static bool ztOdI4S3LEUwvnkVuKG(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000490 RID: 1168 RVA: 0x0001A7C4 File Offset: 0x000189C4
			internal static void TGs30NSfs0qqo4GaLFa(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000491 RID: 1169 RVA: 0x0001A7E4 File Offset: 0x000189E4
			internal static void vZ37pOS1numrHJBhCsB()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000492 RID: 1170 RVA: 0x0001A7F4 File Offset: 0x000189F4
			internal static object ah1EYmSFkfxguagCKEo(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x040001DB RID: 475
			private static readonly int _bitfield0offset;

			// Token: 0x040001DD RID: 477
			private static object G3xUi7SDQRdOG25W9du;
		}
	}
}
