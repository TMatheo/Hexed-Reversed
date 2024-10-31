using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x0200008C RID: 140
	[ApplicableToUnityVersionsSince("2019.1.0")]
	public class NativeImageStructHandler_24_4 : INativeImageStructHandler, INativeStructHandler
	{
		// Token: 0x0600054E RID: 1358 RVA: 0x0000F018 File Offset: 0x0000D218
		public int Size()
		{
			return sizeof(NativeImageStructHandler_24_4.Il2CppImage_24_4);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0000F028 File Offset: 0x0000D228
		public unsafe INativeImageStruct CreateNewStruct()
		{
			NativeImageStructHandler_24_4.Il2CppImage_24_4* ptr2;
			IntPtr ptr = ptr2 = NativeImageStructHandler_24_4.HytV9Qn1J2toBpyfunO(this.Size());
			*ptr2 = default(NativeImageStructHandler_24_4.Il2CppImage_24_4);
			return new NativeImageStructHandler_24_4.NativeStructWrapper(ptr);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0000F058 File Offset: 0x0000D258
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eec4384c7d0d42baa74a4dbdbdbdd8df == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeImageStructHandler_24_4.NativeStructWrapper(ptr);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0000F0C0 File Offset: 0x0000D2C0
		public NativeImageStructHandler_24_4()
		{
			NativeImageStructHandler_24_4.xpKSIlnFfvomZqW9mb5();
			NativeImageStructHandler_24_4.snQc1cnRKiStr5fgw2K();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_420bdc7f003c47439a9f8331e71194a1 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0000F124 File Offset: 0x0000D324
		// Note: this type is marked as 'beforefieldinit'.
		static NativeImageStructHandler_24_4()
		{
			NativeImageStructHandler_24_4.e0063YnML8IRfpFYEti();
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0000F134 File Offset: 0x0000D334
		internal static IntPtr HytV9Qn1J2toBpyfunO(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0000F148 File Offset: 0x0000D348
		internal static bool emIkEDn38kUkKwBQi4r()
		{
			return NativeImageStructHandler_24_4.HBclY4n4XyIg1lFoGr0 == null;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0000F15C File Offset: 0x0000D35C
		internal static NativeImageStructHandler_24_4 q9UXPjnfDQNUx6AIjtG()
		{
			return NativeImageStructHandler_24_4.HBclY4n4XyIg1lFoGr0;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000F16C File Offset: 0x0000D36C
		internal static void xpKSIlnFfvomZqW9mb5()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0000F17C File Offset: 0x0000D37C
		internal static void snQc1cnRKiStr5fgw2K()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0000F18C File Offset: 0x0000D38C
		internal static void e0063YnML8IRfpFYEti()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400024A RID: 586
		private static NativeImageStructHandler_24_4 HBclY4n4XyIg1lFoGr0;

		// Token: 0x0200008D RID: 141
		internal struct Il2CppImage_24_4
		{
			// Token: 0x0400024B RID: 587
			public unsafe byte* name;

			// Token: 0x0400024C RID: 588
			public unsafe byte* nameNoExt;

			// Token: 0x0400024D RID: 589
			public unsafe Il2CppAssembly* assembly;

			// Token: 0x0400024E RID: 590
			public int typeStart;

			// Token: 0x0400024F RID: 591
			public uint typeCount;

			// Token: 0x04000250 RID: 592
			public int exportedTypeStart;

			// Token: 0x04000251 RID: 593
			public uint exportedTypeCount;

			// Token: 0x04000252 RID: 594
			public int customAttributeStart;

			// Token: 0x04000253 RID: 595
			public uint customAttributeCount;

			// Token: 0x04000254 RID: 596
			public int entryPointIndex;

			// Token: 0x04000255 RID: 597
			public unsafe void* nameToClassHashTable;

			// Token: 0x04000256 RID: 598
			public unsafe void* codeGenModule;

			// Token: 0x04000257 RID: 599
			public uint token;

			// Token: 0x04000258 RID: 600
			public byte dynamic;
		}

		// Token: 0x0200008E RID: 142
		internal class NativeStructWrapper : INativeImageStruct, INativeStruct
		{
			// Token: 0x06000559 RID: 1369 RVA: 0x0001B520 File Offset: 0x00019720
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeImageStructHandler_24_4.NativeStructWrapper.PyTEJBNipW9uCepY2je();
				NativeImageStructHandler_24_4.NativeStructWrapper.yloh1WNwOHDg8YQFbBq();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_68cafcd7c4d444e39c183fde29795ee9 != 0)
				{
					num = 0;
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6e0b93a59f7244c4b07385ec95383bee == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x0600055A RID: 1370 RVA: 0x0001B5B0 File Offset: 0x000197B0
			private unsafe NativeImageStructHandler_24_4.Il2CppImage_24_4* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x0600055B RID: 1371 RVA: 0x0001B5C0 File Offset: 0x000197C0
			public IntPtr Pointer { get; }

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x0600055C RID: 1372 RVA: 0x0001B5D0 File Offset: 0x000197D0
			public unsafe Il2CppImage* ImagePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x0600055D RID: 1373 RVA: 0x0001B5E0 File Offset: 0x000197E0
			public bool HasNameNoExt
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x0600055E RID: 1374 RVA: 0x0001B5EC File Offset: 0x000197EC
			public unsafe ref Il2CppAssembly* Assembly
			{
				get
				{
					return ref this._->assembly;
				}
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x0600055F RID: 1375 RVA: 0x0001B600 File Offset: 0x00019800
			public unsafe ref byte Dynamic
			{
				get
				{
					return ref this._->dynamic;
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000560 RID: 1376 RVA: 0x0001B614 File Offset: 0x00019814
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000561 RID: 1377 RVA: 0x0001B62C File Offset: 0x0001982C
			public unsafe ref IntPtr NameNoExt
			{
				get
				{
					return ref *(IntPtr*)(&this._->nameNoExt);
				}
			}

			// Token: 0x06000562 RID: 1378 RVA: 0x0001B644 File Offset: 0x00019844
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeImageStructHandler_24_4.NativeStructWrapper.I1qcPGNEH9284VOXCf7();
			}

			// Token: 0x06000563 RID: 1379 RVA: 0x0001B654 File Offset: 0x00019854
			internal static void PyTEJBNipW9uCepY2je()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000564 RID: 1380 RVA: 0x0001B664 File Offset: 0x00019864
			internal static void yloh1WNwOHDg8YQFbBq()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000565 RID: 1381 RVA: 0x0001B674 File Offset: 0x00019874
			internal static bool XgHOsbNI6045CkntbeE()
			{
				return NativeImageStructHandler_24_4.NativeStructWrapper.XN6u6EN9qJ4DHvIT8hL == null;
			}

			// Token: 0x06000566 RID: 1382 RVA: 0x0001B688 File Offset: 0x00019888
			internal static NativeImageStructHandler_24_4.NativeStructWrapper v1XwtlNdfiTdogd7dyW()
			{
				return NativeImageStructHandler_24_4.NativeStructWrapper.XN6u6EN9qJ4DHvIT8hL;
			}

			// Token: 0x06000567 RID: 1383 RVA: 0x0001B698 File Offset: 0x00019898
			internal static void I1qcPGNEH9284VOXCf7()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0400025A RID: 602
			internal static object XN6u6EN9qJ4DHvIT8hL;
		}
	}
}
