using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x0200006C RID: 108
	[ApplicableToUnityVersionsSince("2018.3.0")]
	public class NativeMethodInfoStructHandler_24_1 : INativeMethodInfoStructHandler, INativeStructHandler
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x0000ED84 File Offset: 0x0000CF84
		public int Size()
		{
			return sizeof(NativeMethodInfoStructHandler_24_1.Il2CppMethodInfo_24_1);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000ED94 File Offset: 0x0000CF94
		public unsafe INativeMethodInfoStruct CreateNewStruct()
		{
			NativeMethodInfoStructHandler_24_1.Il2CppMethodInfo_24_1* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeMethodInfoStructHandler_24_1.Il2CppMethodInfo_24_1);
			return new NativeMethodInfoStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000EDC4 File Offset: 0x0000CFC4
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_39f2b5d6802b4ad087933b982faeb79d == 0)
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
			return new NativeMethodInfoStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000EE2C File Offset: 0x0000D02C
		public NativeMethodInfoStructHandler_24_1()
		{
			NativeMethodInfoStructHandler_24_1.Xrrmr4N5ZgkWnnPJvkH();
			NativeMethodInfoStructHandler_24_1.iAU2SJNnxvd5w6yIkn7();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_16defe672aac4a3485dcd78387beb521 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000EE90 File Offset: 0x0000D090
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethodInfoStructHandler_24_1()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000EEA0 File Offset: 0x0000D0A0
		internal static bool OhpptrNFuWfvwOHbp5P()
		{
			return NativeMethodInfoStructHandler_24_1.ndPXl1NTRAgbLg65Ix9 == null;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000EEB4 File Offset: 0x0000D0B4
		internal static NativeMethodInfoStructHandler_24_1 PAtHV0NK5SmeSfc9tLN()
		{
			return NativeMethodInfoStructHandler_24_1.ndPXl1NTRAgbLg65Ix9;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000EEC4 File Offset: 0x0000D0C4
		internal static void Xrrmr4N5ZgkWnnPJvkH()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000EED4 File Offset: 0x0000D0D4
		internal static void iAU2SJNnxvd5w6yIkn7()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x04000194 RID: 404
		internal static NativeMethodInfoStructHandler_24_1 ndPXl1NTRAgbLg65Ix9;

		// Token: 0x0200006D RID: 109
		internal struct Il2CppMethodInfo_24_1
		{
			// Token: 0x04000195 RID: 405
			public unsafe void* methodPointer;

			// Token: 0x04000196 RID: 406
			public unsafe void* invoker_method;

			// Token: 0x04000197 RID: 407
			public unsafe byte* name;

			// Token: 0x04000198 RID: 408
			public unsafe Il2CppClass* klass;

			// Token: 0x04000199 RID: 409
			public unsafe Il2CppTypeStruct* return_type;

			// Token: 0x0400019A RID: 410
			public unsafe Il2CppParameterInfo* parameters;

			// Token: 0x0400019B RID: 411
			public unsafe void* runtime_data;

			// Token: 0x0400019C RID: 412
			public unsafe void* generic_data;

			// Token: 0x0400019D RID: 413
			public uint token;

			// Token: 0x0400019E RID: 414
			public ushort flags;

			// Token: 0x0400019F RID: 415
			public ushort iflags;

			// Token: 0x040001A0 RID: 416
			public ushort slot;

			// Token: 0x040001A1 RID: 417
			public byte parameters_count;

			// Token: 0x040001A2 RID: 418
			public NativeMethodInfoStructHandler_24_1.Il2CppMethodInfo_24_1.Bitfield0 _bitfield0;

			// Token: 0x0200006E RID: 110
			internal enum Bitfield0 : byte
			{
				// Token: 0x040001A4 RID: 420
				BIT_is_generic,
				// Token: 0x040001A5 RID: 421
				is_generic,
				// Token: 0x040001A6 RID: 422
				BIT_is_inflated = 1,
				// Token: 0x040001A7 RID: 423
				is_inflated,
				// Token: 0x040001A8 RID: 424
				BIT_wrapper_type = 2,
				// Token: 0x040001A9 RID: 425
				wrapper_type = 4,
				// Token: 0x040001AA RID: 426
				BIT_is_marshaled_from_native = 3,
				// Token: 0x040001AB RID: 427
				is_marshaled_from_native = 8
			}
		}

		// Token: 0x0200006F RID: 111
		internal class NativeStructWrapper : INativeMethodInfoStruct, INativeStruct
		{
			// Token: 0x06000448 RID: 1096 RVA: 0x0001A7B0 File Offset: 0x000189B0
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeMethodInfoStructHandler_24_1.NativeStructWrapper.eDyQlIWlTaZGsaLn1Fn();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_dbbda98ba6574101bc623ad559f7b5a3 == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b3f1fcfa11104bd49a7f00386d38b4f4 == 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x06000449 RID: 1097 RVA: 0x0001A840 File Offset: 0x00018A40
			private unsafe NativeMethodInfoStructHandler_24_1.Il2CppMethodInfo_24_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x0600044A RID: 1098 RVA: 0x0001A850 File Offset: 0x00018A50
			public IntPtr Pointer { get; }

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x0600044B RID: 1099 RVA: 0x0001A860 File Offset: 0x00018A60
			public unsafe Il2CppMethodInfo* MethodInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x0600044C RID: 1100 RVA: 0x0001A870 File Offset: 0x00018A70
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x0600044D RID: 1101 RVA: 0x0001A888 File Offset: 0x00018A88
			public unsafe ref ushort Slot
			{
				get
				{
					return ref this._->slot;
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x0600044E RID: 1102 RVA: 0x0001A89C File Offset: 0x00018A9C
			public unsafe ref IntPtr MethodPointer
			{
				get
				{
					return ref *(IntPtr*)(&this._->methodPointer);
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x0600044F RID: 1103 RVA: 0x0001A8B4 File Offset: 0x00018AB4
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x06000450 RID: 1104 RVA: 0x0001A8C8 File Offset: 0x00018AC8
			public unsafe ref IntPtr InvokerMethod
			{
				get
				{
					return ref *(IntPtr*)(&this._->invoker_method);
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x06000451 RID: 1105 RVA: 0x0001A8E0 File Offset: 0x00018AE0
			public unsafe ref Il2CppTypeStruct* ReturnType
			{
				get
				{
					return ref this._->return_type;
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x06000452 RID: 1106 RVA: 0x0001A8F4 File Offset: 0x00018AF4
			public unsafe ref Il2CppMethodFlags Flags
			{
				get
				{
					return ref *(Il2CppMethodFlags*)(&this._->flags);
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x06000453 RID: 1107 RVA: 0x0001A90C File Offset: 0x00018B0C
			public unsafe ref byte ParametersCount
			{
				get
				{
					return ref this._->parameters_count;
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x06000454 RID: 1108 RVA: 0x0001A920 File Offset: 0x00018B20
			public unsafe ref Il2CppParameterInfo* Parameters
			{
				get
				{
					return ref this._->parameters;
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x06000455 RID: 1109 RVA: 0x0001A934 File Offset: 0x00018B34
			public unsafe ref uint Token
			{
				get
				{
					return ref this._->token;
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x06000456 RID: 1110 RVA: 0x0001A948 File Offset: 0x00018B48
			// (set) Token: 0x06000457 RID: 1111 RVA: 0x0001A960 File Offset: 0x00018B60
			public bool IsGeneric
			{
				get
				{
					return NativeMethodInfoStructHandler_24_1.NativeStructWrapper.zYTGylWVxW3lmuv9FJ4(this, NativeMethodInfoStructHandler_24_1.NativeStructWrapper._bitfield0offset, 0);
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
							NativeMethodInfoStructHandler_24_1.NativeStructWrapper.JETA3KWOj4xIjVwWspO(this, NativeMethodInfoStructHandler_24_1.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_49c6a53db2614593b5468905d8aba004 == 0)
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
			// (get) Token: 0x06000458 RID: 1112 RVA: 0x0001A9C4 File Offset: 0x00018BC4
			// (set) Token: 0x06000459 RID: 1113 RVA: 0x0001A9DC File Offset: 0x00018BDC
			public bool IsInflated
			{
				get
				{
					return NativeMethodInfoStructHandler_24_1.NativeStructWrapper.zYTGylWVxW3lmuv9FJ4(this, NativeMethodInfoStructHandler_24_1.NativeStructWrapper._bitfield0offset, 1);
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
							this.SetBit(NativeMethodInfoStructHandler_24_1.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d1f9cbcd89d6464f81f56a1119f034c6 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x0600045A RID: 1114 RVA: 0x0001AA40 File Offset: 0x00018C40
			// (set) Token: 0x0600045B RID: 1115 RVA: 0x0001AA58 File Offset: 0x00018C58
			public bool IsMarshalledFromNative
			{
				get
				{
					return NativeMethodInfoStructHandler_24_1.NativeStructWrapper.zYTGylWVxW3lmuv9FJ4(this, NativeMethodInfoStructHandler_24_1.NativeStructWrapper._bitfield0offset, 3);
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
							NativeMethodInfoStructHandler_24_1.NativeStructWrapper.JETA3KWOj4xIjVwWspO(this, NativeMethodInfoStructHandler_24_1.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9a3e85e731764e36a5b07f4e692becd8 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x0600045C RID: 1116 RVA: 0x0001AABC File Offset: 0x00018CBC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 4;
				int num2 = num;
				for (;;)
				{
					IntPtr intPtr;
					switch (num2)
					{
					case 1:
						return;
					case 2:
						nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						hIDAYxH6DWLHIthQgC.oDuBOTgYK();
						num2 = 2;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_483eecf3691e4ef2b23b2d4cb2ca3d52 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						NativeMethodInfoStructHandler_24_1.NativeStructWrapper.NtvUudWXN7uaVNGQ7C1();
						num2 = 3;
						continue;
					case 5:
						NativeMethodInfoStructHandler_24_1.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_61a3825996b24609815f6b482bf680d9 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					intPtr = Marshal.OffsetOf<NativeMethodInfoStructHandler_24_1.Il2CppMethodInfo_24_1>(hIDAYxH6DWLHIthQgC.gSCeTtiku(1253386989 << 6 ^ -523404868 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6926da1cf80047d3a6f0516668d22380));
					num2 = 5;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5c4dec7c475342669cbf3c1205f935ba == 0)
					{
						num2 = 5;
					}
				}
			}

			// Token: 0x0600045D RID: 1117 RVA: 0x0001ABD4 File Offset: 0x00018DD4
			internal static void eDyQlIWlTaZGsaLn1Fn()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x0600045E RID: 1118 RVA: 0x0001ABE4 File Offset: 0x00018DE4
			internal static bool j81Pr6WSPw7SW2uLtHN()
			{
				return NativeMethodInfoStructHandler_24_1.NativeStructWrapper.W8GHh6WyX2DcfPSAYme == null;
			}

			// Token: 0x0600045F RID: 1119 RVA: 0x0001ABF8 File Offset: 0x00018DF8
			internal static NativeMethodInfoStructHandler_24_1.NativeStructWrapper El74J4WgB9llXJquqDY()
			{
				return NativeMethodInfoStructHandler_24_1.NativeStructWrapper.W8GHh6WyX2DcfPSAYme;
			}

			// Token: 0x06000460 RID: 1120 RVA: 0x0001AC08 File Offset: 0x00018E08
			internal static bool zYTGylWVxW3lmuv9FJ4(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000461 RID: 1121 RVA: 0x0001AC24 File Offset: 0x00018E24
			internal static void JETA3KWOj4xIjVwWspO(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000462 RID: 1122 RVA: 0x0001AC44 File Offset: 0x00018E44
			internal static void NtvUudWXN7uaVNGQ7C1()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x040001AC RID: 428
			private static readonly int _bitfield0offset;

			// Token: 0x040001AE RID: 430
			private static object W8GHh6WyX2DcfPSAYme;
		}
	}
}
