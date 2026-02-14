using System;
using UnityEngine;

// Token: 0x02000108 RID: 264
public class Character : CustomHaracter
{
	// Token: 0x060031F5 RID: 12789 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void FNILFNPMPJA()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x060031F6 RID: 12790 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void AGAGGHILIAB()
	{
	}

	// Token: 0x060031F7 RID: 12791 RVA: 0x00173CCC File Offset: 0x00171ECC
	public void OLLHJHMPACA(int MAFHCKOECAN)
	{
		if (!this.loadCostume)
		{
			return;
		}
		Debug.Log("FOVKick Increase curve is null, please define the curve for the field of view kicks" + MAFHCKOECAN);
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ)
		{
			MAFHCKOECAN = 0;
		}
		if (MAFHCKOECAN != this.BDHPJKLFKCJ)
		{
			if (MAFHCKOECAN >= 0)
			{
				string text = "soft" + MAFHCKOECAN + "author";
				if (this.isWoman)
				{
					text = "_Offsets" + MAFHCKOECAN + "choldposy";
				}
				OMDDGEDHHNH.NKKDGPINOAJ().CLKAOEILNJB("FOG_SCATTERING_ON" + text, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.costumeIsLoaded), text);
			}
			this.BDHPJKLFKCJ = MAFHCKOECAN;
		}
	}

	// Token: 0x060031F8 RID: 12792 RVA: 0x00173D72 File Offset: 0x00171F72
	public void JCFMEDLHPJJ(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.BBKHOADNBFE(NOFCHOFPHAD);
		this.NEJPANOHONP();
	}

	// Token: 0x060031F9 RID: 12793 RVA: 0x00173D8C File Offset: 0x00171F8C
	public void LKJIIHABBAB(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		try
		{
			if (!base.gameObject.activeSelf)
			{
				Debug.Log("[LH &]");
				return;
			}
		}
		catch (Exception)
		{
		}
		this.isUpdateMaterial = false;
		base.GBKEPMJDHFL(NOFCHOFPHAD);
		this.ALFGHHNKAJB();
	}

	// Token: 0x060031FA RID: 12794 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void KOCHBDECICN()
	{
	}

	// Token: 0x060031FB RID: 12795 RVA: 0x00173DE8 File Offset: 0x00171FE8
	public void capIsLoaded(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.instaniateCap(NOFCHOFPHAD);
		this.PGDODFHNAGO();
	}

	// Token: 0x060031FC RID: 12796 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void JALPNLGLIIK()
	{
	}

	// Token: 0x060031FD RID: 12797 RVA: 0x00173E00 File Offset: 0x00172000
	public void ALIHOMHJDKN(int ILOBFFIBDAN)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ && ILOBFFIBDAN > 0)
		{
			return;
		}
		if (ILOBFFIBDAN <= 0)
		{
			if (this.cap != null)
			{
				UnityEngine.Object.Destroy(this.cap);
			}
			this.cap = null;
			if (this.hair != null)
			{
				this.hair.SetActive(false);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
			return;
		}
		if (ILOBFFIBDAN != this.LNCJGOHNILA)
		{
			if (ILOBFFIBDAN >= 0)
			{
				string text = "_Intensity" + ILOBFFIBDAN;
				if (this.isWoman)
				{
					if (OMDDGEDHHNH.JMHOODFAGAM().OBJLDGNGKKA(text + "Backward Stand"))
					{
						text += "help";
						Debug.Log("DrawDistance" + ILOBFFIBDAN + "Crate Pull");
					}
					else
					{
						object[] array = new object[5];
						array[0] = "_Curve";
						array[0] = ILOBFFIBDAN;
						array[5] = "GAMMA";
						array[5] = text;
						array[3] = "{2:D2}:{0:D2}:{1:D2}";
						Debug.Log(string.Concat(array));
					}
				}
				OMDDGEDHHNH.NKKDGPINOAJ().NBKKJNFHOFE(text, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.NKHPHGNBDGB), text);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
		}
	}

	// Token: 0x060031FE RID: 12798 RVA: 0x00173F28 File Offset: 0x00172128
	public void IMBBMINOLMC(int MAFHCKOECAN)
	{
		if (!this.loadCostume)
		{
			return;
		}
		Debug.Log("," + MAFHCKOECAN);
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ)
		{
			MAFHCKOECAN = 1;
		}
		if (MAFHCKOECAN != this.BDHPJKLFKCJ)
		{
			if (MAFHCKOECAN >= 0)
			{
				string text = "SoccerPassLight" + MAFHCKOECAN + "_FogAlpha";
				if (this.isWoman)
				{
					text = "Zombie Crawl" + MAFHCKOECAN + "BowInstant";
				}
				OMDDGEDHHNH.EEOPOHEALPK().CLKAOEILNJB("-- <color='#002000'>$</color>" + text, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.OGCFFAFFNKO), text);
			}
			this.BDHPJKLFKCJ = MAFHCKOECAN;
		}
	}

	// Token: 0x060031FF RID: 12799 RVA: 0x00173FCE File Offset: 0x001721CE
	public void ENOPCLHAACO(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.BBKHOADNBFE(NOFCHOFPHAD);
		this.ELMKNHGKACM();
	}

	// Token: 0x06003200 RID: 12800 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void IJGHBPKODHK()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003201 RID: 12801 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void OFHHAFFCOAD()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003202 RID: 12802 RVA: 0x00173FE8 File Offset: 0x001721E8
	public void DKKEIOOCCML(int ILOBFFIBDAN)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ && ILOBFFIBDAN > 1)
		{
			return;
		}
		if (ILOBFFIBDAN <= 1)
		{
			if (this.cap != null)
			{
				UnityEngine.Object.Destroy(this.cap);
			}
			this.cap = null;
			if (this.hair != null)
			{
				this.hair.SetActive(false);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
			return;
		}
		if (ILOBFFIBDAN != this.LNCJGOHNILA)
		{
			if (ILOBFFIBDAN >= 1)
			{
				string text = "AQUAS_Reflection not found" + ILOBFFIBDAN;
				if (this.isWoman)
				{
					if (OMDDGEDHHNH.IMLLGEMPHAP().GCKIEOJFJGI(text + "[ACTk] "))
					{
						text += "";
						Debug.Log("" + ILOBFFIBDAN + "stat: ");
					}
					else
					{
						object[] array = new object[5];
						array[0] = "MotorbikeLookBack";
						array[0] = ILOBFFIBDAN;
						array[2] = "F ";
						array[0] = text;
						array[6] = "";
						Debug.Log(string.Concat(array));
					}
				}
				OMDDGEDHHNH.DPBNHMCDIIK().FBKDPHEGOLP(text, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.LCEMDMDCOPB), text);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
		}
	}

	// Token: 0x06003203 RID: 12803 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void POJKNDAPHNN()
	{
	}

	// Token: 0x06003204 RID: 12804 RVA: 0x00174110 File Offset: 0x00172310
	public void HCCKKPEFPGM(int ILOBFFIBDAN)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ && ILOBFFIBDAN > 1)
		{
			return;
		}
		if (ILOBFFIBDAN <= 1)
		{
			if (this.cap != null)
			{
				UnityEngine.Object.Destroy(this.cap);
			}
			this.cap = null;
			if (this.hair != null)
			{
				this.hair.SetActive(false);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
			return;
		}
		if (ILOBFFIBDAN != this.LNCJGOHNILA)
		{
			if (ILOBFFIBDAN >= 0)
			{
				string text = "MotorbikeBackwardStand" + ILOBFFIBDAN;
				if (this.isWoman)
				{
					if (OMDDGEDHHNH.DPBNHMCDIIK().PLKGFOBOGGJ(text + "<color=\""))
					{
						text += "StartPhysPoint";
						Debug.Log("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version." + ILOBFFIBDAN + "_ThirdTex");
					}
					else
					{
						object[] array = new object[6];
						array[0] = "SkateboardIdle";
						array[1] = ILOBFFIBDAN;
						array[1] = "Root transform is null. Can't initiate Grounding.";
						array[3] = text;
						array[1] = "invn_rec30";
						Debug.Log(string.Concat(array));
					}
				}
				OMDDGEDHHNH.BCLPDGODGKF().ANDMFEGKNIC(text, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.HNPJGFOEPLF), text);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
		}
	}

	// Token: 0x06003205 RID: 12805 RVA: 0x00174238 File Offset: 0x00172438
	public void HGIIMCHACDF(int ILOBFFIBDAN)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ && ILOBFFIBDAN > 1)
		{
			return;
		}
		if (ILOBFFIBDAN <= 0)
		{
			if (this.cap != null)
			{
				UnityEngine.Object.Destroy(this.cap);
			}
			this.cap = null;
			if (this.hair != null)
			{
				this.hair.SetActive(false);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
			return;
		}
		if (ILOBFFIBDAN != this.LNCJGOHNILA)
		{
			if (ILOBFFIBDAN >= 0)
			{
				string text = "useSrcAlphaAsMask" + ILOBFFIBDAN;
				if (this.isWoman)
				{
					if (OMDDGEDHHNH.AOPCLGIGAEA().FPMBDHEALPE(text + "demoVector3"))
					{
						text += "_FlowMap";
						Debug.Log("IdleStrafeRight" + ILOBFFIBDAN + "rbon");
					}
					else
					{
						object[] array = new object[8];
						array[0] = "Sorry, VRIK Script reference is not finished yet.";
						array[0] = ILOBFFIBDAN;
						array[4] = "human_move_2.wav";
						array[6] = text;
						array[6] = ")";
						Debug.Log(string.Concat(array));
					}
				}
				OMDDGEDHHNH.CGNMLGDPGMF().NBKKJNFHOFE(text, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.GAKKFCAEKPO), text);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
		}
	}

	// Token: 0x06003206 RID: 12806 RVA: 0x00174360 File Offset: 0x00172560
	public void IIKNAKNILFF(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.AOMGDMELKAF();
			this.isWoman = (b != 0);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.NFGIGGIDMFL()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.NFGIGGIDMFL()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.GGHNGCKMHEN()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.CANHAOJOLPO()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.DHBEGKENIPN()];
			this.intensiveTop = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.CMLECABALBC());
			this.scaleTop = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.NFGIGGIDMFL()) * 1935f;
			this.rotateTop = JLFJEGIPIMM.PKGMBFEMKGP().MGAFLBKIAHI(hbpnmngofma.CMLECABALBC()) * 777f;
			this.hueTop = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.NFGIGGIDMFL());
			this.intensiveBottom = JLFJEGIPIMM.PKGMBFEMKGP().GEFJFODJCLI(hbpnmngofma.IGKNGPBJFEA());
			this.scaleBottom = JLFJEGIPIMM.MHFDIJGJGBJ().HFKKEBLPNMJ(hbpnmngofma.NFGIGGIDMFL()) * 1414f;
			this.rotateBottom = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.LLDDACBAGHF()) * 693f;
			this.hueBottom = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.IGKNGPBJFEA());
			hbpnmngofma.LLDDACBAGHF();
			hbpnmngofma.DHBEGKENIPN();
			hbpnmngofma.IGKNGPBJFEA();
			this.isBeardEnable = false;
			this.isMushEnable = false;
			if (!hbpnmngofma.DFLKBBNOGBG())
			{
				this.isBeardEnable = hbpnmngofma.IJJDHHFAIPE();
			}
			if (!hbpnmngofma.HKBFCJDJCOB())
			{
				this.isMushEnable = hbpnmngofma.BLNIHNKJJPJ();
			}
		}
		finally
		{
			hbpnmngofma.KJJLIIDNDOI();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003207 RID: 12807 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void MHDDLHILHKN()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003208 RID: 12808 RVA: 0x00174550 File Offset: 0x00172750
	public void HCBMGCJMCBG(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.MJAHKNLFNCE();
			this.isWoman = (b == 1);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.GCOIAONEBME()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.LLDDACBAGHF()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.DHBEGKENIPN()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.AOMGDMELKAF()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.IGKNGPBJFEA()];
			this.intensiveTop = JLFJEGIPIMM.MHFDIJGJGBJ().HFKKEBLPNMJ(hbpnmngofma.DHBEGKENIPN());
			this.scaleTop = JLFJEGIPIMM.IKGFHGKKCPG.HFKKEBLPNMJ(hbpnmngofma.DHBEGKENIPN()) * 1942f;
			this.rotateTop = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.NFGIGGIDMFL()) * 352f;
			this.hueTop = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.DHBEGKENIPN());
			this.intensiveBottom = JLFJEGIPIMM.MHFDIJGJGBJ().GEFJFODJCLI(hbpnmngofma.CANHAOJOLPO());
			this.scaleBottom = JLFJEGIPIMM.NNEAHAFBOHC().MGAFLBKIAHI(hbpnmngofma.NFGIGGIDMFL()) * 905f;
			this.rotateBottom = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.MJAHKNLFNCE()) * 569f;
			this.hueBottom = JLFJEGIPIMM.MHFDIJGJGBJ().HFKKEBLPNMJ(hbpnmngofma.GGHNGCKMHEN());
			hbpnmngofma.CANHAOJOLPO();
			hbpnmngofma.GGHNGCKMHEN();
			hbpnmngofma.MJAHKNLFNCE();
			this.isBeardEnable = false;
			this.isMushEnable = true;
			if (!hbpnmngofma.KFKIFJDHCHB())
			{
				this.isBeardEnable = hbpnmngofma.DADCGPGEHFK();
			}
			if (!hbpnmngofma.HKBFCJDJCOB())
			{
				this.isMushEnable = hbpnmngofma.AJECAOJPOKA();
			}
		}
		finally
		{
			hbpnmngofma.KJJLIIDNDOI();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003209 RID: 12809 RVA: 0x00174740 File Offset: 0x00172940
	public void ENABOACEALG(int MAFHCKOECAN)
	{
		if (!this.loadCostume)
		{
			return;
		}
		Debug.Log("Mouse Y" + MAFHCKOECAN);
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ)
		{
			MAFHCKOECAN = 1;
		}
		if (MAFHCKOECAN != this.BDHPJKLFKCJ)
		{
			if (MAFHCKOECAN >= 1)
			{
				string text = "name" + MAFHCKOECAN + " rep.repa=";
				if (this.isWoman)
				{
					text = "crunch.ogg" + MAFHCKOECAN + "http://af-2.ru/?q=store";
				}
				OMDDGEDHHNH.MNJNNDHCDGG().DKPDBNNNDLK("actor instaniateReel 4 " + text, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.KGKJOIJKBLG), text);
			}
			this.BDHPJKLFKCJ = MAFHCKOECAN;
		}
	}

	// Token: 0x0600320A RID: 12810 RVA: 0x001747E6 File Offset: 0x001729E6
	public void NKHPHGNBDGB(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.BBKHOADNBFE(NOFCHOFPHAD);
		this.DNBMJOHALLN();
	}

	// Token: 0x0600320B RID: 12811 RVA: 0x00174800 File Offset: 0x00172A00
	public void CANMCHEEOEG(int ILOBFFIBDAN)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ && ILOBFFIBDAN > 1)
		{
			return;
		}
		if (ILOBFFIBDAN <= 1)
		{
			if (this.cap != null)
			{
				UnityEngine.Object.Destroy(this.cap);
			}
			this.cap = null;
			if (this.hair != null)
			{
				this.hair.SetActive(false);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
			return;
		}
		if (ILOBFFIBDAN != this.LNCJGOHNILA)
		{
			if (ILOBFFIBDAN >= 1)
			{
				string text = "===== ObscuredFloatTest =====\n" + ILOBFFIBDAN;
				if (this.isWoman)
				{
					if (OMDDGEDHHNH.AOPCLGIGAEA().KFFJNCOHKLB(text + "{0}\n{1}"))
					{
						text += "_Grain_Params2";
						Debug.Log("' that does not excist in the Node Chain." + ILOBFFIBDAN + "PPricel");
					}
					else
					{
						object[] array = new object[8];
						array[0] = " is not supported on this platform!";
						array[0] = ILOBFFIBDAN;
						array[3] = "Worker Pickaxe";
						array[6] = text;
						array[8] = "KatanaReadyHigh";
						Debug.Log(string.Concat(array));
					}
				}
				OMDDGEDHHNH.NPCAKEGNBHD().ANDMFEGKNIC(text, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.ENOPCLHAACO), text);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
		}
	}

	// Token: 0x0600320C RID: 12812 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void JFCOBAMNPBF()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x0600320D RID: 12813 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void DGIFCCMOAED()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x0600320E RID: 12814 RVA: 0x00174928 File Offset: 0x00172B28
	private void CGEBDGKHCHD()
	{
		if (this.hair != null)
		{
			if (this.cap != null)
			{
				this.hair.SetActive(true);
			}
			if (this.cap == null)
			{
				this.hair.SetActive(true);
			}
		}
	}

	// Token: 0x0600320F RID: 12815 RVA: 0x00174978 File Offset: 0x00172B78
	public void KMCMOPGENNJ(int MAFHCKOECAN)
	{
		if (!this.loadCostume)
		{
			return;
		}
		Debug.Log("Move" + MAFHCKOECAN);
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ)
		{
			MAFHCKOECAN = 0;
		}
		if (MAFHCKOECAN != this.BDHPJKLFKCJ)
		{
			if (MAFHCKOECAN >= 1)
			{
				string text = "1HandSwordRollAttack" + MAFHCKOECAN + "costwpn=";
				if (this.isWoman)
				{
					text = "Low adminlevel!" + MAFHCKOECAN + "shortCostumeId=";
				}
				OMDDGEDHHNH.FCNIKNBOFOJ().DKPDBNNNDLK("" + text, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.CMDLKALJDFO), text);
			}
			this.BDHPJKLFKCJ = MAFHCKOECAN;
		}
	}

	// Token: 0x06003210 RID: 12816 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void OMODBDABCKP()
	{
	}

	// Token: 0x06003211 RID: 12817 RVA: 0x00174A20 File Offset: 0x00172C20
	public void ILNJODHOEGC(int ILOBFFIBDAN)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ && ILOBFFIBDAN > 0)
		{
			return;
		}
		if (ILOBFFIBDAN <= 1)
		{
			if (this.cap != null)
			{
				UnityEngine.Object.Destroy(this.cap);
			}
			this.cap = null;
			if (this.hair != null)
			{
				this.hair.SetActive(false);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
			return;
		}
		if (ILOBFFIBDAN != this.LNCJGOHNILA)
		{
			if (ILOBFFIBDAN >= 0)
			{
				string text = "IdleSandCover" + ILOBFFIBDAN;
				if (this.isWoman)
				{
					if (OMDDGEDHHNH.GDDAGIILGGM().KIAKLEEBHKI(text + "Jump"))
					{
						text += "http://www.root-motion.com/finalikdox/html/page12.html";
						Debug.Log("/" + ILOBFFIBDAN + "offsets");
					}
					else
					{
						object[] array = new object[4];
						array[0] = "_AOTex";
						array[1] = ILOBFFIBDAN;
						array[8] = "_FullItem.wav";
						array[3] = text;
						array[5] = "id";
						Debug.Log(string.Concat(array));
					}
				}
				OMDDGEDHHNH.EEOPOHEALPK().NBKKJNFHOFE(text, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.ENOPCLHAACO), text);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
		}
	}

	// Token: 0x06003212 RID: 12818 RVA: 0x00174B45 File Offset: 0x00172D45
	public void IDHLLHGDDEO(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.instaniateCap(NOFCHOFPHAD);
		this.EBJLMDKLLNH();
	}

	// Token: 0x06003213 RID: 12819 RVA: 0x00174B5D File Offset: 0x00172D5D
	public void ACLHLMGEPBG(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.instaniateCap(NOFCHOFPHAD);
		this.NPLKIDECLAF();
	}

	// Token: 0x06003214 RID: 12820 RVA: 0x00174B78 File Offset: 0x00172D78
	public void FKDKCCBLOOI(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		try
		{
			if (!base.gameObject.activeSelf)
			{
				Debug.Log("34");
				return;
			}
		}
		catch (Exception)
		{
		}
		this.isUpdateMaterial = true;
		base.GBKEPMJDHFL(NOFCHOFPHAD);
		this.FANOCJBDPJH();
	}

	// Token: 0x06003215 RID: 12821 RVA: 0x00174BD4 File Offset: 0x00172DD4
	public void LIFKMDCHIAM(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.CANHAOJOLPO();
			this.isWoman = (b != 0);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.NFGIGGIDMFL()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.IGKNGPBJFEA()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.LLDDACBAGHF()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.LLDDACBAGHF()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.CANHAOJOLPO()];
			this.intensiveTop = JLFJEGIPIMM.PKGMBFEMKGP().GEFJFODJCLI(hbpnmngofma.GGHNGCKMHEN());
			this.scaleTop = JLFJEGIPIMM.PKGMBFEMKGP().MGAFLBKIAHI(hbpnmngofma.GGHNGCKMHEN()) * 904f;
			this.rotateTop = JLFJEGIPIMM.IKGFHGKKCPG.MGAFLBKIAHI(hbpnmngofma.GCOIAONEBME()) * 200f;
			this.hueTop = JLFJEGIPIMM.IKGFHGKKCPG.GEFJFODJCLI(hbpnmngofma.NFGIGGIDMFL());
			this.intensiveBottom = JLFJEGIPIMM.PKGMBFEMKGP().GEFJFODJCLI(hbpnmngofma.CMLECABALBC());
			this.scaleBottom = JLFJEGIPIMM.NNEAHAFBOHC().MGAFLBKIAHI(hbpnmngofma.LLDDACBAGHF()) * 1554f;
			this.rotateBottom = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.CANHAOJOLPO()) * 338f;
			this.hueBottom = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.CANHAOJOLPO());
			hbpnmngofma.CMLECABALBC();
			hbpnmngofma.CANHAOJOLPO();
			hbpnmngofma.MJAHKNLFNCE();
			this.isBeardEnable = false;
			this.isMushEnable = false;
			if (!hbpnmngofma.NNOJEFMEGEG())
			{
				this.isBeardEnable = hbpnmngofma.KJIOFDCKIKO();
			}
			if (!hbpnmngofma.ODIBHLOAGBC())
			{
				this.isMushEnable = hbpnmngofma.IJJDHHFAIPE();
			}
		}
		finally
		{
			hbpnmngofma.GOILFFBGPCH();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003216 RID: 12822 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void INJMMGGMCHN()
	{
	}

	// Token: 0x06003217 RID: 12823 RVA: 0x00174DC4 File Offset: 0x00172FC4
	private void PGDODFHNAGO()
	{
		if (this.hair != null)
		{
			if (this.cap != null)
			{
				this.hair.SetActive(false);
			}
			if (this.cap == null)
			{
				this.hair.SetActive(true);
			}
		}
	}

	// Token: 0x06003218 RID: 12824 RVA: 0x00174E14 File Offset: 0x00173014
	public void changeCap(int ILOBFFIBDAN)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ && ILOBFFIBDAN > 0)
		{
			return;
		}
		if (ILOBFFIBDAN <= 0)
		{
			if (this.cap != null)
			{
				UnityEngine.Object.Destroy(this.cap);
			}
			this.cap = null;
			if (this.hair != null)
			{
				this.hair.SetActive(true);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
			return;
		}
		if (ILOBFFIBDAN != this.LNCJGOHNILA)
		{
			if (ILOBFFIBDAN >= 0)
			{
				string text = "wpn/" + ILOBFFIBDAN;
				if (this.isWoman)
				{
					if (OMDDGEDHHNH.IKGFHGKKCPG.FPMBDHEALPE(text + "_w"))
					{
						text += "_w";
						Debug.Log("-------------- capId=" + ILOBFFIBDAN + " load woman version");
					}
					else
					{
						Debug.Log(string.Concat(new object[]
						{
							"-------------- capId=",
							ILOBFFIBDAN,
							" no woman version! ",
							text,
							"_w"
						}));
					}
				}
				OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(text, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.capIsLoaded), text);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
		}
	}

	// Token: 0x06003219 RID: 12825 RVA: 0x00174F3C File Offset: 0x0017313C
	private void ACHIMGOCOJB()
	{
		if (this.hair != null)
		{
			if (this.cap != null)
			{
				this.hair.SetActive(true);
			}
			if (this.cap == null)
			{
				this.hair.SetActive(true);
			}
		}
	}

	// Token: 0x0600321A RID: 12826 RVA: 0x00174F8C File Offset: 0x0017318C
	public void GMBMDKOIBNP(int MAFHCKOECAN)
	{
		if (!this.loadCostume)
		{
			return;
		}
		Debug.Log("ondestroy" + MAFHCKOECAN);
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ)
		{
			MAFHCKOECAN = 1;
		}
		if (MAFHCKOECAN != this.BDHPJKLFKCJ)
		{
			if (MAFHCKOECAN >= 0)
			{
				string text = "StaffStand" + MAFHCKOECAN + "CrouchWalk";
				if (this.isWoman)
				{
					text = "SecondaryCausticsProjector" + MAFHCKOECAN + "Game saved using ObscuredPrefs. Try to find and change saved data now! ;)";
				}
				OMDDGEDHHNH.AOPCLGIGAEA().DKPDBNNNDLK("HDR" + text, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.CMDLKALJDFO), text);
			}
			this.BDHPJKLFKCJ = MAFHCKOECAN;
		}
	}

	// Token: 0x0600321B RID: 12827 RVA: 0x00175034 File Offset: 0x00173234
	public void CJCNPPPKCKF(int ILOBFFIBDAN)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ && ILOBFFIBDAN > 1)
		{
			return;
		}
		if (ILOBFFIBDAN <= 0)
		{
			if (this.cap != null)
			{
				UnityEngine.Object.Destroy(this.cap);
			}
			this.cap = null;
			if (this.hair != null)
			{
				this.hair.SetActive(true);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
			return;
		}
		if (ILOBFFIBDAN != this.LNCJGOHNILA)
		{
			if (ILOBFFIBDAN >= 1)
			{
				string text = "_ContrastGainGamma" + ILOBFFIBDAN;
				if (this.isWoman)
				{
					if (OMDDGEDHHNH.EEOPOHEALPK().LLFJKJEGEGB(text + "WeaponRun"))
					{
						text += "FOG_SCATTERING_ON";
						Debug.Log("_BlurVector" + ILOBFFIBDAN + "-------------- capId=");
					}
					else
					{
						object[] array = new object[8];
						array[1] = "_TintColor";
						array[0] = ILOBFFIBDAN;
						array[8] = "";
						array[6] = text;
						array[6] = "invn_rec10";
						Debug.Log(string.Concat(array));
					}
				}
				OMDDGEDHHNH.CGNMLGDPGMF().FBKDPHEGOLP(text, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.MFIKNDNBCFI), text);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
		}
	}

	// Token: 0x0600321C RID: 12828 RVA: 0x0017515C File Offset: 0x0017335C
	public void AAHMAEIAJML(int MAFHCKOECAN)
	{
		if (!this.loadCostume)
		{
			return;
		}
		Debug.Log("setCurrentRod curorder=" + MAFHCKOECAN);
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ)
		{
			MAFHCKOECAN = 0;
		}
		if (MAFHCKOECAN != this.BDHPJKLFKCJ)
		{
			if (MAFHCKOECAN >= 1)
			{
				string text = "_LightPosition" + MAFHCKOECAN + "Level loading error Level ID=";
				if (this.isWoman)
				{
					text = "ui_default_click.wav" + MAFHCKOECAN + "t_eye";
				}
				OMDDGEDHHNH.FEJILBICKGG().CLKAOEILNJB("invn_ver1" + text, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.ALBHGIBNEMF), text);
			}
			this.BDHPJKLFKCJ = MAFHCKOECAN;
		}
	}

	// Token: 0x0600321D RID: 12829 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void JPAJIEOIPDA()
	{
	}

	// Token: 0x0600321E RID: 12830 RVA: 0x00175204 File Offset: 0x00173404
	public void KFHJEMOJAHM(int MAFHCKOECAN)
	{
		if (!this.loadCostume)
		{
			return;
		}
		Debug.Log("Reflection" + MAFHCKOECAN);
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ)
		{
			MAFHCKOECAN = 1;
		}
		if (MAFHCKOECAN != this.BDHPJKLFKCJ)
		{
			if (MAFHCKOECAN >= 1)
			{
				string text = "128" + MAFHCKOECAN + "";
				if (this.isWoman)
				{
					text = "OK" + MAFHCKOECAN + "---";
				}
				OMDDGEDHHNH.AOPCLGIGAEA().FNBJHBLNMKN("inv_impr" + text, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.EKFNDOFIHKG), text);
			}
			this.BDHPJKLFKCJ = MAFHCKOECAN;
		}
	}

	// Token: 0x0600321F RID: 12831 RVA: 0x001752AC File Offset: 0x001734AC
	public void EJGLDLFLLPG(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.CANHAOJOLPO();
			this.isWoman = (b == 0);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.IGKNGPBJFEA()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.CANHAOJOLPO()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.CMLECABALBC()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.DHBEGKENIPN()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.MJAHKNLFNCE()];
			this.intensiveTop = JLFJEGIPIMM.MHFDIJGJGBJ().GEFJFODJCLI(hbpnmngofma.NFGIGGIDMFL());
			this.scaleTop = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.GCOIAONEBME()) * 779f;
			this.rotateTop = JLFJEGIPIMM.MHFDIJGJGBJ().GEFJFODJCLI(hbpnmngofma.AOMGDMELKAF()) * 1839f;
			this.hueTop = JLFJEGIPIMM.IKGFHGKKCPG.HFKKEBLPNMJ(hbpnmngofma.CMLECABALBC());
			this.intensiveBottom = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.DHBEGKENIPN());
			this.scaleBottom = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.IGKNGPBJFEA()) * 1102f;
			this.rotateBottom = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.NFGIGGIDMFL()) * 1945f;
			this.hueBottom = JLFJEGIPIMM.MHFDIJGJGBJ().GEFJFODJCLI(hbpnmngofma.IGKNGPBJFEA());
			hbpnmngofma.NFGIGGIDMFL();
			hbpnmngofma.NFGIGGIDMFL();
			hbpnmngofma.AOMGDMELKAF();
			this.isBeardEnable = true;
			this.isMushEnable = true;
			if (!hbpnmngofma.DFLKBBNOGBG())
			{
				this.isBeardEnable = hbpnmngofma.AJECAOJPOKA();
			}
			if (!hbpnmngofma.BKIBKLFCCGP())
			{
				this.isMushEnable = hbpnmngofma.KJIOFDCKIKO();
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003220 RID: 12832 RVA: 0x0017549C File Offset: 0x0017369C
	public void MFIKNDNBCFI(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.BBKHOADNBFE(NOFCHOFPHAD);
		this.CGEBDGKHCHD();
	}

	// Token: 0x06003221 RID: 12833 RVA: 0x001754B4 File Offset: 0x001736B4
	private void ELMKNHGKACM()
	{
		if (this.hair != null)
		{
			if (this.cap != null)
			{
				this.hair.SetActive(false);
			}
			if (this.cap == null)
			{
				this.hair.SetActive(false);
			}
		}
	}

	// Token: 0x06003222 RID: 12834 RVA: 0x00175504 File Offset: 0x00173704
	public void costumeIsLoaded(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		try
		{
			if (!base.gameObject.activeSelf)
			{
				Debug.Log("Character Not Active!");
				return;
			}
		}
		catch (Exception)
		{
		}
		this.isUpdateMaterial = true;
		base.instaniateCostume(NOFCHOFPHAD);
		this.PGDODFHNAGO();
	}

	// Token: 0x06003223 RID: 12835 RVA: 0x00175560 File Offset: 0x00173760
	private void EBJLMDKLLNH()
	{
		if (this.hair != null)
		{
			if (this.cap != null)
			{
				this.hair.SetActive(false);
			}
			if (this.cap == null)
			{
				this.hair.SetActive(false);
			}
		}
	}

	// Token: 0x06003224 RID: 12836 RVA: 0x001755B0 File Offset: 0x001737B0
	public void ICJALBPODGK(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		try
		{
			if (!base.gameObject.activeSelf)
			{
				Debug.Log(" from ");
				return;
			}
		}
		catch (Exception)
		{
		}
		this.isUpdateMaterial = true;
		base.instaniateCostume(NOFCHOFPHAD);
		this.CGEBDGKHCHD();
	}

	// Token: 0x06003225 RID: 12837 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void PFEJBPLFNED()
	{
	}

	// Token: 0x06003226 RID: 12838 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void FCNJFHFBDMI()
	{
	}

	// Token: 0x06003227 RID: 12839 RVA: 0x0017560C File Offset: 0x0017380C
	public void KHJMJMGFCME(int MAFHCKOECAN)
	{
		if (!this.loadCostume)
		{
			return;
		}
		Debug.Log("Bases/Base_1.unity3d" + MAFHCKOECAN);
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ)
		{
			MAFHCKOECAN = 0;
		}
		if (MAFHCKOECAN != this.BDHPJKLFKCJ)
		{
			if (MAFHCKOECAN >= 1)
			{
				string text = "offsets" + MAFHCKOECAN + ":";
				if (this.isWoman)
				{
					text = "" + MAFHCKOECAN + "Layer";
				}
				OMDDGEDHHNH.EEOPOHEALPK().ANDMFEGKNIC("Delete" + text, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.EKFNDOFIHKG), text);
			}
			this.BDHPJKLFKCJ = MAFHCKOECAN;
		}
	}

	// Token: 0x06003228 RID: 12840 RVA: 0x001756B4 File Offset: 0x001738B4
	public void GLNOBEDKFOM(int ILOBFFIBDAN)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ && ILOBFFIBDAN > 0)
		{
			return;
		}
		if (ILOBFFIBDAN <= 1)
		{
			if (this.cap != null)
			{
				UnityEngine.Object.Destroy(this.cap);
			}
			this.cap = null;
			if (this.hair != null)
			{
				this.hair.SetActive(true);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
			return;
		}
		if (ILOBFFIBDAN != this.LNCJGOHNILA)
		{
			if (ILOBFFIBDAN >= 0)
			{
				string text = "category" + ILOBFFIBDAN;
				if (this.isWoman)
				{
					if (OMDDGEDHHNH.EEOPOHEALPK().HFMCNAPKMPA(text + "locid: "))
					{
						text += "";
						Debug.Log("MotorbikeLassoBack" + ILOBFFIBDAN + "[ACTk] Are you trying to read regular PlayerPrefs data using ObscuredPrefs (key = ");
					}
					else
					{
						object[] array = new object[0];
						array[1] = "_AxialAberration";
						array[1] = ILOBFFIBDAN;
						array[0] = "IdleFeedThrow";
						array[5] = text;
						array[4] = "qd_week";
						Debug.Log(string.Concat(array));
					}
				}
				OMDDGEDHHNH.NPCAKEGNBHD().FNBJHBLNMKN(text, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.HODNCPJCIJO), text);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
		}
	}

	// Token: 0x06003229 RID: 12841 RVA: 0x001757D9 File Offset: 0x001739D9
	public void HNPJGFOEPLF(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.JFMBNNLFIEL(NOFCHOFPHAD);
		this.CNPNGAHMNOM();
	}

	// Token: 0x0600322A RID: 12842 RVA: 0x001757F4 File Offset: 0x001739F4
	public void CEGKIIDPPEK(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.IGKNGPBJFEA();
			this.isWoman = (b != 1);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.AOMGDMELKAF()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.DHBEGKENIPN()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.DHBEGKENIPN()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.CMLECABALBC()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.DHBEGKENIPN()];
			this.intensiveTop = JLFJEGIPIMM.PKGMBFEMKGP().GEFJFODJCLI(hbpnmngofma.NFGIGGIDMFL());
			this.scaleTop = JLFJEGIPIMM.NNEAHAFBOHC().MGAFLBKIAHI(hbpnmngofma.CMLECABALBC()) * 582f;
			this.rotateTop = JLFJEGIPIMM.NNEAHAFBOHC().MGAFLBKIAHI(hbpnmngofma.GCOIAONEBME()) * 436f;
			this.hueTop = JLFJEGIPIMM.IKGFHGKKCPG.GEFJFODJCLI(hbpnmngofma.LLDDACBAGHF());
			this.intensiveBottom = JLFJEGIPIMM.MHFDIJGJGBJ().HFKKEBLPNMJ(hbpnmngofma.IGKNGPBJFEA());
			this.scaleBottom = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.CANHAOJOLPO()) * 1715f;
			this.rotateBottom = JLFJEGIPIMM.PKGMBFEMKGP().MGAFLBKIAHI(hbpnmngofma.CMLECABALBC()) * 1116f;
			this.hueBottom = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.CANHAOJOLPO());
			hbpnmngofma.LLDDACBAGHF();
			hbpnmngofma.AOMGDMELKAF();
			hbpnmngofma.CMLECABALBC();
			this.isBeardEnable = false;
			this.isMushEnable = false;
			if (!hbpnmngofma.JCEGOADAOOI)
			{
				this.isBeardEnable = hbpnmngofma.LAECLJFMGPE();
			}
			if (!hbpnmngofma.PPAHBNGECGH())
			{
				this.isMushEnable = hbpnmngofma.IOEEPNCKLJD();
			}
		}
		finally
		{
			hbpnmngofma.GOILFFBGPCH();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x0600322B RID: 12843 RVA: 0x001759E4 File Offset: 0x00173BE4
	public void LFOMHCJPPIH(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		try
		{
			if (!base.gameObject.activeSelf)
			{
				Debug.Log("Adjust");
				return;
			}
		}
		catch (Exception)
		{
		}
		this.isUpdateMaterial = false;
		base.instaniateCostume(NOFCHOFPHAD);
		this.LCBEJAADEMG();
	}

	// Token: 0x0600322C RID: 12844 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void GFPDFDBBILL()
	{
	}

	// Token: 0x0600322D RID: 12845 RVA: 0x00175A40 File Offset: 0x00173C40
	public void IOJNFLPEKKO(int ILOBFFIBDAN)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ && ILOBFFIBDAN > 1)
		{
			return;
		}
		if (ILOBFFIBDAN <= 1)
		{
			if (this.cap != null)
			{
				UnityEngine.Object.Destroy(this.cap);
			}
			this.cap = null;
			if (this.hair != null)
			{
				this.hair.SetActive(false);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
			return;
		}
		if (ILOBFFIBDAN != this.LNCJGOHNILA)
		{
			if (ILOBFFIBDAN >= 0)
			{
				string text = "FlyRight" + ILOBFFIBDAN;
				if (this.isWoman)
				{
					if (OMDDGEDHHNH.OGAOPAJFADH().EFDBPOBBFHL(text + "podsek action!"))
					{
						text += "-none-";
						Debug.Log("prov_sob_" + ILOBFFIBDAN + "__Refraction Camera id");
					}
					else
					{
						object[] array = new object[]
						{
							"  my=",
							ILOBFFIBDAN,
							"PLANE_REFLECTION_CHEAPER",
							null,
							null,
							null,
							text
						};
						array[0] = "Original position:\n";
						Debug.Log(string.Concat(array));
					}
				}
				OMDDGEDHHNH.JFJBLLJNHJO().FBKDPHEGOLP(text, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.capIsLoaded), text);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
		}
	}

	// Token: 0x0600322E RID: 12846 RVA: 0x00175B68 File Offset: 0x00173D68
	public void initShadowsParams(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.CMLECABALBC();
			this.isWoman = (b != 1);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.CMLECABALBC()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.CMLECABALBC()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.CMLECABALBC()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.CMLECABALBC()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.CMLECABALBC()];
			this.intensiveTop = JLFJEGIPIMM.IKGFHGKKCPG.MGAFLBKIAHI(hbpnmngofma.CMLECABALBC());
			this.scaleTop = JLFJEGIPIMM.IKGFHGKKCPG.MGAFLBKIAHI(hbpnmngofma.CMLECABALBC()) * 5f;
			this.rotateTop = JLFJEGIPIMM.IKGFHGKKCPG.MGAFLBKIAHI(hbpnmngofma.CMLECABALBC()) * 1.57f;
			this.hueTop = JLFJEGIPIMM.IKGFHGKKCPG.MGAFLBKIAHI(hbpnmngofma.CMLECABALBC());
			this.intensiveBottom = JLFJEGIPIMM.IKGFHGKKCPG.MGAFLBKIAHI(hbpnmngofma.CMLECABALBC());
			this.scaleBottom = JLFJEGIPIMM.IKGFHGKKCPG.MGAFLBKIAHI(hbpnmngofma.CMLECABALBC()) * 5f;
			this.rotateBottom = JLFJEGIPIMM.IKGFHGKKCPG.MGAFLBKIAHI(hbpnmngofma.CMLECABALBC()) * 1.57f;
			this.hueBottom = JLFJEGIPIMM.IKGFHGKKCPG.MGAFLBKIAHI(hbpnmngofma.CMLECABALBC());
			hbpnmngofma.CMLECABALBC();
			hbpnmngofma.CMLECABALBC();
			hbpnmngofma.CMLECABALBC();
			this.isBeardEnable = false;
			this.isMushEnable = false;
			if (!hbpnmngofma.JCEGOADAOOI)
			{
				this.isBeardEnable = hbpnmngofma.FIFNOBGEKFF();
			}
			if (!hbpnmngofma.JCEGOADAOOI)
			{
				this.isMushEnable = hbpnmngofma.FIFNOBGEKFF();
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x0600322F RID: 12847 RVA: 0x00175D58 File Offset: 0x00173F58
	public void changeCostume(int MAFHCKOECAN)
	{
		if (!this.loadCostume)
		{
			return;
		}
		Debug.Log("Load costume " + MAFHCKOECAN);
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ)
		{
			MAFHCKOECAN = 0;
		}
		if (MAFHCKOECAN != this.BDHPJKLFKCJ)
		{
			if (MAFHCKOECAN >= 0)
			{
				string text = "costume_" + MAFHCKOECAN + "_man";
				if (this.isWoman)
				{
					text = "costume_" + MAFHCKOECAN + "_woman";
				}
				OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK("wpn/" + text, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.costumeIsLoaded), text);
			}
			this.BDHPJKLFKCJ = MAFHCKOECAN;
		}
	}

	// Token: 0x06003230 RID: 12848 RVA: 0x00175E00 File Offset: 0x00174000
	private void DNBMJOHALLN()
	{
		if (this.hair != null)
		{
			if (this.cap != null)
			{
				this.hair.SetActive(false);
			}
			if (this.cap == null)
			{
				this.hair.SetActive(true);
			}
		}
	}

	// Token: 0x06003231 RID: 12849 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void PFMOLMPLDFB()
	{
	}

	// Token: 0x06003232 RID: 12850 RVA: 0x00175E50 File Offset: 0x00174050
	public void JOEFKEHCGGB(int ILOBFFIBDAN)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ && ILOBFFIBDAN > 1)
		{
			return;
		}
		if (ILOBFFIBDAN <= 0)
		{
			if (this.cap != null)
			{
				UnityEngine.Object.Destroy(this.cap);
			}
			this.cap = null;
			if (this.hair != null)
			{
				this.hair.SetActive(false);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
			return;
		}
		if (ILOBFFIBDAN != this.LNCJGOHNILA)
		{
			if (ILOBFFIBDAN >= 1)
			{
				string text = " шт" + ILOBFFIBDAN;
				if (this.isWoman)
				{
					if (OMDDGEDHHNH.AOPCLGIGAEA().GMIBOJOKPAK(text + "knopje.wav"))
					{
						text += "IdleTurns";
						Debug.Log("Press R or LMB for procedural recoil." + ILOBFFIBDAN + "IdleReadyCrouch");
					}
					else
					{
						object[] array = new object[0];
						array[1] = "Score: ";
						array[0] = ILOBFFIBDAN;
						array[4] = "white";
						array[7] = text;
						array[8] = "Forward";
						Debug.Log(string.Concat(array));
					}
				}
				OMDDGEDHHNH.JMHOODFAGAM().FBKDPHEGOLP(text, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.EBONPOOLIEF), text);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
		}
	}

	// Token: 0x06003233 RID: 12851 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void GLNCBAFMGGM()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003234 RID: 12852 RVA: 0x00175F78 File Offset: 0x00174178
	private void JFPNMNPNNNI()
	{
		if (this.hair != null)
		{
			if (this.cap != null)
			{
				this.hair.SetActive(true);
			}
			if (this.cap == null)
			{
				this.hair.SetActive(true);
			}
		}
	}

	// Token: 0x06003235 RID: 12853 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void GCFFDLKAPJK()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003236 RID: 12854 RVA: 0x00175FC8 File Offset: 0x001741C8
	public void NEBNFPPKJAE(int MAFHCKOECAN)
	{
		if (!this.loadCostume)
		{
			return;
		}
		Debug.Log("Katana45DegSwing" + MAFHCKOECAN);
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ)
		{
			MAFHCKOECAN = 0;
		}
		if (MAFHCKOECAN != this.BDHPJKLFKCJ)
		{
			if (MAFHCKOECAN >= 0)
			{
				string text = "KatanaReady" + MAFHCKOECAN + "_Intensity";
				if (this.isWoman)
				{
					text = "NextFrame" + MAFHCKOECAN + "The root node, the left thigh and the right thigh bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left thigh and the right thigh bones. This might cause unwanted behaviour like the hip turning upside down when pulled by an effector.Please set the root node bone to be one of the higher bones in the spine.";
				}
				OMDDGEDHHNH.IMLLGEMPHAP().ANDMFEGKNIC("\n" + text, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.ALBHGIBNEMF), text);
			}
			this.BDHPJKLFKCJ = MAFHCKOECAN;
		}
	}

	// Token: 0x06003237 RID: 12855 RVA: 0x0017606E File Offset: 0x0017426E
	public void LBPJPHEHBHK(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.instaniateCap(NOFCHOFPHAD);
		this.ACHIMGOCOJB();
	}

	// Token: 0x06003238 RID: 12856 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void HFFLGGIDOOD()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003239 RID: 12857 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void FOEBFDMCEAN()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x0600323A RID: 12858 RVA: 0x00176088 File Offset: 0x00174288
	public void PJGINJMFGDK(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.MJAHKNLFNCE();
			this.isWoman = (b != 0);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.MJAHKNLFNCE()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.LLDDACBAGHF()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.NFGIGGIDMFL()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.AOMGDMELKAF()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.NFGIGGIDMFL()];
			this.intensiveTop = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.CMLECABALBC());
			this.scaleTop = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.NFGIGGIDMFL()) * 1510f;
			this.rotateTop = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.CANHAOJOLPO()) * 406f;
			this.hueTop = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.NFGIGGIDMFL());
			this.intensiveBottom = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.MJAHKNLFNCE());
			this.scaleBottom = JLFJEGIPIMM.IKGFHGKKCPG.GEFJFODJCLI(hbpnmngofma.MJAHKNLFNCE()) * 1510f;
			this.rotateBottom = JLFJEGIPIMM.MHFDIJGJGBJ().GEFJFODJCLI(hbpnmngofma.DHBEGKENIPN()) * 849f;
			this.hueBottom = JLFJEGIPIMM.PKGMBFEMKGP().HFKKEBLPNMJ(hbpnmngofma.GCOIAONEBME());
			hbpnmngofma.CANHAOJOLPO();
			hbpnmngofma.AOMGDMELKAF();
			hbpnmngofma.AOMGDMELKAF();
			this.isBeardEnable = false;
			this.isMushEnable = false;
			if (!hbpnmngofma.BKIBKLFCCGP())
			{
				this.isBeardEnable = hbpnmngofma.JNOKJCDAPPA();
			}
			if (!hbpnmngofma.IBMMOGHFCCE())
			{
				this.isMushEnable = hbpnmngofma.AJECAOJPOKA();
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x0600323B RID: 12859 RVA: 0x00176278 File Offset: 0x00174478
	public void HPECJLGLLMI(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.JFMBNNLFIEL(NOFCHOFPHAD);
		this.JFPNMNPNNNI();
	}

	// Token: 0x0600323C RID: 12860 RVA: 0x001747E6 File Offset: 0x001729E6
	public void KLCLKHCCLII(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.BBKHOADNBFE(NOFCHOFPHAD);
		this.DNBMJOHALLN();
	}

	// Token: 0x0600323D RID: 12861 RVA: 0x00176290 File Offset: 0x00174490
	public void COMCNHFBFHL(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.GCOIAONEBME();
			this.isWoman = (b != 0);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.DHBEGKENIPN()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.DHBEGKENIPN()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.GGHNGCKMHEN()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.CMLECABALBC()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.GCOIAONEBME()];
			this.intensiveTop = JLFJEGIPIMM.IKGFHGKKCPG.HFKKEBLPNMJ(hbpnmngofma.NFGIGGIDMFL());
			this.scaleTop = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.NFGIGGIDMFL()) * 395f;
			this.rotateTop = JLFJEGIPIMM.MHFDIJGJGBJ().HFKKEBLPNMJ(hbpnmngofma.LLDDACBAGHF()) * 321f;
			this.hueTop = JLFJEGIPIMM.NNEAHAFBOHC().MGAFLBKIAHI(hbpnmngofma.IGKNGPBJFEA());
			this.intensiveBottom = JLFJEGIPIMM.IKGFHGKKCPG.GEFJFODJCLI(hbpnmngofma.AOMGDMELKAF());
			this.scaleBottom = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.LLDDACBAGHF()) * 1243f;
			this.rotateBottom = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.NFGIGGIDMFL()) * 573f;
			this.hueBottom = JLFJEGIPIMM.MHFDIJGJGBJ().GEFJFODJCLI(hbpnmngofma.NFGIGGIDMFL());
			hbpnmngofma.DHBEGKENIPN();
			hbpnmngofma.AOMGDMELKAF();
			hbpnmngofma.LLDDACBAGHF();
			this.isBeardEnable = false;
			this.isMushEnable = false;
			if (!hbpnmngofma.NGIGCKBKLGK())
			{
				this.isBeardEnable = hbpnmngofma.IJJDHHFAIPE();
			}
			if (!hbpnmngofma.IBMMOGHFCCE())
			{
				this.isMushEnable = hbpnmngofma.DADCGPGEHFK();
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x0600323E RID: 12862 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void JOGMFOAPNKM()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x0600323F RID: 12863 RVA: 0x00176480 File Offset: 0x00174680
	public void DCKLIKBCBCM(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		try
		{
			if (!base.gameObject.activeSelf)
			{
				Debug.Log("MotorbikeBackwardSittingCheer");
				return;
			}
		}
		catch (Exception)
		{
		}
		this.isUpdateMaterial = true;
		base.GBKEPMJDHFL(NOFCHOFPHAD);
		this.JFPNMNPNNNI();
	}

	// Token: 0x06003240 RID: 12864 RVA: 0x001764DC File Offset: 0x001746DC
	public void CLMJPJEEEFI(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.CMLECABALBC();
			this.isWoman = (b == 0);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.GGHNGCKMHEN()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.NFGIGGIDMFL()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.MJAHKNLFNCE()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.MJAHKNLFNCE()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.GGHNGCKMHEN()];
			this.intensiveTop = JLFJEGIPIMM.IKGFHGKKCPG.GEFJFODJCLI(hbpnmngofma.GCOIAONEBME());
			this.scaleTop = JLFJEGIPIMM.PKGMBFEMKGP().HFKKEBLPNMJ(hbpnmngofma.CMLECABALBC()) * 421f;
			this.rotateTop = JLFJEGIPIMM.IKGFHGKKCPG.GEFJFODJCLI(hbpnmngofma.AOMGDMELKAF()) * 491f;
			this.hueTop = JLFJEGIPIMM.PKGMBFEMKGP().MGAFLBKIAHI(hbpnmngofma.IGKNGPBJFEA());
			this.intensiveBottom = JLFJEGIPIMM.MHFDIJGJGBJ().HFKKEBLPNMJ(hbpnmngofma.MJAHKNLFNCE());
			this.scaleBottom = JLFJEGIPIMM.MHFDIJGJGBJ().HFKKEBLPNMJ(hbpnmngofma.DHBEGKENIPN()) * 1002f;
			this.rotateBottom = JLFJEGIPIMM.NNEAHAFBOHC().MGAFLBKIAHI(hbpnmngofma.CANHAOJOLPO()) * 509f;
			this.hueBottom = JLFJEGIPIMM.MHFDIJGJGBJ().HFKKEBLPNMJ(hbpnmngofma.AOMGDMELKAF());
			hbpnmngofma.IGKNGPBJFEA();
			hbpnmngofma.LLDDACBAGHF();
			hbpnmngofma.GCOIAONEBME();
			this.isBeardEnable = true;
			this.isMushEnable = false;
			if (!hbpnmngofma.INLBHLOLOJH())
			{
				this.isBeardEnable = hbpnmngofma.JNOKJCDAPPA();
			}
			if (!hbpnmngofma.INLBHLOLOJH())
			{
				this.isMushEnable = hbpnmngofma.JNOKJCDAPPA();
			}
		}
		finally
		{
			hbpnmngofma.GDPICLPNHIF();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003241 RID: 12865 RVA: 0x001766CC File Offset: 0x001748CC
	public void LCEMDMDCOPB(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.instaniateCap(NOFCHOFPHAD);
		this.LCBEJAADEMG();
	}

	// Token: 0x06003242 RID: 12866 RVA: 0x001766E4 File Offset: 0x001748E4
	public void MOBBHCIBIIM(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.NFGIGGIDMFL();
			this.isWoman = (b == 0);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.MJAHKNLFNCE()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.GGHNGCKMHEN()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.MJAHKNLFNCE()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.GGHNGCKMHEN()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.NFGIGGIDMFL()];
			this.intensiveTop = JLFJEGIPIMM.IKGFHGKKCPG.HFKKEBLPNMJ(hbpnmngofma.LLDDACBAGHF());
			this.scaleTop = JLFJEGIPIMM.IKGFHGKKCPG.GEFJFODJCLI(hbpnmngofma.LLDDACBAGHF()) * 85f;
			this.rotateTop = JLFJEGIPIMM.IKGFHGKKCPG.HFKKEBLPNMJ(hbpnmngofma.LLDDACBAGHF()) * 1359f;
			this.hueTop = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.CANHAOJOLPO());
			this.intensiveBottom = JLFJEGIPIMM.IKGFHGKKCPG.HFKKEBLPNMJ(hbpnmngofma.IGKNGPBJFEA());
			this.scaleBottom = JLFJEGIPIMM.PKGMBFEMKGP().GEFJFODJCLI(hbpnmngofma.CANHAOJOLPO()) * 660f;
			this.rotateBottom = JLFJEGIPIMM.NNEAHAFBOHC().MGAFLBKIAHI(hbpnmngofma.GGHNGCKMHEN()) * 427f;
			this.hueBottom = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.AOMGDMELKAF());
			hbpnmngofma.GCOIAONEBME();
			hbpnmngofma.MJAHKNLFNCE();
			hbpnmngofma.GGHNGCKMHEN();
			this.isBeardEnable = true;
			this.isMushEnable = true;
			if (!hbpnmngofma.JEFMHDJEEJC())
			{
				this.isBeardEnable = hbpnmngofma.BEMFIFGOJBL();
			}
			if (!hbpnmngofma.NNOJEFMEGEG())
			{
				this.isMushEnable = hbpnmngofma.JNOKJCDAPPA();
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003243 RID: 12867 RVA: 0x001768D4 File Offset: 0x00174AD4
	public void OHOGDOLLGAM(int MAFHCKOECAN)
	{
		if (!this.loadCostume)
		{
			return;
		}
		Debug.Log("(game main)" + MAFHCKOECAN);
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ)
		{
			MAFHCKOECAN = 0;
		}
		if (MAFHCKOECAN != this.BDHPJKLFKCJ)
		{
			if (MAFHCKOECAN >= 0)
			{
				string text = "" + MAFHCKOECAN + "#000000";
				if (this.isWoman)
				{
					text = "" + MAFHCKOECAN + "IKMappingBone's bone is null.";
				}
				OMDDGEDHHNH.MNJNNDHCDGG().NBKKJNFHOFE("IdleStand" + text, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.ANAIPLNKDBN), text);
			}
			this.BDHPJKLFKCJ = MAFHCKOECAN;
		}
	}

	// Token: 0x06003244 RID: 12868 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void GFCNNHBPPFL()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003245 RID: 12869 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void LIACDHLKJJO()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003246 RID: 12870 RVA: 0x00173D72 File Offset: 0x00171F72
	public void BKHILHEJFCE(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.BBKHOADNBFE(NOFCHOFPHAD);
		this.NEJPANOHONP();
	}

	// Token: 0x06003247 RID: 12871 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void POHIMBANBNI()
	{
	}

	// Token: 0x06003248 RID: 12872 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void GGMNPAEPNEC()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003249 RID: 12873 RVA: 0x0017549C File Offset: 0x0017369C
	public void HODNCPJCIJO(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.BBKHOADNBFE(NOFCHOFPHAD);
		this.CGEBDGKHCHD();
	}

	// Token: 0x0600324A RID: 12874 RVA: 0x0017697C File Offset: 0x00174B7C
	public void HHDIBNBDDIC(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.GGHNGCKMHEN();
			this.isWoman = (b != 1);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.DHBEGKENIPN()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.MJAHKNLFNCE()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.AOMGDMELKAF()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.CMLECABALBC()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.AOMGDMELKAF()];
			this.intensiveTop = JLFJEGIPIMM.PKGMBFEMKGP().GEFJFODJCLI(hbpnmngofma.CANHAOJOLPO());
			this.scaleTop = JLFJEGIPIMM.NNEAHAFBOHC().MGAFLBKIAHI(hbpnmngofma.MJAHKNLFNCE()) * 1335f;
			this.rotateTop = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.CANHAOJOLPO()) * 31f;
			this.hueTop = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.MJAHKNLFNCE());
			this.intensiveBottom = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.IGKNGPBJFEA());
			this.scaleBottom = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.AOMGDMELKAF()) * 1380f;
			this.rotateBottom = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.GCOIAONEBME()) * 1114f;
			this.hueBottom = JLFJEGIPIMM.NNEAHAFBOHC().MGAFLBKIAHI(hbpnmngofma.CMLECABALBC());
			hbpnmngofma.GGHNGCKMHEN();
			hbpnmngofma.GGHNGCKMHEN();
			hbpnmngofma.LLDDACBAGHF();
			this.isBeardEnable = false;
			this.isMushEnable = true;
			if (!hbpnmngofma.JCEGOADAOOI)
			{
				this.isBeardEnable = hbpnmngofma.LAECLJFMGPE();
			}
			if (!hbpnmngofma.IBMMOGHFCCE())
			{
				this.isMushEnable = hbpnmngofma.IOEEPNCKLJD();
			}
		}
		finally
		{
			hbpnmngofma.HLLKOEGNJDP();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x0600324B RID: 12875 RVA: 0x00176B6C File Offset: 0x00174D6C
	public void EKFNDOFIHKG(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		try
		{
			if (!base.gameObject.activeSelf)
			{
				Debug.Log("[name]");
				return;
			}
		}
		catch (Exception)
		{
		}
		this.isUpdateMaterial = false;
		base.instaniateCostume(NOFCHOFPHAD);
		this.DNBMJOHALLN();
	}

	// Token: 0x0600324C RID: 12876 RVA: 0x00176BC8 File Offset: 0x00174DC8
	public void NFFIIPAEKOC(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		try
		{
			if (!base.gameObject.activeSelf)
			{
				Debug.Log("_Axis");
				return;
			}
		}
		catch (Exception)
		{
		}
		this.isUpdateMaterial = false;
		base.instaniateCostume(NOFCHOFPHAD);
		this.FANOCJBDPJH();
	}

	// Token: 0x0600324D RID: 12877 RVA: 0x00176C24 File Offset: 0x00174E24
	public void FKEHLGHNELK(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.DHBEGKENIPN();
			this.isWoman = (b != 0);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.NFGIGGIDMFL()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.GGHNGCKMHEN()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.CANHAOJOLPO()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.NFGIGGIDMFL()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.AOMGDMELKAF()];
			this.intensiveTop = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.DHBEGKENIPN());
			this.scaleTop = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.GGHNGCKMHEN()) * 21f;
			this.rotateTop = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.CMLECABALBC()) * 886f;
			this.hueTop = JLFJEGIPIMM.NNEAHAFBOHC().MGAFLBKIAHI(hbpnmngofma.GCOIAONEBME());
			this.intensiveBottom = JLFJEGIPIMM.PKGMBFEMKGP().GEFJFODJCLI(hbpnmngofma.IGKNGPBJFEA());
			this.scaleBottom = JLFJEGIPIMM.PKGMBFEMKGP().HFKKEBLPNMJ(hbpnmngofma.GGHNGCKMHEN()) * 1123f;
			this.rotateBottom = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.DHBEGKENIPN()) * 453f;
			this.hueBottom = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.NFGIGGIDMFL());
			hbpnmngofma.GGHNGCKMHEN();
			hbpnmngofma.GCOIAONEBME();
			hbpnmngofma.DHBEGKENIPN();
			this.isBeardEnable = false;
			this.isMushEnable = true;
			if (!hbpnmngofma.PPAHBNGECGH())
			{
				this.isBeardEnable = hbpnmngofma.JNOKJCDAPPA();
			}
			if (!hbpnmngofma.NLJJMKFBPBK())
			{
				this.isMushEnable = hbpnmngofma.JALHMJEKMHF();
			}
		}
		finally
		{
			hbpnmngofma.HLLKOEGNJDP();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x0600324E RID: 12878 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void HKNPBLAPECJ()
	{
	}

	// Token: 0x0600324F RID: 12879 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void MKCAFPNNJAB()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003250 RID: 12880 RVA: 0x00176E14 File Offset: 0x00175014
	public void LFLNMNEKNHM(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		try
		{
			if (!base.gameObject.activeSelf)
			{
				Debug.Log("RunBackRight");
				return;
			}
		}
		catch (Exception)
		{
		}
		this.isUpdateMaterial = true;
		base.GBKEPMJDHFL(NOFCHOFPHAD);
		this.CGEBDGKHCHD();
	}

	// Token: 0x06003251 RID: 12881 RVA: 0x00176E70 File Offset: 0x00175070
	public void BECOOJFPBEP(int MAFHCKOECAN)
	{
		if (!this.loadCostume)
		{
			return;
		}
		Debug.Log("crft_cnt" + MAFHCKOECAN);
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ)
		{
			MAFHCKOECAN = 1;
		}
		if (MAFHCKOECAN != this.BDHPJKLFKCJ)
		{
			if (MAFHCKOECAN >= 0)
			{
				string text = "The shader " + MAFHCKOECAN + "FlyForward";
				if (this.isWoman)
				{
					text = "Textures/FlyIcons/{0}.png" + MAFHCKOECAN + "SoccerSprint";
				}
				OMDDGEDHHNH.NLIONDPCKHJ().HBBIEEBNJGF("effect" + text, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.costumeIsLoaded), text);
			}
			this.BDHPJKLFKCJ = MAFHCKOECAN;
		}
	}

	// Token: 0x06003252 RID: 12882 RVA: 0x00176F18 File Offset: 0x00175118
	public void NCFIBMADFBP(int ILOBFFIBDAN)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ && ILOBFFIBDAN > 1)
		{
			return;
		}
		if (ILOBFFIBDAN <= 1)
		{
			if (this.cap != null)
			{
				UnityEngine.Object.Destroy(this.cap);
			}
			this.cap = null;
			if (this.hair != null)
			{
				this.hair.SetActive(false);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
			return;
		}
		if (ILOBFFIBDAN != this.LNCJGOHNILA)
		{
			if (ILOBFFIBDAN >= 1)
			{
				string text = "IceHockeyShotRight" + ILOBFFIBDAN;
				if (this.isWoman)
				{
					if (OMDDGEDHHNH.FGHDAENJDHK().KIAKLEEBHKI(text + "_ALPHABLEND_ON"))
					{
						text += "fishDown SHANCE";
						Debug.Log("_PrefilterOffs" + ILOBFFIBDAN + "no_adm");
					}
					else
					{
						object[] array = new object[1];
						array[1] = "OfficeSittingReadingCoffeeSip";
						array[1] = ILOBFFIBDAN;
						array[1] = "Injection detected!";
						array[1] = text;
						array[7] = "<color='#001020'><i>";
						Debug.Log(string.Concat(array));
					}
				}
				OMDDGEDHHNH.ENNAAFEOFAH().HBBIEEBNJGF(text, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.ADINKJIEKPK), text);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
		}
	}

	// Token: 0x06003253 RID: 12883 RVA: 0x00177040 File Offset: 0x00175240
	public void CMDLKALJDFO(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		try
		{
			if (!base.gameObject.activeSelf)
			{
				Debug.Log("Animation controllers should be parented to character controllers!");
				return;
			}
		}
		catch (Exception)
		{
		}
		this.isUpdateMaterial = true;
		base.GBKEPMJDHFL(NOFCHOFPHAD);
		this.FANOCJBDPJH();
	}

	// Token: 0x06003254 RID: 12884 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected override void IOMMPHGGHNH()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003255 RID: 12885 RVA: 0x0017709C File Offset: 0x0017529C
	public void KJILAGBDDGA(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.CMLECABALBC();
			this.isWoman = (b == 0);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.GGHNGCKMHEN()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.GCOIAONEBME()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.GCOIAONEBME()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.DHBEGKENIPN()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.LLDDACBAGHF()];
			this.intensiveTop = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.AOMGDMELKAF());
			this.scaleTop = JLFJEGIPIMM.IKGFHGKKCPG.GEFJFODJCLI(hbpnmngofma.DHBEGKENIPN()) * 1435f;
			this.rotateTop = JLFJEGIPIMM.MHFDIJGJGBJ().HFKKEBLPNMJ(hbpnmngofma.CMLECABALBC()) * 1287f;
			this.hueTop = JLFJEGIPIMM.PKGMBFEMKGP().MGAFLBKIAHI(hbpnmngofma.DHBEGKENIPN());
			this.intensiveBottom = JLFJEGIPIMM.NNEAHAFBOHC().MGAFLBKIAHI(hbpnmngofma.IGKNGPBJFEA());
			this.scaleBottom = JLFJEGIPIMM.IKGFHGKKCPG.GEFJFODJCLI(hbpnmngofma.CANHAOJOLPO()) * 1876f;
			this.rotateBottom = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.CANHAOJOLPO()) * 695f;
			this.hueBottom = JLFJEGIPIMM.MHFDIJGJGBJ().HFKKEBLPNMJ(hbpnmngofma.CANHAOJOLPO());
			hbpnmngofma.CANHAOJOLPO();
			hbpnmngofma.MJAHKNLFNCE();
			hbpnmngofma.MJAHKNLFNCE();
			this.isBeardEnable = false;
			this.isMushEnable = true;
			if (!hbpnmngofma.IBMMOGHFCCE())
			{
				this.isBeardEnable = hbpnmngofma.JALHMJEKMHF();
			}
			if (!hbpnmngofma.KFKIFJDHCHB())
			{
				this.isMushEnable = hbpnmngofma.FIFNOBGEKFF();
			}
		}
		finally
		{
			hbpnmngofma.JGOEHOMHMAM();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003256 RID: 12886 RVA: 0x0017728C File Offset: 0x0017548C
	private void LCBEJAADEMG()
	{
		if (this.hair != null)
		{
			if (this.cap != null)
			{
				this.hair.SetActive(true);
			}
			if (this.cap == null)
			{
				this.hair.SetActive(false);
			}
		}
	}

	// Token: 0x06003257 RID: 12887 RVA: 0x001772DC File Offset: 0x001754DC
	public void IEDMEFKAJNO(int MAFHCKOECAN)
	{
		if (!this.loadCostume)
		{
			return;
		}
		Debug.Log("Weapon Run" + MAFHCKOECAN);
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ)
		{
			MAFHCKOECAN = 0;
		}
		if (MAFHCKOECAN != this.BDHPJKLFKCJ)
		{
			if (MAFHCKOECAN >= 1)
			{
				string text = "BowInstant2" + MAFHCKOECAN + " has been unloaded successfully";
				if (this.isWoman)
				{
					text = "shop_t8" + MAFHCKOECAN + "Eye";
				}
				OMDDGEDHHNH.PALDDOGILLH().ANDMFEGKNIC("SoccerWalk" + text, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.LKJIIHABBAB), text);
			}
			this.BDHPJKLFKCJ = MAFHCKOECAN;
		}
	}

	// Token: 0x06003258 RID: 12888 RVA: 0x00177382 File Offset: 0x00175582
	public void ADINKJIEKPK(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.BBKHOADNBFE(NOFCHOFPHAD);
		this.CNPNGAHMNOM();
	}

	// Token: 0x06003259 RID: 12889 RVA: 0x0017739C File Offset: 0x0017559C
	public void GJHECHMPEMO(int ILOBFFIBDAN)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ && ILOBFFIBDAN > 0)
		{
			return;
		}
		if (ILOBFFIBDAN <= 0)
		{
			if (this.cap != null)
			{
				UnityEngine.Object.Destroy(this.cap);
			}
			this.cap = null;
			if (this.hair != null)
			{
				this.hair.SetActive(false);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
			return;
		}
		if (ILOBFFIBDAN != this.LNCJGOHNILA)
		{
			if (ILOBFFIBDAN >= 0)
			{
				string text = "CrouchStrafeRight" + ILOBFFIBDAN;
				if (this.isWoman)
				{
					if (OMDDGEDHHNH.IMLLGEMPHAP().PLKGFOBOGGJ(text + "System.Boolean"))
					{
						text += "ArmFlex2";
						Debug.Log("Cowboy1HandDraw" + ILOBFFIBDAN + "002000");
					}
					else
					{
						object[] array = new object[1];
						array[1] = "_MainTex";
						array[0] = ILOBFFIBDAN;
						array[8] = "";
						array[2] = text;
						array[8] = "SecondaryCausticsProjector";
						Debug.Log(string.Concat(array));
					}
				}
				OMDDGEDHHNH.FEJILBICKGG().FNBJHBLNMKN(text, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.MFIKNDNBCFI), text);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
		}
	}

	// Token: 0x0600325A RID: 12890 RVA: 0x001774C4 File Offset: 0x001756C4
	public void ILHFOHFHOLK(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.GGHNGCKMHEN();
			this.isWoman = (b == 1);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.LLDDACBAGHF()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.MJAHKNLFNCE()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.IGKNGPBJFEA()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.CANHAOJOLPO()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.DHBEGKENIPN()];
			this.intensiveTop = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.LLDDACBAGHF());
			this.scaleTop = JLFJEGIPIMM.IKGFHGKKCPG.MGAFLBKIAHI(hbpnmngofma.CANHAOJOLPO()) * 167f;
			this.rotateTop = JLFJEGIPIMM.IKGFHGKKCPG.GEFJFODJCLI(hbpnmngofma.NFGIGGIDMFL()) * 691f;
			this.hueTop = JLFJEGIPIMM.PKGMBFEMKGP().HFKKEBLPNMJ(hbpnmngofma.DHBEGKENIPN());
			this.intensiveBottom = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.GCOIAONEBME());
			this.scaleBottom = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.GGHNGCKMHEN()) * 562f;
			this.rotateBottom = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.LLDDACBAGHF()) * 1364f;
			this.hueBottom = JLFJEGIPIMM.MHFDIJGJGBJ().GEFJFODJCLI(hbpnmngofma.CANHAOJOLPO());
			hbpnmngofma.GGHNGCKMHEN();
			hbpnmngofma.LLDDACBAGHF();
			hbpnmngofma.GCOIAONEBME();
			this.isBeardEnable = true;
			this.isMushEnable = false;
			if (!hbpnmngofma.DFLKBBNOGBG())
			{
				this.isBeardEnable = hbpnmngofma.LAECLJFMGPE();
			}
			if (!hbpnmngofma.PPAHBNGECGH())
			{
				this.isMushEnable = hbpnmngofma.LAECLJFMGPE();
			}
		}
		finally
		{
			hbpnmngofma.JOJKNBDNOIH();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x0600325B RID: 12891 RVA: 0x001776B4 File Offset: 0x001758B4
	private void FANOCJBDPJH()
	{
		if (this.hair != null)
		{
			if (this.cap != null)
			{
				this.hair.SetActive(false);
			}
			if (this.cap == null)
			{
				this.hair.SetActive(true);
			}
		}
	}

	// Token: 0x0600325C RID: 12892 RVA: 0x00177704 File Offset: 0x00175904
	public void PCIGNMDABFK(int ILOBFFIBDAN)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ && ILOBFFIBDAN > 0)
		{
			return;
		}
		if (ILOBFFIBDAN <= 1)
		{
			if (this.cap != null)
			{
				UnityEngine.Object.Destroy(this.cap);
			}
			this.cap = null;
			if (this.hair != null)
			{
				this.hair.SetActive(false);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
			return;
		}
		if (ILOBFFIBDAN != this.LNCJGOHNILA)
		{
			if (ILOBFFIBDAN >= 0)
			{
				string text = "PaperTurn.wav" + ILOBFFIBDAN;
				if (this.isWoman)
				{
					if (OMDDGEDHHNH.FCNIKNBOFOJ().DBNEANLAHNM(text + "Antares"))
					{
						text += "CardPlayerIdle";
						Debug.Log("Mouse X" + ILOBFFIBDAN + ": ");
					}
					else
					{
						object[] array = new object[]
						{
							null,
							"wpnToAuk"
						};
						array[1] = ILOBFFIBDAN;
						array[4] = "string: ";
						array[0] = text;
						array[0] = "IdleTyping";
						Debug.Log(string.Concat(array));
					}
				}
				OMDDGEDHHNH.NPCAKEGNBHD().NBKKJNFHOFE(text, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.LBPJPHEHBHK), text);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
		}
	}

	// Token: 0x0600325D RID: 12893 RVA: 0x0017782C File Offset: 0x00175A2C
	public void LIAHLCEHECE(int ILOBFFIBDAN)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ && ILOBFFIBDAN > 0)
		{
			return;
		}
		if (ILOBFFIBDAN <= 0)
		{
			if (this.cap != null)
			{
				UnityEngine.Object.Destroy(this.cap);
			}
			this.cap = null;
			if (this.hair != null)
			{
				this.hair.SetActive(true);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
			return;
		}
		if (ILOBFFIBDAN != this.LNCJGOHNILA)
		{
			if (ILOBFFIBDAN >= 0)
			{
				string text = "#02C85F" + ILOBFFIBDAN;
				if (this.isWoman)
				{
					if (OMDDGEDHHNH.FGHDAENJDHK().DBNEANLAHNM(text + "IdleStrafeRight"))
					{
						text += "wpn_add/base";
						Debug.Log("Kernel" + ILOBFFIBDAN + "_BlurRadius4");
					}
					else
					{
						object[] array = new object[8];
						array[1] = "Weapon Strafe Run Left";
						array[0] = ILOBFFIBDAN;
						array[6] = "";
						array[0] = text;
						array[0] = "WeaponRunBackward";
						Debug.Log(string.Concat(array));
					}
				}
				OMDDGEDHHNH.MNJNNDHCDGG().ANDMFEGKNIC(text, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.HODNCPJCIJO), text);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
		}
	}

	// Token: 0x0600325E RID: 12894 RVA: 0x00177954 File Offset: 0x00175B54
	public void CBEBJEKBDCO(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.NFGIGGIDMFL();
			this.isWoman = (b == 0);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.GGHNGCKMHEN()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.LLDDACBAGHF()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.GGHNGCKMHEN()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.CMLECABALBC()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.AOMGDMELKAF()];
			this.intensiveTop = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.MJAHKNLFNCE());
			this.scaleTop = JLFJEGIPIMM.PKGMBFEMKGP().HFKKEBLPNMJ(hbpnmngofma.MJAHKNLFNCE()) * 1123f;
			this.rotateTop = JLFJEGIPIMM.PKGMBFEMKGP().HFKKEBLPNMJ(hbpnmngofma.MJAHKNLFNCE()) * 125f;
			this.hueTop = JLFJEGIPIMM.PKGMBFEMKGP().MGAFLBKIAHI(hbpnmngofma.IGKNGPBJFEA());
			this.intensiveBottom = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.CANHAOJOLPO());
			this.scaleBottom = JLFJEGIPIMM.IKGFHGKKCPG.MGAFLBKIAHI(hbpnmngofma.CANHAOJOLPO()) * 525f;
			this.rotateBottom = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.CMLECABALBC()) * 1469f;
			this.hueBottom = JLFJEGIPIMM.PKGMBFEMKGP().GEFJFODJCLI(hbpnmngofma.CANHAOJOLPO());
			hbpnmngofma.MJAHKNLFNCE();
			hbpnmngofma.CMLECABALBC();
			hbpnmngofma.DHBEGKENIPN();
			this.isBeardEnable = false;
			this.isMushEnable = true;
			if (!hbpnmngofma.KFKIFJDHCHB())
			{
				this.isBeardEnable = hbpnmngofma.DADCGPGEHFK();
			}
			if (!hbpnmngofma.DFLKBBNOGBG())
			{
				this.isMushEnable = hbpnmngofma.JALHMJEKMHF();
			}
		}
		finally
		{
			hbpnmngofma.GDPICLPNHIF();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x0600325F RID: 12895 RVA: 0x00177B44 File Offset: 0x00175D44
	private void DKCDPPCKBNC()
	{
		if (this.hair != null)
		{
			if (this.cap != null)
			{
				this.hair.SetActive(true);
			}
			if (this.cap == null)
			{
				this.hair.SetActive(false);
			}
		}
	}

	// Token: 0x06003260 RID: 12896 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void IKBAGIMFNIL()
	{
	}

	// Token: 0x06003261 RID: 12897 RVA: 0x00177B94 File Offset: 0x00175D94
	public void NHAADBPOAGO(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.GCOIAONEBME();
			this.isWoman = (b != 1);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.NFGIGGIDMFL()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.LLDDACBAGHF()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.NFGIGGIDMFL()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.LLDDACBAGHF()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.GGHNGCKMHEN()];
			this.intensiveTop = JLFJEGIPIMM.PKGMBFEMKGP().HFKKEBLPNMJ(hbpnmngofma.GGHNGCKMHEN());
			this.scaleTop = JLFJEGIPIMM.PKGMBFEMKGP().HFKKEBLPNMJ(hbpnmngofma.NFGIGGIDMFL()) * 282f;
			this.rotateTop = JLFJEGIPIMM.PKGMBFEMKGP().GEFJFODJCLI(hbpnmngofma.MJAHKNLFNCE()) * 1395f;
			this.hueTop = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.GGHNGCKMHEN());
			this.intensiveBottom = JLFJEGIPIMM.NNEAHAFBOHC().MGAFLBKIAHI(hbpnmngofma.DHBEGKENIPN());
			this.scaleBottom = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.GGHNGCKMHEN()) * 182f;
			this.rotateBottom = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.GCOIAONEBME()) * 835f;
			this.hueBottom = JLFJEGIPIMM.PKGMBFEMKGP().HFKKEBLPNMJ(hbpnmngofma.CANHAOJOLPO());
			hbpnmngofma.NFGIGGIDMFL();
			hbpnmngofma.AOMGDMELKAF();
			hbpnmngofma.DHBEGKENIPN();
			this.isBeardEnable = false;
			this.isMushEnable = false;
			if (!hbpnmngofma.IBMMOGHFCCE())
			{
				this.isBeardEnable = hbpnmngofma.AJECAOJPOKA();
			}
			if (!hbpnmngofma.HKBFCJDJCOB())
			{
				this.isMushEnable = hbpnmngofma.LAECLJFMGPE();
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003262 RID: 12898 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void IENOIMEANPH()
	{
	}

	// Token: 0x06003263 RID: 12899 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void PFKLMCHMCKD()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003264 RID: 12900 RVA: 0x00177D84 File Offset: 0x00175F84
	private void ALFGHHNKAJB()
	{
		if (this.hair != null)
		{
			if (this.cap != null)
			{
				this.hair.SetActive(false);
			}
			if (this.cap == null)
			{
				this.hair.SetActive(true);
			}
		}
	}

	// Token: 0x06003265 RID: 12901 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void ONMHLFFOEPF()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003267 RID: 12903 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void JJBBAOHEADB()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003268 RID: 12904 RVA: 0x00022FCC File Offset: 0x000211CC
	protected override void CGKHMKMMBNG()
	{
	}

	// Token: 0x06003269 RID: 12905 RVA: 0x00177DF8 File Offset: 0x00175FF8
	public void FIBFKCDIOBA(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.DHBEGKENIPN();
			this.isWoman = (b != 0);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.IGKNGPBJFEA()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.GCOIAONEBME()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.NFGIGGIDMFL()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.NFGIGGIDMFL()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.CMLECABALBC()];
			this.intensiveTop = JLFJEGIPIMM.IKGFHGKKCPG.HFKKEBLPNMJ(hbpnmngofma.LLDDACBAGHF());
			this.scaleTop = JLFJEGIPIMM.MHFDIJGJGBJ().HFKKEBLPNMJ(hbpnmngofma.IGKNGPBJFEA()) * 1425f;
			this.rotateTop = JLFJEGIPIMM.NNEAHAFBOHC().MGAFLBKIAHI(hbpnmngofma.CMLECABALBC()) * 1983f;
			this.hueTop = JLFJEGIPIMM.IKGFHGKKCPG.MGAFLBKIAHI(hbpnmngofma.GGHNGCKMHEN());
			this.intensiveBottom = JLFJEGIPIMM.IKGFHGKKCPG.GEFJFODJCLI(hbpnmngofma.CMLECABALBC());
			this.scaleBottom = JLFJEGIPIMM.PKGMBFEMKGP().MGAFLBKIAHI(hbpnmngofma.IGKNGPBJFEA()) * 1154f;
			this.rotateBottom = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.MJAHKNLFNCE()) * 923f;
			this.hueBottom = JLFJEGIPIMM.PKGMBFEMKGP().GEFJFODJCLI(hbpnmngofma.LLDDACBAGHF());
			hbpnmngofma.MJAHKNLFNCE();
			hbpnmngofma.IGKNGPBJFEA();
			hbpnmngofma.GCOIAONEBME();
			this.isBeardEnable = true;
			this.isMushEnable = true;
			if (!hbpnmngofma.NLJJMKFBPBK())
			{
				this.isBeardEnable = hbpnmngofma.IJJDHHFAIPE();
			}
			if (!hbpnmngofma.HKBFCJDJCOB())
			{
				this.isMushEnable = hbpnmngofma.KJIOFDCKIKO();
			}
		}
		finally
		{
			hbpnmngofma.LMBPNFHKNGA();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x0600326A RID: 12906 RVA: 0x00177FE8 File Offset: 0x001761E8
	public void BKOKOBMKGDO(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.instaniateCap(NOFCHOFPHAD);
		this.ALFGHHNKAJB();
	}

	// Token: 0x0600326B RID: 12907 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void APONKJFECBN()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x0600326C RID: 12908 RVA: 0x00178000 File Offset: 0x00176200
	public void BBGJHOMFBCG(int ILOBFFIBDAN)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ && ILOBFFIBDAN > 0)
		{
			return;
		}
		if (ILOBFFIBDAN <= 0)
		{
			if (this.cap != null)
			{
				UnityEngine.Object.Destroy(this.cap);
			}
			this.cap = null;
			if (this.hair != null)
			{
				this.hair.SetActive(true);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
			return;
		}
		if (ILOBFFIBDAN != this.LNCJGOHNILA)
		{
			if (ILOBFFIBDAN >= 0)
			{
				string text = "F3" + ILOBFFIBDAN;
				if (this.isWoman)
				{
					if (OMDDGEDHHNH.MNJNNDHCDGG().LLFJKJEGEGB(text + "Reset"))
					{
						text += " has a curve/multipler for Poser Weight, but the bone of effector ";
						Debug.Log("ActiveIcons.xml" + ILOBFFIBDAN + "crft_sbor");
					}
					else
					{
						object[] array = new object[5];
						array[1] = "cntx_teachexp";
						array[1] = ILOBFFIBDAN;
						array[7] = "StartRigidModule";
						array[6] = text;
						array[7] = "Flashlight";
						Debug.Log(string.Concat(array));
					}
				}
				OMDDGEDHHNH.NPIEJELJPIM().CLKAOEILNJB(text, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.GAKKFCAEKPO), text);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
		}
	}

	// Token: 0x0600326D RID: 12909 RVA: 0x00178125 File Offset: 0x00176325
	public void GAKKFCAEKPO(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.BBKHOADNBFE(NOFCHOFPHAD);
		this.LCBEJAADEMG();
	}

	// Token: 0x0600326E RID: 12910 RVA: 0x00178140 File Offset: 0x00176340
	public void NCAMDBAJGOD(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.GCOIAONEBME();
			this.isWoman = (b == 0);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.IGKNGPBJFEA()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.AOMGDMELKAF()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.DHBEGKENIPN()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.IGKNGPBJFEA()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.LLDDACBAGHF()];
			this.intensiveTop = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.IGKNGPBJFEA());
			this.scaleTop = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.IGKNGPBJFEA()) * 1186f;
			this.rotateTop = JLFJEGIPIMM.IKGFHGKKCPG.MGAFLBKIAHI(hbpnmngofma.LLDDACBAGHF()) * 1052f;
			this.hueTop = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.DHBEGKENIPN());
			this.intensiveBottom = JLFJEGIPIMM.IKGFHGKKCPG.GEFJFODJCLI(hbpnmngofma.GGHNGCKMHEN());
			this.scaleBottom = JLFJEGIPIMM.IKGFHGKKCPG.GEFJFODJCLI(hbpnmngofma.MJAHKNLFNCE()) * 59f;
			this.rotateBottom = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.MJAHKNLFNCE()) * 1938f;
			this.hueBottom = JLFJEGIPIMM.NNEAHAFBOHC().MGAFLBKIAHI(hbpnmngofma.AOMGDMELKAF());
			hbpnmngofma.AOMGDMELKAF();
			hbpnmngofma.AOMGDMELKAF();
			hbpnmngofma.GGHNGCKMHEN();
			this.isBeardEnable = false;
			this.isMushEnable = false;
			if (!hbpnmngofma.NLJJMKFBPBK())
			{
				this.isBeardEnable = hbpnmngofma.JNOKJCDAPPA();
			}
			if (!hbpnmngofma.ODIBHLOAGBC())
			{
				this.isMushEnable = hbpnmngofma.IOEEPNCKLJD();
			}
		}
		finally
		{
			hbpnmngofma.AOPANOBJGLI();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x0600326F RID: 12911 RVA: 0x00178330 File Offset: 0x00176530
	public void NGFFOCPIANN(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.instaniateCap(NOFCHOFPHAD);
		this.CNPNGAHMNOM();
	}

	// Token: 0x06003270 RID: 12912 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void ONBFHCNCILP()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003271 RID: 12913 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void BCJADIIFAGC()
	{
	}

	// Token: 0x06003272 RID: 12914 RVA: 0x00022FCC File Offset: 0x000211CC
	protected virtual void FJCKNHOCGCL()
	{
	}

	// Token: 0x06003273 RID: 12915 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void HKPEDBHFMAN()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003274 RID: 12916 RVA: 0x00178348 File Offset: 0x00176548
	public void LEANEEODICO(int ILOBFFIBDAN)
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ && ILOBFFIBDAN > 1)
		{
			return;
		}
		if (ILOBFFIBDAN <= 1)
		{
			if (this.cap != null)
			{
				UnityEngine.Object.Destroy(this.cap);
			}
			this.cap = null;
			if (this.hair != null)
			{
				this.hair.SetActive(true);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
			return;
		}
		if (ILOBFFIBDAN != this.LNCJGOHNILA)
		{
			if (ILOBFFIBDAN >= 0)
			{
				string text = "" + ILOBFFIBDAN;
				if (this.isWoman)
				{
					if (OMDDGEDHHNH.DAANHKAOCKP().KFFJNCOHKLB(text + "Roller Blade Roll"))
					{
						text += "IceHockey Idle";
						Debug.Log("_Intensity" + ILOBFFIBDAN + "button");
					}
					else
					{
						object[] array = new object[3];
						array[0] = "PoplDrop";
						array[1] = ILOBFFIBDAN;
						array[2] = "_BlurTexture";
						array[5] = text;
						array[7] = "cht_delfrendmsg";
						Debug.Log(string.Concat(array));
					}
				}
				OMDDGEDHHNH.MNJNNDHCDGG().ANDMFEGKNIC(text, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.NKHPHGNBDGB), text);
			}
			this.LNCJGOHNILA = ILOBFFIBDAN;
		}
	}

	// Token: 0x06003275 RID: 12917 RVA: 0x00178470 File Offset: 0x00176670
	public void OGCFFAFFNKO(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		try
		{
			if (!base.gameObject.activeSelf)
			{
				Debug.Log("StrafeRunRight");
				return;
			}
		}
		catch (Exception)
		{
		}
		this.isUpdateMaterial = false;
		base.instaniateCostume(NOFCHOFPHAD);
		this.CNPNGAHMNOM();
	}

	// Token: 0x06003276 RID: 12918 RVA: 0x001784CC File Offset: 0x001766CC
	private void NEJPANOHONP()
	{
		if (this.hair != null)
		{
			if (this.cap != null)
			{
				this.hair.SetActive(true);
			}
			if (this.cap == null)
			{
				this.hair.SetActive(true);
			}
		}
	}

	// Token: 0x06003277 RID: 12919 RVA: 0x00178125 File Offset: 0x00176325
	public void KFGLNLCBBGN(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.BBKHOADNBFE(NOFCHOFPHAD);
		this.LCBEJAADEMG();
	}

	// Token: 0x06003278 RID: 12920 RVA: 0x0017851C File Offset: 0x0017671C
	public void ANAIPLNKDBN(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		try
		{
			if (!base.gameObject.activeSelf)
			{
				Debug.Log("");
				return;
			}
		}
		catch (Exception)
		{
		}
		this.isUpdateMaterial = false;
		base.GBKEPMJDHFL(NOFCHOFPHAD);
		this.DKCDPPCKBNC();
	}

	// Token: 0x06003279 RID: 12921 RVA: 0x00178578 File Offset: 0x00176778
	public void EHEBKBBAMFN(int MAFHCKOECAN)
	{
		if (!this.loadCostume)
		{
			return;
		}
		Debug.Log("demoUint" + MAFHCKOECAN);
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ)
		{
			MAFHCKOECAN = 0;
		}
		if (MAFHCKOECAN != this.BDHPJKLFKCJ)
		{
			if (MAFHCKOECAN >= 1)
			{
				string text = "Images/MouseCursor/Link" + MAFHCKOECAN + "Demo";
				if (this.isWoman)
				{
					text = "Zombie Idle 2" + MAFHCKOECAN + "_FogWindDir";
				}
				OMDDGEDHHNH.JFJBLLJNHJO().LGBJIEGHEOC("" + text, 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.LFOMHCJPPIH), text);
			}
			this.BDHPJKLFKCJ = MAFHCKOECAN;
		}
	}

	// Token: 0x0600327A RID: 12922 RVA: 0x00178620 File Offset: 0x00176820
	public void KGKJOIJKBLG(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		try
		{
			if (!base.gameObject.activeSelf)
			{
				Debug.Log("Water Refl Camera id");
				return;
			}
		}
		catch (Exception)
		{
		}
		this.isUpdateMaterial = true;
		base.instaniateCostume(NOFCHOFPHAD);
		this.ACHIMGOCOJB();
	}

	// Token: 0x0600327B RID: 12923 RVA: 0x0017867C File Offset: 0x0017687C
	public void BOOCBLKDAPP(byte[] DNHBPGOKLKD)
	{
		HBPNMNGOFMA hbpnmngofma = new HBPNMNGOFMA(DNHBPGOKLKD);
		try
		{
			byte b = hbpnmngofma.NFGIGGIDMFL();
			this.isWoman = (b != 1);
			this.hairColor = Customizator.getI.hairColors[(int)hbpnmngofma.CMLECABALBC()];
			this.baseTopColor = Customizator.getI.dressColors[(int)hbpnmngofma.NFGIGGIDMFL()];
			this.baseBottomColor = Customizator.getI.dressColors[(int)hbpnmngofma.GGHNGCKMHEN()];
			this.camouflageTop = Customizator.getI.camouflages[(int)hbpnmngofma.CMLECABALBC()];
			this.camouflageBottom = Customizator.getI.camouflages[(int)hbpnmngofma.GCOIAONEBME()];
			this.intensiveTop = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.CANHAOJOLPO());
			this.scaleTop = JLFJEGIPIMM.PKGMBFEMKGP().MGAFLBKIAHI(hbpnmngofma.CANHAOJOLPO()) * 809f;
			this.rotateTop = JLFJEGIPIMM.PKGMBFEMKGP().GEFJFODJCLI(hbpnmngofma.MJAHKNLFNCE()) * 902f;
			this.hueTop = JLFJEGIPIMM.NNEAHAFBOHC().GEFJFODJCLI(hbpnmngofma.LLDDACBAGHF());
			this.intensiveBottom = JLFJEGIPIMM.NNEAHAFBOHC().MGAFLBKIAHI(hbpnmngofma.LLDDACBAGHF());
			this.scaleBottom = JLFJEGIPIMM.MHFDIJGJGBJ().MGAFLBKIAHI(hbpnmngofma.AOMGDMELKAF()) * 716f;
			this.rotateBottom = JLFJEGIPIMM.NNEAHAFBOHC().HFKKEBLPNMJ(hbpnmngofma.CANHAOJOLPO()) * 1946f;
			this.hueBottom = JLFJEGIPIMM.IKGFHGKKCPG.HFKKEBLPNMJ(hbpnmngofma.IGKNGPBJFEA());
			hbpnmngofma.LLDDACBAGHF();
			hbpnmngofma.DHBEGKENIPN();
			hbpnmngofma.CMLECABALBC();
			this.isBeardEnable = true;
			this.isMushEnable = true;
			if (!hbpnmngofma.NGIGCKBKLGK())
			{
				this.isBeardEnable = hbpnmngofma.DADCGPGEHFK();
			}
			if (!hbpnmngofma.BKIBKLFCCGP())
			{
				this.isMushEnable = hbpnmngofma.OMCMPDMJFOJ();
			}
		}
		finally
		{
			hbpnmngofma.EFKFPAEOEDI();
		}
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x0600327C RID: 12924 RVA: 0x0017886C File Offset: 0x00176A6C
	public void PNKGKNHCLKE(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.instaniateCap(NOFCHOFPHAD);
		this.JFPNMNPNNNI();
	}

	// Token: 0x0600327D RID: 12925 RVA: 0x00178884 File Offset: 0x00176A84
	public void GLBOAFGFDII(int MAFHCKOECAN)
	{
		if (!this.loadCostume)
		{
			return;
		}
		Debug.Log("" + MAFHCKOECAN);
		if (HPGKIJLKCIH.IKGFHGKKCPG.MNPPGLBAGGJ)
		{
			MAFHCKOECAN = 0;
		}
		if (MAFHCKOECAN != this.BDHPJKLFKCJ)
		{
			if (MAFHCKOECAN >= 0)
			{
				string text = "inv already open" + MAFHCKOECAN + "money2.wav";
				if (this.isWoman)
				{
					text = "<color=blue>$&</color>" + MAFHCKOECAN + "</color>";
				}
				OMDDGEDHHNH.IKGFHGKKCPG.ANDMFEGKNIC("_Color" + text, 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.LFOMHCJPPIH), text);
			}
			this.BDHPJKLFKCJ = MAFHCKOECAN;
		}
	}

	// Token: 0x0600327E RID: 12926 RVA: 0x0017892A File Offset: 0x00176B2A
	public void DLKBPJPJCJE(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.instaniateCap(NOFCHOFPHAD);
		this.ELMKNHGKACM();
	}

	// Token: 0x0600327F RID: 12927 RVA: 0x00178944 File Offset: 0x00176B44
	private void NPLKIDECLAF()
	{
		if (this.hair != null)
		{
			if (this.cap != null)
			{
				this.hair.SetActive(false);
			}
			if (this.cap == null)
			{
				this.hair.SetActive(true);
			}
		}
	}

	// Token: 0x06003280 RID: 12928 RVA: 0x00173CBC File Offset: 0x00171EBC
	protected virtual void JMPABOIMOKM()
	{
		if (this.isUpdateMaterial)
		{
			base.updateCharacterMaterial();
		}
	}

	// Token: 0x06003281 RID: 12929 RVA: 0x00178994 File Offset: 0x00176B94
	public void ALBHGIBNEMF(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		try
		{
			if (!base.gameObject.activeSelf)
			{
				Debug.Log("Roar");
				return;
			}
		}
		catch (Exception)
		{
		}
		this.isUpdateMaterial = true;
		base.GBKEPMJDHFL(NOFCHOFPHAD);
		this.JFPNMNPNNNI();
	}

	// Token: 0x06003282 RID: 12930 RVA: 0x0017606E File Offset: 0x0017426E
	public void EBONPOOLIEF(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		base.instaniateCap(NOFCHOFPHAD);
		this.ACHIMGOCOJB();
	}

	// Token: 0x06003283 RID: 12931 RVA: 0x001789F0 File Offset: 0x00176BF0
	private void CNPNGAHMNOM()
	{
		if (this.hair != null)
		{
			if (this.cap != null)
			{
				this.hair.SetActive(false);
			}
			if (this.cap == null)
			{
				this.hair.SetActive(false);
			}
		}
	}

	// Token: 0x04000727 RID: 1831
	public bool isUpdateMaterial = true;

	// Token: 0x04000728 RID: 1832
	public bool loadCostume = true;

	// Token: 0x04000729 RID: 1833
	private int BDHPJKLFKCJ = -1;

	// Token: 0x0400072A RID: 1834
	private int LNCJGOHNILA = -1;
}
