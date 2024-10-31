using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace CoreRuntime.Manager
{
	// Token: 0x02000006 RID: 6
	public static class CoroutineManager
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00003474 File Offset: 0x00001674
		public static void RunCoroutine(IEnumerator routine)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					CoroutineManager.QueuedEnums.Add(new CoroutineWrap(routine));
					num2 = 0;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_a7b8f11a3dc04c2894575bc1f957bd5d != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000034D4 File Offset: 0x000016D4
		public static void StopCoroutine(IEnumerator routine)
		{
			int num = 1;
			for (;;)
			{
				int num2 = num;
				CoroutineWrap coroutineWrap;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						num2 = 0;
						if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_71c7cb2bd1f54a2da861ecddf0125b03 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						goto IL_86;
					case 4:
						if (coroutineWrap == null)
						{
							return;
						}
						num2 = 2;
						if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_0d6f1b1d53ea401dac5370118afd5971 != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 5:
						CoroutineManager.QueuedEnums.Remove(coroutineWrap);
						num2 = 2;
						if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_5d0fdc373cde4068a8053e8907aa08b1 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					goto Block_1;
				}
				IL_86:
				coroutineWrap = (from x in CoroutineManager.QueuedEnums
				where x._coroutine == CS$<>8__locals1.routine
				select x).FirstOrDefault<CoroutineWrap>();
				num = 4;
				continue;
				IL_B2:
				CS$<>8__locals1.routine = routine2;
				num = 3;
				continue;
				Block_1:
				goto IL_B2;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000035D0 File Offset: 0x000017D0
		// Note: this type is marked as 'beforefieldinit'.
		static CoroutineManager()
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					nHwRpygmi6xxZAssJn.dxI7NE9hn1();
					num2 = 0;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_70bc873b0ed747178a0929a3d2ee0102 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					hIDAYxH6DWLHIthQgC.oDuBOTgYK();
					num2 = 1;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_781114abd2034347956064bb551f8f7d == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				}
				CoroutineManager.QueuedEnums = new List<CoroutineWrap>();
				num2 = 3;
				if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_70bc873b0ed747178a0929a3d2ee0102 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000367C File Offset: 0x0000187C
		internal static bool dp1BUjki6k7mg5iO2N0()
		{
			return CoroutineManager.qv7Fs7kG3gMZSPURGM3 == null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003688 File Offset: 0x00001888
		internal static CoroutineManager dgYvqikurJyJZep6QPB()
		{
			return CoroutineManager.qv7Fs7kG3gMZSPURGM3;
		}

		// Token: 0x04000009 RID: 9
		internal static List<CoroutineWrap> QueuedEnums;

		// Token: 0x0400000A RID: 10
		internal static CoroutineManager qv7Fs7kG3gMZSPURGM3;
	}
}
