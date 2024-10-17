using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000DD RID: 221
	[ApplicableToUnityVersionsSince("2018.1.0")]
	public class NativeClassStructHandler_24_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x060008F0 RID: 2288 RVA: 0x00011E14 File Offset: 0x00010014
		public int Size()
		{
			return sizeof(NativeClassStructHandler_24_0.Il2CppClass_24_0);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00011E24 File Offset: 0x00010024
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_24_0.Il2CppClass_24_0* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_24_0.f3AQRy6DrY3nve6pVxW(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_24_0.Il2CppClass_24_0);
			return new NativeClassStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00011E5C File Offset: 0x0001005C
		public unsafe INativeClassStruct Wrap(Il2CppClass* ptr)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9cbee6d56f49422699718938ff979567 != 0)
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
			return new NativeClassStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00011EC4 File Offset: 0x000100C4
		public NativeClassStructHandler_24_0()
		{
			NativeClassStructHandler_24_0.kE1wKm6ZQbJtCGjfgr0();
			NativeClassStructHandler_24_0.Kvhx5r6oad79WRQJDOl();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d691a76a9c4746c9a1a67e34c67ca64b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00011F28 File Offset: 0x00010128
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_24_0()
		{
			NativeClassStructHandler_24_0.frjpTC6bx3fFLadu5JZ();
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00011F38 File Offset: 0x00010138
		internal static IntPtr f3AQRy6DrY3nve6pVxW(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00011F4C File Offset: 0x0001014C
		internal static bool l5lESr6Wn3yVbXIw0VV()
		{
			return NativeClassStructHandler_24_0.H4bQg16J03yTfNKRbBc == null;
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00011F60 File Offset: 0x00010160
		internal static NativeClassStructHandler_24_0 L6Vw1K6rPYXj1wF5eom()
		{
			return NativeClassStructHandler_24_0.H4bQg16J03yTfNKRbBc;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00011F70 File Offset: 0x00010170
		internal static void kE1wKm6ZQbJtCGjfgr0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00011F80 File Offset: 0x00010180
		internal static void Kvhx5r6oad79WRQJDOl()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00011F90 File Offset: 0x00010190
		internal static void frjpTC6bx3fFLadu5JZ()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000572 RID: 1394
		internal static NativeClassStructHandler_24_0 H4bQg16J03yTfNKRbBc;

		// Token: 0x020000DE RID: 222
		internal struct Il2CppClass_24_0
		{
			// Token: 0x04000573 RID: 1395
			public unsafe Il2CppImage* image;

			// Token: 0x04000574 RID: 1396
			public unsafe void* gc_desc;

			// Token: 0x04000575 RID: 1397
			public unsafe byte* name;

			// Token: 0x04000576 RID: 1398
			public unsafe byte* namespaze;

			// Token: 0x04000577 RID: 1399
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 byval_arg;

			// Token: 0x04000578 RID: 1400
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 this_arg;

			// Token: 0x04000579 RID: 1401
			public unsafe Il2CppClass* element_class;

			// Token: 0x0400057A RID: 1402
			public unsafe Il2CppClass* castClass;

			// Token: 0x0400057B RID: 1403
			public unsafe Il2CppClass* declaringType;

			// Token: 0x0400057C RID: 1404
			public unsafe Il2CppClass* parent;

			// Token: 0x0400057D RID: 1405
			public unsafe void* generic_class;

			// Token: 0x0400057E RID: 1406
			public unsafe void* typeDefinition;

			// Token: 0x0400057F RID: 1407
			public unsafe void* interopData;

			// Token: 0x04000580 RID: 1408
			public unsafe Il2CppClass* klass;

			// Token: 0x04000581 RID: 1409
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x04000582 RID: 1410
			public unsafe Il2CppEventInfo* events;

			// Token: 0x04000583 RID: 1411
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000584 RID: 1412
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x04000585 RID: 1413
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000586 RID: 1414
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x04000587 RID: 1415
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x04000588 RID: 1416
			public unsafe void* static_fields;

			// Token: 0x04000589 RID: 1417
			public unsafe void* rgctx_data;

			// Token: 0x0400058A RID: 1418
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x0400058B RID: 1419
			public uint cctor_started;

			// Token: 0x0400058C RID: 1420
			public uint cctor_finished;

			// Token: 0x0400058D RID: 1421
			public ulong cctor_thread;

			// Token: 0x0400058E RID: 1422
			public int genericContainerIndex;

			// Token: 0x0400058F RID: 1423
			public int customAttributeIndex;

			// Token: 0x04000590 RID: 1424
			public uint instance_size;

			// Token: 0x04000591 RID: 1425
			public uint actualSize;

			// Token: 0x04000592 RID: 1426
			public uint element_size;

			// Token: 0x04000593 RID: 1427
			public int native_size;

			// Token: 0x04000594 RID: 1428
			public uint static_fields_size;

			// Token: 0x04000595 RID: 1429
			public uint thread_static_fields_size;

			// Token: 0x04000596 RID: 1430
			public int thread_static_fields_offset;

			// Token: 0x04000597 RID: 1431
			public uint flags;

			// Token: 0x04000598 RID: 1432
			public uint token;

			// Token: 0x04000599 RID: 1433
			public ushort method_count;

			// Token: 0x0400059A RID: 1434
			public ushort property_count;

			// Token: 0x0400059B RID: 1435
			public ushort field_count;

			// Token: 0x0400059C RID: 1436
			public ushort event_count;

			// Token: 0x0400059D RID: 1437
			public ushort nested_type_count;

			// Token: 0x0400059E RID: 1438
			public ushort vtable_count;

			// Token: 0x0400059F RID: 1439
			public ushort interfaces_count;

			// Token: 0x040005A0 RID: 1440
			public ushort interface_offsets_count;

			// Token: 0x040005A1 RID: 1441
			public byte typeHierarchyDepth;

			// Token: 0x040005A2 RID: 1442
			public byte genericRecursionDepth;

			// Token: 0x040005A3 RID: 1443
			public byte rank;

			// Token: 0x040005A4 RID: 1444
			public byte minimumAlignment;

			// Token: 0x040005A5 RID: 1445
			public byte packingSize;

			// Token: 0x040005A6 RID: 1446
			public NativeClassStructHandler_24_0.Il2CppClass_24_0.Bitfield0 _bitfield0;

			// Token: 0x020000DF RID: 223
			internal enum Bitfield0 : ushort
			{
				// Token: 0x040005A8 RID: 1448
				BIT_valuetype,
				// Token: 0x040005A9 RID: 1449
				valuetype,
				// Token: 0x040005AA RID: 1450
				BIT_initialized = 1,
				// Token: 0x040005AB RID: 1451
				initialized,
				// Token: 0x040005AC RID: 1452
				BIT_enumtype = 2,
				// Token: 0x040005AD RID: 1453
				enumtype = 4,
				// Token: 0x040005AE RID: 1454
				BIT_is_generic = 3,
				// Token: 0x040005AF RID: 1455
				is_generic = 8,
				// Token: 0x040005B0 RID: 1456
				BIT_has_references = 4,
				// Token: 0x040005B1 RID: 1457
				has_references = 16,
				// Token: 0x040005B2 RID: 1458
				BIT_init_pending = 5,
				// Token: 0x040005B3 RID: 1459
				init_pending = 32,
				// Token: 0x040005B4 RID: 1460
				BIT_size_inited = 6,
				// Token: 0x040005B5 RID: 1461
				size_inited = 64,
				// Token: 0x040005B6 RID: 1462
				BIT_has_finalize = 7,
				// Token: 0x040005B7 RID: 1463
				has_finalize = 128,
				// Token: 0x040005B8 RID: 1464
				BIT_has_cctor = 8,
				// Token: 0x040005B9 RID: 1465
				has_cctor = 256,
				// Token: 0x040005BA RID: 1466
				BIT_is_blittable = 9,
				// Token: 0x040005BB RID: 1467
				is_blittable = 512,
				// Token: 0x040005BC RID: 1468
				BIT_is_import_or_windows_runtime = 10,
				// Token: 0x040005BD RID: 1469
				is_import_or_windows_runtime = 1024,
				// Token: 0x040005BE RID: 1470
				BIT_is_vtable_initialized = 11,
				// Token: 0x040005BF RID: 1471
				is_vtable_initialized = 2048
			}
		}

		// Token: 0x020000E0 RID: 224
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x060008FB RID: 2299 RVA: 0x00021848 File Offset: 0x0001FA48
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_24_0.NativeStructWrapper.ewqcMRbbs52hnTrlCA3();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_db312e48eee84539b805fee2f73a8cde == 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						return;
					}
					this.<Pointer>k__BackingField = ptr;
					num = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_570d4e075bf443fcbaca8db32e007291 == 0)
					{
						num = 1;
					}
				}
			}

			// Token: 0x170002C8 RID: 712
			// (get) Token: 0x060008FC RID: 2300 RVA: 0x000218D8 File Offset: 0x0001FAD8
			private unsafe NativeClassStructHandler_24_0.Il2CppClass_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170002C9 RID: 713
			// (get) Token: 0x060008FD RID: 2301 RVA: 0x000218E8 File Offset: 0x0001FAE8
			// (set) Token: 0x060008FE RID: 2302 RVA: 0x00021900 File Offset: 0x0001FB00
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_24_0.NativeStructWrapper.yhEHO5bfLUvJFG0wZqm(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_24_0.NativeStructWrapper.wXiQkZbPQg7t0ab0NkX(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_780e0c86b08f49d785f406cf802c7e87 == 0)
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

			// Token: 0x170002CA RID: 714
			// (get) Token: 0x060008FF RID: 2303 RVA: 0x00021964 File Offset: 0x0001FB64
			public IntPtr Pointer { get; }

			// Token: 0x170002CB RID: 715
			// (get) Token: 0x06000900 RID: 2304 RVA: 0x00021974 File Offset: 0x0001FB74
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_24_0.NativeStructWrapper.eIaWeYbdZKoAfTBuyJS(this.Pointer, sizeof(NativeClassStructHandler_24_0.Il2CppClass_24_0), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x170002CC RID: 716
			// (get) Token: 0x06000901 RID: 2305 RVA: 0x00021994 File Offset: 0x0001FB94
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170002CD RID: 717
			// (get) Token: 0x06000902 RID: 2306 RVA: 0x000219A4 File Offset: 0x0001FBA4
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x170002CE RID: 718
			// (get) Token: 0x06000903 RID: 2307 RVA: 0x000219C0 File Offset: 0x0001FBC0
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x170002CF RID: 719
			// (get) Token: 0x06000904 RID: 2308 RVA: 0x000219DC File Offset: 0x0001FBDC
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x170002D0 RID: 720
			// (get) Token: 0x06000905 RID: 2309 RVA: 0x000219F0 File Offset: 0x0001FBF0
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x170002D1 RID: 721
			// (get) Token: 0x06000906 RID: 2310 RVA: 0x00021A04 File Offset: 0x0001FC04
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x170002D2 RID: 722
			// (get) Token: 0x06000907 RID: 2311 RVA: 0x00021A18 File Offset: 0x0001FC18
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x170002D3 RID: 723
			// (get) Token: 0x06000908 RID: 2312 RVA: 0x00021A2C File Offset: 0x0001FC2C
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x170002D4 RID: 724
			// (get) Token: 0x06000909 RID: 2313 RVA: 0x00021A40 File Offset: 0x0001FC40
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x170002D5 RID: 725
			// (get) Token: 0x0600090A RID: 2314 RVA: 0x00021A54 File Offset: 0x0001FC54
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x170002D6 RID: 726
			// (get) Token: 0x0600090B RID: 2315 RVA: 0x00021A68 File Offset: 0x0001FC68
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x170002D7 RID: 727
			// (get) Token: 0x0600090C RID: 2316 RVA: 0x00021A7C File Offset: 0x0001FC7C
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x170002D8 RID: 728
			// (get) Token: 0x0600090D RID: 2317 RVA: 0x00021A90 File Offset: 0x0001FC90
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x170002D9 RID: 729
			// (get) Token: 0x0600090E RID: 2318 RVA: 0x00021AA8 File Offset: 0x0001FCA8
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170002DA RID: 730
			// (get) Token: 0x0600090F RID: 2319 RVA: 0x00021AC0 File Offset: 0x0001FCC0
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x170002DB RID: 731
			// (get) Token: 0x06000910 RID: 2320 RVA: 0x00021AD8 File Offset: 0x0001FCD8
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x170002DC RID: 732
			// (get) Token: 0x06000911 RID: 2321 RVA: 0x00021AEC File Offset: 0x0001FCEC
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x170002DD RID: 733
			// (get) Token: 0x06000912 RID: 2322 RVA: 0x00021B00 File Offset: 0x0001FD00
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x170002DE RID: 734
			// (get) Token: 0x06000913 RID: 2323 RVA: 0x00021B14 File Offset: 0x0001FD14
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x170002DF RID: 735
			// (get) Token: 0x06000914 RID: 2324 RVA: 0x00021B28 File Offset: 0x0001FD28
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x170002E0 RID: 736
			// (get) Token: 0x06000915 RID: 2325 RVA: 0x00021B3C File Offset: 0x0001FD3C
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x170002E1 RID: 737
			// (get) Token: 0x06000916 RID: 2326 RVA: 0x00021B50 File Offset: 0x0001FD50
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x170002E2 RID: 738
			// (get) Token: 0x06000917 RID: 2327 RVA: 0x00021B64 File Offset: 0x0001FD64
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x170002E3 RID: 739
			// (get) Token: 0x06000918 RID: 2328 RVA: 0x00021B78 File Offset: 0x0001FD78
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x170002E4 RID: 740
			// (get) Token: 0x06000919 RID: 2329 RVA: 0x00021B8C File Offset: 0x0001FD8C
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x170002E5 RID: 741
			// (get) Token: 0x0600091A RID: 2330 RVA: 0x00021BA0 File Offset: 0x0001FDA0
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x170002E6 RID: 742
			// (get) Token: 0x0600091B RID: 2331 RVA: 0x00021BB4 File Offset: 0x0001FDB4
			// (set) Token: 0x0600091C RID: 2332 RVA: 0x00021BCC File Offset: 0x0001FDCC
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_24_0.NativeStructWrapper.yhEHO5bfLUvJFG0wZqm(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_24_0.NativeStructWrapper.wXiQkZbPQg7t0ab0NkX(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c23fbb8072754781976c5c809c25ef15 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170002E7 RID: 743
			// (get) Token: 0x0600091D RID: 2333 RVA: 0x00021C30 File Offset: 0x0001FE30
			// (set) Token: 0x0600091E RID: 2334 RVA: 0x00021C48 File Offset: 0x0001FE48
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_24_0.NativeStructWrapper.yhEHO5bfLUvJFG0wZqm(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_24_0.NativeStructWrapper.wXiQkZbPQg7t0ab0NkX(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_22d16b8eb84d4725aef9f7a9d2f68925 == 0)
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

			// Token: 0x170002E8 RID: 744
			// (get) Token: 0x0600091F RID: 2335 RVA: 0x00021CAC File Offset: 0x0001FEAC
			// (set) Token: 0x06000920 RID: 2336 RVA: 0x00021CC4 File Offset: 0x0001FEC4
			public bool EnumType
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_24_0.NativeStructWrapper.wXiQkZbPQg7t0ab0NkX(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c23fbb8072754781976c5c809c25ef15 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170002E9 RID: 745
			// (get) Token: 0x06000921 RID: 2337 RVA: 0x00021D28 File Offset: 0x0001FF28
			// (set) Token: 0x06000922 RID: 2338 RVA: 0x00021D40 File Offset: 0x0001FF40
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_24_0.NativeStructWrapper.yhEHO5bfLUvJFG0wZqm(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_24_0.NativeStructWrapper.wXiQkZbPQg7t0ab0NkX(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 3, value);
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
				}
			}

			// Token: 0x170002EA RID: 746
			// (get) Token: 0x06000923 RID: 2339 RVA: 0x00021DA4 File Offset: 0x0001FFA4
			// (set) Token: 0x06000924 RID: 2340 RVA: 0x00021DBC File Offset: 0x0001FFBC
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_24_0.NativeStructWrapper.yhEHO5bfLUvJFG0wZqm(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 6);
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
							NativeClassStructHandler_24_0.NativeStructWrapper.wXiQkZbPQg7t0ab0NkX(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5d181dabf1ed42eca63023d24d927754 == 0)
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

			// Token: 0x170002EB RID: 747
			// (get) Token: 0x06000925 RID: 2341 RVA: 0x00021E20 File Offset: 0x00020020
			// (set) Token: 0x06000926 RID: 2342 RVA: 0x00021E38 File Offset: 0x00020038
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_24_0.NativeStructWrapper.yhEHO5bfLUvJFG0wZqm(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 7);
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
							this.SetBit(NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170002EC RID: 748
			// (get) Token: 0x06000927 RID: 2343 RVA: 0x00021E9C File Offset: 0x0002009C
			// (set) Token: 0x06000928 RID: 2344 RVA: 0x00021EB4 File Offset: 0x000200B4
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_24_0.NativeStructWrapper.yhEHO5bfLUvJFG0wZqm(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 11);
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
							NativeClassStructHandler_24_0.NativeStructWrapper.wXiQkZbPQg7t0ab0NkX(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 11, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5afe19cf44424af2ad9aea85585a9cc2 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170002ED RID: 749
			// (get) Token: 0x06000929 RID: 2345 RVA: 0x00021F1C File Offset: 0x0002011C
			// (set) Token: 0x0600092A RID: 2346 RVA: 0x00021F28 File Offset: 0x00020128
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

			// Token: 0x0600092B RID: 2347 RVA: 0x00021F34 File Offset: 0x00020134
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 4;
				int num2 = num;
				for (;;)
				{
					IntPtr intPtr;
					switch (num2)
					{
					case 1:
						return;
					case 2:
						NativeClassStructHandler_24_0.NativeStructWrapper.E7e9hMbeil5HeJ4J4Ya();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f72daac7e98440569eaab57fbb9f7bf2 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						NativeClassStructHandler_24_0.NativeStructWrapper.ewqcMRbbs52hnTrlCA3();
						num2 = 2;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c32cfeb41f7a43999be3bae16a94ad02 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						NativeClassStructHandler_24_0.NativeStructWrapper.SPuwaMbwR1qEyo0ToSn();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8447c7a721f541de9426c754e1b08372 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 5:
						NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_61a3825996b24609815f6b482bf680d9 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					intPtr = Marshal.OffsetOf<NativeClassStructHandler_24_0.Il2CppClass_24_0>(NativeClassStructHandler_24_0.NativeStructWrapper.N1gnL4bs54irjl9gDaQ(211514960 ^ 1519119078 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_806dbdb7f5194c2fa0c07a915df13fc8));
					num2 = 5;
				}
			}

			// Token: 0x0600092C RID: 2348 RVA: 0x00022044 File Offset: 0x00020244
			internal static void ewqcMRbbs52hnTrlCA3()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600092D RID: 2349 RVA: 0x00022054 File Offset: 0x00020254
			internal static bool GDa2MubZGKeA1M7JNhA()
			{
				return NativeClassStructHandler_24_0.NativeStructWrapper.hQ65nBbD6XOtB3ew00q == null;
			}

			// Token: 0x0600092E RID: 2350 RVA: 0x00022068 File Offset: 0x00020268
			internal static NativeClassStructHandler_24_0.NativeStructWrapper TMbBYEbo6YO7s8a8fYi()
			{
				return NativeClassStructHandler_24_0.NativeStructWrapper.hQ65nBbD6XOtB3ew00q;
			}

			// Token: 0x0600092F RID: 2351 RVA: 0x00022078 File Offset: 0x00020278
			internal static bool yhEHO5bfLUvJFG0wZqm(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000930 RID: 2352 RVA: 0x00022094 File Offset: 0x00020294
			internal static void wXiQkZbPQg7t0ab0NkX(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000931 RID: 2353 RVA: 0x000220B4 File Offset: 0x000202B4
			internal static IntPtr eIaWeYbdZKoAfTBuyJS(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x06000932 RID: 2354 RVA: 0x000220D0 File Offset: 0x000202D0
			internal static void SPuwaMbwR1qEyo0ToSn()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000933 RID: 2355 RVA: 0x000220E0 File Offset: 0x000202E0
			internal static void E7e9hMbeil5HeJ4J4Ya()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000934 RID: 2356 RVA: 0x000220F0 File Offset: 0x000202F0
			internal static object N1gnL4bs54irjl9gDaQ(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x040005C0 RID: 1472
			private static readonly int _bitfield0offset;

			// Token: 0x040005C2 RID: 1474
			private static object hQ65nBbD6XOtB3ew00q;
		}
	}
}
