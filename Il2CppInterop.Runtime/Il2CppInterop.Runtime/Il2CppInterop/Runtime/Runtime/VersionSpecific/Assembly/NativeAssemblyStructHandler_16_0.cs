using System;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Assembly
{
	// Token: 0x0200010B RID: 267
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeAssemblyStructHandler_16_0 : INativeAssemblyStructHandler, INativeStructHandler
	{
		// Token: 0x06000C0A RID: 3082 RVA: 0x00012EA4 File Offset: 0x000110A4
		public int Size()
		{
			return sizeof(NativeAssemblyStructHandler_16_0.Il2CppAssembly_16_0);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00012EB4 File Offset: 0x000110B4
		public unsafe INativeAssemblyStruct CreateNewStruct()
		{
			NativeAssemblyStructHandler_16_0.Il2CppAssembly_16_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeAssemblyStructHandler_16_0.Il2CppAssembly_16_0);
			return new NativeAssemblyStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00012EE4 File Offset: 0x000110E4
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_37633ff27b934257920d0d03faf0bd54 != 0)
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

		// Token: 0x06000C0D RID: 3085 RVA: 0x00012F4C File Offset: 0x0001114C
		public NativeAssemblyStructHandler_16_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeAssemblyStructHandler_16_0.Nb8vJmLgiZbFs4B7GwA();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_1d16dd38ead14cb191f3b77c23c04ed4 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00012FB0 File Offset: 0x000111B0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAssemblyStructHandler_16_0()
		{
			NativeAssemblyStructHandler_16_0.aik4ErLlZo2nMHwgofZ();
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x00012FC0 File Offset: 0x000111C0
		internal static bool WHmJt0LyRRp0wWAMhYh()
		{
			return NativeAssemblyStructHandler_16_0.SNmjpLL24pdi2VFmRhp == null;
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00012FD4 File Offset: 0x000111D4
		internal static NativeAssemblyStructHandler_16_0 jCUigILSLAJTmNu2Pc5()
		{
			return NativeAssemblyStructHandler_16_0.SNmjpLL24pdi2VFmRhp;
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00012FE4 File Offset: 0x000111E4
		internal static void Nb8vJmLgiZbFs4B7GwA()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00012FF4 File Offset: 0x000111F4
		internal static void aik4ErLlZo2nMHwgofZ()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000927 RID: 2343
		private static NativeAssemblyStructHandler_16_0 SNmjpLL24pdi2VFmRhp;

		// Token: 0x0200010C RID: 268
		internal struct Il2CppAssembly_16_0
		{
			// Token: 0x04000928 RID: 2344
			public int imageIndex;

			// Token: 0x04000929 RID: 2345
			public int customAttributeIndex;

			// Token: 0x0400092A RID: 2346
			public NativeAssemblyNameStructHandler_16_0.Il2CppAssemblyName_16_0 aname;
		}

		// Token: 0x0200010D RID: 269
		internal class NativeStructWrapper : INativeAssemblyStruct, INativeStruct
		{
			// Token: 0x06000C13 RID: 3091 RVA: 0x00027B68 File Offset: 0x00025D68
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativeAssemblyStructHandler_16_0.NativeStructWrapper.Hm6N4nPm1Y3Ni9iKjAu();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bc244a0192c343599cd1cf83671e02ab != 0)
				{
					num = 1;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						return;
					case 1:
						this.<Pointer>k__BackingField = ptr;
						num = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_570d4e075bf443fcbaca8db32e007291 == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x1700048D RID: 1165
			// (get) Token: 0x06000C14 RID: 3092 RVA: 0x00027BF8 File Offset: 0x00025DF8
			private unsafe NativeAssemblyStructHandler_16_0.Il2CppAssembly_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700048E RID: 1166
			// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00027C08 File Offset: 0x00025E08
			public IntPtr Pointer { get; }

			// Token: 0x1700048F RID: 1167
			// (get) Token: 0x06000C16 RID: 3094 RVA: 0x00027C18 File Offset: 0x00025E18
			public unsafe Il2CppAssembly* AssemblyPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000490 RID: 1168
			// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00027C28 File Offset: 0x00025E28
			// (set) Token: 0x06000C18 RID: 3096 RVA: 0x00027C44 File Offset: 0x00025E44
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
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b15bb2810b414d8fba6ffddaf7154f62 == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x17000491 RID: 1169
			// (get) Token: 0x06000C19 RID: 3097 RVA: 0x00027CB8 File Offset: 0x00025EB8
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x06000C1A RID: 3098 RVA: 0x00027CC8 File Offset: 0x00025EC8
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000C1B RID: 3099 RVA: 0x00027CD8 File Offset: 0x00025ED8
			internal static void Hm6N4nPm1Y3Ni9iKjAu()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000C1C RID: 3100 RVA: 0x00027CE8 File Offset: 0x00025EE8
			internal static bool LdcjUyPOjDs2LVrI6Yy()
			{
				return NativeAssemblyStructHandler_16_0.NativeStructWrapper.Kaj0IrPVsNdD6103aSl == null;
			}

			// Token: 0x06000C1D RID: 3101 RVA: 0x00027CFC File Offset: 0x00025EFC
			internal static NativeAssemblyStructHandler_16_0.NativeStructWrapper IcssWGPXJX7GSBuqKhK()
			{
				return NativeAssemblyStructHandler_16_0.NativeStructWrapper.Kaj0IrPVsNdD6103aSl;
			}

			// Token: 0x0400092C RID: 2348
			internal static object Kaj0IrPVsNdD6103aSl;
		}
	}
}
