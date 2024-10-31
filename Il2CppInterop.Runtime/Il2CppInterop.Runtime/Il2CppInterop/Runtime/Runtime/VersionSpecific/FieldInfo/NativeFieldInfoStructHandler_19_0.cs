using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.FieldInfo
{
	// Token: 0x02000097 RID: 151
	[ApplicableToUnityVersionsSince("5.3.2")]
	public class NativeFieldInfoStructHandler_19_0 : INativeFieldInfoStructHandler, INativeStructHandler
	{
		// Token: 0x060005A0 RID: 1440 RVA: 0x0000F4A4 File Offset: 0x0000D6A4
		public int Size()
		{
			return sizeof(NativeFieldInfoStructHandler_19_0.Il2CppFieldInfo_19_0);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0000F4B4 File Offset: 0x0000D6B4
		public unsafe INativeFieldInfoStruct CreateNewStruct()
		{
			NativeFieldInfoStructHandler_19_0.Il2CppFieldInfo_19_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeFieldInfoStructHandler_19_0.Il2CppFieldInfo_19_0);
			return new NativeFieldInfoStructHandler_19_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0000F4E4 File Offset: 0x0000D6E4
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_11d7514559f14fcba52669ac71e3cb39 == 0)
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

		// Token: 0x060005A3 RID: 1443 RVA: 0x0000F54C File Offset: 0x0000D74C
		public NativeFieldInfoStructHandler_19_0()
		{
			NativeFieldInfoStructHandler_19_0.iYiaf3nzpB2QaHOhi9I();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0000F5B0 File Offset: 0x0000D7B0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeFieldInfoStructHandler_19_0()
		{
			NativeFieldInfoStructHandler_19_0.DbpAw0bl71GAVnBlggF();
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0000F5C0 File Offset: 0x0000D7C0
		internal static bool Vq9fyXnaoSyauq9gU5b()
		{
			return NativeFieldInfoStructHandler_19_0.zQlb0VnKwfKSb6HrJ32 == null;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0000F5D4 File Offset: 0x0000D7D4
		internal static NativeFieldInfoStructHandler_19_0 Ex2TypnZDYnoq7C5wVi()
		{
			return NativeFieldInfoStructHandler_19_0.zQlb0VnKwfKSb6HrJ32;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0000F5E4 File Offset: 0x0000D7E4
		internal static void iYiaf3nzpB2QaHOhi9I()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0000F5F4 File Offset: 0x0000D7F4
		internal static void DbpAw0bl71GAVnBlggF()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000271 RID: 625
		internal static NativeFieldInfoStructHandler_19_0 zQlb0VnKwfKSb6HrJ32;

		// Token: 0x02000098 RID: 152
		internal struct Il2CppFieldInfo_19_0
		{
			// Token: 0x04000272 RID: 626
			public unsafe byte* name;

			// Token: 0x04000273 RID: 627
			public unsafe Il2CppTypeStruct* type;

			// Token: 0x04000274 RID: 628
			public unsafe Il2CppClass* parent;

			// Token: 0x04000275 RID: 629
			public int offset;

			// Token: 0x04000276 RID: 630
			public int customAttributeIndex;

			// Token: 0x04000277 RID: 631
			public uint token;
		}

		// Token: 0x02000099 RID: 153
		internal class NativeStructWrapper : INativeFieldInfoStruct, INativeStruct
		{
			// Token: 0x060005A9 RID: 1449 RVA: 0x0001B998 File Offset: 0x00019B98
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeFieldInfoStructHandler_19_0.NativeStructWrapper.awJ9kEuH1cgKVg1oS4c();
				NativeFieldInfoStructHandler_19_0.NativeStructWrapper.AAJ6S1uhJEDmOo9wQvB();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c580bbd8275c462fb04ea886a5e08073 == 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.<Pointer>k__BackingField = ptr;
						num = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5395ed2b7ead4e349835ba3f56e39138 != 0)
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
			// (get) Token: 0x060005AA RID: 1450 RVA: 0x0001BA28 File Offset: 0x00019C28
			private unsafe NativeFieldInfoStructHandler_19_0.Il2CppFieldInfo_19_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x060005AB RID: 1451 RVA: 0x0001BA38 File Offset: 0x00019C38
			public IntPtr Pointer { get; }

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x060005AC RID: 1452 RVA: 0x0001BA48 File Offset: 0x00019C48
			public unsafe Il2CppFieldInfo* FieldInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x060005AD RID: 1453 RVA: 0x0001BA58 File Offset: 0x00019C58
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x060005AE RID: 1454 RVA: 0x0001BA70 File Offset: 0x00019C70
			public unsafe ref Il2CppTypeStruct* Type
			{
				get
				{
					return ref this._->type;
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x060005AF RID: 1455 RVA: 0x0001BA84 File Offset: 0x00019C84
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0001BA98 File Offset: 0x00019C98
			public unsafe ref int Offset
			{
				get
				{
					return ref this._->offset;
				}
			}

			// Token: 0x060005B1 RID: 1457 RVA: 0x0001BAAC File Offset: 0x00019CAC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeFieldInfoStructHandler_19_0.NativeStructWrapper.mxtkIBuOP56N05dID88();
			}

			// Token: 0x060005B2 RID: 1458 RVA: 0x0001BABC File Offset: 0x00019CBC
			internal static void awJ9kEuH1cgKVg1oS4c()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060005B3 RID: 1459 RVA: 0x0001BACC File Offset: 0x00019CCC
			internal static void AAJ6S1uhJEDmOo9wQvB()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x060005B4 RID: 1460 RVA: 0x0001BADC File Offset: 0x00019CDC
			internal static bool YmRDHbuk7FSc0EvDfeT()
			{
				return NativeFieldInfoStructHandler_19_0.NativeStructWrapper.Wn19XqucvUEwa6EVqqI == null;
			}

			// Token: 0x060005B5 RID: 1461 RVA: 0x0001BAF0 File Offset: 0x00019CF0
			internal static NativeFieldInfoStructHandler_19_0.NativeStructWrapper vjGZPyu2yPUT1r1L3HY()
			{
				return NativeFieldInfoStructHandler_19_0.NativeStructWrapper.Wn19XqucvUEwa6EVqqI;
			}

			// Token: 0x060005B6 RID: 1462 RVA: 0x0001BB00 File Offset: 0x00019D00
			internal static void mxtkIBuOP56N05dID88()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000279 RID: 633
			internal static object Wn19XqucvUEwa6EVqqI;
		}
	}
}
