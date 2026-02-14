using System;
using UnityEngine;

// Token: 0x020000D9 RID: 217
[Serializable]
public class TOD_AmbientParameters
{
	// Token: 0x04000537 RID: 1335
	[Tooltip("Ambient light mode.")]
	public PCFPKFJGNCG Mode = PCFPKFJGNCG.Color;

	// Token: 0x04000538 RID: 1336
	[DOBCLPBCHFP(0f)]
	[Tooltip("Refresh interval of the ambient light probe in seconds.")]
	public float UpdateInterval = 1f;
}
