using System;
using UnityEngine;

// Token: 0x02000012 RID: 18
public class AQUAS_SmallBubbleBehaviour : MonoBehaviour
{
	// Token: 0x0600020B RID: 523 RVA: 0x00022FFA File Offset: 0x000211FA
	private void IIKDDILLGLF()
	{
		this.EHJDCNCNDKA = UnityEngine.Random.Range(-this.averageUpdrift * 1520f, this.averageUpdrift * 1698f);
	}

	// Token: 0x0600020C RID: 524 RVA: 0x00023020 File Offset: 0x00021220
	private void JLFBDOPFDDJ()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * (this.averageUpdrift + this.EHJDCNCNDKA), Space.Self);
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600020D RID: 525 RVA: 0x0002309C File Offset: 0x0002129C
	private void Update()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * (this.averageUpdrift + this.EHJDCNCNDKA), Space.World);
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600020E RID: 526 RVA: 0x00023116 File Offset: 0x00021316
	private void Start()
	{
		this.EHJDCNCNDKA = UnityEngine.Random.Range(-this.averageUpdrift * 0.75f, this.averageUpdrift * 0.75f);
	}

	// Token: 0x0600020F RID: 527 RVA: 0x0002313C File Offset: 0x0002133C
	private void AKLFCMNCPKL()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * (this.averageUpdrift + this.EHJDCNCNDKA), Space.World);
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000210 RID: 528 RVA: 0x000231B6 File Offset: 0x000213B6
	private void EDGALMCHPPH()
	{
		this.EHJDCNCNDKA = UnityEngine.Random.Range(-this.averageUpdrift * 1926f, this.averageUpdrift * 1057f);
	}

	// Token: 0x06000211 RID: 529 RVA: 0x000231DC File Offset: 0x000213DC
	private void BOAJJAKEMLH()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * (this.averageUpdrift + this.EHJDCNCNDKA), Space.World);
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000212 RID: 530 RVA: 0x00023258 File Offset: 0x00021458
	private void AIAMIFEPALP()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * (this.averageUpdrift + this.EHJDCNCNDKA), Space.Self);
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000214 RID: 532 RVA: 0x000232D2 File Offset: 0x000214D2
	private void OBJCOJEHLBE()
	{
		this.EHJDCNCNDKA = UnityEngine.Random.Range(-this.averageUpdrift * 216f, this.averageUpdrift * 1623f);
	}

	// Token: 0x06000215 RID: 533 RVA: 0x000232F8 File Offset: 0x000214F8
	private void PGIHAIPCJLL()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * (this.averageUpdrift + this.EHJDCNCNDKA), Space.World);
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000216 RID: 534 RVA: 0x00023372 File Offset: 0x00021572
	private void BMNJGPIPKLL()
	{
		this.EHJDCNCNDKA = UnityEngine.Random.Range(-this.averageUpdrift * 219f, this.averageUpdrift * 713f);
	}

	// Token: 0x06000217 RID: 535 RVA: 0x00023398 File Offset: 0x00021598
	private void KEMGOLACEHI()
	{
		this.EHJDCNCNDKA = UnityEngine.Random.Range(-this.averageUpdrift * 204f, this.averageUpdrift * 18f);
	}

	// Token: 0x06000218 RID: 536 RVA: 0x000233BE File Offset: 0x000215BE
	private void MCHAAIIHOKD()
	{
		this.EHJDCNCNDKA = UnityEngine.Random.Range(-this.averageUpdrift * 1542f, this.averageUpdrift * 1128f);
	}

	// Token: 0x04000080 RID: 128
	public float averageUpdrift;

	// Token: 0x04000081 RID: 129
	public float waterLevel;

	// Token: 0x04000082 RID: 130
	public GameObject mainCamera;

	// Token: 0x04000083 RID: 131
	private float EHJDCNCNDKA;
}
