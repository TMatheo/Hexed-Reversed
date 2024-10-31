using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000FF RID: 255
	[ApplicableToUnityVersionsSince("2021.2.0")]
	public class NativeClassStructHandler_29_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000B30 RID: 2864 RVA: 0x00011F50 File Offset: 0x00010150
		public int Size()
		{
			return sizeof(NativeClassStructHandler_29_0.Il2CppClass_29_0);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00011F60 File Offset: 0x00010160
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_29_0.Il2CppClass_29_0* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_29_0.gctfN7yzVeBb5Im7GmJ(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_29_0.Il2CppClass_29_0);
			return new NativeClassStructHandler_29_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00011F98 File Offset: 0x00010198
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
			return new NativeClassStructHandler_29_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00012000 File Offset: 0x00010200
		public NativeClassStructHandler_29_0()
		{
			NativeClassStructHandler_29_0.TDyojZJlaD2TeRXt6mP();
			NativeClassStructHandler_29_0.SXdY7CJqHsD0h1UBjB0();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_49f6034724814fe88f4ca6e5ef134249 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00012064 File Offset: 0x00010264
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_29_0()
		{
			NativeClassStructHandler_29_0.ORLcKdJ5JkorL7ZCGkT();
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00012074 File Offset: 0x00010274
		internal static IntPtr gctfN7yzVeBb5Im7GmJ(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00012088 File Offset: 0x00010288
		internal static bool hLYeF8yaDgNkrRgk4BV()
		{
			return NativeClassStructHandler_29_0.ylh0UUyKsOgf10e5T2A == null;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x0001209C File Offset: 0x0001029C
		internal static NativeClassStructHandler_29_0 dZvQb2yZ6hcBkcEbtJV()
		{
			return NativeClassStructHandler_29_0.ylh0UUyKsOgf10e5T2A;
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x000120AC File Offset: 0x000102AC
		internal static void TDyojZJlaD2TeRXt6mP()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x000120BC File Offset: 0x000102BC
		internal static void SXdY7CJqHsD0h1UBjB0()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x000120CC File Offset: 0x000102CC
		internal static void ORLcKdJ5JkorL7ZCGkT()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400086A RID: 2154
		internal static NativeClassStructHandler_29_0 ylh0UUyKsOgf10e5T2A;

		// Token: 0x02000100 RID: 256
		internal struct Il2CppClass_29_0
		{
			// Token: 0x0400086B RID: 2155
			public unsafe Il2CppImage* image;

			// Token: 0x0400086C RID: 2156
			public unsafe void* gc_desc;

			// Token: 0x0400086D RID: 2157
			public unsafe byte* name;

			// Token: 0x0400086E RID: 2158
			public unsafe byte* namespaze;

			// Token: 0x0400086F RID: 2159
			public NativeTypeStructHandler_27_0.Il2CppType_27_0 byval_arg;

			// Token: 0x04000870 RID: 2160
			public NativeTypeStructHandler_27_0.Il2CppType_27_0 this_arg;

			// Token: 0x04000871 RID: 2161
			public unsafe Il2CppClass* element_class;

			// Token: 0x04000872 RID: 2162
			public unsafe Il2CppClass* castClass;

			// Token: 0x04000873 RID: 2163
			public unsafe Il2CppClass* declaringType;

			// Token: 0x04000874 RID: 2164
			public unsafe Il2CppClass* parent;

			// Token: 0x04000875 RID: 2165
			public unsafe void* generic_class;

			// Token: 0x04000876 RID: 2166
			public Il2CppMetadataTypeHandle typeMetadataHandle;

			// Token: 0x04000877 RID: 2167
			public unsafe void* interopData;

			// Token: 0x04000878 RID: 2168
			public unsafe Il2CppClass* klass;

			// Token: 0x04000879 RID: 2169
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x0400087A RID: 2170
			public unsafe Il2CppEventInfo* events;

			// Token: 0x0400087B RID: 2171
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x0400087C RID: 2172
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x0400087D RID: 2173
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x0400087E RID: 2174
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x0400087F RID: 2175
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x04000880 RID: 2176
			public unsafe void* static_fields;

			// Token: 0x04000881 RID: 2177
			public unsafe void* rgctx_data;

			// Token: 0x04000882 RID: 2178
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x04000883 RID: 2179
			public unsafe void* unity_user_data;

			// Token: 0x04000884 RID: 2180
			public uint initializationExceptionGCHandle;

			// Token: 0x04000885 RID: 2181
			public uint cctor_started;

			// Token: 0x04000886 RID: 2182
			public uint cctor_finished_or_no_cctor;

			// Token: 0x04000887 RID: 2183
			public IntPtr cctor_thread;

			// Token: 0x04000888 RID: 2184
			public Il2CppMetadataGenericContainerHandle genericContainerHandle;

			// Token: 0x04000889 RID: 2185
			public uint instance_size;

			// Token: 0x0400088A RID: 2186
			public uint actualSize;

			// Token: 0x0400088B RID: 2187
			public uint element_size;

			// Token: 0x0400088C RID: 2188
			public int native_size;

			// Token: 0x0400088D RID: 2189
			public uint static_fields_size;

			// Token: 0x0400088E RID: 2190
			public uint thread_static_fields_size;

			// Token: 0x0400088F RID: 2191
			public int thread_static_fields_offset;

			// Token: 0x04000890 RID: 2192
			public uint flags;

			// Token: 0x04000891 RID: 2193
			public uint token;

			// Token: 0x04000892 RID: 2194
			public ushort method_count;

			// Token: 0x04000893 RID: 2195
			public ushort property_count;

			// Token: 0x04000894 RID: 2196
			public ushort field_count;

			// Token: 0x04000895 RID: 2197
			public ushort event_count;

			// Token: 0x04000896 RID: 2198
			public ushort nested_type_count;

			// Token: 0x04000897 RID: 2199
			public ushort vtable_count;

			// Token: 0x04000898 RID: 2200
			public ushort interfaces_count;

			// Token: 0x04000899 RID: 2201
			public ushort interface_offsets_count;

			// Token: 0x0400089A RID: 2202
			public byte typeHierarchyDepth;

			// Token: 0x0400089B RID: 2203
			public byte genericRecursionDepth;

			// Token: 0x0400089C RID: 2204
			public byte rank;

			// Token: 0x0400089D RID: 2205
			public byte minimumAlignment;

			// Token: 0x0400089E RID: 2206
			public byte naturalAligment;

			// Token: 0x0400089F RID: 2207
			public byte packingSize;

			// Token: 0x040008A0 RID: 2208
			public NativeClassStructHandler_29_0.Il2CppClass_29_0.Bitfield0 _bitfield0;

			// Token: 0x02000101 RID: 257
			internal enum Bitfield0 : ushort
			{
				// Token: 0x040008A2 RID: 2210
				BIT_initialized_and_no_error,
				// Token: 0x040008A3 RID: 2211
				initialized_and_no_error,
				// Token: 0x040008A4 RID: 2212
				BIT_initialized = 1,
				// Token: 0x040008A5 RID: 2213
				initialized,
				// Token: 0x040008A6 RID: 2214
				BIT_enumtype = 2,
				// Token: 0x040008A7 RID: 2215
				enumtype = 4,
				// Token: 0x040008A8 RID: 2216
				BIT_nullabletype = 3,
				// Token: 0x040008A9 RID: 2217
				nullabletype = 8,
				// Token: 0x040008AA RID: 2218
				BIT_is_generic = 4,
				// Token: 0x040008AB RID: 2219
				is_generic = 16,
				// Token: 0x040008AC RID: 2220
				BIT_has_references = 5,
				// Token: 0x040008AD RID: 2221
				has_references = 32,
				// Token: 0x040008AE RID: 2222
				BIT_init_pending = 6,
				// Token: 0x040008AF RID: 2223
				init_pending = 64,
				// Token: 0x040008B0 RID: 2224
				BIT_size_init_pending = 7,
				// Token: 0x040008B1 RID: 2225
				size_init_pending = 128,
				// Token: 0x040008B2 RID: 2226
				BIT_size_inited = 8,
				// Token: 0x040008B3 RID: 2227
				size_inited = 256,
				// Token: 0x040008B4 RID: 2228
				BIT_has_finalize = 9,
				// Token: 0x040008B5 RID: 2229
				has_finalize = 512,
				// Token: 0x040008B6 RID: 2230
				BIT_has_cctor = 10,
				// Token: 0x040008B7 RID: 2231
				has_cctor = 1024,
				// Token: 0x040008B8 RID: 2232
				BIT_is_blittable = 11,
				// Token: 0x040008B9 RID: 2233
				is_blittable = 2048,
				// Token: 0x040008BA RID: 2234
				BIT_is_import_or_windows_runtime = 12,
				// Token: 0x040008BB RID: 2235
				is_import_or_windows_runtime = 4096,
				// Token: 0x040008BC RID: 2236
				BIT_is_vtable_initialized = 13,
				// Token: 0x040008BD RID: 2237
				is_vtable_initialized = 8192,
				// Token: 0x040008BE RID: 2238
				BIT_is_byref_like = 14,
				// Token: 0x040008BF RID: 2239
				is_byref_like = 16384
			}
		}

		// Token: 0x02000102 RID: 258
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000B3B RID: 2875 RVA: 0x00025C88 File Offset: 0x00023E88
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeClassStructHandler_29_0.NativeStructWrapper.xYqfc8PohBZJZlkBqoI();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5a2f191df3714123bdeb9f5f4b416da9 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e6eb36653ec04a89bf8fa64932849f3b == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x1700041E RID: 1054
			// (get) Token: 0x06000B3C RID: 2876 RVA: 0x00025D18 File Offset: 0x00023F18
			private unsafe NativeClassStructHandler_29_0.Il2CppClass_29_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700041F RID: 1055
			// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00025D28 File Offset: 0x00023F28
			// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00025D40 File Offset: 0x00023F40
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_29_0.NativeStructWrapper.PLXgcOPU0yhapc6W2ZZ(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 5);
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
							NativeClassStructHandler_29_0.NativeStructWrapper.zH0AByPjj4o7c4jtL2Q(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 5, value);
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

			// Token: 0x17000420 RID: 1056
			// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00025DA4 File Offset: 0x00023FA4
			public IntPtr Pointer { get; }

			// Token: 0x17000421 RID: 1057
			// (get) Token: 0x06000B40 RID: 2880 RVA: 0x00025DB4 File Offset: 0x00023FB4
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_29_0.NativeStructWrapper.OaDoi5PQQr7bDdBPqu2(this.Pointer, sizeof(NativeClassStructHandler_29_0.Il2CppClass_29_0), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x17000422 RID: 1058
			// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00025DD4 File Offset: 0x00023FD4
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000423 RID: 1059
			// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00025DE4 File Offset: 0x00023FE4
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x17000424 RID: 1060
			// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00025E00 File Offset: 0x00024000
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x17000425 RID: 1061
			// (get) Token: 0x06000B44 RID: 2884 RVA: 0x00025E1C File Offset: 0x0002401C
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x17000426 RID: 1062
			// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00025E30 File Offset: 0x00024030
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x17000427 RID: 1063
			// (get) Token: 0x06000B46 RID: 2886 RVA: 0x00025E44 File Offset: 0x00024044
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x17000428 RID: 1064
			// (get) Token: 0x06000B47 RID: 2887 RVA: 0x00025E58 File Offset: 0x00024058
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x17000429 RID: 1065
			// (get) Token: 0x06000B48 RID: 2888 RVA: 0x00025E6C File Offset: 0x0002406C
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x1700042A RID: 1066
			// (get) Token: 0x06000B49 RID: 2889 RVA: 0x00025E80 File Offset: 0x00024080
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x1700042B RID: 1067
			// (get) Token: 0x06000B4A RID: 2890 RVA: 0x00025E94 File Offset: 0x00024094
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x1700042C RID: 1068
			// (get) Token: 0x06000B4B RID: 2891 RVA: 0x00025EA8 File Offset: 0x000240A8
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x1700042D RID: 1069
			// (get) Token: 0x06000B4C RID: 2892 RVA: 0x00025EBC File Offset: 0x000240BC
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x1700042E RID: 1070
			// (get) Token: 0x06000B4D RID: 2893 RVA: 0x00025ED0 File Offset: 0x000240D0
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x1700042F RID: 1071
			// (get) Token: 0x06000B4E RID: 2894 RVA: 0x00025EE8 File Offset: 0x000240E8
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000430 RID: 1072
			// (get) Token: 0x06000B4F RID: 2895 RVA: 0x00025F00 File Offset: 0x00024100
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x17000431 RID: 1073
			// (get) Token: 0x06000B50 RID: 2896 RVA: 0x00025F18 File Offset: 0x00024118
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x17000432 RID: 1074
			// (get) Token: 0x06000B51 RID: 2897 RVA: 0x00025F2C File Offset: 0x0002412C
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000433 RID: 1075
			// (get) Token: 0x06000B52 RID: 2898 RVA: 0x00025F40 File Offset: 0x00024140
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x17000434 RID: 1076
			// (get) Token: 0x06000B53 RID: 2899 RVA: 0x00025F54 File Offset: 0x00024154
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x17000435 RID: 1077
			// (get) Token: 0x06000B54 RID: 2900 RVA: 0x00025F68 File Offset: 0x00024168
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x17000436 RID: 1078
			// (get) Token: 0x06000B55 RID: 2901 RVA: 0x00025F7C File Offset: 0x0002417C
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x17000437 RID: 1079
			// (get) Token: 0x06000B56 RID: 2902 RVA: 0x00025F90 File Offset: 0x00024190
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x17000438 RID: 1080
			// (get) Token: 0x06000B57 RID: 2903 RVA: 0x00025FA4 File Offset: 0x000241A4
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x17000439 RID: 1081
			// (get) Token: 0x06000B58 RID: 2904 RVA: 0x00025FB8 File Offset: 0x000241B8
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x1700043A RID: 1082
			// (get) Token: 0x06000B59 RID: 2905 RVA: 0x00025FCC File Offset: 0x000241CC
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x1700043B RID: 1083
			// (get) Token: 0x06000B5A RID: 2906 RVA: 0x00025FE0 File Offset: 0x000241E0
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x1700043C RID: 1084
			// (get) Token: 0x06000B5B RID: 2907 RVA: 0x00025FF4 File Offset: 0x000241F4
			// (set) Token: 0x06000B5C RID: 2908 RVA: 0x00026068 File Offset: 0x00024268
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
							if (!NativeClassStructHandler_29_0.NativeStructWrapper.s59fKwPeJWRUPIxHlBn(this.ByValArg))
							{
								return false;
							}
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_07ecbd0ef7af44eb94dd5a58ea706c8a == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
					return NativeClassStructHandler_29_0.NativeStructWrapper.s59fKwPeJWRUPIxHlBn(this.ThisArg);
				}
				set
				{
				}
			}

			// Token: 0x1700043D RID: 1085
			// (get) Token: 0x06000B5D RID: 2909 RVA: 0x00026074 File Offset: 0x00024274
			// (set) Token: 0x06000B5E RID: 2910 RVA: 0x0002608C File Offset: 0x0002428C
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_29_0.NativeStructWrapper.PLXgcOPU0yhapc6W2ZZ(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_29_0.NativeStructWrapper.zH0AByPjj4o7c4jtL2Q(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_30f9f5d7d3f347ddac00a7ce0719d7cd == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700043E RID: 1086
			// (get) Token: 0x06000B5F RID: 2911 RVA: 0x000260F0 File Offset: 0x000242F0
			// (set) Token: 0x06000B60 RID: 2912 RVA: 0x00026108 File Offset: 0x00024308
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_29_0.NativeStructWrapper.PLXgcOPU0yhapc6W2ZZ(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 2);
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
							this.SetBit(NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b55404cff7864ea3949f7b4156fd6ee5 == 0)
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

			// Token: 0x1700043F RID: 1087
			// (get) Token: 0x06000B61 RID: 2913 RVA: 0x0002616C File Offset: 0x0002436C
			// (set) Token: 0x06000B62 RID: 2914 RVA: 0x00026184 File Offset: 0x00024384
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_29_0.NativeStructWrapper.PLXgcOPU0yhapc6W2ZZ(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_29_0.NativeStructWrapper.zH0AByPjj4o7c4jtL2Q(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 4, value);
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

			// Token: 0x17000440 RID: 1088
			// (get) Token: 0x06000B63 RID: 2915 RVA: 0x000261E8 File Offset: 0x000243E8
			// (set) Token: 0x06000B64 RID: 2916 RVA: 0x00026200 File Offset: 0x00024400
			public bool SizeInited
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 8);
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
							NativeClassStructHandler_29_0.NativeStructWrapper.zH0AByPjj4o7c4jtL2Q(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 8, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6a95c50bbb48420f8f11bb090d6d3bd5 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000441 RID: 1089
			// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00026264 File Offset: 0x00024464
			// (set) Token: 0x06000B66 RID: 2918 RVA: 0x0002627C File Offset: 0x0002447C
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_29_0.NativeStructWrapper.PLXgcOPU0yhapc6W2ZZ(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 9);
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
							this.SetBit(NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 9, value);
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

			// Token: 0x17000442 RID: 1090
			// (get) Token: 0x06000B67 RID: 2919 RVA: 0x000262E4 File Offset: 0x000244E4
			// (set) Token: 0x06000B68 RID: 2920 RVA: 0x000262FC File Offset: 0x000244FC
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_29_0.NativeStructWrapper.PLXgcOPU0yhapc6W2ZZ(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 13);
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
							NativeClassStructHandler_29_0.NativeStructWrapper.zH0AByPjj4o7c4jtL2Q(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 13, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cb2874465fa5416db806f31e03cc475c == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000443 RID: 1091
			// (get) Token: 0x06000B69 RID: 2921 RVA: 0x00026364 File Offset: 0x00024564
			// (set) Token: 0x06000B6A RID: 2922 RVA: 0x0002637C File Offset: 0x0002457C
			public bool InitializedAndNoError
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_29_0.NativeStructWrapper.zH0AByPjj4o7c4jtL2Q(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_43cc35cb254148318955c7f83ade60f1 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x06000B6B RID: 2923 RVA: 0x000263E0 File Offset: 0x000245E0
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
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_29_0.Il2CppClass_29_0>(NativeClassStructHandler_29_0.NativeStructWrapper.YW0SY7PafQZxWsV3CjX(2107640300 ^ 1023724905 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4356a7af7f8147b79f2ed4ab0c268438));
						num2 = 3;
						break;
					}
					case 1:
						return;
					case 2:
						nHwRpygmi6xxZAssJn.EmlEpH4Phw();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b502855b254c47cfafcd30fd84ad7c96 == 0)
						{
							num2 = 0;
						}
						break;
					case 3:
					{
						IntPtr intPtr;
						NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6d7a22a8da0c4b3e8cf479dd7edc9922 == 0)
						{
							num2 = 1;
						}
						break;
					}
					case 4:
						hIDAYxH6DWLHIthQgC.oDuBOTgYK();
						num2 = 2;
						break;
					case 5:
						NativeClassStructHandler_29_0.NativeStructWrapper.Q7sWhnPKqQ2S6uvhxBx();
						num2 = 4;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6dbfd13d96434eb59d868fecd0ad1cda == 0)
						{
							num2 = 3;
						}
						break;
					}
				}
			}

			// Token: 0x06000B6C RID: 2924 RVA: 0x000264DC File Offset: 0x000246DC
			internal static void xYqfc8PohBZJZlkBqoI()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000B6D RID: 2925 RVA: 0x000264EC File Offset: 0x000246EC
			internal static bool g582wqPT1kalP1OnDVq()
			{
				return NativeClassStructHandler_29_0.NativeStructWrapper.RdmvqnPreL43w2QppKU == null;
			}

			// Token: 0x06000B6E RID: 2926 RVA: 0x00026500 File Offset: 0x00024700
			internal static NativeClassStructHandler_29_0.NativeStructWrapper MVsBS5Pga7Gourb6EG7()
			{
				return NativeClassStructHandler_29_0.NativeStructWrapper.RdmvqnPreL43w2QppKU;
			}

			// Token: 0x06000B6F RID: 2927 RVA: 0x00026510 File Offset: 0x00024710
			internal static bool PLXgcOPU0yhapc6W2ZZ(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000B70 RID: 2928 RVA: 0x0002652C File Offset: 0x0002472C
			internal static void zH0AByPjj4o7c4jtL2Q(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000B71 RID: 2929 RVA: 0x0002654C File Offset: 0x0002474C
			internal static IntPtr OaDoi5PQQr7bDdBPqu2(IntPtr A_0, int A_1, object A_2)
			{
				return apS1BFcfBa3gXUspL9j.muOq5LWqgj(A_0, A_1, A_2);
			}

			// Token: 0x06000B72 RID: 2930 RVA: 0x00026568 File Offset: 0x00024768
			internal static bool s59fKwPeJWRUPIxHlBn(object A_0)
			{
				return ((INativeTypeStruct)A_0).ValueType;
			}

			// Token: 0x06000B73 RID: 2931 RVA: 0x0002657C File Offset: 0x0002477C
			internal static void Q7sWhnPKqQ2S6uvhxBx()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000B74 RID: 2932 RVA: 0x0002658C File Offset: 0x0002478C
			internal static object YW0SY7PafQZxWsV3CjX(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x040008C0 RID: 2240
			private static readonly int _bitfield0offset;

			// Token: 0x040008C2 RID: 2242
			private static object RdmvqnPreL43w2QppKU;
		}
	}
}
