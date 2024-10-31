using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000D3 RID: 211
	[ApplicableToUnityVersionsSince("5.5.1")]
	public class NativeClassStructHandler_22_1 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000849 RID: 2121 RVA: 0x00010EAC File Offset: 0x0000F0AC
		public int Size()
		{
			return sizeof(NativeClassStructHandler_22_1.Il2CppClass_22_1);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00010EBC File Offset: 0x0000F0BC
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_22_1.Il2CppClass_22_1* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_22_1.RZG3Sh6QPJkQpTKJhc7(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_22_1.Il2CppClass_22_1);
			ptr2->byval_arg = UnityVersionHandler.NewType().TypePointer;
			ptr2->this_arg = ((INativeTypeStruct)NativeClassStructHandler_22_1.PcYqH56eXkWeFq34G8I()).TypePointer;
			return new NativeClassStructHandler_22_1.NativeStructWrapper(ptr);
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00010F18 File Offset: 0x0000F118
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b55404cff7864ea3949f7b4156fd6ee5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeClassStructHandler_22_1.NativeStructWrapper(ptr);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00010F80 File Offset: 0x0000F180
		public NativeClassStructHandler_22_1()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6e0b93a59f7244c4b07385ec95383bee != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00010FE4 File Offset: 0x0000F1E4
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_22_1()
		{
			NativeClassStructHandler_22_1.feVFdC6K8H2UDYGthgZ();
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00010FF4 File Offset: 0x0000F1F4
		internal static IntPtr RZG3Sh6QPJkQpTKJhc7(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00011008 File Offset: 0x0000F208
		internal static object PcYqH56eXkWeFq34G8I()
		{
			return UnityVersionHandler.NewType();
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00011018 File Offset: 0x0000F218
		internal static bool V8skfH6UabqhmlNO6R1()
		{
			return NativeClassStructHandler_22_1.Krveqf6owmMVCdTEUvP == null;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0001102C File Offset: 0x0000F22C
		internal static NativeClassStructHandler_22_1 Hy88Cf6jrTABoD4yLdA()
		{
			return NativeClassStructHandler_22_1.Krveqf6owmMVCdTEUvP;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0001103C File Offset: 0x0000F23C
		internal static void feVFdC6K8H2UDYGthgZ()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040004C6 RID: 1222
		internal static NativeClassStructHandler_22_1 Krveqf6owmMVCdTEUvP;

		// Token: 0x020000D4 RID: 212
		internal struct Il2CppClass_22_1
		{
			// Token: 0x040004C7 RID: 1223
			public unsafe Il2CppImage* image;

			// Token: 0x040004C8 RID: 1224
			public unsafe void* gc_desc;

			// Token: 0x040004C9 RID: 1225
			public unsafe byte* name;

			// Token: 0x040004CA RID: 1226
			public unsafe byte* namespaze;

			// Token: 0x040004CB RID: 1227
			public unsafe Il2CppTypeStruct* byval_arg;

			// Token: 0x040004CC RID: 1228
			public unsafe Il2CppTypeStruct* this_arg;

			// Token: 0x040004CD RID: 1229
			public unsafe Il2CppClass* element_class;

			// Token: 0x040004CE RID: 1230
			public unsafe Il2CppClass* castClass;

			// Token: 0x040004CF RID: 1231
			public unsafe Il2CppClass* declaringType;

			// Token: 0x040004D0 RID: 1232
			public unsafe Il2CppClass* parent;

			// Token: 0x040004D1 RID: 1233
			public unsafe void* generic_class;

			// Token: 0x040004D2 RID: 1234
			public unsafe void* typeDefinition;

			// Token: 0x040004D3 RID: 1235
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x040004D4 RID: 1236
			public unsafe Il2CppEventInfo* events;

			// Token: 0x040004D5 RID: 1237
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x040004D6 RID: 1238
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x040004D7 RID: 1239
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x040004D8 RID: 1240
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x040004D9 RID: 1241
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x040004DA RID: 1242
			public unsafe void* static_fields;

			// Token: 0x040004DB RID: 1243
			public unsafe void* rgctx_data;

			// Token: 0x040004DC RID: 1244
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x040004DD RID: 1245
			public uint cctor_started;

			// Token: 0x040004DE RID: 1246
			public uint cctor_finished;

			// Token: 0x040004DF RID: 1247
			public ulong cctor_thread;

			// Token: 0x040004E0 RID: 1248
			public int genericContainerIndex;

			// Token: 0x040004E1 RID: 1249
			public int customAttributeIndex;

			// Token: 0x040004E2 RID: 1250
			public uint instance_size;

			// Token: 0x040004E3 RID: 1251
			public uint actualSize;

			// Token: 0x040004E4 RID: 1252
			public uint element_size;

			// Token: 0x040004E5 RID: 1253
			public int native_size;

			// Token: 0x040004E6 RID: 1254
			public uint static_fields_size;

			// Token: 0x040004E7 RID: 1255
			public uint thread_static_fields_size;

			// Token: 0x040004E8 RID: 1256
			public int thread_static_fields_offset;

			// Token: 0x040004E9 RID: 1257
			public uint flags;

			// Token: 0x040004EA RID: 1258
			public uint token;

			// Token: 0x040004EB RID: 1259
			public ushort method_count;

			// Token: 0x040004EC RID: 1260
			public ushort property_count;

			// Token: 0x040004ED RID: 1261
			public ushort field_count;

			// Token: 0x040004EE RID: 1262
			public ushort event_count;

			// Token: 0x040004EF RID: 1263
			public ushort nested_type_count;

			// Token: 0x040004F0 RID: 1264
			public ushort vtable_count;

			// Token: 0x040004F1 RID: 1265
			public ushort interfaces_count;

			// Token: 0x040004F2 RID: 1266
			public ushort interface_offsets_count;

			// Token: 0x040004F3 RID: 1267
			public byte typeHierarchyDepth;

			// Token: 0x040004F4 RID: 1268
			public byte genericRecursionDepth;

			// Token: 0x040004F5 RID: 1269
			public byte rank;

			// Token: 0x040004F6 RID: 1270
			public byte minimumAlignment;

			// Token: 0x040004F7 RID: 1271
			public byte packingSize;

			// Token: 0x040004F8 RID: 1272
			public NativeClassStructHandler_22_1.Il2CppClass_22_1.Bitfield0 _bitfield0;

			// Token: 0x020000D5 RID: 213
			internal enum Bitfield0 : ushort
			{
				// Token: 0x040004FA RID: 1274
				BIT_valuetype,
				// Token: 0x040004FB RID: 1275
				valuetype,
				// Token: 0x040004FC RID: 1276
				BIT_initialized = 1,
				// Token: 0x040004FD RID: 1277
				initialized,
				// Token: 0x040004FE RID: 1278
				BIT_enumtype = 2,
				// Token: 0x040004FF RID: 1279
				enumtype = 4,
				// Token: 0x04000500 RID: 1280
				BIT_is_generic = 3,
				// Token: 0x04000501 RID: 1281
				is_generic = 8,
				// Token: 0x04000502 RID: 1282
				BIT_has_references = 4,
				// Token: 0x04000503 RID: 1283
				has_references = 16,
				// Token: 0x04000504 RID: 1284
				BIT_init_pending = 5,
				// Token: 0x04000505 RID: 1285
				init_pending = 32,
				// Token: 0x04000506 RID: 1286
				BIT_size_inited = 6,
				// Token: 0x04000507 RID: 1287
				size_inited = 64,
				// Token: 0x04000508 RID: 1288
				BIT_has_finalize = 7,
				// Token: 0x04000509 RID: 1289
				has_finalize = 128,
				// Token: 0x0400050A RID: 1290
				BIT_has_cctor = 8,
				// Token: 0x0400050B RID: 1291
				has_cctor = 256,
				// Token: 0x0400050C RID: 1292
				BIT_is_blittable = 9,
				// Token: 0x0400050D RID: 1293
				is_blittable = 512,
				// Token: 0x0400050E RID: 1294
				BIT_is_import_or_windows_runtime = 10,
				// Token: 0x0400050F RID: 1295
				is_import_or_windows_runtime = 1024,
				// Token: 0x04000510 RID: 1296
				BIT_is_vtable_initialized = 11,
				// Token: 0x04000511 RID: 1297
				is_vtable_initialized = 2048
			}
		}

		// Token: 0x020000D6 RID: 214
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000853 RID: 2131 RVA: 0x0001FAB4 File Offset: 0x0001DCB4
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_22_1.NativeStructWrapper.DMk0iqmW562igPfsphH();
				NativeClassStructHandler_22_1.NativeStructWrapper.shXZ6emCTxSD8VDSqpW();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_856ffe7e0c9b4de88d71070d175d49fd == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2adb3ca441e493aba80425bcc0f1db3 == 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x1700027C RID: 636
			// (get) Token: 0x06000854 RID: 2132 RVA: 0x0001FB44 File Offset: 0x0001DD44
			private unsafe NativeClassStructHandler_22_1.Il2CppClass_22_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700027D RID: 637
			// (get) Token: 0x06000855 RID: 2133 RVA: 0x0001FB54 File Offset: 0x0001DD54
			// (set) Token: 0x06000856 RID: 2134 RVA: 0x0001FB6C File Offset: 0x0001DD6C
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_22_1.NativeStructWrapper.U2Ae7um9oBbIUBvlZly(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 4);
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
							this.SetBit(NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4f0a774880f74bccb3d4511e5f526375 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700027E RID: 638
			// (get) Token: 0x06000857 RID: 2135 RVA: 0x0001FBD0 File Offset: 0x0001DDD0
			public IntPtr Pointer { get; }

			// Token: 0x1700027F RID: 639
			// (get) Token: 0x06000858 RID: 2136 RVA: 0x0001FBE0 File Offset: 0x0001DDE0
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_22_1.NativeStructWrapper.OrxclDmIenRAjqakugf(this.Pointer, sizeof(NativeClassStructHandler_22_1.Il2CppClass_22_1), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x17000280 RID: 640
			// (get) Token: 0x06000859 RID: 2137 RVA: 0x0001FC00 File Offset: 0x0001DE00
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000281 RID: 641
			// (get) Token: 0x0600085A RID: 2138 RVA: 0x0001FC10 File Offset: 0x0001DE10
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->byval_arg);
				}
			}

			// Token: 0x17000282 RID: 642
			// (get) Token: 0x0600085B RID: 2139 RVA: 0x0001FC2C File Offset: 0x0001DE2C
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->this_arg);
				}
			}

			// Token: 0x17000283 RID: 643
			// (get) Token: 0x0600085C RID: 2140 RVA: 0x0001FC48 File Offset: 0x0001DE48
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x17000284 RID: 644
			// (get) Token: 0x0600085D RID: 2141 RVA: 0x0001FC5C File Offset: 0x0001DE5C
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x17000285 RID: 645
			// (get) Token: 0x0600085E RID: 2142 RVA: 0x0001FC70 File Offset: 0x0001DE70
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x17000286 RID: 646
			// (get) Token: 0x0600085F RID: 2143 RVA: 0x0001FC84 File Offset: 0x0001DE84
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x17000287 RID: 647
			// (get) Token: 0x06000860 RID: 2144 RVA: 0x0001FC98 File Offset: 0x0001DE98
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x17000288 RID: 648
			// (get) Token: 0x06000861 RID: 2145 RVA: 0x0001FCAC File Offset: 0x0001DEAC
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x17000289 RID: 649
			// (get) Token: 0x06000862 RID: 2146 RVA: 0x0001FCC0 File Offset: 0x0001DEC0
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x1700028A RID: 650
			// (get) Token: 0x06000863 RID: 2147 RVA: 0x0001FCD4 File Offset: 0x0001DED4
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x1700028B RID: 651
			// (get) Token: 0x06000864 RID: 2148 RVA: 0x0001FCE8 File Offset: 0x0001DEE8
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x1700028C RID: 652
			// (get) Token: 0x06000865 RID: 2149 RVA: 0x0001FCFC File Offset: 0x0001DEFC
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x1700028D RID: 653
			// (get) Token: 0x06000866 RID: 2150 RVA: 0x0001FD14 File Offset: 0x0001DF14
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700028E RID: 654
			// (get) Token: 0x06000867 RID: 2151 RVA: 0x0001FD2C File Offset: 0x0001DF2C
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x1700028F RID: 655
			// (get) Token: 0x06000868 RID: 2152 RVA: 0x0001FD44 File Offset: 0x0001DF44
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x17000290 RID: 656
			// (get) Token: 0x06000869 RID: 2153 RVA: 0x0001FD58 File Offset: 0x0001DF58
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000291 RID: 657
			// (get) Token: 0x0600086A RID: 2154 RVA: 0x0001FD6C File Offset: 0x0001DF6C
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x17000292 RID: 658
			// (get) Token: 0x0600086B RID: 2155 RVA: 0x0001FD80 File Offset: 0x0001DF80
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x17000293 RID: 659
			// (get) Token: 0x0600086C RID: 2156 RVA: 0x0001FD94 File Offset: 0x0001DF94
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x17000294 RID: 660
			// (get) Token: 0x0600086D RID: 2157 RVA: 0x0001FDA8 File Offset: 0x0001DFA8
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._klassDummy;
				}
			}

			// Token: 0x17000295 RID: 661
			// (get) Token: 0x0600086E RID: 2158 RVA: 0x0001FDB8 File Offset: 0x0001DFB8
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x17000296 RID: 662
			// (get) Token: 0x0600086F RID: 2159 RVA: 0x0001FDCC File Offset: 0x0001DFCC
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x17000297 RID: 663
			// (get) Token: 0x06000870 RID: 2160 RVA: 0x0001FDE0 File Offset: 0x0001DFE0
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x17000298 RID: 664
			// (get) Token: 0x06000871 RID: 2161 RVA: 0x0001FDF4 File Offset: 0x0001DFF4
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x17000299 RID: 665
			// (get) Token: 0x06000872 RID: 2162 RVA: 0x0001FE08 File Offset: 0x0001E008
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x1700029A RID: 666
			// (get) Token: 0x06000873 RID: 2163 RVA: 0x0001FE1C File Offset: 0x0001E01C
			// (set) Token: 0x06000874 RID: 2164 RVA: 0x0001FE34 File Offset: 0x0001E034
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_22_1.NativeStructWrapper.U2Ae7um9oBbIUBvlZly(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_22_1.NativeStructWrapper.yYFRkemdU5N4ts8rLJo(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700029B RID: 667
			// (get) Token: 0x06000875 RID: 2165 RVA: 0x0001FE98 File Offset: 0x0001E098
			// (set) Token: 0x06000876 RID: 2166 RVA: 0x0001FEB0 File Offset: 0x0001E0B0
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_22_1.NativeStructWrapper.U2Ae7um9oBbIUBvlZly(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 1);
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
							this.SetBit(NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3566f8d0a0994626b4e9fd660bc94d73 == 0)
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

			// Token: 0x1700029C RID: 668
			// (get) Token: 0x06000877 RID: 2167 RVA: 0x0001FF14 File Offset: 0x0001E114
			// (set) Token: 0x06000878 RID: 2168 RVA: 0x0001FF2C File Offset: 0x0001E12C
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_22_1.NativeStructWrapper.U2Ae7um9oBbIUBvlZly(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 2);
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
							this.SetBit(NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_26479210ae524f22ae1fe060a08fdd55 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700029D RID: 669
			// (get) Token: 0x06000879 RID: 2169 RVA: 0x0001FF90 File Offset: 0x0001E190
			// (set) Token: 0x0600087A RID: 2170 RVA: 0x0001FFA8 File Offset: 0x0001E1A8
			public bool IsGeneric
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_22_1.NativeStructWrapper.yYFRkemdU5N4ts8rLJo(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_960a54aec0f640cd975b2d62f3e0a596 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700029E RID: 670
			// (get) Token: 0x0600087B RID: 2171 RVA: 0x0002000C File Offset: 0x0001E20C
			// (set) Token: 0x0600087C RID: 2172 RVA: 0x00020024 File Offset: 0x0001E224
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_22_1.NativeStructWrapper.U2Ae7um9oBbIUBvlZly(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 6);
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
							this.SetBit(NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c580bbd8275c462fb04ea886a5e08073 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700029F RID: 671
			// (get) Token: 0x0600087D RID: 2173 RVA: 0x00020088 File Offset: 0x0001E288
			// (set) Token: 0x0600087E RID: 2174 RVA: 0x000200A0 File Offset: 0x0001E2A0
			public bool HasFinalize
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_22_1.NativeStructWrapper.yYFRkemdU5N4ts8rLJo(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0299b24d936d41acaea60798c25b2a4b == 0)
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

			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x0600087F RID: 2175 RVA: 0x00020104 File Offset: 0x0001E304
			// (set) Token: 0x06000880 RID: 2176 RVA: 0x0002011C File Offset: 0x0001E31C
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_22_1.NativeStructWrapper.U2Ae7um9oBbIUBvlZly(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 11);
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
							NativeClassStructHandler_22_1.NativeStructWrapper.yYFRkemdU5N4ts8rLJo(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 11, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x06000881 RID: 2177 RVA: 0x00020184 File Offset: 0x0001E384
			// (set) Token: 0x06000882 RID: 2178 RVA: 0x00020190 File Offset: 0x0001E390
			public bool InitializedAndNoError
			{
				get
				{
					return true;
				}
				set
				{
				}
			}

			// Token: 0x06000883 RID: 2179 RVA: 0x0002019C File Offset: 0x0001E39C
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
						hIDAYxH6DWLHIthQgC.zSLipEDdx();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ce8abd079f9447b3bade260ffc64f0b8 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
					{
						IntPtr intPtr;
						NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 3;
						continue;
					}
					case 3:
						return;
					case 4:
						NativeClassStructHandler_22_1.NativeStructWrapper.shXZ6emCTxSD8VDSqpW();
						num2 = 5;
						continue;
					case 5:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_22_1.Il2CppClass_22_1>(NativeClassStructHandler_22_1.NativeStructWrapper.ocGEIImiJbfhisexQFX(-1817151529 ^ -1212986918 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0ec1d35577cb488fb4bdfc9810c6c86f));
						num2 = 2;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b329e831708e4d29ae561982d3d8c1c1 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					}
					hIDAYxH6DWLHIthQgC.oDuBOTgYK();
					num2 = 4;
				}
			}

			// Token: 0x06000884 RID: 2180 RVA: 0x00020284 File Offset: 0x0001E484
			internal static void DMk0iqmW562igPfsphH()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000885 RID: 2181 RVA: 0x00020294 File Offset: 0x0001E494
			internal static void shXZ6emCTxSD8VDSqpW()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000886 RID: 2182 RVA: 0x000202A4 File Offset: 0x0001E4A4
			internal static bool HH2xJAmRymEmMWsxj0o()
			{
				return NativeClassStructHandler_22_1.NativeStructWrapper.xHKaw0mFboAloRMMRym == null;
			}

			// Token: 0x06000887 RID: 2183 RVA: 0x000202B8 File Offset: 0x0001E4B8
			internal static NativeClassStructHandler_22_1.NativeStructWrapper bjMwgTmM3YLG1h8iktG()
			{
				return NativeClassStructHandler_22_1.NativeStructWrapper.xHKaw0mFboAloRMMRym;
			}

			// Token: 0x06000888 RID: 2184 RVA: 0x000202C8 File Offset: 0x0001E4C8
			internal static bool U2Ae7um9oBbIUBvlZly(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000889 RID: 2185 RVA: 0x000202E4 File Offset: 0x0001E4E4
			internal static IntPtr OrxclDmIenRAjqakugf(IntPtr A_0, int A_1, object A_2)
			{
				return apS1BFcfBa3gXUspL9j.muOq5LWqgj(A_0, A_1, A_2);
			}

			// Token: 0x0600088A RID: 2186 RVA: 0x00020300 File Offset: 0x0001E500
			internal static void yYFRkemdU5N4ts8rLJo(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x0600088B RID: 2187 RVA: 0x00020320 File Offset: 0x0001E520
			internal static object ocGEIImiJbfhisexQFX(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000512 RID: 1298
			private static readonly int _bitfield0offset;

			// Token: 0x04000513 RID: 1299
			private unsafe Il2CppClass* _klassDummy;

			// Token: 0x04000515 RID: 1301
			internal static object xHKaw0mFboAloRMMRym;
		}
	}
}
