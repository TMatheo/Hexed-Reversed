using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x02000076 RID: 118
	[ApplicableToUnityVersionsSince("2023.2.0")]
	public class NativeMethodInfoStructHandler_29_2 : INativeMethodInfoStructHandler, INativeStructHandler
	{
		// Token: 0x06000493 RID: 1171 RVA: 0x0000E5F0 File Offset: 0x0000C7F0
		public int Size()
		{
			return sizeof(NativeMethodInfoStructHandler_29_2.Il2CppMethodInfo_29_2);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0000E600 File Offset: 0x0000C800
		public unsafe INativeMethodInfoStruct CreateNewStruct()
		{
			NativeMethodInfoStructHandler_29_2.Il2CppMethodInfo_29_2* ptr2;
			IntPtr ptr = ptr2 = NativeMethodInfoStructHandler_29_2.muaYGB8Qpm4uub058vi(this.Size(), kskQ7OcVe6lBLZiQLab.EMjc0SIyEA);
			*ptr2 = default(NativeMethodInfoStructHandler_29_2.Il2CppMethodInfo_29_2);
			return new NativeMethodInfoStructHandler_29_2.NativeStructWrapper(ptr);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0000E634 File Offset: 0x0000C834
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_43cc35cb254148318955c7f83ade60f1 != 0)
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
			return new NativeMethodInfoStructHandler_29_2.NativeStructWrapper(ptr);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0000E69C File Offset: 0x0000C89C
		public NativeMethodInfoStructHandler_29_2()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeMethodInfoStructHandler_29_2.SvT0Af8efi8dltBhmTD();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_355d73c700924bf28058452e63cd9cf1 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000E700 File Offset: 0x0000C900
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethodInfoStructHandler_29_2()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0000E710 File Offset: 0x0000C910
		internal static IntPtr muaYGB8Qpm4uub058vi(int A_0, object A_1)
		{
			return kskQ7OcVe6lBLZiQLab.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0000E728 File Offset: 0x0000C928
		internal static bool y0OO1k8URT71HdAG0hE()
		{
			return NativeMethodInfoStructHandler_29_2.SrOLXq8oQEjQubDWljO == null;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0000E73C File Offset: 0x0000C93C
		internal static NativeMethodInfoStructHandler_29_2 HxGhkK8jfLitA14tgBx()
		{
			return NativeMethodInfoStructHandler_29_2.SrOLXq8oQEjQubDWljO;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0000E74C File Offset: 0x0000C94C
		internal static void SvT0Af8efi8dltBhmTD()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x040001DE RID: 478
		internal static NativeMethodInfoStructHandler_29_2 SrOLXq8oQEjQubDWljO;

		// Token: 0x02000077 RID: 119
		internal struct Il2CppMethodInfo_29_2
		{
			// Token: 0x040001DF RID: 479
			public unsafe void* methodPointer;

			// Token: 0x040001E0 RID: 480
			public unsafe void* virtualMethodPointer;

			// Token: 0x040001E1 RID: 481
			public unsafe void* invoker_method;

			// Token: 0x040001E2 RID: 482
			public unsafe byte* name;

			// Token: 0x040001E3 RID: 483
			public unsafe Il2CppClass* klass;

			// Token: 0x040001E4 RID: 484
			public unsafe Il2CppTypeStruct* return_type;

			// Token: 0x040001E5 RID: 485
			public unsafe Il2CppTypeStruct** parameters;

			// Token: 0x040001E6 RID: 486
			public unsafe void* runtime_data;

			// Token: 0x040001E7 RID: 487
			public unsafe void* generic_data;

			// Token: 0x040001E8 RID: 488
			public uint token;

			// Token: 0x040001E9 RID: 489
			public ushort flags;

			// Token: 0x040001EA RID: 490
			public ushort iflags;

			// Token: 0x040001EB RID: 491
			public ushort slot;

			// Token: 0x040001EC RID: 492
			public byte parameters_count;

			// Token: 0x040001ED RID: 493
			public NativeMethodInfoStructHandler_29_2.Il2CppMethodInfo_29_2.Bitfield0 _bitfield0;

			// Token: 0x02000078 RID: 120
			internal enum Bitfield0 : byte
			{
				// Token: 0x040001EF RID: 495
				BIT_is_generic,
				// Token: 0x040001F0 RID: 496
				is_generic,
				// Token: 0x040001F1 RID: 497
				BIT_is_inflated = 1,
				// Token: 0x040001F2 RID: 498
				is_inflated,
				// Token: 0x040001F3 RID: 499
				BIT_wrapper_type = 2,
				// Token: 0x040001F4 RID: 500
				wrapper_type = 4,
				// Token: 0x040001F5 RID: 501
				BIT_has_full_generic_sharing_signature = 3,
				// Token: 0x040001F6 RID: 502
				has_full_generic_sharing_signature = 8,
				// Token: 0x040001F7 RID: 503
				BIT_is_unmanaged_callers_only = 4,
				// Token: 0x040001F8 RID: 504
				is_unmanaged_callers_only = 16
			}
		}

		// Token: 0x02000079 RID: 121
		internal class NativeStructWrapper : INativeMethodInfoStruct, INativeStruct
		{
			// Token: 0x0600049C RID: 1180 RVA: 0x0001A808 File Offset: 0x00018A08
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeMethodInfoStructHandler_29_2.NativeStructWrapper.o4hBa1SdM5x5iji2iH3();
				NativeMethodInfoStructHandler_29_2.NativeStructWrapper.bTWpoVSi0AUdgIF1D1J();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5 != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cfadd7e02c524ea298356b7415bd67b6 != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x0600049D RID: 1181 RVA: 0x0001A898 File Offset: 0x00018A98
			public IntPtr Pointer { get; }

			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x0600049E RID: 1182 RVA: 0x0001A8A8 File Offset: 0x00018AA8
			private unsafe NativeMethodInfoStructHandler_29_2.Il2CppMethodInfo_29_2* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x0600049F RID: 1183 RVA: 0x0001A8B8 File Offset: 0x00018AB8
			public unsafe Il2CppMethodInfo* MethodInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0001A8C8 File Offset: 0x00018AC8
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0001A8E0 File Offset: 0x00018AE0
			public unsafe ref ushort Slot
			{
				get
				{
					return ref this._->slot;
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0001A8F4 File Offset: 0x00018AF4
			public unsafe ref IntPtr MethodPointer
			{
				get
				{
					return ref *(IntPtr*)(&this._->methodPointer);
				}
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x060004A3 RID: 1187 RVA: 0x0001A90C File Offset: 0x00018B0C
			public unsafe ref IntPtr VirtualMethodPointer
			{
				get
				{
					return ref *(IntPtr*)(&this._->virtualMethodPointer);
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0001A924 File Offset: 0x00018B24
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x060004A5 RID: 1189 RVA: 0x0001A938 File Offset: 0x00018B38
			public unsafe ref IntPtr InvokerMethod
			{
				get
				{
					return ref *(IntPtr*)(&this._->invoker_method);
				}
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0001A950 File Offset: 0x00018B50
			public unsafe ref Il2CppTypeStruct* ReturnType
			{
				get
				{
					return ref this._->return_type;
				}
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0001A964 File Offset: 0x00018B64
			public unsafe ref Il2CppMethodFlags Flags
			{
				get
				{
					return ref *(Il2CppMethodFlags*)(&this._->flags);
				}
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0001A97C File Offset: 0x00018B7C
			public unsafe ref byte ParametersCount
			{
				get
				{
					return ref this._->parameters_count;
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x060004A9 RID: 1193 RVA: 0x0001A990 File Offset: 0x00018B90
			public unsafe ref Il2CppParameterInfo* Parameters
			{
				get
				{
					return ref *(Il2CppParameterInfo**)(&this._->parameters);
				}
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x060004AA RID: 1194 RVA: 0x0001A9A8 File Offset: 0x00018BA8
			public unsafe ref uint Token
			{
				get
				{
					return ref this._->token;
				}
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x060004AB RID: 1195 RVA: 0x0001A9BC File Offset: 0x00018BBC
			// (set) Token: 0x060004AC RID: 1196 RVA: 0x0001A9D4 File Offset: 0x00018BD4
			public bool IsGeneric
			{
				get
				{
					return this.CheckBit(NativeMethodInfoStructHandler_29_2.NativeStructWrapper._bitfield0offset, 0);
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
							NativeMethodInfoStructHandler_29_2.NativeStructWrapper.vnVk77SwTsCRXHjtFLI(this, NativeMethodInfoStructHandler_29_2.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb34a81d7cc4fbea898664370a8645f == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x060004AD RID: 1197 RVA: 0x0001AA38 File Offset: 0x00018C38
			// (set) Token: 0x060004AE RID: 1198 RVA: 0x0001AA50 File Offset: 0x00018C50
			public bool IsInflated
			{
				get
				{
					return NativeMethodInfoStructHandler_29_2.NativeStructWrapper.chCVEASErRQYfn2uV3w(this, NativeMethodInfoStructHandler_29_2.NativeStructWrapper._bitfield0offset, 1);
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
							NativeMethodInfoStructHandler_29_2.NativeStructWrapper.vnVk77SwTsCRXHjtFLI(this, NativeMethodInfoStructHandler_29_2.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7ac65c3fd4cb4629a8b893be89aed17d != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x060004AF RID: 1199 RVA: 0x0001AAB4 File Offset: 0x00018CB4
			// (set) Token: 0x060004B0 RID: 1200 RVA: 0x0001AAC0 File Offset: 0x00018CC0
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

			// Token: 0x060004B1 RID: 1201 RVA: 0x0001AACC File Offset: 0x00018CCC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 3;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						NativeMethodInfoStructHandler_29_2.NativeStructWrapper.bTWpoVSi0AUdgIF1D1J();
						num2 = 5;
						continue;
					case 2:
						NativeMethodInfoStructHandler_29_2.NativeStructWrapper.o4hBa1SdM5x5iji2iH3();
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8b1b71d923f0486b89239dd4a11f6d34 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						NativeMethodInfoStructHandler_29_2.NativeStructWrapper.VtVUbgSBV6JXcmiboSK();
						num2 = 2;
						continue;
					case 4:
					{
						IntPtr intPtr;
						NativeMethodInfoStructHandler_29_2.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f6eb9387956a4e8c81dafbb2ecc8c7ab == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					case 5:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeMethodInfoStructHandler_29_2.Il2CppMethodInfo_29_2>(NativeMethodInfoStructHandler_29_2.NativeStructWrapper.lDXNX0SG0MYMG2Q8Dhd(1995169832 ^ 1668228019 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eec4384c7d0d42baa74a4dbdbdbdd8df));
						num2 = 4;
						continue;
					}
					}
					break;
				}
			}

			// Token: 0x060004B2 RID: 1202 RVA: 0x0001ABB4 File Offset: 0x00018DB4
			internal static void o4hBa1SdM5x5iji2iH3()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060004B3 RID: 1203 RVA: 0x0001ABC4 File Offset: 0x00018DC4
			internal static void bTWpoVSi0AUdgIF1D1J()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x060004B4 RID: 1204 RVA: 0x0001ABD4 File Offset: 0x00018DD4
			internal static bool aWaUTnS9TQXsHHnLFyR()
			{
				return NativeMethodInfoStructHandler_29_2.NativeStructWrapper.jQCDiTSCfRnqeZTCGT7 == null;
			}

			// Token: 0x060004B5 RID: 1205 RVA: 0x0001ABE8 File Offset: 0x00018DE8
			internal static NativeMethodInfoStructHandler_29_2.NativeStructWrapper zgDosmSINwlncFBd15Q()
			{
				return NativeMethodInfoStructHandler_29_2.NativeStructWrapper.jQCDiTSCfRnqeZTCGT7;
			}

			// Token: 0x060004B6 RID: 1206 RVA: 0x0001ABF8 File Offset: 0x00018DF8
			internal static void vnVk77SwTsCRXHjtFLI(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x060004B7 RID: 1207 RVA: 0x0001AC18 File Offset: 0x00018E18
			internal static bool chCVEASErRQYfn2uV3w(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060004B8 RID: 1208 RVA: 0x0001AC34 File Offset: 0x00018E34
			internal static void VtVUbgSBV6JXcmiboSK()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x060004B9 RID: 1209 RVA: 0x0001AC44 File Offset: 0x00018E44
			internal static object lDXNX0SG0MYMG2Q8Dhd(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x040001F9 RID: 505
			private static int _bitfield0offset;

			// Token: 0x040001FB RID: 507
			internal static object jQCDiTSCfRnqeZTCGT7;
		}
	}
}
