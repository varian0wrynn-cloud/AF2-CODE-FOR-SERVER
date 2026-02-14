using System;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000DA RID: 218
[Serializable]
public class TOD_ReflectionParameters
{
	// Token: 0x04000539 RID: 1337
	[Tooltip("Reflection probe mode.")]
	public GLOGLJFNIAL Mode;

	// Token: 0x0400053A RID: 1338
	[Tooltip("Clear flags to use for the reflection.")]
	public ReflectionProbeClearFlags ClearFlags = ReflectionProbeClearFlags.Skybox;

	// Token: 0x0400053B RID: 1339
	[Tooltip("Layers to include in the reflection.")]
	public LayerMask CullingMask = 0;

	// Token: 0x0400053C RID: 1340
	[Tooltip("Time slicing behaviour to spread out rendering cost over multiple frames.")]
	public ReflectionProbeTimeSlicingMode TimeSlicing;

	// Token: 0x0400053D RID: 1341
	[Tooltip("Refresh interval of the reflection cubemap in seconds.")]
	[DOBCLPBCHFP(0f)]
	public float UpdateInterval = 1f;
}
