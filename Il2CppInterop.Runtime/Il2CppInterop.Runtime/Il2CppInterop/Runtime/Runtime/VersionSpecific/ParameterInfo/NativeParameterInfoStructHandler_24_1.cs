using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.ParameterInfo
{
	// Token: 0x02000056 RID: 86
	[ApplicableToUnityVersionsSince("2018.3.0")]
	internal class NativeParameterInfoStructHandler_24_1 : INativeParameterInfoStructHandler, INativeStructHandler
	{
		// Token: 0x06000360 RID: 864 RVA: 0x0000D6D0 File Offset: 0x0000B8D0
		public int Size()
		{
			return sizeof(NativeParameterInfoStructHandler_24_1.Il2CppParameterInfo_24_1);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		public unsafe Il2CppParameterInfo*[] CreateNewParameterInfoArray(int paramCount)
		{
			int num = 8;
			int num2 = num;
			Il2CppParameterInfo*[] array;
			for (;;)
			{
				int num3;
				NativeParameterInfoStructHandler_24_1.Il2CppParameterInfo_24_1* ptr;
				switch (num2)
				{
				case 0:
					goto IL_EB;
				case 1:
					array[num3] = (Il2CppParameterInfo*)(ptr + num3);
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ff3063f9530e4a429cd27a548ab9d19d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					break;
				case 3:
					return array;
				case 4:
					break;
				case 5:
					goto IL_D9;
				case 6:
					goto IL_D9;
				case 7:
					array = new Il2CppParameterInfo*[paramCount];
					num2 = 9;
					continue;
				case 8:
					ptr = NativeParameterInfoStructHandler_24_1.ewUxYF85wQovcDLLWqh(Marshal.SizeOf<NativeParameterInfoStructHandler_24_1.Il2CppParameterInfo_24_1>() * paramCount);
					num2 = 7;
					continue;
				case 9:
					num3 = 0;
					num2 = 6;
					continue;
				default:
					goto IL_EB;
				}
				ptr[num3] = default(NativeParameterInfoStructHandler_24_1.Il2CppParameterInfo_24_1);
				num2 = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ecb3ec1520014011821df145fb87d517 == 0)
				{
					num2 = 1;
					continue;
				}
				continue;
				IL_D9:
				if (num3 < paramCount)
				{
					num2 = 2;
					continue;
				}
				break;
				IL_EB:
				num3++;
				num2 = 5;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_64a8b41e58e0491ab0e9d05ec5ed61d3 == 0)
				{
					num2 = 2;
				}
			}
			return array;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000D830 File Offset: 0x0000BA30
		public unsafe INativeParameterInfoStruct Wrap(Il2CppParameterInfo* paramInfoPointer)
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
					if (paramInfoPointer != IntPtr.Zero)
					{
						goto IL_2D;
					}
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cb2874465fa5416db806f31e03cc475c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeParameterInfoStructHandler_24_1.NativeParameterInfoStructWrapper(paramInfoPointer);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000D89C File Offset: 0x0000BA9C
		public unsafe INativeParameterInfoStruct Wrap(Il2CppParameterInfo* paramInfoListBegin, int index)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (paramInfoListBegin != IntPtr.Zero)
					{
						goto IL_57;
					}
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2356ac6ca5954f1897cd5bbbe0161ae5 != 0)
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
			return new NativeParameterInfoStructHandler_24_1.NativeParameterInfoStructWrapper(paramInfoListBegin + Marshal.SizeOf<NativeParameterInfoStructHandler_24_1.Il2CppParameterInfo_24_1>() * index / sizeof(Il2CppParameterInfo));
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0000D910 File Offset: 0x0000BB10
		public bool HasNamePosToken
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000D91C File Offset: 0x0000BB1C
		public NativeParameterInfoStructHandler_24_1()
		{
			NativeParameterInfoStructHandler_24_1.cydE098AwM4v5linrJ0();
			NativeParameterInfoStructHandler_24_1.kPFb5S8LF4a0CPr2HPG();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_856ffe7e0c9b4de88d71070d175d49fd == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000D980 File Offset: 0x0000BB80
		// Note: this type is marked as 'beforefieldinit'.
		static NativeParameterInfoStructHandler_24_1()
		{
			NativeParameterInfoStructHandler_24_1.jfq2jt8XBlTs11rT2eb();
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000D990 File Offset: 0x0000BB90
		internal static IntPtr ewUxYF85wQovcDLLWqh(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000D9A4 File Offset: 0x0000BBA4
		internal static bool vL74Us8ljLWA422yTG7()
		{
			return NativeParameterInfoStructHandler_24_1.UVt80ZYzOPMlV3jeD7y == null;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000D9B8 File Offset: 0x0000BBB8
		internal static NativeParameterInfoStructHandler_24_1 m1IlMy8q6wRSThH4Snd()
		{
			return NativeParameterInfoStructHandler_24_1.UVt80ZYzOPMlV3jeD7y;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
		internal static void cydE098AwM4v5linrJ0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000D9D8 File Offset: 0x0000BBD8
		internal static void kPFb5S8LF4a0CPr2HPG()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000D9E8 File Offset: 0x0000BBE8
		internal static void jfq2jt8XBlTs11rT2eb()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000132 RID: 306
		private static object UVt80ZYzOPMlV3jeD7y;

		// Token: 0x02000057 RID: 87
		internal struct Il2CppParameterInfo_24_1
		{
			// Token: 0x04000133 RID: 307
			public IntPtr name;

			// Token: 0x04000134 RID: 308
			public int position;

			// Token: 0x04000135 RID: 309
			public uint token;

			// Token: 0x04000136 RID: 310
			public unsafe Il2CppTypeStruct* parameter_type;
		}

		// Token: 0x02000058 RID: 88
		internal class NativeParameterInfoStructWrapper : INativeParameterInfoStruct, INativeStruct
		{
			// Token: 0x0600036D RID: 877 RVA: 0x00018A2C File Offset: 0x00016C2C
			public NativeParameterInfoStructWrapper(IntPtr pointer)
			{
				NativeParameterInfoStructHandler_24_1.NativeParameterInfoStructWrapper.GVqOBys8SHkOdDZRW2n();
				NativeParameterInfoStructHandler_24_1.NativeParameterInfoStructWrapper.yhKmAtsnXE56RxZ2Mki();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa == 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						this.<Pointer>k__BackingField = pointer;
						num = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92a7d78565474619a2c93ca9aa734139 != 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x0600036E RID: 878 RVA: 0x00018ABC File Offset: 0x00016CBC
			private unsafe NativeParameterInfoStructHandler_24_1.Il2CppParameterInfo_24_1* NativeParameter
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x0600036F RID: 879 RVA: 0x00018ACC File Offset: 0x00016CCC
			public IntPtr Pointer { get; }

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x06000370 RID: 880 RVA: 0x00018ADC File Offset: 0x00016CDC
			public unsafe Il2CppParameterInfo* ParameterInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000371 RID: 881 RVA: 0x00018AEC File Offset: 0x00016CEC
			public bool HasNamePosToken
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000372 RID: 882 RVA: 0x00018AF8 File Offset: 0x00016CF8
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref this.NativeParameter->name;
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x06000373 RID: 883 RVA: 0x00018B0C File Offset: 0x00016D0C
			public unsafe ref int Position
			{
				get
				{
					return ref this.NativeParameter->position;
				}
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06000374 RID: 884 RVA: 0x00018B20 File Offset: 0x00016D20
			public unsafe ref uint Token
			{
				get
				{
					return ref this.NativeParameter->token;
				}
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x06000375 RID: 885 RVA: 0x00018B34 File Offset: 0x00016D34
			public unsafe ref Il2CppTypeStruct* ParameterType
			{
				get
				{
					return ref this.NativeParameter->parameter_type;
				}
			}

			// Token: 0x06000376 RID: 886 RVA: 0x00018B48 File Offset: 0x00016D48
			// Note: this type is marked as 'beforefieldinit'.
			static NativeParameterInfoStructWrapper()
			{
				NativeParameterInfoStructHandler_24_1.NativeParameterInfoStructWrapper.X0un1rsb9atvflDHNut();
			}

			// Token: 0x06000377 RID: 887 RVA: 0x00018B58 File Offset: 0x00016D58
			internal static void GVqOBys8SHkOdDZRW2n()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000378 RID: 888 RVA: 0x00018B68 File Offset: 0x00016D68
			internal static void yhKmAtsnXE56RxZ2Mki()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000379 RID: 889 RVA: 0x00018B78 File Offset: 0x00016D78
			internal static bool LeQxmqsx56IUHjCTLCL()
			{
				return NativeParameterInfoStructHandler_24_1.NativeParameterInfoStructWrapper.x38V8MsveBfGk2yYTtf == null;
			}

			// Token: 0x0600037A RID: 890 RVA: 0x00018B8C File Offset: 0x00016D8C
			internal static NativeParameterInfoStructHandler_24_1.NativeParameterInfoStructWrapper GgwRIXsYEoaK0wmcMrB()
			{
				return NativeParameterInfoStructHandler_24_1.NativeParameterInfoStructWrapper.x38V8MsveBfGk2yYTtf;
			}

			// Token: 0x0600037B RID: 891 RVA: 0x00018B9C File Offset: 0x00016D9C
			internal static void X0un1rsb9atvflDHNut()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000138 RID: 312
			internal static object x38V8MsveBfGk2yYTtf;
		}
	}
}
