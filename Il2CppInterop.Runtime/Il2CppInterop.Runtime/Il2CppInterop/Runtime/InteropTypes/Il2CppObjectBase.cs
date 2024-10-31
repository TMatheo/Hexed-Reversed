using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using MaoFcf2Vq4taIANM6n;
using pFRqcJyyWJ2hUZv2rN;

namespace Il2CppInterop.Runtime.InteropTypes
{
	// Token: 0x02000125 RID: 293
	public class Il2CppObjectBase
	{
		// Token: 0x06000CB6 RID: 3254 RVA: 0x00012DE4 File Offset: 0x00010FE4
		public Il2CppObjectBase(IntPtr pointer)
		{
			Il2CppObjectBase.CZUEplpY87SfsfCG5U2();
			nHwRpygmi6xxZAssJn.EmlEpH4Phw();
			base..ctor();
			int num = 0;
			if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_791a252a9221476faad2c6d41e84a167 == 0)
			{
				num = 0;
			}
			for (;;)
			{
				switch (num)
				{
				case 1:
					return;
				}
				this.CreateGCHandle(pointer);
				num = 0;
				if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7ac65c3fd4cb4629a8b893be89aed17d != 0)
				{
					num = 1;
				}
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00012E74 File Offset: 0x00011074
		public IntPtr ObjectClass
		{
			get
			{
				return IL2CPP.il2cpp_object_get_class(this.Pointer);
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00012E88 File Offset: 0x00011088
		public IntPtr Pointer
		{
			get
			{
				IntPtr intPtr = IL2CPP.il2cpp_gchandle_get_target(this.myGcHandle);
				if (intPtr == IntPtr.Zero)
				{
					throw new NullReferenceException(Il2CppObjectBase.CsPBTvp8fbXBlFx4Jyl(373277451 ^ 190906605 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ffe1ad8c1cf94bc78c25e67b0264547e));
				}
				return intPtr;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00012EC8 File Offset: 0x000110C8
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_cfadd7e02c524ea298356b7415bd67b6 != 0)
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

		// Token: 0x06000CBA RID: 3258 RVA: 0x00012F38 File Offset: 0x00011138
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
					goto IL_33;
				case 3:
					if (objHdl == IntPtr.Zero)
					{
						num2 = 2;
						continue;
					}
					if (this.isWrapped)
					{
						num2 = 0;
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_b169d8ea412f45e99e430384ddc8908b == 0)
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
						if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6d7a22a8da0c4b3e8cf479dd7edc9922 == 0)
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
			IL_33:
			throw new NullReferenceException();
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00012FEC File Offset: 0x000111EC
		internal unsafe static T UnboxUnsafe<T>(IntPtr pointer)
		{
			IntPtr nativeClassPtr = Il2CppClassPointerStore<T>.NativeClassPtr;
			if (nativeClassPtr == IntPtr.Zero)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV));
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(55428970 ^ 1176879734 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_6dbfd13d96434eb59d868fecd0ad1cda), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				throw new ArgumentException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
			}
			IntPtr intPtr = IL2CPP.il2cpp_object_get_class(pointer);
			if (!IL2CPP.il2cpp_class_is_assignable_from(nativeClassPtr, intPtr))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 2);
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-544074002 ^ -681349693 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_124ad935e0834fda9ae7f452377dbe1c), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, NhVqEZcsN2QCAbSXXGD.muOq5LWqgj(IL2CPP.il2cpp_class_get_name(intPtr), NhVqEZcsN2QCAbSXXGD.H2PcSqhykC), CbStEuAV6XsjbRRcotu.WZrA06bJrN);
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(1129513093 ^ 1213174783 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e6eb36653ec04a89bf8fa64932849f3b), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV));
				throw new InvalidCastException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
			}
			IntPtr intPtr2 = IL2CPP.il2cpp_object_unbox(pointer);
			return *Unsafe.AsRef<T>(Mw7IMTckZt48JAHG0WH.muOq5LWqgj(ref intPtr2, Mw7IMTckZt48JAHG0WH.u8Gc2tmlLS));
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00013134 File Offset: 0x00011334
		public T Unbox<[IsUnmanaged] T>() where T : struct, ValueType
		{
			return Il2CppObjectBase.UnboxUnsafe<T>(this.Pointer);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00013148 File Offset: 0x00011348
		public T Cast<T>() where T : Il2CppObjectBase
		{
			T t = this.TryCast<T>();
			if (t == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 2);
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-1852219397 >> 2 ^ -325636909 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_124ad935e0834fda9ae7f452377dbe1c), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				CbStEuAV6XsjbRRcotu.muOq5LWqgj(ref defaultInterpolatedStringHandler, NhVqEZcsN2QCAbSXXGD.muOq5LWqgj(IL2CPP.il2cpp_class_get_name(IL2CPP.il2cpp_object_get_class(this.Pointer)), NhVqEZcsN2QCAbSXXGD.H2PcSqhykC), CbStEuAV6XsjbRRcotu.WZrA06bJrN);
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-94957632 ^ -358590348 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_7dfb1d10537744ca9e949b6b3a3eac09), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV));
				throw new InvalidCastException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
			}
			return t;
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x0001321C File Offset: 0x0001141C
		public T TryCast<T>() where T : Il2CppObjectBase
		{
			IntPtr nativeClassPtr = Il2CppClassPointerStore<T>.NativeClassPtr;
			if (nativeClassPtr == IntPtr.Zero)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 1);
				defaultInterpolatedStringHandler.AppendFormatted<Type>(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV));
				gNvtmAqVGiPoaikm7Qe.muOq5LWqgj(ref defaultInterpolatedStringHandler, hIDAYxH6DWLHIthQgC.gSCeTtiku(-488741256 ^ -1773556928 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_8378a46aa7ed47018832a42729b1bc3b), gNvtmAqVGiPoaikm7Qe.caZq0g9xkW);
				throw new ArgumentException(AB0cwrqss60xewxtTc1.muOq5LWqgj(ref defaultInterpolatedStringHandler, AB0cwrqss60xewxtTc1.IlIqSuRBy7));
			}
			IntPtr oklass = IL2CPP.il2cpp_object_get_class(this.Pointer);
			if (!IL2CPP.il2cpp_class_is_assignable_from(nativeClassPtr, oklass))
			{
				return default(T);
			}
			return Il2CppObjectBase.InitializerStore<T>.Initializer(this.Pointer);
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x000132CC File Offset: 0x000114CC
		protected override void Finalize()
		{
			switch (1)
			{
			case 1:
				try
				{
					IL2CPP.il2cpp_gchandle_free(this.myGcHandle);
					int num = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_4c6a46c0a2d14747aa1dc5bf1581154d != 0)
					{
						num = 0;
					}
					switch (num)
					{
					}
				}
				finally
				{
					Il2CppObjectBase.O9Ih6apnpnIZaJPnG7B(this, RFeleXcNniEBxuhjBjt.IZScuMjUmo);
					int num2 = 0;
					if (<Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_ffe1ad8c1cf94bc78c25e67b0264547e == 0)
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

		// Token: 0x06000CC0 RID: 3264 RVA: 0x000133B4 File Offset: 0x000115B4
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppObjectBase()
		{
			Il2CppObjectBase.aDRP9Upb1LYeK8YVOI4();
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x000133C4 File Offset: 0x000115C4
		internal static void CZUEplpY87SfsfCG5U2()
		{
			hIDAYxH6DWLHIthQgC.oDuBOTgYK();
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x000133D4 File Offset: 0x000115D4
		internal static bool CQ8DjxpvUdkCH72nMSE()
		{
			return Il2CppObjectBase.XkbCJoptApjPjsc3flT == null;
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x000133E8 File Offset: 0x000115E8
		internal static Il2CppObjectBase lAC7ggpxG90yYiyAYnA()
		{
			return Il2CppObjectBase.XkbCJoptApjPjsc3flT;
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x000133F8 File Offset: 0x000115F8
		internal static object CsPBTvp8fbXBlFx4Jyl(int \u0020)
		{
			return hIDAYxH6DWLHIthQgC.gSCeTtiku(\u0020);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x0001340C File Offset: 0x0001160C
		internal static void O9Ih6apnpnIZaJPnG7B(object A_0, object A_1)
		{
			RFeleXcNniEBxuhjBjt.muOq5LWqgj(A_0, A_1);
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00013424 File Offset: 0x00011624
		internal static void aDRP9Upb1LYeK8YVOI4()
		{
			hIDAYxH6DWLHIthQgC.zSLipEDdx();
		}

		// Token: 0x0400096E RID: 2414
		internal bool isWrapped;

		// Token: 0x0400096F RID: 2415
		private uint myGcHandle;

		// Token: 0x04000970 RID: 2416
		private static Il2CppObjectBase XkbCJoptApjPjsc3flT;

		// Token: 0x02000126 RID: 294
		internal static class InitializerStore<T>
		{
			// Token: 0x06000CC7 RID: 3271 RVA: 0x00027CE4 File Offset: 0x00025EE4
			private static Func<IntPtr, T> Create()
			{
				Type type = Il2CppClassPointerStore<T>.CreatedTypeRedirect ?? KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV);
				DynamicMethod dynamicMethod = new DynamicMethod(NcUD7JLAPSgAlBXsvpB.muOq5LWqgj(hIDAYxH6DWLHIthQgC.gSCeTtiku(~1524453083 ^ -670491268 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_92b82ae23c6544f3a11e54f2fed3ad25), rnSTF5kYR3v02NE5RJS.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(T).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), rnSTF5kYR3v02NE5RJS.Skkk8lfW2d), hIDAYxH6DWLHIthQgC.gSCeTtiku(-1358012481 ^ -1581788052 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_f2d764a5c50346e296f681b93e45dafa), NcUD7JLAPSgAlBXsvpB.YrNLLbPNO6), type, new Type[]
				{
					KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(IntPtr).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV)
				});
				T81oDLknAWAnLFQ09Jf.muOq5LWqgj(dynamicMethod, 0, ParameterAttributes.None, hIDAYxH6DWLHIthQgC.gSCeTtiku(1651941374 ^ 920542243 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e5b00aa4c99144c78d3bd63e270496cb), T81oDLknAWAnLFQ09Jf.xM8kbaWatR);
				ILGenerator ilgenerator = dr5pjw5kUmWnx1oVRTn.muOq5LWqgj(dynamicMethod, dr5pjw5kUmWnx1oVRTn.pod52cShcT);
				ConstructorInfo constructorInfo = acurH454kQoe5Lch99S.muOq5LWqgj(type, new Type[]
				{
					KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(IntPtr).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV)
				}, acurH454kQoe5Lch99S.yqo53muOE4);
				if (constructorInfo != null)
				{
					sWLRHR5OB7hMDvnerut.muOq5LWqgj(ilgenerator, OpCodes.Ldarg_0, sWLRHR5OB7hMDvnerut.sr65tXjFly);
					UHLYWh5fwXimKj8H332.muOq5LWqgj(ilgenerator, OpCodes.Newobj, constructorInfo, UHLYWh5fwXimKj8H332.WjH515pX3x);
				}
				else
				{
					jVPCDT5ng9KYNuYJDSc.muOq5LWqgj(ilgenerator, OpCodes.Ldtoken, type, jVPCDT5ng9KYNuYJDSc.Li15bXtDZ7);
					nlOWSv5YwlZX9e40I0P.muOq5LWqgj(ilgenerator, OpCodes.Call, DnZ9sC5vW5Zmyo7jjbr.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Type).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), hIDAYxH6DWLHIthQgC.gSCeTtiku(-1614274677 + -126383854 ^ -2004851181 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_e9e27b2b1c8849e199673444ab2b6dae), DnZ9sC5vW5Zmyo7jjbr.gLJ5xeKxO6), nlOWSv5YwlZX9e40I0P.h1i58mR3Ok);
					nlOWSv5YwlZX9e40I0P.muOq5LWqgj(ilgenerator, OpCodes.Call, DnZ9sC5vW5Zmyo7jjbr.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(RuntimeHelpers).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), hIDAYxH6DWLHIthQgC.gSCeTtiku(-588770852 ^ 1913313288 ^ -1990134346 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_49f6034724814fe88f4ca6e5ef134249), DnZ9sC5vW5Zmyo7jjbr.gLJ5xeKxO6), nlOWSv5YwlZX9e40I0P.h1i58mR3Ok);
					jVPCDT5ng9KYNuYJDSc.muOq5LWqgj(ilgenerator, OpCodes.Castclass, type, jVPCDT5ng9KYNuYJDSc.Li15bXtDZ7);
					sWLRHR5OB7hMDvnerut.muOq5LWqgj(ilgenerator, OpCodes.Dup, sWLRHR5OB7hMDvnerut.sr65tXjFly);
					sWLRHR5OB7hMDvnerut.muOq5LWqgj(ilgenerator, OpCodes.Ldarg_0, sWLRHR5OB7hMDvnerut.sr65tXjFly);
					nlOWSv5YwlZX9e40I0P.muOq5LWqgj(ilgenerator, OpCodes.Callvirt, DnZ9sC5vW5Zmyo7jjbr.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Il2CppObjectBase).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), hIDAYxH6DWLHIthQgC.gSCeTtiku(1094358228 ^ 891461245 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_2a3cb7fb82fa47c39f707a2393c1a340), DnZ9sC5vW5Zmyo7jjbr.gLJ5xeKxO6), nlOWSv5YwlZX9e40I0P.h1i58mR3Ok);
					sWLRHR5OB7hMDvnerut.muOq5LWqgj(ilgenerator, OpCodes.Dup, sWLRHR5OB7hMDvnerut.sr65tXjFly);
					sWLRHR5OB7hMDvnerut.muOq5LWqgj(ilgenerator, OpCodes.Ldc_I4_1, sWLRHR5OB7hMDvnerut.sr65tXjFly);
					XDXsAI5JhviMqbZ85AS.muOq5LWqgj(ilgenerator, OpCodes.Stsfld, MAorCg56yGa3HPtjiY3.muOq5LWqgj(KrP4bwqDeBbRGf2nlBC.muOq5LWqgj(typeof(Il2CppObjectBase).TypeHandle, KrP4bwqDeBbRGf2nlBC.cd8qmkqhJV), hIDAYxH6DWLHIthQgC.gSCeTtiku(-1066070775 ^ -703766846 ^ <Module>{7960342e-06bd-4980-8bb2-20d91fd727fe}.m_d0153a99ea94469083b73704bf320112.m_3e36778f33984767b2e7264fa31cee60), MAorCg56yGa3HPtjiY3.iVx5yLylyX), XDXsAI5JhviMqbZ85AS.RAX5p2dieA);
					ConstructorInfo constructorInfo2 = VW7lGvk6bdXaL1dDn8Y.muOq5LWqgj(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, Type.EmptyTypes, VW7lGvk6bdXaL1dDn8Y.tUPkysgHcl);
					if (RjvqbgkJeYJw2D4W5Km.muOq5LWqgj(constructorInfo2, null, RjvqbgkJeYJw2D4W5Km.Lr7kptPqlU))
					{
						sWLRHR5OB7hMDvnerut.muOq5LWqgj(ilgenerator, OpCodes.Dup, sWLRHR5OB7hMDvnerut.sr65tXjFly);
						sWLRHR5OB7hMDvnerut.muOq5LWqgj(ilgenerator, OpCodes.Ldarg_0, sWLRHR5OB7hMDvnerut.sr65tXjFly);
						UHLYWh5fwXimKj8H332.muOq5LWqgj(ilgenerator, OpCodes.Callvirt, constructorInfo2, UHLYWh5fwXimKj8H332.WjH515pX3x);
					}
				}
				sWLRHR5OB7hMDvnerut.muOq5LWqgj(ilgenerator, OpCodes.Ret, sWLRHR5OB7hMDvnerut.sr65tXjFly);
				return dynamicMethod.CreateDelegate<Func<IntPtr, T>>();
			}

			// Token: 0x170004D6 RID: 1238
			// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x00028000 File Offset: 0x00026200
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

			// Token: 0x06000CC9 RID: 3273 RVA: 0x00028020 File Offset: 0x00026220
			// Note: this type is marked as 'beforefieldinit'.
			static InitializerStore()
			{
				hIDAYxH6DWLHIthQgC.zSLipEDdx();
			}

			// Token: 0x04000971 RID: 2417
			private static Func<IntPtr, T> _initializer;
		}
	}
}
