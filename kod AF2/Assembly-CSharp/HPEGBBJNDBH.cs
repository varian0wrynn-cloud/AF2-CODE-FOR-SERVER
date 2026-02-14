using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x0200052F RID: 1327
public sealed class HPEGBBJNDBH : CFPOKEIJEAB<UserLutModel>
{
	// Token: 0x0601192B RID: 71979 RVA: 0x007E03CC File Offset: 0x007DE5CC
	public void OLBDOHCILKO()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.KHBPABICFOF();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.ELBPIDDFKFF().x * (float)Screen.width + 1105f, 1193f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x0601192C RID: 71980 RVA: 0x007E0434 File Offset: 0x007DE634
	public void AIFLGKMMKBI(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.JOAPKCFMLDO();
		OOLNAJMJKIK.EnableKeyword("Positions");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(1139f / (float)settings.lut.width, 296f / (float)settings.lut.height, (float)settings.lut.height - 1164f, settings.contribution));
	}

	// Token: 0x0601192D RID: 71981 RVA: 0x007E04B8 File Offset: 0x007DE6B8
	public void JBGGMKEKOAN()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.FPLLFOMFIDF();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.IKKMHNLCLJD().x * (float)Screen.width + 1784f, 999f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x0601192E RID: 71982 RVA: 0x007E0520 File Offset: 0x007DE720
	public void EMNMOMGOBPI()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.GJNMNCOFKEP();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.PNAKKADMMOE().x * (float)Screen.width + 214f, 347f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x0601192F RID: 71983 RVA: 0x007E0588 File Offset: 0x007DE788
	public override void FBBBNHPGBKC(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.settings;
		OOLNAJMJKIK.EnableKeyword("USER_LUT");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(1f / (float)settings.lut.width, 1f / (float)settings.lut.height, (float)settings.lut.height - 1f, settings.contribution));
	}

	// Token: 0x06011930 RID: 71984 RVA: 0x007E060C File Offset: 0x007DE80C
	public void BCJFDHBDAHD()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.JCNCKIKPIKG();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.EGDBMHIALLP().x * (float)Screen.width + 1745f, 1530f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x06011931 RID: 71985 RVA: 0x007E0674 File Offset: 0x007DE874
	public bool PLHOMLDDDHI()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.FENHJBHKCAG();
		return !base.BBEPCCALAFC.enabled || !(settings.lut != null) || settings.contribution <= 1828f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || !this.AMCOGJHPPOC.CHJAIAPCMDC();
	}

	// Token: 0x06011932 RID: 71986 RVA: 0x007E06E4 File Offset: 0x007DE8E4
	public bool GDHOPOMCFPE()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.BDPNPPMLHBM();
		return base.BBEPCCALAFC.enabled && settings.lut != null && settings.contribution > 999f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && this.AMCOGJHPPOC.ANFINECKHNH();
	}

	// Token: 0x06011933 RID: 71987 RVA: 0x007E0754 File Offset: 0x007DE954
	public void MBADKFPCOEJ()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.GOJNKFKPOKH();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.MNEDFKKLGGC().x * (float)Screen.width + 407f, 434f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x06011934 RID: 71988 RVA: 0x007E07BC File Offset: 0x007DE9BC
	public bool BNEAAFFAFOH()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.settings;
		return !base.BBEPCCALAFC.enabled || !(settings.lut != null) || settings.contribution <= 1267f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || !this.AMCOGJHPPOC.ACEEFEFOCDF();
	}

	// Token: 0x06011935 RID: 71989 RVA: 0x007E082C File Offset: 0x007DEA2C
	public bool GMJELGIOFCI()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.BOLPFGAMAED();
		return base.BBEPCCALAFC.enabled && settings.lut != null && settings.contribution > 1821f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && this.AMCOGJHPPOC.HALNOLGLEOJ();
	}

	// Token: 0x06011936 RID: 71990 RVA: 0x007E089C File Offset: 0x007DEA9C
	public void JDIJNBFGCFD(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.GOJNKFKPOKH();
		OOLNAJMJKIK.EnableKeyword("ObscuredPrefs vs PlayerPrefs, ");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(1183f / (float)settings.lut.width, 648f / (float)settings.lut.height, (float)settings.lut.height - 1834f, settings.contribution));
	}

	// Token: 0x06011937 RID: 71991 RVA: 0x007E0920 File Offset: 0x007DEB20
	public bool IKJICHPBCNM()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.BDPNPPMLHBM();
		return base.BBEPCCALAFC.enabled && settings.lut != null && settings.contribution > 265f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && !this.AMCOGJHPPOC.GCPDMBIEAOG();
	}

	// Token: 0x06011938 RID: 71992 RVA: 0x007E0990 File Offset: 0x007DEB90
	public void BILFPDPDGHG(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.settings;
		OOLNAJMJKIK.EnableKeyword("gi_um_lv");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(1526f / (float)settings.lut.width, 490f / (float)settings.lut.height, (float)settings.lut.height - 1014f, settings.contribution));
	}

	// Token: 0x06011939 RID: 71993 RVA: 0x007E0A14 File Offset: 0x007DEC14
	public void MJDKGMEPMHK()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.GJNMNCOFKEP();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.NOCONJONFLL().x * (float)Screen.width + 654f, 739f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x0601193A RID: 71994 RVA: 0x007E0A7C File Offset: 0x007DEC7C
	public void GLNBCLPECAM(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.KDHGJFOLJJF();
		OOLNAJMJKIK.EnableKeyword("IKSolverFABRIKRoot contains no chains.");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(1824f / (float)settings.lut.width, 867f / (float)settings.lut.height, (float)settings.lut.height - 1467f, settings.contribution));
	}

	// Token: 0x0601193B RID: 71995 RVA: 0x007E0B00 File Offset: 0x007DED00
	public void GIKMMGMKAIP(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.JPPMCPOBALN();
		OOLNAJMJKIK.EnableKeyword(" ");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(1902f / (float)settings.lut.width, 818f / (float)settings.lut.height, (float)settings.lut.height - 641f, settings.contribution));
	}

	// Token: 0x0601193C RID: 71996 RVA: 0x007E0B84 File Offset: 0x007DED84
	public bool MCGNCKIMFFH()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.JEPCJAANIDN();
		return !base.BBEPCCALAFC.enabled || !(settings.lut != null) || settings.contribution <= 806f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || !this.AMCOGJHPPOC.HKJHMGJGNHJ();
	}

	// Token: 0x0601193D RID: 71997 RVA: 0x007E0BF4 File Offset: 0x007DEDF4
	public void OHAOIIGGDBM(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.FPLLFOMFIDF();
		OOLNAJMJKIK.EnableKeyword("MENU.WAV");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(976f / (float)settings.lut.width, 762f / (float)settings.lut.height, (float)settings.lut.height - 356f, settings.contribution));
	}

	// Token: 0x0601193E RID: 71998 RVA: 0x007E0C78 File Offset: 0x007DEE78
	public bool GFFEFDJFMJC()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.settings;
		return base.BBEPCCALAFC.enabled && settings.lut != null && settings.contribution > 608f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && !this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x0601193F RID: 71999 RVA: 0x007E0CE8 File Offset: 0x007DEEE8
	public void ELFMPDIGDLJ()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.JEPCJAANIDN();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.ELBPIDDFKFF().x * (float)Screen.width + 1155f, 1307f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x06011940 RID: 72000 RVA: 0x007E0D50 File Offset: 0x007DEF50
	public void JEJGFDBHABC()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.FENHJBHKCAG();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.MMAHKGNMDEF().x * (float)Screen.width + 878f, 553f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x06011941 RID: 72001 RVA: 0x007E0DB8 File Offset: 0x007DEFB8
	public bool BHDPHLBMCGG()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.GOJNKFKPOKH();
		return !base.BBEPCCALAFC.enabled || !(settings.lut != null) || settings.contribution <= 857f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || this.AMCOGJHPPOC.ACEEFEFOCDF();
	}

	// Token: 0x06011942 RID: 72002 RVA: 0x007E0E28 File Offset: 0x007DF028
	public void ANFHJIIMJNL()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.settings;
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.EMBHPOAEALM.x * (float)Screen.width + 8f, 8f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x06011943 RID: 72003 RVA: 0x007E0E90 File Offset: 0x007DF090
	public void AGBEEDOOOHA()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.KHBPABICFOF();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.MBGEKMGINKB().x * (float)Screen.width + 11f, 676f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x06011944 RID: 72004 RVA: 0x007E0EF8 File Offset: 0x007DF0F8
	public void NPCNGFAIKII(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.HMCGGODBANJ();
		OOLNAJMJKIK.EnableKeyword("crft_from");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(1188f / (float)settings.lut.width, 1940f / (float)settings.lut.height, (float)settings.lut.height - 778f, settings.contribution));
	}

	// Token: 0x06011945 RID: 72005 RVA: 0x007E0F7C File Offset: 0x007DF17C
	public void GEBNGMPHOGG(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.KDHGJFOLJJF();
		OOLNAJMJKIK.EnableKeyword("RollerBladeCrossoverRight");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(189f / (float)settings.lut.width, 995f / (float)settings.lut.height, (float)settings.lut.height - 436f, settings.contribution));
	}

	// Token: 0x06011946 RID: 72006 RVA: 0x007E1000 File Offset: 0x007DF200
	public bool ABDJCLLOHFB()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.settings;
		return base.BBEPCCALAFC.enabled && settings.lut != null && settings.contribution > 881f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && this.AMCOGJHPPOC.MLMGNHHAOHF();
	}

	// Token: 0x06011947 RID: 72007 RVA: 0x007E1070 File Offset: 0x007DF270
	public void KFNKFHMKFHE(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.JCNCKIKPIKG();
		OOLNAJMJKIK.EnableKeyword("cht_msg24");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(476f / (float)settings.lut.width, 1608f / (float)settings.lut.height, (float)settings.lut.height - 138f, settings.contribution));
	}

	// Token: 0x06011948 RID: 72008 RVA: 0x007E10F4 File Offset: 0x007DF2F4
	public bool IINCJJIOKML()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.CIMGEKFAAGC();
		return base.BBEPCCALAFC.enabled && settings.lut != null && settings.contribution > 304f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x06011949 RID: 72009 RVA: 0x007E1164 File Offset: 0x007DF364
	public void KAGBHGJKCHK()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.KHBPABICFOF();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.LKGIPCPDFLE().x * (float)Screen.width + 1085f, 374f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x0601194A RID: 72010 RVA: 0x007E11CC File Offset: 0x007DF3CC
	public void BBGAONKBIPJ()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.BOLPFGAMAED();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.AICCPACEFOK().x * (float)Screen.width + 1775f, 1105f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x0601194B RID: 72011 RVA: 0x007E1234 File Offset: 0x007DF434
	public void KIMPBABLLHK(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.PNNGLBOIIMH();
		OOLNAJMJKIK.EnableKeyword("[ACTk] <b>[ ObscuredInt test ]</b>");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(1620f / (float)settings.lut.width, 453f / (float)settings.lut.height, (float)settings.lut.height - 708f, settings.contribution));
	}

	// Token: 0x0601194C RID: 72012 RVA: 0x007E12B8 File Offset: 0x007DF4B8
	public void IGFAFJCIEFM(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.JEPCJAANIDN();
		OOLNAJMJKIK.EnableKeyword("ElvisLegsLoop");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(1883f / (float)settings.lut.width, 1923f / (float)settings.lut.height, (float)settings.lut.height - 1657f, settings.contribution));
	}

	// Token: 0x0601194D RID: 72013 RVA: 0x007E133C File Offset: 0x007DF53C
	public bool NEBBCDKDNOE()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.HMCGGODBANJ();
		return !base.BBEPCCALAFC.enabled || !(settings.lut != null) || settings.contribution <= 1936f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x0601194E RID: 72014 RVA: 0x007E13AC File Offset: 0x007DF5AC
	public bool INFHBOFCIBG()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.CIMGEKFAAGC();
		return !base.BBEPCCALAFC.enabled || !(settings.lut != null) || settings.contribution <= 1167f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || !this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x0601194F RID: 72015 RVA: 0x007E141C File Offset: 0x007DF61C
	public bool FNHNEJNNKOJ()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.BOLPFGAMAED();
		return base.BBEPCCALAFC.enabled && settings.lut != null && settings.contribution > 1761f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && !this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x170003D4 RID: 980
	// (get) Token: 0x06011950 RID: 72016 RVA: 0x007E148C File Offset: 0x007DF68C
	public override bool NLFEIOCKHKA
	{
		get
		{
			UserLutModel.Settings settings = base.BBEPCCALAFC.settings;
			return base.BBEPCCALAFC.enabled && settings.lut != null && settings.contribution > 0f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && !this.AMCOGJHPPOC.CFABOAAPLPI;
		}
	}

	// Token: 0x06011951 RID: 72017 RVA: 0x007E14FC File Offset: 0x007DF6FC
	public void IIAJGMCJJMI(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.GNKFCHPIOAG();
		OOLNAJMJKIK.EnableKeyword("kfB");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(229f / (float)settings.lut.width, 1729f / (float)settings.lut.height, (float)settings.lut.height - 1942f, settings.contribution));
	}

	// Token: 0x06011952 RID: 72018 RVA: 0x007E1580 File Offset: 0x007DF780
	public bool BLNBICKCGID()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.FEJJFMHMNHK();
		return base.BBEPCCALAFC.enabled && settings.lut != null && settings.contribution > 1197f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && this.AMCOGJHPPOC.HFIFOAPFKBG();
	}

	// Token: 0x06011953 RID: 72019 RVA: 0x007E15F0 File Offset: 0x007DF7F0
	public void IFFDENKOGCH(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.JEPCJAANIDN();
		OOLNAJMJKIK.EnableKeyword("B");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(1230f / (float)settings.lut.width, 946f / (float)settings.lut.height, (float)settings.lut.height - 964f, settings.contribution));
	}

	// Token: 0x06011954 RID: 72020 RVA: 0x007E1674 File Offset: 0x007DF874
	public void PHKDFDFDONF(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.JPPMCPOBALN();
		OOLNAJMJKIK.EnableKeyword("drag_onmousedown.wav");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(439f / (float)settings.lut.width, 482f / (float)settings.lut.height, (float)settings.lut.height - 385f, settings.contribution));
	}

	// Token: 0x06011955 RID: 72021 RVA: 0x007E16F8 File Offset: 0x007DF8F8
	public void LPDJCNBEOIC(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.JCNCKIKPIKG();
		OOLNAJMJKIK.EnableKeyword("_BlurRadius4");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(707f / (float)settings.lut.width, 733f / (float)settings.lut.height, (float)settings.lut.height - 966f, settings.contribution));
	}

	// Token: 0x06011956 RID: 72022 RVA: 0x007E177C File Offset: 0x007DF97C
	public void OKICICGNAFP()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.FEJJFMHMNHK();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.DGFDODAHBKE().x * (float)Screen.width + 1195f, 356f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x06011957 RID: 72023 RVA: 0x007E17E4 File Offset: 0x007DF9E4
	public void GCLIPIADIPD()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.CIMGEKFAAGC();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.CDCHJMABKLC().x * (float)Screen.width + 281f, 974f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x06011958 RID: 72024 RVA: 0x007E184C File Offset: 0x007DFA4C
	public bool MNIFEJMMKOD()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.JPPMCPOBALN();
		return base.BBEPCCALAFC.enabled && settings.lut != null && settings.contribution > 1060f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && !this.AMCOGJHPPOC.ACEEFEFOCDF();
	}

	// Token: 0x06011959 RID: 72025 RVA: 0x007E18BC File Offset: 0x007DFABC
	public void IJPHJGHKPPG(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.CIMGEKFAAGC();
		OOLNAJMJKIK.EnableKeyword("Flap_08.wav");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(537f / (float)settings.lut.width, 1908f / (float)settings.lut.height, (float)settings.lut.height - 1059f, settings.contribution));
	}

	// Token: 0x0601195A RID: 72026 RVA: 0x007E1940 File Offset: 0x007DFB40
	public bool NAKPIFMDCPH()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.BDPNPPMLHBM();
		return !base.BBEPCCALAFC.enabled || !(settings.lut != null) || settings.contribution <= 1010f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || this.AMCOGJHPPOC.POJLMOPEBLN();
	}

	// Token: 0x0601195B RID: 72027 RVA: 0x007E19B0 File Offset: 0x007DFBB0
	public bool MJPDFPDEDHN()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.CIMGEKFAAGC();
		return base.BBEPCCALAFC.enabled && settings.lut != null && settings.contribution > 1512f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && this.AMCOGJHPPOC.MLMGNHHAOHF();
	}

	// Token: 0x0601195C RID: 72028 RVA: 0x007E1A20 File Offset: 0x007DFC20
	public void EKGAPKNAKAD(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.HMCGGODBANJ();
		OOLNAJMJKIK.EnableKeyword("_HitPosition");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(933f / (float)settings.lut.width, 69f / (float)settings.lut.height, (float)settings.lut.height - 953f, settings.contribution));
	}

	// Token: 0x0601195D RID: 72029 RVA: 0x007E1AA4 File Offset: 0x007DFCA4
	public void JFAJCPPAMFD(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.KDHGJFOLJJF();
		OOLNAJMJKIK.EnableKeyword("_FogParams");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(774f / (float)settings.lut.width, 1860f / (float)settings.lut.height, (float)settings.lut.height - 98f, settings.contribution));
	}

	// Token: 0x0601195E RID: 72030 RVA: 0x007E1B28 File Offset: 0x007DFD28
	public void CKIENEMPGLL(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.BOLPFGAMAED();
		OOLNAJMJKIK.EnableKeyword("Invalid IKEffector.positionOffset (contains Infinity)! Please make sure not to set IKEffector.positionOffset to infinite values.");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(684f / (float)settings.lut.width, 1516f / (float)settings.lut.height, (float)settings.lut.height - 276f, settings.contribution));
	}

	// Token: 0x0601195F RID: 72031 RVA: 0x007E1BAC File Offset: 0x007DFDAC
	public void MCKPBNDIOJF(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.BOLPFGAMAED();
		OOLNAJMJKIK.EnableKeyword("Sitting Reading Lean Back");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(1910f / (float)settings.lut.width, 1518f / (float)settings.lut.height, (float)settings.lut.height - 1842f, settings.contribution));
	}

	// Token: 0x06011960 RID: 72032 RVA: 0x007E1C30 File Offset: 0x007DFE30
	public bool LEKGGIMIPLH()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.CIMGEKFAAGC();
		return base.BBEPCCALAFC.enabled && settings.lut != null && settings.contribution > 1912f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && !this.AMCOGJHPPOC.POJLMOPEBLN();
	}

	// Token: 0x06011961 RID: 72033 RVA: 0x007E1CA0 File Offset: 0x007DFEA0
	public void KIEFPGLDOCD()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.FEJJFMHMNHK();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.MNEDFKKLGGC().x * (float)Screen.width + 1480f, 1054f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x06011962 RID: 72034 RVA: 0x007E1D08 File Offset: 0x007DFF08
	public bool JHHOEHKKPEI()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.BDPNPPMLHBM();
		return base.BBEPCCALAFC.enabled && settings.lut != null && settings.contribution > 1933f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && this.AMCOGJHPPOC.HKJHMGJGNHJ();
	}

	// Token: 0x06011963 RID: 72035 RVA: 0x007E1D78 File Offset: 0x007DFF78
	public bool ICGMMGHLHLK()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.FEJJFMHMNHK();
		return base.BBEPCCALAFC.enabled && settings.lut != null && settings.contribution > 927f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x06011964 RID: 72036 RVA: 0x007E1DE8 File Offset: 0x007DFFE8
	public void ADMNABCIDEO(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.settings;
		OOLNAJMJKIK.EnableKeyword("UIChat_pos");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(71f / (float)settings.lut.width, 1374f / (float)settings.lut.height, (float)settings.lut.height - 41f, settings.contribution));
	}

	// Token: 0x06011965 RID: 72037 RVA: 0x007E1E6C File Offset: 0x007E006C
	public bool GIAKLNBJHDH()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.FENHJBHKCAG();
		return base.BBEPCCALAFC.enabled && settings.lut != null && settings.contribution > 300f && settings.lut.height == (int)Mathf.Sqrt((float)settings.lut.width) && !this.AMCOGJHPPOC.AFIPEFLJBBM();
	}

	// Token: 0x06011966 RID: 72038 RVA: 0x007E1EDC File Offset: 0x007E00DC
	public void CGBKGPPNMNM()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.BOLPFGAMAED();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.MNEDFKKLGGC().x * (float)Screen.width + 1704f, 990f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x06011967 RID: 72039 RVA: 0x007E1F44 File Offset: 0x007E0144
	public void NHIMBCNMMCF(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.GOJNKFKPOKH();
		OOLNAJMJKIK.EnableKeyword("DISTORT");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(652f / (float)settings.lut.width, 914f / (float)settings.lut.height, (float)settings.lut.height - 591f, settings.contribution));
	}

	// Token: 0x06011968 RID: 72040 RVA: 0x007E1FC8 File Offset: 0x007E01C8
	public void KOJFFFMCCBO(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.GJNMNCOFKEP();
		OOLNAJMJKIK.EnableKeyword(" does not have any fingers, VRIK can not guess the hand bone's orientation.");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(1117f / (float)settings.lut.width, 24f / (float)settings.lut.height, (float)settings.lut.height - 797f, settings.contribution));
	}

	// Token: 0x06011969 RID: 72041 RVA: 0x007E204C File Offset: 0x007E024C
	public void NNFLMMOEGAK(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.HMCGGODBANJ();
		OOLNAJMJKIK.EnableKeyword(" ");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(1114f / (float)settings.lut.width, 1439f / (float)settings.lut.height, (float)settings.lut.height - 882f, settings.contribution));
	}

	// Token: 0x0601196B RID: 72043 RVA: 0x007E20D8 File Offset: 0x007E02D8
	public void GKFOFOCGPCC()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.settings;
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.ELBPIDDFKFF().x * (float)Screen.width + 512f, 50f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x0601196C RID: 72044 RVA: 0x007E2140 File Offset: 0x007E0340
	public bool HKCMJIIALMC()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.JEPCJAANIDN();
		return !base.BBEPCCALAFC.enabled || !(settings.lut != null) || settings.contribution <= 1907f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || this.AMCOGJHPPOC.MLJCADOONGI();
	}

	// Token: 0x0601196D RID: 72045 RVA: 0x007E21B0 File Offset: 0x007E03B0
	public bool HCHAKMMIMDN()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.JOAPKCFMLDO();
		return !base.BBEPCCALAFC.enabled || !(settings.lut != null) || settings.contribution <= 317f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || !this.AMCOGJHPPOC.POJLMOPEBLN();
	}

	// Token: 0x0601196E RID: 72046 RVA: 0x007E2220 File Offset: 0x007E0420
	public void OBAOPBPDAHK(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.FEJJFMHMNHK();
		OOLNAJMJKIK.EnableKeyword("WeaponInstant");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(1904f / (float)settings.lut.width, 1448f / (float)settings.lut.height, (float)settings.lut.height - 1512f, settings.contribution));
	}

	// Token: 0x0601196F RID: 72047 RVA: 0x007E22A4 File Offset: 0x007E04A4
	public void HEEFBALEGNI(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.BOLPFGAMAED();
		OOLNAJMJKIK.EnableKeyword("rollTENSIONKG=");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(235f / (float)settings.lut.width, 797f / (float)settings.lut.height, (float)settings.lut.height - 841f, settings.contribution));
	}

	// Token: 0x06011970 RID: 72048 RVA: 0x007E2328 File Offset: 0x007E0528
	public void PNAEIDCONFP()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.FEJJFMHMNHK();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.MNEDFKKLGGC().x * (float)Screen.width + 260f, 369f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x06011971 RID: 72049 RVA: 0x007E2390 File Offset: 0x007E0590
	public void NOLGBPGPBKL()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.settings;
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.AICCPACEFOK().x * (float)Screen.width + 285f, 748f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x06011972 RID: 72050 RVA: 0x007E23F8 File Offset: 0x007E05F8
	public void ADHEBPPFMOF()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.KHBPABICFOF();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.OEDLJOEJBDH().x * (float)Screen.width + 569f, 1432f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x06011973 RID: 72051 RVA: 0x007E2460 File Offset: 0x007E0660
	public void MCDMOIIEGOO(Material OOLNAJMJKIK)
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.settings;
		OOLNAJMJKIK.EnableKeyword("clavicle");
		OOLNAJMJKIK.SetTexture(HPEGBBJNDBH.ALMPJHHKGNL.ANFFADLBFBP, settings.lut);
		OOLNAJMJKIK.SetVector(HPEGBBJNDBH.ALMPJHHKGNL.LIABDIIFHCH, new Vector4(1216f / (float)settings.lut.width, 1768f / (float)settings.lut.height, (float)settings.lut.height - 604f, settings.contribution));
	}

	// Token: 0x06011974 RID: 72052 RVA: 0x007E24E4 File Offset: 0x007E06E4
	public void JJJNMPOAPAA()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.FEJJFMHMNHK();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.CDCHJMABKLC().x * (float)Screen.width + 1874f, 1802f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x06011975 RID: 72053 RVA: 0x007E254C File Offset: 0x007E074C
	public bool IHDIKFHMOLC()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.settings;
		return !base.BBEPCCALAFC.enabled || !(settings.lut != null) || settings.contribution <= 95f || settings.lut.height != (int)Mathf.Sqrt((float)settings.lut.width) || !this.AMCOGJHPPOC.GCPDMBIEAOG();
	}

	// Token: 0x06011976 RID: 72054 RVA: 0x007E25BC File Offset: 0x007E07BC
	public void JADGLEGEDGJ()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.GOJNKFKPOKH();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.EGDBMHIALLP().x * (float)Screen.width + 728f, 1925f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x06011977 RID: 72055 RVA: 0x007E2624 File Offset: 0x007E0824
	public void KMLAENJBADF()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.BDPNPPMLHBM();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.LKGIPCPDFLE().x * (float)Screen.width + 874f, 1669f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x06011978 RID: 72056 RVA: 0x007E268C File Offset: 0x007E088C
	public void JGAMNLOICJN()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.PNNGLBOIIMH();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.MMAHKGNMDEF().x * (float)Screen.width + 725f, 1325f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x06011979 RID: 72057 RVA: 0x007E26F4 File Offset: 0x007E08F4
	public void BLCDCEHNNNC()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.FENHJBHKCAG();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.MBGEKMGINKB().x * (float)Screen.width + 60f, 593f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x0601197A RID: 72058 RVA: 0x007E275C File Offset: 0x007E095C
	public void BIOKMDIGOIA()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.JPPMCPOBALN();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.DACGBMKNILJ().x * (float)Screen.width + 1197f, 27f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x0601197B RID: 72059 RVA: 0x007E27C4 File Offset: 0x007E09C4
	public void PBADPBBJBEJ()
	{
		UserLutModel.Settings settings = base.BBEPCCALAFC.JCNCKIKPIKG();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.LKGIPCPDFLE().x * (float)Screen.width + 1377f, 375f, (float)settings.lut.width, (float)settings.lut.height), settings.lut);
	}

	// Token: 0x02000530 RID: 1328
	private static class ALMPJHHKGNL
	{
		// Token: 0x040024CE RID: 9422
		internal static readonly int ANFFADLBFBP = Shader.PropertyToID("_UserLut");

		// Token: 0x040024CF RID: 9423
		internal static readonly int LIABDIIFHCH = Shader.PropertyToID("_UserLut_Params");
	}
}
