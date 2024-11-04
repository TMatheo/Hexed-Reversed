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

// Token: 0x020000A2 RID: 162
internal class Class76 : Interface3
{
	// Token: 0x06000419 RID: 1049 RVA: 0x00016390 File Offset: 0x00014590
	public void Initialize()
	{
		MethodInfo method = typeof(ExternVRCSDKBaseVRCPlayerApi).GetMethod("__SetAvatarEyeHeightMaximumByMeters__SystemSingle__SystemVoid");
		Class76.Delegate7 detour;
		if ((detour = Class76.<>O.delegate7_0) == null)
		{
			detour = (Class76.<>O.delegate7_0 = new Class76.Delegate7(Class76.Patch));
		}
		Class76.delegate7_0 = HookManager.Detour<Class76.Delegate7>(method, detour);
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x000163D8 File Offset: 0x000145D8
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
		Class76.delegate7_0(instance, __0, __1);
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x00003046 File Offset: 0x00001246
	internal static bool x9l2f2ag7ydVXfWSpbM()
	{
		return Class76.dYmyowarM8ar2EeP6ho == null;
	}

	// Token: 0x040001FF RID: 511
	private static Class76.Delegate7 delegate7_0;

	// Token: 0x04000200 RID: 512
	internal static Class76 dYmyowarM8ar2EeP6ho;

	// Token: 0x020000A3 RID: 163
	// (Invoke) Token: 0x0600041E RID: 1054
	private delegate void Delegate7(IntPtr instance, IntPtr __0, IntPtr __1);

	// Token: 0x020000A4 RID: 164
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000201 RID: 513
		public static Class76.Delegate7 delegate7_0;
	}
}
