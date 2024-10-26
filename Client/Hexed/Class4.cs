using System;
using Il2CppSystem.Collections.Generic;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.XR;
using VRC.Core;
using VRC.SDKBase;

// Token: 0x02000007 RID: 7
internal static class Class4
{
	// Token: 0x06000029 RID: 41 RVA: 0x00005D40 File Offset: 0x00003F40
	public static bool IsInVr()
	{
		List<XRDisplaySubsystem> list = new List<XRDisplaySubsystem>();
		SubsystemManager.GetInstances<XRDisplaySubsystem>(list);
		List<XRDisplaySubsystem>.Enumerator enumerator = list.GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (enumerator.Current.running)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00005D80 File Offset: 0x00003F80
	public static bool IsInWorld()
	{
		return Class3.VRCNetworkingClient.Method_Public_get_Room_0() != null && Class3.CurrentPlayer != null;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00005DA8 File Offset: 0x00003FA8
	public static string GetCurrentWorldID()
	{
		Room room = Class3.VRCNetworkingClient.Method_Public_get_Room_0();
		if (room == null)
		{
			return null;
		}
		return room.field_Protected_String_0;
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00005DCC File Offset: 0x00003FCC
	public static bool Forcejoin(string id)
	{
		string text = id.Trim(new char[]
		{
			'\r',
			'\n',
			' '
		});
		if (text.Contains("worldId=") && text.Contains("&instanceId="))
		{
			int num = text.IndexOf("worldId=");
			int num2 = text.IndexOf("&instanceId=");
			string str = text.Substring(num + "worldId=".Length, num2 - (num + "worldId=".Length));
			string str2 = text.Substring(num2 + "&instanceId=".Length);
			return Class4.Forcejoin(str + ":" + str2);
		}
		return Class66.CheckWorldID(text) && Networking.GoToRoom(text);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00005E88 File Offset: 0x00004088
	public static InstanceAccessType GetWorldType(string WorldID)
	{
		if (WorldID.Contains("~canRequestInvite"))
		{
			return 4;
		}
		if (WorldID.Contains("~private"))
		{
			return 3;
		}
		if (WorldID.Contains("~friends"))
		{
			return 2;
		}
		if (WorldID.Contains("~hidden"))
		{
			return 1;
		}
		if (WorldID.Contains("~group"))
		{
			return 5;
		}
		return 0;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00005EE4 File Offset: 0x000040E4
	public static string GetLocalizedWorldType(InstanceAccessType Type)
	{
		switch (Type)
		{
		case 0:
			return "Public";
		case 1:
			return "Friends+";
		case 2:
			return "Friends";
		case 3:
			return "Invite";
		case 4:
			return "Invite+";
		case 5:
			return "Group";
		default:
			return null;
		}
	}

	// Token: 0x0600002F RID: 47 RVA: 0x000023EA File Offset: 0x000005EA
	public static GameObject[] GetWorldPrefabs()
	{
		return VRC_SceneDescriptor.Instance.DynamicPrefabs.ToArray();
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002400 File Offset: 0x00000600
	public static Material[] GetWorldMaterials()
	{
		return VRC_SceneDescriptor.Instance.DynamicMaterials.ToArray();
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002416 File Offset: 0x00000616
	internal static bool ocrukGSBOXj5M9nR6WS()
	{
		return Class4.JJ4wBJSvIvUXIvCF3iD == null;
	}

	// Token: 0x04000009 RID: 9
	private static Class4 JJ4wBJSvIvUXIvCF3iD;
}
