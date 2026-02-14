using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200016D RID: 365
public class DownPanelLogic : MonoBehaviour
{
	// Token: 0x06004E23 RID: 20003 RVA: 0x0023AB14 File Offset: 0x00238D14
	public void PNGBKDOPBCL()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(false);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.PDEFLCIEMFF(1);
			epmphjgalbe.EAOGDKDBENC(168);
			NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(146, epmphjgalbe.IEJLLFECFHF());
		}
		finally
		{
			epmphjgalbe.HDKBMLOJLLC();
		}
	}

	// Token: 0x06004E24 RID: 20004 RVA: 0x0023AB74 File Offset: 0x00238D74
	public void FOBKBHMMLKG(MMKFAENBHKD PAEPDGONGON, ItemBase HEABEPINGED)
	{
		if (PAEPDGONGON == null)
		{
			return;
		}
		if (PAEPDGONGON.NAIIDOFAJKG() < 1)
		{
			return;
		}
		if (PAEPDGONGON.OEAGLNMGGDI() >= PAEPDGONGON.LACAJHOHACK.Count)
		{
			return;
		}
		Debug.Log("_DepthScale");
		int num = (int)HEABEPINGED.tag;
		if (num == ActorMgr.getI.chanellId)
		{
			JDCEFOFMGHB.JFIDAGABKID().CBHHEHHNFKL(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
			Debug.Log("CP0");
			return;
		}
		Fisherman.getI.NEFHFADILLJ(false);
		JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = true;
		base.StartCoroutine(this.GFGMMJNHFMA(num));
		JDCEFOFMGHB.HMJJPNDEKPP().CBHHEHHNFKL(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06004E25 RID: 20005 RVA: 0x0023AC1B File Offset: 0x00238E1B
	private IEnumerator FEGDGFKNFIC(int OEKELPHPKEN)
	{
		DownPanelLogic.NNGMOADAPGG nngmoadapgg = new DownPanelLogic.NNGMOADAPGG(1);
		nngmoadapgg.OEKELPHPKEN = OEKELPHPKEN;
		return nngmoadapgg;
	}

	// Token: 0x06004E26 RID: 20006 RVA: 0x0023AC2C File Offset: 0x00238E2C
	private void AEFGOFJAKDO()
	{
		if (JBEHMPDDMME.PFOLNEGNIPP() != null && JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH != null)
		{
			JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.AHEAJPNHBBB();
		}
		if (Fisherman.getI != null && this.sitButton != null)
		{
			this.sitButton.interactable = Fisherman.getI.isSitEnable;
		}
	}

	// Token: 0x06004E27 RID: 20007 RVA: 0x0023AC90 File Offset: 0x00238E90
	private void OnEnable()
	{
		if (this.chatOpenButton != null)
		{
			this.chatOpenButton.gameObject.SetActive(HPGKIJLKCIH.IKGFHGKKCPG.MKJMAJFLMBJ);
		}
		if (this.infoHelpPanel != null)
		{
			this.infoHelpPanel.gameObject.SetActive(HPGKIJLKCIH.IKGFHGKKCPG.ACNILIHHGNL);
		}
	}

	// Token: 0x06004E28 RID: 20008 RVA: 0x0023ACF0 File Offset: 0x00238EF0
	public void OPMOGLJMPCE(bool HAEEEHGKFMG = false)
	{
		if (HAEEEHGKFMG && this.baseMapObj != null)
		{
			UnityEngine.Object.Destroy(this.baseMapObj);
			this.baseMapObj = null;
			return;
		}
		this.baseMapObj = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("_FogOfWarSize" + JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, GuiProcessor.BBLINJLBAIL().DMHPCBHMNHC());
	}

	// Token: 0x06004E29 RID: 20009 RVA: 0x0023AD5E File Offset: 0x00238F5E
	private IEnumerator KDIHJDCOGNF(int OEKELPHPKEN)
	{
		yield return new WaitForSeconds(1f);
		Debug.Log("to channel = " + OEKELPHPKEN);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(86, OEKELPHPKEN);
		yield break;
	}

	// Token: 0x06004E2A RID: 20010 RVA: 0x0023AD6D File Offset: 0x00238F6D
	public void EFLPFGAIFJB()
	{
		Debug.Log("RussianDance");
		GameInterface.getI.PGHGGGCJMEF(1, true);
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("Point", 1397f);
	}

	// Token: 0x06004E2B RID: 20011 RVA: 0x0023AD9C File Offset: 0x00238F9C
	public void AKPFJEDNIOE(int NBLHDKHCPNK)
	{
		if (this.changeWork)
		{
			return;
		}
		int num = NBLHDKHCPNK % -96;
		int num2 = (int)JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BIHLDHKHPKE("cnt_energ" + num) * 9;
		Debug.Log("demoVector2" + NBLHDKHCPNK);
		Debug.Log("0" + num2);
		base.StartCoroutine(this.MAPGJOOHEHD(NBLHDKHCPNK + num2));
	}

	// Token: 0x06004E2C RID: 20012 RVA: 0x0023AE18 File Offset: 0x00239018
	public void OKAGNGLAIGO(bool HAEEEHGKFMG = false)
	{
		if (HAEEEHGKFMG && MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM > 1 && JDCEFOFMGHB.MNJNNDHCDGG().HILJENLHLDE(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null)
		{
			JDCEFOFMGHB.JFIDAGABKID().KCNBOHEMLCI(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM);
			Debug.Log("DITHERING");
			return;
		}
		MDEKJCCIDIA.IKGFHGKKCPG.EIAHMMNHKAL(null);
		FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("_WrinkleMapBumpScales", 836f);
	}

	// Token: 0x06004E2D RID: 20013 RVA: 0x0023AE89 File Offset: 0x00239089
	public void AKCANJAPGII()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("Assets/Weapons/wbootsBase.unity3d", 1964f);
		NJMHLCGIAJI.EAJGHMMBAFP().AMEOMLNLOGF(33, "Swim");
	}

	// Token: 0x06004E2F RID: 20015 RVA: 0x0023AEB3 File Offset: 0x002390B3
	public void LOECHNOFNOD()
	{
		Debug.Log("GiantGrabIdle");
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("_Curves", 1119f);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(40, "MotorbikeHandlebarSit");
	}

	// Token: 0x06004E30 RID: 20016 RVA: 0x0023AEE4 File Offset: 0x002390E4
	private void DNDBMFDPEDP(Texture2D ILCCFACFLNK)
	{
		if (this.userAvatar != null)
		{
			this.userAvatar.sprite = Sprite.Create(ILCCFACFLNK, new Rect(791f, 603f, (float)ILCCFACFLNK.width, (float)ILCCFACFLNK.height), new Vector2(609f, 1226f));
			this.userAvatar.color = Color.white;
		}
	}

	// Token: 0x06004E31 RID: 20017 RVA: 0x0023AF4C File Offset: 0x0023914C
	public void CHPNDBPOBMH()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MKJMAJFLMBJ = true;
		HPGKIJLKCIH.IKGFHGKKCPG.HMILPFFOPHE();
		Vector2 zero = Vector2.zero;
		zero.x = PlayerPrefs.GetFloat("Add random value");
		zero.y = PlayerPrefs.GetFloat("IK Effector is referencing to a bone '", zero.y);
		ChatPanelLogic.getI.rectTrans.position = zero;
		if (this.chatOpenButton != null)
		{
			this.chatOpenButton.gameObject.SetActive(false);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("<<", 908f);
	}

	// Token: 0x06004E32 RID: 20018 RVA: 0x0023AFE4 File Offset: 0x002391E4
	public void GHCJCJCDHPE()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		Fisherman.getI.CMCPFNJIIHK = !Fisherman.getI.OHKDFALEMNL();
	}

	// Token: 0x06004E33 RID: 20019 RVA: 0x0023B00C File Offset: 0x0023920C
	private void CIBBPIIDHJH()
	{
		if (this.infoHelpPanel != null && Input.GetKeyDown((KeyCode)(-191)))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("ok", 54f);
			if (!this.infoHelpPanel.gameObject.activeSelf)
			{
				this.infoHelpPanel.gameObject.SetActive(true);
			}
		}
		if (this.ORTxt != null)
		{
			this.ORTxt.text = JNBICAJIJMM.EEOPOHEALPK().FLEANFGEJML("_NoiseTex") + JBEHMPDDMME.EAJHPOJPPFA().JBJFBDONEFF;
		}
		if (this.ORProgress != null)
		{
			this.ORProgress.min = 284f;
			this.ORProgress.max = 670f;
			this.ORProgress.position = (float)JBEHMPDDMME.IKGFHGKKCPG.JBJFBDONEFF;
		}
		EDLNGHBMJBL.BEABHKKIDEL beabhkkidel = EDLNGHBMJBL.JMHOODFAGAM().ALCPKMFFBNE();
		if (beabhkkidel != null)
		{
			if (this.radTxt != null)
			{
				this.radTxt.text = string.Concat(beabhkkidel.ANOFHALNEGN);
			}
			if (this.agrTxt != null)
			{
				this.agrTxt.text = string.Concat(beabhkkidel.JDIBHEGKALB);
			}
		}
		if (TimeController.KOJCECHBHLO() != null)
		{
			if (this.clockTxt != null)
			{
				float time = TimeController.IKGFHGKKCPG.time;
				int num = (int)time;
				int num2 = (int)((time - (float)num) * 247f);
				string text = string.Format("PaperTurn.wav", num, num2);
				this.clockTxt.text = text;
			}
			if (this.onlineTxt != null)
			{
				this.onlineTxt.text = (Application.isEditor ? string.Format(JNBICAJIJMM.IKGFHGKKCPG.GNKIBMGNHNE("ShotgunReloadMagazine"), JBEHMPDDMME.PFOLNEGNIPP().MHCCPNFKOKN, JBEHMPDDMME.JKIFIBEPICO().NDLEAJDKPJN) : "Run Back Right");
			}
		}
		if (JBEHMPDDMME.BPPFAOOCENN() != null && JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH != null && this.expBar != null)
		{
			this.expBar.max = (float)JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.GNNDLEAFCND;
			this.expBar.position = (float)JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.MGLOOIONCPM;
		}
		if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH != null)
		{
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
			if (this.money != null)
			{
				this.money.text = JLFJEGIPIMM.NNEAHAFBOHC().MNMIJFNPIPI(1L, kfhelhglnmh.KFODJJIHNHP, false);
			}
			if (this.real != null)
			{
				this.real.text = JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(JBEHMPDDMME.BOKIOJFHNLD().KKNEKAEJLAM, 1L, false);
			}
			if (this.exp != null)
			{
				this.exp.text = string.Concat(kfhelhglnmh.MGLOOIONCPM);
			}
			if (this.Parametr_1 != null)
			{
				this.Parametr_1.min = 709f;
				this.Parametr_1.max = (float)kfhelhglnmh.GPPPGBLEKMF;
				this.Parametr_1.position = kfhelhglnmh.BCINOMMOKJE;
			}
			if (this.Parametr_2 != null)
			{
				this.Parametr_2.min = 834f;
				this.Parametr_2.max = (float)kfhelhglnmh.MOPMCAMIENJ;
				this.Parametr_2.position = kfhelhglnmh.GCLLMNHFMND;
			}
			if (this.Parametr_3 != null)
			{
				this.Parametr_3.min = 1088f;
				this.Parametr_3.max = (float)kfhelhglnmh.JONKLLMGCIF;
				this.Parametr_3.position = kfhelhglnmh.AJHDDHHOHAC;
			}
			if (this.Parametr_4 != null)
			{
				this.Parametr_4.min = 974f;
				this.Parametr_4.max = (float)kfhelhglnmh.OFDBELIILEG;
				this.Parametr_4.position = kfhelhglnmh.ODHFHEBLIJM;
			}
			if (this.Parametr_5 != null)
			{
				this.Parametr_5.min = 1930f;
				this.Parametr_5.max = (float)kfhelhglnmh.LJOPDPNIAEG;
				this.Parametr_5.position = kfhelhglnmh.PMOJDCHIAHE;
			}
		}
	}

	// Token: 0x06004E34 RID: 20020 RVA: 0x0023AD5E File Offset: 0x00238F5E
	private IEnumerator DLBKBABCIID(int OEKELPHPKEN)
	{
		yield return new WaitForSeconds(1f);
		Debug.Log("to channel = " + OEKELPHPKEN);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(86, OEKELPHPKEN);
		yield break;
	}

	// Token: 0x06004E35 RID: 20021 RVA: 0x0023B444 File Offset: 0x00239644
	public void closeInfoPanel()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.7f);
		this.infoHelpPanel.gameObject.SetActive(false);
		HPGKIJLKCIH.IKGFHGKKCPG.ACNILIHHGNL = false;
		HPGKIJLKCIH.IKGFHGKKCPG.PLMCCCMHFKB();
	}

	// Token: 0x06004E36 RID: 20022 RVA: 0x0023B480 File Offset: 0x00239680
	public void EGFLLOFPPOA()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		Fisherman.getI.CMCPFNJIIHK = !Fisherman.getI.CMCPFNJIIHK;
	}

	// Token: 0x06004E37 RID: 20023 RVA: 0x0023B4A7 File Offset: 0x002396A7
	public void CLIMBLOHBGK()
	{
		Debug.Log("");
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("crft_crft", 1361f);
		NJMHLCGIAJI.EAJGHMMBAFP().GDNKCAOHEPL(87, "SUNSHINE_DISABLED");
	}

	// Token: 0x06004E38 RID: 20024 RVA: 0x0023B4D8 File Offset: 0x002396D8
	public void openArtKey()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(450, "?");
	}

	// Token: 0x06004E39 RID: 20025 RVA: 0x0023B50D File Offset: 0x0023970D
	private void FDGKKBGHNIN()
	{
		DownPanelLogic.getI = this;
	}

	// Token: 0x06004E3A RID: 20026 RVA: 0x0023B518 File Offset: 0x00239718
	private void JBEDHHGGNJP(Texture2D ILCCFACFLNK)
	{
		if (this.userAvatar != null)
		{
			this.userAvatar.sprite = Sprite.Create(ILCCFACFLNK, new Rect(1078f, 616f, (float)ILCCFACFLNK.width, (float)ILCCFACFLNK.height), new Vector2(497f, 1716f));
			this.userAvatar.color = Color.white;
		}
	}

	// Token: 0x06004E3B RID: 20027 RVA: 0x0023B580 File Offset: 0x00239780
	public void OpenSadok()
	{
		Debug.Log("OpenSadok");
		GameInterface.getI.openSadok(0, false);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
	}

	// Token: 0x06004E3C RID: 20028 RVA: 0x0023B5AC File Offset: 0x002397AC
	public void MMABDIJOJGG()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("Swim", 1756f);
		this.infoHelpPanel.gameObject.SetActive(true);
		HPGKIJLKCIH.IKGFHGKKCPG.ACNILIHHGNL = false;
		HPGKIJLKCIH.IKGFHGKKCPG.NLOGADGCOGO();
	}

	// Token: 0x06004E3D RID: 20029 RVA: 0x0023B50D File Offset: 0x0023970D
	private void OJDLGCFKCEJ()
	{
		DownPanelLogic.getI = this;
	}

	// Token: 0x06004E3E RID: 20030 RVA: 0x0023B5E8 File Offset: 0x002397E8
	private IEnumerator NBHMIHDCMIB(int CEKJNLLHMMC)
	{
		DownPanelLogic.AFENIECPGOC afeniecpgoc = new DownPanelLogic.AFENIECPGOC(1);
		afeniecpgoc.AENJLLPLILM = this;
		afeniecpgoc.CEKJNLLHMMC = CEKJNLLHMMC;
		return afeniecpgoc;
	}

	// Token: 0x06004E3F RID: 20031 RVA: 0x0023B600 File Offset: 0x00239800
	private void KEMGOLACEHI()
	{
		int nblhdkhcpnk = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.GMLFCKNNOPJ();
		this.OnRodChangeClck(nblhdkhcpnk);
	}

	// Token: 0x06004E40 RID: 20032 RVA: 0x0023B624 File Offset: 0x00239824
	public void MAKNBJKOPGL()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MKJMAJFLMBJ = false;
		HPGKIJLKCIH.IKGFHGKKCPG.OJKPLHEAHGK();
		Vector2 zero = Vector2.zero;
		zero.x = PlayerPrefs.GetFloat("MotorbikeSeatStandWheely");
		zero.y = PlayerPrefs.GetFloat("tintColor", zero.y);
		ChatPanelLogic.getI.rectTrans.position = zero;
		if (this.chatOpenButton != null)
		{
			this.chatOpenButton.gameObject.SetActive(false);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("KatanaReadyHigh", 176f);
	}

	// Token: 0x06004E41 RID: 20033 RVA: 0x0023B6BC File Offset: 0x002398BC
	private IEnumerator JAIFHMIFCCJ(int CEKJNLLHMMC)
	{
		if (Fisherman.getI == null)
		{
			yield return null;
		}
		this.changeWork = true;
		int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KNNKJAEHDHF();
		if (this.btnType_100 != null)
		{
			this.btnType_100.OFGDMJJIOEB = false;
			this.btnType_101.OFGDMJJIOEB = false;
			this.btnType_102.OFGDMJJIOEB = false;
		}
		bool flag = false;
		if (LocNewLogic.getI != null)
		{
			flag = LocNewLogic.getI.panelRoll.isShow;
			LocNewLogic.getI.panelRoll.isShow = false;
		}
		bool isRodOpen = Fisherman.getI.MFENINHGBHM;
		if (num != CEKJNLLHMMC && Fisherman.getI.MFENINHGBHM && num != CEKJNLLHMMC)
		{
			Fisherman.getI.MFENINHGBHM = false;
			yield return new WaitForSeconds(0.1f);
			while (Fisherman.getI.rodObject != null)
			{
				yield return new WaitForSeconds(0.1f);
			}
		}
		Debug.Log("OnRodChangeClck 3 setorder=" + CEKJNLLHMMC);
		JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.JCDBCEEKJPF(CEKJNLLHMMC, -1);
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GLBJBMBBDFK();
		if (LocNewLogic.getI != null && BOIKJDICEMF.IKGFHGKKCPG != null)
		{
			LocNewLogic.getI.updateImages(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP());
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("repair.ogg", 1f);
		this.setSnastImages();
		if (LocNewLogic.getI != null)
		{
			BOIKJDICEMF ikgfhgkkcpg = BOIKJDICEMF.IKGFHGKKCPG;
		}
		if (isRodOpen && BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IKKPFPJLPOL)
		{
			if (LocNewLogic.getI != null && flag)
			{
				LocNewLogic.getI.openSettings();
			}
			Fisherman.getI.MFENINHGBHM = true;
		}
		Debug.Log("OnRodChangeClck 4");
		if (Fisherman.getI.MFENINHGBHM)
		{
			yield return new WaitForSeconds(3f);
		}
		this.changeWork = false;
		Debug.Log("OnRodChangeClck 5");
		yield break;
	}

	// Token: 0x06004E42 RID: 20034 RVA: 0x0023B6D4 File Offset: 0x002398D4
	public void OpenRealShop()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_rcIn.ogg", 0.5f);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(-1);
			epmphjgalbe.NEHCMOODKIN("10");
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1309, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x06004E43 RID: 20035 RVA: 0x0023B748 File Offset: 0x00239948
	public void AFPDOJMCJJJ()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("ShotgunReloadChamber", 176f);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(45, "invn_rec5");
	}

	// Token: 0x06004E44 RID: 20036 RVA: 0x0023B774 File Offset: 0x00239974
	public void OIKGLGHPCAI()
	{
		if (JBEHMPDDMME.IKGFHGKKCPG.PEKHEALPHLD)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("-S", 52f);
			JLFJEGIPIMM.MHFDIJGJGBJ().JOFAKNGHIAD("gi_frac_no", Vector3.zero, GuiProcessor.BBLINJLBAIL().CFAEHFDAGCF());
		}
	}

	// Token: 0x06004E45 RID: 20037 RVA: 0x0023B50D File Offset: 0x0023970D
	private void OGMACADJFIN()
	{
		DownPanelLogic.getI = this;
	}

	// Token: 0x06004E46 RID: 20038 RVA: 0x0023B7C0 File Offset: 0x002399C0
	public void FJOPHGGDCHE()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("<b>ObscuredString:</b> ", 1528f);
		this.infoHelpPanel.gameObject.SetActive(true);
		HPGKIJLKCIH.IKGFHGKKCPG.ACNILIHHGNL = false;
		HPGKIJLKCIH.IKGFHGKKCPG.FIGODKAFCHM();
	}

	// Token: 0x06004E47 RID: 20039 RVA: 0x0023B7FC File Offset: 0x002399FC
	public void GKBNAKPBOAG(int NBLHDKHCPNK)
	{
		if (this.changeWork)
		{
			return;
		}
		int num = NBLHDKHCPNK % -71;
		int num2 = (int)JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BIHLDHKHPKE("IdleRun" + num) * 58;
		Debug.Log("RunBackRight" + NBLHDKHCPNK);
		Debug.Log("Trail" + num2);
		base.StartCoroutine(this.NBHMIHDCMIB(NBLHDKHCPNK + num2));
	}

	// Token: 0x06004E48 RID: 20040 RVA: 0x0023B878 File Offset: 0x00239A78
	public void CBFEGKIBBMF()
	{
		if (JBEHMPDDMME.EAJHPOJPPFA().PEKHEALPHLD)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("offsets", 127f);
			JLFJEGIPIMM.IKGFHGKKCPG.OMPJLOEGMII("_Offsets", Vector3.zero, GuiProcessor.BBLINJLBAIL().NBMOILGEJIP());
		}
	}

	// Token: 0x06004E49 RID: 20041 RVA: 0x0023B8C4 File Offset: 0x00239AC4
	private void MNBENPDFCME(Texture2D ILCCFACFLNK)
	{
		if (this.userAvatar != null)
		{
			this.userAvatar.sprite = Sprite.Create(ILCCFACFLNK, new Rect(1574f, 1638f, (float)ILCCFACFLNK.width, (float)ILCCFACFLNK.height), new Vector2(591f, 247f));
			this.userAvatar.color = Color.white;
		}
	}

	// Token: 0x06004E4A RID: 20042 RVA: 0x0023B92C File Offset: 0x00239B2C
	public void setSnastImages()
	{
		int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GMLFCKNNOPJ();
		if (this.btnType_100 != null)
		{
			this.btnType_100.OFGDMJJIOEB = false;
			this.btnType_101.OFGDMJJIOEB = false;
			this.btnType_102.OFGDMJJIOEB = false;
			if (num == 100)
			{
				this.btnType_100.OFGDMJJIOEB = true;
			}
			if (num == 101)
			{
				this.btnType_101.OFGDMJJIOEB = true;
			}
			if (num == 102)
			{
				this.btnType_102.OFGDMJJIOEB = true;
			}
			if (num == 100)
			{
				this.rodBtn.sprite = this.texBtn_100;
			}
			if (num == 101)
			{
				this.rodBtn.sprite = this.texBtn_101;
			}
			if (num == 102)
			{
				this.rodBtn.sprite = this.texBtn_102;
			}
		}
	}

	// Token: 0x06004E4B RID: 20043 RVA: 0x0023B9F4 File Offset: 0x00239BF4
	public void BACOIMJBJEN(bool HAEEEHGKFMG = false)
	{
		if (HAEEEHGKFMG && MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM > 1 && JDCEFOFMGHB.HMJJPNDEKPP().IJAEDDCCNHG(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().BMOFIBGMIBK(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM);
			Debug.Log("MotorbikeWheely");
			return;
		}
		MDEKJCCIDIA.IKGFHGKKCPG.IFADELLPHJP(null);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("ActorFish", 1503f);
	}

	// Token: 0x06004E4C RID: 20044 RVA: 0x0023BA68 File Offset: 0x00239C68
	public void OpenSiteShop()
	{
		if (JBEHMPDDMME.IKGFHGKKCPG.PEKHEALPHLD)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_rcIn.ogg", 0.2f);
			JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("StShopWindow", Vector3.zero, GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA);
			return;
		}
		Application.OpenURL("http://af-2.ru/?q=store");
	}

	// Token: 0x06004E4D RID: 20045 RVA: 0x0023BABF File Offset: 0x00239CBF
	public void HNEKNAKMHOF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("spinKvok activate", 1581f);
		this.infoHelpPanel.gameObject.SetActive(false);
		HPGKIJLKCIH.IKGFHGKKCPG.ACNILIHHGNL = false;
		HPGKIJLKCIH.IKGFHGKKCPG.BNJGIFNJIFK();
	}

	// Token: 0x06004E4E RID: 20046 RVA: 0x0023BAFC File Offset: 0x00239CFC
	public void KACOIOHIGJF(bool HAEEEHGKFMG = false)
	{
		if (HAEEEHGKFMG && this.baseMapObj != null)
		{
			UnityEngine.Object.Destroy(this.baseMapObj);
			this.baseMapObj = null;
			return;
		}
		this.baseMapObj = JLFJEGIPIMM.PKGMBFEMKGP().OMPJLOEGMII("ObscuredString vs string, " + JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, GuiProcessor.NKOEAPCIBKO().PBBAIBBHMHG());
	}

	// Token: 0x06004E4F RID: 20047 RVA: 0x0023BB6A File Offset: 0x00239D6A
	public void openVIPWindow()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_rcIn.ogg", 0.5f);
		JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("WinVIP", Vector3.zero, GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA);
	}

	// Token: 0x06004E50 RID: 20048 RVA: 0x0023BB9F File Offset: 0x00239D9F
	public void PFODIMCJAAF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("WandStand", 1331f);
		JLFJEGIPIMM.PKGMBFEMKGP().JOFAKNGHIAD("WorkerPickaxe2", Vector3.zero, GuiProcessor.NKOEAPCIBKO().OODKDLPBAIP());
	}

	// Token: 0x06004E51 RID: 20049 RVA: 0x0023BBD4 File Offset: 0x00239DD4
	public void FIILGMFMKKL()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("", 1982f);
		JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(true);
		NJMHLCGIAJI.IKGFHGKKCPG.AMEOMLNLOGF(-85, "inv_minreq");
	}

	// Token: 0x06004E52 RID: 20050 RVA: 0x0023BC0C File Offset: 0x00239E0C
	private void ELFMPDIGDLJ()
	{
		if (JBEHMPDDMME.PLGADNLAEGN() != null && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.EMNMOMGOBPI();
		}
		if (Fisherman.getI != null && this.sitButton != null)
		{
			this.sitButton.interactable = Fisherman.getI.isSitEnable;
		}
	}

	// Token: 0x06004E53 RID: 20051 RVA: 0x0023BC70 File Offset: 0x00239E70
	public void OpenBaseMap(bool HAEEEHGKFMG = false)
	{
		if (HAEEEHGKFMG && this.baseMapObj != null)
		{
			UnityEngine.Object.Destroy(this.baseMapObj);
			this.baseMapObj = null;
			return;
		}
		this.baseMapObj = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("UI_MapWindow_b" + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA);
	}

	// Token: 0x06004E54 RID: 20052 RVA: 0x0023AFE4 File Offset: 0x002391E4
	public void MDCODMOHJLD()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		Fisherman.getI.CMCPFNJIIHK = !Fisherman.getI.OHKDFALEMNL();
	}

	// Token: 0x06004E55 RID: 20053 RVA: 0x0023BCE0 File Offset: 0x00239EE0
	private void FIJKDFIMELM()
	{
		int nblhdkhcpnk = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GMLFCKNNOPJ();
		this.EODNMBBBEDI(nblhdkhcpnk);
	}

	// Token: 0x06004E56 RID: 20054 RVA: 0x0023BD04 File Offset: 0x00239F04
	public void selectChannelButton()
	{
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(85, 0);
	}

	// Token: 0x06004E57 RID: 20055 RVA: 0x0023BD14 File Offset: 0x00239F14
	public void PHCEDCCMMKF()
	{
		int num = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.GMLFCKNNOPJ();
		if (this.btnType_100 != null)
		{
			this.btnType_100.FPKBNIACJKB(false);
			this.btnType_101.CFECAGFDPLN(false);
			this.btnType_102.GLCBKINJCIO(true);
			if (num == 9)
			{
				this.btnType_100.DCAAOABBCLH(true);
			}
			if (num == 33)
			{
				this.btnType_101.IAPOPLALICP(false);
			}
			if (num == 18)
			{
				this.btnType_102.APHMGAIEIKA(true);
			}
			if (num == -58)
			{
				this.rodBtn.sprite = this.texBtn_100;
			}
			if (num == 44)
			{
				this.rodBtn.sprite = this.texBtn_101;
			}
			if (num == -65)
			{
				this.rodBtn.sprite = this.texBtn_102;
			}
		}
	}

	// Token: 0x06004E58 RID: 20056 RVA: 0x0023BDDB File Offset: 0x00239FDB
	public void LCBNPOAPBPO()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("none id=", 877f);
		NJMHLCGIAJI.EAJGHMMBAFP().OGHNHCDABDO(-7, "IdleButtonPress");
	}

	// Token: 0x06004E59 RID: 20057 RVA: 0x0023B50D File Offset: 0x0023970D
	private void KHKDKMMHJBK()
	{
		DownPanelLogic.getI = this;
	}

	// Token: 0x06004E5A RID: 20058 RVA: 0x0023BE08 File Offset: 0x0023A008
	public void PLCDFCFJEBC(int NBLHDKHCPNK)
	{
		if (this.changeWork)
		{
			return;
		}
		int num = NBLHDKHCPNK % -76;
		int num2 = (int)JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.MHIIBKILGBL("Turn" + num) * 28;
		Debug.Log("DealerIdle" + NBLHDKHCPNK);
		Debug.Log("Unarmed" + num2);
		base.StartCoroutine(this.EEIEGGMGOKF(NBLHDKHCPNK + num2));
	}

	// Token: 0x06004E5B RID: 20059 RVA: 0x0023BE84 File Offset: 0x0023A084
	private void LDPMGHPICGB(Texture2D ILCCFACFLNK)
	{
		if (this.userAvatar != null)
		{
			this.userAvatar.sprite = Sprite.Create(ILCCFACFLNK, new Rect(1996f, 933f, (float)ILCCFACFLNK.width, (float)ILCCFACFLNK.height), new Vector2(1994f, 385f));
			this.userAvatar.color = Color.white;
		}
	}

	// Token: 0x06004E5C RID: 20060 RVA: 0x0023BEEC File Offset: 0x0023A0EC
	public void NFKLLICOGJD(bool HAEEEHGKFMG = false)
	{
		if (HAEEEHGKFMG && MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM > 0 && JDCEFOFMGHB.JFIDAGABKID().HILJENLHLDE(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().KCNBOHEMLCI(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM);
			Debug.Log("' that does not excist in the Node Chain.");
			return;
		}
		MDEKJCCIDIA.IKGFHGKKCPG.EIAHMMNHKAL(null);
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("<color='#a0ff60'>", 1676f);
	}

	// Token: 0x06004E5D RID: 20061 RVA: 0x0023BF5D File Offset: 0x0023A15D
	public void BPOEFDMPJAA()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		Fisherman.getI.CMCPFNJIIHK = !Fisherman.getI.KPIPJGKANCD();
	}

	// Token: 0x06004E5E RID: 20062 RVA: 0x0023BF84 File Offset: 0x0023A184
	private void KBMKHLDOIKP()
	{
		if (this.infoHelpPanel != null && Input.GetKeyDown((KeyCode)157))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("4", 825f);
			if (!this.infoHelpPanel.gameObject.activeSelf)
			{
				this.infoHelpPanel.gameObject.SetActive(false);
			}
		}
		if (this.ORTxt != null)
		{
			this.ORTxt.text = JNBICAJIJMM.EDKGBBIIBBC().GNKIBMGNHNE("enableFog") + JBEHMPDDMME.NPCAKEGNBHD().JBJFBDONEFF;
		}
		if (this.ORProgress != null)
		{
			this.ORProgress.min = 1413f;
			this.ORProgress.max = 1289f;
			this.ORProgress.position = (float)JBEHMPDDMME.BPPFAOOCENN().JBJFBDONEFF;
		}
		EDLNGHBMJBL.BEABHKKIDEL beabhkkidel = EDLNGHBMJBL.IKGFHGKKCPG.AADJMFJMAGF;
		if (beabhkkidel != null)
		{
			if (this.radTxt != null)
			{
				this.radTxt.text = string.Concat(beabhkkidel.ANOFHALNEGN);
			}
			if (this.agrTxt != null)
			{
				this.agrTxt.text = string.Concat(beabhkkidel.JDIBHEGKALB);
			}
		}
		if (TimeController.IKGFHGKKCPG != null)
		{
			if (this.clockTxt != null)
			{
				float time = TimeController.BOBNPEAEECC().time;
				int num = (int)time;
				int num2 = (int)((time - (float)num) * 8f);
				string text = string.Format("no_model_fish ", num, num2);
				this.clockTxt.text = text;
			}
			if (this.onlineTxt != null)
			{
				this.onlineTxt.text = (Application.isEditor ? string.Format(JNBICAJIJMM.EKEBHIJMEML().CKAOHMEKLMH("MotorbikeIdle"), JBEHMPDDMME.PFOLNEGNIPP().MHCCPNFKOKN, JBEHMPDDMME.EAJHPOJPPFA().NDLEAJDKPJN) : "[Z]");
			}
		}
		if (JBEHMPDDMME.BOKIOJFHNLD() != null && JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH != null && this.expBar != null)
		{
			this.expBar.max = (float)JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.GNNDLEAFCND;
			this.expBar.position = (float)JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.MGLOOIONCPM;
		}
		if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH != null)
		{
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
			if (this.money != null)
			{
				this.money.text = JLFJEGIPIMM.MHFDIJGJGBJ().OHNLAOJGCGC(0L, kfhelhglnmh.KFODJJIHNHP, false);
			}
			if (this.real != null)
			{
				this.real.text = JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(JBEHMPDDMME.IKGFHGKKCPG.KKNEKAEJLAM, 1L, false);
			}
			if (this.exp != null)
			{
				this.exp.text = string.Concat(kfhelhglnmh.MGLOOIONCPM);
			}
			if (this.Parametr_1 != null)
			{
				this.Parametr_1.min = 292f;
				this.Parametr_1.max = (float)kfhelhglnmh.GPPPGBLEKMF;
				this.Parametr_1.position = kfhelhglnmh.BCINOMMOKJE;
			}
			if (this.Parametr_2 != null)
			{
				this.Parametr_2.min = 1838f;
				this.Parametr_2.max = (float)kfhelhglnmh.MOPMCAMIENJ;
				this.Parametr_2.position = kfhelhglnmh.GCLLMNHFMND;
			}
			if (this.Parametr_3 != null)
			{
				this.Parametr_3.min = 89f;
				this.Parametr_3.max = (float)kfhelhglnmh.JONKLLMGCIF;
				this.Parametr_3.position = kfhelhglnmh.AJHDDHHOHAC;
			}
			if (this.Parametr_4 != null)
			{
				this.Parametr_4.min = 905f;
				this.Parametr_4.max = (float)kfhelhglnmh.OFDBELIILEG;
				this.Parametr_4.position = kfhelhglnmh.ODHFHEBLIJM;
			}
			if (this.Parametr_5 != null)
			{
				this.Parametr_5.min = 966f;
				this.Parametr_5.max = (float)kfhelhglnmh.LJOPDPNIAEG;
				this.Parametr_5.position = kfhelhglnmh.PMOJDCHIAHE;
			}
		}
	}

	// Token: 0x06004E5F RID: 20063 RVA: 0x0023C3BC File Offset: 0x0023A5BC
	public void EHMJLNNNEGK()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = true;
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("Warp index out of range.", 1740f);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.ENDMKPCFKND(-1);
			epmphjgalbe.LCFJAKKMCFN("#mem Sound ");
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-37, epmphjgalbe.NNEAJJNCGMK());
		}
		finally
		{
			epmphjgalbe.PMIGGJHLIDO();
		}
	}

	// Token: 0x06004E60 RID: 20064 RVA: 0x0023C430 File Offset: 0x0023A630
	public void DDJHLFEEEDI(int NBLHDKHCPNK)
	{
		if (this.changeWork)
		{
			return;
		}
		int num = NBLHDKHCPNK % 58;
		int num2 = (int)JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.MHIIBKILGBL("FOG_SCATTERING_ON" + num) * -64;
		Debug.Log("IdleWalk" + NBLHDKHCPNK);
		Debug.Log("Low adminlevel!" + num2);
		base.StartCoroutine(this.JMMEKOAGGPD(NBLHDKHCPNK + num2));
	}

	// Token: 0x06004E61 RID: 20065 RVA: 0x0023C4AB File Offset: 0x0023A6AB
	public void NAHCAFFKOBF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("", 1915f);
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = true;
		NJMHLCGIAJI.EAJGHMMBAFP().OGHNHCDABDO(-118, "auk_wset");
	}

	// Token: 0x06004E62 RID: 20066 RVA: 0x0023C4E0 File Offset: 0x0023A6E0
	public void IBNDBFBPHMK()
	{
		int num = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.GMLFCKNNOPJ();
		if (this.btnType_100 != null)
		{
			this.btnType_100.KLOLNJGKDKD(false);
			this.btnType_101.JFNJCEGPNJA(true);
			this.btnType_102.IAPOPLALICP(true);
			if (num == 86)
			{
				this.btnType_100.OFGDMJJIOEB = true;
			}
			if (num == 6)
			{
				this.btnType_101.AMGJDPOPFGO(false);
			}
			if (num == -12)
			{
				this.btnType_102.GHCOOCKLPLN(false);
			}
			if (num == 112)
			{
				this.rodBtn.sprite = this.texBtn_100;
			}
			if (num == -128)
			{
				this.rodBtn.sprite = this.texBtn_101;
			}
			if (num == 39)
			{
				this.rodBtn.sprite = this.texBtn_102;
			}
		}
	}

	// Token: 0x06004E63 RID: 20067 RVA: 0x0023B6BC File Offset: 0x002398BC
	private IEnumerator DBHBECLJIAP(int CEKJNLLHMMC)
	{
		if (Fisherman.getI == null)
		{
			yield return null;
		}
		this.changeWork = true;
		int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KNNKJAEHDHF();
		if (this.btnType_100 != null)
		{
			this.btnType_100.OFGDMJJIOEB = false;
			this.btnType_101.OFGDMJJIOEB = false;
			this.btnType_102.OFGDMJJIOEB = false;
		}
		flag = false;
		if (LocNewLogic.getI != null)
		{
			flag = LocNewLogic.getI.panelRoll.isShow;
			LocNewLogic.getI.panelRoll.isShow = false;
		}
		isRodOpen = Fisherman.getI.MFENINHGBHM;
		if (num != CEKJNLLHMMC && Fisherman.getI.MFENINHGBHM && num != CEKJNLLHMMC)
		{
			Fisherman.getI.MFENINHGBHM = false;
			yield return new WaitForSeconds(0.1f);
			while (Fisherman.getI.rodObject != null)
			{
				yield return new WaitForSeconds(0.1f);
			}
		}
		Debug.Log("OnRodChangeClck 3 setorder=" + CEKJNLLHMMC);
		JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.JCDBCEEKJPF(CEKJNLLHMMC, -1);
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GLBJBMBBDFK();
		if (LocNewLogic.getI != null && BOIKJDICEMF.IKGFHGKKCPG != null)
		{
			LocNewLogic.getI.updateImages(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP());
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("repair.ogg", 1f);
		this.setSnastImages();
		if (LocNewLogic.getI != null)
		{
			BOIKJDICEMF ikgfhgkkcpg = BOIKJDICEMF.IKGFHGKKCPG;
		}
		if (isRodOpen && BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IKKPFPJLPOL)
		{
			if (LocNewLogic.getI != null && flag)
			{
				LocNewLogic.getI.openSettings();
			}
			Fisherman.getI.MFENINHGBHM = true;
		}
		Debug.Log("OnRodChangeClck 4");
		if (Fisherman.getI.MFENINHGBHM)
		{
			yield return new WaitForSeconds(3f);
		}
		this.changeWork = false;
		Debug.Log("OnRodChangeClck 5");
		yield break;
	}

	// Token: 0x06004E64 RID: 20068 RVA: 0x0023C5A8 File Offset: 0x0023A7A8
	public void OnRodChangeClck(int NBLHDKHCPNK)
	{
		if (this.changeWork)
		{
			return;
		}
		int num = NBLHDKHCPNK % 100;
		int num2 = (int)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MHIIBKILGBL("act_orderb_" + num) * 100;
		Debug.Log("OnRodChangeClck toorder=" + NBLHDKHCPNK);
		Debug.Log("OnRodChangeClck order_check=" + num2);
		base.StartCoroutine(this.EEIEGGMGOKF(NBLHDKHCPNK + num2));
	}

	// Token: 0x06004E65 RID: 20069 RVA: 0x0023C623 File Offset: 0x0023A823
	public void AHENDALJGAF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("", 14f);
		NJMHLCGIAJI.IKGFHGKKCPG.BNJEMPKFNLA(-137, "ui_default_close.wav");
	}

	// Token: 0x06004E66 RID: 20070 RVA: 0x0023C64D File Offset: 0x0023A84D
	public void NGCMOJAHBDN()
	{
		Debug.Log("13");
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("_Intensity", 1417f);
		NJMHLCGIAJI.EAJGHMMBAFP().AMEOMLNLOGF(3, "UNIQUE_SHADOW_LIGHT_COOKIE");
	}

	// Token: 0x06004E67 RID: 20071 RVA: 0x0023C680 File Offset: 0x0023A880
	public void DAKOEIDLBBP()
	{
		if (JBEHMPDDMME.BPPFAOOCENN().PEKHEALPHLD)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("StrafeRunRight", 1561f);
			JLFJEGIPIMM.IKGFHGKKCPG.JOFAKNGHIAD("Mouse ScrollWheel", Vector3.zero, GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA);
		}
	}

	// Token: 0x06004E68 RID: 20072 RVA: 0x0023C6CC File Offset: 0x0023A8CC
	public void AIAJFDNKEJG()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.KPCGLGHDILI(1);
			epmphjgalbe.JDOLCNDNFGP(-199);
			NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(38, epmphjgalbe.ALLANCHILCM());
		}
		finally
		{
			epmphjgalbe.PGLFHABMJPO();
		}
	}

	// Token: 0x06004E69 RID: 20073 RVA: 0x0023C72C File Offset: 0x0023A92C
	public void OpenRecords()
	{
		Debug.Log("OpenRecords");
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(32, "?");
	}

	// Token: 0x06004E6A RID: 20074 RVA: 0x0023C75D File Offset: 0x0023A95D
	public void LIPBABMAOMO()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("FactoryTempTexture", 580f);
		this.infoHelpPanel.gameObject.SetActive(false);
		HPGKIJLKCIH.IKGFHGKKCPG.ACNILIHHGNL = true;
		HPGKIJLKCIH.IKGFHGKKCPG.EGPNLJNEAEA();
	}

	// Token: 0x06004E6B RID: 20075 RVA: 0x0023C799 File Offset: 0x0023A999
	public void OpenAuki()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(330, "?");
	}

	// Token: 0x06004E6C RID: 20076 RVA: 0x0023C7C4 File Offset: 0x0023A9C4
	private void OPDCJCFMIPE()
	{
		if (this.infoHelpPanel != null && Input.GetKeyDown((KeyCode)85))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("3", 1850f);
			if (!this.infoHelpPanel.gameObject.activeSelf)
			{
				this.infoHelpPanel.gameObject.SetActive(true);
			}
		}
		if (this.ORTxt != null)
		{
			this.ORTxt.text = JNBICAJIJMM.CLIMNFDGOEG().FLEANFGEJML("Image Effects are not supported on this platform.") + JBEHMPDDMME.BPPFAOOCENN().JBJFBDONEFF;
		}
		if (this.ORProgress != null)
		{
			this.ORProgress.min = 1384f;
			this.ORProgress.max = 198f;
			this.ORProgress.position = (float)JBEHMPDDMME.IKGFHGKKCPG.JBJFBDONEFF;
		}
		EDLNGHBMJBL.BEABHKKIDEL beabhkkidel = EDLNGHBMJBL.FEJILBICKGG().ALCPKMFFBNE();
		if (beabhkkidel != null)
		{
			if (this.radTxt != null)
			{
				this.radTxt.text = string.Concat(beabhkkidel.ANOFHALNEGN);
			}
			if (this.agrTxt != null)
			{
				this.agrTxt.text = string.Concat(beabhkkidel.JDIBHEGKALB);
			}
		}
		if (TimeController.BOBNPEAEECC() != null)
		{
			if (this.clockTxt != null)
			{
				float time = TimeController.BOBNPEAEECC().time;
				int num = (int)time;
				int num2 = (int)((time - (float)num) * 663f);
				string text = string.Format("WeaponReload", num, num2);
				this.clockTxt.text = text;
			}
			if (this.onlineTxt != null)
			{
				this.onlineTxt.text = (Application.isEditor ? string.Format(JNBICAJIJMM.LPHMKPDBMPP().HLBAJBLHLNI("/"), JBEHMPDDMME.PFOLNEGNIPP().MHCCPNFKOKN, JBEHMPDDMME.JKIFIBEPICO().NDLEAJDKPJN) : "PrimaryCausticsProjector");
			}
		}
		if (JBEHMPDDMME.PFOLNEGNIPP() != null && JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH != null && this.expBar != null)
		{
			this.expBar.max = (float)JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.GNNDLEAFCND;
			this.expBar.position = (float)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MGLOOIONCPM;
		}
		if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH != null)
		{
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
			if (this.money != null)
			{
				this.money.text = JLFJEGIPIMM.MHFDIJGJGBJ().MNMIJFNPIPI(1L, kfhelhglnmh.KFODJJIHNHP, true);
			}
			if (this.real != null)
			{
				this.real.text = JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(JBEHMPDDMME.NPCAKEGNBHD().KKNEKAEJLAM, 0L, false);
			}
			if (this.exp != null)
			{
				this.exp.text = string.Concat(kfhelhglnmh.MGLOOIONCPM);
			}
			if (this.Parametr_1 != null)
			{
				this.Parametr_1.min = 1328f;
				this.Parametr_1.max = (float)kfhelhglnmh.GPPPGBLEKMF;
				this.Parametr_1.position = kfhelhglnmh.BCINOMMOKJE;
			}
			if (this.Parametr_2 != null)
			{
				this.Parametr_2.min = 726f;
				this.Parametr_2.max = (float)kfhelhglnmh.MOPMCAMIENJ;
				this.Parametr_2.position = kfhelhglnmh.GCLLMNHFMND;
			}
			if (this.Parametr_3 != null)
			{
				this.Parametr_3.min = 554f;
				this.Parametr_3.max = (float)kfhelhglnmh.JONKLLMGCIF;
				this.Parametr_3.position = kfhelhglnmh.AJHDDHHOHAC;
			}
			if (this.Parametr_4 != null)
			{
				this.Parametr_4.min = 1879f;
				this.Parametr_4.max = (float)kfhelhglnmh.OFDBELIILEG;
				this.Parametr_4.position = kfhelhglnmh.ODHFHEBLIJM;
			}
			if (this.Parametr_5 != null)
			{
				this.Parametr_5.min = 727f;
				this.Parametr_5.max = (float)kfhelhglnmh.LJOPDPNIAEG;
				this.Parametr_5.position = kfhelhglnmh.PMOJDCHIAHE;
			}
		}
	}

	// Token: 0x06004E6D RID: 20077 RVA: 0x0023CBFC File Offset: 0x0023ADFC
	public void FHLHPEIMIFL()
	{
		Debug.Log("UphillWalk Hand Grab");
		GameInterface.getI.FKLEDJOGPEF(1, false);
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("http://www.root-motion.com/finalikdox/html/page7.html", 1579f);
	}

	// Token: 0x06004E6E RID: 20078 RVA: 0x0023CC28 File Offset: 0x0023AE28
	private void Update()
	{
		if (this.infoHelpPanel != null && Input.GetKeyDown(KeyCode.F1))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_rcIn.ogg", 0.1f);
			if (!this.infoHelpPanel.gameObject.activeSelf)
			{
				this.infoHelpPanel.gameObject.SetActive(true);
			}
		}
		if (this.ORTxt != null)
		{
			this.ORTxt.text = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wplabel") + JBEHMPDDMME.IKGFHGKKCPG.JBJFBDONEFF;
		}
		if (this.ORProgress != null)
		{
			this.ORProgress.min = 0f;
			this.ORProgress.max = 3000f;
			this.ORProgress.position = (float)JBEHMPDDMME.IKGFHGKKCPG.JBJFBDONEFF;
		}
		EDLNGHBMJBL.BEABHKKIDEL beabhkkidel = EDLNGHBMJBL.IKGFHGKKCPG.AADJMFJMAGF;
		if (beabhkkidel != null)
		{
			if (this.radTxt != null)
			{
				this.radTxt.text = string.Concat(beabhkkidel.ANOFHALNEGN);
			}
			if (this.agrTxt != null)
			{
				this.agrTxt.text = string.Concat(beabhkkidel.JDIBHEGKALB);
			}
		}
		if (TimeController.IKGFHGKKCPG != null)
		{
			if (this.clockTxt != null)
			{
				float time = TimeController.IKGFHGKKCPG.time;
				int num = (int)time;
				int num2 = (int)((time - (float)num) * 60f);
				string text = string.Format("{0:00} : {1:00}", num, num2);
				this.clockTxt.text = text;
			}
			if (this.onlineTxt != null)
			{
				this.onlineTxt.text = (Application.isEditor ? string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("usercntinfo"), JBEHMPDDMME.IKGFHGKKCPG.MHCCPNFKOKN, JBEHMPDDMME.IKGFHGKKCPG.NDLEAJDKPJN) : "");
			}
		}
		if (JBEHMPDDMME.IKGFHGKKCPG != null && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null && this.expBar != null)
		{
			this.expBar.max = (float)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GNNDLEAFCND;
			this.expBar.position = (float)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MGLOOIONCPM;
		}
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
			if (this.money != null)
			{
				this.money.text = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, kfhelhglnmh.KFODJJIHNHP, true);
			}
			if (this.real != null)
			{
				this.real.text = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(JBEHMPDDMME.IKGFHGKKCPG.KKNEKAEJLAM, 0L, true);
			}
			if (this.exp != null)
			{
				this.exp.text = string.Concat(kfhelhglnmh.MGLOOIONCPM);
			}
			if (this.Parametr_1 != null)
			{
				this.Parametr_1.min = 0f;
				this.Parametr_1.max = (float)kfhelhglnmh.GPPPGBLEKMF;
				this.Parametr_1.position = kfhelhglnmh.BCINOMMOKJE;
			}
			if (this.Parametr_2 != null)
			{
				this.Parametr_2.min = 0f;
				this.Parametr_2.max = (float)kfhelhglnmh.MOPMCAMIENJ;
				this.Parametr_2.position = kfhelhglnmh.GCLLMNHFMND;
			}
			if (this.Parametr_3 != null)
			{
				this.Parametr_3.min = 0f;
				this.Parametr_3.max = (float)kfhelhglnmh.JONKLLMGCIF;
				this.Parametr_3.position = kfhelhglnmh.AJHDDHHOHAC;
			}
			if (this.Parametr_4 != null)
			{
				this.Parametr_4.min = 0f;
				this.Parametr_4.max = (float)kfhelhglnmh.OFDBELIILEG;
				this.Parametr_4.position = kfhelhglnmh.ODHFHEBLIJM;
			}
			if (this.Parametr_5 != null)
			{
				this.Parametr_5.min = 0f;
				this.Parametr_5.max = (float)kfhelhglnmh.LJOPDPNIAEG;
				this.Parametr_5.position = kfhelhglnmh.PMOJDCHIAHE;
			}
		}
	}

	// Token: 0x06004E6F RID: 20079 RVA: 0x0023D060 File Offset: 0x0023B260
	public void KLBLMLOCDEN(bool HAEEEHGKFMG = false)
	{
		if (HAEEEHGKFMG && MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM > 0 && JDCEFOFMGHB.MNJNNDHCDGG().CHPPAAAAJFC(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().KCNBOHEMLCI(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM);
			Debug.Log("ProneLocomotion");
			return;
		}
		MDEKJCCIDIA.IKGFHGKKCPG.IFADELLPHJP(null);
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("RunBackLeft", 290f);
	}

	// Token: 0x06004E70 RID: 20080 RVA: 0x0023D0D4 File Offset: 0x0023B2D4
	public void ELLJJDKJKJM()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MKJMAJFLMBJ = false;
		HPGKIJLKCIH.IKGFHGKKCPG.BNJGIFNJIFK();
		Vector2 zero = Vector2.zero;
		zero.x = PlayerPrefs.GetFloat("selectTitulId=");
		zero.y = PlayerPrefs.GetFloat("wpn_eat6", zero.y);
		ChatPanelLogic.getI.rectTrans.position = zero;
		if (this.chatOpenButton != null)
		{
			this.chatOpenButton.gameObject.SetActive(false);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("Adjust", 1798f);
	}

	// Token: 0x06004E71 RID: 20081 RVA: 0x0023D16C File Offset: 0x0023B36C
	public void HAHEPKOOJDE()
	{
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(25, 0);
	}

	// Token: 0x06004E72 RID: 20082 RVA: 0x0023D17B File Offset: 0x0023B37B
	public void HBGMFEFONDI()
	{
		NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(-21, 1);
	}

	// Token: 0x06004E73 RID: 20083 RVA: 0x0023D18C File Offset: 0x0023B38C
	private void OBJCOJEHLBE()
	{
		int nblhdkhcpnk = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.GMLFCKNNOPJ();
		this.FGLJAIFHALA(nblhdkhcpnk);
	}

	// Token: 0x06004E74 RID: 20084 RVA: 0x0023D1B0 File Offset: 0x0023B3B0
	public void LFDPIGMLFAC()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(true);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.FLLJONHPLNA(0);
			epmphjgalbe.LHLOOIDHGMA(-186);
			NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(-172, epmphjgalbe.ALLANCHILCM());
		}
		finally
		{
			epmphjgalbe.KNPHNLLMJKJ();
		}
	}

	// Token: 0x06004E75 RID: 20085 RVA: 0x0023D210 File Offset: 0x0023B410
	public void NOBPPJOABFC()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MKJMAJFLMBJ = false;
		HPGKIJLKCIH.IKGFHGKKCPG.HMILPFFOPHE();
		Vector2 zero = Vector2.zero;
		zero.x = PlayerPrefs.GetFloat("WATER_VERTEX_DISPLACEMENT_OFF");
		zero.y = PlayerPrefs.GetFloat("", zero.y);
		ChatPanelLogic.getI.rectTrans.position = zero;
		if (this.chatOpenButton != null)
		{
			this.chatOpenButton.gameObject.SetActive(true);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("WalkInjured", 1925f);
	}

	// Token: 0x06004E76 RID: 20086 RVA: 0x0023B6BC File Offset: 0x002398BC
	private IEnumerator MAPGJOOHEHD(int CEKJNLLHMMC)
	{
		if (Fisherman.getI == null)
		{
			yield return null;
		}
		this.changeWork = true;
		int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KNNKJAEHDHF();
		if (this.btnType_100 != null)
		{
			this.btnType_100.OFGDMJJIOEB = false;
			this.btnType_101.OFGDMJJIOEB = false;
			this.btnType_102.OFGDMJJIOEB = false;
		}
		flag = false;
		if (LocNewLogic.getI != null)
		{
			flag = LocNewLogic.getI.panelRoll.isShow;
			LocNewLogic.getI.panelRoll.isShow = false;
		}
		isRodOpen = Fisherman.getI.MFENINHGBHM;
		if (num != CEKJNLLHMMC && Fisherman.getI.MFENINHGBHM && num != CEKJNLLHMMC)
		{
			Fisherman.getI.MFENINHGBHM = false;
			yield return new WaitForSeconds(0.1f);
			while (Fisherman.getI.rodObject != null)
			{
				yield return new WaitForSeconds(0.1f);
			}
		}
		Debug.Log("OnRodChangeClck 3 setorder=" + CEKJNLLHMMC);
		JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.JCDBCEEKJPF(CEKJNLLHMMC, -1);
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GLBJBMBBDFK();
		if (LocNewLogic.getI != null && BOIKJDICEMF.IKGFHGKKCPG != null)
		{
			LocNewLogic.getI.updateImages(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP());
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("repair.ogg", 1f);
		this.setSnastImages();
		if (LocNewLogic.getI != null)
		{
			BOIKJDICEMF ikgfhgkkcpg = BOIKJDICEMF.IKGFHGKKCPG;
		}
		if (isRodOpen && BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IKKPFPJLPOL)
		{
			if (LocNewLogic.getI != null && flag)
			{
				LocNewLogic.getI.openSettings();
			}
			Fisherman.getI.MFENINHGBHM = true;
		}
		Debug.Log("OnRodChangeClck 4");
		if (Fisherman.getI.MFENINHGBHM)
		{
			yield return new WaitForSeconds(3f);
		}
		this.changeWork = false;
		Debug.Log("OnRodChangeClck 5");
		yield break;
	}

	// Token: 0x06004E77 RID: 20087 RVA: 0x0023D2A8 File Offset: 0x0023B4A8
	public void HHMNLGANCGP()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("gi_um_7", 398f);
		JLFJEGIPIMM.PKGMBFEMKGP().OMPJLOEGMII("_Lift", Vector3.zero, GuiProcessor.NKOEAPCIBKO().CFAEHFDAGCF());
	}

	// Token: 0x06004E78 RID: 20088 RVA: 0x0023D2DD File Offset: 0x0023B4DD
	public void OIAGOHIEDNA()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("TOD_k4PI", 275f);
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
		NJMHLCGIAJI.IKGFHGKKCPG.OGHNHCDABDO(108, "\n");
	}

	// Token: 0x06004E79 RID: 20089 RVA: 0x0023D312 File Offset: 0x0023B512
	public void MDPJCMIDCNK()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		Fisherman.getI.CMCPFNJIIHK = Fisherman.getI.KPIPJGKANCD();
	}

	// Token: 0x06004E7A RID: 20090 RVA: 0x0023AC1B File Offset: 0x00238E1B
	private IEnumerator GFGMMJNHFMA(int OEKELPHPKEN)
	{
		DownPanelLogic.NNGMOADAPGG nngmoadapgg = new DownPanelLogic.NNGMOADAPGG(1);
		nngmoadapgg.OEKELPHPKEN = OEKELPHPKEN;
		return nngmoadapgg;
	}

	// Token: 0x06004E7B RID: 20091 RVA: 0x0023D339 File Offset: 0x0023B539
	public void LJNLCABEECF()
	{
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(98, 0);
	}

	// Token: 0x06004E7C RID: 20092 RVA: 0x0023D348 File Offset: 0x0023B548
	public void AFEMNJFFNCO(int NBLHDKHCPNK)
	{
		if (this.changeWork)
		{
			return;
		}
		int num = NBLHDKHCPNK % -5;
		int num2 = (int)JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BIHLDHKHPKE("selpersbtn" + num) * -8;
		Debug.Log("_FogNoiseData" + NBLHDKHCPNK);
		Debug.Log("isMutant" + num2);
		base.StartCoroutine(this.EEIEGGMGOKF(NBLHDKHCPNK + num2));
	}

	// Token: 0x06004E7D RID: 20093 RVA: 0x0023D3C3 File Offset: 0x0023B5C3
	public void ADCDEMDOFPP()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("name", 439f);
		this.infoHelpPanel.gameObject.SetActive(false);
		HPGKIJLKCIH.IKGFHGKKCPG.ACNILIHHGNL = true;
		HPGKIJLKCIH.IKGFHGKKCPG.GHNBEEEHDPM();
	}

	// Token: 0x06004E7E RID: 20094 RVA: 0x0023D400 File Offset: 0x0023B600
	public void OpenInventory(bool HAEEEHGKFMG = false)
	{
		if (HAEEEHGKFMG && MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM > 0 && JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM);
			Debug.Log("inv already open");
			return;
		}
		MDEKJCCIDIA.IKGFHGKKCPG.EIAHMMNHKAL(null);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
	}

	// Token: 0x06004E7F RID: 20095 RVA: 0x0023B50D File Offset: 0x0023970D
	private void IKLNHNBELJB()
	{
		DownPanelLogic.getI = this;
	}

	// Token: 0x06004E80 RID: 20096 RVA: 0x0023D471 File Offset: 0x0023B671
	public void CJDHEKGBNDM()
	{
		Debug.Log("Aim Transform unassigned in Aim IK solver. Please Assign a Transform (lineal descendant to the last bone in the spine) that you want to be aimed at IKPosition");
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("minWgtBait", 178f);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(36, "_Grain_Params1");
	}

	// Token: 0x06004E81 RID: 20097 RVA: 0x0023D4A2 File Offset: 0x0023B6A2
	public void AHPKNOHBLEC()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("OPEN CONSTRUCT", 828f);
		NJMHLCGIAJI.EAJGHMMBAFP().GDNKCAOHEPL(175, "Idle Come Here");
	}

	// Token: 0x06004E82 RID: 20098 RVA: 0x0023AFE4 File Offset: 0x002391E4
	public void IAJOMJFADCI()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		Fisherman.getI.CMCPFNJIIHK = !Fisherman.getI.OHKDFALEMNL();
	}

	// Token: 0x06004E83 RID: 20099 RVA: 0x0023D4CC File Offset: 0x0023B6CC
	private void ACLJDJBJLCD()
	{
		int nblhdkhcpnk = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GMLFCKNNOPJ();
		this.EODNMBBBEDI(nblhdkhcpnk);
	}

	// Token: 0x06004E84 RID: 20100 RVA: 0x0023D4F0 File Offset: 0x0023B6F0
	public void FDJMMOOOMOA()
	{
		NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(-7, 1);
	}

	// Token: 0x06004E85 RID: 20101 RVA: 0x0023D500 File Offset: 0x0023B700
	private void OnGUI()
	{
		if (JBEHMPDDMME.IKGFHGKKCPG != null && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.ANFHJIIMJNL();
		}
		if (Fisherman.getI != null && this.sitButton != null)
		{
			this.sitButton.interactable = Fisherman.getI.isSitEnable;
		}
	}

	// Token: 0x06004E86 RID: 20102 RVA: 0x0023B50D File Offset: 0x0023970D
	private void Awake()
	{
		DownPanelLogic.getI = this;
	}

	// Token: 0x06004E87 RID: 20103 RVA: 0x0023D564 File Offset: 0x0023B764
	private void KKCFKEDABLB()
	{
		int nblhdkhcpnk = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.GMLFCKNNOPJ();
		this.DDJHLFEEEDI(nblhdkhcpnk);
	}

	// Token: 0x06004E88 RID: 20104 RVA: 0x0023D588 File Offset: 0x0023B788
	public void openChatPanel()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MKJMAJFLMBJ = false;
		HPGKIJLKCIH.IKGFHGKKCPG.PLMCCCMHFKB();
		Vector2 zero = Vector2.zero;
		zero.x = PlayerPrefs.GetFloat("choldposx");
		zero.y = PlayerPrefs.GetFloat("choldposy", zero.y);
		ChatPanelLogic.getI.rectTrans.position = zero;
		if (this.chatOpenButton != null)
		{
			this.chatOpenButton.gameObject.SetActive(false);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 0.7f);
	}

	// Token: 0x06004E89 RID: 20105 RVA: 0x0023D620 File Offset: 0x0023B820
	private void LFBEAPKIGJJ(Texture2D ILCCFACFLNK)
	{
		if (this.userAvatar != null)
		{
			this.userAvatar.sprite = Sprite.Create(ILCCFACFLNK, new Rect(0f, 0f, (float)ILCCFACFLNK.width, (float)ILCCFACFLNK.height), new Vector2(1f, 1f));
			this.userAvatar.color = Color.white;
		}
	}

	// Token: 0x06004E8A RID: 20106 RVA: 0x0023D688 File Offset: 0x0023B888
	public void JLPFMHBGGMM()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.ALNEALEKFNB(1);
			epmphjgalbe.GOMLLPFFPNP(-115);
			NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(-52, epmphjgalbe.JOCJNOBBELJ());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x06004E8B RID: 20107 RVA: 0x0023D6E8 File Offset: 0x0023B8E8
	public void JELPCKBCEKN()
	{
		int num = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GMLFCKNNOPJ();
		if (this.btnType_100 != null)
		{
			this.btnType_100.HABMDELHCIF(false);
			this.btnType_101.HHGNLFDILPO(false);
			this.btnType_102.CFECAGFDPLN(true);
			if (num == 63)
			{
				this.btnType_100.HHGNLFDILPO(false);
			}
			if (num == -102)
			{
				this.btnType_101.JAHJGBOEJJI(true);
			}
			if (num == -97)
			{
				this.btnType_102.EOKPJBEJMGC(true);
			}
			if (num == -85)
			{
				this.rodBtn.sprite = this.texBtn_100;
			}
			if (num == 77)
			{
				this.rodBtn.sprite = this.texBtn_101;
			}
			if (num == 56)
			{
				this.rodBtn.sprite = this.texBtn_102;
			}
		}
	}

	// Token: 0x06004E8C RID: 20108 RVA: 0x0023D7AF File Offset: 0x0023B9AF
	public void EICNIPMNKNI()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		Fisherman.getI.CMCPFNJIIHK = Fisherman.getI.OHKDFALEMNL();
	}

	// Token: 0x06004E8D RID: 20109 RVA: 0x0023B50D File Offset: 0x0023970D
	private void JMNLEBAPHNJ()
	{
		DownPanelLogic.getI = this;
	}

	// Token: 0x06004E8E RID: 20110 RVA: 0x0023D7D8 File Offset: 0x0023B9D8
	public void BAAKOAHMDFL()
	{
		JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(false);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.ALNEALEKFNB(1);
			epmphjgalbe.PDEFLCIEMFF(-39);
			NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-159, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.BKKEFKANGIM();
		}
	}

	// Token: 0x06004E8F RID: 20111 RVA: 0x0023D838 File Offset: 0x0023BA38
	public void LEBEOKIBNKG()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("IdleSadHips", 641f);
		NJMHLCGIAJI.EAJGHMMBAFP().AMEOMLNLOGF(59, "implevel");
	}

	// Token: 0x06004E90 RID: 20112 RVA: 0x0023D862 File Offset: 0x0023BA62
	public void DCJNGGDHKLA()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("Card Player Look", 1122f);
		NJMHLCGIAJI.IKGFHGKKCPG.AMEOMLNLOGF(179, "_LerpAmount");
	}

	// Token: 0x06004E91 RID: 20113 RVA: 0x0023D88C File Offset: 0x0023BA8C
	public void HNONAFMDNMN()
	{
		if (JBEHMPDDMME.BPPFAOOCENN().PEKHEALPHLD)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("money2.wav", 92f);
			JLFJEGIPIMM.PKGMBFEMKGP().JOFAKNGHIAD("Arm", Vector3.zero, GuiProcessor.IKGFHGKKCPG.OODKDLPBAIP());
		}
	}

	// Token: 0x06004E92 RID: 20114 RVA: 0x0023D8D8 File Offset: 0x0023BAD8
	public void NALBBJEKKPO()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		Fisherman.getI.CMCPFNJIIHK = Fisherman.getI.CMCPFNJIIHK;
	}

	// Token: 0x06004E93 RID: 20115 RVA: 0x0023D900 File Offset: 0x0023BB00
	public void CHPNCKDAMAP()
	{
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = true;
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", 1626f);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.AEMAHNDEBKJ(-1);
			epmphjgalbe.NMPPIONANIB("PaperTurn.wav");
			NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(-109, epmphjgalbe.ALLANCHILCM());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x06004E94 RID: 20116 RVA: 0x0023D974 File Offset: 0x0023BB74
	public void PJDNFNCDOPI()
	{
		if (JBEHMPDDMME.BOKIOJFHNLD().PEKHEALPHLD)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("Look Up", 1336f);
			JLFJEGIPIMM.IKGFHGKKCPG.OMPJLOEGMII("OnEvent: Unknow Event", Vector3.zero, GuiProcessor.NKOEAPCIBKO().CFAEHFDAGCF());
			return;
		}
		Application.OpenURL("Player");
	}

	// Token: 0x06004E95 RID: 20117 RVA: 0x0023D7AF File Offset: 0x0023B9AF
	public void CJBEMNNECIB()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		Fisherman.getI.CMCPFNJIIHK = Fisherman.getI.OHKDFALEMNL();
	}

	// Token: 0x06004E96 RID: 20118 RVA: 0x0023D9CB File Offset: 0x0023BBCB
	public void EJBMNNDGPCE()
	{
		Debug.Log("CheerJump");
		GameInterface.getI.ABBDLICDJEK(0, true);
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("_CustomUVS", 891f);
	}

	// Token: 0x06004E97 RID: 20119 RVA: 0x0023D9F8 File Offset: 0x0023BBF8
	private void NCJEPBACGLJ(Texture2D ILCCFACFLNK)
	{
		if (this.userAvatar != null)
		{
			this.userAvatar.sprite = Sprite.Create(ILCCFACFLNK, new Rect(1985f, 615f, (float)ILCCFACFLNK.width, (float)ILCCFACFLNK.height), new Vector2(52f, 1229f));
			this.userAvatar.color = Color.white;
		}
	}

	// Token: 0x06004E98 RID: 20120 RVA: 0x0023B6BC File Offset: 0x002398BC
	private IEnumerator EEIEGGMGOKF(int CEKJNLLHMMC)
	{
		if (Fisherman.getI == null)
		{
			yield return null;
		}
		this.changeWork = true;
		int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KNNKJAEHDHF();
		if (this.btnType_100 != null)
		{
			this.btnType_100.OFGDMJJIOEB = false;
			this.btnType_101.OFGDMJJIOEB = false;
			this.btnType_102.OFGDMJJIOEB = false;
		}
		flag = false;
		if (LocNewLogic.getI != null)
		{
			flag = LocNewLogic.getI.panelRoll.isShow;
			LocNewLogic.getI.panelRoll.isShow = false;
		}
		isRodOpen = Fisherman.getI.MFENINHGBHM;
		if (num != CEKJNLLHMMC && Fisherman.getI.MFENINHGBHM && num != CEKJNLLHMMC)
		{
			Fisherman.getI.MFENINHGBHM = false;
			yield return new WaitForSeconds(0.1f);
			while (Fisherman.getI.rodObject != null)
			{
				yield return new WaitForSeconds(0.1f);
			}
		}
		Debug.Log("OnRodChangeClck 3 setorder=" + CEKJNLLHMMC);
		JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.JCDBCEEKJPF(CEKJNLLHMMC, -1);
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GLBJBMBBDFK();
		if (LocNewLogic.getI != null && BOIKJDICEMF.IKGFHGKKCPG != null)
		{
			LocNewLogic.getI.updateImages(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP());
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("repair.ogg", 1f);
		this.setSnastImages();
		if (LocNewLogic.getI != null)
		{
			BOIKJDICEMF ikgfhgkkcpg = BOIKJDICEMF.IKGFHGKKCPG;
		}
		if (isRodOpen && BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().IKKPFPJLPOL)
		{
			if (LocNewLogic.getI != null && flag)
			{
				LocNewLogic.getI.openSettings();
			}
			Fisherman.getI.MFENINHGBHM = true;
		}
		Debug.Log("OnRodChangeClck 4");
		if (Fisherman.getI.MFENINHGBHM)
		{
			yield return new WaitForSeconds(3f);
		}
		this.changeWork = false;
		Debug.Log("OnRodChangeClck 5");
		yield break;
	}

	// Token: 0x06004E99 RID: 20121 RVA: 0x0023DA60 File Offset: 0x0023BC60
	public void LJGEBLOALKM()
	{
		NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(68, 0);
	}

	// Token: 0x06004E9A RID: 20122 RVA: 0x0023DA70 File Offset: 0x0023BC70
	public void EODNMBBBEDI(int NBLHDKHCPNK)
	{
		if (this.changeWork)
		{
			return;
		}
		int num = NBLHDKHCPNK % -55;
		int num2 = (int)JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BIHLDHKHPKE("droplinemsg1" + num) * 59;
		Debug.Log("WATER_VERTEX_DISPLACEMENT_OFF" + NBLHDKHCPNK);
		Debug.Log("1 Hand Sword Shield Bash" + num2);
		base.StartCoroutine(this.NBHMIHDCMIB(NBLHDKHCPNK + num2));
	}

	// Token: 0x06004E9B RID: 20123 RVA: 0x0023B5E8 File Offset: 0x002397E8
	private IEnumerator JMMEKOAGGPD(int CEKJNLLHMMC)
	{
		DownPanelLogic.AFENIECPGOC afeniecpgoc = new DownPanelLogic.AFENIECPGOC(1);
		afeniecpgoc.AENJLLPLILM = this;
		afeniecpgoc.CEKJNLLHMMC = CEKJNLLHMMC;
		return afeniecpgoc;
	}

	// Token: 0x06004E9C RID: 20124 RVA: 0x0023B480 File Offset: 0x00239680
	public void sitChange()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		Fisherman.getI.CMCPFNJIIHK = !Fisherman.getI.CMCPFNJIIHK;
	}

	// Token: 0x06004E9D RID: 20125 RVA: 0x0023DAEC File Offset: 0x0023BCEC
	public void OADHAHFPGGG()
	{
		if (JBEHMPDDMME.NPCAKEGNBHD().PEKHEALPHLD)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("readActorData", 545f);
			JLFJEGIPIMM.NNEAHAFBOHC().OMPJLOEGMII("_BlurredColor", Vector3.zero, GuiProcessor.BBLINJLBAIL().NBMOILGEJIP());
			return;
		}
		Application.OpenURL(" ");
	}

	// Token: 0x06004E9E RID: 20126 RVA: 0x0023DB44 File Offset: 0x0023BD44
	public void PFBJMDCKNMI(MMKFAENBHKD PAEPDGONGON, ItemBase HEABEPINGED)
	{
		if (PAEPDGONGON == null)
		{
			return;
		}
		if (PAEPDGONGON.BMOEEJCBDJO() < 0)
		{
			return;
		}
		if (PAEPDGONGON.LPENOBCEAPP() >= PAEPDGONGON.LACAJHOHACK.Count)
		{
			return;
		}
		Debug.Log("1HSwordStrafeRunLeft");
		int num = (int)HEABEPINGED.tag;
		if (num == ActorMgr.getI.chanellId)
		{
			JDCEFOFMGHB.JFIDAGABKID().DGFAPDDBHJB(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
			Debug.Log("Jump");
			return;
		}
		Fisherman.getI.MFENINHGBHM = false;
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = true;
		base.StartCoroutine(this.DDKEHGPAHPF(num));
		JDCEFOFMGHB.HMJJPNDEKPP().KCNBOHEMLCI(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06004E9F RID: 20127 RVA: 0x0023DBEB File Offset: 0x0023BDEB
	public void CJNBFJAAKDK()
	{
		Debug.Log("Move around with WASD or cursor keys, space to jump");
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("", 1406f);
		NJMHLCGIAJI.EAJGHMMBAFP().AMEOMLNLOGF(-124, "ara_trail_mesh");
	}

	// Token: 0x06004EA0 RID: 20128 RVA: 0x0023AD5E File Offset: 0x00238F5E
	private IEnumerator DDKEHGPAHPF(int OEKELPHPKEN)
	{
		yield return new WaitForSeconds(1f);
		Debug.Log("to channel = " + OEKELPHPKEN);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(86, OEKELPHPKEN);
		yield break;
	}

	// Token: 0x06004EA1 RID: 20129 RVA: 0x0023DC1C File Offset: 0x0023BE1C
	public void FGLJAIFHALA(int NBLHDKHCPNK)
	{
		if (this.changeWork)
		{
			return;
		}
		int num = NBLHDKHCPNK % -93;
		int num2 = (int)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BIHLDHKHPKE("UNDISTORT" + num) * 68;
		Debug.Log("Additive effector positionOffset detected in Full Body IK (extremely large value). Make sure you are not circularily adding to effector positionOffset each frame." + NBLHDKHCPNK);
		Debug.Log("Fish is init!" + num2);
		base.StartCoroutine(this.EEIEGGMGOKF(NBLHDKHCPNK + num2));
	}

	// Token: 0x06004EA2 RID: 20130 RVA: 0x0023DC98 File Offset: 0x0023BE98
	public void BAMNIIAOLNO()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = false;
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Delete Weapon", 1345f);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.PDEFLCIEMFF(-1);
			epmphjgalbe.BNPGKHHADEH("Horizontal");
			NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-171, epmphjgalbe.IEJLLFECFHF());
		}
		finally
		{
			epmphjgalbe.HDKBMLOJLLC();
		}
	}

	// Token: 0x06004EA3 RID: 20131 RVA: 0x0023DD0C File Offset: 0x0023BF0C
	private void CKGPEFOKKNL()
	{
		int nblhdkhcpnk = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.GMLFCKNNOPJ();
		this.OnRodChangeClck(nblhdkhcpnk);
	}

	// Token: 0x06004EA4 RID: 20132 RVA: 0x0023DD30 File Offset: 0x0023BF30
	public void NLBKIKLKHNJ()
	{
		NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(-9, 1);
	}

	// Token: 0x06004EA5 RID: 20133 RVA: 0x0023DD3F File Offset: 0x0023BF3F
	public void BPKBBKGALLD()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP(" not found", 1628f);
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(182, "wpn_book2");
	}

	// Token: 0x06004EA6 RID: 20134 RVA: 0x0023DD6C File Offset: 0x0023BF6C
	public void AHOEIIJKMHE(MMKFAENBHKD PAEPDGONGON, ItemBase HEABEPINGED)
	{
		if (PAEPDGONGON == null)
		{
			return;
		}
		if (PAEPDGONGON.DEFBLKPDLPM() < 1)
		{
			return;
		}
		if (PAEPDGONGON.FJNDDAMCLFL() >= PAEPDGONGON.LACAJHOHACK.Count)
		{
			return;
		}
		Debug.Log(" ");
		int num = (int)HEABEPINGED.tag;
		if (num == ActorMgr.getI.chanellId)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.KCNBOHEMLCI(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
			Debug.Log("{2:D2}:{0:D2}:{1:D2}");
			return;
		}
		Fisherman.getI.MFENINHGBHM = false;
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		base.StartCoroutine(this.GFGMMJNHFMA(num));
		JDCEFOFMGHB.MNJNNDHCDGG().CBHHEHHNFKL(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06004EA7 RID: 20135 RVA: 0x0023DE13 File Offset: 0x0023C013
	public void ANADFLPLACP()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("RodParams not found!", 231f);
		JLFJEGIPIMM.IKGFHGKKCPG.JOFAKNGHIAD("Loser", Vector3.zero, GuiProcessor.PLGADNLAEGN().OODKDLPBAIP());
	}

	// Token: 0x06004EA8 RID: 20136 RVA: 0x0023DE48 File Offset: 0x0023C048
	public void GIDKGJFPKDF(bool HAEEEHGKFMG = false)
	{
		if (HAEEEHGKFMG && MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM > 0 && JDCEFOFMGHB.JFIDAGABKID().IHNMOJHBMNJ(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().DGFAPDDBHJB(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM);
			Debug.Log("INTERFACE");
			return;
		}
		MDEKJCCIDIA.IKGFHGKKCPG.IFADELLPHJP(null);
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("** Panel save position", 1073f);
	}

	// Token: 0x06004EA9 RID: 20137 RVA: 0x0023DEB9 File Offset: 0x0023C0B9
	public void BIHFALFMIOG()
	{
		Debug.Log("gameComplete");
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("_ChannelMixerGreen", 923f);
		NJMHLCGIAJI.IKGFHGKKCPG.BNJEMPKFNLA(106, " msg=");
	}

	// Token: 0x06004EAA RID: 20138 RVA: 0x0023D8D8 File Offset: 0x0023BAD8
	public void PHKPNAKGABI()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		Fisherman.getI.CMCPFNJIIHK = Fisherman.getI.CMCPFNJIIHK;
	}

	// Token: 0x06004EAB RID: 20139 RVA: 0x0023DEEA File Offset: 0x0023C0EA
	public void IBGBGGLGBPJ()
	{
		Debug.Log("\n");
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("OnGround", 1436f);
		NJMHLCGIAJI.IKGFHGKKCPG.AMEOMLNLOGF(77, "rollSoundIndex");
	}

	// Token: 0x06004EAC RID: 20140 RVA: 0x0023DF1C File Offset: 0x0023C11C
	public void openCollections()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(0);
			epmphjgalbe.GOMLLPFFPNP(1000);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1700, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x06004EAD RID: 20141 RVA: 0x0023AFE4 File Offset: 0x002391E4
	public void GKNFCMOJBNC()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		Fisherman.getI.CMCPFNJIIHK = !Fisherman.getI.OHKDFALEMNL();
	}

	// Token: 0x06004EAE RID: 20142 RVA: 0x0023AFE4 File Offset: 0x002391E4
	public void LJOEKBPPDDM()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		Fisherman.getI.CMCPFNJIIHK = !Fisherman.getI.OHKDFALEMNL();
	}

	// Token: 0x06004EAF RID: 20143 RVA: 0x0023DF7C File Offset: 0x0023C17C
	public void FFJNBDMFBDN(int NBLHDKHCPNK)
	{
		if (this.changeWork)
		{
			return;
		}
		int num = NBLHDKHCPNK % 53;
		int num2 = (int)JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BIHLDHKHPKE("OK aukKeyMEditOk" + num) * 60;
		Debug.Log("_VelocityScale" + NBLHDKHCPNK);
		Debug.Log("WorkerHammer" + num2);
		base.StartCoroutine(this.NBHMIHDCMIB(NBLHDKHCPNK + num2));
	}

	// Token: 0x06004EB0 RID: 20144 RVA: 0x0023DFF7 File Offset: 0x0023C1F7
	public void MJGGKMKDLPK()
	{
		Debug.Log("post_4");
		GameInterface.getI.ABBDLICDJEK(0, false);
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("One of the Reach Cones in the polygon has negative volume. Make sure Axis vector is in the reachable area and the polygon is convex.", 915f);
	}

	// Token: 0x06004EB1 RID: 20145 RVA: 0x0023E023 File Offset: 0x0023C223
	public void KHKGHDHELIO()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("_VignetteSettings", 793f);
		JLFJEGIPIMM.PKGMBFEMKGP().LMFEHHFPAAA("cht_msg20", Vector3.zero, GuiProcessor.BBLINJLBAIL().DMHPCBHMNHC());
	}

	// Token: 0x06004EB2 RID: 20146 RVA: 0x0023E058 File Offset: 0x0023C258
	public void changeChannel(MMKFAENBHKD PAEPDGONGON, ItemBase HEABEPINGED)
	{
		if (PAEPDGONGON == null)
		{
			return;
		}
		if (PAEPDGONGON.IHEILFHMLAG < 0)
		{
			return;
		}
		if (PAEPDGONGON.IHEILFHMLAG >= PAEPDGONGON.LACAJHOHACK.Count)
		{
			return;
		}
		Debug.Log("change channel press");
		int num = (int)HEABEPINGED.tag;
		if (num == ActorMgr.getI.chanellId)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
			Debug.Log("change channek close");
			return;
		}
		Fisherman.getI.MFENINHGBHM = false;
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		base.StartCoroutine(this.DLBKBABCIID(num));
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(PAEPDGONGON.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06004EB3 RID: 20147 RVA: 0x0023E100 File Offset: 0x0023C300
	private void BMNJGPIPKLL()
	{
		int nblhdkhcpnk = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.GMLFCKNNOPJ();
		this.FGLJAIFHALA(nblhdkhcpnk);
	}

	// Token: 0x06004EB4 RID: 20148 RVA: 0x0023E124 File Offset: 0x0023C324
	public void DGFHLLLGJEC()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("MotorbikeLookBack", 553f);
		this.infoHelpPanel.gameObject.SetActive(true);
		HPGKIJLKCIH.IKGFHGKKCPG.ACNILIHHGNL = false;
		HPGKIJLKCIH.IKGFHGKKCPG.ABHIJHKJPCC();
	}

	// Token: 0x06004EB5 RID: 20149 RVA: 0x0023E160 File Offset: 0x0023C360
	public void NBCENDFMCBH(bool HAEEEHGKFMG = false)
	{
		if (HAEEEHGKFMG && this.baseMapObj != null)
		{
			UnityEngine.Object.Destroy(this.baseMapObj);
			this.baseMapObj = null;
			return;
		}
		this.baseMapObj = JLFJEGIPIMM.MHFDIJGJGBJ().DAJFMBBDJIC("No fish in fishModelData modelid=" + JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.PNEDPPPEFFG, Vector3.zero, GuiProcessor.IKGFHGKKCPG.IHFGNALNJOG());
	}

	// Token: 0x06004EB6 RID: 20150 RVA: 0x0023E1D0 File Offset: 0x0023C3D0
	public void OpenPacketShop()
	{
		if (JBEHMPDDMME.IKGFHGKKCPG.PEKHEALPHLD)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_rcIn.ogg", 0.2f);
			JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("StShopPacketWin", Vector3.zero, GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA);
		}
	}

	// Token: 0x06004EB7 RID: 20151 RVA: 0x0023E21C File Offset: 0x0023C41C
	public void JNCPKNJAIME()
	{
		int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GMLFCKNNOPJ();
		if (this.btnType_100 != null)
		{
			this.btnType_100.EOKPJBEJMGC(true);
			this.btnType_101.CPFICGIAENB(false);
			this.btnType_102.EJPBDPMDGBC(false);
			if (num == 67)
			{
				this.btnType_100.GLCBKINJCIO(false);
			}
			if (num == -29)
			{
				this.btnType_101.JAHJGBOEJJI(false);
			}
			if (num == -71)
			{
				this.btnType_102.HHGNLFDILPO(true);
			}
			if (num == 102)
			{
				this.rodBtn.sprite = this.texBtn_100;
			}
			if (num == -63)
			{
				this.rodBtn.sprite = this.texBtn_101;
			}
			if (num == 75)
			{
				this.rodBtn.sprite = this.texBtn_102;
			}
		}
	}

	// Token: 0x06004EB8 RID: 20152 RVA: 0x0023E2E4 File Offset: 0x0023C4E4
	public void FBMECPKMFKA()
	{
		JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(false);
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("_FogNoiseData", 1938f);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(-1);
			epmphjgalbe.BNPGKHHADEH("drag_onmousedown.wav");
			NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(52, epmphjgalbe.PBOPEDMCKDD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x06004EB9 RID: 20153 RVA: 0x0023E358 File Offset: 0x0023C558
	private void HBENPJJDNOC(Texture2D ILCCFACFLNK)
	{
		if (this.userAvatar != null)
		{
			this.userAvatar.sprite = Sprite.Create(ILCCFACFLNK, new Rect(1512f, 1749f, (float)ILCCFACFLNK.width, (float)ILCCFACFLNK.height), new Vector2(857f, 384f));
			this.userAvatar.color = Color.white;
		}
	}

	// Token: 0x06004EBA RID: 20154 RVA: 0x0023AD5E File Offset: 0x00238F5E
	private IEnumerator EHGIKKOKNKG(int OEKELPHPKEN)
	{
		yield return new WaitForSeconds(1f);
		Debug.Log("to channel = " + OEKELPHPKEN);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(86, OEKELPHPKEN);
		yield break;
	}

	// Token: 0x06004EBB RID: 20155 RVA: 0x0023B480 File Offset: 0x00239680
	public void PAKIOFEAHJJ()
	{
		if (Fisherman.getI == null)
		{
			return;
		}
		Fisherman.getI.CMCPFNJIIHK = !Fisherman.getI.CMCPFNJIIHK;
	}

	// Token: 0x06004EBC RID: 20156 RVA: 0x0023E3C0 File Offset: 0x0023C5C0
	private void CLEONAEHLON()
	{
		if (JBEHMPDDMME.EAJHPOJPPFA() != null && JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH != null)
		{
			JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.KBEOAOKBHEK();
		}
		if (Fisherman.getI != null && this.sitButton != null)
		{
			this.sitButton.interactable = Fisherman.getI.isSitEnable;
		}
	}

	// Token: 0x06004EBD RID: 20157 RVA: 0x0023B50D File Offset: 0x0023970D
	private void PFKOLCOAPCN()
	{
		DownPanelLogic.getI = this;
	}

	// Token: 0x06004EBE RID: 20158 RVA: 0x0023E424 File Offset: 0x0023C624
	public void JPIPMHPMFJI()
	{
		JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(false);
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("Assets/Hairs/hair_", 272f);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.AEMAHNDEBKJ(-1);
			epmphjgalbe.HGCCFFKDELO("inv_inv");
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(127, epmphjgalbe.ALLANCHILCM());
		}
		finally
		{
			epmphjgalbe.BKKEFKANGIM();
		}
	}

	// Token: 0x06004EBF RID: 20159 RVA: 0x0023E498 File Offset: 0x0023C698
	private void Start()
	{
		int nblhdkhcpnk = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GMLFCKNNOPJ();
		this.OnRodChangeClck(nblhdkhcpnk);
	}

	// Token: 0x04000BB7 RID: 2999
	public RectTransform infoHelpPanel;

	// Token: 0x04000BB8 RID: 3000
	public static DownPanelLogic getI;

	// Token: 0x04000BB9 RID: 3001
	public RectTransform chatOpenButton;

	// Token: 0x04000BBA RID: 3002
	public Text ORTxt;

	// Token: 0x04000BBB RID: 3003
	public ProgressBar ORProgress;

	// Token: 0x04000BBC RID: 3004
	public Color polNormalColor;

	// Token: 0x04000BBD RID: 3005
	public Color polDangerColor;

	// Token: 0x04000BBE RID: 3006
	public Image userAvatar;

	// Token: 0x04000BBF RID: 3007
	public Button sitButton;

	// Token: 0x04000BC0 RID: 3008
	public Text clockTxt;

	// Token: 0x04000BC1 RID: 3009
	public Text onlineTxt;

	// Token: 0x04000BC2 RID: 3010
	public Text radTxt;

	// Token: 0x04000BC3 RID: 3011
	public Text agrTxt;

	// Token: 0x04000BC4 RID: 3012
	public Text chanellText;

	// Token: 0x04000BC5 RID: 3013
	public ProgressBar expBar;

	// Token: 0x04000BC6 RID: 3014
	public ProgressBar Parametr_1;

	// Token: 0x04000BC7 RID: 3015
	public ProgressBar Parametr_2;

	// Token: 0x04000BC8 RID: 3016
	public ProgressBar Parametr_3;

	// Token: 0x04000BC9 RID: 3017
	public ProgressBar Parametr_4;

	// Token: 0x04000BCA RID: 3018
	public ProgressBar Parametr_5;

	// Token: 0x04000BCB RID: 3019
	public Text money;

	// Token: 0x04000BCC RID: 3020
	public Text real;

	// Token: 0x04000BCD RID: 3021
	public Text exp;

	// Token: 0x04000BCE RID: 3022
	public GameObject baseMapObj;

	// Token: 0x04000BCF RID: 3023
	public ButtonOnOff btnType_100;

	// Token: 0x04000BD0 RID: 3024
	public ButtonOnOff btnType_101;

	// Token: 0x04000BD1 RID: 3025
	public ButtonOnOff btnType_102;

	// Token: 0x04000BD2 RID: 3026
	public Image rodBtn;

	// Token: 0x04000BD3 RID: 3027
	public Sprite texBtn_100;

	// Token: 0x04000BD4 RID: 3028
	public Sprite texBtn_101;

	// Token: 0x04000BD5 RID: 3029
	public Sprite texBtn_102;

	// Token: 0x04000BD6 RID: 3030
	public bool changeWork;
}
