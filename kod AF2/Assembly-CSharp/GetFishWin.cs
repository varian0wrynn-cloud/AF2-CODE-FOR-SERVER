using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000172 RID: 370
public class GetFishWin : MonoBehaviour
{
	// Token: 0x060050DC RID: 20700 RVA: 0x00257F4F File Offset: 0x0025614F
	public void IGGMBOCFGNO()
	{
		GameInterface.getI.BOGPHBNCEDP(-1, false);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050DD RID: 20701 RVA: 0x00257F70 File Offset: 0x00256170
	public void getFishWQN()
	{
		GameInterface.getI.getFish(-1, true);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050DE RID: 20702 RVA: 0x00257F91 File Offset: 0x00256191
	public void CCKBGCKKKBB()
	{
		GameInterface.getI.EFBAFHBCIDA(-1, false);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050DF RID: 20703 RVA: 0x00257FB4 File Offset: 0x002561B4
	private void JIFOELPAEHG()
	{
		if (this.BIINKCAJDKB != null)
		{
			if (this.BIINKCAJDKB.GKPOPMAAGIJ() != null)
			{
				this.fishImage.texture = this.BIINKCAJDKB.FMMNICCENPF().AEIIBNOFLCM();
			}
			this.baitImage.texture = IHFEDJEMJMB.IKGFHGKKCPG.LMGMPPAOPEP(this.BIINKCAJDKB.MIGBFMILDHD).CFFHIODOGCH;
			this.IMLIDGJPGCG = true;
			int num = 1;
			int num2 = 0;
			foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.NAFGMKJPLPC)
			{
				num += oijegjlcfcf.NKHBAJKMAGD;
				num2 += 0;
			}
			num -= this.BIINKCAJDKB.NKHBAJKMAGD;
			num2 -= 0;
			if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.KMGAHCANELI() || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().NKEOCCKEOCE())
			{
				this.IMLIDGJPGCG = false;
			}
			this.getFish.interactable = !this.IMLIDGJPGCG;
			this.getFishNQ.interactable = !this.IMLIDGJPGCG;
			if (!ChatPanelLogic.getI.isChatEnter())
			{
				if (Input.GetKey(KeyCode.R) && !this.IMLIDGJPGCG)
				{
					this.JELFJAEFCIJ();
				}
				if (Input.GetKey((KeyCode)14))
				{
					this.JJNFECCJCKB();
				}
			}
		}
	}

	// Token: 0x060050E0 RID: 20704 RVA: 0x00258128 File Offset: 0x00256328
	public void PPBIOPJDEEO()
	{
		GameInterface.getI.EBAOMHDICFP(-1);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050E1 RID: 20705 RVA: 0x00258148 File Offset: 0x00256348
	public void DOAGCJOOJLF()
	{
		GameInterface.getI.EBAOMHDICFP(-1);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050E2 RID: 20706 RVA: 0x00257F70 File Offset: 0x00256170
	public void DKFJDAOIDMM()
	{
		GameInterface.getI.getFish(-1, true);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050E3 RID: 20707 RVA: 0x00258168 File Offset: 0x00256368
	private void JOHDLNOKCOK()
	{
		if (this.BIINKCAJDKB != null)
		{
			if (this.BIINKCAJDKB.KHIDJHKNNFC() != null)
			{
				this.fishImage.texture = this.BIINKCAJDKB.HEFAGFMDAEE().DPBCBCLJHAJ();
			}
			this.baitImage.texture = IHFEDJEMJMB.JHAAMBEFENP().GBKMHIGNKJA(this.BIINKCAJDKB.MIGBFMILDHD).CFFHIODOGCH;
			this.IMLIDGJPGCG = true;
			int num = 1;
			int num2 = 1;
			foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.NAFGMKJPLPC)
			{
				num += oijegjlcfcf.NKHBAJKMAGD;
				num2++;
			}
			num -= this.BIINKCAJDKB.NKHBAJKMAGD;
			num2 -= 0;
			if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.KMGAHCANELI() || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().IBEIBAHKIAH)
			{
				this.IMLIDGJPGCG = true;
			}
			this.getFish.interactable = !this.IMLIDGJPGCG;
			this.getFishNQ.interactable = this.IMLIDGJPGCG;
			if (!ChatPanelLogic.getI.isChatEnter())
			{
				if (Input.GetKey((KeyCode)(-65)) && !this.IMLIDGJPGCG)
				{
					this.AEMDIOAPJEO();
				}
				if (Input.GetKey((KeyCode)(-23)))
				{
					this.NOIJLGJJCII();
				}
			}
		}
	}

	// Token: 0x060050E4 RID: 20708 RVA: 0x002582DC File Offset: 0x002564DC
	public void GDBLCFJBDOC()
	{
		GameInterface.getI.EFBAFHBCIDA(-1, true);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050E5 RID: 20709 RVA: 0x002582FD File Offset: 0x002564FD
	public void CLEJCNAJFFF()
	{
		GameInterface.getI.getFish(-1, true);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050E6 RID: 20710 RVA: 0x00257F91 File Offset: 0x00256191
	public void OHJADIEJNCE()
	{
		GameInterface.getI.EFBAFHBCIDA(-1, false);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050E7 RID: 20711 RVA: 0x00258320 File Offset: 0x00256520
	public void HMPEOBLLOFI(OIJEGJLCFCF CFBLFPPOIKE, bool FMJHCGFGPED)
	{
		this.BIINKCAJDKB = CFBLFPPOIKE;
		base.gameObject.SetActive(true);
		this.IMLIDGJPGCG = FMJHCGFGPED;
		this.getFish.interactable = FMJHCGFGPED;
		this.getFishNQ.interactable = !FMJHCGFGPED;
		this.fishImage.gameObject.SetActive(!Fisherman.getI.getBragCntrl.AFECKMFDAEA);
		this.uniqImage.gameObject.SetActive(CFBLFPPOIKE.LCOCKNKEFKN());
		this.champImage.gameObject.SetActive(CFBLFPPOIKE.GEFOGEDMLJA);
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OOIJFNAMEDP().LMGMPPAOPEP(CFBLFPPOIKE.MIGBFMILDHD);
		this.baitImage.texture = befchfngomi.KEEDCOIMPMP();
		this.backImage.sprite = GuiProcessor.NKOEAPCIBKO().qualityBackgrounds[befchfngomi.KBGHOIJIPJF];
		this.fishName.text = CFBLFPPOIKE.OOLIOFBGDKC(true, false).ToUpper();
		this.fishWeight.text = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)CFBLFPPOIKE.NKHBAJKMAGD);
		this.fishExp.text = string.Format("invn_rec29", CFBLFPPOIKE.MGLOOIONCPM);
		if (CFBLFPPOIKE.APLAAOCGECL() != null)
		{
			this.fishImage.texture = CFBLFPPOIKE.ENCJNMNEANC().ANLLGCICOPP();
		}
		this.UnqText.text = "wpn_cat2";
		if (CFBLFPPOIKE.OLJEDIJMEOA.Count > 1)
		{
			string text = "_RgbTex";
			foreach (int ldlcflipofh in CFBLFPPOIKE.OLJEDIJMEOA)
			{
				text = text + "IceHockeyIdle" + AKPJIACDDFI.IKGFHGKKCPG.KOACOPGBPHD(ldlcflipofh, true) + "camouflage_scale";
			}
			this.UnqText.text = text;
		}
	}

	// Token: 0x060050E8 RID: 20712 RVA: 0x002584F0 File Offset: 0x002566F0
	public void EHAFDMIMCIO()
	{
		GameInterface.getI.releaseFish(-1);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050E9 RID: 20713 RVA: 0x00258510 File Offset: 0x00256710
	private void IKHCCAANGOP()
	{
		if (this.BIINKCAJDKB != null)
		{
			if (this.BIINKCAJDKB.JGBOJNELADG() != null)
			{
				this.fishImage.texture = this.BIINKCAJDKB.FMMNICCENPF().EIMNFFAAHLI();
			}
			this.baitImage.texture = IHFEDJEMJMB.JHAAMBEFENP().NKMGKJLONDK(this.BIINKCAJDKB.MIGBFMILDHD).CFFHIODOGCH;
			this.IMLIDGJPGCG = true;
			int num = 1;
			int num2 = 0;
			foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC)
			{
				num += oijegjlcfcf.NKHBAJKMAGD;
				num2++;
			}
			num -= this.BIINKCAJDKB.NKHBAJKMAGD;
			num2--;
			if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().ICJDPPOJINN || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.KEHIFGILLJA())
			{
				this.IMLIDGJPGCG = true;
			}
			this.getFish.interactable = this.IMLIDGJPGCG;
			this.getFishNQ.interactable = !this.IMLIDGJPGCG;
			if (!ChatPanelLogic.getI.DGGGOGNMEJL())
			{
				if (Input.GetKey((KeyCode)(-71)) && !this.IMLIDGJPGCG)
				{
					this.JLIHCAKLFAL();
				}
				if (Input.GetKey((KeyCode)(-126)))
				{
					this.FJNJKKPFFFB();
				}
			}
		}
	}

	// Token: 0x060050EA RID: 20714 RVA: 0x00258128 File Offset: 0x00256328
	public void LPFFOGCDFPA()
	{
		GameInterface.getI.EBAOMHDICFP(-1);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050EB RID: 20715 RVA: 0x002582FD File Offset: 0x002564FD
	public void MEEPOODICHI()
	{
		GameInterface.getI.getFish(-1, true);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050EC RID: 20716 RVA: 0x00258684 File Offset: 0x00256884
	public void MIBOKMJIEEJ(OIJEGJLCFCF CFBLFPPOIKE, bool FMJHCGFGPED)
	{
		this.BIINKCAJDKB = CFBLFPPOIKE;
		base.gameObject.SetActive(true);
		this.IMLIDGJPGCG = FMJHCGFGPED;
		this.getFish.interactable = !FMJHCGFGPED;
		this.getFishNQ.interactable = !FMJHCGFGPED;
		this.fishImage.gameObject.SetActive(!Fisherman.getI.getBragCntrl.AFECKMFDAEA);
		this.uniqImage.gameObject.SetActive(CFBLFPPOIKE.KEMKPAAFIIO());
		this.champImage.gameObject.SetActive(CFBLFPPOIKE.GEFOGEDMLJA);
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().LMGMPPAOPEP(CFBLFPPOIKE.MIGBFMILDHD);
		this.baitImage.texture = befchfngomi.KEEDCOIMPMP();
		this.backImage.sprite = GuiProcessor.IKGFHGKKCPG.qualityBackgrounds[befchfngomi.KBGHOIJIPJF];
		this.fishName.text = CFBLFPPOIKE.KCBJCGOINMK(false, false).ToUpper();
		this.fishWeight.text = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)CFBLFPPOIKE.NKHBAJKMAGD);
		this.fishExp.text = string.Format("error", CFBLFPPOIKE.MGLOOIONCPM);
		if (CFBLFPPOIKE.PPJOPGPEFGI() != null)
		{
			this.fishImage.texture = CFBLFPPOIKE.GKPOPMAAGIJ().DPBCBCLJHAJ();
		}
		this.UnqText.text = "UnityEngine.Color";
		if (CFBLFPPOIKE.OLJEDIJMEOA.Count > 1)
		{
			string text = "_FogAlpha";
			foreach (int ldlcflipofh in CFBLFPPOIKE.OLJEDIJMEOA)
			{
				text = text + "start.ogg" + AKPJIACDDFI.IKGFHGKKCPG.PKAJMDDDMMI(ldlcflipofh, false) + "_RgbBlendCacheTex";
			}
			this.UnqText.text = text;
		}
	}

	// Token: 0x060050ED RID: 20717 RVA: 0x00257F91 File Offset: 0x00256191
	public void JELFJAEFCIJ()
	{
		GameInterface.getI.EFBAFHBCIDA(-1, false);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050EF RID: 20719 RVA: 0x00258854 File Offset: 0x00256A54
	public void IFHBJDDPCLH()
	{
		GameInterface.getI.BOGPHBNCEDP(-1, true);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050F0 RID: 20720 RVA: 0x00258875 File Offset: 0x00256A75
	private void GKFOFOCGPCC()
	{
		JDCEFOFMGHB.JFIDAGABKID().OHEFMNPFHFO = false;
	}

	// Token: 0x060050F1 RID: 20721 RVA: 0x00258884 File Offset: 0x00256A84
	public void PDHGBLHNMPH(OIJEGJLCFCF CFBLFPPOIKE, bool FMJHCGFGPED)
	{
		this.BIINKCAJDKB = CFBLFPPOIKE;
		base.gameObject.SetActive(true);
		this.IMLIDGJPGCG = FMJHCGFGPED;
		this.getFish.interactable = FMJHCGFGPED;
		this.getFishNQ.interactable = FMJHCGFGPED;
		this.fishImage.gameObject.SetActive(Fisherman.getI.getBragCntrl.AFECKMFDAEA);
		this.uniqImage.gameObject.SetActive(CFBLFPPOIKE.JPFFCKENLHO);
		this.champImage.gameObject.SetActive(CFBLFPPOIKE.GEFOGEDMLJA);
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().GBKMHIGNKJA(CFBLFPPOIKE.MIGBFMILDHD);
		this.baitImage.texture = befchfngomi.CFFHIODOGCH;
		this.backImage.sprite = GuiProcessor.PLGADNLAEGN().qualityBackgrounds[befchfngomi.KBGHOIJIPJF];
		this.fishName.text = CFBLFPPOIKE.OOLIOFBGDKC(true, false).ToUpper();
		this.fishWeight.text = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)CFBLFPPOIKE.NKHBAJKMAGD);
		this.fishExp.text = string.Format("Idle Feed Throw", CFBLFPPOIKE.MGLOOIONCPM);
		if (CFBLFPPOIKE.FMMNICCENPF() != null)
		{
			this.fishImage.texture = CFBLFPPOIKE.HFAGADCJACL().LECMGDEDAKF();
		}
		this.UnqText.text = "Blending ";
		if (CFBLFPPOIKE.OLJEDIJMEOA.Count > 0)
		{
			string text = "BackPackOff";
			foreach (int ldlcflipofh in CFBLFPPOIKE.OLJEDIJMEOA)
			{
				text = text + "isDrop action" + AKPJIACDDFI.IKGFHGKKCPG.KOACOPGBPHD(ldlcflipofh, false) + " l ";
			}
			this.UnqText.text = text;
		}
	}

	// Token: 0x060050F2 RID: 20722 RVA: 0x00258A54 File Offset: 0x00256C54
	public void PADCNFDBFIP()
	{
		GameInterface.getI.getFish(-1, false);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050F3 RID: 20723 RVA: 0x00258A75 File Offset: 0x00256C75
	private void OnGUI()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.OHEFMNPFHFO = true;
	}

	// Token: 0x060050F4 RID: 20724 RVA: 0x00258A82 File Offset: 0x00256C82
	public void EKFHOMLBMOK()
	{
		GameInterface.getI.BOGPHBNCEDP(-1, false);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050F5 RID: 20725 RVA: 0x002584F0 File Offset: 0x002566F0
	public void FJNJKKPFFFB()
	{
		GameInterface.getI.releaseFish(-1);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050F6 RID: 20726 RVA: 0x00258854 File Offset: 0x00256A54
	public void JLIHCAKLFAL()
	{
		GameInterface.getI.BOGPHBNCEDP(-1, true);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050F7 RID: 20727 RVA: 0x00258854 File Offset: 0x00256A54
	public void JLPAHMHAPDK()
	{
		GameInterface.getI.BOGPHBNCEDP(-1, true);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050F8 RID: 20728 RVA: 0x00258AA3 File Offset: 0x00256CA3
	public void APAFMOGKFAB()
	{
		GameInterface.getI.BOGPHBNCEDP(-1, true);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050F9 RID: 20729 RVA: 0x00258AC4 File Offset: 0x00256CC4
	private void CGBKGPPNMNM()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.OHEFMNPFHFO = false;
	}

	// Token: 0x060050FA RID: 20730 RVA: 0x00257F4F File Offset: 0x0025614F
	public void BDIAIPBFMJC()
	{
		GameInterface.getI.BOGPHBNCEDP(-1, false);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050FB RID: 20731 RVA: 0x00258AD4 File Offset: 0x00256CD4
	public void LNICCBJCIAP(OIJEGJLCFCF CFBLFPPOIKE, bool FMJHCGFGPED)
	{
		this.BIINKCAJDKB = CFBLFPPOIKE;
		base.gameObject.SetActive(false);
		this.IMLIDGJPGCG = FMJHCGFGPED;
		this.getFish.interactable = !FMJHCGFGPED;
		this.getFishNQ.interactable = FMJHCGFGPED;
		this.fishImage.gameObject.SetActive(!Fisherman.getI.getBragCntrl.AFECKMFDAEA);
		this.uniqImage.gameObject.SetActive(CFBLFPPOIKE.FIMJPEEIGEM());
		this.champImage.gameObject.SetActive(CFBLFPPOIKE.GEFOGEDMLJA);
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.IMCJNFHAFGE(CFBLFPPOIKE.MIGBFMILDHD);
		this.baitImage.texture = befchfngomi.KEEDCOIMPMP();
		this.backImage.sprite = GuiProcessor.PLGADNLAEGN().qualityBackgrounds[befchfngomi.KBGHOIJIPJF];
		this.fishName.text = CFBLFPPOIKE.KGHKBMFEEDH(true, false).ToUpper();
		this.fishWeight.text = JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)CFBLFPPOIKE.NKHBAJKMAGD);
		this.fishExp.text = string.Format("modelid", CFBLFPPOIKE.MGLOOIONCPM);
		if (CFBLFPPOIKE.JGBOJNELADG() != null)
		{
			this.fishImage.texture = CFBLFPPOIKE.HEFAGFMDAEE().HONJOFFBOPH();
		}
		this.UnqText.text = "_ProjInfo";
		if (CFBLFPPOIKE.OLJEDIJMEOA.Count > 1)
		{
			string text = "IdleSlide";
			foreach (int ldlcflipofh in CFBLFPPOIKE.OLJEDIJMEOA)
			{
				text = text + "-H" + AKPJIACDDFI.IKGFHGKKCPG.KOACOPGBPHD(ldlcflipofh, false) + "Cloth_01.wav";
			}
			this.UnqText.text = text;
		}
	}

	// Token: 0x060050FC RID: 20732 RVA: 0x00258CA4 File Offset: 0x00256EA4
	public void getFishActn()
	{
		GameInterface.getI.getFish(-1, false);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050FD RID: 20733 RVA: 0x00258CC8 File Offset: 0x00256EC8
	private void IEOICHPKEMD()
	{
		if (this.BIINKCAJDKB != null)
		{
			if (this.BIINKCAJDKB.PDJBFPOAPBA() != null)
			{
				this.fishImage.texture = this.BIINKCAJDKB.PPJOPGPEFGI().HONJOFFBOPH();
			}
			this.baitImage.texture = IHFEDJEMJMB.AGCBLDIBMNB().IMCJNFHAFGE(this.BIINKCAJDKB.MIGBFMILDHD).KEEDCOIMPMP();
			this.IMLIDGJPGCG = false;
			int num = 1;
			int num2 = 0;
			foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.NAFGMKJPLPC)
			{
				num += oijegjlcfcf.NKHBAJKMAGD;
				num2++;
			}
			num -= this.BIINKCAJDKB.NKHBAJKMAGD;
			num2--;
			if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.ICJDPPOJINN || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().IBEIBAHKIAH)
			{
				this.IMLIDGJPGCG = true;
			}
			this.getFish.interactable = this.IMLIDGJPGCG;
			this.getFishNQ.interactable = this.IMLIDGJPGCG;
			if (!ChatPanelLogic.getI.isChatEnter())
			{
				if (Input.GetKey((KeyCode)(-118)) && !this.IMLIDGJPGCG)
				{
					this.LEDFMACOKDD();
				}
				if (Input.GetKey((KeyCode)(-1)))
				{
					this.JJNFECCJCKB();
				}
			}
		}
	}

	// Token: 0x060050FE RID: 20734 RVA: 0x00257F70 File Offset: 0x00256170
	public void LEDFMACOKDD()
	{
		GameInterface.getI.getFish(-1, true);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x060050FF RID: 20735 RVA: 0x00258E3C File Offset: 0x0025703C
	public void PIFLKNJFHKF()
	{
		GameInterface.getI.FFPPJGCJHBF(-1);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x06005100 RID: 20736 RVA: 0x002582FD File Offset: 0x002564FD
	public void LOINHODGNHD()
	{
		GameInterface.getI.getFish(-1, true);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x06005101 RID: 20737 RVA: 0x00258E5C File Offset: 0x0025705C
	public void JJNFECCJCKB()
	{
		GameInterface.getI.releaseFish(-1);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x06005102 RID: 20738 RVA: 0x00258E7C File Offset: 0x0025707C
	public void newFish(OIJEGJLCFCF CFBLFPPOIKE, bool FMJHCGFGPED)
	{
		this.BIINKCAJDKB = CFBLFPPOIKE;
		base.gameObject.SetActive(true);
		this.IMLIDGJPGCG = FMJHCGFGPED;
		this.getFish.interactable = !FMJHCGFGPED;
		this.getFishNQ.interactable = !FMJHCGFGPED;
		this.fishImage.gameObject.SetActive(!Fisherman.getI.getBragCntrl.AFECKMFDAEA);
		this.uniqImage.gameObject.SetActive(CFBLFPPOIKE.JPFFCKENLHO);
		this.champImage.gameObject.SetActive(CFBLFPPOIKE.GEFOGEDMLJA);
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(CFBLFPPOIKE.MIGBFMILDHD);
		this.baitImage.texture = befchfngomi.CFFHIODOGCH;
		this.backImage.sprite = GuiProcessor.IKGFHGKKCPG.qualityBackgrounds[befchfngomi.KBGHOIJIPJF];
		this.fishName.text = CFBLFPPOIKE.LHNOBJDFOOJ(true, true).ToUpper();
		this.fishWeight.text = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)CFBLFPPOIKE.NKHBAJKMAGD);
		this.fishExp.text = string.Format("★{0}", CFBLFPPOIKE.MGLOOIONCPM);
		if (CFBLFPPOIKE.EJJAGEFMHCO() != null)
		{
			this.fishImage.texture = CFBLFPPOIKE.EJJAGEFMHCO().KEDGAOBCNJG;
		}
		this.UnqText.text = "";
		if (CFBLFPPOIKE.OLJEDIJMEOA.Count > 0)
		{
			string text = "";
			foreach (int ldlcflipofh in CFBLFPPOIKE.OLJEDIJMEOA)
			{
				text = text + "♼ " + AKPJIACDDFI.IKGFHGKKCPG.PKAJMDDDMMI(ldlcflipofh, false) + "\n";
			}
			this.UnqText.text = text;
		}
	}

	// Token: 0x06005103 RID: 20739 RVA: 0x00258A75 File Offset: 0x00256C75
	private void DCHAPIHINBJ()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.OHEFMNPFHFO = true;
	}

	// Token: 0x06005104 RID: 20740 RVA: 0x0025904C File Offset: 0x0025724C
	private void LKAMGOGAMCH()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().OHEFMNPFHFO = false;
	}

	// Token: 0x06005105 RID: 20741 RVA: 0x00258AA3 File Offset: 0x00256CA3
	public void BNLEKAEHAPP()
	{
		GameInterface.getI.BOGPHBNCEDP(-1, true);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x06005106 RID: 20742 RVA: 0x00259059 File Offset: 0x00257259
	private void GCLIPIADIPD()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().OHEFMNPFHFO = true;
	}

	// Token: 0x06005107 RID: 20743 RVA: 0x002584F0 File Offset: 0x002566F0
	public void NOIJLGJJCII()
	{
		GameInterface.getI.releaseFish(-1);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x06005108 RID: 20744 RVA: 0x00257F91 File Offset: 0x00256191
	public void ECODDHKBOPH()
	{
		GameInterface.getI.EFBAFHBCIDA(-1, false);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x06005109 RID: 20745 RVA: 0x00259066 File Offset: 0x00257266
	public void KOMAIHEKOLF()
	{
		GameInterface.getI.EFBAFHBCIDA(-1, false);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x0600510A RID: 20746 RVA: 0x00258A54 File Offset: 0x00256C54
	public void AEMDIOAPJEO()
	{
		GameInterface.getI.getFish(-1, false);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x0600510B RID: 20747 RVA: 0x00259088 File Offset: 0x00257288
	private void JLFBDOPFDDJ()
	{
		if (this.BIINKCAJDKB != null)
		{
			if (this.BIINKCAJDKB.PPJOPGPEFGI() != null)
			{
				this.fishImage.texture = this.BIINKCAJDKB.KHIDJHKNNFC().LECMGDEDAKF();
			}
			this.baitImage.texture = IHFEDJEMJMB.IKGFHGKKCPG.NKMGKJLONDK(this.BIINKCAJDKB.MIGBFMILDHD).CFFHIODOGCH;
			this.IMLIDGJPGCG = true;
			int num = 1;
			int num2 = 0;
			foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.NAFGMKJPLPC)
			{
				num += oijegjlcfcf.NKHBAJKMAGD;
				num2 += 0;
			}
			num -= this.BIINKCAJDKB.NKHBAJKMAGD;
			num2--;
			if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().ICJDPPOJINN || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.IBEIBAHKIAH)
			{
				this.IMLIDGJPGCG = false;
			}
			this.getFish.interactable = this.IMLIDGJPGCG;
			this.getFishNQ.interactable = this.IMLIDGJPGCG;
			if (!ChatPanelLogic.getI.DGGGOGNMEJL())
			{
				if (Input.GetKey((KeyCode)(-77)) && !this.IMLIDGJPGCG)
				{
					this.CCKBGCKKKBB();
				}
				if (Input.GetKey((KeyCode)(-76)))
				{
					this.NOIJLGJJCII();
				}
			}
		}
	}

	// Token: 0x0600510C RID: 20748 RVA: 0x002591FC File Offset: 0x002573FC
	public void KGMPOGONKGF(OIJEGJLCFCF CFBLFPPOIKE, bool FMJHCGFGPED)
	{
		this.BIINKCAJDKB = CFBLFPPOIKE;
		base.gameObject.SetActive(true);
		this.IMLIDGJPGCG = FMJHCGFGPED;
		this.getFish.interactable = !FMJHCGFGPED;
		this.getFishNQ.interactable = !FMJHCGFGPED;
		this.fishImage.gameObject.SetActive(Fisherman.getI.getBragCntrl.AFECKMFDAEA);
		this.uniqImage.gameObject.SetActive(CFBLFPPOIKE.KEMKPAAFIIO());
		this.champImage.gameObject.SetActive(CFBLFPPOIKE.GEFOGEDMLJA);
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().LMGMPPAOPEP(CFBLFPPOIKE.MIGBFMILDHD);
		this.baitImage.texture = befchfngomi.CFFHIODOGCH;
		this.backImage.sprite = GuiProcessor.NKOEAPCIBKO().qualityBackgrounds[befchfngomi.KBGHOIJIPJF];
		this.fishName.text = CFBLFPPOIKE.CFPMCOPINOH(false, true).ToUpper();
		this.fishWeight.text = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)CFBLFPPOIKE.NKHBAJKMAGD);
		this.fishExp.text = string.Format("TOD_SunDirection", CFBLFPPOIKE.MGLOOIONCPM);
		if (CFBLFPPOIKE.EJJAGEFMHCO() != null)
		{
			this.fishImage.texture = CFBLFPPOIKE.FMMNICCENPF().AEIIBNOFLCM();
		}
		this.UnqText.text = "Bone ";
		if (CFBLFPPOIKE.OLJEDIJMEOA.Count > 0)
		{
			string text = "_FinalBlendParameters";
			foreach (int ldlcflipofh in CFBLFPPOIKE.OLJEDIJMEOA)
			{
				text = text + "_Threshhold" + AKPJIACDDFI.IKGFHGKKCPG.KOACOPGBPHD(ldlcflipofh, true) + "move";
			}
			this.UnqText.text = text;
		}
	}

	// Token: 0x0600510D RID: 20749 RVA: 0x002593CC File Offset: 0x002575CC
	public void NOPOGEJPFBJ()
	{
		GameInterface.getI.NGKLCGDLKDB(-1);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x0600510E RID: 20750 RVA: 0x00258128 File Offset: 0x00256328
	public void NLHMHKAJLEC()
	{
		GameInterface.getI.EBAOMHDICFP(-1);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x0600510F RID: 20751 RVA: 0x002593EC File Offset: 0x002575EC
	private void Update()
	{
		if (this.BIINKCAJDKB != null)
		{
			if (this.BIINKCAJDKB.EJJAGEFMHCO() != null)
			{
				this.fishImage.texture = this.BIINKCAJDKB.EJJAGEFMHCO().KEDGAOBCNJG;
			}
			this.baitImage.texture = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.BIINKCAJDKB.MIGBFMILDHD).CFFHIODOGCH;
			this.IMLIDGJPGCG = false;
			int num = 0;
			int num2 = 0;
			foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC)
			{
				num += oijegjlcfcf.NKHBAJKMAGD;
				num2++;
			}
			num -= this.BIINKCAJDKB.NKHBAJKMAGD;
			num2--;
			if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.ICJDPPOJINN || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.IBEIBAHKIAH)
			{
				this.IMLIDGJPGCG = true;
			}
			this.getFish.interactable = !this.IMLIDGJPGCG;
			this.getFishNQ.interactable = !this.IMLIDGJPGCG;
			if (!ChatPanelLogic.getI.isChatEnter())
			{
				if (Input.GetKey(KeyCode.Space) && !this.IMLIDGJPGCG)
				{
					this.getFishActn();
				}
				if (Input.GetKey(KeyCode.J))
				{
					this.rlsFish();
				}
			}
		}
	}

	// Token: 0x06005110 RID: 20752 RVA: 0x00258875 File Offset: 0x00256A75
	private void PNJNNNJEBGA()
	{
		JDCEFOFMGHB.JFIDAGABKID().OHEFMNPFHFO = false;
	}

	// Token: 0x06005111 RID: 20753 RVA: 0x00257F70 File Offset: 0x00256170
	public void AGAADEJKIHB()
	{
		GameInterface.getI.getFish(-1, true);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x06005112 RID: 20754 RVA: 0x00259560 File Offset: 0x00257760
	private void KBEOAOKBHEK()
	{
		JDCEFOFMGHB.JFIDAGABKID().OHEFMNPFHFO = true;
	}

	// Token: 0x06005113 RID: 20755 RVA: 0x0025956D File Offset: 0x0025776D
	public void OICCPKKMLAD()
	{
		GameInterface.getI.FFPPJGCJHBF(-1);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x06005114 RID: 20756 RVA: 0x00258128 File Offset: 0x00256328
	public void FINDHICILLN()
	{
		GameInterface.getI.EBAOMHDICFP(-1);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x06005115 RID: 20757 RVA: 0x00259590 File Offset: 0x00257790
	private void EDANNBFJHIK()
	{
		if (this.BIINKCAJDKB != null)
		{
			if (this.BIINKCAJDKB.GKPOPMAAGIJ() != null)
			{
				this.fishImage.texture = this.BIINKCAJDKB.HEFAGFMDAEE().MMKLLFCKCAG();
			}
			this.baitImage.texture = IHFEDJEMJMB.OELKEADDKPE().IMCJNFHAFGE(this.BIINKCAJDKB.MIGBFMILDHD).KEEDCOIMPMP();
			this.IMLIDGJPGCG = true;
			int num = 1;
			int num2 = 0;
			foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.NAFGMKJPLPC)
			{
				num += oijegjlcfcf.NKHBAJKMAGD;
				num2++;
			}
			num -= this.BIINKCAJDKB.NKHBAJKMAGD;
			num2--;
			if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().ICJDPPOJINN || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.IBEIBAHKIAH)
			{
				this.IMLIDGJPGCG = false;
			}
			this.getFish.interactable = this.IMLIDGJPGCG;
			this.getFishNQ.interactable = this.IMLIDGJPGCG;
			if (!ChatPanelLogic.getI.DJEPDONBBIM())
			{
				if (Input.GetKey((KeyCode)11) && !this.IMLIDGJPGCG)
				{
					this.JLIHCAKLFAL();
				}
				if (Input.GetKey((KeyCode)(-16)))
				{
					this.NOPOGEJPFBJ();
				}
			}
		}
	}

	// Token: 0x06005116 RID: 20758 RVA: 0x00259704 File Offset: 0x00257904
	private void BNKJNBIDPME()
	{
		if (this.BIINKCAJDKB != null)
		{
			if (this.BIINKCAJDKB.FMMNICCENPF() != null)
			{
				this.fishImage.texture = this.BIINKCAJDKB.APLAAOCGECL().MLPBJEFJDHM();
			}
			this.baitImage.texture = IHFEDJEMJMB.OOIJFNAMEDP().GBKMHIGNKJA(this.BIINKCAJDKB.MIGBFMILDHD).KEEDCOIMPMP();
			this.IMLIDGJPGCG = true;
			int num = 0;
			int num2 = 1;
			foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.NAFGMKJPLPC)
			{
				num += oijegjlcfcf.NKHBAJKMAGD;
				num2 += 0;
			}
			num -= this.BIINKCAJDKB.NKHBAJKMAGD;
			num2 -= 0;
			if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.KMGAHCANELI() || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().IBEIBAHKIAH)
			{
				this.IMLIDGJPGCG = true;
			}
			this.getFish.interactable = !this.IMLIDGJPGCG;
			this.getFishNQ.interactable = this.IMLIDGJPGCG;
			if (!ChatPanelLogic.getI.DGGGOGNMEJL())
			{
				if (Input.GetKey((KeyCode)(-89)) && !this.IMLIDGJPGCG)
				{
					this.LEDFMACOKDD();
				}
				if (Input.GetKey(KeyCode.BackQuote))
				{
					this.PPBIOPJDEEO();
				}
			}
		}
	}

	// Token: 0x06005117 RID: 20759 RVA: 0x00258E3C File Offset: 0x0025703C
	public void BGOKKLNDMJL()
	{
		GameInterface.getI.FFPPJGCJHBF(-1);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x06005118 RID: 20760 RVA: 0x00258AA3 File Offset: 0x00256CA3
	public void KDCNJEJKIPB()
	{
		GameInterface.getI.BOGPHBNCEDP(-1, true);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x06005119 RID: 20761 RVA: 0x00259878 File Offset: 0x00257A78
	public void MOJLBKDPLLB(OIJEGJLCFCF CFBLFPPOIKE, bool FMJHCGFGPED)
	{
		this.BIINKCAJDKB = CFBLFPPOIKE;
		base.gameObject.SetActive(true);
		this.IMLIDGJPGCG = FMJHCGFGPED;
		this.getFish.interactable = FMJHCGFGPED;
		this.getFishNQ.interactable = FMJHCGFGPED;
		this.fishImage.gameObject.SetActive(Fisherman.getI.getBragCntrl.AFECKMFDAEA);
		this.uniqImage.gameObject.SetActive(CFBLFPPOIKE.BCALBMNHGDI());
		this.champImage.gameObject.SetActive(CFBLFPPOIKE.GEFOGEDMLJA);
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.EDKKJNHDBPF().GBKMHIGNKJA(CFBLFPPOIKE.MIGBFMILDHD);
		this.baitImage.texture = befchfngomi.CFFHIODOGCH;
		this.backImage.sprite = GuiProcessor.NKOEAPCIBKO().qualityBackgrounds[befchfngomi.KBGHOIJIPJF];
		this.fishName.text = CFBLFPPOIKE.JODMFMFAOEG(true, false).ToUpper();
		this.fishWeight.text = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)CFBLFPPOIKE.NKHBAJKMAGD);
		this.fishExp.text = string.Format("FlyUp", CFBLFPPOIKE.MGLOOIONCPM);
		if (CFBLFPPOIKE.MFKHIBOFIFI() != null)
		{
			this.fishImage.texture = CFBLFPPOIKE.PDJBFPOAPBA().MLPBJEFJDHM();
		}
		this.UnqText.text = " x";
		if (CFBLFPPOIKE.OLJEDIJMEOA.Count > 0)
		{
			string text = "wplabel";
			foreach (int ldlcflipofh in CFBLFPPOIKE.OLJEDIJMEOA)
			{
				text = text + "componentA" + AKPJIACDDFI.IKGFHGKKCPG.KOACOPGBPHD(ldlcflipofh, false) + "i shrank because the inputfield was this big";
			}
			this.UnqText.text = text;
		}
	}

	// Token: 0x0600511A RID: 20762 RVA: 0x00259A48 File Offset: 0x00257C48
	private void CBBLGEDCJBF()
	{
		if (this.BIINKCAJDKB != null)
		{
			if (this.BIINKCAJDKB.GKPOPMAAGIJ() != null)
			{
				this.fishImage.texture = this.BIINKCAJDKB.JGBOJNELADG().MMKLLFCKCAG();
			}
			this.baitImage.texture = IHFEDJEMJMB.NNEAHAFBOHC().IMCJNFHAFGE(this.BIINKCAJDKB.MIGBFMILDHD).CFFHIODOGCH;
			this.IMLIDGJPGCG = true;
			int num = 0;
			int num2 = 0;
			foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.NAFGMKJPLPC)
			{
				num += oijegjlcfcf.NKHBAJKMAGD;
				num2++;
			}
			num -= this.BIINKCAJDKB.NKHBAJKMAGD;
			num2--;
			if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().KMGAHCANELI() || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.NKEOCCKEOCE())
			{
				this.IMLIDGJPGCG = true;
			}
			this.getFish.interactable = !this.IMLIDGJPGCG;
			this.getFishNQ.interactable = !this.IMLIDGJPGCG;
			if (!ChatPanelLogic.getI.DGGGOGNMEJL())
			{
				if (Input.GetKey((KeyCode)(-110)) && !this.IMLIDGJPGCG)
				{
					this.DHMBLGIIMDO();
				}
				if (Input.GetKey(KeyCode.F))
				{
					this.BLMFPMMPBDO();
				}
			}
		}
	}

	// Token: 0x0600511B RID: 20763 RVA: 0x00259BBC File Offset: 0x00257DBC
	public void NGGHBJADIHM(OIJEGJLCFCF CFBLFPPOIKE, bool FMJHCGFGPED)
	{
		this.BIINKCAJDKB = CFBLFPPOIKE;
		base.gameObject.SetActive(false);
		this.IMLIDGJPGCG = FMJHCGFGPED;
		this.getFish.interactable = FMJHCGFGPED;
		this.getFishNQ.interactable = FMJHCGFGPED;
		this.fishImage.gameObject.SetActive(Fisherman.getI.getBragCntrl.AFECKMFDAEA);
		this.uniqImage.gameObject.SetActive(CFBLFPPOIKE.JPFFCKENLHO);
		this.champImage.gameObject.SetActive(CFBLFPPOIKE.GEFOGEDMLJA);
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.NNEAHAFBOHC().NKMGKJLONDK(CFBLFPPOIKE.MIGBFMILDHD);
		this.baitImage.texture = befchfngomi.CFFHIODOGCH;
		this.backImage.sprite = GuiProcessor.NKOEAPCIBKO().qualityBackgrounds[befchfngomi.KBGHOIJIPJF];
		this.fishName.text = CFBLFPPOIKE.KCBJCGOINMK(false, false).ToUpper();
		this.fishWeight.text = JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)CFBLFPPOIKE.NKHBAJKMAGD);
		this.fishExp.text = string.Format("Bases/Base_1.unity3d", CFBLFPPOIKE.MGLOOIONCPM);
		if (CFBLFPPOIKE.JGBOJNELADG() != null)
		{
			this.fishImage.texture = CFBLFPPOIKE.BHPAALLBMHL().EIMNFFAAHLI();
		}
		this.UnqText.text = "wpn_izn";
		if (CFBLFPPOIKE.OLJEDIJMEOA.Count > 1)
		{
			string text = "ShotgunReadyFire";
			foreach (int ldlcflipofh in CFBLFPPOIKE.OLJEDIJMEOA)
			{
				text = text + "setCurrentRod sm (профиль)=" + AKPJIACDDFI.IKGFHGKKCPG.PKAJMDDDMMI(ldlcflipofh, true) + "[ACTk] Obscured Cheating Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?";
			}
			this.UnqText.text = text;
		}
	}

	// Token: 0x0600511C RID: 20764 RVA: 0x00259D8C File Offset: 0x00257F8C
	public void PHFFGMLCKMM()
	{
		GameInterface.getI.EFBAFHBCIDA(-1, true);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x0600511D RID: 20765 RVA: 0x00257F4F File Offset: 0x0025614F
	public void DHMBLGIIMDO()
	{
		GameInterface.getI.BOGPHBNCEDP(-1, false);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x0600511E RID: 20766 RVA: 0x00259DB0 File Offset: 0x00257FB0
	private void KMLNBHIIGKH()
	{
		if (this.BIINKCAJDKB != null)
		{
			if (this.BIINKCAJDKB.JGBOJNELADG() != null)
			{
				this.fishImage.texture = this.BIINKCAJDKB.EJJAGEFMHCO().EIMNFFAAHLI();
			}
			this.baitImage.texture = IHFEDJEMJMB.EDKKJNHDBPF().NKMGKJLONDK(this.BIINKCAJDKB.MIGBFMILDHD).KEEDCOIMPMP();
			this.IMLIDGJPGCG = false;
			int num = 1;
			int num2 = 0;
			foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.NAFGMKJPLPC)
			{
				num += oijegjlcfcf.NKHBAJKMAGD;
				num2 += 0;
			}
			num -= this.BIINKCAJDKB.NKHBAJKMAGD;
			num2 -= 0;
			if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.KMGAHCANELI() || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.KMIOLLENCOL())
			{
				this.IMLIDGJPGCG = false;
			}
			this.getFish.interactable = this.IMLIDGJPGCG;
			this.getFishNQ.interactable = this.IMLIDGJPGCG;
			if (!ChatPanelLogic.getI.isChatEnter())
			{
				if (Input.GetKey(KeyCode.Q) && !this.IMLIDGJPGCG)
				{
					this.AEMDIOAPJEO();
				}
				if (Input.GetKey(KeyCode.Q))
				{
					this.PPBIOPJDEEO();
				}
			}
		}
	}

	// Token: 0x0600511F RID: 20767 RVA: 0x00258E3C File Offset: 0x0025703C
	public void BLMFPMMPBDO()
	{
		GameInterface.getI.FFPPJGCJHBF(-1);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x06005120 RID: 20768 RVA: 0x002584F0 File Offset: 0x002566F0
	public void rlsFish()
	{
		GameInterface.getI.releaseFish(-1);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x06005121 RID: 20769 RVA: 0x0025904C File Offset: 0x0025724C
	private void PNAEIDCONFP()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().OHEFMNPFHFO = false;
	}

	// Token: 0x06005122 RID: 20770 RVA: 0x0025956D File Offset: 0x0025776D
	public void NOFGDPFLJBB()
	{
		GameInterface.getI.FFPPJGCJHBF(-1);
		base.gameObject.SetActive(false);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x06005123 RID: 20771 RVA: 0x00258E3C File Offset: 0x0025703C
	public void ODNCFFGCPJK()
	{
		GameInterface.getI.FFPPJGCJHBF(-1);
		base.gameObject.SetActive(true);
		this.BIINKCAJDKB = null;
	}

	// Token: 0x04000C39 RID: 3129
	public Text UnqText;

	// Token: 0x04000C3A RID: 3130
	public Text fishExp;

	// Token: 0x04000C3B RID: 3131
	public Text fishName;

	// Token: 0x04000C3C RID: 3132
	public Text fishWeight;

	// Token: 0x04000C3D RID: 3133
	public RawImage fishImage;

	// Token: 0x04000C3E RID: 3134
	public RawImage baitImage;

	// Token: 0x04000C3F RID: 3135
	public Image backImage;

	// Token: 0x04000C40 RID: 3136
	public Image uniqImage;

	// Token: 0x04000C41 RID: 3137
	public Image champImage;

	// Token: 0x04000C42 RID: 3138
	public Button release;

	// Token: 0x04000C43 RID: 3139
	public Button getFish;

	// Token: 0x04000C44 RID: 3140
	public Button getFishNQ;

	// Token: 0x04000C45 RID: 3141
	private OIJEGJLCFCF BIINKCAJDKB;

	// Token: 0x04000C46 RID: 3142
	private bool IMLIDGJPGCG;
}
