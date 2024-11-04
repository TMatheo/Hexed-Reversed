using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

// Token: 0x02000069 RID: 105
internal class Class50
{
	// Token: 0x0600033C RID: 828 RVA: 0x00010DE8 File Offset: 0x0000EFE8
	public static void Init()
	{
		if (File.Exists(Class141.string_0 + "\\Assets\\ExternalConsole.exe"))
		{
			Console.SetOut(new Class50.Class51());
			Process.Start(Class141.string_0 + "\\Assets\\ExternalConsole.exe");
			IPAddress address = Dns.GetHostEntry("localhost").AddressList[0];
			TcpClient tcpClient = new TcpClient();
			tcpClient.Connect(address, 666);
			Class50.networkStream_0 = tcpClient.GetStream();
			return;
		}
	}

	// Token: 0x0600033D RID: 829 RVA: 0x00010E5C File Offset: 0x0000F05C
	public static void writeMessage(string message)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(message);
		if (Class50.networkStream_0 != null)
		{
			Class50.networkStream_0.Write(bytes, 0, bytes.Length);
		}
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00002E53 File Offset: 0x00001053
	internal static bool nLuC4CnMMoQJkoPcNF4()
	{
		return Class50.dOsWB6nuj1701R8hpf1 == null;
	}

	// Token: 0x0400016F RID: 367
	private static NetworkStream networkStream_0;

	// Token: 0x04000170 RID: 368
	internal static Class50 dOsWB6nuj1701R8hpf1;

	// Token: 0x0200006A RID: 106
	public class Class51 : TextWriter
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00002E5D File Offset: 0x0000105D
		public override Encoding Encoding
		{
			get
			{
				return Encoding.ASCII;
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002E64 File Offset: 0x00001064
		public override void Write(string value)
		{
			Class50.writeMessage(value);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002E6C File Offset: 0x0000106C
		internal static bool l3acaXWApkclVdsKPRS()
		{
			return Class50.Class51.IWd26XWPpArtxhwfXQy == null;
		}

		// Token: 0x04000171 RID: 369
		private static Class50.Class51 IWd26XWPpArtxhwfXQy;
	}
}
