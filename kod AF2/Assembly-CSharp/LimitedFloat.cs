using System;
using UnityEngine;

// Token: 0x02000072 RID: 114
[Serializable]
public class LimitedFloat
{
	// Token: 0x06001B11 RID: 6929 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float JCMFHHFMJIB()
	{
		return this.current;
	}

	// Token: 0x06001B12 RID: 6930 RVA: 0x000DA2D1 File Offset: 0x000D84D1
	public void ADCGNGNICEP(float DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, 748f);
	}

	// Token: 0x06001B13 RID: 6931 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float AFPKBHEEHLN()
	{
		return this.max;
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06001B7B RID: 7035 RVA: 0x000DA327 File Offset: 0x000D8527
	// (set) Token: 0x06001B14 RID: 6932 RVA: 0x000DA2F2 File Offset: 0x000D84F2
	public float Min
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

	// Token: 0x06001B15 RID: 6933 RVA: 0x000DA2FB File Offset: 0x000D84FB
	public static LimitedFloat DHONLBCFNBH(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.IMNBMKCEOIL(limitedFloat.OMCDHLDNEPH() + HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B16 RID: 6934 RVA: 0x000DA2F2 File Offset: 0x000D84F2
	public void AMFNGMIAAFG(float DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001B17 RID: 6935 RVA: 0x000DA311 File Offset: 0x000D8511
	public static LimitedFloat PHJBKOAGOMJ(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.FFDNHKNKPOD(limitedFloat.HBPEPMEKJDD() + HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B18 RID: 6936 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float LNBKHJOHKAH()
	{
		return this.max;
	}

	// Token: 0x06001B19 RID: 6937 RVA: 0x000DA327 File Offset: 0x000D8527
	public float EMMEFDNMMMN()
	{
		return this.min;
	}

	// Token: 0x06001B1A RID: 6938 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float JGCCBADKEFK()
	{
		return this.max;
	}

	// Token: 0x06001B1B RID: 6939 RVA: 0x000DA32F File Offset: 0x000D852F
	public static LimitedFloat PANGFJNOJHB(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.Current = limitedFloat.FMCJBLHPHBP() + HLIOKHMFNBF;
		return limitedFloat;
	}

	// Token: 0x06001B1C RID: 6940 RVA: 0x000DA345 File Offset: 0x000D8545
	public void KKFALBIOOJJ(float DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001B1D RID: 6941 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float MLEDHKJKEMF()
	{
		return this.max;
	}

	// Token: 0x06001B1E RID: 6942 RVA: 0x000DA327 File Offset: 0x000D8527
	public float HCPKDAFBPEO()
	{
		return this.min;
	}

	// Token: 0x06001B1F RID: 6943 RVA: 0x000DA345 File Offset: 0x000D8545
	public void KLEEGGGAEEE(float DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001B20 RID: 6944 RVA: 0x000DA2F2 File Offset: 0x000D84F2
	public void OEHIEJDGLIF(float DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001B21 RID: 6945 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float PCHNEHMDELC()
	{
		return this.max;
	}

	// Token: 0x06001B22 RID: 6946 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float NEBLGNEHPJM()
	{
		return this.current;
	}

	// Token: 0x06001B23 RID: 6947 RVA: 0x000DA35F File Offset: 0x000D855F
	public static LimitedFloat MDFCFJBLFCG(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.IBMGLOJCIGJ(limitedFloat.NEBLGNEHPJM() - HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B24 RID: 6948 RVA: 0x000DA375 File Offset: 0x000D8575
	public static LimitedFloat PPDKHJMCGGA(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.DOOMDGLAGCN(limitedFloat.JCMFHHFMJIB() + HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B25 RID: 6949 RVA: 0x000DA38B File Offset: 0x000D858B
	public static LimitedFloat NOEBNLKGCFJ(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.KKFALBIOOJJ(limitedFloat.Current - HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B26 RID: 6950 RVA: 0x000DA3A1 File Offset: 0x000D85A1
	public static LimitedFloat IPNFMFDDNMI(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.KKFALBIOOJJ(limitedFloat.BJNDMOLGJNA() + HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B27 RID: 6951 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float IOMBICHHJBK()
	{
		return this.max;
	}

	// Token: 0x06001B28 RID: 6952 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float HBPEPMEKJDD()
	{
		return this.current;
	}

	// Token: 0x06001B29 RID: 6953 RVA: 0x000DA2F2 File Offset: 0x000D84F2
	public void GFBGACHLNFO(float DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001B2A RID: 6954 RVA: 0x000DA3B7 File Offset: 0x000D85B7
	public static LimitedFloat HHBIOJODHLD(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.EDMLIOGJLEM(limitedFloat.NKIKBNHIIKO() - HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B2B RID: 6955 RVA: 0x000DA3CD File Offset: 0x000D85CD
	public static LimitedFloat KEBCMGFFPOO(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.MCPEMEOFDII(limitedFloat.HBPEPMEKJDD() + HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B2C RID: 6956 RVA: 0x000DA327 File Offset: 0x000D8527
	public float NKFJCKEEAOC()
	{
		return this.min;
	}

	// Token: 0x06001B2D RID: 6957 RVA: 0x000DA345 File Offset: 0x000D8545
	public void ABFCDENEGME(float DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001B2E RID: 6958 RVA: 0x000DA2F2 File Offset: 0x000D84F2
	public void CPCICPNNFEN(float DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001B2F RID: 6959 RVA: 0x000DA327 File Offset: 0x000D8527
	public float CHIANHCGLAO()
	{
		return this.min;
	}

	// Token: 0x06001B30 RID: 6960 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float OLFFHPACJJJ()
	{
		return this.current;
	}

	// Token: 0x06001B31 RID: 6961 RVA: 0x000DA327 File Offset: 0x000D8527
	public float LPGCNOKKAJN()
	{
		return this.min;
	}

	// Token: 0x06001B32 RID: 6962 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float JLMHNAEGMBF()
	{
		return this.max;
	}

	// Token: 0x06001B33 RID: 6963 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float KPKPGMDHMPJ()
	{
		return this.max;
	}

	// Token: 0x06001B34 RID: 6964 RVA: 0x000DA3E3 File Offset: 0x000D85E3
	public void EBPPPAJHMCP(float DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, 834f);
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x06001B52 RID: 6994 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	// (set) Token: 0x06001B35 RID: 6965 RVA: 0x000DA345 File Offset: 0x000D8545
	public float Current
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

	// Token: 0x06001B36 RID: 6966 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float PHEOPDHKEMB()
	{
		return this.max;
	}

	// Token: 0x06001B37 RID: 6967 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float GINAJPEPIDD()
	{
		return this.max;
	}

	// Token: 0x06001B38 RID: 6968 RVA: 0x000DA3FC File Offset: 0x000D85FC
	public LimitedFloat(float MHBLMMENIGB, float CAOOPCFAONF, float BAPBEBJMMPH)
	{
		this.current = MHBLMMENIGB;
		this.min = CAOOPCFAONF;
		this.max = BAPBEBJMMPH;
	}

	// Token: 0x06001B39 RID: 6969 RVA: 0x000DA419 File Offset: 0x000D8619
	public void MCLLABCCGKM(float DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, 240f);
	}

	// Token: 0x06001B3A RID: 6970 RVA: 0x000DA432 File Offset: 0x000D8632
	public void AIEGCNFLDAJ(float DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, 706f);
	}

	// Token: 0x06001B3B RID: 6971 RVA: 0x000DA327 File Offset: 0x000D8527
	public float GNJAFPGOCGG()
	{
		return this.min;
	}

	// Token: 0x06001B3C RID: 6972 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float FMCJBLHPHBP()
	{
		return this.current;
	}

	// Token: 0x06001B3D RID: 6973 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float POPEGNFMPLG()
	{
		return this.max;
	}

	// Token: 0x06001B3E RID: 6974 RVA: 0x000DA345 File Offset: 0x000D8545
	public void FFDNHKNKPOD(float DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001B3F RID: 6975 RVA: 0x000DA44B File Offset: 0x000D864B
	public void ODJCIBFOCPA(float DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, 1253f);
	}

	// Token: 0x06001B40 RID: 6976 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float LHMOFMNHPIO()
	{
		return this.current;
	}

	// Token: 0x06001B41 RID: 6977 RVA: 0x000DA464 File Offset: 0x000D8664
	public static LimitedFloat NEHNIBGKOEL(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.KKFALBIOOJJ(limitedFloat.NKIKBNHIIKO() + HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B42 RID: 6978 RVA: 0x000DA47A File Offset: 0x000D867A
	public static LimitedFloat FFEFNICOJLI(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.MCPEMEOFDII(limitedFloat.OLFFHPACJJJ() + HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B43 RID: 6979 RVA: 0x000DA490 File Offset: 0x000D8690
	public static LimitedFloat MHCLPDCMLLI(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.Current = limitedFloat.NEBLGNEHPJM() - HLIOKHMFNBF;
		return limitedFloat;
	}

	// Token: 0x06001B44 RID: 6980 RVA: 0x000DA2F2 File Offset: 0x000D84F2
	public void GJBKLAFAHEM(float DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001B45 RID: 6981 RVA: 0x000DA4A6 File Offset: 0x000D86A6
	public static LimitedFloat KFFDMIFJFFE(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.IBMGLOJCIGJ(limitedFloat.NEBLGNEHPJM() + HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B46 RID: 6982 RVA: 0x000DA2F2 File Offset: 0x000D84F2
	public void NJPDEOJDNGB(float DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001B47 RID: 6983 RVA: 0x000DA345 File Offset: 0x000D8545
	public void KDEHBMAEACA(float DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001B48 RID: 6984 RVA: 0x000DA345 File Offset: 0x000D8545
	public void DOOMDGLAGCN(float DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001B49 RID: 6985 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float CDBNGBMDENK()
	{
		return this.max;
	}

	// Token: 0x06001B4A RID: 6986 RVA: 0x000DA2F2 File Offset: 0x000D84F2
	public void JMONIOOIKGN(float DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001B4B RID: 6987 RVA: 0x000DA345 File Offset: 0x000D8545
	public void GHKABOAKGJK(float DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001B4C RID: 6988 RVA: 0x000DA2F2 File Offset: 0x000D84F2
	public void CEJLIMGPPJM(float DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001B4D RID: 6989 RVA: 0x000DA327 File Offset: 0x000D8527
	public float NDLBIIJJOFL()
	{
		return this.min;
	}

	// Token: 0x06001B4E RID: 6990 RVA: 0x000DA345 File Offset: 0x000D8545
	public void IMNBMKCEOIL(float DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001B4F RID: 6991 RVA: 0x000DA327 File Offset: 0x000D8527
	public float KEFPKHLADAE()
	{
		return this.min;
	}

	// Token: 0x06001B50 RID: 6992 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float LJHJPNOMCPL()
	{
		return this.max;
	}

	// Token: 0x06001B51 RID: 6993 RVA: 0x000DA345 File Offset: 0x000D8545
	public void IBMGLOJCIGJ(float DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001B53 RID: 6995 RVA: 0x000DA35F File Offset: 0x000D855F
	public static LimitedFloat DECLHFOBJMA(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.IBMGLOJCIGJ(limitedFloat.NEBLGNEHPJM() - HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B54 RID: 6996 RVA: 0x000DA4BC File Offset: 0x000D86BC
	public static LimitedFloat ENIDOGLMMHH(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.CPAKCAAONHG(limitedFloat.FMCJBLHPHBP() - HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B55 RID: 6997 RVA: 0x000DA4D2 File Offset: 0x000D86D2
	public static LimitedFloat HMGOCBLALME(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.GHKABOAKGJK(limitedFloat.NKIKBNHIIKO() + HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B56 RID: 6998 RVA: 0x000DA2F2 File Offset: 0x000D84F2
	public void KOECEDFHJMD(float DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001B57 RID: 6999 RVA: 0x000DA327 File Offset: 0x000D8527
	public float JBOBKMKOCNC()
	{
		return this.min;
	}

	// Token: 0x06001B58 RID: 7000 RVA: 0x000DA4E8 File Offset: 0x000D86E8
	public static LimitedFloat OPAFEKPDFIF(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.MCPEMEOFDII(limitedFloat.DHCDFKBDAHK() + HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B59 RID: 7001 RVA: 0x000DA4FE File Offset: 0x000D86FE
	public static LimitedFloat IFCPDJILAGA(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.LKFHMIEEGIA(limitedFloat.KCHLJMBAKGN() - HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B5A RID: 7002 RVA: 0x000DA514 File Offset: 0x000D8714
	public void NIOLCFMJDON(float DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, 272f);
	}

	// Token: 0x06001B5B RID: 7003 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float GLIFOKICNOL()
	{
		return this.max;
	}

	// Token: 0x06001B5C RID: 7004 RVA: 0x000DA345 File Offset: 0x000D8545
	public void CPAKCAAONHG(float DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001B5D RID: 7005 RVA: 0x000DA52D File Offset: 0x000D872D
	public static LimitedFloat MDPAMKBEINI(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.Current = limitedFloat.EDMNDMIKANP() - HLIOKHMFNBF;
		return limitedFloat;
	}

	// Token: 0x06001B5E RID: 7006 RVA: 0x000DA327 File Offset: 0x000D8527
	public float FIEOGIPCPLO()
	{
		return this.min;
	}

	// Token: 0x06001B5F RID: 7007 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float OMDAIAGCNKF()
	{
		return this.current;
	}

	// Token: 0x06001B60 RID: 7008 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float GHNDMHJJIMC()
	{
		return this.max;
	}

	// Token: 0x06001B61 RID: 7009 RVA: 0x000DA543 File Offset: 0x000D8743
	public void IPOOPFKGMOM(float DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, 1981f);
	}

	// Token: 0x06001B62 RID: 7010 RVA: 0x000DA55C File Offset: 0x000D875C
	public static LimitedFloat PEEJGBCHHJF(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.HCAIDDGOKGB(limitedFloat.LHMOFMNHPIO() + HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B63 RID: 7011 RVA: 0x000DA572 File Offset: 0x000D8772
	public static LimitedFloat FFLMLHHGNGA(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.FFDNHKNKPOD(limitedFloat.OMDAIAGCNKF() - HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B64 RID: 7012 RVA: 0x000DA588 File Offset: 0x000D8788
	public static LimitedFloat HCJPMCINIKN(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.KDEHBMAEACA(limitedFloat.DLOLDDMKADB() - HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B65 RID: 7013 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float DBGEIBGONDK()
	{
		return this.current;
	}

	// Token: 0x06001B66 RID: 7014 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float ELOJFGGLAPD()
	{
		return this.max;
	}

	// Token: 0x06001B67 RID: 7015 RVA: 0x000DA59E File Offset: 0x000D879E
	public static LimitedFloat OENOGMKEKPA(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.FFDNHKNKPOD(limitedFloat.KCHLJMBAKGN() + HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B68 RID: 7016 RVA: 0x000DA5B4 File Offset: 0x000D87B4
	public static LimitedFloat GIIBOGDAPNF(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.GHKABOAKGJK(limitedFloat.OLFFHPACJJJ() + HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B69 RID: 7017 RVA: 0x000DA345 File Offset: 0x000D8545
	public void CGOHGMLGLAN(float DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001B6A RID: 7018 RVA: 0x000DA5CA File Offset: 0x000D87CA
	public void IDJCFNCMLHE(float DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, 523f);
	}

	// Token: 0x06001B6B RID: 7019 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float NKIKBNHIIKO()
	{
		return this.current;
	}

	// Token: 0x06001B6C RID: 7020 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float KJKIACGLAPN()
	{
		return this.max;
	}

	// Token: 0x06001B6D RID: 7021 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float BFIDOBDAGDG()
	{
		return this.current;
	}

	// Token: 0x06001B6E RID: 7022 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float OMCEHEBAOLP()
	{
		return this.max;
	}

	// Token: 0x06001B6F RID: 7023 RVA: 0x000DA5E3 File Offset: 0x000D87E3
	public static LimitedFloat DIPDDIHNEBG(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.FFDNHKNKPOD(limitedFloat.JCMFHHFMJIB() - HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B70 RID: 7024 RVA: 0x000DA5F9 File Offset: 0x000D87F9
	public static LimitedFloat NJDDEOHIGBJ(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.FFDNHKNKPOD(limitedFloat.NEBLGNEHPJM() - HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B71 RID: 7025 RVA: 0x000DA345 File Offset: 0x000D8545
	public void MCPEMEOFDII(float DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001B72 RID: 7026 RVA: 0x000DA327 File Offset: 0x000D8527
	public float NGMBNGABAMH()
	{
		return this.min;
	}

	// Token: 0x06001B73 RID: 7027 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float EDMNDMIKANP()
	{
		return this.current;
	}

	// Token: 0x06001B74 RID: 7028 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float BFHLJGBNKBJ()
	{
		return this.current;
	}

	// Token: 0x06001B75 RID: 7029 RVA: 0x000DA327 File Offset: 0x000D8527
	public float BGLNJICEOFJ()
	{
		return this.min;
	}

	// Token: 0x06001B76 RID: 7030 RVA: 0x000DA60F File Offset: 0x000D880F
	public static LimitedFloat NGNHFNGPLBM(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.HCAIDDGOKGB(limitedFloat.LHMOFMNHPIO() - HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B77 RID: 7031 RVA: 0x000DA327 File Offset: 0x000D8527
	public float NINDDKAJGGG()
	{
		return this.min;
	}

	// Token: 0x06001B78 RID: 7032 RVA: 0x000DA625 File Offset: 0x000D8825
	public static LimitedFloat FCLPLJGMPJC(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.KLEEGGGAEEE(limitedFloat.OMCDHLDNEPH() - HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B79 RID: 7033 RVA: 0x000DA63B File Offset: 0x000D883B
	public void PNCGBNCPMEC(float DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, 1042f);
	}

	// Token: 0x06001B7A RID: 7034 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float DHCDFKBDAHK()
	{
		return this.current;
	}

	// Token: 0x06001B7C RID: 7036 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float BDIMHJOCLLB()
	{
		return this.max;
	}

	// Token: 0x06001B7D RID: 7037 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float NEIBBMIODCH()
	{
		return this.max;
	}

	// Token: 0x06001B7E RID: 7038 RVA: 0x000DA654 File Offset: 0x000D8854
	public static LimitedFloat PICCFFHAMAG(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.Current += HLIOKHMFNBF;
		return limitedFloat;
	}

	// Token: 0x06001B7F RID: 7039 RVA: 0x000DA327 File Offset: 0x000D8527
	public float BFMMPNAPDAD()
	{
		return this.min;
	}

	// Token: 0x06001B80 RID: 7040 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float BJNDMOLGJNA()
	{
		return this.current;
	}

	// Token: 0x06001B81 RID: 7041 RVA: 0x000DA327 File Offset: 0x000D8527
	public float FNJFPDELEPE()
	{
		return this.min;
	}

	// Token: 0x06001B82 RID: 7042 RVA: 0x000DA66A File Offset: 0x000D886A
	public void MKELFIJKPMG(float DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, 1875f);
	}

	// Token: 0x06001B83 RID: 7043 RVA: 0x000DA683 File Offset: 0x000D8883
	public static LimitedFloat GGEEKDPOOHM(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.FFDNHKNKPOD(limitedFloat.JCMFHHFMJIB() + HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B84 RID: 7044 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float HLAJCFGBDJF()
	{
		return this.max;
	}

	// Token: 0x06001B85 RID: 7045 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float OLOIIBNKHBG()
	{
		return this.max;
	}

	// Token: 0x06001B86 RID: 7046 RVA: 0x000DA345 File Offset: 0x000D8545
	public void EDMLIOGJLEM(float DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001B87 RID: 7047 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float KCHLJMBAKGN()
	{
		return this.current;
	}

	// Token: 0x06001B88 RID: 7048 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float DLOLDDMKADB()
	{
		return this.current;
	}

	// Token: 0x06001B89 RID: 7049 RVA: 0x000DA699 File Offset: 0x000D8899
	public static LimitedFloat CNNDJNHABEC(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.KDEHBMAEACA(limitedFloat.NKIKBNHIIKO() + HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B8A RID: 7050 RVA: 0x000DA6AF File Offset: 0x000D88AF
	public static LimitedFloat PPBHEODICFA(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.Current -= HLIOKHMFNBF;
		return limitedFloat;
	}

	// Token: 0x06001B8B RID: 7051 RVA: 0x000DA327 File Offset: 0x000D8527
	public float BBAENAIBPKP()
	{
		return this.min;
	}

	// Token: 0x06001B8C RID: 7052 RVA: 0x000DA6C5 File Offset: 0x000D88C5
	public LimitedFloat(LimitedFloat OENOOLNHAMK)
	{
		this.min = OENOOLNHAMK.Min;
		this.max = OENOOLNHAMK.Max;
		this.current = OENOOLNHAMK.Current;
	}

	// Token: 0x06001B8D RID: 7053 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float OMCDHLDNEPH()
	{
		return this.current;
	}

	// Token: 0x06001B8E RID: 7054 RVA: 0x000DA2F2 File Offset: 0x000D84F2
	public void EOGKNGOKAAC(float DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06001B8F RID: 7055 RVA: 0x000DA2EA File Offset: 0x000D84EA
	// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x000DA771 File Offset: 0x000D8971
	public float Max
	{
		get
		{
			return this.max;
		}
		set
		{
			this.max = Mathf.Clamp(value, this.min, float.MaxValue);
		}
	}

	// Token: 0x06001B90 RID: 7056 RVA: 0x000DA345 File Offset: 0x000D8545
	public void HCAIDDGOKGB(float DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001B91 RID: 7057 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float KJIOCBKLBFH()
	{
		return this.current;
	}

	// Token: 0x06001B92 RID: 7058 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float DMDNKKHGFMP()
	{
		return this.max;
	}

	// Token: 0x06001B93 RID: 7059 RVA: 0x000DA6F1 File Offset: 0x000D88F1
	public static LimitedFloat KKMPCBKOOCD(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.KDEHBMAEACA(limitedFloat.OBAMOPADEGG() + HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B94 RID: 7060 RVA: 0x000DA707 File Offset: 0x000D8907
	public void LINJIHMADJL(float DCCPCBLODIG)
	{
		this.max = Mathf.Clamp(DCCPCBLODIG, this.min, 449f);
	}

	// Token: 0x06001B95 RID: 7061 RVA: 0x000DA2F2 File Offset: 0x000D84F2
	public void PKFDAKKANCD(float DCCPCBLODIG)
	{
		this.min = DCCPCBLODIG;
	}

	// Token: 0x06001B96 RID: 7062 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float BCLADJLJJJM()
	{
		return this.max;
	}

	// Token: 0x06001B97 RID: 7063 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float BCAKLMAJEGE()
	{
		return this.max;
	}

	// Token: 0x06001B98 RID: 7064 RVA: 0x000DA720 File Offset: 0x000D8920
	public static LimitedFloat FPEHEFFMHPM(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.CGOHGMLGLAN(limitedFloat.DLOLDDMKADB() - HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x06001B99 RID: 7065 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float PMMDAODEJLP()
	{
		return this.max;
	}

	// Token: 0x06001B9A RID: 7066 RVA: 0x000DA345 File Offset: 0x000D8545
	public void LKFHMIEEGIA(float DCCPCBLODIG)
	{
		this.current = Mathf.Clamp(DCCPCBLODIG, this.min, this.max);
	}

	// Token: 0x06001B9B RID: 7067 RVA: 0x000DA736 File Offset: 0x000D8936
	public LimitedFloat(float MHBLMMENIGB)
	{
		this.current = MHBLMMENIGB;
		this.min = float.MinValue;
		this.max = float.MaxValue;
	}

	// Token: 0x06001B9C RID: 7068 RVA: 0x000DA2C9 File Offset: 0x000D84C9
	public float OBAMOPADEGG()
	{
		return this.current;
	}

	// Token: 0x06001B9D RID: 7069 RVA: 0x000DA327 File Offset: 0x000D8527
	public float INJEFLLKEGM()
	{
		return this.min;
	}

	// Token: 0x06001B9E RID: 7070 RVA: 0x000DA327 File Offset: 0x000D8527
	public float MMGFPKMOEGI()
	{
		return this.min;
	}

	// Token: 0x06001B9F RID: 7071 RVA: 0x000DA2EA File Offset: 0x000D84EA
	public float PNALMBFDNOA()
	{
		return this.max;
	}

	// Token: 0x06001BA0 RID: 7072 RVA: 0x000DA75B File Offset: 0x000D895B
	public static LimitedFloat DCFPFAENNCC(LimitedFloat ENNOJLMKNDH, float HLIOKHMFNBF)
	{
		LimitedFloat limitedFloat = new LimitedFloat(ENNOJLMKNDH);
		limitedFloat.KLEEGGGAEEE(limitedFloat.OMDAIAGCNKF() + HLIOKHMFNBF);
		return limitedFloat;
	}

	// Token: 0x040002D8 RID: 728
	[SerializeField]
	private float min;

	// Token: 0x040002D9 RID: 729
	[SerializeField]
	private float max;

	// Token: 0x040002DA RID: 730
	[SerializeField]
	private float current;
}
