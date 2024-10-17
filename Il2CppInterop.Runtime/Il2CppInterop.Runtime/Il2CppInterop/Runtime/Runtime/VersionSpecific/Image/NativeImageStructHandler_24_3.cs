using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x0200008B RID: 139
	[ApplicableToUnityVersionsSince("2018.3.0")]
	public class NativeImageStructHandler_24_3 : INativeImageStructHandler, INativeStructHandler
	{
		// Token: 0x0600054F RID: 1359 RVA: 0x0000FA94 File Offset: 0x0000DC94
		public int Size()
		{
			return sizeof(NativeImageStructHandler_24_3.Il2CppImage_24_3);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0000FAA4 File Offset: 0x0000DCA4
		public unsafe INativeImageStruct CreateNewStruct()
		{
			NativeImageStructHandler_24_3.Il2CppImage_24_3* ptr2;
			IntPtr ptr = ptr2 = NativeImageStructHandler_24_3.B2jgGtuXx0q9QWmbuYC(this.Size());
			*ptr2 = default(NativeImageStructHandler_24_3.Il2CppImage_24_3);
			return new NativeImageStructHandler_24_3.NativeStructWrapper(ptr);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0000FAD4 File Offset: 0x0000DCD4
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e0435cb0909b493e882d051900e9ae38 == 0)
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

		// Token: 0x06000552 RID: 1362 RVA: 0x0000FB3C File Offset: 0x0000DD3C
		public NativeImageStructHandler_24_3()
		{
			NativeImageStructHandler_24_3.xdqnAgumiKRSku3WFCY();
			NativeImageStructHandler_24_3.OS1p7MuvsFwCPMUBiXk();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_feee416e61094c739ba253659ac2e257 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeImageStructHandler_24_3()
		{
			NativeImageStructHandler_24_3.SttgUSuBKgANdF73pyo();
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0000FBB0 File Offset: 0x0000DDB0
		internal static IntPtr B2jgGtuXx0q9QWmbuYC(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0000FBC4 File Offset: 0x0000DDC4
		internal static bool ddQrEluV4iuF3XBvLvG()
		{
			return NativeImageStructHandler_24_3.TjOAgnulj1LrmjDqpYv == null;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000FBD8 File Offset: 0x0000DDD8
		internal static NativeImageStructHandler_24_3 grJvcJuOThQqC8LvHaA()
		{
			return NativeImageStructHandler_24_3.TjOAgnulj1LrmjDqpYv;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		internal static void xdqnAgumiKRSku3WFCY()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0000FBF8 File Offset: 0x0000DDF8
		internal static void OS1p7MuvsFwCPMUBiXk()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0000FC08 File Offset: 0x0000DE08
		internal static void SttgUSuBKgANdF73pyo()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000245 RID: 581
		internal static NativeImageStructHandler_24_3 TjOAgnulj1LrmjDqpYv;

		// Token: 0x0200008C RID: 140
		internal struct Il2CppImage_24_3
		{
			// Token: 0x04000246 RID: 582
			public unsafe byte* name;

			// Token: 0x04000247 RID: 583
			public unsafe byte* nameNoExt;

			// Token: 0x04000248 RID: 584
			public unsafe Il2CppAssembly* assembly;

			// Token: 0x04000249 RID: 585
			public int typeStart;

			// Token: 0x0400024A RID: 586
			public uint typeCount;

			// Token: 0x0400024B RID: 587
			public int exportedTypeStart;

			// Token: 0x0400024C RID: 588
			public uint exportedTypeCount;

			// Token: 0x0400024D RID: 589
			public int customAttributeStart;

			// Token: 0x0400024E RID: 590
			public uint customAttributeCount;

			// Token: 0x0400024F RID: 591
			public int entryPointIndex;

			// Token: 0x04000250 RID: 592
			public unsafe void* nameToClassHashTable;

			// Token: 0x04000251 RID: 593
			public uint token;

			// Token: 0x04000252 RID: 594
			public byte dynamic;
		}

		// Token: 0x0200008D RID: 141
		internal class NativeStructWrapper : INativeImageStruct, INativeStruct
		{
			// Token: 0x0600055A RID: 1370 RVA: 0x0001C020 File Offset: 0x0001A220
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeImageStructHandler_24_3.NativeStructWrapper.BGyf6aDUygmQDyluHEg();
				NativeImageStructHandler_24_3.NativeStructWrapper.dLKuQ9DqWdGeFsRC5QQ();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2f48f5515514b5a9a5feed6dc9a8dce == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_74d61b1611df4615bd4df289712ea178 == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x0600055B RID: 1371 RVA: 0x0001C0B0 File Offset: 0x0001A2B0
			private unsafe NativeImageStructHandler_24_3.Il2CppImage_24_3* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x0600055C RID: 1372 RVA: 0x0001C0C0 File Offset: 0x0001A2C0
			public IntPtr Pointer { get; }

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x0600055D RID: 1373 RVA: 0x0001C0D0 File Offset: 0x0001A2D0
			public unsafe Il2CppImage* ImagePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x0600055E RID: 1374 RVA: 0x0001C0E0 File Offset: 0x0001A2E0
			public bool HasNameNoExt
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x0600055F RID: 1375 RVA: 0x0001C0EC File Offset: 0x0001A2EC
			public unsafe ref Il2CppAssembly* Assembly
			{
				get
				{
					return ref this._->assembly;
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000560 RID: 1376 RVA: 0x0001C100 File Offset: 0x0001A300
			public unsafe ref byte Dynamic
			{
				get
				{
					return ref this._->dynamic;
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x06000561 RID: 1377 RVA: 0x0001C114 File Offset: 0x0001A314
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x06000562 RID: 1378 RVA: 0x0001C12C File Offset: 0x0001A32C
			public unsafe ref IntPtr NameNoExt
			{
				get
				{
					return ref *(IntPtr*)(&this._->nameNoExt);
				}
			}

			// Token: 0x06000563 RID: 1379 RVA: 0x0001C144 File Offset: 0x0001A344
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000564 RID: 1380 RVA: 0x0001C154 File Offset: 0x0001A354
			internal static void BGyf6aDUygmQDyluHEg()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000565 RID: 1381 RVA: 0x0001C164 File Offset: 0x0001A364
			internal static void dLKuQ9DqWdGeFsRC5QQ()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000566 RID: 1382 RVA: 0x0001C174 File Offset: 0x0001A374
			internal static bool mTnmhHDHk3f8DIFYaUh()
			{
				return NativeImageStructHandler_24_3.NativeStructWrapper.sSgXaSrzpEQaVEpyDPh == null;
			}

			// Token: 0x06000567 RID: 1383 RVA: 0x0001C188 File Offset: 0x0001A388
			internal static NativeImageStructHandler_24_3.NativeStructWrapper MwD1oNDAMv4P98PCIKo()
			{
				return NativeImageStructHandler_24_3.NativeStructWrapper.sSgXaSrzpEQaVEpyDPh;
			}

			// Token: 0x04000254 RID: 596
			internal static object sSgXaSrzpEQaVEpyDPh;
		}
	}
}
