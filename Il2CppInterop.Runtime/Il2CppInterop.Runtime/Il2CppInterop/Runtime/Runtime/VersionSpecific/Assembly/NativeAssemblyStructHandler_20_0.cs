using System;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Assembly
{
	// Token: 0x0200010C RID: 268
	[ApplicableToUnityVersionsSince("5.3.3")]
	public class NativeAssemblyStructHandler_20_0 : INativeAssemblyStructHandler, INativeStructHandler
	{
		// Token: 0x06000BFC RID: 3068 RVA: 0x000123CC File Offset: 0x000105CC
		public int Size()
		{
			return sizeof(NativeAssemblyStructHandler_20_0.Il2CppAssembly_20_0);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x000123DC File Offset: 0x000105DC
		public unsafe INativeAssemblyStruct CreateNewStruct()
		{
			NativeAssemblyStructHandler_20_0.Il2CppAssembly_20_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeAssemblyStructHandler_20_0.Il2CppAssembly_20_0);
			return new NativeAssemblyStructHandler_20_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0001240C File Offset: 0x0001060C
		public unsafe INativeAssemblyStruct Wrap(Il2CppAssembly* ptr)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ce8abd079f9447b3bade260ffc64f0b8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeAssemblyStructHandler_20_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00012474 File Offset: 0x00010674
		public NativeAssemblyStructHandler_20_0()
		{
			NativeAssemblyStructHandler_20_0.q36jK9J0poOdkHnC61c();
			NativeAssemblyStructHandler_20_0.dCem1SJsFPW74u1UtV5();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b55404cff7864ea3949f7b4156fd6ee5 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x000124D8 File Offset: 0x000106D8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAssemblyStructHandler_20_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x000124E8 File Offset: 0x000106E8
		internal static bool FFnYgAJpPg73J47Lh3c()
		{
			return NativeAssemblyStructHandler_20_0.sZN27kJJXCOGQnCvqYP == null;
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x000124FC File Offset: 0x000106FC
		internal static NativeAssemblyStructHandler_20_0 jHDJWlJVR2smENfB8vr()
		{
			return NativeAssemblyStructHandler_20_0.sZN27kJJXCOGQnCvqYP;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0001250C File Offset: 0x0001070C
		internal static void q36jK9J0poOdkHnC61c()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0001251C File Offset: 0x0001071C
		internal static void dCem1SJsFPW74u1UtV5()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x04000922 RID: 2338
		private static NativeAssemblyStructHandler_20_0 sZN27kJJXCOGQnCvqYP;

		// Token: 0x0200010D RID: 269
		internal struct Il2CppAssembly_20_0
		{
			// Token: 0x04000923 RID: 2339
			public int imageIndex;

			// Token: 0x04000924 RID: 2340
			public int customAttributeIndex;

			// Token: 0x04000925 RID: 2341
			public int referencedAssemblyStart;

			// Token: 0x04000926 RID: 2342
			public int referencedAssemblyCount;

			// Token: 0x04000927 RID: 2343
			public NativeAssemblyNameStructHandler_16_0.Il2CppAssemblyName_16_0 aname;
		}

		// Token: 0x0200010E RID: 270
		internal class NativeStructWrapper : INativeAssemblyStruct, INativeStruct
		{
			// Token: 0x06000C05 RID: 3077 RVA: 0x000270A8 File Offset: 0x000252A8
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeAssemblyStructHandler_20_0.NativeStructWrapper.kQMO3i4sELedE8EALgI();
				NativeAssemblyStructHandler_20_0.NativeStructWrapper.zX4yK64SqNlQcxmLiN5();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ff3063f9530e4a429cd27a548ab9d19d == 0)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6fe1694df7b94e7bbaa2aab21c6a82ec != 0)
					{
						num = 1;
					}
				}
			}

			// Token: 0x17000492 RID: 1170
			// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00027138 File Offset: 0x00025338
			private unsafe NativeAssemblyStructHandler_20_0.Il2CppAssembly_20_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000493 RID: 1171
			// (get) Token: 0x06000C07 RID: 3079 RVA: 0x00027148 File Offset: 0x00025348
			public IntPtr Pointer { get; }

			// Token: 0x17000494 RID: 1172
			// (get) Token: 0x06000C08 RID: 3080 RVA: 0x00027158 File Offset: 0x00025358
			public unsafe Il2CppAssembly* AssemblyPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000495 RID: 1173
			// (get) Token: 0x06000C09 RID: 3081 RVA: 0x00027168 File Offset: 0x00025368
			// (set) Token: 0x06000C0A RID: 3082 RVA: 0x00027184 File Offset: 0x00025384
			public unsafe INativeAssemblyNameStruct Name
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppAssemblyName*)(&this._->aname));
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
							this._->aname = *(NativeAssemblyNameStructHandler_16_0.Il2CppAssemblyName_16_0*)this.Name.AssemblyNamePointer;
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0272cc4de9694915be17746e515675c8 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000496 RID: 1174
			// (get) Token: 0x06000C0B RID: 3083 RVA: 0x000271F8 File Offset: 0x000253F8
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x06000C0C RID: 3084 RVA: 0x00027208 File Offset: 0x00025408
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeAssemblyStructHandler_20_0.NativeStructWrapper.JOlvDb4NM7igm8PvXvY();
			}

			// Token: 0x06000C0D RID: 3085 RVA: 0x00027218 File Offset: 0x00025418
			internal static void kQMO3i4sELedE8EALgI()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000C0E RID: 3086 RVA: 0x00027228 File Offset: 0x00025428
			internal static void zX4yK64SqNlQcxmLiN5()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000C0F RID: 3087 RVA: 0x00027238 File Offset: 0x00025438
			internal static bool FQrfPI4V0vgAmML1Kmb()
			{
				return NativeAssemblyStructHandler_20_0.NativeStructWrapper.qs7H6N4prZlTD1ot4EF == null;
			}

			// Token: 0x06000C10 RID: 3088 RVA: 0x0002724C File Offset: 0x0002544C
			internal static NativeAssemblyStructHandler_20_0.NativeStructWrapper mAoSc040gFwf1m7Bpg9()
			{
				return NativeAssemblyStructHandler_20_0.NativeStructWrapper.qs7H6N4prZlTD1ot4EF;
			}

			// Token: 0x06000C11 RID: 3089 RVA: 0x0002725C File Offset: 0x0002545C
			internal static void JOlvDb4NM7igm8PvXvY()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000929 RID: 2345
			private static object qs7H6N4prZlTD1ot4EF;
		}
	}
}
