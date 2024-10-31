using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

// Token: 0x02000015 RID: 21
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
public sealed class ObfuscationAttribute : Attribute
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600006D RID: 109 RVA: 0x00005414 File Offset: 0x00003614
	// (set) Token: 0x0600006E RID: 110 RVA: 0x0000541C File Offset: 0x0000361C
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
					if (!global::ObfuscationAttribute.Gs68GZkUpNhka51utQr())
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
	// (get) Token: 0x0600006F RID: 111 RVA: 0x00005470 File Offset: 0x00003670
	// (set) Token: 0x06000070 RID: 112 RVA: 0x00005478 File Offset: 0x00003678
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
					if (global::ObfuscationAttribute.vVyy0Qkf3fwXH0n6Uwr() == null)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000071 RID: 113 RVA: 0x000054CC File Offset: 0x000036CC
	// (set) Token: 0x06000072 RID: 114 RVA: 0x000054D4 File Offset: 0x000036D4
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
					if (global::ObfuscationAttribute.Gs68GZkUpNhka51utQr())
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000073 RID: 115 RVA: 0x00005528 File Offset: 0x00003728
	// (set) Token: 0x06000074 RID: 116 RVA: 0x00005530 File Offset: 0x00003730
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
				case 1:
					this.m_strip = value;
					num2 = 0;
					if (global::ObfuscationAttribute.vVyy0Qkf3fwXH0n6Uwr() == null)
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

	// Token: 0x06000075 RID: 117 RVA: 0x00005584 File Offset: 0x00003784
	public ObfuscationAttribute()
	{
		hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		nHwRpygmi6xxZAssJn.dxI7NE9hn1();
		this.m_applyToMembers = true;
		this.m_exclude = true;
		this.m_feature = hIDAYxH6DWLHIthQgC.gSCeTtiku(711244972 ^ 931514114 ^ <Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_e987b181869c485d9a6dd6b754a96fff);
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

	// Token: 0x06000076 RID: 118 RVA: 0x00005624 File Offset: 0x00003824
	internal static bool Gs68GZkUpNhka51utQr()
	{
		return global::ObfuscationAttribute.LY7N4Bkg6q6mrdwn68R == null;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00005630 File Offset: 0x00003830
	internal static global::ObfuscationAttribute vVyy0Qkf3fwXH0n6Uwr()
	{
		return global::ObfuscationAttribute.LY7N4Bkg6q6mrdwn68R;
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
	internal static global::ObfuscationAttribute LY7N4Bkg6q6mrdwn68R;
}
