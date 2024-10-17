using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.EventInfo
{
	// Token: 0x020000B8 RID: 184
	[ApplicableToUnityVersionsSince("2018.3.0")]
	public class NativeEventInfoStructHandler_24_0 : INativeEventInfoStructHandler, INativeStructHandler
	{
		// Token: 0x060006AA RID: 1706 RVA: 0x00010DBC File Offset: 0x0000EFBC
		public int Size()
		{
			return sizeof(NativeEventInfoStructHandler_24_0.Il2CppEventInfo_24_0);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00010DCC File Offset: 0x0000EFCC
		public unsafe INativeEventInfoStruct CreateNewStruct()
		{
			NativeEventInfoStructHandler_24_0.Il2CppEventInfo_24_0* ptr2;
			IntPtr ptr = ptr2 = NativeEventInfoStructHandler_24_0.Mx5E9HcLSuTXxfIJWJo(this.Size());
			*ptr2 = default(NativeEventInfoStructHandler_24_0.Il2CppEventInfo_24_0);
			return new NativeEventInfoStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00010DFC File Offset: 0x0000EFFC
		public unsafe INativeEventInfoStruct Wrap(Il2CppEventInfo* ptr)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2f48f5515514b5a9a5feed6dc9a8dce == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeEventInfoStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00010E64 File Offset: 0x0000F064
		public NativeEventInfoStructHandler_24_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeEventInfoStructHandler_24_0.qhkhOfc7l4TejM8NvmL();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b8a2996bc299402b995470e3e8286d42 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00010EC8 File Offset: 0x0000F0C8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeEventInfoStructHandler_24_0()
		{
			NativeEventInfoStructHandler_24_0.BLjvlscRfNrd9v7sTwR();
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		internal static IntPtr Mx5E9HcLSuTXxfIJWJo(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00010EEC File Offset: 0x0000F0EC
		internal static bool cwkxrWccMyCQd4ZGmhL()
		{
			return NativeEventInfoStructHandler_24_0.d8NG9acEkOmC1AhpiKy == null;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00010F00 File Offset: 0x0000F100
		internal static NativeEventInfoStructHandler_24_0 zWsEXAc6aaD333TADA5()
		{
			return NativeEventInfoStructHandler_24_0.d8NG9acEkOmC1AhpiKy;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00010F10 File Offset: 0x0000F110
		internal static void qhkhOfc7l4TejM8NvmL()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00010F20 File Offset: 0x0000F120
		internal static void BLjvlscRfNrd9v7sTwR()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040002F6 RID: 758
		private static NativeEventInfoStructHandler_24_0 d8NG9acEkOmC1AhpiKy;

		// Token: 0x020000B9 RID: 185
		internal struct Il2CppEventInfo_24_0
		{
			// Token: 0x040002F7 RID: 759
			public unsafe byte* name;

			// Token: 0x040002F8 RID: 760
			public unsafe Il2CppTypeStruct* eventType;

			// Token: 0x040002F9 RID: 761
			public unsafe Il2CppClass* parent;

			// Token: 0x040002FA RID: 762
			public unsafe Il2CppMethodInfo* add;

			// Token: 0x040002FB RID: 763
			public unsafe Il2CppMethodInfo* remove;

			// Token: 0x040002FC RID: 764
			public unsafe Il2CppMethodInfo* raise;

			// Token: 0x040002FD RID: 765
			public uint token;
		}

		// Token: 0x020000BA RID: 186
		internal class NativeStructWrapper : INativeEventInfoStruct, INativeStruct
		{
			// Token: 0x060006B4 RID: 1716 RVA: 0x0001D3E4 File Offset: 0x0001B5E4
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeEventInfoStructHandler_24_0.NativeStructWrapper.KrcZeNZvK0hM3wgCqPp();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_39f2b5d6802b4ad087933b982faeb79d == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_17522b2a3ddb488c87b7266d3b1f941d != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x17000188 RID: 392
			// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0001D474 File Offset: 0x0001B674
			private unsafe NativeEventInfoStructHandler_24_0.Il2CppEventInfo_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000189 RID: 393
			// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0001D484 File Offset: 0x0001B684
			public IntPtr Pointer { get; }

			// Token: 0x1700018A RID: 394
			// (get) Token: 0x060006B7 RID: 1719 RVA: 0x0001D494 File Offset: 0x0001B694
			public unsafe Il2CppEventInfo* EventInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700018B RID: 395
			// (get) Token: 0x060006B8 RID: 1720 RVA: 0x0001D4A4 File Offset: 0x0001B6A4
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0001D4BC File Offset: 0x0001B6BC
			public unsafe ref Il2CppTypeStruct* EventType
			{
				get
				{
					return ref this._->eventType;
				}
			}

			// Token: 0x1700018D RID: 397
			// (get) Token: 0x060006BA RID: 1722 RVA: 0x0001D4D0 File Offset: 0x0001B6D0
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700018E RID: 398
			// (get) Token: 0x060006BB RID: 1723 RVA: 0x0001D4E4 File Offset: 0x0001B6E4
			public unsafe ref Il2CppMethodInfo* Add
			{
				get
				{
					return ref this._->add;
				}
			}

			// Token: 0x1700018F RID: 399
			// (get) Token: 0x060006BC RID: 1724 RVA: 0x0001D4F8 File Offset: 0x0001B6F8
			public unsafe ref Il2CppMethodInfo* Remove
			{
				get
				{
					return ref this._->remove;
				}
			}

			// Token: 0x17000190 RID: 400
			// (get) Token: 0x060006BD RID: 1725 RVA: 0x0001D50C File Offset: 0x0001B70C
			public unsafe ref Il2CppMethodInfo* Raise
			{
				get
				{
					return ref this._->raise;
				}
			}

			// Token: 0x060006BE RID: 1726 RVA: 0x0001D520 File Offset: 0x0001B720
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeEventInfoStructHandler_24_0.NativeStructWrapper.k9w1pvZBdxpgmE3IHnl();
			}

			// Token: 0x060006BF RID: 1727 RVA: 0x0001D530 File Offset: 0x0001B730
			internal static void KrcZeNZvK0hM3wgCqPp()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060006C0 RID: 1728 RVA: 0x0001D540 File Offset: 0x0001B740
			internal static bool qttd5VZXq33nDvF71KW()
			{
				return NativeEventInfoStructHandler_24_0.NativeStructWrapper.uiRHveZOad52FW3Lgfj == null;
			}

			// Token: 0x060006C1 RID: 1729 RVA: 0x0001D554 File Offset: 0x0001B754
			internal static NativeEventInfoStructHandler_24_0.NativeStructWrapper QEKrp5Zmp8F18E0dWSf()
			{
				return NativeEventInfoStructHandler_24_0.NativeStructWrapper.uiRHveZOad52FW3Lgfj;
			}

			// Token: 0x060006C2 RID: 1730 RVA: 0x0001D564 File Offset: 0x0001B764
			internal static void k9w1pvZBdxpgmE3IHnl()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x040002FF RID: 767
			private static object uiRHveZOad52FW3Lgfj;
		}
	}
}
