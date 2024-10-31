using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000BF RID: 191
	[ApplicableToUnityVersionsSince("5.3.2")]
	public class NativeClassStructHandler_19_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x060006F4 RID: 1780 RVA: 0x00010500 File Offset: 0x0000E700
		public int Size()
		{
			return sizeof(NativeClassStructHandler_19_0.Il2CppClass_19_0);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00010510 File Offset: 0x0000E710
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
					NativeClassStructHandler_19_0.Il2CppClass_19_0* ptr;
					IntPtr buffer = ptr = NativeClassStructHandler_19_0.CCMpW06yU71tMxNwOpm(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
					*ptr = default(NativeClassStructHandler_19_0.Il2CppClass_19_0);
					NativeClassStructHandler_19_0.HC1KcP6Jvu1MIWuo7P5(buffer);
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b544c260d8647ebad150746ba137290 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				}
				break;
			}
			throw new NotSupportedException(NativeClassStructHandler_19_0.o8fCSL6pxhlpAgSgA72(-1335908298 ^ -1092212797 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa));
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x000105AC File Offset: 0x0000E7AC
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_07ecbd0ef7af44eb94dd5a58ea706c8a == 0)
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

		// Token: 0x060006F7 RID: 1783 RVA: 0x00010614 File Offset: 0x0000E814
		public NativeClassStructHandler_19_0()
		{
			NativeClassStructHandler_19_0.mtbs8i6VOVHhJnKqoBl();
			NativeClassStructHandler_19_0.IHOX5360EmIHXhnGOTV();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3bc41e98a8e849aea1e93dfe0f04c43b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00010678 File Offset: 0x0000E878
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_19_0()
		{
			NativeClassStructHandler_19_0.YHDPri6sl9Zp8xdkDnK();
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00010688 File Offset: 0x0000E888
		internal static IntPtr CCMpW06yU71tMxNwOpm(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0001069C File Offset: 0x0000E89C
		internal static void HC1KcP6Jvu1MIWuo7P5(IntPtr buffer)
		{
			MarshalExtend.FreeHGlobal(buffer);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x000106B0 File Offset: 0x0000E8B0
		internal static object o8fCSL6pxhlpAgSgA72(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x000106C4 File Offset: 0x0000E8C4
		internal static bool aPIVCQ6bcKvLbmj4Hql()
		{
			return NativeClassStructHandler_19_0.qkoyhA6nGa8vdImrnjC == null;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x000106D8 File Offset: 0x0000E8D8
		internal static NativeClassStructHandler_19_0 FLgYQG66vJckXRG4y1W()
		{
			return NativeClassStructHandler_19_0.qkoyhA6nGa8vdImrnjC;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x000106E8 File Offset: 0x0000E8E8
		internal static void mtbs8i6VOVHhJnKqoBl()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x000106F8 File Offset: 0x0000E8F8
		internal static void IHOX5360EmIHXhnGOTV()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00010708 File Offset: 0x0000E908
		internal static void YHDPri6sl9Zp8xdkDnK()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000340 RID: 832
		private static NativeClassStructHandler_19_0 qkoyhA6nGa8vdImrnjC;

		// Token: 0x020000C0 RID: 192
		internal struct Il2CppClass_19_0
		{
			// Token: 0x04000341 RID: 833
			public unsafe Il2CppImage* image;

			// Token: 0x04000342 RID: 834
			public unsafe void* gc_desc;

			// Token: 0x04000343 RID: 835
			public unsafe byte* name;

			// Token: 0x04000344 RID: 836
			public unsafe byte* namespaze;

			// Token: 0x04000345 RID: 837
			public unsafe Il2CppTypeStruct* byval_arg;

			// Token: 0x04000346 RID: 838
			public unsafe Il2CppTypeStruct* this_arg;

			// Token: 0x04000347 RID: 839
			public unsafe Il2CppClass* element_class;

			// Token: 0x04000348 RID: 840
			public unsafe Il2CppClass* castClass;

			// Token: 0x04000349 RID: 841
			public unsafe Il2CppClass* declaringType;

			// Token: 0x0400034A RID: 842
			public unsafe Il2CppClass* parent;

			// Token: 0x0400034B RID: 843
			public unsafe void* generic_class;

			// Token: 0x0400034C RID: 844
			public unsafe void* typeDefinition;

			// Token: 0x0400034D RID: 845
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x0400034E RID: 846
			public unsafe Il2CppEventInfo* events;

			// Token: 0x0400034F RID: 847
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000350 RID: 848
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x04000351 RID: 849
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000352 RID: 850
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x04000353 RID: 851
			public unsafe Il2CppMethodInfo** vtable;

			// Token: 0x04000354 RID: 852
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x04000355 RID: 853
			public unsafe void* static_fields;

			// Token: 0x04000356 RID: 854
			public unsafe void* rgctx_data;

			// Token: 0x04000357 RID: 855
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x04000358 RID: 856
			public uint cctor_started;

			// Token: 0x04000359 RID: 857
			public uint cctor_finished;

			// Token: 0x0400035A RID: 858
			public ulong cctor_thread;

			// Token: 0x0400035B RID: 859
			public int genericContainerIndex;

			// Token: 0x0400035C RID: 860
			public int customAttributeIndex;

			// Token: 0x0400035D RID: 861
			public uint instance_size;

			// Token: 0x0400035E RID: 862
			public uint actualSize;

			// Token: 0x0400035F RID: 863
			public uint element_size;

			// Token: 0x04000360 RID: 864
			public int native_size;

			// Token: 0x04000361 RID: 865
			public uint static_fields_size;

			// Token: 0x04000362 RID: 866
			public uint thread_static_fields_size;

			// Token: 0x04000363 RID: 867
			public int thread_static_fields_offset;

			// Token: 0x04000364 RID: 868
			public uint flags;

			// Token: 0x04000365 RID: 869
			public uint token;

			// Token: 0x04000366 RID: 870
			public ushort method_count;

			// Token: 0x04000367 RID: 871
			public ushort property_count;

			// Token: 0x04000368 RID: 872
			public ushort field_count;

			// Token: 0x04000369 RID: 873
			public ushort event_count;

			// Token: 0x0400036A RID: 874
			public ushort nested_type_count;

			// Token: 0x0400036B RID: 875
			public ushort vtable_count;

			// Token: 0x0400036C RID: 876
			public ushort interfaces_count;

			// Token: 0x0400036D RID: 877
			public ushort interface_offsets_count;

			// Token: 0x0400036E RID: 878
			public byte typeHierarchyDepth;

			// Token: 0x0400036F RID: 879
			public byte rank;

			// Token: 0x04000370 RID: 880
			public byte minimumAlignment;

			// Token: 0x04000371 RID: 881
			public byte packingSize;

			// Token: 0x04000372 RID: 882
			public NativeClassStructHandler_19_0.Il2CppClass_19_0.Bitfield0 _bitfield0;

			// Token: 0x020000C1 RID: 193
			internal enum Bitfield0 : ushort
			{
				// Token: 0x04000374 RID: 884
				BIT_valuetype,
				// Token: 0x04000375 RID: 885
				valuetype,
				// Token: 0x04000376 RID: 886
				BIT_initialized = 1,
				// Token: 0x04000377 RID: 887
				initialized,
				// Token: 0x04000378 RID: 888
				BIT_enumtype = 2,
				// Token: 0x04000379 RID: 889
				enumtype = 4,
				// Token: 0x0400037A RID: 890
				BIT_is_generic = 3,
				// Token: 0x0400037B RID: 891
				is_generic = 8,
				// Token: 0x0400037C RID: 892
				BIT_has_references = 4,
				// Token: 0x0400037D RID: 893
				has_references = 16,
				// Token: 0x0400037E RID: 894
				BIT_init_pending = 5,
				// Token: 0x0400037F RID: 895
				init_pending = 32,
				// Token: 0x04000380 RID: 896
				BIT_size_inited = 6,
				// Token: 0x04000381 RID: 897
				size_inited = 64,
				// Token: 0x04000382 RID: 898
				BIT_has_finalize = 7,
				// Token: 0x04000383 RID: 899
				has_finalize = 128,
				// Token: 0x04000384 RID: 900
				BIT_has_cctor = 8,
				// Token: 0x04000385 RID: 901
				has_cctor = 256,
				// Token: 0x04000386 RID: 902
				BIT_is_blittable = 9,
				// Token: 0x04000387 RID: 903
				is_blittable = 512
			}
		}

		// Token: 0x020000C2 RID: 194
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000701 RID: 1793 RVA: 0x0001D140 File Offset: 0x0001B340
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_19_0.NativeStructWrapper.QtnrWCD9dOvT9822Ogn();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c975b252adfc48c4b262398638f90354 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ce8abd079f9447b3bade260ffc64f0b8 == 0)
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
			// (get) Token: 0x06000702 RID: 1794 RVA: 0x0001D1D0 File Offset: 0x0001B3D0
			private unsafe NativeClassStructHandler_19_0.Il2CppClass_19_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170001BF RID: 447
			// (get) Token: 0x06000703 RID: 1795 RVA: 0x0001D1E0 File Offset: 0x0001B3E0
			// (set) Token: 0x06000704 RID: 1796 RVA: 0x0001D1F8 File Offset: 0x0001B3F8
			public bool HasReferences
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_19_0.NativeStructWrapper.Tj9eEoDIkBB9XJEc4dx(this, NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_45f0db95dace45b6a0257ae80a3038eb == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170001C0 RID: 448
			// (get) Token: 0x06000705 RID: 1797 RVA: 0x0001D25C File Offset: 0x0001B45C
			public IntPtr Pointer { get; }

			// Token: 0x170001C1 RID: 449
			// (get) Token: 0x06000706 RID: 1798 RVA: 0x0001D26C File Offset: 0x0001B46C
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_19_0.NativeStructWrapper.DrDdZJDd7nKVlNgvaLc(this.Pointer, sizeof(NativeClassStructHandler_19_0.Il2CppClass_19_0), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x170001C2 RID: 450
			// (get) Token: 0x06000707 RID: 1799 RVA: 0x0001D28C File Offset: 0x0001B48C
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170001C3 RID: 451
			// (get) Token: 0x06000708 RID: 1800 RVA: 0x0001D29C File Offset: 0x0001B49C
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->byval_arg);
				}
			}

			// Token: 0x170001C4 RID: 452
			// (get) Token: 0x06000709 RID: 1801 RVA: 0x0001D2B8 File Offset: 0x0001B4B8
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->this_arg);
				}
			}

			// Token: 0x170001C5 RID: 453
			// (get) Token: 0x0600070A RID: 1802 RVA: 0x0001D2D4 File Offset: 0x0001B4D4
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x170001C6 RID: 454
			// (get) Token: 0x0600070B RID: 1803 RVA: 0x0001D2E8 File Offset: 0x0001B4E8
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x170001C7 RID: 455
			// (get) Token: 0x0600070C RID: 1804 RVA: 0x0001D2FC File Offset: 0x0001B4FC
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x170001C8 RID: 456
			// (get) Token: 0x0600070D RID: 1805 RVA: 0x0001D310 File Offset: 0x0001B510
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x170001C9 RID: 457
			// (get) Token: 0x0600070E RID: 1806 RVA: 0x0001D324 File Offset: 0x0001B524
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x170001CA RID: 458
			// (get) Token: 0x0600070F RID: 1807 RVA: 0x0001D338 File Offset: 0x0001B538
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x170001CB RID: 459
			// (get) Token: 0x06000710 RID: 1808 RVA: 0x0001D34C File Offset: 0x0001B54C
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x170001CC RID: 460
			// (get) Token: 0x06000711 RID: 1809 RVA: 0x0001D360 File Offset: 0x0001B560
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x170001CD RID: 461
			// (get) Token: 0x06000712 RID: 1810 RVA: 0x0001D374 File Offset: 0x0001B574
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x170001CE RID: 462
			// (get) Token: 0x06000713 RID: 1811 RVA: 0x0001D388 File Offset: 0x0001B588
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x170001CF RID: 463
			// (get) Token: 0x06000714 RID: 1812 RVA: 0x0001D3A0 File Offset: 0x0001B5A0
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170001D0 RID: 464
			// (get) Token: 0x06000715 RID: 1813 RVA: 0x0001D3B8 File Offset: 0x0001B5B8
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x170001D1 RID: 465
			// (get) Token: 0x06000716 RID: 1814 RVA: 0x0001D3D0 File Offset: 0x0001B5D0
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x170001D2 RID: 466
			// (get) Token: 0x06000717 RID: 1815 RVA: 0x0001D3E4 File Offset: 0x0001B5E4
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x170001D3 RID: 467
			// (get) Token: 0x06000718 RID: 1816 RVA: 0x0001D3F8 File Offset: 0x0001B5F8
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x170001D4 RID: 468
			// (get) Token: 0x06000719 RID: 1817 RVA: 0x0001D40C File Offset: 0x0001B60C
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x170001D5 RID: 469
			// (get) Token: 0x0600071A RID: 1818 RVA: 0x0001D420 File Offset: 0x0001B620
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x170001D6 RID: 470
			// (get) Token: 0x0600071B RID: 1819 RVA: 0x0001D434 File Offset: 0x0001B634
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._klassDummy;
				}
			}

			// Token: 0x170001D7 RID: 471
			// (get) Token: 0x0600071C RID: 1820 RVA: 0x0001D444 File Offset: 0x0001B644
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x170001D8 RID: 472
			// (get) Token: 0x0600071D RID: 1821 RVA: 0x0001D458 File Offset: 0x0001B658
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x170001D9 RID: 473
			// (get) Token: 0x0600071E RID: 1822 RVA: 0x0001D46C File Offset: 0x0001B66C
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x170001DA RID: 474
			// (get) Token: 0x0600071F RID: 1823 RVA: 0x0001D480 File Offset: 0x0001B680
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x170001DB RID: 475
			// (get) Token: 0x06000720 RID: 1824 RVA: 0x0001D494 File Offset: 0x0001B694
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x170001DC RID: 476
			// (get) Token: 0x06000721 RID: 1825 RVA: 0x0001D4A8 File Offset: 0x0001B6A8
			// (set) Token: 0x06000722 RID: 1826 RVA: 0x0001D4C0 File Offset: 0x0001B6C0
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_19_0.NativeStructWrapper.G8Yge3DiSD5APgBS36X(this, NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_19_0.NativeStructWrapper.Tj9eEoDIkBB9XJEc4dx(this, NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6e0b93a59f7244c4b07385ec95383bee == 0)
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
			// (get) Token: 0x06000723 RID: 1827 RVA: 0x0001D524 File Offset: 0x0001B724
			// (set) Token: 0x06000724 RID: 1828 RVA: 0x0001D53C File Offset: 0x0001B73C
			public bool Initialized
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_19_0.NativeStructWrapper.Tj9eEoDIkBB9XJEc4dx(this, NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b169d8ea412f45e99e430384ddc8908b != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170001DE RID: 478
			// (get) Token: 0x06000725 RID: 1829 RVA: 0x0001D5A0 File Offset: 0x0001B7A0
			// (set) Token: 0x06000726 RID: 1830 RVA: 0x0001D5B8 File Offset: 0x0001B7B8
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_19_0.NativeStructWrapper.G8Yge3DiSD5APgBS36X(this, NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 2);
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
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_fe27a6a8bfb848d1a3dd32bc5b1790e7 == 0)
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
			// (get) Token: 0x06000727 RID: 1831 RVA: 0x0001D61C File Offset: 0x0001B81C
			// (set) Token: 0x06000728 RID: 1832 RVA: 0x0001D634 File Offset: 0x0001B834
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_19_0.NativeStructWrapper.G8Yge3DiSD5APgBS36X(this, NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_19_0.NativeStructWrapper.Tj9eEoDIkBB9XJEc4dx(this, NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_64a8b41e58e0491ab0e9d05ec5ed61d3 != 0)
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

			// Token: 0x170001E0 RID: 480
			// (get) Token: 0x06000729 RID: 1833 RVA: 0x0001D698 File Offset: 0x0001B898
			// (set) Token: 0x0600072A RID: 1834 RVA: 0x0001D6B0 File Offset: 0x0001B8B0
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_19_0.NativeStructWrapper.G8Yge3DiSD5APgBS36X(this, NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 6);
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
							NativeClassStructHandler_19_0.NativeStructWrapper.Tj9eEoDIkBB9XJEc4dx(this, NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cfadd7e02c524ea298356b7415bd67b6 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170001E1 RID: 481
			// (get) Token: 0x0600072B RID: 1835 RVA: 0x0001D714 File Offset: 0x0001B914
			// (set) Token: 0x0600072C RID: 1836 RVA: 0x0001D72C File Offset: 0x0001B92C
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_19_0.NativeStructWrapper.G8Yge3DiSD5APgBS36X(this, NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 7);
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
							this.SetBit(NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset, 7, value);
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

			// Token: 0x170001E2 RID: 482
			// (get) Token: 0x0600072D RID: 1837 RVA: 0x0001D790 File Offset: 0x0001B990
			// (set) Token: 0x0600072E RID: 1838 RVA: 0x0001D79C File Offset: 0x0001B99C
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
			// (get) Token: 0x0600072F RID: 1839 RVA: 0x0001D7A8 File Offset: 0x0001B9A8
			// (set) Token: 0x06000730 RID: 1840 RVA: 0x0001D7B4 File Offset: 0x0001B9B4
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

			// Token: 0x06000731 RID: 1841 RVA: 0x0001D7C0 File Offset: 0x0001B9C0
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 5;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
					{
						IntPtr intPtr;
						NativeClassStructHandler_19_0.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 2;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_15379a47ca764a4e8e16ceaf4804e136 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					case 2:
						return;
					case 3:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_19_0.Il2CppClass_19_0>(NativeClassStructHandler_19_0.NativeStructWrapper.Fqisd1DEtEgLb64bawr(-104288533 + 922129515 ^ 1000594272 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e6eb36653ec04a89bf8fa64932849f3b));
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_315c1a09bac64a059f24e58be082c9be != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					case 4:
						hIDAYxH6DWLHIthQgC.oDuBOTgYK();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_30f9f5d7d3f347ddac00a7ce0719d7cd != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						hIDAYxH6DWLHIthQgC.zSLipEDdx();
						num2 = 4;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4356a7af7f8147b79f2ed4ab0c268438 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					NativeClassStructHandler_19_0.NativeStructWrapper.nIvXnUDwwoKHLm5LgE0();
					num2 = 3;
				}
			}

			// Token: 0x06000732 RID: 1842 RVA: 0x0001D8D8 File Offset: 0x0001BAD8
			internal static void QtnrWCD9dOvT9822Ogn()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000733 RID: 1843 RVA: 0x0001D8E8 File Offset: 0x0001BAE8
			internal static bool O4F0OSDWPtBvxfG819B()
			{
				return NativeClassStructHandler_19_0.NativeStructWrapper.q4qrGrDMLVvOSDJjr2v == null;
			}

			// Token: 0x06000734 RID: 1844 RVA: 0x0001D8FC File Offset: 0x0001BAFC
			internal static NativeClassStructHandler_19_0.NativeStructWrapper trArq3DCMl0YSho3rys()
			{
				return NativeClassStructHandler_19_0.NativeStructWrapper.q4qrGrDMLVvOSDJjr2v;
			}

			// Token: 0x06000735 RID: 1845 RVA: 0x0001D90C File Offset: 0x0001BB0C
			internal static void Tj9eEoDIkBB9XJEc4dx(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000736 RID: 1846 RVA: 0x0001D92C File Offset: 0x0001BB2C
			internal static IntPtr DrDdZJDd7nKVlNgvaLc(IntPtr A_0, int A_1, object A_2)
			{
				return apS1BFcfBa3gXUspL9j.muOq5LWqgj(A_0, A_1, A_2);
			}

			// Token: 0x06000737 RID: 1847 RVA: 0x0001D948 File Offset: 0x0001BB48
			internal static bool G8Yge3DiSD5APgBS36X(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000738 RID: 1848 RVA: 0x0001D964 File Offset: 0x0001BB64
			internal static void nIvXnUDwwoKHLm5LgE0()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000739 RID: 1849 RVA: 0x0001D974 File Offset: 0x0001BB74
			internal static object Fqisd1DEtEgLb64bawr(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000388 RID: 904
			private static readonly int _bitfield0offset;

			// Token: 0x04000389 RID: 905
			private unsafe Il2CppClass* _klassDummy;

			// Token: 0x0400038B RID: 907
			internal static object q4qrGrDMLVvOSDJjr2v;
		}
	}
}
