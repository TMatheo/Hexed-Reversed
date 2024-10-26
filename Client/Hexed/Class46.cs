using System;
using System.Collections;
using System.IO;
using System.Linq;
using Hexed.UIApi;
using Hexed.Wrappers;
using UnityEngine;
using UnityEngine.Networking;

// Token: 0x02000056 RID: 86
internal class Class46
{
	// Token: 0x0600028A RID: 650 RVA: 0x0000EDFC File Offset: 0x0000CFFC
	public static void Initialize()
	{
		if (File.Exists(Class141.string_0 + "\\Assets\\LoadingMusic.ogg"))
		{
			Class46.LoadCustomMusic().Start();
		}
		if (File.Exists(Class141.string_0 + "\\Assets\\HideRobot.vrca"))
		{
			Class46.LoadCustomHidebot().Start();
		}
	}

	// Token: 0x0600028B RID: 651 RVA: 0x00002CA7 File Offset: 0x00000EA7
	private static IEnumerator LoadCustomHidebot()
	{
		Logger.Log("Found custom Hide Robot", Logger.LogsType.Info);
		UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle(string.Format("file://{0}", Directory.GetCurrentDirectory() + (Class141.string_0 + "\\Assets\\HideRobot.vrca")).Replace("\\", "/"));
		www.SendWebRequest();
		while (!www.isDone)
		{
			yield return new WaitForEndOfFrame();
			int num;
			if (num != 1)
			{
				yield break;
			}
		}
		AssetBundle content = DownloadHandlerAssetBundle.GetContent(www);
		string text = (from x in content.GetAllAssetNames()
		where x.EndsWith(".prefab")
		select x).FirstOrDefault<string>();
		if (text != null)
		{
			GameObject gameObject = content.LoadAsset<GameObject>(text);
			gameObject.hideFlags |= 32;
			foreach (VRCAvatarManager vrcavatarManager in Resources.FindObjectsOfTypeAll<VRCAvatarManager>())
			{
				vrcavatarManager.field_Public_GameObject_1 = gameObject;
				vrcavatarManager.field_Public_GameObject_2 = gameObject;
			}
			yield break;
		}
		Logger.LogError("Failed to find prefab in Assetbundle");
		yield break;
	}

	// Token: 0x0600028C RID: 652 RVA: 0x00002CAF File Offset: 0x00000EAF
	public static IEnumerator LoadCustomMusic()
	{
		UnityWebRequest audioLoader = UnityWebRequest.Get(string.Format("file://{0}", Directory.GetCurrentDirectory() + (Class141.string_0 + "\\Assets\\LoadingMusic.ogg")).Replace("\\", "/"));
		audioLoader.SendWebRequest();
		while (!audioLoader.isDone)
		{
			yield return new WaitForEndOfFrame();
		}
		if (!audioLoader.isHttpError)
		{
			AudioClip t = WebRequestWWW.InternalCreateAudioClipUsingDH(audioLoader.downloadHandler, audioLoader.url, false, false, 0);
			t.hideFlags |= 32;
			while (MenuHelper.userInterface == null)
			{
				yield return new WaitForEndOfFrame();
			}
			while (MenuHelper.userInterface.Find("LoadingBackground_TealGradient_Music/LoadingSound") == null)
			{
				yield return new WaitForEndOfFrame();
			}
			Class46.ReplaceClip(MenuHelper.userInterface.Find("LoadingBackground_TealGradient_Music/LoadingSound").GetComponent<AudioSource>(), t);
			for (;;)
			{
				Transform transform = MenuHelper.userInterface.Find("MenuContent/Popups/LoadingPopup/LoadingSound");
				bool flag;
				if (transform == null)
				{
					flag = false;
				}
				else
				{
					GameObject gameObject = transform.gameObject;
					bool? flag2 = (gameObject == null) ? null : new bool?(gameObject.active);
					flag = (!flag2.GetValueOrDefault() & flag2 != null);
				}
				if (!flag)
				{
					break;
				}
				yield return new WaitForEndOfFrame();
			}
			yield return new WaitForEndOfFrame();
			Class46.ReplaceClip(MenuHelper.userInterface.Find("MenuContent/Popups/LoadingPopup/LoadingSound").GetComponent<AudioSource>(), t);
			Logger.Log("Initialized custom Loading Music", Logger.LogsType.Info);
			t = null;
		}
		yield break;
	}

	// Token: 0x0600028D RID: 653 RVA: 0x0000EE4C File Offset: 0x0000D04C
	private static void ReplaceClip(AudioSource src, AudioClip t)
	{
		Object.Destroy(src.GetComponent<VRCUiPageLoadingMusicController>());
		src.Stop();
		src.clip = t;
		src.loop = true;
		src.playOnAwake = true;
		src.Play();
	}

	// Token: 0x0600028F RID: 655 RVA: 0x00002CB7 File Offset: 0x00000EB7
	internal static bool jnO3QXnhqHycqlLLW2f()
	{
		return Class46.XZ2OA7nObbU0f7CP8B1 == null;
	}

	// Token: 0x04000123 RID: 291
	private static Class46 XZ2OA7nObbU0f7CP8B1;
}
