using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200017D RID: 381
public class MessageCloud : MonoBehaviour
{
	// Token: 0x0600538D RID: 21389 RVA: 0x00274D09 File Offset: 0x00272F09
	public void GOBOMLHFLHF(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x0600538E RID: 21390 RVA: 0x00274D09 File Offset: 0x00272F09
	public void PGFLAKAFLGK(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x0600538F RID: 21391 RVA: 0x00274D09 File Offset: 0x00272F09
	public void MPFCJIFDLMI(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x06005390 RID: 21392 RVA: 0x00274D1C File Offset: 0x00272F1C
	public void PKGDABAHNIA(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.IKFCPNFCBLL(true);
	}

	// Token: 0x06005391 RID: 21393 RVA: 0x00274D09 File Offset: 0x00272F09
	public void DFOMELHMHCB(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x06005392 RID: 21394 RVA: 0x00274D09 File Offset: 0x00272F09
	public void GAMJHLBLOMM(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x06005393 RID: 21395 RVA: 0x00274D55 File Offset: 0x00272F55
	private void ACEODGIJKFH()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.DFOMELHMHCB(false);
		}
	}

	// Token: 0x06005394 RID: 21396 RVA: 0x00274D6B File Offset: 0x00272F6B
	private void Update()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.isVisible(false);
		}
	}

	// Token: 0x06005395 RID: 21397 RVA: 0x00274D81 File Offset: 0x00272F81
	private void IDMCOLDDNCF()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.FFFIMBNOFOO(false);
		}
	}

	// Token: 0x06005396 RID: 21398 RVA: 0x00274D55 File Offset: 0x00272F55
	private void KFNOEOIIBOI()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.DFOMELHMHCB(false);
		}
	}

	// Token: 0x06005397 RID: 21399 RVA: 0x00274D97 File Offset: 0x00272F97
	private void HDGNIHBIEDG()
	{
		this.OBCIOGHPILD(true);
	}

	// Token: 0x06005398 RID: 21400 RVA: 0x00274D09 File Offset: 0x00272F09
	public void NFIMJKLBLKO(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x06005399 RID: 21401 RVA: 0x00274D09 File Offset: 0x00272F09
	public void LNAFOGDDCIA(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x0600539A RID: 21402 RVA: 0x00274DA0 File Offset: 0x00272FA0
	public void LBPOFKHAKIC(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.GIHNENFJDCF(true);
	}

	// Token: 0x0600539B RID: 21403 RVA: 0x00274DD9 File Offset: 0x00272FD9
	public void NABPFMGONMN(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.OBCIOGHPILD(false);
	}

	// Token: 0x0600539C RID: 21404 RVA: 0x00274E12 File Offset: 0x00273012
	private void EHDFKHHOHAD()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.EBGBLLIDFOP(false);
		}
	}

	// Token: 0x0600539D RID: 21405 RVA: 0x00274D09 File Offset: 0x00272F09
	public void CJDOHLKDFPF(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x0600539E RID: 21406 RVA: 0x00274E28 File Offset: 0x00273028
	public void ILJMAJNLLGA(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.LBJCPDDCLJL(false);
	}

	// Token: 0x0600539F RID: 21407 RVA: 0x00274E61 File Offset: 0x00273061
	private void IGEICBNMPAD()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.FFFIMBNOFOO(true);
		}
	}

	// Token: 0x060053A0 RID: 21408 RVA: 0x00274E77 File Offset: 0x00273077
	private void OHKHOAKCENL()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.LBJCPDDCLJL(true);
		}
	}

	// Token: 0x060053A1 RID: 21409 RVA: 0x00274D09 File Offset: 0x00272F09
	public void NMOPKJFCEOC(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053A2 RID: 21410 RVA: 0x00274E8D File Offset: 0x0027308D
	public void IHDONOKJMGA(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.CJBICLEAPKG(false);
	}

	// Token: 0x060053A3 RID: 21411 RVA: 0x00274EC6 File Offset: 0x002730C6
	private void EKCKBDKEAKO()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.DKFKNEHFAPG(false);
		}
	}

	// Token: 0x060053A4 RID: 21412 RVA: 0x00274EDC File Offset: 0x002730DC
	public void OEMJOCLJMGC(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.NAJLCFLNIBJ(false);
	}

	// Token: 0x060053A5 RID: 21413 RVA: 0x00274F15 File Offset: 0x00273115
	private void DEGCCLNOEKJ()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.OBCIOGHPILD(false);
		}
	}

	// Token: 0x060053A6 RID: 21414 RVA: 0x00274D09 File Offset: 0x00272F09
	public void FFFIMBNOFOO(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053A7 RID: 21415 RVA: 0x00274D09 File Offset: 0x00272F09
	public void GIHNENFJDCF(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053A8 RID: 21416 RVA: 0x00274F2B File Offset: 0x0027312B
	private void LIOCDEICIFD()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.KCBGLMAKPIA(false);
		}
	}

	// Token: 0x060053A9 RID: 21417 RVA: 0x00274D09 File Offset: 0x00272F09
	public void CBGPOBFFCAI(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053AA RID: 21418 RVA: 0x00274F41 File Offset: 0x00273141
	public void LHOKFMGJEKM(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.isVisible(false);
	}

	// Token: 0x060053AB RID: 21419 RVA: 0x00274D09 File Offset: 0x00272F09
	public void DHCMOFMACJB(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053AC RID: 21420 RVA: 0x00274F7A File Offset: 0x0027317A
	private void GMOACLEBHAM()
	{
		this.DFJCPEOFKAG(false);
	}

	// Token: 0x060053AD RID: 21421 RVA: 0x00274D09 File Offset: 0x00272F09
	public void DKFKNEHFAPG(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053AE RID: 21422 RVA: 0x00274F83 File Offset: 0x00273183
	public void FCCACMPNHBM(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.BKMEJJIBJIN(false);
	}

	// Token: 0x060053AF RID: 21423 RVA: 0x00274FBC File Offset: 0x002731BC
	private void FNBGGJJLIGG()
	{
		this.GOBOMLHFLHF(false);
	}

	// Token: 0x060053B0 RID: 21424 RVA: 0x00274FC5 File Offset: 0x002731C5
	public void IIIMLJLFJFE(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.GAMJHLBLOMM(false);
	}

	// Token: 0x060053B1 RID: 21425 RVA: 0x00274FFE File Offset: 0x002731FE
	public void FGJJPFIANDL(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.LNAFOGDDCIA(false);
	}

	// Token: 0x060053B2 RID: 21426 RVA: 0x00275037 File Offset: 0x00273237
	public void DKBJJICLONK(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.DLNCCKGPEJI(true);
	}

	// Token: 0x060053B3 RID: 21427 RVA: 0x00274D09 File Offset: 0x00272F09
	public void AKKCJDDECGB(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053B4 RID: 21428 RVA: 0x00275070 File Offset: 0x00273270
	public void ANDFCAMCOGG(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.AKKCJDDECGB(true);
	}

	// Token: 0x060053B5 RID: 21429 RVA: 0x002750A9 File Offset: 0x002732A9
	private void LHJCHPFKGDB()
	{
		this.EBGBLLIDFOP(false);
	}

	// Token: 0x060053B6 RID: 21430 RVA: 0x00274D09 File Offset: 0x00272F09
	public void BDJPHDGOAEI(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053B7 RID: 21431 RVA: 0x002750B2 File Offset: 0x002732B2
	private void DGGMJCMLLED()
	{
		this.LBJCPDDCLJL(true);
	}

	// Token: 0x060053B8 RID: 21432 RVA: 0x002750BB File Offset: 0x002732BB
	private void BAIKCLKJPAA()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.GAMJHLBLOMM(true);
		}
	}

	// Token: 0x060053B9 RID: 21433 RVA: 0x002750D1 File Offset: 0x002732D1
	public void HMEDAMLCBFO(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.AKKCJDDECGB(false);
	}

	// Token: 0x060053BA RID: 21434 RVA: 0x0027510A File Offset: 0x0027330A
	private void FPLNDDMFFKG()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.BKMEJJIBJIN(true);
		}
	}

	// Token: 0x060053BB RID: 21435 RVA: 0x00274D09 File Offset: 0x00272F09
	public void LBJCPDDCLJL(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053BC RID: 21436 RVA: 0x00274D09 File Offset: 0x00272F09
	public void KDGOPCIJGBI(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053BD RID: 21437 RVA: 0x00275120 File Offset: 0x00273320
	private void JLFBDOPFDDJ()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.NAJLCFLNIBJ(false);
		}
	}

	// Token: 0x060053BE RID: 21438 RVA: 0x00275136 File Offset: 0x00273336
	public void LFCDPMNKBNP(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.LNAFOGDDCIA(true);
	}

	// Token: 0x060053BF RID: 21439 RVA: 0x0027516F File Offset: 0x0027336F
	private void PNJHMJNFPLP()
	{
		this.DLNCCKGPEJI(false);
	}

	// Token: 0x060053C0 RID: 21440 RVA: 0x00275178 File Offset: 0x00273378
	public void NNMFAJAKCLH(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.EAFEGPHGOOG(true);
	}

	// Token: 0x060053C1 RID: 21441 RVA: 0x002751B1 File Offset: 0x002733B1
	public void HPCJBBJLAKL(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.CBGPOBFFCAI(true);
	}

	// Token: 0x060053C2 RID: 21442 RVA: 0x002751EA File Offset: 0x002733EA
	private void Start()
	{
		this.isVisible(false);
	}

	// Token: 0x060053C3 RID: 21443 RVA: 0x002751F3 File Offset: 0x002733F3
	private void EGAEDOHFAJE()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.ONLGBNBOHOL(true);
		}
	}

	// Token: 0x060053C4 RID: 21444 RVA: 0x00275209 File Offset: 0x00273409
	private void AODJMLNLHNA()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.LNAFOGDDCIA(true);
		}
	}

	// Token: 0x060053C5 RID: 21445 RVA: 0x0027521F File Offset: 0x0027341F
	private void BJCONKIIOBM()
	{
		this.LBJCPDDCLJL(false);
	}

	// Token: 0x060053C6 RID: 21446 RVA: 0x00275228 File Offset: 0x00273428
	private void JHFAHBIIJDC()
	{
		this.CJDOHLKDFPF(true);
	}

	// Token: 0x060053C7 RID: 21447 RVA: 0x00275231 File Offset: 0x00273431
	private void KECMAHFJBCD()
	{
		this.OBCIOGHPILD(false);
	}

	// Token: 0x060053C8 RID: 21448 RVA: 0x00274D09 File Offset: 0x00272F09
	public void CKPGKEOIDNF(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053C9 RID: 21449 RVA: 0x0027523A File Offset: 0x0027343A
	private void BBFPILBIMKC()
	{
		this.MPFCJIFDLMI(true);
	}

	// Token: 0x060053CA RID: 21450 RVA: 0x00275243 File Offset: 0x00273443
	private void IIHNDJOIMAH()
	{
		this.DHCMOFMACJB(false);
	}

	// Token: 0x060053CB RID: 21451 RVA: 0x0027524C File Offset: 0x0027344C
	private void FODDAMMNECI()
	{
		this.NAJLCFLNIBJ(true);
	}

	// Token: 0x060053CC RID: 21452 RVA: 0x00275255 File Offset: 0x00273455
	private void PFPPDNHLCCA()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.HBCJEELNAIP(false);
		}
	}

	// Token: 0x060053CD RID: 21453 RVA: 0x002751F3 File Offset: 0x002733F3
	private void ACLNFGPOHBF()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.ONLGBNBOHOL(true);
		}
	}

	// Token: 0x060053CE RID: 21454 RVA: 0x00274D09 File Offset: 0x00272F09
	public void KONEJCNGFBH(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053CF RID: 21455 RVA: 0x00274D09 File Offset: 0x00272F09
	public void BKMEJJIBJIN(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053D0 RID: 21456 RVA: 0x00274D09 File Offset: 0x00272F09
	public void MMNBKBHPJJB(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053D1 RID: 21457 RVA: 0x00274D09 File Offset: 0x00272F09
	public void EAFEGPHGOOG(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053D2 RID: 21458 RVA: 0x0027526B File Offset: 0x0027346B
	private void HDFCIACDDEK()
	{
		this.CKPGKEOIDNF(true);
	}

	// Token: 0x060053D3 RID: 21459 RVA: 0x00275274 File Offset: 0x00273474
	public void GADEEHLPOPH(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.MPFCJIFDLMI(false);
	}

	// Token: 0x060053D4 RID: 21460 RVA: 0x00274D09 File Offset: 0x00272F09
	public void LFKLLHAEPLA(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053D5 RID: 21461 RVA: 0x002752AD File Offset: 0x002734AD
	private void CPNOBMNKPNC()
	{
		this.GIHNENFJDCF(false);
	}

	// Token: 0x060053D6 RID: 21462 RVA: 0x00274D09 File Offset: 0x00272F09
	public void HBCJEELNAIP(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053D7 RID: 21463 RVA: 0x00274D09 File Offset: 0x00272F09
	public void EBLMLILBFPO(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053D8 RID: 21464 RVA: 0x00274D09 File Offset: 0x00272F09
	public void NAJLCFLNIBJ(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053D9 RID: 21465 RVA: 0x00275243 File Offset: 0x00273443
	private void FPLHODJCJDO()
	{
		this.DHCMOFMACJB(false);
	}

	// Token: 0x060053DA RID: 21466 RVA: 0x002752B6 File Offset: 0x002734B6
	private void KEBDEJIAODF()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.BDJPHDGOAEI(true);
		}
	}

	// Token: 0x060053DB RID: 21467 RVA: 0x002752CC File Offset: 0x002734CC
	public void JGEAKKPLMCE(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.AJNDNNDEGDI(true);
	}

	// Token: 0x060053DC RID: 21468 RVA: 0x00275305 File Offset: 0x00273505
	public void PIKOOPPMNED(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.EAFEGPHGOOG(false);
	}

	// Token: 0x060053DD RID: 21469 RVA: 0x0027533E File Offset: 0x0027353E
	private void CKGPEFOKKNL()
	{
		this.GKHPLIMDAGB(false);
	}

	// Token: 0x060053DE RID: 21470 RVA: 0x00275347 File Offset: 0x00273547
	private void AOCDDBNBADJ()
	{
		this.NFIMJKLBLKO(false);
	}

	// Token: 0x060053DF RID: 21471 RVA: 0x00275274 File Offset: 0x00273474
	public void GODEHLCGIKL(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.MPFCJIFDLMI(false);
	}

	// Token: 0x060053E0 RID: 21472 RVA: 0x00274D09 File Offset: 0x00272F09
	public void DFJCPEOFKAG(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053E1 RID: 21473 RVA: 0x00274FFE File Offset: 0x002731FE
	public void GEKCBDAPBJA(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.LNAFOGDDCIA(false);
	}

	// Token: 0x060053E2 RID: 21474 RVA: 0x00275350 File Offset: 0x00273550
	public void LLJNLBAHJOI(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.KBAOCEDAFOM(false);
	}

	// Token: 0x060053E3 RID: 21475 RVA: 0x00275389 File Offset: 0x00273589
	private void GCLBNFCBMLL()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.DLNCCKGPEJI(false);
		}
	}

	// Token: 0x060053E4 RID: 21476 RVA: 0x0027539F File Offset: 0x0027359F
	private void ADLHNBEDHMJ()
	{
		this.PCAEJBLNAAC(true);
	}

	// Token: 0x060053E5 RID: 21477 RVA: 0x00274D09 File Offset: 0x00272F09
	public void DLNCCKGPEJI(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053E6 RID: 21478 RVA: 0x002753A8 File Offset: 0x002735A8
	public void KGIBHBIHNHF(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.DKFKNEHFAPG(true);
	}

	// Token: 0x060053E7 RID: 21479 RVA: 0x002753E1 File Offset: 0x002735E1
	private void EGDBNKCJOCD()
	{
		this.IKFCPNFCBLL(true);
	}

	// Token: 0x060053E8 RID: 21480 RVA: 0x002753EA File Offset: 0x002735EA
	public void ELHCCHAMNEK(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.GAMJHLBLOMM(true);
	}

	// Token: 0x060053E9 RID: 21481 RVA: 0x00275423 File Offset: 0x00273623
	public void showMessage(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.isVisible(true);
	}

	// Token: 0x060053EA RID: 21482 RVA: 0x00274D09 File Offset: 0x00272F09
	public void IKFCPNFCBLL(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053EB RID: 21483 RVA: 0x00274D09 File Offset: 0x00272F09
	public void KCBGLMAKPIA(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053EC RID: 21484 RVA: 0x0027545C File Offset: 0x0027365C
	private void LHKGDKLABAA()
	{
		this.NAJLCFLNIBJ(false);
	}

	// Token: 0x060053ED RID: 21485 RVA: 0x00275465 File Offset: 0x00273665
	private void OKMAHGAAMHA()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.KDGOPCIJGBI(false);
		}
	}

	// Token: 0x060053EE RID: 21486 RVA: 0x0027547B File Offset: 0x0027367B
	public void AGINDNAPGDD(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.KCBGLMAKPIA(false);
	}

	// Token: 0x060053EF RID: 21487 RVA: 0x002754B4 File Offset: 0x002736B4
	private void APPLKMOGAMJ()
	{
		this.DFOMELHMHCB(true);
	}

	// Token: 0x060053F0 RID: 21488 RVA: 0x002754BD File Offset: 0x002736BD
	private void LGPJEFMIIOL()
	{
		this.MMNBKBHPJJB(true);
	}

	// Token: 0x060053F1 RID: 21489 RVA: 0x002754C6 File Offset: 0x002736C6
	private void DOHJPDNKALP()
	{
		this.IFLBAMKEHEL(false);
	}

	// Token: 0x060053F2 RID: 21490 RVA: 0x002754CF File Offset: 0x002736CF
	private void PBFKCKCHEAC()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.AKKCJDDECGB(true);
		}
	}

	// Token: 0x060053F3 RID: 21491 RVA: 0x00274D09 File Offset: 0x00272F09
	public void CJBICLEAPKG(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053F4 RID: 21492 RVA: 0x00274F83 File Offset: 0x00273183
	public void EFECMPMFNIL(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.BKMEJJIBJIN(false);
	}

	// Token: 0x060053F5 RID: 21493 RVA: 0x002754E5 File Offset: 0x002736E5
	private void BHFMGBNIAMC()
	{
		this.NMOPKJFCEOC(true);
	}

	// Token: 0x060053F6 RID: 21494 RVA: 0x002754EE File Offset: 0x002736EE
	private void EFJDBBDMPMC()
	{
		this.FFFIMBNOFOO(true);
	}

	// Token: 0x060053F7 RID: 21495 RVA: 0x002754F7 File Offset: 0x002736F7
	public void OJNJMNGMCOB(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.ONLGBNBOHOL(false);
	}

	// Token: 0x060053F8 RID: 21496 RVA: 0x00275530 File Offset: 0x00273730
	private void OLGDMBDGLAN()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.GKODKDHCJBE(true);
		}
	}

	// Token: 0x060053F9 RID: 21497 RVA: 0x00275546 File Offset: 0x00273746
	public void BGGGEEPEMLM(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.MMNBKBHPJJB(false);
	}

	// Token: 0x060053FA RID: 21498 RVA: 0x0027557F File Offset: 0x0027377F
	private void MPLCAGFGEBO()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.GKHPLIMDAGB(true);
		}
	}

	// Token: 0x060053FB RID: 21499 RVA: 0x002752B6 File Offset: 0x002734B6
	private void MIFLHGMPLJD()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.BDJPHDGOAEI(true);
		}
	}

	// Token: 0x060053FC RID: 21500 RVA: 0x00274D09 File Offset: 0x00272F09
	public void GKODKDHCJBE(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053FD RID: 21501 RVA: 0x00274D09 File Offset: 0x00272F09
	public void PCAEJBLNAAC(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x060053FE RID: 21502 RVA: 0x00275595 File Offset: 0x00273795
	private void BBFCMCAFOMH()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.KONEJCNGFBH(false);
		}
	}

	// Token: 0x060053FF RID: 21503 RVA: 0x00274D09 File Offset: 0x00272F09
	public void OBCIOGHPILD(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x06005400 RID: 21504 RVA: 0x00274D09 File Offset: 0x00272F09
	public void IFLBAMKEHEL(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x06005401 RID: 21505 RVA: 0x002755AB File Offset: 0x002737AB
	public void IHPIMCJJGPO(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.GOBOMLHFLHF(true);
	}

	// Token: 0x06005402 RID: 21506 RVA: 0x002755E4 File Offset: 0x002737E4
	private void KJJNMNKPNCH()
	{
		this.NFIMJKLBLKO(true);
	}

	// Token: 0x06005403 RID: 21507 RVA: 0x002755ED File Offset: 0x002737ED
	public void NJHKBEBLJOE(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.IFLBAMKEHEL(false);
	}

	// Token: 0x06005404 RID: 21508 RVA: 0x00275350 File Offset: 0x00273550
	public void IBPAICCCMHB(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.KBAOCEDAFOM(false);
	}

	// Token: 0x06005405 RID: 21509 RVA: 0x00275626 File Offset: 0x00273826
	public void JPLPOLIFCOA(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.LBJCPDDCLJL(true);
	}

	// Token: 0x06005406 RID: 21510 RVA: 0x00274D09 File Offset: 0x00272F09
	public void ONLGBNBOHOL(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x06005407 RID: 21511 RVA: 0x00275626 File Offset: 0x00273826
	public void INIIILEHDGM(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.LBJCPDDCLJL(true);
	}

	// Token: 0x06005409 RID: 21513 RVA: 0x0027565F File Offset: 0x0027385F
	private void BNKJNBIDPME()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.KBAOCEDAFOM(false);
		}
	}

	// Token: 0x0600540A RID: 21514 RVA: 0x00274D09 File Offset: 0x00272F09
	public void GKHPLIMDAGB(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x0600540B RID: 21515 RVA: 0x00275255 File Offset: 0x00273455
	private void CDLDCKAHLHC()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.HBCJEELNAIP(false);
		}
	}

	// Token: 0x0600540C RID: 21516 RVA: 0x00275675 File Offset: 0x00273875
	public void CDJEJEJLNHH(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.OBCIOGHPILD(true);
	}

	// Token: 0x0600540D RID: 21517 RVA: 0x002756AE File Offset: 0x002738AE
	public void LFBNCBPDBKG(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.KONEJCNGFBH(false);
	}

	// Token: 0x0600540E RID: 21518 RVA: 0x002756E7 File Offset: 0x002738E7
	public void GHJLKIJECPL(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.KCBGLMAKPIA(true);
	}

	// Token: 0x0600540F RID: 21519 RVA: 0x00275720 File Offset: 0x00273920
	private void HMLNMHOMMNO()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.EAFEGPHGOOG(true);
		}
	}

	// Token: 0x06005410 RID: 21520 RVA: 0x00275037 File Offset: 0x00273237
	public void FFKBDCFLDCL(string IABKGMNJLJO, int IIDAELEGPNB = 0, float CPEAFPEJBDI = 5f)
	{
		this.messageText.text = IABKGMNJLJO;
		this.cloudPanel.color = this.backColors[IIDAELEGPNB];
		this.EMEBFBNFNBG = Time.time + CPEAFPEJBDI;
		this.DLNCCKGPEJI(true);
	}

	// Token: 0x06005411 RID: 21521 RVA: 0x00274D09 File Offset: 0x00272F09
	public void KBAOCEDAFOM(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x06005412 RID: 21522 RVA: 0x00275736 File Offset: 0x00273936
	private void BOAJJAKEMLH()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.EAFEGPHGOOG(false);
		}
	}

	// Token: 0x06005413 RID: 21523 RVA: 0x0027574C File Offset: 0x0027394C
	private void OLBDJCFPKFG()
	{
		this.LNAFOGDDCIA(false);
	}

	// Token: 0x06005414 RID: 21524 RVA: 0x00274D09 File Offset: 0x00272F09
	public void AJNDNNDEGDI(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x06005415 RID: 21525 RVA: 0x00274D6B File Offset: 0x00272F6B
	private void KMPEBHIPKJH()
	{
		if (Time.time > this.EMEBFBNFNBG)
		{
			this.isVisible(false);
		}
	}

	// Token: 0x06005416 RID: 21526 RVA: 0x00274D09 File Offset: 0x00272F09
	public void EBGBLLIDFOP(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x06005417 RID: 21527 RVA: 0x00274D09 File Offset: 0x00272F09
	public void isVisible(bool GPMBKIIIOFC)
	{
		this.cloudPanel.gameObject.SetActive(GPMBKIIIOFC);
	}

	// Token: 0x04000CB6 RID: 3254
	public GameObject rootPanel;

	// Token: 0x04000CB7 RID: 3255
	public Text messageText;

	// Token: 0x04000CB8 RID: 3256
	public Image cloudPanel;

	// Token: 0x04000CB9 RID: 3257
	public Color[] backColors;

	// Token: 0x04000CBA RID: 3258
	private float EMEBFBNFNBG;
}
