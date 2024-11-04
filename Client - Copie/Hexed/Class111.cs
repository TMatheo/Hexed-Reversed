using System;
using System.IO;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

// Token: 0x02000110 RID: 272
internal class Class111
{
	// Token: 0x06000561 RID: 1377 RVA: 0x00003294 File Offset: 0x00001494
	private static bool ValidateServerCertificate(HttpRequestMessage request, X509Certificate2 certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return certificate.Thumbprint == Class111.string_1;
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x0001BBAC File Offset: 0x00019DAC
	public static bool Init(string UnityLoaderPath)
	{
		if (File.Exists(UnityLoaderPath + "\\Token.Hexed"))
		{
			Class111.string_0 = File.ReadAllText(UnityLoaderPath + "\\Token.Hexed");
			Class111.string_1 = Class109.smethod_0(Class111.FetchCert());
			Class111.string_2 = Class109.smethod_0(Class111.FetchEncryptionKey());
			Class111.string_3 = Class109.smethod_0(Class111.FetchDecryptionKey());
			return Class111.IsValidToken();
		}
		return false;
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x0001BC14 File Offset: 0x00019E14
	private static string FetchCert()
	{
		HttpClient httpClient = new HttpClient(new HttpClientHandler
		{
			UseCookies = false
		});
		httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Hexed)");
		HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://api.logout.rip/Server/Certificate");
		HttpResponseMessage httpResponseMessage = httpClient.Send(request);
		if (!httpResponseMessage.IsSuccessStatusCode)
		{
			return null;
		}
		return httpResponseMessage.Content.ReadAsStringAsync().Result;
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x0001BC80 File Offset: 0x00019E80
	private static string FetchEncryptionKey()
	{
		HttpClientHandler httpClientHandler = new HttpClientHandler();
		httpClientHandler.UseCookies = false;
		Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> serverCertificateCustomValidationCallback;
		if ((serverCertificateCustomValidationCallback = Class111.<>O.func_0) == null)
		{
			serverCertificateCustomValidationCallback = (Class111.<>O.func_0 = new Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool>(Class111.ValidateServerCertificate));
		}
		httpClientHandler.ServerCertificateCustomValidationCallback = serverCertificateCustomValidationCallback;
		HttpClient httpClient = new HttpClient(httpClientHandler);
		httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Hexed)");
		HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://api.logout.rip/Server/EncryptKey");
		HttpResponseMessage httpResponseMessage = httpClient.Send(request);
		if (httpResponseMessage.IsSuccessStatusCode)
		{
			return httpResponseMessage.Content.ReadAsStringAsync().Result;
		}
		return null;
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x0001BD0C File Offset: 0x00019F0C
	private static string FetchDecryptionKey()
	{
		HttpClientHandler httpClientHandler = new HttpClientHandler();
		httpClientHandler.UseCookies = false;
		Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> serverCertificateCustomValidationCallback;
		if ((serverCertificateCustomValidationCallback = Class111.<>O.func_0) == null)
		{
			serverCertificateCustomValidationCallback = (Class111.<>O.func_0 = new Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool>(Class111.ValidateServerCertificate));
		}
		httpClientHandler.ServerCertificateCustomValidationCallback = serverCertificateCustomValidationCallback;
		HttpClient httpClient = new HttpClient(httpClientHandler);
		httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Hexed)");
		HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://api.logout.rip/Server/DecryptKey");
		HttpResponseMessage httpResponseMessage = httpClient.Send(request);
		if (!httpResponseMessage.IsSuccessStatusCode)
		{
			return null;
		}
		return httpResponseMessage.Content.ReadAsStringAsync().Result;
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x0001BD98 File Offset: 0x00019F98
	public static bool IsValidToken()
	{
		HttpClientHandler httpClientHandler = new HttpClientHandler();
		httpClientHandler.UseCookies = false;
		Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> serverCertificateCustomValidationCallback;
		if ((serverCertificateCustomValidationCallback = Class111.<>O.func_0) == null)
		{
			serverCertificateCustomValidationCallback = (Class111.<>O.func_0 = new Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool>(Class111.ValidateServerCertificate));
		}
		httpClientHandler.ServerCertificateCustomValidationCallback = serverCertificateCustomValidationCallback;
		HttpClient httpClient = new HttpClient(httpClientHandler);
		httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Hexed)");
		HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://api.logout.rip/Server/IsValidToken")
		{
			Content = new StringContent(Class108.EncryptData(JsonSerializer.Serialize(new
			{
				Key = Class111.string_0,
				HWID = Class110.GetHWID(),
				ServerTime = Class109.GetUnixTime()
			}, null), Class111.string_2), Encoding.UTF8, "application/json")
		};
		return httpClient.Send(request).IsSuccessStatusCode;
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x0001BE44 File Offset: 0x0001A044
	public static string DownloadAsset(string Asset)
	{
		HttpClientHandler httpClientHandler = new HttpClientHandler();
		httpClientHandler.UseCookies = false;
		Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> serverCertificateCustomValidationCallback;
		if ((serverCertificateCustomValidationCallback = Class111.<>O.func_0) == null)
		{
			serverCertificateCustomValidationCallback = (Class111.<>O.func_0 = new Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool>(Class111.ValidateServerCertificate));
		}
		httpClientHandler.ServerCertificateCustomValidationCallback = serverCertificateCustomValidationCallback;
		HttpClient httpClient = new HttpClient(httpClientHandler);
		httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Hexed)");
		HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://api.logout.rip/Server/GetAsset/" + Asset);
		HttpResponseMessage httpResponseMessage = httpClient.Send(request);
		if (!httpResponseMessage.IsSuccessStatusCode)
		{
			return null;
		}
		return httpResponseMessage.Content.ReadAsStringAsync().Result;
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x000032A6 File Offset: 0x000014A6
	internal static bool nH0QeSIJWJqHoKoBvfj()
	{
		return Class111.jy0137I8bAgsTOmSsgd == null;
	}

	// Token: 0x04000289 RID: 649
	private static string string_0;

	// Token: 0x0400028A RID: 650
	private static string string_1;

	// Token: 0x0400028B RID: 651
	private static string string_2;

	// Token: 0x0400028C RID: 652
	private static string string_3;

	// Token: 0x0400028D RID: 653
	private static Class111 jy0137I8bAgsTOmSsgd;

	// Token: 0x02000111 RID: 273
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400028E RID: 654
		[Nullable(new byte[]
		{
			0,
			1,
			2,
			2
		})]
		public static Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> func_0;
	}
}
