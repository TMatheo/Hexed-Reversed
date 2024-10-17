using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop
{
	// Token: 0x02000003 RID: 3
	public class GetReady
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002F8C File Offset: 0x0000118C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002F9C File Offset: 0x0000119C
		public static Version UnityVersion { get; private set; }

		// Token: 0x0600003A RID: 58 RVA: 0x00002FAC File Offset: 0x000011AC
		public static void Create(string UnityPlayerPath)
		{
			int num = 9;
			for (;;)
			{
				int num2 = num;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				FileVersionInfo fileVersionInfo;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_DF;
					case 2:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 3);
						num2 = 13;
						continue;
					case 3:
						defaultInterpolatedStringHandler.AppendFormatted<int>(GetReady.lDoyk2Cc29snHwguUf1(fileVersionInfo, QTHFXTAZRcODfhg7snJ.GPZAow0yjh));
						num2 = 5;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d1f9cbcd89d6464f81f56a1119f034c6 == 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					case 4:
						goto IL_1FF;
					case 5:
						return;
					case 6:
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, GetReady.RLqK4hCNiGoUPQDQswc(-126702131 << 3 ^ -1052979103 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5f6b46e73a464a41b29ca79bf0f3b8f9), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						num2 = 10;
						continue;
					case 7:
						GetReady.yd8egYCu5HFbgVDEZET(GetReady.RLqK4hCNiGoUPQDQswc(1170670504 ^ 2102423062 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3cdc0c80f3644c499e0bcd7810be1cee));
						num2 = 5;
						continue;
					case 8:
						if (fileVersionInfo == null)
						{
							goto Block_7;
						}
						GetReady.VQ0sofCL2scr9TyEDPH(new Version(GetReady.gaQngOCEWlCfndGn6nE(fileVersionInfo, dZka5XArmBuiU3qaWBm.SX3ADWhqnd), GetReady.lDoyk2Cc29snHwguUf1(fileVersionInfo, QTHFXTAZRcODfhg7snJ.GPZAow0yjh), GetReady.DTdnGnC6NenKbrbN0jF(fileVersionInfo, E0DvAOAb0lWL4EMkAd1.mSWAf3nHC6)));
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_61a3825996b24609815f6b482bf680d9 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 9:
						goto IL_C4;
					case 10:
						defaultInterpolatedStringHandler.AppendFormatted<int>(GetReady.DTdnGnC6NenKbrbN0jF(fileVersionInfo, E0DvAOAb0lWL4EMkAd1.mSWAf3nHC6));
						num2 = 4;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_48b9993e573d4d08a64ac27c515a32b9 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 11:
						defaultInterpolatedStringHandler.AppendFormatted<int>(GetReady.gaQngOCEWlCfndGn6nE(fileVersionInfo, dZka5XArmBuiU3qaWBm.SX3ADWhqnd));
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b3f1fcfa11104bd49a7f00386d38b4f4 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 12:
						return;
					case 13:
						goto IL_25E;
					}
					UnityVersionHandler.RecalculateHandlers();
					num2 = 2;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_37633ff27b934257920d0d03faf0bd54 != 0)
					{
						num2 = 0;
					}
				}
				IL_C4:
				fileVersionInfo = NSN3k1AJAxBmHtKkJgf.i2IAUFsOOC(UnityPlayerPath, NSN3k1AJAxBmHtKkJgf.g2NAWl9GM6);
				num = 8;
				continue;
				IL_DF:
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, GetReady.RLqK4hCNiGoUPQDQswc(~445573850 ^ -368468599 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				num = 3;
				continue;
				IL_1FF:
				GetReady.HxZGoGC79ALvVEYDXV3(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
				num = 12;
				continue;
				Block_7:
				num = 7;
				continue;
				IL_25E:
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, GetReady.RLqK4hCNiGoUPQDQswc(-563509933 + 1953254144 ^ 98600733 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2210d7ca22c24335b32d80ca3ef84b8e), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				num = 11;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003254 File Offset: 0x00001454
		public GetReady()
		{
			GetReady.UnPmvfCRFrYSqujHQO0();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6b13daaa4cb24d0bac4f6e72da052370 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000032B8 File Offset: 0x000014B8
		// Note: this type is marked as 'beforefieldinit'.
		static GetReady()
		{
			GetReady.D4LpG8CkZXIe8x9sXBP();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000032C8 File Offset: 0x000014C8
		internal static object RLqK4hCNiGoUPQDQswc(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000032DC File Offset: 0x000014DC
		internal static void yd8egYCu5HFbgVDEZET(object A_0)
		{
			Logger.LogError(A_0);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000032F0 File Offset: 0x000014F0
		internal static int gaQngOCEWlCfndGn6nE(object A_0, object A_1)
		{
			return dZka5XArmBuiU3qaWBm.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003308 File Offset: 0x00001508
		internal static int lDoyk2Cc29snHwguUf1(object A_0, object A_1)
		{
			return QTHFXTAZRcODfhg7snJ.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003320 File Offset: 0x00001520
		internal static int DTdnGnC6NenKbrbN0jF(object A_0, object A_1)
		{
			return E0DvAOAb0lWL4EMkAd1.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003338 File Offset: 0x00001538
		internal static void VQ0sofCL2scr9TyEDPH(object A_0)
		{
			GetReady.UnityVersion = A_0;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000334C File Offset: 0x0000154C
		internal static void HxZGoGC79ALvVEYDXV3(object A_0)
		{
			Logger.Log(A_0);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003360 File Offset: 0x00001560
		internal static bool zDO3AdC8yhUVojJdG8H()
		{
			return GetReady.aOSMn1ChXblwNMXEaAM == null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003374 File Offset: 0x00001574
		internal static GetReady Tx4lxGC0SGwYO1e866A()
		{
			return GetReady.aOSMn1ChXblwNMXEaAM;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003384 File Offset: 0x00001584
		internal static void UnPmvfCRFrYSqujHQO0()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003394 File Offset: 0x00001594
		internal static void D4LpG8CkZXIe8x9sXBP()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000004 RID: 4
		private static GetReady aOSMn1ChXblwNMXEaAM;
	}
}
