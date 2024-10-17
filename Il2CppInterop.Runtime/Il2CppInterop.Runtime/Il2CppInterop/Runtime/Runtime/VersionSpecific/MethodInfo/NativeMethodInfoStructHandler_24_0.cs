using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x02000068 RID: 104
	[ApplicableToUnityVersionsSince("2018.1.0")]
	public class NativeMethodInfoStructHandler_24_0 : INativeMethodInfoStructHandler, INativeStructHandler
	{
		// Token: 0x0600041A RID: 1050 RVA: 0x0000EC34 File Offset: 0x0000CE34
		public int Size()
		{
			return sizeof(NativeMethodInfoStructHandler_24_0.Il2CppMethodInfo_24_0);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000EC44 File Offset: 0x0000CE44
		public unsafe INativeMethodInfoStruct CreateNewStruct()
		{
			NativeMethodInfoStructHandler_24_0.Il2CppMethodInfo_24_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeMethodInfoStructHandler_24_0.Il2CppMethodInfo_24_0);
			return new NativeMethodInfoStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0000EC74 File Offset: 0x0000CE74
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4e45528af4644e9b080e05d5ff6ef54 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeMethodInfoStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000ECDC File Offset: 0x0000CEDC
		public NativeMethodInfoStructHandler_24_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeMethodInfoStructHandler_24_0.fy3TRvNjgH2tKSWw48R();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_89e7beae9a774fb691cacbb26b1d9330 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0000ED40 File Offset: 0x0000CF40
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethodInfoStructHandler_24_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0000ED50 File Offset: 0x0000CF50
		internal static bool U0Ep6CNvJpykxPAQh9u()
		{
			return NativeMethodInfoStructHandler_24_0.hmkQpLNmbE8J4ynyE6o == null;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000ED64 File Offset: 0x0000CF64
		internal static NativeMethodInfoStructHandler_24_0 MqMqyhNB6vye4kUZ2es()
		{
			return NativeMethodInfoStructHandler_24_0.hmkQpLNmbE8J4ynyE6o;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000ED74 File Offset: 0x0000CF74
		internal static void fy3TRvNjgH2tKSWw48R()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x04000178 RID: 376
		private static NativeMethodInfoStructHandler_24_0 hmkQpLNmbE8J4ynyE6o;

		// Token: 0x02000069 RID: 105
		internal struct Il2CppMethodInfo_24_0
		{
			// Token: 0x04000179 RID: 377
			public unsafe void* methodPointer;

			// Token: 0x0400017A RID: 378
			public unsafe void* invoker_method;

			// Token: 0x0400017B RID: 379
			public unsafe byte* name;

			// Token: 0x0400017C RID: 380
			public unsafe Il2CppClass* klass;

			// Token: 0x0400017D RID: 381
			public unsafe Il2CppTypeStruct* return_type;

			// Token: 0x0400017E RID: 382
			public unsafe Il2CppParameterInfo* parameters;

			// Token: 0x0400017F RID: 383
			public unsafe void* runtime_data;

			// Token: 0x04000180 RID: 384
			public unsafe void* generic_data;

			// Token: 0x04000181 RID: 385
			public int customAttributeIndex;

			// Token: 0x04000182 RID: 386
			public uint token;

			// Token: 0x04000183 RID: 387
			public ushort flags;

			// Token: 0x04000184 RID: 388
			public ushort iflags;

			// Token: 0x04000185 RID: 389
			public ushort slot;

			// Token: 0x04000186 RID: 390
			public byte parameters_count;

			// Token: 0x04000187 RID: 391
			public NativeMethodInfoStructHandler_24_0.Il2CppMethodInfo_24_0.Bitfield0 _bitfield0;

			// Token: 0x0200006A RID: 106
			internal enum Bitfield0 : byte
			{
				// Token: 0x04000189 RID: 393
				BIT_is_generic,
				// Token: 0x0400018A RID: 394
				is_generic,
				// Token: 0x0400018B RID: 395
				BIT_is_inflated = 1,
				// Token: 0x0400018C RID: 396
				is_inflated,
				// Token: 0x0400018D RID: 397
				BIT_wrapper_type = 2,
				// Token: 0x0400018E RID: 398
				wrapper_type = 4,
				// Token: 0x0400018F RID: 399
				BIT_is_marshaled_from_native = 3,
				// Token: 0x04000190 RID: 400
				is_marshaled_from_native = 8
			}
		}

		// Token: 0x0200006B RID: 107
		internal class NativeStructWrapper : INativeMethodInfoStruct, INativeStruct
		{
			// Token: 0x06000422 RID: 1058 RVA: 0x0001A2E8 File Offset: 0x000184E8
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeMethodInfoStructHandler_24_0.NativeStructWrapper.qmYYqpWbViPAVFEBEfy();
				NativeMethodInfoStructHandler_24_0.NativeStructWrapper.Wl29AaWf4scI5WKlT48();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_16defe672aac4a3485dcd78387beb521 != 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6104a350572547c0a789887568cca07c != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x06000423 RID: 1059 RVA: 0x0001A378 File Offset: 0x00018578
			private unsafe NativeMethodInfoStructHandler_24_0.Il2CppMethodInfo_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x06000424 RID: 1060 RVA: 0x0001A388 File Offset: 0x00018588
			public IntPtr Pointer { get; }

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x06000425 RID: 1061 RVA: 0x0001A398 File Offset: 0x00018598
			public unsafe Il2CppMethodInfo* MethodInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x06000426 RID: 1062 RVA: 0x0001A3A8 File Offset: 0x000185A8
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x06000427 RID: 1063 RVA: 0x0001A3C0 File Offset: 0x000185C0
			public unsafe ref ushort Slot
			{
				get
				{
					return ref this._->slot;
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x06000428 RID: 1064 RVA: 0x0001A3D4 File Offset: 0x000185D4
			public unsafe ref IntPtr MethodPointer
			{
				get
				{
					return ref *(IntPtr*)(&this._->methodPointer);
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x06000429 RID: 1065 RVA: 0x0001A3EC File Offset: 0x000185EC
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x0600042A RID: 1066 RVA: 0x0001A400 File Offset: 0x00018600
			public unsafe ref IntPtr InvokerMethod
			{
				get
				{
					return ref *(IntPtr*)(&this._->invoker_method);
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x0600042B RID: 1067 RVA: 0x0001A418 File Offset: 0x00018618
			public unsafe ref Il2CppTypeStruct* ReturnType
			{
				get
				{
					return ref this._->return_type;
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x0600042C RID: 1068 RVA: 0x0001A42C File Offset: 0x0001862C
			public unsafe ref Il2CppMethodFlags Flags
			{
				get
				{
					return ref *(Il2CppMethodFlags*)(&this._->flags);
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x0600042D RID: 1069 RVA: 0x0001A444 File Offset: 0x00018644
			public unsafe ref byte ParametersCount
			{
				get
				{
					return ref this._->parameters_count;
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x0600042E RID: 1070 RVA: 0x0001A458 File Offset: 0x00018658
			public unsafe ref Il2CppParameterInfo* Parameters
			{
				get
				{
					return ref this._->parameters;
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x0600042F RID: 1071 RVA: 0x0001A46C File Offset: 0x0001866C
			public unsafe ref uint Token
			{
				get
				{
					return ref this._->token;
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x06000430 RID: 1072 RVA: 0x0001A480 File Offset: 0x00018680
			// (set) Token: 0x06000431 RID: 1073 RVA: 0x0001A498 File Offset: 0x00018698
			public bool IsGeneric
			{
				get
				{
					return NativeMethodInfoStructHandler_24_0.NativeStructWrapper.jRZRp9WPTvgBcVCraTA(this, NativeMethodInfoStructHandler_24_0.NativeStructWrapper._bitfield0offset, 0);
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
							NativeMethodInfoStructHandler_24_0.NativeStructWrapper.kmVLCTWdGqpnWnyObeA(this, NativeMethodInfoStructHandler_24_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_48b9993e573d4d08a64ac27c515a32b9 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x06000432 RID: 1074 RVA: 0x0001A4FC File Offset: 0x000186FC
			// (set) Token: 0x06000433 RID: 1075 RVA: 0x0001A514 File Offset: 0x00018714
			public bool IsInflated
			{
				get
				{
					return NativeMethodInfoStructHandler_24_0.NativeStructWrapper.jRZRp9WPTvgBcVCraTA(this, NativeMethodInfoStructHandler_24_0.NativeStructWrapper._bitfield0offset, 1);
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
							this.SetBit(NativeMethodInfoStructHandler_24_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_db312e48eee84539b805fee2f73a8cde != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x06000434 RID: 1076 RVA: 0x0001A578 File Offset: 0x00018778
			// (set) Token: 0x06000435 RID: 1077 RVA: 0x0001A590 File Offset: 0x00018790
			public bool IsMarshalledFromNative
			{
				get
				{
					return this.CheckBit(NativeMethodInfoStructHandler_24_0.NativeStructWrapper._bitfield0offset, 3);
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
							NativeMethodInfoStructHandler_24_0.NativeStructWrapper.kmVLCTWdGqpnWnyObeA(this, NativeMethodInfoStructHandler_24_0.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9f56599a6a304695b6cfc284bd7d7c9a == 0)
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

			// Token: 0x06000436 RID: 1078 RVA: 0x0001A5F4 File Offset: 0x000187F4
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
						NativeMethodInfoStructHandler_24_0.NativeStructWrapper.NLJbAYWwWWhYOnXeaFX();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_570d4e075bf443fcbaca8db32e007291 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
					{
						IntPtr intPtr;
						NativeMethodInfoStructHandler_24_0.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 3;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b15bb2810b414d8fba6ffddaf7154f62 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					case 3:
						return;
					case 4:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeMethodInfoStructHandler_24_0.Il2CppMethodInfo_24_0>(NativeMethodInfoStructHandler_24_0.NativeStructWrapper.V9aN9kWeKFcAsFP3Mds(-1912890712 ^ -993532503 ^ 1170153606 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c504ab11ece64b14b01df2d4c88e6e49));
						num2 = 2;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ba3f6bd5a09c47868765e25f534dbf2a == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					case 5:
						NativeMethodInfoStructHandler_24_0.NativeStructWrapper.Wl29AaWf4scI5WKlT48();
						num2 = 4;
						continue;
					}
					NativeMethodInfoStructHandler_24_0.NativeStructWrapper.qmYYqpWbViPAVFEBEfy();
					num2 = 5;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f7e83c7c87bd4de9b4cb2b7f339254ad != 0)
					{
						num2 = 5;
					}
				}
			}

			// Token: 0x06000437 RID: 1079 RVA: 0x0001A70C File Offset: 0x0001890C
			internal static void qmYYqpWbViPAVFEBEfy()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000438 RID: 1080 RVA: 0x0001A71C File Offset: 0x0001891C
			internal static void Wl29AaWf4scI5WKlT48()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000439 RID: 1081 RVA: 0x0001A72C File Offset: 0x0001892C
			internal static bool mdXEAOWZLpYG29qxCK9()
			{
				return NativeMethodInfoStructHandler_24_0.NativeStructWrapper.syuc6FWDqCsFRYJEIdn == null;
			}

			// Token: 0x0600043A RID: 1082 RVA: 0x0001A740 File Offset: 0x00018940
			internal static NativeMethodInfoStructHandler_24_0.NativeStructWrapper GBy84eWosgk8bKcYNVW()
			{
				return NativeMethodInfoStructHandler_24_0.NativeStructWrapper.syuc6FWDqCsFRYJEIdn;
			}

			// Token: 0x0600043B RID: 1083 RVA: 0x0001A750 File Offset: 0x00018950
			internal static bool jRZRp9WPTvgBcVCraTA(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x0600043C RID: 1084 RVA: 0x0001A76C File Offset: 0x0001896C
			internal static void kmVLCTWdGqpnWnyObeA(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x0001A78C File Offset: 0x0001898C
			internal static void NLJbAYWwWWhYOnXeaFX()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0600043E RID: 1086 RVA: 0x0001A79C File Offset: 0x0001899C
			internal static object V9aN9kWeKFcAsFP3Mds(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000191 RID: 401
			private static readonly int _bitfield0offset;

			// Token: 0x04000193 RID: 403
			internal static object syuc6FWDqCsFRYJEIdn;
		}
	}
}
