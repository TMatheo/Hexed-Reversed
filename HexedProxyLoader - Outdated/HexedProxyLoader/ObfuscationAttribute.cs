using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

// Token: 0x02000012 RID: 18
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
public sealed class ObfuscationAttribute : Attribute
{
	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000110 RID: 272 RVA: 0x00009768 File Offset: 0x00007968
	// (set) Token: 0x06000111 RID: 273 RVA: 0x00009778 File Offset: 0x00007978
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
					if (ObfuscationAttribute.nKsdukFz2MYlRZDdmOS() == null)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000112 RID: 274 RVA: 0x000097D4 File Offset: 0x000079D4
	// (set) Token: 0x06000113 RID: 275 RVA: 0x000097E4 File Offset: 0x000079E4
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
					if (!ObfuscationAttribute.PERluEFrnOWTkZcQWMX())
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

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000114 RID: 276 RVA: 0x00009840 File Offset: 0x00007A40
	// (set) Token: 0x06000115 RID: 277 RVA: 0x00009850 File Offset: 0x00007A50
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
					if (ObfuscationAttribute.PERluEFrnOWTkZcQWMX())
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000116 RID: 278 RVA: 0x000098AC File Offset: 0x00007AAC
	// (set) Token: 0x06000117 RID: 279 RVA: 0x000098BC File Offset: 0x00007ABC
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
					if (!ObfuscationAttribute.PERluEFrnOWTkZcQWMX())
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00009918 File Offset: 0x00007B18
	public ObfuscationAttribute()
	{
		ObfuscationAttribute.Bdjbycl7TcKYD70uOkZ();
		ObfuscationAttribute.tvOG35l81qKTVYDFXNV();
		this.m_applyToMembers = true;
		this.m_exclude = true;
		this.m_feature = hIDAYxH6DWLHIthQgC.gSCeTtiku(1148712147 << 4 ^ 1972190285 ^ <Module>{260fc716-7ad5-4a28-8eeb-4047ba131927}.m_c7ec8c12e1304eb68ffe0858c140659c.m_139b0a866b8e4b56b67d29a6f8689f09);
		this.m_strip = true;
		base..ctor();
		int num = 0;
		if (!false)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			return;
		}
	}

	// Token: 0x06000119 RID: 281 RVA: 0x000099C4 File Offset: 0x00007BC4
	// Note: this type is marked as 'beforefieldinit'.
	static ObfuscationAttribute()
	{
		hIDAYxH6DWLHIthQgC.zSLipEDdx();
	}

	// Token: 0x0600011A RID: 282 RVA: 0x000099D4 File Offset: 0x00007BD4
	internal static bool PERluEFrnOWTkZcQWMX()
	{
		return ObfuscationAttribute.CHaSr5F6PBraW2gBYoE == null;
	}

	// Token: 0x0600011B RID: 283 RVA: 0x000099E8 File Offset: 0x00007BE8
	internal static ObfuscationAttribute nKsdukFz2MYlRZDdmOS()
	{
		return ObfuscationAttribute.CHaSr5F6PBraW2gBYoE;
	}

	// Token: 0x0600011C RID: 284 RVA: 0x000099F8 File Offset: 0x00007BF8
	internal static void Bdjbycl7TcKYD70uOkZ()
	{
		hIDAYxH6DWLHIthQgC.oDuBOTgYK();
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00009A08 File Offset: 0x00007C08
	internal static void tvOG35l81qKTVYDFXNV()
	{
		nHwRpygmi6xxZAssJn.JvcaFtwnsV();
	}

	// Token: 0x04000046 RID: 70
	private bool m_applyToMembers;

	// Token: 0x04000047 RID: 71
	private bool m_exclude;

	// Token: 0x04000048 RID: 72
	private string m_feature;

	// Token: 0x04000049 RID: 73
	private bool m_strip;

	// Token: 0x0400004A RID: 74
	private static ObfuscationAttribute CHaSr5F6PBraW2gBYoE;
}
