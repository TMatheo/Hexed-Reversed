using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.PropertyInfo
{
	// Token: 0x0200004E RID: 78
	[ApplicableToUnityVersionsSince("2018.3.0")]
	public class NativePropertyInfoStructHandler_24_0 : INativePropertyInfoStructHandler, INativeStructHandler
	{
		// Token: 0x06000324 RID: 804 RVA: 0x0000D21C File Offset: 0x0000B41C
		public int Size()
		{
			return sizeof(NativePropertyInfoStructHandler_24_0.Il2CppPropertyInfo_24_0);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000D22C File Offset: 0x0000B42C
		public unsafe INativePropertyInfoStruct CreateNewStruct()
		{
			NativePropertyInfoStructHandler_24_0.Il2CppPropertyInfo_24_0* ptr2;
			IntPtr ptr = ptr2 = NativePropertyInfoStructHandler_24_0.gKXX88YwBlkskcNfujD(this.Size());
			*ptr2 = default(NativePropertyInfoStructHandler_24_0.Il2CppPropertyInfo_24_0);
			return new NativePropertyInfoStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000D25C File Offset: 0x0000B45C
		public unsafe INativePropertyInfoStruct Wrap(Il2CppPropertyInfo* ptr)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4356a7af7f8147b79f2ed4ab0c268438 == 0)
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
			return new NativePropertyInfoStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000D2C4 File Offset: 0x0000B4C4
		public NativePropertyInfoStructHandler_24_0()
		{
			NativePropertyInfoStructHandler_24_0.j8I4I9YEkMUroFKTRNk();
			NativePropertyInfoStructHandler_24_0.gv1OAWYBdkwYYhKfZpG();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_22f9ae9a49f143d7bbb3b03eb2446c0f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000D328 File Offset: 0x0000B528
		// Note: this type is marked as 'beforefieldinit'.
		static NativePropertyInfoStructHandler_24_0()
		{
			NativePropertyInfoStructHandler_24_0.tnGBEQYG3lVXkohZZMB();
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000D338 File Offset: 0x0000B538
		internal static IntPtr gKXX88YwBlkskcNfujD(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000D34C File Offset: 0x0000B54C
		internal static bool J5AAT3Ydb3Y9gJH5mo7()
		{
			return NativePropertyInfoStructHandler_24_0.ENdq9rYIuQwsikJWO1C == null;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000D360 File Offset: 0x0000B560
		internal static NativePropertyInfoStructHandler_24_0 zRFQqxYiwk1t1b9x3iO()
		{
			return NativePropertyInfoStructHandler_24_0.ENdq9rYIuQwsikJWO1C;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000D370 File Offset: 0x0000B570
		internal static void j8I4I9YEkMUroFKTRNk()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000D380 File Offset: 0x0000B580
		internal static void gv1OAWYBdkwYYhKfZpG()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000D390 File Offset: 0x0000B590
		internal static void tnGBEQYG3lVXkohZZMB()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000121 RID: 289
		internal static NativePropertyInfoStructHandler_24_0 ENdq9rYIuQwsikJWO1C;

		// Token: 0x0200004F RID: 79
		internal struct Il2CppPropertyInfo_24_0
		{
			// Token: 0x04000122 RID: 290
			public unsafe Il2CppClass* parent;

			// Token: 0x04000123 RID: 291
			public unsafe byte* name;

			// Token: 0x04000124 RID: 292
			public unsafe Il2CppMethodInfo* get;

			// Token: 0x04000125 RID: 293
			public unsafe Il2CppMethodInfo* set;

			// Token: 0x04000126 RID: 294
			public uint attrs;

			// Token: 0x04000127 RID: 295
			public uint token;
		}

		// Token: 0x02000050 RID: 80
		internal class NativeStructWrapper : INativePropertyInfoStruct, INativeStruct
		{
			// Token: 0x0600032F RID: 815 RVA: 0x00018740 File Offset: 0x00016940
			public NativeStructWrapper(IntPtr ptr)
			{
				NativePropertyInfoStructHandler_24_0.NativeStructWrapper.gXs5S1slEtFDRWZSM8T();
				NativePropertyInfoStructHandler_24_0.NativeStructWrapper.Jx2E0tsqEPhWagd9X21();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b169d8ea412f45e99e430384ddc8908b != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3566f8d0a0994626b4e9fd660bc94d73 == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x06000330 RID: 816 RVA: 0x000187D0 File Offset: 0x000169D0
			private unsafe NativePropertyInfoStructHandler_24_0.Il2CppPropertyInfo_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x06000331 RID: 817 RVA: 0x000187E0 File Offset: 0x000169E0
			public IntPtr Pointer { get; }

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x06000332 RID: 818 RVA: 0x000187F0 File Offset: 0x000169F0
			public unsafe Il2CppPropertyInfo* PropertyInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x06000333 RID: 819 RVA: 0x00018800 File Offset: 0x00016A00
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x06000334 RID: 820 RVA: 0x00018818 File Offset: 0x00016A18
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x06000335 RID: 821 RVA: 0x0001882C File Offset: 0x00016A2C
			public unsafe ref Il2CppMethodInfo* Get
			{
				get
				{
					return ref this._->get;
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x06000336 RID: 822 RVA: 0x00018840 File Offset: 0x00016A40
			public unsafe ref Il2CppMethodInfo* Set
			{
				get
				{
					return ref this._->set;
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x06000337 RID: 823 RVA: 0x00018854 File Offset: 0x00016A54
			public unsafe ref uint Attrs
			{
				get
				{
					return ref this._->attrs;
				}
			}

			// Token: 0x06000338 RID: 824 RVA: 0x00018868 File Offset: 0x00016A68
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativePropertyInfoStructHandler_24_0.NativeStructWrapper.Ow7HHms5995Qw6QOkwQ();
			}

			// Token: 0x06000339 RID: 825 RVA: 0x00018878 File Offset: 0x00016A78
			internal static void gXs5S1slEtFDRWZSM8T()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600033A RID: 826 RVA: 0x00018888 File Offset: 0x00016A88
			internal static void Jx2E0tsqEPhWagd9X21()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x0600033B RID: 827 RVA: 0x00018898 File Offset: 0x00016A98
			internal static bool b5wW4K0ZMqImmErxmow()
			{
				return NativePropertyInfoStructHandler_24_0.NativeStructWrapper.HLOBar0au6nT5tYnEHC == null;
			}

			// Token: 0x0600033C RID: 828 RVA: 0x000188AC File Offset: 0x00016AAC
			internal static NativePropertyInfoStructHandler_24_0.NativeStructWrapper vTBR2O0zLnEScqVQSsU()
			{
				return NativePropertyInfoStructHandler_24_0.NativeStructWrapper.HLOBar0au6nT5tYnEHC;
			}

			// Token: 0x0600033D RID: 829 RVA: 0x000188BC File Offset: 0x00016ABC
			internal static void Ow7HHms5995Qw6QOkwQ()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000129 RID: 297
			private static object HLOBar0au6nT5tYnEHC;
		}
	}
}
