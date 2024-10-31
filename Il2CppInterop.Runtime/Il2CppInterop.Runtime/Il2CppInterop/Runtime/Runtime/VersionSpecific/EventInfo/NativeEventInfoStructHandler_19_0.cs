using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.EventInfo
{
	// Token: 0x020000B3 RID: 179
	[ApplicableToUnityVersionsSince("5.3.2")]
	public class NativeEventInfoStructHandler_19_0 : INativeEventInfoStructHandler, INativeStructHandler
	{
		// Token: 0x06000675 RID: 1653 RVA: 0x00010018 File Offset: 0x0000E218
		public int Size()
		{
			return sizeof(NativeEventInfoStructHandler_19_0.Il2CppEventInfo_19_0);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00010028 File Offset: 0x0000E228
		public unsafe INativeEventInfoStruct CreateNewStruct()
		{
			NativeEventInfoStructHandler_19_0.Il2CppEventInfo_19_0* ptr2;
			IntPtr ptr = ptr2 = NativeEventInfoStructHandler_19_0.slVxLpbeQdGAyaNsXjJ(this.Size());
			*ptr2 = default(NativeEventInfoStructHandler_19_0.Il2CppEventInfo_19_0);
			return new NativeEventInfoStructHandler_19_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00010058 File Offset: 0x0000E258
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7b01772eb8964b6a81d74c3d1c2f871e != 0)
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
			return new NativeEventInfoStructHandler_19_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000100C0 File Offset: 0x0000E2C0
		public NativeEventInfoStructHandler_19_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeEventInfoStructHandler_19_0.HEYHGsbK1F92wRd3ThV();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3566f8d0a0994626b4e9fd660bc94d73 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00010124 File Offset: 0x0000E324
		// Note: this type is marked as 'beforefieldinit'.
		static NativeEventInfoStructHandler_19_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00010134 File Offset: 0x0000E334
		internal static IntPtr slVxLpbeQdGAyaNsXjJ(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00010148 File Offset: 0x0000E348
		internal static bool IcSMYwbjR9ZvJ1jH7o0()
		{
			return NativeEventInfoStructHandler_19_0.H3mO2YbUFrJZhNAMSu9 == null;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0001015C File Offset: 0x0000E35C
		internal static NativeEventInfoStructHandler_19_0 ehPZqKbQNe1MX1NbU18()
		{
			return NativeEventInfoStructHandler_19_0.H3mO2YbUFrJZhNAMSu9;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0001016C File Offset: 0x0000E36C
		internal static void HEYHGsbK1F92wRd3ThV()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x040002E0 RID: 736
		internal static NativeEventInfoStructHandler_19_0 H3mO2YbUFrJZhNAMSu9;

		// Token: 0x020000B4 RID: 180
		internal struct Il2CppEventInfo_19_0
		{
			// Token: 0x040002E1 RID: 737
			public unsafe byte* name;

			// Token: 0x040002E2 RID: 738
			public unsafe Il2CppTypeStruct* eventType;

			// Token: 0x040002E3 RID: 739
			public unsafe Il2CppClass* parent;

			// Token: 0x040002E4 RID: 740
			public unsafe Il2CppMethodInfo* add;

			// Token: 0x040002E5 RID: 741
			public unsafe Il2CppMethodInfo* remove;

			// Token: 0x040002E6 RID: 742
			public unsafe Il2CppMethodInfo* raise;

			// Token: 0x040002E7 RID: 743
			public int customAttributeIndex;

			// Token: 0x040002E8 RID: 744
			public uint token;
		}

		// Token: 0x020000B5 RID: 181
		internal class NativeStructWrapper : INativeEventInfoStruct, INativeStruct
		{
			// Token: 0x0600067E RID: 1662 RVA: 0x0001C5EC File Offset: 0x0001A7EC
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeEventInfoStructHandler_19_0.NativeStructWrapper.DvxQIZDxm5foq0BH0xZ();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c975b252adfc48c4b262398638f90354 == 0)
				{
					num = 1;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						return;
					case 1:
						this.<Pointer>k__BackingField = ptr;
						num = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_11d7514559f14fcba52669ac71e3cb39 != 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x1700017F RID: 383
			// (get) Token: 0x0600067F RID: 1663 RVA: 0x0001C67C File Offset: 0x0001A87C
			private unsafe NativeEventInfoStructHandler_19_0.Il2CppEventInfo_19_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000180 RID: 384
			// (get) Token: 0x06000680 RID: 1664 RVA: 0x0001C68C File Offset: 0x0001A88C
			public IntPtr Pointer { get; }

			// Token: 0x17000181 RID: 385
			// (get) Token: 0x06000681 RID: 1665 RVA: 0x0001C69C File Offset: 0x0001A89C
			public unsafe Il2CppEventInfo* EventInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000182 RID: 386
			// (get) Token: 0x06000682 RID: 1666 RVA: 0x0001C6AC File Offset: 0x0001A8AC
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000183 RID: 387
			// (get) Token: 0x06000683 RID: 1667 RVA: 0x0001C6C4 File Offset: 0x0001A8C4
			public unsafe ref Il2CppTypeStruct* EventType
			{
				get
				{
					return ref this._->eventType;
				}
			}

			// Token: 0x17000184 RID: 388
			// (get) Token: 0x06000684 RID: 1668 RVA: 0x0001C6D8 File Offset: 0x0001A8D8
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000185 RID: 389
			// (get) Token: 0x06000685 RID: 1669 RVA: 0x0001C6EC File Offset: 0x0001A8EC
			public unsafe ref Il2CppMethodInfo* Add
			{
				get
				{
					return ref this._->add;
				}
			}

			// Token: 0x17000186 RID: 390
			// (get) Token: 0x06000686 RID: 1670 RVA: 0x0001C700 File Offset: 0x0001A900
			public unsafe ref Il2CppMethodInfo* Remove
			{
				get
				{
					return ref this._->remove;
				}
			}

			// Token: 0x17000187 RID: 391
			// (get) Token: 0x06000687 RID: 1671 RVA: 0x0001C714 File Offset: 0x0001A914
			public unsafe ref Il2CppMethodInfo* Raise
			{
				get
				{
					return ref this._->raise;
				}
			}

			// Token: 0x06000688 RID: 1672 RVA: 0x0001C728 File Offset: 0x0001A928
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeEventInfoStructHandler_19_0.NativeStructWrapper.IknBsLDYONBxogOM67n();
			}

			// Token: 0x06000689 RID: 1673 RVA: 0x0001C738 File Offset: 0x0001A938
			internal static void DvxQIZDxm5foq0BH0xZ()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600068A RID: 1674 RVA: 0x0001C748 File Offset: 0x0001A948
			internal static bool EeQQASDtQTUYUUgEBUF()
			{
				return NativeEventInfoStructHandler_19_0.NativeStructWrapper.gyXncODOu6rU0POgecF == null;
			}

			// Token: 0x0600068B RID: 1675 RVA: 0x0001C75C File Offset: 0x0001A95C
			internal static NativeEventInfoStructHandler_19_0.NativeStructWrapper kIQpHLDv7LqWZoOgtVd()
			{
				return NativeEventInfoStructHandler_19_0.NativeStructWrapper.gyXncODOu6rU0POgecF;
			}

			// Token: 0x0600068C RID: 1676 RVA: 0x0001C76C File Offset: 0x0001A96C
			internal static void IknBsLDYONBxogOM67n()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x040002EA RID: 746
			internal static object gyXncODOu6rU0POgecF;
		}
	}
}
