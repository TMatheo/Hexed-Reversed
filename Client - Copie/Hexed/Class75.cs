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

// Token: 0x0200009F RID: 159
internal class Class75 : Interface3
{
	// Token: 0x06000411 RID: 1041 RVA: 0x000162A0 File Offset: 0x000144A0
	public void Initialize()
	{
		MethodInfo method = typeof(ExternVRCSDKBaseVRCPlayerApi).GetMethod("__SetAvatarEyeHeightByMultiplier__SystemSingle__SystemVoid");
		Class75.Delegate6 detour;
		if ((detour = Class75.<>O.delegate6_0) == null)
		{
			detour = (Class75.<>O.delegate6_0 = new Class75.Delegate6(Class75.Patch));
		}
		Class75.delegate6_0 = HookManager.Detour<Class75.Delegate6>(method, detour);
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x000162E8 File Offset: 0x000144E8
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
		Class75.delegate6_0(instance, __0, __1);
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x0000303C File Offset: 0x0000123C
	internal static bool fWZUxmaGGFBIWut7j1Z()
	{
		return Class75.G3cc89abr3igNHDxNOW == null;
	}

	// Token: 0x040001FC RID: 508
	private static Class75.Delegate6 delegate6_0;

	// Token: 0x040001FD RID: 509
	private static Class75 G3cc89abr3igNHDxNOW;

	// Token: 0x020000A0 RID: 160
	// (Invoke) Token: 0x06000416 RID: 1046
	private delegate void Delegate6(IntPtr instance, IntPtr __0, IntPtr __1);

	// Token: 0x020000A1 RID: 161
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040001FE RID: 510
		public static Class75.Delegate6 delegate6_0;
	}
}
