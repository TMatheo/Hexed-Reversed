using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using VRC.SDKBase;
using VRC.Udon.Common.Interfaces;
using VRC.Udon.Wrapper.Modules;

// Token: 0x02000099 RID: 153
internal class FuceuthfkSnjrmwciDQ : Interface3
{
	// Token: 0x06000401 RID: 1025 RVA: 0x00016074 File Offset: 0x00014274
	public void Initialize()
	{
		MethodInfo method = typeof(ExternVRCSDKBaseVRCPlayerApi).GetMethod("__get_displayName__SystemString");
		FuceuthfkSnjrmwciDQ.Delegate4 detour;
		if ((detour = FuceuthfkSnjrmwciDQ.<>O.delegate4_0) == null)
		{
			detour = (FuceuthfkSnjrmwciDQ.<>O.delegate4_0 = new FuceuthfkSnjrmwciDQ.Delegate4(FuceuthfkSnjrmwciDQ.Patch));
		}
		FuceuthfkSnjrmwciDQ.delegate4_0 = HookManager.Detour<FuceuthfkSnjrmwciDQ.Delegate4>(method, detour);
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x000160BC File Offset: 0x000142BC
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
				if (vrcplayerApi != null && vrcplayerApi.isLocal)
				{
					switch (Class143.udonSpoofMode_0)
					{
					case Class143.UdonSpoofMode.Owner:
						if (RoomManager.field_Internal_Static_ApiWorld_0 != null)
						{
							vrcplayerApi.displayName = RoomManager.field_Internal_Static_ApiWorld_0.authorName;
						}
						break;
					case Class143.UdonSpoofMode.Random:
						vrcplayerApi.displayName = Class109.RandomString(13);
						break;
					case Class143.UdonSpoofMode.Custom:
						vrcplayerApi.displayName = Class143.string_0;
						break;
					}
					udonHeap.SetHeapVariable<VRCPlayerApi>(il2CppArrayBase[i], vrcplayerApi);
				}
			}
		}
		FuceuthfkSnjrmwciDQ.delegate4_0(instance, __0, __1);
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x00003028 File Offset: 0x00001228
	internal static bool qkVD9OaBeFXBcSloHJA()
	{
		return FuceuthfkSnjrmwciDQ.O19R2Pav7R31bwIkrwL == null;
	}

	// Token: 0x040001F6 RID: 502
	private static FuceuthfkSnjrmwciDQ.Delegate4 delegate4_0;

	// Token: 0x040001F7 RID: 503
	internal static FuceuthfkSnjrmwciDQ O19R2Pav7R31bwIkrwL;

	// Token: 0x0200009A RID: 154
	// (Invoke) Token: 0x06000406 RID: 1030
	private delegate void Delegate4(IntPtr instance, IntPtr __0, IntPtr __1);

	// Token: 0x0200009B RID: 155
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040001F8 RID: 504
		public static FuceuthfkSnjrmwciDQ.Delegate4 delegate4_0;
	}
}
