using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.InteropTypes.Arrays
{
	// Token: 0x0200012F RID: 303
	public class Il2CppStringArray : Il2CppArrayBase<string>
	{
		// Token: 0x06000D40 RID: 3392 RVA: 0x000157D8 File Offset: 0x000139D8
		static Il2CppStringArray()
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					Il2CppStringArray.DdBq9mRiXdPG9XynkVS();
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2b9d7065e34e71a0069eb107f69f59 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					Il2CppStringArray.N8kSrxRGNhfeg6mLKwD();
					num2 = 3;
					continue;
				case 3:
					Il2CppStringArray.iZo0klRaFgHvBMnH0D3(Il2CppStringArray.iItTXLRYPJcPdnwdO3U(typeof(Il2CppStringArray).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an));
					num2 = 4;
					continue;
				case 4:
					return;
				}
				Il2CppStringArray.rpFN87RI70TIWN88qoS();
				num2 = 2;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5d181dabf1ed42eca63023d24d927754 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00015894 File Offset: 0x00013A94
		public Il2CppStringArray(IntPtr pointer)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			Il2CppStringArray.N8kSrxRGNhfeg6mLKwD();
			base..ctor(pointer);
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4e45528af4644e9b080e05d5ff6ef54 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x000158FC File Offset: 0x00013AFC
		public Il2CppStringArray(long size)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			Il2CppStringArray.N8kSrxRGNhfeg6mLKwD();
			base..ctor(Il2CppStringArray.ONrcjPRCoQLqr0oQHtW(size));
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

		// Token: 0x06000D43 RID: 3395 RVA: 0x00015968 File Offset: 0x00013B68
		public Il2CppStringArray(string[] arr)
		{
			Il2CppStringArray.rpFN87RI70TIWN88qoS();
			Il2CppStringArray.N8kSrxRGNhfeg6mLKwD();
			base..ctor(Il2CppStringArray.AllocateArray((long)arr.Length));
			int num = 1;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fcdd30171ceb4eb7a5570cbbc4f6aec1 == 0)
			{
				num = 0;
			}
			for (;;)
			{
				int num2;
				switch (num)
				{
				case 1:
					num2 = 0;
					num = 5;
					continue;
				case 2:
					num2++;
					num = 2;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3af7919884e4482186590a3e6e04f119 == 0)
					{
						num = 3;
						continue;
					}
					continue;
				case 3:
					goto IL_D1;
				case 4:
					return;
				case 5:
					goto IL_D1;
				}
				IL_A6:
				this[num2] = arr[num2];
				num = 2;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc != 0)
				{
					num = 2;
					continue;
				}
				continue;
				IL_D1:
				if (num2 < arr.Length)
				{
					goto IL_A6;
				}
				num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_75b92ac812f348208c578c3de71e2d57 == 0)
				{
					num = 4;
				}
			}
		}

		// Token: 0x170004E1 RID: 1249
		public unsafe override string this[int index]
		{
			get
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_EA;
					case 2:
						if (index < 0)
						{
							num2 = 1;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5a8626d471f54eba873ce59c8785d9b9 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 3:
						goto IL_49;
					}
					if (index < Il2CppStringArray.crj6A8RtoF1Sg4E8jtn(this))
					{
						goto IL_8B;
					}
					num2 = 3;
				}
				IL_49:
				throw new ArgumentOutOfRangeException(Il2CppStringArray.BHiKhhRxi6ZMAs6lmqb(189284862 - -678740789 ^ 668665678 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ea3a0368554c4e6093e0b0561ffd5cef), Il2CppStringArray.BHiKhhRxi6ZMAs6lmqb(1808198684 ^ 805410106 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fcdd30171ceb4eb7a5570cbbc4f6aec1));
				IL_8B:
				return Il2CppStringArray.uxRt2KR0faQ4mvtJTGn(*Il2CppStringArray.YwLc0yR8CnroIP9y1nE(Il2CppStringArray.YwLc0yR8CnroIP9y1nE(base.Pointer, 4 * Il2CppStringArray.ppds2hRhgtMQdUIbOZm(IreLT7A0Ync4AwEXIgw.thqANbO0eM), ksqFb8Il85Vq0skiabV.j8CIVKyZg8), index * Il2CppStringArray.ppds2hRhgtMQdUIbOZm(IreLT7A0Ync4AwEXIgw.thqANbO0eM), ksqFb8Il85Vq0skiabV.j8CIVKyZg8));
				IL_EA:
				goto IL_49;
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
						if (index >= 0)
						{
							goto IL_6D;
						}
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_780e0c86b08f49d785f406cf802c7e87 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_6D;
					case 4:
						return;
					}
					break;
					IL_6D:
					if (index >= base.Length)
					{
						num2 = 2;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_46ba390073ec4df6883860abf17dbf6f == 0)
						{
							num2 = 2;
						}
					}
					else
					{
						*Il2CppStringArray.YwLc0yR8CnroIP9y1nE(Il2CppStringArray.YwLc0yR8CnroIP9y1nE(base.Pointer, 4 * Il2CppStringArray.ppds2hRhgtMQdUIbOZm(IreLT7A0Ync4AwEXIgw.thqANbO0eM), ksqFb8Il85Vq0skiabV.j8CIVKyZg8), index * IreLT7A0Ync4AwEXIgw.i2IAUFsOOC(IreLT7A0Ync4AwEXIgw.thqANbO0eM), ksqFb8Il85Vq0skiabV.j8CIVKyZg8) = IL2CPP.ManagedStringToIl2Cpp(value);
						num2 = 4;
					}
				}
				throw new ArgumentOutOfRangeException(Il2CppStringArray.BHiKhhRxi6ZMAs6lmqb(256602955 + -2081249470 ^ -1673099359 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40), Il2CppStringArray.BHiKhhRxi6ZMAs6lmqb(-1422024723 ^ -866534983 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ddf0bbff3ec54ad39c6b2ba58dc80058));
			}
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00015CDC File Offset: 0x00013EDC
		public static implicit operator Il2CppStringArray(string[] arr)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (arr != null)
					{
						goto IL_52;
					}
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_806dbdb7f5194c2fa0c07a915df13fc8 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return null;
			IL_52:
			return new Il2CppStringArray(arr);
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00015D44 File Offset: 0x00013F44
		private static IntPtr AllocateArray(long size)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (size >= 0L)
					{
						goto IL_8E;
					}
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_1d16dd38ead14cb191f3b77c23c04ed4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(1570093376 ^ 124806922 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d691a76a9c4746c9a1a67e34c67ca64b), Il2CppStringArray.BHiKhhRxi6ZMAs6lmqb(-1887629927 ^ -1552506850 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_48b9993e573d4d08a64ac27c515a32b9));
			IL_8E:
			IntPtr nativeClassPtr = Il2CppClassPointerStore<string>.NativeClassPtr;
			if (nativeClassPtr == IntPtr.Zero)
			{
				throw new ArgumentException(hIDAYxH6DWLHIthQgC.gSCeTtiku(~499136732 ^ -1271966243 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_806dbdb7f5194c2fa0c07a915df13fc8));
			}
			return IL2CPP.il2cpp_array_new(nativeClassPtr, (ulong)size);
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00015E18 File Offset: 0x00014018
		internal static void DdBq9mRiXdPG9XynkVS()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00015E28 File Offset: 0x00014028
		internal static void rpFN87RI70TIWN88qoS()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00015E38 File Offset: 0x00014038
		internal static void N8kSrxRGNhfeg6mLKwD()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00015E48 File Offset: 0x00014048
		internal static Type iItTXLRYPJcPdnwdO3U(RuntimeTypeHandle A_0, object A_1)
		{
			return byRw0gA2NyqHkl03ii9.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00015E60 File Offset: 0x00014060
		internal static void iZo0klRaFgHvBMnH0D3(Type A_0)
		{
			Il2CppArrayBase<string>.StaticCtorBody(A_0);
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00015E74 File Offset: 0x00014074
		internal static bool MRhTBURqVLOurMVeqq4()
		{
			return Il2CppStringArray.AjcmreRUV8NNPYMtIPg == null;
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00015E88 File Offset: 0x00014088
		internal static Il2CppStringArray Kpe881R9LLVTPWToQ31()
		{
			return Il2CppStringArray.AjcmreRUV8NNPYMtIPg;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00015E98 File Offset: 0x00014098
		internal static IntPtr ONrcjPRCoQLqr0oQHtW(long size)
		{
			return Il2CppStringArray.AllocateArray(size);
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00015EAC File Offset: 0x000140AC
		internal static int crj6A8RtoF1Sg4E8jtn(object A_0)
		{
			return A_0.Length;
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00015EC0 File Offset: 0x000140C0
		internal static object BHiKhhRxi6ZMAs6lmqb(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00015ED4 File Offset: 0x000140D4
		internal static int ppds2hRhgtMQdUIbOZm(object A_0)
		{
			return IreLT7A0Ync4AwEXIgw.i2IAUFsOOC(A_0);
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00015EE8 File Offset: 0x000140E8
		internal static IntPtr YwLc0yR8CnroIP9y1nE(IntPtr A_0, int A_1, object A_2)
		{
			return ksqFb8Il85Vq0skiabV.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00015F04 File Offset: 0x00014104
		internal static object uxRt2KR0faQ4mvtJTGn(IntPtr il2CppString)
		{
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0400098E RID: 2446
		private static Il2CppStringArray AjcmreRUV8NNPYMtIPg;
	}
}
