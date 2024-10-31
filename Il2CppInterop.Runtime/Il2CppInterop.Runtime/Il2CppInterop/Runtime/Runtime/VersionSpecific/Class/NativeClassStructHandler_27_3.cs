using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000FB RID: 251
	[ApplicableToUnityVersionsSince("2021.1.24")]
	public class NativeClassStructHandler_27_3 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000AED RID: 2797 RVA: 0x00011DE4 File Offset: 0x0000FFE4
		public int Size()
		{
			return sizeof(NativeClassStructHandler_27_3.Il2CppClass_27_3);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00011DF4 File Offset: 0x0000FFF4
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_27_3.Il2CppClass_27_3* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_27_3.scOUAZyQgu0bDtWlSVo(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_27_3.Il2CppClass_27_3);
			return new NativeClassStructHandler_27_3.NativeStructWrapper(ptr);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00011E2C File Offset: 0x0001002C
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ce8abd079f9447b3bade260ffc64f0b8 != 0)
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
			return new NativeClassStructHandler_27_3.NativeStructWrapper(ptr);
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00011E94 File Offset: 0x00010094
		public NativeClassStructHandler_27_3()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeClassStructHandler_27_3.znaiRhyeLQjjVbVHmDt();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eec4384c7d0d42baa74a4dbdbdbdd8df != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00011EF8 File Offset: 0x000100F8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_27_3()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00011F08 File Offset: 0x00010108
		internal static IntPtr scOUAZyQgu0bDtWlSVo(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00011F1C File Offset: 0x0001011C
		internal static bool pcCon0yUcPSjgWRCjqw()
		{
			return NativeClassStructHandler_27_3.bEoBrnyorNQOU17ey6x == null;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00011F30 File Offset: 0x00010130
		internal static NativeClassStructHandler_27_3 bhphN8yjyPSuVS4NbTb()
		{
			return NativeClassStructHandler_27_3.bEoBrnyorNQOU17ey6x;
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00011F40 File Offset: 0x00010140
		internal static void znaiRhyeLQjjVbVHmDt()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x04000813 RID: 2067
		private static NativeClassStructHandler_27_3 bEoBrnyorNQOU17ey6x;

		// Token: 0x020000FC RID: 252
		internal struct Il2CppClass_27_3
		{
			// Token: 0x04000814 RID: 2068
			public unsafe Il2CppImage* image;

			// Token: 0x04000815 RID: 2069
			public unsafe void* gc_desc;

			// Token: 0x04000816 RID: 2070
			public unsafe byte* name;

			// Token: 0x04000817 RID: 2071
			public unsafe byte* namespaze;

			// Token: 0x04000818 RID: 2072
			public NativeTypeStructHandler_27_0.Il2CppType_27_0 byval_arg;

			// Token: 0x04000819 RID: 2073
			public NativeTypeStructHandler_27_0.Il2CppType_27_0 this_arg;

			// Token: 0x0400081A RID: 2074
			public unsafe Il2CppClass* element_class;

			// Token: 0x0400081B RID: 2075
			public unsafe Il2CppClass* castClass;

			// Token: 0x0400081C RID: 2076
			public unsafe Il2CppClass* declaringType;

			// Token: 0x0400081D RID: 2077
			public unsafe Il2CppClass* parent;

			// Token: 0x0400081E RID: 2078
			public unsafe void* generic_class;

			// Token: 0x0400081F RID: 2079
			public Il2CppMetadataTypeHandle typeMetadataHandle;

			// Token: 0x04000820 RID: 2080
			public unsafe void* interopData;

			// Token: 0x04000821 RID: 2081
			public unsafe Il2CppClass* klass;

			// Token: 0x04000822 RID: 2082
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x04000823 RID: 2083
			public unsafe Il2CppEventInfo* events;

			// Token: 0x04000824 RID: 2084
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000825 RID: 2085
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x04000826 RID: 2086
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000827 RID: 2087
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x04000828 RID: 2088
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x04000829 RID: 2089
			public unsafe void* static_fields;

			// Token: 0x0400082A RID: 2090
			public unsafe void* rgctx_data;

			// Token: 0x0400082B RID: 2091
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x0400082C RID: 2092
			public unsafe void* unity_user_data;

			// Token: 0x0400082D RID: 2093
			public uint initializationExceptionGCHandle;

			// Token: 0x0400082E RID: 2094
			public uint cctor_started;

			// Token: 0x0400082F RID: 2095
			public uint cctor_finished;

			// Token: 0x04000830 RID: 2096
			public IntPtr cctor_thread;

			// Token: 0x04000831 RID: 2097
			public Il2CppMetadataGenericContainerHandle genericContainerHandle;

			// Token: 0x04000832 RID: 2098
			public uint instance_size;

			// Token: 0x04000833 RID: 2099
			public uint actualSize;

			// Token: 0x04000834 RID: 2100
			public uint element_size;

			// Token: 0x04000835 RID: 2101
			public int native_size;

			// Token: 0x04000836 RID: 2102
			public uint static_fields_size;

			// Token: 0x04000837 RID: 2103
			public uint thread_static_fields_size;

			// Token: 0x04000838 RID: 2104
			public int thread_static_fields_offset;

			// Token: 0x04000839 RID: 2105
			public uint flags;

			// Token: 0x0400083A RID: 2106
			public uint token;

			// Token: 0x0400083B RID: 2107
			public ushort method_count;

			// Token: 0x0400083C RID: 2108
			public ushort property_count;

			// Token: 0x0400083D RID: 2109
			public ushort field_count;

			// Token: 0x0400083E RID: 2110
			public ushort event_count;

			// Token: 0x0400083F RID: 2111
			public ushort nested_type_count;

			// Token: 0x04000840 RID: 2112
			public ushort vtable_count;

			// Token: 0x04000841 RID: 2113
			public ushort interfaces_count;

			// Token: 0x04000842 RID: 2114
			public ushort interface_offsets_count;

			// Token: 0x04000843 RID: 2115
			public byte typeHierarchyDepth;

			// Token: 0x04000844 RID: 2116
			public byte genericRecursionDepth;

			// Token: 0x04000845 RID: 2117
			public byte rank;

			// Token: 0x04000846 RID: 2118
			public byte minimumAlignment;

			// Token: 0x04000847 RID: 2119
			public byte naturalAligment;

			// Token: 0x04000848 RID: 2120
			public byte packingSize;

			// Token: 0x04000849 RID: 2121
			public NativeClassStructHandler_27_3.Il2CppClass_27_3.Bitfield0 _bitfield0;

			// Token: 0x020000FD RID: 253
			internal enum Bitfield0 : ushort
			{
				// Token: 0x0400084B RID: 2123
				BIT_initialized_and_no_error,
				// Token: 0x0400084C RID: 2124
				initialized_and_no_error,
				// Token: 0x0400084D RID: 2125
				BIT_initialized = 1,
				// Token: 0x0400084E RID: 2126
				initialized,
				// Token: 0x0400084F RID: 2127
				BIT_enumtype = 2,
				// Token: 0x04000850 RID: 2128
				enumtype = 4,
				// Token: 0x04000851 RID: 2129
				BIT_is_generic = 3,
				// Token: 0x04000852 RID: 2130
				is_generic = 8,
				// Token: 0x04000853 RID: 2131
				BIT_has_references = 4,
				// Token: 0x04000854 RID: 2132
				has_references = 16,
				// Token: 0x04000855 RID: 2133
				BIT_init_pending = 5,
				// Token: 0x04000856 RID: 2134
				init_pending = 32,
				// Token: 0x04000857 RID: 2135
				BIT_size_init_pending = 6,
				// Token: 0x04000858 RID: 2136
				size_init_pending = 64,
				// Token: 0x04000859 RID: 2137
				BIT_size_inited = 7,
				// Token: 0x0400085A RID: 2138
				size_inited = 128,
				// Token: 0x0400085B RID: 2139
				BIT_has_finalize = 8,
				// Token: 0x0400085C RID: 2140
				has_finalize = 256,
				// Token: 0x0400085D RID: 2141
				BIT_has_cctor = 9,
				// Token: 0x0400085E RID: 2142
				has_cctor = 512,
				// Token: 0x0400085F RID: 2143
				BIT_is_blittable = 10,
				// Token: 0x04000860 RID: 2144
				is_blittable = 1024,
				// Token: 0x04000861 RID: 2145
				BIT_is_import_or_windows_runtime = 11,
				// Token: 0x04000862 RID: 2146
				is_import_or_windows_runtime = 2048,
				// Token: 0x04000863 RID: 2147
				BIT_is_vtable_initialized = 12,
				// Token: 0x04000864 RID: 2148
				is_vtable_initialized = 4096,
				// Token: 0x04000865 RID: 2149
				BIT_has_initialization_error = 13,
				// Token: 0x04000866 RID: 2150
				has_initialization_error = 8192
			}
		}

		// Token: 0x020000FE RID: 254
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000AF6 RID: 2806 RVA: 0x00025330 File Offset: 0x00023530
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_27_3.NativeStructWrapper.Jc7pMgPWUWUriQXEtJr();
				NativeClassStructHandler_27_3.NativeStructWrapper.Hen5wsPCaUv3BesdoGd();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eeb967463afe407d8f7c3b354043704c != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb8decd62b945dda713f7b22b6b95ca == 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x170003F8 RID: 1016
			// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x000253C0 File Offset: 0x000235C0
			private unsafe NativeClassStructHandler_27_3.Il2CppClass_27_3* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170003F9 RID: 1017
			// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x000253D0 File Offset: 0x000235D0
			// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x000253E8 File Offset: 0x000235E8
			public bool HasReferences
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_27_3.NativeStructWrapper.tQuviEP9aA4yGXiQXde(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6c17eda4faca4bd29ba4134efb91a5a8 == 0)
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

			// Token: 0x170003FA RID: 1018
			// (get) Token: 0x06000AFA RID: 2810 RVA: 0x0002544C File Offset: 0x0002364C
			public IntPtr Pointer { get; }

			// Token: 0x170003FB RID: 1019
			// (get) Token: 0x06000AFB RID: 2811 RVA: 0x0002545C File Offset: 0x0002365C
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_27_3.NativeStructWrapper.l64lJmPIoX870N2Pv2T(this.Pointer, sizeof(NativeClassStructHandler_27_3.Il2CppClass_27_3), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x170003FC RID: 1020
			// (get) Token: 0x06000AFC RID: 2812 RVA: 0x0002547C File Offset: 0x0002367C
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170003FD RID: 1021
			// (get) Token: 0x06000AFD RID: 2813 RVA: 0x0002548C File Offset: 0x0002368C
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x170003FE RID: 1022
			// (get) Token: 0x06000AFE RID: 2814 RVA: 0x000254A8 File Offset: 0x000236A8
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x170003FF RID: 1023
			// (get) Token: 0x06000AFF RID: 2815 RVA: 0x000254C4 File Offset: 0x000236C4
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x17000400 RID: 1024
			// (get) Token: 0x06000B00 RID: 2816 RVA: 0x000254D8 File Offset: 0x000236D8
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x17000401 RID: 1025
			// (get) Token: 0x06000B01 RID: 2817 RVA: 0x000254EC File Offset: 0x000236EC
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x17000402 RID: 1026
			// (get) Token: 0x06000B02 RID: 2818 RVA: 0x00025500 File Offset: 0x00023700
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x17000403 RID: 1027
			// (get) Token: 0x06000B03 RID: 2819 RVA: 0x00025514 File Offset: 0x00023714
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x17000404 RID: 1028
			// (get) Token: 0x06000B04 RID: 2820 RVA: 0x00025528 File Offset: 0x00023728
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x17000405 RID: 1029
			// (get) Token: 0x06000B05 RID: 2821 RVA: 0x0002553C File Offset: 0x0002373C
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x17000406 RID: 1030
			// (get) Token: 0x06000B06 RID: 2822 RVA: 0x00025550 File Offset: 0x00023750
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x17000407 RID: 1031
			// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00025564 File Offset: 0x00023764
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x17000408 RID: 1032
			// (get) Token: 0x06000B08 RID: 2824 RVA: 0x00025578 File Offset: 0x00023778
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x17000409 RID: 1033
			// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00025590 File Offset: 0x00023790
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700040A RID: 1034
			// (get) Token: 0x06000B0A RID: 2826 RVA: 0x000255A8 File Offset: 0x000237A8
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x1700040B RID: 1035
			// (get) Token: 0x06000B0B RID: 2827 RVA: 0x000255C0 File Offset: 0x000237C0
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x1700040C RID: 1036
			// (get) Token: 0x06000B0C RID: 2828 RVA: 0x000255D4 File Offset: 0x000237D4
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700040D RID: 1037
			// (get) Token: 0x06000B0D RID: 2829 RVA: 0x000255E8 File Offset: 0x000237E8
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x1700040E RID: 1038
			// (get) Token: 0x06000B0E RID: 2830 RVA: 0x000255FC File Offset: 0x000237FC
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x1700040F RID: 1039
			// (get) Token: 0x06000B0F RID: 2831 RVA: 0x00025610 File Offset: 0x00023810
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x17000410 RID: 1040
			// (get) Token: 0x06000B10 RID: 2832 RVA: 0x00025624 File Offset: 0x00023824
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x17000411 RID: 1041
			// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00025638 File Offset: 0x00023838
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x17000412 RID: 1042
			// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0002564C File Offset: 0x0002384C
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x17000413 RID: 1043
			// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00025660 File Offset: 0x00023860
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x17000414 RID: 1044
			// (get) Token: 0x06000B14 RID: 2836 RVA: 0x00025674 File Offset: 0x00023874
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x17000415 RID: 1045
			// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00025688 File Offset: 0x00023888
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x17000416 RID: 1046
			// (get) Token: 0x06000B16 RID: 2838 RVA: 0x0002569C File Offset: 0x0002389C
			// (set) Token: 0x06000B17 RID: 2839 RVA: 0x00025738 File Offset: 0x00023938
			public bool ValueType
			{
				get
				{
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							if (NativeClassStructHandler_27_3.NativeStructWrapper.qwwy0DPdR1Gpe8UORjW(this.ByValArg))
							{
								goto IL_2F;
							}
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							goto IL_2F;
						}
						break;
					}
					return false;
					IL_2F:
					return this.ThisArg.ValueType;
				}
				set
				{
				}
			}

			// Token: 0x17000417 RID: 1047
			// (get) Token: 0x06000B18 RID: 2840 RVA: 0x00025744 File Offset: 0x00023944
			// (set) Token: 0x06000B19 RID: 2841 RVA: 0x0002575C File Offset: 0x0002395C
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_27_3.NativeStructWrapper.nOKTJMPiAmsfh8JgA12(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_27_3.NativeStructWrapper.tQuviEP9aA4yGXiQXde(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c04403f838344b38b3a8911774a446ea == 0)
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

			// Token: 0x17000418 RID: 1048
			// (get) Token: 0x06000B1A RID: 2842 RVA: 0x000257C0 File Offset: 0x000239C0
			// (set) Token: 0x06000B1B RID: 2843 RVA: 0x000257D8 File Offset: 0x000239D8
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_27_3.NativeStructWrapper.nOKTJMPiAmsfh8JgA12(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_27_3.NativeStructWrapper.tQuviEP9aA4yGXiQXde(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c580bbd8275c462fb04ea886a5e08073 == 0)
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

			// Token: 0x17000419 RID: 1049
			// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0002583C File Offset: 0x00023A3C
			// (set) Token: 0x06000B1D RID: 2845 RVA: 0x00025854 File Offset: 0x00023A54
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_27_3.NativeStructWrapper.nOKTJMPiAmsfh8JgA12(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_27_3.NativeStructWrapper.tQuviEP9aA4yGXiQXde(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_23fed2b647424ffc818af5297e87fd1e != 0)
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

			// Token: 0x1700041A RID: 1050
			// (get) Token: 0x06000B1E RID: 2846 RVA: 0x000258B8 File Offset: 0x00023AB8
			// (set) Token: 0x06000B1F RID: 2847 RVA: 0x000258D0 File Offset: 0x00023AD0
			public bool SizeInited
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_27_3.NativeStructWrapper.tQuviEP9aA4yGXiQXde(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_07ecbd0ef7af44eb94dd5a58ea706c8a != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700041B RID: 1051
			// (get) Token: 0x06000B20 RID: 2848 RVA: 0x00025934 File Offset: 0x00023B34
			// (set) Token: 0x06000B21 RID: 2849 RVA: 0x0002594C File Offset: 0x00023B4C
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_27_3.NativeStructWrapper.nOKTJMPiAmsfh8JgA12(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 8);
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
							this.SetBit(NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 8, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2356ac6ca5954f1897cd5bbbe0161ae5 != 0)
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

			// Token: 0x1700041C RID: 1052
			// (get) Token: 0x06000B22 RID: 2850 RVA: 0x000259B0 File Offset: 0x00023BB0
			// (set) Token: 0x06000B23 RID: 2851 RVA: 0x000259C8 File Offset: 0x00023BC8
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_27_3.NativeStructWrapper.nOKTJMPiAmsfh8JgA12(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 12);
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
							NativeClassStructHandler_27_3.NativeStructWrapper.tQuviEP9aA4yGXiQXde(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 12, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_420bdc7f003c47439a9f8331e71194a1 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700041D RID: 1053
			// (get) Token: 0x06000B24 RID: 2852 RVA: 0x00025A30 File Offset: 0x00023C30
			// (set) Token: 0x06000B25 RID: 2853 RVA: 0x00025A48 File Offset: 0x00023C48
			public bool InitializedAndNoError
			{
				get
				{
					return NativeClassStructHandler_27_3.NativeStructWrapper.nOKTJMPiAmsfh8JgA12(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_27_3.NativeStructWrapper.tQuviEP9aA4yGXiQXde(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_49f6034724814fe88f4ca6e5ef134249 != 0)
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

			// Token: 0x06000B26 RID: 2854 RVA: 0x00025AAC File Offset: 0x00023CAC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						NativeClassStructHandler_27_3.NativeStructWrapper.Jc7pMgPWUWUriQXEtJr();
						num2 = 5;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4356a7af7f8147b79f2ed4ab0c268438 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 2:
						hIDAYxH6DWLHIthQgC.zSLipEDdx();
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_068b7dfa4ec449e7b5200030c1c277e5 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_27_3.Il2CppClass_27_3>(NativeClassStructHandler_27_3.NativeStructWrapper.AVOH4BPwDktL0HBdsJY(-1475211578 - -148084141 ^ -460418304 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b5e8e4146b4a178d711afdb1274991));
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4f96e4bec76a4c34a19bcff463d6dc03 == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					case 4:
					{
						IntPtr intPtr;
						NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_124ad935e0834fda9ae7f452377dbe1c != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					case 5:
						NativeClassStructHandler_27_3.NativeStructWrapper.Hen5wsPCaUv3BesdoGd();
						num2 = 3;
						continue;
					}
					break;
				}
			}

			// Token: 0x06000B27 RID: 2855 RVA: 0x00025BC4 File Offset: 0x00023DC4
			internal static void Jc7pMgPWUWUriQXEtJr()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000B28 RID: 2856 RVA: 0x00025BD4 File Offset: 0x00023DD4
			internal static void Hen5wsPCaUv3BesdoGd()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000B29 RID: 2857 RVA: 0x00025BE4 File Offset: 0x00023DE4
			internal static bool AkQe9uPRmveeYpiOS6E()
			{
				return NativeClassStructHandler_27_3.NativeStructWrapper.jKdTYSPF0KR1LusxCdj == null;
			}

			// Token: 0x06000B2A RID: 2858 RVA: 0x00025BF8 File Offset: 0x00023DF8
			internal static NativeClassStructHandler_27_3.NativeStructWrapper ylyNYPPMtroBvk9U1S4()
			{
				return NativeClassStructHandler_27_3.NativeStructWrapper.jKdTYSPF0KR1LusxCdj;
			}

			// Token: 0x06000B2B RID: 2859 RVA: 0x00025C08 File Offset: 0x00023E08
			internal static void tQuviEP9aA4yGXiQXde(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000B2C RID: 2860 RVA: 0x00025C28 File Offset: 0x00023E28
			internal static IntPtr l64lJmPIoX870N2Pv2T(IntPtr A_0, int A_1, object A_2)
			{
				return apS1BFcfBa3gXUspL9j.muOq5LWqgj(A_0, A_1, A_2);
			}

			// Token: 0x06000B2D RID: 2861 RVA: 0x00025C44 File Offset: 0x00023E44
			internal static bool qwwy0DPdR1Gpe8UORjW(object A_0)
			{
				return ((INativeTypeStruct)A_0).ValueType;
			}

			// Token: 0x06000B2E RID: 2862 RVA: 0x00025C58 File Offset: 0x00023E58
			internal static bool nOKTJMPiAmsfh8JgA12(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000B2F RID: 2863 RVA: 0x00025C74 File Offset: 0x00023E74
			internal static object AVOH4BPwDktL0HBdsJY(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000867 RID: 2151
			private static readonly int _bitfield0offset;

			// Token: 0x04000869 RID: 2153
			internal static object jKdTYSPF0KR1LusxCdj;
		}
	}
}
