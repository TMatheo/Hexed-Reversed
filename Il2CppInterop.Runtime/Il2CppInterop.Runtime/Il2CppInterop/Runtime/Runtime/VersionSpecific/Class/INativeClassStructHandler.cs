using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x02000109 RID: 265
	public interface INativeClassStructHandler : INativeStructHandler
	{
		// Token: 0x06000BDD RID: 3037
		INativeClassStruct CreateNewStruct(int vTableSlots);

		// Token: 0x06000BDE RID: 3038
		unsafe INativeClassStruct Wrap(Il2CppClass* classPointer);
	}
}
