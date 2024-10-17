using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

// Token: 0x02000015 RID: 21
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
public sealed class ObfuscationAttribute : Attribute
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600006D RID: 109 RVA: 0x0000528C File Offset: 0x0000348C
	// (set) Token: 0x0600006E RID: 110 RVA: 0x00005294 File Offset: 0x00003494
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
					if (global::ObfuscationAttribute.SU60Tc2lC3khYGRIYur() != null)
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

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600006F RID: 111 RVA: 0x000052E8 File Offset: 0x000034E8
	// (set) Token: 0x06000070 RID: 112 RVA: 0x000052F0 File Offset: 0x000034F0
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
					if (!global::ObfuscationAttribute.SUtm5i2ne9vlg3p4gUO())
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000071 RID: 113 RVA: 0x00005344 File Offset: 0x00003544
	// (set) Token: 0x06000072 RID: 114 RVA: 0x0000534C File Offset: 0x0000354C
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
					if (global::ObfuscationAttribute.SU60Tc2lC3khYGRIYur() == null)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000073 RID: 115 RVA: 0x000053A0 File Offset: 0x000035A0
	// (set) Token: 0x06000074 RID: 116 RVA: 0x000053A8 File Offset: 0x000035A8
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
					if (!global::ObfuscationAttribute.SUtm5i2ne9vlg3p4gUO())
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	// Token: 0x06000075 RID: 117 RVA: 0x000053FC File Offset: 0x000035FC
	public ObfuscationAttribute()
	{
		hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		nHwRpygmi6xxZAssJn.UoDdI5CpWg();
		this.m_applyToMembers = true;
		this.m_exclude = true;
		this.m_feature = hIDAYxH6DWLHIthQgC.gSCeTtiku(--120282258 ^ 2066840512 ^ <Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_98fd8e694684493ba2ae034d20be4be9);
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

	// Token: 0x06000076 RID: 118 RVA: 0x0000549C File Offset: 0x0000369C
	internal static bool SUtm5i2ne9vlg3p4gUO()
	{
		return global::ObfuscationAttribute.Dj9jPK2tp8pRMXpk5b7 == null;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x000054A8 File Offset: 0x000036A8
	internal static global::ObfuscationAttribute SU60Tc2lC3khYGRIYur()
	{
		return global::ObfuscationAttribute.Dj9jPK2tp8pRMXpk5b7;
	}

	// Token: 0x04000025 RID: 37
	private bool m_applyToMembers;

	// Token: 0x04000026 RID: 38
	private bool m_exclude;

	// Token: 0x04000027 RID: 39
	private string m_feature;

	// Token: 0x04000028 RID: 40
	private bool m_strip;

	// Token: 0x04000029 RID: 41
	internal static global::ObfuscationAttribute Dj9jPK2tp8pRMXpk5b7;
}
