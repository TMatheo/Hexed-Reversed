using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000E3 RID: 227
	[ApplicableToUnityVersionsSince("2018.3.0")]
	public class NativeClassStructHandler_24_2 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000959 RID: 2393 RVA: 0x00011524 File Offset: 0x0000F724
		public int Size()
		{
			return sizeof(NativeClassStructHandler_24_2.Il2CppClass_24_2);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00011534 File Offset: 0x0000F734
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_24_2.Il2CppClass_24_2* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_24_2.QlmRKUyp4CrkWYgRhNQ(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_24_2.Il2CppClass_24_2);
			return new NativeClassStructHandler_24_2.NativeStructWrapper(ptr);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0001156C File Offset: 0x0000F76C
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_892d6b14d02a4b94bf68e8edfebcd1f5 == 0)
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

		// Token: 0x0600095C RID: 2396 RVA: 0x000115D4 File Offset: 0x0000F7D4
		public NativeClassStructHandler_24_2()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeClassStructHandler_24_2.dEOeiAyVBPiT6pE4A4B();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_40fe2648722c4d04bef43cdd927d6154 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00011638 File Offset: 0x0000F838
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_24_2()
		{
			NativeClassStructHandler_24_2.nxYAsUy0tJXlI6FUtxk();
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00011648 File Offset: 0x0000F848
		internal static IntPtr QlmRKUyp4CrkWYgRhNQ(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0001165C File Offset: 0x0000F85C
		internal static bool zrAX74yy4pHWVHvp8RY()
		{
			return NativeClassStructHandler_24_2.g0xmApy6n89WqlT5TSy == null;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00011670 File Offset: 0x0000F870
		internal static NativeClassStructHandler_24_2 unyZZ4yJ4wlLTtvmre0()
		{
			return NativeClassStructHandler_24_2.g0xmApy6n89WqlT5TSy;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00011680 File Offset: 0x0000F880
		internal static void dEOeiAyVBPiT6pE4A4B()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00011690 File Offset: 0x0000F890
		internal static void nxYAsUy0tJXlI6FUtxk()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400060C RID: 1548
		internal static NativeClassStructHandler_24_2 g0xmApy6n89WqlT5TSy;

		// Token: 0x020000E4 RID: 228
		internal struct Il2CppClass_24_2
		{
			// Token: 0x0400060D RID: 1549
			public unsafe Il2CppImage* image;

			// Token: 0x0400060E RID: 1550
			public unsafe void* gc_desc;

			// Token: 0x0400060F RID: 1551
			public unsafe byte* name;

			// Token: 0x04000610 RID: 1552
			public unsafe byte* namespaze;

			// Token: 0x04000611 RID: 1553
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 byval_arg;

			// Token: 0x04000612 RID: 1554
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 this_arg;

			// Token: 0x04000613 RID: 1555
			public unsafe Il2CppClass* element_class;

			// Token: 0x04000614 RID: 1556
			public unsafe Il2CppClass* castClass;

			// Token: 0x04000615 RID: 1557
			public unsafe Il2CppClass* declaringType;

			// Token: 0x04000616 RID: 1558
			public unsafe Il2CppClass* parent;

			// Token: 0x04000617 RID: 1559
			public unsafe void* generic_class;

			// Token: 0x04000618 RID: 1560
			public unsafe void* typeDefinition;

			// Token: 0x04000619 RID: 1561
			public unsafe void* interopData;

			// Token: 0x0400061A RID: 1562
			public unsafe Il2CppClass* klass;

			// Token: 0x0400061B RID: 1563
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x0400061C RID: 1564
			public unsafe Il2CppEventInfo* events;

			// Token: 0x0400061D RID: 1565
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x0400061E RID: 1566
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x0400061F RID: 1567
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000620 RID: 1568
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x04000621 RID: 1569
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x04000622 RID: 1570
			public unsafe void* static_fields;

			// Token: 0x04000623 RID: 1571
			public unsafe void* rgctx_data;

			// Token: 0x04000624 RID: 1572
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x04000625 RID: 1573
			public uint initializationExceptionGCHandle;

			// Token: 0x04000626 RID: 1574
			public uint cctor_started;

			// Token: 0x04000627 RID: 1575
			public uint cctor_finished;

			// Token: 0x04000628 RID: 1576
			public ulong cctor_thread;

			// Token: 0x04000629 RID: 1577
			public int genericContainerIndex;

			// Token: 0x0400062A RID: 1578
			public uint instance_size;

			// Token: 0x0400062B RID: 1579
			public uint actualSize;

			// Token: 0x0400062C RID: 1580
			public uint element_size;

			// Token: 0x0400062D RID: 1581
			public int native_size;

			// Token: 0x0400062E RID: 1582
			public uint static_fields_size;

			// Token: 0x0400062F RID: 1583
			public uint thread_static_fields_size;

			// Token: 0x04000630 RID: 1584
			public int thread_static_fields_offset;

			// Token: 0x04000631 RID: 1585
			public uint flags;

			// Token: 0x04000632 RID: 1586
			public uint token;

			// Token: 0x04000633 RID: 1587
			public ushort method_count;

			// Token: 0x04000634 RID: 1588
			public ushort property_count;

			// Token: 0x04000635 RID: 1589
			public ushort field_count;

			// Token: 0x04000636 RID: 1590
			public ushort event_count;

			// Token: 0x04000637 RID: 1591
			public ushort nested_type_count;

			// Token: 0x04000638 RID: 1592
			public ushort vtable_count;

			// Token: 0x04000639 RID: 1593
			public ushort interfaces_count;

			// Token: 0x0400063A RID: 1594
			public ushort interface_offsets_count;

			// Token: 0x0400063B RID: 1595
			public byte typeHierarchyDepth;

			// Token: 0x0400063C RID: 1596
			public byte genericRecursionDepth;

			// Token: 0x0400063D RID: 1597
			public byte rank;

			// Token: 0x0400063E RID: 1598
			public byte minimumAlignment;

			// Token: 0x0400063F RID: 1599
			public byte packingSize;

			// Token: 0x04000640 RID: 1600
			public NativeClassStructHandler_24_2.Il2CppClass_24_2.Bitfield0 _bitfield0;

			// Token: 0x020000E5 RID: 229
			internal enum Bitfield0 : ushort
			{
				// Token: 0x04000642 RID: 1602
				BIT_initialized_and_no_error,
				// Token: 0x04000643 RID: 1603
				initialized_and_no_error,
				// Token: 0x04000644 RID: 1604
				BIT_valuetype = 1,
				// Token: 0x04000645 RID: 1605
				valuetype,
				// Token: 0x04000646 RID: 1606
				BIT_initialized = 2,
				// Token: 0x04000647 RID: 1607
				initialized = 4,
				// Token: 0x04000648 RID: 1608
				BIT_enumtype = 3,
				// Token: 0x04000649 RID: 1609
				enumtype = 8,
				// Token: 0x0400064A RID: 1610
				BIT_is_generic = 4,
				// Token: 0x0400064B RID: 1611
				is_generic = 16,
				// Token: 0x0400064C RID: 1612
				BIT_has_references = 5,
				// Token: 0x0400064D RID: 1613
				has_references = 32,
				// Token: 0x0400064E RID: 1614
				BIT_init_pending = 6,
				// Token: 0x0400064F RID: 1615
				init_pending = 64,
				// Token: 0x04000650 RID: 1616
				BIT_size_inited = 7,
				// Token: 0x04000651 RID: 1617
				size_inited = 128,
				// Token: 0x04000652 RID: 1618
				BIT_has_finalize = 8,
				// Token: 0x04000653 RID: 1619
				has_finalize = 256,
				// Token: 0x04000654 RID: 1620
				BIT_has_cctor = 9,
				// Token: 0x04000655 RID: 1621
				has_cctor = 512,
				// Token: 0x04000656 RID: 1622
				BIT_is_blittable = 10,
				// Token: 0x04000657 RID: 1623
				is_blittable = 1024,
				// Token: 0x04000658 RID: 1624
				BIT_is_import_or_windows_runtime = 11,
				// Token: 0x04000659 RID: 1625
				is_import_or_windows_runtime = 2048,
				// Token: 0x0400065A RID: 1626
				BIT_is_vtable_initialized = 12,
				// Token: 0x0400065B RID: 1627
				is_vtable_initialized = 4096,
				// Token: 0x0400065C RID: 1628
				BIT_has_initialization_error = 13,
				// Token: 0x0400065D RID: 1629
				has_initialization_error = 8192
			}
		}

		// Token: 0x020000E6 RID: 230
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000963 RID: 2403 RVA: 0x00021D08 File Offset: 0x0001FF08
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_24_2.NativeStructWrapper.cNOXmc7SfFlD9TcgUgU();
				NativeClassStructHandler_24_2.NativeStructWrapper.Qsioa97NSQRHcnQOhBR();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2a3cb7fb82fa47c39f707a2393c1a340 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_892d6b14d02a4b94bf68e8edfebcd1f5 == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x17000314 RID: 788
			// (get) Token: 0x06000964 RID: 2404 RVA: 0x00021D98 File Offset: 0x0001FF98
			private unsafe NativeClassStructHandler_24_2.Il2CppClass_24_2* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000315 RID: 789
			// (get) Token: 0x06000965 RID: 2405 RVA: 0x00021DA8 File Offset: 0x0001FFA8
			// (set) Token: 0x06000966 RID: 2406 RVA: 0x00021DC0 File Offset: 0x0001FFC0
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_24_2.NativeStructWrapper.gVb78x7usr7pexVNRXs(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 5);
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
							NativeClassStructHandler_24_2.NativeStructWrapper.Y3OKmx7D9yF5FWa4VDg(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 5, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7492c06848354e9185cf647bb6904451 == 0)
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
			// (get) Token: 0x06000967 RID: 2407 RVA: 0x00021E24 File Offset: 0x00020024
			public IntPtr Pointer { get; }

			// Token: 0x17000317 RID: 791
			// (get) Token: 0x06000968 RID: 2408 RVA: 0x00021E34 File Offset: 0x00020034
			public IntPtr VTable
			{
				get
				{
					return apS1BFcfBa3gXUspL9j.muOq5LWqgj(this.Pointer, sizeof(NativeClassStructHandler_24_2.Il2CppClass_24_2), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x17000318 RID: 792
			// (get) Token: 0x06000969 RID: 2409 RVA: 0x00021E54 File Offset: 0x00020054
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000319 RID: 793
			// (get) Token: 0x0600096A RID: 2410 RVA: 0x00021E64 File Offset: 0x00020064
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x1700031A RID: 794
			// (get) Token: 0x0600096B RID: 2411 RVA: 0x00021E80 File Offset: 0x00020080
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x1700031B RID: 795
			// (get) Token: 0x0600096C RID: 2412 RVA: 0x00021E9C File Offset: 0x0002009C
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x1700031C RID: 796
			// (get) Token: 0x0600096D RID: 2413 RVA: 0x00021EB0 File Offset: 0x000200B0
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x1700031D RID: 797
			// (get) Token: 0x0600096E RID: 2414 RVA: 0x00021EC4 File Offset: 0x000200C4
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x1700031E RID: 798
			// (get) Token: 0x0600096F RID: 2415 RVA: 0x00021ED8 File Offset: 0x000200D8
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x1700031F RID: 799
			// (get) Token: 0x06000970 RID: 2416 RVA: 0x00021EEC File Offset: 0x000200EC
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x17000320 RID: 800
			// (get) Token: 0x06000971 RID: 2417 RVA: 0x00021F00 File Offset: 0x00020100
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x17000321 RID: 801
			// (get) Token: 0x06000972 RID: 2418 RVA: 0x00021F14 File Offset: 0x00020114
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x17000322 RID: 802
			// (get) Token: 0x06000973 RID: 2419 RVA: 0x00021F28 File Offset: 0x00020128
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x17000323 RID: 803
			// (get) Token: 0x06000974 RID: 2420 RVA: 0x00021F3C File Offset: 0x0002013C
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x17000324 RID: 804
			// (get) Token: 0x06000975 RID: 2421 RVA: 0x00021F50 File Offset: 0x00020150
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x17000325 RID: 805
			// (get) Token: 0x06000976 RID: 2422 RVA: 0x00021F68 File Offset: 0x00020168
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000326 RID: 806
			// (get) Token: 0x06000977 RID: 2423 RVA: 0x00021F80 File Offset: 0x00020180
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x17000327 RID: 807
			// (get) Token: 0x06000978 RID: 2424 RVA: 0x00021F98 File Offset: 0x00020198
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x17000328 RID: 808
			// (get) Token: 0x06000979 RID: 2425 RVA: 0x00021FAC File Offset: 0x000201AC
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000329 RID: 809
			// (get) Token: 0x0600097A RID: 2426 RVA: 0x00021FC0 File Offset: 0x000201C0
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x1700032A RID: 810
			// (get) Token: 0x0600097B RID: 2427 RVA: 0x00021FD4 File Offset: 0x000201D4
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x1700032B RID: 811
			// (get) Token: 0x0600097C RID: 2428 RVA: 0x00021FE8 File Offset: 0x000201E8
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x1700032C RID: 812
			// (get) Token: 0x0600097D RID: 2429 RVA: 0x00021FFC File Offset: 0x000201FC
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x1700032D RID: 813
			// (get) Token: 0x0600097E RID: 2430 RVA: 0x00022010 File Offset: 0x00020210
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x1700032E RID: 814
			// (get) Token: 0x0600097F RID: 2431 RVA: 0x00022024 File Offset: 0x00020224
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x1700032F RID: 815
			// (get) Token: 0x06000980 RID: 2432 RVA: 0x00022038 File Offset: 0x00020238
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x17000330 RID: 816
			// (get) Token: 0x06000981 RID: 2433 RVA: 0x0002204C File Offset: 0x0002024C
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x17000331 RID: 817
			// (get) Token: 0x06000982 RID: 2434 RVA: 0x00022060 File Offset: 0x00020260
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x17000332 RID: 818
			// (get) Token: 0x06000983 RID: 2435 RVA: 0x00022074 File Offset: 0x00020274
			// (set) Token: 0x06000984 RID: 2436 RVA: 0x0002208C File Offset: 0x0002028C
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_24_2.NativeStructWrapper.gVb78x7usr7pexVNRXs(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 1);
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
							this.SetBit(NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7ac65c3fd4cb4629a8b893be89aed17d != 0)
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
			// (get) Token: 0x06000985 RID: 2437 RVA: 0x000220F0 File Offset: 0x000202F0
			// (set) Token: 0x06000986 RID: 2438 RVA: 0x00022108 File Offset: 0x00020308
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_24_2.NativeStructWrapper.gVb78x7usr7pexVNRXs(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_24_2.NativeStructWrapper.Y3OKmx7D9yF5FWa4VDg(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6dbfd13d96434eb59d868fecd0ad1cda == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000334 RID: 820
			// (get) Token: 0x06000987 RID: 2439 RVA: 0x0002216C File Offset: 0x0002036C
			// (set) Token: 0x06000988 RID: 2440 RVA: 0x00022184 File Offset: 0x00020384
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
						case 1:
							NativeClassStructHandler_24_2.NativeStructWrapper.Y3OKmx7D9yF5FWa4VDg(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b5e8e4146b4a178d711afdb1274991 == 0)
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

			// Token: 0x17000335 RID: 821
			// (get) Token: 0x06000989 RID: 2441 RVA: 0x000221E8 File Offset: 0x000203E8
			// (set) Token: 0x0600098A RID: 2442 RVA: 0x00022200 File Offset: 0x00020400
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_24_2.NativeStructWrapper.gVb78x7usr7pexVNRXs(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_24_2.NativeStructWrapper.Y3OKmx7D9yF5FWa4VDg(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_734db430e12345289ec4ae0afacc44df == 0)
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

			// Token: 0x17000336 RID: 822
			// (get) Token: 0x0600098B RID: 2443 RVA: 0x00022264 File Offset: 0x00020464
			// (set) Token: 0x0600098C RID: 2444 RVA: 0x0002227C File Offset: 0x0002047C
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_24_2.NativeStructWrapper.gVb78x7usr7pexVNRXs(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_24_2.NativeStructWrapper.Y3OKmx7D9yF5FWa4VDg(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7fef7bb77728417ab4965dd0775b5899 != 0)
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

			// Token: 0x17000337 RID: 823
			// (get) Token: 0x0600098D RID: 2445 RVA: 0x000222E0 File Offset: 0x000204E0
			// (set) Token: 0x0600098E RID: 2446 RVA: 0x000222F8 File Offset: 0x000204F8
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_24_2.NativeStructWrapper.gVb78x7usr7pexVNRXs(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 8);
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
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c975b252adfc48c4b262398638f90354 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000338 RID: 824
			// (get) Token: 0x0600098F RID: 2447 RVA: 0x0002235C File Offset: 0x0002055C
			// (set) Token: 0x06000990 RID: 2448 RVA: 0x00022374 File Offset: 0x00020574
			public bool IsVtableInitialized
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 12);
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
							NativeClassStructHandler_24_2.NativeStructWrapper.Y3OKmx7D9yF5FWa4VDg(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 12, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_40fe2648722c4d04bef43cdd927d6154 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000339 RID: 825
			// (get) Token: 0x06000991 RID: 2449 RVA: 0x000223DC File Offset: 0x000205DC
			// (set) Token: 0x06000992 RID: 2450 RVA: 0x000223F4 File Offset: 0x000205F4
			public bool InitializedAndNoError
			{
				get
				{
					return NativeClassStructHandler_24_2.NativeStructWrapper.gVb78x7usr7pexVNRXs(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_24_2.NativeStructWrapper.Y3OKmx7D9yF5FWa4VDg(this, NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_40fe2648722c4d04bef43cdd927d6154 == 0)
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

			// Token: 0x06000993 RID: 2451 RVA: 0x00022458 File Offset: 0x00020658
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 2;
				for (;;)
				{
					int num2 = num;
					IntPtr intPtr;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							hIDAYxH6DWLHIthQgC.oDuBOTgYK();
							num2 = 5;
							continue;
						case 2:
							hIDAYxH6DWLHIthQgC.zSLipEDdx();
							num2 = 1;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_1f1b1b07c9f5435991b0738ea3210852 != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							return;
						case 4:
							intPtr = Marshal.OffsetOf<NativeClassStructHandler_24_2.Il2CppClass_24_2>(NativeClassStructHandler_24_2.NativeStructWrapper.GqKmv17maMKM24htQC0(1919189329 ^ 553467158 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb34a81d7cc4fbea898664370a8645f));
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 5:
							NativeClassStructHandler_24_2.NativeStructWrapper.Qsioa97NSQRHcnQOhBR();
							num2 = 4;
							continue;
						}
						break;
					}
					IL_BF:
					NativeClassStructHandler_24_2.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
					num = 3;
					continue;
					goto IL_BF;
				}
			}

			// Token: 0x06000994 RID: 2452 RVA: 0x00022544 File Offset: 0x00020744
			internal static void cNOXmc7SfFlD9TcgUgU()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000995 RID: 2453 RVA: 0x00022554 File Offset: 0x00020754
			internal static void Qsioa97NSQRHcnQOhBR()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000996 RID: 2454 RVA: 0x00022564 File Offset: 0x00020764
			internal static bool XatXeA70WqTAGvCIvCM()
			{
				return NativeClassStructHandler_24_2.NativeStructWrapper.RpNYu47VKj0VldkkH5A == null;
			}

			// Token: 0x06000997 RID: 2455 RVA: 0x00022578 File Offset: 0x00020778
			internal static NativeClassStructHandler_24_2.NativeStructWrapper L7hYYu7sILKfH885Vs4()
			{
				return NativeClassStructHandler_24_2.NativeStructWrapper.RpNYu47VKj0VldkkH5A;
			}

			// Token: 0x06000998 RID: 2456 RVA: 0x00022588 File Offset: 0x00020788
			internal static bool gVb78x7usr7pexVNRXs(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000999 RID: 2457 RVA: 0x000225A4 File Offset: 0x000207A4
			internal static void Y3OKmx7D9yF5FWa4VDg(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x0600099A RID: 2458 RVA: 0x000225C4 File Offset: 0x000207C4
			internal static object GqKmv17maMKM24htQC0(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x0400065E RID: 1630
			private static readonly int _bitfield0offset;

			// Token: 0x04000660 RID: 1632
			private static object RpNYu47VKj0VldkkH5A;
		}
	}
}
