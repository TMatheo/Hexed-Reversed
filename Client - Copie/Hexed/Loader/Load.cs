using System;
using System.Collections;
using System.IO;
using CoreRuntime.Interfaces;
using CoreRuntime.Manager;

namespace Hexed.Loader
{
	public class Load : HexedCheat
	{
		public override void OnLoad(string[] args)
		{
			string unityLoaderPath = (args != null) ? new FileInfo(args[0]).Directory.Parent.Parent.ToString() : new FileInfo(base.Path).Directory.Parent.Parent.ToString();
			MonoManager.PatchUpdate(typeof(VRCApplication).GetMethod("Update"));
			MonoManager.PatchOnApplicationQuit(typeof(VRCApplicationSetup).GetMethod("OnApplicationQuit"));
			Load.LoadMenu(unityLoaderPath).Start();
		}

		public override void OnApplicationQuit()
		{
			Class48.StopBot();
		}

		public override void OnUpdate()
		{
			Class142.UpdateGlobalModules();
		}

		private static IEnumerator LoadMenu(string UnityLoaderPath)
		{
			Load.<LoadMenu>d__3 <LoadMenu>d__ = new Load.<LoadMenu>d__3(0);
			<LoadMenu>d__.UnityLoaderPath = UnityLoaderPath;
			return <LoadMenu>d__;
		}

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

		internal static bool DBSsV493n9WcswxuIHi()
		{
			return Load.yn6lyx9wWf3pNQyKUDP == null;
		}
		private static Load yn6lyx9wWf3pNQyKUDP;
	}
}
