using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Exception
{
	// Token: 0x020000B1 RID: 177
	public interface INativeExceptionStruct : INativeStruct
	{
		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600066F RID: 1647
		unsafe Il2CppException* ExceptionPointer { get; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000670 RID: 1648
		unsafe ref Il2CppException* InnerException { get; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000671 RID: 1649
		unsafe ref Il2CppString* Message { get; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000672 RID: 1650
		unsafe ref Il2CppString* HelpLink { get; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000673 RID: 1651
		unsafe ref Il2CppString* ClassName { get; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000674 RID: 1652
		unsafe ref Il2CppString* StackTrace { get; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000675 RID: 1653
		unsafe ref Il2CppString* RemoteStackTrace { get; }
	}
}
