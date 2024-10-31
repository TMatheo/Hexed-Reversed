using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.PropertyInfo
{
	// Token: 0x02000046 RID: 70
	public interface INativePropertyInfoStructHandler : INativeStructHandler
	{
		// Token: 0x060002EE RID: 750
		INativePropertyInfoStruct CreateNewStruct();

		// Token: 0x060002EF RID: 751
		unsafe INativePropertyInfoStruct Wrap(Il2CppPropertyInfo* propertyInfoPointer);
	}
}
