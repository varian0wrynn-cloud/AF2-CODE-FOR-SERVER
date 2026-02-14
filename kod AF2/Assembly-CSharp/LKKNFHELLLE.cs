using System;
using System.Text;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Token: 0x02000586 RID: 1414
public static class LKKNFHELLLE
{
	// Token: 0x17000412 RID: 1042
	// (get) Token: 0x060128CF RID: 75983 RVA: 0x00814F61 File Offset: 0x00813161
	// (set) Token: 0x060128CE RID: 75982 RVA: 0x00814F59 File Offset: 0x00813159
	public static string OAMCKGBOBCL
	{
		get
		{
			return LKKNFHELLLE.MDEFDNBJHMP;
		}
		set
		{
			LKKNFHELLLE.MDEFDNBJHMP = value;
		}
	}

	// Token: 0x17000413 RID: 1043
	// (get) Token: 0x060128D0 RID: 75984 RVA: 0x00814F68 File Offset: 0x00813168
	// (set) Token: 0x060128D1 RID: 75985 RVA: 0x00814F85 File Offset: 0x00813185
	public static string GDFOCCHNMBH
	{
		get
		{
			if (string.IsNullOrEmpty(LKKNFHELLLE.MDACMIHCFGI))
			{
				LKKNFHELLLE.MDACMIHCFGI = LKKNFHELLLE.KJMCCCNAPKM();
			}
			return LKKNFHELLLE.MDACMIHCFGI;
		}
		set
		{
			LKKNFHELLLE.MDACMIHCFGI = value;
		}
	}

	// Token: 0x17000414 RID: 1044
	// (get) Token: 0x060128D2 RID: 75986 RVA: 0x00814F8D File Offset: 0x0081318D
	// (set) Token: 0x060128D3 RID: 75987 RVA: 0x00814F94 File Offset: 0x00813194
	[Obsolete("This property is obsolete, please use DeviceId instead.")]
	internal static string JKKHKMDPGAC
	{
		get
		{
			return LKKNFHELLLE.GDFOCCHNMBH;
		}
		set
		{
			LKKNFHELLLE.GDFOCCHNMBH = value;
		}
	}

	// Token: 0x17000415 RID: 1045
	// (get) Token: 0x060128D4 RID: 75988 RVA: 0x00814F9C File Offset: 0x0081319C
	private static uint CKCHAMMENPN
	{
		get
		{
			if (LKKNFHELLLE.JLHDBNKDIMM == 0U)
			{
				LKKNFHELLLE.JLHDBNKDIMM = LKKNFHELLLE.BDAAIFPGCCP(LKKNFHELLLE.GDFOCCHNMBH);
			}
			return LKKNFHELLLE.JLHDBNKDIMM;
		}
	}

	// Token: 0x060128D5 RID: 75989 RVA: 0x00814FB9 File Offset: 0x008131B9
	public static void OKKFOMBCPJN()
	{
		if (string.IsNullOrEmpty(LKKNFHELLLE.MDACMIHCFGI))
		{
			LKKNFHELLLE.MDACMIHCFGI = LKKNFHELLLE.KJMCCCNAPKM();
			LKKNFHELLLE.JLHDBNKDIMM = LKKNFHELLLE.BDAAIFPGCCP(LKKNFHELLLE.MDACMIHCFGI);
			return;
		}
		Debug.LogWarning("[ACTk] ObscuredPrefs.ForceLockToDeviceInit() is called, but device ID is already obtained!");
	}

	// Token: 0x060128D6 RID: 75990 RVA: 0x00814FEB File Offset: 0x008131EB
	[Obsolete("This method is obsolete, use property CryptoKey instead")]
	internal static void BBOGAEMNJJN(string JODDIMFACHN)
	{
		LKKNFHELLLE.OAMCKGBOBCL = JODDIMFACHN;
	}

	// Token: 0x060128D7 RID: 75991 RVA: 0x00814FF3 File Offset: 0x008131F3
	public static void BBHBEEFGEKL(string JMBKDINHDLO, int DCCPCBLODIG)
	{
		PlayerPrefs.SetString(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO), LKKNFHELLLE.FNCPNKLFFBM(JMBKDINHDLO, DCCPCBLODIG));
	}

	// Token: 0x060128D8 RID: 75992 RVA: 0x00815007 File Offset: 0x00813207
	public static int AJCENDFNEJO(string JMBKDINHDLO)
	{
		return LKKNFHELLLE.AJCENDFNEJO(JMBKDINHDLO, 0);
	}

	// Token: 0x060128D9 RID: 75993 RVA: 0x00815010 File Offset: 0x00813210
	public static int AJCENDFNEJO(string JMBKDINHDLO, int EOBCOHIMMCF)
	{
		string text = LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO);
		if (!PlayerPrefs.HasKey(text) && PlayerPrefs.HasKey(JMBKDINHDLO))
		{
			int @int = PlayerPrefs.GetInt(JMBKDINHDLO, EOBCOHIMMCF);
			if (!LKKNFHELLLE.FFNCFECPDBD)
			{
				LKKNFHELLLE.BBHBEEFGEKL(JMBKDINHDLO, @int);
				PlayerPrefs.DeleteKey(JMBKDINHDLO);
			}
			return @int;
		}
		string text2 = LKKNFHELLLE.JOLPGFABINK(JMBKDINHDLO, text);
		if (!(text2 == "{not_found}"))
		{
			return LKKNFHELLLE.BAIOCBPFPCF(JMBKDINHDLO, text2, EOBCOHIMMCF);
		}
		return EOBCOHIMMCF;
	}

	// Token: 0x060128DA RID: 75994 RVA: 0x00815074 File Offset: 0x00813274
	internal static string FNCPNKLFFBM(string JMBKDINHDLO, int DCCPCBLODIG)
	{
		byte[] bytes = BitConverter.GetBytes(DCCPCBLODIG);
		return LKKNFHELLLE.CEDPOBKEDCE(JMBKDINHDLO, bytes, LKKNFHELLLE.KJEKIALFPGO.Int);
	}

	// Token: 0x060128DB RID: 75995 RVA: 0x00815090 File Offset: 0x00813290
	internal static int BAIOCBPFPCF(string JMBKDINHDLO, string CLLLKAFOHGF, int EOBCOHIMMCF)
	{
		if (CLLLKAFOHGF.IndexOf(':') > -1)
		{
			string text = LKKNFHELLLE.OHJBHBOBNOB(CLLLKAFOHGF);
			if (text == "")
			{
				return EOBCOHIMMCF;
			}
			int num;
			int.TryParse(text, out num);
			LKKNFHELLLE.BBHBEEFGEKL(JMBKDINHDLO, num);
			return num;
		}
		else
		{
			byte[] array = LKKNFHELLLE.BBNMNNLFINM(JMBKDINHDLO, CLLLKAFOHGF);
			if (array == null)
			{
				return EOBCOHIMMCF;
			}
			return BitConverter.ToInt32(array, 0);
		}
	}

	// Token: 0x060128DC RID: 75996 RVA: 0x008150E4 File Offset: 0x008132E4
	public static void CCPDMKHFPDK(string JMBKDINHDLO, uint DCCPCBLODIG)
	{
		PlayerPrefs.SetString(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO), LKKNFHELLLE.DCCBNPGHHKH(JMBKDINHDLO, DCCPCBLODIG));
	}

	// Token: 0x060128DD RID: 75997 RVA: 0x008150F8 File Offset: 0x008132F8
	public static uint PJDHKADOLDH(string JMBKDINHDLO)
	{
		return LKKNFHELLLE.PJDHKADOLDH(JMBKDINHDLO, 0U);
	}

	// Token: 0x060128DE RID: 75998 RVA: 0x00815104 File Offset: 0x00813304
	public static uint PJDHKADOLDH(string JMBKDINHDLO, uint EOBCOHIMMCF)
	{
		string text = LKKNFHELLLE.JOLPGFABINK(JMBKDINHDLO, LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO));
		if (!(text == "{not_found}"))
		{
			return LKKNFHELLLE.MFBMHMCAAMA(JMBKDINHDLO, text, EOBCOHIMMCF);
		}
		return EOBCOHIMMCF;
	}

	// Token: 0x060128DF RID: 75999 RVA: 0x00815138 File Offset: 0x00813338
	private static string DCCBNPGHHKH(string JMBKDINHDLO, uint DCCPCBLODIG)
	{
		byte[] bytes = BitConverter.GetBytes(DCCPCBLODIG);
		return LKKNFHELLLE.CEDPOBKEDCE(JMBKDINHDLO, bytes, LKKNFHELLLE.KJEKIALFPGO.UInt);
	}

	// Token: 0x060128E0 RID: 76000 RVA: 0x00815158 File Offset: 0x00813358
	private static uint MFBMHMCAAMA(string JMBKDINHDLO, string CLLLKAFOHGF, uint EOBCOHIMMCF)
	{
		if (CLLLKAFOHGF.IndexOf(':') > -1)
		{
			string text = LKKNFHELLLE.OHJBHBOBNOB(CLLLKAFOHGF);
			if (text == "")
			{
				return EOBCOHIMMCF;
			}
			uint num;
			uint.TryParse(text, out num);
			LKKNFHELLLE.CCPDMKHFPDK(JMBKDINHDLO, num);
			return num;
		}
		else
		{
			byte[] array = LKKNFHELLLE.BBNMNNLFINM(JMBKDINHDLO, CLLLKAFOHGF);
			if (array == null)
			{
				return EOBCOHIMMCF;
			}
			return BitConverter.ToUInt32(array, 0);
		}
	}

	// Token: 0x060128E1 RID: 76001 RVA: 0x008151AC File Offset: 0x008133AC
	public static void FDABIMMMFDM(string JMBKDINHDLO, string DCCPCBLODIG)
	{
		PlayerPrefs.SetString(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO), LKKNFHELLLE.APJGKHFMFKL(JMBKDINHDLO, DCCPCBLODIG));
	}

	// Token: 0x060128E2 RID: 76002 RVA: 0x008151C0 File Offset: 0x008133C0
	public static string HPADJPKKDOG(string JMBKDINHDLO)
	{
		return LKKNFHELLLE.HPADJPKKDOG(JMBKDINHDLO, "");
	}

	// Token: 0x060128E3 RID: 76003 RVA: 0x008151D0 File Offset: 0x008133D0
	public static string HPADJPKKDOG(string JMBKDINHDLO, string EOBCOHIMMCF)
	{
		string text = LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO);
		if (!PlayerPrefs.HasKey(text) && PlayerPrefs.HasKey(JMBKDINHDLO))
		{
			string @string = PlayerPrefs.GetString(JMBKDINHDLO, EOBCOHIMMCF);
			if (!LKKNFHELLLE.FFNCFECPDBD)
			{
				LKKNFHELLLE.FDABIMMMFDM(JMBKDINHDLO, @string);
				PlayerPrefs.DeleteKey(JMBKDINHDLO);
			}
			return @string;
		}
		string text2 = LKKNFHELLLE.JOLPGFABINK(JMBKDINHDLO, text);
		if (!(text2 == "{not_found}"))
		{
			return LKKNFHELLLE.BNKNPIBNBCK(JMBKDINHDLO, text2, EOBCOHIMMCF);
		}
		return EOBCOHIMMCF;
	}

	// Token: 0x060128E4 RID: 76004 RVA: 0x00815234 File Offset: 0x00813434
	internal static string APJGKHFMFKL(string JMBKDINHDLO, string DCCPCBLODIG)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(DCCPCBLODIG);
		return LKKNFHELLLE.CEDPOBKEDCE(JMBKDINHDLO, bytes, LKKNFHELLLE.KJEKIALFPGO.String);
	}

	// Token: 0x060128E5 RID: 76005 RVA: 0x00815258 File Offset: 0x00813458
	internal static string BNKNPIBNBCK(string JMBKDINHDLO, string CLLLKAFOHGF, string EOBCOHIMMCF)
	{
		if (CLLLKAFOHGF.IndexOf(':') > -1)
		{
			string text = LKKNFHELLLE.OHJBHBOBNOB(CLLLKAFOHGF);
			if (text == "")
			{
				return EOBCOHIMMCF;
			}
			LKKNFHELLLE.FDABIMMMFDM(JMBKDINHDLO, text);
			return text;
		}
		else
		{
			byte[] array = LKKNFHELLLE.BBNMNNLFINM(JMBKDINHDLO, CLLLKAFOHGF);
			if (array == null)
			{
				return EOBCOHIMMCF;
			}
			return Encoding.UTF8.GetString(array, 0, array.Length);
		}
	}

	// Token: 0x060128E6 RID: 76006 RVA: 0x008152AB File Offset: 0x008134AB
	public static void FFBDAGLKIBP(string JMBKDINHDLO, float DCCPCBLODIG)
	{
		PlayerPrefs.SetString(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO), LKKNFHELLLE.KCACGMNONDM(JMBKDINHDLO, DCCPCBLODIG));
	}

	// Token: 0x060128E7 RID: 76007 RVA: 0x008152BF File Offset: 0x008134BF
	public static float JGJNCJGCFNC(string JMBKDINHDLO)
	{
		return LKKNFHELLLE.JGJNCJGCFNC(JMBKDINHDLO, 0f);
	}

	// Token: 0x060128E8 RID: 76008 RVA: 0x008152CC File Offset: 0x008134CC
	public static float JGJNCJGCFNC(string JMBKDINHDLO, float EOBCOHIMMCF)
	{
		string text = LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO);
		if (!PlayerPrefs.HasKey(text) && PlayerPrefs.HasKey(JMBKDINHDLO))
		{
			float @float = PlayerPrefs.GetFloat(JMBKDINHDLO, EOBCOHIMMCF);
			if (!LKKNFHELLLE.FFNCFECPDBD)
			{
				LKKNFHELLLE.FFBDAGLKIBP(JMBKDINHDLO, @float);
				PlayerPrefs.DeleteKey(JMBKDINHDLO);
			}
			return @float;
		}
		string text2 = LKKNFHELLLE.JOLPGFABINK(JMBKDINHDLO, text);
		if (!(text2 == "{not_found}"))
		{
			return LKKNFHELLLE.DIEJDCFBJGK(JMBKDINHDLO, text2, EOBCOHIMMCF);
		}
		return EOBCOHIMMCF;
	}

	// Token: 0x060128E9 RID: 76009 RVA: 0x00815330 File Offset: 0x00813530
	internal static string KCACGMNONDM(string JMBKDINHDLO, float DCCPCBLODIG)
	{
		byte[] bytes = BitConverter.GetBytes(DCCPCBLODIG);
		return LKKNFHELLLE.CEDPOBKEDCE(JMBKDINHDLO, bytes, LKKNFHELLLE.KJEKIALFPGO.Float);
	}

	// Token: 0x060128EA RID: 76010 RVA: 0x00815350 File Offset: 0x00813550
	internal static float DIEJDCFBJGK(string JMBKDINHDLO, string CLLLKAFOHGF, float EOBCOHIMMCF)
	{
		if (CLLLKAFOHGF.IndexOf(':') > -1)
		{
			string text = LKKNFHELLLE.OHJBHBOBNOB(CLLLKAFOHGF);
			if (text == "")
			{
				return EOBCOHIMMCF;
			}
			float num;
			float.TryParse(text, out num);
			LKKNFHELLLE.FFBDAGLKIBP(JMBKDINHDLO, num);
			return num;
		}
		else
		{
			byte[] array = LKKNFHELLLE.BBNMNNLFINM(JMBKDINHDLO, CLLLKAFOHGF);
			if (array == null)
			{
				return EOBCOHIMMCF;
			}
			return BitConverter.ToSingle(array, 0);
		}
	}

	// Token: 0x060128EB RID: 76011 RVA: 0x008153A4 File Offset: 0x008135A4
	public static void CCIBKLAODAO(string JMBKDINHDLO, double DCCPCBLODIG)
	{
		PlayerPrefs.SetString(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO), LKKNFHELLLE.PKJJHOAGKDJ(JMBKDINHDLO, DCCPCBLODIG));
	}

	// Token: 0x060128EC RID: 76012 RVA: 0x008153B8 File Offset: 0x008135B8
	public static double DLOALMJPIDL(string JMBKDINHDLO)
	{
		return LKKNFHELLLE.DLOALMJPIDL(JMBKDINHDLO, 0.0);
	}

	// Token: 0x060128ED RID: 76013 RVA: 0x008153CC File Offset: 0x008135CC
	public static double DLOALMJPIDL(string JMBKDINHDLO, double EOBCOHIMMCF)
	{
		string text = LKKNFHELLLE.JOLPGFABINK(JMBKDINHDLO, LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO));
		if (!(text == "{not_found}"))
		{
			return LKKNFHELLLE.OEMOLFHGKOI(JMBKDINHDLO, text, EOBCOHIMMCF);
		}
		return EOBCOHIMMCF;
	}

	// Token: 0x060128EE RID: 76014 RVA: 0x00815400 File Offset: 0x00813600
	private static string PKJJHOAGKDJ(string JMBKDINHDLO, double DCCPCBLODIG)
	{
		byte[] bytes = BitConverter.GetBytes(DCCPCBLODIG);
		return LKKNFHELLLE.CEDPOBKEDCE(JMBKDINHDLO, bytes, LKKNFHELLLE.KJEKIALFPGO.Double);
	}

	// Token: 0x060128EF RID: 76015 RVA: 0x00815420 File Offset: 0x00813620
	private static double OEMOLFHGKOI(string JMBKDINHDLO, string CLLLKAFOHGF, double EOBCOHIMMCF)
	{
		if (CLLLKAFOHGF.IndexOf(':') > -1)
		{
			string text = LKKNFHELLLE.OHJBHBOBNOB(CLLLKAFOHGF);
			if (text == "")
			{
				return EOBCOHIMMCF;
			}
			double num;
			double.TryParse(text, out num);
			LKKNFHELLLE.CCIBKLAODAO(JMBKDINHDLO, num);
			return num;
		}
		else
		{
			byte[] array = LKKNFHELLLE.BBNMNNLFINM(JMBKDINHDLO, CLLLKAFOHGF);
			if (array == null)
			{
				return EOBCOHIMMCF;
			}
			return BitConverter.ToDouble(array, 0);
		}
	}

	// Token: 0x060128F0 RID: 76016 RVA: 0x00815474 File Offset: 0x00813674
	public static void JDCKOPLJBMP(string JMBKDINHDLO, decimal DCCPCBLODIG)
	{
		PlayerPrefs.SetString(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO), LKKNFHELLLE.KIGGKACNAHH(JMBKDINHDLO, DCCPCBLODIG));
	}

	// Token: 0x060128F1 RID: 76017 RVA: 0x00815488 File Offset: 0x00813688
	public static decimal HINJJOHALKB(string JMBKDINHDLO)
	{
		return LKKNFHELLLE.HINJJOHALKB(JMBKDINHDLO, 0m);
	}

	// Token: 0x060128F2 RID: 76018 RVA: 0x00815498 File Offset: 0x00813698
	public static decimal HINJJOHALKB(string JMBKDINHDLO, decimal EOBCOHIMMCF)
	{
		string text = LKKNFHELLLE.JOLPGFABINK(JMBKDINHDLO, LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO));
		if (!(text == "{not_found}"))
		{
			return LKKNFHELLLE.DJACCBGFKGG(JMBKDINHDLO, text, EOBCOHIMMCF);
		}
		return EOBCOHIMMCF;
	}

	// Token: 0x060128F3 RID: 76019 RVA: 0x008154CC File Offset: 0x008136CC
	private static string KIGGKACNAHH(string JMBKDINHDLO, decimal DCCPCBLODIG)
	{
		byte[] nencfdhmena = LFHBOIDLKFD.FJDHGHDLAHN(DCCPCBLODIG);
		return LKKNFHELLLE.CEDPOBKEDCE(JMBKDINHDLO, nencfdhmena, LKKNFHELLLE.KJEKIALFPGO.Decimal);
	}

	// Token: 0x060128F4 RID: 76020 RVA: 0x008154EC File Offset: 0x008136EC
	private static decimal DJACCBGFKGG(string JMBKDINHDLO, string CLLLKAFOHGF, decimal EOBCOHIMMCF)
	{
		if (CLLLKAFOHGF.IndexOf(':') > -1)
		{
			string text = LKKNFHELLLE.OHJBHBOBNOB(CLLLKAFOHGF);
			if (text == "")
			{
				return EOBCOHIMMCF;
			}
			decimal num;
			decimal.TryParse(text, out num);
			LKKNFHELLLE.JDCKOPLJBMP(JMBKDINHDLO, num);
			return num;
		}
		else
		{
			byte[] array = LKKNFHELLLE.BBNMNNLFINM(JMBKDINHDLO, CLLLKAFOHGF);
			if (array == null)
			{
				return EOBCOHIMMCF;
			}
			return LFHBOIDLKFD.FFJLHBDIPDJ(array);
		}
	}

	// Token: 0x060128F5 RID: 76021 RVA: 0x0081553F File Offset: 0x0081373F
	public static void IHKNEJCFINH(string JMBKDINHDLO, long DCCPCBLODIG)
	{
		PlayerPrefs.SetString(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO), LKKNFHELLLE.CNKOCMLIHMF(JMBKDINHDLO, DCCPCBLODIG));
	}

	// Token: 0x060128F6 RID: 76022 RVA: 0x00815553 File Offset: 0x00813753
	public static long ENNEDJMGKCH(string JMBKDINHDLO)
	{
		return LKKNFHELLLE.ENNEDJMGKCH(JMBKDINHDLO, 0L);
	}

	// Token: 0x060128F7 RID: 76023 RVA: 0x00815560 File Offset: 0x00813760
	public static long ENNEDJMGKCH(string JMBKDINHDLO, long EOBCOHIMMCF)
	{
		string text = LKKNFHELLLE.JOLPGFABINK(JMBKDINHDLO, LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO));
		if (!(text == "{not_found}"))
		{
			return LKKNFHELLLE.BKLOPBMODAG(JMBKDINHDLO, text, EOBCOHIMMCF);
		}
		return EOBCOHIMMCF;
	}

	// Token: 0x060128F8 RID: 76024 RVA: 0x00815594 File Offset: 0x00813794
	private static string CNKOCMLIHMF(string JMBKDINHDLO, long DCCPCBLODIG)
	{
		byte[] bytes = BitConverter.GetBytes(DCCPCBLODIG);
		return LKKNFHELLLE.CEDPOBKEDCE(JMBKDINHDLO, bytes, LKKNFHELLLE.KJEKIALFPGO.Long);
	}

	// Token: 0x060128F9 RID: 76025 RVA: 0x008155B4 File Offset: 0x008137B4
	private static long BKLOPBMODAG(string JMBKDINHDLO, string CLLLKAFOHGF, long EOBCOHIMMCF)
	{
		if (CLLLKAFOHGF.IndexOf(':') > -1)
		{
			string text = LKKNFHELLLE.OHJBHBOBNOB(CLLLKAFOHGF);
			if (text == "")
			{
				return EOBCOHIMMCF;
			}
			long num;
			long.TryParse(text, out num);
			LKKNFHELLLE.IHKNEJCFINH(JMBKDINHDLO, num);
			return num;
		}
		else
		{
			byte[] array = LKKNFHELLLE.BBNMNNLFINM(JMBKDINHDLO, CLLLKAFOHGF);
			if (array == null)
			{
				return EOBCOHIMMCF;
			}
			return BitConverter.ToInt64(array, 0);
		}
	}

	// Token: 0x060128FA RID: 76026 RVA: 0x00815608 File Offset: 0x00813808
	public static void NIEFPKALPAE(string JMBKDINHDLO, ulong DCCPCBLODIG)
	{
		PlayerPrefs.SetString(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO), LKKNFHELLLE.BDFHDAADBEP(JMBKDINHDLO, DCCPCBLODIG));
	}

	// Token: 0x060128FB RID: 76027 RVA: 0x0081561C File Offset: 0x0081381C
	public static ulong DLFJPPGDOIA(string JMBKDINHDLO)
	{
		return LKKNFHELLLE.DLFJPPGDOIA(JMBKDINHDLO, 0UL);
	}

	// Token: 0x060128FC RID: 76028 RVA: 0x00815628 File Offset: 0x00813828
	public static ulong DLFJPPGDOIA(string JMBKDINHDLO, ulong EOBCOHIMMCF)
	{
		string text = LKKNFHELLLE.JOLPGFABINK(JMBKDINHDLO, LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO));
		if (!(text == "{not_found}"))
		{
			return LKKNFHELLLE.GAEHHDHLPPE(JMBKDINHDLO, text, EOBCOHIMMCF);
		}
		return EOBCOHIMMCF;
	}

	// Token: 0x060128FD RID: 76029 RVA: 0x0081565C File Offset: 0x0081385C
	private static string BDFHDAADBEP(string JMBKDINHDLO, ulong DCCPCBLODIG)
	{
		byte[] bytes = BitConverter.GetBytes(DCCPCBLODIG);
		return LKKNFHELLLE.CEDPOBKEDCE(JMBKDINHDLO, bytes, LKKNFHELLLE.KJEKIALFPGO.ULong);
	}

	// Token: 0x060128FE RID: 76030 RVA: 0x0081567C File Offset: 0x0081387C
	private static ulong GAEHHDHLPPE(string JMBKDINHDLO, string CLLLKAFOHGF, ulong EOBCOHIMMCF)
	{
		if (CLLLKAFOHGF.IndexOf(':') > -1)
		{
			string text = LKKNFHELLLE.OHJBHBOBNOB(CLLLKAFOHGF);
			if (text == "")
			{
				return EOBCOHIMMCF;
			}
			ulong num;
			ulong.TryParse(text, out num);
			LKKNFHELLLE.NIEFPKALPAE(JMBKDINHDLO, num);
			return num;
		}
		else
		{
			byte[] array = LKKNFHELLLE.BBNMNNLFINM(JMBKDINHDLO, CLLLKAFOHGF);
			if (array == null)
			{
				return EOBCOHIMMCF;
			}
			return BitConverter.ToUInt64(array, 0);
		}
	}

	// Token: 0x060128FF RID: 76031 RVA: 0x008156D0 File Offset: 0x008138D0
	public static void LJFPOEKDNHA(string JMBKDINHDLO, bool DCCPCBLODIG)
	{
		PlayerPrefs.SetString(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO), LKKNFHELLLE.HGICDKDMAPB(JMBKDINHDLO, DCCPCBLODIG));
	}

	// Token: 0x06012900 RID: 76032 RVA: 0x008156E4 File Offset: 0x008138E4
	public static bool IFFDPHPBONE(string JMBKDINHDLO)
	{
		return LKKNFHELLLE.IFFDPHPBONE(JMBKDINHDLO, false);
	}

	// Token: 0x06012901 RID: 76033 RVA: 0x008156F0 File Offset: 0x008138F0
	public static bool IFFDPHPBONE(string JMBKDINHDLO, bool EOBCOHIMMCF)
	{
		string text = LKKNFHELLLE.JOLPGFABINK(JMBKDINHDLO, LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO));
		if (!(text == "{not_found}"))
		{
			return LKKNFHELLLE.DMIHEMOBBFD(JMBKDINHDLO, text, EOBCOHIMMCF);
		}
		return EOBCOHIMMCF;
	}

	// Token: 0x06012902 RID: 76034 RVA: 0x00815724 File Offset: 0x00813924
	private static string HGICDKDMAPB(string JMBKDINHDLO, bool DCCPCBLODIG)
	{
		byte[] bytes = BitConverter.GetBytes(DCCPCBLODIG);
		return LKKNFHELLLE.CEDPOBKEDCE(JMBKDINHDLO, bytes, LKKNFHELLLE.KJEKIALFPGO.Bool);
	}

	// Token: 0x06012903 RID: 76035 RVA: 0x00815744 File Offset: 0x00813944
	private static bool DMIHEMOBBFD(string JMBKDINHDLO, string CLLLKAFOHGF, bool EOBCOHIMMCF)
	{
		if (CLLLKAFOHGF.IndexOf(':') > -1)
		{
			string text = LKKNFHELLLE.OHJBHBOBNOB(CLLLKAFOHGF);
			if (text == "")
			{
				return EOBCOHIMMCF;
			}
			int num;
			int.TryParse(text, out num);
			LKKNFHELLLE.LJFPOEKDNHA(JMBKDINHDLO, num == 1);
			return num == 1;
		}
		else
		{
			byte[] array = LKKNFHELLLE.BBNMNNLFINM(JMBKDINHDLO, CLLLKAFOHGF);
			if (array == null)
			{
				return EOBCOHIMMCF;
			}
			return BitConverter.ToBoolean(array, 0);
		}
	}

	// Token: 0x06012904 RID: 76036 RVA: 0x0081579E File Offset: 0x0081399E
	public static void FAPMLODBLAN(string JMBKDINHDLO, byte[] DCCPCBLODIG)
	{
		PlayerPrefs.SetString(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO), LKKNFHELLLE.KHPEJBGBCLC(JMBKDINHDLO, DCCPCBLODIG));
	}

	// Token: 0x06012905 RID: 76037 RVA: 0x008157B2 File Offset: 0x008139B2
	public static byte[] PNKFFEMEOEG(string JMBKDINHDLO)
	{
		return LKKNFHELLLE.PNKFFEMEOEG(JMBKDINHDLO, 0, 0);
	}

	// Token: 0x06012906 RID: 76038 RVA: 0x008157BC File Offset: 0x008139BC
	public static byte[] PNKFFEMEOEG(string JMBKDINHDLO, byte EOBCOHIMMCF, int LAAKOJDKDBH)
	{
		string text = LKKNFHELLLE.JOLPGFABINK(JMBKDINHDLO, LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO));
		if (text == "{not_found}")
		{
			return LKKNFHELLLE.MPLIJAFEOFF(EOBCOHIMMCF, LAAKOJDKDBH);
		}
		return LKKNFHELLLE.GGMKKGMODPL(JMBKDINHDLO, text, EOBCOHIMMCF, LAAKOJDKDBH);
	}

	// Token: 0x06012907 RID: 76039 RVA: 0x008157F4 File Offset: 0x008139F4
	private static string KHPEJBGBCLC(string JMBKDINHDLO, byte[] DCCPCBLODIG)
	{
		return LKKNFHELLLE.CEDPOBKEDCE(JMBKDINHDLO, DCCPCBLODIG, LKKNFHELLLE.KJEKIALFPGO.ByteArray);
	}

	// Token: 0x06012908 RID: 76040 RVA: 0x00815800 File Offset: 0x00813A00
	private static byte[] GGMKKGMODPL(string JMBKDINHDLO, string CLLLKAFOHGF, byte EOBCOHIMMCF, int LAAKOJDKDBH)
	{
		if (CLLLKAFOHGF.IndexOf(':') > -1)
		{
			string text = LKKNFHELLLE.OHJBHBOBNOB(CLLLKAFOHGF);
			if (text == "")
			{
				return LKKNFHELLLE.MPLIJAFEOFF(EOBCOHIMMCF, LAAKOJDKDBH);
			}
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			LKKNFHELLLE.FAPMLODBLAN(JMBKDINHDLO, bytes);
			return bytes;
		}
		else
		{
			byte[] array = LKKNFHELLLE.BBNMNNLFINM(JMBKDINHDLO, CLLLKAFOHGF);
			if (array == null)
			{
				return LKKNFHELLLE.MPLIJAFEOFF(EOBCOHIMMCF, LAAKOJDKDBH);
			}
			return array;
		}
	}

	// Token: 0x06012909 RID: 76041 RVA: 0x00815860 File Offset: 0x00813A60
	private static byte[] MPLIJAFEOFF(byte DCCPCBLODIG, int IOHIFNBBGPJ)
	{
		byte[] array = new byte[IOHIFNBBGPJ];
		for (int i = 0; i < IOHIFNBBGPJ; i++)
		{
			array[i] = DCCPCBLODIG;
		}
		return array;
	}

	// Token: 0x0601290A RID: 76042 RVA: 0x00815885 File Offset: 0x00813A85
	public static void EDCLCKOECBG(string JMBKDINHDLO, Vector2 DCCPCBLODIG)
	{
		PlayerPrefs.SetString(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO), LKKNFHELLLE.GEIPJGECNJI(JMBKDINHDLO, DCCPCBLODIG));
	}

	// Token: 0x0601290B RID: 76043 RVA: 0x00815899 File Offset: 0x00813A99
	public static Vector2 FPMHFABDEMO(string JMBKDINHDLO)
	{
		return LKKNFHELLLE.FPMHFABDEMO(JMBKDINHDLO, Vector2.zero);
	}

	// Token: 0x0601290C RID: 76044 RVA: 0x008158A8 File Offset: 0x00813AA8
	public static Vector2 FPMHFABDEMO(string JMBKDINHDLO, Vector2 EOBCOHIMMCF)
	{
		string text = LKKNFHELLLE.JOLPGFABINK(JMBKDINHDLO, LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO));
		if (!(text == "{not_found}"))
		{
			return LKKNFHELLLE.DLEKIAEOACL(JMBKDINHDLO, text, EOBCOHIMMCF);
		}
		return EOBCOHIMMCF;
	}

	// Token: 0x0601290D RID: 76045 RVA: 0x008158DC File Offset: 0x00813ADC
	private static string GEIPJGECNJI(string JMBKDINHDLO, Vector2 DCCPCBLODIG)
	{
		byte[] array = new byte[8];
		Buffer.BlockCopy(BitConverter.GetBytes(DCCPCBLODIG.x), 0, array, 0, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(DCCPCBLODIG.y), 0, array, 4, 4);
		return LKKNFHELLLE.CEDPOBKEDCE(JMBKDINHDLO, array, LKKNFHELLLE.KJEKIALFPGO.Vector2);
	}

	// Token: 0x0601290E RID: 76046 RVA: 0x00815924 File Offset: 0x00813B24
	private static Vector2 DLEKIAEOACL(string JMBKDINHDLO, string CLLLKAFOHGF, Vector2 EOBCOHIMMCF)
	{
		if (CLLLKAFOHGF.IndexOf(':') > -1)
		{
			string text = LKKNFHELLLE.OHJBHBOBNOB(CLLLKAFOHGF);
			if (text == "")
			{
				return EOBCOHIMMCF;
			}
			string[] array = text.Split(new char[]
			{
				"|"[0]
			});
			float x;
			float.TryParse(array[0], out x);
			float y;
			float.TryParse(array[1], out y);
			Vector2 vector = new Vector2(x, y);
			LKKNFHELLLE.EDCLCKOECBG(JMBKDINHDLO, vector);
			return vector;
		}
		else
		{
			byte[] array2 = LKKNFHELLLE.BBNMNNLFINM(JMBKDINHDLO, CLLLKAFOHGF);
			if (array2 == null)
			{
				return EOBCOHIMMCF;
			}
			Vector2 result;
			result.x = BitConverter.ToSingle(array2, 0);
			result.y = BitConverter.ToSingle(array2, 4);
			return result;
		}
	}

	// Token: 0x0601290F RID: 76047 RVA: 0x008159C0 File Offset: 0x00813BC0
	public static void GLOIENOOOHM(string JMBKDINHDLO, Vector3 DCCPCBLODIG)
	{
		PlayerPrefs.SetString(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO), LKKNFHELLLE.BBHFKHBIDJM(JMBKDINHDLO, DCCPCBLODIG));
	}

	// Token: 0x06012910 RID: 76048 RVA: 0x008159D4 File Offset: 0x00813BD4
	public static Vector3 DALCFJICOLI(string JMBKDINHDLO)
	{
		return LKKNFHELLLE.DALCFJICOLI(JMBKDINHDLO, Vector3.zero);
	}

	// Token: 0x06012911 RID: 76049 RVA: 0x008159E4 File Offset: 0x00813BE4
	public static Vector3 DALCFJICOLI(string JMBKDINHDLO, Vector3 EOBCOHIMMCF)
	{
		string text = LKKNFHELLLE.JOLPGFABINK(JMBKDINHDLO, LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO));
		if (!(text == "{not_found}"))
		{
			return LKKNFHELLLE.HEEFNEMILFG(JMBKDINHDLO, text, EOBCOHIMMCF);
		}
		return EOBCOHIMMCF;
	}

	// Token: 0x06012912 RID: 76050 RVA: 0x00815A18 File Offset: 0x00813C18
	private static string BBHFKHBIDJM(string JMBKDINHDLO, Vector3 DCCPCBLODIG)
	{
		byte[] array = new byte[12];
		Buffer.BlockCopy(BitConverter.GetBytes(DCCPCBLODIG.x), 0, array, 0, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(DCCPCBLODIG.y), 0, array, 4, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(DCCPCBLODIG.z), 0, array, 8, 4);
		return LKKNFHELLLE.CEDPOBKEDCE(JMBKDINHDLO, array, LKKNFHELLLE.KJEKIALFPGO.Vector3);
	}

	// Token: 0x06012913 RID: 76051 RVA: 0x00815A74 File Offset: 0x00813C74
	private static Vector3 HEEFNEMILFG(string JMBKDINHDLO, string CLLLKAFOHGF, Vector3 EOBCOHIMMCF)
	{
		if (CLLLKAFOHGF.IndexOf(':') > -1)
		{
			string text = LKKNFHELLLE.OHJBHBOBNOB(CLLLKAFOHGF);
			if (text == "")
			{
				return EOBCOHIMMCF;
			}
			string[] array = text.Split(new char[]
			{
				"|"[0]
			});
			float x;
			float.TryParse(array[0], out x);
			float y;
			float.TryParse(array[1], out y);
			float z;
			float.TryParse(array[2], out z);
			Vector3 vector = new Vector3(x, y, z);
			LKKNFHELLLE.GLOIENOOOHM(JMBKDINHDLO, vector);
			return vector;
		}
		else
		{
			byte[] array2 = LKKNFHELLLE.BBNMNNLFINM(JMBKDINHDLO, CLLLKAFOHGF);
			if (array2 == null)
			{
				return EOBCOHIMMCF;
			}
			Vector3 result;
			result.x = BitConverter.ToSingle(array2, 0);
			result.y = BitConverter.ToSingle(array2, 4);
			result.z = BitConverter.ToSingle(array2, 8);
			return result;
		}
	}

	// Token: 0x06012914 RID: 76052 RVA: 0x00815B2B File Offset: 0x00813D2B
	public static void NKDMHHPNAHP(string JMBKDINHDLO, Quaternion DCCPCBLODIG)
	{
		PlayerPrefs.SetString(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO), LKKNFHELLLE.JOHMJHHHLCC(JMBKDINHDLO, DCCPCBLODIG));
	}

	// Token: 0x06012915 RID: 76053 RVA: 0x00815B3F File Offset: 0x00813D3F
	public static Quaternion FKBHNBGCPOH(string JMBKDINHDLO)
	{
		return LKKNFHELLLE.FKBHNBGCPOH(JMBKDINHDLO, Quaternion.identity);
	}

	// Token: 0x06012916 RID: 76054 RVA: 0x00815B4C File Offset: 0x00813D4C
	public static Quaternion FKBHNBGCPOH(string JMBKDINHDLO, Quaternion EOBCOHIMMCF)
	{
		string text = LKKNFHELLLE.JOLPGFABINK(JMBKDINHDLO, LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO));
		if (!(text == "{not_found}"))
		{
			return LKKNFHELLLE.JIDINNOJBAG(JMBKDINHDLO, text, EOBCOHIMMCF);
		}
		return EOBCOHIMMCF;
	}

	// Token: 0x06012917 RID: 76055 RVA: 0x00815B80 File Offset: 0x00813D80
	private static string JOHMJHHHLCC(string JMBKDINHDLO, Quaternion DCCPCBLODIG)
	{
		byte[] array = new byte[16];
		Buffer.BlockCopy(BitConverter.GetBytes(DCCPCBLODIG.x), 0, array, 0, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(DCCPCBLODIG.y), 0, array, 4, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(DCCPCBLODIG.z), 0, array, 8, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(DCCPCBLODIG.w), 0, array, 12, 4);
		return LKKNFHELLLE.CEDPOBKEDCE(JMBKDINHDLO, array, LKKNFHELLLE.KJEKIALFPGO.Quaternion);
	}

	// Token: 0x06012918 RID: 76056 RVA: 0x00815BF0 File Offset: 0x00813DF0
	private static Quaternion JIDINNOJBAG(string JMBKDINHDLO, string CLLLKAFOHGF, Quaternion EOBCOHIMMCF)
	{
		if (CLLLKAFOHGF.IndexOf(':') > -1)
		{
			string text = LKKNFHELLLE.OHJBHBOBNOB(CLLLKAFOHGF);
			if (text == "")
			{
				return EOBCOHIMMCF;
			}
			string[] array = text.Split(new char[]
			{
				"|"[0]
			});
			float x;
			float.TryParse(array[0], out x);
			float y;
			float.TryParse(array[1], out y);
			float z;
			float.TryParse(array[2], out z);
			float w;
			float.TryParse(array[3], out w);
			Quaternion quaternion = new Quaternion(x, y, z, w);
			LKKNFHELLLE.NKDMHHPNAHP(JMBKDINHDLO, quaternion);
			return quaternion;
		}
		else
		{
			byte[] array2 = LKKNFHELLLE.BBNMNNLFINM(JMBKDINHDLO, CLLLKAFOHGF);
			if (array2 == null)
			{
				return EOBCOHIMMCF;
			}
			Quaternion result;
			result.x = BitConverter.ToSingle(array2, 0);
			result.y = BitConverter.ToSingle(array2, 4);
			result.z = BitConverter.ToSingle(array2, 8);
			result.w = BitConverter.ToSingle(array2, 12);
			return result;
		}
	}

	// Token: 0x06012919 RID: 76057 RVA: 0x00815CC4 File Offset: 0x00813EC4
	public static void AFFHHGEGACP(string JMBKDINHDLO, Color32 DCCPCBLODIG)
	{
		uint dccpcblodig = (uint)((int)DCCPCBLODIG.a << 24 | (int)DCCPCBLODIG.r << 16 | (int)DCCPCBLODIG.g << 8 | (int)DCCPCBLODIG.b);
		PlayerPrefs.SetString(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO), LKKNFHELLLE.LIEIKBJJDHF(JMBKDINHDLO, dccpcblodig));
	}

	// Token: 0x0601291A RID: 76058 RVA: 0x00815D07 File Offset: 0x00813F07
	public static Color32 NLIFGBAMGEK(string JMBKDINHDLO)
	{
		return LKKNFHELLLE.NLIFGBAMGEK(JMBKDINHDLO, new Color32(0, 0, 0, 1));
	}

	// Token: 0x0601291B RID: 76059 RVA: 0x00815D18 File Offset: 0x00813F18
	public static Color32 NLIFGBAMGEK(string JMBKDINHDLO, Color32 EOBCOHIMMCF)
	{
		string text = LKKNFHELLLE.JOLPGFABINK(JMBKDINHDLO, LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO));
		if (text == "{not_found}")
		{
			return EOBCOHIMMCF;
		}
		uint num = LKKNFHELLLE.MFBMHMCAAMA(JMBKDINHDLO, text, 16777216U);
		byte a = (byte)(num >> 24);
		byte r = (byte)(num >> 16);
		byte g = (byte)(num >> 8);
		byte b = (byte)num;
		return new Color32(r, g, b, a);
	}

	// Token: 0x0601291C RID: 76060 RVA: 0x00815D6C File Offset: 0x00813F6C
	private static string LIEIKBJJDHF(string JMBKDINHDLO, uint DCCPCBLODIG)
	{
		byte[] bytes = BitConverter.GetBytes(DCCPCBLODIG);
		return LKKNFHELLLE.CEDPOBKEDCE(JMBKDINHDLO, bytes, LKKNFHELLLE.KJEKIALFPGO.Color);
	}

	// Token: 0x0601291D RID: 76061 RVA: 0x00815D89 File Offset: 0x00813F89
	public static void KDHBOJNNKLI(string JMBKDINHDLO, Rect DCCPCBLODIG)
	{
		PlayerPrefs.SetString(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO), LKKNFHELLLE.KHJFHOLEHCF(JMBKDINHDLO, DCCPCBLODIG));
	}

	// Token: 0x0601291E RID: 76062 RVA: 0x00815D9D File Offset: 0x00813F9D
	public static Rect OOJEDABANPH(string JMBKDINHDLO)
	{
		return LKKNFHELLLE.OOJEDABANPH(JMBKDINHDLO, new Rect(0f, 0f, 0f, 0f));
	}

	// Token: 0x0601291F RID: 76063 RVA: 0x00815DC0 File Offset: 0x00813FC0
	public static Rect OOJEDABANPH(string JMBKDINHDLO, Rect EOBCOHIMMCF)
	{
		string text = LKKNFHELLLE.JOLPGFABINK(JMBKDINHDLO, LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO));
		if (!(text == "{not_found}"))
		{
			return LKKNFHELLLE.AILLKLBIHLP(JMBKDINHDLO, text, EOBCOHIMMCF);
		}
		return EOBCOHIMMCF;
	}

	// Token: 0x06012920 RID: 76064 RVA: 0x00815DF4 File Offset: 0x00813FF4
	private static string KHJFHOLEHCF(string JMBKDINHDLO, Rect DCCPCBLODIG)
	{
		byte[] array = new byte[16];
		Buffer.BlockCopy(BitConverter.GetBytes(DCCPCBLODIG.x), 0, array, 0, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(DCCPCBLODIG.y), 0, array, 4, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(DCCPCBLODIG.width), 0, array, 8, 4);
		Buffer.BlockCopy(BitConverter.GetBytes(DCCPCBLODIG.height), 0, array, 12, 4);
		return LKKNFHELLLE.CEDPOBKEDCE(JMBKDINHDLO, array, LKKNFHELLLE.KJEKIALFPGO.Rect);
	}

	// Token: 0x06012921 RID: 76065 RVA: 0x00815E68 File Offset: 0x00814068
	private static Rect AILLKLBIHLP(string JMBKDINHDLO, string CLLLKAFOHGF, Rect EOBCOHIMMCF)
	{
		if (CLLLKAFOHGF.IndexOf(':') > -1)
		{
			string text = LKKNFHELLLE.OHJBHBOBNOB(CLLLKAFOHGF);
			if (text == "")
			{
				return EOBCOHIMMCF;
			}
			string[] array = text.Split(new char[]
			{
				"|"[0]
			});
			float x;
			float.TryParse(array[0], out x);
			float y;
			float.TryParse(array[1], out y);
			float width;
			float.TryParse(array[2], out width);
			float height;
			float.TryParse(array[3], out height);
			Rect rect = new Rect(x, y, width, height);
			LKKNFHELLLE.KDHBOJNNKLI(JMBKDINHDLO, rect);
			return rect;
		}
		else
		{
			byte[] array2 = LKKNFHELLLE.BBNMNNLFINM(JMBKDINHDLO, CLLLKAFOHGF);
			if (array2 == null)
			{
				return EOBCOHIMMCF;
			}
			return new Rect
			{
				x = BitConverter.ToSingle(array2, 0),
				y = BitConverter.ToSingle(array2, 4),
				width = BitConverter.ToSingle(array2, 8),
				height = BitConverter.ToSingle(array2, 12)
			};
		}
	}

	// Token: 0x06012922 RID: 76066 RVA: 0x00815F43 File Offset: 0x00814143
	public static void MMCKALNDPIJ(string JMBKDINHDLO, string NMKFMLGHEMN)
	{
		PlayerPrefs.SetString(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO), NMKFMLGHEMN);
	}

	// Token: 0x06012923 RID: 76067 RVA: 0x00815F51 File Offset: 0x00814151
	public static string EKBFGGJDNKC(string JMBKDINHDLO)
	{
		return PlayerPrefs.GetString(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO));
	}

	// Token: 0x06012924 RID: 76068 RVA: 0x00815F60 File Offset: 0x00814160
	internal static LKKNFHELLLE.KJEKIALFPGO NELLHFOCFCH(string DCCPCBLODIG)
	{
		LKKNFHELLLE.KJEKIALFPGO result = LKKNFHELLLE.KJEKIALFPGO.Unknown;
		byte[] array;
		try
		{
			array = Convert.FromBase64String(DCCPCBLODIG);
		}
		catch (Exception)
		{
			return result;
		}
		if (array.Length < 7)
		{
			return result;
		}
		int num = array.Length;
		result = (LKKNFHELLLE.KJEKIALFPGO)array[num - 7];
		if (array[num - 6] > 10)
		{
			result = LKKNFHELLLE.KJEKIALFPGO.Unknown;
		}
		return result;
	}

	// Token: 0x06012925 RID: 76069 RVA: 0x00815FB0 File Offset: 0x008141B0
	internal static string KJHNGOPLDBM(string JMBKDINHDLO)
	{
		JMBKDINHDLO = ObscuredString.KOJLJMMMJGP(JMBKDINHDLO, LKKNFHELLLE.MDEFDNBJHMP);
		JMBKDINHDLO = Convert.ToBase64String(Encoding.UTF8.GetBytes(JMBKDINHDLO));
		return JMBKDINHDLO;
	}

	// Token: 0x06012926 RID: 76070 RVA: 0x00815FD2 File Offset: 0x008141D2
	public static bool PBKNGKHCOIE(string JMBKDINHDLO)
	{
		return PlayerPrefs.HasKey(JMBKDINHDLO) || PlayerPrefs.HasKey(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO));
	}

	// Token: 0x06012927 RID: 76071 RVA: 0x00815FE9 File Offset: 0x008141E9
	public static void GAFPPAKNHEL(string JMBKDINHDLO)
	{
		PlayerPrefs.DeleteKey(LKKNFHELLLE.KJHNGOPLDBM(JMBKDINHDLO));
		if (!LKKNFHELLLE.FFNCFECPDBD)
		{
			PlayerPrefs.DeleteKey(JMBKDINHDLO);
		}
	}

	// Token: 0x06012928 RID: 76072 RVA: 0x00816003 File Offset: 0x00814203
	public static void ECAEMFPMNFG()
	{
		PlayerPrefs.DeleteAll();
	}

	// Token: 0x06012929 RID: 76073 RVA: 0x0081600A File Offset: 0x0081420A
	public static void FPGAGIMIMPP()
	{
		PlayerPrefs.Save();
	}

	// Token: 0x0601292A RID: 76074 RVA: 0x00816011 File Offset: 0x00814211
	private static string JOLPGFABINK(string JMBKDINHDLO, string GFMEALEPEMA)
	{
		string @string = PlayerPrefs.GetString(GFMEALEPEMA, "{not_found}");
		if (@string == "{not_found}" && PlayerPrefs.HasKey(JMBKDINHDLO))
		{
			Debug.LogWarning("[ACTk] Are you trying to read regular PlayerPrefs data using ObscuredPrefs (key = " + JMBKDINHDLO + ")?");
		}
		return @string;
	}

	// Token: 0x0601292B RID: 76075 RVA: 0x00816048 File Offset: 0x00814248
	private static string CEDPOBKEDCE(string JMBKDINHDLO, byte[] NENCFDHMENA, LKKNFHELLLE.KJEKIALFPGO DFBHMIIPLCA)
	{
		int num = NENCFDHMENA.Length;
		Array src = LKKNFHELLLE.JPFHPNBENOL(NENCFDHMENA, num, JMBKDINHDLO + LKKNFHELLLE.MDEFDNBJHMP);
		uint num2 = LOLNFMHOOJM.PDIJFNMAKCN(NENCFDHMENA, num, 0U);
		byte[] src2 = new byte[]
		{
			(byte)(num2 & 255U),
			(byte)(num2 >> 8 & 255U),
			(byte)(num2 >> 16 & 255U),
			(byte)(num2 >> 24 & 255U)
		};
		byte[] array = null;
		int num3;
		if (LKKNFHELLLE.KCPLDHCMPKH != LKKNFHELLLE.MDFJCGDICEB.None)
		{
			num3 = num + 11;
			uint num4 = LKKNFHELLLE.CKCHAMMENPN;
			array = new byte[]
			{
				(byte)(num4 & 255U),
				(byte)(num4 >> 8 & 255U),
				(byte)(num4 >> 16 & 255U),
				(byte)(num4 >> 24 & 255U)
			};
		}
		else
		{
			num3 = num + 7;
		}
		byte[] array2 = new byte[num3];
		Buffer.BlockCopy(src, 0, array2, 0, num);
		if (array != null)
		{
			Buffer.BlockCopy(array, 0, array2, num, 4);
		}
		array2[num3 - 7] = (byte)DFBHMIIPLCA;
		array2[num3 - 6] = 2;
		array2[num3 - 5] = (byte)LKKNFHELLLE.KCPLDHCMPKH;
		Buffer.BlockCopy(src2, 0, array2, num3 - 4, 4);
		return Convert.ToBase64String(array2);
	}

	// Token: 0x0601292C RID: 76076 RVA: 0x00816160 File Offset: 0x00814360
	internal static byte[] BBNMNNLFINM(string JMBKDINHDLO, string CLLLKAFOHGF)
	{
		byte[] array;
		try
		{
			array = Convert.FromBase64String(CLLLKAFOHGF);
		}
		catch (Exception)
		{
			LKKNFHELLLE.NIDEBOIFEPG();
			return null;
		}
		if (array.Length == 0)
		{
			LKKNFHELLLE.NIDEBOIFEPG();
			return null;
		}
		int num = array.Length;
		if (array[num - 6] != 2)
		{
			LKKNFHELLLE.NIDEBOIFEPG();
			return null;
		}
		LKKNFHELLLE.MDFJCGDICEB mdfjcgdiceb = (LKKNFHELLLE.MDFJCGDICEB)array[num - 5];
		byte[] array2 = new byte[4];
		Buffer.BlockCopy(array, num - 4, array2, 0, 4);
		uint num2 = (uint)((int)array2[0] | (int)array2[1] << 8 | (int)array2[2] << 16 | (int)array2[3] << 24);
		uint num3 = 0U;
		int num4;
		if (mdfjcgdiceb != LKKNFHELLLE.MDFJCGDICEB.None)
		{
			num4 = num - 11;
			if (LKKNFHELLLE.KCPLDHCMPKH != LKKNFHELLLE.MDFJCGDICEB.None)
			{
				byte[] array3 = new byte[4];
				Buffer.BlockCopy(array, num4, array3, 0, 4);
				num3 = (uint)((int)array3[0] | (int)array3[1] << 8 | (int)array3[2] << 16 | (int)array3[3] << 24);
			}
		}
		else
		{
			num4 = num - 7;
		}
		byte[] array4 = new byte[num4];
		Buffer.BlockCopy(array, 0, array4, 0, num4);
		byte[] array5 = LKKNFHELLLE.JPFHPNBENOL(array4, num4, JMBKDINHDLO + LKKNFHELLLE.MDEFDNBJHMP);
		if (LOLNFMHOOJM.PDIJFNMAKCN(array5, num4, 0U) != num2)
		{
			LKKNFHELLLE.NIDEBOIFEPG();
			return null;
		}
		if (LKKNFHELLLE.KCPLDHCMPKH == LKKNFHELLLE.MDFJCGDICEB.Strict && num3 == 0U && !LKKNFHELLLE.AFLFABDJICP && !LKKNFHELLLE.LFPFOIEMLPL)
		{
			return null;
		}
		if (num3 != 0U && !LKKNFHELLLE.AFLFABDJICP)
		{
			uint num5 = LKKNFHELLLE.CKCHAMMENPN;
			if (num3 != num5)
			{
				LKKNFHELLLE.HDGLLOOJOLC();
				if (!LKKNFHELLLE.LFPFOIEMLPL)
				{
					return null;
				}
			}
		}
		return array5;
	}

	// Token: 0x0601292D RID: 76077 RVA: 0x008162B8 File Offset: 0x008144B8
	private static uint BDAAIFPGCCP(string NFKFMIIAKFN)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(NFKFMIIAKFN + LKKNFHELLLE.MDEFDNBJHMP);
		return LOLNFMHOOJM.PDIJFNMAKCN(bytes, bytes.Length, 0U);
	}

	// Token: 0x0601292E RID: 76078 RVA: 0x008162D8 File Offset: 0x008144D8
	private static void NIDEBOIFEPG()
	{
		if (LKKNFHELLLE.HKHLNCHNCMM != null)
		{
			LKKNFHELLLE.HKHLNCHNCMM();
			LKKNFHELLLE.HKHLNCHNCMM = null;
		}
	}

	// Token: 0x0601292F RID: 76079 RVA: 0x008162F1 File Offset: 0x008144F1
	private static void HDGLLOOJOLC()
	{
		if (LKKNFHELLLE.AAFEJOEEKHD != null && !LKKNFHELLLE.KNCEHGNNIPM)
		{
			LKKNFHELLLE.KNCEHGNNIPM = true;
			LKKNFHELLLE.AAFEJOEEKHD();
		}
	}

	// Token: 0x06012930 RID: 76080 RVA: 0x00816314 File Offset: 0x00814514
	private static string KJMCCCNAPKM()
	{
		string text = "";
		if (string.IsNullOrEmpty(text))
		{
			text = SystemInfo.deviceUniqueIdentifier;
		}
		return text;
	}

	// Token: 0x06012931 RID: 76081 RVA: 0x00816338 File Offset: 0x00814538
	private static byte[] JPFHPNBENOL(byte[] KGOOLPNJNPN, int OCEGOAFCLBP, string JMBKDINHDLO)
	{
		int length = JMBKDINHDLO.Length;
		byte[] array = new byte[OCEGOAFCLBP];
		for (int i = 0; i < OCEGOAFCLBP; i++)
		{
			array[i] = (byte)((char)KGOOLPNJNPN[i] ^ JMBKDINHDLO[i % length]);
		}
		return array;
	}

	// Token: 0x06012932 RID: 76082 RVA: 0x00816374 File Offset: 0x00814574
	private static string OHJBHBOBNOB(string DCCPCBLODIG)
	{
		string[] array = DCCPCBLODIG.Split(new char[]
		{
			':'
		});
		if (array.Length < 2)
		{
			LKKNFHELLLE.NIDEBOIFEPG();
			return "";
		}
		string text = array[0];
		string a = array[1];
		byte[] array2;
		try
		{
			array2 = Convert.FromBase64String(text);
		}
		catch
		{
			LKKNFHELLLE.NIDEBOIFEPG();
			return "";
		}
		string result = ObscuredString.KOJLJMMMJGP(Encoding.UTF8.GetString(array2, 0, array2.Length), LKKNFHELLLE.MDEFDNBJHMP);
		if (array.Length == 3)
		{
			if (a != LKKNFHELLLE.LPJIKLNFIIA(text + LKKNFHELLLE.JLGEKIJDKNL))
			{
				LKKNFHELLLE.NIDEBOIFEPG();
			}
		}
		else if (array.Length == 2)
		{
			if (a != LKKNFHELLLE.LPJIKLNFIIA(text))
			{
				LKKNFHELLLE.NIDEBOIFEPG();
			}
		}
		else
		{
			LKKNFHELLLE.NIDEBOIFEPG();
		}
		if (LKKNFHELLLE.KCPLDHCMPKH != LKKNFHELLLE.MDFJCGDICEB.None && !LKKNFHELLLE.AFLFABDJICP)
		{
			if (array.Length >= 3)
			{
				if (array[2] != LKKNFHELLLE.JLGEKIJDKNL)
				{
					if (!LKKNFHELLLE.LFPFOIEMLPL)
					{
						result = "";
					}
					LKKNFHELLLE.HDGLLOOJOLC();
				}
			}
			else if (LKKNFHELLLE.KCPLDHCMPKH == LKKNFHELLLE.MDFJCGDICEB.Strict)
			{
				if (!LKKNFHELLLE.LFPFOIEMLPL)
				{
					result = "";
				}
				LKKNFHELLLE.HDGLLOOJOLC();
			}
			else if (a != LKKNFHELLLE.LPJIKLNFIIA(text))
			{
				if (!LKKNFHELLLE.LFPFOIEMLPL)
				{
					result = "";
				}
				LKKNFHELLLE.HDGLLOOJOLC();
			}
		}
		return result;
	}

	// Token: 0x06012933 RID: 76083 RVA: 0x008164B4 File Offset: 0x008146B4
	private static string LPJIKLNFIIA(string NFKFMIIAKFN)
	{
		int num = 0;
		byte[] bytes = Encoding.UTF8.GetBytes(NFKFMIIAKFN + LKKNFHELLLE.MDEFDNBJHMP);
		int num2 = bytes.Length;
		int num3 = LKKNFHELLLE.MDEFDNBJHMP.Length ^ 64;
		for (int i = 0; i < num2; i++)
		{
			byte b = bytes[i];
			num += (int)b + (int)b * (i + num3) % 3;
		}
		return num.ToString("X2");
	}

	// Token: 0x17000416 RID: 1046
	// (get) Token: 0x06012934 RID: 76084 RVA: 0x0081651C File Offset: 0x0081471C
	private static string JLGEKIJDKNL
	{
		get
		{
			if (string.IsNullOrEmpty(LKKNFHELLLE.DALBBOGHAJP))
			{
				LKKNFHELLLE.DALBBOGHAJP = LKKNFHELLLE.LPJIKLNFIIA(LKKNFHELLLE.GDFOCCHNMBH);
			}
			return LKKNFHELLLE.DALBBOGHAJP;
		}
	}

	// Token: 0x04002621 RID: 9761
	private const byte JEGJPNLGHHG = 2;

	// Token: 0x04002622 RID: 9762
	private static bool KNCEHGNNIPM;

	// Token: 0x04002623 RID: 9763
	private static string MDEFDNBJHMP = "e806f6";

	// Token: 0x04002624 RID: 9764
	private static string MDACMIHCFGI;

	// Token: 0x04002625 RID: 9765
	private static uint JLHDBNKDIMM;

	// Token: 0x04002626 RID: 9766
	public static Action HKHLNCHNCMM;

	// Token: 0x04002627 RID: 9767
	public static bool FFNCFECPDBD = false;

	// Token: 0x04002628 RID: 9768
	public static Action AAFEJOEEKHD = null;

	// Token: 0x04002629 RID: 9769
	public static LKKNFHELLLE.MDFJCGDICEB KCPLDHCMPKH = LKKNFHELLLE.MDFJCGDICEB.None;

	// Token: 0x0400262A RID: 9770
	public static bool LFPFOIEMLPL = false;

	// Token: 0x0400262B RID: 9771
	public static bool AFLFABDJICP = false;

	// Token: 0x0400262C RID: 9772
	private const char HJKGHFLHJBN = ':';

	// Token: 0x0400262D RID: 9773
	private static string DALBBOGHAJP;

	// Token: 0x0400262E RID: 9774
	private static string FAPICMADIKN = "{not_found}";

	// Token: 0x0400262F RID: 9775
	private static string MFENJEMMNDC = "|";

	// Token: 0x02000587 RID: 1415
	internal enum KJEKIALFPGO : byte
	{
		// Token: 0x04002631 RID: 9777
		Unknown,
		// Token: 0x04002632 RID: 9778
		Int = 5,
		// Token: 0x04002633 RID: 9779
		UInt = 10,
		// Token: 0x04002634 RID: 9780
		String = 15,
		// Token: 0x04002635 RID: 9781
		Float = 20,
		// Token: 0x04002636 RID: 9782
		Double = 25,
		// Token: 0x04002637 RID: 9783
		Decimal = 27,
		// Token: 0x04002638 RID: 9784
		Long = 30,
		// Token: 0x04002639 RID: 9785
		ULong = 32,
		// Token: 0x0400263A RID: 9786
		Bool = 35,
		// Token: 0x0400263B RID: 9787
		ByteArray = 40,
		// Token: 0x0400263C RID: 9788
		Vector2 = 45,
		// Token: 0x0400263D RID: 9789
		Vector3 = 50,
		// Token: 0x0400263E RID: 9790
		Quaternion = 55,
		// Token: 0x0400263F RID: 9791
		Color = 60,
		// Token: 0x04002640 RID: 9792
		Rect = 65
	}

	// Token: 0x02000588 RID: 1416
	public enum MDFJCGDICEB : byte
	{
		// Token: 0x04002642 RID: 9794
		None,
		// Token: 0x04002643 RID: 9795
		Soft,
		// Token: 0x04002644 RID: 9796
		Strict
	}
}
