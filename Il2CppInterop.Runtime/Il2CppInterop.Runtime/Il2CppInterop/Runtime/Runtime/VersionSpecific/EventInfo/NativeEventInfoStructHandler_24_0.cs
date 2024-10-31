using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.EventInfo
{
	// Token: 0x020000B6 RID: 182
	[ApplicableToUnityVersionsSince("2018.3.0")]
	public class NativeEventInfoStructHandler_24_0 : INativeEventInfoStructHandler, INativeStructHandler
	{
		// Token: 0x0600068D RID: 1677 RVA: 0x0001017C File Offset: 0x0000E37C
		public int Size()
		{
			return sizeof(NativeEventInfoStructHandler_24_0.Il2CppEventInfo_24_0);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0001018C File Offset: 0x0000E38C
		public unsafe INativeEventInfoStruct CreateNewStruct()
		{
			NativeEventInfoStructHandler_24_0.Il2CppEventInfo_24_0* ptr2;
			IntPtr ptr = ptr2 = NativeEventInfoStructHandler_24_0.KVJpbT6lcF8txxUMpRj(this.Size());
			*ptr2 = default(NativeEventInfoStructHandler_24_0.Il2CppEventInfo_24_0);
			return new NativeEventInfoStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000101BC File Offset: 0x0000E3BC
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8378a46aa7ed47018832a42729b1bc3b == 0)
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

		// Token: 0x06000690 RID: 1680 RVA: 0x00010224 File Offset: 0x0000E424
		public NativeEventInfoStructHandler_24_0()
		{
			NativeEventInfoStructHandler_24_0.xr0rKJ6qOYPRDsQ4iSn();
			NativeEventInfoStructHandler_24_0.TL07Jw65eXh7HUfh9u8();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b5c96750853e4496814af588489331dc != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00010288 File Offset: 0x0000E488
		// Note: this type is marked as 'beforefieldinit'.
		static NativeEventInfoStructHandler_24_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00010298 File Offset: 0x0000E498
		internal static IntPtr KVJpbT6lcF8txxUMpRj(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x000102AC File Offset: 0x0000E4AC
		internal static bool dWKRiFbZulvn89ZI4pv()
		{
			return NativeEventInfoStructHandler_24_0.Krjfgjbal0tMbfDj3KY == null;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x000102C0 File Offset: 0x0000E4C0
		internal static NativeEventInfoStructHandler_24_0 oGHjjGbztDirwHuXOgI()
		{
			return NativeEventInfoStructHandler_24_0.Krjfgjbal0tMbfDj3KY;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x000102D0 File Offset: 0x0000E4D0
		internal static void xr0rKJ6qOYPRDsQ4iSn()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x000102E0 File Offset: 0x0000E4E0
		internal static void TL07Jw65eXh7HUfh9u8()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x040002EB RID: 747
		internal static NativeEventInfoStructHandler_24_0 Krjfgjbal0tMbfDj3KY;

		// Token: 0x020000B7 RID: 183
		internal struct Il2CppEventInfo_24_0
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
			public uint token;
		}

		// Token: 0x020000B8 RID: 184
		internal class NativeStructWrapper : INativeEventInfoStruct, INativeStruct
		{
			// Token: 0x06000697 RID: 1687 RVA: 0x0001C77C File Offset: 0x0001A97C
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeEventInfoStructHandler_24_0.NativeStructWrapper.MkoKhCDpSIaBDnqwixu();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_11d7514559f14fcba52669ac71e3cb39 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_dd9c757bd882429784d62f0e80f112e6 == 0)
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
			// (get) Token: 0x06000698 RID: 1688 RVA: 0x0001C80C File Offset: 0x0001AA0C
			private unsafe NativeEventInfoStructHandler_24_0.Il2CppEventInfo_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000189 RID: 393
			// (get) Token: 0x06000699 RID: 1689 RVA: 0x0001C81C File Offset: 0x0001AA1C
			public IntPtr Pointer { get; }

			// Token: 0x1700018A RID: 394
			// (get) Token: 0x0600069A RID: 1690 RVA: 0x0001C82C File Offset: 0x0001AA2C
			public unsafe Il2CppEventInfo* EventInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700018B RID: 395
			// (get) Token: 0x0600069B RID: 1691 RVA: 0x0001C83C File Offset: 0x0001AA3C
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x0600069C RID: 1692 RVA: 0x0001C854 File Offset: 0x0001AA54
			public unsafe ref Il2CppTypeStruct* EventType
			{
				get
				{
					return ref this._->eventType;
				}
			}

			// Token: 0x1700018D RID: 397
			// (get) Token: 0x0600069D RID: 1693 RVA: 0x0001C868 File Offset: 0x0001AA68
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700018E RID: 398
			// (get) Token: 0x0600069E RID: 1694 RVA: 0x0001C87C File Offset: 0x0001AA7C
			public unsafe ref Il2CppMethodInfo* Add
			{
				get
				{
					return ref this._->add;
				}
			}

			// Token: 0x1700018F RID: 399
			// (get) Token: 0x0600069F RID: 1695 RVA: 0x0001C890 File Offset: 0x0001AA90
			public unsafe ref Il2CppMethodInfo* Remove
			{
				get
				{
					return ref this._->remove;
				}
			}

			// Token: 0x17000190 RID: 400
			// (get) Token: 0x060006A0 RID: 1696 RVA: 0x0001C8A4 File Offset: 0x0001AAA4
			public unsafe ref Il2CppMethodInfo* Raise
			{
				get
				{
					return ref this._->raise;
				}
			}

			// Token: 0x060006A1 RID: 1697 RVA: 0x0001C8B8 File Offset: 0x0001AAB8
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeEventInfoStructHandler_24_0.NativeStructWrapper.QSfGpaDVTabbm9uU7Pk();
			}

			// Token: 0x060006A2 RID: 1698 RVA: 0x0001C8C8 File Offset: 0x0001AAC8
			internal static void MkoKhCDpSIaBDnqwixu()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x060006A3 RID: 1699 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
			internal static bool YJ7KcFDye2i9VKOVJht()
			{
				return NativeEventInfoStructHandler_24_0.NativeStructWrapper.PHNqWhD61tAM5aGOlTl == null;
			}

			// Token: 0x060006A4 RID: 1700 RVA: 0x0001C8EC File Offset: 0x0001AAEC
			internal static NativeEventInfoStructHandler_24_0.NativeStructWrapper oBsmGGDJCtUXYeeBLGC()
			{
				return NativeEventInfoStructHandler_24_0.NativeStructWrapper.PHNqWhD61tAM5aGOlTl;
			}

			// Token: 0x060006A5 RID: 1701 RVA: 0x0001C8FC File Offset: 0x0001AAFC
			internal static void QSfGpaDVTabbm9uU7Pk()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x040002F4 RID: 756
			private static object PHNqWhD61tAM5aGOlTl;
		}
	}
}
