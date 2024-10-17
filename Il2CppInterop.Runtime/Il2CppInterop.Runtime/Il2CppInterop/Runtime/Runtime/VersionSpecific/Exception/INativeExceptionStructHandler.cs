using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Exception
{
	// Token: 0x020000B0 RID: 176
	public interface INativeExceptionStructHandler : INativeStructHandler
	{
		// Token: 0x0600066D RID: 1645
		INativeExceptionStruct CreateNewStruct();

		// Token: 0x0600066E RID: 1646
		unsafe INativeExceptionStruct Wrap(Il2CppException* exceptionPointer);
	}
}
