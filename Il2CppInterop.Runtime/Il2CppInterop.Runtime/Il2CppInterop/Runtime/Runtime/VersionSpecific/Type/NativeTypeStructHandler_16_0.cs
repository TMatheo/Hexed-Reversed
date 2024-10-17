using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Type
{
	// Token: 0x02000040 RID: 64
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeTypeStructHandler_16_0 : INativeTypeStructHandler, INativeStructHandler
	{
		// Token: 0x060002D5 RID: 725 RVA: 0x0000D8B0 File Offset: 0x0000BAB0
		public int Size()
		{
			return sizeof(NativeTypeStructHandler_16_0.Il2CppType_16_0);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		public unsafe INativeTypeStruct CreateNewStruct()
		{
			NativeTypeStructHandler_16_0.Il2CppType_16_0* ptr2;
			IntPtr ptr = ptr2 = NativeTypeStructHandler_16_0.Fnc9JK0eA4Fi82CEMGo(this.Size());
			*ptr2 = default(NativeTypeStructHandler_16_0.Il2CppType_16_0);
			return new NativeTypeStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bc244a0192c343599cd1cf83671e02ab != 0)
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
			return new NativeTypeStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000D958 File Offset: 0x0000BB58
		public NativeTypeStructHandler_16_0()
		{
			NativeTypeStructHandler_16_0.VhgbBu0sl6SYRYVSW4r();
			NativeTypeStructHandler_16_0.SOUyuN0QGyNxp6HNKH1();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7c2c0376e816400db5716cff194385b2 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000D9BC File Offset: 0x0000BBBC
		// Note: this type is marked as 'beforefieldinit'.
		static NativeTypeStructHandler_16_0()
		{
			NativeTypeStructHandler_16_0.iRXVPj02Jq1Qo9yTRgG();
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000D9CC File Offset: 0x0000BBCC
		internal static IntPtr Fnc9JK0eA4Fi82CEMGo(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		internal static bool xvKu1O0dH7waQdFvdVb()
		{
			return NativeTypeStructHandler_16_0.DRLvMa0PTpMuSRxG80h == null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000D9F4 File Offset: 0x0000BBF4
		internal static NativeTypeStructHandler_16_0 UAde3L0wHN5ugyd8hJB()
		{
			return NativeTypeStructHandler_16_0.DRLvMa0PTpMuSRxG80h;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000DA04 File Offset: 0x0000BC04
		internal static void VhgbBu0sl6SYRYVSW4r()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000DA14 File Offset: 0x0000BC14
		internal static void SOUyuN0QGyNxp6HNKH1()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000DA24 File Offset: 0x0000BC24
		internal static void iRXVPj02Jq1Qo9yTRgG()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040000FD RID: 253
		internal static NativeTypeStructHandler_16_0 DRLvMa0PTpMuSRxG80h;

		// Token: 0x02000041 RID: 65
		internal struct Il2CppType_16_0
		{
			// Token: 0x040000FE RID: 254
			public unsafe void* data;

			// Token: 0x040000FF RID: 255
			public ushort attrs;

			// Token: 0x04000100 RID: 256
			public byte type;

			// Token: 0x04000101 RID: 257
			public NativeTypeStructHandler_16_0.Il2CppType_16_0.Bitfield0 _bitfield0;

			// Token: 0x02000042 RID: 66
			internal enum Bitfield0 : byte
			{
				// Token: 0x04000103 RID: 259
				BIT_byref = 6,
				// Token: 0x04000104 RID: 260
				byref = 64,
				// Token: 0x04000105 RID: 261
				BIT_pinned = 7,
				// Token: 0x04000106 RID: 262
				pinned = 128
			}
		}

		// Token: 0x02000043 RID: 67
		internal class NativeStructWrapper : INativeTypeStruct, INativeStruct
		{
			// Token: 0x060002E0 RID: 736 RVA: 0x000189B0 File Offset: 0x00016BB0
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeTypeStructHandler_16_0.NativeStructWrapper.XPyabskzN2Esm0haHh2();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c733963b5aa3462f9be5a2d711359fa7 == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_01c6e15d1fd54ef9b78826bf2944de2a == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060002E1 RID: 737 RVA: 0x00018A40 File Offset: 0x00016C40
			private unsafe NativeTypeStructHandler_16_0.Il2CppType_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x060002E2 RID: 738 RVA: 0x00018A50 File Offset: 0x00016C50
			public IntPtr Pointer { get; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x060002E3 RID: 739 RVA: 0x00018A60 File Offset: 0x00016C60
			public unsafe Il2CppTypeStruct* TypePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x060002E4 RID: 740 RVA: 0x00018A70 File Offset: 0x00016C70
			public unsafe ref IntPtr Data
			{
				get
				{
					return ref *(IntPtr*)(&this._->data);
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x060002E5 RID: 741 RVA: 0x00018A88 File Offset: 0x00016C88
			public unsafe ref ushort Attrs
			{
				get
				{
					return ref this._->attrs;
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x060002E6 RID: 742 RVA: 0x00018A9C File Offset: 0x00016C9C
			public unsafe ref Il2CppTypeEnum Type
			{
				get
				{
					return ref *(Il2CppTypeEnum*)(&this._->type);
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x060002E7 RID: 743 RVA: 0x00018AB4 File Offset: 0x00016CB4
			// (set) Token: 0x060002E8 RID: 744 RVA: 0x00018ACC File Offset: 0x00016CCC
			public bool ByRef
			{
				get
				{
					return NativeTypeStructHandler_16_0.NativeStructWrapper.mxnlc2JHkfVMnsTdktW(this, NativeTypeStructHandler_16_0.NativeStructWrapper._bitfield0offset, 6);
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
							NativeTypeStructHandler_16_0.NativeStructWrapper.GnMI5xJA5DhqcdJoYJ8(this, NativeTypeStructHandler_16_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c32cfeb41f7a43999be3bae16a94ad02 != 0)
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
			// (get) Token: 0x060002E9 RID: 745 RVA: 0x00018B30 File Offset: 0x00016D30
			// (set) Token: 0x060002EA RID: 746 RVA: 0x00018B48 File Offset: 0x00016D48
			public bool Pinned
			{
				get
				{
					return NativeTypeStructHandler_16_0.NativeStructWrapper.mxnlc2JHkfVMnsTdktW(this, NativeTypeStructHandler_16_0.NativeStructWrapper._bitfield0offset, 7);
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
							NativeTypeStructHandler_16_0.NativeStructWrapper.GnMI5xJA5DhqcdJoYJ8(this, NativeTypeStructHandler_16_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_75b92ac812f348208c578c3de71e2d57 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060002EB RID: 747 RVA: 0x00018BAC File Offset: 0x00016DAC
			// (set) Token: 0x060002EC RID: 748 RVA: 0x00018BB8 File Offset: 0x00016DB8
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

			// Token: 0x060002ED RID: 749 RVA: 0x00018BC4 File Offset: 0x00016DC4
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
						NativeTypeStructHandler_16_0.NativeStructWrapper.aYe6m3JUe8PCbCOBMfe();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2dd85386720b438b874026b47430e4fa == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeTypeStructHandler_16_0.Il2CppType_16_0>(NativeTypeStructHandler_16_0.NativeStructWrapper.MDJ187J9wbMOgIiZj6g(~-572906782 ^ 1872895969 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6926da1cf80047d3a6f0516668d22380));
						num2 = 4;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bacedfb8a3cf4671ae3e03ec2f965495 == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					case 3:
						NativeTypeStructHandler_16_0.NativeStructWrapper.Kiys6kJq198U0cABvey();
						num2 = 2;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56a961858094410b8d2e4da57d386f1 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
					{
						IntPtr intPtr;
						NativeTypeStructHandler_16_0.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 5;
						continue;
					}
					case 5:
						return;
					}
					NativeTypeStructHandler_16_0.NativeStructWrapper.XPyabskzN2Esm0haHh2();
					num2 = 3;
				}
			}

			// Token: 0x060002EE RID: 750 RVA: 0x00018CC0 File Offset: 0x00016EC0
			internal static void XPyabskzN2Esm0haHh2()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060002EF RID: 751 RVA: 0x00018CD0 File Offset: 0x00016ED0
			internal static bool TG8jlskpqRngaEqm2tT()
			{
				return NativeTypeStructHandler_16_0.NativeStructWrapper.CJkOy2kM3X5qxrvDvYJ == null;
			}

			// Token: 0x060002F0 RID: 752 RVA: 0x00018CE4 File Offset: 0x00016EE4
			internal static NativeTypeStructHandler_16_0.NativeStructWrapper NpeERNk4jHQVf2fvOmj()
			{
				return NativeTypeStructHandler_16_0.NativeStructWrapper.CJkOy2kM3X5qxrvDvYJ;
			}

			// Token: 0x060002F1 RID: 753 RVA: 0x00018CF4 File Offset: 0x00016EF4
			internal static bool mxnlc2JHkfVMnsTdktW(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060002F2 RID: 754 RVA: 0x00018D10 File Offset: 0x00016F10
			internal static void GnMI5xJA5DhqcdJoYJ8(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x060002F3 RID: 755 RVA: 0x00018D30 File Offset: 0x00016F30
			internal static void aYe6m3JUe8PCbCOBMfe()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x060002F4 RID: 756 RVA: 0x00018D40 File Offset: 0x00016F40
			internal static void Kiys6kJq198U0cABvey()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x060002F5 RID: 757 RVA: 0x00018D50 File Offset: 0x00016F50
			internal static object MDJ187J9wbMOgIiZj6g(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000107 RID: 263
			private static readonly int _bitfield0offset;

			// Token: 0x04000109 RID: 265
			internal static object CJkOy2kM3X5qxrvDvYJ;
		}
	}
}
