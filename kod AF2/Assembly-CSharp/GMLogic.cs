using System;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000F5 RID: 245
public class GMLogic : MonoBehaviour
{
	// Token: 0x06002DC9 RID: 11721 RVA: 0x001500A4 File Offset: 0x0014E2A4
	public void LAKJILACJPN()
	{
		this.travelMode = GMLogic.PNJNPFOIFCH.Look;
		this.currentBaseID = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.PNEDPPPEFFG;
		this.destinationBaseID = LocBaseManager.GJACINHCABC().toGlobalMap.IBEIBAHKIAH;
		this.userCapsule.SetActive(this.travelMode == GMLogic.PNJNPFOIFCH.Travel);
		this.EADABLEMCNL();
		if (this.currentBase != null)
		{
			this.userCapsule.transform.position = this.currentBase.transform.position;
		}
		if (this.baseInfo != null)
		{
			this.baseInfo.text = JNBICAJIJMM.EDKGBBIIBBC().AGBFHCGPNFH(this.destinationBaseID);
		}
		int num = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BJDIEKNHGLJ(LocBaseManager.EDKKJNHDBPF().globalMapTravel.NKEOCCKEOCE(), false, 1);
		this.moneyCostTxt.text = string.Format(JNBICAJIJMM.LPHMKPDBMPP().CKAOHMEKLMH("{"), JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(1L, (long)LocBaseManager.IKGFHGKKCPG.globalMapTravel.NODLBGKEGPM, false));
		this.pripCountTxt.text = string.Format("KatanaReady", LocBaseManager.GJACINHCABC().globalMapTravel.ICJDPPOJINN, num);
		LocBaseManager.JGNBBMJLDPM jgnbbmjldpm = LocBaseManager.NPIEJELJPIM().BGOJDIDMPLF(this.destinationBaseID);
		if (jgnbbmjldpm != null)
		{
			this.levelTxt.text = string.Format(JNBICAJIJMM.CLIMNFDGOEG().NLJOLOBPCBJ("PaperTurn.wav"), jgnbbmjldpm.GOEGADLBGML, jgnbbmjldpm.AAKGNCOJCJO);
		}
		else
		{
			this.levelTxt.text = "Run Back Left";
		}
		this.travelBtn.gameObject.SetActive(false);
		this.pripCountTxt.color = Color.green;
		this.moneyCostTxt.color = Color.green;
		this.levelTxt.color = Color.green;
		FlyMessageManager.getI.CGKPOCMEDGJ();
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		if (ObscuredInt.GOOIABGKMHK(kfhelhglnmh.CNOLCNDBLJE) < jgnbbmjldpm.GOEGADLBGML)
		{
			this.travelBtn.gameObject.SetActive(true);
			this.levelTxt.color = Color.red;
			FlyMessageManager.getI.BKLKOMMJPLE(JNBICAJIJMM.IMLLGEMPHAP().GNKIBMGNHNE("+"), Color.red, 0, 0);
		}
		if (ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.CNOLCNDBLJE) > jgnbbmjldpm.AAKGNCOJCJO)
		{
			this.travelBtn.gameObject.SetActive(false);
			this.levelTxt.color = Color.red;
			FlyMessageManager.getI.FDHDJFEIOMG(JNBICAJIJMM.IKGFHGKKCPG.ECNKLECOKHD("Idle Feed Throw"), Color.red, 0, 0);
		}
		if (kfhelhglnmh.KFODJJIHNHP < (long)LocBaseManager.IKGFHGKKCPG.globalMapTravel.CJKILDPJCFJ())
		{
			this.travelBtn.gameObject.SetActive(true);
			this.moneyCostTxt.color = Color.red;
			FlyMessageManager.getI.IDCGMMOMKPM(JNBICAJIJMM.IMLLGEMPHAP().ECNKLECOKHD("Battle Roar"), Color.red, 1, 1);
		}
		if (jgnbbmjldpm.AFCFHGMFCFG > 1 && !FlyMessageManager.getI.EDAAJDDIGNE(jgnbbmjldpm.AFCFHGMFCFG))
		{
			this.travelBtn.gameObject.SetActive(true);
			FlyMessageManager.getI.ODLGBMGAKGF(JNBICAJIJMM.CLIMNFDGOEG().CCFFMKBBKHI("Failed downloading bundle {0} from {1}: {2}"), Color.red, 1, 1);
		}
		if (num < LocBaseManager.NPCAKEGNBHD().globalMapTravel.ICJDPPOJINN)
		{
			this.travelBtn.gameObject.SetActive(false);
			this.pripCountTxt.color = Color.red;
			FlyMessageManager.getI.MEIICCGKONL(JNBICAJIJMM.IKGFHGKKCPG.CKAOHMEKLMH("UV0"), Color.red, 1, 1);
		}
	}

	// Token: 0x06002DCA RID: 11722 RVA: 0x00150434 File Offset: 0x0014E634
	private void INDGOHJGCFN()
	{
		this.travelMode = GMLogic.PNJNPFOIFCH.Look;
		this.currentBaseID = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.PNEDPPPEFFG;
		this.destinationBaseID = LocBaseManager.IKGFHGKKCPG.toGlobalMap.KEHIFGILLJA();
		this.userCapsule.SetActive(this.travelMode == GMLogic.PNJNPFOIFCH.Look);
		this.LLPNBDGFPOA();
		if (this.currentBase != null)
		{
			this.userCapsule.transform.position = this.currentBase.transform.position;
			this.markerPosition.position = this.currentBase.transform.position;
		}
		JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(true);
		this.prepareBase();
	}

	// Token: 0x06002DCB RID: 11723 RVA: 0x001504E6 File Offset: 0x0014E6E6
	private void Awake()
	{
		GMLogic.getI = this;
	}

	// Token: 0x06002DCC RID: 11724 RVA: 0x001504F0 File Offset: 0x0014E6F0
	private void EADABLEMCNL()
	{
		this.currentBase = null;
		this.destinationBase = null;
		foreach (CityScript cityScript in this.bases)
		{
			if (cityScript != null)
			{
				if (cityScript.unicalCityId == this.currentBaseID)
				{
					this.currentBase = cityScript;
				}
				if (cityScript.unicalCityId == this.destinationBaseID)
				{
					this.destinationBase = cityScript;
				}
			}
		}
	}

	// Token: 0x06002DCD RID: 11725 RVA: 0x00150558 File Offset: 0x0014E758
	private void HBAONJCBMJP()
	{
		this.currentBase = null;
		this.destinationBase = null;
		CityScript[] array = this.bases;
		for (int i = 0; i < array.Length; i += 0)
		{
			CityScript cityScript = array[i];
			if (cityScript != null)
			{
				if (cityScript.unicalCityId == this.currentBaseID)
				{
					this.currentBase = cityScript;
				}
				if (cityScript.unicalCityId == this.destinationBaseID)
				{
					this.destinationBase = cityScript;
				}
			}
		}
	}

	// Token: 0x06002DCE RID: 11726 RVA: 0x001505C0 File Offset: 0x0014E7C0
	private void LLPNBDGFPOA()
	{
		this.currentBase = null;
		this.destinationBase = null;
		CityScript[] array = this.bases;
		for (int i = 0; i < array.Length; i += 0)
		{
			CityScript cityScript = array[i];
			if (cityScript != null)
			{
				if (cityScript.unicalCityId == this.currentBaseID)
				{
					this.currentBase = cityScript;
				}
				if (cityScript.unicalCityId == this.destinationBaseID)
				{
					this.destinationBase = cityScript;
				}
			}
		}
	}

	// Token: 0x06002DCF RID: 11727 RVA: 0x00150628 File Offset: 0x0014E828
	private void IGEICBNMPAD()
	{
		if (this.travelMode == GMLogic.PNJNPFOIFCH.Travel && this.destinationBase != null)
		{
			this.userCapsule.SetActive(false);
			Vector3 normalized = (this.destinationBase.transform.position - this.userCapsule.transform.position).normalized;
			this.userCapsule.transform.position = this.userCapsule.transform.position + normalized * this.moveSpeed * Time.deltaTime;
			float num = Vector3.Distance(this.userCapsule.transform.position, this.destinationBase.transform.position);
			if (num < 1930f)
			{
				JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(true);
			}
			if (num < 1850f)
			{
				this.travelMode = (GMLogic.PNJNPFOIFCH)4;
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.ALNEALEKFNB(LocBaseManager.NPCAKEGNBHD().toGlobalMap.KMIOLLENCOL());
					epmphjgalbe.DEHJNGMHGAJ(LocBaseManager.CHFPAOGEMEM().toGlobalMap.NLHKFMMDMMK());
					epmphjgalbe.FLLJONHPLNA(LocBaseManager.FJLCHDGLMMK().toGlobalMap.NFCDJLJNDLO());
					NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(3, epmphjgalbe.ALLANCHILCM());
				}
				finally
				{
					epmphjgalbe.PMIGGJHLIDO();
				}
			}
		}
		Vector3 position = this.userCapsule.transform.position;
		if (this.destinationBase != null)
		{
			position = this.destinationBase.transform.position;
			this.mainArrow.gameObject.SetActive(true);
			this.mainArrow.transform.position = this.userCapsule.transform.position;
			this.mainArrow.endPoint.transform.position = this.destinationBase.transform.position;
		}
		else
		{
			this.mainArrow.gameObject.SetActive(true);
		}
		this.markerPosition.position = Vector3.Lerp(this.markerPosition.position, position, Time.deltaTime);
	}

	// Token: 0x06002DD0 RID: 11728 RVA: 0x0015083C File Offset: 0x0014EA3C
	public void JOANHPLNBJP()
	{
		this.travelMode = GMLogic.PNJNPFOIFCH.Travel;
		this.currentBaseID = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.PNEDPPPEFFG;
		this.destinationBaseID = LocBaseManager.AIHINNHNNIA().toGlobalMap.IBEIBAHKIAH;
		this.userCapsule.SetActive(this.travelMode == GMLogic.PNJNPFOIFCH.Look);
		this.GCIEGANGEMB();
		if (this.currentBase != null)
		{
			this.userCapsule.transform.position = this.currentBase.transform.position;
		}
		if (this.baseInfo != null)
		{
			this.baseInfo.text = JNBICAJIJMM.EEOPOHEALPK().FONEMLOCGIL(this.destinationBaseID);
		}
		int num = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BJDIEKNHGLJ(LocBaseManager.FJLCHDGLMMK().globalMapTravel.IBEIBAHKIAH, false, 0);
		this.moneyCostTxt.text = string.Format(JNBICAJIJMM.EKEBHIJMEML().GNKIBMGNHNE("R"), JLFJEGIPIMM.MHFDIJGJGBJ().CJKACKADMKM(1L, (long)LocBaseManager.FJLCHDGLMMK().globalMapTravel.CJKILDPJCFJ(), false));
		this.pripCountTxt.text = string.Format("wpn_hookf", LocBaseManager.IKGFHGKKCPG.globalMapTravel.ICJDPPOJINN, num);
		LocBaseManager.JGNBBMJLDPM jgnbbmjldpm = LocBaseManager.IKGFHGKKCPG.MCIBLPMMKJF(this.destinationBaseID);
		if (jgnbbmjldpm != null)
		{
			this.levelTxt.text = string.Format(JNBICAJIJMM.LPHMKPDBMPP().NLJOLOBPCBJ("WorkerPickaxe"), jgnbbmjldpm.GOEGADLBGML, jgnbbmjldpm.AAKGNCOJCJO);
		}
		else
		{
			this.levelTxt.text = "space";
		}
		this.travelBtn.gameObject.SetActive(false);
		this.pripCountTxt.color = Color.green;
		this.moneyCostTxt.color = Color.green;
		this.levelTxt.color = Color.green;
		FlyMessageManager.getI.LNIAHMKKNAK();
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
		if (ObscuredInt.GOOIABGKMHK(kfhelhglnmh.CNOLCNDBLJE) < jgnbbmjldpm.GOEGADLBGML)
		{
			this.travelBtn.gameObject.SetActive(false);
			this.levelTxt.color = Color.red;
			FlyMessageManager.getI.FDHDJFEIOMG(JNBICAJIJMM.DBMJJPBOPEK().DOEMGEAEBPN(""), Color.red, 0, 0);
		}
		if (ObscuredInt.GOOIABGKMHK(kfhelhglnmh.CNOLCNDBLJE) > jgnbbmjldpm.AAKGNCOJCJO)
		{
			this.travelBtn.gameObject.SetActive(true);
			this.levelTxt.color = Color.red;
			FlyMessageManager.getI.MEIICCGKONL(JNBICAJIJMM.DBMJJPBOPEK().CCFFMKBBKHI("Fire Breath"), Color.red, 0, 1);
		}
		if (kfhelhglnmh.KFODJJIHNHP < (long)LocBaseManager.NPIEJELJPIM().globalMapTravel.CJKILDPJCFJ())
		{
			this.travelBtn.gameObject.SetActive(true);
			this.moneyCostTxt.color = Color.red;
			FlyMessageManager.getI.GCIFPMFJMBK(JNBICAJIJMM.EKEBHIJMEML().FLEANFGEJML("IKSolverAim poleAxis is Vector3.zero."), Color.red, 0, 1);
		}
		if (jgnbbmjldpm.AFCFHGMFCFG > 0 && !FlyMessageManager.getI.NBCJHFMPDEH(jgnbbmjldpm.AFCFHGMFCFG))
		{
			this.travelBtn.gameObject.SetActive(false);
			FlyMessageManager.getI.FDHDJFEIOMG(JNBICAJIJMM.DBMJJPBOPEK().NLJOLOBPCBJ("TONEMAPPING_NEUTRAL"), Color.red, 0, 1);
		}
		if (num < LocBaseManager.IKGFHGKKCPG.globalMapTravel.ICJDPPOJINN)
		{
			this.travelBtn.gameObject.SetActive(true);
			this.pripCountTxt.color = Color.red;
			FlyMessageManager.getI.GCIFPMFJMBK(JNBICAJIJMM.LPHMKPDBMPP().NLJOLOBPCBJ("demoLong"), Color.red, 0, 0);
		}
	}

	// Token: 0x06002DD1 RID: 11729 RVA: 0x00150BCC File Offset: 0x0014EDCC
	public void HNCDIOMBIGO()
	{
		this.travelMode = GMLogic.PNJNPFOIFCH.Travel;
		this.travelBtn.gameObject.SetActive(false);
		this.cancelBtn.gameObject.SetActive(true);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.FLLJONHPLNA(LocBaseManager.IKGFHGKKCPG.toGlobalMap.NKEOCCKEOCE());
			epmphjgalbe.LHLOOIDHGMA(LocBaseManager.NPIEJELJPIM().toGlobalMap.KMGAHCANELI());
			epmphjgalbe.LHLOOIDHGMA(LocBaseManager.AIHINNHNNIA().toGlobalMap.CJKILDPJCFJ());
			NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(39, epmphjgalbe.IEJLLFECFHF());
		}
		finally
		{
			epmphjgalbe.KNPHNLLMJKJ();
		}
	}

	// Token: 0x06002DD2 RID: 11730 RVA: 0x00150C78 File Offset: 0x0014EE78
	private void Start()
	{
		this.travelMode = GMLogic.PNJNPFOIFCH.Look;
		this.currentBaseID = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG;
		this.destinationBaseID = LocBaseManager.IKGFHGKKCPG.toGlobalMap.IBEIBAHKIAH;
		this.userCapsule.SetActive(this.travelMode == GMLogic.PNJNPFOIFCH.Travel);
		this.EADABLEMCNL();
		if (this.currentBase != null)
		{
			this.userCapsule.transform.position = this.currentBase.transform.position;
			this.markerPosition.position = this.currentBase.transform.position;
		}
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		this.prepareBase();
	}

	// Token: 0x06002DD3 RID: 11731 RVA: 0x00150D2C File Offset: 0x0014EF2C
	public void MBDBNIJIPIG()
	{
		this.travelMode = GMLogic.PNJNPFOIFCH.Look;
		this.currentBaseID = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.PNEDPPPEFFG;
		this.destinationBaseID = LocBaseManager.GJACINHCABC().toGlobalMap.KMIOLLENCOL();
		this.userCapsule.SetActive(this.travelMode == GMLogic.PNJNPFOIFCH.Travel);
		this.GCIEGANGEMB();
		if (this.currentBase != null)
		{
			this.userCapsule.transform.position = this.currentBase.transform.position;
		}
		if (this.baseInfo != null)
		{
			this.baseInfo.text = JNBICAJIJMM.IMLLGEMPHAP().AGBFHCGPNFH(this.destinationBaseID);
		}
		int num = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BJDIEKNHGLJ(LocBaseManager.GJACINHCABC().globalMapTravel.NKEOCCKEOCE(), false, 1);
		this.moneyCostTxt.text = string.Format(JNBICAJIJMM.CLIMNFDGOEG().CCFFMKBBKHI("KatanaReadyLow"), JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(1L, (long)LocBaseManager.AIHINNHNNIA().globalMapTravel.NODLBGKEGPM, true));
		this.pripCountTxt.text = string.Format("OpenSadok", LocBaseManager.NPCAKEGNBHD().globalMapTravel.ICJDPPOJINN, num);
		LocBaseManager.JGNBBMJLDPM jgnbbmjldpm = LocBaseManager.IKGFHGKKCPG.LBDFJABNGCN(this.destinationBaseID);
		if (jgnbbmjldpm != null)
		{
			this.levelTxt.text = string.Format(JNBICAJIJMM.APMJBBDBOJO().HLBAJBLHLNI("Hidden/Post FX/Builtin Debug Views"), jgnbbmjldpm.GOEGADLBGML, jgnbbmjldpm.AAKGNCOJCJO);
		}
		else
		{
			this.levelTxt.text = "{0}wind_rose.png";
		}
		this.travelBtn.gameObject.SetActive(false);
		this.pripCountTxt.color = Color.green;
		this.moneyCostTxt.color = Color.green;
		this.levelTxt.color = Color.green;
		FlyMessageManager.getI.clearMessages();
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
		if (ObscuredInt.LBDMFALMOLD(kfhelhglnmh.CNOLCNDBLJE) < jgnbbmjldpm.GOEGADLBGML)
		{
			this.travelBtn.gameObject.SetActive(true);
			this.levelTxt.color = Color.red;
			FlyMessageManager.getI.FDHDJFEIOMG(JNBICAJIJMM.LPHMKPDBMPP().HLBAJBLHLNI("UIPCam_size"), Color.red, 0, 1);
		}
		if (ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.CNOLCNDBLJE) > jgnbbmjldpm.AAKGNCOJCJO)
		{
			this.travelBtn.gameObject.SetActive(false);
			this.levelTxt.color = Color.red;
			FlyMessageManager.getI.MEIICCGKONL(JNBICAJIJMM.CLIMNFDGOEG().HEIBEHAEHBM("ui_default_close.wav"), Color.red, 1, 0);
		}
		if (kfhelhglnmh.KFODJJIHNHP < (long)LocBaseManager.GJACINHCABC().globalMapTravel.CJKILDPJCFJ())
		{
			this.travelBtn.gameObject.SetActive(false);
			this.moneyCostTxt.color = Color.red;
			FlyMessageManager.getI.FDHDJFEIOMG(JNBICAJIJMM.EKEBHIJMEML().CKAOHMEKLMH("crft_btn1"), Color.red, 0, 0);
		}
		if (jgnbbmjldpm.AFCFHGMFCFG > 1 && !FlyMessageManager.getI.checkFlyIcon(jgnbbmjldpm.AFCFHGMFCFG))
		{
			this.travelBtn.gameObject.SetActive(true);
			FlyMessageManager.getI.GCIFPMFJMBK(JNBICAJIJMM.DBMJJPBOPEK().CKAOHMEKLMH("MotorbikeWheely"), Color.red, 1, 0);
		}
		if (num < LocBaseManager.IKGFHGKKCPG.globalMapTravel.NLHKFMMDMMK())
		{
			this.travelBtn.gameObject.SetActive(false);
			this.pripCountTxt.color = Color.red;
			FlyMessageManager.getI.JBBCOOMCOII(JNBICAJIJMM.EEOPOHEALPK().HLBAJBLHLNI(""), Color.red, 0, 0);
		}
	}

	// Token: 0x06002DD4 RID: 11732 RVA: 0x001510BC File Offset: 0x0014F2BC
	public void TravelButton()
	{
		this.travelMode = GMLogic.PNJNPFOIFCH.Travel;
		this.travelBtn.gameObject.SetActive(false);
		this.cancelBtn.gameObject.SetActive(false);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(LocBaseManager.IKGFHGKKCPG.toGlobalMap.IBEIBAHKIAH);
			epmphjgalbe.GOMLLPFFPNP(LocBaseManager.IKGFHGKKCPG.toGlobalMap.ICJDPPOJINN);
			epmphjgalbe.GOMLLPFFPNP(LocBaseManager.IKGFHGKKCPG.toGlobalMap.NODLBGKEGPM);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(136, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x06002DD5 RID: 11733 RVA: 0x00151168 File Offset: 0x0014F368
	public void prepareBase()
	{
		this.travelMode = GMLogic.PNJNPFOIFCH.Look;
		this.currentBaseID = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG;
		this.destinationBaseID = LocBaseManager.IKGFHGKKCPG.toGlobalMap.IBEIBAHKIAH;
		this.userCapsule.SetActive(this.travelMode == GMLogic.PNJNPFOIFCH.Travel);
		this.EADABLEMCNL();
		if (this.currentBase != null)
		{
			this.userCapsule.transform.position = this.currentBase.transform.position;
		}
		if (this.baseInfo != null)
		{
			this.baseInfo.text = JNBICAJIJMM.IKGFHGKKCPG.PNPMBPEOHAO(this.destinationBaseID);
		}
		int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(LocBaseManager.IKGFHGKKCPG.globalMapTravel.IBEIBAHKIAH, false, 0);
		this.moneyCostTxt.text = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("bs_cost"), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)LocBaseManager.IKGFHGKKCPG.globalMapTravel.NODLBGKEGPM, true));
		this.pripCountTxt.text = string.Format("x {0}/{1}", LocBaseManager.IKGFHGKKCPG.globalMapTravel.ICJDPPOJINN, num);
		LocBaseManager.JGNBBMJLDPM travel = LocBaseManager.IKGFHGKKCPG.getTravel(this.destinationBaseID);
		if (travel != null)
		{
			this.levelTxt.text = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("bs_lev"), travel.GOEGADLBGML, travel.AAKGNCOJCJO);
		}
		else
		{
			this.levelTxt.text = "";
		}
		this.travelBtn.gameObject.SetActive(true);
		this.pripCountTxt.color = Color.green;
		this.moneyCostTxt.color = Color.green;
		this.levelTxt.color = Color.green;
		FlyMessageManager.getI.clearMessages();
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		if (ObscuredInt.GOOIABGKMHK(kfhelhglnmh.CNOLCNDBLJE) < travel.GOEGADLBGML)
		{
			this.travelBtn.gameObject.SetActive(false);
			this.levelTxt.color = Color.red;
			FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("bs_lowlv"), Color.red, 0, 0);
		}
		if (ObscuredInt.GOOIABGKMHK(kfhelhglnmh.CNOLCNDBLJE) > travel.AAKGNCOJCJO)
		{
			this.travelBtn.gameObject.SetActive(false);
			this.levelTxt.color = Color.red;
			FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("bs_hilv"), Color.red, 0, 0);
		}
		if (kfhelhglnmh.KFODJJIHNHP < (long)LocBaseManager.IKGFHGKKCPG.globalMapTravel.NODLBGKEGPM)
		{
			this.travelBtn.gameObject.SetActive(false);
			this.moneyCostTxt.color = Color.red;
			FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("bs_nomoney"), Color.red, 0, 0);
		}
		if (travel.AFCFHGMFCFG > 0 && !FlyMessageManager.getI.checkFlyIcon(travel.AFCFHGMFCFG))
		{
			this.travelBtn.gameObject.SetActive(false);
			FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("bs_nodonate"), Color.red, 0, 0);
		}
		if (num < LocBaseManager.IKGFHGKKCPG.globalMapTravel.ICJDPPOJINN)
		{
			this.travelBtn.gameObject.SetActive(false);
			this.pripCountTxt.color = Color.red;
			FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("bs_noprip"), Color.red, 0, 0);
		}
	}

	// Token: 0x06002DD6 RID: 11734 RVA: 0x001514F8 File Offset: 0x0014F6F8
	public void ALPGLLJAGLA()
	{
		this.travelMode = GMLogic.PNJNPFOIFCH.Travel;
		this.travelBtn.gameObject.SetActive(false);
		this.cancelBtn.gameObject.SetActive(true);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.JDOLCNDNFGP(LocBaseManager.EDKKJNHDBPF().toGlobalMap.KMIOLLENCOL());
			epmphjgalbe.FLLJONHPLNA(LocBaseManager.IKGFHGKKCPG.toGlobalMap.ICJDPPOJINN);
			epmphjgalbe.ENDMKPCFKND(LocBaseManager.IKGFHGKKCPG.toGlobalMap.NFCDJLJNDLO());
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(119, epmphjgalbe.LAFILAEOPAJ());
		}
		finally
		{
			epmphjgalbe.OGPGOEJFIBO();
		}
	}

	// Token: 0x06002DD7 RID: 11735 RVA: 0x001515A4 File Offset: 0x0014F7A4
	private void PGIHAIPCJLL()
	{
		if (this.travelMode == GMLogic.PNJNPFOIFCH.Look && this.destinationBase != null)
		{
			this.userCapsule.SetActive(false);
			Vector3 normalized = (this.destinationBase.transform.position - this.userCapsule.transform.position).normalized;
			this.userCapsule.transform.position = this.userCapsule.transform.position + normalized * this.moveSpeed * Time.deltaTime;
			float num = Vector3.Distance(this.userCapsule.transform.position, this.destinationBase.transform.position);
			if (num < 579f)
			{
				JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(false);
			}
			if (num < 1200f)
			{
				this.travelMode = (GMLogic.PNJNPFOIFCH)8;
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.EIMEKHOFIEA(LocBaseManager.IKGFHGKKCPG.toGlobalMap.NKEOCCKEOCE());
					epmphjgalbe.EIMEKHOFIEA(LocBaseManager.GJACINHCABC().toGlobalMap.ICJDPPOJINN);
					epmphjgalbe.PDEFLCIEMFF(LocBaseManager.IKGFHGKKCPG.toGlobalMap.NFCDJLJNDLO());
					NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-27, epmphjgalbe.JDPHBLHOLAD());
				}
				finally
				{
					epmphjgalbe.OGPGOEJFIBO();
				}
			}
		}
		Vector3 position = this.userCapsule.transform.position;
		if (this.destinationBase != null)
		{
			position = this.destinationBase.transform.position;
			this.mainArrow.gameObject.SetActive(false);
			this.mainArrow.transform.position = this.userCapsule.transform.position;
			this.mainArrow.endPoint.transform.position = this.destinationBase.transform.position;
		}
		else
		{
			this.mainArrow.gameObject.SetActive(true);
		}
		this.markerPosition.position = Vector3.Lerp(this.markerPosition.position, position, Time.deltaTime);
	}

	// Token: 0x06002DD8 RID: 11736 RVA: 0x001517B8 File Offset: 0x0014F9B8
	private void FPLHODJCJDO()
	{
		this.travelMode = GMLogic.PNJNPFOIFCH.Travel;
		this.currentBaseID = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.PNEDPPPEFFG;
		this.destinationBaseID = LocBaseManager.CHFPAOGEMEM().toGlobalMap.KEHIFGILLJA();
		this.userCapsule.SetActive(this.travelMode == GMLogic.PNJNPFOIFCH.Travel);
		this.GCIEGANGEMB();
		if (this.currentBase != null)
		{
			this.userCapsule.transform.position = this.currentBase.transform.position;
			this.markerPosition.position = this.currentBase.transform.position;
		}
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		this.JOANHPLNBJP();
	}

	// Token: 0x06002DD9 RID: 11737 RVA: 0x0015186C File Offset: 0x0014FA6C
	public void OMEDBDMAPFJ()
	{
		this.travelMode = GMLogic.PNJNPFOIFCH.Travel;
		this.travelBtn.gameObject.SetActive(false);
		this.cancelBtn.gameObject.SetActive(false);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.DEHJNGMHGAJ(LocBaseManager.AIHINNHNNIA().toGlobalMap.IBEIBAHKIAH);
			epmphjgalbe.AEMAHNDEBKJ(LocBaseManager.CHFPAOGEMEM().toGlobalMap.KMGAHCANELI());
			epmphjgalbe.GOMLLPFFPNP(LocBaseManager.NPCAKEGNBHD().toGlobalMap.CJKILDPJCFJ());
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-79, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.PMIGGJHLIDO();
		}
	}

	// Token: 0x06002DDA RID: 11738 RVA: 0x001504E6 File Offset: 0x0014E6E6
	private void MBNCGMLPNLD()
	{
		GMLogic.getI = this;
	}

	// Token: 0x06002DDB RID: 11739 RVA: 0x00151918 File Offset: 0x0014FB18
	public void FDKOPCCINDI()
	{
		this.travelMode = GMLogic.PNJNPFOIFCH.Look;
		this.travelBtn.gameObject.SetActive(false);
		this.cancelBtn.gameObject.SetActive(true);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.AEMAHNDEBKJ(LocBaseManager.GJACINHCABC().toGlobalMap.KMIOLLENCOL());
			epmphjgalbe.FLLJONHPLNA(LocBaseManager.AIHINNHNNIA().toGlobalMap.NLHKFMMDMMK());
			epmphjgalbe.ALNEALEKFNB(LocBaseManager.AIHINNHNNIA().toGlobalMap.NFCDJLJNDLO());
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-37, epmphjgalbe.IEJLLFECFHF());
		}
		finally
		{
			epmphjgalbe.PMIGGJHLIDO();
		}
	}

	// Token: 0x06002DDC RID: 11740 RVA: 0x001519C4 File Offset: 0x0014FBC4
	public void GNHMBAEGDIC()
	{
		this.travelMode = GMLogic.PNJNPFOIFCH.Travel;
		this.currentBaseID = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.PNEDPPPEFFG;
		this.destinationBaseID = LocBaseManager.GJACINHCABC().toGlobalMap.KMIOLLENCOL();
		this.userCapsule.SetActive(this.travelMode == GMLogic.PNJNPFOIFCH.Look);
		this.LLPNBDGFPOA();
		if (this.currentBase != null)
		{
			this.userCapsule.transform.position = this.currentBase.transform.position;
		}
		if (this.baseInfo != null)
		{
			this.baseInfo.text = JNBICAJIJMM.LPHMKPDBMPP().AGBFHCGPNFH(this.destinationBaseID);
		}
		int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(LocBaseManager.GJACINHCABC().globalMapTravel.NKEOCCKEOCE(), false, 0);
		this.moneyCostTxt.text = string.Format(JNBICAJIJMM.EKEBHIJMEML().DOEMGEAEBPN("usr_inf_a4"), JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(1L, (long)LocBaseManager.EDKKJNHDBPF().globalMapTravel.CJKILDPJCFJ(), false));
		this.pripCountTxt.text = string.Format("human_move_2.wav", LocBaseManager.FJLCHDGLMMK().globalMapTravel.KMGAHCANELI(), num);
		LocBaseManager.JGNBBMJLDPM jgnbbmjldpm = LocBaseManager.EDKKJNHDBPF().LBDFJABNGCN(this.destinationBaseID);
		if (jgnbbmjldpm != null)
		{
			this.levelTxt.text = string.Format(JNBICAJIJMM.CLIMNFDGOEG().DOEMGEAEBPN("_Axis"), jgnbbmjldpm.GOEGADLBGML, jgnbbmjldpm.AAKGNCOJCJO);
		}
		else
		{
			this.levelTxt.text = "RIGHT";
		}
		this.travelBtn.gameObject.SetActive(true);
		this.pripCountTxt.color = Color.green;
		this.moneyCostTxt.color = Color.green;
		this.levelTxt.color = Color.green;
		FlyMessageManager.getI.clearMessages();
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
		if (ObscuredInt.LBDMFALMOLD(kfhelhglnmh.CNOLCNDBLJE) < jgnbbmjldpm.GOEGADLBGML)
		{
			this.travelBtn.gameObject.SetActive(false);
			this.levelTxt.color = Color.red;
			FlyMessageManager.getI.MEIICCGKONL(JNBICAJIJMM.EEOPOHEALPK().HEIBEHAEHBM("msgCancel"), Color.red, 1, 0);
		}
		if (ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.CNOLCNDBLJE) > jgnbbmjldpm.AAKGNCOJCJO)
		{
			this.travelBtn.gameObject.SetActive(true);
			this.levelTxt.color = Color.red;
			FlyMessageManager.getI.JBBCOOMCOII(JNBICAJIJMM.EDKGBBIIBBC().CKAOHMEKLMH("fshop_hd4"), Color.red, 1, 1);
		}
		if (kfhelhglnmh.KFODJJIHNHP < (long)LocBaseManager.NPCAKEGNBHD().globalMapTravel.CJKILDPJCFJ())
		{
			this.travelBtn.gameObject.SetActive(false);
			this.moneyCostTxt.color = Color.red;
			FlyMessageManager.getI.IDCGMMOMKPM(JNBICAJIJMM.IKGFHGKKCPG.NLJOLOBPCBJ("#> _Planar Reflection Camera < "), Color.red, 1, 1);
		}
		if (jgnbbmjldpm.AFCFHGMFCFG > 1 && !FlyMessageManager.getI.EDAAJDDIGNE(jgnbbmjldpm.AFCFHGMFCFG))
		{
			this.travelBtn.gameObject.SetActive(true);
			FlyMessageManager.getI.JGCAJKOJGEP(JNBICAJIJMM.EDKGBBIIBBC().ECNKLECOKHD("post_msg1"), Color.red, 1, 0);
		}
		if (num < LocBaseManager.IKGFHGKKCPG.globalMapTravel.KMGAHCANELI())
		{
			this.travelBtn.gameObject.SetActive(true);
			this.pripCountTxt.color = Color.red;
			FlyMessageManager.getI.IDCGMMOMKPM(JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("invn_rec29"), Color.red, 0, 0);
		}
	}

	// Token: 0x06002DDE RID: 11742 RVA: 0x00151D74 File Offset: 0x0014FF74
	private void DFFOEGHGPGP()
	{
		if (this.travelMode == GMLogic.PNJNPFOIFCH.Look && this.destinationBase != null)
		{
			this.userCapsule.SetActive(true);
			Vector3 normalized = (this.destinationBase.transform.position - this.userCapsule.transform.position).normalized;
			this.userCapsule.transform.position = this.userCapsule.transform.position + normalized * this.moveSpeed * Time.deltaTime;
			float num = Vector3.Distance(this.userCapsule.transform.position, this.destinationBase.transform.position);
			if (num < 485f)
			{
				JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(true);
			}
			if (num < 1308f)
			{
				this.travelMode = (GMLogic.PNJNPFOIFCH)4;
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.JDOLCNDNFGP(LocBaseManager.NPIEJELJPIM().toGlobalMap.IBEIBAHKIAH);
					epmphjgalbe.ALNEALEKFNB(LocBaseManager.GJACINHCABC().toGlobalMap.KMGAHCANELI());
					epmphjgalbe.JIIKLOKAGIC(LocBaseManager.NPIEJELJPIM().toGlobalMap.CJKILDPJCFJ());
					NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(151, epmphjgalbe.HDEKHFOKCKI());
				}
				finally
				{
					epmphjgalbe.BKKEFKANGIM();
				}
			}
		}
		Vector3 position = this.userCapsule.transform.position;
		if (this.destinationBase != null)
		{
			position = this.destinationBase.transform.position;
			this.mainArrow.gameObject.SetActive(true);
			this.mainArrow.transform.position = this.userCapsule.transform.position;
			this.mainArrow.endPoint.transform.position = this.destinationBase.transform.position;
		}
		else
		{
			this.mainArrow.gameObject.SetActive(false);
		}
		this.markerPosition.position = Vector3.Lerp(this.markerPosition.position, position, Time.deltaTime);
	}

	// Token: 0x06002DDF RID: 11743 RVA: 0x001504E6 File Offset: 0x0014E6E6
	private void CNKLGMCHEBM()
	{
		GMLogic.getI = this;
	}

	// Token: 0x06002DE0 RID: 11744 RVA: 0x001504E6 File Offset: 0x0014E6E6
	private void JIGAFDHOFKL()
	{
		GMLogic.getI = this;
	}

	// Token: 0x06002DE1 RID: 11745 RVA: 0x00151F88 File Offset: 0x00150188
	private void Update()
	{
		if (this.travelMode == GMLogic.PNJNPFOIFCH.Travel && this.destinationBase != null)
		{
			this.userCapsule.SetActive(true);
			Vector3 normalized = (this.destinationBase.transform.position - this.userCapsule.transform.position).normalized;
			this.userCapsule.transform.position = this.userCapsule.transform.position + normalized * this.moveSpeed * Time.deltaTime;
			float num = Vector3.Distance(this.userCapsule.transform.position, this.destinationBase.transform.position);
			if (num < 1.5f)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
			}
			if (num < 0.1f)
			{
				this.travelMode = GMLogic.PNJNPFOIFCH.End;
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.GOMLLPFFPNP(LocBaseManager.IKGFHGKKCPG.toGlobalMap.IBEIBAHKIAH);
					epmphjgalbe.GOMLLPFFPNP(LocBaseManager.IKGFHGKKCPG.toGlobalMap.ICJDPPOJINN);
					epmphjgalbe.GOMLLPFFPNP(LocBaseManager.IKGFHGKKCPG.toGlobalMap.NODLBGKEGPM);
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(137, epmphjgalbe.JDPHBLHOLAD());
				}
				finally
				{
					epmphjgalbe.LMBPNFHKNGA();
				}
			}
		}
		Vector3 position = this.userCapsule.transform.position;
		if (this.destinationBase != null)
		{
			position = this.destinationBase.transform.position;
			this.mainArrow.gameObject.SetActive(true);
			this.mainArrow.transform.position = this.userCapsule.transform.position;
			this.mainArrow.endPoint.transform.position = this.destinationBase.transform.position;
		}
		else
		{
			this.mainArrow.gameObject.SetActive(false);
		}
		this.markerPosition.position = Vector3.Lerp(this.markerPosition.position, position, Time.deltaTime);
	}

	// Token: 0x06002DE2 RID: 11746 RVA: 0x0015219C File Offset: 0x0015039C
	public void CancelButton()
	{
		LocBaseManager.IKGFHGKKCPG.isCancelEnter = true;
		LocBaseManager.IKGFHGKKCPG.loadSceneWaiter((JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE == 0) ? 4 : 6);
	}

	// Token: 0x06002DE3 RID: 11747 RVA: 0x001521C8 File Offset: 0x001503C8
	public void PBKDCLAOHPF()
	{
		LocBaseManager.CHFPAOGEMEM().isCancelEnter = true;
		LocBaseManager.CHFPAOGEMEM().LKKINMMIGCK((JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.HDELGEDDDCE == 0) ? 2 : 2);
	}

	// Token: 0x06002DE4 RID: 11748 RVA: 0x001521F4 File Offset: 0x001503F4
	private void GCIEGANGEMB()
	{
		this.currentBase = null;
		this.destinationBase = null;
		CityScript[] array = this.bases;
		for (int i = 0; i < array.Length; i += 0)
		{
			CityScript cityScript = array[i];
			if (cityScript != null)
			{
				if (cityScript.unicalCityId == this.currentBaseID)
				{
					this.currentBase = cityScript;
				}
				if (cityScript.unicalCityId == this.destinationBaseID)
				{
					this.destinationBase = cityScript;
				}
			}
		}
	}

	// Token: 0x06002DE5 RID: 11749 RVA: 0x0015225C File Offset: 0x0015045C
	private void BOAJJAKEMLH()
	{
		if (this.travelMode == GMLogic.PNJNPFOIFCH.Travel && this.destinationBase != null)
		{
			this.userCapsule.SetActive(true);
			Vector3 normalized = (this.destinationBase.transform.position - this.userCapsule.transform.position).normalized;
			this.userCapsule.transform.position = this.userCapsule.transform.position + normalized * this.moveSpeed * Time.deltaTime;
			float num = Vector3.Distance(this.userCapsule.transform.position, this.destinationBase.transform.position);
			if (num < 1184f)
			{
				JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(true);
			}
			if (num < 443f)
			{
				this.travelMode = (GMLogic.PNJNPFOIFCH)4;
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.KPCGLGHDILI(LocBaseManager.GJACINHCABC().toGlobalMap.IBEIBAHKIAH);
					epmphjgalbe.JDOLCNDNFGP(LocBaseManager.GJACINHCABC().toGlobalMap.ICJDPPOJINN);
					epmphjgalbe.KPCGLGHDILI(LocBaseManager.CHFPAOGEMEM().toGlobalMap.NODLBGKEGPM);
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-50, epmphjgalbe.JOCJNOBBELJ());
				}
				finally
				{
					epmphjgalbe.KNPHNLLMJKJ();
				}
			}
		}
		Vector3 position = this.userCapsule.transform.position;
		if (this.destinationBase != null)
		{
			position = this.destinationBase.transform.position;
			this.mainArrow.gameObject.SetActive(false);
			this.mainArrow.transform.position = this.userCapsule.transform.position;
			this.mainArrow.endPoint.transform.position = this.destinationBase.transform.position;
		}
		else
		{
			this.mainArrow.gameObject.SetActive(true);
		}
		this.markerPosition.position = Vector3.Lerp(this.markerPosition.position, position, Time.deltaTime);
	}

	// Token: 0x06002DE6 RID: 11750 RVA: 0x00152470 File Offset: 0x00150670
	public void MMCDGBHJNMK()
	{
		this.travelMode = GMLogic.PNJNPFOIFCH.Look;
		this.currentBaseID = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.PNEDPPPEFFG;
		this.destinationBaseID = LocBaseManager.EDKKJNHDBPF().toGlobalMap.KEHIFGILLJA();
		this.userCapsule.SetActive(this.travelMode == GMLogic.PNJNPFOIFCH.Look);
		this.HBAONJCBMJP();
		if (this.currentBase != null)
		{
			this.userCapsule.transform.position = this.currentBase.transform.position;
		}
		if (this.baseInfo != null)
		{
			this.baseInfo.text = JNBICAJIJMM.IMLLGEMPHAP().DCANODCKKCG(this.destinationBaseID);
		}
		int num = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BJDIEKNHGLJ(LocBaseManager.AIHINNHNNIA().globalMapTravel.KEHIFGILLJA(), false, 0);
		this.moneyCostTxt.text = string.Format(JNBICAJIJMM.IKGFHGKKCPG.CCFFMKBBKHI("OnTriggerExit"), JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC(1L, (long)LocBaseManager.IKGFHGKKCPG.globalMapTravel.NFCDJLJNDLO(), true));
		this.pripCountTxt.text = string.Format("WATER_REFLECTIVE", LocBaseManager.CHFPAOGEMEM().globalMapTravel.NLHKFMMDMMK(), num);
		LocBaseManager.JGNBBMJLDPM jgnbbmjldpm = LocBaseManager.AIHINNHNNIA().BDIPCNDAABO(this.destinationBaseID);
		if (jgnbbmjldpm != null)
		{
			this.levelTxt.text = string.Format(JNBICAJIJMM.EKEBHIJMEML().HLBAJBLHLNI("Mouse Y"), jgnbbmjldpm.GOEGADLBGML, jgnbbmjldpm.AAKGNCOJCJO);
		}
		else
		{
			this.levelTxt.text = "";
		}
		this.travelBtn.gameObject.SetActive(false);
		this.pripCountTxt.color = Color.green;
		this.moneyCostTxt.color = Color.green;
		this.levelTxt.color = Color.green;
		FlyMessageManager.getI.LNIAHMKKNAK();
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
		if (ObscuredInt.LBDMFALMOLD(kfhelhglnmh.CNOLCNDBLJE) < jgnbbmjldpm.GOEGADLBGML)
		{
			this.travelBtn.gameObject.SetActive(false);
			this.levelTxt.color = Color.red;
			FlyMessageManager.getI.GCIFPMFJMBK(JNBICAJIJMM.IMLLGEMPHAP().ECNKLECOKHD("name"), Color.red, 1, 0);
		}
		if (ObscuredInt.GOOIABGKMHK(kfhelhglnmh.CNOLCNDBLJE) > jgnbbmjldpm.AAKGNCOJCJO)
		{
			this.travelBtn.gameObject.SetActive(false);
			this.levelTxt.color = Color.red;
			FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.EKEBHIJMEML().FLEANFGEJML("gi_tit_sel"), Color.red, 0, 1);
		}
		if (kfhelhglnmh.KFODJJIHNHP < (long)LocBaseManager.GJACINHCABC().globalMapTravel.NFCDJLJNDLO())
		{
			this.travelBtn.gameObject.SetActive(false);
			this.moneyCostTxt.color = Color.red;
			FlyMessageManager.getI.FDHDJFEIOMG(JNBICAJIJMM.IKGFHGKKCPG.DOEMGEAEBPN("_BlurSize"), Color.red, 1, 1);
		}
		if (jgnbbmjldpm.AFCFHGMFCFG > 1 && !FlyMessageManager.getI.HGPJFOGELGH(jgnbbmjldpm.AFCFHGMFCFG))
		{
			this.travelBtn.gameObject.SetActive(true);
			FlyMessageManager.getI.IDCGMMOMKPM(JNBICAJIJMM.APMJBBDBOJO().ECNKLECOKHD("TOD_kSun"), Color.red, 0, 1);
		}
		if (num < LocBaseManager.EDKKJNHDBPF().globalMapTravel.ICJDPPOJINN)
		{
			this.travelBtn.gameObject.SetActive(false);
			this.pripCountTxt.color = Color.red;
			FlyMessageManager.getI.JBBCOOMCOII(JNBICAJIJMM.EDKGBBIIBBC().NLJOLOBPCBJ("CM"), Color.red, 1, 0);
		}
	}

	// Token: 0x04000634 RID: 1588
	public static GMLogic getI;

	// Token: 0x04000635 RID: 1589
	public Text baseInfo;

	// Token: 0x04000636 RID: 1590
	public GMLogic.PNJNPFOIFCH travelMode;

	// Token: 0x04000637 RID: 1591
	public CityScript[] bases;

	// Token: 0x04000638 RID: 1592
	public GameObject userCapsule;

	// Token: 0x04000639 RID: 1593
	public int currentBaseID = 1;

	// Token: 0x0400063A RID: 1594
	public int destinationBaseID = 3;

	// Token: 0x0400063B RID: 1595
	public CityScript currentBase;

	// Token: 0x0400063C RID: 1596
	public CityScript destinationBase;

	// Token: 0x0400063D RID: 1597
	public LinePath mainArrow;

	// Token: 0x0400063E RID: 1598
	public Transform markerPosition;

	// Token: 0x0400063F RID: 1599
	public float moveSpeed = 2f;

	// Token: 0x04000640 RID: 1600
	public Color look_CC_Color;

	// Token: 0x04000641 RID: 1601
	public Color base_CC_Color;

	// Token: 0x04000642 RID: 1602
	public Image pripImage;

	// Token: 0x04000643 RID: 1603
	public Text pripCountTxt;

	// Token: 0x04000644 RID: 1604
	public Text moneyCostTxt;

	// Token: 0x04000645 RID: 1605
	public Text levelTxt;

	// Token: 0x04000646 RID: 1606
	public Button cancelBtn;

	// Token: 0x04000647 RID: 1607
	public Button travelBtn;

	// Token: 0x020000F6 RID: 246
	public enum PNJNPFOIFCH
	{
		// Token: 0x04000649 RID: 1609
		Look,
		// Token: 0x0400064A RID: 1610
		Travel,
		// Token: 0x0400064B RID: 1611
		End
	}
}
