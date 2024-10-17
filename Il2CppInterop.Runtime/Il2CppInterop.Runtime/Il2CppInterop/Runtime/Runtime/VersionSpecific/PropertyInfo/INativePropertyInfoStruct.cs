using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.PropertyInfo
{
	// Token: 0x02000049 RID: 73
	public interface INativePropertyInfoStruct : INativeStruct
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000316 RID: 790
		unsafe Il2CppPropertyInfo* PropertyInfoPointer { get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000317 RID: 791
		ref IntPtr Name { get; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000318 RID: 792
		unsafe ref Il2CppClass* Parent { get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000319 RID: 793
		unsafe ref Il2CppMethodInfo* Get { get; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600031A RID: 794
		unsafe ref Il2CppMethodInfo* Set { get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600031B RID: 795
		ref uint Attrs { get; }
	}
}
