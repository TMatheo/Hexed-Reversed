using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Assembly
{
	// Token: 0x02000118 RID: 280
	public interface INativeAssemblyStructHandler : INativeStructHandler
	{
		// Token: 0x06000C53 RID: 3155
		INativeAssemblyStruct CreateNewStruct();

		// Token: 0x06000C54 RID: 3156
		unsafe INativeAssemblyStruct Wrap(Il2CppAssembly* assemblyPointer);
	}
}
