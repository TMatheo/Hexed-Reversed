using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x0200005C RID: 92
	public interface INativeMethodInfoStructHandler : INativeStructHandler
	{
		// Token: 0x06000398 RID: 920
		INativeMethodInfoStruct CreateNewStruct();

		// Token: 0x06000399 RID: 921
		unsafe INativeMethodInfoStruct Wrap(Il2CppMethodInfo* methodPointer);
	}
}
