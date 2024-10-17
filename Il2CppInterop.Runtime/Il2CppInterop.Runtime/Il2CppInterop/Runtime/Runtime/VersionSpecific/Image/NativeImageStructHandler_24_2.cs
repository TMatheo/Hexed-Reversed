using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x02000088 RID: 136
	[ApplicableToUnityVersionsSince("2018.1.0")]
	public class NativeImageStructHandler_24_2 : INativeImageStructHandler, INativeStructHandler
	{
		// Token: 0x06000538 RID: 1336 RVA: 0x0000F920 File Offset: 0x0000DB20
		public int Size()
		{
			return sizeof(NativeImageStructHandler_24_2.Il2CppImage_24_2);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0000F930 File Offset: 0x0000DB30
		public unsafe INativeImageStruct CreateNewStruct()
		{
			NativeImageStructHandler_24_2.Il2CppImage_24_2* ptr2;
			IntPtr ptr = ptr2 = NativeImageStructHandler_24_2.HWCq5juyYWsyoSX3h2P(this.Size());
			*ptr2 = default(NativeImageStructHandler_24_2.Il2CppImage_24_2);
			return new NativeImageStructHandler_24_2.NativeStructWrapper(ptr);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0000F960 File Offset: 0x0000DB60
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f7e83c7c87bd4de9b4cb2b7f339254ad == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeImageStructHandler_24_2.NativeStructWrapper(ptr);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0000F9C8 File Offset: 0x0000DBC8
		public NativeImageStructHandler_24_2()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeImageStructHandler_24_2.Vpxq6cuSNlayG7j8hxu();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_650e65d7606047fda7d187c401bdfc6e == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0000FA2C File Offset: 0x0000DC2C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeImageStructHandler_24_2()
		{
			NativeImageStructHandler_24_2.BK4H6DugG8JvJgDJQit();
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0000FA3C File Offset: 0x0000DC3C
		internal static IntPtr HWCq5juyYWsyoSX3h2P(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0000FA50 File Offset: 0x0000DC50
		internal static bool VCHVvQuQIkW9NL6mDly()
		{
			return NativeImageStructHandler_24_2.ADLqSTusRHg1aUY81pK == null;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0000FA64 File Offset: 0x0000DC64
		internal static NativeImageStructHandler_24_2 cxyQHZu2SoKuVNkHqxT()
		{
			return NativeImageStructHandler_24_2.ADLqSTusRHg1aUY81pK;
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0000FA74 File Offset: 0x0000DC74
		internal static void Vpxq6cuSNlayG7j8hxu()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0000FA84 File Offset: 0x0000DC84
		internal static void BK4H6DugG8JvJgDJQit()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000237 RID: 567
		internal static NativeImageStructHandler_24_2 ADLqSTusRHg1aUY81pK;

		// Token: 0x02000089 RID: 137
		internal struct Il2CppImage_24_2
		{
			// Token: 0x04000238 RID: 568
			public unsafe byte* name;

			// Token: 0x04000239 RID: 569
			public unsafe byte* nameNoExt;

			// Token: 0x0400023A RID: 570
			public unsafe Il2CppAssembly* assembly;

			// Token: 0x0400023B RID: 571
			public int typeStart;

			// Token: 0x0400023C RID: 572
			public uint typeCount;

			// Token: 0x0400023D RID: 573
			public int exportedTypeStart;

			// Token: 0x0400023E RID: 574
			public uint exportedTypeCount;

			// Token: 0x0400023F RID: 575
			public int entryPointIndex;

			// Token: 0x04000240 RID: 576
			public unsafe void* nameToClassHashTable;

			// Token: 0x04000241 RID: 577
			public uint token;

			// Token: 0x04000242 RID: 578
			public byte dynamic;
		}

		// Token: 0x0200008A RID: 138
		internal class NativeStructWrapper : INativeImageStruct, INativeStruct
		{
			// Token: 0x06000542 RID: 1346 RVA: 0x0001BEB8 File Offset: 0x0001A0B8
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d691a76a9c4746c9a1a67e34c67ca64b != 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_780e0c86b08f49d785f406cf802c7e87 != 0)
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
			// (get) Token: 0x06000543 RID: 1347 RVA: 0x0001BF48 File Offset: 0x0001A148
			private unsafe NativeImageStructHandler_24_2.Il2CppImage_24_2* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x06000544 RID: 1348 RVA: 0x0001BF58 File Offset: 0x0001A158
			public IntPtr Pointer { get; }

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x06000545 RID: 1349 RVA: 0x0001BF68 File Offset: 0x0001A168
			public unsafe Il2CppImage* ImagePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x06000546 RID: 1350 RVA: 0x0001BF78 File Offset: 0x0001A178
			public bool HasNameNoExt
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x06000547 RID: 1351 RVA: 0x0001BF84 File Offset: 0x0001A184
			public unsafe ref Il2CppAssembly* Assembly
			{
				get
				{
					return ref this._->assembly;
				}
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x06000548 RID: 1352 RVA: 0x0001BF98 File Offset: 0x0001A198
			public unsafe ref byte Dynamic
			{
				get
				{
					return ref this._->dynamic;
				}
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x06000549 RID: 1353 RVA: 0x0001BFAC File Offset: 0x0001A1AC
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x0600054A RID: 1354 RVA: 0x0001BFC4 File Offset: 0x0001A1C4
			public unsafe ref IntPtr NameNoExt
			{
				get
				{
					return ref *(IntPtr*)(&this._->nameNoExt);
				}
			}

			// Token: 0x0600054B RID: 1355 RVA: 0x0001BFDC File Offset: 0x0001A1DC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeImageStructHandler_24_2.NativeStructWrapper.gWx45Zr1JTv0Mbwht0X();
			}

			// Token: 0x0600054C RID: 1356 RVA: 0x0001BFEC File Offset: 0x0001A1EC
			internal static bool TmA1Y1rn4aQJ8mxwjI5()
			{
				return NativeImageStructHandler_24_2.NativeStructWrapper.z6vWONr5RqEDlfDBAUN == null;
			}

			// Token: 0x0600054D RID: 1357 RVA: 0x0001C000 File Offset: 0x0001A200
			internal static NativeImageStructHandler_24_2.NativeStructWrapper ERaoamr32YXE88Th9rv()
			{
				return NativeImageStructHandler_24_2.NativeStructWrapper.z6vWONr5RqEDlfDBAUN;
			}

			// Token: 0x0600054E RID: 1358 RVA: 0x0001C010 File Offset: 0x0001A210
			internal static void gWx45Zr1JTv0Mbwht0X()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000244 RID: 580
			internal static object z6vWONr5RqEDlfDBAUN;
		}
	}
}
