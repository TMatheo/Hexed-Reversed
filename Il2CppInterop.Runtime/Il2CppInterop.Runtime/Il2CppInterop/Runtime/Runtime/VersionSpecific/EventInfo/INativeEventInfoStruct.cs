using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.EventInfo
{
	// Token: 0x020000BC RID: 188
	public interface INativeEventInfoStruct : INativeStruct
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060006C5 RID: 1733
		unsafe Il2CppEventInfo* EventInfoPointer { get; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060006C6 RID: 1734
		ref IntPtr Name { get; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060006C7 RID: 1735
		unsafe ref Il2CppTypeStruct* EventType { get; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060006C8 RID: 1736
		unsafe ref Il2CppClass* Parent { get; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060006C9 RID: 1737
		unsafe ref Il2CppMethodInfo* Add { get; }

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060006CA RID: 1738
		unsafe ref Il2CppMethodInfo* Remove { get; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060006CB RID: 1739
		unsafe ref Il2CppMethodInfo* Raise { get; }
	}
}
