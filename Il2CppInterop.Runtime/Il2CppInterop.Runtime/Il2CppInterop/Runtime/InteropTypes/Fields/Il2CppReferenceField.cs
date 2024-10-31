using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.InteropTypes.Fields
{
	// Token: 0x02000127 RID: 295
	public class Il2CppReferenceField<TRefObj> where TRefObj : Il2CppObjectBase
	{
		// Token: 0x06000CCA RID: 3274 RVA: 0x00013434 File Offset: 0x00011634
		internal Il2CppReferenceField(Il2CppObjectBase obj, string fieldName)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 1:
					this._fieldPtr = IL2CPP.GetIl2CppField(obj.ObjectClass, fieldName);
					num = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_124ad935e0834fda9ae7f452377dbe1c != 0)
					{
						num = 0;
						continue;
					}
					continue;
				case 2:
					this._obj = obj;
					num = 1;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6fe1694df7b94e7bbaa2aab21c6a82ec == 0)
					{
						num = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x000134E4 File Offset: 0x000116E4
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x000134F4 File Offset: 0x000116F4
		public TRefObj Value
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

		// Token: 0x06000CCD RID: 3277 RVA: 0x00013504 File Offset: 0x00011704
		public unsafe TRefObj Get()
		{
			IntPtr intPtr = *this.GetPointerToData();
			if (intPtr == IntPtr.Zero)
			{
				return default(TRefObj);
			}
			return (TRefObj)((object)uOwB4KcDZYIKE8rJ5Wb.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(TRefObj).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), new object[]
			{
				intPtr
			}, uOwB4KcDZYIKE8rJ5Wb.VeocmNDrMe));
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00013564 File Offset: 0x00011764
		public unsafe void Set(TRefObj value)
		{
			*this.GetPointerToData() = ((value != null) ? value.Pointer : IntPtr.Zero);
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x00013594 File Offset: 0x00011794
		public static implicit operator TRefObj(Il2CppReferenceField<TRefObj> _this)
		{
			return _this.Get();
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x000135A4 File Offset: 0x000117A4
		public static implicit operator Il2CppReferenceField<TRefObj>(TRefObj _)
		{
			throw null;
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x000135B0 File Offset: 0x000117B0
		private unsafe IntPtr* GetPointerToData()
		{
			return IL2CPP.Il2CppObjectBaseToPtrNotNull(this._obj) / (IntPtr)sizeof(IntPtr) + IL2CPP.il2cpp_field_get_offset(this._fieldPtr);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x000135D4 File Offset: 0x000117D4
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppReferenceField()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x000135E4 File Offset: 0x000117E4
		internal static bool oBwisFpy2KkduwFm51o()
		{
			return Il2CppReferenceField<TRefObj>.XoXhM1p6CgBvTg24UF0 == null;
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x000135F8 File Offset: 0x000117F8
		internal static object Gs27bDpJSxf7Em7Bu4T()
		{
			return Il2CppReferenceField<TRefObj>.XoXhM1p6CgBvTg24UF0;
		}

		// Token: 0x04000972 RID: 2418
		private readonly IntPtr _fieldPtr;

		// Token: 0x04000973 RID: 2419
		private readonly Il2CppObjectBase _obj;

		// Token: 0x04000974 RID: 2420
		internal static object XoXhM1p6CgBvTg24UF0;
	}
}
