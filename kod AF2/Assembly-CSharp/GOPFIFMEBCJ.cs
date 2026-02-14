using System;
using UnityEngine.PostProcessing;

// Token: 0x02000570 RID: 1392
public abstract class GOPFIFMEBCJ<T> : GINHKMOJKNN where T : PostProcessingModel
{
	// Token: 0x17000406 RID: 1030
	// (get) Token: 0x0601239F RID: 74655 RVA: 0x00803268 File Offset: 0x00801468
	// (set) Token: 0x060123A0 RID: 74656 RVA: 0x00803270 File Offset: 0x00801470
	public T BBEPCCALAFC { get; internal set; }

	// Token: 0x060123A1 RID: 74657 RVA: 0x00803279 File Offset: 0x00801479
	public virtual void PINLMCCKKNA(NGEENBGMFFM KEIBEMILLED, T MPDLBFGKCIO)
	{
		this.AMCOGJHPPOC = KEIBEMILLED;
		this.BBEPCCALAFC = MPDLBFGKCIO;
	}

	// Token: 0x060123A2 RID: 74658 RVA: 0x00803289 File Offset: 0x00801489
	public override PostProcessingModel IEIKOEPMMDA()
	{
		return this.BBEPCCALAFC;
	}
}
