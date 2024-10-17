using System;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Assembly
{
	// Token: 0x02000114 RID: 276
	[ApplicableToUnityVersionsSince("2018.3.0")]
	public class NativeAssemblyStructHandler_24_1 : INativeAssemblyStructHandler, INativeStructHandler
	{
		// Token: 0x06000C4A RID: 3146 RVA: 0x000132DC File Offset: 0x000114DC
		public int Size()
		{
			return sizeof(NativeAssemblyStructHandler_24_1.Il2CppAssembly_24_1);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x000132EC File Offset: 0x000114EC
		public unsafe INativeAssemblyStruct CreateNewStruct()
		{
			NativeAssemblyStructHandler_24_1.Il2CppAssembly_24_1* ptr2;
			IntPtr ptr = ptr2 = NativeAssemblyStructHandler_24_1.UAaTopLM000y4ZQVW04(this.Size());
			*ptr2 = default(NativeAssemblyStructHandler_24_1.Il2CppAssembly_24_1);
			return new NativeAssemblyStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0001331C File Offset: 0x0001151C
		public unsafe INativeAssemblyStruct Wrap(Il2CppAssembly* ptr)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_944294969d634011bf30e3f4f506a31e != 0)
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
			return new NativeAssemblyStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00013384 File Offset: 0x00011584
		public NativeAssemblyStructHandler_24_1()
		{
			NativeAssemblyStructHandler_24_1.kGGjJRLpdliSUid5GLE();
			NativeAssemblyStructHandler_24_1.n9LkQvL4E2OO5nLXahT();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_483eecf3691e4ef2b23b2d4cb2ca3d52 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000133E8 File Offset: 0x000115E8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAssemblyStructHandler_24_1()
		{
			NativeAssemblyStructHandler_24_1.EI5bSVLzeU2ufkm90hK();
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x000133F8 File Offset: 0x000115F8
		internal static IntPtr UAaTopLM000y4ZQVW04(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0001340C File Offset: 0x0001160C
		internal static bool jJdp8VL3CIx6JRrNyMa()
		{
			return NativeAssemblyStructHandler_24_1.saeZmGLnApmi7mcuCsT == null;
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00013420 File Offset: 0x00011620
		internal static NativeAssemblyStructHandler_24_1 jqBYFuL1u36OMWgJHYb()
		{
			return NativeAssemblyStructHandler_24_1.saeZmGLnApmi7mcuCsT;
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00013430 File Offset: 0x00011630
		internal static void kGGjJRLpdliSUid5GLE()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00013440 File Offset: 0x00011640
		internal static void n9LkQvL4E2OO5nLXahT()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00013450 File Offset: 0x00011650
		internal static void EI5bSVLzeU2ufkm90hK()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400093D RID: 2365
		internal static NativeAssemblyStructHandler_24_1 saeZmGLnApmi7mcuCsT;

		// Token: 0x02000115 RID: 277
		internal struct Il2CppAssembly_24_1
		{
			// Token: 0x0400093E RID: 2366
			public unsafe Il2CppImage* image;

			// Token: 0x0400093F RID: 2367
			public uint token;

			// Token: 0x04000940 RID: 2368
			public int referencedAssemblyStart;

			// Token: 0x04000941 RID: 2369
			public int referencedAssemblyCount;

			// Token: 0x04000942 RID: 2370
			public NativeAssemblyNameStructHandler_24_0.Il2CppAssemblyName_24_0 aname;
		}

		// Token: 0x02000116 RID: 278
		internal class NativeStructWrapper : INativeAssemblyStruct, INativeStruct
		{
			// Token: 0x06000C55 RID: 3157 RVA: 0x00028088 File Offset: 0x00026288
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeAssemblyStructHandler_24_1.NativeStructWrapper.LO13bGdaimMXvWt3ASs();
				NativeAssemblyStructHandler_24_1.NativeStructWrapper.jD4m04dCFESQO6nexSm();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_4cb85c330fed4a769825a3343f966401 == 0)
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
					num = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_084a47a7baf94bf79b9c3fbf8d684053 == 0)
					{
						num = 1;
					}
				}
			}

			// Token: 0x1700049C RID: 1180
			// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00028118 File Offset: 0x00026318
			private unsafe NativeAssemblyStructHandler_24_1.Il2CppAssembly_24_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700049D RID: 1181
			// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00028128 File Offset: 0x00026328
			public IntPtr Pointer { get; }

			// Token: 0x1700049E RID: 1182
			// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00028138 File Offset: 0x00026338
			public unsafe Il2CppAssembly* AssemblyPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700049F RID: 1183
			// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00028148 File Offset: 0x00026348
			// (set) Token: 0x06000C5A RID: 3162 RVA: 0x00028164 File Offset: 0x00026364
			public unsafe INativeAssemblyNameStruct Name
			{
				get
				{
					return UnityVersionHandler.Wrap((Il2CppAssemblyName*)(&this._->aname));
				}
				set
				{
					int num = 1;
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							return;
						case 1:
							this._->aname = *(NativeAssemblyNameStructHandler_24_0.Il2CppAssemblyName_24_0*)this.Name.AssemblyNamePointer;
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_084a47a7baf94bf79b9c3fbf8d684053 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170004A0 RID: 1184
			// (get) Token: 0x06000C5B RID: 3163 RVA: 0x000281D8 File Offset: 0x000263D8
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x06000C5C RID: 3164 RVA: 0x000281EC File Offset: 0x000263EC
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeAssemblyStructHandler_24_1.NativeStructWrapper.WmktredtId1kyvs6qqg();
			}

			// Token: 0x06000C5D RID: 3165 RVA: 0x000281FC File Offset: 0x000263FC
			internal static void LO13bGdaimMXvWt3ASs()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000C5E RID: 3166 RVA: 0x0002820C File Offset: 0x0002640C
			internal static void jD4m04dCFESQO6nexSm()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000C5F RID: 3167 RVA: 0x0002821C File Offset: 0x0002641C
			internal static bool wy2XEydGvTbKWLEAWCq()
			{
				return NativeAssemblyStructHandler_24_1.NativeStructWrapper.DSAy2DdIrhx26jTqnOB == null;
			}

			// Token: 0x06000C60 RID: 3168 RVA: 0x00028230 File Offset: 0x00026430
			internal static NativeAssemblyStructHandler_24_1.NativeStructWrapper VNueJFdY6udZAay5vxC()
			{
				return NativeAssemblyStructHandler_24_1.NativeStructWrapper.DSAy2DdIrhx26jTqnOB;
			}

			// Token: 0x06000C61 RID: 3169 RVA: 0x00028240 File Offset: 0x00026440
			internal static void WmktredtId1kyvs6qqg()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000944 RID: 2372
			private static object DSAy2DdIrhx26jTqnOB;
		}
	}
}
