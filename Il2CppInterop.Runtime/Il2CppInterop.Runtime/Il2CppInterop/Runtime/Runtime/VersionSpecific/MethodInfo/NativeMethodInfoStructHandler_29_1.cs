using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x02000074 RID: 116
	[ApplicableToUnityVersionsSince("2022.1.0")]
	public class NativeMethodInfoStructHandler_29_1 : INativeMethodInfoStructHandler, INativeStructHandler
	{
		// Token: 0x0600048B RID: 1163 RVA: 0x0000F068 File Offset: 0x0000D268
		public int Size()
		{
			return sizeof(NativeMethodInfoStructHandler_29_1.Il2CppMethodInfo_29_1);
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0000F078 File Offset: 0x0000D278
		public unsafe INativeMethodInfoStruct CreateNewStruct()
		{
			NativeMethodInfoStructHandler_29_1.Il2CppMethodInfo_29_1* ptr2;
			IntPtr ptr = ptr2 = NativeMethodInfoStructHandler_29_1.mQl3Nwu96qnlGlQk78R(this.Size());
			*ptr2 = default(NativeMethodInfoStructHandler_29_1.Il2CppMethodInfo_29_1);
			return new NativeMethodInfoStructHandler_29_1.NativeStructWrapper(ptr);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9c5de7c7e06f4557898ef7a8362c30ee != 0)
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

		// Token: 0x0600048E RID: 1166 RVA: 0x0000F110 File Offset: 0x0000D310
		public NativeMethodInfoStructHandler_29_1()
		{
			NativeMethodInfoStructHandler_29_1.hgrRuMuiYoCQL8kHJcs();
			NativeMethodInfoStructHandler_29_1.F9NTE8uIGsjTFBD6ee4();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_feee416e61094c739ba253659ac2e257 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0000F174 File Offset: 0x0000D374
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethodInfoStructHandler_29_1()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0000F184 File Offset: 0x0000D384
		internal static IntPtr mQl3Nwu96qnlGlQk78R(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0000F198 File Offset: 0x0000D398
		internal static bool Cl9xStuUC2hN6bExbKR()
		{
			return NativeMethodInfoStructHandler_29_1.xHtLNjuA2NoQh25tGA7 == null;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0000F1AC File Offset: 0x0000D3AC
		internal static NativeMethodInfoStructHandler_29_1 Mb6G37uqwfcMNZiTMmd()
		{
			return NativeMethodInfoStructHandler_29_1.xHtLNjuA2NoQh25tGA7;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0000F1BC File Offset: 0x0000D3BC
		internal static void hgrRuMuiYoCQL8kHJcs()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0000F1CC File Offset: 0x0000D3CC
		internal static void F9NTE8uIGsjTFBD6ee4()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x040001CD RID: 461
		internal static NativeMethodInfoStructHandler_29_1 xHtLNjuA2NoQh25tGA7;

		// Token: 0x02000075 RID: 117
		internal struct Il2CppMethodInfo_29_1
		{
			// Token: 0x040001CE RID: 462
			public unsafe void* methodPointer;

			// Token: 0x040001CF RID: 463
			public unsafe void* virtualMethodPointer;

			// Token: 0x040001D0 RID: 464
			public unsafe void* invoker_method;

			// Token: 0x040001D1 RID: 465
			public unsafe byte* name;

			// Token: 0x040001D2 RID: 466
			public unsafe Il2CppClass* klass;

			// Token: 0x040001D3 RID: 467
			public unsafe Il2CppTypeStruct* return_type;

			// Token: 0x040001D4 RID: 468
			public unsafe Il2CppTypeStruct** parameters;

			// Token: 0x040001D5 RID: 469
			public unsafe void* runtime_data;

			// Token: 0x040001D6 RID: 470
			public unsafe void* generic_data;

			// Token: 0x040001D7 RID: 471
			public uint token;

			// Token: 0x040001D8 RID: 472
			public ushort flags;

			// Token: 0x040001D9 RID: 473
			public ushort iflags;

			// Token: 0x040001DA RID: 474
			public ushort slot;

			// Token: 0x040001DB RID: 475
			public byte parameters_count;

			// Token: 0x040001DC RID: 476
			public NativeMethodInfoStructHandler_29_1.Il2CppMethodInfo_29_1.Bitfield0 _bitfield0;

			// Token: 0x02000076 RID: 118
			internal enum Bitfield0 : byte
			{
				// Token: 0x040001DE RID: 478
				BIT_is_generic,
				// Token: 0x040001DF RID: 479
				is_generic,
				// Token: 0x040001E0 RID: 480
				BIT_is_inflated = 1,
				// Token: 0x040001E1 RID: 481
				is_inflated,
				// Token: 0x040001E2 RID: 482
				BIT_wrapper_type = 2,
				// Token: 0x040001E3 RID: 483
				wrapper_type = 4,
				// Token: 0x040001E4 RID: 484
				BIT_has_full_generic_sharing_signature = 3,
				// Token: 0x040001E5 RID: 485
				has_full_generic_sharing_signature = 8
			}
		}

		// Token: 0x02000077 RID: 119
		internal class NativeStructWrapper : INativeMethodInfoStruct, INativeStruct
		{
			// Token: 0x06000495 RID: 1173 RVA: 0x0001B090 File Offset: 0x00019290
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeMethodInfoStructHandler_29_1.NativeStructWrapper.RM9MDNrq3bf6kfw93OS();
				NativeMethodInfoStructHandler_29_1.NativeStructWrapper.cuH386r9ugdAiGRmoww();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7c2c0376e816400db5716cff194385b2 == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d1f9cbcd89d6464f81f56a1119f034c6 != 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x06000496 RID: 1174 RVA: 0x0001B120 File Offset: 0x00019320
			private unsafe NativeMethodInfoStructHandler_29_1.Il2CppMethodInfo_29_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x06000497 RID: 1175 RVA: 0x0001B130 File Offset: 0x00019330
			public IntPtr Pointer { get; }

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x06000498 RID: 1176 RVA: 0x0001B140 File Offset: 0x00019340
			public unsafe Il2CppMethodInfo* MethodInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x06000499 RID: 1177 RVA: 0x0001B150 File Offset: 0x00019350
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x0600049A RID: 1178 RVA: 0x0001B168 File Offset: 0x00019368
			public unsafe ref ushort Slot
			{
				get
				{
					return ref this._->slot;
				}
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x0600049B RID: 1179 RVA: 0x0001B17C File Offset: 0x0001937C
			public unsafe ref IntPtr MethodPointer
			{
				get
				{
					return ref *(IntPtr*)(&this._->methodPointer);
				}
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x0600049C RID: 1180 RVA: 0x0001B194 File Offset: 0x00019394
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x0600049D RID: 1181 RVA: 0x0001B1A8 File Offset: 0x000193A8
			public unsafe ref IntPtr InvokerMethod
			{
				get
				{
					return ref *(IntPtr*)(&this._->invoker_method);
				}
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x0600049E RID: 1182 RVA: 0x0001B1C0 File Offset: 0x000193C0
			public unsafe ref Il2CppTypeStruct* ReturnType
			{
				get
				{
					return ref this._->return_type;
				}
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x0600049F RID: 1183 RVA: 0x0001B1D4 File Offset: 0x000193D4
			public unsafe ref Il2CppMethodFlags Flags
			{
				get
				{
					return ref *(Il2CppMethodFlags*)(&this._->flags);
				}
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0001B1EC File Offset: 0x000193EC
			public unsafe ref byte ParametersCount
			{
				get
				{
					return ref this._->parameters_count;
				}
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0001B200 File Offset: 0x00019400
			public unsafe ref Il2CppParameterInfo* Parameters
			{
				get
				{
					return ref *(Il2CppParameterInfo**)(&this._->parameters);
				}
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0001B218 File Offset: 0x00019418
			public unsafe ref uint Token
			{
				get
				{
					return ref this._->token;
				}
			}

			// Token: 0x170000CE RID: 206
			// (get) Token: 0x060004A3 RID: 1187 RVA: 0x0001B22C File Offset: 0x0001942C
			// (set) Token: 0x060004A4 RID: 1188 RVA: 0x0001B244 File Offset: 0x00019444
			public bool IsGeneric
			{
				get
				{
					return NativeMethodInfoStructHandler_29_1.NativeStructWrapper.dqotA0ri0X9KHivkWrW(this, NativeMethodInfoStructHandler_29_1.NativeStructWrapper._bitfield0offset, 0);
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
							NativeMethodInfoStructHandler_29_1.NativeStructWrapper.xlsl5RrIsMgLQ1a0rU6(this, NativeMethodInfoStructHandler_29_1.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_18558c8f0d4f4774910664df1c51bd49 == 0)
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

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x060004A5 RID: 1189 RVA: 0x0001B2A8 File Offset: 0x000194A8
			// (set) Token: 0x060004A6 RID: 1190 RVA: 0x0001B2C0 File Offset: 0x000194C0
			public bool IsInflated
			{
				get
				{
					return NativeMethodInfoStructHandler_29_1.NativeStructWrapper.dqotA0ri0X9KHivkWrW(this, NativeMethodInfoStructHandler_29_1.NativeStructWrapper._bitfield0offset, 1);
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
							NativeMethodInfoStructHandler_29_1.NativeStructWrapper.xlsl5RrIsMgLQ1a0rU6(this, NativeMethodInfoStructHandler_29_1.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_74d61b1611df4615bd4df289712ea178 != 0)
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

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0001B324 File Offset: 0x00019524
			// (set) Token: 0x060004A8 RID: 1192 RVA: 0x0001B330 File Offset: 0x00019530
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

			// Token: 0x060004A9 RID: 1193 RVA: 0x0001B33C File Offset: 0x0001953C
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 5;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
					{
						IntPtr intPtr;
						NativeMethodInfoStructHandler_29_1.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 2;
						break;
					}
					case 1:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeMethodInfoStructHandler_29_1.Il2CppMethodInfo_29_1>(hIDAYxH6DWLHIthQgC.gSCeTtiku(-2007369155 ^ -292595251 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ba3f6bd5a09c47868765e25f534dbf2a));
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bd64431fd05f4961aa9b79e5bd243164 != 0)
						{
							num2 = 0;
						}
						break;
					}
					case 2:
						return;
					case 3:
						NativeMethodInfoStructHandler_29_1.NativeStructWrapper.cuH386r9ugdAiGRmoww();
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6926da1cf80047d3a6f0516668d22380 == 0)
						{
							num2 = 1;
						}
						break;
					case 4:
						NativeMethodInfoStructHandler_29_1.NativeStructWrapper.RM9MDNrq3bf6kfw93OS();
						num2 = 3;
						break;
					case 5:
						NativeMethodInfoStructHandler_29_1.NativeStructWrapper.bN0tAWrGOpKvLLtrp8v();
						num2 = 4;
						break;
					}
				}
			}

			// Token: 0x060004AA RID: 1194 RVA: 0x0001B424 File Offset: 0x00019624
			internal static void RM9MDNrq3bf6kfw93OS()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060004AB RID: 1195 RVA: 0x0001B434 File Offset: 0x00019634
			internal static void cuH386r9ugdAiGRmoww()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x060004AC RID: 1196 RVA: 0x0001B444 File Offset: 0x00019644
			internal static bool DgjPmGrAaERqkjBYrms()
			{
				return NativeMethodInfoStructHandler_29_1.NativeStructWrapper.ax8jxirHh0EyOCPVqiN == null;
			}

			// Token: 0x060004AD RID: 1197 RVA: 0x0001B458 File Offset: 0x00019658
			internal static NativeMethodInfoStructHandler_29_1.NativeStructWrapper tBYJGgrUiPIuZ0s3x9P()
			{
				return NativeMethodInfoStructHandler_29_1.NativeStructWrapper.ax8jxirHh0EyOCPVqiN;
			}

			// Token: 0x060004AE RID: 1198 RVA: 0x0001B468 File Offset: 0x00019668
			internal static bool dqotA0ri0X9KHivkWrW(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060004AF RID: 1199 RVA: 0x0001B484 File Offset: 0x00019684
			internal static void xlsl5RrIsMgLQ1a0rU6(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x060004B0 RID: 1200 RVA: 0x0001B4A4 File Offset: 0x000196A4
			internal static void bN0tAWrGOpKvLLtrp8v()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x040001E6 RID: 486
			private static readonly int _bitfield0offset;

			// Token: 0x040001E8 RID: 488
			internal static object ax8jxirHh0EyOCPVqiN;
		}
	}
}
