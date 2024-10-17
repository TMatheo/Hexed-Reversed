using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.ParameterInfo
{
	// Token: 0x02000053 RID: 83
	public interface INativeParameterInfoStructHandler : INativeStructHandler
	{
		// Token: 0x06000360 RID: 864
		unsafe Il2CppParameterInfo*[] CreateNewParameterInfoArray(int paramCount);

		// Token: 0x06000361 RID: 865
		unsafe INativeParameterInfoStruct Wrap(Il2CppParameterInfo* paramInfoPointer);

		// Token: 0x06000362 RID: 866
		unsafe INativeParameterInfoStruct Wrap(Il2CppParameterInfo* paramInfoListBegin, int index);

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000363 RID: 867
		bool HasNamePosToken { get; }
	}
}
