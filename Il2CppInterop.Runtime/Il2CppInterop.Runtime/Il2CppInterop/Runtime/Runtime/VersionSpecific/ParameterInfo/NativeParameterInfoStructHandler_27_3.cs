using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.ParameterInfo
{
	// Token: 0x02000059 RID: 89
	[ApplicableToUnityVersionsSince("2021.2.0")]
	internal class NativeParameterInfoStructHandler_27_3 : INativeParameterInfoStructHandler, INativeStructHandler
	{
		// Token: 0x0600037C RID: 892 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		public int Size()
		{
			return sizeof(NativeParameterInfoStructHandler_27_3.Il2CppParameterInfo_27_3);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000DA08 File Offset: 0x0000BC08
		public unsafe Il2CppParameterInfo*[] CreateNewParameterInfoArray(int paramCount)
		{
			int num = 1;
			int num2 = num;
			Il2CppParameterInfo*[] array;
			for (;;)
			{
				NativeParameterInfoStructHandler_27_3.Il2CppParameterInfo_27_3* ptr;
				int num3;
				switch (num2)
				{
				case 0:
					goto IL_16B;
				case 1:
					ptr = NativeParameterInfoStructHandler_27_3.S32Oue8HlMJu15aKTkG(Marshal.SizeOf<NativeParameterInfoStructHandler_27_3.Il2CppParameterInfo_27_3>() * paramCount);
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_dd9c757bd882429784d62f0e80f112e6 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					array[num3] = (Il2CppParameterInfo*)(ptr + num3);
					num2 = 7;
					continue;
				case 3:
					return array;
				case 4:
					break;
				case 5:
					goto IL_10F;
				case 6:
					num3 = 0;
					num2 = 8;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_faca03c2e5084297b7a5d894ac66fa57 != 0)
					{
						num2 = 7;
						continue;
					}
					continue;
				case 7:
					num3++;
					num2 = 5;
					continue;
				case 8:
					goto IL_10F;
				case 9:
					break;
				default:
					goto IL_16B;
				}
				ptr[num3] = default(NativeParameterInfoStructHandler_27_3.Il2CppParameterInfo_27_3);
				num2 = 2;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bc2bbd892f074260abf5aaa8b1124d64 != 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_10F:
				if (num3 >= paramCount)
				{
					break;
				}
				num2 = 9;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6d9238cad9434518b97d223669b8fe50 == 0)
				{
					num2 = 4;
					continue;
				}
				continue;
				IL_16B:
				array = new Il2CppParameterInfo*[paramCount];
				num2 = 6;
			}
			return array;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000DB94 File Offset: 0x0000BD94
		public unsafe INativeParameterInfoStruct Wrap(Il2CppParameterInfo* paramInfoPointer)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (paramInfoPointer != IntPtr.Zero)
					{
						goto IL_57;
					}
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b3f20ce588d04b909ddcdcdf767eb5d4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return null;
			IL_57:
			return new NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper(paramInfoPointer);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000DC00 File Offset: 0x0000BE00
		public unsafe INativeParameterInfoStruct Wrap(Il2CppParameterInfo* paramInfoListBegin, int index)
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
					if (paramInfoListBegin != IntPtr.Zero)
					{
						goto IL_2D;
					}
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_da5aa2d475094b06a3df3cc53bc85956 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper(paramInfoListBegin + Marshal.SizeOf<NativeParameterInfoStructHandler_27_3.Il2CppParameterInfo_27_3>() * index / sizeof(Il2CppParameterInfo));
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0000DC74 File Offset: 0x0000BE74
		public bool HasNamePosToken
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000DC80 File Offset: 0x0000BE80
		public NativeParameterInfoStructHandler_27_3()
		{
			NativeParameterInfoStructHandler_27_3.xHS2fr8h0n5Yt71goex();
			NativeParameterInfoStructHandler_27_3.KXdWAE8OkevsS7FsFEY();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_263609815aa041aea5525a459e9a816b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000DCE4 File Offset: 0x0000BEE4
		// Note: this type is marked as 'beforefieldinit'.
		static NativeParameterInfoStructHandler_27_3()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000DCF4 File Offset: 0x0000BEF4
		internal static IntPtr S32Oue8HlMJu15aKTkG(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000DD08 File Offset: 0x0000BF08
		internal static bool iiyr0Y8k0Ox5atjMTuB()
		{
			return NativeParameterInfoStructHandler_27_3.BHSCTY8clWh0rdYb8qV == null;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000DD1C File Offset: 0x0000BF1C
		internal static NativeParameterInfoStructHandler_27_3 iJZh5q82VitR86oaUUh()
		{
			return NativeParameterInfoStructHandler_27_3.BHSCTY8clWh0rdYb8qV;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000DD2C File Offset: 0x0000BF2C
		internal static void xHS2fr8h0n5Yt71goex()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000DD3C File Offset: 0x0000BF3C
		internal static void KXdWAE8OkevsS7FsFEY()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x04000139 RID: 313
		private static object BHSCTY8clWh0rdYb8qV;

		// Token: 0x0200005A RID: 90
		internal struct Il2CppParameterInfo_27_3
		{
			// Token: 0x0400013A RID: 314
			public unsafe Il2CppTypeStruct* parameter_type;
		}

		// Token: 0x0200005B RID: 91
		internal class NativeParameterInfoStructWrapper : INativeParameterInfoStruct, INativeStruct
		{
			// Token: 0x06000388 RID: 904 RVA: 0x00018BAC File Offset: 0x00016DAC
			public NativeParameterInfoStructWrapper(IntPtr pointer)
			{
				NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper.o5ctF9ssJIu8Novrv95();
				NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper.jNaitIsSo18YOGOxgLg();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c04403f838344b38b3a8911774a446ea == 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						return;
					case 1:
						this.<Pointer>k__BackingField = pointer;
						num = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_15379a47ca764a4e8e16ceaf4804e136 != 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000389 RID: 905 RVA: 0x00018C3C File Offset: 0x00016E3C
			private unsafe NativeParameterInfoStructHandler_27_3.Il2CppParameterInfo_27_3* NativeParameter
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x0600038A RID: 906 RVA: 0x00018C4C File Offset: 0x00016E4C
			public IntPtr Pointer { get; }

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x0600038B RID: 907 RVA: 0x00018C5C File Offset: 0x00016E5C
			public unsafe Il2CppParameterInfo* ParameterInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x0600038C RID: 908 RVA: 0x00018C6C File Offset: 0x00016E6C
			public bool HasNamePosToken
			{
				get
				{
					return false;
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x0600038D RID: 909 RVA: 0x00018C78 File Offset: 0x00016E78
			public ref IntPtr Name
			{
				get
				{
					throw new NotSupportedException(NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper.aTStdssNibw6PJKx5tG(~-331621286 ^ 1454124121 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6dbfd13d96434eb59d868fecd0ad1cda));
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x0600038E RID: 910 RVA: 0x00018CA4 File Offset: 0x00016EA4
			public ref int Position
			{
				get
				{
					throw new NotSupportedException(NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper.aTStdssNibw6PJKx5tG(-719654323 >> 3 ^ -559914900 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0ec1d35577cb488fb4bdfc9810c6c86f));
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x0600038F RID: 911 RVA: 0x00018CD4 File Offset: 0x00016ED4
			public ref uint Token
			{
				get
				{
					throw new NotSupportedException(NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper.aTStdssNibw6PJKx5tG(-59170696 ^ -1011021482 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5));
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000390 RID: 912 RVA: 0x00018D00 File Offset: 0x00016F00
			public unsafe ref Il2CppTypeStruct* ParameterType
			{
				get
				{
					return ref this.NativeParameter->parameter_type;
				}
			}

			// Token: 0x06000391 RID: 913 RVA: 0x00018D14 File Offset: 0x00016F14
			// Note: this type is marked as 'beforefieldinit'.
			static NativeParameterInfoStructWrapper()
			{
				NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper.zVWtBdsu8YIgi0Q4Sc2();
			}

			// Token: 0x06000392 RID: 914 RVA: 0x00018D24 File Offset: 0x00016F24
			internal static void o5ctF9ssJIu8Novrv95()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000393 RID: 915 RVA: 0x00018D34 File Offset: 0x00016F34
			internal static void jNaitIsSo18YOGOxgLg()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000394 RID: 916 RVA: 0x00018D44 File Offset: 0x00016F44
			internal static bool U4skLWsVyPGlEDG7uJy()
			{
				return NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper.RLaMtBsp2MmOyjx0Lk5 == null;
			}

			// Token: 0x06000395 RID: 917 RVA: 0x00018D58 File Offset: 0x00016F58
			internal static NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper GxxFY5s0BVTI418Kq5A()
			{
				return NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper.RLaMtBsp2MmOyjx0Lk5;
			}

			// Token: 0x06000396 RID: 918 RVA: 0x00018D68 File Offset: 0x00016F68
			internal static object aTStdssNibw6PJKx5tG(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x06000397 RID: 919 RVA: 0x00018D7C File Offset: 0x00016F7C
			internal static void zVWtBdsu8YIgi0Q4Sc2()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0400013C RID: 316
			private static object RLaMtBsp2MmOyjx0Lk5;
		}
	}
}
