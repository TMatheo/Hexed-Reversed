using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000C9 RID: 201
	[ApplicableToUnityVersionsSince("5.3.6")]
	public class NativeClassStructHandler_21_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x0600079A RID: 1946 RVA: 0x00011530 File Offset: 0x0000F730
		public int Size()
		{
			return sizeof(NativeClassStructHandler_21_0.Il2CppClass_21_0);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00011540 File Offset: 0x0000F740
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
					IntPtr buffer = ptr = MarshalExtend.AllocHGlobal(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
					*ptr = default(NativeClassStructHandler_21_0.Il2CppClass_21_0);
					MarshalExtend.FreeHGlobal(buffer);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_468d644ed32a4ba3ad77ef2c95e2ad4b != 0)
					{
						num2 = 0;
					}
					break;
				}
				}
			}
			IL_2B:
			throw new NotSupportedException(NativeClassStructHandler_21_0.iwdC02c3tKNMvvxRU8F(--1380778555 ^ 1563794177 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40));
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x000115DC File Offset: 0x0000F7DC
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3ffead0113044f06b294bee6bd5e7a44 == 0)
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

		// Token: 0x0600079D RID: 1949 RVA: 0x00011644 File Offset: 0x0000F844
		public NativeClassStructHandler_21_0()
		{
			NativeClassStructHandler_21_0.S9X4CTc1oZW6KaA90MO();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c1d51581d05f41579ee6e476d9be288e == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x000116A8 File Offset: 0x0000F8A8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_21_0()
		{
			NativeClassStructHandler_21_0.OixVt8cMVQ84BklAhVX();
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000116B8 File Offset: 0x0000F8B8
		internal static object iwdC02c3tKNMvvxRU8F(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000116CC File Offset: 0x0000F8CC
		internal static bool UeLt8ac5shv5pX0gI21()
		{
			return NativeClassStructHandler_21_0.WMYMq0cKkDpnntMXQdb == null;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000116E0 File Offset: 0x0000F8E0
		internal static NativeClassStructHandler_21_0 CMRemAcnTCY6Splr1oK()
		{
			return NativeClassStructHandler_21_0.WMYMq0cKkDpnntMXQdb;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x000116F0 File Offset: 0x0000F8F0
		internal static void S9X4CTc1oZW6KaA90MO()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00011700 File Offset: 0x0000F900
		internal static void OixVt8cMVQ84BklAhVX()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040003E5 RID: 997
		private static NativeClassStructHandler_21_0 WMYMq0cKkDpnntMXQdb;

		// Token: 0x020000CA RID: 202
		internal struct Il2CppClass_21_0
		{
			// Token: 0x040003E6 RID: 998
			public unsafe Il2CppImage* image;

			// Token: 0x040003E7 RID: 999
			public unsafe void* gc_desc;

			// Token: 0x040003E8 RID: 1000
			public unsafe byte* name;

			// Token: 0x040003E9 RID: 1001
			public unsafe byte* namespaze;

			// Token: 0x040003EA RID: 1002
			public unsafe Il2CppTypeStruct* byval_arg;

			// Token: 0x040003EB RID: 1003
			public unsafe Il2CppTypeStruct* this_arg;

			// Token: 0x040003EC RID: 1004
			public unsafe Il2CppClass* element_class;

			// Token: 0x040003ED RID: 1005
			public unsafe Il2CppClass* castClass;

			// Token: 0x040003EE RID: 1006
			public unsafe Il2CppClass* declaringType;

			// Token: 0x040003EF RID: 1007
			public unsafe Il2CppClass* parent;

			// Token: 0x040003F0 RID: 1008
			public unsafe void* generic_class;

			// Token: 0x040003F1 RID: 1009
			public unsafe void* typeDefinition;

			// Token: 0x040003F2 RID: 1010
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x040003F3 RID: 1011
			public unsafe Il2CppEventInfo* events;

			// Token: 0x040003F4 RID: 1012
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x040003F5 RID: 1013
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x040003F6 RID: 1014
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x040003F7 RID: 1015
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x040003F8 RID: 1016
			public unsafe VirtualInvokeData* vtable;

			// Token: 0x040003F9 RID: 1017
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x040003FA RID: 1018
			public unsafe void* static_fields;

			// Token: 0x040003FB RID: 1019
			public unsafe void* rgctx_data;

			// Token: 0x040003FC RID: 1020
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x040003FD RID: 1021
			public uint cctor_started;

			// Token: 0x040003FE RID: 1022
			public uint cctor_finished;

			// Token: 0x040003FF RID: 1023
			public ulong cctor_thread;

			// Token: 0x04000400 RID: 1024
			public int genericContainerIndex;

			// Token: 0x04000401 RID: 1025
			public int customAttributeIndex;

			// Token: 0x04000402 RID: 1026
			public uint instance_size;

			// Token: 0x04000403 RID: 1027
			public uint actualSize;

			// Token: 0x04000404 RID: 1028
			public uint element_size;

			// Token: 0x04000405 RID: 1029
			public int native_size;

			// Token: 0x04000406 RID: 1030
			public uint static_fields_size;

			// Token: 0x04000407 RID: 1031
			public uint thread_static_fields_size;

			// Token: 0x04000408 RID: 1032
			public int thread_static_fields_offset;

			// Token: 0x04000409 RID: 1033
			public uint flags;

			// Token: 0x0400040A RID: 1034
			public uint token;

			// Token: 0x0400040B RID: 1035
			public ushort method_count;

			// Token: 0x0400040C RID: 1036
			public ushort property_count;

			// Token: 0x0400040D RID: 1037
			public ushort field_count;

			// Token: 0x0400040E RID: 1038
			public ushort event_count;

			// Token: 0x0400040F RID: 1039
			public ushort nested_type_count;

			// Token: 0x04000410 RID: 1040
			public ushort vtable_count;

			// Token: 0x04000411 RID: 1041
			public ushort interfaces_count;

			// Token: 0x04000412 RID: 1042
			public ushort interface_offsets_count;

			// Token: 0x04000413 RID: 1043
			public byte typeHierarchyDepth;

			// Token: 0x04000414 RID: 1044
			public byte rank;

			// Token: 0x04000415 RID: 1045
			public byte minimumAlignment;

			// Token: 0x04000416 RID: 1046
			public byte packingSize;

			// Token: 0x04000417 RID: 1047
			public NativeClassStructHandler_21_0.Il2CppClass_21_0.Bitfield0 _bitfield0;

			// Token: 0x020000CB RID: 203
			internal enum Bitfield0 : ushort
			{
				// Token: 0x04000419 RID: 1049
				BIT_valuetype,
				// Token: 0x0400041A RID: 1050
				valuetype,
				// Token: 0x0400041B RID: 1051
				BIT_initialized = 1,
				// Token: 0x0400041C RID: 1052
				initialized,
				// Token: 0x0400041D RID: 1053
				BIT_enumtype = 2,
				// Token: 0x0400041E RID: 1054
				enumtype = 4,
				// Token: 0x0400041F RID: 1055
				BIT_is_generic = 3,
				// Token: 0x04000420 RID: 1056
				is_generic = 8,
				// Token: 0x04000421 RID: 1057
				BIT_has_references = 4,
				// Token: 0x04000422 RID: 1058
				has_references = 16,
				// Token: 0x04000423 RID: 1059
				BIT_init_pending = 5,
				// Token: 0x04000424 RID: 1060
				init_pending = 32,
				// Token: 0x04000425 RID: 1061
				BIT_size_inited = 6,
				// Token: 0x04000426 RID: 1062
				size_inited = 64,
				// Token: 0x04000427 RID: 1063
				BIT_has_finalize = 7,
				// Token: 0x04000428 RID: 1064
				has_finalize = 128,
				// Token: 0x04000429 RID: 1065
				BIT_has_cctor = 8,
				// Token: 0x0400042A RID: 1066
				has_cctor = 256,
				// Token: 0x0400042B RID: 1067
				BIT_is_blittable = 9,
				// Token: 0x0400042C RID: 1068
				is_blittable = 512,
				// Token: 0x0400042D RID: 1069
				BIT_is_import_or_windows_runtime = 10,
				// Token: 0x0400042E RID: 1070
				is_import_or_windows_runtime = 1024
			}
		}

		// Token: 0x020000CC RID: 204
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x060007A4 RID: 1956 RVA: 0x0001EDE8 File Offset: 0x0001CFE8
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_21_0.NativeStructWrapper.Pe1yoXoomTqIdmTKarP();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8447c7a721f541de9426c754e1b08372 == 0)
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
					num = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc == 0)
					{
						num = 1;
					}
				}
			}

			// Token: 0x1700020A RID: 522
			// (get) Token: 0x060007A5 RID: 1957 RVA: 0x0001EE78 File Offset: 0x0001D078
			private unsafe NativeClassStructHandler_21_0.Il2CppClass_21_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700020B RID: 523
			// (get) Token: 0x060007A6 RID: 1958 RVA: 0x0001EE88 File Offset: 0x0001D088
			// (set) Token: 0x060007A7 RID: 1959 RVA: 0x0001EEA0 File Offset: 0x0001D0A0
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_21_0.NativeStructWrapper.CHXvK6obmxaW83SaxVo(this, NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 4);
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
							this.SetBit(NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a8737fecb12449d7ad23f5080d76d2f8 == 0)
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

			// Token: 0x1700020C RID: 524
			// (get) Token: 0x060007A8 RID: 1960 RVA: 0x0001EF04 File Offset: 0x0001D104
			public IntPtr Pointer { get; }

			// Token: 0x1700020D RID: 525
			// (get) Token: 0x060007A9 RID: 1961 RVA: 0x0001EF14 File Offset: 0x0001D114
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_21_0.NativeStructWrapper.MwhNhZofj2hhnOJo8tL(this.Pointer, sizeof(NativeClassStructHandler_21_0.Il2CppClass_21_0), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x1700020E RID: 526
			// (get) Token: 0x060007AA RID: 1962 RVA: 0x0001EF34 File Offset: 0x0001D134
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700020F RID: 527
			// (get) Token: 0x060007AB RID: 1963 RVA: 0x0001EF44 File Offset: 0x0001D144
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->byval_arg);
				}
			}

			// Token: 0x17000210 RID: 528
			// (get) Token: 0x060007AC RID: 1964 RVA: 0x0001EF60 File Offset: 0x0001D160
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->this_arg);
				}
			}

			// Token: 0x17000211 RID: 529
			// (get) Token: 0x060007AD RID: 1965 RVA: 0x0001EF7C File Offset: 0x0001D17C
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x17000212 RID: 530
			// (get) Token: 0x060007AE RID: 1966 RVA: 0x0001EF90 File Offset: 0x0001D190
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x17000213 RID: 531
			// (get) Token: 0x060007AF RID: 1967 RVA: 0x0001EFA4 File Offset: 0x0001D1A4
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x17000214 RID: 532
			// (get) Token: 0x060007B0 RID: 1968 RVA: 0x0001EFB8 File Offset: 0x0001D1B8
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x17000215 RID: 533
			// (get) Token: 0x060007B1 RID: 1969 RVA: 0x0001EFCC File Offset: 0x0001D1CC
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x17000216 RID: 534
			// (get) Token: 0x060007B2 RID: 1970 RVA: 0x0001EFE0 File Offset: 0x0001D1E0
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x17000217 RID: 535
			// (get) Token: 0x060007B3 RID: 1971 RVA: 0x0001EFF4 File Offset: 0x0001D1F4
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x17000218 RID: 536
			// (get) Token: 0x060007B4 RID: 1972 RVA: 0x0001F008 File Offset: 0x0001D208
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x17000219 RID: 537
			// (get) Token: 0x060007B5 RID: 1973 RVA: 0x0001F01C File Offset: 0x0001D21C
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x1700021A RID: 538
			// (get) Token: 0x060007B6 RID: 1974 RVA: 0x0001F030 File Offset: 0x0001D230
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x1700021B RID: 539
			// (get) Token: 0x060007B7 RID: 1975 RVA: 0x0001F048 File Offset: 0x0001D248
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700021C RID: 540
			// (get) Token: 0x060007B8 RID: 1976 RVA: 0x0001F060 File Offset: 0x0001D260
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x1700021D RID: 541
			// (get) Token: 0x060007B9 RID: 1977 RVA: 0x0001F078 File Offset: 0x0001D278
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x1700021E RID: 542
			// (get) Token: 0x060007BA RID: 1978 RVA: 0x0001F08C File Offset: 0x0001D28C
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700021F RID: 543
			// (get) Token: 0x060007BB RID: 1979 RVA: 0x0001F0A0 File Offset: 0x0001D2A0
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x17000220 RID: 544
			// (get) Token: 0x060007BC RID: 1980 RVA: 0x0001F0B4 File Offset: 0x0001D2B4
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x17000221 RID: 545
			// (get) Token: 0x060007BD RID: 1981 RVA: 0x0001F0C8 File Offset: 0x0001D2C8
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x17000222 RID: 546
			// (get) Token: 0x060007BE RID: 1982 RVA: 0x0001F0DC File Offset: 0x0001D2DC
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._klassDummy;
				}
			}

			// Token: 0x17000223 RID: 547
			// (get) Token: 0x060007BF RID: 1983 RVA: 0x0001F0EC File Offset: 0x0001D2EC
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x17000224 RID: 548
			// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0001F100 File Offset: 0x0001D300
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x17000225 RID: 549
			// (get) Token: 0x060007C1 RID: 1985 RVA: 0x0001F114 File Offset: 0x0001D314
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x17000226 RID: 550
			// (get) Token: 0x060007C2 RID: 1986 RVA: 0x0001F128 File Offset: 0x0001D328
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x17000227 RID: 551
			// (get) Token: 0x060007C3 RID: 1987 RVA: 0x0001F13C File Offset: 0x0001D33C
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x17000228 RID: 552
			// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0001F150 File Offset: 0x0001D350
			// (set) Token: 0x060007C5 RID: 1989 RVA: 0x0001F168 File Offset: 0x0001D368
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_21_0.NativeStructWrapper.CHXvK6obmxaW83SaxVo(this, NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_21_0.NativeStructWrapper.vxwPF9oPGhh36ue4ZIx(this, NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 0, value);
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

			// Token: 0x17000229 RID: 553
			// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0001F1CC File Offset: 0x0001D3CC
			// (set) Token: 0x060007C7 RID: 1991 RVA: 0x0001F1E4 File Offset: 0x0001D3E4
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_21_0.NativeStructWrapper.CHXvK6obmxaW83SaxVo(this, NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 1);
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
							this.SetBit(NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700022A RID: 554
			// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0001F248 File Offset: 0x0001D448
			// (set) Token: 0x060007C9 RID: 1993 RVA: 0x0001F260 File Offset: 0x0001D460
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_21_0.NativeStructWrapper.CHXvK6obmxaW83SaxVo(this, NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_21_0.NativeStructWrapper.vxwPF9oPGhh36ue4ZIx(this, NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_db312e48eee84539b805fee2f73a8cde != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700022B RID: 555
			// (get) Token: 0x060007CA RID: 1994 RVA: 0x0001F2C4 File Offset: 0x0001D4C4
			// (set) Token: 0x060007CB RID: 1995 RVA: 0x0001F2DC File Offset: 0x0001D4DC
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_21_0.NativeStructWrapper.CHXvK6obmxaW83SaxVo(this, NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 3);
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
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a36e967c0f044e9ebf523536bdec8e28 == 0)
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
			// (get) Token: 0x060007CC RID: 1996 RVA: 0x0001F340 File Offset: 0x0001D540
			// (set) Token: 0x060007CD RID: 1997 RVA: 0x0001F358 File Offset: 0x0001D558
			public bool SizeInited
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 6);
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
							NativeClassStructHandler_21_0.NativeStructWrapper.vxwPF9oPGhh36ue4ZIx(this, NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f72daac7e98440569eaab57fbb9f7bf2 != 0)
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
			// (get) Token: 0x060007CE RID: 1998 RVA: 0x0001F3BC File Offset: 0x0001D5BC
			// (set) Token: 0x060007CF RID: 1999 RVA: 0x0001F3D4 File Offset: 0x0001D5D4
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_21_0.NativeStructWrapper.CHXvK6obmxaW83SaxVo(this, NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_21_0.NativeStructWrapper.vxwPF9oPGhh36ue4ZIx(this, NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6104a350572547c0a789887568cca07c == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700022E RID: 558
			// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0001F438 File Offset: 0x0001D638
			// (set) Token: 0x060007D1 RID: 2001 RVA: 0x0001F444 File Offset: 0x0001D644
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
			// (get) Token: 0x060007D2 RID: 2002 RVA: 0x0001F450 File Offset: 0x0001D650
			// (set) Token: 0x060007D3 RID: 2003 RVA: 0x0001F45C File Offset: 0x0001D65C
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

			// Token: 0x060007D4 RID: 2004 RVA: 0x0001F468 File Offset: 0x0001D668
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
						IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_21_0.Il2CppClass_21_0>(NativeClassStructHandler_21_0.NativeStructWrapper.j40trDoeX02cucmWKwi(~674864128 ^ -616219528 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c504ab11ece64b14b01df2d4c88e6e49));
						num2 = 5;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					case 2:
						return;
					case 3:
						hIDAYxH6DWLHIthQgC.oDuBOTgYK();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2210d7ca22c24335b32d80ca3ef84b8e != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						NativeClassStructHandler_21_0.NativeStructWrapper.w7KC4XodCYB0WmfVBjx();
						num2 = 3;
						continue;
					case 5:
					{
						IntPtr intPtr;
						NativeClassStructHandler_21_0.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 2;
						continue;
					}
					}
					NativeClassStructHandler_21_0.NativeStructWrapper.CiBS9uownkii9sh44Cl();
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d01f42186cf2421f90d71301ed147eb1 != 0)
					{
						num2 = 1;
					}
				}
			}

			// Token: 0x060007D5 RID: 2005 RVA: 0x0001F564 File Offset: 0x0001D764
			internal static void Pe1yoXoomTqIdmTKarP()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060007D6 RID: 2006 RVA: 0x0001F574 File Offset: 0x0001D774
			internal static bool U9QEZIoDoskAda12QvO()
			{
				return NativeClassStructHandler_21_0.NativeStructWrapper.qscAJ1orCuiIL7jcyJk == null;
			}

			// Token: 0x060007D7 RID: 2007 RVA: 0x0001F588 File Offset: 0x0001D788
			internal static NativeClassStructHandler_21_0.NativeStructWrapper mWZ18VoZcO1XRrWCLCU()
			{
				return NativeClassStructHandler_21_0.NativeStructWrapper.qscAJ1orCuiIL7jcyJk;
			}

			// Token: 0x060007D8 RID: 2008 RVA: 0x0001F598 File Offset: 0x0001D798
			internal static bool CHXvK6obmxaW83SaxVo(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x060007D9 RID: 2009 RVA: 0x0001F5B4 File Offset: 0x0001D7B4
			internal static IntPtr MwhNhZofj2hhnOJo8tL(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x060007DA RID: 2010 RVA: 0x0001F5D0 File Offset: 0x0001D7D0
			internal static void vxwPF9oPGhh36ue4ZIx(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x060007DB RID: 2011 RVA: 0x0001F5F0 File Offset: 0x0001D7F0
			internal static void w7KC4XodCYB0WmfVBjx()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x060007DC RID: 2012 RVA: 0x0001F600 File Offset: 0x0001D800
			internal static void CiBS9uownkii9sh44Cl()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x060007DD RID: 2013 RVA: 0x0001F610 File Offset: 0x0001D810
			internal static object j40trDoeX02cucmWKwi(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x0400042F RID: 1071
			private static readonly int _bitfield0offset;

			// Token: 0x04000430 RID: 1072
			private unsafe Il2CppClass* _klassDummy;

			// Token: 0x04000432 RID: 1074
			private static object qscAJ1orCuiIL7jcyJk;
		}
	}
}
