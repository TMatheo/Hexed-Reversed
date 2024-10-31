using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Type
{
	// Token: 0x0200003C RID: 60
	public interface INativeTypeStructHandler : INativeStructHandler
	{
		// Token: 0x060002A5 RID: 677
		INativeTypeStruct CreateNewStruct();

		// Token: 0x060002A6 RID: 678
		unsafe INativeTypeStruct Wrap(Il2CppTypeStruct* typePointer);
	}
}
