using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Type
{
	// Token: 0x0200003E RID: 62
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeTypeStructHandler_16_0 : INativeTypeStructHandler, INativeStructHandler
	{
		// Token: 0x060002B1 RID: 689 RVA: 0x0000CC78 File Offset: 0x0000AE78
		public int Size()
		{
			return sizeof(NativeTypeStructHandler_16_0.Il2CppType_16_0);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000CC88 File Offset: 0x0000AE88
		public unsafe INativeTypeStruct CreateNewStruct()
		{
			NativeTypeStructHandler_16_0.Il2CppType_16_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeTypeStructHandler_16_0.Il2CppType_16_0);
			return new NativeTypeStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000CCB8 File Offset: 0x0000AEB8
		public unsafe INativeTypeStruct Wrap(Il2CppTypeStruct* ptr)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_49f6034724814fe88f4ca6e5ef134249 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeTypeStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000CD20 File Offset: 0x0000AF20
		public NativeTypeStructHandler_16_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeTypeStructHandler_16_0.dV9hoqYb8YZlKCK4lZ4();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2adb3ca441e493aba80425bcc0f1db3 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000CD84 File Offset: 0x0000AF84
		// Note: this type is marked as 'beforefieldinit'.
		static NativeTypeStructHandler_16_0()
		{
			NativeTypeStructHandler_16_0.QCIXC7Y6t48Bw5hGrcP();
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000CD94 File Offset: 0x0000AF94
		internal static bool cnuK5kY8HMdO2ioqrg9()
		{
			return NativeTypeStructHandler_16_0.HjsBBeYYJoEfXGSMuGK == null;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000CDA8 File Offset: 0x0000AFA8
		internal static NativeTypeStructHandler_16_0 B4w5SgYn19MFKlweYPT()
		{
			return NativeTypeStructHandler_16_0.HjsBBeYYJoEfXGSMuGK;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000CDB8 File Offset: 0x0000AFB8
		internal static void dV9hoqYb8YZlKCK4lZ4()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		internal static void QCIXC7Y6t48Bw5hGrcP()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040000F2 RID: 242
		private static NativeTypeStructHandler_16_0 HjsBBeYYJoEfXGSMuGK;

		// Token: 0x0200003F RID: 63
		internal struct Il2CppType_16_0
		{
			// Token: 0x040000F3 RID: 243
			public unsafe void* data;

			// Token: 0x040000F4 RID: 244
			public ushort attrs;

			// Token: 0x040000F5 RID: 245
			public byte type;

			// Token: 0x040000F6 RID: 246
			public NativeTypeStructHandler_16_0.Il2CppType_16_0.Bitfield0 _bitfield0;

			// Token: 0x02000040 RID: 64
			internal enum Bitfield0 : byte
			{
				// Token: 0x040000F8 RID: 248
				BIT_byref = 6,
				// Token: 0x040000F9 RID: 249
				byref = 64,
				// Token: 0x040000FA RID: 250
				BIT_pinned = 7,
				// Token: 0x040000FB RID: 251
				pinned = 128
			}
		}

		// Token: 0x02000041 RID: 65
		internal class NativeStructWrapper : INativeTypeStruct, INativeStruct
		{
			// Token: 0x060002BA RID: 698 RVA: 0x00017CBC File Offset: 0x00015EBC
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeTypeStructHandler_16_0.NativeStructWrapper.VIxO5O0sVqxmuiOPpyJ();
				NativeTypeStructHandler_16_0.NativeStructWrapper.zNqsYT0SDNiqRDRbpKg();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_43cc35cb254148318955c7f83ade60f1 != 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						this.<Pointer>k__BackingField = ptr;
						num = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b82ae23c6544f3a11e54f2fed3ad25 == 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060002BB RID: 699 RVA: 0x00017D4C File Offset: 0x00015F4C
			private unsafe NativeTypeStructHandler_16_0.Il2CppType_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x060002BC RID: 700 RVA: 0x00017D5C File Offset: 0x00015F5C
			public IntPtr Pointer { get; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x060002BD RID: 701 RVA: 0x00017D6C File Offset: 0x00015F6C
			public unsafe Il2CppTypeStruct* TypePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x060002BE RID: 702 RVA: 0x00017D7C File Offset: 0x00015F7C
			public unsafe ref IntPtr Data
			{
				get
				{
					return ref *(IntPtr*)(&this._->data);
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060002BF RID: 703 RVA: 0x00017D94 File Offset: 0x00015F94
			public unsafe ref ushort Attrs
			{
				get
				{
					return ref this._->attrs;
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x060002C0 RID: 704 RVA: 0x00017DA8 File Offset: 0x00015FA8
			public unsafe ref Il2CppTypeEnum Type
			{
				get
				{
					return ref *(Il2CppTypeEnum*)(&this._->type);
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x060002C1 RID: 705 RVA: 0x00017DC0 File Offset: 0x00015FC0
			// (set) Token: 0x060002C2 RID: 706 RVA: 0x00017DD8 File Offset: 0x00015FD8
			public bool ByRef
			{
				get
				{
					return NativeTypeStructHandler_16_0.NativeStructWrapper.wjwJXd0NI09Mucm3k3K(this, NativeTypeStructHandler_16_0.NativeStructWrapper._bitfield0offset, 6);
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
							this.SetBit(NativeTypeStructHandler_16_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7b01772eb8964b6a81d74c3d1c2f871e != 0)
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

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x060002C3 RID: 707 RVA: 0x00017E3C File Offset: 0x0001603C
			// (set) Token: 0x060002C4 RID: 708 RVA: 0x00017E54 File Offset: 0x00016054
			public bool Pinned
			{
				get
				{
					return NativeTypeStructHandler_16_0.NativeStructWrapper.wjwJXd0NI09Mucm3k3K(this, NativeTypeStructHandler_16_0.NativeStructWrapper._bitfield0offset, 7);
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
							this.SetBit(NativeTypeStructHandler_16_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f6eb9387956a4e8c81dafbb2ecc8c7ab != 0)
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

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060002C5 RID: 709 RVA: 0x00017EB8 File Offset: 0x000160B8
			// (set) Token: 0x060002C6 RID: 710 RVA: 0x00017EC4 File Offset: 0x000160C4
			public bool ValueType
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			// Token: 0x060002C7 RID: 711 RVA: 0x00017ED0 File Offset: 0x000160D0
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						NativeTypeStructHandler_16_0.NativeStructWrapper.nQK9ws0uIlN5dgT27M7();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ffe1ad8c1cf94bc78c25e67b0264547e == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						NativeTypeStructHandler_16_0.NativeStructWrapper.zNqsYT0SDNiqRDRbpKg();
						num2 = 4;
						continue;
					case 3:
						return;
					case 4:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeTypeStructHandler_16_0.Il2CppType_16_0>(hIDAYxH6DWLHIthQgC.gSCeTtiku(684946568 ^ -1100635574 ^ -399809171 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_441278fe93ad425f9343d4f7d1692fca));
						num2 = 5;
						continue;
					}
					case 5:
					{
						IntPtr intPtr;
						NativeTypeStructHandler_16_0.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 3;
						continue;
					}
					}
					NativeTypeStructHandler_16_0.NativeStructWrapper.VIxO5O0sVqxmuiOPpyJ();
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6a95c50bbb48420f8f11bb090d6d3bd5 == 0)
					{
						num2 = 2;
					}
				}
			}

			// Token: 0x060002C8 RID: 712 RVA: 0x00017FBC File Offset: 0x000161BC
			internal static void VIxO5O0sVqxmuiOPpyJ()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060002C9 RID: 713 RVA: 0x00017FCC File Offset: 0x000161CC
			internal static void zNqsYT0SDNiqRDRbpKg()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x060002CA RID: 714 RVA: 0x00017FDC File Offset: 0x000161DC
			internal static bool G7N5bm0VvaKDKin8wdR()
			{
				return NativeTypeStructHandler_16_0.NativeStructWrapper.kqVEcj0pZY1VjOSuEqJ == null;
			}

			// Token: 0x060002CB RID: 715 RVA: 0x00017FF0 File Offset: 0x000161F0
			internal static NativeTypeStructHandler_16_0.NativeStructWrapper CTIJcr00ga4iMjhlZ4I()
			{
				return NativeTypeStructHandler_16_0.NativeStructWrapper.kqVEcj0pZY1VjOSuEqJ;
			}

			// Token: 0x060002CC RID: 716 RVA: 0x00018000 File Offset: 0x00016200
			internal static bool wjwJXd0NI09Mucm3k3K(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060002CD RID: 717 RVA: 0x0001801C File Offset: 0x0001621C
			internal static void nQK9ws0uIlN5dgT27M7()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x040000FC RID: 252
			private static readonly int _bitfield0offset;

			// Token: 0x040000FE RID: 254
			internal static object kqVEcj0pZY1VjOSuEqJ;
		}
	}
}
