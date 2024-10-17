using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.FieldInfo
{
	// Token: 0x0200009C RID: 156
	[ApplicableToUnityVersionsSince("2018.3.0")]
	public class NativeFieldInfoStructHandler_24_0 : INativeFieldInfoStructHandler, INativeStructHandler
	{
		// Token: 0x060005CF RID: 1487 RVA: 0x00010204 File Offset: 0x0000E404
		public int Size()
		{
			return sizeof(NativeFieldInfoStructHandler_24_0.Il2CppFieldInfo_24_0);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00010214 File Offset: 0x0000E414
		public unsafe INativeFieldInfoStruct CreateNewStruct()
		{
			NativeFieldInfoStructHandler_24_0.Il2CppFieldInfo_24_0* ptr2;
			IntPtr ptr = ptr2 = NativeFieldInfoStructHandler_24_0.PvAqVvELmDjweCJvauE(this.Size());
			*ptr2 = default(NativeFieldInfoStructHandler_24_0.Il2CppFieldInfo_24_0);
			return new NativeFieldInfoStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00010244 File Offset: 0x0000E444
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_18558c8f0d4f4774910664df1c51bd49 != 0)
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

		// Token: 0x060005D2 RID: 1490 RVA: 0x000102AC File Offset: 0x0000E4AC
		public NativeFieldInfoStructHandler_24_0()
		{
			NativeFieldInfoStructHandler_24_0.uW7m0YE7DUAFnMbV1ba();
			NativeFieldInfoStructHandler_24_0.Xij1yZERoqlwiGisq8U();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00010310 File Offset: 0x0000E510
		// Note: this type is marked as 'beforefieldinit'.
		static NativeFieldInfoStructHandler_24_0()
		{
			NativeFieldInfoStructHandler_24_0.KJwHAEEkgbjkR91rC77();
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00010320 File Offset: 0x0000E520
		internal static IntPtr PvAqVvELmDjweCJvauE(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00010334 File Offset: 0x0000E534
		internal static bool m1wnncEcyTnApjEEtDn()
		{
			return NativeFieldInfoStructHandler_24_0.sqCqHdEEYeeI9CyfE2L == null;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00010348 File Offset: 0x0000E548
		internal static NativeFieldInfoStructHandler_24_0 vefNFWE6Ugb7SNJQ5aD()
		{
			return NativeFieldInfoStructHandler_24_0.sqCqHdEEYeeI9CyfE2L;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00010358 File Offset: 0x0000E558
		internal static void uW7m0YE7DUAFnMbV1ba()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00010368 File Offset: 0x0000E568
		internal static void Xij1yZERoqlwiGisq8U()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00010378 File Offset: 0x0000E578
		internal static void KJwHAEEkgbjkR91rC77()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000285 RID: 645
		internal static NativeFieldInfoStructHandler_24_0 sqCqHdEEYeeI9CyfE2L;

		// Token: 0x0200009D RID: 157
		internal struct Il2CppFieldInfo_24_0
		{
			// Token: 0x04000286 RID: 646
			public unsafe byte* name;

			// Token: 0x04000287 RID: 647
			public unsafe Il2CppTypeStruct* type;

			// Token: 0x04000288 RID: 648
			public unsafe Il2CppClass* parent;

			// Token: 0x04000289 RID: 649
			public int offset;

			// Token: 0x0400028A RID: 650
			public uint token;
		}

		// Token: 0x0200009E RID: 158
		internal class NativeStructWrapper : INativeFieldInfoStruct, INativeStruct
		{
			// Token: 0x060005DA RID: 1498 RVA: 0x0001C768 File Offset: 0x0001A968
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeFieldInfoStructHandler_24_0.NativeStructWrapper.i2vswKDlw4YOLPtEp8o();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bacedfb8a3cf4671ae3e03ec2f965495 != 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56a961858094410b8d2e4da57d386f1 == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x060005DB RID: 1499 RVA: 0x0001C7F8 File Offset: 0x0001A9F8
			private unsafe NativeFieldInfoStructHandler_24_0.Il2CppFieldInfo_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x060005DC RID: 1500 RVA: 0x0001C808 File Offset: 0x0001AA08
			public IntPtr Pointer { get; }

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x060005DD RID: 1501 RVA: 0x0001C818 File Offset: 0x0001AA18
			public unsafe Il2CppFieldInfo* FieldInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x060005DE RID: 1502 RVA: 0x0001C828 File Offset: 0x0001AA28
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x060005DF RID: 1503 RVA: 0x0001C840 File Offset: 0x0001AA40
			public unsafe ref Il2CppTypeStruct* Type
			{
				get
				{
					return ref this._->type;
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0001C854 File Offset: 0x0001AA54
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0001C868 File Offset: 0x0001AA68
			public unsafe ref int Offset
			{
				get
				{
					return ref this._->offset;
				}
			}

			// Token: 0x060005E2 RID: 1506 RVA: 0x0001C87C File Offset: 0x0001AA7C
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x060005E3 RID: 1507 RVA: 0x0001C88C File Offset: 0x0001AA8C
			internal static void i2vswKDlw4YOLPtEp8o()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x060005E4 RID: 1508 RVA: 0x0001C89C File Offset: 0x0001AA9C
			internal static bool Fr6OSTDSeoBt5I1DuUm()
			{
				return NativeFieldInfoStructHandler_24_0.NativeStructWrapper.BLlibyDypSXATpjIK1I == null;
			}

			// Token: 0x060005E5 RID: 1509 RVA: 0x0001C8B0 File Offset: 0x0001AAB0
			internal static NativeFieldInfoStructHandler_24_0.NativeStructWrapper ujSvayDghyDg9lhRGGZ()
			{
				return NativeFieldInfoStructHandler_24_0.NativeStructWrapper.BLlibyDypSXATpjIK1I;
			}

			// Token: 0x0400028C RID: 652
			private static object BLlibyDypSXATpjIK1I;
		}
	}
}
