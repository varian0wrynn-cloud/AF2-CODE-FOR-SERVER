using System;
using UnityEngine;

// Token: 0x020000D7 RID: 215
[Serializable]
public class TOD_LightParameters
{
	// Token: 0x04000533 RID: 1331
	[Tooltip("Refresh interval of the light source position in seconds.")]
	[DOBCLPBCHFP(0f)]
	public float UpdateInterval;

	// Token: 0x04000534 RID: 1332
	[Tooltip("Controls how low the light source is allowed to go.")]
	[AKOPBLFCONA(-1f, 1f)]
	public float MinimumHeight;
}
