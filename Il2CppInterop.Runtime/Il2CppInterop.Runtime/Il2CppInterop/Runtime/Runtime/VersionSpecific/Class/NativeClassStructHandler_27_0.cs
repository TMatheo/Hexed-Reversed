using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000EF RID: 239
	[ApplicableToUnityVersionsSince("2020.2.0")]
	public class NativeClassStructHandler_27_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000A21 RID: 2593 RVA: 0x00011984 File Offset: 0x0000FB84
		public int Size()
		{
			return sizeof(NativeClassStructHandler_27_0.Il2CppClass_27_0);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00011994 File Offset: 0x0000FB94
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_27_0.Il2CppClass_27_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_27_0.Il2CppClass_27_0);
			return new NativeClassStructHandler_27_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x000119CC File Offset: 0x0000FBCC
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c04403f838344b38b3a8911774a446ea == 0)
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

		// Token: 0x06000A24 RID: 2596 RVA: 0x00011A34 File Offset: 0x0000FC34
		public NativeClassStructHandler_27_0()
		{
			NativeClassStructHandler_27_0.qw3vlWyMANT3rVNevZc();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb8decd62b945dda713f7b22b6b95ca != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00011A98 File Offset: 0x0000FC98
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_27_0()
		{
			NativeClassStructHandler_27_0.Fft34ayWATxCTXJNSv8();
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00011AA8 File Offset: 0x0000FCA8
		internal static bool TObG00yFYCNMpG1tCSO()
		{
			return NativeClassStructHandler_27_0.rVnqG5y1gbK6iy1xhZy == null;
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00011ABC File Offset: 0x0000FCBC
		internal static NativeClassStructHandler_27_0 ah0bQIyRtikkjuLjqXZ()
		{
			return NativeClassStructHandler_27_0.rVnqG5y1gbK6iy1xhZy;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00011ACC File Offset: 0x0000FCCC
		internal static void qw3vlWyMANT3rVNevZc()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00011ADC File Offset: 0x0000FCDC
		internal static void Fft34ayWATxCTXJNSv8()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400070E RID: 1806
		internal static NativeClassStructHandler_27_0 rVnqG5y1gbK6iy1xhZy;

		// Token: 0x020000F0 RID: 240
		internal struct Il2CppClass_27_0
		{
			// Token: 0x0400070F RID: 1807
			public unsafe Il2CppImage* image;

			// Token: 0x04000710 RID: 1808
			public unsafe void* gc_desc;

			// Token: 0x04000711 RID: 1809
			public unsafe byte* name;

			// Token: 0x04000712 RID: 1810
			public unsafe byte* namespaze;

			// Token: 0x04000713 RID: 1811
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 byval_arg;

			// Token: 0x04000714 RID: 1812
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 this_arg;

			// Token: 0x04000715 RID: 1813
			public unsafe Il2CppClass* element_class;

			// Token: 0x04000716 RID: 1814
			public unsafe Il2CppClass* castClass;

			// Token: 0x04000717 RID: 1815
			public unsafe Il2CppClass* declaringType;

			// Token: 0x04000718 RID: 1816
			public unsafe Il2CppClass* parent;

			// Token: 0x04000719 RID: 1817
			public unsafe void* generic_class;

			// Token: 0x0400071A RID: 1818
			public Il2CppMetadataTypeHandle typeMetadataHandle;

			// Token: 0x0400071B RID: 1819
			public unsafe void* interopData;

			// Token: 0x0400071C RID: 1820
			public unsafe Il2CppClass* klass;

			// Token: 0x0400071D RID: 1821
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x0400071E RID: 1822
			public unsafe Il2CppEventInfo* events;

			// Token: 0x0400071F RID: 1823
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000720 RID: 1824
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x04000721 RID: 1825
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000722 RID: 1826
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x04000723 RID: 1827
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x04000724 RID: 1828
			public unsafe void* static_fields;

			// Token: 0x04000725 RID: 1829
			public unsafe void* rgctx_data;

			// Token: 0x04000726 RID: 1830
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x04000727 RID: 1831
			public unsafe void* unity_user_data;

			// Token: 0x04000728 RID: 1832
			public uint initializationExceptionGCHandle;

			// Token: 0x04000729 RID: 1833
			public uint cctor_started;

			// Token: 0x0400072A RID: 1834
			public uint cctor_finished;

			// Token: 0x0400072B RID: 1835
			public IntPtr cctor_thread;

			// Token: 0x0400072C RID: 1836
			public Il2CppMetadataGenericContainerHandle genericContainerHandle;

			// Token: 0x0400072D RID: 1837
			public uint instance_size;

			// Token: 0x0400072E RID: 1838
			public uint actualSize;

			// Token: 0x0400072F RID: 1839
			public uint element_size;

			// Token: 0x04000730 RID: 1840
			public int native_size;

			// Token: 0x04000731 RID: 1841
			public uint static_fields_size;

			// Token: 0x04000732 RID: 1842
			public uint thread_static_fields_size;

			// Token: 0x04000733 RID: 1843
			public int thread_static_fields_offset;

			// Token: 0x04000734 RID: 1844
			public uint flags;

			// Token: 0x04000735 RID: 1845
			public uint token;

			// Token: 0x04000736 RID: 1846
			public ushort method_count;

			// Token: 0x04000737 RID: 1847
			public ushort property_count;

			// Token: 0x04000738 RID: 1848
			public ushort field_count;

			// Token: 0x04000739 RID: 1849
			public ushort event_count;

			// Token: 0x0400073A RID: 1850
			public ushort nested_type_count;

			// Token: 0x0400073B RID: 1851
			public ushort vtable_count;

			// Token: 0x0400073C RID: 1852
			public ushort interfaces_count;

			// Token: 0x0400073D RID: 1853
			public ushort interface_offsets_count;

			// Token: 0x0400073E RID: 1854
			public byte typeHierarchyDepth;

			// Token: 0x0400073F RID: 1855
			public byte genericRecursionDepth;

			// Token: 0x04000740 RID: 1856
			public byte rank;

			// Token: 0x04000741 RID: 1857
			public byte minimumAlignment;

			// Token: 0x04000742 RID: 1858
			public byte naturalAligment;

			// Token: 0x04000743 RID: 1859
			public byte packingSize;

			// Token: 0x04000744 RID: 1860
			public NativeClassStructHandler_27_0.Il2CppClass_27_0.Bitfield0 _bitfield0;

			// Token: 0x020000F1 RID: 241
			internal enum Bitfield0 : ushort
			{
				// Token: 0x04000746 RID: 1862
				BIT_initialized_and_no_error,
				// Token: 0x04000747 RID: 1863
				initialized_and_no_error,
				// Token: 0x04000748 RID: 1864
				BIT_valuetype = 1,
				// Token: 0x04000749 RID: 1865
				valuetype,
				// Token: 0x0400074A RID: 1866
				BIT_initialized = 2,
				// Token: 0x0400074B RID: 1867
				initialized = 4,
				// Token: 0x0400074C RID: 1868
				BIT_enumtype = 3,
				// Token: 0x0400074D RID: 1869
				enumtype = 8,
				// Token: 0x0400074E RID: 1870
				BIT_is_generic = 4,
				// Token: 0x0400074F RID: 1871
				is_generic = 16,
				// Token: 0x04000750 RID: 1872
				BIT_has_references = 5,
				// Token: 0x04000751 RID: 1873
				has_references = 32,
				// Token: 0x04000752 RID: 1874
				BIT_init_pending = 6,
				// Token: 0x04000753 RID: 1875
				init_pending = 64,
				// Token: 0x04000754 RID: 1876
				BIT_size_inited = 7,
				// Token: 0x04000755 RID: 1877
				size_inited = 128,
				// Token: 0x04000756 RID: 1878
				BIT_has_finalize = 8,
				// Token: 0x04000757 RID: 1879
				has_finalize = 256,
				// Token: 0x04000758 RID: 1880
				BIT_has_cctor = 9,
				// Token: 0x04000759 RID: 1881
				has_cctor = 512,
				// Token: 0x0400075A RID: 1882
				BIT_is_blittable = 10,
				// Token: 0x0400075B RID: 1883
				is_blittable = 1024,
				// Token: 0x0400075C RID: 1884
				BIT_is_import_or_windows_runtime = 11,
				// Token: 0x0400075D RID: 1885
				is_import_or_windows_runtime = 2048,
				// Token: 0x0400075E RID: 1886
				BIT_is_vtable_initialized = 12,
				// Token: 0x0400075F RID: 1887
				is_vtable_initialized = 4096,
				// Token: 0x04000760 RID: 1888
				BIT_has_initialization_error = 13,
				// Token: 0x04000761 RID: 1889
				has_initialization_error = 8192
			}
		}

		// Token: 0x020000F2 RID: 242
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000A2A RID: 2602 RVA: 0x000237DC File Offset: 0x000219DC
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_27_0.NativeStructWrapper.KkRM5OPlFGalocFiAOw();
				NativeClassStructHandler_27_0.NativeStructWrapper.kfbe1BPqxD0klmtKNFj();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6dbfd13d96434eb59d868fecd0ad1cda == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3f609fad0bcc47d79d3add6a492d3616 == 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x17000386 RID: 902
			// (get) Token: 0x06000A2B RID: 2603 RVA: 0x0002386C File Offset: 0x00021A6C
			private unsafe NativeClassStructHandler_27_0.Il2CppClass_27_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000387 RID: 903
			// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0002387C File Offset: 0x00021A7C
			// (set) Token: 0x06000A2D RID: 2605 RVA: 0x00023894 File Offset: 0x00021A94
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.SBDMnVP5l7qkd3tfMFA(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 5);
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
							NativeClassStructHandler_27_0.NativeStructWrapper.Sws28oPAxYDGYw6DfjC(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 5, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_457365959f004478ad0e311bf72b3912 == 0)
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
			// (get) Token: 0x06000A2E RID: 2606 RVA: 0x000238F8 File Offset: 0x00021AF8
			public IntPtr Pointer { get; }

			// Token: 0x17000389 RID: 905
			// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00023908 File Offset: 0x00021B08
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.WN3nE7PLwm3Ipp5E54S(this.Pointer, sizeof(NativeClassStructHandler_27_0.Il2CppClass_27_0), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x1700038A RID: 906
			// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00023928 File Offset: 0x00021B28
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700038B RID: 907
			// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00023938 File Offset: 0x00021B38
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x1700038C RID: 908
			// (get) Token: 0x06000A32 RID: 2610 RVA: 0x00023954 File Offset: 0x00021B54
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x1700038D RID: 909
			// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00023970 File Offset: 0x00021B70
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x1700038E RID: 910
			// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00023984 File Offset: 0x00021B84
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x1700038F RID: 911
			// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00023998 File Offset: 0x00021B98
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x17000390 RID: 912
			// (get) Token: 0x06000A36 RID: 2614 RVA: 0x000239AC File Offset: 0x00021BAC
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x17000391 RID: 913
			// (get) Token: 0x06000A37 RID: 2615 RVA: 0x000239C0 File Offset: 0x00021BC0
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x17000392 RID: 914
			// (get) Token: 0x06000A38 RID: 2616 RVA: 0x000239D4 File Offset: 0x00021BD4
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x17000393 RID: 915
			// (get) Token: 0x06000A39 RID: 2617 RVA: 0x000239E8 File Offset: 0x00021BE8
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x17000394 RID: 916
			// (get) Token: 0x06000A3A RID: 2618 RVA: 0x000239FC File Offset: 0x00021BFC
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x17000395 RID: 917
			// (get) Token: 0x06000A3B RID: 2619 RVA: 0x00023A10 File Offset: 0x00021C10
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x17000396 RID: 918
			// (get) Token: 0x06000A3C RID: 2620 RVA: 0x00023A24 File Offset: 0x00021C24
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x17000397 RID: 919
			// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00023A3C File Offset: 0x00021C3C
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000398 RID: 920
			// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00023A54 File Offset: 0x00021C54
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x17000399 RID: 921
			// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00023A6C File Offset: 0x00021C6C
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x1700039A RID: 922
			// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00023A80 File Offset: 0x00021C80
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700039B RID: 923
			// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00023A94 File Offset: 0x00021C94
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x1700039C RID: 924
			// (get) Token: 0x06000A42 RID: 2626 RVA: 0x00023AA8 File Offset: 0x00021CA8
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x1700039D RID: 925
			// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00023ABC File Offset: 0x00021CBC
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x1700039E RID: 926
			// (get) Token: 0x06000A44 RID: 2628 RVA: 0x00023AD0 File Offset: 0x00021CD0
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x1700039F RID: 927
			// (get) Token: 0x06000A45 RID: 2629 RVA: 0x00023AE4 File Offset: 0x00021CE4
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x170003A0 RID: 928
			// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00023AF8 File Offset: 0x00021CF8
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x170003A1 RID: 929
			// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00023B0C File Offset: 0x00021D0C
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x170003A2 RID: 930
			// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00023B20 File Offset: 0x00021D20
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x170003A3 RID: 931
			// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00023B34 File Offset: 0x00021D34
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x170003A4 RID: 932
			// (get) Token: 0x06000A4A RID: 2634 RVA: 0x00023B48 File Offset: 0x00021D48
			// (set) Token: 0x06000A4B RID: 2635 RVA: 0x00023B60 File Offset: 0x00021D60
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.SBDMnVP5l7qkd3tfMFA(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_27_0.NativeStructWrapper.Sws28oPAxYDGYw6DfjC(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa == 0)
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

			// Token: 0x170003A5 RID: 933
			// (get) Token: 0x06000A4C RID: 2636 RVA: 0x00023BC4 File Offset: 0x00021DC4
			// (set) Token: 0x06000A4D RID: 2637 RVA: 0x00023BDC File Offset: 0x00021DDC
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.SBDMnVP5l7qkd3tfMFA(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_27_0.NativeStructWrapper.Sws28oPAxYDGYw6DfjC(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e82c749fe41a4203930245c7cb92bede != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003A6 RID: 934
			// (get) Token: 0x06000A4E RID: 2638 RVA: 0x00023C40 File Offset: 0x00021E40
			// (set) Token: 0x06000A4F RID: 2639 RVA: 0x00023C58 File Offset: 0x00021E58
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.SBDMnVP5l7qkd3tfMFA(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_27_0.NativeStructWrapper.Sws28oPAxYDGYw6DfjC(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4da80845ebf7410ebbf942336f5ee27b == 0)
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
			// (get) Token: 0x06000A50 RID: 2640 RVA: 0x00023CBC File Offset: 0x00021EBC
			// (set) Token: 0x06000A51 RID: 2641 RVA: 0x00023CD4 File Offset: 0x00021ED4
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.SBDMnVP5l7qkd3tfMFA(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_27_0.NativeStructWrapper.Sws28oPAxYDGYw6DfjC(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 4, value);
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

			// Token: 0x170003A8 RID: 936
			// (get) Token: 0x06000A52 RID: 2642 RVA: 0x00023D38 File Offset: 0x00021F38
			// (set) Token: 0x06000A53 RID: 2643 RVA: 0x00023D50 File Offset: 0x00021F50
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.SBDMnVP5l7qkd3tfMFA(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 7);
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
							this.SetBit(NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3566f8d0a0994626b4e9fd660bc94d73 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003A9 RID: 937
			// (get) Token: 0x06000A54 RID: 2644 RVA: 0x00023DB4 File Offset: 0x00021FB4
			// (set) Token: 0x06000A55 RID: 2645 RVA: 0x00023DCC File Offset: 0x00021FCC
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_27_0.NativeStructWrapper.SBDMnVP5l7qkd3tfMFA(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 8);
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
							NativeClassStructHandler_27_0.NativeStructWrapper.Sws28oPAxYDGYw6DfjC(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 8, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ac2c10c141e144acbcef06aa86a10430 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003AA RID: 938
			// (get) Token: 0x06000A56 RID: 2646 RVA: 0x00023E30 File Offset: 0x00022030
			// (set) Token: 0x06000A57 RID: 2647 RVA: 0x00023E48 File Offset: 0x00022048
			public bool IsVtableInitialized
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 12);
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
							this.SetBit(NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 12, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92a7d78565474619a2c93ca9aa734139 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003AB RID: 939
			// (get) Token: 0x06000A58 RID: 2648 RVA: 0x00023EB0 File Offset: 0x000220B0
			// (set) Token: 0x06000A59 RID: 2649 RVA: 0x00023EC8 File Offset: 0x000220C8
			public bool InitializedAndNoError
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_27_0.NativeStructWrapper.Sws28oPAxYDGYw6DfjC(this, NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6dbfd13d96434eb59d868fecd0ad1cda != 0)
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

			// Token: 0x06000A5A RID: 2650 RVA: 0x00023F2C File Offset: 0x0002212C
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
						return;
					case 2:
						NativeClassStructHandler_27_0.NativeStructWrapper.kfbe1BPqxD0klmtKNFj();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b169d8ea412f45e99e430384ddc8908b == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						NativeClassStructHandler_27_0.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c04403f838344b38b3a8911774a446ea == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						hIDAYxH6DWLHIthQgC.oDuBOTgYK();
						num2 = 2;
						continue;
					case 5:
						NativeClassStructHandler_27_0.NativeStructWrapper.Eqv9hkPXfeJsiyRC9Pd();
						num2 = 4;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f6eb9387956a4e8c81dafbb2ecc8c7ab != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					intPtr = Marshal.OffsetOf<NativeClassStructHandler_27_0.Il2CppClass_27_0>(NativeClassStructHandler_27_0.NativeStructWrapper.gIaZnTPcG8kLi7iqYgk(-1376963134 ^ -2128164618 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_64a8b41e58e0491ab0e9d05ec5ed61d3));
					num2 = 3;
				}
			}

			// Token: 0x06000A5B RID: 2651 RVA: 0x00024028 File Offset: 0x00022228
			internal static void KkRM5OPlFGalocFiAOw()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000A5C RID: 2652 RVA: 0x00024038 File Offset: 0x00022238
			internal static void kfbe1BPqxD0klmtKNFj()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000A5D RID: 2653 RVA: 0x00024048 File Offset: 0x00022248
			internal static bool UD90Io7ZFxKICttxiP7()
			{
				return NativeClassStructHandler_27_0.NativeStructWrapper.UMkr157ay4ynqlSc5Bc == null;
			}

			// Token: 0x06000A5E RID: 2654 RVA: 0x0002405C File Offset: 0x0002225C
			internal static NativeClassStructHandler_27_0.NativeStructWrapper e9yPaB7zIXPsxTLwCmj()
			{
				return NativeClassStructHandler_27_0.NativeStructWrapper.UMkr157ay4ynqlSc5Bc;
			}

			// Token: 0x06000A5F RID: 2655 RVA: 0x0002406C File Offset: 0x0002226C
			internal static bool SBDMnVP5l7qkd3tfMFA(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000A60 RID: 2656 RVA: 0x00024088 File Offset: 0x00022288
			internal static void Sws28oPAxYDGYw6DfjC(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000A61 RID: 2657 RVA: 0x000240A8 File Offset: 0x000222A8
			internal static IntPtr WN3nE7PLwm3Ipp5E54S(IntPtr A_0, int A_1, object A_2)
			{
				return apS1BFcfBa3gXUspL9j.muOq5LWqgj(A_0, A_1, A_2);
			}

			// Token: 0x06000A62 RID: 2658 RVA: 0x000240C4 File Offset: 0x000222C4
			internal static void Eqv9hkPXfeJsiyRC9Pd()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000A63 RID: 2659 RVA: 0x000240D4 File Offset: 0x000222D4
			internal static object gIaZnTPcG8kLi7iqYgk(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000762 RID: 1890
			private static readonly int _bitfield0offset;

			// Token: 0x04000764 RID: 1892
			private static object UMkr157ay4ynqlSc5Bc;
		}
	}
}
