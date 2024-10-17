using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Type
{
	// Token: 0x0200003E RID: 62
	public interface INativeTypeStructHandler : INativeStructHandler
	{
		// Token: 0x060002C9 RID: 713
		INativeTypeStruct CreateNewStruct();

		// Token: 0x060002CA RID: 714
		unsafe INativeTypeStruct Wrap(Il2CppTypeStruct* typePointer);
	}
}
