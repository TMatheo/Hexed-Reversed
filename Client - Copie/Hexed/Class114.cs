using System;
using System.Linq;
using UnityEngine;

// Token: 0x02000114 RID: 276
internal class Class114
{
	// Token: 0x06000572 RID: 1394 RVA: 0x0001BEFC File Offset: 0x0001A0FC
	public static void Init()
	{
		Class114.ChangeHighlightColor(Color.grey);
		Class114.ChangeCoreColor(Color.grey);
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x0001BF20 File Offset: 0x0001A120
	private static void ChangeHighlightColor(Color highlightcolor)
	{
		foreach (HighlightsFXStandalone highlightsFXStandalone in Resources.FindObjectsOfTypeAll<HighlightsFXStandalone>())
		{
			highlightsFXStandalone.highlightColor = highlightcolor;
		}
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x0001BF70 File Offset: 0x0001A170
	private static void ChangeCoreColor(Color highlightcolor)
	{
		foreach (MeshRenderer meshRenderer in from m in Resources.FindObjectsOfTypeAll<MeshRenderer>()
		where m.name.Contains("SelectRegion")
		select m)
		{
			meshRenderer.material.color = highlightcolor;
		}
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x0001BFEC File Offset: 0x0001A1EC
	public static void ToggleHighlightFx(HighlightsFXStandalone highlightFx, MeshFilter filter, bool State)
	{
		if (!State)
		{
			highlightFx.field_Protected_HashSet_1_MeshFilter_0.Remove(filter);
			return;
		}
		highlightFx.field_Protected_HashSet_1_MeshFilter_0.AddIfNotPresent(filter);
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x000032D4 File Offset: 0x000014D4
	public static bool IsRenderPresent(HighlightsFXStandalone highlightFx, MeshFilter renderer)
	{
		return highlightFx.field_Protected_HashSet_1_MeshFilter_0.Contains(renderer);
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x000032E2 File Offset: 0x000014E2
	internal static bool qMQhhUIFFQwQiuYu1I6()
	{
		return Class114.CgVXwfIdJv7wjCnq5P3 == null;
	}

	// Token: 0x04000293 RID: 659
	internal static Class114 CgVXwfIdJv7wjCnq5P3;
}
