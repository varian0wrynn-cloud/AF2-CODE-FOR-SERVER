using System;
using UnityEngine;

// Token: 0x02000002 RID: 2
public class AQUAS_BubbleBehaviour : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	private void OLGDMBDGLAN()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.HFICODOMJBP();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000002 RID: 2 RVA: 0x000020C9 File Offset: 0x000002C9
	private void IIHNDJOIMAH()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(2, 72);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000020F4 File Offset: 0x000002F4
	private void PAKOHKKBKHD()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.CMDLKCOODIP();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000004 RID: 4 RVA: 0x0000216D File Offset: 0x0000036D
	private void KEMGOLACEHI()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-62, -38);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002196 File Offset: 0x00000396
	private void BJCONKIIOBM()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-19, 75);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000021BF File Offset: 0x000003BF
	private void GGBMJFNGHMC()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-89, -8);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000021E8 File Offset: 0x000003E8
	private void LMMDHJJJNJO()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.BDNGCOONPOI();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002264 File Offset: 0x00000464
	private void HFHLCGLPPGK()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1065f, 1467f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 1973f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(767f, 218f), base.transform.position.y - UnityEngine.Random.Range(1116f, 235f), base.transform.position.z + UnityEngine.Random.Range(1160f, 549f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x06000009 RID: 9 RVA: 0x0000236E File Offset: 0x0000056E
	private void PEKDKKHPINC()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-108, -95);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002398 File Offset: 0x00000598
	private void OABBFHFODOP()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(27f, 1031f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 307f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(271f, 211f), base.transform.position.y - UnityEngine.Random.Range(643f, 1011f), base.transform.position.z + UnityEngine.Random.Range(813f, 457f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x0600000B RID: 11 RVA: 0x000024A4 File Offset: 0x000006A4
	private void IJMECOHONAP()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1984f, 454f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 1473f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(767f, 379f), base.transform.position.y - UnityEngine.Random.Range(1168f, 1207f), base.transform.position.z + UnityEngine.Random.Range(1523f, 446f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000025B0 File Offset: 0x000007B0
	private void GPJOPADMJAP()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(383f, 623f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 586f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(928f, 1716f), base.transform.position.y - UnityEngine.Random.Range(494f, 1025f), base.transform.position.z + UnityEngine.Random.Range(424f, 807f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x000026BA File Offset: 0x000008BA
	private void APPLKMOGAMJ()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(113, 3);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000026E4 File Offset: 0x000008E4
	private void BJOICAKCPLI()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.HANCKOOPMJP();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002760 File Offset: 0x00000960
	private void DIAIKCBANBK()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.ICJFFIGJEFC();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000027DC File Offset: 0x000009DC
	private void Update()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.FFNNCJKKBMC();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002858 File Offset: 0x00000A58
	private void KJJBBLDJHPD()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.CMDLKCOODIP();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000028D4 File Offset: 0x00000AD4
	private void FFNNCJKKBMC()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(0.05f, 0.2f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 0.5f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(-0.1f, 0.1f), base.transform.position.y - UnityEngine.Random.Range(0.01f, 1f), base.transform.position.z + UnityEngine.Random.Range(-0.1f, 0.1f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000029E0 File Offset: 0x00000BE0
	private void AFHBOLFGJNE()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.GNOIMIDFFMC();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002A5C File Offset: 0x00000C5C
	private void HFICODOMJBP()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(387f, 30f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 41f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1834f, 1621f), base.transform.position.y - UnityEngine.Random.Range(592f, 1315f), base.transform.position.z + UnityEngine.Random.Range(237f, 1178f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002B68 File Offset: 0x00000D68
	private void KJCCFLCNNHM()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1059f, 1550f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 262f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(11f, 1953f), base.transform.position.y - UnityEngine.Random.Range(1268f, 782f), base.transform.position.z + UnityEngine.Random.Range(1221f, 167f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002C72 File Offset: 0x00000E72
	private void BMNJGPIPKLL()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(68, 51);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002C9C File Offset: 0x00000E9C
	private void HANCKOOPMJP()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(263f, 1209f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 1814f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1338f, 1954f), base.transform.position.y - UnityEngine.Random.Range(441f, 451f), base.transform.position.z + UnityEngine.Random.Range(1635f, 724f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002DA6 File Offset: 0x00000FA6
	private void OLBDJCFPKFG()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(123, 41);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002DD0 File Offset: 0x00000FD0
	private void FEEBIGAAOFM()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1316f, 40f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 715f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(565f, 113f), base.transform.position.y - UnityEngine.Random.Range(964f, 1453f), base.transform.position.z + UnityEngine.Random.Range(229f, 188f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002EDA File Offset: 0x000010DA
	private void BLLGOMHDFPL()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(15, 38);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002F04 File Offset: 0x00001104
	private void PFNOEACNHON()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.HLEDFFMDABB();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002F80 File Offset: 0x00001180
	private void ANONNCHEFOC()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1767f, 427f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 697f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(747f, 1423f), base.transform.position.y - UnityEngine.Random.Range(208f, 1601f), base.transform.position.z + UnityEngine.Random.Range(1119f, 720f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x0600001D RID: 29 RVA: 0x0000308C File Offset: 0x0000128C
	private void IEOICHPKEMD()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.DLGABFOFNLO();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00003108 File Offset: 0x00001308
	private void JOOAFNICJKF()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(341f, 1126f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 386f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1921f, 1966f), base.transform.position.y - UnityEngine.Random.Range(244f, 1633f), base.transform.position.z + UnityEngine.Random.Range(1420f, 606f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00003214 File Offset: 0x00001414
	private void JJFHPGDPHGB()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.PCLPPGPENFB();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00003290 File Offset: 0x00001490
	private void BABNEIJILFH()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1778f, 1680f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 586f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1869f, 142f), base.transform.position.y - UnityEngine.Random.Range(40f, 733f), base.transform.position.z + UnityEngine.Random.Range(1960f, 1063f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x06000021 RID: 33 RVA: 0x0000339C File Offset: 0x0000159C
	private void DLHONKPEPEA()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1990f, 655f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 569f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(798f, 1121f), base.transform.position.y - UnityEngine.Random.Range(915f, 539f), base.transform.position.z + UnityEngine.Random.Range(1154f, 1975f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000034A8 File Offset: 0x000016A8
	private void HMEAENGBFKC()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.OBCDLELKGKD();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00003524 File Offset: 0x00001724
	private void JDCOGBKGOLL()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1649f, 1604f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 765f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1603f, 113f), base.transform.position.y - UnityEngine.Random.Range(1425f, 905f), base.transform.position.z + UnityEngine.Random.Range(1852f, 1094f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00003630 File Offset: 0x00001830
	private void GHOBHBMFKHN()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.LMMAEABKKHG();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000025 RID: 37 RVA: 0x000036A9 File Offset: 0x000018A9
	private void LHKGDKLABAA()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-20, 26);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000026 RID: 38 RVA: 0x000036D2 File Offset: 0x000018D2
	private void ECMAANIDEBA()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-52, 40);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000027 RID: 39 RVA: 0x000036FB File Offset: 0x000018FB
	private void KECMAHFJBCD()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-42, -55);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00003724 File Offset: 0x00001924
	private void OIBIGDFPHGO()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.KOHKNFAKENH();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000029 RID: 41 RVA: 0x000037A0 File Offset: 0x000019A0
	private void GPCKACGEILI()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.JGMPMOBOPBN();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600002A RID: 42 RVA: 0x0000381C File Offset: 0x00001A1C
	private void FGONMKDNDLK()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.NLFHHGMPCDC();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00003898 File Offset: 0x00001A98
	private void OCLECLKLEJL()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1903f, 561f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 293f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(356f, 918f), base.transform.position.y - UnityEngine.Random.Range(821f, 242f), base.transform.position.z + UnityEngine.Random.Range(462f, 214f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x000039A4 File Offset: 0x00001BA4
	private void GNOIMIDFFMC()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(817f, 132f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 1601f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1765f, 171f), base.transform.position.y - UnityEngine.Random.Range(1230f, 1271f), base.transform.position.z + UnityEngine.Random.Range(540f, 24f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00003AB0 File Offset: 0x00001CB0
	private void OBCDLELKGKD()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(276f, 635f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 1111f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(282f, 1326f), base.transform.position.y - UnityEngine.Random.Range(258f, 109f), base.transform.position.z + UnityEngine.Random.Range(1098f, 849f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00003BBC File Offset: 0x00001DBC
	private void HJCLNJLADKL()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.AFNOKADPJIE();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00003C35 File Offset: 0x00001E35
	private void CJNBMPCNKHP()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-48, 125);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00003C5E File Offset: 0x00001E5E
	private void HDGNIHBIEDG()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-40, -4);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00003C88 File Offset: 0x00001E88
	private void EDANNBFJHIK()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.GPJOPADMJAP();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00003D04 File Offset: 0x00001F04
	private void AIAMIFEPALP()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.EJEOJGLFKEN();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00003D7D File Offset: 0x00001F7D
	private void FNBGGJJLIGG()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(63, 16);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00003DA6 File Offset: 0x00001FA6
	private void EHFPLKEINFO()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-102, 105);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00003DCF File Offset: 0x00001FCF
	private void AIFIEAGFIMM()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-29, 88);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00003DF8 File Offset: 0x00001FF8
	private void JPHLMNIMDHH()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.JJHBNAGFMEN();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00003E74 File Offset: 0x00002074
	private void EDEODHDFANE()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.HANCKOOPMJP();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00003EED File Offset: 0x000020ED
	private void NCBLFNKNEDK()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(3, -73);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003F16 File Offset: 0x00002116
	private void IJOCHELLKJH()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(29, 28);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00003F40 File Offset: 0x00002140
	private void BDNGCOONPOI()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(756f, 1887f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 1588f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(57f, 82f), base.transform.position.y - UnityEngine.Random.Range(1096f, 1963f), base.transform.position.z + UnityEngine.Random.Range(603f, 705f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x0600003B RID: 59 RVA: 0x0000404C File Offset: 0x0000224C
	private void NLFHHGMPCDC()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(852f, 918f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 1489f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1455f, 960f), base.transform.position.y - UnityEngine.Random.Range(864f, 270f), base.transform.position.z + UnityEngine.Random.Range(1966f, 168f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x0600003D RID: 61 RVA: 0x0000415E File Offset: 0x0000235E
	private void OPNPODKLOJK()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(125, -65);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00004188 File Offset: 0x00002388
	private void BOAJJAKEMLH()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.OABBFHFODOP();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00004204 File Offset: 0x00002404
	private void HLHMGFEBMEL()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(441f, 1604f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 608f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(929f, 250f), base.transform.position.y - UnityEngine.Random.Range(1615f, 1304f), base.transform.position.z + UnityEngine.Random.Range(746f, 393f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x06000040 RID: 64 RVA: 0x0000430E File Offset: 0x0000250E
	private void LCBIFGKANMD()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-29, -15);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00004337 File Offset: 0x00002537
	private void MMACLBBMDLA()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-49, 30);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00004360 File Offset: 0x00002560
	private void DLGABFOFNLO()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1689f, 671f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 1166f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1602f, 24f), base.transform.position.y - UnityEngine.Random.Range(513f, 1267f), base.transform.position.z + UnityEngine.Random.Range(82f, 1695f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x06000043 RID: 67 RVA: 0x0000446C File Offset: 0x0000266C
	private void AAEFACEGJMB()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.ICJFFIGJEFC();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000044 RID: 68 RVA: 0x000044E8 File Offset: 0x000026E8
	private void DHDGPGOONBC()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.HFICODOMJBP();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00004561 File Offset: 0x00002761
	private void OFGMIEJKMGC()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-27, 39);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000046 RID: 70 RVA: 0x0000458A File Offset: 0x0000278A
	private void ACLJDJBJLCD()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-66, 1);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000047 RID: 71 RVA: 0x000045B4 File Offset: 0x000027B4
	private void ODLJLPIMCIE()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(955f, 1553f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 731f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(913f, 39f), base.transform.position.y - UnityEngine.Random.Range(1967f, 761f), base.transform.position.z + UnityEngine.Random.Range(530f, 191f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x06000048 RID: 72 RVA: 0x000046C0 File Offset: 0x000028C0
	private void CBFPLIFGNNA()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(996f, 1250f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 133f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1794f, 1540f), base.transform.position.y - UnityEngine.Random.Range(1821f, 1830f), base.transform.position.z + UnityEngine.Random.Range(342f, 1019f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x06000049 RID: 73 RVA: 0x000047CA File Offset: 0x000029CA
	private void DGEIACONKCJ()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(2, -23);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x0600004A RID: 74 RVA: 0x000047F3 File Offset: 0x000029F3
	private void GDIMBBBPIHI()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-24, -102);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x0600004B RID: 75 RVA: 0x0000481C File Offset: 0x00002A1C
	private void PMKOAHMNBBG()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.DJFCMGEFIFL();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00004898 File Offset: 0x00002A98
	private void LFJHDHPJOPE()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.FEEBIGAAOFM();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00004914 File Offset: 0x00002B14
	private void JJHBNAGFMEN()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1189f, 27f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 814f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1064f, 1410f), base.transform.position.y - UnityEngine.Random.Range(390f, 1666f), base.transform.position.z + UnityEngine.Random.Range(1318f, 1662f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00004A1E File Offset: 0x00002C1E
	private void ABEIHJCDDCH()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-101, 27);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00004A47 File Offset: 0x00002C47
	private void BHFMGBNIAMC()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-115, -90);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00004A70 File Offset: 0x00002C70
	private void PBFKCKCHEAC()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.OFFNDEJEBBK();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00004AEC File Offset: 0x00002CEC
	private void JGMPMOBOPBN()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1244f, 507f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 1936f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1354f, 1499f), base.transform.position.y - UnityEngine.Random.Range(968f, 1684f), base.transform.position.z + UnityEngine.Random.Range(1255f, 1555f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00004BF8 File Offset: 0x00002DF8
	private void GCCAPOHGAHA()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.DLHONKPEPEA();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00004C74 File Offset: 0x00002E74
	private void LMMAEABKKHG()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(80f, 260f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 698f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(404f, 1978f), base.transform.position.y - UnityEngine.Random.Range(150f, 292f), base.transform.position.z + UnityEngine.Random.Range(1920f, 1639f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00004D80 File Offset: 0x00002F80
	private void JIBKGOFOPHJ()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.PONEBKEAOJO();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00004DFC File Offset: 0x00002FFC
	private void CJHBCHBOLBI()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.GPJOPADMJAP();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00004E75 File Offset: 0x00003075
	private void PLBDELOIINH()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(21, -124);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00004EA0 File Offset: 0x000030A0
	private void HLEDFFMDABB()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(342f, 1529f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 443f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1405f, 267f), base.transform.position.y - UnityEngine.Random.Range(440f, 1670f), base.transform.position.z + UnityEngine.Random.Range(1903f, 266f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00004FAA File Offset: 0x000031AA
	private void KDCOHILDJJO()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(20, -8);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00004FD4 File Offset: 0x000031D4
	private void OBGFILLOLOJ()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1092f, 714f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 364f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1692f, 410f), base.transform.position.y - UnityEngine.Random.Range(1619f, 984f), base.transform.position.z + UnityEngine.Random.Range(1620f, 821f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x0600005A RID: 90 RVA: 0x000050E0 File Offset: 0x000032E0
	private void GDBBAMFMKII()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.LMMAEABKKHG();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600005B RID: 91 RVA: 0x0000515C File Offset: 0x0000335C
	private void KJJEEMEHGBF()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.HLEDFFMDABB();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600005C RID: 92 RVA: 0x000051D8 File Offset: 0x000033D8
	private void BLMBPFIJJBP()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.GPJOPADMJAP();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00005254 File Offset: 0x00003454
	private void AFNOKADPJIE()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1702f, 853f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 14f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(642f, 1157f), base.transform.position.y - UnityEngine.Random.Range(7f, 188f), base.transform.position.z + UnityEngine.Random.Range(1109f, 1666f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x0600005E RID: 94 RVA: 0x0000535E File Offset: 0x0000355E
	private void LHMNFJBJBJM()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(99, -44);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00005387 File Offset: 0x00003587
	private void EHDPACPIBNF()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(32, 69);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000060 RID: 96 RVA: 0x000053B0 File Offset: 0x000035B0
	private void MNAHGMDDHCA()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.JDCOGBKGOLL();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000061 RID: 97 RVA: 0x0000542C File Offset: 0x0000362C
	private void LAGGDCBJLNK()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.CJOMELDMDNO();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000054A8 File Offset: 0x000036A8
	private void IDMCOLDDNCF()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.LMMAEABKKHG();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00005524 File Offset: 0x00003724
	private void ICJFFIGJEFC()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1463f, 724f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 775f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1162f, 1374f), base.transform.position.y - UnityEngine.Random.Range(1160f, 1440f), base.transform.position.z + UnityEngine.Random.Range(266f, 521f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x06000064 RID: 100 RVA: 0x0000562E File Offset: 0x0000382E
	private void Start()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(20, 30);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00005658 File Offset: 0x00003858
	private void DJFCMGEFIFL()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1351f, 1239f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 1467f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(429f, 50f), base.transform.position.y - UnityEngine.Random.Range(1752f, 432f), base.transform.position.z + UnityEngine.Random.Range(557f, 648f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00005762 File Offset: 0x00003962
	private void DIBOKDBMKJI()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(101, 106);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000067 RID: 103 RVA: 0x0000578C File Offset: 0x0000398C
	private void LEHBKPPGHPC()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.IJMECOHONAP();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00005808 File Offset: 0x00003A08
	private void PBEKBHFDHAM()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.HLEDFFMDABB();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00005884 File Offset: 0x00003A84
	private void PONEBKEAOJO()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1124f, 146f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 573f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1614f, 879f), base.transform.position.y - UnityEngine.Random.Range(1331f, 729f), base.transform.position.z + UnityEngine.Random.Range(1369f, 1552f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00005990 File Offset: 0x00003B90
	private void LMGBKHCHPHO()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.HLHMGFEBMEL();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00005A0C File Offset: 0x00003C0C
	private void KCBECEFNGMO()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.ANONNCHEFOC();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00005A88 File Offset: 0x00003C88
	private void CBBLGEDCJBF()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.HANCKOOPMJP();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00005B04 File Offset: 0x00003D04
	private void ACLNFGPOHBF()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.ANONNCHEFOC();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00005B80 File Offset: 0x00003D80
	private void BNKJNBIDPME()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.MILBFGHHFPC();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00005BFC File Offset: 0x00003DFC
	private void MFHGOLNLAAF()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.FEEBIGAAOFM();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00005C78 File Offset: 0x00003E78
	private void LBBCFOBAOBH()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1192f, 1483f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 1042f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(562f, 1876f), base.transform.position.y - UnityEngine.Random.Range(345f, 1269f), base.transform.position.z + UnityEngine.Random.Range(1767f, 325f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00005D84 File Offset: 0x00003F84
	private void FKHAKIKPFFO()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.IJMECOHONAP();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00005E00 File Offset: 0x00004000
	private void OFFNDEJEBBK()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(527f, 549f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 1580f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(50f, 370f), base.transform.position.y - UnityEngine.Random.Range(1632f, 1051f), base.transform.position.z + UnityEngine.Random.Range(1654f, 744f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00005F0C File Offset: 0x0000410C
	private void PCLPPGPENFB()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1566f, 1407f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 1212f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1625f, 863f), base.transform.position.y - UnityEngine.Random.Range(544f, 1077f), base.transform.position.z + UnityEngine.Random.Range(903f, 1490f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00006018 File Offset: 0x00004218
	private void BDDPMEJOJJO()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(48f, 1992f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 627f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1734f, 458f), base.transform.position.y - UnityEngine.Random.Range(146f, 589f), base.transform.position.z + UnityEngine.Random.Range(147f, 1204f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00006124 File Offset: 0x00004324
	private void CJOMELDMDNO()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1540f, 448f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 719f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(435f, 1925f), base.transform.position.y - UnityEngine.Random.Range(227f, 1397f), base.transform.position.z + UnityEngine.Random.Range(1841f, 1333f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x06000076 RID: 118 RVA: 0x0000622E File Offset: 0x0000442E
	private void EFCCCKGCOCB()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(113, 90);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00006258 File Offset: 0x00004458
	private void MMOOOOFLOMO()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1443f, 386f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 1609f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(752f, 1795f), base.transform.position.y - UnityEngine.Random.Range(1551f, 1597f), base.transform.position.z + UnityEngine.Random.Range(1200f, 393f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00006364 File Offset: 0x00004564
	private void BIGPMMGBPJC()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.NLFHHGMPCDC();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000079 RID: 121 RVA: 0x000063E0 File Offset: 0x000045E0
	private void CKNMEMOJOHN()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(825f, 824f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 1429f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1744f, 452f), base.transform.position.y - UnityEngine.Random.Range(745f, 1607f), base.transform.position.z + UnityEngine.Random.Range(442f, 1931f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x0600007A RID: 122 RVA: 0x000064EA File Offset: 0x000046EA
	private void CGMHGDEKDEP()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(87, -112);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00006514 File Offset: 0x00004714
	private void MPLCAGFGEBO()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.GPJOPADMJAP();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00006590 File Offset: 0x00004790
	private void HABONMJNDAL()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.World);
		this.HLEDFFMDABB();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600007D RID: 125 RVA: 0x0000660C File Offset: 0x0000480C
	private void EJEOJGLFKEN()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1031f, 1725f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 1707f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(1558f, 772f), base.transform.position.y - UnityEngine.Random.Range(555f, 415f), base.transform.position.z + UnityEngine.Random.Range(1028f, 237f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00006718 File Offset: 0x00004918
	private void HONIFOPBBKC()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.BABNEIJILFH();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00006794 File Offset: 0x00004994
	private void HNMODJBBKBI()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.JDCOGBKGOLL();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000080 RID: 128 RVA: 0x0000680D File Offset: 0x00004A0D
	private void KGICJDGIIJK()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-32, -22);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00006836 File Offset: 0x00004A36
	private void OBJCOJEHLBE()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(39, 93);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000082 RID: 130 RVA: 0x0000685F File Offset: 0x00004A5F
	private void FODDAMMNECI()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-5, 126);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00006888 File Offset: 0x00004A88
	private void ELADFDNPOOI()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(-7, 44);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000084 RID: 132 RVA: 0x000068B4 File Offset: 0x00004AB4
	private void KOHKNFAKENH()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(770f, 1042f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 1499f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(655f, 1462f), base.transform.position.y - UnityEngine.Random.Range(1260f, 1112f), base.transform.position.z + UnityEngine.Random.Range(1687f, 102f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x06000085 RID: 133 RVA: 0x000069C0 File Offset: 0x00004BC0
	private void MILBFGHHFPC()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(1693f, 1337f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 501f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(760f, 1759f), base.transform.position.y - UnityEngine.Random.Range(1538f, 151f), base.transform.position.z + UnityEngine.Random.Range(1096f, 113f)), Quaternion.identity);
			this.DELCGEHKLAO += 0;
		}
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00006ACC File Offset: 0x00004CCC
	private void CDLDCKAHLHC()
	{
		base.transform.Translate(Vector3.up * Time.deltaTime * this.averageUpdrift, Space.Self);
		this.JJHBNAGFMEN();
		if (this.mainCamera.transform.position.y > this.waterLevel || base.transform.position.y > this.waterLevel)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00006B48 File Offset: 0x00004D48
	private void CMDLKCOODIP()
	{
		if (this.DELCGEHKLAO <= this.JPPLPPFNKOC)
		{
			this.smallBubble.transform.localScale = base.transform.localScale * UnityEngine.Random.Range(671f, 1026f);
			this.DNDPLLEJABK.averageUpdrift = this.averageUpdrift * 236f;
			this.DNDPLLEJABK.waterLevel = this.waterLevel;
			this.DNDPLLEJABK.mainCamera = this.mainCamera;
			UnityEngine.Object.Instantiate<GameObject>(this.smallBubble, new Vector3(base.transform.position.x + UnityEngine.Random.Range(37f, 394f), base.transform.position.y - UnityEngine.Random.Range(865f, 154f), base.transform.position.z + UnityEngine.Random.Range(1099f, 649f)), Quaternion.identity);
			this.DELCGEHKLAO++;
		}
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00006C52 File Offset: 0x00004E52
	private void CAJLCEPLKJG()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(91, 111);
		this.DELCGEHKLAO = 1;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00006C7B File Offset: 0x00004E7B
	private void JHAKJAMBNAH()
	{
		this.JPPLPPFNKOC = UnityEngine.Random.Range(111, -100);
		this.DELCGEHKLAO = 0;
		this.DNDPLLEJABK = this.smallBubble.GetComponent<AQUAS_SmallBubbleBehaviour>();
	}

	// Token: 0x04000001 RID: 1
	public float averageUpdrift;

	// Token: 0x04000002 RID: 2
	public float waterLevel;

	// Token: 0x04000003 RID: 3
	public GameObject mainCamera;

	// Token: 0x04000004 RID: 4
	public GameObject smallBubble;

	// Token: 0x04000005 RID: 5
	private int DELCGEHKLAO;

	// Token: 0x04000006 RID: 6
	private int JPPLPPFNKOC;

	// Token: 0x04000007 RID: 7
	private AQUAS_SmallBubbleBehaviour DNDPLLEJABK;
}
