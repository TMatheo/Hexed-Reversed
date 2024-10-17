using System;
using CoreRuntime.Manager;
using CoreRuntime.Wrappers;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace CoreRuntime
{
	// Token: 0x02000002 RID: 2
	public class Boot
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002060 File Offset: 0x00000260
		private static void Entry(IntPtr pCreateHook, IntPtr pRemoveHook)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					IcESJCjNCBkmXZ9KmQ.Vkgsu7Vsh(GFqAQHOdVUCtrs7yZx.Vkgsu7Vsh(rZrH1314Uo11aaKqpD.Vkgsu7Vsh(GT3G9MQmIwCwwyX5KR.Vkgsu7Vsh(WZedFaJiQANw5LiGpN.Vkgsu7Vsh(VitR1pcm0SIa2t7r5D.Vkgsu7Vsh(VitR1pcm0SIa2t7r5D.EHUAVMHB4), WZedFaJiQANw5LiGpN.LtbCTM2En), GT3G9MQmIwCwwyX5KR.voTIvcHbX), rZrH1314Uo11aaKqpD.HZovfD3RY), hIDAYxH6DWLHIthQgC.gSCeTtiku(1393515205 ^ 789935531 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_98fd8e694684493ba2ae034d20be4be9), GFqAQHOdVUCtrs7yZx.EXWmoUsjs), IcESJCjNCBkmXZ9KmQ.rX4Uus7Qk);
					num2 = 6;
					break;
				case 1:
					if (pRemoveHook == IntPtr.Zero)
					{
						num2 = 0;
						if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_32911dce27c04054b2ecfdfc0d36115c != 0)
						{
							num2 = 4;
						}
					}
					else
					{
						Logger.LogSuccess(hIDAYxH6DWLHIthQgC.gSCeTtiku(1137899459 ^ 2120204235 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_ee5f85992ef34584af1f0ef0ef2afddb));
						num2 = 5;
						if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_47329f189feb4b8e80da5c054d0462a0 != 0)
						{
							num2 = 4;
						}
					}
					break;
				case 2:
					if (pCreateHook == IntPtr.Zero)
					{
						return;
					}
					num2 = 1;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_9659e700394c4bbbb6e5a258b827bed3 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					MonoManager.CheckBaseHooks();
					num2 = 7;
					break;
				case 4:
					return;
				case 5:
					HookManager.Initialize(pCreateHook, pRemoveHook);
					num2 = 0;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_434d3901588e427a807b42f125cc2ce3 == 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					CheatManager.InjectCheats();
					num2 = 3;
					break;
				case 7:
					return;
				}
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021E4 File Offset: 0x000003E4
		public Boot()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.UoDdI5CpWg();
			base..ctor();
			int num = 0;
			if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_f78ec114ba134530b494cb8149d9ceec != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002244 File Offset: 0x00000444
		internal static bool mw5wV62ZboqNshMVUP0()
		{
			return Boot.Ts8jXb221gOAo2bHIq5 == null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002250 File Offset: 0x00000450
		internal static Boot gLGKOc2qwHYMlHYhUqo()
		{
			return Boot.Ts8jXb221gOAo2bHIq5;
		}

		// Token: 0x04000001 RID: 1
		internal static Boot Ts8jXb221gOAo2bHIq5;
	}
}
