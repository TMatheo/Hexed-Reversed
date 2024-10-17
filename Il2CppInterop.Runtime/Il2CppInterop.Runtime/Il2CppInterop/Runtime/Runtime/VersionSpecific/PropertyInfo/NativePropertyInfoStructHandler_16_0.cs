using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.PropertyInfo
{
	// Token: 0x0200004A RID: 74
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativePropertyInfoStructHandler_16_0 : INativePropertyInfoStructHandler, INativeStructHandler
	{
		// Token: 0x0600031C RID: 796 RVA: 0x0000DBB8 File Offset: 0x0000BDB8
		public int Size()
		{
			return sizeof(NativePropertyInfoStructHandler_16_0.Il2CppPropertyInfo_16_0);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000DBC8 File Offset: 0x0000BDC8
		public unsafe INativePropertyInfoStruct CreateNewStruct()
		{
			NativePropertyInfoStructHandler_16_0.Il2CppPropertyInfo_16_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativePropertyInfoStructHandler_16_0.Il2CppPropertyInfo_16_0);
			return new NativePropertyInfoStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000DBF8 File Offset: 0x0000BDF8
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9c5de7c7e06f4557898ef7a8362c30ee == 0)
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
			return new NativePropertyInfoStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000DC60 File Offset: 0x0000BE60
		public NativePropertyInfoStructHandler_16_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativePropertyInfoStructHandler_16_0.IlG7PU03TXsYwJYBoSp();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_22d16b8eb84d4725aef9f7a9d2f68925 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000DCC4 File Offset: 0x0000BEC4
		// Note: this type is marked as 'beforefieldinit'.
		static NativePropertyInfoStructHandler_16_0()
		{
			NativePropertyInfoStructHandler_16_0.tRniCy01nkD0YIpOEMZ();
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000DCD4 File Offset: 0x0000BED4
		internal static bool gjbnKy05h7v3FIE4oMt()
		{
			return NativePropertyInfoStructHandler_16_0.hkUqJF0KXVNl2FWZucg == null;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000DCE8 File Offset: 0x0000BEE8
		internal static NativePropertyInfoStructHandler_16_0 iDVFVH0nWiaOaXUQHbC()
		{
			return NativePropertyInfoStructHandler_16_0.hkUqJF0KXVNl2FWZucg;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		internal static void IlG7PU03TXsYwJYBoSp()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000DD08 File Offset: 0x0000BF08
		internal static void tRniCy01nkD0YIpOEMZ()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000119 RID: 281
		internal static NativePropertyInfoStructHandler_16_0 hkUqJF0KXVNl2FWZucg;

		// Token: 0x0200004B RID: 75
		internal struct Il2CppPropertyInfo_16_0
		{
			// Token: 0x0400011A RID: 282
			public unsafe Il2CppClass* parent;

			// Token: 0x0400011B RID: 283
			public unsafe byte* name;

			// Token: 0x0400011C RID: 284
			public unsafe Il2CppMethodInfo* get;

			// Token: 0x0400011D RID: 285
			public unsafe Il2CppMethodInfo* set;

			// Token: 0x0400011E RID: 286
			public uint attrs;

			// Token: 0x0400011F RID: 287
			public int customAttributeIndex;
		}

		// Token: 0x0200004C RID: 76
		internal class NativeStructWrapper : INativePropertyInfoStruct, INativeStruct
		{
			// Token: 0x06000325 RID: 805 RVA: 0x0001913C File Offset: 0x0001733C
			public NativeStructWrapper(IntPtr ptr)
			{
				NativePropertyInfoStructHandler_16_0.NativeStructWrapper.EUN2JMJ6cRhnxHetO9M();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ba3f6bd5a09c47868765e25f534dbf2a == 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.<Pointer>k__BackingField = ptr;
						num = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7f5f35a413414ac0b2dfa27f953f90e9 != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x06000326 RID: 806 RVA: 0x000191CC File Offset: 0x000173CC
			private unsafe NativePropertyInfoStructHandler_16_0.Il2CppPropertyInfo_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x06000327 RID: 807 RVA: 0x000191DC File Offset: 0x000173DC
			public IntPtr Pointer { get; }

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x06000328 RID: 808 RVA: 0x000191EC File Offset: 0x000173EC
			public unsafe Il2CppPropertyInfo* PropertyInfoPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000329 RID: 809 RVA: 0x000191FC File Offset: 0x000173FC
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x0600032A RID: 810 RVA: 0x00019214 File Offset: 0x00017414
			public unsafe ref Il2CppClass* Parent
			{
				get
				{
					return ref this._->parent;
				}
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x0600032B RID: 811 RVA: 0x00019228 File Offset: 0x00017428
			public unsafe ref Il2CppMethodInfo* Get
			{
				get
				{
					return ref this._->get;
				}
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x0600032C RID: 812 RVA: 0x0001923C File Offset: 0x0001743C
			public unsafe ref Il2CppMethodInfo* Set
			{
				get
				{
					return ref this._->set;
				}
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x0600032D RID: 813 RVA: 0x00019250 File Offset: 0x00017450
			public unsafe ref uint Attrs
			{
				get
				{
					return ref this._->attrs;
				}
			}

			// Token: 0x0600032E RID: 814 RVA: 0x00019264 File Offset: 0x00017464
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0600032F RID: 815 RVA: 0x00019274 File Offset: 0x00017474
			internal static void EUN2JMJ6cRhnxHetO9M()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000330 RID: 816 RVA: 0x00019284 File Offset: 0x00017484
			internal static bool fxXvA5JE361XLqTmGfl()
			{
				return NativePropertyInfoStructHandler_16_0.NativeStructWrapper.HDPhMFJuZ9ZFsYOLxop == null;
			}

			// Token: 0x06000331 RID: 817 RVA: 0x00019298 File Offset: 0x00017498
			internal static NativePropertyInfoStructHandler_16_0.NativeStructWrapper dDDhIbJcytTgCZ0H3sl()
			{
				return NativePropertyInfoStructHandler_16_0.NativeStructWrapper.HDPhMFJuZ9ZFsYOLxop;
			}

			// Token: 0x04000121 RID: 289
			internal static object HDPhMFJuZ9ZFsYOLxop;
		}
	}
}
