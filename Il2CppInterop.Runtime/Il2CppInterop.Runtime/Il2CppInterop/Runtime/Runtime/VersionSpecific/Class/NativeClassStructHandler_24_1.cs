using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000E1 RID: 225
	[ApplicableToUnityVersionsSince("2018.2.0")]
	public class NativeClassStructHandler_24_1 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000935 RID: 2357 RVA: 0x00011FA0 File Offset: 0x000101A0
		public int Size()
		{
			return sizeof(NativeClassStructHandler_24_1.Il2CppClass_24_1);
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00011FB0 File Offset: 0x000101B0
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_24_1.Il2CppClass_24_1* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_24_1.uUUjE46w97bE0ggXuNG(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_24_1.Il2CppClass_24_1);
			return new NativeClassStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00011FE8 File Offset: 0x000101E8
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_74d61b1611df4615bd4df289712ea178 != 0)
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
			return new NativeClassStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00012050 File Offset: 0x00010250
		public NativeClassStructHandler_24_1()
		{
			NativeClassStructHandler_24_1.ulTeKV6eS0rhRGHXwrY();
			NativeClassStructHandler_24_1.UjwHFa6slLdMQeF8dbw();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_468d644ed32a4ba3ad77ef2c95e2ad4b != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x000120B4 File Offset: 0x000102B4
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_24_1()
		{
			NativeClassStructHandler_24_1.RvHYRS6QHQAbaTWM31m();
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x000120C4 File Offset: 0x000102C4
		internal static IntPtr uUUjE46w97bE0ggXuNG(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000120D8 File Offset: 0x000102D8
		internal static bool IsF54a6Ppn64Ks5AmsR()
		{
			return NativeClassStructHandler_24_1.WZtRLp6f3lkFUmJq3Fg == null;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000120EC File Offset: 0x000102EC
		internal static NativeClassStructHandler_24_1 TbNVIL6dGxhqc0xmycN()
		{
			return NativeClassStructHandler_24_1.WZtRLp6f3lkFUmJq3Fg;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000120FC File Offset: 0x000102FC
		internal static void ulTeKV6eS0rhRGHXwrY()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0001210C File Offset: 0x0001030C
		internal static void UjwHFa6slLdMQeF8dbw()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0001211C File Offset: 0x0001031C
		internal static void RvHYRS6QHQAbaTWM31m()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040005C3 RID: 1475
		internal static NativeClassStructHandler_24_1 WZtRLp6f3lkFUmJq3Fg;

		// Token: 0x020000E2 RID: 226
		internal struct Il2CppClass_24_1
		{
			// Token: 0x040005C4 RID: 1476
			public unsafe Il2CppImage* image;

			// Token: 0x040005C5 RID: 1477
			public unsafe void* gc_desc;

			// Token: 0x040005C6 RID: 1478
			public unsafe byte* name;

			// Token: 0x040005C7 RID: 1479
			public unsafe byte* namespaze;

			// Token: 0x040005C8 RID: 1480
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 byval_arg;

			// Token: 0x040005C9 RID: 1481
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 this_arg;

			// Token: 0x040005CA RID: 1482
			public unsafe Il2CppClass* element_class;

			// Token: 0x040005CB RID: 1483
			public unsafe Il2CppClass* castClass;

			// Token: 0x040005CC RID: 1484
			public unsafe Il2CppClass* declaringType;

			// Token: 0x040005CD RID: 1485
			public unsafe Il2CppClass* parent;

			// Token: 0x040005CE RID: 1486
			public unsafe void* generic_class;

			// Token: 0x040005CF RID: 1487
			public unsafe void* typeDefinition;

			// Token: 0x040005D0 RID: 1488
			public unsafe void* interopData;

			// Token: 0x040005D1 RID: 1489
			public unsafe Il2CppClass* klass;

			// Token: 0x040005D2 RID: 1490
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x040005D3 RID: 1491
			public unsafe Il2CppEventInfo* events;

			// Token: 0x040005D4 RID: 1492
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x040005D5 RID: 1493
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x040005D6 RID: 1494
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x040005D7 RID: 1495
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x040005D8 RID: 1496
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x040005D9 RID: 1497
			public unsafe void* static_fields;

			// Token: 0x040005DA RID: 1498
			public unsafe void* rgctx_data;

			// Token: 0x040005DB RID: 1499
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x040005DC RID: 1500
			public uint initializationExceptionGCHandle;

			// Token: 0x040005DD RID: 1501
			public uint cctor_started;

			// Token: 0x040005DE RID: 1502
			public uint cctor_finished;

			// Token: 0x040005DF RID: 1503
			public ulong cctor_thread;

			// Token: 0x040005E0 RID: 1504
			public int genericContainerIndex;

			// Token: 0x040005E1 RID: 1505
			public int customAttributeIndex;

			// Token: 0x040005E2 RID: 1506
			public uint instance_size;

			// Token: 0x040005E3 RID: 1507
			public uint actualSize;

			// Token: 0x040005E4 RID: 1508
			public uint element_size;

			// Token: 0x040005E5 RID: 1509
			public int native_size;

			// Token: 0x040005E6 RID: 1510
			public uint static_fields_size;

			// Token: 0x040005E7 RID: 1511
			public uint thread_static_fields_size;

			// Token: 0x040005E8 RID: 1512
			public int thread_static_fields_offset;

			// Token: 0x040005E9 RID: 1513
			public uint flags;

			// Token: 0x040005EA RID: 1514
			public uint token;

			// Token: 0x040005EB RID: 1515
			public ushort method_count;

			// Token: 0x040005EC RID: 1516
			public ushort property_count;

			// Token: 0x040005ED RID: 1517
			public ushort field_count;

			// Token: 0x040005EE RID: 1518
			public ushort event_count;

			// Token: 0x040005EF RID: 1519
			public ushort nested_type_count;

			// Token: 0x040005F0 RID: 1520
			public ushort vtable_count;

			// Token: 0x040005F1 RID: 1521
			public ushort interfaces_count;

			// Token: 0x040005F2 RID: 1522
			public ushort interface_offsets_count;

			// Token: 0x040005F3 RID: 1523
			public byte typeHierarchyDepth;

			// Token: 0x040005F4 RID: 1524
			public byte genericRecursionDepth;

			// Token: 0x040005F5 RID: 1525
			public byte rank;

			// Token: 0x040005F6 RID: 1526
			public byte minimumAlignment;

			// Token: 0x040005F7 RID: 1527
			public byte packingSize;

			// Token: 0x040005F8 RID: 1528
			public NativeClassStructHandler_24_1.Il2CppClass_24_1.Bitfield0 _bitfield0;

			// Token: 0x020000E3 RID: 227
			internal enum Bitfield0 : ushort
			{
				// Token: 0x040005FA RID: 1530
				BIT_valuetype,
				// Token: 0x040005FB RID: 1531
				valuetype,
				// Token: 0x040005FC RID: 1532
				BIT_initialized = 1,
				// Token: 0x040005FD RID: 1533
				initialized,
				// Token: 0x040005FE RID: 1534
				BIT_enumtype = 2,
				// Token: 0x040005FF RID: 1535
				enumtype = 4,
				// Token: 0x04000600 RID: 1536
				BIT_is_generic = 3,
				// Token: 0x04000601 RID: 1537
				is_generic = 8,
				// Token: 0x04000602 RID: 1538
				BIT_has_references = 4,
				// Token: 0x04000603 RID: 1539
				has_references = 16,
				// Token: 0x04000604 RID: 1540
				BIT_init_pending = 5,
				// Token: 0x04000605 RID: 1541
				init_pending = 32,
				// Token: 0x04000606 RID: 1542
				BIT_size_inited = 6,
				// Token: 0x04000607 RID: 1543
				size_inited = 64,
				// Token: 0x04000608 RID: 1544
				BIT_has_finalize = 7,
				// Token: 0x04000609 RID: 1545
				has_finalize = 128,
				// Token: 0x0400060A RID: 1546
				BIT_has_cctor = 8,
				// Token: 0x0400060B RID: 1547
				has_cctor = 256,
				// Token: 0x0400060C RID: 1548
				BIT_is_blittable = 9,
				// Token: 0x0400060D RID: 1549
				is_blittable = 512,
				// Token: 0x0400060E RID: 1550
				BIT_is_import_or_windows_runtime = 10,
				// Token: 0x0400060F RID: 1551
				is_import_or_windows_runtime = 1024,
				// Token: 0x04000610 RID: 1552
				BIT_is_vtable_initialized = 11,
				// Token: 0x04000611 RID: 1553
				is_vtable_initialized = 2048,
				// Token: 0x04000612 RID: 1554
				BIT_has_initialization_error = 12,
				// Token: 0x04000613 RID: 1555
				has_initialization_error = 4096
			}
		}

		// Token: 0x020000E4 RID: 228
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000940 RID: 2368 RVA: 0x00022104 File Offset: 0x00020304
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_24_1.NativeStructWrapper.yf0jDGbVE5d32mwxSYR();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_944294969d634011bf30e3f4f506a31e != 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56c162609824bd799f0a7b9a8c33c89 == 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x170002EE RID: 750
			// (get) Token: 0x06000941 RID: 2369 RVA: 0x00022194 File Offset: 0x00020394
			private unsafe NativeClassStructHandler_24_1.Il2CppClass_24_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170002EF RID: 751
			// (get) Token: 0x06000942 RID: 2370 RVA: 0x000221A4 File Offset: 0x000203A4
			// (set) Token: 0x06000943 RID: 2371 RVA: 0x000221BC File Offset: 0x000203BC
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_24_1.NativeStructWrapper.mBP6TqbOrg68THdkejU(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 4);
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
							this.SetBit(NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_46ba390073ec4df6883860abf17dbf6f != 0)
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
			// (get) Token: 0x06000944 RID: 2372 RVA: 0x00022220 File Offset: 0x00020420
			public IntPtr Pointer { get; }

			// Token: 0x170002F1 RID: 753
			// (get) Token: 0x06000945 RID: 2373 RVA: 0x00022230 File Offset: 0x00020430
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_24_1.NativeStructWrapper.o9qcIBbXDrP85vP50K8(this.Pointer, sizeof(NativeClassStructHandler_24_1.Il2CppClass_24_1), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x170002F2 RID: 754
			// (get) Token: 0x06000946 RID: 2374 RVA: 0x00022250 File Offset: 0x00020450
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170002F3 RID: 755
			// (get) Token: 0x06000947 RID: 2375 RVA: 0x00022260 File Offset: 0x00020460
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x170002F4 RID: 756
			// (get) Token: 0x06000948 RID: 2376 RVA: 0x0002227C File Offset: 0x0002047C
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x170002F5 RID: 757
			// (get) Token: 0x06000949 RID: 2377 RVA: 0x00022298 File Offset: 0x00020498
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x170002F6 RID: 758
			// (get) Token: 0x0600094A RID: 2378 RVA: 0x000222AC File Offset: 0x000204AC
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x170002F7 RID: 759
			// (get) Token: 0x0600094B RID: 2379 RVA: 0x000222C0 File Offset: 0x000204C0
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x170002F8 RID: 760
			// (get) Token: 0x0600094C RID: 2380 RVA: 0x000222D4 File Offset: 0x000204D4
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x170002F9 RID: 761
			// (get) Token: 0x0600094D RID: 2381 RVA: 0x000222E8 File Offset: 0x000204E8
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x170002FA RID: 762
			// (get) Token: 0x0600094E RID: 2382 RVA: 0x000222FC File Offset: 0x000204FC
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x170002FB RID: 763
			// (get) Token: 0x0600094F RID: 2383 RVA: 0x00022310 File Offset: 0x00020510
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x170002FC RID: 764
			// (get) Token: 0x06000950 RID: 2384 RVA: 0x00022324 File Offset: 0x00020524
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x170002FD RID: 765
			// (get) Token: 0x06000951 RID: 2385 RVA: 0x00022338 File Offset: 0x00020538
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x170002FE RID: 766
			// (get) Token: 0x06000952 RID: 2386 RVA: 0x0002234C File Offset: 0x0002054C
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x170002FF RID: 767
			// (get) Token: 0x06000953 RID: 2387 RVA: 0x00022364 File Offset: 0x00020564
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000300 RID: 768
			// (get) Token: 0x06000954 RID: 2388 RVA: 0x0002237C File Offset: 0x0002057C
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x17000301 RID: 769
			// (get) Token: 0x06000955 RID: 2389 RVA: 0x00022394 File Offset: 0x00020594
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x17000302 RID: 770
			// (get) Token: 0x06000956 RID: 2390 RVA: 0x000223A8 File Offset: 0x000205A8
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000303 RID: 771
			// (get) Token: 0x06000957 RID: 2391 RVA: 0x000223BC File Offset: 0x000205BC
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x17000304 RID: 772
			// (get) Token: 0x06000958 RID: 2392 RVA: 0x000223D0 File Offset: 0x000205D0
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x17000305 RID: 773
			// (get) Token: 0x06000959 RID: 2393 RVA: 0x000223E4 File Offset: 0x000205E4
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x17000306 RID: 774
			// (get) Token: 0x0600095A RID: 2394 RVA: 0x000223F8 File Offset: 0x000205F8
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x17000307 RID: 775
			// (get) Token: 0x0600095B RID: 2395 RVA: 0x0002240C File Offset: 0x0002060C
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x17000308 RID: 776
			// (get) Token: 0x0600095C RID: 2396 RVA: 0x00022420 File Offset: 0x00020620
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x17000309 RID: 777
			// (get) Token: 0x0600095D RID: 2397 RVA: 0x00022434 File Offset: 0x00020634
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x1700030A RID: 778
			// (get) Token: 0x0600095E RID: 2398 RVA: 0x00022448 File Offset: 0x00020648
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x1700030B RID: 779
			// (get) Token: 0x0600095F RID: 2399 RVA: 0x0002245C File Offset: 0x0002065C
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x1700030C RID: 780
			// (get) Token: 0x06000960 RID: 2400 RVA: 0x00022470 File Offset: 0x00020670
			// (set) Token: 0x06000961 RID: 2401 RVA: 0x00022488 File Offset: 0x00020688
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_24_1.NativeStructWrapper.mBP6TqbOrg68THdkejU(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_24_1.NativeStructWrapper.YMWELPbmJRttOOQpPUG(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2dd85386720b438b874026b47430e4fa != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700030D RID: 781
			// (get) Token: 0x06000962 RID: 2402 RVA: 0x000224EC File Offset: 0x000206EC
			// (set) Token: 0x06000963 RID: 2403 RVA: 0x00022504 File Offset: 0x00020704
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
							NativeClassStructHandler_24_1.NativeStructWrapper.YMWELPbmJRttOOQpPUG(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6926da1cf80047d3a6f0516668d22380 == 0)
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
			// (get) Token: 0x06000964 RID: 2404 RVA: 0x00022568 File Offset: 0x00020768
			// (set) Token: 0x06000965 RID: 2405 RVA: 0x00022580 File Offset: 0x00020780
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_24_1.NativeStructWrapper.mBP6TqbOrg68THdkejU(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_24_1.NativeStructWrapper.YMWELPbmJRttOOQpPUG(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_16defe672aac4a3485dcd78387beb521 == 0)
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
			// (get) Token: 0x06000966 RID: 2406 RVA: 0x000225E4 File Offset: 0x000207E4
			// (set) Token: 0x06000967 RID: 2407 RVA: 0x000225FC File Offset: 0x000207FC
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
							NativeClassStructHandler_24_1.NativeStructWrapper.YMWELPbmJRttOOQpPUG(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_570d4e075bf443fcbaca8db32e007291 == 0)
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
			// (get) Token: 0x06000968 RID: 2408 RVA: 0x00022660 File Offset: 0x00020860
			// (set) Token: 0x06000969 RID: 2409 RVA: 0x00022678 File Offset: 0x00020878
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_24_1.NativeStructWrapper.mBP6TqbOrg68THdkejU(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 6);
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
							NativeClassStructHandler_24_1.NativeStructWrapper.YMWELPbmJRttOOQpPUG(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b8a2996bc299402b995470e3e8286d42 == 0)
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
			// (get) Token: 0x0600096A RID: 2410 RVA: 0x000226DC File Offset: 0x000208DC
			// (set) Token: 0x0600096B RID: 2411 RVA: 0x000226F4 File Offset: 0x000208F4
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_24_1.NativeStructWrapper.mBP6TqbOrg68THdkejU(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_24_1.NativeStructWrapper.YMWELPbmJRttOOQpPUG(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_78bdbfb54f5c42368a7dbf88905820e8 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000312 RID: 786
			// (get) Token: 0x0600096C RID: 2412 RVA: 0x00022758 File Offset: 0x00020958
			// (set) Token: 0x0600096D RID: 2413 RVA: 0x00022770 File Offset: 0x00020970
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_24_1.NativeStructWrapper.mBP6TqbOrg68THdkejU(this, NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 11);
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
							this.SetBit(NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset, 11, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_40875ab50e1c43f7bf4d96946e4523cb != 0)
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

			// Token: 0x17000313 RID: 787
			// (get) Token: 0x0600096E RID: 2414 RVA: 0x000227D8 File Offset: 0x000209D8
			// (set) Token: 0x0600096F RID: 2415 RVA: 0x000227E4 File Offset: 0x000209E4
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

			// Token: 0x06000970 RID: 2416 RVA: 0x000227F0 File Offset: 0x000209F0
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 1;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							NativeClassStructHandler_24_1.NativeStructWrapper.PibdXHbvNDU5m5xrC9f();
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c4640bbaac7c4988b56f91d1b6b3f1a9 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							return;
						case 3:
							NativeClassStructHandler_24_1.NativeStructWrapper.S2Uj6obBJVtHLm48R0C();
							num2 = 4;
							continue;
						case 4:
						{
							IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_24_1.Il2CppClass_24_1>(NativeClassStructHandler_24_1.NativeStructWrapper.ufCuYsbj6TYvFsRmBDA(1980509011 - -1178533388 ^ -1288455849 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40));
							num2 = 5;
							continue;
						}
						case 5:
						{
							IntPtr intPtr;
							NativeClassStructHandler_24_1.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
							num2 = 2;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c32cfeb41f7a43999be3bae16a94ad02 == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						}
						}
						break;
					}
					IL_9F:
					hIDAYxH6DWLHIthQgC.oDuBOTgYK();
					num = 3;
					continue;
					goto IL_9F;
				}
			}

			// Token: 0x06000971 RID: 2417 RVA: 0x000228E0 File Offset: 0x00020AE0
			internal static void yf0jDGbVE5d32mwxSYR()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000972 RID: 2418 RVA: 0x000228F0 File Offset: 0x00020AF0
			internal static bool lOL85kbgWOv4bi74Aw8()
			{
				return NativeClassStructHandler_24_1.NativeStructWrapper.gDDa1HbSO4u6wr7KlgU == null;
			}

			// Token: 0x06000973 RID: 2419 RVA: 0x00022904 File Offset: 0x00020B04
			internal static NativeClassStructHandler_24_1.NativeStructWrapper zAQosKblaagVYPD6Bwk()
			{
				return NativeClassStructHandler_24_1.NativeStructWrapper.gDDa1HbSO4u6wr7KlgU;
			}

			// Token: 0x06000974 RID: 2420 RVA: 0x00022914 File Offset: 0x00020B14
			internal static bool mBP6TqbOrg68THdkejU(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000975 RID: 2421 RVA: 0x00022930 File Offset: 0x00020B30
			internal static IntPtr o9qcIBbXDrP85vP50K8(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x06000976 RID: 2422 RVA: 0x0002294C File Offset: 0x00020B4C
			internal static void YMWELPbmJRttOOQpPUG(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000977 RID: 2423 RVA: 0x0002296C File Offset: 0x00020B6C
			internal static void PibdXHbvNDU5m5xrC9f()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000978 RID: 2424 RVA: 0x0002297C File Offset: 0x00020B7C
			internal static void S2Uj6obBJVtHLm48R0C()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000979 RID: 2425 RVA: 0x0002298C File Offset: 0x00020B8C
			internal static object ufCuYsbj6TYvFsRmBDA(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000614 RID: 1556
			private static readonly int _bitfield0offset;

			// Token: 0x04000616 RID: 1558
			internal static object gDDa1HbSO4u6wr7KlgU;
		}
	}
}
