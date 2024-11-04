using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using CoreRuntime.Manager;
using Il2CppSystem.Collections.Generic;
using VRC.Core;

// Token: 0x020000D8 RID: 216
internal class Class93 : Interface3
{
	// Token: 0x060004AE RID: 1198 RVA: 0x000179F4 File Offset: 0x00015BF4
	public void Initialize()
	{
		MethodInfo method = typeof(ObjectPublicStBoStDaBo1StILBo1Unique).GetMethod("Method_Public_Static_ApiVRChatSubscription_0");
		Class93.Delegate24 detour;
		if ((detour = Class93.<>O.delegate24_0) == null)
		{
			detour = (Class93.<>O.delegate24_0 = new Class93.Delegate24(Class93.Patch));
		}
		Class93.delegate24_0 = HookManager.Detour<Class93.Delegate24>(method, detour);
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x00017A3C File Offset: 0x00015C3C
	private static IntPtr Patch()
	{
		IntPtr intPtr = Class93.delegate24_0();
		if (intPtr != IntPtr.Zero)
		{
			return intPtr;
		}
		string text = DateTime.UtcNow.AddDays(-1.0).ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
		string text2 = DateTime.UtcNow.AddDays(-1.0).AddYears(1).ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
		defaultInterpolatedStringHandler.AppendLiteral("txn_");
		defaultInterpolatedStringHandler.AppendFormatted<Guid>(Guid.NewGuid());
		string text3 = defaultInterpolatedStringHandler.ToStringAndClear();
		List<string> list = new List<string>();
		List<string> list2 = list;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
		defaultInterpolatedStringHandler.AppendLiteral("lgrp_");
		defaultInterpolatedStringHandler.AppendFormatted<Guid>(Guid.NewGuid());
		list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
		return new ApiVRChatSubscription
		{
			transactionId = text3,
			amount = 9999UL,
			description = "VRChat Plus (Yearly)",
			store = "Admin",
			period = "year",
			active = true,
			status = "active",
			tier = 5,
			starts = "",
			expires = text2,
			created_at = text,
			updated_at = text,
			isGift = false,
			giftedBy = null,
			giftedByDisplayName = null,
			licenseGroups = list,
			id = "vrchatplus-yearly",
			supportedPlatforms = 14,
			Populated = true,
			Endpoint = null,
			steamItemId = "5000",
			_transactionId_k__BackingField = text3,
			_amount_k__BackingField = 9999UL,
			_description_k__BackingField = "VRChat Plus (Yearly)",
			_store_k__BackingField = "Admin",
			_period_k__BackingField = "year",
			_active_k__BackingField = true,
			_status_k__BackingField = "active",
			_tier_k__BackingField = 5,
			_starts_k__BackingField = "",
			_expires_k__BackingField = text2,
			_created_at_k__BackingField = text,
			_updated_at_k__BackingField = text,
			_isGift_k__BackingField = true,
			_giftedBy_k__BackingField = null,
			_giftedByDisplayName_k__BackingField = null,
			_licenseGroups_k__BackingField = list,
			_id_k__BackingField = "vrchatplus-yearly",
			_Populated_k__BackingField = true,
			_Endpoint_k__BackingField = null,
			_steamItemId_k__BackingField = "5000",
			_cacheId = null
		}.Pointer;
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x00003120 File Offset: 0x00001320
	internal static bool jJ0j6TTxLTYk0xXM6OD()
	{
		return Class93.V0YFWDTX85upbA8k4oC == null;
	}

	// Token: 0x0400023D RID: 573
	private static Class93.Delegate24 delegate24_0;

	// Token: 0x0400023E RID: 574
	private static Class93 V0YFWDTX85upbA8k4oC;

	// Token: 0x020000D9 RID: 217
	// (Invoke) Token: 0x060004B3 RID: 1203
	private delegate IntPtr Delegate24();

	// Token: 0x020000DA RID: 218
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400023F RID: 575
		public static Class93.Delegate24 delegate24_0;
	}
}
