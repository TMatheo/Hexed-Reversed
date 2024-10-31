using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000BB RID: 187
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeClassStructHandler_16_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x060006AF RID: 1711 RVA: 0x000102F0 File Offset: 0x0000E4F0
		public int Size()
		{
			return sizeof(NativeClassStructHandler_16_0.Il2CppClass_16_0);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00010300 File Offset: 0x0000E500
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
					IntPtr buffer = ptr = NativeClassStructHandler_16_0.Let34c6tviCPi2dqoHb(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
					*ptr = default(NativeClassStructHandler_16_0.Il2CppClass_16_0);
					NativeClassStructHandler_16_0.pEegBI6vBltEeYQOo6j(buffer);
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ac2c10c141e144acbcef06aa86a10430 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				}
				break;
			}
			throw new NotSupportedException(NativeClassStructHandler_16_0.BMLQgP6xq6ZJnPKe59L(1105551206 ^ 142569887 ^ 828359874 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_856ffe7e0c9b4de88d71070d175d49fd));
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x000103A4 File Offset: 0x0000E5A4
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b9b6cd6cbc040a7be58cff054f9e843 != 0)
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

		// Token: 0x060006B2 RID: 1714 RVA: 0x0001040C File Offset: 0x0000E60C
		public NativeClassStructHandler_16_0()
		{
			NativeClassStructHandler_16_0.KED0pA6YWKOrqJA5MtH();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4da80845ebf7410ebbf942336f5ee27b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00010470 File Offset: 0x0000E670
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_16_0()
		{
			NativeClassStructHandler_16_0.tBiPrn68QqYYlqlhBiE();
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00010480 File Offset: 0x0000E680
		internal static IntPtr Let34c6tviCPi2dqoHb(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00010494 File Offset: 0x0000E694
		internal static void pEegBI6vBltEeYQOo6j(IntPtr buffer)
		{
			MarshalExtend.FreeHGlobal(buffer);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x000104A8 File Offset: 0x0000E6A8
		internal static object BMLQgP6xq6ZJnPKe59L(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x000104BC File Offset: 0x0000E6BC
		internal static bool GG1OB96hfltufUm6Jlt()
		{
			return NativeClassStructHandler_16_0.t1hvT56HbIbRwm6dXvp == null;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x000104D0 File Offset: 0x0000E6D0
		internal static NativeClassStructHandler_16_0 V5iiLL6Ow47xjFXIwTk()
		{
			return NativeClassStructHandler_16_0.t1hvT56HbIbRwm6dXvp;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x000104E0 File Offset: 0x0000E6E0
		internal static void KED0pA6YWKOrqJA5MtH()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x000104F0 File Offset: 0x0000E6F0
		internal static void tBiPrn68QqYYlqlhBiE()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040002F5 RID: 757
		internal static NativeClassStructHandler_16_0 t1hvT56HbIbRwm6dXvp;

		// Token: 0x020000BC RID: 188
		internal struct Il2CppClass_16_0
		{
			// Token: 0x040002F6 RID: 758
			public unsafe Il2CppImage* image;

			// Token: 0x040002F7 RID: 759
			public unsafe void* gc_desc;

			// Token: 0x040002F8 RID: 760
			public unsafe byte* name;

			// Token: 0x040002F9 RID: 761
			public unsafe byte* namespaze;

			// Token: 0x040002FA RID: 762
			public unsafe Il2CppTypeStruct* byval_arg;

			// Token: 0x040002FB RID: 763
			public unsafe Il2CppTypeStruct* this_arg;

			// Token: 0x040002FC RID: 764
			public unsafe Il2CppClass* element_class;

			// Token: 0x040002FD RID: 765
			public unsafe Il2CppClass* castClass;

			// Token: 0x040002FE RID: 766
			public unsafe Il2CppClass* declaringType;

			// Token: 0x040002FF RID: 767
			public unsafe Il2CppClass* parent;

			// Token: 0x04000300 RID: 768
			public unsafe void* generic_class;

			// Token: 0x04000301 RID: 769
			public unsafe void* typeDefinition;

			// Token: 0x04000302 RID: 770
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x04000303 RID: 771
			public unsafe Il2CppEventInfo* events;

			// Token: 0x04000304 RID: 772
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000305 RID: 773
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x04000306 RID: 774
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000307 RID: 775
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x04000308 RID: 776
			public unsafe Il2CppMethodInfo** vtable;

			// Token: 0x04000309 RID: 777
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x0400030A RID: 778
			public unsafe void* static_fields;

			// Token: 0x0400030B RID: 779
			public unsafe void* rgctx_data;

			// Token: 0x0400030C RID: 780
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x0400030D RID: 781
			public uint cctor_started;

			// Token: 0x0400030E RID: 782
			public uint cctor_finished;

			// Token: 0x0400030F RID: 783
			public ulong cctor_thread;

			// Token: 0x04000310 RID: 784
			public int genericContainerIndex;

			// Token: 0x04000311 RID: 785
			public int customAttributeIndex;

			// Token: 0x04000312 RID: 786
			public uint instance_size;

			// Token: 0x04000313 RID: 787
			public uint actualSize;

			// Token: 0x04000314 RID: 788
			public uint element_size;

			// Token: 0x04000315 RID: 789
			public int native_size;

			// Token: 0x04000316 RID: 790
			public uint static_fields_size;

			// Token: 0x04000317 RID: 791
			public uint thread_static_fields_size;

			// Token: 0x04000318 RID: 792
			public int thread_static_fields_offset;

			// Token: 0x04000319 RID: 793
			public uint flags;

			// Token: 0x0400031A RID: 794
			public ushort method_count;

			// Token: 0x0400031B RID: 795
			public ushort property_count;

			// Token: 0x0400031C RID: 796
			public ushort field_count;

			// Token: 0x0400031D RID: 797
			public ushort event_count;

			// Token: 0x0400031E RID: 798
			public ushort nested_type_count;

			// Token: 0x0400031F RID: 799
			public ushort vtable_count;

			// Token: 0x04000320 RID: 800
			public ushort interfaces_count;

			// Token: 0x04000321 RID: 801
			public ushort interface_offsets_count;

			// Token: 0x04000322 RID: 802
			public byte typeHierarchyDepth;

			// Token: 0x04000323 RID: 803
			public byte rank;

			// Token: 0x04000324 RID: 804
			public byte minimumAlignment;

			// Token: 0x04000325 RID: 805
			public byte packingSize;

			// Token: 0x04000326 RID: 806
			public NativeClassStructHandler_16_0.Il2CppClass_16_0.Bitfield0 _bitfield0;

			// Token: 0x020000BD RID: 189
			internal enum Bitfield0 : ushort
			{
				// Token: 0x04000328 RID: 808
				BIT_valuetype,
				// Token: 0x04000329 RID: 809
				valuetype,
				// Token: 0x0400032A RID: 810
				BIT_initialized = 1,
				// Token: 0x0400032B RID: 811
				initialized,
				// Token: 0x0400032C RID: 812
				BIT_enumtype = 2,
				// Token: 0x0400032D RID: 813
				enumtype = 4,
				// Token: 0x0400032E RID: 814
				BIT_is_generic = 3,
				// Token: 0x0400032F RID: 815
				is_generic = 8,
				// Token: 0x04000330 RID: 816
				BIT_has_references = 4,
				// Token: 0x04000331 RID: 817
				has_references = 16,
				// Token: 0x04000332 RID: 818
				BIT_init_pending = 5,
				// Token: 0x04000333 RID: 819
				init_pending = 32,
				// Token: 0x04000334 RID: 820
				BIT_size_inited = 6,
				// Token: 0x04000335 RID: 821
				size_inited = 64,
				// Token: 0x04000336 RID: 822
				BIT_has_finalize = 7,
				// Token: 0x04000337 RID: 823
				has_finalize = 128,
				// Token: 0x04000338 RID: 824
				BIT_has_cctor = 8,
				// Token: 0x04000339 RID: 825
				has_cctor = 256,
				// Token: 0x0400033A RID: 826
				BIT_is_blittable = 9,
				// Token: 0x0400033B RID: 827
				is_blittable = 512
			}
		}

		// Token: 0x020000BE RID: 190
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x060006BB RID: 1723 RVA: 0x0001C90C File Offset: 0x0001AB0C
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_16_0.NativeStructWrapper.VwdfaXDmU6Ln2yjZPj4();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_315c1a09bac64a059f24e58be082c9be != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_30f9f5d7d3f347ddac00a7ce0719d7cd != 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x17000198 RID: 408
			// (get) Token: 0x060006BC RID: 1724 RVA: 0x0001C99C File Offset: 0x0001AB9C
			private unsafe NativeClassStructHandler_16_0.Il2CppClass_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000199 RID: 409
			// (get) Token: 0x060006BD RID: 1725 RVA: 0x0001C9AC File Offset: 0x0001ABAC
			// (set) Token: 0x060006BE RID: 1726 RVA: 0x0001C9C4 File Offset: 0x0001ABC4
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
						case 1:
							this.SetBit(NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b1a14f54e3674a8baf7d5ab6ab85764a != 0)
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

			// Token: 0x1700019A RID: 410
			// (get) Token: 0x060006BF RID: 1727 RVA: 0x0001CA28 File Offset: 0x0001AC28
			public IntPtr Pointer { get; }

			// Token: 0x1700019B RID: 411
			// (get) Token: 0x060006C0 RID: 1728 RVA: 0x0001CA38 File Offset: 0x0001AC38
			public IntPtr VTable
			{
				get
				{
					return apS1BFcfBa3gXUspL9j.muOq5LWqgj(this.Pointer, sizeof(NativeClassStructHandler_16_0.Il2CppClass_16_0), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x1700019C RID: 412
			// (get) Token: 0x060006C1 RID: 1729 RVA: 0x0001CA58 File Offset: 0x0001AC58
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700019D RID: 413
			// (get) Token: 0x060006C2 RID: 1730 RVA: 0x0001CA68 File Offset: 0x0001AC68
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->byval_arg);
				}
			}

			// Token: 0x1700019E RID: 414
			// (get) Token: 0x060006C3 RID: 1731 RVA: 0x0001CA84 File Offset: 0x0001AC84
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->this_arg);
				}
			}

			// Token: 0x1700019F RID: 415
			// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0001CAA0 File Offset: 0x0001ACA0
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x170001A0 RID: 416
			// (get) Token: 0x060006C5 RID: 1733 RVA: 0x0001CAB4 File Offset: 0x0001ACB4
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x170001A1 RID: 417
			// (get) Token: 0x060006C6 RID: 1734 RVA: 0x0001CAC8 File Offset: 0x0001ACC8
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x170001A2 RID: 418
			// (get) Token: 0x060006C7 RID: 1735 RVA: 0x0001CADC File Offset: 0x0001ACDC
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x060006C8 RID: 1736 RVA: 0x0001CAF0 File Offset: 0x0001ACF0
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x170001A4 RID: 420
			// (get) Token: 0x060006C9 RID: 1737 RVA: 0x0001CB04 File Offset: 0x0001AD04
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x060006CA RID: 1738 RVA: 0x0001CB18 File Offset: 0x0001AD18
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x060006CB RID: 1739 RVA: 0x0001CB2C File Offset: 0x0001AD2C
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x060006CC RID: 1740 RVA: 0x0001CB40 File Offset: 0x0001AD40
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x060006CD RID: 1741 RVA: 0x0001CB54 File Offset: 0x0001AD54
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x060006CE RID: 1742 RVA: 0x0001CB6C File Offset: 0x0001AD6C
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170001AA RID: 426
			// (get) Token: 0x060006CF RID: 1743 RVA: 0x0001CB84 File Offset: 0x0001AD84
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x170001AB RID: 427
			// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0001CB9C File Offset: 0x0001AD9C
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x170001AC RID: 428
			// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0001CBB0 File Offset: 0x0001ADB0
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x170001AD RID: 429
			// (get) Token: 0x060006D2 RID: 1746 RVA: 0x0001CBC4 File Offset: 0x0001ADC4
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x170001AE RID: 430
			// (get) Token: 0x060006D3 RID: 1747 RVA: 0x0001CBD8 File Offset: 0x0001ADD8
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x170001AF RID: 431
			// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0001CBEC File Offset: 0x0001ADEC
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x170001B0 RID: 432
			// (get) Token: 0x060006D5 RID: 1749 RVA: 0x0001CC00 File Offset: 0x0001AE00
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._klassDummy;
				}
			}

			// Token: 0x170001B1 RID: 433
			// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0001CC10 File Offset: 0x0001AE10
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x170001B2 RID: 434
			// (get) Token: 0x060006D7 RID: 1751 RVA: 0x0001CC24 File Offset: 0x0001AE24
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x170001B3 RID: 435
			// (get) Token: 0x060006D8 RID: 1752 RVA: 0x0001CC38 File Offset: 0x0001AE38
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x170001B4 RID: 436
			// (get) Token: 0x060006D9 RID: 1753 RVA: 0x0001CC4C File Offset: 0x0001AE4C
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x170001B5 RID: 437
			// (get) Token: 0x060006DA RID: 1754 RVA: 0x0001CC60 File Offset: 0x0001AE60
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x170001B6 RID: 438
			// (get) Token: 0x060006DB RID: 1755 RVA: 0x0001CC74 File Offset: 0x0001AE74
			// (set) Token: 0x060006DC RID: 1756 RVA: 0x0001CC8C File Offset: 0x0001AE8C
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_16_0.NativeStructWrapper.D2ecd7D7kQ6TOEqQQ7N(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 0);
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
							this.SetBit(NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_64a8b41e58e0491ab0e9d05ec5ed61d3 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170001B7 RID: 439
			// (get) Token: 0x060006DD RID: 1757 RVA: 0x0001CCF0 File Offset: 0x0001AEF0
			// (set) Token: 0x060006DE RID: 1758 RVA: 0x0001CD08 File Offset: 0x0001AF08
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_16_0.NativeStructWrapper.D2ecd7D7kQ6TOEqQQ7N(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_16_0.NativeStructWrapper.bnljqPDP2VCDCqZBdHY(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8160363759e64728b1ce193157380515 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170001B8 RID: 440
			// (get) Token: 0x060006DF RID: 1759 RVA: 0x0001CD6C File Offset: 0x0001AF6C
			// (set) Token: 0x060006E0 RID: 1760 RVA: 0x0001CD84 File Offset: 0x0001AF84
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_16_0.NativeStructWrapper.D2ecd7D7kQ6TOEqQQ7N(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_16_0.NativeStructWrapper.bnljqPDP2VCDCqZBdHY(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4356a7af7f8147b79f2ed4ab0c268438 == 0)
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

			// Token: 0x170001B9 RID: 441
			// (get) Token: 0x060006E1 RID: 1761 RVA: 0x0001CDE8 File Offset: 0x0001AFE8
			// (set) Token: 0x060006E2 RID: 1762 RVA: 0x0001CE00 File Offset: 0x0001B000
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_16_0.NativeStructWrapper.D2ecd7D7kQ6TOEqQQ7N(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_16_0.NativeStructWrapper.bnljqPDP2VCDCqZBdHY(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4c6a46c0a2d14747aa1dc5bf1581154d == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170001BA RID: 442
			// (get) Token: 0x060006E3 RID: 1763 RVA: 0x0001CE64 File Offset: 0x0001B064
			// (set) Token: 0x060006E4 RID: 1764 RVA: 0x0001CE7C File Offset: 0x0001B07C
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_16_0.NativeStructWrapper.D2ecd7D7kQ6TOEqQQ7N(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 6);
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
							NativeClassStructHandler_16_0.NativeStructWrapper.bnljqPDP2VCDCqZBdHY(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b329e831708e4d29ae561982d3d8c1c1 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170001BB RID: 443
			// (get) Token: 0x060006E5 RID: 1765 RVA: 0x0001CEE0 File Offset: 0x0001B0E0
			// (set) Token: 0x060006E6 RID: 1766 RVA: 0x0001CEF8 File Offset: 0x0001B0F8
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_16_0.NativeStructWrapper.D2ecd7D7kQ6TOEqQQ7N(this, NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 7);
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
							this.SetBit(NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_856ffe7e0c9b4de88d71070d175d49fd != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170001BC RID: 444
			// (get) Token: 0x060006E7 RID: 1767 RVA: 0x0001CF5C File Offset: 0x0001B15C
			// (set) Token: 0x060006E8 RID: 1768 RVA: 0x0001CF68 File Offset: 0x0001B168
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
			// (get) Token: 0x060006E9 RID: 1769 RVA: 0x0001CF74 File Offset: 0x0001B174
			// (set) Token: 0x060006EA RID: 1770 RVA: 0x0001CF80 File Offset: 0x0001B180
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

			// Token: 0x060006EB RID: 1771 RVA: 0x0001CF8C File Offset: 0x0001B18C
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
						NativeClassStructHandler_16_0.NativeStructWrapper.psfOTYD4a8LE3gRHXkZ();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2ec67b9ff6c4cd7af2a4ceec32c111c != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_16_0.Il2CppClass_16_0>(NativeClassStructHandler_16_0.NativeStructWrapper.VxUl3yDfYYjQy6TEfRk(1919189329 ^ 650920482 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e5b00aa4c99144c78d3bd63e270496cb));
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5 != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					}
					case 3:
						NativeClassStructHandler_16_0.NativeStructWrapper.ywmg86D3w3Nh3j1GZwQ();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_22f9ae9a49f143d7bbb3b03eb2446c0f == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						return;
					case 5:
					{
						IntPtr intPtr;
						NativeClassStructHandler_16_0.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 4;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_124ad935e0834fda9ae7f452377dbe1c == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					}
					NativeClassStructHandler_16_0.NativeStructWrapper.VwdfaXDmU6Ln2yjZPj4();
					num2 = 3;
				}
			}

			// Token: 0x060006EC RID: 1772 RVA: 0x0001D09C File Offset: 0x0001B29C
			internal static void VwdfaXDmU6Ln2yjZPj4()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060006ED RID: 1773 RVA: 0x0001D0AC File Offset: 0x0001B2AC
			internal static bool fvrUggDulymnL1YIrub()
			{
				return NativeClassStructHandler_16_0.NativeStructWrapper.mS2WNpDNJcuEiw1SvMm == null;
			}

			// Token: 0x060006EE RID: 1774 RVA: 0x0001D0C0 File Offset: 0x0001B2C0
			internal static NativeClassStructHandler_16_0.NativeStructWrapper MMeE8CDDEby5dEG7avI()
			{
				return NativeClassStructHandler_16_0.NativeStructWrapper.mS2WNpDNJcuEiw1SvMm;
			}

			// Token: 0x060006EF RID: 1775 RVA: 0x0001D0D0 File Offset: 0x0001B2D0
			internal static bool D2ecd7D7kQ6TOEqQQ7N(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060006F0 RID: 1776 RVA: 0x0001D0EC File Offset: 0x0001B2EC
			internal static void bnljqPDP2VCDCqZBdHY(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x060006F1 RID: 1777 RVA: 0x0001D10C File Offset: 0x0001B30C
			internal static void psfOTYD4a8LE3gRHXkZ()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x060006F2 RID: 1778 RVA: 0x0001D11C File Offset: 0x0001B31C
			internal static void ywmg86D3w3Nh3j1GZwQ()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x060006F3 RID: 1779 RVA: 0x0001D12C File Offset: 0x0001B32C
			internal static object VxUl3yDfYYjQy6TEfRk(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x0400033C RID: 828
			private static readonly int _bitfield0offset;

			// Token: 0x0400033D RID: 829
			private unsafe Il2CppClass* _klassDummy;

			// Token: 0x0400033F RID: 831
			internal static object mS2WNpDNJcuEiw1SvMm;
		}
	}
}
