using System;
using System.Collections.Generic;
using Hexed.UIApi;
using Hexed.Wrappers;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using VRC.SDK3.Components;
using VRC.SDKBase;
using VRC.Udon;

// Token: 0x02000138 RID: 312
internal class Class131
{
	// Token: 0x060006BD RID: 1725 RVA: 0x00021AC4 File Offset: 0x0001FCC4
	public static void Init()
	{
		QMScrollButton qmscrollButton_0 = new QMScrollButton(Class127.qmmenuPage_0, 3f, 2f, "Udon", "Udon/Trigger Options", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Udon"));
		QMScrollButton qmscrollButton_1 = new QMScrollButton(Class127.qmmenuPage_0, 2f, 2f, "Udon Interact", "Udon Interact Options", ButtonAPI.ButtonSize.Default, null);
		qmscrollButton_1.MainButton.GetGameObject().SetActive(false);
		qmscrollButton_0.SetAction(delegate()
		{
			if (Object.FindObjectOfType<VRCSceneDescriptor>() != null)
			{
				qmscrollButton_0.Add("Send \nCustom", "Send Custom Event", delegate
				{
					Class3.VRCUiPopupManager.AskInGameInput("Custom Event", "Ok", delegate(string text)
					{
						foreach (UdonBehaviour behaviour in Object.FindObjectsOfType<UdonBehaviour>())
						{
							Class117.smethod_0(behaviour, text, null, false);
						}
					}, null);
				});
				using (IEnumerator<UdonBehaviour> enumerator = Object.FindObjectsOfType<UdonBehaviour>().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						UdonBehaviour udonBehaviour_0 = enumerator.Current;
						qmscrollButton_0.Add(udonBehaviour_0.name, "Open Event Menu", delegate
						{
							qmscrollButton_1.SetAction(delegate()
							{
								Dictionary<string, List<uint>>.KeyCollection.Enumerator enumerator3 = udonBehaviour_0._eventTable.Keys.GetEnumerator();
								while (enumerator3.MoveNext())
								{
									string string_0 = enumerator3.Current;
									qmscrollButton_1.Add(string_0, "Trigger Event", delegate
									{
										Class117.smethod_0(udonBehaviour_0, string_0, null, false);
									});
								}
							});
							qmscrollButton_1.MainButton.ClickMe();
						});
					}
					return;
				}
			}
			Logger.Log("SDK2 World found, using Trigger Menu instead", Logger.LogsType.Info);
			using (IEnumerator<VRC_Trigger> enumerator2 = Object.FindObjectsOfType<VRC_Trigger>().GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					VRC_Trigger vrc_Trigger_0 = enumerator2.Current;
					qmscrollButton_0.Add(vrc_Trigger_0.name, "Interact", delegate
					{
						vrc_Trigger_0.Interact();
					});
				}
			}
		});
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x000035F5 File Offset: 0x000017F5
	internal static bool SRpdgA92Qxc3c8hL27a()
	{
		return Class131.seyyqF9Ujq9qD5r31kn == null;
	}

	// Token: 0x040003A1 RID: 929
	private static Class131 seyyqF9Ujq9qD5r31kn;
}
