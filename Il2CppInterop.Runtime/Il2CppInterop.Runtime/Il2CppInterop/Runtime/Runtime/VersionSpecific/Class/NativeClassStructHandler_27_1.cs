using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000F5 RID: 245
	[ApplicableToUnityVersionsSince("2020.3.20")]
	public class NativeClassStructHandler_27_1 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000A87 RID: 2695 RVA: 0x00012718 File Offset: 0x00010918
		public int Size()
		{
			return sizeof(NativeClassStructHandler_27_1.Il2CppClass_27_1);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00012728 File Offset: 0x00010928
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_27_1.Il2CppClass_27_1* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_27_1.BZFUi7L9JIEf2M8gErZ(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_27_1.Il2CppClass_27_1);
			return new NativeClassStructHandler_27_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00012760 File Offset: 0x00010960
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_01c6e15d1fd54ef9b78826bf2944de2a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeClassStructHandler_27_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x000127C8 File Offset: 0x000109C8
		public NativeClassStructHandler_27_1()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeClassStructHandler_27_1.xu6bLcLiEkTFaMA0Gcf();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c32cfeb41f7a43999be3bae16a94ad02 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0001282C File Offset: 0x00010A2C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_27_1()
		{
			NativeClassStructHandler_27_1.w0xFcVLIw5uf2WNpULM();
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0001283C File Offset: 0x00010A3C
		internal static IntPtr BZFUi7L9JIEf2M8gErZ(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00012850 File Offset: 0x00010A50
		internal static bool JmGRO4LUltYNR9DxqnZ()
		{
			return NativeClassStructHandler_27_1.BptpPeLAVs5aZpQkBoJ == null;
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00012864 File Offset: 0x00010A64
		internal static NativeClassStructHandler_27_1 J0Hr4wLql6inMGrOXVP()
		{
			return NativeClassStructHandler_27_1.BptpPeLAVs5aZpQkBoJ;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00012874 File Offset: 0x00010A74
		internal static void xu6bLcLiEkTFaMA0Gcf()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00012884 File Offset: 0x00010A84
		internal static void w0xFcVLIw5uf2WNpULM()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000770 RID: 1904
		private static NativeClassStructHandler_27_1 BptpPeLAVs5aZpQkBoJ;

		// Token: 0x020000F6 RID: 246
		internal struct Il2CppClass_27_1
		{
			// Token: 0x04000771 RID: 1905
			public unsafe Il2CppImage* image;

			// Token: 0x04000772 RID: 1906
			public unsafe void* gc_desc;

			// Token: 0x04000773 RID: 1907
			public unsafe byte* name;

			// Token: 0x04000774 RID: 1908
			public unsafe byte* namespaze;

			// Token: 0x04000775 RID: 1909
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 byval_arg;

			// Token: 0x04000776 RID: 1910
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 this_arg;

			// Token: 0x04000777 RID: 1911
			public unsafe Il2CppClass* element_class;

			// Token: 0x04000778 RID: 1912
			public unsafe Il2CppClass* castClass;

			// Token: 0x04000779 RID: 1913
			public unsafe Il2CppClass* declaringType;

			// Token: 0x0400077A RID: 1914
			public unsafe Il2CppClass* parent;

			// Token: 0x0400077B RID: 1915
			public unsafe void* generic_class;

			// Token: 0x0400077C RID: 1916
			public Il2CppMetadataTypeHandle typeMetadataHandle;

			// Token: 0x0400077D RID: 1917
			public unsafe void* interopData;

			// Token: 0x0400077E RID: 1918
			public unsafe Il2CppClass* klass;

			// Token: 0x0400077F RID: 1919
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x04000780 RID: 1920
			public unsafe Il2CppEventInfo* events;

			// Token: 0x04000781 RID: 1921
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000782 RID: 1922
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x04000783 RID: 1923
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000784 RID: 1924
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x04000785 RID: 1925
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x04000786 RID: 1926
			public unsafe void* static_fields;

			// Token: 0x04000787 RID: 1927
			public unsafe void* rgctx_data;

			// Token: 0x04000788 RID: 1928
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x04000789 RID: 1929
			public unsafe void* unity_user_data;

			// Token: 0x0400078A RID: 1930
			public uint initializationExceptionGCHandle;

			// Token: 0x0400078B RID: 1931
			public uint cctor_started;

			// Token: 0x0400078C RID: 1932
			public uint cctor_finished;

			// Token: 0x0400078D RID: 1933
			public IntPtr cctor_thread;

			// Token: 0x0400078E RID: 1934
			public Il2CppMetadataGenericContainerHandle genericContainerHandle;

			// Token: 0x0400078F RID: 1935
			public uint instance_size;

			// Token: 0x04000790 RID: 1936
			public uint actualSize;

			// Token: 0x04000791 RID: 1937
			public uint element_size;

			// Token: 0x04000792 RID: 1938
			public int native_size;

			// Token: 0x04000793 RID: 1939
			public uint static_fields_size;

			// Token: 0x04000794 RID: 1940
			public uint thread_static_fields_size;

			// Token: 0x04000795 RID: 1941
			public int thread_static_fields_offset;

			// Token: 0x04000796 RID: 1942
			public uint flags;

			// Token: 0x04000797 RID: 1943
			public uint token;

			// Token: 0x04000798 RID: 1944
			public ushort method_count;

			// Token: 0x04000799 RID: 1945
			public ushort property_count;

			// Token: 0x0400079A RID: 1946
			public ushort field_count;

			// Token: 0x0400079B RID: 1947
			public ushort event_count;

			// Token: 0x0400079C RID: 1948
			public ushort nested_type_count;

			// Token: 0x0400079D RID: 1949
			public ushort vtable_count;

			// Token: 0x0400079E RID: 1950
			public ushort interfaces_count;

			// Token: 0x0400079F RID: 1951
			public ushort interface_offsets_count;

			// Token: 0x040007A0 RID: 1952
			public byte typeHierarchyDepth;

			// Token: 0x040007A1 RID: 1953
			public byte genericRecursionDepth;

			// Token: 0x040007A2 RID: 1954
			public byte rank;

			// Token: 0x040007A3 RID: 1955
			public byte minimumAlignment;

			// Token: 0x040007A4 RID: 1956
			public byte naturalAligment;

			// Token: 0x040007A5 RID: 1957
			public byte packingSize;

			// Token: 0x040007A6 RID: 1958
			public NativeClassStructHandler_27_1.Il2CppClass_27_1.Bitfield0 _bitfield0;

			// Token: 0x020000F7 RID: 247
			internal enum Bitfield0 : ushort
			{
				// Token: 0x040007A8 RID: 1960
				BIT_initialized_and_no_error,
				// Token: 0x040007A9 RID: 1961
				initialized_and_no_error,
				// Token: 0x040007AA RID: 1962
				BIT_valuetype = 1,
				// Token: 0x040007AB RID: 1963
				valuetype,
				// Token: 0x040007AC RID: 1964
				BIT_initialized = 2,
				// Token: 0x040007AD RID: 1965
				initialized = 4,
				// Token: 0x040007AE RID: 1966
				BIT_enumtype = 3,
				// Token: 0x040007AF RID: 1967
				enumtype = 8,
				// Token: 0x040007B0 RID: 1968
				BIT_is_generic = 4,
				// Token: 0x040007B1 RID: 1969
				is_generic = 16,
				// Token: 0x040007B2 RID: 1970
				BIT_has_references = 5,
				// Token: 0x040007B3 RID: 1971
				has_references = 32,
				// Token: 0x040007B4 RID: 1972
				BIT_init_pending = 6,
				// Token: 0x040007B5 RID: 1973
				init_pending = 64,
				// Token: 0x040007B6 RID: 1974
				BIT_size_init_pending = 7,
				// Token: 0x040007B7 RID: 1975
				size_init_pending = 128,
				// Token: 0x040007B8 RID: 1976
				BIT_size_inited = 8,
				// Token: 0x040007B9 RID: 1977
				size_inited = 256,
				// Token: 0x040007BA RID: 1978
				BIT_has_finalize = 9,
				// Token: 0x040007BB RID: 1979
				has_finalize = 512,
				// Token: 0x040007BC RID: 1980
				BIT_has_cctor = 10,
				// Token: 0x040007BD RID: 1981
				has_cctor = 1024,
				// Token: 0x040007BE RID: 1982
				BIT_is_blittable = 11,
				// Token: 0x040007BF RID: 1983
				is_blittable = 2048,
				// Token: 0x040007C0 RID: 1984
				BIT_is_import_or_windows_runtime = 12,
				// Token: 0x040007C1 RID: 1985
				is_import_or_windows_runtime = 4096,
				// Token: 0x040007C2 RID: 1986
				BIT_is_vtable_initialized = 13,
				// Token: 0x040007C3 RID: 1987
				is_vtable_initialized = 8192,
				// Token: 0x040007C4 RID: 1988
				BIT_has_initialization_error = 14,
				// Token: 0x040007C5 RID: 1989
				has_initialization_error = 16384
			}
		}

		// Token: 0x020000F8 RID: 248
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000A91 RID: 2705 RVA: 0x00024D9C File Offset: 0x00022F9C
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_27_1.NativeStructWrapper.Lw5Ut8fVyX3cbFOUrHL();
				NativeClassStructHandler_27_1.NativeStructWrapper.oVl6O1fOl3nWIercgoC();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_17522b2a3ddb488c87b7266d3b1f941d == 0)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_18558c8f0d4f4774910664df1c51bd49 == 0)
					{
						num = 1;
					}
				}
			}

			// Token: 0x170003AC RID: 940
			// (get) Token: 0x06000A92 RID: 2706 RVA: 0x00024E2C File Offset: 0x0002302C
			private unsafe NativeClassStructHandler_27_1.Il2CppClass_27_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170003AD RID: 941
			// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00024E3C File Offset: 0x0002303C
			// (set) Token: 0x06000A94 RID: 2708 RVA: 0x00024E54 File Offset: 0x00023054
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_27_1.NativeStructWrapper.iEjbCXfX3pemAoCIHsb(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 5);
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
							NativeClassStructHandler_27_1.NativeStructWrapper.N4UFqffmPEntpEaEUIw(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 5, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_780e0c86b08f49d785f406cf802c7e87 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003AE RID: 942
			// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00024EB8 File Offset: 0x000230B8
			public IntPtr Pointer { get; }

			// Token: 0x170003AF RID: 943
			// (get) Token: 0x06000A96 RID: 2710 RVA: 0x00024EC8 File Offset: 0x000230C8
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_27_1.NativeStructWrapper.dABuR0fvxBrM09O3T3E(this.Pointer, sizeof(NativeClassStructHandler_27_1.Il2CppClass_27_1), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x170003B0 RID: 944
			// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00024EE8 File Offset: 0x000230E8
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170003B1 RID: 945
			// (get) Token: 0x06000A98 RID: 2712 RVA: 0x00024EF8 File Offset: 0x000230F8
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x170003B2 RID: 946
			// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00024F14 File Offset: 0x00023114
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x170003B3 RID: 947
			// (get) Token: 0x06000A9A RID: 2714 RVA: 0x00024F30 File Offset: 0x00023130
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x170003B4 RID: 948
			// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00024F44 File Offset: 0x00023144
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x170003B5 RID: 949
			// (get) Token: 0x06000A9C RID: 2716 RVA: 0x00024F58 File Offset: 0x00023158
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x170003B6 RID: 950
			// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00024F6C File Offset: 0x0002316C
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x170003B7 RID: 951
			// (get) Token: 0x06000A9E RID: 2718 RVA: 0x00024F80 File Offset: 0x00023180
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x170003B8 RID: 952
			// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00024F94 File Offset: 0x00023194
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x170003B9 RID: 953
			// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x00024FA8 File Offset: 0x000231A8
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x170003BA RID: 954
			// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00024FBC File Offset: 0x000231BC
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x170003BB RID: 955
			// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x00024FD0 File Offset: 0x000231D0
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x170003BC RID: 956
			// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x00024FE4 File Offset: 0x000231E4
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x170003BD RID: 957
			// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x00024FFC File Offset: 0x000231FC
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170003BE RID: 958
			// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x00025014 File Offset: 0x00023214
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x170003BF RID: 959
			// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0002502C File Offset: 0x0002322C
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x170003C0 RID: 960
			// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x00025040 File Offset: 0x00023240
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x170003C1 RID: 961
			// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x00025054 File Offset: 0x00023254
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x170003C2 RID: 962
			// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x00025068 File Offset: 0x00023268
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x170003C3 RID: 963
			// (get) Token: 0x06000AAA RID: 2730 RVA: 0x0002507C File Offset: 0x0002327C
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x170003C4 RID: 964
			// (get) Token: 0x06000AAB RID: 2731 RVA: 0x00025090 File Offset: 0x00023290
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x170003C5 RID: 965
			// (get) Token: 0x06000AAC RID: 2732 RVA: 0x000250A4 File Offset: 0x000232A4
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x170003C6 RID: 966
			// (get) Token: 0x06000AAD RID: 2733 RVA: 0x000250B8 File Offset: 0x000232B8
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x170003C7 RID: 967
			// (get) Token: 0x06000AAE RID: 2734 RVA: 0x000250CC File Offset: 0x000232CC
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x170003C8 RID: 968
			// (get) Token: 0x06000AAF RID: 2735 RVA: 0x000250E0 File Offset: 0x000232E0
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x170003C9 RID: 969
			// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x000250F4 File Offset: 0x000232F4
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x170003CA RID: 970
			// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x00025108 File Offset: 0x00023308
			// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x00025120 File Offset: 0x00023320
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_27_1.NativeStructWrapper.iEjbCXfX3pemAoCIHsb(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_27_1.NativeStructWrapper.N4UFqffmPEntpEaEUIw(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2f48f5515514b5a9a5feed6dc9a8dce != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003CB RID: 971
			// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x00025184 File Offset: 0x00023384
			// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x0002519C File Offset: 0x0002339C
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_27_1.NativeStructWrapper.iEjbCXfX3pemAoCIHsb(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_27_1.NativeStructWrapper.N4UFqffmPEntpEaEUIw(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e4c6981dbbef43b3a6de5ad27be6a3b1 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003CC RID: 972
			// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00025200 File Offset: 0x00023400
			// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x00025218 File Offset: 0x00023418
			public bool EnumType
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_27_1.NativeStructWrapper.N4UFqffmPEntpEaEUIw(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_40875ab50e1c43f7bf4d96946e4523cb == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003CD RID: 973
			// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0002527C File Offset: 0x0002347C
			// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x00025294 File Offset: 0x00023494
			public bool IsGeneric
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_27_1.NativeStructWrapper.N4UFqffmPEntpEaEUIw(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b3f1fcfa11104bd49a7f00386d38b4f4 != 0)
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
			// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x000252F8 File Offset: 0x000234F8
			// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00025310 File Offset: 0x00023510
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_27_1.NativeStructWrapper.iEjbCXfX3pemAoCIHsb(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 8);
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
							this.SetBit(NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 8, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_0783948440564d328b8e79831447d3f6 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003CF RID: 975
			// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00025374 File Offset: 0x00023574
			// (set) Token: 0x06000ABC RID: 2748 RVA: 0x0002538C File Offset: 0x0002358C
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_27_1.NativeStructWrapper.iEjbCXfX3pemAoCIHsb(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 9);
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
							NativeClassStructHandler_27_1.NativeStructWrapper.N4UFqffmPEntpEaEUIw(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 9, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_39f2b5d6802b4ad087933b982faeb79d == 0)
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
			// (get) Token: 0x06000ABD RID: 2749 RVA: 0x000253F4 File Offset: 0x000235F4
			// (set) Token: 0x06000ABE RID: 2750 RVA: 0x0002540C File Offset: 0x0002360C
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_27_1.NativeStructWrapper.iEjbCXfX3pemAoCIHsb(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 13);
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
							NativeClassStructHandler_27_1.NativeStructWrapper.N4UFqffmPEntpEaEUIw(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 13, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56a961858094410b8d2e4da57d386f1 == 0)
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
			// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00025474 File Offset: 0x00023674
			// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x0002548C File Offset: 0x0002368C
			public bool InitializedAndNoError
			{
				get
				{
					return NativeClassStructHandler_27_1.NativeStructWrapper.iEjbCXfX3pemAoCIHsb(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_27_1.NativeStructWrapper.N4UFqffmPEntpEaEUIw(this, NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c32cfeb41f7a43999be3bae16a94ad02 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x06000AC1 RID: 2753 RVA: 0x000254F0 File Offset: 0x000236F0
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
							return;
						case 2:
							nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_46ba390073ec4df6883860abf17dbf6f == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							NativeClassStructHandler_27_1.NativeStructWrapper.Lw5Ut8fVyX3cbFOUrHL();
							num2 = 2;
							continue;
						case 4:
							NativeClassStructHandler_27_1.NativeStructWrapper.QMlNvBfB9wZFFWZp9wt();
							num2 = 3;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_22d16b8eb84d4725aef9f7a9d2f68925 != 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						case 5:
							NativeClassStructHandler_27_1.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56c162609824bd799f0a7b9a8c33c89 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						break;
					}
					IL_5F:
					intPtr = Marshal.OffsetOf<NativeClassStructHandler_27_1.Il2CppClass_27_1>(hIDAYxH6DWLHIthQgC.gSCeTtiku(-187280351 ^ -1575274857 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_22a2950bfabc46ffa61eec0d3eacc4c9));
					num = 5;
					continue;
					goto IL_5F;
				}
			}

			// Token: 0x06000AC2 RID: 2754 RVA: 0x000255F0 File Offset: 0x000237F0
			internal static void Lw5Ut8fVyX3cbFOUrHL()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000AC3 RID: 2755 RVA: 0x00025600 File Offset: 0x00023800
			internal static void oVl6O1fOl3nWIercgoC()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000AC4 RID: 2756 RVA: 0x00025610 File Offset: 0x00023810
			internal static bool zPUwjMfge6JGcfv0CAK()
			{
				return NativeClassStructHandler_27_1.NativeStructWrapper.umEXuWfScpelBGem809 == null;
			}

			// Token: 0x06000AC5 RID: 2757 RVA: 0x00025624 File Offset: 0x00023824
			internal static NativeClassStructHandler_27_1.NativeStructWrapper Xx1mxOfl7lGLdVv9bCf()
			{
				return NativeClassStructHandler_27_1.NativeStructWrapper.umEXuWfScpelBGem809;
			}

			// Token: 0x06000AC6 RID: 2758 RVA: 0x00025634 File Offset: 0x00023834
			internal static bool iEjbCXfX3pemAoCIHsb(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000AC7 RID: 2759 RVA: 0x00025650 File Offset: 0x00023850
			internal static void N4UFqffmPEntpEaEUIw(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000AC8 RID: 2760 RVA: 0x00025670 File Offset: 0x00023870
			internal static IntPtr dABuR0fvxBrM09O3T3E(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x06000AC9 RID: 2761 RVA: 0x0002568C File Offset: 0x0002388C
			internal static void QMlNvBfB9wZFFWZp9wt()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x040007C6 RID: 1990
			private static readonly int _bitfield0offset;

			// Token: 0x040007C8 RID: 1992
			private static object umEXuWfScpelBGem809;
		}
	}
}
