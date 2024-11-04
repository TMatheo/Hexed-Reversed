using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000171 RID: 369
internal class Class144
{
	// Token: 0x06000791 RID: 1937 RVA: 0x000251B4 File Offset: 0x000233B4
	static Class144()
	{
		Class144.dictionary_0 = null;
		Class144.object_1 = new object();
		Class144.assembly_0 = typeof(Class144).Assembly;
		Class144.byte_3 = new byte[0];
		Class144.rsacryptoServiceProvider_0 = null;
		Class144.byte_0 = new byte[0];
		Class144.object_0 = new object();
		Class144.list_1 = null;
		Class144.list_0 = null;
		Class144.int_0 = 0;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x0000388F File Offset: 0x00001A8F
	internal Class144()
	{
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x00002328 File Offset: 0x00000528
	private void method_0()
	{
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x0002525C File Offset: 0x0002345C
	internal static byte[] smethod_0(byte[] byte_4)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - byte_4.Length * 8 % 512 + 512) % 512);
		if (num == 0U)
		{
			num = 512U;
		}
		uint num2 = (uint)((long)byte_4.Length + (long)((ulong)(num / 8U)) + 8L);
		byte[] array2 = new byte[num2];
		for (int i = 0; i < byte_4.Length; i++)
		{
			array2[i] = byte_4[i];
		}
		byte[] array3 = array2;
		int num3 = byte_4.Length;
		array3[num3] |= 128;
		for (int j = 8; j > 0; j--)
		{
			array2[(int)(checked((IntPtr)(unchecked((ulong)num2 - (ulong)((long)j)))))] = 0;
		}
		uint num4 = (uint)(array2.Length * 8 / 32);
		uint num5 = 1732584193U;
		uint num6 = 4023233417U;
		uint num7 = 2562383102U;
		uint num8 = 271733878U;
		for (uint num9 = 0U; num9 < num4 / 16U; num9 += 1U)
		{
			uint num10 = num9 << 6;
			for (uint num11 = 0U; num11 < 61U; num11 += 4U)
			{
				array[(int)(num11 >> 2)] = (uint)((int)array2[(int)(num10 + (num11 + 3U))] << 24 | (int)array2[(int)(num10 + (num11 + 2U))] << 16 | (int)array2[(int)(num10 + (num11 + 1U))] << 8 | (int)array2[(int)(num10 + num11)]);
			}
			uint num12 = num5;
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			Class144.smethod_1(ref num5, num6, num7, num8, 0U, 7, 1U, array);
			Class144.smethod_1(ref num8, num5, num6, num7, 1U, 12, 2U, array);
			Class144.smethod_1(ref num7, num8, num5, num6, 2U, 17, 3U, array);
			Class144.smethod_1(ref num6, num7, num8, num5, 3U, 22, 4U, array);
			Class144.smethod_1(ref num5, num6, num7, num8, 4U, 7, 5U, array);
			Class144.smethod_1(ref num8, num5, num6, num7, 5U, 12, 6U, array);
			Class144.smethod_1(ref num7, num8, num5, num6, 6U, 17, 7U, array);
			Class144.smethod_1(ref num6, num7, num8, num5, 7U, 22, 8U, array);
			Class144.smethod_1(ref num5, num6, num7, num8, 8U, 7, 9U, array);
			Class144.smethod_1(ref num8, num5, num6, num7, 9U, 12, 10U, array);
			Class144.smethod_1(ref num7, num8, num5, num6, 10U, 17, 11U, array);
			Class144.smethod_1(ref num6, num7, num8, num5, 11U, 22, 12U, array);
			Class144.smethod_1(ref num5, num6, num7, num8, 12U, 7, 13U, array);
			Class144.smethod_1(ref num8, num5, num6, num7, 13U, 12, 14U, array);
			Class144.smethod_1(ref num7, num8, num5, num6, 14U, 17, 15U, array);
			Class144.smethod_1(ref num6, num7, num8, num5, 15U, 22, 16U, array);
			Class144.smethod_2(ref num5, num6, num7, num8, 1U, 5, 17U, array);
			Class144.smethod_2(ref num8, num5, num6, num7, 6U, 9, 18U, array);
			Class144.smethod_2(ref num7, num8, num5, num6, 11U, 14, 19U, array);
			Class144.smethod_2(ref num6, num7, num8, num5, 0U, 20, 20U, array);
			Class144.smethod_2(ref num5, num6, num7, num8, 5U, 5, 21U, array);
			Class144.smethod_2(ref num8, num5, num6, num7, 10U, 9, 22U, array);
			Class144.smethod_2(ref num7, num8, num5, num6, 15U, 14, 23U, array);
			Class144.smethod_2(ref num6, num7, num8, num5, 4U, 20, 24U, array);
			Class144.smethod_2(ref num5, num6, num7, num8, 9U, 5, 25U, array);
			Class144.smethod_2(ref num8, num5, num6, num7, 14U, 9, 26U, array);
			Class144.smethod_2(ref num7, num8, num5, num6, 3U, 14, 27U, array);
			Class144.smethod_2(ref num6, num7, num8, num5, 8U, 20, 28U, array);
			Class144.smethod_2(ref num5, num6, num7, num8, 13U, 5, 29U, array);
			Class144.smethod_2(ref num8, num5, num6, num7, 2U, 9, 30U, array);
			Class144.smethod_2(ref num7, num8, num5, num6, 7U, 14, 31U, array);
			Class144.smethod_2(ref num6, num7, num8, num5, 12U, 20, 32U, array);
			Class144.smethod_3(ref num5, num6, num7, num8, 5U, 4, 33U, array);
			Class144.smethod_3(ref num8, num5, num6, num7, 8U, 11, 34U, array);
			Class144.smethod_3(ref num7, num8, num5, num6, 11U, 16, 35U, array);
			Class144.smethod_3(ref num6, num7, num8, num5, 14U, 23, 36U, array);
			Class144.smethod_3(ref num5, num6, num7, num8, 1U, 4, 37U, array);
			Class144.smethod_3(ref num8, num5, num6, num7, 4U, 11, 38U, array);
			Class144.smethod_3(ref num7, num8, num5, num6, 7U, 16, 39U, array);
			Class144.smethod_3(ref num6, num7, num8, num5, 10U, 23, 40U, array);
			Class144.smethod_3(ref num5, num6, num7, num8, 13U, 4, 41U, array);
			Class144.smethod_3(ref num8, num5, num6, num7, 0U, 11, 42U, array);
			Class144.smethod_3(ref num7, num8, num5, num6, 3U, 16, 43U, array);
			Class144.smethod_3(ref num6, num7, num8, num5, 6U, 23, 44U, array);
			Class144.smethod_3(ref num5, num6, num7, num8, 9U, 4, 45U, array);
			Class144.smethod_3(ref num8, num5, num6, num7, 12U, 11, 46U, array);
			Class144.smethod_3(ref num7, num8, num5, num6, 15U, 16, 47U, array);
			Class144.smethod_3(ref num6, num7, num8, num5, 2U, 23, 48U, array);
			Class144.smethod_4(ref num5, num6, num7, num8, 0U, 6, 49U, array);
			Class144.smethod_4(ref num8, num5, num6, num7, 7U, 10, 50U, array);
			Class144.smethod_4(ref num7, num8, num5, num6, 14U, 15, 51U, array);
			Class144.smethod_4(ref num6, num7, num8, num5, 5U, 21, 52U, array);
			Class144.smethod_4(ref num5, num6, num7, num8, 12U, 6, 53U, array);
			Class144.smethod_4(ref num8, num5, num6, num7, 3U, 10, 54U, array);
			Class144.smethod_4(ref num7, num8, num5, num6, 10U, 15, 55U, array);
			Class144.smethod_4(ref num6, num7, num8, num5, 1U, 21, 56U, array);
			Class144.smethod_4(ref num5, num6, num7, num8, 8U, 6, 57U, array);
			Class144.smethod_4(ref num8, num5, num6, num7, 15U, 10, 58U, array);
			Class144.smethod_4(ref num7, num8, num5, num6, 6U, 15, 59U, array);
			Class144.smethod_4(ref num6, num7, num8, num5, 13U, 21, 60U, array);
			Class144.smethod_4(ref num5, num6, num7, num8, 4U, 6, 61U, array);
			Class144.smethod_4(ref num8, num5, num6, num7, 11U, 10, 62U, array);
			Class144.smethod_4(ref num7, num8, num5, num6, 2U, 15, 63U, array);
			Class144.smethod_4(ref num6, num7, num8, num5, 9U, 21, 64U, array);
			num5 += num12;
			num6 += num13;
			num7 += num14;
			num8 += num15;
		}
		byte[] array4 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num5), 0, array4, 0, 4);
		Array.Copy(BitConverter.GetBytes(num6), 0, array4, 4, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array4, 8, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array4, 12, 4);
		return array4;
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x00003897 File Offset: 0x00001A97
	private static void smethod_1(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class144.smethod_5(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + uint_7[(int)uint_5] + Class144.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x000038C0 File Offset: 0x00001AC0
	private static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class144.smethod_5(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + uint_7[(int)uint_5] + Class144.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x000038E9 File Offset: 0x00001AE9
	private static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class144.smethod_5(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + uint_7[(int)uint_5] + Class144.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x0000390F File Offset: 0x00001B0F
	private static void smethod_4(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class144.smethod_5(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + uint_7[(int)uint_5] + Class144.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x00002DE4 File Offset: 0x00000FE4
	private static uint smethod_5(uint uint_1, ushort ushort_0)
	{
		return 0U;
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x00003936 File Offset: 0x00001B36
	internal static byte[] smethod_6(byte[] byte_4)
	{
		if (!Class144.smethod_8())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_4);
		}
		return Class144.smethod_0(byte_4);
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x00025898 File Offset: 0x00023A98
	private static void smethod_7()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x00003951 File Offset: 0x00001B51
	internal static bool smethod_8()
	{
		if (!Class144.bool_0)
		{
			Class144.smethod_11();
			Class144.bool_0 = true;
		}
		return Class144.bool_1;
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x0000396A File Offset: 0x00001B6A
	internal byte[] method_1()
	{
		int length = "{11111-22222-40001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x00003985 File Offset: 0x00001B85
	internal byte[] method_2()
	{
		int length = "{11111-22222-40001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x000039A0 File Offset: 0x00001BA0
	internal byte[] method_3()
	{
		int length = "{11111-22222-50001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x000039BB File Offset: 0x00001BBB
	internal byte[] method_4()
	{
		int length = "{11111-22222-50001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x000258C0 File Offset: 0x00023AC0
	public static void smethod_9(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (Class144.dictionary_0 == null)
			{
				object obj = Class144.object_1;
				lock (obj)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(Class144).Assembly.GetManifestResourceStream("dy1yGg8JFOBy1S8MyI.hdyHiHJaPGs1hNpYyZ"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length != 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0U;
						if (num > 0)
						{
							num2++;
						}
						for (int i = 0; i < num2; i++)
						{
							int num4 = i * 4;
							uint num5 = 255U;
							int num6 = 0;
							uint num7;
							if (i == num2 - 1 && num > 0)
							{
								num7 = 0U;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num7 <<= 8;
									}
									num7 |= (uint)array[array.Length - (1 + j)];
								}
							}
							else
							{
								uint num8 = (uint)num4;
								num7 = (uint)((int)array[(int)(num8 + 3U)] << 24 | (int)array[(int)(num8 + 2U)] << 16 | (int)array[(int)(num8 + 1U)] << 8 | (int)array[(int)num8]);
							}
							num3 = num3;
							uint num9 = num3;
							uint num10 = num3;
							uint num11 = num10 / 515470795U + 515470795U;
							uint num12 = num10 + num10 + num11 + num10;
							num10 += 3544217681U;
							num12 = 8617075U * (num12 & 15U) + (num12 >> 4);
							num10 ^= num10 >> 19;
							num10 += 571567973U;
							num10 ^= num10 << 5;
							num10 += num10;
							num10 ^= num10 >> 1;
							num10 += 292407599U;
							num10 = (3969908736U - num10 ^ num10) + num10;
							num3 = num9 + (uint)num10;
							if (i == num2 - 1 && num > 0)
							{
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num5 <<= 8;
										num6 += 8;
									}
									array2[num4 + k] = 0;
								}
							}
							else
							{
								uint num13 = num3 ^ num7;
								array2[num4] = (byte)(num13 & 255U);
								array2[num4 + 1] = (byte)((num13 & 65280U) >> 8);
								array2[num4 + 2] = (byte)((num13 & 16711680U) >> 16);
								array2[num4 + 3] = (byte)((num13 & 4278190080U) >> 24);
							}
						}
						array = array2;
						int num14 = array.Length / 8;
						Class144.Class145 @class = new Class144.Class145(new MemoryStream(array));
						for (int l = 0; l < num14; l++)
						{
							int key = @class.method_3();
							int value = @class.method_3();
							dictionary.Add(key, value);
						}
						@class.method_4();
					}
					Class144.dictionary_0 = dictionary;
				}
			}
			foreach (FieldInfo fieldInfo in typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField))
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num15 = Class144.dictionary_0[metadataToken];
				bool flag2 = (num15 & 1073741824) > 0;
				num15 &= 1073741823;
				MethodInfo methodInfo = (MethodInfo)typeof(Class144).Module.ResolveMethod(num15, typeFromHandle.GetGenericArguments(), new Type[0]);
				if (methodInfo.IsStatic)
				{
					fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
				}
				else
				{
					ParameterInfo[] parameters = methodInfo.GetParameters();
					int num16 = parameters.Length + 1;
					Type[] array3 = new Type[num16];
					if (methodInfo.DeclaringType.IsValueType)
					{
						array3[0] = methodInfo.DeclaringType.MakeByRefType();
					}
					else
					{
						array3[0] = typeof(object);
					}
					for (int n = 0; n < parameters.Length; n++)
					{
						array3[n + 1] = parameters[n].ParameterType;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					for (int num17 = 0; num17 < num16; num17++)
					{
						switch (num17)
						{
						case 0:
							ilgenerator.Emit(OpCodes.Ldarg_0);
							break;
						case 1:
							ilgenerator.Emit(OpCodes.Ldarg_1);
							break;
						case 2:
							ilgenerator.Emit(OpCodes.Ldarg_2);
							break;
						case 3:
							ilgenerator.Emit(OpCodes.Ldarg_3);
							break;
						default:
							ilgenerator.Emit(OpCodes.Ldarg_S, num17);
							break;
						}
					}
					ilgenerator.Emit(OpCodes.Tailcall);
					ilgenerator.Emit(flag2 ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
					ilgenerator.Emit(OpCodes.Ret);
					fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
				}
			}
		}
		catch (Exception ex)
		{
			throw ex;
		}
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x000039D6 File Offset: 0x00001BD6
	internal static void smethod_10()
	{
		if (Debugger.IsAttached)
		{
			throw new Exception("Debugger Detected");
		}
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x00025DFC File Offset: 0x00023FFC
	internal static void smethod_11()
	{
		try
		{
			new MD5CryptoServiceProvider();
		}
		catch
		{
			Class144.bool_1 = true;
			return;
		}
		try
		{
			Class144.bool_1 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x00025E48 File Offset: 0x00024048
	internal static SymmetricAlgorithm smethod_12()
	{
		SymmetricAlgorithm result = null;
		if (Class144.smethod_8())
		{
			result = new AesCryptoServiceProvider();
		}
		else
		{
			try
			{
				result = new RijndaelManaged();
			}
			catch
			{
				result = new AesCryptoServiceProvider();
			}
		}
		return result;
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x000039EA File Offset: 0x00001BEA
	private byte[] method_5()
	{
		int length = "{11111-22222-20001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x00003A05 File Offset: 0x00001C05
	private byte[] method_6()
	{
		int length = "{11111-22222-20001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x00025E8C File Offset: 0x0002408C
	internal static void smethod_13(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_1, byte[] byte_4)
	{
		while (uint_1 > 0U)
		{
			int num = (uint_1 > (uint)byte_4.Length) ? byte_4.Length : ((int)uint_1);
			stream_0.Read(byte_4, 0, num);
			Class144.smethod_14(hashAlgorithm_0, byte_4, 0, num);
			uint_1 -= (uint)num;
		}
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x00003A20 File Offset: 0x00001C20
	internal static void smethod_14(HashAlgorithm hashAlgorithm_0, byte[] byte_4, int int_1, int int_2)
	{
		hashAlgorithm_0.TransformBlock(byte_4, int_1, int_2, byte_4, int_1);
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x00025EC8 File Offset: 0x000240C8
	internal static uint smethod_15(uint uint_1, int int_1, long long_0, BinaryReader binaryReader_0)
	{
		for (int i = 0; i < int_1; i++)
		{
			binaryReader_0.BaseStream.Position = long_0 + (long)(i * 40 + 8);
			uint num = binaryReader_0.ReadUInt32();
			uint num2 = binaryReader_0.ReadUInt32();
			binaryReader_0.ReadUInt32();
			uint num3 = binaryReader_0.ReadUInt32();
			if (num2 <= uint_1 && uint_1 < num2 + num)
			{
				return num3 + uint_1 - num2;
			}
		}
		return 0U;
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x00025F24 File Offset: 0x00024124
	internal static void smethod_16()
	{
		if (Class144.rsacryptoServiceProvider_0 == null)
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
			Class144.rsacryptoServiceProvider_0 = new RSACryptoServiceProvider();
			string location = typeof(Class144).Assembly.Location;
			if (location == null || location.Length == 0)
			{
				return;
			}
			HashAlgorithm hashAlgorithm = null;
			string str = null;
			try
			{
				hashAlgorithm = SHA1.Create();
				str = CryptoConfig.MapNameToOID("SHA1");
				if (!File.Exists(location))
				{
					return;
				}
			}
			catch
			{
				return;
			}
			bool flag = false;
			try
			{
				Class144.Class145 @class = new Class144.Class145(Class144.assembly_0.GetManifestResourceStream("{11111-22222-20001-00000}"));
				@class.method_0().Position = 0L;
				byte[] array = @class.method_1((int)@class.method_0().Length);
				byte[] rgbKey = new Class144().method_6();
				byte[] rgbIV = new Class144().method_5();
				SymmetricAlgorithm symmetricAlgorithm = Class144.smethod_12();
				symmetricAlgorithm.Mode = CipherMode.CBC;
				ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(rgbKey, rgbIV);
				Stream stream = Class144.smethod_17();
				CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				Class144.rsacryptoServiceProvider_0.FromXmlString(Encoding.UTF8.GetString(Class144.smethod_20(stream)));
				stream.Close();
				cryptoStream.Close();
				@class.method_4();
			}
			catch
			{
				flag = true;
			}
			if (!flag)
			{
				BinaryReader binaryReader = null;
				try
				{
					FileStream fileStream = new FileStream(location, FileMode.Open, FileAccess.Read, FileShare.Read);
					binaryReader = new BinaryReader(fileStream);
					byte[] array2 = new byte[65536];
					Class144.smethod_13(hashAlgorithm, fileStream, 152U, array2);
					bool flag2 = binaryReader.ReadUInt16() != 523;
					int num = flag2 ? 96 : 112;
					fileStream.Position = 152L;
					fileStream.Read(array2, 0, num);
					array2[64] = 0;
					array2[65] = 0;
					array2[66] = 0;
					array2[67] = 0;
					Class144.smethod_14(hashAlgorithm, array2, 0, num);
					fileStream.Read(array2, 0, 128);
					array2[32] = 0;
					array2[33] = 0;
					array2[34] = 0;
					array2[35] = 0;
					array2[36] = 0;
					array2[37] = 0;
					array2[38] = 0;
					array2[39] = 0;
					Class144.smethod_14(hashAlgorithm, array2, 0, 128);
					long position = fileStream.Position;
					fileStream.Position = 134L;
					int num2 = (int)binaryReader.ReadUInt16();
					fileStream.Position = position;
					Class144.smethod_13(hashAlgorithm, fileStream, (uint)(num2 * 40), array2);
					long position2 = fileStream.Position;
					if (flag2)
					{
						fileStream.Position = 360L;
					}
					else
					{
						fileStream.Position = 376L;
					}
					uint num3 = Class144.smethod_15(binaryReader.ReadUInt32(), num2, position, binaryReader);
					fileStream.Position = (long)((ulong)(num3 + 32U));
					uint uint_ = binaryReader.ReadUInt32();
					uint num4 = binaryReader.ReadUInt32();
					long num5 = (long)((ulong)Class144.smethod_15(uint_, num2, position, binaryReader));
					long num6 = num5 + (long)((ulong)num4);
					fileStream.Position = position2;
					int i = 0;
					IL_386:
					while (i < num2)
					{
						fileStream.Position = position + (long)(i * 40) + 16L;
						uint num7 = binaryReader.ReadUInt32();
						uint num8 = binaryReader.ReadUInt32();
						fileStream.Position = (long)((ulong)num8);
						while (num7 > 0U)
						{
							long position3 = fileStream.Position;
							if (num5 <= position3 && position3 < num6)
							{
								uint num9 = (uint)(num6 - position3);
								if (num9 < num7)
								{
									num7 -= num9;
									fileStream.Position += (long)((ulong)num9);
									continue;
								}
							}
							else
							{
								if (position3 < num6)
								{
									uint num10 = (uint)Math.Min(num5 - position3, (long)((ulong)num7));
									Class144.smethod_13(hashAlgorithm, fileStream, num10, array2);
									num7 -= num10;
									continue;
								}
								Class144.smethod_13(hashAlgorithm, fileStream, num7, array2);
							}
							IL_380:
							i++;
							goto IL_386;
						}
						goto IL_380;
					}
					hashAlgorithm.TransformFinalBlock(new byte[0], 0, 0);
					fileStream.Position = num5;
					byte[] array3 = binaryReader.ReadBytes((int)num4);
					Array.Reverse<byte>(array3);
					flag = !Class144.rsacryptoServiceProvider_0.VerifyHash(hashAlgorithm.Hash, str, array3);
				}
				catch
				{
					flag = true;
				}
				try
				{
					if (binaryReader != null)
					{
						binaryReader.Close();
					}
				}
				catch
				{
				}
			}
			if (flag)
			{
				throw new Exception(typeof(Class144).Assembly.GetName().Name + " is tampered.");
			}
			flag = false;
		}
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x00003A2E File Offset: 0x00001C2E
	private static Stream smethod_17()
	{
		return new MemoryStream();
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x000263B0 File Offset: 0x000245B0
	private static byte[] smethod_18(string string_0)
	{
		byte[] array;
		using (FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			int num = 0;
			int i = (int)fileStream.Length;
			array = new byte[i];
			while (i > 0)
			{
				int num2 = fileStream.Read(array, num, i);
				num += num2;
				i -= num2;
			}
		}
		return array;
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x00026410 File Offset: 0x00024610
	internal static object smethod_19(Assembly assembly_1)
	{
		try
		{
			if (File.Exists(((Assembly)assembly_1).Location))
			{
				return ((Assembly)assembly_1).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0]).ToString()))
			{
				return assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0]).ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	// Token: 0x060007AE RID: 1966 RVA: 0x00003A35 File Offset: 0x00001C35
	private static byte[] smethod_20(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x00003A42 File Offset: 0x00001C42
	internal byte[] method_7()
	{
		int length = "{11111-22222-30001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x00003A5D File Offset: 0x00001C5D
	internal byte[] tPnkNfto2()
	{
		int length = "{11111-22222-30001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x00026520 File Offset: 0x00024720
	private static void smethod_21(Stream stream_0)
	{
		using (BinaryReader binaryReader = new BinaryReader(stream_0))
		{
			binaryReader.BaseStream.Position = 0L;
			byte[] byte_ = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array = new byte[32];
			array[0] = 130;
			array[0] = 115;
			array[0] = 149;
			array[0] = 168;
			array[0] = 200;
			array[1] = 90;
			array[1] = 123;
			array[1] = 104;
			array[1] = 244;
			array[2] = 106;
			array[2] = 119;
			array[2] = 208;
			array[3] = 148;
			array[3] = 68;
			array[3] = 155;
			array[3] = 105;
			array[4] = 128;
			array[4] = 141;
			array[4] = 150;
			array[4] = 171;
			array[5] = 152;
			array[5] = 79;
			array[5] = 99;
			array[5] = 119;
			array[5] = 42;
			array[5] = 251;
			array[6] = 127;
			array[6] = 116;
			array[6] = 39;
			array[6] = 199;
			array[7] = 188;
			array[7] = 161;
			array[7] = 128;
			array[7] = 175;
			array[7] = 134;
			array[7] = 159;
			array[8] = 36;
			array[8] = 178;
			array[8] = 149;
			array[8] = 38;
			array[9] = 124;
			array[9] = 75;
			array[9] = 97;
			array[9] = 111;
			array[10] = 126;
			array[10] = 86;
			array[10] = 74;
			array[10] = 92;
			array[11] = 117;
			array[11] = 60;
			array[11] = 27;
			array[12] = 143;
			array[12] = 147;
			array[12] = 41;
			array[12] = 153;
			array[12] = 170;
			array[12] = 129;
			array[13] = 160;
			array[13] = 89;
			array[13] = 156;
			array[13] = 138;
			array[13] = 13;
			array[14] = 166;
			array[14] = 189;
			array[14] = 114;
			array[14] = 144;
			array[14] = 140;
			array[15] = 158;
			array[15] = 141;
			array[15] = 248;
			array[16] = 112;
			array[16] = 105;
			array[16] = 87;
			array[16] = 54;
			array[17] = 136;
			array[17] = 148;
			array[17] = 54;
			array[17] = 122;
			array[17] = 94;
			array[17] = 165;
			array[18] = 124;
			array[18] = 169;
			array[18] = 63;
			array[18] = 130;
			array[18] = 103;
			array[19] = 40;
			array[19] = 134;
			array[19] = 116;
			array[19] = 115;
			array[19] = 143;
			array[19] = 223;
			array[20] = 177;
			array[20] = 114;
			array[20] = 80;
			array[20] = 121;
			array[20] = 58;
			array[21] = 133;
			array[21] = 150;
			array[21] = 91;
			array[21] = 103;
			array[21] = 23;
			array[22] = 111;
			array[22] = 130;
			array[22] = 127;
			array[22] = 69;
			array[23] = 130;
			array[23] = 90;
			array[23] = 94;
			array[23] = 173;
			array[23] = 73;
			array[24] = 37;
			array[24] = 142;
			array[24] = 115;
			array[24] = 162;
			array[24] = 71;
			array[25] = 162;
			array[25] = 113;
			array[25] = 103;
			array[25] = 72;
			array[26] = 24;
			array[26] = 139;
			array[26] = 144;
			array[26] = 11;
			array[27] = 160;
			array[27] = 179;
			array[27] = 116;
			array[27] = 26;
			array[28] = 115;
			array[28] = 109;
			array[28] = 148;
			array[28] = 137;
			array[28] = 97;
			array[28] = 102;
			array[29] = 138;
			array[29] = 117;
			array[29] = 100;
			array[29] = 90;
			array[29] = 105;
			array[30] = 151;
			array[30] = 125;
			array[30] = 83;
			array[30] = 25;
			array[31] = 58;
			array[31] = 224;
			array[31] = 128;
			array[31] = 195;
			byte[] byte_2 = array;
			byte[] array2 = new byte[16];
			array2[0] = 67;
			array2[0] = 48;
			array2[0] = 98;
			array2[0] = 40;
			array2[0] = 90;
			array2[0] = 206;
			array2[1] = 159;
			array2[1] = 100;
			array2[1] = 152;
			array2[1] = 119;
			array2[1] = 203;
			array2[1] = 101;
			array2[2] = 123;
			array2[2] = 127;
			array2[2] = 128;
			array2[2] = 73;
			array2[3] = 122;
			array2[3] = 134;
			array2[3] = 48;
			array2[4] = 125;
			array2[4] = 24;
			array2[4] = 56;
			array2[4] = 10;
			array2[5] = 97;
			array2[5] = 98;
			array2[5] = 44;
			array2[6] = 50;
			array2[6] = 169;
			array2[6] = 241;
			array2[7] = 125;
			array2[7] = 162;
			array2[7] = 150;
			array2[7] = 156;
			array2[7] = 27;
			array2[8] = 73;
			array2[8] = 143;
			array2[8] = 149;
			array2[8] = 63;
			array2[8] = 84;
			array2[8] = 87;
			array2[9] = 143;
			array2[9] = 112;
			array2[9] = 123;
			array2[9] = 22;
			array2[10] = 119;
			array2[10] = 131;
			array2[10] = 154;
			array2[11] = 117;
			array2[11] = 95;
			array2[11] = 94;
			array2[11] = 101;
			array2[12] = 205;
			array2[12] = 131;
			array2[12] = 220;
			array2[12] = 235;
			array2[12] = 115;
			array2[12] = 170;
			array2[13] = 89;
			array2[13] = 162;
			array2[13] = 79;
			array2[13] = 124;
			array2[13] = 113;
			array2[14] = 112;
			array2[14] = 104;
			array2[14] = 151;
			array2[14] = 86;
			array2[14] = 220;
			array2[14] = 6;
			array2[15] = 182;
			array2[15] = 145;
			array2[15] = 130;
			array2[15] = 112;
			array2[15] = 179;
			array2[15] = 9;
			byte[] byte_3 = array2;
			if (Class144.assembly_0.EntryPoint == null)
			{
				Class144.int_0 = 80;
			}
			Class144.byte_0 = new Class144(byte_2, byte_3).method_8(byte_);
		}
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x00027160 File Offset: 0x00025360
	internal static string smethod_22(int int_1)
	{
		/*
An exception occurred when decompiling this method (060007B2)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.String Class144::smethod_22(System.Int32)

 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILExpression expr, ILExpression parentExpr, Int32 posInParent) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1587
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.IntroducePropertyAccessInstructions(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 1579
   at ICSharpCode.Decompiler.ILAst.ILAstOptimizer.Optimize(DecompilerContext context, ILBlock method, AutoPropertyProvider autoPropertyProvider, StateMachineKind& stateMachineKind, MethodDef& inlinedMethod, AsyncMethodDebugInfo& asyncInfo, ILAstOptimizationStep abortBeforeStep) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstOptimizer.cs:line 244
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 123
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1533
*/;
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x00003A78 File Offset: 0x00001C78
	private Class144(byte[] byte_4, byte[] byte_5)
	{
		this.byte_1 = byte_4;
		this.byte_2 = byte_5;
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x00027330 File Offset: 0x00025530
	private byte[] method_8(byte[] byte_4)
	{
		if (byte_4.Length == 0)
		{
			return new byte[0];
		}
		int num = byte_4.Length % 4;
		int num2 = byte_4.Length / 4;
		byte[] array = new byte[byte_4.Length];
		int num3 = this.byte_1.Length / 4;
		uint num4 = 0U;
		if (num > 0)
		{
			num2++;
		}
		for (int i = 0; i < num2; i++)
		{
			int num5 = i % num3;
			int num6 = i * 4;
			uint num7 = (uint)(num5 * 4);
			uint num8 = (uint)((int)this.byte_1[(int)(num7 + 3U)] << 24 | (int)this.byte_1[(int)(num7 + 2U)] << 16 | (int)this.byte_1[(int)(num7 + 1U)] << 8 | (int)this.byte_1[(int)num7]);
			if (i == num2 - 1 && num > 0)
			{
				uint num9 = 0U;
				uint num10 = 255U;
				int num11 = 0;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num9 <<= 8;
					}
					num9 |= (uint)byte_4[byte_4.Length - (1 + j)];
				}
				num4 += num8;
				num4 += this.method_9(num4);
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num10 <<= 8;
						num11 += 8;
					}
					array[num6 + k] = 0;
				}
			}
			else
			{
				num7 = (uint)num6;
				uint num9 = (uint)((int)byte_4[(int)(num7 + 3U)] << 24 | (int)byte_4[(int)(num7 + 2U)] << 16 | (int)byte_4[(int)(num7 + 1U)] << 8 | (int)byte_4[(int)num7]);
				num4 += num8;
				num4 += this.method_9(num4);
				uint num12 = num4 ^ num9;
				array[num6] = (byte)(num12 & 255U);
				array[num6 + 1] = (byte)((num12 & 65280U) >> 8);
				array[num6 + 2] = (byte)((num12 & 16711680U) >> 16);
				array[num6 + 3] = (byte)((num12 & 4278190080U) >> 24);
			}
		}
		return array;
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x000274E4 File Offset: 0x000256E4
	private uint method_9(uint uint_1)
	{
		uint num = uint_1 ^ uint_1 << 3;
		num += 3302414041U;
		num ^= num << 11;
		num += 2323220752U;
		num ^= num >> 27;
		num += 1568112929U;
		return 319228767U - num;
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x00027528 File Offset: 0x00025728
	internal static string smethod_23(string string_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x00003A8E File Offset: 0x00001C8E
	private static byte[] smethod_24(byte[] byte_4)
	{
		return new Class144(new byte[]
		{
			123,
			5,
			74,
			12,
			244,
			156,
			221,
			154,
			121,
			221,
			183,
			41,
			121,
			65,
			9,
			43,
			67,
			81,
			23,
			43,
			74,
			63,
			64,
			23,
			95,
			185,
			226,
			244,
			45,
			194,
			211,
			43
		}, new byte[]
		{
			117,
			254,
			41,
			121,
			65,
			52,
			9,
			43,
			221,
			154,
			12,
			54,
			68,
			241,
			68,
			66
		}).method_8(byte_4);
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x00027558 File Offset: 0x00025758
	private byte[] method_10()
	{
		return null;
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x00027558 File Offset: 0x00025758
	private byte[] method_11()
	{
		return null;
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x00003ABF File Offset: 0x00001CBF
	internal static bool xZHqD4xYDoQXLL1ERGo()
	{
		return null == null;
	}

	// Token: 0x040004BB RID: 1211
	private static Assembly assembly_0;

	// Token: 0x040004BC RID: 1212
	private static byte[] byte_0;

	// Token: 0x040004BD RID: 1213
	private byte[] byte_1;

	// Token: 0x040004BE RID: 1214
	private byte[] byte_2;

	// Token: 0x040004BF RID: 1215
	private static int int_0;

	// Token: 0x040004C0 RID: 1216
	private static uint[] uint_0 = new uint[]
	{
		3614090360U,
		3905402710U,
		606105819U,
		3250441966U,
		4118548399U,
		1200080426U,
		2821735955U,
		4249261313U,
		1770035416U,
		2336552879U,
		4294925233U,
		2304563134U,
		1804603682U,
		4254626195U,
		2792965006U,
		1236535329U,
		4129170786U,
		3225465664U,
		643717713U,
		3921069994U,
		3593408605U,
		38016083U,
		3634488961U,
		3889429448U,
		568446438U,
		3275163606U,
		4107603335U,
		1163531501U,
		2850285829U,
		4243563512U,
		1735328473U,
		2368359562U,
		4294588738U,
		2272392833U,
		1839030562U,
		4259657740U,
		2763975236U,
		1272893353U,
		4139469664U,
		3200236656U,
		681279174U,
		3936430074U,
		3572445317U,
		76029189U,
		3654602809U,
		3873151461U,
		530742520U,
		3299628645U,
		4096336452U,
		1126891415U,
		2878612391U,
		4237533241U,
		1700485571U,
		2399980690U,
		4293915773U,
		2240044497U,
		1873313359U,
		4264355552U,
		2734768916U,
		1309151649U,
		4149444226U,
		3174756917U,
		718787259U,
		3951481745U
	};

	// Token: 0x040004C1 RID: 1217
	private static object object_0;

	// Token: 0x040004C2 RID: 1218
	private static bool bool_0 = false;

	// Token: 0x040004C3 RID: 1219
	private static object object_1;

	// Token: 0x040004C4 RID: 1220
	private static RSACryptoServiceProvider rsacryptoServiceProvider_0;

	// Token: 0x040004C5 RID: 1221
	private static Dictionary<int, int> dictionary_0;

	// Token: 0x040004C6 RID: 1222
	private static List<int> list_0;

	// Token: 0x040004C7 RID: 1223
	private static byte[] byte_3;

	// Token: 0x040004C8 RID: 1224
	private static bool bool_1 = false;

	// Token: 0x040004C9 RID: 1225
	private static List<string> list_1;

	// Token: 0x02000172 RID: 370
	internal class Class145
	{
		// Token: 0x060007BB RID: 1979 RVA: 0x00003AC5 File Offset: 0x00001CC5
		public Class145(Stream stream_0)
		{
			this.binaryReader_0 = new BinaryReader(stream_0);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00003AD9 File Offset: 0x00001CD9
		internal Stream method_0()
		{
			return this.binaryReader_0.BaseStream;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00003AE6 File Offset: 0x00001CE6
		internal byte[] method_1(int int_0)
		{
			return this.binaryReader_0.ReadBytes(int_0);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00003AF4 File Offset: 0x00001CF4
		internal int method_2(byte[] byte_0, int int_0, int int_1)
		{
			return this.binaryReader_0.Read(byte_0, int_0, int_1);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00003B04 File Offset: 0x00001D04
		internal int method_3()
		{
			return this.binaryReader_0.ReadInt32();
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00003B11 File Offset: 0x00001D11
		internal void method_4()
		{
			this.binaryReader_0.Close();
		}

		// Token: 0x040004CA RID: 1226
		private BinaryReader binaryReader_0;
	}

	// Token: 0x02000173 RID: 371
	// (Invoke) Token: 0x060007C2 RID: 1986
	private delegate void Delegate39(object o);

	// Token: 0x02000174 RID: 372
	internal class Class146
	{
		// Token: 0x060007C5 RID: 1989 RVA: 0x00027568 File Offset: 0x00025768
		internal static string smethod_0(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] key = new byte[]
			{
				82,
				102,
				104,
				110,
				32,
				77,
				24,
				34,
				118,
				181,
				51,
				17,
				18,
				51,
				12,
				109,
				10,
				32,
				77,
				24,
				34,
				158,
				161,
				41,
				97,
				28,
				118,
				181,
				5,
				25,
				1,
				88
			};
			byte[] iv = Class144.smethod_6(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Class144.smethod_12();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iv;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}
}
