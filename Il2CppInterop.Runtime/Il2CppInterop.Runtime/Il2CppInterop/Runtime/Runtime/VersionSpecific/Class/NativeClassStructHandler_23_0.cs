using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000D9 RID: 217
	[ApplicableToUnityVersionsSince("5.6.0")]
	public class NativeClassStructHandler_23_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x060008AB RID: 2219 RVA: 0x00011C64 File Offset: 0x0000FE64
		public int Size()
		{
			return sizeof(NativeClassStructHandler_23_0.Il2CppClass_23_0);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00011C74 File Offset: 0x0000FE74
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_23_0.Il2CppClass_23_0* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_23_0.Ytf0D26LM3ElesO9LJF(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_23_0.Il2CppClass_23_0);
			ptr2->byval_arg = ((INativeTypeStruct)NativeClassStructHandler_23_0.xD1g0c678m3mc4TJdoD()).TypePointer;
			ptr2->this_arg = ((INativeTypeStruct)NativeClassStructHandler_23_0.xD1g0c678m3mc4TJdoD()).TypePointer;
			return new NativeClassStructHandler_23_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00011CD0 File Offset: 0x0000FED0
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_98f1dfe5d9cd4cf9bdc32e0db7fb0ae4 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeClassStructHandler_23_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00011D38 File Offset: 0x0000FF38
		public NativeClassStructHandler_23_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeClassStructHandler_23_0.uMex5w6RvAxWA8CHb38();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_89e7beae9a774fb691cacbb26b1d9330 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00011D9C File Offset: 0x0000FF9C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_23_0()
		{
			NativeClassStructHandler_23_0.H8ore16kHBY3ejahrhg();
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00011DAC File Offset: 0x0000FFAC
		internal static IntPtr Ytf0D26LM3ElesO9LJF(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		internal static object xD1g0c678m3mc4TJdoD()
		{
			return UnityVersionHandler.NewType();
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00011DD0 File Offset: 0x0000FFD0
		internal static bool IRDTgm6coDvt1dlqeGm()
		{
			return NativeClassStructHandler_23_0.VEW9l96EdCvHFX3aKIU == null;
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00011DE4 File Offset: 0x0000FFE4
		internal static NativeClassStructHandler_23_0 wXa2jm66AQiFOyusHle()
		{
			return NativeClassStructHandler_23_0.VEW9l96EdCvHFX3aKIU;
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00011DF4 File Offset: 0x0000FFF4
		internal static void uMex5w6RvAxWA8CHb38()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00011E04 File Offset: 0x00010004
		internal static void H8ore16kHBY3ejahrhg()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000521 RID: 1313
		private static NativeClassStructHandler_23_0 VEW9l96EdCvHFX3aKIU;

		// Token: 0x020000DA RID: 218
		internal struct Il2CppClass_23_0
		{
			// Token: 0x04000522 RID: 1314
			public unsafe Il2CppImage* image;

			// Token: 0x04000523 RID: 1315
			public unsafe void* gc_desc;

			// Token: 0x04000524 RID: 1316
			public unsafe byte* name;

			// Token: 0x04000525 RID: 1317
			public unsafe byte* namespaze;

			// Token: 0x04000526 RID: 1318
			public unsafe Il2CppTypeStruct* byval_arg;

			// Token: 0x04000527 RID: 1319
			public unsafe Il2CppTypeStruct* this_arg;

			// Token: 0x04000528 RID: 1320
			public unsafe Il2CppClass* element_class;

			// Token: 0x04000529 RID: 1321
			public unsafe Il2CppClass* castClass;

			// Token: 0x0400052A RID: 1322
			public unsafe Il2CppClass* declaringType;

			// Token: 0x0400052B RID: 1323
			public unsafe Il2CppClass* parent;

			// Token: 0x0400052C RID: 1324
			public unsafe void* generic_class;

			// Token: 0x0400052D RID: 1325
			public unsafe void* typeDefinition;

			// Token: 0x0400052E RID: 1326
			public unsafe void* interopData;

			// Token: 0x0400052F RID: 1327
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x04000530 RID: 1328
			public unsafe Il2CppEventInfo* events;

			// Token: 0x04000531 RID: 1329
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000532 RID: 1330
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x04000533 RID: 1331
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000534 RID: 1332
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x04000535 RID: 1333
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x04000536 RID: 1334
			public unsafe void* static_fields;

			// Token: 0x04000537 RID: 1335
			public unsafe void* rgctx_data;

			// Token: 0x04000538 RID: 1336
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x04000539 RID: 1337
			public uint cctor_started;

			// Token: 0x0400053A RID: 1338
			public uint cctor_finished;

			// Token: 0x0400053B RID: 1339
			public ulong cctor_thread;

			// Token: 0x0400053C RID: 1340
			public int genericContainerIndex;

			// Token: 0x0400053D RID: 1341
			public int customAttributeIndex;

			// Token: 0x0400053E RID: 1342
			public uint instance_size;

			// Token: 0x0400053F RID: 1343
			public uint actualSize;

			// Token: 0x04000540 RID: 1344
			public uint element_size;

			// Token: 0x04000541 RID: 1345
			public int native_size;

			// Token: 0x04000542 RID: 1346
			public uint static_fields_size;

			// Token: 0x04000543 RID: 1347
			public uint thread_static_fields_size;

			// Token: 0x04000544 RID: 1348
			public int thread_static_fields_offset;

			// Token: 0x04000545 RID: 1349
			public uint flags;

			// Token: 0x04000546 RID: 1350
			public uint token;

			// Token: 0x04000547 RID: 1351
			public ushort method_count;

			// Token: 0x04000548 RID: 1352
			public ushort property_count;

			// Token: 0x04000549 RID: 1353
			public ushort field_count;

			// Token: 0x0400054A RID: 1354
			public ushort event_count;

			// Token: 0x0400054B RID: 1355
			public ushort nested_type_count;

			// Token: 0x0400054C RID: 1356
			public ushort vtable_count;

			// Token: 0x0400054D RID: 1357
			public ushort interfaces_count;

			// Token: 0x0400054E RID: 1358
			public ushort interface_offsets_count;

			// Token: 0x0400054F RID: 1359
			public byte typeHierarchyDepth;

			// Token: 0x04000550 RID: 1360
			public byte genericRecursionDepth;

			// Token: 0x04000551 RID: 1361
			public byte rank;

			// Token: 0x04000552 RID: 1362
			public byte minimumAlignment;

			// Token: 0x04000553 RID: 1363
			public byte packingSize;

			// Token: 0x04000554 RID: 1364
			public NativeClassStructHandler_23_0.Il2CppClass_23_0.Bitfield0 _bitfield0;

			// Token: 0x020000DB RID: 219
			internal enum Bitfield0 : ushort
			{
				// Token: 0x04000556 RID: 1366
				BIT_valuetype,
				// Token: 0x04000557 RID: 1367
				valuetype,
				// Token: 0x04000558 RID: 1368
				BIT_initialized = 1,
				// Token: 0x04000559 RID: 1369
				initialized,
				// Token: 0x0400055A RID: 1370
				BIT_enumtype = 2,
				// Token: 0x0400055B RID: 1371
				enumtype = 4,
				// Token: 0x0400055C RID: 1372
				BIT_is_generic = 3,
				// Token: 0x0400055D RID: 1373
				is_generic = 8,
				// Token: 0x0400055E RID: 1374
				BIT_has_references = 4,
				// Token: 0x0400055F RID: 1375
				has_references = 16,
				// Token: 0x04000560 RID: 1376
				BIT_init_pending = 5,
				// Token: 0x04000561 RID: 1377
				init_pending = 32,
				// Token: 0x04000562 RID: 1378
				BIT_size_inited = 6,
				// Token: 0x04000563 RID: 1379
				size_inited = 64,
				// Token: 0x04000564 RID: 1380
				BIT_has_finalize = 7,
				// Token: 0x04000565 RID: 1381
				has_finalize = 128,
				// Token: 0x04000566 RID: 1382
				BIT_has_cctor = 8,
				// Token: 0x04000567 RID: 1383
				has_cctor = 256,
				// Token: 0x04000568 RID: 1384
				BIT_is_blittable = 9,
				// Token: 0x04000569 RID: 1385
				is_blittable = 512,
				// Token: 0x0400056A RID: 1386
				BIT_is_import_or_windows_runtime = 10,
				// Token: 0x0400056B RID: 1387
				is_import_or_windows_runtime = 1024,
				// Token: 0x0400056C RID: 1388
				BIT_is_vtable_initialized = 11,
				// Token: 0x0400056D RID: 1389
				is_vtable_initialized = 2048
			}
		}

		// Token: 0x020000DC RID: 220
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x060008B6 RID: 2230 RVA: 0x00020F8C File Offset: 0x0001F18C
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_23_0.NativeStructWrapper.FrRXFCbEP8ByomGsQe5();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c1d51581d05f41579ee6e476d9be288e == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4ab786fa8604298818cd412db8f702f != 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x060008B7 RID: 2231 RVA: 0x0002101C File Offset: 0x0001F21C
			private unsafe NativeClassStructHandler_23_0.Il2CppClass_23_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170002A3 RID: 675
			// (get) Token: 0x060008B8 RID: 2232 RVA: 0x0002102C File Offset: 0x0001F22C
			// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00021044 File Offset: 0x0001F244
			public bool HasReferences
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_23_0.NativeStructWrapper.BJKaerbcYdVg3M73RnU(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3ffead0113044f06b294bee6bd5e7a44 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170002A4 RID: 676
			// (get) Token: 0x060008BA RID: 2234 RVA: 0x000210A8 File Offset: 0x0001F2A8
			public IntPtr Pointer { get; }

			// Token: 0x170002A5 RID: 677
			// (get) Token: 0x060008BB RID: 2235 RVA: 0x000210B8 File Offset: 0x0001F2B8
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_23_0.NativeStructWrapper.EINXrxb6wnWMv8cFEkx(this.Pointer, sizeof(NativeClassStructHandler_23_0.Il2CppClass_23_0), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x170002A6 RID: 678
			// (get) Token: 0x060008BC RID: 2236 RVA: 0x000210D8 File Offset: 0x0001F2D8
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170002A7 RID: 679
			// (get) Token: 0x060008BD RID: 2237 RVA: 0x000210E8 File Offset: 0x0001F2E8
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->byval_arg);
				}
			}

			// Token: 0x170002A8 RID: 680
			// (get) Token: 0x060008BE RID: 2238 RVA: 0x00021104 File Offset: 0x0001F304
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->this_arg);
				}
			}

			// Token: 0x170002A9 RID: 681
			// (get) Token: 0x060008BF RID: 2239 RVA: 0x00021120 File Offset: 0x0001F320
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x170002AA RID: 682
			// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00021134 File Offset: 0x0001F334
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x170002AB RID: 683
			// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00021148 File Offset: 0x0001F348
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x170002AC RID: 684
			// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0002115C File Offset: 0x0001F35C
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x170002AD RID: 685
			// (get) Token: 0x060008C3 RID: 2243 RVA: 0x00021170 File Offset: 0x0001F370
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x170002AE RID: 686
			// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00021184 File Offset: 0x0001F384
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x170002AF RID: 687
			// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00021198 File Offset: 0x0001F398
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x170002B0 RID: 688
			// (get) Token: 0x060008C6 RID: 2246 RVA: 0x000211AC File Offset: 0x0001F3AC
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x170002B1 RID: 689
			// (get) Token: 0x060008C7 RID: 2247 RVA: 0x000211C0 File Offset: 0x0001F3C0
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x170002B2 RID: 690
			// (get) Token: 0x060008C8 RID: 2248 RVA: 0x000211D4 File Offset: 0x0001F3D4
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x170002B3 RID: 691
			// (get) Token: 0x060008C9 RID: 2249 RVA: 0x000211EC File Offset: 0x0001F3EC
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170002B4 RID: 692
			// (get) Token: 0x060008CA RID: 2250 RVA: 0x00021204 File Offset: 0x0001F404
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x170002B5 RID: 693
			// (get) Token: 0x060008CB RID: 2251 RVA: 0x0002121C File Offset: 0x0001F41C
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x170002B6 RID: 694
			// (get) Token: 0x060008CC RID: 2252 RVA: 0x00021230 File Offset: 0x0001F430
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x170002B7 RID: 695
			// (get) Token: 0x060008CD RID: 2253 RVA: 0x00021244 File Offset: 0x0001F444
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x170002B8 RID: 696
			// (get) Token: 0x060008CE RID: 2254 RVA: 0x00021258 File Offset: 0x0001F458
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x170002B9 RID: 697
			// (get) Token: 0x060008CF RID: 2255 RVA: 0x0002126C File Offset: 0x0001F46C
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x170002BA RID: 698
			// (get) Token: 0x060008D0 RID: 2256 RVA: 0x00021280 File Offset: 0x0001F480
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._klassDummy;
				}
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x060008D1 RID: 2257 RVA: 0x00021290 File Offset: 0x0001F490
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x170002BC RID: 700
			// (get) Token: 0x060008D2 RID: 2258 RVA: 0x000212A4 File Offset: 0x0001F4A4
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x170002BD RID: 701
			// (get) Token: 0x060008D3 RID: 2259 RVA: 0x000212B8 File Offset: 0x0001F4B8
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x170002BE RID: 702
			// (get) Token: 0x060008D4 RID: 2260 RVA: 0x000212CC File Offset: 0x0001F4CC
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x170002BF RID: 703
			// (get) Token: 0x060008D5 RID: 2261 RVA: 0x000212E0 File Offset: 0x0001F4E0
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x170002C0 RID: 704
			// (get) Token: 0x060008D6 RID: 2262 RVA: 0x000212F4 File Offset: 0x0001F4F4
			// (set) Token: 0x060008D7 RID: 2263 RVA: 0x0002130C File Offset: 0x0001F50C
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_23_0.NativeStructWrapper.OO616lbLUNrbLwy7WFG(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_23_0.NativeStructWrapper.BJKaerbcYdVg3M73RnU(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b15bb2810b414d8fba6ffddaf7154f62 != 0)
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

			// Token: 0x170002C1 RID: 705
			// (get) Token: 0x060008D8 RID: 2264 RVA: 0x00021370 File Offset: 0x0001F570
			// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00021388 File Offset: 0x0001F588
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_23_0.NativeStructWrapper.OO616lbLUNrbLwy7WFG(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_23_0.NativeStructWrapper.BJKaerbcYdVg3M73RnU(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170002C2 RID: 706
			// (get) Token: 0x060008DA RID: 2266 RVA: 0x000213EC File Offset: 0x0001F5EC
			// (set) Token: 0x060008DB RID: 2267 RVA: 0x00021404 File Offset: 0x0001F604
			public bool EnumType
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 2);
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
							this.SetBit(NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_944294969d634011bf30e3f4f506a31e == 0)
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

			// Token: 0x170002C3 RID: 707
			// (get) Token: 0x060008DC RID: 2268 RVA: 0x00021468 File Offset: 0x0001F668
			// (set) Token: 0x060008DD RID: 2269 RVA: 0x00021480 File Offset: 0x0001F680
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_23_0.NativeStructWrapper.OO616lbLUNrbLwy7WFG(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 3);
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
							this.SetBit(NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40 != 0)
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

			// Token: 0x170002C4 RID: 708
			// (get) Token: 0x060008DE RID: 2270 RVA: 0x000214E4 File Offset: 0x0001F6E4
			// (set) Token: 0x060008DF RID: 2271 RVA: 0x000214FC File Offset: 0x0001F6FC
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_23_0.NativeStructWrapper.OO616lbLUNrbLwy7WFG(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 6);
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
							this.SetBit(NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc != 0)
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

			// Token: 0x170002C5 RID: 709
			// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00021560 File Offset: 0x0001F760
			// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00021578 File Offset: 0x0001F778
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_23_0.NativeStructWrapper.OO616lbLUNrbLwy7WFG(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_23_0.NativeStructWrapper.BJKaerbcYdVg3M73RnU(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fdb0528b1ef843aca29153aec62fa60d == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170002C6 RID: 710
			// (get) Token: 0x060008E2 RID: 2274 RVA: 0x000215DC File Offset: 0x0001F7DC
			// (set) Token: 0x060008E3 RID: 2275 RVA: 0x000215F4 File Offset: 0x0001F7F4
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_23_0.NativeStructWrapper.OO616lbLUNrbLwy7WFG(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 11);
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
							NativeClassStructHandler_23_0.NativeStructWrapper.BJKaerbcYdVg3M73RnU(this, NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset, 11, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_01c6e15d1fd54ef9b78826bf2944de2a != 0)
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

			// Token: 0x170002C7 RID: 711
			// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0002165C File Offset: 0x0001F85C
			// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00021668 File Offset: 0x0001F868
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

			// Token: 0x060008E6 RID: 2278 RVA: 0x00021674 File Offset: 0x0001F874
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
						NativeClassStructHandler_23_0.NativeStructWrapper.gUYdgUbRSD6vDsIB2aJ();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2b9d7065e34e71a0069eb107f69f59 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						NativeClassStructHandler_23_0.NativeStructWrapper.FrRXFCbEP8ByomGsQe5();
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6104a350572547c0a789887568cca07c == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						NativeClassStructHandler_23_0.NativeStructWrapper.c3DvXXb7FaNRxm6chHZ();
						num2 = 2;
						continue;
					case 4:
						return;
					case 5:
						NativeClassStructHandler_23_0.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 3;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2210d7ca22c24335b32d80ca3ef84b8e != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					intPtr = Marshal.OffsetOf<NativeClassStructHandler_23_0.Il2CppClass_23_0>(NativeClassStructHandler_23_0.NativeStructWrapper.VbI4GhbkV4aRUIfGqVg(~430829421 ^ -599560545 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2e7e5b018e46a2b3bb280ae243eb22));
					num2 = 3;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9cbee6d56f49422699718938ff979567 != 0)
					{
						num2 = 5;
					}
				}
			}

			// Token: 0x060008E7 RID: 2279 RVA: 0x00021788 File Offset: 0x0001F988
			internal static void FrRXFCbEP8ByomGsQe5()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060008E8 RID: 2280 RVA: 0x00021798 File Offset: 0x0001F998
			internal static bool G8ouFobNF9ZIMN4hK6p()
			{
				return NativeClassStructHandler_23_0.NativeStructWrapper.bAG6gxb04Ogt5HqtphI == null;
			}

			// Token: 0x060008E9 RID: 2281 RVA: 0x000217AC File Offset: 0x0001F9AC
			internal static NativeClassStructHandler_23_0.NativeStructWrapper K30Whjbup8d2RHy9ow9()
			{
				return NativeClassStructHandler_23_0.NativeStructWrapper.bAG6gxb04Ogt5HqtphI;
			}

			// Token: 0x060008EA RID: 2282 RVA: 0x000217BC File Offset: 0x0001F9BC
			internal static void BJKaerbcYdVg3M73RnU(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x060008EB RID: 2283 RVA: 0x000217DC File Offset: 0x0001F9DC
			internal static IntPtr EINXrxb6wnWMv8cFEkx(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x060008EC RID: 2284 RVA: 0x000217F8 File Offset: 0x0001F9F8
			internal static bool OO616lbLUNrbLwy7WFG(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060008ED RID: 2285 RVA: 0x00021814 File Offset: 0x0001FA14
			internal static void c3DvXXb7FaNRxm6chHZ()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x060008EE RID: 2286 RVA: 0x00021824 File Offset: 0x0001FA24
			internal static void gUYdgUbRSD6vDsIB2aJ()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x060008EF RID: 2287 RVA: 0x00021834 File Offset: 0x0001FA34
			internal static object VbI4GhbkV4aRUIfGqVg(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x0400056E RID: 1390
			private static readonly int _bitfield0offset;

			// Token: 0x0400056F RID: 1391
			private unsafe Il2CppClass* _klassDummy;

			// Token: 0x04000571 RID: 1393
			private static object bAG6gxb04Ogt5HqtphI;
		}
	}
}
