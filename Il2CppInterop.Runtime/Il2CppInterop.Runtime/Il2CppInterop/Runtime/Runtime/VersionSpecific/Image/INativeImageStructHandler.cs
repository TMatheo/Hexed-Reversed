using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x02000092 RID: 146
	public interface INativeImageStructHandler : INativeStructHandler
	{
		// Token: 0x06000580 RID: 1408
		INativeImageStruct CreateNewStruct();

		// Token: 0x06000581 RID: 1409
		unsafe INativeImageStruct Wrap(Il2CppImage* imagePointer);
	}
}
