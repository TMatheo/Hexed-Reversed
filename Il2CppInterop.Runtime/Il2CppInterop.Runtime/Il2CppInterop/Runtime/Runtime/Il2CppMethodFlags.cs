﻿using System;

namespace Il2CppInterop.Runtime.Runtime
{
	// Token: 0x02000029 RID: 41
	[Flags]
	public enum Il2CppMethodFlags : ushort
	{
		// Token: 0x04000064 RID: 100
		METHOD_ATTRIBUTE_MEMBER_ACCESS_MASK = 7,
		// Token: 0x04000065 RID: 101
		METHOD_ATTRIBUTE_COMPILER_CONTROLLED = 0,
		// Token: 0x04000066 RID: 102
		METHOD_ATTRIBUTE_PRIVATE = 1,
		// Token: 0x04000067 RID: 103
		METHOD_ATTRIBUTE_FAM_AND_ASSEM = 2,
		// Token: 0x04000068 RID: 104
		METHOD_ATTRIBUTE_ASSEM = 3,
		// Token: 0x04000069 RID: 105
		METHOD_ATTRIBUTE_FAMILY = 4,
		// Token: 0x0400006A RID: 106
		METHOD_ATTRIBUTE_FAM_OR_ASSEM = 5,
		// Token: 0x0400006B RID: 107
		METHOD_ATTRIBUTE_PUBLIC = 6,
		// Token: 0x0400006C RID: 108
		METHOD_ATTRIBUTE_STATIC = 16,
		// Token: 0x0400006D RID: 109
		METHOD_ATTRIBUTE_FINAL = 32,
		// Token: 0x0400006E RID: 110
		METHOD_ATTRIBUTE_VIRTUAL = 64,
		// Token: 0x0400006F RID: 111
		METHOD_ATTRIBUTE_HIDE_BY_SIG = 128,
		// Token: 0x04000070 RID: 112
		METHOD_ATTRIBUTE_VTABLE_LAYOUT_MASK = 256,
		// Token: 0x04000071 RID: 113
		METHOD_ATTRIBUTE_REUSE_SLOT = 0,
		// Token: 0x04000072 RID: 114
		METHOD_ATTRIBUTE_NEW_SLOT = 256,
		// Token: 0x04000073 RID: 115
		METHOD_ATTRIBUTE_STRICT = 512,
		// Token: 0x04000074 RID: 116
		METHOD_ATTRIBUTE_ABSTRACT = 1024,
		// Token: 0x04000075 RID: 117
		METHOD_ATTRIBUTE_SPECIAL_NAME = 2048,
		// Token: 0x04000076 RID: 118
		METHOD_ATTRIBUTE_PINVOKE_IMPL = 8192,
		// Token: 0x04000077 RID: 119
		METHOD_ATTRIBUTE_UNMANAGED_EXPORT = 8,
		// Token: 0x04000078 RID: 120
		METHOD_ATTRIBUTE_RESERVED_MASK = 53248,
		// Token: 0x04000079 RID: 121
		METHOD_ATTRIBUTE_RT_SPECIAL_NAME = 4096,
		// Token: 0x0400007A RID: 122
		METHOD_ATTRIBUTE_HAS_SECURITY = 16384,
		// Token: 0x0400007B RID: 123
		METHOD_ATTRIBUTE_REQUIRE_SEC_OBJECT = 32768
	}
}
