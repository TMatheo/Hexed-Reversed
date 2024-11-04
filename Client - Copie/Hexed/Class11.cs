using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Hexed.Wrappers;
using UnityEngine;

// Token: 0x02000016 RID: 22
internal static class Class11
{
	// Token: 0x060000E5 RID: 229 RVA: 0x00008784 File Offset: 0x00006984
	public static bool IsBadPosition(Vector3 v3)
	{
		return float.IsNaN(v3.x) || float.IsNaN(v3.y) || float.IsNaN(v3.z) || float.IsInfinity(v3.x) || float.IsInfinity(v3.y) || float.IsInfinity(v3.z);
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x000087E0 File Offset: 0x000069E0
	public static bool IsBadRotation(Quaternion v3)
	{
		return float.IsNaN(v3.x) || float.IsNaN(v3.y) || float.IsNaN(v3.z) || float.IsInfinity(v3.x) || float.IsInfinity(v3.y) || float.IsInfinity(v3.z);
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x000026B1 File Offset: 0x000008B1
	public static bool IsBadDistance(Vector3 current, Vector3 target)
	{
		return Vector3.Distance(current, target) > 500000f;
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x000026C1 File Offset: 0x000008C1
	public static string ColorToHex(Color c)
	{
		return string.Format("#{0:X2}{1:X2}{2:X2}", Class11.ToByte(c.r), Class11.ToByte(c.g), Class11.ToByte(c.b));
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x0000883C File Offset: 0x00006A3C
	private static byte ToByte(float f)
	{
		f = Mathf.Clamp01(f);
		return (byte)(f * 255f);
	}

	// Token: 0x060000EA RID: 234 RVA: 0x0000885C File Offset: 0x00006A5C
	public static void DestroyChildren(this Transform transform)
	{
		transform.DestroyChildren(null);
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00008870 File Offset: 0x00006A70
	public static void DestroyChildren(this Transform transform, Func<Transform, bool> exclude)
	{
		for (int i = transform.childCount - 1; i >= 0; i--)
		{
			if (exclude == null || exclude(transform.GetChild(i)))
			{
				Object.DestroyImmediate(transform.GetChild(i).gameObject);
			}
		}
	}

	// Token: 0x060000EC RID: 236 RVA: 0x000088B4 File Offset: 0x00006AB4
	public static Sprite GetSprite(string resourceName)
	{
		if (Class11.dictionary_0.ContainsKey(resourceName))
		{
			return Class11.dictionary_0[resourceName];
		}
		Texture2D texture = Class11.GetTexture(resourceName);
		Rect rect;
		rect..ctor(0f, 0f, (float)texture.width, (float)texture.height);
		Vector2 vector;
		vector..ctor(0.5f, 0.5f);
		Vector4 zero = Vector4.zero;
		Sprite sprite = Sprite.CreateSprite(texture, rect, vector, 100f, 0U, 0, zero, false, null);
		sprite.hideFlags |= 32;
		Class11.dictionary_0.Add(resourceName, sprite);
		return sprite;
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00008954 File Offset: 0x00006B54
	public static Sprite GetSprite(string resourceName, Sprite existing)
	{
		if (existing == null)
		{
			return null;
		}
		if (!Class11.dictionary_1.ContainsKey(existing))
		{
			Sprite sprite = Sprite.CreateSprite(Class11.GetTexture(resourceName), existing.rect, existing.pivot, existing.pixelsPerUnit, 0U, 0, existing.border, false, null);
			sprite.hideFlags |= 32;
			Class11.dictionary_1.Add(existing, sprite);
			return sprite;
		}
		return Class11.dictionary_1[existing];
	}

	// Token: 0x060000EE RID: 238 RVA: 0x000089D0 File Offset: 0x00006BD0
	private static Texture2D GetTexture(string resourceName)
	{
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Hexed.Resources." + resourceName + ".png");
		if (manifestResourceStream == null)
		{
			Logger.LogError("Failed to find texture " + resourceName);
			return null;
		}
		Texture2D result;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			manifestResourceStream.CopyTo(memoryStream);
			Texture2D texture2D = new Texture2D(1, 1);
			texture2D.hideFlags |= 32;
			ImageConversion.LoadImage(texture2D, memoryStream.ToArray());
			texture2D.wrapMode = 1;
			result = texture2D;
		}
		return result;
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00008A74 File Offset: 0x00006C74
	public static Texture2D smethod_0(this Texture texture)
	{
		if (!Class11.dictionary_3.Any((KeyValuePair<Texture, Texture2D> a) => a.Key != null && a.Key == texture))
		{
			FilterMode filterMode = texture.filterMode;
			texture.filterMode = 0;
			RenderTexture temporary = RenderTexture.GetTemporary(texture.width, texture.height, 0, 0);
			temporary.hideFlags |= 32;
			Graphics.Blit2(texture, temporary);
			RenderTexture.active = temporary;
			Texture2D texture2D = new Texture2D(texture.width, texture.height);
			texture2D.hideFlags |= 32;
			texture2D.name = texture.name;
			texture2D.ReadPixels(new Rect(0f, 0f, (float)temporary.width, (float)temporary.height), 0, 0);
			texture2D.Apply();
			texture2D.wrapMode = texture.wrapMode;
			texture2D.wrapModeU = texture.wrapModeU;
			texture2D.wrapModeV = texture.wrapModeV;
			texture2D.wrapModeW = texture.wrapModeW;
			RenderTexture.active = null;
			RenderTexture.ReleaseTemporary(temporary);
			texture.filterMode = filterMode;
			texture.hideFlags |= 32;
			Class11.dictionary_3.Add(texture, texture2D);
			return texture2D;
		}
		return Class11.dictionary_3.FirstOrDefault((KeyValuePair<Texture, Texture2D> a) => a.Key != null && a.Key == texture).Value;
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00008C30 File Offset: 0x00006E30
	public static Texture2D CloneReadable(this Texture2D texture)
	{
		if (Class11.dictionary_2.Any((KeyValuePair<Texture2D, Texture2D> a) => a.Key != null && a.Key == texture))
		{
			return Class11.dictionary_2.FirstOrDefault((KeyValuePair<Texture2D, Texture2D> a) => a.Key != null && a.Key == texture).Value;
		}
		FilterMode filterMode = texture.filterMode;
		texture.filterMode = 0;
		RenderTexture temporary = RenderTexture.GetTemporary(texture.width, texture.height, 0, 0);
		temporary.hideFlags |= 32;
		Graphics.Blit2(texture, temporary);
		RenderTexture.active = temporary;
		Texture2D texture2D = new Texture2D(texture.width, texture.height);
		texture2D.hideFlags |= 32;
		texture2D.name = texture.name;
		texture2D.ReadPixels(new Rect(0f, 0f, (float)temporary.width, (float)temporary.height), 0, 0);
		texture2D.Apply();
		texture2D.wrapMode = texture.wrapMode;
		texture2D.wrapModeU = texture.wrapModeU;
		texture2D.wrapModeV = texture.wrapModeV;
		texture2D.wrapModeW = texture.wrapModeW;
		RenderTexture.active = null;
		RenderTexture.ReleaseTemporary(temporary);
		texture.filterMode = filterMode;
		Class11.dictionary_2.Add(texture, texture2D);
		return texture2D;
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00008DD4 File Offset: 0x00006FD4
	public static Texture2D Desaturate(this Texture2D oldText)
	{
		if (!Class11.dictionary_4.Any((KeyValuePair<Texture2D, Texture2D> a) => a.Key != null && a.Key == oldText))
		{
			Texture2D texture2D = (!oldText.isReadable) ? oldText.CloneReadable() : oldText;
			texture2D.hideFlags |= 32;
			Texture2D texture2D2 = new Texture2D(oldText.width, oldText.height);
			texture2D2.hideFlags |= 32;
			Color[] array = texture2D.GetPixels();
			Color[] array2 = new Color[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				float num = (array[i].r + array[i].g + array[i].b) / 3f;
				array2[i].r = num;
				array2[i].g = num;
				array2[i].b = num;
				array2[i].a = array[i].a;
			}
			texture2D2.SetPixels(array2);
			texture2D2.Apply();
			Class11.dictionary_4.Add(oldText, texture2D2);
			return texture2D2;
		}
		return Class11.dictionary_4.FirstOrDefault((KeyValuePair<Texture2D, Texture2D> a) => a.Key != null && a.Key == oldText).Value;
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x00008F68 File Offset: 0x00007168
	public static Texture2D UnpackTexture(this Sprite sprite)
	{
		if (!Class11.dictionary_5.Any((KeyValuePair<Sprite, Texture2D> a) => a.Key != null && a.Key == sprite))
		{
			Rect rect2;
			if (sprite.packed && sprite.packingMode == null)
			{
				float num = 1f;
				float num2 = 0f;
				float num3 = 0f;
				float num4 = 1f;
				foreach (Vector2 vector in sprite.uv)
				{
					if (vector.x > num3)
					{
						num3 = vector.x;
					}
					if (vector.x < num)
					{
						num = vector.x;
					}
					if (vector.y > num2)
					{
						num2 = vector.y;
					}
					if (vector.y < num4)
					{
						num4 = vector.y;
					}
				}
				Rect rect = default(Rect);
				rect.m_XMin = num * (float)sprite.texture.width;
				rect.m_YMin = num4 * (float)sprite.texture.height;
				rect.m_Width = (num3 - num) * (float)sprite.texture.width;
				rect.m_Height = (num2 - num4) * (float)sprite.texture.height;
				rect2 = rect;
			}
			else
			{
				rect2 = sprite.textureRect;
			}
			Color[] array = ((!sprite.texture.isReadable) ? sprite.texture.CloneReadable() : sprite.texture).GetPixels((int)rect2.x, (int)rect2.y, (int)rect2.width, (int)rect2.height);
			Texture2D texture2D = new Texture2D((int)rect2.width, (int)rect2.height);
			texture2D.hideFlags |= 32;
			texture2D.SetPixels(array);
			texture2D.Apply();
			Class11.dictionary_5.Add(sprite, texture2D);
			return texture2D;
		}
		return Class11.dictionary_5.FirstOrDefault((KeyValuePair<Sprite, Texture2D> a) => a.Key != null && a.Key == sprite).Value;
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x000091D8 File Offset: 0x000073D8
	public static Sprite ReplaceTexture(this Sprite sprite, Texture2D newTexture)
	{
		if (sprite == null)
		{
			return sprite;
		}
		Rect rect;
		rect..ctor(0f, 0f, (float)newTexture.width, (float)newTexture.height);
		Vector2 vector = sprite.pivot / sprite.rect.size;
		Vector4 border = sprite.border;
		Sprite sprite2 = Sprite.CreateSprite(newTexture, rect, vector, sprite.pixelsPerUnit, 0U, 0, border, false, null);
		sprite2.hideFlags |= 32;
		return sprite2;
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x000026FD File Offset: 0x000008FD
	internal static bool i23p8eSQN2PleLCQxM8()
	{
		return Class11.Idwf4yStkslDPJqvhMx == null;
	}

	// Token: 0x0400003E RID: 62
	private static readonly Dictionary<string, Sprite> dictionary_0 = new Dictionary<string, Sprite>();

	// Token: 0x0400003F RID: 63
	private static readonly Dictionary<Sprite, Sprite> dictionary_1 = new Dictionary<Sprite, Sprite>();

	// Token: 0x04000040 RID: 64
	private static readonly Dictionary<Texture2D, Texture2D> dictionary_2 = new Dictionary<Texture2D, Texture2D>();

	// Token: 0x04000041 RID: 65
	private static readonly Dictionary<Texture, Texture2D> dictionary_3 = new Dictionary<Texture, Texture2D>();

	// Token: 0x04000042 RID: 66
	private static readonly Dictionary<Texture2D, Texture2D> dictionary_4 = new Dictionary<Texture2D, Texture2D>();

	// Token: 0x04000043 RID: 67
	private static readonly Dictionary<Sprite, Texture2D> dictionary_5 = new Dictionary<Sprite, Texture2D>();

	// Token: 0x04000044 RID: 68
	private static Class11 Idwf4yStkslDPJqvhMx;

	// Token: 0x02000017 RID: 23
	public readonly struct Struct0
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00002707 File Offset: 0x00000907
		public static Vector3 Vector3_0
		{
			get
			{
				return new Vector3(Class11.Struct0.float_0, Class11.Struct0.float_0, Class11.Struct0.float_0);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000271D File Offset: 0x0000091D
		public static Vector3 NegINFBypass
		{
			get
			{
				return new Vector3(-Class11.Struct0.float_0, -Class11.Struct0.float_0, -Class11.Struct0.float_0);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00002736 File Offset: 0x00000936
		public static Quaternion Quaternion_0
		{
			get
			{
				return new Quaternion(Class11.Struct0.float_0, Class11.Struct0.float_0, Class11.Struct0.float_0, Class11.Struct0.float_0);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00002751 File Offset: 0x00000951
		public static Quaternion NegROTBypass
		{
			get
			{
				return new Quaternion(-Class11.Struct0.float_0, -Class11.Struct0.float_0, -Class11.Struct0.float_0, -Class11.Struct0.float_0);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002770 File Offset: 0x00000970
		internal static bool YKByDQmdJuolyRy36FE()
		{
			return Class11.Struct0.nXPATVmVf2AsUwBO4mQ == null;
		}

		// Token: 0x04000045 RID: 69
		public static readonly float float_0 = 8.589935E+09f;

		// Token: 0x04000046 RID: 70
		private static object nXPATVmVf2AsUwBO4mQ;
	}
}
