using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName
{
	// Token: 0x0200011A RID: 282
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeAssemblyNameStructHandler_16_0 : INativeAssemblyNameStructHandler, INativeStructHandler
	{
		// Token: 0x06000C58 RID: 3160 RVA: 0x00012978 File Offset: 0x00010B78
		public int Size()
		{
			return sizeof(NativeAssemblyNameStructHandler_16_0.Il2CppAssemblyName_16_0);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x00012988 File Offset: 0x00010B88
		public unsafe INativeAssemblyNameStruct CreateNewStruct()
		{
			NativeAssemblyNameStructHandler_16_0.Il2CppAssemblyName_16_0* ptr2;
			IntPtr ptr = ptr2 = NativeAssemblyNameStructHandler_16_0.eL5LWhJglUUA5ojFQW1(this.Size());
			*ptr2 = default(NativeAssemblyNameStructHandler_16_0.Il2CppAssemblyName_16_0);
			return new NativeAssemblyNameStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x000129B8 File Offset: 0x00010BB8
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7dfb1d10537744ca9e949b6b3a3eac09 != 0)
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

		// Token: 0x06000C5B RID: 3163 RVA: 0x00012A20 File Offset: 0x00010C20
		public NativeAssemblyNameStructHandler_16_0()
		{
			NativeAssemblyNameStructHandler_16_0.p6jvJVJoNrBETPEUVRV();
			NativeAssemblyNameStructHandler_16_0.jOKbfhJUdsNMK7h2sMl();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4f96e4bec76a4c34a19bcff463d6dc03 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00012A84 File Offset: 0x00010C84
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAssemblyNameStructHandler_16_0()
		{
			NativeAssemblyNameStructHandler_16_0.hdPRmRJjcy6DNP6ge7m();
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00012A94 File Offset: 0x00010C94
		internal static IntPtr eL5LWhJglUUA5ojFQW1(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00012AA8 File Offset: 0x00010CA8
		internal static bool Qtd0QrJr1kH5WrHR5xy()
		{
			return NativeAssemblyNameStructHandler_16_0.w7dMGLJGBw70CuByMFF == null;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00012ABC File Offset: 0x00010CBC
		internal static NativeAssemblyNameStructHandler_16_0 H1USVDJT95cXiVD9rYD()
		{
			return NativeAssemblyNameStructHandler_16_0.w7dMGLJGBw70CuByMFF;
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00012ACC File Offset: 0x00010CCC
		internal static void p6jvJVJoNrBETPEUVRV()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00012ADC File Offset: 0x00010CDC
		internal static void jOKbfhJUdsNMK7h2sMl()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00012AEC File Offset: 0x00010CEC
		internal static void hdPRmRJjcy6DNP6ge7m()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000942 RID: 2370
		internal static NativeAssemblyNameStructHandler_16_0 w7dMGLJGBw70CuByMFF;

		// Token: 0x0200011B RID: 283
		internal struct Il2CppAssemblyName_16_0
		{
			// Token: 0x04000943 RID: 2371
			public int nameIndex;

			// Token: 0x04000944 RID: 2372
			public int cultureIndex;

			// Token: 0x04000945 RID: 2373
			public int hashValueIndex;

			// Token: 0x04000946 RID: 2374
			public int publicKeyIndex;

			// Token: 0x04000947 RID: 2375
			public uint hash_alg;

			// Token: 0x04000948 RID: 2376
			public int hash_len;

			// Token: 0x04000949 RID: 2377
			public uint flags;

			// Token: 0x0400094A RID: 2378
			public int major;

			// Token: 0x0400094B RID: 2379
			public int minor;

			// Token: 0x0400094C RID: 2380
			public int build;

			// Token: 0x0400094D RID: 2381
			public int revision;

			// Token: 0x0400094E RID: 2382
			public ulong publicKeyToken;
		}

		// Token: 0x0200011C RID: 284
		internal class NativeStructWrapper : INativeAssemblyNameStruct, INativeStruct
		{
			// Token: 0x06000C63 RID: 3171 RVA: 0x00027794 File Offset: 0x00025994
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeAssemblyNameStructHandler_16_0.NativeStructWrapper.M2mq9E4K28QKq6bCMAe();
				NativeAssemblyNameStructHandler_16_0.NativeStructWrapper.IJMX0G4a5CyGmkFUWvU();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b1a14f54e3674a8baf7d5ab6ab85764a != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_892d6b14d02a4b94bf68e8edfebcd1f5 != 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x170004A9 RID: 1193
			// (get) Token: 0x06000C64 RID: 3172 RVA: 0x00027824 File Offset: 0x00025A24
			private unsafe NativeAssemblyNameStructHandler_16_0.Il2CppAssemblyName_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170004AA RID: 1194
			// (get) Token: 0x06000C65 RID: 3173 RVA: 0x00027834 File Offset: 0x00025A34
			public IntPtr Pointer { get; }

			// Token: 0x170004AB RID: 1195
			// (get) Token: 0x06000C66 RID: 3174 RVA: 0x00027844 File Offset: 0x00025A44
			public unsafe Il2CppAssemblyName* AssemblyNamePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170004AC RID: 1196
			// (get) Token: 0x06000C67 RID: 3175 RVA: 0x00027854 File Offset: 0x00025A54
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->nameIndex);
				}
			}

			// Token: 0x170004AD RID: 1197
			// (get) Token: 0x06000C68 RID: 3176 RVA: 0x0002786C File Offset: 0x00025A6C
			public unsafe ref IntPtr Culture
			{
				get
				{
					return ref *(IntPtr*)(&this._->cultureIndex);
				}
			}

			// Token: 0x170004AE RID: 1198
			// (get) Token: 0x06000C69 RID: 3177 RVA: 0x00027884 File Offset: 0x00025A84
			public unsafe ref IntPtr PublicKey
			{
				get
				{
					return ref *(IntPtr*)(&this._->publicKeyIndex);
				}
			}

			// Token: 0x170004AF RID: 1199
			// (get) Token: 0x06000C6A RID: 3178 RVA: 0x0002789C File Offset: 0x00025A9C
			public unsafe ref int Major
			{
				get
				{
					return ref this._->major;
				}
			}

			// Token: 0x170004B0 RID: 1200
			// (get) Token: 0x06000C6B RID: 3179 RVA: 0x000278B0 File Offset: 0x00025AB0
			public unsafe ref int Minor
			{
				get
				{
					return ref this._->minor;
				}
			}

			// Token: 0x170004B1 RID: 1201
			// (get) Token: 0x06000C6C RID: 3180 RVA: 0x000278C4 File Offset: 0x00025AC4
			public unsafe ref int Build
			{
				get
				{
					return ref this._->build;
				}
			}

			// Token: 0x170004B2 RID: 1202
			// (get) Token: 0x06000C6D RID: 3181 RVA: 0x000278D8 File Offset: 0x00025AD8
			public unsafe ref int Revision
			{
				get
				{
					return ref this._->revision;
				}
			}

			// Token: 0x170004B3 RID: 1203
			// (get) Token: 0x06000C6E RID: 3182 RVA: 0x000278EC File Offset: 0x00025AEC
			public unsafe ref ulong PublicKeyToken
			{
				get
				{
					return ref this._->publicKeyToken;
				}
			}

			// Token: 0x06000C6F RID: 3183 RVA: 0x00027900 File Offset: 0x00025B00
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeAssemblyNameStructHandler_16_0.NativeStructWrapper.EjANtV4ZcRFNvyaatx4();
			}

			// Token: 0x06000C70 RID: 3184 RVA: 0x00027910 File Offset: 0x00025B10
			internal static void M2mq9E4K28QKq6bCMAe()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000C71 RID: 3185 RVA: 0x00027920 File Offset: 0x00025B20
			internal static void IJMX0G4a5CyGmkFUWvU()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000C72 RID: 3186 RVA: 0x00027930 File Offset: 0x00025B30
			internal static bool FYVTKJ4QA9dZWD6yPem()
			{
				return NativeAssemblyNameStructHandler_16_0.NativeStructWrapper.spAKjT4jLKtHj8BibZi == null;
			}

			// Token: 0x06000C73 RID: 3187 RVA: 0x00027944 File Offset: 0x00025B44
			internal static NativeAssemblyNameStructHandler_16_0.NativeStructWrapper atPE364el2EgXKrclJe()
			{
				return NativeAssemblyNameStructHandler_16_0.NativeStructWrapper.spAKjT4jLKtHj8BibZi;
			}

			// Token: 0x06000C74 RID: 3188 RVA: 0x00027954 File Offset: 0x00025B54
			internal static void EjANtV4ZcRFNvyaatx4()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000950 RID: 2384
			internal static object spAKjT4jLKtHj8BibZi;
		}
	}
}
