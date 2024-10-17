using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace CoreRuntime.Interfaces
{
	// Token: 0x02000013 RID: 19
	public class HexedCheat
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00004DEC File Offset: 0x00002FEC
		public HexedCheat()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.UoDdI5CpWg();
			base..ctor();
			int num = 0;
			if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_ab54e6dff83042e185dfcab6f3cc1c05 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00004E4C File Offset: 0x0000304C
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00004E54 File Offset: 0x00003054
		public string Identifier
		{
			[CompilerGenerated]
			get
			{
				return this.<Identifier>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						this.<Identifier>k__BackingField = value;
						num2 = 0;
						if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_3ed9ef715f6845f1a81c32835cb199f2 == 0)
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

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00004EAC File Offset: 0x000030AC
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00004EB4 File Offset: 0x000030B4
		public string Path
		{
			[CompilerGenerated]
			get
			{
				return this.<Path>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						this.<Path>k__BackingField = value;
						num2 = 0;
						if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_446460a1dff54d64bbdb362324d22159 != 0)
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

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00004F0C File Offset: 0x0000310C
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00004F14 File Offset: 0x00003114
		public Assembly Assembly
		{
			[CompilerGenerated]
			get
			{
				return this.<Assembly>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						this.<Assembly>k__BackingField = value;
						num2 = 0;
						if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_214adb6fa07348f1907277a6a99ecb99 != 0)
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

		// Token: 0x06000064 RID: 100 RVA: 0x00004F6C File Offset: 0x0000316C
		internal void Initialize(string identifier, Assembly assembly, string path)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					this.Assembly = assembly;
					num2 = 0;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_a1159e767799409fa9c6ba86ba1418c8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					this.Identifier = identifier;
					num2 = 0;
					if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_65f8a3d6a5de4588a892575d6bdfaa57 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				}
				this.Path = path;
				num2 = 0;
				if (<Module>{ac036323-8bbe-4bc3-98ee-09be8d56c592}.m_f08175ccb47d47d4b92ca8027a0600b8.m_214adb6fa07348f1907277a6a99ecb99 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005018 File Offset: 0x00003218
		public virtual void OnLoad()
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000501C File Offset: 0x0000321C
		public virtual void OnUpdate()
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005020 File Offset: 0x00003220
		public virtual void OnLateUpdate()
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00005024 File Offset: 0x00003224
		public virtual void OnFixedUpdate()
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00005028 File Offset: 0x00003228
		public virtual void OnGUI()
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000502C File Offset: 0x0000322C
		public virtual void OnApplicationQuit()
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00005030 File Offset: 0x00003230
		internal static bool ueDRGD2UDUSf61hhrCQ()
		{
			return HexedCheat.Gx6ibJ2jpsBplGbMe9W == null;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000503C File Offset: 0x0000323C
		internal static HexedCheat F7DfFt2WYBp6lHjs6S4()
		{
			return HexedCheat.Gx6ibJ2jpsBplGbMe9W;
		}

		// Token: 0x04000024 RID: 36
		internal static HexedCheat Gx6ibJ2jpsBplGbMe9W;
	}
}
