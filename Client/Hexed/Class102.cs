using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using ExitGames.Client.Photon;
using Hexed.Wrappers;
using VRC.Core;

// Token: 0x020000F4 RID: 244
internal class Class102 : Interface3
{
	// Token: 0x060004FF RID: 1279 RVA: 0x000193B4 File Offset: 0x000175B4
	public void Initialize()
	{
		MethodInfo method = typeof(VRCNetworkingClient).GetMethod("OnOperationResponse");
		Class102.Delegate33 detour;
		if ((detour = Class102.<>O.delegate33_0) == null)
		{
			detour = (Class102.<>O.delegate33_0 = new Class102.Delegate33(Class102.Patch));
		}
		Class102.delegate33_0 = HookManager.Detour<Class102.Delegate33>(method, detour);
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x000193FC File Offset: 0x000175FC
	private static void Patch(IntPtr instance, IntPtr __0)
	{
		VRCNetworkingClient vrcnetworkingClient = (instance == IntPtr.Zero) ? null : new VRCNetworkingClient(instance);
		OperationResponse operationResponse = (__0 == IntPtr.Zero) ? null : new OperationResponse(__0);
		if (operationResponse == null || vrcnetworkingClient == null)
		{
			return;
		}
		if (Class143.bool_4)
		{
			Logger.LogOperationResponse(operationResponse);
		}
		if (operationResponse.ReturnCode == 0)
		{
			byte operationCode = operationResponse.OperationCode;
			if (operationCode != 226)
			{
				if (operationCode == 254)
				{
					Logger.Log("Disconnected from Room", Logger.LogsType.Room);
					Class53.Log("Disconnected from Room", Class53.LogsType.Room);
				}
			}
			else if (vrcnetworkingClient.Method_Public_get_ServerConnection_0() == 1)
			{
				Class143.long_0 = Class5.GetUnixTimeInMilliseconds();
				string currentWorldID = Class4.GetCurrentWorldID();
				if (currentWorldID != null)
				{
					if (Class143.dictionary_1.Count > 150)
					{
						Class143.dictionary_1.Clear();
					}
					Class143.dictionary_1[currentWorldID] = DateTime.Now;
				}
				Logger.Log("Connected to Room", Logger.LogsType.Room);
				Class53.Log("Connected to Room", Class53.LogsType.Room);
				Class142.DestroyAllPlayerModules();
				Class66.ClearEventBlocks();
				Class67.ClearModerations();
				Class143.dictionary_0.Clear();
				Class8.dictionary_0.Clear();
			}
			Class102.delegate33_0(instance, __0);
			return;
		}
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x000031A8 File Offset: 0x000013A8
	internal static bool a0776fTKayESrqs1roG()
	{
		return Class102.KicXBFTQqwLMohtrqlx == null;
	}

	// Token: 0x0400025D RID: 605
	private static Class102.Delegate33 delegate33_0;

	// Token: 0x0400025E RID: 606
	internal static Class102 KicXBFTQqwLMohtrqlx;

	// Token: 0x020000F5 RID: 245
	// (Invoke) Token: 0x06000504 RID: 1284
	private delegate void Delegate33(IntPtr instance, IntPtr __0);

	// Token: 0x020000F6 RID: 246
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400025F RID: 607
		public static Class102.Delegate33 delegate33_0;
	}
}
