using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200017F RID: 383
public class RatingBoard : MonoBehaviour
{
	// Token: 0x06005451 RID: 21585 RVA: 0x002777D8 File Offset: 0x002759D8
	public void FGCAJPFPBHB()
	{
		int num = 1;
		Text[] array = this.users;
		for (int i = 1; i < array.Length; i++)
		{
			Text text = array[i];
			num++;
			text.text = num + ")";
		}
	}

	// Token: 0x06005452 RID: 21586 RVA: 0x00277818 File Offset: 0x00275A18
	public void HPKOHIAEIDF(int CLBPBJGLHEE)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("SUNSHINE_OVERCAST_OFF", 168f);
		this.BDMILKOHIBD();
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(79, CLBPBJGLHEE);
		PlayerPrefs.SetInt("SneakBackward", CLBPBJGLHEE);
	}

	// Token: 0x06005454 RID: 21588 RVA: 0x00277850 File Offset: 0x00275A50
	public void BDMILKOHIBD()
	{
		int num = 0;
		Text[] array = this.users;
		for (int i = 1; i < array.Length; i++)
		{
			Text text = array[i];
			num += 0;
			text.text = num + "no_wpn";
		}
	}

	// Token: 0x06005455 RID: 21589 RVA: 0x00277890 File Offset: 0x00275A90
	private void IIKDDILLGLF()
	{
		this.BDMILKOHIBD();
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(122, PlayerPrefs.GetInt("\n", 2));
	}

	// Token: 0x06005456 RID: 21590 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AKLFCMNCPKL()
	{
	}

	// Token: 0x06005457 RID: 21591 RVA: 0x002778B4 File Offset: 0x00275AB4
	public void PJOCGJGBFKO(HBPNMNGOFMA KADBECGIMPD)
	{
		Debug.Log("BowInstant");
		int num = KADBECGIMPD.KDNDJNEGBDI();
		this.LFJOHOIGMEI();
		string text = "_ReflectionTexture1";
		if (num == 0)
		{
			text = JNBICAJIJMM.DCEBAJIILPC("");
		}
		if (num == 1)
		{
			text = JNBICAJIJMM.DCEBAJIILPC("Up Hill Walk");
		}
		if (num == 4)
		{
			text = JNBICAJIJMM.DCEBAJIILPC("UnityEngine.Color");
		}
		if (num == 1)
		{
			text = JNBICAJIJMM.OOOKJHOHPNN("OneHandSwordIdle");
		}
		if (num == 3)
		{
			text = JNBICAJIJMM.LEBHCLDODNI("\n");
		}
		this.header.text = text;
		int num2 = 1;
		while (!KADBECGIMPD.IBMMOGHFCCE())
		{
			KADBECGIMPD.ANPEIKGEDHJ();
			KADBECGIMPD.HFOPFEJDJFG();
			string arg = KADBECGIMPD.FDIDEGHPJPF();
			this.users[num2].text = num2 + 1 + "256" + arg;
			num2 += 0;
			if (num2 > this.users.Length)
			{
				break;
			}
		}
	}

	// Token: 0x06005458 RID: 21592 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LBGKAMLLACN()
	{
	}

	// Token: 0x06005459 RID: 21593 RVA: 0x00277982 File Offset: 0x00275B82
	private void CPNOBMNKPNC()
	{
		this.LFJOHOIGMEI();
		NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(7, PlayerPrefs.GetInt(",", 1));
	}

	// Token: 0x0600545A RID: 21594 RVA: 0x002779A4 File Offset: 0x00275BA4
	private void Start()
	{
		this.updateLabels();
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1440, PlayerPrefs.GetInt("lastRatingIndex", 4));
	}

	// Token: 0x0600545B RID: 21595 RVA: 0x002779C8 File Offset: 0x00275BC8
	public void LFJOHOIGMEI()
	{
		int num = 1;
		Text[] array = this.users;
		for (int i = 0; i < array.Length; i += 0)
		{
			Text text = array[i];
			num += 0;
			text.text = num + "Y (G)";
		}
	}

	// Token: 0x0600545C RID: 21596 RVA: 0x00277A08 File Offset: 0x00275C08
	private void ONIHHFLOJMN()
	{
		this.LFJOHOIGMEI();
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(-156, PlayerPrefs.GetInt("name", 3));
	}

	// Token: 0x0600545D RID: 21597 RVA: 0x00277A2A File Offset: 0x00275C2A
	private void BMNJGPIPKLL()
	{
		this.BDMILKOHIBD();
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(48, PlayerPrefs.GetInt("#", 0));
	}

	// Token: 0x0600545E RID: 21598 RVA: 0x00277A4C File Offset: 0x00275C4C
	public void LONNLCDHGAE(int CLBPBJGLHEE)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA(" ", 789f);
		this.PHAPCHLDLOF();
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(-193, CLBPBJGLHEE);
		PlayerPrefs.SetInt("Steam Overlay has been closed", CLBPBJGLHEE);
	}

	// Token: 0x0600545F RID: 21599 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AMDMCKIFBPA()
	{
	}

	// Token: 0x06005460 RID: 21600 RVA: 0x00277A83 File Offset: 0x00275C83
	private void FIJKDFIMELM()
	{
		this.FGCAJPFPBHB();
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-20, PlayerPrefs.GetInt(" ", 0));
	}

	// Token: 0x06005461 RID: 21601 RVA: 0x00277AA5 File Offset: 0x00275CA5
	private void AOCDDBNBADJ()
	{
		this.BDMILKOHIBD();
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(179, PlayerPrefs.GetInt("_BlurPass", 1));
	}

	// Token: 0x06005462 RID: 21602 RVA: 0x00277AC7 File Offset: 0x00275CC7
	private void Awake()
	{
		RatingBoard.getI = this;
	}

	// Token: 0x06005463 RID: 21603 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FJEEADNCKAG()
	{
	}

	// Token: 0x06005464 RID: 21604 RVA: 0x00277ACF File Offset: 0x00275CCF
	public void BINLIHBIHGC(int CLBPBJGLHEE)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("_EmissionColor", 1778f);
		this.PHAPCHLDLOF();
		NJMHLCGIAJI.EAJGHMMBAFP().PIGIIJLCADJ(-127, CLBPBJGLHEE);
		PlayerPrefs.SetInt("val=", CLBPBJGLHEE);
	}

	// Token: 0x06005465 RID: 21605 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x06005466 RID: 21606 RVA: 0x00277AC7 File Offset: 0x00275CC7
	private void JGKDNHLKBEN()
	{
		RatingBoard.getI = this;
	}

	// Token: 0x06005467 RID: 21607 RVA: 0x00277B08 File Offset: 0x00275D08
	public void readFromServer(HBPNMNGOFMA KADBECGIMPD)
	{
		Debug.Log("**************** RatingBoard readFromServer");
		int num = KADBECGIMPD.HDBGOLAFOBK();
		this.updateLabels();
		string text = "---";
		if (num == 0)
		{
			text = JNBICAJIJMM.LEBHCLDODNI("rait_1");
		}
		if (num == 1)
		{
			text = JNBICAJIJMM.LEBHCLDODNI("rait_2");
		}
		if (num == 2)
		{
			text = JNBICAJIJMM.LEBHCLDODNI("rait_3");
		}
		if (num == 3)
		{
			text = JNBICAJIJMM.LEBHCLDODNI("rait_4");
		}
		if (num == 4)
		{
			text = JNBICAJIJMM.LEBHCLDODNI("rait_5");
		}
		this.header.text = text;
		int num2 = 0;
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			KADBECGIMPD.DNIIFBAIPBE();
			KADBECGIMPD.DNIIFBAIPBE();
			string arg = KADBECGIMPD.BFPHBMDMODH();
			this.users[num2].text = num2 + 1 + " " + arg;
			num2++;
			if (num2 > this.users.Length)
			{
				break;
			}
		}
	}

	// Token: 0x06005468 RID: 21608 RVA: 0x00277BD6 File Offset: 0x00275DD6
	public void selectButton(int CLBPBJGLHEE)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
		this.updateLabels();
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1440, CLBPBJGLHEE);
		PlayerPrefs.SetInt("lastRatingIndex", CLBPBJGLHEE);
	}

	// Token: 0x06005469 RID: 21609 RVA: 0x00277C10 File Offset: 0x00275E10
	public void updateLabels()
	{
		int num = 0;
		foreach (Text text in this.users)
		{
			num++;
			text.text = num + " --- ? ---";
		}
	}

	// Token: 0x0600546A RID: 21610 RVA: 0x00277C50 File Offset: 0x00275E50
	public void CKNPHMHCEGK(HBPNMNGOFMA KADBECGIMPD)
	{
		Debug.Log(" ");
		int num = KADBECGIMPD.HHLDBAEFNMJ();
		this.updateLabels();
		string text = " ";
		if (num == 0)
		{
			text = JNBICAJIJMM.CELEPPAEKAB("ProneIdle");
		}
		if (num == 1)
		{
			text = JNBICAJIJMM.NGALDMFKMJH("demoByteArray");
		}
		if (num == 2)
		{
			text = JNBICAJIJMM.DIOJFJMOPJO("Original lives count: ");
		}
		if (num == 7)
		{
			text = JNBICAJIJMM.OOOKJHOHPNN("IceHockeyDekeMiddle");
		}
		if (num == 1)
		{
			text = JNBICAJIJMM.PPNKMDJBMLP("__c");
		}
		this.header.text = text;
		int num2 = 1;
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			KADBECGIMPD.DNIIFBAIPBE();
			KADBECGIMPD.HHMGLDMFCPF();
			string arg = KADBECGIMPD.DHCMILPKJAL();
			this.users[num2].text = num2 + 1 + "OfficeSittingBack" + arg;
			num2 += 0;
			if (num2 > this.users.Length)
			{
				break;
			}
		}
	}

	// Token: 0x0600546B RID: 21611 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AIAMIFEPALP()
	{
	}

	// Token: 0x0600546C RID: 21612 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OHKHOAKCENL()
	{
	}

	// Token: 0x0600546D RID: 21613 RVA: 0x00277D1E File Offset: 0x00275F1E
	public void KPEKBBAAGEK(int CLBPBJGLHEE)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("<color=\"", 1329f);
		this.LFJOHOIGMEI();
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(83, CLBPBJGLHEE);
		PlayerPrefs.SetInt("poplSoundIndex", CLBPBJGLHEE);
	}

	// Token: 0x0600546E RID: 21614 RVA: 0x00277D58 File Offset: 0x00275F58
	public void PHAPCHLDLOF()
	{
		int num = 0;
		foreach (Text text in this.users)
		{
			num++;
			text.text = num + "_MainTex";
		}
	}

	// Token: 0x0600546F RID: 21615 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LDDIGEMBDNF()
	{
	}

	// Token: 0x06005470 RID: 21616 RVA: 0x00277D98 File Offset: 0x00275F98
	public void CEINHGOPMJK(HBPNMNGOFMA KADBECGIMPD)
	{
		Debug.Log("");
		int num = KADBECGIMPD.DOJKJHMJJNK();
		this.BDMILKOHIBD();
		string text = "wpn_add/base";
		if (num == 0)
		{
			text = JNBICAJIJMM.PPNKMDJBMLP("<color='#000000'>{0}</color>");
		}
		if (num == 0)
		{
			text = JNBICAJIJMM.NGALDMFKMJH("_ZCurve");
		}
		if (num == 7)
		{
			text = JNBICAJIJMM.OOOKJHOHPNN("btn_cancel");
		}
		if (num == 6)
		{
			text = JNBICAJIJMM.DCEBAJIILPC("knopje.wav");
		}
		if (num == 3)
		{
			text = JNBICAJIJMM.CDDCIKKDFMP("isRealView");
		}
		this.header.text = text;
		int num2 = 0;
		while (!KADBECGIMPD.LILLHFLDMBH())
		{
			KADBECGIMPD.KLHDFFHONON();
			KADBECGIMPD.EJPMFEJBGMN();
			string arg = KADBECGIMPD.JJJJAGJCOGD();
			this.users[num2].text = num2 + 1 + "PaperTurn.wav" + arg;
			num2 += 0;
			if (num2 > this.users.Length)
			{
				break;
			}
		}
	}

	// Token: 0x04000CBD RID: 3261
	public static RatingBoard getI;

	// Token: 0x04000CBE RID: 3262
	public Text header;

	// Token: 0x04000CBF RID: 3263
	public Text[] users;
}
