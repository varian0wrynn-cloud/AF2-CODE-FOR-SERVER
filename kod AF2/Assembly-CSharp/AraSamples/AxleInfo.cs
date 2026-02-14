using System;
using UnityEngine;

namespace AraSamples
{
	// Token: 0x020005B4 RID: 1460
	[Serializable]
	public class AxleInfo
	{
		// Token: 0x0400276D RID: 10093
		public WheelCollider leftWheel;

		// Token: 0x0400276E RID: 10094
		public WheelCollider rightWheel;

		// Token: 0x0400276F RID: 10095
		public bool motor;

		// Token: 0x04002770 RID: 10096
		public bool steering;
	}
}
