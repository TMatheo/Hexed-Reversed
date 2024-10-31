using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.FieldInfo
{
	// Token: 0x02000094 RID: 148
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeFieldInfoStructHandler_16_0 : INativeFieldInfoStructHandler, INativeStructHandler
	{
		// Token: 0x06000588 RID: 1416 RVA: 0x0000F330 File Offset: 0x0000D530
		public int Size()
		{
			return sizeof(NativeFieldInfoStructHandler_16_0.Il2CppFieldInfo_16_0);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0000F340 File Offset: 0x0000D540
		public unsafe INativeFieldInfoStruct CreateNewStruct()
		{
			NativeFieldInfoStructHandler_16_0.Il2CppFieldInfo_16_0* ptr2;
			IntPtr ptr = ptr2 = NativeFieldInfoStructHandler_16_0.HewTA6njGDOng2BhyEq(this.Size());
			*ptr2 = default(NativeFieldInfoStructHandler_16_0.Il2CppFieldInfo_16_0);
			return new NativeFieldInfoStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0000F370 File Offset: 0x0000D570
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_457365959f004478ad0e311bf72b3912 == 0)
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

		// Token: 0x0600058B RID: 1419 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		public NativeFieldInfoStructHandler_16_0()
		{
			NativeFieldInfoStructHandler_16_0.t0uRBXnQLpKXxRB0n3F();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b4185925b5254e3aae05578c6a89b13c == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0000F43C File Offset: 0x0000D63C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeFieldInfoStructHandler_16_0()
		{
			NativeFieldInfoStructHandler_16_0.XiPa32neL99OOrEvXs2();
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0000F44C File Offset: 0x0000D64C
		internal static IntPtr HewTA6njGDOng2BhyEq(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0000F460 File Offset: 0x0000D660
		internal static bool TIvp3Tno6V9PocCrKGw()
		{
			return NativeFieldInfoStructHandler_16_0.Fss46KngPsIc0QPb1Pm == null;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0000F474 File Offset: 0x0000D674
		internal static NativeFieldInfoStructHandler_16_0 oak8xhnUPC9s3LfqjWj()
		{
			return NativeFieldInfoStructHandler_16_0.Fss46KngPsIc0QPb1Pm;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0000F484 File Offset: 0x0000D684
		internal static void t0uRBXnQLpKXxRB0n3F()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0000F494 File Offset: 0x0000D694
		internal static void XiPa32neL99OOrEvXs2()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000269 RID: 617
		internal static NativeFieldInfoStructHandler_16_0 Fss46KngPsIc0QPb1Pm;

		// Token: 0x02000095 RID: 149
		internal struct Il2CppFieldInfo_16_0
		{
			// Token: 0x0400026A RID: 618
			public unsafe byte* name;

			// Token: 0x0400026B RID: 619
			public unsafe Il2CppTypeStruct* type;

			// Token: 0x0400026C RID: 620
			public unsafe Il2CppClass* parent;

			// Token: 0x0400026D RID: 621
			public int offset;

			// Token: 0x0400026E RID: 622
			public int customAttributeIndex;
		}

		// Token: 0x02000096 RID: 150
		internal class NativeStructWrapper : INativeFieldInfoStruct, INativeStruct
		{
			// Token: 0x06000592 RID: 1426 RVA: 0x0001B820 File Offset: 0x00019A20
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeFieldInfoStructHandler_16_0.NativeStructWrapper.ciLuZAul9JyNQCXN9uN();
				NativeFieldInfoStructHandler_16_0.NativeStructWrapper.tgeMgDuqkXoTejFwBA0();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_11d7514559f14fcba52669ac71e3cb39 != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_da5aa2d475094b06a3df3cc53bc85956 != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000593 RID: 1427 RVA: 0x0001B8B0 File Offset: 0x00019AB0
			private unsafe NativeFieldInfoStructHandler_16_0.Il2CppFieldInfo_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000594 RID: 1428 RVA: 0x0001B8C0 File Offset: 0x00019AC0
			public IntPtr Pointer { get; }

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x06000595 RID: 1429 RVA: 0x0001B8D0 File Offset: 0x00019AD0
			public unsafe Il2CppFieldInfo* FieldInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x06000596 RID: 1430 RVA: 0x0001B8E0 File Offset: 0x00019AE0
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x06000597 RID: 1431 RVA: 0x0001B8F8 File Offset: 0x00019AF8
			public unsafe ref Il2CppTypeStruct* Type
			{
				get
				{
					return ref this._->type;
				}
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x06000598 RID: 1432 RVA: 0x0001B90C File Offset: 0x00019B0C
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x06000599 RID: 1433 RVA: 0x0001B920 File Offset: 0x00019B20
			public unsafe ref int Offset
			{
				get
				{
					return ref this._->offset;
				}
			}

			// Token: 0x0600059A RID: 1434 RVA: 0x0001B934 File Offset: 0x00019B34
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeFieldInfoStructHandler_16_0.NativeStructWrapper.MEmwnqu5l8DHopXiPfr();
			}

			// Token: 0x0600059B RID: 1435 RVA: 0x0001B944 File Offset: 0x00019B44
			internal static void ciLuZAul9JyNQCXN9uN()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600059C RID: 1436 RVA: 0x0001B954 File Offset: 0x00019B54
			internal static void tgeMgDuqkXoTejFwBA0()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x0600059D RID: 1437 RVA: 0x0001B964 File Offset: 0x00019B64
			internal static bool FT57BeNZoN2hRULOMuV()
			{
				return NativeFieldInfoStructHandler_16_0.NativeStructWrapper.OAK1qLNac5Hw0g38IAM == null;
			}

			// Token: 0x0600059E RID: 1438 RVA: 0x0001B978 File Offset: 0x00019B78
			internal static NativeFieldInfoStructHandler_16_0.NativeStructWrapper BU8oT6NzcUGxc9WDUEj()
			{
				return NativeFieldInfoStructHandler_16_0.NativeStructWrapper.OAK1qLNac5Hw0g38IAM;
			}

			// Token: 0x0600059F RID: 1439 RVA: 0x0001B988 File Offset: 0x00019B88
			internal static void MEmwnqu5l8DHopXiPfr()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000270 RID: 624
			private static object OAK1qLNac5Hw0g38IAM;
		}
	}
}
