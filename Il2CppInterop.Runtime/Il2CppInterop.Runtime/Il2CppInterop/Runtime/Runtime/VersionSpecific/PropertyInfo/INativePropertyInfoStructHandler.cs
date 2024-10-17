using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.PropertyInfo
{
	// Token: 0x02000048 RID: 72
	public interface INativePropertyInfoStructHandler : INativeStructHandler
	{
		// Token: 0x06000314 RID: 788
		INativePropertyInfoStruct CreateNewStruct();

		// Token: 0x06000315 RID: 789
		unsafe INativePropertyInfoStruct Wrap(Il2CppPropertyInfo* propertyInfoPointer);
	}
}
