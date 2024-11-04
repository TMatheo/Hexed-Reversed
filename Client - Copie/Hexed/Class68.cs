using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000084 RID: 132
internal class Class68
{
	// Token: 0x060003D1 RID: 977 RVA: 0x000156D0 File Offset: 0x000138D0
	public static void ChangeOperation226(Dictionary<byte, Object> param)
	{
		if (!param.ContainsKey(249))
		{
			return;
		}
		Hashtable hashtable = param[249].TryCast<Hashtable>();
		if (hashtable == null)
		{
			return;
		}
		if (hashtable.ContainsKey("inVRMode"))
		{
			Class143.VRMode vrmode_ = Class143.vrmode_0;
			if (vrmode_ != Class143.VRMode.VR)
			{
				if (vrmode_ == Class143.VRMode.Desktop)
				{
					Hashtable hashtable2 = hashtable;
					Object @object = "inVRMode";
					Boolean boolean = default(Boolean);
					boolean.m_value = false;
					hashtable2[@object] = boolean.BoxIl2CppObject();
				}
			}
			else
			{
				Hashtable hashtable3 = hashtable;
				Object object2 = "inVRMode";
				Boolean boolean = default(Boolean);
				boolean.m_value = true;
				hashtable3[object2] = boolean.BoxIl2CppObject();
			}
		}
		if (hashtable.ContainsKey("groupOnNameplate") && Class143.bool_32)
		{
			hashtable["groupOnNameplate"] = new Object(IL2CPP.ManagedStringToIl2Cpp(Class143.string_1));
		}
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x00002FE2 File Offset: 0x000011E2
	internal static bool hPPGtAnP9F6R0HgZdtm()
	{
		return Class68.PxXfZ3nKnNGaV7Zlh5u == null;
	}

	// Token: 0x040001E6 RID: 486
	internal static Class68 PxXfZ3nKnNGaV7Zlh5u;
}
