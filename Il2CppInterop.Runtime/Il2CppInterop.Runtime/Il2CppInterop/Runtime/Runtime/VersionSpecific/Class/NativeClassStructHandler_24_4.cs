using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000EB RID: 235
	[ApplicableToUnityVersionsSince("2019.1.0")]
	public class NativeClassStructHandler_24_4 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x060009DF RID: 2527 RVA: 0x0001181C File Offset: 0x0000FA1C
		public int Size()
		{
			return sizeof(NativeClassStructHandler_24_4.Il2CppClass_24_4);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0001182C File Offset: 0x0000FA2C
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_24_4.Il2CppClass_24_4* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_24_4.Il2CppClass_24_4);
			return new NativeClassStructHandler_24_4.NativeStructWrapper(ptr);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00011864 File Offset: 0x0000FA64
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_faca03c2e5084297b7a5d894ac66fa57 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeClassStructHandler_24_4.NativeStructWrapper(ptr);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x000118CC File Offset: 0x0000FACC
		public NativeClassStructHandler_24_4()
		{
			NativeClassStructHandler_24_4.sGZeWfy3igJh9Udd5iA();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb8decd62b945dda713f7b22b6b95ca != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00011930 File Offset: 0x0000FB30
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_24_4()
		{
			NativeClassStructHandler_24_4.OuHaO1yfBqayVPnxix1();
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00011940 File Offset: 0x0000FB40
		internal static bool KfHLmHyPKJ8dWNfUcjE()
		{
			return NativeClassStructHandler_24_4.xoADCby7L7VmhuxW1PJ == null;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00011954 File Offset: 0x0000FB54
		internal static NativeClassStructHandler_24_4 vAgsAgy4HqxtU3m3PnY()
		{
			return NativeClassStructHandler_24_4.xoADCby7L7VmhuxW1PJ;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00011964 File Offset: 0x0000FB64
		internal static void sGZeWfy3igJh9Udd5iA()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00011974 File Offset: 0x0000FB74
		internal static void OuHaO1yfBqayVPnxix1()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040006B7 RID: 1719
		private static NativeClassStructHandler_24_4 xoADCby7L7VmhuxW1PJ;

		// Token: 0x020000EC RID: 236
		internal struct Il2CppClass_24_4
		{
			// Token: 0x040006B8 RID: 1720
			public unsafe Il2CppImage* image;

			// Token: 0x040006B9 RID: 1721
			public unsafe void* gc_desc;

			// Token: 0x040006BA RID: 1722
			public unsafe byte* name;

			// Token: 0x040006BB RID: 1723
			public unsafe byte* namespaze;

			// Token: 0x040006BC RID: 1724
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 byval_arg;

			// Token: 0x040006BD RID: 1725
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 this_arg;

			// Token: 0x040006BE RID: 1726
			public unsafe Il2CppClass* element_class;

			// Token: 0x040006BF RID: 1727
			public unsafe Il2CppClass* castClass;

			// Token: 0x040006C0 RID: 1728
			public unsafe Il2CppClass* declaringType;

			// Token: 0x040006C1 RID: 1729
			public unsafe Il2CppClass* parent;

			// Token: 0x040006C2 RID: 1730
			public unsafe void* generic_class;

			// Token: 0x040006C3 RID: 1731
			public unsafe void* typeDefinition;

			// Token: 0x040006C4 RID: 1732
			public unsafe void* interopData;

			// Token: 0x040006C5 RID: 1733
			public unsafe Il2CppClass* klass;

			// Token: 0x040006C6 RID: 1734
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x040006C7 RID: 1735
			public unsafe Il2CppEventInfo* events;

			// Token: 0x040006C8 RID: 1736
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x040006C9 RID: 1737
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x040006CA RID: 1738
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x040006CB RID: 1739
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x040006CC RID: 1740
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x040006CD RID: 1741
			public unsafe void* static_fields;

			// Token: 0x040006CE RID: 1742
			public unsafe void* rgctx_data;

			// Token: 0x040006CF RID: 1743
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x040006D0 RID: 1744
			public unsafe void* unity_user_data;

			// Token: 0x040006D1 RID: 1745
			public uint initializationExceptionGCHandle;

			// Token: 0x040006D2 RID: 1746
			public uint cctor_started;

			// Token: 0x040006D3 RID: 1747
			public uint cctor_finished;

			// Token: 0x040006D4 RID: 1748
			public IntPtr cctor_thread;

			// Token: 0x040006D5 RID: 1749
			public int genericContainerIndex;

			// Token: 0x040006D6 RID: 1750
			public uint instance_size;

			// Token: 0x040006D7 RID: 1751
			public uint actualSize;

			// Token: 0x040006D8 RID: 1752
			public uint element_size;

			// Token: 0x040006D9 RID: 1753
			public int native_size;

			// Token: 0x040006DA RID: 1754
			public uint static_fields_size;

			// Token: 0x040006DB RID: 1755
			public uint thread_static_fields_size;

			// Token: 0x040006DC RID: 1756
			public int thread_static_fields_offset;

			// Token: 0x040006DD RID: 1757
			public uint flags;

			// Token: 0x040006DE RID: 1758
			public uint token;

			// Token: 0x040006DF RID: 1759
			public ushort method_count;

			// Token: 0x040006E0 RID: 1760
			public ushort property_count;

			// Token: 0x040006E1 RID: 1761
			public ushort field_count;

			// Token: 0x040006E2 RID: 1762
			public ushort event_count;

			// Token: 0x040006E3 RID: 1763
			public ushort nested_type_count;

			// Token: 0x040006E4 RID: 1764
			public ushort vtable_count;

			// Token: 0x040006E5 RID: 1765
			public ushort interfaces_count;

			// Token: 0x040006E6 RID: 1766
			public ushort interface_offsets_count;

			// Token: 0x040006E7 RID: 1767
			public byte typeHierarchyDepth;

			// Token: 0x040006E8 RID: 1768
			public byte genericRecursionDepth;

			// Token: 0x040006E9 RID: 1769
			public byte rank;

			// Token: 0x040006EA RID: 1770
			public byte minimumAlignment;

			// Token: 0x040006EB RID: 1771
			public byte naturalAligment;

			// Token: 0x040006EC RID: 1772
			public byte packingSize;

			// Token: 0x040006ED RID: 1773
			public NativeClassStructHandler_24_4.Il2CppClass_24_4.Bitfield0 _bitfield0;

			// Token: 0x020000ED RID: 237
			internal enum Bitfield0 : ushort
			{
				// Token: 0x040006EF RID: 1775
				BIT_initialized_and_no_error,
				// Token: 0x040006F0 RID: 1776
				initialized_and_no_error,
				// Token: 0x040006F1 RID: 1777
				BIT_valuetype = 1,
				// Token: 0x040006F2 RID: 1778
				valuetype,
				// Token: 0x040006F3 RID: 1779
				BIT_initialized = 2,
				// Token: 0x040006F4 RID: 1780
				initialized = 4,
				// Token: 0x040006F5 RID: 1781
				BIT_enumtype = 3,
				// Token: 0x040006F6 RID: 1782
				enumtype = 8,
				// Token: 0x040006F7 RID: 1783
				BIT_is_generic = 4,
				// Token: 0x040006F8 RID: 1784
				is_generic = 16,
				// Token: 0x040006F9 RID: 1785
				BIT_has_references = 5,
				// Token: 0x040006FA RID: 1786
				has_references = 32,
				// Token: 0x040006FB RID: 1787
				BIT_init_pending = 6,
				// Token: 0x040006FC RID: 1788
				init_pending = 64,
				// Token: 0x040006FD RID: 1789
				BIT_size_inited = 7,
				// Token: 0x040006FE RID: 1790
				size_inited = 128,
				// Token: 0x040006FF RID: 1791
				BIT_has_finalize = 8,
				// Token: 0x04000700 RID: 1792
				has_finalize = 256,
				// Token: 0x04000701 RID: 1793
				BIT_has_cctor = 9,
				// Token: 0x04000702 RID: 1794
				has_cctor = 512,
				// Token: 0x04000703 RID: 1795
				BIT_is_blittable = 10,
				// Token: 0x04000704 RID: 1796
				is_blittable = 1024,
				// Token: 0x04000705 RID: 1797
				BIT_is_import_or_windows_runtime = 11,
				// Token: 0x04000706 RID: 1798
				is_import_or_windows_runtime = 2048,
				// Token: 0x04000707 RID: 1799
				BIT_is_vtable_initialized = 12,
				// Token: 0x04000708 RID: 1800
				is_vtable_initialized = 4096,
				// Token: 0x04000709 RID: 1801
				BIT_has_initialization_error = 13,
				// Token: 0x0400070A RID: 1802
				has_initialization_error = 8192
			}
		}

		// Token: 0x020000EE RID: 238
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x060009E8 RID: 2536 RVA: 0x00022F00 File Offset: 0x00021100
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_24_4.NativeStructWrapper.veRTLS7rYkJR1dVFFJO();
				NativeClassStructHandler_24_4.NativeStructWrapper.gAuFxY7TYfsunCmANrY();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_dd9c757bd882429784d62f0e80f112e6 != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92a7d78565474619a2c93ca9aa734139 != 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x17000360 RID: 864
			// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00022F90 File Offset: 0x00021190
			private unsafe NativeClassStructHandler_24_4.Il2CppClass_24_4* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000361 RID: 865
			// (get) Token: 0x060009EA RID: 2538 RVA: 0x00022FA0 File Offset: 0x000211A0
			// (set) Token: 0x060009EB RID: 2539 RVA: 0x00022FB8 File Offset: 0x000211B8
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_24_4.NativeStructWrapper.Qenpyj7ggdpUE5g7X1P(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 5);
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
							this.SetBit(NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 5, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4da80845ebf7410ebbf942336f5ee27b == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000362 RID: 866
			// (get) Token: 0x060009EC RID: 2540 RVA: 0x0002301C File Offset: 0x0002121C
			public IntPtr Pointer { get; }

			// Token: 0x17000363 RID: 867
			// (get) Token: 0x060009ED RID: 2541 RVA: 0x0002302C File Offset: 0x0002122C
			public IntPtr VTable
			{
				get
				{
					return apS1BFcfBa3gXUspL9j.muOq5LWqgj(this.Pointer, sizeof(NativeClassStructHandler_24_4.Il2CppClass_24_4), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x17000364 RID: 868
			// (get) Token: 0x060009EE RID: 2542 RVA: 0x0002304C File Offset: 0x0002124C
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000365 RID: 869
			// (get) Token: 0x060009EF RID: 2543 RVA: 0x0002305C File Offset: 0x0002125C
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x17000366 RID: 870
			// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00023078 File Offset: 0x00021278
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x17000367 RID: 871
			// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00023094 File Offset: 0x00021294
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x17000368 RID: 872
			// (get) Token: 0x060009F2 RID: 2546 RVA: 0x000230A8 File Offset: 0x000212A8
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x17000369 RID: 873
			// (get) Token: 0x060009F3 RID: 2547 RVA: 0x000230BC File Offset: 0x000212BC
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x1700036A RID: 874
			// (get) Token: 0x060009F4 RID: 2548 RVA: 0x000230D0 File Offset: 0x000212D0
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x1700036B RID: 875
			// (get) Token: 0x060009F5 RID: 2549 RVA: 0x000230E4 File Offset: 0x000212E4
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x1700036C RID: 876
			// (get) Token: 0x060009F6 RID: 2550 RVA: 0x000230F8 File Offset: 0x000212F8
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x1700036D RID: 877
			// (get) Token: 0x060009F7 RID: 2551 RVA: 0x0002310C File Offset: 0x0002130C
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x1700036E RID: 878
			// (get) Token: 0x060009F8 RID: 2552 RVA: 0x00023120 File Offset: 0x00021320
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x1700036F RID: 879
			// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00023134 File Offset: 0x00021334
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x17000370 RID: 880
			// (get) Token: 0x060009FA RID: 2554 RVA: 0x00023148 File Offset: 0x00021348
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x17000371 RID: 881
			// (get) Token: 0x060009FB RID: 2555 RVA: 0x00023160 File Offset: 0x00021360
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000372 RID: 882
			// (get) Token: 0x060009FC RID: 2556 RVA: 0x00023178 File Offset: 0x00021378
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x17000373 RID: 883
			// (get) Token: 0x060009FD RID: 2557 RVA: 0x00023190 File Offset: 0x00021390
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x17000374 RID: 884
			// (get) Token: 0x060009FE RID: 2558 RVA: 0x000231A4 File Offset: 0x000213A4
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000375 RID: 885
			// (get) Token: 0x060009FF RID: 2559 RVA: 0x000231B8 File Offset: 0x000213B8
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x17000376 RID: 886
			// (get) Token: 0x06000A00 RID: 2560 RVA: 0x000231CC File Offset: 0x000213CC
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x17000377 RID: 887
			// (get) Token: 0x06000A01 RID: 2561 RVA: 0x000231E0 File Offset: 0x000213E0
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x17000378 RID: 888
			// (get) Token: 0x06000A02 RID: 2562 RVA: 0x000231F4 File Offset: 0x000213F4
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x17000379 RID: 889
			// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00023208 File Offset: 0x00021408
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x1700037A RID: 890
			// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0002321C File Offset: 0x0002141C
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x1700037B RID: 891
			// (get) Token: 0x06000A05 RID: 2565 RVA: 0x00023230 File Offset: 0x00021430
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x1700037C RID: 892
			// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00023244 File Offset: 0x00021444
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x1700037D RID: 893
			// (get) Token: 0x06000A07 RID: 2567 RVA: 0x00023258 File Offset: 0x00021458
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x1700037E RID: 894
			// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0002326C File Offset: 0x0002146C
			// (set) Token: 0x06000A09 RID: 2569 RVA: 0x00023284 File Offset: 0x00021484
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_24_4.NativeStructWrapper.Qenpyj7ggdpUE5g7X1P(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 1);
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
							this.SetBit(NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_11d7514559f14fcba52669ac71e3cb39 != 0)
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

			// Token: 0x1700037F RID: 895
			// (get) Token: 0x06000A0A RID: 2570 RVA: 0x000232E8 File Offset: 0x000214E8
			// (set) Token: 0x06000A0B RID: 2571 RVA: 0x00023300 File Offset: 0x00021500
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_24_4.NativeStructWrapper.Qenpyj7ggdpUE5g7X1P(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 2);
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
							this.SetBit(NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 2, value);
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

			// Token: 0x17000380 RID: 896
			// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00023364 File Offset: 0x00021564
			// (set) Token: 0x06000A0D RID: 2573 RVA: 0x0002337C File Offset: 0x0002157C
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_24_4.NativeStructWrapper.Qenpyj7ggdpUE5g7X1P(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_24_4.NativeStructWrapper.q4cYI67omSDtJoMVhe8(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae != 0)
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

			// Token: 0x17000381 RID: 897
			// (get) Token: 0x06000A0E RID: 2574 RVA: 0x000233E0 File Offset: 0x000215E0
			// (set) Token: 0x06000A0F RID: 2575 RVA: 0x000233F8 File Offset: 0x000215F8
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_24_4.NativeStructWrapper.Qenpyj7ggdpUE5g7X1P(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_24_4.NativeStructWrapper.q4cYI67omSDtJoMVhe8(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6776fc69415b4d309be658e7e8ac3a28 == 0)
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

			// Token: 0x17000382 RID: 898
			// (get) Token: 0x06000A10 RID: 2576 RVA: 0x0002345C File Offset: 0x0002165C
			// (set) Token: 0x06000A11 RID: 2577 RVA: 0x00023474 File Offset: 0x00021674
			public bool SizeInited
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_24_4.NativeStructWrapper.q4cYI67omSDtJoMVhe8(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2356ac6ca5954f1897cd5bbbe0161ae5 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000383 RID: 899
			// (get) Token: 0x06000A12 RID: 2578 RVA: 0x000234D8 File Offset: 0x000216D8
			// (set) Token: 0x06000A13 RID: 2579 RVA: 0x000234F0 File Offset: 0x000216F0
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_24_4.NativeStructWrapper.Qenpyj7ggdpUE5g7X1P(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 8);
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
							NativeClassStructHandler_24_4.NativeStructWrapper.q4cYI67omSDtJoMVhe8(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 8, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000384 RID: 900
			// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00023554 File Offset: 0x00021754
			// (set) Token: 0x06000A15 RID: 2581 RVA: 0x0002356C File Offset: 0x0002176C
			public bool IsVtableInitialized
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 12);
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
							this.SetBit(NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 12, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7b01772eb8964b6a81d74c3d1c2f871e == 0)
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

			// Token: 0x17000385 RID: 901
			// (get) Token: 0x06000A16 RID: 2582 RVA: 0x000235D4 File Offset: 0x000217D4
			// (set) Token: 0x06000A17 RID: 2583 RVA: 0x000235EC File Offset: 0x000217EC
			public bool InitializedAndNoError
			{
				get
				{
					return NativeClassStructHandler_24_4.NativeStructWrapper.Qenpyj7ggdpUE5g7X1P(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_24_4.NativeStructWrapper.q4cYI67omSDtJoMVhe8(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_26479210ae524f22ae1fe060a08fdd55 == 0)
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

			// Token: 0x06000A18 RID: 2584 RVA: 0x00023650 File Offset: 0x00021850
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 4;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
					{
						IntPtr intPtr;
						NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 5;
						continue;
					}
					case 2:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_24_4.Il2CppClass_24_4>(NativeClassStructHandler_24_4.NativeStructWrapper.vilMSx7jPUTFVpgPVm6(-141486901 ^ -1130384863 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bac7568f2bc04130b6b980225b2cc409));
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_457365959f004478ad0e311bf72b3912 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					case 3:
						NativeClassStructHandler_24_4.NativeStructWrapper.veRTLS7rYkJR1dVFFJO();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb34a81d7cc4fbea898664370a8645f != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						NativeClassStructHandler_24_4.NativeStructWrapper.g5WE7q7UsuSExQkrP8b();
						num2 = 3;
						continue;
					case 5:
						return;
					}
					NativeClassStructHandler_24_4.NativeStructWrapper.gAuFxY7TYfsunCmANrY();
					num2 = 2;
				}
			}

			// Token: 0x06000A19 RID: 2585 RVA: 0x00023738 File Offset: 0x00021938
			internal static void veRTLS7rYkJR1dVFFJO()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000A1A RID: 2586 RVA: 0x00023748 File Offset: 0x00021948
			internal static void gAuFxY7TYfsunCmANrY()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000A1B RID: 2587 RVA: 0x00023758 File Offset: 0x00021958
			internal static bool AgHnc17BKCDbiYGFRV3()
			{
				return NativeClassStructHandler_24_4.NativeStructWrapper.zxM4Dn7E1bkl4a1XFXy == null;
			}

			// Token: 0x06000A1C RID: 2588 RVA: 0x0002376C File Offset: 0x0002196C
			internal static NativeClassStructHandler_24_4.NativeStructWrapper oU5sMs7Gr3P2hVflRg3()
			{
				return NativeClassStructHandler_24_4.NativeStructWrapper.zxM4Dn7E1bkl4a1XFXy;
			}

			// Token: 0x06000A1D RID: 2589 RVA: 0x0002377C File Offset: 0x0002197C
			internal static bool Qenpyj7ggdpUE5g7X1P(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000A1E RID: 2590 RVA: 0x00023798 File Offset: 0x00021998
			internal static void q4cYI67omSDtJoMVhe8(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000A1F RID: 2591 RVA: 0x000237B8 File Offset: 0x000219B8
			internal static void g5WE7q7UsuSExQkrP8b()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000A20 RID: 2592 RVA: 0x000237C8 File Offset: 0x000219C8
			internal static object vilMSx7jPUTFVpgPVm6(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x0400070B RID: 1803
			private static readonly int _bitfield0offset;

			// Token: 0x0400070D RID: 1805
			internal static object zxM4Dn7E1bkl4a1XFXy;
		}
	}
}
