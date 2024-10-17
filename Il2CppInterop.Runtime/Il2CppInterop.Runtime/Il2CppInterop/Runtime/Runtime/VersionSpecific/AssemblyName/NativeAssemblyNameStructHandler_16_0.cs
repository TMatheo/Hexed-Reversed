using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName
{
	// Token: 0x0200011C RID: 284
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeAssemblyNameStructHandler_16_0 : INativeAssemblyNameStructHandler, INativeStructHandler
	{
		// Token: 0x06000C7D RID: 3197 RVA: 0x000135E4 File Offset: 0x000117E4
		public int Size()
		{
			return sizeof(NativeAssemblyNameStructHandler_16_0.Il2CppAssemblyName_16_0);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x000135F4 File Offset: 0x000117F4
		public unsafe INativeAssemblyNameStruct CreateNewStruct()
		{
			NativeAssemblyNameStructHandler_16_0.Il2CppAssemblyName_16_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeAssemblyNameStructHandler_16_0.Il2CppAssemblyName_16_0);
			return new NativeAssemblyNameStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00013624 File Offset: 0x00011824
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c4640bbaac7c4988b56f91d1b6b3f1a9 == 0)
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
			return new NativeAssemblyNameStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0001368C File Offset: 0x0001188C
		public NativeAssemblyNameStructHandler_16_0()
		{
			NativeAssemblyNameStructHandler_16_0.yyFS5M7NkGit5O4U77x();
			NativeAssemblyNameStructHandler_16_0.xUywQv7uHXfhPL7r0yl();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3ffead0113044f06b294bee6bd5e7a44 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x000136F0 File Offset: 0x000118F0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAssemblyNameStructHandler_16_0()
		{
			NativeAssemblyNameStructHandler_16_0.uQXbwL7EfutPxwqmyqT();
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00013700 File Offset: 0x00011900
		internal static bool gFbuxB78VTiilbpGaI1()
		{
			return NativeAssemblyNameStructHandler_16_0.dhV5XE7hxcsKnTaQuvq == null;
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00013714 File Offset: 0x00011914
		internal static NativeAssemblyNameStructHandler_16_0 JoZy31700C8AVTIkaGb()
		{
			return NativeAssemblyNameStructHandler_16_0.dhV5XE7hxcsKnTaQuvq;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00013724 File Offset: 0x00011924
		internal static void yyFS5M7NkGit5O4U77x()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00013734 File Offset: 0x00011934
		internal static void xUywQv7uHXfhPL7r0yl()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00013744 File Offset: 0x00011944
		internal static void uQXbwL7EfutPxwqmyqT()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400094D RID: 2381
		private static NativeAssemblyNameStructHandler_16_0 dhV5XE7hxcsKnTaQuvq;

		// Token: 0x0200011D RID: 285
		internal struct Il2CppAssemblyName_16_0
		{
			// Token: 0x0400094E RID: 2382
			public int nameIndex;

			// Token: 0x0400094F RID: 2383
			public int cultureIndex;

			// Token: 0x04000950 RID: 2384
			public int hashValueIndex;

			// Token: 0x04000951 RID: 2385
			public int publicKeyIndex;

			// Token: 0x04000952 RID: 2386
			public uint hash_alg;

			// Token: 0x04000953 RID: 2387
			public int hash_len;

			// Token: 0x04000954 RID: 2388
			public uint flags;

			// Token: 0x04000955 RID: 2389
			public int major;

			// Token: 0x04000956 RID: 2390
			public int minor;

			// Token: 0x04000957 RID: 2391
			public int build;

			// Token: 0x04000958 RID: 2392
			public int revision;

			// Token: 0x04000959 RID: 2393
			public ulong publicKeyToken;
		}

		// Token: 0x0200011E RID: 286
		internal class NativeStructWrapper : INativeAssemblyNameStruct, INativeStruct
		{
			// Token: 0x06000C87 RID: 3207 RVA: 0x000283F8 File Offset: 0x000265F8
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeAssemblyNameStructHandler_16_0.NativeStructWrapper.oNnNbldJpxXEPNA3E2F();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3af7919884e4482186590a3e6e04f119 == 0)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2210d7ca22c24335b32d80ca3ef84b8e != 0)
					{
						num = 1;
					}
				}
			}

			// Token: 0x170004A9 RID: 1193
			// (get) Token: 0x06000C88 RID: 3208 RVA: 0x00028488 File Offset: 0x00026688
			private unsafe NativeAssemblyNameStructHandler_16_0.Il2CppAssemblyName_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170004AA RID: 1194
			// (get) Token: 0x06000C89 RID: 3209 RVA: 0x00028498 File Offset: 0x00026698
			public IntPtr Pointer { get; }

			// Token: 0x170004AB RID: 1195
			// (get) Token: 0x06000C8A RID: 3210 RVA: 0x000284A8 File Offset: 0x000266A8
			public unsafe Il2CppAssemblyName* AssemblyNamePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170004AC RID: 1196
			// (get) Token: 0x06000C8B RID: 3211 RVA: 0x000284B8 File Offset: 0x000266B8
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->nameIndex);
				}
			}

			// Token: 0x170004AD RID: 1197
			// (get) Token: 0x06000C8C RID: 3212 RVA: 0x000284D0 File Offset: 0x000266D0
			public unsafe ref IntPtr Culture
			{
				get
				{
					return ref *(IntPtr*)(&this._->cultureIndex);
				}
			}

			// Token: 0x170004AE RID: 1198
			// (get) Token: 0x06000C8D RID: 3213 RVA: 0x000284E8 File Offset: 0x000266E8
			public unsafe ref IntPtr PublicKey
			{
				get
				{
					return ref *(IntPtr*)(&this._->publicKeyIndex);
				}
			}

			// Token: 0x170004AF RID: 1199
			// (get) Token: 0x06000C8E RID: 3214 RVA: 0x00028500 File Offset: 0x00026700
			public unsafe ref int Major
			{
				get
				{
					return ref this._->major;
				}
			}

			// Token: 0x170004B0 RID: 1200
			// (get) Token: 0x06000C8F RID: 3215 RVA: 0x00028514 File Offset: 0x00026714
			public unsafe ref int Minor
			{
				get
				{
					return ref this._->minor;
				}
			}

			// Token: 0x170004B1 RID: 1201
			// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00028528 File Offset: 0x00026728
			public unsafe ref int Build
			{
				get
				{
					return ref this._->build;
				}
			}

			// Token: 0x170004B2 RID: 1202
			// (get) Token: 0x06000C91 RID: 3217 RVA: 0x0002853C File Offset: 0x0002673C
			public unsafe ref int Revision
			{
				get
				{
					return ref this._->revision;
				}
			}

			// Token: 0x170004B3 RID: 1203
			// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00028550 File Offset: 0x00026750
			public unsafe ref ulong PublicKeyToken
			{
				get
				{
					return ref this._->publicKeyToken;
				}
			}

			// Token: 0x06000C93 RID: 3219 RVA: 0x00028564 File Offset: 0x00026764
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeAssemblyNameStructHandler_16_0.NativeStructWrapper.qSZq5QdWqPUGojHq8iV();
			}

			// Token: 0x06000C94 RID: 3220 RVA: 0x00028574 File Offset: 0x00026774
			internal static void oNnNbldJpxXEPNA3E2F()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000C95 RID: 3221 RVA: 0x00028584 File Offset: 0x00026784
			internal static bool leA6smdRPug0y39kxRX()
			{
				return NativeAssemblyNameStructHandler_16_0.NativeStructWrapper.Jeh7VHd7wFuSC8vTTKr == null;
			}

			// Token: 0x06000C96 RID: 3222 RVA: 0x00028598 File Offset: 0x00026798
			internal static NativeAssemblyNameStructHandler_16_0.NativeStructWrapper skZ8ptdkl88enWc7uFw()
			{
				return NativeAssemblyNameStructHandler_16_0.NativeStructWrapper.Jeh7VHd7wFuSC8vTTKr;
			}

			// Token: 0x06000C97 RID: 3223 RVA: 0x000285A8 File Offset: 0x000267A8
			internal static void qSZq5QdWqPUGojHq8iV()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0400095B RID: 2395
			private static object Jeh7VHd7wFuSC8vTTKr;
		}
	}
}
