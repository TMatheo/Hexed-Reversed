using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000ED RID: 237
	[ApplicableToUnityVersionsSince("2019.1.0")]
	public class NativeClassStructHandler_24_4 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000A01 RID: 2561 RVA: 0x00012424 File Offset: 0x00010624
		public int Size()
		{
			return sizeof(NativeClassStructHandler_24_4.Il2CppClass_24_4);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00012434 File Offset: 0x00010634
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_24_4.Il2CppClass_24_4* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_24_4.n7x5P865IPEavFuIRyi(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_24_4.Il2CppClass_24_4);
			return new NativeClassStructHandler_24_4.NativeStructWrapper(ptr);
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0001246C File Offset: 0x0001066C
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_650e65d7606047fda7d187c401bdfc6e == 0)
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
			return new NativeClassStructHandler_24_4.NativeStructWrapper(ptr);
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x000124D4 File Offset: 0x000106D4
		public NativeClassStructHandler_24_4()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeClassStructHandler_24_4.kv6mFv6n4J7GM5C96Jq();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_98f1dfe5d9cd4cf9bdc32e0db7fb0ae4 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00012538 File Offset: 0x00010738
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_24_4()
		{
			NativeClassStructHandler_24_4.ctlKEF63nabdd94tykr();
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00012548 File Offset: 0x00010748
		internal static IntPtr n7x5P865IPEavFuIRyi(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0001255C File Offset: 0x0001075C
		internal static bool LGR71f6FK5KYlO3uhTL()
		{
			return NativeClassStructHandler_24_4.AP2D2C6TPc959AtOYsH == null;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00012570 File Offset: 0x00010770
		internal static NativeClassStructHandler_24_4 HmUx4J6K4DChttNcUtj()
		{
			return NativeClassStructHandler_24_4.AP2D2C6TPc959AtOYsH;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00012580 File Offset: 0x00010780
		internal static void kv6mFv6n4J7GM5C96Jq()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00012590 File Offset: 0x00010790
		internal static void ctlKEF63nabdd94tykr()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040006C2 RID: 1730
		internal static NativeClassStructHandler_24_4 AP2D2C6TPc959AtOYsH;

		// Token: 0x020000EE RID: 238
		internal struct Il2CppClass_24_4
		{
			// Token: 0x040006C3 RID: 1731
			public unsafe Il2CppImage* image;

			// Token: 0x040006C4 RID: 1732
			public unsafe void* gc_desc;

			// Token: 0x040006C5 RID: 1733
			public unsafe byte* name;

			// Token: 0x040006C6 RID: 1734
			public unsafe byte* namespaze;

			// Token: 0x040006C7 RID: 1735
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 byval_arg;

			// Token: 0x040006C8 RID: 1736
			public NativeTypeStructHandler_16_0.Il2CppType_16_0 this_arg;

			// Token: 0x040006C9 RID: 1737
			public unsafe Il2CppClass* element_class;

			// Token: 0x040006CA RID: 1738
			public unsafe Il2CppClass* castClass;

			// Token: 0x040006CB RID: 1739
			public unsafe Il2CppClass* declaringType;

			// Token: 0x040006CC RID: 1740
			public unsafe Il2CppClass* parent;

			// Token: 0x040006CD RID: 1741
			public unsafe void* generic_class;

			// Token: 0x040006CE RID: 1742
			public unsafe void* typeDefinition;

			// Token: 0x040006CF RID: 1743
			public unsafe void* interopData;

			// Token: 0x040006D0 RID: 1744
			public unsafe Il2CppClass* klass;

			// Token: 0x040006D1 RID: 1745
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x040006D2 RID: 1746
			public unsafe Il2CppEventInfo* events;

			// Token: 0x040006D3 RID: 1747
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x040006D4 RID: 1748
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x040006D5 RID: 1749
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x040006D6 RID: 1750
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x040006D7 RID: 1751
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x040006D8 RID: 1752
			public unsafe void* static_fields;

			// Token: 0x040006D9 RID: 1753
			public unsafe void* rgctx_data;

			// Token: 0x040006DA RID: 1754
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x040006DB RID: 1755
			public unsafe void* unity_user_data;

			// Token: 0x040006DC RID: 1756
			public uint initializationExceptionGCHandle;

			// Token: 0x040006DD RID: 1757
			public uint cctor_started;

			// Token: 0x040006DE RID: 1758
			public uint cctor_finished;

			// Token: 0x040006DF RID: 1759
			public IntPtr cctor_thread;

			// Token: 0x040006E0 RID: 1760
			public int genericContainerIndex;

			// Token: 0x040006E1 RID: 1761
			public uint instance_size;

			// Token: 0x040006E2 RID: 1762
			public uint actualSize;

			// Token: 0x040006E3 RID: 1763
			public uint element_size;

			// Token: 0x040006E4 RID: 1764
			public int native_size;

			// Token: 0x040006E5 RID: 1765
			public uint static_fields_size;

			// Token: 0x040006E6 RID: 1766
			public uint thread_static_fields_size;

			// Token: 0x040006E7 RID: 1767
			public int thread_static_fields_offset;

			// Token: 0x040006E8 RID: 1768
			public uint flags;

			// Token: 0x040006E9 RID: 1769
			public uint token;

			// Token: 0x040006EA RID: 1770
			public ushort method_count;

			// Token: 0x040006EB RID: 1771
			public ushort property_count;

			// Token: 0x040006EC RID: 1772
			public ushort field_count;

			// Token: 0x040006ED RID: 1773
			public ushort event_count;

			// Token: 0x040006EE RID: 1774
			public ushort nested_type_count;

			// Token: 0x040006EF RID: 1775
			public ushort vtable_count;

			// Token: 0x040006F0 RID: 1776
			public ushort interfaces_count;

			// Token: 0x040006F1 RID: 1777
			public ushort interface_offsets_count;

			// Token: 0x040006F2 RID: 1778
			public byte typeHierarchyDepth;

			// Token: 0x040006F3 RID: 1779
			public byte genericRecursionDepth;

			// Token: 0x040006F4 RID: 1780
			public byte rank;

			// Token: 0x040006F5 RID: 1781
			public byte minimumAlignment;

			// Token: 0x040006F6 RID: 1782
			public byte naturalAligment;

			// Token: 0x040006F7 RID: 1783
			public byte packingSize;

			// Token: 0x040006F8 RID: 1784
			public NativeClassStructHandler_24_4.Il2CppClass_24_4.Bitfield0 _bitfield0;

			// Token: 0x020000EF RID: 239
			internal enum Bitfield0 : ushort
			{
				// Token: 0x040006FA RID: 1786
				BIT_initialized_and_no_error,
				// Token: 0x040006FB RID: 1787
				initialized_and_no_error,
				// Token: 0x040006FC RID: 1788
				BIT_valuetype = 1,
				// Token: 0x040006FD RID: 1789
				valuetype,
				// Token: 0x040006FE RID: 1790
				BIT_initialized = 2,
				// Token: 0x040006FF RID: 1791
				initialized = 4,
				// Token: 0x04000700 RID: 1792
				BIT_enumtype = 3,
				// Token: 0x04000701 RID: 1793
				enumtype = 8,
				// Token: 0x04000702 RID: 1794
				BIT_is_generic = 4,
				// Token: 0x04000703 RID: 1795
				is_generic = 16,
				// Token: 0x04000704 RID: 1796
				BIT_has_references = 5,
				// Token: 0x04000705 RID: 1797
				has_references = 32,
				// Token: 0x04000706 RID: 1798
				BIT_init_pending = 6,
				// Token: 0x04000707 RID: 1799
				init_pending = 64,
				// Token: 0x04000708 RID: 1800
				BIT_size_inited = 7,
				// Token: 0x04000709 RID: 1801
				size_inited = 128,
				// Token: 0x0400070A RID: 1802
				BIT_has_finalize = 8,
				// Token: 0x0400070B RID: 1803
				has_finalize = 256,
				// Token: 0x0400070C RID: 1804
				BIT_has_cctor = 9,
				// Token: 0x0400070D RID: 1805
				has_cctor = 512,
				// Token: 0x0400070E RID: 1806
				BIT_is_blittable = 10,
				// Token: 0x0400070F RID: 1807
				is_blittable = 1024,
				// Token: 0x04000710 RID: 1808
				BIT_is_import_or_windows_runtime = 11,
				// Token: 0x04000711 RID: 1809
				is_import_or_windows_runtime = 2048,
				// Token: 0x04000712 RID: 1810
				BIT_is_vtable_initialized = 12,
				// Token: 0x04000713 RID: 1811
				is_vtable_initialized = 4096,
				// Token: 0x04000714 RID: 1812
				BIT_has_initialization_error = 13,
				// Token: 0x04000715 RID: 1813
				has_initialization_error = 8192
			}
		}

		// Token: 0x020000F0 RID: 240
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000A0B RID: 2571 RVA: 0x00023BC0 File Offset: 0x00021DC0
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_24_4.NativeStructWrapper.TWOnaqf6ppsA20fBSYk();
				NativeClassStructHandler_24_4.NativeStructWrapper.hA0fuLfLfjDWc8qd6cv();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_82de010761f84d069578c758673e6648 == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_39f2b5d6802b4ad087933b982faeb79d == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x17000360 RID: 864
			// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00023C50 File Offset: 0x00021E50
			private unsafe NativeClassStructHandler_24_4.Il2CppClass_24_4* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000361 RID: 865
			// (get) Token: 0x06000A0D RID: 2573 RVA: 0x00023C60 File Offset: 0x00021E60
			// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00023C78 File Offset: 0x00021E78
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_24_4.NativeStructWrapper.Cr69g9f7skrJAvXrGaq(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 5);
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
							NativeClassStructHandler_24_4.NativeStructWrapper.RVixVGfRqXOFvh7xxmw(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 5, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_16defe672aac4a3485dcd78387beb521 == 0)
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

			// Token: 0x17000362 RID: 866
			// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00023CDC File Offset: 0x00021EDC
			public IntPtr Pointer { get; }

			// Token: 0x17000363 RID: 867
			// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00023CEC File Offset: 0x00021EEC
			public IntPtr VTable
			{
				get
				{
					return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(this.Pointer, sizeof(NativeClassStructHandler_24_4.Il2CppClass_24_4), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x17000364 RID: 868
			// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00023D0C File Offset: 0x00021F0C
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000365 RID: 869
			// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00023D1C File Offset: 0x00021F1C
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x17000366 RID: 870
			// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00023D38 File Offset: 0x00021F38
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x17000367 RID: 871
			// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00023D54 File Offset: 0x00021F54
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x17000368 RID: 872
			// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00023D68 File Offset: 0x00021F68
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x17000369 RID: 873
			// (get) Token: 0x06000A16 RID: 2582 RVA: 0x00023D7C File Offset: 0x00021F7C
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x1700036A RID: 874
			// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00023D90 File Offset: 0x00021F90
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x1700036B RID: 875
			// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00023DA4 File Offset: 0x00021FA4
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x1700036C RID: 876
			// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00023DB8 File Offset: 0x00021FB8
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x1700036D RID: 877
			// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00023DCC File Offset: 0x00021FCC
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x1700036E RID: 878
			// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00023DE0 File Offset: 0x00021FE0
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x1700036F RID: 879
			// (get) Token: 0x06000A1C RID: 2588 RVA: 0x00023DF4 File Offset: 0x00021FF4
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x17000370 RID: 880
			// (get) Token: 0x06000A1D RID: 2589 RVA: 0x00023E08 File Offset: 0x00022008
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x17000371 RID: 881
			// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00023E20 File Offset: 0x00022020
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000372 RID: 882
			// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00023E38 File Offset: 0x00022038
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x17000373 RID: 883
			// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00023E50 File Offset: 0x00022050
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x17000374 RID: 884
			// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00023E64 File Offset: 0x00022064
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000375 RID: 885
			// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00023E78 File Offset: 0x00022078
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x17000376 RID: 886
			// (get) Token: 0x06000A23 RID: 2595 RVA: 0x00023E8C File Offset: 0x0002208C
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x17000377 RID: 887
			// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00023EA0 File Offset: 0x000220A0
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x17000378 RID: 888
			// (get) Token: 0x06000A25 RID: 2597 RVA: 0x00023EB4 File Offset: 0x000220B4
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x17000379 RID: 889
			// (get) Token: 0x06000A26 RID: 2598 RVA: 0x00023EC8 File Offset: 0x000220C8
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x1700037A RID: 890
			// (get) Token: 0x06000A27 RID: 2599 RVA: 0x00023EDC File Offset: 0x000220DC
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x1700037B RID: 891
			// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00023EF0 File Offset: 0x000220F0
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x1700037C RID: 892
			// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00023F04 File Offset: 0x00022104
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x1700037D RID: 893
			// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00023F18 File Offset: 0x00022118
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x1700037E RID: 894
			// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00023F2C File Offset: 0x0002212C
			// (set) Token: 0x06000A2C RID: 2604 RVA: 0x00023F44 File Offset: 0x00022144
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_24_4.NativeStructWrapper.Cr69g9f7skrJAvXrGaq(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_24_4.NativeStructWrapper.RVixVGfRqXOFvh7xxmw(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8447c7a721f541de9426c754e1b08372 != 0)
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
			// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00023FA8 File Offset: 0x000221A8
			// (set) Token: 0x06000A2E RID: 2606 RVA: 0x00023FC0 File Offset: 0x000221C0
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_24_4.NativeStructWrapper.Cr69g9f7skrJAvXrGaq(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_24_4.NativeStructWrapper.RVixVGfRqXOFvh7xxmw(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_0783948440564d328b8e79831447d3f6 == 0)
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
			// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00024024 File Offset: 0x00022224
			// (set) Token: 0x06000A30 RID: 2608 RVA: 0x0002403C File Offset: 0x0002223C
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_24_4.NativeStructWrapper.Cr69g9f7skrJAvXrGaq(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_24_4.NativeStructWrapper.RVixVGfRqXOFvh7xxmw(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2b9d7065e34e71a0069eb107f69f59 == 0)
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
			// (get) Token: 0x06000A31 RID: 2609 RVA: 0x000240A0 File Offset: 0x000222A0
			// (set) Token: 0x06000A32 RID: 2610 RVA: 0x000240B8 File Offset: 0x000222B8
			public bool IsGeneric
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_24_4.NativeStructWrapper.RVixVGfRqXOFvh7xxmw(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_780e0c86b08f49d785f406cf802c7e87 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000382 RID: 898
			// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0002411C File Offset: 0x0002231C
			// (set) Token: 0x06000A34 RID: 2612 RVA: 0x00024134 File Offset: 0x00022334
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
						case 1:
							NativeClassStructHandler_24_4.NativeStructWrapper.RVixVGfRqXOFvh7xxmw(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56a961858094410b8d2e4da57d386f1 != 0)
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

			// Token: 0x17000383 RID: 899
			// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00024198 File Offset: 0x00022398
			// (set) Token: 0x06000A36 RID: 2614 RVA: 0x000241B0 File Offset: 0x000223B0
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_24_4.NativeStructWrapper.Cr69g9f7skrJAvXrGaq(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 8);
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
							NativeClassStructHandler_24_4.NativeStructWrapper.RVixVGfRqXOFvh7xxmw(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 8, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7b2fff018dbf4cfe8ef41e2d123dc629 == 0)
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

			// Token: 0x17000384 RID: 900
			// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00024214 File Offset: 0x00022414
			// (set) Token: 0x06000A38 RID: 2616 RVA: 0x0002422C File Offset: 0x0002242C
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
						default:
							return;
						case 1:
							NativeClassStructHandler_24_4.NativeStructWrapper.RVixVGfRqXOFvh7xxmw(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 12, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bacedfb8a3cf4671ae3e03ec2f965495 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000385 RID: 901
			// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00024294 File Offset: 0x00022494
			// (set) Token: 0x06000A3A RID: 2618 RVA: 0x000242AC File Offset: 0x000224AC
			public bool InitializedAndNoError
			{
				get
				{
					return NativeClassStructHandler_24_4.NativeStructWrapper.Cr69g9f7skrJAvXrGaq(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_24_4.NativeStructWrapper.RVixVGfRqXOFvh7xxmw(this, NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9c5de7c7e06f4557898ef7a8362c30ee != 0)
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

			// Token: 0x06000A3B RID: 2619 RVA: 0x00024310 File Offset: 0x00022510
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
						NativeClassStructHandler_24_4.NativeStructWrapper.hA0fuLfLfjDWc8qd6cv();
						num2 = 2;
						continue;
					case 2:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_24_4.Il2CppClass_24_4>(NativeClassStructHandler_24_4.NativeStructWrapper.VaYhGufJZqbcf6IJ0CC(824460796 ^ 327736468 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc));
						num2 = 5;
						continue;
					}
					case 3:
						NativeClassStructHandler_24_4.NativeStructWrapper.TWOnaqf6ppsA20fBSYk();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_17522b2a3ddb488c87b7266d3b1f941d == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						NativeClassStructHandler_24_4.NativeStructWrapper.LTQmptfktv5Jd3LgkiB();
						num2 = 3;
						continue;
					case 5:
					{
						IntPtr intPtr;
						NativeClassStructHandler_24_4.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_75b92ac812f348208c578c3de71e2d57 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					}
					break;
				}
			}

			// Token: 0x06000A3C RID: 2620 RVA: 0x000243F8 File Offset: 0x000225F8
			internal static void TWOnaqf6ppsA20fBSYk()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000A3D RID: 2621 RVA: 0x00024408 File Offset: 0x00022608
			internal static void hA0fuLfLfjDWc8qd6cv()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000A3E RID: 2622 RVA: 0x00024418 File Offset: 0x00022618
			internal static bool nTKRbcfEvbRA0OKorLf()
			{
				return NativeClassStructHandler_24_4.NativeStructWrapper.SXIxm9fuLOo06N2dyyO == null;
			}

			// Token: 0x06000A3F RID: 2623 RVA: 0x0002442C File Offset: 0x0002262C
			internal static NativeClassStructHandler_24_4.NativeStructWrapper wJ6quOfc5wK2i09D8wX()
			{
				return NativeClassStructHandler_24_4.NativeStructWrapper.SXIxm9fuLOo06N2dyyO;
			}

			// Token: 0x06000A40 RID: 2624 RVA: 0x0002443C File Offset: 0x0002263C
			internal static bool Cr69g9f7skrJAvXrGaq(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000A41 RID: 2625 RVA: 0x00024458 File Offset: 0x00022658
			internal static void RVixVGfRqXOFvh7xxmw(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000A42 RID: 2626 RVA: 0x00024478 File Offset: 0x00022678
			internal static void LTQmptfktv5Jd3LgkiB()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000A43 RID: 2627 RVA: 0x00024488 File Offset: 0x00022688
			internal static object VaYhGufJZqbcf6IJ0CC(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000716 RID: 1814
			private static readonly int _bitfield0offset;

			// Token: 0x04000718 RID: 1816
			internal static object SXIxm9fuLOo06N2dyyO;
		}
	}
}
