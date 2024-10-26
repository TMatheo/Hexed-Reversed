using System;
using System.Runtime.CompilerServices;
using Hexed.Wrappers;
using UnityEngine;
using UnityEngine.Animations;

// Token: 0x0200005A RID: 90
internal class Class47
{
	// Token: 0x060002A2 RID: 674 RVA: 0x0000F244 File Offset: 0x0000D444
	public static void SanitizeAvatarObject(GameObject gameObject, VRCPlayer player)
	{
		int num = 0 + Class47.SanitizeAudios(gameObject.GetComponentsInChildren<AudioSource>(true));
		num += Class47.SanitizeONSPAudios(gameObject.GetComponentsInChildren<ONSPAudioSource>(true));
		num += Class47.SanitizeLights(gameObject.GetComponentsInChildren<Light>(true));
		num += Class47.SanitizeParticleSystems(gameObject.GetComponentsInChildren<ParticleSystem>(true));
		num += Class47.SanitizeAnimators(gameObject.GetComponentsInChildren<Animator>(true));
		num += Class47.SanitizeColliders(gameObject.GetComponentsInChildren<Collider>(true));
		num += Class47.SanitizeRenderers(gameObject.GetComponentsInChildren<Renderer>(true));
		num += Class47.SanitizeRigidbodys(gameObject.GetComponentsInChildren<Rigidbody>(true));
		num += Class47.SanitizeCloths(gameObject.GetComponentsInChildren<Cloth>(true));
		int num2 = num;
		Behaviour[] constraints = gameObject.GetComponentsInChildren<AimConstraint>(true);
		num = num2 + Class47.SanitizeConstraints(constraints);
		int num3 = num;
		constraints = gameObject.GetComponentsInChildren<ParentConstraint>(true);
		num = num3 + Class47.SanitizeConstraints(constraints);
		int num4 = num;
		constraints = gameObject.GetComponentsInChildren<RotationConstraint>(true);
		num = num4 + Class47.SanitizeConstraints(constraints);
		int num5 = num;
		constraints = gameObject.GetComponentsInChildren<PositionConstraint>(true);
		num = num5 + Class47.SanitizeConstraints(constraints);
		int num6 = num;
		constraints = gameObject.GetComponentsInChildren<ScaleConstraint>(true);
		num = num6 + Class47.SanitizeConstraints(constraints);
		int num7 = num;
		constraints = gameObject.GetComponentsInChildren<LookAtConstraint>(true);
		num = num7 + Class47.SanitizeConstraints(constraints);
		if (num > 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(48, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Prevented ");
			defaultInterpolatedStringHandler.AppendFormatted(player.DisplayName());
			defaultInterpolatedStringHandler.AppendLiteral(" from overflow with ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral(" Avatar components");
			Logger.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Logger.LogsType.Protection);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
			defaultInterpolatedStringHandler.AppendFormatted(player.DisplayName());
			defaultInterpolatedStringHandler.AppendLiteral(" --> ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral(" Avatar components");
			Class53.Log(defaultInterpolatedStringHandler.ToStringAndClear(), Class53.LogsType.Protection);
		}
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x0000F454 File Offset: 0x0000D654
	private static int SanitizeAudios(AudioSource[] Audios)
	{
		int num = 20;
		int num2 = 0;
		for (int i = 0; i < Audios.Length; i++)
		{
			if (num2 <= num)
			{
				if (Class143.bool_27 && Audios[i].enabled && Audios[i].playOnAwake && !Audios[i].loop)
				{
					Object.DestroyImmediate(Audios[i], true);
				}
				else
				{
					Audios[i].outputAudioMixerGroup = null;
				}
			}
			else
			{
				Object.DestroyImmediate(Audios[i], true);
			}
			num2++;
		}
		if (Audios.Length - num <= 0)
		{
			return 0;
		}
		return Audios.Length - num;
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x0000F4E4 File Offset: 0x0000D6E4
	private static int SanitizeONSPAudios(ONSPAudioSource[] Audios)
	{
		int num = 20;
		int num2 = 0;
		for (int i = 0; i < Audios.Length; i++)
		{
			if (num2 > num)
			{
				Object.DestroyImmediate(Audios[i], true);
			}
			num2++;
		}
		if (Audios.Length - num > 0)
		{
			return Audios.Length - num;
		}
		return 0;
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x0000F534 File Offset: 0x0000D734
	private static int SanitizeLights(Light[] Lights)
	{
		int num = 40;
		int num2 = 0;
		for (int i = 0; i < Lights.Length; i++)
		{
			if (num2 <= num)
			{
				Lights[i].shadowResolution = 0;
				Lights[i].shadowSoftness = 0f;
				Lights[i].shadowSoftnessFade = 0f;
				Lights[i].shadowStrength = 0f;
				Lights[i].shadowNearPlane = 0f;
				Lights[i].shadowBias = 0f;
				Lights[i].shadowNormalBias = 0f;
				Lights[i].shadowObjectSizeBias = 0f;
				Lights[i].shadowConstantBias = 0f;
			}
			else
			{
				Object.DestroyImmediate(Lights[i], true);
			}
			num2++;
		}
		if (Lights.Length - num <= 0)
		{
			return 0;
		}
		return Lights.Length - num;
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x0000F604 File Offset: 0x0000D804
	private static int SanitizeParticleSystems(ParticleSystem[] Particles)
	{
		int num = 150;
		int num2 = 0;
		for (int i = 0; i < Particles.Length; i++)
		{
			if (num2 > num)
			{
				Object.DestroyImmediate(Particles[i], true);
			}
			else
			{
				if (Particles[i].maxParticles > 5000)
				{
					Particles[i].maxParticles = 5000;
				}
				if (Particles[i].collision.maxCollisionShapes > 256)
				{
					Particles[i].collision.maxCollisionShapes = 256;
				}
				if (Particles[i].trails.ribbonCount > 64)
				{
					Particles[i].maxParticles = 64;
				}
			}
			num2++;
		}
		if (Particles.Length - num > 0)
		{
			return Particles.Length - num;
		}
		return 0;
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
	private static int SanitizeAnimators(Animator[] Animators)
	{
		int num = 80;
		int num2 = 0;
		for (int i = 0; i < Animators.Length; i++)
		{
			if (num2 > num)
			{
				Object.DestroyImmediate(Animators[i], true);
			}
			num2++;
		}
		if (Animators.Length - num > 0)
		{
			return Animators.Length - num;
		}
		return 0;
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x0000F710 File Offset: 0x0000D910
	private static int SanitizeColliders(Collider[] Colliders)
	{
		int num = 50;
		int num2 = 0;
		for (int i = 0; i < Colliders.Length; i++)
		{
			if (num2 > num)
			{
				Object.DestroyImmediate(Colliders[i], true);
			}
			num2++;
		}
		if (Colliders.Length - num <= 0)
		{
			return 0;
		}
		return Colliders.Length - num;
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x0000F760 File Offset: 0x0000D960
	private static int SanitizeRenderers(Renderer[] Renderers)
	{
		int num = 400;
		int num2 = 0;
		for (int i = 0; i < Renderers.Length; i++)
		{
			if (num2 <= num)
			{
				Renderers[i].rayTracingMode = 0;
				Renderers[i].receiveShadows = false;
				Renderers[i].castShadows = false;
				Renderers[i].shadowCastingMode = 0;
				Renderers[i].sortingOrder = 0;
				Renderers[i].sortingLayerID = 0;
				Renderers[i].rendererPriority = 0;
				Renderers[i].useLightProbes = false;
				Renderers[i].reflectionProbeUsage = 0;
				SkinnedMeshRenderer skinnedMeshRenderer = Renderers[i].TryCast<SkinnedMeshRenderer>();
				if (skinnedMeshRenderer != null)
				{
					skinnedMeshRenderer.updateWhenOffscreen = false;
					Transform transform = null;
					Transform[] array = skinnedMeshRenderer.bones;
					for (int j = 0; j < array.Length; j++)
					{
						if (!(array[j] != null))
						{
							if (transform == null)
							{
								transform = new GameObject("hexed-zero-scale").transform;
								transform.SetParent(skinnedMeshRenderer.rootBone, false);
								transform.localScale = Vector3.zero;
							}
							array[j] = transform;
						}
					}
					if (transform != null)
					{
						skinnedMeshRenderer.bones = array;
					}
				}
			}
			else
			{
				Object.DestroyImmediate(Renderers[i], true);
			}
			num2++;
		}
		if (Renderers.Length - num <= 0)
		{
			return 0;
		}
		return Renderers.Length - num;
	}

	// Token: 0x060002AA RID: 682 RVA: 0x0000F8BC File Offset: 0x0000DABC
	private static int SanitizeRigidbodys(Rigidbody[] Rigidbodys)
	{
		int num = 30;
		int num2 = 0;
		for (int i = 0; i < Rigidbodys.Length; i++)
		{
			if (num2 > num)
			{
				Object.DestroyImmediate(Rigidbodys[i], true);
			}
			num2++;
		}
		if (Rigidbodys.Length - num <= 0)
		{
			return 0;
		}
		return Rigidbodys.Length - num;
	}

	// Token: 0x060002AB RID: 683 RVA: 0x0000F8BC File Offset: 0x0000DABC
	private static int SanitizeCloths(Cloth[] Cloths)
	{
		int num = 30;
		int num2 = 0;
		for (int i = 0; i < Cloths.Length; i++)
		{
			if (num2 > num)
			{
				Object.DestroyImmediate(Cloths[i], true);
			}
			num2++;
		}
		if (Cloths.Length - num <= 0)
		{
			return 0;
		}
		return Cloths.Length - num;
	}

	// Token: 0x060002AC RID: 684 RVA: 0x0000F90C File Offset: 0x0000DB0C
	private static int SanitizeConstraints(Behaviour[] constraints)
	{
		int num = 250;
		int num2 = 0;
		for (int i = 0; i < constraints.Length; i++)
		{
			if (num2 > num)
			{
				Object.DestroyImmediate(constraints[i], true);
			}
			num2++;
		}
		if (constraints.Length - num > 0)
		{
			return constraints.Length - num;
		}
		return 0;
	}

	// Token: 0x060002AE RID: 686 RVA: 0x00002CFC File Offset: 0x00000EFC
	internal static bool AxkvjGnUxlTJsXbSqKs()
	{
		return Class47.hkhiVTnor7vGdTRlO7t == null;
	}

	// Token: 0x04000130 RID: 304
	internal static Class47 hkhiVTnor7vGdTRlO7t;
}
