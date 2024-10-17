using System;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Assembly
{
	// Token: 0x02000117 RID: 279
	[ApplicableToUnityVersionsSince("2018.4.34")]
	public class NativeAssemblyStructHandler_24_2 : INativeAssemblyStructHandler, INativeStructHandler
	{
		// Token: 0x06000C62 RID: 3170 RVA: 0x00013460 File Offset: 0x00011660
		public int Size()
		{
			return sizeof(NativeAssemblyStructHandler_24_2.Il2CppAssembly_24_2);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00013470 File Offset: 0x00011670
		public unsafe INativeAssemblyStruct CreateNewStruct()
		{
			NativeAssemblyStructHandler_24_2.Il2CppAssembly_24_2* ptr2;
			IntPtr ptr = ptr2 = NativeAssemblyStructHandler_24_2.QbjVlQ7q1yjbZ1sJFKl(this.Size());
			*ptr2 = default(NativeAssemblyStructHandler_24_2.Il2CppAssembly_24_2);
			return new NativeAssemblyStructHandler_24_2.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x000134A0 File Offset: 0x000116A0
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_906545e343eb409d9eb685fc4a903234 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeAssemblyStructHandler_24_2.NativeStructWrapper(ptr);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00013508 File Offset: 0x00011708
		public NativeAssemblyStructHandler_24_2()
		{
			NativeAssemblyStructHandler_24_2.DMsuyb79HjsxmpDBf4P();
			NativeAssemblyStructHandler_24_2.hpopRw7ig2cT99P1XvQ();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_084a47a7baf94bf79b9c3fbf8d684053 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0001356C File Offset: 0x0001176C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeAssemblyStructHandler_24_2()
		{
			NativeAssemblyStructHandler_24_2.PYHVd37IUAiRxsUn5Pb();
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0001357C File Offset: 0x0001177C
		internal static IntPtr QbjVlQ7q1yjbZ1sJFKl(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00013590 File Offset: 0x00011790
		internal static bool YlQ9uL7AqTnkxD5vvrH()
		{
			return NativeAssemblyStructHandler_24_2.fVm5iV7HlwC3kJAcxjU == null;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x000135A4 File Offset: 0x000117A4
		internal static NativeAssemblyStructHandler_24_2 zSuYqb7UaOuIlvRHy0T()
		{
			return NativeAssemblyStructHandler_24_2.fVm5iV7HlwC3kJAcxjU;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x000135B4 File Offset: 0x000117B4
		internal static void DMsuyb79HjsxmpDBf4P()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x000135C4 File Offset: 0x000117C4
		internal static void hpopRw7ig2cT99P1XvQ()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x000135D4 File Offset: 0x000117D4
		internal static void PYHVd37IUAiRxsUn5Pb()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000945 RID: 2373
		private static NativeAssemblyStructHandler_24_2 fVm5iV7HlwC3kJAcxjU;

		// Token: 0x02000118 RID: 280
		internal struct Il2CppAssembly_24_2
		{
			// Token: 0x04000946 RID: 2374
			public unsafe Il2CppImage* image;

			// Token: 0x04000947 RID: 2375
			public uint token;

			// Token: 0x04000948 RID: 2376
			public int referencedAssemblyStart;

			// Token: 0x04000949 RID: 2377
			public int referencedAssemblyCount;

			// Token: 0x0400094A RID: 2378
			public NativeAssemblyNameStructHandler_24_1.Il2CppAssemblyName_24_1 aname;
		}

		// Token: 0x02000119 RID: 281
		internal class NativeStructWrapper : INativeAssemblyStruct, INativeStruct
		{
			// Token: 0x06000C6D RID: 3181 RVA: 0x00028250 File Offset: 0x00026450
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeAssemblyStructHandler_24_2.NativeStructWrapper.supYpqdEmY49VWDqgEr();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e56c162609824bd799f0a7b9a8c33c89 == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2dd85386720b438b874026b47430e4fa == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x170004A1 RID: 1185
			// (get) Token: 0x06000C6E RID: 3182 RVA: 0x000282E0 File Offset: 0x000264E0
			private unsafe NativeAssemblyStructHandler_24_2.Il2CppAssembly_24_2* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170004A2 RID: 1186
			// (get) Token: 0x06000C6F RID: 3183 RVA: 0x000282F0 File Offset: 0x000264F0
			public IntPtr Pointer { get; }

			// Token: 0x170004A3 RID: 1187
			// (get) Token: 0x06000C70 RID: 3184 RVA: 0x00028300 File Offset: 0x00026500
			public unsafe Il2CppAssembly* AssemblyPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170004A4 RID: 1188
			// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00028310 File Offset: 0x00026510
			// (set) Token: 0x06000C72 RID: 3186 RVA: 0x0002832C File Offset: 0x0002652C
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
							this._->aname = *(NativeAssemblyNameStructHandler_24_1.Il2CppAssemblyName_24_1*)this.Name.AssemblyNamePointer;
							num2 = 0;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c2ad52141772446383547acade021f9a == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				}
			}

			// Token: 0x170004A5 RID: 1189
			// (get) Token: 0x06000C73 RID: 3187 RVA: 0x000283A0 File Offset: 0x000265A0
			public unsafe ref Il2CppImage* Image
			{
				get
				{
					return ref this._->image;
				}
			}

			// Token: 0x06000C74 RID: 3188 RVA: 0x000283B4 File Offset: 0x000265B4
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x06000C75 RID: 3189 RVA: 0x000283C4 File Offset: 0x000265C4
			internal static void supYpqdEmY49VWDqgEr()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000C76 RID: 3190 RVA: 0x000283D4 File Offset: 0x000265D4
			internal static bool xwMFqXdNUhgfArU6lja()
			{
				return NativeAssemblyStructHandler_24_2.NativeStructWrapper.KrdFKxd02HDVwvRPgBO == null;
			}

			// Token: 0x06000C77 RID: 3191 RVA: 0x000283E8 File Offset: 0x000265E8
			internal static NativeAssemblyStructHandler_24_2.NativeStructWrapper E0LqrBduH8qRcja9En5()
			{
				return NativeAssemblyStructHandler_24_2.NativeStructWrapper.KrdFKxd02HDVwvRPgBO;
			}

			// Token: 0x0400094C RID: 2380
			internal static object KrdFKxd02HDVwvRPgBO;
		}
	}
}
