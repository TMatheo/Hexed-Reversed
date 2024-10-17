using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000F1 RID: 241
	[ApplicableToUnityVersionsSince("2020.2.0")]
	public class NativeClassStructHandler_27_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000A44 RID: 2628 RVA: 0x000125A0 File Offset: 0x000107A0
		public int Size()
		{
			return sizeof(NativeClassStructHandler_27_0.Il2CppClass_27_0);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x000125B0 File Offset: 0x000107B0
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_27_0.Il2CppClass_27_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_27_0.Il2CppClass_27_0);
			return new NativeClassStructHandler_27_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x000125E8 File Offset: 0x000107E8
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_98f1dfe5d9cd4cf9bdc32e0db7fb0ae4 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeClassStructHandler_27_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00012650 File Offset: 0x00010850
		public NativeClassStructHandler_27_0()
		{
			NativeClassStructHandler_27_0.HFqoGI64pkqUAZSfWb3();
			NativeClassStructHandler_27_0.Vlf9NM6zYCPDUmuQ2Tw();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ac98984015b94d6a931f8affda832ec9 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x000126B4 File Offset: 0x000108B4
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_27_0()
		{
			NativeClassStructHandler_27_0.IT8ag1LH4ikyHLtVCM6();
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x000126C4 File Offset: 0x000108C4
		internal static bool BgPPCR6MwCFTNQh5wJn()
		{
			return NativeClassStructHandler_27_0.cXPdLl61mD3XLAn6FYu == null;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x000126D8 File Offset: 0x000108D8
		internal static NativeClassStructHandler_27_0 caiTb96p66jTUS8vAc6()
		{
			return NativeClassStructHandler_27_0.cXPdLl61mD3XLAn6FYu;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x000126E8 File Offset: 0x000108E8
		internal static void HFqoGI64pkqUAZSfWb3()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x000126F8 File Offset: 0x000108F8
		internal static void Vlf9NM6zYCPDUmuQ2Tw()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00012708 File Offset: 0x00010908
		internal static void IT8ag1LH4ikyHLtVCM6()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000719 RID: 1817
		internal static NativeClassStructHandler_27_0 cXPdLl61mD3XLAn6FYu;

		// Token: 0x020000F2 RID: 242
		internal struct Il2CppClass_27_0
		{
			// Token: 0x0400071A RID: 1818
			public unsafe Il2CppImage* image;

			// Token: 0x0400071B RID: 1819
			public unsafe void* gc_desc;

			// Token: 0x0400071C RID: 1820
			public unsafe byte* name;

			// Token: 0x0400071D RID: 1821
			public unsafe byte* namespaze;

			// Token: 0x0400071E RID: 1822
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 byval_arg;

			// Token: 0x0400071F RID: 1823
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 this_arg;

			// Token: 0x04000720 RID: 1824
			public unsafe Il2CppClass* element_class;

			// Token: 0x04000721 RID: 1825
			public unsafe Il2CppClass* castClass;

			// Token: 0x04000722 RID: 1826
			public unsafe Il2CppClass* declaringType;

			// Token: 0x04000723 RID: 1827
			public unsafe Il2CppClass* parent;

			// Token: 0x04000724 RID: 1828
			public unsafe void* generic_class;

			// Token: 0x04000725 RID: 1829
			public Il2CppMetadataTypeHandle typeMetadataHandle;

			// Token: 0x04000726 RID: 1830
			public unsafe void* interopData;

			// Token: 0x04000727 RID: 1831
			public unsafe Il2CppClass* klass;

			// Token: 0x04000728 RID: 1832
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x04000729 RID: 1833
			public unsafe Il2CppEventInfo* events;

			// Token: 0x0400072A RID: 1834
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x0400072B RID: 1835
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x0400072C RID: 1836
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x0400072D RID: 1837
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x0400072E RID: 1838
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x0400072F RID: 1839
			public unsafe void* static_fields;

			// Token: 0x04000730 RID: 1840
			public unsafe void* rgctx_data;

			// Token: 0x04000731 RID: 1841
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x04000732 RID: 1842
			public unsafe void* unity_user_data;

			// Token: 0x04000733 RID: 1843
			public uint initializationExceptionGCHandle;

			// Token: 0x04000734 RID: 1844
			public uint cctor_started;

			// Token: 0x04000735 RID: 1845
			public uint cctor_finished;

			// Token: 0x04000736 RID: 1846
			public IntPtr cctor_thread;

			// Token: 0x04000737 RID: 1847
			public Il2CppMetadataGenericContainerHandle genericContainerHandle;

			// Token: 0x04000738 RID: 1848
			public uint instance_size;

			// Token: 0x04000739 RID: 1849
			public uint actualSize;

			// Token: 0x0400073A RID: 1850
			public uint element_size;

			// Token: 0x0400073B RID: 1851
			public int native_size;

			// Token: 0x0400073C RID: 1852
			public uint static_fields_size;

			// Token: 0x0400073D RID: 1853
			public uint thread_static_fields_size;

			// Token: 0x0400073E RID: 1854
			public int thread_static_fields_offset;

			// Token: 0x0400073F RID: 1855
			public uint flags;

			// Token: 0x04000740 RID: 1856
			public uint token;

			// Token: 0x04000741 RID: 1857
			public ushort method_count;

			// Token: 0x04000742 RID: 1858
			public ushort property_count;

			// Token: 0x04000743 RID: 1859
			public ushort field_count;

			// Token: 0x04000744 RID: 1860
			public ushort event_count;

			// Token: 0x04000745 RID: 1861
			public ushort nested_type_count;

			// Token: 0x04000746 RID: 1862
			public ushort vtable_count;

			// Token: 0x04000747 RID: 1863
			public ushort interfaces_count;

			// Token: 0x04000748 RID: 1864
			public ushort interface_offsets_count;

			// Token: 0x04000749 RID: 1865
			public byte typeHierarchyDepth;

			// Token: 0x0400074A RID: 1866
			public byte genericRecursionDepth;

			// Token: 0x0400074B RID: 1867
			public byte rank;

			// Token: 0x0400074C RID: 1868
			public byte minimumAlignment;

			// Token: 0x0400074D RID: 1869
			public byte naturalAligment;

			// Token: 0x0400074E RID: 1870
			public byte packingSize;

			// Token: 0x0400074F RID: 1871
			public NativeClassStructHandler_27_0.Il2CppClass_27_0.Bitfield0 _bitfield0;

			// Token: 0x020000F3 RID: 243
			internal enum Bitfield0 : ushort
			{
				// Token: 0x04000751 RID: 1873
				BIT_initialized_and_no_error,
				// Token: 0x04000752 RID: 1874
				initialized_and_no_error,
				// Token: 0x04000753 RID: 1875
				BIT_valuetype = 1,
				// Token: 0x04000754 RID: 1876
				valuetype,
				// Token: 0x04000755 RID: 1877
				BIT_initialized = 2,
				// Token: 0x04000756 RID: 1878
				initialized = 4,
				// Token: 0x04000757 RID: 1879
				BIT_enumtype = 3,
				// Token: 0x04000758 RID: 1880
				enumtype = 8,
				// Token: 0x04000759 RID: 1881
				BIT_is_generic = 4,
				// Token: 0x0400075A RID: 1882
				is_generic = 16,
				// Token: 0x0400075B RID: 1883
				BIT_has_references = 5,
				// Token: 0x0400075C RID: 1884
				has_references = 32,
				// Token: 0x0400075D RID: 1885
				BIT_init_pending = 6,
				// Token: 0x0400075E RID: 1886
				init_pending = 64,
				// Token: 0x0400075F RID: 1887
				BIT_size_inited = 7,
				// Token: 0x04000760 RID: 1888
				size_inited = 128,
				// Token: 0x04000761 RID: 1889
				BIT_has_finalize = 8,
				// Token: 0x04000762 RID: 1890
				has_finalize = 256,
				// Token: 0x04000763 RID: 1891
				BIT_has_cctor = 9,
				// Token: 0x04000764 RID: 1892
				has_cctor = 512,
				// Token: 0x04000765 RID: 1893
				BIT_is_blittable = 10,
				// Token: 0x04000766 RID: 1894
				is_blittable = 1024,
				// Token: 0x04000767 RID: 1895
				BIT_is_import_or_windows_runtime = 11,
				// Token: 0x04000768 RID: 1896
				is_import_or_windows_runtime = 2048,
				// Token: 0x04000769 RID: 1897
				BIT_is_vtable_initialized = 12,
				// Token: 0x0400076A RID: 1898
				is_vtable_initialized = 4096,
				// Token: 0x0400076B RID: 1899
				BIT_has_initialization_error = 13,
				// Token: 0x0400076C RID: 1900
				has_initialization_error = 8192
			}
		}

		// Token: 0x020000F4 RID: 244
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000A4E RID: 2638 RVA: 0x0002449C File Offset: 0x0002269C
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeClassStructHandler_27_0.NativeStructWrapper.qvhlwEffEeobEJ9htAs();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bacedfb8a3cf4671ae3e03ec2f965495 == 0)
				{
					num = 1;
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c474f43efb4d4f17b5c0c1bf3216ef4d != 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x17000386 RID: 902
			// (get) Token: 0x06000A4F RID: 2639 RVA: 0x0002452C File Offset: 0x0002272C
			private unsafe NativeClassStructHandler_27_0.Il2CppClass_27_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000387 RID: 903
			// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0002453C File Offset: 0x0002273C
			// (set) Token: 0x06000A51 RID: 2641 RVA: 0x00024554 File Offset: 0x00022754
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.M7fCNwfPHuAqtS1j2Zn(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 5);
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
							NativeClassStructHandler_27_0.NativeStructWrapper.mq16kBfdm0NvGbHMRkU(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 5, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_75b92ac812f348208c578c3de71e2d57 == 0)
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

			// Token: 0x17000388 RID: 904
			// (get) Token: 0x06000A52 RID: 2642 RVA: 0x000245B8 File Offset: 0x000227B8
			public IntPtr Pointer { get; }

			// Token: 0x17000389 RID: 905
			// (get) Token: 0x06000A53 RID: 2643 RVA: 0x000245C8 File Offset: 0x000227C8
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.IBXxqifwwSKL10Z7pG6(this.Pointer, sizeof(NativeClassStructHandler_27_0.Il2CppClass_27_0), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x1700038A RID: 906
			// (get) Token: 0x06000A54 RID: 2644 RVA: 0x000245E8 File Offset: 0x000227E8
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700038B RID: 907
			// (get) Token: 0x06000A55 RID: 2645 RVA: 0x000245F8 File Offset: 0x000227F8
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x1700038C RID: 908
			// (get) Token: 0x06000A56 RID: 2646 RVA: 0x00024614 File Offset: 0x00022814
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x1700038D RID: 909
			// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00024630 File Offset: 0x00022830
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x1700038E RID: 910
			// (get) Token: 0x06000A58 RID: 2648 RVA: 0x00024644 File Offset: 0x00022844
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x1700038F RID: 911
			// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00024658 File Offset: 0x00022858
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x17000390 RID: 912
			// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0002466C File Offset: 0x0002286C
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x17000391 RID: 913
			// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00024680 File Offset: 0x00022880
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x17000392 RID: 914
			// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00024694 File Offset: 0x00022894
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x17000393 RID: 915
			// (get) Token: 0x06000A5D RID: 2653 RVA: 0x000246A8 File Offset: 0x000228A8
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x17000394 RID: 916
			// (get) Token: 0x06000A5E RID: 2654 RVA: 0x000246BC File Offset: 0x000228BC
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x17000395 RID: 917
			// (get) Token: 0x06000A5F RID: 2655 RVA: 0x000246D0 File Offset: 0x000228D0
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x17000396 RID: 918
			// (get) Token: 0x06000A60 RID: 2656 RVA: 0x000246E4 File Offset: 0x000228E4
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x17000397 RID: 919
			// (get) Token: 0x06000A61 RID: 2657 RVA: 0x000246FC File Offset: 0x000228FC
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000398 RID: 920
			// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00024714 File Offset: 0x00022914
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x17000399 RID: 921
			// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0002472C File Offset: 0x0002292C
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x1700039A RID: 922
			// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00024740 File Offset: 0x00022940
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700039B RID: 923
			// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00024754 File Offset: 0x00022954
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x1700039C RID: 924
			// (get) Token: 0x06000A66 RID: 2662 RVA: 0x00024768 File Offset: 0x00022968
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x1700039D RID: 925
			// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0002477C File Offset: 0x0002297C
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x1700039E RID: 926
			// (get) Token: 0x06000A68 RID: 2664 RVA: 0x00024790 File Offset: 0x00022990
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x1700039F RID: 927
			// (get) Token: 0x06000A69 RID: 2665 RVA: 0x000247A4 File Offset: 0x000229A4
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x170003A0 RID: 928
			// (get) Token: 0x06000A6A RID: 2666 RVA: 0x000247B8 File Offset: 0x000229B8
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x170003A1 RID: 929
			// (get) Token: 0x06000A6B RID: 2667 RVA: 0x000247CC File Offset: 0x000229CC
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x170003A2 RID: 930
			// (get) Token: 0x06000A6C RID: 2668 RVA: 0x000247E0 File Offset: 0x000229E0
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x170003A3 RID: 931
			// (get) Token: 0x06000A6D RID: 2669 RVA: 0x000247F4 File Offset: 0x000229F4
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x170003A4 RID: 932
			// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00024808 File Offset: 0x00022A08
			// (set) Token: 0x06000A6F RID: 2671 RVA: 0x00024820 File Offset: 0x00022A20
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.M7fCNwfPHuAqtS1j2Zn(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_27_0.NativeStructWrapper.mq16kBfdm0NvGbHMRkU(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2e7e5b018e46a2b3bb280ae243eb22 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003A5 RID: 933
			// (get) Token: 0x06000A70 RID: 2672 RVA: 0x00024884 File Offset: 0x00022A84
			// (set) Token: 0x06000A71 RID: 2673 RVA: 0x0002489C File Offset: 0x00022A9C
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.M7fCNwfPHuAqtS1j2Zn(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_27_0.NativeStructWrapper.mq16kBfdm0NvGbHMRkU(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_db312e48eee84539b805fee2f73a8cde == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003A6 RID: 934
			// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00024900 File Offset: 0x00022B00
			// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00024918 File Offset: 0x00022B18
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.M7fCNwfPHuAqtS1j2Zn(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_27_0.NativeStructWrapper.mq16kBfdm0NvGbHMRkU(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_22a2950bfabc46ffa61eec0d3eacc4c9 != 0)
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

			// Token: 0x170003A7 RID: 935
			// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0002497C File Offset: 0x00022B7C
			// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00024994 File Offset: 0x00022B94
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.M7fCNwfPHuAqtS1j2Zn(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_27_0.NativeStructWrapper.mq16kBfdm0NvGbHMRkU(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_570d4e075bf443fcbaca8db32e007291 != 0)
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

			// Token: 0x170003A8 RID: 936
			// (get) Token: 0x06000A76 RID: 2678 RVA: 0x000249F8 File Offset: 0x00022BF8
			// (set) Token: 0x06000A77 RID: 2679 RVA: 0x00024A10 File Offset: 0x00022C10
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.M7fCNwfPHuAqtS1j2Zn(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_27_0.NativeStructWrapper.mq16kBfdm0NvGbHMRkU(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_0783948440564d328b8e79831447d3f6 == 0)
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

			// Token: 0x170003A9 RID: 937
			// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00024A74 File Offset: 0x00022C74
			// (set) Token: 0x06000A79 RID: 2681 RVA: 0x00024A8C File Offset: 0x00022C8C
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.M7fCNwfPHuAqtS1j2Zn(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 8);
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
							NativeClassStructHandler_27_0.NativeStructWrapper.mq16kBfdm0NvGbHMRkU(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 8, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_89e7beae9a774fb691cacbb26b1d9330 != 0)
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

			// Token: 0x170003AA RID: 938
			// (get) Token: 0x06000A7A RID: 2682 RVA: 0x00024AF0 File Offset: 0x00022CF0
			// (set) Token: 0x06000A7B RID: 2683 RVA: 0x00024B08 File Offset: 0x00022D08
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.M7fCNwfPHuAqtS1j2Zn(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 12);
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
							NativeClassStructHandler_27_0.NativeStructWrapper.mq16kBfdm0NvGbHMRkU(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 12, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003AB RID: 939
			// (get) Token: 0x06000A7C RID: 2684 RVA: 0x00024B70 File Offset: 0x00022D70
			// (set) Token: 0x06000A7D RID: 2685 RVA: 0x00024B88 File Offset: 0x00022D88
			public bool InitializedAndNoError
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.M7fCNwfPHuAqtS1j2Zn(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 0);
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
							this.SetBit(NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c733963b5aa3462f9be5a2d711359fa7 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x06000A7E RID: 2686 RVA: 0x00024BEC File Offset: 0x00022DEC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 4;
				for (;;)
				{
					int num2 = num;
					IntPtr intPtr;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							intPtr = Marshal.OffsetOf<NativeClassStructHandler_27_0.Il2CppClass_27_0>(hIDAYxH6DWLHIthQgC.gSCeTtiku(887500895 ^ 1690642713 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_be54e2986e644667aed0d52d0affe157));
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d03e4e4716154375bf56bf596fbd5780 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							NativeClassStructHandler_27_0.NativeStructWrapper.qvhlwEffEeobEJ9htAs();
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bd64431fd05f4961aa9b79e5bd243164 != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							goto IL_3B;
						case 4:
							NativeClassStructHandler_27_0.NativeStructWrapper.jkCmjUfe5w7O3xij8iY();
							num2 = 3;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9a3e85e731764e36a5b07f4e692becd8 == 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 5:
							return;
						}
						goto Block_1;
					}
					IL_3B:
					NativeClassStructHandler_27_0.NativeStructWrapper.Ym23VHfsDMcOasDpZKS();
					num = 2;
					continue;
					IL_73:
					NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
					num = 5;
					continue;
					Block_1:
					goto IL_73;
				}
			}

			// Token: 0x06000A7F RID: 2687 RVA: 0x00024CF0 File Offset: 0x00022EF0
			internal static void qvhlwEffEeobEJ9htAs()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000A80 RID: 2688 RVA: 0x00024D00 File Offset: 0x00022F00
			internal static bool Tqjp1KfoTcJUkeoR5CR()
			{
				return NativeClassStructHandler_27_0.NativeStructWrapper.BqaXTLfZJS3P6xIabO2 == null;
			}

			// Token: 0x06000A81 RID: 2689 RVA: 0x00024D14 File Offset: 0x00022F14
			internal static NativeClassStructHandler_27_0.NativeStructWrapper eH8TDnfbdAL7fAs1KVs()
			{
				return NativeClassStructHandler_27_0.NativeStructWrapper.BqaXTLfZJS3P6xIabO2;
			}

			// Token: 0x06000A82 RID: 2690 RVA: 0x00024D24 File Offset: 0x00022F24
			internal static bool M7fCNwfPHuAqtS1j2Zn(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000A83 RID: 2691 RVA: 0x00024D40 File Offset: 0x00022F40
			internal static void mq16kBfdm0NvGbHMRkU(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000A84 RID: 2692 RVA: 0x00024D60 File Offset: 0x00022F60
			internal static IntPtr IBXxqifwwSKL10Z7pG6(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x06000A85 RID: 2693 RVA: 0x00024D7C File Offset: 0x00022F7C
			internal static void jkCmjUfe5w7O3xij8iY()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000A86 RID: 2694 RVA: 0x00024D8C File Offset: 0x00022F8C
			internal static void Ym23VHfsDMcOasDpZKS()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0400076D RID: 1901
			private static readonly int _bitfield0offset;

			// Token: 0x0400076F RID: 1903
			private static object BqaXTLfZJS3P6xIabO2;
		}
	}
}
