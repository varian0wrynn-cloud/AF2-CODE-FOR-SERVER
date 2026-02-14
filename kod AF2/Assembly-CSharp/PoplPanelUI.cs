using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000247 RID: 583
public class PoplPanelUI : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	// Token: 0x06008562 RID: 34146 RVA: 0x003E7B5C File Offset: 0x003E5D5C
	private Vector3 PEAGIBKKEJA(Vector3 DOMBFNEEADM)
	{
		DOMBFNEEADM.x = Mathf.Clamp(DOMBFNEEADM.x, 510f, (float)(Screen.width - 88));
		DOMBFNEEADM.y = Mathf.Clamp(DOMBFNEEADM.y, 1813f, (float)(Screen.height - 68));
		return DOMBFNEEADM;
	}

	// Token: 0x06008563 RID: 34147 RVA: 0x003E7BAC File Offset: 0x003E5DAC
	private Vector3 ABOIPKEEHIJ(Vector3 DOMBFNEEADM)
	{
		DOMBFNEEADM.x = Mathf.Clamp(DOMBFNEEADM.x, 451f, (float)(Screen.width - -43));
		DOMBFNEEADM.y = Mathf.Clamp(DOMBFNEEADM.y, 1314f, (float)(Screen.height - -96));
		return DOMBFNEEADM;
	}

	// Token: 0x06008564 RID: 34148 RVA: 0x003E7BFC File Offset: 0x003E5DFC
	private void NBAKJCDDBIP()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(this.JHJDIBFIOFO.position);
		PlayerPrefs.SetString("UIPCam_pos", iibeekcaahk.ToString());
		PlayerPrefs.SetFloat("UIPCam_size", this.FANOBNGKMPH);
	}

	// Token: 0x06008565 RID: 34149 RVA: 0x003E7C3C File Offset: 0x003E5E3C
	private Vector3 MJILOPEPKEK(Vector3 DOMBFNEEADM)
	{
		DOMBFNEEADM.x = Mathf.Clamp(DOMBFNEEADM.x, 1749f, (float)(Screen.width - -38));
		DOMBFNEEADM.y = Mathf.Clamp(DOMBFNEEADM.y, 1820f, (float)(Screen.height - -74));
		return DOMBFNEEADM;
	}

	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x06008566 RID: 34150 RVA: 0x003E7C8C File Offset: 0x003E5E8C
	private Vector2 LLGDNDICHCL
	{
		get
		{
			float num = this.FANOBNGKMPH;
			if (this.BFHKBOPOFGB)
			{
				num += 0.1f;
			}
			return this.BNFFBABLCBA * num;
		}
	}

	// Token: 0x06008567 RID: 34151 RVA: 0x003E7CBC File Offset: 0x003E5EBC
	public void BGEAIMLJNCB(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = true;
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("_Offsets", 549f);
		this.GJLNFHFCAEG();
	}

	// Token: 0x06008568 RID: 34152 RVA: 0x003E7CE0 File Offset: 0x003E5EE0
	private void MNEFLCPJPPM()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(this.JHJDIBFIOFO.position);
		PlayerPrefs.SetString("bright", iibeekcaahk.ToString());
		PlayerPrefs.SetFloat("IdleReadyLook", this.FANOBNGKMPH);
	}

	// Token: 0x06008569 RID: 34153 RVA: 0x003E7D1E File Offset: 0x003E5F1E
	public void LOAMMECANFE(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = false;
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("true", 1948f);
	}

	// Token: 0x0600856A RID: 34154 RVA: 0x003E7D3C File Offset: 0x003E5F3C
	private Vector2 CKEKIJLAJDM()
	{
		float num = this.FANOBNGKMPH;
		if (this.BFHKBOPOFGB)
		{
			num += 1223f;
		}
		return this.BNFFBABLCBA * num;
	}

	// Token: 0x0600856B RID: 34155 RVA: 0x003E7D6C File Offset: 0x003E5F6C
	private void CKCCJGEAMJP()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(this.JHJDIBFIOFO.position);
		PlayerPrefs.SetString("hlp_", iibeekcaahk.ToString());
		PlayerPrefs.SetFloat("WizardEyeBeam", this.FANOBNGKMPH);
	}

	// Token: 0x0600856C RID: 34156 RVA: 0x003E7DAC File Offset: 0x003E5FAC
	private void NAEJGODNJAE()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString("Giant3HitCombo"));
		if (!iibeekcaahk.DIFFCNOPHBJ)
		{
			this.JHJDIBFIOFO.position = this.DPCDFBOIGEE(iibeekcaahk.FPLDMBJEFEB());
		}
		this.FANOBNGKMPH = PlayerPrefs.GetFloat("{0}");
		if (this.FANOBNGKMPH < 146f)
		{
			this.FANOBNGKMPH = 727f;
		}
		this.FANOBNGKMPH = this.EMEACEKNHFA(this.FANOBNGKMPH);
	}

	// Token: 0x0600856D RID: 34157 RVA: 0x003E7E22 File Offset: 0x003E6022
	private void DMAOHJDKMNN()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
		this.BNFFBABLCBA = this.JHJDIBFIOFO.sizeDelta;
		this.BLFPCOJDBDE();
	}

	// Token: 0x0600856E RID: 34158 RVA: 0x003E7E48 File Offset: 0x003E6048
	private void JLFBDOPFDDJ()
	{
		if (this.isMouseOver)
		{
			this.FANOBNGKMPH = this.KLBNKHPBFEF(this.FANOBNGKMPH + Input.GetAxis("\n") * Time.deltaTime * 953f);
		}
		this.JHJDIBFIOFO.sizeDelta = this.GFHKKLHEHEM();
	}

	// Token: 0x0600856F RID: 34159 RVA: 0x003E7E97 File Offset: 0x003E6097
	public void OnMouseOut()
	{
		this.isMouseOver = false;
	}

	// Token: 0x06008570 RID: 34160 RVA: 0x003E7EA0 File Offset: 0x003E60A0
	private void HDKMHJCEPBK()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(this.JHJDIBFIOFO.position);
		PlayerPrefs.SetString("_L_", iibeekcaahk.ToString());
		PlayerPrefs.SetFloat("WalkInjured", this.FANOBNGKMPH);
	}

	// Token: 0x06008571 RID: 34161 RVA: 0x003E7EE0 File Offset: 0x003E60E0
	private void BLFPCOJDBDE()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString(")"));
		if (!iibeekcaahk.DMPPOEAOIIC())
		{
			this.JHJDIBFIOFO.position = this.DCDIACFPGLF(iibeekcaahk.GEJNEDNGJDD());
		}
		this.FANOBNGKMPH = PlayerPrefs.GetFloat("cntx_teachexp");
		if (this.FANOBNGKMPH < 1832f)
		{
			this.FANOBNGKMPH = 818f;
		}
		this.FANOBNGKMPH = this.BLCIBMKDIML(this.FANOBNGKMPH);
	}

	// Token: 0x06008572 RID: 34162 RVA: 0x003E7F58 File Offset: 0x003E6158
	private void HMEAENGBFKC()
	{
		if (this.isMouseOver)
		{
			this.FANOBNGKMPH = this.KLBNKHPBFEF(this.FANOBNGKMPH + Input.GetAxis("Keeper Jump") * Time.deltaTime * 571f);
		}
		this.JHJDIBFIOFO.sizeDelta = this.GFHKKLHEHEM();
	}

	// Token: 0x06008573 RID: 34163 RVA: 0x003E7FA7 File Offset: 0x003E61A7
	private void EFJDBBDMPMC()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
		this.BNFFBABLCBA = this.JHJDIBFIOFO.sizeDelta;
		this.FPANLBODIEP();
	}

	// Token: 0x06008574 RID: 34164 RVA: 0x003E7FCC File Offset: 0x003E61CC
	private void ABLPIJEAHGC()
	{
		this.CKCCJGEAMJP();
	}

	// Token: 0x06008575 RID: 34165 RVA: 0x003E7FD4 File Offset: 0x003E61D4
	private void MPNLFFJKENI()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString("MotorbikeShootBack"));
		if (!iibeekcaahk.DMPPOEAOIIC())
		{
			this.JHJDIBFIOFO.position = this.IFOMDIKEMDK(iibeekcaahk.GEJNEDNGJDD());
		}
		this.FANOBNGKMPH = PlayerPrefs.GetFloat("WizardNeoBlock");
		if (this.FANOBNGKMPH < 508f)
		{
			this.FANOBNGKMPH = 667f;
		}
		this.FANOBNGKMPH = this.PKLCCGJBNAE(this.FANOBNGKMPH);
	}

	// Token: 0x06008576 RID: 34166 RVA: 0x003E804A File Offset: 0x003E624A
	public void GOEDKMLKFJB(PointerEventData CAKNKPPGGIK)
	{
		this.JHJDIBFIOFO.position = this.EJBACLBFLIB(this.JHJDIBFIOFO.position + new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y));
	}

	// Token: 0x06008577 RID: 34167 RVA: 0x003E7FCC File Offset: 0x003E61CC
	private void IDFGJIHLHDH()
	{
		this.CKCCJGEAMJP();
	}

	// Token: 0x06008578 RID: 34168 RVA: 0x003E8088 File Offset: 0x003E6288
	public void MPDOFAOAIKG(PointerEventData CAKNKPPGGIK)
	{
		this.JHJDIBFIOFO.position = this.PEAGIBKKEJA(this.JHJDIBFIOFO.position + new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y));
	}

	// Token: 0x06008579 RID: 34169 RVA: 0x003E80C6 File Offset: 0x003E62C6
	private float KLBNKHPBFEF(float BFKEKIBPJGG)
	{
		return Mathf.Clamp(BFKEKIBPJGG, 1584f, 962f);
	}

	// Token: 0x0600857A RID: 34170 RVA: 0x003E7E97 File Offset: 0x003E6097
	public void FEIHNEOEDPH()
	{
		this.isMouseOver = false;
	}

	// Token: 0x0600857B RID: 34171 RVA: 0x003E80D8 File Offset: 0x003E62D8
	private void FPANLBODIEP()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString(" point="));
		if (!iibeekcaahk.CHOHHHOLIBJ())
		{
			this.JHJDIBFIOFO.position = this.IFOMDIKEMDK(iibeekcaahk.OHIPPMOMNDB());
		}
		this.FANOBNGKMPH = PlayerPrefs.GetFloat("{0}");
		if (this.FANOBNGKMPH < 691f)
		{
			this.FANOBNGKMPH = 779f;
		}
		this.FANOBNGKMPH = this.PKLCCGJBNAE(this.FANOBNGKMPH);
	}

	// Token: 0x0600857C RID: 34172 RVA: 0x003E814E File Offset: 0x003E634E
	private void OBJCOJEHLBE()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
		this.BNFFBABLCBA = this.JHJDIBFIOFO.sizeDelta;
		this.NAEJGODNJAE();
	}

	// Token: 0x0600857D RID: 34173 RVA: 0x003E8174 File Offset: 0x003E6374
	private void Update()
	{
		if (this.isMouseOver)
		{
			this.FANOBNGKMPH = this.EFOOLFEJLFF(this.FANOBNGKMPH + Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * 16f);
		}
		this.JHJDIBFIOFO.sizeDelta = this.LLGDNDICHCL;
	}

	// Token: 0x0600857E RID: 34174 RVA: 0x003E81C3 File Offset: 0x003E63C3
	public void POFACBHCDJE()
	{
		this.isMouseOver = true;
	}

	// Token: 0x0600857F RID: 34175 RVA: 0x003E81CC File Offset: 0x003E63CC
	public void EAHBNDBPBPJ(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = true;
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("WeaponReload", 1492f);
	}

	// Token: 0x06008580 RID: 34176 RVA: 0x003E81E9 File Offset: 0x003E63E9
	private void OnDestroy()
	{
		this.NBAKJCDDBIP();
	}

	// Token: 0x06008581 RID: 34177 RVA: 0x003E81F1 File Offset: 0x003E63F1
	private float EFOOLFEJLFF(float BFKEKIBPJGG)
	{
		return Mathf.Clamp(BFKEKIBPJGG, 0.5f, 2f);
	}

	// Token: 0x06008582 RID: 34178 RVA: 0x003E7E97 File Offset: 0x003E6097
	public void CKLDMGFIPEC()
	{
		this.isMouseOver = false;
	}

	// Token: 0x06008583 RID: 34179 RVA: 0x003E8204 File Offset: 0x003E6404
	private Vector2 GFHKKLHEHEM()
	{
		float num = this.FANOBNGKMPH;
		if (this.BFHKBOPOFGB)
		{
			num += 745f;
		}
		return this.BNFFBABLCBA * num;
	}

	// Token: 0x06008584 RID: 34180 RVA: 0x003E81C3 File Offset: 0x003E63C3
	public void OnMouseEnter()
	{
		this.isMouseOver = true;
	}

	// Token: 0x06008585 RID: 34181 RVA: 0x003E8234 File Offset: 0x003E6434
	public void NKPGAOJDAAB(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = false;
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB(" ms", 231f);
		this.ECIKPPFMMBC();
	}

	// Token: 0x06008586 RID: 34182 RVA: 0x003E8257 File Offset: 0x003E6457
	public void DOKDHMLHHAO(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = true;
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("val=", 501f);
		this.HDKMHJCEPBK();
	}

	// Token: 0x06008587 RID: 34183 RVA: 0x003E827C File Offset: 0x003E647C
	private Vector3 DCDIACFPGLF(Vector3 DOMBFNEEADM)
	{
		DOMBFNEEADM.x = Mathf.Clamp(DOMBFNEEADM.x, 1759f, (float)(Screen.width - -12));
		DOMBFNEEADM.y = Mathf.Clamp(DOMBFNEEADM.y, 586f, (float)(Screen.height - -90));
		return DOMBFNEEADM;
	}

	// Token: 0x06008589 RID: 34185 RVA: 0x003E82DD File Offset: 0x003E64DD
	private void EHDPACPIBNF()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
		this.BNFFBABLCBA = this.JHJDIBFIOFO.sizeDelta;
		this.OEHDMLCBACP();
	}

	// Token: 0x0600858A RID: 34186 RVA: 0x003E8304 File Offset: 0x003E6504
	private Vector2 PNPEABJGNPC()
	{
		float num = this.FANOBNGKMPH;
		if (this.BFHKBOPOFGB)
		{
			num += 1519f;
		}
		return this.BNFFBABLCBA * num;
	}

	// Token: 0x0600858B RID: 34187 RVA: 0x003E8334 File Offset: 0x003E6534
	private void GANHGLKMOBI()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString("FlyDown"));
		if (!iibeekcaahk.CHOHHHOLIBJ())
		{
			this.JHJDIBFIOFO.position = this.EJBACLBFLIB(iibeekcaahk.MCPNAMDKJOH());
		}
		this.FANOBNGKMPH = PlayerPrefs.GetFloat("WorkerPickaxe2");
		if (this.FANOBNGKMPH < 346f)
		{
			this.FANOBNGKMPH = 792f;
		}
		this.FANOBNGKMPH = this.AOHNKGBALAG(this.FANOBNGKMPH);
	}

	// Token: 0x0600858C RID: 34188 RVA: 0x003E83AC File Offset: 0x003E65AC
	private Vector2 CINOIKACFOE()
	{
		float num = this.FANOBNGKMPH;
		if (this.BFHKBOPOFGB)
		{
			num += 620f;
		}
		return this.BNFFBABLCBA * num;
	}

	// Token: 0x0600858D RID: 34189 RVA: 0x003E83DC File Offset: 0x003E65DC
	private float BLCIBMKDIML(float BFKEKIBPJGG)
	{
		return Mathf.Clamp(BFKEKIBPJGG, 653f, 802f);
	}

	// Token: 0x0600858E RID: 34190 RVA: 0x003E83EE File Offset: 0x003E65EE
	public void CINJMDAMMGI(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = true;
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("", 149f);
	}

	// Token: 0x0600858F RID: 34191 RVA: 0x003E7E22 File Offset: 0x003E6022
	private void CPNOBMNKPNC()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
		this.BNFFBABLCBA = this.JHJDIBFIOFO.sizeDelta;
		this.BLFPCOJDBDE();
	}

	// Token: 0x06008590 RID: 34192 RVA: 0x003E814E File Offset: 0x003E634E
	private void EFCCCKGCOCB()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
		this.BNFFBABLCBA = this.JHJDIBFIOFO.sizeDelta;
		this.NAEJGODNJAE();
	}

	// Token: 0x06008591 RID: 34193 RVA: 0x003E840C File Offset: 0x003E660C
	private Vector3 IFOMDIKEMDK(Vector3 DOMBFNEEADM)
	{
		DOMBFNEEADM.x = Mathf.Clamp(DOMBFNEEADM.x, 0f, (float)(Screen.width - 100));
		DOMBFNEEADM.y = Mathf.Clamp(DOMBFNEEADM.y, 0f, (float)(Screen.height - 100));
		return DOMBFNEEADM;
	}

	// Token: 0x06008592 RID: 34194 RVA: 0x003E845C File Offset: 0x003E665C
	private Vector2 IICNNCPOFNG()
	{
		float num = this.FANOBNGKMPH;
		if (this.BFHKBOPOFGB)
		{
			num += 342f;
		}
		return this.BNFFBABLCBA * num;
	}

	// Token: 0x06008593 RID: 34195 RVA: 0x003E7E97 File Offset: 0x003E6097
	public void PHDCCPGFGJM()
	{
		this.isMouseOver = false;
	}

	// Token: 0x06008594 RID: 34196 RVA: 0x003E848C File Offset: 0x003E668C
	public void BDHEMKOHAEH(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = true;
		FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("IdleStand", 524f);
	}

	// Token: 0x06008595 RID: 34197 RVA: 0x003E84AC File Offset: 0x003E66AC
	private Vector3 AEMBLPEPFMA(Vector3 DOMBFNEEADM)
	{
		DOMBFNEEADM.x = Mathf.Clamp(DOMBFNEEADM.x, 1108f, (float)(Screen.width - 19));
		DOMBFNEEADM.y = Mathf.Clamp(DOMBFNEEADM.y, 45f, (float)(Screen.height - 94));
		return DOMBFNEEADM;
	}

	// Token: 0x06008596 RID: 34198 RVA: 0x003E84FA File Offset: 0x003E66FA
	public void PPHJAEMMMEK(PointerEventData CAKNKPPGGIK)
	{
		this.JHJDIBFIOFO.position = this.DCDIACFPGLF(this.JHJDIBFIOFO.position + new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y));
	}

	// Token: 0x06008597 RID: 34199 RVA: 0x003E8538 File Offset: 0x003E6738
	private void ECIKPPFMMBC()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(this.JHJDIBFIOFO.position);
		PlayerPrefs.SetString("food_draw.ogg", iibeekcaahk.ToString());
		PlayerPrefs.SetFloat("BlackSmithForge", this.FANOBNGKMPH);
	}

	// Token: 0x06008598 RID: 34200 RVA: 0x003E82DD File Offset: 0x003E64DD
	private void GDIMBBBPIHI()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
		this.BNFFBABLCBA = this.JHJDIBFIOFO.sizeDelta;
		this.OEHDMLCBACP();
	}

	// Token: 0x06008599 RID: 34201 RVA: 0x003E8578 File Offset: 0x003E6778
	private void JEEIKMDLICC()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString("UIPCam_pos"));
		if (!iibeekcaahk.DIFFCNOPHBJ)
		{
			this.JHJDIBFIOFO.position = this.IFOMDIKEMDK(iibeekcaahk.FPLDMBJEFEB());
		}
		this.FANOBNGKMPH = PlayerPrefs.GetFloat("UIPCam_size");
		if (this.FANOBNGKMPH < 0.1f)
		{
			this.FANOBNGKMPH = 1f;
		}
		this.FANOBNGKMPH = this.EFOOLFEJLFF(this.FANOBNGKMPH);
	}

	// Token: 0x0600859A RID: 34202 RVA: 0x003E85EE File Offset: 0x003E67EE
	public void DCHPJAOHMBJ(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = true;
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("_WrinkleOcclusionMap2", 619f);
	}

	// Token: 0x0600859B RID: 34203 RVA: 0x003E860C File Offset: 0x003E680C
	private Vector2 EFKIPEEKBPM()
	{
		float num = this.FANOBNGKMPH;
		if (this.BFHKBOPOFGB)
		{
			num += 30f;
		}
		return this.BNFFBABLCBA * num;
	}

	// Token: 0x0600859C RID: 34204 RVA: 0x003E863C File Offset: 0x003E683C
	public void AJMJKFMBEOH(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = true;
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("_WaveScale4", 564f);
		this.GNEOHFHABFA();
	}

	// Token: 0x0600859D RID: 34205 RVA: 0x003E865F File Offset: 0x003E685F
	private void LHJCHPFKGDB()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
		this.BNFFBABLCBA = this.JHJDIBFIOFO.sizeDelta;
		this.GANHGLKMOBI();
	}

	// Token: 0x0600859E RID: 34206 RVA: 0x003E8684 File Offset: 0x003E6884
	public void OBDOIKBIPFP(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = true;
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("bag", 1730f);
	}

	// Token: 0x0600859F RID: 34207 RVA: 0x003E86A1 File Offset: 0x003E68A1
	public void DPJNMNLFOGB(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = false;
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("", 1599f);
	}

	// Token: 0x060085A0 RID: 34208 RVA: 0x003E86BE File Offset: 0x003E68BE
	public void HCCHGAKMHPH(PointerEventData CAKNKPPGGIK)
	{
		this.JHJDIBFIOFO.position = this.MJILOPEPKEK(this.JHJDIBFIOFO.position + new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y));
	}

	// Token: 0x060085A1 RID: 34209 RVA: 0x003E84FA File Offset: 0x003E66FA
	public void IEFJJKFJHBA(PointerEventData CAKNKPPGGIK)
	{
		this.JHJDIBFIOFO.position = this.DCDIACFPGLF(this.JHJDIBFIOFO.position + new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y));
	}

	// Token: 0x060085A2 RID: 34210 RVA: 0x003E86FC File Offset: 0x003E68FC
	private void PJHEGHHOJHJ()
	{
		if (this.isMouseOver)
		{
			this.FANOBNGKMPH = this.KLBNKHPBFEF(this.FANOBNGKMPH + Input.GetAxis("Assets/Weapons/baseLegs.unity3d") * Time.deltaTime * 1855f);
		}
		this.JHJDIBFIOFO.sizeDelta = this.EFKIPEEKBPM();
	}

	// Token: 0x060085A3 RID: 34211 RVA: 0x003E874B File Offset: 0x003E694B
	private void DOHJPDNKALP()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
		this.BNFFBABLCBA = this.JHJDIBFIOFO.sizeDelta;
		this.MPNLFFJKENI();
	}

	// Token: 0x060085A4 RID: 34212 RVA: 0x003E8770 File Offset: 0x003E6970
	public void OnBeginDrag(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = true;
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("drag_onmousedown.wav", 0.3f);
	}

	// Token: 0x060085A5 RID: 34213 RVA: 0x003E8790 File Offset: 0x003E6990
	private Vector2 DMMBEODGCFH()
	{
		float num = this.FANOBNGKMPH;
		if (this.BFHKBOPOFGB)
		{
			num += 1884f;
		}
		return this.BNFFBABLCBA * num;
	}

	// Token: 0x060085A6 RID: 34214 RVA: 0x003E87C0 File Offset: 0x003E69C0
	private void Start()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
		this.BNFFBABLCBA = this.JHJDIBFIOFO.sizeDelta;
		this.JEEIKMDLICC();
	}

	// Token: 0x060085A7 RID: 34215 RVA: 0x003E87E8 File Offset: 0x003E69E8
	private Vector2 EAOEDLFHCBE()
	{
		float num = this.FANOBNGKMPH;
		if (this.BFHKBOPOFGB)
		{
			num += 1700f;
		}
		return this.BNFFBABLCBA * num;
	}

	// Token: 0x060085A8 RID: 34216 RVA: 0x003E8818 File Offset: 0x003E6A18
	private float AOHNKGBALAG(float BFKEKIBPJGG)
	{
		return Mathf.Clamp(BFKEKIBPJGG, 1953f, 1457f);
	}

	// Token: 0x060085A9 RID: 34217 RVA: 0x003E882A File Offset: 0x003E6A2A
	public void OnDrag(PointerEventData CAKNKPPGGIK)
	{
		this.JHJDIBFIOFO.position = this.IFOMDIKEMDK(this.JHJDIBFIOFO.position + new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y));
	}

	// Token: 0x060085AA RID: 34218 RVA: 0x003E8868 File Offset: 0x003E6A68
	public void KDFBCCMIACJ(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = true;
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("__b", 1637f);
	}

	// Token: 0x060085AB RID: 34219 RVA: 0x003E8088 File Offset: 0x003E6288
	public void BLPDMAEDEJM(PointerEventData CAKNKPPGGIK)
	{
		this.JHJDIBFIOFO.position = this.PEAGIBKKEJA(this.JHJDIBFIOFO.position + new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y));
	}

	// Token: 0x060085AC RID: 34220 RVA: 0x003E7E97 File Offset: 0x003E6097
	public void NDAEJANHIOL()
	{
		this.isMouseOver = false;
	}

	// Token: 0x060085AD RID: 34221 RVA: 0x003E8888 File Offset: 0x003E6A88
	private Vector2 LCLPOAKFLHH()
	{
		float num = this.FANOBNGKMPH;
		if (this.BFHKBOPOFGB)
		{
			num += 202f;
		}
		return this.BNFFBABLCBA * num;
	}

	// Token: 0x060085AE RID: 34222 RVA: 0x003E88B8 File Offset: 0x003E6AB8
	public void GECNGFFJHFI(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = true;
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("DISTANCE_CUTOFF_ON", 1820f);
		this.GNEOHFHABFA();
	}

	// Token: 0x060085AF RID: 34223 RVA: 0x003E81C3 File Offset: 0x003E63C3
	public void GABDODBFGGA()
	{
		this.isMouseOver = true;
	}

	// Token: 0x060085B0 RID: 34224 RVA: 0x003E88DC File Offset: 0x003E6ADC
	private void OEHDMLCBACP()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString("fider_Empty.ogg"));
		if (!iibeekcaahk.DIFFCNOPHBJ)
		{
			this.JHJDIBFIOFO.position = this.IFOMDIKEMDK(iibeekcaahk.GEJNEDNGJDD());
		}
		this.FANOBNGKMPH = PlayerPrefs.GetFloat("");
		if (this.FANOBNGKMPH < 159f)
		{
			this.FANOBNGKMPH = 1084f;
		}
		this.FANOBNGKMPH = this.PKLCCGJBNAE(this.FANOBNGKMPH);
	}

	// Token: 0x060085B1 RID: 34225 RVA: 0x003E804A File Offset: 0x003E624A
	public void DNDFCJHKEFF(PointerEventData CAKNKPPGGIK)
	{
		this.JHJDIBFIOFO.position = this.EJBACLBFLIB(this.JHJDIBFIOFO.position + new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y));
	}

	// Token: 0x060085B2 RID: 34226 RVA: 0x003E8954 File Offset: 0x003E6B54
	private Vector3 DPCDFBOIGEE(Vector3 DOMBFNEEADM)
	{
		DOMBFNEEADM.x = Mathf.Clamp(DOMBFNEEADM.x, 710f, (float)(Screen.width - 71));
		DOMBFNEEADM.y = Mathf.Clamp(DOMBFNEEADM.y, 374f, (float)(Screen.height - 4));
		return DOMBFNEEADM;
	}

	// Token: 0x060085B3 RID: 34227 RVA: 0x003E89A2 File Offset: 0x003E6BA2
	public void KNGKEGBKLLM(PointerEventData CAKNKPPGGIK)
	{
		this.JHJDIBFIOFO.position = this.NGMAMANKOKC(this.JHJDIBFIOFO.position + new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y));
	}

	// Token: 0x060085B4 RID: 34228 RVA: 0x003E81C3 File Offset: 0x003E63C3
	public void BALEEJIEBIC()
	{
		this.isMouseOver = true;
	}

	// Token: 0x060085B5 RID: 34229 RVA: 0x003E81E9 File Offset: 0x003E63E9
	private void PGCPOCKJFGP()
	{
		this.NBAKJCDDBIP();
	}

	// Token: 0x060085B6 RID: 34230 RVA: 0x003E89E0 File Offset: 0x003E6BE0
	private void GJLNFHFCAEG()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(this.JHJDIBFIOFO.position);
		PlayerPrefs.SetString("FishbragContainer", iibeekcaahk.ToString());
		PlayerPrefs.SetFloat("Zone ", this.FANOBNGKMPH);
	}

	// Token: 0x060085B7 RID: 34231 RVA: 0x003E8A1E File Offset: 0x003E6C1E
	private void CGMBLNCHALB()
	{
		this.GJLNFHFCAEG();
	}

	// Token: 0x060085B8 RID: 34232 RVA: 0x003E8A28 File Offset: 0x003E6C28
	private Vector2 AOPHKABNMEM()
	{
		float num = this.FANOBNGKMPH;
		if (this.BFHKBOPOFGB)
		{
			num += 1250f;
		}
		return this.BNFFBABLCBA * num;
	}

	// Token: 0x060085B9 RID: 34233 RVA: 0x003E87C0 File Offset: 0x003E69C0
	private void ELFLOPJDAKK()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
		this.BNFFBABLCBA = this.JHJDIBFIOFO.sizeDelta;
		this.JEEIKMDLICC();
	}

	// Token: 0x060085BA RID: 34234 RVA: 0x003E8A58 File Offset: 0x003E6C58
	private void JOHDLNOKCOK()
	{
		if (this.isMouseOver)
		{
			this.FANOBNGKMPH = this.PKLCCGJBNAE(this.FANOBNGKMPH + Input.GetAxis(": ") * Time.deltaTime * 653f);
		}
		this.JHJDIBFIOFO.sizeDelta = this.DMMBEODGCFH();
	}

	// Token: 0x060085BB RID: 34235 RVA: 0x003E8AA8 File Offset: 0x003E6CA8
	private void DMNNDFDENAB()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(this.JHJDIBFIOFO.position);
		PlayerPrefs.SetString("level", iibeekcaahk.ToString());
		PlayerPrefs.SetFloat("cht_msg10", this.FANOBNGKMPH);
	}

	// Token: 0x060085BC RID: 34236 RVA: 0x003E8AE6 File Offset: 0x003E6CE6
	private float INOHOANKGNI(float BFKEKIBPJGG)
	{
		return Mathf.Clamp(BFKEKIBPJGG, 1f, 297f);
	}

	// Token: 0x060085BD RID: 34237 RVA: 0x003E8AF8 File Offset: 0x003E6CF8
	public void DEEMGCLKOPD(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = false;
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("#000000", 1943f);
		this.ECIKPPFMMBC();
	}

	// Token: 0x060085BE RID: 34238 RVA: 0x003E8B1C File Offset: 0x003E6D1C
	private void AIILFFCEKKM()
	{
		if (this.isMouseOver)
		{
			this.FANOBNGKMPH = this.INOHOANKGNI(this.FANOBNGKMPH + Input.GetAxis("Active Process ") * Time.deltaTime * 1695f);
		}
		this.JHJDIBFIOFO.sizeDelta = this.EFKIPEEKBPM();
	}

	// Token: 0x060085BF RID: 34239 RVA: 0x003E814E File Offset: 0x003E634E
	private void MODJFGGIAHD()
	{
		this.JHJDIBFIOFO = base.GetComponent<RectTransform>();
		this.BNFFBABLCBA = this.JHJDIBFIOFO.sizeDelta;
		this.NAEJGODNJAE();
	}

	// Token: 0x060085C0 RID: 34240 RVA: 0x003E8B6B File Offset: 0x003E6D6B
	public void JOCAMLHENHC(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = false;
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("OfficeSittingReading", 778f);
	}

	// Token: 0x060085C1 RID: 34241 RVA: 0x003E81C3 File Offset: 0x003E63C3
	public void ANJJDOGNEGM()
	{
		this.isMouseOver = true;
	}

	// Token: 0x060085C2 RID: 34242 RVA: 0x003E8B88 File Offset: 0x003E6D88
	public void NPKBLLEDLAL(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = false;
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("---", 1914f);
	}

	// Token: 0x060085C3 RID: 34243 RVA: 0x003E8BA8 File Offset: 0x003E6DA8
	private void NMMGHFDLNOE()
	{
		if (this.isMouseOver)
		{
			this.FANOBNGKMPH = this.EMEACEKNHFA(this.FANOBNGKMPH + Input.GetAxis("Criticals") * Time.deltaTime * 1110f);
		}
		this.JHJDIBFIOFO.sizeDelta = this.IICNNCPOFNG();
	}

	// Token: 0x060085C4 RID: 34244 RVA: 0x003E8BF7 File Offset: 0x003E6DF7
	private void BCNGPIGDICE()
	{
		this.MNEFLCPJPPM();
	}

	// Token: 0x060085C5 RID: 34245 RVA: 0x003E8BFF File Offset: 0x003E6DFF
	public void GNGCJFCLAFD(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = true;
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("PLANE_REFLECTION", 1711f);
	}

	// Token: 0x060085C6 RID: 34246 RVA: 0x003E8C1C File Offset: 0x003E6E1C
	private void AMDMCKIFBPA()
	{
		if (this.isMouseOver)
		{
			this.FANOBNGKMPH = this.AOHNKGBALAG(this.FANOBNGKMPH + Input.GetAxis("IceHockeyGoalieSave2") * Time.deltaTime * 1767f);
		}
		this.JHJDIBFIOFO.sizeDelta = this.CINOIKACFOE();
	}

	// Token: 0x060085C7 RID: 34247 RVA: 0x003E89A2 File Offset: 0x003E6BA2
	public void JMMPOKPNDFD(PointerEventData CAKNKPPGGIK)
	{
		this.JHJDIBFIOFO.position = this.NGMAMANKOKC(this.JHJDIBFIOFO.position + new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y));
	}

	// Token: 0x060085C8 RID: 34248 RVA: 0x003E8C6C File Offset: 0x003E6E6C
	private Vector3 EJBACLBFLIB(Vector3 DOMBFNEEADM)
	{
		DOMBFNEEADM.x = Mathf.Clamp(DOMBFNEEADM.x, 625f, (float)(Screen.width - -1));
		DOMBFNEEADM.y = Mathf.Clamp(DOMBFNEEADM.y, 1664f, (float)(Screen.height - -16));
		return DOMBFNEEADM;
	}

	// Token: 0x060085C9 RID: 34249 RVA: 0x003E8CBC File Offset: 0x003E6EBC
	private void GNEOHFHABFA()
	{
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(this.JHJDIBFIOFO.position);
		PlayerPrefs.SetString("_History2ChromaTex", iibeekcaahk.ToString());
		PlayerPrefs.SetFloat("", this.FANOBNGKMPH);
	}

	// Token: 0x060085CA RID: 34250 RVA: 0x003E8CFC File Offset: 0x003E6EFC
	private Vector2 LJNEEHCJBDF()
	{
		float num = this.FANOBNGKMPH;
		if (this.BFHKBOPOFGB)
		{
			num += 729f;
		}
		return this.BNFFBABLCBA * num;
	}

	// Token: 0x060085CB RID: 34251 RVA: 0x003E8D2C File Offset: 0x003E6F2C
	private Vector2 IFJEMGPKCJD()
	{
		float num = this.FANOBNGKMPH;
		if (this.BFHKBOPOFGB)
		{
			num += 329f;
		}
		return this.BNFFBABLCBA * num;
	}

	// Token: 0x060085CC RID: 34252 RVA: 0x003E8D5C File Offset: 0x003E6F5C
	private float PKLCCGJBNAE(float BFKEKIBPJGG)
	{
		return Mathf.Clamp(BFKEKIBPJGG, 1026f, 701f);
	}

	// Token: 0x060085CD RID: 34253 RVA: 0x003E8D70 File Offset: 0x003E6F70
	private void BBFCMCAFOMH()
	{
		if (this.isMouseOver)
		{
			this.FANOBNGKMPH = this.KLBNKHPBFEF(this.FANOBNGKMPH + Input.GetAxis("foot") * Time.deltaTime * 95f);
		}
		this.JHJDIBFIOFO.sizeDelta = this.GFHKKLHEHEM();
	}

	// Token: 0x060085CE RID: 34254 RVA: 0x003E81C3 File Offset: 0x003E63C3
	public void FJNHEPJIACH()
	{
		this.isMouseOver = true;
	}

	// Token: 0x060085CF RID: 34255 RVA: 0x003E8DC0 File Offset: 0x003E6FC0
	private Vector3 OMHHDIACACL(Vector3 DOMBFNEEADM)
	{
		DOMBFNEEADM.x = Mathf.Clamp(DOMBFNEEADM.x, 610f, (float)(Screen.width - 48));
		DOMBFNEEADM.y = Mathf.Clamp(DOMBFNEEADM.y, 1354f, (float)(Screen.height - 14));
		return DOMBFNEEADM;
	}

	// Token: 0x060085D0 RID: 34256 RVA: 0x003E804A File Offset: 0x003E624A
	public void HBGHGBEGMGJ(PointerEventData CAKNKPPGGIK)
	{
		this.JHJDIBFIOFO.position = this.EJBACLBFLIB(this.JHJDIBFIOFO.position + new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y));
	}

	// Token: 0x060085D1 RID: 34257 RVA: 0x003E8E0E File Offset: 0x003E700E
	private void NLHMPJAIJKD()
	{
		this.HDKMHJCEPBK();
	}

	// Token: 0x060085D2 RID: 34258 RVA: 0x003E8E16 File Offset: 0x003E7016
	private float EMEACEKNHFA(float BFKEKIBPJGG)
	{
		return Mathf.Clamp(BFKEKIBPJGG, 354f, 572f);
	}

	// Token: 0x060085D3 RID: 34259 RVA: 0x003E8BF7 File Offset: 0x003E6DF7
	private void DNFMEMNJADK()
	{
		this.MNEFLCPJPPM();
	}

	// Token: 0x060085D4 RID: 34260 RVA: 0x003E882A File Offset: 0x003E6A2A
	public void MCEEFOPHNLF(PointerEventData CAKNKPPGGIK)
	{
		this.JHJDIBFIOFO.position = this.IFOMDIKEMDK(this.JHJDIBFIOFO.position + new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y));
	}

	// Token: 0x060085D5 RID: 34261 RVA: 0x003E8E28 File Offset: 0x003E7028
	public void HEDODHKKJGK(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = false;
		FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("BowReady2", 1048f);
	}

	// Token: 0x060085D6 RID: 34262 RVA: 0x003E8E45 File Offset: 0x003E7045
	public void OnEndDrag(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = false;
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("drag_onmouseup.wav", 0.3f);
		this.NBAKJCDDBIP();
	}

	// Token: 0x060085D7 RID: 34263 RVA: 0x003E7E97 File Offset: 0x003E6097
	public void BPNLAJNEJEH()
	{
		this.isMouseOver = false;
	}

	// Token: 0x060085D8 RID: 34264 RVA: 0x003E8E68 File Offset: 0x003E7068
	private Vector3 NGMAMANKOKC(Vector3 DOMBFNEEADM)
	{
		DOMBFNEEADM.x = Mathf.Clamp(DOMBFNEEADM.x, 1134f, (float)(Screen.width - 33));
		DOMBFNEEADM.y = Mathf.Clamp(DOMBFNEEADM.y, 622f, (float)(Screen.height - -46));
		return DOMBFNEEADM;
	}

	// Token: 0x060085D9 RID: 34265 RVA: 0x003E7E97 File Offset: 0x003E6097
	public void IJPHELGJBGF()
	{
		this.isMouseOver = false;
	}

	// Token: 0x060085DA RID: 34266 RVA: 0x003E81E9 File Offset: 0x003E63E9
	private void GPKHKLEINDH()
	{
		this.NBAKJCDDBIP();
	}

	// Token: 0x060085DB RID: 34267 RVA: 0x003E8EB6 File Offset: 0x003E70B6
	public void LMDAOCHHAKM(PointerEventData CAKNKPPGGIK)
	{
		this.BFHKBOPOFGB = true;
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("pempty", 1979f);
		this.ECIKPPFMMBC();
	}

	// Token: 0x040012C0 RID: 4800
	private RectTransform JHJDIBFIOFO;

	// Token: 0x040012C1 RID: 4801
	private Vector2 BNFFBABLCBA;

	// Token: 0x040012C2 RID: 4802
	private float FANOBNGKMPH = 1f;

	// Token: 0x040012C3 RID: 4803
	private bool BFHKBOPOFGB;

	// Token: 0x040012C4 RID: 4804
	public bool isMouseOver;
}
