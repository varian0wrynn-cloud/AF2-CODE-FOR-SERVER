using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000009 RID: 9
[Serializable]
public class AQUAS_Parameters
{
	// Token: 0x0200000A RID: 10
	[Serializable]
	public class UnderWaterParameters
	{
		// Token: 0x04000056 RID: 86
		[Header("The following parameters apply for underwater only!")]
		[Space(5f)]
		public float fogDensity = 0.1f;

		// Token: 0x04000057 RID: 87
		public Color fogColor;

		// Token: 0x04000058 RID: 88
		public float bloom = 7f;
	}

	// Token: 0x0200000B RID: 11
	[Serializable]
	public class GameObjects
	{
		// Token: 0x04000059 RID: 89
		[Header("Set the game objects required for underwater mode.")]
		[Space(5f)]
		public GameObject mainCamera;

		// Token: 0x0400005A RID: 90
		public GameObject waterLens;

		// Token: 0x0400005B RID: 91
		public GameObject airLens;

		// Token: 0x0400005C RID: 92
		public GameObject bubble;

		// Token: 0x0400005D RID: 93
		[Space(5f)]
		[Header("Set waterplanes array size = number of waterplanes")]
		public List<GameObject> waterPlanes = new List<GameObject>();

		// Token: 0x0400005E RID: 94
		public bool useSquaredPlanes;
	}

	// Token: 0x0200000C RID: 12
	[Serializable]
	public class WetLens
	{
		// Token: 0x0400005F RID: 95
		[Header("Set how long the lens stays wet after diving up.")]
		public float wetTime = 1f;

		// Token: 0x04000060 RID: 96
		[Space(5f)]
		[Header("Set how long the lens needs to dry.")]
		public float dryingTime = 1.5f;

		// Token: 0x04000061 RID: 97
		[Space(5f)]
		public Texture2D[] sprayFrames;

		// Token: 0x04000062 RID: 98
		public Texture2D[] sprayFramesCutout;

		// Token: 0x04000063 RID: 99
		public float rundownSpeed = 72f;
	}

	// Token: 0x0200000D RID: 13
	[Serializable]
	public class CausticSettings
	{
		// Token: 0x04000064 RID: 100
		[Header("The following values are 'Afloat'/'Underwater'")]
		public Vector2 causticIntensity = new Vector2(0.6f, 0.2f);

		// Token: 0x04000065 RID: 101
		public Vector2 causticTiling = new Vector2(300f, 100f);

		// Token: 0x04000066 RID: 102
		public float maxCausticDepth;
	}

	// Token: 0x0200000E RID: 14
	[Serializable]
	public class Audio
	{
		// Token: 0x04000067 RID: 103
		public AudioClip[] sounds;

		// Token: 0x04000068 RID: 104
		[Range(0f, 1f)]
		public float underwaterVolume;

		// Token: 0x04000069 RID: 105
		[Range(0f, 1f)]
		public float surfacingVolume;

		// Token: 0x0400006A RID: 106
		[Range(0f, 1f)]
		public float diveVolume;
	}

	// Token: 0x0200000F RID: 15
	[Serializable]
	public class BubbleSpawnCriteria
	{
		// Token: 0x0400006B RID: 107
		[Header("Spawn Criteria for big bubbles")]
		public int minBubbleCount = 20;

		// Token: 0x0400006C RID: 108
		public int maxBubbleCount = 40;

		// Token: 0x0400006D RID: 109
		[Space(5f)]
		public float maxSpawnDistance = 1f;

		// Token: 0x0400006E RID: 110
		public float averageUpdrift = 3f;

		// Token: 0x0400006F RID: 111
		[Space(5f)]
		public float baseScale = 0.06f;

		// Token: 0x04000070 RID: 112
		public float avgScaleSummand = 0.15f;

		// Token: 0x04000071 RID: 113
		[Space(5f)]
		[Header("Spawn Timer for initial dive")]
		public float minSpawnTimer = 0.005f;

		// Token: 0x04000072 RID: 114
		public float maxSpawnTimer = 0.03f;

		// Token: 0x04000073 RID: 115
		[Space(5f)]
		[Header("Spawn Timer for long dive")]
		public float minSpawnTimerL = 0.1f;

		// Token: 0x04000074 RID: 116
		public float maxSpawnTimerL = 0.5f;
	}
}
