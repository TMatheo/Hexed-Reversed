using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName
{
	// Token: 0x02000124 RID: 292
	public interface INativeAssemblyNameStruct : INativeStruct
	{
		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000CAD RID: 3245
		unsafe Il2CppAssemblyName* AssemblyNamePointer { get; }

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000CAE RID: 3246
		ref IntPtr Name { get; }

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000CAF RID: 3247
		ref IntPtr Culture { get; }

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000CB0 RID: 3248
		ref IntPtr PublicKey { get; }

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000CB1 RID: 3249
		ref int Major { get; }

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000CB2 RID: 3250
		ref int Minor { get; }

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000CB3 RID: 3251
		ref int Build { get; }

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000CB4 RID: 3252
		ref int Revision { get; }

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000CB5 RID: 3253
		ref ulong PublicKeyToken { get; }
	}
}
