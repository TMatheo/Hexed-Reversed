using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Exception
{
	// Token: 0x020000A5 RID: 165
	[ApplicableToUnityVersionsSince("5.3.5")]
	public class NativeExceptionStructHandler_21_0 : INativeExceptionStructHandler, INativeStructHandler
	{
		// Token: 0x06000605 RID: 1541 RVA: 0x0000FA28 File Offset: 0x0000DC28
		public int Size()
		{
			return sizeof(NativeExceptionStructHandler_21_0.Il2CppException_21_0);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0000FA38 File Offset: 0x0000DC38
		public unsafe INativeExceptionStruct CreateNewStruct()
		{
			NativeExceptionStructHandler_21_0.Il2CppException_21_0* ptr2;
			IntPtr ptr = ptr2 = NativeExceptionStructHandler_21_0.LnUDUibsu9s5Vjq24hA(this.Size());
			*ptr2 = default(NativeExceptionStructHandler_21_0.Il2CppException_21_0);
			return new NativeExceptionStructHandler_21_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0000FA68 File Offset: 0x0000DC68
		public unsafe INativeExceptionStruct Wrap(Il2CppException* ptr)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eec4384c7d0d42baa74a4dbdbdbdd8df == 0)
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
			return new NativeExceptionStructHandler_21_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0000FAD0 File Offset: 0x0000DCD0
		public NativeExceptionStructHandler_21_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeExceptionStructHandler_21_0.UE4MlfbSp8S3badsuom();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c975b252adfc48c4b262398638f90354 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0000FB34 File Offset: 0x0000DD34
		// Note: this type is marked as 'beforefieldinit'.
		static NativeExceptionStructHandler_21_0()
		{
			NativeExceptionStructHandler_21_0.qLG1yJbNbq8vggoQMWo();
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0000FB44 File Offset: 0x0000DD44
		internal static IntPtr LnUDUibsu9s5Vjq24hA(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0000FB58 File Offset: 0x0000DD58
		internal static bool CuDgUYbVDVQrK8EiaYV()
		{
			return NativeExceptionStructHandler_21_0.e91eHcbp5Cj024jNdHw == null;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0000FB6C File Offset: 0x0000DD6C
		internal static NativeExceptionStructHandler_21_0 tXcStmb0fVesJCoNXas()
		{
			return NativeExceptionStructHandler_21_0.e91eHcbp5Cj024jNdHw;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0000FB7C File Offset: 0x0000DD7C
		internal static void UE4MlfbSp8S3badsuom()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0000FB8C File Offset: 0x0000DD8C
		internal static void qLG1yJbNbq8vggoQMWo()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040002A0 RID: 672
		private static NativeExceptionStructHandler_21_0 e91eHcbp5Cj024jNdHw;

		// Token: 0x020000A6 RID: 166
		internal struct Il2CppException_21_0
		{
			// Token: 0x040002A1 RID: 673
			public Il2CppObject _object;

			// Token: 0x040002A2 RID: 674
			public unsafe void* trace_ips;

			// Token: 0x040002A3 RID: 675
			public unsafe Il2CppException* inner_ex;

			// Token: 0x040002A4 RID: 676
			public unsafe Il2CppString* message;

			// Token: 0x040002A5 RID: 677
			public unsafe Il2CppString* help_link;

			// Token: 0x040002A6 RID: 678
			public unsafe Il2CppString* class_name;

			// Token: 0x040002A7 RID: 679
			public unsafe Il2CppString* stack_trace;

			// Token: 0x040002A8 RID: 680
			public unsafe Il2CppString* remote_stack_trace;

			// Token: 0x040002A9 RID: 681
			public int remote_stack_index;

			// Token: 0x040002AA RID: 682
			public il2cpp_hresult_t hresult;

			// Token: 0x040002AB RID: 683
			public unsafe Il2CppString* source;

			// Token: 0x040002AC RID: 684
			public unsafe Il2CppObject* _data;
		}

		// Token: 0x020000A7 RID: 167
		internal class NativeStructWrapper : INativeExceptionStruct, INativeStruct
		{
			// Token: 0x0600060F RID: 1551 RVA: 0x0001BFA8 File Offset: 0x0001A1A8
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeExceptionStructHandler_21_0.NativeStructWrapper.mKduKruIIh2FqJQYg2y();
				NativeExceptionStructHandler_21_0.NativeStructWrapper.E2Kkpiudh27nglsromu();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_355d73c700924bf28058452e63cd9cf1 != 0)
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
					num = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c580bbd8275c462fb04ea886a5e08073 == 0)
					{
						num = 0;
					}
				}
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x06000610 RID: 1552 RVA: 0x0001C038 File Offset: 0x0001A238
			private unsafe NativeExceptionStructHandler_21_0.Il2CppException_21_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000155 RID: 341
			// (get) Token: 0x06000611 RID: 1553 RVA: 0x0001C048 File Offset: 0x0001A248
			public IntPtr Pointer { get; }

			// Token: 0x17000156 RID: 342
			// (get) Token: 0x06000612 RID: 1554 RVA: 0x0001C058 File Offset: 0x0001A258
			public unsafe Il2CppException* ExceptionPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x06000613 RID: 1555 RVA: 0x0001C068 File Offset: 0x0001A268
			public unsafe ref Il2CppException* InnerException
			{
				get
				{
					return ref this._->inner_ex;
				}
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x06000614 RID: 1556 RVA: 0x0001C07C File Offset: 0x0001A27C
			public unsafe ref Il2CppString* Message
			{
				get
				{
					return ref this._->message;
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x06000615 RID: 1557 RVA: 0x0001C090 File Offset: 0x0001A290
			public unsafe ref Il2CppString* HelpLink
			{
				get
				{
					return ref this._->help_link;
				}
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x06000616 RID: 1558 RVA: 0x0001C0A4 File Offset: 0x0001A2A4
			public unsafe ref Il2CppString* ClassName
			{
				get
				{
					return ref this._->class_name;
				}
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x06000617 RID: 1559 RVA: 0x0001C0B8 File Offset: 0x0001A2B8
			public unsafe ref Il2CppString* StackTrace
			{
				get
				{
					return ref this._->stack_trace;
				}
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x06000618 RID: 1560 RVA: 0x0001C0CC File Offset: 0x0001A2CC
			public unsafe ref Il2CppString* RemoteStackTrace
			{
				get
				{
					return ref this._->remote_stack_trace;
				}
			}

			// Token: 0x06000619 RID: 1561 RVA: 0x0001C0E0 File Offset: 0x0001A2E0
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0600061A RID: 1562 RVA: 0x0001C0F0 File Offset: 0x0001A2F0
			internal static void mKduKruIIh2FqJQYg2y()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600061B RID: 1563 RVA: 0x0001C100 File Offset: 0x0001A300
			internal static void E2Kkpiudh27nglsromu()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x0600061C RID: 1564 RVA: 0x0001C110 File Offset: 0x0001A310
			internal static bool eB09CbuC24Mopo6M3gY()
			{
				return NativeExceptionStructHandler_21_0.NativeStructWrapper.KDVDQ9uWr6GmLgDtwcI == null;
			}

			// Token: 0x0600061D RID: 1565 RVA: 0x0001C124 File Offset: 0x0001A324
			internal static NativeExceptionStructHandler_21_0.NativeStructWrapper f0CBHSu9HSBCWaXcsPx()
			{
				return NativeExceptionStructHandler_21_0.NativeStructWrapper.KDVDQ9uWr6GmLgDtwcI;
			}

			// Token: 0x040002AE RID: 686
			internal static object KDVDQ9uWr6GmLgDtwcI;
		}
	}
}
