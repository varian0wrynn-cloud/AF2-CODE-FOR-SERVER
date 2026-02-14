using System;
using UnityEngine;

// Token: 0x020000D5 RID: 213
[Serializable]
public class TOD_StarParameters
{
	// Token: 0x04000529 RID: 1321
	[DOBCLPBCHFP(0f)]
	[Tooltip("Texture tiling of the stars texture.")]
	public float Tiling = 6f;

	// Token: 0x0400052A RID: 1322
	[DOBCLPBCHFP(0f)]
	[Tooltip("Brightness of the stars.")]
	public float Brightness = 3f;

	// Token: 0x0400052B RID: 1323
	[Tooltip("Type of the stars position calculation.")]
	public CEBGPGGCLPH Position = CEBGPGGCLPH.Rotating;
}
