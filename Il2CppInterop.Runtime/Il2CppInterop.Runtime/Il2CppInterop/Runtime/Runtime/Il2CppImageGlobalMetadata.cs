using System;

namespace Il2CppInterop.Runtime.Runtime
{
	// Token: 0x02000031 RID: 49
	public struct Il2CppImageGlobalMetadata
	{
		// Token: 0x040000D1 RID: 209
		public int typeStart;

		// Token: 0x040000D2 RID: 210
		public int exportedTypeStart;

		// Token: 0x040000D3 RID: 211
		public int customAttributeStart;

		// Token: 0x040000D4 RID: 212
		public int entryPointIndex;

		// Token: 0x040000D5 RID: 213
		public unsafe Il2CppImage* image;
	}
}
