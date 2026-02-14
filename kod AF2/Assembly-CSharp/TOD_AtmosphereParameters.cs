using System;
using UnityEngine;

// Token: 0x020000D0 RID: 208
[Serializable]
public class TOD_AtmosphereParameters
{
	// Token: 0x04000504 RID: 1284
	[DOBCLPBCHFP(0f)]
	[Tooltip("Intensity of the atmospheric Rayleigh scattering.")]
	public float RayleighMultiplier = 1f;

	// Token: 0x04000505 RID: 1285
	[DOBCLPBCHFP(0f)]
	[Tooltip("Intensity of the atmospheric Mie scattering.")]
	public float MieMultiplier = 1f;

	// Token: 0x04000506 RID: 1286
	[Tooltip("Overall brightness of the atmosphere.")]
	[DOBCLPBCHFP(0f)]
	public float Brightness = 1.5f;

	// Token: 0x04000507 RID: 1287
	[Tooltip("Overall contrast of the atmosphere.")]
	[DOBCLPBCHFP(0f)]
	public float Contrast = 1.5f;

	// Token: 0x04000508 RID: 1288
	[AKOPBLFCONA(0f, 1f)]
	[Tooltip("Directionality factor that determines the size and sharpness of the glow around the light source.")]
	public float Directionality = 0.7f;

	// Token: 0x04000509 RID: 1289
	[AKOPBLFCONA(0f, 1f)]
	[Tooltip("Density of the fog covering the sky.")]
	public float Fogginess;
}
