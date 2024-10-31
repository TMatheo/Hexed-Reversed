using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000C3 RID: 195
	[ApplicableToUnityVersionsSince("5.3.3")]
	public class NativeClassStructHandler_20_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x0600073A RID: 1850 RVA: 0x00010718 File Offset: 0x0000E918
		public int Size()
		{
			return sizeof(NativeClassStructHandler_20_0.Il2CppClass_20_0);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00010728 File Offset: 0x0000E928
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
					NativeClassStructHandler_20_0.Il2CppClass_20_0* ptr;
					IntPtr buffer = ptr = NativeClassStructHandler_20_0.z2nEbM6D54xCleZkuPO(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
					*ptr = default(NativeClassStructHandler_20_0.Il2CppClass_20_0);
					MarshalExtend.FreeHGlobal(buffer);
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3e2009ed69c04f5799431b4e58cafb2a != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				}
				break;
			}
			throw new NotSupportedException(NativeClassStructHandler_20_0.kyR4n66mFIMxgreo3P4(1760926646 ^ -616978438 ^ -1185336787 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_420bdc7f003c47439a9f8331e71194a1));
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x000107CC File Offset: 0x0000E9CC
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7b01772eb8964b6a81d74c3d1c2f871e != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeClassStructHandler_20_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00010834 File Offset: 0x0000EA34
		public NativeClassStructHandler_20_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeClassStructHandler_20_0.SVx2O767k00bkGNoB6G();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6c17eda4faca4bd29ba4134efb91a5a8 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00010898 File Offset: 0x0000EA98
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_20_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000108A8 File Offset: 0x0000EAA8
		internal static IntPtr z2nEbM6D54xCleZkuPO(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000108BC File Offset: 0x0000EABC
		internal static object kyR4n66mFIMxgreo3P4(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000108D0 File Offset: 0x0000EAD0
		internal static bool wrcAH86NB129QFRSYY3()
		{
			return NativeClassStructHandler_20_0.PX3UWb6SH1Lm0wN1kQ7 == null;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000108E4 File Offset: 0x0000EAE4
		internal static NativeClassStructHandler_20_0 Lchkn46uimVWJxbuhLp()
		{
			return NativeClassStructHandler_20_0.PX3UWb6SH1Lm0wN1kQ7;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x000108F4 File Offset: 0x0000EAF4
		internal static void SVx2O767k00bkGNoB6G()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x0400038C RID: 908
		internal static NativeClassStructHandler_20_0 PX3UWb6SH1Lm0wN1kQ7;

		// Token: 0x020000C4 RID: 196
		internal struct Il2CppClass_20_0
		{
			// Token: 0x0400038D RID: 909
			public unsafe Il2CppImage* image;

			// Token: 0x0400038E RID: 910
			public unsafe void* gc_desc;

			// Token: 0x0400038F RID: 911
			public unsafe byte* name;

			// Token: 0x04000390 RID: 912
			public unsafe byte* namespaze;

			// Token: 0x04000391 RID: 913
			public unsafe Il2CppTypeStruct* byval_arg;

			// Token: 0x04000392 RID: 914
			public unsafe Il2CppTypeStruct* this_arg;

			// Token: 0x04000393 RID: 915
			public unsafe Il2CppClass* element_class;

			// Token: 0x04000394 RID: 916
			public unsafe Il2CppClass* castClass;

			// Token: 0x04000395 RID: 917
			public unsafe Il2CppClass* declaringType;

			// Token: 0x04000396 RID: 918
			public unsafe Il2CppClass* parent;

			// Token: 0x04000397 RID: 919
			public unsafe void* generic_class;

			// Token: 0x04000398 RID: 920
			public unsafe void* typeDefinition;

			// Token: 0x04000399 RID: 921
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x0400039A RID: 922
			public unsafe Il2CppEventInfo* events;

			// Token: 0x0400039B RID: 923
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x0400039C RID: 924
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x0400039D RID: 925
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x0400039E RID: 926
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x0400039F RID: 927
			public unsafe Il2CppMethodInfo** vtable;

			// Token: 0x040003A0 RID: 928
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x040003A1 RID: 929
			public unsafe void* static_fields;

			// Token: 0x040003A2 RID: 930
			public unsafe void* rgctx_data;

			// Token: 0x040003A3 RID: 931
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x040003A4 RID: 932
			public uint cctor_started;

			// Token: 0x040003A5 RID: 933
			public uint cctor_finished;

			// Token: 0x040003A6 RID: 934
			public ulong cctor_thread;

			// Token: 0x040003A7 RID: 935
			public int genericContainerIndex;

			// Token: 0x040003A8 RID: 936
			public int customAttributeIndex;

			// Token: 0x040003A9 RID: 937
			public uint instance_size;

			// Token: 0x040003AA RID: 938
			public uint actualSize;

			// Token: 0x040003AB RID: 939
			public uint element_size;

			// Token: 0x040003AC RID: 940
			public int native_size;

			// Token: 0x040003AD RID: 941
			public uint static_fields_size;

			// Token: 0x040003AE RID: 942
			public uint thread_static_fields_size;

			// Token: 0x040003AF RID: 943
			public int thread_static_fields_offset;

			// Token: 0x040003B0 RID: 944
			public uint flags;

			// Token: 0x040003B1 RID: 945
			public uint token;

			// Token: 0x040003B2 RID: 946
			public ushort method_count;

			// Token: 0x040003B3 RID: 947
			public ushort property_count;

			// Token: 0x040003B4 RID: 948
			public ushort field_count;

			// Token: 0x040003B5 RID: 949
			public ushort event_count;

			// Token: 0x040003B6 RID: 950
			public ushort nested_type_count;

			// Token: 0x040003B7 RID: 951
			public ushort vtable_count;

			// Token: 0x040003B8 RID: 952
			public ushort interfaces_count;

			// Token: 0x040003B9 RID: 953
			public ushort interface_offsets_count;

			// Token: 0x040003BA RID: 954
			public byte typeHierarchyDepth;

			// Token: 0x040003BB RID: 955
			public byte rank;

			// Token: 0x040003BC RID: 956
			public byte minimumAlignment;

			// Token: 0x040003BD RID: 957
			public byte packingSize;

			// Token: 0x040003BE RID: 958
			public NativeClassStructHandler_20_0.Il2CppClass_20_0.Bitfield0 _bitfield0;

			// Token: 0x020000C5 RID: 197
			internal enum Bitfield0 : ushort
			{
				// Token: 0x040003C0 RID: 960
				BIT_valuetype,
				// Token: 0x040003C1 RID: 961
				valuetype,
				// Token: 0x040003C2 RID: 962
				BIT_initialized = 1,
				// Token: 0x040003C3 RID: 963
				initialized,
				// Token: 0x040003C4 RID: 964
				BIT_enumtype = 2,
				// Token: 0x040003C5 RID: 965
				enumtype = 4,
				// Token: 0x040003C6 RID: 966
				BIT_is_generic = 3,
				// Token: 0x040003C7 RID: 967
				is_generic = 8,
				// Token: 0x040003C8 RID: 968
				BIT_has_references = 4,
				// Token: 0x040003C9 RID: 969
				has_references = 16,
				// Token: 0x040003CA RID: 970
				BIT_init_pending = 5,
				// Token: 0x040003CB RID: 971
				init_pending = 32,
				// Token: 0x040003CC RID: 972
				BIT_size_inited = 6,
				// Token: 0x040003CD RID: 973
				size_inited = 64,
				// Token: 0x040003CE RID: 974
				BIT_has_finalize = 7,
				// Token: 0x040003CF RID: 975
				has_finalize = 128,
				// Token: 0x040003D0 RID: 976
				BIT_has_cctor = 8,
				// Token: 0x040003D1 RID: 977
				has_cctor = 256,
				// Token: 0x040003D2 RID: 978
				BIT_is_blittable = 9,
				// Token: 0x040003D3 RID: 979
				is_blittable = 512,
				// Token: 0x040003D4 RID: 980
				BIT_is_import = 10,
				// Token: 0x040003D5 RID: 981
				is_import = 1024
			}
		}

		// Token: 0x020000C6 RID: 198
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000744 RID: 1860 RVA: 0x0001D988 File Offset: 0x0001BB88
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeClassStructHandler_20_0.NativeStructWrapper.x4jbZ3DU4TcIodxcy70();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b329e831708e4d29ae561982d3d8c1c1 != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_faca03c2e5084297b7a5d894ac66fa57 != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x170001E4 RID: 484
			// (get) Token: 0x06000745 RID: 1861 RVA: 0x0001DA18 File Offset: 0x0001BC18
			private unsafe NativeClassStructHandler_20_0.Il2CppClass_20_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170001E5 RID: 485
			// (get) Token: 0x06000746 RID: 1862 RVA: 0x0001DA28 File Offset: 0x0001BC28
			// (set) Token: 0x06000747 RID: 1863 RVA: 0x0001DA40 File Offset: 0x0001BC40
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_20_0.NativeStructWrapper.cpdT2uDjIIisIfDsmns(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_20_0.NativeStructWrapper.lfsY23DQk0fjrGowgbD(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_9f61d52c010d488b818a577e37d289c0 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170001E6 RID: 486
			// (get) Token: 0x06000748 RID: 1864 RVA: 0x0001DAA4 File Offset: 0x0001BCA4
			public IntPtr Pointer { get; }

			// Token: 0x170001E7 RID: 487
			// (get) Token: 0x06000749 RID: 1865 RVA: 0x0001DAB4 File Offset: 0x0001BCB4
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_20_0.NativeStructWrapper.endT7sDeoejdPQcChF6(this.Pointer, sizeof(NativeClassStructHandler_20_0.Il2CppClass_20_0), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x170001E8 RID: 488
			// (get) Token: 0x0600074A RID: 1866 RVA: 0x0001DAD4 File Offset: 0x0001BCD4
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170001E9 RID: 489
			// (get) Token: 0x0600074B RID: 1867 RVA: 0x0001DAE4 File Offset: 0x0001BCE4
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->byval_arg);
				}
			}

			// Token: 0x170001EA RID: 490
			// (get) Token: 0x0600074C RID: 1868 RVA: 0x0001DB00 File Offset: 0x0001BD00
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->this_arg);
				}
			}

			// Token: 0x170001EB RID: 491
			// (get) Token: 0x0600074D RID: 1869 RVA: 0x0001DB1C File Offset: 0x0001BD1C
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x170001EC RID: 492
			// (get) Token: 0x0600074E RID: 1870 RVA: 0x0001DB30 File Offset: 0x0001BD30
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x170001ED RID: 493
			// (get) Token: 0x0600074F RID: 1871 RVA: 0x0001DB44 File Offset: 0x0001BD44
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x170001EE RID: 494
			// (get) Token: 0x06000750 RID: 1872 RVA: 0x0001DB58 File Offset: 0x0001BD58
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x170001EF RID: 495
			// (get) Token: 0x06000751 RID: 1873 RVA: 0x0001DB6C File Offset: 0x0001BD6C
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x170001F0 RID: 496
			// (get) Token: 0x06000752 RID: 1874 RVA: 0x0001DB80 File Offset: 0x0001BD80
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x170001F1 RID: 497
			// (get) Token: 0x06000753 RID: 1875 RVA: 0x0001DB94 File Offset: 0x0001BD94
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x170001F2 RID: 498
			// (get) Token: 0x06000754 RID: 1876 RVA: 0x0001DBA8 File Offset: 0x0001BDA8
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x170001F3 RID: 499
			// (get) Token: 0x06000755 RID: 1877 RVA: 0x0001DBBC File Offset: 0x0001BDBC
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x170001F4 RID: 500
			// (get) Token: 0x06000756 RID: 1878 RVA: 0x0001DBD0 File Offset: 0x0001BDD0
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x170001F5 RID: 501
			// (get) Token: 0x06000757 RID: 1879 RVA: 0x0001DBE8 File Offset: 0x0001BDE8
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170001F6 RID: 502
			// (get) Token: 0x06000758 RID: 1880 RVA: 0x0001DC00 File Offset: 0x0001BE00
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x170001F7 RID: 503
			// (get) Token: 0x06000759 RID: 1881 RVA: 0x0001DC18 File Offset: 0x0001BE18
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x170001F8 RID: 504
			// (get) Token: 0x0600075A RID: 1882 RVA: 0x0001DC2C File Offset: 0x0001BE2C
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x170001F9 RID: 505
			// (get) Token: 0x0600075B RID: 1883 RVA: 0x0001DC40 File Offset: 0x0001BE40
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x170001FA RID: 506
			// (get) Token: 0x0600075C RID: 1884 RVA: 0x0001DC54 File Offset: 0x0001BE54
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x170001FB RID: 507
			// (get) Token: 0x0600075D RID: 1885 RVA: 0x0001DC68 File Offset: 0x0001BE68
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x170001FC RID: 508
			// (get) Token: 0x0600075E RID: 1886 RVA: 0x0001DC7C File Offset: 0x0001BE7C
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._klassDummy;
				}
			}

			// Token: 0x170001FD RID: 509
			// (get) Token: 0x0600075F RID: 1887 RVA: 0x0001DC8C File Offset: 0x0001BE8C
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x170001FE RID: 510
			// (get) Token: 0x06000760 RID: 1888 RVA: 0x0001DCA0 File Offset: 0x0001BEA0
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x170001FF RID: 511
			// (get) Token: 0x06000761 RID: 1889 RVA: 0x0001DCB4 File Offset: 0x0001BEB4
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x17000200 RID: 512
			// (get) Token: 0x06000762 RID: 1890 RVA: 0x0001DCC8 File Offset: 0x0001BEC8
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x17000201 RID: 513
			// (get) Token: 0x06000763 RID: 1891 RVA: 0x0001DCDC File Offset: 0x0001BEDC
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x17000202 RID: 514
			// (get) Token: 0x06000764 RID: 1892 RVA: 0x0001DCF0 File Offset: 0x0001BEF0
			// (set) Token: 0x06000765 RID: 1893 RVA: 0x0001DD08 File Offset: 0x0001BF08
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_20_0.NativeStructWrapper.cpdT2uDjIIisIfDsmns(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 0);
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
							this.SetBit(NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e6eb36653ec04a89bf8fa64932849f3b != 0)
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

			// Token: 0x17000203 RID: 515
			// (get) Token: 0x06000766 RID: 1894 RVA: 0x0001DD6C File Offset: 0x0001BF6C
			// (set) Token: 0x06000767 RID: 1895 RVA: 0x0001DD84 File Offset: 0x0001BF84
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_20_0.NativeStructWrapper.cpdT2uDjIIisIfDsmns(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 1);
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
							this.SetBit(NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_315c1a09bac64a059f24e58be082c9be == 0)
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

			// Token: 0x17000204 RID: 516
			// (get) Token: 0x06000768 RID: 1896 RVA: 0x0001DDE8 File Offset: 0x0001BFE8
			// (set) Token: 0x06000769 RID: 1897 RVA: 0x0001DE00 File Offset: 0x0001C000
			public bool EnumType
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_20_0.NativeStructWrapper.lfsY23DQk0fjrGowgbD(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eec4384c7d0d42baa74a4dbdbdbdd8df == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000205 RID: 517
			// (get) Token: 0x0600076A RID: 1898 RVA: 0x0001DE64 File Offset: 0x0001C064
			// (set) Token: 0x0600076B RID: 1899 RVA: 0x0001DE7C File Offset: 0x0001C07C
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_20_0.NativeStructWrapper.cpdT2uDjIIisIfDsmns(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_20_0.NativeStructWrapper.lfsY23DQk0fjrGowgbD(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8b1b71d923f0486b89239dd4a11f6d34 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000206 RID: 518
			// (get) Token: 0x0600076C RID: 1900 RVA: 0x0001DEE0 File Offset: 0x0001C0E0
			// (set) Token: 0x0600076D RID: 1901 RVA: 0x0001DEF8 File Offset: 0x0001C0F8
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_20_0.NativeStructWrapper.cpdT2uDjIIisIfDsmns(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 6);
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
							NativeClassStructHandler_20_0.NativeStructWrapper.lfsY23DQk0fjrGowgbD(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b1a14f54e3674a8baf7d5ab6ab85764a == 0)
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

			// Token: 0x17000207 RID: 519
			// (get) Token: 0x0600076E RID: 1902 RVA: 0x0001DF5C File Offset: 0x0001C15C
			// (set) Token: 0x0600076F RID: 1903 RVA: 0x0001DF74 File Offset: 0x0001C174
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_20_0.NativeStructWrapper.cpdT2uDjIIisIfDsmns(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_20_0.NativeStructWrapper.lfsY23DQk0fjrGowgbD(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_315c1a09bac64a059f24e58be082c9be != 0)
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

			// Token: 0x17000208 RID: 520
			// (get) Token: 0x06000770 RID: 1904 RVA: 0x0001DFD8 File Offset: 0x0001C1D8
			// (set) Token: 0x06000771 RID: 1905 RVA: 0x0001DFE4 File Offset: 0x0001C1E4
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

			// Token: 0x17000209 RID: 521
			// (get) Token: 0x06000772 RID: 1906 RVA: 0x0001DFF0 File Offset: 0x0001C1F0
			// (set) Token: 0x06000773 RID: 1907 RVA: 0x0001DFFC File Offset: 0x0001C1FC
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

			// Token: 0x06000774 RID: 1908 RVA: 0x0001E008 File Offset: 0x0001C208
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 1;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							NativeClassStructHandler_20_0.NativeStructWrapper.TjZ1HNDKonHuPqagKnc();
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b169d8ea412f45e99e430384ddc8908b == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							return;
						case 3:
						{
							IntPtr intPtr;
							NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
							num2 = 2;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e19113368d2b45ba8f9d5ebaa49ce5d2 != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						case 4:
							goto IL_5F;
						case 5:
						{
							IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_20_0.Il2CppClass_20_0>(hIDAYxH6DWLHIthQgC.gSCeTtiku(2064853062 ^ 1592199946 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b169d8ea412f45e99e430384ddc8908b));
							num2 = 3;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_fe27a6a8bfb848d1a3dd32bc5b1790e7 == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						}
						NativeClassStructHandler_20_0.NativeStructWrapper.lr7kWYDah5YixvRkUgO();
						num2 = 4;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_dd9c757bd882429784d62f0e80f112e6 == 0)
						{
							num2 = 0;
						}
					}
					IL_5F:
					NativeClassStructHandler_20_0.NativeStructWrapper.x4jbZ3DU4TcIodxcy70();
					num = 5;
				}
			}

			// Token: 0x06000775 RID: 1909 RVA: 0x0001E11C File Offset: 0x0001C31C
			internal static void x4jbZ3DU4TcIodxcy70()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000776 RID: 1910 RVA: 0x0001E12C File Offset: 0x0001C32C
			internal static bool i3VLVXDg6iC9uenCWbJ()
			{
				return NativeClassStructHandler_20_0.NativeStructWrapper.cCQRjKDThOi0yw5tAKE == null;
			}

			// Token: 0x06000777 RID: 1911 RVA: 0x0001E140 File Offset: 0x0001C340
			internal static NativeClassStructHandler_20_0.NativeStructWrapper lThLMRDohmJUx52NUqw()
			{
				return NativeClassStructHandler_20_0.NativeStructWrapper.cCQRjKDThOi0yw5tAKE;
			}

			// Token: 0x06000778 RID: 1912 RVA: 0x0001E150 File Offset: 0x0001C350
			internal static bool cpdT2uDjIIisIfDsmns(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000779 RID: 1913 RVA: 0x0001E16C File Offset: 0x0001C36C
			internal static void lfsY23DQk0fjrGowgbD(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x0600077A RID: 1914 RVA: 0x0001E18C File Offset: 0x0001C38C
			internal static IntPtr endT7sDeoejdPQcChF6(IntPtr A_0, int A_1, object A_2)
			{
				return apS1BFcfBa3gXUspL9j.muOq5LWqgj(A_0, A_1, A_2);
			}

			// Token: 0x0600077B RID: 1915 RVA: 0x0001E1A8 File Offset: 0x0001C3A8
			internal static void TjZ1HNDKonHuPqagKnc()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0600077C RID: 1916 RVA: 0x0001E1B8 File Offset: 0x0001C3B8
			internal static void lr7kWYDah5YixvRkUgO()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x040003D6 RID: 982
			private static readonly int _bitfield0offset;

			// Token: 0x040003D7 RID: 983
			private unsafe Il2CppClass* _klassDummy;

			// Token: 0x040003D9 RID: 985
			private static object cCQRjKDThOi0yw5tAKE;
		}
	}
}
