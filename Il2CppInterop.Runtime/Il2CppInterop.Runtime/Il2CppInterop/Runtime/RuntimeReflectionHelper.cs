using System;
using Il2CppSystem;
using MaoFcf2Vq4taIANM6n;

namespace Il2CppInterop.Runtime
{
	// Token: 0x02000013 RID: 19
	public static class RuntimeReflectionHelper
	{
		// Token: 0x0600021F RID: 543 RVA: 0x0000B20C File Offset: 0x0000940C
		public static IntPtr GetNestedTypeViaReflection(IntPtr enclosingClass, string nestedTypeName)
		{
			int num = 1;
			int num2 = num;
			Type type;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					type = vA5hciIAaLmwRJo7Vr0.i2IAUFsOOC(RuntimeReflectionHelper.PLusk6xFNqqCHS5GxBo(IL2CPP.il2cpp_class_get_type(enclosingClass), u17VAkqcirg8uZTulMb.sHiq69QE45), nestedTypeName, 48, vA5hciIAaLmwRJo7Vr0.lnoIUZVN3U);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_17522b2a3ddb488c87b7266d3b1f941d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					goto IL_33;
				case 3:
					goto IL_73;
				}
				if (!RuntimeReflectionHelper.WnXkQdxKrXMGZvXS2Hf(type, null, xmtnXiIq216ltw1lIgY.wVdI9t9s4k))
				{
					goto IL_73;
				}
				num2 = 2;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ac98984015b94d6a931f8affda832ec9 != 0)
				{
					num2 = 2;
				}
			}
			IL_33:
			return IL2CPP.il2cpp_class_from_system_type(RuntimeReflectionHelper.QNpVOqx54I5t4TGkQbU(type));
			IL_73:
			return IntPtr.Zero;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000B2DC File Offset: 0x000094DC
		public static RuntimeTypeHandle GetRuntimeTypeHandle<T>()
		{
			return uGBFWSIiCC3BWMWAE0g.i2IAUFsOOC(Il2CppType.Of<T>(), uGBFWSIiCC3BWMWAE0g.NQBIIQKkTR);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000B2F4 File Offset: 0x000094F4
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeReflectionHelper()
		{
			RuntimeReflectionHelper.ufnR7txnuxdseFKiGVo();
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000B304 File Offset: 0x00009504
		internal static object PLusk6xFNqqCHS5GxBo(IntPtr A_0, object A_1)
		{
			return u17VAkqcirg8uZTulMb.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000B31C File Offset: 0x0000951C
		internal static bool WnXkQdxKrXMGZvXS2Hf(object A_0, object A_1, object A_2)
		{
			return xmtnXiIq216ltw1lIgY.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000B338 File Offset: 0x00009538
		internal static IntPtr QNpVOqx54I5t4TGkQbU(object A_0)
		{
			return A_0.Pointer;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000B34C File Offset: 0x0000954C
		internal static bool SrefKUxjLQVQ4YaGUl1()
		{
			return RuntimeReflectionHelper.lgEhM4xBiAJGfxHVLSJ == null;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000B360 File Offset: 0x00009560
		internal static RuntimeReflectionHelper NDYHyRxT05fYnArNaZA()
		{
			return RuntimeReflectionHelper.lgEhM4xBiAJGfxHVLSJ;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000B370 File Offset: 0x00009570
		internal static void ufnR7txnuxdseFKiGVo()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000037 RID: 55
		internal static RuntimeReflectionHelper lgEhM4xBiAJGfxHVLSJ;
	}
}
