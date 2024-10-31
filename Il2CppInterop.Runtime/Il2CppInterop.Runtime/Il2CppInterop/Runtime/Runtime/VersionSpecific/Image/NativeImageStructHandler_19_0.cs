using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x0200007D RID: 125
	[ApplicableToUnityVersionsSince("5.3.2")]
	public class NativeImageStructHandler_19_0 : INativeImageStructHandler, INativeStructHandler
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x0000E8CC File Offset: 0x0000CACC
		public int Size()
		{
			return sizeof(NativeImageStructHandler_19_0.Il2CppImage_19_0);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0000E8DC File Offset: 0x0000CADC
		public unsafe INativeImageStruct CreateNewStruct()
		{
			NativeImageStructHandler_19_0.Il2CppImage_19_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeImageStructHandler_19_0.Il2CppImage_19_0);
			return new NativeImageStructHandler_19_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0000E90C File Offset: 0x0000CB0C
		public unsafe INativeImageStruct Wrap(Il2CppImage* ptr)
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
			return new NativeImageStructHandler_19_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0000E974 File Offset: 0x0000CB74
		public NativeImageStructHandler_19_0()
		{
			NativeImageStructHandler_19_0.YvK8MXnXgKwPilMS6xL();
			NativeImageStructHandler_19_0.Oww5r8nc1QOu78HmCUE();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0000E9D8 File Offset: 0x0000CBD8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeImageStructHandler_19_0()
		{
			NativeImageStructHandler_19_0.U5kEa6nkujoQl9xsehS();
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0000E9E8 File Offset: 0x0000CBE8
		internal static bool XJcmg9nA7PmoAYP2Ih5()
		{
			return NativeImageStructHandler_19_0.Q9IVsXn5WjA7q0jn0CQ == null;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0000E9FC File Offset: 0x0000CBFC
		internal static NativeImageStructHandler_19_0 TOXuitnLfs7d8tTcvrv()
		{
			return NativeImageStructHandler_19_0.Q9IVsXn5WjA7q0jn0CQ;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0000EA0C File Offset: 0x0000CC0C
		internal static void YvK8MXnXgKwPilMS6xL()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0000EA1C File Offset: 0x0000CC1C
		internal static void Oww5r8nc1QOu78HmCUE()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0000EA2C File Offset: 0x0000CC2C
		internal static void U5kEa6nkujoQl9xsehS()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000206 RID: 518
		private static NativeImageStructHandler_19_0 Q9IVsXn5WjA7q0jn0CQ;

		// Token: 0x0200007E RID: 126
		internal struct Il2CppImage_19_0
		{
			// Token: 0x04000207 RID: 519
			public unsafe byte* name;

			// Token: 0x04000208 RID: 520
			public int assemblyIndex;

			// Token: 0x04000209 RID: 521
			public int typeStart;

			// Token: 0x0400020A RID: 522
			public uint typeCount;

			// Token: 0x0400020B RID: 523
			public int entryPointIndex;

			// Token: 0x0400020C RID: 524
			public unsafe void* nameToClassHashTable;

			// Token: 0x0400020D RID: 525
			public uint token;
		}

		// Token: 0x0200007F RID: 127
		internal class NativeStructWrapper : INativeImageStruct, INativeStruct
		{
			// Token: 0x060004DD RID: 1245 RVA: 0x0001ADD0 File Offset: 0x00018FD0
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeImageStructHandler_19_0.NativeStructWrapper.lJ4APpNAEslkFDv8CMd();
				NativeImageStructHandler_19_0.NativeStructWrapper.FwP6DSNL4Bd1LwpMq8L();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_22f9ae9a49f143d7bbb3b03eb2446c0f != 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb8decd62b945dda713f7b22b6b95ca == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x060004DE RID: 1246 RVA: 0x0001AE60 File Offset: 0x00019060
			private unsafe NativeImageStructHandler_19_0.Il2CppImage_19_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x060004DF RID: 1247 RVA: 0x0001AE70 File Offset: 0x00019070
			public IntPtr Pointer { get; }

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x060004E0 RID: 1248 RVA: 0x0001AE80 File Offset: 0x00019080
			public unsafe Il2CppImage* ImagePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0001AE90 File Offset: 0x00019090
			public bool HasNameNoExt
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0001AE9C File Offset: 0x0001909C
			public unsafe ref Il2CppAssembly* Assembly
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0001AEAC File Offset: 0x000190AC
			public ref byte Dynamic
			{
				get
				{
					return ref this._dynamicDummy;
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x060004E4 RID: 1252 RVA: 0x0001AEBC File Offset: 0x000190BC
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0001AED4 File Offset: 0x000190D4
			public ref IntPtr NameNoExt
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x060004E6 RID: 1254 RVA: 0x0001AEE4 File Offset: 0x000190E4
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeImageStructHandler_19_0.NativeStructWrapper.q9sWtoNXFtt0MdVE77w();
			}

			// Token: 0x060004E7 RID: 1255 RVA: 0x0001AEF4 File Offset: 0x000190F4
			internal static void lJ4APpNAEslkFDv8CMd()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060004E8 RID: 1256 RVA: 0x0001AF04 File Offset: 0x00019104
			internal static void FwP6DSNL4Bd1LwpMq8L()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x060004E9 RID: 1257 RVA: 0x0001AF14 File Offset: 0x00019114
			internal static bool hUqyuvNqrWEefBrnoHb()
			{
				return NativeImageStructHandler_19_0.NativeStructWrapper.iNqURFNlksbK3KZyQhm == null;
			}

			// Token: 0x060004EA RID: 1258 RVA: 0x0001AF28 File Offset: 0x00019128
			internal static NativeImageStructHandler_19_0.NativeStructWrapper WbP78fN5JPdd0pRfVH7()
			{
				return NativeImageStructHandler_19_0.NativeStructWrapper.iNqURFNlksbK3KZyQhm;
			}

			// Token: 0x060004EB RID: 1259 RVA: 0x0001AF38 File Offset: 0x00019138
			internal static void q9sWtoNXFtt0MdVE77w()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0400020E RID: 526
			private byte _dynamicDummy;

			// Token: 0x04000210 RID: 528
			internal static object iNqURFNlksbK3KZyQhm;
		}
	}
}
