using System;

namespace Il2CppInterop.Runtime.Runtime
{
	// Token: 0x02000033 RID: 51
	public struct Il2CppReflectionMethod
	{
		// Token: 0x040000D1 RID: 209
		public Il2CppObject _object;

		// Token: 0x040000D2 RID: 210
		public unsafe Il2CppMethodInfo* method;

		// Token: 0x040000D3 RID: 211
		public unsafe Il2CppString* name;

		// Token: 0x040000D4 RID: 212
		public IntPtr reftype;
	}
}
