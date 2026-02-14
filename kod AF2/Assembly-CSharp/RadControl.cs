using System;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

// Token: 0x0200012F RID: 303
public class RadControl : MonoBehaviour
{
	// Token: 0x06003EC4 RID: 16068 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AOJICLCCJHF()
	{
	}

	// Token: 0x06003EC5 RID: 16069 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OPNPODKLOJK()
	{
	}

	// Token: 0x06003EC6 RID: 16070 RVA: 0x001CD7D7 File Offset: 0x001CB9D7
	public void HEAMDAMKFHD()
	{
		this.toRad = 557f;
	}

	// Token: 0x06003EC7 RID: 16071 RVA: 0x001CD7E4 File Offset: 0x001CB9E4
	private void GPBCHHCFBMJ()
	{
		if (this.NOPADEGCCLB())
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = true;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = false;
	}

	// Token: 0x06003EC8 RID: 16072 RVA: 0x001CD7E4 File Offset: 0x001CB9E4
	private void DALOMMMONFP()
	{
		if (this.NOPADEGCCLB())
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = true;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = false;
	}

	// Token: 0x06003EC9 RID: 16073 RVA: 0x001CD81D File Offset: 0x001CBA1D
	public void IHNCBOEFBHL()
	{
		this.toRad = 1564f;
	}

	// Token: 0x06003ECA RID: 16074 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void CODPNNMDKLA(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003ECB RID: 16075 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void CPELFGOJOMM(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003ECC RID: 16076 RVA: 0x001CD834 File Offset: 0x001CBA34
	private void AAEFACEGJMB()
	{
		bool flag = this.IILDPPLOHAL();
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 1320f);
		this.audsrc.volume = this.currentRad / 866f;
		this.imgEffNoice.generalIntensity = this.currentRad / 1600f;
		if (flag != this.MAMOHEJLGHP())
		{
			this.HNAGIBBNABO();
		}
	}

	// Token: 0x06003ECD RID: 16077 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void CMBCGAPCBFN(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003ECE RID: 16078 RVA: 0x001CD8A5 File Offset: 0x001CBAA5
	public void KOBAGCIAMLI()
	{
		this.toRad = 1832f;
	}

	// Token: 0x06003ECF RID: 16079 RVA: 0x001CD8B2 File Offset: 0x001CBAB2
	public void radiationOff()
	{
		this.toRad = 0f;
	}

	// Token: 0x06003ED0 RID: 16080 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void OFOGBEKGENL()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003ED1 RID: 16081 RVA: 0x001CD8C7 File Offset: 0x001CBAC7
	private bool MMFAGLNONDH()
	{
		return this.currentRad > 473f;
	}

	// Token: 0x06003ED2 RID: 16082 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PEKDKKHPINC()
	{
	}

	// Token: 0x06003ED3 RID: 16083 RVA: 0x001CD8D6 File Offset: 0x001CBAD6
	private void OGHDPNCIGMA()
	{
		if (this.IILDPPLOHAL())
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = false;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = false;
	}

	// Token: 0x06003ED4 RID: 16084 RVA: 0x001CD910 File Offset: 0x001CBB10
	private void BEDAJLJFAFO()
	{
		bool flag = this.NNLNDFEIPPM();
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 1781f);
		this.audsrc.volume = this.currentRad / 1926f;
		this.imgEffNoice.generalIntensity = this.currentRad / 1677f;
		if (flag != this.BIEIFCFODGN())
		{
			this.KDDLHBJAMDK();
		}
	}

	// Token: 0x06003ED5 RID: 16085 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ALDMBECNFFO()
	{
	}

	// Token: 0x06003ED6 RID: 16086 RVA: 0x001CD981 File Offset: 0x001CBB81
	private void DIBANDIKNMG()
	{
		if (this.CFADPGFMDII)
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = false;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = false;
	}

	// Token: 0x06003ED7 RID: 16087 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void radiationON(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003ED8 RID: 16088 RVA: 0x001CD9BA File Offset: 0x001CBBBA
	private bool DNDAJKGDEPE()
	{
		return this.currentRad > 889f;
	}

	// Token: 0x06003ED9 RID: 16089 RVA: 0x001CD9C9 File Offset: 0x001CBBC9
	public void LNPKMMEAJPI()
	{
		this.toRad = 650f;
	}

	// Token: 0x06003EDA RID: 16090 RVA: 0x001CD9D6 File Offset: 0x001CBBD6
	private bool GFCPBDHMELE()
	{
		return this.currentRad > 696f;
	}

	// Token: 0x06003EDB RID: 16091 RVA: 0x001CD9E5 File Offset: 0x001CBBE5
	public void DECGFAIDPFA()
	{
		this.toRad = 792f;
	}

	// Token: 0x06003EDC RID: 16092 RVA: 0x001CD9F4 File Offset: 0x001CBBF4
	private void NFPFDOEENLA()
	{
		bool flag = this.DNDAJKGDEPE();
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 798f);
		this.audsrc.volume = this.currentRad / 1543f;
		this.imgEffNoice.generalIntensity = this.currentRad / 921f;
		if (flag != this.EGBFKLJJCAL())
		{
			this.HICHINEHEME();
		}
	}

	// Token: 0x06003EDD RID: 16093 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void EKLLODNIAFG(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003EDE RID: 16094 RVA: 0x001CDA65 File Offset: 0x001CBC65
	private bool IILDPPLOHAL()
	{
		return this.currentRad > 236f;
	}

	// Token: 0x06003EDF RID: 16095 RVA: 0x001CDA74 File Offset: 0x001CBC74
	private void HFPPENPGGAI()
	{
		bool flag = this.EGBFKLJJCAL();
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 1077f);
		this.audsrc.volume = this.currentRad / 708f;
		this.imgEffNoice.generalIntensity = this.currentRad / 1608f;
		if (flag != this.CFADPGFMDII)
		{
			this.KNOAANNKGNP();
		}
	}

	// Token: 0x06003EE0 RID: 16096 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void Awake()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003EE1 RID: 16097 RVA: 0x001CDAE8 File Offset: 0x001CBCE8
	private void KMPEBHIPKJH()
	{
		bool flag = this.KOBPLJPBAIJ();
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 408f);
		this.audsrc.volume = this.currentRad / 1599f;
		this.imgEffNoice.generalIntensity = this.currentRad / 1417f;
		if (flag != this.NNLNDFEIPPM())
		{
			this.OBPPACNKBNL();
		}
	}

	// Token: 0x06003EE2 RID: 16098 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NCLEJMJPGKN()
	{
	}

	// Token: 0x06003EE3 RID: 16099 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void CEBAOOAIADJ()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003EE4 RID: 16100 RVA: 0x001CDB5C File Offset: 0x001CBD5C
	private void AFHBOLFGJNE()
	{
		bool flag = this.CJHCCFKICFJ();
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 399f);
		this.audsrc.volume = this.currentRad / 1385f;
		this.imgEffNoice.generalIntensity = this.currentRad / 1699f;
		if (flag != this.EOHACHEHPBI())
		{
			this.BMNMCFMAADL();
		}
	}

	// Token: 0x06003EE5 RID: 16101 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JHAKJAMBNAH()
	{
	}

	// Token: 0x06003EE6 RID: 16102 RVA: 0x001CDBCD File Offset: 0x001CBDCD
	public void CLACFHPFMMB()
	{
		this.toRad = 374f;
	}

	// Token: 0x06003EE7 RID: 16103 RVA: 0x001CDBDA File Offset: 0x001CBDDA
	private bool OHENBFHNHEF()
	{
		return this.currentRad > 1943f;
	}

	// Token: 0x06003EE8 RID: 16104 RVA: 0x001CDBEC File Offset: 0x001CBDEC
	private void GPCKACGEILI()
	{
		bool flag = this.CFADPGFMDII;
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 1301f);
		this.audsrc.volume = this.currentRad / 1596f;
		this.imgEffNoice.generalIntensity = this.currentRad / 1472f;
		if (flag != this.CFADPGFMDII)
		{
			this.BLKJFINCMLC();
		}
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06003EE9 RID: 16105 RVA: 0x001CDC5D File Offset: 0x001CBE5D
	private bool CFADPGFMDII
	{
		get
		{
			return this.currentRad > 3f;
		}
	}

	// Token: 0x06003EEA RID: 16106 RVA: 0x001CDC6C File Offset: 0x001CBE6C
	private void DAFJMNMFOON()
	{
		bool flag = this.EFFLAJEFIBO();
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 1134f);
		this.audsrc.volume = this.currentRad / 1342f;
		this.imgEffNoice.generalIntensity = this.currentRad / 1337f;
		if (flag != this.CFADPGFMDII)
		{
			this.OGHDPNCIGMA();
		}
	}

	// Token: 0x06003EEB RID: 16107 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void LPGJPFOFAJH(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003EEC RID: 16108 RVA: 0x001CDCDD File Offset: 0x001CBEDD
	private void HICHINEHEME()
	{
		if (this.MAMOHEJLGHP())
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = true;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = true;
	}

	// Token: 0x06003EED RID: 16109 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void PBGEDDNIOFM(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003EEE RID: 16110 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void KLPOBIMDADP(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003EEF RID: 16111 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void PFOFKEFHBDA(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003EF0 RID: 16112 RVA: 0x001CDD16 File Offset: 0x001CBF16
	private bool KOBPLJPBAIJ()
	{
		return this.currentRad > 234f;
	}

	// Token: 0x06003EF1 RID: 16113 RVA: 0x001CDD25 File Offset: 0x001CBF25
	private void BLKJFINCMLC()
	{
		if (this.EGBFKLJJCAL())
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = false;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = false;
	}

	// Token: 0x06003EF2 RID: 16114 RVA: 0x001CDD5E File Offset: 0x001CBF5E
	private bool EGBFKLJJCAL()
	{
		return this.currentRad > 1772f;
	}

	// Token: 0x06003EF3 RID: 16115 RVA: 0x001CDD70 File Offset: 0x001CBF70
	private void JFGGBEGNAFP()
	{
		bool flag = this.MAMOHEJLGHP();
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 1882f);
		this.audsrc.volume = this.currentRad / 1209f;
		this.imgEffNoice.generalIntensity = this.currentRad / 405f;
		if (flag != this.EFFLAJEFIBO())
		{
			this.GPBCHHCFBMJ();
		}
	}

	// Token: 0x06003EF4 RID: 16116 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LPNDCJKAKEA()
	{
	}

	// Token: 0x06003EF5 RID: 16117 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void NFIKOKDAHAG(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003EF6 RID: 16118 RVA: 0x001CDDE1 File Offset: 0x001CBFE1
	private void FFIAEHLFJKN()
	{
		if (this.BIEIFCFODGN())
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = false;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = true;
	}

	// Token: 0x06003EF7 RID: 16119 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Start()
	{
	}

	// Token: 0x06003EF8 RID: 16120 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void AOLBGAGHJDO()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003EF9 RID: 16121 RVA: 0x001CDE1A File Offset: 0x001CC01A
	public void NOILMKBNFCG()
	{
		this.toRad = 1967f;
	}

	// Token: 0x06003EFA RID: 16122 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void MMMFBIKOBGN(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003EFB RID: 16123 RVA: 0x001CDE27 File Offset: 0x001CC027
	private void JGFHBKHGJPI()
	{
		if (this.CJHCCFKICFJ())
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = false;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = false;
	}

	// Token: 0x06003EFC RID: 16124 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void GLDOCKBOGPE(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003EFD RID: 16125 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void DHIJGNHBMFJ()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003EFE RID: 16126 RVA: 0x001CDE60 File Offset: 0x001CC060
	public void NCDEFDPDPLG()
	{
		this.toRad = 165f;
	}

	// Token: 0x06003EFF RID: 16127 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void LBKPJAJJLBH()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F00 RID: 16128 RVA: 0x001CDE6D File Offset: 0x001CC06D
	private bool MAMOHEJLGHP()
	{
		return this.currentRad > 355f;
	}

	// Token: 0x06003F01 RID: 16129 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void KBNKFNBNMFN(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003F02 RID: 16130 RVA: 0x001CDE7C File Offset: 0x001CC07C
	private bool GLGOGFPBPNF()
	{
		return this.currentRad > 1079f;
	}

	// Token: 0x06003F03 RID: 16131 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GIADAJFBIOP()
	{
	}

	// Token: 0x06003F04 RID: 16132 RVA: 0x001CDE8B File Offset: 0x001CC08B
	public void MJIJMJMNEOL()
	{
		this.toRad = 716f;
	}

	// Token: 0x06003F05 RID: 16133 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void MGNGNBMMAAD()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F06 RID: 16134 RVA: 0x001CDE98 File Offset: 0x001CC098
	private void IOGAKGCADBL()
	{
		bool flag = this.EOHACHEHPBI();
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 1983f);
		this.audsrc.volume = this.currentRad / 334f;
		this.imgEffNoice.generalIntensity = this.currentRad / 218f;
		if (flag != this.KOBPLJPBAIJ())
		{
			this.HICHINEHEME();
		}
	}

	// Token: 0x06003F07 RID: 16135 RVA: 0x001CDF09 File Offset: 0x001CC109
	private void KDDLHBJAMDK()
	{
		if (this.OHENBFHNHEF())
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = false;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = true;
	}

	// Token: 0x06003F08 RID: 16136 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void CFGOEFIKLJB()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F09 RID: 16137 RVA: 0x001CDF42 File Offset: 0x001CC142
	public void ILBPOIIPDPJ()
	{
		this.toRad = 399f;
	}

	// Token: 0x06003F0A RID: 16138 RVA: 0x001CDF4F File Offset: 0x001CC14F
	public void LBKPJIJMOKG()
	{
		this.toRad = 1291f;
	}

	// Token: 0x06003F0B RID: 16139 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void DKBGMIPBHNM()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F0C RID: 16140 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CAJLCEPLKJG()
	{
	}

	// Token: 0x06003F0D RID: 16141 RVA: 0x001CDF5C File Offset: 0x001CC15C
	public void AHMIPIJIBLK()
	{
		this.toRad = 702f;
	}

	// Token: 0x06003F0E RID: 16142 RVA: 0x001CDF69 File Offset: 0x001CC169
	private void OKMHLGNDOLA()
	{
		if (this.CJHCCFKICFJ())
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = true;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = true;
	}

	// Token: 0x06003F0F RID: 16143 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FECFLBMPAAL()
	{
	}

	// Token: 0x06003F11 RID: 16145 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void IGIJMGALKEA()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F12 RID: 16146 RVA: 0x001CDFA2 File Offset: 0x001CC1A2
	public void PCNFMHAEPPL()
	{
		this.toRad = 115f;
	}

	// Token: 0x06003F13 RID: 16147 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void FPJFPNOMJNJ(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003F14 RID: 16148 RVA: 0x001CDFAF File Offset: 0x001CC1AF
	private bool BIEIFCFODGN()
	{
		return this.currentRad > 881f;
	}

	// Token: 0x06003F15 RID: 16149 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BMNJGPIPKLL()
	{
	}

	// Token: 0x06003F16 RID: 16150 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CKGPEFOKKNL()
	{
	}

	// Token: 0x06003F17 RID: 16151 RVA: 0x001CDFBE File Offset: 0x001CC1BE
	public void LHNPLMFDJHJ()
	{
		this.toRad = 1025f;
	}

	// Token: 0x06003F18 RID: 16152 RVA: 0x001CDFCC File Offset: 0x001CC1CC
	private void JBFJPNKLLKI()
	{
		bool flag = this.BIEIFCFODGN();
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 1392f);
		this.audsrc.volume = this.currentRad / 71f;
		this.imgEffNoice.generalIntensity = this.currentRad / 1272f;
		if (flag != this.NOPADEGCCLB())
		{
			this.JGFHBKHGJPI();
		}
	}

	// Token: 0x06003F19 RID: 16153 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void CFBNLFKAAKH()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F1A RID: 16154 RVA: 0x001CE03D File Offset: 0x001CC23D
	public void PBFNJAPKJPG()
	{
		this.toRad = 1998f;
	}

	// Token: 0x06003F1B RID: 16155 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FPLHODJCJDO()
	{
	}

	// Token: 0x06003F1C RID: 16156 RVA: 0x001CE04A File Offset: 0x001CC24A
	public void BKOGEKKAOOI()
	{
		this.toRad = 418f;
	}

	// Token: 0x06003F1D RID: 16157 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void AHJFCGPCFFC(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003F1E RID: 16158 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void OKCPKBGDFJH()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F1F RID: 16159 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CPNOBMNKPNC()
	{
	}

	// Token: 0x06003F20 RID: 16160 RVA: 0x001CE057 File Offset: 0x001CC257
	private void KNOAANNKGNP()
	{
		if (this.GLGOGFPBPNF())
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = false;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = false;
	}

	// Token: 0x06003F21 RID: 16161 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FEBIICIMLHA()
	{
	}

	// Token: 0x06003F22 RID: 16162 RVA: 0x001CE090 File Offset: 0x001CC290
	private bool EFFLAJEFIBO()
	{
		return this.currentRad > 616f;
	}

	// Token: 0x06003F23 RID: 16163 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void JPADPCAMLCL()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F24 RID: 16164 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IIHNDJOIMAH()
	{
	}

	// Token: 0x06003F25 RID: 16165 RVA: 0x001CE09F File Offset: 0x001CC29F
	public void BDNKBAHJBPL()
	{
		this.toRad = 435f;
	}

	// Token: 0x06003F26 RID: 16166 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void BLDELNFCEGB()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F27 RID: 16167 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void NLLHFKPPAMB(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003F28 RID: 16168 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PFNPOHMMJDN()
	{
	}

	// Token: 0x06003F29 RID: 16169 RVA: 0x001CE0AC File Offset: 0x001CC2AC
	private void AALEPLNFELA()
	{
		if (this.KOBPLJPBAIJ())
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = false;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = false;
	}

	// Token: 0x06003F2A RID: 16170 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void NOKBLBJFPBC()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F2B RID: 16171 RVA: 0x001CE0E5 File Offset: 0x001CC2E5
	public void MAEOGIJBDJB()
	{
		this.toRad = 817f;
	}

	// Token: 0x06003F2C RID: 16172 RVA: 0x001CE0F2 File Offset: 0x001CC2F2
	public void JAFKPCIHBPK()
	{
		this.toRad = 406f;
	}

	// Token: 0x06003F2D RID: 16173 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void CAAFMJLJOLO(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003F2E RID: 16174 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void PEOBEIJBBMC(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003F2F RID: 16175 RVA: 0x001CE100 File Offset: 0x001CC300
	private void CBBLGEDCJBF()
	{
		bool flag = this.CFADPGFMDII;
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 1199f);
		this.audsrc.volume = this.currentRad / 389f;
		this.imgEffNoice.generalIntensity = this.currentRad / 610f;
		if (flag != this.KOBPLJPBAIJ())
		{
			this.HNAGIBBNABO();
		}
	}

	// Token: 0x06003F30 RID: 16176 RVA: 0x001CE174 File Offset: 0x001CC374
	private void MLLJFAHJGOJ()
	{
		bool flag = this.BIEIFCFODGN();
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 933f);
		this.audsrc.volume = this.currentRad / 918f;
		this.imgEffNoice.generalIntensity = this.currentRad / 418f;
		if (flag != this.NOPADEGCCLB())
		{
			this.OGHDPNCIGMA();
		}
	}

	// Token: 0x06003F31 RID: 16177 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EFJDBBDMPMC()
	{
	}

	// Token: 0x06003F32 RID: 16178 RVA: 0x001CE1E5 File Offset: 0x001CC3E5
	private bool NNLNDFEIPPM()
	{
		return this.currentRad > 361f;
	}

	// Token: 0x06003F33 RID: 16179 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void FOIJINIJEID()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F34 RID: 16180 RVA: 0x001CE1F4 File Offset: 0x001CC3F4
	private bool NOPADEGCCLB()
	{
		return this.currentRad > 734f;
	}

	// Token: 0x06003F35 RID: 16181 RVA: 0x001CE203 File Offset: 0x001CC403
	private void OBPPACNKBNL()
	{
		if (this.CFADPGFMDII)
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = true;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = false;
	}

	// Token: 0x06003F36 RID: 16182 RVA: 0x001CE23C File Offset: 0x001CC43C
	public void KMLAFCAALBP()
	{
		this.toRad = 1347f;
	}

	// Token: 0x06003F37 RID: 16183 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void BJHFBOLNMDK()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F38 RID: 16184 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FODDAMMNECI()
	{
	}

	// Token: 0x06003F39 RID: 16185 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void IJHHOLCHNNP()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F3A RID: 16186 RVA: 0x001CE24C File Offset: 0x001CC44C
	private void AKLFCMNCPKL()
	{
		bool flag = this.NNLNDFEIPPM();
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 1162f);
		this.audsrc.volume = this.currentRad / 1427f;
		this.imgEffNoice.generalIntensity = this.currentRad / 1616f;
		if (flag != this.IILDPPLOHAL())
		{
			this.OGHDPNCIGMA();
		}
	}

	// Token: 0x06003F3B RID: 16187 RVA: 0x001CE2C0 File Offset: 0x001CC4C0
	private void JIKGIJEHGAP()
	{
		bool flag = this.IILDPPLOHAL();
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 786f);
		this.audsrc.volume = this.currentRad / 600f;
		this.imgEffNoice.generalIntensity = this.currentRad / 1897f;
		if (flag != this.EFFLAJEFIBO())
		{
			this.OGHDPNCIGMA();
		}
	}

	// Token: 0x06003F3C RID: 16188 RVA: 0x001CE331 File Offset: 0x001CC531
	public void JJHNDHLAPDI()
	{
		this.toRad = 1400f;
	}

	// Token: 0x06003F3D RID: 16189 RVA: 0x001CE33E File Offset: 0x001CC53E
	private void DFOOEIPJFHP()
	{
		if (this.DNDAJKGDEPE())
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = false;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = false;
	}

	// Token: 0x06003F3E RID: 16190 RVA: 0x001CE378 File Offset: 0x001CC578
	private void Update()
	{
		bool flag = this.CFADPGFMDII;
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 1f);
		this.audsrc.volume = this.currentRad / 100f;
		this.imgEffNoice.generalIntensity = this.currentRad / 100f;
		if (flag != this.CFADPGFMDII)
		{
			this.OBPPACNKBNL();
		}
	}

	// Token: 0x06003F3F RID: 16191 RVA: 0x001CE3E9 File Offset: 0x001CC5E9
	public void CCAKBGCCLIN()
	{
		this.toRad = 1577f;
	}

	// Token: 0x06003F40 RID: 16192 RVA: 0x001CE3F8 File Offset: 0x001CC5F8
	private void PBEKBHFDHAM()
	{
		bool flag = this.EGBFKLJJCAL();
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 150f);
		this.audsrc.volume = this.currentRad / 982f;
		this.imgEffNoice.generalIntensity = this.currentRad / 1434f;
		if (flag != this.DNDAJKGDEPE())
		{
			this.AALEPLNFELA();
		}
	}

	// Token: 0x06003F41 RID: 16193 RVA: 0x001CE469 File Offset: 0x001CC669
	private bool EOHACHEHPBI()
	{
		return this.currentRad > 1274f;
	}

	// Token: 0x06003F42 RID: 16194 RVA: 0x001CE478 File Offset: 0x001CC678
	private void BJHJGBENKDJ()
	{
		if (this.MMFAGLNONDH())
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = true;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = true;
	}

	// Token: 0x06003F43 RID: 16195 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OALIDDIKLHK()
	{
	}

	// Token: 0x06003F44 RID: 16196 RVA: 0x001CE4B4 File Offset: 0x001CC6B4
	private void EINLCOFCLLC()
	{
		bool flag = this.OHENBFHNHEF();
		this.currentRad = Mathf.Lerp(this.currentRad, this.toRad, Time.deltaTime * 1722f);
		this.audsrc.volume = this.currentRad / 1913f;
		this.imgEffNoice.generalIntensity = this.currentRad / 334f;
		if (flag != this.KOBPLJPBAIJ())
		{
			this.GPBCHHCFBMJ();
		}
	}

	// Token: 0x06003F45 RID: 16197 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PNOHGOJEJKL()
	{
	}

	// Token: 0x06003F46 RID: 16198 RVA: 0x001CE525 File Offset: 0x001CC725
	private bool CJHCCFKICFJ()
	{
		return this.currentRad > 264f;
	}

	// Token: 0x06003F47 RID: 16199 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NCALLFHEAGJ()
	{
	}

	// Token: 0x06003F48 RID: 16200 RVA: 0x001CE534 File Offset: 0x001CC734
	private void LIPOOBNHAPB()
	{
		if (this.EFFLAJEFIBO())
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = false;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = true;
	}

	// Token: 0x06003F49 RID: 16201 RVA: 0x001CE56D File Offset: 0x001CC76D
	private void HNAGIBBNABO()
	{
		if (this.KOBPLJPBAIJ())
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = true;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = true;
	}

	// Token: 0x06003F4A RID: 16202 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void MBNCGMLPNLD()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F4B RID: 16203 RVA: 0x001CD7E4 File Offset: 0x001CB9E4
	private void KOKJJJHFOOD()
	{
		if (this.NOPADEGCCLB())
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = true;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = false;
	}

	// Token: 0x06003F4C RID: 16204 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void PPNOJNBFHAP()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F4D RID: 16205 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void CHHMFDFHFAA()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F4E RID: 16206 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void CFNLKNOKAGC()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F4F RID: 16207 RVA: 0x001CD8BF File Offset: 0x001CBABF
	private void LNMBLLMCBAB()
	{
		RadControl.getI = this;
	}

	// Token: 0x06003F50 RID: 16208 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void JFMOOKLAJNA(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003F51 RID: 16209 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void EPJDLDBGIFF(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003F52 RID: 16210 RVA: 0x001CD82A File Offset: 0x001CBA2A
	public void LFFAGDNENKO(float CNOLCNDBLJE)
	{
		this.toRad = CNOLCNDBLJE;
	}

	// Token: 0x06003F53 RID: 16211 RVA: 0x001CE5A6 File Offset: 0x001CC7A6
	public void EGCLHJJLDBE()
	{
		this.toRad = 261f;
	}

	// Token: 0x06003F54 RID: 16212 RVA: 0x001CE5B3 File Offset: 0x001CC7B3
	private void BMNMCFMAADL()
	{
		if (this.CFADPGFMDII)
		{
			this.audsrc.Play();
			this.imgEffNoice.enabled = false;
			return;
		}
		this.audsrc.Stop();
		this.imgEffNoice.enabled = true;
	}

	// Token: 0x040008FF RID: 2303
	public static RadControl getI;

	// Token: 0x04000900 RID: 2304
	public float currentRad;

	// Token: 0x04000901 RID: 2305
	public float toRad;

	// Token: 0x04000902 RID: 2306
	public AudioSource audsrc;

	// Token: 0x04000903 RID: 2307
	public NoiseAndGrain imgEffNoice;
}
