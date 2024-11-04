using System;
using System.Collections.Generic;
using System.Linq;
using Photon.Pun;
using UnityEngine;
using VRC;
using VRC.Core;
using VRC.SDKBase;

// Token: 0x02000117 RID: 279
internal class Class116
{
	// Token: 0x06000584 RID: 1412 RVA: 0x0001C030 File Offset: 0x0001A230
	public static void TakeOwnershipIfNecessary(GameObject gameObject)
	{
		Player objectOwner = Class116.GetObjectOwner(gameObject);
		if (((objectOwner != null) ? objectOwner.UserID() : null) != APIUser.CurrentUser.UserID())
		{
			Networking.SetOwner(Class3.CurrentPlayer.GetVRCPlayerApi(), gameObject);
		}
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x0001C070 File Offset: 0x0001A270
	public static Player GetObjectOwner(GameObject gameObject)
	{
		foreach (Player player in Class3.PlayerManager.GetAllPlayers())
		{
			if (player.GetVRCPlayerApi().IsOwner(gameObject))
			{
				return player;
			}
		}
		return null;
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x0001C0B8 File Offset: 0x0001A2B8
	public static void ItemsToPlayer(Player Player)
	{
		Class116.ItemsToPosition(Player.transform.position);
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x0001C0D8 File Offset: 0x0001A2D8
	public static void ItemsToPosition(Vector3 Position)
	{
		foreach (VRC_Pickup vrc_Pickup in Class116.GetAllPickups())
		{
			Class116.TakeOwnershipIfNecessary(vrc_Pickup.gameObject);
			vrc_Pickup.transform.position = Position;
		}
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x0001C11C File Offset: 0x0001A31C
	public static VRC_Pickup[] GetAllPickups()
	{
		IEnumerable<VRC_Pickup> enumerable = from x in Resources.FindObjectsOfTypeAll<VRC_Pickup>()
		where x.name != "PhotoCamera" && x.name != "AvatarDebugConsole" && x.name != "OscDebugConsole" && x.name != "DebugConsole" && x.name != "ViewFinder" && x.name != "MirrorPickup"
		select x;
		if (enumerable == null)
		{
			return null;
		}
		return enumerable.ToArray<VRC_Pickup>();
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x0001C160 File Offset: 0x0001A360
	public static bool IsViewIdPickupable(int viewId)
	{
		PhotonView photonView = PhotonView.Method_Public_Static_PhotonView_Int32_0(viewId);
		return !(photonView == null) && photonView.gameObject.GetComponent<VRC_Pickup>() != null;
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x0001C194 File Offset: 0x0001A394
	public static void ToggleHeadlight(bool state)
	{
		if (!state)
		{
			Light component = Camera.main.gameObject.GetComponent<Light>();
			if (component != null)
			{
				Object.Destroy(component);
			}
			return;
		}
		Light light = Camera.main.gameObject.AddComponent<Light>();
		light.type = 0;
		light.range = 40f;
		light.spotAngle = 80f;
		light.color = Color.white;
		light.intensity = 1f;
		light.shadows = 0;
		light.boundingSphereOverride = new Vector4(0f, 0f, 0f, 4f);
		light.renderMode = 1;
		light.useBoundingSphereOverride = true;
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x00003347 File Offset: 0x00001547
	internal static bool Vl1BvFIyE5ug8bjkxFE()
	{
		return Class116.PRp38aICisnK8xocnew == null;
	}

	// Token: 0x04000298 RID: 664
	internal static Class116 PRp38aICisnK8xocnew;
}
