using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.ParameterInfo
{
	// Token: 0x02000053 RID: 83
	[ApplicableToUnityVersionsSince("5.3.0")]
	internal class NativeParameterInfoStructHandler_16_0 : INativeParameterInfoStructHandler, INativeStructHandler
	{
		// Token: 0x06000348 RID: 840 RVA: 0x0000D3A0 File Offset: 0x0000B5A0
		public int Size()
		{
			return sizeof(NativeParameterInfoStructHandler_16_0.Il2CppParameterInfo_16_0);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		public unsafe Il2CppParameterInfo*[] CreateNewParameterInfoArray(int paramCount)
		{
			int num = 1;
			Il2CppParameterInfo*[] array;
			for (;;)
			{
				int num2 = num;
				int num3;
				for (;;)
				{
					NativeParameterInfoStructHandler_16_0.Il2CppParameterInfo_16_0* ptr;
					switch (num2)
					{
					default:
						goto IL_4B;
					case 1:
						ptr = MarshalExtend.AllocHGlobal(Marshal.SizeOf<NativeParameterInfoStructHandler_16_0.Il2CppParameterInfo_16_0>() * paramCount);
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0ec1d35577cb488fb4bdfc9810c6c86f == 0)
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
						break;
					case 4:
						break;
					case 5:
						goto IL_146;
					case 6:
						goto IL_146;
					case 7:
						goto IL_61;
					case 8:
						num3 = 0;
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0272cc4de9694915be17746e515675c8 != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 9:
						return array;
					}
					ptr[num3] = default(NativeParameterInfoStructHandler_16_0.Il2CppParameterInfo_16_0);
					num2 = 2;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6d7a22a8da0c4b3e8cf479dd7edc9922 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
					IL_146:
					if (num3 >= paramCount)
					{
						return array;
					}
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_791a252a9221476faad2c6d41e84a167 != 0)
					{
						num2 = 3;
					}
				}
				IL_4B:
				array = new Il2CppParameterInfo*[paramCount];
				num = 8;
				continue;
				IL_61:
				num3++;
				num = 6;
			}
			return array;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000D52C File Offset: 0x0000B72C
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8378a46aa7ed47018832a42729b1bc3b != 0)
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
			return new NativeParameterInfoStructHandler_16_0.NativeParameterInfoStructWrapper(paramInfoPointer);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000D598 File Offset: 0x0000B798
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_575f8bd7bfb04e37800ff009689b44f6 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeParameterInfoStructHandler_16_0.NativeParameterInfoStructWrapper(paramInfoListBegin + Marshal.SizeOf<NativeParameterInfoStructHandler_16_0.Il2CppParameterInfo_16_0>() * index / sizeof(Il2CppParameterInfo));
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0000D60C File Offset: 0x0000B80C
		public bool HasNamePosToken
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000D618 File Offset: 0x0000B818
		public NativeParameterInfoStructHandler_16_0()
		{
			NativeParameterInfoStructHandler_16_0.n1DwqPYaxs8Hc7rcD0h();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000D67C File Offset: 0x0000B87C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeParameterInfoStructHandler_16_0()
		{
			NativeParameterInfoStructHandler_16_0.wHjAo8YZRax4jqlpZZ0();
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000D68C File Offset: 0x0000B88C
		internal static bool HoW0OBYefhiIrICNL4p()
		{
			return NativeParameterInfoStructHandler_16_0.x3CuC7YQGkIIPCTD57p == null;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000D6A0 File Offset: 0x0000B8A0
		internal static NativeParameterInfoStructHandler_16_0 LubUFnYKlqPKhHnuXVv()
		{
			return NativeParameterInfoStructHandler_16_0.x3CuC7YQGkIIPCTD57p;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		internal static void n1DwqPYaxs8Hc7rcD0h()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000D6C0 File Offset: 0x0000B8C0
		internal static void wHjAo8YZRax4jqlpZZ0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400012A RID: 298
		internal static object x3CuC7YQGkIIPCTD57p;

		// Token: 0x02000054 RID: 84
		internal struct Il2CppParameterInfo_16_0
		{
			// Token: 0x0400012B RID: 299
			public IntPtr name;

			// Token: 0x0400012C RID: 300
			public int position;

			// Token: 0x0400012D RID: 301
			public uint token;

			// Token: 0x0400012E RID: 302
			public int customAttributeIndex;

			// Token: 0x0400012F RID: 303
			public unsafe Il2CppTypeStruct* parameter_type;
		}

		// Token: 0x02000055 RID: 85
		internal class NativeParameterInfoStructWrapper : INativeParameterInfoStruct, INativeStruct
		{
			// Token: 0x06000353 RID: 851 RVA: 0x000188CC File Offset: 0x00016ACC
			public NativeParameterInfoStructWrapper(IntPtr pointer)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_43cc35cb254148318955c7f83ade60f1 == 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						this.<Pointer>k__BackingField = pointer;
						num = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb8decd62b945dda713f7b22b6b95ca != 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x06000354 RID: 852 RVA: 0x0001895C File Offset: 0x00016B5C
			private unsafe NativeParameterInfoStructHandler_16_0.Il2CppParameterInfo_16_0* NativeParameter
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x06000355 RID: 853 RVA: 0x0001896C File Offset: 0x00016B6C
			public IntPtr Pointer { get; }

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x06000356 RID: 854 RVA: 0x0001897C File Offset: 0x00016B7C
			public unsafe Il2CppParameterInfo* ParameterInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x06000357 RID: 855 RVA: 0x0001898C File Offset: 0x00016B8C
			public bool HasNamePosToken
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x06000358 RID: 856 RVA: 0x00018998 File Offset: 0x00016B98
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref this.NativeParameter->name;
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x06000359 RID: 857 RVA: 0x000189AC File Offset: 0x00016BAC
			public unsafe ref int Position
			{
				get
				{
					return ref this.NativeParameter->position;
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x0600035A RID: 858 RVA: 0x000189C0 File Offset: 0x00016BC0
			public unsafe ref uint Token
			{
				get
				{
					return ref this.NativeParameter->token;
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x0600035B RID: 859 RVA: 0x000189D4 File Offset: 0x00016BD4
			public unsafe ref Il2CppTypeStruct* ParameterType
			{
				get
				{
					return ref this.NativeParameter->parameter_type;
				}
			}

			// Token: 0x0600035C RID: 860 RVA: 0x000189E8 File Offset: 0x00016BE8
			// Note: this type is marked as 'beforefieldinit'.
			static NativeParameterInfoStructWrapper()
			{
				NativeParameterInfoStructHandler_16_0.NativeParameterInfoStructWrapper.tRxxx9sHCrSCLayEtU0();
			}

			// Token: 0x0600035D RID: 861 RVA: 0x000189F8 File Offset: 0x00016BF8
			internal static bool yiDm3DskTtH4spurLbA()
			{
				return NativeParameterInfoStructHandler_16_0.NativeParameterInfoStructWrapper.zPJJNusclu2Wqa0qYdy == null;
			}

			// Token: 0x0600035E RID: 862 RVA: 0x00018A0C File Offset: 0x00016C0C
			internal static NativeParameterInfoStructHandler_16_0.NativeParameterInfoStructWrapper rTl0qNs2naowAPhIqxZ()
			{
				return NativeParameterInfoStructHandler_16_0.NativeParameterInfoStructWrapper.zPJJNusclu2Wqa0qYdy;
			}

			// Token: 0x0600035F RID: 863 RVA: 0x00018A1C File Offset: 0x00016C1C
			internal static void tRxxx9sHCrSCLayEtU0()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000131 RID: 305
			private static object zPJJNusclu2Wqa0qYdy;
		}
	}
}
