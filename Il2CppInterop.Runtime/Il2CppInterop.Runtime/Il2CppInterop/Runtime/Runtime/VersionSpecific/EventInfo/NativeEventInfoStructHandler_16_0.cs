using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.EventInfo
{
	// Token: 0x020000B0 RID: 176
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeEventInfoStructHandler_16_0 : INativeEventInfoStructHandler, INativeStructHandler
	{
		// Token: 0x0600065B RID: 1627 RVA: 0x0000FE94 File Offset: 0x0000E094
		public int Size()
		{
			return sizeof(NativeEventInfoStructHandler_16_0.Il2CppEventInfo_16_0);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0000FEA4 File Offset: 0x0000E0A4
		public unsafe INativeEventInfoStruct CreateNewStruct()
		{
			NativeEventInfoStructHandler_16_0.Il2CppEventInfo_16_0* ptr2;
			IntPtr ptr = ptr2 = NativeEventInfoStructHandler_16_0.LSqCiJbrEmnp1ogyqrn(this.Size());
			*ptr2 = default(NativeEventInfoStructHandler_16_0.Il2CppEventInfo_16_0);
			return new NativeEventInfoStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0000FED4 File Offset: 0x0000E0D4
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
			return new NativeEventInfoStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0000FF3C File Offset: 0x0000E13C
		public NativeEventInfoStructHandler_16_0()
		{
			NativeEventInfoStructHandler_16_0.Q0n2DVbTNnJWr7AOneb();
			NativeEventInfoStructHandler_16_0.KZgopQbgcTgV6aKlBvs();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7dfb1d10537744ca9e949b6b3a3eac09 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0000FFA0 File Offset: 0x0000E1A0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeEventInfoStructHandler_16_0()
		{
			NativeEventInfoStructHandler_16_0.uVbZM1botaQ9tQvQnnS();
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0000FFB0 File Offset: 0x0000E1B0
		internal static IntPtr LSqCiJbrEmnp1ogyqrn(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0000FFC4 File Offset: 0x0000E1C4
		internal static bool pHZkbZbBeB5f2fOEOwG()
		{
			return NativeEventInfoStructHandler_16_0.sLLvw0bEVbGo2yjWQIc == null;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		internal static NativeEventInfoStructHandler_16_0 NS0Dv4bGtwxocdXIc2R()
		{
			return NativeEventInfoStructHandler_16_0.sLLvw0bEVbGo2yjWQIc;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0000FFE8 File Offset: 0x0000E1E8
		internal static void Q0n2DVbTNnJWr7AOneb()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0000FFF8 File Offset: 0x0000E1F8
		internal static void KZgopQbgcTgV6aKlBvs()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00010008 File Offset: 0x0000E208
		internal static void uVbZM1botaQ9tQvQnnS()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040002D6 RID: 726
		internal static NativeEventInfoStructHandler_16_0 sLLvw0bEVbGo2yjWQIc;

		// Token: 0x020000B1 RID: 177
		internal struct Il2CppEventInfo_16_0
		{
			// Token: 0x040002D7 RID: 727
			public unsafe byte* name;

			// Token: 0x040002D8 RID: 728
			public unsafe Il2CppTypeStruct* eventType;

			// Token: 0x040002D9 RID: 729
			public unsafe Il2CppClass* parent;

			// Token: 0x040002DA RID: 730
			public unsafe Il2CppMethodInfo* add;

			// Token: 0x040002DB RID: 731
			public unsafe Il2CppMethodInfo* remove;

			// Token: 0x040002DC RID: 732
			public unsafe Il2CppMethodInfo* raise;

			// Token: 0x040002DD RID: 733
			public int customAttributeIndex;
		}

		// Token: 0x020000B2 RID: 178
		internal class NativeStructWrapper : INativeEventInfoStruct, INativeStruct
		{
			// Token: 0x06000666 RID: 1638 RVA: 0x0001C45C File Offset: 0x0001A65C
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeEventInfoStructHandler_16_0.NativeStructWrapper.DuQyLeDc6q0HyppktXo();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cfadd7e02c524ea298356b7415bd67b6 != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b3f20ce588d04b909ddcdcdf767eb5d4 != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x17000176 RID: 374
			// (get) Token: 0x06000667 RID: 1639 RVA: 0x0001C4EC File Offset: 0x0001A6EC
			private unsafe NativeEventInfoStructHandler_16_0.Il2CppEventInfo_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000177 RID: 375
			// (get) Token: 0x06000668 RID: 1640 RVA: 0x0001C4FC File Offset: 0x0001A6FC
			public IntPtr Pointer { get; }

			// Token: 0x17000178 RID: 376
			// (get) Token: 0x06000669 RID: 1641 RVA: 0x0001C50C File Offset: 0x0001A70C
			public unsafe Il2CppEventInfo* EventInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000179 RID: 377
			// (get) Token: 0x0600066A RID: 1642 RVA: 0x0001C51C File Offset: 0x0001A71C
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700017A RID: 378
			// (get) Token: 0x0600066B RID: 1643 RVA: 0x0001C534 File Offset: 0x0001A734
			public unsafe ref Il2CppTypeStruct* EventType
			{
				get
				{
					return ref this._->eventType;
				}
			}

			// Token: 0x1700017B RID: 379
			// (get) Token: 0x0600066C RID: 1644 RVA: 0x0001C548 File Offset: 0x0001A748
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700017C RID: 380
			// (get) Token: 0x0600066D RID: 1645 RVA: 0x0001C55C File Offset: 0x0001A75C
			public unsafe ref Il2CppMethodInfo* Add
			{
				get
				{
					return ref this._->add;
				}
			}

			// Token: 0x1700017D RID: 381
			// (get) Token: 0x0600066E RID: 1646 RVA: 0x0001C570 File Offset: 0x0001A770
			public unsafe ref Il2CppMethodInfo* Remove
			{
				get
				{
					return ref this._->remove;
				}
			}

			// Token: 0x1700017E RID: 382
			// (get) Token: 0x0600066F RID: 1647 RVA: 0x0001C584 File Offset: 0x0001A784
			public unsafe ref Il2CppMethodInfo* Raise
			{
				get
				{
					return ref this._->raise;
				}
			}

			// Token: 0x06000670 RID: 1648 RVA: 0x0001C598 File Offset: 0x0001A798
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeEventInfoStructHandler_16_0.NativeStructWrapper.gcnTK9DkYhDX0k2fEiV();
			}

			// Token: 0x06000671 RID: 1649 RVA: 0x0001C5A8 File Offset: 0x0001A7A8
			internal static void DuQyLeDc6q0HyppktXo()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000672 RID: 1650 RVA: 0x0001C5B8 File Offset: 0x0001A7B8
			internal static bool TJst0IDLkNXq99FK0xl()
			{
				return NativeEventInfoStructHandler_16_0.NativeStructWrapper.F3obAKDA6weKm5TGhBp == null;
			}

			// Token: 0x06000673 RID: 1651 RVA: 0x0001C5CC File Offset: 0x0001A7CC
			internal static NativeEventInfoStructHandler_16_0.NativeStructWrapper kQhJ1CDX95MyEuZsWkN()
			{
				return NativeEventInfoStructHandler_16_0.NativeStructWrapper.F3obAKDA6weKm5TGhBp;
			}

			// Token: 0x06000674 RID: 1652 RVA: 0x0001C5DC File Offset: 0x0001A7DC
			internal static void gcnTK9DkYhDX0k2fEiV()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x040002DF RID: 735
			private static object F3obAKDA6weKm5TGhBp;
		}
	}
}
