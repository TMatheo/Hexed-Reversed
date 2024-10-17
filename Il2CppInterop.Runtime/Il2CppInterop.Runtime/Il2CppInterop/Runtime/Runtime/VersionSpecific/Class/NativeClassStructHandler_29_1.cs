using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x02000105 RID: 261
	[ApplicableToUnityVersionsSince("2022.2.0")]
	public class NativeClassStructHandler_29_1 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000B98 RID: 2968 RVA: 0x00012D28 File Offset: 0x00010F28
		public int Size()
		{
			return sizeof(NativeClassStructHandler_29_1.Il2CppClass_29_1);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00012D38 File Offset: 0x00010F38
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_29_1.Il2CppClass_29_1* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_29_1.HtyVEWLo4Y7JAD8Lvma(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_29_1.Il2CppClass_29_1);
			return new NativeClassStructHandler_29_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00012D70 File Offset: 0x00010F70
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7f5f35a413414ac0b2dfa27f953f90e9 == 0)
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

		// Token: 0x06000B9B RID: 2971 RVA: 0x00012DD8 File Offset: 0x00010FD8
		public NativeClassStructHandler_29_1()
		{
			NativeClassStructHandler_29_1.NlCpFYLbPGnMYNKGW8b();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ea3a0368554c4e6093e0b0561ffd5cef == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00012E3C File Offset: 0x0001103C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_29_1()
		{
			NativeClassStructHandler_29_1.KJXloYLfZGD9b72N056();
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00012E4C File Offset: 0x0001104C
		internal static IntPtr HtyVEWLo4Y7JAD8Lvma(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00012E60 File Offset: 0x00011060
		internal static bool qkCFG8LDp1vTv895NTm()
		{
			return NativeClassStructHandler_29_1.UNnOKcLrPS14uEMSIfA == null;
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00012E74 File Offset: 0x00011074
		internal static NativeClassStructHandler_29_1 NO6webLZAnPnkayfasy()
		{
			return NativeClassStructHandler_29_1.UNnOKcLrPS14uEMSIfA;
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00012E84 File Offset: 0x00011084
		internal static void NlCpFYLbPGnMYNKGW8b()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00012E94 File Offset: 0x00011094
		internal static void KJXloYLfZGD9b72N056()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040008CE RID: 2254
		internal static NativeClassStructHandler_29_1 UNnOKcLrPS14uEMSIfA;

		// Token: 0x02000106 RID: 262
		internal struct Il2CppClass_29_1
		{
			// Token: 0x040008CF RID: 2255
			public unsafe Il2CppImage* image;

			// Token: 0x040008D0 RID: 2256
			public unsafe void* gc_desc;

			// Token: 0x040008D1 RID: 2257
			public unsafe byte* name;

			// Token: 0x040008D2 RID: 2258
			public unsafe byte* namespaze;

			// Token: 0x040008D3 RID: 2259
			public NativeTypeStructHandler_27_0.Il2CppType_27_0 byval_arg;

			// Token: 0x040008D4 RID: 2260
			public NativeTypeStructHandler_27_0.Il2CppType_27_0 this_arg;

			// Token: 0x040008D5 RID: 2261
			public unsafe Il2CppClass* element_class;

			// Token: 0x040008D6 RID: 2262
			public unsafe Il2CppClass* castClass;

			// Token: 0x040008D7 RID: 2263
			public unsafe Il2CppClass* declaringType;

			// Token: 0x040008D8 RID: 2264
			public unsafe Il2CppClass* parent;

			// Token: 0x040008D9 RID: 2265
			public unsafe void* generic_class;

			// Token: 0x040008DA RID: 2266
			public Il2CppMetadataTypeHandle typeMetadataHandle;

			// Token: 0x040008DB RID: 2267
			public unsafe void* interopData;

			// Token: 0x040008DC RID: 2268
			public unsafe Il2CppClass* klass;

			// Token: 0x040008DD RID: 2269
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x040008DE RID: 2270
			public unsafe Il2CppEventInfo* events;

			// Token: 0x040008DF RID: 2271
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x040008E0 RID: 2272
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x040008E1 RID: 2273
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x040008E2 RID: 2274
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x040008E3 RID: 2275
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x040008E4 RID: 2276
			public unsafe void* static_fields;

			// Token: 0x040008E5 RID: 2277
			public unsafe void* rgctx_data;

			// Token: 0x040008E6 RID: 2278
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x040008E7 RID: 2279
			public unsafe void* unity_user_data;

			// Token: 0x040008E8 RID: 2280
			public uint initializationExceptionGCHandle;

			// Token: 0x040008E9 RID: 2281
			public uint cctor_started;

			// Token: 0x040008EA RID: 2282
			public uint cctor_finished_or_no_cctor;

			// Token: 0x040008EB RID: 2283
			public IntPtr cctor_thread;

			// Token: 0x040008EC RID: 2284
			public Il2CppMetadataGenericContainerHandle genericContainerHandle;

			// Token: 0x040008ED RID: 2285
			public uint instance_size;

			// Token: 0x040008EE RID: 2286
			public uint stack_slot_size;

			// Token: 0x040008EF RID: 2287
			public uint actualSize;

			// Token: 0x040008F0 RID: 2288
			public uint element_size;

			// Token: 0x040008F1 RID: 2289
			public int native_size;

			// Token: 0x040008F2 RID: 2290
			public uint static_fields_size;

			// Token: 0x040008F3 RID: 2291
			public uint thread_static_fields_size;

			// Token: 0x040008F4 RID: 2292
			public int thread_static_fields_offset;

			// Token: 0x040008F5 RID: 2293
			public uint flags;

			// Token: 0x040008F6 RID: 2294
			public uint token;

			// Token: 0x040008F7 RID: 2295
			public ushort method_count;

			// Token: 0x040008F8 RID: 2296
			public ushort property_count;

			// Token: 0x040008F9 RID: 2297
			public ushort field_count;

			// Token: 0x040008FA RID: 2298
			public ushort event_count;

			// Token: 0x040008FB RID: 2299
			public ushort nested_type_count;

			// Token: 0x040008FC RID: 2300
			public ushort vtable_count;

			// Token: 0x040008FD RID: 2301
			public ushort interfaces_count;

			// Token: 0x040008FE RID: 2302
			public ushort interface_offsets_count;

			// Token: 0x040008FF RID: 2303
			public byte typeHierarchyDepth;

			// Token: 0x04000900 RID: 2304
			public byte genericRecursionDepth;

			// Token: 0x04000901 RID: 2305
			public byte rank;

			// Token: 0x04000902 RID: 2306
			public byte minimumAlignment;

			// Token: 0x04000903 RID: 2307
			public byte packingSize;

			// Token: 0x04000904 RID: 2308
			public NativeClassStructHandler_29_1.Il2CppClass_29_1.Bitfield0 _bitfield0;

			// Token: 0x02000107 RID: 263
			internal enum Bitfield0 : ushort
			{
				// Token: 0x04000906 RID: 2310
				BIT_initialized_and_no_error,
				// Token: 0x04000907 RID: 2311
				initialized_and_no_error,
				// Token: 0x04000908 RID: 2312
				BIT_initialized = 1,
				// Token: 0x04000909 RID: 2313
				initialized,
				// Token: 0x0400090A RID: 2314
				BIT_enumtype = 2,
				// Token: 0x0400090B RID: 2315
				enumtype = 4,
				// Token: 0x0400090C RID: 2316
				BIT_nullabletype = 3,
				// Token: 0x0400090D RID: 2317
				nullabletype = 8,
				// Token: 0x0400090E RID: 2318
				BIT_is_generic = 4,
				// Token: 0x0400090F RID: 2319
				is_generic = 16,
				// Token: 0x04000910 RID: 2320
				BIT_has_references = 5,
				// Token: 0x04000911 RID: 2321
				has_references = 32,
				// Token: 0x04000912 RID: 2322
				BIT_init_pending = 6,
				// Token: 0x04000913 RID: 2323
				init_pending = 64,
				// Token: 0x04000914 RID: 2324
				BIT_size_init_pending = 7,
				// Token: 0x04000915 RID: 2325
				size_init_pending = 128,
				// Token: 0x04000916 RID: 2326
				BIT_size_inited = 8,
				// Token: 0x04000917 RID: 2327
				size_inited = 256,
				// Token: 0x04000918 RID: 2328
				BIT_has_finalize = 9,
				// Token: 0x04000919 RID: 2329
				has_finalize = 512,
				// Token: 0x0400091A RID: 2330
				BIT_has_cctor = 10,
				// Token: 0x0400091B RID: 2331
				has_cctor = 1024,
				// Token: 0x0400091C RID: 2332
				BIT_is_blittable = 11,
				// Token: 0x0400091D RID: 2333
				is_blittable = 2048,
				// Token: 0x0400091E RID: 2334
				BIT_is_import_or_windows_runtime = 12,
				// Token: 0x0400091F RID: 2335
				is_import_or_windows_runtime = 4096,
				// Token: 0x04000920 RID: 2336
				BIT_is_vtable_initialized = 13,
				// Token: 0x04000921 RID: 2337
				is_vtable_initialized = 8192,
				// Token: 0x04000922 RID: 2338
				BIT_is_byref_like = 14,
				// Token: 0x04000923 RID: 2339
				is_byref_like = 16384
			}
		}

		// Token: 0x02000108 RID: 264
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000BA2 RID: 2978 RVA: 0x00027254 File Offset: 0x00025454
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_29_1.NativeStructWrapper.mEgDkkPPn3SZCeUvvOr();
				NativeClassStructHandler_29_1.NativeStructWrapper.r0mIYKPdPuiclXB1aTl();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_18558c8f0d4f4774910664df1c51bd49 == 0)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_39f2b5d6802b4ad087933b982faeb79d != 0)
					{
						num = 0;
					}
				}
			}

			// Token: 0x17000444 RID: 1092
			// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x000272E4 File Offset: 0x000254E4
			private unsafe NativeClassStructHandler_29_1.Il2CppClass_29_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000445 RID: 1093
			// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x000272F4 File Offset: 0x000254F4
			// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x0002730C File Offset: 0x0002550C
			public bool HasReferences
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 5);
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
							NativeClassStructHandler_29_1.NativeStructWrapper.IcQqbDPw38jhy8whVEt(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 5, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6e39fb1a8feb46889b60abcfbb34e0df == 0)
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

			// Token: 0x17000446 RID: 1094
			// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x00027370 File Offset: 0x00025570
			public IntPtr Pointer { get; }

			// Token: 0x17000447 RID: 1095
			// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x00027380 File Offset: 0x00025580
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_29_1.NativeStructWrapper.NR6QacPeTDcBHqa5i2a(this.Pointer, sizeof(NativeClassStructHandler_29_1.Il2CppClass_29_1), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x17000448 RID: 1096
			// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x000273A0 File Offset: 0x000255A0
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000449 RID: 1097
			// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x000273B0 File Offset: 0x000255B0
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x1700044A RID: 1098
			// (get) Token: 0x06000BAA RID: 2986 RVA: 0x000273CC File Offset: 0x000255CC
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x1700044B RID: 1099
			// (get) Token: 0x06000BAB RID: 2987 RVA: 0x000273E8 File Offset: 0x000255E8
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x1700044C RID: 1100
			// (get) Token: 0x06000BAC RID: 2988 RVA: 0x000273FC File Offset: 0x000255FC
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x1700044D RID: 1101
			// (get) Token: 0x06000BAD RID: 2989 RVA: 0x00027410 File Offset: 0x00025610
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x1700044E RID: 1102
			// (get) Token: 0x06000BAE RID: 2990 RVA: 0x00027424 File Offset: 0x00025624
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x1700044F RID: 1103
			// (get) Token: 0x06000BAF RID: 2991 RVA: 0x00027438 File Offset: 0x00025638
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x17000450 RID: 1104
			// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x0002744C File Offset: 0x0002564C
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x17000451 RID: 1105
			// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00027460 File Offset: 0x00025660
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x17000452 RID: 1106
			// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x00027474 File Offset: 0x00025674
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x17000453 RID: 1107
			// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x00027488 File Offset: 0x00025688
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x17000454 RID: 1108
			// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0002749C File Offset: 0x0002569C
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x17000455 RID: 1109
			// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x000274B4 File Offset: 0x000256B4
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000456 RID: 1110
			// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x000274CC File Offset: 0x000256CC
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x17000457 RID: 1111
			// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x000274E4 File Offset: 0x000256E4
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x17000458 RID: 1112
			// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x000274F8 File Offset: 0x000256F8
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000459 RID: 1113
			// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x0002750C File Offset: 0x0002570C
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x1700045A RID: 1114
			// (get) Token: 0x06000BBA RID: 3002 RVA: 0x00027520 File Offset: 0x00025720
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x1700045B RID: 1115
			// (get) Token: 0x06000BBB RID: 3003 RVA: 0x00027534 File Offset: 0x00025734
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x1700045C RID: 1116
			// (get) Token: 0x06000BBC RID: 3004 RVA: 0x00027548 File Offset: 0x00025748
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x1700045D RID: 1117
			// (get) Token: 0x06000BBD RID: 3005 RVA: 0x0002755C File Offset: 0x0002575C
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x1700045E RID: 1118
			// (get) Token: 0x06000BBE RID: 3006 RVA: 0x00027570 File Offset: 0x00025770
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x1700045F RID: 1119
			// (get) Token: 0x06000BBF RID: 3007 RVA: 0x00027584 File Offset: 0x00025784
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x17000460 RID: 1120
			// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x00027598 File Offset: 0x00025798
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x17000461 RID: 1121
			// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x000275AC File Offset: 0x000257AC
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x17000462 RID: 1122
			// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x000275C0 File Offset: 0x000257C0
			// (set) Token: 0x06000BC3 RID: 3011 RVA: 0x00027634 File Offset: 0x00025834
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
							if (!NativeClassStructHandler_29_1.NativeStructWrapper.mm2sP8Ps4Jrrc9ssQHv(this.ByValArg))
							{
								return false;
							}
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9cbee6d56f49422699718938ff979567 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
					return NativeClassStructHandler_29_1.NativeStructWrapper.mm2sP8Ps4Jrrc9ssQHv(this.ThisArg);
				}
				set
				{
				}
			}

			// Token: 0x17000463 RID: 1123
			// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x00027640 File Offset: 0x00025840
			// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x00027658 File Offset: 0x00025858
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_29_1.NativeStructWrapper.JEWqgIPQG4nih8xuJXp(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_29_1.NativeStructWrapper.IcQqbDPw38jhy8whVEt(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f7e83c7c87bd4de9b4cb2b7f339254ad == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000464 RID: 1124
			// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x000276BC File Offset: 0x000258BC
			// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x000276D4 File Offset: 0x000258D4
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_29_1.NativeStructWrapper.JEWqgIPQG4nih8xuJXp(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_29_1.NativeStructWrapper.IcQqbDPw38jhy8whVEt(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5d181dabf1ed42eca63023d24d927754 != 0)
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

			// Token: 0x17000465 RID: 1125
			// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x00027738 File Offset: 0x00025938
			// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x00027750 File Offset: 0x00025950
			public bool IsGeneric
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_29_1.NativeStructWrapper.IcQqbDPw38jhy8whVEt(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 4, value);
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

			// Token: 0x17000466 RID: 1126
			// (get) Token: 0x06000BCA RID: 3018 RVA: 0x000277B4 File Offset: 0x000259B4
			// (set) Token: 0x06000BCB RID: 3019 RVA: 0x000277CC File Offset: 0x000259CC
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_29_1.NativeStructWrapper.JEWqgIPQG4nih8xuJXp(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 8);
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
							NativeClassStructHandler_29_1.NativeStructWrapper.IcQqbDPw38jhy8whVEt(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 8, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_906545e343eb409d9eb685fc4a903234 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000467 RID: 1127
			// (get) Token: 0x06000BCC RID: 3020 RVA: 0x00027830 File Offset: 0x00025A30
			// (set) Token: 0x06000BCD RID: 3021 RVA: 0x00027848 File Offset: 0x00025A48
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
						default:
							return;
						case 1:
							NativeClassStructHandler_29_1.NativeStructWrapper.IcQqbDPw38jhy8whVEt(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 9, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ea3a0368554c4e6093e0b0561ffd5cef == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000468 RID: 1128
			// (get) Token: 0x06000BCE RID: 3022 RVA: 0x000278B0 File Offset: 0x00025AB0
			// (set) Token: 0x06000BCF RID: 3023 RVA: 0x000278C8 File Offset: 0x00025AC8
			public bool IsVtableInitialized
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 13);
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
							this.SetBit(NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 13, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ac98984015b94d6a931f8affda832ec9 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000469 RID: 1129
			// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x00027930 File Offset: 0x00025B30
			// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x00027948 File Offset: 0x00025B48
			public bool InitializedAndNoError
			{
				get
				{
					return NativeClassStructHandler_29_1.NativeStructWrapper.JEWqgIPQG4nih8xuJXp(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_29_1.NativeStructWrapper.IcQqbDPw38jhy8whVEt(this, NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f7e83c7c87bd4de9b4cb2b7f339254ad != 0)
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

			// Token: 0x06000BD2 RID: 3026 RVA: 0x000279AC File Offset: 0x00025BAC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					IntPtr intPtr;
					switch (num2)
					{
					case 1:
						NativeClassStructHandler_29_1.NativeStructWrapper.mEgDkkPPn3SZCeUvvOr();
						num2 = 3;
						continue;
					case 2:
						NativeClassStructHandler_29_1.NativeStructWrapper.LEJJQ2P2CgR5eu0Efk3();
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2210d7ca22c24335b32d80ca3ef84b8e == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						NativeClassStructHandler_29_1.NativeStructWrapper.r0mIYKPdPuiclXB1aTl();
						num2 = 4;
						continue;
					case 4:
						intPtr = Marshal.OffsetOf<NativeClassStructHandler_29_1.Il2CppClass_29_1>(NativeClassStructHandler_29_1.NativeStructWrapper.LRIZk8Py0O7jrstlR7O(~-726396172 ^ 667464332 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c504ab11ece64b14b01df2d4c88e6e49));
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2f48f5515514b5a9a5feed6dc9a8dce == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						return;
					}
					NativeClassStructHandler_29_1.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
					num2 = 5;
				}
			}

			// Token: 0x06000BD3 RID: 3027 RVA: 0x00027A94 File Offset: 0x00025C94
			internal static void mEgDkkPPn3SZCeUvvOr()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000BD4 RID: 3028 RVA: 0x00027AA4 File Offset: 0x00025CA4
			internal static void r0mIYKPdPuiclXB1aTl()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000BD5 RID: 3029 RVA: 0x00027AB4 File Offset: 0x00025CB4
			internal static bool LvARA7PbqAqA2kcQLL2()
			{
				return NativeClassStructHandler_29_1.NativeStructWrapper.RjC5ooPoXsp3hcbNIPU == null;
			}

			// Token: 0x06000BD6 RID: 3030 RVA: 0x00027AC8 File Offset: 0x00025CC8
			internal static NativeClassStructHandler_29_1.NativeStructWrapper kgeQegPfoqY1fpm4Pfi()
			{
				return NativeClassStructHandler_29_1.NativeStructWrapper.RjC5ooPoXsp3hcbNIPU;
			}

			// Token: 0x06000BD7 RID: 3031 RVA: 0x00027AD8 File Offset: 0x00025CD8
			internal static void IcQqbDPw38jhy8whVEt(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000BD8 RID: 3032 RVA: 0x00027AF8 File Offset: 0x00025CF8
			internal static IntPtr NR6QacPeTDcBHqa5i2a(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x06000BD9 RID: 3033 RVA: 0x00027B14 File Offset: 0x00025D14
			internal static bool mm2sP8Ps4Jrrc9ssQHv(object A_0)
			{
				return ((INativeTypeStruct)A_0).ValueType;
			}

			// Token: 0x06000BDA RID: 3034 RVA: 0x00027B28 File Offset: 0x00025D28
			internal static bool JEWqgIPQG4nih8xuJXp(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000BDB RID: 3035 RVA: 0x00027B44 File Offset: 0x00025D44
			internal static void LEJJQ2P2CgR5eu0Efk3()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000BDC RID: 3036 RVA: 0x00027B54 File Offset: 0x00025D54
			internal static object LRIZk8Py0O7jrstlR7O(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000924 RID: 2340
			private static readonly int _bitfield0offset;

			// Token: 0x04000926 RID: 2342
			internal static object RjC5ooPoXsp3hcbNIPU;
		}
	}
}
