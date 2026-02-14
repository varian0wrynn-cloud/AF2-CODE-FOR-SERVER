using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200024E RID: 590
public class SelShdBtn : MonoBehaviour
{
	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x06008783 RID: 34691 RVA: 0x003F47EF File Offset: 0x003F29EF
	// (set) Token: 0x06008768 RID: 34664 RVA: 0x003F45FD File Offset: 0x003F27FD
	public bool HKPAEGGJNGG { get; set; }

	// Token: 0x06008769 RID: 34665 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void GBPLFFBBEHL(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x0600876A RID: 34666 RVA: 0x003F4608 File Offset: 0x003F2808
	public void EBIGDGDMIIC(NEBJANKNJOG EEPNACDOOBF)
	{
		this.shadName.text = EEPNACDOOBF.BNIHFBMEPAB;
		this.info1.text = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("box"), EEPNACDOOBF.CNOLCNDBLJE);
		if (EEPNACDOOBF.HIOAFDBKDJD)
		{
			string text = string.Format(JNBICAJIJMM.LPHMKPDBMPP().ECNKLECOKHD("Mouse Y"), EEPNACDOOBF.FPBECPLINFD.ToString("cellid"));
			this.info1.text = text;
			this.mainButtonImage.color = new Color(393f, 944f, 1793f, 1562f);
		}
		if (EEPNACDOOBF.GDJMBFGEMFJ == 1)
		{
			this.manIcon.gameObject.SetActive(false);
			this.womanIcon.gameObject.SetActive(false);
			return;
		}
		this.womanIcon.gameObject.SetActive(true);
		this.manIcon.gameObject.SetActive(false);
	}

	// Token: 0x0600876B RID: 34667 RVA: 0x003F46FC File Offset: 0x003F28FC
	public void FCBCDDEENFM(NEBJANKNJOG EEPNACDOOBF)
	{
		this.shadName.text = EEPNACDOOBF.BNIHFBMEPAB;
		this.info1.text = string.Format(JNBICAJIJMM.EKEBHIJMEML().CCFFMKBBKHI("twist"), EEPNACDOOBF.CNOLCNDBLJE);
		if (EEPNACDOOBF.HIOAFDBKDJD)
		{
			string text = string.Format(JNBICAJIJMM.DBMJJPBOPEK().GNKIBMGNHNE("Climb to the top of the mountain to see the clouds (WASD keys to move)."), EEPNACDOOBF.FPBECPLINFD.ToString("t_bottom"));
			this.info1.text = text;
			this.mainButtonImage.color = new Color(1541f, 979f, 402f, 687f);
		}
		if (EEPNACDOOBF.GDJMBFGEMFJ == 1)
		{
			this.manIcon.gameObject.SetActive(true);
			this.womanIcon.gameObject.SetActive(false);
			return;
		}
		this.womanIcon.gameObject.SetActive(true);
		this.manIcon.gameObject.SetActive(true);
	}

	// Token: 0x0600876C RID: 34668 RVA: 0x003F47EF File Offset: 0x003F29EF
	public bool BEGMLDJEIHB()
	{
		return this.<GNDJJLLHHAO>k__BackingField;
	}

	// Token: 0x0600876D RID: 34669 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MEFOGCFJBNE()
	{
	}

	// Token: 0x0600876F RID: 34671 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EMFOECIPBIP()
	{
	}

	// Token: 0x06008770 RID: 34672 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void ELKIOLNBOBI(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06008771 RID: 34673 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void CDEDAFDLDMO(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06008772 RID: 34674 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void GFOMKMFNCDF(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06008773 RID: 34675 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JIFOELPAEHG()
	{
	}

	// Token: 0x06008774 RID: 34676 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void KKDIKDOOFPJ(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06008775 RID: 34677 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HMEAENGBFKC()
	{
	}

	// Token: 0x06008776 RID: 34678 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void CFLIKOMPJFK(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06008777 RID: 34679 RVA: 0x003F47F8 File Offset: 0x003F29F8
	public void INIDEJOJOON(NEBJANKNJOG EEPNACDOOBF)
	{
		this.shadName.text = EEPNACDOOBF.BNIHFBMEPAB;
		this.info1.text = string.Format(JNBICAJIJMM.EDKGBBIIBBC().HEIBEHAEHBM("_MainTex"), EEPNACDOOBF.CNOLCNDBLJE);
		if (EEPNACDOOBF.HIOAFDBKDJD)
		{
			string text = string.Format(JNBICAJIJMM.DBMJJPBOPEK().NLJOLOBPCBJ(""), EEPNACDOOBF.FPBECPLINFD.ToString("Reset"));
			this.info1.text = text;
			this.mainButtonImage.color = new Color(1058f, 1035f, 179f, 500f);
		}
		if (EEPNACDOOBF.GDJMBFGEMFJ == 1)
		{
			this.manIcon.gameObject.SetActive(false);
			this.womanIcon.gameObject.SetActive(true);
			return;
		}
		this.womanIcon.gameObject.SetActive(false);
		this.manIcon.gameObject.SetActive(false);
	}

	// Token: 0x06008778 RID: 34680 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void DEALFKAEFFP(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06008779 RID: 34681 RVA: 0x003F48EC File Offset: 0x003F2AEC
	public void setData(NEBJANKNJOG EEPNACDOOBF)
	{
		this.shadName.text = EEPNACDOOBF.BNIHFBMEPAB;
		this.info1.text = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("selpersbtn"), EEPNACDOOBF.CNOLCNDBLJE);
		if (EEPNACDOOBF.HIOAFDBKDJD)
		{
			string text = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("deltext"), EEPNACDOOBF.FPBECPLINFD.ToString("dd\\/MM\\/yyyy HH:mm"));
			this.info1.text = text;
			this.mainButtonImage.color = new Color(1f, 0.8f, 0.8f, 0.7f);
		}
		if (EEPNACDOOBF.GDJMBFGEMFJ == 1)
		{
			this.manIcon.gameObject.SetActive(true);
			this.womanIcon.gameObject.SetActive(false);
			return;
		}
		this.womanIcon.gameObject.SetActive(true);
		this.manIcon.gameObject.SetActive(false);
	}

	// Token: 0x0600877A RID: 34682 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void ABGEEOHEMFB(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x0600877B RID: 34683 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void BBHFANJNNJG(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x0600877C RID: 34684 RVA: 0x003F47EF File Offset: 0x003F29EF
	public bool JEMIMEBKBHN()
	{
		return this.<GNDJJLLHHAO>k__BackingField;
	}

	// Token: 0x0600877D RID: 34685 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FOHLAIIMNFB()
	{
	}

	// Token: 0x0600877E RID: 34686 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void EBFEMONJMCH(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x0600877F RID: 34687 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KBMKHLDOIKP()
	{
	}

	// Token: 0x06008780 RID: 34688 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x06008781 RID: 34689 RVA: 0x003F47EF File Offset: 0x003F29EF
	public bool GBPEEMIKFHK()
	{
		return this.<GNDJJLLHHAO>k__BackingField;
	}

	// Token: 0x06008782 RID: 34690 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void JDJJPIPCIDP(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06008784 RID: 34692 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KJJBBLDJHPD()
	{
	}

	// Token: 0x06008785 RID: 34693 RVA: 0x003F47EF File Offset: 0x003F29EF
	public bool GOBKHLPJLJP()
	{
		return this.<GNDJJLLHHAO>k__BackingField;
	}

	// Token: 0x06008786 RID: 34694 RVA: 0x003F49E0 File Offset: 0x003F2BE0
	public void HEPAANBOKKE(NEBJANKNJOG EEPNACDOOBF)
	{
		this.shadName.text = EEPNACDOOBF.BNIHFBMEPAB;
		this.info1.text = string.Format(JNBICAJIJMM.IMLLGEMPHAP().HEIBEHAEHBM("********* End INSTANIATE Level  instLevelTime="), EEPNACDOOBF.CNOLCNDBLJE);
		if (EEPNACDOOBF.HIOAFDBKDJD)
		{
			string text = string.Format(JNBICAJIJMM.APMJBBDBOJO().CKAOHMEKLMH("WeaponStrafeRunLeft"), EEPNACDOOBF.FPBECPLINFD.ToString("ClimbIdle"));
			this.info1.text = text;
			this.mainButtonImage.color = new Color(250f, 510f, 1227f, 520f);
		}
		if (EEPNACDOOBF.GDJMBFGEMFJ == 1)
		{
			this.manIcon.gameObject.SetActive(false);
			this.womanIcon.gameObject.SetActive(true);
			return;
		}
		this.womanIcon.gameObject.SetActive(false);
		this.manIcon.gameObject.SetActive(false);
	}

	// Token: 0x06008787 RID: 34695 RVA: 0x003F47EF File Offset: 0x003F29EF
	public bool IGDCBIIEHFG()
	{
		return this.<GNDJJLLHHAO>k__BackingField;
	}

	// Token: 0x06008788 RID: 34696 RVA: 0x003F4AD4 File Offset: 0x003F2CD4
	public void PEIPFIBLPGN(NEBJANKNJOG EEPNACDOOBF)
	{
		this.shadName.text = EEPNACDOOBF.BNIHFBMEPAB;
		this.info1.text = string.Format(JNBICAJIJMM.APMJBBDBOJO().HLBAJBLHLNI("UserOut"), EEPNACDOOBF.CNOLCNDBLJE);
		if (EEPNACDOOBF.HIOAFDBKDJD)
		{
			string text = string.Format(JNBICAJIJMM.EEOPOHEALPK().CKAOHMEKLMH("GiantGrabIdle"), EEPNACDOOBF.FPBECPLINFD.ToString("GiantGrabIdle"));
			this.info1.text = text;
			this.mainButtonImage.color = new Color(1637f, 699f, 1056f, 1124f);
		}
		if (EEPNACDOOBF.GDJMBFGEMFJ == 0)
		{
			this.manIcon.gameObject.SetActive(true);
			this.womanIcon.gameObject.SetActive(false);
			return;
		}
		this.womanIcon.gameObject.SetActive(false);
		this.manIcon.gameObject.SetActive(true);
	}

	// Token: 0x06008789 RID: 34697 RVA: 0x003F47EF File Offset: 0x003F29EF
	public bool JKEBLINPDLD()
	{
		return this.<GNDJJLLHHAO>k__BackingField;
	}

	// Token: 0x0600878A RID: 34698 RVA: 0x003F4BC8 File Offset: 0x003F2DC8
	public void DKKIEEHMGGO(NEBJANKNJOG EEPNACDOOBF)
	{
		this.shadName.text = EEPNACDOOBF.BNIHFBMEPAB;
		this.info1.text = string.Format(JNBICAJIJMM.EKEBHIJMEML().ECNKLECOKHD("Tonemapper curve texture"), EEPNACDOOBF.CNOLCNDBLJE);
		if (EEPNACDOOBF.HIOAFDBKDJD)
		{
			string text = string.Format(JNBICAJIJMM.IKGFHGKKCPG.ECNKLECOKHD("_InvScreenSize"), EEPNACDOOBF.FPBECPLINFD.ToString("Left arm 'Palm To Thumb Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the palm towards the thumb. If the arrow points away from the thumb, axis must be negative."));
			this.info1.text = text;
			this.mainButtonImage.color = new Color(23f, 204f, 393f, 660f);
		}
		if (EEPNACDOOBF.GDJMBFGEMFJ == 1)
		{
			this.manIcon.gameObject.SetActive(false);
			this.womanIcon.gameObject.SetActive(false);
			return;
		}
		this.womanIcon.gameObject.SetActive(true);
		this.manIcon.gameObject.SetActive(true);
	}

	// Token: 0x0600878B RID: 34699 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MFHGOLNLAAF()
	{
	}

	// Token: 0x0600878C RID: 34700 RVA: 0x003F47EF File Offset: 0x003F29EF
	public bool BJBINEFJJFJ()
	{
		return this.<GNDJJLLHHAO>k__BackingField;
	}

	// Token: 0x0600878D RID: 34701 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void NDIKMBAKJEA(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x0600878E RID: 34702 RVA: 0x003F4CBC File Offset: 0x003F2EBC
	public void KFHFDOINAFH(NEBJANKNJOG EEPNACDOOBF)
	{
		this.shadName.text = EEPNACDOOBF.BNIHFBMEPAB;
		this.info1.text = string.Format(JNBICAJIJMM.EEOPOHEALPK().DOEMGEAEBPN("Sewing"), EEPNACDOOBF.CNOLCNDBLJE);
		if (EEPNACDOOBF.HIOAFDBKDJD)
		{
			string text = string.Format(JNBICAJIJMM.CLIMNFDGOEG().HLBAJBLHLNI(" ("), EEPNACDOOBF.FPBECPLINFD.ToString("iNPC"));
			this.info1.text = text;
			this.mainButtonImage.color = new Color(1859f, 132f, 1949f, 738f);
		}
		if (EEPNACDOOBF.GDJMBFGEMFJ == 0)
		{
			this.manIcon.gameObject.SetActive(true);
			this.womanIcon.gameObject.SetActive(true);
			return;
		}
		this.womanIcon.gameObject.SetActive(true);
		this.manIcon.gameObject.SetActive(true);
	}

	// Token: 0x0600878F RID: 34703 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void IKKLLLPLAHN(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06008790 RID: 34704 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JPHLMNIMDHH()
	{
	}

	// Token: 0x06008791 RID: 34705 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void HFBODIHFPJI(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06008792 RID: 34706 RVA: 0x003F47EF File Offset: 0x003F29EF
	public bool GPJODPBAFNM()
	{
		return this.<GNDJJLLHHAO>k__BackingField;
	}

	// Token: 0x06008793 RID: 34707 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void KEKALIJGLDO(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06008794 RID: 34708 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LIOCDEICIFD()
	{
	}

	// Token: 0x06008795 RID: 34709 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void ECOODCDLDJN(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06008796 RID: 34710 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void AGLPBBLCLAO(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06008797 RID: 34711 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PFNOEACNHON()
	{
	}

	// Token: 0x06008798 RID: 34712 RVA: 0x003F4DB0 File Offset: 0x003F2FB0
	public void MCMALHNDCLF(NEBJANKNJOG EEPNACDOOBF)
	{
		this.shadName.text = EEPNACDOOBF.BNIHFBMEPAB;
		this.info1.text = string.Format(JNBICAJIJMM.APMJBBDBOJO().CKAOHMEKLMH(" ms"), EEPNACDOOBF.CNOLCNDBLJE);
		if (EEPNACDOOBF.HIOAFDBKDJD)
		{
			string text = string.Format(JNBICAJIJMM.CLIMNFDGOEG().DOEMGEAEBPN("#400000"), EEPNACDOOBF.FPBECPLINFD.ToString("_BlurCoe"));
			this.info1.text = text;
			this.mainButtonImage.color = new Color(867f, 696f, 537f, 10f);
		}
		if (EEPNACDOOBF.GDJMBFGEMFJ == 1)
		{
			this.manIcon.gameObject.SetActive(false);
			this.womanIcon.gameObject.SetActive(false);
			return;
		}
		this.womanIcon.gameObject.SetActive(false);
		this.manIcon.gameObject.SetActive(false);
	}

	// Token: 0x06008799 RID: 34713 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void HLNHMDMHJFI(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x0600879A RID: 34714 RVA: 0x003F45FD File Offset: 0x003F27FD
	public void PPCHEDNLELC(bool DCCPCBLODIG)
	{
		this.<GNDJJLLHHAO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x0600879B RID: 34715 RVA: 0x003F47EF File Offset: 0x003F29EF
	public bool MGNFCEKGAEI()
	{
		return this.<GNDJJLLHHAO>k__BackingField;
	}

	// Token: 0x040012E1 RID: 4833
	public Image manIcon;

	// Token: 0x040012E2 RID: 4834
	public Image womanIcon;

	// Token: 0x040012E3 RID: 4835
	public Image mainButtonImage;

	// Token: 0x040012E4 RID: 4836
	public Text shadName;

	// Token: 0x040012E5 RID: 4837
	public Text info1;

	// Token: 0x040012E6 RID: 4838
	public Text info2;
}
