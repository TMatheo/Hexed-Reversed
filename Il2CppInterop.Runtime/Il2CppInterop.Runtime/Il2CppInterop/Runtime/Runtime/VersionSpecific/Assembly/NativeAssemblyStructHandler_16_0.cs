using System;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Assembly
{
	// Token: 0x02000109 RID: 265
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeAssemblyStructHandler_16_0 : INativeAssemblyStructHandler, INativeStructHandler
	{
		// Token: 0x06000BE6 RID: 3046 RVA: 0x00012258 File Offset: 0x00010458
		public int Size()
		{
			return sizeof(NativeAssemblyStructHandler_16_0.Il2CppAssembly_16_0);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00012268 File Offset: 0x00010468
		public unsafe INativeAssemblyStruct CreateNewStruct()
		{
			NativeAssemblyStructHandler_16_0.Il2CppAssembly_16_0* ptr2;
			IntPtr ptr = ptr2 = NativeAssemblyStructHandler_16_0.pLOYKeJbN9JTKvF1kbw(this.Size());
			*ptr2 = default(NativeAssemblyStructHandler_16_0.Il2CppAssembly_16_0);
			return new NativeAssemblyStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00012298 File Offset: 0x00010498
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cb2874465fa5416db806f31e03cc475c == 0)
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
			return new NativeAssemblyStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00012300 File Offset: 0x00010500
		public NativeAssemblyStructHandler_16_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeAssemblyStructHandler_16_0.AQKhB1J6Gy593jc1pXw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c04403f838344b38b3a8911774a446ea == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x00012364 File Offset: 0x00010564
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAssemblyStructHandler_16_0()
		{
			NativeAssemblyStructHandler_16_0.KjaEAbJyZr6aYdgURDZ();
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x00012374 File Offset: 0x00010574
		internal static IntPtr pLOYKeJbN9JTKvF1kbw(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00012388 File Offset: 0x00010588
		internal static bool sRsX8xJ8nBjuqoEEC1k()
		{
			return NativeAssemblyStructHandler_16_0.LJpqGGJY34V97kjWDc6 == null;
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x0001239C File Offset: 0x0001059C
		internal static NativeAssemblyStructHandler_16_0 EqJWOsJn6MC1KHGwFJU()
		{
			return NativeAssemblyStructHandler_16_0.LJpqGGJY34V97kjWDc6;
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x000123AC File Offset: 0x000105AC
		internal static void AQKhB1J6Gy593jc1pXw()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x000123BC File Offset: 0x000105BC
		internal static void KjaEAbJyZr6aYdgURDZ()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400091C RID: 2332
		private static NativeAssemblyStructHandler_16_0 LJpqGGJY34V97kjWDc6;

		// Token: 0x0200010A RID: 266
		internal struct Il2CppAssembly_16_0
		{
			// Token: 0x0400091D RID: 2333
			public int imageIndex;

			// Token: 0x0400091E RID: 2334
			public int customAttributeIndex;

			// Token: 0x0400091F RID: 2335
			public NativeAssemblyNameStructHandler_16_0.Il2CppAssemblyName_16_0 aname;
		}

		// Token: 0x0200010B RID: 267
		internal class NativeStructWrapper : INativeAssemblyStruct, INativeStruct
		{
			// Token: 0x06000BF0 RID: 3056 RVA: 0x00026EF4 File Offset: 0x000250F4
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeAssemblyStructHandler_16_0.NativeStructWrapper.xPQgJT4nCmPKjWe5p1o();
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_43cc35cb254148318955c7f83ade60f1 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5395ed2b7ead4e349835ba3f56e39138 == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x1700048D RID: 1165
			// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x00026F84 File Offset: 0x00025184
			private unsafe NativeAssemblyStructHandler_16_0.Il2CppAssembly_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700048E RID: 1166
			// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00026F94 File Offset: 0x00025194
			public IntPtr Pointer { get; }

			// Token: 0x1700048F RID: 1167
			// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00026FA4 File Offset: 0x000251A4
			public unsafe Il2CppAssembly* AssemblyPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000490 RID: 1168
			// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x00026FB4 File Offset: 0x000251B4
			// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x00026FD0 File Offset: 0x000251D0
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
							this._->aname = *(NativeAssemblyNameStructHandler_16_0.Il2CppAssemblyName_16_0*)this.Name.AssemblyNamePointer;
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3e2009ed69c04f5799431b4e58cafb2a == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000491 RID: 1169
			// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x00027044 File Offset: 0x00025244
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x06000BF7 RID: 3063 RVA: 0x00027054 File Offset: 0x00025254
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeAssemblyStructHandler_16_0.NativeStructWrapper.EkEsBG4bVwvLpLJqCts();
			}

			// Token: 0x06000BF8 RID: 3064 RVA: 0x00027064 File Offset: 0x00025264
			internal static void xPQgJT4nCmPKjWe5p1o()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000BF9 RID: 3065 RVA: 0x00027074 File Offset: 0x00025274
			internal static bool m2KNAn4YM0gFcoS6XVB()
			{
				return NativeAssemblyStructHandler_16_0.NativeStructWrapper.h64p0v4x1q9Fww8W2oM == null;
			}

			// Token: 0x06000BFA RID: 3066 RVA: 0x00027088 File Offset: 0x00025288
			internal static NativeAssemblyStructHandler_16_0.NativeStructWrapper wpbvQZ48LHSvbDwsDmJ()
			{
				return NativeAssemblyStructHandler_16_0.NativeStructWrapper.h64p0v4x1q9Fww8W2oM;
			}

			// Token: 0x06000BFB RID: 3067 RVA: 0x00027098 File Offset: 0x00025298
			internal static void EkEsBG4bVwvLpLJqCts()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000921 RID: 2337
			private static object h64p0v4x1q9Fww8W2oM;
		}
	}
}
