using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x02000103 RID: 259
	[ApplicableToUnityVersionsSince("2022.2.0")]
	public class NativeClassStructHandler_29_1 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000B75 RID: 2933 RVA: 0x000120DC File Offset: 0x000102DC
		public int Size()
		{
			return sizeof(NativeClassStructHandler_29_1.Il2CppClass_29_1);
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x000120EC File Offset: 0x000102EC
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_29_1.Il2CppClass_29_1* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_29_1.aAd5wJJctsyug2CpQbA(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_29_1.Il2CppClass_29_1);
			return new NativeClassStructHandler_29_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00012124 File Offset: 0x00010324
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3e2009ed69c04f5799431b4e58cafb2a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeClassStructHandler_29_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0001218C File Offset: 0x0001038C
		public NativeClassStructHandler_29_1()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeClassStructHandler_29_1.Y9ZQA3JkIBOHOmSdorc();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x000121F0 File Offset: 0x000103F0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_29_1()
		{
			NativeClassStructHandler_29_1.inWllyJ2thhw8SmOb95();
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00012200 File Offset: 0x00010400
		internal static IntPtr aAd5wJJctsyug2CpQbA(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00012214 File Offset: 0x00010414
		internal static bool J1PZ9nJLvKZEYCq5uIp()
		{
			return NativeClassStructHandler_29_1.HsS9A4JAEClraYuEyVT == null;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00012228 File Offset: 0x00010428
		internal static NativeClassStructHandler_29_1 EdbFXTJXeI8J0SV7ToA()
		{
			return NativeClassStructHandler_29_1.HsS9A4JAEClraYuEyVT;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00012238 File Offset: 0x00010438
		internal static void Y9ZQA3JkIBOHOmSdorc()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00012248 File Offset: 0x00010448
		internal static void inWllyJ2thhw8SmOb95()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040008C3 RID: 2243
		internal static NativeClassStructHandler_29_1 HsS9A4JAEClraYuEyVT;

		// Token: 0x02000104 RID: 260
		internal struct Il2CppClass_29_1
		{
			// Token: 0x040008C4 RID: 2244
			public unsafe Il2CppImage* image;

			// Token: 0x040008C5 RID: 2245
			public unsafe void* gc_desc;

			// Token: 0x040008C6 RID: 2246
			public unsafe byte* name;

			// Token: 0x040008C7 RID: 2247
			public unsafe byte* namespaze;

			// Token: 0x040008C8 RID: 2248
			public NativeTypeStructHandler_27_0.Il2CppType_27_0 byval_arg;

			// Token: 0x040008C9 RID: 2249
			public NativeTypeStructHandler_27_0.Il2CppType_27_0 this_arg;

			// Token: 0x040008CA RID: 2250
			public unsafe Il2CppClass* element_class;

			// Token: 0x040008CB RID: 2251
			public unsafe Il2CppClass* castClass;

			// Token: 0x040008CC RID: 2252
			public unsafe Il2CppClass* declaringType;

			// Token: 0x040008CD RID: 2253
			public unsafe Il2CppClass* parent;

			// Token: 0x040008CE RID: 2254
			public unsafe void* generic_class;

			// Token: 0x040008CF RID: 2255
			public Il2CppMetadataTypeHandle typeMetadataHandle;

			// Token: 0x040008D0 RID: 2256
			public unsafe void* interopData;

			// Token: 0x040008D1 RID: 2257
			public unsafe Il2CppClass* klass;

			// Token: 0x040008D2 RID: 2258
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x040008D3 RID: 2259
			public unsafe Il2CppEventInfo* events;

			// Token: 0x040008D4 RID: 2260
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x040008D5 RID: 2261
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x040008D6 RID: 2262
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x040008D7 RID: 2263
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x040008D8 RID: 2264
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x040008D9 RID: 2265
			public unsafe void* static_fields;

			// Token: 0x040008DA RID: 2266
			public unsafe void* rgctx_data;

			// Token: 0x040008DB RID: 2267
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x040008DC RID: 2268
			public unsafe void* unity_user_data;

			// Token: 0x040008DD RID: 2269
			public uint initializationExceptionGCHandle;

			// Token: 0x040008DE RID: 2270
			public uint cctor_started;

			// Token: 0x040008DF RID: 2271
			public uint cctor_finished_or_no_cctor;

			// Token: 0x040008E0 RID: 2272
			public IntPtr cctor_thread;

			// Token: 0x040008E1 RID: 2273
			public Il2CppMetadataGenericContainerHandle genericContainerHandle;

			// Token: 0x040008E2 RID: 2274
			public uint instance_size;

			// Token: 0x040008E3 RID: 2275
			public uint stack_slot_size;

			// Token: 0x040008E4 RID: 2276
			public uint actualSize;

			// Token: 0x040008E5 RID: 2277
			public uint element_size;

			// Token: 0x040008E6 RID: 2278
			public int native_size;

			// Token: 0x040008E7 RID: 2279
			public uint static_fields_size;

			// Token: 0x040008E8 RID: 2280
			public uint thread_static_fields_size;

			// Token: 0x040008E9 RID: 2281
			public int thread_static_fields_offset;

			// Token: 0x040008EA RID: 2282
			public uint flags;

			// Token: 0x040008EB RID: 2283
			public uint token;

			// Token: 0x040008EC RID: 2284
			public ushort method_count;

			// Token: 0x040008ED RID: 2285
			public ushort property_count;

			// Token: 0x040008EE RID: 2286
			public ushort field_count;

			// Token: 0x040008EF RID: 2287
			public ushort event_count;

			// Token: 0x040008F0 RID: 2288
			public ushort nested_type_count;

			// Token: 0x040008F1 RID: 2289
			public ushort vtable_count;

			// Token: 0x040008F2 RID: 2290
			public ushort interfaces_count;

			// Token: 0x040008F3 RID: 2291
			public ushort interface_offsets_count;

			// Token: 0x040008F4 RID: 2292
			public byte typeHierarchyDepth;

			// Token: 0x040008F5 RID: 2293
			public byte genericRecursionDepth;

			// Token: 0x040008F6 RID: 2294
			public byte rank;

			// Token: 0x040008F7 RID: 2295
			public byte minimumAlignment;

			// Token: 0x040008F8 RID: 2296
			public byte packingSize;

			// Token: 0x040008F9 RID: 2297
			public NativeClassStructHandler_29_1.Il2CppClass_29_1.Bitfield0 _bitfield0;

			// Token: 0x02000105 RID: 261
			internal enum Bitfield0 : ushort
			{
				// Token: 0x040008FB RID: 2299
				BIT_initialized_and_no_error,
				// Token: 0x040008FC RID: 2300
				initialized_and_no_error,
				// Token: 0x040008FD RID: 2301
				BIT_initialized = 1,
				// Token: 0x040008FE RID: 2302
				initialized,
				// Token: 0x040008FF RID: 2303
				BIT_enumtype = 2,
				// Token: 0x04000900 RID: 2304
				enumtype = 4,
				// Token: 0x04000901 RID: 2305
				BIT_nullabletype = 3,
				// Token: 0x04000902 RID: 2306
				nullabletype = 8,
				// Token: 0x04000903 RID: 2307
				BIT_is_generic = 4,
				// Token: 0x04000904 RID: 2308
				is_generic = 16,
				// Token: 0x04000905 RID: 2309
				BIT_has_references = 5,
				// Token: 0x04000906 RID: 2310
				has_references = 32,
				// Token: 0x04000907 RID: 2311
				BIT_init_pending = 6,
				// Token: 0x04000908 RID: 2312
				init_pending = 64,
				// Token: 0x04000909 RID: 2313
				BIT_size_init_pending = 7,
				// Token: 0x0400090A RID: 2314
				size_init_pending = 128,
				// Token: 0x0400090B RID: 2315
				BIT_size_inited = 8,
				// Token: 0x0400090C RID: 2316
				size_inited = 256,
				// Token: 0x0400090D RID: 2317
				BIT_has_finalize = 9,
				// Token: 0x0400090E RID: 2318
				has_finalize = 512,
				// Token: 0x0400090F RID: 2319
				BIT_has_cctor = 10,
				// Token: 0x04000910 RID: 2320
				has_cctor = 1024,
				// Token: 0x04000911 RID: 2321
				BIT_is_blittable = 11,
				// Token: 0x04000912 RID: 2322
				is_blittable = 2048,
				// Token: 0x04000913 RID: 2323
				BIT_is_import_or_windows_runtime = 12,
				// Token: 0x04000914 RID: 2324
				is_import_or_windows_runtime = 4096,
				// Token: 0x04000915 RID: 2325
				BIT_is_vtable_initialized = 13,
				// Token: 0x04000916 RID: 2326
				is_vtable_initialized = 8192,
				// Token: 0x04000917 RID: 2327
				BIT_is_byref_like = 14,
				// Token: 0x04000918 RID: 2328
				is_byref_like = 16384
			}
		}

		// Token: 0x02000106 RID: 262
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000B7F RID: 2943 RVA: 0x000265A0 File Offset: 0x000247A0
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_29_1.NativeStructWrapper.zHML1q4LtTZhxZvAqQy();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b9b6cd6cbc040a7be58cff054f9e843 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_15379a47ca764a4e8e16ceaf4804e136 == 0)
						{
							num = 0;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x17000444 RID: 1092
			// (get) Token: 0x06000B80 RID: 2944 RVA: 0x00026630 File Offset: 0x00024830
			private unsafe NativeClassStructHandler_29_1.Il2CppClass_29_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000445 RID: 1093
			// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00026640 File Offset: 0x00024840
			// (set) Token: 0x06000B82 RID: 2946 RVA: 0x00026658 File Offset: 0x00024858
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_29_1.NativeStructWrapper.JY3E2g4XsD8iUxSaMX7(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 5);
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
							NativeClassStructHandler_29_1.NativeStructWrapper.gMy2o74c01bMwtVMZKZ(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 5, value);
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

			// Token: 0x17000446 RID: 1094
			// (get) Token: 0x06000B83 RID: 2947 RVA: 0x000266BC File Offset: 0x000248BC
			public IntPtr Pointer { get; }

			// Token: 0x17000447 RID: 1095
			// (get) Token: 0x06000B84 RID: 2948 RVA: 0x000266CC File Offset: 0x000248CC
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_29_1.NativeStructWrapper.Qm25qg4kwBQAu80pSaR(this.Pointer, sizeof(NativeClassStructHandler_29_1.Il2CppClass_29_1), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x17000448 RID: 1096
			// (get) Token: 0x06000B85 RID: 2949 RVA: 0x000266EC File Offset: 0x000248EC
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000449 RID: 1097
			// (get) Token: 0x06000B86 RID: 2950 RVA: 0x000266FC File Offset: 0x000248FC
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x1700044A RID: 1098
			// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00026718 File Offset: 0x00024918
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x1700044B RID: 1099
			// (get) Token: 0x06000B88 RID: 2952 RVA: 0x00026734 File Offset: 0x00024934
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x1700044C RID: 1100
			// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00026748 File Offset: 0x00024948
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x1700044D RID: 1101
			// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0002675C File Offset: 0x0002495C
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x1700044E RID: 1102
			// (get) Token: 0x06000B8B RID: 2955 RVA: 0x00026770 File Offset: 0x00024970
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x1700044F RID: 1103
			// (get) Token: 0x06000B8C RID: 2956 RVA: 0x00026784 File Offset: 0x00024984
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x17000450 RID: 1104
			// (get) Token: 0x06000B8D RID: 2957 RVA: 0x00026798 File Offset: 0x00024998
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x17000451 RID: 1105
			// (get) Token: 0x06000B8E RID: 2958 RVA: 0x000267AC File Offset: 0x000249AC
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x17000452 RID: 1106
			// (get) Token: 0x06000B8F RID: 2959 RVA: 0x000267C0 File Offset: 0x000249C0
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x17000453 RID: 1107
			// (get) Token: 0x06000B90 RID: 2960 RVA: 0x000267D4 File Offset: 0x000249D4
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x17000454 RID: 1108
			// (get) Token: 0x06000B91 RID: 2961 RVA: 0x000267E8 File Offset: 0x000249E8
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x17000455 RID: 1109
			// (get) Token: 0x06000B92 RID: 2962 RVA: 0x00026800 File Offset: 0x00024A00
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000456 RID: 1110
			// (get) Token: 0x06000B93 RID: 2963 RVA: 0x00026818 File Offset: 0x00024A18
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x17000457 RID: 1111
			// (get) Token: 0x06000B94 RID: 2964 RVA: 0x00026830 File Offset: 0x00024A30
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x17000458 RID: 1112
			// (get) Token: 0x06000B95 RID: 2965 RVA: 0x00026844 File Offset: 0x00024A44
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000459 RID: 1113
			// (get) Token: 0x06000B96 RID: 2966 RVA: 0x00026858 File Offset: 0x00024A58
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x1700045A RID: 1114
			// (get) Token: 0x06000B97 RID: 2967 RVA: 0x0002686C File Offset: 0x00024A6C
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x1700045B RID: 1115
			// (get) Token: 0x06000B98 RID: 2968 RVA: 0x00026880 File Offset: 0x00024A80
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x1700045C RID: 1116
			// (get) Token: 0x06000B99 RID: 2969 RVA: 0x00026894 File Offset: 0x00024A94
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x1700045D RID: 1117
			// (get) Token: 0x06000B9A RID: 2970 RVA: 0x000268A8 File Offset: 0x00024AA8
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x1700045E RID: 1118
			// (get) Token: 0x06000B9B RID: 2971 RVA: 0x000268BC File Offset: 0x00024ABC
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x1700045F RID: 1119
			// (get) Token: 0x06000B9C RID: 2972 RVA: 0x000268D0 File Offset: 0x00024AD0
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x17000460 RID: 1120
			// (get) Token: 0x06000B9D RID: 2973 RVA: 0x000268E4 File Offset: 0x00024AE4
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x17000461 RID: 1121
			// (get) Token: 0x06000B9E RID: 2974 RVA: 0x000268F8 File Offset: 0x00024AF8
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x17000462 RID: 1122
			// (get) Token: 0x06000B9F RID: 2975 RVA: 0x0002690C File Offset: 0x00024B0C
			// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x000269A8 File Offset: 0x00024BA8
			public bool ValueType
			{
				get
				{
					int num = 2;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							return false;
						case 2:
							if (!NativeClassStructHandler_29_1.NativeStructWrapper.KZbmO242KExFVInBjrF(this.ByValArg))
							{
								num2 = 1;
								if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_1f1b1b07c9f5435991b0738ea3210852 != 0)
								{
									num2 = 1;
									continue;
								}
								continue;
							}
							break;
						}
						break;
					}
					return NativeClassStructHandler_29_1.NativeStructWrapper.KZbmO242KExFVInBjrF(this.ThisArg);
				}
				set
				{
				}
			}

			// Token: 0x17000463 RID: 1123
			// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x000269B4 File Offset: 0x00024BB4
			// (set) Token: 0x06000BA2 RID: 2978 RVA: 0x000269CC File Offset: 0x00024BCC
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_29_1.NativeStructWrapper.JY3E2g4XsD8iUxSaMX7(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 1);
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
							this.SetBit(NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_be7c67937fc746d2ad6f8cd47b555de7 == 0)
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

			// Token: 0x17000464 RID: 1124
			// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00026A30 File Offset: 0x00024C30
			// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x00026A48 File Offset: 0x00024C48
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_29_1.NativeStructWrapper.JY3E2g4XsD8iUxSaMX7(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 2);
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
							this.SetBit(NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7b01772eb8964b6a81d74c3d1c2f871e == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000465 RID: 1125
			// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x00026AAC File Offset: 0x00024CAC
			// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x00026AC4 File Offset: 0x00024CC4
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_29_1.NativeStructWrapper.JY3E2g4XsD8iUxSaMX7(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 4);
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
							this.SetBit(NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6fe1694df7b94e7bbaa2aab21c6a82ec == 0)
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

			// Token: 0x17000466 RID: 1126
			// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x00026B28 File Offset: 0x00024D28
			// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x00026B40 File Offset: 0x00024D40
			public bool SizeInited
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 8);
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
							this.SetBit(NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 8, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ecb3ec1520014011821df145fb87d517 == 0)
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

			// Token: 0x17000467 RID: 1127
			// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x00026BA4 File Offset: 0x00024DA4
			// (set) Token: 0x06000BAA RID: 2986 RVA: 0x00026BBC File Offset: 0x00024DBC
			public bool HasFinalize
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 9);
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
							NativeClassStructHandler_29_1.NativeStructWrapper.gMy2o74c01bMwtVMZKZ(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 9, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eeb967463afe407d8f7c3b354043704c != 0)
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

			// Token: 0x17000468 RID: 1128
			// (get) Token: 0x06000BAB RID: 2987 RVA: 0x00026C24 File Offset: 0x00024E24
			// (set) Token: 0x06000BAC RID: 2988 RVA: 0x00026C3C File Offset: 0x00024E3C
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_29_1.NativeStructWrapper.JY3E2g4XsD8iUxSaMX7(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 13);
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
							NativeClassStructHandler_29_1.NativeStructWrapper.gMy2o74c01bMwtVMZKZ(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 13, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_15379a47ca764a4e8e16ceaf4804e136 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000469 RID: 1129
			// (get) Token: 0x06000BAD RID: 2989 RVA: 0x00026CA4 File Offset: 0x00024EA4
			// (set) Token: 0x06000BAE RID: 2990 RVA: 0x00026CBC File Offset: 0x00024EBC
			public bool InitializedAndNoError
			{
				get
				{
					return NativeClassStructHandler_29_1.NativeStructWrapper.JY3E2g4XsD8iUxSaMX7(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_29_1.NativeStructWrapper.gMy2o74c01bMwtVMZKZ(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_be7c67937fc746d2ad6f8cd47b555de7 == 0)
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

			// Token: 0x06000BAF RID: 2991 RVA: 0x00026D20 File Offset: 0x00024F20
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 3;
				int num2 = num;
				for (;;)
				{
					IntPtr intPtr;
					switch (num2)
					{
					case 1:
						return;
					case 2:
						NativeClassStructHandler_29_1.NativeStructWrapper.zHML1q4LtTZhxZvAqQy();
						num2 = 4;
						continue;
					case 3:
						NativeClassStructHandler_29_1.NativeStructWrapper.wFh2k94HILhWQuABH10();
						num2 = 2;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c26b4d3619a4457fb4121e194d9ef286 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						nHwRpygmi6xxZAssJn.EmlEpH4Phw();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b3f20ce588d04b909ddcdcdf767eb5d4 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2adb3ca441e493aba80425bcc0f1db3 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					intPtr = Marshal.OffsetOf<NativeClassStructHandler_29_1.Il2CppClass_29_1>(NativeClassStructHandler_29_1.NativeStructWrapper.Bvrri44hF25YJl0nWHy(1365795018 ^ 637511482 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8378a46aa7ed47018832a42729b1bc3b));
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6a95c50bbb48420f8f11bb090d6d3bd5 == 0)
					{
						num2 = 5;
					}
				}
			}

			// Token: 0x06000BB0 RID: 2992 RVA: 0x00026E30 File Offset: 0x00025030
			internal static void zHML1q4LtTZhxZvAqQy()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000BB1 RID: 2993 RVA: 0x00026E40 File Offset: 0x00025040
			internal static bool E31hRZ45F2JRgo7nmJK()
			{
				return NativeClassStructHandler_29_1.NativeStructWrapper.CGoNrv4qsM8UypIFnGw == null;
			}

			// Token: 0x06000BB2 RID: 2994 RVA: 0x00026E54 File Offset: 0x00025054
			internal static NativeClassStructHandler_29_1.NativeStructWrapper GxHxgh4A5OE0Sa3VT6U()
			{
				return NativeClassStructHandler_29_1.NativeStructWrapper.CGoNrv4qsM8UypIFnGw;
			}

			// Token: 0x06000BB3 RID: 2995 RVA: 0x00026E64 File Offset: 0x00025064
			internal static bool JY3E2g4XsD8iUxSaMX7(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000BB4 RID: 2996 RVA: 0x00026E80 File Offset: 0x00025080
			internal static void gMy2o74c01bMwtVMZKZ(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000BB5 RID: 2997 RVA: 0x00026EA0 File Offset: 0x000250A0
			internal static IntPtr Qm25qg4kwBQAu80pSaR(IntPtr A_0, int A_1, object A_2)
			{
				return apS1BFcfBa3gXUspL9j.muOq5LWqgj(A_0, A_1, A_2);
			}

			// Token: 0x06000BB6 RID: 2998 RVA: 0x00026EBC File Offset: 0x000250BC
			internal static bool KZbmO242KExFVInBjrF(object A_0)
			{
				return ((INativeTypeStruct)A_0).ValueType;
			}

			// Token: 0x06000BB7 RID: 2999 RVA: 0x00026ED0 File Offset: 0x000250D0
			internal static void wFh2k94HILhWQuABH10()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000BB8 RID: 3000 RVA: 0x00026EE0 File Offset: 0x000250E0
			internal static object Bvrri44hF25YJl0nWHy(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000919 RID: 2329
			private static readonly int _bitfield0offset;

			// Token: 0x0400091B RID: 2331
			internal static object CGoNrv4qsM8UypIFnGw;
		}
	}
}
