using System;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Assembly
{
	// Token: 0x0200010E RID: 270
	[ApplicableToUnityVersionsSince("5.3.3")]
	public class NativeAssemblyStructHandler_20_0 : INativeAssemblyStructHandler, INativeStructHandler
	{
		// Token: 0x06000C1E RID: 3102 RVA: 0x00013004 File Offset: 0x00011204
		public int Size()
		{
			return sizeof(NativeAssemblyStructHandler_20_0.Il2CppAssembly_20_0);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00013014 File Offset: 0x00011214
		public unsafe INativeAssemblyStruct CreateNewStruct()
		{
			NativeAssemblyStructHandler_20_0.Il2CppAssembly_20_0* ptr2;
			IntPtr ptr = ptr2 = NativeAssemblyStructHandler_20_0.v0qq1NLmL2EQQ97ru4b(this.Size());
			*ptr2 = default(NativeAssemblyStructHandler_20_0.Il2CppAssembly_20_0);
			return new NativeAssemblyStructHandler_20_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00013044 File Offset: 0x00011244
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6e39fb1a8feb46889b60abcfbb34e0df != 0)
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
			return new NativeAssemblyStructHandler_20_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x000130AC File Offset: 0x000112AC
		public NativeAssemblyStructHandler_20_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeAssemblyStructHandler_20_0.epHcMaLvSFH6o4kQSl9();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_780e0c86b08f49d785f406cf802c7e87 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00013110 File Offset: 0x00011310
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAssemblyStructHandler_20_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00013120 File Offset: 0x00011320
		internal static IntPtr v0qq1NLmL2EQQ97ru4b(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00013134 File Offset: 0x00011334
		internal static bool y0nMAKLOPhd5gousn9h()
		{
			return NativeAssemblyStructHandler_20_0.m22keXLVumPFmrZwyFl == null;
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00013148 File Offset: 0x00011348
		internal static NativeAssemblyStructHandler_20_0 YIsZWpLX5c3xeEZfWiH()
		{
			return NativeAssemblyStructHandler_20_0.m22keXLVumPFmrZwyFl;
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00013158 File Offset: 0x00011358
		internal static void epHcMaLvSFH6o4kQSl9()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x0400092D RID: 2349
		internal static NativeAssemblyStructHandler_20_0 m22keXLVumPFmrZwyFl;

		// Token: 0x0200010F RID: 271
		internal struct Il2CppAssembly_20_0
		{
			// Token: 0x0400092E RID: 2350
			public int imageIndex;

			// Token: 0x0400092F RID: 2351
			public int customAttributeIndex;

			// Token: 0x04000930 RID: 2352
			public int referencedAssemblyStart;

			// Token: 0x04000931 RID: 2353
			public int referencedAssemblyCount;

			// Token: 0x04000932 RID: 2354
			public NativeAssemblyNameStructHandler_16_0.Il2CppAssemblyName_16_0 aname;
		}

		// Token: 0x02000110 RID: 272
		internal class NativeStructWrapper : INativeAssemblyStruct, INativeStruct
		{
			// Token: 0x06000C27 RID: 3111 RVA: 0x00027D0C File Offset: 0x00025F0C
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeAssemblyStructHandler_20_0.NativeStructWrapper.qhjsr9P5prwpjxcRmFb();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fcdd30171ceb4eb7a5570cbbc4f6aec1 == 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						this.<Pointer>k__BackingField = ptr;
						num = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56c162609824bd799f0a7b9a8c33c89 == 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x17000492 RID: 1170
			// (get) Token: 0x06000C28 RID: 3112 RVA: 0x00027D9C File Offset: 0x00025F9C
			private unsafe NativeAssemblyStructHandler_20_0.Il2CppAssembly_20_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000493 RID: 1171
			// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00027DAC File Offset: 0x00025FAC
			public IntPtr Pointer { get; }

			// Token: 0x17000494 RID: 1172
			// (get) Token: 0x06000C2A RID: 3114 RVA: 0x00027DBC File Offset: 0x00025FBC
			public unsafe Il2CppAssembly* AssemblyPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000495 RID: 1173
			// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00027DCC File Offset: 0x00025FCC
			// (set) Token: 0x06000C2C RID: 3116 RVA: 0x00027DE8 File Offset: 0x00025FE8
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
						case 1:
							this._->aname = *(NativeAssemblyNameStructHandler_16_0.Il2CppAssemblyName_16_0*)this.Name.AssemblyNamePointer;
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_37633ff27b934257920d0d03faf0bd54 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
				}
			}

			// Token: 0x17000496 RID: 1174
			// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00027E5C File Offset: 0x0002605C
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x06000C2E RID: 3118 RVA: 0x00027E6C File Offset: 0x0002606C
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeAssemblyStructHandler_20_0.NativeStructWrapper.kaVh15PnBsKcynTaRYQ();
			}

			// Token: 0x06000C2F RID: 3119 RVA: 0x00027E7C File Offset: 0x0002607C
			internal static void qhjsr9P5prwpjxcRmFb()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000C30 RID: 3120 RVA: 0x00027E8C File Offset: 0x0002608C
			internal static bool sKNBI1PFW5WsHvb9Lev()
			{
				return NativeAssemblyStructHandler_20_0.NativeStructWrapper.ePMLcRPTEe9EEPHB74I == null;
			}

			// Token: 0x06000C31 RID: 3121 RVA: 0x00027EA0 File Offset: 0x000260A0
			internal static NativeAssemblyStructHandler_20_0.NativeStructWrapper KgEor7PKdCJIss7OsQ5()
			{
				return NativeAssemblyStructHandler_20_0.NativeStructWrapper.ePMLcRPTEe9EEPHB74I;
			}

			// Token: 0x06000C32 RID: 3122 RVA: 0x00027EB0 File Offset: 0x000260B0
			internal static void kaVh15PnBsKcynTaRYQ()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000934 RID: 2356
			internal static object ePMLcRPTEe9EEPHB74I;
		}
	}
}
