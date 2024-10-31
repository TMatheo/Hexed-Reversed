using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x02000089 RID: 137
	[ApplicableToUnityVersionsSince("2018.3.0")]
	public class NativeImageStructHandler_24_3 : INativeImageStructHandler, INativeStructHandler
	{
		// Token: 0x06000536 RID: 1334 RVA: 0x0000EE94 File Offset: 0x0000D094
		public int Size()
		{
			return sizeof(NativeImageStructHandler_24_3.Il2CppImage_24_3);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0000EEA4 File Offset: 0x0000D0A4
		public unsafe INativeImageStruct CreateNewStruct()
		{
			NativeImageStructHandler_24_3.Il2CppImage_24_3* ptr2;
			IntPtr ptr = ptr2 = NativeImageStructHandler_24_3.FRsqGMnDIg5lgNHtuos(this.Size());
			*ptr2 = default(NativeImageStructHandler_24_3.Il2CppImage_24_3);
			return new NativeImageStructHandler_24_3.NativeStructWrapper(ptr);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0000EED4 File Offset: 0x0000D0D4
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa == 0)
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
			return new NativeImageStructHandler_24_3.NativeStructWrapper(ptr);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0000EF3C File Offset: 0x0000D13C
		public NativeImageStructHandler_24_3()
		{
			NativeImageStructHandler_24_3.MIcj6fnmrgvjQUS8gDY();
			NativeImageStructHandler_24_3.hNU81tn7aeFqDc0PvCj();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4c6a46c0a2d14747aa1dc5bf1581154d == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeImageStructHandler_24_3()
		{
			NativeImageStructHandler_24_3.UwfCepnPs7QeCKQYAhp();
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0000EFB0 File Offset: 0x0000D1B0
		internal static IntPtr FRsqGMnDIg5lgNHtuos(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0000EFC4 File Offset: 0x0000D1C4
		internal static bool pgyKSmnNZCIbiaAPsob()
		{
			return NativeImageStructHandler_24_3.r0yV4snSXhraI8BCUxL == null;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0000EFD8 File Offset: 0x0000D1D8
		internal static NativeImageStructHandler_24_3 jcoCYJnuJib20j35POS()
		{
			return NativeImageStructHandler_24_3.r0yV4snSXhraI8BCUxL;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
		internal static void MIcj6fnmrgvjQUS8gDY()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0000EFF8 File Offset: 0x0000D1F8
		internal static void hNU81tn7aeFqDc0PvCj()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0000F008 File Offset: 0x0000D208
		internal static void UwfCepnPs7QeCKQYAhp()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400023A RID: 570
		internal static NativeImageStructHandler_24_3 r0yV4snSXhraI8BCUxL;

		// Token: 0x0200008A RID: 138
		internal struct Il2CppImage_24_3
		{
			// Token: 0x0400023B RID: 571
			public unsafe byte* name;

			// Token: 0x0400023C RID: 572
			public unsafe byte* nameNoExt;

			// Token: 0x0400023D RID: 573
			public unsafe Il2CppAssembly* assembly;

			// Token: 0x0400023E RID: 574
			public int typeStart;

			// Token: 0x0400023F RID: 575
			public uint typeCount;

			// Token: 0x04000240 RID: 576
			public int exportedTypeStart;

			// Token: 0x04000241 RID: 577
			public uint exportedTypeCount;

			// Token: 0x04000242 RID: 578
			public int customAttributeStart;

			// Token: 0x04000243 RID: 579
			public uint customAttributeCount;

			// Token: 0x04000244 RID: 580
			public int entryPointIndex;

			// Token: 0x04000245 RID: 581
			public unsafe void* nameToClassHashTable;

			// Token: 0x04000246 RID: 582
			public uint token;

			// Token: 0x04000247 RID: 583
			public byte dynamic;
		}

		// Token: 0x0200008B RID: 139
		internal class NativeStructWrapper : INativeImageStruct, INativeStruct
		{
			// Token: 0x06000541 RID: 1345 RVA: 0x0001B3B8 File Offset: 0x000195B8
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e6eb36653ec04a89bf8fa64932849f3b == 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						this.<Pointer>k__BackingField = ptr;
						num = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6d9238cad9434518b97d223669b8fe50 != 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x06000542 RID: 1346 RVA: 0x0001B448 File Offset: 0x00019648
			private unsafe NativeImageStructHandler_24_3.Il2CppImage_24_3* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x06000543 RID: 1347 RVA: 0x0001B458 File Offset: 0x00019658
			public IntPtr Pointer { get; }

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x06000544 RID: 1348 RVA: 0x0001B468 File Offset: 0x00019668
			public unsafe Il2CppImage* ImagePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x06000545 RID: 1349 RVA: 0x0001B478 File Offset: 0x00019678
			public bool HasNameNoExt
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x06000546 RID: 1350 RVA: 0x0001B484 File Offset: 0x00019684
			public unsafe ref Il2CppAssembly* Assembly
			{
				get
				{
					return ref this._->assembly;
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000547 RID: 1351 RVA: 0x0001B498 File Offset: 0x00019698
			public unsafe ref byte Dynamic
			{
				get
				{
					return ref this._->dynamic;
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x06000548 RID: 1352 RVA: 0x0001B4AC File Offset: 0x000196AC
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x06000549 RID: 1353 RVA: 0x0001B4C4 File Offset: 0x000196C4
			public unsafe ref IntPtr NameNoExt
			{
				get
				{
					return ref *(IntPtr*)(&this._->nameNoExt);
				}
			}

			// Token: 0x0600054A RID: 1354 RVA: 0x0001B4DC File Offset: 0x000196DC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeImageStructHandler_24_3.NativeStructWrapper.LMAf8dNRLuoGXSjhNus();
			}

			// Token: 0x0600054B RID: 1355 RVA: 0x0001B4EC File Offset: 0x000196EC
			internal static bool QFLXFqN11VMtaT0iHs1()
			{
				return NativeImageStructHandler_24_3.NativeStructWrapper.SHdW0bNfQ34LXGLZtCG == null;
			}

			// Token: 0x0600054C RID: 1356 RVA: 0x0001B500 File Offset: 0x00019700
			internal static NativeImageStructHandler_24_3.NativeStructWrapper YJ5i4RNFjtcK3LhVSoy()
			{
				return NativeImageStructHandler_24_3.NativeStructWrapper.SHdW0bNfQ34LXGLZtCG;
			}

			// Token: 0x0600054D RID: 1357 RVA: 0x0001B510 File Offset: 0x00019710
			internal static void LMAf8dNRLuoGXSjhNus()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000249 RID: 585
			private static object SHdW0bNfQ34LXGLZtCG;
		}
	}
}
