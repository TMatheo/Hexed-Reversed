using System;
using System.Collections;
using CoreRuntime.Wrappers;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;
using UnityEngine;

namespace CoreRuntime.Manager
{
	// Token: 0x02000008 RID: 8
	internal class CoroutineWrap
	{
		// Token: 0x06000026 RID: 38 RVA: 0x000036F4 File Offset: 0x000018F4
		public CoroutineWrap(IEnumerator enu)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.UoDdI5CpWg();
			this._startTime = UTUoEskVajcPfb5Ng9N.Vkgsu7Vsh(UTUoEskVajcPfb5Ng9N.xx2kHy2Ewn);
			base..ctor();
			int num = 0;
			if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_ed6240c80c8c44b49bedc1856b4b4eae != 0)
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
				this._coroutine = enu;
				num = 0;
				if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_4ef4e6bb6996425889844972b794e594 != 0)
				{
					num = 1;
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003790 File Offset: 0x00001990
		public bool MoveNext()
		{
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					object obj;
					WaitUntil waitUntil;
					switch (num2)
					{
					case 1:
					{
						WaitWhile waitWhile;
						this._waiting = yjjkw6kJOIuDZZNU1ty.Vkgsu7Vsh(waitWhile, yjjkw6kJOIuDZZNU1ty.cIXkCUiM97);
						num2 = 17;
						if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_33a8f57c176f4d198f1febe007b7e26a == 0)
						{
							num2 = 15;
							continue;
						}
						continue;
					}
					case 2:
						if (this._waiting)
						{
							num2 = 0;
							if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_ee3ed32d72034860b0af9b26a15650c0 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						else
						{
							if (!jFF7XLkgd8gIZkfLA0G.Vkgsu7Vsh(this._coroutine, jFF7XLkgd8gIZkfLA0G.rhmk9h6Nw0))
							{
								num2 = 21;
								continue;
							}
							goto IL_2FD;
						}
						break;
					case 3:
						if (UTUoEskVajcPfb5Ng9N.Vkgsu7Vsh(UTUoEskVajcPfb5Ng9N.xx2kHy2Ewn) - this._startTime >= this._waitTime)
						{
							num2 = 2;
							if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_1b4f5aa4a1234ebea96b31189690ee77 != 0)
							{
								num2 = 2;
								continue;
							}
							continue;
						}
						break;
					case 4:
					{
						WaitForSecondsRealtime waitForSecondsRealtime = obj as WaitForSecondsRealtime;
						num2 = 6;
						continue;
					}
					case 5:
						if (!(obj is WaitForFixedUpdate))
						{
							num2 = 25;
							continue;
						}
						return true;
					case 6:
					{
						WaitForSecondsRealtime waitForSecondsRealtime;
						if (waitForSecondsRealtime == null)
						{
							num2 = 12;
							continue;
						}
						this._waiting = yjjkw6kJOIuDZZNU1ty.Vkgsu7Vsh(waitForSecondsRealtime, yjjkw6kJOIuDZZNU1ty.cIXkCUiM97);
						num2 = 24;
						continue;
					}
					case 7:
						goto IL_2FD;
					case 8:
						return true;
					case 9:
					{
						WaitForSeconds waitForSeconds;
						if (waitForSeconds == null)
						{
							num2 = 4;
							continue;
						}
						goto IL_239;
					}
					case 10:
						if (waitUntil == null)
						{
							goto Block_11;
						}
						this._waiting = yjjkw6kJOIuDZZNU1ty.Vkgsu7Vsh(waitUntil, yjjkw6kJOIuDZZNU1ty.cIXkCUiM97);
						num2 = 18;
						if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_14220072943b47f99fd6e94ff4c63aa5 != 0)
						{
							num2 = 9;
							continue;
						}
						continue;
					case 11:
					{
						WaitForSeconds waitForSeconds = obj as WaitForSeconds;
						num2 = 9;
						if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_ac5a396fb1314f03b00a1c1c1fb25832 != 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					}
					case 12:
						if (!(obj is WaitForEndOfFrame))
						{
							num2 = 5;
							continue;
						}
						return true;
					case 13:
						goto IL_239;
					case 14:
						goto IL_2B1;
					case 15:
					{
						WaitWhile waitWhile = obj as WaitWhile;
						num2 = 19;
						continue;
					}
					case 16:
						return true;
					case 17:
						return true;
					case 18:
						return true;
					case 19:
					{
						WaitWhile waitWhile;
						if (waitWhile == null)
						{
							goto IL_2A2;
						}
						num2 = 1;
						if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_a9e6643767b24faeb22874c272d31c0c == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					case 20:
					{
						WaitForSeconds waitForSeconds;
						this._waitTime = RPquxQkcGL8Nqig1Pfq.Vkgsu7Vsh(waitForSeconds, RPquxQkcGL8Nqig1Pfq.wiekA7ZjcL);
						num2 = 8;
						continue;
					}
					case 21:
						return false;
					case 22:
						goto IL_2A2;
					case 23:
						return true;
					case 24:
						return true;
					case 25:
						if (obj == null)
						{
							num2 = 23;
							continue;
						}
						goto IL_2B1;
					}
					goto Block_1;
					IL_239:
					this._startTime = UTUoEskVajcPfb5Ng9N.Vkgsu7Vsh(UTUoEskVajcPfb5Ng9N.xx2kHy2Ewn);
					num2 = 20;
					continue;
					IL_2A2:
					Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(-2085063068 ^ -675752628 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_434d3901588e427a807b42f125cc2ce3));
					num2 = 16;
					continue;
					IL_2B1:
					waitUntil = (obj as WaitUntil);
					num2 = 10;
					continue;
					IL_2FD:
					obj = ARXvvSkh2rgmNCjwQVn.Vkgsu7Vsh(this._coroutine, ARXvvSkh2rgmNCjwQVn.Iteks3MMEv);
					num2 = 11;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_c562bff83da649f1af22aec8f521fe1d == 0)
					{
						num2 = 11;
					}
				}
				Block_11:
				num = 15;
			}
			Block_1:
			return true;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003B14 File Offset: 0x00001D14
		internal static bool BquP1d2JMUFisAuRqX4()
		{
			return CoroutineWrap.zxgXE32A1bwS1hQmFH7 == null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003B20 File Offset: 0x00001D20
		internal static CoroutineWrap nhTd2j2CGSTseKOjoSF()
		{
			return CoroutineWrap.zxgXE32A1bwS1hQmFH7;
		}

		// Token: 0x0400000D RID: 13
		public readonly IEnumerator _coroutine;

		// Token: 0x0400000E RID: 14
		private float _startTime;

		// Token: 0x0400000F RID: 15
		private float _waitTime;

		// Token: 0x04000010 RID: 16
		private bool _waiting;

		// Token: 0x04000011 RID: 17
		private static CoroutineWrap zxgXE32A1bwS1hQmFH7;
	}
}
