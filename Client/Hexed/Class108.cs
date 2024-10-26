using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

// Token: 0x0200010C RID: 268
internal class Class108
{
	// Token: 0x06000546 RID: 1350 RVA: 0x0001B3C8 File Offset: 0x000195C8
	public static string DecryptData(string combinedString, string privateKey)
	{
		string[] array = combinedString.Split('|', StringSplitOptions.None);
		string s = array[0];
		string s2 = array[1];
		string s3 = array[2];
		byte[] data = Convert.FromBase64String(s);
		byte[] rgb = Convert.FromBase64String(s2);
		byte[] rgb2 = Convert.FromBase64String(s3);
		string @string;
		using (RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider())
		{
			rsacryptoServiceProvider.FromXmlString(privateKey);
			byte[] key = rsacryptoServiceProvider.Decrypt(rgb, false);
			byte[] iv = rsacryptoServiceProvider.Decrypt(rgb2, false);
			byte[] bytes = Class108.DecryptWithAes(data, key, iv);
			@string = Encoding.UTF8.GetString(bytes);
		}
		return @string;
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x0001B468 File Offset: 0x00019668
	private static byte[] DecryptWithAes(byte[] data, byte[] key, byte[] iv)
	{
		byte[] result;
		using (Aes aes = Aes.Create())
		{
			aes.Key = key;
			aes.IV = iv;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(data, 0, data.Length);
					cryptoStream.FlushFinalBlock();
				}
				result = memoryStream.ToArray();
			}
		}
		return result;
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x0001B514 File Offset: 0x00019714
	public static string EncryptData(string dataToEncrypt, string publicKey)
	{
		string result;
		using (Aes aes = Aes.Create())
		{
			byte[] inArray = Class108.EncryptWithAes(Encoding.UTF8.GetBytes(dataToEncrypt), aes.Key, aes.IV);
			using (RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider())
			{
				rsacryptoServiceProvider.FromXmlString(publicKey);
				byte[] inArray2 = rsacryptoServiceProvider.Encrypt(aes.Key, false);
				byte[] inArray3 = rsacryptoServiceProvider.Encrypt(aes.IV, false);
				result = string.Concat(new string[]
				{
					Convert.ToBase64String(inArray),
					"|",
					Convert.ToBase64String(inArray2),
					"|",
					Convert.ToBase64String(inArray3)
				});
			}
		}
		return result;
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x0001B5EC File Offset: 0x000197EC
	private static byte[] EncryptWithAes(byte[] data, byte[] key, byte[] iv)
	{
		byte[] result;
		using (Aes aes = Aes.Create())
		{
			aes.Key = key;
			aes.IV = iv;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(data, 0, data.Length);
					cryptoStream.FlushFinalBlock();
				}
				result = memoryStream.ToArray();
			}
		}
		return result;
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00003220 File Offset: 0x00001420
	internal static bool RoFAu6IhnJrRA7lAk45()
	{
		return Class108.o6uMGCIO2R9Vd8UmFNM == null;
	}

	// Token: 0x0400027E RID: 638
	internal static Class108 o6uMGCIO2R9Vd8UmFNM;
}
