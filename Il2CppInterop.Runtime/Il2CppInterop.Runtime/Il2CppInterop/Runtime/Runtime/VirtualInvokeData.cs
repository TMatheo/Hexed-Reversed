using System;

namespace Il2CppInterop.Runtime.Runtime
{
	// Token: 0x0200002C RID: 44
	public struct VirtualInvokeData
	{
		// Token: 0x040000C0 RID: 192
		public IntPtr methodPtr;

		// Token: 0x040000C1 RID: 193
		public unsafe Il2CppMethodInfo* method;
	}
}
