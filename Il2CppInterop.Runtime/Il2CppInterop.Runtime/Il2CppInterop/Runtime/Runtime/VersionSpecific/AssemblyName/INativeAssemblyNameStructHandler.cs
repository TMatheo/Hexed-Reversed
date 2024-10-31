using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName
{
	// Token: 0x02000123 RID: 291
	public interface INativeAssemblyNameStructHandler : INativeStructHandler
	{
		// Token: 0x06000CAB RID: 3243
		INativeAssemblyNameStruct CreateNewStruct();

		// Token: 0x06000CAC RID: 3244
		unsafe INativeAssemblyNameStruct Wrap(Il2CppAssemblyName* assemblyNamePointer);
	}
}
