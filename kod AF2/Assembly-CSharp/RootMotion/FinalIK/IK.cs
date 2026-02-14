using System;

namespace RootMotion.FinalIK
{
	// Token: 0x02000454 RID: 1108
	public abstract class IK : SolverManager
	{
		// Token: 0x0600EFC3 RID: 61379
		public abstract IKSolver GetIKSolver();

		// Token: 0x0600EFC4 RID: 61380 RVA: 0x006B8F3B File Offset: 0x006B713B
		protected override void MBOPIBBAHOD()
		{
			if (!this.GetIKSolver().initiated)
			{
				this.MPJFMFOPHKJ();
			}
			if (!this.GetIKSolver().initiated)
			{
				return;
			}
			this.GetIKSolver().FANPFKHEDPA();
		}

		// Token: 0x0600EFC5 RID: 61381 RVA: 0x006B8F69 File Offset: 0x006B7169
		protected override void MPJFMFOPHKJ()
		{
			if (this.GetIKSolver().initiated)
			{
				return;
			}
			this.GetIKSolver().BHALELINNDJ(base.transform);
		}

		// Token: 0x0600EFC6 RID: 61382 RVA: 0x006B8F8A File Offset: 0x006B718A
		protected override void BLOEEPCIPKJ()
		{
			if (!this.GetIKSolver().initiated)
			{
				return;
			}
			this.GetIKSolver().BLOEEPCIPKJ();
		}

		// Token: 0x0600EFC7 RID: 61383
		protected abstract void NLLHEACBOPP();

		// Token: 0x0600EFC8 RID: 61384
		protected abstract void AFEMLFIOJIA();
	}
}
