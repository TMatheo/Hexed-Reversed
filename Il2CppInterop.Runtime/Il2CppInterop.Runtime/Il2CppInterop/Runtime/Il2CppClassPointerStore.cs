using System;
using Il2CppSystem;
using MaoFcf2Vq4taIANM6n;

namespace Il2CppInterop.Runtime
{
	// Token: 0x0200000B RID: 11
	public static class Il2CppClassPointerStore
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x00009830 File Offset: 0x00007A30
		public static IntPtr GetNativeClassPointer(Type type)
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					goto IL_37;
				case 1:
					goto IL_D5;
				case 2:
					if (Il2CppClassPointerStore.rBrX4NxUgUHVFv22Em6(type, Il2CppClassPointerStore.RajpBKxAE0YjBU5GQcO(typeof(String).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), dPsigOUwJdO4bwskNJ5.hvvUeCiIEf))
					{
						goto IL_37;
					}
					num2 = 4;
					break;
				case 3:
					if (Il2CppClassPointerStore.rBrX4NxUgUHVFv22Em6(type, Il2CppClassPointerStore.RajpBKxAE0YjBU5GQcO(typeof(void).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), dPsigOUwJdO4bwskNJ5.hvvUeCiIEf))
					{
						goto IL_D5;
					}
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ce81190098cb44f1b9a77ca4822d7770 == 0)
					{
						num2 = 2;
					}
					break;
				case 4:
					goto IL_104;
				}
			}
			IL_37:
			return Il2CppClassPointerStore<string>.NativeClassPtr;
			IL_D5:
			return Il2CppClassPointerStore<Void>.NativeClassPtr;
			IL_104:
			return (IntPtr)Il2CppClassPointerStore.rQvKDbxIffLTQyhSO6v(Il2CppClassPointerStore.QBq90Exi8Eqn3KEeySf(Il2CppClassPointerStore.efhmMkxqWAc3HTXNEej(Il2CppClassPointerStore.RajpBKxAE0YjBU5GQcO(typeof(Il2CppClassPointerStore<>).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), new Type[]
			{
				type
			}, F9k0QHqwuAF4DuGYBHT.AMmqeBVp2m), Il2CppClassPointerStore.n9jibmx9ACJMmmSn27L(~-164793095 ^ 1509003184 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_be54e2986e644667aed0d52d0affe157), e9JbcIqsAv7s4t2ydLY.Ib4qQ8dvnX), null, GYhvdXq2oldr1eq9pKe.gf2qyBPuV5);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00009988 File Offset: 0x00007B88
		internal static void SetNativeClassPointer(Type type, IntPtr value)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					Il2CppClassPointerStore.KfH2kPxGioFa6xXWT71(Il2CppClassPointerStore.QBq90Exi8Eqn3KEeySf(Il2CppClassPointerStore.efhmMkxqWAc3HTXNEej(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Il2CppClassPointerStore<>).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), new Type[]
					{
						type
					}, F9k0QHqwuAF4DuGYBHT.AMmqeBVp2m), Il2CppClassPointerStore.n9jibmx9ACJMmmSn27L(767765750 - -76668076 ^ 1981341341 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5d181dabf1ed42eca63023d24d927754), e9JbcIqsAv7s4t2ydLY.Ib4qQ8dvnX), null, value, ExKpTG9zgZI9MvmWbMm.NR0iHAwMQm);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_e0435cb0909b493e882d051900e9ae38 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00009A40 File Offset: 0x00007C40
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppClassPointerStore()
		{
			Il2CppClassPointerStore.AFGVpJxYfcUChGo85Cm();
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00009A50 File Offset: 0x00007C50
		internal static Type RajpBKxAE0YjBU5GQcO(RuntimeTypeHandle A_0, object A_1)
		{
			return byRw0gA2NyqHkl03ii9.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00009A68 File Offset: 0x00007C68
		internal static bool rBrX4NxUgUHVFv22Em6(Type A_0, Type A_1, object A_2)
		{
			return dPsigOUwJdO4bwskNJ5.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00009A84 File Offset: 0x00007C84
		internal static Type efhmMkxqWAc3HTXNEej(object A_0, object A_1, object A_2)
		{
			return F9k0QHqwuAF4DuGYBHT.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00009AA0 File Offset: 0x00007CA0
		internal static object n9jibmx9ACJMmmSn27L(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00009AB4 File Offset: 0x00007CB4
		internal static object QBq90Exi8Eqn3KEeySf(object A_0, object A_1, object A_2)
		{
			return e9JbcIqsAv7s4t2ydLY.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00009AD0 File Offset: 0x00007CD0
		internal static object rQvKDbxIffLTQyhSO6v(object A_0, object A_1, object A_2)
		{
			return GYhvdXq2oldr1eq9pKe.i2IAUFsOOC(A_0, A_1, A_2);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00009AEC File Offset: 0x00007CEC
		internal static bool m1GX75tznwTC6jVSmCL()
		{
			return Il2CppClassPointerStore.AK7hcht4GhM57EGS0Sd == null;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00009B00 File Offset: 0x00007D00
		internal static Il2CppClassPointerStore TwGdZXxHA8ftxYw6Hcp()
		{
			return Il2CppClassPointerStore.AK7hcht4GhM57EGS0Sd;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00009B10 File Offset: 0x00007D10
		internal static void KfH2kPxGioFa6xXWT71(object A_0, object A_1, object A_2, object A_3)
		{
			ExKpTG9zgZI9MvmWbMm.i2IAUFsOOC(A_0, A_1, A_2, A_3);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00009B30 File Offset: 0x00007D30
		internal static void AFGVpJxYfcUChGo85Cm()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000021 RID: 33
		internal static Il2CppClassPointerStore AK7hcht4GhM57EGS0Sd;
	}
}
