using System;
using Il2CppSystem;
using MaoFcf2Vq4taIANM6n;

namespace Il2CppInterop.Runtime
{
	// Token: 0x0200000F RID: 15
	public static class Il2CppType
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x0000A56C File Offset: 0x0000876C
		public static Type TypeFromPointer(IntPtr classPointer, string typeName = "<unknown type>")
		{
			return Il2CppType.U0lR9txRc7MZPv6tVlU(classPointer, typeName, true);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000A580 File Offset: 0x00008780
		private static Type TypeFromPointerInternal(IntPtr classPointer, object typeName, bool throwOnFailure)
		{
			int num = 3;
			int num2 = num;
			IntPtr intPtr;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_100;
				case 2:
					if (!throwOnFailure)
					{
						goto IL_12C;
					}
					num2 = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2210d7ca22c24335b32d80ca3ef84b8e != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					if (classPointer == IntPtr.Zero)
					{
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2b24b0de55344c2b8aaf8116dbc4d16 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					else
					{
						intPtr = IL2CPP.il2cpp_class_get_type(classPointer);
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_636316cf576545aba2f7d326dd7e140b != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					break;
				case 4:
					if (intPtr == IntPtr.Zero)
					{
						num2 = 5;
						continue;
					}
					goto IL_DD;
				case 5:
					if (!throwOnFailure)
					{
						goto IL_DB;
					}
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5a8626d471f54eba873ce59c8785d9b9 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			throw new ArgumentException(Il2CppType.wIMxyVxkhDNsoPn1Dd6(typeName, Il2CppType.krnZdnxJKcncsJmkwko(-813371636 ^ -193111881 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_c4640bbaac7c4988b56f91d1b6b3f1a9), z4S0e1U05BsRVVK2fNl.aarUNWns9V));
			IL_DB:
			return null;
			IL_DD:
			return u17VAkqcirg8uZTulMb.i2IAUFsOOC(intPtr, u17VAkqcirg8uZTulMb.sHiq69QE45);
			IL_100:
			throw new ArgumentException(Il2CppType.wIMxyVxkhDNsoPn1Dd6(typeName, hIDAYxH6DWLHIthQgC.gSCeTtiku(386187679 ^ 1508406635 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f65b5965aa9843ea8b738fef02a2c6c9), z4S0e1U05BsRVVK2fNl.aarUNWns9V));
			IL_12C:
			return null;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000A6E4 File Offset: 0x000088E4
		public static Type From(Type type)
		{
			return Il2CppType.From(type, true);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000A6F4 File Offset: 0x000088F4
		public static Type From(Type type, bool throwOnFailure)
		{
			return Il2CppType.U0lR9txRc7MZPv6tVlU(Il2CppClassPointerStore.GetNativeClassPointer(type), Il2CppType.EQXkvTxWjdEp9Z0aJsT(type, el3Dwo9OYrba9URt3tt.qs29XcBOk2), throwOnFailure);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000A714 File Offset: 0x00008914
		public static Type Of<T>()
		{
			return Il2CppType.Of<T>(true);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000A724 File Offset: 0x00008924
		public static Type Of<T>(bool throwOnFailure)
		{
			return Il2CppType.TypeFromPointerInternal(Il2CppClassPointerStore<T>.NativeClassPtr, el3Dwo9OYrba9URt3tt.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), el3Dwo9OYrba9URt3tt.qs29XcBOk2), throwOnFailure);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000A754 File Offset: 0x00008954
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppType()
		{
			Il2CppType.RS9LrpxrHxoxb8mpOZH();
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000A764 File Offset: 0x00008964
		internal static object U0lR9txRc7MZPv6tVlU(IntPtr classPointer, object A_1, bool throwOnFailure)
		{
			return Il2CppType.TypeFromPointerInternal(classPointer, A_1, throwOnFailure);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000A780 File Offset: 0x00008980
		internal static bool HYuWNcxLNASSi6cbrhk()
		{
			return Il2CppType.FGNmJmx6njIe3VhxqMP == null;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000A794 File Offset: 0x00008994
		internal static Il2CppType yYc0eox7p1707XOoUjI()
		{
			return Il2CppType.FGNmJmx6njIe3VhxqMP;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000A7A4 File Offset: 0x000089A4
		internal static object wIMxyVxkhDNsoPn1Dd6(object A_0, object A_1, object A_2)
		{
			return z4S0e1U05BsRVVK2fNl.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000A7C0 File Offset: 0x000089C0
		internal static object krnZdnxJKcncsJmkwko(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000A7D4 File Offset: 0x000089D4
		internal static object EQXkvTxWjdEp9Z0aJsT(object A_0, object A_1)
		{
			return el3Dwo9OYrba9URt3tt.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000A7EC File Offset: 0x000089EC
		internal static void RS9LrpxrHxoxb8mpOZH()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400002A RID: 42
		internal static Il2CppType FGNmJmx6njIe3VhxqMP;
	}
}
