using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x0200005E RID: 94
	public interface INativeMethodInfoStructHandler : INativeStructHandler
	{
		// Token: 0x060003BB RID: 955
		INativeMethodInfoStruct CreateNewStruct();

		// Token: 0x060003BC RID: 956
		unsafe INativeMethodInfoStruct Wrap(Il2CppMethodInfo* methodPointer);
	}
}
