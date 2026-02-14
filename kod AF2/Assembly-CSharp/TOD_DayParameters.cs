using System;
using UnityEngine;

// Token: 0x020000D1 RID: 209
[Serializable]
public class TOD_DayParameters
{
	// Token: 0x0400050A RID: 1290
	[Tooltip("Color of the light that hits the atmosphere.\nInterpolates from left (day) to right (night).")]
	public Gradient SkyColor = new Gradient
	{
		alphaKeys = new GradientAlphaKey[]
		{
			new GradientAlphaKey(1f, 0f),
			new GradientAlphaKey(1f, 1f)
		},
		colorKeys = new GradientColorKey[]
		{
			new GradientColorKey(new Color32(byte.MaxValue, 243, 234, byte.MaxValue), 0f),
			new GradientColorKey(new Color32(byte.MaxValue, 243, 234, byte.MaxValue), 1f)
		}
	};

	// Token: 0x0400050B RID: 1291
	[Tooltip("Color of the light that hits the ground.\nInterpolates from left (day) to right (night).")]
	public Gradient LightColor = new Gradient
	{
		alphaKeys = new GradientAlphaKey[]
		{
			new GradientAlphaKey(1f, 0f),
			new GradientAlphaKey(1f, 1f)
		},
		colorKeys = new GradientColorKey[]
		{
			new GradientColorKey(new Color32(byte.MaxValue, 243, 234, byte.MaxValue), 0f),
			new GradientColorKey(new Color32(byte.MaxValue, 107, 0, byte.MaxValue), 1f)
		}
	};

	// Token: 0x0400050C RID: 1292
	[Tooltip("Color of the god rays.\nInterpolates from left (day) to right (night).")]
	public Gradient RayColor = new Gradient
	{
		alphaKeys = new GradientAlphaKey[]
		{
			new GradientAlphaKey(1f, 0f),
			new GradientAlphaKey(1f, 1f)
		},
		colorKeys = new GradientColorKey[]
		{
			new GradientColorKey(new Color32(byte.MaxValue, 243, 234, byte.MaxValue), 0f),
			new GradientColorKey(new Color32(byte.MaxValue, 107, 0, byte.MaxValue), 1f)
		}
	};

	// Token: 0x0400050D RID: 1293
	[Tooltip("Color of the clouds.\nInterpolates from left (day) to right (night).")]
	public Gradient CloudColor = new Gradient
	{
		alphaKeys = new GradientAlphaKey[]
		{
			new GradientAlphaKey(1f, 0f),
			new GradientAlphaKey(1f, 1f)
		},
		colorKeys = new GradientColorKey[]
		{
			new GradientColorKey(new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), 0f),
			new GradientColorKey(new Color32(byte.MaxValue, 200, 100, byte.MaxValue), 1f)
		}
	};

	// Token: 0x0400050E RID: 1294
	[Tooltip("Color of the ambient light.\nInterpolates from left (day) to right (night).")]
	public Gradient AmbientColor = new Gradient
	{
		alphaKeys = new GradientAlphaKey[]
		{
			new GradientAlphaKey(1f, 0f),
			new GradientAlphaKey(1f, 1f)
		},
		colorKeys = new GradientColorKey[]
		{
			new GradientColorKey(new Color32(94, 89, 87, byte.MaxValue), 0f),
			new GradientColorKey(new Color32(94, 89, 87, byte.MaxValue), 1f)
		}
	};

	// Token: 0x0400050F RID: 1295
	[DOBCLPBCHFP(0f)]
	[Tooltip("Intensity of the light source.")]
	public float LightIntensity = 1f;

	// Token: 0x04000510 RID: 1296
	[AKOPBLFCONA(0f, 1f)]
	[Tooltip("Opacity of the shadows dropped by the light source.")]
	public float ShadowStrength = 1f;

	// Token: 0x04000511 RID: 1297
	[Tooltip("Brightness of colors.")]
	[Range(0f, 1f)]
	public float ColorMultiplier = 1f;

	// Token: 0x04000512 RID: 1298
	[Range(0f, 1f)]
	[Tooltip("Brightness of ambient light.")]
	public float AmbientMultiplier = 1f;

	// Token: 0x04000513 RID: 1299
	[Range(0f, 1f)]
	[Tooltip("Brightness of reflected light.")]
	public float ReflectionMultiplier = 1f;
}
