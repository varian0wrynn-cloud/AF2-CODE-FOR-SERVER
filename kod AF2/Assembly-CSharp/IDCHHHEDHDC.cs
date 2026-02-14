using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000149 RID: 329
public class IDCHHHEDHDC
{
	// Token: 0x06004514 RID: 17684 RVA: 0x0020C2D8 File Offset: 0x0020A4D8
	public CKNLPGEPGGF.IAPCJOBDCEH KMIIGKECOEB(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 2)
		{
			CLBPBJGLHEE = 2;
		}
		if (this.JJACHHDFFFB[CLBPBJGLHEE] == null)
		{
			this.JIFFLPNBILE(CLBPBJGLHEE);
		}
		return this.JJACHHDFFFB[CLBPBJGLHEE];
	}

	// Token: 0x06004515 RID: 17685 RVA: 0x0020C2FA File Offset: 0x0020A4FA
	public bool KFFHOABFPCM(int DFBHMIIPLCA)
	{
		return JLFJEGIPIMM.PKGMBFEMKGP().IBBAJMOLBCP(DFBHMIIPLCA, this.JEKDOPJHKMH);
	}

	// Token: 0x06004516 RID: 17686 RVA: 0x0020C30D File Offset: 0x0020A50D
	public bool EKJBDACJAMM()
	{
		return this.NIPHCKIKNBN(-109);
	}

	// Token: 0x06004517 RID: 17687 RVA: 0x0020C318 File Offset: 0x0020A518
	public string PIFLJJBAEOA(int NKHBAJKMAGD, int DBEIGNDALDC, bool KCBFEHCDHKO = false)
	{
		string str = JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)NKHBAJKMAGD);
		char c = ':';
		if (KCBFEHCDHKO)
		{
			c = 'b';
		}
		if (NKHBAJKMAGD <= 0)
		{
			str = "**************** RatingBoard readFromServer";
		}
		return this.JJKOJOMGIOA(DBEIGNDALDC) + c.ToString() + str;
	}

	// Token: 0x06004518 RID: 17688 RVA: 0x0020C35C File Offset: 0x0020A55C
	public string POMPCEHPGNG(int DBEIGNDALDC)
	{
		string result = "";
		if (this.KIJMCOPFLCN == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 1)
			{
				result = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("fwgt_big_w") + " " + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 2)
			{
				result = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("fwgt_trof_w") + " " + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 3)
			{
				result = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("fwgt_uniq_w") + " " + this.HAJNMNALBBI.ToLower();
			}
		}
		if (this.KIJMCOPFLCN == 1)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 1)
			{
				result = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("fwgt_big_m") + " " + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 2)
			{
				result = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("fwgt_trof_m") + " " + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 3)
			{
				result = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("fwgt_uniq_m") + " " + this.HAJNMNALBBI.ToLower();
			}
		}
		return result;
	}

	// Token: 0x06004519 RID: 17689 RVA: 0x0020C4C3 File Offset: 0x0020A6C3
	public bool DKOLGAMJJLF()
	{
		return this.KFFHOABFPCM(-125);
	}

	// Token: 0x0600451A RID: 17690 RVA: 0x0020C4D0 File Offset: 0x0020A6D0
	public int CNDCDPIFCLP()
	{
		if (this.JELOGFKEELE < 0)
		{
			string text = AKPJIACDDFI.IKGFHGKKCPG.MJCJIEPAEJP(this.LPFKFNLHGBI);
			char c = text[text.Length - 1];
			this.JELOGFKEELE = 0;
			if ((int)c == -143)
			{
				this.JELOGFKEELE = 1;
			}
			if (c == 'Y')
			{
				this.JELOGFKEELE = 0;
			}
			if (this.LPFKFNLHGBI == -54)
			{
				this.JELOGFKEELE = 1;
			}
			if (this.LPFKFNLHGBI == -6)
			{
				this.JELOGFKEELE = 0;
			}
			if (this.LPFKFNLHGBI == -58)
			{
				this.JELOGFKEELE = 0;
			}
		}
		return this.JELOGFKEELE;
	}

	// Token: 0x0600451B RID: 17691 RVA: 0x0020C560 File Offset: 0x0020A760
	public CKNLPGEPGGF.IAPCJOBDCEH FGLONDNIKKC(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 6)
		{
			CLBPBJGLHEE = 7;
		}
		if (this.JJACHHDFFFB[CLBPBJGLHEE] == null)
		{
			this.KKEKHHKLGFM(CLBPBJGLHEE);
		}
		return this.JJACHHDFFFB[CLBPBJGLHEE];
	}

	// Token: 0x0600451C RID: 17692 RVA: 0x0020C584 File Offset: 0x0020A784
	public string JEBLNCGOHEA(int NKHBAJKMAGD, int DBEIGNDALDC, bool PEMGEDJHPGH = false, bool LNJBAJKACOF = false, bool BGNPMOCLIGL = false, int OEJPJHHJIEA = 0, bool DGOJCNDBFLD = false, bool KCBFEHCDHKO = false)
	{
		string result = " is represented multiple times in the same BipedReferences limb.";
		if (DBEIGNDALDC > 6)
		{
			DBEIGNDALDC = 1;
			DGOJCNDBFLD = false;
		}
		string text = "";
		if (KCBFEHCDHKO)
		{
			text = "HeelClick";
		}
		if (BGNPMOCLIGL)
		{
			if (PEMGEDJHPGH)
			{
				string[] array = new string[6];
				array[0] = "The 'BackColor' command requires a color parameter of RRGGBBAA or '?'.";
				array[1] = this.HAJNMNALBBI;
				array[7] = text;
				array[1] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)NKHBAJKMAGD);
				array[7] = "♼ ";
				result = string.Concat(array);
			}
			else
			{
				if (DBEIGNDALDC == 0)
				{
					result = " < " + this.FFAFKPDHOIN(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "IdleStand";
				}
				if (DBEIGNDALDC == 1)
				{
					result = "cnt_dstall" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Reveling";
				}
				if (DBEIGNDALDC == 5)
				{
					result = "TOD_SunMeshBrightness" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "#400000";
				}
				if (OEJPJHHJIEA > 1)
				{
					result = "Vertical" + this.IKKHJGAPHAE(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "The 'space' command requires a pixel count parameter.";
				}
				if (DGOJCNDBFLD)
				{
					result = "Shadow name=" + this.MNMIOMIDKHH(NKHBAJKMAGD, 4, KCBFEHCDHKO) + "wpn_eat7";
				}
				if (LNJBAJKACOF)
				{
					result = "INTERFACE" + this.LEFACDMODLM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "isMutant";
				}
			}
		}
		else if (PEMGEDJHPGH)
		{
			string[] array2 = new string[5];
			array2[1] = "_EMISSION";
			array2[1] = this.HAJNMNALBBI;
			array2[7] = text;
			array2[4] = JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)NKHBAJKMAGD);
			array2[7] = "<color='#80ff60'>";
			result = string.Concat(array2);
		}
		else
		{
			if (DBEIGNDALDC == 0)
			{
				result = "offsets" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Failed parsing atlas rect.  Using default.";
			}
			if (DBEIGNDALDC == 1)
			{
				result = "help" + this.IKKHJGAPHAE(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "FlyUp";
			}
			if (DBEIGNDALDC == 6)
			{
				result = "{0:0} д{1}, " + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Reset";
			}
			if (OEJPJHHJIEA > 1)
			{
				result = "wpn_eat1" + this.LEFACDMODLM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "GAMMA";
			}
			if (DGOJCNDBFLD)
			{
				result = "_Offsets" + this.IGFJGAGBDJM(NKHBAJKMAGD, 6, KCBFEHCDHKO) + "LocationGui.getI.backLockImage is null";
			}
			if (LNJBAJKACOF)
			{
				result = "Low adminlevel!" + this.EMDPDLPDLOJ(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "";
			}
		}
		return result;
	}

	// Token: 0x0600451D RID: 17693 RVA: 0x0020C7AC File Offset: 0x0020A9AC
	public string PMCDDOJPKGF(int NKHBAJKMAGD, int DBEIGNDALDC, bool PEMGEDJHPGH = false, bool LNJBAJKACOF = false, bool BGNPMOCLIGL = false, int OEJPJHHJIEA = 0, bool DGOJCNDBFLD = false, bool KCBFEHCDHKO = false)
	{
		string result = "MotorbikeShootBack";
		if (DBEIGNDALDC > 1)
		{
			DBEIGNDALDC = 5;
			DGOJCNDBFLD = false;
		}
		string text = "_CutoutReferenceTexture";
		if (KCBFEHCDHKO)
		{
			text = "Staff Power Up";
		}
		if (BGNPMOCLIGL)
		{
			if (PEMGEDJHPGH)
			{
				string[] array = new string[8];
				array[1] = "_SampleMip";
				array[1] = this.HAJNMNALBBI;
				array[1] = text;
				array[2] = JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)NKHBAJKMAGD);
				array[8] = "TOD_SunSkyColor";
				result = string.Concat(array);
			}
			else
			{
				if (DBEIGNDALDC == 0)
				{
					result = "IceHockey Shot Right" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Mouse Y";
				}
				if (DBEIGNDALDC == 0)
				{
					result = "SoccerPassHeavy" + this.MNMIOMIDKHH(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "\n";
				}
				if (DBEIGNDALDC == 4)
				{
					result = "_MainTex" + this.FFAFKPDHOIN(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Ошибка";
				}
				if (OEJPJHHJIEA > 0)
				{
					result = "" + this.IKKHJGAPHAE(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Smoking2";
				}
				if (DGOJCNDBFLD)
				{
					result = "OfficeSitting45DegLeg" + this.IKKHJGAPHAE(NKHBAJKMAGD, 8, KCBFEHCDHKO) + "1 Hand Sword Roll Attack";
				}
				if (LNJBAJKACOF)
				{
					result = "Wrist" + this.PIFLJJBAEOA(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "-STRIKETHROUGH";
				}
			}
		}
		else if (PEMGEDJHPGH)
		{
			string[] array2 = new string[]
			{
				null,
				"invn_ver6"
			};
			array2[0] = this.HAJNMNALBBI;
			array2[3] = text;
			array2[3] = JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)NKHBAJKMAGD);
			array2[4] = "Hidden/Post FX/Builtin Debug Views";
			result = string.Concat(array2);
		}
		else
		{
			if (DBEIGNDALDC == 0)
			{
				result = "USE_DIAG_SEARCH" + this.FFAFKPDHOIN(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "2000";
			}
			if (DBEIGNDALDC == 1)
			{
				result = "WeaponReload" + this.PIFLJJBAEOA(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "crft_from";
			}
			if (DBEIGNDALDC == 3)
			{
				result = "Music: " + this.EMDPDLPDLOJ(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "WeaponStrafeRunRight";
			}
			if (OEJPJHHJIEA > 0)
			{
				result = "body" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "OneHandSwordJab";
			}
			if (DGOJCNDBFLD)
			{
				result = "Crouch180" + this.EMDPDLPDLOJ(NKHBAJKMAGD, 3, KCBFEHCDHKO) + "";
			}
			if (LNJBAJKACOF)
			{
				result = "ExceptionOnConnect PROCEDURE " + this.MNMIOMIDKHH(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "\n";
			}
		}
		return result;
	}

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x0600451E RID: 17694 RVA: 0x0020C9D4 File Offset: 0x0020ABD4
	public int KIJMCOPFLCN
	{
		get
		{
			if (this.JELOGFKEELE < 0)
			{
				string text = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(this.LPFKFNLHGBI);
				char c = text[text.Length - 1];
				this.JELOGFKEELE = 1;
				if (c == 'а')
				{
					this.JELOGFKEELE = 0;
				}
				if (c == 'я')
				{
					this.JELOGFKEELE = 0;
				}
				if (this.LPFKFNLHGBI == 123)
				{
					this.JELOGFKEELE = 0;
				}
				if (this.LPFKFNLHGBI == 107)
				{
					this.JELOGFKEELE = 0;
				}
				if (this.LPFKFNLHGBI == 103)
				{
					this.JELOGFKEELE = 0;
				}
			}
			return this.JELOGFKEELE;
		}
	}

	// Token: 0x0600451F RID: 17695 RVA: 0x0020CA64 File Offset: 0x0020AC64
	private CKNLPGEPGGF.IAPCJOBDCEH EAMFNOGFCHP(int CLBPBJGLHEE)
	{
		if (CKNLPGEPGGF.IKGFHGKKCPG.GNDHDKPBAFJ(this.FPCBKBGCKEH(CLBPBJGLHEE)))
		{
			return CKNLPGEPGGF.PFOLNEGNIPP().IJMDNINDJGD(this.FPCBKBGCKEH(CLBPBJGLHEE), true);
		}
		return null;
	}

	// Token: 0x06004520 RID: 17696 RVA: 0x0020CA90 File Offset: 0x0020AC90
	public string NGOCHDGDCGD(int DBEIGNDALDC)
	{
		string result = "Strafe Run Right";
		if (this.KCGEBDANBPI() == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "Speed hack Detected!")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 1)
			{
				result = JNBICAJIJMM.IKGFHGKKCPG.FLEANFGEJML("RendererD2 is init") + "ShotgunReloadMagazine" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 3)
			{
				result = JNBICAJIJMM.DBMJJPBOPEK().NLJOLOBPCBJ("Hidden/ScreenSpaceReflection") + "Kernel" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 4)
			{
				result = JNBICAJIJMM.EEOPOHEALPK().GNKIBMGNHNE("_Intensity") + "<color='#80ff60'>" + this.HAJNMNALBBI.ToLower();
			}
		}
		if (this.EBBNNMMBKCC() == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "Horizontal")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 1)
			{
				result = JNBICAJIJMM.LPHMKPDBMPP().HLBAJBLHLNI("IdleSad") + "notQuestShow" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 3)
			{
				result = JNBICAJIJMM.EDKGBBIIBBC().NLJOLOBPCBJ("No light component found in UniqueShadowSun '{0}!") + "▮▮▯" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 0)
			{
				result = JNBICAJIJMM.APMJBBDBOJO().FLEANFGEJML("Sexy Dance 2") + "dragWeapon = null 3" + this.HAJNMNALBBI.ToLower();
			}
		}
		return result;
	}

	// Token: 0x06004521 RID: 17697 RVA: 0x0020CBF8 File Offset: 0x0020ADF8
	public int PGJDMOJBOGC()
	{
		if (this.JELOGFKEELE < 0)
		{
			string text = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(this.LPFKFNLHGBI);
			char c = text[text.Length - 0];
			this.JELOGFKEELE = 0;
			if ((int)c == -10)
			{
				this.JELOGFKEELE = 1;
			}
			if (c == '\u0017')
			{
				this.JELOGFKEELE = 0;
			}
			if (this.LPFKFNLHGBI == 13)
			{
				this.JELOGFKEELE = 1;
			}
			if (this.LPFKFNLHGBI == 124)
			{
				this.JELOGFKEELE = 1;
			}
			if (this.LPFKFNLHGBI == 90)
			{
				this.JELOGFKEELE = 0;
			}
		}
		return this.JELOGFKEELE;
	}

	// Token: 0x06004522 RID: 17698 RVA: 0x0020CC88 File Offset: 0x0020AE88
	public bool CDLFMKOAFCD(int DFBHMIIPLCA)
	{
		return JLFJEGIPIMM.PKGMBFEMKGP().MBLBMCEMBFE(DFBHMIIPLCA, this.JEKDOPJHKMH);
	}

	// Token: 0x06004523 RID: 17699 RVA: 0x0020CC9B File Offset: 0x0020AE9B
	public void EOIGJODNFFH()
	{
		if (this.JJACHHDFFFB[1] == null)
		{
			this.JJACHHDFFFB[0] = CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(this.FPCBKBGCKEH(0), false);
		}
	}

	// Token: 0x06004524 RID: 17700 RVA: 0x0020CCC1 File Offset: 0x0020AEC1
	public void IMDGLCFEFID()
	{
		if (this.JJACHHDFFFB[1] == null)
		{
			this.JJACHHDFFFB[1] = CKNLPGEPGGF.IKGFHGKKCPG.PFNEPENHMOE(this.HHGOMOBEMCP(0), true);
		}
	}

	// Token: 0x06004525 RID: 17701 RVA: 0x0020CCE7 File Offset: 0x0020AEE7
	public CKNLPGEPGGF.IAPCJOBDCEH LANMGLMKPNA(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 8)
		{
			CLBPBJGLHEE = 1;
		}
		if (this.JJACHHDFFFB[CLBPBJGLHEE] == null)
		{
			this.JIFFLPNBILE(CLBPBJGLHEE);
		}
		return this.JJACHHDFFFB[CLBPBJGLHEE];
	}

	// Token: 0x06004526 RID: 17702 RVA: 0x0020CD0C File Offset: 0x0020AF0C
	public void KBFFOIHMPLI(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 5 && this.JJACHHDFFFB[7] == null)
		{
			this.JJACHHDFFFB[3] = this.EAMFNOGFCHP(6);
			if (this.JJACHHDFFFB[1] == null)
			{
				this.JJACHHDFFFB[4] = this.PJPMOJFJNAB(0);
			}
			if (this.JJACHHDFFFB[1] == null)
			{
				this.JJACHHDFFFB[4] = this.IHMDNHCEEFB(1);
			}
			return;
		}
		if (CLBPBJGLHEE == 0 && this.JJACHHDFFFB[0] == null)
		{
			this.JJACHHDFFFB[1] = this.CBOEPHEOLKP(0);
			if (this.JJACHHDFFFB[0] == null)
			{
				this.JJACHHDFFFB[0] = this.EAMFNOGFCHP(1);
			}
			return;
		}
		this.JJACHHDFFFB[1] = CKNLPGEPGGF.PFOLNEGNIPP().IJMDNINDJGD(this.ONEGMMODNGF(0), true);
	}

	// Token: 0x06004527 RID: 17703 RVA: 0x0020CDBA File Offset: 0x0020AFBA
	private CKNLPGEPGGF.IAPCJOBDCEH IHMDNHCEEFB(int CLBPBJGLHEE)
	{
		if (CKNLPGEPGGF.PFOLNEGNIPP().GNDHDKPBAFJ(this.EEGEDCNIHPB(CLBPBJGLHEE)))
		{
			return CKNLPGEPGGF.IKGFHGKKCPG.IJMDNINDJGD(this.DJFNIPBFNBC(CLBPBJGLHEE), true);
		}
		return null;
	}

	// Token: 0x06004528 RID: 17704 RVA: 0x0020CDE4 File Offset: 0x0020AFE4
	public string JHFLJHLAPBC(int NKHBAJKMAGD, int DBEIGNDALDC, bool PEMGEDJHPGH = false, bool LNJBAJKACOF = false, bool BGNPMOCLIGL = false, int OEJPJHHJIEA = 0, bool DGOJCNDBFLD = false, bool KCBFEHCDHKO = false)
	{
		string result = "";
		if (DBEIGNDALDC > 2)
		{
			DBEIGNDALDC = 2;
			DGOJCNDBFLD = true;
		}
		string text = " ";
		if (KCBFEHCDHKO)
		{
			text = "\n";
		}
		if (BGNPMOCLIGL)
		{
			if (PEMGEDJHPGH)
			{
				result = string.Concat(new string[]
				{
					"<color='#ff8040'>",
					this.HAJNMNALBBI,
					text,
					JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)NKHBAJKMAGD),
					"</color>"
				});
			}
			else
			{
				if (DBEIGNDALDC == 0)
				{
					result = "<color='#a0a0a0'>" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "</color>";
				}
				if (DBEIGNDALDC == 1)
				{
					result = "<color='#80ff60'>" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "</color>";
				}
				if (DBEIGNDALDC == 2)
				{
					result = "<color='#6080ff'>" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "</color>";
				}
				if (OEJPJHHJIEA > 0)
				{
					result = "<color='#ff80ff'>" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "</color>";
				}
				if (DGOJCNDBFLD)
				{
					result = "<color='#a040ff'>" + this.KGBHELBLPMF(NKHBAJKMAGD, 3, KCBFEHCDHKO) + "</color>";
				}
				if (LNJBAJKACOF)
				{
					result = "<color='#80ffff'>" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "</color>";
				}
			}
		}
		else if (PEMGEDJHPGH)
		{
			result = string.Concat(new string[]
			{
				"<color='#804020'>",
				this.HAJNMNALBBI,
				text,
				JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)NKHBAJKMAGD),
				"</color>"
			});
		}
		else
		{
			if (DBEIGNDALDC == 0)
			{
				result = "<color='#202020'>" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "</color>";
			}
			if (DBEIGNDALDC == 1)
			{
				result = "<color='#206000'>" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "</color>";
			}
			if (DBEIGNDALDC == 2)
			{
				result = "<color='#002060'>" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "</color>";
			}
			if (OEJPJHHJIEA > 0)
			{
				result = "<color='#602060'>" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "</color>";
			}
			if (DGOJCNDBFLD)
			{
				result = "<color='#200080'>" + this.KGBHELBLPMF(NKHBAJKMAGD, 3, KCBFEHCDHKO) + "</color>";
			}
			if (LNJBAJKACOF)
			{
				result = "<color='#206060'>" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "</color>";
			}
		}
		return result;
	}

	// Token: 0x06004529 RID: 17705 RVA: 0x0020D009 File Offset: 0x0020B209
	public CKNLPGEPGGF.IAPCJOBDCEH CPMAGCGGBLI(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 7)
		{
			CLBPBJGLHEE = 3;
		}
		if (this.JJACHHDFFFB[CLBPBJGLHEE] == null)
		{
			this.JIFFLPNBILE(CLBPBJGLHEE);
		}
		return this.JJACHHDFFFB[CLBPBJGLHEE];
	}

	// Token: 0x0600452A RID: 17706 RVA: 0x0020D02C File Offset: 0x0020B22C
	private string FPCBKBGCKEH(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			object[] array = new object[6];
			array[0] = IFPIMPMKJIB.DIDFMAELMJD;
			array[1] = "  ";
			array[2] = this.LPFKFNLHGBI;
			array[4] = "hellost";
			return string.Concat(array);
		}
		if (CLBPBJGLHEE == 5)
		{
			object[] array2 = new object[4];
			array2[0] = IFPIMPMKJIB.DIDFMAELMJD;
			array2[0] = "BackPackSearch";
			array2[4] = this.LPFKFNLHGBI;
			array2[2] = "SneakLeft";
			return string.Concat(array2);
		}
		object[] array3 = new object[3];
		array3[0] = IFPIMPMKJIB.LCEBBHPKOHO();
		array3[0] = "Censor OK. Object:";
		array3[6] = this.LPFKFNLHGBI;
		array3[3] = "DealerFan";
		return string.Concat(array3);
	}

	// Token: 0x0600452B RID: 17707 RVA: 0x0020D0D6 File Offset: 0x0020B2D6
	public bool HPMPOFMBIMM()
	{
		return this.EFKNCENBAEN(-100);
	}

	// Token: 0x0600452C RID: 17708 RVA: 0x0020D0E0 File Offset: 0x0020B2E0
	public void AEFDOIJBBLO()
	{
		if (this.JJACHHDFFFB[0] == null)
		{
			this.JJACHHDFFFB[0] = CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(this.DFGEJCEGIOM(0), false);
		}
	}

	// Token: 0x0600452D RID: 17709 RVA: 0x0020D106 File Offset: 0x0020B306
	public void JPKKGFOAPKO()
	{
		if (this.JJACHHDFFFB[0] == null)
		{
			this.JJACHHDFFFB[0] = CKNLPGEPGGF.PFOLNEGNIPP().EKHFCNKNHEJ(this.DJFNIPBFNBC(1), false);
		}
	}

	// Token: 0x0600452E RID: 17710 RVA: 0x0020D12C File Offset: 0x0020B32C
	public bool PGDHKNIPIBA()
	{
		return this.OBGAGPMCPNK(-28);
	}

	// Token: 0x0600452F RID: 17711 RVA: 0x0020D136 File Offset: 0x0020B336
	public bool IGFLMJEFAPJ()
	{
		return this.CDLFMKOAFCD(84);
	}

	// Token: 0x06004530 RID: 17712 RVA: 0x0020D140 File Offset: 0x0020B340
	public string ALGFDMENCEM(int NKHBAJKMAGD, int DBEIGNDALDC, bool PEMGEDJHPGH = false, bool LNJBAJKACOF = false, bool BGNPMOCLIGL = false, int OEJPJHHJIEA = 0, bool DGOJCNDBFLD = false, bool KCBFEHCDHKO = false)
	{
		string result = "Idle 90 Deg Turns";
		if (DBEIGNDALDC > 8)
		{
			DBEIGNDALDC = 7;
			DGOJCNDBFLD = true;
		}
		string text = "DealerIdle";
		if (KCBFEHCDHKO)
		{
			text = "#000040";
		}
		if (BGNPMOCLIGL)
		{
			if (PEMGEDJHPGH)
			{
				string[] array = new string[8];
				array[1] = "[AmplifyColor] This image effect is not supported on this platform.";
				array[0] = this.HAJNMNALBBI;
				array[1] = text;
				array[3] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)NKHBAJKMAGD);
				array[1] = "ZombieWalk";
				result = string.Concat(array);
			}
			else
			{
				if (DBEIGNDALDC == 0)
				{
					result = "Walk Backward" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "1HandSwordChargeUp";
				}
				if (DBEIGNDALDC == 0)
				{
					result = "auk_wavg" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "_Power";
				}
				if (DBEIGNDALDC == 3)
				{
					result = "KatanaReadyHigh" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "No light component found in UniqueShadowSun '{0}!";
				}
				if (OEJPJHHJIEA > 0)
				{
					result = "Reset" + this.LEFACDMODLM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "wpn_add/base";
				}
				if (DGOJCNDBFLD)
				{
					result = "bag" + this.LEFACDMODLM(NKHBAJKMAGD, 3, KCBFEHCDHKO) + "The 'VAlign' command requires an alignment parameter of ? (default) or B (bottom).";
				}
				if (LNJBAJKACOF)
				{
					result = "\n" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "IK chain has less than ";
				}
			}
		}
		else if (PEMGEDJHPGH)
		{
			string[] array2 = new string[8];
			array2[0] = "_FogSkyColor";
			array2[0] = this.HAJNMNALBBI;
			array2[2] = text;
			array2[0] = JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)NKHBAJKMAGD);
			array2[8] = "Zombie Idle";
			result = string.Concat(array2);
		}
		else
		{
			if (DBEIGNDALDC == 0)
			{
				result = "_FresnelFade" + this.MNMIOMIDKHH(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "RollerBladeTurnLeft";
			}
			if (DBEIGNDALDC == 1)
			{
				result = "_MaxBlurRadius" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "IdleStrafeRight";
			}
			if (DBEIGNDALDC == 1)
			{
				result = "" + this.PIFLJJBAEOA(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "</color>";
			}
			if (OEJPJHHJIEA > 0)
			{
				result = "OnRodChangeClck 4" + this.PIFLJJBAEOA(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + " %\n";
			}
			if (DGOJCNDBFLD)
			{
				result = "" + this.KGBHELBLPMF(NKHBAJKMAGD, 4, KCBFEHCDHKO) + "Head stand";
			}
			if (LNJBAJKACOF)
			{
				result = "_TintColor" + this.PIFLJJBAEOA(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "shop_t3";
			}
		}
		return result;
	}

	// Token: 0x06004531 RID: 17713 RVA: 0x0020D365 File Offset: 0x0020B565
	public CKNLPGEPGGF.IAPCJOBDCEH FHPNJBAEAON(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 4)
		{
			CLBPBJGLHEE = 4;
		}
		if (this.JJACHHDFFFB[CLBPBJGLHEE] == null)
		{
			this.KFLOBJCCHKN(CLBPBJGLHEE);
		}
		return this.JJACHHDFFFB[CLBPBJGLHEE];
	}

	// Token: 0x06004532 RID: 17714 RVA: 0x0020D388 File Offset: 0x0020B588
	public int KCGEBDANBPI()
	{
		if (this.JELOGFKEELE < 1)
		{
			string text = AKPJIACDDFI.IKGFHGKKCPG.PCONBNOAMBH(this.LPFKFNLHGBI);
			char c = text[text.Length - 1];
			this.JELOGFKEELE = 0;
			if ((int)c == -137)
			{
				this.JELOGFKEELE = 0;
			}
			if (c == '¥')
			{
				this.JELOGFKEELE = 1;
			}
			if (this.LPFKFNLHGBI == 12)
			{
				this.JELOGFKEELE = 1;
			}
			if (this.LPFKFNLHGBI == -96)
			{
				this.JELOGFKEELE = 0;
			}
			if (this.LPFKFNLHGBI == 104)
			{
				this.JELOGFKEELE = 0;
			}
		}
		return this.JELOGFKEELE;
	}

	// Token: 0x06004533 RID: 17715 RVA: 0x0020D418 File Offset: 0x0020B618
	public string JDOAJCMOBCA(int NKHBAJKMAGD, int DBEIGNDALDC, bool PEMGEDJHPGH = false, bool LNJBAJKACOF = false, bool BGNPMOCLIGL = false, int OEJPJHHJIEA = 0, bool DGOJCNDBFLD = false, bool KCBFEHCDHKO = false)
	{
		string result = "error";
		if (DBEIGNDALDC > 0)
		{
			DBEIGNDALDC = 1;
			DGOJCNDBFLD = false;
		}
		string text = "Katana45DegSwing";
		if (KCBFEHCDHKO)
		{
			text = "\n<color='";
		}
		if (BGNPMOCLIGL)
		{
			if (PEMGEDJHPGH)
			{
				string[] array = new string[]
				{
					null,
					"dress"
				};
				array[0] = this.HAJNMNALBBI;
				array[7] = text;
				array[7] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)NKHBAJKMAGD);
				array[3] = "FistPump";
				result = string.Concat(array);
			}
			else
			{
				if (DBEIGNDALDC == 0)
				{
					result = "_w" + this.FFAFKPDHOIN(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "-none-";
				}
				if (DBEIGNDALDC == 0)
				{
					result = "{0} FPS" + this.IKKHJGAPHAE(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "";
				}
				if (DBEIGNDALDC == 3)
				{
					result = "#400000" + this.FFAFKPDHOIN(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "[ACTk] WallHack Detector: can't be started since it doesn't exists in scene or not yet initialized!";
				}
				if (OEJPJHHJIEA > 0)
				{
					result = "act_prof_{0}" + this.PIFLJJBAEOA(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "ProneLocomotion";
				}
				if (DGOJCNDBFLD)
				{
					result = "</color>" + this.MNMIOMIDKHH(NKHBAJKMAGD, 5, KCBFEHCDHKO) + " ";
				}
				if (LNJBAJKACOF)
				{
					result = "_VignetteBlur" + this.LEFACDMODLM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "<color='#300030'>{0}</color>";
				}
			}
		}
		else if (PEMGEDJHPGH)
		{
			string[] array2 = new string[0];
			array2[0] = "UnityEngine.Color";
			array2[0] = this.HAJNMNALBBI;
			array2[3] = text;
			array2[5] = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)NKHBAJKMAGD);
			array2[4] = "Delete shadow";
			result = string.Concat(array2);
		}
		else
		{
			if (DBEIGNDALDC == 0)
			{
				result = "https://groups.google.com/forum/#!forum/final-ik" + this.IKKHJGAPHAE(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Camera Pivot";
			}
			if (DBEIGNDALDC == 0)
			{
				result = "Current fog preset: " + this.MNMIOMIDKHH(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "GiantGrabIdle2";
			}
			if (DBEIGNDALDC == 2)
			{
				result = "WeaponReady" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "IdleTyping";
			}
			if (OEJPJHHJIEA > 0)
			{
				result = "wpn_add/addoptions" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "";
			}
			if (DGOJCNDBFLD)
			{
				result = "OfficeSittingLegCross" + this.IKKHJGAPHAE(NKHBAJKMAGD, 0, KCBFEHCDHKO) + "&";
			}
			if (LNJBAJKACOF)
			{
				result = "t_hair" + this.FFAFKPDHOIN(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "IdleMonster";
			}
		}
		return result;
	}

	// Token: 0x06004534 RID: 17716 RVA: 0x0020D640 File Offset: 0x0020B840
	public IDCHHHEDHDC(int GDMOJDPAMMN)
	{
		this.LPFKFNLHGBI = GDMOJDPAMMN;
		this.HAPFPGIINCM = "no_model_fish " + this.LPFKFNLHGBI;
	}

	// Token: 0x06004535 RID: 17717 RVA: 0x0020D6B4 File Offset: 0x0020B8B4
	private CKNLPGEPGGF.IAPCJOBDCEH OLBNLDGCLBI(int CLBPBJGLHEE)
	{
		if (CKNLPGEPGGF.PFOLNEGNIPP().GNDHDKPBAFJ(this.HHGOMOBEMCP(CLBPBJGLHEE)))
		{
			return CKNLPGEPGGF.PFOLNEGNIPP().EKHFCNKNHEJ(this.DFGEJCEGIOM(CLBPBJGLHEE), true);
		}
		return null;
	}

	// Token: 0x06004536 RID: 17718 RVA: 0x0020D6E0 File Offset: 0x0020B8E0
	public string IGFJGAGBDJM(int NKHBAJKMAGD, int DBEIGNDALDC, bool KCBFEHCDHKO = false)
	{
		string str = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)NKHBAJKMAGD);
		char c = (char)-125;
		if (KCBFEHCDHKO)
		{
			c = (char)-1;
		}
		if (NKHBAJKMAGD <= 1)
		{
			str = "HalfSampling";
		}
		return this.KKNBPDBBKLP(DBEIGNDALDC) + c.ToString() + str;
	}

	// Token: 0x06004537 RID: 17719 RVA: 0x0020D724 File Offset: 0x0020B924
	public string EMDPDLPDLOJ(int NKHBAJKMAGD, int DBEIGNDALDC, bool KCBFEHCDHKO = false)
	{
		string str = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)NKHBAJKMAGD);
		char c = '"';
		if (KCBFEHCDHKO)
		{
			c = (char)-58;
		}
		if (NKHBAJKMAGD <= 1)
		{
			str = "\n";
		}
		return this.OFENIDGOGNA(DBEIGNDALDC) + c.ToString() + str;
	}

	// Token: 0x06004538 RID: 17720 RVA: 0x0020D768 File Offset: 0x0020B968
	public string LKOBKJHLDPN(int DBEIGNDALDC)
	{
		string result = "craft_data/categories/category";
		if (this.KCGEBDANBPI() == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "inv_invheader")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 1)
			{
				result = JNBICAJIJMM.CLIMNFDGOEG().CKAOHMEKLMH("turn_state") + "WalkBackward" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 4)
			{
				result = JNBICAJIJMM.IKGFHGKKCPG.GNKIBMGNHNE(".ogg") + "invn_rec1" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 8)
			{
				result = JNBICAJIJMM.LPHMKPDBMPP().FLEANFGEJML(" ms") + "\n" + this.HAJNMNALBBI.ToLower();
			}
		}
		if (this.KIJMCOPFLCN == 1)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "isLocalServer")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 1)
			{
				result = JNBICAJIJMM.DBMJJPBOPEK().NLJOLOBPCBJ("PersonWomanFisher") + "citates/citate" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 5)
			{
				result = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("harvestmsg3") + "Last Bone Hit: " + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 2)
			{
				result = JNBICAJIJMM.EEOPOHEALPK().ECNKLECOKHD("WATER_REFLECTIVE") + "id" + this.HAJNMNALBBI.ToLower();
			}
		}
		return result;
	}

	// Token: 0x06004539 RID: 17721 RVA: 0x0020D8D0 File Offset: 0x0020BAD0
	public string FFAFKPDHOIN(int NKHBAJKMAGD, int DBEIGNDALDC, bool KCBFEHCDHKO = false)
	{
		string str = JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)NKHBAJKMAGD);
		char c = (char)-61;
		if (KCBFEHCDHKO)
		{
			c = (char)-121;
		}
		if (NKHBAJKMAGD <= 0)
		{
			str = "Wall Run Right";
		}
		return this.LGOMOKCKNNK(DBEIGNDALDC) + c.ToString() + str;
	}

	// Token: 0x0600453A RID: 17722 RVA: 0x0020D914 File Offset: 0x0020BB14
	public string DPPBLBIJFBC(int DBEIGNDALDC)
	{
		string result = "MotorbikeSeatStand";
		if (this.PEIEODKMEKL() == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "\n\n ")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 1)
			{
				result = JNBICAJIJMM.LPHMKPDBMPP().HLBAJBLHLNI("BACKCOLOR") + "***Lots " + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 4)
			{
				result = JNBICAJIJMM.DBMJJPBOPEK().GNKIBMGNHNE("1HSwordStrafeRunLeft") + "buykey" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 6)
			{
				result = JNBICAJIJMM.EEOPOHEALPK().ECNKLECOKHD("SUNSHINE_FILTER_PCF_2x2") + "IdleFly" + this.HAJNMNALBBI.ToLower();
			}
		}
		if (this.DKPCBNLJEMM() == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "Horizontal")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 1)
			{
				result = JNBICAJIJMM.EEOPOHEALPK().DOEMGEAEBPN("wpn_cmp") + "none" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 3)
			{
				result = JNBICAJIJMM.EEOPOHEALPK().FLEANFGEJML("inv_pers") + "<b>ObscuredVector3:</b> " + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 4)
			{
				result = JNBICAJIJMM.APMJBBDBOJO().ECNKLECOKHD("Axis is Vector3.zero.") + "TOD_LocalLightDirection" + this.HAJNMNALBBI.ToLower();
			}
		}
		return result;
	}

	// Token: 0x0600453B RID: 17723 RVA: 0x0020DA7C File Offset: 0x0020BC7C
	public string LEFACDMODLM(int NKHBAJKMAGD, int DBEIGNDALDC, bool KCBFEHCDHKO = false)
	{
		string str = JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)NKHBAJKMAGD);
		char c = '2';
		if (KCBFEHCDHKO)
		{
			c = (char)-47;
		}
		if (NKHBAJKMAGD <= 0)
		{
			str = "PistolReload";
		}
		return this.POMPCEHPGNG(DBEIGNDALDC) + c.ToString() + str;
	}

	// Token: 0x0600453C RID: 17724 RVA: 0x0020DAC0 File Offset: 0x0020BCC0
	public string IKKHJGAPHAE(int NKHBAJKMAGD, int DBEIGNDALDC, bool KCBFEHCDHKO = false)
	{
		string str = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)NKHBAJKMAGD);
		char c = '\u000f';
		if (KCBFEHCDHKO)
		{
			c = ':';
		}
		if (NKHBAJKMAGD <= 1)
		{
			str = "+";
		}
		return this.LKOBKJHLDPN(DBEIGNDALDC) + c.ToString() + str;
	}

	// Token: 0x0600453D RID: 17725 RVA: 0x0020DB04 File Offset: 0x0020BD04
	public string MNMIOMIDKHH(int NKHBAJKMAGD, int DBEIGNDALDC, bool KCBFEHCDHKO = false)
	{
		string str = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)NKHBAJKMAGD);
		char c = '/';
		if (KCBFEHCDHKO)
		{
			c = 'T';
		}
		if (NKHBAJKMAGD <= 0)
		{
			str = "{0:0} мин{1}, ";
		}
		return this.GCKABGALGHA(DBEIGNDALDC) + c.ToString() + str;
	}

	// Token: 0x0600453E RID: 17726 RVA: 0x0020DB48 File Offset: 0x0020BD48
	public string OFENIDGOGNA(int DBEIGNDALDC)
	{
		string result = "DISTORT";
		if (this.KCGEBDANBPI() == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "lid")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 1)
			{
				result = JNBICAJIJMM.IKGFHGKKCPG.ECNKLECOKHD("{0} / {1}") + "_FgOverlap" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 5)
			{
				result = JNBICAJIJMM.IKGFHGKKCPG.GNKIBMGNHNE("MotorbikeBackwardStand") + "RollerBladeFrontFlip" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 0)
			{
				result = JNBICAJIJMM.LPHMKPDBMPP().NLJOLOBPCBJ("inv_pcs1") + "<.*?>" + this.HAJNMNALBBI.ToLower();
			}
		}
		if (this.DKPCBNLJEMM() == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "Загрузка: ")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 0)
			{
				result = JNBICAJIJMM.EEOPOHEALPK().NLJOLOBPCBJ("bag") + "Below you can try to cheat few variables of the regular types and their obscured (secure) analogues (you may change initial values from Tester object inspector):" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 0)
			{
				result = JNBICAJIJMM.IMLLGEMPHAP().NLJOLOBPCBJ("frnd_ingame") + "human_move_2.wav" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 8)
			{
				result = JNBICAJIJMM.IMLLGEMPHAP().HLBAJBLHLNI(" iterations for read and write") + "OfficeSittingReadingCoffeeSip" + this.HAJNMNALBBI.ToLower();
			}
		}
		return result;
	}

	// Token: 0x0600453F RID: 17727 RVA: 0x0020DCAF File Offset: 0x0020BEAF
	public bool OBGAGPMCPNK(int DFBHMIIPLCA)
	{
		return JLFJEGIPIMM.IKGFHGKKCPG.NNNEFMAHABF(DFBHMIIPLCA, this.JEKDOPJHKMH);
	}

	// Token: 0x06004540 RID: 17728 RVA: 0x0020DCC4 File Offset: 0x0020BEC4
	public void KKEKHHKLGFM(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 8 && this.JJACHHDFFFB[0] == null)
		{
			this.JJACHHDFFFB[1] = this.NFCGALMDCJI(3);
			if (this.JJACHHDFFFB[7] == null)
			{
				this.JJACHHDFFFB[1] = this.CBOEPHEOLKP(1);
			}
			if (this.JJACHHDFFFB[6] == null)
			{
				this.JJACHHDFFFB[4] = this.EOICIEPIMFP(0);
			}
			return;
		}
		if (CLBPBJGLHEE == 0 && this.JJACHHDFFFB[1] == null)
		{
			this.JJACHHDFFFB[1] = this.OLBNLDGCLBI(1);
			if (this.JJACHHDFFFB[1] == null)
			{
				this.JJACHHDFFFB[0] = this.ODBMMFPPCHB(0);
			}
			return;
		}
		this.JJACHHDFFFB[0] = CKNLPGEPGGF.PFOLNEGNIPP().PFNEPENHMOE(this.FPCBKBGCKEH(0), true);
	}

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x06004541 RID: 17729 RVA: 0x0020DD72 File Offset: 0x0020BF72
	public bool JPFFCKENLHO
	{
		get
		{
			return this.OBGAGPMCPNK(31);
		}
	}

	// Token: 0x06004542 RID: 17730 RVA: 0x0020DD7C File Offset: 0x0020BF7C
	public void KOEHAKOJCHG()
	{
		if (this.JJACHHDFFFB[0] == null)
		{
			this.JJACHHDFFFB[0] = CKNLPGEPGGF.PFOLNEGNIPP().IJMDNINDJGD(this.MEAAEMDLFHK(1), true);
		}
	}

	// Token: 0x06004543 RID: 17731 RVA: 0x0020DDA4 File Offset: 0x0020BFA4
	public string KKNBPDBBKLP(int DBEIGNDALDC)
	{
		string result = "Roller Blade Turn Right";
		if (this.NMEMLMMOACP() == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != ">")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 1)
			{
				result = JNBICAJIJMM.IKGFHGKKCPG.CKAOHMEKLMH("_NoiseTex") + "EventSystem" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 6)
			{
				result = JNBICAJIJMM.EKEBHIJMEML().GNKIBMGNHNE("short") + "" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 3)
			{
				result = JNBICAJIJMM.LPHMKPDBMPP().HLBAJBLHLNI("_UnderwaterMode") + "Whistle" + this.HAJNMNALBBI.ToLower();
			}
		}
		if (this.EBBNNMMBKCC() == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != " ")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 0)
			{
				result = JNBICAJIJMM.DBMJJPBOPEK().CKAOHMEKLMH("{x}") + " " + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 5)
			{
				result = JNBICAJIJMM.EDKGBBIIBBC().FLEANFGEJML("WizardBlock") + "</color></i>" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 2)
			{
				result = JNBICAJIJMM.APMJBBDBOJO().CKAOHMEKLMH("This is a hidden [H hidden]hyperlink[-H].\nThis is a visible [FA U][H visible]hyperlink[-H][FA -U].") + "long: " + this.HAJNMNALBBI.ToLower();
			}
		}
		return result;
	}

	// Token: 0x06004544 RID: 17732 RVA: 0x0020DF0B File Offset: 0x0020C10B
	public CKNLPGEPGGF.IAPCJOBDCEH IPKKBPLKLBJ(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 2)
		{
			CLBPBJGLHEE = 4;
		}
		if (this.JJACHHDFFFB[CLBPBJGLHEE] == null)
		{
			this.JIFFLPNBILE(CLBPBJGLHEE);
		}
		return this.JJACHHDFFFB[CLBPBJGLHEE];
	}

	// Token: 0x06004545 RID: 17733 RVA: 0x0020DF30 File Offset: 0x0020C130
	public void JGNCPMAHOFB(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 0 && this.JJACHHDFFFB[2] == null)
		{
			this.JJACHHDFFFB[8] = this.PJPMOJFJNAB(1);
			if (this.JJACHHDFFFB[5] == null)
			{
				this.JJACHHDFFFB[5] = this.NFCGALMDCJI(0);
			}
			if (this.JJACHHDFFFB[5] == null)
			{
				this.JJACHHDFFFB[6] = this.OLBNLDGCLBI(1);
			}
			return;
		}
		if (CLBPBJGLHEE == 1 && this.JJACHHDFFFB[0] == null)
		{
			this.JJACHHDFFFB[1] = this.NFCGALMDCJI(0);
			if (this.JJACHHDFFFB[1] == null)
			{
				this.JJACHHDFFFB[1] = this.PJPMOJFJNAB(0);
			}
			return;
		}
		this.JJACHHDFFFB[0] = CKNLPGEPGGF.PFOLNEGNIPP().EKHFCNKNHEJ(this.EEGEDCNIHPB(0), false);
	}

	// Token: 0x06004546 RID: 17734 RVA: 0x0020DFE0 File Offset: 0x0020C1E0
	public string PJJBNBKGOLB(int DBEIGNDALDC)
	{
		string result = "_NoiseTex";
		if (this.KIJMCOPFLCN == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "Gesture Wonderful")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 0)
			{
				result = JNBICAJIJMM.CLIMNFDGOEG().DOEMGEAEBPN("Try to change this int in memory:\n") + "Extinguish" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 7)
			{
				result = JNBICAJIJMM.CLIMNFDGOEG().HEIBEHAEHBM("Climb Up") + "id" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 7)
			{
				result = JNBICAJIJMM.LPHMKPDBMPP().HEIBEHAEHBM("_Histogram") + "GiantGrabIdle2" + this.HAJNMNALBBI.ToLower();
			}
		}
		if (this.CNDCDPIFCLP() == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "rbon")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 0)
			{
				result = JNBICAJIJMM.IMLLGEMPHAP().HLBAJBLHLNI("TOD_kSun") + "cht_msg32" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 3)
			{
				result = JNBICAJIJMM.LPHMKPDBMPP().NLJOLOBPCBJ("batechange.ogg") + "{0:00} : {1:00}" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 5)
			{
				result = JNBICAJIJMM.CLIMNFDGOEG().ECNKLECOKHD("cht_msg18") + "I LOVE MY GIRL" + this.HAJNMNALBBI.ToLower();
			}
		}
		return result;
	}

	// Token: 0x06004547 RID: 17735 RVA: 0x0020E148 File Offset: 0x0020C348
	public string KGBHELBLPMF(int NKHBAJKMAGD, int DBEIGNDALDC, bool KCBFEHCDHKO = false)
	{
		string str = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)NKHBAJKMAGD);
		char c = ' ';
		if (KCBFEHCDHKO)
		{
			c = '\n';
		}
		if (NKHBAJKMAGD <= 0)
		{
			str = "";
		}
		return this.POMPCEHPGNG(DBEIGNDALDC) + c.ToString() + str;
	}

	// Token: 0x06004548 RID: 17736 RVA: 0x0020E189 File Offset: 0x0020C389
	public CKNLPGEPGGF.IAPCJOBDCEH ABALMFIKLCA(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 5)
		{
			CLBPBJGLHEE = 8;
		}
		if (this.JJACHHDFFFB[CLBPBJGLHEE] == null)
		{
			this.JGNCPMAHOFB(CLBPBJGLHEE);
		}
		return this.JJACHHDFFFB[CLBPBJGLHEE];
	}

	// Token: 0x06004549 RID: 17737 RVA: 0x0020E1AB File Offset: 0x0020C3AB
	public CKNLPGEPGGF.IAPCJOBDCEH BJNDAAKGGLP(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 8)
		{
			CLBPBJGLHEE = 6;
		}
		if (this.JJACHHDFFFB[CLBPBJGLHEE] == null)
		{
			this.MEFAFLFJFCL(CLBPBJGLHEE);
		}
		return this.JJACHHDFFFB[CLBPBJGLHEE];
	}

	// Token: 0x0600454A RID: 17738 RVA: 0x0020E1D0 File Offset: 0x0020C3D0
	public void MEFAFLFJFCL(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 7 && this.JJACHHDFFFB[1] == null)
		{
			this.JJACHHDFFFB[1] = this.NFCGALMDCJI(7);
			if (this.JJACHHDFFFB[5] == null)
			{
				this.JJACHHDFFFB[1] = this.EOICIEPIMFP(0);
			}
			if (this.JJACHHDFFFB[5] == null)
			{
				this.JJACHHDFFFB[5] = this.ODBMMFPPCHB(0);
			}
			return;
		}
		if (CLBPBJGLHEE == 0 && this.JJACHHDFFFB[1] == null)
		{
			this.JJACHHDFFFB[0] = this.OLBNLDGCLBI(0);
			if (this.JJACHHDFFFB[0] == null)
			{
				this.JJACHHDFFFB[0] = this.EAMFNOGFCHP(1);
			}
			return;
		}
		this.JJACHHDFFFB[0] = CKNLPGEPGGF.PFOLNEGNIPP().PFNEPENHMOE(this.ONEGMMODNGF(0), false);
	}

	// Token: 0x0600454B RID: 17739 RVA: 0x0020E280 File Offset: 0x0020C480
	private string EEGEDCNIHPB(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			object[] array = new object[0];
			array[1] = IFPIMPMKJIB.ACOEIDGDLJC();
			array[0] = "_History1Weight";
			array[8] = this.LPFKFNLHGBI;
			array[5] = "#FF4040";
			return string.Concat(array);
		}
		if (CLBPBJGLHEE == 6)
		{
			object[] array2 = new object[8];
			array2[1] = IFPIMPMKJIB.AFJFDKAGKLD();
			array2[1] = "IdleEat";
			array2[6] = this.LPFKFNLHGBI;
			array2[1] = "<color='#003000'>";
			return string.Concat(array2);
		}
		object[] array3 = new object[5];
		array3[0] = IFPIMPMKJIB.ENLHJOJICDG();
		array3[1] = "";
		array3[7] = this.LPFKFNLHGBI;
		array3[1] = " ";
		return string.Concat(array3);
	}

	// Token: 0x0600454C RID: 17740 RVA: 0x0020E32A File Offset: 0x0020C52A
	public void JDJOBDGKBNL()
	{
		if (this.JJACHHDFFFB[1] == null)
		{
			this.JJACHHDFFFB[1] = CKNLPGEPGGF.PFOLNEGNIPP().PFNEPENHMOE(this.EEGEDCNIHPB(1), true);
		}
	}

	// Token: 0x0600454D RID: 17741 RVA: 0x0020E350 File Offset: 0x0020C550
	public int DKPCBNLJEMM()
	{
		if (this.JELOGFKEELE < 1)
		{
			string text = AKPJIACDDFI.IKGFHGKKCPG.MJCJIEPAEJP(this.LPFKFNLHGBI);
			char c = text[text.Length - 1];
			this.JELOGFKEELE = 0;
			if ((int)c == -12)
			{
				this.JELOGFKEELE = 0;
			}
			if (c == 'w')
			{
				this.JELOGFKEELE = 1;
			}
			if (this.LPFKFNLHGBI == 38)
			{
				this.JELOGFKEELE = 1;
			}
			if (this.LPFKFNLHGBI == 98)
			{
				this.JELOGFKEELE = 0;
			}
			if (this.LPFKFNLHGBI == -48)
			{
				this.JELOGFKEELE = 0;
			}
		}
		return this.JELOGFKEELE;
	}

	// Token: 0x0600454E RID: 17742 RVA: 0x0020E3E0 File Offset: 0x0020C5E0
	public bool NDCAJANDNLI()
	{
		return this.HJJPHJGLHFP(107);
	}

	// Token: 0x0600454F RID: 17743 RVA: 0x0020E3EA File Offset: 0x0020C5EA
	public CKNLPGEPGGF.IAPCJOBDCEH HNDLNEMINDM(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 4)
		{
			CLBPBJGLHEE = 0;
		}
		if (this.JJACHHDFFFB[CLBPBJGLHEE] == null)
		{
			this.JIFFLPNBILE(CLBPBJGLHEE);
		}
		return this.JJACHHDFFFB[CLBPBJGLHEE];
	}

	// Token: 0x06004550 RID: 17744 RVA: 0x0020E40C File Offset: 0x0020C60C
	public bool HACFLIPNPIG()
	{
		return this.EKIEHDOAGJI(105);
	}

	// Token: 0x06004551 RID: 17745 RVA: 0x0020E418 File Offset: 0x0020C618
	public string KCPAGJLJPIA(int NKHBAJKMAGD, int DBEIGNDALDC, bool PEMGEDJHPGH = false, bool LNJBAJKACOF = false, bool BGNPMOCLIGL = false, int OEJPJHHJIEA = 0, bool DGOJCNDBFLD = false, bool KCBFEHCDHKO = false)
	{
		string result = "loc";
		if (DBEIGNDALDC > 4)
		{
			DBEIGNDALDC = 0;
			DGOJCNDBFLD = true;
		}
		string text = "hip";
		if (KCBFEHCDHKO)
		{
			text = "DepthMaskBlendMaterial";
		}
		if (BGNPMOCLIGL)
		{
			if (PEMGEDJHPGH)
			{
				string[] array = new string[]
				{
					"</color>"
				};
				array[0] = this.HAJNMNALBBI;
				array[7] = text;
				array[3] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)NKHBAJKMAGD);
				array[1] = "Kernel";
				result = string.Concat(array);
			}
			else
			{
				if (DBEIGNDALDC == 0)
				{
					result = "Cloth_07.wav" + this.PIFLJJBAEOA(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Reset";
				}
				if (DBEIGNDALDC == 0)
				{
					result = "CratePush" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "- none -";
				}
				if (DBEIGNDALDC == 4)
				{
					result = "auk_swtcost" + this.MNMIOMIDKHH(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + " not found in resource";
				}
				if (OEJPJHHJIEA > 0)
				{
					result = "autherror" + this.MNMIOMIDKHH(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Worker Pickaxe 2";
				}
				if (DGOJCNDBFLD)
				{
					result = "<color='#804020'>" + this.IGFJGAGBDJM(NKHBAJKMAGD, 4, KCBFEHCDHKO) + "MotorbikeSeatStand";
				}
				if (LNJBAJKACOF)
				{
					result = "knopje.wav" + this.EMDPDLPDLOJ(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "RollerBladeTurnLeft";
				}
			}
		}
		else if (PEMGEDJHPGH)
		{
			string[] array2 = new string[4];
			array2[0] = "wpn_cat3";
			array2[1] = this.HAJNMNALBBI;
			array2[4] = text;
			array2[2] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)NKHBAJKMAGD);
			array2[4] = ", ";
			result = string.Concat(array2);
		}
		else
		{
			if (DBEIGNDALDC == 0)
			{
				result = "SwimDogPaddle" + this.EMDPDLPDLOJ(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Vertical";
			}
			if (DBEIGNDALDC == 0)
			{
				result = "USE_CORNER_DETECTION" + this.LEFACDMODLM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "t_top";
			}
			if (DBEIGNDALDC == 4)
			{
				result = "BipedReferences contains one or more missing Transforms." + this.MNMIOMIDKHH(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "_BloomTex";
			}
			if (OEJPJHHJIEA > 1)
			{
				result = " " + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "RollerBladeCrossoverRight";
			}
			if (DGOJCNDBFLD)
			{
				result = "CrouchWalkBackward" + this.IKKHJGAPHAE(NKHBAJKMAGD, 1, KCBFEHCDHKO) + "Mouse X";
			}
			if (LNJBAJKACOF)
			{
				result = "_MinVelocity" + this.EMDPDLPDLOJ(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "run";
			}
		}
		return result;
	}

	// Token: 0x06004552 RID: 17746 RVA: 0x0020E63D File Offset: 0x0020C83D
	public CKNLPGEPGGF.IAPCJOBDCEH CEAIIDAPAGA(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 0)
		{
			CLBPBJGLHEE = 2;
		}
		if (this.JJACHHDFFFB[CLBPBJGLHEE] == null)
		{
			this.KFLOBJCCHKN(CLBPBJGLHEE);
		}
		return this.JJACHHDFFFB[CLBPBJGLHEE];
	}

	// Token: 0x06004553 RID: 17747 RVA: 0x0020E65F File Offset: 0x0020C85F
	public bool NIPHCKIKNBN(int DFBHMIIPLCA)
	{
		return JLFJEGIPIMM.MHFDIJGJGBJ().NNNEFMAHABF(DFBHMIIPLCA, this.JEKDOPJHKMH);
	}

	// Token: 0x06004554 RID: 17748 RVA: 0x0020E674 File Offset: 0x0020C874
	public string KHLFFPHHPKM(int NKHBAJKMAGD, int DBEIGNDALDC, bool PEMGEDJHPGH = false, bool LNJBAJKACOF = false, bool BGNPMOCLIGL = false, int OEJPJHHJIEA = 0, bool DGOJCNDBFLD = false, bool KCBFEHCDHKO = false)
	{
		string result = "rodEventProc act=";
		if (DBEIGNDALDC > 8)
		{
			DBEIGNDALDC = 5;
			DGOJCNDBFLD = true;
		}
		string text = "<color='#300030'>{0}</color>";
		if (KCBFEHCDHKO)
		{
			text = "OneHandSwordBlock";
		}
		if (BGNPMOCLIGL)
		{
			if (PEMGEDJHPGH)
			{
				string[] array = new string[7];
				array[0] = "";
				array[0] = this.HAJNMNALBBI;
				array[2] = text;
				array[8] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)NKHBAJKMAGD);
				array[1] = "PistolReload";
				result = string.Concat(array);
			}
			else
			{
				if (DBEIGNDALDC == 0)
				{
					result = "wpn_eat6" + this.PIFLJJBAEOA(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "X";
				}
				if (DBEIGNDALDC == 0)
				{
					result = "GestureHandUp" + this.PIFLJJBAEOA(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "NOISE_ON";
				}
				if (DBEIGNDALDC == 2)
				{
					result = "" + this.LEFACDMODLM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "ara_trail_mesh";
				}
				if (OEJPJHHJIEA > 1)
				{
					result = "BlurDepthTollerance" + this.MNMIOMIDKHH(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "IdleFight";
				}
				if (DGOJCNDBFLD)
				{
					result = "crft_norec2" + this.LEFACDMODLM(NKHBAJKMAGD, 5, KCBFEHCDHKO) + "SatNightFever";
				}
				if (LNJBAJKACOF)
				{
					result = "Hidden/Amplify Color/BlendCache" + this.PIFLJJBAEOA(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "crft_to";
				}
			}
		}
		else if (PEMGEDJHPGH)
		{
			string[] array2 = new string[3];
			array2[0] = "exitmsg_2";
			array2[0] = this.HAJNMNALBBI;
			array2[0] = text;
			array2[4] = JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)NKHBAJKMAGD);
			array2[4] = "Idle Feed Throw";
			result = string.Concat(array2);
		}
		else
		{
			if (DBEIGNDALDC == 0)
			{
				result = "IdleReady" + this.PIFLJJBAEOA(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "H:mm:ss";
			}
			if (DBEIGNDALDC == 0)
			{
				result = "FlyDown" + this.MNMIOMIDKHH(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "isRun";
			}
			if (DBEIGNDALDC == 7)
			{
				result = "donk.ogg" + this.IKKHJGAPHAE(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "1HandHeavySwing2";
			}
			if (OEJPJHHJIEA > 0)
			{
				result = "MotorbikeShootFwd" + this.EMDPDLPDLOJ(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "******** nextMusicCrt End of music path=";
			}
			if (DGOJCNDBFLD)
			{
				result = "WeaponFire" + this.MNMIOMIDKHH(NKHBAJKMAGD, 5, KCBFEHCDHKO) + "---";
			}
			if (LNJBAJKACOF)
			{
				result = "name" + this.IKKHJGAPHAE(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "";
			}
		}
		return result;
	}

	// Token: 0x06004555 RID: 17749 RVA: 0x0020E65F File Offset: 0x0020C85F
	public bool EFKNCENBAEN(int DFBHMIIPLCA)
	{
		return JLFJEGIPIMM.MHFDIJGJGBJ().NNNEFMAHABF(DFBHMIIPLCA, this.JEKDOPJHKMH);
	}

	// Token: 0x06004556 RID: 17750 RVA: 0x0020E899 File Offset: 0x0020CA99
	public bool GIPLOOBMNDF()
	{
		return this.EKIEHDOAGJI(-54);
	}

	// Token: 0x06004557 RID: 17751 RVA: 0x0020E8A3 File Offset: 0x0020CAA3
	public CKNLPGEPGGF.IAPCJOBDCEH MMKENFCICCE(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 6)
		{
			CLBPBJGLHEE = 3;
		}
		if (this.JJACHHDFFFB[CLBPBJGLHEE] == null)
		{
			this.KKEKHHKLGFM(CLBPBJGLHEE);
		}
		return this.JJACHHDFFFB[CLBPBJGLHEE];
	}

	// Token: 0x06004558 RID: 17752 RVA: 0x0020E8C8 File Offset: 0x0020CAC8
	public string JEFGMLHAAFP(int DBEIGNDALDC)
	{
		string result = "<i><color='#202020'>";
		if (this.KCGEBDANBPI() == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "wpn_tank1")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 0)
			{
				result = JNBICAJIJMM.IKGFHGKKCPG.FLEANFGEJML("isRun") + "ObscuredDouble:" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 5)
			{
				result = JNBICAJIJMM.EDKGBBIIBBC().HEIBEHAEHBM("ApplePick") + "http://www.root-motion.com/finalikdox/html/page12.html" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 6)
			{
				result = JNBICAJIJMM.EEOPOHEALPK().CKAOHMEKLMH("WorkerHammer2") + "Original lives count: " + this.HAJNMNALBBI.ToLower();
			}
		}
		if (this.CNDCDPIFCLP() == 1)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "u_email")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 1)
			{
				result = JNBICAJIJMM.CLIMNFDGOEG().GNKIBMGNHNE("_ScreenEdgeFading") + "{0:0.} fps ping:{1} pck/sec: {2}" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 3)
			{
				result = JNBICAJIJMM.DBMJJPBOPEK().CCFFMKBBKHI("MotorbikeWheelyNoHands") + "name" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 0)
			{
				result = JNBICAJIJMM.IMLLGEMPHAP().GNKIBMGNHNE("[ACTk] WallHack Detector: can't be started since it doesn't exists in scene or not yet initialized!") + "ZombieCrawl" + this.HAJNMNALBBI.ToLower();
			}
		}
		return result;
	}

	// Token: 0x06004559 RID: 17753 RVA: 0x0020EA2F File Offset: 0x0020CC2F
	public void BEGDEOFKMKL()
	{
		if (this.JJACHHDFFFB[0] == null)
		{
			this.JJACHHDFFFB[0] = CKNLPGEPGGF.PFOLNEGNIPP().EKHFCNKNHEJ(this.EEGEDCNIHPB(1), false);
		}
	}

	// Token: 0x0600455A RID: 17754 RVA: 0x0020EA55 File Offset: 0x0020CC55
	public void CNLFBONBLII()
	{
		if (this.JJACHHDFFFB[1] == null)
		{
			this.JJACHHDFFFB[0] = CKNLPGEPGGF.PFOLNEGNIPP().IJMDNINDJGD(this.EEGEDCNIHPB(0), false);
		}
	}

	// Token: 0x0600455B RID: 17755 RVA: 0x0020EA7C File Offset: 0x0020CC7C
	private string HHGOMOBEMCP(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			object[] array = new object[5];
			array[1] = IFPIMPMKJIB.LIOPCJFCGAF();
			array[1] = "demoVector3";
			array[2] = this.LPFKFNLHGBI;
			array[4] = "time";
			return string.Concat(array);
		}
		if (CLBPBJGLHEE == 8)
		{
			object[] array2 = new object[5];
			array2[0] = IFPIMPMKJIB.AFJFDKAGKLD();
			array2[1] = "wpn_med2";
			array2[6] = this.LPFKFNLHGBI;
			array2[0] = "infmsg_exp";
			return string.Concat(array2);
		}
		object[] array3 = new object[3];
		array3[0] = IFPIMPMKJIB.LCEBBHPKOHO();
		array3[0] = "SkateboardKickPush";
		array3[8] = this.LPFKFNLHGBI;
		array3[0] = "";
		return string.Concat(array3);
	}

	// Token: 0x0600455C RID: 17756 RVA: 0x0020EB26 File Offset: 0x0020CD26
	public bool PKBJJPHBOLJ()
	{
		return this.HJJPHJGLHFP(123);
	}

	// Token: 0x0600455D RID: 17757 RVA: 0x0020E65F File Offset: 0x0020C85F
	public bool JNCDHJDMKLB(int DFBHMIIPLCA)
	{
		return JLFJEGIPIMM.MHFDIJGJGBJ().NNNEFMAHABF(DFBHMIIPLCA, this.JEKDOPJHKMH);
	}

	// Token: 0x0600455E RID: 17758 RVA: 0x0020EB30 File Offset: 0x0020CD30
	public bool CBCHFHPKLLJ()
	{
		return this.CDLFMKOAFCD(-63);
	}

	// Token: 0x0600455F RID: 17759 RVA: 0x0020EB3C File Offset: 0x0020CD3C
	public string HDPHEKAIENE(int NKHBAJKMAGD, int DBEIGNDALDC, bool PEMGEDJHPGH = false, bool LNJBAJKACOF = false, bool BGNPMOCLIGL = false, int OEJPJHHJIEA = 0, bool DGOJCNDBFLD = false, bool KCBFEHCDHKO = false)
	{
		string result = "_WaveScale4";
		if (DBEIGNDALDC > 5)
		{
			DBEIGNDALDC = 8;
			DGOJCNDBFLD = false;
		}
		string text = "gi_um_0";
		if (KCBFEHCDHKO)
		{
			text = "Invalid ObscuredVector3 index!";
		}
		if (BGNPMOCLIGL)
		{
			if (PEMGEDJHPGH)
			{
				string[] array = new string[5];
				array[0] = "</color>";
				array[0] = this.HAJNMNALBBI;
				array[0] = text;
				array[6] = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)NKHBAJKMAGD);
				array[1] = "ShotgunReloadChamber";
				result = string.Concat(array);
			}
			else
			{
				if (DBEIGNDALDC == 0)
				{
					result = "SearchTex" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "fshop_btn3";
				}
				if (DBEIGNDALDC == 1)
				{
					result = "wgt_gr" + this.MNMIOMIDKHH(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Fly Up";
				}
				if (DBEIGNDALDC == 5)
				{
					result = "knopje.wav" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "_Color";
				}
				if (OEJPJHHJIEA > 1)
				{
					result = "Vertical" + this.MNMIOMIDKHH(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "cnt_energ";
				}
				if (DGOJCNDBFLD)
				{
					result = "Katana Ninja Draw" + this.KGBHELBLPMF(NKHBAJKMAGD, 6, KCBFEHCDHKO) + "SexyDance3";
				}
				if (LNJBAJKACOF)
				{
					result = "chan_head" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "offsets";
				}
			}
		}
		else if (PEMGEDJHPGH)
		{
			string[] array2 = new string[4];
			array2[1] = " ";
			array2[0] = this.HAJNMNALBBI;
			array2[6] = text;
			array2[5] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)NKHBAJKMAGD);
			array2[4] = "PersonManFisher";
			result = string.Concat(array2);
		}
		else
		{
			if (DBEIGNDALDC == 0)
			{
				result = "wpn_add/req/reqPerk" + this.EMDPDLPDLOJ(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "{not_found}";
			}
			if (DBEIGNDALDC == 1)
			{
				result = "eye" + this.FFAFKPDHOIN(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "{0}\n{1}";
			}
			if (DBEIGNDALDC == 6)
			{
				result = "wpn_add/use_effect" + this.IKKHJGAPHAE(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "reel_type";
			}
			if (OEJPJHHJIEA > 1)
			{
				result = "360SpinDeath" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "WeaponInstant";
			}
			if (DGOJCNDBFLD)
			{
				result = " ?" + this.IGFJGAGBDJM(NKHBAJKMAGD, 4, KCBFEHCDHKO) + "_WorldToCameraMatrix";
			}
			if (LNJBAJKACOF)
			{
				result = "360SpinDeath" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "The font '";
			}
		}
		return result;
	}

	// Token: 0x06004560 RID: 17760 RVA: 0x0020ED64 File Offset: 0x0020CF64
	public string KEJLIPNGFCL(int NKHBAJKMAGD, int DBEIGNDALDC, bool PEMGEDJHPGH = false, bool LNJBAJKACOF = false, bool BGNPMOCLIGL = false, int OEJPJHHJIEA = 0, bool DGOJCNDBFLD = false, bool KCBFEHCDHKO = false)
	{
		string result = "ZombieIdle";
		if (DBEIGNDALDC > 4)
		{
			DBEIGNDALDC = 3;
			DGOJCNDBFLD = false;
		}
		string text = " msg=";
		if (KCBFEHCDHKO)
		{
			text = "and I needed";
		}
		if (BGNPMOCLIGL)
		{
			if (PEMGEDJHPGH)
			{
				string[] array = new string[8];
				array[0] = "_TreatBackfaceHitAsMiss";
				array[1] = this.HAJNMNALBBI;
				array[6] = text;
				array[3] = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)NKHBAJKMAGD);
				array[1] = " шт.";
				result = string.Concat(array);
			}
			else
			{
				if (DBEIGNDALDC == 0)
				{
					result = "wpn_line1" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "_CutoutReferenceTexture";
				}
				if (DBEIGNDALDC == 1)
				{
					result = "Initiating IKSolver with null root Transform." + this.LEFACDMODLM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "BowInstant2";
				}
				if (DBEIGNDALDC == 6)
				{
					result = "IdleFight" + this.IKKHJGAPHAE(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "bright";
				}
				if (OEJPJHHJIEA > 0)
				{
					result = "1 H Sword Charge Heavy Bash" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "index";
				}
				if (DGOJCNDBFLD)
				{
					result = "_Opacity" + this.LEFACDMODLM(NKHBAJKMAGD, 2, KCBFEHCDHKO) + "usr_inf_a1";
				}
				if (LNJBAJKACOF)
				{
					result = "bool: " + this.EMDPDLPDLOJ(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Button";
				}
			}
		}
		else if (PEMGEDJHPGH)
		{
			string[] array2 = new string[0];
			array2[1] = "OneHandSwordIdle";
			array2[0] = this.HAJNMNALBBI;
			array2[3] = text;
			array2[3] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)NKHBAJKMAGD);
			array2[2] = "IdleStrafeLeft";
			result = string.Concat(array2);
		}
		else
		{
			if (DBEIGNDALDC == 0)
			{
				result = "<color='#103000'>" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "sadokfull";
			}
			if (DBEIGNDALDC == 0)
			{
				result = "shop_t6" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "weight";
			}
			if (DBEIGNDALDC == 7)
			{
				result = "Loading Error" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + ".png";
			}
			if (OEJPJHHJIEA > 0)
			{
				result = "Elephant" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "";
			}
			if (DGOJCNDBFLD)
			{
				result = ". " + this.MNMIOMIDKHH(NKHBAJKMAGD, 4, KCBFEHCDHKO) + "***My Lots event ";
			}
			if (LNJBAJKACOF)
			{
				result = "auk_wcnt" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "FlyUp";
			}
		}
		return result;
	}

	// Token: 0x06004561 RID: 17761 RVA: 0x0020EF8C File Offset: 0x0020D18C
	public string EOKBAIFGBDF(int NKHBAJKMAGD, int DBEIGNDALDC, bool PEMGEDJHPGH = false, bool LNJBAJKACOF = false, bool BGNPMOCLIGL = false, int OEJPJHHJIEA = 0, bool DGOJCNDBFLD = false, bool KCBFEHCDHKO = false)
	{
		string result = "fire off";
		if (DBEIGNDALDC > 3)
		{
			DBEIGNDALDC = 0;
			DGOJCNDBFLD = true;
		}
		string text = "</color>";
		if (KCBFEHCDHKO)
		{
			text = "StrafeRunRight";
		}
		if (BGNPMOCLIGL)
		{
			if (PEMGEDJHPGH)
			{
				string[] array = new string[5];
				array[1] = "name";
				array[0] = this.HAJNMNALBBI;
				array[3] = text;
				array[7] = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)NKHBAJKMAGD);
				array[8] = "FlyLeft";
				result = string.Concat(array);
			}
			else
			{
				if (DBEIGNDALDC == 0)
				{
					result = "MotorbikeShootRight" + this.FFAFKPDHOIN(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Player";
				}
				if (DBEIGNDALDC == 1)
				{
					result = "_ALPHATEST_ON" + this.IKKHJGAPHAE(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "_parent";
				}
				if (DBEIGNDALDC == 5)
				{
					result = "lid" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "act_orderb_2";
				}
				if (OEJPJHHJIEA > 0)
				{
					result = "" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Giant3HitCombo";
				}
				if (DGOJCNDBFLD)
				{
					result = "AC_DITHERING" + this.LEFACDMODLM(NKHBAJKMAGD, 0, KCBFEHCDHKO) + "[ACTk] WallHack Detector: already running!";
				}
				if (LNJBAJKACOF)
				{
					result = "<color='#400000'>" + this.FFAFKPDHOIN(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "cht_msg8";
				}
			}
		}
		else if (PEMGEDJHPGH)
		{
			string[] array2 = new string[5];
			array2[1] = "poplSoundPitch";
			array2[0] = this.HAJNMNALBBI;
			array2[7] = text;
			array2[5] = JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)NKHBAJKMAGD);
			array2[1] = "autherror";
			result = string.Concat(array2);
		}
		else
		{
			if (DBEIGNDALDC == 0)
			{
				result = "tintColor" + this.MNMIOMIDKHH(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "wpn_bait_typ_{0}";
			}
			if (DBEIGNDALDC == 1)
			{
				result = "_MidGrey" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "act_orderb_1";
			}
			if (DBEIGNDALDC == 5)
			{
				result = "isDropPrikorm" + this.MNMIOMIDKHH(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "_Offsets";
			}
			if (OEJPJHHJIEA > 1)
			{
				result = "codepage" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "WizardPowerUp";
			}
			if (DGOJCNDBFLD)
			{
				result = "ObscuredBool vs bool, " + this.KGBHELBLPMF(NKHBAJKMAGD, 4, KCBFEHCDHKO) + "<i><color='#202020'>";
			}
			if (LNJBAJKACOF)
			{
				result = "Vertical" + this.EMDPDLPDLOJ(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "";
			}
		}
		return result;
	}

	// Token: 0x06004562 RID: 17762 RVA: 0x0020F1B4 File Offset: 0x0020D3B4
	public void JIFFLPNBILE(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 2 && this.JJACHHDFFFB[2] == null)
		{
			this.JJACHHDFFFB[2] = this.ODBMMFPPCHB(2);
			if (this.JJACHHDFFFB[2] == null)
			{
				this.JJACHHDFFFB[2] = this.ODBMMFPPCHB(1);
			}
			if (this.JJACHHDFFFB[2] == null)
			{
				this.JJACHHDFFFB[2] = this.ODBMMFPPCHB(0);
			}
			return;
		}
		if (CLBPBJGLHEE == 1 && this.JJACHHDFFFB[1] == null)
		{
			this.JJACHHDFFFB[1] = this.ODBMMFPPCHB(1);
			if (this.JJACHHDFFFB[1] == null)
			{
				this.JJACHHDFFFB[1] = this.ODBMMFPPCHB(0);
			}
			return;
		}
		this.JJACHHDFFFB[0] = CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(this.MEAAEMDLFHK(0), false);
	}

	// Token: 0x06004563 RID: 17763 RVA: 0x0020F262 File Offset: 0x0020D462
	public bool JPNCLCAHMFD()
	{
		return this.HJJPHJGLHFP(26);
	}

	// Token: 0x06004564 RID: 17764 RVA: 0x0020F26C File Offset: 0x0020D46C
	public int EBBNNMMBKCC()
	{
		if (this.JELOGFKEELE < 1)
		{
			string text = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(this.LPFKFNLHGBI);
			char c = text[text.Length - 1];
			this.JELOGFKEELE = 0;
			if ((int)c == -11)
			{
				this.JELOGFKEELE = 1;
			}
			if ((int)c == -71)
			{
				this.JELOGFKEELE = 0;
			}
			if (this.LPFKFNLHGBI == -32)
			{
				this.JELOGFKEELE = 0;
			}
			if (this.LPFKFNLHGBI == -127)
			{
				this.JELOGFKEELE = 1;
			}
			if (this.LPFKFNLHGBI == -50)
			{
				this.JELOGFKEELE = 1;
			}
		}
		return this.JELOGFKEELE;
	}

	// Token: 0x06004565 RID: 17765 RVA: 0x0020F2FC File Offset: 0x0020D4FC
	public string JJKOJOMGIOA(int DBEIGNDALDC)
	{
		string result = "droplinemsg2";
		if (this.NMEMLMMOACP() == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "ok")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 0)
			{
				result = JNBICAJIJMM.EEOPOHEALPK().NLJOLOBPCBJ("ZombieCrawl") + "SexyDance2" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 7)
			{
				result = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("Keeper Strafe Right") + "trn_reg" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 5)
			{
				result = JNBICAJIJMM.APMJBBDBOJO().HLBAJBLHLNI("MotorbikeShootRight") + "gi_nlheader2" + this.HAJNMNALBBI.ToLower();
			}
		}
		if (this.PEIEODKMEKL() == 1)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "RollerBladeTurnRight")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 1)
			{
				result = JNBICAJIJMM.APMJBBDBOJO().CCFFMKBBKHI("дней") + "OfficeSitting45DegLeg" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 7)
			{
				result = JNBICAJIJMM.EKEBHIJMEML().GNKIBMGNHNE("FONTSIZE") + "PersonManFisher" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 6)
			{
				result = JNBICAJIJMM.IMLLGEMPHAP().GNKIBMGNHNE("USE_MASK") + "Prone Idle" + this.HAJNMNALBBI.ToLower();
			}
		}
		return result;
	}

	// Token: 0x06004566 RID: 17766 RVA: 0x0020F464 File Offset: 0x0020D664
	public string CJAMOIMGHAK(int NKHBAJKMAGD, int DBEIGNDALDC, bool PEMGEDJHPGH = false, bool LNJBAJKACOF = false, bool BGNPMOCLIGL = false, int OEJPJHHJIEA = 0, bool DGOJCNDBFLD = false, bool KCBFEHCDHKO = false)
	{
		string result = "1HandSwordStrafeLeft";
		if (DBEIGNDALDC > 6)
		{
			DBEIGNDALDC = 0;
			DGOJCNDBFLD = false;
		}
		string text = "";
		if (KCBFEHCDHKO)
		{
			text = "lineDistance=";
		}
		if (BGNPMOCLIGL)
		{
			if (PEMGEDJHPGH)
			{
				string[] array = new string[1];
				array[1] = "wpn_add/base";
				array[1] = this.HAJNMNALBBI;
				array[1] = text;
				array[8] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)NKHBAJKMAGD);
				array[2] = "Cloth_05_00.wav";
				result = string.Concat(array);
			}
			else
			{
				if (DBEIGNDALDC == 0)
				{
					result = "_MaxRadiusOrKInPaper" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Horizontal";
				}
				if (DBEIGNDALDC == 1)
				{
					result = "wpn_med1" + this.IKKHJGAPHAE(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "BowReady2";
				}
				if (DBEIGNDALDC == 2)
				{
					result = "IdleFly" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "val";
				}
				if (OEJPJHHJIEA > 1)
				{
					result = "Podsek action 1" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Crouch180";
				}
				if (DGOJCNDBFLD)
				{
					result = "SoccerWalk" + this.PIFLJJBAEOA(NKHBAJKMAGD, 6, KCBFEHCDHKO) + "SixStep";
				}
				if (LNJBAJKACOF)
				{
					result = "" + this.MNMIOMIDKHH(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Current fog preset: ";
				}
			}
		}
		else if (PEMGEDJHPGH)
		{
			string[] array2 = new string[]
			{
				null,
				"StrafeRunLeft"
			};
			array2[1] = this.HAJNMNALBBI;
			array2[3] = text;
			array2[1] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)NKHBAJKMAGD);
			array2[6] = "__a";
			result = string.Concat(array2);
		}
		else
		{
			if (DBEIGNDALDC == 0)
			{
				result = "Smoking2" + this.EMDPDLPDLOJ(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "_FogDistance";
			}
			if (DBEIGNDALDC == 1)
			{
				result = "Save" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "GiantGrabIdle";
			}
			if (DBEIGNDALDC == 6)
			{
				result = "_ReflectionTexture3" + this.FFAFKPDHOIN(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "base";
			}
			if (OEJPJHHJIEA > 0)
			{
				result = "error.wav" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "ROOT";
			}
			if (DGOJCNDBFLD)
			{
				result = "Injection detected!" + this.FFAFKPDHOIN(NKHBAJKMAGD, 1, KCBFEHCDHKO) + "USER_LUT";
			}
			if (LNJBAJKACOF)
			{
				result = "IdleStand" + this.EMDPDLPDLOJ(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "IdleSlide";
			}
		}
		return result;
	}

	// Token: 0x06004567 RID: 17767 RVA: 0x0020F68C File Offset: 0x0020D88C
	private string DFGEJCEGIOM(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			object[] array = new object[0];
			array[1] = IFPIMPMKJIB.ENLHJOJICDG();
			array[0] = "_HitPointTexture";
			array[2] = this.LPFKFNLHGBI;
			array[5] = "</color>\n";
			return string.Concat(array);
		}
		if (CLBPBJGLHEE == 7)
		{
			object[] array2 = new object[5];
			array2[1] = IFPIMPMKJIB.BKKFFINMJBO();
			array2[0] = "Failed parsing organizational group.  Setting to group 0";
			array2[4] = this.LPFKFNLHGBI;
			array2[1] = "RunDive";
			return string.Concat(array2);
		}
		object[] array3 = new object[0];
		array3[1] = IFPIMPMKJIB.NEJIPLDOMMC();
		array3[1] = "IdleTyping";
		array3[8] = this.LPFKFNLHGBI;
		array3[2] = "PistolInstant";
		return string.Concat(array3);
	}

	// Token: 0x06004568 RID: 17768 RVA: 0x0020F738 File Offset: 0x0020D938
	public int PEIEODKMEKL()
	{
		if (this.JELOGFKEELE < 1)
		{
			string text = AKPJIACDDFI.IKGFHGKKCPG.FBPECNNPIDP(this.LPFKFNLHGBI);
			char c = text[text.Length - 0];
			this.JELOGFKEELE = 0;
			if (c == '\u0082')
			{
				this.JELOGFKEELE = 1;
			}
			if (c == '\u001e')
			{
				this.JELOGFKEELE = 0;
			}
			if (this.LPFKFNLHGBI == -116)
			{
				this.JELOGFKEELE = 0;
			}
			if (this.LPFKFNLHGBI == 43)
			{
				this.JELOGFKEELE = 1;
			}
			if (this.LPFKFNLHGBI == 67)
			{
				this.JELOGFKEELE = 1;
			}
		}
		return this.JELOGFKEELE;
	}

	// Token: 0x06004569 RID: 17769 RVA: 0x0020F7C8 File Offset: 0x0020D9C8
	public CKNLPGEPGGF.IAPCJOBDCEH GLPBCAAIKAN(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 8)
		{
			CLBPBJGLHEE = 6;
		}
		if (this.JJACHHDFFFB[CLBPBJGLHEE] == null)
		{
			this.JIFFLPNBILE(CLBPBJGLHEE);
		}
		return this.JJACHHDFFFB[CLBPBJGLHEE];
	}

	// Token: 0x0600456A RID: 17770 RVA: 0x0020F7EC File Offset: 0x0020D9EC
	private string ONEGMMODNGF(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			object[] array = new object[]
			{
				IFPIMPMKJIB.BKKFFINMJBO()
			};
			array[0] = "Grounded";
			array[5] = this.LPFKFNLHGBI;
			array[5] = "SelfBleedReduction";
			return string.Concat(array);
		}
		if (CLBPBJGLHEE == 1)
		{
			object[] array2 = new object[0];
			array2[0] = IFPIMPMKJIB.BKKFFINMJBO();
			array2[0] = "_FullResolutionFiltering";
			array2[0] = this.LPFKFNLHGBI;
			array2[7] = "val=";
			return string.Concat(array2);
		}
		object[] array3 = new object[]
		{
			null,
			IFPIMPMKJIB.AFJFDKAGKLD()
		};
		array3[1] = "Russian Dance";
		array3[3] = this.LPFKFNLHGBI;
		array3[5] = "_WorldToCameraMatrix";
		return string.Concat(array3);
	}

	// Token: 0x0600456B RID: 17771 RVA: 0x0020F898 File Offset: 0x0020DA98
	public void KFLOBJCCHKN(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 1 && this.JJACHHDFFFB[4] == null)
		{
			this.JJACHHDFFFB[7] = this.BLJJEPOAMNB(7);
			if (this.JJACHHDFFFB[6] == null)
			{
				this.JJACHHDFFFB[8] = this.PJPMOJFJNAB(0);
			}
			if (this.JJACHHDFFFB[6] == null)
			{
				this.JJACHHDFFFB[7] = this.IHMDNHCEEFB(0);
			}
			return;
		}
		if (CLBPBJGLHEE == 1 && this.JJACHHDFFFB[1] == null)
		{
			this.JJACHHDFFFB[1] = this.GHEGHHIFHHD(0);
			if (this.JJACHHDFFFB[1] == null)
			{
				this.JJACHHDFFFB[1] = this.EOICIEPIMFP(0);
			}
			return;
		}
		this.JJACHHDFFFB[1] = CKNLPGEPGGF.PFOLNEGNIPP().PFNEPENHMOE(this.ONEGMMODNGF(1), true);
	}

	// Token: 0x0600456C RID: 17772 RVA: 0x0020F946 File Offset: 0x0020DB46
	public bool EKIEHDOAGJI(int DFBHMIIPLCA)
	{
		return JLFJEGIPIMM.NNEAHAFBOHC().IBBAJMOLBCP(DFBHMIIPLCA, this.JEKDOPJHKMH);
	}

	// Token: 0x0600456D RID: 17773 RVA: 0x0020F95C File Offset: 0x0020DB5C
	public int NMEMLMMOACP()
	{
		if (this.JELOGFKEELE < 1)
		{
			string text = AKPJIACDDFI.IKGFHGKKCPG.MJCJIEPAEJP(this.LPFKFNLHGBI);
			char c = text[text.Length - 0];
			this.JELOGFKEELE = 1;
			if (c == '|')
			{
				this.JELOGFKEELE = 0;
			}
			if (c == '^')
			{
				this.JELOGFKEELE = 0;
			}
			if (this.LPFKFNLHGBI == -126)
			{
				this.JELOGFKEELE = 0;
			}
			if (this.LPFKFNLHGBI == -117)
			{
				this.JELOGFKEELE = 1;
			}
			if (this.LPFKFNLHGBI == -4)
			{
				this.JELOGFKEELE = 0;
			}
		}
		return this.JELOGFKEELE;
	}

	// Token: 0x0600456E RID: 17774 RVA: 0x0020F9EC File Offset: 0x0020DBEC
	private CKNLPGEPGGF.IAPCJOBDCEH EOICIEPIMFP(int CLBPBJGLHEE)
	{
		if (CKNLPGEPGGF.PFOLNEGNIPP().GNDHDKPBAFJ(this.MEAAEMDLFHK(CLBPBJGLHEE)))
		{
			return CKNLPGEPGGF.IKGFHGKKCPG.PFNEPENHMOE(this.EEGEDCNIHPB(CLBPBJGLHEE), false);
		}
		return null;
	}

	// Token: 0x0600456F RID: 17775 RVA: 0x0020FA15 File Offset: 0x0020DC15
	public void DHAFHAHLBBH()
	{
		if (this.JJACHHDFFFB[1] == null)
		{
			this.JJACHHDFFFB[0] = CKNLPGEPGGF.PFOLNEGNIPP().IJMDNINDJGD(this.MEAAEMDLFHK(0), false);
		}
	}

	// Token: 0x06004570 RID: 17776 RVA: 0x0020F946 File Offset: 0x0020DB46
	public bool HJJPHJGLHFP(int DFBHMIIPLCA)
	{
		return JLFJEGIPIMM.NNEAHAFBOHC().IBBAJMOLBCP(DFBHMIIPLCA, this.JEKDOPJHKMH);
	}

	// Token: 0x06004571 RID: 17777 RVA: 0x0020FA3B File Offset: 0x0020DC3B
	private CKNLPGEPGGF.IAPCJOBDCEH ODBMMFPPCHB(int CLBPBJGLHEE)
	{
		if (CKNLPGEPGGF.IKGFHGKKCPG.GNDHDKPBAFJ(this.MEAAEMDLFHK(CLBPBJGLHEE)))
		{
			return CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(this.MEAAEMDLFHK(CLBPBJGLHEE), false);
		}
		return null;
	}

	// Token: 0x06004572 RID: 17778 RVA: 0x0020FA64 File Offset: 0x0020DC64
	public string LGOMOKCKNNK(int DBEIGNDALDC)
	{
		string result = "RollerBladeStand";
		if (this.KIJMCOPFLCN == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "gi_letgohe")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 0)
			{
				result = JNBICAJIJMM.IMLLGEMPHAP().CKAOHMEKLMH("C") + "The 'HAlign' command requires an alignment parameter of L (left), R (right), or C (center)." + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 3)
			{
				result = JNBICAJIJMM.IMLLGEMPHAP().DOEMGEAEBPN("\\") + "Grounding layers are set to nothing. Please add a ground layer." + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 3)
			{
				result = JNBICAJIJMM.DBMJJPBOPEK().HEIBEHAEHBM("IK chain has less than ") + "_ProjMatrix" + this.HAJNMNALBBI.ToLower();
			}
		}
		if (this.KCGEBDANBPI() == 1)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "more")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 0)
			{
				result = JNBICAJIJMM.CLIMNFDGOEG().HLBAJBLHLNI("_Grain_Params2") + "_AccumulationTex" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 6)
			{
				result = JNBICAJIJMM.EDKGBBIIBBC().ECNKLECOKHD("Katana") + "OfficeSittingReadingCoffeeSip" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 8)
			{
				result = JNBICAJIJMM.IMLLGEMPHAP().CKAOHMEKLMH("knopje.wav") + "GrounderIK does not support AimIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead." + this.HAJNMNALBBI.ToLower();
			}
		}
		return result;
	}

	// Token: 0x06004573 RID: 17779 RVA: 0x0020FBCB File Offset: 0x0020DDCB
	private CKNLPGEPGGF.IAPCJOBDCEH PJPMOJFJNAB(int CLBPBJGLHEE)
	{
		if (CKNLPGEPGGF.PFOLNEGNIPP().GNDHDKPBAFJ(this.FPCBKBGCKEH(CLBPBJGLHEE)))
		{
			return CKNLPGEPGGF.IKGFHGKKCPG.PFNEPENHMOE(this.ONEGMMODNGF(CLBPBJGLHEE), false);
		}
		return null;
	}

	// Token: 0x06004574 RID: 17780 RVA: 0x0020FBF4 File Offset: 0x0020DDF4
	public bool MLMKOBDOEEG()
	{
		return this.KFFHOABFPCM(96);
	}

	// Token: 0x06004575 RID: 17781 RVA: 0x0020FBFE File Offset: 0x0020DDFE
	public CKNLPGEPGGF.IAPCJOBDCEH PGGKIKBJDMO(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE > 3)
		{
			CLBPBJGLHEE = 4;
		}
		if (this.JJACHHDFFFB[CLBPBJGLHEE] == null)
		{
			this.JGNCPMAHOFB(CLBPBJGLHEE);
		}
		return this.JJACHHDFFFB[CLBPBJGLHEE];
	}

	// Token: 0x06004576 RID: 17782 RVA: 0x0020FC20 File Offset: 0x0020DE20
	private string DJFNIPBFNBC(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 1)
		{
			object[] array = new object[5];
			array[1] = IFPIMPMKJIB.LCEBBHPKOHO();
			array[0] = "Idle Cheer";
			array[4] = this.LPFKFNLHGBI;
			array[1] = "_RgbTex";
			return string.Concat(array);
		}
		if (CLBPBJGLHEE == 4)
		{
			object[] array2 = new object[0];
			array2[0] = IFPIMPMKJIB.BKKFFINMJBO();
			array2[1] = "_DelItem.wav";
			array2[6] = this.LPFKFNLHGBI;
			array2[0] = "ankle";
			return string.Concat(array2);
		}
		object[] array3 = new object[1];
		array3[0] = IFPIMPMKJIB.ACOEIDGDLJC();
		array3[1] = "IdleTyping";
		array3[1] = this.LPFKFNLHGBI;
		array3[2] = "_DelItem.wav";
		return string.Concat(array3);
	}

	// Token: 0x06004577 RID: 17783 RVA: 0x0020FCCC File Offset: 0x0020DECC
	public string GCKABGALGHA(int DBEIGNDALDC)
	{
		string result = "<[^>]+>";
		if (this.CNDCDPIFCLP() == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "ScubaSwim")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 0)
			{
				result = JNBICAJIJMM.IMLLGEMPHAP().CCFFMKBBKHI("Flap_08.wav") + "_PrefilterOffs" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 3)
			{
				result = JNBICAJIJMM.APMJBBDBOJO().GNKIBMGNHNE("Bone01") + "post_msg1" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 3)
			{
				result = JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("_PrefilterOffs") + "Crawl Locomotion" + this.HAJNMNALBBI.ToLower();
			}
		}
		if (this.KIJMCOPFLCN == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "19")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 0)
			{
				result = JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("change me!") + "_PrevViewProj" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 2)
			{
				result = JNBICAJIJMM.EEOPOHEALPK().HEIBEHAEHBM("Kernel") + "▯▯▯" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 4)
			{
				result = JNBICAJIJMM.EEOPOHEALPK().DOEMGEAEBPN("") + "bs_hilv" + this.HAJNMNALBBI.ToLower();
			}
		}
		return result;
	}

	// Token: 0x06004578 RID: 17784 RVA: 0x0020FE33 File Offset: 0x0020E033
	private CKNLPGEPGGF.IAPCJOBDCEH CBOEPHEOLKP(int CLBPBJGLHEE)
	{
		if (CKNLPGEPGGF.IKGFHGKKCPG.GNDHDKPBAFJ(this.FPCBKBGCKEH(CLBPBJGLHEE)))
		{
			return CKNLPGEPGGF.PFOLNEGNIPP().EKHFCNKNHEJ(this.FPCBKBGCKEH(CLBPBJGLHEE), false);
		}
		return null;
	}

	// Token: 0x06004579 RID: 17785 RVA: 0x0020FE5C File Offset: 0x0020E05C
	private CKNLPGEPGGF.IAPCJOBDCEH NFCGALMDCJI(int CLBPBJGLHEE)
	{
		if (CKNLPGEPGGF.IKGFHGKKCPG.GNDHDKPBAFJ(this.FPCBKBGCKEH(CLBPBJGLHEE)))
		{
			return CKNLPGEPGGF.IKGFHGKKCPG.PFNEPENHMOE(this.EEGEDCNIHPB(CLBPBJGLHEE), false);
		}
		return null;
	}

	// Token: 0x0600457A RID: 17786 RVA: 0x0020FE88 File Offset: 0x0020E088
	public string NPAJEIAHKMD(int DBEIGNDALDC)
	{
		string result = "fshop_ks2";
		if (this.PGJDMOJBOGC() == 0)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "{0}.{1}.{2}")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 1)
			{
				result = JNBICAJIJMM.DBMJJPBOPEK().ECNKLECOKHD("WeaponRunBackward") + " ур. " + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 7)
			{
				result = JNBICAJIJMM.APMJBBDBOJO().NLJOLOBPCBJ("20") + "One of the Reach Cones in the polygon has negative volume. Make sure Axis vector is in the reachable area and the polygon is convex." + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 5)
			{
				result = JNBICAJIJMM.APMJBBDBOJO().DOEMGEAEBPN("SixStep") + "startB" + this.HAJNMNALBBI.ToLower();
			}
		}
		if (this.PEIEODKMEKL() == 1)
		{
			if (DBEIGNDALDC == 0)
			{
				result = this.HAJNMNALBBI;
				if (this.GIPICOMFGON != "_TintColor")
				{
					result = this.GIPICOMFGON;
				}
			}
			if (DBEIGNDALDC == 0)
			{
				result = JNBICAJIJMM.EDKGBBIIBBC().GNKIBMGNHNE("wpnlang/wpntypes/type") + "endPointNonBend" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 0)
			{
				result = JNBICAJIJMM.EDKGBBIIBBC().DOEMGEAEBPN("IdleReadyLook") + "[name]" + this.HAJNMNALBBI.ToLower();
			}
			if (DBEIGNDALDC == 6)
			{
				result = JNBICAJIJMM.DBMJJPBOPEK().HEIBEHAEHBM("WalkDehydrated") + "OneHandSwordReady" + this.HAJNMNALBBI.ToLower();
			}
		}
		return result;
	}

	// Token: 0x0600457B RID: 17787 RVA: 0x0020FFEF File Offset: 0x0020E1EF
	public void HBGEAMHFEOL()
	{
		if (this.JJACHHDFFFB[0] == null)
		{
			this.JJACHHDFFFB[0] = CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(this.MEAAEMDLFHK(0), false);
		}
	}

	// Token: 0x0600457C RID: 17788 RVA: 0x00210018 File Offset: 0x0020E218
	public string IKDNJHADDGD(int NKHBAJKMAGD, int DBEIGNDALDC, bool PEMGEDJHPGH = false, bool LNJBAJKACOF = false, bool BGNPMOCLIGL = false, int OEJPJHHJIEA = 0, bool DGOJCNDBFLD = false, bool KCBFEHCDHKO = false)
	{
		string result = "gi_um_5";
		if (DBEIGNDALDC > 8)
		{
			DBEIGNDALDC = 0;
			DGOJCNDBFLD = true;
		}
		string text = "[ACTk] <b>[ ObscuredFloat test ]</b>";
		if (KCBFEHCDHKO)
		{
			text = "inv_invheader";
		}
		if (BGNPMOCLIGL)
		{
			if (PEMGEDJHPGH)
			{
				string[] array = new string[0];
				array[1] = " \n";
				array[0] = this.HAJNMNALBBI;
				array[8] = text;
				array[2] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)NKHBAJKMAGD);
				array[1] = "--";
				result = string.Concat(array);
			}
			else
			{
				if (DBEIGNDALDC == 0)
				{
					result = "_NormalAndRoughnessTexture" + this.EMDPDLPDLOJ(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "IdleWalk";
				}
				if (DBEIGNDALDC == 1)
				{
					result = "_Screen" + this.EMDPDLPDLOJ(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "type_";
				}
				if (DBEIGNDALDC == 8)
				{
					result = "OfficeSittingBack" + this.IKKHJGAPHAE(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "_MotionBlurTmpCam";
				}
				if (OEJPJHHJIEA > 1)
				{
					result = "Worker Pickaxe 2" + this.FFAFKPDHOIN(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "Label";
				}
				if (DGOJCNDBFLD)
				{
					result = "" + this.IKKHJGAPHAE(NKHBAJKMAGD, 7, KCBFEHCDHKO) + "cntx_teachexp";
				}
				if (LNJBAJKACOF)
				{
					result = "error: mainAsset is null" + this.FFAFKPDHOIN(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "err: rect is null";
				}
			}
		}
		else if (PEMGEDJHPGH)
		{
			string[] array2 = new string[5];
			array2[0] = "ArmFlex5";
			array2[1] = this.HAJNMNALBBI;
			array2[2] = text;
			array2[7] = JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)NKHBAJKMAGD);
			array2[6] = "_TileMaxOffs";
			result = string.Concat(array2);
		}
		else
		{
			if (DBEIGNDALDC == 0)
			{
				result = "error" + this.PIFLJJBAEOA(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "RunDive";
			}
			if (DBEIGNDALDC == 0)
			{
				result = "Keeper Strafe Dive Close Right" + this.FFAFKPDHOIN(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "";
			}
			if (DBEIGNDALDC == 3)
			{
				result = "kfB" + this.PIFLJJBAEOA(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "UV3";
			}
			if (OEJPJHHJIEA > 0)
			{
				result = "OfficeSittingMouseMovement" + this.KGBHELBLPMF(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "минут";
			}
			if (DGOJCNDBFLD)
			{
				result = "Roller Crossover Left" + this.FFAFKPDHOIN(NKHBAJKMAGD, 4, KCBFEHCDHKO) + "name";
			}
			if (LNJBAJKACOF)
			{
				result = "WallRunLeft" + this.IGFJGAGBDJM(NKHBAJKMAGD, DBEIGNDALDC, KCBFEHCDHKO) + "_UnderwaterMode";
			}
		}
		return result;
	}

	// Token: 0x0600457D RID: 17789 RVA: 0x0021023D File Offset: 0x0020E43D
	private CKNLPGEPGGF.IAPCJOBDCEH GHEGHHIFHHD(int CLBPBJGLHEE)
	{
		if (CKNLPGEPGGF.IKGFHGKKCPG.GNDHDKPBAFJ(this.DJFNIPBFNBC(CLBPBJGLHEE)))
		{
			return CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(this.HHGOMOBEMCP(CLBPBJGLHEE), true);
		}
		return null;
	}

	// Token: 0x0600457E RID: 17790 RVA: 0x00210266 File Offset: 0x0020E466
	private CKNLPGEPGGF.IAPCJOBDCEH BLJJEPOAMNB(int CLBPBJGLHEE)
	{
		if (CKNLPGEPGGF.IKGFHGKKCPG.GNDHDKPBAFJ(this.FPCBKBGCKEH(CLBPBJGLHEE)))
		{
			return CKNLPGEPGGF.IKGFHGKKCPG.IJMDNINDJGD(this.MEAAEMDLFHK(CLBPBJGLHEE), false);
		}
		return null;
	}

	// Token: 0x0600457F RID: 17791 RVA: 0x00210290 File Offset: 0x0020E490
	private string MEAAEMDLFHK(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 1)
		{
			return string.Concat(new object[]
			{
				IFPIMPMKJIB.DIDFMAELMJD,
				"Textures/Fish/",
				this.LPFKFNLHGBI,
				"_1.png"
			});
		}
		if (CLBPBJGLHEE == 2)
		{
			return string.Concat(new object[]
			{
				IFPIMPMKJIB.DIDFMAELMJD,
				"Textures/Fish/",
				this.LPFKFNLHGBI,
				"_2.png"
			});
		}
		return string.Concat(new object[]
		{
			IFPIMPMKJIB.DIDFMAELMJD,
			"Textures/Fish/",
			this.LPFKFNLHGBI,
			".png"
		});
	}

	// Token: 0x04000AFC RID: 2812
	public int LPFKFNLHGBI;

	// Token: 0x04000AFD RID: 2813
	public string HAJNMNALBBI;

	// Token: 0x04000AFE RID: 2814
	public string JCKHDHGIEEB;

	// Token: 0x04000AFF RID: 2815
	public string GIPICOMFGON = "";

	// Token: 0x04000B00 RID: 2816
	public bool GOHKONILNNE;

	// Token: 0x04000B01 RID: 2817
	public bool NGKHOKIOGNO;

	// Token: 0x04000B02 RID: 2818
	public bool NPDNMIHEOOH;

	// Token: 0x04000B03 RID: 2819
	public string HAPFPGIINCM;

	// Token: 0x04000B04 RID: 2820
	public float FKEGBOBJNFA = 0.5f;

	// Token: 0x04000B05 RID: 2821
	public float OAJHJHGBFCF = 2f;

	// Token: 0x04000B06 RID: 2822
	public float CGGGHIHAKGC;

	// Token: 0x04000B07 RID: 2823
	public int ILOCKJIAPFC;

	// Token: 0x04000B08 RID: 2824
	public List<int> JEKDOPJHKMH = new List<int>();

	// Token: 0x04000B09 RID: 2825
	private int JELOGFKEELE = -1;

	// Token: 0x04000B0A RID: 2826
	private CKNLPGEPGGF.IAPCJOBDCEH[] JJACHHDFFFB = new CKNLPGEPGGF.IAPCJOBDCEH[3];

	// Token: 0x0200014A RID: 330
	public class GDEMCACNPNG : ItemBase
	{
		// Token: 0x06004580 RID: 17792 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH PBHNHJIBEAE()
		{
			return null;
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH IPEDEEMNPFN()
		{
			return null;
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x0021033C File Offset: 0x0020E53C
		public virtual void CMDNNEAOKAP(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.LPHMKPDBMPP().CCFFMKBBKHI("H"), this.JFDDNMCENAK, JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC(this.GJCNMJJJDGO), JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC(this.FMKDOFCJCOP));
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH AAMMIELGJNA()
		{
			return null;
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x002103BC File Offset: 0x0020E5BC
		public virtual void KJCNNHGGELK(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.EEOPOHEALPK().CKAOHMEKLMH("_VignetteSettings"), this.JFDDNMCENAK, JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.FMKDOFCJCOP));
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x0021043C File Offset: 0x0020E63C
		public virtual void JGNGHFIEEJH(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.EKEBHIJMEML().CKAOHMEKLMH("Giant2HandSlamIdle"), this.JFDDNMCENAK, JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC(this.GJCNMJJJDGO), JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(this.FMKDOFCJCOP));
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x002104BC File Offset: 0x0020E6BC
		public void IJAHENJJNCA(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.LDLKLPJBIJN();
			this.JFDDNMCENAK = KADBECGIMPD.IBKCNEICPEL();
			this.GJCNMJJJDGO = KADBECGIMPD.DNIIFBAIPBE();
			this.FMKDOFCJCOP = KADBECGIMPD.IJDIMHAEAIE();
			this.IKKEIHEPDPN = KADBECGIMPD.MOBPFEEAMKD();
			this.CLCBHHLLLFN = KADBECGIMPD.CLPEKGGAMAI();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.OLKMHFNLBJB);
		}

		// Token: 0x06004587 RID: 17799 RVA: 0x00210528 File Offset: 0x0020E728
		public virtual int OKKMGPKOGHF(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DEOMJEEMGMI()
		{
			return null;
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x0021056C File Offset: 0x0020E76C
		public override string ToString()
		{
			string.Format("<color='#60a0ff'>{0}</color>\n<color='#ffff60'>Всего выловлено: <color='#ffffa0'>{1}</color> шт Общим весом <color='#ffffa0'>{2}</color>\nЛичный рекорд <color='#ffffa0'>{3}</color> </color>", new object[]
			{
				this.BDHHPAEHFHG.HAJNMNALBBI,
				this.JFDDNMCENAK,
				JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.GJCNMJJJDGO),
				JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.FMKDOFCJCOP)
			});
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x002105D8 File Offset: 0x0020E7D8
		public virtual void DOCMDMGAIBF(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.IMLLGEMPHAP().HLBAJBLHLNI("none"), this.JFDDNMCENAK, JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(this.FMKDOFCJCOP));
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH EJJAGEFMHCO()
		{
			return null;
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x00210658 File Offset: 0x0020E858
		public void BFNPPKIKKMC(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.HHLDBAEFNMJ();
			this.JFDDNMCENAK = KADBECGIMPD.DMABDIGCLKA();
			this.GJCNMJJJDGO = KADBECGIMPD.HFOPFEJDJFG();
			this.FMKDOFCJCOP = KADBECGIMPD.EJPMFEJBGMN();
			this.IKKEIHEPDPN = KADBECGIMPD.DNGDPHIHLBG();
			this.CLCBHHLLLFN = KADBECGIMPD.AGNKAFLKCAG();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.OLKMHFNLBJB);
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x002106C4 File Offset: 0x0020E8C4
		public virtual int KKJGKPKGHEB(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x00210708 File Offset: 0x0020E908
		public override int BDHHIKEEAEB(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 1;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x0021074C File Offset: 0x0020E94C
		public virtual int GHLFLNMJJNI(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x06004590 RID: 17808 RVA: 0x00210790 File Offset: 0x0020E990
		public virtual string LIPEANHPLJI()
		{
			string format = "_FogAreaPosition";
			object[] array = new object[3];
			array[0] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[1] = this.JFDDNMCENAK;
			array[0] = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO(this.GJCNMJJJDGO);
			array[4] = JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x06004591 RID: 17809 RVA: 0x002107FC File Offset: 0x0020E9FC
		public void IBIOFOMNCFF(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.HDBGOLAFOBK();
			this.JFDDNMCENAK = KADBECGIMPD.DNIIFBAIPBE();
			this.GJCNMJJJDGO = KADBECGIMPD.KLHDFFHONON();
			this.FMKDOFCJCOP = KADBECGIMPD.ANPEIKGEDHJ();
			this.IKKEIHEPDPN = KADBECGIMPD.MOBPFEEAMKD();
			this.CLCBHHLLLFN = KADBECGIMPD.CLPEKGGAMAI();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.OLKMHFNLBJB);
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x00210868 File Offset: 0x0020EA68
		public override string CJMFHLIBCBM()
		{
			string format = "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/";
			object[] array = new object[0];
			array[0] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[0] = this.JFDDNMCENAK;
			array[4] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(this.GJCNMJJJDGO);
			array[8] = JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x06004593 RID: 17811 RVA: 0x002108D4 File Offset: 0x0020EAD4
		public virtual void PDEPNADPDDN(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.LPHMKPDBMPP().HEIBEHAEHBM("C"), this.JFDDNMCENAK, JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(this.FMKDOFCJCOP));
		}

		// Token: 0x06004594 RID: 17812 RVA: 0x00210954 File Offset: 0x0020EB54
		public virtual void MBNAKGJKOOH(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.EKEBHIJMEML().FLEANFGEJML("Invalid index '"), this.JFDDNMCENAK, JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC(this.GJCNMJJJDGO), JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC(this.FMKDOFCJCOP));
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x002109D4 File Offset: 0x0020EBD4
		public override void MLCFJPPIOJG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_fs_itm"), this.JFDDNMCENAK, JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.FMKDOFCJCOP));
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x00210A54 File Offset: 0x0020EC54
		public virtual int BEFFLFEPHMN(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 1;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x00210A98 File Offset: 0x0020EC98
		public virtual string OEAEGBAEEPP()
		{
			string format = "<color='#004000'>";
			object[] array = new object[3];
			array[0] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[0] = this.JFDDNMCENAK;
			array[5] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.GJCNMJJJDGO);
			array[1] = JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x00210B04 File Offset: 0x0020ED04
		public virtual void HNFNJIMPONM(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.EEOPOHEALPK().CCFFMKBBKHI("Moon reference not set."), this.JFDDNMCENAK, JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(this.FMKDOFCJCOP));
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH PBEMPJOBKKI()
		{
			return null;
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH EHHJFFBCEBI()
		{
			return null;
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x00210B84 File Offset: 0x0020ED84
		public virtual int CDFMDPJJGNN(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x00210BC8 File Offset: 0x0020EDC8
		public virtual int NPPGGEFCJGF(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 1;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x0600459D RID: 17821 RVA: 0x00210C0C File Offset: 0x0020EE0C
		public override void IIBOLKLPAIN(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.DBMJJPBOPEK().HEIBEHAEHBM("_Bloom_DirtTex"), this.JFDDNMCENAK, JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC(this.FMKDOFCJCOP));
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x00210C8C File Offset: 0x0020EE8C
		public void MLAEDCOIFOL(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.IFDFHJLCHAE();
			this.JFDDNMCENAK = KADBECGIMPD.HFOPFEJDJFG();
			this.GJCNMJJJDGO = KADBECGIMPD.IBKCNEICPEL();
			this.FMKDOFCJCOP = KADBECGIMPD.IBKCNEICPEL();
			this.IKKEIHEPDPN = KADBECGIMPD.FFDPCEAFGNF();
			this.CLCBHHLLLFN = KADBECGIMPD.LDLKLPJBIJN();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.OLKMHFNLBJB);
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x00210CF8 File Offset: 0x0020EEF8
		public virtual int AFIOMKAJFHC(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 1;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x00210D3C File Offset: 0x0020EF3C
		public void ENLDGLNOGAN(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.KKOKFLMMAAK();
			this.JFDDNMCENAK = KADBECGIMPD.ANPEIKGEDHJ();
			this.GJCNMJJJDGO = KADBECGIMPD.DCGEOFHNBCN();
			this.FMKDOFCJCOP = KADBECGIMPD.KLHDFFHONON();
			this.IKKEIHEPDPN = KADBECGIMPD.BIMMPENHGMD();
			this.CLCBHHLLLFN = KADBECGIMPD.AGNKAFLKCAG();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.OLKMHFNLBJB);
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x00210DA8 File Offset: 0x0020EFA8
		public virtual int JDAIMBGAAML(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 1;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x00210DEC File Offset: 0x0020EFEC
		public void MBLEIMCGLCE(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.KKOKFLMMAAK();
			this.JFDDNMCENAK = KADBECGIMPD.ANPEIKGEDHJ();
			this.GJCNMJJJDGO = KADBECGIMPD.DCGEOFHNBCN();
			this.FMKDOFCJCOP = KADBECGIMPD.IBKCNEICPEL();
			this.IKKEIHEPDPN = KADBECGIMPD.CNNEPCOAMJK();
			this.CLCBHHLLLFN = KADBECGIMPD.DOJKJHMJJNK();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.OLKMHFNLBJB);
		}

		// Token: 0x060045A3 RID: 17827 RVA: 0x00210E58 File Offset: 0x0020F058
		public virtual string HPBHHAKPGAD()
		{
			string format = "PistolReload";
			object[] array = new object[0];
			array[1] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[0] = this.JFDDNMCENAK;
			array[4] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(this.GJCNMJJJDGO);
			array[1] = JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x060045A4 RID: 17828 RVA: 0x00210EC4 File Offset: 0x0020F0C4
		public override int HGFLLGHHJML(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 1;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x00210F08 File Offset: 0x0020F108
		public override int IOCPBFFNIDK(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 1;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH BFHNHJEJFMM()
		{
			return null;
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH JJINIAMLEEA()
		{
			return null;
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x00210F4C File Offset: 0x0020F14C
		public virtual int KNEOKAHGENI(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x00210F90 File Offset: 0x0020F190
		public override int HFCKNENEKKP(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 1;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x00210FD4 File Offset: 0x0020F1D4
		public void OHAMJIKDMMF(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.KDNDJNEGBDI();
			this.JFDDNMCENAK = KADBECGIMPD.DCGEOFHNBCN();
			this.GJCNMJJJDGO = KADBECGIMPD.EJPMFEJBGMN();
			this.FMKDOFCJCOP = KADBECGIMPD.DCGEOFHNBCN();
			this.IKKEIHEPDPN = KADBECGIMPD.DNGDPHIHLBG();
			this.CLCBHHLLLFN = KADBECGIMPD.HDBGOLAFOBK();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.OLKMHFNLBJB);
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x00211040 File Offset: 0x0020F240
		public virtual string ALAAOKOIJNG()
		{
			string format = "_History4LumaTex";
			object[] array = new object[]
			{
				this.BDHHPAEHFHG.HAJNMNALBBI,
				this.JFDDNMCENAK,
				null,
				null,
				null,
				null,
				JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.GJCNMJJJDGO)
			};
			array[1] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x002110AC File Offset: 0x0020F2AC
		public virtual string NEIAHJGEINP()
		{
			string format = "<color='#200080'>";
			object[] array = new object[4];
			array[1] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[0] = this.JFDDNMCENAK;
			array[6] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(this.GJCNMJJJDGO);
			array[5] = JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x00211118 File Offset: 0x0020F318
		public virtual string NKFOGFFPKFN()
		{
			string format = "MotorbikeLassoBack";
			object[] array = new object[5];
			array[1] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[0] = this.JFDDNMCENAK;
			array[2] = JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC(this.GJCNMJJJDGO);
			array[7] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x00211184 File Offset: 0x0020F384
		public void GBIFKNOMLGN(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.DOJKJHMJJNK();
			this.JFDDNMCENAK = KADBECGIMPD.HHMGLDMFCPF();
			this.GJCNMJJJDGO = KADBECGIMPD.ANPEIKGEDHJ();
			this.FMKDOFCJCOP = KADBECGIMPD.IBKCNEICPEL();
			this.IKKEIHEPDPN = KADBECGIMPD.AILCEJFAMGN();
			this.CLCBHHLLLFN = KADBECGIMPD.AGNKAFLKCAG();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.OLKMHFNLBJB);
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x002111F0 File Offset: 0x0020F3F0
		public override int LMNIKNJBFCH(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x00211234 File Offset: 0x0020F434
		public void CIPALFKOHBK(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.KDNDJNEGBDI();
			this.JFDDNMCENAK = KADBECGIMPD.DNIIFBAIPBE();
			this.GJCNMJJJDGO = KADBECGIMPD.HHMGLDMFCPF();
			this.FMKDOFCJCOP = KADBECGIMPD.EJPMFEJBGMN();
			this.IKKEIHEPDPN = KADBECGIMPD.AILCEJFAMGN();
			this.CLCBHHLLLFN = KADBECGIMPD.KDNDJNEGBDI();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.OLKMHFNLBJB);
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x002112A0 File Offset: 0x0020F4A0
		public void OCPAHLAGCAI(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.HDBGOLAFOBK();
			this.JFDDNMCENAK = KADBECGIMPD.DNIIFBAIPBE();
			this.GJCNMJJJDGO = KADBECGIMPD.DNIIFBAIPBE();
			this.FMKDOFCJCOP = KADBECGIMPD.DNIIFBAIPBE();
			this.IKKEIHEPDPN = KADBECGIMPD.FFDPCEAFGNF();
			this.CLCBHHLLLFN = KADBECGIMPD.HDBGOLAFOBK();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.OLKMHFNLBJB);
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x0021130C File Offset: 0x0020F50C
		public virtual int KLKGLIEODAI(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 1;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x00211350 File Offset: 0x0020F550
		public virtual void FOKHLKPGGFO(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.LPHMKPDBMPP().ECNKLECOKHD("_AccumOrig"), this.JFDDNMCENAK, JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.FMKDOFCJCOP));
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x002113D0 File Offset: 0x0020F5D0
		public virtual void PIKNKNNODAI(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.EKEBHIJMEML().HLBAJBLHLNI("IKMappingSpine is missing the left thigh bone."), this.JFDDNMCENAK, JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC(this.GJCNMJJJDGO), JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC(this.FMKDOFCJCOP));
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x00211450 File Offset: 0x0020F650
		public virtual void ENEEFJHINPG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.LPHMKPDBMPP().NLJOLOBPCBJ("Windmill"), this.JFDDNMCENAK, JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC(this.FMKDOFCJCOP));
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x002114D0 File Offset: 0x0020F6D0
		public void HAGJNPDIIIC(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.KDNDJNEGBDI();
			this.JFDDNMCENAK = KADBECGIMPD.IJDIMHAEAIE();
			this.GJCNMJJJDGO = KADBECGIMPD.ANPEIKGEDHJ();
			this.FMKDOFCJCOP = KADBECGIMPD.HFOPFEJDJFG();
			this.IKKEIHEPDPN = KADBECGIMPD.BIMMPENHGMD();
			this.CLCBHHLLLFN = KADBECGIMPD.HHLDBAEFNMJ();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.OLKMHFNLBJB);
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x0021153C File Offset: 0x0020F73C
		public override void NNKKDHFGIGM(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.APMJBBDBOJO().HLBAJBLHLNI("KatanaReady"), this.JFDDNMCENAK, JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.FMKDOFCJCOP));
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x002115BC File Offset: 0x0020F7BC
		public void JHLCFAGDNKM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.AGNKAFLKCAG();
			this.JFDDNMCENAK = KADBECGIMPD.EJPMFEJBGMN();
			this.GJCNMJJJDGO = KADBECGIMPD.IBKCNEICPEL();
			this.FMKDOFCJCOP = KADBECGIMPD.HFOPFEJDJFG();
			this.IKKEIHEPDPN = KADBECGIMPD.DNGDPHIHLBG();
			this.CLCBHHLLLFN = KADBECGIMPD.LDLKLPJBIJN();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.OLKMHFNLBJB);
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x00211628 File Offset: 0x0020F828
		public virtual string MIHCFECAIAD()
		{
			string format = "OneHandSwordBackSwing";
			object[] array = new object[2];
			array[0] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[0] = this.JFDDNMCENAK;
			array[3] = JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC(this.GJCNMJJJDGO);
			array[4] = JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x00211694 File Offset: 0x0020F894
		public void MCIKLDBPPFJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.DOJKJHMJJNK();
			this.JFDDNMCENAK = KADBECGIMPD.DNIIFBAIPBE();
			this.GJCNMJJJDGO = KADBECGIMPD.ANPEIKGEDHJ();
			this.FMKDOFCJCOP = KADBECGIMPD.KLHDFFHONON();
			this.IKKEIHEPDPN = KADBECGIMPD.CGJIINADKNH();
			this.CLCBHHLLLFN = KADBECGIMPD.AGNKAFLKCAG();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.OLKMHFNLBJB);
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x00211700 File Offset: 0x0020F900
		public virtual int IPLNJOONDFI(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH MFKHIBOFIFI()
		{
			return null;
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH PGFNEDLFAFD()
		{
			return null;
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x00211744 File Offset: 0x0020F944
		public virtual string FPPLGDMIGKI()
		{
			string format = "\n";
			object[] array = new object[8];
			array[1] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[0] = this.JFDDNMCENAK;
			array[3] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.GJCNMJJJDGO);
			array[7] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x002117B0 File Offset: 0x0020F9B0
		public void IBLEOELKMEC(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.IFDFHJLCHAE();
			this.JFDDNMCENAK = KADBECGIMPD.EJPMFEJBGMN();
			this.GJCNMJJJDGO = KADBECGIMPD.HFOPFEJDJFG();
			this.FMKDOFCJCOP = KADBECGIMPD.ANPEIKGEDHJ();
			this.IKKEIHEPDPN = KADBECGIMPD.ECJLJGDNFMN();
			this.CLCBHHLLLFN = KADBECGIMPD.AGNKAFLKCAG();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.OLKMHFNLBJB);
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH HFAGADCJACL()
		{
			return null;
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x0021181C File Offset: 0x0020FA1C
		public void EHBONHMNIGM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.IFDFHJLCHAE();
			this.JFDDNMCENAK = KADBECGIMPD.KLHDFFHONON();
			this.GJCNMJJJDGO = KADBECGIMPD.EJPMFEJBGMN();
			this.FMKDOFCJCOP = KADBECGIMPD.IBKCNEICPEL();
			this.IKKEIHEPDPN = KADBECGIMPD.AIDAGFNHNHE();
			this.CLCBHHLLLFN = KADBECGIMPD.KDNDJNEGBDI();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.OLKMHFNLBJB);
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x00211888 File Offset: 0x0020FA88
		public virtual void ENFDIICCBBG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.EDKGBBIIBBC().CCFFMKBBKHI("NadeThrow"), this.JFDDNMCENAK, JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.FMKDOFCJCOP));
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x00211908 File Offset: 0x0020FB08
		public virtual int IFCECCJMMJJ(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH AJJOMBGHGBD()
		{
			return null;
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HODNJCNMEMH()
		{
			return null;
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH JGBOJNELADG()
		{
			return null;
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x0021194C File Offset: 0x0020FB4C
		public void CLGMEOEMPJN(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.CLPEKGGAMAI();
			this.JFDDNMCENAK = KADBECGIMPD.DCGEOFHNBCN();
			this.GJCNMJJJDGO = KADBECGIMPD.DNIIFBAIPBE();
			this.FMKDOFCJCOP = KADBECGIMPD.HFOPFEJDJFG();
			this.IKKEIHEPDPN = KADBECGIMPD.AILCEJFAMGN();
			this.CLCBHHLLLFN = KADBECGIMPD.HDBGOLAFOBK();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.OLKMHFNLBJB);
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x002119B8 File Offset: 0x0020FBB8
		public virtual string IPDCPCECFBC()
		{
			string format = " x";
			object[] array = new object[]
			{
				this.BDHHPAEHFHG.HAJNMNALBBI
			};
			array[0] = this.JFDDNMCENAK;
			array[6] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(this.GJCNMJJJDGO);
			array[2] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x00211A24 File Offset: 0x0020FC24
		public virtual void GFOBMJGIOOJ(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.EEOPOHEALPK().DOEMGEAEBPN("error.wav"), this.JFDDNMCENAK, JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC(this.GJCNMJJJDGO), JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC(this.FMKDOFCJCOP));
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x00211AA4 File Offset: 0x0020FCA4
		public virtual string IAJFNKBPACC()
		{
			string format = "' does not exist within Assets/Resources/Fonts/";
			object[] array = new object[8];
			array[0] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[0] = this.JFDDNMCENAK;
			array[7] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(this.GJCNMJJJDGO);
			array[7] = JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x060045CB RID: 17867 RVA: 0x00211B10 File Offset: 0x0020FD10
		public virtual void EICKHIOBNJP(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.EDKGBBIIBBC().ECNKLECOKHD("IdleStrafeLeft"), this.JFDDNMCENAK, JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC(this.FMKDOFCJCOP));
		}

		// Token: 0x060045CC RID: 17868 RVA: 0x00211B90 File Offset: 0x0020FD90
		public virtual string CBPDHBKDMGC()
		{
			string format = "ProcessOnlyMaterial";
			object[] array = new object[8];
			array[0] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[0] = this.JFDDNMCENAK;
			array[7] = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO(this.GJCNMJJJDGO);
			array[6] = JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x060045CD RID: 17869 RVA: 0x00211BFC File Offset: 0x0020FDFC
		public virtual void BCJDFPNDIFF(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.APMJBBDBOJO().GNKIBMGNHNE("ChannelCastDirected"), this.JFDDNMCENAK, JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC(this.FMKDOFCJCOP));
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x00211C7C File Offset: 0x0020FE7C
		public virtual string PFJJIMIOAPO()
		{
			string format = "Sitting Reading Lean Back";
			object[] array = new object[0];
			array[0] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[0] = this.JFDDNMCENAK;
			array[5] = JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC(this.GJCNMJJJDGO);
			array[7] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x060045CF RID: 17871 RVA: 0x00211CE8 File Offset: 0x0020FEE8
		public void OMCHPBBJGAH(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.KDNDJNEGBDI();
			this.JFDDNMCENAK = KADBECGIMPD.DMABDIGCLKA();
			this.GJCNMJJJDGO = KADBECGIMPD.KLHDFFHONON();
			this.FMKDOFCJCOP = KADBECGIMPD.ANPEIKGEDHJ();
			this.IKKEIHEPDPN = KADBECGIMPD.MOBPFEEAMKD();
			this.CLCBHHLLLFN = KADBECGIMPD.HDBGOLAFOBK();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.OLKMHFNLBJB);
		}

		// Token: 0x060045D0 RID: 17872 RVA: 0x00211D54 File Offset: 0x0020FF54
		public virtual string BPODJNKAIEC()
		{
			string format = "Hidden/Post FX/Grain Generator";
			object[] array = new object[4];
			array[0] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[0] = this.JFDDNMCENAK;
			array[3] = JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.GJCNMJJJDGO);
			array[8] = JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x060045D1 RID: 17873 RVA: 0x00211DC0 File Offset: 0x0020FFC0
		public virtual int PFNMADDPJLK(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045D2 RID: 17874 RVA: 0x00211E04 File Offset: 0x00210004
		public virtual void DIBKBCDFLIC(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.EEOPOHEALPK().HEIBEHAEHBM("money"), this.JFDDNMCENAK, JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(this.GJCNMJJJDGO), JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC(this.FMKDOFCJCOP));
		}

		// Token: 0x060045D3 RID: 17875 RVA: 0x00211E84 File Offset: 0x00210084
		public virtual int HDBBBILHDMC(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 1;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x00211EC8 File Offset: 0x002100C8
		public virtual string ANJOEAHHDGC()
		{
			string format = "offsets";
			object[] array = new object[3];
			array[1] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[1] = this.JFDDNMCENAK;
			array[3] = JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.GJCNMJJJDGO);
			array[4] = JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x00211F34 File Offset: 0x00210134
		public virtual int LIJFAHDLGJI(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x00211F78 File Offset: 0x00210178
		public void JKLHIJKGLJB(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.AGNKAFLKCAG();
			this.JFDDNMCENAK = KADBECGIMPD.IBKCNEICPEL();
			this.GJCNMJJJDGO = KADBECGIMPD.ANPEIKGEDHJ();
			this.FMKDOFCJCOP = KADBECGIMPD.HHMGLDMFCPF();
			this.IKKEIHEPDPN = KADBECGIMPD.ECJLJGDNFMN();
			this.CLCBHHLLLFN = KADBECGIMPD.HHLDBAEFNMJ();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.OLKMHFNLBJB);
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x00211FE4 File Offset: 0x002101E4
		public virtual string JODMFMFAOEG()
		{
			string format = "harvestmsg3";
			object[] array = new object[2];
			array[0] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[0] = this.JFDDNMCENAK;
			array[5] = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO(this.GJCNMJJJDGO);
			array[4] = JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x00212050 File Offset: 0x00210250
		public void ONIJHKMCCHH(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.AGNKAFLKCAG();
			this.JFDDNMCENAK = KADBECGIMPD.DNIIFBAIPBE();
			this.GJCNMJJJDGO = KADBECGIMPD.HFOPFEJDJFG();
			this.FMKDOFCJCOP = KADBECGIMPD.HFOPFEJDJFG();
			this.IKKEIHEPDPN = KADBECGIMPD.ECJLJGDNFMN();
			this.CLCBHHLLLFN = KADBECGIMPD.HDBGOLAFOBK();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.OLKMHFNLBJB);
		}

		// Token: 0x060045D9 RID: 17881 RVA: 0x002120BC File Offset: 0x002102BC
		public virtual string IIBPDPDEBNA()
		{
			string format = "reel_type";
			object[] array = new object[5];
			array[0] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[1] = this.JFDDNMCENAK;
			array[0] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(this.GJCNMJJJDGO);
			array[8] = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x00212128 File Offset: 0x00210328
		public virtual void AACAABDCNBO(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.EEOPOHEALPK().CCFFMKBBKHI("Get post"), this.JFDDNMCENAK, JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(this.GJCNMJJJDGO), JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.FMKDOFCJCOP));
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x002121A8 File Offset: 0x002103A8
		public virtual int PMHKENHEHGM(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x002121EC File Offset: 0x002103EC
		public void INDMOLIMBFB(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.LDLKLPJBIJN();
			this.JFDDNMCENAK = KADBECGIMPD.DCGEOFHNBCN();
			this.GJCNMJJJDGO = KADBECGIMPD.HHMGLDMFCPF();
			this.FMKDOFCJCOP = KADBECGIMPD.KLHDFFHONON();
			this.IKKEIHEPDPN = KADBECGIMPD.BIMMPENHGMD();
			this.CLCBHHLLLFN = KADBECGIMPD.HHLDBAEFNMJ();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.OLKMHFNLBJB);
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH FMMNICCENPF()
		{
			return null;
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x00212258 File Offset: 0x00210458
		public override int DPAPDKMLFCB(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x0021229C File Offset: 0x0021049C
		public void IHONANEEDOC(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.HHLDBAEFNMJ();
			this.JFDDNMCENAK = KADBECGIMPD.IJDIMHAEAIE();
			this.GJCNMJJJDGO = KADBECGIMPD.ANPEIKGEDHJ();
			this.FMKDOFCJCOP = KADBECGIMPD.HHMGLDMFCPF();
			this.IKKEIHEPDPN = KADBECGIMPD.MOBPFEEAMKD();
			this.CLCBHHLLLFN = KADBECGIMPD.HDBGOLAFOBK();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.OLKMHFNLBJB);
		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x00212308 File Offset: 0x00210508
		public void EPEGCPELLCN(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.IFDFHJLCHAE();
			this.JFDDNMCENAK = KADBECGIMPD.DNIIFBAIPBE();
			this.GJCNMJJJDGO = KADBECGIMPD.IBKCNEICPEL();
			this.FMKDOFCJCOP = KADBECGIMPD.HFOPFEJDJFG();
			this.IKKEIHEPDPN = KADBECGIMPD.CNNEPCOAMJK();
			this.CLCBHHLLLFN = KADBECGIMPD.HDBGOLAFOBK();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.OLKMHFNLBJB);
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x00212374 File Offset: 0x00210574
		public virtual void CKEADHDIJAO(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.CLIMNFDGOEG().FLEANFGEJML("No IK assigned in HitReaction"), this.JFDDNMCENAK, JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.FMKDOFCJCOP));
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x002123F4 File Offset: 0x002105F4
		public virtual void GCFKLNJLCMF(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.EKEBHIJMEML().HEIBEHAEHBM(""), this.JFDDNMCENAK, JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC(this.GJCNMJJJDGO), JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO(this.FMKDOFCJCOP));
		}

		// Token: 0x060045E3 RID: 17891 RVA: 0x00212474 File Offset: 0x00210674
		public virtual int PINONLIJIMC(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 1;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x002124B8 File Offset: 0x002106B8
		public override int NBCAEJHKLMG(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x002124FC File Offset: 0x002106FC
		public virtual void MANGLJBHKNL(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.DBMJJPBOPEK().HEIBEHAEHBM(""), this.JFDDNMCENAK, JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(this.FMKDOFCJCOP));
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH OJONMJNDGAA()
		{
			return null;
		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x0021257C File Offset: 0x0021077C
		public virtual int HOHCDEENBPL(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045E8 RID: 17896 RVA: 0x002125C0 File Offset: 0x002107C0
		public virtual string JMCNJFKMDKI()
		{
			string format = " value=";
			object[] array = new object[4];
			array[1] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[1] = this.JFDDNMCENAK;
			array[7] = JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.GJCNMJJJDGO);
			array[6] = JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH CJDBDJMFEGK()
		{
			return null;
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x0021262C File Offset: 0x0021082C
		public virtual string KGHKBMFEEDH()
		{
			string format = "u_UniqueShadowMatrix";
			object[] array = new object[0];
			array[1] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[0] = this.JFDDNMCENAK;
			array[4] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.GJCNMJJJDGO);
			array[4] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DKNEPLMPHOD()
		{
			return null;
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x00212698 File Offset: 0x00210898
		public virtual void LJNDKCGLDMA(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.EKEBHIJMEML().CCFFMKBBKHI("---"), this.JFDDNMCENAK, JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC(this.FMKDOFCJCOP));
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH HHOBCJNGCEL()
		{
			return null;
		}

		// Token: 0x060045EE RID: 17902 RVA: 0x00212718 File Offset: 0x00210918
		public virtual void JNPHEKIFFLD(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("Images/MouseCursor/Link"), this.JFDDNMCENAK, JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC(this.GJCNMJJJDGO), JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(this.FMKDOFCJCOP));
		}

		// Token: 0x060045EF RID: 17903 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH BIBPDODNMJL()
		{
			return null;
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x00212798 File Offset: 0x00210998
		public void NHHAANEMJCK(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.HDBGOLAFOBK();
			this.JFDDNMCENAK = KADBECGIMPD.HFOPFEJDJFG();
			this.GJCNMJJJDGO = KADBECGIMPD.EJPMFEJBGMN();
			this.FMKDOFCJCOP = KADBECGIMPD.IBKCNEICPEL();
			this.IKKEIHEPDPN = KADBECGIMPD.AIDAGFNHNHE();
			this.CLCBHHLLLFN = KADBECGIMPD.KKOKFLMMAAK();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.OLKMHFNLBJB);
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x00212804 File Offset: 0x00210A04
		public override int NAKPJJPCNDP(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x00212848 File Offset: 0x00210A48
		public virtual string PNAEJEIKIOO()
		{
			string format = "TenkokuModule";
			object[] array = new object[6];
			array[1] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[1] = this.JFDDNMCENAK;
			array[0] = JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.GJCNMJJJDGO);
			array[1] = JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x002128B4 File Offset: 0x00210AB4
		public override int PPJDDEJPOBL(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 1;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045F4 RID: 17908 RVA: 0x002128F8 File Offset: 0x00210AF8
		public virtual void MHBPPCKHKHO(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.EKEBHIJMEML().FLEANFGEJML("IceHockeyShotRight"), this.JFDDNMCENAK, JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(this.FMKDOFCJCOP));
		}

		// Token: 0x060045F5 RID: 17909 RVA: 0x00212978 File Offset: 0x00210B78
		public virtual int GECLNKAEGJJ(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FNIIBBGCFMB()
		{
			return null;
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x002129BC File Offset: 0x00210BBC
		public void BIGEEOCOICN(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.LDLKLPJBIJN();
			this.JFDDNMCENAK = KADBECGIMPD.EJPMFEJBGMN();
			this.GJCNMJJJDGO = KADBECGIMPD.EJPMFEJBGMN();
			this.FMKDOFCJCOP = KADBECGIMPD.DMABDIGCLKA();
			this.IKKEIHEPDPN = KADBECGIMPD.MOBPFEEAMKD();
			this.CLCBHHLLLFN = KADBECGIMPD.AGNKAFLKCAG();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.OLKMHFNLBJB);
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x00212A28 File Offset: 0x00210C28
		public virtual int IKDBEOHOOJJ(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x00212A6C File Offset: 0x00210C6C
		public void ABKNFJOOHJL(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.KDNDJNEGBDI();
			this.JFDDNMCENAK = KADBECGIMPD.DMABDIGCLKA();
			this.GJCNMJJJDGO = KADBECGIMPD.KLHDFFHONON();
			this.FMKDOFCJCOP = KADBECGIMPD.HHMGLDMFCPF();
			this.IKKEIHEPDPN = KADBECGIMPD.ECJLJGDNFMN();
			this.CLCBHHLLLFN = KADBECGIMPD.LDLKLPJBIJN();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.OLKMHFNLBJB);
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x00212AD8 File Offset: 0x00210CD8
		public void JKHENPBFLCD(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OLKMHFNLBJB = KADBECGIMPD.IFDFHJLCHAE();
			this.JFDDNMCENAK = KADBECGIMPD.KLHDFFHONON();
			this.GJCNMJJJDGO = KADBECGIMPD.HHMGLDMFCPF();
			this.FMKDOFCJCOP = KADBECGIMPD.DNIIFBAIPBE();
			this.IKKEIHEPDPN = KADBECGIMPD.DNGDPHIHLBG();
			this.CLCBHHLLLFN = KADBECGIMPD.CLPEKGGAMAI();
			this.BDHHPAEHFHG = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.OLKMHFNLBJB);
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x00212B44 File Offset: 0x00210D44
		public virtual void KEJEGGGIAGB(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.EKEBHIJMEML().CKAOHMEKLMH("ArmFlex5"), this.JFDDNMCENAK, JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC(this.FMKDOFCJCOP));
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x00212BC4 File Offset: 0x00210DC4
		public virtual int OOOOMBKJKMO(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x00212C08 File Offset: 0x00210E08
		public virtual int JLDACJOFMJJ(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 1;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x00212C4C File Offset: 0x00210E4C
		public virtual void NKBOMOAMPOO(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.DBMJJPBOPEK().HEIBEHAEHBM(""), this.JFDDNMCENAK, JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(this.GJCNMJJJDGO), JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(this.FMKDOFCJCOP));
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x00212CCC File Offset: 0x00210ECC
		public virtual int EAPGHECOGKI(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH PDJBFPOAPBA()
		{
			return null;
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x00212D10 File Offset: 0x00210F10
		public virtual void KCFEGGGKCDM(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.BDHHPAEHFHG.HAJNMNALBBI;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.IMLLGEMPHAP().NLJOLOBPCBJ("_BlurCoe"), this.JFDDNMCENAK, JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.GJCNMJJJDGO), JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.FMKDOFCJCOP));
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x00212D90 File Offset: 0x00210F90
		public virtual int EFINPLLKKAO(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 0;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x00212DD4 File Offset: 0x00210FD4
		public virtual string KCBJCGOINMK()
		{
			string format = "gi_fridge";
			object[] array = new object[1];
			array[1] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[1] = this.JFDDNMCENAK;
			array[4] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(this.GJCNMJJJDGO);
			array[6] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x00212E40 File Offset: 0x00211040
		public virtual string JJPMKNKFPPN()
		{
			string format = "[maxcnt]";
			object[] array = new object[]
			{
				this.BDHHPAEHFHG.HAJNMNALBBI,
				this.JFDDNMCENAK,
				null,
				null,
				null,
				null,
				JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.GJCNMJJJDGO)
			};
			array[4] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH JMNBEKPPGLP()
		{
			return null;
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x00212EAC File Offset: 0x002110AC
		public override string PGJOHGFNAPC()
		{
			string format = "\n";
			object[] array = new object[7];
			array[1] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[0] = this.JFDDNMCENAK;
			array[1] = JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(this.GJCNMJJJDGO);
			array[7] = JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x00212F18 File Offset: 0x00211118
		public virtual int HPPMMNCAGGJ(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 1;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x00212F64 File Offset: 0x00211164
		public virtual string DIPEOLHEMHK()
		{
			string format = "** Panel save position";
			object[] array = new object[4];
			array[1] = this.BDHHPAEHFHG.HAJNMNALBBI;
			array[0] = this.JFDDNMCENAK;
			array[8] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(this.GJCNMJJJDGO);
			array[8] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(this.FMKDOFCJCOP);
			string.Format(format, array);
			return this.BDHHPAEHFHG.HAJNMNALBBI;
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x00212FD0 File Offset: 0x002111D0
		public virtual int ABDMMOJDGLN(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 1;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 0;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x00213014 File Offset: 0x00211214
		public virtual int ODHFPJGIFCG(ItemBase MBKPMBPLIJN)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)MBKPMBPLIJN;
			if (this.BDHHPAEHFHG == null)
			{
				return 1;
			}
			if (gdemcacnpng.BDHHPAEHFHG == null)
			{
				return 1;
			}
			return string.CompareOrdinal(this.BDHHPAEHFHG.HAJNMNALBBI, gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI);
		}

		// Token: 0x04000B0B RID: 2827
		public int OLKMHFNLBJB;

		// Token: 0x04000B0C RID: 2828
		public long JFDDNMCENAK;

		// Token: 0x04000B0D RID: 2829
		public long GJCNMJJJDGO;

		// Token: 0x04000B0E RID: 2830
		public long FMKDOFCJCOP;

		// Token: 0x04000B0F RID: 2831
		public int CLCBHHLLLFN;

		// Token: 0x04000B10 RID: 2832
		public float IKKEIHEPDPN;

		// Token: 0x04000B11 RID: 2833
		public IDCHHHEDHDC BDHHPAEHFHG;
	}

	// Token: 0x0200014B RID: 331
	public class GIONPNFHOOC : ItemBase
	{
		// Token: 0x0600460C RID: 17932 RVA: 0x00213057 File Offset: 0x00211257
		public override string IBLEHFEBIMG()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x00213057 File Offset: 0x00211257
		public override string ToString()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH CBCJEPLFMIM()
		{
			return null;
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH OFPLJEDIFMK()
		{
			return null;
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string OKJEDFNFDML()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH GKPOPMAAGIJ()
		{
			return null;
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH GCLHFHNKONE()
		{
			return null;
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FGKHJANCMEM()
		{
			return null;
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH PBEMPJOBKKI()
		{
			return null;
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FEHBDOHNGGN()
		{
			return null;
		}

		// Token: 0x06004616 RID: 17942 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string NCNNJHIIAFM()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004617 RID: 17943 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH JGBOJNELADG()
		{
			return null;
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string JKGHGFFFGEH()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004619 RID: 17945 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH EJJAGEFMHCO()
		{
			return null;
		}

		// Token: 0x0600461A RID: 17946 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FNIIBBGCFMB()
		{
			return null;
		}

		// Token: 0x0600461B RID: 17947 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DKNEPLMPHOD()
		{
			return null;
		}

		// Token: 0x0600461C RID: 17948 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string NMBKBGNBAEM()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HAEJBFNEIOM()
		{
			return null;
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH PPJOPGPEFGI()
		{
			return null;
		}

		// Token: 0x0600461F RID: 17951 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string GCIGMHOJAIM()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH AMBFDBDHIEJ()
		{
			return null;
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DCIMNIONGEM()
		{
			return null;
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH IHIKKLOPOKL()
		{
			return null;
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LNHLBIOOINI()
		{
			return null;
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH PLEHKPMDEFJ()
		{
			return null;
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string KBHGJLAEMFH()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LINIEFNDEEF()
		{
			return null;
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LFPIIPOHIEK()
		{
			return null;
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH PFKIHEHMLDB()
		{
			return null;
		}

		// Token: 0x06004629 RID: 17961 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string AGFCIEALPEM()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x0600462A RID: 17962 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string KCBJCGOINMK()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x0600462B RID: 17963 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH IPEDEEMNPFN()
		{
			return null;
		}

		// Token: 0x0600462C RID: 17964 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string DINGGHOCDNN()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x0600462D RID: 17965 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string JJPMKNKFPPN()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x0600462E RID: 17966 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH MDFFEHKPBHO()
		{
			return null;
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x00213057 File Offset: 0x00211257
		public override string BFOFMHGHALI()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004630 RID: 17968 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string BHLHEJCILKF()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string BNNOHGHHKBF()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string GAOJCHIOICI()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LKGPLALBDDJ()
		{
			return null;
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string PDMPLOPPLBI()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004635 RID: 17973 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH OJONMJNDGAA()
		{
			return null;
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string EFODDEDDHCE()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string FOIFFCPAJMI()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string KGHKBMFEEDH()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string PFNDMCPAGLP()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x0600463A RID: 17978 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string DDLFNJEJPBP()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x0600463B RID: 17979 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LICCJMNJLCM()
		{
			return null;
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string CFPMCOPINOH()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FMELNFODNLL()
		{
			return null;
		}

		// Token: 0x0600463E RID: 17982 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string OCJAOJLHOFO()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HLNKEKKHOHO()
		{
			return null;
		}

		// Token: 0x06004640 RID: 17984 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HGGBDGJLKKA()
		{
			return null;
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string FGNNJFJLENH()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string IIBPDPDEBNA()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string PNAEJEIKIOO()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH BHPAALLBMHL()
		{
			return null;
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string AOJIJIPBKPB()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004646 RID: 17990 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH APLAAOCGECL()
		{
			return null;
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string NHDAHNIOAFD()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x00213057 File Offset: 0x00211257
		public override string IGJFJGKAFIE()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH HFAGADCJACL()
		{
			return null;
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string NJECBCLINBO()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x00213060 File Offset: 0x00211260
		public GIONPNFHOOC(int NENOBDLCFHO, long JCGDLKIHBJG, string GAJGBADJHOK, int KCFCJHCBCFM, int PNEDPPPEFFG, int HDELGEDDDCE, int MIGBFMILDHD)
		{
			this.BGJICMGFOON = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(NENOBDLCFHO);
			this.GHGAHDMKJFE = JCGDLKIHBJG;
			this.MGILDBCKBON = GAJGBADJHOK;
			this.GBOBJLNHPBI = KCFCJHCBCFM;
			this.BINCFGAKKIB = HDELGEDDDCE;
			this.GNCMJMOJAAK = MIGBFMILDHD;
			this.IAOHOFAMLEF = PNEDPPPEFFG;
			this.LLKDCEPNHOL = JNBICAJIJMM.IKGFHGKKCPG.KHKAOHCCPAJ(PNEDPPPEFFG) + ": " + JNBICAJIJMM.IKGFHGKKCPG.IGOOOILHFPL(this.BINCFGAKKIB, 0);
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.GNCMJMOJAAK);
			if (befchfngomi != null)
			{
				this.LLKDCEPNHOL = this.LLKDCEPNHOL + " " + befchfngomi.BNIHFBMEPAB;
			}
			string text = "<color='#b0a0c0'>";
			if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI == JCGDLKIHBJG)
			{
				text = "<color='#a0ff60'>";
			}
			this.DHMBNNPDPMO = string.Concat(new string[]
			{
				"<color='#60a0ff'>",
				this.BGJICMGFOON.HAJNMNALBBI,
				" ",
				JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)KCFCJHCBCFM),
				"</color>\n",
				text,
				"Установлен <b>",
				GAJGBADJHOK,
				"</b>\n : ",
				JNBICAJIJMM.IKGFHGKKCPG.KHKAOHCCPAJ(PNEDPPPEFFG),
				"</color>"
			});
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DKGBLACIOMH()
		{
			return null;
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string NILBMGFGPPB()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string CBPDHBKDMGC()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string NIDKKALEJIM()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string BJALMHGGAFM()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH OFKKIBANOOH()
		{
			return null;
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH EDEPOFPDCEJ()
		{
			return null;
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string PGOGIIBBPLM()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string NAAOOABFHKB()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH BCKMFMCJDOG()
		{
			return null;
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH JFFFDKGGPOL()
		{
			return null;
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string DFHAGGBIEIH()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string MJODNMLNFJC()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LDDALIJPHNF()
		{
			return null;
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH NCEHHOOBOFL()
		{
			return null;
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string GMLGLOOIEAA()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH KHIDJHKNNFC()
		{
			return null;
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DGILLFBNNGD()
		{
			return null;
		}

		// Token: 0x0600465E RID: 18014 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH BCJKJAPDKLH()
		{
			return null;
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string CEOAKEEKAMH()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH AIHENNHGODP()
		{
			return null;
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x00213057 File Offset: 0x00211257
		public virtual string DIACBNHNDCJ()
		{
			return this.DHMBNNPDPMO;
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FEBAFNCKCGA()
		{
			return null;
		}

		// Token: 0x04000B12 RID: 2834
		private readonly string DHMBNNPDPMO;

		// Token: 0x04000B13 RID: 2835
		public IDCHHHEDHDC BGJICMGFOON;

		// Token: 0x04000B14 RID: 2836
		public long GHGAHDMKJFE;

		// Token: 0x04000B15 RID: 2837
		public string MGILDBCKBON;

		// Token: 0x04000B16 RID: 2838
		public int GBOBJLNHPBI;

		// Token: 0x04000B17 RID: 2839
		public int IAOHOFAMLEF;

		// Token: 0x04000B18 RID: 2840
		public int BINCFGAKKIB;

		// Token: 0x04000B19 RID: 2841
		public int GNCMJMOJAAK;

		// Token: 0x04000B1A RID: 2842
		public string LLKDCEPNHOL;
	}
}
