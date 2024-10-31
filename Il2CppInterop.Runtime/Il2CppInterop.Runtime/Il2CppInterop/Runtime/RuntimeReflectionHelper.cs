using System;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using MaoFcf2Vq4taIANM6n;

namespace Il2CppInterop.Runtime
{
	// Token: 0x02000013 RID: 19
	public static class RuntimeReflectionHelper
	{
		// Token: 0x06000203 RID: 515 RVA: 0x0000A740 File Offset: 0x00008940
		public static IntPtr GetNestedTypeViaReflection(IntPtr enclosingClass, string nestedTypeName)
		{
			int num = 1;
			int num2 = num;
			Type type;
			for (;;)
			{
				switch (num2)
				{
				default:
					if (RuntimeReflectionHelper.jaotkTtMxFTZKSjEMt1(type, null, ccUJLqXjtZmhf9IK1m7.iTHXQhEaUj))
					{
						goto IL_A4;
					}
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6776fc69415b4d309be658e7e8ac3a28 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					type = RuntimeReflectionHelper.dfTfJstR97B52w7bh0K(RuntimeReflectionHelper.w886YntFH35EFS1ZR7k(IL2CPP.il2cpp_class_get_type(enclosingClass), UesPrPAH73jB0XWSnsx.bGYAhJSFUo), nestedTypeName, 48, Nn9vJ2Xo1pg1NgHYipk.C4CXUWkS1g);
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_be7c67937fc746d2ad6f8cd47b555de7 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					goto IL_9E;
				}
			}
			IL_9E:
			return IntPtr.Zero;
			IL_A4:
			return IL2CPP.il2cpp_class_from_system_type(RuntimeReflectionHelper.x2qULptWeHhGVaMAuyd(type));
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000A800 File Offset: 0x00008A00
		public static RuntimeTypeHandle GetRuntimeTypeHandle<T>()
		{
			return jUanqkXeicoxVrqYLpO.muOq5LWqgj(Il2CppType.Of<T>(), jUanqkXeicoxVrqYLpO.D8EXKIxH5o);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000A818 File Offset: 0x00008A18
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeReflectionHelper()
		{
			RuntimeReflectionHelper.r4eqFxtCgMe5NG1968l();
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000A828 File Offset: 0x00008A28
		internal static object w886YntFH35EFS1ZR7k(IntPtr A_0, object A_1)
		{
			return UesPrPAH73jB0XWSnsx.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000A840 File Offset: 0x00008A40
		internal static object dfTfJstR97B52w7bh0K(object A_0, object A_1, BindingFlags A_2, object A_3)
		{
			return Nn9vJ2Xo1pg1NgHYipk.muOq5LWqgj(A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000A860 File Offset: 0x00008A60
		internal static bool jaotkTtMxFTZKSjEMt1(object A_0, object A_1, object A_2)
		{
			return ccUJLqXjtZmhf9IK1m7.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000A87C File Offset: 0x00008A7C
		internal static IntPtr x2qULptWeHhGVaMAuyd(object A_0)
		{
			return A_0.Pointer;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000A890 File Offset: 0x00008A90
		internal static bool VA4yU4tf9Cn1xxh35Ru()
		{
			return RuntimeReflectionHelper.G7cwTnt3rFMsnAB6lqr == null;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000A8A4 File Offset: 0x00008AA4
		internal static RuntimeReflectionHelper qhaNXgt1MGLSQUj0Sf6()
		{
			return RuntimeReflectionHelper.G7cwTnt3rFMsnAB6lqr;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000A8B4 File Offset: 0x00008AB4
		internal static void r4eqFxtCgMe5NG1968l()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000037 RID: 55
		private static RuntimeReflectionHelper G7cwTnt3rFMsnAB6lqr;
	}
}
