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
		// Token: 0x0600005D RID: 93 RVA: 0x00004FB0 File Offset: 0x000031B0
		public HexedCheat()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.dxI7NE9hn1();
			base..ctor();
			int num = 0;
			if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_5ae564a9ecfe4f169a22d95bbec1499a != 0)
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
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00005010 File Offset: 0x00003210
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00005018 File Offset: 0x00003218
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
					default:
						return;
					case 1:
						this.<Identifier>k__BackingField = value;
						num2 = 0;
						if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_d1cb4aaf4fc045f5839300511ab1de3f != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00005070 File Offset: 0x00003270
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00005078 File Offset: 0x00003278
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
					default:
						return;
					case 1:
						this.<Path>k__BackingField = value;
						num2 = 0;
						if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_b1083c87447b4a5f88a05d024fae2975 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000050D0 File Offset: 0x000032D0
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000050D8 File Offset: 0x000032D8
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
					default:
						return;
					case 1:
						this.<Assembly>k__BackingField = value;
						num2 = 0;
						if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_afc1c0a1256744ca83837550f557c751 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00005130 File Offset: 0x00003330
		internal void Initialize(string identifier, Assembly assembly, string path)
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					this.Path = path;
					num2 = 0;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_9b9e897d8842480382c741acc7c5e177 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 2:
					this.Assembly = assembly;
					num2 = 0;
					if (<Module>{39544666-5886-4660-82c2-b5d6ee1bb8df}.m_b71752828a4840c087bf361f4e965877.m_540582763ba947fe9423f9dab666d323 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					this.Identifier = identifier;
					num2 = 2;
					break;
				}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000051C8 File Offset: 0x000033C8
		public virtual void OnLoad(string[] args = null)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000051CC File Offset: 0x000033CC
		public virtual void OnUpdate()
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000051D0 File Offset: 0x000033D0
		public virtual void OnLateUpdate()
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000051D4 File Offset: 0x000033D4
		public virtual void OnFixedUpdate()
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000051D8 File Offset: 0x000033D8
		public virtual void OnGUI()
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000051DC File Offset: 0x000033DC
		public virtual void OnApplicationQuit()
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000051E0 File Offset: 0x000033E0
		internal static bool KTf1cLkmH3no9TD2P2r()
		{
			return HexedCheat.GHEP9bkhGkwB4Wf6Jf8 == null;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000051EC File Offset: 0x000033EC
		internal static HexedCheat dWcetKkphL1WxcM4HOC()
		{
			return HexedCheat.GHEP9bkhGkwB4Wf6Jf8;
		}

		// Token: 0x04000024 RID: 36
		private static HexedCheat GHEP9bkhGkwB4Wf6Jf8;
	}
}
