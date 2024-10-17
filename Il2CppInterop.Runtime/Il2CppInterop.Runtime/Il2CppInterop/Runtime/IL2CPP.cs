using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppInterop.Runtime.Injection;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime
{
	// Token: 0x02000009 RID: 9
	public static class IL2CPP
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x000059DC File Offset: 0x00003BDC
		unsafe static IL2CPP()
		{
			int num = 10;
			for (;;)
			{
				int num2 = num;
				IntPtr intPtr;
				IntPtr intPtr2;
				string text;
				string key;
				for (;;)
				{
					uint num3;
					uint num4;
					IntPtr* ptr;
					uint num5;
					int num6;
					switch (num2)
					{
					case 0:
						goto IL_188;
					case 1:
						if (IL2CPP.il2cpp_class_get_declaring_type(intPtr) == IntPtr.Zero)
						{
							num2 = 5;
							continue;
						}
						goto IL_163;
					case 2:
						goto IL_244;
					case 3:
						nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
						num2 = 7;
						continue;
					case 4:
						goto IL_163;
					case 5:
						IL2CPP.FallbackClasses.Add(new ValueTuple<IntPtr, string>(intPtr2, text), intPtr);
						num2 = 4;
						continue;
					case 6:
						goto IL_1B5;
					case 7:
						IL2CPP.ImageMap = new Dictionary<string, IntPtr>();
						num2 = 14;
						continue;
					case 8:
						num3 = IL2CPP.il2cpp_image_get_class_count(intPtr2);
						num2 = 15;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_18558c8f0d4f4774910664df1c51bd49 != 0)
						{
							num2 = 15;
							continue;
						}
						continue;
					case 9:
						IL2CPP.tHNpC5tLrDcNKb4KcoY();
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6926da1cf80047d3a6f0516668d22380 != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 10:
						IL2CPP.PasESet6atUQ8sYS3Uv();
						num2 = 8;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f72daac7e98440569eaab57fbb9f7bf2 == 0)
						{
							num2 = 9;
							continue;
						}
						continue;
					case 11:
						goto IL_110;
					case 12:
						break;
					case 13:
					{
						IntPtr intPtr3 = IL2CPP.il2cpp_domain_get();
						if (intPtr3 == IntPtr.Zero)
						{
							goto Block_16;
						}
						num4 = 0U;
						ptr = IL2CPP.il2cpp_domain_get_assemblies(intPtr3, ref num4);
						num2 = 21;
						continue;
					}
					case 14:
						goto IL_80;
					case 15:
						num5 = 0U;
						num2 = 23;
						continue;
					case 16:
						goto IL_1D1;
					case 17:
						return;
					case 18:
						goto IL_110;
					case 19:
						if (!IL2CPP.XPCcVutkSPqXDIJfwX3(text))
						{
							goto IL_163;
						}
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_46ba390073ec4df6883860abf17dbf6f != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 20:
						goto IL_284;
					case 21:
						num6 = 0;
						num2 = 22;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_48b9993e573d4d08a64ac27c515a32b9 == 0)
						{
							num2 = 10;
							continue;
						}
						continue;
					case 22:
						goto IL_1D1;
					case 23:
						break;
					case 24:
						num6++;
						num2 = 16;
						continue;
					default:
						goto IL_188;
					}
					if (num5 < num3)
					{
						goto IL_284;
					}
					num2 = 24;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_75b92ac812f348208c578c3de71e2d57 != 0)
					{
						num2 = 17;
						continue;
					}
					continue;
					IL_110:
					intPtr2 = IL2CPP.il2cpp_assembly_get_image(ptr[(IntPtr)num6 * (IntPtr)sizeof(IntPtr) / (IntPtr)sizeof(IntPtr)]);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_61a3825996b24609815f6b482bf680d9 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_163:
					num5 += 1U;
					num2 = 5;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_570d4e075bf443fcbaca8db32e007291 == 0)
					{
						num2 = 12;
						continue;
					}
					continue;
					IL_188:
					key = IL2CPP.neGOw3tRVLwgZpG82V7(IL2CPP.il2cpp_image_get_name(intPtr2));
					num2 = 2;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d01f42186cf2421f90d71301ed147eb1 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_1D1:
					if ((long)num6 < (long)((ulong)num4))
					{
						num2 = 18;
						continue;
					}
					return;
					IL_284:
					intPtr = IL2CPP.il2cpp_image_get_class(intPtr2, num5);
					num2 = 6;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ddf0bbff3ec54ad39c6b2ba58dc80058 == 0)
					{
						num2 = 0;
					}
				}
				IL_80:
				IL2CPP.FallbackClasses = new Dictionary<ValueTuple<IntPtr, string>, IntPtr>();
				num = 13;
				continue;
				IL_1B5:
				text = MarshalExtend.PtrToString(IL2CPP.il2cpp_class_get_name(intPtr));
				num = 19;
				continue;
				IL_244:
				IL2CPP.ImageMap[key] = intPtr2;
				num = 8;
			}
			return;
			Block_16:
			throw new NullReferenceException(IL2CPP.AD1eLwt7XYNSpmuoN2R(-1210334493 >> 2 ^ -2110613027 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_40875ab50e1c43f7bf4d96946e4523cb));
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00005D84 File Offset: 0x00003F84
		internal static IntPtr GetIl2CppImage(object name)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (!IL2CPP.ImageMap.ContainsKey(name))
					{
						goto IL_5F;
					}
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_afe904a262fb47328a49943b4b34b494 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return IL2CPP.ImageMap[name];
			IL_5F:
			return IntPtr.Zero;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00005DF8 File Offset: 0x00003FF8
		internal static IntPtr[] GetIl2CppImages()
		{
			return IL2CPP.ImageMap.Values.ToArray<IntPtr>();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005E0C File Offset: 0x0000400C
		internal static bool IsObfuscated(this object str)
		{
			int num = 8;
			for (;;)
			{
				int num2 = num;
				char c;
				int num3;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_135;
					case 1:
						if (c == '>')
						{
							goto IL_1E6;
						}
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_483eecf3691e4ef2b23b2d4cb2ca3d52 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 2:
						goto IL_BD;
					case 3:
						return true;
					case 4:
						if (c == '<')
						{
							goto IL_1E6;
						}
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 5:
						break;
					case 6:
						break;
					case 7:
						num3 = 0;
						num2 = 18;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3ffead0113044f06b294bee6bd5e7a44 == 0)
						{
							num2 = 18;
							continue;
						}
						continue;
					case 8:
						num2 = 7;
						continue;
					case 9:
						return false;
					case 10:
						goto IL_170;
					case 11:
						if (c <= 'Z')
						{
							num2 = 15;
							continue;
						}
						goto IL_1BC;
					case 12:
						goto IL_1BC;
					case 13:
						goto IL_D4;
					case 14:
						if (c == '.')
						{
							goto IL_1E6;
						}
						num2 = 4;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f7e83c7c87bd4de9b4cb2b7f339254ad == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 15:
						goto IL_8E;
					case 16:
						if (cLhl8b9aY175EjB6MKQ.i2IAUFsOOC(c, cLhl8b9aY175EjB6MKQ.e2o9CeIeqw))
						{
							goto IL_1E6;
						}
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_667bd9633593433784ebdd2b3fdc8daf == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 17:
						goto IL_18A;
					case 18:
						goto IL_18A;
					case 19:
						goto IL_170;
					default:
						goto IL_135;
					}
					if (c >= 'A')
					{
						num2 = 11;
						continue;
					}
					goto IL_1BC;
					IL_135:
					if (c != '`')
					{
						num2 = 14;
						continue;
					}
					goto IL_1E6;
					IL_170:
					c = IL2CPP.SQ9ZGrtJQDD7dhevb5J(str, num3, A5IXfW9GsGA59SDnkr0.aiB9Y7vFdh);
					num2 = 16;
					continue;
					IL_18A:
					if (num3 >= JmmWop9taD6h4B6BjCV.i2IAUFsOOC(str, JmmWop9taD6h4B6BjCV.CJd9xWFsl8))
					{
						return false;
					}
					num2 = 18;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6926da1cf80047d3a6f0516668d22380 != 0)
					{
						num2 = 19;
						continue;
					}
					continue;
					IL_1BC:
					if (c == '_')
					{
						goto IL_1E6;
					}
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6104a350572547c0a789887568cca07c != 0)
					{
						num2 = 0;
					}
				}
				IL_BD:
				if (c < 'a')
				{
					num = 6;
					continue;
				}
				IL_D4:
				if (c > 'z')
				{
					num = 5;
					continue;
				}
				IL_1E6:
				num3++;
				num = 17;
				continue;
				IL_8E:
				goto IL_1E6;
			}
			return true;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000060B4 File Offset: 0x000042B4
		public static IntPtr TryGetDeclaringType(IntPtr Prt, out IntPtr DeclaringType)
		{
			int num = 1;
			int num2 = num;
			IntPtr result;
			for (;;)
			{
				switch (num2)
				{
				default:
					return result;
				case 1:
					result = (DeclaringType = IL2CPP.il2cpp_class_get_declaring_type(Prt));
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5afe19cf44424af2ad9aea85585a9cc2 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			return result;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00006114 File Offset: 0x00004314
		public static IntPtr GetIl2CppClass(string assemblyName, string namespaze, string className)
		{
			int num = 11;
			int num2 = num;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			IntPtr intPtr2;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, namespaze, FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
					num2 = 5;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2f48f5515514b5a9a5feed6dc9a8dce == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					goto IL_1F5;
				case 3:
					goto IL_1BC;
				case 4:
					goto IL_28B;
				case 5:
					QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, IL2CPP.AD1eLwt7XYNSpmuoN2R(2082337970 - -1918242524 ^ -1995426014 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ddf0bbff3ec54ad39c6b2ba58dc80058), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
					num2 = 7;
					continue;
				case 6:
				{
					IntPtr intPtr;
					if (IL2CPP.FallbackClasses.TryGetValue(new ValueTuple<IntPtr, string>(intPtr, className), out intPtr2))
					{
						num2 = 2;
						continue;
					}
					goto IL_28B;
				}
				case 7:
					FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, className, FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
					num2 = 3;
					continue;
				case 8:
					if (intPtr2 == IntPtr.Zero)
					{
						num2 = 6;
						continue;
					}
					return intPtr2;
				case 9:
					QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1428742484 ^ -363849663 ^ -488118855 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8155e7a9a9bd4894b741e1951a0eace6), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
					num2 = 13;
					continue;
				case 10:
				{
					IntPtr intPtr;
					intPtr2 = IL2CPP.il2cpp_class_from_name(intPtr, namespaze, className);
					num2 = 8;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f7e83c7c87bd4de9b4cb2b7f339254ad == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				case 11:
				{
					IntPtr intPtr;
					if (IL2CPP.ImageMap.TryGetValue(assemblyName, out intPtr))
					{
						num2 = 10;
						continue;
					}
					break;
				}
				case 12:
					QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-351482292 - -287444189 ^ -1314322897 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6926da1cf80047d3a6f0516668d22380), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_944294969d634011bf30e3f4f506a31e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 13:
					FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, assemblyName, FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
					num2 = 12;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f65b5965aa9843ea8b738fef02a2c6c9 == 0)
					{
						num2 = 8;
						continue;
					}
					continue;
				}
				break;
				IL_28B:
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 3);
				num2 = 9;
			}
			goto IL_204;
			IL_1BC:
			throw new NullReferenceException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
			IL_1F5:
			return intPtr2;
			IL_204:
			throw new NullReferenceException(IL2CPP.aCDkC4tWLb4rwbrmFX5(IL2CPP.AD1eLwt7XYNSpmuoN2R(941424024 ^ 1545262182 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_636316cf576545aba2f7d326dd7e140b), assemblyName, hIDAYxH6DWLHIthQgC.gSCeTtiku(407102589 ^ 20429767 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_1d16dd38ead14cb191f3b77c23c04ed4), FqZp2N9hs66h9Og8y7V.HHh98mFKgS));
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000063C0 File Offset: 0x000045C0
		public static IntPtr GetIl2CppField(IntPtr clazz, string fieldName)
		{
			int num = 4;
			int num2 = num;
			for (;;)
			{
				IntPtr intPtr;
				IntPtr zero;
				switch (num2)
				{
				case 1:
					goto IL_3F;
				case 2:
					IL_82:
					if (IL2CPP.YnutYVtrwYE9d7IDGRH(IL2CPP.neGOw3tRVLwgZpG82V7(IL2CPP.il2cpp_field_get_name(intPtr)), fieldName, KXbVLO90rvxCycuMdcc.jp69NlJ4ca))
					{
						num2 = 7;
						continue;
					}
					goto IL_3F;
				case 3:
					goto IL_A8;
				case 4:
				{
					if (clazz == IntPtr.Zero)
					{
						num2 = 3;
						continue;
					}
					IntPtr intPtr2 = IL2CPP.il2cpp_class_get_field_from_name(clazz, fieldName);
					num2 = 5;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_78bdbfb54f5c42368a7dbf88905820e8 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				case 5:
				{
					IntPtr intPtr2;
					if (intPtr2 != IntPtr.Zero)
					{
						return intPtr2;
					}
					num2 = 6;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_be54e2986e644667aed0d52d0affe157 == 0)
					{
						num2 = 6;
						continue;
					}
					continue;
				}
				case 6:
					zero = IntPtr.Zero;
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_78bdbfb54f5c42368a7dbf88905820e8 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 7:
					return intPtr;
				}
				break;
				IL_3F:
				if ((intPtr = IL2CPP.il2cpp_class_get_fields(clazz, ref zero)) != IntPtr.Zero)
				{
					goto IL_82;
				}
				num2 = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_37633ff27b934257920d0d03faf0bd54 != 0)
				{
					num2 = 0;
				}
			}
			goto IL_EB;
			IL_A8:
			return IntPtr.Zero;
			IL_EB:
			throw new NullReferenceException(IL2CPP.At7ypPtDGntBLusBnFN(hIDAYxH6DWLHIthQgC.gSCeTtiku(~2031287826 ^ -613278433 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8155e7a9a9bd4894b741e1951a0eace6), fieldName, IL2CPP.AD1eLwt7XYNSpmuoN2R(824460796 ^ 1125759004 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bacedfb8a3cf4671ae3e03ec2f965495), IL2CPP.neGOw3tRVLwgZpG82V7(IL2CPP.il2cpp_class_get_name(clazz)), SjRANlAsQ8j3KPpZL2p.xmXAQkOq8l));
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00006560 File Offset: 0x00004760
		public static IntPtr GetIl2CppMethodByToken(IntPtr clazz, int token)
		{
			int num = 4;
			string text;
			for (;;)
			{
				int num2 = num;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				for (;;)
				{
					IntPtr zero;
					IntPtr intPtr;
					switch (num2)
					{
					case 1:
						text = IL2CPP.neGOw3tRVLwgZpG82V7(IL2CPP.il2cpp_class_get_name(clazz));
						num2 = 2;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9cbee6d56f49422699718938ff979567 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
						num2 = 12;
						continue;
					case 3:
						goto IL_183;
					case 4:
						if (clazz != IntPtr.Zero)
						{
							zero = IntPtr.Zero;
							num2 = 8;
							continue;
						}
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_277c9fa6c1da46a98cc2f13643296b8f == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 5:
						return intPtr;
					case 6:
						defaultInterpolatedStringHandler.AppendFormatted<int>(token);
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9cbee6d56f49422699718938ff979567 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 7:
						FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, text, FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
						num2 = 9;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4ab786fa8604298818cd412db8f702f == 0)
						{
							num2 = 9;
							continue;
						}
						continue;
					case 8:
						goto IL_14F;
					case 9:
						goto IL_232;
					case 10:
						IL_1A6:
						if ((ulong)IL2CPP.il2cpp_method_get_token(intPtr) != (ulong)((long)token))
						{
							goto IL_14F;
						}
						num2 = 5;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6926da1cf80047d3a6f0516668d22380 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 11:
						goto IL_7D;
					case 12:
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, IL2CPP.AD1eLwt7XYNSpmuoN2R(~1015743027 ^ -519304631 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e4c6981dbbef43b3a6de5ad27be6a3b1), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						num2 = 7;
						continue;
					}
					IL2CPP.lQ7KNIto7ksG5YVpoQb(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
					num2 = 11;
					continue;
					IL_14F:
					if ((intPtr = IL2CPP.il2cpp_class_get_methods(clazz, ref zero)) != IntPtr.Zero)
					{
						goto IL_1A6;
					}
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6b13daaa4cb24d0bac4f6e72da052370 == 0)
					{
						num2 = 1;
					}
				}
				IL_232:
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, IL2CPP.AD1eLwt7XYNSpmuoN2R(1963904811 ^ 778287728 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2dd85386720b438b874026b47430e4fa), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				num = 6;
			}
			IL_7D:
			return IL2CPP.tCseJotZesyVEKyYLyu(IL2CPP.aCDkC4tWLb4rwbrmFX5(text, IL2CPP.AD1eLwt7XYNSpmuoN2R(-402682399 ^ -270013231 ^ 529241876 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b3f1fcfa11104bd49a7f00386d38b4f4), Iwwlq19uEXHSO3XQG7C.i2IAUFsOOC(ref token, Iwwlq19uEXHSO3XQG7C.bj09EGqFDr), FqZp2N9hs66h9Og8y7V.HHh98mFKgS));
			IL_183:
			return IL2CPP.tCseJotZesyVEKyYLyu(Iwwlq19uEXHSO3XQG7C.i2IAUFsOOC(ref token, Iwwlq19uEXHSO3XQG7C.bj09EGqFDr));
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000067E8 File Offset: 0x000049E8
		public static IntPtr GetIl2CppMethod(IntPtr clazz, bool isGeneric, string methodName, string returnTypeName, params string[] argTypes)
		{
			int num = 26;
			IntPtr intPtr2;
			string text;
			for (;;)
			{
				int num2 = num;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				int num5;
				int num6;
				int num7;
				string text5;
				for (;;)
				{
					IntPtr intPtr;
					int num3;
					int num4;
					IntPtr zero;
					bool flag;
					string text2;
					string text3;
					string text4;
					int num8;
					switch (num2)
					{
					case 1:
						goto IL_2A1;
					case 2:
						IL2CPP.lQ7KNIto7ksG5YVpoQb(IL2CPP.AD1eLwt7XYNSpmuoN2R(~1794978049 ^ -87643395 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_40875ab50e1c43f7bf4d96946e4523cb));
						num2 = 16;
						continue;
					case 3:
						goto IL_2C0;
					case 4:
						FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, methodName, FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
						num2 = 66;
						continue;
					case 5:
						intPtr = intPtr2;
						num2 = 23;
						continue;
					case 6:
						goto IL_1A3;
					case 7:
						goto IL_830;
					case 8:
						num3 = 0;
						num2 = 11;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40 != 0)
						{
							num2 = 55;
							continue;
						}
						continue;
					case 9:
						num4 = 0;
						num2 = 28;
						continue;
					case 10:
						goto IL_C36;
					case 11:
						goto IL_AF5;
					case 12:
						goto IL_A81;
					case 13:
						num5++;
						num2 = 6;
						continue;
					case 14:
						goto IL_CF4;
					case 15:
						goto IL_2C0;
					case 16:
						Logger.LogDebug(IL2CPP.hYEUhEtwh8wlrNVyI5Q(IL2CPP.AD1eLwt7XYNSpmuoN2R(996372030 ^ 942978071 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9a3e85e731764e36a5b07f4e692becd8), MarshalExtend.PtrToString(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_return_type(intPtr2))), z4S0e1U05BsRVVK2fNl.aarUNWns9V));
						num2 = 68;
						continue;
					case 17:
						goto IL_1A3;
					case 18:
						goto IL_AF5;
					case 19:
						FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, text, FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
						num2 = 12;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_39f2b5d6802b4ad087933b982faeb79d == 0)
						{
							num2 = 48;
							continue;
						}
						continue;
					case 20:
						goto IL_929;
					case 21:
						zero = IntPtr.Zero;
						num2 = 63;
						continue;
					case 22:
						if (!IL2CPP.bW6gxHtd1rZ2qOlOF5O(IL2CPP.neGOw3tRVLwgZpG82V7(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_return_type(intPtr2))), returnTypeName, O8vLYPqbYWoU9KsgoZ5.uy0qf0LujG))
						{
							goto IL_929;
						}
						num2 = 35;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f65b5965aa9843ea8b738fef02a2c6c9 == 0)
						{
							num2 = 19;
							continue;
						}
						continue;
					case 23:
						flag = false;
						num2 = 9;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5afe19cf44424af2ad9aea85585a9cc2 != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 24:
						goto IL_74E;
					case 25:
						goto IL_861;
					case 26:
						if (clazz == IntPtr.Zero)
						{
							num2 = 25;
							continue;
						}
						returnTypeName = IL2CPP.jcG9XetfJPHnNJ6F7sx(e61WPb9RvMZQJWDgbH9.i2IAUFsOOC(My0BUA9Ld5K5NOXfgTl.i2IAUFsOOC(returnTypeName, IL2CPP.AD1eLwt7XYNSpmuoN2R(-923761311 ^ -1160939519 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bacedfb8a3cf4671ae3e03ec2f965495), "", My0BUA9Ld5K5NOXfgTl.VdA97RyUj9), '/', '.', e61WPb9RvMZQJWDgbH9.IVw9kd82Yg), '+', '.', e61WPb9RvMZQJWDgbH9.IVw9kd82Yg);
						num2 = 34;
						continue;
					case 27:
						num6 = 0;
						num2 = 21;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5f6b46e73a464a41b29ca79bf0f3b8f9 != 0)
						{
							num2 = 52;
							continue;
						}
						continue;
					case 28:
						goto IL_B41;
					case 29:
						Logger.LogDebug(SjRANlAsQ8j3KPpZL2p.i2IAUFsOOC(IL2CPP.AD1eLwt7XYNSpmuoN2R(941424024 ^ 1244979466 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9f56599a6a304695b6cfc284bd7d7c9a), IL2CPP.neGOw3tRVLwgZpG82V7(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_return_type(intPtr))), IL2CPP.AD1eLwt7XYNSpmuoN2R(~1887414127 ^ -1781977906 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a8737fecb12449d7ad23f5080d76d2f8), returnTypeName, SjRANlAsQ8j3KPpZL2p.xmXAQkOq8l));
						num2 = 44;
						continue;
					case 30:
						goto IL_5AD;
					case 31:
						zero = IntPtr.Zero;
						num2 = 47;
						continue;
					case 32:
						Logger.LogDebug(IL2CPP.At7ypPtDGntBLusBnFN(IL2CPP.AD1eLwt7XYNSpmuoN2R(~-1950393929 ^ 782591032 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d691a76a9c4746c9a1a67e34c67ca64b), text2, IL2CPP.AD1eLwt7XYNSpmuoN2R(-654236927 - -719369916 ^ 1359844391 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_dbbda98ba6574101bc623ad559f7b5a3), argTypes[num6], SjRANlAsQ8j3KPpZL2p.xmXAQkOq8l));
						num2 = 65;
						continue;
					case 33:
						FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, text, FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
						num2 = 64;
						continue;
					case 34:
						goto IL_D8B;
					case 35:
						goto IL_2A1;
					case 36:
						num2 = 60;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5d181dabf1ed42eca63023d24d927754 == 0)
						{
							num2 = 22;
							continue;
						}
						continue;
					case 37:
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, IL2CPP.AD1eLwt7XYNSpmuoN2R(1742737878 ^ 1938165311 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ea3a0368554c4e6093e0b0561ffd5cef), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						num2 = 33;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_89e7beae9a774fb691cacbb26b1d9330 != 0)
						{
							num2 = 18;
							continue;
						}
						continue;
					case 38:
						goto IL_B41;
					case 39:
						goto IL_9B5;
					case 40:
						goto IL_C17;
					case 41:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(68, 2);
						num2 = 9;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_667bd9633593433784ebdd2b3fdc8daf == 0)
						{
							num2 = 37;
							continue;
						}
						continue;
					case 42:
						argTypes[num5] = e61WPb9RvMZQJWDgbH9.i2IAUFsOOC(IL2CPP.jcG9XetfJPHnNJ6F7sx(IL2CPP.yv2p52tPsEHv740qRjy(text3, IL2CPP.AD1eLwt7XYNSpmuoN2R(~-285258927 ^ 2067822745 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_944294969d634011bf30e3f4f506a31e), "", My0BUA9Ld5K5NOXfgTl.VdA97RyUj9), '/', '.', e61WPb9RvMZQJWDgbH9.IVw9kd82Yg), '+', '.', e61WPb9RvMZQJWDgbH9.IVw9kd82Yg);
						num2 = 13;
						continue;
					case 43:
						flag = true;
						num2 = 29;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_282cf292112a4cf49ec1b8b2e2e7602a != 0)
						{
							num2 = 71;
							continue;
						}
						continue;
					case 44:
						IL2CPP.lQ7KNIto7ksG5YVpoQb(IL2CPP.AD1eLwt7XYNSpmuoN2R(-866075606 ^ -1391439081 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_eea945ea6be345c0b18511ac11610b35));
						num2 = 26;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f0601de1a406461b9e99711ec5418371 == 0)
						{
							num2 = 27;
							continue;
						}
						continue;
					case 45:
						goto IL_830;
					case 46:
						goto IL_95B;
					case 47:
						goto IL_AD6;
					case 48:
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1170670504 ^ 1198437711 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5f6b46e73a464a41b29ca79bf0f3b8f9), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						num2 = 4;
						continue;
					case 49:
						goto IL_7A3;
					case 50:
						goto IL_C4A;
					case 51:
						goto IL_34B;
					case 52:
						goto IL_74E;
					case 53:
						IL2CPP.lQ7KNIto7ksG5YVpoQb(IL2CPP.hYEUhEtwh8wlrNVyI5Q(IL2CPP.AD1eLwt7XYNSpmuoN2R(-479592382 ^ -2079442256 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ddf0bbff3ec54ad39c6b2ba58dc80058), text4, z4S0e1U05BsRVVK2fNl.aarUNWns9V));
						num2 = 10;
						continue;
					case 54:
						goto IL_7CB;
					case 55:
						intPtr = IntPtr.Zero;
						num2 = 21;
						continue;
					case 56:
						return intPtr;
					case 57:
						IL_BD1:
						if (O8vLYPqbYWoU9KsgoZ5.i2IAUFsOOC(IL2CPP.neGOw3tRVLwgZpG82V7(IL2CPP.il2cpp_method_get_name(intPtr2)), methodName, O8vLYPqbYWoU9KsgoZ5.uy0qf0LujG))
						{
							num2 = 76;
							continue;
						}
						goto IL_7A3;
					case 58:
						if ((ulong)IL2CPP.il2cpp_method_get_param_count(intPtr2) == (ulong)((long)argTypes.Length))
						{
							num2 = 70;
							continue;
						}
						goto IL_2A1;
					case 59:
						return intPtr2;
					case 60:
						num7 = 0;
						num2 = 11;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_db312e48eee84539b805fee2f73a8cde == 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 61:
						goto IL_B56;
					case 62:
						IL_97A:
						if (IL2CPP.bW6gxHtd1rZ2qOlOF5O(IL2CPP.neGOw3tRVLwgZpG82V7(IL2CPP.il2cpp_method_get_name(intPtr2)), methodName, O8vLYPqbYWoU9KsgoZ5.uy0qf0LujG))
						{
							goto IL_2A1;
						}
						num2 = 53;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5d181dabf1ed42eca63023d24d927754 != 0)
						{
							num2 = 58;
							continue;
						}
						continue;
					case 63:
						goto IL_2A1;
					case 64:
						goto IL_C7E;
					case 65:
						goto IL_70E;
					case 66:
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(~1794978049 ^ -605126744 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f65b5965aa9843ea8b738fef02a2c6c9), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						num2 = 74;
						continue;
					case 67:
						FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, methodName, FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
						num2 = 72;
						continue;
					case 68:
						num8 = 0;
						num2 = 3;
						continue;
					case 69:
						num8++;
						num2 = 15;
						continue;
					case 70:
						if (IL2CPP.il2cpp_method_is_generic(intPtr2) == isGeneric)
						{
							num2 = 22;
							continue;
						}
						goto IL_2A1;
					case 71:
						goto IL_CF4;
					case 72:
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, IL2CPP.AD1eLwt7XYNSpmuoN2R(733481413 - 954737972 ^ -505042763 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2f48f5515514b5a9a5feed6dc9a8dce), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						num2 = 23;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_18558c8f0d4f4774910664df1c51bd49 == 0)
						{
							num2 = 40;
							continue;
						}
						continue;
					case 73:
						if (num3 == 1)
						{
							num2 = 41;
							continue;
						}
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 2);
						num2 = 51;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c == 0)
						{
							num2 = 45;
							continue;
						}
						continue;
					case 74:
						IL2CPP.lQ7KNIto7ksG5YVpoQb(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d03e4e4716154375bf56bf596fbd5780 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 75:
						text = IL2CPP.neGOw3tRVLwgZpG82V7(IL2CPP.il2cpp_class_get_name(clazz));
						num2 = 73;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_468d644ed32a4ba3ad77ef2c95e2ad4b != 0)
						{
							num2 = 30;
							continue;
						}
						continue;
					case 76:
						goto IL_AD6;
					case 77:
						goto IL_587;
					case 78:
						return intPtr2;
					case 79:
						goto IL_C4A;
					}
					IL2CPP.lQ7KNIto7ksG5YVpoQb(IL2CPP.hYEUhEtwh8wlrNVyI5Q(IL2CPP.AD1eLwt7XYNSpmuoN2R(183698442 ^ 492893102 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b3f1fcfa11104bd49a7f00386d38b4f4), returnTypeName, z4S0e1U05BsRVVK2fNl.aarUNWns9V));
					num2 = 36;
					continue;
					IL_1A3:
					if (num5 < argTypes.Length)
					{
						goto IL_587;
					}
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ea3a0368554c4e6093e0b0561ffd5cef != 0)
					{
						num2 = 8;
						continue;
					}
					continue;
					IL_2A1:
					if ((intPtr2 = IL2CPP.il2cpp_class_get_methods(clazz, ref zero)) == IntPtr.Zero)
					{
						num2 = 75;
						continue;
					}
					goto IL_97A;
					IL_2C0:
					uint num9;
					if ((long)num8 >= (long)((ulong)num9))
					{
						num2 = 59;
						continue;
					}
					goto IL_95B;
					IL_587:
					text3 = argTypes[num5];
					num2 = 14;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d03e4e4716154375bf56bf596fbd5780 == 0)
					{
						num2 = 42;
						continue;
					}
					continue;
					IL_74E:
					if (num6 < argTypes.Length)
					{
						num2 = 50;
						continue;
					}
					return intPtr;
					IL_7A3:
					num9 = IL2CPP.il2cpp_method_get_param_count(intPtr2);
					num2 = 2;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_1d16dd38ead14cb191f3b77c23c04ed4 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_AD6:
					if ((intPtr2 = IL2CPP.il2cpp_class_get_methods(clazz, ref zero)) == IntPtr.Zero)
					{
						num2 = 39;
						continue;
					}
					goto IL_BD1;
					IL_7CB:
					text4 = argTypes[num7];
					num2 = 53;
					continue;
					IL_AF5:
					if (num7 < argTypes.Length)
					{
						goto IL_7CB;
					}
					num2 = 12;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f72daac7e98440569eaab57fbb9f7bf2 != 0)
					{
						num2 = 8;
						continue;
					}
					continue;
					IL_830:
					if (IL2CPP.bW6gxHtd1rZ2qOlOF5O(MarshalExtend.PtrToString(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_param(intPtr2, (uint)num4))), argTypes[num4], O8vLYPqbYWoU9KsgoZ5.uy0qf0LujG))
					{
						num2 = 43;
						continue;
					}
					goto IL_B56;
					IL_929:
					num3++;
					num2 = 5;
					continue;
					IL_95B:
					text5 = MarshalExtend.PtrToString(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_param(intPtr2, (uint)num8)));
					num2 = 30;
					continue;
					IL_B41:
					if (num4 < argTypes.Length)
					{
						num2 = 7;
						continue;
					}
					goto IL_CF4;
					IL_B56:
					num4++;
					num2 = 38;
					continue;
					IL_C4A:
					text2 = IL2CPP.neGOw3tRVLwgZpG82V7(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_param(intPtr, (uint)num6)));
					num2 = 3;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_37633ff27b934257920d0d03faf0bd54 == 0)
					{
						num2 = 32;
						continue;
					}
					continue;
					IL_CF4:
					if (!flag)
					{
						return intPtr2;
					}
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b15bb2810b414d8fba6ffddaf7154f62 != 0)
					{
						num2 = 1;
					}
				}
				IL_34B:
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, IL2CPP.AD1eLwt7XYNSpmuoN2R(996372030 ^ 1911338106 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a36e967c0f044e9ebf523536bdec8e28), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				num = 19;
				continue;
				IL_5AD:
				Logger.LogDebug(IL2CPP.hYEUhEtwh8wlrNVyI5Q(IL2CPP.AD1eLwt7XYNSpmuoN2R(828890082 ^ 1631900468 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_be54e2986e644667aed0d52d0affe157), text5, z4S0e1U05BsRVVK2fNl.aarUNWns9V));
				num = 69;
				continue;
				IL_70E:
				num6++;
				num = 24;
				continue;
				IL_A81:
				IL2CPP.lQ7KNIto7ksG5YVpoQb(hIDAYxH6DWLHIthQgC.gSCeTtiku(1339831552 ^ 536821350 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_be54e2986e644667aed0d52d0affe157));
				num = 31;
				continue;
				IL_C17:
				IL2CPP.lQ7KNIto7ksG5YVpoQb(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
				num = 29;
				continue;
				IL_C36:
				num7++;
				num = 18;
				continue;
				IL_C7E:
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, IL2CPP.AD1eLwt7XYNSpmuoN2R(155266333 ^ 736994367 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				num = 67;
				continue;
				IL_D8B:
				num5 = 0;
				num = 17;
			}
			return intPtr2;
			IL_861:
			return NativeStructUtils.GetMethodInfoForMissingMethod(SjRANlAsQ8j3KPpZL2p.i2IAUFsOOC(methodName, hIDAYxH6DWLHIthQgC.gSCeTtiku(-644802384 ^ -174413605 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_48b9993e573d4d08a64ac27c515a32b9), IL2CPP.ETgriltbugPDLcuxJ4x(IL2CPP.AD1eLwt7XYNSpmuoN2R(-187280351 ^ -2030155285 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9f56599a6a304695b6cfc284bd7d7c9a), argTypes, pcGtWx9cV0AmXQghfas.Hxf96ruww7), IL2CPP.AD1eLwt7XYNSpmuoN2R(-352363743 + -1553115080 ^ -2129382411 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40), SjRANlAsQ8j3KPpZL2p.xmXAQkOq8l));
			IL_9B5:
			return IL2CPP.tCseJotZesyVEKyYLyu(IL2CPP.rqwkBJten0ymxmiklv5(new string[]
			{
				text,
				hIDAYxH6DWLHIthQgC.gSCeTtiku(196923949 ^ 1498455687 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_dbbda98ba6574101bc623ad559f7b5a3),
				methodName,
				IL2CPP.AD1eLwt7XYNSpmuoN2R(1980509011 - -1178533388 ^ -167050549 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_db312e48eee84539b805fee2f73a8cde),
				IL2CPP.ETgriltbugPDLcuxJ4x(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1256025778 ^ -222169483 ^ 673644820 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_40875ab50e1c43f7bf4d96946e4523cb), argTypes, pcGtWx9cV0AmXQghfas.Hxf96ruww7),
				IL2CPP.AD1eLwt7XYNSpmuoN2R(-351482292 - -287444189 ^ -1689591569 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ddf0bbff3ec54ad39c6b2ba58dc80058)
			}, MHUs7j9JBFis0IY18CL.gx49Wi13oq));
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000075B4 File Offset: 0x000057B4
		public static IntPtr GetIl2CppMethod(IntPtr clazz, string methodName, params string[] argTypes)
		{
			int num = 49;
			string text2;
			for (;;)
			{
				int num2 = num;
				int num6;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				IntPtr intPtr2;
				int num8;
				for (;;)
				{
					IntPtr intPtr;
					uint num3;
					int num4;
					int num5;
					string text;
					IntPtr zero;
					int num7;
					bool flag;
					string text3;
					string text4;
					string text5;
					int num9;
					switch (num2)
					{
					case 0:
						goto IL_9BD;
					case 1:
						goto IL_BE7;
					case 2:
						num3 = IL2CPP.il2cpp_method_get_param_count(intPtr);
						num2 = 22;
						continue;
					case 3:
						num4++;
						num2 = 27;
						continue;
					case 4:
						argTypes[num5] = IL2CPP.jcG9XetfJPHnNJ6F7sx(IL2CPP.jcG9XetfJPHnNJ6F7sx(My0BUA9Ld5K5NOXfgTl.i2IAUFsOOC(text, IL2CPP.AD1eLwt7XYNSpmuoN2R(443897056 << 2 ^ 101791069 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_40875ab50e1c43f7bf4d96946e4523cb), "", My0BUA9Ld5K5NOXfgTl.VdA97RyUj9), '/', '.', e61WPb9RvMZQJWDgbH9.IVw9kd82Yg), '+', '.', e61WPb9RvMZQJWDgbH9.IVw9kd82Yg);
						num2 = 29;
						continue;
					case 5:
						if (num6 == 1)
						{
							num2 = 14;
							continue;
						}
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 2);
						num2 = 31;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b15bb2810b414d8fba6ffddaf7154f62 != 0)
						{
							num2 = 70;
							continue;
						}
						continue;
					case 6:
						zero = IntPtr.Zero;
						num2 = 41;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_89e7beae9a774fb691cacbb26b1d9330 != 0)
						{
							num2 = 16;
							continue;
						}
						continue;
					case 7:
						intPtr2 = IntPtr.Zero;
						num2 = 6;
						continue;
					case 8:
						goto IL_52C;
					case 9:
						goto IL_5F7;
					case 10:
						goto IL_995;
					case 11:
						goto IL_A88;
					case 12:
						num7++;
						num2 = 18;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_22d16b8eb84d4725aef9f7a9d2f68925 == 0)
						{
							num2 = 66;
							continue;
						}
						continue;
					case 13:
						goto IL_925;
					case 14:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(68, 2);
						num2 = 51;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b3f1fcfa11104bd49a7f00386d38b4f4 == 0)
						{
							num2 = 14;
							continue;
						}
						continue;
					case 15:
						goto IL_25A;
					case 16:
						num7 = 0;
						num2 = 7;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_db312e48eee84539b805fee2f73a8cde != 0)
						{
							num2 = 31;
							continue;
						}
						continue;
					case 17:
						flag = false;
						num2 = 74;
						continue;
					case 18:
						goto IL_52C;
					case 19:
						FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, text2, FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
						num2 = 65;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40 == 0)
						{
							num2 = 45;
							continue;
						}
						continue;
					case 20:
						break;
					case 21:
						return intPtr2;
					case 22:
						Logger.LogDebug(IL2CPP.AD1eLwt7XYNSpmuoN2R(-660285926 << 2 ^ 1439870388 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4ab786fa8604298818cd412db8f702f));
						num2 = 24;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8447c7a721f541de9426c754e1b08372 == 0)
						{
							num2 = 35;
							continue;
						}
						continue;
					case 23:
						IL2CPP.lQ7KNIto7ksG5YVpoQb(z4S0e1U05BsRVVK2fNl.i2IAUFsOOC(IL2CPP.AD1eLwt7XYNSpmuoN2R(-923761311 ^ -606418853 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2f48f5515514b5a9a5feed6dc9a8dce), text3, z4S0e1U05BsRVVK2fNl.aarUNWns9V));
						num2 = 12;
						continue;
					case 24:
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, IL2CPP.AD1eLwt7XYNSpmuoN2R(--1039077110 ^ 1553981445 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_eea945ea6be345c0b18511ac11610b35), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						num2 = 62;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e4c6981dbbef43b3a6de5ad27be6a3b1 != 0)
						{
							num2 = 62;
							continue;
						}
						continue;
					case 25:
						IL2CPP.lQ7KNIto7ksG5YVpoQb(z4S0e1U05BsRVVK2fNl.i2IAUFsOOC(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1256025778 ^ -222169483 ^ 282474911 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2210d7ca22c24335b32d80ca3ef84b8e), text4, z4S0e1U05BsRVVK2fNl.aarUNWns9V));
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_99cea5f9c4c245c2a5f184ab2e57fafc == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 26:
						intPtr2 = intPtr;
						num2 = 17;
						continue;
					case 27:
						goto IL_995;
					case 28:
						goto IL_59D;
					case 29:
						num5++;
						num2 = 8;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a8737fecb12449d7ad23f5080d76d2f8 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 30:
						IL_227:
						if (IL2CPP.bW6gxHtd1rZ2qOlOF5O(IL2CPP.neGOw3tRVLwgZpG82V7(IL2CPP.il2cpp_method_get_name(intPtr)), methodName, O8vLYPqbYWoU9KsgoZ5.uy0qf0LujG))
						{
							num2 = 68;
							continue;
						}
						goto IL_C88;
					case 31:
						goto IL_3A1;
					case 32:
						goto IL_25A;
					case 33:
						IL2CPP.lQ7KNIto7ksG5YVpoQb(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
						num2 = 45;
						continue;
					case 34:
						FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, methodName, FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
						num2 = 37;
						continue;
					case 35:
						Logger.LogDebug(z4S0e1U05BsRVVK2fNl.i2IAUFsOOC(hIDAYxH6DWLHIthQgC.gSCeTtiku(~632778831 ^ -1630117436 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_282cf292112a4cf49ec1b8b2e2e7602a), MarshalExtend.PtrToString(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_return_type(intPtr))), z4S0e1U05BsRVVK2fNl.aarUNWns9V));
						num2 = 16;
						continue;
					case 36:
						goto IL_29D;
					case 37:
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-170966476 ^ -858013383 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bc244a0192c343599cd1cf83671e02ab), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						num2 = 33;
						continue;
					case 38:
						zero = IntPtr.Zero;
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c2ad52141772446383547acade021f9a != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 39:
						FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, text2, FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
						num2 = 61;
						continue;
					case 40:
						break;
					case 41:
						goto IL_AF0;
					case 42:
						goto IL_B49;
					case 43:
						goto IL_6E5;
					case 44:
						text2 = IL2CPP.neGOw3tRVLwgZpG82V7(IL2CPP.il2cpp_class_get_name(clazz));
						num2 = 5;
						continue;
					case 45:
						num2 = 58;
						continue;
					case 46:
						IL2CPP.lQ7KNIto7ksG5YVpoQb(IL2CPP.AD1eLwt7XYNSpmuoN2R(-978113932 + -1400964511 ^ 688990926 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f7e83c7c87bd4de9b4cb2b7f339254ad));
						num2 = 38;
						continue;
					case 47:
						num8++;
						num2 = 50;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_16defe672aac4a3485dcd78387beb521 != 0)
						{
							num2 = 25;
							continue;
						}
						continue;
					case 48:
						goto IL_3F8;
					case 49:
						if (clazz == IntPtr.Zero)
						{
							num2 = 48;
							continue;
						}
						num5 = 0;
						num2 = 18;
						continue;
					case 50:
						goto IL_148;
					case 51:
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, IL2CPP.AD1eLwt7XYNSpmuoN2R(1484788881 ^ 1540869210 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9a3e85e731764e36a5b07f4e692becd8), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						num2 = 19;
						continue;
					case 52:
						flag = true;
						num2 = 63;
						continue;
					case 53:
						return intPtr;
					case 54:
						goto IL_C88;
					case 55:
						return intPtr;
					case 56:
						goto IL_81F;
					case 57:
						IL_76D:
						if (!IL2CPP.bW6gxHtd1rZ2qOlOF5O(IL2CPP.neGOw3tRVLwgZpG82V7(IL2CPP.il2cpp_method_get_name(intPtr)), methodName, O8vLYPqbYWoU9KsgoZ5.uy0qf0LujG))
						{
							goto Block_19;
						}
						goto IL_BE7;
					case 58:
						num4 = 0;
						num2 = 3;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ce81190098cb44f1b9a77ca4822d7770 == 0)
						{
							num2 = 10;
							continue;
						}
						continue;
					case 59:
						num8 = 0;
						num2 = 6;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_61a3825996b24609815f6b482bf680d9 == 0)
						{
							num2 = 43;
							continue;
						}
						continue;
					case 60:
						goto IL_29D;
					case 61:
						goto IL_B68;
					case 62:
						IL2CPP.lQ7KNIto7ksG5YVpoQb(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c2ad52141772446383547acade021f9a == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 63:
						goto IL_495;
					case 64:
						IL2CPP.lQ7KNIto7ksG5YVpoQb(IL2CPP.At7ypPtDGntBLusBnFN(IL2CPP.AD1eLwt7XYNSpmuoN2R(--423224755 ^ 2101330607 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_636316cf576545aba2f7d326dd7e140b), text5, IL2CPP.AD1eLwt7XYNSpmuoN2R(1140735436 ^ 1295525095 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2b24b0de55344c2b8aaf8116dbc4d16), argTypes[num8], SjRANlAsQ8j3KPpZL2p.xmXAQkOq8l));
						num2 = 47;
						continue;
					case 65:
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(163526699 ^ -306984248 ^ -749927163 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4ab786fa8604298818cd412db8f702f), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						num2 = 69;
						continue;
					case 66:
						goto IL_3A1;
					case 67:
						goto IL_925;
					case 68:
						goto IL_AF0;
					case 69:
						goto IL_A6D;
					case 70:
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, IL2CPP.AD1eLwt7XYNSpmuoN2R(1808198684 ^ 1732617089 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c504ab11ece64b14b01df2d4c88e6e49), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						num2 = 39;
						continue;
					case 71:
						goto IL_51B;
					case 72:
						goto IL_495;
					case 73:
						IL2CPP.lQ7KNIto7ksG5YVpoQb(IL2CPP.AD1eLwt7XYNSpmuoN2R(-198467123 ^ -1362205843 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d691a76a9c4746c9a1a67e34c67ca64b));
						num2 = 59;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b3f1fcfa11104bd49a7f00386d38b4f4 == 0)
						{
							num2 = 43;
							continue;
						}
						continue;
					case 74:
						num9 = 0;
						num2 = 67;
						continue;
					default:
						goto IL_9BD;
					}
					if (IL2CPP.bW6gxHtd1rZ2qOlOF5O(MarshalExtend.PtrToString(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_param(intPtr, (uint)num9))), argTypes[num9], O8vLYPqbYWoU9KsgoZ5.uy0qf0LujG))
					{
						num2 = 52;
						continue;
					}
					goto IL_81F;
					IL_AF0:
					if ((intPtr = IL2CPP.il2cpp_class_get_methods(clazz, ref zero)) != IntPtr.Zero)
					{
						goto IL_227;
					}
					num2 = 44;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_db312e48eee84539b805fee2f73a8cde == 0)
					{
						num2 = 39;
						continue;
					}
					continue;
					IL_C88:
					if ((ulong)IL2CPP.il2cpp_method_get_param_count(intPtr) == (ulong)((long)argTypes.Length))
					{
						num2 = 28;
						continue;
					}
					goto IL_AF0;
					IL_495:
					if (!flag)
					{
						num2 = 55;
						continue;
					}
					goto IL_AF0;
					IL_925:
					if (num9 < argTypes.Length)
					{
						num2 = 20;
						continue;
					}
					goto IL_495;
					IL_25A:
					text5 = IL2CPP.neGOw3tRVLwgZpG82V7(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_param(intPtr2, (uint)num8)));
					num2 = 39;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_906545e343eb409d9eb685fc4a903234 != 0)
					{
						num2 = 64;
						continue;
					}
					continue;
					IL_29D:
					text = argTypes[num5];
					num2 = 4;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c2ad52141772446383547acade021f9a != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
					IL_3A1:
					if ((long)num7 < (long)((ulong)num3))
					{
						goto IL_A88;
					}
					num2 = 53;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d1f9cbcd89d6464f81f56a1119f034c6 != 0)
					{
						num2 = 40;
						continue;
					}
					continue;
					IL_51B:
					text4 = argTypes[num4];
					num2 = 25;
					continue;
					IL_995:
					if (num4 >= argTypes.Length)
					{
						goto Block_27;
					}
					goto IL_51B;
					IL_81F:
					num9++;
					num2 = 3;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ddf0bbff3ec54ad39c6b2ba58dc80058 != 0)
					{
						num2 = 13;
						continue;
					}
					continue;
					IL_9BD:
					Logger.LogDebug(IL2CPP.hYEUhEtwh8wlrNVyI5Q(hIDAYxH6DWLHIthQgC.gSCeTtiku(-813371636 ^ -858573197 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9a3e85e731764e36a5b07f4e692becd8), MarshalExtend.PtrToString(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_return_type(intPtr2))), z4S0e1U05BsRVVK2fNl.aarUNWns9V));
					num2 = 73;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c23fbb8072754781976c5c809c25ef15 != 0)
					{
						num2 = 36;
						continue;
					}
					continue;
					IL_A88:
					text3 = MarshalExtend.PtrToString(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_param(intPtr, (uint)num7)));
					num2 = 12;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_48b9993e573d4d08a64ac27c515a32b9 != 0)
					{
						num2 = 23;
						continue;
					}
					continue;
					IL_B49:
					num6 = 0;
					num2 = 7;
					continue;
					IL_52C:
					if (num5 < argTypes.Length)
					{
						goto Block_15;
					}
					goto IL_B49;
					IL_BE7:
					if ((intPtr = IL2CPP.il2cpp_class_get_methods(clazz, ref zero)) != IntPtr.Zero)
					{
						goto IL_76D;
					}
					num2 = 3;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_282cf292112a4cf49ec1b8b2e2e7602a != 0)
					{
						num2 = 9;
					}
				}
				IL_148:
				if (num8 < argTypes.Length)
				{
					num = 15;
					continue;
				}
				return intPtr2;
				Block_15:
				num = 60;
				continue;
				IL_59D:
				num6++;
				num = 26;
				continue;
				Block_19:
				num = 2;
				continue;
				Block_27:
				num = 46;
				continue;
				IL_A6D:
				FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, methodName, FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
				num = 24;
				continue;
				IL_B68:
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, IL2CPP.AD1eLwt7XYNSpmuoN2R(1887176262 ^ 343548032 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_636316cf576545aba2f7d326dd7e140b), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				num = 34;
				continue;
				IL_6E5:
				goto IL_148;
			}
			IL_3F8:
			return IL2CPP.tCseJotZesyVEKyYLyu(SjRANlAsQ8j3KPpZL2p.i2IAUFsOOC(methodName, IL2CPP.AD1eLwt7XYNSpmuoN2R(-344551199 + 798742277 ^ 40253250 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_1d16dd38ead14cb191f3b77c23c04ed4), IL2CPP.ETgriltbugPDLcuxJ4x(IL2CPP.AD1eLwt7XYNSpmuoN2R(941424024 ^ 920315285 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2b24b0de55344c2b8aaf8116dbc4d16), argTypes, pcGtWx9cV0AmXQghfas.Hxf96ruww7), IL2CPP.AD1eLwt7XYNSpmuoN2R(720537572 - 1446147662 ^ -2076498621 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc), SjRANlAsQ8j3KPpZL2p.xmXAQkOq8l));
			IL_5F7:
			return IL2CPP.tCseJotZesyVEKyYLyu(IL2CPP.rqwkBJten0ymxmiklv5(new string[]
			{
				text2,
				hIDAYxH6DWLHIthQgC.gSCeTtiku(275067185 ^ 840812260 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e4c6981dbbef43b3a6de5ad27be6a3b1),
				methodName,
				IL2CPP.AD1eLwt7XYNSpmuoN2R(-187280351 ^ -525317334 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ea3a0368554c4e6093e0b0561ffd5cef),
				IL2CPP.ETgriltbugPDLcuxJ4x(IL2CPP.AD1eLwt7XYNSpmuoN2R(75745436 >> 5 ^ 6962745 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b15bb2810b414d8fba6ffddaf7154f62), argTypes, pcGtWx9cV0AmXQghfas.Hxf96ruww7),
				hIDAYxH6DWLHIthQgC.gSCeTtiku(-540390967 ^ -593653482 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9a3e85e731764e36a5b07f4e692becd8)
			}, MHUs7j9JBFis0IY18CL.gx49Wi13oq));
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00008288 File Offset: 0x00006488
		public static string Il2CppStringToManaged(IntPtr il2CppString)
		{
			int num = 2;
			int num2 = num;
			int length;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_28;
				case 2:
					if (il2CppString == IntPtr.Zero)
					{
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8155e7a9a9bd4894b741e1951a0eace6 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					else
					{
						length = IL2CPP.il2cpp_string_length(il2CppString);
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c2ad52141772446383547acade021f9a != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				break;
			}
			goto IL_51;
			IL_28:
			return null;
			IL_51:
			return new string(IL2CPP.il2cpp_string_chars(il2CppString), 0, length);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00008320 File Offset: 0x00006520
		public unsafe static IntPtr ManagedStringToIl2Cpp(string str)
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					fixed (char* ptr = eQQ7169r4bK83ANL64x.i2IAUFsOOC(str, eQQ7169r4bK83ANL64x.wQb9DUh3Kq))
					{
						num2 = 5;
						continue;
					}
				case 2:
					if (str != null)
					{
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				case 3:
					if (str != null)
					{
						num2 = 2;
						continue;
					}
					goto IL_8B;
				case 4:
					goto IL_8B;
				case 5:
					goto IL_C5;
				}
				break;
			}
			char* text = null;
			goto IL_C8;
			IL_8B:
			return IntPtr.Zero;
			IL_C5:
			char* ptr;
			text = ptr;
			IL_C8:
			return IL2CPP.il2cpp_string_new_utf16(text, IL2CPP.S2Wl7Sts5RYRQaIoBD6(str, JmmWop9taD6h4B6BjCV.CJd9xWFsl8));
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00008408 File Offset: 0x00006608
		public static IntPtr Il2CppObjectBaseToPtr(Il2CppObjectBase obj)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_5A;
				case 2:
					if (obj != null)
					{
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6b13daaa4cb24d0bac4f6e72da052370 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				}
				break;
			}
			return IntPtr.Zero;
			IL_5A:
			return obj.Pointer;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00008494 File Offset: 0x00006694
		public static IntPtr Il2CppObjectBaseToPtrNotNull(Il2CppObjectBase obj)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					goto IL_28;
				case 1:
					goto IL_5A;
				case 2:
					if (obj == null)
					{
						goto IL_28;
					}
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_40875ab50e1c43f7bf4d96946e4523cb != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
			IL_28:
			throw new NullReferenceException();
			IL_5A:
			return obj.Pointer;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00008520 File Offset: 0x00006720
		public static IntPtr GetIl2CppNestedType(IntPtr enclosingType, string nestedTypeName)
		{
			int num = 13;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					IntPtr intPtr;
					IntPtr zero;
					switch (num2)
					{
					case 1:
					{
						IL_2DE:
						string text;
						if (KXbVLO90rvxCycuMdcc.i2IAUFsOOC(MarshalExtend.PtrToString(IL2CPP.il2cpp_class_get_name(intPtr)), text, KXbVLO90rvxCycuMdcc.jp69NlJ4ca))
						{
							return intPtr;
						}
						num2 = 5;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					case 2:
						FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, IL2CPP.neGOw3tRVLwgZpG82V7(IL2CPP.il2cpp_class_get_name(enclosingType)), FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
						num2 = 14;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a8737fecb12449d7ad23f5080d76d2f8 != 0)
						{
							num2 = 16;
							continue;
						}
						continue;
					case 3:
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, IL2CPP.AD1eLwt7XYNSpmuoN2R(196923949 ^ 1445184433 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_8155e7a9a9bd4894b741e1951a0eace6), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						num2 = 17;
						continue;
					case 4:
					{
						string text;
						FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, text, FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
						num2 = 18;
						continue;
					}
					case 6:
					{
						string text;
						if (Wp4sPL9ZtF5HfcQMd2v.i2IAUFsOOC(text, IL2CPP.AD1eLwt7XYNSpmuoN2R(-525229696 + 2058506580 ^ 1626811121 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c733963b5aa3462f9be5a2d711359fa7), Wp4sPL9ZtF5HfcQMd2v.LgT9oV4mpa) != -1)
						{
							goto Block_2;
						}
						break;
					}
					case 7:
					{
						int num3;
						string text = IL2CPP.VF9gWMtyPW2dCVdEbYJ(text, num3 + 1, IL2CPP.S2Wl7Sts5RYRQaIoBD6(text, JmmWop9taD6h4B6BjCV.CJd9xWFsl8) - (num3 + 1), aaIVKB9PZFrTDNowlRw.lZk9dfXAEs);
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_468d644ed32a4ba3ad77ef2c95e2ad4b == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					case 8:
						return intPtr;
					case 9:
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, IL2CPP.AD1eLwt7XYNSpmuoN2R(281228140 ^ 277680601 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b15bb2810b414d8fba6ffddaf7154f62), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						num2 = 4;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5f6b46e73a464a41b29ca79bf0f3b8f9 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 10:
						goto IL_179;
					case 11:
						goto IL_250;
					case 12:
						goto IL_131;
					case 13:
						if (enclosingType != IntPtr.Zero)
						{
							zero = IntPtr.Zero;
							num2 = 15;
							continue;
						}
						num2 = 12;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2f48f5515514b5a9a5feed6dc9a8dce == 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 14:
					{
						string text;
						int num3 = IL2CPP.zNlxQmt2DB2jCOSkvw3(text, '/', OSC2DT9buTa3fdEsF0m.dNx9flJIeq);
						num2 = 7;
						continue;
					}
					case 15:
						if (!IL2CPP.il2cpp_class_is_inflated(enclosingType))
						{
							string text = nestedTypeName;
							num2 = 6;
							continue;
						}
						num2 = 3;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2b9d7065e34e71a0069eb107f69f59 == 0)
						{
							num2 = 11;
							continue;
						}
						continue;
					case 16:
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, IL2CPP.AD1eLwt7XYNSpmuoN2R(-446813263 ^ -720149287 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_0e76a731caf34f7495b20ae26aa97571), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						num2 = 10;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c4640bbaac7c4988b56f91d1b6b3f1a9 == 0)
						{
							num2 = 10;
							continue;
						}
						continue;
					case 17:
						FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, nestedTypeName, FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
						num2 = 9;
						continue;
					case 18:
						QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1998617409 << 4 ^ 461771396 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_afe904a262fb47328a49943b4b34b494), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_78bdbfb54f5c42368a7dbf88905820e8 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 19:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
						num2 = 3;
						continue;
					}
					IL_2AA:
					if ((intPtr = IL2CPP.il2cpp_class_get_nested_types(enclosingType, ref zero)) != IntPtr.Zero)
					{
						goto IL_2DE;
					}
					num2 = 19;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bc244a0192c343599cd1cf83671e02ab == 0)
					{
						num2 = 16;
						continue;
					}
					continue;
					goto IL_2AA;
				}
				Block_2:
				num = 14;
			}
			IL_131:
			return IntPtr.Zero;
			IL_179:
			throw new NullReferenceException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
			IL_250:
			return IL2CPP.TfgWSPtQv9fTIEmcXcO(enclosingType, nestedTypeName);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000088F0 File Offset: 0x00006AF0
		public static void ThrowIfNull(object arg)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					if (arg != null)
					{
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fdb0528b1ef843aca29153aec62fa60d == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				}
				break;
			}
			throw new NullReferenceException();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00008974 File Offset: 0x00006B74
		public static T ResolveICall<T>(string signature) where T : Delegate
		{
			IntPtr intPtr = IL2CPP.il2cpp_resolve_icall(signature);
			if (intPtr == IntPtr.Zero)
			{
				return IL2CPP.GenerateDelegateForMissingICall<T>(signature);
			}
			return Marshal.GetDelegateForFunctionPointer<T>(intPtr);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000089A0 File Offset: 0x00006BA0
		private static T GenerateDelegateForMissingICall<T>(object signature) where T : Delegate
		{
			MethodInfo methodInfo = X127Q0UR3CERXOhenKY.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), hIDAYxH6DWLHIthQgC.gSCeTtiku(-1235690808 ^ -602399087 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_944294969d634011bf30e3f4f506a31e), X127Q0UR3CERXOhenKY.Bo6UkBGZYT);
			DynamicMethod dynamicMethod = new DynamicMethod(z4S0e1U05BsRVVK2fNl.i2IAUFsOOC(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1494377555 ^ -1609067166 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c), XbWY87UAp2s3iIUpBiV.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), XbWY87UAp2s3iIUpBiV.tomUUWdyuW), z4S0e1U05BsRVVK2fNl.aarUNWns9V), jPM26DAnQfHunyInIhU.i2IAUFsOOC(methodInfo, jPM26DAnQfHunyInIhU.xcUA3EoFoP), (from it in sLG6EQATwSiLRpKGREk.i2IAUFsOOC(methodInfo, sLG6EQATwSiLRpKGREk.VZpAFVSObI)
			select qc2ECMAKgYlQ7Q4UDSY.i2IAUFsOOC(it, qc2ECMAKgYlQ7Q4UDSY.YttA5ifGGI)).ToArray<Type>(), byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(IL2CPP).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), true);
			ILGenerator ilgenerator = LN74hFUuuPeOAyrLO2m.i2IAUFsOOC(dynamicMethod, LN74hFUuuPeOAyrLO2m.mWbUEkxEGw);
			juWq3eUzrSmJee3Fw6H.i2IAUFsOOC(ilgenerator, OpCodes.Ldstr, FqZp2N9hs66h9Og8y7V.i2IAUFsOOC(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1912890712 ^ -993532503 ^ 777537363 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ddf0bbff3ec54ad39c6b2ba58dc80058), signature, hIDAYxH6DWLHIthQgC.gSCeTtiku(941424024 ^ 1369266930 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_afe904a262fb47328a49943b4b34b494), FqZp2N9hs66h9Og8y7V.HHh98mFKgS), juWq3eUzrSmJee3Fw6H.FKWqH4eps3);
			N3j9MUUOGeO9qTBVBp1.i2IAUFsOOC(ilgenerator, OpCodes.Newobj, b27ekHAlO1XXce9pRo0.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Exception).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), new Type[]
			{
				byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(string).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an)
			}, b27ekHAlO1XXce9pRo0.EtlAV2R4Yl), N3j9MUUOGeO9qTBVBp1.MygUXj5P6N);
			PybwZDULT8j9uRoXf8D.i2IAUFsOOC(ilgenerator, OpCodes.Throw, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
			return (T)((object)GajqGFqGF52ibtnrXfs.i2IAUFsOOC(dynamicMethod, byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), GajqGFqGF52ibtnrXfs.srKqYspB8v));
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00008B4C File Offset: 0x00006D4C
		public unsafe static T PointerToValueGeneric<T>(IntPtr objectPointer, bool isFieldPointer, bool valueTypeWouldBeBoxed)
		{
			if (isFieldPointer)
			{
				if (IL2CPP.il2cpp_class_is_valuetype(Il2CppClassPointerStore<T>.NativeClassPtr))
				{
					objectPointer = IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<T>.NativeClassPtr, objectPointer);
				}
				else
				{
					objectPointer = *objectPointer;
				}
			}
			if (!valueTypeWouldBeBoxed && IL2CPP.il2cpp_class_is_valuetype(Il2CppClassPointerStore<T>.NativeClassPtr))
			{
				objectPointer = IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<T>.NativeClassPtr, objectPointer);
			}
			if (dPsigOUwJdO4bwskNJ5.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(string).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), dPsigOUwJdO4bwskNJ5.hvvUeCiIEf))
			{
				return (T)((object)IL2CPP.Il2CppStringToManaged(objectPointer));
			}
			if (objectPointer == IntPtr.Zero)
			{
				return default(T);
			}
			Il2CppObjectBase obj = new Il2CppObjectBase(objectPointer);
			if (Yrmd8g9wkq9EHP2RruW.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), Yrmd8g9wkq9EHP2RruW.LkX9e9T03c))
			{
				return Il2CppObjectBase.UnboxUnsafe<T>(objectPointer);
			}
			return (T)((object)lSJHkJ9sxpe25iXblNt.i2IAUFsOOC(X127Q0UR3CERXOhenKY.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Il2CppObjectBase).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), hIDAYxH6DWLHIthQgC.gSCeTtiku(--1039077110 ^ 1797422860 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_22a2950bfabc46ffa61eec0d3eacc4c9), X127Q0UR3CERXOhenKY.Bo6UkBGZYT), new Type[]
			{
				byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an)
			}, lSJHkJ9sxpe25iXblNt.eMj9QTvUka).Invoke(obj, new object[0]));
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00008C88 File Offset: 0x00006E88
		public static string RenderTypeName<T>(bool addRefMarker = false)
		{
			return IL2CPP.RenderTypeName(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), addRefMarker);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00008CA0 File Offset: 0x00006EA0
		public static string RenderTypeName(Type t, bool addRefMarker = false)
		{
			int num = 6;
			StringBuilder stringBuilder;
			for (;;)
			{
				int num2 = num;
				Type[] array;
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_275;
					case 1:
						goto IL_FC;
					case 2:
						goto IL_37F;
					case 3:
						goto IL_188;
					case 4:
						if (IL2CPP.tgQ6iZtFbW0brif08cs(t, IL2CPP.fAPKygtTAaFeTSUivsa(typeof(Il2CppStringArray).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), dPsigOUwJdO4bwskNJ5.hvvUeCiIEf))
						{
							goto IL_130;
						}
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_98f1dfe5d9cd4cf9bdc32e0db7fb0ae4 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 5:
						if (IL2CPP.tiqNUMtSYmSu493pTu0(t, vOElIf92k2MIupuZIdH.i6B9yXHN4l))
						{
							goto IL_2F9;
						}
						num2 = 3;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_906545e343eb409d9eb685fc4a903234 != 0)
						{
							num2 = 22;
							continue;
						}
						continue;
					case 6:
						if (addRefMarker)
						{
							goto IL_4A1;
						}
						num2 = 5;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 7:
						goto IL_2F9;
					case 8:
						goto IL_4A1;
					case 9:
						if (!IL2CPP.z0v2J5tVbvMSM67OqJ4(t, UDlAeP9mFIOY9IiyV84.gJM9vVQVwg))
						{
							num2 = 4;
							if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e236d804047744298c2380563ba7eca0 != 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						break;
					case 10:
						IL2CPP.DwNId1tvfr5BWRbWjnJ(stringBuilder, '>', H2StJeUGVkry79EgdEo.je0UY6eoux);
						num2 = 15;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ddf0bbff3ec54ad39c6b2ba58dc80058 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 11:
						stringBuilder = new StringBuilder();
						num2 = 11;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_eea945ea6be345c0b18511ac11610b35 != 0)
						{
							num2 = 21;
							continue;
						}
						continue;
					case 12:
						goto IL_224;
					case 13:
						goto IL_37F;
					case 14:
						num3++;
						num2 = 13;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f7e83c7c87bd4de9b4cb2b7f339254ad != 0)
						{
							num2 = 13;
							continue;
						}
						continue;
					case 15:
						goto IL_3F3;
					case 16:
						goto IL_486;
					case 17:
						goto IL_359;
					case 18:
						break;
					case 19:
						goto IL_130;
					case 20:
						IL2CPP.DwNId1tvfr5BWRbWjnJ(stringBuilder, ',', H2StJeUGVkry79EgdEo.je0UY6eoux);
						num2 = 25;
						continue;
					case 21:
						IL2CPP.QQj1MJtmudC2JERcc6h(stringBuilder, IL2CPP.G5LfMItXWxJipYfSd5Y(Vee0EH9TsQeZv7AssmK.i2IAUFsOOC(t, Vee0EH9TsQeZv7AssmK.vg09FYnI23).FullNameObfuscated()), ryYXxRUq8BsbY0RUmr6.RZIU9CNSIJ);
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2b24b0de55344c2b8aaf8116dbc4d16 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 22:
						if (HUtclRqOvktk8jFJw0c.i2IAUFsOOC(t, HUtclRqOvktk8jFJw0c.zf1qXu2bX0))
						{
							num2 = 3;
							continue;
						}
						if (IL2CPP.dljIS4tlpNq5TBwl7Xt(t, TVBfjI9lsjlW0VbGRtd.iMs9V1KSsZ))
						{
							goto Block_6;
						}
						if (!GZZerOq0lk2GItma8VI.i2IAUFsOOC(t, GZZerOq0lk2GItma8VI.TpPqNScgWN))
						{
							num2 = 9;
							continue;
						}
						goto IL_44B;
					case 23:
						num3 = 0;
						num2 = 2;
						continue;
					case 24:
						goto IL_394;
					case 25:
						goto IL_28E;
					case 26:
						goto IL_44B;
					default:
						goto IL_275;
					}
					if (IL2CPP.ypsMmctOe7wAxNIfCsW(t))
					{
						goto IL_394;
					}
					num2 = 11;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5a8626d471f54eba873ce59c8785d9b9 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_275:
					IL2CPP.DwNId1tvfr5BWRbWjnJ(stringBuilder, '<', H2StJeUGVkry79EgdEo.je0UY6eoux);
					num2 = 16;
					continue;
					IL_28E:
					IL2CPP.QQj1MJtmudC2JERcc6h(stringBuilder, IL2CPP.RenderTypeName(array[num3], false), ryYXxRUq8BsbY0RUmr6.RZIU9CNSIJ);
					num2 = 14;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_636316cf576545aba2f7d326dd7e140b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_359:
					if (num3 == 0)
					{
						goto IL_28E;
					}
					num2 = 20;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bacedfb8a3cf4671ae3e03ec2f965495 == 0)
					{
						num2 = 19;
						continue;
					}
					continue;
					IL_37F:
					if (num3 < array.Length)
					{
						goto IL_359;
					}
					num2 = 10;
				}
				Block_6:
				num = 12;
				continue;
				IL_486:
				array = IL2CPP.Kv5gBJtBWLAhS0N0EuV(t, roQekQ9BcyCRlkwvynt.phH9jdVvrU);
				num = 23;
			}
			IL_FC:
			return IL2CPP.G5LfMItXWxJipYfSd5Y(t.FullNameObfuscated());
			IL_130:
			return IL2CPP.AD1eLwt7XYNSpmuoN2R(-1729570256 ^ 913036641 ^ -591466189 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bacedfb8a3cf4671ae3e03ec2f965495);
			IL_188:
			return IL2CPP.hYEUhEtwh8wlrNVyI5Q(IL2CPP.RenderTypeName(IL2CPP.dj1DD6tgT8K64bWmY7Y(t, U8h2YU9SxVTdCTH73DU.h0m9gM44pd), false), IL2CPP.AD1eLwt7XYNSpmuoN2R(-644802384 ^ -1984818522 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_be54e2986e644667aed0d52d0affe157), z4S0e1U05BsRVVK2fNl.aarUNWns9V);
			IL_224:
			return IL2CPP.hYEUhEtwh8wlrNVyI5Q(IL2CPP.RenderTypeName(IL2CPP.dj1DD6tgT8K64bWmY7Y(t, U8h2YU9SxVTdCTH73DU.h0m9gM44pd), false), IL2CPP.AD1eLwt7XYNSpmuoN2R(1614682224 ^ 1468001406 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4ab786fa8604298818cd412db8f702f), z4S0e1U05BsRVVK2fNl.aarUNWns9V);
			IL_2F9:
			return z4S0e1U05BsRVVK2fNl.i2IAUFsOOC(IL2CPP.RenderTypeName(IL2CPP.dj1DD6tgT8K64bWmY7Y(t, U8h2YU9SxVTdCTH73DU.h0m9gM44pd), false), hIDAYxH6DWLHIthQgC.gSCeTtiku(407102589 ^ 348170400 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c504ab11ece64b14b01df2d4c88e6e49), z4S0e1U05BsRVVK2fNl.aarUNWns9V);
			IL_394:
			return IL2CPP.hYEUhEtwh8wlrNVyI5Q(IL2CPP.RenderTypeName(roQekQ9BcyCRlkwvynt.i2IAUFsOOC(t, roQekQ9BcyCRlkwvynt.phH9jdVvrU)[0], false), IL2CPP.AD1eLwt7XYNSpmuoN2R(1345850071 ^ 1922334949 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc), z4S0e1U05BsRVVK2fNl.aarUNWns9V);
			IL_3F3:
			return IL2CPP.dG9hnWtjj7kVOP52UOC(stringBuilder, QW5rQ4UtSMItWDAsJG4.E5gUxtJVkb);
			IL_44B:
			return el3Dwo9OYrba9URt3tt.i2IAUFsOOC(t, el3Dwo9OYrba9URt3tt.qs29XcBOk2);
			IL_4A1:
			return IL2CPP.hYEUhEtwh8wlrNVyI5Q(IL2CPP.RenderTypeName(t, false), hIDAYxH6DWLHIthQgC.gSCeTtiku(~1887414127 ^ -1551111175 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_48b9993e573d4d08a64ac27c515a32b9), z4S0e1U05BsRVVK2fNl.aarUNWns9V);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000091E0 File Offset: 0x000073E0
		private static string FullNameObfuscated(this Type t)
		{
			int num = 1;
			int num2 = num;
			CustomAttributes.ObfuscatedNameAttribute customAttribute;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					customAttribute = t.GetCustomAttribute<CustomAttributes.ObfuscatedNameAttribute>();
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c32cfeb41f7a43999be3bae16a94ad02 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					goto IL_2C;
				case 3:
					goto IL_40;
				}
				if (customAttribute == null)
				{
					break;
				}
				num2 = 3;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c23fbb8072754781976c5c809c25ef15 != 0)
				{
					num2 = 1;
				}
			}
			IL_2C:
			return IL2CPP.wTVDQHtKfaYa2FM3otx(t, XbWY87UAp2s3iIUpBiV.tomUUWdyuW);
			IL_40:
			return customAttribute.ObfuscatedName;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000092A0 File Offset: 0x000074A0
		private static string TrimIl2CppPrefix(this object s)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					goto IL_28;
				case 1:
					if (!IL2CPP.W2Ua3Qt58XRSwrYot4Z(s, hIDAYxH6DWLHIthQgC.gSCeTtiku(-864128026 ^ -819353577 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9a3e85e731764e36a5b07f4e692becd8), z4BRwT9Ki3wnMXvZB09.EZw95Edmkf))
					{
						return s;
					}
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7b2fff018dbf4cfe8ef41e2d123dc629 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return s;
				}
			}
			IL_28:
			return IL2CPP.dKvsAPt3U8BIa3r9hSu(s, IL2CPP.t1ItoqtnIMIhapvFTY1(IL2CPP.AD1eLwt7XYNSpmuoN2R(-722918268 - 40236485 ^ -758313708 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b15bb2810b414d8fba6ffddaf7154f62), UFa5wp9napnQy9snOJw.zgL93lw2Yw), R7ef7291ooaKjIgIYPN.wAj9M1t1HM);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000937C File Offset: 0x0000757C
		private static bool TypeHasIl2CppArrayBase(this Type type)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return false;
				case 2:
					if (IL2CPP.tgQ6iZtFbW0brif08cs(type, null, dPsigOUwJdO4bwskNJ5.hvvUeCiIEf))
					{
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c2ad52141772446383547acade021f9a != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					else
					{
						if (IL2CPP.Ngwwr3t1DcaJqoRRVQb(type, MlRLUg9pmkDVLenGADv.G6U94Q4cy0))
						{
							num2 = 4;
							continue;
						}
						goto IL_8F;
					}
					break;
				case 3:
					goto IL_8F;
				case 4:
					type = IL2CPP.wPAroNtMIgTpFX791Rj(type, Vee0EH9TsQeZv7AssmK.vg09FYnI23);
					num2 = 3;
					continue;
				}
				break;
				IL_8F:
				if (!IL2CPP.tgQ6iZtFbW0brif08cs(type, IL2CPP.fAPKygtTAaFeTSUivsa(typeof(Il2CppArrayBase<>).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), dPsigOUwJdO4bwskNJ5.hvvUeCiIEf))
				{
					goto IL_7E;
				}
				num2 = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ad2b9d7065e34e71a0069eb107f69f59 == 0)
				{
					num2 = 0;
				}
			}
			return true;
			IL_7E:
			return IL2CPP.ypsMmctOe7wAxNIfCsW(shNswyquVFWBad0nqf7.i2IAUFsOOC(type, shNswyquVFWBad0nqf7.WtLqEc6DLZ));
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000946C File Offset: 0x0000766C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void FieldWriteWbarrierStub(IntPtr obj, IntPtr targetAddress, IntPtr value)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					*targetAddress = value;
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bdb78f8e72c9458b854f92ed163c1f40 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060000D0 RID: 208
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_init(IntPtr domain_name);

		// Token: 0x060000D1 RID: 209
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_init_utf16(IntPtr domain_name);

		// Token: 0x060000D2 RID: 210
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_shutdown();

		// Token: 0x060000D3 RID: 211
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_config_dir(IntPtr config_path);

		// Token: 0x060000D4 RID: 212
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_data_dir(IntPtr data_path);

		// Token: 0x060000D5 RID: 213
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_temp_dir(IntPtr temp_path);

		// Token: 0x060000D6 RID: 214
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_commandline_arguments(int argc, IntPtr argv, IntPtr basedir);

		// Token: 0x060000D7 RID: 215
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_commandline_arguments_utf16(int argc, IntPtr argv, IntPtr basedir);

		// Token: 0x060000D8 RID: 216
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_config_utf16(IntPtr executablePath);

		// Token: 0x060000D9 RID: 217
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_config(IntPtr executablePath);

		// Token: 0x060000DA RID: 218
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_memory_callbacks(IntPtr callbacks);

		// Token: 0x060000DB RID: 219
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_get_corlib();

		// Token: 0x060000DC RID: 220
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_add_internal_call(IntPtr name, IntPtr method);

		// Token: 0x060000DD RID: 221
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_resolve_icall([MarshalAs(UnmanagedType.LPStr)] string name);

		// Token: 0x060000DE RID: 222
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_alloc(uint size);

		// Token: 0x060000DF RID: 223
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_free(IntPtr ptr);

		// Token: 0x060000E0 RID: 224
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_array_class_get(IntPtr element_class, uint rank);

		// Token: 0x060000E1 RID: 225
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_array_length(IntPtr array);

		// Token: 0x060000E2 RID: 226
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_array_get_byte_length(IntPtr array);

		// Token: 0x060000E3 RID: 227
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_array_new(IntPtr elementTypeInfo, ulong length);

		// Token: 0x060000E4 RID: 228
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_array_new_specific(IntPtr arrayTypeInfo, ulong length);

		// Token: 0x060000E5 RID: 229
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_array_new_full(IntPtr array_class, ref ulong lengths, ref ulong lower_bounds);

		// Token: 0x060000E6 RID: 230
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_bounded_array_class_get(IntPtr element_class, uint rank, [MarshalAs(UnmanagedType.I1)] bool bounded);

		// Token: 0x060000E7 RID: 231
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_array_element_size(IntPtr array_class);

		// Token: 0x060000E8 RID: 232
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_assembly_get_image(IntPtr assembly);

		// Token: 0x060000E9 RID: 233
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_enum_basetype(IntPtr klass);

		// Token: 0x060000EA RID: 234
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_generic(IntPtr klass);

		// Token: 0x060000EB RID: 235
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_inflated(IntPtr klass);

		// Token: 0x060000EC RID: 236
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_assignable_from(IntPtr klass, IntPtr oklass);

		// Token: 0x060000ED RID: 237
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_subclass_of(IntPtr klass, IntPtr klassc, [MarshalAs(UnmanagedType.I1)] bool check_interfaces);

		// Token: 0x060000EE RID: 238
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_has_parent(IntPtr klass, IntPtr klassc);

		// Token: 0x060000EF RID: 239
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_from_il2cpp_type(IntPtr type);

		// Token: 0x060000F0 RID: 240
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_from_name(IntPtr image, [MarshalAs(UnmanagedType.LPStr)] string namespaze, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		// Token: 0x060000F1 RID: 241
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_from_system_type(IntPtr type);

		// Token: 0x060000F2 RID: 242
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_element_class(IntPtr klass);

		// Token: 0x060000F3 RID: 243
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_events(IntPtr klass, ref IntPtr iter);

		// Token: 0x060000F4 RID: 244
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_fields(IntPtr klass, ref IntPtr iter);

		// Token: 0x060000F5 RID: 245
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_nested_types(IntPtr klass, ref IntPtr iter);

		// Token: 0x060000F6 RID: 246
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_interfaces(IntPtr klass, ref IntPtr iter);

		// Token: 0x060000F7 RID: 247
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_properties(IntPtr klass, ref IntPtr iter);

		// Token: 0x060000F8 RID: 248
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_property_from_name(IntPtr klass, IntPtr name);

		// Token: 0x060000F9 RID: 249
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_field_from_name(IntPtr klass, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		// Token: 0x060000FA RID: 250
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_methods(IntPtr klass, ref IntPtr iter);

		// Token: 0x060000FB RID: 251
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_method_from_name(IntPtr klass, [MarshalAs(UnmanagedType.LPStr)] string name, int argsCount);

		// Token: 0x060000FC RID: 252
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_name(IntPtr klass);

		// Token: 0x060000FD RID: 253
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_namespace(IntPtr klass);

		// Token: 0x060000FE RID: 254
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_parent(IntPtr klass);

		// Token: 0x060000FF RID: 255
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_declaring_type(IntPtr klass);

		// Token: 0x06000100 RID: 256
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_class_instance_size(IntPtr klass);

		// Token: 0x06000101 RID: 257
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_class_num_fields(IntPtr enumKlass);

		// Token: 0x06000102 RID: 258
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_valuetype(IntPtr klass);

		// Token: 0x06000103 RID: 259
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_class_value_size(IntPtr klass, ref uint align);

		// Token: 0x06000104 RID: 260
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_blittable(IntPtr klass);

		// Token: 0x06000105 RID: 261
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_class_get_flags(IntPtr klass);

		// Token: 0x06000106 RID: 262
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_abstract(IntPtr klass);

		// Token: 0x06000107 RID: 263
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_interface(IntPtr klass);

		// Token: 0x06000108 RID: 264
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_class_array_element_size(IntPtr klass);

		// Token: 0x06000109 RID: 265
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_from_type(IntPtr type);

		// Token: 0x0600010A RID: 266
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_type(IntPtr klass);

		// Token: 0x0600010B RID: 267
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_class_get_type_token(IntPtr klass);

		// Token: 0x0600010C RID: 268
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_has_attribute(IntPtr klass, IntPtr attr_class);

		// Token: 0x0600010D RID: 269
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_has_references(IntPtr klass);

		// Token: 0x0600010E RID: 270
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_enum(IntPtr klass);

		// Token: 0x0600010F RID: 271
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_image(IntPtr klass);

		// Token: 0x06000110 RID: 272
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_assemblyname(IntPtr klass);

		// Token: 0x06000111 RID: 273
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_class_get_rank(IntPtr klass);

		// Token: 0x06000112 RID: 274
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_class_get_bitmap_size(IntPtr klass);

		// Token: 0x06000113 RID: 275
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_class_get_bitmap(IntPtr klass, ref uint bitmap);

		// Token: 0x06000114 RID: 276
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_stats_dump_to_file(IntPtr path);

		// Token: 0x06000115 RID: 277
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_domain_get();

		// Token: 0x06000116 RID: 278
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_domain_assembly_open(IntPtr domain, IntPtr name);

		// Token: 0x06000117 RID: 279
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern IntPtr* il2cpp_domain_get_assemblies(IntPtr domain, ref uint size);

		// Token: 0x06000118 RID: 280
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_exception_from_name_msg(IntPtr image, IntPtr name_space, IntPtr name, IntPtr msg);

		// Token: 0x06000119 RID: 281
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_get_exception_argument_null(IntPtr arg);

		// Token: 0x0600011A RID: 282
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern void il2cpp_format_exception(IntPtr ex, void* message, int message_size);

		// Token: 0x0600011B RID: 283
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern void il2cpp_format_stack_trace(IntPtr ex, void* output, int output_size);

		// Token: 0x0600011C RID: 284
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_unhandled_exception(IntPtr ex);

		// Token: 0x0600011D RID: 285
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_field_get_flags(IntPtr field);

		// Token: 0x0600011E RID: 286
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_field_get_name(IntPtr field);

		// Token: 0x0600011F RID: 287
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_field_get_parent(IntPtr field);

		// Token: 0x06000120 RID: 288
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_field_get_offset(IntPtr field);

		// Token: 0x06000121 RID: 289
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_field_get_type(IntPtr field);

		// Token: 0x06000122 RID: 290
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern void il2cpp_field_get_value(IntPtr obj, IntPtr field, void* value);

		// Token: 0x06000123 RID: 291
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_field_get_value_object(IntPtr field, IntPtr obj);

		// Token: 0x06000124 RID: 292
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_field_has_attribute(IntPtr field, IntPtr attr_class);

		// Token: 0x06000125 RID: 293
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern void il2cpp_field_set_value(IntPtr obj, IntPtr field, void* value);

		// Token: 0x06000126 RID: 294
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern void il2cpp_field_static_get_value(IntPtr field, void* value);

		// Token: 0x06000127 RID: 295
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern void il2cpp_field_static_set_value(IntPtr field, void* value);

		// Token: 0x06000128 RID: 296
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_field_set_value_object(IntPtr instance, IntPtr field, IntPtr value);

		// Token: 0x06000129 RID: 297
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_gc_collect(int maxGenerations);

		// Token: 0x0600012A RID: 298
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_gc_collect_a_little();

		// Token: 0x0600012B RID: 299
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_gc_disable();

		// Token: 0x0600012C RID: 300
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_gc_enable();

		// Token: 0x0600012D RID: 301
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_gc_is_disabled();

		// Token: 0x0600012E RID: 302
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern long il2cpp_gc_get_used_size();

		// Token: 0x0600012F RID: 303
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern long il2cpp_gc_get_heap_size();

		// Token: 0x06000130 RID: 304
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_gc_wbarrier_set_field(IntPtr obj, IntPtr targetAddress, IntPtr gcObj);

		// Token: 0x06000131 RID: 305
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_gchandle_new(IntPtr obj, [MarshalAs(UnmanagedType.I1)] bool pinned);

		// Token: 0x06000132 RID: 306
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_gchandle_new_weakref(IntPtr obj, [MarshalAs(UnmanagedType.I1)] bool track_resurrection);

		// Token: 0x06000133 RID: 307
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_gchandle_get_target(uint gchandle);

		// Token: 0x06000134 RID: 308
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_gchandle_free(uint gchandle);

		// Token: 0x06000135 RID: 309
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_unity_liveness_calculation_begin(IntPtr filter, int max_object_count, IntPtr callback, IntPtr userdata, IntPtr onWorldStarted, IntPtr onWorldStopped);

		// Token: 0x06000136 RID: 310
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_unity_liveness_calculation_end(IntPtr state);

		// Token: 0x06000137 RID: 311
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_unity_liveness_calculation_from_root(IntPtr root, IntPtr state);

		// Token: 0x06000138 RID: 312
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_unity_liveness_calculation_from_statics(IntPtr state);

		// Token: 0x06000139 RID: 313
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_method_get_return_type(IntPtr method);

		// Token: 0x0600013A RID: 314
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_method_get_declaring_type(IntPtr method);

		// Token: 0x0600013B RID: 315
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_method_get_name(IntPtr method);

		// Token: 0x0600013C RID: 316 RVA: 0x000094C0 File Offset: 0x000076C0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr il2cpp_method_get_from_reflection(IntPtr method)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					num2 = 2;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_0e76a731caf34f7495b20ae26aa97571 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					if (IL2CPP.K9jJCqtpxKTTpoTM4D3())
					{
						goto IL_50;
					}
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_3cdc0c80f3644c499e0bcd7810be1cee == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					goto IL_A2;
				case 3:
					goto IL_50;
				}
			}
			IL_50:
			return IL2CPP._il2cpp_method_get_from_reflection(method);
			IL_A2:
			return method.method;
		}

		// Token: 0x0600013D RID: 317
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi, EntryPoint = "il2cpp_method_get_from_reflection")]
		private static extern IntPtr _il2cpp_method_get_from_reflection(IntPtr method);

		// Token: 0x0600013E RID: 318
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_method_get_object(IntPtr method, IntPtr refclass);

		// Token: 0x0600013F RID: 319
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_method_is_generic(IntPtr method);

		// Token: 0x06000140 RID: 320
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_method_is_inflated(IntPtr method);

		// Token: 0x06000141 RID: 321
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_method_is_instance(IntPtr method);

		// Token: 0x06000142 RID: 322
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_method_get_param_count(IntPtr method);

		// Token: 0x06000143 RID: 323
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_method_get_param(IntPtr method, uint index);

		// Token: 0x06000144 RID: 324
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_method_get_class(IntPtr method);

		// Token: 0x06000145 RID: 325
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_method_has_attribute(IntPtr method, IntPtr attr_class);

		// Token: 0x06000146 RID: 326
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_method_get_flags(IntPtr method, ref uint iflags);

		// Token: 0x06000147 RID: 327
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_method_get_token(IntPtr method);

		// Token: 0x06000148 RID: 328
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_method_get_param_name(IntPtr method, uint index);

		// Token: 0x06000149 RID: 329
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_profiler_install(IntPtr prof, IntPtr shutdown_callback);

		// Token: 0x0600014A RID: 330
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_profiler_install_enter_leave(IntPtr enter, IntPtr fleave);

		// Token: 0x0600014B RID: 331
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_profiler_install_allocation(IntPtr callback);

		// Token: 0x0600014C RID: 332
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_profiler_install_gc(IntPtr callback, IntPtr heap_resize_callback);

		// Token: 0x0600014D RID: 333
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_profiler_install_fileio(IntPtr callback);

		// Token: 0x0600014E RID: 334
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_profiler_install_thread(IntPtr start, IntPtr end);

		// Token: 0x0600014F RID: 335
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_property_get_flags(IntPtr prop);

		// Token: 0x06000150 RID: 336
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_property_get_get_method(IntPtr prop);

		// Token: 0x06000151 RID: 337
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_property_get_set_method(IntPtr prop);

		// Token: 0x06000152 RID: 338
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_property_get_name(IntPtr prop);

		// Token: 0x06000153 RID: 339
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_property_get_parent(IntPtr prop);

		// Token: 0x06000154 RID: 340
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_object_get_class(IntPtr obj);

		// Token: 0x06000155 RID: 341
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_object_get_size(IntPtr obj);

		// Token: 0x06000156 RID: 342
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_object_get_virtual_method(IntPtr obj, IntPtr method);

		// Token: 0x06000157 RID: 343
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_object_new(IntPtr klass);

		// Token: 0x06000158 RID: 344
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_object_unbox(IntPtr obj);

		// Token: 0x06000159 RID: 345
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_value_box(IntPtr klass, IntPtr data);

		// Token: 0x0600015A RID: 346
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_monitor_enter(IntPtr obj);

		// Token: 0x0600015B RID: 347
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_monitor_try_enter(IntPtr obj, uint timeout);

		// Token: 0x0600015C RID: 348
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_monitor_exit(IntPtr obj);

		// Token: 0x0600015D RID: 349
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_monitor_pulse(IntPtr obj);

		// Token: 0x0600015E RID: 350
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_monitor_pulse_all(IntPtr obj);

		// Token: 0x0600015F RID: 351
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_monitor_wait(IntPtr obj);

		// Token: 0x06000160 RID: 352
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_monitor_try_wait(IntPtr obj, uint timeout);

		// Token: 0x06000161 RID: 353
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern IntPtr il2cpp_runtime_invoke(IntPtr method, IntPtr obj, void** param, ref IntPtr exc);

		// Token: 0x06000162 RID: 354
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern IntPtr il2cpp_runtime_invoke_convert_args(IntPtr method, IntPtr obj, void** param, int paramCount, ref IntPtr exc);

		// Token: 0x06000163 RID: 355
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_runtime_class_init(IntPtr klass);

		// Token: 0x06000164 RID: 356
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_runtime_object_init(IntPtr obj);

		// Token: 0x06000165 RID: 357
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_runtime_object_init_exception(IntPtr obj, ref IntPtr exc);

		// Token: 0x06000166 RID: 358
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_string_length(IntPtr str);

		// Token: 0x06000167 RID: 359
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern char* il2cpp_string_chars(IntPtr str);

		// Token: 0x06000168 RID: 360
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_string_new(string str);

		// Token: 0x06000169 RID: 361
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_string_new_len(string str, uint length);

		// Token: 0x0600016A RID: 362
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern IntPtr il2cpp_string_new_utf16(char* text, int len);

		// Token: 0x0600016B RID: 363
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_string_new_wrapper(string str);

		// Token: 0x0600016C RID: 364
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_string_intern(string str);

		// Token: 0x0600016D RID: 365
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_string_is_interned(string str);

		// Token: 0x0600016E RID: 366
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_thread_current();

		// Token: 0x0600016F RID: 367
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_thread_attach(IntPtr domain);

		// Token: 0x06000170 RID: 368
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_thread_detach(IntPtr thread);

		// Token: 0x06000171 RID: 369
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern void** il2cpp_thread_get_all_attached_threads(ref uint size);

		// Token: 0x06000172 RID: 370
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_is_vm_thread(IntPtr thread);

		// Token: 0x06000173 RID: 371
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_current_thread_walk_frame_stack(IntPtr func, IntPtr user_data);

		// Token: 0x06000174 RID: 372
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_thread_walk_frame_stack(IntPtr thread, IntPtr func, IntPtr user_data);

		// Token: 0x06000175 RID: 373
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_current_thread_get_top_frame(IntPtr frame);

		// Token: 0x06000176 RID: 374
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_thread_get_top_frame(IntPtr thread, IntPtr frame);

		// Token: 0x06000177 RID: 375
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_current_thread_get_frame_at(int offset, IntPtr frame);

		// Token: 0x06000178 RID: 376
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_thread_get_frame_at(IntPtr thread, int offset, IntPtr frame);

		// Token: 0x06000179 RID: 377
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_current_thread_get_stack_depth();

		// Token: 0x0600017A RID: 378
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_thread_get_stack_depth(IntPtr thread);

		// Token: 0x0600017B RID: 379
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_type_get_object(IntPtr type);

		// Token: 0x0600017C RID: 380
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_type_get_type(IntPtr type);

		// Token: 0x0600017D RID: 381
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_type_get_class_or_element_class(IntPtr type);

		// Token: 0x0600017E RID: 382
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_type_get_name(IntPtr type);

		// Token: 0x0600017F RID: 383
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_type_is_byref(IntPtr type);

		// Token: 0x06000180 RID: 384
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_type_get_attrs(IntPtr type);

		// Token: 0x06000181 RID: 385
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_type_equals(IntPtr type, IntPtr otherType);

		// Token: 0x06000182 RID: 386
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_type_get_assembly_qualified_name(IntPtr type);

		// Token: 0x06000183 RID: 387
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_image_get_assembly(IntPtr image);

		// Token: 0x06000184 RID: 388
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_image_get_name(IntPtr image);

		// Token: 0x06000185 RID: 389
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_image_get_filename(IntPtr image);

		// Token: 0x06000186 RID: 390
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_image_get_entry_point(IntPtr image);

		// Token: 0x06000187 RID: 391
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_image_get_class_count(IntPtr image);

		// Token: 0x06000188 RID: 392
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_image_get_class(IntPtr image, uint index);

		// Token: 0x06000189 RID: 393
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_capture_memory_snapshot();

		// Token: 0x0600018A RID: 394
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_free_captured_memory_snapshot(IntPtr snapshot);

		// Token: 0x0600018B RID: 395
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_find_plugin_callback(IntPtr method);

		// Token: 0x0600018C RID: 396
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_register_log_callback(IntPtr method);

		// Token: 0x0600018D RID: 397
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_debugger_set_agent_options(IntPtr options);

		// Token: 0x0600018E RID: 398
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_is_debugger_attached();

		// Token: 0x0600018F RID: 399
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern void il2cpp_unity_install_unitytls_interface(void* unitytlsInterfaceStruct);

		// Token: 0x06000190 RID: 400
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_custom_attrs_from_class(IntPtr klass);

		// Token: 0x06000191 RID: 401
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_custom_attrs_from_method(IntPtr method);

		// Token: 0x06000192 RID: 402
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_custom_attrs_get_attr(IntPtr ainfo, IntPtr attr_klass);

		// Token: 0x06000193 RID: 403
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_custom_attrs_has_attr(IntPtr ainfo, IntPtr attr_klass);

		// Token: 0x06000194 RID: 404
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_custom_attrs_construct(IntPtr cinfo);

		// Token: 0x06000195 RID: 405
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_custom_attrs_free(IntPtr ainfo);

		// Token: 0x06000196 RID: 406 RVA: 0x00009578 File Offset: 0x00007778
		internal static void PasESet6atUQ8sYS3Uv()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00009580 File Offset: 0x00007780
		internal static void tHNpC5tLrDcNKb4KcoY()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00009588 File Offset: 0x00007788
		internal static object AD1eLwt7XYNSpmuoN2R(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00009594 File Offset: 0x00007794
		internal static object neGOw3tRVLwgZpG82V7(IntPtr ptr)
		{
			return MarshalExtend.PtrToString(ptr);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000095A0 File Offset: 0x000077A0
		internal static bool XPCcVutkSPqXDIJfwX3(object A_0)
		{
			return A_0.IsObfuscated();
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000095AC File Offset: 0x000077AC
		internal static bool e7OfpytEGZLnEkhjY6b()
		{
			return IL2CPP.nBBJu8tu2HXL1P7mwu4 == null;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000095B8 File Offset: 0x000077B8
		internal static IL2CPP jZxQUhtcoWywVRhkgEw()
		{
			return IL2CPP.nBBJu8tu2HXL1P7mwu4;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000095C0 File Offset: 0x000077C0
		internal static char SQ9ZGrtJQDD7dhevb5J(object A_0, int A_1, object A_2)
		{
			return A5IXfW9GsGA59SDnkr0.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000095D4 File Offset: 0x000077D4
		internal static object aCDkC4tWLb4rwbrmFX5(object A_0, object A_1, object A_2, object A_3)
		{
			return FqZp2N9hs66h9Og8y7V.i2IAUFsOOC(A_0, A_1, A_2, A_3);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000095EC File Offset: 0x000077EC
		internal static bool YnutYVtrwYE9d7IDGRH(object A_0, object A_1, object A_2)
		{
			return KXbVLO90rvxCycuMdcc.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00009600 File Offset: 0x00007800
		internal static object At7ypPtDGntBLusBnFN(object A_0, object A_1, object A_2, object A_3, object A_4)
		{
			return SjRANlAsQ8j3KPpZL2p.i2IAUFsOOC(A_0, A_1, A_2, A_3, A_4);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000961C File Offset: 0x0000781C
		internal static IntPtr tCseJotZesyVEKyYLyu(object A_0)
		{
			return NativeStructUtils.GetMethodInfoForMissingMethod(A_0);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00009628 File Offset: 0x00007828
		internal static void lQ7KNIto7ksG5YVpoQb(object A_0)
		{
			Logger.LogDebug(A_0);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00009634 File Offset: 0x00007834
		internal static object ETgriltbugPDLcuxJ4x(object A_0, object A_1, object A_2)
		{
			return pcGtWx9cV0AmXQghfas.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00009648 File Offset: 0x00007848
		internal static object jcG9XetfJPHnNJ6F7sx(object A_0, char A_1, char A_2, object A_3)
		{
			return e61WPb9RvMZQJWDgbH9.i2IAUFsOOC(A_0, A_1, A_2, A_3);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00009660 File Offset: 0x00007860
		internal static object yv2p52tPsEHv740qRjy(object A_0, object A_1, object A_2, object A_3)
		{
			return My0BUA9Ld5K5NOXfgTl.i2IAUFsOOC(A_0, A_1, A_2, A_3);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00009678 File Offset: 0x00007878
		internal static bool bW6gxHtd1rZ2qOlOF5O(object A_0, object A_1, object A_2)
		{
			return O8vLYPqbYWoU9KsgoZ5.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000968C File Offset: 0x0000788C
		internal static object hYEUhEtwh8wlrNVyI5Q(object A_0, object A_1, object A_2)
		{
			return z4S0e1U05BsRVVK2fNl.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000096A0 File Offset: 0x000078A0
		internal static object rqwkBJten0ymxmiklv5(object A_0, object A_1)
		{
			return MHUs7j9JBFis0IY18CL.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000096B0 File Offset: 0x000078B0
		internal static int S2Wl7Sts5RYRQaIoBD6(object A_0, object A_1)
		{
			return JmmWop9taD6h4B6BjCV.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000096C0 File Offset: 0x000078C0
		internal static IntPtr TfgWSPtQv9fTIEmcXcO(IntPtr enclosingClass, object A_1)
		{
			return RuntimeReflectionHelper.GetNestedTypeViaReflection(enclosingClass, A_1);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000096D0 File Offset: 0x000078D0
		internal static int zNlxQmt2DB2jCOSkvw3(object A_0, char A_1, object A_2)
		{
			return OSC2DT9buTa3fdEsF0m.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000096E4 File Offset: 0x000078E4
		internal static object VF9gWMtyPW2dCVdEbYJ(object A_0, int A_1, int A_2, object A_3)
		{
			return aaIVKB9PZFrTDNowlRw.i2IAUFsOOC(A_0, A_1, A_2, A_3);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000096FC File Offset: 0x000078FC
		internal static bool tiqNUMtSYmSu493pTu0(object A_0, object A_1)
		{
			return vOElIf92k2MIupuZIdH.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000970C File Offset: 0x0000790C
		internal static Type dj1DD6tgT8K64bWmY7Y(object A_0, object A_1)
		{
			return U8h2YU9SxVTdCTH73DU.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000971C File Offset: 0x0000791C
		internal static bool dljIS4tlpNq5TBwl7Xt(object A_0, object A_1)
		{
			return TVBfjI9lsjlW0VbGRtd.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000972C File Offset: 0x0000792C
		internal static bool z0v2J5tVbvMSM67OqJ4(object A_0, object A_1)
		{
			return UDlAeP9mFIOY9IiyV84.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000973C File Offset: 0x0000793C
		internal static bool ypsMmctOe7wAxNIfCsW(Type type)
		{
			return type.TypeHasIl2CppArrayBase();
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00009748 File Offset: 0x00007948
		internal static object G5LfMItXWxJipYfSd5Y(object A_0)
		{
			return A_0.TrimIl2CppPrefix();
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00009754 File Offset: 0x00007954
		internal static object QQj1MJtmudC2JERcc6h(object A_0, object A_1, object A_2)
		{
			return ryYXxRUq8BsbY0RUmr6.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00009768 File Offset: 0x00007968
		internal static object DwNId1tvfr5BWRbWjnJ(object A_0, char A_1, object A_2)
		{
			return H2StJeUGVkry79EgdEo.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000977C File Offset: 0x0000797C
		internal static object Kv5gBJtBWLAhS0N0EuV(object A_0, object A_1)
		{
			return roQekQ9BcyCRlkwvynt.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000978C File Offset: 0x0000798C
		internal static object dG9hnWtjj7kVOP52UOC(object A_0, object A_1)
		{
			return QW5rQ4UtSMItWDAsJG4.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000979C File Offset: 0x0000799C
		internal static Type fAPKygtTAaFeTSUivsa(RuntimeTypeHandle A_0, object A_1)
		{
			return byRw0gA2NyqHkl03ii9.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000097AC File Offset: 0x000079AC
		internal static bool tgQ6iZtFbW0brif08cs(Type A_0, Type A_1, object A_2)
		{
			return dPsigOUwJdO4bwskNJ5.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000097C0 File Offset: 0x000079C0
		internal static object wTVDQHtKfaYa2FM3otx(object A_0, object A_1)
		{
			return XbWY87UAp2s3iIUpBiV.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000097D0 File Offset: 0x000079D0
		internal static bool W2Ua3Qt58XRSwrYot4Z(object A_0, object A_1, object A_2)
		{
			return z4BRwT9Ki3wnMXvZB09.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000097E4 File Offset: 0x000079E4
		internal static int t1ItoqtnIMIhapvFTY1(object A_0, object A_1)
		{
			return UFa5wp9napnQy9snOJw.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000097F4 File Offset: 0x000079F4
		internal static object dKvsAPt3U8BIa3r9hSu(object A_0, int A_1, object A_2)
		{
			return R7ef7291ooaKjIgIYPN.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00009808 File Offset: 0x00007A08
		internal static bool Ngwwr3t1DcaJqoRRVQb(object A_0, object A_1)
		{
			return MlRLUg9pmkDVLenGADv.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00009818 File Offset: 0x00007A18
		internal static Type wPAroNtMIgTpFX791Rj(object A_0, object A_1)
		{
			return Vee0EH9TsQeZv7AssmK.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00009828 File Offset: 0x00007A28
		internal static bool K9jJCqtpxKTTpoTM4D3()
		{
			return UnityVersionHandler.HasGetMethodFromReflection;
		}

		// Token: 0x0400001B RID: 27
		public static readonly Dictionary<string, IntPtr> ImageMap;

		// Token: 0x0400001C RID: 28
		public static readonly Dictionary<ValueTuple<IntPtr, string>, IntPtr> FallbackClasses;

		// Token: 0x0400001D RID: 29
		internal static IL2CPP nBBJu8tu2HXL1P7mwu4;
	}
}
