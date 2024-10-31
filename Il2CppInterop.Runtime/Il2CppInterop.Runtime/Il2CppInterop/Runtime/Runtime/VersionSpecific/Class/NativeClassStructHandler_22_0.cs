using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000CF RID: 207
	[ApplicableToUnityVersionsSince("5.5.0")]
	public class NativeClassStructHandler_22_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000805 RID: 2053 RVA: 0x00010CFC File Offset: 0x0000EEFC
		public int Size()
		{
			return sizeof(NativeClassStructHandler_22_0.Il2CppClass_22_0);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00010D0C File Offset: 0x0000EF0C
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_22_0.Il2CppClass_22_0* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_22_0.pTaJWf6GvrynyL3EHWl(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_22_0.Il2CppClass_22_0);
			ptr2->byval_arg = UnityVersionHandler.NewType().TypePointer;
			ptr2->this_arg = ((INativeTypeStruct)NativeClassStructHandler_22_0.Yw56lN6riFYpWePCqe6()).TypePointer;
			return new NativeClassStructHandler_22_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00010D68 File Offset: 0x0000EF68
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bac7568f2bc04130b6b980225b2cc409 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeClassStructHandler_22_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		public NativeClassStructHandler_22_0()
		{
			NativeClassStructHandler_22_0.TV3iBt6TvA9kh49JMO8();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_dd9c757bd882429784d62f0e80f112e6 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00010E34 File Offset: 0x0000F034
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_22_0()
		{
			NativeClassStructHandler_22_0.rZ7cmO6grYSTtgnDt8E();
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00010E44 File Offset: 0x0000F044
		internal static IntPtr pTaJWf6GvrynyL3EHWl(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00010E58 File Offset: 0x0000F058
		internal static object Yw56lN6riFYpWePCqe6()
		{
			return UnityVersionHandler.NewType();
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00010E68 File Offset: 0x0000F068
		internal static bool jDyaCR6EOFG1AAHY4st()
		{
			return NativeClassStructHandler_22_0.Uh5Daj6wPZN3oUBuuCv == null;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00010E7C File Offset: 0x0000F07C
		internal static NativeClassStructHandler_22_0 k1fS8W6B810fEaY3RKl()
		{
			return NativeClassStructHandler_22_0.Uh5Daj6wPZN3oUBuuCv;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00010E8C File Offset: 0x0000F08C
		internal static void TV3iBt6TvA9kh49JMO8()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00010E9C File Offset: 0x0000F09C
		internal static void rZ7cmO6grYSTtgnDt8E()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000477 RID: 1143
		private static NativeClassStructHandler_22_0 Uh5Daj6wPZN3oUBuuCv;

		// Token: 0x020000D0 RID: 208
		internal struct Il2CppClass_22_0
		{
			// Token: 0x04000478 RID: 1144
			public unsafe Il2CppImage* image;

			// Token: 0x04000479 RID: 1145
			public unsafe void* gc_desc;

			// Token: 0x0400047A RID: 1146
			public unsafe byte* name;

			// Token: 0x0400047B RID: 1147
			public unsafe byte* namespaze;

			// Token: 0x0400047C RID: 1148
			public unsafe Il2CppTypeStruct* byval_arg;

			// Token: 0x0400047D RID: 1149
			public unsafe Il2CppTypeStruct* this_arg;

			// Token: 0x0400047E RID: 1150
			public unsafe Il2CppClass* element_class;

			// Token: 0x0400047F RID: 1151
			public unsafe Il2CppClass* castClass;

			// Token: 0x04000480 RID: 1152
			public unsafe Il2CppClass* declaringType;

			// Token: 0x04000481 RID: 1153
			public unsafe Il2CppClass* parent;

			// Token: 0x04000482 RID: 1154
			public unsafe void* generic_class;

			// Token: 0x04000483 RID: 1155
			public unsafe void* typeDefinition;

			// Token: 0x04000484 RID: 1156
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x04000485 RID: 1157
			public unsafe Il2CppEventInfo* events;

			// Token: 0x04000486 RID: 1158
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000487 RID: 1159
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x04000488 RID: 1160
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000489 RID: 1161
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x0400048A RID: 1162
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x0400048B RID: 1163
			public unsafe void* static_fields;

			// Token: 0x0400048C RID: 1164
			public unsafe void* rgctx_data;

			// Token: 0x0400048D RID: 1165
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x0400048E RID: 1166
			public uint cctor_started;

			// Token: 0x0400048F RID: 1167
			public uint cctor_finished;

			// Token: 0x04000490 RID: 1168
			public ulong cctor_thread;

			// Token: 0x04000491 RID: 1169
			public int genericContainerIndex;

			// Token: 0x04000492 RID: 1170
			public int customAttributeIndex;

			// Token: 0x04000493 RID: 1171
			public uint instance_size;

			// Token: 0x04000494 RID: 1172
			public uint actualSize;

			// Token: 0x04000495 RID: 1173
			public uint element_size;

			// Token: 0x04000496 RID: 1174
			public int native_size;

			// Token: 0x04000497 RID: 1175
			public uint static_fields_size;

			// Token: 0x04000498 RID: 1176
			public uint thread_static_fields_size;

			// Token: 0x04000499 RID: 1177
			public int thread_static_fields_offset;

			// Token: 0x0400049A RID: 1178
			public uint flags;

			// Token: 0x0400049B RID: 1179
			public uint token;

			// Token: 0x0400049C RID: 1180
			public ushort method_count;

			// Token: 0x0400049D RID: 1181
			public ushort property_count;

			// Token: 0x0400049E RID: 1182
			public ushort field_count;

			// Token: 0x0400049F RID: 1183
			public ushort event_count;

			// Token: 0x040004A0 RID: 1184
			public ushort nested_type_count;

			// Token: 0x040004A1 RID: 1185
			public ushort vtable_count;

			// Token: 0x040004A2 RID: 1186
			public ushort interfaces_count;

			// Token: 0x040004A3 RID: 1187
			public ushort interface_offsets_count;

			// Token: 0x040004A4 RID: 1188
			public byte typeHierarchyDepth;

			// Token: 0x040004A5 RID: 1189
			public byte rank;

			// Token: 0x040004A6 RID: 1190
			public byte minimumAlignment;

			// Token: 0x040004A7 RID: 1191
			public byte packingSize;

			// Token: 0x040004A8 RID: 1192
			public NativeClassStructHandler_22_0.Il2CppClass_22_0.Bitfield0 _bitfield0;

			// Token: 0x020000D1 RID: 209
			internal enum Bitfield0 : ushort
			{
				// Token: 0x040004AA RID: 1194
				BIT_valuetype,
				// Token: 0x040004AB RID: 1195
				valuetype,
				// Token: 0x040004AC RID: 1196
				BIT_initialized = 1,
				// Token: 0x040004AD RID: 1197
				initialized,
				// Token: 0x040004AE RID: 1198
				BIT_enumtype = 2,
				// Token: 0x040004AF RID: 1199
				enumtype = 4,
				// Token: 0x040004B0 RID: 1200
				BIT_is_generic = 3,
				// Token: 0x040004B1 RID: 1201
				is_generic = 8,
				// Token: 0x040004B2 RID: 1202
				BIT_has_references = 4,
				// Token: 0x040004B3 RID: 1203
				has_references = 16,
				// Token: 0x040004B4 RID: 1204
				BIT_init_pending = 5,
				// Token: 0x040004B5 RID: 1205
				init_pending = 32,
				// Token: 0x040004B6 RID: 1206
				BIT_size_inited = 6,
				// Token: 0x040004B7 RID: 1207
				size_inited = 64,
				// Token: 0x040004B8 RID: 1208
				BIT_has_finalize = 7,
				// Token: 0x040004B9 RID: 1209
				has_finalize = 128,
				// Token: 0x040004BA RID: 1210
				BIT_has_cctor = 8,
				// Token: 0x040004BB RID: 1211
				has_cctor = 256,
				// Token: 0x040004BC RID: 1212
				BIT_is_blittable = 9,
				// Token: 0x040004BD RID: 1213
				is_blittable = 512,
				// Token: 0x040004BE RID: 1214
				BIT_is_import_or_windows_runtime = 10,
				// Token: 0x040004BF RID: 1215
				is_import_or_windows_runtime = 1024,
				// Token: 0x040004C0 RID: 1216
				BIT_is_vtable_initialized = 11,
				// Token: 0x040004C1 RID: 1217
				is_vtable_initialized = 2048
			}
		}

		// Token: 0x020000D2 RID: 210
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000810 RID: 2064 RVA: 0x0001F240 File Offset: 0x0001D440
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8160363759e64728b1ce193157380515 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ff3063f9530e4a429cd27a548ab9d19d != 0)
						{
							num = 0;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x17000256 RID: 598
			// (get) Token: 0x06000811 RID: 2065 RVA: 0x0001F2D0 File Offset: 0x0001D4D0
			private unsafe NativeClassStructHandler_22_0.Il2CppClass_22_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000257 RID: 599
			// (get) Token: 0x06000812 RID: 2066 RVA: 0x0001F2E0 File Offset: 0x0001D4E0
			// (set) Token: 0x06000813 RID: 2067 RVA: 0x0001F2F8 File Offset: 0x0001D4F8
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_22_0.NativeStructWrapper.KAAvSDmu4GXGH5YELDx(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 4);
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
							this.SetBit(NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 4, value);
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

			// Token: 0x17000258 RID: 600
			// (get) Token: 0x06000814 RID: 2068 RVA: 0x0001F35C File Offset: 0x0001D55C
			public IntPtr Pointer { get; }

			// Token: 0x17000259 RID: 601
			// (get) Token: 0x06000815 RID: 2069 RVA: 0x0001F36C File Offset: 0x0001D56C
			public IntPtr VTable
			{
				get
				{
					return apS1BFcfBa3gXUspL9j.muOq5LWqgj(this.Pointer, sizeof(NativeClassStructHandler_22_0.Il2CppClass_22_0), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x1700025A RID: 602
			// (get) Token: 0x06000816 RID: 2070 RVA: 0x0001F38C File Offset: 0x0001D58C
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700025B RID: 603
			// (get) Token: 0x06000817 RID: 2071 RVA: 0x0001F39C File Offset: 0x0001D59C
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->byval_arg);
				}
			}

			// Token: 0x1700025C RID: 604
			// (get) Token: 0x06000818 RID: 2072 RVA: 0x0001F3B8 File Offset: 0x0001D5B8
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->this_arg);
				}
			}

			// Token: 0x1700025D RID: 605
			// (get) Token: 0x06000819 RID: 2073 RVA: 0x0001F3D4 File Offset: 0x0001D5D4
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x1700025E RID: 606
			// (get) Token: 0x0600081A RID: 2074 RVA: 0x0001F3E8 File Offset: 0x0001D5E8
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x1700025F RID: 607
			// (get) Token: 0x0600081B RID: 2075 RVA: 0x0001F3FC File Offset: 0x0001D5FC
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x17000260 RID: 608
			// (get) Token: 0x0600081C RID: 2076 RVA: 0x0001F410 File Offset: 0x0001D610
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x17000261 RID: 609
			// (get) Token: 0x0600081D RID: 2077 RVA: 0x0001F424 File Offset: 0x0001D624
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x17000262 RID: 610
			// (get) Token: 0x0600081E RID: 2078 RVA: 0x0001F438 File Offset: 0x0001D638
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x17000263 RID: 611
			// (get) Token: 0x0600081F RID: 2079 RVA: 0x0001F44C File Offset: 0x0001D64C
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x17000264 RID: 612
			// (get) Token: 0x06000820 RID: 2080 RVA: 0x0001F460 File Offset: 0x0001D660
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x17000265 RID: 613
			// (get) Token: 0x06000821 RID: 2081 RVA: 0x0001F474 File Offset: 0x0001D674
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x17000266 RID: 614
			// (get) Token: 0x06000822 RID: 2082 RVA: 0x0001F488 File Offset: 0x0001D688
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x17000267 RID: 615
			// (get) Token: 0x06000823 RID: 2083 RVA: 0x0001F4A0 File Offset: 0x0001D6A0
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000268 RID: 616
			// (get) Token: 0x06000824 RID: 2084 RVA: 0x0001F4B8 File Offset: 0x0001D6B8
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x17000269 RID: 617
			// (get) Token: 0x06000825 RID: 2085 RVA: 0x0001F4D0 File Offset: 0x0001D6D0
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x1700026A RID: 618
			// (get) Token: 0x06000826 RID: 2086 RVA: 0x0001F4E4 File Offset: 0x0001D6E4
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700026B RID: 619
			// (get) Token: 0x06000827 RID: 2087 RVA: 0x0001F4F8 File Offset: 0x0001D6F8
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x1700026C RID: 620
			// (get) Token: 0x06000828 RID: 2088 RVA: 0x0001F50C File Offset: 0x0001D70C
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x1700026D RID: 621
			// (get) Token: 0x06000829 RID: 2089 RVA: 0x0001F520 File Offset: 0x0001D720
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x1700026E RID: 622
			// (get) Token: 0x0600082A RID: 2090 RVA: 0x0001F534 File Offset: 0x0001D734
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._klassDummy;
				}
			}

			// Token: 0x1700026F RID: 623
			// (get) Token: 0x0600082B RID: 2091 RVA: 0x0001F544 File Offset: 0x0001D744
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x17000270 RID: 624
			// (get) Token: 0x0600082C RID: 2092 RVA: 0x0001F558 File Offset: 0x0001D758
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x17000271 RID: 625
			// (get) Token: 0x0600082D RID: 2093 RVA: 0x0001F56C File Offset: 0x0001D76C
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x17000272 RID: 626
			// (get) Token: 0x0600082E RID: 2094 RVA: 0x0001F580 File Offset: 0x0001D780
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x17000273 RID: 627
			// (get) Token: 0x0600082F RID: 2095 RVA: 0x0001F594 File Offset: 0x0001D794
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x17000274 RID: 628
			// (get) Token: 0x06000830 RID: 2096 RVA: 0x0001F5A8 File Offset: 0x0001D7A8
			// (set) Token: 0x06000831 RID: 2097 RVA: 0x0001F5C0 File Offset: 0x0001D7C0
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_22_0.NativeStructWrapper.KAAvSDmu4GXGH5YELDx(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_22_0.NativeStructWrapper.Yv8IsImDY51qDGgkYQV(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_22f9ae9a49f143d7bbb3b03eb2446c0f != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000275 RID: 629
			// (get) Token: 0x06000832 RID: 2098 RVA: 0x0001F624 File Offset: 0x0001D824
			// (set) Token: 0x06000833 RID: 2099 RVA: 0x0001F63C File Offset: 0x0001D83C
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_22_0.NativeStructWrapper.KAAvSDmu4GXGH5YELDx(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_22_0.NativeStructWrapper.Yv8IsImDY51qDGgkYQV(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b82ae23c6544f3a11e54f2fed3ad25 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000276 RID: 630
			// (get) Token: 0x06000834 RID: 2100 RVA: 0x0001F6A0 File Offset: 0x0001D8A0
			// (set) Token: 0x06000835 RID: 2101 RVA: 0x0001F6B8 File Offset: 0x0001D8B8
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_22_0.NativeStructWrapper.KAAvSDmu4GXGH5YELDx(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_22_0.NativeStructWrapper.Yv8IsImDY51qDGgkYQV(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_11d7514559f14fcba52669ac71e3cb39 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000277 RID: 631
			// (get) Token: 0x06000836 RID: 2102 RVA: 0x0001F71C File Offset: 0x0001D91C
			// (set) Token: 0x06000837 RID: 2103 RVA: 0x0001F734 File Offset: 0x0001D934
			public bool IsGeneric
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_22_0.NativeStructWrapper.Yv8IsImDY51qDGgkYQV(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_9f61d52c010d488b818a577e37d289c0 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000278 RID: 632
			// (get) Token: 0x06000838 RID: 2104 RVA: 0x0001F798 File Offset: 0x0001D998
			// (set) Token: 0x06000839 RID: 2105 RVA: 0x0001F7B0 File Offset: 0x0001D9B0
			public bool SizeInited
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 6);
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
							this.SetBit(NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_45f0db95dace45b6a0257ae80a3038eb != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000279 RID: 633
			// (get) Token: 0x0600083A RID: 2106 RVA: 0x0001F814 File Offset: 0x0001DA14
			// (set) Token: 0x0600083B RID: 2107 RVA: 0x0001F82C File Offset: 0x0001DA2C
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_22_0.NativeStructWrapper.KAAvSDmu4GXGH5YELDx(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_22_0.NativeStructWrapper.Yv8IsImDY51qDGgkYQV(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b544c260d8647ebad150746ba137290 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700027A RID: 634
			// (get) Token: 0x0600083C RID: 2108 RVA: 0x0001F890 File Offset: 0x0001DA90
			// (set) Token: 0x0600083D RID: 2109 RVA: 0x0001F8A8 File Offset: 0x0001DAA8
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_22_0.NativeStructWrapper.KAAvSDmu4GXGH5YELDx(this, NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 11);
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
							this.SetBit(NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset, 11, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7b01772eb8964b6a81d74c3d1c2f871e == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700027B RID: 635
			// (get) Token: 0x0600083E RID: 2110 RVA: 0x0001F910 File Offset: 0x0001DB10
			// (set) Token: 0x0600083F RID: 2111 RVA: 0x0001F91C File Offset: 0x0001DB1C
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

			// Token: 0x06000840 RID: 2112 RVA: 0x0001F928 File Offset: 0x0001DB28
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				int num = 5;
				int num2 = num;
				for (;;)
				{
					IntPtr intPtr;
					switch (num2)
					{
					case 1:
						NativeClassStructHandler_22_0.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 2;
						continue;
					case 2:
						return;
					case 3:
						NativeClassStructHandler_22_0.NativeStructWrapper.Dd5ipamPm2wnhqwBr52();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_da5aa2d475094b06a3df3cc53bc85956 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						NativeClassStructHandler_22_0.NativeStructWrapper.Thrkdlm7vYAY2ROyGH6();
						num2 = 3;
						continue;
					case 5:
						NativeClassStructHandler_22_0.NativeStructWrapper.G2xRRemmtopy8ifFs8N();
						num2 = 4;
						continue;
					}
					intPtr = Marshal.OffsetOf<NativeClassStructHandler_22_0.Il2CppClass_22_0>(NativeClassStructHandler_22_0.NativeStructWrapper.msQon8m4w2iIOsxIQjp(-226554387 ^ -467044642 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b329e831708e4d29ae561982d3d8c1c1));
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b169d8ea412f45e99e430384ddc8908b != 0)
					{
						num2 = 1;
					}
				}
			}

			// Token: 0x06000841 RID: 2113 RVA: 0x0001FA10 File Offset: 0x0001DC10
			internal static bool e6RS63mSgwe6XJZJNjE()
			{
				return NativeClassStructHandler_22_0.NativeStructWrapper.zgecYTmsJW1J9Ux8si6 == null;
			}

			// Token: 0x06000842 RID: 2114 RVA: 0x0001FA24 File Offset: 0x0001DC24
			internal static NativeClassStructHandler_22_0.NativeStructWrapper OEb3C4mN8KGHAFiKgt1()
			{
				return NativeClassStructHandler_22_0.NativeStructWrapper.zgecYTmsJW1J9Ux8si6;
			}

			// Token: 0x06000843 RID: 2115 RVA: 0x0001FA34 File Offset: 0x0001DC34
			internal static bool KAAvSDmu4GXGH5YELDx(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000844 RID: 2116 RVA: 0x0001FA50 File Offset: 0x0001DC50
			internal static void Yv8IsImDY51qDGgkYQV(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000845 RID: 2117 RVA: 0x0001FA70 File Offset: 0x0001DC70
			internal static void G2xRRemmtopy8ifFs8N()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000846 RID: 2118 RVA: 0x0001FA80 File Offset: 0x0001DC80
			internal static void Thrkdlm7vYAY2ROyGH6()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000847 RID: 2119 RVA: 0x0001FA90 File Offset: 0x0001DC90
			internal static void Dd5ipamPm2wnhqwBr52()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000848 RID: 2120 RVA: 0x0001FAA0 File Offset: 0x0001DCA0
			internal static object msQon8m4w2iIOsxIQjp(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x040004C2 RID: 1218
			private static readonly int _bitfield0offset;

			// Token: 0x040004C3 RID: 1219
			private unsafe Il2CppClass* _klassDummy;

			// Token: 0x040004C5 RID: 1221
			internal static object zgecYTmsJW1J9Ux8si6;
		}
	}
}
