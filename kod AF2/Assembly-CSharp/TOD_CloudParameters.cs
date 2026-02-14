using System;
using UnityEngine;

// Token: 0x020000D6 RID: 214
[Serializable]
public class TOD_CloudParameters
{
	// Token: 0x0400052C RID: 1324
	[AKOPBLFCONA(0f, 1f)]
	[Tooltip("Density of the clouds.")]
	public float Density = 1f;

	// Token: 0x0400052D RID: 1325
	[DOBCLPBCHFP(0f)]
	[Tooltip("Sharpness of the clouds.")]
	public float Sharpness = 3f;

	// Token: 0x0400052E RID: 1326
	[Tooltip("Brightness of the clouds.")]
	[DOBCLPBCHFP(0f)]
	public float Brightness = 1f;

	// Token: 0x0400052F RID: 1327
	[Tooltip("Number of billboard clouds to instantiate at start.\nBillboard clouds are not visible in edit mode.")]
	[DOBCLPBCHFP(0f)]
	public int Billboards;

	// Token: 0x04000530 RID: 1328
	[Tooltip("Opacity of the cloud shadows.")]
	[AKOPBLFCONA(0f, 1f)]
	public float ShadowStrength;

	// Token: 0x04000531 RID: 1329
	[Tooltip("Scale of the first cloud layer.")]
	public Vector2 Scale1 = new Vector2(3f, 3f);

	// Token: 0x04000532 RID: 1330
	[Tooltip("Scale of the second cloud layer.")]
	public Vector2 Scale2 = new Vector2(7f, 7f);
}
