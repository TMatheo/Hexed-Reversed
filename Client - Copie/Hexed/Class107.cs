using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CoreRuntime.Manager;
using Hexed.Wrappers;
using VRC.Core;
using WebSocketSharp;

// Token: 0x02000103 RID: 259
internal class Class107 : Interface3
{
	// Token: 0x06000527 RID: 1319 RVA: 0x0001A2C0 File Offset: 0x000184C0
	public void Initialize()
	{
		MethodInfo method = typeof(WebSocket).GetMethod("messagec");
		Class107.Delegate38 detour;
		if ((detour = Class107.<>O.delegate38_0) == null)
		{
			detour = (Class107.<>O.delegate38_0 = new Class107.Delegate38(Class107.Patch));
		}
		Class107.delegate38_0 = HookManager.Detour<Class107.Delegate38>(method, detour);
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x0001A308 File Offset: 0x00018508
	private static void Patch(IntPtr instance, IntPtr __0)
	{
		Class107.delegate38_0(instance, __0);
		MessageEventArgs messageEventArgs = (__0 == IntPtr.Zero) ? null : new MessageEventArgs(__0);
		if (messageEventArgs == null || messageEventArgs.Data == null)
		{
			return;
		}
		if (Class143.bool_6)
		{
			Logger.Log(messageEventArgs.Data, Logger.LogsType.Info);
		}
		if ((!messageEventArgs.Data.StartsWith("{") || !messageEventArgs.Data.EndsWith("}")) && (!messageEventArgs.Data.StartsWith("[") || !messageEventArgs.Data.EndsWith("]")))
		{
			return;
		}
		Class12.Class13 @class = JsonSerializer.Deserialize<Class12.Class13>(messageEventArgs.Data, null);
		if (@class != null)
		{
			string type = @class.type;
			if (type != null)
			{
				switch (type.Length)
				{
				case 10:
				{
					char c = type[0];
					if (c != 'f')
					{
						if (c == 'g')
						{
							if (type == "group-left")
							{
								Class12.Class24 class24_0 = JsonSerializer.Deserialize<Class12.Class24>(@class.content, null);
								APIGroup.GetGroup(class24_0.groupId, delegate(APIGroup group)
								{
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(20, 2);
									defaultInterpolatedStringHandler2.AppendLiteral("You left a Group ");
									defaultInterpolatedStringHandler2.AppendFormatted(group.name);
									defaultInterpolatedStringHandler2.AppendLiteral(" [");
									defaultInterpolatedStringHandler2.AppendFormatted(class24_0.groupId);
									defaultInterpolatedStringHandler2.AppendLiteral("]");
									Logger.Log(defaultInterpolatedStringHandler2.ToStringAndClear(), Logger.LogsType.Group);
									Class53.Log("Group left --> " + group.name, Class53.LogsType.Group);
								}, delegate(string error)
								{
									Logger.Log("You left a Group [" + class24_0.groupId + "]", Logger.LogsType.Group);
									Class53.Log("Group left --> " + class24_0.groupId, Class53.LogsType.Group);
								});
								return;
							}
						}
					}
					else if (type == "friend-add")
					{
						Class12.Class14 class2 = JsonSerializer.Deserialize<Class12.Class14>(@class.content, null);
						Logger.Log("You and " + class2.user.displayName + " friended", Logger.LogsType.Friends);
						Class53.Log(class2.user.displayName + " --> Friend", Class53.LogsType.Friend);
						return;
					}
					break;
				}
				case 11:
					if (type == "user-update")
					{
						return;
					}
					break;
				case 12:
				{
					char c = type[0];
					if (c != 'g')
					{
						if (c == 'n')
						{
							if (type == "notification")
							{
								Class12.Class21 class3 = JsonSerializer.Deserialize<Class12.Class21>(@class.content, null);
								string type2 = class3.type;
								if (type2 == "invite")
								{
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 3);
									defaultInterpolatedStringHandler.AppendFormatted(class3.senderUsername);
									defaultInterpolatedStringHandler.AppendLiteral(" invited you to ");
									defaultInterpolatedStringHandler.AppendFormatted(class3.details.worldName);
									defaultInterpolatedStringHandler.AppendLiteral(" [");
									defaultInterpolatedStringHandler.AppendFormatted(class3.details.worldId);
									defaultInterpolatedStringHandler.AppendLiteral("]");
									Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Friends);
									Class53.Log(class3.senderUsername + " --> Invite", Class53.LogsType.Notification);
									return;
								}
								if (type2 == "friendRequest")
								{
									Logger.Log(class3.senderUsername + " sent a Friend Request", Logger.LogsType.Friends);
									Class53.Log(class3.senderUsername + " --> Request", Class53.LogsType.Friend);
									return;
								}
								if (type2 == "requestInvite")
								{
									Logger.Log(class3.senderUsername + " sent a Invite Request", Logger.LogsType.Friends);
									Class53.Log(class3.senderUsername + " --> Invite Request", Class53.LogsType.Notification);
									return;
								}
								if (type2 == "inviteResponse")
								{
									Logger.Log(class3.senderUsername + " declined your Invite", Logger.LogsType.Friends);
									Class53.Log(class3.senderUsername + " --> Declined Invite", Class53.LogsType.Notification);
									return;
								}
								if (type2 == "requestInviteResponse")
								{
									Logger.Log(class3.senderUsername + " declined your Invite Request", Logger.LogsType.Friends);
									Class53.Log(class3.senderUsername + " --> Declined Invite Request", Class53.LogsType.Notification);
									return;
								}
								if (!(type2 == "message"))
								{
									return;
								}
								Logger.Log(class3.senderUsername + " sent message: " + class3.message, Logger.LogsType.Friends);
								Class53.Log(class3.senderUsername + " --> Message", Class53.LogsType.Notification);
								return;
							}
						}
					}
					else if (type == "group-joined")
					{
						Class12.Class23 class23_0 = JsonSerializer.Deserialize<Class12.Class23>(@class.content, null);
						APIGroup.GetGroup(class23_0.groupId, delegate(APIGroup group)
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(22, 2);
							defaultInterpolatedStringHandler2.AppendLiteral("You joined a Group ");
							defaultInterpolatedStringHandler2.AppendFormatted(group.name);
							defaultInterpolatedStringHandler2.AppendLiteral(" [");
							defaultInterpolatedStringHandler2.AppendFormatted(class23_0.groupId);
							defaultInterpolatedStringHandler2.AppendLiteral("]");
							Logger.Log(defaultInterpolatedStringHandler2.ToStringAndClear(), Logger.LogsType.Group);
							Class53.Log("Group joined --> " + group.name, Class53.LogsType.Group);
						}, delegate(string error)
						{
							Logger.Log("You joined a Group [" + class23_0.groupId + "]", Logger.LogsType.Group);
							Class53.Log("Group joined --> " + class23_0.groupId, Class53.LogsType.Group);
						});
						return;
					}
					break;
				}
				case 13:
				{
					char c = type[7];
					switch (c)
					{
					case 'a':
						if (type == "friend-active")
						{
							Class12.Class18 class4 = JsonSerializer.Deserialize<Class12.Class18>(@class.content, null);
							Logger.Log(class4.user.displayName + " is now Online [Website]", Logger.LogsType.Friends);
							Class53.Log(class4.user.displayName + " [Website]", Class53.LogsType.Online);
							return;
						}
						break;
					case 'b':
						break;
					case 'c':
						if (type == "user-location")
						{
							return;
						}
						break;
					case 'd':
						if (type == "friend-delete")
						{
							Class12.Class17 class17_0 = JsonSerializer.Deserialize<Class12.Class17>(@class.content, null);
							APIUser.FetchUser(class17_0.userId, delegate(APIUser user)
							{
								Logger.Log("You and " + user.DisplayName() + " unfriended", Logger.LogsType.Friends);
								Class53.Log(user.DisplayName() + " --> Unfriend", Class53.LogsType.Friend);
							}, delegate(string error)
							{
								Logger.Log("You and " + class17_0.userId + " unfriended", Logger.LogsType.Friends);
								Class53.Log(class17_0.userId + " --> Unfriend", Class53.LogsType.Friend);
							});
							return;
						}
						break;
					default:
						if (c != 'o')
						{
							if (c == 'u')
							{
								if (type == "friend-update")
								{
									return;
								}
							}
						}
						else if (type == "friend-online")
						{
							Class12.Class15 class5 = JsonSerializer.Deserialize<Class12.Class15>(@class.content, null);
							string str = (class5.user.last_platform == "standalonewindows") ? "Windows" : "Android";
							Logger.Log(class5.user.displayName + " is now Online [" + str + "]", Logger.LogsType.Friends);
							Class53.Log(class5.user.displayName + " [" + str + "]", Class53.LogsType.Online);
							return;
						}
						break;
					}
					break;
				}
				case 14:
				{
					char c = type[0];
					if (c != 'c')
					{
						if (c == 'f')
						{
							if (type == "friend-offline")
							{
								Class12.Class16 class16_0 = JsonSerializer.Deserialize<Class12.Class16>(@class.content, null);
								APIUser.FetchUser(class16_0.userId, delegate(APIUser user)
								{
									Logger.Log(user.DisplayName() + " is now Offline", Logger.LogsType.Friends);
									Class53.Log(user.DisplayName(), Class53.LogsType.Offline);
								}, delegate(string error)
								{
									Logger.Log(class16_0.userId + " is now Offline", Logger.LogsType.Friends);
									Class53.Log(class16_0.userId, Class53.LogsType.Offline);
								});
								return;
							}
						}
					}
					else if (type == "content-upload")
					{
						Class12.Class25 class6 = JsonSerializer.Deserialize<Class12.Class25>(@class.content, null);
						Logger.Log("You uploaded content " + class6.contentType, Logger.LogsType.Info);
						Class53.Log("Content uploaded --> " + class6.contentType, Class53.LogsType.Content);
						return;
					}
					break;
				}
				case 15:
				{
					char c = type[0];
					if (c > 'f')
					{
						if (c != 'i')
						{
							if (c == 'n')
							{
								if (type == "notification-v2")
								{
									string type2 = JsonSerializer.Deserialize<Class12.Class22>(@class.content, null).type;
									if (!(type2 == "group.announcement"))
									{
										type2 == "group.invite";
										return;
									}
									return;
								}
							}
						}
						else if (type == "instance-closed")
						{
							JsonSerializer.Deserialize<Class12.Class32>(@class.content, null);
							Logger.Log("Your Instance is getting closed", Logger.LogsType.Room);
							Class53.Log("Instance --> Closed", Class53.LogsType.Room);
							return;
						}
					}
					else if (c != 'c')
					{
						if (c == 'f')
						{
							if (type == "friend-location")
							{
								Class12.Class19 class19_0 = JsonSerializer.Deserialize<Class12.Class19>(@class.content, null);
								if (class19_0.location == "private")
								{
									Logger.Log(class19_0.user.displayName + " is now in PRIVATE", Logger.LogsType.Friends);
									Class53.Log(class19_0.user.displayName + " --> PRIVATE", Class53.LogsType.World);
									return;
								}
								if (class19_0.location == "traveling")
								{
									InstanceAccessType worldType = Class4.GetWorldType(class19_0.travelingToLocation);
									string string_0 = Class4.GetLocalizedWorldType(worldType);
									new ApiWorld
									{
										id = class19_0.travelingToLocation.Split(':', StringSplitOptions.None)[0]
									}.Fetch(delegate(ApiContainer container)
									{
										new ApiModelContainer<ApiWorld>().setFromContainer(container);
										ApiWorld apiWorld = container.Model.Cast<ApiWorld>();
										DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(17, 4);
										defaultInterpolatedStringHandler2.AppendFormatted(class19_0.user.displayName);
										defaultInterpolatedStringHandler2.AppendLiteral(" is now in ");
										defaultInterpolatedStringHandler2.AppendFormatted(apiWorld.name);
										defaultInterpolatedStringHandler2.AppendLiteral(" [");
										defaultInterpolatedStringHandler2.AppendFormatted(string_0);
										defaultInterpolatedStringHandler2.AppendLiteral("] [");
										defaultInterpolatedStringHandler2.AppendFormatted(class19_0.travelingToLocation);
										defaultInterpolatedStringHandler2.AppendLiteral("]");
										Logger.Log(defaultInterpolatedStringHandler2.ToStringAndClear(), Logger.LogsType.Friends);
										defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(8, 3);
										defaultInterpolatedStringHandler2.AppendFormatted(class19_0.user.displayName);
										defaultInterpolatedStringHandler2.AppendLiteral(" --> ");
										defaultInterpolatedStringHandler2.AppendFormatted(apiWorld.name);
										defaultInterpolatedStringHandler2.AppendLiteral(" [");
										defaultInterpolatedStringHandler2.AppendFormatted(string_0);
										defaultInterpolatedStringHandler2.AppendLiteral("]");
										Class53.Log(defaultInterpolatedStringHandler2.ToStringAndClear(), Class53.LogsType.World);
									}, delegate(ApiContainer container)
									{
										DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(24, 3);
										defaultInterpolatedStringHandler2.AppendFormatted(class19_0.user.displayName);
										defaultInterpolatedStringHandler2.AppendLiteral(" is now in UNKNOWN [");
										defaultInterpolatedStringHandler2.AppendFormatted(string_0);
										defaultInterpolatedStringHandler2.AppendLiteral("] [");
										defaultInterpolatedStringHandler2.AppendFormatted(class19_0.travelingToLocation);
										defaultInterpolatedStringHandler2.AppendLiteral("]");
										Logger.Log(defaultInterpolatedStringHandler2.ToStringAndClear(), Logger.LogsType.Friends);
										Class53.Log(class19_0.user.displayName + " --> UNKNOWN [" + string_0 + "]", Class53.LogsType.World);
									}, null, false, 2);
									return;
								}
								return;
							}
						}
					}
					else if (type == "content-refresh")
					{
						Class12.Class26 class7 = JsonSerializer.Deserialize<Class12.Class26>(@class.content, null);
						Logger.Log("You " + class7.actionType + " content " + class7.contentType, Logger.LogsType.Info);
						Class53.Log("Content " + class7.actionType + " --> " + class7.contentType, Class53.LogsType.Content);
						return;
					}
					break;
				}
				case 16:
					if (type == "see-notification")
					{
						return;
					}
					break;
				case 17:
					if (type == "hide-notification")
					{
						return;
					}
					break;
				case 18:
				{
					char c = type[0];
					if (c != 'c')
					{
						if (c == 'g')
						{
							if (type == "group-role-updated")
							{
								return;
							}
						}
					}
					else if (type == "clear-notification")
					{
						return;
					}
					break;
				}
				case 20:
				{
					char c = type[0];
					if (c != 'g')
					{
						if (c == 'i')
						{
							if (type == "instance-queue-ready")
							{
								JsonSerializer.Deserialize<Class12.Class31>(@class.content, null);
								Logger.Log("Your Instance is ready to join", Logger.LogsType.Info);
								Class53.Log("Position --> Ready", Class53.LogsType.Queue);
								return;
							}
						}
					}
					else if (type == "group-member-updated")
					{
						return;
					}
					break;
				}
				case 21:
				{
					char c = type[0];
					if (c != 'i')
					{
						if (c != 'r')
						{
							if (c == 'u')
							{
								if (type == "user-badge-unassigned")
								{
									Class12.Class33 class8 = JsonSerializer.Deserialize<Class12.Class33>(@class.content, null);
									Logger.Log("Badge unassigned " + class8.badgeId, Logger.LogsType.Info);
									Class53.Log("Badge unassigned --> " + class8.badgeId, Class53.LogsType.Content);
									return;
								}
							}
						}
						else if (type == "response-notification")
						{
							return;
						}
					}
					else if (type == "instance-queue-joined")
					{
						Class12.Class29 class9 = JsonSerializer.Deserialize<Class12.Class29>(@class.content, null);
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 1);
						defaultInterpolatedStringHandler.AppendLiteral("You joined a Instance queue at Position ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(class9.position);
						Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Info);
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
						defaultInterpolatedStringHandler.AppendLiteral("Position --> Joined ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(class9.position);
						Class53.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Class53.LogsType.Queue);
						return;
					}
					break;
				}
				case 22:
				{
					char c = type[16];
					if (c != 'd')
					{
						if (c == 'u')
						{
							if (type == "notification-v2-update")
							{
								return;
							}
						}
					}
					else if (type == "notification-v2-delete")
					{
						return;
					}
					break;
				}
				case 23:
					if (type == "instance-queue-position")
					{
						Class12.Class30 class10 = JsonSerializer.Deserialize<Class12.Class30>(@class.content, null);
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(35, 2);
						defaultInterpolatedStringHandler.AppendLiteral("Your Position at Queue changed to ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(class10.position);
						defaultInterpolatedStringHandler.AppendLiteral("/");
						defaultInterpolatedStringHandler.AppendFormatted<int>(class10.queueSize);
						Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Info);
						defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 2);
						defaultInterpolatedStringHandler.AppendLiteral("Position --> ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(class10.position);
						defaultInterpolatedStringHandler.AppendLiteral("/");
						defaultInterpolatedStringHandler.AppendFormatted<int>(class10.queueSize);
						Class53.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Class53.LogsType.Queue);
						return;
					}
					break;
				}
			}
			Logger.LogWarning("Not implemented Websocket Notifcation");
			Logger.LogDebug(messageEventArgs.Data);
			return;
		}
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x000031DA File Offset: 0x000013DA
	internal static bool tMj6hJI1EFgSBcTxniY()
	{
		return Class107.m5FeEfTztKh98Jgduql == null;
	}

	// Token: 0x0400026C RID: 620
	private static Class107.Delegate38 delegate38_0;

	// Token: 0x0400026D RID: 621
	internal static Class107 m5FeEfTztKh98Jgduql;

	// Token: 0x02000104 RID: 260
	// (Invoke) Token: 0x0600052C RID: 1324
	private delegate void Delegate38(IntPtr instance, IntPtr __0);

	// Token: 0x02000105 RID: 261
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400026E RID: 622
		public static Class107.Delegate38 delegate38_0;
	}
}
