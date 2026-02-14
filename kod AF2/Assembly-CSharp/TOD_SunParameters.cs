using System;
using UnityEngine;

// Token: 0x020000D3 RID: 211
[Serializable]
public class TOD_SunParameters
{
	// Token: 0x0400051E RID: 1310
	[Tooltip("Color of the sun spot.\nInterpolates from left (day) to right (night).")]
	public Gradient MeshColor = new Gradient
	{
		alphaKeys = new GradientAlphaKey[]
		{
			new GradientAlphaKey(1f, 0f),
			new GradientAlphaKey(1f, 1f)
		},
		colorKeys = new GradientColorKey[]
		{
			new GradientColorKey(new Color32(253, 171, 50, byte.MaxValue), 0f),
			new GradientColorKey(new Color32(253, 171, 50, byte.MaxValue), 1f)
		}
	};

	// Token: 0x0400051F RID: 1311
	[Tooltip("Size of the sun spot in degrees.")]
	[DOBCLPBCHFP(0f)]
	public float MeshSize = 1f;

	// Token: 0x04000520 RID: 1312
	[DOBCLPBCHFP(0f)]
	[Tooltip("Brightness of the sun spot.")]
	public float MeshBrightness = 1f;

	// Token: 0x04000521 RID: 1313
	[Tooltip("Contrast of the sun spot.")]
	[DOBCLPBCHFP(0f)]
	public float MeshContrast = 1f;
}
