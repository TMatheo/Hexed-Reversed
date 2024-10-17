using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.EventInfo
{
	// Token: 0x020000BB RID: 187
	public interface INativeEventInfoStructHandler : INativeStructHandler
	{
		// Token: 0x060006C3 RID: 1731
		INativeEventInfoStruct CreateNewStruct();

		// Token: 0x060006C4 RID: 1732
		unsafe INativeEventInfoStruct Wrap(Il2CppEventInfo* eventInfoPointer);
	}
}
