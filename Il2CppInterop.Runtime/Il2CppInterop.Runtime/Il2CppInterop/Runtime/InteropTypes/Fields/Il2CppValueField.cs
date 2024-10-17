using System;
using System.Runtime.CompilerServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.InteropTypes.Fields
{
	// Token: 0x0200012B RID: 299
	public class Il2CppValueField<[IsUnmanaged] T> where T : struct, ValueType
	{
		// Token: 0x06000D09 RID: 3337 RVA: 0x0001458C File Offset: 0x0001278C
		internal Il2CppValueField(Il2CppObjectBase obj, string fieldName)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor();
			int num = 0;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7b2fff018dbf4cfe8ef41e2d123dc629 == 0)
			{
				num = 2;
			}
			for (;;)
			{
				switch (num)
				{
				default:
					this._fieldPtr = IL2CPP.GetIl2CppField(obj.ObjectClass, fieldName);
					num = 1;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_d4e1c4caa68b4a76bc8f57ec8dfac2bc != 0)
					{
						num = 1;
					}
					break;
				case 1:
					return;
				case 2:
					this._obj = obj;
					num = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_bd64431fd05f4961aa9b79e5bd243164 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00014650 File Offset: 0x00012850
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x00014660 File Offset: 0x00012860
		public T Value
		{
			get
			{
				return this.Get();
			}
			set
			{
				this.Set(value);
			}
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00014670 File Offset: 0x00012870
		public unsafe T Get()
		{
			return *this.GetPointerToData();
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00014684 File Offset: 0x00012884
		public unsafe void Set(T value)
		{
			*this.GetPointerToData() = value;
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x0001469C File Offset: 0x0001289C
		public static implicit operator T(Il2CppValueField<T> _this)
		{
			return _this.Get();
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x000146AC File Offset: 0x000128AC
		public static implicit operator Il2CppValueField<T>(T _)
		{
			throw null;
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x000146B8 File Offset: 0x000128B8
		private unsafe T* GetPointerToData()
		{
			return IL2CPP.Il2CppObjectBaseToPtrNotNull(this._obj) / (IntPtr)sizeof(T) + IL2CPP.il2cpp_field_get_offset(this._fieldPtr);
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x000146DC File Offset: 0x000128DC
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppValueField()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x000146EC File Offset: 0x000128EC
		internal static bool sOpcpH73ObrZrR4PEZ0()
		{
			return Il2CppValueField<T>.vJ1YgR7nYfqk4g8xXGf == null;
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00014700 File Offset: 0x00012900
		internal static object NamnSs71tA7cKOOyOdb()
		{
			return Il2CppValueField<T>.vJ1YgR7nYfqk4g8xXGf;
		}

		// Token: 0x04000983 RID: 2435
		private readonly IntPtr _fieldPtr;

		// Token: 0x04000984 RID: 2436
		private readonly Il2CppObjectBase _obj;

		// Token: 0x04000985 RID: 2437
		private static object vJ1YgR7nYfqk4g8xXGf;
	}
}
