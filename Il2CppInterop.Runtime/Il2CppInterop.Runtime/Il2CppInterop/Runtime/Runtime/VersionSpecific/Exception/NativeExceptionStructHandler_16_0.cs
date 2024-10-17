using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Exception
{
	// Token: 0x020000A1 RID: 161
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeExceptionStructHandler_16_0 : INativeExceptionStructHandler, INativeStructHandler
	{
		// Token: 0x060005ED RID: 1517 RVA: 0x00010388 File Offset: 0x0000E588
		public int Size()
		{
			return sizeof(NativeExceptionStructHandler_16_0.Il2CppException_16_0);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00010398 File Offset: 0x0000E598
		public unsafe INativeExceptionStruct CreateNewStruct()
		{
			NativeExceptionStructHandler_16_0.Il2CppException_16_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeExceptionStructHandler_16_0.Il2CppException_16_0);
			return new NativeExceptionStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x000103C8 File Offset: 0x0000E5C8
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bacedfb8a3cf4671ae3e03ec2f965495 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeExceptionStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00010430 File Offset: 0x0000E630
		public NativeExceptionStructHandler_16_0()
		{
			NativeExceptionStructHandler_16_0.C2o1NWEd51kqeNFnNRj();
			NativeExceptionStructHandler_16_0.xaAVfkEwc3QcOJFGCFV();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2f48f5515514b5a9a5feed6dc9a8dce == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00010494 File Offset: 0x0000E694
		// Note: this type is marked as 'beforefieldinit'.
		static NativeExceptionStructHandler_16_0()
		{
			NativeExceptionStructHandler_16_0.LhrVuuEe5E6PDru4djL();
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x000104A4 File Offset: 0x0000E6A4
		internal static bool zSCksREfwAgX1o9YHBM()
		{
			return NativeExceptionStructHandler_16_0.F13oaxEbPEsKHKCsxK4 == null;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x000104B8 File Offset: 0x0000E6B8
		internal static NativeExceptionStructHandler_16_0 m5NjJEEPvBbKRU4RlxL()
		{
			return NativeExceptionStructHandler_16_0.F13oaxEbPEsKHKCsxK4;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000104C8 File Offset: 0x0000E6C8
		internal static void C2o1NWEd51kqeNFnNRj()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x000104D8 File Offset: 0x0000E6D8
		internal static void xaAVfkEwc3QcOJFGCFV()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x000104E8 File Offset: 0x0000E6E8
		internal static void LhrVuuEe5E6PDru4djL()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400028D RID: 653
		internal static NativeExceptionStructHandler_16_0 F13oaxEbPEsKHKCsxK4;

		// Token: 0x020000A2 RID: 162
		internal struct Il2CppException_16_0
		{
			// Token: 0x0400028E RID: 654
			public Il2CppObject _object;

			// Token: 0x0400028F RID: 655
			public unsafe void* trace_ips;

			// Token: 0x04000290 RID: 656
			public unsafe Il2CppObject* inner_ex;

			// Token: 0x04000291 RID: 657
			public unsafe Il2CppString* message;

			// Token: 0x04000292 RID: 658
			public unsafe Il2CppString* help_link;

			// Token: 0x04000293 RID: 659
			public unsafe Il2CppString* class_name;

			// Token: 0x04000294 RID: 660
			public unsafe Il2CppString* stack_trace;

			// Token: 0x04000295 RID: 661
			public unsafe Il2CppString* remote_stack_trace;

			// Token: 0x04000296 RID: 662
			public int remote_stack_index;

			// Token: 0x04000297 RID: 663
			public int hresult;

			// Token: 0x04000298 RID: 664
			public unsafe Il2CppString* source;

			// Token: 0x04000299 RID: 665
			public unsafe Il2CppObject* _data;
		}

		// Token: 0x020000A3 RID: 163
		internal class NativeStructWrapper : INativeExceptionStruct, INativeStruct
		{
			// Token: 0x060005F7 RID: 1527 RVA: 0x0001C8C0 File Offset: 0x0001AAC0
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeExceptionStructHandler_16_0.NativeStructWrapper.w8oHe5DjShsaaG2NvOA();
				NativeExceptionStructHandler_16_0.NativeStructWrapper.YbNRi1DT5K19mnyknrf();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c23fbb8072754781976c5c809c25ef15 != 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.<Pointer>k__BackingField = ptr;
						num = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fdb0528b1ef843aca29153aec62fa60d != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0001C950 File Offset: 0x0001AB50
			private unsafe NativeExceptionStructHandler_16_0.Il2CppException_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0001C960 File Offset: 0x0001AB60
			public IntPtr Pointer { get; }

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x060005FA RID: 1530 RVA: 0x0001C970 File Offset: 0x0001AB70
			public unsafe Il2CppException* ExceptionPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x060005FB RID: 1531 RVA: 0x0001C980 File Offset: 0x0001AB80
			public unsafe ref Il2CppException* InnerException
			{
				get
				{
					return ref *(Il2CppException**)(&this._->inner_ex);
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x060005FC RID: 1532 RVA: 0x0001C998 File Offset: 0x0001AB98
			public unsafe ref Il2CppString* Message
			{
				get
				{
					return ref this._->message;
				}
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x060005FD RID: 1533 RVA: 0x0001C9AC File Offset: 0x0001ABAC
			public unsafe ref Il2CppString* HelpLink
			{
				get
				{
					return ref this._->help_link;
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x060005FE RID: 1534 RVA: 0x0001C9C0 File Offset: 0x0001ABC0
			public unsafe ref Il2CppString* ClassName
			{
				get
				{
					return ref this._->class_name;
				}
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x060005FF RID: 1535 RVA: 0x0001C9D4 File Offset: 0x0001ABD4
			public unsafe ref Il2CppString* StackTrace
			{
				get
				{
					return ref this._->stack_trace;
				}
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x06000600 RID: 1536 RVA: 0x0001C9E8 File Offset: 0x0001ABE8
			public unsafe ref Il2CppString* RemoteStackTrace
			{
				get
				{
					return ref this._->remote_stack_trace;
				}
			}

			// Token: 0x06000601 RID: 1537 RVA: 0x0001C9FC File Offset: 0x0001ABFC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeExceptionStructHandler_16_0.NativeStructWrapper.xea2OnDFipWYq2l8RS6();
			}

			// Token: 0x06000602 RID: 1538 RVA: 0x0001CA0C File Offset: 0x0001AC0C
			internal static void w8oHe5DjShsaaG2NvOA()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000603 RID: 1539 RVA: 0x0001CA1C File Offset: 0x0001AC1C
			internal static void YbNRi1DT5K19mnyknrf()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000604 RID: 1540 RVA: 0x0001CA2C File Offset: 0x0001AC2C
			internal static bool xT0Pq2Dvd5oIL2whrlb()
			{
				return NativeExceptionStructHandler_16_0.NativeStructWrapper.oAllwuDmB0YM0gpF08R == null;
			}

			// Token: 0x06000605 RID: 1541 RVA: 0x0001CA40 File Offset: 0x0001AC40
			internal static NativeExceptionStructHandler_16_0.NativeStructWrapper w5lDGSDBGHBNQeU6lFF()
			{
				return NativeExceptionStructHandler_16_0.NativeStructWrapper.oAllwuDmB0YM0gpF08R;
			}

			// Token: 0x06000606 RID: 1542 RVA: 0x0001CA50 File Offset: 0x0001AC50
			internal static void xea2OnDFipWYq2l8RS6()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0400029B RID: 667
			internal static object oAllwuDmB0YM0gpF08R;
		}
	}
}
