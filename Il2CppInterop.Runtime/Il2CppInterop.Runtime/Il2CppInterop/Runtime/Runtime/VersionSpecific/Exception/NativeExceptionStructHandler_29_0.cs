using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Exception
{
	// Token: 0x020000AD RID: 173
	[ApplicableToUnityVersionsSince("2021.2.0")]
	public class NativeExceptionStructHandler_29_0 : INativeExceptionStructHandler, INativeStructHandler
	{
		// Token: 0x06000654 RID: 1620 RVA: 0x00010940 File Offset: 0x0000EB40
		public int Size()
		{
			return sizeof(NativeExceptionStructHandler_29_0.Il2CppException_29_0);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00010950 File Offset: 0x0000EB50
		public unsafe INativeExceptionStruct CreateNewStruct()
		{
			NativeExceptionStructHandler_29_0.Il2CppException_29_0* ptr2;
			IntPtr ptr = ptr2 = NativeExceptionStructHandler_29_0.xyG3SIE1305JubRY9ma(this.Size());
			*ptr2 = default(NativeExceptionStructHandler_29_0.Il2CppException_29_0);
			return new NativeExceptionStructHandler_29_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00010980 File Offset: 0x0000EB80
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5a8626d471f54eba873ce59c8785d9b9 == 0)
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

		// Token: 0x06000657 RID: 1623 RVA: 0x000109E8 File Offset: 0x0000EBE8
		public NativeExceptionStructHandler_29_0()
		{
			NativeExceptionStructHandler_29_0.qLsHspEMgF1UNKgboli();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b3f1fcfa11104bd49a7f00386d38b4f4 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00010A4C File Offset: 0x0000EC4C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeExceptionStructHandler_29_0()
		{
			NativeExceptionStructHandler_29_0.H84bidEpwS8wG7JNoqv();
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00010A5C File Offset: 0x0000EC5C
		internal static IntPtr xyG3SIE1305JubRY9ma(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00010A70 File Offset: 0x0000EC70
		internal static bool lfVCEnEnEfaS2LrSgeb()
		{
			return NativeExceptionStructHandler_29_0.DS1HGBE5XT8dyFITBbF == null;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00010A84 File Offset: 0x0000EC84
		internal static NativeExceptionStructHandler_29_0 SIaIioE3YmBhD7ghHRn()
		{
			return NativeExceptionStructHandler_29_0.DS1HGBE5XT8dyFITBbF;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00010A94 File Offset: 0x0000EC94
		internal static void qLsHspEMgF1UNKgboli()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00010AA4 File Offset: 0x0000ECA4
		internal static void H84bidEpwS8wG7JNoqv()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040002CD RID: 717
		private static NativeExceptionStructHandler_29_0 DS1HGBE5XT8dyFITBbF;

		// Token: 0x020000AE RID: 174
		internal struct Il2CppException_29_0
		{
			// Token: 0x040002CE RID: 718
			public Il2CppObject _object;

			// Token: 0x040002CF RID: 719
			public unsafe Il2CppString* className;

			// Token: 0x040002D0 RID: 720
			public unsafe Il2CppString* message;

			// Token: 0x040002D1 RID: 721
			public unsafe Il2CppObject* _data;

			// Token: 0x040002D2 RID: 722
			public unsafe Il2CppException* inner_ex;

			// Token: 0x040002D3 RID: 723
			public unsafe Il2CppString* _helpURL;

			// Token: 0x040002D4 RID: 724
			public unsafe void* trace_ips;

			// Token: 0x040002D5 RID: 725
			public unsafe Il2CppString* stack_trace;

			// Token: 0x040002D6 RID: 726
			public unsafe Il2CppString* remote_stack_trace;

			// Token: 0x040002D7 RID: 727
			public int remote_stack_index;

			// Token: 0x040002D8 RID: 728
			public unsafe Il2CppObject* _dynamicMethods;

			// Token: 0x040002D9 RID: 729
			public il2cpp_hresult_t hresult;

			// Token: 0x040002DA RID: 730
			public unsafe Il2CppString* source;

			// Token: 0x040002DB RID: 731
			public unsafe Il2CppObject* safeSerializationManager;

			// Token: 0x040002DC RID: 732
			public unsafe void* captured_traces;

			// Token: 0x040002DD RID: 733
			public unsafe void* native_trace_ips;

			// Token: 0x040002DE RID: 734
			public int caught_in_unmanaged;
		}

		// Token: 0x020000AF RID: 175
		internal class NativeStructWrapper : INativeExceptionStruct, INativeStruct
		{
			// Token: 0x0600065E RID: 1630 RVA: 0x0001CF38 File Offset: 0x0001B138
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeExceptionStructHandler_29_0.NativeStructWrapper.kHd201ZkL62sonP54SG();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f7e83c7c87bd4de9b4cb2b7f339254ad == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x0600065F RID: 1631 RVA: 0x0001CFC8 File Offset: 0x0001B1C8
			private unsafe NativeExceptionStructHandler_29_0.Il2CppException_29_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x06000660 RID: 1632 RVA: 0x0001CFD8 File Offset: 0x0001B1D8
			public IntPtr Pointer { get; }

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x06000661 RID: 1633 RVA: 0x0001CFE8 File Offset: 0x0001B1E8
			public unsafe Il2CppException* ExceptionPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000169 RID: 361
			// (get) Token: 0x06000662 RID: 1634 RVA: 0x0001CFF8 File Offset: 0x0001B1F8
			public unsafe ref Il2CppException* InnerException
			{
				get
				{
					return ref this._->inner_ex;
				}
			}

			// Token: 0x1700016A RID: 362
			// (get) Token: 0x06000663 RID: 1635 RVA: 0x0001D00C File Offset: 0x0001B20C
			public unsafe ref Il2CppString* Message
			{
				get
				{
					return ref this._->message;
				}
			}

			// Token: 0x1700016B RID: 363
			// (get) Token: 0x06000664 RID: 1636 RVA: 0x0001D020 File Offset: 0x0001B220
			public unsafe ref Il2CppString* HelpLink
			{
				get
				{
					return ref this._->_helpURL;
				}
			}

			// Token: 0x1700016C RID: 364
			// (get) Token: 0x06000665 RID: 1637 RVA: 0x0001D034 File Offset: 0x0001B234
			public unsafe ref Il2CppString* ClassName
			{
				get
				{
					return ref this._->className;
				}
			}

			// Token: 0x1700016D RID: 365
			// (get) Token: 0x06000666 RID: 1638 RVA: 0x0001D048 File Offset: 0x0001B248
			public unsafe ref Il2CppString* StackTrace
			{
				get
				{
					return ref this._->stack_trace;
				}
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x06000667 RID: 1639 RVA: 0x0001D05C File Offset: 0x0001B25C
			public unsafe ref Il2CppString* RemoteStackTrace
			{
				get
				{
					return ref this._->remote_stack_trace;
				}
			}

			// Token: 0x06000668 RID: 1640 RVA: 0x0001D070 File Offset: 0x0001B270
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeExceptionStructHandler_29_0.NativeStructWrapper.t6E0kAZJBJUaYUgOm0X();
			}

			// Token: 0x06000669 RID: 1641 RVA: 0x0001D080 File Offset: 0x0001B280
			internal static void kHd201ZkL62sonP54SG()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600066A RID: 1642 RVA: 0x0001D090 File Offset: 0x0001B290
			internal static bool QBgppQZ7PdkXXWrk5T2()
			{
				return NativeExceptionStructHandler_29_0.NativeStructWrapper.e5JveyZL8DkWMQj8mTh == null;
			}

			// Token: 0x0600066B RID: 1643 RVA: 0x0001D0A4 File Offset: 0x0001B2A4
			internal static NativeExceptionStructHandler_29_0.NativeStructWrapper tmeUSdZR4ybxl6V0pYF()
			{
				return NativeExceptionStructHandler_29_0.NativeStructWrapper.e5JveyZL8DkWMQj8mTh;
			}

			// Token: 0x0600066C RID: 1644 RVA: 0x0001D0B4 File Offset: 0x0001B2B4
			internal static void t6E0kAZJBJUaYUgOm0X()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x040002E0 RID: 736
			internal static object e5JveyZL8DkWMQj8mTh;
		}
	}
}
