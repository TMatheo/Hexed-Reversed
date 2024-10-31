using System;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.MethodInfo
{
	// Token: 0x0200005D RID: 93
	public interface INativeMethodInfoStruct : INativeStruct
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600039A RID: 922
		unsafe Il2CppMethodInfo* MethodInfoPointer { get; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600039B RID: 923
		ref IntPtr Name { get; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600039C RID: 924
		ref ushort Slot { get; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600039D RID: 925
		ref IntPtr MethodPointer { get; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600039E RID: 926
		unsafe ref Il2CppClass* Class { get; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600039F RID: 927
		ref IntPtr InvokerMethod { get; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060003A0 RID: 928
		unsafe ref Il2CppTypeStruct* ReturnType { get; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060003A1 RID: 929
		ref Il2CppMethodFlags Flags { get; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060003A2 RID: 930
		ref byte ParametersCount { get; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060003A3 RID: 931
		unsafe ref Il2CppParameterInfo* Parameters { get; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060003A4 RID: 932
		ref uint Token { get; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060003A5 RID: 933
		// (set) Token: 0x060003A6 RID: 934
		bool IsGeneric { get; set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060003A7 RID: 935
		// (set) Token: 0x060003A8 RID: 936
		bool IsInflated { get; set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060003A9 RID: 937
		// (set) Token: 0x060003AA RID: 938
		bool IsMarshalledFromNative { get; set; }
	}
}
