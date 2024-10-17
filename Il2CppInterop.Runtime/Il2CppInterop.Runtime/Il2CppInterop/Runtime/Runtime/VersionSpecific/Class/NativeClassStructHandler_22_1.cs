using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000D5 RID: 213
	[ApplicableToUnityVersionsSince("5.5.1")]
	public class NativeClassStructHandler_22_1 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000866 RID: 2150 RVA: 0x00011AB8 File Offset: 0x0000FCB8
		public int Size()
		{
			return sizeof(NativeClassStructHandler_22_1.Il2CppClass_22_1);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00011AC8 File Offset: 0x0000FCC8
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_22_1.Il2CppClass_22_1* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_22_1.Il2CppClass_22_1);
			ptr2->byval_arg = ((INativeTypeStruct)NativeClassStructHandler_22_1.po2Bex68ZXMRwLhpFYK()).TypePointer;
			ptr2->this_arg = UnityVersionHandler.NewType().TypePointer;
			return new NativeClassStructHandler_22_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00011B24 File Offset: 0x0000FD24
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f65b5965aa9843ea8b738fef02a2c6c9 == 0)
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
			return new NativeClassStructHandler_22_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00011B8C File Offset: 0x0000FD8C
		public NativeClassStructHandler_22_1()
		{
			NativeClassStructHandler_22_1.BbXIf960I1kN3RggktG();
			NativeClassStructHandler_22_1.zoowCr6Ng2u3SFgQhnA();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a8737fecb12449d7ad23f5080d76d2f8 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00011BF0 File Offset: 0x0000FDF0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_22_1()
		{
			NativeClassStructHandler_22_1.y6am4p6uPIBZD4Hk0YT();
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00011C00 File Offset: 0x0000FE00
		internal static object po2Bex68ZXMRwLhpFYK()
		{
			return UnityVersionHandler.NewType();
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00011C10 File Offset: 0x0000FE10
		internal static bool ybO7cU6xDaE04JfT0yC()
		{
			return NativeClassStructHandler_22_1.FC1T7H6tqWxwoTZSWtH == null;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00011C24 File Offset: 0x0000FE24
		internal static NativeClassStructHandler_22_1 UlVUyp6hDLPEV3VPT8A()
		{
			return NativeClassStructHandler_22_1.FC1T7H6tqWxwoTZSWtH;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00011C34 File Offset: 0x0000FE34
		internal static void BbXIf960I1kN3RggktG()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00011C44 File Offset: 0x0000FE44
		internal static void zoowCr6Ng2u3SFgQhnA()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00011C54 File Offset: 0x0000FE54
		internal static void y6am4p6uPIBZD4Hk0YT()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040004D1 RID: 1233
		internal static NativeClassStructHandler_22_1 FC1T7H6tqWxwoTZSWtH;

		// Token: 0x020000D6 RID: 214
		internal struct Il2CppClass_22_1
		{
			// Token: 0x040004D2 RID: 1234
			public unsafe Il2CppImage* image;

			// Token: 0x040004D3 RID: 1235
			public unsafe void* gc_desc;

			// Token: 0x040004D4 RID: 1236
			public unsafe byte* name;

			// Token: 0x040004D5 RID: 1237
			public unsafe byte* namespaze;

			// Token: 0x040004D6 RID: 1238
			public unsafe Il2CppTypeStruct* byval_arg;

			// Token: 0x040004D7 RID: 1239
			public unsafe Il2CppTypeStruct* this_arg;

			// Token: 0x040004D8 RID: 1240
			public unsafe Il2CppClass* element_class;

			// Token: 0x040004D9 RID: 1241
			public unsafe Il2CppClass* castClass;

			// Token: 0x040004DA RID: 1242
			public unsafe Il2CppClass* declaringType;

			// Token: 0x040004DB RID: 1243
			public unsafe Il2CppClass* parent;

			// Token: 0x040004DC RID: 1244
			public unsafe void* generic_class;

			// Token: 0x040004DD RID: 1245
			public unsafe void* typeDefinition;

			// Token: 0x040004DE RID: 1246
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x040004DF RID: 1247
			public unsafe Il2CppEventInfo* events;

			// Token: 0x040004E0 RID: 1248
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x040004E1 RID: 1249
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x040004E2 RID: 1250
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x040004E3 RID: 1251
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x040004E4 RID: 1252
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x040004E5 RID: 1253
			public unsafe void* static_fields;

			// Token: 0x040004E6 RID: 1254
			public unsafe void* rgctx_data;

			// Token: 0x040004E7 RID: 1255
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x040004E8 RID: 1256
			public uint cctor_started;

			// Token: 0x040004E9 RID: 1257
			public uint cctor_finished;

			// Token: 0x040004EA RID: 1258
			public ulong cctor_thread;

			// Token: 0x040004EB RID: 1259
			public int genericContainerIndex;

			// Token: 0x040004EC RID: 1260
			public int customAttributeIndex;

			// Token: 0x040004ED RID: 1261
			public uint instance_size;

			// Token: 0x040004EE RID: 1262
			public uint actualSize;

			// Token: 0x040004EF RID: 1263
			public uint element_size;

			// Token: 0x040004F0 RID: 1264
			public int native_size;

			// Token: 0x040004F1 RID: 1265
			public uint static_fields_size;

			// Token: 0x040004F2 RID: 1266
			public uint thread_static_fields_size;

			// Token: 0x040004F3 RID: 1267
			public int thread_static_fields_offset;

			// Token: 0x040004F4 RID: 1268
			public uint flags;

			// Token: 0x040004F5 RID: 1269
			public uint token;

			// Token: 0x040004F6 RID: 1270
			public ushort method_count;

			// Token: 0x040004F7 RID: 1271
			public ushort property_count;

			// Token: 0x040004F8 RID: 1272
			public ushort field_count;

			// Token: 0x040004F9 RID: 1273
			public ushort event_count;

			// Token: 0x040004FA RID: 1274
			public ushort nested_type_count;

			// Token: 0x040004FB RID: 1275
			public ushort vtable_count;

			// Token: 0x040004FC RID: 1276
			public ushort interfaces_count;

			// Token: 0x040004FD RID: 1277
			public ushort interface_offsets_count;

			// Token: 0x040004FE RID: 1278
			public byte typeHierarchyDepth;

			// Token: 0x040004FF RID: 1279
			public byte genericRecursionDepth;

			// Token: 0x04000500 RID: 1280
			public byte rank;

			// Token: 0x04000501 RID: 1281
			public byte minimumAlignment;

			// Token: 0x04000502 RID: 1282
			public byte packingSize;

			// Token: 0x04000503 RID: 1283
			public NativeClassStructHandler_22_1.Il2CppClass_22_1.Bitfield0 _bitfield0;

			// Token: 0x020000D7 RID: 215
			internal enum Bitfield0 : ushort
			{
				// Token: 0x04000505 RID: 1285
				BIT_valuetype,
				// Token: 0x04000506 RID: 1286
				valuetype,
				// Token: 0x04000507 RID: 1287
				BIT_initialized = 1,
				// Token: 0x04000508 RID: 1288
				initialized,
				// Token: 0x04000509 RID: 1289
				BIT_enumtype = 2,
				// Token: 0x0400050A RID: 1290
				enumtype = 4,
				// Token: 0x0400050B RID: 1291
				BIT_is_generic = 3,
				// Token: 0x0400050C RID: 1292
				is_generic = 8,
				// Token: 0x0400050D RID: 1293
				BIT_has_references = 4,
				// Token: 0x0400050E RID: 1294
				has_references = 16,
				// Token: 0x0400050F RID: 1295
				BIT_init_pending = 5,
				// Token: 0x04000510 RID: 1296
				init_pending = 32,
				// Token: 0x04000511 RID: 1297
				BIT_size_inited = 6,
				// Token: 0x04000512 RID: 1298
				size_inited = 64,
				// Token: 0x04000513 RID: 1299
				BIT_has_finalize = 7,
				// Token: 0x04000514 RID: 1300
				has_finalize = 128,
				// Token: 0x04000515 RID: 1301
				BIT_has_cctor = 8,
				// Token: 0x04000516 RID: 1302
				has_cctor = 256,
				// Token: 0x04000517 RID: 1303
				BIT_is_blittable = 9,
				// Token: 0x04000518 RID: 1304
				is_blittable = 512,
				// Token: 0x04000519 RID: 1305
				BIT_is_import_or_windows_runtime = 10,
				// Token: 0x0400051A RID: 1306
				is_import_or_windows_runtime = 1024,
				// Token: 0x0400051B RID: 1307
				BIT_is_vtable_initialized = 11,
				// Token: 0x0400051C RID: 1308
				is_vtable_initialized = 2048
			}
		}

		// Token: 0x020000D8 RID: 216
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000871 RID: 2161 RVA: 0x000206E0 File Offset: 0x0001E8E0
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_22_1.NativeStructWrapper.E0VqSbbiUq9XiFbRarW();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40 == 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.<Pointer>k__BackingField = ptr;
						num = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7b2fff018dbf4cfe8ef41e2d123dc629 != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x1700027C RID: 636
			// (get) Token: 0x06000872 RID: 2162 RVA: 0x00020770 File Offset: 0x0001E970
			private unsafe NativeClassStructHandler_22_1.Il2CppClass_22_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700027D RID: 637
			// (get) Token: 0x06000873 RID: 2163 RVA: 0x00020780 File Offset: 0x0001E980
			// (set) Token: 0x06000874 RID: 2164 RVA: 0x00020798 File Offset: 0x0001E998
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_22_1.NativeStructWrapper.Ib5jTSbIXfJ2guv0uxj(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_22_1.NativeStructWrapper.sJi5s4bGpyQ6cKu2V5O(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6926da1cf80047d3a6f0516668d22380 != 0)
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

			// Token: 0x1700027E RID: 638
			// (get) Token: 0x06000875 RID: 2165 RVA: 0x000207FC File Offset: 0x0001E9FC
			public IntPtr Pointer { get; }

			// Token: 0x1700027F RID: 639
			// (get) Token: 0x06000876 RID: 2166 RVA: 0x0002080C File Offset: 0x0001EA0C
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_22_1.NativeStructWrapper.VLfZv2bY9MTBYBgWtex(this.Pointer, sizeof(NativeClassStructHandler_22_1.Il2CppClass_22_1), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x17000280 RID: 640
			// (get) Token: 0x06000877 RID: 2167 RVA: 0x0002082C File Offset: 0x0001EA2C
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000281 RID: 641
			// (get) Token: 0x06000878 RID: 2168 RVA: 0x0002083C File Offset: 0x0001EA3C
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->byval_arg);
				}
			}

			// Token: 0x17000282 RID: 642
			// (get) Token: 0x06000879 RID: 2169 RVA: 0x00020858 File Offset: 0x0001EA58
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->this_arg);
				}
			}

			// Token: 0x17000283 RID: 643
			// (get) Token: 0x0600087A RID: 2170 RVA: 0x00020874 File Offset: 0x0001EA74
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x17000284 RID: 644
			// (get) Token: 0x0600087B RID: 2171 RVA: 0x00020888 File Offset: 0x0001EA88
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x17000285 RID: 645
			// (get) Token: 0x0600087C RID: 2172 RVA: 0x0002089C File Offset: 0x0001EA9C
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x17000286 RID: 646
			// (get) Token: 0x0600087D RID: 2173 RVA: 0x000208B0 File Offset: 0x0001EAB0
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x17000287 RID: 647
			// (get) Token: 0x0600087E RID: 2174 RVA: 0x000208C4 File Offset: 0x0001EAC4
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x17000288 RID: 648
			// (get) Token: 0x0600087F RID: 2175 RVA: 0x000208D8 File Offset: 0x0001EAD8
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x17000289 RID: 649
			// (get) Token: 0x06000880 RID: 2176 RVA: 0x000208EC File Offset: 0x0001EAEC
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x1700028A RID: 650
			// (get) Token: 0x06000881 RID: 2177 RVA: 0x00020900 File Offset: 0x0001EB00
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x1700028B RID: 651
			// (get) Token: 0x06000882 RID: 2178 RVA: 0x00020914 File Offset: 0x0001EB14
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x1700028C RID: 652
			// (get) Token: 0x06000883 RID: 2179 RVA: 0x00020928 File Offset: 0x0001EB28
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x1700028D RID: 653
			// (get) Token: 0x06000884 RID: 2180 RVA: 0x00020940 File Offset: 0x0001EB40
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700028E RID: 654
			// (get) Token: 0x06000885 RID: 2181 RVA: 0x00020958 File Offset: 0x0001EB58
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x1700028F RID: 655
			// (get) Token: 0x06000886 RID: 2182 RVA: 0x00020970 File Offset: 0x0001EB70
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x17000290 RID: 656
			// (get) Token: 0x06000887 RID: 2183 RVA: 0x00020984 File Offset: 0x0001EB84
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000291 RID: 657
			// (get) Token: 0x06000888 RID: 2184 RVA: 0x00020998 File Offset: 0x0001EB98
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x17000292 RID: 658
			// (get) Token: 0x06000889 RID: 2185 RVA: 0x000209AC File Offset: 0x0001EBAC
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x17000293 RID: 659
			// (get) Token: 0x0600088A RID: 2186 RVA: 0x000209C0 File Offset: 0x0001EBC0
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x17000294 RID: 660
			// (get) Token: 0x0600088B RID: 2187 RVA: 0x000209D4 File Offset: 0x0001EBD4
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._klassDummy;
				}
			}

			// Token: 0x17000295 RID: 661
			// (get) Token: 0x0600088C RID: 2188 RVA: 0x000209E4 File Offset: 0x0001EBE4
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x17000296 RID: 662
			// (get) Token: 0x0600088D RID: 2189 RVA: 0x000209F8 File Offset: 0x0001EBF8
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x17000297 RID: 663
			// (get) Token: 0x0600088E RID: 2190 RVA: 0x00020A0C File Offset: 0x0001EC0C
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x17000298 RID: 664
			// (get) Token: 0x0600088F RID: 2191 RVA: 0x00020A20 File Offset: 0x0001EC20
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x17000299 RID: 665
			// (get) Token: 0x06000890 RID: 2192 RVA: 0x00020A34 File Offset: 0x0001EC34
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x1700029A RID: 666
			// (get) Token: 0x06000891 RID: 2193 RVA: 0x00020A48 File Offset: 0x0001EC48
			// (set) Token: 0x06000892 RID: 2194 RVA: 0x00020A60 File Offset: 0x0001EC60
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_22_1.NativeStructWrapper.Ib5jTSbIXfJ2guv0uxj(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_22_1.NativeStructWrapper.sJi5s4bGpyQ6cKu2V5O(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c504ab11ece64b14b01df2d4c88e6e49 == 0)
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

			// Token: 0x1700029B RID: 667
			// (get) Token: 0x06000893 RID: 2195 RVA: 0x00020AC4 File Offset: 0x0001ECC4
			// (set) Token: 0x06000894 RID: 2196 RVA: 0x00020ADC File Offset: 0x0001ECDC
			public bool Initialized
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 1);
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
							this.SetBit(NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700029C RID: 668
			// (get) Token: 0x06000895 RID: 2197 RVA: 0x00020B40 File Offset: 0x0001ED40
			// (set) Token: 0x06000896 RID: 2198 RVA: 0x00020B58 File Offset: 0x0001ED58
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_22_1.NativeStructWrapper.Ib5jTSbIXfJ2guv0uxj(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_22_1.NativeStructWrapper.sJi5s4bGpyQ6cKu2V5O(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 2, value);
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

			// Token: 0x1700029D RID: 669
			// (get) Token: 0x06000897 RID: 2199 RVA: 0x00020BBC File Offset: 0x0001EDBC
			// (set) Token: 0x06000898 RID: 2200 RVA: 0x00020BD4 File Offset: 0x0001EDD4
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
							NativeClassStructHandler_22_1.NativeStructWrapper.sJi5s4bGpyQ6cKu2V5O(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9f56599a6a304695b6cfc284bd7d7c9a == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700029E RID: 670
			// (get) Token: 0x06000899 RID: 2201 RVA: 0x00020C38 File Offset: 0x0001EE38
			// (set) Token: 0x0600089A RID: 2202 RVA: 0x00020C50 File Offset: 0x0001EE50
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_22_1.NativeStructWrapper.Ib5jTSbIXfJ2guv0uxj(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 6);
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
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ce81190098cb44f1b9a77ca4822d7770 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700029F RID: 671
			// (get) Token: 0x0600089B RID: 2203 RVA: 0x00020CB4 File Offset: 0x0001EEB4
			// (set) Token: 0x0600089C RID: 2204 RVA: 0x00020CCC File Offset: 0x0001EECC
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_22_1.NativeStructWrapper.Ib5jTSbIXfJ2guv0uxj(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_22_1.NativeStructWrapper.sJi5s4bGpyQ6cKu2V5O(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a36e967c0f044e9ebf523536bdec8e28 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x0600089D RID: 2205 RVA: 0x00020D30 File Offset: 0x0001EF30
			// (set) Token: 0x0600089E RID: 2206 RVA: 0x00020D48 File Offset: 0x0001EF48
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_22_1.NativeStructWrapper.Ib5jTSbIXfJ2guv0uxj(this, NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 11);
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
							this.SetBit(NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset, 11, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f72daac7e98440569eaab57fbb9f7bf2 == 0)
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

			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x0600089F RID: 2207 RVA: 0x00020DB0 File Offset: 0x0001EFB0
			// (set) Token: 0x060008A0 RID: 2208 RVA: 0x00020DBC File Offset: 0x0001EFBC
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

			// Token: 0x060008A1 RID: 2209 RVA: 0x00020DC8 File Offset: 0x0001EFC8
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
						NativeClassStructHandler_22_1.NativeStructWrapper.uT3Udobadj7vO1XvRHC();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2b24b0de55344c2b8aaf8116dbc4d16 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_22_1.Il2CppClass_22_1>(NativeClassStructHandler_22_1.NativeStructWrapper.XQ85wabtCIg4hbpHNYa(1253386989 << 6 ^ -902918110 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ddf0bbff3ec54ad39c6b2ba58dc80058));
						num2 = 5;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_dbbda98ba6574101bc623ad559f7b5a3 == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					case 3:
						return;
					case 4:
						NativeClassStructHandler_22_1.NativeStructWrapper.almBIYbCO2klm8Nfjtx();
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_667bd9633593433784ebdd2b3fdc8daf == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 5:
					{
						IntPtr intPtr;
						NativeClassStructHandler_22_1.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 3;
						continue;
					}
					}
					NativeClassStructHandler_22_1.NativeStructWrapper.E0VqSbbiUq9XiFbRarW();
					num2 = 4;
				}
			}

			// Token: 0x060008A2 RID: 2210 RVA: 0x00020ECC File Offset: 0x0001F0CC
			internal static void E0VqSbbiUq9XiFbRarW()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060008A3 RID: 2211 RVA: 0x00020EDC File Offset: 0x0001F0DC
			internal static bool C3irmqbqXDGyPaCfaHZ()
			{
				return NativeClassStructHandler_22_1.NativeStructWrapper.e58a19bUbjP9EjauUiB == null;
			}

			// Token: 0x060008A4 RID: 2212 RVA: 0x00020EF0 File Offset: 0x0001F0F0
			internal static NativeClassStructHandler_22_1.NativeStructWrapper Wrcuqab9aSre89NKHMq()
			{
				return NativeClassStructHandler_22_1.NativeStructWrapper.e58a19bUbjP9EjauUiB;
			}

			// Token: 0x060008A5 RID: 2213 RVA: 0x00020F00 File Offset: 0x0001F100
			internal static bool Ib5jTSbIXfJ2guv0uxj(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060008A6 RID: 2214 RVA: 0x00020F1C File Offset: 0x0001F11C
			internal static void sJi5s4bGpyQ6cKu2V5O(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x060008A7 RID: 2215 RVA: 0x00020F3C File Offset: 0x0001F13C
			internal static IntPtr VLfZv2bY9MTBYBgWtex(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x060008A8 RID: 2216 RVA: 0x00020F58 File Offset: 0x0001F158
			internal static void uT3Udobadj7vO1XvRHC()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x060008A9 RID: 2217 RVA: 0x00020F68 File Offset: 0x0001F168
			internal static void almBIYbCO2klm8Nfjtx()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x060008AA RID: 2218 RVA: 0x00020F78 File Offset: 0x0001F178
			internal static object XQ85wabtCIg4hbpHNYa(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x0400051D RID: 1309
			private static readonly int _bitfield0offset;

			// Token: 0x0400051E RID: 1310
			private unsafe Il2CppClass* _klassDummy;

			// Token: 0x04000520 RID: 1312
			private static object e58a19bUbjP9EjauUiB;
		}
	}
}
