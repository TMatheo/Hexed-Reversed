using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using VRC.UI.Elements.Controls;

// Token: 0x020000BB RID: 187
internal class Class84 : Interface3
{
	// Token: 0x0600045D RID: 1117 RVA: 0x00016D8C File Offset: 0x00014F8C
	public void Initialize()
	{
		MethodInfo method = typeof(InstanceContentCell).GetMethod("Method_Private_Void_PDM_4");
		Class84.Delegate15 detour;
		if ((detour = Class84.<>O.delegate15_0) == null)
		{
			detour = (Class84.<>O.delegate15_0 = new Class84.Delegate15(Class84.Patch));
		}
		Class84.delegate15_0 = HookManager.Detour<Class84.Delegate15>(method, detour);
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x00016DD4 File Offset: 0x00014FD4
	private static void Patch(IntPtr instance, IntPtr __0)
	{
		Class84.delegate15_0(instance, __0);
		InstanceContentCell instanceContentCell = (instance == IntPtr.Zero) ? null : new InstanceContentCell(instance);
		if (instanceContentCell == null || instanceContentCell.UserCount == null)
		{
			return;
		}
		if (instanceContentCell.name != "Cell_MM_WorldInstance(Clone)")
		{
			return;
		}
		IWorld field_Protected_IWorld_ = instanceContentCell.field_Protected_IWorld_0;
		if (field_Protected_IWorld_ != null && field_Protected_IWorld_.Method_Public_Abstract_Virtual_New_get_String_0() != null)
		{
			if (Class143.dictionary_1.ContainsKey(field_Protected_IWorld_.Method_Public_Abstract_Virtual_New_get_String_0()))
			{
				TextMeshProUGUIEx userCount = instanceContentCell.UserCount;
				userCount.text = userCount.text + " [" + Class143.dictionary_1[field_Protected_IWorld_.Method_Public_Abstract_Virtual_New_get_String_0()].ToShortTimeString() + "]";
			}
			return;
		}
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x000030A0 File Offset: 0x000012A0
	internal static bool CEaEpxaT32nfXmM8FNZ()
	{
		return Class84.opk9w2aanYBXyioAdSi == null;
	}

	// Token: 0x0400021C RID: 540
	private static Class84.Delegate15 delegate15_0;

	// Token: 0x0400021D RID: 541
	private static Class84 opk9w2aanYBXyioAdSi;

	// Token: 0x020000BC RID: 188
	// (Invoke) Token: 0x06000462 RID: 1122
	private delegate void Delegate15(IntPtr instance, IntPtr __0);

	// Token: 0x020000BD RID: 189
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400021E RID: 542
		public static Class84.Delegate15 delegate15_0;
	}
}
