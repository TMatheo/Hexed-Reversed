using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x020000C5 RID: 197
	[ApplicableToUnityVersionsSince("5.3.3")]
	public class NativeClassStructHandler_20_0 : INativeClassStructHandler, INativeStructHandler
	{
		// Token: 0x06000755 RID: 1877 RVA: 0x0001132C File Offset: 0x0000F52C
		public int Size()
		{
			return sizeof(NativeClassStructHandler_20_0.Il2CppClass_20_0);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0001133C File Offset: 0x0000F53C
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
					IntPtr buffer = ptr = NativeClassStructHandler_20_0.ymMW3McvdxcK02Yy4o2(this.Size() + sizeof(VirtualInvokeData) * vTableSlots);
					*ptr = default(NativeClassStructHandler_20_0.Il2CppClass_20_0);
					NativeClassStructHandler_20_0.ufXkO3cB3g1AFp8TkXl(buffer);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_1d16dd38ead14cb191f3b77c23c04ed4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				}
				break;
			}
			throw new NotSupportedException(hIDAYxH6DWLHIthQgC.gSCeTtiku(-864128026 ^ -2009878191 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5d181dabf1ed42eca63023d24d927754));
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x000113D8 File Offset: 0x0000F5D8
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fcdd30171ceb4eb7a5570cbbc4f6aec1 == 0)
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

		// Token: 0x06000758 RID: 1880 RVA: 0x00011440 File Offset: 0x0000F640
		public NativeClassStructHandler_20_0()
		{
			NativeClassStructHandler_20_0.ipUwnhcjKPf0Ax68bRf();
			NativeClassStructHandler_20_0.cqOdT0cT37TBlhErR2q();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2e7e5b018e46a2b3bb280ae243eb22 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x000114A4 File Offset: 0x0000F6A4
		// Note: this type is marked as 'beforefieldinit'.
		static NativeClassStructHandler_20_0()
		{
			NativeClassStructHandler_20_0.e3PktAcFNE9xEddU579();
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x000114B4 File Offset: 0x0000F6B4
		internal static IntPtr ymMW3McvdxcK02Yy4o2(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x000114C8 File Offset: 0x0000F6C8
		internal static void ufXkO3cB3g1AFp8TkXl(IntPtr buffer)
		{
			MarshalExtend.FreeHGlobal(buffer);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000114DC File Offset: 0x0000F6DC
		internal static bool sLeScYcX5bPTQQ2vPa2()
		{
			return NativeClassStructHandler_20_0.KT2LSDcO7G7YhTJHXF6 == null;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x000114F0 File Offset: 0x0000F6F0
		internal static NativeClassStructHandler_20_0 hafbfTcmA1YBS1EYckv()
		{
			return NativeClassStructHandler_20_0.KT2LSDcO7G7YhTJHXF6;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00011500 File Offset: 0x0000F700
		internal static void ipUwnhcjKPf0Ax68bRf()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00011510 File Offset: 0x0000F710
		internal static void cqOdT0cT37TBlhErR2q()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00011520 File Offset: 0x0000F720
		internal static void e3PktAcFNE9xEddU579()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000397 RID: 919
		internal static NativeClassStructHandler_20_0 KT2LSDcO7G7YhTJHXF6;

		// Token: 0x020000C6 RID: 198
		internal struct Il2CppClass_20_0
		{
			// Token: 0x04000398 RID: 920
			public unsafe Il2CppImage* image;

			// Token: 0x04000399 RID: 921
			public unsafe void* gc_desc;

			// Token: 0x0400039A RID: 922
			public unsafe byte* name;

			// Token: 0x0400039B RID: 923
			public unsafe byte* namespaze;

			// Token: 0x0400039C RID: 924
			public unsafe Il2CppTypeStruct* byval_arg;

			// Token: 0x0400039D RID: 925
			public unsafe Il2CppTypeStruct* this_arg;

			// Token: 0x0400039E RID: 926
			public unsafe Il2CppClass* element_class;

			// Token: 0x0400039F RID: 927
			public unsafe Il2CppClass* castClass;

			// Token: 0x040003A0 RID: 928
			public unsafe Il2CppClass* declaringType;

			// Token: 0x040003A1 RID: 929
			public unsafe Il2CppClass* parent;

			// Token: 0x040003A2 RID: 930
			public unsafe void* generic_class;

			// Token: 0x040003A3 RID: 931
			public unsafe void* typeDefinition;

			// Token: 0x040003A4 RID: 932
			public unsafe Il2CppFieldInfo* fields;

			// Token: 0x040003A5 RID: 933
			public unsafe Il2CppEventInfo* events;

			// Token: 0x040003A6 RID: 934
			public unsafe Il2CppPropertyInfo* properties;

			// Token: 0x040003A7 RID: 935
			public unsafe Il2CppMethodInfo** methods;

			// Token: 0x040003A8 RID: 936
			public unsafe Il2CppClass** nestedTypes;

			// Token: 0x040003A9 RID: 937
			public unsafe Il2CppClass** implementedInterfaces;

			// Token: 0x040003AA RID: 938
			public unsafe Il2CppMethodInfo** vtable;

			// Token: 0x040003AB RID: 939
			public unsafe Il2CppRuntimeInterfaceOffsetPair* interfaceOffsets;

			// Token: 0x040003AC RID: 940
			public unsafe void* static_fields;

			// Token: 0x040003AD RID: 941
			public unsafe void* rgctx_data;

			// Token: 0x040003AE RID: 942
			public unsafe Il2CppClass** typeHierarchy;

			// Token: 0x040003AF RID: 943
			public uint cctor_started;

			// Token: 0x040003B0 RID: 944
			public uint cctor_finished;

			// Token: 0x040003B1 RID: 945
			public ulong cctor_thread;

			// Token: 0x040003B2 RID: 946
			public int genericContainerIndex;

			// Token: 0x040003B3 RID: 947
			public int customAttributeIndex;

			// Token: 0x040003B4 RID: 948
			public uint instance_size;

			// Token: 0x040003B5 RID: 949
			public uint actualSize;

			// Token: 0x040003B6 RID: 950
			public uint element_size;

			// Token: 0x040003B7 RID: 951
			public int native_size;

			// Token: 0x040003B8 RID: 952
			public uint static_fields_size;

			// Token: 0x040003B9 RID: 953
			public uint thread_static_fields_size;

			// Token: 0x040003BA RID: 954
			public int thread_static_fields_offset;

			// Token: 0x040003BB RID: 955
			public uint flags;

			// Token: 0x040003BC RID: 956
			public uint token;

			// Token: 0x040003BD RID: 957
			public ushort method_count;

			// Token: 0x040003BE RID: 958
			public ushort property_count;

			// Token: 0x040003BF RID: 959
			public ushort field_count;

			// Token: 0x040003C0 RID: 960
			public ushort event_count;

			// Token: 0x040003C1 RID: 961
			public ushort nested_type_count;

			// Token: 0x040003C2 RID: 962
			public ushort vtable_count;

			// Token: 0x040003C3 RID: 963
			public ushort interfaces_count;

			// Token: 0x040003C4 RID: 964
			public ushort interface_offsets_count;

			// Token: 0x040003C5 RID: 965
			public byte typeHierarchyDepth;

			// Token: 0x040003C6 RID: 966
			public byte rank;

			// Token: 0x040003C7 RID: 967
			public byte minimumAlignment;

			// Token: 0x040003C8 RID: 968
			public byte packingSize;

			// Token: 0x040003C9 RID: 969
			public NativeClassStructHandler_20_0.Il2CppClass_20_0.Bitfield0 _bitfield0;

			// Token: 0x020000C7 RID: 199
			internal enum Bitfield0 : ushort
			{
				// Token: 0x040003CB RID: 971
				BIT_valuetype,
				// Token: 0x040003CC RID: 972
				valuetype,
				// Token: 0x040003CD RID: 973
				BIT_initialized = 1,
				// Token: 0x040003CE RID: 974
				initialized,
				// Token: 0x040003CF RID: 975
				BIT_enumtype = 2,
				// Token: 0x040003D0 RID: 976
				enumtype = 4,
				// Token: 0x040003D1 RID: 977
				BIT_is_generic = 3,
				// Token: 0x040003D2 RID: 978
				is_generic = 8,
				// Token: 0x040003D3 RID: 979
				BIT_has_references = 4,
				// Token: 0x040003D4 RID: 980
				has_references = 16,
				// Token: 0x040003D5 RID: 981
				BIT_init_pending = 5,
				// Token: 0x040003D6 RID: 982
				init_pending = 32,
				// Token: 0x040003D7 RID: 983
				BIT_size_inited = 6,
				// Token: 0x040003D8 RID: 984
				size_inited = 64,
				// Token: 0x040003D9 RID: 985
				BIT_has_finalize = 7,
				// Token: 0x040003DA RID: 986
				has_finalize = 128,
				// Token: 0x040003DB RID: 987
				BIT_has_cctor = 8,
				// Token: 0x040003DC RID: 988
				has_cctor = 256,
				// Token: 0x040003DD RID: 989
				BIT_is_blittable = 9,
				// Token: 0x040003DE RID: 990
				is_blittable = 512,
				// Token: 0x040003DF RID: 991
				BIT_is_import = 10,
				// Token: 0x040003E0 RID: 992
				is_import = 1024
			}
		}

		// Token: 0x020000C8 RID: 200
		internal class NativeStructWrapper : INativeClassStruct, INativeStruct
		{
			// Token: 0x06000761 RID: 1889 RVA: 0x0001E5D4 File Offset: 0x0001C7D4
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeClassStructHandler_20_0.NativeStructWrapper.O0GFvCoEHnp24abGCIk();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_16defe672aac4a3485dcd78387beb521 != 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_806dbdb7f5194c2fa0c07a915df13fc8 != 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x170001E4 RID: 484
			// (get) Token: 0x06000762 RID: 1890 RVA: 0x0001E664 File Offset: 0x0001C864
			private unsafe NativeClassStructHandler_20_0.Il2CppClass_20_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170001E5 RID: 485
			// (get) Token: 0x06000763 RID: 1891 RVA: 0x0001E674 File Offset: 0x0001C874
			// (set) Token: 0x06000764 RID: 1892 RVA: 0x0001E68C File Offset: 0x0001C88C
			public bool HasReferences
			{
				get
				{
					return NativeClassStructHandler_20_0.NativeStructWrapper.z2xqNNocf3JChgA99Gi(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 4);
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
							this.SetBit(NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 4, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_61a3825996b24609815f6b482bf680d9 == 0)
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

			// Token: 0x170001E6 RID: 486
			// (get) Token: 0x06000765 RID: 1893 RVA: 0x0001E6F0 File Offset: 0x0001C8F0
			public IntPtr Pointer { get; }

			// Token: 0x170001E7 RID: 487
			// (get) Token: 0x06000766 RID: 1894 RVA: 0x0001E700 File Offset: 0x0001C900
			public IntPtr VTable
			{
				get
				{
					return NativeClassStructHandler_20_0.NativeStructWrapper.jAy6QOo6yP1wH1Qpodq(this.Pointer, sizeof(NativeClassStructHandler_20_0.Il2CppClass_20_0), ksqFb8Il85Vq0skiabV.j8CIVKyZg8);
				}
			}

			// Token: 0x170001E8 RID: 488
			// (get) Token: 0x06000767 RID: 1895 RVA: 0x0001E720 File Offset: 0x0001C920
			public unsafe Il2CppClass* ClassPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170001E9 RID: 489
			// (get) Token: 0x06000768 RID: 1896 RVA: 0x0001E730 File Offset: 0x0001C930
			public unsafe INativeTypeStruct ByValArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->byval_arg);
				}
			}

			// Token: 0x170001EA RID: 490
			// (get) Token: 0x06000769 RID: 1897 RVA: 0x0001E74C File Offset: 0x0001C94C
			public unsafe INativeTypeStruct ThisArg
			{
				get
				{
					return UnityVersionHandler.Wrap(this._->this_arg);
				}
			}

			// Token: 0x170001EB RID: 491
			// (get) Token: 0x0600076A RID: 1898 RVA: 0x0001E768 File Offset: 0x0001C968
			public unsafe ref uint InstanceSize
			{
				get
				{
					return ref this._->instance_size;
				}
			}

			// Token: 0x170001EC RID: 492
			// (get) Token: 0x0600076B RID: 1899 RVA: 0x0001E77C File Offset: 0x0001C97C
			public unsafe ref ushort VtableCount
			{
				get
				{
					return ref this._->vtable_count;
				}
			}

			// Token: 0x170001ED RID: 493
			// (get) Token: 0x0600076C RID: 1900 RVA: 0x0001E790 File Offset: 0x0001C990
			public unsafe ref ushort InterfaceCount
			{
				get
				{
					return ref this._->interfaces_count;
				}
			}

			// Token: 0x170001EE RID: 494
			// (get) Token: 0x0600076D RID: 1901 RVA: 0x0001E7A4 File Offset: 0x0001C9A4
			public unsafe ref ushort InterfaceOffsetsCount
			{
				get
				{
					return ref this._->interface_offsets_count;
				}
			}

			// Token: 0x170001EF RID: 495
			// (get) Token: 0x0600076E RID: 1902 RVA: 0x0001E7B8 File Offset: 0x0001C9B8
			public unsafe ref byte TypeHierarchyDepth
			{
				get
				{
					return ref this._->typeHierarchyDepth;
				}
			}

			// Token: 0x170001F0 RID: 496
			// (get) Token: 0x0600076F RID: 1903 RVA: 0x0001E7CC File Offset: 0x0001C9CC
			public unsafe ref int NativeSize
			{
				get
				{
					return ref this._->native_size;
				}
			}

			// Token: 0x170001F1 RID: 497
			// (get) Token: 0x06000770 RID: 1904 RVA: 0x0001E7E0 File Offset: 0x0001C9E0
			public unsafe ref uint ActualSize
			{
				get
				{
					return ref this._->actualSize;
				}
			}

			// Token: 0x170001F2 RID: 498
			// (get) Token: 0x06000771 RID: 1905 RVA: 0x0001E7F4 File Offset: 0x0001C9F4
			public unsafe ref ushort MethodCount
			{
				get
				{
					return ref this._->method_count;
				}
			}

			// Token: 0x170001F3 RID: 499
			// (get) Token: 0x06000772 RID: 1906 RVA: 0x0001E808 File Offset: 0x0001CA08
			public unsafe ref ushort FieldCount
			{
				get
				{
					return ref this._->field_count;
				}
			}

			// Token: 0x170001F4 RID: 500
			// (get) Token: 0x06000773 RID: 1907 RVA: 0x0001E81C File Offset: 0x0001CA1C
			public unsafe ref Il2CppClassAttributes Flags
			{
				get
				{
					return ref *(Il2CppClassAttributes*)(&this._->flags);
				}
			}

			// Token: 0x170001F5 RID: 501
			// (get) Token: 0x06000774 RID: 1908 RVA: 0x0001E834 File Offset: 0x0001CA34
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170001F6 RID: 502
			// (get) Token: 0x06000775 RID: 1909 RVA: 0x0001E84C File Offset: 0x0001CA4C
			public unsafe ref IntPtr Namespace
			{
				get
				{
					return ref *(IntPtr*)(&this._->namespaze);
				}
			}

			// Token: 0x170001F7 RID: 503
			// (get) Token: 0x06000776 RID: 1910 RVA: 0x0001E864 File Offset: 0x0001CA64
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x170001F8 RID: 504
			// (get) Token: 0x06000777 RID: 1911 RVA: 0x0001E878 File Offset: 0x0001CA78
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x170001F9 RID: 505
			// (get) Token: 0x06000778 RID: 1912 RVA: 0x0001E88C File Offset: 0x0001CA8C
			public unsafe ref Il2CppClass* ElementClass
			{
				get
				{
					return ref this._->element_class;
				}
			}

			// Token: 0x170001FA RID: 506
			// (get) Token: 0x06000779 RID: 1913 RVA: 0x0001E8A0 File Offset: 0x0001CAA0
			public unsafe ref Il2CppClass* CastClass
			{
				get
				{
					return ref this._->castClass;
				}
			}

			// Token: 0x170001FB RID: 507
			// (get) Token: 0x0600077A RID: 1914 RVA: 0x0001E8B4 File Offset: 0x0001CAB4
			public unsafe ref Il2CppClass* DeclaringType
			{
				get
				{
					return ref this._->declaringType;
				}
			}

			// Token: 0x170001FC RID: 508
			// (get) Token: 0x0600077B RID: 1915 RVA: 0x0001E8C8 File Offset: 0x0001CAC8
			public unsafe ref Il2CppClass* Class
			{
				get
				{
					return ref this._klassDummy;
				}
			}

			// Token: 0x170001FD RID: 509
			// (get) Token: 0x0600077C RID: 1916 RVA: 0x0001E8D8 File Offset: 0x0001CAD8
			public unsafe ref Il2CppFieldInfo* Fields
			{
				get
				{
					return ref this._->fields;
				}
			}

			// Token: 0x170001FE RID: 510
			// (get) Token: 0x0600077D RID: 1917 RVA: 0x0001E8EC File Offset: 0x0001CAEC
			public unsafe ref Il2CppMethodInfo** Methods
			{
				get
				{
					return ref this._->methods;
				}
			}

			// Token: 0x170001FF RID: 511
			// (get) Token: 0x0600077E RID: 1918 RVA: 0x0001E900 File Offset: 0x0001CB00
			public unsafe ref Il2CppClass** ImplementedInterfaces
			{
				get
				{
					return ref this._->implementedInterfaces;
				}
			}

			// Token: 0x17000200 RID: 512
			// (get) Token: 0x0600077F RID: 1919 RVA: 0x0001E914 File Offset: 0x0001CB14
			public unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets
			{
				get
				{
					return ref this._->interfaceOffsets;
				}
			}

			// Token: 0x17000201 RID: 513
			// (get) Token: 0x06000780 RID: 1920 RVA: 0x0001E928 File Offset: 0x0001CB28
			public unsafe ref Il2CppClass** TypeHierarchy
			{
				get
				{
					return ref this._->typeHierarchy;
				}
			}

			// Token: 0x17000202 RID: 514
			// (get) Token: 0x06000781 RID: 1921 RVA: 0x0001E93C File Offset: 0x0001CB3C
			// (set) Token: 0x06000782 RID: 1922 RVA: 0x0001E954 File Offset: 0x0001CB54
			public bool ValueType
			{
				get
				{
					return NativeClassStructHandler_20_0.NativeStructWrapper.z2xqNNocf3JChgA99Gi(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 0);
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
							this.SetBit(NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 0, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2e7e5b018e46a2b3bb280ae243eb22 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000203 RID: 515
			// (get) Token: 0x06000783 RID: 1923 RVA: 0x0001E9B8 File Offset: 0x0001CBB8
			// (set) Token: 0x06000784 RID: 1924 RVA: 0x0001E9D0 File Offset: 0x0001CBD0
			public bool Initialized
			{
				get
				{
					return NativeClassStructHandler_20_0.NativeStructWrapper.z2xqNNocf3JChgA99Gi(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 1);
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
							NativeClassStructHandler_20_0.NativeStructWrapper.QI8J7LoL8QmXFrEJAJ1(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 1, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000204 RID: 516
			// (get) Token: 0x06000785 RID: 1925 RVA: 0x0001EA34 File Offset: 0x0001CC34
			// (set) Token: 0x06000786 RID: 1926 RVA: 0x0001EA4C File Offset: 0x0001CC4C
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
							NativeClassStructHandler_20_0.NativeStructWrapper.QI8J7LoL8QmXFrEJAJ1(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 2, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_eea945ea6be345c0b18511ac11610b35 != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000205 RID: 517
			// (get) Token: 0x06000787 RID: 1927 RVA: 0x0001EAB0 File Offset: 0x0001CCB0
			// (set) Token: 0x06000788 RID: 1928 RVA: 0x0001EAC8 File Offset: 0x0001CCC8
			public bool IsGeneric
			{
				get
				{
					return NativeClassStructHandler_20_0.NativeStructWrapper.z2xqNNocf3JChgA99Gi(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 3);
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
							this.SetBit(NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 3, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4e45528af4644e9b080e05d5ff6ef54 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000206 RID: 518
			// (get) Token: 0x06000789 RID: 1929 RVA: 0x0001EB2C File Offset: 0x0001CD2C
			// (set) Token: 0x0600078A RID: 1930 RVA: 0x0001EB44 File Offset: 0x0001CD44
			public bool SizeInited
			{
				get
				{
					return NativeClassStructHandler_20_0.NativeStructWrapper.z2xqNNocf3JChgA99Gi(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 6);
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
							NativeClassStructHandler_20_0.NativeStructWrapper.QI8J7LoL8QmXFrEJAJ1(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 6, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4ab786fa8604298818cd412db8f702f == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000207 RID: 519
			// (get) Token: 0x0600078B RID: 1931 RVA: 0x0001EBA8 File Offset: 0x0001CDA8
			// (set) Token: 0x0600078C RID: 1932 RVA: 0x0001EBC0 File Offset: 0x0001CDC0
			public bool HasFinalize
			{
				get
				{
					return this.CheckBit(NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 7);
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
							NativeClassStructHandler_20_0.NativeStructWrapper.QI8J7LoL8QmXFrEJAJ1(this, NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset, 7, value);
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc != 0)
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
			// (get) Token: 0x0600078D RID: 1933 RVA: 0x0001EC24 File Offset: 0x0001CE24
			// (set) Token: 0x0600078E RID: 1934 RVA: 0x0001EC30 File Offset: 0x0001CE30
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
			// (get) Token: 0x0600078F RID: 1935 RVA: 0x0001EC3C File Offset: 0x0001CE3C
			// (set) Token: 0x06000790 RID: 1936 RVA: 0x0001EC48 File Offset: 0x0001CE48
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

			// Token: 0x06000791 RID: 1937 RVA: 0x0001EC54 File Offset: 0x0001CE54
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
						NativeClassStructHandler_20_0.NativeStructWrapper.QFDspto78TYmoj8uD27();
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f65b5965aa9843ea8b738fef02a2c6c9 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
					{
						IntPtr intPtr;
						NativeClassStructHandler_20_0.NativeStructWrapper._bitfield0offset = JUCmVnGLumjHA0Awe7U.i2IAUFsOOC(ref intPtr, JUCmVnGLumjHA0Awe7U.Gf5G7ABEu5);
						num2 = 3;
						continue;
					}
					case 3:
						return;
					case 4:
						NativeClassStructHandler_20_0.NativeStructWrapper.O9pqYeoR9rpSOA28qpG();
						num2 = 5;
						continue;
					case 5:
					{
						IntPtr intPtr = Marshal.OffsetOf<NativeClassStructHandler_20_0.Il2CppClass_20_0>(hIDAYxH6DWLHIthQgC.gSCeTtiku(-2007369155 ^ -871091982 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5d181dabf1ed42eca63023d24d927754));
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_18558c8f0d4f4774910664df1c51bd49 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					}
					NativeClassStructHandler_20_0.NativeStructWrapper.O0GFvCoEHnp24abGCIk();
					num2 = 4;
				}
			}

			// Token: 0x06000792 RID: 1938 RVA: 0x0001ED3C File Offset: 0x0001CF3C
			internal static void O0GFvCoEHnp24abGCIk()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000793 RID: 1939 RVA: 0x0001ED4C File Offset: 0x0001CF4C
			internal static bool aTBY27oNqk6rPArAmoh()
			{
				return NativeClassStructHandler_20_0.NativeStructWrapper.e6STTHo05AaXPkhcVXY == null;
			}

			// Token: 0x06000794 RID: 1940 RVA: 0x0001ED60 File Offset: 0x0001CF60
			internal static NativeClassStructHandler_20_0.NativeStructWrapper GcSAqbouBDxMIaWvouG()
			{
				return NativeClassStructHandler_20_0.NativeStructWrapper.e6STTHo05AaXPkhcVXY;
			}

			// Token: 0x06000795 RID: 1941 RVA: 0x0001ED70 File Offset: 0x0001CF70
			internal static bool z2xqNNocf3JChgA99Gi(object A_0, int startOffset, int bit)
			{
				return A_0.CheckBit(startOffset, bit);
			}

			// Token: 0x06000796 RID: 1942 RVA: 0x0001ED8C File Offset: 0x0001CF8C
			internal static IntPtr jAy6QOo6yP1wH1Qpodq(IntPtr A_0, int A_1, object A_2)
			{
				return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
			}

			// Token: 0x06000797 RID: 1943 RVA: 0x0001EDA8 File Offset: 0x0001CFA8
			internal static void QI8J7LoL8QmXFrEJAJ1(object A_0, int startOffset, int bit, bool value)
			{
				A_0.SetBit(startOffset, bit, value);
			}

			// Token: 0x06000798 RID: 1944 RVA: 0x0001EDC8 File Offset: 0x0001CFC8
			internal static void QFDspto78TYmoj8uD27()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000799 RID: 1945 RVA: 0x0001EDD8 File Offset: 0x0001CFD8
			internal static void O9pqYeoR9rpSOA28qpG()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x040003E1 RID: 993
			private static readonly int _bitfield0offset;

			// Token: 0x040003E2 RID: 994
			private unsafe Il2CppClass* _klassDummy;

			// Token: 0x040003E4 RID: 996
			internal static object e6STTHo05AaXPkhcVXY;
		}
	}
}
