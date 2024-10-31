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
		private static void Entry(IntPtr pCreateHook, IntPtr pRemoveHook, object baseDir)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (pCreateHook == IntPtr.Zero)
					{
						return;
					}
					num2 = 0;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_302aed8b9a4f4b8894d39c085f0150b4 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					if (baseDir == null)
					{
						num2 = 3;
						continue;
					}
					Logger.LogSuccess(hIDAYxH6DWLHIthQgC.gSCeTtiku(472176686 - 625101809 ^ -1534342490 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_43b596a520f548c6950ee674fb9d84d8));
					num2 = 7;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_0119f60806a248b6919db0af670ae27a == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					CheatManager.InjectCheats(baseDir);
					num2 = 5;
					continue;
				case 5:
					MonoManager.CheckBaseHooks();
					num2 = 8;
					continue;
				case 6:
					CDSbBRp9aCLFvhcrLL.k0sBmDS26(UTpGGxhoI4R5rF9a0u.k0sBmDS26(EZa0tPR5j8ckAlJoBk.k0sBmDS26(UHCQXjtmxchTbkgSSs.k0sBmDS26(WvAJgXKCyARlLHKKlX.k0sBmDS26(zhW75a0S0ZETvIxOC9.k0sBmDS26(zhW75a0S0ZETvIxOC9.JQ5yyLI01), WvAJgXKCyARlLHKKlX.RwJNhOgCW), UHCQXjtmxchTbkgSSs.nAU9i9Ps8), EZa0tPR5j8ckAlJoBk.p07LuOxR6), hIDAYxH6DWLHIthQgC.gSCeTtiku(-1501105832 - 1012204372 ^ 1580615180 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_3858ee13675945cbb5b881c5073a9cfb), UTpGGxhoI4R5rF9a0u.OFsmmTv3c), CDSbBRp9aCLFvhcrLL.lcLFeDPnK);
					num2 = 4;
					continue;
				case 7:
					HookManager.Initialize(pCreateHook, pRemoveHook);
					num2 = 6;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_5563f3cbf0014aa1b50b0d652816c527 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 8:
					return;
				}
				if (pRemoveHook == IntPtr.Zero)
				{
					break;
				}
				num2 = 2;
				if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_d509aebced084342a79500b2a43b1504 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002204 File Offset: 0x00000404
		public Boot()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.dxI7NE9hn1();
			base..ctor();
			int num = 0;
			if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_138d859d3f2047df875a5a6877d4c694 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002264 File Offset: 0x00000464
		internal static bool ekQ9dmkwWDs8v3HI9CE()
		{
			return Boot.SOYXJGkd73GfVMVIvH5 == null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002270 File Offset: 0x00000470
		internal static Boot DFtRuKkk0UJDwmJHN4f()
		{
			return Boot.SOYXJGkd73GfVMVIvH5;
		}

		// Token: 0x04000001 RID: 1
		private static Boot SOYXJGkd73GfVMVIvH5;
	}
}
