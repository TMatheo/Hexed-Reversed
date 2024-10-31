using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000E7 RID: 231
	[ApplicableToUnityVersionsSince("2018.3.8")]
	public class NativeClassStructHandler_24_3 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x0600099B RID: 2459 RVA: 0x000116A0 File Offset: 0x0000F8A0
		public int Size()
		{
			return sizeof(NativeClassStructHandler_24_3.Il2CppClass_24_3);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x000116B0 File Offset: 0x0000F8B0
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_24_3.Il2CppClass_24_3* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_24_3.WGEOHdyuSrRuROH0COw(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_24_3.Il2CppClass_24_3);
			return new NativeClassStructHandler_24_3.NativeStructWrapper(ptr);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x000116E8 File Offset: 0x0000F8E8
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cc8d2b38a48843c198fb28cbbbd93013 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeClassStructHandler_24_3.NativeStructWrapper(ptr);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00011750 File Offset: 0x0000F950
		public NativeClassStructHandler_24_3()
		{
			NativeClassStructHandler_24_3.fpAecyyDn4NPQf90PhL();
			NativeClassStructHandler_24_3.YX1yBvymR2jjGpGrpVX();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ecb3ec1520014011821df145fb87d517 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000117B4 File Offset: 0x0000F9B4
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_24_3()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x000117C4 File Offset: 0x0000F9C4
		internal static IntPtr WGEOHdyuSrRuROH0COw(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x000117D8 File Offset: 0x0000F9D8
		internal static bool a3MvOPySrwCc19F8dOb()
		{
			return NativeClassStructHandler_24_3.VymImsysSBFLqrhWbpP == null;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x000117EC File Offset: 0x0000F9EC
		internal static NativeClassStructHandler_24_3 oR2KpJyNF1pnHblrWKD()
		{
			return NativeClassStructHandler_24_3.VymImsysSBFLqrhWbpP;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x000117FC File Offset: 0x0000F9FC
		internal static void fpAecyyDn4NPQf90PhL()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0001180C File Offset: 0x0000FA0C
		internal static void YX1yBvymR2jjGpGrpVX()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x04000661 RID: 1633
		internal static NativeClassStructHandler_24_3 VymImsysSBFLqrhWbpP;

		// Token: 0x020000E8 RID: 232
		internal struct Il2CppClass_24_3
		{
			// Token: 0x04000662 RID: 1634
			public unsafe Il2CppImage* image;

			// Token: 0x04000663 RID: 1635
			public unsafe void* gc_desc;

			// Token: 0x04000664 RID: 1636
			public unsafe byte* name;

			// Token: 0x04000665 RID: 1637
			public unsafe byte* namespaze;

			// Token: 0x04000666 RID: 1638
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 byval_arg;

			// Token: 0x04000667 RID: 1639
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 this_arg;

			// Token: 0x04000668 RID: 1640
			public unsafe Il2CppClass* element_class;

			// Token: 0x04000669 RID: 1641
			public unsafe Il2CppClass* castClass;

			// Token: 0x0400066A RID: 1642
			public unsafe Il2CppClass* declaringType;

			// Token: 0x0400066B RID: 1643
			public unsafe Il2CppClass* parent;

			// Token: 0x0400066C RID: 1644
			public unsafe void* generic_class;

			// Token: 0x0400066D RID: 1645
			public unsafe void* typeDefinition;

			// Token: 0x0400066E RID: 1646
			public unsafe void* interopData;

			// Token: 0x0400066F RID: 1647
			public unsafe Il2CppClass* klass;

			// Token: 0x04000670 RID: 1648
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x04000671 RID: 1649
			public unsafe Il2CppEventInfo* events;

			// Token: 0x04000672 RID: 1650
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000673 RID: 1651
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x04000674 RID: 1652
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000675 RID: 1653
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x04000676 RID: 1654
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x04000677 RID: 1655
			public unsafe void* static_fields;

			// Token: 0x04000678 RID: 1656
			public unsafe void* rgctx_data;

			// Token: 0x04000679 RID: 1657
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x0400067A RID: 1658
			public uint initializationExceptionGCHandle;

			// Token: 0x0400067B RID: 1659
			public uint cctor_started;

			// Token: 0x0400067C RID: 1660
			public uint cctor_finished;

			// Token: 0x0400067D RID: 1661
			public ulong cctor_thread;

			// Token: 0x0400067E RID: 1662
			public int genericContainerIndex;

			// Token: 0x0400067F RID: 1663
			public uint instance_size;

			// Token: 0x04000680 RID: 1664
			public uint actualSize;

			// Token: 0x04000681 RID: 1665
			public uint element_size;

			// Token: 0x04000682 RID: 1666
			public int native_size;

			// Token: 0x04000683 RID: 1667
			public uint static_fields_size;

			// Token: 0x04000684 RID: 1668
			public uint thread_static_fields_size;

			// Token: 0x04000685 RID: 1669
			public int thread_static_fields_offset;

			// Token: 0x04000686 RID: 1670
			public uint flags;

			// Token: 0x04000687 RID: 1671
			public uint token;

			// Token: 0x04000688 RID: 1672
			public ushort method_count;

			// Token: 0x04000689 RID: 1673
			public ushort property_count;

			// Token: 0x0400068A RID: 1674
			public ushort field_count;

			// Token: 0x0400068B RID: 1675
			public ushort event_count;

			// Token: 0x0400068C RID: 1676
			public ushort nested_type_count;

			// Token: 0x0400068D RID: 1677
			public ushort vtable_count;

			// Token: 0x0400068E RID: 1678
			public ushort interfaces_count;

			// Token: 0x0400068F RID: 1679
			public ushort interface_offsets_count;

			// Token: 0x04000690 RID: 1680
			public byte typeHierarchyDepth;

			// Token: 0x04000691 RID: 1681
			public byte genericRecursionDepth;

			// Token: 0x04000692 RID: 1682
			public byte rank;

			// Token: 0x04000693 RID: 1683
			public byte minimumAlignment;

			// Token: 0x04000694 RID: 1684
			public byte naturalAligment;

			// Token: 0x04000695 RID: 1685
			public byte packingSize;

			// Token: 0x04000696 RID: 1686
			public NativeClassStructHandler_24_3.Il2CppClass_24_3.Bitfield0 _bitfield0;

			// Token: 0x020000E9 RID: 233
			internal enum Bitfield0 : ushort
			{
				// Token: 0x04000698 RID: 1688
				BIT_initialized_and_no_error,
				// Token: 0x04000699 RID: 1689
				initialized_and_no_error,
				// Token: 0x0400069A RID: 1690
				BIT_valuetype = 1,
				// Token: 0x0400069B RID: 1691
				valuetype,
				// Token: 0x0400069C RID: 1692
				BIT_initialized = 2,
				// Token: 0x0400069D RID: 1693
				initialized = 4,
				// Token: 0x0400069E RID: 1694
				BIT_enumtype = 3,
				// Token: 0x0400069F RID: 1695
				enumtype = 8,
				// Token: 0x040006A0 RID: 1696
				BIT_is_generic = 4,
				// Token: 0x040006A1 RID: 1697
				is_generic = 16,
				// Token: 0x040006A2 RID: 1698
				BIT_has_references = 5,
				// Token: 0x040006A3 RID: 1699
				has_references = 32,
				// Token: 0x040006A4 RID: 1700
				BIT_init_pending = 6,
				// Token: 0x040006A5 RID: 1701
				init_pending = 64,
				// Token: 0x040006A6 RID: 1702
				BIT_size_inited = 7,
				// Token: 0x040006A7 RID: 1703
				size_inited = 128,
				// Token: 0x040006A8 RID: 1704
				BIT_has_finalize = 8,
				// Token: 0x040006A9 RID: 1705
				has_finalize = 256,
				// Token: 0x040006AA RID: 1706
				BIT_has_cctor = 9,
				// Token: 0x040006AB RID: 1707
				has_cctor = 512,
				// Token: 0x040006AC RID: 1708
				BIT_is_blittable = 10,
				// Token: 0x040006AD RID: 1709
				is_blittable = 1024,
				// Token: 0x040006AE RID: 1710
				BIT_is_import_or_windows_runtime = 11,
				// Token: 0x040006AF RID: 1711
				is_import_or_windows_runtime = 2048,
				// Token: 0x040006B0 RID: 1712
				BIT_is_vtable_initialized = 12,
				// Token: 0x040006B1 RID: 1713
				is_vtable_initialized = 4096,
				// Token: 0x040006B2 RID: 1714
				BIT_has_initialization_error = 13,
				// Token: 0x040006B3 RID: 1715
				has_initialization_error = 8192
			}
		}

		// Token: 0x020000EA RID: 234
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x060009A5 RID: 2469 RVA: 0x000225D8 File Offset: 0x000207D8
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_24_3.NativeStructWrapper.SBxmh07FTI10maqvgdd();
				NativeClassStructHandler_24_3.NativeStructWrapper.a89AJ27RbMvvXM5CH0v();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_23fed2b647424ffc818af5297e87fd1e != 0)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_124ad935e0834fda9ae7f452377dbe1c == 0)
					{
						num = 1;
					}
				}
			}

			// Token: 0x1700033A RID: 826
			// (get) Token: 0x060009A6 RID: 2470 RVA: 0x00022668 File Offset: 0x00020868
			private unsafe NativeClassStructHandler_24_3.Il2CppClass_24_3* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700033B RID: 827
			// (get) Token: 0x060009A7 RID: 2471 RVA: 0x00022678 File Offset: 0x00020878
			// (set) Token: 0x060009A8 RID: 2472 RVA: 0x00022690 File Offset: 0x00020890
			public bool HasReferences
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 5);
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
							NativeClassStructHandler_24_3.NativeStructWrapper.BDTyvY7Mu3Dra4gcZt5(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 5, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b3f20ce588d04b909ddcdcdf767eb5d4 != 0)
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

			// Token: 0x1700033C RID: 828
			// (get) Token: 0x060009A9 RID: 2473 RVA: 0x000226F4 File Offset: 0x000208F4
			public IntPtr Pointer { get; }

			// Token: 0x1700033D RID: 829
			// (get) Token: 0x060009AA RID: 2474 RVA: 0x00022704 File Offset: 0x00020904
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_24_3.NativeStructWrapper.kicq047W4MV2AZmnQ6d(this.Pointer, sizeof(NativeClassStructHandler_24_3.Il2CppClass_24_3), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x1700033E RID: 830
			// (get) Token: 0x060009AB RID: 2475 RVA: 0x00022724 File Offset: 0x00020924
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700033F RID: 831
			// (get) Token: 0x060009AC RID: 2476 RVA: 0x00022734 File Offset: 0x00020934
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x17000340 RID: 832
			// (get) Token: 0x060009AD RID: 2477 RVA: 0x00022750 File Offset: 0x00020950
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x17000341 RID: 833
			// (get) Token: 0x060009AE RID: 2478 RVA: 0x0002276C File Offset: 0x0002096C
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x17000342 RID: 834
			// (get) Token: 0x060009AF RID: 2479 RVA: 0x00022780 File Offset: 0x00020980
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x17000343 RID: 835
			// (get) Token: 0x060009B0 RID: 2480 RVA: 0x00022794 File Offset: 0x00020994
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x17000344 RID: 836
			// (get) Token: 0x060009B1 RID: 2481 RVA: 0x000227A8 File Offset: 0x000209A8
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x17000345 RID: 837
			// (get) Token: 0x060009B2 RID: 2482 RVA: 0x000227BC File Offset: 0x000209BC
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x17000346 RID: 838
			// (get) Token: 0x060009B3 RID: 2483 RVA: 0x000227D0 File Offset: 0x000209D0
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x17000347 RID: 839
			// (get) Token: 0x060009B4 RID: 2484 RVA: 0x000227E4 File Offset: 0x000209E4
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x17000348 RID: 840
			// (get) Token: 0x060009B5 RID: 2485 RVA: 0x000227F8 File Offset: 0x000209F8
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x17000349 RID: 841
			// (get) Token: 0x060009B6 RID: 2486 RVA: 0x0002280C File Offset: 0x00020A0C
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x1700034A RID: 842
			// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00022820 File Offset: 0x00020A20
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x1700034B RID: 843
			// (get) Token: 0x060009B8 RID: 2488 RVA: 0x00022838 File Offset: 0x00020A38
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700034C RID: 844
			// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00022850 File Offset: 0x00020A50
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x1700034D RID: 845
			// (get) Token: 0x060009BA RID: 2490 RVA: 0x00022868 File Offset: 0x00020A68
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x1700034E RID: 846
			// (get) Token: 0x060009BB RID: 2491 RVA: 0x0002287C File Offset: 0x00020A7C
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700034F RID: 847
			// (get) Token: 0x060009BC RID: 2492 RVA: 0x00022890 File Offset: 0x00020A90
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x17000350 RID: 848
			// (get) Token: 0x060009BD RID: 2493 RVA: 0x000228A4 File Offset: 0x00020AA4
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x17000351 RID: 849
			// (get) Token: 0x060009BE RID: 2494 RVA: 0x000228B8 File Offset: 0x00020AB8
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x17000352 RID: 850
			// (get) Token: 0x060009BF RID: 2495 RVA: 0x000228CC File Offset: 0x00020ACC
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x17000353 RID: 851
			// (get) Token: 0x060009C0 RID: 2496 RVA: 0x000228E0 File Offset: 0x00020AE0
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x17000354 RID: 852
			// (get) Token: 0x060009C1 RID: 2497 RVA: 0x000228F4 File Offset: 0x00020AF4
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x17000355 RID: 853
			// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00022908 File Offset: 0x00020B08
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x17000356 RID: 854
			// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0002291C File Offset: 0x00020B1C
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x17000357 RID: 855
			// (get) Token: 0x060009C4 RID: 2500 RVA: 0x00022930 File Offset: 0x00020B30
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x17000358 RID: 856
			// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00022944 File Offset: 0x00020B44
			// (set) Token: 0x060009C6 RID: 2502 RVA: 0x0002295C File Offset: 0x00020B5C
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_24_3.NativeStructWrapper.Lx5GXT7ChbIS5CKv0QH(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_24_3.NativeStructWrapper.BDTyvY7Mu3Dra4gcZt5(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_911808c58d664adeb7c16d1e3a32f7fa != 0)
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
			// (get) Token: 0x060009C7 RID: 2503 RVA: 0x000229C0 File Offset: 0x00020BC0
			// (set) Token: 0x060009C8 RID: 2504 RVA: 0x000229D8 File Offset: 0x00020BD8
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_24_3.NativeStructWrapper.Lx5GXT7ChbIS5CKv0QH(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 2);
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
							this.SetBit(NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 2, value);
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

			// Token: 0x1700035A RID: 858
			// (get) Token: 0x060009C9 RID: 2505 RVA: 0x00022A3C File Offset: 0x00020C3C
			// (set) Token: 0x060009CA RID: 2506 RVA: 0x00022A54 File Offset: 0x00020C54
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_24_3.NativeStructWrapper.Lx5GXT7ChbIS5CKv0QH(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 3);
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
							this.SetBit(NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_22f9ae9a49f143d7bbb3b03eb2446c0f == 0)
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
			// (get) Token: 0x060009CB RID: 2507 RVA: 0x00022AB8 File Offset: 0x00020CB8
			// (set) Token: 0x060009CC RID: 2508 RVA: 0x00022AD0 File Offset: 0x00020CD0
			public bool IsGeneric
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_24_3.NativeStructWrapper.BDTyvY7Mu3Dra4gcZt5(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7492c06848354e9185cf647bb6904451 != 0)
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

			// Token: 0x1700035C RID: 860
			// (get) Token: 0x060009CD RID: 2509 RVA: 0x00022B34 File Offset: 0x00020D34
			// (set) Token: 0x060009CE RID: 2510 RVA: 0x00022B4C File Offset: 0x00020D4C
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_24_3.NativeStructWrapper.Lx5GXT7ChbIS5CKv0QH(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_24_3.NativeStructWrapper.BDTyvY7Mu3Dra4gcZt5(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 7, value);
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

			// Token: 0x1700035D RID: 861
			// (get) Token: 0x060009CF RID: 2511 RVA: 0x00022BB0 File Offset: 0x00020DB0
			// (set) Token: 0x060009D0 RID: 2512 RVA: 0x00022BC8 File Offset: 0x00020DC8
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_24_3.NativeStructWrapper.Lx5GXT7ChbIS5CKv0QH(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 8);
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
							NativeClassStructHandler_24_3.NativeStructWrapper.BDTyvY7Mu3Dra4gcZt5(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 8, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e6eb36653ec04a89bf8fa64932849f3b == 0)
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
			// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00022C2C File Offset: 0x00020E2C
			// (set) Token: 0x060009D2 RID: 2514 RVA: 0x00022C44 File Offset: 0x00020E44
			public bool IsVtableInitialized
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 12);
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
							NativeClassStructHandler_24_3.NativeStructWrapper.BDTyvY7Mu3Dra4gcZt5(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 12, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2adb3ca441e493aba80425bcc0f1db3 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700035F RID: 863
			// (get) Token: 0x060009D3 RID: 2515 RVA: 0x00022CAC File Offset: 0x00020EAC
			// (set) Token: 0x060009D4 RID: 2516 RVA: 0x00022CC4 File Offset: 0x00020EC4
			public bool InitializedAndNoError
			{
				get
				{
					return NativeClassStructHandler_24_3.NativeStructWrapper.Lx5GXT7ChbIS5CKv0QH(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_24_3.NativeStructWrapper.BDTyvY7Mu3Dra4gcZt5(this, NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_355d73c700924bf28058452e63cd9cf1 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x060009D5 RID: 2517 RVA: 0x00022D28 File Offset: 0x00020F28
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						NativeClassStructHandler_24_3.NativeStructWrapper.WPs1n6795P7MUIkeI9m();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ecb3ec1520014011821df145fb87d517 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
					{
						IntPtr intPtr;
						NativeClassStructHandler_24_3.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 4;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0272cc4de9694915be17746e515675c8 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					case 3:
						NativeClassStructHandler_24_3.NativeStructWrapper.a89AJ27RbMvvXM5CH0v();
						num2 = 5;
						continue;
					case 4:
						return;
					case 5:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_24_3.Il2CppClass_24_3>(NativeClassStructHandler_24_3.NativeStructWrapper.YfNMnV7IibeFp7Yoaxn(1009111477 - 2068274976 ^ -592806308 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_be7c67937fc746d2ad6f8cd47b555de7));
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					}
					NativeClassStructHandler_24_3.NativeStructWrapper.SBxmh07FTI10maqvgdd();
					num2 = 3;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b82ae23c6544f3a11e54f2fed3ad25 == 0)
					{
						num2 = 0;
					}
				}
			}

			// Token: 0x060009D6 RID: 2518 RVA: 0x00022E40 File Offset: 0x00021040
			internal static void SBxmh07FTI10maqvgdd()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060009D7 RID: 2519 RVA: 0x00022E50 File Offset: 0x00021050
			internal static void a89AJ27RbMvvXM5CH0v()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x060009D8 RID: 2520 RVA: 0x00022E60 File Offset: 0x00021060
			internal static bool OX1XUT7f3mnybDxEdMc()
			{
				return NativeClassStructHandler_24_3.NativeStructWrapper.af5iiu732CTonv6iVlf == null;
			}

			// Token: 0x060009D9 RID: 2521 RVA: 0x00022E74 File Offset: 0x00021074
			internal static NativeClassStructHandler_24_3.NativeStructWrapper iqxjXg71Gl3DMAh0myh()
			{
				return NativeClassStructHandler_24_3.NativeStructWrapper.af5iiu732CTonv6iVlf;
			}

			// Token: 0x060009DA RID: 2522 RVA: 0x00022E84 File Offset: 0x00021084
			internal static void BDTyvY7Mu3Dra4gcZt5(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x060009DB RID: 2523 RVA: 0x00022EA4 File Offset: 0x000210A4
			internal static IntPtr kicq047W4MV2AZmnQ6d(IntPtr A_0, int A_1, object A_2)
			{
				return apS1BFcfBa3gXUspL9j.muOq5LWqgj(A_0, A_1, A_2);
			}

			// Token: 0x060009DC RID: 2524 RVA: 0x00022EC0 File Offset: 0x000210C0
			internal static bool Lx5GXT7ChbIS5CKv0QH(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060009DD RID: 2525 RVA: 0x00022EDC File Offset: 0x000210DC
			internal static void WPs1n6795P7MUIkeI9m()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x060009DE RID: 2526 RVA: 0x00022EEC File Offset: 0x000210EC
			internal static object YfNMnV7IibeFp7Yoaxn(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x040006B4 RID: 1716
			private static readonly int _bitfield0offset;

			// Token: 0x040006B6 RID: 1718
			private static object af5iiu732CTonv6iVlf;
		}
	}
}
