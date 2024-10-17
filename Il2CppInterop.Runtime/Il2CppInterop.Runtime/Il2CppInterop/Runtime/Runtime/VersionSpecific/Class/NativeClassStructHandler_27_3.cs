using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000FD RID: 253
	[ApplicableToUnityVersionsSince("2021.1.24")]
	public class NativeClassStructHandler_27_3 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000B10 RID: 2832 RVA: 0x00012A20 File Offset: 0x00010C20
		public int Size()
		{
			return sizeof(NativeClassStructHandler_27_3.Il2CppClass_27_3);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00012A30 File Offset: 0x00010C30
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_27_3.Il2CppClass_27_3* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_27_3.RWIg4dLuGuhLKCKZ49T(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_27_3.Il2CppClass_27_3);
			return new NativeClassStructHandler_27_3.NativeStructWrapper(ptr);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00012A68 File Offset: 0x00010C68
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b15bb2810b414d8fba6ffddaf7154f62 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeClassStructHandler_27_3.NativeStructWrapper(ptr);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00012AD0 File Offset: 0x00010CD0
		public NativeClassStructHandler_27_3()
		{
			NativeClassStructHandler_27_3.KEIkVNLEY1Hpxcg5nEi();
			NativeClassStructHandler_27_3.btbekxLcPH1fh77FxQe();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_906545e343eb409d9eb685fc4a903234 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00012B34 File Offset: 0x00010D34
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_27_3()
		{
			NativeClassStructHandler_27_3.iPiOctL6mnf7D07E7c5();
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00012B44 File Offset: 0x00010D44
		internal static IntPtr RWIg4dLuGuhLKCKZ49T(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00012B58 File Offset: 0x00010D58
		internal static bool ELan8ML0FfcNYuf9sxE()
		{
			return NativeClassStructHandler_27_3.BMNhmnL8rxawf9q7JVZ == null;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00012B6C File Offset: 0x00010D6C
		internal static NativeClassStructHandler_27_3 MFw6FMLN0YGPFW8Lbi7()
		{
			return NativeClassStructHandler_27_3.BMNhmnL8rxawf9q7JVZ;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00012B7C File Offset: 0x00010D7C
		internal static void KEIkVNLEY1Hpxcg5nEi()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00012B8C File Offset: 0x00010D8C
		internal static void btbekxLcPH1fh77FxQe()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00012B9C File Offset: 0x00010D9C
		internal static void iPiOctL6mnf7D07E7c5()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400081E RID: 2078
		private static NativeClassStructHandler_27_3 BMNhmnL8rxawf9q7JVZ;

		// Token: 0x020000FE RID: 254
		internal struct Il2CppClass_27_3
		{
			// Token: 0x0400081F RID: 2079
			public unsafe Il2CppImage* image;

			// Token: 0x04000820 RID: 2080
			public unsafe void* gc_desc;

			// Token: 0x04000821 RID: 2081
			public unsafe byte* name;

			// Token: 0x04000822 RID: 2082
			public unsafe byte* namespaze;

			// Token: 0x04000823 RID: 2083
			public NativeTypeStructHandler_27_0.Il2CppType_27_0 byval_arg;

			// Token: 0x04000824 RID: 2084
			public NativeTypeStructHandler_27_0.Il2CppType_27_0 this_arg;

			// Token: 0x04000825 RID: 2085
			public unsafe Il2CppClass* element_class;

			// Token: 0x04000826 RID: 2086
			public unsafe Il2CppClass* castClass;

			// Token: 0x04000827 RID: 2087
			public unsafe Il2CppClass* declaringType;

			// Token: 0x04000828 RID: 2088
			public unsafe Il2CppClass* parent;

			// Token: 0x04000829 RID: 2089
			public unsafe void* generic_class;

			// Token: 0x0400082A RID: 2090
			public Il2CppMetadataTypeHandle typeMetadataHandle;

			// Token: 0x0400082B RID: 2091
			public unsafe void* interopData;

			// Token: 0x0400082C RID: 2092
			public unsafe Il2CppClass* klass;

			// Token: 0x0400082D RID: 2093
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x0400082E RID: 2094
			public unsafe Il2CppEventInfo* events;

			// Token: 0x0400082F RID: 2095
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x04000830 RID: 2096
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x04000831 RID: 2097
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x04000832 RID: 2098
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x04000833 RID: 2099
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x04000834 RID: 2100
			public unsafe void* static_fields;

			// Token: 0x04000835 RID: 2101
			public unsafe void* rgctx_data;

			// Token: 0x04000836 RID: 2102
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x04000837 RID: 2103
			public unsafe void* unity_user_data;

			// Token: 0x04000838 RID: 2104
			public uint initializationExceptionGCHandle;

			// Token: 0x04000839 RID: 2105
			public uint cctor_started;

			// Token: 0x0400083A RID: 2106
			public uint cctor_finished;

			// Token: 0x0400083B RID: 2107
			public IntPtr cctor_thread;

			// Token: 0x0400083C RID: 2108
			public Il2CppMetadataGenericContainerHandle genericContainerHandle;

			// Token: 0x0400083D RID: 2109
			public uint instance_size;

			// Token: 0x0400083E RID: 2110
			public uint actualSize;

			// Token: 0x0400083F RID: 2111
			public uint element_size;

			// Token: 0x04000840 RID: 2112
			public int native_size;

			// Token: 0x04000841 RID: 2113
			public uint static_fields_size;

			// Token: 0x04000842 RID: 2114
			public uint thread_static_fields_size;

			// Token: 0x04000843 RID: 2115
			public int thread_static_fields_offset;

			// Token: 0x04000844 RID: 2116
			public uint flags;

			// Token: 0x04000845 RID: 2117
			public uint token;

			// Token: 0x04000846 RID: 2118
			public ushort method_count;

			// Token: 0x04000847 RID: 2119
			public ushort property_count;

			// Token: 0x04000848 RID: 2120
			public ushort field_count;

			// Token: 0x04000849 RID: 2121
			public ushort event_count;

			// Token: 0x0400084A RID: 2122
			public ushort nested_type_count;

			// Token: 0x0400084B RID: 2123
			public ushort vtable_count;

			// Token: 0x0400084C RID: 2124
			public ushort interfaces_count;

			// Token: 0x0400084D RID: 2125
			public ushort interface_offsets_count;

			// Token: 0x0400084E RID: 2126
			public byte typeHierarchyDepth;

			// Token: 0x0400084F RID: 2127
			public byte genericRecursionDepth;

			// Token: 0x04000850 RID: 2128
			public byte rank;

			// Token: 0x04000851 RID: 2129
			public byte minimumAlignment;

			// Token: 0x04000852 RID: 2130
			public byte naturalAligment;

			// Token: 0x04000853 RID: 2131
			public byte packingSize;

			// Token: 0x04000854 RID: 2132
			public NativeClassStructHandler_27_3.Il2CppClass_27_3.Bitfield0 _bitfield0;

			// Token: 0x020000FF RID: 255
			internal enum Bitfield0 : ushort
			{
				// Token: 0x04000856 RID: 2134
				BIT_initialized_and_no_error,
				// Token: 0x04000857 RID: 2135
				initialized_and_no_error,
				// Token: 0x04000858 RID: 2136
				BIT_initialized = 1,
				// Token: 0x04000859 RID: 2137
				initialized,
				// Token: 0x0400085A RID: 2138
				BIT_enumtype = 2,
				// Token: 0x0400085B RID: 2139
				enumtype = 4,
				// Token: 0x0400085C RID: 2140
				BIT_is_generic = 3,
				// Token: 0x0400085D RID: 2141
				is_generic = 8,
				// Token: 0x0400085E RID: 2142
				BIT_has_references = 4,
				// Token: 0x0400085F RID: 2143
				has_references = 16,
				// Token: 0x04000860 RID: 2144
				BIT_init_pending = 5,
				// Token: 0x04000861 RID: 2145
				init_pending = 32,
				// Token: 0x04000862 RID: 2146
				BIT_size_init_pending = 6,
				// Token: 0x04000863 RID: 2147
				size_init_pending = 64,
				// Token: 0x04000864 RID: 2148
				BIT_size_inited = 7,
				// Token: 0x04000865 RID: 2149
				size_inited = 128,
				// Token: 0x04000866 RID: 2150
				BIT_has_finalize = 8,
				// Token: 0x04000867 RID: 2151
				has_finalize = 256,
				// Token: 0x04000868 RID: 2152
				BIT_has_cctor = 9,
				// Token: 0x04000869 RID: 2153
				has_cctor = 512,
				// Token: 0x0400086A RID: 2154
				BIT_is_blittable = 10,
				// Token: 0x0400086B RID: 2155
				is_blittable = 1024,
				// Token: 0x0400086C RID: 2156
				BIT_is_import_or_windows_runtime = 11,
				// Token: 0x0400086D RID: 2157
				is_import_or_windows_runtime = 2048,
				// Token: 0x0400086E RID: 2158
				BIT_is_vtable_initialized = 12,
				// Token: 0x0400086F RID: 2159
				is_vtable_initialized = 4096,
				// Token: 0x04000870 RID: 2160
				BIT_has_initialization_error = 13,
				// Token: 0x04000871 RID: 2161
				has_initialization_error = 8192
			}
		}

		// Token: 0x02000100 RID: 256
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000B1B RID: 2843 RVA: 0x00025FE8 File Offset: 0x000241E8
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeClassStructHandler_27_3.NativeStructWrapper.KImTPNPY9OWh6y7PUbN();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3bc6c4fc6422441e99d3c51c51f46d12 == 0)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_806dbdb7f5194c2fa0c07a915df13fc8 == 0)
					{
						num = 1;
					}
				}
			}

			// Token: 0x170003F8 RID: 1016
			// (get) Token: 0x06000B1C RID: 2844 RVA: 0x00026078 File Offset: 0x00024278
			private unsafe NativeClassStructHandler_27_3.Il2CppClass_27_3* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170003F9 RID: 1017
			// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00026088 File Offset: 0x00024288
			// (set) Token: 0x06000B1E RID: 2846 RVA: 0x000260A0 File Offset: 0x000242A0
			public bool HasReferences
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_27_3.NativeStructWrapper.fPVludPad6SPpixp8L5(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e0435cb0909b493e882d051900e9ae38 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003FA RID: 1018
			// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00026104 File Offset: 0x00024304
			public IntPtr Pointer { get; }

			// Token: 0x170003FB RID: 1019
			// (get) Token: 0x06000B20 RID: 2848 RVA: 0x00026114 File Offset: 0x00024314
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_27_3.NativeStructWrapper.FYxyn9PCNb1OhgSvLYc(this.Pointer, sizeof(NativeClassStructHandler_27_3.Il2CppClass_27_3), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x170003FC RID: 1020
			// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00026134 File Offset: 0x00024334
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170003FD RID: 1021
			// (get) Token: 0x06000B22 RID: 2850 RVA: 0x00026144 File Offset: 0x00024344
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x170003FE RID: 1022
			// (get) Token: 0x06000B23 RID: 2851 RVA: 0x00026160 File Offset: 0x00024360
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x170003FF RID: 1023
			// (get) Token: 0x06000B24 RID: 2852 RVA: 0x0002617C File Offset: 0x0002437C
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x17000400 RID: 1024
			// (get) Token: 0x06000B25 RID: 2853 RVA: 0x00026190 File Offset: 0x00024390
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x17000401 RID: 1025
			// (get) Token: 0x06000B26 RID: 2854 RVA: 0x000261A4 File Offset: 0x000243A4
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x17000402 RID: 1026
			// (get) Token: 0x06000B27 RID: 2855 RVA: 0x000261B8 File Offset: 0x000243B8
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x17000403 RID: 1027
			// (get) Token: 0x06000B28 RID: 2856 RVA: 0x000261CC File Offset: 0x000243CC
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x17000404 RID: 1028
			// (get) Token: 0x06000B29 RID: 2857 RVA: 0x000261E0 File Offset: 0x000243E0
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x17000405 RID: 1029
			// (get) Token: 0x06000B2A RID: 2858 RVA: 0x000261F4 File Offset: 0x000243F4
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x17000406 RID: 1030
			// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00026208 File Offset: 0x00024408
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x17000407 RID: 1031
			// (get) Token: 0x06000B2C RID: 2860 RVA: 0x0002621C File Offset: 0x0002441C
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x17000408 RID: 1032
			// (get) Token: 0x06000B2D RID: 2861 RVA: 0x00026230 File Offset: 0x00024430
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x17000409 RID: 1033
			// (get) Token: 0x06000B2E RID: 2862 RVA: 0x00026248 File Offset: 0x00024448
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700040A RID: 1034
			// (get) Token: 0x06000B2F RID: 2863 RVA: 0x00026260 File Offset: 0x00024460
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x1700040B RID: 1035
			// (get) Token: 0x06000B30 RID: 2864 RVA: 0x00026278 File Offset: 0x00024478
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x1700040C RID: 1036
			// (get) Token: 0x06000B31 RID: 2865 RVA: 0x0002628C File Offset: 0x0002448C
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700040D RID: 1037
			// (get) Token: 0x06000B32 RID: 2866 RVA: 0x000262A0 File Offset: 0x000244A0
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x1700040E RID: 1038
			// (get) Token: 0x06000B33 RID: 2867 RVA: 0x000262B4 File Offset: 0x000244B4
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x1700040F RID: 1039
			// (get) Token: 0x06000B34 RID: 2868 RVA: 0x000262C8 File Offset: 0x000244C8
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x17000410 RID: 1040
			// (get) Token: 0x06000B35 RID: 2869 RVA: 0x000262DC File Offset: 0x000244DC
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x17000411 RID: 1041
			// (get) Token: 0x06000B36 RID: 2870 RVA: 0x000262F0 File Offset: 0x000244F0
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x17000412 RID: 1042
			// (get) Token: 0x06000B37 RID: 2871 RVA: 0x00026304 File Offset: 0x00024504
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x17000413 RID: 1043
			// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00026318 File Offset: 0x00024518
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x17000414 RID: 1044
			// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0002632C File Offset: 0x0002452C
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x17000415 RID: 1045
			// (get) Token: 0x06000B3A RID: 2874 RVA: 0x00026340 File Offset: 0x00024540
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x17000416 RID: 1046
			// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00026354 File Offset: 0x00024554
			// (set) Token: 0x06000B3C RID: 2876 RVA: 0x000263F0 File Offset: 0x000245F0
			public bool ValueType
			{
				get
				{
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							if (NativeClassStructHandler_27_3.NativeStructWrapper.Vrpv08PtVEEnVy9x7qy(this.ByValArg))
							{
								goto IL_2F;
							}
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6926da1cf80047d3a6f0516668d22380 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							goto IL_2F;
						}
						break;
					}
					return false;
					IL_2F:
					return NativeClassStructHandler_27_3.NativeStructWrapper.Vrpv08PtVEEnVy9x7qy(this.ThisArg);
				}
				set
				{
				}
			}

			// Token: 0x17000417 RID: 1047
			// (get) Token: 0x06000B3D RID: 2877 RVA: 0x000263FC File Offset: 0x000245FC
			// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00026414 File Offset: 0x00024614
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_27_3.NativeStructWrapper.zKGooQPxOBaNCIihoSU(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_27_3.NativeStructWrapper.fPVludPad6SPpixp8L5(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_be54e2986e644667aed0d52d0affe157 == 0)
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

			// Token: 0x17000418 RID: 1048
			// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00026478 File Offset: 0x00024678
			// (set) Token: 0x06000B40 RID: 2880 RVA: 0x00026490 File Offset: 0x00024690
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_27_3.NativeStructWrapper.zKGooQPxOBaNCIihoSU(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_27_3.NativeStructWrapper.fPVludPad6SPpixp8L5(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c4640bbaac7c4988b56f91d1b6b3f1a9 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000419 RID: 1049
			// (get) Token: 0x06000B41 RID: 2881 RVA: 0x000264F4 File Offset: 0x000246F4
			// (set) Token: 0x06000B42 RID: 2882 RVA: 0x0002650C File Offset: 0x0002470C
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_27_3.NativeStructWrapper.zKGooQPxOBaNCIihoSU(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 3);
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
							this.SetBit(NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_75b92ac812f348208c578c3de71e2d57 == 0)
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

			// Token: 0x1700041A RID: 1050
			// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00026570 File Offset: 0x00024770
			// (set) Token: 0x06000B44 RID: 2884 RVA: 0x00026588 File Offset: 0x00024788
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_27_3.NativeStructWrapper.zKGooQPxOBaNCIihoSU(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_27_3.NativeStructWrapper.fPVludPad6SPpixp8L5(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_084a47a7baf94bf79b9c3fbf8d684053 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700041B RID: 1051
			// (get) Token: 0x06000B45 RID: 2885 RVA: 0x000265EC File Offset: 0x000247EC
			// (set) Token: 0x06000B46 RID: 2886 RVA: 0x00026604 File Offset: 0x00024804
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_27_3.NativeStructWrapper.zKGooQPxOBaNCIihoSU(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 8);
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
							NativeClassStructHandler_27_3.NativeStructWrapper.fPVludPad6SPpixp8L5(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 8, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2b9d7065e34e71a0069eb107f69f59 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700041C RID: 1052
			// (get) Token: 0x06000B47 RID: 2887 RVA: 0x00026668 File Offset: 0x00024868
			// (set) Token: 0x06000B48 RID: 2888 RVA: 0x00026680 File Offset: 0x00024880
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_27_3.NativeStructWrapper.zKGooQPxOBaNCIihoSU(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 12);
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
							NativeClassStructHandler_27_3.NativeStructWrapper.fPVludPad6SPpixp8L5(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 12, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_49c6a53db2614593b5468905d8aba004 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x1700041D RID: 1053
			// (get) Token: 0x06000B49 RID: 2889 RVA: 0x000266E8 File Offset: 0x000248E8
			// (set) Token: 0x06000B4A RID: 2890 RVA: 0x00026700 File Offset: 0x00024900
			public bool InitializedAndNoError
			{
				get
				{
					return NativeClassStructHandler_27_3.NativeStructWrapper.zKGooQPxOBaNCIihoSU(this, NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 0);
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
							this.SetBit(NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_22d16b8eb84d4725aef9f7a9d2f68925 != 0)
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

			// Token: 0x06000B4B RID: 2891 RVA: 0x00026764 File Offset: 0x00024964
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
						NativeClassStructHandler_27_3.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c32cfeb41f7a43999be3bae16a94ad02 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					case 2:
						NativeClassStructHandler_27_3.NativeStructWrapper.KImTPNPY9OWh6y7PUbN();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6e39fb1a8feb46889b60abcfbb34e0df == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 3:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_27_3.Il2CppClass_27_3>(hIDAYxH6DWLHIthQgC.gSCeTtiku(-2007369155 ^ -1026150301 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a36e967c0f044e9ebf523536bdec8e28));
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c1d51581d05f41579ee6e476d9be288e != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					case 4:
						hIDAYxH6DWLHIthQgC.oDuBOTgYK();
						num2 = 2;
						continue;
					case 5:
						NativeClassStructHandler_27_3.NativeStructWrapper.jxVgH0PhM34KSdhQitT();
						num2 = 2;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f7e83c7c87bd4de9b4cb2b7f339254ad != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x06000B4C RID: 2892 RVA: 0x00026874 File Offset: 0x00024A74
			internal static void KImTPNPY9OWh6y7PUbN()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000B4D RID: 2893 RVA: 0x00026884 File Offset: 0x00024A84
			internal static bool mtgZyvPIEaZvCaMJkTJ()
			{
				return NativeClassStructHandler_27_3.NativeStructWrapper.McOrQnPiK9D5EC1e5US == null;
			}

			// Token: 0x06000B4E RID: 2894 RVA: 0x00026898 File Offset: 0x00024A98
			internal static NativeClassStructHandler_27_3.NativeStructWrapper IMienxPGXg6Q7YwPXKN()
			{
				return NativeClassStructHandler_27_3.NativeStructWrapper.McOrQnPiK9D5EC1e5US;
			}

			// Token: 0x06000B4F RID: 2895 RVA: 0x000268A8 File Offset: 0x00024AA8
			internal static void fPVludPad6SPpixp8L5(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000B50 RID: 2896 RVA: 0x000268C8 File Offset: 0x00024AC8
			internal static IntPtr FYxyn9PCNb1OhgSvLYc(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x06000B51 RID: 2897 RVA: 0x000268E4 File Offset: 0x00024AE4
			internal static bool Vrpv08PtVEEnVy9x7qy(object A_0)
			{
				return ((INativeTypeStruct)A_0).ValueType;
			}

			// Token: 0x06000B52 RID: 2898 RVA: 0x000268F8 File Offset: 0x00024AF8
			internal static bool zKGooQPxOBaNCIihoSU(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000B53 RID: 2899 RVA: 0x00026914 File Offset: 0x00024B14
			internal static void jxVgH0PhM34KSdhQitT()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000872 RID: 2162
			private static readonly int _bitfield0offset;

			// Token: 0x04000874 RID: 2164
			internal static object McOrQnPiK9D5EC1e5US;
		}
	}
}
