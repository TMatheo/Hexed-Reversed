using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x02000085 RID: 133
	[ApplicableToUnityVersionsSince("2017.1.3")]
	public class NativeImageStructHandler_24_1 : INativeImageStructHandler, INativeStructHandler
	{
		// Token: 0x06000520 RID: 1312 RVA: 0x0000F79C File Offset: 0x0000D99C
		public int Size()
		{
			return sizeof(NativeImageStructHandler_24_1.Il2CppImage_24_1);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0000F7AC File Offset: 0x0000D9AC
		public unsafe INativeImageStruct CreateNewStruct()
		{
			NativeImageStructHandler_24_1.Il2CppImage_24_1* ptr2;
			IntPtr ptr = ptr2 = NativeImageStructHandler_24_1.l4JoRIuPI5ZRRneWrUg(this.Size());
			*ptr2 = default(NativeImageStructHandler_24_1.Il2CppImage_24_1);
			return new NativeImageStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0000F7DC File Offset: 0x0000D9DC
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_330a825ae0544050af4112bb9a37f6bb != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeImageStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0000F844 File Offset: 0x0000DA44
		public NativeImageStructHandler_24_1()
		{
			NativeImageStructHandler_24_1.fiCJC0udeVesWqtPJmw();
			NativeImageStructHandler_24_1.EdiNd2uwwrWaU2pYOTX();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_dbbda98ba6574101bc623ad559f7b5a3 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0000F8A8 File Offset: 0x0000DAA8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeImageStructHandler_24_1()
		{
			NativeImageStructHandler_24_1.qvUj2bueWqSTH4kiWWU();
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
		internal static IntPtr l4JoRIuPI5ZRRneWrUg(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0000F8CC File Offset: 0x0000DACC
		internal static bool AgytP4ub20gPKFGdTE7()
		{
			return NativeImageStructHandler_24_1.BmOpfeuoBowirYimUif == null;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0000F8E0 File Offset: 0x0000DAE0
		internal static NativeImageStructHandler_24_1 tWcLO1ufYaJTkn4gXlO()
		{
			return NativeImageStructHandler_24_1.BmOpfeuoBowirYimUif;
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0000F8F0 File Offset: 0x0000DAF0
		internal static void fiCJC0udeVesWqtPJmw()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0000F900 File Offset: 0x0000DB00
		internal static void EdiNd2uwwrWaU2pYOTX()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0000F910 File Offset: 0x0000DB10
		internal static void qvUj2bueWqSTH4kiWWU()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000229 RID: 553
		internal static NativeImageStructHandler_24_1 BmOpfeuoBowirYimUif;

		// Token: 0x02000086 RID: 134
		internal struct Il2CppImage_24_1
		{
			// Token: 0x0400022A RID: 554
			public unsafe byte* name;

			// Token: 0x0400022B RID: 555
			public unsafe byte* nameNoExt;

			// Token: 0x0400022C RID: 556
			public int assemblyIndex;

			// Token: 0x0400022D RID: 557
			public int typeStart;

			// Token: 0x0400022E RID: 558
			public uint typeCount;

			// Token: 0x0400022F RID: 559
			public int exportedTypeStart;

			// Token: 0x04000230 RID: 560
			public uint exportedTypeCount;

			// Token: 0x04000231 RID: 561
			public int entryPointIndex;

			// Token: 0x04000232 RID: 562
			public unsafe void* nameToClassHashTable;

			// Token: 0x04000233 RID: 563
			public uint token;
		}

		// Token: 0x02000087 RID: 135
		internal class NativeStructWrapper : INativeImageStruct, INativeStruct
		{
			// Token: 0x0600052B RID: 1323 RVA: 0x0001BD58 File Offset: 0x00019F58
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeImageStructHandler_24_1.NativeStructWrapper.ctB8Afrjj99qHqcHPur();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_650e65d7606047fda7d187c401bdfc6e == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_570d4e075bf443fcbaca8db32e007291 == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x0600052C RID: 1324 RVA: 0x0001BDE8 File Offset: 0x00019FE8
			private unsafe NativeImageStructHandler_24_1.Il2CppImage_24_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x0600052D RID: 1325 RVA: 0x0001BDF8 File Offset: 0x00019FF8
			public IntPtr Pointer { get; }

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x0600052E RID: 1326 RVA: 0x0001BE08 File Offset: 0x0001A008
			public unsafe Il2CppImage* ImagePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x0600052F RID: 1327 RVA: 0x0001BE18 File Offset: 0x0001A018
			public bool HasNameNoExt
			{
				get
				{
					return true;
				}
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x06000530 RID: 1328 RVA: 0x0001BE24 File Offset: 0x0001A024
			public unsafe ref Il2CppAssembly* Assembly
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x06000531 RID: 1329 RVA: 0x0001BE34 File Offset: 0x0001A034
			public ref byte Dynamic
			{
				get
				{
					return ref this._dynamicDummy;
				}
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x06000532 RID: 1330 RVA: 0x0001BE44 File Offset: 0x0001A044
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x06000533 RID: 1331 RVA: 0x0001BE5C File Offset: 0x0001A05C
			public unsafe ref IntPtr NameNoExt
			{
				get
				{
					return ref *(IntPtr*)(&this._->nameNoExt);
				}
			}

			// Token: 0x06000534 RID: 1332 RVA: 0x0001BE74 File Offset: 0x0001A074
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x0001BE84 File Offset: 0x0001A084
			internal static void ctB8Afrjj99qHqcHPur()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000536 RID: 1334 RVA: 0x0001BE94 File Offset: 0x0001A094
			internal static bool E779nDrvD3pBIXi5BBK()
			{
				return NativeImageStructHandler_24_1.NativeStructWrapper.Ylfuc7rmfyinDNGB3Ge == null;
			}

			// Token: 0x06000537 RID: 1335 RVA: 0x0001BEA8 File Offset: 0x0001A0A8
			internal static NativeImageStructHandler_24_1.NativeStructWrapper XCW9eurBw3deV67dqoM()
			{
				return NativeImageStructHandler_24_1.NativeStructWrapper.Ylfuc7rmfyinDNGB3Ge;
			}

			// Token: 0x04000234 RID: 564
			private byte _dynamicDummy;

			// Token: 0x04000236 RID: 566
			private static object Ylfuc7rmfyinDNGB3Ge;
		}
	}
}
