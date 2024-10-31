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
		// Token: 0x06000026 RID: 38 RVA: 0x00003690 File Offset: 0x00001890
		public CoroutineWrap(IEnumerator enu)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.dxI7NE9hn1();
			this._startTime = nEkMOy37e7TSknHXuko.k0sBmDS26(nEkMOy37e7TSknHXuko.C2Y36QOxIX);
			base..ctor();
			int num = 1;
			if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_dcf84e8319244749981a1c1598c3e1ed != 0)
			{
				num = 1;
			}
			for (;;)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					this._coroutine = enu;
					num = 0;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_e30fcbaf4c4a4253bdef4e5f67f857db != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000372C File Offset: 0x0000192C
		public bool MoveNext()
		{
			int num = 19;
			int num2 = num;
			for (;;)
			{
				object obj;
				WaitUntil waitUntil;
				WaitWhile waitWhile;
				switch (num2)
				{
				case 1:
					if (obj is WaitForFixedUpdate)
					{
						return true;
					}
					num2 = 21;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_fc674978ce33427da1fe04b9f2a2bf37 == 0)
					{
						num2 = 25;
						continue;
					}
					continue;
				case 2:
					return false;
				case 3:
					this._waiting = Wut4Wc30Hs6Vu210dwC.k0sBmDS26(waitUntil, Wut4Wc30Hs6Vu210dwC.d5B3ynk7gd);
					num2 = 16;
					continue;
				case 4:
					return true;
				case 5:
					goto IL_213;
				case 6:
					goto IL_88;
				case 7:
					if (obj is WaitForEndOfFrame)
					{
						return true;
					}
					num2 = 1;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_0119f60806a248b6919db0af670ae27a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 8:
				{
					WaitForSeconds waitForSeconds;
					this._waitTime = ikh8c53u9BttL2UbSXA.k0sBmDS26(waitForSeconds, ikh8c53u9BttL2UbSXA.P1T3BhnM77);
					num2 = 10;
					continue;
				}
				case 9:
					goto IL_D4;
				case 10:
					return true;
				case 11:
					goto IL_1D5;
				case 12:
				{
					WaitForSecondsRealtime waitForSecondsRealtime = obj as WaitForSecondsRealtime;
					num2 = 17;
					continue;
				}
				case 13:
					goto IL_15C;
				case 14:
					return true;
				case 15:
					if (waitUntil != null)
					{
						num2 = 3;
						continue;
					}
					goto IL_213;
				case 16:
					return true;
				case 17:
				{
					WaitForSecondsRealtime waitForSecondsRealtime;
					if (waitForSecondsRealtime == null)
					{
						num2 = 7;
						continue;
					}
					this._waiting = Wut4Wc30Hs6Vu210dwC.k0sBmDS26(waitForSecondsRealtime, Wut4Wc30Hs6Vu210dwC.d5B3ynk7gd);
					num2 = 26;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_489417e8e717471992bde0e896149577 == 0)
					{
						num2 = 13;
						continue;
					}
					continue;
				}
				case 18:
					if (this._waiting)
					{
						num2 = 22;
						continue;
					}
					if (TvAHxl3W9CLFHJJijmf.k0sBmDS26(this._coroutine, TvAHxl3W9CLFHJJijmf.w3t3eyYsaj))
					{
						goto IL_1D5;
					}
					num2 = 2;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_9ae8a86cc9594ac288e5d2da6f82339f == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 19:
					if (nEkMOy37e7TSknHXuko.k0sBmDS26(nEkMOy37e7TSknHXuko.C2Y36QOxIX) - this._startTime >= this._waitTime)
					{
						num2 = 18;
						continue;
					}
					return true;
				case 20:
				{
					WaitForSeconds waitForSeconds = obj as WaitForSeconds;
					num2 = 24;
					continue;
				}
				case 21:
					if (waitWhile != null)
					{
						num2 = 23;
						continue;
					}
					goto IL_88;
				case 22:
					return true;
				case 23:
					this._waiting = Wut4Wc30Hs6Vu210dwC.k0sBmDS26(waitWhile, Wut4Wc30Hs6Vu210dwC.d5B3ynk7gd);
					num2 = 4;
					continue;
				case 24:
				{
					WaitForSeconds waitForSeconds;
					if (waitForSeconds == null)
					{
						num2 = 12;
						continue;
					}
					goto IL_15C;
				}
				case 25:
					if (obj != null)
					{
						goto IL_D4;
					}
					num2 = 0;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_a95e338918c04556aaf47418274cca2d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 26:
					return true;
				}
				break;
				IL_88:
				Logger.LogWarning(hIDAYxH6DWLHIthQgC.gSCeTtiku(-295046568 ^ -1841237901 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_a3ef764822b249b0bdf61221ef3b4538));
				num2 = 14;
				if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_43b596a520f548c6950ee674fb9d84d8 == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_D4:
				waitUntil = (obj as WaitUntil);
				num2 = 10;
				if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_d77a69ee63374251a67c9d6fd02df546 == 0)
				{
					num2 = 15;
					continue;
				}
				continue;
				IL_15C:
				this._startTime = nEkMOy37e7TSknHXuko.k0sBmDS26(nEkMOy37e7TSknHXuko.C2Y36QOxIX);
				num2 = 8;
				continue;
				IL_1D5:
				obj = P2OVYx3GkM6Tx8T3aWD.k0sBmDS26(this._coroutine, P2OVYx3GkM6Tx8T3aWD.j5e3iNepc8);
				num2 = 20;
				continue;
				IL_213:
				waitWhile = (obj as WaitWhile);
				num2 = 9;
				if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_19219e20007142d38523f07c38cd8ec6 != 0)
				{
					num2 = 21;
				}
			}
			return true;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003AD8 File Offset: 0x00001CD8
		internal static bool SLlGVfk0WHeXGdgt7D0()
		{
			return CoroutineWrap.V8TwvFkB7JhMGwgcQBN == null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003AE4 File Offset: 0x00001CE4
		internal static CoroutineWrap Q3gxaIkym3vVF7b9QVt()
		{
			return CoroutineWrap.V8TwvFkB7JhMGwgcQBN;
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
		internal static CoroutineWrap V8TwvFkB7JhMGwgcQBN;
	}
}
