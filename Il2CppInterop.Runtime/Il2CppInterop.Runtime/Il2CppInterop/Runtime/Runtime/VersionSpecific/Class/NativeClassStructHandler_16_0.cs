using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000BD RID: 189
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeClassStructHandler_16_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x060006CC RID: 1740 RVA: 0x00010F30 File Offset: 0x0000F130
		public int Size()
		{
			return sizeof(NativeClassStructHandler_16_0.Il2CppClass_16_0);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00010F40 File Offset: 0x0000F140
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
				{
					NativeClassStructHandler_16_0.Il2CppClass_16_0* ptr;
					IntPtr buffer = ptr = NativeClassStructHandler_16_0.QWboEBcPWJuPljJ5ySQ(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
					*ptr = default(NativeClassStructHandler_16_0.Il2CppClass_16_0);
					NativeClassStructHandler_16_0.eTUL23cdAD9iody5uvc(buffer);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7c2c0376e816400db5716cff194385b2 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				}
				break;
			}
			throw new NotSupportedException(NativeClassStructHandler_16_0.c20S8Ocw4rh9eOId7YP(887500895 ^ 594919653 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b3f1fcfa11104bd49a7f00386d38b4f4));
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00010FDC File Offset: 0x0000F1DC
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b15bb2810b414d8fba6ffddaf7154f62 == 0)
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
			return new NativeClassStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00011044 File Offset: 0x0000F244
		public NativeClassStructHandler_16_0()
		{
			NativeClassStructHandler_16_0.xTNlLwcexJHOn0HPlRq();
			NativeClassStructHandler_16_0.i9HSn9csWLH6WK74SJV();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2e7e5b018e46a2b3bb280ae243eb22 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x000110A8 File Offset: 0x0000F2A8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_16_0()
		{
			NativeClassStructHandler_16_0.DMFrE4cQLeFhJP7IOqJ();
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000110B8 File Offset: 0x0000F2B8
		internal static IntPtr QWboEBcPWJuPljJ5ySQ(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x000110CC File Offset: 0x0000F2CC
		internal static void eTUL23cdAD9iody5uvc(IntPtr buffer)
		{
			MarshalExtend.FreeHGlobal(buffer);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000110E0 File Offset: 0x0000F2E0
		internal static object c20S8Ocw4rh9eOId7YP(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000110F4 File Offset: 0x0000F2F4
		internal static bool h54xb4cbu1rKcAhcmKN()
		{
			return NativeClassStructHandler_16_0.aRQwAIcoKEZkCAFJclq == null;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00011108 File Offset: 0x0000F308
		internal static NativeClassStructHandler_16_0 LV7gZFcf20JbYZrmUtD()
		{
			return NativeClassStructHandler_16_0.aRQwAIcoKEZkCAFJclq;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00011118 File Offset: 0x0000F318
		internal static void xTNlLwcexJHOn0HPlRq()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00011128 File Offset: 0x0000F328
		internal static void i9HSn9csWLH6WK74SJV()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00011138 File Offset: 0x0000F338
		internal static void DMFrE4cQLeFhJP7IOqJ()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000300 RID: 768
		internal static NativeClassStructHandler_16_0 aRQwAIcoKEZkCAFJclq;

		// Token: 0x020000BE RID: 190
		internal struct Il2CppClass_16_0
		{
			// Token: 0x04000301 RID: 769
			public unsafe Il2CppImage* image;

			// Token: 0x04000302 RID: 770
			public unsafe void* gc_desc;

			// Token: 0x04000303 RID: 771
			public unsafe byte* name;

			// Token: 0x04000304 RID: 772
			public unsafe byte* namespaze;

			// Token: 0x04000305 RID: 773
			public unsafe Il2CppTypeStruct* byval_arg;

			// Token: 0x04000306 RID: 774
			public unsafe Il2CppTypeStruct* this_arg;

			// Token: 0x04000307 RID: 775
			public unsafe Il2CppClass* element_class;

			// Token: 0x04000308 RID: 776
			public unsafe Il2CppClass* castClass;

			// Token: 0x04000309 RID: 777
			public unsafe Il2CppClass* declaringType;

			// Token: 0x0400030A RID: 778
			public unsafe Il2CppClass* parent;

			// Token: 0x0400030B RID: 779
			public unsafe void* generic_class;

			// Token: 0x0400030C RID: 780
			public unsafe void* typeDefinition;

			// Token: 0x0400030D RID: 781
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x0400030E RID: 782
			public unsafe Il2CppEventInfo* events;

			// Token: 0x0400030F RID: 783
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000310 RID: 784
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x04000311 RID: 785
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000312 RID: 786
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x04000313 RID: 787
			public unsafe Il2CppMethodInfo** vtable;

			// Token: 0x04000314 RID: 788
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x04000315 RID: 789
			public unsafe void* static_fields;

			// Token: 0x04000316 RID: 790
			public unsafe void* rgctx_data;

			// Token: 0x04000317 RID: 791
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x04000318 RID: 792
			public uint cctor_started;

			// Token: 0x04000319 RID: 793
			public uint cctor_finished;

			// Token: 0x0400031A RID: 794
			public ulong cctor_thread;

			// Token: 0x0400031B RID: 795
			public int genericContainerIndex;

			// Token: 0x0400031C RID: 796
			public int customAttributeIndex;

			// Token: 0x0400031D RID: 797
			public uint instance_size;

			// Token: 0x0400031E RID: 798
			public uint actualSize;

			// Token: 0x0400031F RID: 799
			public uint element_size;

			// Token: 0x04000320 RID: 800
			public int native_size;

			// Token: 0x04000321 RID: 801
			public uint static_fields_size;

			// Token: 0x04000322 RID: 802
			public uint thread_static_fields_size;

			// Token: 0x04000323 RID: 803
			public int thread_static_fields_offset;

			// Token: 0x04000324 RID: 804
			public uint flags;

			// Token: 0x04000325 RID: 805
			public ushort method_count;

			// Token: 0x04000326 RID: 806
			public ushort property_count;

			// Token: 0x04000327 RID: 807
			public ushort field_count;

			// Token: 0x04000328 RID: 808
			public ushort event_count;

			// Token: 0x04000329 RID: 809
			public ushort nested_type_count;

			// Token: 0x0400032A RID: 810
			public ushort vtable_count;

			// Token: 0x0400032B RID: 811
			public ushort interfaces_count;

			// Token: 0x0400032C RID: 812
			public ushort interface_offsets_count;

			// Token: 0x0400032D RID: 813
			public byte typeHierarchyDepth;

			// Token: 0x0400032E RID: 814
			public byte rank;

			// Token: 0x0400032F RID: 815
			public byte minimumAlignment;

			// Token: 0x04000330 RID: 816
			public byte packingSize;

			// Token: 0x04000331 RID: 817
			public NativeClassStructHandler_16_0.Il2CppClass_16_0.Bitfield0 _bitfield0;

			// Token: 0x020000BF RID: 191
			internal enum Bitfield0 : ushort
			{
				// Token: 0x04000333 RID: 819
				BIT_valuetype,
				// Token: 0x04000334 RID: 820
				valuetype,
				// Token: 0x04000335 RID: 821
				BIT_initialized = 1,
				// Token: 0x04000336 RID: 822
				initialized,
				// Token: 0x04000337 RID: 823
				BIT_enumtype = 2,
				// Token: 0x04000338 RID: 824
				enumtype = 4,
				// Token: 0x04000339 RID: 825
				BIT_is_generic = 3,
				// Token: 0x0400033A RID: 826
				is_generic = 8,
				// Token: 0x0400033B RID: 827
				BIT_has_references = 4,
				// Token: 0x0400033C RID: 828
				has_references = 16,
				// Token: 0x0400033D RID: 829
				BIT_init_pending = 5,
				// Token: 0x0400033E RID: 830
				init_pending = 32,
				// Token: 0x0400033F RID: 831
				BIT_size_inited = 6,
				// Token: 0x04000340 RID: 832
				size_inited = 64,
				// Token: 0x04000341 RID: 833
				BIT_has_finalize = 7,
				// Token: 0x04000342 RID: 834
				has_finalize = 128,
				// Token: 0x04000343 RID: 835
				BIT_has_cctor = 8,
				// Token: 0x04000344 RID: 836
				has_cctor = 256,
				// Token: 0x04000345 RID: 837
				BIT_is_blittable = 9,
				// Token: 0x04000346 RID: 838
				is_blittable = 512
			}
		}

		// Token: 0x020000C0 RID: 192
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x060006D9 RID: 1753 RVA: 0x0001D574 File Offset: 0x0001B774
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_16_0.NativeStructWrapper.oKBxoXZ3A3AjVpEj6vh();
				NativeClassStructHandler_16_0.NativeStructWrapper.yY4X4HZ1VO1u9v1qnsb();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9f56599a6a304695b6cfc284bd7d7c9a == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_667bd9633593433784ebdd2b3fdc8daf != 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x17000198 RID: 408
			// (get) Token: 0x060006DA RID: 1754 RVA: 0x0001D604 File Offset: 0x0001B804
			private unsafe NativeClassStructHandler_16_0.Il2CppClass_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000199 RID: 409
			// (get) Token: 0x060006DB RID: 1755 RVA: 0x0001D614 File Offset: 0x0001B814
			// (set) Token: 0x060006DC RID: 1756 RVA: 0x0001D62C File Offset: 0x0001B82C
			public bool HasReferences
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_16_0.NativeStructWrapper.CayyPfZM0UltReTLtO8(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5afe19cf44424af2ad9aea85585a9cc2 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700019A RID: 410
			// (get) Token: 0x060006DD RID: 1757 RVA: 0x0001D690 File Offset: 0x0001B890
			public IntPtr Pointer { get; }

			// Token: 0x1700019B RID: 411
			// (get) Token: 0x060006DE RID: 1758 RVA: 0x0001D6A0 File Offset: 0x0001B8A0
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_16_0.NativeStructWrapper.cf5vqbZptMaXF4spN2n(this.Pointer, sizeof(NativeClassStructHandler_16_0.Il2CppClass_16_0), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x1700019C RID: 412
			// (get) Token: 0x060006DF RID: 1759 RVA: 0x0001D6C0 File Offset: 0x0001B8C0
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700019D RID: 413
			// (get) Token: 0x060006E0 RID: 1760 RVA: 0x0001D6D0 File Offset: 0x0001B8D0
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->byval_arg);
				}
			}

			// Token: 0x1700019E RID: 414
			// (get) Token: 0x060006E1 RID: 1761 RVA: 0x0001D6EC File Offset: 0x0001B8EC
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->this_arg);
				}
			}

			// Token: 0x1700019F RID: 415
			// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0001D708 File Offset: 0x0001B908
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x170001A0 RID: 416
			// (get) Token: 0x060006E3 RID: 1763 RVA: 0x0001D71C File Offset: 0x0001B91C
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x170001A1 RID: 417
			// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0001D730 File Offset: 0x0001B930
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x170001A2 RID: 418
			// (get) Token: 0x060006E5 RID: 1765 RVA: 0x0001D744 File Offset: 0x0001B944
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x060006E6 RID: 1766 RVA: 0x0001D758 File Offset: 0x0001B958
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x170001A4 RID: 420
			// (get) Token: 0x060006E7 RID: 1767 RVA: 0x0001D76C File Offset: 0x0001B96C
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0001D780 File Offset: 0x0001B980
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x060006E9 RID: 1769 RVA: 0x0001D794 File Offset: 0x0001B994
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x060006EA RID: 1770 RVA: 0x0001D7A8 File Offset: 0x0001B9A8
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x060006EB RID: 1771 RVA: 0x0001D7BC File Offset: 0x0001B9BC
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x060006EC RID: 1772 RVA: 0x0001D7D4 File Offset: 0x0001B9D4
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170001AA RID: 426
			// (get) Token: 0x060006ED RID: 1773 RVA: 0x0001D7EC File Offset: 0x0001B9EC
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x170001AB RID: 427
			// (get) Token: 0x060006EE RID: 1774 RVA: 0x0001D804 File Offset: 0x0001BA04
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x170001AC RID: 428
			// (get) Token: 0x060006EF RID: 1775 RVA: 0x0001D818 File Offset: 0x0001BA18
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x170001AD RID: 429
			// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0001D82C File Offset: 0x0001BA2C
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x170001AE RID: 430
			// (get) Token: 0x060006F1 RID: 1777 RVA: 0x0001D840 File Offset: 0x0001BA40
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x170001AF RID: 431
			// (get) Token: 0x060006F2 RID: 1778 RVA: 0x0001D854 File Offset: 0x0001BA54
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x170001B0 RID: 432
			// (get) Token: 0x060006F3 RID: 1779 RVA: 0x0001D868 File Offset: 0x0001BA68
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._klassDummy;
				}
			}

			// Token: 0x170001B1 RID: 433
			// (get) Token: 0x060006F4 RID: 1780 RVA: 0x0001D878 File Offset: 0x0001BA78
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x170001B2 RID: 434
			// (get) Token: 0x060006F5 RID: 1781 RVA: 0x0001D88C File Offset: 0x0001BA8C
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x170001B3 RID: 435
			// (get) Token: 0x060006F6 RID: 1782 RVA: 0x0001D8A0 File Offset: 0x0001BAA0
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x170001B4 RID: 436
			// (get) Token: 0x060006F7 RID: 1783 RVA: 0x0001D8B4 File Offset: 0x0001BAB4
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x170001B5 RID: 437
			// (get) Token: 0x060006F8 RID: 1784 RVA: 0x0001D8C8 File Offset: 0x0001BAC8
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x170001B6 RID: 438
			// (get) Token: 0x060006F9 RID: 1785 RVA: 0x0001D8DC File Offset: 0x0001BADC
			// (set) Token: 0x060006FA RID: 1786 RVA: 0x0001D8F4 File Offset: 0x0001BAF4
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_16_0.NativeStructWrapper.DheqOwZ4TCbrlw4WldG(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_16_0.NativeStructWrapper.CayyPfZM0UltReTLtO8(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_afe904a262fb47328a49943b4b34b494 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170001B7 RID: 439
			// (get) Token: 0x060006FB RID: 1787 RVA: 0x0001D958 File Offset: 0x0001BB58
			// (set) Token: 0x060006FC RID: 1788 RVA: 0x0001D970 File Offset: 0x0001BB70
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_16_0.NativeStructWrapper.DheqOwZ4TCbrlw4WldG(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_16_0.NativeStructWrapper.CayyPfZM0UltReTLtO8(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_78bdbfb54f5c42368a7dbf88905820e8 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170001B8 RID: 440
			// (get) Token: 0x060006FD RID: 1789 RVA: 0x0001D9D4 File Offset: 0x0001BBD4
			// (set) Token: 0x060006FE RID: 1790 RVA: 0x0001D9EC File Offset: 0x0001BBEC
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_16_0.NativeStructWrapper.DheqOwZ4TCbrlw4WldG(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 2);
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
							this.SetBit(NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f65b5965aa9843ea8b738fef02a2c6c9 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170001B9 RID: 441
			// (get) Token: 0x060006FF RID: 1791 RVA: 0x0001DA50 File Offset: 0x0001BC50
			// (set) Token: 0x06000700 RID: 1792 RVA: 0x0001DA68 File Offset: 0x0001BC68
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_16_0.NativeStructWrapper.DheqOwZ4TCbrlw4WldG(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_16_0.NativeStructWrapper.CayyPfZM0UltReTLtO8(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_22d16b8eb84d4725aef9f7a9d2f68925 != 0)
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

			// Token: 0x170001BA RID: 442
			// (get) Token: 0x06000701 RID: 1793 RVA: 0x0001DACC File Offset: 0x0001BCCC
			// (set) Token: 0x06000702 RID: 1794 RVA: 0x0001DAE4 File Offset: 0x0001BCE4
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_16_0.NativeStructWrapper.DheqOwZ4TCbrlw4WldG(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 6);
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
							NativeClassStructHandler_16_0.NativeStructWrapper.CayyPfZM0UltReTLtO8(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_afe904a262fb47328a49943b4b34b494 == 0)
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

			// Token: 0x170001BB RID: 443
			// (get) Token: 0x06000703 RID: 1795 RVA: 0x0001DB48 File Offset: 0x0001BD48
			// (set) Token: 0x06000704 RID: 1796 RVA: 0x0001DB60 File Offset: 0x0001BD60
			public bool HasFinalize
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_16_0.NativeStructWrapper.CayyPfZM0UltReTLtO8(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c474f43efb4d4f17b5c0c1bf3216ef4d == 0)
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

			// Token: 0x170001BC RID: 444
			// (get) Token: 0x06000705 RID: 1797 RVA: 0x0001DBC4 File Offset: 0x0001BDC4
			// (set) Token: 0x06000706 RID: 1798 RVA: 0x0001DBD0 File Offset: 0x0001BDD0
			public bool IsVtableInitialized
			{
				get
				{
					return false;
				}
				set
				{
				}
			}

			// Token: 0x170001BD RID: 445
			// (get) Token: 0x06000707 RID: 1799 RVA: 0x0001DBDC File Offset: 0x0001BDDC
			// (set) Token: 0x06000708 RID: 1800 RVA: 0x0001DBE8 File Offset: 0x0001BDE8
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

			// Token: 0x06000709 RID: 1801 RVA: 0x0001DBF4 File Offset: 0x0001BDF4
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 4;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						IntPtr intPtr;
						switch (num2)
						{
						case 1:
							intPtr = Marshal.OffsetOf<NativeClassStructHandler_16_0.Il2CppClass_16_0>(NativeClassStructHandler_16_0.NativeStructWrapper.FZfc9TZzVUrnc7uFlut(-1887629927 ^ -756937035 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8155e7a9a9bd4894b741e1951a0eace6));
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_40875ab50e1c43f7bf4d96946e4523cb == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							return;
						case 3:
							NativeClassStructHandler_16_0.NativeStructWrapper.oKBxoXZ3A3AjVpEj6vh();
							num2 = 1;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9c5de7c7e06f4557898ef7a8362c30ee == 0)
							{
								num2 = 5;
								continue;
							}
							continue;
						case 4:
							goto IL_3B;
						case 5:
							NativeClassStructHandler_16_0.NativeStructWrapper.yY4X4HZ1VO1u9v1qnsb();
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5afe19cf44424af2ad9aea85585a9cc2 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 2;
					}
					IL_3B:
					hIDAYxH6DWLHIthQgC.zSLipEDdx();
					num = 3;
				}
			}

			// Token: 0x0600070A RID: 1802 RVA: 0x0001DCF4 File Offset: 0x0001BEF4
			internal static void oKBxoXZ3A3AjVpEj6vh()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600070B RID: 1803 RVA: 0x0001DD04 File Offset: 0x0001BF04
			internal static void yY4X4HZ1VO1u9v1qnsb()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x0600070C RID: 1804 RVA: 0x0001DD14 File Offset: 0x0001BF14
			internal static bool shf6F1Z567cCsgisF05()
			{
				return NativeClassStructHandler_16_0.NativeStructWrapper.fgApkaZKlxPHyBb2r6K == null;
			}

			// Token: 0x0600070D RID: 1805 RVA: 0x0001DD28 File Offset: 0x0001BF28
			internal static NativeClassStructHandler_16_0.NativeStructWrapper qpHClxZntFBYbnuyX3c()
			{
				return NativeClassStructHandler_16_0.NativeStructWrapper.fgApkaZKlxPHyBb2r6K;
			}

			// Token: 0x0600070E RID: 1806 RVA: 0x0001DD38 File Offset: 0x0001BF38
			internal static void CayyPfZM0UltReTLtO8(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x0600070F RID: 1807 RVA: 0x0001DD58 File Offset: 0x0001BF58
			internal static IntPtr cf5vqbZptMaXF4spN2n(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x06000710 RID: 1808 RVA: 0x0001DD74 File Offset: 0x0001BF74
			internal static bool DheqOwZ4TCbrlw4WldG(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000711 RID: 1809 RVA: 0x0001DD90 File Offset: 0x0001BF90
			internal static object FZfc9TZzVUrnc7uFlut(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000347 RID: 839
			private static readonly int _bitfield0offset;

			// Token: 0x04000348 RID: 840
			private unsafe Il2CppClass* _klassDummy;

			// Token: 0x0400034A RID: 842
			internal static object fgApkaZKlxPHyBb2r6K;
		}
	}
}
