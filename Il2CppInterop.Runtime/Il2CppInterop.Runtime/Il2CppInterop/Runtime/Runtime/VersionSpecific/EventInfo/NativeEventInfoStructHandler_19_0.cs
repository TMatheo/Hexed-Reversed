using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.EventInfo
{
	// Token: 0x020000B5 RID: 181
	[ApplicableToUnityVersionsSince("5.3.2")]
	public class NativeEventInfoStructHandler_19_0 : INativeEventInfoStructHandler, INativeStructHandler
	{
		// Token: 0x06000690 RID: 1680 RVA: 0x00010C38 File Offset: 0x0000EE38
		public int Size()
		{
			return sizeof(NativeEventInfoStructHandler_19_0.Il2CppEventInfo_19_0);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00010C48 File Offset: 0x0000EE48
		public unsafe INativeEventInfoStruct CreateNewStruct()
		{
			NativeEventInfoStructHandler_19_0.Il2CppEventInfo_19_0* ptr2;
			IntPtr ptr = ptr2 = NativeEventInfoStructHandler_19_0.nFCw1qc8h7YwyNW0diX(this.Size());
			*ptr2 = default(NativeEventInfoStructHandler_19_0.Il2CppEventInfo_19_0);
			return new NativeEventInfoStructHandler_19_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00010C78 File Offset: 0x0000EE78
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeEventInfoStructHandler_19_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00010CE0 File Offset: 0x0000EEE0
		public NativeEventInfoStructHandler_19_0()
		{
			NativeEventInfoStructHandler_19_0.YieygSc01K130pYxGBD();
			NativeEventInfoStructHandler_19_0.kbrlFbcNyQyjG5cH9H9();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3cdc0c80f3644c499e0bcd7810be1cee == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00010D44 File Offset: 0x0000EF44
		// Note: this type is marked as 'beforefieldinit'.
		static NativeEventInfoStructHandler_19_0()
		{
			NativeEventInfoStructHandler_19_0.feldPScupNmgRLlKH7t();
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00010D54 File Offset: 0x0000EF54
		internal static IntPtr nFCw1qc8h7YwyNW0diX(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00010D68 File Offset: 0x0000EF68
		internal static bool eBPlsBcxwwGYIN2P6go()
		{
			return NativeEventInfoStructHandler_19_0.sS3nL8ct9qA7i2LXyjY == null;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00010D7C File Offset: 0x0000EF7C
		internal static NativeEventInfoStructHandler_19_0 fauwFGchMXK7xl9oh8A()
		{
			return NativeEventInfoStructHandler_19_0.sS3nL8ct9qA7i2LXyjY;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00010D8C File Offset: 0x0000EF8C
		internal static void YieygSc01K130pYxGBD()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00010D9C File Offset: 0x0000EF9C
		internal static void kbrlFbcNyQyjG5cH9H9()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00010DAC File Offset: 0x0000EFAC
		internal static void feldPScupNmgRLlKH7t()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040002EB RID: 747
		internal static NativeEventInfoStructHandler_19_0 sS3nL8ct9qA7i2LXyjY;

		// Token: 0x020000B6 RID: 182
		internal struct Il2CppEventInfo_19_0
		{
			// Token: 0x040002EC RID: 748
			public unsafe byte* name;

			// Token: 0x040002ED RID: 749
			public unsafe Il2CppTypeStruct* eventType;

			// Token: 0x040002EE RID: 750
			public unsafe Il2CppClass* parent;

			// Token: 0x040002EF RID: 751
			public unsafe Il2CppMethodInfo* add;

			// Token: 0x040002F0 RID: 752
			public unsafe Il2CppMethodInfo* remove;

			// Token: 0x040002F1 RID: 753
			public unsafe Il2CppMethodInfo* raise;

			// Token: 0x040002F2 RID: 754
			public int customAttributeIndex;

			// Token: 0x040002F3 RID: 755
			public uint token;
		}

		// Token: 0x020000B7 RID: 183
		internal class NativeStructWrapper : INativeEventInfoStruct, INativeStruct
		{
			// Token: 0x0600069B RID: 1691 RVA: 0x0001D254 File Offset: 0x0001B454
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeEventInfoStructHandler_19_0.NativeStructWrapper.EcVNDsZysVqE8VAlxhe();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9cbee6d56f49422699718938ff979567 != 0)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_74d61b1611df4615bd4df289712ea178 == 0)
					{
						num = 0;
					}
				}
			}

			// Token: 0x1700017F RID: 383
			// (get) Token: 0x0600069C RID: 1692 RVA: 0x0001D2E4 File Offset: 0x0001B4E4
			private unsafe NativeEventInfoStructHandler_19_0.Il2CppEventInfo_19_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000180 RID: 384
			// (get) Token: 0x0600069D RID: 1693 RVA: 0x0001D2F4 File Offset: 0x0001B4F4
			public IntPtr Pointer { get; }

			// Token: 0x17000181 RID: 385
			// (get) Token: 0x0600069E RID: 1694 RVA: 0x0001D304 File Offset: 0x0001B504
			public unsafe Il2CppEventInfo* EventInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000182 RID: 386
			// (get) Token: 0x0600069F RID: 1695 RVA: 0x0001D314 File Offset: 0x0001B514
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000183 RID: 387
			// (get) Token: 0x060006A0 RID: 1696 RVA: 0x0001D32C File Offset: 0x0001B52C
			public unsafe ref Il2CppTypeStruct* EventType
			{
				get
				{
					return ref this._->eventType;
				}
			}

			// Token: 0x17000184 RID: 388
			// (get) Token: 0x060006A1 RID: 1697 RVA: 0x0001D340 File Offset: 0x0001B540
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000185 RID: 389
			// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0001D354 File Offset: 0x0001B554
			public unsafe ref Il2CppMethodInfo* Add
			{
				get
				{
					return ref this._->add;
				}
			}

			// Token: 0x17000186 RID: 390
			// (get) Token: 0x060006A3 RID: 1699 RVA: 0x0001D368 File Offset: 0x0001B568
			public unsafe ref Il2CppMethodInfo* Remove
			{
				get
				{
					return ref this._->remove;
				}
			}

			// Token: 0x17000187 RID: 391
			// (get) Token: 0x060006A4 RID: 1700 RVA: 0x0001D37C File Offset: 0x0001B57C
			public unsafe ref Il2CppMethodInfo* Raise
			{
				get
				{
					return ref this._->raise;
				}
			}

			// Token: 0x060006A5 RID: 1701 RVA: 0x0001D390 File Offset: 0x0001B590
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeEventInfoStructHandler_19_0.NativeStructWrapper.zaq89oZSBwCCUpvdAeF();
			}

			// Token: 0x060006A6 RID: 1702 RVA: 0x0001D3A0 File Offset: 0x0001B5A0
			internal static void EcVNDsZysVqE8VAlxhe()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x060006A7 RID: 1703 RVA: 0x0001D3B0 File Offset: 0x0001B5B0
			internal static bool TJUBvCZQFi6ODK6Kq6m()
			{
				return NativeEventInfoStructHandler_19_0.NativeStructWrapper.lXPjFiZsY7QJcQWSJqy == null;
			}

			// Token: 0x060006A8 RID: 1704 RVA: 0x0001D3C4 File Offset: 0x0001B5C4
			internal static NativeEventInfoStructHandler_19_0.NativeStructWrapper GLRaNfZ2LnaJkGGf6Ns()
			{
				return NativeEventInfoStructHandler_19_0.NativeStructWrapper.lXPjFiZsY7QJcQWSJqy;
			}

			// Token: 0x060006A9 RID: 1705 RVA: 0x0001D3D4 File Offset: 0x0001B5D4
			internal static void zaq89oZSBwCCUpvdAeF()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x040002F5 RID: 757
			private static object lXPjFiZsY7QJcQWSJqy;
		}
	}
}
