using System;
using System.Collections.Generic;
using UnityEngine;
using VRC.Core;

// Token: 0x0200004D RID: 77
internal class Class39 : Interface0, Interface4
{
	// Token: 0x06000250 RID: 592 RVA: 0x0000CAA4 File Offset: 0x0000ACA4
	public void Initialize(VRCPlayer player)
	{
		this.vrcplayer_0 = player;
	}

	// Token: 0x06000251 RID: 593 RVA: 0x0000CAB8 File Offset: 0x0000ACB8
	public void OnUpdate()
	{
		if (this.vrcplayer_0 == null)
		{
			return;
		}
		if (!Class143.bool_9)
		{
			this.ToggleCapsuleHighlight(false);
			return;
		}
		this.ToggleCapsuleHighlight(true);
	}

	// Token: 0x06000252 RID: 594 RVA: 0x0000CAEC File Offset: 0x0000ACEC
	public void ToggleCapsuleHighlight(bool State)
	{
		string name = "PlayerCapsule-" + this.vrcplayer_0.UserID();
		if (!State)
		{
			this.DestroyHighlightFx(name);
			return;
		}
		HighlightsFXStandalone orAddHighlight = this.GetOrAddHighlight(name);
		if (this.vrcplayer_0.Method_Internal_get_PlayerSelector_PDM_0() == null)
		{
			return;
		}
		MeshFilter component = this.vrcplayer_0.Method_Internal_get_PlayerSelector_PDM_0().GetComponent<MeshFilter>();
		if (component == null)
		{
			return;
		}
		APIUser apiuser = this.vrcplayer_0.smethod_1();
		if (apiuser != null)
		{
			orAddHighlight.highlightColor = apiuser.GetRankColor();
			Class114.ToggleHighlightFx(orAddHighlight, component, State);
			return;
		}
	}

	// Token: 0x06000253 RID: 595 RVA: 0x0000CB84 File Offset: 0x0000AD84
	private HighlightsFXStandalone GetOrAddHighlight(string name)
	{
		HighlightsFXStandalone highlightsFXStandalone;
		if (!this.dictionary_0.TryGetValue(name, out highlightsFXStandalone))
		{
			highlightsFXStandalone = HighlightsFX.Method_Public_Static_get_HighlightsFX_PDM_0().gameObject.AddComponent<HighlightsFXStandalone>();
			highlightsFXStandalone.blurSize /= 2f;
			this.dictionary_0[name] = highlightsFXStandalone;
		}
		return highlightsFXStandalone;
	}

	// Token: 0x06000254 RID: 596 RVA: 0x0000CBD8 File Offset: 0x0000ADD8
	private HighlightsFXStandalone GetHighlight(string name)
	{
		HighlightsFXStandalone result;
		if (this.dictionary_0.TryGetValue(name, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06000255 RID: 597 RVA: 0x0000CBFC File Offset: 0x0000ADFC
	private void DestroyHighlightFx(string name)
	{
		HighlightsFXStandalone highlight = this.GetHighlight(name);
		if (highlight != null)
		{
			highlight.field_Protected_HashSet_1_MeshFilter_0.Clear();
		}
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00002C3F File Offset: 0x00000E3F
	internal static bool JVyifHN4VwxxXZKRXy0()
	{
		return Class39.ldSTJINEh9ebt9SEKSd == null;
	}

	// Token: 0x04000108 RID: 264
	private VRCPlayer vrcplayer_0;

	// Token: 0x04000109 RID: 265
	private readonly Dictionary<string, HighlightsFXStandalone> dictionary_0 = new Dictionary<string, HighlightsFXStandalone>();

	// Token: 0x0400010A RID: 266
	internal static Class39 ldSTJINEh9ebt9SEKSd;
}
