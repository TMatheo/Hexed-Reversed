using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Image
{
	// Token: 0x02000093 RID: 147
	public interface INativeImageStruct : INativeStruct
	{
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000582 RID: 1410
		unsafe Il2CppImage* ImagePointer { get; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000583 RID: 1411
		unsafe ref Il2CppAssembly* Assembly { get; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000584 RID: 1412
		ref byte Dynamic { get; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000585 RID: 1413
		ref IntPtr Name { get; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000586 RID: 1414
		bool HasNameNoExt { get; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000587 RID: 1415
		ref IntPtr NameNoExt { get; }
	}
}
