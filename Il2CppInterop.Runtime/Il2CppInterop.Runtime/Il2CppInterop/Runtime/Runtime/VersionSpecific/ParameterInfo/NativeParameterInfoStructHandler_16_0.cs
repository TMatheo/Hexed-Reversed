using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.ParameterInfo
{
	// Token: 0x02000055 RID: 85
	[ApplicableToUnityVersionsSince("5.3.0")]
	internal class NativeParameterInfoStructHandler_16_0 : INativeParameterInfoStructHandler, INativeStructHandler
	{
		// Token: 0x0600036A RID: 874 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		public int Size()
		{
			return sizeof(NativeParameterInfoStructHandler_16_0.Il2CppParameterInfo_16_0);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000DFF0 File Offset: 0x0000C1F0
		public unsafe Il2CppParameterInfo*[] CreateNewParameterInfoArray(int paramCount)
		{
			int num = 8;
			int num2 = num;
			Il2CppParameterInfo*[] array;
			for (;;)
			{
				int num3;
				NativeParameterInfoStructHandler_16_0.Il2CppParameterInfo_16_0* ptr;
				switch (num2)
				{
				case 1:
					num3++;
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c23fbb8072754781976c5c809c25ef15 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return array;
				case 4:
					array[num3] = (Il2CppParameterInfo*)(ptr + num3);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_084a47a7baf94bf79b9c3fbf8d684053 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					num3 = 0;
					num2 = 3;
					continue;
				case 6:
					goto IL_B3;
				case 7:
					array = new Il2CppParameterInfo*[paramCount];
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 8:
					ptr = MarshalExtend.AllocHGlobal(Marshal.SizeOf<NativeParameterInfoStructHandler_16_0.Il2CppParameterInfo_16_0>() * paramCount);
					num2 = 7;
					continue;
				}
				if (num3 >= paramCount)
				{
					num2 = 2;
					continue;
				}
				IL_B3:
				ptr[num3] = default(NativeParameterInfoStructHandler_16_0.Il2CppParameterInfo_16_0);
				num2 = 4;
			}
			return array;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000E13C File Offset: 0x0000C33C
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9c5de7c7e06f4557898ef7a8362c30ee != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeParameterInfoStructHandler_16_0.NativeParameterInfoStructWrapper(paramInfoPointer);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fdb0528b1ef843aca29153aec62fa60d == 0)
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
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0000E21C File Offset: 0x0000C41C
		public bool HasNamePosToken
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000E228 File Offset: 0x0000C428
		public NativeParameterInfoStructHandler_16_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeParameterInfoStructHandler_16_0.siXysyN0T0B1kGBKHMY();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_570d4e075bf443fcbaca8db32e007291 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000E28C File Offset: 0x0000C48C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeParameterInfoStructHandler_16_0()
		{
			NativeParameterInfoStructHandler_16_0.MNPAybNN3eyxcpIoogS();
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000E29C File Offset: 0x0000C49C
		internal static bool cf5TESNhNggBuZgOLe8()
		{
			return NativeParameterInfoStructHandler_16_0.o8H5t5NxCJn0RwhKMXa == null;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
		internal static NativeParameterInfoStructHandler_16_0 fIgqfwN8uWq7lxl4Pxo()
		{
			return NativeParameterInfoStructHandler_16_0.o8H5t5NxCJn0RwhKMXa;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000E2C0 File Offset: 0x0000C4C0
		internal static void siXysyN0T0B1kGBKHMY()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000E2D0 File Offset: 0x0000C4D0
		internal static void MNPAybNN3eyxcpIoogS()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000135 RID: 309
		private static object o8H5t5NxCJn0RwhKMXa;

		// Token: 0x02000056 RID: 86
		internal struct Il2CppParameterInfo_16_0
		{
			// Token: 0x04000136 RID: 310
			public IntPtr name;

			// Token: 0x04000137 RID: 311
			public int position;

			// Token: 0x04000138 RID: 312
			public uint token;

			// Token: 0x04000139 RID: 313
			public int customAttributeIndex;

			// Token: 0x0400013A RID: 314
			public unsafe Il2CppTypeStruct* parameter_type;
		}

		// Token: 0x02000057 RID: 87
		internal class NativeParameterInfoStructWrapper : INativeParameterInfoStruct, INativeStruct
		{
			// Token: 0x06000375 RID: 885 RVA: 0x000195A0 File Offset: 0x000177A0
			public NativeParameterInfoStructWrapper(IntPtr pointer)
			{
				NativeParameterInfoStructHandler_16_0.NativeParameterInfoStructWrapper.BO3oMWJll0QT4k163ki();
				NativeParameterInfoStructHandler_16_0.NativeParameterInfoStructWrapper.YNC4doJV4Of3UFxXWLF();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ba3f6bd5a09c47868765e25f534dbf2a != 0)
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
					this.<Pointer>k__BackingField = pointer;
					num = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c504ab11ece64b14b01df2d4c88e6e49 == 0)
					{
						num = 0;
					}
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x06000376 RID: 886 RVA: 0x00019630 File Offset: 0x00017830
			private unsafe NativeParameterInfoStructHandler_16_0.Il2CppParameterInfo_16_0* NativeParameter
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x06000377 RID: 887 RVA: 0x00019640 File Offset: 0x00017840
			public IntPtr Pointer { get; }

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x06000378 RID: 888 RVA: 0x00019650 File Offset: 0x00017850
			public unsafe Il2CppParameterInfo* ParameterInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x06000379 RID: 889 RVA: 0x00019660 File Offset: 0x00017860
			public bool HasNamePosToken
			{
				get
				{
					return true;
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x0600037A RID: 890 RVA: 0x0001966C File Offset: 0x0001786C
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref this.NativeParameter->name;
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x0600037B RID: 891 RVA: 0x00019680 File Offset: 0x00017880
			public unsafe ref int Position
			{
				get
				{
					return ref this.NativeParameter->position;
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x0600037C RID: 892 RVA: 0x00019694 File Offset: 0x00017894
			public unsafe ref uint Token
			{
				get
				{
					return ref this.NativeParameter->token;
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x0600037D RID: 893 RVA: 0x000196A8 File Offset: 0x000178A8
			public unsafe ref Il2CppTypeStruct* ParameterType
			{
				get
				{
					return ref this.NativeParameter->parameter_type;
				}
			}

			// Token: 0x0600037E RID: 894 RVA: 0x000196BC File Offset: 0x000178BC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeParameterInfoStructWrapper()
			{
				NativeParameterInfoStructHandler_16_0.NativeParameterInfoStructWrapper.S8xCirJOnwSB1hUAO6Q();
			}

			// Token: 0x0600037F RID: 895 RVA: 0x000196CC File Offset: 0x000178CC
			internal static void BO3oMWJll0QT4k163ki()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000380 RID: 896 RVA: 0x000196DC File Offset: 0x000178DC
			internal static void YNC4doJV4Of3UFxXWLF()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000381 RID: 897 RVA: 0x000196EC File Offset: 0x000178EC
			internal static bool myyBAJJSIi10yAx29N8()
			{
				return NativeParameterInfoStructHandler_16_0.NativeParameterInfoStructWrapper.SmWsfaJybvcedCIro20 == null;
			}

			// Token: 0x06000382 RID: 898 RVA: 0x00019700 File Offset: 0x00017900
			internal static NativeParameterInfoStructHandler_16_0.NativeParameterInfoStructWrapper Bwjhh4JgrrWHVsEhP84()
			{
				return NativeParameterInfoStructHandler_16_0.NativeParameterInfoStructWrapper.SmWsfaJybvcedCIro20;
			}

			// Token: 0x06000383 RID: 899 RVA: 0x00019710 File Offset: 0x00017910
			internal static void S8xCirJOnwSB1hUAO6Q()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0400013C RID: 316
			internal static object SmWsfaJybvcedCIro20;
		}
	}
}
