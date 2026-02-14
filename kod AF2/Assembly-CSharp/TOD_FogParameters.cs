using System;
using UnityEngine;

// Token: 0x020000D8 RID: 216
[Serializable]
public class TOD_FogParameters
{
	// Token: 0x04000535 RID: 1333
	[Tooltip("Fog color mode.")]
	public LKELCNKDLEC Mode = LKELCNKDLEC.Color;

	// Token: 0x04000536 RID: 1334
	[AKOPBLFCONA(0f, 1f)]
	[Tooltip("Fog color sampling height.")]
	public float HeightBias;
}
