using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Exception
{
	// Token: 0x020000AF RID: 175
	public interface INativeExceptionStruct : INativeStruct
	{
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000654 RID: 1620
		unsafe Il2CppException* ExceptionPointer { get; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000655 RID: 1621
		unsafe ref Il2CppException* InnerException { get; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000656 RID: 1622
		unsafe ref Il2CppString* Message { get; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000657 RID: 1623
		unsafe ref Il2CppString* HelpLink { get; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000658 RID: 1624
		unsafe ref Il2CppString* ClassName { get; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000659 RID: 1625
		unsafe ref Il2CppString* StackTrace { get; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600065A RID: 1626
		unsafe ref Il2CppString* RemoteStackTrace { get; }
	}
}
