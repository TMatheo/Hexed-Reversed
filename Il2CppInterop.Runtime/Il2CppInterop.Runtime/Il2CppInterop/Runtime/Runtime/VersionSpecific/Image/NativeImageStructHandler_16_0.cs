using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x0200007A RID: 122
	[ApplicableToUnityVersionsSince("5.2.2")]
	public class NativeImageStructHandler_16_0 : INativeImageStructHandler, INativeStructHandler
	{
		// Token: 0x060004BA RID: 1210 RVA: 0x0000E75C File Offset: 0x0000C95C
		public int Size()
		{
			return sizeof(NativeImageStructHandler_16_0.Il2CppImage_16_0);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0000E76C File Offset: 0x0000C96C
		public unsafe INativeImageStruct CreateNewStruct()
		{
			NativeImageStructHandler_16_0.Il2CppImage_16_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeImageStructHandler_16_0.Il2CppImage_16_0);
			return new NativeImageStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0000E79C File Offset: 0x0000C99C
		public unsafe INativeImageStruct Wrap(Il2CppImage* ptr)
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4f96e4bec76a4c34a19bcff463d6dc03 == 0)
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
			return new NativeImageStructHandler_16_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0000E804 File Offset: 0x0000CA04
		public NativeImageStructHandler_16_0()
		{
			NativeImageStructHandler_16_0.jWv1Ue8z7i5Pcd02qX8();
			NativeImageStructHandler_16_0.tmMUdWnldRPkbfXHvhK();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_fe27a6a8bfb848d1a3dd32bc5b1790e7 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0000E868 File Offset: 0x0000CA68
		// Note: this type is marked as 'beforefieldinit'.
		static NativeImageStructHandler_16_0()
		{
			NativeImageStructHandler_16_0.wWJkEnnq69N0G0Bnn6d();
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0000E878 File Offset: 0x0000CA78
		internal static bool UC1Llg8appgVpYm01xs()
		{
			return NativeImageStructHandler_16_0.evIIv28KPhJwLNnTHHg == null;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0000E88C File Offset: 0x0000CA8C
		internal static NativeImageStructHandler_16_0 EwqBTM8ZU8fxrlfM10l()
		{
			return NativeImageStructHandler_16_0.evIIv28KPhJwLNnTHHg;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000E89C File Offset: 0x0000CA9C
		internal static void jWv1Ue8z7i5Pcd02qX8()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0000E8AC File Offset: 0x0000CAAC
		internal static void tmMUdWnldRPkbfXHvhK()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0000E8BC File Offset: 0x0000CABC
		internal static void wWJkEnnq69N0G0Bnn6d()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040001FC RID: 508
		private static NativeImageStructHandler_16_0 evIIv28KPhJwLNnTHHg;

		// Token: 0x0200007B RID: 123
		internal struct Il2CppImage_16_0
		{
			// Token: 0x040001FD RID: 509
			public unsafe byte* name;

			// Token: 0x040001FE RID: 510
			public int assemblyIndex;

			// Token: 0x040001FF RID: 511
			public int typeStart;

			// Token: 0x04000200 RID: 512
			public uint typeCount;

			// Token: 0x04000201 RID: 513
			public int entryPointIndex;

			// Token: 0x04000202 RID: 514
			public unsafe void* nameToClassHashTable;
		}

		// Token: 0x0200007C RID: 124
		internal class NativeStructWrapper : INativeImageStruct, INativeStruct
		{
			// Token: 0x060004C4 RID: 1220 RVA: 0x0001AC58 File Offset: 0x00018E58
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeImageStructHandler_16_0.NativeStructWrapper.s7nsQkSQEj7uoIWKI3D();
				NativeImageStructHandler_16_0.NativeStructWrapper.iwBUJOSeJbgvArjKx7O();
				base..ctor();
				int num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_15379a47ca764a4e8e16ceaf4804e136 == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2adb3ca441e493aba80425bcc0f1db3 != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0001ACE8 File Offset: 0x00018EE8
			private unsafe NativeImageStructHandler_16_0.Il2CppImage_16_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0001ACF8 File Offset: 0x00018EF8
			public IntPtr Pointer { get; }

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0001AD08 File Offset: 0x00018F08
			public unsafe Il2CppImage* ImagePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0001AD18 File Offset: 0x00018F18
			public bool HasNameNoExt
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x060004C9 RID: 1225 RVA: 0x0001AD24 File Offset: 0x00018F24
			public unsafe ref Il2CppAssembly* Assembly
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x060004CA RID: 1226 RVA: 0x0001AD34 File Offset: 0x00018F34
			public ref byte Dynamic
			{
				get
				{
					return ref this._dynamicDummy;
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x060004CB RID: 1227 RVA: 0x0001AD44 File Offset: 0x00018F44
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x060004CC RID: 1228 RVA: 0x0001AD5C File Offset: 0x00018F5C
			public ref IntPtr NameNoExt
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x060004CD RID: 1229 RVA: 0x0001AD6C File Offset: 0x00018F6C
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeImageStructHandler_16_0.NativeStructWrapper.agAGq6SK4sQP6ReYbFA();
			}

			// Token: 0x060004CE RID: 1230 RVA: 0x0001AD7C File Offset: 0x00018F7C
			internal static void s7nsQkSQEj7uoIWKI3D()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x060004CF RID: 1231 RVA: 0x0001AD8C File Offset: 0x00018F8C
			internal static void iwBUJOSeJbgvArjKx7O()
			{
				nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			}

			// Token: 0x060004D0 RID: 1232 RVA: 0x0001AD9C File Offset: 0x00018F9C
			internal static bool KBm11OSUmreUcNT4HYG()
			{
				return NativeImageStructHandler_16_0.NativeStructWrapper.k5HOnXSoHv5MrwtsBuQ == null;
			}

			// Token: 0x060004D1 RID: 1233 RVA: 0x0001ADB0 File Offset: 0x00018FB0
			internal static NativeImageStructHandler_16_0.NativeStructWrapper v0uLG7Sjce35nKmm5xe()
			{
				return NativeImageStructHandler_16_0.NativeStructWrapper.k5HOnXSoHv5MrwtsBuQ;
			}

			// Token: 0x060004D2 RID: 1234 RVA: 0x0001ADC0 File Offset: 0x00018FC0
			internal static void agAGq6SK4sQP6ReYbFA()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000203 RID: 515
			private byte _dynamicDummy;

			// Token: 0x04000205 RID: 517
			internal static object k5HOnXSoHv5MrwtsBuQ;
		}
	}
}
