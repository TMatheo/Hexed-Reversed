using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.PropertyInfo
{
	// Token: 0x02000048 RID: 72
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativePropertyInfoStructHandler_16_0 : INativePropertyInfoStructHandler, INativeStructHandler
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x0000CF48 File Offset: 0x0000B148
		public int Size()
		{
			return sizeof(NativePropertyInfoStructHandler_16_0.Il2CppPropertyInfo_16_0);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000CF58 File Offset: 0x0000B158
		public unsafe INativePropertyInfoStruct CreateNewStruct()
		{
			NativePropertyInfoStructHandler_16_0.Il2CppPropertyInfo_16_0* ptr2;
			IntPtr ptr = ptr2 = NativePropertyInfoStructHandler_16_0.kHBX4JYfg60UJIxIPJD(this.Size());
			*ptr2 = default(NativePropertyInfoStructHandler_16_0.Il2CppPropertyInfo_16_0);
			return new NativePropertyInfoStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000CF88 File Offset: 0x0000B188
		public unsafe INativePropertyInfoStruct Wrap(Il2CppPropertyInfo* ptr)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ecb3ec1520014011821df145fb87d517 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativePropertyInfoStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
		public NativePropertyInfoStructHandler_16_0()
		{
			NativePropertyInfoStructHandler_16_0.JIAE7uY1Wu0RpCpqs7M();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_07ecbd0ef7af44eb94dd5a58ea706c8a != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000D054 File Offset: 0x0000B254
		// Note: this type is marked as 'beforefieldinit'.
		static NativePropertyInfoStructHandler_16_0()
		{
			NativePropertyInfoStructHandler_16_0.ofeOvMYFcyD27R1YpIE();
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000D064 File Offset: 0x0000B264
		internal static IntPtr kHBX4JYfg60UJIxIPJD(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000D078 File Offset: 0x0000B278
		internal static bool vnggGkY4tTMZFqj7qWk()
		{
			return NativePropertyInfoStructHandler_16_0.s5FCcaYPH9wPHosPKSV == null;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000D08C File Offset: 0x0000B28C
		internal static NativePropertyInfoStructHandler_16_0 G3KZirY3MnH6dBKBcUs()
		{
			return NativePropertyInfoStructHandler_16_0.s5FCcaYPH9wPHosPKSV;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000D09C File Offset: 0x0000B29C
		internal static void JIAE7uY1Wu0RpCpqs7M()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000D0AC File Offset: 0x0000B2AC
		internal static void ofeOvMYFcyD27R1YpIE()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400010E RID: 270
		internal static NativePropertyInfoStructHandler_16_0 s5FCcaYPH9wPHosPKSV;

		// Token: 0x02000049 RID: 73
		internal struct Il2CppPropertyInfo_16_0
		{
			// Token: 0x0400010F RID: 271
			public unsafe Il2CppClass* parent;

			// Token: 0x04000110 RID: 272
			public unsafe byte* name;

			// Token: 0x04000111 RID: 273
			public unsafe Il2CppMethodInfo* get;

			// Token: 0x04000112 RID: 274
			public unsafe Il2CppMethodInfo* set;

			// Token: 0x04000113 RID: 275
			public uint attrs;

			// Token: 0x04000114 RID: 276
			public int customAttributeIndex;
		}

		// Token: 0x0200004A RID: 74
		internal class NativeStructWrapper : INativePropertyInfoStruct, INativeStruct
		{
			// Token: 0x06000300 RID: 768 RVA: 0x00018458 File Offset: 0x00016658
			public NativeStructWrapper(IntPtr ptr)
			{
				NativePropertyInfoStructHandler_16_0.NativeStructWrapper.aZkySh0EdgoV17RZ44y();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb8decd62b945dda713f7b22b6b95ca == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x06000301 RID: 769 RVA: 0x000184E8 File Offset: 0x000166E8
			private unsafe NativePropertyInfoStructHandler_16_0.Il2CppPropertyInfo_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x06000302 RID: 770 RVA: 0x000184F8 File Offset: 0x000166F8
			public IntPtr Pointer { get; }

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x06000303 RID: 771 RVA: 0x00018508 File Offset: 0x00016708
			public unsafe Il2CppPropertyInfo* PropertyInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000304 RID: 772 RVA: 0x00018518 File Offset: 0x00016718
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x06000305 RID: 773 RVA: 0x00018530 File Offset: 0x00016730
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000306 RID: 774 RVA: 0x00018544 File Offset: 0x00016744
			public unsafe ref Il2CppMethodInfo* Get
			{
				get
				{
					return ref this._->get;
				}
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000307 RID: 775 RVA: 0x00018558 File Offset: 0x00016758
			public unsafe ref Il2CppMethodInfo* Set
			{
				get
				{
					return ref this._->set;
				}
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x06000308 RID: 776 RVA: 0x0001856C File Offset: 0x0001676C
			public unsafe ref uint Attrs
			{
				get
				{
					return ref this._->attrs;
				}
			}

			// Token: 0x06000309 RID: 777 RVA: 0x00018580 File Offset: 0x00016780
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0600030A RID: 778 RVA: 0x00018590 File Offset: 0x00016790
			internal static void aZkySh0EdgoV17RZ44y()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600030B RID: 779 RVA: 0x000185A0 File Offset: 0x000167A0
			internal static bool T3uTii0iNKNEMXK11d4()
			{
				return NativePropertyInfoStructHandler_16_0.NativeStructWrapper.QVfs9L0dDNMqT1e59pY == null;
			}

			// Token: 0x0600030C RID: 780 RVA: 0x000185B4 File Offset: 0x000167B4
			internal static NativePropertyInfoStructHandler_16_0.NativeStructWrapper nYuc9g0wkfaUuLGNXxY()
			{
				return NativePropertyInfoStructHandler_16_0.NativeStructWrapper.QVfs9L0dDNMqT1e59pY;
			}

			// Token: 0x04000116 RID: 278
			internal static object QVfs9L0dDNMqT1e59pY;
		}
	}
}
