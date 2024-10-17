using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.Runtime.VersionSpecific.Exception
{
	// Token: 0x020000A7 RID: 167
	[ApplicableToUnityVersionsSince("5.3.5")]
	public class NativeExceptionStructHandler_21_0 : INativeExceptionStructHandler, INativeStructHandler
	{
		// Token: 0x06000620 RID: 1568 RVA: 0x0001065C File Offset: 0x0000E85C
		public int Size()
		{
			return sizeof(NativeExceptionStructHandler_21_0.Il2CppException_21_0);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0001066C File Offset: 0x0000E86C
		public unsafe INativeExceptionStruct CreateNewStruct()
		{
			NativeExceptionStructHandler_21_0.Il2CppException_21_0* ptr2;
			IntPtr ptr = ptr2 = MarshalExtend.AllocHGlobal(this.Size());
			*ptr2 = default(NativeExceptionStructHandler_21_0.Il2CppException_21_0);
			return new NativeExceptionStructHandler_21_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0001069C File Offset: 0x0000E89C
		public unsafe INativeExceptionStruct Wrap(Il2CppException* ptr)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					goto IL_2B;
				case 1:
					if (ptr != null)
					{
						goto IL_2D;
					}
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fdb0528b1ef843aca29153aec62fa60d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return null;
			IL_2D:
			return new NativeExceptionStructHandler_21_0.NativeStructWrapper(ptr);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00010704 File Offset: 0x0000E904
		public NativeExceptionStructHandler_21_0()
		{
			NativeExceptionStructHandler_21_0.rtNbC1EO11YaSNgJTbD();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_99cea5f9c4c245c2a5f184ab2e57fafc != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00010768 File Offset: 0x0000E968
		// Note: this type is marked as 'beforefieldinit'.
		static NativeExceptionStructHandler_21_0()
		{
			NativeExceptionStructHandler_21_0.Ny0UYREXCJddCYVHqub();
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00010778 File Offset: 0x0000E978
		internal static bool Tsq7JeElThni1usJbrQ()
		{
			return NativeExceptionStructHandler_21_0.v4xCuUEg1YPyG3VTho3 == null;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0001078C File Offset: 0x0000E98C
		internal static NativeExceptionStructHandler_21_0 LfHds7EVWMfBAW5yuJA()
		{
			return NativeExceptionStructHandler_21_0.v4xCuUEg1YPyG3VTho3;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0001079C File Offset: 0x0000E99C
		internal static void rtNbC1EO11YaSNgJTbD()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000107AC File Offset: 0x0000E9AC
		internal static void Ny0UYREXCJddCYVHqub()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x040002AB RID: 683
		private static NativeExceptionStructHandler_21_0 v4xCuUEg1YPyG3VTho3;

		// Token: 0x020000A8 RID: 168
		internal struct Il2CppException_21_0
		{
			// Token: 0x040002AC RID: 684
			public Il2CppObject _object;

			// Token: 0x040002AD RID: 685
			public unsafe void* trace_ips;

			// Token: 0x040002AE RID: 686
			public unsafe Il2CppException* inner_ex;

			// Token: 0x040002AF RID: 687
			public unsafe Il2CppString* message;

			// Token: 0x040002B0 RID: 688
			public unsafe Il2CppString* help_link;

			// Token: 0x040002B1 RID: 689
			public unsafe Il2CppString* class_name;

			// Token: 0x040002B2 RID: 690
			public unsafe Il2CppString* stack_trace;

			// Token: 0x040002B3 RID: 691
			public unsafe Il2CppString* remote_stack_trace;

			// Token: 0x040002B4 RID: 692
			public int remote_stack_index;

			// Token: 0x040002B5 RID: 693
			public il2cpp_hresult_t hresult;

			// Token: 0x040002B6 RID: 694
			public unsafe Il2CppString* source;

			// Token: 0x040002B7 RID: 695
			public unsafe Il2CppObject* _data;
		}

		// Token: 0x020000A9 RID: 169
		internal class NativeStructWrapper : INativeExceptionStruct, INativeStruct
		{
			// Token: 0x06000629 RID: 1577 RVA: 0x0001CC00 File Offset: 0x0001AE00
			public NativeStructWrapper(IntPtr ptr)
			{
				NativeExceptionStructHandler_21_0.NativeStructWrapper.QOjlAEZIMZVUhrKyfKd();
				NativeExceptionStructHandler_21_0.NativeStructWrapper.I0OvJ6ZGYwoSkM7gBMd();
				base..ctor();
				int num = 0;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7b2fff018dbf4cfe8ef41e2d123dc629 == 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						this.<Pointer>k__BackingField = ptr;
						num = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_61a3825996b24609815f6b482bf680d9 == 0)
						{
							num = 1;
						}
						break;
					case 1:
						return;
					}
				}
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x0600062A RID: 1578 RVA: 0x0001CC90 File Offset: 0x0001AE90
			private unsafe NativeExceptionStructHandler_21_0.Il2CppException_21_0* _
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000155 RID: 341
			// (get) Token: 0x0600062B RID: 1579 RVA: 0x0001CCA0 File Offset: 0x0001AEA0
			public IntPtr Pointer { get; }

			// Token: 0x17000156 RID: 342
			// (get) Token: 0x0600062C RID: 1580 RVA: 0x0001CCB0 File Offset: 0x0001AEB0
			public unsafe Il2CppException* ExceptionPointer
			{
				get
				{
					return this.Pointer;
				}
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x0600062D RID: 1581 RVA: 0x0001CCC0 File Offset: 0x0001AEC0
			public unsafe ref Il2CppException* InnerException
			{
				get
				{
					return ref this._->inner_ex;
				}
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x0600062E RID: 1582 RVA: 0x0001CCD4 File Offset: 0x0001AED4
			public unsafe ref Il2CppString* Message
			{
				get
				{
					return ref this._->message;
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x0600062F RID: 1583 RVA: 0x0001CCE8 File Offset: 0x0001AEE8
			public unsafe ref Il2CppString* HelpLink
			{
				get
				{
					return ref this._->help_link;
				}
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x06000630 RID: 1584 RVA: 0x0001CCFC File Offset: 0x0001AEFC
			public unsafe ref Il2CppString* ClassName
			{
				get
				{
					return ref this._->class_name;
				}
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x06000631 RID: 1585 RVA: 0x0001CD10 File Offset: 0x0001AF10
			public unsafe ref Il2CppString* StackTrace
			{
				get
				{
					return ref this._->stack_trace;
				}
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x06000632 RID: 1586 RVA: 0x0001CD24 File Offset: 0x0001AF24
			public unsafe ref Il2CppString* RemoteStackTrace
			{
				get
				{
					return ref this._->remote_stack_trace;
				}
			}

			// Token: 0x06000633 RID: 1587 RVA: 0x0001CD38 File Offset: 0x0001AF38
			// Note: this type is marked as 'beforefieldinit'.
			static NativeStructWrapper()
			{
				NativeExceptionStructHandler_21_0.NativeStructWrapper.VLDmN8ZYostEpSVrX1x();
			}

			// Token: 0x06000634 RID: 1588 RVA: 0x0001CD48 File Offset: 0x0001AF48
			internal static void QOjlAEZIMZVUhrKyfKd()
			{
				hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			}

			// Token: 0x06000635 RID: 1589 RVA: 0x0001CD58 File Offset: 0x0001AF58
			internal static void I0OvJ6ZGYwoSkM7gBMd()
			{
				nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			}

			// Token: 0x06000636 RID: 1590 RVA: 0x0001CD68 File Offset: 0x0001AF68
			internal static bool C8nmybZ9KuJHdn5rvMT()
			{
				return NativeExceptionStructHandler_21_0.NativeStructWrapper.LoUmhEZqRUIlhmw3OsX == null;
			}

			// Token: 0x06000637 RID: 1591 RVA: 0x0001CD7C File Offset: 0x0001AF7C
			internal static NativeExceptionStructHandler_21_0.NativeStructWrapper BeFoGYZiPrFOmMkqmIt()
			{
				return NativeExceptionStructHandler_21_0.NativeStructWrapper.LoUmhEZqRUIlhmw3OsX;
			}

			// Token: 0x06000638 RID: 1592 RVA: 0x0001CD8C File Offset: 0x0001AF8C
			internal static void VLDmN8ZYostEpSVrX1x()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x040002B9 RID: 697
			internal static object LoUmhEZqRUIlhmw3OsX;
		}
	}
}
