using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.FieldInfo
{
	// Token: 0x0200009D RID: 157
	public interface INativeFieldInfoStructHandler : INativeStructHandler
	{
		// Token: 0x060005CE RID: 1486
		INativeFieldInfoStruct CreateNewStruct();

		// Token: 0x060005CF RID: 1487
		unsafe INativeFieldInfoStruct Wrap(Il2CppFieldInfo* fieldInfoPointer);
	}
}
