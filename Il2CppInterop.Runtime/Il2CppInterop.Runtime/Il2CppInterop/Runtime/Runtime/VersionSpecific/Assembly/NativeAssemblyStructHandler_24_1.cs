using System;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Assembly
{
	// Token: 0x02000112 RID: 274
	[ApplicableToUnityVersionsSince("2018.3.0")]
	public class NativeAssemblyStructHandler_24_1 : INativeAssemblyStructHandler, INativeStructHandler
	{
		// Token: 0x06000C26 RID: 3110 RVA: 0x00012690 File Offset: 0x00010890
		public int Size()
		{
			return sizeof(NativeAssemblyStructHandler_24_1.Il2CppAssembly_24_1);
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x000126A0 File Offset: 0x000108A0
		public unsafe INativeAssemblyStruct CreateNewStruct()
		{
			NativeAssemblyStructHandler_24_1.Il2CppAssembly_24_1* ptr2;
			IntPtr ptr = ptr2 = NativeAssemblyStructHandler_24_1.tWRRjwJ3YMrfLLc3qus(this.Size());
			*ptr2 = default(NativeAssemblyStructHandler_24_1.Il2CppAssembly_24_1);
			return new NativeAssemblyStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x000126D0 File Offset: 0x000108D0
		public unsafe INativeAssemblyStruct Wrap(Il2CppAssembly* ptr)
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
					if (ptr != null)
					{
						goto IL_2D;
					}
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b169d8ea412f45e99e430384ddc8908b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeAssemblyStructHandler_24_1.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00012738 File Offset: 0x00010938
		public NativeAssemblyStructHandler_24_1()
		{
			NativeAssemblyStructHandler_24_1.uOmooEJf4gVgAQdPiWF();
			NativeAssemblyStructHandler_24_1.zWMoBDJ1UojHPyAdNbp();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ac2c10c141e144acbcef06aa86a10430 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x0001279C File Offset: 0x0001099C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAssemblyStructHandler_24_1()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x000127AC File Offset: 0x000109AC
		internal static IntPtr tWRRjwJ3YMrfLLc3qus(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x000127C0 File Offset: 0x000109C0
		internal static bool lewIugJPm4yvcBJaw0h()
		{
			return NativeAssemblyStructHandler_24_1.Du4HinJ7HDIAWyPfnCN == null;
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x000127D4 File Offset: 0x000109D4
		internal static NativeAssemblyStructHandler_24_1 kp4jFSJ4VgIR5Ghi4h5()
		{
			return NativeAssemblyStructHandler_24_1.Du4HinJ7HDIAWyPfnCN;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x000127E4 File Offset: 0x000109E4
		internal static void uOmooEJf4gVgAQdPiWF()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x000127F4 File Offset: 0x000109F4
		internal static void zWMoBDJ1UojHPyAdNbp()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x04000932 RID: 2354
		private static NativeAssemblyStructHandler_24_1 Du4HinJ7HDIAWyPfnCN;

		// Token: 0x02000113 RID: 275
		internal struct Il2CppAssembly_24_1
		{
			// Token: 0x04000933 RID: 2355
			public unsafe Il2CppImage* image;

			// Token: 0x04000934 RID: 2356
			public uint token;

			// Token: 0x04000935 RID: 2357
			public int referencedAssemblyStart;

			// Token: 0x04000936 RID: 2358
			public int referencedAssemblyCount;

			// Token: 0x04000937 RID: 2359
			public NativeAssemblyNameStructHandler_24_0.Il2CppAssemblyName_24_0 aname;
		}

		// Token: 0x02000114 RID: 276
		internal class NativeStructWrapper : INativeAssemblyStruct, INativeStruct
		{
			// Token: 0x06000C30 RID: 3120 RVA: 0x00027414 File Offset: 0x00025614
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeAssemblyStructHandler_24_1.NativeStructWrapper.lXBWLw4CdiTk93FOd3W();
				NativeAssemblyStructHandler_24_1.NativeStructWrapper.CG4Oks49tIrPmGjUtVS();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bc2bbd892f074260abf5aaa8b1124d64 == 0)
				{
					num = 1;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.<Pointer>k__BackingField = ptr;
						num = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x1700049C RID: 1180
			// (get) Token: 0x06000C31 RID: 3121 RVA: 0x000274A4 File Offset: 0x000256A4
			private unsafe NativeAssemblyStructHandler_24_1.Il2CppAssembly_24_1* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700049D RID: 1181
			// (get) Token: 0x06000C32 RID: 3122 RVA: 0x000274B4 File Offset: 0x000256B4
			public IntPtr Pointer { get; }

			// Token: 0x1700049E RID: 1182
			// (get) Token: 0x06000C33 RID: 3123 RVA: 0x000274C4 File Offset: 0x000256C4
			public unsafe Il2CppAssembly* AssemblyPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700049F RID: 1183
			// (get) Token: 0x06000C34 RID: 3124 RVA: 0x000274D4 File Offset: 0x000256D4
			// (set) Token: 0x06000C35 RID: 3125 RVA: 0x000274F0 File Offset: 0x000256F0
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
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_911808c58d664adeb7c16d1e3a32f7fa != 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170004A0 RID: 1184
			// (get) Token: 0x06000C36 RID: 3126 RVA: 0x00027564 File Offset: 0x00025764
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x06000C37 RID: 3127 RVA: 0x00027578 File Offset: 0x00025778
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeAssemblyStructHandler_24_1.NativeStructWrapper.IAAo8k4ISh1IAdefZH0();
			}

			// Token: 0x06000C38 RID: 3128 RVA: 0x00027588 File Offset: 0x00025788
			internal static void lXBWLw4CdiTk93FOd3W()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000C39 RID: 3129 RVA: 0x00027598 File Offset: 0x00025798
			internal static void CG4Oks49tIrPmGjUtVS()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000C3A RID: 3130 RVA: 0x000275A8 File Offset: 0x000257A8
			internal static bool NAJ3nK4MCDOexGUliLN()
			{
				return NativeAssemblyStructHandler_24_1.NativeStructWrapper.uNj2lx4R91dqlQmaJyn == null;
			}

			// Token: 0x06000C3B RID: 3131 RVA: 0x000275BC File Offset: 0x000257BC
			internal static NativeAssemblyStructHandler_24_1.NativeStructWrapper dUxhb44WQDRh4TtpoCn()
			{
				return NativeAssemblyStructHandler_24_1.NativeStructWrapper.uNj2lx4R91dqlQmaJyn;
			}

			// Token: 0x06000C3C RID: 3132 RVA: 0x000275CC File Offset: 0x000257CC
			internal static void IAAo8k4ISh1IAdefZH0()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000939 RID: 2361
			internal static object uNj2lx4R91dqlQmaJyn;
		}
	}
}
