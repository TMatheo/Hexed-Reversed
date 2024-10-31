using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace CoreRuntime.Manager
{
	// Token: 0x02000009 RID: 9
	public class HookManager
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00003AEC File Offset: 0x00001CEC
		internal static void Initialize(IntPtr pCreateHook, IntPtr pRemoveHook)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					HookManager.RemoveHook = HookManager.CreateDelegate<HookManager._RemoveHook>(pRemoveHook);
					num2 = 2;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_f38cc8c3333245b7ba6695b5d5b45799 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					HookManager.CreateHook = HookManager.CreateDelegate<HookManager._CreateHook>(pCreateHook);
					num2 = 0;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_ed1e9805f739424e9bc052dbd869ac49 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003B78 File Offset: 0x00001D78
		public static T CreateDelegate<T>(IntPtr method) where T : Delegate
		{
			return dVdtxT3t2LiZMUKEiy8.k0sBmDS26(method, EnlOxL3KU2n5cwR6bLM.k0sBmDS26(typeof(T).TypeHandle, EnlOxL3KU2n5cwR6bLM.EMH3NTwRFd), dVdtxT3t2LiZMUKEiy8.utE39X0IfH) as T;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003BA0 File Offset: 0x00001DA0
		public static T CreateDelegate<T>(IntPtr method, out T Outdelegate) where T : Delegate
		{
			return Outdelegate = (dVdtxT3t2LiZMUKEiy8.k0sBmDS26(method, EnlOxL3KU2n5cwR6bLM.k0sBmDS26(typeof(T).TypeHandle, EnlOxL3KU2n5cwR6bLM.EMH3NTwRFd), dVdtxT3t2LiZMUKEiy8.utE39X0IfH) as T);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003BDC File Offset: 0x00001DDC
		public unsafe static T Detour<T>(IntPtr target, T detour) where T : Delegate
		{
			if (target == IntPtr.Zero || ua6Nfw3REKYySrLpIM5.k0sBmDS26(detour, null, ua6Nfw3REKYySrLpIM5.GDs3Laju0w))
			{
				throw new ArgumentException(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1463496111 ^ -663088468 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_512cfa2b9095423a8666641af6192fd6));
			}
			HookManager.PinnedDelegates.Add(detour);
			IntPtr* ptr = &target;
			IntPtr* ptr2;
			HookManager.CreateHook(*ptr, Marshal.GetFunctionPointerForDelegate<T>(detour), out ptr2);
			return Marshal.GetDelegateForFunctionPointer<T>(ptr2);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003C5C File Offset: 0x00001E5C
		public unsafe static T Detour<T>(MethodInfo target, T detour) where T : Delegate
		{
			return HookManager.Detour<T>(*(IntPtr)g9UbKw3pERkhmEHkqA9.k0sBmDS26(HI1fX63hL1TONRkKqjR.k0sBmDS26(target, HI1fX63hL1TONRkKqjR.P2u3mHpb2D), null, g9UbKw3pERkhmEHkqA9.mv53Fn5xwA), detour);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003C80 File Offset: 0x00001E80
		public HookManager()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.dxI7NE9hn1();
			base..ctor();
			int num = 0;
			if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_9a9bc72297644483a3b3d67891d8967c != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003CE0 File Offset: 0x00001EE0
		// Note: this type is marked as 'beforefieldinit'.
		static HookManager()
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					nHwRpygmi6xxZAssJn.dxI7NE9hn1();
					num2 = 3;
					continue;
				case 2:
					hIDAYxH6DWLHIthQgC.oDuBOTgYK();
					num2 = 1;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_3854c26e2d2a4be88f3e932f13251925 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					HookManager.PinnedDelegates = new List<object>();
					num2 = 0;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_a251c722ffd64d969f265fb60691858a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003D78 File Offset: 0x00001F78
		internal static bool z0RBMVkNtKnpp1cD8uP()
		{
			return HookManager.GPGEptkKGL0exHc5hyp == null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003D84 File Offset: 0x00001F84
		internal static HookManager ixw4nSktmtVitYpkOcd()
		{
			return HookManager.GPGEptkKGL0exHc5hyp;
		}

		// Token: 0x04000012 RID: 18
		private static readonly List<object> PinnedDelegates;

		// Token: 0x04000013 RID: 19
		private static HookManager._CreateHook CreateHook;

		// Token: 0x04000014 RID: 20
		private static HookManager._RemoveHook RemoveHook;

		// Token: 0x04000015 RID: 21
		private static HookManager GPGEptkKGL0exHc5hyp;

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000034 RID: 52
		private unsafe delegate void _CreateHook(IntPtr* pTarget, IntPtr* pDetour, out IntPtr* ppOrig);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000038 RID: 56
		private delegate void _RemoveHook(IntPtr pOriginal);
	}
}
