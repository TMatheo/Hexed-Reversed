using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x02000080 RID: 128
	[ApplicableToUnityVersionsSince("2017.1.0")]
	public class NativeImageStructHandler_24_0 : INativeImageStructHandler, INativeStructHandler
	{
		// Token: 0x060004EC RID: 1260 RVA: 0x0000EA3C File Offset: 0x0000CC3C
		public int Size()
		{
			return sizeof(NativeImageStructHandler_24_0.Il2CppImage_24_0);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0000EA4C File Offset: 0x0000CC4C
		public unsafe INativeImageStruct CreateNewStruct()
		{
			NativeImageStructHandler_24_0.Il2CppImage_24_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeImageStructHandler_24_0.Il2CppImage_24_0);
			return new NativeImageStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0000EA7C File Offset: 0x0000CC7C
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4da80845ebf7410ebbf942336f5ee27b == 0)
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
			return new NativeImageStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0000EAE4 File Offset: 0x0000CCE4
		public NativeImageStructHandler_24_0()
		{
			NativeImageStructHandler_24_0.LdrERenOvjeIoh1i4q3();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5a2f191df3714123bdeb9f5f4b416da9 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0000EB48 File Offset: 0x0000CD48
		// Note: this type is marked as 'beforefieldinit'.
		static NativeImageStructHandler_24_0()
		{
			NativeImageStructHandler_24_0.RK6u5Knt6h3ueqkpoKc();
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000EB58 File Offset: 0x0000CD58
		internal static bool VteQTHnHvpgyDZF2qeF()
		{
			return NativeImageStructHandler_24_0.McybZMn2jgiojaeutvh == null;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000EB6C File Offset: 0x0000CD6C
		internal static NativeImageStructHandler_24_0 AMDyXLnhMb8mwNLXHhE()
		{
			return NativeImageStructHandler_24_0.McybZMn2jgiojaeutvh;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0000EB7C File Offset: 0x0000CD7C
		internal static void LdrERenOvjeIoh1i4q3()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000EB8C File Offset: 0x0000CD8C
		internal static void RK6u5Knt6h3ueqkpoKc()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000211 RID: 529
		private static NativeImageStructHandler_24_0 McybZMn2jgiojaeutvh;

		// Token: 0x02000081 RID: 129
		internal struct Il2CppImage_24_0
		{
			// Token: 0x04000212 RID: 530
			public unsafe byte* name;

			// Token: 0x04000213 RID: 531
			public int assemblyIndex;

			// Token: 0x04000214 RID: 532
			public int typeStart;

			// Token: 0x04000215 RID: 533
			public uint typeCount;

			// Token: 0x04000216 RID: 534
			public int exportedTypeStart;

			// Token: 0x04000217 RID: 535
			public uint exportedTypeCount;

			// Token: 0x04000218 RID: 536
			public int entryPointIndex;

			// Token: 0x04000219 RID: 537
			public unsafe void* nameToClassHashTable;

			// Token: 0x0400021A RID: 538
			public uint token;
		}

		// Token: 0x02000082 RID: 130
		internal class NativeStructWrapper : INativeImageStruct, INativeStruct
		{
			// Token: 0x060004F5 RID: 1269 RVA: 0x0001AF48 File Offset: 0x00019148
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeImageStructHandler_24_0.NativeStructWrapper.KT66d7NtNwlum4QVmi2();
				NativeImageStructHandler_24_0.NativeStructWrapper.rxMonsNvjtWko5DSvAn();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_64a8b41e58e0491ab0e9d05ec5ed61d3 == 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						this.<Pointer>k__BackingField = ptr;
						num = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_754a6df239be4343a1e8b95a82be3f48 == 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x060004F6 RID: 1270 RVA: 0x0001AFD8 File Offset: 0x000191D8
			private unsafe NativeImageStructHandler_24_0.Il2CppImage_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0001AFE8 File Offset: 0x000191E8
			public IntPtr Pointer { get; }

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0001AFF8 File Offset: 0x000191F8
			public unsafe Il2CppImage* ImagePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0001B008 File Offset: 0x00019208
			public bool HasNameNoExt
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x060004FA RID: 1274 RVA: 0x0001B014 File Offset: 0x00019214
			public unsafe ref Il2CppAssembly* Assembly
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x060004FB RID: 1275 RVA: 0x0001B024 File Offset: 0x00019224
			public ref byte Dynamic
			{
				get
				{
					return ref this._dynamicDummy;
				}
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x060004FC RID: 1276 RVA: 0x0001B034 File Offset: 0x00019234
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x060004FD RID: 1277 RVA: 0x0001B04C File Offset: 0x0001924C
			public ref IntPtr NameNoExt
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x060004FE RID: 1278 RVA: 0x0001B05C File Offset: 0x0001925C
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x060004FF RID: 1279 RVA: 0x0001B06C File Offset: 0x0001926C
			internal static void KT66d7NtNwlum4QVmi2()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000500 RID: 1280 RVA: 0x0001B07C File Offset: 0x0001927C
			internal static void rxMonsNvjtWko5DSvAn()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000501 RID: 1281 RVA: 0x0001B08C File Offset: 0x0001928C
			internal static bool TN2nJkNhm5WCY5qY5vs()
			{
				return NativeImageStructHandler_24_0.NativeStructWrapper.Idag1rNHoQFtaDY6DCo == null;
			}

			// Token: 0x06000502 RID: 1282 RVA: 0x0001B0A0 File Offset: 0x000192A0
			internal static NativeImageStructHandler_24_0.NativeStructWrapper AL3MkdNOGeSwkCG02PU()
			{
				return NativeImageStructHandler_24_0.NativeStructWrapper.Idag1rNHoQFtaDY6DCo;
			}

			// Token: 0x0400021B RID: 539
			private byte _dynamicDummy;

			// Token: 0x0400021D RID: 541
			private static object Idag1rNHoQFtaDY6DCo;
		}
	}
}
