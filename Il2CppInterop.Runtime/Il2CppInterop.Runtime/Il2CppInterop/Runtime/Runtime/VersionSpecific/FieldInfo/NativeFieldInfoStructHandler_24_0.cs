using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.FieldInfo
{
	// Token: 0x0200009A RID: 154
	[ApplicableToUnityVersionsSince("2018.3.0")]
	public class NativeFieldInfoStructHandler_24_0 : INativeFieldInfoStructHandler, INativeStructHandler
	{
		// Token: 0x060005B7 RID: 1463 RVA: 0x0000F604 File Offset: 0x0000D804
		public int Size()
		{
			return sizeof(NativeFieldInfoStructHandler_24_0.Il2CppFieldInfo_24_0);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0000F614 File Offset: 0x0000D814
		public unsafe INativeFieldInfoStruct CreateNewStruct()
		{
			NativeFieldInfoStructHandler_24_0.Il2CppFieldInfo_24_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeFieldInfoStructHandler_24_0.Il2CppFieldInfo_24_0);
			return new NativeFieldInfoStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0000F644 File Offset: 0x0000D844
		public unsafe INativeFieldInfoStruct Wrap(Il2CppFieldInfo* ptr)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8378a46aa7ed47018832a42729b1bc3b == 0)
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
			return new NativeFieldInfoStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0000F6AC File Offset: 0x0000D8AC
		public NativeFieldInfoStructHandler_24_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeFieldInfoStructHandler_24_0.XauQk3bLXO7ovXKO8Qh();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0299b24d936d41acaea60798c25b2a4b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0000F710 File Offset: 0x0000D910
		// Note: this type is marked as 'beforefieldinit'.
		static NativeFieldInfoStructHandler_24_0()
		{
			NativeFieldInfoStructHandler_24_0.gGR3xabXVGybUoQw8hI();
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0000F720 File Offset: 0x0000D920
		internal static bool tyIYBbb58KbDMpjUR8R()
		{
			return NativeFieldInfoStructHandler_24_0.cVtFEbbqTjNAuPUVgs7 == null;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0000F734 File Offset: 0x0000D934
		internal static NativeFieldInfoStructHandler_24_0 xRYMlcbAolZmSltUvZm()
		{
			return NativeFieldInfoStructHandler_24_0.cVtFEbbqTjNAuPUVgs7;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0000F744 File Offset: 0x0000D944
		internal static void XauQk3bLXO7ovXKO8Qh()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0000F754 File Offset: 0x0000D954
		internal static void gGR3xabXVGybUoQw8hI()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400027A RID: 634
		internal static NativeFieldInfoStructHandler_24_0 cVtFEbbqTjNAuPUVgs7;

		// Token: 0x0200009B RID: 155
		internal struct Il2CppFieldInfo_24_0
		{
			// Token: 0x0400027B RID: 635
			public unsafe byte* name;

			// Token: 0x0400027C RID: 636
			public unsafe Il2CppTypeStruct* type;

			// Token: 0x0400027D RID: 637
			public unsafe Il2CppClass* parent;

			// Token: 0x0400027E RID: 638
			public int offset;

			// Token: 0x0400027F RID: 639
			public uint token;
		}

		// Token: 0x0200009C RID: 156
		internal class NativeStructWrapper : INativeFieldInfoStruct, INativeStruct
		{
			// Token: 0x060005C0 RID: 1472 RVA: 0x0001BB10 File Offset: 0x00019D10
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeFieldInfoStructHandler_24_0.NativeStructWrapper.jWoHJ3ubQwKAgIs1RUi();
				NativeFieldInfoStructHandler_24_0.NativeStructWrapper.PQ6gdRu66xGKpSFmrlY();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_911808c58d664adeb7c16d1e3a32f7fa == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2adb3ca441e493aba80425bcc0f1db3 == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0001BBA0 File Offset: 0x00019DA0
			private unsafe NativeFieldInfoStructHandler_24_0.Il2CppFieldInfo_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0001BBB0 File Offset: 0x00019DB0
			public IntPtr Pointer { get; }

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0001BBC0 File Offset: 0x00019DC0
			public unsafe Il2CppFieldInfo* FieldInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0001BBD0 File Offset: 0x00019DD0
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0001BBE8 File Offset: 0x00019DE8
			public unsafe ref Il2CppTypeStruct* Type
			{
				get
				{
					return ref this._->type;
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x060005C6 RID: 1478 RVA: 0x0001BBFC File Offset: 0x00019DFC
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x060005C7 RID: 1479 RVA: 0x0001BC10 File Offset: 0x00019E10
			public unsafe ref int Offset
			{
				get
				{
					return ref this._->offset;
				}
			}

			// Token: 0x060005C8 RID: 1480 RVA: 0x0001BC24 File Offset: 0x00019E24
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeFieldInfoStructHandler_24_0.NativeStructWrapper.fGjeLLuyHp8kGDWd539();
			}

			// Token: 0x060005C9 RID: 1481 RVA: 0x0001BC34 File Offset: 0x00019E34
			internal static void jWoHJ3ubQwKAgIs1RUi()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060005CA RID: 1482 RVA: 0x0001BC44 File Offset: 0x00019E44
			internal static void PQ6gdRu66xGKpSFmrlY()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x060005CB RID: 1483 RVA: 0x0001BC54 File Offset: 0x00019E54
			internal static bool ywWlwHu8uHGwqmLdCIU()
			{
				return NativeFieldInfoStructHandler_24_0.NativeStructWrapper.ClT9aVuYYPmqsrmrVmm == null;
			}

			// Token: 0x060005CC RID: 1484 RVA: 0x0001BC68 File Offset: 0x00019E68
			internal static NativeFieldInfoStructHandler_24_0.NativeStructWrapper HkpPQkun3KhyGHfnbll()
			{
				return NativeFieldInfoStructHandler_24_0.NativeStructWrapper.ClT9aVuYYPmqsrmrVmm;
			}

			// Token: 0x060005CD RID: 1485 RVA: 0x0001BC78 File Offset: 0x00019E78
			internal static void fGjeLLuyHp8kGDWd539()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000281 RID: 641
			internal static object ClT9aVuYYPmqsrmrVmm;
		}
	}
}
