using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000C7 RID: 199
	[ApplicableToUnityVersionsSince("5.3.6")]
	public class NativeClassStructHandler_21_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x0600077D RID: 1917 RVA: 0x00010904 File Offset: 0x0000EB04
		public int Size()
		{
			return sizeof(NativeClassStructHandler_21_0.Il2CppClass_21_0);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00010914 File Offset: 0x0000EB14
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
					NativeClassStructHandler_21_0.Il2CppClass_21_0* ptr;
					IntPtr buffer = ptr = NativeClassStructHandler_21_0.rnoeFX6fre6X8ASUUuP(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
					*ptr = default(NativeClassStructHandler_21_0.Il2CppClass_21_0);
					MarshalExtend.FreeHGlobal(buffer);
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2adb3ca441e493aba80425bcc0f1db3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				}
			}
			IL_2B:
			throw new NotSupportedException(NativeClassStructHandler_21_0.kTlGYm61o8L0UP4T9HE(684946568 ^ -1100635574 ^ -417498045 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_23fed2b647424ffc818af5297e87fd1e));
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000109B8 File Offset: 0x0000EBB8
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f6eb9387956a4e8c81dafbb2ecc8c7ab == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeClassStructHandler_21_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00010A20 File Offset: 0x0000EC20
		public NativeClassStructHandler_21_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeClassStructHandler_21_0.Gnkcmf6F6KVdEbbx4Kc();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0272cc4de9694915be17746e515675c8 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00010A84 File Offset: 0x0000EC84
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_21_0()
		{
			NativeClassStructHandler_21_0.FOd84K6RVIXp38fwqSs();
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00010A94 File Offset: 0x0000EC94
		internal static IntPtr rnoeFX6fre6X8ASUUuP(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00010AA8 File Offset: 0x0000ECA8
		internal static object kTlGYm61o8L0UP4T9HE(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00010ABC File Offset: 0x0000ECBC
		internal static bool WnQLaN64e15GdWrwYuG()
		{
			return NativeClassStructHandler_21_0.o7FRfq6P5ZpQ7ohk7d2 == null;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		internal static NativeClassStructHandler_21_0 qpqbNY63wMwhHRpyiET()
		{
			return NativeClassStructHandler_21_0.o7FRfq6P5ZpQ7ohk7d2;
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00010AE0 File Offset: 0x0000ECE0
		internal static void Gnkcmf6F6KVdEbbx4Kc()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00010AF0 File Offset: 0x0000ECF0
		internal static void FOd84K6RVIXp38fwqSs()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040003DA RID: 986
		private static NativeClassStructHandler_21_0 o7FRfq6P5ZpQ7ohk7d2;

		// Token: 0x020000C8 RID: 200
		internal struct Il2CppClass_21_0
		{
			// Token: 0x040003DB RID: 987
			public unsafe Il2CppImage* image;

			// Token: 0x040003DC RID: 988
			public unsafe void* gc_desc;

			// Token: 0x040003DD RID: 989
			public unsafe byte* name;

			// Token: 0x040003DE RID: 990
			public unsafe byte* namespaze;

			// Token: 0x040003DF RID: 991
			public unsafe Il2CppTypeStruct* byval_arg;

			// Token: 0x040003E0 RID: 992
			public unsafe Il2CppTypeStruct* this_arg;

			// Token: 0x040003E1 RID: 993
			public unsafe Il2CppClass* element_class;

			// Token: 0x040003E2 RID: 994
			public unsafe Il2CppClass* castClass;

			// Token: 0x040003E3 RID: 995
			public unsafe Il2CppClass* declaringType;

			// Token: 0x040003E4 RID: 996
			public unsafe Il2CppClass* parent;

			// Token: 0x040003E5 RID: 997
			public unsafe void* generic_class;

			// Token: 0x040003E6 RID: 998
			public unsafe void* typeDefinition;

			// Token: 0x040003E7 RID: 999
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x040003E8 RID: 1000
			public unsafe Il2CppEventInfo* events;

			// Token: 0x040003E9 RID: 1001
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x040003EA RID: 1002
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x040003EB RID: 1003
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x040003EC RID: 1004
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x040003ED RID: 1005
			public unsafe VirtualInvokeData* vtable;

			// Token: 0x040003EE RID: 1006
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x040003EF RID: 1007
			public unsafe void* static_fields;

			// Token: 0x040003F0 RID: 1008
			public unsafe void* rgctx_data;

			// Token: 0x040003F1 RID: 1009
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x040003F2 RID: 1010
			public uint cctor_started;

			// Token: 0x040003F3 RID: 1011
			public uint cctor_finished;

			// Token: 0x040003F4 RID: 1012
			public ulong cctor_thread;

			// Token: 0x040003F5 RID: 1013
			public int genericContainerIndex;

			// Token: 0x040003F6 RID: 1014
			public int customAttributeIndex;

			// Token: 0x040003F7 RID: 1015
			public uint instance_size;

			// Token: 0x040003F8 RID: 1016
			public uint actualSize;

			// Token: 0x040003F9 RID: 1017
			public uint element_size;

			// Token: 0x040003FA RID: 1018
			public int native_size;

			// Token: 0x040003FB RID: 1019
			public uint static_fields_size;

			// Token: 0x040003FC RID: 1020
			public uint thread_static_fields_size;

			// Token: 0x040003FD RID: 1021
			public int thread_static_fields_offset;

			// Token: 0x040003FE RID: 1022
			public uint flags;

			// Token: 0x040003FF RID: 1023
			public uint token;

			// Token: 0x04000400 RID: 1024
			public ushort method_count;

			// Token: 0x04000401 RID: 1025
			public ushort property_count;

			// Token: 0x04000402 RID: 1026
			public ushort field_count;

			// Token: 0x04000403 RID: 1027
			public ushort event_count;

			// Token: 0x04000404 RID: 1028
			public ushort nested_type_count;

			// Token: 0x04000405 RID: 1029
			public ushort vtable_count;

			// Token: 0x04000406 RID: 1030
			public ushort interfaces_count;

			// Token: 0x04000407 RID: 1031
			public ushort interface_offsets_count;

			// Token: 0x04000408 RID: 1032
			public byte typeHierarchyDepth;

			// Token: 0x04000409 RID: 1033
			public byte rank;

			// Token: 0x0400040A RID: 1034
			public byte minimumAlignment;

			// Token: 0x0400040B RID: 1035
			public byte packingSize;

			// Token: 0x0400040C RID: 1036
			public NativeClassStructHandler_21_0.Il2CppClass_21_0.Bitfield0 _bitfield0;

			// Token: 0x020000C9 RID: 201
			internal enum Bitfield0 : ushort
			{
				// Token: 0x0400040E RID: 1038
				BIT_valuetype,
				// Token: 0x0400040F RID: 1039
				valuetype,
				// Token: 0x04000410 RID: 1040
				BIT_initialized = 1,
				// Token: 0x04000411 RID: 1041
				initialized,
				// Token: 0x04000412 RID: 1042
				BIT_enumtype = 2,
				// Token: 0x04000413 RID: 1043
				enumtype = 4,
				// Token: 0x04000414 RID: 1044
				BIT_is_generic = 3,
				// Token: 0x04000415 RID: 1045
				is_generic = 8,
				// Token: 0x04000416 RID: 1046
				BIT_has_references = 4,
				// Token: 0x04000417 RID: 1047
				has_references = 16,
				// Token: 0x04000418 RID: 1048
				BIT_init_pending = 5,
				// Token: 0x04000419 RID: 1049
				init_pending = 32,
				// Token: 0x0400041A RID: 1050
				BIT_size_inited = 6,
				// Token: 0x0400041B RID: 1051
				size_inited = 64,
				// Token: 0x0400041C RID: 1052
				BIT_has_finalize = 7,
				// Token: 0x0400041D RID: 1053
				has_finalize = 128,
				// Token: 0x0400041E RID: 1054
				BIT_has_cctor = 8,
				// Token: 0x0400041F RID: 1055
				has_cctor = 256,
				// Token: 0x04000420 RID: 1056
				BIT_is_blittable = 9,
				// Token: 0x04000421 RID: 1057
				is_blittable = 512,
				// Token: 0x04000422 RID: 1058
				BIT_is_import_or_windows_runtime = 10,
				// Token: 0x04000423 RID: 1059
				is_import_or_windows_runtime = 1024
			}
		}

		// Token: 0x020000CA RID: 202
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000788 RID: 1928 RVA: 0x0001E1C8 File Offset: 0x0001C3C8
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_21_0.NativeStructWrapper.SKi2RbmLAMG6EkVv2Or();
				NativeClassStructHandler_21_0.NativeStructWrapper.FmqfuUmX8MHUoD2MZAP();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3bc41e98a8e849aea1e93dfe0f04c43b != 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						return;
					}
					this.<Pointer>k__BackingField = ptr;
					num = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5 != 0)
					{
						num = 1;
					}
				}
			}

			// Token: 0x1700020A RID: 522
			// (get) Token: 0x06000789 RID: 1929 RVA: 0x0001E258 File Offset: 0x0001C458
			private unsafe NativeClassStructHandler_21_0.Il2CppClass_21_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700020B RID: 523
			// (get) Token: 0x0600078A RID: 1930 RVA: 0x0001E268 File Offset: 0x0001C468
			// (set) Token: 0x0600078B RID: 1931 RVA: 0x0001E280 File Offset: 0x0001C480
			public bool HasReferences
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 4);
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
							this.SetBit(NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2a3cb7fb82fa47c39f707a2393c1a340 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700020C RID: 524
			// (get) Token: 0x0600078C RID: 1932 RVA: 0x0001E2E4 File Offset: 0x0001C4E4
			public IntPtr Pointer { get; }

			// Token: 0x1700020D RID: 525
			// (get) Token: 0x0600078D RID: 1933 RVA: 0x0001E2F4 File Offset: 0x0001C4F4
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_21_0.NativeStructWrapper.Xf9UEYmcfYyj1BuAebt(this.Pointer, sizeof(NativeClassStructHandler_21_0.Il2CppClass_21_0), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x1700020E RID: 526
			// (get) Token: 0x0600078E RID: 1934 RVA: 0x0001E314 File Offset: 0x0001C514
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700020F RID: 527
			// (get) Token: 0x0600078F RID: 1935 RVA: 0x0001E324 File Offset: 0x0001C524
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->byval_arg);
				}
			}

			// Token: 0x17000210 RID: 528
			// (get) Token: 0x06000790 RID: 1936 RVA: 0x0001E340 File Offset: 0x0001C540
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->this_arg);
				}
			}

			// Token: 0x17000211 RID: 529
			// (get) Token: 0x06000791 RID: 1937 RVA: 0x0001E35C File Offset: 0x0001C55C
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x17000212 RID: 530
			// (get) Token: 0x06000792 RID: 1938 RVA: 0x0001E370 File Offset: 0x0001C570
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x17000213 RID: 531
			// (get) Token: 0x06000793 RID: 1939 RVA: 0x0001E384 File Offset: 0x0001C584
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x17000214 RID: 532
			// (get) Token: 0x06000794 RID: 1940 RVA: 0x0001E398 File Offset: 0x0001C598
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x17000215 RID: 533
			// (get) Token: 0x06000795 RID: 1941 RVA: 0x0001E3AC File Offset: 0x0001C5AC
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x17000216 RID: 534
			// (get) Token: 0x06000796 RID: 1942 RVA: 0x0001E3C0 File Offset: 0x0001C5C0
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x17000217 RID: 535
			// (get) Token: 0x06000797 RID: 1943 RVA: 0x0001E3D4 File Offset: 0x0001C5D4
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x17000218 RID: 536
			// (get) Token: 0x06000798 RID: 1944 RVA: 0x0001E3E8 File Offset: 0x0001C5E8
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x17000219 RID: 537
			// (get) Token: 0x06000799 RID: 1945 RVA: 0x0001E3FC File Offset: 0x0001C5FC
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x1700021A RID: 538
			// (get) Token: 0x0600079A RID: 1946 RVA: 0x0001E410 File Offset: 0x0001C610
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x1700021B RID: 539
			// (get) Token: 0x0600079B RID: 1947 RVA: 0x0001E428 File Offset: 0x0001C628
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700021C RID: 540
			// (get) Token: 0x0600079C RID: 1948 RVA: 0x0001E440 File Offset: 0x0001C640
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x1700021D RID: 541
			// (get) Token: 0x0600079D RID: 1949 RVA: 0x0001E458 File Offset: 0x0001C658
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x1700021E RID: 542
			// (get) Token: 0x0600079E RID: 1950 RVA: 0x0001E46C File Offset: 0x0001C66C
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700021F RID: 543
			// (get) Token: 0x0600079F RID: 1951 RVA: 0x0001E480 File Offset: 0x0001C680
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x17000220 RID: 544
			// (get) Token: 0x060007A0 RID: 1952 RVA: 0x0001E494 File Offset: 0x0001C694
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x17000221 RID: 545
			// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0001E4A8 File Offset: 0x0001C6A8
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x17000222 RID: 546
			// (get) Token: 0x060007A2 RID: 1954 RVA: 0x0001E4BC File Offset: 0x0001C6BC
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._klassDummy;
				}
			}

			// Token: 0x17000223 RID: 547
			// (get) Token: 0x060007A3 RID: 1955 RVA: 0x0001E4CC File Offset: 0x0001C6CC
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x17000224 RID: 548
			// (get) Token: 0x060007A4 RID: 1956 RVA: 0x0001E4E0 File Offset: 0x0001C6E0
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x17000225 RID: 549
			// (get) Token: 0x060007A5 RID: 1957 RVA: 0x0001E4F4 File Offset: 0x0001C6F4
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x17000226 RID: 550
			// (get) Token: 0x060007A6 RID: 1958 RVA: 0x0001E508 File Offset: 0x0001C708
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x17000227 RID: 551
			// (get) Token: 0x060007A7 RID: 1959 RVA: 0x0001E51C File Offset: 0x0001C71C
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x17000228 RID: 552
			// (get) Token: 0x060007A8 RID: 1960 RVA: 0x0001E530 File Offset: 0x0001C730
			// (set) Token: 0x060007A9 RID: 1961 RVA: 0x0001E548 File Offset: 0x0001C748
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_21_0.NativeStructWrapper.T9XIbJmkd9T36fpgyJy(this, NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 0);
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
							this.SetBit(NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5395ed2b7ead4e349835ba3f56e39138 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000229 RID: 553
			// (get) Token: 0x060007AA RID: 1962 RVA: 0x0001E5AC File Offset: 0x0001C7AC
			// (set) Token: 0x060007AB RID: 1963 RVA: 0x0001E5C4 File Offset: 0x0001C7C4
			public bool Initialized
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_21_0.NativeStructWrapper.mm9Qw5m23L3CgZ8QvfM(this, NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b9b6cd6cbc040a7be58cff054f9e843 == 0)
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

			// Token: 0x1700022A RID: 554
			// (get) Token: 0x060007AC RID: 1964 RVA: 0x0001E628 File Offset: 0x0001C828
			// (set) Token: 0x060007AD RID: 1965 RVA: 0x0001E640 File Offset: 0x0001C840
			public bool EnumType
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 2);
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
							this.SetBit(NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0272cc4de9694915be17746e515675c8 != 0)
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

			// Token: 0x1700022B RID: 555
			// (get) Token: 0x060007AE RID: 1966 RVA: 0x0001E6A4 File Offset: 0x0001C8A4
			// (set) Token: 0x060007AF RID: 1967 RVA: 0x0001E6BC File Offset: 0x0001C8BC
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_21_0.NativeStructWrapper.T9XIbJmkd9T36fpgyJy(this, NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 3);
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
							this.SetBit(NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_355d73c700924bf28058452e63cd9cf1 != 0)
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

			// Token: 0x1700022C RID: 556
			// (get) Token: 0x060007B0 RID: 1968 RVA: 0x0001E720 File Offset: 0x0001C920
			// (set) Token: 0x060007B1 RID: 1969 RVA: 0x0001E738 File Offset: 0x0001C938
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_21_0.NativeStructWrapper.T9XIbJmkd9T36fpgyJy(this, NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 6);
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
							this.SetBit(NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8160363759e64728b1ce193157380515 == 0)
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

			// Token: 0x1700022D RID: 557
			// (get) Token: 0x060007B2 RID: 1970 RVA: 0x0001E79C File Offset: 0x0001C99C
			// (set) Token: 0x060007B3 RID: 1971 RVA: 0x0001E7B4 File Offset: 0x0001C9B4
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_21_0.NativeStructWrapper.T9XIbJmkd9T36fpgyJy(this, NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_21_0.NativeStructWrapper.mm9Qw5m23L3CgZ8QvfM(this, NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_508916f527eb4b05b32762ef07dd9e52 != 0)
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

			// Token: 0x1700022E RID: 558
			// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0001E818 File Offset: 0x0001CA18
			// (set) Token: 0x060007B5 RID: 1973 RVA: 0x0001E824 File Offset: 0x0001CA24
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

			// Token: 0x1700022F RID: 559
			// (get) Token: 0x060007B6 RID: 1974 RVA: 0x0001E830 File Offset: 0x0001CA30
			// (set) Token: 0x060007B7 RID: 1975 RVA: 0x0001E83C File Offset: 0x0001CA3C
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

			// Token: 0x060007B8 RID: 1976 RVA: 0x0001E848 File Offset: 0x0001CA48
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 1;
				for (;;)
				{
					int num2 = num;
					IntPtr intPtr;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							hIDAYxH6DWLHIthQgC.zSLipEDdx();
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_124ad935e0834fda9ae7f452377dbe1c == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							intPtr = Marshal.OffsetOf<NativeClassStructHandler_21_0.Il2CppClass_21_0>(NativeClassStructHandler_21_0.NativeStructWrapper.Uux6iGmHq3NEpMihVE5(1154435597 ^ 2029081464 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b544c260d8647ebad150746ba137290));
							num2 = 2;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4da80845ebf7410ebbf942336f5ee27b != 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						case 3:
							goto IL_60;
						case 4:
							return;
						case 5:
							NativeClassStructHandler_21_0.NativeStructWrapper.FmqfuUmX8MHUoD2MZAP();
							num2 = 2;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8160363759e64728b1ce193157380515 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						NativeClassStructHandler_21_0.NativeStructWrapper.SKi2RbmLAMG6EkVv2Or();
						num2 = 5;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb34a81d7cc4fbea898664370a8645f == 0)
						{
							num2 = 4;
						}
					}
					IL_60:
					NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
					num = 4;
				}
			}

			// Token: 0x060007B9 RID: 1977 RVA: 0x0001E95C File Offset: 0x0001CB5C
			internal static void SKi2RbmLAMG6EkVv2Or()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060007BA RID: 1978 RVA: 0x0001E96C File Offset: 0x0001CB6C
			internal static void FmqfuUmX8MHUoD2MZAP()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x060007BB RID: 1979 RVA: 0x0001E97C File Offset: 0x0001CB7C
			internal static bool BqaVRum5wNwCWk7UNPx()
			{
				return NativeClassStructHandler_21_0.NativeStructWrapper.L3dkChmqFTG0GlxtBTr == null;
			}

			// Token: 0x060007BC RID: 1980 RVA: 0x0001E990 File Offset: 0x0001CB90
			internal static NativeClassStructHandler_21_0.NativeStructWrapper bdeUPqmA5V7AZoBPWqd()
			{
				return NativeClassStructHandler_21_0.NativeStructWrapper.L3dkChmqFTG0GlxtBTr;
			}

			// Token: 0x060007BD RID: 1981 RVA: 0x0001E9A0 File Offset: 0x0001CBA0
			internal static IntPtr Xf9UEYmcfYyj1BuAebt(IntPtr A_0, int A_1, object A_2)
			{
				return apS1BFcfBa3gXUspL9j.muOq5LWqgj(A_0, A_1, A_2);
			}

			// Token: 0x060007BE RID: 1982 RVA: 0x0001E9BC File Offset: 0x0001CBBC
			internal static bool T9XIbJmkd9T36fpgyJy(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060007BF RID: 1983 RVA: 0x0001E9D8 File Offset: 0x0001CBD8
			internal static void mm9Qw5m23L3CgZ8QvfM(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x060007C0 RID: 1984 RVA: 0x0001E9F8 File Offset: 0x0001CBF8
			internal static object Uux6iGmHq3NEpMihVE5(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000424 RID: 1060
			private static readonly int _bitfield0offset;

			// Token: 0x04000425 RID: 1061
			private unsafe Il2CppClass* _klassDummy;

			// Token: 0x04000427 RID: 1063
			internal static object L3dkChmqFTG0GlxtBTr;
		}
	}
}
