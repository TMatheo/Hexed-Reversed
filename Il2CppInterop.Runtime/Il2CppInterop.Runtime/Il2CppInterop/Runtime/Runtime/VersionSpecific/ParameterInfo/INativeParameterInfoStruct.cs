using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.ParameterInfo
{
	// Token: 0x02000052 RID: 82
	public interface INativeParameterInfoStruct : INativeStruct
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000342 RID: 834
		unsafe Il2CppParameterInfo* ParameterInfoPointer { get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000343 RID: 835
		bool HasNamePosToken { get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000344 RID: 836
		ref IntPtr Name { get; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000345 RID: 837
		ref int Position { get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000346 RID: 838
		ref uint Token { get; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000347 RID: 839
		unsafe ref Il2CppTypeStruct* ParameterType { get; }
	}
}
