using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Exception
{
	// Token: 0x020000A8 RID: 168
	[ApplicableToUnityVersionsSince("2019.3.0")]
	public class NativeExceptionStructHandler_24_0 : INativeExceptionStructHandler, INativeStructHandler
	{
		// Token: 0x0600061E RID: 1566 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		public int Size()
		{
			return sizeof(NativeExceptionStructHandler_24_0.Il2CppException_24_0);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0000FBAC File Offset: 0x0000DDAC
		public unsafe INativeExceptionStruct CreateNewStruct()
		{
			NativeExceptionStructHandler_24_0.Il2CppException_24_0* ptr2;
			IntPtr ptr = ptr2 = NativeExceptionStructHandler_24_0.mrJydLb7SAliZhA5hff(this.Size());
			*ptr2 = default(NativeExceptionStructHandler_24_0.Il2CppException_24_0);
			return new NativeExceptionStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0000FBDC File Offset: 0x0000DDDC
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6a95c50bbb48420f8f11bb090d6d3bd5 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeExceptionStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0000FC44 File Offset: 0x0000DE44
		public NativeExceptionStructHandler_24_0()
		{
			NativeExceptionStructHandler_24_0.Qyq58BbPTo5jshen2BP();
			NativeExceptionStructHandler_24_0.a55Gpob4xrNPaZ9MIBW();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ffe1ad8c1cf94bc78c25e67b0264547e == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeExceptionStructHandler_24_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0000FCB8 File Offset: 0x0000DEB8
		internal static IntPtr mrJydLb7SAliZhA5hff(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0000FCCC File Offset: 0x0000DECC
		internal static bool Pu1gTLbDDbxOt7pyP8x()
		{
			return NativeExceptionStructHandler_24_0.NCYkJ4busKI75xjtyBr == null;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0000FCE0 File Offset: 0x0000DEE0
		internal static NativeExceptionStructHandler_24_0 OpRGQWbm37JfouKbSTD()
		{
			return NativeExceptionStructHandler_24_0.NCYkJ4busKI75xjtyBr;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
		internal static void Qyq58BbPTo5jshen2BP()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0000FD00 File Offset: 0x0000DF00
		internal static void a55Gpob4xrNPaZ9MIBW()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x040002AF RID: 687
		private static NativeExceptionStructHandler_24_0 NCYkJ4busKI75xjtyBr;

		// Token: 0x020000A9 RID: 169
		internal struct Il2CppException_24_0
		{
			// Token: 0x040002B0 RID: 688
			public Il2CppObject _object;

			// Token: 0x040002B1 RID: 689
			public unsafe Il2CppString* className;

			// Token: 0x040002B2 RID: 690
			public unsafe Il2CppString* message;

			// Token: 0x040002B3 RID: 691
			public unsafe Il2CppObject* _data;

			// Token: 0x040002B4 RID: 692
			public unsafe Il2CppException* inner_ex;

			// Token: 0x040002B5 RID: 693
			public unsafe Il2CppString* _helpURL;

			// Token: 0x040002B6 RID: 694
			public unsafe void* trace_ips;

			// Token: 0x040002B7 RID: 695
			public unsafe Il2CppString* stack_trace;

			// Token: 0x040002B8 RID: 696
			public unsafe Il2CppString* remote_stack_trace;

			// Token: 0x040002B9 RID: 697
			public int remote_stack_index;

			// Token: 0x040002BA RID: 698
			public unsafe Il2CppObject* _dynamicMethods;

			// Token: 0x040002BB RID: 699
			public il2cpp_hresult_t hresult;

			// Token: 0x040002BC RID: 700
			public unsafe Il2CppString* source;

			// Token: 0x040002BD RID: 701
			public unsafe Il2CppObject* safeSerializationManager;

			// Token: 0x040002BE RID: 702
			public unsafe void* captured_traces;

			// Token: 0x040002BF RID: 703
			public unsafe void* native_trace_ips;
		}

		// Token: 0x020000AA RID: 170
		internal class NativeStructWrapper : INativeExceptionStruct, INativeStruct
		{
			// Token: 0x06000628 RID: 1576 RVA: 0x0001C134 File Offset: 0x0001A334
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeExceptionStructHandler_24_0.NativeStructWrapper.g4KIERuTF17ogGOLVjg();
				NativeExceptionStructHandler_24_0.NativeStructWrapper.YxaJTWugxJRRFjXCr7m();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_856ffe7e0c9b4de88d71070d175d49fd != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x06000629 RID: 1577 RVA: 0x0001C1C4 File Offset: 0x0001A3C4
			private unsafe NativeExceptionStructHandler_24_0.Il2CppException_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700015E RID: 350
			// (get) Token: 0x0600062A RID: 1578 RVA: 0x0001C1D4 File Offset: 0x0001A3D4
			public IntPtr Pointer { get; }

			// Token: 0x1700015F RID: 351
			// (get) Token: 0x0600062B RID: 1579 RVA: 0x0001C1E4 File Offset: 0x0001A3E4
			public unsafe Il2CppException* ExceptionPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000160 RID: 352
			// (get) Token: 0x0600062C RID: 1580 RVA: 0x0001C1F4 File Offset: 0x0001A3F4
			public unsafe ref Il2CppException* InnerException
			{
				get
				{
					return ref this._->inner_ex;
				}
			}

			// Token: 0x17000161 RID: 353
			// (get) Token: 0x0600062D RID: 1581 RVA: 0x0001C208 File Offset: 0x0001A408
			public unsafe ref Il2CppString* Message
			{
				get
				{
					return ref this._->message;
				}
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x0600062E RID: 1582 RVA: 0x0001C21C File Offset: 0x0001A41C
			public unsafe ref Il2CppString* HelpLink
			{
				get
				{
					return ref this._->_helpURL;
				}
			}

			// Token: 0x17000163 RID: 355
			// (get) Token: 0x0600062F RID: 1583 RVA: 0x0001C230 File Offset: 0x0001A430
			public unsafe ref Il2CppString* ClassName
			{
				get
				{
					return ref this._->className;
				}
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x06000630 RID: 1584 RVA: 0x0001C244 File Offset: 0x0001A444
			public unsafe ref Il2CppString* StackTrace
			{
				get
				{
					return ref this._->stack_trace;
				}
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x06000631 RID: 1585 RVA: 0x0001C258 File Offset: 0x0001A458
			public unsafe ref Il2CppString* RemoteStackTrace
			{
				get
				{
					return ref this._->remote_stack_trace;
				}
			}

			// Token: 0x06000632 RID: 1586 RVA: 0x0001C26C File Offset: 0x0001A46C
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeExceptionStructHandler_24_0.NativeStructWrapper.tH9yWKuov7NOUSckrSZ();
			}

			// Token: 0x06000633 RID: 1587 RVA: 0x0001C27C File Offset: 0x0001A47C
			internal static void g4KIERuTF17ogGOLVjg()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000634 RID: 1588 RVA: 0x0001C28C File Offset: 0x0001A48C
			internal static void YxaJTWugxJRRFjXCr7m()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000635 RID: 1589 RVA: 0x0001C29C File Offset: 0x0001A49C
			internal static bool iluiVnuG5y3UIy4kimq()
			{
				return NativeExceptionStructHandler_24_0.NativeStructWrapper.HagsnXuBE7jJ0DpPB30 == null;
			}

			// Token: 0x06000636 RID: 1590 RVA: 0x0001C2B0 File Offset: 0x0001A4B0
			internal static NativeExceptionStructHandler_24_0.NativeStructWrapper yTBL1Eurf5GsVGwBE49()
			{
				return NativeExceptionStructHandler_24_0.NativeStructWrapper.HagsnXuBE7jJ0DpPB30;
			}

			// Token: 0x06000637 RID: 1591 RVA: 0x0001C2C0 File Offset: 0x0001A4C0
			internal static void tH9yWKuov7NOUSckrSZ()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x040002C1 RID: 705
			internal static object HagsnXuBE7jJ0DpPB30;
		}
	}
}
