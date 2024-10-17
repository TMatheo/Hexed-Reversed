using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.InteropTypes
{
	// Token: 0x02000127 RID: 295
	public class Il2CppObjectBase
	{
		// Token: 0x06000CD9 RID: 3289 RVA: 0x00013A3C File Offset: 0x00011C3C
		public Il2CppObjectBase(IntPtr pointer)
		{
			Il2CppObjectBase.R7vbSi7yxTPh6w0R26o();
			Il2CppObjectBase.MXu4qI7SDPL3HyJUb0I();
			base..ctor();
			int num = 1;
			if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5a8626d471f54eba873ce59c8785d9b9 != 0)
			{
				num = 1;
			}
			for (;;)
			{
				switch (num)
				{
				case 1:
					this.CreateGCHandle(pointer);
					num = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_fdb0528b1ef843aca29153aec62fa60d == 0)
					{
						num = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x00013ACC File Offset: 0x00011CCC
		public IntPtr ObjectClass
		{
			get
			{
				return IL2CPP.il2cpp_object_get_class(this.Pointer);
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x00013AE0 File Offset: 0x00011CE0
		public IntPtr Pointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.il2cpp_gchandle_get_target(this.myGcHandle);
				if (intPtr == IntPtr.Zero)
				{
					throw new NullReferenceException(hIDAYxH6DWLHIthQgC.gSCeTtiku(568254754 ^ 1997769010 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_22a2950bfabc46ffa61eec0d3eacc4c9));
				}
				return intPtr;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00013B20 File Offset: 0x00011D20
		public bool WasCollected
		{
			get
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (IL2CPP.il2cpp_gchandle_get_target(this.myGcHandle) != IntPtr.Zero)
						{
							return false;
						}
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_99cea5f9c4c245c2a5f184ab2e57fafc == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				return true;
			}
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00013B90 File Offset: 0x00011D90
		internal void CreateGCHandle(IntPtr objHdl)
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					goto IL_5E;
				case 3:
					if (objHdl == IntPtr.Zero)
					{
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_7f5f35a413414ac0b2dfa27f953f90e9 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					else if (this.isWrapped)
					{
						num2 = 0;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ce81190098cb44f1b9a77ca4822d7770 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					else
					{
						this.myGcHandle = IL2CPP.il2cpp_gchandle_new(objHdl, false);
						num2 = 1;
						if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_780e0c86b08f49d785f406cf802c7e87 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				}
				break;
			}
			return;
			IL_5E:
			throw new NullReferenceException();
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00013C58 File Offset: 0x00011E58
		internal unsafe static T UnboxUnsafe<T>(IntPtr pointer)
		{
			IntPtr nativeClassPtr = Il2CppClassPointerStore<T>.NativeClassPtr;
			if (nativeClassPtr == IntPtr.Zero)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an));
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1668275920 ^ 691007470 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_db312e48eee84539b805fee2f73a8cde), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				throw new ArgumentException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
			}
			IntPtr intPtr = IL2CPP.il2cpp_object_get_class(pointer);
			if (!IL2CPP.il2cpp_class_is_assignable_from(nativeClassPtr, intPtr))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 2);
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1887176262 ^ 417851132 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_0783948440564d328b8e79831447d3f6), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, N7wDN5IwZsNiI9Qj5B6.i2IAUFsOOC(IL2CPP.il2cpp_class_get_name(intPtr), N7wDN5IwZsNiI9Qj5B6.tjtIeeDMLs), FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(281228140 ^ 503656513 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_a2b24b0de55344c2b8aaf8116dbc4d16), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an));
				throw new InvalidCastException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
			}
			IntPtr intPtr2 = IL2CPP.il2cpp_object_unbox(pointer);
			return *Unsafe.AsRef<T>(JFwKeLIuFdrVcU89o72.i2IAUFsOOC(ref intPtr2, JFwKeLIuFdrVcU89o72.xshIEqMN4b));
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00013DA0 File Offset: 0x00011FA0
		public T Unbox<[IsUnmanaged] T>() where T : struct, ValueType
		{
			return Il2CppObjectBase.UnboxUnsafe<T>(this.Pointer);
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00013DB4 File Offset: 0x00011FB4
		public T Cast<T>() where T : Il2CppObjectBase
		{
			T t = this.TryCast<T>();
			if (t == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 2);
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(981215493 >> 6 ^ 1715427408 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ba3f6bd5a09c47868765e25f534dbf2a), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				FfHHk1qP1Pa78U6K7p4.i2IAUFsOOC(ref defaultInterpolatedStringHandler, N7wDN5IwZsNiI9Qj5B6.i2IAUFsOOC(IL2CPP.il2cpp_class_get_name(IL2CPP.il2cpp_object_get_class(this.Pointer)), N7wDN5IwZsNiI9Qj5B6.tjtIeeDMLs), FfHHk1qP1Pa78U6K7p4.wQLqdMnpxY);
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1468223714 ^ -1139102917 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ea3a0368554c4e6093e0b0561ffd5cef), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an));
				throw new InvalidCastException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
			}
			return t;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00013E88 File Offset: 0x00012088
		public T TryCast<T>() where T : Il2CppObjectBase
		{
			IntPtr nativeClassPtr = Il2CppClassPointerStore<T>.NativeClassPtr;
			if (nativeClassPtr == IntPtr.Zero)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an));
				QG4ZQ9APVeRA5A968ba.i2IAUFsOOC(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1577717134 ^ -835612935 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_40875ab50e1c43f7bf4d96946e4523cb), QG4ZQ9APVeRA5A968ba.WfgAdlCqZw);
				throw new ArgumentException(JERLY8AwDDHFUcct031.i2IAUFsOOC(ref defaultInterpolatedStringHandler, JERLY8AwDDHFUcct031.BtbAeLEPuL));
			}
			IntPtr oklass = IL2CPP.il2cpp_object_get_class(this.Pointer);
			if (!IL2CPP.il2cpp_class_is_assignable_from(nativeClassPtr, oklass))
			{
				return default(T);
			}
			return Il2CppObjectBase.InitializerStore<T>.Initializer(this.Pointer);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00013F38 File Offset: 0x00012138
		protected override void Finalize()
		{
			switch (1)
			{
			case 1:
				try
				{
					IL2CPP.il2cpp_gchandle_free(this.myGcHandle);
					int num = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_277c9fa6c1da46a98cc2f13643296b8f == 0)
					{
						num = 0;
					}
					switch (num)
					{
					}
				}
				finally
				{
					Il2CppObjectBase.bpy18C7gTwLGaAgmgyt(this, WcGScJIsSl14ngpyQJw.IoqIQIRg9g);
					int num2 = 0;
					if (<Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_4cb85c330fed4a769825a3343f966401 == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					}
				}
				break;
			}
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00014020 File Offset: 0x00012220
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppObjectBase()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00014030 File Offset: 0x00012230
		internal static void R7vbSi7yxTPh6w0R26o()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00014040 File Offset: 0x00012240
		internal static void MXu4qI7SDPL3HyJUb0I()
		{
			nHwRpygmi6xxZAssJn.MZ6my7dBdJ();
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00014050 File Offset: 0x00012250
		internal static bool FZ5xVA7QGCSvcTE8RJo()
		{
			return Il2CppObjectBase.YXIYHK7sKyB0JgtysJ0 == null;
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x00014064 File Offset: 0x00012264
		internal static Il2CppObjectBase tytQJc72LRMywS5dNwU()
		{
			return Il2CppObjectBase.YXIYHK7sKyB0JgtysJ0;
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x00014074 File Offset: 0x00012274
		internal static void bpy18C7gTwLGaAgmgyt(object A_0, object A_1)
		{
			WcGScJIsSl14ngpyQJw.i2IAUFsOOC(A_0, A_1);
		}

		// Token: 0x04000979 RID: 2425
		internal bool isWrapped;

		// Token: 0x0400097A RID: 2426
		private uint myGcHandle;

		// Token: 0x0400097B RID: 2427
		private static Il2CppObjectBase YXIYHK7sKyB0JgtysJ0;

		// Token: 0x02000128 RID: 296
		internal static class InitializerStore<T>
		{
			// Token: 0x06000CE9 RID: 3305 RVA: 0x00028938 File Offset: 0x00026B38
			private static Func<IntPtr, T> Create()
			{
				Type type = Il2CppClassPointerStore<T>.CreatedTypeRedirect ?? byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an);
				DynamicMethod dynamicMethod = new DynamicMethod(FqZp2N9hs66h9Og8y7V.i2IAUFsOOC(hIDAYxH6DWLHIthQgC.gSCeTtiku(163526699 ^ -306984248 ^ -2090280697 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_ddf0bbff3ec54ad39c6b2ba58dc80058), zEgD5NGR2vTryLUwsvI.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(T).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), zEgD5NGR2vTryLUwsvI.euiGkgttnA), hIDAYxH6DWLHIthQgC.gSCeTtiku(1570093376 ^ 225349333 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_9eb38fa6f3314175b044ae281856e1bc), FqZp2N9hs66h9Og8y7V.HHh98mFKgS), type, new Type[]
				{
					byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(IntPtr).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an)
				});
				jx3hpxGJlEOEsBH5Y7V.i2IAUFsOOC(dynamicMethod, 0, ParameterAttributes.None, hIDAYxH6DWLHIthQgC.gSCeTtiku(443897056 << 2 ^ 60133251 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_944294969d634011bf30e3f4f506a31e), jx3hpxGJlEOEsBH5Y7V.rJVGWm1rvA);
				ILGenerator ilgenerator = LN74hFUuuPeOAyrLO2m.i2IAUFsOOC(dynamicMethod, LN74hFUuuPeOAyrLO2m.mWbUEkxEGw);
				ConstructorInfo constructorInfo = zD3ZnqUlrIU4LLl6GPl.i2IAUFsOOC(type, new Type[]
				{
					byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(IntPtr).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an)
				}, zD3ZnqUlrIU4LLl6GPl.txAUV634FV);
				if (constructorInfo != null)
				{
					PybwZDULT8j9uRoXf8D.i2IAUFsOOC(ilgenerator, OpCodes.Ldarg_0, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
					N3j9MUUOGeO9qTBVBp1.i2IAUFsOOC(ilgenerator, OpCodes.Newobj, constructorInfo, N3j9MUUOGeO9qTBVBp1.MygUXj5P6N);
				}
				else
				{
					UYciy8UrGRereOdGLqM.i2IAUFsOOC(ilgenerator, OpCodes.Ldtoken, type, UYciy8UrGRereOdGLqM.t1mUDO5w7Y);
					zlhoVEUJgYHXwr3BCPL.i2IAUFsOOC(ilgenerator, OpCodes.Call, X127Q0UR3CERXOhenKY.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Type).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), hIDAYxH6DWLHIthQgC.gSCeTtiku(443897056 << 2 ^ 1054874716 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_2210d7ca22c24335b32d80ca3ef84b8e), X127Q0UR3CERXOhenKY.Bo6UkBGZYT), zlhoVEUJgYHXwr3BCPL.krwUWtuUrb);
					zlhoVEUJgYHXwr3BCPL.i2IAUFsOOC(ilgenerator, OpCodes.Call, X127Q0UR3CERXOhenKY.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(RuntimeHelpers).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), hIDAYxH6DWLHIthQgC.gSCeTtiku(386187679 ^ 1518535601 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_6926da1cf80047d3a6f0516668d22380), X127Q0UR3CERXOhenKY.Bo6UkBGZYT), zlhoVEUJgYHXwr3BCPL.krwUWtuUrb);
					UYciy8UrGRereOdGLqM.i2IAUFsOOC(ilgenerator, OpCodes.Castclass, type, UYciy8UrGRereOdGLqM.t1mUDO5w7Y);
					PybwZDULT8j9uRoXf8D.i2IAUFsOOC(ilgenerator, OpCodes.Dup, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
					PybwZDULT8j9uRoXf8D.i2IAUFsOOC(ilgenerator, OpCodes.Ldarg_0, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
					zlhoVEUJgYHXwr3BCPL.i2IAUFsOOC(ilgenerator, OpCodes.Callvirt, X127Q0UR3CERXOhenKY.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Il2CppObjectBase).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), hIDAYxH6DWLHIthQgC.gSCeTtiku(-1577717134 ^ -1554229795 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_5f6b46e73a464a41b29ca79bf0f3b8f9), X127Q0UR3CERXOhenKY.Bo6UkBGZYT), zlhoVEUJgYHXwr3BCPL.krwUWtuUrb);
					PybwZDULT8j9uRoXf8D.i2IAUFsOOC(ilgenerator, OpCodes.Dup, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
					PybwZDULT8j9uRoXf8D.i2IAUFsOOC(ilgenerator, OpCodes.Ldc_I4_1, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
					UjCL81UbRoyk5Lr84pU.i2IAUFsOOC(ilgenerator, OpCodes.Stsfld, gCZgqYUZrO6iDUQkwRK.i2IAUFsOOC(byRw0gA2NyqHkl03ii9.i2IAUFsOOC(typeof(Il2CppObjectBase).TypeHandle, byRw0gA2NyqHkl03ii9.lfRAy1v3an), hIDAYxH6DWLHIthQgC.gSCeTtiku(-540390967 ^ -1859721191 ^ <Module>{cde795fe-54c1-4a5d-b3ca-315966f8b11e}.m_fa95a52cde3a48319640c03a5a4742a2.m_f65b5965aa9843ea8b738fef02a2c6c9), gCZgqYUZrO6iDUQkwRK.iVLUoyePO3), UjCL81UbRoyk5Lr84pU.jA3UfMc80p);
					ConstructorInfo constructorInfo2 = rOZOoNGrLneGiHEO6cd.i2IAUFsOOC(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, Type.EmptyTypes, rOZOoNGrLneGiHEO6cd.FyVGD3bt2x);
					if (eHiCYiGZ0HINl6pYaQS.i2IAUFsOOC(constructorInfo2, null, eHiCYiGZ0HINl6pYaQS.HO1GoE33S1))
					{
						PybwZDULT8j9uRoXf8D.i2IAUFsOOC(ilgenerator, OpCodes.Dup, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
						PybwZDULT8j9uRoXf8D.i2IAUFsOOC(ilgenerator, OpCodes.Ldarg_0, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
						N3j9MUUOGeO9qTBVBp1.i2IAUFsOOC(ilgenerator, OpCodes.Callvirt, constructorInfo2, N3j9MUUOGeO9qTBVBp1.MygUXj5P6N);
					}
				}
				PybwZDULT8j9uRoXf8D.i2IAUFsOOC(ilgenerator, OpCodes.Ret, PybwZDULT8j9uRoXf8D.TSBU7sUIkv);
				return dynamicMethod.CreateDelegate<Func<IntPtr, T>>();
			}

			// Token: 0x170004D6 RID: 1238
			// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00028C58 File Offset: 0x00026E58
			public static Func<IntPtr, T> Initializer
			{
				get
				{
					Func<IntPtr, T> result;
					if ((result = Il2CppObjectBase.InitializerStore<T>._initializer) == null)
					{
						result = (Il2CppObjectBase.InitializerStore<T>._initializer = Il2CppObjectBase.InitializerStore<T>.Create());
					}
					return result;
				}
			}

			// Token: 0x06000CEB RID: 3307 RVA: 0x00028C78 File Offset: 0x00026E78
			// Note: this type is marked as 'beforefieldinit'.
			static InitializerStore()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x0400097C RID: 2428
			private static Func<IntPtr, T> _initializer;
		}
	}
}
