using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000CD RID: 205
	[ApplicableToUnityVersionsSince("5.4.4")]
	public class NativeClassStructHandler_21_1 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x060007DE RID: 2014 RVA: 0x00011710 File Offset: 0x0000F910
		public int Size()
		{
			return sizeof(NativeClassStructHandler_21_1.Il2CppClass_21_1);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00011720 File Offset: 0x0000F920
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
					NativeClassStructHandler_21_1.Il2CppClass_21_1* ptr;
					IntPtr buffer = ptr = NativeClassStructHandler_21_1.hUSBU56HqZ2OyVgnUuo(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
					*ptr = default(NativeClassStructHandler_21_1.Il2CppClass_21_1);
					NativeClassStructHandler_21_1.vjyodX6AtU99r7ET9KJ(buffer);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_74d61b1611df4615bd4df289712ea178 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				}
				break;
			}
			throw new NotSupportedException(NativeClassStructHandler_21_1.TcwDPc6UCQe4Tysac7i(534098265 ^ 1142082725 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fcdd30171ceb4eb7a5570cbbc4f6aec1));
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000117BC File Offset: 0x0000F9BC
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c474f43efb4d4f17b5c0c1bf3216ef4d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeClassStructHandler_21_1.NativeStructWrapper(ptr);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00011824 File Offset: 0x0000FA24
		public NativeClassStructHandler_21_1()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00011888 File Offset: 0x0000FA88
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_21_1()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00011898 File Offset: 0x0000FA98
		internal static IntPtr hUSBU56HqZ2OyVgnUuo(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x000118AC File Offset: 0x0000FAAC
		internal static void vjyodX6AtU99r7ET9KJ(IntPtr buffer)
		{
			MarshalExtend.FreeHGlobal(buffer);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x000118C0 File Offset: 0x0000FAC0
		internal static object TcwDPc6UCQe4Tysac7i(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000118D4 File Offset: 0x0000FAD4
		internal static bool W04estc4mCVoENBX5sW()
		{
			return NativeClassStructHandler_21_1.kNTnahcp4OXtMnbWdxv == null;
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000118E8 File Offset: 0x0000FAE8
		internal static NativeClassStructHandler_21_1 cmALtdczsduxweH5sx6()
		{
			return NativeClassStructHandler_21_1.kNTnahcp4OXtMnbWdxv;
		}

		// Token: 0x04000433 RID: 1075
		internal static NativeClassStructHandler_21_1 kNTnahcp4OXtMnbWdxv;

		// Token: 0x020000CE RID: 206
		internal struct Il2CppClass_21_1
		{
			// Token: 0x04000434 RID: 1076
			public unsafe Il2CppImage* image;

			// Token: 0x04000435 RID: 1077
			public unsafe void* gc_desc;

			// Token: 0x04000436 RID: 1078
			public unsafe byte* name;

			// Token: 0x04000437 RID: 1079
			public unsafe byte* namespaze;

			// Token: 0x04000438 RID: 1080
			public unsafe Il2CppTypeStruct* byval_arg;

			// Token: 0x04000439 RID: 1081
			public unsafe Il2CppTypeStruct* this_arg;

			// Token: 0x0400043A RID: 1082
			public unsafe Il2CppClass* element_class;

			// Token: 0x0400043B RID: 1083
			public unsafe Il2CppClass* castClass;

			// Token: 0x0400043C RID: 1084
			public unsafe Il2CppClass* declaringType;

			// Token: 0x0400043D RID: 1085
			public unsafe Il2CppClass* parent;

			// Token: 0x0400043E RID: 1086
			public unsafe void* generic_class;

			// Token: 0x0400043F RID: 1087
			public unsafe void* typeDefinition;

			// Token: 0x04000440 RID: 1088
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x04000441 RID: 1089
			public unsafe Il2CppEventInfo* events;

			// Token: 0x04000442 RID: 1090
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000443 RID: 1091
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x04000444 RID: 1092
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000445 RID: 1093
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x04000446 RID: 1094
			public unsafe VirtualInvokeData* vtable;

			// Token: 0x04000447 RID: 1095
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x04000448 RID: 1096
			public unsafe void* static_fields;

			// Token: 0x04000449 RID: 1097
			public unsafe void* rgctx_data;

			// Token: 0x0400044A RID: 1098
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x0400044B RID: 1099
			public uint cctor_started;

			// Token: 0x0400044C RID: 1100
			public uint cctor_finished;

			// Token: 0x0400044D RID: 1101
			public ulong cctor_thread;

			// Token: 0x0400044E RID: 1102
			public int genericContainerIndex;

			// Token: 0x0400044F RID: 1103
			public int customAttributeIndex;

			// Token: 0x04000450 RID: 1104
			public uint instance_size;

			// Token: 0x04000451 RID: 1105
			public uint actualSize;

			// Token: 0x04000452 RID: 1106
			public uint element_size;

			// Token: 0x04000453 RID: 1107
			public int native_size;

			// Token: 0x04000454 RID: 1108
			public uint static_fields_size;

			// Token: 0x04000455 RID: 1109
			public uint thread_static_fields_size;

			// Token: 0x04000456 RID: 1110
			public int thread_static_fields_offset;

			// Token: 0x04000457 RID: 1111
			public uint flags;

			// Token: 0x04000458 RID: 1112
			public uint token;

			// Token: 0x04000459 RID: 1113
			public ushort method_count;

			// Token: 0x0400045A RID: 1114
			public ushort property_count;

			// Token: 0x0400045B RID: 1115
			public ushort field_count;

			// Token: 0x0400045C RID: 1116
			public ushort event_count;

			// Token: 0x0400045D RID: 1117
			public ushort nested_type_count;

			// Token: 0x0400045E RID: 1118
			public ushort vtable_count;

			// Token: 0x0400045F RID: 1119
			public ushort interfaces_count;

			// Token: 0x04000460 RID: 1120
			public ushort interface_offsets_count;

			// Token: 0x04000461 RID: 1121
			public byte typeHierarchyDepth;

			// Token: 0x04000462 RID: 1122
			public byte genericRecursionDepth;

			// Token: 0x04000463 RID: 1123
			public byte rank;

			// Token: 0x04000464 RID: 1124
			public byte minimumAlignment;

			// Token: 0x04000465 RID: 1125
			public byte packingSize;

			// Token: 0x04000466 RID: 1126
			public NativeClassStructHandler_21_1.Il2CppClass_21_1.Bitfield0 _bitfield0;

			// Token: 0x020000CF RID: 207
			internal enum Bitfield0 : ushort
			{
				// Token: 0x04000468 RID: 1128
				BIT_valuetype,
				// Token: 0x04000469 RID: 1129
				valuetype,
				// Token: 0x0400046A RID: 1130
				BIT_initialized = 1,
				// Token: 0x0400046B RID: 1131
				initialized,
				// Token: 0x0400046C RID: 1132
				BIT_enumtype = 2,
				// Token: 0x0400046D RID: 1133
				enumtype = 4,
				// Token: 0x0400046E RID: 1134
				BIT_is_generic = 3,
				// Token: 0x0400046F RID: 1135
				is_generic = 8,
				// Token: 0x04000470 RID: 1136
				BIT_has_references = 4,
				// Token: 0x04000471 RID: 1137
				has_references = 16,
				// Token: 0x04000472 RID: 1138
				BIT_init_pending = 5,
				// Token: 0x04000473 RID: 1139
				init_pending = 32,
				// Token: 0x04000474 RID: 1140
				BIT_size_inited = 6,
				// Token: 0x04000475 RID: 1141
				size_inited = 64,
				// Token: 0x04000476 RID: 1142
				BIT_has_finalize = 7,
				// Token: 0x04000477 RID: 1143
				has_finalize = 128,
				// Token: 0x04000478 RID: 1144
				BIT_has_cctor = 8,
				// Token: 0x04000479 RID: 1145
				has_cctor = 256,
				// Token: 0x0400047A RID: 1146
				BIT_is_blittable = 9,
				// Token: 0x0400047B RID: 1147
				is_blittable = 512,
				// Token: 0x0400047C RID: 1148
				BIT_is_import_or_windows_runtime = 10,
				// Token: 0x0400047D RID: 1149
				is_import_or_windows_runtime = 1024
			}
		}

		// Token: 0x020000D0 RID: 208
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x060007E8 RID: 2024 RVA: 0x0001F624 File Offset: 0x0001D824
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_21_1.NativeStructWrapper.HTRYdPolC4p71nlnnXY();
				NativeClassStructHandler_21_1.NativeStructWrapper.vGyu87oVQ8aASQ9brjm();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_feee416e61094c739ba253659ac2e257 == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5afe19cf44424af2ad9aea85585a9cc2 != 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x17000230 RID: 560
			// (get) Token: 0x060007E9 RID: 2025 RVA: 0x0001F6B4 File Offset: 0x0001D8B4
			private unsafe NativeClassStructHandler_21_1.Il2CppClass_21_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000231 RID: 561
			// (get) Token: 0x060007EA RID: 2026 RVA: 0x0001F6C4 File Offset: 0x0001D8C4
			// (set) Token: 0x060007EB RID: 2027 RVA: 0x0001F6DC File Offset: 0x0001D8DC
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_21_1.NativeStructWrapper.VDsrgJoOGhGlj7v66Gl(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_21_1.NativeStructWrapper.Hk5dgGoX0E3MSh9A9gJ(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8155e7a9a9bd4894b741e1951a0eace6 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000232 RID: 562
			// (get) Token: 0x060007EC RID: 2028 RVA: 0x0001F740 File Offset: 0x0001D940
			public IntPtr Pointer { get; }

			// Token: 0x17000233 RID: 563
			// (get) Token: 0x060007ED RID: 2029 RVA: 0x0001F750 File Offset: 0x0001D950
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_21_1.NativeStructWrapper.Ed002xomPJjtQHIDuIu(this.Pointer, sizeof(NativeClassStructHandler_21_1.Il2CppClass_21_1), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x17000234 RID: 564
			// (get) Token: 0x060007EE RID: 2030 RVA: 0x0001F770 File Offset: 0x0001D970
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000235 RID: 565
			// (get) Token: 0x060007EF RID: 2031 RVA: 0x0001F780 File Offset: 0x0001D980
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->byval_arg);
				}
			}

			// Token: 0x17000236 RID: 566
			// (get) Token: 0x060007F0 RID: 2032 RVA: 0x0001F79C File Offset: 0x0001D99C
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->this_arg);
				}
			}

			// Token: 0x17000237 RID: 567
			// (get) Token: 0x060007F1 RID: 2033 RVA: 0x0001F7B8 File Offset: 0x0001D9B8
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x17000238 RID: 568
			// (get) Token: 0x060007F2 RID: 2034 RVA: 0x0001F7CC File Offset: 0x0001D9CC
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x17000239 RID: 569
			// (get) Token: 0x060007F3 RID: 2035 RVA: 0x0001F7E0 File Offset: 0x0001D9E0
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x1700023A RID: 570
			// (get) Token: 0x060007F4 RID: 2036 RVA: 0x0001F7F4 File Offset: 0x0001D9F4
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x1700023B RID: 571
			// (get) Token: 0x060007F5 RID: 2037 RVA: 0x0001F808 File Offset: 0x0001DA08
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x1700023C RID: 572
			// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0001F81C File Offset: 0x0001DA1C
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x1700023D RID: 573
			// (get) Token: 0x060007F7 RID: 2039 RVA: 0x0001F830 File Offset: 0x0001DA30
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x1700023E RID: 574
			// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0001F844 File Offset: 0x0001DA44
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x1700023F RID: 575
			// (get) Token: 0x060007F9 RID: 2041 RVA: 0x0001F858 File Offset: 0x0001DA58
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x17000240 RID: 576
			// (get) Token: 0x060007FA RID: 2042 RVA: 0x0001F86C File Offset: 0x0001DA6C
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x17000241 RID: 577
			// (get) Token: 0x060007FB RID: 2043 RVA: 0x0001F884 File Offset: 0x0001DA84
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000242 RID: 578
			// (get) Token: 0x060007FC RID: 2044 RVA: 0x0001F89C File Offset: 0x0001DA9C
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x17000243 RID: 579
			// (get) Token: 0x060007FD RID: 2045 RVA: 0x0001F8B4 File Offset: 0x0001DAB4
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x17000244 RID: 580
			// (get) Token: 0x060007FE RID: 2046 RVA: 0x0001F8C8 File Offset: 0x0001DAC8
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000245 RID: 581
			// (get) Token: 0x060007FF RID: 2047 RVA: 0x0001F8DC File Offset: 0x0001DADC
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x17000246 RID: 582
			// (get) Token: 0x06000800 RID: 2048 RVA: 0x0001F8F0 File Offset: 0x0001DAF0
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x17000247 RID: 583
			// (get) Token: 0x06000801 RID: 2049 RVA: 0x0001F904 File Offset: 0x0001DB04
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x17000248 RID: 584
			// (get) Token: 0x06000802 RID: 2050 RVA: 0x0001F918 File Offset: 0x0001DB18
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._klassDummy;
				}
			}

			// Token: 0x17000249 RID: 585
			// (get) Token: 0x06000803 RID: 2051 RVA: 0x0001F928 File Offset: 0x0001DB28
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x1700024A RID: 586
			// (get) Token: 0x06000804 RID: 2052 RVA: 0x0001F93C File Offset: 0x0001DB3C
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x1700024B RID: 587
			// (get) Token: 0x06000805 RID: 2053 RVA: 0x0001F950 File Offset: 0x0001DB50
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x1700024C RID: 588
			// (get) Token: 0x06000806 RID: 2054 RVA: 0x0001F964 File Offset: 0x0001DB64
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x1700024D RID: 589
			// (get) Token: 0x06000807 RID: 2055 RVA: 0x0001F978 File Offset: 0x0001DB78
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x1700024E RID: 590
			// (get) Token: 0x06000808 RID: 2056 RVA: 0x0001F98C File Offset: 0x0001DB8C
			// (set) Token: 0x06000809 RID: 2057 RVA: 0x0001F9A4 File Offset: 0x0001DBA4
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_21_1.NativeStructWrapper.VDsrgJoOGhGlj7v66Gl(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 0);
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
							this.SetBit(NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_570d4e075bf443fcbaca8db32e007291 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700024F RID: 591
			// (get) Token: 0x0600080A RID: 2058 RVA: 0x0001FA08 File Offset: 0x0001DC08
			// (set) Token: 0x0600080B RID: 2059 RVA: 0x0001FA20 File Offset: 0x0001DC20
			public bool Initialized
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 1);
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
							this.SetBit(NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fcdd30171ceb4eb7a5570cbbc4f6aec1 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000250 RID: 592
			// (get) Token: 0x0600080C RID: 2060 RVA: 0x0001FA84 File Offset: 0x0001DC84
			// (set) Token: 0x0600080D RID: 2061 RVA: 0x0001FA9C File Offset: 0x0001DC9C
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_21_1.NativeStructWrapper.VDsrgJoOGhGlj7v66Gl(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_21_1.NativeStructWrapper.Hk5dgGoX0E3MSh9A9gJ(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5636e8ee665e464ba930601506bed387 != 0)
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

			// Token: 0x17000251 RID: 593
			// (get) Token: 0x0600080E RID: 2062 RVA: 0x0001FB00 File Offset: 0x0001DD00
			// (set) Token: 0x0600080F RID: 2063 RVA: 0x0001FB18 File Offset: 0x0001DD18
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_21_1.NativeStructWrapper.VDsrgJoOGhGlj7v66Gl(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 3);
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
							this.SetBit(NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ac98984015b94d6a931f8affda832ec9 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000252 RID: 594
			// (get) Token: 0x06000810 RID: 2064 RVA: 0x0001FB7C File Offset: 0x0001DD7C
			// (set) Token: 0x06000811 RID: 2065 RVA: 0x0001FB94 File Offset: 0x0001DD94
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_21_1.NativeStructWrapper.VDsrgJoOGhGlj7v66Gl(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 6);
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
							NativeClassStructHandler_21_1.NativeStructWrapper.Hk5dgGoX0E3MSh9A9gJ(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5c4dec7c475342669cbf3c1205f935ba == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000253 RID: 595
			// (get) Token: 0x06000812 RID: 2066 RVA: 0x0001FBF8 File Offset: 0x0001DDF8
			// (set) Token: 0x06000813 RID: 2067 RVA: 0x0001FC10 File Offset: 0x0001DE10
			public bool HasFinalize
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_21_1.NativeStructWrapper.Hk5dgGoX0E3MSh9A9gJ(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_944294969d634011bf30e3f4f506a31e != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000254 RID: 596
			// (get) Token: 0x06000814 RID: 2068 RVA: 0x0001FC74 File Offset: 0x0001DE74
			// (set) Token: 0x06000815 RID: 2069 RVA: 0x0001FC80 File Offset: 0x0001DE80
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

			// Token: 0x17000255 RID: 597
			// (get) Token: 0x06000816 RID: 2070 RVA: 0x0001FC8C File Offset: 0x0001DE8C
			// (set) Token: 0x06000817 RID: 2071 RVA: 0x0001FC98 File Offset: 0x0001DE98
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

			// Token: 0x06000818 RID: 2072 RVA: 0x0001FCA4 File Offset: 0x0001DEA4
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 3;
				for (;;)
				{
					int num2 = num;
					IntPtr intPtr;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
							num2 = 5;
							continue;
						case 2:
							NativeClassStructHandler_21_1.NativeStructWrapper.HTRYdPolC4p71nlnnXY();
							num2 = 1;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_330a825ae0544050af4112bb9a37f6bb == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							goto IL_A0;
						case 4:
							NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_0783948440564d328b8e79831447d3f6 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 5:
							goto IL_60;
						}
						return;
					}
					IL_60:
					intPtr = Marshal.OffsetOf<NativeClassStructHandler_21_1.Il2CppClass_21_1>(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1809196863 ^ -1805129504 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b15bb2810b414d8fba6ffddaf7154f62));
					num = 4;
					continue;
					IL_A0:
					hIDAYxH6DWLHIthQgC.zSLipEDdx();
					num = 2;
				}
			}

			// Token: 0x06000819 RID: 2073 RVA: 0x0001FD94 File Offset: 0x0001DF94
			internal static void HTRYdPolC4p71nlnnXY()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600081A RID: 2074 RVA: 0x0001FDA4 File Offset: 0x0001DFA4
			internal static void vGyu87oVQ8aASQ9brjm()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x0600081B RID: 2075 RVA: 0x0001FDB4 File Offset: 0x0001DFB4
			internal static bool wxkouloS14yrwMsJgNN()
			{
				return NativeClassStructHandler_21_1.NativeStructWrapper.mySnZMoyfVkAqg9Ud1s == null;
			}

			// Token: 0x0600081C RID: 2076 RVA: 0x0001FDC8 File Offset: 0x0001DFC8
			internal static NativeClassStructHandler_21_1.NativeStructWrapper R1G9MvogHD3eEnotK0V()
			{
				return NativeClassStructHandler_21_1.NativeStructWrapper.mySnZMoyfVkAqg9Ud1s;
			}

			// Token: 0x0600081D RID: 2077 RVA: 0x0001FDD8 File Offset: 0x0001DFD8
			internal static bool VDsrgJoOGhGlj7v66Gl(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x0600081E RID: 2078 RVA: 0x0001FDF4 File Offset: 0x0001DFF4
			internal static void Hk5dgGoX0E3MSh9A9gJ(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x0600081F RID: 2079 RVA: 0x0001FE14 File Offset: 0x0001E014
			internal static IntPtr Ed002xomPJjtQHIDuIu(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x0400047E RID: 1150
			private static readonly int _bitfield0offset;

			// Token: 0x0400047F RID: 1151
			private unsafe Il2CppClass* _klassDummy;

			// Token: 0x04000481 RID: 1153
			internal static object mySnZMoyfVkAqg9Ud1s;
		}
	}
}
