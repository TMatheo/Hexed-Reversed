using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using Hexed.Wrappers;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using VRC.SDKBase;
using VRC.Udon.Common.Interfaces;
using VRC.Udon.Wrapper.Modules;

// Token: 0x0200009C RID: 156
internal class Class74 : Interface3
{
	// Token: 0x06000409 RID: 1033 RVA: 0x000161B0 File Offset: 0x000143B0
	public void Initialize()
	{
		MethodInfo method = typeof(ExternVRCSDKBaseVRCPlayerApi).GetMethod("__SetAvatarEyeHeightByMeters__SystemSingle__SystemVoid");
		Class74.Delegate5 detour;
		if ((detour = Class74.<>O.delegate5_0) == null)
		{
			detour = (Class74.<>O.delegate5_0 = new Class74.Delegate5(Class74.Patch));
		}
		Class74.delegate5_0 = HookManager.Detour<Class74.Delegate5>(method, detour);
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x000161F8 File Offset: 0x000143F8
	private static void Patch(IntPtr instance, IntPtr __0, IntPtr __1)
	{
		IUdonHeap udonHeap = (__0 == IntPtr.Zero) ? null : new IUdonHeap(__0);
		Il2CppArrayBase<uint> il2CppArrayBase = (__1 == IntPtr.Zero) ? null : new Span<uint>(__1).ToArray();
		for (int i = 0; i < il2CppArrayBase.Length; i++)
		{
			Object heapVariable = udonHeap.GetHeapVariable(il2CppArrayBase[i]);
			if (heapVariable != null)
			{
				VRCPlayerApi vrcplayerApi = heapVariable.TryCast<VRCPlayerApi>();
				if (vrcplayerApi != null && vrcplayerApi.isLocal && Class143.bool_16)
				{
					Logger.Log("Prevented Server from scaling your Avatar", Logger.LogsType.Protection);
					Class53.Log("Server --> Avatar Scaling", Class53.LogsType.Protection);
					return;
				}
			}
		}
		Class74.delegate5_0(instance, __0, __1);
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x00003032 File Offset: 0x00001232
	internal static bool Y9We3Na5kkFA2hdTQij()
	{
		return Class74.XMBRrjayr8KgsxguAOZ == null;
	}

	// Token: 0x040001F9 RID: 505
	private static Class74.Delegate5 delegate5_0;

	// Token: 0x040001FA RID: 506
	private static Class74 XMBRrjayr8KgsxguAOZ;

	// Token: 0x0200009D RID: 157
	// (Invoke) Token: 0x0600040E RID: 1038
	private delegate void Delegate5(IntPtr instance, IntPtr __0, IntPtr __1);

	// Token: 0x0200009E RID: 158
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040001FB RID: 507
		public static Class74.Delegate5 delegate5_0;
	}
}
