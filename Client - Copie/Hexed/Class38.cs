using System;
using Hexed.UIApi;
using UnityEngine;
using VRC;

// Token: 0x0200004C RID: 76
internal class Class38 : Interface2
{
	// Token: 0x0600023C RID: 572 RVA: 0x00002328 File Offset: 0x00000528
	public void Initialize()
	{
	}

	// Token: 0x0600023D RID: 573 RVA: 0x0000C1E4 File Offset: 0x0000A3E4
	public void OnUpdate()
	{
		if (Class4.IsInWorld())
		{
			Player currentPlayer = Class3.CurrentPlayer;
			if (((currentPlayer == null) ? null : currentPlayer.GetVRCPlayerApi()) != null)
			{
				if (Class38.bool_0)
				{
					Class3.CurrentPlayer.GetVRCPlayerApi().SetVelocity(Vector3.zero);
					float num = Class38.float_1;
					if (!Class4.IsInVr())
					{
						if (Input.GetKeyInt(304))
						{
							num *= 2f;
						}
						if (!Input.GetKeyInt(101))
						{
							if (Input.GetKeyInt(113))
							{
								Class3.CurrentPlayer.transform.position += Class38.transform_0.transform.up * -1f * num * Time.deltaTime;
							}
						}
						else
						{
							Class3.CurrentPlayer.transform.position += Class38.transform_0.transform.up * num * Time.deltaTime;
						}
						if (Input.GetKeyInt(119))
						{
							Class3.CurrentPlayer.transform.position += Class38.transform_0.transform.forward * num * Time.deltaTime;
						}
						else if (Input.GetKeyInt(115))
						{
							Class3.CurrentPlayer.transform.position += Class38.transform_0.transform.forward * -1f * num * Time.deltaTime;
						}
						if (!Input.GetKeyInt(97))
						{
							if (Input.GetKeyInt(100))
							{
								Class3.CurrentPlayer.transform.position += Class38.transform_0.transform.right * num * Time.deltaTime;
							}
						}
						else
						{
							Class3.CurrentPlayer.transform.position += Class38.transform_0.transform.right * -1f * num * Time.deltaTime;
						}
					}
					else
					{
						Class3.CurrentPlayer.transform.position += Class38.transform_0.transform.forward * num * Time.deltaTime * Class115.smethod_0("Vertical").GetAxis();
						Class3.CurrentPlayer.transform.position += Class38.transform_0.transform.right * num * Time.deltaTime * Class115.smethod_0("Horizontal").GetAxis();
						Class3.CurrentPlayer.transform.position += Class38.transform_0.transform.up * num * Time.deltaTime * Class115.smethod_0("LookVertical").GetAxis();
					}
				}
				else if (Class143.bool_22)
				{
					if (Class115.smethod_0("Jump").GetHeldTime() > 0f)
					{
						Vector3 velocity = Class3.CurrentPlayer.GetVRCPlayerApi().GetVelocity();
						velocity.y = Class3.CurrentPlayer.GetVRCPlayerApi().GetJumpImpulse();
						Class3.CurrentPlayer.GetVRCPlayerApi().SetVelocity(velocity);
					}
				}
				else
				{
					if (Class143.bool_23 && Class115.smethod_0("Jump").IsPressed() && !Class3.CurrentPlayer.GetVRCPlayerApi().IsPlayerGrounded())
					{
						Vector3 velocity2 = Class3.CurrentPlayer.GetVRCPlayerApi().GetVelocity();
						velocity2.y = Class3.CurrentPlayer.GetVRCPlayerApi().GetJumpImpulse();
						velocity2.y += 1f;
						Class3.CurrentPlayer.GetVRCPlayerApi().SetVelocity(velocity2);
						velocity2.y -= 1f;
					}
					if (Class143.bool_21 && Class115.smethod_0("Jump").GetHeldTime() > 0f && Class3.CurrentPlayer.GetVRCPlayerApi().IsPlayerGrounded())
					{
						Vector3 velocity3 = Class3.CurrentPlayer.GetVRCPlayerApi().GetVelocity();
						velocity3.y = Class3.CurrentPlayer.GetVRCPlayerApi().GetJumpImpulse();
						Class3.CurrentPlayer.GetVRCPlayerApi().SetVelocity(velocity3);
					}
					if (Class143.bool_24)
					{
						try
						{
							Class3.CurrentPlayer.GetVRCPlayerApi().SetJumpImpulse(Class38.float_2);
						}
						catch
						{
						}
					}
				}
				if (Class143.bool_25)
				{
					try
					{
						Class3.CurrentPlayer.GetVRCPlayerApi().SetRunSpeed(Class38.float_3);
					}
					catch
					{
					}
				}
				if (Class38.bool_2)
				{
					if (!Input.GetKey(273))
					{
						if (!Input.GetKey(274))
						{
							if (!Input.GetKey(275))
							{
								if (!Input.GetKey(276))
								{
									if (Input.GetKey(120))
									{
										Class38.DisableRotate();
										Class38.EnableRotate();
									}
								}
								else
								{
									Class3.CurrentPlayer.transform.Rotate(Vector3.forward, Class38.float_4 * Time.deltaTime);
								}
							}
							else
							{
								Class3.CurrentPlayer.transform.Rotate(Vector3.back, Class38.float_4 * Time.deltaTime);
							}
						}
						else
						{
							Class3.CurrentPlayer.transform.Rotate(Vector3.left, Class38.float_4 * Time.deltaTime);
						}
					}
					else
					{
						Class3.CurrentPlayer.transform.Rotate(Vector3.right, Class38.float_4 * Time.deltaTime);
					}
					Class38.AlignTrackingToPlayer();
					return;
				}
				return;
			}
		}
		if (Class38.bool_0)
		{
			Class38.DisableFly();
		}
		if (Class38.bool_2)
		{
			Class38.DisableRotate();
			return;
		}
	}

	// Token: 0x0600023E RID: 574 RVA: 0x0000C7A8 File Offset: 0x0000A9A8
	public static void ToggleFly()
	{
		if (!Class38.bool_0)
		{
			Class38.EnableFly();
			return;
		}
		Class38.DisableFly();
	}

	// Token: 0x0600023F RID: 575 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
	public static void ToggleNoClip()
	{
		if (!Class38.bool_1)
		{
			Class38.EnableNoClip();
			return;
		}
		Class38.DisableFly();
	}

	// Token: 0x06000240 RID: 576 RVA: 0x0000C7E8 File Offset: 0x0000A9E8
	private static void EnableFly()
	{
		if (Class38.transform_0 == null)
		{
			Class38.transform_0 = Camera.main.transform;
		}
		Class38.vector3_0 = Physics.gravity;
		Physics.gravity = Vector3.zero;
		QMToggleButton qmtoggleButton_ = Class128.qmtoggleButton_0;
		if (qmtoggleButton_ != null)
		{
			qmtoggleButton_.SetToggleState(true);
		}
		Class38.bool_0 = true;
	}

	// Token: 0x06000241 RID: 577 RVA: 0x0000C83C File Offset: 0x0000AA3C
	private static void DisableFly()
	{
		Class38.bool_0 = false;
		Class38.bool_1 = false;
		QMToggleButton qmtoggleButton_ = Class128.qmtoggleButton_0;
		if (qmtoggleButton_ != null)
		{
			qmtoggleButton_.SetToggleState(false);
		}
		QMToggleButton qmtoggleButton_2 = Class128.qmtoggleButton_1;
		if (qmtoggleButton_2 != null)
		{
			qmtoggleButton_2.SetToggleState(false);
		}
		Physics.gravity = Class38.vector3_0;
		if (Class3.CurrentPlayer != null)
		{
			Class3.CurrentPlayer.GetComponent<CharacterController>().enabled = true;
		}
	}

	// Token: 0x06000242 RID: 578 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
	private static void EnableNoClip()
	{
		if (!Class38.bool_0)
		{
			Class38.EnableFly();
		}
		Class3.CurrentPlayer.GetComponent<CharacterController>().enabled = false;
		QMToggleButton qmtoggleButton_ = Class128.qmtoggleButton_1;
		if (qmtoggleButton_ != null)
		{
			qmtoggleButton_.SetToggleState(true);
		}
		Class38.bool_1 = true;
	}

	// Token: 0x06000243 RID: 579 RVA: 0x0000C8E0 File Offset: 0x0000AAE0
	public static void ToggleHighJump()
	{
		if (!Class143.bool_24)
		{
			Class38.EnableHighJump();
			return;
		}
		Class38.DisableHighJump();
	}

	// Token: 0x06000244 RID: 580 RVA: 0x0000C900 File Offset: 0x0000AB00
	private static void EnableHighJump()
	{
		Class38.float_0 = Class3.CurrentPlayer.GetVRCPlayerApi().GetJumpImpulse();
		Class143.bool_24 = true;
	}

	// Token: 0x06000245 RID: 581 RVA: 0x0000C928 File Offset: 0x0000AB28
	private static void DisableHighJump()
	{
		Class143.bool_24 = false;
		Class3.CurrentPlayer.GetVRCPlayerApi().SetJumpImpulse(Class38.float_0);
	}

	// Token: 0x06000246 RID: 582 RVA: 0x0000C950 File Offset: 0x0000AB50
	public static void ToggleSpeed()
	{
		if (!Class143.bool_25)
		{
			Class38.EnableSpeed();
			return;
		}
		Class38.DisableSpeed();
	}

	// Token: 0x06000247 RID: 583 RVA: 0x00002C2D File Offset: 0x00000E2D
	private static void EnableSpeed()
	{
		Class143.bool_25 = true;
	}

	// Token: 0x06000248 RID: 584 RVA: 0x0000C970 File Offset: 0x0000AB70
	private static void DisableSpeed()
	{
		Class143.bool_25 = false;
		Class3.CurrentPlayer.GetVRCPlayerApi().SetRunSpeed(4f);
	}

	// Token: 0x06000249 RID: 585 RVA: 0x0000C998 File Offset: 0x0000AB98
	public static void ToggleRotate()
	{
		if (!Class38.bool_2)
		{
			Class38.EnableRotate();
			return;
		}
		Class38.DisableRotate();
	}

	// Token: 0x0600024A RID: 586 RVA: 0x0000C9B8 File Offset: 0x0000ABB8
	private static void EnableRotate()
	{
		Class38.bool_2 = true;
		QMToggleButton qmtoggleButton_ = Class128.qmtoggleButton_2;
		if (qmtoggleButton_ == null)
		{
			return;
		}
		qmtoggleButton_.SetToggleState(true);
	}

	// Token: 0x0600024B RID: 587 RVA: 0x0000C9DC File Offset: 0x0000ABDC
	private static void DisableRotate()
	{
		Class38.bool_2 = false;
		Quaternion localRotation = Class3.CurrentPlayer.transform.localRotation;
		Class3.CurrentVRCPlayer.transform.localRotation = new Quaternion(0f, localRotation.y, 0f, localRotation.w);
		Class38.AlignTrackingToPlayer();
		QMToggleButton qmtoggleButton_ = Class128.qmtoggleButton_2;
		if (qmtoggleButton_ == null)
		{
			return;
		}
		qmtoggleButton_.SetToggleState(false);
	}

	// Token: 0x0600024C RID: 588 RVA: 0x0000CA44 File Offset: 0x0000AC44
	private static void AlignTrackingToPlayer()
	{
		Class3.CurrentVRCPlayer.Method_Public_Void_1();
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00002C35 File Offset: 0x00000E35
	internal static bool n2lhpXNqElGVofamIHD()
	{
		return Class38.pjeLsRNYe0fjrR7GyPp == null;
	}

	// Token: 0x040000FD RID: 253
	private static Vector3 vector3_0;

	// Token: 0x040000FE RID: 254
	private static float float_0;

	// Token: 0x040000FF RID: 255
	private static Transform transform_0;

	// Token: 0x04000100 RID: 256
	private static float float_1 = 4.4f;

	// Token: 0x04000101 RID: 257
	private static float float_2 = 10f;

	// Token: 0x04000102 RID: 258
	private static float float_3 = 10f;

	// Token: 0x04000103 RID: 259
	private static float float_4 = 180f;

	// Token: 0x04000104 RID: 260
	private static bool bool_0 = false;

	// Token: 0x04000105 RID: 261
	private static bool bool_1 = false;

	// Token: 0x04000106 RID: 262
	public static bool bool_2 = false;

	// Token: 0x04000107 RID: 263
	private static Class38 pjeLsRNYe0fjrR7GyPp;
}
