using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Type
{
	// Token: 0x0200003D RID: 61
	public interface INativeTypeStruct : INativeStruct
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060002A7 RID: 679
		unsafe Il2CppTypeStruct* TypePointer { get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060002A8 RID: 680
		ref IntPtr Data { get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060002A9 RID: 681
		ref ushort Attrs { get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060002AA RID: 682
		ref Il2CppTypeEnum Type { get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060002AB RID: 683
		// (set) Token: 0x060002AC RID: 684
		bool ByRef { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060002AD RID: 685
		// (set) Token: 0x060002AE RID: 686
		bool Pinned { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060002AF RID: 687
		// (set) Token: 0x060002B0 RID: 688
		bool ValueType { get; set; }
	}
}
