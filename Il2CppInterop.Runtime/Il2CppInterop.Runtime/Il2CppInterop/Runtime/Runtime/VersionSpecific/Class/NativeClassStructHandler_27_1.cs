using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000F3 RID: 243
	[ApplicableToUnityVersionsSince("2020.3.20")]
	public class NativeClassStructHandler_27_1 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000A64 RID: 2660 RVA: 0x00011AEC File Offset: 0x0000FCEC
		public int Size()
		{
			return sizeof(NativeClassStructHandler_27_1.Il2CppClass_27_1);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00011AFC File Offset: 0x0000FCFC
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_27_1.Il2CppClass_27_1* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_27_1.Mk5FHJydoCBLIiM97Rp(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_27_1.Il2CppClass_27_1);
			return new NativeClassStructHandler_27_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00011B34 File Offset: 0x0000FD34
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_68cafcd7c4d444e39c183fde29795ee9 == 0)
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
			return new NativeClassStructHandler_27_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00011B9C File Offset: 0x0000FD9C
		public NativeClassStructHandler_27_1()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeClassStructHandler_27_1.nqsAc0yijf2OFSTaZdg();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5395ed2b7ead4e349835ba3f56e39138 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00011C00 File Offset: 0x0000FE00
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_27_1()
		{
			NativeClassStructHandler_27_1.oKhvpyywh9FMpPbX9ry();
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00011C10 File Offset: 0x0000FE10
		internal static IntPtr Mk5FHJydoCBLIiM97Rp(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00011C24 File Offset: 0x0000FE24
		internal static bool eqBWrty9dY3nw84sw3i()
		{
			return NativeClassStructHandler_27_1.qpv1RDyC6afPlOj8hwh == null;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00011C38 File Offset: 0x0000FE38
		internal static NativeClassStructHandler_27_1 zgN782yIIRFDrOtHDjd()
		{
			return NativeClassStructHandler_27_1.qpv1RDyC6afPlOj8hwh;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00011C48 File Offset: 0x0000FE48
		internal static void nqsAc0yijf2OFSTaZdg()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00011C58 File Offset: 0x0000FE58
		internal static void oKhvpyywh9FMpPbX9ry()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000765 RID: 1893
		private static NativeClassStructHandler_27_1 qpv1RDyC6afPlOj8hwh;

		// Token: 0x020000F4 RID: 244
		internal struct Il2CppClass_27_1
		{
			// Token: 0x04000766 RID: 1894
			public unsafe Il2CppImage* image;

			// Token: 0x04000767 RID: 1895
			public unsafe void* gc_desc;

			// Token: 0x04000768 RID: 1896
			public unsafe byte* name;

			// Token: 0x04000769 RID: 1897
			public unsafe byte* namespaze;

			// Token: 0x0400076A RID: 1898
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 byval_arg;

			// Token: 0x0400076B RID: 1899
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 this_arg;

			// Token: 0x0400076C RID: 1900
			public unsafe Il2CppClass* element_class;

			// Token: 0x0400076D RID: 1901
			public unsafe Il2CppClass* castClass;

			// Token: 0x0400076E RID: 1902
			public unsafe Il2CppClass* declaringType;

			// Token: 0x0400076F RID: 1903
			public unsafe Il2CppClass* parent;

			// Token: 0x04000770 RID: 1904
			public unsafe void* generic_class;

			// Token: 0x04000771 RID: 1905
			public Il2CppMetadataTypeHandle typeMetadataHandle;

			// Token: 0x04000772 RID: 1906
			public unsafe void* interopData;

			// Token: 0x04000773 RID: 1907
			public unsafe Il2CppClass* klass;

			// Token: 0x04000774 RID: 1908
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x04000775 RID: 1909
			public unsafe Il2CppEventInfo* events;

			// Token: 0x04000776 RID: 1910
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000777 RID: 1911
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x04000778 RID: 1912
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000779 RID: 1913
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x0400077A RID: 1914
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x0400077B RID: 1915
			public unsafe void* static_fields;

			// Token: 0x0400077C RID: 1916
			public unsafe void* rgctx_data;

			// Token: 0x0400077D RID: 1917
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x0400077E RID: 1918
			public unsafe void* unity_user_data;

			// Token: 0x0400077F RID: 1919
			public uint initializationExceptionGCHandle;

			// Token: 0x04000780 RID: 1920
			public uint cctor_started;

			// Token: 0x04000781 RID: 1921
			public uint cctor_finished;

			// Token: 0x04000782 RID: 1922
			public IntPtr cctor_thread;

			// Token: 0x04000783 RID: 1923
			public Il2CppMetadataGenericContainerHandle genericContainerHandle;

			// Token: 0x04000784 RID: 1924
			public uint instance_size;

			// Token: 0x04000785 RID: 1925
			public uint actualSize;

			// Token: 0x04000786 RID: 1926
			public uint element_size;

			// Token: 0x04000787 RID: 1927
			public int native_size;

			// Token: 0x04000788 RID: 1928
			public uint static_fields_size;

			// Token: 0x04000789 RID: 1929
			public uint thread_static_fields_size;

			// Token: 0x0400078A RID: 1930
			public int thread_static_fields_offset;

			// Token: 0x0400078B RID: 1931
			public uint flags;

			// Token: 0x0400078C RID: 1932
			public uint token;

			// Token: 0x0400078D RID: 1933
			public ushort method_count;

			// Token: 0x0400078E RID: 1934
			public ushort property_count;

			// Token: 0x0400078F RID: 1935
			public ushort field_count;

			// Token: 0x04000790 RID: 1936
			public ushort event_count;

			// Token: 0x04000791 RID: 1937
			public ushort nested_type_count;

			// Token: 0x04000792 RID: 1938
			public ushort vtable_count;

			// Token: 0x04000793 RID: 1939
			public ushort interfaces_count;

			// Token: 0x04000794 RID: 1940
			public ushort interface_offsets_count;

			// Token: 0x04000795 RID: 1941
			public byte typeHierarchyDepth;

			// Token: 0x04000796 RID: 1942
			public byte genericRecursionDepth;

			// Token: 0x04000797 RID: 1943
			public byte rank;

			// Token: 0x04000798 RID: 1944
			public byte minimumAlignment;

			// Token: 0x04000799 RID: 1945
			public byte naturalAligment;

			// Token: 0x0400079A RID: 1946
			public byte packingSize;

			// Token: 0x0400079B RID: 1947
			public NativeClassStructHandler_27_1.Il2CppClass_27_1.Bitfield0 _bitfield0;

			// Token: 0x020000F5 RID: 245
			internal enum Bitfield0 : ushort
			{
				// Token: 0x0400079D RID: 1949
				BIT_initialized_and_no_error,
				// Token: 0x0400079E RID: 1950
				initialized_and_no_error,
				// Token: 0x0400079F RID: 1951
				BIT_valuetype = 1,
				// Token: 0x040007A0 RID: 1952
				valuetype,
				// Token: 0x040007A1 RID: 1953
				BIT_initialized = 2,
				// Token: 0x040007A2 RID: 1954
				initialized = 4,
				// Token: 0x040007A3 RID: 1955
				BIT_enumtype = 3,
				// Token: 0x040007A4 RID: 1956
				enumtype = 8,
				// Token: 0x040007A5 RID: 1957
				BIT_is_generic = 4,
				// Token: 0x040007A6 RID: 1958
				is_generic = 16,
				// Token: 0x040007A7 RID: 1959
				BIT_has_references = 5,
				// Token: 0x040007A8 RID: 1960
				has_references = 32,
				// Token: 0x040007A9 RID: 1961
				BIT_init_pending = 6,
				// Token: 0x040007AA RID: 1962
				init_pending = 64,
				// Token: 0x040007AB RID: 1963
				BIT_size_init_pending = 7,
				// Token: 0x040007AC RID: 1964
				size_init_pending = 128,
				// Token: 0x040007AD RID: 1965
				BIT_size_inited = 8,
				// Token: 0x040007AE RID: 1966
				size_inited = 256,
				// Token: 0x040007AF RID: 1967
				BIT_has_finalize = 9,
				// Token: 0x040007B0 RID: 1968
				has_finalize = 512,
				// Token: 0x040007B1 RID: 1969
				BIT_has_cctor = 10,
				// Token: 0x040007B2 RID: 1970
				has_cctor = 1024,
				// Token: 0x040007B3 RID: 1971
				BIT_is_blittable = 11,
				// Token: 0x040007B4 RID: 1972
				is_blittable = 2048,
				// Token: 0x040007B5 RID: 1973
				BIT_is_import_or_windows_runtime = 12,
				// Token: 0x040007B6 RID: 1974
				is_import_or_windows_runtime = 4096,
				// Token: 0x040007B7 RID: 1975
				BIT_is_vtable_initialized = 13,
				// Token: 0x040007B8 RID: 1976
				is_vtable_initialized = 8192,
				// Token: 0x040007B9 RID: 1977
				BIT_has_initialization_error = 14,
				// Token: 0x040007BA RID: 1978
				has_initialization_error = 16384
			}
		}

		// Token: 0x020000F6 RID: 246
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000A6E RID: 2670 RVA: 0x000240E8 File Offset: 0x000222E8
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_27_1.NativeStructWrapper.Srno4sPv7OCSkKkrPWl();
				NativeClassStructHandler_27_1.NativeStructWrapper.isdKG1PxOw5DQrACRiJ();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b329e831708e4d29ae561982d3d8c1c1 != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2ec67b9ff6c4cd7af2a4ceec32c111c != 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x170003AC RID: 940
			// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00024178 File Offset: 0x00022378
			private unsafe NativeClassStructHandler_27_1.Il2CppClass_27_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170003AD RID: 941
			// (get) Token: 0x06000A70 RID: 2672 RVA: 0x00024188 File Offset: 0x00022388
			// (set) Token: 0x06000A71 RID: 2673 RVA: 0x000241A0 File Offset: 0x000223A0
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_27_1.NativeStructWrapper.RmSXhqPYe9Nw79YASH1(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 5);
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
							NativeClassStructHandler_27_1.NativeStructWrapper.gZQiZTP8KXVfbDMPsV9(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 5, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_892d6b14d02a4b94bf68e8edfebcd1f5 != 0)
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

			// Token: 0x170003AE RID: 942
			// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00024204 File Offset: 0x00022404
			public IntPtr Pointer { get; }

			// Token: 0x170003AF RID: 943
			// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00024214 File Offset: 0x00022414
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_27_1.NativeStructWrapper.P5GyRoPnPvrmijL5aAr(this.Pointer, sizeof(NativeClassStructHandler_27_1.Il2CppClass_27_1), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x170003B0 RID: 944
			// (get) Token: 0x06000A74 RID: 2676 RVA: 0x00024234 File Offset: 0x00022434
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170003B1 RID: 945
			// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00024244 File Offset: 0x00022444
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x170003B2 RID: 946
			// (get) Token: 0x06000A76 RID: 2678 RVA: 0x00024260 File Offset: 0x00022460
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x170003B3 RID: 947
			// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0002427C File Offset: 0x0002247C
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x170003B4 RID: 948
			// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00024290 File Offset: 0x00022490
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x170003B5 RID: 949
			// (get) Token: 0x06000A79 RID: 2681 RVA: 0x000242A4 File Offset: 0x000224A4
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x170003B6 RID: 950
			// (get) Token: 0x06000A7A RID: 2682 RVA: 0x000242B8 File Offset: 0x000224B8
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x170003B7 RID: 951
			// (get) Token: 0x06000A7B RID: 2683 RVA: 0x000242CC File Offset: 0x000224CC
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x170003B8 RID: 952
			// (get) Token: 0x06000A7C RID: 2684 RVA: 0x000242E0 File Offset: 0x000224E0
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x170003B9 RID: 953
			// (get) Token: 0x06000A7D RID: 2685 RVA: 0x000242F4 File Offset: 0x000224F4
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x170003BA RID: 954
			// (get) Token: 0x06000A7E RID: 2686 RVA: 0x00024308 File Offset: 0x00022508
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x170003BB RID: 955
			// (get) Token: 0x06000A7F RID: 2687 RVA: 0x0002431C File Offset: 0x0002251C
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x170003BC RID: 956
			// (get) Token: 0x06000A80 RID: 2688 RVA: 0x00024330 File Offset: 0x00022530
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x170003BD RID: 957
			// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00024348 File Offset: 0x00022548
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170003BE RID: 958
			// (get) Token: 0x06000A82 RID: 2690 RVA: 0x00024360 File Offset: 0x00022560
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x170003BF RID: 959
			// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00024378 File Offset: 0x00022578
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x170003C0 RID: 960
			// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0002438C File Offset: 0x0002258C
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x170003C1 RID: 961
			// (get) Token: 0x06000A85 RID: 2693 RVA: 0x000243A0 File Offset: 0x000225A0
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x170003C2 RID: 962
			// (get) Token: 0x06000A86 RID: 2694 RVA: 0x000243B4 File Offset: 0x000225B4
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x170003C3 RID: 963
			// (get) Token: 0x06000A87 RID: 2695 RVA: 0x000243C8 File Offset: 0x000225C8
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x170003C4 RID: 964
			// (get) Token: 0x06000A88 RID: 2696 RVA: 0x000243DC File Offset: 0x000225DC
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x170003C5 RID: 965
			// (get) Token: 0x06000A89 RID: 2697 RVA: 0x000243F0 File Offset: 0x000225F0
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x170003C6 RID: 966
			// (get) Token: 0x06000A8A RID: 2698 RVA: 0x00024404 File Offset: 0x00022604
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x170003C7 RID: 967
			// (get) Token: 0x06000A8B RID: 2699 RVA: 0x00024418 File Offset: 0x00022618
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x170003C8 RID: 968
			// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0002442C File Offset: 0x0002262C
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x170003C9 RID: 969
			// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00024440 File Offset: 0x00022640
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x170003CA RID: 970
			// (get) Token: 0x06000A8E RID: 2702 RVA: 0x00024454 File Offset: 0x00022654
			// (set) Token: 0x06000A8F RID: 2703 RVA: 0x0002446C File Offset: 0x0002266C
			public bool ValueType
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_27_1.NativeStructWrapper.gZQiZTP8KXVfbDMPsV9(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bc2bbd892f074260abf5aaa8b1124d64 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003CB RID: 971
			// (get) Token: 0x06000A90 RID: 2704 RVA: 0x000244D0 File Offset: 0x000226D0
			// (set) Token: 0x06000A91 RID: 2705 RVA: 0x000244E8 File Offset: 0x000226E8
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_27_1.NativeStructWrapper.RmSXhqPYe9Nw79YASH1(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 2);
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
							this.SetBit(NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92a7d78565474619a2c93ca9aa734139 == 0)
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

			// Token: 0x170003CC RID: 972
			// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0002454C File Offset: 0x0002274C
			// (set) Token: 0x06000A93 RID: 2707 RVA: 0x00024564 File Offset: 0x00022764
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_27_1.NativeStructWrapper.RmSXhqPYe9Nw79YASH1(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_27_1.NativeStructWrapper.gZQiZTP8KXVfbDMPsV9(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_26479210ae524f22ae1fe060a08fdd55 != 0)
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

			// Token: 0x170003CD RID: 973
			// (get) Token: 0x06000A94 RID: 2708 RVA: 0x000245C8 File Offset: 0x000227C8
			// (set) Token: 0x06000A95 RID: 2709 RVA: 0x000245E0 File Offset: 0x000227E0
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_27_1.NativeStructWrapper.RmSXhqPYe9Nw79YASH1(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 4);
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
							this.SetBit(NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_15379a47ca764a4e8e16ceaf4804e136 != 0)
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

			// Token: 0x170003CE RID: 974
			// (get) Token: 0x06000A96 RID: 2710 RVA: 0x00024644 File Offset: 0x00022844
			// (set) Token: 0x06000A97 RID: 2711 RVA: 0x0002465C File Offset: 0x0002285C
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_27_1.NativeStructWrapper.RmSXhqPYe9Nw79YASH1(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 8);
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
							NativeClassStructHandler_27_1.NativeStructWrapper.gZQiZTP8KXVfbDMPsV9(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 8, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7628c527f657443a88f11a40a3f948a5 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003CF RID: 975
			// (get) Token: 0x06000A98 RID: 2712 RVA: 0x000246C0 File Offset: 0x000228C0
			// (set) Token: 0x06000A99 RID: 2713 RVA: 0x000246D8 File Offset: 0x000228D8
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_27_1.NativeStructWrapper.RmSXhqPYe9Nw79YASH1(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 9);
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
							NativeClassStructHandler_27_1.NativeStructWrapper.gZQiZTP8KXVfbDMPsV9(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 9, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_26479210ae524f22ae1fe060a08fdd55 != 0)
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

			// Token: 0x170003D0 RID: 976
			// (get) Token: 0x06000A9A RID: 2714 RVA: 0x00024740 File Offset: 0x00022940
			// (set) Token: 0x06000A9B RID: 2715 RVA: 0x00024758 File Offset: 0x00022958
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_27_1.NativeStructWrapper.RmSXhqPYe9Nw79YASH1(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 13);
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
							NativeClassStructHandler_27_1.NativeStructWrapper.gZQiZTP8KXVfbDMPsV9(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 13, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6d9238cad9434518b97d223669b8fe50 == 0)
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

			// Token: 0x170003D1 RID: 977
			// (get) Token: 0x06000A9C RID: 2716 RVA: 0x000247C0 File Offset: 0x000229C0
			// (set) Token: 0x06000A9D RID: 2717 RVA: 0x000247D8 File Offset: 0x000229D8
			public bool InitializedAndNoError
			{
				get
				{
					return NativeClassStructHandler_27_1.NativeStructWrapper.RmSXhqPYe9Nw79YASH1(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_27_1.NativeStructWrapper.gZQiZTP8KXVfbDMPsV9(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x06000A9E RID: 2718 RVA: 0x0002483C File Offset: 0x00022A3C
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 5;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						nHwRpygmi6xxZAssJn.EmlEpH4Phw();
						num2 = 3;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_da5aa2d475094b06a3df3cc53bc85956 == 0)
						{
							num2 = 3;
						}
						break;
					case 2:
					{
						IntPtr intPtr;
						NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3e2009ed69c04f5799431b4e58cafb2a == 0)
						{
							num2 = 0;
						}
						break;
					}
					case 3:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_27_1.Il2CppClass_27_1>(NativeClassStructHandler_27_1.NativeStructWrapper.huBlMpP6K6ADH6Nvvld(-488741256 ^ -1233738485 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e5b00aa4c99144c78d3bd63e270496cb));
						num2 = 2;
						break;
					}
					case 4:
						hIDAYxH6DWLHIthQgC.oDuBOTgYK();
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6a95c50bbb48420f8f11bb090d6d3bd5 != 0)
						{
							num2 = 1;
						}
						break;
					case 5:
						NativeClassStructHandler_27_1.NativeStructWrapper.C2GyvKPb1klVl8JO2E1();
						num2 = 4;
						break;
					}
				}
			}

			// Token: 0x06000A9F RID: 2719 RVA: 0x00024938 File Offset: 0x00022B38
			internal static void Srno4sPv7OCSkKkrPWl()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000AA0 RID: 2720 RVA: 0x00024948 File Offset: 0x00022B48
			internal static void isdKG1PxOw5DQrACRiJ()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000AA1 RID: 2721 RVA: 0x00024958 File Offset: 0x00022B58
			internal static bool wdfeZxPOKWG35TN3Ysr()
			{
				return NativeClassStructHandler_27_1.NativeStructWrapper.zoPOdiPhUwg34ee6NDb == null;
			}

			// Token: 0x06000AA2 RID: 2722 RVA: 0x0002496C File Offset: 0x00022B6C
			internal static NativeClassStructHandler_27_1.NativeStructWrapper T6rTLIPtlUD74hGWQI4()
			{
				return NativeClassStructHandler_27_1.NativeStructWrapper.zoPOdiPhUwg34ee6NDb;
			}

			// Token: 0x06000AA3 RID: 2723 RVA: 0x0002497C File Offset: 0x00022B7C
			internal static bool RmSXhqPYe9Nw79YASH1(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000AA4 RID: 2724 RVA: 0x00024998 File Offset: 0x00022B98
			internal static void gZQiZTP8KXVfbDMPsV9(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000AA5 RID: 2725 RVA: 0x000249B8 File Offset: 0x00022BB8
			internal static IntPtr P5GyRoPnPvrmijL5aAr(IntPtr A_0, int A_1, object A_2)
			{
				return apS1BFcfBa3gXUspL9j.muOq5LWqgj(A_0, A_1, A_2);
			}

			// Token: 0x06000AA6 RID: 2726 RVA: 0x000249D4 File Offset: 0x00022BD4
			internal static void C2GyvKPb1klVl8JO2E1()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000AA7 RID: 2727 RVA: 0x000249E4 File Offset: 0x00022BE4
			internal static object huBlMpP6K6ADH6Nvvld(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x040007BB RID: 1979
			private static readonly int _bitfield0offset;

			// Token: 0x040007BD RID: 1981
			internal static object zoPOdiPhUwg34ee6NDb;
		}
	}
}
