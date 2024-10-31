using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Exception
{
	// Token: 0x020000A2 RID: 162
	[ApplicableToUnityVersionsSince("5.3.3")]
	public class NativeExceptionStructHandler_20_0 : INativeExceptionStructHandler, INativeStructHandler
	{
		// Token: 0x060005EC RID: 1516 RVA: 0x0000F8A4 File Offset: 0x0000DAA4
		public int Size()
		{
			return sizeof(NativeExceptionStructHandler_20_0.Il2CppException_20_0);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0000F8B4 File Offset: 0x0000DAB4
		public unsafe INativeExceptionStruct CreateNewStruct()
		{
			NativeExceptionStructHandler_20_0.Il2CppException_20_0* ptr2;
			IntPtr ptr = ptr2 = NativeExceptionStructHandler_20_0.bqXJSrbbX4RnGsVuHIL(this.Size());
			*ptr2 = default(NativeExceptionStructHandler_20_0.Il2CppException_20_0);
			return new NativeExceptionStructHandler_20_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0000F8E4 File Offset: 0x0000DAE4
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
			return new NativeExceptionStructHandler_20_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0000F94C File Offset: 0x0000DB4C
		public NativeExceptionStructHandler_20_0()
		{
			NativeExceptionStructHandler_20_0.CUo10db6FcwvZ87FDnJ();
			NativeExceptionStructHandler_20_0.JgH9IYbyGA67kgrqp53();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_43cc35cb254148318955c7f83ade60f1 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0000F9B0 File Offset: 0x0000DBB0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeExceptionStructHandler_20_0()
		{
			NativeExceptionStructHandler_20_0.lhPsEZbJpaKM83tfVwo();
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
		internal static IntPtr bqXJSrbbX4RnGsVuHIL(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0000F9D4 File Offset: 0x0000DBD4
		internal static bool ICWWgcb8NbqDEXuH5IC()
		{
			return NativeExceptionStructHandler_20_0.WluE60bYiUgdX6rQXNj == null;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0000F9E8 File Offset: 0x0000DBE8
		internal static NativeExceptionStructHandler_20_0 jyhG5UbnFTmdxhnHFJp()
		{
			return NativeExceptionStructHandler_20_0.WluE60bYiUgdX6rQXNj;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0000F9F8 File Offset: 0x0000DBF8
		internal static void CUo10db6FcwvZ87FDnJ()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0000FA08 File Offset: 0x0000DC08
		internal static void JgH9IYbyGA67kgrqp53()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0000FA18 File Offset: 0x0000DC18
		internal static void lhPsEZbJpaKM83tfVwo()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000291 RID: 657
		internal static NativeExceptionStructHandler_20_0 WluE60bYiUgdX6rQXNj;

		// Token: 0x020000A3 RID: 163
		internal struct Il2CppException_20_0
		{
			// Token: 0x04000292 RID: 658
			public Il2CppObject _object;

			// Token: 0x04000293 RID: 659
			public unsafe void* trace_ips;

			// Token: 0x04000294 RID: 660
			public unsafe Il2CppObject* inner_ex;

			// Token: 0x04000295 RID: 661
			public unsafe Il2CppString* message;

			// Token: 0x04000296 RID: 662
			public unsafe Il2CppString* help_link;

			// Token: 0x04000297 RID: 663
			public unsafe Il2CppString* class_name;

			// Token: 0x04000298 RID: 664
			public unsafe Il2CppString* stack_trace;

			// Token: 0x04000299 RID: 665
			public unsafe Il2CppString* remote_stack_trace;

			// Token: 0x0400029A RID: 666
			public int remote_stack_index;

			// Token: 0x0400029B RID: 667
			public il2cpp_hresult_t hresult;

			// Token: 0x0400029C RID: 668
			public unsafe Il2CppString* source;

			// Token: 0x0400029D RID: 669
			public unsafe Il2CppObject* _data;
		}

		// Token: 0x020000A4 RID: 164
		internal class NativeStructWrapper : INativeExceptionStruct, INativeStruct
		{
			// Token: 0x060005F7 RID: 1527 RVA: 0x0001BE28 File Offset: 0x0001A028
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeExceptionStructHandler_20_0.NativeStructWrapper.SPPA9Uu1loYE0mu3mTB();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8160363759e64728b1ce193157380515 != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_26479210ae524f22ae1fe060a08fdd55 == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0001BEB8 File Offset: 0x0001A0B8
			private unsafe NativeExceptionStructHandler_20_0.Il2CppException_20_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700014C RID: 332
			// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0001BEC8 File Offset: 0x0001A0C8
			public IntPtr Pointer { get; }

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x060005FA RID: 1530 RVA: 0x0001BED8 File Offset: 0x0001A0D8
			public unsafe Il2CppException* ExceptionPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x060005FB RID: 1531 RVA: 0x0001BEE8 File Offset: 0x0001A0E8
			public unsafe ref Il2CppException* InnerException
			{
				get
				{
					return ref *(Il2CppException**)(&this._->inner_ex);
				}
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x060005FC RID: 1532 RVA: 0x0001BF00 File Offset: 0x0001A100
			public unsafe ref Il2CppString* Message
			{
				get
				{
					return ref this._->message;
				}
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x060005FD RID: 1533 RVA: 0x0001BF14 File Offset: 0x0001A114
			public unsafe ref Il2CppString* HelpLink
			{
				get
				{
					return ref this._->help_link;
				}
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x060005FE RID: 1534 RVA: 0x0001BF28 File Offset: 0x0001A128
			public unsafe ref Il2CppString* ClassName
			{
				get
				{
					return ref this._->class_name;
				}
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x060005FF RID: 1535 RVA: 0x0001BF3C File Offset: 0x0001A13C
			public unsafe ref Il2CppString* StackTrace
			{
				get
				{
					return ref this._->stack_trace;
				}
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x06000600 RID: 1536 RVA: 0x0001BF50 File Offset: 0x0001A150
			public unsafe ref Il2CppString* RemoteStackTrace
			{
				get
				{
					return ref this._->remote_stack_trace;
				}
			}

			// Token: 0x06000601 RID: 1537 RVA: 0x0001BF64 File Offset: 0x0001A164
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000602 RID: 1538 RVA: 0x0001BF74 File Offset: 0x0001A174
			internal static void SPPA9Uu1loYE0mu3mTB()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000603 RID: 1539 RVA: 0x0001BF84 File Offset: 0x0001A184
			internal static bool ABMF8Uu33JcR6OuYsXv()
			{
				return NativeExceptionStructHandler_20_0.NativeStructWrapper.b5ZBT8u4ilYp0V2aYdt == null;
			}

			// Token: 0x06000604 RID: 1540 RVA: 0x0001BF98 File Offset: 0x0001A198
			internal static NativeExceptionStructHandler_20_0.NativeStructWrapper Fp957JufOMGdbnIA5Gt()
			{
				return NativeExceptionStructHandler_20_0.NativeStructWrapper.b5ZBT8u4ilYp0V2aYdt;
			}

			// Token: 0x0400029F RID: 671
			internal static object b5ZBT8u4ilYp0V2aYdt;
		}
	}
}
