using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.FieldInfo
{
	// Token: 0x02000099 RID: 153
	[ApplicableToUnityVersionsSince("5.3.2")]
	public class NativeFieldInfoStructHandler_19_0 : INativeFieldInfoStructHandler, INativeStructHandler
	{
		// Token: 0x060005B7 RID: 1463 RVA: 0x00010080 File Offset: 0x0000E280
		public int Size()
		{
			return sizeof(NativeFieldInfoStructHandler_19_0.Il2CppFieldInfo_19_0);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00010090 File Offset: 0x0000E290
		public unsafe INativeFieldInfoStruct CreateNewStruct()
		{
			NativeFieldInfoStructHandler_19_0.Il2CppFieldInfo_19_0* ptr2;
			IntPtr ptr = ptr2 = NativeFieldInfoStructHandler_19_0.t9VTYRE8pTkQSYgOoCO(this.Size());
			*ptr2 = default(NativeFieldInfoStructHandler_19_0.Il2CppFieldInfo_19_0);
			return new NativeFieldInfoStructHandler_19_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000100C0 File Offset: 0x0000E2C0
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2210d7ca22c24335b32d80ca3ef84b8e == 0)
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
			return new NativeFieldInfoStructHandler_19_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00010128 File Offset: 0x0000E328
		public NativeFieldInfoStructHandler_19_0()
		{
			NativeFieldInfoStructHandler_19_0.A8ebSuE0TmhjYKwD1as();
			NativeFieldInfoStructHandler_19_0.gxYyjwENnemXlMpuR4r();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_afe904a262fb47328a49943b4b34b494 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0001018C File Offset: 0x0000E38C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeFieldInfoStructHandler_19_0()
		{
			NativeFieldInfoStructHandler_19_0.DN9dk6EuCc30AHVnmeH();
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0001019C File Offset: 0x0000E39C
		internal static IntPtr t9VTYRE8pTkQSYgOoCO(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x000101B0 File Offset: 0x0000E3B0
		internal static bool QHWGg4ExhZJ5616eY2V()
		{
			return NativeFieldInfoStructHandler_19_0.D1gwBREtDKKt3g8NsWV == null;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000101C4 File Offset: 0x0000E3C4
		internal static NativeFieldInfoStructHandler_19_0 sc0caHEhKnX4uYQbuVo()
		{
			return NativeFieldInfoStructHandler_19_0.D1gwBREtDKKt3g8NsWV;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x000101D4 File Offset: 0x0000E3D4
		internal static void A8ebSuE0TmhjYKwD1as()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x000101E4 File Offset: 0x0000E3E4
		internal static void gxYyjwENnemXlMpuR4r()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x000101F4 File Offset: 0x0000E3F4
		internal static void DN9dk6EuCc30AHVnmeH()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400027C RID: 636
		internal static NativeFieldInfoStructHandler_19_0 D1gwBREtDKKt3g8NsWV;

		// Token: 0x0200009A RID: 154
		internal struct Il2CppFieldInfo_19_0
		{
			// Token: 0x0400027D RID: 637
			public unsafe byte* name;

			// Token: 0x0400027E RID: 638
			public unsafe Il2CppTypeStruct* type;

			// Token: 0x0400027F RID: 639
			public unsafe Il2CppClass* parent;

			// Token: 0x04000280 RID: 640
			public int offset;

			// Token: 0x04000281 RID: 641
			public int customAttributeIndex;

			// Token: 0x04000282 RID: 642
			public uint token;
		}

		// Token: 0x0200009B RID: 155
		internal class NativeStructWrapper : INativeFieldInfoStruct, INativeStruct
		{
			// Token: 0x060005C2 RID: 1474 RVA: 0x0001C600 File Offset: 0x0001A800
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeFieldInfoStructHandler_19_0.NativeStructWrapper.FASNXNDwYXBagHTKb0H();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_570d4e075bf443fcbaca8db32e007291 != 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5c4dec7c475342669cbf3c1205f935ba == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0001C690 File Offset: 0x0001A890
			private unsafe NativeFieldInfoStructHandler_19_0.Il2CppFieldInfo_19_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0001C6A0 File Offset: 0x0001A8A0
			public IntPtr Pointer { get; }

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0001C6B0 File Offset: 0x0001A8B0
			public unsafe Il2CppFieldInfo* FieldInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x060005C6 RID: 1478 RVA: 0x0001C6C0 File Offset: 0x0001A8C0
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x060005C7 RID: 1479 RVA: 0x0001C6D8 File Offset: 0x0001A8D8
			public unsafe ref Il2CppTypeStruct* Type
			{
				get
				{
					return ref this._->type;
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x060005C8 RID: 1480 RVA: 0x0001C6EC File Offset: 0x0001A8EC
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0001C700 File Offset: 0x0001A900
			public unsafe ref int Offset
			{
				get
				{
					return ref this._->offset;
				}
			}

			// Token: 0x060005CA RID: 1482 RVA: 0x0001C714 File Offset: 0x0001A914
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeFieldInfoStructHandler_19_0.NativeStructWrapper.Bpd8kCDeeDSgHmZ5jnA();
			}

			// Token: 0x060005CB RID: 1483 RVA: 0x0001C724 File Offset: 0x0001A924
			internal static void FASNXNDwYXBagHTKb0H()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060005CC RID: 1484 RVA: 0x0001C734 File Offset: 0x0001A934
			internal static bool VAt3B0DPkta26UOSDkI()
			{
				return NativeFieldInfoStructHandler_19_0.NativeStructWrapper.j1Z5c2Df0KCH7GgsYRa == null;
			}

			// Token: 0x060005CD RID: 1485 RVA: 0x0001C748 File Offset: 0x0001A948
			internal static NativeFieldInfoStructHandler_19_0.NativeStructWrapper A2ZQcbDdhtHw6mMTd1p()
			{
				return NativeFieldInfoStructHandler_19_0.NativeStructWrapper.j1Z5c2Df0KCH7GgsYRa;
			}

			// Token: 0x060005CE RID: 1486 RVA: 0x0001C758 File Offset: 0x0001A958
			internal static void Bpd8kCDeeDSgHmZ5jnA()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000284 RID: 644
			private static object j1Z5c2Df0KCH7GgsYRa;
		}
	}
}
