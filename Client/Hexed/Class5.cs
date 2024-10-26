using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CoreRuntime.Manager;
using Hexed.Wrappers;
using UnityEngine;

// Token: 0x02000008 RID: 8
internal static class Class5
{
	// Token: 0x06000032 RID: 50 RVA: 0x00005F34 File Offset: 0x00004134
	public static int IndexOfByteArray(byte[] source, byte[] pattern)
	{
		if (source != null && pattern != null && source.Length != 0 && pattern.Length != 0 && source.Length >= pattern.Length)
		{
			for (int i = 0; i <= source.Length - pattern.Length; i++)
			{
				if (Class5.Matches(source, i, pattern))
				{
					return i;
				}
			}
			return -1;
		}
		return -1;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00005F80 File Offset: 0x00004180
	public static int[] IndexesOfByteArray(byte[] source, byte[] pattern)
	{
		List<int> list = new List<int>();
		if (source != null && pattern != null && source.Length != 0 && pattern.Length != 0 && source.Length >= pattern.Length)
		{
			for (int i = 0; i <= source.Length - pattern.Length; i++)
			{
				if (Class5.Matches(source, i, pattern))
				{
					list.Add(i);
				}
			}
			return list.ToArray();
		}
		return list.ToArray();
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00005FE4 File Offset: 0x000041E4
	private static bool Matches(byte[] source, int startIndex, byte[] pattern)
	{
		for (int i = 0; i < pattern.Length; i++)
		{
			if (source[startIndex + i] != pattern[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00006018 File Offset: 0x00004218
	public static int lastIndexOfByteArray(byte[] source, byte[] pattern)
	{
		byte[] source2 = Class5.reverseArray(source);
		byte[] pattern2 = Class5.reverseArray(pattern);
		int num = Class5.IndexOfByteArray(source2, pattern2);
		if (num == -1)
		{
			return -1;
		}
		return source.Length - num - pattern.Length;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00006050 File Offset: 0x00004250
	public static byte[] reverseArray(byte[] array)
	{
		byte[] array2 = new byte[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = array[array.Length - 1 - i];
		}
		return array2;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x0000608C File Offset: 0x0000428C
	public static Process GetProcessByName(string Name)
	{
		Process[] processesByName = Process.GetProcessesByName(Name);
		if (processesByName != null && processesByName.Length != 0)
		{
			return processesByName[0];
		}
		return null;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002420 File Offset: 0x00000620
	public static IEnumerator DelayAction(float delay, Action action)
	{
		yield return new WaitForSeconds(delay);
		int num;
		if (num != 1)
		{
			yield break;
		}
		action();
		yield break;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x000060B0 File Offset: 0x000042B0
	public static void Start(this IEnumerator e)
	{
		CoroutineManager.RunCoroutine(e);
	}

	// Token: 0x0600003A RID: 58 RVA: 0x000060C4 File Offset: 0x000042C4
	public static void CopyToClipboard(string Text)
	{
		if (Text == null)
		{
			return;
		}
		if (Class7.OpenClipboard(IntPtr.Zero))
		{
			try
			{
				Class7.EmptyClipboard();
				uint uFlags = 2U;
				UIntPtr dwBytes = (UIntPtr)((IntPtr)((Text.Length + 1) * 2));
				IntPtr intPtr = Class7.GlobalAlloc(uFlags, dwBytes);
				if (intPtr != IntPtr.Zero)
				{
					IntPtr intPtr2 = Class7.GlobalLock(intPtr);
					Marshal.Copy(Text.ToCharArray(), 0, intPtr2, Text.Length);
					Marshal.WriteInt16(intPtr2 + (IntPtr)(Text.Length * 2), 0);
					Class7.GlobalUnlock(intPtr);
					if (Class7.SetClipboardData(13U, intPtr) != IntPtr.Zero)
					{
						Logger.Log("Copied: " + Text, Logger.LogsType.Info);
					}
				}
			}
			finally
			{
				Class7.CloseClipboard();
			}
			return;
		}
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00006184 File Offset: 0x00004384
	public static long GetUnixTimeInMilliseconds()
	{
		return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002436 File Offset: 0x00000636
	internal static bool JGBdUhS5BsyEASj0sWj()
	{
		return Class5.JNR7hkSypXNLdqYWRGe == null;
	}

	// Token: 0x0400000A RID: 10
	private static Class5 JNR7hkSypXNLdqYWRGe;
}
