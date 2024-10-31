using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Type
{
	// Token: 0x02000042 RID: 66
	[ApplicableToUnityVersionsSince("2021.1.0")]
	public class NativeTypeStructHandler_27_0 : INativeTypeStructHandler, INativeStructHandler
	{
		// Token: 0x060002CE RID: 718 RVA: 0x0000CDD8 File Offset: 0x0000AFD8
		public int Size()
		{
			return sizeof(NativeTypeStructHandler_27_0.Il2CppType_27_0);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000CDE8 File Offset: 0x0000AFE8
		public unsafe INativeTypeStruct CreateNewStruct()
		{
			NativeTypeStructHandler_27_0.Il2CppType_27_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeTypeStructHandler_27_0.Il2CppType_27_0);
			return new NativeTypeStructHandler_27_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000CE18 File Offset: 0x0000B018
		public unsafe INativeTypeStruct Wrap(Il2CppTypeStruct* ptr)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_892d6b14d02a4b94bf68e8edfebcd1f5 == 0)
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
			return new NativeTypeStructHandler_27_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000CE80 File Offset: 0x0000B080
		public NativeTypeStructHandler_27_0()
		{
			NativeTypeStructHandler_27_0.amD2gKYVIfAPjpZxU1i();
			NativeTypeStructHandler_27_0.c7ZwdRY0Tip3BLDsyjc();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_9f61d52c010d488b818a577e37d289c0 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000CEE4 File Offset: 0x0000B0E4
		// Note: this type is marked as 'beforefieldinit'.
		static NativeTypeStructHandler_27_0()
		{
			NativeTypeStructHandler_27_0.C0Lod1YsnP9NMttCcMn();
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000CEF4 File Offset: 0x0000B0F4
		internal static bool qDsXhBYJ62sNE8r5w13()
		{
			return NativeTypeStructHandler_27_0.G83LpHYyriwshVGixjp == null;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000CF08 File Offset: 0x0000B108
		internal static NativeTypeStructHandler_27_0 W16d60Yp95s8gVwlOL3()
		{
			return NativeTypeStructHandler_27_0.G83LpHYyriwshVGixjp;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000CF18 File Offset: 0x0000B118
		internal static void amD2gKYVIfAPjpZxU1i()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000CF28 File Offset: 0x0000B128
		internal static void c7ZwdRY0Tip3BLDsyjc()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000CF38 File Offset: 0x0000B138
		internal static void C0Lod1YsnP9NMttCcMn()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040000FF RID: 255
		private static NativeTypeStructHandler_27_0 G83LpHYyriwshVGixjp;

		// Token: 0x02000043 RID: 67
		internal struct Il2CppType_27_0
		{
			// Token: 0x04000100 RID: 256
			public unsafe void* data;

			// Token: 0x04000101 RID: 257
			public ushort attrs;

			// Token: 0x04000102 RID: 258
			public byte type;

			// Token: 0x04000103 RID: 259
			public NativeTypeStructHandler_27_0.Il2CppType_27_0.Bitfield0 _bitfield0;

			// Token: 0x02000044 RID: 68
			internal enum Bitfield0 : byte
			{
				// Token: 0x04000105 RID: 261
				BIT_byref = 5,
				// Token: 0x04000106 RID: 262
				byref = 32,
				// Token: 0x04000107 RID: 263
				BIT_pinned = 6,
				// Token: 0x04000108 RID: 264
				pinned = 64,
				// Token: 0x04000109 RID: 265
				BIT_valuetype = 7,
				// Token: 0x0400010A RID: 266
				valuetype = 128
			}
		}

		// Token: 0x02000045 RID: 69
		internal class NativeStructWrapper : INativeTypeStruct, INativeStruct
		{
			// Token: 0x060002D8 RID: 728 RVA: 0x0001802C File Offset: 0x0001622C
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeTypeStructHandler_27_0.NativeStructWrapper.gDGYrO0f6D5AGaDJYNA();
				NativeTypeStructHandler_27_0.NativeStructWrapper.ucAljv01TYcGEoNAiqG();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bac7568f2bc04130b6b980225b2cc409 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eeb967463afe407d8f7c3b354043704c == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060002D9 RID: 729 RVA: 0x000180BC File Offset: 0x000162BC
			private unsafe NativeTypeStructHandler_27_0.Il2CppType_27_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060002DA RID: 730 RVA: 0x000180CC File Offset: 0x000162CC
			public IntPtr Pointer { get; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060002DB RID: 731 RVA: 0x000180DC File Offset: 0x000162DC
			public unsafe Il2CppTypeStruct* TypePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060002DC RID: 732 RVA: 0x000180EC File Offset: 0x000162EC
			public unsafe ref IntPtr Data
			{
				get
				{
					return ref *(IntPtr*)(&this._->data);
				}
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060002DD RID: 733 RVA: 0x00018104 File Offset: 0x00016304
			public unsafe ref ushort Attrs
			{
				get
				{
					return ref this._->attrs;
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060002DE RID: 734 RVA: 0x00018118 File Offset: 0x00016318
			public unsafe ref Il2CppTypeEnum Type
			{
				get
				{
					return ref *(Il2CppTypeEnum*)(&this._->type);
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060002DF RID: 735 RVA: 0x00018130 File Offset: 0x00016330
			// (set) Token: 0x060002E0 RID: 736 RVA: 0x00018148 File Offset: 0x00016348
			public bool ByRef
			{
				get
				{
					return this.CheckBit(NativeTypeStructHandler_27_0.NativeStructWrapper._bitfield0offset, 5);
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
							NativeTypeStructHandler_27_0.NativeStructWrapper.hOcOFo0FB4jsaUvV8NL(this, NativeTypeStructHandler_27_0.NativeStructWrapper._bitfield0offset, 5, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_911808c58d664adeb7c16d1e3a32f7fa != 0)
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

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060002E1 RID: 737 RVA: 0x000181AC File Offset: 0x000163AC
			// (set) Token: 0x060002E2 RID: 738 RVA: 0x000181C4 File Offset: 0x000163C4
			public bool Pinned
			{
				get
				{
					return NativeTypeStructHandler_27_0.NativeStructWrapper.Gg6Nyj0RkvIiqdNXIX5(this, NativeTypeStructHandler_27_0.NativeStructWrapper._bitfield0offset, 6);
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
							NativeTypeStructHandler_27_0.NativeStructWrapper.hOcOFo0FB4jsaUvV8NL(this, NativeTypeStructHandler_27_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa == 0)
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

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060002E3 RID: 739 RVA: 0x00018228 File Offset: 0x00016428
			// (set) Token: 0x060002E4 RID: 740 RVA: 0x00018240 File Offset: 0x00016440
			public bool ValueType
			{
				get
				{
					return NativeTypeStructHandler_27_0.NativeStructWrapper.Gg6Nyj0RkvIiqdNXIX5(this, NativeTypeStructHandler_27_0.NativeStructWrapper._bitfield0offset, 7);
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
							NativeTypeStructHandler_27_0.NativeStructWrapper.hOcOFo0FB4jsaUvV8NL(this, NativeTypeStructHandler_27_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2ec67b9ff6c4cd7af2a4ceec32c111c == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x060002E5 RID: 741 RVA: 0x000182A4 File Offset: 0x000164A4
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
						NativeTypeStructHandler_27_0.NativeStructWrapper.ucAljv01TYcGEoNAiqG();
						num2 = 4;
						continue;
					case 2:
						NativeTypeStructHandler_27_0.NativeStructWrapper.gDGYrO0f6D5AGaDJYNA();
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ce8abd079f9447b3bade260ffc64f0b8 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						NativeTypeStructHandler_27_0.NativeStructWrapper.eJXto00MISYhEfDWNhN();
						num2 = 2;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4f0a774880f74bccb3d4511e5f526375 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						intPtr = Marshal.OffsetOf<NativeTypeStructHandler_27_0.Il2CppType_27_0>(NativeTypeStructHandler_27_0.NativeStructWrapper.hGERUJ0W2CelvXDysYP(-1817151529 ^ -2096121375 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae));
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7492c06848354e9185cf647bb6904451 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						return;
					}
					NativeTypeStructHandler_27_0.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e6eb36653ec04a89bf8fa64932849f3b != 0)
					{
						num2 = 5;
					}
				}
			}

			// Token: 0x060002E6 RID: 742 RVA: 0x000183B4 File Offset: 0x000165B4
			internal static void gDGYrO0f6D5AGaDJYNA()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x000183C4 File Offset: 0x000165C4
			internal static void ucAljv01TYcGEoNAiqG()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x000183D4 File Offset: 0x000165D4
			internal static bool wwVfgq049Wa08piPhGL()
			{
				return NativeTypeStructHandler_27_0.NativeStructWrapper.fWD9gl0PQoYoO3bu2JT == null;
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x000183E8 File Offset: 0x000165E8
			internal static NativeTypeStructHandler_27_0.NativeStructWrapper NQyXNI03W9s3VvjOXeS()
			{
				return NativeTypeStructHandler_27_0.NativeStructWrapper.fWD9gl0PQoYoO3bu2JT;
			}

			// Token: 0x060002EA RID: 746 RVA: 0x000183F8 File Offset: 0x000165F8
			internal static void hOcOFo0FB4jsaUvV8NL(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x060002EB RID: 747 RVA: 0x00018418 File Offset: 0x00016618
			internal static bool Gg6Nyj0RkvIiqdNXIX5(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060002EC RID: 748 RVA: 0x00018434 File Offset: 0x00016634
			internal static void eJXto00MISYhEfDWNhN()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x060002ED RID: 749 RVA: 0x00018444 File Offset: 0x00016644
			internal static object hGERUJ0W2CelvXDysYP(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x0400010B RID: 267
			private static readonly int _bitfield0offset;

			// Token: 0x0400010D RID: 269
			private static object fWD9gl0PQoYoO3bu2JT;
		}
	}
}
