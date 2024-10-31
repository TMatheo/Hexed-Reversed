using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.InteropTypes.Arrays
{
	// Token: 0x0200012D RID: 301
	public class Il2CppStringArray : Il2CppArrayBase<string>
	{
		// Token: 0x06000D1E RID: 3358 RVA: 0x00014B2C File Offset: 0x00012D2C
		static Il2CppStringArray()
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					Il2CppStringArray.V83ERbpijYTsmXFdMWM();
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92a7d78565474619a2c93ca9aa734139 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					Il2CppStringArray.Jfu8yrpd3cXnmCAtdNt();
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_441278fe93ad425f9343d4f7d1692fca != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					Il2CppStringArray.Ne7OrspIs8nDfMwnk8p();
					num2 = 2;
					continue;
				case 4:
					return;
				}
				Il2CppStringArray.thfg0spEoOCmchK08R6(Il2CppStringArray.H8QZobpwOjIQfhpeMHj(typeof(Il2CppStringArray).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV));
				num2 = 4;
			}
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00014BE8 File Offset: 0x00012DE8
		public Il2CppStringArray(IntPtr pointer)
		{
			Il2CppStringArray.Jfu8yrpd3cXnmCAtdNt();
			Il2CppStringArray.V83ERbpijYTsmXFdMWM();
			base..ctor(pointer);
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_508916f527eb4b05b32762ef07dd9e52 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00014C50 File Offset: 0x00012E50
		public Il2CppStringArray(long size)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			Il2CppStringArray.V83ERbpijYTsmXFdMWM();
			base..ctor(Il2CppStringArray.NQyLVbpBIEG9YNsm3VG(size));
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8378a46aa7ed47018832a42729b1bc3b != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00014CBC File Offset: 0x00012EBC
		public Il2CppStringArray(string[] arr)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			Il2CppStringArray.V83ERbpijYTsmXFdMWM();
			base..ctor(Il2CppStringArray.NQyLVbpBIEG9YNsm3VG((long)arr.Length));
			int num = 2;
			for (;;)
			{
				int num2;
				switch (num)
				{
				case 0:
					goto IL_A7;
				case 1:
					num2++;
					num = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6a95c50bbb48420f8f11bb090d6d3bd5 == 0)
					{
						num = 0;
						continue;
					}
					continue;
				case 2:
					num2 = 0;
					num = 3;
					continue;
				case 3:
					goto IL_A7;
				case 4:
					return;
				case 5:
					break;
				default:
					goto IL_A7;
				}
				IL_7B:
				this[num2] = arr[num2];
				num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e5b00aa4c99144c78d3bd63e270496cb != 0)
				{
					num = 1;
					continue;
				}
				continue;
				IL_A7:
				if (num2 < arr.Length)
				{
					goto IL_7B;
				}
				int num3 = 4;
				num = num3;
			}
		}

		// Token: 0x170004E1 RID: 1249
		public unsafe override string this[int index]
		{
			get
			{
				int num = 3;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_33;
					case 3:
						if (index < 0)
						{
							num2 = 2;
							continue;
						}
						goto IL_33;
					}
					break;
					IL_33:
					if (index < Il2CppStringArray.yXSviApGr7x02IRMT8k(this))
					{
						goto IL_BF;
					}
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2ec67b9ff6c4cd7af2a4ceec32c111c != 0)
					{
						num2 = 0;
					}
				}
				throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(~1524453083 ^ -177131277 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4da80845ebf7410ebbf942336f5ee27b), Il2CppStringArray.PuYZWSprIs5GZ08eV7b(-1459391761 ^ -390763933 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_30f9f5d7d3f347ddac00a7ce0719d7cd));
				IL_BF:
				return Il2CppStringArray.ctvnbFpoiQSaAL5aNDl(*Il2CppStringArray.WIbZqkpguDiOvQU81QE(Il2CppStringArray.WIbZqkpguDiOvQU81QE(base.Pointer, 4 * Il2CppStringArray.o6ihXVpTqrTNxX75vlF(cQkHnrc4uCYVWodZmHM.qhnc3Q5HwY), apS1BFcfBa3gXUspL9j.A06c1GDsfl), index * Il2CppStringArray.o6ihXVpTqrTNxX75vlF(cQkHnrc4uCYVWodZmHM.qhnc3Q5HwY), apS1BFcfBa3gXUspL9j.A06c1GDsfl));
			}
			set
			{
				int num = 2;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							goto IL_37;
						case 1:
							if (index >= Il2CppStringArray.yXSviApGr7x02IRMT8k(this))
							{
								goto IL_5B;
							}
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cb2874465fa5416db806f31e03cc475c != 0)
							{
								num2 = 0;
							}
							break;
						case 2:
							if (index < 0)
							{
								goto IL_5B;
							}
							num2 = 1;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c04403f838344b38b3a8911774a446ea != 0)
							{
								num2 = 1;
							}
							break;
						case 3:
							goto IL_5B;
						case 4:
							return;
						}
					}
					IL_37:
					*apS1BFcfBa3gXUspL9j.muOq5LWqgj(Il2CppStringArray.WIbZqkpguDiOvQU81QE(base.Pointer, 4 * Il2CppStringArray.o6ihXVpTqrTNxX75vlF(cQkHnrc4uCYVWodZmHM.qhnc3Q5HwY), apS1BFcfBa3gXUspL9j.A06c1GDsfl), index * Il2CppStringArray.o6ihXVpTqrTNxX75vlF(cQkHnrc4uCYVWodZmHM.qhnc3Q5HwY), apS1BFcfBa3gXUspL9j.A06c1GDsfl) = IL2CPP.ManagedStringToIl2Cpp(value);
					num = 4;
				}
				IL_5B:
				throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(457203345 ^ -2052212554 ^ -1779338507 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e6eb36653ec04a89bf8fa64932849f3b), hIDAYxH6DWLHIthQgC.gSCeTtiku(674965228 ^ 982390957 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7ac65c3fd4cb4629a8b893be89aed17d));
			}
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00015008 File Offset: 0x00013208
		public static implicit operator Il2CppStringArray(string[] arr)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (arr == null)
					{
						goto IL_2F;
					}
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6dbfd13d96434eb59d868fecd0ad1cda == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					goto IL_2F;
				}
				break;
			}
			goto IL_5D;
			IL_2F:
			return null;
			IL_5D:
			return new Il2CppStringArray(arr);
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00015098 File Offset: 0x00013298
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
						goto IL_94;
					}
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b4185925b5254e3aae05578c6a89b13c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			throw new ArgumentOutOfRangeException(Il2CppStringArray.PuYZWSprIs5GZ08eV7b(-1817151529 ^ -658580413 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bac7568f2bc04130b6b980225b2cc409), hIDAYxH6DWLHIthQgC.gSCeTtiku(106916134 + 835889755 ^ 1669285074 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ce8abd079f9447b3bade260ffc64f0b8));
			IL_94:
			IntPtr nativeClassPtr = Il2CppClassPointerStore<string>.NativeClassPtr;
			if (nativeClassPtr == IntPtr.Zero)
			{
				throw new ArgumentException(Il2CppStringArray.PuYZWSprIs5GZ08eV7b(1147518606 ^ 813546361 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2a3cb7fb82fa47c39f707a2393c1a340));
			}
			return IL2CPP.il2cpp_array_new(nativeClassPtr, (ulong)size);
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00015170 File Offset: 0x00013370
		internal static void Ne7OrspIs8nDfMwnk8p()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00015180 File Offset: 0x00013380
		internal static void Jfu8yrpd3cXnmCAtdNt()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00015190 File Offset: 0x00013390
		internal static void V83ERbpijYTsmXFdMWM()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x000151A0 File Offset: 0x000133A0
		internal static Type H8QZobpwOjIQfhpeMHj(RuntimeTypeHandle A_0, object A_1)
		{
			return KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x000151B8 File Offset: 0x000133B8
		internal static void thfg0spEoOCmchK08R6(Type A_0)
		{
			Il2CppArrayBase<string>.StaticCtorBody(A_0);
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x000151CC File Offset: 0x000133CC
		internal static bool NKKKyrpCvWLpPFFLuXG()
		{
			return Il2CppStringArray.HILaZZpWkqnooiRIsLL == null;
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x000151E0 File Offset: 0x000133E0
		internal static Il2CppStringArray HNbg0ap9rCJWKww6LXm()
		{
			return Il2CppStringArray.HILaZZpWkqnooiRIsLL;
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x000151F0 File Offset: 0x000133F0
		internal static IntPtr NQyLVbpBIEG9YNsm3VG(long size)
		{
			return Il2CppStringArray.AllocateArray(size);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00015204 File Offset: 0x00013404
		internal static int yXSviApGr7x02IRMT8k(object A_0)
		{
			return A_0.Length;
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00015218 File Offset: 0x00013418
		internal static object PuYZWSprIs5GZ08eV7b(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0001522C File Offset: 0x0001342C
		internal static int o6ihXVpTqrTNxX75vlF(object A_0)
		{
			return cQkHnrc4uCYVWodZmHM.muOq5LWqgj(A_0);
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00015240 File Offset: 0x00013440
		internal static IntPtr WIbZqkpguDiOvQU81QE(IntPtr A_0, int A_1, object A_2)
		{
			return apS1BFcfBa3gXUspL9j.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x0001525C File Offset: 0x0001345C
		internal static object ctvnbFpoiQSaAL5aNDl(IntPtr il2CppString)
		{
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x04000983 RID: 2435
		internal static Il2CppStringArray HILaZZpWkqnooiRIsLL;
	}
}
