using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Hexed.Wrappers;
using UnityEngine;

// Token: 0x0200015F RID: 351
internal class Class142
{
	// Token: 0x0600077D RID: 1917 RVA: 0x00024930 File Offset: 0x00022B30
	public static void CreateHooks()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
		{
			if (!type.IsAbstract && typeof(Interface3).IsAssignableFrom(type))
			{
				Interface3 @interface = (Interface3)Activator.CreateInstance(type);
				try
				{
					if (!Class4.IsInVr())
					{
						if (!(@interface is Interface5))
						{
							@interface.Initialize();
							Class142.list_0.Add(@interface);
						}
					}
					else if (!(@interface is Interface1))
					{
						@interface.Initialize();
						Class142.list_0.Add(@interface);
					}
				}
				catch (Exception value)
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Failed to Hook ");
					defaultInterpolatedStringHandler.AppendFormatted(@interface.GetType().Name);
					defaultInterpolatedStringHandler.AppendLiteral(": ");
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
					Logger.LogError(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
		defaultInterpolatedStringHandler.AppendLiteral("Loaded ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(Class142.list_0.Count);
		defaultInterpolatedStringHandler.AppendLiteral(" Hooks");
		Logger.LogDebug(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x00024A80 File Offset: 0x00022C80
	public static void CreateGlobalModules()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
		{
			if (!type.IsAbstract && typeof(Interface2).IsAssignableFrom(type))
			{
				Interface2 @interface = (Interface2)Activator.CreateInstance(type);
				try
				{
					if (!Class4.IsInVr())
					{
						if (!(@interface is Interface5))
						{
							@interface.Initialize();
							Class142.list_1.Add(@interface);
						}
					}
					else if (!(@interface is Interface1))
					{
						@interface.Initialize();
						Class142.list_1.Add(@interface);
					}
				}
				catch (Exception value)
				{
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Failed to Initialize ");
					defaultInterpolatedStringHandler.AppendFormatted(@interface.GetType().Name);
					defaultInterpolatedStringHandler.AppendLiteral(": ");
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
					Logger.LogError(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
		defaultInterpolatedStringHandler.AppendLiteral("Loaded ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(Class142.list_1.Count);
		defaultInterpolatedStringHandler.AppendLiteral(" Global Modules");
		Logger.LogDebug(defaultInterpolatedStringHandler.ToStringAndClear());
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x00024BD0 File Offset: 0x00022DD0
	public static void UpdateGlobalModules()
	{
		bool flag = false;
		foreach (Interface2 @interface in Class142.list_1)
		{
			if (!(@interface is Interface0))
			{
				@interface.OnUpdate();
			}
			else if (Time.time > Class142.float_0)
			{
				@interface.OnUpdate();
				flag = true;
			}
		}
		if (flag)
		{
			Class142.float_0 = Time.time + 0.15f;
		}
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x00024C60 File Offset: 0x00022E60
	public static void CreatePlayerModules(VRCPlayer player)
	{
		foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
		{
			if (!type.IsAbstract && typeof(Interface4).IsAssignableFrom(type))
			{
				Interface4 @interface = (Interface4)Activator.CreateInstance(type);
				int key = player.GetPhotonPlayer().ActorID();
				try
				{
					if (!Class4.IsInVr())
					{
						if (!(@interface is Interface5))
						{
							@interface.Initialize(player);
							if (Class142.dictionary_0.ContainsKey(key))
							{
								Class142.dictionary_0[key].Add(@interface);
							}
							else
							{
								Class142.dictionary_0.Add(key, new List<Interface4>
								{
									@interface
								});
							}
						}
					}
					else if (!(@interface is Interface1))
					{
						@interface.Initialize(player);
						if (!Class142.dictionary_0.ContainsKey(key))
						{
							Class142.dictionary_0.Add(key, new List<Interface4>
							{
								@interface
							});
						}
						else
						{
							Class142.dictionary_0[key].Add(@interface);
						}
					}
				}
				catch (Exception value)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
					defaultInterpolatedStringHandler.AppendLiteral("Failed to Initialize ");
					defaultInterpolatedStringHandler.AppendFormatted(@interface.GetType().Name);
					defaultInterpolatedStringHandler.AppendLiteral(": ");
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
					Logger.LogError(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
		}
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x00024DE0 File Offset: 0x00022FE0
	public static Interface4 GetPlayerModuleByClass(int Actor, Type Class)
	{
		List<Interface4> source;
		if (Class142.dictionary_0.TryGetValue(Actor, out source))
		{
			return source.FirstOrDefault((Interface4 x) => x.GetType() == Class);
		}
		return null;
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x00024E24 File Offset: 0x00023024
	public static void DestroyPlayerModules(int Actor)
	{
		if (Class142.dictionary_0.ContainsKey(Actor))
		{
			Class142.dictionary_0.Remove(Actor);
		}
		if (Class142.dictionary_1.ContainsKey(Actor))
		{
			Class142.dictionary_1.Remove(Actor);
		}
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x00024E64 File Offset: 0x00023064
	public static void DestroyAllPlayerModules()
	{
		Class142.dictionary_0.Clear();
		Class142.dictionary_1.Clear();
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x00024E88 File Offset: 0x00023088
	public static void UpdatePlayerModules(int Actor)
	{
		bool flag = false;
		IEnumerable<KeyValuePair<int, List<Interface4>>> source = Class142.dictionary_0;
		Func<KeyValuePair<int, List<Interface4>>, bool> func_0;
		Func<KeyValuePair<int, List<Interface4>>, bool> predicate;
		if ((predicate = func_0) == null)
		{
			predicate = (func_0 = ((KeyValuePair<int, List<Interface4>> x) => x.Value != null && x.Key == Actor));
		}
		foreach (KeyValuePair<int, List<Interface4>> keyValuePair in source.Where(predicate))
		{
			foreach (Interface4 @interface in keyValuePair.Value)
			{
				if (@interface is Interface0)
				{
					if (!Class142.dictionary_1.ContainsKey(Actor))
					{
						Class142.dictionary_1.Add(Actor, Time.time);
					}
					if (Time.time > Class142.dictionary_1[Actor])
					{
						@interface.OnUpdate();
						flag = true;
					}
				}
				else
				{
					@interface.OnUpdate();
				}
			}
		}
		if (flag)
		{
			Class142.dictionary_1[Actor] = Time.time + 0.15f;
		}
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x00003838 File Offset: 0x00001A38
	internal static bool Sgcjed9EtFsfT9cfQr1()
	{
		return Class142.NRQYvN9klZIUQCZWcOv == null;
	}

	// Token: 0x04000445 RID: 1093
	private static readonly List<Interface3> list_0 = new List<Interface3>();

	// Token: 0x04000446 RID: 1094
	private static readonly List<Interface2> list_1 = new List<Interface2>();

	// Token: 0x04000447 RID: 1095
	private static float float_0 = Time.time;

	// Token: 0x04000448 RID: 1096
	private static readonly Dictionary<int, List<Interface4>> dictionary_0 = new Dictionary<int, List<Interface4>>();

	// Token: 0x04000449 RID: 1097
	private static readonly Dictionary<int, float> dictionary_1 = new Dictionary<int, float>();

	// Token: 0x0400044A RID: 1098
	internal static Class142 NRQYvN9klZIUQCZWcOv;
}
