using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.ParameterInfo
{
	// Token: 0x0200005B RID: 91
	[ApplicableToUnityVersionsSince("2021.2.0")]
	internal class NativeParameterInfoStructHandler_27_3 : INativeParameterInfoStructHandler, INativeStructHandler
	{
		// Token: 0x0600039E RID: 926 RVA: 0x0000E5E8 File Offset: 0x0000C7E8
		public int Size()
		{
			return sizeof(NativeParameterInfoStructHandler_27_3.Il2CppParameterInfo_27_3);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
		public unsafe Il2CppParameterInfo*[] CreateNewParameterInfoArray(int paramCount)
		{
			int num = 2;
			int num2 = num;
			Il2CppParameterInfo*[] array;
			for (;;)
			{
				NativeParameterInfoStructHandler_27_3.Il2CppParameterInfo_27_3* ptr;
				int num3;
				switch (num2)
				{
				case 0:
					goto IL_13C;
				case 1:
					array = new Il2CppParameterInfo*[paramCount];
					num2 = 7;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_806dbdb7f5194c2fa0c07a915df13fc8 != 0)
					{
						num2 = 7;
						continue;
					}
					continue;
				case 2:
					ptr = NativeParameterInfoStructHandler_27_3.F6pwv9NJ4I92WpsUsmt(Marshal.SizeOf<NativeParameterInfoStructHandler_27_3.Il2CppParameterInfo_27_3>() * paramCount);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c733963b5aa3462f9be5a2d711359fa7 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					break;
				case 4:
					num3++;
					num2 = 3;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_18558c8f0d4f4774910664df1c51bd49 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 5:
					break;
				case 6:
					goto IL_160;
				case 7:
					num3 = 0;
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3cdc0c80f3644c499e0bcd7810be1cee != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 8:
					return array;
				case 9:
					array[num3] = (Il2CppParameterInfo*)(ptr + num3);
					num2 = 4;
					continue;
				default:
					goto IL_13C;
				}
				if (num3 >= paramCount)
				{
					break;
				}
				num2 = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c2ad52141772446383547acade021f9a != 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_160:
				ptr[num3] = default(NativeParameterInfoStructHandler_27_3.Il2CppParameterInfo_27_3);
				num2 = 9;
				continue;
				IL_13C:
				goto IL_160;
			}
			return array;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000E784 File Offset: 0x0000C984
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc != 0)
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

		// Token: 0x060003A1 RID: 929 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_37633ff27b934257920d0d03faf0bd54 != 0)
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
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0000E864 File Offset: 0x0000CA64
		public bool HasNamePosToken
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000E870 File Offset: 0x0000CA70
		public NativeParameterInfoStructHandler_27_3()
		{
			NativeParameterInfoStructHandler_27_3.NAUm7GNWgLlXa5PYRkt();
			NativeParameterInfoStructHandler_27_3.dSRYsQNrwCVNSqYT29N();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c1d51581d05f41579ee6e476d9be288e == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000E8D4 File Offset: 0x0000CAD4
		// Note: this type is marked as 'beforefieldinit'.
		static NativeParameterInfoStructHandler_27_3()
		{
			NativeParameterInfoStructHandler_27_3.STvIevNDGLj18XyjVn2();
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000E8E4 File Offset: 0x0000CAE4
		internal static IntPtr F6pwv9NJ4I92WpsUsmt(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000E8F8 File Offset: 0x0000CAF8
		internal static bool secQ7ENRDqFjunbIlvv()
		{
			return NativeParameterInfoStructHandler_27_3.xgamWsN7FHy4QcW6Trl == null;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000E90C File Offset: 0x0000CB0C
		internal static NativeParameterInfoStructHandler_27_3 Eamt1HNkDNQaffXkHt9()
		{
			return NativeParameterInfoStructHandler_27_3.xgamWsN7FHy4QcW6Trl;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000E91C File Offset: 0x0000CB1C
		internal static void NAUm7GNWgLlXa5PYRkt()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000E92C File Offset: 0x0000CB2C
		internal static void dSRYsQNrwCVNSqYT29N()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000E93C File Offset: 0x0000CB3C
		internal static void STvIevNDGLj18XyjVn2()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000144 RID: 324
		private static object xgamWsN7FHy4QcW6Trl;

		// Token: 0x0200005C RID: 92
		internal struct Il2CppParameterInfo_27_3
		{
			// Token: 0x04000145 RID: 325
			public unsafe Il2CppTypeStruct* parameter_type;
		}

		// Token: 0x0200005D RID: 93
		internal class NativeParameterInfoStructWrapper : INativeParameterInfoStruct, INativeStruct
		{
			// Token: 0x060003AB RID: 939 RVA: 0x000198A0 File Offset: 0x00017AA0
			public NativeParameterInfoStructWrapper(IntPtr pointer)
			{
				NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper.DTDVMZJzalJ11F6oP6u();
				NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper.kqQxCBWHVEqs08cIARW();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b8a2996bc299402b995470e3e8286d42 == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6e39fb1a8feb46889b60abcfbb34e0df == 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x060003AC RID: 940 RVA: 0x00019930 File Offset: 0x00017B30
			private unsafe NativeParameterInfoStructHandler_27_3.Il2CppParameterInfo_27_3* NativeParameter
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x060003AD RID: 941 RVA: 0x00019940 File Offset: 0x00017B40
			public IntPtr Pointer { get; }

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x060003AE RID: 942 RVA: 0x00019950 File Offset: 0x00017B50
			public unsafe Il2CppParameterInfo* ParameterInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x060003AF RID: 943 RVA: 0x00019960 File Offset: 0x00017B60
			public bool HasNamePosToken
			{
				get
				{
					return false;
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x060003B0 RID: 944 RVA: 0x0001996C File Offset: 0x00017B6C
			public ref IntPtr Name
			{
				get
				{
					throw new NotSupportedException(NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper.YvSeSLWAbD12PWuVsqv(-1468223714 ^ -1786469099 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b8a2996bc299402b995470e3e8286d42));
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x060003B1 RID: 945 RVA: 0x00019998 File Offset: 0x00017B98
			public ref int Position
			{
				get
				{
					throw new NotSupportedException(NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper.YvSeSLWAbD12PWuVsqv(1668275920 ^ 1412315492 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4ab786fa8604298818cd412db8f702f));
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x060003B2 RID: 946 RVA: 0x000199C4 File Offset: 0x00017BC4
			public ref uint Token
			{
				get
				{
					throw new NotSupportedException(hIDAYxH6DWLHIthQgC.gSCeTtiku(-864128026 ^ -819348603 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9a3e85e731764e36a5b07f4e692becd8));
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x060003B3 RID: 947 RVA: 0x000199F0 File Offset: 0x00017BF0
			public unsafe ref Il2CppTypeStruct* ParameterType
			{
				get
				{
					return ref this.NativeParameter->parameter_type;
				}
			}

			// Token: 0x060003B4 RID: 948 RVA: 0x00019A04 File Offset: 0x00017C04
			// Note: this type is marked as 'beforefieldinit'.
			static NativeParameterInfoStructWrapper()
			{
				NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper.NQROH4WU0irwFJht5Et();
			}

			// Token: 0x060003B5 RID: 949 RVA: 0x00019A14 File Offset: 0x00017C14
			internal static void DTDVMZJzalJ11F6oP6u()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x00019A24 File Offset: 0x00017C24
			internal static void kqQxCBWHVEqs08cIARW()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x060003B7 RID: 951 RVA: 0x00019A34 File Offset: 0x00017C34
			internal static bool lObWWfJpCZh5FJ9wIHg()
			{
				return NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper.IlV8FJJMqooWdJO1SqD == null;
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x00019A48 File Offset: 0x00017C48
			internal static NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper wEYEIiJ4LRHynRp5Bvj()
			{
				return NativeParameterInfoStructHandler_27_3.NativeParameterInfoStructWrapper.IlV8FJJMqooWdJO1SqD;
			}

			// Token: 0x060003B9 RID: 953 RVA: 0x00019A58 File Offset: 0x00017C58
			internal static object YvSeSLWAbD12PWuVsqv(int \u0020)
			{
				return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
			}

			// Token: 0x060003BA RID: 954 RVA: 0x00019A6C File Offset: 0x00017C6C
			internal static void NQROH4WU0irwFJht5Et()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000147 RID: 327
			private static object IlV8FJJMqooWdJO1SqD;
		}
	}
}
