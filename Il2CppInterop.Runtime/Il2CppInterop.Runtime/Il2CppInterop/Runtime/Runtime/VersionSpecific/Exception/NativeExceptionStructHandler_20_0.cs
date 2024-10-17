using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Exception
{
	// Token: 0x020000A4 RID: 164
	[ApplicableToUnityVersionsSince("5.3.3")]
	public class NativeExceptionStructHandler_20_0 : INativeExceptionStructHandler, INativeStructHandler
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x000104F8 File Offset: 0x0000E6F8
		public int Size()
		{
			return sizeof(NativeExceptionStructHandler_20_0.Il2CppException_20_0);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00010508 File Offset: 0x0000E708
		public unsafe INativeExceptionStruct CreateNewStruct()
		{
			NativeExceptionStructHandler_20_0.Il2CppException_20_0* ptr2;
			IntPtr ptr = ptr2 = NativeExceptionStructHandler_20_0.JTXq79Ey1okMhkliv3p(this.Size());
			*ptr2 = default(NativeExceptionStructHandler_20_0.Il2CppException_20_0);
			return new NativeExceptionStructHandler_20_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00010538 File Offset: 0x0000E738
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c2ad52141772446383547acade021f9a == 0)
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

		// Token: 0x0600060A RID: 1546 RVA: 0x000105A0 File Offset: 0x0000E7A0
		public NativeExceptionStructHandler_20_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7c2c0376e816400db5716cff194385b2 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00010604 File Offset: 0x0000E804
		// Note: this type is marked as 'beforefieldinit'.
		static NativeExceptionStructHandler_20_0()
		{
			NativeExceptionStructHandler_20_0.DwhKxZESLjdFXE5ROPk();
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00010614 File Offset: 0x0000E814
		internal static IntPtr JTXq79Ey1okMhkliv3p(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00010628 File Offset: 0x0000E828
		internal static bool Hp7MStEQ6wIOCgvoZrA()
		{
			return NativeExceptionStructHandler_20_0.Qh1BnrEsvRDXOb8LW5j == null;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0001063C File Offset: 0x0000E83C
		internal static NativeExceptionStructHandler_20_0 bFcKAVE2BBWrrebq9Q6()
		{
			return NativeExceptionStructHandler_20_0.Qh1BnrEsvRDXOb8LW5j;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0001064C File Offset: 0x0000E84C
		internal static void DwhKxZESLjdFXE5ROPk()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400029C RID: 668
		internal static NativeExceptionStructHandler_20_0 Qh1BnrEsvRDXOb8LW5j;

		// Token: 0x020000A5 RID: 165
		internal struct Il2CppException_20_0
		{
			// Token: 0x0400029D RID: 669
			public Il2CppObject _object;

			// Token: 0x0400029E RID: 670
			public unsafe void* trace_ips;

			// Token: 0x0400029F RID: 671
			public unsafe Il2CppObject* inner_ex;

			// Token: 0x040002A0 RID: 672
			public unsafe Il2CppString* message;

			// Token: 0x040002A1 RID: 673
			public unsafe Il2CppString* help_link;

			// Token: 0x040002A2 RID: 674
			public unsafe Il2CppString* class_name;

			// Token: 0x040002A3 RID: 675
			public unsafe Il2CppString* stack_trace;

			// Token: 0x040002A4 RID: 676
			public unsafe Il2CppString* remote_stack_trace;

			// Token: 0x040002A5 RID: 677
			public int remote_stack_index;

			// Token: 0x040002A6 RID: 678
			public il2cpp_hresult_t hresult;

			// Token: 0x040002A7 RID: 679
			public unsafe Il2CppString* source;

			// Token: 0x040002A8 RID: 680
			public unsafe Il2CppObject* _data;
		}

		// Token: 0x020000A6 RID: 166
		internal class NativeStructWrapper : INativeExceptionStruct, INativeStruct
		{
			// Token: 0x06000610 RID: 1552 RVA: 0x0001CA60 File Offset: 0x0001AC60
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeExceptionStructHandler_20_0.NativeStructWrapper.RhHZqZDpVAjYMb9Gts2();
				NativeExceptionStructHandler_20_0.NativeStructWrapper.u6f31BD4sLxHi3USkcV();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_944294969d634011bf30e3f4f506a31e == 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						this.<Pointer>k__BackingField = ptr;
						num = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_468d644ed32a4ba3ad77ef2c95e2ad4b == 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x06000611 RID: 1553 RVA: 0x0001CAF0 File Offset: 0x0001ACF0
			private unsafe NativeExceptionStructHandler_20_0.Il2CppException_20_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700014C RID: 332
			// (get) Token: 0x06000612 RID: 1554 RVA: 0x0001CB00 File Offset: 0x0001AD00
			public IntPtr Pointer { get; }

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x06000613 RID: 1555 RVA: 0x0001CB10 File Offset: 0x0001AD10
			public unsafe Il2CppException* ExceptionPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x06000614 RID: 1556 RVA: 0x0001CB20 File Offset: 0x0001AD20
			public unsafe ref Il2CppException* InnerException
			{
				get
				{
					return ref *(Il2CppException**)(&this._->inner_ex);
				}
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x06000615 RID: 1557 RVA: 0x0001CB38 File Offset: 0x0001AD38
			public unsafe ref Il2CppString* Message
			{
				get
				{
					return ref this._->message;
				}
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x06000616 RID: 1558 RVA: 0x0001CB4C File Offset: 0x0001AD4C
			public unsafe ref Il2CppString* HelpLink
			{
				get
				{
					return ref this._->help_link;
				}
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x06000617 RID: 1559 RVA: 0x0001CB60 File Offset: 0x0001AD60
			public unsafe ref Il2CppString* ClassName
			{
				get
				{
					return ref this._->class_name;
				}
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x06000618 RID: 1560 RVA: 0x0001CB74 File Offset: 0x0001AD74
			public unsafe ref Il2CppString* StackTrace
			{
				get
				{
					return ref this._->stack_trace;
				}
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x06000619 RID: 1561 RVA: 0x0001CB88 File Offset: 0x0001AD88
			public unsafe ref Il2CppString* RemoteStackTrace
			{
				get
				{
					return ref this._->remote_stack_trace;
				}
			}

			// Token: 0x0600061A RID: 1562 RVA: 0x0001CB9C File Offset: 0x0001AD9C
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeExceptionStructHandler_20_0.NativeStructWrapper.WMy641DzLc2Jg4DDrMl();
			}

			// Token: 0x0600061B RID: 1563 RVA: 0x0001CBAC File Offset: 0x0001ADAC
			internal static void RhHZqZDpVAjYMb9Gts2()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600061C RID: 1564 RVA: 0x0001CBBC File Offset: 0x0001ADBC
			internal static void u6f31BD4sLxHi3USkcV()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x0600061D RID: 1565 RVA: 0x0001CBCC File Offset: 0x0001ADCC
			internal static bool ByVTK8D1aSOBfAfUmLL()
			{
				return NativeExceptionStructHandler_20_0.NativeStructWrapper.lYb2PpD36HsNXSW3nXi == null;
			}

			// Token: 0x0600061E RID: 1566 RVA: 0x0001CBE0 File Offset: 0x0001ADE0
			internal static NativeExceptionStructHandler_20_0.NativeStructWrapper GqcWyqDMaC2a7wif3xQ()
			{
				return NativeExceptionStructHandler_20_0.NativeStructWrapper.lYb2PpD36HsNXSW3nXi;
			}

			// Token: 0x0600061F RID: 1567 RVA: 0x0001CBF0 File Offset: 0x0001ADF0
			internal static void WMy641DzLc2Jg4DDrMl()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x040002AA RID: 682
			internal static object lYb2PpD36HsNXSW3nXi;
		}
	}
}
