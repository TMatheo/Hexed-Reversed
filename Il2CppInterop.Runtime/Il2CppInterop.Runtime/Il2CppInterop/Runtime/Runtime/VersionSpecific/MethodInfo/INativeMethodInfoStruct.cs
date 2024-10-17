using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x0200005F RID: 95
	public interface INativeMethodInfoStruct : INativeStruct
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060003BD RID: 957
		unsafe Il2CppMethodInfo* MethodInfoPointer { get; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060003BE RID: 958
		ref IntPtr Name { get; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060003BF RID: 959
		ref ushort Slot { get; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060003C0 RID: 960
		ref IntPtr MethodPointer { get; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060003C1 RID: 961
		unsafe ref Il2CppClass* Class { get; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060003C2 RID: 962
		ref IntPtr InvokerMethod { get; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060003C3 RID: 963
		unsafe ref Il2CppTypeStruct* ReturnType { get; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060003C4 RID: 964
		ref Il2CppMethodFlags Flags { get; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060003C5 RID: 965
		ref byte ParametersCount { get; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060003C6 RID: 966
		unsafe ref Il2CppParameterInfo* Parameters { get; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060003C7 RID: 967
		ref uint Token { get; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060003C8 RID: 968
		// (set) Token: 0x060003C9 RID: 969
		bool IsGeneric { get; set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060003CA RID: 970
		// (set) Token: 0x060003CB RID: 971
		bool IsInflated { get; set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060003CC RID: 972
		// (set) Token: 0x060003CD RID: 973
		bool IsMarshalledFromNative { get; set; }
	}
}
