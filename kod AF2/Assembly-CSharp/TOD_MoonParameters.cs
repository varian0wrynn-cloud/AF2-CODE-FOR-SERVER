using System;
using UnityEngine;

// Token: 0x020000D4 RID: 212
[Serializable]
public class TOD_MoonParameters
{
	// Token: 0x04000522 RID: 1314
	[Tooltip("Color of the moon mesh.\nInterpolates from left (day) to right (night).")]
	public Gradient MeshColor = new Gradient
	{
		alphaKeys = new GradientAlphaKey[]
		{
			new GradientAlphaKey(1f, 0f),
			new GradientAlphaKey(1f, 1f)
		},
		colorKeys = new GradientColorKey[]
		{
			new GradientColorKey(new Color32(byte.MaxValue, 233, 200, byte.MaxValue), 0f),
			new GradientColorKey(new Color32(byte.MaxValue, 233, 200, byte.MaxValue), 1f)
		}
	};

	// Token: 0x04000523 RID: 1315
	[DOBCLPBCHFP(0f)]
	[Tooltip("Size of the moon mesh in degrees.")]
	public float MeshSize = 1f;

	// Token: 0x04000524 RID: 1316
	[DOBCLPBCHFP(0f)]
	[Tooltip("Brightness of the moon mesh.")]
	public float MeshBrightness = 1f;

	// Token: 0x04000525 RID: 1317
	[DOBCLPBCHFP(0f)]
	[Tooltip("Contrast of the moon mesh.")]
	public float MeshContrast = 1f;

	// Token: 0x04000526 RID: 1318
	[Tooltip("Color of the moon halo.\nInterpolates from left (day) to right (night).")]
	public Gradient HaloColor = new Gradient
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

	// Token: 0x04000527 RID: 1319
	[Tooltip("Size of the moon halo.")]
	[DOBCLPBCHFP(0f)]
	public float HaloSize = 0.1f;

	// Token: 0x04000528 RID: 1320
	[Tooltip("Type of the moon position calculation.")]
	public KEBEBOLGIBL Position = KEBEBOLGIBL.Realistic;
}
