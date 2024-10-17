using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Exception
{
	// Token: 0x020000AA RID: 170
	[ApplicableToUnityVersionsSince("2019.3.0")]
	public class NativeExceptionStructHandler_24_0 : INativeExceptionStructHandler, INativeStructHandler
	{
		// Token: 0x06000639 RID: 1593 RVA: 0x000107BC File Offset: 0x0000E9BC
		public int Size()
		{
			return sizeof(NativeExceptionStructHandler_24_0.Il2CppException_24_0);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x000107CC File Offset: 0x0000E9CC
		public unsafe INativeExceptionStruct CreateNewStruct()
		{
			NativeExceptionStructHandler_24_0.Il2CppException_24_0* ptr2;
			IntPtr ptr = ptr2 = NativeExceptionStructHandler_24_0.nEA4GQEj1Gh9v4pQIYw(this.Size());
			*ptr2 = default(NativeExceptionStructHandler_24_0.Il2CppException_24_0);
			return new NativeExceptionStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000107FC File Offset: 0x0000E9FC
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2dd85386720b438b874026b47430e4fa == 0)
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
			return new NativeExceptionStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00010864 File Offset: 0x0000EA64
		public NativeExceptionStructHandler_24_0()
		{
			NativeExceptionStructHandler_24_0.dtbay1ET0wEjnDDB3Mu();
			NativeExceptionStructHandler_24_0.daLgm0EFqWTRIReverY();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9a3e85e731764e36a5b07f4e692becd8 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000108C8 File Offset: 0x0000EAC8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeExceptionStructHandler_24_0()
		{
			NativeExceptionStructHandler_24_0.boAIgqEK9vJ59aopimZ();
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000108D8 File Offset: 0x0000EAD8
		internal static IntPtr nEA4GQEj1Gh9v4pQIYw(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x000108EC File Offset: 0x0000EAEC
		internal static bool dCSF2AEvrmlCJeZUIsQ()
		{
			return NativeExceptionStructHandler_24_0.GD3O9SEm8H4Ytod3YyF == null;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00010900 File Offset: 0x0000EB00
		internal static NativeExceptionStructHandler_24_0 qHqDvxEBu4v9UdDVFKE()
		{
			return NativeExceptionStructHandler_24_0.GD3O9SEm8H4Ytod3YyF;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00010910 File Offset: 0x0000EB10
		internal static void dtbay1ET0wEjnDDB3Mu()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00010920 File Offset: 0x0000EB20
		internal static void daLgm0EFqWTRIReverY()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00010930 File Offset: 0x0000EB30
		internal static void boAIgqEK9vJ59aopimZ()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040002BA RID: 698
		internal static NativeExceptionStructHandler_24_0 GD3O9SEm8H4Ytod3YyF;

		// Token: 0x020000AB RID: 171
		internal struct Il2CppException_24_0
		{
			// Token: 0x040002BB RID: 699
			public Il2CppObject _object;

			// Token: 0x040002BC RID: 700
			public unsafe Il2CppString* className;

			// Token: 0x040002BD RID: 701
			public unsafe Il2CppString* message;

			// Token: 0x040002BE RID: 702
			public unsafe Il2CppObject* _data;

			// Token: 0x040002BF RID: 703
			public unsafe Il2CppException* inner_ex;

			// Token: 0x040002C0 RID: 704
			public unsafe Il2CppString* _helpURL;

			// Token: 0x040002C1 RID: 705
			public unsafe void* trace_ips;

			// Token: 0x040002C2 RID: 706
			public unsafe Il2CppString* stack_trace;

			// Token: 0x040002C3 RID: 707
			public unsafe Il2CppString* remote_stack_trace;

			// Token: 0x040002C4 RID: 708
			public int remote_stack_index;

			// Token: 0x040002C5 RID: 709
			public unsafe Il2CppObject* _dynamicMethods;

			// Token: 0x040002C6 RID: 710
			public il2cpp_hresult_t hresult;

			// Token: 0x040002C7 RID: 711
			public unsafe Il2CppString* source;

			// Token: 0x040002C8 RID: 712
			public unsafe Il2CppObject* safeSerializationManager;

			// Token: 0x040002C9 RID: 713
			public unsafe void* captured_traces;

			// Token: 0x040002CA RID: 714
			public unsafe void* native_trace_ips;
		}

		// Token: 0x020000AC RID: 172
		internal class NativeStructWrapper : INativeExceptionStruct, INativeStruct
		{
			// Token: 0x06000644 RID: 1604 RVA: 0x0001CD9C File Offset: 0x0001AF9C
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeExceptionStructHandler_24_0.NativeStructWrapper.l62haQZ02qwTgqjBTOA();
				NativeExceptionStructHandler_24_0.NativeStructWrapper.hgD6wZZNVhfLaM8aHqW();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8155e7a9a9bd4894b741e1951a0eace6 != 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40 == 0)
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
			// (get) Token: 0x06000645 RID: 1605 RVA: 0x0001CE2C File Offset: 0x0001B02C
			private unsafe NativeExceptionStructHandler_24_0.Il2CppException_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700015E RID: 350
			// (get) Token: 0x06000646 RID: 1606 RVA: 0x0001CE3C File Offset: 0x0001B03C
			public IntPtr Pointer { get; }

			// Token: 0x1700015F RID: 351
			// (get) Token: 0x06000647 RID: 1607 RVA: 0x0001CE4C File Offset: 0x0001B04C
			public unsafe Il2CppException* ExceptionPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000160 RID: 352
			// (get) Token: 0x06000648 RID: 1608 RVA: 0x0001CE5C File Offset: 0x0001B05C
			public unsafe ref Il2CppException* InnerException
			{
				get
				{
					return ref this._->inner_ex;
				}
			}

			// Token: 0x17000161 RID: 353
			// (get) Token: 0x06000649 RID: 1609 RVA: 0x0001CE70 File Offset: 0x0001B070
			public unsafe ref Il2CppString* Message
			{
				get
				{
					return ref this._->message;
				}
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x0600064A RID: 1610 RVA: 0x0001CE84 File Offset: 0x0001B084
			public unsafe ref Il2CppString* HelpLink
			{
				get
				{
					return ref this._->_helpURL;
				}
			}

			// Token: 0x17000163 RID: 355
			// (get) Token: 0x0600064B RID: 1611 RVA: 0x0001CE98 File Offset: 0x0001B098
			public unsafe ref Il2CppString* ClassName
			{
				get
				{
					return ref this._->className;
				}
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x0600064C RID: 1612 RVA: 0x0001CEAC File Offset: 0x0001B0AC
			public unsafe ref Il2CppString* StackTrace
			{
				get
				{
					return ref this._->stack_trace;
				}
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x0600064D RID: 1613 RVA: 0x0001CEC0 File Offset: 0x0001B0C0
			public unsafe ref Il2CppString* RemoteStackTrace
			{
				get
				{
					return ref this._->remote_stack_trace;
				}
			}

			// Token: 0x0600064E RID: 1614 RVA: 0x0001CED4 File Offset: 0x0001B0D4
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeExceptionStructHandler_24_0.NativeStructWrapper.GHtetKZu26011O9Lfqh();
			}

			// Token: 0x0600064F RID: 1615 RVA: 0x0001CEE4 File Offset: 0x0001B0E4
			internal static void l62haQZ02qwTgqjBTOA()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000650 RID: 1616 RVA: 0x0001CEF4 File Offset: 0x0001B0F4
			internal static void hgD6wZZNVhfLaM8aHqW()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000651 RID: 1617 RVA: 0x0001CF04 File Offset: 0x0001B104
			internal static bool ceg1NyZhCfgjTDL10aN()
			{
				return NativeExceptionStructHandler_24_0.NativeStructWrapper.ESXr5XZxw8BFbRUfVUy == null;
			}

			// Token: 0x06000652 RID: 1618 RVA: 0x0001CF18 File Offset: 0x0001B118
			internal static NativeExceptionStructHandler_24_0.NativeStructWrapper onXRgXZ8n3Wv8R2OuuG()
			{
				return NativeExceptionStructHandler_24_0.NativeStructWrapper.ESXr5XZxw8BFbRUfVUy;
			}

			// Token: 0x06000653 RID: 1619 RVA: 0x0001CF28 File Offset: 0x0001B128
			internal static void GHtetKZu26011O9Lfqh()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x040002CC RID: 716
			private static object ESXr5XZxw8BFbRUfVUy;
		}
	}
}
