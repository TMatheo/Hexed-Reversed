using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.FieldInfo
{
	// Token: 0x020000A0 RID: 160
	public interface INativeFieldInfoStruct : INativeStruct
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060005E8 RID: 1512
		unsafe Il2CppFieldInfo* FieldInfoPointer { get; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060005E9 RID: 1513
		ref IntPtr Name { get; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060005EA RID: 1514
		unsafe ref Il2CppTypeStruct* Type { get; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060005EB RID: 1515
		unsafe ref Il2CppClass* Parent { get; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060005EC RID: 1516
		ref int Offset { get; }
	}
}
