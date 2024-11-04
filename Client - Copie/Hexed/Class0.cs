using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using ExitGames.Client.Photon;
using Hexed.Wrappers;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using VRC.SDK.Internal.Whiteboard.VRC_Presentation_Utils;
using VRCSDK2;

// Token: 0x02000003 RID: 3
internal class Class0
{
	// Token: 0x0600000C RID: 12 RVA: 0x00002370 File Offset: 0x00000570
	internal static bool FSGfKRSV7djSLfydBar()
	{
		return Class0.guAPPySM2PexlpjCqkB == null;
	}

	// Token: 0x04000005 RID: 5
	internal static Class0 guAPPySM2PexlpjCqkB;

	// Token: 0x02000004 RID: 4
	public class Class1
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000047C8 File Offset: 0x000029C8
		private static byte[] IL2CPPObjectToByteArray(Object obj)
		{
			if (obj != null)
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				MemoryStream memoryStream = new MemoryStream();
				binaryFormatter.Serialize(memoryStream, obj);
				return memoryStream.ToArray();
			}
			return null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000047FC File Offset: 0x000029FC
		private static byte[] ManagedObjectToByteArray(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			MemoryStream memoryStream = new MemoryStream();
			binaryFormatter.Serialize(memoryStream, obj);
			return memoryStream.ToArray();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000482C File Offset: 0x00002A2C
		private static object ManagedObjectFromArray(byte[] data)
		{
			if (data != null)
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				object result;
				using (MemoryStream memoryStream = new MemoryStream(data))
				{
					result = binaryFormatter.Deserialize(memoryStream);
				}
				return result;
			}
			return null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00004878 File Offset: 0x00002A78
		private static Object IL2CPPObjectFromArray(byte[] data)
		{
			if (data == null)
			{
				return null;
			}
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			MemoryStream memoryStream = new MemoryStream(data);
			return (Object)binaryFormatter.Deserialize(memoryStream);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000237A File Offset: 0x0000057A
		public static object Serialize(Object obj)
		{
			return Class0.Class1.ManagedObjectFromArray(Class0.Class1.IL2CPPObjectToByteArray(obj));
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002387 File Offset: 0x00000587
		public static Object Serialize(object obj)
		{
			return Class0.Class1.IL2CPPObjectFromArray(Class0.Class1.ManagedObjectToByteArray(obj));
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002394 File Offset: 0x00000594
		internal static bool vf8Vlf9Ngq8D2FpVn2u()
		{
			return Class0.Class1.iFUM7P9STkIxkEu1ikR == null;
		}

		// Token: 0x04000006 RID: 6
		internal static Class0.Class1 iFUM7P9STkIxkEu1ikR;
	}

	// Token: 0x02000005 RID: 5
	public class Class2
	{
		// Token: 0x06000015 RID: 21 RVA: 0x000048A8 File Offset: 0x00002AA8
		public static Object ManagedToIL(object Data)
		{
			Type type = Data.GetType();
			if (!type.IsArray)
			{
				if (type == typeof(string))
				{
					return new Object(IL2CPP.ManagedStringToIl2Cpp(Data.ToString()));
				}
				if (type == typeof(bool))
				{
					Boolean boolean = default(Boolean);
					boolean.m_value = (bool)Data;
					return boolean.BoxIl2CppObject();
				}
				if (type == typeof(byte))
				{
					Byte @byte = default(Byte);
					@byte.m_value = (byte)Data;
					return @byte.BoxIl2CppObject();
				}
				if (type == typeof(sbyte))
				{
					SByte @sbyte = default(SByte);
					@sbyte.m_value = (sbyte)Data;
					return @sbyte.BoxIl2CppObject();
				}
				if (type == typeof(char))
				{
					Char @char = default(Char);
					@char.m_value = (char)Data;
					return @char.BoxIl2CppObject();
				}
				if (type == typeof(double))
				{
					Double @double = default(Double);
					@double.m_value = (double)Data;
					return @double.BoxIl2CppObject();
				}
				if (type == typeof(float))
				{
					Single single = default(Single);
					single.m_value = (float)Data;
					return single.BoxIl2CppObject();
				}
				if (type == typeof(int))
				{
					Int32 @int = default(Int32);
					@int.m_value = (int)Data;
					return @int.BoxIl2CppObject();
				}
				if (type == typeof(uint))
				{
					UInt32 @uint = default(UInt32);
					@uint.m_value = (uint)Data;
					return @uint.BoxIl2CppObject();
				}
				if (type == typeof(IntPtr))
				{
					IntPtr intPtr = default(IntPtr);
					intPtr.m_value = (IntPtr)Data;
					return intPtr.BoxIl2CppObject();
				}
				if (type == typeof(UIntPtr))
				{
					UIntPtr uintPtr = default(UIntPtr);
					uintPtr._pointer = (IntPtr)Data;
					return uintPtr.BoxIl2CppObject();
				}
				if (type == typeof(long))
				{
					Int64 int2 = default(Int64);
					int2.m_value = (long)Data;
					return int2.BoxIl2CppObject();
				}
				if (type == typeof(ulong))
				{
					UInt64 uint2 = default(UInt64);
					uint2.m_value = (ulong)Data;
					return uint2.BoxIl2CppObject();
				}
				if (type == typeof(short))
				{
					Int16 int3 = default(Int16);
					int3.m_value = (short)Data;
					return int3.BoxIl2CppObject();
				}
				if (type == typeof(ushort))
				{
					UInt16 uint3 = default(UInt16);
					uint3.m_value = (ushort)Data;
					return uint3.BoxIl2CppObject();
				}
				if (type == typeof(Vector2))
				{
					return ((Vector2)Data).BoxIl2CppObject();
				}
				if (type == typeof(Vector3))
				{
					return ((Vector3)Data).BoxIl2CppObject();
				}
				if (type == typeof(Vector4))
				{
					return ((Vector4)Data).BoxIl2CppObject();
				}
				if (type == typeof(Quaternion))
				{
					return ((Quaternion)Data).BoxIl2CppObject();
				}
				if (type == typeof(Color))
				{
					return ((Color)Data).BoxIl2CppObject();
				}
				if (type == typeof(Color32))
				{
					return ((Color32)Data).BoxIl2CppObject();
				}
			}
			return Class0.Class1.Serialize(Data);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00004C84 File Offset: 0x00002E84
		public static object smethod_0(Object Data)
		{
			if (Data == null)
			{
				return null;
			}
			Type il2CppType = Data.GetIl2CppType();
			if (il2CppType.IsArray)
			{
				if (!il2CppType.GetElementType().IsArray)
				{
					if (il2CppType.GetElementType() == Il2CppType.Of<string>())
					{
						return Il2CppArrayBase<string>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<bool>())
					{
						return Il2CppArrayBase<bool>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<byte>())
					{
						return Il2CppArrayBase<byte>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<sbyte>())
					{
						return Il2CppArrayBase<sbyte>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<char>())
					{
						return Il2CppArrayBase<char>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<double>())
					{
						return Il2CppArrayBase<double>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<float>())
					{
						return Il2CppArrayBase<float>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<int>())
					{
						return Il2CppArrayBase<int>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<uint>())
					{
						return Il2CppArrayBase<uint>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<IntPtr>())
					{
						return Il2CppArrayBase<IntPtr>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<UIntPtr>())
					{
						return Il2CppArrayBase<UIntPtr>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<long>())
					{
						return Il2CppArrayBase<long>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<ulong>())
					{
						return Il2CppArrayBase<ulong>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<short>())
					{
						return Il2CppArrayBase<short>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<ushort>())
					{
						return Il2CppArrayBase<ushort>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<Vector2>())
					{
						return Il2CppArrayBase<Vector2>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<Vector3>())
					{
						return Il2CppArrayBase<Vector3>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<Vector4>())
					{
						return Il2CppArrayBase<Vector4>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<Quaternion>())
					{
						return Il2CppArrayBase<Quaternion>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<Color>())
					{
						return Il2CppArrayBase<Color>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<Color32>())
					{
						return Il2CppArrayBase<Color32>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<GameObject>())
					{
						return Il2CppArrayBase<GameObject>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<Object>())
					{
						return Il2CppArrayBase<Object>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<Transform>())
					{
						return Il2CppArrayBase<Transform>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.GetElementType() == Il2CppType.Of<VRC_SyncVideoPlayer.VideoEntry>())
					{
						return Il2CppArrayBase<VRC_SyncVideoPlayer.VideoEntry>.WrapNativeGenericArrayPointer(Data.Pointer);
					}
					if (il2CppType.Name == "Object[]")
					{
						return Class0.Class2.ReadObjectArray(Data);
					}
				}
				else if (il2CppType.Name == "Object[][]")
				{
					return Class0.Class2.ReadObjectArrayArray(Data);
				}
			}
			else if (il2CppType.Name == "Dictionary`2")
			{
				if (il2CppType == Il2CppType.Of<Dictionary<string, Object>>())
				{
					return Class0.Class2.ReadDictionary<string>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<bool, Object>>())
				{
					return Class0.Class2.ReadDictionary<bool>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<byte, Object>>())
				{
					return Class0.Class2.ReadDictionary<byte>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<sbyte, Object>>())
				{
					return Class0.Class2.ReadDictionary<sbyte>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<char, Object>>())
				{
					return Class0.Class2.ReadDictionary<char>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<double, Object>>())
				{
					return Class0.Class2.ReadDictionary<double>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<float, Object>>())
				{
					return Class0.Class2.ReadDictionary<float>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<int, Object>>())
				{
					return Class0.Class2.ReadDictionary<int>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<uint, Object>>())
				{
					return Class0.Class2.ReadDictionary<uint>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<IntPtr, Object>>())
				{
					return Class0.Class2.ReadDictionary<IntPtr>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<UIntPtr, Object>>())
				{
					return Class0.Class2.ReadDictionary<UIntPtr>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<long, Object>>())
				{
					return Class0.Class2.ReadDictionary<long>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<ulong, Object>>())
				{
					return Class0.Class2.ReadDictionary<ulong>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<short, Object>>())
				{
					return Class0.Class2.ReadDictionary<short>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<ushort, Object>>())
				{
					return Class0.Class2.ReadDictionary<ushort>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<byte, string>>())
				{
					return Class0.Class2.ReadDictionary<byte, string>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<byte, bool>>())
				{
					return Class0.Class2.ReadDictionary<byte, bool>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<byte, byte>>())
				{
					return Class0.Class2.ReadDictionary<byte, byte>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<byte, sbyte>>())
				{
					return Class0.Class2.ReadDictionary<byte, sbyte>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<byte, char>>())
				{
					return Class0.Class2.ReadDictionary<byte, char>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<byte, double>>())
				{
					return Class0.Class2.ReadDictionary<byte, double>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<byte, float>>())
				{
					return Class0.Class2.ReadDictionary<byte, float>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<byte, int>>())
				{
					return Class0.Class2.ReadDictionary<byte, int>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<byte, uint>>())
				{
					return Class0.Class2.ReadDictionary<byte, uint>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<byte, IntPtr>>())
				{
					return Class0.Class2.ReadDictionary<byte, IntPtr>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<byte, UIntPtr>>())
				{
					return Class0.Class2.ReadDictionary<byte, UIntPtr>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<byte, long>>())
				{
					return Class0.Class2.ReadDictionary<byte, long>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<byte, ulong>>())
				{
					return Class0.Class2.ReadDictionary<byte, ulong>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<byte, short>>())
				{
					return Class0.Class2.ReadDictionary<byte, short>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<byte, ushort>>())
				{
					return Class0.Class2.ReadDictionary<byte, ushort>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<string, string>>())
				{
					return Class0.Class2.ReadDictionary<string, string>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<string, bool>>())
				{
					return Class0.Class2.ReadDictionary<string, bool>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<string, byte>>())
				{
					return Class0.Class2.ReadDictionary<string, byte>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<string, sbyte>>())
				{
					return Class0.Class2.ReadDictionary<string, sbyte>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<string, char>>())
				{
					return Class0.Class2.ReadDictionary<string, char>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<string, double>>())
				{
					return Class0.Class2.ReadDictionary<string, double>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<string, float>>())
				{
					return Class0.Class2.ReadDictionary<string, float>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<string, int>>())
				{
					return Class0.Class2.ReadDictionary<string, int>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<string, uint>>())
				{
					return Class0.Class2.ReadDictionary<string, uint>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<string, IntPtr>>())
				{
					return Class0.Class2.ReadDictionary<string, IntPtr>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<string, UIntPtr>>())
				{
					return Class0.Class2.ReadDictionary<string, UIntPtr>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<string, long>>())
				{
					return Class0.Class2.ReadDictionary<string, long>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<string, ulong>>())
				{
					return Class0.Class2.ReadDictionary<string, ulong>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<string, short>>())
				{
					return Class0.Class2.ReadDictionary<string, short>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<string, ushort>>())
				{
					return Class0.Class2.ReadDictionary<string, ushort>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<int, string>>())
				{
					return Class0.Class2.ReadDictionary<int, string>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<int, bool>>())
				{
					return Class0.Class2.ReadDictionary<int, bool>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<int, byte>>())
				{
					return Class0.Class2.ReadDictionary<int, byte>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<int, sbyte>>())
				{
					return Class0.Class2.ReadDictionary<int, sbyte>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<int, char>>())
				{
					return Class0.Class2.ReadDictionary<int, char>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<int, double>>())
				{
					return Class0.Class2.ReadDictionary<int, double>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<int, float>>())
				{
					return Class0.Class2.ReadDictionary<int, float>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<int, int>>())
				{
					return Class0.Class2.ReadDictionary<int, int>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<int, uint>>())
				{
					return Class0.Class2.ReadDictionary<int, uint>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<int, IntPtr>>())
				{
					return Class0.Class2.ReadDictionary<int, IntPtr>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<int, UIntPtr>>())
				{
					return Class0.Class2.ReadDictionary<int, UIntPtr>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<int, long>>())
				{
					return Class0.Class2.ReadDictionary<int, long>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<int, ulong>>())
				{
					return Class0.Class2.ReadDictionary<int, ulong>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<int, short>>())
				{
					return Class0.Class2.ReadDictionary<int, short>(Data);
				}
				if (il2CppType == Il2CppType.Of<Dictionary<int, ushort>>())
				{
					return Class0.Class2.ReadDictionary<int, ushort>(Data);
				}
			}
			else
			{
				if (il2CppType == Il2CppType.Of<string>())
				{
					return Data.ToString();
				}
				if (il2CppType == Il2CppType.Of<bool>())
				{
					return Data.Unbox<bool>();
				}
				if (il2CppType == Il2CppType.Of<byte>())
				{
					return Data.Unbox<byte>();
				}
				if (il2CppType == Il2CppType.Of<sbyte>())
				{
					return Data.Unbox<sbyte>();
				}
				if (il2CppType == Il2CppType.Of<char>())
				{
					return Data.Unbox<char>();
				}
				if (il2CppType == Il2CppType.Of<double>())
				{
					return Data.Unbox<double>();
				}
				if (il2CppType == Il2CppType.Of<float>())
				{
					return Data.Unbox<float>();
				}
				if (il2CppType == Il2CppType.Of<int>())
				{
					return Data.Unbox<int>();
				}
				if (il2CppType == Il2CppType.Of<uint>())
				{
					return Data.Unbox<uint>();
				}
				if (il2CppType == Il2CppType.Of<IntPtr>())
				{
					return Data.Unbox<IntPtr>();
				}
				if (il2CppType == Il2CppType.Of<UIntPtr>())
				{
					return Data.Unbox<UIntPtr>();
				}
				if (il2CppType == Il2CppType.Of<long>())
				{
					return Data.Unbox<long>();
				}
				if (il2CppType == Il2CppType.Of<ulong>())
				{
					return Data.Unbox<ulong>();
				}
				if (il2CppType == Il2CppType.Of<short>())
				{
					return Data.Unbox<short>();
				}
				if (il2CppType == Il2CppType.Of<ushort>())
				{
					return Data.Unbox<ushort>();
				}
				if (il2CppType == Il2CppType.Of<Vector2>())
				{
					return Data.Unbox<Vector2>();
				}
				if (il2CppType == Il2CppType.Of<Vector3>())
				{
					return Data.Unbox<Vector3>();
				}
				if (il2CppType == Il2CppType.Of<Vector4>())
				{
					return Data.Unbox<Vector4>();
				}
				if (il2CppType == Il2CppType.Of<Quaternion>())
				{
					return Data.Unbox<Quaternion>();
				}
				if (il2CppType == Il2CppType.Of<Color>())
				{
					return Data.Unbox<Color>();
				}
				if (il2CppType == Il2CppType.Of<Color32>())
				{
					return Data.Unbox<Color32>();
				}
				if (il2CppType == Il2CppType.Of<EnumPublicSealedvaLeCu3vUnique>())
				{
					return Data.Unbox<EnumPublicSealedvaLeCu3vUnique>();
				}
				if (il2CppType == Il2CppType.Of<EnumPublicSealedvaPoShSt4vUnique>())
				{
					return Data.Unbox<EnumPublicSealedvaPoShSt4vUnique>();
				}
				if (il2CppType == Il2CppType.Of<ObjectPublicByVoByVoByByByByByByUnique.EnumNPublicSealedvaAvFaUsStAlPrBiTaBiUnique>())
				{
					return Data.Unbox<ObjectPublicByVoByVoByByByByByByUnique.EnumNPublicSealedvaAvFaUsStAlPrBiTaBiUnique>();
				}
				if (il2CppType == Il2CppType.Of<EnumPublicSealedvaNoImApPl5vUnique>())
				{
					return Data.Unbox<EnumPublicSealedvaNoImApPl5vUnique>();
				}
				if (il2CppType == Il2CppType.Of<EnumPublicSealedvaCrUpDePoReCr7vUnique>())
				{
					return Data.Unbox<EnumPublicSealedvaCrUpDePoReCr7vUnique>();
				}
				if (il2CppType == Il2CppType.Of<EnumPublicSealedvaCrDeUpUn5vUnique>())
				{
					return Data.Unbox<EnumPublicSealedvaCrDeUpUn5vUnique>();
				}
				if (il2CppType == Il2CppType.Of<EnumPublicSealedvaAlFrGr4vUnique>())
				{
					return Data.Unbox<EnumPublicSealedvaAlFrGr4vUnique>();
				}
				if (il2CppType == Il2CppType.Of<GameObject>())
				{
					return Data.Cast<GameObject>();
				}
				if (il2CppType == Il2CppType.Of<Object>())
				{
					return Data.Cast<Object>();
				}
				if (il2CppType == Il2CppType.Of<Transform>())
				{
					return Data.Cast<Transform>();
				}
				if (il2CppType == Il2CppType.Of<VRC_SyncVideoPlayer.VideoEntry>())
				{
					return Data.Cast<VRC_SyncVideoPlayer.VideoEntry>();
				}
				if (il2CppType == Il2CppType.Of<InkStroke>())
				{
					return Data.Cast<InkStroke>();
				}
				if (il2CppType == Il2CppType.Of<Hashtable>())
				{
					return Class0.Class2.ReadHashtable(Data);
				}
				if (il2CppType == Il2CppType.Of<ParameterDictionary>())
				{
					return Class0.Class2.ReadParamDictionary(Data);
				}
			}
			object result;
			try
			{
				result = Class0.Class1.Serialize(Data);
			}
			catch
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(49, 4);
				defaultInterpolatedStringHandler.AppendLiteral("Il2CPPToManaged: Not Implemented type: ");
				defaultInterpolatedStringHandler.AppendFormatted(il2CppType.FullName);
				defaultInterpolatedStringHandler.AppendLiteral(" in ");
				defaultInterpolatedStringHandler.AppendFormatted(il2CppType.Assembly.FullName);
				defaultInterpolatedStringHandler.AppendLiteral(" [");
				defaultInterpolatedStringHandler.AppendFormatted<int>(il2CppType.MetadataToken);
				defaultInterpolatedStringHandler.AppendLiteral(" | ");
				defaultInterpolatedStringHandler.AppendFormatted<IntPtr>(il2CppType.Pointer);
				defaultInterpolatedStringHandler.AppendLiteral("]");
				Logger.LogError(defaultInterpolatedStringHandler.ToStringAndClear());
				foreach (FieldInfo fieldInfo in il2CppType.GetFields())
				{
					Logger.LogError(fieldInfo.Name);
				}
				foreach (MethodInfo methodInfo in il2CppType.GetMethods())
				{
					Logger.LogError(methodInfo.Name);
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00005AF4 File Offset: 0x00003CF4
		private static Dictionary<T, object> ReadDictionary<T>(Object Data)
		{
			Dictionary<T, object> dictionary = new Dictionary<T, object>();
			foreach (KeyValuePair<T, Object> keyValuePair in Data.Cast<Dictionary<T, Object>>())
			{
				if (keyValuePair.Key != null)
				{
					T key = keyValuePair.Key;
					object value = Class0.Class2.smethod_0(keyValuePair.Value);
					dictionary.Add(key, value);
				}
			}
			return dictionary;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00005B50 File Offset: 0x00003D50
		private static Dictionary<T, object> ReadDictionary<T, V>(Object Data)
		{
			Dictionary<T, object> dictionary = new Dictionary<T, object>();
			foreach (KeyValuePair<T, V> keyValuePair in Data.Cast<Dictionary<T, V>>())
			{
				if (keyValuePair.Key != null)
				{
					T key = keyValuePair.Key;
					V value = keyValuePair.Value;
					dictionary.Add(key, value);
				}
			}
			return dictionary;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00005BAC File Offset: 0x00003DAC
		private static Hashtable ReadHashtable(Object Data)
		{
			Hashtable hashtable = new Hashtable();
			foreach (Hashtable.bucket bucket in Data.Cast<Hashtable>()._buckets)
			{
				if (bucket.key != null)
				{
					object value = (bucket.val == null) ? null : Class0.Class2.smethod_0(bucket.val);
					hashtable.Add(Class0.Class2.smethod_0(bucket.key), value);
				}
			}
			return hashtable;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00005C40 File Offset: 0x00003E40
		private static Dictionary<byte, object> ReadParamDictionary(Object Data)
		{
			Dictionary<byte, object> dictionary = new Dictionary<byte, object>();
			foreach (KeyValuePair<byte, Object> keyValuePair in Data.Cast<ParameterDictionary>().paramDict)
			{
				object value = (keyValuePair.Value == null) ? null : Class0.Class2.smethod_0(keyValuePair.value);
				dictionary.Add(keyValuePair.Key, value);
			}
			return dictionary;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00005C9C File Offset: 0x00003E9C
		private static object[] ReadObjectArray(Object Data)
		{
			Array array = Data.Cast<Array>();
			int length = array.Length;
			object[] array2 = new object[length];
			for (int i = 0; i < length; i++)
			{
				object obj = Class0.Class2.smethod_0(array.GetValue(i));
				array2[i] = obj;
			}
			return array2;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00005CF0 File Offset: 0x00003EF0
		private static object[][] ReadObjectArrayArray(Object Data)
		{
			Array array = Data.Cast<Array>();
			int length = array.Length;
			object[][] array2 = new object[length][];
			for (int i = 0; i < length; i++)
			{
				array2[i] = Class0.Class2.ReadObjectArray(array.GetValue(i));
			}
			return array2;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000239E File Offset: 0x0000059E
		internal static bool mAPlk79TAguphKA10Fv()
		{
			return Class0.Class2.Pe97q89adrScCiFjJa3 == null;
		}

		// Token: 0x04000007 RID: 7
		private static Class0.Class2 Pe97q89adrScCiFjJa3;
	}
}
