using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200000A RID: 10
internal class Class6
{
	// Token: 0x06000044 RID: 68
	[DllImport("KERNEL32.DLL", CallingConvention = 3, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern int GetPrivateProfileStringW(string lpSection, string lpKey, string lpDefault, StringBuilder lpReturnString, int nSize, string lpFileName);

	// Token: 0x06000045 RID: 69
	[DllImport("KERNEL32.DLL", CallingConvention = 3, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	private static extern int WritePrivateProfileStringW(string lpSection, string lpKey, string lpValue, string lpFileName);

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000046 RID: 70 RVA: 0x00002459 File Offset: 0x00000659
	// (set) Token: 0x06000047 RID: 71 RVA: 0x00006210 File Offset: 0x00004410
	public string Path
	{
		get
		{
			return this.string_0;
		}
		internal set
		{
			if (!File.Exists(value))
			{
				File.WriteAllText(value, "", Encoding.Unicode);
			}
			this.string_0 = value;
		}
	}

	// Token: 0x06000048 RID: 72 RVA: 0x0000623C File Offset: 0x0000443C
	public Class6(string INIPath)
	{
		this.Path = INIPath;
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00006264 File Offset: 0x00004464
	private void WriteValue(string Section, string Key, string Value)
	{
		Class6.WritePrivateProfileStringW(Section, Key, Value, this.Path);
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00006280 File Offset: 0x00004480
	private string ReadValue(string Section, string Key)
	{
		StringBuilder stringBuilder = new StringBuilder(1023);
		Class6.GetPrivateProfileStringW(Section, Key, " _", stringBuilder, 1023, this.Path);
		if (stringBuilder.ToString().Equals(" _"))
		{
			return null;
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002461 File Offset: 0x00000661
	public bool HasKey(string section, string name)
	{
		return this.ReadValue(section, name) != null;
	}

	// Token: 0x0600004C RID: 76 RVA: 0x000062D0 File Offset: 0x000044D0
	public string GetString(string section, string name, string defaultValue = "", bool autoSave = false)
	{
		string text = this.ReadValue(section, name);
		if (string.IsNullOrEmpty(text))
		{
			if (autoSave)
			{
				this.SetString(section, name, defaultValue);
			}
			return defaultValue;
		}
		return text;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00006304 File Offset: 0x00004504
	public void SetString(string section, string name, string value)
	{
		this.WriteValue(section, name, value.Trim());
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00006320 File Offset: 0x00004520
	public int GetInt(string section, string name, int defaultValue = 0, bool autoSave = false)
	{
		int result;
		if (int.TryParse(this.ReadValue(section, name), out result))
		{
			return result;
		}
		if (autoSave)
		{
			this.SetInt(section, name, defaultValue);
		}
		return defaultValue;
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00006350 File Offset: 0x00004550
	public void SetInt(string section, string name, int value)
	{
		this.WriteValue(section, name, value.ToString());
	}

	// Token: 0x06000050 RID: 80 RVA: 0x0000636C File Offset: 0x0000456C
	public float GetFloat(string section, string name, float defaultValue = 0f, bool autoSave = false)
	{
		float result;
		if (!float.TryParse(this.ReadValue(section, name), out result))
		{
			if (autoSave)
			{
				this.SetFloat(section, name, defaultValue);
			}
			return defaultValue;
		}
		return result;
	}

	// Token: 0x06000051 RID: 81 RVA: 0x0000639C File Offset: 0x0000459C
	public void SetFloat(string section, string name, float value)
	{
		this.WriteValue(section, name, value.ToString());
	}

	// Token: 0x06000052 RID: 82 RVA: 0x000063B8 File Offset: 0x000045B8
	public bool GetBool(string section, string name, bool defaultValue = false, bool autoSave = false)
	{
		string @string = this.GetString(section, name, null, false);
		if (!"true".Equals(@string) && !"1".Equals(@string) && !"0".Equals(@string) && !"false".Equals(@string))
		{
			if (autoSave)
			{
				this.SetBool(section, name, defaultValue);
			}
			return defaultValue;
		}
		return "true".Equals(@string) || "1".Equals(@string);
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00006434 File Offset: 0x00004634
	public void SetBool(string section, string name, bool value)
	{
		this.WriteValue(section, name, (!value) ? "false" : "true");
	}

	// Token: 0x06000054 RID: 84 RVA: 0x0000246E File Offset: 0x0000066E
	internal static bool EZdyl3SGZyhDF4GiR25()
	{
		return Class6.rVKHyFSbBLNPOkW1nHT == null;
	}

	// Token: 0x04000010 RID: 16
	private string string_0 = "";

	// Token: 0x04000011 RID: 17
	internal static Class6 rVKHyFSbBLNPOkW1nHT;
}
