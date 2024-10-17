using System;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.ParameterInfo
{
	// Token: 0x02000058 RID: 88
	[ApplicableToUnityVersionsSince("2018.3.0")]
	internal class NativeParameterInfoStructHandler_24_1 : INativeParameterInfoStructHandler, INativeStructHandler
	{
		// Token: 0x06000384 RID: 900 RVA: 0x0000E2E0 File Offset: 0x0000C4E0
		public int Size()
		{
			return sizeof(NativeParameterInfoStructHandler_24_1.Il2CppParameterInfo_24_1);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000E2F0 File Offset: 0x0000C4F0
		public unsafe Il2CppParameterInfo*[] CreateNewParameterInfoArray(int paramCount)
		{
			int num = 2;
			Il2CppParameterInfo*[] array;
			for (;;)
			{
				int num2 = num;
				NativeParameterInfoStructHandler_24_1.Il2CppParameterInfo_24_1* ptr;
				int num3;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						array = new Il2CppParameterInfo*[paramCount];
						num2 = 4;
						continue;
					case 2:
						ptr = NativeParameterInfoStructHandler_24_1.W8UNvnN6Sp7chb2K32f(Marshal.SizeOf<NativeParameterInfoStructHandler_24_1.Il2CppParameterInfo_24_1>() * paramCount);
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_afe904a262fb47328a49943b4b34b494 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_9D;
					case 4:
						num3 = 0;
						num2 = 3;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4ab786fa8604298818cd412db8f702f != 0)
						{
							num2 = 7;
							continue;
						}
						continue;
					case 5:
						return array;
					case 6:
						num3++;
						num2 = 8;
						continue;
					case 7:
						goto IL_8B;
					case 8:
						goto IL_8B;
					}
					IL_47:
					ptr[num3] = default(NativeParameterInfoStructHandler_24_1.Il2CppParameterInfo_24_1);
					num2 = 3;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_afe904a262fb47328a49943b4b34b494 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
					IL_8B:
					if (num3 < paramCount)
					{
						goto IL_47;
					}
					num2 = 5;
				}
				IL_9D:
				array[num3] = (Il2CppParameterInfo*)(ptr + num3);
				num = 6;
			}
			return array;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000E440 File Offset: 0x0000C640
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_61a3825996b24609815f6b482bf680d9 != 0)
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
			return new NativeParameterInfoStructHandler_24_1.NativeParameterInfoStructWrapper(paramInfoPointer);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000E4AC File Offset: 0x0000C6AC
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_806dbdb7f5194c2fa0c07a915df13fc8 == 0)
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
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0000E520 File Offset: 0x0000C720
		public bool HasNamePosToken
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000E52C File Offset: 0x0000C72C
		public NativeParameterInfoStructHandler_24_1()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeParameterInfoStructHandler_24_1.YlnulCNLePtmF0TkT30();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f0601de1a406461b9e99711ec5418371 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000E590 File Offset: 0x0000C790
		// Note: this type is marked as 'beforefieldinit'.
		static NativeParameterInfoStructHandler_24_1()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
		internal static IntPtr W8UNvnN6Sp7chb2K32f(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000E5B4 File Offset: 0x0000C7B4
		internal static bool AmVrAsNEsn7V9jFJaAH()
		{
			return NativeParameterInfoStructHandler_24_1.bA3MldNuSiXZ3dHvXFO == null;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		internal static NativeParameterInfoStructHandler_24_1 AE36piNc3U8EGZc4lmD()
		{
			return NativeParameterInfoStructHandler_24_1.bA3MldNuSiXZ3dHvXFO;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000E5D8 File Offset: 0x0000C7D8
		internal static void YlnulCNLePtmF0TkT30()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x0400013D RID: 317
		private static object bA3MldNuSiXZ3dHvXFO;

		// Token: 0x02000059 RID: 89
		internal struct Il2CppParameterInfo_24_1
		{
			// Token: 0x0400013E RID: 318
			public IntPtr name;

			// Token: 0x0400013F RID: 319
			public int position;

			// Token: 0x04000140 RID: 320
			public uint token;

			// Token: 0x04000141 RID: 321
			public unsafe Il2CppTypeStruct* parameter_type;
		}

		// Token: 0x0200005A RID: 90
		internal class NativeParameterInfoStructWrapper : INativeParameterInfoStruct, INativeStruct
		{
			// Token: 0x0600038F RID: 911 RVA: 0x00019720 File Offset: 0x00017920
			public NativeParameterInfoStructWrapper(IntPtr pointer)
			{
				NativeParameterInfoStructHandler_24_1.NativeParameterInfoStructWrapper.TFoLZcJFrP89moSxqkk();
				NativeParameterInfoStructHandler_24_1.NativeParameterInfoStructWrapper.aohKkvJKkUe4eeEV6w8();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a36e967c0f044e9ebf523536bdec8e28 != 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5636e8ee665e464ba930601506bed387 == 0)
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
			// (get) Token: 0x06000390 RID: 912 RVA: 0x000197B0 File Offset: 0x000179B0
			private unsafe NativeParameterInfoStructHandler_24_1.Il2CppParameterInfo_24_1* NativeParameter
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000391 RID: 913 RVA: 0x000197C0 File Offset: 0x000179C0
			public IntPtr Pointer { get; }

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x06000392 RID: 914 RVA: 0x000197D0 File Offset: 0x000179D0
			public unsafe Il2CppParameterInfo* ParameterInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000393 RID: 915 RVA: 0x000197E0 File Offset: 0x000179E0
			public bool HasNamePosToken
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000394 RID: 916 RVA: 0x000197EC File Offset: 0x000179EC
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref this.NativeParameter->name;
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x06000395 RID: 917 RVA: 0x00019800 File Offset: 0x00017A00
			public unsafe ref int Position
			{
				get
				{
					return ref this.NativeParameter->position;
				}
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06000396 RID: 918 RVA: 0x00019814 File Offset: 0x00017A14
			public unsafe ref uint Token
			{
				get
				{
					return ref this.NativeParameter->token;
				}
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x06000397 RID: 919 RVA: 0x00019828 File Offset: 0x00017A28
			public unsafe ref Il2CppTypeStruct* ParameterType
			{
				get
				{
					return ref this.NativeParameter->parameter_type;
				}
			}

			// Token: 0x06000398 RID: 920 RVA: 0x0001983C File Offset: 0x00017A3C
			// Note: this type is marked as 'beforefieldinit'.
			static NativeParameterInfoStructWrapper()
			{
				NativeParameterInfoStructHandler_24_1.NativeParameterInfoStructWrapper.XAgRcvJ5WcbqGwFpe4H();
			}

			// Token: 0x06000399 RID: 921 RVA: 0x0001984C File Offset: 0x00017A4C
			internal static void TFoLZcJFrP89moSxqkk()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600039A RID: 922 RVA: 0x0001985C File Offset: 0x00017A5C
			internal static void aohKkvJKkUe4eeEV6w8()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x0600039B RID: 923 RVA: 0x0001986C File Offset: 0x00017A6C
			internal static bool gEREusJjHgBVkE8vl8Y()
			{
				return NativeParameterInfoStructHandler_24_1.NativeParameterInfoStructWrapper.jaL4NbJBrW5QURWyFZj == null;
			}

			// Token: 0x0600039C RID: 924 RVA: 0x00019880 File Offset: 0x00017A80
			internal static NativeParameterInfoStructHandler_24_1.NativeParameterInfoStructWrapper VVB6IGJTkfQNeVSNLPm()
			{
				return NativeParameterInfoStructHandler_24_1.NativeParameterInfoStructWrapper.jaL4NbJBrW5QURWyFZj;
			}

			// Token: 0x0600039D RID: 925 RVA: 0x00019890 File Offset: 0x00017A90
			internal static void XAgRcvJ5WcbqGwFpe4H()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000143 RID: 323
			private static object jaL4NbJBrW5QURWyFZj;
		}
	}
}
