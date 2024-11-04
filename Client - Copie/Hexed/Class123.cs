using System;
using System.Collections.Generic;
using System.Text.Json;
using Hexed.UIApi;
using Hexed.Wrappers;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using VRC.Udon;

// Token: 0x02000123 RID: 291
internal class Class123
{
	// Token: 0x060005F0 RID: 1520 RVA: 0x0001E258 File Offset: 0x0001C458
	public static void Init()
	{
		Class123.qmmenuPage_0 = new QMMenuPage("Player Utils");
		new QMSingleButton(Class122.qmmenuPage_0, 1f, 0f, "Utils", new Action(Class123.qmmenuPage_0.OpenMe), "Utils Options", ButtonAPI.ButtonSize.Default, Class11.GetSprite("Utils"));
		new QMSingleButton(Class123.qmmenuPage_0, 1f, 0f, "Teleport", delegate()
		{
			Class3.CurrentPlayer.transform.position = Class9.GetSelectedPlayer().transform.position;
		}, "Teleport to the Player", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class123.qmmenuPage_0, 1f, 0.5f, "Copy \nUserID", delegate()
		{
			Class5.CopyToClipboard(Class9.GetSelectedPlayer().UserID());
		}, "Copy the UserID", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class123.qmmenuPage_0, 2f, 0f, "Dump \nProps", delegate()
		{
			Logger.Log(JsonSerializer.Serialize<object>(Class0.Class2.smethod_0(Class9.GetSelectedPlayer().GetPhotonPlayer().GetProperties()), new JsonSerializerOptions
			{
				WriteIndented = true
			}), Logger.LogsType.Info);
		}, "Dump the Player properties", ButtonAPI.ButtonSize.Half, null);
		QMScrollButton qmscrollButton_0 = new QMScrollButton(Class123.qmmenuPage_0, 2f, 0.5f, "Udon", "Udon Options", ButtonAPI.ButtonSize.Half, null);
		QMScrollButton qmscrollButton_1 = new QMScrollButton(Class123.qmmenuPage_0, 2f, 2f, "Udon Interact", "Udon Interact Options", ButtonAPI.ButtonSize.Default, null);
		qmscrollButton_1.MainButton.GetGameObject().SetActive(false);
		qmscrollButton_0.SetAction(delegate()
		{
			qmscrollButton_0.Add("Send \nCustom", "Send Custom Event", delegate
			{
				Class3.VRCUiPopupManager.AskInGameInput("Custom Event", "Ok", delegate(string text)
				{
					foreach (UdonBehaviour behaviour in Object.FindObjectsOfType<UdonBehaviour>())
					{
						Class117.smethod_0(behaviour, text, Class9.GetSelectedPlayer(), false);
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
							Dictionary<string, List<uint>>.KeyCollection.Enumerator enumerator2 = udonBehaviour_0._eventTable.Keys.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								string string_0 = enumerator2.Current;
								qmscrollButton_1.Add(string_0, "Trigger Event", delegate
								{
									Class117.smethod_0(udonBehaviour_0, string_0, Class9.GetSelectedPlayer(), false);
								});
							}
						});
						qmscrollButton_1.MainButton.ClickMe();
					});
				}
			}
		});
		new QMSingleButton(Class123.qmmenuPage_0, 3f, 0f, "Copy \nActorID", delegate()
		{
			Class5.CopyToClipboard(Class9.GetSelectedPlayer().GetPhotonPlayer().ActorID().ToString());
		}, "Copy the ActorID", ButtonAPI.ButtonSize.Half, null);
		new QMSingleButton(Class123.qmmenuPage_0, 3f, 0.5f, "Copy \nName", delegate()
		{
			Class5.CopyToClipboard(Class9.GetSelectedPlayer().DisplayName());
		}, "Copy the Name", ButtonAPI.ButtonSize.Half, null);
		new QMToggleButton(Class123.qmmenuPage_0, 4f, 0f, "Always \nHear", delegate()
		{
			Class49.ListenPlayer(Class9.GetSelectedPlayer(), true);
		}, delegate()
		{
			Class49.ListenPlayer(Class9.GetSelectedPlayer(), false);
		}, "Always listen to the Player", false);
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x0000342B File Offset: 0x0000162B
	internal static bool SU32iqItfegLubcrLmp()
	{
		return Class123.iyYxfvI4GKJBdbITeS3 == null;
	}

	// Token: 0x040002DB RID: 731
	private static QMMenuPage qmmenuPage_0;

	// Token: 0x040002DC RID: 732
	internal static Class123 iyYxfvI4GKJBdbITeS3;
}
