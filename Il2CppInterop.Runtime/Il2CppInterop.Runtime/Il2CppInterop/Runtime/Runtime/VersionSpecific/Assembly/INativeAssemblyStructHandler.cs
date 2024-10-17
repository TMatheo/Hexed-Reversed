using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Assembly
{
	// Token: 0x0200011A RID: 282
	public interface INativeAssemblyStructHandler : INativeStructHandler
	{
		// Token: 0x06000C78 RID: 3192
		INativeAssemblyStruct CreateNewStruct();

		// Token: 0x06000C79 RID: 3193
		unsafe INativeAssemblyStruct Wrap(Il2CppAssembly* assemblyPointer);
	}
}
