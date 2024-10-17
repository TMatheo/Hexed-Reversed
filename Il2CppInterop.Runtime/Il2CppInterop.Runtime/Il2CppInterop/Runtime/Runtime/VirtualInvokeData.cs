using System;

namespace Il2CppInterop.Runtime.Runtime
{
	// Token: 0x0200002E RID: 46
	public struct VirtualInvokeData
	{
		// Token: 0x040000CB RID: 203
		public IntPtr methodPtr;

		// Token: 0x040000CC RID: 204
		public unsafe Il2CppMethodInfo* method;
	}
}
