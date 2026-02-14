using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000574 RID: 1396
	[Serializable]
	public abstract class PostProcessingModel
	{
		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06012432 RID: 74802 RVA: 0x0080353D File Offset: 0x0080173D
		// (set) Token: 0x06012433 RID: 74803 RVA: 0x00803545 File Offset: 0x00801745
		public bool enabled
		{
			get
			{
				return this.m_Enabled;
			}
			set
			{
				this.m_Enabled = value;
				if (value)
				{
					this.GIBDKLENALN();
				}
			}
		}

		// Token: 0x06012434 RID: 74804
		public abstract void Reset();

		// Token: 0x06012435 RID: 74805 RVA: 0x00022FCC File Offset: 0x000211CC
		public virtual void GIBDKLENALN()
		{
		}

		// Token: 0x040025C7 RID: 9671
		[EPAPLFHLLJN("enabled")]
		[SerializeField]
		private bool m_Enabled;
	}
}
