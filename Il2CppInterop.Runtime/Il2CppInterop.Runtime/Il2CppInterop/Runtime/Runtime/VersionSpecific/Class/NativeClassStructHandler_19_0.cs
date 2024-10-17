using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000C1 RID: 193
	[ApplicableToUnityVersionsSince("5.3.2")]
	public class NativeClassStructHandler_19_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000712 RID: 1810 RVA: 0x00011148 File Offset: 0x0000F348
		public int Size()
		{
			return sizeof(NativeClassStructHandler_19_0.Il2CppClass_19_0);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00011158 File Offset: 0x0000F358
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
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
				{
					NativeClassStructHandler_19_0.Il2CppClass_19_0* ptr;
					IntPtr buffer = ptr = NativeClassStructHandler_19_0.ibTHlacgUir9AqPXclB(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
					*ptr = default(NativeClassStructHandler_19_0.Il2CppClass_19_0);
					NativeClassStructHandler_19_0.CXPppDcl7X24HEDcVij(buffer);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5c4dec7c475342669cbf3c1205f935ba != 0)
					{
						num2 = 0;
					}
					break;
				}
				}
			}
			IL_2B:
			throw new NotSupportedException(hIDAYxH6DWLHIthQgC.gSCeTtiku(~-285258927 ^ 495189159 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c504ab11ece64b14b01df2d4c88e6e49));
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000111F4 File Offset: 0x0000F3F4
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_dbbda98ba6574101bc623ad559f7b5a3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeClassStructHandler_19_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0001125C File Offset: 0x0000F45C
		public NativeClassStructHandler_19_0()
		{
			NativeClassStructHandler_19_0.apZtW1cVgWJVcJL7O6C();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2dd85386720b438b874026b47430e4fa == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000112C0 File Offset: 0x0000F4C0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_19_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000112D0 File Offset: 0x0000F4D0
		internal static IntPtr ibTHlacgUir9AqPXclB(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x000112E4 File Offset: 0x0000F4E4
		internal static void CXPppDcl7X24HEDcVij(IntPtr buffer)
		{
			MarshalExtend.FreeHGlobal(buffer);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x000112F8 File Offset: 0x0000F4F8
		internal static bool jeQhqlcyg1pKvOWVj2n()
		{
			return NativeClassStructHandler_19_0.N3Hq1jc2TM3G2uGeLTo == null;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0001130C File Offset: 0x0000F50C
		internal static NativeClassStructHandler_19_0 uVTTqecSca96vtU6uDk()
		{
			return NativeClassStructHandler_19_0.N3Hq1jc2TM3G2uGeLTo;
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0001131C File Offset: 0x0000F51C
		internal static void apZtW1cVgWJVcJL7O6C()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x0400034B RID: 843
		private static NativeClassStructHandler_19_0 N3Hq1jc2TM3G2uGeLTo;

		// Token: 0x020000C2 RID: 194
		internal struct Il2CppClass_19_0
		{
			// Token: 0x0400034C RID: 844
			public unsafe Il2CppImage* image;

			// Token: 0x0400034D RID: 845
			public unsafe void* gc_desc;

			// Token: 0x0400034E RID: 846
			public unsafe byte* name;

			// Token: 0x0400034F RID: 847
			public unsafe byte* namespaze;

			// Token: 0x04000350 RID: 848
			public unsafe Il2CppTypeStruct* byval_arg;

			// Token: 0x04000351 RID: 849
			public unsafe Il2CppTypeStruct* this_arg;

			// Token: 0x04000352 RID: 850
			public unsafe Il2CppClass* element_class;

			// Token: 0x04000353 RID: 851
			public unsafe Il2CppClass* castClass;

			// Token: 0x04000354 RID: 852
			public unsafe Il2CppClass* declaringType;

			// Token: 0x04000355 RID: 853
			public unsafe Il2CppClass* parent;

			// Token: 0x04000356 RID: 854
			public unsafe void* generic_class;

			// Token: 0x04000357 RID: 855
			public unsafe void* typeDefinition;

			// Token: 0x04000358 RID: 856
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x04000359 RID: 857
			public unsafe Il2CppEventInfo* events;

			// Token: 0x0400035A RID: 858
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x0400035B RID: 859
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x0400035C RID: 860
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x0400035D RID: 861
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x0400035E RID: 862
			public unsafe Il2CppMethodInfo** vtable;

			// Token: 0x0400035F RID: 863
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x04000360 RID: 864
			public unsafe void* static_fields;

			// Token: 0x04000361 RID: 865
			public unsafe void* rgctx_data;

			// Token: 0x04000362 RID: 866
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x04000363 RID: 867
			public uint cctor_started;

			// Token: 0x04000364 RID: 868
			public uint cctor_finished;

			// Token: 0x04000365 RID: 869
			public ulong cctor_thread;

			// Token: 0x04000366 RID: 870
			public int genericContainerIndex;

			// Token: 0x04000367 RID: 871
			public int customAttributeIndex;

			// Token: 0x04000368 RID: 872
			public uint instance_size;

			// Token: 0x04000369 RID: 873
			public uint actualSize;

			// Token: 0x0400036A RID: 874
			public uint element_size;

			// Token: 0x0400036B RID: 875
			public int native_size;

			// Token: 0x0400036C RID: 876
			public uint static_fields_size;

			// Token: 0x0400036D RID: 877
			public uint thread_static_fields_size;

			// Token: 0x0400036E RID: 878
			public int thread_static_fields_offset;

			// Token: 0x0400036F RID: 879
			public uint flags;

			// Token: 0x04000370 RID: 880
			public uint token;

			// Token: 0x04000371 RID: 881
			public ushort method_count;

			// Token: 0x04000372 RID: 882
			public ushort property_count;

			// Token: 0x04000373 RID: 883
			public ushort field_count;

			// Token: 0x04000374 RID: 884
			public ushort event_count;

			// Token: 0x04000375 RID: 885
			public ushort nested_type_count;

			// Token: 0x04000376 RID: 886
			public ushort vtable_count;

			// Token: 0x04000377 RID: 887
			public ushort interfaces_count;

			// Token: 0x04000378 RID: 888
			public ushort interface_offsets_count;

			// Token: 0x04000379 RID: 889
			public byte typeHierarchyDepth;

			// Token: 0x0400037A RID: 890
			public byte rank;

			// Token: 0x0400037B RID: 891
			public byte minimumAlignment;

			// Token: 0x0400037C RID: 892
			public byte packingSize;

			// Token: 0x0400037D RID: 893
			public NativeClassStructHandler_19_0.Il2CppClass_19_0.Bitfield0 _bitfield0;

			// Token: 0x020000C3 RID: 195
			internal enum Bitfield0 : ushort
			{
				// Token: 0x0400037F RID: 895
				BIT_valuetype,
				// Token: 0x04000380 RID: 896
				valuetype,
				// Token: 0x04000381 RID: 897
				BIT_initialized = 1,
				// Token: 0x04000382 RID: 898
				initialized,
				// Token: 0x04000383 RID: 899
				BIT_enumtype = 2,
				// Token: 0x04000384 RID: 900
				enumtype = 4,
				// Token: 0x04000385 RID: 901
				BIT_is_generic = 3,
				// Token: 0x04000386 RID: 902
				is_generic = 8,
				// Token: 0x04000387 RID: 903
				BIT_has_references = 4,
				// Token: 0x04000388 RID: 904
				has_references = 16,
				// Token: 0x04000389 RID: 905
				BIT_init_pending = 5,
				// Token: 0x0400038A RID: 906
				init_pending = 32,
				// Token: 0x0400038B RID: 907
				BIT_size_inited = 6,
				// Token: 0x0400038C RID: 908
				size_inited = 64,
				// Token: 0x0400038D RID: 909
				BIT_has_finalize = 7,
				// Token: 0x0400038E RID: 910
				has_finalize = 128,
				// Token: 0x0400038F RID: 911
				BIT_has_cctor = 8,
				// Token: 0x04000390 RID: 912
				has_cctor = 256,
				// Token: 0x04000391 RID: 913
				BIT_is_blittable = 9,
				// Token: 0x04000392 RID: 914
				is_blittable = 512
			}
		}

		// Token: 0x020000C4 RID: 196
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x0600071C RID: 1820 RVA: 0x0001DDA4 File Offset: 0x0001BFA4
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_19_0.NativeStructWrapper.y5SE0boIZjAJfsYkUir();
				NativeClassStructHandler_19_0.NativeStructWrapper.t6VMxloGF8Fdv13Lirm();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bacedfb8a3cf4671ae3e03ec2f965495 != 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_0e76a731caf34f7495b20ae26aa97571 == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x170001BE RID: 446
			// (get) Token: 0x0600071D RID: 1821 RVA: 0x0001DE34 File Offset: 0x0001C034
			private unsafe NativeClassStructHandler_19_0.Il2CppClass_19_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170001BF RID: 447
			// (get) Token: 0x0600071E RID: 1822 RVA: 0x0001DE44 File Offset: 0x0001C044
			// (set) Token: 0x0600071F RID: 1823 RVA: 0x0001DE5C File Offset: 0x0001C05C
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_19_0.NativeStructWrapper.WZWpNloYBfNI1cJfe8S(this, NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 4);
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
							this.SetBit(NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 4, value);
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

			// Token: 0x170001C0 RID: 448
			// (get) Token: 0x06000720 RID: 1824 RVA: 0x0001DEC0 File Offset: 0x0001C0C0
			public IntPtr Pointer { get; }

			// Token: 0x170001C1 RID: 449
			// (get) Token: 0x06000721 RID: 1825 RVA: 0x0001DED0 File Offset: 0x0001C0D0
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_19_0.NativeStructWrapper.jfgTgkoakoBNy7fIxLa(this.Pointer, sizeof(NativeClassStructHandler_19_0.Il2CppClass_19_0), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x170001C2 RID: 450
			// (get) Token: 0x06000722 RID: 1826 RVA: 0x0001DEF0 File Offset: 0x0001C0F0
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170001C3 RID: 451
			// (get) Token: 0x06000723 RID: 1827 RVA: 0x0001DF00 File Offset: 0x0001C100
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->byval_arg);
				}
			}

			// Token: 0x170001C4 RID: 452
			// (get) Token: 0x06000724 RID: 1828 RVA: 0x0001DF1C File Offset: 0x0001C11C
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->this_arg);
				}
			}

			// Token: 0x170001C5 RID: 453
			// (get) Token: 0x06000725 RID: 1829 RVA: 0x0001DF38 File Offset: 0x0001C138
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x170001C6 RID: 454
			// (get) Token: 0x06000726 RID: 1830 RVA: 0x0001DF4C File Offset: 0x0001C14C
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x170001C7 RID: 455
			// (get) Token: 0x06000727 RID: 1831 RVA: 0x0001DF60 File Offset: 0x0001C160
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x170001C8 RID: 456
			// (get) Token: 0x06000728 RID: 1832 RVA: 0x0001DF74 File Offset: 0x0001C174
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x170001C9 RID: 457
			// (get) Token: 0x06000729 RID: 1833 RVA: 0x0001DF88 File Offset: 0x0001C188
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x170001CA RID: 458
			// (get) Token: 0x0600072A RID: 1834 RVA: 0x0001DF9C File Offset: 0x0001C19C
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x170001CB RID: 459
			// (get) Token: 0x0600072B RID: 1835 RVA: 0x0001DFB0 File Offset: 0x0001C1B0
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x170001CC RID: 460
			// (get) Token: 0x0600072C RID: 1836 RVA: 0x0001DFC4 File Offset: 0x0001C1C4
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x170001CD RID: 461
			// (get) Token: 0x0600072D RID: 1837 RVA: 0x0001DFD8 File Offset: 0x0001C1D8
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x170001CE RID: 462
			// (get) Token: 0x0600072E RID: 1838 RVA: 0x0001DFEC File Offset: 0x0001C1EC
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x170001CF RID: 463
			// (get) Token: 0x0600072F RID: 1839 RVA: 0x0001E004 File Offset: 0x0001C204
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170001D0 RID: 464
			// (get) Token: 0x06000730 RID: 1840 RVA: 0x0001E01C File Offset: 0x0001C21C
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x170001D1 RID: 465
			// (get) Token: 0x06000731 RID: 1841 RVA: 0x0001E034 File Offset: 0x0001C234
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x170001D2 RID: 466
			// (get) Token: 0x06000732 RID: 1842 RVA: 0x0001E048 File Offset: 0x0001C248
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x170001D3 RID: 467
			// (get) Token: 0x06000733 RID: 1843 RVA: 0x0001E05C File Offset: 0x0001C25C
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x170001D4 RID: 468
			// (get) Token: 0x06000734 RID: 1844 RVA: 0x0001E070 File Offset: 0x0001C270
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x170001D5 RID: 469
			// (get) Token: 0x06000735 RID: 1845 RVA: 0x0001E084 File Offset: 0x0001C284
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x170001D6 RID: 470
			// (get) Token: 0x06000736 RID: 1846 RVA: 0x0001E098 File Offset: 0x0001C298
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._klassDummy;
				}
			}

			// Token: 0x170001D7 RID: 471
			// (get) Token: 0x06000737 RID: 1847 RVA: 0x0001E0A8 File Offset: 0x0001C2A8
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x170001D8 RID: 472
			// (get) Token: 0x06000738 RID: 1848 RVA: 0x0001E0BC File Offset: 0x0001C2BC
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x170001D9 RID: 473
			// (get) Token: 0x06000739 RID: 1849 RVA: 0x0001E0D0 File Offset: 0x0001C2D0
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x170001DA RID: 474
			// (get) Token: 0x0600073A RID: 1850 RVA: 0x0001E0E4 File Offset: 0x0001C2E4
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x170001DB RID: 475
			// (get) Token: 0x0600073B RID: 1851 RVA: 0x0001E0F8 File Offset: 0x0001C2F8
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x170001DC RID: 476
			// (get) Token: 0x0600073C RID: 1852 RVA: 0x0001E10C File Offset: 0x0001C30C
			// (set) Token: 0x0600073D RID: 1853 RVA: 0x0001E124 File Offset: 0x0001C324
			public bool ValueType
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 0);
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
							this.SetBit(NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3bc6c4fc6422441e99d3c51c51f46d12 != 0)
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

			// Token: 0x170001DD RID: 477
			// (get) Token: 0x0600073E RID: 1854 RVA: 0x0001E188 File Offset: 0x0001C388
			// (set) Token: 0x0600073F RID: 1855 RVA: 0x0001E1A0 File Offset: 0x0001C3A0
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_19_0.NativeStructWrapper.WZWpNloYBfNI1cJfe8S(this, NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 1);
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
							this.SetBit(NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2210d7ca22c24335b32d80ca3ef84b8e != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170001DE RID: 478
			// (get) Token: 0x06000740 RID: 1856 RVA: 0x0001E204 File Offset: 0x0001C404
			// (set) Token: 0x06000741 RID: 1857 RVA: 0x0001E21C File Offset: 0x0001C41C
			public bool EnumType
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 2);
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
							this.SetBit(NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7f5f35a413414ac0b2dfa27f953f90e9 != 0)
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

			// Token: 0x170001DF RID: 479
			// (get) Token: 0x06000742 RID: 1858 RVA: 0x0001E280 File Offset: 0x0001C480
			// (set) Token: 0x06000743 RID: 1859 RVA: 0x0001E298 File Offset: 0x0001C498
			public bool IsGeneric
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 3);
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
							this.SetBit(NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_46ba390073ec4df6883860abf17dbf6f == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170001E0 RID: 480
			// (get) Token: 0x06000744 RID: 1860 RVA: 0x0001E2FC File Offset: 0x0001C4FC
			// (set) Token: 0x06000745 RID: 1861 RVA: 0x0001E314 File Offset: 0x0001C514
			public bool SizeInited
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 6);
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
							this.SetBit(NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ea3a0368554c4e6093e0b0561ffd5cef != 0)
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

			// Token: 0x170001E1 RID: 481
			// (get) Token: 0x06000746 RID: 1862 RVA: 0x0001E378 File Offset: 0x0001C578
			// (set) Token: 0x06000747 RID: 1863 RVA: 0x0001E390 File Offset: 0x0001C590
			public bool HasFinalize
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_19_0.NativeStructWrapper.lEV4xIoCw9HE4RyIbdB(this, NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_483eecf3691e4ef2b23b2d4cb2ca3d52 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170001E2 RID: 482
			// (get) Token: 0x06000748 RID: 1864 RVA: 0x0001E3F4 File Offset: 0x0001C5F4
			// (set) Token: 0x06000749 RID: 1865 RVA: 0x0001E400 File Offset: 0x0001C600
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

			// Token: 0x170001E3 RID: 483
			// (get) Token: 0x0600074A RID: 1866 RVA: 0x0001E40C File Offset: 0x0001C60C
			// (set) Token: 0x0600074B RID: 1867 RVA: 0x0001E418 File Offset: 0x0001C618
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

			// Token: 0x0600074C RID: 1868 RVA: 0x0001E424 File Offset: 0x0001C624
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 4;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
						{
							IntPtr intPtr;
							NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
							num2 = 2;
							continue;
						}
						case 2:
							return;
						case 3:
							NativeClassStructHandler_19_0.NativeStructWrapper.y5SE0boIZjAJfsYkUir();
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							hIDAYxH6DWLHIthQgC.zSLipEDdx();
							num2 = 3;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c474f43efb4d4f17b5c0c1bf3216ef4d == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						case 5:
						{
							IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_19_0.Il2CppClass_19_0>(NativeClassStructHandler_19_0.NativeStructWrapper.WgSNnGotGPE4drQGfFE(618117306 ^ 2117233498 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d691a76a9c4746c9a1a67e34c67ca64b));
							num2 = 1;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a8737fecb12449d7ad23f5080d76d2f8 != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						}
						break;
					}
					IL_7C:
					nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
					num = 5;
					continue;
					goto IL_7C;
				}
			}

			// Token: 0x0600074D RID: 1869 RVA: 0x0001E524 File Offset: 0x0001C724
			internal static void y5SE0boIZjAJfsYkUir()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600074E RID: 1870 RVA: 0x0001E534 File Offset: 0x0001C734
			internal static void t6VMxloGF8Fdv13Lirm()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x0600074F RID: 1871 RVA: 0x0001E544 File Offset: 0x0001C744
			internal static bool XWr5eLo9uPDYWBJXsB8()
			{
				return NativeClassStructHandler_19_0.NativeStructWrapper.hiN6I1oqXKk5JHGkNMj == null;
			}

			// Token: 0x06000750 RID: 1872 RVA: 0x0001E558 File Offset: 0x0001C758
			internal static NativeClassStructHandler_19_0.NativeStructWrapper mGS1rZoiY6kNsO5e2QZ()
			{
				return NativeClassStructHandler_19_0.NativeStructWrapper.hiN6I1oqXKk5JHGkNMj;
			}

			// Token: 0x06000751 RID: 1873 RVA: 0x0001E568 File Offset: 0x0001C768
			internal static bool WZWpNloYBfNI1cJfe8S(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000752 RID: 1874 RVA: 0x0001E584 File Offset: 0x0001C784
			internal static IntPtr jfgTgkoakoBNy7fIxLa(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x06000753 RID: 1875 RVA: 0x0001E5A0 File Offset: 0x0001C7A0
			internal static void lEV4xIoCw9HE4RyIbdB(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000754 RID: 1876 RVA: 0x0001E5C0 File Offset: 0x0001C7C0
			internal static object WgSNnGotGPE4drQGfFE(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000393 RID: 915
			private static readonly int _bitfield0offset;

			// Token: 0x04000394 RID: 916
			private unsafe Il2CppClass* _klassDummy;

			// Token: 0x04000396 RID: 918
			internal static object hiN6I1oqXKk5JHGkNMj;
		}
	}
}
