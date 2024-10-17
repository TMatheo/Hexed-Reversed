using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.FieldInfo
{
	// Token: 0x02000096 RID: 150
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeFieldInfoStructHandler_16_0 : INativeFieldInfoStructHandler, INativeStructHandler
	{
		// Token: 0x060005A2 RID: 1442 RVA: 0x0000FF30 File Offset: 0x0000E130
		public int Size()
		{
			return sizeof(NativeFieldInfoStructHandler_16_0.Il2CppFieldInfo_16_0);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0000FF40 File Offset: 0x0000E140
		public unsafe INativeFieldInfoStruct CreateNewStruct()
		{
			NativeFieldInfoStructHandler_16_0.Il2CppFieldInfo_16_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeFieldInfoStructHandler_16_0.Il2CppFieldInfo_16_0);
			return new NativeFieldInfoStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0000FF70 File Offset: 0x0000E170
		public unsafe INativeFieldInfoStruct Wrap(Il2CppFieldInfo* ptr)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_650e65d7606047fda7d187c401bdfc6e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeFieldInfoStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		public NativeFieldInfoStructHandler_16_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeFieldInfoStructHandler_16_0.hZ2U2aECJZFX2DE1XDH();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8155e7a9a9bd4894b741e1951a0eace6 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0001003C File Offset: 0x0000E23C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeFieldInfoStructHandler_16_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0001004C File Offset: 0x0000E24C
		internal static bool AMMlqTEYVRe2vHBEJIr()
		{
			return NativeFieldInfoStructHandler_16_0.eORjIDEGTSJau51wNoJ == null;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00010060 File Offset: 0x0000E260
		internal static NativeFieldInfoStructHandler_16_0 RrGxmWEaT6pI4bU41Xk()
		{
			return NativeFieldInfoStructHandler_16_0.eORjIDEGTSJau51wNoJ;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00010070 File Offset: 0x0000E270
		internal static void hZ2U2aECJZFX2DE1XDH()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x04000274 RID: 628
		private static NativeFieldInfoStructHandler_16_0 eORjIDEGTSJau51wNoJ;

		// Token: 0x02000097 RID: 151
		internal struct Il2CppFieldInfo_16_0
		{
			// Token: 0x04000275 RID: 629
			public unsafe byte* name;

			// Token: 0x04000276 RID: 630
			public unsafe Il2CppTypeStruct* type;

			// Token: 0x04000277 RID: 631
			public unsafe Il2CppClass* parent;

			// Token: 0x04000278 RID: 632
			public int offset;

			// Token: 0x04000279 RID: 633
			public int customAttributeIndex;
		}

		// Token: 0x02000098 RID: 152
		internal class NativeStructWrapper : INativeFieldInfoStruct, INativeStruct
		{
			// Token: 0x060005AA RID: 1450 RVA: 0x0001C498 File Offset: 0x0001A698
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeFieldInfoStructHandler_16_0.NativeStructWrapper.jm57tLDrP9NB3y5Y3SN();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_18558c8f0d4f4774910664df1c51bd49 == 0)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b8a2996bc299402b995470e3e8286d42 == 0)
					{
						num = 0;
					}
				}
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x060005AB RID: 1451 RVA: 0x0001C528 File Offset: 0x0001A728
			private unsafe NativeFieldInfoStructHandler_16_0.Il2CppFieldInfo_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x060005AC RID: 1452 RVA: 0x0001C538 File Offset: 0x0001A738
			public IntPtr Pointer { get; }

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x060005AD RID: 1453 RVA: 0x0001C548 File Offset: 0x0001A748
			public unsafe Il2CppFieldInfo* FieldInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x060005AE RID: 1454 RVA: 0x0001C558 File Offset: 0x0001A758
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x060005AF RID: 1455 RVA: 0x0001C570 File Offset: 0x0001A770
			public unsafe ref Il2CppTypeStruct* Type
			{
				get
				{
					return ref this._->type;
				}
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0001C584 File Offset: 0x0001A784
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0001C598 File Offset: 0x0001A798
			public unsafe ref int Offset
			{
				get
				{
					return ref this._->offset;
				}
			}

			// Token: 0x060005B2 RID: 1458 RVA: 0x0001C5AC File Offset: 0x0001A7AC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeFieldInfoStructHandler_16_0.NativeStructWrapper.eS60QfDDY5GMdJWVYR8();
			}

			// Token: 0x060005B3 RID: 1459 RVA: 0x0001C5BC File Offset: 0x0001A7BC
			internal static void jm57tLDrP9NB3y5Y3SN()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x060005B4 RID: 1460 RVA: 0x0001C5CC File Offset: 0x0001A7CC
			internal static bool dlvf7VDJAOxhOcr0h73()
			{
				return NativeFieldInfoStructHandler_16_0.NativeStructWrapper.eBMhAqDkCXh70ZYvNRY == null;
			}

			// Token: 0x060005B5 RID: 1461 RVA: 0x0001C5E0 File Offset: 0x0001A7E0
			internal static NativeFieldInfoStructHandler_16_0.NativeStructWrapper ngZb4RDWbHPa1Z6VunO()
			{
				return NativeFieldInfoStructHandler_16_0.NativeStructWrapper.eBMhAqDkCXh70ZYvNRY;
			}

			// Token: 0x060005B6 RID: 1462 RVA: 0x0001C5F0 File Offset: 0x0001A7F0
			internal static void eS60QfDDY5GMdJWVYR8()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0400027B RID: 635
			private static object eBMhAqDkCXh70ZYvNRY;
		}
	}
}
