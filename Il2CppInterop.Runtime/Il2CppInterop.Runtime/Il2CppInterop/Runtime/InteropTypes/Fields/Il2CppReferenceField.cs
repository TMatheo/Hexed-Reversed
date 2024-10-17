using System;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.InteropTypes.Fields
{
	// Token: 0x02000129 RID: 297
	public class Il2CppReferenceField<TRefObj> where TRefObj : Il2CppObjectBase
	{
		// Token: 0x06000CEC RID: 3308 RVA: 0x0001408C File Offset: 0x0001228C
		internal Il2CppReferenceField(Il2CppObjectBase obj, string fieldName)
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
			base..ctor();
			int num = 1;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_01c6e15d1fd54ef9b78826bf2944de2a != 0)
			{
				num = 0;
			}
			for (;;)
			{
				switch (num)
				{
				default:
				{
					this._fieldPtr = IL2CPP.GetIl2CppField(obj.ObjectClass, fieldName);
					int num2 = 2;
					num = num2;
					break;
				}
				case 1:
					this._obj = obj;
					num = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_22a2950bfabc46ffa61eec0d3eacc4c9 == 0)
					{
						num = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x00014140 File Offset: 0x00012340
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x00014150 File Offset: 0x00012350
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

		// Token: 0x06000CEF RID: 3311 RVA: 0x00014160 File Offset: 0x00012360
		public unsafe TRefObj Get()
		{
			IntPtr intPtr = *this.GetPointerToData();
			if (intPtr == IntPtr.Zero)
			{
				return default(TRefObj);
			}
			return (TRefObj)((object)bFfvVxI2DKZLSU4QQXm.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(TRefObj).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), new object[]
			{
				intPtr
			}, bFfvVxI2DKZLSU4QQXm.d0AIy6X62W));
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x000141C0 File Offset: 0x000123C0
		public unsafe void Set(TRefObj value)
		{
			*this.GetPointerToData() = ((value != null) ? value.Pointer : IntPtr.Zero);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x000141F0 File Offset: 0x000123F0
		public static implicit operator TRefObj(Il2CppReferenceField<TRefObj> _this)
		{
			return _this.Get();
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00014200 File Offset: 0x00012400
		public static implicit operator Il2CppReferenceField<TRefObj>(TRefObj _)
		{
			throw null;
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x0001420C File Offset: 0x0001240C
		private unsafe IntPtr* GetPointerToData()
		{
			return IL2CPP.Il2CppObjectBaseToPtrNotNull(this._obj) / (IntPtr)sizeof(IntPtr) + IL2CPP.il2cpp_field_get_offset(this._fieldPtr);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00014230 File Offset: 0x00012430
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppReferenceField()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00014240 File Offset: 0x00012440
		internal static bool msRIKV7V2ax34rOubOa()
		{
			return Il2CppReferenceField<TRefObj>.wy7Crc7ltsZpVPcNAXQ == null;
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00014254 File Offset: 0x00012454
		internal static object NIaDNc7OvwguqZCFNvp()
		{
			return Il2CppReferenceField<TRefObj>.wy7Crc7ltsZpVPcNAXQ;
		}

		// Token: 0x0400097D RID: 2429
		private readonly IntPtr _fieldPtr;

		// Token: 0x0400097E RID: 2430
		private readonly Il2CppObjectBase _obj;

		// Token: 0x0400097F RID: 2431
		private static object wy7Crc7ltsZpVPcNAXQ;
	}
}
