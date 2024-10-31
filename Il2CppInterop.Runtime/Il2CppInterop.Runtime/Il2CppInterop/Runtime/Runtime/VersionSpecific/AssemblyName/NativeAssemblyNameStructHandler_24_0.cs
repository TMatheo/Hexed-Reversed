using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName
{
	// Token: 0x0200011D RID: 285
	[ApplicableToUnityVersionsSince("2018.1.0")]
	public class NativeAssemblyNameStructHandler_24_0 : INativeAssemblyNameStructHandler, INativeStructHandler
	{
		// Token: 0x06000C75 RID: 3189 RVA: 0x00012AFC File Offset: 0x00010CFC
		public int Size()
		{
			return sizeof(NativeAssemblyNameStructHandler_24_0.Il2CppAssemblyName_24_0);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00012B0C File Offset: 0x00010D0C
		public unsafe INativeAssemblyNameStruct CreateNewStruct()
		{
			NativeAssemblyNameStructHandler_24_0.Il2CppAssemblyName_24_0* ptr2;
			IntPtr ptr = ptr2 = NativeAssemblyNameStructHandler_24_0.I6JTSRJaSY2dMyn4rl9(this.Size());
			*ptr2 = default(NativeAssemblyNameStructHandler_24_0.Il2CppAssemblyName_24_0);
			return new NativeAssemblyNameStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00012B3C File Offset: 0x00010D3C
		public unsafe INativeAssemblyNameStruct Wrap(Il2CppAssemblyName* ptr)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c26b4d3619a4457fb4121e194d9ef286 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeAssemblyNameStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00012BA4 File Offset: 0x00010DA4
		public NativeAssemblyNameStructHandler_24_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_49f6034724814fe88f4ca6e5ef134249 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00012C08 File Offset: 0x00010E08
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAssemblyNameStructHandler_24_0()
		{
			NativeAssemblyNameStructHandler_24_0.GyFkcxJZWSSZTKsjAw2();
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00012C18 File Offset: 0x00010E18
		internal static IntPtr I6JTSRJaSY2dMyn4rl9(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00012C2C File Offset: 0x00010E2C
		internal static bool Vc5cFlJeOMHRTh6NiMh()
		{
			return NativeAssemblyNameStructHandler_24_0.PeVYwlJQ96a0dVwkn0T == null;
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00012C40 File Offset: 0x00010E40
		internal static NativeAssemblyNameStructHandler_24_0 aBNdCNJK7sY7r7u75SW()
		{
			return NativeAssemblyNameStructHandler_24_0.PeVYwlJQ96a0dVwkn0T;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00012C50 File Offset: 0x00010E50
		internal static void GyFkcxJZWSSZTKsjAw2()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000951 RID: 2385
		private static NativeAssemblyNameStructHandler_24_0 PeVYwlJQ96a0dVwkn0T;

		// Token: 0x0200011E RID: 286
		internal struct Il2CppAssemblyName_24_0
		{
			// Token: 0x04000952 RID: 2386
			public unsafe byte* name;

			// Token: 0x04000953 RID: 2387
			public unsafe byte* culture;

			// Token: 0x04000954 RID: 2388
			public unsafe byte* hash_value;

			// Token: 0x04000955 RID: 2389
			public unsafe byte* public_key;

			// Token: 0x04000956 RID: 2390
			public uint hash_alg;

			// Token: 0x04000957 RID: 2391
			public int hash_len;

			// Token: 0x04000958 RID: 2392
			public uint flags;

			// Token: 0x04000959 RID: 2393
			public int major;

			// Token: 0x0400095A RID: 2394
			public int minor;

			// Token: 0x0400095B RID: 2395
			public int build;

			// Token: 0x0400095C RID: 2396
			public int revision;

			// Token: 0x0400095D RID: 2397
			public ulong public_key_token;
		}

		// Token: 0x0200011F RID: 287
		internal class NativeStructWrapper : INativeAssemblyNameStruct, INativeStruct
		{
			// Token: 0x06000C7E RID: 3198 RVA: 0x00027964 File Offset: 0x00025B64
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeAssemblyNameStructHandler_24_0.NativeStructWrapper.JSm0ys3XX9B9x0k6sFx();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8b1b71d923f0486b89239dd4a11f6d34 != 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.<Pointer>k__BackingField = ptr;
						num = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_fe27a6a8bfb848d1a3dd32bc5b1790e7 == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x170004B4 RID: 1204
			// (get) Token: 0x06000C7F RID: 3199 RVA: 0x000279F4 File Offset: 0x00025BF4
			private unsafe NativeAssemblyNameStructHandler_24_0.Il2CppAssemblyName_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170004B5 RID: 1205
			// (get) Token: 0x06000C80 RID: 3200 RVA: 0x00027A04 File Offset: 0x00025C04
			public IntPtr Pointer { get; }

			// Token: 0x170004B6 RID: 1206
			// (get) Token: 0x06000C81 RID: 3201 RVA: 0x00027A14 File Offset: 0x00025C14
			public unsafe Il2CppAssemblyName* AssemblyNamePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170004B7 RID: 1207
			// (get) Token: 0x06000C82 RID: 3202 RVA: 0x00027A24 File Offset: 0x00025C24
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170004B8 RID: 1208
			// (get) Token: 0x06000C83 RID: 3203 RVA: 0x00027A3C File Offset: 0x00025C3C
			public unsafe ref IntPtr Culture
			{
				get
				{
					return ref *(IntPtr*)(&this._->culture);
				}
			}

			// Token: 0x170004B9 RID: 1209
			// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00027A54 File Offset: 0x00025C54
			public unsafe ref IntPtr PublicKey
			{
				get
				{
					return ref *(IntPtr*)(&this._->public_key);
				}
			}

			// Token: 0x170004BA RID: 1210
			// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00027A6C File Offset: 0x00025C6C
			public unsafe ref int Major
			{
				get
				{
					return ref this._->major;
				}
			}

			// Token: 0x170004BB RID: 1211
			// (get) Token: 0x06000C86 RID: 3206 RVA: 0x00027A80 File Offset: 0x00025C80
			public unsafe ref int Minor
			{
				get
				{
					return ref this._->minor;
				}
			}

			// Token: 0x170004BC RID: 1212
			// (get) Token: 0x06000C87 RID: 3207 RVA: 0x00027A94 File Offset: 0x00025C94
			public unsafe ref int Build
			{
				get
				{
					return ref this._->build;
				}
			}

			// Token: 0x170004BD RID: 1213
			// (get) Token: 0x06000C88 RID: 3208 RVA: 0x00027AA8 File Offset: 0x00025CA8
			public unsafe ref int Revision
			{
				get
				{
					return ref this._->revision;
				}
			}

			// Token: 0x170004BE RID: 1214
			// (get) Token: 0x06000C89 RID: 3209 RVA: 0x00027ABC File Offset: 0x00025CBC
			public unsafe ref ulong PublicKeyToken
			{
				get
				{
					return ref this._->public_key_token;
				}
			}

			// Token: 0x06000C8A RID: 3210 RVA: 0x00027AD0 File Offset: 0x00025CD0
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeAssemblyNameStructHandler_24_0.NativeStructWrapper.WJ9nWL3cgnJ04jEvhCL();
			}

			// Token: 0x06000C8B RID: 3211 RVA: 0x00027AE0 File Offset: 0x00025CE0
			internal static void JSm0ys3XX9B9x0k6sFx()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000C8C RID: 3212 RVA: 0x00027AF0 File Offset: 0x00025CF0
			internal static bool jJQXXJ3ADtdxxbktuu4()
			{
				return NativeAssemblyNameStructHandler_24_0.NativeStructWrapper.nu9XoC35LEbKbmCotrV == null;
			}

			// Token: 0x06000C8D RID: 3213 RVA: 0x00027B04 File Offset: 0x00025D04
			internal static NativeAssemblyNameStructHandler_24_0.NativeStructWrapper hNt2mS3Lre8MsY7k0t2()
			{
				return NativeAssemblyNameStructHandler_24_0.NativeStructWrapper.nu9XoC35LEbKbmCotrV;
			}

			// Token: 0x06000C8E RID: 3214 RVA: 0x00027B14 File Offset: 0x00025D14
			internal static void WJ9nWL3cgnJ04jEvhCL()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0400095F RID: 2399
			private static object nu9XoC35LEbKbmCotrV;
		}
	}
}
