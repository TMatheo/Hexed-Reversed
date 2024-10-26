using System;
using UnityEngine;

// Token: 0x02000053 RID: 83
internal class Class43 : Interface1, Interface2
{
	// Token: 0x06000277 RID: 631 RVA: 0x0000E2CC File Offset: 0x0000C4CC
	public void Initialize()
	{
		GameObject gameObject = Camera.main.gameObject;
		Class43.gameObject_0 = GameObject.CreatePrimitive(3);
		Class43.gameObject_0.hideFlags |= 32;
		Class43.gameObject_0.name = "BackCamera";
		Object.Destroy(Class43.gameObject_0.GetComponent<BoxCollider>());
		Object.Destroy(Class43.gameObject_0.GetComponent<MeshRenderer>());
		Object.Destroy(Class43.gameObject_0.GetComponent<MeshFilter>());
		Class43.gameObject_0.transform.localScale = gameObject.transform.localScale;
		Rigidbody rigidbody = Class43.gameObject_0.AddComponent<Rigidbody>();
		rigidbody.isKinematic = true;
		rigidbody.useGravity = false;
		Class43.gameObject_0.GetComponent<Renderer>().enabled = false;
		Class43.gameObject_0.AddComponent<Camera>();
		Class43.gameObject_0.transform.parent = gameObject.transform;
		Class43.gameObject_0.transform.rotation = gameObject.transform.rotation;
		Class43.gameObject_0.transform.position = gameObject.transform.position;
		Class43.gameObject_0.transform.position -= Class43.gameObject_0.transform.forward * 2f;
		Class43.gameObject_0.GetComponent<Camera>().fieldOfView = VRCInputManager.Method_Public_Static_Single_EnumNPublicSealedvaCoHeToTaThShPeVoViUnique_0(143);
		Class43.gameObject_1 = GameObject.CreatePrimitive(3);
		Class43.gameObject_1.hideFlags |= 32;
		Class43.gameObject_1.name = "FrontCamera";
		Object.Destroy(Class43.gameObject_1.GetComponent<BoxCollider>());
		Object.Destroy(Class43.gameObject_1.GetComponent<MeshRenderer>());
		Object.Destroy(Class43.gameObject_1.GetComponent<MeshFilter>());
		Class43.gameObject_1.transform.localScale = gameObject.transform.localScale;
		Rigidbody rigidbody2 = Class43.gameObject_1.AddComponent<Rigidbody>();
		rigidbody2.isKinematic = true;
		rigidbody2.useGravity = false;
		Class43.gameObject_1.GetComponent<Renderer>().enabled = false;
		Class43.gameObject_1.AddComponent<Camera>();
		Class43.gameObject_0.GetComponent<BoxCollider>().enabled = false;
		Class43.gameObject_1.transform.parent = gameObject.transform;
		Class43.gameObject_1.transform.rotation = gameObject.transform.rotation;
		Class43.gameObject_1.transform.Rotate(0f, 180f, 0f);
		Class43.gameObject_1.transform.position = gameObject.transform.position;
		Class43.gameObject_1.transform.position += -Class43.gameObject_1.transform.forward * 2f;
		Class43.gameObject_1.GetComponent<Camera>().fieldOfView = VRCInputManager.Method_Public_Static_Single_EnumNPublicSealedvaCoHeToTaThShPeVoViUnique_0(143);
		Class43.gameObject_1.GetComponent<Camera>().enabled = false;
		Class43.gameObject_0.GetComponent<Camera>().enabled = false;
	}

	// Token: 0x06000278 RID: 632 RVA: 0x0000E5B8 File Offset: 0x0000C7B8
	public void OnUpdate()
	{
		if (Class4.IsInWorld() && !(Class43.gameObject_0 == null) && !(Class43.gameObject_1 == null))
		{
			switch (Class43.int_0)
			{
			case 0:
				Class43.gameObject_0.GetComponent<Camera>().enabled = false;
				Class43.gameObject_1.GetComponent<Camera>().enabled = false;
				break;
			case 1:
				Class43.gameObject_0.GetComponent<Camera>().enabled = true;
				Class43.gameObject_1.GetComponent<Camera>().enabled = false;
				break;
			case 2:
				Class43.gameObject_0.GetComponent<Camera>().enabled = false;
				Class43.gameObject_1.GetComponent<Camera>().enabled = true;
				break;
			}
			if (Class43.int_0 != 0)
			{
				float axis = Input.GetAxis("Mouse ScrollWheel");
				if (axis > 0f)
				{
					Class43.gameObject_0.transform.position += Class43.gameObject_0.transform.forward * 0.1f;
					Class43.gameObject_1.transform.position -= Class43.gameObject_0.transform.forward * 0.1f;
					return;
				}
				if (axis < 0f)
				{
					Class43.gameObject_0.transform.position -= Class43.gameObject_0.transform.forward * 0.1f;
					Class43.gameObject_1.transform.position += Class43.gameObject_0.transform.forward * 0.1f;
				}
			}
			return;
		}
	}

	// Token: 0x06000279 RID: 633 RVA: 0x0000E768 File Offset: 0x0000C968
	public static void SwitchCamSetup()
	{
		switch (Class43.int_0)
		{
		case 0:
			Class43.int_0 = 1;
			return;
		case 1:
			Class43.int_0 = 2;
			return;
		case 2:
			Class43.int_0 = 0;
			return;
		default:
			return;
		}
	}

	// Token: 0x0600027B RID: 635 RVA: 0x00002C89 File Offset: 0x00000E89
	internal static bool bOaMwUNIMXL4O5iq33G()
	{
		return Class43.YTZUY9NTq12ulnW4BeZ == null;
	}

	// Token: 0x0400011A RID: 282
	private static GameObject gameObject_0;

	// Token: 0x0400011B RID: 283
	private static GameObject gameObject_1;

	// Token: 0x0400011C RID: 284
	private static int int_0;

	// Token: 0x0400011D RID: 285
	internal static Class43 YTZUY9NTq12ulnW4BeZ;
}
