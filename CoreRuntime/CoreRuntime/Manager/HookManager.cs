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
		// Token: 0x0600002A RID: 42 RVA: 0x00003B28 File Offset: 0x00001D28
		internal static void Initialize(IntPtr pCreateHook, IntPtr pRemoveHook)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					HookManager.RemoveHook = HookManager.CreateDelegate<HookManager._RemoveHook>(pRemoveHook);
					num2 = 0;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_65a08a5c2ec14c03a6ad53769cd71a85 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					HookManager.CreateHook = HookManager.CreateDelegate<HookManager._CreateHook>(pCreateHook);
					num2 = 1;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_0df571ad3e7a43b59474cc5fb575fc55 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003BB4 File Offset: 0x00001DB4
		public static T CreateDelegate<T>(IntPtr method) where T : Delegate
		{
			return mT2oT0k19nDRWWMjKQp.Vkgsu7Vsh(method, leXdUdkQnIXIpKm4I85.Vkgsu7Vsh(typeof(T).TypeHandle, leXdUdkQnIXIpKm4I85.WhGkIJZ1F5), mT2oT0k19nDRWWMjKQp.oKKkvGMMNV) as T;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003BDC File Offset: 0x00001DDC
		public static T CreateDelegate<T>(IntPtr method, out T Outdelegate) where T : Delegate
		{
			return Outdelegate = (mT2oT0k19nDRWWMjKQp.Vkgsu7Vsh(method, leXdUdkQnIXIpKm4I85.Vkgsu7Vsh(typeof(T).TypeHandle, leXdUdkQnIXIpKm4I85.WhGkIJZ1F5), mT2oT0k19nDRWWMjKQp.oKKkvGMMNV) as T);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003C18 File Offset: 0x00001E18
		public unsafe static T Detour<T>(IntPtr target, T detour) where T : Delegate
		{
			if (target == IntPtr.Zero || sNsPygkOjiTyYeakpeD.Vkgsu7Vsh(detour, null, sNsPygkOjiTyYeakpeD.v6OkmQ9mi9))
			{
				throw new ArgumentException(hIDAYxH6DWLHIthQgC.gSCeTtiku(793362578 ^ 2116811485 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_8336580d1f0445238d6836f5e92b70db));
			}
			HookManager.PinnedDelegates.Add(detour);
			IntPtr* ptr = &target;
			IntPtr* ptr2;
			HookManager.CreateHook(*ptr, Marshal.GetFunctionPointerForDelegate<T>(detour), out ptr2);
			return Marshal.GetDelegateForFunctionPointer<T>(ptr2);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003C98 File Offset: 0x00001E98
		public unsafe static T Detour<T>(MethodInfo target, T detour) where T : Delegate
		{
			return HookManager.Detour<T>(*(IntPtr)iXgqG8kWIjkgLMEpgmP.Vkgsu7Vsh(hPD7iakj1IYHEKlrhfl.Vkgsu7Vsh(target, hPD7iakj1IYHEKlrhfl.JTgkULgSwH), null, iXgqG8kWIjkgLMEpgmP.m1NkSmDP4b), detour);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003CBC File Offset: 0x00001EBC
		public HookManager()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.UoDdI5CpWg();
			base..ctor();
			int num = 0;
			if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_841d80e9e7b1410a9be58b8ad14bc686 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003D1C File Offset: 0x00001F1C
		// Note: this type is marked as 'beforefieldinit'.
		static HookManager()
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					hIDAYxH6DWLHIthQgC.oDuBOTgYK();
					num2 = 0;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_ba3b074605844c669dab104a149132a3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					HookManager.PinnedDelegates = new List<object>();
					num2 = 2;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_9df70692e5e246029925140cffe0265f == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				nHwRpygmi6xxZAssJn.UoDdI5CpWg();
				num2 = 3;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003DB4 File Offset: 0x00001FB4
		internal static bool UxnkUO2IbPmihj17PrT()
		{
			return HookManager.wEdEKJ2Qro0QWr2sElU == null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003DC0 File Offset: 0x00001FC0
		internal static HookManager NG0YHx21ANWana5LcSw()
		{
			return HookManager.wEdEKJ2Qro0QWr2sElU;
		}

		// Token: 0x04000012 RID: 18
		private static readonly List<object> PinnedDelegates;

		// Token: 0x04000013 RID: 19
		private static HookManager._CreateHook CreateHook;

		// Token: 0x04000014 RID: 20
		private static HookManager._RemoveHook RemoveHook;

		// Token: 0x04000015 RID: 21
		internal static HookManager wEdEKJ2Qro0QWr2sElU;

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000034 RID: 52
		private unsafe delegate void _CreateHook(IntPtr* pTarget, IntPtr* pDetour, out IntPtr* ppOrig);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000038 RID: 56
		private delegate void _RemoveHook(IntPtr pOriginal);
	}
}
