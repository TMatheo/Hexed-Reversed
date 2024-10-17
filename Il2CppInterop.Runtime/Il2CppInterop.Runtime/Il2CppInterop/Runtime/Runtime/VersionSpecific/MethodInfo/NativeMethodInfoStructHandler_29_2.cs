using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x02000078 RID: 120
	[ApplicableToUnityVersionsSince("2023.2.0")]
	public class NativeMethodInfoStructHandler_29_2 : INativeMethodInfoStructHandler, INativeStructHandler
	{
		// Token: 0x060004B1 RID: 1201 RVA: 0x0000F1DC File Offset: 0x0000D3DC
		public int Size()
		{
			return sizeof(NativeMethodInfoStructHandler_29_2.Il2CppMethodInfo_29_2);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0000F1EC File Offset: 0x0000D3EC
		public unsafe INativeMethodInfoStruct CreateNewStruct()
		{
			NativeMethodInfoStructHandler_29_2.Il2CppMethodInfo_29_2* ptr2;
			IntPtr ptr = ptr2 = GoyCIOIP2bFaHyGepWM.i2IAUFsOOC(this.Size(), GoyCIOIP2bFaHyGepWM.WJ4IdLh7Zg);
			*ptr2 = default(NativeMethodInfoStructHandler_29_2.Il2CppMethodInfo_29_2);
			return new NativeMethodInfoStructHandler_29_2.NativeStructWrapper(ptr);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0000F220 File Offset: 0x0000D420
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bacedfb8a3cf4671ae3e03ec2f965495 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeMethodInfoStructHandler_29_2.NativeStructWrapper(ptr);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0000F288 File Offset: 0x0000D488
		public NativeMethodInfoStructHandler_29_2()
		{
			NativeMethodInfoStructHandler_29_2.a7nr1LuC5UMQ1h1L8B9();
			NativeMethodInfoStructHandler_29_2.VYbHr4utMWYO74Vuq1x();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c2ad52141772446383547acade021f9a == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0000F2EC File Offset: 0x0000D4EC
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethodInfoStructHandler_29_2()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0000F2FC File Offset: 0x0000D4FC
		internal static bool EvdCPeuYRy6WW03OTQR()
		{
			return NativeMethodInfoStructHandler_29_2.moRvO4uG2wc1T7d8NFv == null;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0000F310 File Offset: 0x0000D510
		internal static NativeMethodInfoStructHandler_29_2 Yg2v7kuaADm2b4nNBVC()
		{
			return NativeMethodInfoStructHandler_29_2.moRvO4uG2wc1T7d8NFv;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0000F320 File Offset: 0x0000D520
		internal static void a7nr1LuC5UMQ1h1L8B9()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0000F330 File Offset: 0x0000D530
		internal static void VYbHr4utMWYO74Vuq1x()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x040001E9 RID: 489
		internal static NativeMethodInfoStructHandler_29_2 moRvO4uG2wc1T7d8NFv;

		// Token: 0x02000079 RID: 121
		internal struct Il2CppMethodInfo_29_2
		{
			// Token: 0x040001EA RID: 490
			public unsafe void* methodPointer;

			// Token: 0x040001EB RID: 491
			public unsafe void* virtualMethodPointer;

			// Token: 0x040001EC RID: 492
			public unsafe void* invoker_method;

			// Token: 0x040001ED RID: 493
			public unsafe byte* name;

			// Token: 0x040001EE RID: 494
			public unsafe Il2CppClass* klass;

			// Token: 0x040001EF RID: 495
			public unsafe Il2CppTypeStruct* return_type;

			// Token: 0x040001F0 RID: 496
			public unsafe Il2CppTypeStruct** parameters;

			// Token: 0x040001F1 RID: 497
			public unsafe void* runtime_data;

			// Token: 0x040001F2 RID: 498
			public unsafe void* generic_data;

			// Token: 0x040001F3 RID: 499
			public uint token;

			// Token: 0x040001F4 RID: 500
			public ushort flags;

			// Token: 0x040001F5 RID: 501
			public ushort iflags;

			// Token: 0x040001F6 RID: 502
			public ushort slot;

			// Token: 0x040001F7 RID: 503
			public byte parameters_count;

			// Token: 0x040001F8 RID: 504
			public NativeMethodInfoStructHandler_29_2.Il2CppMethodInfo_29_2.Bitfield0 _bitfield0;

			// Token: 0x0200007A RID: 122
			internal enum Bitfield0 : byte
			{
				// Token: 0x040001FA RID: 506
				BIT_is_generic,
				// Token: 0x040001FB RID: 507
				is_generic,
				// Token: 0x040001FC RID: 508
				BIT_is_inflated = 1,
				// Token: 0x040001FD RID: 509
				is_inflated,
				// Token: 0x040001FE RID: 510
				BIT_wrapper_type = 2,
				// Token: 0x040001FF RID: 511
				wrapper_type = 4,
				// Token: 0x04000200 RID: 512
				BIT_has_full_generic_sharing_signature = 3,
				// Token: 0x04000201 RID: 513
				has_full_generic_sharing_signature = 8,
				// Token: 0x04000202 RID: 514
				BIT_is_unmanaged_callers_only = 4,
				// Token: 0x04000203 RID: 515
				is_unmanaged_callers_only = 16
			}
		}

		// Token: 0x0200007B RID: 123
		internal class NativeStructWrapper : INativeMethodInfoStruct, INativeStruct
		{
			// Token: 0x060004BA RID: 1210 RVA: 0x0001B4B4 File Offset: 0x000196B4
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeMethodInfoStructHandler_29_2.NativeStructWrapper.OAT6Lrr895M2jt3wSa2();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c4640bbaac7c4988b56f91d1b6b3f1a9 == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c != 0)
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
			// (get) Token: 0x060004BB RID: 1211 RVA: 0x0001B544 File Offset: 0x00019744
			public IntPtr Pointer { get; }

			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x060004BC RID: 1212 RVA: 0x0001B554 File Offset: 0x00019754
			private unsafe NativeMethodInfoStructHandler_29_2.Il2CppMethodInfo_29_2* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x060004BD RID: 1213 RVA: 0x0001B564 File Offset: 0x00019764
			public unsafe Il2CppMethodInfo* MethodInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x060004BE RID: 1214 RVA: 0x0001B574 File Offset: 0x00019774
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x060004BF RID: 1215 RVA: 0x0001B58C File Offset: 0x0001978C
			public unsafe ref ushort Slot
			{
				get
				{
					return ref this._->slot;
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x060004C0 RID: 1216 RVA: 0x0001B5A0 File Offset: 0x000197A0
			public unsafe ref IntPtr MethodPointer
			{
				get
				{
					return ref *(IntPtr*)(&this._->methodPointer);
				}
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x060004C1 RID: 1217 RVA: 0x0001B5B8 File Offset: 0x000197B8
			public unsafe ref IntPtr VirtualMethodPointer
			{
				get
				{
					return ref *(IntPtr*)(&this._->virtualMethodPointer);
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x060004C2 RID: 1218 RVA: 0x0001B5D0 File Offset: 0x000197D0
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x170000D9 RID: 217
			// (get) Token: 0x060004C3 RID: 1219 RVA: 0x0001B5E4 File Offset: 0x000197E4
			public unsafe ref IntPtr InvokerMethod
			{
				get
				{
					return ref *(IntPtr*)(&this._->invoker_method);
				}
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0001B5FC File Offset: 0x000197FC
			public unsafe ref Il2CppTypeStruct* ReturnType
			{
				get
				{
					return ref this._->return_type;
				}
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0001B610 File Offset: 0x00019810
			public unsafe ref Il2CppMethodFlags Flags
			{
				get
				{
					return ref *(Il2CppMethodFlags*)(&this._->flags);
				}
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0001B628 File Offset: 0x00019828
			public unsafe ref byte ParametersCount
			{
				get
				{
					return ref this._->parameters_count;
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0001B63C File Offset: 0x0001983C
			public unsafe ref Il2CppParameterInfo* Parameters
			{
				get
				{
					return ref *(Il2CppParameterInfo**)(&this._->parameters);
				}
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0001B654 File Offset: 0x00019854
			public unsafe ref uint Token
			{
				get
				{
					return ref this._->token;
				}
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x060004C9 RID: 1225 RVA: 0x0001B668 File Offset: 0x00019868
			// (set) Token: 0x060004CA RID: 1226 RVA: 0x0001B680 File Offset: 0x00019880
			public bool IsGeneric
			{
				get
				{
					return NativeMethodInfoStructHandler_29_2.NativeStructWrapper.WZLQu9r0Aw8Gc8FX52t(this, NativeMethodInfoStructHandler_29_2.NativeStructWrapper._bitfield0offset, 0);
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
							this.SetBit(NativeMethodInfoStructHandler_29_2.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5636e8ee665e464ba930601506bed387 != 0)
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

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x060004CB RID: 1227 RVA: 0x0001B6E4 File Offset: 0x000198E4
			// (set) Token: 0x060004CC RID: 1228 RVA: 0x0001B6FC File Offset: 0x000198FC
			public bool IsInflated
			{
				get
				{
					return NativeMethodInfoStructHandler_29_2.NativeStructWrapper.WZLQu9r0Aw8Gc8FX52t(this, NativeMethodInfoStructHandler_29_2.NativeStructWrapper._bitfield0offset, 1);
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
							this.SetBit(NativeMethodInfoStructHandler_29_2.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c2ad52141772446383547acade021f9a == 0)
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

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x060004CD RID: 1229 RVA: 0x0001B760 File Offset: 0x00019960
			// (set) Token: 0x060004CE RID: 1230 RVA: 0x0001B76C File Offset: 0x0001996C
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

			// Token: 0x060004CF RID: 1231 RVA: 0x0001B778 File Offset: 0x00019978
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
						NativeMethodInfoStructHandler_29_2.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 2;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f7e83c7c87bd4de9b4cb2b7f339254ad == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						NativeMethodInfoStructHandler_29_2.NativeStructWrapper.C2e4n5ruWIxsVfdsNSS();
						num2 = 5;
						continue;
					case 4:
						NativeMethodInfoStructHandler_29_2.NativeStructWrapper.FMqvXhrN7sxW1s4YVyF();
						num2 = 3;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6b13daaa4cb24d0bac4f6e72da052370 != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 5:
						NativeMethodInfoStructHandler_29_2.NativeStructWrapper.OAT6Lrr895M2jt3wSa2();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_99cea5f9c4c245c2a5f184ab2e57fafc == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					intPtr = Marshal.OffsetOf<NativeMethodInfoStructHandler_29_2.Il2CppMethodInfo_29_2>(NativeMethodInfoStructHandler_29_2.NativeStructWrapper.it68DErEKEqpDw3Y4Qp(~-937283608 ^ 1744750929 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_be54e2986e644667aed0d52d0affe157));
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b8a2996bc299402b995470e3e8286d42 == 0)
					{
						num2 = 1;
					}
				}
			}

			// Token: 0x060004D0 RID: 1232 RVA: 0x0001B88C File Offset: 0x00019A8C
			internal static void OAT6Lrr895M2jt3wSa2()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x060004D1 RID: 1233 RVA: 0x0001B89C File Offset: 0x00019A9C
			internal static bool RRt10SrxvwsOHgcdboW()
			{
				return NativeMethodInfoStructHandler_29_2.NativeStructWrapper.XYJfDZrtBWDZ2DqweN6 == null;
			}

			// Token: 0x060004D2 RID: 1234 RVA: 0x0001B8B0 File Offset: 0x00019AB0
			internal static NativeMethodInfoStructHandler_29_2.NativeStructWrapper cv2RAVrhVh7cjwDexmy()
			{
				return NativeMethodInfoStructHandler_29_2.NativeStructWrapper.XYJfDZrtBWDZ2DqweN6;
			}

			// Token: 0x060004D3 RID: 1235 RVA: 0x0001B8C0 File Offset: 0x00019AC0
			internal static bool WZLQu9r0Aw8Gc8FX52t(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060004D4 RID: 1236 RVA: 0x0001B8DC File Offset: 0x00019ADC
			internal static void FMqvXhrN7sxW1s4YVyF()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x060004D5 RID: 1237 RVA: 0x0001B8EC File Offset: 0x00019AEC
			internal static void C2e4n5ruWIxsVfdsNSS()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060004D6 RID: 1238 RVA: 0x0001B8FC File Offset: 0x00019AFC
			internal static object it68DErEKEqpDw3Y4Qp(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000204 RID: 516
			private static int _bitfield0offset;

			// Token: 0x04000206 RID: 518
			internal static object XYJfDZrtBWDZ2DqweN6;
		}
	}
}
