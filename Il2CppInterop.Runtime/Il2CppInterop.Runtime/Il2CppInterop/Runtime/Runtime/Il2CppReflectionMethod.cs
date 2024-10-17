using System;

namespace Il2CppInterop.Runtime.Runtime
{
	// Token: 0x02000035 RID: 53
	public struct Il2CppReflectionMethod
	{
		// Token: 0x040000DC RID: 220
		public Il2CppObject _object;

		// Token: 0x040000DD RID: 221
		public unsafe Il2CppMethodInfo* method;

		// Token: 0x040000DE RID: 222
		public unsafe Il2CppString* name;

		// Token: 0x040000DF RID: 223
		public IntPtr reftype;
	}
}
