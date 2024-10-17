using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000E9 RID: 233
	[ApplicableToUnityVersionsSince("2018.3.8")]
	public class NativeClassStructHandler_24_3 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x060009BD RID: 2493 RVA: 0x00012298 File Offset: 0x00010498
		public int Size()
		{
			return sizeof(NativeClassStructHandler_24_3.Il2CppClass_24_3);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x000122A8 File Offset: 0x000104A8
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_24_3.Il2CppClass_24_3* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_24_3.qMdPPK6m8GNJIMteKR8(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_24_3.Il2CppClass_24_3);
			return new NativeClassStructHandler_24_3.NativeStructWrapper(ptr);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x000122E0 File Offset: 0x000104E0
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_eea945ea6be345c0b18511ac11610b35 == 0)
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
			return new NativeClassStructHandler_24_3.NativeStructWrapper(ptr);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00012348 File Offset: 0x00010548
		public NativeClassStructHandler_24_3()
		{
			NativeClassStructHandler_24_3.AntSsf6vFe3xhWh5dNJ();
			NativeClassStructHandler_24_3.D8td7w6B2nTHw8IhfsS();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_483eecf3691e4ef2b23b2d4cb2ca3d52 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x000123AC File Offset: 0x000105AC
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_24_3()
		{
			NativeClassStructHandler_24_3.Q4wIDN6jkdYG8gncxPV();
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000123BC File Offset: 0x000105BC
		internal static IntPtr qMdPPK6m8GNJIMteKR8(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x000123D0 File Offset: 0x000105D0
		internal static bool aZ1CwT6OLnxaASNJrNI()
		{
			return NativeClassStructHandler_24_3.e8hfpf6VhPnF54f0Z6d == null;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x000123E4 File Offset: 0x000105E4
		internal static NativeClassStructHandler_24_3 GNS2Ec6XaCMlpQkPJhI()
		{
			return NativeClassStructHandler_24_3.e8hfpf6VhPnF54f0Z6d;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x000123F4 File Offset: 0x000105F4
		internal static void AntSsf6vFe3xhWh5dNJ()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00012404 File Offset: 0x00010604
		internal static void D8td7w6B2nTHw8IhfsS()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00012414 File Offset: 0x00010614
		internal static void Q4wIDN6jkdYG8gncxPV()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400066C RID: 1644
		private static NativeClassStructHandler_24_3 e8hfpf6VhPnF54f0Z6d;

		// Token: 0x020000EA RID: 234
		internal struct Il2CppClass_24_3
		{
			// Token: 0x0400066D RID: 1645
			public unsafe Il2CppImage* image;

			// Token: 0x0400066E RID: 1646
			public unsafe void* gc_desc;

			// Token: 0x0400066F RID: 1647
			public unsafe byte* name;

			// Token: 0x04000670 RID: 1648
			public unsafe byte* namespaze;

			// Token: 0x04000671 RID: 1649
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 byval_arg;

			// Token: 0x04000672 RID: 1650
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 this_arg;

			// Token: 0x04000673 RID: 1651
			public unsafe Il2CppClass* element_class;

			// Token: 0x04000674 RID: 1652
			public unsafe Il2CppClass* castClass;

			// Token: 0x04000675 RID: 1653
			public unsafe Il2CppClass* declaringType;

			// Token: 0x04000676 RID: 1654
			public unsafe Il2CppClass* parent;

			// Token: 0x04000677 RID: 1655
			public unsafe void* generic_class;

			// Token: 0x04000678 RID: 1656
			public unsafe void* typeDefinition;

			// Token: 0x04000679 RID: 1657
			public unsafe void* interopData;

			// Token: 0x0400067A RID: 1658
			public unsafe Il2CppClass* klass;

			// Token: 0x0400067B RID: 1659
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x0400067C RID: 1660
			public unsafe Il2CppEventInfo* events;

			// Token: 0x0400067D RID: 1661
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x0400067E RID: 1662
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x0400067F RID: 1663
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000680 RID: 1664
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x04000681 RID: 1665
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x04000682 RID: 1666
			public unsafe void* static_fields;

			// Token: 0x04000683 RID: 1667
			public unsafe void* rgctx_data;

			// Token: 0x04000684 RID: 1668
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x04000685 RID: 1669
			public uint initializationExceptionGCHandle;

			// Token: 0x04000686 RID: 1670
			public uint cctor_started;

			// Token: 0x04000687 RID: 1671
			public uint cctor_finished;

			// Token: 0x04000688 RID: 1672
			public ulong cctor_thread;

			// Token: 0x04000689 RID: 1673
			public int genericContainerIndex;

			// Token: 0x0400068A RID: 1674
			public uint instance_size;

			// Token: 0x0400068B RID: 1675
			public uint actualSize;

			// Token: 0x0400068C RID: 1676
			public uint element_size;

			// Token: 0x0400068D RID: 1677
			public int native_size;

			// Token: 0x0400068E RID: 1678
			public uint static_fields_size;

			// Token: 0x0400068F RID: 1679
			public uint thread_static_fields_size;

			// Token: 0x04000690 RID: 1680
			public int thread_static_fields_offset;

			// Token: 0x04000691 RID: 1681
			public uint flags;

			// Token: 0x04000692 RID: 1682
			public uint token;

			// Token: 0x04000693 RID: 1683
			public ushort method_count;

			// Token: 0x04000694 RID: 1684
			public ushort property_count;

			// Token: 0x04000695 RID: 1685
			public ushort field_count;

			// Token: 0x04000696 RID: 1686
			public ushort event_count;

			// Token: 0x04000697 RID: 1687
			public ushort nested_type_count;

			// Token: 0x04000698 RID: 1688
			public ushort vtable_count;

			// Token: 0x04000699 RID: 1689
			public ushort interfaces_count;

			// Token: 0x0400069A RID: 1690
			public ushort interface_offsets_count;

			// Token: 0x0400069B RID: 1691
			public byte typeHierarchyDepth;

			// Token: 0x0400069C RID: 1692
			public byte genericRecursionDepth;

			// Token: 0x0400069D RID: 1693
			public byte rank;

			// Token: 0x0400069E RID: 1694
			public byte minimumAlignment;

			// Token: 0x0400069F RID: 1695
			public byte naturalAligment;

			// Token: 0x040006A0 RID: 1696
			public byte packingSize;

			// Token: 0x040006A1 RID: 1697
			public NativeClassStructHandler_24_3.Il2CppClass_24_3.Bitfield0 _bitfield0;

			// Token: 0x020000EB RID: 235
			internal enum Bitfield0 : ushort
			{
				// Token: 0x040006A3 RID: 1699
				BIT_initialized_and_no_error,
				// Token: 0x040006A4 RID: 1700
				initialized_and_no_error,
				// Token: 0x040006A5 RID: 1701
				BIT_valuetype = 1,
				// Token: 0x040006A6 RID: 1702
				valuetype,
				// Token: 0x040006A7 RID: 1703
				BIT_initialized = 2,
				// Token: 0x040006A8 RID: 1704
				initialized = 4,
				// Token: 0x040006A9 RID: 1705
				BIT_enumtype = 3,
				// Token: 0x040006AA RID: 1706
				enumtype = 8,
				// Token: 0x040006AB RID: 1707
				BIT_is_generic = 4,
				// Token: 0x040006AC RID: 1708
				is_generic = 16,
				// Token: 0x040006AD RID: 1709
				BIT_has_references = 5,
				// Token: 0x040006AE RID: 1710
				has_references = 32,
				// Token: 0x040006AF RID: 1711
				BIT_init_pending = 6,
				// Token: 0x040006B0 RID: 1712
				init_pending = 64,
				// Token: 0x040006B1 RID: 1713
				BIT_size_inited = 7,
				// Token: 0x040006B2 RID: 1714
				size_inited = 128,
				// Token: 0x040006B3 RID: 1715
				BIT_has_finalize = 8,
				// Token: 0x040006B4 RID: 1716
				has_finalize = 256,
				// Token: 0x040006B5 RID: 1717
				BIT_has_cctor = 9,
				// Token: 0x040006B6 RID: 1718
				has_cctor = 512,
				// Token: 0x040006B7 RID: 1719
				BIT_is_blittable = 10,
				// Token: 0x040006B8 RID: 1720
				is_blittable = 1024,
				// Token: 0x040006B9 RID: 1721
				BIT_is_import_or_windows_runtime = 11,
				// Token: 0x040006BA RID: 1722
				is_import_or_windows_runtime = 2048,
				// Token: 0x040006BB RID: 1723
				BIT_is_vtable_initialized = 12,
				// Token: 0x040006BC RID: 1724
				is_vtable_initialized = 4096,
				// Token: 0x040006BD RID: 1725
				BIT_has_initialization_error = 13,
				// Token: 0x040006BE RID: 1726
				has_initialization_error = 8192
			}
		}

		// Token: 0x020000EC RID: 236
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x060009C8 RID: 2504 RVA: 0x000232C0 File Offset: 0x000214C0
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_24_3.NativeStructWrapper.BlykTyfYYB69PTaaXNu();
				NativeClassStructHandler_24_3.NativeStructWrapper.m4AgF3fasKymvk29vyE();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_afe904a262fb47328a49943b4b34b494 == 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.<Pointer>k__BackingField = ptr;
						num = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6104a350572547c0a789887568cca07c != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x1700033A RID: 826
			// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00023350 File Offset: 0x00021550
			private unsafe NativeClassStructHandler_24_3.Il2CppClass_24_3* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700033B RID: 827
			// (get) Token: 0x060009CA RID: 2506 RVA: 0x00023360 File Offset: 0x00021560
			// (set) Token: 0x060009CB RID: 2507 RVA: 0x00023378 File Offset: 0x00021578
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_24_3.NativeStructWrapper.TVduY6fCTODC3N9Vm8U(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 5);
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
							NativeClassStructHandler_24_3.NativeStructWrapper.VNRgufftmEM3jo5NmF0(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 5, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_806dbdb7f5194c2fa0c07a915df13fc8 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700033C RID: 828
			// (get) Token: 0x060009CC RID: 2508 RVA: 0x000233DC File Offset: 0x000215DC
			public IntPtr Pointer { get; }

			// Token: 0x1700033D RID: 829
			// (get) Token: 0x060009CD RID: 2509 RVA: 0x000233EC File Offset: 0x000215EC
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_24_3.NativeStructWrapper.IjBKUgfxr48XSHInflY(this.Pointer, sizeof(NativeClassStructHandler_24_3.Il2CppClass_24_3), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x1700033E RID: 830
			// (get) Token: 0x060009CE RID: 2510 RVA: 0x0002340C File Offset: 0x0002160C
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700033F RID: 831
			// (get) Token: 0x060009CF RID: 2511 RVA: 0x0002341C File Offset: 0x0002161C
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x17000340 RID: 832
			// (get) Token: 0x060009D0 RID: 2512 RVA: 0x00023438 File Offset: 0x00021638
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x17000341 RID: 833
			// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00023454 File Offset: 0x00021654
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x17000342 RID: 834
			// (get) Token: 0x060009D2 RID: 2514 RVA: 0x00023468 File Offset: 0x00021668
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x17000343 RID: 835
			// (get) Token: 0x060009D3 RID: 2515 RVA: 0x0002347C File Offset: 0x0002167C
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x17000344 RID: 836
			// (get) Token: 0x060009D4 RID: 2516 RVA: 0x00023490 File Offset: 0x00021690
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x17000345 RID: 837
			// (get) Token: 0x060009D5 RID: 2517 RVA: 0x000234A4 File Offset: 0x000216A4
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x17000346 RID: 838
			// (get) Token: 0x060009D6 RID: 2518 RVA: 0x000234B8 File Offset: 0x000216B8
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x17000347 RID: 839
			// (get) Token: 0x060009D7 RID: 2519 RVA: 0x000234CC File Offset: 0x000216CC
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x17000348 RID: 840
			// (get) Token: 0x060009D8 RID: 2520 RVA: 0x000234E0 File Offset: 0x000216E0
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x17000349 RID: 841
			// (get) Token: 0x060009D9 RID: 2521 RVA: 0x000234F4 File Offset: 0x000216F4
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x1700034A RID: 842
			// (get) Token: 0x060009DA RID: 2522 RVA: 0x00023508 File Offset: 0x00021708
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x1700034B RID: 843
			// (get) Token: 0x060009DB RID: 2523 RVA: 0x00023520 File Offset: 0x00021720
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700034C RID: 844
			// (get) Token: 0x060009DC RID: 2524 RVA: 0x00023538 File Offset: 0x00021738
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x1700034D RID: 845
			// (get) Token: 0x060009DD RID: 2525 RVA: 0x00023550 File Offset: 0x00021750
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x1700034E RID: 846
			// (get) Token: 0x060009DE RID: 2526 RVA: 0x00023564 File Offset: 0x00021764
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700034F RID: 847
			// (get) Token: 0x060009DF RID: 2527 RVA: 0x00023578 File Offset: 0x00021778
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x17000350 RID: 848
			// (get) Token: 0x060009E0 RID: 2528 RVA: 0x0002358C File Offset: 0x0002178C
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x17000351 RID: 849
			// (get) Token: 0x060009E1 RID: 2529 RVA: 0x000235A0 File Offset: 0x000217A0
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x17000352 RID: 850
			// (get) Token: 0x060009E2 RID: 2530 RVA: 0x000235B4 File Offset: 0x000217B4
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x17000353 RID: 851
			// (get) Token: 0x060009E3 RID: 2531 RVA: 0x000235C8 File Offset: 0x000217C8
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x17000354 RID: 852
			// (get) Token: 0x060009E4 RID: 2532 RVA: 0x000235DC File Offset: 0x000217DC
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x17000355 RID: 853
			// (get) Token: 0x060009E5 RID: 2533 RVA: 0x000235F0 File Offset: 0x000217F0
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x17000356 RID: 854
			// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00023604 File Offset: 0x00021804
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x17000357 RID: 855
			// (get) Token: 0x060009E7 RID: 2535 RVA: 0x00023618 File Offset: 0x00021818
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x17000358 RID: 856
			// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0002362C File Offset: 0x0002182C
			// (set) Token: 0x060009E9 RID: 2537 RVA: 0x00023644 File Offset: 0x00021844
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_24_3.NativeStructWrapper.TVduY6fCTODC3N9Vm8U(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_24_3.NativeStructWrapper.VNRgufftmEM3jo5NmF0(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_780e0c86b08f49d785f406cf802c7e87 != 0)
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

			// Token: 0x17000359 RID: 857
			// (get) Token: 0x060009EA RID: 2538 RVA: 0x000236A8 File Offset: 0x000218A8
			// (set) Token: 0x060009EB RID: 2539 RVA: 0x000236C0 File Offset: 0x000218C0
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_24_3.NativeStructWrapper.TVduY6fCTODC3N9Vm8U(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_24_3.NativeStructWrapper.VNRgufftmEM3jo5NmF0(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_330a825ae0544050af4112bb9a37f6bb != 0)
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

			// Token: 0x1700035A RID: 858
			// (get) Token: 0x060009EC RID: 2540 RVA: 0x00023724 File Offset: 0x00021924
			// (set) Token: 0x060009ED RID: 2541 RVA: 0x0002373C File Offset: 0x0002193C
			public bool EnumType
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_24_3.NativeStructWrapper.VNRgufftmEM3jo5NmF0(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c4640bbaac7c4988b56f91d1b6b3f1a9 != 0)
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

			// Token: 0x1700035B RID: 859
			// (get) Token: 0x060009EE RID: 2542 RVA: 0x000237A0 File Offset: 0x000219A0
			// (set) Token: 0x060009EF RID: 2543 RVA: 0x000237B8 File Offset: 0x000219B8
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_24_3.NativeStructWrapper.TVduY6fCTODC3N9Vm8U(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_24_3.NativeStructWrapper.VNRgufftmEM3jo5NmF0(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56c162609824bd799f0a7b9a8c33c89 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700035C RID: 860
			// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0002381C File Offset: 0x00021A1C
			// (set) Token: 0x060009F1 RID: 2545 RVA: 0x00023834 File Offset: 0x00021A34
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_24_3.NativeStructWrapper.TVduY6fCTODC3N9Vm8U(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 7);
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
							this.SetBit(NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2b9d7065e34e71a0069eb107f69f59 == 0)
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

			// Token: 0x1700035D RID: 861
			// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00023898 File Offset: 0x00021A98
			// (set) Token: 0x060009F3 RID: 2547 RVA: 0x000238B0 File Offset: 0x00021AB0
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_24_3.NativeStructWrapper.TVduY6fCTODC3N9Vm8U(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 8);
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
							NativeClassStructHandler_24_3.NativeStructWrapper.VNRgufftmEM3jo5NmF0(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 8, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_277c9fa6c1da46a98cc2f13643296b8f != 0)
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

			// Token: 0x1700035E RID: 862
			// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00023914 File Offset: 0x00021B14
			// (set) Token: 0x060009F5 RID: 2549 RVA: 0x0002392C File Offset: 0x00021B2C
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_24_3.NativeStructWrapper.TVduY6fCTODC3N9Vm8U(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 12);
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
							NativeClassStructHandler_24_3.NativeStructWrapper.VNRgufftmEM3jo5NmF0(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 12, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d03e4e4716154375bf56bf596fbd5780 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700035F RID: 863
			// (get) Token: 0x060009F6 RID: 2550 RVA: 0x00023994 File Offset: 0x00021B94
			// (set) Token: 0x060009F7 RID: 2551 RVA: 0x000239AC File Offset: 0x00021BAC
			public bool InitializedAndNoError
			{
				get
				{
					return NativeClassStructHandler_24_3.NativeStructWrapper.TVduY6fCTODC3N9Vm8U(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_24_3.NativeStructWrapper.VNRgufftmEM3jo5NmF0(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c1d51581d05f41579ee6e476d9be288e != 0)
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

			// Token: 0x060009F8 RID: 2552 RVA: 0x00023A10 File Offset: 0x00021C10
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
							hIDAYxH6DWLHIthQgC.zSLipEDdx();
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3af7919884e4482186590a3e6e04f119 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
						{
							IntPtr intPtr;
							NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
							num2 = 3;
							continue;
						}
						case 3:
							return;
						case 4:
						{
							IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_24_3.Il2CppClass_24_3>(NativeClassStructHandler_24_3.NativeStructWrapper.qUaFPlfh8gNCcHicDHL(-2053189787 ^ -1489873395 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc));
							num2 = 2;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5a8626d471f54eba873ce59c8785d9b9 != 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						}
						case 5:
							goto IL_3B;
						}
						hIDAYxH6DWLHIthQgC.oDuBOTgYK();
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5636e8ee665e464ba930601506bed387 == 0)
						{
							num2 = 5;
						}
					}
					IL_3B:
					NativeClassStructHandler_24_3.NativeStructWrapper.m4AgF3fasKymvk29vyE();
					num = 4;
				}
			}

			// Token: 0x060009F9 RID: 2553 RVA: 0x00023B10 File Offset: 0x00021D10
			internal static void BlykTyfYYB69PTaaXNu()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060009FA RID: 2554 RVA: 0x00023B20 File Offset: 0x00021D20
			internal static void m4AgF3fasKymvk29vyE()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x060009FB RID: 2555 RVA: 0x00023B30 File Offset: 0x00021D30
			internal static bool dvrRLBfI1WhUqEHf28o()
			{
				return NativeClassStructHandler_24_3.NativeStructWrapper.KeOED5fiEHkt2T5x05V == null;
			}

			// Token: 0x060009FC RID: 2556 RVA: 0x00023B44 File Offset: 0x00021D44
			internal static NativeClassStructHandler_24_3.NativeStructWrapper IyT4VifGSgipTV7aLyq()
			{
				return NativeClassStructHandler_24_3.NativeStructWrapper.KeOED5fiEHkt2T5x05V;
			}

			// Token: 0x060009FD RID: 2557 RVA: 0x00023B54 File Offset: 0x00021D54
			internal static bool TVduY6fCTODC3N9Vm8U(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060009FE RID: 2558 RVA: 0x00023B70 File Offset: 0x00021D70
			internal static void VNRgufftmEM3jo5NmF0(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x060009FF RID: 2559 RVA: 0x00023B90 File Offset: 0x00021D90
			internal static IntPtr IjBKUgfxr48XSHInflY(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x06000A00 RID: 2560 RVA: 0x00023BAC File Offset: 0x00021DAC
			internal static object qUaFPlfh8gNCcHicDHL(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x040006BF RID: 1727
			private static readonly int _bitfield0offset;

			// Token: 0x040006C1 RID: 1729
			internal static object KeOED5fiEHkt2T5x05V;
		}
	}
}
