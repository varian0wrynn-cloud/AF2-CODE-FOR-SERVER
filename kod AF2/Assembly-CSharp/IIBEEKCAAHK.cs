using System;
using System.Globalization;
using UnityEngine;

// Token: 0x0200027B RID: 635
public class IIBEEKCAAHK
{
	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x060093BA RID: 37818 RVA: 0x00420F0A File Offset: 0x0041F10A
	// (set) Token: 0x06009420 RID: 37920 RVA: 0x00421324 File Offset: 0x0041F524
	public double NKGGAFLBFDF { get; set; }

	// Token: 0x060093BB RID: 37819 RVA: 0x00420F12 File Offset: 0x0041F112
	public static IIBEEKCAAHK HBGADBDLHDP(IIBEEKCAAHK EGABJKIFAON, float HHAGIHEGFML)
	{
		return new IIBEEKCAAHK(EGABJKIFAON.DHJBAKDAMGH() * (double)HHAGIHEGFML, EGABJKIFAON.NMKCBJKHBOH * (double)HHAGIHEGFML, EGABJKIFAON.DBFOHFDOCIB() * (double)HHAGIHEGFML);
	}

	// Token: 0x060093BC RID: 37820 RVA: 0x00420F34 File Offset: 0x0041F134
	public static IIBEEKCAAHK NHIJGBPBLFC(IIBEEKCAAHK EGABJKIFAON, float HHAGIHEGFML)
	{
		return new IIBEEKCAAHK(EGABJKIFAON.LNEPKLKELMI * (double)HHAGIHEGFML, EGABJKIFAON.NMKCBJKHBOH * (double)HHAGIHEGFML, EGABJKIFAON.NKGGAFLBFDF * (double)HHAGIHEGFML);
	}

	// Token: 0x060093BD RID: 37821 RVA: 0x00420F56 File Offset: 0x0041F156
	public float EPPEFJDDOHN()
	{
		return (float)this.HDPNCIECLKP();
	}

	// Token: 0x060093BE RID: 37822 RVA: 0x00420F5F File Offset: 0x0041F15F
	public void CGLGAFHNJGK(double DCCPCBLODIG)
	{
		this.<JHIDDNMFLEF>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060093BF RID: 37823 RVA: 0x00420F68 File Offset: 0x0041F168
	public float CLAEAFMCDMP()
	{
		return (float)this.AIMCFAHLPEF();
	}

	// Token: 0x170001EB RID: 491
	// (get) Token: 0x060093C0 RID: 37824 RVA: 0x00420F71 File Offset: 0x0041F171
	public float PEMFLGJKEEO
	{
		get
		{
			return (float)this.DCACBECHFMA;
		}
	}

	// Token: 0x060093C1 RID: 37825 RVA: 0x00420F7A File Offset: 0x0041F17A
	public float LOIBCMBMLEC()
	{
		return (float)this.OIGIHEPJFFJ();
	}

	// Token: 0x060093C2 RID: 37826 RVA: 0x00420F83 File Offset: 0x0041F183
	public int KMGAHCANELI()
	{
		return Mathf.RoundToInt((float)this.OIGIHEPJFFJ());
	}

	// Token: 0x060093C3 RID: 37827 RVA: 0x00420F94 File Offset: 0x0041F194
	public IIBEEKCAAHK(double INHFGFEAENI, double HOLFAJCOIMC, double HMNHPDJABFG)
	{
		this.LNEPKLKELMI = INHFGFEAENI;
		this.NMKCBJKHBOH = HOLFAJCOIMC;
		this.NKGGAFLBFDF = HMNHPDJABFG;
		this.DCACBECHFMA = 0.0;
		this.MIJKHGIGELG = 0.0;
		this.ECDMPPDLHHH = 0.0;
	}

	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x060093C4 RID: 37828 RVA: 0x00420FE9 File Offset: 0x0041F1E9
	// (set) Token: 0x060093CB RID: 37835 RVA: 0x004210E4 File Offset: 0x0041F2E4
	public double MIJKHGIGELG { get; set; }

	// Token: 0x060093C5 RID: 37829 RVA: 0x00420FF1 File Offset: 0x0041F1F1
	public Vector2 KPEOIMBBDBE()
	{
		return new Vector2((float)this.LNEPKLKELMI, (float)this.NMKCBJKHBOH);
	}

	// Token: 0x060093C6 RID: 37830 RVA: 0x00421006 File Offset: 0x0041F206
	public int LAGCLCGBNLI()
	{
		return (int)((float)this.KMIOLLENCOL() * 947f + (float)this.ICJDPPOJINN * 1730f * 1359f + (float)this.CJKILDPJCFJ() * 255f * 1930f);
	}

	// Token: 0x060093C7 RID: 37831 RVA: 0x0042103E File Offset: 0x0041F23E
	public int MCJJCAFILPF()
	{
		return Mathf.RoundToInt((float)this.DCACBECHFMA);
	}

	// Token: 0x060093C8 RID: 37832 RVA: 0x0042104C File Offset: 0x0041F24C
	public virtual string EDBCGCIHHKA()
	{
		object[] array = new object[6];
		array[1] = this.DHJBAKDAMGH();
		array[0] = "AntaresController";
		array[2] = this.NMKCBJKHBOH;
		array[2] = " iterations for read and write";
		array[2] = this.FJACMDGJEBL();
		return string.Concat(array);
	}

	// Token: 0x060093C9 RID: 37833 RVA: 0x0042109E File Offset: 0x0041F29E
	public int MCHPKHHMKPG()
	{
		return (int)((float)this.IBEIBAHKIAH * 1601f + (float)this.KMGAHCANELI() * 1598f * 1763f + (float)this.NFCDJLJNDLO() * 1958f * 145f);
	}

	// Token: 0x060093CA RID: 37834 RVA: 0x004210D6 File Offset: 0x0041F2D6
	public int CJKILDPJCFJ()
	{
		return Mathf.RoundToInt((float)this.KCKFCPIHMPC());
	}

	// Token: 0x060093CC RID: 37836 RVA: 0x00420F56 File Offset: 0x0041F156
	public float GHEGIJFKEON()
	{
		return (float)this.HDPNCIECLKP();
	}

	// Token: 0x060093CD RID: 37837 RVA: 0x004210ED File Offset: 0x0041F2ED
	public float DOFNAOOCDDB()
	{
		return (float)this.NMKCBJKHBOH;
	}

	// Token: 0x060093CE RID: 37838 RVA: 0x00420F0A File Offset: 0x0041F10A
	public double DBFOHFDOCIB()
	{
		return this.<LBGPICLDAKM>k__BackingField;
	}

	// Token: 0x060093CF RID: 37839 RVA: 0x00420F56 File Offset: 0x0041F156
	public float NJJIBEJGLEJ()
	{
		return (float)this.HDPNCIECLKP();
	}

	// Token: 0x060093D0 RID: 37840 RVA: 0x004210F6 File Offset: 0x0041F2F6
	public int PKEBKANNBJD()
	{
		return Mathf.RoundToInt((float)this.DMHCNOBKPJK());
	}

	// Token: 0x060093D1 RID: 37841 RVA: 0x00420F0A File Offset: 0x0041F10A
	public double KCKFCPIHMPC()
	{
		return this.<LBGPICLDAKM>k__BackingField;
	}

	// Token: 0x060093D2 RID: 37842 RVA: 0x0042103E File Offset: 0x0041F23E
	public int PBMJIMLEHEC()
	{
		return Mathf.RoundToInt((float)this.DCACBECHFMA);
	}

	// Token: 0x170001EF RID: 495
	// (get) Token: 0x060093D3 RID: 37843 RVA: 0x00421104 File Offset: 0x0041F304
	public int ICJDPPOJINN
	{
		get
		{
			return Mathf.RoundToInt((float)this.NMKCBJKHBOH);
		}
	}

	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x06009434 RID: 37940 RVA: 0x004215CE File Offset: 0x0041F7CE
	// (set) Token: 0x060093D4 RID: 37844 RVA: 0x00420F5F File Offset: 0x0041F15F
	public double ECDMPPDLHHH { get; set; }

	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x060093D5 RID: 37845 RVA: 0x00421112 File Offset: 0x0041F312
	// (set) Token: 0x06009403 RID: 37891 RVA: 0x00421154 File Offset: 0x0041F354
	public double LNEPKLKELMI { get; set; }

	// Token: 0x060093D6 RID: 37846 RVA: 0x004210E4 File Offset: 0x0041F2E4
	public void NCNHNLBIDMN(double DCCPCBLODIG)
	{
		this.<JMBHILJIPCO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060093D7 RID: 37847 RVA: 0x00420F83 File Offset: 0x0041F183
	public int NLHKFMMDMMK()
	{
		return Mathf.RoundToInt((float)this.OIGIHEPJFFJ());
	}

	// Token: 0x060093D8 RID: 37848 RVA: 0x0042111A File Offset: 0x0041F31A
	public float EIHMJDCOOCC()
	{
		return (float)this.DHJBAKDAMGH();
	}

	// Token: 0x060093D9 RID: 37849 RVA: 0x00421123 File Offset: 0x0041F323
	public Vector2 PMNHDCNCDGL()
	{
		return new Vector2((float)this.LNEPKLKELMI, (float)this.OIGIHEPJFFJ());
	}

	// Token: 0x060093DA RID: 37850 RVA: 0x00421138 File Offset: 0x0041F338
	public int OAMPMLIIJPH()
	{
		return Mathf.RoundToInt((float)this.ANFBFHGCJND());
	}

	// Token: 0x060093DB RID: 37851 RVA: 0x00421146 File Offset: 0x0041F346
	public int KMIOLLENCOL()
	{
		return Mathf.RoundToInt((float)this.AIMCFAHLPEF());
	}

	// Token: 0x060093DC RID: 37852 RVA: 0x00421154 File Offset: 0x0041F354
	public void JLPFNMDEOGO(double DCCPCBLODIG)
	{
		this.<KLIIGPDIGAB>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060093DD RID: 37853 RVA: 0x0042115D File Offset: 0x0041F35D
	public static IIBEEKCAAHK INIHCDIMIKI(IIBEEKCAAHK EGABJKIFAON, float HHAGIHEGFML)
	{
		return new IIBEEKCAAHK(EGABJKIFAON.LNEPKLKELMI * (double)HHAGIHEGFML, EGABJKIFAON.NMKCBJKHBOH * (double)HHAGIHEGFML, EGABJKIFAON.DBFOHFDOCIB() * (double)HHAGIHEGFML);
	}

	// Token: 0x060093DE RID: 37854 RVA: 0x00421154 File Offset: 0x0041F354
	public void IECBGIDJHCL(double DCCPCBLODIG)
	{
		this.<KLIIGPDIGAB>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x0600942B RID: 37931 RVA: 0x00421398 File Offset: 0x0041F598
	// (set) Token: 0x060093DF RID: 37855 RVA: 0x0042117F File Offset: 0x0041F37F
	public double DCACBECHFMA { get; set; }

	// Token: 0x060093E0 RID: 37856 RVA: 0x004210F6 File Offset: 0x0041F2F6
	public int IEDJJIFACKA()
	{
		return Mathf.RoundToInt((float)this.DMHCNOBKPJK());
	}

	// Token: 0x060093E1 RID: 37857 RVA: 0x00420F5F File Offset: 0x0041F15F
	public void CJFCIFAJNJA(double DCCPCBLODIG)
	{
		this.<JHIDDNMFLEF>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060093E2 RID: 37858 RVA: 0x00420F5F File Offset: 0x0041F15F
	public void JKMBJCCIGHB(double DCCPCBLODIG)
	{
		this.<JHIDDNMFLEF>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060093E3 RID: 37859 RVA: 0x00421188 File Offset: 0x0041F388
	public virtual string DFHAGGBIEIH()
	{
		object[] array = new object[0];
		array[0] = this.AIMCFAHLPEF();
		array[0] = "autherror";
		array[2] = this.NMKCBJKHBOH;
		array[0] = "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_f_a_b_r_i_k.html";
		array[4] = this.DBFOHFDOCIB();
		return string.Concat(array);
	}

	// Token: 0x060093E4 RID: 37860 RVA: 0x004211DA File Offset: 0x0041F3DA
	public int JDHDFEHFNNG()
	{
		return (int)((float)this.IBEIBAHKIAH * 3.1415927f + (float)this.ICJDPPOJINN * 3.1415927f * 5f + (float)this.NODLBGKEGPM * 3.1415927f * 35f);
	}

	// Token: 0x060093E5 RID: 37861 RVA: 0x00421138 File Offset: 0x0041F338
	public int NAJIMILCPJK()
	{
		return Mathf.RoundToInt((float)this.ANFBFHGCJND());
	}

	// Token: 0x060093E6 RID: 37862 RVA: 0x00421212 File Offset: 0x0041F412
	public float HCHOAJADMPP()
	{
		return (float)this.ANFBFHGCJND();
	}

	// Token: 0x060093E7 RID: 37863 RVA: 0x0042121B File Offset: 0x0041F41B
	public float GCDNDOMHOBF()
	{
		return (float)this.DCPKBIDFKAE();
	}

	// Token: 0x060093E8 RID: 37864 RVA: 0x00421224 File Offset: 0x0041F424
	public int NFCDJLJNDLO()
	{
		return Mathf.RoundToInt((float)this.FJACMDGJEBL());
	}

	// Token: 0x060093E9 RID: 37865 RVA: 0x00421232 File Offset: 0x0041F432
	public bool DMPPOEAOIIC()
	{
		return this.DHJBAKDAMGH() != 966.0 || this.OIGIHEPJFFJ() != 229.0 || this.HDPNCIECLKP() == 1801.0;
	}

	// Token: 0x060093EA RID: 37866 RVA: 0x00421269 File Offset: 0x0041F469
	public static IIBEEKCAAHK EBAFBELBICP(IIBEEKCAAHK EGABJKIFAON, float HHAGIHEGFML)
	{
		return new IIBEEKCAAHK(EGABJKIFAON.DHJBAKDAMGH() * (double)HHAGIHEGFML, EGABJKIFAON.OIGIHEPJFFJ() * (double)HHAGIHEGFML, EGABJKIFAON.NKGGAFLBFDF * (double)HHAGIHEGFML);
	}

	// Token: 0x060093EB RID: 37867 RVA: 0x0042128B File Offset: 0x0041F48B
	public static IIBEEKCAAHK IMJHKMLHDJH()
	{
		return new IIBEEKCAAHK(1637.0, 984.0, 1172.0);
	}

	// Token: 0x060093EC RID: 37868 RVA: 0x004212B0 File Offset: 0x0041F4B0
	public virtual string OKJEDFNFDML()
	{
		object[] array = new object[1];
		array[1] = this.DHJBAKDAMGH();
		array[0] = "sunshine_OvercastVectorsUV";
		array[3] = this.OIGIHEPJFFJ();
		array[4] = "_ScreenEdgeFading";
		array[0] = this.FJACMDGJEBL();
		return string.Concat(array);
	}

	// Token: 0x060093ED RID: 37869 RVA: 0x00421302 File Offset: 0x0041F502
	public static IIBEEKCAAHK AHAHNPGIFEF(IIBEEKCAAHK EGABJKIFAON, float HHAGIHEGFML)
	{
		return new IIBEEKCAAHK(EGABJKIFAON.LNEPKLKELMI * (double)HHAGIHEGFML, EGABJKIFAON.OIGIHEPJFFJ() * (double)HHAGIHEGFML, EGABJKIFAON.NKGGAFLBFDF * (double)HHAGIHEGFML);
	}

	// Token: 0x060093EE RID: 37870 RVA: 0x00421324 File Offset: 0x0041F524
	public void MDJBNNGJAGH(double DCCPCBLODIG)
	{
		this.<LBGPICLDAKM>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060093EF RID: 37871 RVA: 0x00421112 File Offset: 0x0041F312
	public double DHJBAKDAMGH()
	{
		return this.<KLIIGPDIGAB>k__BackingField;
	}

	// Token: 0x060093F0 RID: 37872 RVA: 0x0042132D File Offset: 0x0041F52D
	public float MLOEJFMIAIP()
	{
		return (float)this.KCKFCPIHMPC();
	}

	// Token: 0x060093F1 RID: 37873 RVA: 0x0042117F File Offset: 0x0041F37F
	public void DLDDNHFAOFE(double DCCPCBLODIG)
	{
		this.<GPNJFCBOADP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x170001F2 RID: 498
	// (get) Token: 0x060093F2 RID: 37874 RVA: 0x00421336 File Offset: 0x0041F536
	public int BDGMCFEJNIO
	{
		get
		{
			return Mathf.RoundToInt((float)this.MIJKHGIGELG);
		}
	}

	// Token: 0x060093F3 RID: 37875 RVA: 0x00421344 File Offset: 0x0041F544
	public int KMNOIAIBLEB()
	{
		return Mathf.RoundToInt((float)this.NJHBLPGMGLP());
	}

	// Token: 0x060093F4 RID: 37876 RVA: 0x00421352 File Offset: 0x0041F552
	public int IFANMDKJPLP()
	{
		return (int)((float)this.KEHIFGILLJA() * 1797f + (float)this.KMGAHCANELI() * 1203f * 284f + (float)this.NODLBGKEGPM * 1644f * 99f);
	}

	// Token: 0x060093F5 RID: 37877 RVA: 0x0042138A File Offset: 0x0041F58A
	public int KCFNICBAINM()
	{
		return Mathf.RoundToInt((float)this.DCPKBIDFKAE());
	}

	// Token: 0x060093F6 RID: 37878 RVA: 0x00421398 File Offset: 0x0041F598
	public double DPEEFKPONMC()
	{
		return this.<GPNJFCBOADP>k__BackingField;
	}

	// Token: 0x170001E8 RID: 488
	// (get) Token: 0x060093F7 RID: 37879 RVA: 0x004213A0 File Offset: 0x0041F5A0
	public float JLLJFKOGLHJ
	{
		get
		{
			return (float)this.LNEPKLKELMI;
		}
	}

	// Token: 0x060093F8 RID: 37880 RVA: 0x004213AC File Offset: 0x0041F5AC
	public virtual string JHGPBNCOHHH()
	{
		object[] array = new object[7];
		array[0] = this.LNEPKLKELMI;
		array[1] = "";
		array[3] = this.NMKCBJKHBOH;
		array[3] = "1HandHeavySwing";
		array[6] = this.GJBKBEEJLDF();
		return string.Concat(array);
	}

	// Token: 0x060093F9 RID: 37881 RVA: 0x0042117F File Offset: 0x0041F37F
	public void NHPBJHIAICE(double DCCPCBLODIG)
	{
		this.<GPNJFCBOADP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060093FA RID: 37882 RVA: 0x004213FE File Offset: 0x0041F5FE
	public float LIINPAKEACF()
	{
		return (float)this.DMHCNOBKPJK();
	}

	// Token: 0x060093FB RID: 37883 RVA: 0x00420F7A File Offset: 0x0041F17A
	public float PDMNLDLGJNG()
	{
		return (float)this.OIGIHEPJFFJ();
	}

	// Token: 0x060093FC RID: 37884 RVA: 0x00421408 File Offset: 0x0041F608
	public IIBEEKCAAHK(string IIOHPBENEFI)
	{
		this.LNEPKLKELMI = 0.0;
		this.NMKCBJKHBOH = 0.0;
		this.NKGGAFLBFDF = 0.0;
		this.DCACBECHFMA = 0.0;
		this.MIJKHGIGELG = 0.0;
		this.ECDMPPDLHHH = 0.0;
		string currencyDecimalSeparator = NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator;
		IIOHPBENEFI = IIOHPBENEFI.Replace(".", currencyDecimalSeparator);
		IIOHPBENEFI = IIOHPBENEFI.Replace(",", currencyDecimalSeparator);
		string[] array = IIOHPBENEFI.Split(new char[]
		{
			'/'
		});
		try
		{
			if (array.Length >= 1)
			{
				this.LNEPKLKELMI = double.Parse(array[0]);
			}
			if (array.Length >= 2)
			{
				this.NMKCBJKHBOH = double.Parse(array[1]);
			}
			if (array.Length >= 3)
			{
				this.NKGGAFLBFDF = double.Parse(array[2]);
			}
			if (array.Length >= 4)
			{
				this.DCACBECHFMA = double.Parse(array[3]);
			}
			if (array.Length >= 5)
			{
				this.MIJKHGIGELG = double.Parse(array[4]);
			}
			if (array.Length >= 6)
			{
				this.ECDMPPDLHHH = double.Parse(array[5]);
			}
		}
		catch
		{
			this.LNEPKLKELMI = 0.0;
			this.NMKCBJKHBOH = 0.0;
			this.NKGGAFLBFDF = 0.0;
		}
	}

	// Token: 0x060093FD RID: 37885 RVA: 0x00421568 File Offset: 0x0041F768
	public float EGGDBMBCCIK()
	{
		return (float)this.MIJKHGIGELG;
	}

	// Token: 0x060093FE RID: 37886 RVA: 0x004213A0 File Offset: 0x0041F5A0
	public float FDCKJDDOJPB()
	{
		return (float)this.LNEPKLKELMI;
	}

	// Token: 0x060093FF RID: 37887 RVA: 0x00421571 File Offset: 0x0041F771
	public int HDPFLBFDIBN()
	{
		return (int)((float)this.NKEOCCKEOCE() * 68f + (float)this.KMGAHCANELI() * 1940f * 1161f + (float)this.CJKILDPJCFJ() * 322f * 1515f);
	}

	// Token: 0x06009400 RID: 37888 RVA: 0x00421112 File Offset: 0x0041F312
	public double AIMCFAHLPEF()
	{
		return this.<KLIIGPDIGAB>k__BackingField;
	}

	// Token: 0x06009401 RID: 37889 RVA: 0x00421324 File Offset: 0x0041F524
	public void PFKFBFAPMAP(double DCCPCBLODIG)
	{
		this.<LBGPICLDAKM>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06009402 RID: 37890 RVA: 0x004215A9 File Offset: 0x0041F7A9
	public Vector3 GEJNEDNGJDD()
	{
		return new Vector3((float)this.AIMCFAHLPEF(), (float)this.OIGIHEPJFFJ(), (float)this.KCKFCPIHMPC());
	}

	// Token: 0x06009404 RID: 37892 RVA: 0x004215C5 File Offset: 0x0041F7C5
	public float HCNLBNLJOFI()
	{
		return (float)this.DBFOHFDOCIB();
	}

	// Token: 0x06009405 RID: 37893 RVA: 0x004215CE File Offset: 0x0041F7CE
	public double ANFBFHGCJND()
	{
		return this.<JHIDDNMFLEF>k__BackingField;
	}

	// Token: 0x170001ED RID: 493
	// (get) Token: 0x06009406 RID: 37894 RVA: 0x004215D6 File Offset: 0x0041F7D6
	public float OHKGJCIJOCA
	{
		get
		{
			return (float)this.ECDMPPDLHHH;
		}
	}

	// Token: 0x06009407 RID: 37895 RVA: 0x0042132D File Offset: 0x0041F52D
	public float FIAMGODLKFA()
	{
		return (float)this.KCKFCPIHMPC();
	}

	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x0600943B RID: 37947 RVA: 0x0042160B File Offset: 0x0041F80B
	// (set) Token: 0x06009408 RID: 37896 RVA: 0x004215DF File Offset: 0x0041F7DF
	public double NMKCBJKHBOH { get; set; }

	// Token: 0x170001F1 RID: 497
	// (get) Token: 0x06009409 RID: 37897 RVA: 0x0042103E File Offset: 0x0041F23E
	public int LKAGIEBPLAI
	{
		get
		{
			return Mathf.RoundToInt((float)this.DCACBECHFMA);
		}
	}

	// Token: 0x0600940A RID: 37898 RVA: 0x004215D6 File Offset: 0x0041F7D6
	public float MDDIJIKACNM()
	{
		return (float)this.ECDMPPDLHHH;
	}

	// Token: 0x0600940B RID: 37899 RVA: 0x004215E8 File Offset: 0x0041F7E8
	public Vector2 OPIIPGKBELO()
	{
		return new Vector2((float)this.AIMCFAHLPEF(), (float)this.NMKCBJKHBOH);
	}

	// Token: 0x170001EE RID: 494
	// (get) Token: 0x0600940C RID: 37900 RVA: 0x004215FD File Offset: 0x0041F7FD
	public int IBEIBAHKIAH
	{
		get
		{
			return Mathf.RoundToInt((float)this.LNEPKLKELMI);
		}
	}

	// Token: 0x0600940D RID: 37901 RVA: 0x00421154 File Offset: 0x0041F354
	public void KBIOCGCIGEH(double DCCPCBLODIG)
	{
		this.<KLIIGPDIGAB>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x0600940E RID: 37902 RVA: 0x0042160B File Offset: 0x0041F80B
	public double OIGIHEPJFFJ()
	{
		return this.<KPBFAGCGBJP>k__BackingField;
	}

	// Token: 0x0600940F RID: 37903 RVA: 0x004210E4 File Offset: 0x0041F2E4
	public void GANHKGMOCPA(double DCCPCBLODIG)
	{
		this.<JMBHILJIPCO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06009410 RID: 37904 RVA: 0x00421613 File Offset: 0x0041F813
	public static IIBEEKCAAHK HLOLNGEKIIH()
	{
		return new IIBEEKCAAHK(1907.0, 539.0, 673.0);
	}

	// Token: 0x06009411 RID: 37905 RVA: 0x00421635 File Offset: 0x0041F835
	public int HMMKBABFCGD()
	{
		return Mathf.RoundToInt((float)this.LBJHMBCMGFB());
	}

	// Token: 0x06009412 RID: 37906 RVA: 0x0042117F File Offset: 0x0041F37F
	public void GEAKBHLLALF(double DCCPCBLODIG)
	{
		this.<GPNJFCBOADP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06009413 RID: 37907 RVA: 0x00421644 File Offset: 0x0041F844
	public IIBEEKCAAHK(Vector3 BDGECGGHECB)
	{
		this.LNEPKLKELMI = (double)BDGECGGHECB.x;
		this.NMKCBJKHBOH = (double)BDGECGGHECB.y;
		this.NKGGAFLBFDF = (double)BDGECGGHECB.z;
		this.DCACBECHFMA = 0.0;
		this.MIJKHGIGELG = 0.0;
		this.ECDMPPDLHHH = 0.0;
	}

	// Token: 0x06009414 RID: 37908 RVA: 0x004216AB File Offset: 0x0041F8AB
	public float AIKDHHMNANP()
	{
		return (float)this.DPEEFKPONMC();
	}

	// Token: 0x06009415 RID: 37909 RVA: 0x00421344 File Offset: 0x0041F544
	public int KIDKOFKNPEP()
	{
		return Mathf.RoundToInt((float)this.NJHBLPGMGLP());
	}

	// Token: 0x06009416 RID: 37910 RVA: 0x004216B4 File Offset: 0x0041F8B4
	public int NKEOCCKEOCE()
	{
		return Mathf.RoundToInt((float)this.DHJBAKDAMGH());
	}

	// Token: 0x06009417 RID: 37911 RVA: 0x004216C4 File Offset: 0x0041F8C4
	public IIBEEKCAAHK(Vector2 BDGECGGHECB)
	{
		this.LNEPKLKELMI = (double)BDGECGGHECB.x;
		this.NMKCBJKHBOH = (double)BDGECGGHECB.y;
		this.NKGGAFLBFDF = 0.0;
		this.DCACBECHFMA = 0.0;
		this.MIJKHGIGELG = 0.0;
		this.ECDMPPDLHHH = 0.0;
	}

	// Token: 0x06009418 RID: 37912 RVA: 0x00420FE9 File Offset: 0x0041F1E9
	public double LBJHMBCMGFB()
	{
		return this.<JMBHILJIPCO>k__BackingField;
	}

	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x06009419 RID: 37913 RVA: 0x0042172D File Offset: 0x0041F92D
	public int NODLBGKEGPM
	{
		get
		{
			return Mathf.RoundToInt((float)this.NKGGAFLBFDF);
		}
	}

	// Token: 0x0600941A RID: 37914 RVA: 0x004215C5 File Offset: 0x0041F7C5
	public float BJNOAHHGAIP()
	{
		return (float)this.DBFOHFDOCIB();
	}

	// Token: 0x0600941B RID: 37915 RVA: 0x00420F68 File Offset: 0x0041F168
	public float NAHLEJDLCNF()
	{
		return (float)this.AIMCFAHLPEF();
	}

	// Token: 0x0600941C RID: 37916 RVA: 0x0042173C File Offset: 0x0041F93C
	public IIBEEKCAAHK()
	{
		this.LNEPKLKELMI = 0.0;
		this.NMKCBJKHBOH = 0.0;
		this.NKGGAFLBFDF = 0.0;
		this.DCACBECHFMA = 0.0;
		this.MIJKHGIGELG = 0.0;
		this.ECDMPPDLHHH = 0.0;
	}

	// Token: 0x0600941D RID: 37917 RVA: 0x004215CE File Offset: 0x0041F7CE
	public double DMHCNOBKPJK()
	{
		return this.<JHIDDNMFLEF>k__BackingField;
	}

	// Token: 0x0600941E RID: 37918 RVA: 0x004217AC File Offset: 0x0041F9AC
	public override string ToString()
	{
		return string.Concat(new object[]
		{
			this.LNEPKLKELMI,
			"/",
			this.NMKCBJKHBOH,
			"/",
			this.NKGGAFLBFDF
		});
	}

	// Token: 0x0600941F RID: 37919 RVA: 0x00420F0A File Offset: 0x0041F10A
	public double HDPNCIECLKP()
	{
		return this.<LBGPICLDAKM>k__BackingField;
	}

	// Token: 0x06009421 RID: 37921 RVA: 0x004217FE File Offset: 0x0041F9FE
	public bool CHOHHHOLIBJ()
	{
		return this.DHJBAKDAMGH() == 1274.0 && this.NMKCBJKHBOH == 418.0 && this.KCKFCPIHMPC() == 1238.0;
	}

	// Token: 0x06009422 RID: 37922 RVA: 0x00421324 File Offset: 0x0041F524
	public void MKOBCGPJMHA(double DCCPCBLODIG)
	{
		this.<LBGPICLDAKM>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06009423 RID: 37923 RVA: 0x00421398 File Offset: 0x0041F598
	public double NJHBLPGMGLP()
	{
		return this.<GPNJFCBOADP>k__BackingField;
	}

	// Token: 0x06009424 RID: 37924 RVA: 0x00420FE9 File Offset: 0x0041F1E9
	public double DCPKBIDFKAE()
	{
		return this.<JMBHILJIPCO>k__BackingField;
	}

	// Token: 0x06009425 RID: 37925 RVA: 0x00421835 File Offset: 0x0041FA35
	public int OHOPGJNMFIE()
	{
		return (int)((float)this.KMIOLLENCOL() * 464f + (float)this.NLHKFMMDMMK() * 603f * 872f + (float)this.CJKILDPJCFJ() * 181f * 1196f);
	}

	// Token: 0x06009426 RID: 37926 RVA: 0x0042186D File Offset: 0x0041FA6D
	public int NGNFLNFOIHP()
	{
		return Mathf.RoundToInt((float)this.ECDMPPDLHHH);
	}

	// Token: 0x06009427 RID: 37927 RVA: 0x0042117F File Offset: 0x0041F37F
	public void MBPEFEIMENC(double DCCPCBLODIG)
	{
		this.<GPNJFCBOADP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06009428 RID: 37928 RVA: 0x0042187B File Offset: 0x0041FA7B
	public int JONPKHGEDFB()
	{
		return (int)((float)this.NKEOCCKEOCE() * 402f + (float)this.NLHKFMMDMMK() * 1423f * 1238f + (float)this.CJKILDPJCFJ() * 1494f * 390f);
	}

	// Token: 0x170001F3 RID: 499
	// (get) Token: 0x06009429 RID: 37929 RVA: 0x0042186D File Offset: 0x0041FA6D
	public int KEJCINHLMBC
	{
		get
		{
			return Mathf.RoundToInt((float)this.ECDMPPDLHHH);
		}
	}

	// Token: 0x0600942A RID: 37930 RVA: 0x004218B3 File Offset: 0x0041FAB3
	public static IIBEEKCAAHK JLKEPPCCJBK(IIBEEKCAAHK EGABJKIFAON, float HHAGIHEGFML)
	{
		return new IIBEEKCAAHK(EGABJKIFAON.DHJBAKDAMGH() * (double)HHAGIHEGFML, EGABJKIFAON.OIGIHEPJFFJ() * (double)HHAGIHEGFML, EGABJKIFAON.GJBKBEEJLDF() * (double)HHAGIHEGFML);
	}

	// Token: 0x0600942C RID: 37932 RVA: 0x004218D8 File Offset: 0x0041FAD8
	public virtual string AGFCIEALPEM()
	{
		object[] array = new object[1];
		array[1] = this.LNEPKLKELMI;
		array[1] = "file:///";
		array[7] = this.OIGIHEPJFFJ();
		array[8] = "5";
		array[6] = this.NKGGAFLBFDF;
		return string.Concat(array);
	}

	// Token: 0x170001EA RID: 490
	// (get) Token: 0x0600942D RID: 37933 RVA: 0x0042192A File Offset: 0x0041FB2A
	public float KGKNPAAMDJK
	{
		get
		{
			return (float)this.NKGGAFLBFDF;
		}
	}

	// Token: 0x0600942E RID: 37934 RVA: 0x00420F0A File Offset: 0x0041F10A
	public double FJACMDGJEBL()
	{
		return this.<LBGPICLDAKM>k__BackingField;
	}

	// Token: 0x0600942F RID: 37935 RVA: 0x00420F68 File Offset: 0x0041F168
	public float PHLLHDNNOMB()
	{
		return (float)this.AIMCFAHLPEF();
	}

	// Token: 0x06009430 RID: 37936 RVA: 0x00421933 File Offset: 0x0041FB33
	public Vector3 FPLDMBJEFEB()
	{
		return new Vector3((float)this.LNEPKLKELMI, (float)this.NMKCBJKHBOH, (float)this.NKGGAFLBFDF);
	}

	// Token: 0x170001E9 RID: 489
	// (get) Token: 0x06009431 RID: 37937 RVA: 0x004210ED File Offset: 0x0041F2ED
	public float OBEOJCGHOGL
	{
		get
		{
			return (float)this.NMKCBJKHBOH;
		}
	}

	// Token: 0x06009432 RID: 37938 RVA: 0x0042194F File Offset: 0x0041FB4F
	public Vector3 FBLEDBJGDBD()
	{
		return new Vector3((float)this.DHJBAKDAMGH(), (float)this.OIGIHEPJFFJ(), (float)this.FJACMDGJEBL());
	}

	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x06009433 RID: 37939 RVA: 0x0042196B File Offset: 0x0041FB6B
	public static IIBEEKCAAHK ECOFBCMPIDO
	{
		get
		{
			return new IIBEEKCAAHK(0.0, 0.0, 0.0);
		}
	}

	// Token: 0x06009435 RID: 37941 RVA: 0x0042198D File Offset: 0x0041FB8D
	public Vector3 MCPNAMDKJOH()
	{
		return new Vector3((float)this.AIMCFAHLPEF(), (float)this.OIGIHEPJFFJ(), (float)this.GJBKBEEJLDF());
	}

	// Token: 0x170001EC RID: 492
	// (get) Token: 0x06009436 RID: 37942 RVA: 0x00421568 File Offset: 0x0041F768
	public float EJMBCLDFANE
	{
		get
		{
			return (float)this.MIJKHGIGELG;
		}
	}

	// Token: 0x06009437 RID: 37943 RVA: 0x00421138 File Offset: 0x0041F338
	public int AJNPBCIMNCD()
	{
		return Mathf.RoundToInt((float)this.ANFBFHGCJND());
	}

	// Token: 0x06009438 RID: 37944 RVA: 0x004219A9 File Offset: 0x0041FBA9
	public static IIBEEKCAAHK ODANEFHPOFE(IIBEEKCAAHK EGABJKIFAON, float HHAGIHEGFML)
	{
		return new IIBEEKCAAHK(EGABJKIFAON.AIMCFAHLPEF() * (double)HHAGIHEGFML, EGABJKIFAON.NMKCBJKHBOH * (double)HHAGIHEGFML, EGABJKIFAON.DBFOHFDOCIB() * (double)HHAGIHEGFML);
	}

	// Token: 0x06009439 RID: 37945 RVA: 0x00421344 File Offset: 0x0041F544
	public int ACEPOCLANAG()
	{
		return Mathf.RoundToInt((float)this.NJHBLPGMGLP());
	}

	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x0600943A RID: 37946 RVA: 0x004219CB File Offset: 0x0041FBCB
	public bool DIFFCNOPHBJ
	{
		get
		{
			return this.LNEPKLKELMI == 0.0 && this.NMKCBJKHBOH == 0.0 && this.NKGGAFLBFDF == 0.0;
		}
	}

	// Token: 0x0600943C RID: 37948 RVA: 0x00420F7A File Offset: 0x0041F17A
	public float OAAKPMLGJJH()
	{
		return (float)this.OIGIHEPJFFJ();
	}

	// Token: 0x0600943D RID: 37949 RVA: 0x004215D6 File Offset: 0x0041F7D6
	public float GNPHGJFGIOJ()
	{
		return (float)this.ECDMPPDLHHH;
	}

	// Token: 0x0600943E RID: 37950 RVA: 0x00420F0A File Offset: 0x0041F10A
	public double GJBKBEEJLDF()
	{
		return this.<LBGPICLDAKM>k__BackingField;
	}

	// Token: 0x0600943F RID: 37951 RVA: 0x0042186D File Offset: 0x0041FA6D
	public int MLNEJIIGOMG()
	{
		return Mathf.RoundToInt((float)this.ECDMPPDLHHH);
	}

	// Token: 0x06009440 RID: 37952 RVA: 0x00421A02 File Offset: 0x0041FC02
	public int DCMGMMJDJHE()
	{
		return (int)((float)this.KEHIFGILLJA() * 870f + (float)this.KMGAHCANELI() * 182f * 1219f + (float)this.CJKILDPJCFJ() * 957f * 1630f);
	}

	// Token: 0x06009441 RID: 37953 RVA: 0x00420F5F File Offset: 0x0041F15F
	public void DFJKKEMEBCF(double DCCPCBLODIG)
	{
		this.<JHIDDNMFLEF>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06009442 RID: 37954 RVA: 0x00421146 File Offset: 0x0041F346
	public int KEHIFGILLJA()
	{
		return Mathf.RoundToInt((float)this.AIMCFAHLPEF());
	}

	// Token: 0x06009443 RID: 37955 RVA: 0x004215A9 File Offset: 0x0041F7A9
	public Vector3 OHIPPMOMNDB()
	{
		return new Vector3((float)this.AIMCFAHLPEF(), (float)this.OIGIHEPJFFJ(), (float)this.KCKFCPIHMPC());
	}
}
