using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Exception
{
	// Token: 0x0200009F RID: 159
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeExceptionStructHandler_16_0 : INativeExceptionStructHandler, INativeStructHandler
	{
		// Token: 0x060005D5 RID: 1493 RVA: 0x0000F764 File Offset: 0x0000D964
		public int Size()
		{
			return sizeof(NativeExceptionStructHandler_16_0.Il2CppException_16_0);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0000F774 File Offset: 0x0000D974
		public unsafe INativeExceptionStruct CreateNewStruct()
		{
			NativeExceptionStructHandler_16_0.Il2CppException_16_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeExceptionStructHandler_16_0.Il2CppException_16_0);
			return new NativeExceptionStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0000F7A4 File Offset: 0x0000D9A4
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb8decd62b945dda713f7b22b6b95ca == 0)
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
			return new NativeExceptionStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0000F80C File Offset: 0x0000DA0C
		public NativeExceptionStructHandler_16_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4f0a774880f74bccb3d4511e5f526375 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0000F870 File Offset: 0x0000DA70
		// Note: this type is marked as 'beforefieldinit'.
		static NativeExceptionStructHandler_16_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0000F880 File Offset: 0x0000DA80
		internal static bool xK7OHtbv79aeUA5cclP()
		{
			return NativeExceptionStructHandler_16_0.htZ56ZbtkvdDNS3MimS == null;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0000F894 File Offset: 0x0000DA94
		internal static NativeExceptionStructHandler_16_0 amx2u7bxiRLyPhxclZV()
		{
			return NativeExceptionStructHandler_16_0.htZ56ZbtkvdDNS3MimS;
		}

		// Token: 0x04000282 RID: 642
		internal static NativeExceptionStructHandler_16_0 htZ56ZbtkvdDNS3MimS;

		// Token: 0x020000A0 RID: 160
		internal struct Il2CppException_16_0
		{
			// Token: 0x04000283 RID: 643
			public Il2CppObject _object;

			// Token: 0x04000284 RID: 644
			public unsafe void* trace_ips;

			// Token: 0x04000285 RID: 645
			public unsafe Il2CppObject* inner_ex;

			// Token: 0x04000286 RID: 646
			public unsafe Il2CppString* message;

			// Token: 0x04000287 RID: 647
			public unsafe Il2CppString* help_link;

			// Token: 0x04000288 RID: 648
			public unsafe Il2CppString* class_name;

			// Token: 0x04000289 RID: 649
			public unsafe Il2CppString* stack_trace;

			// Token: 0x0400028A RID: 650
			public unsafe Il2CppString* remote_stack_trace;

			// Token: 0x0400028B RID: 651
			public int remote_stack_index;

			// Token: 0x0400028C RID: 652
			public int hresult;

			// Token: 0x0400028D RID: 653
			public unsafe Il2CppString* source;

			// Token: 0x0400028E RID: 654
			public unsafe Il2CppObject* _data;
		}

		// Token: 0x020000A1 RID: 161
		internal class NativeStructWrapper : INativeExceptionStruct, INativeStruct
		{
			// Token: 0x060005DC RID: 1500 RVA: 0x0001BC88 File Offset: 0x00019E88
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeExceptionStructHandler_16_0.NativeStructWrapper.JxiaTBuNXTW6ZxauUd9();
				NativeExceptionStructHandler_16_0.NativeStructWrapper.Au10XMuuTdsbTYPcaiG();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6d7a22a8da0c4b3e8cf479dd7edc9922 == 0)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0299b24d936d41acaea60798c25b2a4b != 0)
					{
						num = 0;
					}
				}
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x060005DD RID: 1501 RVA: 0x0001BD18 File Offset: 0x00019F18
			private unsafe NativeExceptionStructHandler_16_0.Il2CppException_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x060005DE RID: 1502 RVA: 0x0001BD28 File Offset: 0x00019F28
			public IntPtr Pointer { get; }

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x060005DF RID: 1503 RVA: 0x0001BD38 File Offset: 0x00019F38
			public unsafe Il2CppException* ExceptionPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0001BD48 File Offset: 0x00019F48
			public unsafe ref Il2CppException* InnerException
			{
				get
				{
					return ref *(Il2CppException**)(&this._->inner_ex);
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0001BD60 File Offset: 0x00019F60
			public unsafe ref Il2CppString* Message
			{
				get
				{
					return ref this._->message;
				}
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0001BD74 File Offset: 0x00019F74
			public unsafe ref Il2CppString* HelpLink
			{
				get
				{
					return ref this._->help_link;
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0001BD88 File Offset: 0x00019F88
			public unsafe ref Il2CppString* ClassName
			{
				get
				{
					return ref this._->class_name;
				}
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0001BD9C File Offset: 0x00019F9C
			public unsafe ref Il2CppString* StackTrace
			{
				get
				{
					return ref this._->stack_trace;
				}
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x060005E5 RID: 1509 RVA: 0x0001BDB0 File Offset: 0x00019FB0
			public unsafe ref Il2CppString* RemoteStackTrace
			{
				get
				{
					return ref this._->remote_stack_trace;
				}
			}

			// Token: 0x060005E6 RID: 1510 RVA: 0x0001BDC4 File Offset: 0x00019FC4
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeExceptionStructHandler_16_0.NativeStructWrapper.rTPlTjuDLB0odG7i2IO();
			}

			// Token: 0x060005E7 RID: 1511 RVA: 0x0001BDD4 File Offset: 0x00019FD4
			internal static void JxiaTBuNXTW6ZxauUd9()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060005E8 RID: 1512 RVA: 0x0001BDE4 File Offset: 0x00019FE4
			internal static void Au10XMuuTdsbTYPcaiG()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x060005E9 RID: 1513 RVA: 0x0001BDF4 File Offset: 0x00019FF4
			internal static bool J08QVtusesxceNnSJYr()
			{
				return NativeExceptionStructHandler_16_0.NativeStructWrapper.gA5orCu0ck0IR4axkgw == null;
			}

			// Token: 0x060005EA RID: 1514 RVA: 0x0001BE08 File Offset: 0x0001A008
			internal static NativeExceptionStructHandler_16_0.NativeStructWrapper G4J5csuSwmNYNQ9v6KV()
			{
				return NativeExceptionStructHandler_16_0.NativeStructWrapper.gA5orCu0ck0IR4axkgw;
			}

			// Token: 0x060005EB RID: 1515 RVA: 0x0001BE18 File Offset: 0x0001A018
			internal static void rTPlTjuDLB0odG7i2IO()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000290 RID: 656
			private static object gA5orCu0ck0IR4axkgw;
		}
	}
}
