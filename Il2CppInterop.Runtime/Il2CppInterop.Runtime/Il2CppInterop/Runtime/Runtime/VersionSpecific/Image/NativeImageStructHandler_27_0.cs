using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x02000091 RID: 145
	[ApplicableToUnityVersionsSince("2020.2.0")]
	public class NativeImageStructHandler_27_0 : INativeImageStructHandler, INativeStructHandler
	{
		// Token: 0x06000581 RID: 1409 RVA: 0x0000FD8C File Offset: 0x0000DF8C
		public int Size()
		{
			return sizeof(NativeImageStructHandler_27_0.Il2CppImage_27_0);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0000FD9C File Offset: 0x0000DF9C
		public unsafe INativeImageStruct CreateNewStruct()
		{
			NativeImageStructHandler_27_0.Il2CppImage_27_0* ptr2;
			IntPtr ptr = ptr2 = NativeImageStructHandler_27_0.OL43HpupmxEBxegEsIf(this.Size());
			*ptr2 = default(NativeImageStructHandler_27_0.Il2CppImage_27_0);
			Il2CppImageGlobalMetadata* ptr3 = NativeImageStructHandler_27_0.OL43HpupmxEBxegEsIf(sizeof(Il2CppImageGlobalMetadata));
			ptr3->image = (Il2CppImage*)ptr2;
			*(IntPtr*)(&ptr2->metadataHandle) = ptr3;
			return new NativeImageStructHandler_27_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000FDEC File Offset: 0x0000DFEC
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_37633ff27b934257920d0d03faf0bd54 != 0)
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
			return new NativeImageStructHandler_27_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0000FE54 File Offset: 0x0000E054
		public NativeImageStructHandler_27_0()
		{
			NativeImageStructHandler_27_0.arrWpOu4g0jutY770F0();
			NativeImageStructHandler_27_0.GdVlgYuzisGLNqZ0HVO();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_82de010761f84d069578c758673e6648 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeImageStructHandler_27_0()
		{
			NativeImageStructHandler_27_0.FlkGd7EHJIfRet9kbpD();
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0000FEC8 File Offset: 0x0000E0C8
		internal static IntPtr OL43HpupmxEBxegEsIf(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0000FEDC File Offset: 0x0000E0DC
		internal static bool dLEgZou1ROS5j78c5DZ()
		{
			return NativeImageStructHandler_27_0.BnCBgQu3mtcnAJg0Mmg == null;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0000FEF0 File Offset: 0x0000E0F0
		internal static NativeImageStructHandler_27_0 j2NCnduM4W3ERr33f83()
		{
			return NativeImageStructHandler_27_0.BnCBgQu3mtcnAJg0Mmg;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0000FF00 File Offset: 0x0000E100
		internal static void arrWpOu4g0jutY770F0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0000FF10 File Offset: 0x0000E110
		internal static void GdVlgYuzisGLNqZ0HVO()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0000FF20 File Offset: 0x0000E120
		internal static void FlkGd7EHJIfRet9kbpD()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000266 RID: 614
		internal static NativeImageStructHandler_27_0 BnCBgQu3mtcnAJg0Mmg;

		// Token: 0x02000092 RID: 146
		internal struct Il2CppImage_27_0
		{
			// Token: 0x04000267 RID: 615
			public unsafe byte* name;

			// Token: 0x04000268 RID: 616
			public unsafe byte* nameNoExt;

			// Token: 0x04000269 RID: 617
			public unsafe Il2CppAssembly* assembly;

			// Token: 0x0400026A RID: 618
			public uint typeCount;

			// Token: 0x0400026B RID: 619
			public uint exportedTypeCount;

			// Token: 0x0400026C RID: 620
			public uint customAttributeCount;

			// Token: 0x0400026D RID: 621
			public Il2CppMetadataImageHandle metadataHandle;

			// Token: 0x0400026E RID: 622
			public unsafe void* nameToClassHashTable;

			// Token: 0x0400026F RID: 623
			public unsafe void* codeGenModule;

			// Token: 0x04000270 RID: 624
			public uint token;

			// Token: 0x04000271 RID: 625
			public byte dynamic;
		}

		// Token: 0x02000093 RID: 147
		internal class NativeStructWrapper : INativeImageStruct, INativeStruct
		{
			// Token: 0x0600058C RID: 1420 RVA: 0x0001C320 File Offset: 0x0001A520
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeImageStructHandler_27_0.NativeStructWrapper.E166mPDc5jLxZnEMyuu();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9a3e85e731764e36a5b07f4e692becd8 == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_17522b2a3ddb488c87b7266d3b1f941d != 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x0600058D RID: 1421 RVA: 0x0001C3B0 File Offset: 0x0001A5B0
			private unsafe NativeImageStructHandler_27_0.Il2CppImage_27_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x0600058E RID: 1422 RVA: 0x0001C3C0 File Offset: 0x0001A5C0
			public IntPtr Pointer { get; }

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x0600058F RID: 1423 RVA: 0x0001C3D0 File Offset: 0x0001A5D0
			public unsafe Il2CppImage* ImagePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x06000590 RID: 1424 RVA: 0x0001C3E0 File Offset: 0x0001A5E0
			public bool HasNameNoExt
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x06000591 RID: 1425 RVA: 0x0001C3EC File Offset: 0x0001A5EC
			public unsafe ref Il2CppAssembly* Assembly
			{
				get
				{
					return ref this._->assembly;
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000592 RID: 1426 RVA: 0x0001C400 File Offset: 0x0001A600
			public unsafe ref byte Dynamic
			{
				get
				{
					return ref this._->dynamic;
				}
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x06000593 RID: 1427 RVA: 0x0001C414 File Offset: 0x0001A614
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x06000594 RID: 1428 RVA: 0x0001C42C File Offset: 0x0001A62C
			public unsafe ref IntPtr NameNoExt
			{
				get
				{
					return ref *(IntPtr*)(&this._->nameNoExt);
				}
			}

			// Token: 0x06000595 RID: 1429 RVA: 0x0001C444 File Offset: 0x0001A644
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeImageStructHandler_27_0.NativeStructWrapper.WhfrKTD6UtIY779m5A5();
			}

			// Token: 0x06000596 RID: 1430 RVA: 0x0001C454 File Offset: 0x0001A654
			internal static void E166mPDc5jLxZnEMyuu()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000597 RID: 1431 RVA: 0x0001C464 File Offset: 0x0001A664
			internal static bool hh2SG2Dur58RvZDvDMd()
			{
				return NativeImageStructHandler_27_0.NativeStructWrapper.HX7QUZDNXKmIUR6aBOs == null;
			}

			// Token: 0x06000598 RID: 1432 RVA: 0x0001C478 File Offset: 0x0001A678
			internal static NativeImageStructHandler_27_0.NativeStructWrapper Db1XVRDENIuE3Hq9Gf9()
			{
				return NativeImageStructHandler_27_0.NativeStructWrapper.HX7QUZDNXKmIUR6aBOs;
			}

			// Token: 0x06000599 RID: 1433 RVA: 0x0001C488 File Offset: 0x0001A688
			internal static void WhfrKTD6UtIY779m5A5()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000273 RID: 627
			private static object HX7QUZDNXKmIUR6aBOs;
		}
	}
}
