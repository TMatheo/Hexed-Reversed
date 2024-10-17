using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.InteropTypes.Fields
{
	// Token: 0x0200012A RID: 298
	public class Il2CppStringField
	{
		// Token: 0x06000CF7 RID: 3319 RVA: 0x00014264 File Offset: 0x00012464
		internal Il2CppStringField(Il2CppObjectBase obj, string fieldName)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			Il2CppStringField.ARnaQM7BqmS0nCdbOsT();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5c4dec7c475342669cbf3c1205f935ba == 0)
			{
				num = 0;
			}
			for (;;)
			{
				switch (num)
				{
				case 1:
					this._fieldPtr = IL2CPP.GetIl2CppField(Il2CppStringField.tiTRxZ7jDwqIhqphqqP(obj), fieldName);
					num = 2;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_b4e45528af4644e9b080e05d5ff6ef54 != 0)
					{
						num = 0;
						continue;
					}
					continue;
				case 2:
					return;
				}
				this._obj = obj;
				num = 1;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9c5de7c7e06f4557898ef7a8362c30ee != 0)
				{
					num = 1;
				}
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x00014328 File Offset: 0x00012528
		// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x00014338 File Offset: 0x00012538
		public string Value
		{
			get
			{
				return this.Get();
			}
			set
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						this.Set(value);
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_64afbb57bf68458f80a150c34cb4e04c != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00014398 File Offset: 0x00012598
		public unsafe string Get()
		{
			int num = 1;
			int num2 = num;
			IntPtr intPtr;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					intPtr = *this.GetPointerToData();
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_4cb85c330fed4a769825a3343f966401 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					goto IL_2F;
				}
				if (intPtr != IntPtr.Zero)
				{
					goto IL_31;
				}
				num2 = 2;
				if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5636e8ee665e464ba930601506bed387 != 0)
				{
					num2 = 2;
				}
			}
			IL_2F:
			return null;
			IL_31:
			return Il2CppStringField.PPuhCa7T8qZYltTfu4o(intPtr);
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00014430 File Offset: 0x00012630
		public unsafe void Set(string value)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					*this.GetPointerToData() = Il2CppStringField.MV9oI37Fq8bFHkaCF9i(value);
					num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00014494 File Offset: 0x00012694
		public static implicit operator string(Il2CppStringField _this)
		{
			return Il2CppStringField.tfVvAl7K0eE1Dgwphfw(_this);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x000144A4 File Offset: 0x000126A4
		public static implicit operator Il2CppStringField(string _)
		{
			throw null;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x000144B0 File Offset: 0x000126B0
		public override string ToString()
		{
			return this.Get();
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x000144C0 File Offset: 0x000126C0
		private unsafe IntPtr* GetPointerToData()
		{
			return Il2CppStringField.nnMiXm75sJiEGf2LsYd(this._obj) / (IntPtr)sizeof(IntPtr) + IL2CPP.il2cpp_field_get_offset(this._fieldPtr);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x000144E4 File Offset: 0x000126E4
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppStringField()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x000144F4 File Offset: 0x000126F4
		internal static void ARnaQM7BqmS0nCdbOsT()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00014504 File Offset: 0x00012704
		internal static IntPtr tiTRxZ7jDwqIhqphqqP(object A_0)
		{
			return A_0.ObjectClass;
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00014518 File Offset: 0x00012718
		internal static bool QZgoOu7mbwq1HvQhcGB()
		{
			return Il2CppStringField.bARTiT7XBxM7LZjarS9 == null;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x0001452C File Offset: 0x0001272C
		internal static Il2CppStringField cW0fFi7vvdFeQOgOBem()
		{
			return Il2CppStringField.bARTiT7XBxM7LZjarS9;
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0001453C File Offset: 0x0001273C
		internal static object PPuhCa7T8qZYltTfu4o(IntPtr il2CppString)
		{
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00014550 File Offset: 0x00012750
		internal static IntPtr MV9oI37Fq8bFHkaCF9i(object A_0)
		{
			return IL2CPP.ManagedStringToIl2Cpp(A_0);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00014564 File Offset: 0x00012764
		internal static object tfVvAl7K0eE1Dgwphfw(object A_0)
		{
			return A_0.Get();
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00014578 File Offset: 0x00012778
		internal static IntPtr nnMiXm75sJiEGf2LsYd(object A_0)
		{
			return IL2CPP.Il2CppObjectBaseToPtrNotNull(A_0);
		}

		// Token: 0x04000980 RID: 2432
		private readonly IntPtr _fieldPtr;

		// Token: 0x04000981 RID: 2433
		private readonly Il2CppObjectBase _obj;

		// Token: 0x04000982 RID: 2434
		private static Il2CppStringField bARTiT7XBxM7LZjarS9;
	}
}
