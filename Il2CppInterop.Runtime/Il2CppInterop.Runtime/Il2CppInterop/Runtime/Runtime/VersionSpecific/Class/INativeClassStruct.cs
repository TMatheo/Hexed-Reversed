using System;
using Il2CppInterop.Runtime.Runtime.VersionSpecific.Type;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Class
{
	// Token: 0x02000108 RID: 264
	public interface INativeClassStruct : INativeStruct
	{
		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000BBB RID: 3003
		unsafe Il2CppClass* ClassPointer { get; }

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000BBC RID: 3004
		IntPtr VTable { get; }

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000BBD RID: 3005
		ref uint InstanceSize { get; }

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000BBE RID: 3006
		ref ushort VtableCount { get; }

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000BBF RID: 3007
		ref ushort InterfaceCount { get; }

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000BC0 RID: 3008
		ref ushort InterfaceOffsetsCount { get; }

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000BC1 RID: 3009
		ref byte TypeHierarchyDepth { get; }

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000BC2 RID: 3010
		ref int NativeSize { get; }

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000BC3 RID: 3011
		ref uint ActualSize { get; }

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000BC4 RID: 3012
		ref ushort MethodCount { get; }

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000BC5 RID: 3013
		ref ushort FieldCount { get; }

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000BC6 RID: 3014
		ref Il2CppClassAttributes Flags { get; }

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000BC7 RID: 3015
		// (set) Token: 0x06000BC8 RID: 3016
		bool ValueType { get; set; }

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000BC9 RID: 3017
		// (set) Token: 0x06000BCA RID: 3018
		bool EnumType { get; set; }

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000BCB RID: 3019
		// (set) Token: 0x06000BCC RID: 3020
		bool IsGeneric { get; set; }

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000BCD RID: 3021
		// (set) Token: 0x06000BCE RID: 3022
		bool Initialized { get; set; }

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000BCF RID: 3023
		// (set) Token: 0x06000BD0 RID: 3024
		bool InitializedAndNoError { get; set; }

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000BD1 RID: 3025
		// (set) Token: 0x06000BD2 RID: 3026
		bool SizeInited { get; set; }

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000BD3 RID: 3027
		// (set) Token: 0x06000BD4 RID: 3028
		bool HasFinalize { get; set; }

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000BD5 RID: 3029
		// (set) Token: 0x06000BD6 RID: 3030
		bool IsVtableInitialized { get; set; }

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000BD7 RID: 3031
		ref IntPtr Name { get; }

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000BD8 RID: 3032
		ref IntPtr Namespace { get; }

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000BD9 RID: 3033
		INativeTypeStruct ByValArg { get; }

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000BDA RID: 3034
		INativeTypeStruct ThisArg { get; }

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000BDB RID: 3035
		unsafe ref Il2CppImage* Image { get; }

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000BDC RID: 3036
		unsafe ref Il2CppClass* Parent { get; }

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000BDD RID: 3037
		unsafe ref Il2CppClass* ElementClass { get; }

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000BDE RID: 3038
		unsafe ref Il2CppClass* CastClass { get; }

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000BDF RID: 3039
		unsafe ref Il2CppClass* DeclaringType { get; }

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000BE0 RID: 3040
		unsafe ref Il2CppClass* Class { get; }

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000BE1 RID: 3041
		unsafe ref Il2CppFieldInfo* Fields { get; }

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000BE2 RID: 3042
		unsafe ref Il2CppMethodInfo** Methods { get; }

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000BE3 RID: 3043
		unsafe ref Il2CppClass** ImplementedInterfaces { get; }

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000BE4 RID: 3044
		unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets { get; }

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000BE5 RID: 3045
		unsafe ref Il2CppClass** TypeHierarchy { get; }
	}
}
