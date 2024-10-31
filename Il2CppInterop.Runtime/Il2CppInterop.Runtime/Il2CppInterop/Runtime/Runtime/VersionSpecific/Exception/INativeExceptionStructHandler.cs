using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Exception
{
	// Token: 0x020000AE RID: 174
	public interface INativeExceptionStructHandler : INativeStructHandler
	{
		// Token: 0x06000652 RID: 1618
		INativeExceptionStruct CreateNewStruct();

		// Token: 0x06000653 RID: 1619
		unsafe INativeExceptionStruct Wrap(Il2CppException* exceptionPointer);
	}
}
