using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x0200007C RID: 124
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeImageStructHandler_16_0 : INativeImageStructHandler, INativeStructHandler
	{
		// Token: 0x060004D7 RID: 1239 RVA: 0x0000F340 File Offset: 0x0000D540
		public int Size()
		{
			return sizeof(NativeImageStructHandler_16_0.Il2CppImage_16_0);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0000F350 File Offset: 0x0000D550
		public unsafe INativeImageStruct CreateNewStruct()
		{
			NativeImageStructHandler_16_0.Il2CppImage_16_0* ptr2;
			IntPtr ptr = ptr2 = NativeImageStructHandler_16_0.waSrYUu04qJVNq6OqbS(this.Size());
			*ptr2 = default(NativeImageStructHandler_16_0.Il2CppImage_16_0);
			return new NativeImageStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0000F380 File Offset: 0x0000D580
		public unsafe INativeImageStruct Wrap(Il2CppImage* ptr)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2f48f5515514b5a9a5feed6dc9a8dce != 0)
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
			return new NativeImageStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0000F3E8 File Offset: 0x0000D5E8
		public NativeImageStructHandler_16_0()
		{
			NativeImageStructHandler_16_0.lwQvycuNPjHUCFLSIbG();
			NativeImageStructHandler_16_0.M0CaP2uunEo3kcmVPjv();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9a3e85e731764e36a5b07f4e692becd8 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0000F44C File Offset: 0x0000D64C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeImageStructHandler_16_0()
		{
			NativeImageStructHandler_16_0.fUQJHIuEko2WMaeWup4();
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0000F45C File Offset: 0x0000D65C
		internal static IntPtr waSrYUu04qJVNq6OqbS(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0000F470 File Offset: 0x0000D670
		internal static bool tPRGcmuhnZojrrLtDu1()
		{
			return NativeImageStructHandler_16_0.lWn2xouxeHgSyBemwuc == null;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0000F484 File Offset: 0x0000D684
		internal static NativeImageStructHandler_16_0 zHYTJiu8BjtNTpLTyvK()
		{
			return NativeImageStructHandler_16_0.lWn2xouxeHgSyBemwuc;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0000F494 File Offset: 0x0000D694
		internal static void lwQvycuNPjHUCFLSIbG()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0000F4A4 File Offset: 0x0000D6A4
		internal static void M0CaP2uunEo3kcmVPjv()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0000F4B4 File Offset: 0x0000D6B4
		internal static void fUQJHIuEko2WMaeWup4()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000207 RID: 519
		private static NativeImageStructHandler_16_0 lWn2xouxeHgSyBemwuc;

		// Token: 0x0200007D RID: 125
		internal struct Il2CppImage_16_0
		{
			// Token: 0x04000208 RID: 520
			public unsafe byte* name;

			// Token: 0x04000209 RID: 521
			public int assemblyIndex;

			// Token: 0x0400020A RID: 522
			public int typeStart;

			// Token: 0x0400020B RID: 523
			public uint typeCount;

			// Token: 0x0400020C RID: 524
			public int entryPointIndex;

			// Token: 0x0400020D RID: 525
			public unsafe void* nameToClassHashTable;
		}

		// Token: 0x0200007E RID: 126
		internal class NativeStructWrapper : INativeImageStruct, INativeStruct
		{
			// Token: 0x060004E2 RID: 1250 RVA: 0x0001B910 File Offset: 0x00019B10
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeImageStructHandler_16_0.NativeStructWrapper.fo8DKWrJ1qb0V1x9lyZ();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_99cea5f9c4c245c2a5f184ab2e57fafc != 0)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bacedfb8a3cf4671ae3e03ec2f965495 == 0)
					{
						num = 0;
					}
				}
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0001B9A0 File Offset: 0x00019BA0
			private unsafe NativeImageStructHandler_16_0.Il2CppImage_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x060004E4 RID: 1252 RVA: 0x0001B9B0 File Offset: 0x00019BB0
			public IntPtr Pointer { get; }

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0001B9C0 File Offset: 0x00019BC0
			public unsafe Il2CppImage* ImagePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x060004E6 RID: 1254 RVA: 0x0001B9D0 File Offset: 0x00019BD0
			public bool HasNameNoExt
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0001B9DC File Offset: 0x00019BDC
			public unsafe ref Il2CppAssembly* Assembly
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0001B9EC File Offset: 0x00019BEC
			public ref byte Dynamic
			{
				get
				{
					return ref this._dynamicDummy;
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x060004E9 RID: 1257 RVA: 0x0001B9FC File Offset: 0x00019BFC
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x060004EA RID: 1258 RVA: 0x0001BA14 File Offset: 0x00019C14
			public ref IntPtr NameNoExt
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x060004EB RID: 1259 RVA: 0x0001BA24 File Offset: 0x00019C24
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeImageStructHandler_16_0.NativeStructWrapper.Fu1NW4rWtpslF4SYPHu();
			}

			// Token: 0x060004EC RID: 1260 RVA: 0x0001BA34 File Offset: 0x00019C34
			internal static void fo8DKWrJ1qb0V1x9lyZ()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060004ED RID: 1261 RVA: 0x0001BA44 File Offset: 0x00019C44
			internal static bool zpiq1RrR9ob4M7ooFrv()
			{
				return NativeImageStructHandler_16_0.NativeStructWrapper.D0SZFdr7wVrlFMCPKU1 == null;
			}

			// Token: 0x060004EE RID: 1262 RVA: 0x0001BA58 File Offset: 0x00019C58
			internal static NativeImageStructHandler_16_0.NativeStructWrapper spRmUprkDimeF9pvXry()
			{
				return NativeImageStructHandler_16_0.NativeStructWrapper.D0SZFdr7wVrlFMCPKU1;
			}

			// Token: 0x060004EF RID: 1263 RVA: 0x0001BA68 File Offset: 0x00019C68
			internal static void Fu1NW4rWtpslF4SYPHu()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0400020E RID: 526
			private byte _dynamicDummy;

			// Token: 0x04000210 RID: 528
			internal static object D0SZFdr7wVrlFMCPKU1;
		}
	}
}
