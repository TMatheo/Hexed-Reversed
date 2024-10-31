using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName
{
	// Token: 0x02000120 RID: 288
	[ApplicableToUnityVersionsSince("2018.4.34")]
	public class NativeAssemblyNameStructHandler_24_1 : INativeAssemblyNameStructHandler, INativeStructHandler
	{
		// Token: 0x06000C8F RID: 3215 RVA: 0x00012C60 File Offset: 0x00010E60
		public int Size()
		{
			return sizeof(NativeAssemblyNameStructHandler_24_1.Il2CppAssemblyName_24_1);
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00012C70 File Offset: 0x00010E70
		public unsafe INativeAssemblyNameStruct CreateNewStruct()
		{
			NativeAssemblyNameStructHandler_24_1.Il2CppAssemblyName_24_1* ptr2;
			IntPtr ptr = ptr2 = NativeAssemblyNameStructHandler_24_1.DJHvkDp54X61cULoe9t(this.Size());
			*ptr2 = default(NativeAssemblyNameStructHandler_24_1.Il2CppAssemblyName_24_1);
			return new NativeAssemblyNameStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00012CA0 File Offset: 0x00010EA0
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_43cc35cb254148318955c7f83ade60f1 != 0)
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

		// Token: 0x06000C92 RID: 3218 RVA: 0x00012D08 File Offset: 0x00010F08
		public NativeAssemblyNameStructHandler_24_1()
		{
			NativeAssemblyNameStructHandler_24_1.U0Z5HFpAWQIMxWZMd5W();
			NativeAssemblyNameStructHandler_24_1.xnrJ4IpLYqV7o2o44G3();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8378a46aa7ed47018832a42729b1bc3b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00012D6C File Offset: 0x00010F6C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAssemblyNameStructHandler_24_1()
		{
			NativeAssemblyNameStructHandler_24_1.rgXEOEpXhlYy4wPRvYO();
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00012D7C File Offset: 0x00010F7C
		internal static IntPtr DJHvkDp54X61cULoe9t(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00012D90 File Offset: 0x00010F90
		internal static bool RO6ZkJplsnQAUfArXVh()
		{
			return NativeAssemblyNameStructHandler_24_1.k9rAM8JzRypSCwIlDn2 == null;
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00012DA4 File Offset: 0x00010FA4
		internal static NativeAssemblyNameStructHandler_24_1 f0Omeepq2v8QFCppcds()
		{
			return NativeAssemblyNameStructHandler_24_1.k9rAM8JzRypSCwIlDn2;
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00012DB4 File Offset: 0x00010FB4
		internal static void U0Z5HFpAWQIMxWZMd5W()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00012DC4 File Offset: 0x00010FC4
		internal static void xnrJ4IpLYqV7o2o44G3()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00012DD4 File Offset: 0x00010FD4
		internal static void rgXEOEpXhlYy4wPRvYO()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000960 RID: 2400
		private static NativeAssemblyNameStructHandler_24_1 k9rAM8JzRypSCwIlDn2;

		// Token: 0x02000121 RID: 289
		internal struct Il2CppAssemblyName_24_1
		{
			// Token: 0x04000961 RID: 2401
			public unsafe byte* name;

			// Token: 0x04000962 RID: 2402
			public unsafe byte* culture;

			// Token: 0x04000963 RID: 2403
			public unsafe byte* public_key;

			// Token: 0x04000964 RID: 2404
			public uint hash_alg;

			// Token: 0x04000965 RID: 2405
			public int hash_len;

			// Token: 0x04000966 RID: 2406
			public uint flags;

			// Token: 0x04000967 RID: 2407
			public int major;

			// Token: 0x04000968 RID: 2408
			public int minor;

			// Token: 0x04000969 RID: 2409
			public int build;

			// Token: 0x0400096A RID: 2410
			public int revision;

			// Token: 0x0400096B RID: 2411
			public ulong public_key_token;
		}

		// Token: 0x02000122 RID: 290
		internal class NativeStructWrapper : INativeAssemblyNameStruct, INativeStruct
		{
			// Token: 0x06000C9A RID: 3226 RVA: 0x00027B24 File Offset: 0x00025D24
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeAssemblyNameStructHandler_24_1.NativeStructWrapper.MxY56H3vsQFW2gNfjCs();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ecb3ec1520014011821df145fb87d517 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_124ad935e0834fda9ae7f452377dbe1c == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x170004BF RID: 1215
			// (get) Token: 0x06000C9B RID: 3227 RVA: 0x00027BB4 File Offset: 0x00025DB4
			private unsafe NativeAssemblyNameStructHandler_24_1.Il2CppAssemblyName_24_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170004C0 RID: 1216
			// (get) Token: 0x06000C9C RID: 3228 RVA: 0x00027BC4 File Offset: 0x00025DC4
			public IntPtr Pointer { get; }

			// Token: 0x170004C1 RID: 1217
			// (get) Token: 0x06000C9D RID: 3229 RVA: 0x00027BD4 File Offset: 0x00025DD4
			public unsafe Il2CppAssemblyName* AssemblyNamePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170004C2 RID: 1218
			// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00027BE4 File Offset: 0x00025DE4
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170004C3 RID: 1219
			// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00027BFC File Offset: 0x00025DFC
			public unsafe ref IntPtr Culture
			{
				get
				{
					return ref *(IntPtr*)(&this._->culture);
				}
			}

			// Token: 0x170004C4 RID: 1220
			// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00027C14 File Offset: 0x00025E14
			public unsafe ref IntPtr PublicKey
			{
				get
				{
					return ref *(IntPtr*)(&this._->public_key);
				}
			}

			// Token: 0x170004C5 RID: 1221
			// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00027C2C File Offset: 0x00025E2C
			public unsafe ref int Major
			{
				get
				{
					return ref this._->major;
				}
			}

			// Token: 0x170004C6 RID: 1222
			// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00027C40 File Offset: 0x00025E40
			public unsafe ref int Minor
			{
				get
				{
					return ref this._->minor;
				}
			}

			// Token: 0x170004C7 RID: 1223
			// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x00027C54 File Offset: 0x00025E54
			public unsafe ref int Build
			{
				get
				{
					return ref this._->build;
				}
			}

			// Token: 0x170004C8 RID: 1224
			// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00027C68 File Offset: 0x00025E68
			public unsafe ref int Revision
			{
				get
				{
					return ref this._->revision;
				}
			}

			// Token: 0x170004C9 RID: 1225
			// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00027C7C File Offset: 0x00025E7C
			public unsafe ref ulong PublicKeyToken
			{
				get
				{
					return ref this._->public_key_token;
				}
			}

			// Token: 0x06000CA6 RID: 3238 RVA: 0x00027C90 File Offset: 0x00025E90
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeAssemblyNameStructHandler_24_1.NativeStructWrapper.VAwZBL3xZr34JDIyfXS();
			}

			// Token: 0x06000CA7 RID: 3239 RVA: 0x00027CA0 File Offset: 0x00025EA0
			internal static void MxY56H3vsQFW2gNfjCs()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000CA8 RID: 3240 RVA: 0x00027CB0 File Offset: 0x00025EB0
			internal static bool dVngkU3OIcMilhGvB5H()
			{
				return NativeAssemblyNameStructHandler_24_1.NativeStructWrapper.P4VwKU3hXYydVm16Foq == null;
			}

			// Token: 0x06000CA9 RID: 3241 RVA: 0x00027CC4 File Offset: 0x00025EC4
			internal static NativeAssemblyNameStructHandler_24_1.NativeStructWrapper iLPVDH3twCgabjKotem()
			{
				return NativeAssemblyNameStructHandler_24_1.NativeStructWrapper.P4VwKU3hXYydVm16Foq;
			}

			// Token: 0x06000CAA RID: 3242 RVA: 0x00027CD4 File Offset: 0x00025ED4
			internal static void VAwZBL3xZr34JDIyfXS()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0400096D RID: 2413
			internal static object P4VwKU3hXYydVm16Foq;
		}
	}
}
