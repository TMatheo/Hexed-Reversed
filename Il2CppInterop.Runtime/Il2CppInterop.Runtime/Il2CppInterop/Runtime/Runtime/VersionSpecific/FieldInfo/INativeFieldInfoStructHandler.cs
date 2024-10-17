using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.FieldInfo
{
	// Token: 0x0200009F RID: 159
	public interface INativeFieldInfoStructHandler : INativeStructHandler
	{
		// Token: 0x060005E6 RID: 1510
		INativeFieldInfoStruct CreateNewStruct();

		// Token: 0x060005E7 RID: 1511
		unsafe INativeFieldInfoStruct Wrap(Il2CppFieldInfo* fieldInfoPointer);
	}
}
