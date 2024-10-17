using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.EventInfo
{
	// Token: 0x020000B2 RID: 178
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeEventInfoStructHandler_16_0 : INativeEventInfoStructHandler, INativeStructHandler
	{
		// Token: 0x06000676 RID: 1654 RVA: 0x00010AB4 File Offset: 0x0000ECB4
		public int Size()
		{
			return sizeof(NativeEventInfoStructHandler_16_0.Il2CppEventInfo_16_0);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00010AC4 File Offset: 0x0000ECC4
		public unsafe INativeEventInfoStruct CreateNewStruct()
		{
			NativeEventInfoStructHandler_16_0.Il2CppEventInfo_16_0* ptr2;
			IntPtr ptr = ptr2 = NativeEventInfoStructHandler_16_0.vQI9ZmcGnF9E7jA43AB(this.Size());
			*ptr2 = default(NativeEventInfoStructHandler_16_0.Il2CppEventInfo_16_0);
			return new NativeEventInfoStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00010AF4 File Offset: 0x0000ECF4
		public unsafe INativeEventInfoStruct Wrap(Il2CppEventInfo* ptr)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_330a825ae0544050af4112bb9a37f6bb != 0)
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
			return new NativeEventInfoStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00010B5C File Offset: 0x0000ED5C
		public NativeEventInfoStructHandler_16_0()
		{
			NativeEventInfoStructHandler_16_0.WwVlsrcYOxnsVwWWlj8();
			NativeEventInfoStructHandler_16_0.n79d8wcaSns1icjYDBy();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c23fbb8072754781976c5c809c25ef15 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00010BC0 File Offset: 0x0000EDC0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeEventInfoStructHandler_16_0()
		{
			NativeEventInfoStructHandler_16_0.iXVWuucC0IkqrlXGcO6();
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00010BD0 File Offset: 0x0000EDD0
		internal static IntPtr vQI9ZmcGnF9E7jA43AB(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00010BE4 File Offset: 0x0000EDE4
		internal static bool SFf6PPcikTkf0YGwWv6()
		{
			return NativeEventInfoStructHandler_16_0.uTaGcZc9IPIGPSrawfl == null;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00010BF8 File Offset: 0x0000EDF8
		internal static NativeEventInfoStructHandler_16_0 wgeLhbcIkWrnEv9l7O9()
		{
			return NativeEventInfoStructHandler_16_0.uTaGcZc9IPIGPSrawfl;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00010C08 File Offset: 0x0000EE08
		internal static void WwVlsrcYOxnsVwWWlj8()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00010C18 File Offset: 0x0000EE18
		internal static void n79d8wcaSns1icjYDBy()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00010C28 File Offset: 0x0000EE28
		internal static void iXVWuucC0IkqrlXGcO6()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040002E1 RID: 737
		internal static NativeEventInfoStructHandler_16_0 uTaGcZc9IPIGPSrawfl;

		// Token: 0x020000B3 RID: 179
		internal struct Il2CppEventInfo_16_0
		{
			// Token: 0x040002E2 RID: 738
			public unsafe byte* name;

			// Token: 0x040002E3 RID: 739
			public unsafe Il2CppTypeStruct* eventType;

			// Token: 0x040002E4 RID: 740
			public unsafe Il2CppClass* parent;

			// Token: 0x040002E5 RID: 741
			public unsafe Il2CppMethodInfo* add;

			// Token: 0x040002E6 RID: 742
			public unsafe Il2CppMethodInfo* remove;

			// Token: 0x040002E7 RID: 743
			public unsafe Il2CppMethodInfo* raise;

			// Token: 0x040002E8 RID: 744
			public int customAttributeIndex;
		}

		// Token: 0x020000B4 RID: 180
		internal class NativeStructWrapper : INativeEventInfoStruct, INativeStruct
		{
			// Token: 0x06000681 RID: 1665 RVA: 0x0001D0C4 File Offset: 0x0001B2C4
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeEventInfoStructHandler_16_0.NativeStructWrapper.s1X85HZfW8W0n0bfef4();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c474f43efb4d4f17b5c0c1bf3216ef4d == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c474f43efb4d4f17b5c0c1bf3216ef4d == 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x17000176 RID: 374
			// (get) Token: 0x06000682 RID: 1666 RVA: 0x0001D154 File Offset: 0x0001B354
			private unsafe NativeEventInfoStructHandler_16_0.Il2CppEventInfo_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x06000683 RID: 1667 RVA: 0x0001D164 File Offset: 0x0001B364
			public IntPtr Pointer { get; }

			// Token: 0x17000178 RID: 376
			// (get) Token: 0x06000684 RID: 1668 RVA: 0x0001D174 File Offset: 0x0001B374
			public unsafe Il2CppEventInfo* EventInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000179 RID: 377
			// (get) Token: 0x06000685 RID: 1669 RVA: 0x0001D184 File Offset: 0x0001B384
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700017A RID: 378
			// (get) Token: 0x06000686 RID: 1670 RVA: 0x0001D19C File Offset: 0x0001B39C
			public unsafe ref Il2CppTypeStruct* EventType
			{
				get
				{
					return ref this._->eventType;
				}
			}

			// Token: 0x1700017B RID: 379
			// (get) Token: 0x06000687 RID: 1671 RVA: 0x0001D1B0 File Offset: 0x0001B3B0
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700017C RID: 380
			// (get) Token: 0x06000688 RID: 1672 RVA: 0x0001D1C4 File Offset: 0x0001B3C4
			public unsafe ref Il2CppMethodInfo* Add
			{
				get
				{
					return ref this._->add;
				}
			}

			// Token: 0x1700017D RID: 381
			// (get) Token: 0x06000689 RID: 1673 RVA: 0x0001D1D8 File Offset: 0x0001B3D8
			public unsafe ref Il2CppMethodInfo* Remove
			{
				get
				{
					return ref this._->remove;
				}
			}

			// Token: 0x1700017E RID: 382
			// (get) Token: 0x0600068A RID: 1674 RVA: 0x0001D1EC File Offset: 0x0001B3EC
			public unsafe ref Il2CppMethodInfo* Raise
			{
				get
				{
					return ref this._->raise;
				}
			}

			// Token: 0x0600068B RID: 1675 RVA: 0x0001D200 File Offset: 0x0001B400
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeEventInfoStructHandler_16_0.NativeStructWrapper.mI9XTvZPrx1BHyrvuwd();
			}

			// Token: 0x0600068C RID: 1676 RVA: 0x0001D210 File Offset: 0x0001B410
			internal static void s1X85HZfW8W0n0bfef4()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600068D RID: 1677 RVA: 0x0001D220 File Offset: 0x0001B420
			internal static bool eOd8QIZoWDjBSqVBjkl()
			{
				return NativeEventInfoStructHandler_16_0.NativeStructWrapper.milMUpZZmjVSskh7g2J == null;
			}

			// Token: 0x0600068E RID: 1678 RVA: 0x0001D234 File Offset: 0x0001B434
			internal static NativeEventInfoStructHandler_16_0.NativeStructWrapper N6W51TZbTvoitmZEo2n()
			{
				return NativeEventInfoStructHandler_16_0.NativeStructWrapper.milMUpZZmjVSskh7g2J;
			}

			// Token: 0x0600068F RID: 1679 RVA: 0x0001D244 File Offset: 0x0001B444
			internal static void mI9XTvZPrx1BHyrvuwd()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x040002EA RID: 746
			private static object milMUpZZmjVSskh7g2J;
		}
	}
}
