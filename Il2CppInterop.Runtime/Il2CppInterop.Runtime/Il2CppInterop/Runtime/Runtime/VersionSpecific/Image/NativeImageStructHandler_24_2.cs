using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x02000086 RID: 134
	[ApplicableToUnityVersionsSince("2018.1.0")]
	public class NativeImageStructHandler_24_2 : INativeImageStructHandler, INativeStructHandler
	{
		// Token: 0x0600051D RID: 1309 RVA: 0x0000ED20 File Offset: 0x0000CF20
		public int Size()
		{
			return sizeof(NativeImageStructHandler_24_2.Il2CppImage_24_2);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0000ED30 File Offset: 0x0000CF30
		public unsafe INativeImageStruct CreateNewStruct()
		{
			NativeImageStructHandler_24_2.Il2CppImage_24_2* ptr2;
			IntPtr ptr = ptr2 = NativeImageStructHandler_24_2.YsA4UnnVWncGuXokSH1(this.Size());
			*ptr2 = default(NativeImageStructHandler_24_2.Il2CppImage_24_2);
			return new NativeImageStructHandler_24_2.NativeStructWrapper(ptr);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0000ED60 File Offset: 0x0000CF60
		public unsafe INativeImageStruct Wrap(Il2CppImage* ptr)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7dfb1d10537744ca9e949b6b3a3eac09 == 0)
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
			return new NativeImageStructHandler_24_2.NativeStructWrapper(ptr);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0000EDC8 File Offset: 0x0000CFC8
		public NativeImageStructHandler_24_2()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeImageStructHandler_24_2.DRJComn0EHuP8CpPO5j();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_441278fe93ad425f9343d4f7d1692fca == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0000EE2C File Offset: 0x0000D02C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeImageStructHandler_24_2()
		{
			NativeImageStructHandler_24_2.Tqg3EVns5fs5IiQw42Y();
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0000EE3C File Offset: 0x0000D03C
		internal static IntPtr YsA4UnnVWncGuXokSH1(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0000EE50 File Offset: 0x0000D050
		internal static bool fIrUernJlq9tq1l9oRG()
		{
			return NativeImageStructHandler_24_2.AHsV4EnyoPSd31Bjyci == null;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0000EE64 File Offset: 0x0000D064
		internal static NativeImageStructHandler_24_2 Nsx6xrnp4pHefu4O6gl()
		{
			return NativeImageStructHandler_24_2.AHsV4EnyoPSd31Bjyci;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0000EE74 File Offset: 0x0000D074
		internal static void DRJComn0EHuP8CpPO5j()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0000EE84 File Offset: 0x0000D084
		internal static void Tqg3EVns5fs5IiQw42Y()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400022C RID: 556
		private static NativeImageStructHandler_24_2 AHsV4EnyoPSd31Bjyci;

		// Token: 0x02000087 RID: 135
		internal struct Il2CppImage_24_2
		{
			// Token: 0x0400022D RID: 557
			public unsafe byte* name;

			// Token: 0x0400022E RID: 558
			public unsafe byte* nameNoExt;

			// Token: 0x0400022F RID: 559
			public unsafe Il2CppAssembly* assembly;

			// Token: 0x04000230 RID: 560
			public int typeStart;

			// Token: 0x04000231 RID: 561
			public uint typeCount;

			// Token: 0x04000232 RID: 562
			public int exportedTypeStart;

			// Token: 0x04000233 RID: 563
			public uint exportedTypeCount;

			// Token: 0x04000234 RID: 564
			public int entryPointIndex;

			// Token: 0x04000235 RID: 565
			public unsafe void* nameToClassHashTable;

			// Token: 0x04000236 RID: 566
			public uint token;

			// Token: 0x04000237 RID: 567
			public byte dynamic;
		}

		// Token: 0x02000088 RID: 136
		internal class NativeStructWrapper : INativeImageStruct, INativeStruct
		{
			// Token: 0x06000527 RID: 1319 RVA: 0x0001B230 File Offset: 0x00019430
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeImageStructHandler_24_2.NativeStructWrapper.RwRPMrND8Agf7kLm8qF();
				NativeImageStructHandler_24_2.NativeStructWrapper.pWt6qTNmQYYrxspcrvP();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2356ac6ca5954f1897cd5bbbe0161ae5 != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6d7a22a8da0c4b3e8cf479dd7edc9922 != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x06000528 RID: 1320 RVA: 0x0001B2C0 File Offset: 0x000194C0
			private unsafe NativeImageStructHandler_24_2.Il2CppImage_24_2* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x06000529 RID: 1321 RVA: 0x0001B2D0 File Offset: 0x000194D0
			public IntPtr Pointer { get; }

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x0600052A RID: 1322 RVA: 0x0001B2E0 File Offset: 0x000194E0
			public unsafe Il2CppImage* ImagePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x0600052B RID: 1323 RVA: 0x0001B2F0 File Offset: 0x000194F0
			public bool HasNameNoExt
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x0600052C RID: 1324 RVA: 0x0001B2FC File Offset: 0x000194FC
			public unsafe ref Il2CppAssembly* Assembly
			{
				get
				{
					return ref this._->assembly;
				}
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x0600052D RID: 1325 RVA: 0x0001B310 File Offset: 0x00019510
			public unsafe ref byte Dynamic
			{
				get
				{
					return ref this._->dynamic;
				}
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x0600052E RID: 1326 RVA: 0x0001B324 File Offset: 0x00019524
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x0600052F RID: 1327 RVA: 0x0001B33C File Offset: 0x0001953C
			public unsafe ref IntPtr NameNoExt
			{
				get
				{
					return ref *(IntPtr*)(&this._->nameNoExt);
				}
			}

			// Token: 0x06000530 RID: 1328 RVA: 0x0001B354 File Offset: 0x00019554
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeImageStructHandler_24_2.NativeStructWrapper.VEHL76N7ehjc2T3pQVb();
			}

			// Token: 0x06000531 RID: 1329 RVA: 0x0001B364 File Offset: 0x00019564
			internal static void RwRPMrND8Agf7kLm8qF()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000532 RID: 1330 RVA: 0x0001B374 File Offset: 0x00019574
			internal static void pWt6qTNmQYYrxspcrvP()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000533 RID: 1331 RVA: 0x0001B384 File Offset: 0x00019584
			internal static bool xFGK5qNNTN2TZMxVdIQ()
			{
				return NativeImageStructHandler_24_2.NativeStructWrapper.zKUWhVNSiNWBxMoWFn9 == null;
			}

			// Token: 0x06000534 RID: 1332 RVA: 0x0001B398 File Offset: 0x00019598
			internal static NativeImageStructHandler_24_2.NativeStructWrapper ms9IFMNu8MjxUToJN5v()
			{
				return NativeImageStructHandler_24_2.NativeStructWrapper.zKUWhVNSiNWBxMoWFn9;
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x0001B3A8 File Offset: 0x000195A8
			internal static void VEHL76N7ehjc2T3pQVb()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000239 RID: 569
			private static object zKUWhVNSiNWBxMoWFn9;
		}
	}
}
