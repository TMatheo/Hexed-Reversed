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
		// Token: 0x06000093 RID: 147 RVA: 0x00004E98 File Offset: 0x00003098
		unsafe static IL2CPP()
		{
			int num = 17;
			for (;;)
			{
				int num2 = num;
				IntPtr intPtr;
				int num3;
				IntPtr* ptr;
				for (;;)
				{
					uint num4;
					uint num5;
					IntPtr intPtr3;
					uint num6;
					switch (num2)
					{
					case 0:
						goto IL_240;
					case 1:
						goto IL_205;
					case 2:
						goto IL_31D;
					case 3:
						goto IL_134;
					case 4:
						goto IL_281;
					case 5:
					{
						string key;
						IL2CPP.ImageMap[key] = intPtr;
						num2 = 25;
						continue;
					}
					case 6:
						num3 = 0;
						num2 = 24;
						continue;
					case 7:
						break;
					case 8:
						IL2CPP.GZmnfvhZbFgFixTRS6C();
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_26479210ae524f22ae1fe060a08fdd55 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 9:
						goto IL_1A0;
					case 10:
						goto IL_2B4;
					case 11:
						goto IL_2B4;
					case 12:
					{
						IntPtr intPtr2 = IL2CPP.il2cpp_domain_get();
						if (intPtr2 == IntPtr.Zero)
						{
							goto Block_14;
						}
						num4 = 0U;
						ptr = IL2CPP.il2cpp_domain_get_assemblies(intPtr2, ref num4);
						num2 = 6;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b5c96750853e4496814af588489331dc != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					case 13:
						num5 = 0U;
						num2 = 11;
						continue;
					case 14:
					{
						string key = IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_image_get_name(intPtr));
						num2 = 5;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_263609815aa041aea5525a459e9a816b != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					case 15:
						IL2CPP.FallbackClasses = new Dictionary<ValueTuple<IntPtr, string>, IntPtr>();
						num2 = 12;
						continue;
					case 16:
						hIDAYxH6DWLHIthQgC.oDuBOTgYK();
						num2 = 8;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2356ac6ca5954f1897cd5bbbe0161ae5 != 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					case 17:
						IL2CPP.uJK0VHhamrFbZU0PAWM();
						num2 = 16;
						continue;
					case 18:
					{
						string text;
						if (IL2CPP.Smq6GCOqlVdSiuYkpED(text))
						{
							goto IL_281;
						}
						num2 = 13;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa != 0)
						{
							num2 = 22;
							continue;
						}
						continue;
					}
					case 19:
					{
						string text;
						IL2CPP.FallbackClasses.Add(new ValueTuple<IntPtr, string>(intPtr, text), intPtr3);
						num2 = 9;
						continue;
					}
					case 20:
					{
						string text = IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_class_get_name(intPtr3));
						num2 = 18;
						continue;
					}
					case 21:
						return;
					case 22:
						goto IL_1A0;
					case 23:
						break;
					case 24:
						goto IL_134;
					case 25:
						num6 = IL2CPP.il2cpp_image_get_class_count(intPtr);
						num2 = 8;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_43cc35cb254148318955c7f83ade60f1 == 0)
						{
							num2 = 13;
							continue;
						}
						continue;
					default:
						goto IL_240;
					}
					intPtr3 = IL2CPP.il2cpp_image_get_class(intPtr, num5);
					num2 = 20;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4c6a46c0a2d14747aa1dc5bf1581154d != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
					IL_134:
					if ((long)num3 >= (long)((ulong)num4))
					{
						num2 = 21;
						continue;
					}
					break;
					IL_1A0:
					num5 += 1U;
					num2 = 3;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b1a14f54e3674a8baf7d5ab6ab85764a == 0)
					{
						num2 = 10;
						continue;
					}
					continue;
					IL_281:
					if (IL2CPP.il2cpp_class_get_declaring_type(intPtr3) == IntPtr.Zero)
					{
						num2 = 19;
						continue;
					}
					goto IL_1A0;
					IL_240:
					IL2CPP.ImageMap = new Dictionary<string, IntPtr>();
					num2 = 15;
					continue;
					IL_2B4:
					if (num5 < num6)
					{
						num2 = 7;
						continue;
					}
					IL_31D:
					num3++;
					num2 = 2;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8378a46aa7ed47018832a42729b1bc3b != 0)
					{
						num2 = 3;
					}
				}
				IL_205:
				intPtr = IL2CPP.il2cpp_assembly_get_image(ptr[(IntPtr)num3 * (IntPtr)sizeof(IntPtr) / (IntPtr)sizeof(IntPtr)]);
				num = 14;
			}
			return;
			Block_14:
			throw new NullReferenceException(IL2CPP.bbiWdqhzIlyFXcCC3fU(-212088314 ^ -129544918 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e6eb36653ec04a89bf8fa64932849f3b));
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00005244 File Offset: 0x00003444
		internal static IntPtr GetIl2CppImage(object name)
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
					goto IL_3A;
				case 2:
					if (IL2CPP.ImageMap.ContainsKey(name))
					{
						goto IL_28;
					}
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4356a7af7f8147b79f2ed4ab0c268438 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
			IL_28:
			return IL2CPP.ImageMap[name];
			IL_3A:
			return IntPtr.Zero;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000052E0 File Offset: 0x000034E0
		internal static IntPtr[] GetIl2CppImages()
		{
			return IL2CPP.ImageMap.Values.ToArray<IntPtr>();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000052F4 File Offset: 0x000034F4
		internal static bool IsObfuscated(this object str)
		{
			int num = 13;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					char c;
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_201;
					case 1:
						break;
					case 2:
						if (!IL2CPP.g3sy1sOAebEJalrCjcq(c, nGt75TAzVTkWVu9307q.a2LLluqJ9a))
						{
							goto IL_89;
						}
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_124ad935e0834fda9ae7f452377dbe1c != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						if (c != '>')
						{
							num2 = 14;
							continue;
						}
						goto IL_212;
					case 4:
						if (c <= 'Z')
						{
							num2 = 16;
							continue;
						}
						goto IL_D3;
					case 5:
						goto IL_171;
					case 6:
						if (c != '<')
						{
							num2 = 3;
							continue;
						}
						goto IL_212;
					case 7:
						goto IL_D3;
					case 8:
						return false;
					case 9:
						goto IL_15E;
					case 10:
						goto IL_212;
					case 11:
						goto IL_89;
					case 12:
						num3 = 0;
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_be7c67937fc746d2ad6f8cd47b555de7 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 13:
						num2 = 12;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_be7c67937fc746d2ad6f8cd47b555de7 == 0)
						{
							num2 = 7;
							continue;
						}
						continue;
					case 14:
						return true;
					case 15:
						if (c != '.')
						{
							num2 = 6;
							continue;
						}
						goto IL_212;
					case 16:
						goto IL_212;
					case 17:
						if (c > 'z')
						{
							goto IL_15E;
						}
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92a7d78565474619a2c93ca9aa734139 != 0)
						{
							num2 = 10;
							continue;
						}
						continue;
					case 18:
						if (c != '`')
						{
							num2 = 15;
							continue;
						}
						goto IL_212;
					case 19:
						break;
					default:
						goto IL_201;
					}
					if (num3 >= zcv4yQLqdIM9E4xdCpN.muOq5LWqgj(str, zcv4yQLqdIM9E4xdCpN.gIPL5dh8lU))
					{
						num2 = 8;
						continue;
					}
					goto IL_171;
					IL_89:
					if (c >= 'a')
					{
						num2 = 17;
						continue;
					}
					IL_15E:
					if (c >= 'A')
					{
						num2 = 4;
						continue;
					}
					goto IL_D3;
					IL_171:
					c = IL2CPP.fJhICWO5tGE85eLVls7(str, num3, YL0AxBAagUmuljcLtI3.Qv8AZkC12e);
					num2 = 2;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7628c527f657443a88f11a40a3f948a5 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
					IL_212:
					num3++;
					num2 = 19;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7492c06848354e9185cf647bb6904451 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
					IL_201:
					goto IL_212;
					IL_D3:
					if (c != '_')
					{
						break;
					}
					goto IL_212;
				}
				num = 18;
			}
			return false;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000555C File Offset: 0x0000375C
		public static IntPtr TryGetDeclaringType(IntPtr Prt, out IntPtr DeclaringType)
		{
			int num = 1;
			int num2 = num;
			IntPtr result;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					result = (DeclaringType = IL2CPP.il2cpp_class_get_declaring_type(Prt));
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c26b4d3619a4457fb4121e194d9ef286 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return result;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000055BC File Offset: 0x000037BC
		public static IntPtr GetIl2CppClass(string assemblyName, string namespaze, string className)
		{
			int num = 2;
			int num2 = num;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_1BB;
				case 2:
				{
					IntPtr intPtr;
					if (IL2CPP.ImageMap.TryGetValue(assemblyName, out intPtr))
					{
						IntPtr intPtr2 = IL2CPP.il2cpp_class_from_name(intPtr, namespaze, className);
						num2 = 4;
						continue;
					}
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b5c96750853e4496814af588489331dc != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				case 3:
					gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(849699899 + -32398930 ^ 570566866 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7ac65c3fd4cb4629a8b893be89aed17d), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
					num2 = 9;
					continue;
				case 4:
				{
					IntPtr intPtr2;
					if (intPtr2 == IntPtr.Zero)
					{
						num2 = 7;
						continue;
					}
					return intPtr2;
				}
				case 5:
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 3);
					num2 = 3;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_40fe2648722c4d04bef43cdd927d6154 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 6:
					gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, IL2CPP.bbiWdqhzIlyFXcCC3fU(-635121885 ^ -864900130 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b329e831708e4d29ae561982d3d8c1c1), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
					num2 = 10;
					continue;
				case 7:
				{
					IntPtr intPtr;
					IntPtr intPtr2;
					if (!IL2CPP.FallbackClasses.TryGetValue(new ValueTuple<IntPtr, string>(intPtr, className), out intPtr2))
					{
						num2 = 5;
						continue;
					}
					return intPtr2;
				}
				case 8:
					gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, IL2CPP.bbiWdqhzIlyFXcCC3fU(-488741256 ^ -192413047 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b329e831708e4d29ae561982d3d8c1c1), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
					num2 = 11;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_791a252a9221476faad2c6d41e84a167 == 0)
					{
						num2 = 11;
						continue;
					}
					continue;
				case 9:
					CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, assemblyName, CbStEuAV6XsjbRRcotu.WZrA06bJrN);
					num2 = 6;
					continue;
				case 10:
					CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, namespaze, CbStEuAV6XsjbRRcotu.WZrA06bJrN);
					num2 = 8;
					continue;
				case 11:
					CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, className, CbStEuAV6XsjbRRcotu.WZrA06bJrN);
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_068b7dfa4ec449e7b5200030c1c277e5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			goto IL_21D;
			IL_1BB:
			throw new NullReferenceException(NcUD7JLAPSgAlBXsvpB.muOq5LWqgj(IL2CPP.bbiWdqhzIlyFXcCC3fU(-1056993365 << 4 ^ 1251011154 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6dbfd13d96434eb59d868fecd0ad1cda), assemblyName, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1392900426 ^ -743871856 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6d9238cad9434518b97d223669b8fe50), NcUD7JLAPSgAlBXsvpB.YrNLLbPNO6));
			IL_21D:
			throw new NullReferenceException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00005828 File Offset: 0x00003A28
		public static IntPtr GetIl2CppField(IntPtr clazz, string fieldName)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				IntPtr zero;
				IntPtr intPtr2;
				switch (num2)
				{
				default:
					goto IL_40;
				case 1:
					if (clazz == IntPtr.Zero)
					{
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_457365959f004478ad0e311bf72b3912 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					else
					{
						IntPtr intPtr = IL2CPP.il2cpp_class_get_field_from_name(clazz, fieldName);
						num2 = 2;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8b1b71d923f0486b89239dd4a11f6d34 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					break;
				case 2:
					zero = IntPtr.Zero;
					num2 = 6;
					continue;
				case 3:
				{
					IntPtr intPtr;
					if (intPtr != IntPtr.Zero)
					{
						return intPtr;
					}
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cc8d2b38a48843c198fb28cbbbd93013 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				case 4:
					break;
				case 5:
					goto IL_98;
				case 6:
					break;
				case 7:
					return intPtr2;
				case 8:
					IL_129:
					if (!IL2CPP.ufxDS8OLJw47k1UWLQw(IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_field_get_name(intPtr2)), fieldName, XXsbDZLXBpXOTAuVQqA.UVLLcpMwbl))
					{
						num2 = 4;
						continue;
					}
					return intPtr2;
				}
				if ((intPtr2 = IL2CPP.il2cpp_class_get_fields(clazz, ref zero)) != IntPtr.Zero)
				{
					goto IL_129;
				}
				num2 = 5;
			}
			IL_40:
			return IntPtr.Zero;
			IL_98:
			throw new NullReferenceException(IL2CPP.cYL3yUOXjbCgKWAcX8X(IL2CPP.bbiWdqhzIlyFXcCC3fU(-684805877 ^ -257125779 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_49f6034724814fe88f4ca6e5ef134249), fieldName, IL2CPP.bbiWdqhzIlyFXcCC3fU(1053591832 << 3 ^ -535034417 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3e36778f33984767b2e7264fa31cee60), IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_class_get_name(clazz)), KUcPF8qN05KKuwdEiA1.R6Mqu5fmTH));
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000059F4 File Offset: 0x00003BF4
		public static IntPtr GetIl2CppMethodByToken(IntPtr clazz, int token)
		{
			int num = 4;
			int num2 = num;
			string text;
			for (;;)
			{
				IntPtr intPtr;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				IntPtr zero;
				switch (num2)
				{
				case 0:
					goto IL_239;
				case 1:
					IL_1D4:
					if ((ulong)IL2CPP.il2cpp_method_get_token(intPtr) == (ulong)((long)token))
					{
						num2 = 12;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b329e831708e4d29ae561982d3d8c1c1 == 0)
						{
							num2 = 11;
							continue;
						}
						continue;
					}
					break;
				case 2:
					CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, text, CbStEuAV6XsjbRRcotu.WZrA06bJrN);
					num2 = 8;
					continue;
				case 3:
					goto IL_185;
				case 4:
					if (clazz == IntPtr.Zero)
					{
						num2 = 3;
						continue;
					}
					zero = IntPtr.Zero;
					num2 = 7;
					continue;
				case 5:
					gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1262615253 ^ -535374218 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e5b00aa4c99144c78d3bd63e270496cb), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
					num2 = 2;
					continue;
				case 6:
					text = IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_class_get_name(clazz));
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_45f0db95dace45b6a0257ae80a3038eb == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 7:
					break;
				case 8:
					gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, IL2CPP.bbiWdqhzIlyFXcCC3fU(1154435597 ^ 1745135463 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_64a8b41e58e0491ab0e9d05ec5ed61d3), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
					num2 = 10;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4da80845ebf7410ebbf942336f5ee27b != 0)
					{
						num2 = 10;
						continue;
					}
					continue;
				case 9:
					Logger.LogDebug(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
					num2 = 11;
					continue;
				case 10:
					defaultInterpolatedStringHandler.AppendFormatted<int>(token);
					num2 = 9;
					continue;
				case 11:
					goto IL_A9;
				case 12:
					return intPtr;
				default:
					goto IL_239;
				}
				if ((intPtr = IL2CPP.il2cpp_class_get_methods(clazz, ref zero)) != IntPtr.Zero)
				{
					goto IL_1D4;
				}
				num2 = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6776fc69415b4d309be658e7e8ac3a28 != 0)
				{
					num2 = 6;
					continue;
				}
				continue;
				IL_239:
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
				num2 = 5;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b1a14f54e3674a8baf7d5ab6ab85764a != 0)
				{
					num2 = 4;
				}
			}
			IL_A9:
			return NativeStructUtils.GetMethodInfoForMissingMethod(NcUD7JLAPSgAlBXsvpB.muOq5LWqgj(text, IL2CPP.bbiWdqhzIlyFXcCC3fU(280296357 + 279526192 ^ 1035006607 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92a7d78565474619a2c93ca9aa734139), DAVuPRLkTcl9jFXneIG.muOq5LWqgj(ref token, DAVuPRLkTcl9jFXneIG.ThVL2CwEDi), NcUD7JLAPSgAlBXsvpB.YrNLLbPNO6));
			IL_185:
			return IL2CPP.pDmADQOcma9J5bo2gxj(DAVuPRLkTcl9jFXneIG.muOq5LWqgj(ref token, DAVuPRLkTcl9jFXneIG.ThVL2CwEDi));
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00005C64 File Offset: 0x00003E64
		public static IntPtr GetIl2CppMethod(IntPtr clazz, bool isGeneric, string methodName, string returnTypeName, params string[] argTypes)
		{
			int num = 28;
			string text2;
			for (;;)
			{
				int num2 = num;
				IntPtr intPtr;
				int num5;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				int num9;
				for (;;)
				{
					int num3;
					int num4;
					IntPtr intPtr2;
					int num6;
					string text;
					IntPtr zero;
					bool flag;
					uint num7;
					string text3;
					int num8;
					string text4;
					string text5;
					switch (num2)
					{
					case 0:
						goto IL_8C7;
					case 1:
						num3 = 0;
						num2 = 63;
						continue;
					case 2:
						num4++;
						num2 = 68;
						continue;
					case 3:
						if (IL2CPP.BoBNyPOhISo7gg7SDj6(IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_return_type(intPtr))), returnTypeName, Qb3kHiAJfQfbhOqjpaj.KIMApEklig))
						{
							num2 = 18;
							continue;
						}
						goto IL_670;
					case 4:
						goto IL_9FE;
					case 5:
						num5 = 0;
						num2 = 49;
						continue;
					case 6:
						goto IL_2C0;
					case 7:
						intPtr2 = intPtr;
						num2 = 29;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cc8d2b38a48843c198fb28cbbbd93013 != 0)
						{
							num2 = 29;
							continue;
						}
						continue;
					case 8:
						goto IL_9FE;
					case 9:
						num2 = 22;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bac7568f2bc04130b6b980225b2cc409 != 0)
						{
							num2 = 71;
							continue;
						}
						continue;
					case 10:
						argTypes[num6] = IL2CPP.RdPHVTOHnqYkWZ0Pq9L(IL2CPP.RdPHVTOHnqYkWZ0Pq9L(IL2CPP.AOdwnQO2dVfChAmtUbF(text, IL2CPP.bbiWdqhzIlyFXcCC3fU(-141486901 ^ -1784351494 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_575f8bd7bfb04e37800ff009689b44f6), "", fhthINLOyrFIG1Wkwkk.TXILtuWQat), '/', '.', zndYDNLvolVdGcenNrM.C3ULxA1fyZ), '+', '.', zndYDNLvolVdGcenNrM.C3ULxA1fyZ);
						num2 = 16;
						continue;
					case 11:
						zero = IntPtr.Zero;
						num2 = 78;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0272cc4de9694915be17746e515675c8 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 12:
						goto IL_9C9;
					case 13:
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, IL2CPP.bbiWdqhzIlyFXcCC3fU(~-1738352621 ^ 1375649010 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_508916f527eb4b05b32762ef07dd9e52), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						num2 = 74;
						continue;
					case 14:
						goto IL_B1F;
					case 15:
						if (IL2CPP.il2cpp_method_is_generic(intPtr) != isGeneric)
						{
							goto IL_924;
						}
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_911808c58d664adeb7c16d1e3a32f7fa == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 16:
						num6++;
						num2 = 22;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b1a14f54e3674a8baf7d5ab6ab85764a == 0)
						{
							num2 = 24;
							continue;
						}
						continue;
					case 17:
						goto IL_DC3;
					case 18:
						goto IL_924;
					case 19:
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, IL2CPP.bbiWdqhzIlyFXcCC3fU(395365498 ^ 631967065 ^ 364506569 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_49f6034724814fe88f4ca6e5ef134249), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						num2 = 65;
						continue;
					case 20:
						break;
					case 21:
						IL2CPP.xbPOsGOO9lW4uyNyVCc(IL2CPP.bbiWdqhzIlyFXcCC3fU(2056095481 >> 1 ^ 158776331 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8160363759e64728b1ce193157380515));
						num2 = 67;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3e2009ed69c04f5799431b4e58cafb2a == 0)
						{
							num2 = 76;
							continue;
						}
						continue;
					case 22:
						goto IL_342;
					case 23:
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, IL2CPP.bbiWdqhzIlyFXcCC3fU(-357604844 ^ -1518788151 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c580bbd8275c462fb04ea886a5e08073), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						num2 = 35;
						continue;
					case 24:
						goto IL_621;
					case 25:
						CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, text2, CbStEuAV6XsjbRRcotu.WZrA06bJrN);
						num2 = 19;
						continue;
					case 26:
						IL2CPP.xbPOsGOO9lW4uyNyVCc(hIDAYxH6DWLHIthQgC.gSCeTtiku(756266829 << 1 ^ 1314768633 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ac2c10c141e144acbcef06aa86a10430));
						num2 = 56;
						continue;
					case 27:
						goto IL_BCB;
					case 28:
						if (clazz == IntPtr.Zero)
						{
							num2 = 27;
							continue;
						}
						returnTypeName = zndYDNLvolVdGcenNrM.muOq5LWqgj(IL2CPP.RdPHVTOHnqYkWZ0Pq9L(IL2CPP.AOdwnQO2dVfChAmtUbF(returnTypeName, IL2CPP.bbiWdqhzIlyFXcCC3fU(--1271083629 ^ 425369160 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb34a81d7cc4fbea898664370a8645f), "", fhthINLOyrFIG1Wkwkk.TXILtuWQat), '/', '.', zndYDNLvolVdGcenNrM.C3ULxA1fyZ), '+', '.', zndYDNLvolVdGcenNrM.C3ULxA1fyZ);
						num2 = 36;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_faca03c2e5084297b7a5d894ac66fa57 == 0)
						{
							num2 = 45;
							continue;
						}
						continue;
					case 29:
						flag = false;
						num2 = 79;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2ec67b9ff6c4cd7af2a4ceec32c111c == 0)
						{
							num2 = 29;
							continue;
						}
						continue;
					case 30:
						text2 = IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_class_get_name(clazz));
						num2 = 54;
						continue;
					case 31:
						return intPtr;
					case 32:
						goto IL_40E;
					case 33:
						IL_591:
						if (IL2CPP.BoBNyPOhISo7gg7SDj6(MarshalExtend.PtrToString(IL2CPP.il2cpp_method_get_name(intPtr)), methodName, Qb3kHiAJfQfbhOqjpaj.KIMApEklig))
						{
							goto IL_384;
						}
						num2 = 25;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8378a46aa7ed47018832a42729b1bc3b != 0)
						{
							num2 = 34;
							continue;
						}
						continue;
					case 34:
						num7 = IL2CPP.il2cpp_method_get_param_count(intPtr);
						num2 = 21;
						continue;
					case 35:
						IL2CPP.xbPOsGOO9lW4uyNyVCc(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
						num2 = 19;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e82c749fe41a4203930245c7cb92bede == 0)
						{
							num2 = 22;
							continue;
						}
						continue;
					case 36:
						goto IL_9C9;
					case 37:
						IL2CPP.xbPOsGOO9lW4uyNyVCc(uLfVht5XqcdpSvFumbD.muOq5LWqgj(IL2CPP.bbiWdqhzIlyFXcCC3fU(849699899 + -32398930 ^ 1647224894 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb34a81d7cc4fbea898664370a8645f), text3, uLfVht5XqcdpSvFumbD.YFG5cZFN0S));
						num2 = 2;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0299b24d936d41acaea60798c25b2a4b != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 38:
						goto IL_190;
					case 39:
						goto IL_422;
					case 40:
						Logger.LogDebug(KUcPF8qN05KKuwdEiA1.muOq5LWqgj(IL2CPP.bbiWdqhzIlyFXcCC3fU(-1037388976 ^ 1897662843 ^ -873244736 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_856ffe7e0c9b4de88d71070d175d49fd), IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_return_type(intPtr2))), IL2CPP.bbiWdqhzIlyFXcCC3fU(2129888446 ^ 1120767109 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b544c260d8647ebad150746ba137290), returnTypeName, KUcPF8qN05KKuwdEiA1.R6Mqu5fmTH));
						num2 = 55;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_64a8b41e58e0491ab0e9d05ec5ed61d3 == 0)
						{
							num2 = 52;
							continue;
						}
						continue;
					case 41:
						return intPtr2;
					case 42:
						return intPtr;
					case 43:
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, IL2CPP.bbiWdqhzIlyFXcCC3fU(-2138437892 - -65622770 ^ -873700265 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2ec67b9ff6c4cd7af2a4ceec32c111c), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						num2 = 25;
						continue;
					case 44:
						goto IL_3D5;
					case 45:
						num6 = 0;
						num2 = 61;
						continue;
					case 46:
						goto IL_422;
					case 47:
						CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, methodName, CbStEuAV6XsjbRRcotu.WZrA06bJrN);
						num2 = 23;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_43cc35cb254148318955c7f83ade60f1 == 0)
						{
							num2 = 62;
							continue;
						}
						continue;
					case 48:
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, IL2CPP.bbiWdqhzIlyFXcCC3fU(1208865958 ^ 408832459 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4da80845ebf7410ebbf942336f5ee27b), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						num2 = 47;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_49f6034724814fe88f4ca6e5ef134249 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 49:
						goto IL_804;
					case 50:
						goto IL_384;
					case 51:
						IL_B53:
						if (Qb3kHiAJfQfbhOqjpaj.muOq5LWqgj(IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_method_get_name(intPtr)), methodName, Qb3kHiAJfQfbhOqjpaj.KIMApEklig))
						{
							goto IL_924;
						}
						num2 = 73;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_07ecbd0ef7af44eb94dd5a58ea706c8a != 0)
						{
							num2 = 47;
							continue;
						}
						continue;
					case 52:
						IL2CPP.xbPOsGOO9lW4uyNyVCc(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
						num2 = 40;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b329e831708e4d29ae561982d3d8c1c1 == 0)
						{
							num2 = 35;
							continue;
						}
						continue;
					case 53:
						goto IL_670;
					case 54:
						if (num3 != 1)
						{
							goto IL_4DC;
						}
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b329e831708e4d29ae561982d3d8c1c1 != 0)
						{
							num2 = 59;
							continue;
						}
						continue;
					case 55:
						IL2CPP.xbPOsGOO9lW4uyNyVCc(hIDAYxH6DWLHIthQgC.gSCeTtiku(-2019746020 ^ -1754639708 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7dfb1d10537744ca9e949b6b3a3eac09));
						num2 = 3;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_315c1a09bac64a059f24e58be082c9be == 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 56:
						zero = IntPtr.Zero;
						num2 = 50;
						continue;
					case 57:
						goto IL_804;
					case 58:
						goto IL_56F;
					case 59:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(68, 2);
						num2 = 13;
						continue;
					case 60:
						num8++;
						num2 = 8;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_30f9f5d7d3f347ddac00a7ce0719d7cd == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 61:
						goto IL_621;
					case 62:
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, IL2CPP.bbiWdqhzIlyFXcCC3fU(-1518499353 << 4 ^ 1679738701 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6fe1694df7b94e7bbaa2aab21c6a82ec), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						num2 = 52;
						continue;
					case 63:
						intPtr2 = IntPtr.Zero;
						num2 = 11;
						continue;
					case 64:
						break;
					case 65:
						goto IL_E88;
					case 66:
						IL2CPP.xbPOsGOO9lW4uyNyVCc(IL2CPP.cYL3yUOXjbCgKWAcX8X(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1037388976 ^ 1897662843 ^ -1344766017 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92a7d78565474619a2c93ca9aa734139), text4, IL2CPP.bbiWdqhzIlyFXcCC3fU(239015313 ^ 734734227 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b169d8ea412f45e99e430384ddc8908b), argTypes[num5], KUcPF8qN05KKuwdEiA1.R6Mqu5fmTH));
						num2 = 12;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_960a54aec0f640cd975b2d62f3e0a596 != 0)
						{
							num2 = 44;
							continue;
						}
						continue;
					case 67:
						goto IL_5CC;
					case 68:
						goto IL_B8E;
					case 69:
						goto IL_B8E;
					case 70:
						num8 = 0;
						num2 = 4;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b3f20ce588d04b909ddcdcdf767eb5d4 == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 71:
						num4 = 0;
						num2 = 69;
						continue;
					case 72:
						goto IL_865;
					case 73:
						if ((ulong)IL2CPP.il2cpp_method_get_param_count(intPtr) == (ulong)((long)argTypes.Length))
						{
							num2 = 15;
							continue;
						}
						goto IL_924;
					case 74:
						CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, text2, CbStEuAV6XsjbRRcotu.WZrA06bJrN);
						num2 = 48;
						continue;
					case 75:
						Logger.LogDebug(IL2CPP.W39i36OtBj43kyF9FcK(IL2CPP.bbiWdqhzIlyFXcCC3fU(--1616386354 ^ 349163346 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8378a46aa7ed47018832a42729b1bc3b), text5, uLfVht5XqcdpSvFumbD.YFG5cZFN0S));
						num2 = 60;
						continue;
					case 76:
						goto IL_87E;
					case 77:
						goto IL_865;
					case 78:
						goto IL_924;
					case 79:
						num9 = 0;
						num2 = 72;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8378a46aa7ed47018832a42729b1bc3b == 0)
						{
							num2 = 43;
							continue;
						}
						continue;
					default:
						goto IL_8C7;
					}
					text4 = IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_param(intPtr2, (uint)num5)));
					num2 = 66;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e6eb36653ec04a89bf8fa64932849f3b == 0)
					{
						num2 = 48;
						continue;
					}
					continue;
					IL_2C0:
					text3 = argTypes[num4];
					num2 = 37;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_fe27a6a8bfb848d1a3dd32bc5b1790e7 != 0)
					{
						num2 = 16;
						continue;
					}
					continue;
					IL_B8E:
					if (num4 < argTypes.Length)
					{
						goto IL_2C0;
					}
					num2 = 26;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6dbfd13d96434eb59d868fecd0ad1cda == 0)
					{
						num2 = 8;
						continue;
					}
					continue;
					IL_384:
					if ((intPtr = IL2CPP.il2cpp_class_get_methods(clazz, ref zero)) == IntPtr.Zero)
					{
						num2 = 38;
						continue;
					}
					goto IL_591;
					IL_422:
					if (!flag)
					{
						num2 = 42;
						continue;
					}
					goto IL_924;
					IL_865:
					if (num9 < argTypes.Length)
					{
						goto Block_26;
					}
					goto IL_422;
					IL_56F:
					flag = true;
					num2 = 46;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_441278fe93ad425f9343d4f7d1692fca == 0)
					{
						num2 = 28;
						continue;
					}
					continue;
					IL_9C9:
					if (!IL2CPP.BoBNyPOhISo7gg7SDj6(IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_param(intPtr, (uint)num9))), argTypes[num9], Qb3kHiAJfQfbhOqjpaj.KIMApEklig))
					{
						goto Block_29;
					}
					goto IL_56F;
					IL_621:
					if (num6 < argTypes.Length)
					{
						goto IL_DC3;
					}
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_068b7dfa4ec449e7b5200030c1c277e5 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_670:
					num3++;
					num2 = 7;
					continue;
					IL_804:
					if (num5 >= argTypes.Length)
					{
						return intPtr2;
					}
					num2 = 15;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eec4384c7d0d42baa74a4dbdbdbdd8df != 0)
					{
						num2 = 20;
						continue;
					}
					continue;
					IL_924:
					if ((intPtr = IL2CPP.il2cpp_class_get_methods(clazz, ref zero)) != IntPtr.Zero)
					{
						goto IL_B53;
					}
					num2 = 28;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_754a6df239be4343a1e8b95a82be3f48 == 0)
					{
						num2 = 30;
						continue;
					}
					continue;
					IL_9FE:
					if ((long)num8 >= (long)((ulong)num7))
					{
						return intPtr;
					}
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_11d7514559f14fcba52669ac71e3cb39 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_B1F:
					text5 = MarshalExtend.PtrToString(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_param(intPtr, (uint)num8)));
					num2 = 3;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eeb967463afe407d8f7c3b354043704c != 0)
					{
						num2 = 75;
						continue;
					}
					continue;
					IL_8C7:
					goto IL_B1F;
					IL_DC3:
					text = argTypes[num6];
					num2 = 7;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_911808c58d664adeb7c16d1e3a32f7fa == 0)
					{
						num2 = 10;
					}
				}
				IL_342:
				IL2CPP.xbPOsGOO9lW4uyNyVCc(uLfVht5XqcdpSvFumbD.muOq5LWqgj(IL2CPP.bbiWdqhzIlyFXcCC3fU(-854988610 >> 3 ^ -966457905 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5), returnTypeName, uLfVht5XqcdpSvFumbD.YFG5cZFN0S));
				num = 9;
				continue;
				IL_3D5:
				num5++;
				num = 57;
				continue;
				IL_40E:
				num9++;
				num = 77;
				continue;
				IL_5CC:
				goto IL_40E;
				IL_4DC:
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 2);
				num = 43;
				continue;
				Block_26:
				num = 36;
				continue;
				IL_87E:
				Logger.LogDebug(uLfVht5XqcdpSvFumbD.muOq5LWqgj(IL2CPP.bbiWdqhzIlyFXcCC3fU(-59170696 ^ -517473374 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ffe1ad8c1cf94bc78c25e67b0264547e), IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_return_type(intPtr))), uLfVht5XqcdpSvFumbD.YFG5cZFN0S));
				num = 70;
				continue;
				Block_29:
				num = 67;
				continue;
				IL_E88:
				CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, methodName, CbStEuAV6XsjbRRcotu.WZrA06bJrN);
				num = 23;
			}
			IL_190:
			return IL2CPP.pDmADQOcma9J5bo2gxj(IL2CPP.aJlBMHOv8MxUMbKn6yS(new string[]
			{
				text2,
				hIDAYxH6DWLHIthQgC.gSCeTtiku(870414366 - 779185206 ^ 917918217 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6fe1694df7b94e7bbaa2aab21c6a82ec),
				methodName,
				hIDAYxH6DWLHIthQgC.gSCeTtiku(-498665130 ^ -1620228654 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b82ae23c6544f3a11e54f2fed3ad25),
				IL2CPP.PSnHYEOkqUZPpSVC9Ne(hIDAYxH6DWLHIthQgC.gSCeTtiku(1105551206 ^ 142569887 ^ 942775522 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_23fed2b647424ffc818af5297e87fd1e), argTypes, pUpARsLHLyKY1GdSMar.KkALh2718u),
				IL2CPP.bbiWdqhzIlyFXcCC3fU(2107640300 ^ 1008078334 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_30f9f5d7d3f347ddac00a7ce0719d7cd)
			}, lonhQ4LY1oN1lRp0a4i.urWL8DCZyO));
			IL_BCB:
			return IL2CPP.pDmADQOcma9J5bo2gxj(IL2CPP.cYL3yUOXjbCgKWAcX8X(methodName, IL2CPP.bbiWdqhzIlyFXcCC3fU(1094358228 ^ 1401927225 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7ac65c3fd4cb4629a8b893be89aed17d), IL2CPP.PSnHYEOkqUZPpSVC9Ne(IL2CPP.bbiWdqhzIlyFXcCC3fU(395365498 ^ 631967065 ^ 785712459 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92a7d78565474619a2c93ca9aa734139), argTypes, pUpARsLHLyKY1GdSMar.KkALh2718u), IL2CPP.bbiWdqhzIlyFXcCC3fU(--1616386354 ^ 727101372 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bac7568f2bc04130b6b980225b2cc409), KUcPF8qN05KKuwdEiA1.R6Mqu5fmTH));
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00006B14 File Offset: 0x00004D14
		public static IntPtr GetIl2CppMethod(IntPtr clazz, string methodName, params string[] argTypes)
		{
			int num = 20;
			IntPtr intPtr2;
			string text3;
			for (;;)
			{
				int num2 = num;
				int num3;
				int num6;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
				string text5;
				for (;;)
				{
					IntPtr intPtr;
					string text;
					int num5;
					int num7;
					bool flag;
					IntPtr zero;
					int num8;
					string text2;
					uint num9;
					string text4;
					switch (num2)
					{
					case 0:
						goto IL_739;
					case 1:
						goto IL_2D9;
					case 2:
						num3 = 0;
						num2 = 9;
						continue;
					case 3:
						intPtr = intPtr2;
						num2 = 22;
						continue;
					case 4:
						IL2CPP.xbPOsGOO9lW4uyNyVCc(IL2CPP.W39i36OtBj43kyF9FcK(IL2CPP.bbiWdqhzIlyFXcCC3fU(756266829 << 1 ^ 1580105399 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c26b4d3619a4457fb4121e194d9ef286), IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_return_type(intPtr2))), uLfVht5XqcdpSvFumbD.YFG5cZFN0S));
						num2 = 2;
						continue;
					case 5:
						goto IL_2A1;
					case 6:
						goto IL_5E0;
					case 7:
						goto IL_524;
					case 8:
						goto IL_A52;
					case 9:
						goto IL_90E;
					case 10:
						Logger.LogDebug(uLfVht5XqcdpSvFumbD.muOq5LWqgj(IL2CPP.bbiWdqhzIlyFXcCC3fU(-225340272 ^ -2037805393 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2a3cb7fb82fa47c39f707a2393c1a340), text, uLfVht5XqcdpSvFumbD.YFG5cZFN0S));
						num2 = 16;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_11d7514559f14fcba52669ac71e3cb39 == 0)
						{
							num2 = 13;
							continue;
						}
						continue;
					case 11:
						goto IL_437;
					case 12:
						goto IL_90E;
					case 13:
						intPtr = IntPtr.Zero;
						num2 = 25;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7fef7bb77728417ab4965dd0775b5899 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 14:
						IL_310:
						if (Qb3kHiAJfQfbhOqjpaj.muOq5LWqgj(IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_method_get_name(intPtr2)), methodName, Qb3kHiAJfQfbhOqjpaj.KIMApEklig))
						{
							goto IL_CA4;
						}
						num2 = 34;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b544c260d8647ebad150746ba137290 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 15:
					{
						int num4;
						num4++;
						num2 = 3;
						continue;
					}
					case 16:
						num5++;
						num2 = 43;
						continue;
					case 17:
						goto IL_67E;
					case 18:
					{
						int num4 = 0;
						num2 = 13;
						continue;
					}
					case 19:
						goto IL_86F;
					case 20:
						if (clazz == IntPtr.Zero)
						{
							num2 = 19;
							continue;
						}
						num6 = 0;
						num2 = 74;
						continue;
					case 21:
						num7 = 0;
						num2 = 2;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bc2bbd892f074260abf5aaa8b1124d64 == 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 22:
						flag = false;
						num2 = 35;
						continue;
					case 23:
						goto IL_CA4;
					case 24:
						IL2CPP.xbPOsGOO9lW4uyNyVCc(IL2CPP.bbiWdqhzIlyFXcCC3fU(870414366 - 779185206 ^ 226585217 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_124ad935e0834fda9ae7f452377dbe1c));
						num2 = 21;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_d2ec67b9ff6c4cd7af2a4ceec32c111c == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 25:
						zero = IntPtr.Zero;
						num2 = 44;
						continue;
					case 26:
						goto IL_534;
					case 27:
						num5 = 0;
						num2 = 8;
						continue;
					case 28:
					{
						int num4;
						if (num4 == 1)
						{
							num2 = 59;
							continue;
						}
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(43, 2);
						num2 = 55;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c26b4d3619a4457fb4121e194d9ef286 == 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					}
					case 29:
						goto IL_67E;
					case 30:
						num2 = 27;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_45f0db95dace45b6a0257ae80a3038eb != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 31:
						goto IL_403;
					case 32:
						goto IL_524;
					case 33:
						goto IL_534;
					case 34:
						if ((ulong)IL2CPP.il2cpp_method_get_param_count(intPtr2) != (ulong)((long)argTypes.Length))
						{
							goto IL_CA4;
						}
						num2 = 5;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_fe27a6a8bfb848d1a3dd32bc5b1790e7 == 0)
						{
							num2 = 15;
							continue;
						}
						continue;
					case 35:
						num8 = 0;
						num2 = 29;
						continue;
					case 36:
						IL2CPP.xbPOsGOO9lW4uyNyVCc(IL2CPP.W39i36OtBj43kyF9FcK(hIDAYxH6DWLHIthQgC.gSCeTtiku(1094358228 ^ 27148737 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4356a7af7f8147b79f2ed4ab0c268438), text2, uLfVht5XqcdpSvFumbD.YFG5cZFN0S));
						num2 = 40;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_575f8bd7bfb04e37800ff009689b44f6 == 0)
						{
							num2 = 18;
							continue;
						}
						continue;
					case 37:
						return intPtr2;
					case 38:
						Logger.LogDebug(IL2CPP.bbiWdqhzIlyFXcCC3fU(-635121885 ^ -892108309 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7dfb1d10537744ca9e949b6b3a3eac09));
						num2 = 4;
						continue;
					case 39:
						goto IL_3EF;
					case 40:
						goto IL_9EC;
					case 41:
						goto IL_1C5;
					case 42:
						text3 = IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_class_get_name(clazz));
						num2 = 28;
						continue;
					case 43:
						goto IL_A52;
					case 44:
						goto IL_CA4;
					case 45:
						IL2CPP.xbPOsGOO9lW4uyNyVCc(uLfVht5XqcdpSvFumbD.muOq5LWqgj(IL2CPP.bbiWdqhzIlyFXcCC3fU(-488741256 ^ -725746670 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_508916f527eb4b05b32762ef07dd9e52), MarshalExtend.PtrToString(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_return_type(intPtr))), uLfVht5XqcdpSvFumbD.YFG5cZFN0S));
						num2 = 24;
						continue;
					case 46:
						CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, text3, CbStEuAV6XsjbRRcotu.WZrA06bJrN);
						num2 = 31;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cb2874465fa5416db806f31e03cc475c == 0)
						{
							num2 = 47;
							continue;
						}
						continue;
					case 47:
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1371503382 + -1420905238 ^ -1241479500 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bac7568f2bc04130b6b980225b2cc409), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						num2 = 73;
						continue;
					case 48:
						CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, methodName, CbStEuAV6XsjbRRcotu.WZrA06bJrN);
						num2 = 45;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3f609fad0bcc47d79d3add6a492d3616 == 0)
						{
							num2 = 50;
							continue;
						}
						continue;
					case 49:
						IL2CPP.xbPOsGOO9lW4uyNyVCc(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
						num2 = 30;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6fe1694df7b94e7bbaa2aab21c6a82ec == 0)
						{
							num2 = 22;
							continue;
						}
						continue;
					case 50:
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-191781671 ^ -2059790582 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_23fed2b647424ffc818af5297e87fd1e), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						num2 = 49;
						continue;
					case 51:
						num7++;
						num2 = 61;
						continue;
					case 52:
						num9 = IL2CPP.il2cpp_method_get_param_count(intPtr2);
						num2 = 38;
						continue;
					case 53:
						IL_923:
						if (!Qb3kHiAJfQfbhOqjpaj.muOq5LWqgj(IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_method_get_name(intPtr2)), methodName, Qb3kHiAJfQfbhOqjpaj.KIMApEklig))
						{
							num2 = 52;
							continue;
						}
						goto IL_5E0;
					case 54:
						goto IL_2D9;
					case 55:
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1314478277 ^ 822754193 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6d9238cad9434518b97d223669b8fe50), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0ec1d35577cb488fb4bdfc9810c6c86f == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 56:
						return intPtr;
					case 57:
						goto IL_814;
					case 58:
						goto IL_266;
					case 59:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(68, 2);
						num2 = 8;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b5c96750853e4496814af588489331dc == 0)
						{
							num2 = 58;
							continue;
						}
						continue;
					case 60:
						break;
					case 61:
						goto IL_2A1;
					case 62:
						num6++;
						num2 = 16;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eeb967463afe407d8f7c3b354043704c != 0)
						{
							num2 = 39;
							continue;
						}
						continue;
					case 63:
						goto IL_1C5;
					case 64:
						goto IL_5BE;
					case 65:
						IL2CPP.xbPOsGOO9lW4uyNyVCc(IL2CPP.cYL3yUOXjbCgKWAcX8X(IL2CPP.bbiWdqhzIlyFXcCC3fU(--1634178851 ^ 281814212 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_23fed2b647424ffc818af5297e87fd1e), text4, IL2CPP.bbiWdqhzIlyFXcCC3fU(-1056993365 << 4 ^ 590550730 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_64a8b41e58e0491ab0e9d05ec5ed61d3), argTypes[num7], KUcPF8qN05KKuwdEiA1.R6Mqu5fmTH));
						num2 = 51;
						continue;
					case 66:
						goto IL_6A7;
					case 67:
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1129513093 ^ 1237718574 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_420bdc7f003c47439a9f8331e71194a1), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						num2 = 70;
						continue;
					case 68:
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, IL2CPP.bbiWdqhzIlyFXcCC3fU(1670146401 ^ 358447931 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_960a54aec0f640cd975b2d62f3e0a596), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						num2 = 48;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_1f1b1b07c9f5435991b0738ea3210852 != 0)
						{
							num2 = 38;
							continue;
						}
						continue;
					case 69:
						goto IL_766;
					case 70:
						IL2CPP.xbPOsGOO9lW4uyNyVCc(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
						num2 = 45;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cb2874465fa5416db806f31e03cc475c != 0)
						{
							num2 = 24;
							continue;
						}
						continue;
					case 71:
						zero = IntPtr.Zero;
						num2 = 6;
						continue;
					case 72:
						return intPtr2;
					case 73:
						CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, methodName, CbStEuAV6XsjbRRcotu.WZrA06bJrN);
						num2 = 66;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bc2bbd892f074260abf5aaa8b1124d64 == 0)
						{
							num2 = 67;
							continue;
						}
						continue;
					case 74:
						goto IL_3EF;
					default:
						goto IL_739;
					}
					IL_191:
					text5 = argTypes[num6];
					num2 = 11;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eec4384c7d0d42baa74a4dbdbdbdd8df == 0)
					{
						num2 = 9;
						continue;
					}
					continue;
					IL_3EF:
					if (num6 >= argTypes.Length)
					{
						num2 = 18;
						continue;
					}
					goto IL_191;
					IL_1C5:
					if (!flag)
					{
						return intPtr2;
					}
					num2 = 18;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b82ae23c6544f3a11e54f2fed3ad25 != 0)
					{
						num2 = 23;
						continue;
					}
					continue;
					IL_67E:
					if (num8 >= argTypes.Length)
					{
						goto IL_1C5;
					}
					num2 = 33;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e82c749fe41a4203930245c7cb92bede != 0)
					{
						num2 = 20;
						continue;
					}
					continue;
					IL_2A1:
					if (num7 < argTypes.Length)
					{
						goto IL_403;
					}
					num2 = 56;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_457365959f004478ad0e311bf72b3912 != 0)
					{
						num2 = 30;
						continue;
					}
					continue;
					IL_2D9:
					text = argTypes[num5];
					num2 = 10;
					continue;
					IL_CA4:
					if ((intPtr2 = IL2CPP.il2cpp_class_get_methods(clazz, ref zero)) != IntPtr.Zero)
					{
						goto IL_310;
					}
					num2 = 42;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_754a6df239be4343a1e8b95a82be3f48 != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
					IL_403:
					text4 = IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_param(intPtr, (uint)num7)));
					num2 = 51;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ffe1ad8c1cf94bc78c25e67b0264547e != 0)
					{
						num2 = 65;
						continue;
					}
					continue;
					IL_524:
					num8++;
					num2 = 17;
					continue;
					IL_5BE:
					text2 = MarshalExtend.PtrToString(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_param(intPtr2, (uint)num3)));
					num2 = 36;
					continue;
					IL_90E:
					if ((long)num3 >= (long)((ulong)num9))
					{
						num2 = 37;
						continue;
					}
					goto IL_5BE;
					IL_5E0:
					if ((intPtr2 = IL2CPP.il2cpp_class_get_methods(clazz, ref zero)) == IntPtr.Zero)
					{
						num2 = 69;
						continue;
					}
					goto IL_923;
					IL_6A7:
					flag = true;
					num2 = 63;
					continue;
					IL_534:
					if (!IL2CPP.BoBNyPOhISo7gg7SDj6(IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_type_get_name(IL2CPP.il2cpp_method_get_param(intPtr2, (uint)num8))), argTypes[num8], Qb3kHiAJfQfbhOqjpaj.KIMApEklig))
					{
						goto Block_18;
					}
					goto IL_6A7;
					IL_739:
					CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, text3, CbStEuAV6XsjbRRcotu.WZrA06bJrN);
					num2 = 68;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_bac7568f2bc04130b6b980225b2cc409 == 0)
					{
						num2 = 17;
						continue;
					}
					continue;
					IL_814:
					IL2CPP.xbPOsGOO9lW4uyNyVCc(IL2CPP.bbiWdqhzIlyFXcCC3fU(-357604844 ^ -1752899802 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b82ae23c6544f3a11e54f2fed3ad25));
					num2 = 71;
					continue;
					IL_A52:
					if (num5 >= argTypes.Length)
					{
						goto IL_814;
					}
					num2 = 54;
				}
				IL_266:
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1371503382 + -1420905238 ^ -1294437879 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c580bbd8275c462fb04ea886a5e08073), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				num = 46;
				continue;
				IL_437:
				argTypes[num6] = IL2CPP.RdPHVTOHnqYkWZ0Pq9L(IL2CPP.RdPHVTOHnqYkWZ0Pq9L(IL2CPP.AOdwnQO2dVfChAmtUbF(text5, IL2CPP.bbiWdqhzIlyFXcCC3fU(-794732516 ^ -325103349 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b544c260d8647ebad150746ba137290), "", fhthINLOyrFIG1Wkwkk.TXILtuWQat), '/', '.', zndYDNLvolVdGcenNrM.C3ULxA1fyZ), '+', '.', zndYDNLvolVdGcenNrM.C3ULxA1fyZ);
				num = 62;
				continue;
				Block_18:
				num = 7;
				continue;
				IL_9EC:
				num3++;
				num = 12;
			}
			return intPtr2;
			IL_766:
			return IL2CPP.pDmADQOcma9J5bo2gxj(IL2CPP.aJlBMHOv8MxUMbKn6yS(new string[]
			{
				text3,
				IL2CPP.bbiWdqhzIlyFXcCC3fU(-89903789 ^ -1374880130 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e5b00aa4c99144c78d3bd63e270496cb),
				methodName,
				IL2CPP.bbiWdqhzIlyFXcCC3fU(-873661934 ^ 37256319 ^ -614357888 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7ac65c3fd4cb4629a8b893be89aed17d),
				IL2CPP.PSnHYEOkqUZPpSVC9Ne(IL2CPP.bbiWdqhzIlyFXcCC3fU(-719654323 >> 3 ^ -2076246646 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_441278fe93ad425f9343d4f7d1692fca), argTypes, pUpARsLHLyKY1GdSMar.KkALh2718u),
				hIDAYxH6DWLHIthQgC.gSCeTtiku(-794732516 ^ -479788601 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6fe1694df7b94e7bbaa2aab21c6a82ec)
			}, lonhQ4LY1oN1lRp0a4i.urWL8DCZyO));
			IL_86F:
			return IL2CPP.pDmADQOcma9J5bo2gxj(KUcPF8qN05KKuwdEiA1.muOq5LWqgj(methodName, IL2CPP.bbiWdqhzIlyFXcCC3fU(674965228 ^ 1554837834 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8378a46aa7ed47018832a42729b1bc3b), IL2CPP.PSnHYEOkqUZPpSVC9Ne(IL2CPP.bbiWdqhzIlyFXcCC3fU(-257240942 ^ -1573684039 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb34a81d7cc4fbea898664370a8645f), argTypes, pUpARsLHLyKY1GdSMar.KkALh2718u), IL2CPP.bbiWdqhzIlyFXcCC3fU(863254910 ^ 1307155125 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_441278fe93ad425f9343d4f7d1692fca), KUcPF8qN05KKuwdEiA1.R6Mqu5fmTH));
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000077F8 File Offset: 0x000059F8
		public static string Il2CppStringToManaged(IntPtr il2CppString)
		{
			int num = 1;
			int num2 = num;
			int length;
			for (;;)
			{
				switch (num2)
				{
				default:
					goto IL_28;
				case 1:
					if (il2CppString == IntPtr.Zero)
					{
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_575f8bd7bfb04e37800ff009689b44f6 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						length = IL2CPP.il2cpp_string_length(il2CppString);
						num2 = 2;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c26b4d3619a4457fb4121e194d9ef286 == 0)
						{
							num2 = 1;
						}
					}
					break;
				case 2:
					goto IL_7B;
				}
			}
			IL_28:
			return null;
			IL_7B:
			return new string(IL2CPP.il2cpp_string_chars(il2CppString), 0, length);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00007890 File Offset: 0x00005A90
		public unsafe static IntPtr ManagedStringToIl2Cpp(string str)
		{
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_87;
				case 2:
					goto IL_58;
				case 3:
					fixed (char* ptr = o1RBkmLnABeZ1VxMK6m.muOq5LWqgj(str, o1RBkmLnABeZ1VxMK6m.vD4LbWPx28))
					{
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
						break;
					}
				case 4:
					if (str != null)
					{
						num2 = 3;
						continue;
					}
					goto IL_58;
				case 5:
					if (str != null)
					{
						num2 = 4;
						continue;
					}
					goto IL_87;
				}
				break;
			}
			goto IL_C9;
			IL_58:
			char* text = null;
			goto IL_CC;
			IL_87:
			return IntPtr.Zero;
			IL_C9:
			char* ptr;
			text = ptr;
			IL_CC:
			return IL2CPP.il2cpp_string_new_utf16(text, IL2CPP.ElI3UCOxbCvQqpDdHkX(str, zcv4yQLqdIM9E4xdCpN.gIPL5dh8lU));
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000797C File Offset: 0x00005B7C
		public static IntPtr Il2CppObjectBaseToPtr(Il2CppObjectBase obj)
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
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_c975b252adfc48c4b262398638f90354 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
			IL_28:
			return IntPtr.Zero;
			IL_5A:
			return obj.Pointer;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00007A08 File Offset: 0x00005C08
		public static IntPtr Il2CppObjectBaseToPtrNotNull(Il2CppObjectBase obj)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					goto IL_24;
				case 1:
					if (obj != null)
					{
						goto IL_2A;
					}
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0ec1d35577cb488fb4bdfc9810c6c86f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_24:
			throw new NullReferenceException();
			IL_2A:
			return obj.Pointer;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00007A6C File Offset: 0x00005C6C
		public static IntPtr GetIl2CppNestedType(IntPtr enclosingType, string nestedTypeName)
		{
			int num = 10;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
			for (;;)
			{
				int num2 = num;
				string text;
				IntPtr intPtr;
				for (;;)
				{
					IntPtr zero;
					switch (num2)
					{
					case 1:
						if (IL2CPP.il2cpp_class_is_inflated(enclosingType))
						{
							goto IL_C9;
						}
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_1B6;
					case 3:
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, IL2CPP.bbiWdqhzIlyFXcCC3fU(379738335 >> 6 ^ 481578995 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92a7d78565474619a2c93ca9aa734139), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						num2 = 18;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_575f8bd7bfb04e37800ff009689b44f6 == 0)
						{
							num2 = 13;
							continue;
						}
						continue;
					case 4:
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, IL2CPP.bbiWdqhzIlyFXcCC3fU(-1392900426 ^ -124705945 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b5e8e4146b4a178d711afdb1274991), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						num2 = 16;
						continue;
					case 5:
						goto IL_320;
					case 6:
						CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, nestedTypeName, CbStEuAV6XsjbRRcotu.WZrA06bJrN);
						num2 = 3;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_1f1b1b07c9f5435991b0738ea3210852 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 7:
						if (IL2CPP.yYtau2O8IHIYwUcsFd3(text, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1475211578 - -148084141 ^ -1399735616 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_be7c67937fc746d2ad6f8cd47b555de7), PeofPkL6bNG0bjS3T48.DRFLyqM7gX) != -1)
						{
							num2 = 8;
							continue;
						}
						goto IL_1B6;
					case 8:
					{
						int num3 = IL2CPP.JL4Ax6OnXOvuDiY0gyf(text, '/', NUqNn4LJ4BD2wh0AoTB.tlFLpGIwaa);
						num2 = 19;
						continue;
					}
					case 9:
						goto IL_9D;
					case 10:
						if (enclosingType == IntPtr.Zero)
						{
							num2 = 9;
							continue;
						}
						zero = IntPtr.Zero;
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3e36778f33984767b2e7264fa31cee60 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 11:
						return intPtr;
					case 12:
						CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_class_get_name(enclosingType)), CbStEuAV6XsjbRRcotu.WZrA06bJrN);
						num2 = 4;
						continue;
					case 13:
						goto IL_C9;
					case 14:
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, IL2CPP.bbiWdqhzIlyFXcCC3fU(-1852219397 >> 2 ^ -401453688 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b9b6cd6cbc040a7be58cff054f9e843), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						num2 = 12;
						continue;
					case 15:
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 3);
						num2 = 17;
						continue;
					case 16:
						goto IL_30E;
					case 17:
						gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, IL2CPP.bbiWdqhzIlyFXcCC3fU(~1524453083 ^ -729218781 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_23fed2b647424ffc818af5297e87fd1e), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
						num2 = 6;
						continue;
					case 18:
						CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, text, CbStEuAV6XsjbRRcotu.WZrA06bJrN);
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7b01772eb8964b6a81d74c3d1c2f871e == 0)
						{
							num2 = 14;
							continue;
						}
						continue;
					case 19:
					{
						int num3;
						text = IL2CPP.ndDFXMObK9PjHfuR619(text, num3 + 1, zcv4yQLqdIM9E4xdCpN.muOq5LWqgj(text, zcv4yQLqdIM9E4xdCpN.gIPL5dh8lU) - (num3 + 1), q9OgZiLVxnaY9ejTXLM.TkJL0k2tDq);
						num2 = 20;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_892d6b14d02a4b94bf68e8edfebcd1f5 != 0)
						{
							num2 = 14;
							continue;
						}
						continue;
					}
					case 20:
						goto IL_1B6;
					}
					text = nestedTypeName;
					num2 = 7;
					continue;
					IL_1B6:
					if ((intPtr = IL2CPP.il2cpp_class_get_nested_types(enclosingType, ref zero)) != IntPtr.Zero)
					{
						break;
					}
					num2 = 15;
				}
				IL_320:
				if (IL2CPP.ufxDS8OLJw47k1UWLQw(IL2CPP.SMf5IjOlFKjd5nuZl0F(IL2CPP.il2cpp_class_get_name(intPtr)), text, XXsbDZLXBpXOTAuVQqA.UVLLcpMwbl))
				{
					return intPtr;
				}
				num = 2;
			}
			IL_9D:
			return IntPtr.Zero;
			IL_C9:
			return IL2CPP.XxGyoYOYriugMRDA1Pj(enclosingType, nestedTypeName);
			IL_30E:
			throw new NullReferenceException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00007E2C File Offset: 0x0000602C
		public static void ThrowIfNull(object arg)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (arg == null)
					{
						goto IL_71;
					}
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92a7d78565474619a2c93ca9aa734139 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					goto IL_71;
				}
				break;
			}
			return;
			IL_71:
			throw new NullReferenceException();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00007EB0 File Offset: 0x000060B0
		public static T ResolveICall<T>(string signature) where T : Delegate
		{
			IntPtr intPtr = IL2CPP.il2cpp_resolve_icall(signature);
			if (intPtr == IntPtr.Zero)
			{
				return IL2CPP.GenerateDelegateForMissingICall<T>(signature);
			}
			return Marshal.GetDelegateForFunctionPointer<T>(intPtr);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00007EDC File Offset: 0x000060DC
		private static T GenerateDelegateForMissingICall<T>(object signature) where T : Delegate
		{
			MethodInfo methodInfo = DnZ9sC5vW5Zmyo7jjbr.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), hIDAYxH6DWLHIthQgC.gSCeTtiku(--1271083629 ^ 1530164821 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7dfb1d10537744ca9e949b6b3a3eac09), DnZ9sC5vW5Zmyo7jjbr.gLJ5xeKxO6);
			DynamicMethod dynamicMethod = new DynamicMethod(uLfVht5XqcdpSvFumbD.muOq5LWqgj(hIDAYxH6DWLHIthQgC.gSCeTtiku(-1130020106 << 5 ^ -1485961803 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6fe1694df7b94e7bbaa2aab21c6a82ec), y1wUHLqoFyW6gbQN93u.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), y1wUHLqoFyW6gbQN93u.la8qUHBwms), uLfVht5XqcdpSvFumbD.YFG5cZFN0S), C67uwgqiEvgqVW8owjp.muOq5LWqgj(methodInfo, C67uwgqiEvgqVW8owjp.qj1qwiCc4X), (from it in BliveCqCnt3Bq9RIiHL.muOq5LWqgj(methodInfo, BliveCqCnt3Bq9RIiHL.EbUq9R3fXl)
			select Ru3dbaqIKWq9Yf63MJb.muOq5LWqgj(it, Ru3dbaqIKWq9Yf63MJb.CVKqd8MMF8)).ToArray<Type>(), KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(IL2CPP).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), true);
			ILGenerator ilgenerator = dr5pjw5kUmWnx1oVRTn.muOq5LWqgj(dynamicMethod, dr5pjw5kUmWnx1oVRTn.pod52cShcT);
			NHuG3T5TPIER7uS3ECl.muOq5LWqgj(ilgenerator, OpCodes.Ldstr, NcUD7JLAPSgAlBXsvpB.muOq5LWqgj(hIDAYxH6DWLHIthQgC.gSCeTtiku(1651941374 ^ 1571988488 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3b7b1d35d0b845dea3db033f6ba5ccb5), signature, hIDAYxH6DWLHIthQgC.gSCeTtiku(457203345 ^ -2052212554 ^ -473540141 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b82ae23c6544f3a11e54f2fed3ad25), NcUD7JLAPSgAlBXsvpB.YrNLLbPNO6), NHuG3T5TPIER7uS3ECl.tlx5gASR4G);
			UHLYWh5fwXimKj8H332.muOq5LWqgj(ilgenerator, OpCodes.Newobj, Fj0pGZq4FxSKcr9u2UH.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Exception).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), new Type[]
			{
				KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(string).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV)
			}, Fj0pGZq4FxSKcr9u2UH.QGxq3iFYNq), UHLYWh5fwXimKj8H332.WjH515pX3x);
			sWLRHR5OB7hMDvnerut.muOq5LWqgj(ilgenerator, OpCodes.Throw, sWLRHR5OB7hMDvnerut.sr65tXjFly);
			return (T)((object)RXPjpP5aBG6EjiAFu8c.muOq5LWqgj(dynamicMethod, KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), RXPjpP5aBG6EjiAFu8c.rSD5ZZujmu));
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00008090 File Offset: 0x00006290
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
			if (JCwQlA5sGlTyuRZuORY.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(string).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), JCwQlA5sGlTyuRZuORY.fqC5SwdxA5))
			{
				return (T)((object)IL2CPP.Il2CppStringToManaged(objectPointer));
			}
			if (objectPointer == IntPtr.Zero)
			{
				return default(T);
			}
			Il2CppObjectBase obj = new Il2CppObjectBase(objectPointer);
			if (x0spFZLsrp0hVQy7PPM.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), x0spFZLsrp0hVQy7PPM.HLcLST3Bek))
			{
				return Il2CppObjectBase.UnboxUnsafe<T>(objectPointer);
			}
			return (T)((object)h8B9V2LNETmMepe7XaN.muOq5LWqgj(DnZ9sC5vW5Zmyo7jjbr.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Il2CppObjectBase).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), hIDAYxH6DWLHIthQgC.gSCeTtiku(~-1799406944 ^ 534188531 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8378a46aa7ed47018832a42729b1bc3b), DnZ9sC5vW5Zmyo7jjbr.gLJ5xeKxO6), new Type[]
			{
				KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV)
			}, h8B9V2LNETmMepe7XaN.nPqLu389px).Invoke(obj, new object[0]));
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000081CC File Offset: 0x000063CC
		public static string RenderTypeName<T>(bool addRefMarker = false)
		{
			return IL2CPP.RenderTypeName(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), addRefMarker);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000081E4 File Offset: 0x000063E4
		public static string RenderTypeName(Type t, bool addRefMarker = false)
		{
			int num = 5;
			StringBuilder stringBuilder;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					Type[] array;
					int num3;
					switch (num2)
					{
					case 1:
						IL2CPP.u5UiUpOm32WfgXlYNUM(stringBuilder, '<', L3pNC5qaYklcQpPam6c.HaqqZExIA8);
						num2 = 9;
						continue;
					case 2:
						IL2CPP.W6AA2nODAqeWHSbwH0j(stringBuilder, IL2CPP.i4VxBIOu0ZkUDA6FOAG(IL2CPP.Ti3QdeONZAXFrsIZ62G(t, WlkGPlLCeVsSoCNEnkk.N1bL9EYrMB).FullNameObfuscated()), m2eLpFqjHkNaRPiWsth.q85qQy67LK);
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7fef7bb77728417ab4965dd0775b5899 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_289;
					case 4:
						if (!BQuLGfLDjvo8ClYhpuj.muOq5LWqgj(t, BQuLGfLDjvo8ClYhpuj.UiLLm8omjq))
						{
							num2 = 12;
							continue;
						}
						goto IL_84;
					case 5:
						if (!addRefMarker)
						{
							num2 = 4;
							continue;
						}
						goto IL_22D;
					case 6:
						L3pNC5qaYklcQpPam6c.muOq5LWqgj(stringBuilder, ',', L3pNC5qaYklcQpPam6c.HaqqZExIA8);
						num2 = 13;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5395ed2b7ead4e349835ba3f56e39138 != 0)
						{
							num2 = 7;
							continue;
						}
						continue;
					case 7:
						goto IL_2EF;
					case 8:
						if (IL2CPP.oHuvmcO0UfTNZxYl3JN(t, bD89rXLF0J94DXDJgjF.ndvLR0O44d))
						{
							num2 = 18;
							continue;
						}
						if (!IL2CPP.oIWR0SOP3jjlTcWyYBY(t, KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Il2CppStringArray).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), JCwQlA5sGlTyuRZuORY.fqC5SwdxA5))
						{
							num2 = 19;
							continue;
						}
						goto IL_2C1;
					case 9:
						array = IL2CPP.B7gZYFOSlCQhRcPkuWE(t, r0IMR6LMRF77eMvdEPd.HClLWk0fY4);
						num2 = 17;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_40fe2648722c4d04bef43cdd927d6154 == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 10:
						goto IL_22D;
					case 11:
						goto IL_84;
					case 12:
						if (IL2CPP.l7sVj3OywXfXKPbF0BN(t, BD4fpgAfbgEWuCwmKMc.ktpA11NTFq))
						{
							num2 = 0;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e19113368d2b45ba8f9d5ebaa49ce5d2 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						else
						{
							if (IL2CPP.RulY2ZOJFyqsWNxGctK(t, i8Cp7LL4WH7tP8ruxcp.IK1L3NBLcC))
							{
								num2 = 21;
								continue;
							}
							if (IL2CPP.SNRYwqOpoQvK98kgqBi(t, iArNNMAXqKAVpiQpoAR.fkgAcoXZRp))
							{
								goto IL_3F9;
							}
							num2 = 8;
							if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_5b544c260d8647ebad150746ba137290 != 0)
							{
								num2 = 8;
								continue;
							}
							continue;
						}
						break;
					case 13:
						goto IL_390;
					case 14:
						goto IL_300;
					case 15:
						goto IL_2EF;
					case 16:
						goto IL_2C1;
					case 17:
						num3 = 0;
						num2 = 20;
						continue;
					case 18:
						if (IL2CPP.ysxSdlOsCSa2p6h8Nm2(t))
						{
							goto Block_4;
						}
						stringBuilder = new StringBuilder();
						num2 = 2;
						continue;
					case 19:
						goto IL_3EA;
					case 20:
						goto IL_300;
					case 21:
						goto IL_162;
					case 22:
						goto IL_41F;
					case 23:
						num3++;
						num2 = 14;
						continue;
					case 24:
						goto IL_345;
					case 25:
						goto IL_3F9;
					}
					goto Block_1;
					IL_289:
					IL2CPP.u5UiUpOm32WfgXlYNUM(stringBuilder, '>', L3pNC5qaYklcQpPam6c.HaqqZExIA8);
					num2 = 22;
					continue;
					IL_300:
					if (num3 < array.Length)
					{
						goto Block_12;
					}
					goto IL_289;
					IL_2EF:
					if (num3 != 0)
					{
						num2 = 6;
						continue;
					}
					IL_390:
					m2eLpFqjHkNaRPiWsth.muOq5LWqgj(stringBuilder, IL2CPP.RenderTypeName(array[num3], false), m2eLpFqjHkNaRPiWsth.q85qQy67LK);
					num2 = 23;
				}
				Block_4:
				num = 24;
				continue;
				Block_12:
				num = 15;
			}
			Block_1:
			goto IL_111;
			IL_84:
			return uLfVht5XqcdpSvFumbD.muOq5LWqgj(IL2CPP.RenderTypeName(IL2CPP.A4bxuTO6q24gS4WLANV(t, Vc0yi5L7073fonVVdAs.IPoLP4Ir53), false), IL2CPP.bbiWdqhzIlyFXcCC3fU(~1524453083 ^ -2103402754 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_49f6034724814fe88f4ca6e5ef134249), uLfVht5XqcdpSvFumbD.YFG5cZFN0S);
			IL_111:
			return IL2CPP.W39i36OtBj43kyF9FcK(IL2CPP.RenderTypeName(Vc0yi5L7073fonVVdAs.muOq5LWqgj(t, Vc0yi5L7073fonVVdAs.IPoLP4Ir53), false), IL2CPP.bbiWdqhzIlyFXcCC3fU(1498942091 ^ 1866175157 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_508916f527eb4b05b32762ef07dd9e52), uLfVht5XqcdpSvFumbD.YFG5cZFN0S);
			IL_162:
			return IL2CPP.W39i36OtBj43kyF9FcK(IL2CPP.RenderTypeName(IL2CPP.A4bxuTO6q24gS4WLANV(t, Vc0yi5L7073fonVVdAs.IPoLP4Ir53), false), IL2CPP.bbiWdqhzIlyFXcCC3fU(-488741256 ^ -328733335 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa), uLfVht5XqcdpSvFumbD.YFG5cZFN0S);
			IL_22D:
			return IL2CPP.W39i36OtBj43kyF9FcK(IL2CPP.RenderTypeName(t, false), hIDAYxH6DWLHIthQgC.gSCeTtiku(-583563293 ^ -681263541 ^ 446985728 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7dfb1d10537744ca9e949b6b3a3eac09), uLfVht5XqcdpSvFumbD.YFG5cZFN0S);
			IL_2C1:
			return IL2CPP.bbiWdqhzIlyFXcCC3fU(958229786 ^ 1372855152 ^ 382015976 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0272cc4de9694915be17746e515675c8);
			IL_345:
			return IL2CPP.W39i36OtBj43kyF9FcK(IL2CPP.RenderTypeName(IL2CPP.B7gZYFOSlCQhRcPkuWE(t, r0IMR6LMRF77eMvdEPd.HClLWk0fY4)[0], false), IL2CPP.bbiWdqhzIlyFXcCC3fU(--1616386354 ^ 508851874 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0272cc4de9694915be17746e515675c8), uLfVht5XqcdpSvFumbD.YFG5cZFN0S);
			IL_3EA:
			return IL2CPP.IchPbvO4spyZAfoh0uo(t).TrimIl2CppPrefix();
			IL_3F9:
			return IL2CPP.yQV7afOVXpyVgvfiBLU(t, PTKvoMLfDDsJo1Y7iZK.RMSL1lrYOT);
			IL_41F:
			return IL2CPP.umTcrJO7dSXKYJo3L78(stringBuilder, Wp12YC5qLpXaitTqQ38.MHi55JM3O7);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00008684 File Offset: 0x00006884
		private static string FullNameObfuscated(this Type t)
		{
			int num = 2;
			int num2 = num;
			CustomAttributes.ObfuscatedNameAttribute customAttribute;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (customAttribute == null)
					{
						goto IL_52;
					}
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_22f9ae9a49f143d7bbb3b03eb2446c0f == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					customAttribute = t.GetCustomAttribute<CustomAttributes.ObfuscatedNameAttribute>();
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_441278fe93ad425f9343d4f7d1692fca != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					goto IL_52;
				}
				break;
			}
			goto IL_8D;
			IL_52:
			return IL2CPP.zxQlbyO3UGYvNfIUx2Q(t, y1wUHLqoFyW6gbQN93u.la8qUHBwms);
			IL_8D:
			return customAttribute.ObfuscatedName;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00008744 File Offset: 0x00006944
		private static string TrimIl2CppPrefix(this object s)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_28;
				case 2:
					if (IL2CPP.B4uCL4Of29XDPFc8gXi(s, IL2CPP.bbiWdqhzIlyFXcCC3fU(340547543 ^ 1820965030 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_856ffe7e0c9b4de88d71070d175d49fd), rsZ3wmLIoERoV03dQL9.K8rLdSBH8T))
					{
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f6eb9387956a4e8c81dafbb2ecc8c7ab == 0)
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
			return s;
			IL_28:
			return IL2CPP.lRBROGOF7143bXXrH4l(s, IL2CPP.WKORx5O139xbXbuZJqM(IL2CPP.bbiWdqhzIlyFXcCC3fU(1105551206 ^ 142569887 ^ 1061896035 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_960a54aec0f640cd975b2d62f3e0a596), XVnj3lLiqi3Tb2vvZPs.vgGLwFYH71), LikeQqLEVWwQuKTkRO2.PyHLBfhLEu);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00008820 File Offset: 0x00006A20
		private static bool TypeHasIl2CppArrayBase(this Type type)
		{
			int num = 5;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_7B;
					case 1:
						break;
					case 2:
						goto IL_151;
					case 3:
						return false;
					case 4:
						if (!IL2CPP.LaPGH2ORvqjHBxqU4tJ(type, pepouCLGnAA0wr10ltH.QwPLrsvF81))
						{
							goto Block_5;
						}
						break;
					case 5:
						if (IL2CPP.oIWR0SOP3jjlTcWyYBY(type, null, JCwQlA5sGlTyuRZuORY.fqC5SwdxA5))
						{
							return false;
						}
						num2 = 4;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_dd9c757bd882429784d62f0e80f112e6 != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 6:
						return true;
					case 7:
						goto IL_7B;
					default:
						goto IL_7B;
					}
					type = IL2CPP.Ti3QdeONZAXFrsIZ62G(type, WlkGPlLCeVsSoCNEnkk.N1bL9EYrMB);
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_eec4384c7d0d42baa74a4dbdbdbdd8df != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_7B:
					if (IL2CPP.oIWR0SOP3jjlTcWyYBY(type, IL2CPP.MYBLC4OMgYBJuWBE3Fj(typeof(Il2CppArrayBase<>).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), JCwQlA5sGlTyuRZuORY.fqC5SwdxA5))
					{
						return true;
					}
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4f96e4bec76a4c34a19bcff463d6dc03 == 0)
					{
						num2 = 2;
					}
				}
				Block_5:
				num = 7;
			}
			return true;
			IL_151:
			return IL2CPP.ysxSdlOsCSa2p6h8Nm2(IL2CPP.skS1hCOWNdUq9B96hoM(type, sxYvEPAkSQfHMoJIih4.GLiA2wflMe));
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000898C File Offset: 0x00006B8C
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
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b5c96750853e4496814af588489331dc == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060000AC RID: 172
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_init(IntPtr domain_name);

		// Token: 0x060000AD RID: 173
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_init_utf16(IntPtr domain_name);

		// Token: 0x060000AE RID: 174
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_shutdown();

		// Token: 0x060000AF RID: 175
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_config_dir(IntPtr config_path);

		// Token: 0x060000B0 RID: 176
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_data_dir(IntPtr data_path);

		// Token: 0x060000B1 RID: 177
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_temp_dir(IntPtr temp_path);

		// Token: 0x060000B2 RID: 178
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_commandline_arguments(int argc, IntPtr argv, IntPtr basedir);

		// Token: 0x060000B3 RID: 179
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_commandline_arguments_utf16(int argc, IntPtr argv, IntPtr basedir);

		// Token: 0x060000B4 RID: 180
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_config_utf16(IntPtr executablePath);

		// Token: 0x060000B5 RID: 181
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_config(IntPtr executablePath);

		// Token: 0x060000B6 RID: 182
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_memory_callbacks(IntPtr callbacks);

		// Token: 0x060000B7 RID: 183
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_get_corlib();

		// Token: 0x060000B8 RID: 184
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_add_internal_call(IntPtr name, IntPtr method);

		// Token: 0x060000B9 RID: 185
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_resolve_icall([MarshalAs(UnmanagedType.LPStr)] string name);

		// Token: 0x060000BA RID: 186
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_alloc(uint size);

		// Token: 0x060000BB RID: 187
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_free(IntPtr ptr);

		// Token: 0x060000BC RID: 188
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_array_class_get(IntPtr element_class, uint rank);

		// Token: 0x060000BD RID: 189
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_array_length(IntPtr array);

		// Token: 0x060000BE RID: 190
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_array_get_byte_length(IntPtr array);

		// Token: 0x060000BF RID: 191
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_array_new(IntPtr elementTypeInfo, ulong length);

		// Token: 0x060000C0 RID: 192
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_array_new_specific(IntPtr arrayTypeInfo, ulong length);

		// Token: 0x060000C1 RID: 193
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_array_new_full(IntPtr array_class, ref ulong lengths, ref ulong lower_bounds);

		// Token: 0x060000C2 RID: 194
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_bounded_array_class_get(IntPtr element_class, uint rank, [MarshalAs(UnmanagedType.I1)] bool bounded);

		// Token: 0x060000C3 RID: 195
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_array_element_size(IntPtr array_class);

		// Token: 0x060000C4 RID: 196
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_assembly_get_image(IntPtr assembly);

		// Token: 0x060000C5 RID: 197
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_enum_basetype(IntPtr klass);

		// Token: 0x060000C6 RID: 198
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_generic(IntPtr klass);

		// Token: 0x060000C7 RID: 199
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_inflated(IntPtr klass);

		// Token: 0x060000C8 RID: 200
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_assignable_from(IntPtr klass, IntPtr oklass);

		// Token: 0x060000C9 RID: 201
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_subclass_of(IntPtr klass, IntPtr klassc, [MarshalAs(UnmanagedType.I1)] bool check_interfaces);

		// Token: 0x060000CA RID: 202
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_has_parent(IntPtr klass, IntPtr klassc);

		// Token: 0x060000CB RID: 203
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_from_il2cpp_type(IntPtr type);

		// Token: 0x060000CC RID: 204
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_from_name(IntPtr image, [MarshalAs(UnmanagedType.LPStr)] string namespaze, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		// Token: 0x060000CD RID: 205
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_from_system_type(IntPtr type);

		// Token: 0x060000CE RID: 206
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_element_class(IntPtr klass);

		// Token: 0x060000CF RID: 207
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_events(IntPtr klass, ref IntPtr iter);

		// Token: 0x060000D0 RID: 208
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_fields(IntPtr klass, ref IntPtr iter);

		// Token: 0x060000D1 RID: 209
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_nested_types(IntPtr klass, ref IntPtr iter);

		// Token: 0x060000D2 RID: 210
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_interfaces(IntPtr klass, ref IntPtr iter);

		// Token: 0x060000D3 RID: 211
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_properties(IntPtr klass, ref IntPtr iter);

		// Token: 0x060000D4 RID: 212
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_property_from_name(IntPtr klass, IntPtr name);

		// Token: 0x060000D5 RID: 213
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_field_from_name(IntPtr klass, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		// Token: 0x060000D6 RID: 214
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_methods(IntPtr klass, ref IntPtr iter);

		// Token: 0x060000D7 RID: 215
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_method_from_name(IntPtr klass, [MarshalAs(UnmanagedType.LPStr)] string name, int argsCount);

		// Token: 0x060000D8 RID: 216
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_name(IntPtr klass);

		// Token: 0x060000D9 RID: 217
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_namespace(IntPtr klass);

		// Token: 0x060000DA RID: 218
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_parent(IntPtr klass);

		// Token: 0x060000DB RID: 219
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_declaring_type(IntPtr klass);

		// Token: 0x060000DC RID: 220
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_class_instance_size(IntPtr klass);

		// Token: 0x060000DD RID: 221
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_class_num_fields(IntPtr enumKlass);

		// Token: 0x060000DE RID: 222
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_valuetype(IntPtr klass);

		// Token: 0x060000DF RID: 223
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_class_value_size(IntPtr klass, ref uint align);

		// Token: 0x060000E0 RID: 224
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_blittable(IntPtr klass);

		// Token: 0x060000E1 RID: 225
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_class_get_flags(IntPtr klass);

		// Token: 0x060000E2 RID: 226
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_abstract(IntPtr klass);

		// Token: 0x060000E3 RID: 227
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_interface(IntPtr klass);

		// Token: 0x060000E4 RID: 228
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_class_array_element_size(IntPtr klass);

		// Token: 0x060000E5 RID: 229
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_from_type(IntPtr type);

		// Token: 0x060000E6 RID: 230
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_type(IntPtr klass);

		// Token: 0x060000E7 RID: 231
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_class_get_type_token(IntPtr klass);

		// Token: 0x060000E8 RID: 232
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_has_attribute(IntPtr klass, IntPtr attr_class);

		// Token: 0x060000E9 RID: 233
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_has_references(IntPtr klass);

		// Token: 0x060000EA RID: 234
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_class_is_enum(IntPtr klass);

		// Token: 0x060000EB RID: 235
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_image(IntPtr klass);

		// Token: 0x060000EC RID: 236
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_class_get_assemblyname(IntPtr klass);

		// Token: 0x060000ED RID: 237
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_class_get_rank(IntPtr klass);

		// Token: 0x060000EE RID: 238
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_class_get_bitmap_size(IntPtr klass);

		// Token: 0x060000EF RID: 239
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_class_get_bitmap(IntPtr klass, ref uint bitmap);

		// Token: 0x060000F0 RID: 240
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_stats_dump_to_file(IntPtr path);

		// Token: 0x060000F1 RID: 241
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_domain_get();

		// Token: 0x060000F2 RID: 242
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_domain_assembly_open(IntPtr domain, IntPtr name);

		// Token: 0x060000F3 RID: 243
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern IntPtr* il2cpp_domain_get_assemblies(IntPtr domain, ref uint size);

		// Token: 0x060000F4 RID: 244
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_exception_from_name_msg(IntPtr image, IntPtr name_space, IntPtr name, IntPtr msg);

		// Token: 0x060000F5 RID: 245
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_get_exception_argument_null(IntPtr arg);

		// Token: 0x060000F6 RID: 246
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern void il2cpp_format_exception(IntPtr ex, void* message, int message_size);

		// Token: 0x060000F7 RID: 247
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern void il2cpp_format_stack_trace(IntPtr ex, void* output, int output_size);

		// Token: 0x060000F8 RID: 248
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_unhandled_exception(IntPtr ex);

		// Token: 0x060000F9 RID: 249
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_field_get_flags(IntPtr field);

		// Token: 0x060000FA RID: 250
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_field_get_name(IntPtr field);

		// Token: 0x060000FB RID: 251
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_field_get_parent(IntPtr field);

		// Token: 0x060000FC RID: 252
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_field_get_offset(IntPtr field);

		// Token: 0x060000FD RID: 253
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_field_get_type(IntPtr field);

		// Token: 0x060000FE RID: 254
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern void il2cpp_field_get_value(IntPtr obj, IntPtr field, void* value);

		// Token: 0x060000FF RID: 255
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_field_get_value_object(IntPtr field, IntPtr obj);

		// Token: 0x06000100 RID: 256
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_field_has_attribute(IntPtr field, IntPtr attr_class);

		// Token: 0x06000101 RID: 257
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern void il2cpp_field_set_value(IntPtr obj, IntPtr field, void* value);

		// Token: 0x06000102 RID: 258
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern void il2cpp_field_static_get_value(IntPtr field, void* value);

		// Token: 0x06000103 RID: 259
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern void il2cpp_field_static_set_value(IntPtr field, void* value);

		// Token: 0x06000104 RID: 260
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_field_set_value_object(IntPtr instance, IntPtr field, IntPtr value);

		// Token: 0x06000105 RID: 261
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_gc_collect(int maxGenerations);

		// Token: 0x06000106 RID: 262
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_gc_collect_a_little();

		// Token: 0x06000107 RID: 263
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_gc_disable();

		// Token: 0x06000108 RID: 264
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_gc_enable();

		// Token: 0x06000109 RID: 265
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_gc_is_disabled();

		// Token: 0x0600010A RID: 266
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern long il2cpp_gc_get_used_size();

		// Token: 0x0600010B RID: 267
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern long il2cpp_gc_get_heap_size();

		// Token: 0x0600010C RID: 268
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_gc_wbarrier_set_field(IntPtr obj, IntPtr targetAddress, IntPtr gcObj);

		// Token: 0x0600010D RID: 269
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_gchandle_new(IntPtr obj, [MarshalAs(UnmanagedType.I1)] bool pinned);

		// Token: 0x0600010E RID: 270
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_gchandle_new_weakref(IntPtr obj, [MarshalAs(UnmanagedType.I1)] bool track_resurrection);

		// Token: 0x0600010F RID: 271
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_gchandle_get_target(uint gchandle);

		// Token: 0x06000110 RID: 272
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_gchandle_free(uint gchandle);

		// Token: 0x06000111 RID: 273
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_unity_liveness_calculation_begin(IntPtr filter, int max_object_count, IntPtr callback, IntPtr userdata, IntPtr onWorldStarted, IntPtr onWorldStopped);

		// Token: 0x06000112 RID: 274
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_unity_liveness_calculation_end(IntPtr state);

		// Token: 0x06000113 RID: 275
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_unity_liveness_calculation_from_root(IntPtr root, IntPtr state);

		// Token: 0x06000114 RID: 276
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_unity_liveness_calculation_from_statics(IntPtr state);

		// Token: 0x06000115 RID: 277
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_method_get_return_type(IntPtr method);

		// Token: 0x06000116 RID: 278
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_method_get_declaring_type(IntPtr method);

		// Token: 0x06000117 RID: 279
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_method_get_name(IntPtr method);

		// Token: 0x06000118 RID: 280 RVA: 0x000089E0 File Offset: 0x00006BE0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr il2cpp_method_get_from_reflection(IntPtr method)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_28;
				case 2:
					if (IL2CPP.CYl4PnOCbgciD57heJg())
					{
						num2 = 1;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92a7d78565474619a2c93ca9aa734139 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					else
					{
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6fe1694df7b94e7bbaa2aab21c6a82ec == 0)
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
			goto IL_7A;
			IL_28:
			return IL2CPP._il2cpp_method_get_from_reflection(method);
			IL_7A:
			return method.method;
		}

		// Token: 0x06000119 RID: 281
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi, EntryPoint = "il2cpp_method_get_from_reflection")]
		private static extern IntPtr _il2cpp_method_get_from_reflection(IntPtr method);

		// Token: 0x0600011A RID: 282
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_method_get_object(IntPtr method, IntPtr refclass);

		// Token: 0x0600011B RID: 283
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_method_is_generic(IntPtr method);

		// Token: 0x0600011C RID: 284
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_method_is_inflated(IntPtr method);

		// Token: 0x0600011D RID: 285
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_method_is_instance(IntPtr method);

		// Token: 0x0600011E RID: 286
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_method_get_param_count(IntPtr method);

		// Token: 0x0600011F RID: 287
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_method_get_param(IntPtr method, uint index);

		// Token: 0x06000120 RID: 288
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_method_get_class(IntPtr method);

		// Token: 0x06000121 RID: 289
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_method_has_attribute(IntPtr method, IntPtr attr_class);

		// Token: 0x06000122 RID: 290
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_method_get_flags(IntPtr method, ref uint iflags);

		// Token: 0x06000123 RID: 291
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_method_get_token(IntPtr method);

		// Token: 0x06000124 RID: 292
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_method_get_param_name(IntPtr method, uint index);

		// Token: 0x06000125 RID: 293
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_profiler_install(IntPtr prof, IntPtr shutdown_callback);

		// Token: 0x06000126 RID: 294
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_profiler_install_enter_leave(IntPtr enter, IntPtr fleave);

		// Token: 0x06000127 RID: 295
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_profiler_install_allocation(IntPtr callback);

		// Token: 0x06000128 RID: 296
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_profiler_install_gc(IntPtr callback, IntPtr heap_resize_callback);

		// Token: 0x06000129 RID: 297
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_profiler_install_fileio(IntPtr callback);

		// Token: 0x0600012A RID: 298
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_profiler_install_thread(IntPtr start, IntPtr end);

		// Token: 0x0600012B RID: 299
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_property_get_flags(IntPtr prop);

		// Token: 0x0600012C RID: 300
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_property_get_get_method(IntPtr prop);

		// Token: 0x0600012D RID: 301
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_property_get_set_method(IntPtr prop);

		// Token: 0x0600012E RID: 302
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_property_get_name(IntPtr prop);

		// Token: 0x0600012F RID: 303
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_property_get_parent(IntPtr prop);

		// Token: 0x06000130 RID: 304
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_object_get_class(IntPtr obj);

		// Token: 0x06000131 RID: 305
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_object_get_size(IntPtr obj);

		// Token: 0x06000132 RID: 306
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_object_get_virtual_method(IntPtr obj, IntPtr method);

		// Token: 0x06000133 RID: 307
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_object_new(IntPtr klass);

		// Token: 0x06000134 RID: 308
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_object_unbox(IntPtr obj);

		// Token: 0x06000135 RID: 309
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_value_box(IntPtr klass, IntPtr data);

		// Token: 0x06000136 RID: 310
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_monitor_enter(IntPtr obj);

		// Token: 0x06000137 RID: 311
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_monitor_try_enter(IntPtr obj, uint timeout);

		// Token: 0x06000138 RID: 312
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_monitor_exit(IntPtr obj);

		// Token: 0x06000139 RID: 313
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_monitor_pulse(IntPtr obj);

		// Token: 0x0600013A RID: 314
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_monitor_pulse_all(IntPtr obj);

		// Token: 0x0600013B RID: 315
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_monitor_wait(IntPtr obj);

		// Token: 0x0600013C RID: 316
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_monitor_try_wait(IntPtr obj, uint timeout);

		// Token: 0x0600013D RID: 317
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern IntPtr il2cpp_runtime_invoke(IntPtr method, IntPtr obj, void** param, ref IntPtr exc);

		// Token: 0x0600013E RID: 318
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern IntPtr il2cpp_runtime_invoke_convert_args(IntPtr method, IntPtr obj, void** param, int paramCount, ref IntPtr exc);

		// Token: 0x0600013F RID: 319
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_runtime_class_init(IntPtr klass);

		// Token: 0x06000140 RID: 320
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_runtime_object_init(IntPtr obj);

		// Token: 0x06000141 RID: 321
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_runtime_object_init_exception(IntPtr obj, ref IntPtr exc);

		// Token: 0x06000142 RID: 322
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_string_length(IntPtr str);

		// Token: 0x06000143 RID: 323
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern char* il2cpp_string_chars(IntPtr str);

		// Token: 0x06000144 RID: 324
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_string_new(string str);

		// Token: 0x06000145 RID: 325
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_string_new_len(string str, uint length);

		// Token: 0x06000146 RID: 326
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern IntPtr il2cpp_string_new_utf16(char* text, int len);

		// Token: 0x06000147 RID: 327
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_string_new_wrapper(string str);

		// Token: 0x06000148 RID: 328
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_string_intern(string str);

		// Token: 0x06000149 RID: 329
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_string_is_interned(string str);

		// Token: 0x0600014A RID: 330
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_thread_current();

		// Token: 0x0600014B RID: 331
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_thread_attach(IntPtr domain);

		// Token: 0x0600014C RID: 332
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_thread_detach(IntPtr thread);

		// Token: 0x0600014D RID: 333
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern void** il2cpp_thread_get_all_attached_threads(ref uint size);

		// Token: 0x0600014E RID: 334
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_is_vm_thread(IntPtr thread);

		// Token: 0x0600014F RID: 335
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_current_thread_walk_frame_stack(IntPtr func, IntPtr user_data);

		// Token: 0x06000150 RID: 336
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_thread_walk_frame_stack(IntPtr thread, IntPtr func, IntPtr user_data);

		// Token: 0x06000151 RID: 337
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_current_thread_get_top_frame(IntPtr frame);

		// Token: 0x06000152 RID: 338
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_thread_get_top_frame(IntPtr thread, IntPtr frame);

		// Token: 0x06000153 RID: 339
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_current_thread_get_frame_at(int offset, IntPtr frame);

		// Token: 0x06000154 RID: 340
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_thread_get_frame_at(IntPtr thread, int offset, IntPtr frame);

		// Token: 0x06000155 RID: 341
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_current_thread_get_stack_depth();

		// Token: 0x06000156 RID: 342
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_thread_get_stack_depth(IntPtr thread);

		// Token: 0x06000157 RID: 343
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_type_get_object(IntPtr type);

		// Token: 0x06000158 RID: 344
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern int il2cpp_type_get_type(IntPtr type);

		// Token: 0x06000159 RID: 345
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_type_get_class_or_element_class(IntPtr type);

		// Token: 0x0600015A RID: 346
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_type_get_name(IntPtr type);

		// Token: 0x0600015B RID: 347
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_type_is_byref(IntPtr type);

		// Token: 0x0600015C RID: 348
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_type_get_attrs(IntPtr type);

		// Token: 0x0600015D RID: 349
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_type_equals(IntPtr type, IntPtr otherType);

		// Token: 0x0600015E RID: 350
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_type_get_assembly_qualified_name(IntPtr type);

		// Token: 0x0600015F RID: 351
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_image_get_assembly(IntPtr image);

		// Token: 0x06000160 RID: 352
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_image_get_name(IntPtr image);

		// Token: 0x06000161 RID: 353
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_image_get_filename(IntPtr image);

		// Token: 0x06000162 RID: 354
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_image_get_entry_point(IntPtr image);

		// Token: 0x06000163 RID: 355
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern uint il2cpp_image_get_class_count(IntPtr image);

		// Token: 0x06000164 RID: 356
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_image_get_class(IntPtr image, uint index);

		// Token: 0x06000165 RID: 357
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_capture_memory_snapshot();

		// Token: 0x06000166 RID: 358
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_free_captured_memory_snapshot(IntPtr snapshot);

		// Token: 0x06000167 RID: 359
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_set_find_plugin_callback(IntPtr method);

		// Token: 0x06000168 RID: 360
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_register_log_callback(IntPtr method);

		// Token: 0x06000169 RID: 361
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_debugger_set_agent_options(IntPtr options);

		// Token: 0x0600016A RID: 362
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_is_debugger_attached();

		// Token: 0x0600016B RID: 363
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public unsafe static extern void il2cpp_unity_install_unitytls_interface(void* unitytlsInterfaceStruct);

		// Token: 0x0600016C RID: 364
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_custom_attrs_from_class(IntPtr klass);

		// Token: 0x0600016D RID: 365
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_custom_attrs_from_method(IntPtr method);

		// Token: 0x0600016E RID: 366
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_custom_attrs_get_attr(IntPtr ainfo, IntPtr attr_klass);

		// Token: 0x0600016F RID: 367
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool il2cpp_custom_attrs_has_attr(IntPtr ainfo, IntPtr attr_klass);

		// Token: 0x06000170 RID: 368
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern IntPtr il2cpp_custom_attrs_construct(IntPtr cinfo);

		// Token: 0x06000171 RID: 369
		[DllImport("GameAssembly", CallingConvention = 2, CharSet = CharSet.Ansi)]
		public static extern void il2cpp_custom_attrs_free(IntPtr ainfo);

		// Token: 0x06000172 RID: 370 RVA: 0x00008A70 File Offset: 0x00006C70
		internal static void uJK0VHhamrFbZU0PAWM()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00008A78 File Offset: 0x00006C78
		internal static void GZmnfvhZbFgFixTRS6C()
		{
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00008A80 File Offset: 0x00006C80
		internal static object bbiWdqhzIlyFXcCC3fU(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00008A8C File Offset: 0x00006C8C
		internal static object SMf5IjOlFKjd5nuZl0F(IntPtr ptr)
		{
			return MarshalExtend.PtrToString(ptr);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00008A98 File Offset: 0x00006C98
		internal static bool Smq6GCOqlVdSiuYkpED(object A_0)
		{
			return A_0.IsObfuscated();
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00008AA4 File Offset: 0x00006CA4
		internal static bool zi9s07he3mpk4U12Akn()
		{
			return IL2CPP.p6ZIyqhQeGeLkPHawyA == null;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00008AB0 File Offset: 0x00006CB0
		internal static IL2CPP pRCmr9hKvETwlVl5MUg()
		{
			return IL2CPP.p6ZIyqhQeGeLkPHawyA;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00008AB8 File Offset: 0x00006CB8
		internal static char fJhICWO5tGE85eLVls7(object A_0, int A_1, object A_2)
		{
			return YL0AxBAagUmuljcLtI3.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00008ACC File Offset: 0x00006CCC
		internal static bool g3sy1sOAebEJalrCjcq(char A_0, object A_1)
		{
			return nGt75TAzVTkWVu9307q.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00008ADC File Offset: 0x00006CDC
		internal static bool ufxDS8OLJw47k1UWLQw(object A_0, object A_1, object A_2)
		{
			return XXsbDZLXBpXOTAuVQqA.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00008AF0 File Offset: 0x00006CF0
		internal static object cYL3yUOXjbCgKWAcX8X(object A_0, object A_1, object A_2, object A_3, object A_4)
		{
			return KUcPF8qN05KKuwdEiA1.muOq5LWqgj(A_0, A_1, A_2, A_3, A_4);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00008B0C File Offset: 0x00006D0C
		internal static IntPtr pDmADQOcma9J5bo2gxj(object A_0)
		{
			return NativeStructUtils.GetMethodInfoForMissingMethod(A_0);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00008B18 File Offset: 0x00006D18
		internal static object PSnHYEOkqUZPpSVC9Ne(object A_0, object A_1, object A_2)
		{
			return pUpARsLHLyKY1GdSMar.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00008B2C File Offset: 0x00006D2C
		internal static object AOdwnQO2dVfChAmtUbF(object A_0, object A_1, object A_2, object A_3)
		{
			return fhthINLOyrFIG1Wkwkk.muOq5LWqgj(A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00008B44 File Offset: 0x00006D44
		internal static object RdPHVTOHnqYkWZ0Pq9L(object A_0, char A_1, char A_2, object A_3)
		{
			return zndYDNLvolVdGcenNrM.muOq5LWqgj(A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00008B5C File Offset: 0x00006D5C
		internal static bool BoBNyPOhISo7gg7SDj6(object A_0, object A_1, object A_2)
		{
			return Qb3kHiAJfQfbhOqjpaj.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00008B70 File Offset: 0x00006D70
		internal static void xbPOsGOO9lW4uyNyVCc(object A_0)
		{
			Logger.LogDebug(A_0);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00008B7C File Offset: 0x00006D7C
		internal static object W39i36OtBj43kyF9FcK(object A_0, object A_1, object A_2)
		{
			return uLfVht5XqcdpSvFumbD.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00008B90 File Offset: 0x00006D90
		internal static object aJlBMHOv8MxUMbKn6yS(object A_0, object A_1)
		{
			return lonhQ4LY1oN1lRp0a4i.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00008BA0 File Offset: 0x00006DA0
		internal static int ElI3UCOxbCvQqpDdHkX(object A_0, object A_1)
		{
			return zcv4yQLqdIM9E4xdCpN.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00008BB0 File Offset: 0x00006DB0
		internal static IntPtr XxGyoYOYriugMRDA1Pj(IntPtr enclosingClass, object A_1)
		{
			return RuntimeReflectionHelper.GetNestedTypeViaReflection(enclosingClass, A_1);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00008BC0 File Offset: 0x00006DC0
		internal static int yYtau2O8IHIYwUcsFd3(object A_0, object A_1, object A_2)
		{
			return PeofPkL6bNG0bjS3T48.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00008BD4 File Offset: 0x00006DD4
		internal static int JL4Ax6OnXOvuDiY0gyf(object A_0, char A_1, object A_2)
		{
			return NUqNn4LJ4BD2wh0AoTB.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00008BE8 File Offset: 0x00006DE8
		internal static object ndDFXMObK9PjHfuR619(object A_0, int A_1, int A_2, object A_3)
		{
			return q9OgZiLVxnaY9ejTXLM.muOq5LWqgj(A_0, A_1, A_2, A_3);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00008C00 File Offset: 0x00006E00
		internal static Type A4bxuTO6q24gS4WLANV(object A_0, object A_1)
		{
			return Vc0yi5L7073fonVVdAs.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00008C10 File Offset: 0x00006E10
		internal static bool l7sVj3OywXfXKPbF0BN(object A_0, object A_1)
		{
			return BD4fpgAfbgEWuCwmKMc.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00008C20 File Offset: 0x00006E20
		internal static bool RulY2ZOJFyqsWNxGctK(object A_0, object A_1)
		{
			return i8Cp7LL4WH7tP8ruxcp.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00008C30 File Offset: 0x00006E30
		internal static bool SNRYwqOpoQvK98kgqBi(object A_0, object A_1)
		{
			return iArNNMAXqKAVpiQpoAR.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00008C40 File Offset: 0x00006E40
		internal static object yQV7afOVXpyVgvfiBLU(object A_0, object A_1)
		{
			return PTKvoMLfDDsJo1Y7iZK.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00008C50 File Offset: 0x00006E50
		internal static bool oHuvmcO0UfTNZxYl3JN(object A_0, object A_1)
		{
			return bD89rXLF0J94DXDJgjF.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00008C60 File Offset: 0x00006E60
		internal static bool ysxSdlOsCSa2p6h8Nm2(Type type)
		{
			return type.TypeHasIl2CppArrayBase();
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00008C6C File Offset: 0x00006E6C
		internal static object B7gZYFOSlCQhRcPkuWE(object A_0, object A_1)
		{
			return r0IMR6LMRF77eMvdEPd.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00008C7C File Offset: 0x00006E7C
		internal static Type Ti3QdeONZAXFrsIZ62G(object A_0, object A_1)
		{
			return WlkGPlLCeVsSoCNEnkk.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00008C8C File Offset: 0x00006E8C
		internal static object i4VxBIOu0ZkUDA6FOAG(object A_0)
		{
			return A_0.TrimIl2CppPrefix();
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00008C98 File Offset: 0x00006E98
		internal static object W6AA2nODAqeWHSbwH0j(object A_0, object A_1, object A_2)
		{
			return m2eLpFqjHkNaRPiWsth.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00008CAC File Offset: 0x00006EAC
		internal static object u5UiUpOm32WfgXlYNUM(object A_0, char A_1, object A_2)
		{
			return L3pNC5qaYklcQpPam6c.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00008CC0 File Offset: 0x00006EC0
		internal static object umTcrJO7dSXKYJo3L78(object A_0, object A_1)
		{
			return Wp12YC5qLpXaitTqQ38.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00008CD0 File Offset: 0x00006ED0
		internal static bool oIWR0SOP3jjlTcWyYBY(Type A_0, Type A_1, object A_2)
		{
			return JCwQlA5sGlTyuRZuORY.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00008CE4 File Offset: 0x00006EE4
		internal static object IchPbvO4spyZAfoh0uo(Type t)
		{
			return t.FullNameObfuscated();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00008CF0 File Offset: 0x00006EF0
		internal static object zxQlbyO3UGYvNfIUx2Q(object A_0, object A_1)
		{
			return y1wUHLqoFyW6gbQN93u.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00008D00 File Offset: 0x00006F00
		internal static bool B4uCL4Of29XDPFc8gXi(object A_0, object A_1, object A_2)
		{
			return rsZ3wmLIoERoV03dQL9.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00008D14 File Offset: 0x00006F14
		internal static int WKORx5O139xbXbuZJqM(object A_0, object A_1)
		{
			return XVnj3lLiqi3Tb2vvZPs.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00008D24 File Offset: 0x00006F24
		internal static object lRBROGOF7143bXXrH4l(object A_0, int A_1, object A_2)
		{
			return LikeQqLEVWwQuKTkRO2.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00008D38 File Offset: 0x00006F38
		internal static bool LaPGH2ORvqjHBxqU4tJ(object A_0, object A_1)
		{
			return pepouCLGnAA0wr10ltH.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00008D48 File Offset: 0x00006F48
		internal static Type MYBLC4OMgYBJuWBE3Fj(RuntimeTypeHandle A_0, object A_1)
		{
			return KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00008D58 File Offset: 0x00006F58
		internal static Type skS1hCOWNdUq9B96hoM(object A_0, object A_1)
		{
			return sxYvEPAkSQfHMoJIih4.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00008D68 File Offset: 0x00006F68
		internal static bool CYl4PnOCbgciD57heJg()
		{
			return UnityVersionHandler.HasGetMethodFromReflection;
		}

		// Token: 0x0400001B RID: 27
		public static readonly Dictionary<string, IntPtr> ImageMap;

		// Token: 0x0400001C RID: 28
		public static readonly Dictionary<ValueTuple<IntPtr, string>, IntPtr> FallbackClasses;

		// Token: 0x0400001D RID: 29
		private static IL2CPP p6ZIyqhQeGeLkPHawyA;
	}
}
