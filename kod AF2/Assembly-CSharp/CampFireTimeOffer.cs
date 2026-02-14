using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000160 RID: 352
public class CampFireTimeOffer : MonoBehaviour
{
	// Token: 0x06004B26 RID: 19238 RVA: 0x0022E813 File Offset: 0x0022CA13
	private IEnumerator NAMKPLCPHPL()
	{
		this.OAFOAJHNFOA();
		yield return new WaitForSeconds(1f);
		if (this.timeOn < this.timeOff)
		{
			if (TimeController.IKGFHGKKCPG.time >= (float)this.timeOn && TimeController.IKGFHGKKCPG.time < (float)this.timeOff)
			{
				this.HFGJCMLBPBC();
			}
		}
		else
		{
			bool flag = false;
			if (TimeController.IKGFHGKKCPG.time < (float)this.timeOff)
			{
				flag = true;
			}
			if (TimeController.IKGFHGKKCPG.time >= (float)this.timeOn)
			{
				flag = true;
			}
			if (flag)
			{
				this.HFGJCMLBPBC();
			}
			else
			{
				this.OAFOAJHNFOA();
			}
		}
		yield break;
	}

	// Token: 0x06004B27 RID: 19239 RVA: 0x0022E822 File Offset: 0x0022CA22
	private void MMOLACMOCIO()
	{
		if (!this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			this.alight.enabled = false;
			base.GetComponent<AudioSource>().Play();
			Debug.Log("IdleMouthWipe");
		}
	}

	// Token: 0x06004B28 RID: 19240 RVA: 0x0022E854 File Offset: 0x0022CA54
	private void FBMJIALKPEB()
	{
		if (TimeController.IKGFHGKKCPG != null)
		{
			TimeController.EKEBHIJMEML().DOGCPCFLNCD(base.gameObject);
		}
	}

	// Token: 0x06004B29 RID: 19241 RVA: 0x0022E874 File Offset: 0x0022CA74
	private void DDABGJJFCFG()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = false;
			Debug.Log("RIGHT");
		}
	}

	// Token: 0x06004B2A RID: 19242 RVA: 0x0022E8C0 File Offset: 0x0022CAC0
	public void HDJMFJPPADH(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.AMCEENIOHON();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.LKPBDAOPECA();
		}
	}

	// Token: 0x06004B2B RID: 19243 RVA: 0x0022E8E0 File Offset: 0x0022CAE0
	private IEnumerator IFEOAILAGEE()
	{
		CampFireTimeOffer.HGMMPKHPOOC hgmmpkhpooc = new CampFireTimeOffer.HGMMPKHPOOC(1);
		hgmmpkhpooc.AENJLLPLILM = this;
		return hgmmpkhpooc;
	}

	// Token: 0x06004B2C RID: 19244 RVA: 0x0022E8EF File Offset: 0x0022CAEF
	private void HFGJCMLBPBC()
	{
		if (!this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			this.alight.enabled = true;
			base.GetComponent<AudioSource>().Play();
			Debug.Log("fire on");
		}
	}

	// Token: 0x06004B2D RID: 19245 RVA: 0x0022E921 File Offset: 0x0022CB21
	private void FEMHFPFDFFH()
	{
		base.StartCoroutine("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}");
	}

	// Token: 0x06004B2E RID: 19246 RVA: 0x0022E92F File Offset: 0x0022CB2F
	private void DNFMEMNJADK()
	{
		if (TimeController.BOBNPEAEECC() != null)
		{
			TimeController.KOJCECHBHLO().CFPMJNFNBBB(base.gameObject);
		}
	}

	// Token: 0x06004B2F RID: 19247 RVA: 0x0022E94E File Offset: 0x0022CB4E
	private void AKGBDJDMOLC()
	{
		base.StartCoroutine("\n");
	}

	// Token: 0x06004B30 RID: 19248 RVA: 0x0022E95C File Offset: 0x0022CB5C
	public void newHour(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.HFGJCMLBPBC();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.OAFOAJHNFOA();
		}
	}

	// Token: 0x06004B31 RID: 19249 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EJOAPOGPBFM()
	{
	}

	// Token: 0x06004B32 RID: 19250 RVA: 0x0022E97C File Offset: 0x0022CB7C
	private void KCBBKIGIDFA()
	{
		if (!this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			this.alight.enabled = false;
			base.GetComponent<AudioSource>().Play();
			Debug.Log("****** FlyIcon tmpl is null id=");
		}
	}

	// Token: 0x06004B33 RID: 19251 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EDANNBFJHIK()
	{
	}

	// Token: 0x06004B34 RID: 19252 RVA: 0x0022E9AE File Offset: 0x0022CBAE
	public void IMBFLPOGKHJ(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.HFGJCMLBPBC();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.CJGKHLOAKGE();
		}
	}

	// Token: 0x06004B35 RID: 19253 RVA: 0x0022E9CE File Offset: 0x0022CBCE
	private void Awake()
	{
		base.StartCoroutine("ENNPIGEBADA");
	}

	// Token: 0x06004B36 RID: 19254 RVA: 0x0022E9DC File Offset: 0x0022CBDC
	private void GEFDGPPLCGD()
	{
		if (!this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			this.alight.enabled = true;
			base.GetComponent<AudioSource>().Play();
			Debug.Log("WallRunRight");
		}
	}

	// Token: 0x06004B37 RID: 19255 RVA: 0x0022EA0E File Offset: 0x0022CC0E
	private void JCMBBMFDBAI()
	{
		base.StartCoroutine("languageid");
	}

	// Token: 0x06004B38 RID: 19256 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OALIDDIKLHK()
	{
	}

	// Token: 0x06004B39 RID: 19257 RVA: 0x0022E8E0 File Offset: 0x0022CAE0
	private IEnumerator NPGIFNMOHGE()
	{
		CampFireTimeOffer.HGMMPKHPOOC hgmmpkhpooc = new CampFireTimeOffer.HGMMPKHPOOC(1);
		hgmmpkhpooc.AENJLLPLILM = this;
		return hgmmpkhpooc;
	}

	// Token: 0x06004B3A RID: 19258 RVA: 0x0022E8E0 File Offset: 0x0022CAE0
	private IEnumerator DECFBBFAPMA()
	{
		CampFireTimeOffer.HGMMPKHPOOC hgmmpkhpooc = new CampFireTimeOffer.HGMMPKHPOOC(1);
		hgmmpkhpooc.AENJLLPLILM = this;
		return hgmmpkhpooc;
	}

	// Token: 0x06004B3B RID: 19259 RVA: 0x0022EA1C File Offset: 0x0022CC1C
	private void IJNHBKIJOPF()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = true;
			Debug.Log("RunBackward");
		}
	}

	// Token: 0x06004B3C RID: 19260 RVA: 0x0022EA68 File Offset: 0x0022CC68
	private void JFHBGOOHIEC()
	{
		if (TimeController.IKGFHGKKCPG != null)
		{
			TimeController.EKEBHIJMEML().CFPMJNFNBBB(base.gameObject);
		}
	}

	// Token: 0x06004B3D RID: 19261 RVA: 0x0022EA88 File Offset: 0x0022CC88
	private void LBOHKBAGCPO()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = false;
			Debug.Log("StrafeRunRight");
		}
	}

	// Token: 0x06004B3E RID: 19262 RVA: 0x0022E8E0 File Offset: 0x0022CAE0
	private IEnumerator EJAGKCNNHMJ()
	{
		CampFireTimeOffer.HGMMPKHPOOC hgmmpkhpooc = new CampFireTimeOffer.HGMMPKHPOOC(1);
		hgmmpkhpooc.AENJLLPLILM = this;
		return hgmmpkhpooc;
	}

	// Token: 0x06004B3F RID: 19263 RVA: 0x0022E8E0 File Offset: 0x0022CAE0
	private IEnumerator IIIPJDBEBKO()
	{
		CampFireTimeOffer.HGMMPKHPOOC hgmmpkhpooc = new CampFireTimeOffer.HGMMPKHPOOC(1);
		hgmmpkhpooc.AENJLLPLILM = this;
		return hgmmpkhpooc;
	}

	// Token: 0x06004B40 RID: 19264 RVA: 0x0022EAD4 File Offset: 0x0022CCD4
	public void ABEDCHNIOEA(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.LBIDPJIAGJH();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.MDMLMAEOBGP();
		}
	}

	// Token: 0x06004B41 RID: 19265 RVA: 0x0022EAF4 File Offset: 0x0022CCF4
	private void CJGKHLOAKGE()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = false;
			Debug.Log("Wizard Overhead");
		}
	}

	// Token: 0x06004B42 RID: 19266 RVA: 0x0022EB40 File Offset: 0x0022CD40
	private void IEHOIMHFICG()
	{
		if (TimeController.EPCKOOOGNGK() != null)
		{
			TimeController.KOJCECHBHLO().DOGCPCFLNCD(base.gameObject);
		}
	}

	// Token: 0x06004B43 RID: 19267 RVA: 0x0022EB5F File Offset: 0x0022CD5F
	private void JOPKEFJOKIM()
	{
		if (TimeController.EKEBHIJMEML() != null)
		{
			TimeController.EPCKOOOGNGK().NCPNMCNHDGM(base.gameObject);
		}
	}

	// Token: 0x06004B44 RID: 19268 RVA: 0x0022EB7E File Offset: 0x0022CD7E
	public void ICMHEABCAPG(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.MMOLACMOCIO();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.KFBKGLPELPP();
		}
	}

	// Token: 0x06004B45 RID: 19269 RVA: 0x0022EB9E File Offset: 0x0022CD9E
	private void MLEPPKECCJE()
	{
		if (!this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			this.alight.enabled = true;
			base.GetComponent<AudioSource>().Play();
			Debug.Log("_StretchWidth");
		}
	}

	// Token: 0x06004B46 RID: 19270 RVA: 0x0022EBD0 File Offset: 0x0022CDD0
	private void CICEOAHKIII()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = true;
			Debug.Log("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_biped_i_k.html");
		}
	}

	// Token: 0x06004B47 RID: 19271 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BAIKCLKJPAA()
	{
	}

	// Token: 0x06004B48 RID: 19272 RVA: 0x0022EC1C File Offset: 0x0022CE1C
	private void LAIGLPNMHHI()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = true;
			Debug.Log("Point");
		}
	}

	// Token: 0x06004B49 RID: 19273 RVA: 0x0022E8E0 File Offset: 0x0022CAE0
	private IEnumerator JOJAPEAJOHI()
	{
		CampFireTimeOffer.HGMMPKHPOOC hgmmpkhpooc = new CampFireTimeOffer.HGMMPKHPOOC(1);
		hgmmpkhpooc.AENJLLPLILM = this;
		return hgmmpkhpooc;
	}

	// Token: 0x06004B4A RID: 19274 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MIFLHGMPLJD()
	{
	}

	// Token: 0x06004B4B RID: 19275 RVA: 0x0022EC68 File Offset: 0x0022CE68
	private void KIDFKDGHOHL()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = true;
			Debug.Log("[Y]");
		}
	}

	// Token: 0x06004B4C RID: 19276 RVA: 0x0022ECB4 File Offset: 0x0022CEB4
	private void AGGIPMOOBBP()
	{
		if (TimeController.EPCKOOOGNGK() != null)
		{
			TimeController.EPCKOOOGNGK().CFPMJNFNBBB(base.gameObject);
		}
	}

	// Token: 0x06004B4D RID: 19277 RVA: 0x0022ECD3 File Offset: 0x0022CED3
	public void POOOBEGJOFB(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.HFGJCMLBPBC();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.LBOHKBAGCPO();
		}
	}

	// Token: 0x06004B4E RID: 19278 RVA: 0x0022ECF4 File Offset: 0x0022CEF4
	private void DGJHIGCMGNA()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = true;
			Debug.Log("selColor");
		}
	}

	// Token: 0x06004B4F RID: 19279 RVA: 0x0022ED40 File Offset: 0x0022CF40
	private void MDMLMAEOBGP()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = true;
			Debug.Log("1");
		}
	}

	// Token: 0x06004B50 RID: 19280 RVA: 0x0022ED8C File Offset: 0x0022CF8C
	private void AMCEENIOHON()
	{
		if (!this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			this.alight.enabled = true;
			base.GetComponent<AudioSource>().Play();
			Debug.Log("NO TURN");
		}
	}

	// Token: 0x06004B51 RID: 19281 RVA: 0x0022EDBE File Offset: 0x0022CFBE
	public void EJBANGPGKOB(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.GEFDGPPLCGD();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.KIDFKDGHOHL();
		}
	}

	// Token: 0x06004B52 RID: 19282 RVA: 0x0022EDDE File Offset: 0x0022CFDE
	private void HHGMPMBDJIH()
	{
		if (!this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			this.alight.enabled = false;
			base.GetComponent<AudioSource>().Play();
			Debug.Log("Hidden/Subpixel Morphological Anti-aliasing");
		}
	}

	// Token: 0x06004B53 RID: 19283 RVA: 0x0022EE10 File Offset: 0x0022D010
	private void GCEIPALLKFH()
	{
		if (!this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			this.alight.enabled = false;
			base.GetComponent<AudioSource>().Play();
			Debug.Log("wpn_eat1");
		}
	}

	// Token: 0x06004B54 RID: 19284 RVA: 0x0022E813 File Offset: 0x0022CA13
	private IEnumerator OBDMIMEDMJE()
	{
		this.OAFOAJHNFOA();
		yield return new WaitForSeconds(1f);
		if (this.timeOn < this.timeOff)
		{
			if (TimeController.IKGFHGKKCPG.time >= (float)this.timeOn && TimeController.IKGFHGKKCPG.time < (float)this.timeOff)
			{
				this.HFGJCMLBPBC();
			}
		}
		else
		{
			bool flag = false;
			if (TimeController.IKGFHGKKCPG.time < (float)this.timeOff)
			{
				flag = true;
			}
			if (TimeController.IKGFHGKKCPG.time >= (float)this.timeOn)
			{
				flag = true;
			}
			if (flag)
			{
				this.HFGJCMLBPBC();
			}
			else
			{
				this.OAFOAJHNFOA();
			}
		}
		yield break;
	}

	// Token: 0x06004B55 RID: 19285 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x06004B56 RID: 19286 RVA: 0x0022EE44 File Offset: 0x0022D044
	private void AIPDDGJMFEC()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = true;
			Debug.Log("Q");
		}
	}

	// Token: 0x06004B57 RID: 19287 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DABJGOFIDJM()
	{
	}

	// Token: 0x06004B58 RID: 19288 RVA: 0x00022FCC File Offset: 0x000211CC
	private void INKGAFANFIB()
	{
	}

	// Token: 0x06004B59 RID: 19289 RVA: 0x0022E8E0 File Offset: 0x0022CAE0
	private IEnumerator PKBBOBAKKHL()
	{
		CampFireTimeOffer.HGMMPKHPOOC hgmmpkhpooc = new CampFireTimeOffer.HGMMPKHPOOC(1);
		hgmmpkhpooc.AENJLLPLILM = this;
		return hgmmpkhpooc;
	}

	// Token: 0x06004B5B RID: 19291 RVA: 0x0022E94E File Offset: 0x0022CB4E
	private void CEBAOOAIADJ()
	{
		base.StartCoroutine("\n");
	}

	// Token: 0x06004B5C RID: 19292 RVA: 0x0022EEB0 File Offset: 0x0022D0B0
	private void LKPBDAOPECA()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = true;
			Debug.Log("final ok: ");
		}
	}

	// Token: 0x06004B5D RID: 19293 RVA: 0x0022EEFC File Offset: 0x0022D0FC
	public void KODCGCPCOGK(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.HFOHPGMGKID();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.LKPBDAOPECA();
		}
	}

	// Token: 0x06004B5E RID: 19294 RVA: 0x0022EF1C File Offset: 0x0022D11C
	private void LHMIOHAGJJM()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = true;
			Debug.Log("WeaponFire");
		}
	}

	// Token: 0x06004B5F RID: 19295 RVA: 0x0022EF68 File Offset: 0x0022D168
	public void JHNEDOMGPNL(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.IMDJFOANDOM();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.LHMIOHAGJJM();
		}
	}

	// Token: 0x06004B60 RID: 19296 RVA: 0x0022EF88 File Offset: 0x0022D188
	private void NPKEBODNBAI()
	{
		base.StartCoroutine("distscale");
	}

	// Token: 0x06004B61 RID: 19297 RVA: 0x0022EF96 File Offset: 0x0022D196
	private void BHMKAOBHAII()
	{
		base.StartCoroutine("demoVector3");
	}

	// Token: 0x06004B62 RID: 19298 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MODJFGGIAHD()
	{
	}

	// Token: 0x06004B63 RID: 19299 RVA: 0x0022EFA4 File Offset: 0x0022D1A4
	private void JPAANPEIKOM()
	{
		if (TimeController.EKEBHIJMEML() != null)
		{
			TimeController.BOBNPEAEECC().CFPMJNFNBBB(base.gameObject);
		}
	}

	// Token: 0x06004B64 RID: 19300 RVA: 0x0022E8E0 File Offset: 0x0022CAE0
	private IEnumerator KKDNLBMBFFC()
	{
		CampFireTimeOffer.HGMMPKHPOOC hgmmpkhpooc = new CampFireTimeOffer.HGMMPKHPOOC(1);
		hgmmpkhpooc.AENJLLPLILM = this;
		return hgmmpkhpooc;
	}

	// Token: 0x06004B65 RID: 19301 RVA: 0x0022EFC4 File Offset: 0x0022D1C4
	private void OEAEMLCLJIJ()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = false;
			Debug.Log("WRINKLE_MAPS");
		}
	}

	// Token: 0x06004B66 RID: 19302 RVA: 0x0022E813 File Offset: 0x0022CA13
	private IEnumerator LNLADPACEEK()
	{
		this.OAFOAJHNFOA();
		yield return new WaitForSeconds(1f);
		if (this.timeOn < this.timeOff)
		{
			if (TimeController.IKGFHGKKCPG.time >= (float)this.timeOn && TimeController.IKGFHGKKCPG.time < (float)this.timeOff)
			{
				this.HFGJCMLBPBC();
			}
		}
		else
		{
			bool flag = false;
			if (TimeController.IKGFHGKKCPG.time < (float)this.timeOff)
			{
				flag = true;
			}
			if (TimeController.IKGFHGKKCPG.time >= (float)this.timeOn)
			{
				flag = true;
			}
			if (flag)
			{
				this.HFGJCMLBPBC();
			}
			else
			{
				this.OAFOAJHNFOA();
			}
		}
		yield break;
	}

	// Token: 0x06004B67 RID: 19303 RVA: 0x0022F010 File Offset: 0x0022D210
	private void BHECIFOGAIE()
	{
		if (TimeController.BOBNPEAEECC() != null)
		{
			TimeController.EKEBHIJMEML().delMsgListener(base.gameObject);
		}
	}

	// Token: 0x06004B68 RID: 19304 RVA: 0x0022F02F File Offset: 0x0022D22F
	public void BCHCODEENPB(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.IJBDKLHMKIF();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.IJNHBKIJOPF();
		}
	}

	// Token: 0x06004B69 RID: 19305 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IJOCHELLKJH()
	{
	}

	// Token: 0x06004B6A RID: 19306 RVA: 0x0022F04F File Offset: 0x0022D24F
	private void IJBDKLHMKIF()
	{
		if (!this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			this.alight.enabled = true;
			base.GetComponent<AudioSource>().Play();
			Debug.Log("#02C85F");
		}
	}

	// Token: 0x06004B6B RID: 19307 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GPCKACGEILI()
	{
	}

	// Token: 0x06004B6C RID: 19308 RVA: 0x0022F084 File Offset: 0x0022D284
	private void HMKAEKOPIMC()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = true;
			Debug.Log("knopje.wav");
		}
	}

	// Token: 0x06004B6D RID: 19309 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OFGMIEJKMGC()
	{
	}

	// Token: 0x06004B6E RID: 19310 RVA: 0x0022E813 File Offset: 0x0022CA13
	private IEnumerator GMKPNBIDLBF()
	{
		this.OAFOAJHNFOA();
		yield return new WaitForSeconds(1f);
		if (this.timeOn < this.timeOff)
		{
			if (TimeController.IKGFHGKKCPG.time >= (float)this.timeOn && TimeController.IKGFHGKKCPG.time < (float)this.timeOff)
			{
				this.HFGJCMLBPBC();
			}
		}
		else
		{
			bool flag = false;
			if (TimeController.IKGFHGKKCPG.time < (float)this.timeOff)
			{
				flag = true;
			}
			if (TimeController.IKGFHGKKCPG.time >= (float)this.timeOn)
			{
				flag = true;
			}
			if (flag)
			{
				this.HFGJCMLBPBC();
			}
			else
			{
				this.OAFOAJHNFOA();
			}
		}
		yield break;
	}

	// Token: 0x06004B6F RID: 19311 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EFJDBBDMPMC()
	{
	}

	// Token: 0x06004B70 RID: 19312 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JIFOELPAEHG()
	{
	}

	// Token: 0x06004B71 RID: 19313 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GCNGEFBKMNC()
	{
	}

	// Token: 0x06004B72 RID: 19314 RVA: 0x0022F0D0 File Offset: 0x0022D2D0
	private void KFBKGLPELPP()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = false;
			Debug.Log("**** Weather cloudly={0} fog={1} rain={2} snaige={3} grom={4}");
		}
	}

	// Token: 0x06004B73 RID: 19315 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HCDJABMBDFF()
	{
	}

	// Token: 0x06004B74 RID: 19316 RVA: 0x0022F11C File Offset: 0x0022D31C
	private void JMNLEBAPHNJ()
	{
		base.StartCoroutine("setCurrentRod curorder=");
	}

	// Token: 0x06004B75 RID: 19317 RVA: 0x0022F12A File Offset: 0x0022D32A
	private void OnDestroy()
	{
		if (TimeController.IKGFHGKKCPG != null)
		{
			TimeController.IKGFHGKKCPG.delMsgListener(base.gameObject);
		}
	}

	// Token: 0x06004B76 RID: 19318 RVA: 0x0022F149 File Offset: 0x0022D349
	private void DGCPMPPKOCC()
	{
		if (!this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			this.alight.enabled = true;
			base.GetComponent<AudioSource>().Play();
			Debug.Log("wpn_popl1");
		}
	}

	// Token: 0x06004B77 RID: 19319 RVA: 0x0022F17B File Offset: 0x0022D37B
	private void FOIJINIJEID()
	{
		base.StartCoroutine("HALIGN");
	}

	// Token: 0x06004B78 RID: 19320 RVA: 0x0022F189 File Offset: 0x0022D389
	private void BNHHKABAFHK()
	{
		if (TimeController.EPCKOOOGNGK() != null)
		{
			TimeController.IKGFHGKKCPG.ONBAEDGHKHG(base.gameObject);
		}
	}

	// Token: 0x06004B79 RID: 19321 RVA: 0x0022E813 File Offset: 0x0022CA13
	private IEnumerator NDMOKJMGKMH()
	{
		this.OAFOAJHNFOA();
		yield return new WaitForSeconds(1f);
		if (this.timeOn < this.timeOff)
		{
			if (TimeController.IKGFHGKKCPG.time >= (float)this.timeOn && TimeController.IKGFHGKKCPG.time < (float)this.timeOff)
			{
				this.HFGJCMLBPBC();
			}
		}
		else
		{
			bool flag = false;
			if (TimeController.IKGFHGKKCPG.time < (float)this.timeOff)
			{
				flag = true;
			}
			if (TimeController.IKGFHGKKCPG.time >= (float)this.timeOn)
			{
				flag = true;
			}
			if (flag)
			{
				this.HFGJCMLBPBC();
			}
			else
			{
				this.OAFOAJHNFOA();
			}
		}
		yield break;
	}

	// Token: 0x06004B7A RID: 19322 RVA: 0x0022F1A8 File Offset: 0x0022D3A8
	private void DAKLOGMELKO()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = true;
			Debug.Log("name");
		}
	}

	// Token: 0x06004B7B RID: 19323 RVA: 0x0022F1F4 File Offset: 0x0022D3F4
	private void BMMEIIIJIFF()
	{
		if (TimeController.IKGFHGKKCPG != null)
		{
			TimeController.IKGFHGKKCPG.NCPNMCNHDGM(base.gameObject);
		}
	}

	// Token: 0x06004B7C RID: 19324 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JOHDLNOKCOK()
	{
	}

	// Token: 0x06004B7D RID: 19325 RVA: 0x0022F213 File Offset: 0x0022D413
	private void DOBFKBMGMNA()
	{
		base.StartCoroutine("_BlurParams");
	}

	// Token: 0x06004B7E RID: 19326 RVA: 0x0022F221 File Offset: 0x0022D421
	private void CKGJEIDEJCH()
	{
		base.StartCoroutine("BipedReferences contains one or more missing Transforms.");
	}

	// Token: 0x06004B7F RID: 19327 RVA: 0x0022F22F File Offset: 0x0022D42F
	public void DMPMGGLOLMH(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.EIGNGGEMIMA();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.EHHODJNDNNO();
		}
	}

	// Token: 0x06004B80 RID: 19328 RVA: 0x0022F24F File Offset: 0x0022D44F
	public void DCKIGEDCNLE(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.HHGMPMBDJIH();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.DAKLOGMELKO();
		}
	}

	// Token: 0x06004B81 RID: 19329 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JBFJPNKLLKI()
	{
	}

	// Token: 0x06004B82 RID: 19330 RVA: 0x0022F270 File Offset: 0x0022D470
	private void OAFOAJHNFOA()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = false;
			Debug.Log("fire off");
		}
	}

	// Token: 0x06004B83 RID: 19331 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FJIGNBOFFOJ()
	{
	}

	// Token: 0x06004B84 RID: 19332 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LACNPNKHCAA()
	{
	}

	// Token: 0x06004B85 RID: 19333 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FKHAKIKPFFO()
	{
	}

	// Token: 0x06004B86 RID: 19334 RVA: 0x0022F2BC File Offset: 0x0022D4BC
	public void MPMPJHGIEGL(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.EIGNGGEMIMA();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.LKPBDAOPECA();
		}
	}

	// Token: 0x06004B87 RID: 19335 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GDPMOMHBIFN()
	{
	}

	// Token: 0x06004B88 RID: 19336 RVA: 0x0022F2DC File Offset: 0x0022D4DC
	private void HFOHPGMGKID()
	{
		if (!this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			this.alight.enabled = false;
			base.GetComponent<AudioSource>().Play();
			Debug.Log("(game main)");
		}
	}

	// Token: 0x06004B89 RID: 19337 RVA: 0x0022E8E0 File Offset: 0x0022CAE0
	private IEnumerator FIKPAKJBIHJ()
	{
		CampFireTimeOffer.HGMMPKHPOOC hgmmpkhpooc = new CampFireTimeOffer.HGMMPKHPOOC(1);
		hgmmpkhpooc.AENJLLPLILM = this;
		return hgmmpkhpooc;
	}

	// Token: 0x06004B8A RID: 19338 RVA: 0x0022F30E File Offset: 0x0022D50E
	private void JLLAOEIAIAO()
	{
		if (!this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			this.alight.enabled = true;
			base.GetComponent<AudioSource>().Play();
			Debug.Log("double: ");
		}
	}

	// Token: 0x06004B8B RID: 19339 RVA: 0x0022F340 File Offset: 0x0022D540
	public void DBOBNLKNDJI(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.KCBBKIGIDFA();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.DAKLOGMELKO();
		}
	}

	// Token: 0x06004B8C RID: 19340 RVA: 0x0022F360 File Offset: 0x0022D560
	public void PGIIELNKBHK(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.GCEIPALLKFH();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.FEEHBNAJBDI();
		}
	}

	// Token: 0x06004B8D RID: 19341 RVA: 0x0022F380 File Offset: 0x0022D580
	private void BPPNGPBJONL()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = false;
			Debug.Log("ragulaEventProc");
		}
	}

	// Token: 0x06004B8E RID: 19342 RVA: 0x0022E8E0 File Offset: 0x0022CAE0
	private IEnumerator AAANMEDHAGN()
	{
		CampFireTimeOffer.HGMMPKHPOOC hgmmpkhpooc = new CampFireTimeOffer.HGMMPKHPOOC(1);
		hgmmpkhpooc.AENJLLPLILM = this;
		return hgmmpkhpooc;
	}

	// Token: 0x06004B8F RID: 19343 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KJJNMNKPNCH()
	{
	}

	// Token: 0x06004B90 RID: 19344 RVA: 0x0022E813 File Offset: 0x0022CA13
	private IEnumerator JFMLGJKEEAI()
	{
		this.OAFOAJHNFOA();
		yield return new WaitForSeconds(1f);
		if (this.timeOn < this.timeOff)
		{
			if (TimeController.IKGFHGKKCPG.time >= (float)this.timeOn && TimeController.IKGFHGKKCPG.time < (float)this.timeOff)
			{
				this.HFGJCMLBPBC();
			}
		}
		else
		{
			bool flag = false;
			if (TimeController.IKGFHGKKCPG.time < (float)this.timeOff)
			{
				flag = true;
			}
			if (TimeController.IKGFHGKKCPG.time >= (float)this.timeOn)
			{
				flag = true;
			}
			if (flag)
			{
				this.HFGJCMLBPBC();
			}
			else
			{
				this.OAFOAJHNFOA();
			}
		}
		yield break;
	}

	// Token: 0x06004B91 RID: 19345 RVA: 0x0022F3CC File Offset: 0x0022D5CC
	private void EIGNGGEMIMA()
	{
		if (!this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			this.alight.enabled = false;
			base.GetComponent<AudioSource>().Play();
			Debug.Log("rbon");
		}
	}

	// Token: 0x06004B92 RID: 19346 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ACLNFGPOHBF()
	{
	}

	// Token: 0x06004B93 RID: 19347 RVA: 0x0022F3FE File Offset: 0x0022D5FE
	public void PLKPOHDNKNK(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.DGCPMPPKOCC();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.IJNHBKIJOPF();
		}
	}

	// Token: 0x06004B94 RID: 19348 RVA: 0x0022F41E File Offset: 0x0022D61E
	public void CMMCBJFLKEH(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.LBIDPJIAGJH();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.FEEHBNAJBDI();
		}
	}

	// Token: 0x06004B95 RID: 19349 RVA: 0x0022F189 File Offset: 0x0022D389
	private void PKPGIGEEEJI()
	{
		if (TimeController.EPCKOOOGNGK() != null)
		{
			TimeController.IKGFHGKKCPG.ONBAEDGHKHG(base.gameObject);
		}
	}

	// Token: 0x06004B96 RID: 19350 RVA: 0x0022F43E File Offset: 0x0022D63E
	public void BNNFAIBJBDP(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.AMCEENIOHON();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.AFEACCIAOLC();
		}
	}

	// Token: 0x06004B97 RID: 19351 RVA: 0x0022F460 File Offset: 0x0022D660
	private void FEEHBNAJBDI()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = false;
			Debug.Log("gi_um_1");
		}
	}

	// Token: 0x06004B98 RID: 19352 RVA: 0x0022F4AC File Offset: 0x0022D6AC
	private void JGKDNHLKBEN()
	{
		base.StartCoroutine("Textures/Perks/");
	}

	// Token: 0x06004B99 RID: 19353 RVA: 0x0022E8E0 File Offset: 0x0022CAE0
	private IEnumerator DJPKABLGHOD()
	{
		CampFireTimeOffer.HGMMPKHPOOC hgmmpkhpooc = new CampFireTimeOffer.HGMMPKHPOOC(1);
		hgmmpkhpooc.AENJLLPLILM = this;
		return hgmmpkhpooc;
	}

	// Token: 0x06004B9A RID: 19354 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DKOIOBMMAGN()
	{
	}

	// Token: 0x06004B9B RID: 19355 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OPDCJCFMIPE()
	{
	}

	// Token: 0x06004B9C RID: 19356 RVA: 0x0022F4BA File Offset: 0x0022D6BA
	private void IMDJFOANDOM()
	{
		if (!this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			this.alight.enabled = true;
			base.GetComponent<AudioSource>().Play();
			Debug.Log("");
		}
	}

	// Token: 0x06004B9D RID: 19357 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Start()
	{
	}

	// Token: 0x06004B9E RID: 19358 RVA: 0x0022F4EC File Offset: 0x0022D6EC
	private void EHHODJNDNNO()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = false;
			Debug.Log("IdleStrafeRight");
		}
	}

	// Token: 0x06004B9F RID: 19359 RVA: 0x0022F538 File Offset: 0x0022D738
	private void OBMPEBPAOFJ()
	{
		if (TimeController.KOJCECHBHLO() != null)
		{
			TimeController.IKGFHGKKCPG.delMsgListener(base.gameObject);
		}
	}

	// Token: 0x06004BA0 RID: 19360 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DPPAAIJCFLC()
	{
	}

	// Token: 0x06004BA1 RID: 19361 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ACLJDJBJLCD()
	{
	}

	// Token: 0x06004BA2 RID: 19362 RVA: 0x0022F558 File Offset: 0x0022D758
	private void AFEACCIAOLC()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = true;
			Debug.Log("WoodSaw");
		}
	}

	// Token: 0x06004BA3 RID: 19363 RVA: 0x0022E8E0 File Offset: 0x0022CAE0
	private IEnumerator OABHJDDIIIN()
	{
		CampFireTimeOffer.HGMMPKHPOOC hgmmpkhpooc = new CampFireTimeOffer.HGMMPKHPOOC(1);
		hgmmpkhpooc.AENJLLPLILM = this;
		return hgmmpkhpooc;
	}

	// Token: 0x06004BA4 RID: 19364 RVA: 0x0022F5A4 File Offset: 0x0022D7A4
	private void MBNCGMLPNLD()
	{
		base.StartCoroutine(" ");
	}

	// Token: 0x06004BA5 RID: 19365 RVA: 0x0022F5B2 File Offset: 0x0022D7B2
	private void CONGABENFFF()
	{
		if (!this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			this.alight.enabled = false;
			base.GetComponent<AudioSource>().Play();
			Debug.Log("Apply 6");
		}
	}

	// Token: 0x06004BA6 RID: 19366 RVA: 0x0022E813 File Offset: 0x0022CA13
	private IEnumerator ENNPIGEBADA()
	{
		this.OAFOAJHNFOA();
		yield return new WaitForSeconds(1f);
		if (this.timeOn < this.timeOff)
		{
			if (TimeController.IKGFHGKKCPG.time >= (float)this.timeOn && TimeController.IKGFHGKKCPG.time < (float)this.timeOff)
			{
				this.HFGJCMLBPBC();
			}
		}
		else
		{
			bool flag = false;
			if (TimeController.IKGFHGKKCPG.time < (float)this.timeOff)
			{
				flag = true;
			}
			if (TimeController.IKGFHGKKCPG.time >= (float)this.timeOn)
			{
				flag = true;
			}
			if (flag)
			{
				this.HFGJCMLBPBC();
			}
			else
			{
				this.OAFOAJHNFOA();
			}
		}
		yield break;
	}

	// Token: 0x06004BA7 RID: 19367 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PLBDELOIINH()
	{
	}

	// Token: 0x06004BA8 RID: 19368 RVA: 0x0022F5E4 File Offset: 0x0022D7E4
	private void LPDIHACCGKK()
	{
		base.StartCoroutine("WeaponFire");
	}

	// Token: 0x06004BA9 RID: 19369 RVA: 0x0022F5F2 File Offset: 0x0022D7F2
	public void GECMDFHDBEA(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.IMDJFOANDOM();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.CICEOAHKIII();
		}
	}

	// Token: 0x06004BAA RID: 19370 RVA: 0x0022F612 File Offset: 0x0022D812
	public void IJLBBIEDAAC(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.AMCEENIOHON();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.AIPDDGJMFEC();
		}
	}

	// Token: 0x06004BAB RID: 19371 RVA: 0x0022F632 File Offset: 0x0022D832
	private void PJMCFJBFLIH()
	{
		base.StartCoroutine("Error!");
	}

	// Token: 0x06004BAC RID: 19372 RVA: 0x0022F640 File Offset: 0x0022D840
	private void BLDELNFCEGB()
	{
		base.StartCoroutine("BowReady");
	}

	// Token: 0x06004BAD RID: 19373 RVA: 0x0022F650 File Offset: 0x0022D850
	private void LPLPPHKHPOE()
	{
		if (this.alight == null)
		{
			return;
		}
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			base.GetComponent<AudioSource>().Stop();
			this.alight.enabled = true;
			Debug.Log("<color='{2}'>{0}: {1}</color>");
		}
	}

	// Token: 0x06004BAE RID: 19374 RVA: 0x0022F69C File Offset: 0x0022D89C
	private void LBIDPJIAGJH()
	{
		if (!this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			this.alight.enabled = true;
			base.GetComponent<AudioSource>().Play();
			Debug.Log("</color>\n");
		}
	}

	// Token: 0x06004BAF RID: 19375 RVA: 0x0022F6CE File Offset: 0x0022D8CE
	public void LNNCGLMMION(int CONGHFMELAK)
	{
		if (CONGHFMELAK == this.timeOn)
		{
			this.HFOHPGMGKID();
		}
		if (CONGHFMELAK == this.timeOff)
		{
			this.LBOHKBAGCPO();
		}
	}

	// Token: 0x06004BB0 RID: 19376 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ACFEBEDDIAI()
	{
	}

	// Token: 0x04000B86 RID: 2950
	public Light alight;

	// Token: 0x04000B87 RID: 2951
	public int timeOn = 18;

	// Token: 0x04000B88 RID: 2952
	public int timeOff = 6;

	// Token: 0x04000B89 RID: 2953
	private bool IKKPFPJLPOL = true;
}
