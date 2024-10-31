using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x02000107 RID: 263
	public interface INativeClassStructHandler : INativeStructHandler
	{
		// Token: 0x06000BB9 RID: 3001
		INativeClassStruct CreateNewStruct(int vTableSlots);

		// Token: 0x06000BBA RID: 3002
		unsafe INativeClassStruct Wrap(Il2CppClass* classPointer);
	}
}
