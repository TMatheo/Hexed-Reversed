using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x02000101 RID: 257
	[ApplicableToUnityVersionsSince("2021.2.0")]
	public class NativeClassStructHandler_29_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000B54 RID: 2900 RVA: 0x00012BAC File Offset: 0x00010DAC
		public int Size()
		{
			return sizeof(NativeClassStructHandler_29_0.Il2CppClass_29_0);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00012BBC File Offset: 0x00010DBC
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_29_0.Il2CppClass_29_0* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_29_0.usqsBLLkvK1nHVcAReR(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_29_0.Il2CppClass_29_0);
			return new NativeClassStructHandler_29_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00012BF4 File Offset: 0x00010DF4
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_570d4e075bf443fcbaca8db32e007291 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeClassStructHandler_29_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00012C5C File Offset: 0x00010E5C
		public NativeClassStructHandler_29_0()
		{
			NativeClassStructHandler_29_0.qbYsWoLJXxdGWqcytIo();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bc244a0192c343599cd1cf83671e02ab == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00012CC0 File Offset: 0x00010EC0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_29_0()
		{
			NativeClassStructHandler_29_0.AqVy8hLWDV7bYf4F0nB();
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00012CD0 File Offset: 0x00010ED0
		internal static IntPtr usqsBLLkvK1nHVcAReR(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00012CE4 File Offset: 0x00010EE4
		internal static bool TvOH2yL7D9lhrbjXu3X()
		{
			return NativeClassStructHandler_29_0.MjDoyILLTC5Fsa1AS9d == null;
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00012CF8 File Offset: 0x00010EF8
		internal static NativeClassStructHandler_29_0 wbbuPwLRPsmOVeg05nf()
		{
			return NativeClassStructHandler_29_0.MjDoyILLTC5Fsa1AS9d;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00012D08 File Offset: 0x00010F08
		internal static void qbYsWoLJXxdGWqcytIo()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00012D18 File Offset: 0x00010F18
		internal static void AqVy8hLWDV7bYf4F0nB()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000875 RID: 2165
		private static NativeClassStructHandler_29_0 MjDoyILLTC5Fsa1AS9d;

		// Token: 0x02000102 RID: 258
		internal struct Il2CppClass_29_0
		{
			// Token: 0x04000876 RID: 2166
			public unsafe Il2CppImage* image;

			// Token: 0x04000877 RID: 2167
			public unsafe void* gc_desc;

			// Token: 0x04000878 RID: 2168
			public unsafe byte* name;

			// Token: 0x04000879 RID: 2169
			public unsafe byte* namespaze;

			// Token: 0x0400087A RID: 2170
			public NativeTypeStructHandler_27_0.Il2CppType_27_0 byval_arg;

			// Token: 0x0400087B RID: 2171
			public NativeTypeStructHandler_27_0.Il2CppType_27_0 this_arg;

			// Token: 0x0400087C RID: 2172
			public unsafe Il2CppClass* element_class;

			// Token: 0x0400087D RID: 2173
			public unsafe Il2CppClass* castClass;

			// Token: 0x0400087E RID: 2174
			public unsafe Il2CppClass* declaringType;

			// Token: 0x0400087F RID: 2175
			public unsafe Il2CppClass* parent;

			// Token: 0x04000880 RID: 2176
			public unsafe void* generic_class;

			// Token: 0x04000881 RID: 2177
			public Il2CppMetadataTypeHandle typeMetadataHandle;

			// Token: 0x04000882 RID: 2178
			public unsafe void* interopData;

			// Token: 0x04000883 RID: 2179
			public unsafe Il2CppClass* klass;

			// Token: 0x04000884 RID: 2180
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x04000885 RID: 2181
			public unsafe Il2CppEventInfo* events;

			// Token: 0x04000886 RID: 2182
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000887 RID: 2183
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x04000888 RID: 2184
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000889 RID: 2185
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x0400088A RID: 2186
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x0400088B RID: 2187
			public unsafe void* static_fields;

			// Token: 0x0400088C RID: 2188
			public unsafe void* rgctx_data;

			// Token: 0x0400088D RID: 2189
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x0400088E RID: 2190
			public unsafe void* unity_user_data;

			// Token: 0x0400088F RID: 2191
			public uint initializationExceptionGCHandle;

			// Token: 0x04000890 RID: 2192
			public uint cctor_started;

			// Token: 0x04000891 RID: 2193
			public uint cctor_finished_or_no_cctor;

			// Token: 0x04000892 RID: 2194
			public IntPtr cctor_thread;

			// Token: 0x04000893 RID: 2195
			public Il2CppMetadataGenericContainerHandle genericContainerHandle;

			// Token: 0x04000894 RID: 2196
			public uint instance_size;

			// Token: 0x04000895 RID: 2197
			public uint actualSize;

			// Token: 0x04000896 RID: 2198
			public uint element_size;

			// Token: 0x04000897 RID: 2199
			public int native_size;

			// Token: 0x04000898 RID: 2200
			public uint static_fields_size;

			// Token: 0x04000899 RID: 2201
			public uint thread_static_fields_size;

			// Token: 0x0400089A RID: 2202
			public int thread_static_fields_offset;

			// Token: 0x0400089B RID: 2203
			public uint flags;

			// Token: 0x0400089C RID: 2204
			public uint token;

			// Token: 0x0400089D RID: 2205
			public ushort method_count;

			// Token: 0x0400089E RID: 2206
			public ushort property_count;

			// Token: 0x0400089F RID: 2207
			public ushort field_count;

			// Token: 0x040008A0 RID: 2208
			public ushort event_count;

			// Token: 0x040008A1 RID: 2209
			public ushort nested_type_count;

			// Token: 0x040008A2 RID: 2210
			public ushort vtable_count;

			// Token: 0x040008A3 RID: 2211
			public ushort interfaces_count;

			// Token: 0x040008A4 RID: 2212
			public ushort interface_offsets_count;

			// Token: 0x040008A5 RID: 2213
			public byte typeHierarchyDepth;

			// Token: 0x040008A6 RID: 2214
			public byte genericRecursionDepth;

			// Token: 0x040008A7 RID: 2215
			public byte rank;

			// Token: 0x040008A8 RID: 2216
			public byte minimumAlignment;

			// Token: 0x040008A9 RID: 2217
			public byte naturalAligment;

			// Token: 0x040008AA RID: 2218
			public byte packingSize;

			// Token: 0x040008AB RID: 2219
			public NativeClassStructHandler_29_0.Il2CppClass_29_0.Bitfield0 _bitfield0;

			// Token: 0x02000103 RID: 259
			internal enum Bitfield0 : ushort
			{
				// Token: 0x040008AD RID: 2221
				BIT_initialized_and_no_error,
				// Token: 0x040008AE RID: 2222
				initialized_and_no_error,
				// Token: 0x040008AF RID: 2223
				BIT_initialized = 1,
				// Token: 0x040008B0 RID: 2224
				initialized,
				// Token: 0x040008B1 RID: 2225
				BIT_enumtype = 2,
				// Token: 0x040008B2 RID: 2226
				enumtype = 4,
				// Token: 0x040008B3 RID: 2227
				BIT_nullabletype = 3,
				// Token: 0x040008B4 RID: 2228
				nullabletype = 8,
				// Token: 0x040008B5 RID: 2229
				BIT_is_generic = 4,
				// Token: 0x040008B6 RID: 2230
				is_generic = 16,
				// Token: 0x040008B7 RID: 2231
				BIT_has_references = 5,
				// Token: 0x040008B8 RID: 2232
				has_references = 32,
				// Token: 0x040008B9 RID: 2233
				BIT_init_pending = 6,
				// Token: 0x040008BA RID: 2234
				init_pending = 64,
				// Token: 0x040008BB RID: 2235
				BIT_size_init_pending = 7,
				// Token: 0x040008BC RID: 2236
				size_init_pending = 128,
				// Token: 0x040008BD RID: 2237
				BIT_size_inited = 8,
				// Token: 0x040008BE RID: 2238
				size_inited = 256,
				// Token: 0x040008BF RID: 2239
				BIT_has_finalize = 9,
				// Token: 0x040008C0 RID: 2240
				has_finalize = 512,
				// Token: 0x040008C1 RID: 2241
				BIT_has_cctor = 10,
				// Token: 0x040008C2 RID: 2242
				has_cctor = 1024,
				// Token: 0x040008C3 RID: 2243
				BIT_is_blittable = 11,
				// Token: 0x040008C4 RID: 2244
				is_blittable = 2048,
				// Token: 0x040008C5 RID: 2245
				BIT_is_import_or_windows_runtime = 12,
				// Token: 0x040008C6 RID: 2246
				is_import_or_windows_runtime = 4096,
				// Token: 0x040008C7 RID: 2247
				BIT_is_vtable_initialized = 13,
				// Token: 0x040008C8 RID: 2248
				is_vtable_initialized = 8192,
				// Token: 0x040008C9 RID: 2249
				BIT_is_byref_like = 14,
				// Token: 0x040008CA RID: 2250
				is_byref_like = 16384
			}
		}

		// Token: 0x02000104 RID: 260
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000B5E RID: 2910 RVA: 0x00026924 File Offset: 0x00024B24
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_29_0.NativeStructWrapper.REvI7yP6qESw7R1q7Rp();
				NativeClassStructHandler_29_0.NativeStructWrapper.dAbUlLPL3Znd9KfyGRR();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c474f43efb4d4f17b5c0c1bf3216ef4d == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_906545e343eb409d9eb685fc4a903234 == 0)
						{
							num = 0;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x1700041E RID: 1054
			// (get) Token: 0x06000B5F RID: 2911 RVA: 0x000269B4 File Offset: 0x00024BB4
			private unsafe NativeClassStructHandler_29_0.Il2CppClass_29_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700041F RID: 1055
			// (get) Token: 0x06000B60 RID: 2912 RVA: 0x000269C4 File Offset: 0x00024BC4
			// (set) Token: 0x06000B61 RID: 2913 RVA: 0x000269DC File Offset: 0x00024BDC
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_29_0.NativeStructWrapper.HKD9LtP7440qSIRpler(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 5);
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
							NativeClassStructHandler_29_0.NativeStructWrapper.TlFIJTPRZXCQPrpdL3V(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 5, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_feee416e61094c739ba253659ac2e257 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000420 RID: 1056
			// (get) Token: 0x06000B62 RID: 2914 RVA: 0x00026A40 File Offset: 0x00024C40
			public IntPtr Pointer { get; }

			// Token: 0x17000421 RID: 1057
			// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00026A50 File Offset: 0x00024C50
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_29_0.NativeStructWrapper.Xd0vUoPkHHxkGJbBoFp(this.Pointer, sizeof(NativeClassStructHandler_29_0.Il2CppClass_29_0), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x17000422 RID: 1058
			// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00026A70 File Offset: 0x00024C70
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000423 RID: 1059
			// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00026A80 File Offset: 0x00024C80
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x17000424 RID: 1060
			// (get) Token: 0x06000B66 RID: 2918 RVA: 0x00026A9C File Offset: 0x00024C9C
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x17000425 RID: 1061
			// (get) Token: 0x06000B67 RID: 2919 RVA: 0x00026AB8 File Offset: 0x00024CB8
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x17000426 RID: 1062
			// (get) Token: 0x06000B68 RID: 2920 RVA: 0x00026ACC File Offset: 0x00024CCC
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x17000427 RID: 1063
			// (get) Token: 0x06000B69 RID: 2921 RVA: 0x00026AE0 File Offset: 0x00024CE0
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x17000428 RID: 1064
			// (get) Token: 0x06000B6A RID: 2922 RVA: 0x00026AF4 File Offset: 0x00024CF4
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x17000429 RID: 1065
			// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00026B08 File Offset: 0x00024D08
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x1700042A RID: 1066
			// (get) Token: 0x06000B6C RID: 2924 RVA: 0x00026B1C File Offset: 0x00024D1C
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x1700042B RID: 1067
			// (get) Token: 0x06000B6D RID: 2925 RVA: 0x00026B30 File Offset: 0x00024D30
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x1700042C RID: 1068
			// (get) Token: 0x06000B6E RID: 2926 RVA: 0x00026B44 File Offset: 0x00024D44
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x1700042D RID: 1069
			// (get) Token: 0x06000B6F RID: 2927 RVA: 0x00026B58 File Offset: 0x00024D58
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x1700042E RID: 1070
			// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00026B6C File Offset: 0x00024D6C
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x1700042F RID: 1071
			// (get) Token: 0x06000B71 RID: 2929 RVA: 0x00026B84 File Offset: 0x00024D84
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000430 RID: 1072
			// (get) Token: 0x06000B72 RID: 2930 RVA: 0x00026B9C File Offset: 0x00024D9C
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x17000431 RID: 1073
			// (get) Token: 0x06000B73 RID: 2931 RVA: 0x00026BB4 File Offset: 0x00024DB4
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x17000432 RID: 1074
			// (get) Token: 0x06000B74 RID: 2932 RVA: 0x00026BC8 File Offset: 0x00024DC8
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000433 RID: 1075
			// (get) Token: 0x06000B75 RID: 2933 RVA: 0x00026BDC File Offset: 0x00024DDC
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x17000434 RID: 1076
			// (get) Token: 0x06000B76 RID: 2934 RVA: 0x00026BF0 File Offset: 0x00024DF0
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x17000435 RID: 1077
			// (get) Token: 0x06000B77 RID: 2935 RVA: 0x00026C04 File Offset: 0x00024E04
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x17000436 RID: 1078
			// (get) Token: 0x06000B78 RID: 2936 RVA: 0x00026C18 File Offset: 0x00024E18
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x17000437 RID: 1079
			// (get) Token: 0x06000B79 RID: 2937 RVA: 0x00026C2C File Offset: 0x00024E2C
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x17000438 RID: 1080
			// (get) Token: 0x06000B7A RID: 2938 RVA: 0x00026C40 File Offset: 0x00024E40
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x17000439 RID: 1081
			// (get) Token: 0x06000B7B RID: 2939 RVA: 0x00026C54 File Offset: 0x00024E54
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x1700043A RID: 1082
			// (get) Token: 0x06000B7C RID: 2940 RVA: 0x00026C68 File Offset: 0x00024E68
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x1700043B RID: 1083
			// (get) Token: 0x06000B7D RID: 2941 RVA: 0x00026C7C File Offset: 0x00024E7C
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x1700043C RID: 1084
			// (get) Token: 0x06000B7E RID: 2942 RVA: 0x00026C90 File Offset: 0x00024E90
			// (set) Token: 0x06000B7F RID: 2943 RVA: 0x00026D04 File Offset: 0x00024F04
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
							if (!NativeClassStructHandler_29_0.NativeStructWrapper.XYGIxkPJyBA49kvGVlM(this.ByValArg))
							{
								return false;
							}
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5f6b46e73a464a41b29ca79bf0f3b8f9 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
					return NativeClassStructHandler_29_0.NativeStructWrapper.XYGIxkPJyBA49kvGVlM(this.ThisArg);
				}
				set
				{
				}
			}

			// Token: 0x1700043D RID: 1085
			// (get) Token: 0x06000B80 RID: 2944 RVA: 0x00026D10 File Offset: 0x00024F10
			// (set) Token: 0x06000B81 RID: 2945 RVA: 0x00026D28 File Offset: 0x00024F28
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_29_0.NativeStructWrapper.HKD9LtP7440qSIRpler(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_29_0.NativeStructWrapper.TlFIJTPRZXCQPrpdL3V(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8155e7a9a9bd4894b741e1951a0eace6 == 0)
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

			// Token: 0x1700043E RID: 1086
			// (get) Token: 0x06000B82 RID: 2946 RVA: 0x00026D8C File Offset: 0x00024F8C
			// (set) Token: 0x06000B83 RID: 2947 RVA: 0x00026DA4 File Offset: 0x00024FA4
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_29_0.NativeStructWrapper.HKD9LtP7440qSIRpler(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 2);
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

			// Token: 0x1700043F RID: 1087
			// (get) Token: 0x06000B84 RID: 2948 RVA: 0x00026E08 File Offset: 0x00025008
			// (set) Token: 0x06000B85 RID: 2949 RVA: 0x00026E20 File Offset: 0x00025020
			public bool IsGeneric
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_29_0.NativeStructWrapper.TlFIJTPRZXCQPrpdL3V(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_89e7beae9a774fb691cacbb26b1d9330 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000440 RID: 1088
			// (get) Token: 0x06000B86 RID: 2950 RVA: 0x00026E84 File Offset: 0x00025084
			// (set) Token: 0x06000B87 RID: 2951 RVA: 0x00026E9C File Offset: 0x0002509C
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_29_0.NativeStructWrapper.HKD9LtP7440qSIRpler(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 8);
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
							NativeClassStructHandler_29_0.NativeStructWrapper.TlFIJTPRZXCQPrpdL3V(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 8, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bacedfb8a3cf4671ae3e03ec2f965495 == 0)
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

			// Token: 0x17000441 RID: 1089
			// (get) Token: 0x06000B88 RID: 2952 RVA: 0x00026F00 File Offset: 0x00025100
			// (set) Token: 0x06000B89 RID: 2953 RVA: 0x00026F18 File Offset: 0x00025118
			public bool HasFinalize
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 9);
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
							NativeClassStructHandler_29_0.NativeStructWrapper.TlFIJTPRZXCQPrpdL3V(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 9, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_650e65d7606047fda7d187c401bdfc6e != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000442 RID: 1090
			// (get) Token: 0x06000B8A RID: 2954 RVA: 0x00026F80 File Offset: 0x00025180
			// (set) Token: 0x06000B8B RID: 2955 RVA: 0x00026F98 File Offset: 0x00025198
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_29_0.NativeStructWrapper.HKD9LtP7440qSIRpler(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 13);
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
							NativeClassStructHandler_29_0.NativeStructWrapper.TlFIJTPRZXCQPrpdL3V(this, NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 13, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4e45528af4644e9b080e05d5ff6ef54 == 0)
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

			// Token: 0x17000443 RID: 1091
			// (get) Token: 0x06000B8C RID: 2956 RVA: 0x00027000 File Offset: 0x00025200
			// (set) Token: 0x06000B8D RID: 2957 RVA: 0x00027018 File Offset: 0x00025218
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
							this.SetBit(NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_37633ff27b934257920d0d03faf0bd54 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x06000B8E RID: 2958 RVA: 0x0002707C File Offset: 0x0002527C
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 4;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
					{
						IntPtr intPtr;
						NativeClassStructHandler_29_0.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_17522b2a3ddb488c87b7266d3b1f941d == 0)
						{
							num2 = 0;
						}
						break;
					}
					case 2:
						nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
						num2 = 5;
						break;
					case 3:
						hIDAYxH6DWLHIthQgC.oDuBOTgYK();
						num2 = 2;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc == 0)
						{
							num2 = 0;
						}
						break;
					case 4:
						NativeClassStructHandler_29_0.NativeStructWrapper.hHu77bPWN9jkMJ3dgnA();
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_37633ff27b934257920d0d03faf0bd54 == 0)
						{
							num2 = 3;
						}
						break;
					case 5:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_29_0.Il2CppClass_29_0>(hIDAYxH6DWLHIthQgC.gSCeTtiku(1253386989 << 6 ^ -1373801669 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9a3e85e731764e36a5b07f4e692becd8));
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7c2c0376e816400db5716cff194385b2 != 0)
						{
							num2 = 1;
						}
						break;
					}
					}
				}
			}

			// Token: 0x06000B8F RID: 2959 RVA: 0x00027194 File Offset: 0x00025394
			internal static void REvI7yP6qESw7R1q7Rp()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000B90 RID: 2960 RVA: 0x000271A4 File Offset: 0x000253A4
			internal static void dAbUlLPL3Znd9KfyGRR()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000B91 RID: 2961 RVA: 0x000271B4 File Offset: 0x000253B4
			internal static bool toff80PEwFjqjnFfFwF()
			{
				return NativeClassStructHandler_29_0.NativeStructWrapper.NIEcKlPuosWm7vpeeVn == null;
			}

			// Token: 0x06000B92 RID: 2962 RVA: 0x000271C8 File Offset: 0x000253C8
			internal static NativeClassStructHandler_29_0.NativeStructWrapper rVjN1sPc1okaqC5CZtN()
			{
				return NativeClassStructHandler_29_0.NativeStructWrapper.NIEcKlPuosWm7vpeeVn;
			}

			// Token: 0x06000B93 RID: 2963 RVA: 0x000271D8 File Offset: 0x000253D8
			internal static bool HKD9LtP7440qSIRpler(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000B94 RID: 2964 RVA: 0x000271F4 File Offset: 0x000253F4
			internal static void TlFIJTPRZXCQPrpdL3V(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000B95 RID: 2965 RVA: 0x00027214 File Offset: 0x00025414
			internal static IntPtr Xd0vUoPkHHxkGJbBoFp(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x06000B96 RID: 2966 RVA: 0x00027230 File Offset: 0x00025430
			internal static bool XYGIxkPJyBA49kvGVlM(object A_0)
			{
				return ((INativeTypeStruct)A_0).ValueType;
			}

			// Token: 0x06000B97 RID: 2967 RVA: 0x00027244 File Offset: 0x00025444
			internal static void hHu77bPWN9jkMJ3dgnA()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x040008CB RID: 2251
			private static readonly int _bitfield0offset;

			// Token: 0x040008CD RID: 2253
			internal static object NIEcKlPuosWm7vpeeVn;
		}
	}
}
