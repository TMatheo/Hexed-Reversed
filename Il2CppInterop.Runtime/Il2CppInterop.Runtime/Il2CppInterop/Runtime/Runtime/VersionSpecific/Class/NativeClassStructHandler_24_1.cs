using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000DF RID: 223
	[ApplicableToUnityVersionsSince("2018.2.0")]
	public class NativeClassStructHandler_24_1 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000915 RID: 2325 RVA: 0x00011398 File Offset: 0x0000F598
		public int Size()
		{
			return sizeof(NativeClassStructHandler_24_1.Il2CppClass_24_1);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x000113A8 File Offset: 0x0000F5A8
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_24_1.Il2CppClass_24_1* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_24_1.bQJaQDyY14806cWIQxE(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_24_1.Il2CppClass_24_1);
			return new NativeClassStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x000113E0 File Offset: 0x0000F5E0
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7fef7bb77728417ab4965dd0775b5899 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeClassStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00011448 File Offset: 0x0000F648
		public NativeClassStructHandler_24_1()
		{
			NativeClassStructHandler_24_1.mpICtIy8svu0GfI1p4u();
			NativeClassStructHandler_24_1.pQg0WZynsI7Nv8Yr4Hq();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ac2c10c141e144acbcef06aa86a10430 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x000114AC File Offset: 0x0000F6AC
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_24_1()
		{
			NativeClassStructHandler_24_1.AVtaMyybrunCJDvKak0();
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x000114BC File Offset: 0x0000F6BC
		internal static IntPtr bQJaQDyY14806cWIQxE(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x000114D0 File Offset: 0x0000F6D0
		internal static bool zD8wD5yvhRvrZoMXNni()
		{
			return NativeClassStructHandler_24_1.fikQtoytBaZPxWO07Vg == null;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000114E4 File Offset: 0x0000F6E4
		internal static NativeClassStructHandler_24_1 feAM5ayxSLf6cQud1BI()
		{
			return NativeClassStructHandler_24_1.fikQtoytBaZPxWO07Vg;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000114F4 File Offset: 0x0000F6F4
		internal static void mpICtIy8svu0GfI1p4u()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00011504 File Offset: 0x0000F704
		internal static void pQg0WZynsI7Nv8Yr4Hq()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00011514 File Offset: 0x0000F714
		internal static void AVtaMyybrunCJDvKak0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040005B8 RID: 1464
		internal static NativeClassStructHandler_24_1 fikQtoytBaZPxWO07Vg;

		// Token: 0x020000E0 RID: 224
		internal struct Il2CppClass_24_1
		{
			// Token: 0x040005B9 RID: 1465
			public unsafe Il2CppImage* image;

			// Token: 0x040005BA RID: 1466
			public unsafe void* gc_desc;

			// Token: 0x040005BB RID: 1467
			public unsafe byte* name;

			// Token: 0x040005BC RID: 1468
			public unsafe byte* namespaze;

			// Token: 0x040005BD RID: 1469
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 byval_arg;

			// Token: 0x040005BE RID: 1470
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 this_arg;

			// Token: 0x040005BF RID: 1471
			public unsafe Il2CppClass* element_class;

			// Token: 0x040005C0 RID: 1472
			public unsafe Il2CppClass* castClass;

			// Token: 0x040005C1 RID: 1473
			public unsafe Il2CppClass* declaringType;

			// Token: 0x040005C2 RID: 1474
			public unsafe Il2CppClass* parent;

			// Token: 0x040005C3 RID: 1475
			public unsafe void* generic_class;

			// Token: 0x040005C4 RID: 1476
			public unsafe void* typeDefinition;

			// Token: 0x040005C5 RID: 1477
			public unsafe void* interopData;

			// Token: 0x040005C6 RID: 1478
			public unsafe Il2CppClass* klass;

			// Token: 0x040005C7 RID: 1479
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x040005C8 RID: 1480
			public unsafe Il2CppEventInfo* events;

			// Token: 0x040005C9 RID: 1481
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x040005CA RID: 1482
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x040005CB RID: 1483
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x040005CC RID: 1484
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x040005CD RID: 1485
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x040005CE RID: 1486
			public unsafe void* static_fields;

			// Token: 0x040005CF RID: 1487
			public unsafe void* rgctx_data;

			// Token: 0x040005D0 RID: 1488
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x040005D1 RID: 1489
			public uint initializationExceptionGCHandle;

			// Token: 0x040005D2 RID: 1490
			public uint cctor_started;

			// Token: 0x040005D3 RID: 1491
			public uint cctor_finished;

			// Token: 0x040005D4 RID: 1492
			public ulong cctor_thread;

			// Token: 0x040005D5 RID: 1493
			public int genericContainerIndex;

			// Token: 0x040005D6 RID: 1494
			public int customAttributeIndex;

			// Token: 0x040005D7 RID: 1495
			public uint instance_size;

			// Token: 0x040005D8 RID: 1496
			public uint actualSize;

			// Token: 0x040005D9 RID: 1497
			public uint element_size;

			// Token: 0x040005DA RID: 1498
			public int native_size;

			// Token: 0x040005DB RID: 1499
			public uint static_fields_size;

			// Token: 0x040005DC RID: 1500
			public uint thread_static_fields_size;

			// Token: 0x040005DD RID: 1501
			public int thread_static_fields_offset;

			// Token: 0x040005DE RID: 1502
			public uint flags;

			// Token: 0x040005DF RID: 1503
			public uint token;

			// Token: 0x040005E0 RID: 1504
			public ushort method_count;

			// Token: 0x040005E1 RID: 1505
			public ushort property_count;

			// Token: 0x040005E2 RID: 1506
			public ushort field_count;

			// Token: 0x040005E3 RID: 1507
			public ushort event_count;

			// Token: 0x040005E4 RID: 1508
			public ushort nested_type_count;

			// Token: 0x040005E5 RID: 1509
			public ushort vtable_count;

			// Token: 0x040005E6 RID: 1510
			public ushort interfaces_count;

			// Token: 0x040005E7 RID: 1511
			public ushort interface_offsets_count;

			// Token: 0x040005E8 RID: 1512
			public byte typeHierarchyDepth;

			// Token: 0x040005E9 RID: 1513
			public byte genericRecursionDepth;

			// Token: 0x040005EA RID: 1514
			public byte rank;

			// Token: 0x040005EB RID: 1515
			public byte minimumAlignment;

			// Token: 0x040005EC RID: 1516
			public byte packingSize;

			// Token: 0x040005ED RID: 1517
			public NativeClassStructHandler_24_1.Il2CppClass_24_1.Bitfield0 _bitfield0;

			// Token: 0x020000E1 RID: 225
			internal enum Bitfield0 : ushort
			{
				// Token: 0x040005EF RID: 1519
				BIT_valuetype,
				// Token: 0x040005F0 RID: 1520
				valuetype,
				// Token: 0x040005F1 RID: 1521
				BIT_initialized = 1,
				// Token: 0x040005F2 RID: 1522
				initialized,
				// Token: 0x040005F3 RID: 1523
				BIT_enumtype = 2,
				// Token: 0x040005F4 RID: 1524
				enumtype = 4,
				// Token: 0x040005F5 RID: 1525
				BIT_is_generic = 3,
				// Token: 0x040005F6 RID: 1526
				is_generic = 8,
				// Token: 0x040005F7 RID: 1527
				BIT_has_references = 4,
				// Token: 0x040005F8 RID: 1528
				has_references = 16,
				// Token: 0x040005F9 RID: 1529
				BIT_init_pending = 5,
				// Token: 0x040005FA RID: 1530
				init_pending = 32,
				// Token: 0x040005FB RID: 1531
				BIT_size_inited = 6,
				// Token: 0x040005FC RID: 1532
				size_inited = 64,
				// Token: 0x040005FD RID: 1533
				BIT_has_finalize = 7,
				// Token: 0x040005FE RID: 1534
				has_finalize = 128,
				// Token: 0x040005FF RID: 1535
				BIT_has_cctor = 8,
				// Token: 0x04000600 RID: 1536
				has_cctor = 256,
				// Token: 0x04000601 RID: 1537
				BIT_is_blittable = 9,
				// Token: 0x04000602 RID: 1538
				is_blittable = 512,
				// Token: 0x04000603 RID: 1539
				BIT_is_import_or_windows_runtime = 10,
				// Token: 0x04000604 RID: 1540
				is_import_or_windows_runtime = 1024,
				// Token: 0x04000605 RID: 1541
				BIT_is_vtable_initialized = 11,
				// Token: 0x04000606 RID: 1542
				is_vtable_initialized = 2048,
				// Token: 0x04000607 RID: 1543
				BIT_has_initialization_error = 12,
				// Token: 0x04000608 RID: 1544
				has_initialization_error = 4096
			}
		}

		// Token: 0x020000E2 RID: 226
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000920 RID: 2336 RVA: 0x00021480 File Offset: 0x0001F680
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_24_1.NativeStructWrapper.aJKdVd7xbG4pd5PaovT();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2356ac6ca5954f1897cd5bbbe0161ae5 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4f0a774880f74bccb3d4511e5f526375 != 0)
						{
							num = 0;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x170002EE RID: 750
			// (get) Token: 0x06000921 RID: 2337 RVA: 0x00021510 File Offset: 0x0001F710
			private unsafe NativeClassStructHandler_24_1.Il2CppClass_24_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170002EF RID: 751
			// (get) Token: 0x06000922 RID: 2338 RVA: 0x00021520 File Offset: 0x0001F720
			// (set) Token: 0x06000923 RID: 2339 RVA: 0x00021538 File Offset: 0x0001F738
			public bool HasReferences
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_24_1.NativeStructWrapper.CKpojC7Yvh6P0lJ1COU(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4356a7af7f8147b79f2ed4ab0c268438 == 0)
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

			// Token: 0x170002F0 RID: 752
			// (get) Token: 0x06000924 RID: 2340 RVA: 0x0002159C File Offset: 0x0001F79C
			public IntPtr Pointer { get; }

			// Token: 0x170002F1 RID: 753
			// (get) Token: 0x06000925 RID: 2341 RVA: 0x000215AC File Offset: 0x0001F7AC
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_24_1.NativeStructWrapper.pWC6Pn78mAPWg1tXGOI(this.Pointer, sizeof(NativeClassStructHandler_24_1.Il2CppClass_24_1), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x170002F2 RID: 754
			// (get) Token: 0x06000926 RID: 2342 RVA: 0x000215CC File Offset: 0x0001F7CC
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170002F3 RID: 755
			// (get) Token: 0x06000927 RID: 2343 RVA: 0x000215DC File Offset: 0x0001F7DC
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x170002F4 RID: 756
			// (get) Token: 0x06000928 RID: 2344 RVA: 0x000215F8 File Offset: 0x0001F7F8
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x170002F5 RID: 757
			// (get) Token: 0x06000929 RID: 2345 RVA: 0x00021614 File Offset: 0x0001F814
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x170002F6 RID: 758
			// (get) Token: 0x0600092A RID: 2346 RVA: 0x00021628 File Offset: 0x0001F828
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x170002F7 RID: 759
			// (get) Token: 0x0600092B RID: 2347 RVA: 0x0002163C File Offset: 0x0001F83C
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x170002F8 RID: 760
			// (get) Token: 0x0600092C RID: 2348 RVA: 0x00021650 File Offset: 0x0001F850
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x170002F9 RID: 761
			// (get) Token: 0x0600092D RID: 2349 RVA: 0x00021664 File Offset: 0x0001F864
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x170002FA RID: 762
			// (get) Token: 0x0600092E RID: 2350 RVA: 0x00021678 File Offset: 0x0001F878
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x170002FB RID: 763
			// (get) Token: 0x0600092F RID: 2351 RVA: 0x0002168C File Offset: 0x0001F88C
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x170002FC RID: 764
			// (get) Token: 0x06000930 RID: 2352 RVA: 0x000216A0 File Offset: 0x0001F8A0
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x170002FD RID: 765
			// (get) Token: 0x06000931 RID: 2353 RVA: 0x000216B4 File Offset: 0x0001F8B4
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x170002FE RID: 766
			// (get) Token: 0x06000932 RID: 2354 RVA: 0x000216C8 File Offset: 0x0001F8C8
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x170002FF RID: 767
			// (get) Token: 0x06000933 RID: 2355 RVA: 0x000216E0 File Offset: 0x0001F8E0
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000300 RID: 768
			// (get) Token: 0x06000934 RID: 2356 RVA: 0x000216F8 File Offset: 0x0001F8F8
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x17000301 RID: 769
			// (get) Token: 0x06000935 RID: 2357 RVA: 0x00021710 File Offset: 0x0001F910
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x17000302 RID: 770
			// (get) Token: 0x06000936 RID: 2358 RVA: 0x00021724 File Offset: 0x0001F924
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000303 RID: 771
			// (get) Token: 0x06000937 RID: 2359 RVA: 0x00021738 File Offset: 0x0001F938
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x17000304 RID: 772
			// (get) Token: 0x06000938 RID: 2360 RVA: 0x0002174C File Offset: 0x0001F94C
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x17000305 RID: 773
			// (get) Token: 0x06000939 RID: 2361 RVA: 0x00021760 File Offset: 0x0001F960
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x17000306 RID: 774
			// (get) Token: 0x0600093A RID: 2362 RVA: 0x00021774 File Offset: 0x0001F974
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x17000307 RID: 775
			// (get) Token: 0x0600093B RID: 2363 RVA: 0x00021788 File Offset: 0x0001F988
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x17000308 RID: 776
			// (get) Token: 0x0600093C RID: 2364 RVA: 0x0002179C File Offset: 0x0001F99C
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x17000309 RID: 777
			// (get) Token: 0x0600093D RID: 2365 RVA: 0x000217B0 File Offset: 0x0001F9B0
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x1700030A RID: 778
			// (get) Token: 0x0600093E RID: 2366 RVA: 0x000217C4 File Offset: 0x0001F9C4
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x1700030B RID: 779
			// (get) Token: 0x0600093F RID: 2367 RVA: 0x000217D8 File Offset: 0x0001F9D8
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x1700030C RID: 780
			// (get) Token: 0x06000940 RID: 2368 RVA: 0x000217EC File Offset: 0x0001F9EC
			// (set) Token: 0x06000941 RID: 2369 RVA: 0x00021804 File Offset: 0x0001FA04
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_24_1.NativeStructWrapper.VY3A3i7nkFdUbPtUVCh(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_24_1.NativeStructWrapper.CKpojC7Yvh6P0lJ1COU(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cc8d2b38a48843c198fb28cbbbd93013 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700030D RID: 781
			// (get) Token: 0x06000942 RID: 2370 RVA: 0x00021868 File Offset: 0x0001FA68
			// (set) Token: 0x06000943 RID: 2371 RVA: 0x00021880 File Offset: 0x0001FA80
			public bool Initialized
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 1);
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
							this.SetBit(NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2a3cb7fb82fa47c39f707a2393c1a340 == 0)
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

			// Token: 0x1700030E RID: 782
			// (get) Token: 0x06000944 RID: 2372 RVA: 0x000218E4 File Offset: 0x0001FAE4
			// (set) Token: 0x06000945 RID: 2373 RVA: 0x000218FC File Offset: 0x0001FAFC
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_24_1.NativeStructWrapper.VY3A3i7nkFdUbPtUVCh(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_24_1.NativeStructWrapper.CKpojC7Yvh6P0lJ1COU(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_dd9c757bd882429784d62f0e80f112e6 == 0)
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

			// Token: 0x1700030F RID: 783
			// (get) Token: 0x06000946 RID: 2374 RVA: 0x00021960 File Offset: 0x0001FB60
			// (set) Token: 0x06000947 RID: 2375 RVA: 0x00021978 File Offset: 0x0001FB78
			public bool IsGeneric
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_24_1.NativeStructWrapper.CKpojC7Yvh6P0lJ1COU(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_68cafcd7c4d444e39c183fde29795ee9 == 0)
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

			// Token: 0x17000310 RID: 784
			// (get) Token: 0x06000948 RID: 2376 RVA: 0x000219DC File Offset: 0x0001FBDC
			// (set) Token: 0x06000949 RID: 2377 RVA: 0x000219F4 File Offset: 0x0001FBF4
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_24_1.NativeStructWrapper.VY3A3i7nkFdUbPtUVCh(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 6);
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
							NativeClassStructHandler_24_1.NativeStructWrapper.CKpojC7Yvh6P0lJ1COU(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b82ae23c6544f3a11e54f2fed3ad25 != 0)
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

			// Token: 0x17000311 RID: 785
			// (get) Token: 0x0600094A RID: 2378 RVA: 0x00021A58 File Offset: 0x0001FC58
			// (set) Token: 0x0600094B RID: 2379 RVA: 0x00021A70 File Offset: 0x0001FC70
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_24_1.NativeStructWrapper.VY3A3i7nkFdUbPtUVCh(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_24_1.NativeStructWrapper.CKpojC7Yvh6P0lJ1COU(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb34a81d7cc4fbea898664370a8645f == 0)
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

			// Token: 0x17000312 RID: 786
			// (get) Token: 0x0600094C RID: 2380 RVA: 0x00021AD4 File Offset: 0x0001FCD4
			// (set) Token: 0x0600094D RID: 2381 RVA: 0x00021AEC File Offset: 0x0001FCEC
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_24_1.NativeStructWrapper.VY3A3i7nkFdUbPtUVCh(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 11);
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
							this.SetBit(NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 11, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0272cc4de9694915be17746e515675c8 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000313 RID: 787
			// (get) Token: 0x0600094E RID: 2382 RVA: 0x00021B54 File Offset: 0x0001FD54
			// (set) Token: 0x0600094F RID: 2383 RVA: 0x00021B60 File Offset: 0x0001FD60
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

			// Token: 0x06000950 RID: 2384 RVA: 0x00021B6C File Offset: 0x0001FD6C
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 3;
				int num2 = num;
				for (;;)
				{
					IntPtr intPtr;
					switch (num2)
					{
					case 1:
						nHwRpygmi6xxZAssJn.EmlEpH4Phw();
						num2 = 5;
						continue;
					case 2:
						NativeClassStructHandler_24_1.NativeStructWrapper.aJKdVd7xbG4pd5PaovT();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b169d8ea412f45e99e430384ddc8908b != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						NativeClassStructHandler_24_1.NativeStructWrapper.cCViLn7by4WAoPWIAb0();
						num2 = 2;
						continue;
					case 4:
						return;
					case 5:
						intPtr = Marshal.OffsetOf<NativeClassStructHandler_24_1.Il2CppClass_24_1>(NativeClassStructHandler_24_1.NativeStructWrapper.QFjNvZ76Grsssdv46CG(-1056993365 << 4 ^ 1421189265 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ce8abd079f9447b3bade260ffc64f0b8));
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6e0b93a59f7244c4b07385ec95383bee == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
					num2 = 4;
				}
			}

			// Token: 0x06000951 RID: 2385 RVA: 0x00021C58 File Offset: 0x0001FE58
			internal static void aJKdVd7xbG4pd5PaovT()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000952 RID: 2386 RVA: 0x00021C68 File Offset: 0x0001FE68
			internal static bool kODAa87tWa7MJfiVPTk()
			{
				return NativeClassStructHandler_24_1.NativeStructWrapper.OjNRZD7OMsH5934oMse == null;
			}

			// Token: 0x06000953 RID: 2387 RVA: 0x00021C7C File Offset: 0x0001FE7C
			internal static NativeClassStructHandler_24_1.NativeStructWrapper OuG7eA7vg1TjcHAbrww()
			{
				return NativeClassStructHandler_24_1.NativeStructWrapper.OjNRZD7OMsH5934oMse;
			}

			// Token: 0x06000954 RID: 2388 RVA: 0x00021C8C File Offset: 0x0001FE8C
			internal static void CKpojC7Yvh6P0lJ1COU(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000955 RID: 2389 RVA: 0x00021CAC File Offset: 0x0001FEAC
			internal static IntPtr pWC6Pn78mAPWg1tXGOI(IntPtr A_0, int A_1, object A_2)
			{
				return apS1BFcfBa3gXUspL9j.muOq5LWqgj(A_0, A_1, A_2);
			}

			// Token: 0x06000956 RID: 2390 RVA: 0x00021CC8 File Offset: 0x0001FEC8
			internal static bool VY3A3i7nkFdUbPtUVCh(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000957 RID: 2391 RVA: 0x00021CE4 File Offset: 0x0001FEE4
			internal static void cCViLn7by4WAoPWIAb0()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000958 RID: 2392 RVA: 0x00021CF4 File Offset: 0x0001FEF4
			internal static object QFjNvZ76Grsssdv46CG(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000609 RID: 1545
			private static readonly int _bitfield0offset;

			// Token: 0x0400060B RID: 1547
			private static object OjNRZD7OMsH5934oMse;
		}
	}
}
