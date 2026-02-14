using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200043B RID: 1083
	[Serializable]
	public abstract class Constraint
	{
		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600E912 RID: 59666 RVA: 0x0069C881 File Offset: 0x0069AA81
		public bool isValid
		{
			get
			{
				return this.transform != null;
			}
		}

		// Token: 0x0600E913 RID: 59667
		public abstract void CBJIKGNFCJI();

		// Token: 0x04001EA1 RID: 7841
		public Transform transform;

		// Token: 0x04001EA2 RID: 7842
		public float weight;
	}
}
