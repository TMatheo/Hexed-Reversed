using System;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Assembly
{
	// Token: 0x0200011B RID: 283
	public interface INativeAssemblyStruct : INativeStruct
	{
		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000C7A RID: 3194
		unsafe Il2CppAssembly* AssemblyPointer { get; }

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000C7B RID: 3195
		unsafe ref Il2CppImage* Image { get; }

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000C7C RID: 3196
		INativeAssemblyNameStruct Name { get; }
	}
}
