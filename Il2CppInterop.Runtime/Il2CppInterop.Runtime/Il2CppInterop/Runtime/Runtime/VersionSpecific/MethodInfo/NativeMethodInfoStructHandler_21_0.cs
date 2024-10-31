using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x02000062 RID: 98
	[ApplicableToUnityVersionsSince("5.3.6")]
	public class NativeMethodInfoStructHandler_21_0 : INativeMethodInfoStructHandler, INativeStructHandler
	{
		// Token: 0x060003D3 RID: 979 RVA: 0x0000DED0 File Offset: 0x0000C0D0
		public int Size()
		{
			return sizeof(NativeMethodInfoStructHandler_21_0.Il2CppMethodInfo_21_0);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000DEE0 File Offset: 0x0000C0E0
		public unsafe INativeMethodInfoStruct CreateNewStruct()
		{
			NativeMethodInfoStructHandler_21_0.Il2CppMethodInfo_21_0* ptr2;
			IntPtr ptr = ptr2 = NativeMethodInfoStructHandler_21_0.HtU6Bw8uTsWy3jxXh4V(this.Size());
			*ptr2 = default(NativeMethodInfoStructHandler_21_0.Il2CppMethodInfo_21_0);
			return new NativeMethodInfoStructHandler_21_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000DF10 File Offset: 0x0000C110
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4c6a46c0a2d14747aa1dc5bf1581154d != 0)
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
			return new NativeMethodInfoStructHandler_21_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000DF78 File Offset: 0x0000C178
		public NativeMethodInfoStructHandler_21_0()
		{
			NativeMethodInfoStructHandler_21_0.f0e1wu8D3A27U374pcT();
			NativeMethodInfoStructHandler_21_0.BLLsvo8mf7eMfvw2emZ();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2a3cb7fb82fa47c39f707a2393c1a340 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000DFDC File Offset: 0x0000C1DC
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethodInfoStructHandler_21_0()
		{
			NativeMethodInfoStructHandler_21_0.eNaRSZ87uyQU6h7lXsg();
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000DFEC File Offset: 0x0000C1EC
		internal static IntPtr HtU6Bw8uTsWy3jxXh4V(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000E000 File Offset: 0x0000C200
		internal static bool MoE8OD8SG1n8PaBMy9Z()
		{
			return NativeMethodInfoStructHandler_21_0.VWopIr8sHVgmu7MCsKy == null;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000E014 File Offset: 0x0000C214
		internal static NativeMethodInfoStructHandler_21_0 qZeZYJ8NSmkak3yyakH()
		{
			return NativeMethodInfoStructHandler_21_0.VWopIr8sHVgmu7MCsKy;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000E024 File Offset: 0x0000C224
		internal static void f0e1wu8D3A27U374pcT()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000E034 File Offset: 0x0000C234
		internal static void BLLsvo8mf7eMfvw2emZ()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000E044 File Offset: 0x0000C244
		internal static void eNaRSZ87uyQU6h7lXsg()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000155 RID: 341
		internal static NativeMethodInfoStructHandler_21_0 VWopIr8sHVgmu7MCsKy;

		// Token: 0x02000063 RID: 99
		internal struct Il2CppMethodInfo_21_0
		{
			// Token: 0x04000156 RID: 342
			public unsafe void* methodPointer;

			// Token: 0x04000157 RID: 343
			public unsafe void* invoker_method;

			// Token: 0x04000158 RID: 344
			public unsafe byte* name;

			// Token: 0x04000159 RID: 345
			public unsafe Il2CppClass* declaring_type;

			// Token: 0x0400015A RID: 346
			public unsafe Il2CppTypeStruct* return_type;

			// Token: 0x0400015B RID: 347
			public unsafe Il2CppParameterInfo* parameters;

			// Token: 0x0400015C RID: 348
			public unsafe void* runtime_data;

			// Token: 0x0400015D RID: 349
			public unsafe void* generic_data;

			// Token: 0x0400015E RID: 350
			public int customAttributeIndex;

			// Token: 0x0400015F RID: 351
			public uint token;

			// Token: 0x04000160 RID: 352
			public ushort flags;

			// Token: 0x04000161 RID: 353
			public ushort iflags;

			// Token: 0x04000162 RID: 354
			public ushort slot;

			// Token: 0x04000163 RID: 355
			public byte parameters_count;

			// Token: 0x04000164 RID: 356
			public NativeMethodInfoStructHandler_21_0.Il2CppMethodInfo_21_0.Bitfield0 _bitfield0;

			// Token: 0x02000064 RID: 100
			internal enum Bitfield0 : byte
			{
				// Token: 0x04000166 RID: 358
				BIT_is_generic,
				// Token: 0x04000167 RID: 359
				is_generic,
				// Token: 0x04000168 RID: 360
				BIT_is_inflated = 1,
				// Token: 0x04000169 RID: 361
				is_inflated
			}
		}

		// Token: 0x02000065 RID: 101
		internal class NativeStructWrapper : INativeMethodInfoStruct, INativeStruct
		{
			// Token: 0x060003DE RID: 990 RVA: 0x000191D8 File Offset: 0x000173D8
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeMethodInfoStructHandler_21_0.NativeStructWrapper.jOKZGNsE8XxiyTWSAhJ();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_441278fe93ad425f9343d4f7d1692fca != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_45f0db95dace45b6a0257ae80a3038eb == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x060003DF RID: 991 RVA: 0x00019268 File Offset: 0x00017468
			private unsafe NativeMethodInfoStructHandler_21_0.Il2CppMethodInfo_21_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x060003E0 RID: 992 RVA: 0x00019278 File Offset: 0x00017478
			public IntPtr Pointer { get; }

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x060003E1 RID: 993 RVA: 0x00019288 File Offset: 0x00017488
			public unsafe Il2CppMethodInfo* MethodInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x060003E2 RID: 994 RVA: 0x00019298 File Offset: 0x00017498
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x060003E3 RID: 995 RVA: 0x000192B0 File Offset: 0x000174B0
			public unsafe ref ushort Slot
			{
				get
				{
					return ref this._->slot;
				}
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x060003E4 RID: 996 RVA: 0x000192C4 File Offset: 0x000174C4
			public unsafe ref IntPtr MethodPointer
			{
				get
				{
					return ref *(IntPtr*)(&this._->methodPointer);
				}
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x060003E5 RID: 997 RVA: 0x000192DC File Offset: 0x000174DC
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->declaring_type;
				}
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x060003E6 RID: 998 RVA: 0x000192F0 File Offset: 0x000174F0
			public unsafe ref IntPtr InvokerMethod
			{
				get
				{
					return ref *(IntPtr*)(&this._->invoker_method);
				}
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x060003E7 RID: 999 RVA: 0x00019308 File Offset: 0x00017508
			public unsafe ref Il2CppTypeStruct* ReturnType
			{
				get
				{
					return ref this._->return_type;
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0001931C File Offset: 0x0001751C
			public unsafe ref Il2CppMethodFlags Flags
			{
				get
				{
					return ref *(Il2CppMethodFlags*)(&this._->flags);
				}
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00019334 File Offset: 0x00017534
			public unsafe ref byte ParametersCount
			{
				get
				{
					return ref this._->parameters_count;
				}
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x060003EA RID: 1002 RVA: 0x00019348 File Offset: 0x00017548
			public unsafe ref Il2CppParameterInfo* Parameters
			{
				get
				{
					return ref this._->parameters;
				}
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x060003EB RID: 1003 RVA: 0x0001935C File Offset: 0x0001755C
			public unsafe ref uint Token
			{
				get
				{
					return ref this._->token;
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x060003EC RID: 1004 RVA: 0x00019370 File Offset: 0x00017570
			// (set) Token: 0x060003ED RID: 1005 RVA: 0x00019388 File Offset: 0x00017588
			public bool IsGeneric
			{
				get
				{
					return NativeMethodInfoStructHandler_21_0.NativeStructWrapper.Qk6MLWsBDmtcZLBTYoQ(this, NativeMethodInfoStructHandler_21_0.NativeStructWrapper._bitfield0offset, 0);
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
							this.SetBit(NativeMethodInfoStructHandler_21_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_dd9c757bd882429784d62f0e80f112e6 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x060003EE RID: 1006 RVA: 0x000193EC File Offset: 0x000175EC
			// (set) Token: 0x060003EF RID: 1007 RVA: 0x00019404 File Offset: 0x00017604
			public bool IsInflated
			{
				get
				{
					return NativeMethodInfoStructHandler_21_0.NativeStructWrapper.Qk6MLWsBDmtcZLBTYoQ(this, NativeMethodInfoStructHandler_21_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeMethodInfoStructHandler_21_0.NativeStructWrapper.loJyc9sGE2myLLiGy6Z(this, NativeMethodInfoStructHandler_21_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6c17eda4faca4bd29ba4134efb91a5a8 != 0)
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

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00019468 File Offset: 0x00017668
			// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00019474 File Offset: 0x00017674
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

			// Token: 0x060003F2 RID: 1010 RVA: 0x00019480 File Offset: 0x00017680
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						NativeMethodInfoStructHandler_21_0.NativeStructWrapper.jOKZGNsE8XxiyTWSAhJ();
						num2 = 3;
						continue;
					case 2:
						NativeMethodInfoStructHandler_21_0.NativeStructWrapper.dXYtodsr4B9cFc2DZOH();
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6776fc69415b4d309be658e7e8ac3a28 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						NativeMethodInfoStructHandler_21_0.NativeStructWrapper.mgo5PGsTioNe1MfX4WM();
						num2 = 5;
						continue;
					case 4:
					{
						IntPtr intPtr;
						NativeMethodInfoStructHandler_21_0.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_124ad935e0834fda9ae7f452377dbe1c == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					case 5:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeMethodInfoStructHandler_21_0.Il2CppMethodInfo_21_0>(NativeMethodInfoStructHandler_21_0.NativeStructWrapper.EN2yYrsgH4s7YpSqDTh(1919189329 ^ 2029094776 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_420bdc7f003c47439a9f8331e71194a1));
						num2 = 4;
						continue;
					}
					}
					break;
				}
			}

			// Token: 0x060003F3 RID: 1011 RVA: 0x00019568 File Offset: 0x00017768
			internal static void jOKZGNsE8XxiyTWSAhJ()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060003F4 RID: 1012 RVA: 0x00019578 File Offset: 0x00017778
			internal static bool DQOaeasikow3Eeu43Te()
			{
				return NativeMethodInfoStructHandler_21_0.NativeStructWrapper.dra2pSsdsAXoim3cO1a == null;
			}

			// Token: 0x060003F5 RID: 1013 RVA: 0x0001958C File Offset: 0x0001778C
			internal static NativeMethodInfoStructHandler_21_0.NativeStructWrapper ayXEhZswHtjx17tWTgN()
			{
				return NativeMethodInfoStructHandler_21_0.NativeStructWrapper.dra2pSsdsAXoim3cO1a;
			}

			// Token: 0x060003F6 RID: 1014 RVA: 0x0001959C File Offset: 0x0001779C
			internal static bool Qk6MLWsBDmtcZLBTYoQ(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x000195B8 File Offset: 0x000177B8
			internal static void loJyc9sGE2myLLiGy6Z(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x060003F8 RID: 1016 RVA: 0x000195D8 File Offset: 0x000177D8
			internal static void dXYtodsr4B9cFc2DZOH()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x000195E8 File Offset: 0x000177E8
			internal static void mgo5PGsTioNe1MfX4WM()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x060003FA RID: 1018 RVA: 0x000195F8 File Offset: 0x000177F8
			internal static object EN2yYrsgH4s7YpSqDTh(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x0400016A RID: 362
			private static readonly int _bitfield0offset;

			// Token: 0x0400016C RID: 364
			internal static object dra2pSsdsAXoim3cO1a;
		}
	}
}
