using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.PropertyInfo
{
	// Token: 0x02000047 RID: 71
	public interface INativePropertyInfoStruct : INativeStruct
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060002F0 RID: 752
		unsafe Il2CppPropertyInfo* PropertyInfoPointer { get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060002F1 RID: 753
		ref IntPtr Name { get; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060002F2 RID: 754
		unsafe ref Il2CppClass* Parent { get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060002F3 RID: 755
		unsafe ref Il2CppMethodInfo* Get { get; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060002F4 RID: 756
		unsafe ref Il2CppMethodInfo* Set { get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060002F5 RID: 757
		ref uint Attrs { get; }
	}
}
