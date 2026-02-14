using System;
using UnityEngine;

// Token: 0x02000071 RID: 113
[Serializable]
public class LimitedInt
{
	// Token: 0x06001A93 RID: 6803 RVA: 0x000D9D91 File Offset: 0x000D7F91
	public void BDEBGCEOCOJ(int DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001A94 RID: 6804 RVA: 0x000D9D9A File Offset: 0x000D7F9A
	public int LNNBOAPIPAK()
	{
		return this.current;
	}

	// Token: 0x06001A95 RID: 6805 RVA: 0x000D9DA2 File Offset: 0x000D7FA2
	public static LimitedInt NGNHFNGPLBM(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.EDMLIOGJLEM(limitedInt.LNNBOAPIPAK() - HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001A96 RID: 6806 RVA: 0x000D9DB8 File Offset: 0x000D7FB8
	public void CGOHGMLGLAN(int DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001A97 RID: 6807 RVA: 0x000D9DD2 File Offset: 0x000D7FD2
	public static LimitedInt PCKCNGNPLMP(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.DNAAKMDCKMB(limitedInt.LBOAJLGFMNK() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001A98 RID: 6808 RVA: 0x000D9DE8 File Offset: 0x000D7FE8
	public static LimitedInt AGAPNJLHDJN(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.OFKOPLPMDJD(limitedInt.DLOLDDMKADB() - HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x06001A99 RID: 6809 RVA: 0x000D9DFE File Offset: 0x000D7FFE
	// (set) Token: 0x06001AB6 RID: 6838 RVA: 0x000D9F6B File Offset: 0x000D816B
	public int Max
	{
		get
		{
			return this.max;
		}
		set
		{
			this.max = Mathf.Clamp(value, this.min, int.MaxValue);
		}
	}

	// Token: 0x06001A9A RID: 6810 RVA: 0x000D9E06 File Offset: 0x000D8006
	public static LimitedInt DCFPFAENNCC(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.PEKHPLPBHND(limitedInt.DLOLDDMKADB() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001A9B RID: 6811 RVA: 0x000D9DFE File Offset: 0x000D7FFE
	public int JBCADAIMOBF()
	{
		return this.max;
	}

	// Token: 0x06001A9C RID: 6812 RVA: 0x000D9D91 File Offset: 0x000D7F91
	public void JCKLEMENGOE(int DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001A9D RID: 6813 RVA: 0x000D9E1C File Offset: 0x000D801C
	public static LimitedInt CIOHDOJIHJM(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.GMCJBPEMPJB(limitedInt.EPBLLBFINNA() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001A9E RID: 6814 RVA: 0x000D9E32 File Offset: 0x000D8032
	public int CBENCJDLFMC()
	{
		return this.min;
	}

	// Token: 0x06001A9F RID: 6815 RVA: 0x000D9E3A File Offset: 0x000D803A
	public static LimitedInt PPLMANIMPOJ(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.GMCJBPEMPJB(limitedInt.LBOAJLGFMNK() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AA0 RID: 6816 RVA: 0x000D9E32 File Offset: 0x000D8032
	public int HOODHFLDKEE()
	{
		return this.min;
	}

	// Token: 0x06001AA1 RID: 6817 RVA: 0x000D9E50 File Offset: 0x000D8050
	public void JPCCONCLKCO(int DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, -73);
	}

	// Token: 0x06001AA2 RID: 6818 RVA: 0x000D9E69 File Offset: 0x000D8069
	public void BHHHDAGCHHD(int DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, 3);
	}

	// Token: 0x06001AA3 RID: 6819 RVA: 0x000D9E32 File Offset: 0x000D8032
	public int HAFHLNKLDMI()
	{
		return this.min;
	}

	// Token: 0x06001AA4 RID: 6820 RVA: 0x000D9E82 File Offset: 0x000D8082
	public static LimitedInt JCPDOGJHPOE(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.GPPCLDFKHGH(limitedInt.DLOLDDMKADB() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AA5 RID: 6821 RVA: 0x000D9E98 File Offset: 0x000D8098
	public static LimitedInt NJEBEMBFELL(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.EHNONEHHMEJ(limitedInt.GPPMAJOBOJF() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AA6 RID: 6822 RVA: 0x000D9E32 File Offset: 0x000D8032
	public int FIABFBMPBJO()
	{
		return this.min;
	}

	// Token: 0x06001AA7 RID: 6823 RVA: 0x000D9EAE File Offset: 0x000D80AE
	public static LimitedInt PDFHJEIKECF(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.IBEOKNNNGJP(limitedInt.GPPMAJOBOJF() - HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AA8 RID: 6824 RVA: 0x000D9EC4 File Offset: 0x000D80C4
	public static LimitedInt ELNBPKHBJMB(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.CILJDFKGNCI(limitedInt.Current - HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AA9 RID: 6825 RVA: 0x000D9EDA File Offset: 0x000D80DA
	public static LimitedInt MMLDNCNNKGN(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.EHNONEHHMEJ(limitedInt.OMDAIAGCNKF() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AAA RID: 6826 RVA: 0x000D9EF0 File Offset: 0x000D80F0
	public void BLNLJKJLKGM(int DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, -87);
	}

	// Token: 0x06001AAB RID: 6827 RVA: 0x000D9DFE File Offset: 0x000D7FFE
	public int NGNCICBJGCL()
	{
		return this.max;
	}

	// Token: 0x06001AAC RID: 6828 RVA: 0x000D9F09 File Offset: 0x000D8109
	public static LimitedInt JCOIBBKIMIB(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.CGOHGMLGLAN(limitedInt.EPBLLBFINNA() - HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AAD RID: 6829 RVA: 0x000D9DFE File Offset: 0x000D7FFE
	public int KHOOMLFELDO()
	{
		return this.max;
	}

	// Token: 0x06001AAE RID: 6830 RVA: 0x000D9D9A File Offset: 0x000D7F9A
	public int NENCCHPPFEF()
	{
		return this.current;
	}

	// Token: 0x06001AAF RID: 6831 RVA: 0x000D9DB8 File Offset: 0x000D7FB8
	public void EDMLIOGJLEM(int DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001AB0 RID: 6832 RVA: 0x000D9F1F File Offset: 0x000D811F
	public static LimitedInt EKPAHGPADLK(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.CGOHGMLGLAN(limitedInt.EPBLLBFINNA() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x06001B04 RID: 6916 RVA: 0x000D9E32 File Offset: 0x000D8032
	// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x000D9D91 File Offset: 0x000D7F91
	public int Min
	{
		get
		{
			return this.min;
		}
		set
		{
			this.min = value;
		}
	}

	// Token: 0x06001AB2 RID: 6834 RVA: 0x000D9F35 File Offset: 0x000D8135
	public LimitedInt(int MHBLMMENIGB, int CAOOPCFAONF, int BAPBEBJMMPH)
	{
		this.current = MHBLMMENIGB;
		this.min = CAOOPCFAONF;
		this.max = BAPBEBJMMPH;
	}

	// Token: 0x06001AB3 RID: 6835 RVA: 0x000D9F52 File Offset: 0x000D8152
	public void OEGCHOGMOHJ(int DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, -80);
	}

	// Token: 0x06001AB4 RID: 6836 RVA: 0x000D9DB8 File Offset: 0x000D7FB8
	public void OFKOPLPMDJD(int DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001AB5 RID: 6837 RVA: 0x000D9DE8 File Offset: 0x000D7FE8
	public static LimitedInt IAFLNCFLEIJ(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.OFKOPLPMDJD(limitedInt.DLOLDDMKADB() - HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AB7 RID: 6839 RVA: 0x000D9E32 File Offset: 0x000D8032
	public int CBIJBPHJKCB()
	{
		return this.min;
	}

	// Token: 0x06001AB8 RID: 6840 RVA: 0x000D9F84 File Offset: 0x000D8184
	public static LimitedInt PICCFFHAMAG(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.Current += HLIOKHMFNBF;
		return limitedInt;
	}

	// Token: 0x06001AB9 RID: 6841 RVA: 0x000D9DB8 File Offset: 0x000D7FB8
	public void DNAAKMDCKMB(int DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001ABA RID: 6842 RVA: 0x000D9F9A File Offset: 0x000D819A
	public LimitedInt(LimitedInt OENOOLNHAMK)
	{
		this.min = OENOOLNHAMK.min;
		this.max = OENOOLNHAMK.max;
		this.current = OENOOLNHAMK.current;
	}

	// Token: 0x06001ABB RID: 6843 RVA: 0x000D9FC6 File Offset: 0x000D81C6
	public static LimitedInt MFALBEDFKOO(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.OFKOPLPMDJD(limitedInt.OMDAIAGCNKF() - HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001ABC RID: 6844 RVA: 0x000D9D91 File Offset: 0x000D7F91
	public void AAOPNJLCDOE(int DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001ABD RID: 6845 RVA: 0x000D9DB8 File Offset: 0x000D7FB8
	public void EHNONEHHMEJ(int DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001ABE RID: 6846 RVA: 0x000D9FDC File Offset: 0x000D81DC
	public static LimitedInt ILBMBBNLACG(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.Current = limitedInt.DLOLDDMKADB() - HLIOKHMFNBF;
		return limitedInt;
	}

	// Token: 0x06001ABF RID: 6847 RVA: 0x000D9E32 File Offset: 0x000D8032
	public int NDLBIIJJOFL()
	{
		return this.min;
	}

	// Token: 0x06001AC0 RID: 6848 RVA: 0x000D9DFE File Offset: 0x000D7FFE
	public int OBIACLEJIBD()
	{
		return this.max;
	}

	// Token: 0x06001AC1 RID: 6849 RVA: 0x000D9DB8 File Offset: 0x000D7FB8
	public void GMCJBPEMPJB(int DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001AC2 RID: 6850 RVA: 0x000D9FF2 File Offset: 0x000D81F2
	public void BPECPIJFGEK(int DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, -93);
	}

	// Token: 0x06001AC3 RID: 6851 RVA: 0x000D9E32 File Offset: 0x000D8032
	public int DHMPFMEGACI()
	{
		return this.min;
	}

	// Token: 0x06001AC4 RID: 6852 RVA: 0x000D9DFE File Offset: 0x000D7FFE
	public int KCJFBBIKNGD()
	{
		return this.max;
	}

	// Token: 0x06001AC5 RID: 6853 RVA: 0x000D9E69 File Offset: 0x000D8069
	public void PIACIAKMMAL(int DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, 3);
	}

	// Token: 0x06001AC6 RID: 6854 RVA: 0x000DA00B File Offset: 0x000D820B
	public static LimitedInt HCGAHMIEGGG(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.EHNONEHHMEJ(limitedInt.EPBLLBFINNA() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AC7 RID: 6855 RVA: 0x000D9E32 File Offset: 0x000D8032
	public int BCKGIHLHCGE()
	{
		return this.min;
	}

	// Token: 0x06001AC8 RID: 6856 RVA: 0x000D9D91 File Offset: 0x000D7F91
	public void DIOFANIDKNE(int DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001AC9 RID: 6857 RVA: 0x000D9DFE File Offset: 0x000D7FFE
	public int PNDJKALBDFL()
	{
		return this.max;
	}

	// Token: 0x06001ACA RID: 6858 RVA: 0x000DA021 File Offset: 0x000D8221
	public LimitedInt(int MHBLMMENIGB)
	{
		this.current = MHBLMMENIGB;
		this.min = int.MinValue;
		this.max = int.MaxValue;
	}

	// Token: 0x06001ACB RID: 6859 RVA: 0x000D9D91 File Offset: 0x000D7F91
	public void PGBKGDDFPJO(int DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001ACC RID: 6860 RVA: 0x000DA046 File Offset: 0x000D8246
	public static LimitedInt DPCLKOBCCCC(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.OFKOPLPMDJD(limitedInt.GPPMAJOBOJF() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001ACD RID: 6861 RVA: 0x000D9EF0 File Offset: 0x000D80F0
	public void KDJOKPPILOB(int DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, -87);
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x06001B0E RID: 6926 RVA: 0x000D9D9A File Offset: 0x000D7F9A
	// (set) Token: 0x06001ACE RID: 6862 RVA: 0x000D9DB8 File Offset: 0x000D7FB8
	public int Current
	{
		get
		{
			return this.current;
		}
		set
		{
			this.current = Mathf.Clamp(value, this.min, this.max);
		}
	}

	// Token: 0x06001ACF RID: 6863 RVA: 0x000D9D91 File Offset: 0x000D7F91
	public void NOFCMDIJNEO(int DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001AD0 RID: 6864 RVA: 0x000DA05C File Offset: 0x000D825C
	public static LimitedInt HFKELEHOJLM(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.Current = limitedInt.LBOAJLGFMNK() + HLIOKHMFNBF;
		return limitedInt;
	}

	// Token: 0x06001AD1 RID: 6865 RVA: 0x000DA072 File Offset: 0x000D8272
	public static LimitedInt PPBHEODICFA(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.Current -= HLIOKHMFNBF;
		return limitedInt;
	}

	// Token: 0x06001AD2 RID: 6866 RVA: 0x000D9DB8 File Offset: 0x000D7FB8
	public void EMGNLNCPDGK(int DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001AD3 RID: 6867 RVA: 0x000D9DB8 File Offset: 0x000D7FB8
	public void PNGCAIDPPPE(int DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001AD4 RID: 6868 RVA: 0x000DA088 File Offset: 0x000D8288
	public void MKOIPAPBNON(int DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, -126);
	}

	// Token: 0x06001AD5 RID: 6869 RVA: 0x000D9DFE File Offset: 0x000D7FFE
	public int FLNJAMCKKJC()
	{
		return this.max;
	}

	// Token: 0x06001AD6 RID: 6870 RVA: 0x000D9D9A File Offset: 0x000D7F9A
	public int LBOAJLGFMNK()
	{
		return this.current;
	}

	// Token: 0x06001AD7 RID: 6871 RVA: 0x000D9D9A File Offset: 0x000D7F9A
	public int OMDAIAGCNKF()
	{
		return this.current;
	}

	// Token: 0x06001AD8 RID: 6872 RVA: 0x000DA0A1 File Offset: 0x000D82A1
	public void PPPHBEFKLHJ(int DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, -167);
	}

	// Token: 0x06001AD9 RID: 6873 RVA: 0x000DA0BA File Offset: 0x000D82BA
	public static LimitedInt GBDKBKCLPEL(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.GPPCLDFKHGH(limitedInt.NENCCHPPFEF() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001ADA RID: 6874 RVA: 0x000D9D9A File Offset: 0x000D7F9A
	public int EPBLLBFINNA()
	{
		return this.current;
	}

	// Token: 0x06001ADB RID: 6875 RVA: 0x000D9E32 File Offset: 0x000D8032
	public int BCDNHADFDEK()
	{
		return this.min;
	}

	// Token: 0x06001ADC RID: 6876 RVA: 0x000D9E32 File Offset: 0x000D8032
	public int DBCMCCINLPO()
	{
		return this.min;
	}

	// Token: 0x06001ADD RID: 6877 RVA: 0x000D9DB8 File Offset: 0x000D7FB8
	public void PEKHPLPBHND(int DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001ADE RID: 6878 RVA: 0x000D9DFE File Offset: 0x000D7FFE
	public int GBFIDOKPPAE()
	{
		return this.max;
	}

	// Token: 0x06001ADF RID: 6879 RVA: 0x000D9F1F File Offset: 0x000D811F
	public static LimitedInt HLMMLAJGECB(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.CGOHGMLGLAN(limitedInt.EPBLLBFINNA() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AE0 RID: 6880 RVA: 0x000D9F84 File Offset: 0x000D8184
	public static LimitedInt IJDBECJHNJO(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.Current += HLIOKHMFNBF;
		return limitedInt;
	}

	// Token: 0x06001AE1 RID: 6881 RVA: 0x000D9D91 File Offset: 0x000D7F91
	public void DMOJKDOLPLI(int DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001AE2 RID: 6882 RVA: 0x000D9D9A File Offset: 0x000D7F9A
	public int DLOLDDMKADB()
	{
		return this.current;
	}

	// Token: 0x06001AE3 RID: 6883 RVA: 0x000DA0D0 File Offset: 0x000D82D0
	public void IDJKFJPLHKC(int DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, -12);
	}

	// Token: 0x06001AE4 RID: 6884 RVA: 0x000D9DFE File Offset: 0x000D7FFE
	public int DCJPHJDNPOG()
	{
		return this.max;
	}

	// Token: 0x06001AE5 RID: 6885 RVA: 0x000DA0E9 File Offset: 0x000D82E9
	public static LimitedInt LIGKIFEAKJP(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.CIMFPALFHOG(limitedInt.LNNBOAPIPAK() - HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AE6 RID: 6886 RVA: 0x000D9DFE File Offset: 0x000D7FFE
	public int EDLKHIJFFFN()
	{
		return this.max;
	}

	// Token: 0x06001AE7 RID: 6887 RVA: 0x000DA0FF File Offset: 0x000D82FF
	public static LimitedInt IFFLIIHFODC(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.JJBIBIGGAIB(limitedInt.EPBLLBFINNA() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AE8 RID: 6888 RVA: 0x000DA072 File Offset: 0x000D8272
	public static LimitedInt MDPAMKBEINI(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.Current -= HLIOKHMFNBF;
		return limitedInt;
	}

	// Token: 0x06001AE9 RID: 6889 RVA: 0x000DA115 File Offset: 0x000D8315
	public static LimitedInt HMGOCBLALME(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.OFKOPLPMDJD(limitedInt.LBOAJLGFMNK() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AEA RID: 6890 RVA: 0x000D9E32 File Offset: 0x000D8032
	public int BGLNJICEOFJ()
	{
		return this.min;
	}

	// Token: 0x06001AEB RID: 6891 RVA: 0x000DA12B File Offset: 0x000D832B
	public static LimitedInt KKCBCHMCDHI(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.EMGNLNCPDGK(limitedInt.LNNBOAPIPAK() - HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AEC RID: 6892 RVA: 0x000DA141 File Offset: 0x000D8341
	public static LimitedInt CJGPHJEILBI(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.OFKOPLPMDJD(limitedInt.EPBLLBFINNA() - HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AED RID: 6893 RVA: 0x000D9E32 File Offset: 0x000D8032
	public int PJCNDBCPJLE()
	{
		return this.min;
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x000D9E32 File Offset: 0x000D8032
	public int EACDJCJPNDI()
	{
		return this.min;
	}

	// Token: 0x06001AEF RID: 6895 RVA: 0x000DA157 File Offset: 0x000D8357
	public static LimitedInt IPNFMFDDNMI(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.EMGNLNCPDGK(limitedInt.EPBLLBFINNA() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x000D9DFE File Offset: 0x000D7FFE
	public int KKMBEHPIHFF()
	{
		return this.max;
	}

	// Token: 0x06001AF1 RID: 6897 RVA: 0x000DA16D File Offset: 0x000D836D
	public void KNLDBKELLAI(int DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, 111);
	}

	// Token: 0x06001AF2 RID: 6898 RVA: 0x000D9DB8 File Offset: 0x000D7FB8
	public void IBEOKNNNGJP(int DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001AF3 RID: 6899 RVA: 0x000DA186 File Offset: 0x000D8386
	public static LimitedInt BFGAEMGBLPC(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.EMGNLNCPDGK(limitedInt.EPBLLBFINNA() - HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AF4 RID: 6900 RVA: 0x000D9DFE File Offset: 0x000D7FFE
	public int OIBHCOLMBIK()
	{
		return this.max;
	}

	// Token: 0x06001AF5 RID: 6901 RVA: 0x000DA19C File Offset: 0x000D839C
	public static LimitedInt JJCNKMLDNHB(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.GMCJBPEMPJB(limitedInt.OMDAIAGCNKF() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AF6 RID: 6902 RVA: 0x000D9D9A File Offset: 0x000D7F9A
	public int HBPEPMEKJDD()
	{
		return this.current;
	}

	// Token: 0x06001AF7 RID: 6903 RVA: 0x000DA1B2 File Offset: 0x000D83B2
	public static LimitedInt MHDGPGNBCBE(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.GMCJBPEMPJB(limitedInt.Current + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AF8 RID: 6904 RVA: 0x000D9DB8 File Offset: 0x000D7FB8
	public void GPPCLDFKHGH(int DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001AF9 RID: 6905 RVA: 0x000D9E32 File Offset: 0x000D8032
	public int DDGLNAEIMNE()
	{
		return this.min;
	}

	// Token: 0x06001AFA RID: 6906 RVA: 0x000DA1C8 File Offset: 0x000D83C8
	public static LimitedInt DFLKALJLCBP(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.CGOHGMLGLAN(limitedInt.LBOAJLGFMNK() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AFB RID: 6907 RVA: 0x000D9DB8 File Offset: 0x000D7FB8
	public void CIMFPALFHOG(int DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001AFC RID: 6908 RVA: 0x000DA1DE File Offset: 0x000D83DE
	public void LBOIFNOLJFL(int DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, -19);
	}

	// Token: 0x06001AFD RID: 6909 RVA: 0x000D9DFE File Offset: 0x000D7FFE
	public int OBJPFMNMMKN()
	{
		return this.max;
	}

	// Token: 0x06001AFE RID: 6910 RVA: 0x000DA1F7 File Offset: 0x000D83F7
	public static LimitedInt NMHFFDMJOFK(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.GMCJBPEMPJB(limitedInt.GPPMAJOBOJF() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001AFF RID: 6911 RVA: 0x000D9DFE File Offset: 0x000D7FFE
	public int MDECOBMHGPL()
	{
		return this.max;
	}

	// Token: 0x06001B00 RID: 6912 RVA: 0x000DA20D File Offset: 0x000D840D
	public static LimitedInt NLDOLNIOGIA(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.PEKHPLPBHND(limitedInt.HBPEPMEKJDD() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001B01 RID: 6913 RVA: 0x000D9D9A File Offset: 0x000D7F9A
	public int GPPMAJOBOJF()
	{
		return this.current;
	}

	// Token: 0x06001B02 RID: 6914 RVA: 0x000DA223 File Offset: 0x000D8423
	public static LimitedInt KLHMIGJEAML(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.CILJDFKGNCI(limitedInt.EPBLLBFINNA() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001B03 RID: 6915 RVA: 0x000DA239 File Offset: 0x000D8439
	public static LimitedInt DAFIPMFHEPB(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.PNGCAIDPPPE(limitedInt.LBOAJLGFMNK() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001B05 RID: 6917 RVA: 0x000DA24F File Offset: 0x000D844F
	public void BPDAMPCPEBK(int DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, -179);
	}

	// Token: 0x06001B06 RID: 6918 RVA: 0x000DA268 File Offset: 0x000D8468
	public static LimitedInt PKIDHCEJOBP(LimitedInt ENNOJLMKNDH, int HLIOKHMFNBF)
	{
		LimitedInt limitedInt = new LimitedInt(ENNOJLMKNDH);
		limitedInt.OFKOPLPMDJD(limitedInt.EPBLLBFINNA() + HLIOKHMFNBF);
		return limitedInt;
	}

	// Token: 0x06001B07 RID: 6919 RVA: 0x000DA27E File Offset: 0x000D847E
	public void DDMGBEPONJF(int DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, 89);
	}

	// Token: 0x06001B08 RID: 6920 RVA: 0x000DA297 File Offset: 0x000D8497
	public void IKMDPLGNBHI(int DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, 42);
	}

	// Token: 0x06001B09 RID: 6921 RVA: 0x000D9D91 File Offset: 0x000D7F91
	public void INECLJNFBPD(int DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001B0A RID: 6922 RVA: 0x000D9DFE File Offset: 0x000D7FFE
	public int KBPCFKKGJKN()
	{
		return this.max;
	}

	// Token: 0x06001B0B RID: 6923 RVA: 0x000D9D91 File Offset: 0x000D7F91
	public void MHLLPOFANGB(int DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001B0C RID: 6924 RVA: 0x000D9E32 File Offset: 0x000D8032
	public int MMDGAGCFHEA()
	{
		return this.min;
	}

	// Token: 0x06001B0D RID: 6925 RVA: 0x000DA2B0 File Offset: 0x000D84B0
	public void PPBNHCLDFIP(int DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, 144);
	}

	// Token: 0x06001B0F RID: 6927 RVA: 0x000D9DB8 File Offset: 0x000D7FB8
	public void CILJDFKGNCI(int DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001B10 RID: 6928 RVA: 0x000D9DB8 File Offset: 0x000D7FB8
	public void JJBIBIGGAIB(int DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x040002D5 RID: 725
	[SerializeField]
	private int min;

	// Token: 0x040002D6 RID: 726
	[SerializeField]
	private int max;

	// Token: 0x040002D7 RID: 727
	[SerializeField]
	private int current;
}
