using System;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Assembly
{
	// Token: 0x0200010F RID: 271
	[ApplicableToUnityVersionsSince("2018.1.0")]
	public class NativeAssemblyStructHandler_24_0 : INativeAssemblyStructHandler, INativeStructHandler
	{
		// Token: 0x06000C12 RID: 3090 RVA: 0x0001252C File Offset: 0x0001072C
		public int Size()
		{
			return sizeof(NativeAssemblyStructHandler_24_0.Il2CppAssembly_24_0);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0001253C File Offset: 0x0001073C
		public unsafe INativeAssemblyStruct CreateNewStruct()
		{
			NativeAssemblyStructHandler_24_0.Il2CppAssembly_24_0* ptr2;
			IntPtr ptr = ptr2 = NativeAssemblyStructHandler_24_0.q73PTsJDHr3Lay8tJO7(this.Size());
			*ptr2 = default(NativeAssemblyStructHandler_24_0.Il2CppAssembly_24_0);
			return new NativeAssemblyStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0001256C File Offset: 0x0001076C
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae == 0)
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
			return new NativeAssemblyStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x000125D4 File Offset: 0x000107D4
		public NativeAssemblyStructHandler_24_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3e2009ed69c04f5799431b4e58cafb2a == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00012638 File Offset: 0x00010838
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAssemblyStructHandler_24_0()
		{
			NativeAssemblyStructHandler_24_0.XODGUpJmikKVcYfDqEp();
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x00012648 File Offset: 0x00010848
		internal static IntPtr q73PTsJDHr3Lay8tJO7(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0001265C File Offset: 0x0001085C
		internal static bool DOUhQjJNuJPJiiuQk6w()
		{
			return NativeAssemblyStructHandler_24_0.Wu4XBAJSCXIKpeyd7W8 == null;
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00012670 File Offset: 0x00010870
		internal static NativeAssemblyStructHandler_24_0 J3nk1OJudp2ch7yEkBf()
		{
			return NativeAssemblyStructHandler_24_0.Wu4XBAJSCXIKpeyd7W8;
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00012680 File Offset: 0x00010880
		internal static void XODGUpJmikKVcYfDqEp()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400092A RID: 2346
		internal static NativeAssemblyStructHandler_24_0 Wu4XBAJSCXIKpeyd7W8;

		// Token: 0x02000110 RID: 272
		internal struct Il2CppAssembly_24_0
		{
			// Token: 0x0400092B RID: 2347
			public unsafe Il2CppImage* image;

			// Token: 0x0400092C RID: 2348
			public int customAttributeIndex;

			// Token: 0x0400092D RID: 2349
			public int referencedAssemblyStart;

			// Token: 0x0400092E RID: 2350
			public int referencedAssemblyCount;

			// Token: 0x0400092F RID: 2351
			public NativeAssemblyNameStructHandler_24_0.Il2CppAssemblyName_24_0 aname;
		}

		// Token: 0x02000111 RID: 273
		internal class NativeStructWrapper : INativeAssemblyStruct, INativeStruct
		{
			// Token: 0x06000C1B RID: 3099 RVA: 0x0002726C File Offset: 0x0002546C
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeAssemblyStructHandler_24_0.NativeStructWrapper.KcTwqg43unTUeunUHZc();
				base..ctor();
				int num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_faca03c2e5084297b7a5d894ac66fa57 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7628c527f657443a88f11a40a3f948a5 == 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x17000497 RID: 1175
			// (get) Token: 0x06000C1C RID: 3100 RVA: 0x000272FC File Offset: 0x000254FC
			private unsafe NativeAssemblyStructHandler_24_0.Il2CppAssembly_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000498 RID: 1176
			// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0002730C File Offset: 0x0002550C
			public IntPtr Pointer { get; }

			// Token: 0x17000499 RID: 1177
			// (get) Token: 0x06000C1E RID: 3102 RVA: 0x0002731C File Offset: 0x0002551C
			public unsafe Il2CppAssembly* AssemblyPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700049A RID: 1178
			// (get) Token: 0x06000C1F RID: 3103 RVA: 0x0002732C File Offset: 0x0002552C
			// (set) Token: 0x06000C20 RID: 3104 RVA: 0x00027348 File Offset: 0x00025548
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
							this._->aname = *(NativeAssemblyNameStructHandler_24_0.Il2CppAssemblyName_24_0*)this.Name.AssemblyNamePointer;
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_faca03c2e5084297b7a5d894ac66fa57 != 0)
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

			// Token: 0x1700049B RID: 1179
			// (get) Token: 0x06000C21 RID: 3105 RVA: 0x000273BC File Offset: 0x000255BC
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x06000C22 RID: 3106 RVA: 0x000273D0 File Offset: 0x000255D0
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000C23 RID: 3107 RVA: 0x000273E0 File Offset: 0x000255E0
			internal static void KcTwqg43unTUeunUHZc()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x06000C24 RID: 3108 RVA: 0x000273F0 File Offset: 0x000255F0
			internal static bool vf51144PLsCM1pUJ0cx()
			{
				return NativeAssemblyStructHandler_24_0.NativeStructWrapper.Ulh59w47KcOtHDZ7qsQ == null;
			}

			// Token: 0x06000C25 RID: 3109 RVA: 0x00027404 File Offset: 0x00025604
			internal static NativeAssemblyStructHandler_24_0.NativeStructWrapper XE88TS44iO9Honi6xay()
			{
				return NativeAssemblyStructHandler_24_0.NativeStructWrapper.Ulh59w47KcOtHDZ7qsQ;
			}

			// Token: 0x04000931 RID: 2353
			internal static object Ulh59w47KcOtHDZ7qsQ;
		}
	}
}
