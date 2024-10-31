using System;

namespace Il2CppInterop.Runtime.Runtime
{
	// Token: 0x0200002F RID: 47
	public struct Il2CppImageGlobalMetadata
	{
		// Token: 0x040000C6 RID: 198
		public int typeStart;

		// Token: 0x040000C7 RID: 199
		public int exportedTypeStart;

		// Token: 0x040000C8 RID: 200
		public int customAttributeStart;

		// Token: 0x040000C9 RID: 201
		public int entryPointIndex;

		// Token: 0x040000CA RID: 202
		public unsafe Il2CppImage* image;
	}
}
