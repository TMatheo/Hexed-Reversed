using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x02000095 RID: 149
	public interface INativeImageStruct : INativeStruct
	{
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600059C RID: 1436
		unsafe Il2CppImage* ImagePointer { get; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600059D RID: 1437
		unsafe ref Il2CppAssembly* Assembly { get; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600059E RID: 1438
		ref byte Dynamic { get; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600059F RID: 1439
		ref IntPtr Name { get; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060005A0 RID: 1440
		bool HasNameNoExt { get; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060005A1 RID: 1441
		ref IntPtr NameNoExt { get; }
	}
}
