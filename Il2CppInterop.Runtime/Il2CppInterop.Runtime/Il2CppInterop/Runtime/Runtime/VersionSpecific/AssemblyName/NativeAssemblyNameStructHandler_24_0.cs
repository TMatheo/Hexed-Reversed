using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName
{
	// Token: 0x0200011F RID: 287
	[ApplicableToUnityVersionsSince("2018.1.0")]
	public class NativeAssemblyNameStructHandler_24_0 : INativeAssemblyNameStructHandler, INativeStructHandler
	{
		// Token: 0x06000C98 RID: 3224 RVA: 0x00013754 File Offset: 0x00011954
		public int Size()
		{
			return sizeof(NativeAssemblyNameStructHandler_24_0.Il2CppAssemblyName_24_0);
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00013764 File Offset: 0x00011964
		public unsafe INativeAssemblyNameStruct CreateNewStruct()
		{
			NativeAssemblyNameStructHandler_24_0.Il2CppAssemblyName_24_0* ptr2;
			IntPtr ptr = ptr2 = NativeAssemblyNameStructHandler_24_0.EMva3M77F48ODDX1GUH(this.Size());
			*ptr2 = default(NativeAssemblyNameStructHandler_24_0.Il2CppAssemblyName_24_0);
			return new NativeAssemblyNameStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00013794 File Offset: 0x00011994
		public unsafe INativeAssemblyNameStruct Wrap(Il2CppAssemblyName* ptr)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_46ba390073ec4df6883860abf17dbf6f != 0)
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
			return new NativeAssemblyNameStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x000137FC File Offset: 0x000119FC
		public NativeAssemblyNameStructHandler_24_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeAssemblyNameStructHandler_24_0.ui6gRZ7RKQOkRoaBAsR();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4e45528af4644e9b080e05d5ff6ef54 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00013860 File Offset: 0x00011A60
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAssemblyNameStructHandler_24_0()
		{
			NativeAssemblyNameStructHandler_24_0.fZVdj67krgZ2vYLauhG();
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00013870 File Offset: 0x00011A70
		internal static IntPtr EMva3M77F48ODDX1GUH(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00013884 File Offset: 0x00011A84
		internal static bool TyO6cp76gpwe2p9Q3YN()
		{
			return NativeAssemblyNameStructHandler_24_0.KaHe7Z7ccS0KEY5rF0b == null;
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00013898 File Offset: 0x00011A98
		internal static NativeAssemblyNameStructHandler_24_0 C1vGAx7LJwqBo4MXiAx()
		{
			return NativeAssemblyNameStructHandler_24_0.KaHe7Z7ccS0KEY5rF0b;
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x000138A8 File Offset: 0x00011AA8
		internal static void ui6gRZ7RKQOkRoaBAsR()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x000138B8 File Offset: 0x00011AB8
		internal static void fZVdj67krgZ2vYLauhG()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400095C RID: 2396
		private static NativeAssemblyNameStructHandler_24_0 KaHe7Z7ccS0KEY5rF0b;

		// Token: 0x02000120 RID: 288
		internal struct Il2CppAssemblyName_24_0
		{
			// Token: 0x0400095D RID: 2397
			public unsafe byte* name;

			// Token: 0x0400095E RID: 2398
			public unsafe byte* culture;

			// Token: 0x0400095F RID: 2399
			public unsafe byte* hash_value;

			// Token: 0x04000960 RID: 2400
			public unsafe byte* public_key;

			// Token: 0x04000961 RID: 2401
			public uint hash_alg;

			// Token: 0x04000962 RID: 2402
			public int hash_len;

			// Token: 0x04000963 RID: 2403
			public uint flags;

			// Token: 0x04000964 RID: 2404
			public int major;

			// Token: 0x04000965 RID: 2405
			public int minor;

			// Token: 0x04000966 RID: 2406
			public int build;

			// Token: 0x04000967 RID: 2407
			public int revision;

			// Token: 0x04000968 RID: 2408
			public ulong public_key_token;
		}

		// Token: 0x02000121 RID: 289
		internal class NativeStructWrapper : INativeAssemblyNameStruct, INativeStruct
		{
			// Token: 0x06000CA2 RID: 3234 RVA: 0x000285B8 File Offset: 0x000267B8
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeAssemblyNameStructHandler_24_0.NativeStructWrapper.XDG9T1dP99axwaBXi5S();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bd64431fd05f4961aa9b79e5bd243164 != 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_650e65d7606047fda7d187c401bdfc6e == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x170004B4 RID: 1204
			// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x00028648 File Offset: 0x00026848
			private unsafe NativeAssemblyNameStructHandler_24_0.Il2CppAssemblyName_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170004B5 RID: 1205
			// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00028658 File Offset: 0x00026858
			public IntPtr Pointer { get; }

			// Token: 0x170004B6 RID: 1206
			// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00028668 File Offset: 0x00026868
			public unsafe Il2CppAssemblyName* AssemblyNamePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170004B7 RID: 1207
			// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x00028678 File Offset: 0x00026878
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170004B8 RID: 1208
			// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00028690 File Offset: 0x00026890
			public unsafe ref IntPtr Culture
			{
				get
				{
					return ref *(IntPtr*)(&this._->culture);
				}
			}

			// Token: 0x170004B9 RID: 1209
			// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x000286A8 File Offset: 0x000268A8
			public unsafe ref IntPtr PublicKey
			{
				get
				{
					return ref *(IntPtr*)(&this._->public_key);
				}
			}

			// Token: 0x170004BA RID: 1210
			// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x000286C0 File Offset: 0x000268C0
			public unsafe ref int Major
			{
				get
				{
					return ref this._->major;
				}
			}

			// Token: 0x170004BB RID: 1211
			// (get) Token: 0x06000CAA RID: 3242 RVA: 0x000286D4 File Offset: 0x000268D4
			public unsafe ref int Minor
			{
				get
				{
					return ref this._->minor;
				}
			}

			// Token: 0x170004BC RID: 1212
			// (get) Token: 0x06000CAB RID: 3243 RVA: 0x000286E8 File Offset: 0x000268E8
			public unsafe ref int Build
			{
				get
				{
					return ref this._->build;
				}
			}

			// Token: 0x170004BD RID: 1213
			// (get) Token: 0x06000CAC RID: 3244 RVA: 0x000286FC File Offset: 0x000268FC
			public unsafe ref int Revision
			{
				get
				{
					return ref this._->revision;
				}
			}

			// Token: 0x170004BE RID: 1214
			// (get) Token: 0x06000CAD RID: 3245 RVA: 0x00028710 File Offset: 0x00026910
			public unsafe ref ulong PublicKeyToken
			{
				get
				{
					return ref this._->public_key_token;
				}
			}

			// Token: 0x06000CAE RID: 3246 RVA: 0x00028724 File Offset: 0x00026924
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeAssemblyNameStructHandler_24_0.NativeStructWrapper.O2aQfrddK7TRWVdgEWR();
			}

			// Token: 0x06000CAF RID: 3247 RVA: 0x00028734 File Offset: 0x00026934
			internal static void XDG9T1dP99axwaBXi5S()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000CB0 RID: 3248 RVA: 0x00028744 File Offset: 0x00026944
			internal static bool mM4e5OdbDAWbQ3rMq6R()
			{
				return NativeAssemblyNameStructHandler_24_0.NativeStructWrapper.mi3g1Kdo4QJhZLSmXCf == null;
			}

			// Token: 0x06000CB1 RID: 3249 RVA: 0x00028758 File Offset: 0x00026958
			internal static NativeAssemblyNameStructHandler_24_0.NativeStructWrapper WUoobodfT2SoyphM7Lg()
			{
				return NativeAssemblyNameStructHandler_24_0.NativeStructWrapper.mi3g1Kdo4QJhZLSmXCf;
			}

			// Token: 0x06000CB2 RID: 3250 RVA: 0x00028768 File Offset: 0x00026968
			internal static void O2aQfrddK7TRWVdgEWR()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0400096A RID: 2410
			private static object mi3g1Kdo4QJhZLSmXCf;
		}
	}
}
