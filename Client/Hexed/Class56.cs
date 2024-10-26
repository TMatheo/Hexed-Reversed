using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using Hexed.Wrappers;
using UnityEngine;

// Token: 0x02000070 RID: 112
internal class Class56
{
	// Token: 0x06000359 RID: 857 RVA: 0x00011BA8 File Offset: 0x0000FDA8
	public static void Init()
	{
		if (!Class143.bool_8)
		{
			return;
		}
		Class56.class55_0 = new Class54.Class55();
		Class56.gameObject_1 = new GameObject[Class54.Class55.int_0];
		Class56.gameObject_0 = new GameObject("LeapTrackingRoot");
		Class56.gameObject_0.transform.localPosition = Vector3.zero;
		Class56.gameObject_0.transform.localRotation = Quaternion.identity;
		Object.DontDestroyOnLoad(Class56.gameObject_0);
		for (int i = 0; i < Class54.Class55.int_0; i++)
		{
			Class56.gameObject_1[i] = new GameObject("LeapHand" + i.ToString());
			Class56.gameObject_1[i].transform.parent = Class56.gameObject_0.transform;
			Class56.gameObject_1[i].transform.localPosition = Vector3.zero;
			Class56.gameObject_1[i].transform.localRotation = Quaternion.identity;
			Object.DontDestroyOnLoad(Class56.gameObject_1[i]);
		}
		if (Class56.gameObject_0 != null)
		{
			Class56.gameObject_0.transform.parent = Camera.main.transform;
			Class56.gameObject_0.transform.localPosition = new Vector3(0f, -0.5f, 0.3f);
			Class56.gameObject_0.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
		}
		if (File.Exists(Class141.string_0 + "\\LeapMotion\\LeapManager.exe"))
		{
			Process process_0 = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = Class141.string_0 + "\\LeapMotion\\LeapManager.exe",
					WorkingDirectory = Class141.string_0 + "\\LeapMotion",
					CreateNoWindow = true
				}
			};
			process_0.Start();
			IPAddress ipaddress = Dns.GetHostEntry("localhost").AddressList[0];
			IPEndPoint localEP = new IPEndPoint(ipaddress, 1337);
			Class56.socket_0 = new Socket(ipaddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			Class56.socket_0.Bind(localEP);
			Class56.socket_0.Listen(10);
			Class56.socket_1 = Class56.socket_0.Accept();
			Logger.Log("Leap Device Connected", Logger.LogsType.Info);
			new Thread(delegate()
			{
				while (!process_0.HasExited && Class56.socket_1 != null && Class56.socket_1.Connected)
				{
					byte[] array = new byte[15000];
					int count = Class56.socket_1.Receive(array);
					string @string = Encoding.ASCII.GetString(array, 0, count);
					try
					{
						Class56.class58_0 = JsonSerializer.Deserialize<Class57.Class58[]>(@string, null);
					}
					catch
					{
						Class56.class58_0 = null;
						for (int j = 0; j < Class54.Class55.int_0; j++)
						{
							Class56.class55_0.bool_0[j] = false;
						}
					}
				}
			}).Start();
			return;
		}
	}

	// Token: 0x0600035B RID: 859 RVA: 0x00002E9E File Offset: 0x0000109E
	internal static bool WL0G0YnbH0PPTvFFlYe()
	{
		return Class56.mbATmnncloOObfIgNEa == null;
	}

	// Token: 0x0400019E RID: 414
	public static GameObject gameObject_0;

	// Token: 0x0400019F RID: 415
	public static Class54.Class55 class55_0;

	// Token: 0x040001A0 RID: 416
	public static GameObject[] gameObject_1;

	// Token: 0x040001A1 RID: 417
	public static Class57.Class58[] class58_0;

	// Token: 0x040001A2 RID: 418
	private static Socket socket_0;

	// Token: 0x040001A3 RID: 419
	private static Socket socket_1;

	// Token: 0x040001A4 RID: 420
	internal static Class56 mbATmnncloOObfIgNEa;
}
