using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000DB RID: 219
	[ApplicableToUnityVersionsSince("2018.1.0")]
	public class NativeClassStructHandler_24_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x060008D1 RID: 2257 RVA: 0x0001120C File Offset: 0x0000F40C
		public int Size()
		{
			return sizeof(NativeClassStructHandler_24_0.Il2CppClass_24_0);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0001121C File Offset: 0x0000F41C
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_24_0.Il2CppClass_24_0* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_24_0.Cpkwvay2ue9q2q6wRMt(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_24_0.Il2CppClass_24_0);
			return new NativeClassStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00011254 File Offset: 0x0000F454
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2356ac6ca5954f1897cd5bbbe0161ae5 == 0)
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
			return new NativeClassStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x000112BC File Offset: 0x0000F4BC
		public NativeClassStructHandler_24_0()
		{
			NativeClassStructHandler_24_0.v38nK4yHb2D45TqGMjA();
			NativeClassStructHandler_24_0.htLKLhyhifQGBo7psUo();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_da5aa2d475094b06a3df3cc53bc85956 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00011320 File Offset: 0x0000F520
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_24_0()
		{
			NativeClassStructHandler_24_0.o3dNQHyO4lb1cwUljXl();
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00011330 File Offset: 0x0000F530
		internal static IntPtr Cpkwvay2ue9q2q6wRMt(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00011344 File Offset: 0x0000F544
		internal static bool vOlXWbycDTYDXHDbEXj()
		{
			return NativeClassStructHandler_24_0.CBfE7eyXNYMhcq9U6Ph == null;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00011358 File Offset: 0x0000F558
		internal static NativeClassStructHandler_24_0 feWs7gykU5vdR3BKaBQ()
		{
			return NativeClassStructHandler_24_0.CBfE7eyXNYMhcq9U6Ph;
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00011368 File Offset: 0x0000F568
		internal static void v38nK4yHb2D45TqGMjA()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00011378 File Offset: 0x0000F578
		internal static void htLKLhyhifQGBo7psUo()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00011388 File Offset: 0x0000F588
		internal static void o3dNQHyO4lb1cwUljXl()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000567 RID: 1383
		private static NativeClassStructHandler_24_0 CBfE7eyXNYMhcq9U6Ph;

		// Token: 0x020000DC RID: 220
		internal struct Il2CppClass_24_0
		{
			// Token: 0x04000568 RID: 1384
			public unsafe Il2CppImage* image;

			// Token: 0x04000569 RID: 1385
			public unsafe void* gc_desc;

			// Token: 0x0400056A RID: 1386
			public unsafe byte* name;

			// Token: 0x0400056B RID: 1387
			public unsafe byte* namespaze;

			// Token: 0x0400056C RID: 1388
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 byval_arg;

			// Token: 0x0400056D RID: 1389
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 this_arg;

			// Token: 0x0400056E RID: 1390
			public unsafe Il2CppClass* element_class;

			// Token: 0x0400056F RID: 1391
			public unsafe Il2CppClass* castClass;

			// Token: 0x04000570 RID: 1392
			public unsafe Il2CppClass* declaringType;

			// Token: 0x04000571 RID: 1393
			public unsafe Il2CppClass* parent;

			// Token: 0x04000572 RID: 1394
			public unsafe void* generic_class;

			// Token: 0x04000573 RID: 1395
			public unsafe void* typeDefinition;

			// Token: 0x04000574 RID: 1396
			public unsafe void* interopData;

			// Token: 0x04000575 RID: 1397
			public unsafe Il2CppClass* klass;

			// Token: 0x04000576 RID: 1398
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x04000577 RID: 1399
			public unsafe Il2CppEventInfo* events;

			// Token: 0x04000578 RID: 1400
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000579 RID: 1401
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x0400057A RID: 1402
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x0400057B RID: 1403
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x0400057C RID: 1404
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x0400057D RID: 1405
			public unsafe void* static_fields;

			// Token: 0x0400057E RID: 1406
			public unsafe void* rgctx_data;

			// Token: 0x0400057F RID: 1407
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x04000580 RID: 1408
			public uint cctor_started;

			// Token: 0x04000581 RID: 1409
			public uint cctor_finished;

			// Token: 0x04000582 RID: 1410
			public ulong cctor_thread;

			// Token: 0x04000583 RID: 1411
			public int genericContainerIndex;

			// Token: 0x04000584 RID: 1412
			public int customAttributeIndex;

			// Token: 0x04000585 RID: 1413
			public uint instance_size;

			// Token: 0x04000586 RID: 1414
			public uint actualSize;

			// Token: 0x04000587 RID: 1415
			public uint element_size;

			// Token: 0x04000588 RID: 1416
			public int native_size;

			// Token: 0x04000589 RID: 1417
			public uint static_fields_size;

			// Token: 0x0400058A RID: 1418
			public uint thread_static_fields_size;

			// Token: 0x0400058B RID: 1419
			public int thread_static_fields_offset;

			// Token: 0x0400058C RID: 1420
			public uint flags;

			// Token: 0x0400058D RID: 1421
			public uint token;

			// Token: 0x0400058E RID: 1422
			public ushort method_count;

			// Token: 0x0400058F RID: 1423
			public ushort property_count;

			// Token: 0x04000590 RID: 1424
			public ushort field_count;

			// Token: 0x04000591 RID: 1425
			public ushort event_count;

			// Token: 0x04000592 RID: 1426
			public ushort nested_type_count;

			// Token: 0x04000593 RID: 1427
			public ushort vtable_count;

			// Token: 0x04000594 RID: 1428
			public ushort interfaces_count;

			// Token: 0x04000595 RID: 1429
			public ushort interface_offsets_count;

			// Token: 0x04000596 RID: 1430
			public byte typeHierarchyDepth;

			// Token: 0x04000597 RID: 1431
			public byte genericRecursionDepth;

			// Token: 0x04000598 RID: 1432
			public byte rank;

			// Token: 0x04000599 RID: 1433
			public byte minimumAlignment;

			// Token: 0x0400059A RID: 1434
			public byte packingSize;

			// Token: 0x0400059B RID: 1435
			public NativeClassStructHandler_24_0.Il2CppClass_24_0.Bitfield0 _bitfield0;

			// Token: 0x020000DD RID: 221
			internal enum Bitfield0 : ushort
			{
				// Token: 0x0400059D RID: 1437
				BIT_valuetype,
				// Token: 0x0400059E RID: 1438
				valuetype,
				// Token: 0x0400059F RID: 1439
				BIT_initialized = 1,
				// Token: 0x040005A0 RID: 1440
				initialized,
				// Token: 0x040005A1 RID: 1441
				BIT_enumtype = 2,
				// Token: 0x040005A2 RID: 1442
				enumtype = 4,
				// Token: 0x040005A3 RID: 1443
				BIT_is_generic = 3,
				// Token: 0x040005A4 RID: 1444
				is_generic = 8,
				// Token: 0x040005A5 RID: 1445
				BIT_has_references = 4,
				// Token: 0x040005A6 RID: 1446
				has_references = 16,
				// Token: 0x040005A7 RID: 1447
				BIT_init_pending = 5,
				// Token: 0x040005A8 RID: 1448
				init_pending = 32,
				// Token: 0x040005A9 RID: 1449
				BIT_size_inited = 6,
				// Token: 0x040005AA RID: 1450
				size_inited = 64,
				// Token: 0x040005AB RID: 1451
				BIT_has_finalize = 7,
				// Token: 0x040005AC RID: 1452
				has_finalize = 128,
				// Token: 0x040005AD RID: 1453
				BIT_has_cctor = 8,
				// Token: 0x040005AE RID: 1454
				has_cctor = 256,
				// Token: 0x040005AF RID: 1455
				BIT_is_blittable = 9,
				// Token: 0x040005B0 RID: 1456
				is_blittable = 512,
				// Token: 0x040005B1 RID: 1457
				BIT_is_import_or_windows_runtime = 10,
				// Token: 0x040005B2 RID: 1458
				is_import_or_windows_runtime = 1024,
				// Token: 0x040005B3 RID: 1459
				BIT_is_vtable_initialized = 11,
				// Token: 0x040005B4 RID: 1460
				is_vtable_initialized = 2048
			}
		}

		// Token: 0x020000DE RID: 222
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x060008DC RID: 2268 RVA: 0x00020BD0 File Offset: 0x0001EDD0
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_24_0.NativeStructWrapper.hhl4DB75bBxTfdFRD35();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b1a14f54e3674a8baf7d5ab6ab85764a != 0)
				{
					num = 1;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.<Pointer>k__BackingField = ptr;
						num = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x170002C8 RID: 712
			// (get) Token: 0x060008DD RID: 2269 RVA: 0x00020C60 File Offset: 0x0001EE60
			private unsafe NativeClassStructHandler_24_0.Il2CppClass_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170002C9 RID: 713
			// (get) Token: 0x060008DE RID: 2270 RVA: 0x00020C70 File Offset: 0x0001EE70
			// (set) Token: 0x060008DF RID: 2271 RVA: 0x00020C88 File Offset: 0x0001EE88
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_24_0.NativeStructWrapper.K0idcI7AXqBKCLRUNHO(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 4);
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
							this.SetBit(NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 4, value);
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

			// Token: 0x170002CA RID: 714
			// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00020CEC File Offset: 0x0001EEEC
			public IntPtr Pointer { get; }

			// Token: 0x170002CB RID: 715
			// (get) Token: 0x060008E1 RID: 2273 RVA: 0x00020CFC File Offset: 0x0001EEFC
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_24_0.NativeStructWrapper.jIXRIY7LBBVIfyrtk52(this.Pointer, sizeof(NativeClassStructHandler_24_0.Il2CppClass_24_0), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x170002CC RID: 716
			// (get) Token: 0x060008E2 RID: 2274 RVA: 0x00020D1C File Offset: 0x0001EF1C
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170002CD RID: 717
			// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00020D2C File Offset: 0x0001EF2C
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x170002CE RID: 718
			// (get) Token: 0x060008E4 RID: 2276 RVA: 0x00020D48 File Offset: 0x0001EF48
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x170002CF RID: 719
			// (get) Token: 0x060008E5 RID: 2277 RVA: 0x00020D64 File Offset: 0x0001EF64
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x170002D0 RID: 720
			// (get) Token: 0x060008E6 RID: 2278 RVA: 0x00020D78 File Offset: 0x0001EF78
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x170002D1 RID: 721
			// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00020D8C File Offset: 0x0001EF8C
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x170002D2 RID: 722
			// (get) Token: 0x060008E8 RID: 2280 RVA: 0x00020DA0 File Offset: 0x0001EFA0
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x170002D3 RID: 723
			// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00020DB4 File Offset: 0x0001EFB4
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x170002D4 RID: 724
			// (get) Token: 0x060008EA RID: 2282 RVA: 0x00020DC8 File Offset: 0x0001EFC8
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x170002D5 RID: 725
			// (get) Token: 0x060008EB RID: 2283 RVA: 0x00020DDC File Offset: 0x0001EFDC
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x170002D6 RID: 726
			// (get) Token: 0x060008EC RID: 2284 RVA: 0x00020DF0 File Offset: 0x0001EFF0
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x170002D7 RID: 727
			// (get) Token: 0x060008ED RID: 2285 RVA: 0x00020E04 File Offset: 0x0001F004
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x170002D8 RID: 728
			// (get) Token: 0x060008EE RID: 2286 RVA: 0x00020E18 File Offset: 0x0001F018
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x170002D9 RID: 729
			// (get) Token: 0x060008EF RID: 2287 RVA: 0x00020E30 File Offset: 0x0001F030
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170002DA RID: 730
			// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00020E48 File Offset: 0x0001F048
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x170002DB RID: 731
			// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00020E60 File Offset: 0x0001F060
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x170002DC RID: 732
			// (get) Token: 0x060008F2 RID: 2290 RVA: 0x00020E74 File Offset: 0x0001F074
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x170002DD RID: 733
			// (get) Token: 0x060008F3 RID: 2291 RVA: 0x00020E88 File Offset: 0x0001F088
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x170002DE RID: 734
			// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00020E9C File Offset: 0x0001F09C
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x170002DF RID: 735
			// (get) Token: 0x060008F5 RID: 2293 RVA: 0x00020EB0 File Offset: 0x0001F0B0
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x170002E0 RID: 736
			// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00020EC4 File Offset: 0x0001F0C4
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x170002E1 RID: 737
			// (get) Token: 0x060008F7 RID: 2295 RVA: 0x00020ED8 File Offset: 0x0001F0D8
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x170002E2 RID: 738
			// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00020EEC File Offset: 0x0001F0EC
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x170002E3 RID: 739
			// (get) Token: 0x060008F9 RID: 2297 RVA: 0x00020F00 File Offset: 0x0001F100
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x170002E4 RID: 740
			// (get) Token: 0x060008FA RID: 2298 RVA: 0x00020F14 File Offset: 0x0001F114
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x170002E5 RID: 741
			// (get) Token: 0x060008FB RID: 2299 RVA: 0x00020F28 File Offset: 0x0001F128
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x170002E6 RID: 742
			// (get) Token: 0x060008FC RID: 2300 RVA: 0x00020F3C File Offset: 0x0001F13C
			// (set) Token: 0x060008FD RID: 2301 RVA: 0x00020F54 File Offset: 0x0001F154
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_24_0.NativeStructWrapper.K0idcI7AXqBKCLRUNHO(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 0);
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
							this.SetBit(NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_124ad935e0834fda9ae7f452377dbe1c == 0)
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

			// Token: 0x170002E7 RID: 743
			// (get) Token: 0x060008FE RID: 2302 RVA: 0x00020FB8 File Offset: 0x0001F1B8
			// (set) Token: 0x060008FF RID: 2303 RVA: 0x00020FD0 File Offset: 0x0001F1D0
			public bool Initialized
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_24_0.NativeStructWrapper.MDBMtE7XOb2MAbfB453(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_791a252a9221476faad2c6d41e84a167 == 0)
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

			// Token: 0x170002E8 RID: 744
			// (get) Token: 0x06000900 RID: 2304 RVA: 0x00021034 File Offset: 0x0001F234
			// (set) Token: 0x06000901 RID: 2305 RVA: 0x0002104C File Offset: 0x0001F24C
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_24_0.NativeStructWrapper.K0idcI7AXqBKCLRUNHO(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 2);
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
							this.SetBit(NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_1f1b1b07c9f5435991b0738ea3210852 != 0)
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

			// Token: 0x170002E9 RID: 745
			// (get) Token: 0x06000902 RID: 2306 RVA: 0x000210B0 File Offset: 0x0001F2B0
			// (set) Token: 0x06000903 RID: 2307 RVA: 0x000210C8 File Offset: 0x0001F2C8
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_24_0.NativeStructWrapper.K0idcI7AXqBKCLRUNHO(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 3);
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
							this.SetBit(NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e19113368d2b45ba8f9d5ebaa49ce5d2 != 0)
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

			// Token: 0x170002EA RID: 746
			// (get) Token: 0x06000904 RID: 2308 RVA: 0x0002112C File Offset: 0x0001F32C
			// (set) Token: 0x06000905 RID: 2309 RVA: 0x00021144 File Offset: 0x0001F344
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_24_0.NativeStructWrapper.K0idcI7AXqBKCLRUNHO(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 6);
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
							NativeClassStructHandler_24_0.NativeStructWrapper.MDBMtE7XOb2MAbfB453(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3e2009ed69c04f5799431b4e58cafb2a == 0)
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

			// Token: 0x170002EB RID: 747
			// (get) Token: 0x06000906 RID: 2310 RVA: 0x000211A8 File Offset: 0x0001F3A8
			// (set) Token: 0x06000907 RID: 2311 RVA: 0x000211C0 File Offset: 0x0001F3C0
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_24_0.NativeStructWrapper.K0idcI7AXqBKCLRUNHO(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_24_0.NativeStructWrapper.MDBMtE7XOb2MAbfB453(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_64a8b41e58e0491ab0e9d05ec5ed61d3 == 0)
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

			// Token: 0x170002EC RID: 748
			// (get) Token: 0x06000908 RID: 2312 RVA: 0x00021224 File Offset: 0x0001F424
			// (set) Token: 0x06000909 RID: 2313 RVA: 0x0002123C File Offset: 0x0001F43C
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_24_0.NativeStructWrapper.K0idcI7AXqBKCLRUNHO(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 11);
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
							NativeClassStructHandler_24_0.NativeStructWrapper.MDBMtE7XOb2MAbfB453(this, NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset, 11, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_9f61d52c010d488b818a577e37d289c0 == 0)
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

			// Token: 0x170002ED RID: 749
			// (get) Token: 0x0600090A RID: 2314 RVA: 0x000212A4 File Offset: 0x0001F4A4
			// (set) Token: 0x0600090B RID: 2315 RVA: 0x000212B0 File Offset: 0x0001F4B0
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

			// Token: 0x0600090C RID: 2316 RVA: 0x000212BC File Offset: 0x0001F4BC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 5;
				int num2 = num;
				for (;;)
				{
					IntPtr intPtr;
					switch (num2)
					{
					case 1:
						nHwRpygmi6xxZAssJn.EmlEpH4Phw();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8160363759e64728b1ce193157380515 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						NativeClassStructHandler_24_0.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 2;
						continue;
					case 4:
						NativeClassStructHandler_24_0.NativeStructWrapper.hhl4DB75bBxTfdFRD35();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e19113368d2b45ba8f9d5ebaa49ce5d2 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 5:
						NativeClassStructHandler_24_0.NativeStructWrapper.iT8wyw7cIKSBLJm2ngP();
						num2 = 4;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6fe1694df7b94e7bbaa2aab21c6a82ec == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					intPtr = Marshal.OffsetOf<NativeClassStructHandler_24_0.Il2CppClass_24_0>(NativeClassStructHandler_24_0.NativeStructWrapper.EGOQgi7kCojfrDFwOFM(~-331621286 ^ 804928208 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b544c260d8647ebad150746ba137290));
					num2 = 3;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ff3063f9530e4a429cd27a548ab9d19d == 0)
					{
						num2 = 3;
					}
				}
			}

			// Token: 0x0600090D RID: 2317 RVA: 0x000213D0 File Offset: 0x0001F5D0
			internal static void hhl4DB75bBxTfdFRD35()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600090E RID: 2318 RVA: 0x000213E0 File Offset: 0x0001F5E0
			internal static bool VVmwEF7labbk5d16HOJ()
			{
				return NativeClassStructHandler_24_0.NativeStructWrapper.gURWw9mzxM40MQesQi8 == null;
			}

			// Token: 0x0600090F RID: 2319 RVA: 0x000213F4 File Offset: 0x0001F5F4
			internal static NativeClassStructHandler_24_0.NativeStructWrapper qqhEyb7qsVuQ5Dxn06p()
			{
				return NativeClassStructHandler_24_0.NativeStructWrapper.gURWw9mzxM40MQesQi8;
			}

			// Token: 0x06000910 RID: 2320 RVA: 0x00021404 File Offset: 0x0001F604
			internal static bool K0idcI7AXqBKCLRUNHO(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000911 RID: 2321 RVA: 0x00021420 File Offset: 0x0001F620
			internal static IntPtr jIXRIY7LBBVIfyrtk52(IntPtr A_0, int A_1, object A_2)
			{
				return apS1BFcfBa3gXUspL9j.muOq5LWqgj(A_0, A_1, A_2);
			}

			// Token: 0x06000912 RID: 2322 RVA: 0x0002143C File Offset: 0x0001F63C
			internal static void MDBMtE7XOb2MAbfB453(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000913 RID: 2323 RVA: 0x0002145C File Offset: 0x0001F65C
			internal static void iT8wyw7cIKSBLJm2ngP()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000914 RID: 2324 RVA: 0x0002146C File Offset: 0x0001F66C
			internal static object EGOQgi7kCojfrDFwOFM(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x040005B5 RID: 1461
			private static readonly int _bitfield0offset;

			// Token: 0x040005B7 RID: 1463
			private static object gURWw9mzxM40MQesQi8;
		}
	}
}
