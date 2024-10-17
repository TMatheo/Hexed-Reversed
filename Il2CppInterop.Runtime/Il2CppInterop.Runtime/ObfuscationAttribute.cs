using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

// Token: 0x02000137 RID: 311
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
public sealed class ObfuscationAttribute : Attribute
{
	// Token: 0x170004E3 RID: 1251
	// (get) Token: 0x06000D8F RID: 3471 RVA: 0x0002944C File Offset: 0x0002764C
	// (set) Token: 0x06000D90 RID: 3472 RVA: 0x0002945C File Offset: 0x0002765C
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
				default:
					return;
				case 1:
					this.m_applyToMembers = value;
					num2 = 0;
					if (!ObfuscationAttribute.wFCAmXe2lC0nZFpXThb())
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	// Token: 0x170004E4 RID: 1252
	// (get) Token: 0x06000D91 RID: 3473 RVA: 0x000294B8 File Offset: 0x000276B8
	// (set) Token: 0x06000D92 RID: 3474 RVA: 0x000294C8 File Offset: 0x000276C8
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
				default:
					return;
				case 1:
					this.m_exclude = value;
					num2 = 0;
					if (ObfuscationAttribute.uQXNyXeygTTynr6bCx8() == null)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	// Token: 0x170004E5 RID: 1253
	// (get) Token: 0x06000D93 RID: 3475 RVA: 0x00029524 File Offset: 0x00027724
	// (set) Token: 0x06000D94 RID: 3476 RVA: 0x00029534 File Offset: 0x00027734
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
					if (ObfuscationAttribute.uQXNyXeygTTynr6bCx8() == null)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	// Token: 0x170004E6 RID: 1254
	// (get) Token: 0x06000D95 RID: 3477 RVA: 0x00029590 File Offset: 0x00027790
	// (set) Token: 0x06000D96 RID: 3478 RVA: 0x000295A0 File Offset: 0x000277A0
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
					if (ObfuscationAttribute.uQXNyXeygTTynr6bCx8() == null)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	// Token: 0x06000D97 RID: 3479 RVA: 0x000295FC File Offset: 0x000277FC
	public ObfuscationAttribute()
	{
		ObfuscationAttribute.hwSR5beSROsNo3nnWUL();
		nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		this.m_applyToMembers = true;
		this.m_exclude = true;
		this.m_feature = ObfuscationAttribute.OR0cMgega0eHkbdYABg(2082337970 - -1918242524 ^ -1671688348 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9f56599a6a304695b6cfc284bd7d7c9a);
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

	// Token: 0x06000D98 RID: 3480 RVA: 0x000296A8 File Offset: 0x000278A8
	// Note: this type is marked as 'beforefieldinit'.
	static ObfuscationAttribute()
	{
		ObfuscationAttribute.SVAnmqelYMeCw6CyPDx();
	}

	// Token: 0x06000D99 RID: 3481 RVA: 0x000296B8 File Offset: 0x000278B8
	internal static bool wFCAmXe2lC0nZFpXThb()
	{
		return ObfuscationAttribute.meaGwJeQ3mgamrPTQID == null;
	}

	// Token: 0x06000D9A RID: 3482 RVA: 0x000296CC File Offset: 0x000278CC
	internal static ObfuscationAttribute uQXNyXeygTTynr6bCx8()
	{
		return ObfuscationAttribute.meaGwJeQ3mgamrPTQID;
	}

	// Token: 0x06000D9B RID: 3483 RVA: 0x000296DC File Offset: 0x000278DC
	internal static void hwSR5beSROsNo3nnWUL()
	{
		hIDAYxH6DWLHIthQgC.oDuBOTgYK();
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x000296EC File Offset: 0x000278EC
	internal static object OR0cMgega0eHkbdYABg(int \u0020)
	{
		return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x00029700 File Offset: 0x00027900
	internal static void SVAnmqelYMeCw6CyPDx()
	{
		hIDAYxH6DWLHIthQgC.zSLipEDdx();
	}

	// Token: 0x040009A0 RID: 2464
	private bool m_applyToMembers;

	// Token: 0x040009A1 RID: 2465
	private bool m_exclude;

	// Token: 0x040009A2 RID: 2466
	private string m_feature;

	// Token: 0x040009A3 RID: 2467
	private bool m_strip;

	// Token: 0x040009A4 RID: 2468
	private static ObfuscationAttribute meaGwJeQ3mgamrPTQID;
}
