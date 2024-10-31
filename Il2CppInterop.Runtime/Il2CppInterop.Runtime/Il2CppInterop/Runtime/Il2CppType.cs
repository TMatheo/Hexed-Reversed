using System;
using Il2CppSystem;
using MaoFcf2Vq4taIANM6n;

namespace Il2CppInterop.Runtime
{
	// Token: 0x0200000F RID: 15
	public static class Il2CppType
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x00009A20 File Offset: 0x00007C20
		public static Type TypeFromPointer(IntPtr classPointer, string typeName = "<unknown type>")
		{
			return Il2CppType.TypeFromPointerInternal(classPointer, typeName, true);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00009A34 File Offset: 0x00007C34
		private static Type TypeFromPointerInternal(IntPtr classPointer, object typeName, bool throwOnFailure)
		{
			int num = 1;
			int num2 = num;
			IntPtr intPtr;
			for (;;)
			{
				switch (num2)
				{
				default:
					if (throwOnFailure)
					{
						goto IL_63;
					}
					num2 = 3;
					break;
				case 1:
					if (classPointer == IntPtr.Zero)
					{
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_0299b24d936d41acaea60798c25b2a4b != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						intPtr = IL2CPP.il2cpp_class_get_type(classPointer);
						num2 = 5;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4c6a46c0a2d14747aa1dc5bf1581154d != 0)
						{
							num2 = 4;
						}
					}
					break;
				case 2:
					if (throwOnFailure)
					{
						goto IL_113;
					}
					num2 = 4;
					break;
				case 3:
					goto IL_178;
				case 4:
					goto IL_154;
				case 5:
					if (intPtr != IntPtr.Zero)
					{
						goto IL_147;
					}
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_791a252a9221476faad2c6d41e84a167 != 0)
					{
						num2 = 2;
					}
					break;
				case 6:
					goto IL_63;
				case 7:
					goto IL_113;
				}
			}
			IL_63:
			throw new ArgumentException(uLfVht5XqcdpSvFumbD.muOq5LWqgj(typeName, Il2CppType.RxhTIVtAqYFbnB8Eu7O(-1039001447 >> 2 ^ -2041212824 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_960a54aec0f640cd975b2d62f3e0a596), uLfVht5XqcdpSvFumbD.YFG5cZFN0S));
			IL_113:
			throw new ArgumentException(Il2CppType.Wics4stLJmvAwgkRMvo(typeName, hIDAYxH6DWLHIthQgC.gSCeTtiku(849699899 + -32398930 ^ 1311417082 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_441278fe93ad425f9343d4f7d1692fca), uLfVht5XqcdpSvFumbD.YFG5cZFN0S));
			IL_147:
			return Il2CppType.a2aIcptXovkChuwj4w0(intPtr, UesPrPAH73jB0XWSnsx.bGYAhJSFUo);
			IL_154:
			return null;
			IL_178:
			return null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00009BC8 File Offset: 0x00007DC8
		public static Type From(Type type)
		{
			return Il2CppType.From(type, true);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00009BD8 File Offset: 0x00007DD8
		public static Type From(Type type, bool throwOnFailure)
		{
			return Il2CppType.chhsNdt29kN70O9xpP9(Il2CppType.SlAQcktcmccktYkiJ8E(type), Il2CppType.T7P37Vtk9ZNsYojYw7R(type, PTKvoMLfDDsJo1Y7iZK.RMSL1lrYOT), throwOnFailure);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00009BF8 File Offset: 0x00007DF8
		public static Type Of<T>()
		{
			return Il2CppType.Of<T>(true);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00009C08 File Offset: 0x00007E08
		public static Type Of<T>(bool throwOnFailure)
		{
			return Il2CppType.TypeFromPointerInternal(Il2CppClassPointerStore<T>.NativeClassPtr, PTKvoMLfDDsJo1Y7iZK.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), PTKvoMLfDDsJo1Y7iZK.RMSL1lrYOT), throwOnFailure);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00009C38 File Offset: 0x00007E38
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppType()
		{
			Il2CppType.qtQrNGtHJgZTmXNYPAu();
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00009C48 File Offset: 0x00007E48
		internal static bool truyWatqu5ydqQHapwU()
		{
			return Il2CppType.HjPkSVtlcor7enr47dX == null;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00009C5C File Offset: 0x00007E5C
		internal static Il2CppType lcGDcbt54rKpXNfr4Fs()
		{
			return Il2CppType.HjPkSVtlcor7enr47dX;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00009C6C File Offset: 0x00007E6C
		internal static object RxhTIVtAqYFbnB8Eu7O(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00009C80 File Offset: 0x00007E80
		internal static object Wics4stLJmvAwgkRMvo(object A_0, object A_1, object A_2)
		{
			return uLfVht5XqcdpSvFumbD.muOq5LWqgj(A_0, A_1, A_2);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00009C9C File Offset: 0x00007E9C
		internal static object a2aIcptXovkChuwj4w0(IntPtr A_0, object A_1)
		{
			return UesPrPAH73jB0XWSnsx.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00009CB4 File Offset: 0x00007EB4
		internal static IntPtr SlAQcktcmccktYkiJ8E(Type type)
		{
			return Il2CppClassPointerStore.GetNativeClassPointer(type);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00009CC8 File Offset: 0x00007EC8
		internal static object T7P37Vtk9ZNsYojYw7R(object A_0, object A_1)
		{
			return PTKvoMLfDDsJo1Y7iZK.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00009CE0 File Offset: 0x00007EE0
		internal static object chhsNdt29kN70O9xpP9(IntPtr classPointer, object A_1, bool throwOnFailure)
		{
			return Il2CppType.TypeFromPointerInternal(classPointer, A_1, throwOnFailure);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00009CFC File Offset: 0x00007EFC
		internal static void qtQrNGtHJgZTmXNYPAu()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400002A RID: 42
		private static Il2CppType HjPkSVtlcor7enr47dX;
	}
}
