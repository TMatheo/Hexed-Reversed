using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Exception
{
	// Token: 0x020000AB RID: 171
	[ApplicableToUnityVersionsSince("2021.2.0")]
	public class NativeExceptionStructHandler_29_0 : INativeExceptionStructHandler, INativeStructHandler
	{
		// Token: 0x06000638 RID: 1592 RVA: 0x0000FD10 File Offset: 0x0000DF10
		public int Size()
		{
			return sizeof(NativeExceptionStructHandler_29_0.Il2CppException_29_0);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0000FD20 File Offset: 0x0000DF20
		public unsafe INativeExceptionStruct CreateNewStruct()
		{
			NativeExceptionStructHandler_29_0.Il2CppException_29_0* ptr2;
			IntPtr ptr = ptr2 = NativeExceptionStructHandler_29_0.rKfdgsbF3UVSYUYLo3x(this.Size());
			*ptr2 = default(NativeExceptionStructHandler_29_0.Il2CppException_29_0);
			return new NativeExceptionStructHandler_29_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0000FD50 File Offset: 0x0000DF50
		public unsafe INativeExceptionStruct Wrap(Il2CppException* ptr)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ff3063f9530e4a429cd27a548ab9d19d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeExceptionStructHandler_29_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0000FDB8 File Offset: 0x0000DFB8
		public NativeExceptionStructHandler_29_0()
		{
			NativeExceptionStructHandler_29_0.Eh3DEhbRSFqU09rUyfQ();
			NativeExceptionStructHandler_29_0.benyibbMP45IU9FsW2w();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_68cafcd7c4d444e39c183fde29795ee9 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0000FE1C File Offset: 0x0000E01C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeExceptionStructHandler_29_0()
		{
			NativeExceptionStructHandler_29_0.bbXomabWXNjA16Foo98();
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0000FE2C File Offset: 0x0000E02C
		internal static IntPtr rKfdgsbF3UVSYUYLo3x(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0000FE40 File Offset: 0x0000E040
		internal static bool RWN6NIbfj2CEDEbUXaf()
		{
			return NativeExceptionStructHandler_29_0.RsxOmCb37NRbRQrpeum == null;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0000FE54 File Offset: 0x0000E054
		internal static NativeExceptionStructHandler_29_0 CkwEbBb1IELmSLbp2yl()
		{
			return NativeExceptionStructHandler_29_0.RsxOmCb37NRbRQrpeum;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0000FE64 File Offset: 0x0000E064
		internal static void Eh3DEhbRSFqU09rUyfQ()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0000FE74 File Offset: 0x0000E074
		internal static void benyibbMP45IU9FsW2w()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0000FE84 File Offset: 0x0000E084
		internal static void bbXomabWXNjA16Foo98()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040002C2 RID: 706
		internal static NativeExceptionStructHandler_29_0 RsxOmCb37NRbRQrpeum;

		// Token: 0x020000AC RID: 172
		internal struct Il2CppException_29_0
		{
			// Token: 0x040002C3 RID: 707
			public Il2CppObject _object;

			// Token: 0x040002C4 RID: 708
			public unsafe Il2CppString* className;

			// Token: 0x040002C5 RID: 709
			public unsafe Il2CppString* message;

			// Token: 0x040002C6 RID: 710
			public unsafe Il2CppObject* _data;

			// Token: 0x040002C7 RID: 711
			public unsafe Il2CppException* inner_ex;

			// Token: 0x040002C8 RID: 712
			public unsafe Il2CppString* _helpURL;

			// Token: 0x040002C9 RID: 713
			public unsafe void* trace_ips;

			// Token: 0x040002CA RID: 714
			public unsafe Il2CppString* stack_trace;

			// Token: 0x040002CB RID: 715
			public unsafe Il2CppString* remote_stack_trace;

			// Token: 0x040002CC RID: 716
			public int remote_stack_index;

			// Token: 0x040002CD RID: 717
			public unsafe Il2CppObject* _dynamicMethods;

			// Token: 0x040002CE RID: 718
			public il2cpp_hresult_t hresult;

			// Token: 0x040002CF RID: 719
			public unsafe Il2CppString* source;

			// Token: 0x040002D0 RID: 720
			public unsafe Il2CppObject* safeSerializationManager;

			// Token: 0x040002D1 RID: 721
			public unsafe void* captured_traces;

			// Token: 0x040002D2 RID: 722
			public unsafe void* native_trace_ips;

			// Token: 0x040002D3 RID: 723
			public int caught_in_unmanaged;
		}

		// Token: 0x020000AD RID: 173
		internal class NativeStructWrapper : INativeExceptionStruct, INativeStruct
		{
			// Token: 0x06000643 RID: 1603 RVA: 0x0001C2D0 File Offset: 0x0001A4D0
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeExceptionStructHandler_29_0.NativeStructWrapper.FgBUfSuZPWEYX7gK22e();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_40fe2648722c4d04bef43cdd927d6154 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3f609fad0bcc47d79d3add6a492d3616 == 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x06000644 RID: 1604 RVA: 0x0001C360 File Offset: 0x0001A560
			private unsafe NativeExceptionStructHandler_29_0.Il2CppException_29_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x06000645 RID: 1605 RVA: 0x0001C370 File Offset: 0x0001A570
			public IntPtr Pointer { get; }

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x06000646 RID: 1606 RVA: 0x0001C380 File Offset: 0x0001A580
			public unsafe Il2CppException* ExceptionPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000169 RID: 361
			// (get) Token: 0x06000647 RID: 1607 RVA: 0x0001C390 File Offset: 0x0001A590
			public unsafe ref Il2CppException* InnerException
			{
				get
				{
					return ref this._->inner_ex;
				}
			}

			// Token: 0x1700016A RID: 362
			// (get) Token: 0x06000648 RID: 1608 RVA: 0x0001C3A4 File Offset: 0x0001A5A4
			public unsafe ref Il2CppString* Message
			{
				get
				{
					return ref this._->message;
				}
			}

			// Token: 0x1700016B RID: 363
			// (get) Token: 0x06000649 RID: 1609 RVA: 0x0001C3B8 File Offset: 0x0001A5B8
			public unsafe ref Il2CppString* HelpLink
			{
				get
				{
					return ref this._->_helpURL;
				}
			}

			// Token: 0x1700016C RID: 364
			// (get) Token: 0x0600064A RID: 1610 RVA: 0x0001C3CC File Offset: 0x0001A5CC
			public unsafe ref Il2CppString* ClassName
			{
				get
				{
					return ref this._->className;
				}
			}

			// Token: 0x1700016D RID: 365
			// (get) Token: 0x0600064B RID: 1611 RVA: 0x0001C3E0 File Offset: 0x0001A5E0
			public unsafe ref Il2CppString* StackTrace
			{
				get
				{
					return ref this._->stack_trace;
				}
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x0600064C RID: 1612 RVA: 0x0001C3F4 File Offset: 0x0001A5F4
			public unsafe ref Il2CppString* RemoteStackTrace
			{
				get
				{
					return ref this._->remote_stack_trace;
				}
			}

			// Token: 0x0600064D RID: 1613 RVA: 0x0001C408 File Offset: 0x0001A608
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeExceptionStructHandler_29_0.NativeStructWrapper.al6UDBuzrOOQnUfWvUZ();
			}

			// Token: 0x0600064E RID: 1614 RVA: 0x0001C418 File Offset: 0x0001A618
			internal static void FgBUfSuZPWEYX7gK22e()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x0600064F RID: 1615 RVA: 0x0001C428 File Offset: 0x0001A628
			internal static bool sUevLVuK9WDVTpkGscj()
			{
				return NativeExceptionStructHandler_29_0.NativeStructWrapper.Y4wjy9ueLuQkI3xEHhf == null;
			}

			// Token: 0x06000650 RID: 1616 RVA: 0x0001C43C File Offset: 0x0001A63C
			internal static NativeExceptionStructHandler_29_0.NativeStructWrapper oqtI8juavPqPmxoQVPJ()
			{
				return NativeExceptionStructHandler_29_0.NativeStructWrapper.Y4wjy9ueLuQkI3xEHhf;
			}

			// Token: 0x06000651 RID: 1617 RVA: 0x0001C44C File Offset: 0x0001A64C
			internal static void al6UDBuzrOOQnUfWvUZ()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x040002D5 RID: 725
			internal static object Y4wjy9ueLuQkI3xEHhf;
		}
	}
}
