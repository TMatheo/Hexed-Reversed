using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.ParameterInfo
{
	// Token: 0x02000051 RID: 81
	public interface INativeParameterInfoStructHandler : INativeStructHandler
	{
		// Token: 0x0600033E RID: 830
		unsafe Il2CppParameterInfo*[] CreateNewParameterInfoArray(int paramCount);

		// Token: 0x0600033F RID: 831
		unsafe INativeParameterInfoStruct Wrap(Il2CppParameterInfo* paramInfoPointer);

		// Token: 0x06000340 RID: 832
		unsafe INativeParameterInfoStruct Wrap(Il2CppParameterInfo* paramInfoListBegin, int index);

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000341 RID: 833
		bool HasNamePosToken { get; }
	}
}
