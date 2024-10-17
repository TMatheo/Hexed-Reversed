using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x02000094 RID: 148
	public interface INativeImageStructHandler : INativeStructHandler
	{
		// Token: 0x0600059A RID: 1434
		INativeImageStruct CreateNewStruct();

		// Token: 0x0600059B RID: 1435
		unsafe INativeImageStruct Wrap(Il2CppImage* imagePointer);
	}
}
