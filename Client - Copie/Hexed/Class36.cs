using System;
using System.Linq;
using UnityEngine;

// Token: 0x0200004A RID: 74
internal class Class36 : Interface1, Interface2
{
	// Token: 0x06000231 RID: 561 RVA: 0x00002328 File Offset: 0x00000528
	public void Initialize()
	{
	}

	// Token: 0x06000232 RID: 562 RVA: 0x0000BE04 File Offset: 0x0000A004
	public void OnUpdate()
	{
		if (Class4.IsInWorld())
		{
			if (Input.GetKeyInt(306) && Input.GetKeyDownInt(323))
			{
				RaycastHit raycastHit;
				if (Physics.Raycast(Camera.current.ScreenPointToRay(Input.mousePosition), ref raycastHit))
				{
					Class3.CurrentPlayer.transform.position = raycastHit.point;
					return;
				}
			}
			else
			{
				if (Input.GetKeyDownInt(102) & Input.GetKeyInt(306))
				{
					Class38.ToggleFly();
					return;
				}
				if (Input.GetKeyDownInt(103) & Input.GetKeyInt(306))
				{
					Class38.ToggleNoClip();
					return;
				}
				if (Input.GetKeyInt(308) && !Class143.bool_7 && !Input.GetKeyInt(9))
				{
					Class143.bool_7 = true;
					Camera.main.fieldOfView = 10f;
					return;
				}
				if (Input.GetKeyUpInt(308) && Class143.bool_7)
				{
					Class143.bool_7 = false;
					Camera.main.fieldOfView = VRCInputManager.Method_Public_Static_Single_EnumNPublicSealedvaCoHeToTaThShPeVoViUnique_0(143);
					return;
				}
				if (Input.GetKeyInt(306) && Input.GetKeyDownInt(53))
				{
					Class43.SwitchCamSetup();
					return;
				}
				if (Input.GetKeyDownInt(325))
				{
					Class52.CustomSerialize(!Class52.bool_0, true);
					return;
				}
				if (Input.GetKeyInt(306) && Input.GetKeyDownInt(49))
				{
					Class10.ChangeAvatar("avtr_c38a1615-5bf5-42b4-84eb-a8b6c37cbd11");
					return;
				}
				if (Input.GetKeyInt(306) && Input.GetKeyDownInt(48))
				{
					DebugLogGui debugLogGui = Resources.FindObjectsOfTypeAll<DebugLogGui>().FirstOrDefault<DebugLogGui>();
					debugLogGui.field_Public_Boolean_0 = !debugLogGui.field_Public_Boolean_0;
					return;
				}
				if (Input.GetKeyInt(306) && Input.GetKeyDownInt(57))
				{
					DebugTextGUI debugTextGUI = Resources.FindObjectsOfTypeAll<DebugTextGUI>().FirstOrDefault<DebugTextGUI>();
					debugTextGUI.field_Public_Boolean_0 = !debugTextGUI.field_Public_Boolean_0;
					return;
				}
				if (Input.GetKeyInt(306) && Input.GetKeyDownInt(56))
				{
					VRCNetworkInfoGUI vrcnetworkInfoGUI = Resources.FindObjectsOfTypeAll<VRCNetworkInfoGUI>().FirstOrDefault<VRCNetworkInfoGUI>();
					vrcnetworkInfoGUI.field_Private_Boolean_0 = !vrcnetworkInfoGUI.field_Private_Boolean_0;
					return;
				}
				if (Input.GetKeyInt(306) && Input.GetKeyDownInt(55))
				{
					DebugNetworkObjectInfo debugNetworkObjectInfo = Resources.FindObjectsOfTypeAll<DebugNetworkObjectInfo>().FirstOrDefault<DebugNetworkObjectInfo>();
					debugNetworkObjectInfo.field_Private_Boolean_0 = !debugNetworkObjectInfo.field_Private_Boolean_0;
					debugNetworkObjectInfo.Method_Private_Void_0();
					return;
				}
				if (Input.GetKeyInt(306) && Input.GetKeyDownInt(54))
				{
					Class3.CurrentVRCPlayer.GetVRCPlayerApi().Respawn();
				}
			}
			return;
		}
	}

	// Token: 0x06000234 RID: 564 RVA: 0x00002C0D File Offset: 0x00000E0D
	internal static bool B5AmLnN6dF4cAcN7uGU()
	{
		return Class36.B5yM0QNlyldWUvDFYDI == null;
	}

	// Token: 0x040000FB RID: 251
	private static Class36 B5yM0QNlyldWUvDFYDI;
}
