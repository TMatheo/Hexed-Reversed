using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using BestHTTP;
using CoreRuntime.Manager;
using Hexed.Wrappers;

// Token: 0x020000B5 RID: 181
internal class Class82 : Interface3
{
	// Token: 0x0600044D RID: 1101 RVA: 0x00016C18 File Offset: 0x00014E18
	public void Initialize()
	{
		MethodInfo method = typeof(HTTPManager).GetMethod("SendRequestImpl");
		Class82.Delegate13 detour;
		if ((detour = Class82.<>O.delegate13_0) == null)
		{
			detour = (Class82.<>O.delegate13_0 = new Class82.Delegate13(Class82.Patch));
		}
		Class82.delegate13_0 = HookManager.Detour<Class82.Delegate13>(method, detour);
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00016C60 File Offset: 0x00014E60
	private static void Patch(IntPtr __0)
	{
		HTTPRequest httprequest = (__0 == IntPtr.Zero) ? null : new HTTPRequest(__0);
		if (httprequest != null)
		{
			if (Class143.bool_5)
			{
				Logger.LogApi(httprequest);
			}
			if (httprequest.Uri != null && httprequest.Uri.ToString().Contains("amplitude.com"))
			{
				return;
			}
		}
		Class82.delegate13_0(__0);
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x0000308C File Offset: 0x0000128C
	internal static bool kW0OF6aAy58btHTisqT()
	{
		return Class82.mMtQj9aP9fopL0uddAY == null;
	}

	// Token: 0x04000216 RID: 534
	private static Class82.Delegate13 delegate13_0;

	// Token: 0x04000217 RID: 535
	internal static Class82 mMtQj9aP9fopL0uddAY;

	// Token: 0x020000B6 RID: 182
	// (Invoke) Token: 0x06000452 RID: 1106
	private delegate void Delegate13(IntPtr __0);

	// Token: 0x020000B7 RID: 183
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000218 RID: 536
		public static Class82.Delegate13 delegate13_0;
	}
}
