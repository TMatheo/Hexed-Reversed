using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000CB RID: 203
	[ApplicableToUnityVersionsSince("5.4.4")]
	public class NativeClassStructHandler_21_1 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x060007C1 RID: 1985 RVA: 0x00010B00 File Offset: 0x0000ED00
		public int Size()
		{
			return sizeof(NativeClassStructHandler_21_1.Il2CppClass_21_1);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00010B10 File Offset: 0x0000ED10
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
					NativeClassStructHandler_21_1.Il2CppClass_21_1* ptr;
					IntPtr buffer = ptr = MarshalExtend.AllocHGlobal(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
					*ptr = default(NativeClassStructHandler_21_1.Il2CppClass_21_1);
					NativeClassStructHandler_21_1.NjI4Tg69pedXmDRyRDU(buffer);
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3bc41e98a8e849aea1e93dfe0f04c43b == 0)
					{
						num2 = 0;
					}
					break;
				}
				}
			}
			IL_2B:
			throw new NotSupportedException(NativeClassStructHandler_21_1.P1fn206IM00Ziioa3hj(870414366 - 779185206 ^ 365939810 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae));
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00010BB4 File Offset: 0x0000EDB4
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ac2c10c141e144acbcef06aa86a10430 == 0)
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
			return new NativeClassStructHandler_21_1.NativeStructWrapper(ptr);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00010C1C File Offset: 0x0000EE1C
		public NativeClassStructHandler_21_1()
		{
			NativeClassStructHandler_21_1.XZQD6V6diSHaYJ3w4MB();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6dbfd13d96434eb59d868fecd0ad1cda == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00010C80 File Offset: 0x0000EE80
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_21_1()
		{
			NativeClassStructHandler_21_1.yXbpsK6ig5pljZ4T2K6();
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00010C90 File Offset: 0x0000EE90
		internal static void NjI4Tg69pedXmDRyRDU(IntPtr buffer)
		{
			MarshalExtend.FreeHGlobal(buffer);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00010CA4 File Offset: 0x0000EEA4
		internal static object P1fn206IM00Ziioa3hj(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00010CB8 File Offset: 0x0000EEB8
		internal static bool P1o3ci6WN6NLcMT4ZmW()
		{
			return NativeClassStructHandler_21_1.R0aFSo6MUI5E3Vlbmho == null;
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00010CCC File Offset: 0x0000EECC
		internal static NativeClassStructHandler_21_1 YpGWLV6CvIPVemCKlXo()
		{
			return NativeClassStructHandler_21_1.R0aFSo6MUI5E3Vlbmho;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00010CDC File Offset: 0x0000EEDC
		internal static void XZQD6V6diSHaYJ3w4MB()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00010CEC File Offset: 0x0000EEEC
		internal static void yXbpsK6ig5pljZ4T2K6()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000428 RID: 1064
		private static NativeClassStructHandler_21_1 R0aFSo6MUI5E3Vlbmho;

		// Token: 0x020000CC RID: 204
		internal struct Il2CppClass_21_1
		{
			// Token: 0x04000429 RID: 1065
			public unsafe Il2CppImage* image;

			// Token: 0x0400042A RID: 1066
			public unsafe void* gc_desc;

			// Token: 0x0400042B RID: 1067
			public unsafe byte* name;

			// Token: 0x0400042C RID: 1068
			public unsafe byte* namespaze;

			// Token: 0x0400042D RID: 1069
			public unsafe Il2CppTypeStruct* byval_arg;

			// Token: 0x0400042E RID: 1070
			public unsafe Il2CppTypeStruct* this_arg;

			// Token: 0x0400042F RID: 1071
			public unsafe Il2CppClass* element_class;

			// Token: 0x04000430 RID: 1072
			public unsafe Il2CppClass* castClass;

			// Token: 0x04000431 RID: 1073
			public unsafe Il2CppClass* declaringType;

			// Token: 0x04000432 RID: 1074
			public unsafe Il2CppClass* parent;

			// Token: 0x04000433 RID: 1075
			public unsafe void* generic_class;

			// Token: 0x04000434 RID: 1076
			public unsafe void* typeDefinition;

			// Token: 0x04000435 RID: 1077
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x04000436 RID: 1078
			public unsafe Il2CppEventInfo* events;

			// Token: 0x04000437 RID: 1079
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000438 RID: 1080
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x04000439 RID: 1081
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x0400043A RID: 1082
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x0400043B RID: 1083
			public unsafe VirtualInvokeData* vtable;

			// Token: 0x0400043C RID: 1084
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x0400043D RID: 1085
			public unsafe void* static_fields;

			// Token: 0x0400043E RID: 1086
			public unsafe void* rgctx_data;

			// Token: 0x0400043F RID: 1087
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x04000440 RID: 1088
			public uint cctor_started;

			// Token: 0x04000441 RID: 1089
			public uint cctor_finished;

			// Token: 0x04000442 RID: 1090
			public ulong cctor_thread;

			// Token: 0x04000443 RID: 1091
			public int genericContainerIndex;

			// Token: 0x04000444 RID: 1092
			public int customAttributeIndex;

			// Token: 0x04000445 RID: 1093
			public uint instance_size;

			// Token: 0x04000446 RID: 1094
			public uint actualSize;

			// Token: 0x04000447 RID: 1095
			public uint element_size;

			// Token: 0x04000448 RID: 1096
			public int native_size;

			// Token: 0x04000449 RID: 1097
			public uint static_fields_size;

			// Token: 0x0400044A RID: 1098
			public uint thread_static_fields_size;

			// Token: 0x0400044B RID: 1099
			public int thread_static_fields_offset;

			// Token: 0x0400044C RID: 1100
			public uint flags;

			// Token: 0x0400044D RID: 1101
			public uint token;

			// Token: 0x0400044E RID: 1102
			public ushort method_count;

			// Token: 0x0400044F RID: 1103
			public ushort property_count;

			// Token: 0x04000450 RID: 1104
			public ushort field_count;

			// Token: 0x04000451 RID: 1105
			public ushort event_count;

			// Token: 0x04000452 RID: 1106
			public ushort nested_type_count;

			// Token: 0x04000453 RID: 1107
			public ushort vtable_count;

			// Token: 0x04000454 RID: 1108
			public ushort interfaces_count;

			// Token: 0x04000455 RID: 1109
			public ushort interface_offsets_count;

			// Token: 0x04000456 RID: 1110
			public byte typeHierarchyDepth;

			// Token: 0x04000457 RID: 1111
			public byte genericRecursionDepth;

			// Token: 0x04000458 RID: 1112
			public byte rank;

			// Token: 0x04000459 RID: 1113
			public byte minimumAlignment;

			// Token: 0x0400045A RID: 1114
			public byte packingSize;

			// Token: 0x0400045B RID: 1115
			public NativeClassStructHandler_21_1.Il2CppClass_21_1.Bitfield0 _bitfield0;

			// Token: 0x020000CD RID: 205
			internal enum Bitfield0 : ushort
			{
				// Token: 0x0400045D RID: 1117
				BIT_valuetype,
				// Token: 0x0400045E RID: 1118
				valuetype,
				// Token: 0x0400045F RID: 1119
				BIT_initialized = 1,
				// Token: 0x04000460 RID: 1120
				initialized,
				// Token: 0x04000461 RID: 1121
				BIT_enumtype = 2,
				// Token: 0x04000462 RID: 1122
				enumtype = 4,
				// Token: 0x04000463 RID: 1123
				BIT_is_generic = 3,
				// Token: 0x04000464 RID: 1124
				is_generic = 8,
				// Token: 0x04000465 RID: 1125
				BIT_has_references = 4,
				// Token: 0x04000466 RID: 1126
				has_references = 16,
				// Token: 0x04000467 RID: 1127
				BIT_init_pending = 5,
				// Token: 0x04000468 RID: 1128
				init_pending = 32,
				// Token: 0x04000469 RID: 1129
				BIT_size_inited = 6,
				// Token: 0x0400046A RID: 1130
				size_inited = 64,
				// Token: 0x0400046B RID: 1131
				BIT_has_finalize = 7,
				// Token: 0x0400046C RID: 1132
				has_finalize = 128,
				// Token: 0x0400046D RID: 1133
				BIT_has_cctor = 8,
				// Token: 0x0400046E RID: 1134
				has_cctor = 256,
				// Token: 0x0400046F RID: 1135
				BIT_is_blittable = 9,
				// Token: 0x04000470 RID: 1136
				is_blittable = 512,
				// Token: 0x04000471 RID: 1137
				BIT_is_import_or_windows_runtime = 10,
				// Token: 0x04000472 RID: 1138
				is_import_or_windows_runtime = 1024
			}
		}

		// Token: 0x020000CE RID: 206
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x060007CC RID: 1996 RVA: 0x0001EA0C File Offset: 0x0001CC0C
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeClassStructHandler_21_1.NativeStructWrapper.fBJJKNm82MOKZHa5dld();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ce8abd079f9447b3bade260ffc64f0b8 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3e2009ed69c04f5799431b4e58cafb2a == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x17000230 RID: 560
			// (get) Token: 0x060007CD RID: 1997 RVA: 0x0001EA9C File Offset: 0x0001CC9C
			private unsafe NativeClassStructHandler_21_1.Il2CppClass_21_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000231 RID: 561
			// (get) Token: 0x060007CE RID: 1998 RVA: 0x0001EAAC File Offset: 0x0001CCAC
			// (set) Token: 0x060007CF RID: 1999 RVA: 0x0001EAC4 File Offset: 0x0001CCC4
			public bool HasReferences
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_21_1.NativeStructWrapper.XBu5T5mnXJi9epMxvRR(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7492c06848354e9185cf647bb6904451 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000232 RID: 562
			// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0001EB28 File Offset: 0x0001CD28
			public IntPtr Pointer { get; }

			// Token: 0x17000233 RID: 563
			// (get) Token: 0x060007D1 RID: 2001 RVA: 0x0001EB38 File Offset: 0x0001CD38
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_21_1.NativeStructWrapper.i5FigFmbbqyFq9c2Lip(this.Pointer, sizeof(NativeClassStructHandler_21_1.Il2CppClass_21_1), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x17000234 RID: 564
			// (get) Token: 0x060007D2 RID: 2002 RVA: 0x0001EB58 File Offset: 0x0001CD58
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000235 RID: 565
			// (get) Token: 0x060007D3 RID: 2003 RVA: 0x0001EB68 File Offset: 0x0001CD68
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->byval_arg);
				}
			}

			// Token: 0x17000236 RID: 566
			// (get) Token: 0x060007D4 RID: 2004 RVA: 0x0001EB84 File Offset: 0x0001CD84
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->this_arg);
				}
			}

			// Token: 0x17000237 RID: 567
			// (get) Token: 0x060007D5 RID: 2005 RVA: 0x0001EBA0 File Offset: 0x0001CDA0
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x17000238 RID: 568
			// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0001EBB4 File Offset: 0x0001CDB4
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x17000239 RID: 569
			// (get) Token: 0x060007D7 RID: 2007 RVA: 0x0001EBC8 File Offset: 0x0001CDC8
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x1700023A RID: 570
			// (get) Token: 0x060007D8 RID: 2008 RVA: 0x0001EBDC File Offset: 0x0001CDDC
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x1700023B RID: 571
			// (get) Token: 0x060007D9 RID: 2009 RVA: 0x0001EBF0 File Offset: 0x0001CDF0
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x1700023C RID: 572
			// (get) Token: 0x060007DA RID: 2010 RVA: 0x0001EC04 File Offset: 0x0001CE04
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x1700023D RID: 573
			// (get) Token: 0x060007DB RID: 2011 RVA: 0x0001EC18 File Offset: 0x0001CE18
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x1700023E RID: 574
			// (get) Token: 0x060007DC RID: 2012 RVA: 0x0001EC2C File Offset: 0x0001CE2C
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x1700023F RID: 575
			// (get) Token: 0x060007DD RID: 2013 RVA: 0x0001EC40 File Offset: 0x0001CE40
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x17000240 RID: 576
			// (get) Token: 0x060007DE RID: 2014 RVA: 0x0001EC54 File Offset: 0x0001CE54
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x17000241 RID: 577
			// (get) Token: 0x060007DF RID: 2015 RVA: 0x0001EC6C File Offset: 0x0001CE6C
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000242 RID: 578
			// (get) Token: 0x060007E0 RID: 2016 RVA: 0x0001EC84 File Offset: 0x0001CE84
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x17000243 RID: 579
			// (get) Token: 0x060007E1 RID: 2017 RVA: 0x0001EC9C File Offset: 0x0001CE9C
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x17000244 RID: 580
			// (get) Token: 0x060007E2 RID: 2018 RVA: 0x0001ECB0 File Offset: 0x0001CEB0
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000245 RID: 581
			// (get) Token: 0x060007E3 RID: 2019 RVA: 0x0001ECC4 File Offset: 0x0001CEC4
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x17000246 RID: 582
			// (get) Token: 0x060007E4 RID: 2020 RVA: 0x0001ECD8 File Offset: 0x0001CED8
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x17000247 RID: 583
			// (get) Token: 0x060007E5 RID: 2021 RVA: 0x0001ECEC File Offset: 0x0001CEEC
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x17000248 RID: 584
			// (get) Token: 0x060007E6 RID: 2022 RVA: 0x0001ED00 File Offset: 0x0001CF00
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._klassDummy;
				}
			}

			// Token: 0x17000249 RID: 585
			// (get) Token: 0x060007E7 RID: 2023 RVA: 0x0001ED10 File Offset: 0x0001CF10
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x1700024A RID: 586
			// (get) Token: 0x060007E8 RID: 2024 RVA: 0x0001ED24 File Offset: 0x0001CF24
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x1700024B RID: 587
			// (get) Token: 0x060007E9 RID: 2025 RVA: 0x0001ED38 File Offset: 0x0001CF38
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x1700024C RID: 588
			// (get) Token: 0x060007EA RID: 2026 RVA: 0x0001ED4C File Offset: 0x0001CF4C
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x1700024D RID: 589
			// (get) Token: 0x060007EB RID: 2027 RVA: 0x0001ED60 File Offset: 0x0001CF60
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x1700024E RID: 590
			// (get) Token: 0x060007EC RID: 2028 RVA: 0x0001ED74 File Offset: 0x0001CF74
			// (set) Token: 0x060007ED RID: 2029 RVA: 0x0001ED8C File Offset: 0x0001CF8C
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_21_1.NativeStructWrapper.DXfwZhm66ZOss0L7EBW(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 0);
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
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2356ac6ca5954f1897cd5bbbe0161ae5 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700024F RID: 591
			// (get) Token: 0x060007EE RID: 2030 RVA: 0x0001EDF0 File Offset: 0x0001CFF0
			// (set) Token: 0x060007EF RID: 2031 RVA: 0x0001EE08 File Offset: 0x0001D008
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_21_1.NativeStructWrapper.DXfwZhm66ZOss0L7EBW(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_21_1.NativeStructWrapper.XBu5T5mnXJi9epMxvRR(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b5c96750853e4496814af588489331dc == 0)
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

			// Token: 0x17000250 RID: 592
			// (get) Token: 0x060007F0 RID: 2032 RVA: 0x0001EE6C File Offset: 0x0001D06C
			// (set) Token: 0x060007F1 RID: 2033 RVA: 0x0001EE84 File Offset: 0x0001D084
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_21_1.NativeStructWrapper.DXfwZhm66ZOss0L7EBW(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_21_1.NativeStructWrapper.XBu5T5mnXJi9epMxvRR(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7fef7bb77728417ab4965dd0775b5899 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000251 RID: 593
			// (get) Token: 0x060007F2 RID: 2034 RVA: 0x0001EEE8 File Offset: 0x0001D0E8
			// (set) Token: 0x060007F3 RID: 2035 RVA: 0x0001EF00 File Offset: 0x0001D100
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_21_1.NativeStructWrapper.DXfwZhm66ZOss0L7EBW(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_21_1.NativeStructWrapper.XBu5T5mnXJi9epMxvRR(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_26479210ae524f22ae1fe060a08fdd55 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000252 RID: 594
			// (get) Token: 0x060007F4 RID: 2036 RVA: 0x0001EF64 File Offset: 0x0001D164
			// (set) Token: 0x060007F5 RID: 2037 RVA: 0x0001EF7C File Offset: 0x0001D17C
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_21_1.NativeStructWrapper.DXfwZhm66ZOss0L7EBW(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 6);
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
							NativeClassStructHandler_21_1.NativeStructWrapper.XBu5T5mnXJi9epMxvRR(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ffe1ad8c1cf94bc78c25e67b0264547e != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000253 RID: 595
			// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0001EFE0 File Offset: 0x0001D1E0
			// (set) Token: 0x060007F7 RID: 2039 RVA: 0x0001EFF8 File Offset: 0x0001D1F8
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_21_1.NativeStructWrapper.DXfwZhm66ZOss0L7EBW(this, NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 7);
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
							this.SetBit(NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3bc41e98a8e849aea1e93dfe0f04c43b != 0)
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

			// Token: 0x17000254 RID: 596
			// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0001F05C File Offset: 0x0001D25C
			// (set) Token: 0x060007F9 RID: 2041 RVA: 0x0001F068 File Offset: 0x0001D268
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
			// (get) Token: 0x060007FA RID: 2042 RVA: 0x0001F074 File Offset: 0x0001D274
			// (set) Token: 0x060007FB RID: 2043 RVA: 0x0001F080 File Offset: 0x0001D280
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

			// Token: 0x060007FC RID: 2044 RVA: 0x0001F08C File Offset: 0x0001D28C
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
						NativeClassStructHandler_21_1.NativeStructWrapper.CKMDWkmymG89SHvj7mD();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_07ecbd0ef7af44eb94dd5a58ea706c8a == 0)
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
						NativeClassStructHandler_21_1.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bac7568f2bc04130b6b980225b2cc409 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					case 4:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_21_1.Il2CppClass_21_1>(NativeClassStructHandler_21_1.NativeStructWrapper.b7kEVLmJGoQLSJjMbnF(-579874071 + 1102803655 ^ 1299933137 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_11d7514559f14fcba52669ac71e3cb39));
						num2 = 2;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cfadd7e02c524ea298356b7415bd67b6 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					case 5:
						NativeClassStructHandler_21_1.NativeStructWrapper.fBJJKNm82MOKZHa5dld();
						num2 = 4;
						continue;
					}
					hIDAYxH6DWLHIthQgC.oDuBOTgYK();
					num2 = 5;
				}
			}

			// Token: 0x060007FD RID: 2045 RVA: 0x0001F190 File Offset: 0x0001D390
			internal static void fBJJKNm82MOKZHa5dld()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x060007FE RID: 2046 RVA: 0x0001F1A0 File Offset: 0x0001D3A0
			internal static bool sgaJP2mxtgiJX1j7re0()
			{
				return NativeClassStructHandler_21_1.NativeStructWrapper.cTB915mvKHZjfBBnwoJ == null;
			}

			// Token: 0x060007FF RID: 2047 RVA: 0x0001F1B4 File Offset: 0x0001D3B4
			internal static NativeClassStructHandler_21_1.NativeStructWrapper tKcK9cmYHrXYI4U030o()
			{
				return NativeClassStructHandler_21_1.NativeStructWrapper.cTB915mvKHZjfBBnwoJ;
			}

			// Token: 0x06000800 RID: 2048 RVA: 0x0001F1C4 File Offset: 0x0001D3C4
			internal static void XBu5T5mnXJi9epMxvRR(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000801 RID: 2049 RVA: 0x0001F1E4 File Offset: 0x0001D3E4
			internal static IntPtr i5FigFmbbqyFq9c2Lip(IntPtr A_0, int A_1, object A_2)
			{
				return apS1BFcfBa3gXUspL9j.muOq5LWqgj(A_0, A_1, A_2);
			}

			// Token: 0x06000802 RID: 2050 RVA: 0x0001F200 File Offset: 0x0001D400
			internal static bool DXfwZhm66ZOss0L7EBW(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000803 RID: 2051 RVA: 0x0001F21C File Offset: 0x0001D41C
			internal static void CKMDWkmymG89SHvj7mD()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000804 RID: 2052 RVA: 0x0001F22C File Offset: 0x0001D42C
			internal static object b7kEVLmJGoQLSJjMbnF(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000473 RID: 1139
			private static readonly int _bitfield0offset;

			// Token: 0x04000474 RID: 1140
			private unsafe Il2CppClass* _klassDummy;

			// Token: 0x04000476 RID: 1142
			private static object cTB915mvKHZjfBBnwoJ;
		}
	}
}
