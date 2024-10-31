using System;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Hexed.HexedServer
{
	// Token: 0x02000008 RID: 8
	internal class ServerHandler
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00005900 File Offset: 0x00003B00
		public static bool Init()
		{
			int num = 6;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					Encryption.DecryptionKey = ServerHandler.pjmQhCZGn4377pnmDNJ(ServerHandler.FetchDecryptionKey().Result);
					num2 = 4;
					if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_cddfc40cd36944feba63584f794d66e0 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					goto IL_126;
				case 3:
					Encryption.EncryptionKey = ServerHandler.pjmQhCZGn4377pnmDNJ(ServerHandler.FetchEncryptionKey().Result);
					num2 = 1;
					if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_516e7c1c53c544dcbcf294bcc1855e5f == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					goto IL_FD;
				case 5:
					ServerHandler.Y0ZU94ZcKQWao7gkkyQ(ServerHandler.BJKu3ZZ9G7t7Q45AMVd(cnfpx8kpBc0Xvh1qPo5.ucwkqCYKJE), kxZYhGkVQJLua9etdXa.JWHkDawd1X);
					num2 = 2;
					continue;
				case 6:
					if (!ServerHandler.XmtKXoZn6kBxN5t9mZv(ServerHandler.CXNNWEZ2F6Z8T7bMOpM(1403243363 << 2 ^ 206826934 ^ <Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_2b81ec8af5e04f369f0d06aea74493ed), Q8POwskhPbRg6Miq02Z.vVtkOn4NhN))
					{
						num2 = 5;
						continue;
					}
					goto IL_126;
				}
				Encryption.ServerThumbprint = ServerHandler.pjmQhCZGn4377pnmDNJ(ServerHandler.FetchCert().Result);
				num2 = 3;
				continue;
				IL_126:
				ServerHandler.Token = ServerHandler.RojU9PZPtuOC1iA0HcL(hIDAYxH6DWLHIthQgC.gSCeTtiku(2040783242 ^ 1699160712 ^ <Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_a886741aeab44e5eaceecb407afb698c), WHCmbFk0fxLAL0ZgsAU.GZvksvVFXM);
				num2 = 0;
				if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_d3b22718177c49568d74048e56d27602 == 0)
				{
					num2 = 0;
				}
			}
			IL_FD:
			return ServerHandler.IsValidToken().Result;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00005A7C File Offset: 0x00003C7C
		private static Task<string> FetchCert()
		{
			ServerHandler.<FetchCert>d__2 <FetchCert>d__;
			<FetchCert>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<FetchCert>d__.<>1__state = -1;
			<FetchCert>d__.<>t__builder.Start<ServerHandler.<FetchCert>d__2>(ref <FetchCert>d__);
			return <FetchCert>d__.<>t__builder.Task;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00005AC0 File Offset: 0x00003CC0
		private static Task<string> FetchEncryptionKey()
		{
			ServerHandler.<FetchEncryptionKey>d__3 <FetchEncryptionKey>d__;
			<FetchEncryptionKey>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<FetchEncryptionKey>d__.<>1__state = -1;
			<FetchEncryptionKey>d__.<>t__builder.Start<ServerHandler.<FetchEncryptionKey>d__3>(ref <FetchEncryptionKey>d__);
			return <FetchEncryptionKey>d__.<>t__builder.Task;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00005B04 File Offset: 0x00003D04
		private static Task<string> FetchDecryptionKey()
		{
			ServerHandler.<FetchDecryptionKey>d__4 <FetchDecryptionKey>d__;
			<FetchDecryptionKey>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<FetchDecryptionKey>d__.<>1__state = -1;
			<FetchDecryptionKey>d__.<>t__builder.Start<ServerHandler.<FetchDecryptionKey>d__4>(ref <FetchDecryptionKey>d__);
			return <FetchDecryptionKey>d__.<>t__builder.Task;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00005B48 File Offset: 0x00003D48
		public static Task<bool> IsValidToken()
		{
			ServerHandler.<IsValidToken>d__5 <IsValidToken>d__;
			<IsValidToken>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<IsValidToken>d__.<>1__state = -1;
			<IsValidToken>d__.<>t__builder.Start<ServerHandler.<IsValidToken>d__5>(ref <IsValidToken>d__);
			return <IsValidToken>d__.<>t__builder.Task;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00005B8C File Offset: 0x00003D8C
		public static Task<string> GetClient()
		{
			ServerHandler.<GetClient>d__6 <GetClient>d__;
			<GetClient>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetClient>d__.<>1__state = -1;
			<GetClient>d__.<>t__builder.Start<ServerHandler.<GetClient>d__6>(ref <GetClient>d__);
			return <GetClient>d__.<>t__builder.Task;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00005BD0 File Offset: 0x00003DD0
		public ServerHandler()
		{
			ServerHandler.jC3953ZuvRk2koqlQ1p();
			ServerHandler.oYeFhGZxEvC9VdoRAq6();
			base..ctor();
			int num = 0;
			if (<Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_9ad36fa8304947da8c6d258c7ab0aaf5 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00005C34 File Offset: 0x00003E34
		// Note: this type is marked as 'beforefieldinit'.
		static ServerHandler()
		{
			ServerHandler.eDx40pZSvXdf9ak6U5P();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00005C44 File Offset: 0x00003E44
		internal static object CXNNWEZ2F6Z8T7bMOpM(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00005C58 File Offset: 0x00003E58
		internal static bool XmtKXoZn6kBxN5t9mZv(object A_0, object A_1)
		{
			return Q8POwskhPbRg6Miq02Z.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00005C70 File Offset: 0x00003E70
		internal static object BJKu3ZZ9G7t7Q45AMVd(object A_0)
		{
			return cnfpx8kpBc0Xvh1qPo5.bHC8kRmMET(A_0);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00005C84 File Offset: 0x00003E84
		internal static void Y0ZU94ZcKQWao7gkkyQ(object A_0, object A_1)
		{
			kxZYhGkVQJLua9etdXa.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00005C9C File Offset: 0x00003E9C
		internal static object RojU9PZPtuOC1iA0HcL(object A_0, object A_1)
		{
			return WHCmbFk0fxLAL0ZgsAU.bHC8kRmMET(A_0, A_1);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005CB4 File Offset: 0x00003EB4
		internal static object pjmQhCZGn4377pnmDNJ(object A_0)
		{
			return EncryptUtils.FromBase64(A_0);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00005CC8 File Offset: 0x00003EC8
		internal static bool jDlgPkZFyCnZwcXHV3f()
		{
			return ServerHandler.W6ESYqZZhjYDQjthpn2 == null;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00005CDC File Offset: 0x00003EDC
		internal static ServerHandler V8vbEyZldSGddvZlSBg()
		{
			return ServerHandler.W6ESYqZZhjYDQjthpn2;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005CEC File Offset: 0x00003EEC
		internal static void jC3953ZuvRk2koqlQ1p()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00005CFC File Offset: 0x00003EFC
		internal static void oYeFhGZxEvC9VdoRAq6()
		{
			nHwRpygmi6xxZAssJn.JvcaFtwnsV();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00005D0C File Offset: 0x00003F0C
		internal static void eDx40pZSvXdf9ak6U5P()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000015 RID: 21
		private static object Token;

		// Token: 0x04000016 RID: 22
		private static object W6ESYqZZhjYDQjthpn2;

		// Token: 0x02000009 RID: 9
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x06000096 RID: 150 RVA: 0x00006700 File Offset: 0x00004900
			// Note: this type is marked as 'beforefieldinit'.
			static <>O()
			{
				ServerHandler.<>O.aDyufMZIX68hFpLfm2k();
			}

			// Token: 0x06000097 RID: 151 RVA: 0x00006710 File Offset: 0x00004910
			internal static void aDyufMZIX68hFpLfm2k()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000017 RID: 23
			[Nullable(new byte[]
			{
				0,
				1,
				2,
				2
			})]
			public static Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool> <0>__ValidateServerCertificate;
		}
	}
}
