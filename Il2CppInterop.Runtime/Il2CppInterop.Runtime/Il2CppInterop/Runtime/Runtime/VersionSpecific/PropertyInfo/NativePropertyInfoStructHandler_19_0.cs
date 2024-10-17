using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.PropertyInfo
{
	// Token: 0x0200004D RID: 77
	[ApplicableToUnityVersionsSince("5.3.2")]
	public class NativePropertyInfoStructHandler_19_0 : INativePropertyInfoStructHandler, INativeStructHandler
	{
		// Token: 0x06000332 RID: 818 RVA: 0x0000DD18 File Offset: 0x0000BF18
		public int Size()
		{
			return sizeof(NativePropertyInfoStructHandler_19_0.Il2CppPropertyInfo_19_0);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000DD28 File Offset: 0x0000BF28
		public unsafe INativePropertyInfoStruct CreateNewStruct()
		{
			NativePropertyInfoStructHandler_19_0.Il2CppPropertyInfo_19_0* ptr2;
			IntPtr ptr = ptr2 = NativePropertyInfoStructHandler_19_0.SvOeal0zDyiI48AJ6dj(this.Size());
			*ptr2 = default(NativePropertyInfoStructHandler_19_0.Il2CppPropertyInfo_19_0);
			return new NativePropertyInfoStructHandler_19_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000DD58 File Offset: 0x0000BF58
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5a8626d471f54eba873ce59c8785d9b9 != 0)
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
			return new NativePropertyInfoStructHandler_19_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000DDC0 File Offset: 0x0000BFC0
		public NativePropertyInfoStructHandler_19_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativePropertyInfoStructHandler_19_0.qhal1WNHgma2JRssNnq();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ea3a0368554c4e6093e0b0561ffd5cef == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000DE24 File Offset: 0x0000C024
		// Note: this type is marked as 'beforefieldinit'.
		static NativePropertyInfoStructHandler_19_0()
		{
			NativePropertyInfoStructHandler_19_0.JkLOG1NA3uoue9vMpPg();
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000DE34 File Offset: 0x0000C034
		internal static IntPtr SvOeal0zDyiI48AJ6dj(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000DE48 File Offset: 0x0000C048
		internal static bool P2mhjV0p8ckEnO5DGag()
		{
			return NativePropertyInfoStructHandler_19_0.Re545C0MXejXCRwKZTM == null;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000DE5C File Offset: 0x0000C05C
		internal static NativePropertyInfoStructHandler_19_0 SJyD6O04lZShLGSLSaW()
		{
			return NativePropertyInfoStructHandler_19_0.Re545C0MXejXCRwKZTM;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000DE6C File Offset: 0x0000C06C
		internal static void qhal1WNHgma2JRssNnq()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000DE7C File Offset: 0x0000C07C
		internal static void JkLOG1NA3uoue9vMpPg()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000122 RID: 290
		private static NativePropertyInfoStructHandler_19_0 Re545C0MXejXCRwKZTM;

		// Token: 0x0200004E RID: 78
		internal struct Il2CppPropertyInfo_19_0
		{
			// Token: 0x04000123 RID: 291
			public unsafe Il2CppClass* parent;

			// Token: 0x04000124 RID: 292
			public unsafe byte* name;

			// Token: 0x04000125 RID: 293
			public unsafe Il2CppMethodInfo* get;

			// Token: 0x04000126 RID: 294
			public unsafe Il2CppMethodInfo* set;

			// Token: 0x04000127 RID: 295
			public uint attrs;

			// Token: 0x04000128 RID: 296
			public int customAttributeIndex;

			// Token: 0x04000129 RID: 297
			public uint token;
		}

		// Token: 0x0200004F RID: 79
		internal class NativeStructWrapper : INativePropertyInfoStruct, INativeStruct
		{
			// Token: 0x0600033C RID: 828 RVA: 0x000192A8 File Offset: 0x000174A8
			public NativeStructWrapper(IntPtr ptr)
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
				NativePropertyInfoStructHandler_19_0.NativeStructWrapper.a2RLumJr2jtDH5iWgIr();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5afe19cf44424af2ad9aea85585a9cc2 == 0)
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_46ba390073ec4df6883860abf17dbf6f == 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x0600033D RID: 829 RVA: 0x00019338 File Offset: 0x00017538
			private unsafe NativePropertyInfoStructHandler_19_0.Il2CppPropertyInfo_19_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x0600033E RID: 830 RVA: 0x00019348 File Offset: 0x00017548
			public IntPtr Pointer { get; }

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x0600033F RID: 831 RVA: 0x00019358 File Offset: 0x00017558
			public unsafe Il2CppPropertyInfo* PropertyInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x06000340 RID: 832 RVA: 0x00019368 File Offset: 0x00017568
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000341 RID: 833 RVA: 0x00019380 File Offset: 0x00017580
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x06000342 RID: 834 RVA: 0x00019394 File Offset: 0x00017594
			public unsafe ref Il2CppMethodInfo* Get
			{
				get
				{
					return ref this._->get;
				}
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x06000343 RID: 835 RVA: 0x000193A8 File Offset: 0x000175A8
			public unsafe ref Il2CppMethodInfo* Set
			{
				get
				{
					return ref this._->set;
				}
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x06000344 RID: 836 RVA: 0x000193BC File Offset: 0x000175BC
			public unsafe ref uint Attrs
			{
				get
				{
					return ref this._->attrs;
				}
			}

			// Token: 0x06000345 RID: 837 RVA: 0x000193D0 File Offset: 0x000175D0
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativePropertyInfoStructHandler_19_0.NativeStructWrapper.IvKJATJDwAcnM5XfTZm();
			}

			// Token: 0x06000346 RID: 838 RVA: 0x000193E0 File Offset: 0x000175E0
			internal static void a2RLumJr2jtDH5iWgIr()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000347 RID: 839 RVA: 0x000193F0 File Offset: 0x000175F0
			internal static bool K1lfcRJJbZ6j3jr2QTg()
			{
				return NativePropertyInfoStructHandler_19_0.NativeStructWrapper.fWBUDKJkFE7Qa5V54oY == null;
			}

			// Token: 0x06000348 RID: 840 RVA: 0x00019404 File Offset: 0x00017604
			internal static NativePropertyInfoStructHandler_19_0.NativeStructWrapper aqxU8rJWx63Jx6PZt3w()
			{
				return NativePropertyInfoStructHandler_19_0.NativeStructWrapper.fWBUDKJkFE7Qa5V54oY;
			}

			// Token: 0x06000349 RID: 841 RVA: 0x00019414 File Offset: 0x00017614
			internal static void IvKJATJDwAcnM5XfTZm()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0400012B RID: 299
			internal static object fWBUDKJkFE7Qa5V54oY;
		}
	}
}
