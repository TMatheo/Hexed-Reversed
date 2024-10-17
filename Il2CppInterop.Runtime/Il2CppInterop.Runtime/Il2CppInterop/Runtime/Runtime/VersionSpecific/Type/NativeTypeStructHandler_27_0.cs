using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Type
{
	// Token: 0x02000044 RID: 68
	[ApplicableToUnityVersionsSince("2021.1.0")]
	public class NativeTypeStructHandler_27_0 : INativeTypeStructHandler, INativeStructHandler
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x0000DA34 File Offset: 0x0000BC34
		public int Size()
		{
			return sizeof(NativeTypeStructHandler_27_0.Il2CppType_27_0);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000DA44 File Offset: 0x0000BC44
		public unsafe INativeTypeStruct CreateNewStruct()
		{
			NativeTypeStructHandler_27_0.Il2CppType_27_0* ptr2;
			IntPtr ptr = ptr2 = NativeTypeStructHandler_27_0.RDF5no0lXG9WKHX6jsi(this.Size());
			*ptr2 = default(NativeTypeStructHandler_27_0.Il2CppType_27_0);
			return new NativeTypeStructHandler_27_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000DA74 File Offset: 0x0000BC74
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6104a350572547c0a789887568cca07c == 0)
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

		// Token: 0x060002F9 RID: 761 RVA: 0x0000DADC File Offset: 0x0000BCDC
		public NativeTypeStructHandler_27_0()
		{
			NativeTypeStructHandler_27_0.hOyUfT0Vy4bCh3kHOu3();
			NativeTypeStructHandler_27_0.caBuK80OiCioCXnDCaA();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f0601de1a406461b9e99711ec5418371 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000DB40 File Offset: 0x0000BD40
		// Note: this type is marked as 'beforefieldinit'.
		static NativeTypeStructHandler_27_0()
		{
			NativeTypeStructHandler_27_0.Vwg4LU0XysU6vTsBEpV();
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000DB50 File Offset: 0x0000BD50
		internal static IntPtr RDF5no0lXG9WKHX6jsi(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000DB64 File Offset: 0x0000BD64
		internal static bool ct3umO0S7QR5fdQbREu()
		{
			return NativeTypeStructHandler_27_0.IPQuyV0yKVpdTpPVCq7 == null;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000DB78 File Offset: 0x0000BD78
		internal static NativeTypeStructHandler_27_0 d7mb1L0gFn1KqHBpOB7()
		{
			return NativeTypeStructHandler_27_0.IPQuyV0yKVpdTpPVCq7;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000DB88 File Offset: 0x0000BD88
		internal static void hOyUfT0Vy4bCh3kHOu3()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000DB98 File Offset: 0x0000BD98
		internal static void caBuK80OiCioCXnDCaA()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
		internal static void Vwg4LU0XysU6vTsBEpV()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400010A RID: 266
		internal static NativeTypeStructHandler_27_0 IPQuyV0yKVpdTpPVCq7;

		// Token: 0x02000045 RID: 69
		internal struct Il2CppType_27_0
		{
			// Token: 0x0400010B RID: 267
			public unsafe void* data;

			// Token: 0x0400010C RID: 268
			public ushort attrs;

			// Token: 0x0400010D RID: 269
			public byte type;

			// Token: 0x0400010E RID: 270
			public NativeTypeStructHandler_27_0.Il2CppType_27_0.Bitfield0 _bitfield0;

			// Token: 0x02000046 RID: 70
			internal enum Bitfield0 : byte
			{
				// Token: 0x04000110 RID: 272
				BIT_byref = 5,
				// Token: 0x04000111 RID: 273
				byref = 32,
				// Token: 0x04000112 RID: 274
				BIT_pinned = 6,
				// Token: 0x04000113 RID: 275
				pinned = 64,
				// Token: 0x04000114 RID: 276
				BIT_valuetype = 7,
				// Token: 0x04000115 RID: 277
				valuetype = 128
			}
		}

		// Token: 0x02000047 RID: 71
		internal class NativeStructWrapper : INativeTypeStruct, INativeStruct
		{
			// Token: 0x06000301 RID: 769 RVA: 0x00018D64 File Offset: 0x00016F64
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeTypeStructHandler_27_0.NativeStructWrapper.vav9VeJtUfuXONIrvIS();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d01f42186cf2421f90d71301ed147eb1 == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9c5de7c7e06f4557898ef7a8362c30ee != 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000302 RID: 770 RVA: 0x00018DF4 File Offset: 0x00016FF4
			private unsafe NativeTypeStructHandler_27_0.Il2CppType_27_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000303 RID: 771 RVA: 0x00018E04 File Offset: 0x00017004
			public IntPtr Pointer { get; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000304 RID: 772 RVA: 0x00018E14 File Offset: 0x00017014
			public unsafe Il2CppTypeStruct* TypePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000305 RID: 773 RVA: 0x00018E24 File Offset: 0x00017024
			public unsafe ref IntPtr Data
			{
				get
				{
					return ref *(IntPtr*)(&this._->data);
				}
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000306 RID: 774 RVA: 0x00018E3C File Offset: 0x0001703C
			public unsafe ref ushort Attrs
			{
				get
				{
					return ref this._->attrs;
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000307 RID: 775 RVA: 0x00018E50 File Offset: 0x00017050
			public unsafe ref Il2CppTypeEnum Type
			{
				get
				{
					return ref *(Il2CppTypeEnum*)(&this._->type);
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000308 RID: 776 RVA: 0x00018E68 File Offset: 0x00017068
			// (set) Token: 0x06000309 RID: 777 RVA: 0x00018E80 File Offset: 0x00017080
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
						default:
							return;
						case 1:
							NativeTypeStructHandler_27_0.NativeStructWrapper.d9lsE2Jxo4MwlyTRTES(this, NativeTypeStructHandler_27_0.NativeStructWrapper._bitfield0offset, 5, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_37633ff27b934257920d0d03faf0bd54 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600030A RID: 778 RVA: 0x00018EE4 File Offset: 0x000170E4
			// (set) Token: 0x0600030B RID: 779 RVA: 0x00018EFC File Offset: 0x000170FC
			public bool Pinned
			{
				get
				{
					return this.CheckBit(NativeTypeStructHandler_27_0.NativeStructWrapper._bitfield0offset, 6);
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
							NativeTypeStructHandler_27_0.NativeStructWrapper.d9lsE2Jxo4MwlyTRTES(this, NativeTypeStructHandler_27_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56c162609824bd799f0a7b9a8c33c89 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x0600030C RID: 780 RVA: 0x00018F60 File Offset: 0x00017160
			// (set) Token: 0x0600030D RID: 781 RVA: 0x00018F78 File Offset: 0x00017178
			public bool ValueType
			{
				get
				{
					return this.CheckBit(NativeTypeStructHandler_27_0.NativeStructWrapper._bitfield0offset, 7);
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
							NativeTypeStructHandler_27_0.NativeStructWrapper.d9lsE2Jxo4MwlyTRTES(this, NativeTypeStructHandler_27_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_806dbdb7f5194c2fa0c07a915df13fc8 == 0)
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

			// Token: 0x0600030E RID: 782 RVA: 0x00018FDC File Offset: 0x000171DC
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
						NativeTypeStructHandler_27_0.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 5;
						continue;
					case 2:
						NativeTypeStructHandler_27_0.NativeStructWrapper.vav9VeJtUfuXONIrvIS();
						num2 = 4;
						continue;
					case 3:
						hIDAYxH6DWLHIthQgC.zSLipEDdx();
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3af7919884e4482186590a3e6e04f119 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						NativeTypeStructHandler_27_0.NativeStructWrapper.m4H2BQJhvmFExwEMPNZ();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c4640bbaac7c4988b56f91d1b6b3f1a9 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						return;
					}
					intPtr = Marshal.OffsetOf<NativeTypeStructHandler_27_0.Il2CppType_27_0>(hIDAYxH6DWLHIthQgC.gSCeTtiku(-866075606 ^ -21004689 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9cbee6d56f49422699718938ff979567));
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f65b5965aa9843ea8b738fef02a2c6c9 != 0)
					{
						num2 = 1;
					}
				}
			}

			// Token: 0x0600030F RID: 783 RVA: 0x000190D8 File Offset: 0x000172D8
			internal static void vav9VeJtUfuXONIrvIS()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000310 RID: 784 RVA: 0x000190E8 File Offset: 0x000172E8
			internal static bool d27X2vJaAVyKVCmJxi3()
			{
				return NativeTypeStructHandler_27_0.NativeStructWrapper.Htla4xJYok7eZDEGP1M == null;
			}

			// Token: 0x06000311 RID: 785 RVA: 0x000190FC File Offset: 0x000172FC
			internal static NativeTypeStructHandler_27_0.NativeStructWrapper dUVPAdJCMZXTAy2IqKq()
			{
				return NativeTypeStructHandler_27_0.NativeStructWrapper.Htla4xJYok7eZDEGP1M;
			}

			// Token: 0x06000312 RID: 786 RVA: 0x0001910C File Offset: 0x0001730C
			internal static void d9lsE2Jxo4MwlyTRTES(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000313 RID: 787 RVA: 0x0001912C File Offset: 0x0001732C
			internal static void m4H2BQJhvmFExwEMPNZ()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x04000116 RID: 278
			private static readonly int _bitfield0offset;

			// Token: 0x04000118 RID: 280
			internal static object Htla4xJYok7eZDEGP1M;
		}
	}
}
