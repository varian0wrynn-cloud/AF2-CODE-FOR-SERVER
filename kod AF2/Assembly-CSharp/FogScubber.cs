using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000145 RID: 325
public class FogScubber : MonoBehaviour
{
	// Token: 0x06004450 RID: 17488 RVA: 0x00201234 File Offset: 0x001FF434
	private IEnumerator KKDNLBMBFFC()
	{
		for (;;)
		{
			yield return new WaitForSeconds(3f);
			bool isWork = false;
			if (TimeController.IKGFHGKKCPG.time >= (float)this.StartTimeHour && TimeController.IKGFHGKKCPG.time < (float)this.EndTimeHour)
			{
				isWork = true;
			}
			this.IKKPFPJLPOL = isWork;
		}
		yield break;
	}

	// Token: 0x06004451 RID: 17489 RVA: 0x00022FCC File Offset: 0x000211CC
	public void INOEBIBPDJB()
	{
	}

	// Token: 0x06004452 RID: 17490 RVA: 0x00022FCC File Offset: 0x000211CC
	public void EGAAMGKAHKM()
	{
	}

	// Token: 0x06004453 RID: 17491 RVA: 0x00022FCC File Offset: 0x000211CC
	public void ELMMAOAILLL()
	{
	}

	// Token: 0x06004454 RID: 17492 RVA: 0x00201243 File Offset: 0x001FF443
	public bool OAOAPJKMLHO()
	{
		return this.DPEOPGOKJMJ;
	}

	// Token: 0x06004455 RID: 17493 RVA: 0x00201243 File Offset: 0x001FF443
	public bool NPECOPGNDNI()
	{
		return this.DPEOPGOKJMJ;
	}

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x0600445B RID: 17499 RVA: 0x00201243 File Offset: 0x001FF443
	// (set) Token: 0x06004456 RID: 17494 RVA: 0x0020124C File Offset: 0x001FF44C
	public bool IKKPFPJLPOL
	{
		get
		{
			return this.DPEOPGOKJMJ;
		}
		set
		{
			bool dpeopgokjmj = this.DPEOPGOKJMJ;
			this.DPEOPGOKJMJ = value;
			if (this.DPEOPGOKJMJ)
			{
				if (dpeopgokjmj != this.DPEOPGOKJMJ)
				{
					this.onFog();
					return;
				}
			}
			else if (dpeopgokjmj != this.DPEOPGOKJMJ)
			{
				this.offFog();
			}
		}
	}

	// Token: 0x06004457 RID: 17495 RVA: 0x00022FCC File Offset: 0x000211CC
	public void offFog()
	{
	}

	// Token: 0x06004458 RID: 17496 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x06004459 RID: 17497 RVA: 0x00022FCC File Offset: 0x000211CC
	public void NPNJKGOOOGN()
	{
	}

	// Token: 0x0600445A RID: 17498 RVA: 0x00022FCC File Offset: 0x000211CC
	public void GIPLMNALOCH()
	{
	}

	// Token: 0x0600445C RID: 17500 RVA: 0x0020128E File Offset: 0x001FF48E
	private void OnDestroy()
	{
		this.offFog();
	}

	// Token: 0x0600445D RID: 17501 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AIAMIFEPALP()
	{
	}

	// Token: 0x0600445E RID: 17502 RVA: 0x00201243 File Offset: 0x001FF443
	public bool PMBEFEOCOPB()
	{
		return this.DPEOPGOKJMJ;
	}

	// Token: 0x0600445F RID: 17503 RVA: 0x00022FCC File Offset: 0x000211CC
	public void OCBHPKNJFAH()
	{
	}

	// Token: 0x06004460 RID: 17504 RVA: 0x00201234 File Offset: 0x001FF434
	private IEnumerator JJNMIOOEHPI()
	{
		for (;;)
		{
			yield return new WaitForSeconds(3f);
			bool isWork = false;
			if (TimeController.IKGFHGKKCPG.time >= (float)this.StartTimeHour && TimeController.IKGFHGKKCPG.time < (float)this.EndTimeHour)
			{
				isWork = true;
			}
			this.IKKPFPJLPOL = isWork;
		}
		yield break;
	}

	// Token: 0x06004461 RID: 17505 RVA: 0x00201234 File Offset: 0x001FF434
	private IEnumerator ENNPIGEBADA()
	{
		for (;;)
		{
			yield return new WaitForSeconds(3f);
			bool isWork = false;
			if (TimeController.IKGFHGKKCPG.time >= (float)this.StartTimeHour && TimeController.IKGFHGKKCPG.time < (float)this.EndTimeHour)
			{
				isWork = true;
			}
			this.IKKPFPJLPOL = isWork;
		}
		yield break;
	}

	// Token: 0x06004462 RID: 17506 RVA: 0x00022FCC File Offset: 0x000211CC
	public void FAIKNALIFPP()
	{
	}

	// Token: 0x06004463 RID: 17507 RVA: 0x0020128E File Offset: 0x001FF48E
	private void NJHJLHBNPOM()
	{
		this.offFog();
	}

	// Token: 0x06004464 RID: 17508 RVA: 0x00022FCC File Offset: 0x000211CC
	public void onFog()
	{
	}

	// Token: 0x06004465 RID: 17509 RVA: 0x00201296 File Offset: 0x001FF496
	private void Start()
	{
		this.offFog();
		base.StartCoroutine("ENNPIGEBADA");
	}

	// Token: 0x06004467 RID: 17511 RVA: 0x00022FCC File Offset: 0x000211CC
	public void PGDBBBPMGKE()
	{
	}

	// Token: 0x04000AE2 RID: 2786
	public int StartTimeHour = 5;

	// Token: 0x04000AE3 RID: 2787
	public int EndTimeHour = 7;

	// Token: 0x04000AE4 RID: 2788
	private bool DPEOPGOKJMJ;
}
