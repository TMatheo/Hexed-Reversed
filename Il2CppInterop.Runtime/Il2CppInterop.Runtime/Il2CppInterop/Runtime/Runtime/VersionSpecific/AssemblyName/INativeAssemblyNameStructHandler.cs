using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName
{
	// Token: 0x02000125 RID: 293
	public interface INativeAssemblyNameStructHandler : INativeStructHandler
	{
		// Token: 0x06000CCE RID: 3278
		INativeAssemblyNameStruct CreateNewStruct();

		// Token: 0x06000CCF RID: 3279
		unsafe INativeAssemblyNameStruct Wrap(Il2CppAssemblyName* assemblyNamePointer);
	}
}
