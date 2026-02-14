using System;
using UnityEngine;

namespace UnityStandardAssets.Cameras
{
	// Token: 0x020003AF RID: 943
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		// Token: 0x0600CC41 RID: 52289 RVA: 0x005BECC0 File Offset: 0x005BCEC0
		protected virtual void Awake()
		{
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>().transform;
			this.JBJCNGPGNHG = this.JGKJBAJLKLI.parent;
		}

		// Token: 0x04001B15 RID: 6933
		protected Transform JGKJBAJLKLI;

		// Token: 0x04001B16 RID: 6934
		protected Transform JBJCNGPGNHG;

		// Token: 0x04001B17 RID: 6935
		protected Vector3 EGJMDMJNCPM;
	}
}
