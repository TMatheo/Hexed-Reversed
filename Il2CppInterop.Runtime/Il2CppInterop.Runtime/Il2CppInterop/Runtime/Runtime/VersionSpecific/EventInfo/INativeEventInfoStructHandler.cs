using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.EventInfo
{
	// Token: 0x020000B9 RID: 185
	public interface INativeEventInfoStructHandler : INativeStructHandler
	{
		// Token: 0x060006A6 RID: 1702
		INativeEventInfoStruct CreateNewStruct();

		// Token: 0x060006A7 RID: 1703
		unsafe INativeEventInfoStruct Wrap(Il2CppEventInfo* eventInfoPointer);
	}
}
