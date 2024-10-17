using System;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x0200010A RID: 266
	public interface INativeClassStruct : INativeStruct
	{
		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000BDF RID: 3039
		unsafe Il2CppClass* ClassPointer { get; }

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000BE0 RID: 3040
		IntPtr VTable { get; }

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000BE1 RID: 3041
		ref uint InstanceSize { get; }

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000BE2 RID: 3042
		ref ushort VtableCount { get; }

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000BE3 RID: 3043
		ref ushort InterfaceCount { get; }

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000BE4 RID: 3044
		ref ushort InterfaceOffsetsCount { get; }

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000BE5 RID: 3045
		ref byte TypeHierarchyDepth { get; }

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000BE6 RID: 3046
		ref int NativeSize { get; }

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000BE7 RID: 3047
		ref uint ActualSize { get; }

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000BE8 RID: 3048
		ref ushort MethodCount { get; }

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000BE9 RID: 3049
		ref ushort FieldCount { get; }

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000BEA RID: 3050
		ref Il2CppClassAttributes Flags { get; }

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000BEB RID: 3051
		// (set) Token: 0x06000BEC RID: 3052
		bool ValueType { get; set; }

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000BED RID: 3053
		// (set) Token: 0x06000BEE RID: 3054
		bool EnumType { get; set; }

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000BEF RID: 3055
		// (set) Token: 0x06000BF0 RID: 3056
		bool IsGeneric { get; set; }

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000BF1 RID: 3057
		// (set) Token: 0x06000BF2 RID: 3058
		bool Initialized { get; set; }

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000BF3 RID: 3059
		// (set) Token: 0x06000BF4 RID: 3060
		bool InitializedAndNoError { get; set; }

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000BF5 RID: 3061
		// (set) Token: 0x06000BF6 RID: 3062
		bool SizeInited { get; set; }

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000BF7 RID: 3063
		// (set) Token: 0x06000BF8 RID: 3064
		bool HasFinalize { get; set; }

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000BF9 RID: 3065
		// (set) Token: 0x06000BFA RID: 3066
		bool IsVtableInitialized { get; set; }

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000BFB RID: 3067
		ref IntPtr Name { get; }

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000BFC RID: 3068
		ref IntPtr Namespace { get; }

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000BFD RID: 3069
		INativeTypeStruct ByValArg { get; }

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000BFE RID: 3070
		INativeTypeStruct ThisArg { get; }

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000BFF RID: 3071
		unsafe ref Il2CppImage* Image { get; }

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000C00 RID: 3072
		unsafe ref Il2CppClass* Parent { get; }

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000C01 RID: 3073
		unsafe ref Il2CppClass* ElementClass { get; }

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000C02 RID: 3074
		unsafe ref Il2CppClass* CastClass { get; }

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000C03 RID: 3075
		unsafe ref Il2CppClass* DeclaringType { get; }

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000C04 RID: 3076
		unsafe ref Il2CppClass* Class { get; }

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000C05 RID: 3077
		unsafe ref Il2CppFieldInfo* Fields { get; }

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000C06 RID: 3078
		unsafe ref Il2CppMethodInfo** Methods { get; }

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000C07 RID: 3079
		unsafe ref Il2CppClass** ImplementedInterfaces { get; }

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000C08 RID: 3080
		unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets { get; }

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000C09 RID: 3081
		unsafe ref Il2CppClass** TypeHierarchy { get; }
	}
}
