using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.PropertyInfo
{
	// Token: 0x02000050 RID: 80
	[ApplicableToUnityVersionsSince("2018.3.0")]
	public class NativePropertyInfoStructHandler_24_0 : INativePropertyInfoStructHandler, INativeStructHandler
	{
		// Token: 0x0600034A RID: 842 RVA: 0x0000DE8C File Offset: 0x0000C08C
		public int Size()
		{
			return sizeof(NativePropertyInfoStructHandler_24_0.Il2CppPropertyInfo_24_0);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000DE9C File Offset: 0x0000C09C
		public unsafe INativePropertyInfoStruct CreateNewStruct()
		{
			NativePropertyInfoStructHandler_24_0.Il2CppPropertyInfo_24_0* ptr2;
			IntPtr ptr = ptr2 = NativePropertyInfoStructHandler_24_0.pQDyl3NiUZbP9RUZ97m(this.Size());
			*ptr2 = default(NativePropertyInfoStructHandler_24_0.Il2CppPropertyInfo_24_0);
			return new NativePropertyInfoStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000DECC File Offset: 0x0000C0CC
		public unsafe INativePropertyInfoStruct Wrap(Il2CppPropertyInfo* ptr)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fcdd30171ceb4eb7a5570cbbc4f6aec1 != 0)
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
			return new NativePropertyInfoStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000DF34 File Offset: 0x0000C134
		public NativePropertyInfoStructHandler_24_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ce81190098cb44f1b9a77ca4822d7770 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000DF98 File Offset: 0x0000C198
		// Note: this type is marked as 'beforefieldinit'.
		static NativePropertyInfoStructHandler_24_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000DFA8 File Offset: 0x0000C1A8
		internal static IntPtr pQDyl3NiUZbP9RUZ97m(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000DFBC File Offset: 0x0000C1BC
		internal static bool UnkmUgNqksjdnrskPEs()
		{
			return NativePropertyInfoStructHandler_24_0.pdMctiNU2Roda0UT5w8 == null;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000DFD0 File Offset: 0x0000C1D0
		internal static NativePropertyInfoStructHandler_24_0 VRvu3MN9lf2L9anqUB8()
		{
			return NativePropertyInfoStructHandler_24_0.pdMctiNU2Roda0UT5w8;
		}

		// Token: 0x0400012C RID: 300
		internal static NativePropertyInfoStructHandler_24_0 pdMctiNU2Roda0UT5w8;

		// Token: 0x02000051 RID: 81
		internal struct Il2CppPropertyInfo_24_0
		{
			// Token: 0x0400012D RID: 301
			public unsafe Il2CppClass* parent;

			// Token: 0x0400012E RID: 302
			public unsafe byte* name;

			// Token: 0x0400012F RID: 303
			public unsafe Il2CppMethodInfo* get;

			// Token: 0x04000130 RID: 304
			public unsafe Il2CppMethodInfo* set;

			// Token: 0x04000131 RID: 305
			public uint attrs;

			// Token: 0x04000132 RID: 306
			public uint token;
		}

		// Token: 0x02000052 RID: 82
		internal class NativeStructWrapper : INativePropertyInfoStruct, INativeStruct
		{
			// Token: 0x06000352 RID: 850 RVA: 0x00019424 File Offset: 0x00017624
			public NativeStructWrapper(IntPtr ptr)
			{
				NativePropertyInfoStructHandler_24_0.NativeStructWrapper.JFEWcPJwClTvAjZ9Ks2();
				NativePropertyInfoStructHandler_24_0.NativeStructWrapper.DhX72eJeH70bEuCNpqQ();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_330a825ae0544050af4112bb9a37f6bb == 0)
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
					num = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8447c7a721f541de9426c754e1b08372 != 0)
					{
						num = 1;
					}
				}
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x06000353 RID: 851 RVA: 0x000194B4 File Offset: 0x000176B4
			private unsafe NativePropertyInfoStructHandler_24_0.Il2CppPropertyInfo_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x06000354 RID: 852 RVA: 0x000194C4 File Offset: 0x000176C4
			public IntPtr Pointer { get; }

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x06000355 RID: 853 RVA: 0x000194D4 File Offset: 0x000176D4
			public unsafe Il2CppPropertyInfo* PropertyInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x06000356 RID: 854 RVA: 0x000194E4 File Offset: 0x000176E4
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x06000357 RID: 855 RVA: 0x000194FC File Offset: 0x000176FC
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x06000358 RID: 856 RVA: 0x00019510 File Offset: 0x00017710
			public unsafe ref Il2CppMethodInfo* Get
			{
				get
				{
					return ref this._->get;
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x06000359 RID: 857 RVA: 0x00019524 File Offset: 0x00017724
			public unsafe ref Il2CppMethodInfo* Set
			{
				get
				{
					return ref this._->set;
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x0600035A RID: 858 RVA: 0x00019538 File Offset: 0x00017738
			public unsafe ref uint Attrs
			{
				get
				{
					return ref this._->attrs;
				}
			}

			// Token: 0x0600035B RID: 859 RVA: 0x0001954C File Offset: 0x0001774C
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0600035C RID: 860 RVA: 0x0001955C File Offset: 0x0001775C
			internal static void JFEWcPJwClTvAjZ9Ks2()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600035D RID: 861 RVA: 0x0001956C File Offset: 0x0001776C
			internal static void DhX72eJeH70bEuCNpqQ()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x0600035E RID: 862 RVA: 0x0001957C File Offset: 0x0001777C
			internal static bool TLirXgJPCNWt6Z2g1qx()
			{
				return NativePropertyInfoStructHandler_24_0.NativeStructWrapper.UNTfhRJfc2GxAPePnd3 == null;
			}

			// Token: 0x0600035F RID: 863 RVA: 0x00019590 File Offset: 0x00017790
			internal static NativePropertyInfoStructHandler_24_0.NativeStructWrapper AQaxA9JdYQ1XTRDfaE5()
			{
				return NativePropertyInfoStructHandler_24_0.NativeStructWrapper.UNTfhRJfc2GxAPePnd3;
			}

			// Token: 0x04000134 RID: 308
			private static object UNTfhRJfc2GxAPePnd3;
		}
	}
}
