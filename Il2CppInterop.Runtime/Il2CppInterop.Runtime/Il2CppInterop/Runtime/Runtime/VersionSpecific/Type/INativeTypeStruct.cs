using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Type
{
	// Token: 0x0200003F RID: 63
	public interface INativeTypeStruct : INativeStruct
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060002CB RID: 715
		unsafe Il2CppTypeStruct* TypePointer { get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060002CC RID: 716
		ref IntPtr Data { get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060002CD RID: 717
		ref ushort Attrs { get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060002CE RID: 718
		ref Il2CppTypeEnum Type { get; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060002CF RID: 719
		// (set) Token: 0x060002D0 RID: 720
		bool ByRef { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060002D1 RID: 721
		// (set) Token: 0x060002D2 RID: 722
		bool Pinned { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060002D3 RID: 723
		// (set) Token: 0x060002D4 RID: 724
		bool ValueType { get; set; }
	}
}
