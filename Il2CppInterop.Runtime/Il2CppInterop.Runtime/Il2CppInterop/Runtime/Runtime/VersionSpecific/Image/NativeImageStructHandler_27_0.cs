using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x0200008F RID: 143
	[ApplicableToUnityVersionsSince("2020.2.0")]
	public class NativeImageStructHandler_27_0 : INativeImageStructHandler, INativeStructHandler
	{
		// Token: 0x06000568 RID: 1384 RVA: 0x0000F19C File Offset: 0x0000D39C
		public int Size()
		{
			return sizeof(NativeImageStructHandler_27_0.Il2CppImage_27_0);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0000F1AC File Offset: 0x0000D3AC
		public unsafe INativeImageStruct CreateNewStruct()
		{
			NativeImageStructHandler_27_0.Il2CppImage_27_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeImageStructHandler_27_0.Il2CppImage_27_0);
			Il2CppImageGlobalMetadata* ptr3 = NativeImageStructHandler_27_0.tETEM1nIlMfayLB0FAl(sizeof(Il2CppImageGlobalMetadata));
			ptr3->image = (Il2CppImage*)ptr2;
			*(IntPtr*)(&ptr2->metadataHandle) = ptr3;
			return new NativeImageStructHandler_27_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0000F1FC File Offset: 0x0000D3FC
		public unsafe INativeImageStruct Wrap(Il2CppImage* ptr)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b502855b254c47cfafcd30fd84ad7c96 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeImageStructHandler_27_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0000F264 File Offset: 0x0000D464
		public NativeImageStructHandler_27_0()
		{
			NativeImageStructHandler_27_0.run2wvnd96Rcuxex4P0();
			NativeImageStructHandler_27_0.FquTB6nijwhQLee6FAN();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6dbfd13d96434eb59d868fecd0ad1cda == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0000F2C8 File Offset: 0x0000D4C8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeImageStructHandler_27_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0000F2D8 File Offset: 0x0000D4D8
		internal static IntPtr tETEM1nIlMfayLB0FAl(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0000F2EC File Offset: 0x0000D4EC
		internal static bool RKVN1tnCv64x9mRdBL6()
		{
			return NativeImageStructHandler_27_0.CKqKY7nWS6tslEkPLPS == null;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0000F300 File Offset: 0x0000D500
		internal static NativeImageStructHandler_27_0 A8kY7en9f8LWESjxsTT()
		{
			return NativeImageStructHandler_27_0.CKqKY7nWS6tslEkPLPS;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0000F310 File Offset: 0x0000D510
		internal static void run2wvnd96Rcuxex4P0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0000F320 File Offset: 0x0000D520
		internal static void FquTB6nijwhQLee6FAN()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x0400025B RID: 603
		internal static NativeImageStructHandler_27_0 CKqKY7nWS6tslEkPLPS;

		// Token: 0x02000090 RID: 144
		internal struct Il2CppImage_27_0
		{
			// Token: 0x0400025C RID: 604
			public unsafe byte* name;

			// Token: 0x0400025D RID: 605
			public unsafe byte* nameNoExt;

			// Token: 0x0400025E RID: 606
			public unsafe Il2CppAssembly* assembly;

			// Token: 0x0400025F RID: 607
			public uint typeCount;

			// Token: 0x04000260 RID: 608
			public uint exportedTypeCount;

			// Token: 0x04000261 RID: 609
			public uint customAttributeCount;

			// Token: 0x04000262 RID: 610
			public Il2CppMetadataImageHandle metadataHandle;

			// Token: 0x04000263 RID: 611
			public unsafe void* nameToClassHashTable;

			// Token: 0x04000264 RID: 612
			public unsafe void* codeGenModule;

			// Token: 0x04000265 RID: 613
			public uint token;

			// Token: 0x04000266 RID: 614
			public byte dynamic;
		}

		// Token: 0x02000091 RID: 145
		internal class NativeStructWrapper : INativeImageStruct, INativeStruct
		{
			// Token: 0x06000572 RID: 1394 RVA: 0x0001B6A8 File Offset: 0x000198A8
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeImageStructHandler_27_0.NativeStructWrapper.VE5n1qNUGUgntYei3mR();
				NativeImageStructHandler_27_0.NativeStructWrapper.atCH3ENjch5B1TJPULA();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6dbfd13d96434eb59d868fecd0ad1cda == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0272cc4de9694915be17746e515675c8 == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x06000573 RID: 1395 RVA: 0x0001B738 File Offset: 0x00019938
			private unsafe NativeImageStructHandler_27_0.Il2CppImage_27_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x06000574 RID: 1396 RVA: 0x0001B748 File Offset: 0x00019948
			public IntPtr Pointer { get; }

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x06000575 RID: 1397 RVA: 0x0001B758 File Offset: 0x00019958
			public unsafe Il2CppImage* ImagePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x06000576 RID: 1398 RVA: 0x0001B768 File Offset: 0x00019968
			public bool HasNameNoExt
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x06000577 RID: 1399 RVA: 0x0001B774 File Offset: 0x00019974
			public unsafe ref Il2CppAssembly* Assembly
			{
				get
				{
					return ref this._->assembly;
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000578 RID: 1400 RVA: 0x0001B788 File Offset: 0x00019988
			public unsafe ref byte Dynamic
			{
				get
				{
					return ref this._->dynamic;
				}
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x06000579 RID: 1401 RVA: 0x0001B79C File Offset: 0x0001999C
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x0600057A RID: 1402 RVA: 0x0001B7B4 File Offset: 0x000199B4
			public unsafe ref IntPtr NameNoExt
			{
				get
				{
					return ref *(IntPtr*)(&this._->nameNoExt);
				}
			}

			// Token: 0x0600057B RID: 1403 RVA: 0x0001B7CC File Offset: 0x000199CC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0600057C RID: 1404 RVA: 0x0001B7DC File Offset: 0x000199DC
			internal static void VE5n1qNUGUgntYei3mR()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600057D RID: 1405 RVA: 0x0001B7EC File Offset: 0x000199EC
			internal static void atCH3ENjch5B1TJPULA()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x0600057E RID: 1406 RVA: 0x0001B7FC File Offset: 0x000199FC
			internal static bool DuY2PKNgmrpZmlqVgHQ()
			{
				return NativeImageStructHandler_27_0.NativeStructWrapper.PdZfCtNTu3lsCAuF5XL == null;
			}

			// Token: 0x0600057F RID: 1407 RVA: 0x0001B810 File Offset: 0x00019A10
			internal static NativeImageStructHandler_27_0.NativeStructWrapper C7a8lsNo96wLZbRNfpS()
			{
				return NativeImageStructHandler_27_0.NativeStructWrapper.PdZfCtNTu3lsCAuF5XL;
			}

			// Token: 0x04000268 RID: 616
			internal static object PdZfCtNTu3lsCAuF5XL;
		}
	}
}
