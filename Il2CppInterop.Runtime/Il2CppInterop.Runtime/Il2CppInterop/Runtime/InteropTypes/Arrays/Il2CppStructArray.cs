using System;
using System.Runtime.CompilerServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.InteropTypes.Arrays
{
	// Token: 0x0200012E RID: 302
	public class Il2CppStructArray<[IsUnmanaged] T> : Il2CppArrayBase<T> where T : struct, ValueType
	{
		// Token: 0x06000D33 RID: 3379 RVA: 0x00015270 File Offset: 0x00013470
		static Il2CppStructArray()
		{
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					Il2CppArrayBase<T>.StaticCtorBody(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Il2CppStructArray<T>).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV));
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_11d7514559f14fcba52669ac71e3cb39 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					nHwRpygmi6xxZAssJn.EmlEpH4Phw();
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eeb967463afe407d8f7c3b354043704c == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					hIDAYxH6DWLHIthQgC.oDuBOTgYK();
					num2 = 2;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					hIDAYxH6DWLHIthQgC.zSLipEDdx();
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00015354 File Offset: 0x00013554
		public Il2CppStructArray(IntPtr nativeObject)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor(nativeObject);
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x000153BC File Offset: 0x000135BC
		public Il2CppStructArray(long size)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor(Il2CppStructArray<T>.AllocateArray(size));
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_40fe2648722c4d04bef43cdd927d6154 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00015428 File Offset: 0x00013628
		public Il2CppStructArray(T[] arr)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor(Il2CppStructArray<T>.AllocateArray((long)arr.Length));
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8160363759e64728b1ce193157380515 == 0)
			{
				num = 0;
			}
			for (;;)
			{
				int num2;
				switch (num)
				{
				case 0:
					goto IL_9D;
				case 1:
					return;
				case 2:
					break;
				case 3:
					break;
				case 4:
					goto IL_BA;
				case 5:
					num2++;
					num = 2;
					continue;
				default:
					goto IL_9D;
				}
				if (num2 < arr.Length)
				{
					goto IL_BA;
				}
				num = 1;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_64a8b41e58e0491ab0e9d05ec5ed61d3 != 0)
				{
					num = 1;
					continue;
				}
				continue;
				IL_9D:
				num2 = 0;
				num = 3;
				continue;
				IL_BA:
				this[num2] = arr[num2];
				num = 5;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6776fc69415b4d309be658e7e8ac3a28 != 0)
				{
					num = 5;
				}
			}
		}

		// Token: 0x170004E2 RID: 1250
		public unsafe override T this[int index]
		{
			get
			{
				if (index < 0 || index >= base.Length)
				{
					throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1066070775 ^ -796762859 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7dfb1d10537744ca9e949b6b3a3eac09), hIDAYxH6DWLHIthQgC.gSCeTtiku(-2138437892 - -65622770 ^ -1734508272 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92a7d78565474619a2c93ca9aa734139));
				}
				IntPtr intPtr = apS1BFcfBa3gXUspL9j.muOq5LWqgj(base.Pointer, 4 * cQkHnrc4uCYVWodZmHM.muOq5LWqgj(cQkHnrc4uCYVWodZmHM.qhnc3Q5HwY), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				return *(T*)((byte*)Mw7IMTckZt48JAHG0WH.muOq5LWqgj(ref intPtr, Mw7IMTckZt48JAHG0WH.u8Gc2tmlLS) + (IntPtr)index * (IntPtr)sizeof(T));
			}
			set
			{
				if (index < 0 || index >= base.Length)
				{
					throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(1662658398 ^ 2002817593 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ac2c10c141e144acbcef06aa86a10430), hIDAYxH6DWLHIthQgC.gSCeTtiku(-670896492 ^ -1628791093 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_40fe2648722c4d04bef43cdd927d6154));
				}
				IntPtr intPtr = apS1BFcfBa3gXUspL9j.muOq5LWqgj(base.Pointer, 4 * cQkHnrc4uCYVWodZmHM.muOq5LWqgj(cQkHnrc4uCYVWodZmHM.qhnc3Q5HwY), apS1BFcfBa3gXUspL9j.A06c1GDsfl);
				*(T*)((byte*)Mw7IMTckZt48JAHG0WH.muOq5LWqgj(ref intPtr, Mw7IMTckZt48JAHG0WH.u8Gc2tmlLS) + (IntPtr)index * (IntPtr)sizeof(T)) = value;
			}
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00015670 File Offset: 0x00013870
		public static implicit operator Il2CppStructArray<T>(T[] arr)
		{
			if (arr == null)
			{
				return null;
			}
			return new Il2CppStructArray<T>(arr);
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00015688 File Offset: 0x00013888
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_263609815aa041aea5525a459e9a816b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			throw new ArgumentOutOfRangeException(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1037388976 ^ 1897662843 ^ -1086144625 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b9b6cd6cbc040a7be58cff054f9e843), hIDAYxH6DWLHIthQgC.gSCeTtiku(1314478277 ^ 251498802 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4356a7af7f8147b79f2ed4ab0c268438));
			IL_94:
			IntPtr nativeClassPtr = Il2CppClassPointerStore<T>.NativeClassPtr;
			if (nativeClassPtr == IntPtr.Zero)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(48, 2);
				CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(379738335 >> 6 ^ 1138230620 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c04403f838344b38b3a8911774a446ea), CbStEuAV6XsjbRRcotu.WZrA06bJrN);
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-544074002 ^ -133158982 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_49f6034724814fe88f4ca6e5ef134249), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV));
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(567160369 ^ 1606573191 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0272cc4de9694915be17746e515675c8), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				throw new ArgumentException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
			}
			return IL2CPP.il2cpp_array_new(nativeClassPtr, (ulong)size);
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x000157EC File Offset: 0x000139EC
		internal static bool tfbjZtpjo5viZo6RAGf()
		{
			return Il2CppStructArray<T>.ORlqeFpUZsM0UFW7G41 == null;
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00015800 File Offset: 0x00013A00
		internal static object MkFtZSpQ5yNIxNu6xRN()
		{
			return Il2CppStructArray<T>.ORlqeFpUZsM0UFW7G41;
		}

		// Token: 0x04000984 RID: 2436
		internal static object ORlqeFpUZsM0UFW7G41;
	}
}
