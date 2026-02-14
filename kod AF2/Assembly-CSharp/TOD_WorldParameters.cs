using System;
using UnityEngine;

// Token: 0x020000CF RID: 207
[Serializable]
public class TOD_WorldParameters
{
	// Token: 0x04000501 RID: 1281
	[Tooltip("Latitude of the current location in degrees.")]
	[Range(-90f, 90f)]
	public float Latitude;

	// Token: 0x04000502 RID: 1282
	[Range(-180f, 180f)]
	[Tooltip("Longitude of the current location in degrees.")]
	public float Longitude;

	// Token: 0x04000503 RID: 1283
	[Range(-14f, 14f)]
	[Tooltip("UTC/GMT time zone of the current location in hours.")]
	public float UTC;
}
