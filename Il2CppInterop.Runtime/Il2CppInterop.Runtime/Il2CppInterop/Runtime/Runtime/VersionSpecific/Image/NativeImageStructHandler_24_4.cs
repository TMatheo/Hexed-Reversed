using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x0200008E RID: 142
	[ApplicableToUnityVersionsSince("2019.1.0")]
	public class NativeImageStructHandler_24_4 : INativeImageStructHandler, INativeStructHandler
	{
		// Token: 0x06000568 RID: 1384 RVA: 0x0000FC18 File Offset: 0x0000DE18
		public int Size()
		{
			return sizeof(NativeImageStructHandler_24_4.Il2CppImage_24_4);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0000FC28 File Offset: 0x0000DE28
		public unsafe INativeImageStruct CreateNewStruct()
		{
			NativeImageStructHandler_24_4.Il2CppImage_24_4* ptr2;
			IntPtr ptr = ptr2 = NativeImageStructHandler_24_4.FRFOeYuKES95WDRgpfZ(this.Size());
			*ptr2 = default(NativeImageStructHandler_24_4.Il2CppImage_24_4);
			return new NativeImageStructHandler_24_4.NativeStructWrapper(ptr);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0000FC58 File Offset: 0x0000DE58
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ef7f3142723b424fb42b4125f902e28b == 0)
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

		// Token: 0x0600056B RID: 1387 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		public NativeImageStructHandler_24_4()
		{
			NativeImageStructHandler_24_4.I6J1imu5lS0VjqwyCW9();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c32cfeb41f7a43999be3bae16a94ad02 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0000FD24 File Offset: 0x0000DF24
		// Note: this type is marked as 'beforefieldinit'.
		static NativeImageStructHandler_24_4()
		{
			NativeImageStructHandler_24_4.AJaL8GunQFiAxitQPFV();
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0000FD34 File Offset: 0x0000DF34
		internal static IntPtr FRFOeYuKES95WDRgpfZ(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0000FD48 File Offset: 0x0000DF48
		internal static bool hwZfH8uTy8GItIfCZk9()
		{
			return NativeImageStructHandler_24_4.Wm53bwujl6I7lauDlFx == null;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0000FD5C File Offset: 0x0000DF5C
		internal static NativeImageStructHandler_24_4 qqBjP0uFHqebfhrO6Ut()
		{
			return NativeImageStructHandler_24_4.Wm53bwujl6I7lauDlFx;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0000FD6C File Offset: 0x0000DF6C
		internal static void I6J1imu5lS0VjqwyCW9()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0000FD7C File Offset: 0x0000DF7C
		internal static void AJaL8GunQFiAxitQPFV()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000255 RID: 597
		private static NativeImageStructHandler_24_4 Wm53bwujl6I7lauDlFx;

		// Token: 0x0200008F RID: 143
		internal struct Il2CppImage_24_4
		{
			// Token: 0x04000256 RID: 598
			public unsafe byte* name;

			// Token: 0x04000257 RID: 599
			public unsafe byte* nameNoExt;

			// Token: 0x04000258 RID: 600
			public unsafe Il2CppAssembly* assembly;

			// Token: 0x04000259 RID: 601
			public int typeStart;

			// Token: 0x0400025A RID: 602
			public uint typeCount;

			// Token: 0x0400025B RID: 603
			public int exportedTypeStart;

			// Token: 0x0400025C RID: 604
			public uint exportedTypeCount;

			// Token: 0x0400025D RID: 605
			public int customAttributeStart;

			// Token: 0x0400025E RID: 606
			public uint customAttributeCount;

			// Token: 0x0400025F RID: 607
			public int entryPointIndex;

			// Token: 0x04000260 RID: 608
			public unsafe void* nameToClassHashTable;

			// Token: 0x04000261 RID: 609
			public unsafe void* codeGenModule;

			// Token: 0x04000262 RID: 610
			public uint token;

			// Token: 0x04000263 RID: 611
			public byte dynamic;
		}

		// Token: 0x02000090 RID: 144
		internal class NativeStructWrapper : INativeImageStruct, INativeStruct
		{
			// Token: 0x06000572 RID: 1394 RVA: 0x0001C198 File Offset: 0x0001A398
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeImageStructHandler_24_4.NativeStructWrapper.koqrrXDCPdf9Jrc5dl5();
				NativeImageStructHandler_24_4.NativeStructWrapper.c3GyIfDtYwuLYLO3Bcv();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_feee416e61094c739ba253659ac2e257 == 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						this.<Pointer>k__BackingField = ptr;
						num = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b3f1fcfa11104bd49a7f00386d38b4f4 == 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x06000573 RID: 1395 RVA: 0x0001C228 File Offset: 0x0001A428
			private unsafe NativeImageStructHandler_24_4.Il2CppImage_24_4* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x06000574 RID: 1396 RVA: 0x0001C238 File Offset: 0x0001A438
			public IntPtr Pointer { get; }

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x06000575 RID: 1397 RVA: 0x0001C248 File Offset: 0x0001A448
			public unsafe Il2CppImage* ImagePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x06000576 RID: 1398 RVA: 0x0001C258 File Offset: 0x0001A458
			public bool HasNameNoExt
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x06000577 RID: 1399 RVA: 0x0001C264 File Offset: 0x0001A464
			public unsafe ref Il2CppAssembly* Assembly
			{
				get
				{
					return ref this._->assembly;
				}
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x06000578 RID: 1400 RVA: 0x0001C278 File Offset: 0x0001A478
			public unsafe ref byte Dynamic
			{
				get
				{
					return ref this._->dynamic;
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000579 RID: 1401 RVA: 0x0001C28C File Offset: 0x0001A48C
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x0600057A RID: 1402 RVA: 0x0001C2A4 File Offset: 0x0001A4A4
			public unsafe ref IntPtr NameNoExt
			{
				get
				{
					return ref *(IntPtr*)(&this._->nameNoExt);
				}
			}

			// Token: 0x0600057B RID: 1403 RVA: 0x0001C2BC File Offset: 0x0001A4BC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeImageStructHandler_24_4.NativeStructWrapper.lDUH9DDxyPOnq52grH4();
			}

			// Token: 0x0600057C RID: 1404 RVA: 0x0001C2CC File Offset: 0x0001A4CC
			internal static void koqrrXDCPdf9Jrc5dl5()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600057D RID: 1405 RVA: 0x0001C2DC File Offset: 0x0001A4DC
			internal static void c3GyIfDtYwuLYLO3Bcv()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x0600057E RID: 1406 RVA: 0x0001C2EC File Offset: 0x0001A4EC
			internal static bool qqngqrDYNeJIjpsyjdj()
			{
				return NativeImageStructHandler_24_4.NativeStructWrapper.yPLuiZDGgEwO9Y01BQf == null;
			}

			// Token: 0x0600057F RID: 1407 RVA: 0x0001C300 File Offset: 0x0001A500
			internal static NativeImageStructHandler_24_4.NativeStructWrapper cSOAqGDaJIN0Svpsejs()
			{
				return NativeImageStructHandler_24_4.NativeStructWrapper.yPLuiZDGgEwO9Y01BQf;
			}

			// Token: 0x06000580 RID: 1408 RVA: 0x0001C310 File Offset: 0x0001A510
			internal static void lDUH9DDxyPOnq52grH4()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000265 RID: 613
			internal static object yPLuiZDGgEwO9Y01BQf;
		}
	}
}
