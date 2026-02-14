using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020004A2 RID: 1186
	public abstract class Poser : SolverManager
	{
		// Token: 0x06010306 RID: 66310
		public abstract void AutoMapping();

		// Token: 0x06010307 RID: 66311
		protected abstract void FNPFFPPGGFD();

		// Token: 0x06010308 RID: 66312
		protected abstract void BLHJPADDJOM();

		// Token: 0x06010309 RID: 66313
		protected abstract void NPJKDOKKPJJ();

		// Token: 0x0601030A RID: 66314 RVA: 0x007416DA File Offset: 0x0073F8DA
		protected override void MBOPIBBAHOD()
		{
			if (!this.EOFDOPLDFCG)
			{
				this.MPJFMFOPHKJ();
			}
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			this.BLHJPADDJOM();
		}

		// Token: 0x0601030B RID: 66315 RVA: 0x007416F9 File Offset: 0x0073F8F9
		protected override void MPJFMFOPHKJ()
		{
			if (this.EOFDOPLDFCG)
			{
				return;
			}
			this.FNPFFPPGGFD();
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0601030C RID: 66316 RVA: 0x00741711 File Offset: 0x0073F911
		protected override void BLOEEPCIPKJ()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			this.NPJKDOKKPJJ();
		}

		// Token: 0x04002205 RID: 8709
		public Transform poseRoot;

		// Token: 0x04002206 RID: 8710
		[Range(0f, 1f)]
		public float weight = 1f;

		// Token: 0x04002207 RID: 8711
		[Range(0f, 1f)]
		public float localRotationWeight = 1f;

		// Token: 0x04002208 RID: 8712
		[Range(0f, 1f)]
		public float localPositionWeight;

		// Token: 0x04002209 RID: 8713
		private bool EOFDOPLDFCG;
	}
}
