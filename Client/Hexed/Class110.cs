using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

// Token: 0x0200010E RID: 270
internal class Class110
{
	// Token: 0x06000554 RID: 1364 RVA: 0x0001B7AC File Offset: 0x000199AC
	public static string GetHWID()
	{
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, string> keyValuePair in new Dictionary<string, string>
		{
			{
				"Win32_DiskDrive where (MediaType = 'Fixed hard disk media')",
				"SerialNumber"
			},
			{
				"Win32_ComputerSystemProduct",
				"UUID"
			},
			{
				"Win32_BaseBoard",
				"SerialNumber"
			}
		})
		{
			foreach (string item in Class110.ExecuteWmiQuery(keyValuePair.Key, keyValuePair.Value))
			{
				list.Add(item);
			}
		}
		foreach (string item2 in Class110.GetNvidiaGpuUuids())
		{
			list.Add(item2);
		}
		string s = string.Join("+", list);
		string result;
		using (SHA256 sha = SHA256.Create())
		{
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			byte[] array2 = sha.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in array2)
			{
				stringBuilder.Append(b.ToString("x2"));
			}
			result = stringBuilder.ToString();
		}
		return result;
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x0001B91C File Offset: 0x00019B1C
	private static string[] ExecuteWmiQuery(string className, string Query)
	{
		string[] result;
		try
		{
			using (Process process = new Process())
			{
				process.StartInfo.FileName = "wmic";
				process.StartInfo.Arguments = "path " + className + " get " + Query;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				string text = process.StandardOutput.ReadToEnd();
				process.WaitForExit();
				result = (from line in (from line in text.Split(new string[]
				{
					Environment.NewLine
				}, StringSplitOptions.RemoveEmptyEntries)
				select line.Trim()).Skip(1)
				where !string.IsNullOrWhiteSpace(line)
				select line).ToArray<string>();
			}
		}
		catch
		{
			result = Array.Empty<string>();
		}
		return result;
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x0001BA40 File Offset: 0x00019C40
	private static string[] GetNvidiaGpuUuids()
	{
		string[] result;
		try
		{
			using (Process process = new Process())
			{
				process.StartInfo.FileName = "nvidia-smi";
				process.StartInfo.Arguments = "-L";
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				string text = process.StandardOutput.ReadToEnd();
				process.WaitForExit();
				result = (from line in (from line in text.Split(new string[]
				{
					Environment.NewLine
				}, StringSplitOptions.RemoveEmptyEntries)
				select line.Trim(')') into x
				where x.Contains("GPU-")
				select x).ToArray<string>()
				select line.Split(' ', StringSplitOptions.None).Last<string>()).ToArray<string>();
			}
		}
		catch
		{
			result = Array.Empty<string>();
		}
		return result;
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x00003246 File Offset: 0x00001446
	internal static bool B6qOfuIiIZjNQiR4MBy()
	{
		return Class110.ekQw0mIHbq3UHJ17nB4 == null;
	}

	// Token: 0x04000281 RID: 641
	private static Class110 ekQw0mIHbq3UHJ17nB4;
}
