using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.InteropTypes.Fields
{
	// Token: 0x02000128 RID: 296
	public class Il2CppStringField
	{
		// Token: 0x06000CD5 RID: 3285 RVA: 0x00013608 File Offset: 0x00011808
		internal Il2CppStringField(Il2CppObjectBase obj, string fieldName)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92a7d78565474619a2c93ca9aa734139 != 0)
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
					this._fieldPtr = Il2CppStringField.mB3XNGpsc3ttUpdxJgC(obj.ObjectClass, fieldName);
					num = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b82ae23c6544f3a11e54f2fed3ad25 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x000136B8 File Offset: 0x000118B8
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x000136C8 File Offset: 0x000118C8
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7628c527f657443a88f11a40a3f948a5 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00013728 File Offset: 0x00011928
		public unsafe string Get()
		{
			int num = 2;
			int num2 = num;
			IntPtr intPtr;
			for (;;)
			{
				switch (num2)
				{
				default:
					goto IL_2F;
				case 1:
					if (intPtr != IntPtr.Zero)
					{
						goto IL_31;
					}
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_124ad935e0834fda9ae7f452377dbe1c == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					intPtr = *this.GetPointerToData();
					num2 = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b82ae23c6544f3a11e54f2fed3ad25 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
			IL_2F:
			return null;
			IL_31:
			return Il2CppStringField.YEPM42pSdg8M23DXLly(intPtr);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x000137C0 File Offset: 0x000119C0
		public unsafe void Set(string value)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					*this.GetPointerToData() = Il2CppStringField.aY4flapNYe1w9eEpxgS(value);
					num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_fe27a6a8bfb848d1a3dd32bc5b1790e7 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00013824 File Offset: 0x00011A24
		public static implicit operator string(Il2CppStringField _this)
		{
			return Il2CppStringField.VjRSSBpufpkQmujRYtM(_this);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00013834 File Offset: 0x00011A34
		public static implicit operator Il2CppStringField(string _)
		{
			throw null;
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00013840 File Offset: 0x00011A40
		public override string ToString()
		{
			return this.Get();
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00013850 File Offset: 0x00011A50
		private unsafe IntPtr* GetPointerToData()
		{
			return Il2CppStringField.BPl81KpDsmcJFCo4qTt(this._obj) / (IntPtr)sizeof(IntPtr) + IL2CPP.il2cpp_field_get_offset(this._fieldPtr);
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00013874 File Offset: 0x00011A74
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppStringField()
		{
			Il2CppStringField.B4V1jPpmT6Ow62jyajW();
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00013884 File Offset: 0x00011A84
		internal static IntPtr mB3XNGpsc3ttUpdxJgC(IntPtr clazz, object A_1)
		{
			return IL2CPP.GetIl2CppField(clazz, A_1);
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x0001389C File Offset: 0x00011A9C
		internal static bool qLCVWLpVIDJl5dtgUhP()
		{
			return Il2CppStringField.IBq2QQppOLqN9NQwb1R == null;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x000138B0 File Offset: 0x00011AB0
		internal static Il2CppStringField GEukd4p0iVJKGeqhmpY()
		{
			return Il2CppStringField.IBq2QQppOLqN9NQwb1R;
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x000138C0 File Offset: 0x00011AC0
		internal static object YEPM42pSdg8M23DXLly(IntPtr il2CppString)
		{
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x000138D4 File Offset: 0x00011AD4
		internal static IntPtr aY4flapNYe1w9eEpxgS(object A_0)
		{
			return IL2CPP.ManagedStringToIl2Cpp(A_0);
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x000138E8 File Offset: 0x00011AE8
		internal static object VjRSSBpufpkQmujRYtM(object A_0)
		{
			return A_0.Get();
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x000138FC File Offset: 0x00011AFC
		internal static IntPtr BPl81KpDsmcJFCo4qTt(object A_0)
		{
			return IL2CPP.Il2CppObjectBaseToPtrNotNull(A_0);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00013910 File Offset: 0x00011B10
		internal static void B4V1jPpmT6Ow62jyajW()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x04000975 RID: 2421
		private readonly IntPtr _fieldPtr;

		// Token: 0x04000976 RID: 2422
		private readonly Il2CppObjectBase _obj;

		// Token: 0x04000977 RID: 2423
		private static Il2CppStringField IBq2QQppOLqN9NQwb1R;
	}
}
