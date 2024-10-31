using System;
using System.Runtime.CompilerServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.InteropTypes.Fields
{
	// Token: 0x02000129 RID: 297
	public class Il2CppValueField<[IsUnmanaged] T> where T : struct, ValueType
	{
		// Token: 0x06000CE7 RID: 3303 RVA: 0x00013920 File Offset: 0x00011B20
		internal Il2CppValueField(Il2CppObjectBase obj, string fieldName)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 1;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_068b7dfa4ec449e7b5200030c1c277e5 != 0)
			{
				num = 1;
			}
			for (;;)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					this._obj = obj;
					num = 2;
					break;
				case 2:
					this._fieldPtr = IL2CPP.GetIl2CppField(obj.ObjectClass, fieldName);
					num = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_adb8decd62b945dda713f7b22b6b95ca != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x000139D0 File Offset: 0x00011BD0
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x000139E0 File Offset: 0x00011BE0
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

		// Token: 0x06000CEA RID: 3306 RVA: 0x000139F0 File Offset: 0x00011BF0
		public unsafe T Get()
		{
			return *this.GetPointerToData();
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x00013A04 File Offset: 0x00011C04
		public unsafe void Set(T value)
		{
			*this.GetPointerToData() = value;
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x00013A1C File Offset: 0x00011C1C
		public static implicit operator T(Il2CppValueField<T> _this)
		{
			return _this.Get();
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00013A2C File Offset: 0x00011C2C
		public static implicit operator Il2CppValueField<T>(T _)
		{
			throw null;
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00013A38 File Offset: 0x00011C38
		private unsafe T* GetPointerToData()
		{
			return IL2CPP.Il2CppObjectBaseToPtrNotNull(this._obj) / (IntPtr)sizeof(T) + IL2CPP.il2cpp_field_get_offset(this._fieldPtr);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00013A5C File Offset: 0x00011C5C
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppValueField()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00013A6C File Offset: 0x00011C6C
		internal static bool iAlfFwpPtwwc9LqsPby()
		{
			return Il2CppValueField<T>.EnZLZdp7yicyLZAJYXu == null;
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00013A80 File Offset: 0x00011C80
		internal static object cRMtAEp44A26EUnvlbm()
		{
			return Il2CppValueField<T>.EnZLZdp7yicyLZAJYXu;
		}

		// Token: 0x04000978 RID: 2424
		private readonly IntPtr _fieldPtr;

		// Token: 0x04000979 RID: 2425
		private readonly Il2CppObjectBase _obj;

		// Token: 0x0400097A RID: 2426
		private static object EnZLZdp7yicyLZAJYXu;
	}
}
