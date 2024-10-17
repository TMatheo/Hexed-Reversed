using System;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Assembly
{
	// Token: 0x02000111 RID: 273
	[ApplicableToUnityVersionsSince("2018.1.0")]
	public class NativeAssemblyStructHandler_24_0 : INativeAssemblyStructHandler, INativeStructHandler
	{
		// Token: 0x06000C33 RID: 3123 RVA: 0x00013168 File Offset: 0x00011368
		public int Size()
		{
			return sizeof(NativeAssemblyStructHandler_24_0.Il2CppAssembly_24_0);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00013178 File Offset: 0x00011378
		public unsafe INativeAssemblyStruct CreateNewStruct()
		{
			NativeAssemblyStructHandler_24_0.Il2CppAssembly_24_0* ptr2;
			IntPtr ptr = ptr2 = NativeAssemblyStructHandler_24_0.fUbD3GLFA0GjFtg6ryX(this.Size());
			*ptr2 = default(NativeAssemblyStructHandler_24_0.Il2CppAssembly_24_0);
			return new NativeAssemblyStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x000131A8 File Offset: 0x000113A8
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_37633ff27b934257920d0d03faf0bd54 == 0)
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
			return new NativeAssemblyStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00013210 File Offset: 0x00011410
		public NativeAssemblyStructHandler_24_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeAssemblyStructHandler_24_0.t9tUsyLKOFdFjJXKkG3();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6b13daaa4cb24d0bac4f6e72da052370 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00013274 File Offset: 0x00011474
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAssemblyStructHandler_24_0()
		{
			NativeAssemblyStructHandler_24_0.dBbObTL5piB3qPDhrr8();
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00013284 File Offset: 0x00011484
		internal static IntPtr fUbD3GLFA0GjFtg6ryX(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00013298 File Offset: 0x00011498
		internal static bool iO71GCLj7YfR4oMyA5O()
		{
			return NativeAssemblyStructHandler_24_0.rvBBxtLBG6H8Osrkx5y == null;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x000132AC File Offset: 0x000114AC
		internal static NativeAssemblyStructHandler_24_0 a06vARLTTT9f6vc8BvS()
		{
			return NativeAssemblyStructHandler_24_0.rvBBxtLBG6H8Osrkx5y;
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x000132BC File Offset: 0x000114BC
		internal static void t9tUsyLKOFdFjJXKkG3()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x000132CC File Offset: 0x000114CC
		internal static void dBbObTL5piB3qPDhrr8()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000935 RID: 2357
		internal static NativeAssemblyStructHandler_24_0 rvBBxtLBG6H8Osrkx5y;

		// Token: 0x02000112 RID: 274
		internal struct Il2CppAssembly_24_0
		{
			// Token: 0x04000936 RID: 2358
			public unsafe Il2CppImage* image;

			// Token: 0x04000937 RID: 2359
			public int customAttributeIndex;

			// Token: 0x04000938 RID: 2360
			public int referencedAssemblyStart;

			// Token: 0x04000939 RID: 2361
			public int referencedAssemblyCount;

			// Token: 0x0400093A RID: 2362
			public NativeAssemblyNameStructHandler_24_0.Il2CppAssemblyName_24_0 aname;
		}

		// Token: 0x02000113 RID: 275
		internal class NativeStructWrapper : INativeAssemblyStruct, INativeStruct
		{
			// Token: 0x06000C3D RID: 3133 RVA: 0x00027EC0 File Offset: 0x000260C0
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeAssemblyStructHandler_24_0.NativeStructWrapper.fk59SSdHRLVRnNYr69c();
				NativeAssemblyStructHandler_24_0.NativeStructWrapper.pVgOGBdADj0K2EUK6YJ();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f0601de1a406461b9e99711ec5418371 != 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d01f42186cf2421f90d71301ed147eb1 == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x17000497 RID: 1175
			// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00027F50 File Offset: 0x00026150
			private unsafe NativeAssemblyStructHandler_24_0.Il2CppAssembly_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000498 RID: 1176
			// (get) Token: 0x06000C3F RID: 3135 RVA: 0x00027F60 File Offset: 0x00026160
			public IntPtr Pointer { get; }

			// Token: 0x17000499 RID: 1177
			// (get) Token: 0x06000C40 RID: 3136 RVA: 0x00027F70 File Offset: 0x00026170
			public unsafe Il2CppAssembly* AssemblyPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700049A RID: 1178
			// (get) Token: 0x06000C41 RID: 3137 RVA: 0x00027F80 File Offset: 0x00026180
			// (set) Token: 0x06000C42 RID: 3138 RVA: 0x00027F9C File Offset: 0x0002619C
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
							this._->aname = *(NativeAssemblyNameStructHandler_24_0.Il2CppAssemblyName_24_0*)this.Name.AssemblyNamePointer;
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_afe904a262fb47328a49943b4b34b494 == 0)
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

			// Token: 0x1700049B RID: 1179
			// (get) Token: 0x06000C43 RID: 3139 RVA: 0x00028010 File Offset: 0x00026210
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x06000C44 RID: 3140 RVA: 0x00028024 File Offset: 0x00026224
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeAssemblyStructHandler_24_0.NativeStructWrapper.bIOY3kdUFpehrpoL3bY();
			}

			// Token: 0x06000C45 RID: 3141 RVA: 0x00028034 File Offset: 0x00026234
			internal static void fk59SSdHRLVRnNYr69c()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000C46 RID: 3142 RVA: 0x00028044 File Offset: 0x00026244
			internal static void pVgOGBdADj0K2EUK6YJ()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000C47 RID: 3143 RVA: 0x00028054 File Offset: 0x00026254
			internal static bool Vuq4YxP4hMx55eLmrIP()
			{
				return NativeAssemblyStructHandler_24_0.NativeStructWrapper.ic2cUfPpvw5TE7KQT45 == null;
			}

			// Token: 0x06000C48 RID: 3144 RVA: 0x00028068 File Offset: 0x00026268
			internal static NativeAssemblyStructHandler_24_0.NativeStructWrapper TksPcgPzQ7vyMSqiIPu()
			{
				return NativeAssemblyStructHandler_24_0.NativeStructWrapper.ic2cUfPpvw5TE7KQT45;
			}

			// Token: 0x06000C49 RID: 3145 RVA: 0x00028078 File Offset: 0x00026278
			internal static void bIOY3kdUFpehrpoL3bY()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0400093C RID: 2364
			internal static object ic2cUfPpvw5TE7KQT45;
		}
	}
}
