using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName
{
	// Token: 0x02000122 RID: 290
	[ApplicableToUnityVersionsSince("2018.4.34")]
	public class NativeAssemblyNameStructHandler_24_1 : INativeAssemblyNameStructHandler, INativeStructHandler
	{
		// Token: 0x06000CB3 RID: 3251 RVA: 0x000138C8 File Offset: 0x00011AC8
		public int Size()
		{
			return sizeof(NativeAssemblyNameStructHandler_24_1.Il2CppAssemblyName_24_1);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x000138D8 File Offset: 0x00011AD8
		public unsafe INativeAssemblyNameStruct CreateNewStruct()
		{
			NativeAssemblyNameStructHandler_24_1.Il2CppAssemblyName_24_1* ptr2;
			IntPtr ptr = ptr2 = NativeAssemblyNameStructHandler_24_1.sAtdXp7D9bpQsyrILrZ(this.Size());
			*ptr2 = default(NativeAssemblyNameStructHandler_24_1.Il2CppAssemblyName_24_1);
			return new NativeAssemblyNameStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00013908 File Offset: 0x00011B08
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d691a76a9c4746c9a1a67e34c67ca64b != 0)
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
			return new NativeAssemblyNameStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00013970 File Offset: 0x00011B70
		public NativeAssemblyNameStructHandler_24_1()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeAssemblyNameStructHandler_24_1.pOmHd37ZSbOk3TsLXcT();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9c5de7c7e06f4557898ef7a8362c30ee == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x000139D4 File Offset: 0x00011BD4
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAssemblyNameStructHandler_24_1()
		{
			NativeAssemblyNameStructHandler_24_1.B7VFx57o4gsU8xLdodL();
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x000139E4 File Offset: 0x00011BE4
		internal static IntPtr sAtdXp7D9bpQsyrILrZ(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x000139F8 File Offset: 0x00011BF8
		internal static bool h7TyGj7W6TcnOL0kOm1()
		{
			return NativeAssemblyNameStructHandler_24_1.dgLb4f7JMIxdhsvtCQq == null;
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00013A0C File Offset: 0x00011C0C
		internal static NativeAssemblyNameStructHandler_24_1 ExMBp17r7cMsfhDJg7j()
		{
			return NativeAssemblyNameStructHandler_24_1.dgLb4f7JMIxdhsvtCQq;
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00013A1C File Offset: 0x00011C1C
		internal static void pOmHd37ZSbOk3TsLXcT()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00013A2C File Offset: 0x00011C2C
		internal static void B7VFx57o4gsU8xLdodL()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400096B RID: 2411
		internal static NativeAssemblyNameStructHandler_24_1 dgLb4f7JMIxdhsvtCQq;

		// Token: 0x02000123 RID: 291
		internal struct Il2CppAssemblyName_24_1
		{
			// Token: 0x0400096C RID: 2412
			public unsafe byte* name;

			// Token: 0x0400096D RID: 2413
			public unsafe byte* culture;

			// Token: 0x0400096E RID: 2414
			public unsafe byte* public_key;

			// Token: 0x0400096F RID: 2415
			public uint hash_alg;

			// Token: 0x04000970 RID: 2416
			public int hash_len;

			// Token: 0x04000971 RID: 2417
			public uint flags;

			// Token: 0x04000972 RID: 2418
			public int major;

			// Token: 0x04000973 RID: 2419
			public int minor;

			// Token: 0x04000974 RID: 2420
			public int build;

			// Token: 0x04000975 RID: 2421
			public int revision;

			// Token: 0x04000976 RID: 2422
			public ulong public_key_token;
		}

		// Token: 0x02000124 RID: 292
		internal class NativeStructWrapper : INativeAssemblyNameStruct, INativeStruct
		{
			// Token: 0x06000CBD RID: 3261 RVA: 0x00028778 File Offset: 0x00026978
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeAssemblyNameStructHandler_24_1.NativeStructWrapper.lCFphLdS94Eu1jml8eW();
				NativeAssemblyNameStructHandler_24_1.NativeStructWrapper.Xvdy9qdg6WTZjMkRCWd();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5a8626d471f54eba873ce59c8785d9b9 == 0)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c2ad52141772446383547acade021f9a == 0)
					{
						num = 1;
					}
				}
			}

			// Token: 0x170004BF RID: 1215
			// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00028808 File Offset: 0x00026A08
			private unsafe NativeAssemblyNameStructHandler_24_1.Il2CppAssemblyName_24_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170004C0 RID: 1216
			// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00028818 File Offset: 0x00026A18
			public IntPtr Pointer { get; }

			// Token: 0x170004C1 RID: 1217
			// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00028828 File Offset: 0x00026A28
			public unsafe Il2CppAssemblyName* AssemblyNamePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170004C2 RID: 1218
			// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00028838 File Offset: 0x00026A38
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170004C3 RID: 1219
			// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00028850 File Offset: 0x00026A50
			public unsafe ref IntPtr Culture
			{
				get
				{
					return ref *(IntPtr*)(&this._->culture);
				}
			}

			// Token: 0x170004C4 RID: 1220
			// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x00028868 File Offset: 0x00026A68
			public unsafe ref IntPtr PublicKey
			{
				get
				{
					return ref *(IntPtr*)(&this._->public_key);
				}
			}

			// Token: 0x170004C5 RID: 1221
			// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00028880 File Offset: 0x00026A80
			public unsafe ref int Major
			{
				get
				{
					return ref this._->major;
				}
			}

			// Token: 0x170004C6 RID: 1222
			// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x00028894 File Offset: 0x00026A94
			public unsafe ref int Minor
			{
				get
				{
					return ref this._->minor;
				}
			}

			// Token: 0x170004C7 RID: 1223
			// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x000288A8 File Offset: 0x00026AA8
			public unsafe ref int Build
			{
				get
				{
					return ref this._->build;
				}
			}

			// Token: 0x170004C8 RID: 1224
			// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x000288BC File Offset: 0x00026ABC
			public unsafe ref int Revision
			{
				get
				{
					return ref this._->revision;
				}
			}

			// Token: 0x170004C9 RID: 1225
			// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x000288D0 File Offset: 0x00026AD0
			public unsafe ref ulong PublicKeyToken
			{
				get
				{
					return ref this._->public_key_token;
				}
			}

			// Token: 0x06000CC9 RID: 3273 RVA: 0x000288E4 File Offset: 0x00026AE4
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000CCA RID: 3274 RVA: 0x000288F4 File Offset: 0x00026AF4
			internal static void lCFphLdS94Eu1jml8eW()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000CCB RID: 3275 RVA: 0x00028904 File Offset: 0x00026B04
			internal static void Xvdy9qdg6WTZjMkRCWd()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000CCC RID: 3276 RVA: 0x00028914 File Offset: 0x00026B14
			internal static bool CYSllDd2rYXIrBEGlc6()
			{
				return NativeAssemblyNameStructHandler_24_1.NativeStructWrapper.VC01i9dQqw9QfElGcE0 == null;
			}

			// Token: 0x06000CCD RID: 3277 RVA: 0x00028928 File Offset: 0x00026B28
			internal static NativeAssemblyNameStructHandler_24_1.NativeStructWrapper LTN7otdyM8BFGIhgMaQ()
			{
				return NativeAssemblyNameStructHandler_24_1.NativeStructWrapper.VC01i9dQqw9QfElGcE0;
			}

			// Token: 0x04000978 RID: 2424
			internal static object VC01i9dQqw9QfElGcE0;
		}
	}
}
