using System;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Assembly
{
	// Token: 0x02000119 RID: 281
	public interface INativeAssemblyStruct : INativeStruct
	{
		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000C55 RID: 3157
		unsafe Il2CppAssembly* AssemblyPointer { get; }

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000C56 RID: 3158
		unsafe ref Il2CppImage* Image { get; }

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000C57 RID: 3159
		INativeAssemblyNameStruct Name { get; }
	}
}
