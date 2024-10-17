using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.ParameterInfo
{
	// Token: 0x02000054 RID: 84
	public interface INativeParameterInfoStruct : INativeStruct
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000364 RID: 868
		unsafe Il2CppParameterInfo* ParameterInfoPointer { get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000365 RID: 869
		bool HasNamePosToken { get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000366 RID: 870
		ref IntPtr Name { get; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000367 RID: 871
		ref int Position { get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000368 RID: 872
		ref uint Token { get; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000369 RID: 873
		unsafe ref Il2CppTypeStruct* ParameterType { get; }
	}
}
