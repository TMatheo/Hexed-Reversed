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

// Token: 0x020000A5 RID: 165
internal class Class77 : Interface3
{
	// Token: 0x06000421 RID: 1057 RVA: 0x00016480 File Offset: 0x00014680
	public void Initialize()
	{
		MethodInfo method = typeof(ExternVRCSDKBaseVRCPlayerApi).GetMethod("__SetAvatarEyeHeightMinimumByMeters__SystemSingle__SystemVoid");
		Class77.Delegate8 detour;
		if ((detour = Class77.<>O.delegate8_0) == null)
		{
			detour = (Class77.<>O.delegate8_0 = new Class77.Delegate8(Class77.Patch));
		}
		Class77.delegate8_0 = HookManager.Detour<Class77.Delegate8>(method, detour);
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x000164C8 File Offset: 0x000146C8
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
		Class77.delegate8_0(instance, __0, __1);
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x00003050 File Offset: 0x00001250
	internal static bool fchLeLalyhNOs1bvRsQ()
	{
		return Class77.U8axSPa7RemhAB0Amt8 == null;
	}

	// Token: 0x04000202 RID: 514
	private static Class77.Delegate8 delegate8_0;

	// Token: 0x04000203 RID: 515
	internal static Class77 U8axSPa7RemhAB0Amt8;

	// Token: 0x020000A6 RID: 166
	// (Invoke) Token: 0x06000426 RID: 1062
	private delegate void Delegate8(IntPtr instance, IntPtr __0, IntPtr __1);

	// Token: 0x020000A7 RID: 167
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000204 RID: 516
		public static Class77.Delegate8 delegate8_0;
	}
}
