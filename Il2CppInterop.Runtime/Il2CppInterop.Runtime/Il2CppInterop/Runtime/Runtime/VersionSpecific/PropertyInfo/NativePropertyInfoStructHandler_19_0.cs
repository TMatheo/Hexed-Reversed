using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.PropertyInfo
{
	// Token: 0x0200004B RID: 75
	[ApplicableToUnityVersionsSince("5.3.2")]
	public class NativePropertyInfoStructHandler_19_0 : INativePropertyInfoStructHandler, INativeStructHandler
	{
		// Token: 0x0600030D RID: 781 RVA: 0x0000D0BC File Offset: 0x0000B2BC
		public int Size()
		{
			return sizeof(NativePropertyInfoStructHandler_19_0.Il2CppPropertyInfo_19_0);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000D0CC File Offset: 0x0000B2CC
		public unsafe INativePropertyInfoStruct CreateNewStruct()
		{
			NativePropertyInfoStructHandler_19_0.Il2CppPropertyInfo_19_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativePropertyInfoStructHandler_19_0.Il2CppPropertyInfo_19_0);
			return new NativePropertyInfoStructHandler_19_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000D0FC File Offset: 0x0000B2FC
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_64a8b41e58e0491ab0e9d05ec5ed61d3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativePropertyInfoStructHandler_19_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000D164 File Offset: 0x0000B364
		public NativePropertyInfoStructHandler_19_0()
		{
			NativePropertyInfoStructHandler_19_0.nHEkQnYCoNNVPVHrdyL();
			NativePropertyInfoStructHandler_19_0.NKCvmAY9NbNaf2Qw6YT();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_734db430e12345289ec4ae0afacc44df == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000D1C8 File Offset: 0x0000B3C8
		// Note: this type is marked as 'beforefieldinit'.
		static NativePropertyInfoStructHandler_19_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000D1D8 File Offset: 0x0000B3D8
		internal static bool PnETm1YMZ7yZpsfBb0Z()
		{
			return NativePropertyInfoStructHandler_19_0.xcZpZGYRfVtA039BbH9 == null;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000D1EC File Offset: 0x0000B3EC
		internal static NativePropertyInfoStructHandler_19_0 NoW3UMYWjM5BO4MlvTV()
		{
			return NativePropertyInfoStructHandler_19_0.xcZpZGYRfVtA039BbH9;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000D1FC File Offset: 0x0000B3FC
		internal static void nHEkQnYCoNNVPVHrdyL()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000D20C File Offset: 0x0000B40C
		internal static void NKCvmAY9NbNaf2Qw6YT()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x04000117 RID: 279
		private static NativePropertyInfoStructHandler_19_0 xcZpZGYRfVtA039BbH9;

		// Token: 0x0200004C RID: 76
		internal struct Il2CppPropertyInfo_19_0
		{
			// Token: 0x04000118 RID: 280
			public unsafe Il2CppClass* parent;

			// Token: 0x04000119 RID: 281
			public unsafe byte* name;

			// Token: 0x0400011A RID: 282
			public unsafe Il2CppMethodInfo* get;

			// Token: 0x0400011B RID: 283
			public unsafe Il2CppMethodInfo* set;

			// Token: 0x0400011C RID: 284
			public uint attrs;

			// Token: 0x0400011D RID: 285
			public int customAttributeIndex;

			// Token: 0x0400011E RID: 286
			public uint token;
		}

		// Token: 0x0200004D RID: 77
		internal class NativeStructWrapper : INativePropertyInfoStruct, INativeStruct
		{
			// Token: 0x06000316 RID: 790 RVA: 0x000185C4 File Offset: 0x000167C4
			public NativeStructWrapper(IntPtr ptr)
			{
				NativePropertyInfoStructHandler_19_0.NativeStructWrapper.hVCBcJ0UpCtIdY3LdZX();
				NativePropertyInfoStructHandler_19_0.NativeStructWrapper.SJLauW0jpvDFjKQnOHi();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_355d73c700924bf28058452e63cd9cf1 == 0)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4da80845ebf7410ebbf942336f5ee27b == 0)
					{
						num = 0;
					}
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x06000317 RID: 791 RVA: 0x00018654 File Offset: 0x00016854
			private unsafe NativePropertyInfoStructHandler_19_0.Il2CppPropertyInfo_19_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x06000318 RID: 792 RVA: 0x00018664 File Offset: 0x00016864
			public IntPtr Pointer { get; }

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x06000319 RID: 793 RVA: 0x00018674 File Offset: 0x00016874
			public unsafe Il2CppPropertyInfo* PropertyInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x0600031A RID: 794 RVA: 0x00018684 File Offset: 0x00016884
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x0600031B RID: 795 RVA: 0x0001869C File Offset: 0x0001689C
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x0600031C RID: 796 RVA: 0x000186B0 File Offset: 0x000168B0
			public unsafe ref Il2CppMethodInfo* Get
			{
				get
				{
					return ref this._->get;
				}
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x0600031D RID: 797 RVA: 0x000186C4 File Offset: 0x000168C4
			public unsafe ref Il2CppMethodInfo* Set
			{
				get
				{
					return ref this._->set;
				}
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x0600031E RID: 798 RVA: 0x000186D8 File Offset: 0x000168D8
			public unsafe ref uint Attrs
			{
				get
				{
					return ref this._->attrs;
				}
			}

			// Token: 0x0600031F RID: 799 RVA: 0x000186EC File Offset: 0x000168EC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000320 RID: 800 RVA: 0x000186FC File Offset: 0x000168FC
			internal static void hVCBcJ0UpCtIdY3LdZX()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000321 RID: 801 RVA: 0x0001870C File Offset: 0x0001690C
			internal static void SJLauW0jpvDFjKQnOHi()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000322 RID: 802 RVA: 0x0001871C File Offset: 0x0001691C
			internal static bool bbE7rh0g0tZtQiM7cnu()
			{
				return NativePropertyInfoStructHandler_19_0.NativeStructWrapper.RjiqPB0TSeyYGlQ7yC4 == null;
			}

			// Token: 0x06000323 RID: 803 RVA: 0x00018730 File Offset: 0x00016930
			internal static NativePropertyInfoStructHandler_19_0.NativeStructWrapper dMcZC10o4DK4H4i1SPI()
			{
				return NativePropertyInfoStructHandler_19_0.NativeStructWrapper.RjiqPB0TSeyYGlQ7yC4;
			}

			// Token: 0x04000120 RID: 288
			internal static object RjiqPB0TSeyYGlQ7yC4;
		}
	}
}
