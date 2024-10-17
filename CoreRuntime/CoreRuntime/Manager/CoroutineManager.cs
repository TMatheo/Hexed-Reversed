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
		// Token: 0x0600001D RID: 29 RVA: 0x000034CC File Offset: 0x000016CC
		public static void RunCoroutine(IEnumerator routine)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					CoroutineManager.QueuedEnums.Add(new CoroutineWrap(routine));
					num2 = 0;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_44b91839abc74b4e80f4fbc7e2f95d46 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000352C File Offset: 0x0000172C
		public static void StopCoroutine(IEnumerator routine)
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				CoroutineWrap coroutineWrap;
				switch (num2)
				{
				case 1:
					if (coroutineWrap == null)
					{
						num2 = 5;
						continue;
					}
					goto IL_BE;
				case 2:
					CS$<>8__locals1.routine = routine2;
					num2 = 6;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_fa60916c7a1349c5b763a777fb2641c6 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					num2 = 2;
					continue;
				case 4:
					goto IL_BE;
				case 6:
					coroutineWrap = (from x in CoroutineManager.QueuedEnums
					where x._coroutine == CS$<>8__locals1.routine
					select x).FirstOrDefault<CoroutineWrap>();
					num2 = 0;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_2fb74f9d085344138f63a1f1e086a85d != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
				IL_BE:
				CoroutineManager.QueuedEnums.Remove(coroutineWrap);
				num2 = 0;
				if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_87e5b6540b634fc2ba51a8e24880693f != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003634 File Offset: 0x00001834
		// Note: this type is marked as 'beforefieldinit'.
		static CoroutineManager()
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					CoroutineManager.QueuedEnums = new List<CoroutineWrap>();
					num2 = 0;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_ffa29b8d81de4abeb6a7b629819de9ed == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					nHwRpygmi6xxZAssJn.UoDdI5CpWg();
					num2 = 1;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_0bdee027790a49d8af2e7ff913456ed0 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					hIDAYxH6DWLHIthQgC.oDuBOTgYK();
					num2 = 2;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_4cbcb2d46d6c4286be8cf3e1dde6ad8c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000036E0 File Offset: 0x000018E0
		internal static bool NBnyZo2sYZp64Qfc0Aj()
		{
			return CoroutineManager.zL1a802hZBtB0kerMqR == null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000036EC File Offset: 0x000018EC
		internal static CoroutineManager sbg5Zq2cvOOgwLS3FLO()
		{
			return CoroutineManager.zL1a802hZBtB0kerMqR;
		}

		// Token: 0x04000009 RID: 9
		internal static List<CoroutineWrap> QueuedEnums;

		// Token: 0x0400000A RID: 10
		private static CoroutineManager zL1a802hZBtB0kerMqR;
	}
}
