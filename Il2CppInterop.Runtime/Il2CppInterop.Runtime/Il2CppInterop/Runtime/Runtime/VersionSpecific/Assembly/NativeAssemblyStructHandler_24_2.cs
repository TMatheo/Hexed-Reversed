using System;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Assembly
{
	// Token: 0x02000115 RID: 277
	[ApplicableToUnityVersionsSince("2018.4.34")]
	public class NativeAssemblyStructHandler_24_2 : INativeAssemblyStructHandler, INativeStructHandler
	{
		// Token: 0x06000C3D RID: 3133 RVA: 0x00012804 File Offset: 0x00010A04
		public int Size()
		{
			return sizeof(NativeAssemblyStructHandler_24_2.Il2CppAssembly_24_2);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00012814 File Offset: 0x00010A14
		public unsafe INativeAssemblyStruct CreateNewStruct()
		{
			NativeAssemblyStructHandler_24_2.Il2CppAssembly_24_2* ptr2;
			IntPtr ptr = ptr2 = NativeAssemblyStructHandler_24_2.zyXwQgJWt1fONZyKOJw(this.Size());
			*ptr2 = default(NativeAssemblyStructHandler_24_2.Il2CppAssembly_24_2);
			return new NativeAssemblyStructHandler_24_2.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00012844 File Offset: 0x00010A44
		public unsafe INativeAssemblyStruct Wrap(Il2CppAssembly* ptr)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4c6a46c0a2d14747aa1dc5bf1581154d != 0)
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
			return new NativeAssemblyStructHandler_24_2.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x000128AC File Offset: 0x00010AAC
		public NativeAssemblyStructHandler_24_2()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeAssemblyStructHandler_24_2.bLkwDiJCoRL8guKshQm();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3bc41e98a8e849aea1e93dfe0f04c43b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00012910 File Offset: 0x00010B10
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAssemblyStructHandler_24_2()
		{
			NativeAssemblyStructHandler_24_2.QugAN9J9jnaVH55pLiA();
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00012920 File Offset: 0x00010B20
		internal static IntPtr zyXwQgJWt1fONZyKOJw(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x00012934 File Offset: 0x00010B34
		internal static bool jwbTR3JRqs9sgFRnwmE()
		{
			return NativeAssemblyStructHandler_24_2.OqfBwBJFXDpiX5O0Eoc == null;
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x00012948 File Offset: 0x00010B48
		internal static NativeAssemblyStructHandler_24_2 BXq0agJMbhRi8ofRtxP()
		{
			return NativeAssemblyStructHandler_24_2.OqfBwBJFXDpiX5O0Eoc;
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x00012958 File Offset: 0x00010B58
		internal static void bLkwDiJCoRL8guKshQm()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x00012968 File Offset: 0x00010B68
		internal static void QugAN9J9jnaVH55pLiA()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400093A RID: 2362
		internal static NativeAssemblyStructHandler_24_2 OqfBwBJFXDpiX5O0Eoc;

		// Token: 0x02000116 RID: 278
		internal struct Il2CppAssembly_24_2
		{
			// Token: 0x0400093B RID: 2363
			public unsafe Il2CppImage* image;

			// Token: 0x0400093C RID: 2364
			public uint token;

			// Token: 0x0400093D RID: 2365
			public int referencedAssemblyStart;

			// Token: 0x0400093E RID: 2366
			public int referencedAssemblyCount;

			// Token: 0x0400093F RID: 2367
			public NativeAssemblyNameStructHandler_24_1.Il2CppAssemblyName_24_1 aname;
		}

		// Token: 0x02000117 RID: 279
		internal class NativeStructWrapper : INativeAssemblyStruct, INativeStruct
		{
			// Token: 0x06000C47 RID: 3143 RVA: 0x000275DC File Offset: 0x000257DC
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeAssemblyStructHandler_24_2.NativeStructWrapper.GyHysf4r3cRR3ruHWNv();
				NativeAssemblyStructHandler_24_2.NativeStructWrapper.qHnnty4TKThFCJPOc8G();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bc2bbd892f074260abf5aaa8b1124d64 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2adb3ca441e493aba80425bcc0f1db3 != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x170004A1 RID: 1185
			// (get) Token: 0x06000C48 RID: 3144 RVA: 0x0002766C File Offset: 0x0002586C
			private unsafe NativeAssemblyStructHandler_24_2.Il2CppAssembly_24_2* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170004A2 RID: 1186
			// (get) Token: 0x06000C49 RID: 3145 RVA: 0x0002767C File Offset: 0x0002587C
			public IntPtr Pointer { get; }

			// Token: 0x170004A3 RID: 1187
			// (get) Token: 0x06000C4A RID: 3146 RVA: 0x0002768C File Offset: 0x0002588C
			public unsafe Il2CppAssembly* AssemblyPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170004A4 RID: 1188
			// (get) Token: 0x06000C4B RID: 3147 RVA: 0x0002769C File Offset: 0x0002589C
			// (set) Token: 0x06000C4C RID: 3148 RVA: 0x000276B8 File Offset: 0x000258B8
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
						case 1:
							this._->aname = *(NativeAssemblyNameStructHandler_24_1.Il2CppAssemblyName_24_1*)this.Name.AssemblyNamePointer;
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2356ac6ca5954f1897cd5bbbe0161ae5 == 0)
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

			// Token: 0x170004A5 RID: 1189
			// (get) Token: 0x06000C4D RID: 3149 RVA: 0x0002772C File Offset: 0x0002592C
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x06000C4E RID: 3150 RVA: 0x00027740 File Offset: 0x00025940
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000C4F RID: 3151 RVA: 0x00027750 File Offset: 0x00025950
			internal static void GyHysf4r3cRR3ruHWNv()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000C50 RID: 3152 RVA: 0x00027760 File Offset: 0x00025960
			internal static void qHnnty4TKThFCJPOc8G()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000C51 RID: 3153 RVA: 0x00027770 File Offset: 0x00025970
			internal static bool I6lTko4BRMl7RJy9OW2()
			{
				return NativeAssemblyStructHandler_24_2.NativeStructWrapper.ikpxsM4EcyRCgEbvI76 == null;
			}

			// Token: 0x06000C52 RID: 3154 RVA: 0x00027784 File Offset: 0x00025984
			internal static NativeAssemblyStructHandler_24_2.NativeStructWrapper B8U8fT4GawE9JHGyq7X()
			{
				return NativeAssemblyStructHandler_24_2.NativeStructWrapper.ikpxsM4EcyRCgEbvI76;
			}

			// Token: 0x04000941 RID: 2369
			internal static object ikpxsM4EcyRCgEbvI76;
		}
	}
}
