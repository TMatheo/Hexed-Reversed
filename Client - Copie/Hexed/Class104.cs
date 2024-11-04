using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using UnityEngine;

// Token: 0x020000FA RID: 250
internal class Class104 : Interface3
{
	// Token: 0x0600050F RID: 1295 RVA: 0x00019EEC File Offset: 0x000180EC
	public void Initialize()
	{
		MethodInfo method = typeof(VRCUiPageLoading).GetMethod("OnEnable");
		Class104.Delegate35 detour;
		if ((detour = Class104.<>O.delegate35_0) == null)
		{
			detour = (Class104.<>O.delegate35_0 = new Class104.Delegate35(Class104.Patch));
		}
		Class104.delegate35_0 = HookManager.Detour<Class104.Delegate35>(method, detour);
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x00019F34 File Offset: 0x00018134
	private static void Patch(IntPtr instance)
	{
		Class104.delegate35_0(instance);
		VRCUiPageLoading vrcuiPageLoading = (instance == IntPtr.Zero) ? null : new VRCUiPageLoading(instance);
		if (!(vrcuiPageLoading == null))
		{
			vrcuiPageLoading.transform.Find("3DElements/LoadingBackground_TealGradient/SkyCube_Baked").transform.localScale = Vector3.zero;
			vrcuiPageLoading.transform.Find("3DElements/LoadingInfoPanel").transform.localScale = Vector3.zero;
			vrcuiPageLoading.transform.Find("ProgressPanel/Parent_Loading_Progress/Panel_Backdrop").transform.localScale = Vector3.zero;
			vrcuiPageLoading.transform.Find("ProgressPanel/Parent_Loading_Progress/Decoration_Left").transform.localScale = Vector3.zero;
			vrcuiPageLoading.transform.Find("ProgressPanel/Parent_Loading_Progress/Decoration_Right").transform.localScale = Vector3.zero;
			ParticleSystem component = vrcuiPageLoading.transform.Find("3DElements/LoadingBackground_TealGradient/_FX_ParticleBubbles/FX_snow").gameObject.GetComponent<ParticleSystem>();
			component.startColor = Color.white;
			component.gameObject.SetActive(false);
			component.gameObject.SetActive(true);
			ParticleSystem component2 = vrcuiPageLoading.transform.Find("3DElements/LoadingBackground_TealGradient/_FX_ParticleBubbles/FX_CloseParticles").gameObject.GetComponent<ParticleSystem>();
			component2.startColor = Color.white;
			component2.gameObject.SetActive(false);
			component2.gameObject.SetActive(true);
			return;
		}
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x000031BC File Offset: 0x000013BC
	internal static bool OWJ60rTnZQt7qIxIy9p()
	{
		return Class104.lmdvoATNeYINr7XDDBT == null;
	}

	// Token: 0x04000263 RID: 611
	private static Class104.Delegate35 delegate35_0;

	// Token: 0x04000264 RID: 612
	private static Class104 lmdvoATNeYINr7XDDBT;

	// Token: 0x020000FB RID: 251
	// (Invoke) Token: 0x06000514 RID: 1300
	private delegate void Delegate35(IntPtr instance);

	// Token: 0x020000FC RID: 252
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04000265 RID: 613
		public static Class104.Delegate35 delegate35_0;
	}
}
