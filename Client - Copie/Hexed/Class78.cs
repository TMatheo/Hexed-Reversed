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

// Token: 0x020000A8 RID: 168
internal class Class78 : Interface3
{
	// Token: 0x06000429 RID: 1065 RVA: 0x00016570 File Offset: 0x00014770
	public void Initialize()
	{
		MethodInfo method = typeof(ExternVRCSDKBaseVRCPlayerApi).GetMethod("__SetManualAvatarScalingAllowed__SystemBoolean__SystemVoid");
		Class78.Delegate9 detour;
		if ((detour = Class78.<>O.delegate9_0) == null)
		{
			detour = (Class78.<>O.delegate9_0 = new Class78.Delegate9(Class78.Patch));
		}
		Class78.delegate9_0 = HookManager.Detour<Class78.Delegate9>(method, detour);
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x000165B8 File Offset: 0x000147B8
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
		Class78.delegate9_0(instance, __0, __1);
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x0000305A File Offset: 0x0000125A
	internal static bool Ynb2PVa3JDgFpPvoJev()
	{
		return Class78.kqHcKnawQCAqKuJV4VK == null;
	}

	// Token: 0x04000205 RID: 517
	private static Class78.Delegate9 delegate9_0;

	// Token: 0x04000206 RID: 518
	private static Class78 kqHcKnawQCAqKuJV4VK;

	// Token: 0x020000A9 RID: 169
	// (Invoke) Token: 0x0600042E RID: 1070
	private delegate void Delegate9(IntPtr instance, IntPtr __0, IntPtr __1);

	// Token: 0x020000AA RID: 170
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000207 RID: 519
		public static Class78.Delegate9 delegate9_0;
	}
}
