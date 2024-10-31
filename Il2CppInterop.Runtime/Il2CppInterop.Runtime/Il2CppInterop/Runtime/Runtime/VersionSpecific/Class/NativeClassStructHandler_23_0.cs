using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000D7 RID: 215
	[ApplicableToUnityVersionsSince("5.6.0")]
	public class NativeClassStructHandler_23_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x0600088C RID: 2188 RVA: 0x0001104C File Offset: 0x0000F24C
		public int Size()
		{
			return sizeof(NativeClassStructHandler_23_0.Il2CppClass_23_0);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0001105C File Offset: 0x0000F25C
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_23_0.Il2CppClass_23_0* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_23_0.kL0kYVylrsM9a8xFZfS(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_23_0.Il2CppClass_23_0);
			ptr2->byval_arg = UnityVersionHandler.NewType().TypePointer;
			ptr2->this_arg = ((INativeTypeStruct)NativeClassStructHandler_23_0.MJMyC5yqmtB1XctBRvm()).TypePointer;
			return new NativeClassStructHandler_23_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x000110B8 File Offset: 0x0000F2B8
		public unsafe INativeClassStruct Wrap(Il2CppClass* ptr)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5395ed2b7ead4e349835ba3f56e39138 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeClassStructHandler_23_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00011120 File Offset: 0x0000F320
		public NativeClassStructHandler_23_0()
		{
			NativeClassStructHandler_23_0.BOhJW5y58HJ5jpIM1WZ();
			NativeClassStructHandler_23_0.paxWYMyAo3cLuUAZL69();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7ac65c3fd4cb4629a8b893be89aed17d == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00011184 File Offset: 0x0000F384
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_23_0()
		{
			NativeClassStructHandler_23_0.GvK3BXyLPy5CTP61saZ();
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00011194 File Offset: 0x0000F394
		internal static IntPtr kL0kYVylrsM9a8xFZfS(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x000111A8 File Offset: 0x0000F3A8
		internal static object MJMyC5yqmtB1XctBRvm()
		{
			return UnityVersionHandler.NewType();
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x000111B8 File Offset: 0x0000F3B8
		internal static bool HRZSNn6Zl0pNaT5yyRf()
		{
			return NativeClassStructHandler_23_0.mSVbFt6a4T0QkxN7PZV == null;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000111CC File Offset: 0x0000F3CC
		internal static NativeClassStructHandler_23_0 pfbCvB6zWxbZiF5qhFI()
		{
			return NativeClassStructHandler_23_0.mSVbFt6a4T0QkxN7PZV;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x000111DC File Offset: 0x0000F3DC
		internal static void BOhJW5y58HJ5jpIM1WZ()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x000111EC File Offset: 0x0000F3EC
		internal static void paxWYMyAo3cLuUAZL69()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x000111FC File Offset: 0x0000F3FC
		internal static void GvK3BXyLPy5CTP61saZ()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000516 RID: 1302
		internal static NativeClassStructHandler_23_0 mSVbFt6a4T0QkxN7PZV;

		// Token: 0x020000D8 RID: 216
		internal struct Il2CppClass_23_0
		{
			// Token: 0x04000517 RID: 1303
			public unsafe Il2CppImage* image;

			// Token: 0x04000518 RID: 1304
			public unsafe void* gc_desc;

			// Token: 0x04000519 RID: 1305
			public unsafe byte* name;

			// Token: 0x0400051A RID: 1306
			public unsafe byte* namespaze;

			// Token: 0x0400051B RID: 1307
			public unsafe Il2CppTypeStruct* byval_arg;

			// Token: 0x0400051C RID: 1308
			public unsafe Il2CppTypeStruct* this_arg;

			// Token: 0x0400051D RID: 1309
			public unsafe Il2CppClass* element_class;

			// Token: 0x0400051E RID: 1310
			public unsafe Il2CppClass* castClass;

			// Token: 0x0400051F RID: 1311
			public unsafe Il2CppClass* declaringType;

			// Token: 0x04000520 RID: 1312
			public unsafe Il2CppClass* parent;

			// Token: 0x04000521 RID: 1313
			public unsafe void* generic_class;

			// Token: 0x04000522 RID: 1314
			public unsafe void* typeDefinition;

			// Token: 0x04000523 RID: 1315
			public unsafe void* interopData;

			// Token: 0x04000524 RID: 1316
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x04000525 RID: 1317
			public unsafe Il2CppEventInfo* events;

			// Token: 0x04000526 RID: 1318
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000527 RID: 1319
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x04000528 RID: 1320
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000529 RID: 1321
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x0400052A RID: 1322
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x0400052B RID: 1323
			public unsafe void* static_fields;

			// Token: 0x0400052C RID: 1324
			public unsafe void* rgctx_data;

			// Token: 0x0400052D RID: 1325
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x0400052E RID: 1326
			public uint cctor_started;

			// Token: 0x0400052F RID: 1327
			public uint cctor_finished;

			// Token: 0x04000530 RID: 1328
			public ulong cctor_thread;

			// Token: 0x04000531 RID: 1329
			public int genericContainerIndex;

			// Token: 0x04000532 RID: 1330
			public int customAttributeIndex;

			// Token: 0x04000533 RID: 1331
			public uint instance_size;

			// Token: 0x04000534 RID: 1332
			public uint actualSize;

			// Token: 0x04000535 RID: 1333
			public uint element_size;

			// Token: 0x04000536 RID: 1334
			public int native_size;

			// Token: 0x04000537 RID: 1335
			public uint static_fields_size;

			// Token: 0x04000538 RID: 1336
			public uint thread_static_fields_size;

			// Token: 0x04000539 RID: 1337
			public int thread_static_fields_offset;

			// Token: 0x0400053A RID: 1338
			public uint flags;

			// Token: 0x0400053B RID: 1339
			public uint token;

			// Token: 0x0400053C RID: 1340
			public ushort method_count;

			// Token: 0x0400053D RID: 1341
			public ushort property_count;

			// Token: 0x0400053E RID: 1342
			public ushort field_count;

			// Token: 0x0400053F RID: 1343
			public ushort event_count;

			// Token: 0x04000540 RID: 1344
			public ushort nested_type_count;

			// Token: 0x04000541 RID: 1345
			public ushort vtable_count;

			// Token: 0x04000542 RID: 1346
			public ushort interfaces_count;

			// Token: 0x04000543 RID: 1347
			public ushort interface_offsets_count;

			// Token: 0x04000544 RID: 1348
			public byte typeHierarchyDepth;

			// Token: 0x04000545 RID: 1349
			public byte genericRecursionDepth;

			// Token: 0x04000546 RID: 1350
			public byte rank;

			// Token: 0x04000547 RID: 1351
			public byte minimumAlignment;

			// Token: 0x04000548 RID: 1352
			public byte packingSize;

			// Token: 0x04000549 RID: 1353
			public NativeClassStructHandler_23_0.Il2CppClass_23_0.Bitfield0 _bitfield0;

			// Token: 0x020000D9 RID: 217
			internal enum Bitfield0 : ushort
			{
				// Token: 0x0400054B RID: 1355
				BIT_valuetype,
				// Token: 0x0400054C RID: 1356
				valuetype,
				// Token: 0x0400054D RID: 1357
				BIT_initialized = 1,
				// Token: 0x0400054E RID: 1358
				initialized,
				// Token: 0x0400054F RID: 1359
				BIT_enumtype = 2,
				// Token: 0x04000550 RID: 1360
				enumtype = 4,
				// Token: 0x04000551 RID: 1361
				BIT_is_generic = 3,
				// Token: 0x04000552 RID: 1362
				is_generic = 8,
				// Token: 0x04000553 RID: 1363
				BIT_has_references = 4,
				// Token: 0x04000554 RID: 1364
				has_references = 16,
				// Token: 0x04000555 RID: 1365
				BIT_init_pending = 5,
				// Token: 0x04000556 RID: 1366
				init_pending = 32,
				// Token: 0x04000557 RID: 1367
				BIT_size_inited = 6,
				// Token: 0x04000558 RID: 1368
				size_inited = 64,
				// Token: 0x04000559 RID: 1369
				BIT_has_finalize = 7,
				// Token: 0x0400055A RID: 1370
				has_finalize = 128,
				// Token: 0x0400055B RID: 1371
				BIT_has_cctor = 8,
				// Token: 0x0400055C RID: 1372
				has_cctor = 256,
				// Token: 0x0400055D RID: 1373
				BIT_is_blittable = 9,
				// Token: 0x0400055E RID: 1374
				is_blittable = 512,
				// Token: 0x0400055F RID: 1375
				BIT_is_import_or_windows_runtime = 10,
				// Token: 0x04000560 RID: 1376
				is_import_or_windows_runtime = 1024,
				// Token: 0x04000561 RID: 1377
				BIT_is_vtable_initialized = 11,
				// Token: 0x04000562 RID: 1378
				is_vtable_initialized = 2048
			}
		}

		// Token: 0x020000DA RID: 218
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000898 RID: 2200 RVA: 0x00020334 File Offset: 0x0001E534
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_23_0.NativeStructWrapper.e0wamDmgXD2Ph8GRUcd();
				NativeClassStructHandler_23_0.NativeStructWrapper.jZjMGsmo5RsXgBY8JB4();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c04403f838344b38b3a8911774a446ea == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2ec67b9ff6c4cd7af2a4ceec32c111c == 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x06000899 RID: 2201 RVA: 0x000203C4 File Offset: 0x0001E5C4
			private unsafe NativeClassStructHandler_23_0.Il2CppClass_23_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170002A3 RID: 675
			// (get) Token: 0x0600089A RID: 2202 RVA: 0x000203D4 File Offset: 0x0001E5D4
			// (set) Token: 0x0600089B RID: 2203 RVA: 0x000203EC File Offset: 0x0001E5EC
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_23_0.NativeStructWrapper.PG06DwmUfUHKsV3YPn5(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 4);
				}
				set
				{
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							this.SetBit(NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c975b252adfc48c4b262398638f90354 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}
			}

			// Token: 0x170002A4 RID: 676
			// (get) Token: 0x0600089C RID: 2204 RVA: 0x00020450 File Offset: 0x0001E650
			public IntPtr Pointer { get; }

			// Token: 0x170002A5 RID: 677
			// (get) Token: 0x0600089D RID: 2205 RVA: 0x00020460 File Offset: 0x0001E660
			public IntPtr VTable
			{
				get
				{
					return apS1BFcfBa3gXUspL9j.muOq5LWqgj(this.Pointer, sizeof(NativeClassStructHandler_23_0.Il2CppClass_23_0), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x170002A6 RID: 678
			// (get) Token: 0x0600089E RID: 2206 RVA: 0x00020480 File Offset: 0x0001E680
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170002A7 RID: 679
			// (get) Token: 0x0600089F RID: 2207 RVA: 0x00020490 File Offset: 0x0001E690
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->byval_arg);
				}
			}

			// Token: 0x170002A8 RID: 680
			// (get) Token: 0x060008A0 RID: 2208 RVA: 0x000204AC File Offset: 0x0001E6AC
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->this_arg);
				}
			}

			// Token: 0x170002A9 RID: 681
			// (get) Token: 0x060008A1 RID: 2209 RVA: 0x000204C8 File Offset: 0x0001E6C8
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x170002AA RID: 682
			// (get) Token: 0x060008A2 RID: 2210 RVA: 0x000204DC File Offset: 0x0001E6DC
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x170002AB RID: 683
			// (get) Token: 0x060008A3 RID: 2211 RVA: 0x000204F0 File Offset: 0x0001E6F0
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x170002AC RID: 684
			// (get) Token: 0x060008A4 RID: 2212 RVA: 0x00020504 File Offset: 0x0001E704
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x170002AD RID: 685
			// (get) Token: 0x060008A5 RID: 2213 RVA: 0x00020518 File Offset: 0x0001E718
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x170002AE RID: 686
			// (get) Token: 0x060008A6 RID: 2214 RVA: 0x0002052C File Offset: 0x0001E72C
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x170002AF RID: 687
			// (get) Token: 0x060008A7 RID: 2215 RVA: 0x00020540 File Offset: 0x0001E740
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x170002B0 RID: 688
			// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00020554 File Offset: 0x0001E754
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x170002B1 RID: 689
			// (get) Token: 0x060008A9 RID: 2217 RVA: 0x00020568 File Offset: 0x0001E768
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x170002B2 RID: 690
			// (get) Token: 0x060008AA RID: 2218 RVA: 0x0002057C File Offset: 0x0001E77C
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x170002B3 RID: 691
			// (get) Token: 0x060008AB RID: 2219 RVA: 0x00020594 File Offset: 0x0001E794
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170002B4 RID: 692
			// (get) Token: 0x060008AC RID: 2220 RVA: 0x000205AC File Offset: 0x0001E7AC
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x170002B5 RID: 693
			// (get) Token: 0x060008AD RID: 2221 RVA: 0x000205C4 File Offset: 0x0001E7C4
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x170002B6 RID: 694
			// (get) Token: 0x060008AE RID: 2222 RVA: 0x000205D8 File Offset: 0x0001E7D8
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x170002B7 RID: 695
			// (get) Token: 0x060008AF RID: 2223 RVA: 0x000205EC File Offset: 0x0001E7EC
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x170002B8 RID: 696
			// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00020600 File Offset: 0x0001E800
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x170002B9 RID: 697
			// (get) Token: 0x060008B1 RID: 2225 RVA: 0x00020614 File Offset: 0x0001E814
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x170002BA RID: 698
			// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00020628 File Offset: 0x0001E828
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._klassDummy;
				}
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x060008B3 RID: 2227 RVA: 0x00020638 File Offset: 0x0001E838
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x170002BC RID: 700
			// (get) Token: 0x060008B4 RID: 2228 RVA: 0x0002064C File Offset: 0x0001E84C
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x170002BD RID: 701
			// (get) Token: 0x060008B5 RID: 2229 RVA: 0x00020660 File Offset: 0x0001E860
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x170002BE RID: 702
			// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00020674 File Offset: 0x0001E874
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x170002BF RID: 703
			// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00020688 File Offset: 0x0001E888
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x170002C0 RID: 704
			// (get) Token: 0x060008B8 RID: 2232 RVA: 0x0002069C File Offset: 0x0001E89C
			// (set) Token: 0x060008B9 RID: 2233 RVA: 0x000206B4 File Offset: 0x0001E8B4
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_23_0.NativeStructWrapper.PG06DwmUfUHKsV3YPn5(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 0);
				}
				set
				{
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							NativeClassStructHandler_23_0.NativeStructWrapper.ysI9dGmjFcYToPNyjIJ(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_1f1b1b07c9f5435991b0738ea3210852 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}
			}

			// Token: 0x170002C1 RID: 705
			// (get) Token: 0x060008BA RID: 2234 RVA: 0x00020718 File Offset: 0x0001E918
			// (set) Token: 0x060008BB RID: 2235 RVA: 0x00020730 File Offset: 0x0001E930
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_23_0.NativeStructWrapper.PG06DwmUfUHKsV3YPn5(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 1);
				}
				set
				{
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							NativeClassStructHandler_23_0.NativeStructWrapper.ysI9dGmjFcYToPNyjIJ(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3f609fad0bcc47d79d3add6a492d3616 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170002C2 RID: 706
			// (get) Token: 0x060008BC RID: 2236 RVA: 0x00020794 File Offset: 0x0001E994
			// (set) Token: 0x060008BD RID: 2237 RVA: 0x000207AC File Offset: 0x0001E9AC
			public bool EnumType
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 2);
				}
				set
				{
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							NativeClassStructHandler_23_0.NativeStructWrapper.ysI9dGmjFcYToPNyjIJ(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4f96e4bec76a4c34a19bcff463d6dc03 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170002C3 RID: 707
			// (get) Token: 0x060008BE RID: 2238 RVA: 0x00020810 File Offset: 0x0001EA10
			// (set) Token: 0x060008BF RID: 2239 RVA: 0x00020828 File Offset: 0x0001EA28
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_23_0.NativeStructWrapper.PG06DwmUfUHKsV3YPn5(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 3);
				}
				set
				{
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							NativeClassStructHandler_23_0.NativeStructWrapper.ysI9dGmjFcYToPNyjIJ(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_15379a47ca764a4e8e16ceaf4804e136 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170002C4 RID: 708
			// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0002088C File Offset: 0x0001EA8C
			// (set) Token: 0x060008C1 RID: 2241 RVA: 0x000208A4 File Offset: 0x0001EAA4
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_23_0.NativeStructWrapper.PG06DwmUfUHKsV3YPn5(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 6);
				}
				set
				{
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							this.SetBit(NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b4185925b5254e3aae05578c6a89b13c == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}
			}

			// Token: 0x170002C5 RID: 709
			// (get) Token: 0x060008C2 RID: 2242 RVA: 0x00020908 File Offset: 0x0001EB08
			// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00020920 File Offset: 0x0001EB20
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_23_0.NativeStructWrapper.PG06DwmUfUHKsV3YPn5(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 7);
				}
				set
				{
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							this.SetBit(NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_420bdc7f003c47439a9f8331e71194a1 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170002C6 RID: 710
			// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00020984 File Offset: 0x0001EB84
			// (set) Token: 0x060008C5 RID: 2245 RVA: 0x0002099C File Offset: 0x0001EB9C
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_23_0.NativeStructWrapper.PG06DwmUfUHKsV3YPn5(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 11);
				}
				set
				{
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							this.SetBit(NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 11, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_441278fe93ad425f9343d4f7d1692fca == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170002C7 RID: 711
			// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00020A04 File Offset: 0x0001EC04
			// (set) Token: 0x060008C7 RID: 2247 RVA: 0x00020A10 File Offset: 0x0001EC10
			public bool InitializedAndNoError
			{
				get
				{
					return true;
				}
				set
				{
				}
			}

			// Token: 0x060008C8 RID: 2248 RVA: 0x00020A1C File Offset: 0x0001EC1C
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 5;
				int num2 = num;
				for (;;)
				{
					IntPtr intPtr;
					switch (num2)
					{
					case 1:
						NativeClassStructHandler_23_0.NativeStructWrapper.jZjMGsmo5RsXgBY8JB4();
						num2 = 2;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_43cc35cb254148318955c7f83ade60f1 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 2:
						intPtr = Marshal.OffsetOf<NativeClassStructHandler_23_0.Il2CppClass_23_0>(NativeClassStructHandler_23_0.NativeStructWrapper.h12btymerxPxIf4y6tF(-709960536 ^ -2117735461 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b5e8e4146b4a178d711afdb1274991));
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b55404cff7864ea3949f7b4156fd6ee5 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						NativeClassStructHandler_23_0.NativeStructWrapper.e0wamDmgXD2Ph8GRUcd();
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b55404cff7864ea3949f7b4156fd6ee5 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 5:
						NativeClassStructHandler_23_0.NativeStructWrapper.N5EnFBmQBbbgc0mjnhp();
						num2 = 4;
						continue;
					}
					NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_911808c58d664adeb7c16d1e3a32f7fa == 0)
					{
						num2 = 3;
					}
				}
			}

			// Token: 0x060008C9 RID: 2249 RVA: 0x00020B2C File Offset: 0x0001ED2C
			internal static void e0wamDmgXD2Ph8GRUcd()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060008CA RID: 2250 RVA: 0x00020B3C File Offset: 0x0001ED3C
			internal static void jZjMGsmo5RsXgBY8JB4()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x060008CB RID: 2251 RVA: 0x00020B4C File Offset: 0x0001ED4C
			internal static bool IZtyFcmraNfWFQ6fWOG()
			{
				return NativeClassStructHandler_23_0.NativeStructWrapper.rpifZcmGMB4LlRIEt4X == null;
			}

			// Token: 0x060008CC RID: 2252 RVA: 0x00020B60 File Offset: 0x0001ED60
			internal static NativeClassStructHandler_23_0.NativeStructWrapper DTitMvmT4Xc2wM02oyw()
			{
				return NativeClassStructHandler_23_0.NativeStructWrapper.rpifZcmGMB4LlRIEt4X;
			}

			// Token: 0x060008CD RID: 2253 RVA: 0x00020B70 File Offset: 0x0001ED70
			internal static bool PG06DwmUfUHKsV3YPn5(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060008CE RID: 2254 RVA: 0x00020B8C File Offset: 0x0001ED8C
			internal static void ysI9dGmjFcYToPNyjIJ(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x060008CF RID: 2255 RVA: 0x00020BAC File Offset: 0x0001EDAC
			internal static void N5EnFBmQBbbgc0mjnhp()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x060008D0 RID: 2256 RVA: 0x00020BBC File Offset: 0x0001EDBC
			internal static object h12btymerxPxIf4y6tF(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000563 RID: 1379
			private static readonly int _bitfield0offset;

			// Token: 0x04000564 RID: 1380
			private unsafe Il2CppClass* _klassDummy;

			// Token: 0x04000566 RID: 1382
			internal static object rpifZcmGMB4LlRIEt4X;
		}
	}
}
