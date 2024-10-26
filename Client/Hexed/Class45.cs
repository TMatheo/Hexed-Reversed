using System;
using System.Collections.Generic;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

// Token: 0x02000055 RID: 85
internal class Class45 : Interface0, Interface2
{
	// Token: 0x06000281 RID: 641 RVA: 0x00002328 File Offset: 0x00000528
	public void Initialize()
	{
	}

	// Token: 0x06000282 RID: 642 RVA: 0x0000EA60 File Offset: 0x0000CC60
	public void OnUpdate()
	{
		if (!Class4.IsInWorld())
		{
			this.list_0.Clear();
			this.list_1.Clear();
			return;
		}
		if (!Class143.bool_10)
		{
			foreach (VRC_Pickup pickup in this.list_1)
			{
				this.TogglePickupESP(pickup, false);
			}
			this.list_1.Clear();
		}
		else
		{
			if (this.list_1.Count == 0)
			{
				foreach (VRC_Pickup item in Class116.GetAllPickups())
				{
					this.list_1.Add(item);
				}
			}
			foreach (VRC_Pickup pickup2 in this.list_1)
			{
				this.TogglePickupESP(pickup2, true);
			}
		}
		if (Class143.bool_11)
		{
			if (this.list_0.Count == 0)
			{
				foreach (UdonBehaviour item2 in Resources.FindObjectsOfTypeAll<UdonBehaviour>())
				{
					this.list_0.Add(item2);
				}
			}
			using (List<UdonBehaviour>.Enumerator enumerator3 = this.list_0.GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					UdonBehaviour trigger = enumerator3.Current;
					this.ToggleTriggerESP(trigger, true);
				}
				return;
			}
		}
		foreach (UdonBehaviour trigger2 in this.list_0)
		{
			this.ToggleTriggerESP(trigger2, false);
		}
		this.list_0.Clear();
	}

	// Token: 0x06000283 RID: 643 RVA: 0x0000EC64 File Offset: 0x0000CE64
	public void TogglePickupESP(VRC_Pickup pickup, bool State)
	{
		string name = "PickupRenderer-" + pickup.name;
		if (!State)
		{
			this.DestroyHighlightFx(name);
			return;
		}
		MeshFilter component = pickup.GetComponent<MeshFilter>();
		if (!(component == null))
		{
			HighlightsFXStandalone orAddHighlight = this.GetOrAddHighlight(name);
			orAddHighlight.highlightColor = Color.gray;
			Class114.ToggleHighlightFx(orAddHighlight, component, State);
			return;
		}
	}

	// Token: 0x06000284 RID: 644 RVA: 0x0000ECC0 File Offset: 0x0000CEC0
	public void ToggleTriggerESP(UdonBehaviour trigger, bool State)
	{
		string name = "TriggerRenderer-" + trigger.name;
		if (!State)
		{
			this.DestroyHighlightFx(name);
			return;
		}
		if (!trigger._hasInteractiveEvents)
		{
			return;
		}
		MeshFilter component = trigger.GetComponent<MeshFilter>();
		if (component == null)
		{
			return;
		}
		HighlightsFXStandalone orAddHighlight = this.GetOrAddHighlight(name);
		orAddHighlight.highlightColor = Color.gray;
		Class114.ToggleHighlightFx(orAddHighlight, component, State);
	}

	// Token: 0x06000285 RID: 645 RVA: 0x0000ED24 File Offset: 0x0000CF24
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

	// Token: 0x06000286 RID: 646 RVA: 0x0000ED78 File Offset: 0x0000CF78
	private HighlightsFXStandalone GetHighlight(string name)
	{
		HighlightsFXStandalone result;
		if (this.dictionary_0.TryGetValue(name, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06000287 RID: 647 RVA: 0x0000ED9C File Offset: 0x0000CF9C
	private void DestroyHighlightFx(string name)
	{
		HighlightsFXStandalone highlight = this.GetHighlight(name);
		if (highlight != null)
		{
			highlight.field_Protected_HashSet_1_MeshFilter_0.Clear();
		}
	}

	// Token: 0x06000289 RID: 649 RVA: 0x00002C9D File Offset: 0x00000E9D
	internal static bool Rda7ohn1AcscXSmnbEm()
	{
		return Class45.x3I2xKNzdfTjhWLEAPc == null;
	}

	// Token: 0x0400011F RID: 287
	private readonly Dictionary<string, HighlightsFXStandalone> dictionary_0 = new Dictionary<string, HighlightsFXStandalone>();

	// Token: 0x04000120 RID: 288
	private List<UdonBehaviour> list_0 = new List<UdonBehaviour>();

	// Token: 0x04000121 RID: 289
	private List<VRC_Pickup> list_1 = new List<VRC_Pickup>();

	// Token: 0x04000122 RID: 290
	internal static Class45 x3I2xKNzdfTjhWLEAPc;
}
