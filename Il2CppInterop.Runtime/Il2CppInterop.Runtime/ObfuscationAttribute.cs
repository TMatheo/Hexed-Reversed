using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

// Token: 0x02000134 RID: 308
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
public sealed class ObfuscationAttribute : Attribute
{
	// Token: 0x170004E3 RID: 1251
	// (get) Token: 0x06000D67 RID: 3431 RVA: 0x00028714 File Offset: 0x00026914
	// (set) Token: 0x06000D68 RID: 3432 RVA: 0x00028724 File Offset: 0x00026924
	public bool ApplyToMembers
	{
		get
		{
			return this.m_applyToMembers;
		}
		set
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					this.m_applyToMembers = value;
					num2 = 0;
					if (!ObfuscationAttribute.uWshFE12DMeGfhPdQx7())
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}
	}

	// Token: 0x170004E4 RID: 1252
	// (get) Token: 0x06000D69 RID: 3433 RVA: 0x00028780 File Offset: 0x00026980
	// (set) Token: 0x06000D6A RID: 3434 RVA: 0x00028790 File Offset: 0x00026990
	public bool Exclude
	{
		get
		{
			return this.m_exclude;
		}
		set
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					this.m_exclude = value;
					num2 = 0;
					if (ObfuscationAttribute.Y30Q941HIyeohiTMqFa() != null)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}
	}

	// Token: 0x170004E5 RID: 1253
	// (get) Token: 0x06000D6B RID: 3435 RVA: 0x000287EC File Offset: 0x000269EC
	// (set) Token: 0x06000D6C RID: 3436 RVA: 0x000287FC File Offset: 0x000269FC
	public string Feature
	{
		get
		{
			return this.m_feature;
		}
		set
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					this.m_feature = value;
					num2 = 0;
					if (!ObfuscationAttribute.uWshFE12DMeGfhPdQx7())
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	// Token: 0x170004E6 RID: 1254
	// (get) Token: 0x06000D6D RID: 3437 RVA: 0x00028858 File Offset: 0x00026A58
	// (set) Token: 0x06000D6E RID: 3438 RVA: 0x00028868 File Offset: 0x00026A68
	public bool StripAfterObfuscation
	{
		get
		{
			return this.m_strip;
		}
		set
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					this.m_strip = value;
					num2 = 0;
					if (!ObfuscationAttribute.uWshFE12DMeGfhPdQx7())
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	// Token: 0x06000D6F RID: 3439 RVA: 0x000288C4 File Offset: 0x00026AC4
	public ObfuscationAttribute()
	{
		ObfuscationAttribute.yfOYad1hNDPWtMoeEGR();
		ObfuscationAttribute.cWj2yq1OkGj6UjaAFce();
		this.m_applyToMembers = true;
		this.m_exclude = true;
		this.m_feature = hIDAYxH6DWLHIthQgC.gSCeTtiku(407862330 ^ 1124214615 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ce8abd079f9447b3bade260ffc64f0b8);
		this.m_strip = true;
		base..ctor();
		int num = 0;
		if (!true)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			return;
		}
	}

	// Token: 0x06000D70 RID: 3440 RVA: 0x0002896C File Offset: 0x00026B6C
	// Note: this type is marked as 'beforefieldinit'.
	static ObfuscationAttribute()
	{
		hIDAYxH6DWLHIthQgC.zSLipEDdx();
	}

	// Token: 0x06000D71 RID: 3441 RVA: 0x0002897C File Offset: 0x00026B7C
	internal static bool uWshFE12DMeGfhPdQx7()
	{
		return ObfuscationAttribute.OcxdMq1k8pBuEYVsIHC == null;
	}

	// Token: 0x06000D72 RID: 3442 RVA: 0x00028990 File Offset: 0x00026B90
	internal static ObfuscationAttribute Y30Q941HIyeohiTMqFa()
	{
		return ObfuscationAttribute.OcxdMq1k8pBuEYVsIHC;
	}

	// Token: 0x06000D73 RID: 3443 RVA: 0x000289A0 File Offset: 0x00026BA0
	internal static void yfOYad1hNDPWtMoeEGR()
	{
		hIDAYxH6DWLHIthQgC.oDuBOTgYK();
	}

	// Token: 0x06000D74 RID: 3444 RVA: 0x000289B0 File Offset: 0x00026BB0
	internal static void cWj2yq1OkGj6UjaAFce()
	{
		nHwRpygmi6xxZAssJn.EmlEpH4Phw();
	}

	// Token: 0x04000993 RID: 2451
	private bool m_applyToMembers;

	// Token: 0x04000994 RID: 2452
	private bool m_exclude;

	// Token: 0x04000995 RID: 2453
	private string m_feature;

	// Token: 0x04000996 RID: 2454
	private bool m_strip;

	// Token: 0x04000997 RID: 2455
	internal static ObfuscationAttribute OcxdMq1k8pBuEYVsIHC;
}
