using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000F7 RID: 247
	[ApplicableToUnityVersionsSince("2021.1.0")]
	public class NativeClassStructHandler_27_2 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000AA8 RID: 2728 RVA: 0x00011C68 File Offset: 0x0000FE68
		public int Size()
		{
			return sizeof(NativeClassStructHandler_27_2.Il2CppClass_27_2);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00011C78 File Offset: 0x0000FE78
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_27_2.Il2CppClass_27_2* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_27_2.IakwCoyrUpqsc5OOvaC(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_27_2.Il2CppClass_27_2);
			return new NativeClassStructHandler_27_2.NativeStructWrapper(ptr);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00011CB0 File Offset: 0x0000FEB0
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2ec67b9ff6c4cd7af2a4ceec32c111c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeClassStructHandler_27_2.NativeStructWrapper(ptr);
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00011D18 File Offset: 0x0000FF18
		public NativeClassStructHandler_27_2()
		{
			NativeClassStructHandler_27_2.QIRbIEyTvHCnKo6KHdw();
			NativeClassStructHandler_27_2.YOyeoZygwMjuFoLohA1();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b502855b254c47cfafcd30fd84ad7c96 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00011D7C File Offset: 0x0000FF7C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_27_2()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00011D8C File Offset: 0x0000FF8C
		internal static IntPtr IakwCoyrUpqsc5OOvaC(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00011DA0 File Offset: 0x0000FFA0
		internal static bool Pl10F3yBV4IgrC4vyAQ()
		{
			return NativeClassStructHandler_27_2.wfiLfSyEXWibUbh1VQQ == null;
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00011DB4 File Offset: 0x0000FFB4
		internal static NativeClassStructHandler_27_2 WSehwNyGgpfnqJri5gG()
		{
			return NativeClassStructHandler_27_2.wfiLfSyEXWibUbh1VQQ;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00011DC4 File Offset: 0x0000FFC4
		internal static void QIRbIEyTvHCnKo6KHdw()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00011DD4 File Offset: 0x0000FFD4
		internal static void YOyeoZygwMjuFoLohA1()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x040007BE RID: 1982
		private static NativeClassStructHandler_27_2 wfiLfSyEXWibUbh1VQQ;

		// Token: 0x020000F8 RID: 248
		internal struct Il2CppClass_27_2
		{
			// Token: 0x040007BF RID: 1983
			public unsafe Il2CppImage* image;

			// Token: 0x040007C0 RID: 1984
			public unsafe void* gc_desc;

			// Token: 0x040007C1 RID: 1985
			public unsafe byte* name;

			// Token: 0x040007C2 RID: 1986
			public unsafe byte* namespaze;

			// Token: 0x040007C3 RID: 1987
			public NativeTypeStructHandler_27_0.Il2CppType_27_0 byval_arg;

			// Token: 0x040007C4 RID: 1988
			public NativeTypeStructHandler_27_0.Il2CppType_27_0 this_arg;

			// Token: 0x040007C5 RID: 1989
			public unsafe Il2CppClass* element_class;

			// Token: 0x040007C6 RID: 1990
			public unsafe Il2CppClass* castClass;

			// Token: 0x040007C7 RID: 1991
			public unsafe Il2CppClass* declaringType;

			// Token: 0x040007C8 RID: 1992
			public unsafe Il2CppClass* parent;

			// Token: 0x040007C9 RID: 1993
			public unsafe void* generic_class;

			// Token: 0x040007CA RID: 1994
			public Il2CppMetadataTypeHandle typeMetadataHandle;

			// Token: 0x040007CB RID: 1995
			public unsafe void* interopData;

			// Token: 0x040007CC RID: 1996
			public unsafe Il2CppClass* klass;

			// Token: 0x040007CD RID: 1997
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x040007CE RID: 1998
			public unsafe Il2CppEventInfo* events;

			// Token: 0x040007CF RID: 1999
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x040007D0 RID: 2000
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x040007D1 RID: 2001
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x040007D2 RID: 2002
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x040007D3 RID: 2003
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x040007D4 RID: 2004
			public unsafe void* static_fields;

			// Token: 0x040007D5 RID: 2005
			public unsafe void* rgctx_data;

			// Token: 0x040007D6 RID: 2006
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x040007D7 RID: 2007
			public unsafe void* unity_user_data;

			// Token: 0x040007D8 RID: 2008
			public uint initializationExceptionGCHandle;

			// Token: 0x040007D9 RID: 2009
			public uint cctor_started;

			// Token: 0x040007DA RID: 2010
			public uint cctor_finished;

			// Token: 0x040007DB RID: 2011
			public IntPtr cctor_thread;

			// Token: 0x040007DC RID: 2012
			public Il2CppMetadataGenericContainerHandle genericContainerHandle;

			// Token: 0x040007DD RID: 2013
			public uint instance_size;

			// Token: 0x040007DE RID: 2014
			public uint actualSize;

			// Token: 0x040007DF RID: 2015
			public uint element_size;

			// Token: 0x040007E0 RID: 2016
			public int native_size;

			// Token: 0x040007E1 RID: 2017
			public uint static_fields_size;

			// Token: 0x040007E2 RID: 2018
			public uint thread_static_fields_size;

			// Token: 0x040007E3 RID: 2019
			public int thread_static_fields_offset;

			// Token: 0x040007E4 RID: 2020
			public uint flags;

			// Token: 0x040007E5 RID: 2021
			public uint token;

			// Token: 0x040007E6 RID: 2022
			public ushort method_count;

			// Token: 0x040007E7 RID: 2023
			public ushort property_count;

			// Token: 0x040007E8 RID: 2024
			public ushort field_count;

			// Token: 0x040007E9 RID: 2025
			public ushort event_count;

			// Token: 0x040007EA RID: 2026
			public ushort nested_type_count;

			// Token: 0x040007EB RID: 2027
			public ushort vtable_count;

			// Token: 0x040007EC RID: 2028
			public ushort interfaces_count;

			// Token: 0x040007ED RID: 2029
			public ushort interface_offsets_count;

			// Token: 0x040007EE RID: 2030
			public byte typeHierarchyDepth;

			// Token: 0x040007EF RID: 2031
			public byte genericRecursionDepth;

			// Token: 0x040007F0 RID: 2032
			public byte rank;

			// Token: 0x040007F1 RID: 2033
			public byte minimumAlignment;

			// Token: 0x040007F2 RID: 2034
			public byte naturalAligment;

			// Token: 0x040007F3 RID: 2035
			public byte packingSize;

			// Token: 0x040007F4 RID: 2036
			public NativeClassStructHandler_27_2.Il2CppClass_27_2.Bitfield0 _bitfield0;

			// Token: 0x020000F9 RID: 249
			internal enum Bitfield0 : ushort
			{
				// Token: 0x040007F6 RID: 2038
				BIT_initialized_and_no_error,
				// Token: 0x040007F7 RID: 2039
				initialized_and_no_error,
				// Token: 0x040007F8 RID: 2040
				BIT_initialized = 1,
				// Token: 0x040007F9 RID: 2041
				initialized,
				// Token: 0x040007FA RID: 2042
				BIT_enumtype = 2,
				// Token: 0x040007FB RID: 2043
				enumtype = 4,
				// Token: 0x040007FC RID: 2044
				BIT_is_generic = 3,
				// Token: 0x040007FD RID: 2045
				is_generic = 8,
				// Token: 0x040007FE RID: 2046
				BIT_has_references = 4,
				// Token: 0x040007FF RID: 2047
				has_references = 16,
				// Token: 0x04000800 RID: 2048
				BIT_init_pending = 5,
				// Token: 0x04000801 RID: 2049
				init_pending = 32,
				// Token: 0x04000802 RID: 2050
				BIT_size_inited = 6,
				// Token: 0x04000803 RID: 2051
				size_inited = 64,
				// Token: 0x04000804 RID: 2052
				BIT_has_finalize = 7,
				// Token: 0x04000805 RID: 2053
				has_finalize = 128,
				// Token: 0x04000806 RID: 2054
				BIT_has_cctor = 8,
				// Token: 0x04000807 RID: 2055
				has_cctor = 256,
				// Token: 0x04000808 RID: 2056
				BIT_is_blittable = 9,
				// Token: 0x04000809 RID: 2057
				is_blittable = 512,
				// Token: 0x0400080A RID: 2058
				BIT_is_import_or_windows_runtime = 10,
				// Token: 0x0400080B RID: 2059
				is_import_or_windows_runtime = 1024,
				// Token: 0x0400080C RID: 2060
				BIT_is_vtable_initialized = 11,
				// Token: 0x0400080D RID: 2061
				is_vtable_initialized = 2048,
				// Token: 0x0400080E RID: 2062
				BIT_has_initialization_error = 12,
				// Token: 0x0400080F RID: 2063
				has_initialization_error = 4096
			}
		}

		// Token: 0x020000FA RID: 250
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000AB2 RID: 2738 RVA: 0x000249F8 File Offset: 0x00022BF8
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ecb3ec1520014011821df145fb87d517 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b169d8ea412f45e99e430384ddc8908b == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x170003D2 RID: 978
			// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x00024A88 File Offset: 0x00022C88
			private unsafe NativeClassStructHandler_27_2.Il2CppClass_27_2* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170003D3 RID: 979
			// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x00024A98 File Offset: 0x00022C98
			// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x00024AB0 File Offset: 0x00022CB0
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_27_2.NativeStructWrapper.WsG8HePSJs0xHSCTKKj(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 4);
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
							this.SetBit(NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e19113368d2b45ba8f9d5ebaa49ce5d2 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003D4 RID: 980
			// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x00024B14 File Offset: 0x00022D14
			public IntPtr Pointer { get; }

			// Token: 0x170003D5 RID: 981
			// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00024B24 File Offset: 0x00022D24
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_27_2.NativeStructWrapper.rUKZfVPNJaN2kHO80jw(this.Pointer, sizeof(NativeClassStructHandler_27_2.Il2CppClass_27_2), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				}
			}

			// Token: 0x170003D6 RID: 982
			// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00024B44 File Offset: 0x00022D44
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170003D7 RID: 983
			// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00024B54 File Offset: 0x00022D54
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x170003D8 RID: 984
			// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00024B70 File Offset: 0x00022D70
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x170003D9 RID: 985
			// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00024B8C File Offset: 0x00022D8C
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x170003DA RID: 986
			// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00024BA0 File Offset: 0x00022DA0
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x170003DB RID: 987
			// (get) Token: 0x06000ABD RID: 2749 RVA: 0x00024BB4 File Offset: 0x00022DB4
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x170003DC RID: 988
			// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00024BC8 File Offset: 0x00022DC8
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x170003DD RID: 989
			// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00024BDC File Offset: 0x00022DDC
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x170003DE RID: 990
			// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00024BF0 File Offset: 0x00022DF0
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x170003DF RID: 991
			// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00024C04 File Offset: 0x00022E04
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x170003E0 RID: 992
			// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x00024C18 File Offset: 0x00022E18
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x170003E1 RID: 993
			// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00024C2C File Offset: 0x00022E2C
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x170003E2 RID: 994
			// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00024C40 File Offset: 0x00022E40
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x170003E3 RID: 995
			// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00024C58 File Offset: 0x00022E58
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170003E4 RID: 996
			// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00024C70 File Offset: 0x00022E70
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x170003E5 RID: 997
			// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x00024C88 File Offset: 0x00022E88
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x170003E6 RID: 998
			// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x00024C9C File Offset: 0x00022E9C
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x170003E7 RID: 999
			// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x00024CB0 File Offset: 0x00022EB0
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x170003E8 RID: 1000
			// (get) Token: 0x06000ACA RID: 2762 RVA: 0x00024CC4 File Offset: 0x00022EC4
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x170003E9 RID: 1001
			// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00024CD8 File Offset: 0x00022ED8
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x170003EA RID: 1002
			// (get) Token: 0x06000ACC RID: 2764 RVA: 0x00024CEC File Offset: 0x00022EEC
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x170003EB RID: 1003
			// (get) Token: 0x06000ACD RID: 2765 RVA: 0x00024D00 File Offset: 0x00022F00
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x170003EC RID: 1004
			// (get) Token: 0x06000ACE RID: 2766 RVA: 0x00024D14 File Offset: 0x00022F14
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x170003ED RID: 1005
			// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00024D28 File Offset: 0x00022F28
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x170003EE RID: 1006
			// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x00024D3C File Offset: 0x00022F3C
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x170003EF RID: 1007
			// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x00024D50 File Offset: 0x00022F50
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x170003F0 RID: 1008
			// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x00024D64 File Offset: 0x00022F64
			// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x00024DD8 File Offset: 0x00022FD8
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
							if (!NativeClassStructHandler_27_2.NativeStructWrapper.A88CvNPuIi8TeLBQEa6(this.ByValArg))
							{
								return false;
							}
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ecb3ec1520014011821df145fb87d517 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
					return NativeClassStructHandler_27_2.NativeStructWrapper.A88CvNPuIi8TeLBQEa6(this.ThisArg);
				}
				set
				{
				}
			}

			// Token: 0x170003F1 RID: 1009
			// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x00024DE4 File Offset: 0x00022FE4
			// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x00024DFC File Offset: 0x00022FFC
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_27_2.NativeStructWrapper.WsG8HePSJs0xHSCTKKj(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_27_2.NativeStructWrapper.PeGKdsPDlmd7QELXOEa(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_575f8bd7bfb04e37800ff009689b44f6 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003F2 RID: 1010
			// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x00024E60 File Offset: 0x00023060
			// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x00024E78 File Offset: 0x00023078
			public bool EnumType
			{
				get
				{
					return NativeClassStructHandler_27_2.NativeStructWrapper.WsG8HePSJs0xHSCTKKj(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 2);
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
							this.SetBit(NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7fef7bb77728417ab4965dd0775b5899 != 0)
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

			// Token: 0x170003F3 RID: 1011
			// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x00024EDC File Offset: 0x000230DC
			// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x00024EF4 File Offset: 0x000230F4
			public bool IsGeneric
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 3);
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
							NativeClassStructHandler_27_2.NativeStructWrapper.PeGKdsPDlmd7QELXOEa(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_49f6034724814fe88f4ca6e5ef134249 == 0)
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

			// Token: 0x170003F4 RID: 1012
			// (get) Token: 0x06000ADA RID: 2778 RVA: 0x00024F58 File Offset: 0x00023158
			// (set) Token: 0x06000ADB RID: 2779 RVA: 0x00024F70 File Offset: 0x00023170
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_27_2.NativeStructWrapper.WsG8HePSJs0xHSCTKKj(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 6);
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
							NativeClassStructHandler_27_2.NativeStructWrapper.PeGKdsPDlmd7QELXOEa(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eeb967463afe407d8f7c3b354043704c == 0)
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

			// Token: 0x170003F5 RID: 1013
			// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00024FD4 File Offset: 0x000231D4
			// (set) Token: 0x06000ADD RID: 2781 RVA: 0x00024FEC File Offset: 0x000231EC
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_27_2.NativeStructWrapper.WsG8HePSJs0xHSCTKKj(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_27_2.NativeStructWrapper.PeGKdsPDlmd7QELXOEa(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6a95c50bbb48420f8f11bb090d6d3bd5 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003F6 RID: 1014
			// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00025050 File Offset: 0x00023250
			// (set) Token: 0x06000ADF RID: 2783 RVA: 0x00025068 File Offset: 0x00023268
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_27_2.NativeStructWrapper.WsG8HePSJs0xHSCTKKj(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 11);
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
							NativeClassStructHandler_27_2.NativeStructWrapper.PeGKdsPDlmd7QELXOEa(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 11, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eeb967463afe407d8f7c3b354043704c == 0)
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

			// Token: 0x170003F7 RID: 1015
			// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x000250D0 File Offset: 0x000232D0
			// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x000250E8 File Offset: 0x000232E8
			public bool InitializedAndNoError
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_27_2.NativeStructWrapper.PeGKdsPDlmd7QELXOEa(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8b1b71d923f0486b89239dd4a11f6d34 != 0)
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

			// Token: 0x06000AE2 RID: 2786 RVA: 0x0002514C File Offset: 0x0002334C
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
						return;
					case 2:
						NativeClassStructHandler_27_2.NativeStructWrapper.j001U8PPoWZvrIyBtvQ();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b4185925b5254e3aae05578c6a89b13c == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset = aD8ZS5kvlxp4mAiEPJA.muOq5LWqgj(ref intPtr, aD8ZS5kvlxp4mAiEPJA.qwRkxpVy2X);
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5a2f191df3714123bdeb9f5f4b416da9 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						NativeClassStructHandler_27_2.NativeStructWrapper.UnrLGVP7TbnKu0kIi6d();
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b55404cff7864ea3949f7b4156fd6ee5 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 5:
						NativeClassStructHandler_27_2.NativeStructWrapper.BGh4O0PmJ1ZXfhqn5b0();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b4185925b5254e3aae05578c6a89b13c == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					intPtr = Marshal.OffsetOf<NativeClassStructHandler_27_2.Il2CppClass_27_2>(NativeClassStructHandler_27_2.NativeStructWrapper.yKaHivP4tyYhseEXKSP(55428970 ^ 797325918 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_64a8b41e58e0491ab0e9d05ec5ed61d3));
					num2 = 3;
				}
			}

			// Token: 0x06000AE3 RID: 2787 RVA: 0x0002525C File Offset: 0x0002345C
			internal static bool qt7EjkP0rT2g1t26qQP()
			{
				return NativeClassStructHandler_27_2.NativeStructWrapper.q139SwPV6TQoZRXgGmo == null;
			}

			// Token: 0x06000AE4 RID: 2788 RVA: 0x00025270 File Offset: 0x00023470
			internal static NativeClassStructHandler_27_2.NativeStructWrapper s56HnwPs1WRfO4RsUFF()
			{
				return NativeClassStructHandler_27_2.NativeStructWrapper.q139SwPV6TQoZRXgGmo;
			}

			// Token: 0x06000AE5 RID: 2789 RVA: 0x00025280 File Offset: 0x00023480
			internal static bool WsG8HePSJs0xHSCTKKj(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000AE6 RID: 2790 RVA: 0x0002529C File Offset: 0x0002349C
			internal static IntPtr rUKZfVPNJaN2kHO80jw(IntPtr A_0, int A_1, object A_2)
			{
				return apS1BFcfBa3gXUspL9j.muOq5LWqgj(A_0, A_1, A_2);
			}

			// Token: 0x06000AE7 RID: 2791 RVA: 0x000252B8 File Offset: 0x000234B8
			internal static bool A88CvNPuIi8TeLBQEa6(object A_0)
			{
				return ((INativeTypeStruct)A_0).ValueType;
			}

			// Token: 0x06000AE8 RID: 2792 RVA: 0x000252CC File Offset: 0x000234CC
			internal static void PeGKdsPDlmd7QELXOEa(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000AE9 RID: 2793 RVA: 0x000252EC File Offset: 0x000234EC
			internal static void BGh4O0PmJ1ZXfhqn5b0()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000AEA RID: 2794 RVA: 0x000252FC File Offset: 0x000234FC
			internal static void UnrLGVP7TbnKu0kIi6d()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000AEB RID: 2795 RVA: 0x0002530C File Offset: 0x0002350C
			internal static void j001U8PPoWZvrIyBtvQ()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000AEC RID: 2796 RVA: 0x0002531C File Offset: 0x0002351C
			internal static object yKaHivP4tyYhseEXKSP(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x04000810 RID: 2064
			private static readonly int _bitfield0offset;

			// Token: 0x04000812 RID: 2066
			internal static object q139SwPV6TQoZRXgGmo;
		}
	}
}
