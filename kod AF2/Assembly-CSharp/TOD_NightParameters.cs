using System;
using UnityEngine;

// Token: 0x020000D2 RID: 210
[Serializable]
public class TOD_NightParameters
{
	// Token: 0x04000514 RID: 1300
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
			new GradientColorKey(new Color32(25, 40, 65, byte.MaxValue), 0f),
			new GradientColorKey(new Color32(25, 40, 65, byte.MaxValue), 1f)
		}
	};

	// Token: 0x04000515 RID: 1301
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
			new GradientColorKey(new Color32(25, 40, 65, byte.MaxValue), 0f),
			new GradientColorKey(new Color32(25, 40, 65, byte.MaxValue), 1f)
		}
	};

	// Token: 0x04000516 RID: 1302
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
			new GradientColorKey(new Color32(25, 40, 65, byte.MaxValue), 0f),
			new GradientColorKey(new Color32(25, 40, 65, byte.MaxValue), 1f)
		}
	};

	// Token: 0x04000517 RID: 1303
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
			new GradientColorKey(new Color32(25, 40, 65, byte.MaxValue), 0f),
			new GradientColorKey(new Color32(25, 40, 65, byte.MaxValue), 1f)
		}
	};

	// Token: 0x04000518 RID: 1304
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
			new GradientColorKey(new Color32(25, 40, 65, byte.MaxValue), 0f),
			new GradientColorKey(new Color32(25, 40, 65, byte.MaxValue), 1f)
		}
	};

	// Token: 0x04000519 RID: 1305
	[Tooltip("Intensity of the light source.")]
	[DOBCLPBCHFP(0f)]
	public float LightIntensity = 0.1f;

	// Token: 0x0400051A RID: 1306
	[Tooltip("Opacity of the shadows dropped by the light source.")]
	[AKOPBLFCONA(0f, 1f)]
	public float ShadowStrength = 1f;

	// Token: 0x0400051B RID: 1307
	[Range(0f, 1f)]
	[Tooltip("Brightness of colors.")]
	public float ColorMultiplier = 1f;

	// Token: 0x0400051C RID: 1308
	[Range(0f, 1f)]
	[Tooltip("Brightness of ambient light.")]
	public float AmbientMultiplier = 1f;

	// Token: 0x0400051D RID: 1309
	[Range(0f, 1f)]
	[Tooltip("Brightness of reflected light.")]
	public float ReflectionMultiplier = 1f;
}
