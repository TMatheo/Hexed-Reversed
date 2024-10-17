using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x0200007F RID: 127
	[ApplicableToUnityVersionsSince("5.3.2")]
	public class NativeImageStructHandler_19_0 : INativeImageStructHandler, INativeStructHandler
	{
		// Token: 0x060004F0 RID: 1264 RVA: 0x0000F4C4 File Offset: 0x0000D6C4
		public int Size()
		{
			return sizeof(NativeImageStructHandler_19_0.Il2CppImage_19_0);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000F4D4 File Offset: 0x0000D6D4
		public unsafe INativeImageStruct CreateNewStruct()
		{
			NativeImageStructHandler_19_0.Il2CppImage_19_0* ptr2;
			IntPtr ptr = ptr2 = NativeImageStructHandler_19_0.wFkARCu7rXrCMeDYSnU(this.Size());
			*ptr2 = default(NativeImageStructHandler_19_0.Il2CppImage_19_0);
			return new NativeImageStructHandler_19_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000F504 File Offset: 0x0000D704
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e236d804047744298c2380563ba7eca0 != 0)
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
			return new NativeImageStructHandler_19_0.NativeStructWrapper(ptr);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0000F56C File Offset: 0x0000D76C
		public NativeImageStructHandler_19_0()
		{
			NativeImageStructHandler_19_0.KhS2yDuRHuAI3SiVPKR();
			NativeImageStructHandler_19_0.rnd1OKuk7EvqbIpRZ8d();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2e7e5b018e46a2b3bb280ae243eb22 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeImageStructHandler_19_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0000F5E0 File Offset: 0x0000D7E0
		internal static IntPtr wFkARCu7rXrCMeDYSnU(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0000F5F4 File Offset: 0x0000D7F4
		internal static bool OW7DDuu6mPle79WsGnG()
		{
			return NativeImageStructHandler_19_0.wd9r0SucIYafHhuMD5U == null;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0000F608 File Offset: 0x0000D808
		internal static NativeImageStructHandler_19_0 yxkP6vuLObceywjDp8P()
		{
			return NativeImageStructHandler_19_0.wd9r0SucIYafHhuMD5U;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0000F618 File Offset: 0x0000D818
		internal static void KhS2yDuRHuAI3SiVPKR()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0000F628 File Offset: 0x0000D828
		internal static void rnd1OKuk7EvqbIpRZ8d()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x04000211 RID: 529
		internal static NativeImageStructHandler_19_0 wd9r0SucIYafHhuMD5U;

		// Token: 0x02000080 RID: 128
		internal struct Il2CppImage_19_0
		{
			// Token: 0x04000212 RID: 530
			public unsafe byte* name;

			// Token: 0x04000213 RID: 531
			public int assemblyIndex;

			// Token: 0x04000214 RID: 532
			public int typeStart;

			// Token: 0x04000215 RID: 533
			public uint typeCount;

			// Token: 0x04000216 RID: 534
			public int entryPointIndex;

			// Token: 0x04000217 RID: 535
			public unsafe void* nameToClassHashTable;

			// Token: 0x04000218 RID: 536
			public uint token;
		}

		// Token: 0x02000081 RID: 129
		internal class NativeStructWrapper : INativeImageStruct, INativeStruct
		{
			// Token: 0x060004FA RID: 1274 RVA: 0x0001BA78 File Offset: 0x00019C78
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeImageStructHandler_19_0.NativeStructWrapper.fvPX5DrPvaH4S1Z4i1I();
				NativeImageStructHandler_19_0.NativeStructWrapper.WMfAVprd4PG5jOjDr4K();
				base..ctor();
				int num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_16defe672aac4a3485dcd78387beb521 != 0)
				{
					num = 0;
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
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6104a350572547c0a789887568cca07c == 0)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x060004FB RID: 1275 RVA: 0x0001BB08 File Offset: 0x00019D08
			private unsafe NativeImageStructHandler_19_0.Il2CppImage_19_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x060004FC RID: 1276 RVA: 0x0001BB18 File Offset: 0x00019D18
			public IntPtr Pointer { get; }

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x060004FD RID: 1277 RVA: 0x0001BB28 File Offset: 0x00019D28
			public unsafe Il2CppImage* ImagePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x060004FE RID: 1278 RVA: 0x0001BB38 File Offset: 0x00019D38
			public bool HasNameNoExt
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x060004FF RID: 1279 RVA: 0x0001BB44 File Offset: 0x00019D44
			public unsafe ref Il2CppAssembly* Assembly
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x06000500 RID: 1280 RVA: 0x0001BB54 File Offset: 0x00019D54
			public ref byte Dynamic
			{
				get
				{
					return ref this._dynamicDummy;
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x06000501 RID: 1281 RVA: 0x0001BB64 File Offset: 0x00019D64
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x06000502 RID: 1282 RVA: 0x0001BB7C File Offset: 0x00019D7C
			public ref IntPtr NameNoExt
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x06000503 RID: 1283 RVA: 0x0001BB8C File Offset: 0x00019D8C
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeImageStructHandler_19_0.NativeStructWrapper.VLswPErw70sAOAsIe1a();
			}

			// Token: 0x06000504 RID: 1284 RVA: 0x0001BB9C File Offset: 0x00019D9C
			internal static void fvPX5DrPvaH4S1Z4i1I()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000505 RID: 1285 RVA: 0x0001BBAC File Offset: 0x00019DAC
			internal static void WMfAVprd4PG5jOjDr4K()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000506 RID: 1286 RVA: 0x0001BBBC File Offset: 0x00019DBC
			internal static bool Uo4mMJrbej7jl5xhVjX()
			{
				return NativeImageStructHandler_19_0.NativeStructWrapper.z9qykFroOCl2gVKMEsE == null;
			}

			// Token: 0x06000507 RID: 1287 RVA: 0x0001BBD0 File Offset: 0x00019DD0
			internal static NativeImageStructHandler_19_0.NativeStructWrapper pY5eSOrfZSE7ubssRsJ()
			{
				return NativeImageStructHandler_19_0.NativeStructWrapper.z9qykFroOCl2gVKMEsE;
			}

			// Token: 0x06000508 RID: 1288 RVA: 0x0001BBE0 File Offset: 0x00019DE0
			internal static void VLswPErw70sAOAsIe1a()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000219 RID: 537
			private byte _dynamicDummy;

			// Token: 0x0400021B RID: 539
			private static object z9qykFroOCl2gVKMEsE;
		}
	}
}
