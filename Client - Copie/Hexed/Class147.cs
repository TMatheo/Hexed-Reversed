using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

// Token: 0x02000176 RID: 374
internal class Class147
{
	// Token: 0x060007C7 RID: 1991 RVA: 0x00003B1E File Offset: 0x00001D1E
	internal static object[] smethod_0()
	{
		return new object[1];
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x000275E8 File Offset: 0x000257E8
	internal static object[] smethod_1<T>(int int_1, object[] object_1, object object_2, ref T gparam_0)
	{
		Class147.Class153 @class = null;
		object obj = Class147.object_0;
		lock (obj)
		{
			if (!Class147.bool_0)
			{
				Class147.bool_0 = true;
				Class147.smethod_4();
			}
			if (Class147.class153_0[int_1] != null)
			{
				@class = Class147.class153_0[int_1];
			}
			else
			{
				Class147.binaryReader_0.BaseStream.Position = (long)Class147.int_0[int_1];
				@class = new Class147.Class153();
				Module module = typeof(Class147).Module;
				int metadataToken = Class147.smethod_6(Class147.binaryReader_0);
				int num = Class147.smethod_6(Class147.binaryReader_0);
				int num2 = Class147.smethod_6(Class147.binaryReader_0);
				int num3 = Class147.smethod_6(Class147.binaryReader_0);
				@class.methodBase_0 = module.ResolveMethod(metadataToken);
				ParameterInfo[] parameters = @class.methodBase_0.GetParameters();
				@class.class149_0 = new Class147.Class149[parameters.Length];
				for (int i = 0; i < parameters.Length; i++)
				{
					Type type = parameters[i].ParameterType;
					Class147.Class149 class2 = new Class147.Class149();
					class2.bool_0 = type.IsByRef;
					class2.int_0 = i;
					@class.class149_0[i] = class2;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					Class147.Enum0 enum0_;
					if (type == typeof(string))
					{
						enum0_ = (Class147.Enum0)14;
					}
					else if (type == typeof(byte))
					{
						enum0_ = (Class147.Enum0)2;
					}
					else if (type == typeof(sbyte))
					{
						enum0_ = (Class147.Enum0)1;
					}
					else if (type == typeof(short))
					{
						enum0_ = (Class147.Enum0)3;
					}
					else if (type == typeof(ushort))
					{
						enum0_ = (Class147.Enum0)4;
					}
					else if (type == typeof(int))
					{
						enum0_ = (Class147.Enum0)5;
					}
					else if (type == typeof(uint))
					{
						enum0_ = (Class147.Enum0)6;
					}
					else if (type == typeof(long))
					{
						enum0_ = (Class147.Enum0)7;
					}
					else if (type == typeof(ulong))
					{
						enum0_ = (Class147.Enum0)8;
					}
					else if (type == typeof(float))
					{
						enum0_ = (Class147.Enum0)9;
					}
					else if (type == typeof(double))
					{
						enum0_ = (Class147.Enum0)10;
					}
					else if (type == typeof(bool))
					{
						enum0_ = (Class147.Enum0)11;
					}
					else if (type == typeof(IntPtr))
					{
						enum0_ = (Class147.Enum0)12;
					}
					else if (type == typeof(UIntPtr))
					{
						enum0_ = (Class147.Enum0)13;
					}
					else if (type == typeof(char))
					{
						enum0_ = (Class147.Enum0)15;
					}
					else
					{
						enum0_ = (Class147.Enum0)0;
					}
					class2.enum0_0 = enum0_;
				}
				@class.list_1 = new List<Class147.Class150>(num);
				for (int j = 0; j < num; j++)
				{
					int num4 = Class147.smethod_6(Class147.binaryReader_0);
					Class147.Class150 class3 = new Class147.Class150();
					class3.type_0 = null;
					if (num4 >= 0 && num4 < 50)
					{
						class3.enum0_0 = (Class147.Enum0)(num4 & 31);
						class3.bool_0 = ((num4 & 32) > 0);
					}
					class3.int_0 = j;
					@class.list_1.Add(class3);
				}
				@class.list_2 = new List<Class147.Class151>(num2);
				for (int k = 0; k < num2; k++)
				{
					int num5 = Class147.smethod_6(Class147.binaryReader_0);
					int int_2 = Class147.smethod_6(Class147.binaryReader_0);
					Class147.Class151 class4 = new Class147.Class151();
					class4.int_0 = num5;
					class4.int_1 = int_2;
					Class147.Class152 class5 = new Class147.Class152();
					class4.class152_0 = class5;
					num5 = Class147.smethod_6(Class147.binaryReader_0);
					int_2 = Class147.smethod_6(Class147.binaryReader_0);
					int num6 = Class147.smethod_6(Class147.binaryReader_0);
					class5.int_0 = num5;
					class5.int_1 = int_2;
					class5.int_3 = num6;
					if (num6 == 0)
					{
						class5.type_0 = module.ResolveType(Class147.smethod_6(Class147.binaryReader_0));
					}
					else if (num6 == 1)
					{
						class5.int_2 = Class147.smethod_6(Class147.binaryReader_0);
					}
					else
					{
						Class147.smethod_6(Class147.binaryReader_0);
					}
					@class.list_2.Add(class4);
				}
				@class.list_2.Sort(new Comparison<Class147.Class151>(Class147.Class173<T>.<>9.method_0));
				@class.list_0 = new List<Class147.Class148>(num3);
				for (int l = 0; l < num3; l++)
				{
					Class147.Class148 class6 = new Class147.Class148();
					byte b = Class147.binaryReader_0.ReadByte();
					class6.enum2_0 = (Class147.Enum2)b;
					if (b >= 176)
					{
						throw new Exception();
					}
					int num7 = (int)Class147.byte_0[(int)b];
					if (num7 == 0)
					{
						class6.object_0 = null;
					}
					else
					{
						object obj2;
						switch (num7)
						{
						case 1:
							obj2 = Class147.smethod_6(Class147.binaryReader_0);
							break;
						case 2:
							obj2 = Class147.binaryReader_0.ReadInt64();
							break;
						case 3:
							obj2 = Class147.binaryReader_0.ReadSingle();
							break;
						case 4:
							obj2 = Class147.binaryReader_0.ReadDouble();
							break;
						case 5:
						{
							int num8 = Class147.smethod_6(Class147.binaryReader_0);
							int[] array = new int[num8];
							for (int m = 0; m < num8; m++)
							{
								array[m] = Class147.smethod_6(Class147.binaryReader_0);
							}
							obj2 = array;
							break;
						}
						default:
							throw new Exception();
						}
						class6.object_0 = obj2;
					}
					@class.list_0.Add(class6);
				}
				Class147.class153_0[int_1] = @class;
			}
		}
		Class147.Class156 class7 = new Class147.Class156();
		class7.class153_0 = @class;
		ParameterInfo[] parameters2 = @class.methodBase_0.GetParameters();
		bool flag2 = false;
		int num9 = 0;
		if (@class.methodBase_0 is MethodInfo && ((MethodInfo)@class.methodBase_0).ReturnType != typeof(void))
		{
			flag2 = true;
		}
		if (@class.methodBase_0.IsStatic)
		{
			class7.class158_0 = new Class147.Class158[parameters2.Length];
			for (int n = 0; n < parameters2.Length; n++)
			{
				Type parameterType = parameters2[n].ParameterType;
				class7.class158_0[n] = Class147.Class158.smethod_0(parameterType, object_1[n]);
				if (parameterType.IsByRef)
				{
					num9++;
				}
			}
		}
		else
		{
			class7.class158_0 = new Class147.Class158[parameters2.Length + 1];
			if (@class.methodBase_0.DeclaringType.IsValueType)
			{
				class7.class158_0[0] = new Class147.Class169(new Class147.Class170(object_2), @class.methodBase_0.DeclaringType);
			}
			else
			{
				class7.class158_0[0] = new Class147.Class170(object_2);
			}
			for (int num10 = 0; num10 < parameters2.Length; num10++)
			{
				Type parameterType2 = parameters2[num10].ParameterType;
				if (parameterType2.IsByRef)
				{
					class7.class158_0[num10 + 1] = Class147.Class158.smethod_0(parameterType2, object_1[num10]);
					num9++;
				}
				else
				{
					class7.class158_0[num10 + 1] = Class147.Class158.smethod_0(parameterType2, object_1[num10]);
				}
			}
		}
		class7.class158_1 = new Class147.Class158[@class.list_1.Count];
		for (int num11 = 0; num11 < @class.list_1.Count; num11++)
		{
			Class147.Class150 class8 = @class.list_1[num11];
			switch (class8.enum0_0)
			{
			case (Class147.Enum0)0:
				class7.class158_1[num11] = null;
				break;
			case (Class147.Enum0)1:
			case (Class147.Enum0)2:
			case (Class147.Enum0)3:
			case (Class147.Enum0)4:
			case (Class147.Enum0)5:
			case (Class147.Enum0)6:
			case (Class147.Enum0)11:
			case (Class147.Enum0)15:
				class7.class158_1[num11] = new Class147.Class160(0, class8.enum0_0);
				break;
			case (Class147.Enum0)7:
			case (Class147.Enum0)8:
				class7.class158_1[num11] = new Class147.Class161(0L, class8.enum0_0);
				break;
			case (Class147.Enum0)9:
			case (Class147.Enum0)10:
				class7.class158_1[num11] = new Class147.Class163(0.0, class8.enum0_0);
				break;
			case (Class147.Enum0)12:
				class7.class158_1[num11] = new Class147.Class162(IntPtr.Zero);
				break;
			case (Class147.Enum0)13:
				class7.class158_1[num11] = new Class147.Class162(UIntPtr.Zero);
				break;
			case (Class147.Enum0)14:
				class7.class158_1[num11] = null;
				break;
			case (Class147.Enum0)16:
				class7.class158_1[num11] = new Class147.Class170(null);
				break;
			}
		}
		try
		{
			class7.method_0();
		}
		finally
		{
			class7.method_1();
		}
		int num12 = 0;
		if (flag2)
		{
			num12 = 1;
		}
		num12 += num9;
		object[] array2 = new object[num12];
		if (flag2)
		{
			array2[0] = null;
		}
		if (@class.methodBase_0 is MethodInfo)
		{
			MethodInfo methodInfo = (MethodInfo)@class.methodBase_0;
			if (methodInfo.ReturnType != typeof(void) && class7.class158_2 != null)
			{
				array2[0] = class7.class158_2.vmethod_4(methodInfo.ReturnType);
			}
		}
		if (num9 > 0)
		{
			int num13 = 0;
			if (flag2)
			{
				num13++;
			}
			for (int num14 = 0; num14 < parameters2.Length; num14++)
			{
				Type type2 = parameters2[num14].ParameterType;
				if (type2.IsByRef)
				{
					type2 = type2.GetElementType();
					if (class7.class158_0[num14] != null)
					{
						if (@class.methodBase_0.IsStatic)
						{
							array2[num13] = class7.class158_0[num14].vmethod_4(type2);
						}
						else
						{
							array2[num13] = class7.class158_0[num14 + 1].vmethod_4(type2);
						}
					}
					else
					{
						array2[num13] = null;
					}
					num13++;
				}
			}
		}
		if (!@class.methodBase_0.IsStatic && @class.methodBase_0.DeclaringType.IsValueType)
		{
			gparam_0 = (T)((object)class7.class158_0[0].vmethod_4(@class.methodBase_0.DeclaringType));
		}
		return array2;
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x00027FC8 File Offset: 0x000261C8
	internal static object[] smethod_2(int int_1, object[] object_1, object object_2)
	{
		int num = 0;
		return Class147.smethod_1<int>(int_1, object_1, object_2, ref num);
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x00003B26 File Offset: 0x00001D26
	internal static object[] smethod_3<T>(int int_1, object[] object_1, ref T gparam_0)
	{
		return Class147.smethod_1<T>(int_1, object_1, gparam_0, ref gparam_0);
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x00027FE4 File Offset: 0x000261E4
	internal static void smethod_4()
	{
		if (Class147.int_0 == null)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class147).Assembly.GetManifestResourceStream("wKNM4tiIbcEhlLMtPZ.M9c0j2RNmCgu3SMOlf"));
			binaryReader.BaseStream.Position = 0L;
			byte[] byte_ = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			binaryReader.Close();
			Class147.smethod_5(byte_);
		}
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x0002804C File Offset: 0x0002624C
	internal static void smethod_5(byte[] byte_1)
	{
		Class147.binaryReader_0 = new BinaryReader(new MemoryStream(byte_1));
		Class147.byte_0 = new byte[255];
		int num = Class147.smethod_6(Class147.binaryReader_0);
		for (int i = 0; i < num; i++)
		{
			int num2 = (int)Class147.binaryReader_0.ReadByte();
			Class147.byte_0[num2] = Class147.binaryReader_0.ReadByte();
		}
		num = Class147.smethod_6(Class147.binaryReader_0);
		Class147.list_0 = new List<string>(num);
		for (int j = 0; j < num; j++)
		{
			Class147.list_0.Add(Encoding.Unicode.GetString(Class147.binaryReader_0.ReadBytes(Class147.smethod_6(Class147.binaryReader_0))));
		}
		num = Class147.smethod_6(Class147.binaryReader_0);
		Class147.class153_0 = new Class147.Class153[num];
		Class147.int_0 = new int[num];
		for (int k = 0; k < num; k++)
		{
			Class147.class153_0[k] = null;
			Class147.int_0[k] = Class147.smethod_6(Class147.binaryReader_0);
		}
		int num3 = (int)Class147.binaryReader_0.BaseStream.Position;
		for (int l = 0; l < num; l++)
		{
			int num4 = Class147.int_0[l];
			Class147.int_0[l] = num3;
			num3 += num4;
		}
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x00028194 File Offset: 0x00026394
	internal static int smethod_6(BinaryReader binaryReader_1)
	{
		bool flag = false;
		uint num = (uint)binaryReader_1.ReadByte();
		uint num2 = 0U | (num & 63U);
		if ((num & 64U) != 0U)
		{
			flag = true;
		}
		if (num < 128U)
		{
			if (flag)
			{
				return (int)(~(int)num2);
			}
			return (int)num2;
		}
		else
		{
			int num3 = 0;
			for (;;)
			{
				uint num4 = (uint)binaryReader_1.ReadByte();
				num2 |= (num4 & 127U) << 7 * num3 + 6;
				if (num4 < 128U)
				{
					break;
				}
				num3++;
			}
			if (flag)
			{
				return (int)(~(int)num2);
			}
			return (int)num2;
		}
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x00003B3B File Offset: 0x00001D3B
	internal static bool b5M1mpZodd749pVsVqCe()
	{
		return Class147.BU0u9MZoV38txth9Cm6C == null;
	}

	// Token: 0x040004CB RID: 1227
	internal static Class147.Class153[] class153_0 = null;

	// Token: 0x040004CC RID: 1228
	internal static int[] int_0 = null;

	// Token: 0x040004CD RID: 1229
	internal static List<string> list_0;

	// Token: 0x040004CE RID: 1230
	private static BinaryReader binaryReader_0;

	// Token: 0x040004CF RID: 1231
	private static byte[] byte_0;

	// Token: 0x040004D0 RID: 1232
	private static bool bool_0 = false;

	// Token: 0x040004D1 RID: 1233
	private static object object_0 = new object();

	// Token: 0x040004D2 RID: 1234
	internal static Class147 BU0u9MZoV38txth9Cm6C;

	// Token: 0x02000177 RID: 375
	[StructLayout(LayoutKind.Explicit)]
	public struct Struct3
	{
		// Token: 0x040004D3 RID: 1235
		[FieldOffset(0)]
		public byte byte_0;

		// Token: 0x040004D4 RID: 1236
		[FieldOffset(0)]
		public sbyte sbyte_0;

		// Token: 0x040004D5 RID: 1237
		[FieldOffset(0)]
		public ushort ushort_0;

		// Token: 0x040004D6 RID: 1238
		[FieldOffset(0)]
		public short short_0;

		// Token: 0x040004D7 RID: 1239
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x040004D8 RID: 1240
		[FieldOffset(0)]
		public int int_0;
	}

	// Token: 0x02000178 RID: 376
	private class Class160 : Class147.Class159
	{
		// Token: 0x060007D1 RID: 2001 RVA: 0x0002823C File Offset: 0x0002643C
		internal override void vmethod_10(Class147.Class158 class158_0)
		{
			this.struct3_0 = ((Class147.Class160)class158_0).struct3_0;
			this.enum0_0 = ((Class147.Class160)class158_0).enum0_0;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0002826C File Offset: 0x0002646C
		internal override void vmethod_2(Class147.Class158 class158_0)
		{
			this.vmethod_10(class158_0);
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00028280 File Offset: 0x00026480
		public Class160(bool bool_0)
		{
			this.enum3_0 = (Class147.Enum3)1;
			if (!bool_0)
			{
				this.struct3_0.int_0 = 0;
			}
			else
			{
				this.struct3_0.int_0 = 1;
			}
			this.enum0_0 = (Class147.Enum0)11;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x000282C0 File Offset: 0x000264C0
		public Class160(Class147.Class160 class160_0)
		{
			this.enum3_0 = class160_0.enum3_0;
			this.struct3_0.int_0 = class160_0.struct3_0.int_0;
			this.enum0_0 = class160_0.enum0_0;
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00003B45 File Offset: 0x00001D45
		public override Class147.Class159 vmethod_71()
		{
			return new Class147.Class160(this);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00028304 File Offset: 0x00026504
		public Class160(int int_0)
		{
			this.enum3_0 = (Class147.Enum3)1;
			this.struct3_0.int_0 = int_0;
			this.enum0_0 = (Class147.Enum0)5;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00028334 File Offset: 0x00026534
		public Class160(uint uint_0)
		{
			this.enum3_0 = (Class147.Enum3)1;
			this.struct3_0.uint_0 = uint_0;
			this.enum0_0 = (Class147.Enum0)6;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00028364 File Offset: 0x00026564
		public Class160(int int_0, Class147.Enum0 enum0_1)
		{
			this.enum3_0 = (Class147.Enum3)1;
			this.struct3_0.int_0 = int_0;
			this.enum0_0 = enum0_1;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00028394 File Offset: 0x00026594
		public Class160(uint uint_0, Class147.Enum0 enum0_1)
		{
			this.enum3_0 = (Class147.Enum3)1;
			this.struct3_0.uint_0 = uint_0;
			this.enum0_0 = enum0_1;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000283C4 File Offset: 0x000265C4
		public override bool vmethod_11()
		{
			Class147.Enum0 @enum = this.enum0_0;
			switch (@enum)
			{
			case (Class147.Enum0)1:
			case (Class147.Enum0)3:
			case (Class147.Enum0)5:
			case (Class147.Enum0)7:
				goto IL_4A;
			case (Class147.Enum0)2:
			case (Class147.Enum0)4:
			case (Class147.Enum0)6:
				break;
			default:
				if (@enum == (Class147.Enum0)11)
				{
					goto IL_4A;
				}
				if (@enum == (Class147.Enum0)15)
				{
					goto IL_4A;
				}
				break;
			}
			return this.struct3_0.uint_0 == 0U;
			IL_4A:
			return this.struct3_0.int_0 == 0;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00003B4D File Offset: 0x00001D4D
		public override bool vmethod_12()
		{
			return !this.vmethod_11();
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0002842C File Offset: 0x0002662C
		public override Class147.Class158 vmethod_13(Class147.Enum0 enum0_1)
		{
			switch (enum0_1)
			{
			case (Class147.Enum0)1:
				return this.vmethod_15();
			case (Class147.Enum0)2:
				return this.vmethod_16();
			case (Class147.Enum0)3:
				return this.vmethod_17();
			case (Class147.Enum0)4:
				return this.vmethod_18();
			case (Class147.Enum0)5:
				return this.LtAcwclWeT();
			case (Class147.Enum0)6:
				return this.vmethod_19();
			case (Class147.Enum0)11:
				return this.vmethod_14();
			case (Class147.Enum0)15:
				return this.method_7();
			case (Class147.Enum0)16:
				return this.vmethod_71();
			}
			throw new Exception(((Class147.Enum4)4).ToString());
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x000284D8 File Offset: 0x000266D8
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 != null && Nullable.GetUnderlyingType(type_0) != null)
			{
				type_0 = Nullable.GetUnderlyingType(type_0);
			}
			if (type_0 == null || type_0 == typeof(object))
			{
				switch (this.enum0_0)
				{
				case (Class147.Enum0)1:
					return this.struct3_0.sbyte_0;
				case (Class147.Enum0)2:
					return this.struct3_0.byte_0;
				case (Class147.Enum0)3:
					return this.struct3_0.short_0;
				case (Class147.Enum0)4:
					return this.struct3_0.ushort_0;
				case (Class147.Enum0)5:
					return this.struct3_0.int_0;
				case (Class147.Enum0)6:
					return this.struct3_0.uint_0;
				case (Class147.Enum0)7:
					return (long)this.struct3_0.int_0;
				case (Class147.Enum0)8:
					return (ulong)this.struct3_0.uint_0;
				case (Class147.Enum0)11:
					return this.vmethod_12();
				case (Class147.Enum0)15:
					return (char)this.struct3_0.int_0;
				}
				return this.struct3_0.int_0;
			}
			if (type_0 == typeof(int))
			{
				return this.struct3_0.int_0;
			}
			if (type_0 == typeof(uint))
			{
				return this.struct3_0.uint_0;
			}
			if (type_0 == typeof(short))
			{
				return this.struct3_0.short_0;
			}
			if (type_0 == typeof(ushort))
			{
				return this.struct3_0.ushort_0;
			}
			if (type_0 == typeof(byte))
			{
				return this.struct3_0.byte_0;
			}
			if (type_0 == typeof(sbyte))
			{
				return this.struct3_0.sbyte_0;
			}
			if (type_0 == typeof(bool))
			{
				return !this.vmethod_11();
			}
			if (type_0 == typeof(long))
			{
				return (long)this.struct3_0.int_0;
			}
			if (type_0 == typeof(ulong))
			{
				return (ulong)this.struct3_0.uint_0;
			}
			if (type_0 == typeof(char))
			{
				return (char)this.struct3_0.int_0;
			}
			if (type_0 == typeof(IntPtr))
			{
				return new IntPtr(this.struct3_0.int_0);
			}
			if (type_0 == typeof(UIntPtr))
			{
				return new UIntPtr(this.struct3_0.uint_0);
			}
			if (!type_0.IsEnum)
			{
				throw new Class147.Exception1();
			}
			return this.method_6(type_0);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00028828 File Offset: 0x00026A28
		internal object method_6(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (underlyingType == typeof(int))
			{
				return Enum.ToObject(type_0, this.struct3_0.int_0);
			}
			if (underlyingType == typeof(uint))
			{
				return Enum.ToObject(type_0, this.struct3_0.uint_0);
			}
			if (underlyingType == typeof(short))
			{
				return Enum.ToObject(type_0, this.struct3_0.short_0);
			}
			if (underlyingType == typeof(ushort))
			{
				return Enum.ToObject(type_0, this.struct3_0.ushort_0);
			}
			if (underlyingType == typeof(byte))
			{
				return Enum.ToObject(type_0, this.struct3_0.byte_0);
			}
			if (underlyingType == typeof(sbyte))
			{
				return Enum.ToObject(type_0, this.struct3_0.sbyte_0);
			}
			if (underlyingType == typeof(long))
			{
				return Enum.ToObject(type_0, (long)this.struct3_0.int_0);
			}
			if (underlyingType == typeof(ulong))
			{
				return Enum.ToObject(type_0, (ulong)this.struct3_0.uint_0);
			}
			if (!(underlyingType == typeof(char)))
			{
				return Enum.ToObject(type_0, this.struct3_0.int_0);
			}
			return Enum.ToObject(type_0, (ushort)this.struct3_0.int_0);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00003B58 File Offset: 0x00001D58
		public override Class147.Class160 vmethod_14()
		{
			return new Class147.Class160((!this.vmethod_11()) ? 1 : 0);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00003B68 File Offset: 0x00001D68
		internal override bool vmethod_7()
		{
			return this.vmethod_12();
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00003B70 File Offset: 0x00001D70
		public override Class147.Class160 vmethod_15()
		{
			return new Class147.Class160((int)this.struct3_0.sbyte_0, (Class147.Enum0)1);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00003B83 File Offset: 0x00001D83
		public Class147.Class160 method_7()
		{
			return new Class147.Class160(this.struct3_0.int_0, (Class147.Enum0)15);
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00003B97 File Offset: 0x00001D97
		public override Class147.Class160 vmethod_16()
		{
			return new Class147.Class160((uint)this.struct3_0.byte_0, (Class147.Enum0)2);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00003BAA File Offset: 0x00001DAA
		public override Class147.Class160 vmethod_17()
		{
			return new Class147.Class160((int)this.struct3_0.short_0, (Class147.Enum0)3);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00003BBD File Offset: 0x00001DBD
		public override Class147.Class160 vmethod_18()
		{
			return new Class147.Class160((uint)this.struct3_0.ushort_0, (Class147.Enum0)4);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00003BD0 File Offset: 0x00001DD0
		public override Class147.Class160 LtAcwclWeT()
		{
			return new Class147.Class160(this.struct3_0.int_0, (Class147.Enum0)5);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00003BE3 File Offset: 0x00001DE3
		public override Class147.Class160 vmethod_19()
		{
			return new Class147.Class160(this.struct3_0.uint_0, (Class147.Enum0)6);
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00003BF6 File Offset: 0x00001DF6
		public override Class147.Class161 vmethod_20()
		{
			return new Class147.Class161((long)this.struct3_0.int_0, (Class147.Enum0)7);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00003C0A File Offset: 0x00001E0A
		public override Class147.Class161 vmethod_21()
		{
			return new Class147.Class161((ulong)this.struct3_0.uint_0, (Class147.Enum0)8);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00003C1E File Offset: 0x00001E1E
		public override Class147.Class160 vmethod_22()
		{
			return this.vmethod_15();
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00003C26 File Offset: 0x00001E26
		public override Class147.Class160 vmethod_23()
		{
			return this.vmethod_17();
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00003C2E File Offset: 0x00001E2E
		public override Class147.Class160 vmethod_24()
		{
			return this.LtAcwclWeT();
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00003C36 File Offset: 0x00001E36
		public override Class147.Class161 vmethod_25()
		{
			return this.vmethod_20();
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00003C3E File Offset: 0x00001E3E
		public override Class147.Class160 vmethod_26()
		{
			return this.vmethod_16();
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00003C46 File Offset: 0x00001E46
		public override Class147.Class160 vmethod_27()
		{
			return this.vmethod_18();
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00003C4E File Offset: 0x00001E4E
		public override Class147.Class160 vmethod_28()
		{
			return this.vmethod_19();
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00003C56 File Offset: 0x00001E56
		public override Class147.Class161 vmethod_29()
		{
			return this.vmethod_21();
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00003C5E File Offset: 0x00001E5E
		public override Class147.Class160 tPncmNfto2()
		{
			return new Class147.Class160((int)(checked((sbyte)this.struct3_0.int_0)), (Class147.Enum0)1);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00003C72 File Offset: 0x00001E72
		public override Class147.Class160 vmethod_30()
		{
			return new Class147.Class160((int)(checked((sbyte)this.struct3_0.uint_0)), (Class147.Enum0)1);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00003C86 File Offset: 0x00001E86
		public override Class147.Class160 vmethod_31()
		{
			return new Class147.Class160((int)(checked((short)this.struct3_0.int_0)), (Class147.Enum0)3);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00003C9A File Offset: 0x00001E9A
		public override Class147.Class160 vmethod_32()
		{
			return new Class147.Class160((int)(checked((short)this.struct3_0.uint_0)), (Class147.Enum0)3);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00003BD0 File Offset: 0x00001DD0
		public override Class147.Class160 vmethod_33()
		{
			return new Class147.Class160(this.struct3_0.int_0, (Class147.Enum0)5);
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00003CAE File Offset: 0x00001EAE
		public override Class147.Class160 vmethod_34()
		{
			return new Class147.Class160(checked((int)this.struct3_0.uint_0), (Class147.Enum0)5);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00003BF6 File Offset: 0x00001DF6
		public override Class147.Class161 vmethod_35()
		{
			return new Class147.Class161((long)this.struct3_0.int_0, (Class147.Enum0)7);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00003CC2 File Offset: 0x00001EC2
		public override Class147.Class161 vmethod_36()
		{
			return new Class147.Class161((long)((ulong)this.struct3_0.uint_0), (Class147.Enum0)7);
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00003CD6 File Offset: 0x00001ED6
		public override Class147.Class160 vmethod_37()
		{
			return new Class147.Class160((int)(checked((byte)this.struct3_0.int_0)), (Class147.Enum0)2);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00003CEA File Offset: 0x00001EEA
		public override Class147.Class160 vmethod_38()
		{
			return new Class147.Class160((int)(checked((byte)this.struct3_0.uint_0)), (Class147.Enum0)2);
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00003CFE File Offset: 0x00001EFE
		public override Class147.Class160 vmethod_39()
		{
			return new Class147.Class160((int)(checked((ushort)this.struct3_0.int_0)), (Class147.Enum0)4);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00003D12 File Offset: 0x00001F12
		public override Class147.Class160 vmethod_40()
		{
			return new Class147.Class160((int)(checked((ushort)this.struct3_0.uint_0)), (Class147.Enum0)4);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00003D26 File Offset: 0x00001F26
		public override Class147.Class160 vmethod_41()
		{
			return new Class147.Class160(checked((uint)this.struct3_0.int_0), (Class147.Enum0)6);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00003BE3 File Offset: 0x00001DE3
		public override Class147.Class160 vmethod_42()
		{
			return new Class147.Class160(this.struct3_0.uint_0, (Class147.Enum0)6);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00003D3A File Offset: 0x00001F3A
		public override Class147.Class161 vmethod_43()
		{
			return new Class147.Class161(checked((ulong)this.struct3_0.int_0), (Class147.Enum0)8);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00003C0A File Offset: 0x00001E0A
		public override Class147.Class161 vmethod_44()
		{
			return new Class147.Class161((ulong)this.struct3_0.uint_0, (Class147.Enum0)8);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00003D4E File Offset: 0x00001F4E
		public override Class147.Class163 vmethod_45()
		{
			return new Class147.Class163((float)this.struct3_0.int_0);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00003D61 File Offset: 0x00001F61
		public override Class147.Class163 vmethod_46()
		{
			return new Class147.Class163((double)this.struct3_0.int_0);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00003D74 File Offset: 0x00001F74
		public override Class147.Class163 vmethod_47()
		{
			return new Class147.Class163(this.struct3_0.uint_0);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000289B0 File Offset: 0x00026BB0
		public override Class147.Class162 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_25().struct4_0.long_0);
			}
			return new Class147.Class162((long)this.vmethod_24().struct3_0.int_0);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000289F4 File Offset: 0x00026BF4
		public override Class147.Class162 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_29().struct4_0.ulong_0);
			}
			return new Class147.Class162((ulong)this.vmethod_28().struct3_0.uint_0);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00028A38 File Offset: 0x00026C38
		public override Class147.Class162 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_35().struct4_0.long_0);
			}
			return new Class147.Class162((long)this.vmethod_33().struct3_0.int_0);
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00028A7C File Offset: 0x00026C7C
		public override Class147.Class162 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_43().struct4_0.ulong_0);
			}
			return new Class147.Class162((ulong)this.vmethod_41().struct3_0.uint_0);
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00028AC0 File Offset: 0x00026CC0
		public override Class147.Class162 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_36().struct4_0.long_0);
			}
			return new Class147.Class162((long)this.vmethod_34().struct3_0.int_0);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00028B04 File Offset: 0x00026D04
		public override Class147.Class162 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_44().struct4_0.ulong_0);
			}
			return new Class147.Class162((ulong)this.vmethod_42().struct3_0.uint_0);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00028B48 File Offset: 0x00026D48
		public override Class147.Class158 vmethod_54()
		{
			Class147.Enum0 @enum = this.enum0_0;
			switch (@enum)
			{
			case (Class147.Enum0)1:
			case (Class147.Enum0)3:
			case (Class147.Enum0)5:
				goto IL_47;
			case (Class147.Enum0)2:
			case (Class147.Enum0)4:
				break;
			default:
				if (@enum == (Class147.Enum0)11)
				{
					goto IL_47;
				}
				if (@enum == (Class147.Enum0)15)
				{
					goto IL_47;
				}
				break;
			}
			return new Class147.Class160((int)(-(int)((ulong)this.struct3_0.uint_0)));
			IL_47:
			return new Class147.Class160(-this.struct3_0.int_0);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00028BB0 File Offset: 0x00026DB0
		public override Class147.Class158 Add(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(this.struct3_0.int_0 + ((Class147.Class160)class158_0).struct3_0.int_0);
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).Add(this);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00028C14 File Offset: 0x00026E14
		public override Class147.Class158 vmethod_55(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(checked(this.struct3_0.int_0 + ((Class147.Class160)class158_0).struct3_0.int_0));
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).vmethod_55(this);
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00028C78 File Offset: 0x00026E78
		public override Class147.Class158 vmethod_56(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(checked(this.struct3_0.uint_0 + ((Class147.Class160)class158_0).struct3_0.uint_0));
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).vmethod_56(this);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00028CDC File Offset: 0x00026EDC
		public override Class147.Class158 vmethod_57(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(this.struct3_0.int_0 - ((Class147.Class160)class158_0).struct3_0.int_0);
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).method_8(this);
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00028D40 File Offset: 0x00026F40
		public override Class147.Class158 vmethod_58(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(checked(this.struct3_0.int_0 - ((Class147.Class160)class158_0).struct3_0.int_0));
			}
			if (class158_0.method_2())
			{
				return ((Class147.Class162)class158_0).method_9(this);
			}
			throw new Class147.Exception1();
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00028DA4 File Offset: 0x00026FA4
		public override Class147.Class158 vmethod_59(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(checked(this.struct3_0.uint_0 - ((Class147.Class160)class158_0).struct3_0.uint_0));
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).method_10(this);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00028E08 File Offset: 0x00027008
		public override Class147.Class158 vmethod_60(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(this.struct3_0.int_0 * ((Class147.Class160)class158_0).struct3_0.int_0);
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).vmethod_60(this);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00028E6C File Offset: 0x0002706C
		public override Class147.Class158 vmethod_61(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(checked(this.struct3_0.int_0 * ((Class147.Class160)class158_0).struct3_0.int_0));
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).vmethod_61(this);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00028ED0 File Offset: 0x000270D0
		public override Class147.Class158 vmethod_62(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(checked(this.struct3_0.uint_0 * ((Class147.Class160)class158_0).struct3_0.uint_0));
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).vmethod_62(this);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00028F34 File Offset: 0x00027134
		public override Class147.Class158 vmethod_63(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(this.struct3_0.int_0 / ((Class147.Class160)class158_0).struct3_0.int_0);
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).method_11(this);
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00028F98 File Offset: 0x00027198
		public override Class147.Class158 vmethod_64(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(this.struct3_0.uint_0 / ((Class147.Class160)class158_0).struct3_0.uint_0);
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).method_12(this);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00028FFC File Offset: 0x000271FC
		public override Class147.Class158 vmethod_65(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(this.struct3_0.int_0 % ((Class147.Class160)class158_0).struct3_0.int_0);
			}
			if (class158_0.method_2())
			{
				return ((Class147.Class162)class158_0).method_13(this);
			}
			throw new Class147.Exception1();
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00029060 File Offset: 0x00027260
		public override Class147.Class158 vmethod_66(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(this.struct3_0.uint_0 % ((Class147.Class160)class158_0).struct3_0.uint_0);
			}
			if (class158_0.method_2())
			{
				return ((Class147.Class162)class158_0).method_14(this);
			}
			throw new Class147.Exception1();
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x000290C4 File Offset: 0x000272C4
		public override Class147.Class158 vmethod_67(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(this.struct3_0.int_0 & ((Class147.Class160)class158_0).struct3_0.int_0);
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).vmethod_67(this);
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00029128 File Offset: 0x00027328
		public override Class147.Class158 vmethod_68(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(this.struct3_0.int_0 | ((Class147.Class160)class158_0).struct3_0.int_0);
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).vmethod_68(this);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00003D88 File Offset: 0x00001F88
		public override Class147.Class158 vmethod_69()
		{
			return new Class147.Class160(~this.struct3_0.int_0);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0002918C File Offset: 0x0002738C
		public override Class147.Class158 vmethod_70(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(this.struct3_0.int_0 ^ ((Class147.Class160)class158_0).struct3_0.int_0);
			}
			if (class158_0.method_2())
			{
				return ((Class147.Class162)class158_0).vmethod_70(this);
			}
			throw new Class147.Exception1();
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000291F0 File Offset: 0x000273F0
		public override Class147.Class158 vmethod_72(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(this.struct3_0.int_0 << ((Class147.Class160)class158_0).struct3_0.int_0);
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).method_17(this);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00029254 File Offset: 0x00027454
		public override Class147.Class158 vmethod_73(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(this.struct3_0.int_0 >> ((Class147.Class160)class158_0).struct3_0.int_0);
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).method_16(this);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x000292B8 File Offset: 0x000274B8
		public override Class147.Class158 vmethod_74(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return new Class147.Class160(this.struct3_0.uint_0 >> ((Class147.Class160)class158_0).struct3_0.int_0);
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).method_15(this);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0002931C File Offset: 0x0002751C
		public override string ToString()
		{
			Class147.Enum0 @enum = this.enum0_0;
			switch (@enum)
			{
			case (Class147.Enum0)1:
			case (Class147.Enum0)3:
			case (Class147.Enum0)5:
				goto IL_3E;
			case (Class147.Enum0)2:
			case (Class147.Enum0)4:
				break;
			default:
				if (@enum == (Class147.Enum0)11)
				{
					goto IL_3E;
				}
				break;
			}
			return this.struct3_0.uint_0.ToString();
			IL_3E:
			return this.struct3_0.int_0.ToString();
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00003D9B File Offset: 0x00001F9B
		internal override Class147.Class158 vmethod_8()
		{
			return this;
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00003D9E File Offset: 0x00001F9E
		internal override bool vmethod_9()
		{
			return true;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00029378 File Offset: 0x00027578
		internal override bool vmethod_5(Class147.Class158 class158_0)
		{
			if (class158_0.method_0())
			{
				return ((Class147.Class170)class158_0).vmethod_5(this);
			}
			if (class158_0.vmethod_0())
			{
				return ((Class147.Class164)class158_0).vmethod_5(this);
			}
			Class147.Class158 @class = class158_0.vmethod_8();
			if (!@class.vmethod_9())
			{
				return false;
			}
			if (@class.method_3())
			{
				return false;
			}
			if (@class.method_1())
			{
				return this.struct3_0.int_0 == ((Class147.Class160)@class).struct3_0.int_0;
			}
			return ((Class147.Class162)@class).vmethod_5(this);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00029404 File Offset: 0x00027604
		private static Class147.Class159 smethod_3(Class147.Class158 class158_0)
		{
			Class147.Class159 @class = class158_0 as Class147.Class159;
			if (@class == null && class158_0.vmethod_0())
			{
				@class = (class158_0.vmethod_8() as Class147.Class159);
			}
			return @class;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00029434 File Offset: 0x00027634
		internal override bool vmethod_6(Class147.Class158 class158_0)
		{
			if (class158_0.method_0())
			{
				return false;
			}
			if (class158_0.vmethod_0())
			{
				return ((Class147.Class164)class158_0).vmethod_6(this);
			}
			Class147.Class158 @class = class158_0.vmethod_8();
			if (!@class.vmethod_9())
			{
				return false;
			}
			if (@class.method_3())
			{
				return false;
			}
			if (!@class.method_1())
			{
				return ((Class147.Class162)@class).vmethod_6(this);
			}
			return this.struct3_0.uint_0 != ((Class147.Class160)@class).struct3_0.uint_0;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000294B8 File Offset: 0x000276B8
		public override bool vmethod_75(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return this.struct3_0.int_0 >= ((Class147.Class160)class158_0).struct3_0.int_0;
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).vmethod_79(this);
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00029518 File Offset: 0x00027718
		public override bool vmethod_76(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return this.struct3_0.uint_0 >= ((Class147.Class160)class158_0).struct3_0.uint_0;
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).vmethod_80(this);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00029578 File Offset: 0x00027778
		public override bool vmethod_77(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return this.struct3_0.int_0 > ((Class147.Class160)class158_0).struct3_0.int_0;
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).vmethod_81(this);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x000295D8 File Offset: 0x000277D8
		public override bool vmethod_78(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return this.struct3_0.uint_0 > ((Class147.Class160)class158_0).struct3_0.uint_0;
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).vmethod_82(this);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00029638 File Offset: 0x00027838
		public override bool vmethod_79(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return this.struct3_0.int_0 <= ((Class147.Class160)class158_0).struct3_0.int_0;
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).vmethod_75(this);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00029698 File Offset: 0x00027898
		public override bool vmethod_80(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return this.struct3_0.uint_0 <= ((Class147.Class160)class158_0).struct3_0.uint_0;
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).vmethod_76(this);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x000296F8 File Offset: 0x000278F8
		public override bool vmethod_81(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return this.struct3_0.int_0 < ((Class147.Class160)class158_0).struct3_0.int_0;
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).vmethod_77(this);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00029758 File Offset: 0x00027958
		public override bool vmethod_82(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				return this.struct3_0.uint_0 < ((Class147.Class160)class158_0).struct3_0.uint_0;
			}
			if (!class158_0.method_2())
			{
				throw new Class147.Exception1();
			}
			return ((Class147.Class162)class158_0).vmethod_78(this);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00003DA1 File Offset: 0x00001FA1
		internal static bool WN5pkAZoCMIOnvjoPaMX()
		{
			return Class147.Class160.p3Am0HZoBu0Sqwv0b2MN == null;
		}

		// Token: 0x040004D9 RID: 1241
		public Class147.Struct3 struct3_0;

		// Token: 0x040004DA RID: 1242
		public Class147.Enum0 enum0_0;

		// Token: 0x040004DB RID: 1243
		private static Class147.Class160 p3Am0HZoBu0Sqwv0b2MN;
	}

	// Token: 0x02000179 RID: 377
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct4
	{
		// Token: 0x040004DC RID: 1244
		[FieldOffset(0)]
		public byte byte_0;

		// Token: 0x040004DD RID: 1245
		[FieldOffset(0)]
		public sbyte sbyte_0;

		// Token: 0x040004DE RID: 1246
		[FieldOffset(0)]
		public ushort pocFquVkyD;

		// Token: 0x040004DF RID: 1247
		[FieldOffset(0)]
		public short short_0;

		// Token: 0x040004E0 RID: 1248
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x040004E1 RID: 1249
		[FieldOffset(0)]
		public int int_0;

		// Token: 0x040004E2 RID: 1250
		[FieldOffset(0)]
		public ulong ulong_0;

		// Token: 0x040004E3 RID: 1251
		[FieldOffset(0)]
		public long long_0;
	}

	// Token: 0x0200017A RID: 378
	private class Class161 : Class147.Class159
	{
		// Token: 0x0600082F RID: 2095 RVA: 0x000297B8 File Offset: 0x000279B8
		internal override void vmethod_10(Class147.Class158 class158_0)
		{
			this.struct4_0 = ((Class147.Class161)class158_0).struct4_0;
			this.enum0_0 = ((Class147.Class161)class158_0).enum0_0;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0002826C File Offset: 0x0002646C
		internal override void vmethod_2(Class147.Class158 class158_0)
		{
			this.vmethod_10(class158_0);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000297E8 File Offset: 0x000279E8
		public Class161(long long_0)
		{
			this.enum3_0 = (Class147.Enum3)2;
			this.struct4_0.long_0 = long_0;
			this.enum0_0 = (Class147.Enum0)7;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00029818 File Offset: 0x00027A18
		public Class161(Class147.Class161 class161_0)
		{
			this.enum3_0 = class161_0.enum3_0;
			this.struct4_0.long_0 = class161_0.struct4_0.long_0;
			this.enum0_0 = class161_0.enum0_0;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00003DAB File Offset: 0x00001FAB
		public override Class147.Class159 vmethod_71()
		{
			return new Class147.Class161(this);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0002985C File Offset: 0x00027A5C
		public Class161(long long_0, Class147.Enum0 enum0_1)
		{
			this.enum3_0 = (Class147.Enum3)2;
			this.struct4_0.long_0 = long_0;
			this.enum0_0 = enum0_1;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0002988C File Offset: 0x00027A8C
		public Class161(ulong ulong_0)
		{
			this.enum3_0 = (Class147.Enum3)2;
			this.struct4_0.ulong_0 = ulong_0;
			this.enum0_0 = (Class147.Enum0)8;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000298BC File Offset: 0x00027ABC
		public Class161(ulong ulong_0, Class147.Enum0 enum0_1)
		{
			this.enum3_0 = (Class147.Enum3)2;
			this.struct4_0.ulong_0 = ulong_0;
			this.enum0_0 = enum0_1;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x000298EC File Offset: 0x00027AEC
		public override bool vmethod_11()
		{
			if (this.enum0_0 == (Class147.Enum0)7)
			{
				return this.struct4_0.long_0 == 0L;
			}
			return this.struct4_0.ulong_0 == 0UL;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00003B4D File Offset: 0x00001D4D
		public override bool vmethod_12()
		{
			return !this.vmethod_11();
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00029930 File Offset: 0x00027B30
		public override Class147.Class158 vmethod_13(Class147.Enum0 enum0_1)
		{
			switch (enum0_1)
			{
			case (Class147.Enum0)1:
				return this.vmethod_15();
			case (Class147.Enum0)2:
				return this.vmethod_16();
			case (Class147.Enum0)3:
				return this.vmethod_17();
			case (Class147.Enum0)4:
				return this.vmethod_18();
			case (Class147.Enum0)5:
				return this.LtAcwclWeT();
			case (Class147.Enum0)6:
				return this.vmethod_19();
			case (Class147.Enum0)7:
				return this.vmethod_20();
			case (Class147.Enum0)8:
				return this.vmethod_21();
			case (Class147.Enum0)11:
				return this.vmethod_14();
			case (Class147.Enum0)15:
				return this.method_7();
			case (Class147.Enum0)16:
				return this.vmethod_71();
			}
			throw new Exception(((Class147.Enum4)4).ToString());
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x000299EC File Offset: 0x00027BEC
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == null || type_0 == typeof(object))
			{
				switch (this.enum0_0)
				{
				case (Class147.Enum0)1:
					return this.struct4_0.sbyte_0;
				case (Class147.Enum0)2:
					return this.struct4_0.byte_0;
				case (Class147.Enum0)3:
					return this.struct4_0.short_0;
				case (Class147.Enum0)4:
					return this.struct4_0.pocFquVkyD;
				case (Class147.Enum0)5:
					return this.struct4_0.int_0;
				case (Class147.Enum0)6:
					return this.struct4_0.uint_0;
				case (Class147.Enum0)7:
					return this.struct4_0.long_0;
				case (Class147.Enum0)8:
					return this.struct4_0.ulong_0;
				case (Class147.Enum0)11:
					return this.vmethod_12();
				case (Class147.Enum0)15:
					return (char)this.struct4_0.int_0;
				}
				return this.struct4_0.long_0;
			}
			if (type_0 == typeof(int))
			{
				return this.struct4_0.int_0;
			}
			if (type_0 == typeof(uint))
			{
				return this.struct4_0.uint_0;
			}
			if (type_0 == typeof(short))
			{
				return this.struct4_0.short_0;
			}
			if (type_0 == typeof(ushort))
			{
				return this.struct4_0.pocFquVkyD;
			}
			if (type_0 == typeof(byte))
			{
				return this.struct4_0.byte_0;
			}
			if (type_0 == typeof(sbyte))
			{
				return this.struct4_0.sbyte_0;
			}
			if (type_0 == typeof(bool))
			{
				return !this.vmethod_11();
			}
			if (type_0 == typeof(long))
			{
				return this.struct4_0.long_0;
			}
			if (type_0 == typeof(ulong))
			{
				return this.struct4_0.ulong_0;
			}
			if (type_0 == typeof(char))
			{
				return (char)this.struct4_0.long_0;
			}
			if (!type_0.IsEnum)
			{
				throw new Class147.Exception1();
			}
			return this.method_6(type_0);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00029CC0 File Offset: 0x00027EC0
		internal object method_6(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (underlyingType == typeof(int))
			{
				return Enum.ToObject(type_0, this.struct4_0.int_0);
			}
			if (underlyingType == typeof(uint))
			{
				return Enum.ToObject(type_0, this.struct4_0.uint_0);
			}
			if (underlyingType == typeof(short))
			{
				return Enum.ToObject(type_0, this.struct4_0.short_0);
			}
			if (underlyingType == typeof(ushort))
			{
				return Enum.ToObject(type_0, this.struct4_0.pocFquVkyD);
			}
			if (underlyingType == typeof(byte))
			{
				return Enum.ToObject(type_0, this.struct4_0.byte_0);
			}
			if (underlyingType == typeof(sbyte))
			{
				return Enum.ToObject(type_0, this.struct4_0.sbyte_0);
			}
			if (underlyingType == typeof(long))
			{
				return Enum.ToObject(type_0, this.struct4_0.long_0);
			}
			if (underlyingType == typeof(ulong))
			{
				return Enum.ToObject(type_0, this.struct4_0.ulong_0);
			}
			if (!(underlyingType == typeof(char)))
			{
				return Enum.ToObject(type_0, this.struct4_0.long_0);
			}
			return Enum.ToObject(type_0, (ushort)this.struct4_0.int_0);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00003B58 File Offset: 0x00001D58
		public override Class147.Class160 vmethod_14()
		{
			return new Class147.Class160((!this.vmethod_11()) ? 1 : 0);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00003B68 File Offset: 0x00001D68
		internal override bool vmethod_7()
		{
			return this.vmethod_12();
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00003DB3 File Offset: 0x00001FB3
		public Class147.Class160 method_7()
		{
			return new Class147.Class160((int)this.struct4_0.sbyte_0, (Class147.Enum0)15);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00003DC7 File Offset: 0x00001FC7
		public override Class147.Class160 vmethod_15()
		{
			return new Class147.Class160((int)this.struct4_0.sbyte_0, (Class147.Enum0)1);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00003DDA File Offset: 0x00001FDA
		public override Class147.Class160 vmethod_16()
		{
			return new Class147.Class160((uint)this.struct4_0.byte_0, (Class147.Enum0)2);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00003DED File Offset: 0x00001FED
		public override Class147.Class160 vmethod_17()
		{
			return new Class147.Class160((int)this.struct4_0.short_0, (Class147.Enum0)3);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00003E00 File Offset: 0x00002000
		public override Class147.Class160 vmethod_18()
		{
			return new Class147.Class160((uint)this.struct4_0.pocFquVkyD, (Class147.Enum0)4);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00003E13 File Offset: 0x00002013
		public override Class147.Class160 LtAcwclWeT()
		{
			return new Class147.Class160(this.struct4_0.int_0, (Class147.Enum0)5);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00003E26 File Offset: 0x00002026
		public override Class147.Class160 vmethod_19()
		{
			return new Class147.Class160(this.struct4_0.uint_0, (Class147.Enum0)6);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00003E39 File Offset: 0x00002039
		public override Class147.Class161 vmethod_20()
		{
			return new Class147.Class161(this.struct4_0.long_0, (Class147.Enum0)7);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00003E4C File Offset: 0x0000204C
		public override Class147.Class161 vmethod_21()
		{
			return new Class147.Class161(this.struct4_0.ulong_0, (Class147.Enum0)8);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00003C1E File Offset: 0x00001E1E
		public override Class147.Class160 vmethod_22()
		{
			return this.vmethod_15();
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00003C26 File Offset: 0x00001E26
		public override Class147.Class160 vmethod_23()
		{
			return this.vmethod_17();
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00003C2E File Offset: 0x00001E2E
		public override Class147.Class160 vmethod_24()
		{
			return this.LtAcwclWeT();
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00003C36 File Offset: 0x00001E36
		public override Class147.Class161 vmethod_25()
		{
			return this.vmethod_20();
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00003C3E File Offset: 0x00001E3E
		public override Class147.Class160 vmethod_26()
		{
			return this.vmethod_16();
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00003C46 File Offset: 0x00001E46
		public override Class147.Class160 vmethod_27()
		{
			return this.vmethod_18();
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00003C4E File Offset: 0x00001E4E
		public override Class147.Class160 vmethod_28()
		{
			return this.vmethod_19();
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00003C56 File Offset: 0x00001E56
		public override Class147.Class161 vmethod_29()
		{
			return this.vmethod_21();
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00003E5F File Offset: 0x0000205F
		public override Class147.Class160 tPncmNfto2()
		{
			return new Class147.Class160((int)(checked((sbyte)this.struct4_0.long_0)), (Class147.Enum0)1);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00003E73 File Offset: 0x00002073
		public override Class147.Class160 vmethod_30()
		{
			return new Class147.Class160((int)(checked((sbyte)this.struct4_0.ulong_0)), (Class147.Enum0)1);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00003E87 File Offset: 0x00002087
		public override Class147.Class160 vmethod_31()
		{
			return new Class147.Class160((int)(checked((short)this.struct4_0.long_0)), (Class147.Enum0)3);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00003E9B File Offset: 0x0000209B
		public override Class147.Class160 vmethod_32()
		{
			return new Class147.Class160((int)(checked((short)this.struct4_0.ulong_0)), (Class147.Enum0)3);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00003EAF File Offset: 0x000020AF
		public override Class147.Class160 vmethod_33()
		{
			return new Class147.Class160(checked((int)this.struct4_0.long_0), (Class147.Enum0)5);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00003EC3 File Offset: 0x000020C3
		public override Class147.Class160 vmethod_34()
		{
			return new Class147.Class160(checked((int)this.struct4_0.ulong_0), (Class147.Enum0)5);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00003E39 File Offset: 0x00002039
		public override Class147.Class161 vmethod_35()
		{
			return new Class147.Class161(this.struct4_0.long_0, (Class147.Enum0)7);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00003ED7 File Offset: 0x000020D7
		public override Class147.Class161 vmethod_36()
		{
			return new Class147.Class161(checked((long)this.struct4_0.ulong_0), (Class147.Enum0)7);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00003EEB File Offset: 0x000020EB
		public override Class147.Class160 vmethod_37()
		{
			return new Class147.Class160((int)(checked((byte)this.struct4_0.long_0)), (Class147.Enum0)2);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00003EFF File Offset: 0x000020FF
		public override Class147.Class160 vmethod_38()
		{
			return new Class147.Class160((int)(checked((byte)this.struct4_0.ulong_0)), (Class147.Enum0)2);
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00003F13 File Offset: 0x00002113
		public override Class147.Class160 vmethod_39()
		{
			return new Class147.Class160((int)(checked((ushort)this.struct4_0.long_0)), (Class147.Enum0)4);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00003F27 File Offset: 0x00002127
		public override Class147.Class160 vmethod_40()
		{
			return new Class147.Class160((int)(checked((ushort)this.struct4_0.ulong_0)), (Class147.Enum0)4);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00003F3B File Offset: 0x0000213B
		public override Class147.Class160 vmethod_41()
		{
			return new Class147.Class160(checked((uint)this.struct4_0.long_0), (Class147.Enum0)6);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00003F4F File Offset: 0x0000214F
		public override Class147.Class160 vmethod_42()
		{
			return new Class147.Class160(checked((uint)this.struct4_0.ulong_0), (Class147.Enum0)6);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00003F63 File Offset: 0x00002163
		public override Class147.Class161 vmethod_43()
		{
			return new Class147.Class161(checked((ulong)this.struct4_0.long_0), (Class147.Enum0)8);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00003E4C File Offset: 0x0000204C
		public override Class147.Class161 vmethod_44()
		{
			return new Class147.Class161(this.struct4_0.ulong_0, (Class147.Enum0)8);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00003F77 File Offset: 0x00002177
		public override Class147.Class163 vmethod_45()
		{
			return new Class147.Class163((float)this.struct4_0.long_0);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00003F8A File Offset: 0x0000218A
		public override Class147.Class163 vmethod_46()
		{
			return new Class147.Class163((double)this.struct4_0.long_0);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00003F9D File Offset: 0x0000219D
		public override Class147.Class163 vmethod_47()
		{
			return new Class147.Class163(this.struct4_0.ulong_0);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x000289B0 File Offset: 0x00026BB0
		public override Class147.Class162 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_25().struct4_0.long_0);
			}
			return new Class147.Class162((long)this.vmethod_24().struct3_0.int_0);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000289F4 File Offset: 0x00026BF4
		public override Class147.Class162 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_29().struct4_0.ulong_0);
			}
			return new Class147.Class162((ulong)this.vmethod_28().struct3_0.uint_0);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00028A38 File Offset: 0x00026C38
		public override Class147.Class162 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_35().struct4_0.long_0);
			}
			return new Class147.Class162((long)this.vmethod_33().struct3_0.int_0);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00028A7C File Offset: 0x00026C7C
		public override Class147.Class162 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_43().struct4_0.ulong_0);
			}
			return new Class147.Class162((ulong)this.vmethod_41().struct3_0.uint_0);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00028AC0 File Offset: 0x00026CC0
		public override Class147.Class162 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_36().struct4_0.long_0);
			}
			return new Class147.Class162((long)this.vmethod_34().struct3_0.int_0);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00029E48 File Offset: 0x00028048
		public override Class147.Class162 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.struct4_0.ulong_0);
			}
			return new Class147.Class162((ulong)(checked((uint)this.struct4_0.ulong_0)));
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00003FB1 File Offset: 0x000021B1
		public override Class147.Class158 vmethod_54()
		{
			return new Class147.Class161(-this.struct4_0.long_0);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00029E80 File Offset: 0x00028080
		public override Class147.Class158 Add(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(this.struct4_0.long_0 + ((Class147.Class161)class158_0).struct4_0.long_0);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00029ECC File Offset: 0x000280CC
		public override Class147.Class158 vmethod_55(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(checked(this.struct4_0.long_0 + ((Class147.Class161)class158_0).struct4_0.long_0));
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00029F18 File Offset: 0x00028118
		public override Class147.Class158 vmethod_56(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(checked(this.struct4_0.ulong_0 + ((Class147.Class161)class158_0).struct4_0.ulong_0));
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00029F64 File Offset: 0x00028164
		public override Class147.Class158 vmethod_57(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(this.struct4_0.long_0 - ((Class147.Class161)class158_0).struct4_0.long_0);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00029FB0 File Offset: 0x000281B0
		public override Class147.Class158 vmethod_58(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(checked(this.struct4_0.long_0 - ((Class147.Class161)class158_0).struct4_0.long_0));
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00029FFC File Offset: 0x000281FC
		public override Class147.Class158 vmethod_59(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(checked(this.struct4_0.ulong_0 - ((Class147.Class161)class158_0).struct4_0.ulong_0));
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0002A048 File Offset: 0x00028248
		public override Class147.Class158 vmethod_60(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(this.struct4_0.long_0 * ((Class147.Class161)class158_0).struct4_0.long_0);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0002A094 File Offset: 0x00028294
		public override Class147.Class158 vmethod_61(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(checked(this.struct4_0.long_0 * ((Class147.Class161)class158_0).struct4_0.long_0));
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0002A0E0 File Offset: 0x000282E0
		public override Class147.Class158 vmethod_62(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(checked(this.struct4_0.ulong_0 * ((Class147.Class161)class158_0).struct4_0.ulong_0));
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0002A12C File Offset: 0x0002832C
		public override Class147.Class158 vmethod_63(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(this.struct4_0.long_0 / ((Class147.Class161)class158_0).struct4_0.long_0);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0002A178 File Offset: 0x00028378
		public override Class147.Class158 vmethod_64(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(this.struct4_0.ulong_0 / ((Class147.Class161)class158_0).struct4_0.ulong_0);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0002A1C4 File Offset: 0x000283C4
		public override Class147.Class158 vmethod_65(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(this.struct4_0.long_0 % ((Class147.Class161)class158_0).struct4_0.long_0);
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0002A210 File Offset: 0x00028410
		public override Class147.Class158 vmethod_66(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(this.struct4_0.ulong_0 % ((Class147.Class161)class158_0).struct4_0.ulong_0);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0002A25C File Offset: 0x0002845C
		public override Class147.Class158 vmethod_67(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(this.struct4_0.long_0 & ((Class147.Class161)class158_0).struct4_0.long_0);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0002A2A8 File Offset: 0x000284A8
		public override Class147.Class158 vmethod_68(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(this.struct4_0.long_0 | ((Class147.Class161)class158_0).struct4_0.long_0);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00003FC4 File Offset: 0x000021C4
		public override Class147.Class158 vmethod_69()
		{
			return new Class147.Class161(~this.struct4_0.long_0);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0002A2F4 File Offset: 0x000284F4
		public override Class147.Class158 vmethod_70(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(this.struct4_0.long_0 ^ ((Class147.Class161)class158_0).struct4_0.long_0);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0002A340 File Offset: 0x00028540
		public override Class147.Class158 vmethod_72(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_3())
			{
				return new Class147.Class161(this.struct4_0.long_0 << ((Class147.Class161)class158_0).struct4_0.int_0);
			}
			if (!class158_0.vmethod_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(this.struct4_0.long_0 << ((Class147.Class159)class158_0).LtAcwclWeT().struct3_0.int_0);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0002A3C4 File Offset: 0x000285C4
		public override Class147.Class158 vmethod_73(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_3())
			{
				return new Class147.Class161(this.struct4_0.long_0 >> ((Class147.Class161)class158_0).struct4_0.int_0);
			}
			if (!class158_0.vmethod_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(this.struct4_0.long_0 >> ((Class147.Class159)class158_0).LtAcwclWeT().struct3_0.int_0);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0002A448 File Offset: 0x00028648
		public override Class147.Class158 vmethod_74(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_3())
			{
				return new Class147.Class161(this.struct4_0.ulong_0 >> ((Class147.Class161)class158_0).struct4_0.int_0);
			}
			if (!class158_0.vmethod_3())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class161(this.struct4_0.ulong_0 >> ((Class147.Class159)class158_0).LtAcwclWeT().struct3_0.int_0);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0002A4CC File Offset: 0x000286CC
		public override string ToString()
		{
			if (this.enum0_0 == (Class147.Enum0)7)
			{
				return this.struct4_0.long_0.ToString();
			}
			return this.struct4_0.ulong_0.ToString();
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00003D9B File Offset: 0x00001F9B
		internal override Class147.Class158 vmethod_8()
		{
			return this;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00003D9E File Offset: 0x00001F9E
		internal override bool vmethod_9()
		{
			return true;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0002A504 File Offset: 0x00028704
		internal override bool vmethod_5(Class147.Class158 class158_0)
		{
			if (class158_0.method_0())
			{
				return ((Class147.Class170)class158_0).vmethod_5(this);
			}
			if (!class158_0.vmethod_0())
			{
				Class147.Class158 @class = class158_0.vmethod_8();
				return @class.method_3() && this.struct4_0.long_0 == ((Class147.Class161)@class).struct4_0.long_0;
			}
			return ((Class147.Class164)class158_0).vmethod_5(this);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00029404 File Offset: 0x00027604
		private static Class147.Class159 smethod_3(Class147.Class158 class158_0)
		{
			Class147.Class159 @class = class158_0 as Class147.Class159;
			if (@class == null && class158_0.vmethod_0())
			{
				@class = (class158_0.vmethod_8() as Class147.Class159);
			}
			return @class;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0002A56C File Offset: 0x0002876C
		internal override bool vmethod_6(Class147.Class158 class158_0)
		{
			if (class158_0.method_0())
			{
				return false;
			}
			if (class158_0.vmethod_0())
			{
				return ((Class147.Class164)class158_0).vmethod_6(this);
			}
			Class147.Class158 @class = class158_0.vmethod_8();
			return @class.method_3() && this.struct4_0.ulong_0 != ((Class147.Class161)@class).struct4_0.ulong_0;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0002A5CC File Offset: 0x000287CC
		public override bool vmethod_75(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return this.struct4_0.long_0 >= ((Class147.Class161)class158_0).struct4_0.long_0;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0002A618 File Offset: 0x00028818
		public override bool vmethod_76(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return this.struct4_0.ulong_0 >= ((Class147.Class161)class158_0).struct4_0.ulong_0;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0002A664 File Offset: 0x00028864
		public override bool vmethod_77(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return this.struct4_0.long_0 > ((Class147.Class161)class158_0).struct4_0.long_0;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0002A6AC File Offset: 0x000288AC
		public override bool vmethod_78(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return this.struct4_0.ulong_0 > ((Class147.Class161)class158_0).struct4_0.ulong_0;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0002A6F4 File Offset: 0x000288F4
		public override bool vmethod_79(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return this.struct4_0.long_0 <= ((Class147.Class161)class158_0).struct4_0.long_0;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0002A740 File Offset: 0x00028940
		public override bool vmethod_80(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return this.struct4_0.ulong_0 <= ((Class147.Class161)class158_0).struct4_0.ulong_0;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0002A78C File Offset: 0x0002898C
		public override bool vmethod_81(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return this.struct4_0.long_0 < ((Class147.Class161)class158_0).struct4_0.long_0;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0002A7D4 File Offset: 0x000289D4
		public override bool vmethod_82(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_3())
			{
				throw new Class147.Exception1();
			}
			return this.struct4_0.ulong_0 < ((Class147.Class161)class158_0).struct4_0.ulong_0;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00003FD7 File Offset: 0x000021D7
		internal static bool DXymNEZofifAtygqgoh0()
		{
			return Class147.Class161.NchHS1ZoGlsS48Ojt8MA == null;
		}

		// Token: 0x040004E4 RID: 1252
		public Class147.Struct4 struct4_0;

		// Token: 0x040004E5 RID: 1253
		public Class147.Enum0 enum0_0;

		// Token: 0x040004E6 RID: 1254
		private static Class147.Class161 NchHS1ZoGlsS48Ojt8MA;
	}

	// Token: 0x0200017B RID: 379
	private class Class162 : Class147.Class159
	{
		// Token: 0x0600088C RID: 2188 RVA: 0x0002A81C File Offset: 0x00028A1C
		internal void method_6(Class147.Class158 class158_0)
		{
			if (!class158_0.method_2())
			{
				this.vmethod_10(class158_0);
				return;
			}
			this.class159_0 = ((Class147.Class162)class158_0).class159_0;
			this.enum0_0 = ((Class147.Class162)class158_0).enum0_0;
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0002A85C File Offset: 0x00028A5C
		internal unsafe override void vmethod_10(Class147.Class158 class158_0)
		{
			if (class158_0.method_2())
			{
				if (IntPtr.Size == 8)
				{
					IntPtr value = new IntPtr(((Class147.Class161)this.class159_0).struct4_0.long_0);
					IntPtr intPtr = new IntPtr(((Class147.Class161)((Class147.Class162)class158_0).class159_0).struct4_0.long_0);
					*(long*)((void*)value) = intPtr.ToInt64();
					return;
				}
				IntPtr value2 = new IntPtr(((Class147.Class160)this.class159_0).struct3_0.int_0);
				IntPtr intPtr2 = new IntPtr(((Class147.Class160)((Class147.Class162)class158_0).class159_0).struct3_0.int_0);
				*(int*)((void*)value2) = intPtr2.ToInt32();
				return;
			}
			else
			{
				object obj = class158_0.vmethod_4(null);
				if (obj == null)
				{
					return;
				}
				IntPtr value3;
				if (IntPtr.Size == 8)
				{
					value3 = new IntPtr(((Class147.Class161)this.class159_0).struct4_0.long_0);
				}
				else
				{
					value3 = new IntPtr(((Class147.Class160)this.class159_0).struct3_0.int_0);
				}
				Type type = obj.GetType();
				if (type == typeof(string))
				{
					return;
				}
				if (type == typeof(byte))
				{
					*(byte*)((void*)value3) = (byte)obj;
					return;
				}
				if (type == typeof(sbyte))
				{
					*(byte*)((void*)value3) = (byte)((sbyte)obj);
					return;
				}
				if (type == typeof(short))
				{
					*(short*)((void*)value3) = (short)obj;
					return;
				}
				if (type == typeof(ushort))
				{
					*(short*)((void*)value3) = (short)((ushort)obj);
					return;
				}
				if (type == typeof(int))
				{
					*(int*)((void*)value3) = (int)obj;
					return;
				}
				if (type == typeof(uint))
				{
					*(int*)((void*)value3) = (int)((uint)obj);
					return;
				}
				if (type == typeof(long))
				{
					*(long*)((void*)value3) = (long)obj;
					return;
				}
				if (type == typeof(ulong))
				{
					*(long*)((void*)value3) = (long)((ulong)obj);
					return;
				}
				if (type == typeof(float))
				{
					*(float*)((void*)value3) = (float)obj;
					return;
				}
				if (type == typeof(double))
				{
					*(double*)((void*)value3) = (double)obj;
					return;
				}
				if (type == typeof(bool))
				{
					*(byte*)((void*)value3) = (((bool)obj) ? 1 : 0);
					return;
				}
				if (type == typeof(IntPtr))
				{
					*(IntPtr*)((void*)value3) = (IntPtr)obj;
					return;
				}
				if (type == typeof(UIntPtr))
				{
					*(IntPtr*)((void*)value3) = (IntPtr)((UIntPtr)obj);
					return;
				}
				if (type == typeof(char))
				{
					*(short*)((void*)value3) = (short)((char)obj);
					return;
				}
				throw new Class147.Exception1();
			}
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0002826C File Offset: 0x0002646C
		internal override void vmethod_2(Class147.Class158 class158_0)
		{
			this.vmethod_10(class158_0);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0002AB84 File Offset: 0x00028D84
		public Class162(IntPtr intptr_0)
		{
			this.enum3_0 = (Class147.Enum3)3;
			if (IntPtr.Size == 8)
			{
				this.class159_0 = new Class147.Class161(intptr_0.ToInt64());
				this.enum0_0 = (Class147.Enum0)12;
				return;
			}
			this.class159_0 = new Class147.Class160(intptr_0.ToInt32());
			this.enum0_0 = (Class147.Enum0)12;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0002ABDC File Offset: 0x00028DDC
		public Class162(UIntPtr uintptr_0)
		{
			this.enum3_0 = (Class147.Enum3)3;
			if (IntPtr.Size == 8)
			{
				this.class159_0 = new Class147.Class161(uintptr_0.ToUInt64());
				this.enum0_0 = (Class147.Enum0)12;
				return;
			}
			this.class159_0 = new Class147.Class160(uintptr_0.ToUInt32());
			this.enum0_0 = (Class147.Enum0)12;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0002AC34 File Offset: 0x00028E34
		public Class162()
		{
			this.enum3_0 = (Class147.Enum3)3;
			if (IntPtr.Size == 8)
			{
				this.class159_0 = new Class147.Class161(0L);
				this.enum0_0 = (Class147.Enum0)12;
				return;
			}
			this.class159_0 = new Class147.Class160(0);
			this.enum0_0 = (Class147.Enum0)12;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00003FE1 File Offset: 0x000021E1
		public override Class147.Class159 vmethod_71()
		{
			return new Class147.Class162
			{
				class159_0 = this.class159_0.vmethod_71(),
				enum0_0 = this.enum0_0
			};
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0002AC88 File Offset: 0x00028E88
		public Class162(long long_0)
		{
			this.enum3_0 = (Class147.Enum3)3;
			if (IntPtr.Size == 8)
			{
				this.class159_0 = new Class147.Class161(long_0);
				this.enum0_0 = (Class147.Enum0)12;
				return;
			}
			this.class159_0 = new Class147.Class160((int)long_0);
			this.enum0_0 = (Class147.Enum0)12;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0002ACD4 File Offset: 0x00028ED4
		public Class162(long long_0, Class147.Enum0 enum0_1)
		{
			this.enum3_0 = (Class147.Enum3)3;
			if (IntPtr.Size == 8)
			{
				this.class159_0 = new Class147.Class161(long_0);
				this.enum0_0 = enum0_1;
				return;
			}
			this.class159_0 = new Class147.Class160((int)long_0);
			this.enum0_0 = enum0_1;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x0002AD20 File Offset: 0x00028F20
		public Class162(ulong ulong_0)
		{
			this.enum3_0 = (Class147.Enum3)4;
			if (IntPtr.Size == 8)
			{
				this.class159_0 = new Class147.Class161(ulong_0);
				this.enum0_0 = (Class147.Enum0)13;
				return;
			}
			this.class159_0 = new Class147.Class160((uint)ulong_0);
			this.enum0_0 = (Class147.Enum0)13;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0002AD6C File Offset: 0x00028F6C
		public Class162(ulong ulong_0, Class147.Enum0 enum0_1)
		{
			this.enum3_0 = (Class147.Enum3)4;
			if (IntPtr.Size == 8)
			{
				this.class159_0 = new Class147.Class161(ulong_0);
				this.enum0_0 = enum0_1;
				return;
			}
			this.class159_0 = new Class147.Class160((uint)ulong_0);
			this.enum0_0 = enum0_1;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00004005 File Offset: 0x00002205
		public override bool vmethod_11()
		{
			return this.class159_0.vmethod_11();
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00003B4D File Offset: 0x00001D4D
		public override bool vmethod_12()
		{
			return !this.vmethod_11();
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00003B68 File Offset: 0x00001D68
		internal override bool vmethod_7()
		{
			return this.vmethod_12();
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00003D9E File Offset: 0x00001F9E
		internal override bool vmethod_1()
		{
			return true;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0002ADB8 File Offset: 0x00028FB8
		public override Class147.Class158 vmethod_13(Class147.Enum0 enum0_1)
		{
			switch (enum0_1)
			{
			case (Class147.Enum0)1:
				return this.vmethod_15();
			case (Class147.Enum0)2:
				return this.vmethod_16();
			case (Class147.Enum0)3:
				return this.vmethod_17();
			case (Class147.Enum0)4:
				return this.vmethod_18();
			case (Class147.Enum0)5:
				return this.LtAcwclWeT();
			case (Class147.Enum0)6:
				return this.vmethod_19();
			case (Class147.Enum0)7:
				return this.vmethod_20();
			case (Class147.Enum0)8:
				return this.vmethod_21();
			case (Class147.Enum0)11:
				return this.vmethod_14();
			case (Class147.Enum0)12:
				return this;
			case (Class147.Enum0)13:
				return this;
			case (Class147.Enum0)16:
				return this.vmethod_71();
			}
			throw new Exception(((Class147.Enum4)4).ToString());
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0002AE70 File Offset: 0x00029070
		internal IntPtr method_7()
		{
			if (IntPtr.Size == 8)
			{
				return new IntPtr(((Class147.Class161)this.class159_0).struct4_0.long_0);
			}
			return new IntPtr(((Class147.Class160)this.class159_0).struct3_0.int_0);
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0002AEBC File Offset: 0x000290BC
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == typeof(IntPtr))
			{
				if (IntPtr.Size == 8)
				{
					return new IntPtr(((Class147.Class161)this.class159_0).struct4_0.long_0);
				}
				return new IntPtr(((Class147.Class160)this.class159_0).struct3_0.int_0);
			}
			else if (type_0 == typeof(UIntPtr))
			{
				if (IntPtr.Size == 8)
				{
					return new UIntPtr(((Class147.Class161)this.class159_0).struct4_0.ulong_0);
				}
				return new UIntPtr(((Class147.Class160)this.class159_0).struct3_0.uint_0);
			}
			else
			{
				if (!(type_0 == null) && !(type_0 == typeof(object)))
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					if (this.enum0_0 == (Class147.Enum0)12)
					{
						return new IntPtr(((Class147.Class161)this.class159_0).struct4_0.long_0);
					}
					return new UIntPtr(((Class147.Class161)this.class159_0).struct4_0.ulong_0);
				}
				else
				{
					if (this.enum0_0 == (Class147.Enum0)12)
					{
						return new IntPtr(((Class147.Class161)this.class159_0).struct4_0.int_0);
					}
					return new UIntPtr(((Class147.Class160)this.class159_0).struct3_0.uint_0);
				}
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00004012 File Offset: 0x00002212
		public override Class147.Class160 vmethod_14()
		{
			return this.class159_0.vmethod_14();
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0000401F File Offset: 0x0000221F
		public override Class147.Class160 vmethod_15()
		{
			return this.class159_0.vmethod_15();
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0000402C File Offset: 0x0000222C
		public override Class147.Class160 vmethod_16()
		{
			return this.class159_0.vmethod_16();
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00004039 File Offset: 0x00002239
		public override Class147.Class160 vmethod_17()
		{
			return this.class159_0.vmethod_17();
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00004046 File Offset: 0x00002246
		public override Class147.Class160 vmethod_18()
		{
			return this.class159_0.vmethod_18();
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00004053 File Offset: 0x00002253
		public override Class147.Class160 LtAcwclWeT()
		{
			return this.class159_0.LtAcwclWeT();
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00004060 File Offset: 0x00002260
		public override Class147.Class160 vmethod_19()
		{
			return this.class159_0.vmethod_19();
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0000406D File Offset: 0x0000226D
		public override Class147.Class161 vmethod_20()
		{
			return this.class159_0.vmethod_20();
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x0000407A File Offset: 0x0000227A
		public override Class147.Class161 vmethod_21()
		{
			return this.class159_0.vmethod_21();
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00003C1E File Offset: 0x00001E1E
		public override Class147.Class160 vmethod_22()
		{
			return this.vmethod_15();
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00003C26 File Offset: 0x00001E26
		public override Class147.Class160 vmethod_23()
		{
			return this.vmethod_17();
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00003C2E File Offset: 0x00001E2E
		public override Class147.Class160 vmethod_24()
		{
			return this.LtAcwclWeT();
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00003C36 File Offset: 0x00001E36
		public override Class147.Class161 vmethod_25()
		{
			return this.vmethod_20();
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00003C3E File Offset: 0x00001E3E
		public override Class147.Class160 vmethod_26()
		{
			return this.vmethod_16();
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00003C46 File Offset: 0x00001E46
		public override Class147.Class160 vmethod_27()
		{
			return this.vmethod_18();
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00003C4E File Offset: 0x00001E4E
		public override Class147.Class160 vmethod_28()
		{
			return this.vmethod_19();
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00003C56 File Offset: 0x00001E56
		public override Class147.Class161 vmethod_29()
		{
			return this.vmethod_21();
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00004087 File Offset: 0x00002287
		public override Class147.Class160 tPncmNfto2()
		{
			return this.class159_0.tPncmNfto2();
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00004094 File Offset: 0x00002294
		public override Class147.Class160 vmethod_30()
		{
			return this.class159_0.vmethod_30();
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x000040A1 File Offset: 0x000022A1
		public override Class147.Class160 vmethod_31()
		{
			return this.class159_0.vmethod_31();
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x000040AE File Offset: 0x000022AE
		public override Class147.Class160 vmethod_32()
		{
			return this.class159_0.vmethod_32();
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000040BB File Offset: 0x000022BB
		public override Class147.Class160 vmethod_33()
		{
			return this.class159_0.vmethod_33();
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x000040C8 File Offset: 0x000022C8
		public override Class147.Class160 vmethod_34()
		{
			return this.class159_0.vmethod_34();
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x000040D5 File Offset: 0x000022D5
		public override Class147.Class161 vmethod_35()
		{
			return this.class159_0.vmethod_35();
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x000040E2 File Offset: 0x000022E2
		public override Class147.Class161 vmethod_36()
		{
			return this.class159_0.vmethod_36();
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x000040EF File Offset: 0x000022EF
		public override Class147.Class160 vmethod_37()
		{
			return this.class159_0.vmethod_37();
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x000040FC File Offset: 0x000022FC
		public override Class147.Class160 vmethod_38()
		{
			return this.class159_0.vmethod_38();
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00004109 File Offset: 0x00002309
		public override Class147.Class160 vmethod_39()
		{
			return this.class159_0.vmethod_39();
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00004116 File Offset: 0x00002316
		public override Class147.Class160 vmethod_40()
		{
			return this.class159_0.vmethod_40();
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00004123 File Offset: 0x00002323
		public override Class147.Class160 vmethod_41()
		{
			return this.class159_0.vmethod_41();
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00004130 File Offset: 0x00002330
		public override Class147.Class160 vmethod_42()
		{
			return this.class159_0.vmethod_42();
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0000413D File Offset: 0x0000233D
		public override Class147.Class161 vmethod_43()
		{
			return this.class159_0.vmethod_43();
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0000414A File Offset: 0x0000234A
		public override Class147.Class161 vmethod_44()
		{
			return this.class159_0.vmethod_44();
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00004157 File Offset: 0x00002357
		public override Class147.Class163 vmethod_45()
		{
			return this.class159_0.vmethod_45();
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00004164 File Offset: 0x00002364
		public override Class147.Class163 vmethod_46()
		{
			return this.class159_0.vmethod_46();
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00004171 File Offset: 0x00002371
		public override Class147.Class163 vmethod_47()
		{
			return this.class159_0.vmethod_47();
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x000289B0 File Offset: 0x00026BB0
		public override Class147.Class162 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_25().struct4_0.long_0);
			}
			return new Class147.Class162((long)this.vmethod_24().struct3_0.int_0);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000289F4 File Offset: 0x00026BF4
		public override Class147.Class162 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_29().struct4_0.ulong_0);
			}
			return new Class147.Class162((ulong)this.vmethod_28().struct3_0.uint_0);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00028A38 File Offset: 0x00026C38
		public override Class147.Class162 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_35().struct4_0.long_0);
			}
			return new Class147.Class162((long)this.vmethod_33().struct3_0.int_0);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00028A7C File Offset: 0x00026C7C
		public override Class147.Class162 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_43().struct4_0.ulong_0);
			}
			return new Class147.Class162((ulong)this.vmethod_41().struct3_0.uint_0);
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00028AC0 File Offset: 0x00026CC0
		public override Class147.Class162 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_36().struct4_0.long_0);
			}
			return new Class147.Class162((long)this.vmethod_34().struct3_0.int_0);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00028B04 File Offset: 0x00026D04
		public override Class147.Class162 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_44().struct4_0.ulong_0);
			}
			return new Class147.Class162((ulong)this.vmethod_42().struct3_0.uint_0);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0002B054 File Offset: 0x00029254
		public override Class147.Class158 vmethod_54()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(-((Class147.Class161)this.class159_0).struct4_0.long_0);
			}
			return new Class147.Class162((long)(-(long)((Class147.Class160)this.class159_0).struct3_0.int_0));
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0002B0A4 File Offset: 0x000292A4
		public override Class147.Class158 Add(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_1())
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 + ((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 + ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 + ((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 + ((Class147.Class160)class158_0).struct3_0.int_0));
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0002B194 File Offset: 0x00029394
		public override Class147.Class158 vmethod_55(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_1())
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(checked(this.vmethod_20().struct4_0.long_0 + ((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0));
				}
				return new Class147.Class162((long)(checked(this.LtAcwclWeT().struct3_0.int_0 + ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(checked(this.vmethod_20().struct4_0.long_0 + ((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0));
				}
				return new Class147.Class162((long)(checked(this.LtAcwclWeT().struct3_0.int_0 + ((Class147.Class160)class158_0).struct3_0.int_0)));
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0002B284 File Offset: 0x00029484
		public override Class147.Class158 vmethod_56(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(checked(this.vmethod_20().struct4_0.ulong_0 + unchecked((ulong)((Class147.Class160)class158_0).struct3_0.uint_0)));
				}
				return new Class147.Class162((long)((ulong)(checked(this.LtAcwclWeT().struct3_0.uint_0 + ((Class147.Class160)class158_0).struct3_0.uint_0))));
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(checked(this.vmethod_20().struct4_0.ulong_0 + ((Class147.Class162)class158_0).vmethod_20().struct4_0.ulong_0));
				}
				return new Class147.Class162((ulong)(checked(this.LtAcwclWeT().struct3_0.uint_0 + ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.uint_0)));
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0002B370 File Offset: 0x00029570
		public override Class147.Class158 vmethod_57(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 - ((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 - ((Class147.Class160)class158_0).struct3_0.int_0));
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 - ((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 - ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0));
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0002B460 File Offset: 0x00029660
		public Class147.Class158 method_8(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0 - this.vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(((Class147.Class160)class158_0).struct3_0.int_0 - this.LtAcwclWeT().struct3_0.int_0));
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0 - this.vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0 - this.LtAcwclWeT().struct3_0.int_0));
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0002B550 File Offset: 0x00029750
		public override Class147.Class158 vmethod_58(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(checked(this.vmethod_20().struct4_0.long_0 - ((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0));
				}
				return new Class147.Class162((long)(checked(this.LtAcwclWeT().struct3_0.int_0 - ((Class147.Class160)class158_0).struct3_0.int_0)));
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(checked(this.vmethod_20().struct4_0.long_0 - ((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0));
				}
				return new Class147.Class162((long)(checked(this.LtAcwclWeT().struct3_0.int_0 - ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0)));
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0002B640 File Offset: 0x00029840
		public Class147.Class158 method_9(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_1())
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(checked(((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0 - this.vmethod_20().struct4_0.long_0));
				}
				return new Class147.Class162((long)(checked(((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0 - this.LtAcwclWeT().struct3_0.int_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(checked(((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0 - this.vmethod_20().struct4_0.long_0));
				}
				return new Class147.Class162((long)(checked(((Class147.Class160)class158_0).struct3_0.int_0 - this.LtAcwclWeT().struct3_0.int_0)));
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0002B730 File Offset: 0x00029930
		public override Class147.Class158 vmethod_59(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(checked(this.vmethod_20().struct4_0.ulong_0 - unchecked((ulong)((Class147.Class160)class158_0).struct3_0.uint_0)));
				}
				return new Class147.Class162((long)((ulong)(checked(this.LtAcwclWeT().struct3_0.uint_0 - ((Class147.Class160)class158_0).struct3_0.uint_0))));
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(checked(this.vmethod_20().struct4_0.ulong_0 - ((Class147.Class162)class158_0).vmethod_20().struct4_0.ulong_0));
				}
				return new Class147.Class162((ulong)(checked(this.LtAcwclWeT().struct3_0.uint_0 - ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.uint_0)));
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0002B81C File Offset: 0x00029A1C
		public Class147.Class158 method_10(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(checked(unchecked((ulong)((Class147.Class160)class158_0).struct3_0.uint_0) - this.vmethod_20().struct4_0.ulong_0));
				}
				return new Class147.Class162((long)((ulong)(checked(((Class147.Class160)class158_0).struct3_0.uint_0 - this.LtAcwclWeT().struct3_0.uint_0))));
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(checked(((Class147.Class162)class158_0).vmethod_20().struct4_0.ulong_0 - this.vmethod_20().struct4_0.ulong_0));
				}
				return new Class147.Class162((ulong)(checked(((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.uint_0 - this.LtAcwclWeT().struct3_0.uint_0)));
			}
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0002B908 File Offset: 0x00029B08
		public override Class147.Class158 vmethod_60(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 * ((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 * ((Class147.Class160)class158_0).struct3_0.int_0));
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 * ((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 * ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0));
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0002B9F8 File Offset: 0x00029BF8
		public override Class147.Class158 vmethod_61(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_1())
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(checked(this.vmethod_20().struct4_0.long_0 * ((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0));
				}
				return new Class147.Class162((long)(checked(this.LtAcwclWeT().struct3_0.int_0 * ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(checked(this.vmethod_20().struct4_0.long_0 * ((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0));
				}
				return new Class147.Class162((long)(checked(this.LtAcwclWeT().struct3_0.int_0 * ((Class147.Class160)class158_0).struct3_0.int_0)));
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0002BAE8 File Offset: 0x00029CE8
		public override Class147.Class158 vmethod_62(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_1())
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(checked(this.vmethod_20().struct4_0.ulong_0 * ((Class147.Class162)class158_0).vmethod_20().struct4_0.ulong_0));
				}
				return new Class147.Class162((ulong)(checked(this.LtAcwclWeT().struct3_0.uint_0 * ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.uint_0)));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(checked(this.vmethod_20().struct4_0.ulong_0 * unchecked((ulong)((Class147.Class160)class158_0).struct3_0.uint_0)));
				}
				return new Class147.Class162((long)((ulong)(checked(this.LtAcwclWeT().struct3_0.uint_0 * ((Class147.Class160)class158_0).struct3_0.uint_0))));
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0002BBD4 File Offset: 0x00029DD4
		public override Class147.Class158 vmethod_63(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 / ((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 / ((Class147.Class160)class158_0).struct3_0.int_0));
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 / ((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 / ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0));
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0002BCC4 File Offset: 0x00029EC4
		public Class147.Class158 method_11(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0 / this.vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(((Class147.Class160)class158_0).struct3_0.int_0 / this.LtAcwclWeT().struct3_0.int_0));
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0 / this.vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0 / this.LtAcwclWeT().struct3_0.int_0));
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0002BDB4 File Offset: 0x00029FB4
		public override Class147.Class158 vmethod_64(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_1())
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.ulong_0 / ((Class147.Class162)class158_0).vmethod_20().struct4_0.ulong_0);
				}
				return new Class147.Class162((ulong)(this.LtAcwclWeT().struct3_0.uint_0 / ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.uint_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.ulong_0 / ((Class147.Class160)class158_0).vmethod_20().struct4_0.ulong_0);
				}
				return new Class147.Class162((long)((ulong)(this.LtAcwclWeT().struct3_0.uint_0 / ((Class147.Class160)class158_0).struct3_0.uint_0)));
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0002BEA4 File Offset: 0x0002A0A4
		public Class147.Class158 method_12(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(((Class147.Class160)class158_0).vmethod_20().struct4_0.ulong_0 / this.vmethod_20().struct4_0.ulong_0);
				}
				return new Class147.Class162((long)((ulong)(((Class147.Class160)class158_0).struct3_0.uint_0 / this.LtAcwclWeT().struct3_0.uint_0)));
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(((Class147.Class162)class158_0).vmethod_20().struct4_0.ulong_0 / this.vmethod_20().struct4_0.ulong_0);
				}
				return new Class147.Class162((ulong)(((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.uint_0 / this.LtAcwclWeT().struct3_0.uint_0));
			}
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0002BF94 File Offset: 0x0002A194
		public override Class147.Class158 vmethod_65(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 % ((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 % ((Class147.Class160)class158_0).struct3_0.int_0));
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 % ((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 % ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0));
			}
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0002C084 File Offset: 0x0002A284
		public Class147.Class158 method_13(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0 % this.vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(((Class147.Class160)class158_0).struct3_0.int_0 % this.LtAcwclWeT().struct3_0.int_0));
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0 % this.vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0 % this.LtAcwclWeT().struct3_0.int_0));
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0002C174 File Offset: 0x0002A374
		public override Class147.Class158 vmethod_66(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.ulong_0 % ((Class147.Class160)class158_0).vmethod_20().struct4_0.ulong_0);
				}
				return new Class147.Class162((long)((ulong)(this.LtAcwclWeT().struct3_0.uint_0 % ((Class147.Class160)class158_0).struct3_0.uint_0)));
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.ulong_0 % ((Class147.Class162)class158_0).vmethod_20().struct4_0.ulong_0);
				}
				return new Class147.Class162((ulong)(this.LtAcwclWeT().struct3_0.uint_0 % ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.uint_0));
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0002C264 File Offset: 0x0002A464
		public Class147.Class158 method_14(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_1())
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(((Class147.Class162)class158_0).vmethod_20().struct4_0.ulong_0 % this.vmethod_20().struct4_0.ulong_0);
				}
				return new Class147.Class162((ulong)(((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.uint_0 % this.LtAcwclWeT().struct3_0.uint_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(((Class147.Class160)class158_0).vmethod_20().struct4_0.ulong_0 % this.vmethod_20().struct4_0.ulong_0);
				}
				return new Class147.Class162((long)((ulong)(((Class147.Class160)class158_0).struct3_0.uint_0 % this.LtAcwclWeT().struct3_0.uint_0)));
			}
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0002C354 File Offset: 0x0002A554
		public override Class147.Class158 vmethod_67(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 & ((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 & ((Class147.Class160)class158_0).struct3_0.int_0));
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 & ((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 & ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0));
			}
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0002C444 File Offset: 0x0002A644
		public override Class147.Class158 vmethod_68(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 | ((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 | ((Class147.Class160)class158_0).struct3_0.int_0));
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 | ((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 | ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0));
			}
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0002C534 File Offset: 0x0002A734
		public override Class147.Class158 vmethod_69()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(~this.vmethod_20().struct4_0.long_0);
			}
			return new Class147.Class162((long)(~(long)this.LtAcwclWeT().struct3_0.int_0));
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0002C578 File Offset: 0x0002A778
		public override Class147.Class158 vmethod_70(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_1())
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 ^ ((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 ^ ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 ^ ((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 ^ ((Class147.Class160)class158_0).struct3_0.int_0));
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0002C668 File Offset: 0x0002A868
		public override Class147.Class158 vmethod_72(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 << ((Class147.Class160)class158_0).struct3_0.int_0);
				}
				long num = (long)((long)this.LtAcwclWeT().struct3_0.int_0 << ((Class147.Class160)class158_0).struct3_0.int_0);
				return new Class147.Class162(0L);
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 << ((Class147.Class162)class158_0).vmethod_20().struct4_0.int_0);
				}
				long num2 = (long)((long)this.LtAcwclWeT().struct3_0.int_0 << ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0);
				return new Class147.Class162(0L);
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0002C774 File Offset: 0x0002A974
		public override Class147.Class158 vmethod_73(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_1())
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 >> ((Class147.Class162)class158_0).vmethod_20().struct4_0.int_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 >> ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0));
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.long_0 >> ((Class147.Class160)class158_0).struct3_0.int_0);
				}
				return new Class147.Class162((long)(this.LtAcwclWeT().struct3_0.int_0 >> ((Class147.Class160)class158_0).struct3_0.int_0));
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0002C86C File Offset: 0x0002AA6C
		public override Class147.Class158 vmethod_74(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_1())
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.ulong_0 >> ((Class147.Class162)class158_0).vmethod_20().struct4_0.int_0);
				}
				ulong num = (ulong)(this.LtAcwclWeT().struct3_0.uint_0 >> ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0);
				return new Class147.Class162(0L);
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return new Class147.Class162(this.vmethod_20().struct4_0.ulong_0 >> ((Class147.Class160)class158_0).struct3_0.int_0);
				}
				ulong num2 = (ulong)(this.LtAcwclWeT().struct3_0.uint_0 >> ((Class147.Class160)class158_0).struct3_0.int_0);
				return new Class147.Class162(0L);
			}
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0000417E File Offset: 0x0000237E
		public Class147.Class158 method_15(Class147.Class160 class160_0)
		{
			ulong num = (ulong)(class160_0.struct3_0.uint_0 >> this.LtAcwclWeT().struct3_0.int_0);
			return new Class147.Class162(0L);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x000041AF File Offset: 0x000023AF
		public Class147.Class158 method_16(Class147.Class160 class160_0)
		{
			return new Class147.Class162((long)(class160_0.struct3_0.int_0 >> this.vmethod_20().struct4_0.int_0));
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x000041D6 File Offset: 0x000023D6
		public Class147.Class158 method_17(Class147.Class160 class160_0)
		{
			long num = (long)((long)class160_0.struct3_0.int_0 << this.vmethod_20().struct4_0.int_0);
			return new Class147.Class162(0L);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00004207 File Offset: 0x00002407
		public override string ToString()
		{
			return this.class159_0.ToString();
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00003D9B File Offset: 0x00001F9B
		internal override Class147.Class158 vmethod_8()
		{
			return this;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00003D9E File Offset: 0x00001F9E
		internal override bool vmethod_9()
		{
			return true;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0002C978 File Offset: 0x0002AB78
		internal override bool vmethod_5(Class147.Class158 class158_0)
		{
			if (class158_0.method_0())
			{
				return false;
			}
			if (class158_0.vmethod_0())
			{
				return ((Class147.Class164)class158_0).vmethod_5(this);
			}
			Class147.Class158 @class = class158_0.vmethod_8();
			if (!@class.vmethod_9())
			{
				return false;
			}
			if (!@class.method_1())
			{
				if (!@class.method_2())
				{
					return false;
				}
				int size = IntPtr.Size;
				return this.vmethod_20().struct4_0.long_0 == ((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.long_0 == ((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0;
				}
				return this.LtAcwclWeT().struct3_0.int_0 == ((Class147.Class160)class158_0).struct3_0.int_0;
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0002CA54 File Offset: 0x0002AC54
		internal override bool vmethod_6(Class147.Class158 class158_0)
		{
			if (class158_0.method_0())
			{
				return false;
			}
			if (class158_0.vmethod_0())
			{
				return ((Class147.Class164)class158_0).vmethod_6(this);
			}
			Class147.Class158 @class = class158_0.vmethod_8();
			if (!@class.vmethod_9())
			{
				return false;
			}
			if (@class.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.ulong_0 != ((Class147.Class160)class158_0).vmethod_20().struct4_0.ulong_0;
				}
				return this.LtAcwclWeT().struct3_0.uint_0 != ((Class147.Class160)class158_0).struct3_0.uint_0;
			}
			else
			{
				if (@class.method_2())
				{
					int size = IntPtr.Size;
					return this.vmethod_20().struct4_0.ulong_0 != ((Class147.Class162)class158_0).vmethod_20().struct4_0.ulong_0;
				}
				return false;
			}
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0002CB38 File Offset: 0x0002AD38
		public override bool vmethod_75(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.long_0 >= ((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0;
				}
				return this.LtAcwclWeT().struct3_0.int_0 >= ((Class147.Class160)class158_0).struct3_0.int_0;
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.long_0 >= ((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0;
				}
				return this.LtAcwclWeT().struct3_0.int_0 >= ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0;
			}
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0002CC24 File Offset: 0x0002AE24
		public override bool vmethod_76(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_1())
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.ulong_0 >= ((Class147.Class162)class158_0).vmethod_20().struct4_0.ulong_0;
				}
				return this.LtAcwclWeT().struct3_0.uint_0 >= ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.uint_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.ulong_0 >= ((Class147.Class160)class158_0).vmethod_20().struct4_0.ulong_0;
				}
				return this.LtAcwclWeT().struct3_0.uint_0 >= ((Class147.Class160)class158_0).struct3_0.uint_0;
			}
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0002CD10 File Offset: 0x0002AF10
		public override bool vmethod_77(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.long_0 > ((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0;
				}
				return this.LtAcwclWeT().struct3_0.int_0 > ((Class147.Class160)class158_0).struct3_0.int_0;
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.long_0 > ((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0;
				}
				return this.LtAcwclWeT().struct3_0.int_0 > ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0;
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0002CDF0 File Offset: 0x0002AFF0
		public override bool vmethod_78(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_1())
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.ulong_0 > ((Class147.Class162)class158_0).vmethod_20().struct4_0.ulong_0;
				}
				return this.LtAcwclWeT().struct3_0.uint_0 > ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.uint_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.ulong_0 > ((Class147.Class160)class158_0).vmethod_20().struct4_0.ulong_0;
				}
				return this.LtAcwclWeT().struct3_0.uint_0 > ((Class147.Class160)class158_0).struct3_0.uint_0;
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0002CED0 File Offset: 0x0002B0D0
		public override bool vmethod_79(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.long_0 <= ((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0;
				}
				return this.LtAcwclWeT().struct3_0.int_0 <= ((Class147.Class160)class158_0).struct3_0.int_0;
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.long_0 <= ((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0;
				}
				return this.LtAcwclWeT().struct3_0.int_0 <= ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0;
			}
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0002CFBC File Offset: 0x0002B1BC
		public override bool vmethod_80(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_1())
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.ulong_0 <= ((Class147.Class162)class158_0).vmethod_20().struct4_0.ulong_0;
				}
				return this.LtAcwclWeT().struct3_0.uint_0 <= ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.uint_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.ulong_0 <= ((Class147.Class160)class158_0).vmethod_20().struct4_0.ulong_0;
				}
				return this.LtAcwclWeT().struct3_0.uint_0 <= ((Class147.Class160)class158_0).struct3_0.uint_0;
			}
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0002D0A8 File Offset: 0x0002B2A8
		public override bool vmethod_81(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_1())
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.long_0 < ((Class147.Class162)class158_0).vmethod_20().struct4_0.long_0;
				}
				return this.LtAcwclWeT().struct3_0.int_0 < ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.int_0;
			}
			else
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.long_0 < ((Class147.Class160)class158_0).vmethod_20().struct4_0.long_0;
				}
				return this.LtAcwclWeT().struct3_0.int_0 < ((Class147.Class160)class158_0).struct3_0.int_0;
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0002D188 File Offset: 0x0002B388
		public override bool vmethod_82(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (class158_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.ulong_0 < ((Class147.Class160)class158_0).vmethod_20().struct4_0.ulong_0;
				}
				return this.LtAcwclWeT().struct3_0.uint_0 < ((Class147.Class160)class158_0).struct3_0.uint_0;
			}
			else
			{
				if (!class158_0.method_2())
				{
					throw new Class147.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct4_0.ulong_0 < ((Class147.Class162)class158_0).vmethod_20().struct4_0.ulong_0;
				}
				return this.LtAcwclWeT().struct3_0.uint_0 < ((Class147.Class162)class158_0).LtAcwclWeT().struct3_0.uint_0;
			}
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00004214 File Offset: 0x00002414
		internal static bool oDTJ0LZojeM4VX1D5oN3()
		{
			return Class147.Class162.xDj4RMZog4sSPvpuKvrR == null;
		}

		// Token: 0x040004E7 RID: 1255
		public Class147.Class159 class159_0;

		// Token: 0x040004E8 RID: 1256
		public Class147.Enum0 enum0_0;

		// Token: 0x040004E9 RID: 1257
		private static Class147.Class162 xDj4RMZog4sSPvpuKvrR;
	}

	// Token: 0x0200017C RID: 380
	private abstract class Class159 : Class147.Class158
	{
		// Token: 0x060008F5 RID: 2293
		public abstract bool vmethod_11();

		// Token: 0x060008F6 RID: 2294
		public abstract bool vmethod_12();

		// Token: 0x060008F7 RID: 2295
		public abstract Class147.Class158 vmethod_13(Class147.Enum0 enum0_0);

		// Token: 0x060008F8 RID: 2296
		public abstract Class147.Class160 vmethod_14();

		// Token: 0x060008F9 RID: 2297
		public abstract Class147.Class160 vmethod_15();

		// Token: 0x060008FA RID: 2298
		public abstract Class147.Class160 vmethod_16();

		// Token: 0x060008FB RID: 2299
		public abstract Class147.Class160 vmethod_17();

		// Token: 0x060008FC RID: 2300
		public abstract Class147.Class160 vmethod_18();

		// Token: 0x060008FD RID: 2301
		public abstract Class147.Class160 LtAcwclWeT();

		// Token: 0x060008FE RID: 2302
		public abstract Class147.Class160 vmethod_19();

		// Token: 0x060008FF RID: 2303
		public abstract Class147.Class161 vmethod_20();

		// Token: 0x06000900 RID: 2304
		public abstract Class147.Class161 vmethod_21();

		// Token: 0x06000901 RID: 2305
		public abstract Class147.Class160 vmethod_22();

		// Token: 0x06000902 RID: 2306
		public abstract Class147.Class160 vmethod_23();

		// Token: 0x06000903 RID: 2307
		public abstract Class147.Class160 vmethod_24();

		// Token: 0x06000904 RID: 2308
		public abstract Class147.Class161 vmethod_25();

		// Token: 0x06000905 RID: 2309
		public abstract Class147.Class160 vmethod_26();

		// Token: 0x06000906 RID: 2310
		public abstract Class147.Class160 vmethod_27();

		// Token: 0x06000907 RID: 2311
		public abstract Class147.Class160 vmethod_28();

		// Token: 0x06000908 RID: 2312
		public abstract Class147.Class161 vmethod_29();

		// Token: 0x06000909 RID: 2313
		public abstract Class147.Class160 tPncmNfto2();

		// Token: 0x0600090A RID: 2314
		public abstract Class147.Class160 vmethod_30();

		// Token: 0x0600090B RID: 2315
		public abstract Class147.Class160 vmethod_31();

		// Token: 0x0600090C RID: 2316
		public abstract Class147.Class160 vmethod_32();

		// Token: 0x0600090D RID: 2317
		public abstract Class147.Class160 vmethod_33();

		// Token: 0x0600090E RID: 2318
		public abstract Class147.Class160 vmethod_34();

		// Token: 0x0600090F RID: 2319
		public abstract Class147.Class161 vmethod_35();

		// Token: 0x06000910 RID: 2320
		public abstract Class147.Class161 vmethod_36();

		// Token: 0x06000911 RID: 2321
		public abstract Class147.Class160 vmethod_37();

		// Token: 0x06000912 RID: 2322
		public abstract Class147.Class160 vmethod_38();

		// Token: 0x06000913 RID: 2323
		public abstract Class147.Class160 vmethod_39();

		// Token: 0x06000914 RID: 2324
		public abstract Class147.Class160 vmethod_40();

		// Token: 0x06000915 RID: 2325
		public abstract Class147.Class160 vmethod_41();

		// Token: 0x06000916 RID: 2326
		public abstract Class147.Class160 vmethod_42();

		// Token: 0x06000917 RID: 2327
		public abstract Class147.Class161 vmethod_43();

		// Token: 0x06000918 RID: 2328
		public abstract Class147.Class161 vmethod_44();

		// Token: 0x06000919 RID: 2329
		public abstract Class147.Class163 vmethod_45();

		// Token: 0x0600091A RID: 2330
		public abstract Class147.Class163 vmethod_46();

		// Token: 0x0600091B RID: 2331
		public abstract Class147.Class163 vmethod_47();

		// Token: 0x0600091C RID: 2332
		public abstract Class147.Class162 vmethod_48();

		// Token: 0x0600091D RID: 2333
		public abstract Class147.Class162 vmethod_49();

		// Token: 0x0600091E RID: 2334
		public abstract Class147.Class162 vmethod_50();

		// Token: 0x0600091F RID: 2335
		public abstract Class147.Class162 vmethod_51();

		// Token: 0x06000920 RID: 2336
		public abstract Class147.Class162 vmethod_52();

		// Token: 0x06000921 RID: 2337
		public abstract Class147.Class162 vmethod_53();

		// Token: 0x06000922 RID: 2338
		public abstract Class147.Class158 vmethod_54();

		// Token: 0x06000923 RID: 2339
		public abstract Class147.Class158 Add(Class147.Class158 class158_0);

		// Token: 0x06000924 RID: 2340
		public abstract Class147.Class158 vmethod_55(Class147.Class158 class158_0);

		// Token: 0x06000925 RID: 2341
		public abstract Class147.Class158 vmethod_56(Class147.Class158 class158_0);

		// Token: 0x06000926 RID: 2342
		public abstract Class147.Class158 vmethod_57(Class147.Class158 class158_0);

		// Token: 0x06000927 RID: 2343
		public abstract Class147.Class158 vmethod_58(Class147.Class158 class158_0);

		// Token: 0x06000928 RID: 2344
		public abstract Class147.Class158 vmethod_59(Class147.Class158 class158_0);

		// Token: 0x06000929 RID: 2345
		public abstract Class147.Class158 vmethod_60(Class147.Class158 class158_0);

		// Token: 0x0600092A RID: 2346
		public abstract Class147.Class158 vmethod_61(Class147.Class158 class158_0);

		// Token: 0x0600092B RID: 2347
		public abstract Class147.Class158 vmethod_62(Class147.Class158 class158_0);

		// Token: 0x0600092C RID: 2348
		public abstract Class147.Class158 vmethod_63(Class147.Class158 class158_0);

		// Token: 0x0600092D RID: 2349
		public abstract Class147.Class158 vmethod_64(Class147.Class158 class158_0);

		// Token: 0x0600092E RID: 2350
		public abstract Class147.Class158 vmethod_65(Class147.Class158 class158_0);

		// Token: 0x0600092F RID: 2351
		public abstract Class147.Class158 vmethod_66(Class147.Class158 class158_0);

		// Token: 0x06000930 RID: 2352
		public abstract Class147.Class158 vmethod_67(Class147.Class158 class158_0);

		// Token: 0x06000931 RID: 2353
		public abstract Class147.Class158 vmethod_68(Class147.Class158 class158_0);

		// Token: 0x06000932 RID: 2354
		public abstract Class147.Class158 vmethod_69();

		// Token: 0x06000933 RID: 2355
		public abstract Class147.Class158 vmethod_70(Class147.Class158 class158_0);

		// Token: 0x06000934 RID: 2356
		public abstract Class147.Class159 vmethod_71();

		// Token: 0x06000935 RID: 2357
		public abstract Class147.Class158 vmethod_72(Class147.Class158 class158_0);

		// Token: 0x06000936 RID: 2358
		public abstract Class147.Class158 vmethod_73(Class147.Class158 class158_0);

		// Token: 0x06000937 RID: 2359
		public abstract Class147.Class158 vmethod_74(Class147.Class158 class158_0);

		// Token: 0x06000938 RID: 2360
		public abstract bool vmethod_75(Class147.Class158 class158_0);

		// Token: 0x06000939 RID: 2361
		public abstract bool vmethod_76(Class147.Class158 class158_0);

		// Token: 0x0600093A RID: 2362
		public abstract bool vmethod_77(Class147.Class158 class158_0);

		// Token: 0x0600093B RID: 2363
		public abstract bool vmethod_78(Class147.Class158 class158_0);

		// Token: 0x0600093C RID: 2364
		public abstract bool vmethod_79(Class147.Class158 class158_0);

		// Token: 0x0600093D RID: 2365
		public abstract bool vmethod_80(Class147.Class158 class158_0);

		// Token: 0x0600093E RID: 2366
		public abstract bool vmethod_81(Class147.Class158 class158_0);

		// Token: 0x0600093F RID: 2367
		public abstract bool vmethod_82(Class147.Class158 class158_0);

		// Token: 0x06000940 RID: 2368 RVA: 0x00003D9E File Offset: 0x00001F9E
		internal override bool vmethod_3()
		{
			return true;
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0000421E File Offset: 0x0000241E
		internal static bool Sn4yn5Zo6ZmsNpbEyIR5()
		{
			return Class147.Class159.QO8kZ0ZolO689ArlkI5V == null;
		}

		// Token: 0x040004EA RID: 1258
		internal static Class147.Class159 QO8kZ0ZolO689ArlkI5V;
	}

	// Token: 0x0200017D RID: 381
	private class Class163 : Class147.Class159
	{
		// Token: 0x06000943 RID: 2371 RVA: 0x0002D27C File Offset: 0x0002B47C
		internal override void vmethod_10(Class147.Class158 class158_0)
		{
			this.double_0 = ((Class147.Class163)class158_0).double_0;
			this.enum0_0 = ((Class147.Class163)class158_0).enum0_0;
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0002826C File Offset: 0x0002646C
		internal override void vmethod_2(Class147.Class158 class158_0)
		{
			this.vmethod_10(class158_0);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0002D2AC File Offset: 0x0002B4AC
		public Class163(double double_1)
		{
			this.enum3_0 = (Class147.Enum3)5;
			this.enum0_0 = (Class147.Enum0)10;
			this.double_0 = double_1;
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0002D2D8 File Offset: 0x0002B4D8
		public Class163(Class147.Class163 class163_0)
		{
			this.enum3_0 = class163_0.enum3_0;
			this.enum0_0 = class163_0.enum0_0;
			this.double_0 = class163_0.double_0;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00004228 File Offset: 0x00002428
		public override Class147.Class159 vmethod_71()
		{
			return new Class147.Class163(this);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0002D310 File Offset: 0x0002B510
		public Class163(double double_1, Class147.Enum0 enum0_1)
		{
			this.enum3_0 = (Class147.Enum3)5;
			this.double_0 = double_1;
			this.enum0_0 = enum0_1;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0002D338 File Offset: 0x0002B538
		public Class163(float float_0)
		{
			this.enum3_0 = (Class147.Enum3)5;
			this.double_0 = (double)float_0;
			this.enum0_0 = (Class147.Enum0)9;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0002D364 File Offset: 0x0002B564
		public Class163(float float_0, Class147.Enum0 enum0_1)
		{
			this.enum3_0 = (Class147.Enum3)5;
			this.double_0 = (double)float_0;
			this.enum0_0 = enum0_1;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00004230 File Offset: 0x00002430
		public override bool vmethod_11()
		{
			return this.double_0 == 0.0;
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00003B4D File Offset: 0x00001D4D
		public override bool vmethod_12()
		{
			return !this.vmethod_11();
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00004243 File Offset: 0x00002443
		public override string ToString()
		{
			return this.double_0.ToString();
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0002D390 File Offset: 0x0002B590
		public override Class147.Class158 vmethod_13(Class147.Enum0 enum0_1)
		{
			switch (enum0_1)
			{
			case (Class147.Enum0)1:
				return this.vmethod_15();
			case (Class147.Enum0)2:
				return this.vmethod_16();
			case (Class147.Enum0)3:
				return this.vmethod_17();
			case (Class147.Enum0)4:
				return this.vmethod_18();
			case (Class147.Enum0)5:
				return this.LtAcwclWeT();
			case (Class147.Enum0)6:
				return this.vmethod_19();
			case (Class147.Enum0)7:
				return this.vmethod_20();
			case (Class147.Enum0)8:
				return this.vmethod_21();
			case (Class147.Enum0)9:
				return this.vmethod_45();
			case (Class147.Enum0)10:
				return this.vmethod_46();
			case (Class147.Enum0)11:
				return this.vmethod_14();
			default:
				throw new Exception(((Class147.Enum4)4).ToString());
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0002D434 File Offset: 0x0002B634
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == typeof(float))
			{
				return (float)this.double_0;
			}
			if (type_0 == typeof(double))
			{
				return this.double_0;
			}
			if ((type_0 == null || type_0 == typeof(object)) && this.enum0_0 == (Class147.Enum0)9)
			{
				return (float)this.double_0;
			}
			return this.double_0;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00004250 File Offset: 0x00002450
		public override Class147.Class160 vmethod_14()
		{
			return new Class147.Class160((this.vmethod_11() > false) ? 1 : 0);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00003B68 File Offset: 0x00001D68
		internal override bool vmethod_7()
		{
			return this.vmethod_12();
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00004260 File Offset: 0x00002460
		public override Class147.Class160 vmethod_15()
		{
			return new Class147.Class160((int)((sbyte)this.double_0), (Class147.Enum0)1);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0000426F File Offset: 0x0000246F
		public override Class147.Class160 vmethod_16()
		{
			return new Class147.Class160((uint)((byte)this.double_0), (Class147.Enum0)2);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0000427E File Offset: 0x0000247E
		public override Class147.Class160 vmethod_17()
		{
			return new Class147.Class160((int)((short)this.double_0), (Class147.Enum0)3);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0000428D File Offset: 0x0000248D
		public override Class147.Class160 vmethod_18()
		{
			return new Class147.Class160((uint)((ushort)this.double_0), (Class147.Enum0)4);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0000429C File Offset: 0x0000249C
		public override Class147.Class160 LtAcwclWeT()
		{
			return new Class147.Class160((int)this.double_0, (Class147.Enum0)5);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x000042AB File Offset: 0x000024AB
		public override Class147.Class160 vmethod_19()
		{
			return new Class147.Class160((uint)this.double_0, (Class147.Enum0)6);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x000042BA File Offset: 0x000024BA
		public override Class147.Class161 vmethod_20()
		{
			return new Class147.Class161((long)this.double_0, (Class147.Enum0)7);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x000042C9 File Offset: 0x000024C9
		public override Class147.Class161 vmethod_21()
		{
			return new Class147.Class161((ulong)this.double_0, (Class147.Enum0)8);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00003C1E File Offset: 0x00001E1E
		public override Class147.Class160 vmethod_22()
		{
			return this.vmethod_15();
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00003C26 File Offset: 0x00001E26
		public override Class147.Class160 vmethod_23()
		{
			return this.vmethod_17();
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00003C2E File Offset: 0x00001E2E
		public override Class147.Class160 vmethod_24()
		{
			return this.LtAcwclWeT();
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00003C36 File Offset: 0x00001E36
		public override Class147.Class161 vmethod_25()
		{
			return this.vmethod_20();
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00003C3E File Offset: 0x00001E3E
		public override Class147.Class160 vmethod_26()
		{
			return this.vmethod_16();
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00003C46 File Offset: 0x00001E46
		public override Class147.Class160 vmethod_27()
		{
			return this.vmethod_18();
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00003C4E File Offset: 0x00001E4E
		public override Class147.Class160 vmethod_28()
		{
			return this.vmethod_19();
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00003C56 File Offset: 0x00001E56
		public override Class147.Class161 vmethod_29()
		{
			return this.vmethod_21();
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x000042D8 File Offset: 0x000024D8
		public override Class147.Class160 tPncmNfto2()
		{
			return new Class147.Class160((int)(checked((sbyte)this.double_0)), (Class147.Enum0)1);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x000042D8 File Offset: 0x000024D8
		public override Class147.Class160 vmethod_30()
		{
			return new Class147.Class160((int)(checked((sbyte)this.double_0)), (Class147.Enum0)1);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x000042E7 File Offset: 0x000024E7
		public override Class147.Class160 vmethod_31()
		{
			return new Class147.Class160((int)(checked((short)this.double_0)), (Class147.Enum0)3);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x000042E7 File Offset: 0x000024E7
		public override Class147.Class160 vmethod_32()
		{
			return new Class147.Class160((int)(checked((short)this.double_0)), (Class147.Enum0)3);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x000042F6 File Offset: 0x000024F6
		public override Class147.Class160 vmethod_33()
		{
			return new Class147.Class160(checked((int)this.double_0), (Class147.Enum0)5);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x000042F6 File Offset: 0x000024F6
		public override Class147.Class160 vmethod_34()
		{
			return new Class147.Class160(checked((int)this.double_0), (Class147.Enum0)5);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00004305 File Offset: 0x00002505
		public override Class147.Class161 vmethod_35()
		{
			return new Class147.Class161(checked((long)this.double_0), (Class147.Enum0)7);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00004305 File Offset: 0x00002505
		public override Class147.Class161 vmethod_36()
		{
			return new Class147.Class161(checked((long)this.double_0), (Class147.Enum0)7);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00004314 File Offset: 0x00002514
		public override Class147.Class160 vmethod_37()
		{
			return new Class147.Class160((int)(checked((byte)this.double_0)), (Class147.Enum0)2);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00004314 File Offset: 0x00002514
		public override Class147.Class160 vmethod_38()
		{
			return new Class147.Class160((int)(checked((byte)this.double_0)), (Class147.Enum0)2);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00004323 File Offset: 0x00002523
		public override Class147.Class160 vmethod_39()
		{
			return new Class147.Class160((int)(checked((ushort)this.double_0)), (Class147.Enum0)4);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00004323 File Offset: 0x00002523
		public override Class147.Class160 vmethod_40()
		{
			return new Class147.Class160((int)(checked((ushort)this.double_0)), (Class147.Enum0)4);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00004332 File Offset: 0x00002532
		public override Class147.Class160 vmethod_41()
		{
			return new Class147.Class160(checked((uint)this.double_0), (Class147.Enum0)6);
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00004332 File Offset: 0x00002532
		public override Class147.Class160 vmethod_42()
		{
			return new Class147.Class160(checked((uint)this.double_0), (Class147.Enum0)6);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00004341 File Offset: 0x00002541
		public override Class147.Class161 vmethod_43()
		{
			return new Class147.Class161(checked((ulong)this.double_0), (Class147.Enum0)8);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00004341 File Offset: 0x00002541
		public override Class147.Class161 vmethod_44()
		{
			return new Class147.Class161(checked((ulong)this.double_0), (Class147.Enum0)8);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00004350 File Offset: 0x00002550
		public override Class147.Class163 vmethod_45()
		{
			return new Class147.Class163((float)this.double_0, (Class147.Enum0)9);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00004360 File Offset: 0x00002560
		public override Class147.Class163 vmethod_46()
		{
			return new Class147.Class163(this.double_0, (Class147.Enum0)10);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00004370 File Offset: 0x00002570
		public override Class147.Class163 vmethod_47()
		{
			return new Class147.Class163(this.double_0);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000289B0 File Offset: 0x00026BB0
		public override Class147.Class162 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_25().struct4_0.long_0);
			}
			return new Class147.Class162((long)this.vmethod_24().struct3_0.int_0);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x000289F4 File Offset: 0x00026BF4
		public override Class147.Class162 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_29().struct4_0.ulong_0);
			}
			return new Class147.Class162((ulong)this.vmethod_28().struct3_0.uint_0);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00028A38 File Offset: 0x00026C38
		public override Class147.Class162 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_35().struct4_0.long_0);
			}
			return new Class147.Class162((long)this.vmethod_33().struct3_0.int_0);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00028A7C File Offset: 0x00026C7C
		public override Class147.Class162 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_43().struct4_0.ulong_0);
			}
			return new Class147.Class162((ulong)this.vmethod_41().struct3_0.uint_0);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00028AC0 File Offset: 0x00026CC0
		public override Class147.Class162 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_36().struct4_0.long_0);
			}
			return new Class147.Class162((long)this.vmethod_34().struct3_0.int_0);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00028B04 File Offset: 0x00026D04
		public override Class147.Class162 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class147.Class162(this.vmethod_44().struct4_0.ulong_0);
			}
			return new Class147.Class162((ulong)this.vmethod_42().struct3_0.uint_0);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0002D4D4 File Offset: 0x0002B6D4
		public override Class147.Class158 vmethod_54()
		{
			if (this.enum0_0 == (Class147.Enum0)9)
			{
				return new Class147.Class163((float)(-(float)this.double_0));
			}
			return new Class147.Class163(-this.double_0);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0002D508 File Offset: 0x0002B708
		public override Class147.Class158 Add(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class163(this.double_0 + ((Class147.Class163)class158_0).double_0);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0002D508 File Offset: 0x0002B708
		public override Class147.Class158 vmethod_55(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class163(this.double_0 + ((Class147.Class163)class158_0).double_0);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0002D508 File Offset: 0x0002B708
		public override Class147.Class158 vmethod_56(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class163(this.double_0 + ((Class147.Class163)class158_0).double_0);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0002D54C File Offset: 0x0002B74C
		public override Class147.Class158 vmethod_57(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class163(this.double_0 - ((Class147.Class163)class158_0).double_0);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0002D54C File Offset: 0x0002B74C
		public override Class147.Class158 vmethod_58(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class163(this.double_0 - ((Class147.Class163)class158_0).double_0);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0002D54C File Offset: 0x0002B74C
		public override Class147.Class158 vmethod_59(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class163(this.double_0 - ((Class147.Class163)class158_0).double_0);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0002D590 File Offset: 0x0002B790
		public override Class147.Class158 vmethod_60(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4() || !class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class163(this.double_0 * ((Class147.Class163)class158_0).double_0);
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0002D5DC File Offset: 0x0002B7DC
		public override Class147.Class158 vmethod_61(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class163(this.double_0 * ((Class147.Class163)class158_0).double_0);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0002D5DC File Offset: 0x0002B7DC
		public override Class147.Class158 vmethod_62(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class163(this.double_0 * ((Class147.Class163)class158_0).double_0);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0002D620 File Offset: 0x0002B820
		public override Class147.Class158 vmethod_63(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class163(this.double_0 / ((Class147.Class163)class158_0).double_0);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0002D620 File Offset: 0x0002B820
		public override Class147.Class158 vmethod_64(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class163(this.double_0 / ((Class147.Class163)class158_0).double_0);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0002D664 File Offset: 0x0002B864
		public override Class147.Class158 vmethod_65(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class163(this.double_0 % ((Class147.Class163)class158_0).double_0);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0002D664 File Offset: 0x0002B864
		public override Class147.Class158 vmethod_66(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return new Class147.Class163(this.double_0 % ((Class147.Class163)class158_0).double_0);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0000437E File Offset: 0x0000257E
		public override Class147.Class158 vmethod_67(Class147.Class158 class158_0)
		{
			throw new Class147.Exception1();
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0000437E File Offset: 0x0000257E
		public override Class147.Class158 vmethod_68(Class147.Class158 class158_0)
		{
			throw new Class147.Exception1();
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0000437E File Offset: 0x0000257E
		public override Class147.Class158 vmethod_69()
		{
			throw new Class147.Exception1();
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0000437E File Offset: 0x0000257E
		public override Class147.Class158 vmethod_70(Class147.Class158 class158_0)
		{
			throw new Class147.Exception1();
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0000437E File Offset: 0x0000257E
		public override Class147.Class158 vmethod_72(Class147.Class158 class158_0)
		{
			throw new Class147.Exception1();
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0000437E File Offset: 0x0000257E
		public override Class147.Class158 vmethod_73(Class147.Class158 class158_0)
		{
			throw new Class147.Exception1();
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0000437E File Offset: 0x0000257E
		public override Class147.Class158 vmethod_74(Class147.Class158 class158_0)
		{
			throw new Class147.Exception1();
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00003D9B File Offset: 0x00001F9B
		internal override Class147.Class158 vmethod_8()
		{
			return this;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0002D6A8 File Offset: 0x0002B8A8
		internal override bool vmethod_5(Class147.Class158 class158_0)
		{
			if (class158_0.method_0())
			{
				return false;
			}
			if (!class158_0.vmethod_0())
			{
				Class147.Class158 @class = class158_0.vmethod_8();
				return @class.method_4() && this.double_0 == ((Class147.Class163)@class).double_0;
			}
			return ((Class147.Class164)class158_0).vmethod_5(this);
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0002D6FC File Offset: 0x0002B8FC
		internal override bool vmethod_6(Class147.Class158 class158_0)
		{
			if (class158_0.method_0())
			{
				return false;
			}
			if (!class158_0.vmethod_0())
			{
				Class147.Class158 @class = class158_0.vmethod_8();
				return @class.method_4() && this.double_0 != ((Class147.Class163)@class).double_0;
			}
			return ((Class147.Class164)class158_0).vmethod_6(this);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0002D754 File Offset: 0x0002B954
		public override bool vmethod_75(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return this.double_0 >= ((Class147.Class163)class158_0).double_0;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0002D754 File Offset: 0x0002B954
		public override bool vmethod_76(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return this.double_0 >= ((Class147.Class163)class158_0).double_0;
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0002D798 File Offset: 0x0002B998
		public override bool vmethod_77(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return this.double_0 > ((Class147.Class163)class158_0).double_0;
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0002D798 File Offset: 0x0002B998
		public override bool vmethod_78(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return this.double_0 > ((Class147.Class163)class158_0).double_0;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0002D7D8 File Offset: 0x0002B9D8
		public override bool vmethod_79(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return this.double_0 <= ((Class147.Class163)class158_0).double_0;
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0002D7D8 File Offset: 0x0002B9D8
		public override bool vmethod_80(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return this.double_0 <= ((Class147.Class163)class158_0).double_0;
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0002D81C File Offset: 0x0002BA1C
		public override bool vmethod_81(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return this.double_0 < ((Class147.Class163)class158_0).double_0;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0002D81C File Offset: 0x0002BA1C
		public override bool vmethod_82(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				class158_0 = class158_0.vmethod_8();
			}
			if (!class158_0.method_4())
			{
				throw new Class147.Exception1();
			}
			return this.double_0 < ((Class147.Class163)class158_0).double_0;
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00004385 File Offset: 0x00002585
		internal static bool TLBAPwZosjFyaQN7E0kf()
		{
			return Class147.Class163.u79tmXZo3eCH6WpCO9Uy == null;
		}

		// Token: 0x040004EB RID: 1259
		public double double_0;

		// Token: 0x040004EC RID: 1260
		public Class147.Enum0 enum0_0;

		// Token: 0x040004ED RID: 1261
		private static Class147.Class163 u79tmXZo3eCH6WpCO9Uy;
	}

	// Token: 0x0200017E RID: 382
	internal enum Enum0 : byte
	{

	}

	// Token: 0x0200017F RID: 383
	internal enum Enum1 : byte
	{

	}

	// Token: 0x02000180 RID: 384
	private class Exception0 : Exception
	{
		// Token: 0x0600099C RID: 2460 RVA: 0x0002D85C File Offset: 0x0002BA5C
		public Exception0(string string_0) : base(string_0)
		{
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0000438F File Offset: 0x0000258F
		internal static bool qN903nZoKJEDdbTy3Cu4()
		{
			return Class147.Exception0.vwbkJFZoQr0ZTVlpncQU == null;
		}

		// Token: 0x040004F0 RID: 1264
		internal static Class147.Exception0 vwbkJFZoQr0ZTVlpncQU;
	}

	// Token: 0x02000181 RID: 385
	private class Exception1 : Exception
	{
		// Token: 0x0600099E RID: 2462 RVA: 0x0002D870 File Offset: 0x0002BA70
		public Exception1()
		{
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0002D85C File Offset: 0x0002BA5C
		public Exception1(string string_0) : base(string_0)
		{
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00004399 File Offset: 0x00002599
		internal static bool O0ioOVZo0CFd427xTIG8()
		{
			return Class147.Exception1.NdFuurZoAB3hjQQu5G9P == null;
		}

		// Token: 0x040004F1 RID: 1265
		internal static Class147.Exception1 NdFuurZoAB3hjQQu5G9P;
	}

	// Token: 0x02000182 RID: 386
	internal class Class148
	{
		// Token: 0x060009A1 RID: 2465 RVA: 0x0002D884 File Offset: 0x0002BA84
		public override string ToString()
		{
			object obj = this.enum2_0;
			if (this.object_0 != null)
			{
				return obj.ToString() + 'H'.ToString() + this.object_0.ToString();
			}
			return obj.ToString();
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x000043A3 File Offset: 0x000025A3
		internal static bool Cb0c3PZonrsHTTYqZStN()
		{
			return Class147.Class148.x6lq0XZoN54Al0Sk4YyY == null;
		}

		// Token: 0x040004F2 RID: 1266
		internal Class147.Enum2 enum2_0 = (Class147.Enum2)126;

		// Token: 0x040004F3 RID: 1267
		internal object object_0;

		// Token: 0x040004F4 RID: 1268
		internal static Class147.Class148 x6lq0XZoN54Al0Sk4YyY;
	}

	// Token: 0x02000183 RID: 387
	internal abstract class Class164 : Class147.Class158
	{
		// Token: 0x060009A4 RID: 2468 RVA: 0x0002D268 File Offset: 0x0002B468
		public Class164()
		{
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00003D9E File Offset: 0x00001F9E
		internal override bool vmethod_0()
		{
			return true;
		}

		// Token: 0x060009A6 RID: 2470
		internal abstract IntPtr vmethod_11();

		// Token: 0x060009A7 RID: 2471
		internal abstract void vmethod_12(Class147.Class158 class158_0);

		// Token: 0x060009A8 RID: 2472 RVA: 0x00003D9E File Offset: 0x00001F9E
		internal override bool vmethod_1()
		{
			return true;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x000043AD File Offset: 0x000025AD
		internal static bool cwfPiuZoIm8LCuiGNULK()
		{
			return Class147.Class164.qwWPO4ZoTm1CusAYVDAU == null;
		}

		// Token: 0x040004F5 RID: 1269
		internal static Class147.Class164 qwWPO4ZoTm1CusAYVDAU;
	}

	// Token: 0x02000184 RID: 388
	internal class Class165 : Class147.Class164
	{
		// Token: 0x060009AA RID: 2474 RVA: 0x0002D8EC File Offset: 0x0002BAEC
		public Class165(int int_1, Class147.Class156 class156_1)
		{
			this.class156_0 = class156_1;
			this.int_0 = int_1;
			this.enum3_0 = (Class147.Enum3)7;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0002D914 File Offset: 0x0002BB14
		internal override void vmethod_10(Class147.Class158 class158_0)
		{
			if (class158_0 is Class147.Class165)
			{
				this.class156_0 = ((Class147.Class165)class158_0).class156_0;
				this.int_0 = ((Class147.Class165)class158_0).int_0;
				return;
			}
			Class147.Class150 @class = this.class156_0.class153_0.list_1[this.int_0];
			if (class158_0 is Class147.Class164 && (@class.enum0_0 & (Class147.Enum0)226) > (Class147.Enum0)0)
			{
				Class147.Class158 class158_ = (class158_0 as Class147.Class164).vmethod_8();
				this.vmethod_12(class158_);
				return;
			}
			this.vmethod_12(class158_0);
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x0002D9A0 File Offset: 0x0002BBA0
		internal override void vmethod_2(Class147.Class158 class158_0)
		{
			this.vmethod_12(class158_0);
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x000043B7 File Offset: 0x000025B7
		internal override IntPtr vmethod_11()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0002D9B4 File Offset: 0x0002BBB4
		internal override void vmethod_12(Class147.Class158 class158_0)
		{
			this.class156_0.class158_1[this.int_0] = class158_0;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0002D9D4 File Offset: 0x0002BBD4
		internal override object vmethod_4(Type type_0)
		{
			if (this.class156_0.class158_1[this.int_0] != null)
			{
				return this.vmethod_8().vmethod_4(type_0);
			}
			return null;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0002DA04 File Offset: 0x0002BC04
		internal override Class147.Class158 vmethod_8()
		{
			if (this.class156_0.class158_1[this.int_0] != null)
			{
				return this.class156_0.class158_1[this.int_0].vmethod_8();
			}
			return new Class147.Class170(null);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x000043BE File Offset: 0x000025BE
		internal override bool vmethod_9()
		{
			return this.vmethod_8().vmethod_9();
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0002DA44 File Offset: 0x0002BC44
		internal override bool vmethod_5(Class147.Class158 class158_0)
		{
			return class158_0.vmethod_0() && class158_0 is Class147.Class165 && ((Class147.Class165)class158_0).int_0 == this.int_0;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0002DA7C File Offset: 0x0002BC7C
		internal override bool vmethod_6(Class147.Class158 class158_0)
		{
			return !class158_0.vmethod_0() || !(class158_0 is Class147.Class165) || ((Class147.Class165)class158_0).int_0 != this.int_0;
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x000043CB File Offset: 0x000025CB
		internal override bool vmethod_7()
		{
			return this.vmethod_8().vmethod_7();
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x000043D8 File Offset: 0x000025D8
		internal static bool LbeKW6ZoDW1DsxEdluBR()
		{
			return Class147.Class165.xDh1EAZomq2m41y4nQqR == null;
		}

		// Token: 0x040004F6 RID: 1270
		private Class147.Class156 class156_0;

		// Token: 0x040004F7 RID: 1271
		internal int int_0;

		// Token: 0x040004F8 RID: 1272
		internal static Class147.Class165 xDh1EAZomq2m41y4nQqR;
	}

	// Token: 0x02000185 RID: 389
	internal class Class166 : Class147.Class164
	{
		// Token: 0x060009B6 RID: 2486 RVA: 0x0002DAB4 File Offset: 0x0002BCB4
		public Class166(int int_1, Array array_1)
		{
			this.array_0 = array_1;
			this.int_0 = int_1;
			this.enum3_0 = (Class147.Enum3)7;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x000043B7 File Offset: 0x000025B7
		internal override IntPtr vmethod_11()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0002DADC File Offset: 0x0002BCDC
		internal override void vmethod_10(Class147.Class158 class158_0)
		{
			if (!(class158_0 is Class147.Class166))
			{
				this.vmethod_12(class158_0);
				return;
			}
			this.array_0 = ((Class147.Class166)class158_0).array_0;
			this.int_0 = ((Class147.Class166)class158_0).int_0;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0002D9A0 File Offset: 0x0002BBA0
		internal override void vmethod_2(Class147.Class158 class158_0)
		{
			this.vmethod_12(class158_0);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0002DB1C File Offset: 0x0002BD1C
		internal override void vmethod_12(Class147.Class158 class158_0)
		{
			this.array_0.SetValue(class158_0.vmethod_4(null), this.int_0);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x000043E2 File Offset: 0x000025E2
		internal override object vmethod_4(Type type_0)
		{
			return this.vmethod_8().vmethod_4(type_0);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x000043F0 File Offset: 0x000025F0
		internal override Class147.Class158 vmethod_8()
		{
			return Class147.Class158.smethod_0(this.array_0.GetType().GetElementType(), this.array_0.GetValue(this.int_0));
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x000043BE File Offset: 0x000025BE
		internal override bool vmethod_9()
		{
			return this.vmethod_8().vmethod_9();
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0002DB44 File Offset: 0x0002BD44
		internal override bool vmethod_5(Class147.Class158 class158_0)
		{
			if (!class158_0.vmethod_0())
			{
				return false;
			}
			if (!(class158_0 is Class147.Class166))
			{
				return false;
			}
			Class147.Class166 @class = (Class147.Class166)class158_0;
			return @class.int_0 == this.int_0 && @class.array_0 == this.array_0;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0002DB90 File Offset: 0x0002BD90
		internal override bool vmethod_6(Class147.Class158 class158_0)
		{
			if (!class158_0.vmethod_0())
			{
				return true;
			}
			if (class158_0 is Class147.Class166)
			{
				Class147.Class166 @class = (Class147.Class166)class158_0;
				return @class.int_0 != this.int_0 || @class.array_0 != this.array_0;
			}
			return true;
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x000043CB File Offset: 0x000025CB
		internal override bool vmethod_7()
		{
			return this.vmethod_8().vmethod_7();
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00004418 File Offset: 0x00002618
		internal static bool zvcn00ZU16VVhdncMZIf()
		{
			return Class147.Class166.btdd23Zoz6mRuW5tBUI7 == null;
		}

		// Token: 0x040004F9 RID: 1273
		private Array array_0;

		// Token: 0x040004FA RID: 1274
		internal int int_0;

		// Token: 0x040004FB RID: 1275
		private static Class147.Class166 btdd23Zoz6mRuW5tBUI7;
	}

	// Token: 0x02000186 RID: 390
	internal class Class167 : Class147.Class164
	{
		// Token: 0x060009C2 RID: 2498 RVA: 0x0002DBDC File Offset: 0x0002BDDC
		public Class167(FieldInfo fieldInfo_1, object object_1)
		{
			this.fieldInfo_0 = fieldInfo_1;
			this.object_0 = object_1;
			this.enum3_0 = (Class147.Enum3)7;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x000043B7 File Offset: 0x000025B7
		internal override IntPtr vmethod_11()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0002DC04 File Offset: 0x0002BE04
		internal override void vmethod_12(Class147.Class158 class158_0)
		{
			if (this.object_0 != null && this.object_0 is Class147.Class158)
			{
				this.fieldInfo_0.SetValue(((Class147.Class158)this.object_0).vmethod_4(null), class158_0.vmethod_4(null));
				return;
			}
			this.fieldInfo_0.SetValue(this.object_0, class158_0.vmethod_4(null));
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0002DC64 File Offset: 0x0002BE64
		internal override void vmethod_10(Class147.Class158 class158_0)
		{
			if (class158_0 is Class147.Class167)
			{
				this.fieldInfo_0 = ((Class147.Class167)class158_0).fieldInfo_0;
				this.object_0 = ((Class147.Class167)class158_0).object_0;
				return;
			}
			this.vmethod_12(class158_0);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0002D9A0 File Offset: 0x0002BBA0
		internal override void vmethod_2(Class147.Class158 class158_0)
		{
			this.vmethod_12(class158_0);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x000043E2 File Offset: 0x000025E2
		internal override object vmethod_4(Type type_0)
		{
			return this.vmethod_8().vmethod_4(type_0);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0002DCA4 File Offset: 0x0002BEA4
		internal override Class147.Class158 vmethod_8()
		{
			if (this.object_0 != null && this.object_0 is Class147.Class158)
			{
				return Class147.Class158.smethod_0(this.fieldInfo_0.FieldType, this.fieldInfo_0.GetValue(((Class147.Class158)this.object_0).vmethod_4(null)));
			}
			return Class147.Class158.smethod_0(this.fieldInfo_0.FieldType, this.fieldInfo_0.GetValue(this.object_0));
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x000043BE File Offset: 0x000025BE
		internal override bool vmethod_9()
		{
			return this.vmethod_8().vmethod_9();
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0002DD14 File Offset: 0x0002BF14
		internal override bool vmethod_5(Class147.Class158 class158_0)
		{
			if (!class158_0.vmethod_0())
			{
				return false;
			}
			if (class158_0 is Class147.Class167)
			{
				Class147.Class167 @class = (Class147.Class167)class158_0;
				return !(@class.fieldInfo_0 != this.fieldInfo_0) && @class.object_0 == this.object_0;
			}
			return false;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0002DD68 File Offset: 0x0002BF68
		internal override bool vmethod_6(Class147.Class158 class158_0)
		{
			if (!class158_0.vmethod_0())
			{
				return true;
			}
			if (!(class158_0 is Class147.Class167))
			{
				return true;
			}
			Class147.Class167 @class = (Class147.Class167)class158_0;
			return @class.fieldInfo_0 != this.fieldInfo_0 || @class.object_0 != this.object_0;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x000043CB File Offset: 0x000025CB
		internal override bool vmethod_7()
		{
			return this.vmethod_8().vmethod_7();
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00004422 File Offset: 0x00002622
		internal static bool NEdax1ZUhBYYJMy2qPNG()
		{
			return Class147.Class167.wLh6xjZUOrahMEW5CEKs == null;
		}

		// Token: 0x040004FC RID: 1276
		internal FieldInfo fieldInfo_0;

		// Token: 0x040004FD RID: 1277
		internal object object_0;

		// Token: 0x040004FE RID: 1278
		private static Class147.Class167 wLh6xjZUOrahMEW5CEKs;
	}

	// Token: 0x02000187 RID: 391
	internal class Class168 : Class147.Class164
	{
		// Token: 0x060009CE RID: 2510 RVA: 0x0002DDBC File Offset: 0x0002BFBC
		public Class168(int int_1, Class147.Class156 class156_1)
		{
			this.class156_0 = class156_1;
			this.int_0 = int_1;
			this.enum3_0 = (Class147.Enum3)7;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000043B7 File Offset: 0x000025B7
		internal override IntPtr vmethod_11()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0002DDE4 File Offset: 0x0002BFE4
		internal override void vmethod_10(Class147.Class158 class158_0)
		{
			if (!(class158_0 is Class147.Class168))
			{
				this.vmethod_12(class158_0);
				return;
			}
			this.class156_0 = ((Class147.Class168)class158_0).class156_0;
			this.int_0 = ((Class147.Class168)class158_0).int_0;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x0002D9A0 File Offset: 0x0002BBA0
		internal override void vmethod_2(Class147.Class158 class158_0)
		{
			this.vmethod_12(class158_0);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0002DE24 File Offset: 0x0002C024
		internal override void vmethod_12(Class147.Class158 class158_0)
		{
			this.class156_0.class158_0[this.int_0] = class158_0;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0002DE44 File Offset: 0x0002C044
		internal override object vmethod_4(Type type_0)
		{
			if (this.class156_0.class158_0[this.int_0] != null)
			{
				return this.vmethod_8().vmethod_4(type_0);
			}
			return null;
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0002DE74 File Offset: 0x0002C074
		internal override Class147.Class158 vmethod_8()
		{
			if (this.class156_0.class158_0[this.int_0] == null)
			{
				return new Class147.Class170(null);
			}
			return this.class156_0.class158_0[this.int_0].vmethod_8();
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000043BE File Offset: 0x000025BE
		internal override bool vmethod_9()
		{
			return this.vmethod_8().vmethod_9();
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0002DEB4 File Offset: 0x0002C0B4
		internal override bool vmethod_5(Class147.Class158 class158_0)
		{
			return class158_0.vmethod_0() && class158_0 is Class147.Class168 && ((Class147.Class168)class158_0).int_0 == this.int_0;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0002DEE8 File Offset: 0x0002C0E8
		internal override bool vmethod_6(Class147.Class158 class158_0)
		{
			return !class158_0.vmethod_0() || !(class158_0 is Class147.Class168) || ((Class147.Class168)class158_0).int_0 != this.int_0;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000043CB File Offset: 0x000025CB
		internal override bool vmethod_7()
		{
			return this.vmethod_8().vmethod_7();
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0000442C File Offset: 0x0000262C
		internal static bool TOtyZLZUU0FEbSdwMNfV()
		{
			return Class147.Class168.YDPd9NZUod4M4pnoBhQs == null;
		}

		// Token: 0x040004FF RID: 1279
		private Class147.Class156 class156_0;

		// Token: 0x04000500 RID: 1280
		internal int int_0;

		// Token: 0x04000501 RID: 1281
		private static Class147.Class168 YDPd9NZUod4M4pnoBhQs;
	}

	// Token: 0x02000188 RID: 392
	internal class Class169 : Class147.Class164
	{
		// Token: 0x060009DA RID: 2522 RVA: 0x0002DF20 File Offset: 0x0002C120
		public Class169(Class147.Class158 class158_1, Type type_1)
		{
			this.class158_0 = class158_1;
			this.type_0 = type_1;
			this.enum3_0 = (Class147.Enum3)7;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x000043B7 File Offset: 0x000025B7
		internal override IntPtr vmethod_11()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0002DF48 File Offset: 0x0002C148
		internal override void vmethod_10(Class147.Class158 class158_1)
		{
			if (!(class158_1 is Class147.Class169))
			{
				this.class158_0.vmethod_10(class158_1);
				return;
			}
			this.type_0 = ((Class147.Class169)class158_1).type_0;
			this.class158_0 = ((Class147.Class169)class158_1).class158_0;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0002D9A0 File Offset: 0x0002BBA0
		internal override void vmethod_2(Class147.Class158 class158_1)
		{
			this.vmethod_12(class158_1);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0002DF8C File Offset: 0x0002C18C
		internal override void vmethod_12(Class147.Class158 class158_1)
		{
			this.class158_0 = class158_1;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0002DFA0 File Offset: 0x0002C1A0
		internal override object vmethod_4(Type type_1)
		{
			if (this.class158_0 == null)
			{
				return new Class147.Class170(null);
			}
			if (!(type_1 == null) && !(type_1 == typeof(object)))
			{
				return this.class158_0.vmethod_4(type_1);
			}
			return this.class158_0.vmethod_4(this.type_0);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0002DFF8 File Offset: 0x0002C1F8
		internal override Class147.Class158 vmethod_8()
		{
			if (this.class158_0 == null)
			{
				return new Class147.Class170(null);
			}
			return this.class158_0.vmethod_8();
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x000043BE File Offset: 0x000025BE
		internal override bool vmethod_9()
		{
			return this.vmethod_8().vmethod_9();
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0002E020 File Offset: 0x0002C220
		internal override bool vmethod_5(Class147.Class158 class158_1)
		{
			if (!class158_1.vmethod_0())
			{
				return false;
			}
			if (!(class158_1 is Class147.Class169))
			{
				return false;
			}
			Class147.Class169 @class = (Class147.Class169)class158_1;
			if (@class.type_0 != this.type_0)
			{
				return false;
			}
			if (this.class158_0 != null)
			{
				return this.class158_0.vmethod_5(@class.class158_0);
			}
			return @class.class158_0 == null;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0002E088 File Offset: 0x0002C288
		internal override bool vmethod_6(Class147.Class158 class158_1)
		{
			if (!class158_1.vmethod_0())
			{
				return true;
			}
			if (!(class158_1 is Class147.Class169))
			{
				return true;
			}
			Class147.Class169 @class = (Class147.Class169)class158_1;
			if (@class.type_0 != this.type_0)
			{
				return true;
			}
			if (this.class158_0 == null)
			{
				return @class.class158_0 != null;
			}
			return this.class158_0.vmethod_6(@class.class158_0);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000043CB File Offset: 0x000025CB
		internal override bool vmethod_7()
		{
			return this.vmethod_8().vmethod_7();
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00004436 File Offset: 0x00002636
		internal static bool f9OVFWZUiMquF1fNPylS()
		{
			return Class147.Class169.wKPEU9ZUHsZPjSWXeCcT == null;
		}

		// Token: 0x04000502 RID: 1282
		private Class147.Class158 class158_0;

		// Token: 0x04000503 RID: 1283
		private Type type_0;

		// Token: 0x04000504 RID: 1284
		internal static Class147.Class169 wKPEU9ZUHsZPjSWXeCcT;
	}

	// Token: 0x02000189 RID: 393
	internal class Class149
	{
		// Token: 0x060009E7 RID: 2535 RVA: 0x00004440 File Offset: 0x00002640
		internal static bool POrPrWZUJpOMoyNYZkOI()
		{
			return Class147.Class149.o7vPWGZU81QdwZv6Oujs == null;
		}

		// Token: 0x04000505 RID: 1285
		public int int_0;

		// Token: 0x04000506 RID: 1286
		public bool bool_0;

		// Token: 0x04000507 RID: 1287
		public Class147.Enum0 enum0_0;

		// Token: 0x04000508 RID: 1288
		private static Class147.Class149 o7vPWGZU81QdwZv6Oujs;
	}

	// Token: 0x0200018A RID: 394
	internal class Class150
	{
		// Token: 0x060009E9 RID: 2537 RVA: 0x0000444A File Offset: 0x0000264A
		internal static bool zyKqVNZUMINGhDbndNlf()
		{
			return Class147.Class150.SYRxk5ZUu1r56cqwFnUy == null;
		}

		// Token: 0x04000509 RID: 1289
		public int int_0;

		// Token: 0x0400050A RID: 1290
		public Class147.Enum0 enum0_0;

		// Token: 0x0400050B RID: 1291
		public bool bool_0;

		// Token: 0x0400050C RID: 1292
		public Type type_0 = typeof(object);

		// Token: 0x0400050D RID: 1293
		internal static Class147.Class150 SYRxk5ZUu1r56cqwFnUy;
	}

	// Token: 0x0200018B RID: 395
	internal class Class151
	{
		// Token: 0x060009EB RID: 2539 RVA: 0x00004454 File Offset: 0x00002654
		internal static bool Xea3jqZUFEINPA6hCDk5()
		{
			return Class147.Class151.DPiREaZUdOgWk5wNqJng == null;
		}

		// Token: 0x0400050E RID: 1294
		public int int_0;

		// Token: 0x0400050F RID: 1295
		public int int_1;

		// Token: 0x04000510 RID: 1296
		public Class147.Class152 class152_0;

		// Token: 0x04000511 RID: 1297
		internal static Class147.Class151 DPiREaZUdOgWk5wNqJng;
	}

	// Token: 0x0200018C RID: 396
	internal class Class152
	{
		// Token: 0x060009ED RID: 2541 RVA: 0x0000445E File Offset: 0x0000265E
		internal static bool K4jXfFZUv7HWg5CvUoms()
		{
			return Class147.Class152.lWu7V3ZUxO5LyMf76B61 == null;
		}

		// Token: 0x04000512 RID: 1298
		public int int_0;

		// Token: 0x04000513 RID: 1299
		public int int_1;

		// Token: 0x04000514 RID: 1300
		public byte byte_0;

		// Token: 0x04000515 RID: 1301
		public Type type_0;

		// Token: 0x04000516 RID: 1302
		public int int_2;

		// Token: 0x04000517 RID: 1303
		public int int_3;

		// Token: 0x04000518 RID: 1304
		internal static Class147.Class152 lWu7V3ZUxO5LyMf76B61;
	}

	// Token: 0x0200018D RID: 397
	internal class Class153
	{
		// Token: 0x060009EF RID: 2543 RVA: 0x00004468 File Offset: 0x00002668
		internal static bool xfFlGTZUypa4bV5s6wm6()
		{
			return Class147.Class153.LQqv9DZUCISyMalPnPBQ == null;
		}

		// Token: 0x04000519 RID: 1305
		internal MethodBase methodBase_0;

		// Token: 0x0400051A RID: 1306
		internal List<Class147.Class148> list_0;

		// Token: 0x0400051B RID: 1307
		internal Class147.Class149[] class149_0;

		// Token: 0x0400051C RID: 1308
		internal List<Class147.Class150> list_1;

		// Token: 0x0400051D RID: 1309
		internal List<Class147.Class151> list_2;

		// Token: 0x0400051E RID: 1310
		internal static Class147.Class153 LQqv9DZUCISyMalPnPBQ;
	}

	// Token: 0x0200018E RID: 398
	private class Class154
	{
		// Token: 0x060009F0 RID: 2544 RVA: 0x0002E114 File Offset: 0x0002C314
		public Class154(FieldInfo fieldInfo_1, int int_1)
		{
			this.fieldInfo_0 = fieldInfo_1;
			this.int_0 = int_1;
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00004472 File Offset: 0x00002672
		internal static bool uWphDYZUbBwHtklOqF1j()
		{
			return Class147.Class154.Q4JRDpZUciuYtgGT5vbA == null;
		}

		// Token: 0x0400051F RID: 1311
		internal FieldInfo fieldInfo_0;

		// Token: 0x04000520 RID: 1312
		internal int int_0;

		// Token: 0x04000521 RID: 1313
		internal static Class147.Class154 Q4JRDpZUciuYtgGT5vbA;
	}

	// Token: 0x0200018F RID: 399
	private class Class155
	{
		// Token: 0x060009F2 RID: 2546 RVA: 0x0000447C File Offset: 0x0000267C
		public Class155(MethodBase methodBase_1, List<Class147.Class154> list_1)
		{
			this.list_0 = list_1;
			this.methodBase_0 = methodBase_1;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0002E138 File Offset: 0x0002C338
		public Class155(MethodBase methodBase_1, Class147.Class154[] class154_0)
		{
			this.list_0.AddRange(class154_0);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0002E164 File Offset: 0x0002C364
		public override bool Equals(object obj)
		{
			Class147.Class155 @class = obj as Class147.Class155;
			if (obj == null)
			{
				return false;
			}
			if (this.methodBase_0 != @class.methodBase_0)
			{
				return false;
			}
			if (this.list_0.Count != @class.list_0.Count)
			{
				return false;
			}
			for (int i = 0; i < this.list_0.Count; i++)
			{
				if (this.list_0[i].fieldInfo_0 != @class.list_0[i].fieldInfo_0)
				{
					return false;
				}
				if (this.list_0[i].int_0 != @class.list_0[i].int_0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0002E228 File Offset: 0x0002C428
		public override int GetHashCode()
		{
			int num = this.methodBase_0.GetHashCode();
			foreach (Class147.Class154 @class in this.list_0)
			{
				int num2 = @class.fieldInfo_0.GetHashCode() + @class.int_0;
				num = (num ^ num2) + num2;
			}
			return num;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0002E2A8 File Offset: 0x0002C4A8
		public Class147.Class154 method_0(int int_0)
		{
			foreach (Class147.Class154 @class in this.list_0)
			{
				if (@class.int_0 == int_0)
				{
					return @class;
				}
			}
			return null;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0002E310 File Offset: 0x0002C510
		public bool method_1(int int_0)
		{
			using (List<Class147.Class154>.Enumerator enumerator = this.list_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.int_0 == int_0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0000449D File Offset: 0x0000269D
		internal static bool eELRF2ZUrlspQki3rpk5()
		{
			return Class147.Class155.sLLFsFZUf6UvD7qk05oM == null;
		}

		// Token: 0x04000522 RID: 1314
		private List<Class147.Class154> list_0 = new List<Class147.Class154>();

		// Token: 0x04000523 RID: 1315
		private MethodBase methodBase_0;

		// Token: 0x04000524 RID: 1316
		internal static Class147.Class155 sLLFsFZUf6UvD7qk05oM;
	}

	// Token: 0x02000190 RID: 400
	// (Invoke) Token: 0x060009FA RID: 2554
	private delegate object Delegate40(object target, object[] paramters);

	// Token: 0x02000191 RID: 401
	// (Invoke) Token: 0x060009FE RID: 2558
	private delegate object Delegate41(ref object target, object[] paramters);

	// Token: 0x02000192 RID: 402
	// (Invoke) Token: 0x06000A02 RID: 2562
	private delegate object Delegate42(object target);

	// Token: 0x02000193 RID: 403
	// (Invoke) Token: 0x06000A06 RID: 2566
	private delegate void Delegate43(IntPtr a, byte b, int c);

	// Token: 0x02000194 RID: 404
	// (Invoke) Token: 0x06000A0A RID: 2570
	private delegate void Delegate44(IntPtr s, IntPtr t, uint c);

	// Token: 0x02000195 RID: 405
	internal class Class156
	{
		// Token: 0x06000A0D RID: 2573 RVA: 0x0002E370 File Offset: 0x0002C570
		internal void method_0()
		{
			bool flag = false;
			this.method_2(ref flag);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0002E388 File Offset: 0x0002C588
		internal void method_1()
		{
			this.class172_0.method_1();
			this.class158_1 = null;
			if (this.list_0 != null)
			{
				foreach (IntPtr hglobal in this.list_0)
				{
					try
					{
						Marshal.FreeHGlobal(hglobal);
					}
					catch
					{
					}
				}
				this.list_0.Clear();
				this.list_0 = null;
			}
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0002E41C File Offset: 0x0002C61C
		internal void method_2(ref bool bool_4)
		{
			while (this.int_0 > -2)
			{
				if (this.bool_0)
				{
					this.bool_0 = false;
					int num = this.int_1;
					int num2 = this.int_0;
					this.method_4(this.int_1, this.int_0);
					this.int_0 = num2;
					this.int_1 = num;
				}
				if (this.bool_2)
				{
					this.bool_2 = false;
					return;
				}
				if (!this.bool_1)
				{
					this.int_1 = this.int_0;
					Class147.Class148 @class = this.class153_0.list_0[this.int_0];
					this.object_0 = @class.object_0;
					try
					{
						this.method_7(@class);
					}
					catch (Exception innerException)
					{
						if (innerException is TargetInvocationException)
						{
							TargetInvocationException ex = (TargetInvocationException)innerException;
							if (ex.InnerException != null)
							{
								innerException = ex.InnerException;
							}
						}
						this.exception_0 = innerException;
						bool_4 = true;
						this.class172_0.method_1();
						int int_ = this.int_1;
						Class147.Class151 class2 = this.method_5(int_, innerException);
						List<Class147.Class151> list = this.method_6(int_, false);
						List<Class147.Class151> list2 = new List<Class147.Class151>();
						if (class2 != null)
						{
							list2.Add(class2);
						}
						if (list != null && list.Count > 0)
						{
							list2.AddRange(list);
						}
						list2.Sort(new Comparison<Class147.Class151>(Class147.Class156.Class157.<>9.method_0));
						Class147.Class151 class3 = null;
						foreach (Class147.Class151 class4 in list2)
						{
							if (class4.class152_0.int_3 != 0)
							{
								this.class172_0.method_2(new Class147.Class170(innerException));
								this.int_1 = class4.class152_0.int_2;
								this.int_0 = this.int_1;
								this.method_0();
								if (!this.bool_3)
								{
									continue;
								}
								this.bool_3 = false;
								class3 = class4;
							}
							else
							{
								class3 = class4;
							}
							break;
						}
						if (class3 != null)
						{
							this.int_2 = class3.class152_0.int_0;
							this.method_3(int_, class3.class152_0.int_0);
							if (this.int_2 >= 0)
							{
								this.class172_0.method_2(new Class147.Class170(innerException));
								this.int_1 = this.int_2;
								this.int_0 = this.int_1;
								this.int_2 = -1;
								this.method_0();
							}
							return;
						}
						throw innerException;
					}
					this.int_0++;
					continue;
				}
				this.bool_1 = false;
				return;
			}
			this.class172_0.method_1();
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0002E6DC File Offset: 0x0002C8DC
		internal void method_3(int int_3, int int_4)
		{
			if (this.class153_0.list_2 != null)
			{
				foreach (Class147.Class151 @class in this.class153_0.list_2)
				{
					if ((@class.class152_0.int_3 == 4 || @class.class152_0.int_3 == 2) && @class.class152_0.int_0 >= int_3 && @class.class152_0.int_1 <= int_4)
					{
						this.int_1 = @class.class152_0.int_0;
						this.int_0 = this.int_1;
						bool flag = false;
						this.method_2(ref flag);
						if (flag)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x0002E7AC File Offset: 0x0002C9AC
		internal void method_4(int int_3, int int_4)
		{
			if (this.class153_0.list_2 != null)
			{
				foreach (Class147.Class151 @class in this.class153_0.list_2)
				{
					if (@class.class152_0.int_3 == 2 && @class.class152_0.int_0 >= int_3 && @class.class152_0.int_1 <= int_4)
					{
						this.int_1 = @class.class152_0.int_0;
						this.int_0 = this.int_1;
						bool flag = false;
						this.method_2(ref flag);
						if (flag)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0002E86C File Offset: 0x0002CA6C
		internal Class147.Class151 method_5(int int_3, Exception exception_1)
		{
			Class147.Class151 @class = null;
			if (this.class153_0.list_2 != null)
			{
				foreach (Class147.Class151 class2 in this.class153_0.list_2)
				{
					if (class2.class152_0 != null && class2.class152_0.int_3 == 0 && (class2.class152_0.type_0 == exception_1.GetType() || (class2.class152_0.type_0 != null && (class2.class152_0.type_0.FullName == exception_1.GetType().FullName || class2.class152_0.type_0.FullName == typeof(object).FullName || class2.class152_0.type_0.FullName == typeof(Exception).FullName))) && int_3 >= class2.int_0 && int_3 <= class2.int_1)
					{
						if (@class == null)
						{
							@class = class2;
						}
						else if (class2.class152_0.int_0 < @class.class152_0.int_0)
						{
							@class = class2;
						}
					}
				}
			}
			return @class;
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x0002E9E4 File Offset: 0x0002CBE4
		internal List<Class147.Class151> method_6(int int_3, bool bool_4)
		{
			if (this.class153_0.list_2 == null)
			{
				return null;
			}
			List<Class147.Class151> list = new List<Class147.Class151>();
			foreach (Class147.Class151 @class in this.class153_0.list_2)
			{
				if ((@class.class152_0.int_3 & 1) == 1 && int_3 >= @class.int_0 && int_3 <= @class.int_1)
				{
					list.Add(@class);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			return list;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0002EA80 File Offset: 0x0002CC80
		private unsafe void method_7(Class147.Class148 class148_0)
		{
			switch (class148_0.enum2_0)
			{
			case (Class147.Enum2)0:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class172_0.method_2(class2.vmethod_59(@class));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)1:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (class3.vmethod_3())
				{
					class3 = ((Class147.Class159)class3).vmethod_24();
				}
				this.class172_0.method_4().vmethod_2(class3);
				return;
			}
			case (Class147.Enum2)2:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_50());
				return;
			}
			case (Class147.Enum2)3:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null)
				{
					this.class172_0.method_2(@class.vmethod_46());
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)4:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class147).Module.ResolveType(num);
				Class147.Class164 class4 = this.class172_0.method_4() as Class147.Class164;
				if (class4 == null)
				{
					throw new Class147.Exception1();
				}
				if (type.IsValueType)
				{
					object obj = Activator.CreateInstance(type);
					class4.vmethod_12(Class147.Class158.smethod_0(type, obj));
					return;
				}
				class4.vmethod_12(new Class147.Class170(null));
				return;
			}
			case (Class147.Enum2)5:
				throw this.exception_0;
			case (Class147.Enum2)6:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_22());
				return;
			}
			case (Class147.Enum2)7:
			case (Class147.Enum2)20:
			case (Class147.Enum2)26:
			case (Class147.Enum2)42:
			case (Class147.Enum2)59:
			case (Class147.Enum2)107:
			case (Class147.Enum2)118:
			case (Class147.Enum2)167:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Array array = (Array)this.class172_0.method_4().vmethod_4(null);
				Type type = array.GetType().GetElementType();
				array.SetValue(class3.vmethod_4(type), @class.LtAcwclWeT().struct3_0.int_0);
				return;
			}
			case (Class147.Enum2)8:
			{
				IntPtr intPtr = Marshal.AllocHGlobal((this.class172_0.method_4() as Class147.Class159).LtAcwclWeT().struct3_0.int_0);
				if (this.list_0 == null)
				{
					this.list_0 = new List<IntPtr>();
				}
				this.list_0.Add(intPtr);
				this.class172_0.method_2(new Class147.Class162(intPtr));
				return;
			}
			case (Class147.Enum2)9:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (!class3.vmethod_0())
				{
					throw new Class147.Exception1();
				}
				object obj = class3.vmethod_4(null);
				if (obj != null)
				{
					class3 = Class147.Class158.smethod_0(obj.GetType(), obj);
				}
				else
				{
					class3 = new Class147.Class170(null);
				}
				this.class172_0.method_2(class3);
				return;
			}
			case (Class147.Enum2)10:
			case (Class147.Enum2)46:
			case (Class147.Enum2)89:
			case (Class147.Enum2)122:
			case (Class147.Enum2)169:
			case (Class147.Enum2)170:
				throw new Class147.Exception1();
			case (Class147.Enum2)11:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class147).Module.ResolveType(num);
				Class147.Class158 class3 = this.class172_0.method_4();
				object obj = class3.vmethod_4(null);
				if (obj == null)
				{
					this.class172_0.method_2(new Class147.Class170(null));
					return;
				}
				if (!type.IsAssignableFrom(obj.GetType()))
				{
					this.class172_0.method_2(new Class147.Class170(null));
					return;
				}
				this.class172_0.method_2(class3);
				return;
			}
			case (Class147.Enum2)12:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_31());
				return;
			}
			case (Class147.Enum2)13:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class147).Module.ResolveType(num);
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				object obj = ((Array)this.class172_0.method_4().vmethod_4(null)).GetValue(@class.LtAcwclWeT().struct3_0.int_0);
				this.class172_0.method_2(Class147.Class158.smethod_0(type, obj));
				return;
			}
			case (Class147.Enum2)14:
				this.int_0 = (int)this.object_0 - 1;
				this.bool_0 = true;
				return;
			case (Class147.Enum2)15:
				this.class172_0.method_2(new Class147.Class163((double)this.object_0));
				return;
			case (Class147.Enum2)16:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (Class147.Class156.smethod_1(this.class172_0.method_4()).vmethod_80(class3))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class147.Enum2)17:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				object obj = ((Array)this.class172_0.method_4().vmethod_4(null)).GetValue(@class.LtAcwclWeT().struct3_0.int_0);
				this.class172_0.method_2(Class147.Class158.smethod_0(typeof(byte), obj));
				return;
			}
			case (Class147.Enum2)18:
				if (Class147.list_0.Count == 0)
				{
					Module module = typeof(Class147).Module;
					this.class172_0.method_2(new Class147.Class171(module.ResolveString((int)this.object_0 | 1879048192)));
					return;
				}
				this.class172_0.method_2(new Class147.Class171(Class147.list_0[(int)this.object_0]));
				return;
			case (Class147.Enum2)19:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				Class147.Class159 @class = Class147.Class156.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class172_0.method_2(@class.vmethod_24());
					return;
				}
				if (@class != null && @class.method_2())
				{
					IntPtr intPtr = ((Class147.Class162)@class).method_7();
					this.class172_0.method_2(new Class147.Class160(*(int*)((void*)intPtr), (Class147.Enum0)5));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)21:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null)
				{
					this.class172_0.method_2(@class.vmethod_26());
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)22:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				object obj = ((Array)this.class172_0.method_4().vmethod_4(null)).GetValue(@class.LtAcwclWeT().struct3_0.int_0);
				this.class172_0.method_2(Class147.Class158.smethod_0(typeof(IntPtr), obj));
				return;
			}
			case (Class147.Enum2)23:
			case (Class147.Enum2)55:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class147).Module.ResolveType(num);
				Class147.Class158 class3 = this.class172_0.method_4();
				object obj = class3.vmethod_4(type);
				if (obj != null)
				{
					if (type.IsValueType)
					{
						obj = Class147.Class156.smethod_10(obj);
					}
					class3 = Class147.Class158.smethod_0(type, obj);
				}
				else if (!type.IsValueType)
				{
					class3 = new Class147.Class170(null);
				}
				else
				{
					obj = Activator.CreateInstance(type);
					class3 = Class147.Class158.smethod_0(type, obj);
				}
				Class147.Class164 class5 = this.class172_0.method_4() as Class147.Class164;
				if (class5 == null)
				{
					throw new Class147.Exception1();
				}
				class5.vmethod_10(class3);
				return;
			}
			case (Class147.Enum2)24:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				bool flag = Class147.Class156.smethod_1(this.class172_0.method_4()).vmethod_82(class3);
				if (!flag)
				{
					this.class172_0.method_2(new Class147.Class160(0));
				}
				else
				{
					this.class172_0.method_2(new Class147.Class160(1));
				}
				if (flag)
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class147.Enum2)25:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null)
				{
					this.class172_0.method_2(@class.vmethod_51());
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)27:
			case (Class147.Enum2)69:
			case (Class147.Enum2)113:
			case (Class147.Enum2)115:
			case (Class147.Enum2)163:
			case (Class147.Enum2)164:
				return;
			case (Class147.Enum2)28:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class172_0.method_2(class2.vmethod_65(@class));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)29:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null && class2 != null)
				{
					this.class172_0.method_2(@class.vmethod_68(class2));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)30:
			{
				Class147.Class159 class6 = Class147.Class156.smethod_1(this.class172_0.method_3());
				if (class6 != null)
				{
					Class147.Class163 class7 = class6 as Class147.Class163;
					if (class7 != null)
					{
						if (double.IsNaN(class7.double_0))
						{
							throw new OverflowException(((Class147.Enum4)2).ToString());
						}
						if (double.IsInfinity(class7.double_0))
						{
							throw new OverflowException(((Class147.Enum4)1).ToString());
						}
					}
					return;
				}
				throw new ArithmeticException(((Class147.Enum4)0).ToString());
			}
			case (Class147.Enum2)31:
				this.bool_2 = true;
				return;
			case (Class147.Enum2)32:
			{
				Class147.Class159 @class = this.class172_0.method_4() as Class147.Class159;
				IntPtr intPtr = Class147.Class156.smethod_9(this.class172_0.method_4());
				IntPtr intPtr2 = Class147.Class156.smethod_9(this.class172_0.method_4());
				if (intPtr != IntPtr.Zero && intPtr2 != IntPtr.Zero)
				{
					uint num2 = @class.vmethod_19().struct3_0.uint_0;
					Class147.Class156.smethod_12(intPtr2, intPtr, num2);
				}
				return;
			}
			case (Class147.Enum2)33:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class172_0.method_2(class2.vmethod_66(@class));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)34:
				this.class172_0.method_2(this.class172_0.method_3());
				return;
			case (Class147.Enum2)35:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (Class147.Class156.smethod_1(this.class172_0.method_4()).vmethod_75(class3))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class147.Enum2)36:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				object obj = ((Array)this.class172_0.method_4().vmethod_4(null)).GetValue(@class.LtAcwclWeT().struct3_0.int_0);
				this.class172_0.method_2(Class147.Class158.smethod_0(typeof(int), obj));
				return;
			}
			case (Class147.Enum2)37:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_49());
				return;
			}
			case (Class147.Enum2)38:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				Class147.Class159 @class = Class147.Class156.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class172_0.method_2(@class.vmethod_23());
					return;
				}
				if (@class != null && @class.method_2())
				{
					IntPtr intPtr = ((Class147.Class162)@class).method_7();
					this.class172_0.method_2(new Class147.Class160((int)(*(short*)((void*)intPtr)), (Class147.Enum0)3));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)39:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class172_0.method_2(class2.vmethod_60(@class));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)40:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null)
				{
					this.class172_0.method_2(@class.vmethod_25());
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)41:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class147).Module.ResolveField(num);
				object obj = this.class172_0.method_4().vmethod_4(fieldInfo.FieldType);
				fieldInfo.SetValue(null, obj);
				return;
			}
			case (Class147.Enum2)43:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (!Class147.Class156.smethod_1(this.class172_0.method_4()).vmethod_77(class3))
				{
					this.class172_0.method_2(new Class147.Class160(0));
					return;
				}
				this.class172_0.method_2(new Class147.Class160(1));
				return;
			}
			case (Class147.Enum2)44:
				this.int_0 = -3;
				if (this.class172_0.method_0() > 0)
				{
					this.class158_2 = this.class172_0.method_4();
				}
				return;
			case (Class147.Enum2)45:
			{
				int num = (int)this.object_0;
				ConstructorInfo constructorInfo = (ConstructorInfo)typeof(Class147).Module.ResolveMethod(num);
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				object[] array2 = new object[parameters.Length];
				Class147.Class158[] array3 = new Class147.Class158[parameters.Length];
				List<Class147.Class154> list = null;
				Class147.Class155 class8 = null;
				for (int i = 0; i < parameters.Length; i++)
				{
					Class147.Class158 class3 = this.class172_0.method_4();
					Type type = parameters[parameters.Length - 1 - i].ParameterType;
					object obj2 = null;
					bool flag2 = false;
					if (type.IsByRef)
					{
						Class147.Class167 class9 = class3 as Class147.Class167;
						if (class9 != null)
						{
							if (list == null)
							{
								list = new List<Class147.Class154>();
							}
							list.Add(new Class147.Class154(class9.fieldInfo_0, parameters.Length - 1 - i));
							obj2 = class9.object_0;
							if (obj2 is Class147.Class158)
							{
								class3 = (obj2 as Class147.Class158);
							}
							else
							{
								flag2 = true;
							}
						}
					}
					if (!flag2)
					{
						if (class3 != null)
						{
							obj2 = class3.vmethod_4(type);
						}
						if (obj2 == null)
						{
							if (type.IsByRef)
							{
								type = type.GetElementType();
							}
							if (type.IsValueType)
							{
								obj2 = Activator.CreateInstance(type);
								if (class3 is Class147.Class165)
								{
									((Class147.Class164)class3).vmethod_12(Class147.Class158.smethod_0(type, obj2));
								}
							}
						}
					}
					array3[array2.Length - 1 - i] = class3;
					array2[array2.Length - 1 - i] = obj2;
				}
				Class147.Delegate40 @delegate = null;
				if (list != null)
				{
					class8 = new Class147.Class155(constructorInfo, list);
					@delegate = Class147.Class156.smethod_4(constructorInfo, true, class8);
				}
				object obj = null;
				if (@delegate != null)
				{
					obj = @delegate(null, array2);
				}
				else
				{
					obj = constructorInfo.Invoke(array2);
				}
				for (int j = 0; j < parameters.Length; j++)
				{
					if (parameters[j].ParameterType.IsByRef && (class8 == null || !class8.method_1(j)))
					{
						if (array3[j].method_2())
						{
							((Class147.Class162)array3[j]).method_6(Class147.Class158.smethod_0(parameters[j].ParameterType, array2[j]));
						}
						else if (!(array3[j] is Class147.Class165))
						{
							array3[j].vmethod_10(Class147.Class158.smethod_0(parameters[j].ParameterType, array2[j]));
						}
						else
						{
							array3[j].vmethod_10(Class147.Class158.smethod_0(parameters[j].ParameterType.GetElementType(), array2[j]));
						}
					}
				}
				this.class172_0.method_2(Class147.Class158.smethod_0(constructorInfo.DeclaringType, obj));
				return;
			}
			case (Class147.Enum2)47:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = (Class147.Class159)this.class172_0.method_4();
				if (class2 != null && @class != null)
				{
					this.class172_0.method_2(class2.vmethod_58(@class));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)48:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (Class147.Class156.smethod_1(this.class172_0.method_4()).vmethod_79(class3))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class147.Enum2)49:
			{
				int num = (int)this.object_0;
				this.class172_0.method_2(this.class158_0[num]);
				return;
			}
			case (Class147.Enum2)50:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_27());
				return;
			}
			case (Class147.Enum2)51:
				this.class172_0.method_2(new Class147.Class160((int)this.object_0));
				return;
			case (Class147.Enum2)52:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_37());
				return;
			}
			case (Class147.Enum2)53:
			{
				Class147.Class158 class10 = this.class172_0.method_4();
				Class147.Class158 class3 = this.class172_0.method_4();
				if (class10.vmethod_5(class3))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class147.Enum2)54:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (Class147.Class156.smethod_1(this.class172_0.method_4()).vmethod_81(class3))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class147.Enum2)56:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null)
				{
					this.class172_0.method_2(@class.vmethod_44());
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)57:
			{
				int num = (int)this.object_0;
				this.class158_1[num] = this.method_8(this.class172_0.method_4(), this.class153_0.list_1[num].enum0_0, this.class153_0.list_1[num].bool_0);
				return;
			}
			case (Class147.Enum2)58:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null)
				{
					this.class172_0.method_2(@class.vmethod_36());
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)60:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (Class147.Class156.smethod_1(this.class172_0.method_4()).vmethod_81(class3))
				{
					this.class172_0.method_2(new Class147.Class160(1));
					return;
				}
				this.class172_0.method_2(new Class147.Class160(0));
				return;
			}
			case (Class147.Enum2)61:
				this.bApfYhsCem(false);
				return;
			case (Class147.Enum2)62:
				throw (Exception)this.class172_0.method_4().vmethod_4(null);
			case (Class147.Enum2)63:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_28());
				return;
			}
			case (Class147.Enum2)64:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class172_0.method_2(class2.vmethod_56(@class));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)65:
			{
				Array array4 = (Array)this.class172_0.method_4().vmethod_4(null);
				this.class172_0.method_2(new Class147.Class160(array4.Length, (Class147.Enum0)5));
				return;
			}
			case (Class147.Enum2)66:
			{
				int num = (int)this.object_0;
				Type elementType = typeof(Class147).Module.ResolveType(num);
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Array array4 = Array.CreateInstance(elementType, @class.LtAcwclWeT().struct3_0.int_0);
				this.class172_0.method_2(new Class147.Class170(array4));
				return;
			}
			case (Class147.Enum2)67:
				this.class172_0.method_2(((Class147.Class159)this.class172_0.method_4()).vmethod_54());
				return;
			case (Class147.Enum2)68:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (Class147.Class156.smethod_1(this.class172_0.method_4()).vmethod_76(class3))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class147.Enum2)70:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null)
				{
					this.class172_0.method_2(@class.vmethod_23());
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)71:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class172_0.method_2(class2.vmethod_74(@class));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)72:
			{
				int num = (int)this.object_0;
				uint num2 = (uint)Class147.Class156.smethod_0(typeof(Class147).Module.ResolveType(num));
				this.class172_0.method_2(new Class147.Class160(num2, (Class147.Enum0)6));
				return;
			}
			case (Class147.Enum2)73:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (class3.vmethod_3())
				{
					class3 = ((Class147.Class159)class3).vmethod_25();
				}
				this.class172_0.method_4().vmethod_2(class3);
				return;
			}
			case (Class147.Enum2)74:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_33());
				return;
			}
			case (Class147.Enum2)75:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (class3.vmethod_3())
				{
					class3 = ((Class147.Class159)class3).vmethod_48();
				}
				this.class172_0.method_4().vmethod_2(class3);
				return;
			}
			case (Class147.Enum2)76:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				Class147.Class159 @class = Class147.Class156.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class172_0.method_2(@class.vmethod_25());
					return;
				}
				if (@class != null && @class.method_2())
				{
					IntPtr intPtr = ((Class147.Class162)@class).method_7();
					this.class172_0.method_2(new Class147.Class161(*(long*)((void*)intPtr), (Class147.Enum0)7));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)77:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (!Class147.Class156.smethod_1(this.class172_0.method_4()).vmethod_82(class3))
				{
					this.class172_0.method_2(new Class147.Class160(0));
					return;
				}
				this.class172_0.method_2(new Class147.Class160(1));
				return;
			}
			case (Class147.Enum2)78:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				Class147.Class159 @class = Class147.Class156.smethod_1(class3);
				Class147.Class158 class158_ = this.class172_0.method_4();
				Class147.Class159 class2 = Class147.Class156.smethod_1(class158_);
				if (class2 != null && @class != null)
				{
					if (!class2.vmethod_78(class3))
					{
						this.class172_0.method_2(new Class147.Class160(0));
						return;
					}
					this.class172_0.method_2(new Class147.Class160(1));
					return;
				}
				else
				{
					if (class3.vmethod_6(class158_))
					{
						this.class172_0.method_2(new Class147.Class160(1));
						return;
					}
					this.class172_0.method_2(new Class147.Class160(0));
					return;
				}
				break;
			}
			case (Class147.Enum2)79:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class172_0.method_2(class2.vmethod_62(@class));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)80:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null)
				{
					this.class172_0.method_2(@class.tPncmNfto2());
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)81:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class147).Module.ResolveField(num);
				object obj = this.class172_0.method_4().vmethod_4(fieldInfo.FieldType);
				Class147.Class158 class3 = this.class172_0.method_4();
				object obj2 = class3.vmethod_4(null);
				if (obj2 == null)
				{
					Type type = fieldInfo.DeclaringType;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					if (!type.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj2 = Activator.CreateInstance(type);
					if (class3 is Class147.Class165)
					{
						((Class147.Class164)class3).vmethod_12(Class147.Class158.smethod_0(type, obj2));
					}
				}
				fieldInfo.SetValue(obj2, obj);
				return;
			}
			case (Class147.Enum2)82:
			{
				int num = (int)this.object_0;
				Module module = typeof(Class147).Module;
				this.class172_0.method_2(new Class147.Class162(module.ResolveMethod(num).MethodHandle.GetFunctionPointer()));
				return;
			}
			case (Class147.Enum2)83:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_52());
				return;
			}
			case (Class147.Enum2)84:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_35());
				return;
			}
			case (Class147.Enum2)85:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null)
				{
					this.class172_0.method_2(@class.vmethod_32());
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)86:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class172_0.method_2(class2.vmethod_72(@class));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)87:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class172_0.method_2(class2.vmethod_57(@class));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)88:
			{
				int num = (int)this.object_0;
				Module module = typeof(Class147).Module;
				object obj = null;
				try
				{
					obj = module.ResolveType(num);
				}
				catch
				{
					try
					{
						obj = module.ResolveMethod(num);
					}
					catch
					{
						try
						{
							obj = module.ResolveField(num);
						}
						catch
						{
							obj = module.ResolveMember(num);
						}
					}
				}
				this.class172_0.method_2(new Class147.Class170(obj));
				return;
			}
			case (Class147.Enum2)90:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				object obj = ((Array)this.class172_0.method_4().vmethod_4(null)).GetValue(@class.LtAcwclWeT().struct3_0.int_0);
				this.class172_0.method_2(Class147.Class158.smethod_0(typeof(short), obj));
				return;
			}
			case (Class147.Enum2)91:
				this.int_0 = (int)this.object_0 - 1;
				return;
			case (Class147.Enum2)92:
			{
				int num = (int)this.object_0;
				if (this.class153_0.methodBase_0.IsStatic)
				{
					this.class158_0[num] = this.method_8(this.class172_0.method_4(), this.class153_0.class149_0[num].enum0_0, false);
					return;
				}
				this.class158_0[num] = this.method_8(this.class172_0.method_4(), this.class153_0.class149_0[num - 1].enum0_0, false);
				return;
			}
			case (Class147.Enum2)93:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class147).Module.ResolveType(num);
				Class147.Class158 class3 = this.class172_0.method_4();
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				((Array)this.class172_0.method_4().vmethod_4(null)).SetValue(class3.vmethod_4(type), @class.LtAcwclWeT().struct3_0.int_0);
				return;
			}
			case (Class147.Enum2)94:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class147).Module.ResolveField(num);
				this.class172_0.method_2(Class147.Class158.smethod_0(fieldInfo.FieldType, fieldInfo.GetValue(null)));
				return;
			}
			case (Class147.Enum2)95:
			{
				object obj = Class147.Class156.object_2;
				lock (obj)
				{
					Class147.Class158 class3 = this.class172_0.method_4();
					object obj2 = this.class172_0.method_4().vmethod_4(null);
					Class147.Class156.dictionary_1[obj2] = class3;
				}
				return;
			}
			case (Class147.Enum2)96:
			{
				Type type = typeof(Class147).Module.ResolveType((int)this.object_0);
				object obj = this.class172_0.method_4().vmethod_4(type);
				if (obj == null)
				{
					obj = Activator.CreateInstance(type);
				}
				Class147.Class170 class11 = new Class147.Class170(Class147.Class158.smethod_0(type, Class147.Class156.smethod_10(obj)));
				this.class172_0.method_2(class11);
				return;
			}
			case (Class147.Enum2)97:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (class3.vmethod_3())
				{
					class3 = ((Class147.Class159)class3).vmethod_45();
				}
				this.class172_0.method_4().vmethod_2(class3);
				return;
			}
			case (Class147.Enum2)98:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null && class2 != null)
				{
					this.class172_0.method_2(@class.vmethod_70(class2));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)99:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_39());
				return;
			}
			case (Class147.Enum2)100:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				Class147.Class159 @class = Class147.Class156.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class172_0.method_2(@class.vmethod_26());
					return;
				}
				if (@class != null && @class.method_2())
				{
					IntPtr intPtr = ((Class147.Class162)@class).method_7();
					this.class172_0.method_2(new Class147.Class160((int)(*(byte*)((void*)intPtr)), (Class147.Enum0)2));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)101:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null)
				{
					this.class172_0.method_2(@class.vmethod_42());
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)102:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (Class147.Class156.smethod_1(this.class172_0.method_4()).vmethod_77(class3))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class147.Enum2)103:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				this.class172_0.method_4().vmethod_2(class3);
				return;
			}
			case (Class147.Enum2)104:
				this.bApfYhsCem(true);
				return;
			case (Class147.Enum2)105:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class147).Module.ResolveField(num);
				Class147.Class158 class12 = this.class172_0.method_4();
				class12.vmethod_8();
				object obj = class12.vmethod_4(null);
				this.class172_0.method_2(new Class147.Class167(fieldInfo, obj));
				return;
			}
			case (Class147.Enum2)106:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null)
				{
					this.class172_0.method_2(@class.vmethod_47());
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)108:
				this.class172_0.method_2(new Class147.Class165((int)this.object_0, this));
				return;
			case (Class147.Enum2)109:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_40());
				return;
			}
			case (Class147.Enum2)110:
				this.class172_0.method_2(new Class147.Class163((float)this.object_0));
				return;
			case (Class147.Enum2)111:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null && class2 != null)
				{
					this.class172_0.method_2(@class.vmethod_67(class2));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)112:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class147).Module.ResolveType(num);
				Class147.Class164 class13 = this.class172_0.method_4() as Class147.Class164;
				if (class13 != null)
				{
					object obj = class13.vmethod_4(type);
					Class147.Class158 class3;
					if (obj != null)
					{
						if (type.IsValueType)
						{
							obj = Class147.Class156.smethod_10(obj);
						}
						class3 = Class147.Class158.smethod_0(type, obj);
					}
					else if (!type.IsValueType)
					{
						class3 = new Class147.Class170(null);
					}
					else
					{
						obj = Activator.CreateInstance(type);
						class3 = Class147.Class158.smethod_0(type, obj);
					}
					this.class172_0.method_2(class3);
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)114:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (class3.vmethod_3())
				{
					class3 = ((Class147.Class159)class3).vmethod_46();
				}
				this.class172_0.method_4().vmethod_2(class3);
				return;
			}
			case (Class147.Enum2)116:
				this.class172_0.method_2(new Class147.Class161((long)this.object_0));
				return;
			case (Class147.Enum2)117:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				Class147.Class159 @class = Class147.Class156.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class172_0.method_2(@class.vmethod_45());
					return;
				}
				if (@class != null && @class.method_2())
				{
					IntPtr intPtr = ((Class147.Class162)@class).method_7();
					this.class172_0.method_2(new Class147.Class163(*(float*)((void*)intPtr), (Class147.Enum0)9));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)119:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				Class147.Class159 @class = Class147.Class156.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class172_0.method_2(@class.vmethod_27());
					return;
				}
				if (@class != null && @class.method_2())
				{
					IntPtr intPtr = ((Class147.Class162)@class).method_7();
					this.class172_0.method_2(new Class147.Class160((int)(*(ushort*)((void*)intPtr)), (Class147.Enum0)4));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)120:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null)
				{
					this.class172_0.method_2(@class.vmethod_48());
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)121:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				object obj = ((Array)this.class172_0.method_4().vmethod_4(null)).GetValue(@class.LtAcwclWeT().struct3_0.int_0);
				this.class172_0.method_2(Class147.Class158.smethod_0(typeof(double), obj));
				return;
			}
			case (Class147.Enum2)123:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (class3.vmethod_3())
				{
					class3 = ((Class147.Class159)class3).vmethod_22();
				}
				this.class172_0.method_4().vmethod_2(class3);
				return;
			}
			case (Class147.Enum2)124:
				this.bool_3 = (bool)this.class172_0.method_4().vmethod_4(typeof(bool));
				this.bool_1 = true;
				return;
			case (Class147.Enum2)125:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_53());
				return;
			}
			case (Class147.Enum2)126:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null)
				{
					this.class172_0.method_2(@class.vmethod_69());
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)127:
			{
				object obj = Class147.Class156.object_2;
				lock (obj)
				{
					object obj2 = this.class172_0.method_4().vmethod_4(null);
					Class147.Class158 class3 = null;
					if (!Class147.Class156.dictionary_1.TryGetValue(obj2, out class3))
					{
						this.class172_0.method_2(new Class147.Class170(null));
					}
					else
					{
						this.class172_0.method_2(class3);
					}
				}
				return;
			}
			case (Class147.Enum2)128:
				this.class172_0.method_2(new Class147.Class170(null));
				return;
			case (Class147.Enum2)129:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (class3 != null && class3.vmethod_7())
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class147.Enum2)130:
				this.class172_0.method_4();
				return;
			case (Class147.Enum2)131:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class172_0.method_2(class2.vmethod_55(@class));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)132:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				Class147.Class159 @class = Class147.Class156.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class172_0.method_2(@class.vmethod_22());
					return;
				}
				if (@class != null && @class.method_2())
				{
					IntPtr intPtr = ((Class147.Class162)@class).method_7();
					this.class172_0.method_2(new Class147.Class160((int)(*(sbyte*)((void*)intPtr)), (Class147.Enum0)1));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)133:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class147).Module.ResolveType(num);
				object obj = this.class172_0.method_4().vmethod_8().vmethod_4(type);
				Class147.Class158 class3 = Class147.Class158.smethod_0(type, obj);
				this.class172_0.method_2(class3);
				return;
			}
			case (Class147.Enum2)134:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class172_0.method_2(class2.vmethod_61(@class));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)135:
			{
				int num = (int)this.object_0;
				MethodBase methodBase = typeof(Class147).Module.ResolveMethod(num);
				Type type = this.class172_0.method_4().vmethod_4(null).GetType();
				List<Type> list2 = new List<Type>();
				do
				{
					list2.Add(type);
					type = type.BaseType;
				}
				while (type != null && type != methodBase.DeclaringType);
				list2.Reverse();
				MethodBase methodBase2 = methodBase;
				foreach (Type type2 in list2)
				{
					foreach (MethodInfo methodInfo in type2.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
					{
						if (methodInfo.GetBaseDefinition() == methodBase2)
						{
							methodBase2 = methodInfo;
							break;
						}
					}
				}
				this.class172_0.method_2(new Class147.Class162(methodBase2.MethodHandle.GetFunctionPointer()));
				return;
			}
			case (Class147.Enum2)136:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class147).Module.ResolveField(num);
				this.class172_0.method_2(new Class147.Class167(fieldInfo, null));
				return;
			}
			case (Class147.Enum2)137:
			{
				Class147.Class159 @class = this.class172_0.method_4() as Class147.Class159;
				Class147.Class159 class2 = this.class172_0.method_4() as Class147.Class159;
				IntPtr intPtr = Class147.Class156.smethod_9(this.class172_0.method_4());
				if (intPtr != IntPtr.Zero)
				{
					byte byte_ = class2.vmethod_16().struct3_0.byte_0;
					uint num2 = @class.vmethod_19().struct3_0.uint_0;
					Class147.Class156.smethod_11(intPtr, byte_, (int)num2);
				}
				return;
			}
			case (Class147.Enum2)138:
			{
				int num = (int)this.object_0;
				Class147.Class158 class3 = this.class158_1[num];
				this.class172_0.method_2(class3);
				return;
			}
			case (Class147.Enum2)139:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_24());
				return;
			}
			case (Class147.Enum2)140:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				object obj = ((Array)this.class172_0.method_4().vmethod_4(null)).GetValue(@class.LtAcwclWeT().struct3_0.int_0);
				this.class172_0.method_2(Class147.Class158.smethod_0(typeof(uint), obj));
				return;
			}
			case (Class147.Enum2)141:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_34());
				return;
			}
			case (Class147.Enum2)142:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null)
				{
					this.class172_0.method_2(@class.vmethod_38());
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)143:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class172_0.method_2(class2.Add(@class));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)144:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				object obj = ((Array)this.class172_0.method_4().vmethod_4(null)).GetValue(@class.LtAcwclWeT().struct3_0.int_0);
				this.class172_0.method_2(Class147.Class158.smethod_0(typeof(long), obj));
				return;
			}
			case (Class147.Enum2)145:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_29());
				return;
			}
			case (Class147.Enum2)146:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				object obj = ((Array)this.class172_0.method_4().vmethod_4(null)).GetValue(@class.LtAcwclWeT().struct3_0.int_0);
				this.class172_0.method_2(Class147.Class158.smethod_0(typeof(sbyte), obj));
				return;
			}
			case (Class147.Enum2)147:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				object obj = ((Array)this.class172_0.method_4().vmethod_4(null)).GetValue(@class.LtAcwclWeT().struct3_0.int_0);
				this.class172_0.method_2(Class147.Class158.smethod_0(typeof(ushort), obj));
				return;
			}
			case (Class147.Enum2)148:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class172_0.method_2(class2.vmethod_63(@class));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)149:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_43());
				return;
			}
			case (Class147.Enum2)150:
			{
				int[] array5 = (int[])this.object_0;
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				long num3 = @class.vmethod_20().struct4_0.long_0;
				if ((num3 < 0L || @class.method_4()) && IntPtr.Size == 4)
				{
					num3 = (long)((int)num3);
				}
				if (@class.method_1())
				{
					Class147.Class160 class14 = (Class147.Class160)@class;
					if (class14.enum0_0 == (Class147.Enum0)6)
					{
						num3 = (long)((ulong)class14.struct3_0.uint_0);
					}
				}
				if (num3 < (long)array5.Length && num3 >= 0L)
				{
					this.int_0 = array5[(int)(checked((IntPtr)num3))] - 1;
				}
				return;
			}
			case (Class147.Enum2)151:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				Class147.Class159 @class = Class147.Class156.smethod_1(class3);
				Class147.Class158 class158_ = this.class172_0.method_4();
				Class147.Class159 class2 = Class147.Class156.smethod_1(class158_);
				if (class2 != null && @class != null)
				{
					if (class2.vmethod_78(class3))
					{
						this.int_0 = (int)this.object_0 - 1;
					}
					return;
				}
				if (class3.vmethod_6(class158_))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class147.Enum2)152:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class147).Module.ResolveField(num);
				object obj = this.class172_0.method_4().vmethod_4(null);
				this.class172_0.method_2(Class147.Class158.smethod_0(fieldInfo.FieldType, fieldInfo.GetValue(obj)));
				return;
			}
			case (Class147.Enum2)153:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class172_0.method_2(class2.vmethod_64(@class));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)154:
			{
				Class147.Class158 class15 = Class147.Class156.smethod_7(this.class172_0.method_4());
				Class147.Class158 class3 = Class147.Class156.smethod_7(this.class172_0.method_4());
				if (!class15.vmethod_5(class3))
				{
					this.class172_0.method_2(new Class147.Class160(0));
					return;
				}
				this.class172_0.method_2(new Class147.Class160(1));
				return;
			}
			case (Class147.Enum2)155:
			{
				bool flag2 = false;
				Class147.Class158 class3 = this.class172_0.method_4();
				flag2 = (class3 == null || !class3.vmethod_7());
				if (flag2)
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class147.Enum2)156:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class != null)
				{
					this.class172_0.method_2(@class.vmethod_30());
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)157:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_41());
				return;
			}
			case (Class147.Enum2)158:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (@class == null)
				{
					throw new Class147.Exception1();
				}
				this.class172_0.method_2(@class.vmethod_45());
				return;
			}
			case (Class147.Enum2)159:
				if (this.class172_0.method_4().vmethod_6(this.class172_0.method_4()))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			case (Class147.Enum2)160:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Array array6 = (Array)this.class172_0.method_4().vmethod_4(null);
				object obj = array6.GetValue(@class.LtAcwclWeT().struct3_0.int_0);
				Type type = array6.GetType().GetElementType();
				this.class172_0.method_2(Class147.Class158.smethod_0(type, obj));
				return;
			}
			case (Class147.Enum2)161:
				this.class172_0.method_2(this.class172_0.method_4().vmethod_8());
				return;
			case (Class147.Enum2)162:
			{
				int num = (int)this.object_0;
				this.class172_0.method_2(new Class147.Class168(num, this));
				return;
			}
			case (Class147.Enum2)165:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				Class147.Class159 @class = Class147.Class156.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class172_0.method_2(@class.vmethod_48());
					return;
				}
				if (@class == null || !@class.method_2())
				{
					throw new Class147.Exception1();
				}
				IntPtr intPtr = ((Class147.Class162)@class).method_7();
				if (IntPtr.Size == 8)
				{
					long num3 = *(long*)((void*)intPtr);
					this.class172_0.method_2(new Class147.Class162(num3, (Class147.Enum0)12));
					return;
				}
				int num = *(int*)((void*)intPtr);
				this.class172_0.method_2(new Class147.Class162((long)num, (Class147.Enum0)12));
				return;
			}
			case (Class147.Enum2)166:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				Class147.Class159 @class = Class147.Class156.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class172_0.method_2(@class.vmethod_46());
					return;
				}
				if (@class != null && @class.method_2())
				{
					IntPtr intPtr = ((Class147.Class162)@class).method_7();
					this.class172_0.method_2(new Class147.Class163(*(double*)((void*)intPtr), (Class147.Enum0)10));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)168:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				if (class3.vmethod_3())
				{
					class3 = ((Class147.Class159)class3).vmethod_23();
				}
				this.class172_0.method_4().vmethod_2(class3);
				return;
			}
			case (Class147.Enum2)171:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				object obj = ((Array)this.class172_0.method_4().vmethod_4(null)).GetValue(@class.LtAcwclWeT().struct3_0.int_0);
				this.class172_0.method_2(Class147.Class158.smethod_0(typeof(float), obj));
				return;
			}
			case (Class147.Enum2)172:
				return;
			case (Class147.Enum2)173:
			{
				int num = (int)this.object_0;
				typeof(Class147).Module.ResolveType(num);
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Array array4 = (Array)this.class172_0.method_4().vmethod_4(null);
				this.class172_0.method_2(new Class147.Class166(@class.LtAcwclWeT().struct3_0.int_0, array4));
				return;
			}
			case (Class147.Enum2)174:
			{
				Class147.Class159 @class = Class147.Class156.smethod_1(this.class172_0.method_4());
				Class147.Class159 class2 = Class147.Class156.smethod_1(this.class172_0.method_4());
				if (class2 != null && @class != null)
				{
					this.class172_0.method_2(class2.vmethod_73(@class));
					return;
				}
				throw new Class147.Exception1();
			}
			case (Class147.Enum2)175:
			{
				Class147.Class158 class3 = this.class172_0.method_4();
				Class147.Class159 @class = Class147.Class156.smethod_1(class3);
				if (class3 != null && class3.vmethod_0() && @class != null)
				{
					this.class172_0.method_2(@class.vmethod_28());
					return;
				}
				if (@class == null || !@class.method_2())
				{
					throw new Class147.Exception1();
				}
				IntPtr intPtr = ((Class147.Class162)@class).method_7();
				this.class172_0.method_2(new Class147.Class160(*(uint*)((void*)intPtr), (Class147.Enum0)6));
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00031B14 File Offset: 0x0002FD14
		private Class147.Class158 method_8(Class147.Class158 class158_3, Class147.Enum0 enum0_0, bool bool_4 = false)
		{
			if (!bool_4 && class158_3.vmethod_0())
			{
				class158_3 = class158_3.vmethod_8();
			}
			if (class158_3.method_1())
			{
				return ((Class147.Class160)class158_3).vmethod_13(enum0_0);
			}
			if (class158_3.method_3())
			{
				return ((Class147.Class161)class158_3).vmethod_13(enum0_0);
			}
			if (class158_3.method_4())
			{
				return ((Class147.Class163)class158_3).vmethod_13(enum0_0);
			}
			if (!class158_3.method_2())
			{
				return class158_3;
			}
			return ((Class147.Class162)class158_3).vmethod_13(enum0_0);
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x000044A7 File Offset: 0x000026A7
		private Class147.Class158 method_9(int int_3)
		{
			return this.class158_1[int_3];
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00031B8C File Offset: 0x0002FD8C
		private void method_10(int int_3)
		{
			this.method_11(int_3, this.class172_0.method_4());
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00031BAC File Offset: 0x0002FDAC
		private static int smethod_0(Type type_0)
		{
			object obj = Class147.Class156.object_1;
			int result;
			lock (obj)
			{
				if (Class147.Class156.dictionary_0 == null)
				{
					Class147.Class156.dictionary_0 = new Dictionary<Type, int>();
				}
				try
				{
					int num = 0;
					if (Class147.Class156.dictionary_0.TryGetValue(type_0, out num))
					{
						result = num;
					}
					else
					{
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(int), Type.EmptyTypes, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.Emit(OpCodes.Sizeof, type_0);
						ilgenerator.Emit(OpCodes.Ret);
						num = (int)dynamicMethod.Invoke(null, null);
						Class147.Class156.dictionary_0[type_0] = num;
						result = num;
					}
				}
				catch
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00031C80 File Offset: 0x0002FE80
		private void method_11(int int_3, Class147.Class158 class158_3)
		{
			this.class158_1[int_3] = this.method_8(class158_3, this.class153_0.list_1[int_3].enum0_0, this.class153_0.list_1[int_3].bool_0);
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00031CC8 File Offset: 0x0002FEC8
		private static Class147.Class159 smethod_1(Class147.Class158 class158_3)
		{
			Class147.Class159 @class = class158_3 as Class147.Class159;
			if (@class == null && class158_3.vmethod_0())
			{
				@class = (class158_3.vmethod_8() as Class147.Class159);
			}
			return @class;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00031CF8 File Offset: 0x0002FEF8
		private void bApfYhsCem(bool bool_4)
		{
			int metadataToken = (int)this.object_0;
			MethodBase methodBase = typeof(Class147).Module.ResolveMethod(metadataToken);
			MethodInfo methodInfo = methodBase as MethodInfo;
			ParameterInfo[] parameters = methodBase.GetParameters();
			object[] array = new object[parameters.Length];
			Class147.Class158[] array2 = new Class147.Class158[parameters.Length];
			List<Class147.Class154> list = null;
			Class147.Class155 @class = null;
			for (int i = 0; i < parameters.Length; i++)
			{
				Class147.Class158 class2 = this.class172_0.method_4();
				Type type = parameters[parameters.Length - 1 - i].ParameterType;
				object obj = null;
				bool flag = false;
				if (type.IsByRef)
				{
					Class147.Class167 class3 = class2 as Class147.Class167;
					if (class3 != null)
					{
						if (list == null)
						{
							list = new List<Class147.Class154>();
						}
						list.Add(new Class147.Class154(class3.fieldInfo_0, parameters.Length - 1 - i));
						obj = class3.object_0;
						if (!(obj is Class147.Class158))
						{
							flag = true;
							if (obj == null)
							{
								if (type.IsByRef)
								{
									type = type.GetElementType();
								}
								if (type.IsValueType)
								{
									if (class3.fieldInfo_0.IsStatic)
									{
										obj = class3.fieldInfo_0.GetValue(null);
									}
									else
									{
										obj = Activator.CreateInstance(type);
									}
									if (class2 is Class147.Class165)
									{
										((Class147.Class164)class2).vmethod_12(Class147.Class158.smethod_0(type, obj));
									}
								}
							}
						}
						else
						{
							class2 = (obj as Class147.Class158);
						}
					}
				}
				if (!flag)
				{
					if (class2 != null)
					{
						obj = class2.vmethod_4(type);
					}
					if (obj == null)
					{
						if (type.IsByRef)
						{
							type = type.GetElementType();
						}
						if (type.IsValueType)
						{
							obj = Activator.CreateInstance(type);
							if (class2 is Class147.Class165)
							{
								((Class147.Class164)class2).vmethod_12(Class147.Class158.smethod_0(type, obj));
							}
						}
					}
				}
				array2[array.Length - 1 - i] = class2;
				array[array.Length - 1 - i] = obj;
			}
			Class147.Delegate40 @delegate = null;
			Class147.Class156.Delegate45 delegate2 = null;
			if (list == null)
			{
				if (methodInfo != null && methodInfo.ReturnType.IsByRef)
				{
					@delegate = Class147.Class156.smethod_2(methodBase, bool_4);
				}
				else if (bool_4 && methodInfo != null && methodBase.IsVirtual)
				{
					delegate2 = Class147.Class156.smethod_6(methodBase, bool_4);
				}
			}
			else
			{
				@class = new Class147.Class155(methodBase, list);
				@delegate = Class147.Class156.smethod_3(methodBase, bool_4, @class);
			}
			object obj2 = null;
			Class147.Class158 class4 = null;
			if (!methodBase.IsStatic)
			{
				class4 = this.class172_0.method_4();
				if (class4 != null)
				{
					obj2 = class4.vmethod_4(methodBase.DeclaringType);
				}
				if (obj2 == null)
				{
					Type type2 = methodBase.DeclaringType;
					if (type2.IsByRef)
					{
						type2 = type2.GetElementType();
					}
					if (!type2.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj2 = Activator.CreateInstance(type2);
					if (obj2 == null && Nullable.GetUnderlyingType(type2) != null)
					{
						obj2 = FormatterServices.GetUninitializedObject(type2);
					}
					if (class4 is Class147.Class165)
					{
						((Class147.Class164)class4).vmethod_12(Class147.Class158.smethod_0(type2, obj2));
					}
				}
			}
			object obj3;
			if (methodBase is ConstructorInfo && Nullable.GetUnderlyingType(methodBase.DeclaringType) != null)
			{
				obj3 = array[0];
				if (class4 != null && class4 is Class147.Class165)
				{
					((Class147.Class164)class4).vmethod_12(Class147.Class158.smethod_0(Nullable.GetUnderlyingType(methodBase.DeclaringType), obj3));
				}
			}
			else if (@delegate == null)
			{
				if (delegate2 == null)
				{
					obj3 = methodBase.Invoke(obj2, array);
				}
				else
				{
					obj3 = delegate2(ref obj2, array);
					if (!methodBase.DeclaringType.IsClass && !methodBase.DeclaringType.IsInterface && class4 != null && class4 is Class147.Class164)
					{
						Type type3 = Nullable.GetUnderlyingType(methodBase.DeclaringType);
						if (type3 == null)
						{
							type3 = methodBase.DeclaringType;
						}
						((Class147.Class164)class4).vmethod_12(Class147.Class158.smethod_0(type3, obj2));
					}
				}
			}
			else
			{
				obj3 = @delegate(obj2, array);
			}
			for (int j = 0; j < parameters.Length; j++)
			{
				if (parameters[j].ParameterType.IsByRef && (@class == null || !@class.method_1(j)))
				{
					if (array2[j].method_2())
					{
						((Class147.Class162)array2[j]).method_6(Class147.Class158.smethod_0(parameters[j].ParameterType, array[j]));
					}
					else if (array2[j] is Class147.Class165)
					{
						array2[j].vmethod_10(Class147.Class158.smethod_0(parameters[j].ParameterType.GetElementType(), array[j]));
					}
					else
					{
						array2[j].vmethod_10(Class147.Class158.smethod_0(parameters[j].ParameterType, array[j]));
					}
				}
			}
			if (methodInfo != null && methodInfo.ReturnType != typeof(void))
			{
				this.class172_0.method_2(Class147.Class158.smethod_0(methodInfo.ReturnType, obj3));
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x000321CC File Offset: 0x000303CC
		private static Class147.Delegate40 smethod_2(MethodBase methodBase_0, bool bool_4)
		{
			object obj = Class147.Class156.object_3;
			Class147.Delegate40 result2;
			lock (obj)
			{
				Class147.Delegate40 result = null;
				if (bool_4)
				{
					if (Class147.Class156.dictionary_2.TryGetValue(methodBase_0, out result))
					{
						return result;
					}
				}
				else if (Class147.Class156.dictionary_3.TryGetValue(methodBase_0, out result))
				{
					return result;
				}
				MethodInfo methodInfo = methodBase_0 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (!parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType;
					}
					else
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
				}
				int num = array.Length;
				if (methodBase_0.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					array2[j] = ilgenerator.DeclareLocal(array[j]);
				}
				if (methodBase_0.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(methodBase_0.DeclaringType);
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class147.Class156.smethod_5(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (array[k].IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
					}
					else if (array[k] != typeof(object))
					{
						ilgenerator.Emit(OpCodes.Castclass, array[k]);
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!methodBase_0.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (!methodBase_0.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Castclass, methodBase_0.DeclaringType);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, methodBase_0.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[array2.Length - 1]);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (!parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
					}
				}
				if (!bool_4)
				{
					if (!(methodInfo != null))
					{
						ilgenerator.Emit(OpCodes.Callvirt, methodBase_0 as ConstructorInfo);
					}
					else
					{
						ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
					}
				}
				else if (methodInfo != null)
				{
					ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
				}
				else
				{
					ilgenerator.Emit(OpCodes.Call, methodBase_0 as ConstructorInfo);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (methodInfo.ReturnType.IsByRef)
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
					else if (methodInfo.ReturnType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class147.Class156.smethod_5(ilgenerator, m);
						ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
						if (array2[m].LocalType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
						}
						ilgenerator.Emit(OpCodes.Stelem_Ref);
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class147.Delegate40 @delegate = (Class147.Delegate40)dynamicMethod.CreateDelegate(typeof(Class147.Delegate40));
				if (bool_4)
				{
					Class147.Class156.dictionary_2.Add(methodBase_0, @delegate);
				}
				else
				{
					Class147.Class156.dictionary_3.Add(methodBase_0, @delegate);
				}
				result2 = @delegate;
			}
			return result2;
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00032678 File Offset: 0x00030878
		private static Class147.Delegate40 smethod_3(MethodBase methodBase_0, bool bool_4, Class147.Class155 class155_0)
		{
			object obj = Class147.Class156.object_4;
			Class147.Delegate40 result2;
			lock (obj)
			{
				Class147.Delegate40 result = null;
				if (bool_4)
				{
					if (Class147.Class156.dictionary_4.TryGetValue(class155_0, out result))
					{
						return result;
					}
				}
				else if (Class147.Class156.dictionary_5.TryGetValue(class155_0, out result))
				{
					return result;
				}
				MethodInfo methodInfo = methodBase_0 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, typeof(Class147), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
					else
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				int num = array.Length;
				if (methodBase_0.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					if (!class155_0.method_1(j))
					{
						array2[j] = ilgenerator.DeclareLocal(array[j]);
					}
					else
					{
						array2[j] = ilgenerator.DeclareLocal(typeof(object));
					}
				}
				if (methodBase_0.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(methodBase_0.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class147.Class156.smethod_5(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (!class155_0.method_1(k))
					{
						if (!array[k].IsValueType)
						{
							if (array[k] != typeof(object))
							{
								ilgenerator.Emit(OpCodes.Castclass, array[k]);
							}
						}
						else
						{
							ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
						}
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!methodBase_0.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (methodBase_0.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox, methodBase_0.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Castclass, methodBase_0.DeclaringType);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (class155_0.method_1(l))
					{
						Class147.Class154 @class = class155_0.method_0(l);
						if (@class.fieldInfo_0.IsStatic)
						{
							ilgenerator.Emit(OpCodes.Ldsflda, @class.fieldInfo_0);
						}
						else if (@class.fieldInfo_0.DeclaringType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
							ilgenerator.Emit(OpCodes.Unbox, @class.fieldInfo_0.DeclaringType);
							ilgenerator.Emit(OpCodes.Ldflda, @class.fieldInfo_0);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
							ilgenerator.Emit(OpCodes.Castclass, @class.fieldInfo_0.DeclaringType);
							ilgenerator.Emit(OpCodes.Ldflda, @class.fieldInfo_0);
						}
					}
					else if (parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
					}
				}
				if (!bool_4)
				{
					if (methodInfo != null)
					{
						ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Callvirt, methodBase_0 as ConstructorInfo);
					}
				}
				else if (methodInfo != null)
				{
					ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
				}
				else
				{
					ilgenerator.Emit(OpCodes.Call, methodBase_0 as ConstructorInfo);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (!methodInfo.ReturnType.IsByRef)
					{
						if (methodInfo.ReturnType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
						}
					}
					else
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						if (!class155_0.method_1(m))
						{
							ilgenerator.Emit(OpCodes.Ldarg_1);
							Class147.Class156.smethod_5(ilgenerator, m);
							ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
							if (array2[m].LocalType.IsValueType)
							{
								ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
							}
							ilgenerator.Emit(OpCodes.Stelem_Ref);
						}
						else
						{
							Class147.Class154 class2 = class155_0.method_0(m);
							if (class2.fieldInfo_0.IsStatic)
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class147.Class156.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldsfld, class2.fieldInfo_0);
								if (class2.fieldInfo_0.FieldType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, class2.fieldInfo_0.FieldType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class147.Class156.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, class2.fieldInfo_0.FieldType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
						}
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class147.Delegate40 @delegate = (Class147.Delegate40)dynamicMethod.CreateDelegate(typeof(Class147.Delegate40));
				if (!bool_4)
				{
					Class147.Class156.dictionary_5.Add(class155_0, @delegate);
				}
				else
				{
					Class147.Class156.dictionary_4.Add(class155_0, @delegate);
				}
				result2 = @delegate;
			}
			return result2;
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00032D20 File Offset: 0x00030F20
		private static Class147.Delegate40 smethod_4(MethodBase methodBase_0, bool bool_4, Class147.Class155 class155_0)
		{
			object obj = Class147.Class156.object_5;
			Class147.Delegate40 result;
			lock (obj)
			{
				Class147.Delegate40 @delegate = null;
				if (!Class147.Class156.dictionary_6.TryGetValue(class155_0, out @delegate))
				{
					ConstructorInfo constructorInfo = methodBase_0 as ConstructorInfo;
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
					{
						typeof(object),
						typeof(object[])
					}, typeof(Class147), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ParameterInfo[] parameters = methodBase_0.GetParameters();
					Type[] array = new Type[parameters.Length];
					for (int i = 0; i < array.Length; i++)
					{
						if (!parameters[i].ParameterType.IsByRef)
						{
							array[i] = parameters[i].ParameterType;
						}
						else
						{
							array[i] = parameters[i].ParameterType.GetElementType();
						}
					}
					int num = array.Length;
					if (methodBase_0.DeclaringType.IsValueType)
					{
						num++;
					}
					LocalBuilder[] array2 = new LocalBuilder[num];
					for (int j = 0; j < array.Length; j++)
					{
						if (!class155_0.method_1(j))
						{
							array2[j] = ilgenerator.DeclareLocal(array[j]);
						}
						else
						{
							array2[j] = ilgenerator.DeclareLocal(typeof(object));
						}
					}
					if (methodBase_0.DeclaringType.IsValueType)
					{
						array2[array2.Length - 1] = ilgenerator.DeclareLocal(methodBase_0.DeclaringType.MakeByRefType());
					}
					for (int k = 0; k < array.Length; k++)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class147.Class156.smethod_5(ilgenerator, k);
						ilgenerator.Emit(OpCodes.Ldelem_Ref);
						if (!class155_0.method_1(k))
						{
							if (array[k].IsValueType)
							{
								ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
							}
							else if (array[k] != typeof(object))
							{
								ilgenerator.Emit(OpCodes.Castclass, array[k]);
							}
						}
						ilgenerator.Emit(OpCodes.Stloc, array2[k]);
					}
					for (int l = 0; l < array.Length; l++)
					{
						if (class155_0.method_1(l))
						{
							Class147.Class154 @class = class155_0.method_0(l);
							if (@class.fieldInfo_0.IsStatic)
							{
								ilgenerator.Emit(OpCodes.Ldsflda, @class.fieldInfo_0);
							}
							else if (!@class.fieldInfo_0.DeclaringType.IsValueType)
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
								ilgenerator.Emit(OpCodes.Castclass, @class.fieldInfo_0.DeclaringType);
								ilgenerator.Emit(OpCodes.Ldflda, @class.fieldInfo_0);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
								ilgenerator.Emit(OpCodes.Unbox, @class.fieldInfo_0.DeclaringType);
								ilgenerator.Emit(OpCodes.Ldflda, @class.fieldInfo_0);
							}
						}
						else if (!parameters[l].ParameterType.IsByRef)
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
						}
					}
					ilgenerator.Emit(OpCodes.Newobj, methodBase_0 as ConstructorInfo);
					if (constructorInfo.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, constructorInfo.DeclaringType);
					}
					for (int m = 0; m < array.Length; m++)
					{
						if (parameters[m].ParameterType.IsByRef)
						{
							if (!class155_0.method_1(m))
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class147.Class156.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
							else
							{
								Class147.Class154 class2 = class155_0.method_0(m);
								if (!class2.fieldInfo_0.IsStatic)
								{
									ilgenerator.Emit(OpCodes.Ldarg_1);
									Class147.Class156.smethod_5(ilgenerator, m);
									ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
									if (array2[m].LocalType.IsValueType)
									{
										ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
									}
									ilgenerator.Emit(OpCodes.Stelem_Ref);
								}
								else
								{
									ilgenerator.Emit(OpCodes.Ldarg_1);
									Class147.Class156.smethod_5(ilgenerator, m);
									ilgenerator.Emit(OpCodes.Ldsfld, class2.fieldInfo_0);
									if (class2.fieldInfo_0.FieldType.IsValueType)
									{
										ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
									}
									ilgenerator.Emit(OpCodes.Stelem_Ref);
								}
							}
						}
					}
					ilgenerator.Emit(OpCodes.Ret);
					Class147.Delegate40 delegate2 = (Class147.Delegate40)dynamicMethod.CreateDelegate(typeof(Class147.Delegate40));
					Class147.Class156.dictionary_6.Add(class155_0, delegate2);
					result = delegate2;
				}
				else
				{
					result = @delegate;
				}
			}
			return result;
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00033248 File Offset: 0x00031448
		private static void smethod_5(ILGenerator ilgenerator_0, int int_3)
		{
			switch (int_3)
			{
			case -1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
				return;
			case 0:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
				return;
			case 1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
				return;
			case 2:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_2);
				return;
			case 3:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_3);
				return;
			case 4:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_4);
				return;
			case 5:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
				return;
			case 6:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_6);
				return;
			case 7:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_7);
				return;
			case 8:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_8);
				return;
			default:
				if (int_3 > -129 && int_3 < 128)
				{
					ilgenerator_0.Emit(OpCodes.Ldc_I4_S, (sbyte)int_3);
					return;
				}
				ilgenerator_0.Emit(OpCodes.Ldc_I4, int_3);
				return;
			}
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00033328 File Offset: 0x00031528
		private static Class147.Class156.Delegate45 smethod_6(MethodBase methodBase_0, bool bool_4)
		{
			object obj = Class147.Class156.object_6;
			Class147.Class156.Delegate45 result2;
			lock (obj)
			{
				Class147.Class156.Delegate45 result = null;
				if (bool_4)
				{
					if (Class147.Class156.dictionary_7.TryGetValue(methodBase_0, out result))
					{
						return result;
					}
				}
				else if (Class147.Class156.dictionary_8.TryGetValue(methodBase_0, out result))
				{
					return result;
				}
				MethodInfo methodInfo = methodBase_0 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object).MakeByRefType(),
					typeof(object[])
				}, true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (!parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType;
					}
					else
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
				}
				LocalBuilder[] array2 = new LocalBuilder[array.Length + 1];
				for (int j = 0; j < array.Length; j++)
				{
					array2[j] = ilgenerator.DeclareLocal(array[j]);
				}
				array2[array2.Length - 1] = ilgenerator.DeclareLocal(methodBase_0.DeclaringType);
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class147.Class156.smethod_5(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (array[k].IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
					}
					else if (array[k] != typeof(object))
					{
						ilgenerator.Emit(OpCodes.Castclass, array[k]);
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!methodBase_0.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					ilgenerator.Emit(OpCodes.Ldind_Ref);
					if (!methodBase_0.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Castclass, methodBase_0.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, methodBase_0.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[array2.Length - 1]);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (!parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
					}
				}
				if (bool_4)
				{
					if (methodInfo != null)
					{
						ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Call, methodBase_0 as ConstructorInfo);
					}
				}
				else if (methodInfo != null)
				{
					ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
				}
				else
				{
					ilgenerator.Emit(OpCodes.Callvirt, methodBase_0 as ConstructorInfo);
				}
				if (!methodBase_0.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					ilgenerator.Emit(OpCodes.Ldloc, array2[array2.Length - 1]);
					if (methodBase_0.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, methodBase_0.DeclaringType);
					}
					ilgenerator.Emit(OpCodes.Stind_Ref);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (!methodInfo.ReturnType.IsByRef)
					{
						if (methodInfo.ReturnType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
						}
					}
					else
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (!elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class147.Class156.smethod_5(ilgenerator, m);
						ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
						if (array2[m].LocalType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
						}
						ilgenerator.Emit(OpCodes.Stelem_Ref);
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class147.Class156.Delegate45 @delegate = (Class147.Class156.Delegate45)dynamicMethod.CreateDelegate(typeof(Class147.Class156.Delegate45));
				if (bool_4)
				{
					Class147.Class156.dictionary_7.Add(methodBase_0, @delegate);
				}
				else
				{
					Class147.Class156.dictionary_8.Add(methodBase_0, @delegate);
				}
				result2 = @delegate;
			}
			return result2;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00033844 File Offset: 0x00031A44
		private static Class147.Class158 smethod_7(Class147.Class158 class158_3)
		{
			if (class158_3.vmethod_8().method_0())
			{
				object obj = class158_3.vmethod_4(null);
				if (obj != null && obj.GetType().IsEnum)
				{
					Type underlyingType = Enum.GetUnderlyingType(obj.GetType());
					object obj2 = Convert.ChangeType(obj, underlyingType);
					Class147.Class158 @class = Class147.Class156.smethod_8(Class147.Class158.smethod_0(underlyingType, obj2));
					if (@class != null)
					{
						return @class as Class147.Class159;
					}
				}
			}
			return class158_3;
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00031CC8 File Offset: 0x0002FEC8
		private static Class147.Class159 smethod_8(Class147.Class158 class158_3)
		{
			Class147.Class159 @class = class158_3 as Class147.Class159;
			if (@class == null && class158_3.vmethod_0())
			{
				@class = (class158_3.vmethod_8() as Class147.Class159);
			}
			return @class;
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x000338B0 File Offset: 0x00031AB0
		private static IntPtr smethod_9(Class147.Class158 class158_3)
		{
			if (class158_3 == null)
			{
				return IntPtr.Zero;
			}
			if (class158_3.method_2())
			{
				return ((Class147.Class162)class158_3).method_7();
			}
			if (class158_3.vmethod_0())
			{
				Class147.Class164 @class = (Class147.Class164)class158_3;
				IntPtr result;
				try
				{
					result = @class.vmethod_11();
				}
				catch
				{
					goto IL_3E;
				}
				return result;
			}
			IL_3E:
			object obj = class158_3.vmethod_4(typeof(IntPtr));
			if (obj == null || !(obj.GetType() == typeof(IntPtr)))
			{
				throw new Class147.Exception1();
			}
			return (IntPtr)obj;
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00033948 File Offset: 0x00031B48
		private static object smethod_10(object object_8)
		{
			object obj = Class147.Class156.object_7;
			object result;
			lock (obj)
			{
				if (Class147.Class156.dictionary_9 == null)
				{
					Class147.Class156.dictionary_9 = new Dictionary<Type, Class147.Delegate42>();
				}
				if (object_8 != null)
				{
					try
					{
						Type type = object_8.GetType();
						Class147.Delegate42 @delegate;
						if (!Class147.Class156.dictionary_9.TryGetValue(type, out @delegate))
						{
							DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
							{
								typeof(object)
							}, true);
							ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
							ilgenerator.Emit(OpCodes.Ldarg_0);
							ilgenerator.Emit(OpCodes.Unbox_Any, type);
							ilgenerator.Emit(OpCodes.Box, type);
							ilgenerator.Emit(OpCodes.Ret);
							Class147.Delegate42 delegate2 = (Class147.Delegate42)dynamicMethod.CreateDelegate(typeof(Class147.Delegate42));
							Class147.Class156.dictionary_9.Add(type, delegate2);
							return delegate2(object_8);
						}
						return @delegate(object_8);
					}
					catch
					{
						return null;
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00033A6C File Offset: 0x00031C6C
		private static void smethod_11(IntPtr intptr_0, byte byte_0, int int_3)
		{
			object obj = Class147.Class156.object_7;
			lock (obj)
			{
				if (Class147.Class156.delegate43_0 == null)
				{
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
					{
						typeof(IntPtr),
						typeof(byte),
						typeof(int)
					}, typeof(Class147), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ilgenerator.Emit(OpCodes.Ldarg_0);
					ilgenerator.Emit(OpCodes.Ldarg_1);
					ilgenerator.Emit(OpCodes.Ldarg_2);
					ilgenerator.Emit(OpCodes.Initblk);
					ilgenerator.Emit(OpCodes.Ret);
					Class147.Class156.delegate43_0 = (Class147.Delegate43)dynamicMethod.CreateDelegate(typeof(Class147.Delegate43));
				}
				Class147.Class156.delegate43_0(intptr_0, byte_0, int_3);
			}
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00033B64 File Offset: 0x00031D64
		private static void smethod_12(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
		{
			if (Class147.Class156.delegate44_0 == null)
			{
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
				{
					typeof(IntPtr),
					typeof(IntPtr),
					typeof(uint)
				}, typeof(Class147), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ilgenerator.Emit(OpCodes.Ldarg_0);
				ilgenerator.Emit(OpCodes.Ldarg_1);
				ilgenerator.Emit(OpCodes.Ldarg_2);
				ilgenerator.Emit(OpCodes.Cpblk);
				ilgenerator.Emit(OpCodes.Ret);
				Class147.Class156.delegate44_0 = (Class147.Delegate44)dynamicMethod.CreateDelegate(typeof(Class147.Delegate44));
			}
			Class147.Class156.delegate44_0(intptr_0, intptr_1, uint_0);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x000044B1 File Offset: 0x000026B1
		internal static bool V08bRaZU7qJUwtSdKDAB()
		{
			return Class147.Class156.bUaqTaZUj7ZgbgKLTZGy == null;
		}

		// Token: 0x04000525 RID: 1317
		internal Class147.Class153 class153_0;

		// Token: 0x04000526 RID: 1318
		internal Class147.Class158[] class158_0 = new Class147.Class158[0];

		// Token: 0x04000527 RID: 1319
		internal Class147.Class158[] class158_1 = new Class147.Class158[0];

		// Token: 0x04000528 RID: 1320
		internal Class147.Class172 class172_0 = new Class147.Class172();

		// Token: 0x04000529 RID: 1321
		internal Class147.Class158 class158_2;

		// Token: 0x0400052A RID: 1322
		internal Exception exception_0;

		// Token: 0x0400052B RID: 1323
		internal List<IntPtr> list_0;

		// Token: 0x0400052C RID: 1324
		private int int_0;

		// Token: 0x0400052D RID: 1325
		private int int_1;

		// Token: 0x0400052E RID: 1326
		private int int_2 = -1;

		// Token: 0x0400052F RID: 1327
		private object object_0;

		// Token: 0x04000530 RID: 1328
		private bool bool_0;

		// Token: 0x04000531 RID: 1329
		private bool bool_1;

		// Token: 0x04000532 RID: 1330
		private bool bool_2;

		// Token: 0x04000533 RID: 1331
		private bool bool_3;

		// Token: 0x04000534 RID: 1332
		private static Dictionary<Type, int> dictionary_0;

		// Token: 0x04000535 RID: 1333
		private static object object_1 = new object();

		// Token: 0x04000536 RID: 1334
		private static Dictionary<object, Class147.Class158> dictionary_1 = new Dictionary<object, Class147.Class158>();

		// Token: 0x04000537 RID: 1335
		private static object object_2 = new object();

		// Token: 0x04000538 RID: 1336
		private static Dictionary<MethodBase, Class147.Delegate40> dictionary_2 = new Dictionary<MethodBase, Class147.Delegate40>();

		// Token: 0x04000539 RID: 1337
		private static Dictionary<MethodBase, Class147.Delegate40> dictionary_3 = new Dictionary<MethodBase, Class147.Delegate40>();

		// Token: 0x0400053A RID: 1338
		private static object object_3 = new object();

		// Token: 0x0400053B RID: 1339
		private static Dictionary<Class147.Class155, Class147.Delegate40> dictionary_4 = new Dictionary<Class147.Class155, Class147.Delegate40>();

		// Token: 0x0400053C RID: 1340
		private static Dictionary<Class147.Class155, Class147.Delegate40> dictionary_5 = new Dictionary<Class147.Class155, Class147.Delegate40>();

		// Token: 0x0400053D RID: 1341
		private static object object_4 = new object();

		// Token: 0x0400053E RID: 1342
		private static Dictionary<Class147.Class155, Class147.Delegate40> dictionary_6 = new Dictionary<Class147.Class155, Class147.Delegate40>();

		// Token: 0x0400053F RID: 1343
		private static object object_5 = new object();

		// Token: 0x04000540 RID: 1344
		private static object object_6 = new object();

		// Token: 0x04000541 RID: 1345
		private static Dictionary<MethodBase, Class147.Class156.Delegate45> dictionary_7 = new Dictionary<MethodBase, Class147.Class156.Delegate45>();

		// Token: 0x04000542 RID: 1346
		private static Dictionary<MethodBase, Class147.Class156.Delegate45> dictionary_8 = new Dictionary<MethodBase, Class147.Class156.Delegate45>();

		// Token: 0x04000543 RID: 1347
		private static Dictionary<Type, Class147.Delegate42> dictionary_9;

		// Token: 0x04000544 RID: 1348
		private static object object_7 = new object();

		// Token: 0x04000545 RID: 1349
		private static Class147.Delegate43 delegate43_0;

		// Token: 0x04000546 RID: 1350
		private static Class147.Delegate44 delegate44_0;

		// Token: 0x04000547 RID: 1351
		internal static Class147.Class156 bUaqTaZUj7ZgbgKLTZGy;

		// Token: 0x02000196 RID: 406
		// (Invoke) Token: 0x06000A2B RID: 2603
		private delegate object Delegate45(ref object target, object[] paramters);

		// Token: 0x02000197 RID: 407
		[CompilerGenerated]
		[Serializable]
		private sealed class Class157
		{
			// Token: 0x06000A30 RID: 2608 RVA: 0x000044BB File Offset: 0x000026BB
			internal int method_0(Class147.Class151 x, Class147.Class151 y)
			{
				return x.class152_0.int_0.CompareTo(y.class152_0.int_0);
			}

			// Token: 0x06000A31 RID: 2609 RVA: 0x000044D8 File Offset: 0x000026D8
			internal static bool yAjATwZUwDvIUUiF2eQR()
			{
				return Class147.Class156.Class157.fe3bLfZU67kptsXYL8R6 == null;
			}

			// Token: 0x04000548 RID: 1352
			public static readonly Class147.Class156.Class157 <>9 = new Class147.Class156.Class157();

			// Token: 0x04000549 RID: 1353
			public static Comparison<Class147.Class151> <>9__12_0;

			// Token: 0x0400054A RID: 1354
			internal static Class147.Class156.Class157 fe3bLfZU67kptsXYL8R6;
		}
	}

	// Token: 0x02000198 RID: 408
	internal enum Enum2 : byte
	{

	}

	// Token: 0x02000199 RID: 409
	internal enum Enum3 : byte
	{

	}

	// Token: 0x0200019A RID: 410
	internal abstract class Class158
	{
		// Token: 0x06000A32 RID: 2610 RVA: 0x000047B4 File Offset: 0x000029B4
		public Class158()
		{
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x000044E2 File Offset: 0x000026E2
		internal bool method_0()
		{
			return this.enum3_0 == (Class147.Enum3)0;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x000044ED File Offset: 0x000026ED
		internal bool method_1()
		{
			return this.enum3_0 == (Class147.Enum3)1;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00033D28 File Offset: 0x00031F28
		internal bool method_2()
		{
			return this.enum3_0 == (Class147.Enum3)3 || this.enum3_0 == (Class147.Enum3)4;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x000044F8 File Offset: 0x000026F8
		internal bool method_3()
		{
			return this.enum3_0 == (Class147.Enum3)2;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00004503 File Offset: 0x00002703
		internal bool method_4()
		{
			return this.enum3_0 == (Class147.Enum3)5;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0000450E File Offset: 0x0000270E
		internal bool method_5()
		{
			return this.enum3_0 == (Class147.Enum3)6;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00002DE4 File Offset: 0x00000FE4
		internal virtual bool vmethod_0()
		{
			return false;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00002DE4 File Offset: 0x00000FE4
		internal virtual bool vmethod_1()
		{
			return false;
		}

		// Token: 0x06000A3B RID: 2619
		internal abstract void vmethod_2(Class147.Class158 class158_0);

		// Token: 0x06000A3C RID: 2620 RVA: 0x00002DE4 File Offset: 0x00000FE4
		internal virtual bool vmethod_3()
		{
			return false;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00033D4C File Offset: 0x00031F4C
		internal Class158(Class147.Enum3 enum3_1)
		{
			this.enum3_0 = enum3_1;
		}

		// Token: 0x06000A3E RID: 2622
		internal abstract object vmethod_4(Type type_0);

		// Token: 0x06000A3F RID: 2623
		internal abstract bool vmethod_5(Class147.Class158 class158_0);

		// Token: 0x06000A40 RID: 2624
		internal abstract bool vmethod_6(Class147.Class158 class158_0);

		// Token: 0x06000A41 RID: 2625
		internal abstract bool vmethod_7();

		// Token: 0x06000A42 RID: 2626
		internal abstract Class147.Class158 vmethod_8();

		// Token: 0x06000A43 RID: 2627 RVA: 0x00002DE4 File Offset: 0x00000FE4
		internal virtual bool vmethod_9()
		{
			return false;
		}

		// Token: 0x06000A44 RID: 2628
		internal abstract void vmethod_10(Class147.Class158 class158_0);

		// Token: 0x06000A45 RID: 2629 RVA: 0x00033D68 File Offset: 0x00031F68
		internal static Class147.Enum1 wceRauqQjd(Type type_0)
		{
			Type type = type_0;
			if (!(type != null))
			{
				return (Class147.Enum1)18;
			}
			if (type.IsByRef)
			{
				type = type.GetElementType();
			}
			if (type != null && Nullable.GetUnderlyingType(type) != null)
			{
				type = Nullable.GetUnderlyingType(type);
			}
			if (type == typeof(string))
			{
				return (Class147.Enum1)14;
			}
			if (type == typeof(byte))
			{
				return (Class147.Enum1)2;
			}
			if (type == typeof(sbyte))
			{
				return (Class147.Enum1)1;
			}
			if (type == typeof(short))
			{
				return (Class147.Enum1)3;
			}
			if (type == typeof(ushort))
			{
				return (Class147.Enum1)4;
			}
			if (type == typeof(int))
			{
				return (Class147.Enum1)5;
			}
			if (type == typeof(uint))
			{
				return (Class147.Enum1)6;
			}
			if (type == typeof(long))
			{
				return (Class147.Enum1)7;
			}
			if (type == typeof(ulong))
			{
				return (Class147.Enum1)8;
			}
			if (type == typeof(float))
			{
				return (Class147.Enum1)9;
			}
			if (type == typeof(double))
			{
				return (Class147.Enum1)10;
			}
			if (type == typeof(bool))
			{
				return (Class147.Enum1)11;
			}
			if (type == typeof(IntPtr))
			{
				return (Class147.Enum1)12;
			}
			if (type == typeof(UIntPtr))
			{
				return (Class147.Enum1)13;
			}
			if (type == typeof(char))
			{
				return (Class147.Enum1)15;
			}
			if (type == typeof(object))
			{
				return (Class147.Enum1)0;
			}
			if (type.IsEnum)
			{
				return (Class147.Enum1)16;
			}
			return (Class147.Enum1)17;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00033F40 File Offset: 0x00032140
		internal static Class147.Class158 smethod_0(Type type_0, object object_0)
		{
			Class147.Enum1 @enum = Class147.Class158.wceRauqQjd(type_0);
			Class147.Enum1 enum2 = (Class147.Enum1)18;
			if (object_0 != null)
			{
				enum2 = Class147.Class158.wceRauqQjd(object_0.GetType());
			}
			Class147.Class158 @class = null;
			switch (@enum)
			{
			case (Class147.Enum1)0:
				if (enum2 == (Class147.Enum1)15)
				{
					@class = new Class147.Class170(object_0);
				}
				else
				{
					@class = Class147.Class158.smethod_1(object_0);
				}
				break;
			case (Class147.Enum1)1:
				if (enum2 <= (Class147.Enum1)2)
				{
					if (enum2 == (Class147.Enum1)1)
					{
						@class = new Class147.Class160((int)((sbyte)object_0), (Class147.Enum0)1);
						break;
					}
					if (enum2 == (Class147.Enum1)2)
					{
						@class = new Class147.Class160((int)((sbyte)((byte)object_0)), (Class147.Enum0)1);
						break;
					}
				}
				else if (enum2 != (Class147.Enum1)11)
				{
					if (enum2 == (Class147.Enum1)15)
					{
						@class = new Class147.Class160((int)((sbyte)((char)object_0)), (Class147.Enum0)1);
						break;
					}
				}
				else
				{
					if ((bool)object_0)
					{
						@class = new Class147.Class160(1, (Class147.Enum0)1);
						break;
					}
					@class = new Class147.Class160(0, (Class147.Enum0)1);
					break;
				}
				throw new InvalidCastException();
			case (Class147.Enum1)2:
				if (enum2 <= (Class147.Enum1)2)
				{
					if (enum2 == (Class147.Enum1)1)
					{
						@class = new Class147.Class160((int)((byte)((sbyte)object_0)), (Class147.Enum0)2);
						break;
					}
					if (enum2 == (Class147.Enum1)2)
					{
						@class = new Class147.Class160((int)((byte)object_0), (Class147.Enum0)2);
						break;
					}
				}
				else if (enum2 != (Class147.Enum1)11)
				{
					if (enum2 == (Class147.Enum1)15)
					{
						@class = new Class147.Class160((int)((byte)((char)object_0)), (Class147.Enum0)2);
						break;
					}
				}
				else
				{
					if ((bool)object_0)
					{
						@class = new Class147.Class160(1, (Class147.Enum0)2);
						break;
					}
					@class = new Class147.Class160(0, (Class147.Enum0)2);
					break;
				}
				throw new InvalidCastException();
			case (Class147.Enum1)3:
				if (enum2 != (Class147.Enum1)3)
				{
					if (enum2 != (Class147.Enum1)11)
					{
						if (enum2 != (Class147.Enum1)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class147.Class160((int)((short)((char)object_0)), (Class147.Enum0)3);
					}
					else if ((bool)object_0)
					{
						@class = new Class147.Class160(1, (Class147.Enum0)3);
					}
					else
					{
						@class = new Class147.Class160(0, (Class147.Enum0)3);
					}
				}
				else
				{
					@class = new Class147.Class160((int)((short)object_0), (Class147.Enum0)3);
				}
				break;
			case (Class147.Enum1)4:
				if (enum2 != (Class147.Enum1)4)
				{
					if (enum2 != (Class147.Enum1)11)
					{
						if (enum2 != (Class147.Enum1)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class147.Class160((int)((char)object_0), (Class147.Enum0)4);
					}
					else if (!(bool)object_0)
					{
						@class = new Class147.Class160(0, (Class147.Enum0)4);
					}
					else
					{
						@class = new Class147.Class160(1, (Class147.Enum0)4);
					}
				}
				else
				{
					@class = new Class147.Class160((int)((ushort)object_0), (Class147.Enum0)4);
				}
				break;
			case (Class147.Enum1)5:
				if (enum2 != (Class147.Enum1)5)
				{
					if (enum2 != (Class147.Enum1)11)
					{
						if (enum2 != (Class147.Enum1)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class147.Class160((int)((char)object_0), (Class147.Enum0)5);
					}
					else if ((bool)object_0)
					{
						@class = new Class147.Class160(1, (Class147.Enum0)5);
					}
					else
					{
						@class = new Class147.Class160(0, (Class147.Enum0)5);
					}
				}
				else
				{
					@class = new Class147.Class160((int)object_0, (Class147.Enum0)5);
				}
				break;
			case (Class147.Enum1)6:
				if (enum2 != (Class147.Enum1)6)
				{
					if (enum2 != (Class147.Enum1)11)
					{
						if (enum2 != (Class147.Enum1)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class147.Class160((uint)((char)object_0), (Class147.Enum0)6);
					}
					else if (!(bool)object_0)
					{
						@class = new Class147.Class160(0U, (Class147.Enum0)6);
					}
					else
					{
						@class = new Class147.Class160(1U, (Class147.Enum0)6);
					}
				}
				else
				{
					@class = new Class147.Class160((uint)object_0, (Class147.Enum0)6);
				}
				break;
			case (Class147.Enum1)7:
				if (enum2 != (Class147.Enum1)7)
				{
					if (enum2 != (Class147.Enum1)11)
					{
						if (enum2 != (Class147.Enum1)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class147.Class161((long)((ulong)((char)object_0)), (Class147.Enum0)7);
					}
					else if (!(bool)object_0)
					{
						@class = new Class147.Class161(0L, (Class147.Enum0)7);
					}
					else
					{
						@class = new Class147.Class161(1L, (Class147.Enum0)7);
					}
				}
				else
				{
					@class = new Class147.Class161((long)object_0, (Class147.Enum0)7);
				}
				break;
			case (Class147.Enum1)8:
				if (enum2 != (Class147.Enum1)8)
				{
					if (enum2 != (Class147.Enum1)11)
					{
						if (enum2 != (Class147.Enum1)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class147.Class161((ulong)((char)object_0), (Class147.Enum0)8);
					}
					else if (!(bool)object_0)
					{
						@class = new Class147.Class161(0UL, (Class147.Enum0)8);
					}
					else
					{
						@class = new Class147.Class161(1UL, (Class147.Enum0)8);
					}
				}
				else
				{
					@class = new Class147.Class161((ulong)object_0, (Class147.Enum0)8);
				}
				break;
			case (Class147.Enum1)9:
				if (enum2 != (Class147.Enum1)9)
				{
					throw new InvalidCastException();
				}
				@class = new Class147.Class163((float)object_0);
				break;
			case (Class147.Enum1)10:
				if (enum2 != (Class147.Enum1)10)
				{
					throw new InvalidCastException();
				}
				@class = new Class147.Class163((double)object_0);
				break;
			case (Class147.Enum1)11:
				switch (enum2)
				{
				case (Class147.Enum1)1:
					@class = new Class147.Class160((sbyte)object_0 != 0);
					goto IL_67D;
				case (Class147.Enum1)2:
					@class = new Class147.Class160((byte)object_0 > 0);
					goto IL_67D;
				case (Class147.Enum1)3:
					@class = new Class147.Class160((short)object_0 != 0);
					goto IL_67D;
				case (Class147.Enum1)4:
					@class = new Class147.Class160((ushort)object_0 > 0);
					goto IL_67D;
				case (Class147.Enum1)5:
					@class = new Class147.Class160((int)object_0 != 0);
					goto IL_67D;
				case (Class147.Enum1)6:
					@class = new Class147.Class160((uint)object_0 > 0U);
					goto IL_67D;
				case (Class147.Enum1)7:
					@class = new Class147.Class160((long)object_0 != 0L);
					goto IL_67D;
				case (Class147.Enum1)8:
					@class = new Class147.Class160((ulong)object_0 > 0UL);
					goto IL_67D;
				case (Class147.Enum1)9:
				case (Class147.Enum1)10:
				case (Class147.Enum1)12:
				case (Class147.Enum1)13:
				case (Class147.Enum1)14:
				case (Class147.Enum1)15:
				case (Class147.Enum1)16:
					throw new InvalidCastException();
				case (Class147.Enum1)11:
					@class = new Class147.Class160((bool)object_0);
					goto IL_67D;
				case (Class147.Enum1)18:
					@class = new Class147.Class160(false);
					goto IL_67D;
				}
				@class = new Class147.Class160(object_0 != null);
				break;
			case (Class147.Enum1)12:
				if (enum2 != (Class147.Enum1)12)
				{
					throw new InvalidCastException();
				}
				@class = new Class147.Class162((IntPtr)object_0);
				break;
			case (Class147.Enum1)13:
				if (enum2 != (Class147.Enum1)13)
				{
					throw new InvalidCastException();
				}
				@class = new Class147.Class162((UIntPtr)object_0);
				break;
			case (Class147.Enum1)14:
				@class = new Class147.Class171(object_0 as string);
				break;
			case (Class147.Enum1)15:
				switch (enum2)
				{
				case (Class147.Enum1)1:
					@class = new Class147.Class160((int)((sbyte)object_0), (Class147.Enum0)15);
					break;
				case (Class147.Enum1)2:
					@class = new Class147.Class160((int)((byte)object_0), (Class147.Enum0)15);
					break;
				case (Class147.Enum1)3:
					@class = new Class147.Class160((int)((short)object_0), (Class147.Enum0)15);
					break;
				case (Class147.Enum1)4:
					@class = new Class147.Class160((int)((ushort)object_0), (Class147.Enum0)15);
					break;
				case (Class147.Enum1)5:
					@class = new Class147.Class160((int)object_0, (Class147.Enum0)15);
					break;
				case (Class147.Enum1)6:
					@class = new Class147.Class160((int)((uint)object_0), (Class147.Enum0)15);
					break;
				default:
					if (enum2 != (Class147.Enum1)15)
					{
						throw new InvalidCastException();
					}
					@class = new Class147.Class160((int)((char)object_0), (Class147.Enum0)15);
					break;
				}
				break;
			case (Class147.Enum1)16:
			case (Class147.Enum1)17:
				@class = Class147.Class158.smethod_1(object_0);
				break;
			case (Class147.Enum1)18:
				throw new InvalidCastException();
			}
			IL_67D:
			if (type_0.IsByRef)
			{
				@class = new Class147.Class169(@class, type_0.GetElementType());
			}
			return @class;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x000345EC File Offset: 0x000327EC
		private static Class147.Class158 smethod_1(object object_0)
		{
			if (object_0 != null && object_0.GetType().IsEnum)
			{
				Type underlyingType = Enum.GetUnderlyingType(object_0.GetType());
				object object_ = Convert.ChangeType(object_0, underlyingType);
				Class147.Class158 @class = Class147.Class158.smethod_2(Class147.Class158.smethod_0(underlyingType, object_));
				if (@class != null)
				{
					return @class as Class147.Class159;
				}
			}
			return new Class147.Class170(object_0);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00031CC8 File Offset: 0x0002FEC8
		private static Class147.Class159 smethod_2(Class147.Class158 class158_0)
		{
			Class147.Class159 @class = class158_0 as Class147.Class159;
			if (@class == null && class158_0.vmethod_0())
			{
				@class = (class158_0.vmethod_8() as Class147.Class159);
			}
			return @class;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00004519 File Offset: 0x00002719
		internal static bool XiZDHdZUtvJ5ZNfni8pT()
		{
			return Class147.Class158.T8MwuoZU4kehvOhYy2x6 == null;
		}

		// Token: 0x0400054D RID: 1357
		internal Class147.Enum3 enum3_0;

		// Token: 0x0400054E RID: 1358
		internal static Class147.Class158 T8MwuoZU4kehvOhYy2x6;
	}

	// Token: 0x0200019B RID: 411
	private class Class170 : Class147.Class158
	{
		// Token: 0x06000A4A RID: 2634 RVA: 0x00034644 File Offset: 0x00032844
		public Class170() : this(null)
		{
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00034658 File Offset: 0x00032858
		internal override void vmethod_10(Class147.Class158 class158_1)
		{
			if (!(class158_1 is Class147.Class170))
			{
				this.class158_0 = class158_1.vmethod_8();
				return;
			}
			this.class158_0 = ((Class147.Class170)class158_1).class158_0;
			this.type_0 = ((Class147.Class170)class158_1).type_0;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0002826C File Offset: 0x0002646C
		internal override void vmethod_2(Class147.Class158 class158_1)
		{
			this.vmethod_10(class158_1);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0003469C File Offset: 0x0003289C
		public Class170(object object_0) : base((Class147.Enum3)0)
		{
			this.class158_0 = object_0;
			this.type_0 = null;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x000346C0 File Offset: 0x000328C0
		public Class170(object object_0, Type type_1) : base((Class147.Enum3)0)
		{
			this.class158_0 = object_0;
			this.type_0 = type_1;
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x000346E4 File Offset: 0x000328E4
		public override string ToString()
		{
			if (this.class158_0 == null)
			{
				return ((Class147.Enum4)5).ToString();
			}
			return this.class158_0.ToString();
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00034718 File Offset: 0x00032918
		internal override object vmethod_4(Type type_1)
		{
			if (this.class158_0 == null)
			{
				return null;
			}
			if (type_1 != null && type_1.IsByRef)
			{
				type_1 = type_1.GetElementType();
			}
			if (!(this.class158_0 is Class147.Class158))
			{
				object obj = this.class158_0;
				if (obj != null && type_1 != null && obj.GetType() != type_1)
				{
					if (type_1 == typeof(RuntimeFieldHandle) && obj is FieldInfo)
					{
						obj = ((FieldInfo)obj).FieldHandle;
					}
					else if (type_1 == typeof(RuntimeTypeHandle) && obj is Type)
					{
						obj = ((Type)obj).TypeHandle;
					}
					else if (type_1 == typeof(RuntimeMethodHandle) && obj is MethodBase)
					{
						obj = ((MethodBase)obj).MethodHandle;
					}
				}
				return obj;
			}
			if (!(this.type_0 != null))
			{
				object obj2 = ((Class147.Class158)this.class158_0).vmethod_4(type_1);
				if (obj2 != null && type_1 != null && obj2.GetType() != type_1)
				{
					if (type_1 == typeof(RuntimeFieldHandle) && obj2 is FieldInfo)
					{
						obj2 = ((FieldInfo)obj2).FieldHandle;
					}
					else if (type_1 == typeof(RuntimeTypeHandle) && obj2 is Type)
					{
						obj2 = ((Type)obj2).TypeHandle;
					}
					else if (type_1 == typeof(RuntimeMethodHandle) && obj2 is MethodBase)
					{
						obj2 = ((MethodBase)obj2).MethodHandle;
					}
				}
				return obj2;
			}
			return ((Class147.Class158)this.class158_0).vmethod_4(this.type_0);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0003490C File Offset: 0x00032B0C
		internal override bool vmethod_5(Class147.Class158 class158_1)
		{
			if (!class158_1.vmethod_0())
			{
				object obj = this.vmethod_4(null);
				object obj2 = class158_1.vmethod_4(null);
				return obj == obj2;
			}
			return ((Class147.Class164)class158_1).vmethod_5(this);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00034944 File Offset: 0x00032B44
		internal override bool vmethod_6(Class147.Class158 class158_1)
		{
			if (!class158_1.vmethod_0())
			{
				object obj = this.vmethod_4(null);
				object obj2 = class158_1.vmethod_4(null);
				return obj != obj2;
			}
			return ((Class147.Class164)class158_1).vmethod_6(this);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00034980 File Offset: 0x00032B80
		internal override Class147.Class158 vmethod_8()
		{
			Class147.Class158 @class = this.class158_0 as Class147.Class158;
			if (@class != null)
			{
				return @class.vmethod_8();
			}
			return this;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x000349A8 File Offset: 0x00032BA8
		internal override bool vmethod_7()
		{
			if (this.class158_0 != null)
			{
				Class147.Class158 @class = this.class158_0 as Class147.Class158;
				return @class == null || @class.vmethod_4(null) != null;
			}
			return false;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00004523 File Offset: 0x00002723
		internal static bool zEtoHhZUPWULl5bv6YfY()
		{
			return Class147.Class170.akfWDqZUKq7RioNkB53e == null;
		}

		// Token: 0x0400054F RID: 1359
		public Class147.Class158 class158_0;

		// Token: 0x04000550 RID: 1360
		public Type type_0;

		// Token: 0x04000551 RID: 1361
		internal static Class147.Class170 akfWDqZUKq7RioNkB53e;
	}

	// Token: 0x0200019C RID: 412
	private class Class171 : Class147.Class158
	{
		// Token: 0x06000A56 RID: 2646 RVA: 0x000349E0 File Offset: 0x00032BE0
		public Class171(string string_1) : base((Class147.Enum3)6)
		{
			this.string_0 = string_1;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x000349FC File Offset: 0x00032BFC
		internal override void vmethod_10(Class147.Class158 class158_0)
		{
			this.string_0 = ((Class147.Class171)class158_0).string_0;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0002826C File Offset: 0x0002646C
		internal override void vmethod_2(Class147.Class158 class158_0)
		{
			this.vmethod_10(class158_0);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00034A1C File Offset: 0x00032C1C
		public override string ToString()
		{
			if (this.string_0 == null)
			{
				return ((Class147.Enum4)5).ToString();
			}
			return '*'.ToString() + this.string_0 + '*'.ToString();
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0000452D File Offset: 0x0000272D
		internal override bool vmethod_7()
		{
			return this.string_0 != null;
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00004538 File Offset: 0x00002738
		internal override object vmethod_4(Type type_0)
		{
			return this.string_0;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00034A64 File Offset: 0x00032C64
		internal override bool vmethod_5(Class147.Class158 class158_0)
		{
			if (!class158_0.vmethod_0())
			{
				object obj = this.string_0;
				object obj2 = class158_0.vmethod_4(null);
				return obj == obj2;
			}
			return ((Class147.Class164)class158_0).vmethod_5(this);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00034A9C File Offset: 0x00032C9C
		internal override bool vmethod_6(Class147.Class158 class158_0)
		{
			if (class158_0.vmethod_0())
			{
				return ((Class147.Class164)class158_0).vmethod_6(this);
			}
			object obj = this.string_0;
			object obj2 = class158_0.vmethod_4(null);
			return obj != obj2;
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00003D9B File Offset: 0x00001F9B
		internal override Class147.Class158 vmethod_8()
		{
			return this;
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00004540 File Offset: 0x00002740
		internal static bool et0SiUZUSKQhlqmMgJKE()
		{
			return Class147.Class171.eiPahoZU0JaiCJ2st2q7 == null;
		}

		// Token: 0x04000552 RID: 1362
		public string string_0;

		// Token: 0x04000553 RID: 1363
		private static Class147.Class171 eiPahoZU0JaiCJ2st2q7;
	}

	// Token: 0x0200019D RID: 413
	internal class Class172
	{
		// Token: 0x06000A60 RID: 2656 RVA: 0x0000454A File Offset: 0x0000274A
		public int method_0()
		{
			return this.list_0.Count;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00034AD4 File Offset: 0x00032CD4
		public void method_1()
		{
			this.list_0.Clear();
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00034AEC File Offset: 0x00032CEC
		public void method_2(Class147.Class158 class158_0)
		{
			this.list_0.Add(class158_0);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00004557 File Offset: 0x00002757
		public Class147.Class158 method_3()
		{
			return this.list_0[this.list_0.Count - 1];
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00004571 File Offset: 0x00002771
		public Class147.Class158 method_4()
		{
			Class147.Class158 result = this.method_3();
			if (this.list_0.Count != 0)
			{
				this.list_0.RemoveAt(this.list_0.Count - 1);
			}
			return result;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0000459E File Offset: 0x0000279E
		internal static bool kwOqlkZUai4jZ2aYuuU8()
		{
			return Class147.Class172.hpYUxUZUn1CbBhht5Mni == null;
		}

		// Token: 0x04000554 RID: 1364
		private List<Class147.Class158> list_0 = new List<Class147.Class158>();

		// Token: 0x04000555 RID: 1365
		private static Class147.Class172 hpYUxUZUn1CbBhht5Mni;
	}

	// Token: 0x0200019E RID: 414
	private struct Struct5
	{
		// Token: 0x06000A67 RID: 2663 RVA: 0x00034B28 File Offset: 0x00032D28
		public Struct5(int int_0, int int_1)
		{
			this.stringBuilder_0 = new StringBuilder();
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00034B28 File Offset: 0x00032D28
		public Struct5(int int_0, int int_1, IFormatProvider iformatProvider_0)
		{
			this.stringBuilder_0 = new StringBuilder();
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00034B40 File Offset: 0x00032D40
		public void AppendLiteral(string string_0)
		{
			if (string_0 != null)
			{
				this.stringBuilder_0.Append(string_0);
			}
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x000045A8 File Offset: 0x000027A8
		public void AppendFormatted<T>(T value)
		{
			if (value != null)
			{
				this.stringBuilder_0.Append(value);
			}
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x000045C4 File Offset: 0x000027C4
		public void AppendFormatted<T>(T value, string string_0)
		{
			if (string_0 != null)
			{
				this.stringBuilder_0.AppendFormat(string_0, value);
				return;
			}
			this.stringBuilder_0.Append(value);
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x000045A8 File Offset: 0x000027A8
		public void AppendFormatted<T>(T value, int int_0)
		{
			if (value != null)
			{
				this.stringBuilder_0.Append(value);
			}
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x000045EF File Offset: 0x000027EF
		public void AppendFormatted<T>(T value, int int_0, string string_0)
		{
			if (string_0 != null)
			{
				this.stringBuilder_0.AppendFormat(string_0, value);
				return;
			}
			this.stringBuilder_0.Append(value);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00034B40 File Offset: 0x00032D40
		public void AppendFormatted(string string_0)
		{
			if (string_0 != null)
			{
				this.stringBuilder_0.Append(string_0);
			}
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00034B60 File Offset: 0x00032D60
		public void AppendFormatted(string string_0, int int_0 = 0, string string_1 = null)
		{
			if (string_1 != null)
			{
				this.stringBuilder_0.AppendFormat(string_1, string_0);
				return;
			}
			this.stringBuilder_0.Append(string_0);
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00034B8C File Offset: 0x00032D8C
		public void AppendFormatted(object object_0, int int_0 = 0, string string_0 = null)
		{
			if (string_0 == null)
			{
				this.stringBuilder_0.Append(object_0);
				return;
			}
			this.stringBuilder_0.AppendFormat(string_0, object_0);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0000461A File Offset: 0x0000281A
		public string ToStringAndClear()
		{
			string result = this.stringBuilder_0.ToString();
			this.stringBuilder_0 = new StringBuilder();
			return result;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00004632 File Offset: 0x00002832
		internal static bool BbJ2KjZU9JcHBlYlPQcs()
		{
			return Class147.Struct5.MlgM1DZUIWHQ6hg0Vkj8 == null;
		}

		// Token: 0x04000556 RID: 1366
		private StringBuilder stringBuilder_0;

		// Token: 0x04000557 RID: 1367
		private static object MlgM1DZUIWHQ6hg0Vkj8;
	}

	// Token: 0x0200019F RID: 415
	internal enum Enum4
	{

	}

	// Token: 0x020001A0 RID: 416
	[CompilerGenerated]
	[Serializable]
	private sealed class Class173<T>
	{
		// Token: 0x06000A75 RID: 2677 RVA: 0x000044BB File Offset: 0x000026BB
		internal int method_0(Class147.Class151 x, Class147.Class151 y)
		{
			return x.class152_0.int_0.CompareTo(y.class152_0.int_0);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0000463C File Offset: 0x0000283C
		internal static bool gx2JWaZ2ZhVW1VQax2FZ()
		{
			return Class147.Class173<T>.TMU5BWZ21Bu86xAEPlJQ == null;
		}

		// Token: 0x04000559 RID: 1369
		public static readonly Class147.Class173<T> <>9 = new Class147.Class173<T>();

		// Token: 0x0400055A RID: 1370
		public static Comparison<Class147.Class151> <>9__47_0;

		// Token: 0x0400055B RID: 1371
		internal static object TMU5BWZ21Bu86xAEPlJQ;
	}
}
