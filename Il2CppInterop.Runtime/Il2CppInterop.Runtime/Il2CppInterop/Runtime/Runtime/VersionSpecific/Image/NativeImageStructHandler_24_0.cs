using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x02000082 RID: 130
	[ApplicableToUnityVersionsSince("2017.1.0")]
	public class NativeImageStructHandler_24_0 : INativeImageStructHandler, INativeStructHandler
	{
		// Token: 0x06000509 RID: 1289 RVA: 0x0000F638 File Offset: 0x0000D838
		public int Size()
		{
			return sizeof(NativeImageStructHandler_24_0.Il2CppImage_24_0);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0000F648 File Offset: 0x0000D848
		public unsafe INativeImageStruct CreateNewStruct()
		{
			NativeImageStructHandler_24_0.Il2CppImage_24_0* ptr2;
			IntPtr ptr = ptr2 = NativeImageStructHandler_24_0.SfDclbuDCB4SmyVKYpg(this.Size());
			*ptr2 = default(NativeImageStructHandler_24_0.Il2CppImage_24_0);
			return new NativeImageStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0000F678 File Offset: 0x0000D878
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d691a76a9c4746c9a1a67e34c67ca64b == 0)
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
			return new NativeImageStructHandler_24_0.NativeStructWrapper(ptr);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0000F6E0 File Offset: 0x0000D8E0
		public NativeImageStructHandler_24_0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			NativeImageStructHandler_24_0.ThYOLTuZ1MP1MkF093J();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_feee416e61094c739ba253659ac2e257 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0000F744 File Offset: 0x0000D944
		// Note: this type is marked as 'beforefieldinit'.
		static NativeImageStructHandler_24_0()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0000F754 File Offset: 0x0000D954
		internal static IntPtr SfDclbuDCB4SmyVKYpg(int size)
		{
			return MarshalExtend.AllocHGlobal(size);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0000F768 File Offset: 0x0000D968
		internal static bool w6ufMVuWBypWiYH7BhW()
		{
			return NativeImageStructHandler_24_0.zDMECwuJCu6eyWdhVqs == null;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0000F77C File Offset: 0x0000D97C
		internal static NativeImageStructHandler_24_0 tO95NqurRWvdql3Qd9c()
		{
			return NativeImageStructHandler_24_0.zDMECwuJCu6eyWdhVqs;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0000F78C File Offset: 0x0000D98C
		internal static void ThYOLTuZ1MP1MkF093J()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x0400021C RID: 540
		private static NativeImageStructHandler_24_0 zDMECwuJCu6eyWdhVqs;

		// Token: 0x02000083 RID: 131
		internal struct Il2CppImage_24_0
		{
			// Token: 0x0400021D RID: 541
			public unsafe byte* name;

			// Token: 0x0400021E RID: 542
			public int assemblyIndex;

			// Token: 0x0400021F RID: 543
			public int typeStart;

			// Token: 0x04000220 RID: 544
			public uint typeCount;

			// Token: 0x04000221 RID: 545
			public int exportedTypeStart;

			// Token: 0x04000222 RID: 546
			public uint exportedTypeCount;

			// Token: 0x04000223 RID: 547
			public int entryPointIndex;

			// Token: 0x04000224 RID: 548
			public unsafe void* nameToClassHashTable;

			// Token: 0x04000225 RID: 549
			public uint token;
		}

		// Token: 0x02000084 RID: 132
		internal class NativeStructWrapper : INativeImageStruct, INativeStruct
		{
			// Token: 0x06000512 RID: 1298 RVA: 0x0001BBF0 File Offset: 0x00019DF0
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeImageStructHandler_24_0.NativeStructWrapper.rqZfvYrgFHOXx4uYjuw();
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_eea945ea6be345c0b18511ac11610b35 == 0)
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
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_61a3825996b24609815f6b482bf680d9 != 0)
					{
						num = 0;
					}
				}
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x06000513 RID: 1299 RVA: 0x0001BC80 File Offset: 0x00019E80
			private unsafe NativeImageStructHandler_24_0.Il2CppImage_24_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x06000514 RID: 1300 RVA: 0x0001BC90 File Offset: 0x00019E90
			public IntPtr Pointer { get; }

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x06000515 RID: 1301 RVA: 0x0001BCA0 File Offset: 0x00019EA0
			public unsafe Il2CppImage* ImagePointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x06000516 RID: 1302 RVA: 0x0001BCB0 File Offset: 0x00019EB0
			public bool HasNameNoExt
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x06000517 RID: 1303 RVA: 0x0001BCBC File Offset: 0x00019EBC
			public unsafe ref Il2CppAssembly* Assembly
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x06000518 RID: 1304 RVA: 0x0001BCCC File Offset: 0x00019ECC
			public ref byte Dynamic
			{
				get
				{
					return ref this._dynamicDummy;
				}
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x06000519 RID: 1305 RVA: 0x0001BCDC File Offset: 0x00019EDC
			public unsafe ref IntPtr Name
			{
				get
				{
					return ref *(IntPtr*)(&this._->name);
				}
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x0600051A RID: 1306 RVA: 0x0001BCF4 File Offset: 0x00019EF4
			public ref IntPtr NameNoExt
			{
				get
				{
					throw new NotSupportedException();
				}
			}

			// Token: 0x0600051B RID: 1307 RVA: 0x0001BD04 File Offset: 0x00019F04
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeImageStructHandler_24_0.NativeStructWrapper.iFh0EIrltt4DlBGbCRA();
			}

			// Token: 0x0600051C RID: 1308 RVA: 0x0001BD14 File Offset: 0x00019F14
			internal static void rqZfvYrgFHOXx4uYjuw()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x0600051D RID: 1309 RVA: 0x0001BD24 File Offset: 0x00019F24
			internal static bool HZO9NFryX6q4MnSOW8h()
			{
				return NativeImageStructHandler_24_0.NativeStructWrapper.D9EJVMr2GFjV7oeVL76 == null;
			}

			// Token: 0x0600051E RID: 1310 RVA: 0x0001BD38 File Offset: 0x00019F38
			internal static NativeImageStructHandler_24_0.NativeStructWrapper axje6FrSiT74NqCBfJa()
			{
				return NativeImageStructHandler_24_0.NativeStructWrapper.D9EJVMr2GFjV7oeVL76;
			}

			// Token: 0x0600051F RID: 1311 RVA: 0x0001BD48 File Offset: 0x00019F48
			internal static void iFh0EIrltt4DlBGbCRA()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000226 RID: 550
			private byte _dynamicDummy;

			// Token: 0x04000228 RID: 552
			private static object D9EJVMr2GFjV7oeVL76;
		}
	}
}
