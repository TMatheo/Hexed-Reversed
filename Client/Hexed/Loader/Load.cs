using System;
using System.Collections;
using System.IO;
using CoreRuntime.Interfaces;
using CoreRuntime.Manager;

namespace Hexed.Loader
{
	// Token: 0x0200015C RID: 348
	public class Load : HexedCheat
	{
		// Token: 0x0600076B RID: 1899 RVA: 0x00024140 File Offset: 0x00022340
		public override void OnLoad(string[] args)
		{
			string unityLoaderPath = (args != null) ? new FileInfo(args[0]).Directory.Parent.Parent.ToString() : new FileInfo(base.Path).Directory.Parent.Parent.ToString();
			MonoManager.PatchUpdate(typeof(VRCApplication).GetMethod("Update"));
			MonoManager.PatchOnApplicationQuit(typeof(VRCApplicationSetup).GetMethod("OnApplicationQuit"));
			Load.LoadMenu(unityLoaderPath).Start();
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000037F5 File Offset: 0x000019F5
		public override void OnApplicationQuit()
		{
			Class48.StopBot();
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x000037FC File Offset: 0x000019FC
		public override void OnUpdate()
		{
			Class142.UpdateGlobalModules();
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00003803 File Offset: 0x00001A03
		private static IEnumerator LoadMenu(string UnityLoaderPath)
		{
			Load.<LoadMenu>d__3 <LoadMenu>d__ = new Load.<LoadMenu>d__3(0);
			<LoadMenu>d__.UnityLoaderPath = UnityLoaderPath;
			return <LoadMenu>d__;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x000241D0 File Offset: 0x000223D0
		private static void LoadExtensions()
		{
			Class114.Init();
			Class118.ChangeTrustColors();
			Class46.Initialize();
			Class118.ApplyEarlyChanges();
			if (!Class4.IsInVr())
			{
				Class56.Init();
			}
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00003812 File Offset: 0x00001A12
		internal static bool DBSsV493n9WcswxuIHi()
		{
			return Load.yn6lyx9wWf3pNQyKUDP == null;
		}

		// Token: 0x0400043D RID: 1085
		private static Load yn6lyx9wWf3pNQyKUDP;
	}
}
