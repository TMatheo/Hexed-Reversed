using System;
using System.Linq;
using System.Text;

// Token: 0x0200010D RID: 269
internal class Class109
{
	// Token: 0x0600054C RID: 1356 RVA: 0x0001B698 File Offset: 0x00019898
	public static string RandomString(int length)
	{
		char[] array = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToArray<char>();
		string text = string.Empty;
		for (int i = 0; i < length; i++)
		{
			ReadOnlySpan<char> str = text;
			char c = array[Class109.random_0.Next(array.Length)];
			text = str + new ReadOnlySpan<char>(ref c);
		}
		return text;
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x0001B6F4 File Offset: 0x000198F4
	public static string RandomStringNumber(int length)
	{
		char[] array = "0123456789".ToArray<char>();
		string text = string.Empty;
		for (int i = 0; i < length; i++)
		{
			ReadOnlySpan<char> str = text;
			char c = array[Class109.random_0.Next(array.Length)];
			text = str + new ReadOnlySpan<char>(ref c);
		}
		return text;
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x0001B750 File Offset: 0x00019950
	public static string smethod_0(string Data)
	{
		byte[] bytes = Convert.FromBase64String(Data);
		return Encoding.UTF8.GetString(bytes);
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x0000322A File Offset: 0x0000142A
	public static string ToBase64(string Data)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(Data));
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x0001B774 File Offset: 0x00019974
	public static long GetUnixTime()
	{
		return DateTimeOffset.UtcNow.ToUnixTimeSeconds();
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x0000323C File Offset: 0x0000143C
	internal static bool M6safHIUt3sx6bn1CTg()
	{
		return Class109.IRqkUBIoyA4gqjKwZBN == null;
	}

	// Token: 0x0400027F RID: 639
	public static Random random_0 = new Random(Environment.TickCount);

	// Token: 0x04000280 RID: 640
	private static Class109 IRqkUBIoyA4gqjKwZBN;
}
