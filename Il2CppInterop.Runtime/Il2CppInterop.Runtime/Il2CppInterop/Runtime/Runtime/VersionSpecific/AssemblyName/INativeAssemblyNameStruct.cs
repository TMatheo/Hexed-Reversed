using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.AssemblyName
{
	// Token: 0x02000126 RID: 294
	public interface INativeAssemblyNameStruct : INativeStruct
	{
		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000CD0 RID: 3280
		unsafe Il2CppAssemblyName* AssemblyNamePointer { get; }

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000CD1 RID: 3281
		ref IntPtr Name { get; }

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000CD2 RID: 3282
		ref IntPtr Culture { get; }

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000CD3 RID: 3283
		ref IntPtr PublicKey { get; }

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000CD4 RID: 3284
		ref int Major { get; }

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000CD5 RID: 3285
		ref int Minor { get; }

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000CD6 RID: 3286
		ref int Build { get; }

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000CD7 RID: 3287
		ref int Revision { get; }

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000CD8 RID: 3288
		ref ulong PublicKeyToken { get; }
	}
}
