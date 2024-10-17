using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000F9 RID: 249
	[ApplicableToUnityVersionsSince("2021.1.0")]
	public class NativeClassStructHandler_27_2 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000ACA RID: 2762 RVA: 0x00012894 File Offset: 0x00010A94
		public int Size()
		{
			return sizeof(NativeClassStructHandler_27_2.Il2CppClass_27_2);
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x000128A4 File Offset: 0x00010AA4
		public unsafe INativeClassStruct CreateNewStruct(int vTableSlots)
		{
			NativeClassStructHandler_27_2.Il2CppClass_27_2* ptr2;
			IntPtr ptr = ptr2 = NativeClassStructHandler_27_2.eLp9miLCQOBUMgwAmn2(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
			*ptr2 = default(NativeClassStructHandler_27_2.Il2CppClass_27_2);
			return new NativeClassStructHandler_27_2.NativeStructWrapper(ptr);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x000128DC File Offset: 0x00010ADC
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc != 0)
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

		// Token: 0x06000ACD RID: 2765 RVA: 0x00012944 File Offset: 0x00010B44
		public NativeClassStructHandler_27_2()
		{
			NativeClassStructHandler_27_2.XOmp4cLt7cOVnlJOVIM();
			NativeClassStructHandler_27_2.mfuD9qLxeLZKhwVOUGn();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2b24b0de55344c2b8aaf8116dbc4d16 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x000129A8 File Offset: 0x00010BA8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_27_2()
		{
			NativeClassStructHandler_27_2.ArgBDfLhvxV952BEdvy();
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x000129B8 File Offset: 0x00010BB8
		internal static IntPtr eLp9miLCQOBUMgwAmn2(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x000129CC File Offset: 0x00010BCC
		internal static bool WrZXMLLY0FGi93932Yy()
		{
			return NativeClassStructHandler_27_2.FLMXMDLGeh9qDnovrHt == null;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x000129E0 File Offset: 0x00010BE0
		internal static NativeClassStructHandler_27_2 nI5xGELa3LfvjQyoLoC()
		{
			return NativeClassStructHandler_27_2.FLMXMDLGeh9qDnovrHt;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x000129F0 File Offset: 0x00010BF0
		internal static void XOmp4cLt7cOVnlJOVIM()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00012A00 File Offset: 0x00010C00
		internal static void mfuD9qLxeLZKhwVOUGn()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00012A10 File Offset: 0x00010C10
		internal static void ArgBDfLhvxV952BEdvy()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040007C9 RID: 1993
		private static NativeClassStructHandler_27_2 FLMXMDLGeh9qDnovrHt;

		// Token: 0x020000FA RID: 250
		internal struct Il2CppClass_27_2
		{
			// Token: 0x040007CA RID: 1994
			public unsafe Il2CppImage* image;

			// Token: 0x040007CB RID: 1995
			public unsafe void* gc_desc;

			// Token: 0x040007CC RID: 1996
			public unsafe byte* name;

			// Token: 0x040007CD RID: 1997
			public unsafe byte* namespaze;

			// Token: 0x040007CE RID: 1998
			public NativeTypeStructHandler_27_0.Il2CppType_27_0 byval_arg;

			// Token: 0x040007CF RID: 1999
			public NativeTypeStructHandler_27_0.Il2CppType_27_0 this_arg;

			// Token: 0x040007D0 RID: 2000
			public unsafe Il2CppClass* element_class;

			// Token: 0x040007D1 RID: 2001
			public unsafe Il2CppClass* castClass;

			// Token: 0x040007D2 RID: 2002
			public unsafe Il2CppClass* declaringType;

			// Token: 0x040007D3 RID: 2003
			public unsafe Il2CppClass* parent;

			// Token: 0x040007D4 RID: 2004
			public unsafe void* generic_class;

			// Token: 0x040007D5 RID: 2005
			public Il2CppMetadataTypeHandle typeMetadataHandle;

			// Token: 0x040007D6 RID: 2006
			public unsafe void* interopData;

			// Token: 0x040007D7 RID: 2007
			public unsafe Il2CppClass* klass;

			// Token: 0x040007D8 RID: 2008
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x040007D9 RID: 2009
			public unsafe Il2CppEventInfo* events;

			// Token: 0x040007DA RID: 2010
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x040007DB RID: 2011
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x040007DC RID: 2012
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x040007DD RID: 2013
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x040007DE RID: 2014
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x040007DF RID: 2015
			public unsafe void* static_fields;

			// Token: 0x040007E0 RID: 2016
			public unsafe void* rgctx_data;

			// Token: 0x040007E1 RID: 2017
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x040007E2 RID: 2018
			public unsafe void* unity_user_data;

			// Token: 0x040007E3 RID: 2019
			public uint initializationExceptionGCHandle;

			// Token: 0x040007E4 RID: 2020
			public uint cctor_started;

			// Token: 0x040007E5 RID: 2021
			public uint cctor_finished;

			// Token: 0x040007E6 RID: 2022
			public IntPtr cctor_thread;

			// Token: 0x040007E7 RID: 2023
			public Il2CppMetadataGenericContainerHandle genericContainerHandle;

			// Token: 0x040007E8 RID: 2024
			public uint instance_size;

			// Token: 0x040007E9 RID: 2025
			public uint actualSize;

			// Token: 0x040007EA RID: 2026
			public uint element_size;

			// Token: 0x040007EB RID: 2027
			public int native_size;

			// Token: 0x040007EC RID: 2028
			public uint static_fields_size;

			// Token: 0x040007ED RID: 2029
			public uint thread_static_fields_size;

			// Token: 0x040007EE RID: 2030
			public int thread_static_fields_offset;

			// Token: 0x040007EF RID: 2031
			public uint flags;

			// Token: 0x040007F0 RID: 2032
			public uint token;

			// Token: 0x040007F1 RID: 2033
			public ushort method_count;

			// Token: 0x040007F2 RID: 2034
			public ushort property_count;

			// Token: 0x040007F3 RID: 2035
			public ushort field_count;

			// Token: 0x040007F4 RID: 2036
			public ushort event_count;

			// Token: 0x040007F5 RID: 2037
			public ushort nested_type_count;

			// Token: 0x040007F6 RID: 2038
			public ushort vtable_count;

			// Token: 0x040007F7 RID: 2039
			public ushort interfaces_count;

			// Token: 0x040007F8 RID: 2040
			public ushort interface_offsets_count;

			// Token: 0x040007F9 RID: 2041
			public byte typeHierarchyDepth;

			// Token: 0x040007FA RID: 2042
			public byte genericRecursionDepth;

			// Token: 0x040007FB RID: 2043
			public byte rank;

			// Token: 0x040007FC RID: 2044
			public byte minimumAlignment;

			// Token: 0x040007FD RID: 2045
			public byte naturalAligment;

			// Token: 0x040007FE RID: 2046
			public byte packingSize;

			// Token: 0x040007FF RID: 2047
			public NativeClassStructHandler_27_2.Il2CppClass_27_2.Bitfield0 _bitfield0;

			// Token: 0x020000FB RID: 251
			internal enum Bitfield0 : ushort
			{
				// Token: 0x04000801 RID: 2049
				BIT_initialized_and_no_error,
				// Token: 0x04000802 RID: 2050
				initialized_and_no_error,
				// Token: 0x04000803 RID: 2051
				BIT_initialized = 1,
				// Token: 0x04000804 RID: 2052
				initialized,
				// Token: 0x04000805 RID: 2053
				BIT_enumtype = 2,
				// Token: 0x04000806 RID: 2054
				enumtype = 4,
				// Token: 0x04000807 RID: 2055
				BIT_is_generic = 3,
				// Token: 0x04000808 RID: 2056
				is_generic = 8,
				// Token: 0x04000809 RID: 2057
				BIT_has_references = 4,
				// Token: 0x0400080A RID: 2058
				has_references = 16,
				// Token: 0x0400080B RID: 2059
				BIT_init_pending = 5,
				// Token: 0x0400080C RID: 2060
				init_pending = 32,
				// Token: 0x0400080D RID: 2061
				BIT_size_inited = 6,
				// Token: 0x0400080E RID: 2062
				size_inited = 64,
				// Token: 0x0400080F RID: 2063
				BIT_has_finalize = 7,
				// Token: 0x04000810 RID: 2064
				has_finalize = 128,
				// Token: 0x04000811 RID: 2065
				BIT_has_cctor = 8,
				// Token: 0x04000812 RID: 2066
				has_cctor = 256,
				// Token: 0x04000813 RID: 2067
				BIT_is_blittable = 9,
				// Token: 0x04000814 RID: 2068
				is_blittable = 512,
				// Token: 0x04000815 RID: 2069
				BIT_is_import_or_windows_runtime = 10,
				// Token: 0x04000816 RID: 2070
				is_import_or_windows_runtime = 1024,
				// Token: 0x04000817 RID: 2071
				BIT_is_vtable_initialized = 11,
				// Token: 0x04000818 RID: 2072
				is_vtable_initialized = 2048,
				// Token: 0x04000819 RID: 2073
				BIT_has_initialization_error = 12,
				// Token: 0x0400081A RID: 2074
				has_initialization_error = 4096
			}
		}

		// Token: 0x020000FC RID: 252
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000AD5 RID: 2773 RVA: 0x0002569C File Offset: 0x0002389C
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_27_2.NativeStructWrapper.Gntekrf3drUvMURjNIK();
				NativeClassStructHandler_27_2.NativeStructWrapper.e2EHhwf1JlGdgPobB0U();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56a961858094410b8d2e4da57d386f1 != 0)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_afe904a262fb47328a49943b4b34b494 != 0)
					{
						num = 1;
					}
				}
			}

			// Token: 0x170003D2 RID: 978
			// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x0002572C File Offset: 0x0002392C
			private unsafe NativeClassStructHandler_27_2.Il2CppClass_27_2* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170003D3 RID: 979
			// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0002573C File Offset: 0x0002393C
			// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00025754 File Offset: 0x00023954
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_27_2.NativeStructWrapper.s3DdOEfMP6PbTwWYJAO(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 4);
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
							NativeClassStructHandler_27_2.NativeStructWrapper.WJhDZZfpcom9uYSoKIF(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ef7f3142723b424fb42b4125f902e28b != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003D4 RID: 980
			// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x000257B8 File Offset: 0x000239B8
			public IntPtr Pointer { get; }

			// Token: 0x170003D5 RID: 981
			// (get) Token: 0x06000ADA RID: 2778 RVA: 0x000257C8 File Offset: 0x000239C8
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_27_2.NativeStructWrapper.OED5crf4HPGI7EKFG4P(this.Pointer, sizeof(NativeClassStructHandler_27_2.Il2CppClass_27_2), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x170003D6 RID: 982
			// (get) Token: 0x06000ADB RID: 2779 RVA: 0x000257E8 File Offset: 0x000239E8
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170003D7 RID: 983
			// (get) Token: 0x06000ADC RID: 2780 RVA: 0x000257F8 File Offset: 0x000239F8
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->byval_arg));
				}
			}

			// Token: 0x170003D8 RID: 984
			// (get) Token: 0x06000ADD RID: 2781 RVA: 0x00025814 File Offset: 0x00023A14
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppTypeStruct*)(&this._->this_arg));
				}
			}

			// Token: 0x170003D9 RID: 985
			// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00025830 File Offset: 0x00023A30
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x170003DA RID: 986
			// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00025844 File Offset: 0x00023A44
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x170003DB RID: 987
			// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x00025858 File Offset: 0x00023A58
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x170003DC RID: 988
			// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0002586C File Offset: 0x00023A6C
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x170003DD RID: 989
			// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00025880 File Offset: 0x00023A80
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x170003DE RID: 990
			// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00025894 File Offset: 0x00023A94
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x170003DF RID: 991
			// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x000258A8 File Offset: 0x00023AA8
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x170003E0 RID: 992
			// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x000258BC File Offset: 0x00023ABC
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x170003E1 RID: 993
			// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x000258D0 File Offset: 0x00023AD0
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x170003E2 RID: 994
			// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x000258E4 File Offset: 0x00023AE4
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x170003E3 RID: 995
			// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x000258FC File Offset: 0x00023AFC
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170003E4 RID: 996
			// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x00025914 File Offset: 0x00023B14
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x170003E5 RID: 997
			// (get) Token: 0x06000AEA RID: 2794 RVA: 0x0002592C File Offset: 0x00023B2C
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x170003E6 RID: 998
			// (get) Token: 0x06000AEB RID: 2795 RVA: 0x00025940 File Offset: 0x00023B40
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x170003E7 RID: 999
			// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00025954 File Offset: 0x00023B54
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x170003E8 RID: 1000
			// (get) Token: 0x06000AED RID: 2797 RVA: 0x00025968 File Offset: 0x00023B68
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x170003E9 RID: 1001
			// (get) Token: 0x06000AEE RID: 2798 RVA: 0x0002597C File Offset: 0x00023B7C
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x170003EA RID: 1002
			// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00025990 File Offset: 0x00023B90
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._->klass;
				}
			}

			// Token: 0x170003EB RID: 1003
			// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x000259A4 File Offset: 0x00023BA4
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x170003EC RID: 1004
			// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x000259B8 File Offset: 0x00023BB8
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x170003ED RID: 1005
			// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x000259CC File Offset: 0x00023BCC
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x170003EE RID: 1006
			// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x000259E0 File Offset: 0x00023BE0
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x170003EF RID: 1007
			// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x000259F4 File Offset: 0x00023BF4
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x170003F0 RID: 1008
			// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00025A08 File Offset: 0x00023C08
			// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00025AA4 File Offset: 0x00023CA4
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
							if (this.ByValArg.ValueType)
							{
								goto IL_82;
							}
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_22d16b8eb84d4725aef9f7a9d2f68925 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							goto IL_82;
						}
						break;
					}
					return false;
					IL_82:
					return NativeClassStructHandler_27_2.NativeStructWrapper.Fdo8SEfzMQAxjal3Z31(this.ThisArg);
				}
				set
				{
				}
			}

			// Token: 0x170003F1 RID: 1009
			// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00025AB0 File Offset: 0x00023CB0
			// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x00025AC8 File Offset: 0x00023CC8
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_27_2.NativeStructWrapper.s3DdOEfMP6PbTwWYJAO(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_27_2.NativeStructWrapper.WJhDZZfpcom9uYSoKIF(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3cdc0c80f3644c499e0bcd7810be1cee == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003F2 RID: 1010
			// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00025B2C File Offset: 0x00023D2C
			// (set) Token: 0x06000AFA RID: 2810 RVA: 0x00025B44 File Offset: 0x00023D44
			public bool EnumType
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 2);
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
							NativeClassStructHandler_27_2.NativeStructWrapper.WJhDZZfpcom9uYSoKIF(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_82de010761f84d069578c758673e6648 == 0)
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
			// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00025BA8 File Offset: 0x00023DA8
			// (set) Token: 0x06000AFC RID: 2812 RVA: 0x00025BC0 File Offset: 0x00023DC0
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
							NativeClassStructHandler_27_2.NativeStructWrapper.WJhDZZfpcom9uYSoKIF(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9f56599a6a304695b6cfc284bd7d7c9a == 0)
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
			// (get) Token: 0x06000AFD RID: 2813 RVA: 0x00025C24 File Offset: 0x00023E24
			// (set) Token: 0x06000AFE RID: 2814 RVA: 0x00025C3C File Offset: 0x00023E3C
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_27_2.NativeStructWrapper.s3DdOEfMP6PbTwWYJAO(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 6);
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
							NativeClassStructHandler_27_2.NativeStructWrapper.WJhDZZfpcom9uYSoKIF(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6e39fb1a8feb46889b60abcfbb34e0df == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170003F5 RID: 1013
			// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00025CA0 File Offset: 0x00023EA0
			// (set) Token: 0x06000B00 RID: 2816 RVA: 0x00025CB8 File Offset: 0x00023EB8
			public bool HasFinalize
			{
				get
				{
					return NativeClassStructHandler_27_2.NativeStructWrapper.s3DdOEfMP6PbTwWYJAO(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_27_2.NativeStructWrapper.WJhDZZfpcom9uYSoKIF(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 7, value);
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

			// Token: 0x170003F6 RID: 1014
			// (get) Token: 0x06000B01 RID: 2817 RVA: 0x00025D1C File Offset: 0x00023F1C
			// (set) Token: 0x06000B02 RID: 2818 RVA: 0x00025D34 File Offset: 0x00023F34
			public bool IsVtableInitialized
			{
				get
				{
					return NativeClassStructHandler_27_2.NativeStructWrapper.s3DdOEfMP6PbTwWYJAO(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 11);
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
							NativeClassStructHandler_27_2.NativeStructWrapper.WJhDZZfpcom9uYSoKIF(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 11, value);
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

			// Token: 0x170003F7 RID: 1015
			// (get) Token: 0x06000B03 RID: 2819 RVA: 0x00025D9C File Offset: 0x00023F9C
			// (set) Token: 0x06000B04 RID: 2820 RVA: 0x00025DB4 File Offset: 0x00023FB4
			public bool InitializedAndNoError
			{
				get
				{
					return NativeClassStructHandler_27_2.NativeStructWrapper.s3DdOEfMP6PbTwWYJAO(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 0);
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
							NativeClassStructHandler_27_2.NativeStructWrapper.WJhDZZfpcom9uYSoKIF(this, NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_17522b2a3ddb488c87b7266d3b1f941d == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x06000B05 RID: 2821 RVA: 0x00025E18 File Offset: 0x00024018
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
						NativeClassStructHandler_27_2.NativeStructWrapper.FaPVrpPHR2rywp825d7();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d03e4e4716154375bf56bf596fbd5780 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_27_2.Il2CppClass_27_2>(NativeClassStructHandler_27_2.NativeStructWrapper.RI7lGjPA87Qnx9fwgqx(534098265 ^ 530284920 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b15bb2810b414d8fba6ffddaf7154f62));
						num2 = 3;
						continue;
					}
					case 3:
					{
						IntPtr intPtr;
						NativeClassStructHandler_27_2.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 4;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bd64431fd05f4961aa9b79e5bd243164 != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					}
					case 4:
						NativeClassStructHandler_27_2.NativeStructWrapper.e2EHhwf1JlGdgPobB0U();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_75b92ac812f348208c578c3de71e2d57 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 5:
						return;
					}
					NativeClassStructHandler_27_2.NativeStructWrapper.Gntekrf3drUvMURjNIK();
					num2 = 4;
				}
			}

			// Token: 0x06000B06 RID: 2822 RVA: 0x00025F14 File Offset: 0x00024114
			internal static void Gntekrf3drUvMURjNIK()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000B07 RID: 2823 RVA: 0x00025F24 File Offset: 0x00024124
			internal static void e2EHhwf1JlGdgPobB0U()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000B08 RID: 2824 RVA: 0x00025F34 File Offset: 0x00024134
			internal static bool iWCdf1f5B4wx7NZI7yN()
			{
				return NativeClassStructHandler_27_2.NativeStructWrapper.wAcEtZfK0HNIL4eWgpX == null;
			}

			// Token: 0x06000B09 RID: 2825 RVA: 0x00025F48 File Offset: 0x00024148
			internal static NativeClassStructHandler_27_2.NativeStructWrapper cKrBkCfnjgXCZPc16B8()
			{
				return NativeClassStructHandler_27_2.NativeStructWrapper.wAcEtZfK0HNIL4eWgpX;
			}

			// Token: 0x06000B0A RID: 2826 RVA: 0x00025F58 File Offset: 0x00024158
			internal static bool s3DdOEfMP6PbTwWYJAO(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000B0B RID: 2827 RVA: 0x00025F74 File Offset: 0x00024174
			internal static void WJhDZZfpcom9uYSoKIF(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000B0C RID: 2828 RVA: 0x00025F94 File Offset: 0x00024194
			internal static IntPtr OED5crf4HPGI7EKFG4P(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x06000B0D RID: 2829 RVA: 0x00025FB0 File Offset: 0x000241B0
			internal static bool Fdo8SEfzMQAxjal3Z31(object A_0)
			{
				return ((INativeTypeStruct)A_0).ValueType;
			}

			// Token: 0x06000B0E RID: 2830 RVA: 0x00025FC4 File Offset: 0x000241C4
			internal static void FaPVrpPHR2rywp825d7()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000B0F RID: 2831 RVA: 0x00025FD4 File Offset: 0x000241D4
			internal static object RI7lGjPA87Qnx9fwgqx(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x0400081B RID: 2075
			private static readonly int _bitfield0offset;

			// Token: 0x0400081D RID: 2077
			private static object wAcEtZfK0HNIL4eWgpX;
		}
	}
}
