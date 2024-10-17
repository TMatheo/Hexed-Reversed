using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000D1 RID: 209
	[ApplicableToUnityVersionsSince("5.5.0")]
	public class NativeClassStructHandler_22_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000820 RID: 2080 RVA: 0x000118F8 File Offset: 0x0000FAF8
		public int Size()
		{
			return sizeof(NativeClassStructHandler_22_0.Il2CppClass_22_0);
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00011908 File Offset: 0x0000FB08
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_22_0.Il2CppClass_22_0* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_22_0.TFKDNb6IXVsfCNuXHhF(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_22_0.Il2CppClass_22_0);
			ptr2->byval_arg = ((INativeTypeStruct)NativeClassStructHandler_22_0.E8QDK66GSFlPRfioSte()).TypePointer;
			ptr2->this_arg = UnityVersionHandler.NewType().TypePointer;
			return new NativeClassStructHandler_22_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00011964 File Offset: 0x0000FB64
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_61a3825996b24609815f6b482bf680d9 != 0)
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
			return new NativeClassStructHandler_22_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x000119CC File Offset: 0x0000FBCC
		public NativeClassStructHandler_22_0()
		{
			NativeClassStructHandler_22_0.sxECkU6YnNG0PsJNNlb();
			NativeClassStructHandler_22_0.On15Ky6aVtOtWqS8RVo();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9f56599a6a304695b6cfc284bd7d7c9a == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00011A30 File Offset: 0x0000FC30
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_22_0()
		{
			NativeClassStructHandler_22_0.hBfO826COyGbEfJ6Hxg();
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00011A40 File Offset: 0x0000FC40
		internal static IntPtr TFKDNb6IXVsfCNuXHhF(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00011A54 File Offset: 0x0000FC54
		internal static object E8QDK66GSFlPRfioSte()
		{
			return UnityVersionHandler.NewType();
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00011A64 File Offset: 0x0000FC64
		internal static bool VEriqU69fkBKtOKLXKn()
		{
			return NativeClassStructHandler_22_0.jw5O8O6qOhxN1VwatTm == null;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00011A78 File Offset: 0x0000FC78
		internal static NativeClassStructHandler_22_0 c5O8LU6iQZcWbxqSACX()
		{
			return NativeClassStructHandler_22_0.jw5O8O6qOhxN1VwatTm;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00011A88 File Offset: 0x0000FC88
		internal static void sxECkU6YnNG0PsJNNlb()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00011A98 File Offset: 0x0000FC98
		internal static void On15Ky6aVtOtWqS8RVo()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00011AA8 File Offset: 0x0000FCA8
		internal static void hBfO826COyGbEfJ6Hxg()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000482 RID: 1154
		internal static NativeClassStructHandler_22_0 jw5O8O6qOhxN1VwatTm;

		// Token: 0x020000D2 RID: 210
		internal struct Il2CppClass_22_0
		{
			// Token: 0x04000483 RID: 1155
			public unsafe Il2CppImage* image;

			// Token: 0x04000484 RID: 1156
			public unsafe void* gc_desc;

			// Token: 0x04000485 RID: 1157
			public unsafe byte* name;

			// Token: 0x04000486 RID: 1158
			public unsafe byte* namespaze;

			// Token: 0x04000487 RID: 1159
			public unsafe Il2CppTypeStruct* byval_arg;

			// Token: 0x04000488 RID: 1160
			public unsafe Il2CppTypeStruct* this_arg;

			// Token: 0x04000489 RID: 1161
			public unsafe Il2CppClass* element_class;

			// Token: 0x0400048A RID: 1162
			public unsafe Il2CppClass* castClass;

			// Token: 0x0400048B RID: 1163
			public unsafe Il2CppClass* declaringType;

			// Token: 0x0400048C RID: 1164
			public unsafe Il2CppClass* parent;

			// Token: 0x0400048D RID: 1165
			public unsafe void* generic_class;

			// Token: 0x0400048E RID: 1166
			public unsafe void* typeDefinition;

			// Token: 0x0400048F RID: 1167
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x04000490 RID: 1168
			public unsafe Il2CppEventInfo* events;

			// Token: 0x04000491 RID: 1169
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000492 RID: 1170
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x04000493 RID: 1171
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000494 RID: 1172
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x04000495 RID: 1173
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x04000496 RID: 1174
			public unsafe void* static_fields;

			// Token: 0x04000497 RID: 1175
			public unsafe void* rgctx_data;

			// Token: 0x04000498 RID: 1176
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x04000499 RID: 1177
			public uint cctor_started;

			// Token: 0x0400049A RID: 1178
			public uint cctor_finished;

			// Token: 0x0400049B RID: 1179
			public ulong cctor_thread;

			// Token: 0x0400049C RID: 1180
			public int genericContainerIndex;

			// Token: 0x0400049D RID: 1181
			public int customAttributeIndex;

			// Token: 0x0400049E RID: 1182
			public uint instance_size;

			// Token: 0x0400049F RID: 1183
			public uint actualSize;

			// Token: 0x040004A0 RID: 1184
			public uint element_size;

			// Token: 0x040004A1 RID: 1185
			public int native_size;

			// Token: 0x040004A2 RID: 1186
			public uint static_fields_size;

			// Token: 0x040004A3 RID: 1187
			public uint thread_static_fields_size;

			// Token: 0x040004A4 RID: 1188
			public int thread_static_fields_offset;

			// Token: 0x040004A5 RID: 1189
			public uint flags;

			// Token: 0x040004A6 RID: 1190
			public uint token;

			// Token: 0x040004A7 RID: 1191
			public ushort method_count;

			// Token: 0x040004A8 RID: 1192
			public ushort property_count;

			// Token: 0x040004A9 RID: 1193
			public ushort field_count;

			// Token: 0x040004AA RID: 1194
			public ushort event_count;

			// Token: 0x040004AB RID: 1195
			public ushort nested_type_count;

			// Token: 0x040004AC RID: 1196
			public ushort vtable_count;

			// Token: 0x040004AD RID: 1197
			public ushort interfaces_count;

			// Token: 0x040004AE RID: 1198
			public ushort interface_offsets_count;

			// Token: 0x040004AF RID: 1199
			public byte typeHierarchyDepth;

			// Token: 0x040004B0 RID: 1200
			public byte rank;

			// Token: 0x040004B1 RID: 1201
			public byte minimumAlignment;

			// Token: 0x040004B2 RID: 1202
			public byte packingSize;

			// Token: 0x040004B3 RID: 1203
			public NativeClassStructHandler_22_0.Il2CppClass_22_0.Bitfield0 _bitfield0;

			// Token: 0x020000D3 RID: 211
			internal enum Bitfield0 : ushort
			{
				// Token: 0x040004B5 RID: 1205
				BIT_valuetype,
				// Token: 0x040004B6 RID: 1206
				valuetype,
				// Token: 0x040004B7 RID: 1207
				BIT_initialized = 1,
				// Token: 0x040004B8 RID: 1208
				initialized,
				// Token: 0x040004B9 RID: 1209
				BIT_enumtype = 2,
				// Token: 0x040004BA RID: 1210
				enumtype = 4,
				// Token: 0x040004BB RID: 1211
				BIT_is_generic = 3,
				// Token: 0x040004BC RID: 1212
				is_generic = 8,
				// Token: 0x040004BD RID: 1213
				BIT_has_references = 4,
				// Token: 0x040004BE RID: 1214
				has_references = 16,
				// Token: 0x040004BF RID: 1215
				BIT_init_pending = 5,
				// Token: 0x040004C0 RID: 1216
				init_pending = 32,
				// Token: 0x040004C1 RID: 1217
				BIT_size_inited = 6,
				// Token: 0x040004C2 RID: 1218
				size_inited = 64,
				// Token: 0x040004C3 RID: 1219
				BIT_has_finalize = 7,
				// Token: 0x040004C4 RID: 1220
				has_finalize = 128,
				// Token: 0x040004C5 RID: 1221
				BIT_has_cctor = 8,
				// Token: 0x040004C6 RID: 1222
				has_cctor = 256,
				// Token: 0x040004C7 RID: 1223
				BIT_is_blittable = 9,
				// Token: 0x040004C8 RID: 1224
				is_blittable = 512,
				// Token: 0x040004C9 RID: 1225
				BIT_is_import_or_windows_runtime = 10,
				// Token: 0x040004CA RID: 1226
				is_import_or_windows_runtime = 1024,
				// Token: 0x040004CB RID: 1227
				BIT_is_vtable_initialized = 11,
				// Token: 0x040004CC RID: 1228
				is_vtable_initialized = 2048
			}
		}

		// Token: 0x020000D4 RID: 212
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x0600082C RID: 2092 RVA: 0x0001FE30 File Offset: 0x0001E030
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_22_0.NativeStructWrapper.bVss8Ao5KLNlU5NSfDP();
				NativeClassStructHandler_22_0.NativeStructWrapper.Lq2qNconlx8SHW3fBcp();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_667bd9633593433784ebdd2b3fdc8daf != 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_780e0c86b08f49d785f406cf802c7e87 == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x17000256 RID: 598
			// (get) Token: 0x0600082D RID: 2093 RVA: 0x0001FEC0 File Offset: 0x0001E0C0
			private unsafe NativeClassStructHandler_22_0.Il2CppClass_22_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000257 RID: 599
			// (get) Token: 0x0600082E RID: 2094 RVA: 0x0001FED0 File Offset: 0x0001E0D0
			// (set) Token: 0x0600082F RID: 2095 RVA: 0x0001FEE8 File Offset: 0x0001E0E8
			public bool HasReferences
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_22_0.NativeStructWrapper.VVXCddo3V3Fcfc50sLa(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_4cb85c330fed4a769825a3343f966401 != 0)
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

			// Token: 0x17000258 RID: 600
			// (get) Token: 0x06000830 RID: 2096 RVA: 0x0001FF4C File Offset: 0x0001E14C
			public IntPtr Pointer { get; }

			// Token: 0x17000259 RID: 601
			// (get) Token: 0x06000831 RID: 2097 RVA: 0x0001FF5C File Offset: 0x0001E15C
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_22_0.NativeStructWrapper.yuccs7o1GX7P1yeVdeb(this.Pointer, sizeof(NativeClassStructHandler_22_0.Il2CppClass_22_0), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x1700025A RID: 602
			// (get) Token: 0x06000832 RID: 2098 RVA: 0x0001FF7C File Offset: 0x0001E17C
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700025B RID: 603
			// (get) Token: 0x06000833 RID: 2099 RVA: 0x0001FF8C File Offset: 0x0001E18C
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->byval_arg);
				}
			}

			// Token: 0x1700025C RID: 604
			// (get) Token: 0x06000834 RID: 2100 RVA: 0x0001FFA8 File Offset: 0x0001E1A8
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->this_arg);
				}
			}

			// Token: 0x1700025D RID: 605
			// (get) Token: 0x06000835 RID: 2101 RVA: 0x0001FFC4 File Offset: 0x0001E1C4
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x1700025E RID: 606
			// (get) Token: 0x06000836 RID: 2102 RVA: 0x0001FFD8 File Offset: 0x0001E1D8
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x1700025F RID: 607
			// (get) Token: 0x06000837 RID: 2103 RVA: 0x0001FFEC File Offset: 0x0001E1EC
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x17000260 RID: 608
			// (get) Token: 0x06000838 RID: 2104 RVA: 0x00020000 File Offset: 0x0001E200
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x17000261 RID: 609
			// (get) Token: 0x06000839 RID: 2105 RVA: 0x00020014 File Offset: 0x0001E214
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x17000262 RID: 610
			// (get) Token: 0x0600083A RID: 2106 RVA: 0x00020028 File Offset: 0x0001E228
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x17000263 RID: 611
			// (get) Token: 0x0600083B RID: 2107 RVA: 0x0002003C File Offset: 0x0001E23C
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x17000264 RID: 612
			// (get) Token: 0x0600083C RID: 2108 RVA: 0x00020050 File Offset: 0x0001E250
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x17000265 RID: 613
			// (get) Token: 0x0600083D RID: 2109 RVA: 0x00020064 File Offset: 0x0001E264
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x17000266 RID: 614
			// (get) Token: 0x0600083E RID: 2110 RVA: 0x00020078 File Offset: 0x0001E278
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x17000267 RID: 615
			// (get) Token: 0x0600083F RID: 2111 RVA: 0x00020090 File Offset: 0x0001E290
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000268 RID: 616
			// (get) Token: 0x06000840 RID: 2112 RVA: 0x000200A8 File Offset: 0x0001E2A8
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x17000269 RID: 617
			// (get) Token: 0x06000841 RID: 2113 RVA: 0x000200C0 File Offset: 0x0001E2C0
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x1700026A RID: 618
			// (get) Token: 0x06000842 RID: 2114 RVA: 0x000200D4 File Offset: 0x0001E2D4
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700026B RID: 619
			// (get) Token: 0x06000843 RID: 2115 RVA: 0x000200E8 File Offset: 0x0001E2E8
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x1700026C RID: 620
			// (get) Token: 0x06000844 RID: 2116 RVA: 0x000200FC File Offset: 0x0001E2FC
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x1700026D RID: 621
			// (get) Token: 0x06000845 RID: 2117 RVA: 0x00020110 File Offset: 0x0001E310
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x1700026E RID: 622
			// (get) Token: 0x06000846 RID: 2118 RVA: 0x00020124 File Offset: 0x0001E324
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._klassDummy;
				}
			}

			// Token: 0x1700026F RID: 623
			// (get) Token: 0x06000847 RID: 2119 RVA: 0x00020134 File Offset: 0x0001E334
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x17000270 RID: 624
			// (get) Token: 0x06000848 RID: 2120 RVA: 0x00020148 File Offset: 0x0001E348
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x17000271 RID: 625
			// (get) Token: 0x06000849 RID: 2121 RVA: 0x0002015C File Offset: 0x0001E35C
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x17000272 RID: 626
			// (get) Token: 0x0600084A RID: 2122 RVA: 0x00020170 File Offset: 0x0001E370
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x17000273 RID: 627
			// (get) Token: 0x0600084B RID: 2123 RVA: 0x00020184 File Offset: 0x0001E384
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x17000274 RID: 628
			// (get) Token: 0x0600084C RID: 2124 RVA: 0x00020198 File Offset: 0x0001E398
			// (set) Token: 0x0600084D RID: 2125 RVA: 0x000201B0 File Offset: 0x0001E3B0
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_22_0.NativeStructWrapper.qnOVQwoMQbpovnSJUT4(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_22_0.NativeStructWrapper.VVXCddo3V3Fcfc50sLa(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_570d4e075bf443fcbaca8db32e007291 == 0)
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

			// Token: 0x17000275 RID: 629
			// (get) Token: 0x0600084E RID: 2126 RVA: 0x00020214 File Offset: 0x0001E414
			// (set) Token: 0x0600084F RID: 2127 RVA: 0x0002022C File Offset: 0x0001E42C
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_22_0.NativeStructWrapper.qnOVQwoMQbpovnSJUT4(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 1);
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
							this.SetBit(NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_17522b2a3ddb488c87b7266d3b1f941d == 0)
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

			// Token: 0x17000276 RID: 630
			// (get) Token: 0x06000850 RID: 2128 RVA: 0x00020290 File Offset: 0x0001E490
			// (set) Token: 0x06000851 RID: 2129 RVA: 0x000202A8 File Offset: 0x0001E4A8
			public bool EnumType
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 2);
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
							this.SetBit(NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc == 0)
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

			// Token: 0x17000277 RID: 631
			// (get) Token: 0x06000852 RID: 2130 RVA: 0x0002030C File Offset: 0x0001E50C
			// (set) Token: 0x06000853 RID: 2131 RVA: 0x00020324 File Offset: 0x0001E524
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_22_0.NativeStructWrapper.qnOVQwoMQbpovnSJUT4(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_22_0.NativeStructWrapper.VVXCddo3V3Fcfc50sLa(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 3, value);
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

			// Token: 0x17000278 RID: 632
			// (get) Token: 0x06000854 RID: 2132 RVA: 0x00020388 File Offset: 0x0001E588
			// (set) Token: 0x06000855 RID: 2133 RVA: 0x000203A0 File Offset: 0x0001E5A0
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_22_0.NativeStructWrapper.qnOVQwoMQbpovnSJUT4(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 6);
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
							NativeClassStructHandler_22_0.NativeStructWrapper.VVXCddo3V3Fcfc50sLa(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_89e7beae9a774fb691cacbb26b1d9330 != 0)
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

			// Token: 0x17000279 RID: 633
			// (get) Token: 0x06000856 RID: 2134 RVA: 0x00020404 File Offset: 0x0001E604
			// (set) Token: 0x06000857 RID: 2135 RVA: 0x0002041C File Offset: 0x0001E61C
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_22_0.NativeStructWrapper.qnOVQwoMQbpovnSJUT4(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_22_0.NativeStructWrapper.VVXCddo3V3Fcfc50sLa(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8155e7a9a9bd4894b741e1951a0eace6 == 0)
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

			// Token: 0x1700027A RID: 634
			// (get) Token: 0x06000858 RID: 2136 RVA: 0x00020480 File Offset: 0x0001E680
			// (set) Token: 0x06000859 RID: 2137 RVA: 0x00020498 File Offset: 0x0001E698
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_22_0.NativeStructWrapper.qnOVQwoMQbpovnSJUT4(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 11);
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
							this.SetBit(NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 11, value);
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

			// Token: 0x1700027B RID: 635
			// (get) Token: 0x0600085A RID: 2138 RVA: 0x00020500 File Offset: 0x0001E700
			// (set) Token: 0x0600085B RID: 2139 RVA: 0x0002050C File Offset: 0x0001E70C
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

			// Token: 0x0600085C RID: 2140 RVA: 0x00020518 File Offset: 0x0001E718
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
						default:
							NativeClassStructHandler_22_0.NativeStructWrapper.Lq2qNconlx8SHW3fBcp();
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_48b9993e573d4d08a64ac27c515a32b9 != 0)
							{
								num2 = 2;
							}
							break;
						case 1:
						{
							IntPtr intPtr;
							NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
							num2 = 5;
							break;
						}
						case 2:
						{
							IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_22_0.Il2CppClass_22_0>(NativeClassStructHandler_22_0.NativeStructWrapper.cXqfCBo4d73lAEaCSIq(81407119 ^ 819357190 ^ 267774430 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c4640bbaac7c4988b56f91d1b6b3f1a9));
							num2 = 1;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8155e7a9a9bd4894b741e1951a0eace6 == 0)
							{
								num2 = 0;
							}
							break;
						}
						case 3:
							NativeClassStructHandler_22_0.NativeStructWrapper.bVss8Ao5KLNlU5NSfDP();
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_49c6a53db2614593b5468905d8aba004 != 0)
							{
								num2 = 0;
							}
							break;
						case 4:
							goto IL_C2;
						case 5:
							return;
						}
					}
					IL_C2:
					NativeClassStructHandler_22_0.NativeStructWrapper.iInSrLopBpHkDNCD4qJ();
					num = 3;
				}
			}

			// Token: 0x0600085D RID: 2141 RVA: 0x00020620 File Offset: 0x0001E820
			internal static void bVss8Ao5KLNlU5NSfDP()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600085E RID: 2142 RVA: 0x00020630 File Offset: 0x0001E830
			internal static void Lq2qNconlx8SHW3fBcp()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x0600085F RID: 2143 RVA: 0x00020640 File Offset: 0x0001E840
			internal static bool JTDHwQoFr9ZOju3nLQJ()
			{
				return NativeClassStructHandler_22_0.NativeStructWrapper.gb6R9doTAKrE2ph8Hw8 == null;
			}

			// Token: 0x06000860 RID: 2144 RVA: 0x00020654 File Offset: 0x0001E854
			internal static NativeClassStructHandler_22_0.NativeStructWrapper zjF9JYoKAsJwteafZLc()
			{
				return NativeClassStructHandler_22_0.NativeStructWrapper.gb6R9doTAKrE2ph8Hw8;
			}

			// Token: 0x06000861 RID: 2145 RVA: 0x00020664 File Offset: 0x0001E864
			internal static void VVXCddo3V3Fcfc50sLa(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000862 RID: 2146 RVA: 0x00020684 File Offset: 0x0001E884
			internal static IntPtr yuccs7o1GX7P1yeVdeb(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x06000863 RID: 2147 RVA: 0x000206A0 File Offset: 0x0001E8A0
			internal static bool qnOVQwoMQbpovnSJUT4(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000864 RID: 2148 RVA: 0x000206BC File Offset: 0x0001E8BC
			internal static void iInSrLopBpHkDNCD4qJ()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000865 RID: 2149 RVA: 0x000206CC File Offset: 0x0001E8CC
			internal static object cXqfCBo4d73lAEaCSIq(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x040004CD RID: 1229
			private static readonly int _bitfield0offset;

			// Token: 0x040004CE RID: 1230
			private unsafe Il2CppClass* _klassDummy;

			// Token: 0x040004D0 RID: 1232
			internal static object gb6R9doTAKrE2ph8Hw8;
		}
	}
}
