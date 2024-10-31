using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.FieldInfo
{
	// Token: 0x0200009E RID: 158
	public interface INativeFieldInfoStruct : INativeStruct
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060005D0 RID: 1488
		unsafe Il2CppFieldInfo* FieldInfoPointer { get; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060005D1 RID: 1489
		ref IntPtr Name { get; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060005D2 RID: 1490
		unsafe ref Il2CppTypeStruct* Type { get; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060005D3 RID: 1491
		unsafe ref Il2CppClass* Parent { get; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060005D4 RID: 1492
		ref int Offset { get; }
	}
}
