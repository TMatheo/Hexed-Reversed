using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.EventInfo
{
	// Token: 0x020000BA RID: 186
	public interface INativeEventInfoStruct : INativeStruct
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060006A8 RID: 1704
		unsafe Il2CppEventInfo* EventInfoPointer { get; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060006A9 RID: 1705
		ref IntPtr Name { get; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060006AA RID: 1706
		unsafe ref Il2CppTypeStruct* EventType { get; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060006AB RID: 1707
		unsafe ref Il2CppClass* Parent { get; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060006AC RID: 1708
		unsafe ref Il2CppMethodInfo* Add { get; }

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060006AD RID: 1709
		unsafe ref Il2CppMethodInfo* Remove { get; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060006AE RID: 1710
		unsafe ref Il2CppMethodInfo* Raise { get; }
	}
}
