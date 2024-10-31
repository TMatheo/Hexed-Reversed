using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x02000083 RID: 131
	[ApplicableToUnityVersionsSince("2017.1.3")]
	public class NativeImageStructHandler_24_1 : INativeImageStructHandler, INativeStructHandler
	{
		// Token: 0x06000503 RID: 1283 RVA: 0x0000EB9C File Offset: 0x0000CD9C
		public int Size()
		{
			return sizeof(NativeImageStructHandler_24_1.Il2CppImage_24_1);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0000EBAC File Offset: 0x0000CDAC
		public unsafe INativeImageStruct CreateNewStruct()
		{
			NativeImageStructHandler_24_1.Il2CppImage_24_1* ptr2;
			IntPtr ptr = ptr2 = NativeImageStructHandler_24_1.lR3lxvn8bocOuAbP9kw(this.Size());
			*ptr2 = default(NativeImageStructHandler_24_1.Il2CppImage_24_1);
			return new NativeImageStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0000EBDC File Offset: 0x0000CDDC
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2356ac6ca5954f1897cd5bbbe0161ae5 == 0)
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
			return new NativeImageStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0000EC44 File Offset: 0x0000CE44
		public NativeImageStructHandler_24_1()
		{
			NativeImageStructHandler_24_1.qQgflpnn2Fk4GEW8ZbI();
			NativeImageStructHandler_24_1.AFEfWPnbBGR0u6rY0RC();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6e0b93a59f7244c4b07385ec95383bee == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0000ECA8 File Offset: 0x0000CEA8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeImageStructHandler_24_1()
		{
			NativeImageStructHandler_24_1.PR6NRvn68PD5irU9w3h();
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		internal static IntPtr lR3lxvn8bocOuAbP9kw(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0000ECCC File Offset: 0x0000CECC
		internal static bool YkZPFWnx6TooAtfbt5W()
		{
			return NativeImageStructHandler_24_1.x1ojo8nvvPD5oi7GtHL == null;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0000ECE0 File Offset: 0x0000CEE0
		internal static NativeImageStructHandler_24_1 vjkJ3mnYlRBwfpc3oyl()
		{
			return NativeImageStructHandler_24_1.x1ojo8nvvPD5oi7GtHL;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0000ECF0 File Offset: 0x0000CEF0
		internal static void qQgflpnn2Fk4GEW8ZbI()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0000ED00 File Offset: 0x0000CF00
		internal static void AFEfWPnbBGR0u6rY0RC()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0000ED10 File Offset: 0x0000CF10
		internal static void PR6NRvn68PD5irU9w3h()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400021E RID: 542
		internal static NativeImageStructHandler_24_1 x1ojo8nvvPD5oi7GtHL;

		// Token: 0x02000084 RID: 132
		internal struct Il2CppImage_24_1
		{
			// Token: 0x0400021F RID: 543
			public unsafe byte* name;

			// Token: 0x04000220 RID: 544
			public unsafe byte* nameNoExt;

			// Token: 0x04000221 RID: 545
			public int assemblyIndex;

			// Token: 0x04000222 RID: 546
			public int typeStart;

			// Token: 0x04000223 RID: 547
			public uint typeCount;

			// Token: 0x04000224 RID: 548
			public int exportedTypeStart;

			// Token: 0x04000225 RID: 549
			public uint exportedTypeCount;

			// Token: 0x04000226 RID: 550
			public int entryPointIndex;

			// Token: 0x04000227 RID: 551
			public unsafe void* nameToClassHashTable;

			// Token: 0x04000228 RID: 552
			public uint token;
		}

		// Token: 0x02000085 RID: 133
		internal class NativeStructWrapper : INativeImageStruct, INativeStruct
		{
			// Token: 0x0600050E RID: 1294 RVA: 0x0001B0B0 File Offset: 0x000192B0
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeImageStructHandler_24_1.NativeStructWrapper.xEU2qcNyMedxFK9i59k();
				NativeImageStructHandler_24_1.NativeStructWrapper.QFsLoZNJj2lFuQWPBYY();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6d9238cad9434518b97d223669b8fe50 != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_fe27a6a8bfb848d1a3dd32bc5b1790e7 != 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x0600050F RID: 1295 RVA: 0x0001B140 File Offset: 0x00019340
			private unsafe NativeImageStructHandler_24_1.Il2CppImage_24_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x06000510 RID: 1296 RVA: 0x0001B150 File Offset: 0x00019350
			public IntPtr Pointer { get; }

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x06000511 RID: 1297 RVA: 0x0001B160 File Offset: 0x00019360
			public unsafe Il2CppImage* ImagePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x06000512 RID: 1298 RVA: 0x0001B170 File Offset: 0x00019370
			public bool HasNameNoExt
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x06000513 RID: 1299 RVA: 0x0001B17C File Offset: 0x0001937C
			public unsafe ref Il2CppAssembly* Assembly
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x06000514 RID: 1300 RVA: 0x0001B18C File Offset: 0x0001938C
			public ref byte Dynamic
			{
				get
				{
					return ref this._dynamicDummy;
				}
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x06000515 RID: 1301 RVA: 0x0001B19C File Offset: 0x0001939C
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x06000516 RID: 1302 RVA: 0x0001B1B4 File Offset: 0x000193B4
			public unsafe ref IntPtr NameNoExt
			{
				get
				{
					return ref *(IntPtr*)(&this._->nameNoExt);
				}
			}

			// Token: 0x06000517 RID: 1303 RVA: 0x0001B1CC File Offset: 0x000193CC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeImageStructHandler_24_1.NativeStructWrapper.hLT7YeNp1JNhiI2lgqS();
			}

			// Token: 0x06000518 RID: 1304 RVA: 0x0001B1DC File Offset: 0x000193DC
			internal static void xEU2qcNyMedxFK9i59k()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000519 RID: 1305 RVA: 0x0001B1EC File Offset: 0x000193EC
			internal static void QFsLoZNJj2lFuQWPBYY()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x0600051A RID: 1306 RVA: 0x0001B1FC File Offset: 0x000193FC
			internal static bool ka9SvWNbGEqNfbL6Pnr()
			{
				return NativeImageStructHandler_24_1.NativeStructWrapper.wKnTQhNnhZAPNLTULOP == null;
			}

			// Token: 0x0600051B RID: 1307 RVA: 0x0001B210 File Offset: 0x00019410
			internal static NativeImageStructHandler_24_1.NativeStructWrapper NYtQg8N6X3WECxq3AtP()
			{
				return NativeImageStructHandler_24_1.NativeStructWrapper.wKnTQhNnhZAPNLTULOP;
			}

			// Token: 0x0600051C RID: 1308 RVA: 0x0001B220 File Offset: 0x00019420
			internal static void hLT7YeNp1JNhiI2lgqS()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000229 RID: 553
			private byte _dynamicDummy;

			// Token: 0x0400022B RID: 555
			private static object wKnTQhNnhZAPNLTULOP;
		}
	}
}
