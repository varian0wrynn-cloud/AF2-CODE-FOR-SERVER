using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000429 RID: 1065
	public abstract class WeaponBase : MonoBehaviour
	{
		// Token: 0x0600E661 RID: 58977
		public abstract void Fire();

		// Token: 0x04001E0A RID: 7690
		[Header("Recoil")]
		public Vector3 recoilDirection = -Vector3.forward;

		// Token: 0x04001E0B RID: 7691
		public float recoilAngleVertical = 1f;

		// Token: 0x04001E0C RID: 7692
		public float recoilAngleHorizontal = 1f;

		// Token: 0x04001E0D RID: 7693
		public float recoilRandom = 0.2f;
	}
}
