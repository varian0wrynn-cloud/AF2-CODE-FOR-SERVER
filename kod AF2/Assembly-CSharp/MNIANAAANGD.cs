using System;
using System.Collections.Generic;

// Token: 0x020004F2 RID: 1266
public struct MNIANAAANGD : IEquatable<MNIANAAANGD>
{
	// Token: 0x06010F5A RID: 69466 RVA: 0x007942D0 File Offset: 0x007924D0
	public static List<int> IHEPDJELJAA(IEnumerable<MNIANAAANGD> LCEPHOMDPLF)
	{
		List<int> list = new List<int>();
		foreach (MNIANAAANGD mnianaaangd in LCEPHOMDPLF)
		{
			list.Add(mnianaaangd.CBJECKNHHKM.OCNGPCPMCPM);
			list.Add(mnianaaangd.CBJECKNHHKM.ADMFAEOOOHD);
		}
		return list;
	}

	// Token: 0x06010F5B RID: 69467 RVA: 0x0079433C File Offset: 0x0079253C
	public MNIANAAANGD(int KMDPNAHABDM, int OAPEEJPJOCH, int PKHCHJPMCBP, int BFCKJGBNIBN)
	{
		this.CBJECKNHHKM = new JAFKHEFNPML(KMDPNAHABDM, OAPEEJPJOCH);
		this.NJEHCCKLOLC = new JAFKHEFNPML(PKHCHJPMCBP, BFCKJGBNIBN);
	}

	// Token: 0x06010F5C RID: 69468 RVA: 0x00794359 File Offset: 0x00792559
	public int NBDJPCPAFGN()
	{
		return this.NJEHCCKLOLC.GetHashCode();
	}

	// Token: 0x06010F5D RID: 69469 RVA: 0x00794359 File Offset: 0x00792559
	public override int GetHashCode()
	{
		return this.NJEHCCKLOLC.GetHashCode();
	}

	// Token: 0x06010F5E RID: 69470 RVA: 0x0079436C File Offset: 0x0079256C
	public bool AFDHOIDFLJA(object HHAGIHEGFML)
	{
		return HHAGIHEGFML is MNIANAAANGD && this.NJEHCCKLOLC.MNIIEEGNAMN(((MNIANAAANGD)HHAGIHEGFML).NJEHCCKLOLC);
	}

	// Token: 0x06010F5F RID: 69471 RVA: 0x00794390 File Offset: 0x00792590
	public override string ToString()
	{
		return string.Format("{{ {{{0}:{1}}}, {{{2}:{3}}} }}", new object[]
		{
			this.CBJECKNHHKM.OCNGPCPMCPM,
			this.NJEHCCKLOLC.OCNGPCPMCPM,
			this.CBJECKNHHKM.ADMFAEOOOHD,
			this.NJEHCCKLOLC.ADMFAEOOOHD
		});
	}

	// Token: 0x06010F60 RID: 69472 RVA: 0x007943FC File Offset: 0x007925FC
	public static HashSet<int> GPOEJBENBKD(IEnumerable<MNIANAAANGD> LCEPHOMDPLF)
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (MNIANAAANGD mnianaaangd in LCEPHOMDPLF)
		{
			hashSet.Add(mnianaaangd.CBJECKNHHKM.OCNGPCPMCPM);
			hashSet.Add(mnianaaangd.CBJECKNHHKM.ADMFAEOOOHD);
		}
		return hashSet;
	}

	// Token: 0x06010F61 RID: 69473 RVA: 0x00794468 File Offset: 0x00792668
	public bool Equals(MNIANAAANGD HHAGIHEGFML)
	{
		return this.NJEHCCKLOLC.Equals(HHAGIHEGFML.NJEHCCKLOLC);
	}

	// Token: 0x06010F62 RID: 69474 RVA: 0x0079447B File Offset: 0x0079267B
	public int HNEPEIBPMML()
	{
		return this.NJEHCCKLOLC.ADMFAEOOOHD;
	}

	// Token: 0x06010F63 RID: 69475 RVA: 0x00794488 File Offset: 0x00792688
	public static bool KOMOINKIEPL(MNIANAAANGD EGABJKIFAON, MNIANAAANGD HHAGIHEGFML)
	{
		return !EGABJKIFAON.DFEOCFMHLHO(HHAGIHEGFML);
	}

	// Token: 0x06010F64 RID: 69476 RVA: 0x00794498 File Offset: 0x00792698
	public static List<int> DDIDCHFJICP(IEnumerable<MNIANAAANGD> LCEPHOMDPLF)
	{
		List<int> list = new List<int>();
		foreach (MNIANAAANGD mnianaaangd in LCEPHOMDPLF)
		{
			list.Add(mnianaaangd.CBJECKNHHKM.OCNGPCPMCPM);
			list.Add(mnianaaangd.CBJECKNHHKM.ADMFAEOOOHD);
		}
		return list;
	}

	// Token: 0x06010F65 RID: 69477 RVA: 0x00794504 File Offset: 0x00792704
	public static bool HCPCMFIIJAM(MNIANAAANGD EGABJKIFAON, MNIANAAANGD HHAGIHEGFML)
	{
		return EGABJKIFAON.MJDHBHHGMKC(HHAGIHEGFML);
	}

	// Token: 0x06010F66 RID: 69478 RVA: 0x00794359 File Offset: 0x00792559
	public int IFFMNFIJMPM()
	{
		return this.NJEHCCKLOLC.GetHashCode();
	}

	// Token: 0x170003B4 RID: 948
	// (get) Token: 0x06010F67 RID: 69479 RVA: 0x00794511 File Offset: 0x00792711
	public int ADMFAEOOOHD
	{
		get
		{
			return this.CBJECKNHHKM.ADMFAEOOOHD;
		}
	}

	// Token: 0x06010F68 RID: 69480 RVA: 0x0079451E File Offset: 0x0079271E
	public static bool IJAKFMPBLEM(MNIANAAANGD EGABJKIFAON, MNIANAAANGD HHAGIHEGFML)
	{
		return EGABJKIFAON.DFEOCFMHLHO(HHAGIHEGFML);
	}

	// Token: 0x06010F69 RID: 69481 RVA: 0x0079452B File Offset: 0x0079272B
	public static bool BAKPLODMMOJ(MNIANAAANGD EGABJKIFAON, MNIANAAANGD HHAGIHEGFML)
	{
		return EGABJKIFAON.Equals(HHAGIHEGFML);
	}

	// Token: 0x06010F6A RID: 69482 RVA: 0x00794535 File Offset: 0x00792735
	public bool BOAENGKCGND(object HHAGIHEGFML)
	{
		return HHAGIHEGFML is MNIANAAANGD && this.NJEHCCKLOLC.JBMNLBEJJIC(((MNIANAAANGD)HHAGIHEGFML).NJEHCCKLOLC);
	}

	// Token: 0x06010F6B RID: 69483 RVA: 0x00794557 File Offset: 0x00792757
	public bool JMJAHECALNC(MNIANAAANGD HHAGIHEGFML)
	{
		return this.NJEHCCKLOLC.JBMNLBEJJIC(HHAGIHEGFML.NJEHCCKLOLC);
	}

	// Token: 0x06010F6C RID: 69484 RVA: 0x0079456C File Offset: 0x0079276C
	public static List<int> JCOACCENANG(IEnumerable<MNIANAAANGD> LCEPHOMDPLF)
	{
		List<int> list = new List<int>();
		foreach (MNIANAAANGD mnianaaangd in LCEPHOMDPLF)
		{
			list.Add(mnianaaangd.CBJECKNHHKM.OCNGPCPMCPM);
			list.Add(mnianaaangd.CBJECKNHHKM.ADMFAEOOOHD);
		}
		return list;
	}

	// Token: 0x06010F6D RID: 69485 RVA: 0x007945D8 File Offset: 0x007927D8
	public static bool DPBMFNDOKIC(MNIANAAANGD EGABJKIFAON, MNIANAAANGD HHAGIHEGFML)
	{
		return !EGABJKIFAON.JMJAHECALNC(HHAGIHEGFML);
	}

	// Token: 0x06010F6E RID: 69486 RVA: 0x007945E5 File Offset: 0x007927E5
	public bool DFEOCFMHLHO(MNIANAAANGD HHAGIHEGFML)
	{
		return this.NJEHCCKLOLC.FDGDDDMEOHJ(HHAGIHEGFML.NJEHCCKLOLC);
	}

	// Token: 0x06010F6F RID: 69487 RVA: 0x00794511 File Offset: 0x00792711
	public int JBBGHFJPKGK()
	{
		return this.CBJECKNHHKM.ADMFAEOOOHD;
	}

	// Token: 0x06010F70 RID: 69488 RVA: 0x007945F8 File Offset: 0x007927F8
	public static List<int> HPKJHNEIOLB(IEnumerable<MNIANAAANGD> LCEPHOMDPLF)
	{
		List<int> list = new List<int>();
		foreach (MNIANAAANGD mnianaaangd in LCEPHOMDPLF)
		{
			list.Add(mnianaaangd.CBJECKNHHKM.OCNGPCPMCPM);
			list.Add(mnianaaangd.CBJECKNHHKM.ADMFAEOOOHD);
		}
		return list;
	}

	// Token: 0x06010F71 RID: 69489 RVA: 0x00794664 File Offset: 0x00792864
	public int MJOMGKFNLMB()
	{
		return this.CBJECKNHHKM.OCNGPCPMCPM;
	}

	// Token: 0x06010F72 RID: 69490 RVA: 0x00794671 File Offset: 0x00792871
	public static bool DFIOHBFGBFK(MNIANAAANGD EGABJKIFAON, MNIANAAANGD HHAGIHEGFML)
	{
		return EGABJKIFAON.Equals(HHAGIHEGFML);
	}

	// Token: 0x06010F73 RID: 69491 RVA: 0x00794664 File Offset: 0x00792864
	public int PCHHKJHIHKM()
	{
		return this.CBJECKNHHKM.OCNGPCPMCPM;
	}

	// Token: 0x06010F74 RID: 69492 RVA: 0x0079452B File Offset: 0x0079272B
	public static bool FIMEAOKHJBF(MNIANAAANGD EGABJKIFAON, MNIANAAANGD HHAGIHEGFML)
	{
		return EGABJKIFAON.Equals(HHAGIHEGFML);
	}

	// Token: 0x06010F75 RID: 69493 RVA: 0x007945D8 File Offset: 0x007927D8
	public static bool IAEHBIOOKCB(MNIANAAANGD EGABJKIFAON, MNIANAAANGD HHAGIHEGFML)
	{
		return !EGABJKIFAON.JMJAHECALNC(HHAGIHEGFML);
	}

	// Token: 0x06010F76 RID: 69494 RVA: 0x00794359 File Offset: 0x00792559
	public int KGGHILHGNFN()
	{
		return this.NJEHCCKLOLC.GetHashCode();
	}

	// Token: 0x06010F77 RID: 69495 RVA: 0x0079447B File Offset: 0x0079267B
	public int JAAHJAHCPAP()
	{
		return this.NJEHCCKLOLC.ADMFAEOOOHD;
	}

	// Token: 0x06010F78 RID: 69496 RVA: 0x0079447B File Offset: 0x0079267B
	public int DAAKHNJKPLK()
	{
		return this.NJEHCCKLOLC.ADMFAEOOOHD;
	}

	// Token: 0x06010F79 RID: 69497 RVA: 0x00794680 File Offset: 0x00792880
	public static List<int> JCICKIJFBLO(IEnumerable<MNIANAAANGD> LCEPHOMDPLF)
	{
		List<int> list = new List<int>();
		foreach (MNIANAAANGD mnianaaangd in LCEPHOMDPLF)
		{
			list.Add(mnianaaangd.CBJECKNHHKM.OCNGPCPMCPM);
			list.Add(mnianaaangd.CBJECKNHHKM.ADMFAEOOOHD);
		}
		return list;
	}

	// Token: 0x170003B3 RID: 947
	// (get) Token: 0x06010F7A RID: 69498 RVA: 0x00794664 File Offset: 0x00792864
	public int OCNGPCPMCPM
	{
		get
		{
			return this.CBJECKNHHKM.OCNGPCPMCPM;
		}
	}

	// Token: 0x06010F7B RID: 69499 RVA: 0x007946EC File Offset: 0x007928EC
	public bool MJDHBHHGMKC(MNIANAAANGD HHAGIHEGFML)
	{
		return this.NJEHCCKLOLC.KLACFLACLDF(HHAGIHEGFML.NJEHCCKLOLC);
	}

	// Token: 0x06010F7C RID: 69500 RVA: 0x00794700 File Offset: 0x00792900
	public static List<int> IKCKGEELLGF(IEnumerable<MNIANAAANGD> LCEPHOMDPLF)
	{
		List<int> list = new List<int>();
		foreach (MNIANAAANGD mnianaaangd in LCEPHOMDPLF)
		{
			list.Add(mnianaaangd.CBJECKNHHKM.OCNGPCPMCPM);
			list.Add(mnianaaangd.CBJECKNHHKM.ADMFAEOOOHD);
		}
		return list;
	}

	// Token: 0x06010F7D RID: 69501 RVA: 0x00794664 File Offset: 0x00792864
	public int DJNOBLCKDFL()
	{
		return this.CBJECKNHHKM.OCNGPCPMCPM;
	}

	// Token: 0x170003B5 RID: 949
	// (get) Token: 0x06010F7E RID: 69502 RVA: 0x0079476C File Offset: 0x0079296C
	public int DEOHCNBLNPF
	{
		get
		{
			return this.NJEHCCKLOLC.OCNGPCPMCPM;
		}
	}

	// Token: 0x06010F7F RID: 69503 RVA: 0x00794779 File Offset: 0x00792979
	public override bool Equals(object HHAGIHEGFML)
	{
		return HHAGIHEGFML is MNIANAAANGD && this.NJEHCCKLOLC.Equals(((MNIANAAANGD)HHAGIHEGFML).NJEHCCKLOLC);
	}

	// Token: 0x06010F80 RID: 69504 RVA: 0x0079476C File Offset: 0x0079296C
	public int JMNNCAFOPPI()
	{
		return this.NJEHCCKLOLC.OCNGPCPMCPM;
	}

	// Token: 0x06010F81 RID: 69505 RVA: 0x0079479B File Offset: 0x0079299B
	public static bool HDFJOKAGNJC(MNIANAAANGD EGABJKIFAON, MNIANAAANGD HHAGIHEGFML)
	{
		return !EGABJKIFAON.Equals(HHAGIHEGFML);
	}

	// Token: 0x170003B6 RID: 950
	// (get) Token: 0x06010F82 RID: 69506 RVA: 0x0079447B File Offset: 0x0079267B
	public int LJDBKOIGCAK
	{
		get
		{
			return this.NJEHCCKLOLC.ADMFAEOOOHD;
		}
	}

	// Token: 0x06010F83 RID: 69507 RVA: 0x007947A8 File Offset: 0x007929A8
	public static HashSet<int> BBMDOODPHKD(IEnumerable<MNIANAAANGD> LCEPHOMDPLF)
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (MNIANAAANGD mnianaaangd in LCEPHOMDPLF)
		{
			hashSet.Add(mnianaaangd.CBJECKNHHKM.OCNGPCPMCPM);
			hashSet.Add(mnianaaangd.CBJECKNHHKM.ADMFAEOOOHD);
		}
		return hashSet;
	}

	// Token: 0x040023A9 RID: 9129
	public JAFKHEFNPML CBJECKNHHKM;

	// Token: 0x040023AA RID: 9130
	public JAFKHEFNPML NJEHCCKLOLC;
}
