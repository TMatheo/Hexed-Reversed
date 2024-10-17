using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000E5 RID: 229
	[ApplicableToUnityVersionsSince("2018.3.0")]
	public class NativeClassStructHandler_24_2 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x0600097A RID: 2426 RVA: 0x0001212C File Offset: 0x0001032C
		public int Size()
		{
			return sizeof(NativeClassStructHandler_24_2.Il2CppClass_24_2);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0001213C File Offset: 0x0001033C
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_24_2.Il2CppClass_24_2* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_24_2.bDmLEe6gCiCVIhrxtBQ(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_24_2.Il2CppClass_24_2);
			return new NativeClassStructHandler_24_2.NativeStructWrapper(ptr);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00012174 File Offset: 0x00010374
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2210d7ca22c24335b32d80ca3ef84b8e == 0)
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
			return new NativeClassStructHandler_24_2.NativeStructWrapper(ptr);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x000121DC File Offset: 0x000103DC
		public NativeClassStructHandler_24_2()
		{
			NativeClassStructHandler_24_2.Eaeya26lJWLdPejlnVM();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5d181dabf1ed42eca63023d24d927754 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00012240 File Offset: 0x00010440
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_24_2()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00012250 File Offset: 0x00010450
		internal static IntPtr bDmLEe6gCiCVIhrxtBQ(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00012264 File Offset: 0x00010464
		internal static bool lB6lWu6yscSO9HHwKIo()
		{
			return NativeClassStructHandler_24_2.fQW1BT62uPactq0sxOR == null;
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00012278 File Offset: 0x00010478
		internal static NativeClassStructHandler_24_2 S1ZGKg6SMjehLauKEie()
		{
			return NativeClassStructHandler_24_2.fQW1BT62uPactq0sxOR;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00012288 File Offset: 0x00010488
		internal static void Eaeya26lJWLdPejlnVM()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x04000617 RID: 1559
		private static NativeClassStructHandler_24_2 fQW1BT62uPactq0sxOR;

		// Token: 0x020000E6 RID: 230
		internal struct Il2CppClass_24_2
		{
			// Token: 0x04000618 RID: 1560
			public unsafe Il2CppImage* image;

			// Token: 0x04000619 RID: 1561
			public unsafe void* gc_desc;

			// Token: 0x0400061A RID: 1562
			public unsafe byte* name;

			// Token: 0x0400061B RID: 1563
			public unsafe byte* namespaze;

			// Token: 0x0400061C RID: 1564
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 byval_arg;

			// Token: 0x0400061D RID: 1565
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 this_arg;

			// Token: 0x0400061E RID: 1566
			public unsafe Il2CppClass* element_class;

			// Token: 0x0400061F RID: 1567
			public unsafe Il2CppClass* castClass;

			// Token: 0x04000620 RID: 1568
			public unsafe Il2CppClass* declaringType;

			// Token: 0x04000621 RID: 1569
			public unsafe Il2CppClass* parent;

			// Token: 0x04000622 RID: 1570
			public unsafe void* generic_class;

			// Token: 0x04000623 RID: 1571
			public unsafe void* typeDefinition;

			// Token: 0x04000624 RID: 1572
			public unsafe void* interopData;

			// Token: 0x04000625 RID: 1573
			public unsafe Il2CppClass* klass;

			// Token: 0x04000626 RID: 1574
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x04000627 RID: 1575
			public unsafe Il2CppEventInfo* events;

			// Token: 0x04000628 RID: 1576
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000629 RID: 1577
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x0400062A RID: 1578
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x0400062B RID: 1579
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x0400062C RID: 1580
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x0400062D RID: 1581
			public unsafe void* static_fields;

			// Token: 0x0400062E RID: 1582
			public unsafe void* rgctx_data;

			// Token: 0x0400062F RID: 1583
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x04000630 RID: 1584
			public uint initializationExceptionGCHandle;

			// Token: 0x04000631 RID: 1585
			public uint cctor_started;

			// Token: 0x04000632 RID: 1586
			public uint cctor_finished;

			// Token: 0x04000633 RID: 1587
			public ulong cctor_thread;

			// Token: 0x04000634 RID: 1588
			public int genericContainerIndex;

			// Token: 0x04000635 RID: 1589
			public uint instance_size;

			// Token: 0x04000636 RID: 1590
			public uint actualSize;

			// Token: 0x04000637 RID: 1591
			public uint element_size;

			// Token: 0x04000638 RID: 1592
			public int native_size;

			// Token: 0x04000639 RID: 1593
			public uint static_fields_size;

			// Token: 0x0400063A RID: 1594
			public uint thread_static_fields_size;

			// Token: 0x0400063B RID: 1595
			public int thread_static_fields_offset;

			// Token: 0x0400063C RID: 1596
			public uint flags;

			// Token: 0x0400063D RID: 1597
			public uint token;

			// Token: 0x0400063E RID: 1598
			public ushort method_count;

			// Token: 0x0400063F RID: 1599
			public ushort property_count;

			// Token: 0x04000640 RID: 1600
			public ushort field_count;

			// Token: 0x04000641 RID: 1601
			public ushort event_count;

			// Token: 0x04000642 RID: 1602
			public ushort nested_type_count;

			// Token: 0x04000643 RID: 1603
			public ushort vtable_count;

			// Token: 0x04000644 RID: 1604
			public ushort interfaces_count;

			// Token: 0x04000645 RID: 1605
			public ushort interface_offsets_count;

			// Token: 0x04000646 RID: 1606
			public byte typeHierarchyDepth;

			// Token: 0x04000647 RID: 1607
			public byte genericRecursionDepth;

			// Token: 0x04000648 RID: 1608
			public byte rank;

			// Token: 0x04000649 RID: 1609
			public byte minimumAlignment;

			// Token: 0x0400064A RID: 1610
			public byte packingSize;

			// Token: 0x0400064B RID: 1611
			public NativeClassStructHandler_24_2.Il2CppClass_24_2.Bitfield0 _bitfield0;

			// Token: 0x020000E7 RID: 231
			internal enum Bitfield0 : ushort
			{
				// Token: 0x0400064D RID: 1613
				BIT_initialized_and_no_error,
				// Token: 0x0400064E RID: 1614
				initialized_and_no_error,
				// Token: 0x0400064F RID: 1615
				BIT_valuetype = 1,
				// Token: 0x04000650 RID: 1616
				valuetype,
				// Token: 0x04000651 RID: 1617
				BIT_initialized = 2,
				// Token: 0x04000652 RID: 1618
				initialized = 4,
				// Token: 0x04000653 RID: 1619
				BIT_enumtype = 3,
				// Token: 0x04000654 RID: 1620
				enumtype = 8,
				// Token: 0x04000655 RID: 1621
				BIT_is_generic = 4,
				// Token: 0x04000656 RID: 1622
				is_generic = 16,
				// Token: 0x04000657 RID: 1623
				BIT_has_references = 5,
				// Token: 0x04000658 RID: 1624
				has_references = 32,
				// Token: 0x04000659 RID: 1625
				BIT_init_pending = 6,
				// Token: 0x0400065A RID: 1626
				init_pending = 64,
				// Token: 0x0400065B RID: 1627
				BIT_size_inited = 7,
				// Token: 0x0400065C RID: 1628
				size_inited = 128,
				// Token: 0x0400065D RID: 1629
				BIT_has_finalize = 8,
				// Token: 0x0400065E RID: 1630
				has_finalize = 256,
				// Token: 0x0400065F RID: 1631
				BIT_has_cctor = 9,
				// Token: 0x04000660 RID: 1632
				has_cctor = 512,
				// Token: 0x04000661 RID: 1633
				BIT_is_blittable = 10,
				// Token: 0x04000662 RID: 1634
				is_blittable = 1024,
				// Token: 0x04000663 RID: 1635
				BIT_is_import_or_windows_runtime = 11,
				// Token: 0x04000664 RID: 1636
				is_import_or_windows_runtime = 2048,
				// Token: 0x04000665 RID: 1637
				BIT_is_vtable_initialized = 12,
				// Token: 0x04000666 RID: 1638
				is_vtable_initialized = 4096,
				// Token: 0x04000667 RID: 1639
				BIT_has_initialization_error = 13,
				// Token: 0x04000668 RID: 1640
				has_initialization_error = 8192
			}
		}

		// Token: 0x020000E8 RID: 232
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000983 RID: 2435 RVA: 0x000229A0 File Offset: 0x00020BA0
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_24_2.NativeStructWrapper.sXrjoib1FuupDDQktn9();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc == 0)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_277c9fa6c1da46a98cc2f13643296b8f == 0)
					{
						num = 1;
					}
				}
			}

			// Token: 0x17000314 RID: 788
			// (get) Token: 0x06000984 RID: 2436 RVA: 0x00022A30 File Offset: 0x00020C30
			private unsafe NativeClassStructHandler_24_2.Il2CppClass_24_2* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000315 RID: 789
			// (get) Token: 0x06000985 RID: 2437 RVA: 0x00022A40 File Offset: 0x00020C40
			// (set) Token: 0x06000986 RID: 2438 RVA: 0x00022A58 File Offset: 0x00020C58
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_24_2.NativeStructWrapper.GYKprRbMtP9fYoaVBEf(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 5);
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
							NativeClassStructHandler_24_2.NativeStructWrapper.TMKVtJbpPyms4YlsRdA(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 5, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c != 0)
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

			// Token: 0x17000316 RID: 790
			// (get) Token: 0x06000987 RID: 2439 RVA: 0x00022ABC File Offset: 0x00020CBC
			public IntPtr Pointer { get; }

			// Token: 0x17000317 RID: 791
			// (get) Token: 0x06000988 RID: 2440 RVA: 0x00022ACC File Offset: 0x00020CCC
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_24_2.NativeStructWrapper.lqeNaNb4iA1D0Kvnla1(this.Pointer, sizeof(NativeClassStructHandler_24_2.Il2CppClass_24_2), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x17000318 RID: 792
			// (get) Token: 0x06000989 RID: 2441 RVA: 0x00022AEC File Offset: 0x00020CEC
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000319 RID: 793
			// (get) Token: 0x0600098A RID: 2442 RVA: 0x00022AFC File Offset: 0x00020CFC
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x1700031A RID: 794
			// (get) Token: 0x0600098B RID: 2443 RVA: 0x00022B18 File Offset: 0x00020D18
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x1700031B RID: 795
			// (get) Token: 0x0600098C RID: 2444 RVA: 0x00022B34 File Offset: 0x00020D34
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x1700031C RID: 796
			// (get) Token: 0x0600098D RID: 2445 RVA: 0x00022B48 File Offset: 0x00020D48
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x1700031D RID: 797
			// (get) Token: 0x0600098E RID: 2446 RVA: 0x00022B5C File Offset: 0x00020D5C
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x1700031E RID: 798
			// (get) Token: 0x0600098F RID: 2447 RVA: 0x00022B70 File Offset: 0x00020D70
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x1700031F RID: 799
			// (get) Token: 0x06000990 RID: 2448 RVA: 0x00022B84 File Offset: 0x00020D84
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x17000320 RID: 800
			// (get) Token: 0x06000991 RID: 2449 RVA: 0x00022B98 File Offset: 0x00020D98
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x17000321 RID: 801
			// (get) Token: 0x06000992 RID: 2450 RVA: 0x00022BAC File Offset: 0x00020DAC
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x17000322 RID: 802
			// (get) Token: 0x06000993 RID: 2451 RVA: 0x00022BC0 File Offset: 0x00020DC0
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x17000323 RID: 803
			// (get) Token: 0x06000994 RID: 2452 RVA: 0x00022BD4 File Offset: 0x00020DD4
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x17000324 RID: 804
			// (get) Token: 0x06000995 RID: 2453 RVA: 0x00022BE8 File Offset: 0x00020DE8
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x17000325 RID: 805
			// (get) Token: 0x06000996 RID: 2454 RVA: 0x00022C00 File Offset: 0x00020E00
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000326 RID: 806
			// (get) Token: 0x06000997 RID: 2455 RVA: 0x00022C18 File Offset: 0x00020E18
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x17000327 RID: 807
			// (get) Token: 0x06000998 RID: 2456 RVA: 0x00022C30 File Offset: 0x00020E30
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x17000328 RID: 808
			// (get) Token: 0x06000999 RID: 2457 RVA: 0x00022C44 File Offset: 0x00020E44
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000329 RID: 809
			// (get) Token: 0x0600099A RID: 2458 RVA: 0x00022C58 File Offset: 0x00020E58
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x1700032A RID: 810
			// (get) Token: 0x0600099B RID: 2459 RVA: 0x00022C6C File Offset: 0x00020E6C
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x1700032B RID: 811
			// (get) Token: 0x0600099C RID: 2460 RVA: 0x00022C80 File Offset: 0x00020E80
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x1700032C RID: 812
			// (get) Token: 0x0600099D RID: 2461 RVA: 0x00022C94 File Offset: 0x00020E94
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x1700032D RID: 813
			// (get) Token: 0x0600099E RID: 2462 RVA: 0x00022CA8 File Offset: 0x00020EA8
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x1700032E RID: 814
			// (get) Token: 0x0600099F RID: 2463 RVA: 0x00022CBC File Offset: 0x00020EBC
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x1700032F RID: 815
			// (get) Token: 0x060009A0 RID: 2464 RVA: 0x00022CD0 File Offset: 0x00020ED0
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x17000330 RID: 816
			// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00022CE4 File Offset: 0x00020EE4
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x17000331 RID: 817
			// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00022CF8 File Offset: 0x00020EF8
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x17000332 RID: 818
			// (get) Token: 0x060009A3 RID: 2467 RVA: 0x00022D0C File Offset: 0x00020F0C
			// (set) Token: 0x060009A4 RID: 2468 RVA: 0x00022D24 File Offset: 0x00020F24
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_24_2.NativeStructWrapper.GYKprRbMtP9fYoaVBEf(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_24_2.NativeStructWrapper.TMKVtJbpPyms4YlsRdA(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ea3a0368554c4e6093e0b0561ffd5cef == 0)
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

			// Token: 0x17000333 RID: 819
			// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00022D88 File Offset: 0x00020F88
			// (set) Token: 0x060009A6 RID: 2470 RVA: 0x00022DA0 File Offset: 0x00020FA0
			public bool Initialized
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_24_2.NativeStructWrapper.TMKVtJbpPyms4YlsRdA(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bd64431fd05f4961aa9b79e5bd243164 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000334 RID: 820
			// (get) Token: 0x060009A7 RID: 2471 RVA: 0x00022E04 File Offset: 0x00021004
			// (set) Token: 0x060009A8 RID: 2472 RVA: 0x00022E1C File Offset: 0x0002101C
			public bool EnumType
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_24_2.NativeStructWrapper.TMKVtJbpPyms4YlsRdA(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_944294969d634011bf30e3f4f506a31e != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000335 RID: 821
			// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00022E80 File Offset: 0x00021080
			// (set) Token: 0x060009AA RID: 2474 RVA: 0x00022E98 File Offset: 0x00021098
			public bool IsGeneric
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_24_2.NativeStructWrapper.TMKVtJbpPyms4YlsRdA(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7f5f35a413414ac0b2dfa27f953f90e9 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000336 RID: 822
			// (get) Token: 0x060009AB RID: 2475 RVA: 0x00022EFC File Offset: 0x000210FC
			// (set) Token: 0x060009AC RID: 2476 RVA: 0x00022F14 File Offset: 0x00021114
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_24_2.NativeStructWrapper.GYKprRbMtP9fYoaVBEf(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_24_2.NativeStructWrapper.TMKVtJbpPyms4YlsRdA(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5a8626d471f54eba873ce59c8785d9b9 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000337 RID: 823
			// (get) Token: 0x060009AD RID: 2477 RVA: 0x00022F78 File Offset: 0x00021178
			// (set) Token: 0x060009AE RID: 2478 RVA: 0x00022F90 File Offset: 0x00021190
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_24_2.NativeStructWrapper.GYKprRbMtP9fYoaVBEf(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 8);
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
							this.SetBit(NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 8, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fdb0528b1ef843aca29153aec62fa60d == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000338 RID: 824
			// (get) Token: 0x060009AF RID: 2479 RVA: 0x00022FF4 File Offset: 0x000211F4
			// (set) Token: 0x060009B0 RID: 2480 RVA: 0x0002300C File Offset: 0x0002120C
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_24_2.NativeStructWrapper.GYKprRbMtP9fYoaVBEf(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 12);
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
							NativeClassStructHandler_24_2.NativeStructWrapper.TMKVtJbpPyms4YlsRdA(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 12, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b8a2996bc299402b995470e3e8286d42 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000339 RID: 825
			// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00023074 File Offset: 0x00021274
			// (set) Token: 0x060009B2 RID: 2482 RVA: 0x0002308C File Offset: 0x0002128C
			public bool InitializedAndNoError
			{
				get
				{
					return NativeClassStructHandler_24_2.NativeStructWrapper.GYKprRbMtP9fYoaVBEf(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 0);
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
							this.SetBit(NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5afe19cf44424af2ad9aea85585a9cc2 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x060009B3 RID: 2483 RVA: 0x000230F0 File Offset: 0x000212F0
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
						NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_570d4e075bf443fcbaca8db32e007291 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						NativeClassStructHandler_24_2.NativeStructWrapper.sXrjoib1FuupDDQktn9();
						num2 = 5;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bd64431fd05f4961aa9b79e5bd243164 == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 4:
						NativeClassStructHandler_24_2.NativeStructWrapper.GFtpfvbzIKobbSgGURS();
						num2 = 3;
						continue;
					case 5:
						NativeClassStructHandler_24_2.NativeStructWrapper.qCmhw1fHJJj8G6O8SbU();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_82de010761f84d069578c758673e6648 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					intPtr = Marshal.OffsetOf<NativeClassStructHandler_24_2.Il2CppClass_24_2>(NativeClassStructHandler_24_2.NativeStructWrapper.u3UBQhfAvvwWmYS2PiV(-1084408557 ^ -182647083 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_db312e48eee84539b805fee2f73a8cde));
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_282cf292112a4cf49ec1b8b2e2e7602a != 0)
					{
						num2 = 2;
					}
				}
			}

			// Token: 0x060009B4 RID: 2484 RVA: 0x00023200 File Offset: 0x00021400
			internal static void sXrjoib1FuupDDQktn9()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060009B5 RID: 2485 RVA: 0x00023210 File Offset: 0x00021410
			internal static bool rgUiZsbnPKIH0xWXIls()
			{
				return NativeClassStructHandler_24_2.NativeStructWrapper.wu5cwHb5OBkhk9cUPDZ == null;
			}

			// Token: 0x060009B6 RID: 2486 RVA: 0x00023224 File Offset: 0x00021424
			internal static NativeClassStructHandler_24_2.NativeStructWrapper VHr1E8b3EMVnkoWPSA8()
			{
				return NativeClassStructHandler_24_2.NativeStructWrapper.wu5cwHb5OBkhk9cUPDZ;
			}

			// Token: 0x060009B7 RID: 2487 RVA: 0x00023234 File Offset: 0x00021434
			internal static bool GYKprRbMtP9fYoaVBEf(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060009B8 RID: 2488 RVA: 0x00023250 File Offset: 0x00021450
			internal static void TMKVtJbpPyms4YlsRdA(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x060009B9 RID: 2489 RVA: 0x00023270 File Offset: 0x00021470
			internal static IntPtr lqeNaNb4iA1D0Kvnla1(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x060009BA RID: 2490 RVA: 0x0002328C File Offset: 0x0002148C
			internal static void GFtpfvbzIKobbSgGURS()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x060009BB RID: 2491 RVA: 0x0002329C File Offset: 0x0002149C
			internal static void qCmhw1fHJJj8G6O8SbU()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x060009BC RID: 2492 RVA: 0x000232AC File Offset: 0x000214AC
			internal static object u3UBQhfAvvwWmYS2PiV(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000669 RID: 1641
			private static readonly int _bitfield0offset;

			// Token: 0x0400066B RID: 1643
			internal static object wu5cwHb5OBkhk9cUPDZ;
		}
	}
}
