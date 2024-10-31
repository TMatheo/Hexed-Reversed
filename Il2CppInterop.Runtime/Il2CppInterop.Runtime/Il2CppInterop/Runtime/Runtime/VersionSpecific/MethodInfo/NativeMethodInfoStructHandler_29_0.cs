using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x0200006E RID: 110
	[ApplicableToUnityVersionsSince("2021.2.0")]
	public class NativeMethodInfoStructHandler_29_0 : INativeMethodInfoStructHandler, INativeStructHandler
	{
		// Token: 0x06000446 RID: 1094 RVA: 0x0000E318 File Offset: 0x0000C518
		public int Size()
		{
			return sizeof(NativeMethodInfoStructHandler_29_0.Il2CppMethodInfo_29_0);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000E328 File Offset: 0x0000C528
		public unsafe INativeMethodInfoStruct CreateNewStruct()
		{
			NativeMethodInfoStructHandler_29_0.Il2CppMethodInfo_29_0* ptr2;
			IntPtr ptr = ptr2 = NativeMethodInfoStructHandler_29_0.BFWgy28iqRVO4foN2te(this.Size());
			*ptr2 = default(NativeMethodInfoStructHandler_29_0.Il2CppMethodInfo_29_0);
			return new NativeMethodInfoStructHandler_29_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000E358 File Offset: 0x0000C558
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_64a8b41e58e0491ab0e9d05ec5ed61d3 != 0)
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

		// Token: 0x06000449 RID: 1097 RVA: 0x0000E3C0 File Offset: 0x0000C5C0
		public NativeMethodInfoStructHandler_29_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeMethodInfoStructHandler_29_0.TaVOM78wnqrUvyV7XJi();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bc2bbd892f074260abf5aaa8b1124d64 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000E424 File Offset: 0x0000C624
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethodInfoStructHandler_29_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000E434 File Offset: 0x0000C634
		internal static IntPtr BFWgy28iqRVO4foN2te(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000E448 File Offset: 0x0000C648
		internal static bool HKQwYt8IDtAZtBG8qxc()
		{
			return NativeMethodInfoStructHandler_29_0.t6OnyF89WsE6mr2hPHm == null;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000E45C File Offset: 0x0000C65C
		internal static NativeMethodInfoStructHandler_29_0 kfq6Dm8drWYEPUcl3MG()
		{
			return NativeMethodInfoStructHandler_29_0.t6OnyF89WsE6mr2hPHm;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000E46C File Offset: 0x0000C66C
		internal static void TaVOM78wnqrUvyV7XJi()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x040001A4 RID: 420
		private static NativeMethodInfoStructHandler_29_0 t6OnyF89WsE6mr2hPHm;

		// Token: 0x0200006F RID: 111
		internal struct Il2CppMethodInfo_29_0
		{
			// Token: 0x040001A5 RID: 421
			public unsafe void* methodPointer;

			// Token: 0x040001A6 RID: 422
			public unsafe void* virtualMethodPointer;

			// Token: 0x040001A7 RID: 423
			public unsafe void* invoker_method;

			// Token: 0x040001A8 RID: 424
			public unsafe byte* name;

			// Token: 0x040001A9 RID: 425
			public unsafe Il2CppClass* klass;

			// Token: 0x040001AA RID: 426
			public unsafe Il2CppTypeStruct* return_type;

			// Token: 0x040001AB RID: 427
			public unsafe Il2CppTypeStruct** parameters;

			// Token: 0x040001AC RID: 428
			public unsafe void* runtime_data;

			// Token: 0x040001AD RID: 429
			public unsafe void* generic_data;

			// Token: 0x040001AE RID: 430
			public uint token;

			// Token: 0x040001AF RID: 431
			public ushort flags;

			// Token: 0x040001B0 RID: 432
			public ushort iflags;

			// Token: 0x040001B1 RID: 433
			public ushort slot;

			// Token: 0x040001B2 RID: 434
			public byte parameters_count;

			// Token: 0x040001B3 RID: 435
			public NativeMethodInfoStructHandler_29_0.Il2CppMethodInfo_29_0.Bitfield0 _bitfield0;

			// Token: 0x02000070 RID: 112
			internal enum Bitfield0 : byte
			{
				// Token: 0x040001B5 RID: 437
				BIT_is_generic,
				// Token: 0x040001B6 RID: 438
				is_generic,
				// Token: 0x040001B7 RID: 439
				BIT_is_inflated = 1,
				// Token: 0x040001B8 RID: 440
				is_inflated,
				// Token: 0x040001B9 RID: 441
				BIT_wrapper_type = 2,
				// Token: 0x040001BA RID: 442
				wrapper_type = 4,
				// Token: 0x040001BB RID: 443
				BIT_has_full_generic_sharing_signature = 3,
				// Token: 0x040001BC RID: 444
				has_full_generic_sharing_signature = 8,
				// Token: 0x040001BD RID: 445
				BIT_indirect_call_via_invokers = 4,
				// Token: 0x040001BE RID: 446
				indirect_call_via_invokers = 16
			}
		}

		// Token: 0x02000071 RID: 113
		internal class NativeStructWrapper : INativeMethodInfoStruct, INativeStruct
		{
			// Token: 0x0600044F RID: 1103 RVA: 0x00019F78 File Offset: 0x00018178
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c975b252adfc48c4b262398638f90354 == 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						return;
					}
					this.<Pointer>k__BackingField = ptr;
					num = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cfadd7e02c524ea298356b7415bd67b6 == 0)
					{
						num = 1;
					}
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x06000450 RID: 1104 RVA: 0x0001A008 File Offset: 0x00018208
			private unsafe NativeMethodInfoStructHandler_29_0.Il2CppMethodInfo_29_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x06000451 RID: 1105 RVA: 0x0001A018 File Offset: 0x00018218
			public IntPtr Pointer { get; }

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000452 RID: 1106 RVA: 0x0001A028 File Offset: 0x00018228
			public unsafe Il2CppMethodInfo* MethodInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x06000453 RID: 1107 RVA: 0x0001A038 File Offset: 0x00018238
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x06000454 RID: 1108 RVA: 0x0001A050 File Offset: 0x00018250
			public unsafe ref ushort Slot
			{
				get
				{
					return ref this._->slot;
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x06000455 RID: 1109 RVA: 0x0001A064 File Offset: 0x00018264
			public unsafe ref IntPtr MethodPointer
			{
				get
				{
					return ref *(IntPtr*)(&this._->methodPointer);
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x06000456 RID: 1110 RVA: 0x0001A07C File Offset: 0x0001827C
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x06000457 RID: 1111 RVA: 0x0001A090 File Offset: 0x00018290
			public unsafe ref IntPtr InvokerMethod
			{
				get
				{
					return ref *(IntPtr*)(&this._->invoker_method);
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x06000458 RID: 1112 RVA: 0x0001A0A8 File Offset: 0x000182A8
			public unsafe ref Il2CppTypeStruct* ReturnType
			{
				get
				{
					return ref this._->return_type;
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x06000459 RID: 1113 RVA: 0x0001A0BC File Offset: 0x000182BC
			public unsafe ref Il2CppMethodFlags Flags
			{
				get
				{
					return ref *(Il2CppMethodFlags*)(&this._->flags);
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x0600045A RID: 1114 RVA: 0x0001A0D4 File Offset: 0x000182D4
			public unsafe ref byte ParametersCount
			{
				get
				{
					return ref this._->parameters_count;
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x0600045B RID: 1115 RVA: 0x0001A0E8 File Offset: 0x000182E8
			public unsafe ref Il2CppParameterInfo* Parameters
			{
				get
				{
					return ref *(Il2CppParameterInfo**)(&this._->parameters);
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x0600045C RID: 1116 RVA: 0x0001A100 File Offset: 0x00018300
			public unsafe ref uint Token
			{
				get
				{
					return ref this._->token;
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x0600045D RID: 1117 RVA: 0x0001A114 File Offset: 0x00018314
			// (set) Token: 0x0600045E RID: 1118 RVA: 0x0001A12C File Offset: 0x0001832C
			public bool IsGeneric
			{
				get
				{
					return NativeMethodInfoStructHandler_29_0.NativeStructWrapper.E6lVCKSy7J35DAJpkUY(this, NativeMethodInfoStructHandler_29_0.NativeStructWrapper._bitfield0offset, 0);
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
							NativeMethodInfoStructHandler_29_0.NativeStructWrapper.D4NudjSJXmj4gQBedYe(this, NativeMethodInfoStructHandler_29_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2a3cb7fb82fa47c39f707a2393c1a340 == 0)
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
			// (get) Token: 0x0600045F RID: 1119 RVA: 0x0001A190 File Offset: 0x00018390
			// (set) Token: 0x06000460 RID: 1120 RVA: 0x0001A1A8 File Offset: 0x000183A8
			public bool IsInflated
			{
				get
				{
					return NativeMethodInfoStructHandler_29_0.NativeStructWrapper.E6lVCKSy7J35DAJpkUY(this, NativeMethodInfoStructHandler_29_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeMethodInfoStructHandler_29_0.NativeStructWrapper.D4NudjSJXmj4gQBedYe(this, NativeMethodInfoStructHandler_29_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_457365959f004478ad0e311bf72b3912 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x06000461 RID: 1121 RVA: 0x0001A20C File Offset: 0x0001840C
			// (set) Token: 0x06000462 RID: 1122 RVA: 0x0001A218 File Offset: 0x00018418
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

			// Token: 0x06000463 RID: 1123 RVA: 0x0001A224 File Offset: 0x00018424
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 4;
				for (;;)
				{
					int num2 = num;
					IntPtr intPtr;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							intPtr = Marshal.OffsetOf<NativeMethodInfoStructHandler_29_0.Il2CppMethodInfo_29_0>(NativeMethodInfoStructHandler_29_0.NativeStructWrapper.DPTh6ySsorkH2gXlwPH(2056095481 >> 1 ^ 1863770397 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_11d7514559f14fcba52669ac71e3cb39));
							num2 = 5;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b544c260d8647ebad150746ba137290 == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						case 2:
							return;
						case 3:
							NativeMethodInfoStructHandler_29_0.NativeStructWrapper.aeqOaHSV0detg1ymYy9();
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_22f9ae9a49f143d7bbb3b03eb2446c0f == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							NativeMethodInfoStructHandler_29_0.NativeStructWrapper.FpmWW4SpG1ca97rZlRY();
							num2 = 3;
							continue;
						case 5:
							goto IL_82;
						}
						NativeMethodInfoStructHandler_29_0.NativeStructWrapper.BhkTjtS0pZ6HNHbPu5h();
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_124ad935e0834fda9ae7f452377dbe1c == 0)
						{
							num2 = 0;
						}
					}
					IL_82:
					NativeMethodInfoStructHandler_29_0.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
					num = 2;
				}
			}

			// Token: 0x06000464 RID: 1124 RVA: 0x0001A32C File Offset: 0x0001852C
			internal static bool PHCfybSbIsEvdKwVbQy()
			{
				return NativeMethodInfoStructHandler_29_0.NativeStructWrapper.E12a0ZSnADTRywGmb9X == null;
			}

			// Token: 0x06000465 RID: 1125 RVA: 0x0001A340 File Offset: 0x00018540
			internal static NativeMethodInfoStructHandler_29_0.NativeStructWrapper T0edgHS6C8ZOqx1vFFt()
			{
				return NativeMethodInfoStructHandler_29_0.NativeStructWrapper.E12a0ZSnADTRywGmb9X;
			}

			// Token: 0x06000466 RID: 1126 RVA: 0x0001A350 File Offset: 0x00018550
			internal static bool E6lVCKSy7J35DAJpkUY(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000467 RID: 1127 RVA: 0x0001A36C File Offset: 0x0001856C
			internal static void D4NudjSJXmj4gQBedYe(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000468 RID: 1128 RVA: 0x0001A38C File Offset: 0x0001858C
			internal static void FpmWW4SpG1ca97rZlRY()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000469 RID: 1129 RVA: 0x0001A39C File Offset: 0x0001859C
			internal static void aeqOaHSV0detg1ymYy9()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600046A RID: 1130 RVA: 0x0001A3AC File Offset: 0x000185AC
			internal static void BhkTjtS0pZ6HNHbPu5h()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x0600046B RID: 1131 RVA: 0x0001A3BC File Offset: 0x000185BC
			internal static object DPTh6ySsorkH2gXlwPH(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x040001BF RID: 447
			private static readonly int _bitfield0offset;

			// Token: 0x040001C1 RID: 449
			internal static object E12a0ZSnADTRywGmb9X;
		}
	}
}
