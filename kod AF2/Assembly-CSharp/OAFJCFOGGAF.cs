using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001EA RID: 490
public class OAFJCFOGGAF
{
	// Token: 0x06007106 RID: 28934 RVA: 0x00360528 File Offset: 0x0035E728
	public void LHFHJKLLHPO(string IABKGMNJLJO, int PBFNEPLIHGP = -1, long NGCJCDADLAE = 0L)
	{
		int num = this.BNDLJLCJCLO;
		if (PBFNEPLIHGP > 1)
		{
			num = PBFNEPLIHGP;
		}
		string lngffjihknp = "#606060";
		if (num == 1)
		{
			lngffjihknp = this.CAKMOAMPKAA;
		}
		if (num == -91)
		{
			lngffjihknp = "MotorbikeHandstand";
			num = 1;
		}
		if (num == 8)
		{
			lngffjihknp = "_InverseProj";
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(num);
			epmphjgalbe.OBJBHBFAFEE(NGCJCDADLAE);
			epmphjgalbe.BNPGKHHADEH(IABKGMNJLJO);
			epmphjgalbe.LKNDBBGMIOE(lngffjihknp);
			NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(15, epmphjgalbe.PBOPEDMCKDD());
		}
		finally
		{
			epmphjgalbe.NCKMEIBFNGL();
		}
	}

	// Token: 0x06007107 RID: 28935 RVA: 0x003605BC File Offset: 0x0035E7BC
	public void LBEMJLGMKFO(HBPNMNGOFMA KADBECGIMPD)
	{
		this.CAKMOAMPKAA = KADBECGIMPD.PNBECHOLCJM();
		this.BNDLJLCJCLO = KADBECGIMPD.LDLKLPJBIJN();
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = this.DMAOGCJLBDF(1, false);
		lnhmfjdmokp.PNLAPCGPDDL.Clear();
		lnhmfjdmokp.KBIHCAMGPMH(KADBECGIMPD);
		lnhmfjdmokp.PNLAPCGPDDL.Add(new OAFJCFOGGAF.PIGPIKMNNLH(lnhmfjdmokp, "</color>\n", JNBICAJIJMM.EDKGBBIIBBC().FLEANFGEJML(" ") + "_NAME" + this.CAKMOAMPKAA, false));
		if (ChatPanelLogic.getI != null)
		{
			ChatPanelLogic.getI.checkChannel(4);
		}
		Debug.Log("Toe" + this.CAKMOAMPKAA);
	}

	// Token: 0x06007108 RID: 28936 RVA: 0x0036065F File Offset: 0x0035E85F
	public bool JMCDKANKAOI(long LPFKFNLHGBI)
	{
		return this.JIKGMLGOAPG.ContainsKey(LPFKFNLHGBI) && this.ELEFJAEDJAK(LPFKFNLHGBI).EFFAHDKPOJA;
	}

	// Token: 0x06007109 RID: 28937 RVA: 0x00360680 File Offset: 0x0035E880
	public void DHKLMJADOOJ(HBPNMNGOFMA KADBECGIMPD)
	{
		this.CAKMOAMPKAA = KADBECGIMPD.BFPHBMDMODH();
		this.BNDLJLCJCLO = KADBECGIMPD.HDBGOLAFOBK();
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = this.MJGADELHFID(2, true);
		lnhmfjdmokp.PNLAPCGPDDL.Clear();
		lnhmfjdmokp.CNIBNDBFFDO(KADBECGIMPD);
		lnhmfjdmokp.PNLAPCGPDDL.Add(new OAFJCFOGGAF.PIGPIKMNNLH(lnhmfjdmokp, "SYS", JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("chatconnect") + " " + this.CAKMOAMPKAA, false));
		if (ChatPanelLogic.getI != null)
		{
			ChatPanelLogic.getI.checkChannel(2);
		}
		Debug.Log("********* connect to chat " + this.CAKMOAMPKAA);
	}

	// Token: 0x0600710A RID: 28938 RVA: 0x00360724 File Offset: 0x0035E924
	public void CPJCHPJIHHL(string IABKGMNJLJO)
	{
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = this.MJGADELHFID(1, true);
		OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh = new OAFJCFOGGAF.PIGPIKMNNLH(lnhmfjdmokp, "", IABKGMNJLJO, false);
		lnhmfjdmokp.PNLAPCGPDDL.Add(pigpikmnnlh);
		if (lnhmfjdmokp.PNLAPCGPDDL.Count > 20)
		{
			lnhmfjdmokp.PNLAPCGPDDL.RemoveAt(0);
		}
		this.GDMEEEMEBPD("OnChatMessage", pigpikmnnlh);
	}

	// Token: 0x0600710B RID: 28939 RVA: 0x0036077C File Offset: 0x0035E97C
	public OAFJCFOGGAF.EDPNAHLGHPL ANNFFDNGLBA(long LPFKFNLHGBI)
	{
		OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl;
		if (this.JIKGMLGOAPG.ContainsKey(LPFKFNLHGBI))
		{
			edpnahlghpl = this.JIKGMLGOAPG[LPFKFNLHGBI];
		}
		else
		{
			edpnahlghpl = new OAFJCFOGGAF.EDPNAHLGHPL();
			edpnahlghpl.LPFKFNLHGBI = LPFKFNLHGBI;
			this.JIKGMLGOAPG.Add(LPFKFNLHGBI, edpnahlghpl);
		}
		return edpnahlghpl;
	}

	// Token: 0x0600710C RID: 28940 RVA: 0x003607C4 File Offset: 0x0035E9C4
	public void LFCICFEGHMC(int PPICJOPPOLK)
	{
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = this.MJGADELHFID(PPICJOPPOLK, true);
		if (lnhmfjdmokp != null)
		{
			lnhmfjdmokp.PNLAPCGPDDL.Clear();
		}
	}

	// Token: 0x0600710D RID: 28941 RVA: 0x003607E8 File Offset: 0x0035E9E8
	public string DFHMFIAGEBG(int NDDLLPAIHGM)
	{
		return this.MJGADELHFID(NDDLLPAIHGM, true).ECIPMDEDPAO(true);
	}

	// Token: 0x0600710E RID: 28942 RVA: 0x003607F8 File Offset: 0x0035E9F8
	public void HJFHFPHNAJG(int PPICJOPPOLK)
	{
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = this.DMAOGCJLBDF(PPICJOPPOLK, false);
		if (lnhmfjdmokp != null)
		{
			lnhmfjdmokp.PNLAPCGPDDL.Clear();
		}
	}

	// Token: 0x0600710F RID: 28943 RVA: 0x0036081C File Offset: 0x0035EA1C
	public void LNGMCLOGODM(int PPICJOPPOLK)
	{
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = this.MJGADELHFID(PPICJOPPOLK, false);
		if (lnhmfjdmokp != null)
		{
			lnhmfjdmokp.PNLAPCGPDDL.Clear();
		}
	}

	// Token: 0x06007110 RID: 28944 RVA: 0x00360840 File Offset: 0x0035EA40
	public void PAGKNHKCLMD()
	{
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = this.MJGADELHFID(this.BNDLJLCJCLO, true);
		if (lnhmfjdmokp != null)
		{
			lnhmfjdmokp.PNLAPCGPDDL.Clear();
			this.GDMEEEMEBPD("OnChatMessage", new OAFJCFOGGAF.PIGPIKMNNLH(lnhmfjdmokp, "", "Чат очищен", false));
		}
	}

	// Token: 0x06007111 RID: 28945 RVA: 0x00360888 File Offset: 0x0035EA88
	public OAFJCFOGGAF.LNHMFJDMOKP IOJGJDMOEBB(string ODMIONDMCKF, int NAEPLCKLJDN = 2)
	{
		if (this.DBLBDNMLIOF.ContainsKey(ODMIONDMCKF))
		{
			return this.DBLBDNMLIOF[ODMIONDMCKF];
		}
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = new OAFJCFOGGAF.LNHMFJDMOKP(NAEPLCKLJDN, ODMIONDMCKF);
		this.DBLBDNMLIOF.Add(ODMIONDMCKF, lnhmfjdmokp);
		return lnhmfjdmokp;
	}

	// Token: 0x06007112 RID: 28946 RVA: 0x003608C8 File Offset: 0x0035EAC8
	public OAFJCFOGGAF.EDPNAHLGHPL ELEFJAEDJAK(long LPFKFNLHGBI)
	{
		OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl;
		if (this.JIKGMLGOAPG.ContainsKey(LPFKFNLHGBI))
		{
			edpnahlghpl = this.JIKGMLGOAPG[LPFKFNLHGBI];
		}
		else
		{
			edpnahlghpl = new OAFJCFOGGAF.EDPNAHLGHPL();
			edpnahlghpl.LPFKFNLHGBI = LPFKFNLHGBI;
			this.JIKGMLGOAPG.Add(LPFKFNLHGBI, edpnahlghpl);
		}
		return edpnahlghpl;
	}

	// Token: 0x06007113 RID: 28947 RVA: 0x00360910 File Offset: 0x0035EB10
	public void IPBFKJALBIG(long JCGDLKIHBJG, string HGGLNBKFHKK, int OPDBKGOIENM)
	{
		string value = string.Format("?", JCGDLKIHBJG, HGGLNBKFHKK, OPDBKGOIENM);
		OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(JCGDLKIHBJG);
		edpnahlghpl.KNDGFKKALCE = false;
		edpnahlghpl.BNIHFBMEPAB = HGGLNBKFHKK;
		edpnahlghpl.CNOLCNDBLJE = OPDBKGOIENM;
		if (!this.AFEHCKGOGBO.ContainsKey(JCGDLKIHBJG))
		{
			this.AFEHCKGOGBO.Add(JCGDLKIHBJG, value);
		}
		this.BFMBHGBBMGH();
	}

	// Token: 0x06007114 RID: 28948 RVA: 0x00360978 File Offset: 0x0035EB78
	public void KMGHDOGLPAB()
	{
		this.AFEHCKGOGBO.Clear();
		string @string = PlayerPrefs.GetString("ignorelist");
		if (@string == "")
		{
			return;
		}
		foreach (string text in @string.Split(new char[]
		{
			';'
		}))
		{
			if (text.Length >= 2)
			{
				string[] array2 = text.Split(new char[]
				{
					'|'
				});
				long num = long.Parse(array2[0]);
				string text2 = array2[1];
				int num2 = int.Parse(array2[2]);
				string value = string.Format("{0}|{1}|{2}", num, text2, num2);
				if (!this.AFEHCKGOGBO.ContainsKey(num))
				{
					this.AFEHCKGOGBO.Add(num, value);
				}
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.ELEFJAEDJAK(num);
				if (edpnahlghpl.CNOLCNDBLJE == 0)
				{
					edpnahlghpl.CNOLCNDBLJE = num2;
					edpnahlghpl.BNIHFBMEPAB = text2;
				}
				edpnahlghpl.KNDGFKKALCE = true;
			}
		}
	}

	// Token: 0x06007115 RID: 28949 RVA: 0x00360A70 File Offset: 0x0035EC70
	public void BLGDLAFBMPF()
	{
		foreach (OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp in this.DBLBDNMLIOF.Values)
		{
			lnhmfjdmokp.JIKGMLGOAPG.Clear();
			lnhmfjdmokp.PNLAPCGPDDL.Clear();
		}
	}

	// Token: 0x06007116 RID: 28950 RVA: 0x00360AD8 File Offset: 0x0035ECD8
	public void PBHOFBIHPKF(int PPICJOPPOLK, string IABKGMNJLJO)
	{
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = this.MJGADELHFID(PPICJOPPOLK, true);
		OAFJCFOGGAF.PIGPIKMNNLH item = new OAFJCFOGGAF.PIGPIKMNNLH(lnhmfjdmokp, "SYS", IABKGMNJLJO, false);
		lnhmfjdmokp.PNLAPCGPDDL.Add(item);
	}

	// Token: 0x1700018B RID: 395
	// (get) Token: 0x06007117 RID: 28951 RVA: 0x00360B08 File Offset: 0x0035ED08
	public string IJBPCCHPPKO
	{
		get
		{
			if (this.BNDLJLCJCLO == 0)
			{
				return "sys";
			}
			if (this.BNDLJLCJCLO == 1)
			{
				return "loc";
			}
			if (this.BNDLJLCJCLO == 2)
			{
				return this.CAKMOAMPKAA;
			}
			if (this.BNDLJLCJCLO == 10)
			{
				return "help";
			}
			if (this.BNDLJLCJCLO == 3)
			{
				return "private";
			}
			return "none";
		}
	}

	// Token: 0x06007118 RID: 28952 RVA: 0x00360B68 File Offset: 0x0035ED68
	public OAFJCFOGGAF.LNHMFJDMOKP MJGADELHFID(string ODMIONDMCKF, int NAEPLCKLJDN = 2)
	{
		if (this.DBLBDNMLIOF.ContainsKey(ODMIONDMCKF))
		{
			return this.DBLBDNMLIOF[ODMIONDMCKF];
		}
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = new OAFJCFOGGAF.LNHMFJDMOKP(NAEPLCKLJDN, ODMIONDMCKF);
		this.DBLBDNMLIOF.Add(ODMIONDMCKF, lnhmfjdmokp);
		return lnhmfjdmokp;
	}

	// Token: 0x06007119 RID: 28953 RVA: 0x00360BA6 File Offset: 0x0035EDA6
	public string GMIJIPDMMKO(int NDDLLPAIHGM)
	{
		return this.MJGADELHFID(NDDLLPAIHGM, false).JKFEMGAFKLJ(false);
	}

	// Token: 0x0600711A RID: 28954 RVA: 0x00360BB8 File Offset: 0x0035EDB8
	public void MJOGPKOJODA(long LPFKFNLHGBI)
	{
		if (!this.JIKGMLGOAPG.ContainsKey(LPFKFNLHGBI))
		{
			return;
		}
		this.JIKGMLGOAPG[LPFKFNLHGBI].EFFAHDKPOJA = false;
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = this.MJGADELHFID(2, false);
		if (lnhmfjdmokp != null)
		{
			lnhmfjdmokp.JIKGMLGOAPG.Remove(LPFKFNLHGBI);
			if (this.BNDLJLCJCLO == 2 && ChatPanelLogic.getI != null)
			{
				ChatPanelLogic.getI.updateUserList();
			}
		}
		lnhmfjdmokp = this.MJGADELHFID(1, false);
		if (lnhmfjdmokp != null)
		{
			lnhmfjdmokp.JIKGMLGOAPG.Remove(LPFKFNLHGBI);
			if (this.BNDLJLCJCLO == 1 && ChatPanelLogic.getI != null)
			{
				ChatPanelLogic.getI.updateUserList();
			}
		}
	}

	// Token: 0x0600711B RID: 28955 RVA: 0x00360C58 File Offset: 0x0035EE58
	public void LKNHJMPAEBA(GameObject APDJCCIGFAK)
	{
		this.ICJDFGKNKLL.Add(APDJCCIGFAK);
	}

	// Token: 0x0600711C RID: 28956 RVA: 0x00360C58 File Offset: 0x0035EE58
	public void IECBHEEDKND(GameObject APDJCCIGFAK)
	{
		this.ICJDFGKNKLL.Add(APDJCCIGFAK);
	}

	// Token: 0x0600711D RID: 28957 RVA: 0x00360C68 File Offset: 0x0035EE68
	public void HLOMDJIGKEJ(string IABKGMNJLJO, int PBFNEPLIHGP = -1, long NGCJCDADLAE = 0L)
	{
		int num = this.BNDLJLCJCLO;
		if (PBFNEPLIHGP > 1)
		{
			num = PBFNEPLIHGP;
		}
		string lngffjihknp = " l ";
		if (num == 7)
		{
			lngffjihknp = this.CAKMOAMPKAA;
		}
		if (num == -93)
		{
			lngffjihknp = " ур. ";
			num = 1;
		}
		if (num == 0)
		{
			lngffjihknp = "\n";
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.ENDMKPCFKND(num);
			epmphjgalbe.AAHBHCMKGJD(NGCJCDADLAE);
			epmphjgalbe.GHFGOOJLNJH(IABKGMNJLJO);
			epmphjgalbe.GHFGOOJLNJH(lngffjihknp);
			NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-2, epmphjgalbe.ALLANCHILCM());
		}
		finally
		{
			epmphjgalbe.OGPGOEJFIBO();
		}
	}

	// Token: 0x0600711E RID: 28958 RVA: 0x00360CFC File Offset: 0x0035EEFC
	public void ABBEJLCNMLK(string ODMIONDMCKF, int LADDNIBBJDP)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.NEHCMOODKIN(ODMIONDMCKF);
			epmphjgalbe.GOMLLPFFPNP(LADDNIBBJDP);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(25, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x0600711F RID: 28959 RVA: 0x00360D48 File Offset: 0x0035EF48
	public void GLIBPNICMGE(long JCGDLKIHBJG)
	{
		if (this.AFEHCKGOGBO.ContainsKey(JCGDLKIHBJG))
		{
			this.AFEHCKGOGBO.Remove(JCGDLKIHBJG);
		}
		this.BFMBHGBBMGH();
	}

	// Token: 0x06007120 RID: 28960 RVA: 0x00360D6C File Offset: 0x0035EF6C
	private void GDMEEEMEBPD(string IABKGMNJLJO, object DCCPCBLODIG)
	{
		foreach (GameObject gameObject in this.ICJDFGKNKLL)
		{
			try
			{
				gameObject.SendMessage(IABKGMNJLJO, DCCPCBLODIG, SendMessageOptions.DontRequireReceiver);
			}
			catch
			{
				Debug.Log("Msg error");
			}
		}
	}

	// Token: 0x06007121 RID: 28961 RVA: 0x00360DDC File Offset: 0x0035EFDC
	public void BNGIIJPLHLO()
	{
		this.CPJCHPJIHHL("  ");
	}

	// Token: 0x06007122 RID: 28962 RVA: 0x00360DEC File Offset: 0x0035EFEC
	public OAFJCFOGGAF.EDPNAHLGHPL NHBGDHECDKM(HBPNMNGOFMA KADBECGIMPD)
	{
		long num = KADBECGIMPD.DNIIFBAIPBE();
		OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
		edpnahlghpl.OCPAHLAGCAI(num, KADBECGIMPD);
		ChatPanelLogic.getI.updateUserList();
		return edpnahlghpl;
	}

	// Token: 0x06007123 RID: 28963 RVA: 0x00360E20 File Offset: 0x0035F020
	public void IBLPAKKLIGK(int PPICJOPPOLK, string IABKGMNJLJO)
	{
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = this.MJGADELHFID(PPICJOPPOLK, false);
		OAFJCFOGGAF.PIGPIKMNNLH item = new OAFJCFOGGAF.PIGPIKMNNLH(lnhmfjdmokp, "Mouse ScrollWheel", IABKGMNJLJO, false);
		lnhmfjdmokp.PNLAPCGPDDL.Add(item);
	}

	// Token: 0x06007124 RID: 28964 RVA: 0x00360E50 File Offset: 0x0035F050
	public void BFMBHGBBMGH()
	{
		string text = "";
		foreach (string str in this.AFEHCKGOGBO.Values)
		{
			text = text + str + ";";
		}
		PlayerPrefs.SetString("ignorelist", text);
	}

	// Token: 0x06007125 RID: 28965 RVA: 0x00360EC0 File Offset: 0x0035F0C0
	public void COPFOHHLMHM(string IABKGMNJLJO)
	{
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = this.DMAOGCJLBDF(1, true);
		OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh = new OAFJCFOGGAF.PIGPIKMNNLH(lnhmfjdmokp, "lastConfirmLic", IABKGMNJLJO, true);
		lnhmfjdmokp.PNLAPCGPDDL.Add(pigpikmnnlh);
		if (lnhmfjdmokp.PNLAPCGPDDL.Count > -105)
		{
			lnhmfjdmokp.PNLAPCGPDDL.RemoveAt(0);
		}
		this.OEDMHKCBKJF("_MaxCoC", pigpikmnnlh);
	}

	// Token: 0x06007126 RID: 28966 RVA: 0x00360F18 File Offset: 0x0035F118
	public OAFJCFOGGAF.LNHMFJDMOKP DMAOGCJLBDF(int NKGBBKBNPJO, bool DLHADJKLBMA = true)
	{
		string text = this.CAKMOAMPKAA;
		if (NKGBBKBNPJO == 0)
		{
			text = "Cells";
		}
		if (NKGBBKBNPJO == 1)
		{
			text = "Sitting Reading";
		}
		if (NKGBBKBNPJO == 6)
		{
			text = this.CAKMOAMPKAA;
		}
		if (NKGBBKBNPJO == 24)
		{
			text = "cht_tofrendmsg";
		}
		if (NKGBBKBNPJO == 5)
		{
			text = "";
		}
		if (this.DBLBDNMLIOF.ContainsKey(text))
		{
			return this.DBLBDNMLIOF[text];
		}
		if (!DLHADJKLBMA)
		{
			return null;
		}
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = new OAFJCFOGGAF.LNHMFJDMOKP(NKGBBKBNPJO, text);
		this.DBLBDNMLIOF.Add(text, lnhmfjdmokp);
		return lnhmfjdmokp;
	}

	// Token: 0x06007127 RID: 28967 RVA: 0x00360F98 File Offset: 0x0035F198
	public OAFJCFOGGAF.LNHMFJDMOKP MJGADELHFID(int NKGBBKBNPJO, bool DLHADJKLBMA = true)
	{
		string text = this.CAKMOAMPKAA;
		if (NKGBBKBNPJO == 0)
		{
			text = "sys";
		}
		if (NKGBBKBNPJO == 1)
		{
			text = "loc";
		}
		if (NKGBBKBNPJO == 2)
		{
			text = this.CAKMOAMPKAA;
		}
		if (NKGBBKBNPJO == 10)
		{
			text = "help";
		}
		if (NKGBBKBNPJO == 3)
		{
			text = "private";
		}
		if (this.DBLBDNMLIOF.ContainsKey(text))
		{
			return this.DBLBDNMLIOF[text];
		}
		if (!DLHADJKLBMA)
		{
			return null;
		}
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = new OAFJCFOGGAF.LNHMFJDMOKP(NKGBBKBNPJO, text);
		this.DBLBDNMLIOF.Add(text, lnhmfjdmokp);
		return lnhmfjdmokp;
	}

	// Token: 0x06007128 RID: 28968 RVA: 0x00361018 File Offset: 0x0035F218
	public void LIJACMODLFA(HBPNMNGOFMA KADBECGIMPD)
	{
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			long num = KADBECGIMPD.DNIIFBAIPBE();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.OCPAHLAGCAI(num, KADBECGIMPD);
			edpnahlghpl.EFFAHDKPOJA = true;
		}
	}

	// Token: 0x06007129 RID: 28969 RVA: 0x00361050 File Offset: 0x0035F250
	public void KNMHPFAHENN(string IABKGMNJLJO, int PBFNEPLIHGP = -1, long NGCJCDADLAE = 0L)
	{
		int num = this.BNDLJLCJCLO;
		if (PBFNEPLIHGP > 0)
		{
			num = PBFNEPLIHGP;
		}
		string lngffjihknp = "";
		if (num == 2)
		{
			lngffjihknp = this.CAKMOAMPKAA;
		}
		if (num == 10)
		{
			lngffjihknp = "help";
			num = 2;
		}
		if (num == 3)
		{
			lngffjihknp = "private";
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(num);
			epmphjgalbe.OBCCLNMPGEJ(NGCJCDADLAE);
			epmphjgalbe.NEHCMOODKIN(IABKGMNJLJO);
			epmphjgalbe.NEHCMOODKIN(lngffjihknp);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(50, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x0600712A RID: 28970 RVA: 0x003610E4 File Offset: 0x0035F2E4
	public void BJFENEBKNOI(long JCGDLKIHBJG, string HGGLNBKFHKK, int OPDBKGOIENM)
	{
		string value = string.Format("{0}|{1}|{2}", JCGDLKIHBJG, HGGLNBKFHKK, OPDBKGOIENM);
		OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(JCGDLKIHBJG);
		edpnahlghpl.KNDGFKKALCE = true;
		edpnahlghpl.BNIHFBMEPAB = HGGLNBKFHKK;
		edpnahlghpl.CNOLCNDBLJE = OPDBKGOIENM;
		if (!this.AFEHCKGOGBO.ContainsKey(JCGDLKIHBJG))
		{
			this.AFEHCKGOGBO.Add(JCGDLKIHBJG, value);
		}
		this.BFMBHGBBMGH();
	}

	// Token: 0x0600712C RID: 28972 RVA: 0x00361155 File Offset: 0x0035F355
	public void CJCIDBHGHHJ(GameObject APDJCCIGFAK)
	{
		this.ICJDFGKNKLL.Remove(APDJCCIGFAK);
	}

	// Token: 0x0600712D RID: 28973 RVA: 0x00361164 File Offset: 0x0035F364
	public void OFHGCIFNICJ(HBPNMNGOFMA KADBECGIMPD)
	{
		OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh = new OAFJCFOGGAF.PIGPIKMNNLH(KADBECGIMPD);
		pigpikmnnlh.BDELNBNMOPB.PNLAPCGPDDL.Add(pigpikmnnlh);
		if (pigpikmnnlh.BDELNBNMOPB.PNLAPCGPDDL.Count > 20)
		{
			pigpikmnnlh.BDELNBNMOPB.PNLAPCGPDDL.RemoveAt(0);
		}
		this.GDMEEEMEBPD("OnChatMessage", pigpikmnnlh);
	}

	// Token: 0x0600712E RID: 28974 RVA: 0x003611BC File Offset: 0x0035F3BC
	private void OEDMHKCBKJF(string IABKGMNJLJO, object DCCPCBLODIG)
	{
		foreach (GameObject gameObject in this.ICJDFGKNKLL)
		{
			try
			{
				gameObject.SendMessage(IABKGMNJLJO, DCCPCBLODIG, SendMessageOptions.RequireReceiver);
			}
			catch
			{
				Debug.Log(" ");
			}
		}
	}

	// Token: 0x0600712F RID: 28975 RVA: 0x00360C58 File Offset: 0x0035EE58
	public void JAJMEFBHEBH(GameObject APDJCCIGFAK)
	{
		this.ICJDFGKNKLL.Add(APDJCCIGFAK);
	}

	// Token: 0x06007130 RID: 28976 RVA: 0x0036122C File Offset: 0x0035F42C
	public void PLPOKHMHLPL(string IABKGMNJLJO)
	{
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = this.MJGADELHFID(0, true);
		OAFJCFOGGAF.PIGPIKMNNLH item = new OAFJCFOGGAF.PIGPIKMNNLH(lnhmfjdmokp, ">", IABKGMNJLJO, false);
		lnhmfjdmokp.PNLAPCGPDDL.Add(item);
		if (lnhmfjdmokp.PNLAPCGPDDL.Count > 20)
		{
			lnhmfjdmokp.PNLAPCGPDDL.RemoveAt(0);
		}
	}

	// Token: 0x06007131 RID: 28977 RVA: 0x00361278 File Offset: 0x0035F478
	public void HBMNIJCICEI()
	{
		foreach (OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp in this.DBLBDNMLIOF.Values)
		{
			lnhmfjdmokp.JIKGMLGOAPG.Clear();
			lnhmfjdmokp.PNLAPCGPDDL.Clear();
		}
	}

	// Token: 0x06007132 RID: 28978 RVA: 0x003612E0 File Offset: 0x0035F4E0
	public OAFJCFOGGAF()
	{
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = new OAFJCFOGGAF.LNHMFJDMOKP(0, "sys");
		this.DBLBDNMLIOF.Add(lnhmfjdmokp.OFALPEIEOJE, lnhmfjdmokp);
		lnhmfjdmokp = new OAFJCFOGGAF.LNHMFJDMOKP(1, "loc");
		this.DBLBDNMLIOF.Add(lnhmfjdmokp.OFALPEIEOJE, lnhmfjdmokp);
		lnhmfjdmokp = new OAFJCFOGGAF.LNHMFJDMOKP(10, "help");
		this.DBLBDNMLIOF.Add(lnhmfjdmokp.OFALPEIEOJE, lnhmfjdmokp);
	}

	// Token: 0x06007133 RID: 28979 RVA: 0x00361388 File Offset: 0x0035F588
	public void NJFECIDEICI(long LPFKFNLHGBI)
	{
		if (!this.JIKGMLGOAPG.ContainsKey(LPFKFNLHGBI))
		{
			return;
		}
		this.JIKGMLGOAPG[LPFKFNLHGBI].EFFAHDKPOJA = false;
		OAFJCFOGGAF.LNHMFJDMOKP lnhmfjdmokp = this.MJGADELHFID(0, false);
		if (lnhmfjdmokp != null)
		{
			lnhmfjdmokp.JIKGMLGOAPG.Remove(LPFKFNLHGBI);
			if (this.BNDLJLCJCLO == 1 && ChatPanelLogic.getI != null)
			{
				ChatPanelLogic.getI.updateUserList();
			}
		}
		lnhmfjdmokp = this.MJGADELHFID(0, false);
		if (lnhmfjdmokp != null)
		{
			lnhmfjdmokp.JIKGMLGOAPG.Remove(LPFKFNLHGBI);
			if (this.BNDLJLCJCLO == 1 && ChatPanelLogic.getI != null)
			{
				ChatPanelLogic.getI.BEFBMBJDNPB();
			}
		}
	}

	// Token: 0x06007134 RID: 28980 RVA: 0x00361428 File Offset: 0x0035F628
	public void MAOKKGDMPDO(int KIFDNDABFIF)
	{
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(26, this.CAKMOAMPKAA);
		this.CAKMOAMPKAA = "";
	}

	// Token: 0x06007135 RID: 28981 RVA: 0x00360C58 File Offset: 0x0035EE58
	public void BAIACHAHEHH(GameObject APDJCCIGFAK)
	{
		this.ICJDFGKNKLL.Add(APDJCCIGFAK);
	}

	// Token: 0x0400109D RID: 4253
	public string CAKMOAMPKAA = "";

	// Token: 0x0400109E RID: 4254
	public int BNDLJLCJCLO;

	// Token: 0x0400109F RID: 4255
	public static OAFJCFOGGAF IKGFHGKKCPG = new OAFJCFOGGAF();

	// Token: 0x040010A0 RID: 4256
	public const int OEFLHIPNHBI = 20;

	// Token: 0x040010A1 RID: 4257
	public Dictionary<string, OAFJCFOGGAF.LNHMFJDMOKP> DBLBDNMLIOF = new Dictionary<string, OAFJCFOGGAF.LNHMFJDMOKP>();

	// Token: 0x040010A2 RID: 4258
	private readonly List<GameObject> ICJDFGKNKLL = new List<GameObject>();

	// Token: 0x040010A3 RID: 4259
	private Dictionary<long, string> AFEHCKGOGBO = new Dictionary<long, string>();

	// Token: 0x040010A4 RID: 4260
	public Dictionary<long, OAFJCFOGGAF.EDPNAHLGHPL> JIKGMLGOAPG = new Dictionary<long, OAFJCFOGGAF.EDPNAHLGHPL>();

	// Token: 0x020001EB RID: 491
	public class EDPNAHLGHPL : ItemBase
	{
		// Token: 0x06007136 RID: 28982 RVA: 0x00361448 File Offset: 0x0035F648
		public override int AHEKGDLAOIN(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 1;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x06007137 RID: 28983 RVA: 0x00361494 File Offset: 0x0035F694
		public virtual int OKFPGBKONAN(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 0;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x06007138 RID: 28984 RVA: 0x003614DD File Offset: 0x0035F6DD
		public virtual string DIACBNHNDCJ()
		{
			return string.Format("1 Hand Sword Jab Combo", this.BNIHFBMEPAB);
		}

		// Token: 0x06007139 RID: 28985 RVA: 0x003614EF File Offset: 0x0035F6EF
		public void AKMLEEPJPPL(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.DHCMILPKJAL();
			this.HKHMIIEIFNG = KADBECGIMPD.AGNKAFLKCAG();
			this.CNOLCNDBLJE = KADBECGIMPD.HHLDBAEFNMJ();
			this.MODEOKGGDBD = KADBECGIMPD.ELDBJFLCMAJ();
		}

		// Token: 0x0600713A RID: 28986 RVA: 0x00361528 File Offset: 0x0035F728
		public virtual string BGJEBOEAINF()
		{
			return string.Format("---------- DebugReturn ", this.BNIHFBMEPAB);
		}

		// Token: 0x0600713B RID: 28987 RVA: 0x0036153A File Offset: 0x0035F73A
		public void JHMPIOAAIBF(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.LPKJHMGLCKA();
			this.HKHMIIEIFNG = KADBECGIMPD.KDNDJNEGBDI();
			this.CNOLCNDBLJE = KADBECGIMPD.DOJKJHMJJNK();
			this.MODEOKGGDBD = KADBECGIMPD.IOEEPNCKLJD();
		}

		// Token: 0x0600713C RID: 28988 RVA: 0x00361573 File Offset: 0x0035F773
		public virtual string CEOAKEEKAMH()
		{
			return string.Format("forFishes", this.BNIHFBMEPAB);
		}

		// Token: 0x0600713D RID: 28989 RVA: 0x00361588 File Offset: 0x0035F788
		public virtual void DGABHJOHIHE(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[3].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "PaperTurn.wav";
			}
			string text = string.Format("", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.BAHOIALGCFF(0);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.GAMCOCKKBME(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.LCILNGKKLPN(this.HKHMIIEIFNG, this.BNIHFBMEPAB, true, false);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 338f);
			}
			else
			{
				component.text = text;
				component2.text = "no_time_period";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1842f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x0600713E RID: 28990 RVA: 0x003616FD File Offset: 0x0035F8FD
		public void BFNPPKIKKMC(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.DPLAJNEDGBL();
			this.HKHMIIEIFNG = KADBECGIMPD.HDBGOLAFOBK();
			this.CNOLCNDBLJE = KADBECGIMPD.CLPEKGGAMAI();
			this.MODEOKGGDBD = KADBECGIMPD.DADCGPGEHFK();
		}

		// Token: 0x0600713F RID: 28991 RVA: 0x00361738 File Offset: 0x0035F938
		public virtual int FNBAHGJELIE(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 0;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x06007140 RID: 28992 RVA: 0x00361781 File Offset: 0x0035F981
		public void AGADBLDMILO(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.PNBECHOLCJM();
			this.HKHMIIEIFNG = KADBECGIMPD.KDNDJNEGBDI();
			this.CNOLCNDBLJE = KADBECGIMPD.IFDFHJLCHAE();
			this.MODEOKGGDBD = KADBECGIMPD.BLNIHNKJJPJ();
		}

		// Token: 0x06007141 RID: 28993 RVA: 0x003617BC File Offset: 0x0035F9BC
		public virtual void PPFECMOLFDF(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[6].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 1)
			{
				component3.text = "KatanaVerticalSwing";
			}
			string text = string.Format("UpHillWalk", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.HCINMKFKAHJ(1);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.KGMAMJMJOHF(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.DJMOAHJEBFF(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, false);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1719f);
			}
			else
			{
				component.text = text;
				component2.text = "";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1302f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x06007142 RID: 28994 RVA: 0x00361934 File Offset: 0x0035FB34
		public virtual int GIOMNNCOKFN(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 0;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x06007143 RID: 28995 RVA: 0x0036197D File Offset: 0x0035FB7D
		public void HEMIJKOAPBB(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.LPKJHMGLCKA();
			this.HKHMIIEIFNG = KADBECGIMPD.KDNDJNEGBDI();
			this.CNOLCNDBLJE = KADBECGIMPD.AGNKAFLKCAG();
			this.MODEOKGGDBD = KADBECGIMPD.BEMFIFGOJBL();
		}

		// Token: 0x06007144 RID: 28996 RVA: 0x003619B8 File Offset: 0x0035FBB8
		public virtual void MANGLJBHKNL(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[5].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[8].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "_";
			}
			string text = string.Format("Bumper", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.PGEJCFIBKJG(0);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.JMPLBJGLJFB(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.EDCDLKNNBGC(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, false);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 665f);
			}
			else
			{
				component.text = text;
				component2.text = "BackPackOff";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1684f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x06007145 RID: 28997 RVA: 0x00361B2D File Offset: 0x0035FD2D
		public virtual string PMPNLAFNBBC()
		{
			return string.Format("bs_noprip", this.BNIHFBMEPAB);
		}

		// Token: 0x06007146 RID: 28998 RVA: 0x00361B40 File Offset: 0x0035FD40
		public virtual void CKEADHDIJAO(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[6].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 1)
			{
				component3.text = "BlendMaterial";
			}
			string text = string.Format("shop_t4", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.LDMBLNONMOI(1);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.PGEJCFIBKJG(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.CDFDGCAOMLM(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, true);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 445f);
			}
			else
			{
				component.text = text;
				component2.text = ", second bone: ";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 609f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x06007147 RID: 28999 RVA: 0x00361CB5 File Offset: 0x0035FEB5
		public virtual string MFPEPELOHBL()
		{
			return string.Format("<color='#003000'>+{0} {1}</color>", this.BNIHFBMEPAB);
		}

		// Token: 0x06007148 RID: 29000 RVA: 0x00361CC8 File Offset: 0x0035FEC8
		public virtual void HJPFIDCAPGA(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "Moon reference not set.";
			}
			string text = string.Format("EndPhysPoint", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.PIGLJDBPGPJ(0);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.BNPKGGNMCML(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.GLFILPFCMGN(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, true);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 172f);
			}
			else
			{
				component.text = text;
				component2.text = "pempty=0";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1233f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x06007149 RID: 29001 RVA: 0x00361E40 File Offset: 0x00360040
		public virtual int IFCECCJMMJJ(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 0;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x0600714A RID: 29002 RVA: 0x00361E8C File Offset: 0x0036008C
		public virtual int OFLOPECEHLM(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 0;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x0600714B RID: 29003 RVA: 0x00361ED8 File Offset: 0x003600D8
		public virtual void ENFDIICCBBG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "BowFire2";
			}
			string text = string.Format("lastRatingIndex", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.KGMAMJMJOHF(1);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.KOACFBDMKKB(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.FOJGKJPMIOC(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, false);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 885f);
			}
			else
			{
				component.text = text;
				component2.text = "{0} x {1}";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1700f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x0600714C RID: 29004 RVA: 0x0036204D File Offset: 0x0036024D
		public void FNJFCJFAJFG(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.NCODBGMGNFD();
			this.HKHMIIEIFNG = KADBECGIMPD.DOJKJHMJJNK();
			this.CNOLCNDBLJE = KADBECGIMPD.KDNDJNEGBDI();
			this.MODEOKGGDBD = KADBECGIMPD.OMCMPDMJFOJ();
		}

		// Token: 0x0600714D RID: 29005 RVA: 0x00362088 File Offset: 0x00360288
		public virtual int OKADCDIDMOM(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 0;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x0600714E RID: 29006 RVA: 0x003620D1 File Offset: 0x003602D1
		public virtual string DIPEOLHEMHK()
		{
			return string.Format("drag_onmousedown.wav", this.BNIHFBMEPAB);
		}

		// Token: 0x0600714F RID: 29007 RVA: 0x003620E3 File Offset: 0x003602E3
		public void COMPGPHIOPJ(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.NCODBGMGNFD();
			this.HKHMIIEIFNG = KADBECGIMPD.CLPEKGGAMAI();
			this.CNOLCNDBLJE = KADBECGIMPD.CLPEKGGAMAI();
			this.MODEOKGGDBD = KADBECGIMPD.JALHMJEKMHF();
		}

		// Token: 0x06007150 RID: 29008 RVA: 0x0036211C File Offset: 0x0036031C
		public void OGDEGELLJJN(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.JJJJAGJCOGD();
			this.HKHMIIEIFNG = KADBECGIMPD.HDBGOLAFOBK();
			this.CNOLCNDBLJE = KADBECGIMPD.HHLDBAEFNMJ();
			this.MODEOKGGDBD = KADBECGIMPD.BEMFIFGOJBL();
		}

		// Token: 0x06007151 RID: 29009 RVA: 0x00362158 File Offset: 0x00360358
		public override void OMBICACBIFH(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[7].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[6].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "A";
			}
			string text = string.Format("crft_btn2", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.HCINMKFKAHJ(0);
			if (this.HKHMIIEIFNG > 1)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.AIELPFAHFOC(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.CGPPLMOFBDB(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, true);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 480f);
			}
			else
			{
				component.text = text;
				component2.text = "I";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 245f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x06007152 RID: 29010 RVA: 0x003622CD File Offset: 0x003604CD
		public void GMDNABBJDJF(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.BFPHBMDMODH();
			this.HKHMIIEIFNG = KADBECGIMPD.LDLKLPJBIJN();
			this.CNOLCNDBLJE = KADBECGIMPD.AGNKAFLKCAG();
			this.MODEOKGGDBD = KADBECGIMPD.JALHMJEKMHF();
		}

		// Token: 0x06007153 RID: 29011 RVA: 0x00362308 File Offset: 0x00360508
		public virtual void BAOGLNMFMFJ(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[7].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "_LerpRgbTex";
			}
			string text = string.Format("L", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.JMPLBJGLJFB(0);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.BAHOIALGCFF(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.KLCCFECNEAN(this.HKHMIIEIFNG, this.BNIHFBMEPAB, true, false);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 507f);
			}
			else
			{
				component.text = text;
				component2.text = "_Slope";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 824f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x06007154 RID: 29012 RVA: 0x0036247D File Offset: 0x0036067D
		public virtual string BPODJNKAIEC()
		{
			return string.Format("#FF4040", this.BNIHFBMEPAB);
		}

		// Token: 0x06007155 RID: 29013 RVA: 0x0036248F File Offset: 0x0036068F
		public void JHLCFAGDNKM(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.PNBECHOLCJM();
			this.HKHMIIEIFNG = KADBECGIMPD.LDLKLPJBIJN();
			this.CNOLCNDBLJE = KADBECGIMPD.KDNDJNEGBDI();
			this.MODEOKGGDBD = KADBECGIMPD.DADCGPGEHFK();
		}

		// Token: 0x06007156 RID: 29014 RVA: 0x003624C8 File Offset: 0x003606C8
		public virtual void KEJEGGGIAGB(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[6].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "isWoman";
			}
			string text = string.Format("OK", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.CNENPBMADGI(0);
			if (this.HKHMIIEIFNG > 1)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.HGKEGJEKGJF(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.BOOJJNEMLIF(this.HKHMIIEIFNG, this.BNIHFBMEPAB, true, false);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 471f);
			}
			else
			{
				component.text = text;
				component2.text = "WandAttack2";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 600f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x06007157 RID: 29015 RVA: 0x00362640 File Offset: 0x00360840
		public virtual int OCLLOHIBCLB(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 1;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x06007158 RID: 29016 RVA: 0x0036268C File Offset: 0x0036088C
		public virtual int CHPPDNNFBPD(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 1;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x06007159 RID: 29017 RVA: 0x003626D5 File Offset: 0x003608D5
		public void EFGBDBAOFCJ(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.PNBECHOLCJM();
			this.HKHMIIEIFNG = KADBECGIMPD.DOJKJHMJJNK();
			this.CNOLCNDBLJE = KADBECGIMPD.DOJKJHMJJNK();
			this.MODEOKGGDBD = KADBECGIMPD.LAECLJFMGPE();
		}

		// Token: 0x0600715A RID: 29018 RVA: 0x00362710 File Offset: 0x00360910
		public override void FOMFEBJINLG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[5].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "bs_cost";
			}
			string text = string.Format("Root Node bone is null, can not initiate the solver.", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.MDLJBINCHEP(0);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.IEMMANBNHNP(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.HHJHDLHKJDF(this.HKHMIIEIFNG, this.BNIHFBMEPAB, true, true);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 435f);
			}
			else
			{
				component.text = text;
				component2.text = "wpn_wgt";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1554f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x0600715B RID: 29019 RVA: 0x00362888 File Offset: 0x00360A88
		public virtual void KJIJKIBCKAK(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[7].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[7].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 1)
			{
				component3.text = "RunBackLeft";
			}
			string text = string.Format("", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.POHHAIPMJOA(0);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.HDCDPPALBLL(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.EBGHGKKMMGH(this.HKHMIIEIFNG, this.BNIHFBMEPAB, true, false);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1426f);
			}
			else
			{
				component.text = text;
				component2.text = "KatanaNinjaDraw";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 290f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x0600715C RID: 29020 RVA: 0x00362A00 File Offset: 0x00360C00
		public virtual int HPPMMNCAGGJ(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 0;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x0600715D RID: 29021 RVA: 0x00362A49 File Offset: 0x00360C49
		public override string ToString()
		{
			return string.Format("{0}", this.BNIHFBMEPAB);
		}

		// Token: 0x0600715E RID: 29022 RVA: 0x00362A5B File Offset: 0x00360C5B
		public virtual string CBACNFCIOAJ()
		{
			return string.Format("\n", this.BNIHFBMEPAB);
		}

		// Token: 0x0600715F RID: 29023 RVA: 0x00362A6D File Offset: 0x00360C6D
		public void GOBDNDIINPL(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.NCODBGMGNFD();
			this.HKHMIIEIFNG = KADBECGIMPD.AGNKAFLKCAG();
			this.CNOLCNDBLJE = KADBECGIMPD.AGNKAFLKCAG();
			this.MODEOKGGDBD = KADBECGIMPD.ELDBJFLCMAJ();
		}

		// Token: 0x06007160 RID: 29024 RVA: 0x00362AA6 File Offset: 0x00360CA6
		public void KHOPKCFJPBF(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.KDELAFDDGJH();
			this.HKHMIIEIFNG = KADBECGIMPD.KKOKFLMMAAK();
			this.CNOLCNDBLJE = KADBECGIMPD.HDBGOLAFOBK();
			this.MODEOKGGDBD = KADBECGIMPD.JALHMJEKMHF();
		}

		// Token: 0x06007161 RID: 29025 RVA: 0x00362ADF File Offset: 0x00360CDF
		public virtual string MOBHDMJGEEC()
		{
			return string.Format("Try to change this Vector3 in memory:\n", this.BNIHFBMEPAB);
		}

		// Token: 0x06007162 RID: 29026 RVA: 0x00362AF1 File Offset: 0x00360CF1
		public void LEGJBJFGNEJ(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.PNBECHOLCJM();
			this.HKHMIIEIFNG = KADBECGIMPD.LDLKLPJBIJN();
			this.CNOLCNDBLJE = KADBECGIMPD.CLPEKGGAMAI();
			this.MODEOKGGDBD = KADBECGIMPD.ELDBJFLCMAJ();
		}

		// Token: 0x06007163 RID: 29027 RVA: 0x00362B2C File Offset: 0x00360D2C
		public virtual void BIDFNFOCGJO(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "SteamManager";
			}
			string text = string.Format("</color>", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.AAGFEIGBGBM(0);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.GAMCOCKKBME(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.BEGAIJKPDDD(this.HKHMIIEIFNG, this.BNIHFBMEPAB, true, false);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 92f);
			}
			else
			{
				component.text = text;
				component2.text = "************* posid=";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1932f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x06007164 RID: 29028 RVA: 0x00362CA1 File Offset: 0x00360EA1
		public override string CGGKJFBHOMJ()
		{
			return string.Format("cht_msg21", this.BNIHFBMEPAB);
		}

		// Token: 0x06007165 RID: 29029 RVA: 0x00362CB4 File Offset: 0x00360EB4
		public override void MLCFJPPIOJG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[2].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[3].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "";
			}
			string text = string.Format("{0}", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.KOACFBDMKKB(0);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.KOACFBDMKKB(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.HHJHDLHKJDF(this.HKHMIIEIFNG, this.BNIHFBMEPAB, true, true);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 32f);
			}
			else
			{
				component.text = text;
				component2.text = "";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 24f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x06007166 RID: 29030 RVA: 0x00362E29 File Offset: 0x00361029
		public void OLGEDIFBGNL(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.DPLAJNEDGBL();
			this.HKHMIIEIFNG = KADBECGIMPD.AGNKAFLKCAG();
			this.CNOLCNDBLJE = KADBECGIMPD.KKOKFLMMAAK();
			this.MODEOKGGDBD = KADBECGIMPD.IOEEPNCKLJD();
		}

		// Token: 0x06007167 RID: 29031 RVA: 0x00362E64 File Offset: 0x00361064
		public virtual void AACAABDCNBO(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[3].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[8].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "SAMPLES_MEDIUM";
			}
			string text = string.Format("wgt_gr", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.BNPKGGNMCML(0);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.PGEJCFIBKJG(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.BCDJLDLHEKP(this.HKHMIIEIFNG, this.BNIHFBMEPAB, true, false);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 667f);
			}
			else
			{
				component.text = text;
				component2.text = "Mouse X";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1526f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x06007168 RID: 29032 RVA: 0x00362FDC File Offset: 0x003611DC
		public virtual int DEJAPOECJMO(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 1;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x06007169 RID: 29033 RVA: 0x00363028 File Offset: 0x00361228
		public override int NBCAEJHKLMG(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 1;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x0600716A RID: 29034 RVA: 0x00363074 File Offset: 0x00361274
		public virtual void NOHKGHBNLLL(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[3].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 1)
			{
				component3.text = " is represented multiple times in the Bones.";
			}
			string text = string.Format("</color>", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.POHHAIPMJOA(0);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.KGMAMJMJOHF(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.LCILNGKKLPN(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, false);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 93f);
			}
			else
			{
				component.text = text;
				component2.text = "demoLong";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1584f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x0600716B RID: 29035 RVA: 0x003631E9 File Offset: 0x003613E9
		public void KAOKKLLOFBE(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.JJJJAGJCOGD();
			this.HKHMIIEIFNG = KADBECGIMPD.IFDFHJLCHAE();
			this.CNOLCNDBLJE = KADBECGIMPD.HHLDBAEFNMJ();
			this.MODEOKGGDBD = KADBECGIMPD.LAECLJFMGPE();
		}

		// Token: 0x0600716C RID: 29036 RVA: 0x00363224 File Offset: 0x00361424
		public virtual int CBIFPMNGHFA(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 0;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x0600716D RID: 29037 RVA: 0x0036326D File Offset: 0x0036146D
		public void FMHEFGFMLJI(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.DHCMILPKJAL();
			this.HKHMIIEIFNG = KADBECGIMPD.HHLDBAEFNMJ();
			this.CNOLCNDBLJE = KADBECGIMPD.KDNDJNEGBDI();
			this.MODEOKGGDBD = KADBECGIMPD.IJJDHHFAIPE();
		}

		// Token: 0x0600716E RID: 29038 RVA: 0x003632A6 File Offset: 0x003614A6
		public virtual string ALELIIHGHGH()
		{
			return string.Format("</color>", this.BNIHFBMEPAB);
		}

		// Token: 0x0600716F RID: 29039 RVA: 0x003632B8 File Offset: 0x003614B8
		public void KOBJOJMPFGC(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.LPKJHMGLCKA();
			this.HKHMIIEIFNG = KADBECGIMPD.DOJKJHMJJNK();
			this.CNOLCNDBLJE = KADBECGIMPD.HDBGOLAFOBK();
			this.MODEOKGGDBD = KADBECGIMPD.BEMFIFGOJBL();
		}

		// Token: 0x06007170 RID: 29040 RVA: 0x003632F1 File Offset: 0x003614F1
		public override string GAPOIDIICOL()
		{
			return string.Format("1HandSwordJabFootPush", this.BNIHFBMEPAB);
		}

		// Token: 0x06007171 RID: 29041 RVA: 0x00363304 File Offset: 0x00361504
		public virtual void IDNDKCJGIDN(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[2].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 1)
			{
				component3.text = "error";
			}
			string text = string.Format("KatanaReadyLow", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.KNJPPODPKNC(1);
			if (this.HKHMIIEIFNG > 1)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.EPIPJGHICLD(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.GGGFKBAAADC(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, true);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1355f);
			}
			else
			{
				component.text = text;
				component2.text = "512";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 852f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x06007172 RID: 29042 RVA: 0x0036347C File Offset: 0x0036167C
		public virtual int LAEBNJPLGHJ(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 1;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x06007173 RID: 29043 RVA: 0x003634C8 File Offset: 0x003616C8
		public virtual void FOKHLKPGGFO(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[7].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 1)
			{
				component3.text = "\n";
			}
			string text = string.Format("IdleWalk", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.BAHOIALGCFF(1);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.JMPLBJGLJFB(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.PKOFLNMMADN(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, true);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 530f);
			}
			else
			{
				component.text = text;
				component2.text = "gi_inte_3";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1435f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x06007174 RID: 29044 RVA: 0x00363640 File Offset: 0x00361840
		public virtual int JGNFAPFKDLD(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 1;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x06007175 RID: 29045 RVA: 0x00363689 File Offset: 0x00361889
		public void GEFKBNKPAAD(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.DHCMILPKJAL();
			this.HKHMIIEIFNG = KADBECGIMPD.AGNKAFLKCAG();
			this.CNOLCNDBLJE = KADBECGIMPD.IFDFHJLCHAE();
			this.MODEOKGGDBD = KADBECGIMPD.OMCMPDMJFOJ();
		}

		// Token: 0x06007177 RID: 29047 RVA: 0x003636C4 File Offset: 0x003618C4
		public virtual void PBFGKGCFECB(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[6].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[5].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 1)
			{
				component3.text = "MotorbikeLassoRight";
			}
			string text = string.Format("bs_nomoney", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.JMPLBJGLJFB(0);
			if (this.HKHMIIEIFNG > 1)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.EPIPJGHICLD(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.EBGHGKKMMGH(this.HKHMIIEIFNG, this.BNIHFBMEPAB, true, false);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 59f);
			}
			else
			{
				component.text = text;
				component2.text = "WireframeCamera";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1331f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x06007178 RID: 29048 RVA: 0x00363839 File Offset: 0x00361A39
		public void OHAMJIKDMMF(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.JJJJAGJCOGD();
			this.HKHMIIEIFNG = KADBECGIMPD.AGNKAFLKCAG();
			this.CNOLCNDBLJE = KADBECGIMPD.KKOKFLMMAAK();
			this.MODEOKGGDBD = KADBECGIMPD.OMCMPDMJFOJ();
		}

		// Token: 0x06007179 RID: 29049 RVA: 0x00363872 File Offset: 0x00361A72
		public void MCIKLDBPPFJ(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.DPLAJNEDGBL();
			this.HKHMIIEIFNG = KADBECGIMPD.KDNDJNEGBDI();
			this.CNOLCNDBLJE = KADBECGIMPD.IFDFHJLCHAE();
			this.MODEOKGGDBD = KADBECGIMPD.LAECLJFMGPE();
		}

		// Token: 0x0600717A RID: 29050 RVA: 0x003638AB File Offset: 0x00361AAB
		public void NNFFLNNJOBI(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.PNBECHOLCJM();
			this.HKHMIIEIFNG = KADBECGIMPD.LDLKLPJBIJN();
			this.CNOLCNDBLJE = KADBECGIMPD.HHLDBAEFNMJ();
			this.MODEOKGGDBD = KADBECGIMPD.DADCGPGEHFK();
		}

		// Token: 0x0600717B RID: 29051 RVA: 0x003638E4 File Offset: 0x00361AE4
		public void CIPALFKOHBK(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.FDIDEGHPJPF();
			this.HKHMIIEIFNG = KADBECGIMPD.HHLDBAEFNMJ();
			this.CNOLCNDBLJE = KADBECGIMPD.KKOKFLMMAAK();
			this.MODEOKGGDBD = KADBECGIMPD.IJJDHHFAIPE();
		}

		// Token: 0x0600717C RID: 29052 RVA: 0x0036391D File Offset: 0x00361B1D
		public void DFANMIPGKIP(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.NCODBGMGNFD();
			this.HKHMIIEIFNG = KADBECGIMPD.HDBGOLAFOBK();
			this.CNOLCNDBLJE = KADBECGIMPD.DOJKJHMJJNK();
			this.MODEOKGGDBD = KADBECGIMPD.JALHMJEKMHF();
		}

		// Token: 0x0600717D RID: 29053 RVA: 0x00363958 File Offset: 0x00361B58
		public override int HGFLLGHHJML(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 0;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x0600717E RID: 29054 RVA: 0x003639A1 File Offset: 0x00361BA1
		public void MPCIALDHHKN(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.DPLAJNEDGBL();
			this.HKHMIIEIFNG = KADBECGIMPD.CLPEKGGAMAI();
			this.CNOLCNDBLJE = KADBECGIMPD.CLPEKGGAMAI();
			this.MODEOKGGDBD = KADBECGIMPD.AJECAOJPOKA();
		}

		// Token: 0x0600717F RID: 29055 RVA: 0x003639DC File Offset: 0x00361BDC
		public virtual void MHBPPCKHKHO(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[5].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "IceHockeyShotLeft";
			}
			string text = string.Format("IKSolverFABRIKRoot chain at index ", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.IPIDCNGCDLE(1);
			if (this.HKHMIIEIFNG > 1)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.KOACFBDMKKB(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.HPPPPEHMEKL(this.HKHMIIEIFNG, this.BNIHFBMEPAB, true, true);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1944f);
			}
			else
			{
				component.text = text;
				component2.text = "FS ";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 984f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x06007180 RID: 29056 RVA: 0x00363B54 File Offset: 0x00361D54
		public virtual int NGKCHHLBEBJ(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 0;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x06007181 RID: 29057 RVA: 0x00363B9D File Offset: 0x00361D9D
		public void MBLEIMCGLCE(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.KDELAFDDGJH();
			this.HKHMIIEIFNG = KADBECGIMPD.LDLKLPJBIJN();
			this.CNOLCNDBLJE = KADBECGIMPD.CLPEKGGAMAI();
			this.MODEOKGGDBD = KADBECGIMPD.BEMFIFGOJBL();
		}

		// Token: 0x06007182 RID: 29058 RVA: 0x00363BD8 File Offset: 0x00361DD8
		public virtual int BEFFLFEPHMN(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 0;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x06007183 RID: 29059 RVA: 0x00363C21 File Offset: 0x00361E21
		public virtual string MDAPFDLEEGN()
		{
			return string.Format("---", this.BNIHFBMEPAB);
		}

		// Token: 0x06007184 RID: 29060 RVA: 0x00363C33 File Offset: 0x00361E33
		public void FKOKKENAAAB(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.KDELAFDDGJH();
			this.HKHMIIEIFNG = KADBECGIMPD.AGNKAFLKCAG();
			this.CNOLCNDBLJE = KADBECGIMPD.HDBGOLAFOBK();
			this.MODEOKGGDBD = KADBECGIMPD.BLNIHNKJJPJ();
		}

		// Token: 0x06007185 RID: 29061 RVA: 0x00363C6C File Offset: 0x00361E6C
		public void MGBIHPHPMBL(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.DPLAJNEDGBL();
			this.HKHMIIEIFNG = KADBECGIMPD.KDNDJNEGBDI();
			this.CNOLCNDBLJE = KADBECGIMPD.DOJKJHMJJNK();
			this.MODEOKGGDBD = KADBECGIMPD.LAECLJFMGPE();
		}

		// Token: 0x06007186 RID: 29062 RVA: 0x00363CA5 File Offset: 0x00361EA5
		public void APJEMENHACF(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.LPKJHMGLCKA();
			this.HKHMIIEIFNG = KADBECGIMPD.AGNKAFLKCAG();
			this.CNOLCNDBLJE = KADBECGIMPD.IFDFHJLCHAE();
			this.MODEOKGGDBD = KADBECGIMPD.LAECLJFMGPE();
		}

		// Token: 0x06007187 RID: 29063 RVA: 0x00363CDE File Offset: 0x00361EDE
		public void LOJPCMONNLI(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.DHCMILPKJAL();
			this.HKHMIIEIFNG = KADBECGIMPD.IFDFHJLCHAE();
			this.CNOLCNDBLJE = KADBECGIMPD.LDLKLPJBIJN();
			this.MODEOKGGDBD = KADBECGIMPD.JNOKJCDAPPA();
		}

		// Token: 0x06007188 RID: 29064 RVA: 0x00363D17 File Offset: 0x00361F17
		public virtual string NIDKKALEJIM()
		{
			return string.Format("19", this.BNIHFBMEPAB);
		}

		// Token: 0x06007189 RID: 29065 RVA: 0x00363D2C File Offset: 0x00361F2C
		public virtual int PFNMADDPJLK(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 1;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x0600718A RID: 29066 RVA: 0x00363D75 File Offset: 0x00361F75
		public override string BACHFNMDOLO()
		{
			return string.Format(" ", this.BNIHFBMEPAB);
		}

		// Token: 0x0600718B RID: 29067 RVA: 0x00363D88 File Offset: 0x00361F88
		public virtual int APCLCNBALEC(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 1;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x0600718C RID: 29068 RVA: 0x00363C6C File Offset: 0x00361E6C
		public void HIGGEJBKMJF(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.DPLAJNEDGBL();
			this.HKHMIIEIFNG = KADBECGIMPD.KDNDJNEGBDI();
			this.CNOLCNDBLJE = KADBECGIMPD.DOJKJHMJJNK();
			this.MODEOKGGDBD = KADBECGIMPD.LAECLJFMGPE();
		}

		// Token: 0x0600718D RID: 29069 RVA: 0x00363DD1 File Offset: 0x00361FD1
		public virtual string JDPKKGOOKDF()
		{
			return string.Format("sys", this.BNIHFBMEPAB);
		}

		// Token: 0x0600718E RID: 29070 RVA: 0x00363DE4 File Offset: 0x00361FE4
		public override int LCOMDAFAFIP(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 0;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x0600718F RID: 29071 RVA: 0x00363E2D File Offset: 0x0036202D
		public virtual string HLHHDFFDHGL()
		{
			return string.Format("shop_t11", this.BNIHFBMEPAB);
		}

		// Token: 0x06007190 RID: 29072 RVA: 0x00363E3F File Offset: 0x0036203F
		public virtual string IJOKJHOKJOB()
		{
			return string.Format("", this.BNIHFBMEPAB);
		}

		// Token: 0x06007191 RID: 29073 RVA: 0x00363E51 File Offset: 0x00362051
		public void LBBBADCPGOI(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.PNBECHOLCJM();
			this.HKHMIIEIFNG = KADBECGIMPD.CLPEKGGAMAI();
			this.CNOLCNDBLJE = KADBECGIMPD.DOJKJHMJJNK();
			this.MODEOKGGDBD = KADBECGIMPD.BLNIHNKJJPJ();
		}

		// Token: 0x06007192 RID: 29074 RVA: 0x00363E8A File Offset: 0x0036208A
		public virtual string JHHDLHJEEEB()
		{
			return string.Format("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_trigonometric_i_k.html", this.BNIHFBMEPAB);
		}

		// Token: 0x06007193 RID: 29075 RVA: 0x00363E9C File Offset: 0x0036209C
		public virtual string CCFEPJBGCEB()
		{
			return string.Format("_Bloom", this.BNIHFBMEPAB);
		}

		// Token: 0x06007194 RID: 29076 RVA: 0x00363EAE File Offset: 0x003620AE
		public virtual string CKAHIPBPLPM()
		{
			return string.Format("Fly Forward", this.BNIHFBMEPAB);
		}

		// Token: 0x06007195 RID: 29077 RVA: 0x00363EC0 File Offset: 0x003620C0
		public override void PIHHDONHBKF(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 1)
			{
				component3.text = "</color>";
			}
			string text = string.Format("Cloth_05_00.wav", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.MDLJBINCHEP(0);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.JCMJOKAIMLJ(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.DGEINNMPILO(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, true);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 908f);
			}
			else
			{
				component.text = text;
				component2.text = "ComeHere";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1505f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x06007196 RID: 29078 RVA: 0x00364038 File Offset: 0x00362238
		public virtual void NFINEOHFJJK(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[6].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[6].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "isAlwaisGetFish";
			}
			string text = string.Format("Flap_02.wav", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.JCMJOKAIMLJ(0);
			if (this.HKHMIIEIFNG > 1)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.AIELPFAHFOC(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.CNJKACEFHEI(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, false);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 509f);
			}
			else
			{
				component.text = text;
				component2.text = "icon_data/icon";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 652f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x06007197 RID: 29079 RVA: 0x003641B0 File Offset: 0x003623B0
		public virtual int KAHCHIDBKML(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 1;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x06007198 RID: 29080 RVA: 0x003641FC File Offset: 0x003623FC
		public virtual void PIKNKNNODAI(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[8].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 1)
			{
				component3.text = "crft_btn1";
			}
			string text = string.Format("Wheely No Hands", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.BNPKGGNMCML(1);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.IFJLOKKAAMK(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.HPLMICJFPAK(this.HKHMIIEIFNG, this.BNIHFBMEPAB, true, true);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1897f);
			}
			else
			{
				component.text = text;
				component2.text = "Attempting to RefreshSceneDecals without a packed material";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1457f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x06007199 RID: 29081 RVA: 0x00364371 File Offset: 0x00362571
		public virtual string EGHGJIBKNDN()
		{
			return string.Format("ok", this.BNIHFBMEPAB);
		}

		// Token: 0x0600719A RID: 29082 RVA: 0x00364384 File Offset: 0x00362584
		public virtual int OGHHHCFKBIB(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 1;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x0600719B RID: 29083 RVA: 0x003643CD File Offset: 0x003625CD
		public void JEPNENKOEOH(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.NCODBGMGNFD();
			this.HKHMIIEIFNG = KADBECGIMPD.KKOKFLMMAAK();
			this.CNOLCNDBLJE = KADBECGIMPD.CLPEKGGAMAI();
			this.MODEOKGGDBD = KADBECGIMPD.ELDBJFLCMAJ();
		}

		// Token: 0x0600719C RID: 29084 RVA: 0x00364408 File Offset: 0x00362608
		public virtual int BMDCHEODDGA(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 1;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x0600719D RID: 29085 RVA: 0x00364454 File Offset: 0x00362654
		public virtual void NLPHACBANBH(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[3].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "LOC_NAMES";
			}
			string text = string.Format("selectedTask", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.MDLJBINCHEP(0);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.PMJBHIIILIP(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.HBMGCEMAPOK(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, false);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 708f);
			}
			else
			{
				component.text = text;
				component2.text = "WorkerShovel2";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1975f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x0600719E RID: 29086 RVA: 0x003645C9 File Offset: 0x003627C9
		public void ODAFODFACKN(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.LPKJHMGLCKA();
			this.HKHMIIEIFNG = KADBECGIMPD.HDBGOLAFOBK();
			this.CNOLCNDBLJE = KADBECGIMPD.CLPEKGGAMAI();
			this.MODEOKGGDBD = KADBECGIMPD.FIFNOBGEKFF();
		}

		// Token: 0x0600719F RID: 29087 RVA: 0x00364602 File Offset: 0x00362802
		public virtual string EFODDEDDHCE()
		{
			return string.Format("http://www.root-motion.com/finalikdox/html/page10.html", this.BNIHFBMEPAB);
		}

		// Token: 0x060071A0 RID: 29088 RVA: 0x00364614 File Offset: 0x00362814
		public virtual string BDINNEPKJOJ()
		{
			return string.Format("_BlurRadius4", this.BNIHFBMEPAB);
		}

		// Token: 0x060071A1 RID: 29089 RVA: 0x00363D75 File Offset: 0x00361F75
		public virtual string NCNNJHIIAFM()
		{
			return string.Format(" ", this.BNIHFBMEPAB);
		}

		// Token: 0x060071A2 RID: 29090 RVA: 0x00364626 File Offset: 0x00362826
		public void NHHAANEMJCK(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.JJJJAGJCOGD();
			this.HKHMIIEIFNG = KADBECGIMPD.DOJKJHMJJNK();
			this.CNOLCNDBLJE = KADBECGIMPD.LDLKLPJBIJN();
			this.MODEOKGGDBD = KADBECGIMPD.IJJDHHFAIPE();
		}

		// Token: 0x060071A3 RID: 29091 RVA: 0x00364660 File Offset: 0x00362860
		public virtual void KJJGOPDNLGA(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[5].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "toFishPoint";
			}
			string text = string.Format("BowIdle", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.KOACFBDMKKB(1);
			if (this.HKHMIIEIFNG > 1)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.LPCFLOFAOMF(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.KOONNKMMCBB(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, true);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 383f);
			}
			else
			{
				component.text = text;
				component2.text = "SoccerKeeperDiveStrafeCloseLeft";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 69f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x060071A4 RID: 29092 RVA: 0x003647D8 File Offset: 0x003629D8
		public virtual void HCFHNBDIMOD(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[7].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[3].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 1)
			{
				component3.text = "SneakBackward";
			}
			string text = string.Format("FA ", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.CNENPBMADGI(1);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.PMJBHIIILIP(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.HPPPPEHMEKL(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, true);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 369f);
			}
			else
			{
				component.text = text;
				component2.text = "\n";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1214f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x060071A5 RID: 29093 RVA: 0x0036494D File Offset: 0x00362B4D
		public void FCGANCJIFAG(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.JJJJAGJCOGD();
			this.HKHMIIEIFNG = KADBECGIMPD.KKOKFLMMAAK();
			this.CNOLCNDBLJE = KADBECGIMPD.IFDFHJLCHAE();
			this.MODEOKGGDBD = KADBECGIMPD.LAECLJFMGPE();
		}

		// Token: 0x060071A6 RID: 29094 RVA: 0x00364988 File Offset: 0x00362B88
		public virtual void HGPPGJPEPEE(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[5].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[5].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "_BlurParams";
			}
			string text = string.Format("", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.CNENPBMADGI(0);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.JMODIGNMPJP(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.CABGPFFNFPH(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, true);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1307f);
			}
			else
			{
				component.text = text;
				component2.text = "<color=\"#02C85F\"><b>ObscuredPrefs:</b></color>\nsecure, lot of additional types and extra options";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 403f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x060071A7 RID: 29095 RVA: 0x00364AFD File Offset: 0x00362CFD
		public void EOECIOMLINH(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.NCODBGMGNFD();
			this.HKHMIIEIFNG = KADBECGIMPD.HDBGOLAFOBK();
			this.CNOLCNDBLJE = KADBECGIMPD.HDBGOLAFOBK();
			this.MODEOKGGDBD = KADBECGIMPD.BLNIHNKJJPJ();
		}

		// Token: 0x060071A8 RID: 29096 RVA: 0x00364B38 File Offset: 0x00362D38
		public virtual int EFIMMPGNCIB(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 0;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x060071A9 RID: 29097 RVA: 0x00364B81 File Offset: 0x00362D81
		public void GBIFKNOMLGN(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.NCODBGMGNFD();
			this.HKHMIIEIFNG = KADBECGIMPD.KDNDJNEGBDI();
			this.CNOLCNDBLJE = KADBECGIMPD.HHLDBAEFNMJ();
			this.MODEOKGGDBD = KADBECGIMPD.LAECLJFMGPE();
		}

		// Token: 0x060071AA RID: 29098 RVA: 0x00364BBA File Offset: 0x00362DBA
		public void OCPAHLAGCAI(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.BFPHBMDMODH();
			this.HKHMIIEIFNG = KADBECGIMPD.HDBGOLAFOBK();
			this.CNOLCNDBLJE = KADBECGIMPD.HDBGOLAFOBK();
			this.MODEOKGGDBD = KADBECGIMPD.FIFNOBGEKFF();
		}

		// Token: 0x060071AB RID: 29099 RVA: 0x00364BF4 File Offset: 0x00362DF4
		public virtual void MJJJHNJHIIM(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[8].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "t_eye";
			}
			string text = string.Format("Horizontal", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.DDLCBNBPEFI(0);
			if (this.HKHMIIEIFNG > 1)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.BNPKGGNMCML(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.CABGPFFNFPH(this.HKHMIIEIFNG, this.BNIHFBMEPAB, true, true);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 512f);
			}
			else
			{
				component.text = text;
				component2.text = "</color>";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 736f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x060071AC RID: 29100 RVA: 0x00364D6C File Offset: 0x00362F6C
		public virtual void BEHFOBHANKG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[6].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 1)
			{
				component3.text = "WorkerPickaxe";
			}
			string text = string.Format("Textures/alphaDemo", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.HGKEGJEKGJF(0);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.BNPKGGNMCML(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.EDCDLKNNBGC(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, false);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1535f);
			}
			else
			{
				component.text = text;
				component2.text = " ms";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 651f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x060071AD RID: 29101 RVA: 0x00364EE1 File Offset: 0x003630E1
		public void NCKKHDFHBEF(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.DPLAJNEDGBL();
			this.HKHMIIEIFNG = KADBECGIMPD.KDNDJNEGBDI();
			this.CNOLCNDBLJE = KADBECGIMPD.KDNDJNEGBDI();
			this.MODEOKGGDBD = KADBECGIMPD.FIFNOBGEKFF();
		}

		// Token: 0x060071AE RID: 29102 RVA: 0x00364F1A File Offset: 0x0036311A
		public virtual string FGNNJFJLENH()
		{
			return string.Format("{0:D2}:{1:D2}", this.BNIHFBMEPAB);
		}

		// Token: 0x060071AF RID: 29103 RVA: 0x00364F2C File Offset: 0x0036312C
		public virtual void DECGOJJCNCL(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[3].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[8].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 1)
			{
				component3.text = "\n";
			}
			string text = string.Format("_camIntensive", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.EPIPJGHICLD(1);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.KMCDCHNINAF(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.IAIPLNNKKPK(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, false);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 426f);
			}
			else
			{
				component.text = text;
				component2.text = " ";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 562f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x060071B0 RID: 29104 RVA: 0x003650A1 File Offset: 0x003632A1
		public void DIAMCIJNACK(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.PNBECHOLCJM();
			this.HKHMIIEIFNG = KADBECGIMPD.LDLKLPJBIJN();
			this.CNOLCNDBLJE = KADBECGIMPD.HHLDBAEFNMJ();
			this.MODEOKGGDBD = KADBECGIMPD.IJJDHHFAIPE();
		}

		// Token: 0x060071B1 RID: 29105 RVA: 0x00363E3F File Offset: 0x0036203F
		public virtual string FOIFFCPAJMI()
		{
			return string.Format("", this.BNIHFBMEPAB);
		}

		// Token: 0x060071B2 RID: 29106 RVA: 0x003650DC File Offset: 0x003632DC
		public virtual void LLGDGMHIGHM(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[3].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[5].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 1)
			{
				component3.text = "BowIdle";
			}
			string text = string.Format("Bases/Base_1.unity3d", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.EPIPJGHICLD(1);
			if (this.HKHMIIEIFNG > 1)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.PKADGGDGBGO(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.BOOJJNEMLIF(this.HKHMIIEIFNG, this.BNIHFBMEPAB, true, true);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1979f);
			}
			else
			{
				component.text = text;
				component2.text = "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_target.html";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 37f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x060071B3 RID: 29107 RVA: 0x00365251 File Offset: 0x00363451
		public virtual string KCBJCGOINMK()
		{
			return string.Format("IdleReadyLook", this.BNIHFBMEPAB);
		}

		// Token: 0x060071B4 RID: 29108 RVA: 0x00365264 File Offset: 0x00363464
		public virtual int KLKGLIEODAI(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 1;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x060071B5 RID: 29109 RVA: 0x003652B0 File Offset: 0x003634B0
		public virtual int FDDCPGNMHPO(ItemBase BBIDMPHDHDG)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)BBIDMPHDHDG;
			if (this.MODEOKGGDBD && !edpnahlghpl.MODEOKGGDBD)
			{
				return -1;
			}
			if (edpnahlghpl.MODEOKGGDBD && !this.MODEOKGGDBD)
			{
				return 0;
			}
			return this.BNIHFBMEPAB.CompareTo(edpnahlghpl.BNIHFBMEPAB);
		}

		// Token: 0x060071B6 RID: 29110 RVA: 0x003652FC File Offset: 0x003634FC
		public virtual void PFEMGKJGDBM(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[2].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 0)
			{
				component3.text = "Femur";
			}
			string text = string.Format(" length is zero.", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.LDMBLNONMOI(0);
			if (this.HKHMIIEIFNG > 0)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.BNPKGGNMCML(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.GLFILPFCMGN(this.HKHMIIEIFNG, this.BNIHFBMEPAB, true, true);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1072f);
			}
			else
			{
				component.text = text;
				component2.text = "cht_msg13";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 1651f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x060071B7 RID: 29111 RVA: 0x00365471 File Offset: 0x00363671
		public virtual string AGFCIEALPEM()
		{
			return string.Format("_Parameter", this.BNIHFBMEPAB);
		}

		// Token: 0x060071B8 RID: 29112 RVA: 0x00365483 File Offset: 0x00363683
		public void PODGKHBLJED(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.PNBECHOLCJM();
			this.HKHMIIEIFNG = KADBECGIMPD.HDBGOLAFOBK();
			this.CNOLCNDBLJE = KADBECGIMPD.HHLDBAEFNMJ();
			this.MODEOKGGDBD = KADBECGIMPD.FIFNOBGEKFF();
		}

		// Token: 0x060071B9 RID: 29113 RVA: 0x003654BC File Offset: 0x003636BC
		public override string PGJOHGFNAPC()
		{
			return string.Format("wpn_wgt", this.BNIHFBMEPAB);
		}

		// Token: 0x060071BA RID: 29114 RVA: 0x003654CE File Offset: 0x003636CE
		public override string KJFKHMONBLB()
		{
			return string.Format("TOD_LocalSunDirection", this.BNIHFBMEPAB);
		}

		// Token: 0x060071BB RID: 29115 RVA: 0x003654E0 File Offset: 0x003636E0
		public void DCBEEHGGPKE(long GDMOJDPAMMN, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = GDMOJDPAMMN;
			this.BNIHFBMEPAB = KADBECGIMPD.KDELAFDDGJH();
			this.HKHMIIEIFNG = KADBECGIMPD.KDNDJNEGBDI();
			this.CNOLCNDBLJE = KADBECGIMPD.LDLKLPJBIJN();
			this.MODEOKGGDBD = KADBECGIMPD.JALHMJEKMHF();
		}

		// Token: 0x060071BC RID: 29116 RVA: 0x0036551C File Offset: 0x0036371C
		public virtual void IGDKCNKKFNP(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			Text component = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			Text component2 = IKPEEEBENDE[7].gameObject.GetComponent<Text>();
			Text component3 = IKPEEEBENDE[5].gameObject.GetComponent<Text>();
			component3.text = string.Concat(this.CNOLCNDBLJE);
			if (this.CNOLCNDBLJE <= 1)
			{
				component3.text = "";
			}
			string text = string.Format("wpn_tank1", this.BNIHFBMEPAB);
			bool isEditor = Application.isEditor;
			Color color = NHCAOFIKNFE.IKGFHGKKCPG.POHHAIPMJOA(0);
			if (this.HKHMIIEIFNG > 1)
			{
				component.text = text;
				color = NHCAOFIKNFE.IKGFHGKKCPG.EPIPJGHICLD(this.HKHMIIEIFNG);
				component2.text = NHCAOFIKNFE.IKGFHGKKCPG.BCDJLDLHEKP(this.HKHMIIEIFNG, this.BNIHFBMEPAB, false, true);
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 178f);
			}
			else
			{
				component.text = text;
				component2.text = "dropMass";
				ONPHLHKAGFP.sizeDelta = new Vector2(ONPHLHKAGFP.sizeDelta.x, 138f);
			}
			component.color = color;
			component2.color = color;
			if (this.KNDGFKKALCE)
			{
				component.color = Color.red;
				component2.color = Color.red;
				component3.color = Color.red;
			}
			if (!this.MODEOKGGDBD)
			{
				component.color = Color.gray;
				component2.color = Color.gray;
				component3.color = Color.gray;
			}
		}

		// Token: 0x040010A5 RID: 4261
		public long LPFKFNLHGBI;

		// Token: 0x040010A6 RID: 4262
		public string BNIHFBMEPAB;

		// Token: 0x040010A7 RID: 4263
		public int HKHMIIEIFNG;

		// Token: 0x040010A8 RID: 4264
		public int IAEKCPIHMKC;

		// Token: 0x040010A9 RID: 4265
		public int CNOLCNDBLJE;

		// Token: 0x040010AA RID: 4266
		public bool MODEOKGGDBD;

		// Token: 0x040010AB RID: 4267
		public bool EFFAHDKPOJA;

		// Token: 0x040010AC RID: 4268
		public bool KNDGFKKALCE;
	}

	// Token: 0x020001EC RID: 492
	public class PIGPIKMNNLH
	{
		// Token: 0x060071BD RID: 29117 RVA: 0x00365694 File Offset: 0x00363894
		public string FJFNCEBFAGF(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == " ")
				{
					text = string.Format(" ", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("_FrustumCornersWS"));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("DENSITY", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("wpn_add/base"));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("FrontKick", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("_TempRT"));
				}
				else
				{
					text = string.Format("TOD_LocalSunDirection", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("Crouch Strafe Left"));
				}
			}
			else
			{
				text = string.Format("Roll", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("_SSAO"));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "fishRSPEED=", string.Empty);
			}
			return text;
		}

		// Token: 0x060071BE RID: 29118 RVA: 0x00365800 File Offset: 0x00363A00
		public PIGPIKMNNLH(HBPNMNGOFMA KADBECGIMPD)
		{
			this.PPICJOPPOLK = KADBECGIMPD.HDBGOLAFOBK();
			this.OELGGLIHFIH = KADBECGIMPD.DNIIFBAIPBE();
			this.DELFGPAPOPB = KADBECGIMPD.BFPHBMDMODH();
			long num = KADBECGIMPD.DNIIFBAIPBE();
			string bnihfbmepab = KADBECGIMPD.BFPHBMDMODH();
			this.IABKGMNJLJO = KADBECGIMPD.BFPHBMDMODH();
			string text = KADBECGIMPD.BFPHBMDMODH();
			this.POILPDMECGD = (num > 0L);
			if (this.POILPDMECGD)
			{
				this.PPICJOPPOLK = 3;
			}
			if (this.PPICJOPPOLK == 0)
			{
				text = "sys";
			}
			if (this.PPICJOPPOLK == 1)
			{
				text = "loc";
			}
			if (this.PPICJOPPOLK == 3)
			{
				text = "private";
			}
			if (this.PPICJOPPOLK == 10)
			{
				text = "help";
			}
			Debug.Log(string.Concat(new object[]
			{
				"msg from NET channel=",
				this.PPICJOPPOLK,
				" cname=",
				text
			}));
			this.BDELNBNMOPB = OAFJCFOGGAF.IKGFHGKKCPG.MJGADELHFID(text, this.PPICJOPPOLK);
			if (this.PPICJOPPOLK == 3)
			{
				if (this.OELGGLIHFIH != JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI)
				{
					OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(this.OELGGLIHFIH);
					edpnahlghpl.BNIHFBMEPAB = this.DELFGPAPOPB;
					edpnahlghpl.MODEOKGGDBD = true;
					if (!this.BDELNBNMOPB.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
					{
						this.BDELNBNMOPB.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
						if (ChatPanelLogic.getI != null && OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == 3)
						{
							ChatPanelLogic.getI.updateUserList();
						}
					}
				}
				if (num != JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI)
				{
					OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl2 = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
					edpnahlghpl2.BNIHFBMEPAB = bnihfbmepab;
					if (!this.BDELNBNMOPB.JIKGMLGOAPG.ContainsKey(edpnahlghpl2.LPFKFNLHGBI))
					{
						this.BDELNBNMOPB.JIKGMLGOAPG.Add(edpnahlghpl2.LPFKFNLHGBI, edpnahlghpl2);
						if (ChatPanelLogic.getI != null && OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == 3)
						{
							ChatPanelLogic.getI.updateUserList();
						}
					}
				}
			}
			this.CMBCLFLMAPE = DateTime.Now;
			ActorMgr.getI.chatMsg(this);
			if (JBEHMPDDMME.IKGFHGKKCPG != null && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null && this.OELGGLIHFIH == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI)
			{
				Fisherman.getI.onChatMessage(this.PPICJOPPOLK, this.IABKGMNJLJO);
			}
		}

		// Token: 0x060071BF RID: 29119 RVA: 0x00365A64 File Offset: 0x00363C64
		public string CKAKMOCHBLF(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "sys")
				{
					text = string.Format("<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("H:mm:ss"));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("<color='#FF8C42'>[{2}]</color> <color='#FF8C42'>{0}: {1}</color>", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("H:mm:ss"));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("H:mm:ss"));
				}
				else
				{
					text = string.Format("<color='#808080'>[{2}]</color> <color='#c0c0c0'>{0}</color>: {1}", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("H:mm:ss"));
				}
			}
			else
			{
				text = string.Format("<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("H:mm:ss"));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "<.*?>", string.Empty);
			}
			return text;
		}

		// Token: 0x060071C0 RID: 29120 RVA: 0x00365BD0 File Offset: 0x00363DD0
		public string MONLKCBHBHE(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "Left")
				{
					text = string.Format("Open openTurnirWindow", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("Soccer Walk"));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("_CurrentMipLevel", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("VIGNETTE_BLUR"));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("Weapon Fire", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("wpn_add/base"));
				}
				else
				{
					text = string.Format("SoccerSprint", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("__MirrorDeep"));
				}
			}
			else
			{
				text = string.Format("_FarCorner", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString(""));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "stopping ", string.Empty);
			}
			return text;
		}

		// Token: 0x060071C1 RID: 29121 RVA: 0x00365D3C File Offset: 0x00363F3C
		public string MCODMIFIAHO(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "SoccerKeeperDiveStrafeCloseRight")
				{
					text = string.Format("Try to change this float in memory:\n", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("invn_rec27"));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("BipedReferences spine bone at index ", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("wpn_add/base"));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("MotorbikeTurnLeft", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("_AdaptTex"));
				}
				else
				{
					text = string.Format("double:", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("<.*?>"));
				}
			}
			else
			{
				text = string.Format("IdleSandCover", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("act_orderb_"));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "loc", string.Empty);
			}
			return text;
		}

		// Token: 0x060071C2 RID: 29122 RVA: 0x00365EA8 File Offset: 0x003640A8
		public string NNONJGMPCDM(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "wpn_popl1")
				{
					text = string.Format("EndPhysPoint", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("gi_uinf_0"));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("Mouse X", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString(""));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("USER ID=", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("SoccerTackle"));
				}
				else
				{
					text = string.Format("_Bloom", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("BattleRoar"));
				}
			}
			else
			{
				text = string.Format("Error via final request", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("0+100"));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "_Vignette_Settings", string.Empty);
			}
			return text;
		}

		// Token: 0x060071C3 RID: 29123 RVA: 0x00366014 File Offset: 0x00364214
		public string CMPFHBMPJGG(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "inv_dur")
				{
					text = string.Format("FOG_POINT_LIGHT", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("---"));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("BowIdle", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("calf"));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("turn_tminfo", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("CheerKnees"));
				}
				else
				{
					text = string.Format("_RcpMaxBlurRadius", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("System.Boolean"));
				}
			}
			else
			{
				text = string.Format("_ColorDownsampled", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("_ChannelMixerGreen"));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "No IK assigned in HitReaction", string.Empty);
			}
			return text;
		}

		// Token: 0x060071C4 RID: 29124 RVA: 0x00366180 File Offset: 0x00364380
		public string EMGBBOOBAHI(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "float: ")
				{
					text = string.Format("Windmill", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("sound"));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("</color>", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("IdleFly"));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("Water Refl Camera id", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("IdleDodgeRight"));
				}
				else
				{
					text = string.Format("GiantGrabIdle", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("17"));
				}
			}
			else
			{
				text = string.Format("wpn_eat5", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("Show last 128 records"));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "6", string.Empty);
			}
			return text;
		}

		// Token: 0x060071C5 RID: 29125 RVA: 0x003662EC File Offset: 0x003644EC
		public string LDBHBKBPJAA(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "OnTriggerEnter")
				{
					text = string.Format("Sexy Dance 3", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("MotorbikeLassoLeft"));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format(" ", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("Sitting Reading Page Flip"));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("\n", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("Jump"));
				}
				else
				{
					text = string.Format("MotorbikeIdle", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("PLANE_REFLECTION_CHEAPER"));
				}
			}
			else
			{
				text = string.Format("info", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("Mouse ScrollWheel"));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "sunshine_ShadowParamsAndHalfTexel", string.Empty);
			}
			return text;
		}

		// Token: 0x060071C6 RID: 29126 RVA: 0x00366458 File Offset: 0x00364658
		public string BCDAEDNDIBG(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "IdleRun")
				{
					text = string.Format("ScubaOK", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("] is null."));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("WRINKLE_MAPS", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString(" "));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("human_move_2.wav", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("error.wav"));
				}
				else
				{
					text = string.Format("Horizontal", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("The InteractionTrigger in the list 'inContact' has been destroyed"));
				}
			}
			else
			{
				text = string.Format("rait_3", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("\n<color='#406000'>------------------------------------------------------------------------------------------------------------</color>\n"));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "SoccerSprint", string.Empty);
			}
			return text;
		}

		// Token: 0x060071C7 RID: 29127 RVA: 0x003665C2 File Offset: 0x003647C2
		public PIGPIKMNNLH(OAFJCFOGGAF.EDPNAHLGHPL BBIDMPHDHDG)
		{
			this.OELGGLIHFIH = BBIDMPHDHDG.LPFKFNLHGBI;
			this.DELFGPAPOPB = BBIDMPHDHDG.BNIHFBMEPAB;
			this.IABKGMNJLJO = "";
		}

		// Token: 0x060071C8 RID: 29128 RVA: 0x003665F0 File Offset: 0x003647F0
		public string FGDAEJPLPKL(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "Swim")
				{
					text = string.Format("{0}:{1}:{2}:{3}", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("_UserLutParams"));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("hgtDst=", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("fanfare.wav"));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("Shotgun Reload Magazine", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("#80ff00"));
				}
				else
				{
					text = string.Format("HDR", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("Assets/Weapons/wbaseJaket.unity3d"));
				}
			}
			else
			{
				text = string.Format("knopje.wav", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("ACTk has secure layer for the PlayerPrefs: <color=\"#75C4EB\">ObscuredPrefs</color>. It protects data from view, detects any cheating attempts, optionally locks data to the current device and supports additional data types."));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "IKMappingBone's bone is null.", string.Empty);
			}
			return text;
		}

		// Token: 0x060071C9 RID: 29129 RVA: 0x0036675C File Offset: 0x0036495C
		public string HEMFCGODHLK(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "Vader Choke")
				{
					text = string.Format("wpn_wgt", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("id"));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("TOD_MoonMeshBrightness", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString(""));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("_TrStartYou.ogg", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("#ff80ff"));
				}
				else
				{
					text = string.Format("' is not a valid integer", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("_SecondTex"));
				}
			}
			else
			{
				text = string.Format("titul", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("MotorbikeLasso"));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "", string.Empty);
			}
			return text;
		}

		// Token: 0x060071CA RID: 29130 RVA: 0x003668C8 File Offset: 0x00364AC8
		public string LFHOPKPNPNG(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "Roller Blade Stop")
				{
					text = string.Format("CrouchWalkBackward", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("demoVector3"));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("post_4", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("WeaponRun"));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("_SampleScale", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("RunBackLeft"));
				}
				else
				{
					text = string.Format("{0}Textures/Turnirs/{1}.png", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("Criticals"));
				}
			}
			else
			{
				text = string.Format("error.wav", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("AFCServer"));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "_Offset", string.Empty);
			}
			return text;
		}

		// Token: 0x060071CB RID: 29131 RVA: 0x00366A34 File Offset: 0x00364C34
		public string JIOEDJGLMFJ(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "GiantGrabThrow2")
				{
					text = string.Format("_BokehParams", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString(""));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("RHandPunch", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("ShotgunReloadChamber"));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("<<", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("cht_msg17"));
				}
				else
				{
					text = string.Format("http://www.root-motion.com/finalikdox/html/page10.html", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("<color='#60a0ff'>{0}</color>\n<color='#ffff60'>Всего выловлено: <color='#ffffa0'>{1}</color> шт Общим весом <color='#ffffa0'>{2}</color>\nЛичный рекорд <color='#ffffa0'>{3}</color> </color>"));
				}
			}
			else
			{
				text = string.Format("threshold", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("error.wav"));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "★{0}", string.Empty);
			}
			return text;
		}

		// Token: 0x060071CC RID: 29132 RVA: 0x00366BA0 File Offset: 0x00364DA0
		public string PJHAJNLEPDD(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "_Color")
				{
					text = string.Format("_ALPHABLEND_ON", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("S"));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("invn_rec13", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString(""));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("IdleSpew", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("IdleMonster"));
				}
				else
				{
					text = string.Format("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString(" x"));
				}
			}
			else
			{
				text = string.Format("_OcclusionTexture", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString(""));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "ui_default_click.wav", string.Empty);
			}
			return text;
		}

		// Token: 0x060071CD RID: 29133 RVA: 0x00366D0C File Offset: 0x00364F0C
		public string JJPDMCFOMLE(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "WandAttack2")
				{
					text = string.Format("USE_UV_BASED_REPROJECTION", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("минута"));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("WandStand", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("Node transform is null in FBIK chain."));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("Water", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("wpn_dress2"));
				}
				else
				{
					text = string.Format("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_i_k.html", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("WandAttack2"));
				}
			}
			else
			{
				text = string.Format("Bases/{0}/", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("****** locscount="));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "intensity", string.Empty);
			}
			return text;
		}

		// Token: 0x060071CE RID: 29134 RVA: 0x00366E78 File Offset: 0x00365078
		public string MLKGFHKOCBB(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "short:")
				{
					text = string.Format("1 Hand Sword Run", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("_Curve"));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("IdleStand", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("{not_found}"));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("PaperTurn.wav", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("StaffAttack"));
				}
				else
				{
					text = string.Format("change me!", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("Breakdancing"));
				}
			}
			else
			{
				text = string.Format("loc_", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("_TapHigh"));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, " ", string.Empty);
			}
			return text;
		}

		// Token: 0x060071CF RID: 29135 RVA: 0x00366FE2 File Offset: 0x003651E2
		public PIGPIKMNNLH(OAFJCFOGGAF.LNHMFJDMOKP BNDBLKEKLDG, string GMNLJGNOKPD, string BMLEPFFGKBN, bool EPMKDNNIPKD = false)
		{
			this.DELFGPAPOPB = GMNLJGNOKPD;
			this.POILPDMECGD = EPMKDNNIPKD;
			this.IABKGMNJLJO = BMLEPFFGKBN;
			this.BDELNBNMOPB = BNDBLKEKLDG;
			this.CMBCLFLMAPE = DateTime.Now;
			OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("OnChatMessage", this);
		}

		// Token: 0x060071D0 RID: 29136 RVA: 0x00367024 File Offset: 0x00365224
		public string MIHBKFBAJHH(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "8192")
				{
					text = string.Format("ncht_ach1", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString(""));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("IdleBandage", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("RunningDance"));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("\n"));
				}
				else
				{
					text = string.Format("KatanaVerticalSwing", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("http://www.root-motion.com/finalikdox/html/page12.html"));
				}
			}
			else
			{
				text = string.Format(" iterations for read and write", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("WizardBlock"));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "Mouse Y", string.Empty);
			}
			return text;
		}

		// Token: 0x060071D1 RID: 29137 RVA: 0x00367190 File Offset: 0x00365390
		public string DKIKABEFEGM(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "IdleMeditate")
				{
					text = string.Format("- ", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("run_cnt"));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("1HandSwordRollAttack", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("\n"));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("autherror", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("Tonemapper curve texture"));
				}
				else
				{
					text = string.Format("JumpLeg", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("actor instaniateReel 4 "));
				}
			}
			else
			{
				text = string.Format("loadRodObject ", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("wpn_eat3"));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "TOD_kSun", string.Empty);
			}
			return text;
		}

		// Token: 0x060071D2 RID: 29138 RVA: 0x003672FC File Offset: 0x003654FC
		public string ALEEMFNNOPJ(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "u_UniqueShadowFilterWidth")
				{
					text = string.Format("Loading Asset Bundle ", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString(""));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("_ChromaticAberration", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("-l-"));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("SoccerKeeperDiveStrafeCloseRight", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("_TrStartYou.ogg"));
				}
				else
				{
					text = string.Format("Idle Ready", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("[fish]"));
				}
			}
			else
			{
				text = string.Format(" locid=", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("icon_data/icon"));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "Speed hack detected!", string.Empty);
			}
			return text;
		}

		// Token: 0x060071D3 RID: 29139 RVA: 0x00367468 File Offset: 0x00365668
		public string OPLBIOGKINC(bool BGNPMOCLIGL = true, bool EFLPJHMLOOA = false)
		{
			string text;
			if (BGNPMOCLIGL)
			{
				if (string.IsNullOrEmpty(this.DELFGPAPOPB))
				{
					text = this.IABKGMNJLJO;
				}
				else if (this.BDELNBNMOPB.OFALPEIEOJE == "_FresnelFade")
				{
					text = string.Format("gi_uinf_2", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("["));
				}
				else if (this.POILPDMECGD)
				{
					text = string.Format("RodParams not found!", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("Run Back Right"));
				}
				else if (this.OELGGLIHFIH == JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.LPFKFNLHGBI || this.IABKGMNJLJO.Contains(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB))
				{
					text = string.Format("Assets/Weapons/baseLegs.unity3d", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("_RgbTex"));
				}
				else
				{
					text = string.Format("GiantGrabIdle2", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("VaderChoke"));
				}
			}
			else
			{
				text = string.Format("", this.DELFGPAPOPB, this.IABKGMNJLJO, this.CMBCLFLMAPE.ToString("RollerBladeSkateFwd"));
			}
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "", string.Empty);
			}
			return text;
		}

		// Token: 0x040010AD RID: 4269
		public bool POILPDMECGD;

		// Token: 0x040010AE RID: 4270
		public long OELGGLIHFIH;

		// Token: 0x040010AF RID: 4271
		public string DELFGPAPOPB;

		// Token: 0x040010B0 RID: 4272
		public DateTime CMBCLFLMAPE;

		// Token: 0x040010B1 RID: 4273
		public OAFJCFOGGAF.LNHMFJDMOKP BDELNBNMOPB;

		// Token: 0x040010B2 RID: 4274
		public string IABKGMNJLJO;

		// Token: 0x040010B3 RID: 4275
		public int PPICJOPPOLK;
	}

	// Token: 0x020001ED RID: 493
	public class LNHMFJDMOKP
	{
		// Token: 0x060071D4 RID: 29140 RVA: 0x003675D4 File Offset: 0x003657D4
		public void IIJDOLAIIII(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.IJDIMHAEAIE();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
			edpnahlghpl.FNJFCJFAJFG(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 1)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("ArmFlex6", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("FA", edpnahlghpl);
			}
		}

		// Token: 0x060071D5 RID: 29141 RVA: 0x00367678 File Offset: 0x00365878
		public void AIPGGLPDCIH(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "<.*?>";
			while (!KADBECGIMPD.BKIBKLFCCGP())
			{
				long num = KADBECGIMPD.IBKCNEICPEL();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
				edpnahlghpl.HIGGEJBKMJF(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 6)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "1,2,3,4,5";
			}
		}

		// Token: 0x060071D6 RID: 29142 RVA: 0x003676EC File Offset: 0x003658EC
		public string LEFOLBJDHLL(bool BGNPMOCLIGL = true)
		{
			string text = "USE_DEPTH";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "RodParams not found!" + pigpikmnnlh.MLKGFHKOCBB(BGNPMOCLIGL, false);
			}
			return text;
		}

		// Token: 0x060071D7 RID: 29143 RVA: 0x00367754 File Offset: 0x00365954
		public void IMPBFDMKMBM(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.HHMGLDMFCPF();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
			edpnahlghpl.DCBEEHGGPKE(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 0)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("GetMouseButtonUp reboot", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("isRun", edpnahlghpl);
			}
		}

		// Token: 0x060071D8 RID: 29144 RVA: 0x003677F8 File Offset: 0x003659F8
		public string EKKKEFCIDIJ(bool BGNPMOCLIGL = true)
		{
			string text = "SoccerKeeperStrafeLeft";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "NO TURN" + pigpikmnnlh.OPLBIOGKINC(BGNPMOCLIGL, false);
			}
			return text;
		}

		// Token: 0x060071D9 RID: 29145 RVA: 0x00367860 File Offset: 0x00365A60
		public void GJIMMEHCAOG(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "MotorbikeShootRight";
			while (!KADBECGIMPD.NNOJEFMEGEG())
			{
				long num = KADBECGIMPD.IJDIMHAEAIE();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
				edpnahlghpl.AKMLEEPJPPL(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 5)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "wpn_cmp";
			}
		}

		// Token: 0x060071DA RID: 29146 RVA: 0x003678D4 File Offset: 0x00365AD4
		public void AHCLOAFECJP(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.EJPMFEJBGMN();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 8)
				{
					edpnahlghpl.MODEOKGGDBD = false;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("Worker Hammer", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("post_23", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x060071DB RID: 29147 RVA: 0x00367968 File Offset: 0x00365B68
		public string BLGIGJJOJLM(bool BGNPMOCLIGL = true)
		{
			string text = "demoByteArray";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "Autoclear" + pigpikmnnlh.PJHAJNLEPDD(BGNPMOCLIGL, true);
			}
			return text;
		}

		// Token: 0x060071DC RID: 29148 RVA: 0x003679D0 File Offset: 0x00365BD0
		public void ANDDEHEKLPK(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.DNIIFBAIPBE();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
			edpnahlghpl.DIAMCIJNACK(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 2)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("LDR", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("Roll", edpnahlghpl);
			}
		}

		// Token: 0x060071DD RID: 29149 RVA: 0x00367A74 File Offset: 0x00365C74
		public void JGMNDODNKIO(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.HFOPFEJDJFG();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.LBBBADCPGOI(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 3)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("BlendMaterial", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("MotorbikeLookBack", edpnahlghpl);
			}
		}

		// Token: 0x060071DE RID: 29150 RVA: 0x00367B18 File Offset: 0x00365D18
		public string NDDJPKHMEFE(bool BGNPMOCLIGL = true)
		{
			string text = "name";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "money" + pigpikmnnlh.MCODMIFIAHO(BGNPMOCLIGL, true);
			}
			return text;
		}

		// Token: 0x060071DF RID: 29151 RVA: 0x00367B80 File Offset: 0x00365D80
		public void EOOAAPDIDCO(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.IJDIMHAEAIE();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 6)
				{
					edpnahlghpl.MODEOKGGDBD = true;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("wpn_eat4", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("shop_t16", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x060071E0 RID: 29152 RVA: 0x00367C14 File Offset: 0x00365E14
		public void DJOIBNMDONB(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "RollerBladeBackFlip";
			while (!KADBECGIMPD.INLBHLOLOJH())
			{
				long num = KADBECGIMPD.EJPMFEJBGMN();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
				edpnahlghpl.KOBJOJMPFGC(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 6)
				{
					edpnahlghpl.EFFAHDKPOJA = true;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "StartTests";
			}
		}

		// Token: 0x060071E1 RID: 29153 RVA: 0x00367C88 File Offset: 0x00365E88
		public void ENGJGCHKANL(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.HHMGLDMFCPF();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
			edpnahlghpl.JHLCFAGDNKM(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 5)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD(": ", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("_RgbTex", edpnahlghpl);
			}
		}

		// Token: 0x060071E2 RID: 29154 RVA: 0x00367D2C File Offset: 0x00365F2C
		public LNHMFJDMOKP(int LPFKFNLHGBI, string ODMIONDMCKF)
		{
			this.OFALPEIEOJE = ODMIONDMCKF;
			this.NDDLLPAIHGM = LPFKFNLHGBI;
			this.PNLAPCGPDDL = new List<OAFJCFOGGAF.PIGPIKMNNLH>();
			if (this.PNLAPCGPDDL.Count > 20)
			{
				this.PNLAPCGPDDL.RemoveAt(0);
			}
		}

		// Token: 0x060071E3 RID: 29155 RVA: 0x00367D80 File Offset: 0x00365F80
		public void EDNNOAMINHH(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "";
			while (!KADBECGIMPD.PPAHBNGECGH())
			{
				long num = KADBECGIMPD.IJDIMHAEAIE();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
				edpnahlghpl.KAOKKLLOFBE(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 7)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "invn_rec20";
			}
		}

		// Token: 0x060071E4 RID: 29156 RVA: 0x00367DF4 File Offset: 0x00365FF4
		public void LEHNFJMMBCN(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.DMABDIGCLKA();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 3)
				{
					edpnahlghpl.MODEOKGGDBD = true;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("SoundData", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x060071E5 RID: 29157 RVA: 0x00367E88 File Offset: 0x00366088
		public string AHPHPLBOIAF(bool BGNPMOCLIGL = true)
		{
			string text = "Please select the effectors to interact with.";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "Color Grading Log LUT" + pigpikmnnlh.MONLKCBHBHE(BGNPMOCLIGL, true);
			}
			return text;
		}

		// Token: 0x060071E6 RID: 29158 RVA: 0x00367EF0 File Offset: 0x003660F0
		public void JMADAAHGPPG(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.HFOPFEJDJFG();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
			edpnahlghpl.DCBEEHGGPKE(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 1)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("VaderChoke", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("dropMass", edpnahlghpl);
			}
		}

		// Token: 0x060071E7 RID: 29159 RVA: 0x00367F94 File Offset: 0x00366194
		public void CNIBNDBFFDO(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "";
			while (!KADBECGIMPD.JCEGOADAOOI)
			{
				long num = KADBECGIMPD.DNIIFBAIPBE();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
				edpnahlghpl.OCPAHLAGCAI(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 2)
				{
					edpnahlghpl.EFFAHDKPOJA = true;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + " ";
			}
		}

		// Token: 0x060071E8 RID: 29160 RVA: 0x00368008 File Offset: 0x00366208
		public void MAPMCHPMPNB(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.HFOPFEJDJFG();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 0)
				{
					edpnahlghpl.MODEOKGGDBD = true;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("RollerBladeStop", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("<color='{0}'>{1}</color>", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x060071E9 RID: 29161 RVA: 0x0036809C File Offset: 0x0036629C
		public void GMBFGNLHJBK(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "StrafeRunRight";
			while (!KADBECGIMPD.DFLKBBNOGBG())
			{
				long num = KADBECGIMPD.DCGEOFHNBCN();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
				edpnahlghpl.COMPGPHIOPJ(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 2)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "FOG_OF_WAR_ON";
			}
		}

		// Token: 0x060071EA RID: 29162 RVA: 0x00368110 File Offset: 0x00366310
		public string GEGNAKKDNND(bool BGNPMOCLIGL = true)
		{
			string text = "Anchore Left_";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "loc" + pigpikmnnlh.FJFNCEBFAGF(BGNPMOCLIGL, false);
			}
			return text;
		}

		// Token: 0x060071EB RID: 29163 RVA: 0x00368178 File Offset: 0x00366378
		public void IDCDFDGPLKF(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.IBKCNEICPEL();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.DCBEEHGGPKE(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 1)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("wpn_izn", edpnahlghpl);
			}
		}

		// Token: 0x060071EC RID: 29164 RVA: 0x0036821C File Offset: 0x0036641C
		public void HDODIIJPHEO(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.DNIIFBAIPBE();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 5)
				{
					edpnahlghpl.MODEOKGGDBD = true;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("#FF4040", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("name", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x060071ED RID: 29165 RVA: 0x003682B0 File Offset: 0x003664B0
		public void IIFJKPHDKDN(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.HFOPFEJDJFG();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 8)
				{
					edpnahlghpl.MODEOKGGDBD = true;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("Space reference not set.", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("HA ", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x060071EE RID: 29166 RVA: 0x00368344 File Offset: 0x00366544
		public void EALLCDNCHEI(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.HHMGLDMFCPF();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 3)
				{
					edpnahlghpl.MODEOKGGDBD = false;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("Horizontal", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD(" has been disabled as it's not supported on the current platform.", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x060071EF RID: 29167 RVA: 0x003683D8 File Offset: 0x003665D8
		public string MMLEMPCMDNH(bool BGNPMOCLIGL = true)
		{
			string text = "float: ";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "uierror6.wav" + pigpikmnnlh.OPLBIOGKINC(BGNPMOCLIGL, false);
			}
			return text;
		}

		// Token: 0x060071F0 RID: 29168 RVA: 0x00368440 File Offset: 0x00366640
		public void PELNKFINBPI(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "Materials/VolumetricFog";
			while (!KADBECGIMPD.NLJJMKFBPBK())
			{
				long num = KADBECGIMPD.IJDIMHAEAIE();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
				edpnahlghpl.ODAFODFACKN(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 0)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "FOG_POINT_LIGHT";
			}
		}

		// Token: 0x060071F1 RID: 29169 RVA: 0x003684B4 File Offset: 0x003666B4
		public void ABDFDGIGFEA(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.ANPEIKGEDHJ();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 6)
				{
					edpnahlghpl.MODEOKGGDBD = true;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("Loot", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("WeaponStrafeRunRight", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x060071F2 RID: 29170 RVA: 0x00368548 File Offset: 0x00366748
		public string HNKAIEFHOEM(bool BGNPMOCLIGL = true)
		{
			string text = "===== ObscuredStringTest =====\n";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "SuicideHeadShot" + pigpikmnnlh.FGDAEJPLPKL(BGNPMOCLIGL, true);
			}
			return text;
		}

		// Token: 0x060071F3 RID: 29171 RVA: 0x003685B0 File Offset: 0x003667B0
		public void LLELDMHPBBB(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.DMABDIGCLKA();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 2)
				{
					edpnahlghpl.MODEOKGGDBD = true;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("BowFire", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("[ACTk] Speed Hack Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x060071F4 RID: 29172 RVA: 0x00368644 File Offset: 0x00366844
		public void NAMMMOGKFBD(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.HHMGLDMFCPF();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.EFGBDBAOFCJ(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 1)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("OneHandSwordBackSwing", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("_", edpnahlghpl);
			}
		}

		// Token: 0x060071F5 RID: 29173 RVA: 0x003686E8 File Offset: 0x003668E8
		public string OACECANALEG(bool BGNPMOCLIGL = true)
		{
			string text = "FakeWater";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "KatanaVerticalSwing" + pigpikmnnlh.CMPFHBMPJGG(BGNPMOCLIGL, false);
			}
			return text;
		}

		// Token: 0x060071F6 RID: 29174 RVA: 0x00368750 File Offset: 0x00366950
		public void IBDBCJICGKH(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.DNIIFBAIPBE();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 3)
				{
					edpnahlghpl.MODEOKGGDBD = false;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("Floating point textures aren't supported on this device ({0})", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("Wizard1HandThrow", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x060071F7 RID: 29175 RVA: 0x003687E4 File Offset: 0x003669E4
		public void PGJJEBLLJEH(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.HFOPFEJDJFG();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
			edpnahlghpl.FKOKKENAAAB(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 6)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("StShopWindow", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("IdleEat", edpnahlghpl);
			}
		}

		// Token: 0x060071F8 RID: 29176 RVA: 0x00368888 File Offset: 0x00366A88
		public void FJEGKNBFKFB(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.DNIIFBAIPBE();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.GMDNABBJDJF(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 8)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("_CameraClipInfo", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("<color='#FF8C42'>[{2}]</color> <color='#FF8C42'>{0}: {1}</color>", edpnahlghpl);
			}
		}

		// Token: 0x060071F9 RID: 29177 RVA: 0x0036892C File Offset: 0x00366B2C
		public void FEIDAEBGPEJ(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.ANPEIKGEDHJ();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 6)
				{
					edpnahlghpl.MODEOKGGDBD = false;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("Quest langfile not found!", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("_DelItem.wav", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x060071FA RID: 29178 RVA: 0x003689C0 File Offset: 0x00366BC0
		public void DOHBENLNKEF(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.DCGEOFHNBCN();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.MBLEIMCGLCE(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 5)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("_OcclusionTexture", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("Prone Locomotion", edpnahlghpl);
			}
		}

		// Token: 0x060071FB RID: 29179 RVA: 0x00368A64 File Offset: 0x00366C64
		public void BGPCLOCFLJC(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "The given 2D texture ";
			while (!KADBECGIMPD.JCEGOADAOOI)
			{
				long num = KADBECGIMPD.IBKCNEICPEL();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
				edpnahlghpl.KHOPKCFJPBF(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 0)
				{
					edpnahlghpl.EFFAHDKPOJA = true;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "wpn_cmp";
			}
		}

		// Token: 0x060071FC RID: 29180 RVA: 0x00368AD8 File Offset: 0x00366CD8
		public void NFBNOCCJBPM(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.IJDIMHAEAIE();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.BFNPPKIKKMC(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 3)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("{not_found}", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("KEyeHistogram", edpnahlghpl);
			}
		}

		// Token: 0x060071FD RID: 29181 RVA: 0x00368B7C File Offset: 0x00366D7C
		public void LELPDGJGLJF(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.DNIIFBAIPBE();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.OCPAHLAGCAI(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 2)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("UserIn", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("UserChange", edpnahlghpl);
			}
		}

		// Token: 0x060071FE RID: 29182 RVA: 0x00368C20 File Offset: 0x00366E20
		public void EFIJDJMAOOI(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.HHMGLDMFCPF();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
			edpnahlghpl.GMDNABBJDJF(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 8)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("CrouchWalk", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("knopje.wav", edpnahlghpl);
			}
		}

		// Token: 0x060071FF RID: 29183 RVA: 0x00368CC4 File Offset: 0x00366EC4
		public void LFBPKHDGEKG(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.IBKCNEICPEL();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 8)
				{
					edpnahlghpl.MODEOKGGDBD = true;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("iPoint", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("usr_inf_a3", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x06007200 RID: 29184 RVA: 0x00368D58 File Offset: 0x00366F58
		public void OFOPKLEICCH(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.HHMGLDMFCPF();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 5)
				{
					edpnahlghpl.MODEOKGGDBD = false;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("MotorbikeSeatStand", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("TOD_CloudScale", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x06007201 RID: 29185 RVA: 0x00368DEC File Offset: 0x00366FEC
		public void KOELDBPEEFF(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "Sexy Dance";
			while (!KADBECGIMPD.JEFMHDJEEJC())
			{
				long num = KADBECGIMPD.DMABDIGCLKA();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
				edpnahlghpl.FCGANCJIFAG(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 2)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "MotorbikeBackwardStand";
			}
		}

		// Token: 0x06007202 RID: 29186 RVA: 0x00368E60 File Offset: 0x00367060
		public void KIPBGDCGKAF(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "PaperTurn.wav";
			while (!KADBECGIMPD.JCEGOADAOOI)
			{
				long num = KADBECGIMPD.IBKCNEICPEL();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
				edpnahlghpl.JEPNENKOEOH(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 2)
				{
					edpnahlghpl.EFFAHDKPOJA = true;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "UnityEngine.Vector4";
			}
		}

		// Token: 0x06007203 RID: 29187 RVA: 0x00368ED4 File Offset: 0x003670D4
		public void ILDENOCIIPA(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.DCGEOFHNBCN();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 1)
				{
					edpnahlghpl.MODEOKGGDBD = false;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("crft_from", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("[Z]", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x06007204 RID: 29188 RVA: 0x00368F68 File Offset: 0x00367168
		public string LIPDEDEODLP(bool BGNPMOCLIGL = true)
		{
			string text = "Wand Attack 2";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "?" + pigpikmnnlh.MONLKCBHBHE(BGNPMOCLIGL, true);
			}
			return text;
		}

		// Token: 0x06007205 RID: 29189 RVA: 0x00368FD0 File Offset: 0x003671D0
		public void DDHBMLPBNFK(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "LDR";
			while (!KADBECGIMPD.NLJJMKFBPBK())
			{
				long num = KADBECGIMPD.HFOPFEJDJFG();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
				edpnahlghpl.DIAMCIJNACK(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 2)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "Screen Space Reflections";
			}
		}

		// Token: 0x06007206 RID: 29190 RVA: 0x00369044 File Offset: 0x00367244
		public void AKGCPKEJFBE(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.ANPEIKGEDHJ();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 0)
				{
					edpnahlghpl.MODEOKGGDBD = true;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("IdleSadHips", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("Button Right Hand", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x06007207 RID: 29191 RVA: 0x003690D8 File Offset: 0x003672D8
		public void KDDMJBOCNHO(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.ANPEIKGEDHJ();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.HEMIJKOAPBB(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 6)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("SneakIdle", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("_Lift", edpnahlghpl);
			}
		}

		// Token: 0x06007208 RID: 29192 RVA: 0x0036917C File Offset: 0x0036737C
		public string ECIPMDEDPAO(bool BGNPMOCLIGL = true)
		{
			string text = "";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "\n" + pigpikmnnlh.CKAKMOCHBLF(BGNPMOCLIGL, false);
			}
			return text;
		}

		// Token: 0x06007209 RID: 29193 RVA: 0x003691E4 File Offset: 0x003673E4
		public void PNAADPNEPKO(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "t_lashes";
			while (!KADBECGIMPD.ODIBHLOAGBC())
			{
				long num = KADBECGIMPD.ANPEIKGEDHJ();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
				edpnahlghpl.FCGANCJIFAG(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 8)
				{
					edpnahlghpl.EFFAHDKPOJA = true;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "_ToneCurve";
			}
		}

		// Token: 0x0600720A RID: 29194 RVA: 0x00369258 File Offset: 0x00367458
		public void PCPEFANMNLM(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.IBKCNEICPEL();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
			edpnahlghpl.NHHAANEMJCK(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 8)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("OK aukKeyMEditOk", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("Materials/DFGWithSky", edpnahlghpl);
			}
		}

		// Token: 0x0600720B RID: 29195 RVA: 0x003692FC File Offset: 0x003674FC
		public void MCFGIMDAHDI(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.DMABDIGCLKA();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
			edpnahlghpl.OGDEGELLJJN(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 6)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("CrawlLocomotion", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("WeaponReady", edpnahlghpl);
			}
		}

		// Token: 0x0600720C RID: 29196 RVA: 0x003693A0 File Offset: 0x003675A0
		public void DBPFPBPEEDB(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.DCGEOFHNBCN();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.LEGJBJFGNEJ(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 7)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("****************  playNextMusic ", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("Flap_02.wav", edpnahlghpl);
			}
		}

		// Token: 0x0600720D RID: 29197 RVA: 0x00369444 File Offset: 0x00367644
		public void OFAOCJHKIEG(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "_Params1";
			while (!KADBECGIMPD.DFLKBBNOGBG())
			{
				long num = KADBECGIMPD.DNIIFBAIPBE();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
				edpnahlghpl.LBBBADCPGOI(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 7)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "Hip";
			}
		}

		// Token: 0x0600720E RID: 29198 RVA: 0x003694B8 File Offset: 0x003676B8
		public void PIDHABAMCIJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "Cloth_05_00.wav";
			while (!KADBECGIMPD.BKIBKLFCCGP())
			{
				long num = KADBECGIMPD.EJPMFEJBGMN();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
				edpnahlghpl.DFANMIPGKIP(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 7)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "isBrag";
			}
		}

		// Token: 0x0600720F RID: 29199 RVA: 0x0036952C File Offset: 0x0036772C
		public void OAGIBGBPIFK(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.HFOPFEJDJFG();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 0)
				{
					edpnahlghpl.MODEOKGGDBD = true;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("Text:", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("\n", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x06007210 RID: 29200 RVA: 0x003695C0 File Offset: 0x003677C0
		public void JKGEGPMKANJ(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.KLHDFFHONON();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 4)
				{
					edpnahlghpl.MODEOKGGDBD = false;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("_Axis", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("Hidden/Amplify Color/Mask", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x06007211 RID: 29201 RVA: 0x00369654 File Offset: 0x00367854
		public void GKOEHKMCPGK(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "";
			while (!KADBECGIMPD.NLJJMKFBPBK())
			{
				long num = KADBECGIMPD.IBKCNEICPEL();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
				edpnahlghpl.OCPAHLAGCAI(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 7)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "remWpn=";
			}
		}

		// Token: 0x06007212 RID: 29202 RVA: 0x003696C8 File Offset: 0x003678C8
		public void BHLJBEIBOMD(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.HFOPFEJDJFG();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 6)
				{
					edpnahlghpl.MODEOKGGDBD = true;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("</color>", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("_InvRenderTargetSize", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x06007213 RID: 29203 RVA: 0x0036975C File Offset: 0x0036795C
		public void LAFOPPNFAFI(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.IBKCNEICPEL();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
			edpnahlghpl.AGADBLDMILO(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 2)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("TOD_CloudColor", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("WateringCanWatering", edpnahlghpl);
			}
		}

		// Token: 0x06007214 RID: 29204 RVA: 0x00369800 File Offset: 0x00367A00
		public string JKFEMGAFKLJ(bool BGNPMOCLIGL = true)
		{
			string text = "Sunshine Project Configuration";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "Vertical" + pigpikmnnlh.ALEEMFNNOPJ(BGNPMOCLIGL, false);
			}
			return text;
		}

		// Token: 0x06007215 RID: 29205 RVA: 0x00369868 File Offset: 0x00367A68
		public void HLEFNOIJDHG(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "Vertical";
			while (!KADBECGIMPD.KFKIFJDHCHB())
			{
				long num = KADBECGIMPD.IBKCNEICPEL();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
				edpnahlghpl.FKOKKENAAAB(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 4)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "Body";
			}
		}

		// Token: 0x06007216 RID: 29206 RVA: 0x003698DC File Offset: 0x00367ADC
		public string LOEHLFBANKN(bool BGNPMOCLIGL = true)
		{
			string text = "_Convolved_TexelSize";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "" + pigpikmnnlh.OPLBIOGKINC(BGNPMOCLIGL, false);
			}
			return text;
		}

		// Token: 0x06007217 RID: 29207 RVA: 0x00369944 File Offset: 0x00367B44
		public void ANEHNLHILLH(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.ANPEIKGEDHJ();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.KOBJOJMPFGC(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 5)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("RollerBladeCrossoverRight", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("; ", edpnahlghpl);
			}
		}

		// Token: 0x06007218 RID: 29208 RVA: 0x003699E8 File Offset: 0x00367BE8
		public string IABBIPKHMFN(bool BGNPMOCLIGL = true)
		{
			string text = "_ChannelMixerBlue";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "knopje.wav" + pigpikmnnlh.LDBHBKBPJAA(BGNPMOCLIGL, false);
			}
			return text;
		}

		// Token: 0x06007219 RID: 29209 RVA: 0x00369A50 File Offset: 0x00367C50
		public void CKLDKFCKCIC(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "BlurXY";
			while (!KADBECGIMPD.HKBFCJDJCOB())
			{
				long num = KADBECGIMPD.IBKCNEICPEL();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
				edpnahlghpl.NCKKHDFHBEF(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 5)
				{
					edpnahlghpl.EFFAHDKPOJA = true;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "wpn_bait1";
			}
		}

		// Token: 0x0600721A RID: 29210 RVA: 0x00369AC4 File Offset: 0x00367CC4
		public void BFDCJHPDJDJ(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.DNIIFBAIPBE();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 2)
				{
					edpnahlghpl.MODEOKGGDBD = false;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("UserChange", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("UserOut", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x0600721B RID: 29211 RVA: 0x00369B58 File Offset: 0x00367D58
		public void PDKBMGGPONC(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.DMABDIGCLKA();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.OLGEDIFBGNL(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 1)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("elbow", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("{0} {1} {2} {3} {4} {5}", edpnahlghpl);
			}
		}

		// Token: 0x0600721C RID: 29212 RVA: 0x00369BFC File Offset: 0x00367DFC
		public string KPKGHAPNALC(bool BGNPMOCLIGL = true)
		{
			string text = "Flashlight";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "food_draw.ogg" + pigpikmnnlh.MLKGFHKOCBB(BGNPMOCLIGL, false);
			}
			return text;
		}

		// Token: 0x0600721D RID: 29213 RVA: 0x00369C64 File Offset: 0x00367E64
		public void DJFKCPHLHDN(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.HHMGLDMFCPF();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.OLGEDIFBGNL(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 8)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("Sitting 45 Degress leg", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("Vertical", edpnahlghpl);
			}
		}

		// Token: 0x0600721E RID: 29214 RVA: 0x00369D08 File Offset: 0x00367F08
		public string GNGHMGFPBJK(bool BGNPMOCLIGL = true)
		{
			string text = "Hit Point WeightCurve length is zero.";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "wpn_bait_sz" + pigpikmnnlh.LFHOPKPNPNG(BGNPMOCLIGL, true);
			}
			return text;
		}

		// Token: 0x0600721F RID: 29215 RVA: 0x00369D70 File Offset: 0x00367F70
		public void ALDBEDIGBJD(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.DNIIFBAIPBE();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
			edpnahlghpl.DFANMIPGKIP(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 6)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("Save", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("", edpnahlghpl);
			}
		}

		// Token: 0x06007220 RID: 29216 RVA: 0x00369E14 File Offset: 0x00368014
		public void LNDIKAFIPBJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = ".png";
			while (!KADBECGIMPD.DFLKBBNOGBG())
			{
				long num = KADBECGIMPD.DCGEOFHNBCN();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
				edpnahlghpl.NCKKHDFHBEF(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 5)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "ObscuredShort:";
			}
		}

		// Token: 0x06007221 RID: 29217 RVA: 0x00369E88 File Offset: 0x00368088
		public string OLFCMADCGJF(bool BGNPMOCLIGL = true)
		{
			string text = "Reset";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "</color>\n" + pigpikmnnlh.LFHOPKPNPNG(BGNPMOCLIGL, false);
			}
			return text;
		}

		// Token: 0x06007222 RID: 29218 RVA: 0x00369EF0 File Offset: 0x003680F0
		public string IMNDJLNDCJE(bool BGNPMOCLIGL = true)
		{
			string text = "<color='#103000'>";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + " load woman version" + pigpikmnnlh.MIHBKFBAJHH(BGNPMOCLIGL, false);
			}
			return text;
		}

		// Token: 0x06007223 RID: 29219 RVA: 0x00369F58 File Offset: 0x00368158
		public string DDMBBDGFEBH(bool BGNPMOCLIGL = true)
		{
			string text = "_BlurParams";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "name" + pigpikmnnlh.LDBHBKBPJAA(BGNPMOCLIGL, true);
			}
			return text;
		}

		// Token: 0x06007224 RID: 29220 RVA: 0x00369FC0 File Offset: 0x003681C0
		public void KJCLHHJOIFM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "IceHockey Goalie Save 2";
			while (!KADBECGIMPD.INLBHLOLOJH())
			{
				long num = KADBECGIMPD.DCGEOFHNBCN();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
				edpnahlghpl.OGDEGELLJJN(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 4)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "RollerBladeJump";
			}
		}

		// Token: 0x06007225 RID: 29221 RVA: 0x0036A034 File Offset: 0x00368234
		public void FIBFJOIHPGG(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.KLHDFFHONON();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 6)
				{
					edpnahlghpl.MODEOKGGDBD = true;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("name", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("_BlurCoe", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x06007226 RID: 29222 RVA: 0x0036A0C8 File Offset: 0x003682C8
		public void HPCHMOOAHFP(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "{0:F2}, {1:F2}, {2:F2}";
			while (!KADBECGIMPD.NNOJEFMEGEG())
			{
				long num = KADBECGIMPD.KLHDFFHONON();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
				edpnahlghpl.DIAMCIJNACK(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 3)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "Idle180";
			}
		}

		// Token: 0x06007227 RID: 29223 RVA: 0x0036A13C File Offset: 0x0036833C
		public string GBPCLCJNPLH(bool BGNPMOCLIGL = true)
		{
			string text = "Clear Screen";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "dragWeapon = null 3" + pigpikmnnlh.LFHOPKPNPNG(BGNPMOCLIGL, false);
			}
			return text;
		}

		// Token: 0x06007228 RID: 29224 RVA: 0x0036A1A4 File Offset: 0x003683A4
		public void IIGIFGOGNFH(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.IBKCNEICPEL();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 6)
				{
					edpnahlghpl.MODEOKGGDBD = false;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("fish/", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("_NoiseTex", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x06007229 RID: 29225 RVA: 0x0036A238 File Offset: 0x00368438
		public string BGLNNPAFCJH(bool BGNPMOCLIGL = true)
		{
			string text = "";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "_AdaptParams" + pigpikmnnlh.NNONJGMPCDM(BGNPMOCLIGL, true);
			}
			return text;
		}

		// Token: 0x0600722A RID: 29226 RVA: 0x0036A2A0 File Offset: 0x003684A0
		public void GPOEOIGHLLJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "KatanaReady";
			while (!KADBECGIMPD.JEFMHDJEEJC())
			{
				long num = KADBECGIMPD.IJDIMHAEAIE();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
				edpnahlghpl.DFANMIPGKIP(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 1)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "_Curve";
			}
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x0036A314 File Offset: 0x00368514
		public string LBHDCHOJLOF(bool BGNPMOCLIGL = true)
		{
			string text = "Soccer Throw";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "poplSoundPitch" + pigpikmnnlh.MONLKCBHBHE(BGNPMOCLIGL, true);
			}
			return text;
		}

		// Token: 0x0600722C RID: 29228 RVA: 0x0036A37C File Offset: 0x0036857C
		public void NIOLJHIHAIF(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.HHMGLDMFCPF();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.GEFKBNKPAAD(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 6)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("_RgbBlendCacheTex", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("BackPackOff", edpnahlghpl);
			}
		}

		// Token: 0x0600722D RID: 29229 RVA: 0x0036A420 File Offset: 0x00368620
		public void CBGPAEMBCCC(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.DCGEOFHNBCN();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.GOBDNDIINPL(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 1)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("isiznos", edpnahlghpl);
			}
		}

		// Token: 0x0600722E RID: 29230 RVA: 0x0036A4C4 File Offset: 0x003686C4
		public void PODOMIOBPGC(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "";
			while (!KADBECGIMPD.PPAHBNGECGH())
			{
				long num = KADBECGIMPD.DNIIFBAIPBE();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
				edpnahlghpl.APJEMENHACF(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 1)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "KarateGreet";
			}
		}

		// Token: 0x0600722F RID: 29231 RVA: 0x0036A538 File Offset: 0x00368738
		public void CINKHGMCLEK(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.IBKCNEICPEL();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.AKMLEEPJPPL(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 1)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("Add random value", edpnahlghpl);
			}
		}

		// Token: 0x06007230 RID: 29232 RVA: 0x0036A5DC File Offset: 0x003687DC
		public string MBMMEHPPLKO(bool BGNPMOCLIGL = true)
		{
			string text = "wpn_bait1";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "PaperTurn.wav" + pigpikmnnlh.NNONJGMPCDM(BGNPMOCLIGL, true);
			}
			return text;
		}

		// Token: 0x06007231 RID: 29233 RVA: 0x0036A644 File Offset: 0x00368844
		public void LKJGJLGNKML(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "Player";
			while (!KADBECGIMPD.IBMMOGHFCCE())
			{
				long num = KADBECGIMPD.EJPMFEJBGMN();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
				edpnahlghpl.APJEMENHACF(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 7)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "_Tile2RT";
			}
		}

		// Token: 0x06007232 RID: 29234 RVA: 0x0036A6B8 File Offset: 0x003688B8
		public void OMDFBLFBHAE(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.IBKCNEICPEL();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 4)
				{
					edpnahlghpl.MODEOKGGDBD = true;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("fish/", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("no_get", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x06007233 RID: 29235 RVA: 0x0036A74C File Offset: 0x0036894C
		public void BAOEEGGPIPO(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.IJDIMHAEAIE();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
			edpnahlghpl.FMHEFGFMLJI(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 1)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("_ZTest", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("\\StreamingAssets\\Quest\\Lang\\", edpnahlghpl);
			}
		}

		// Token: 0x06007234 RID: 29236 RVA: 0x0036A7F0 File Offset: 0x003689F0
		public string PDMLGFAPEIF(bool BGNPMOCLIGL = true)
		{
			string text = "wtype";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "cond" + pigpikmnnlh.PJHAJNLEPDD(BGNPMOCLIGL, false);
			}
			return text;
		}

		// Token: 0x06007235 RID: 29237 RVA: 0x0036A858 File Offset: 0x00368A58
		public void FMDFNBMNJJO(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.EJPMFEJBGMN();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.KOBJOJMPFGC(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 5)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("RIGHT", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("IKMappingSpine is missing the right thigh bone.", edpnahlghpl);
			}
		}

		// Token: 0x06007236 RID: 29238 RVA: 0x0036A8FC File Offset: 0x00368AFC
		public void BMEDPIKAMEE(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.DNIIFBAIPBE();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.JHLCFAGDNKM(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 6)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("WorkerPickaxe2", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("rollSoundPitch", edpnahlghpl);
			}
		}

		// Token: 0x06007237 RID: 29239 RVA: 0x0036A9A0 File Offset: 0x00368BA0
		public void CGDFKNLFPAH(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.HHMGLDMFCPF();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
			edpnahlghpl.KHOPKCFJPBF(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 8)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("<color='#6080ff'>", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("ShotgunReadyFire", edpnahlghpl);
			}
		}

		// Token: 0x06007238 RID: 29240 RVA: 0x0036AA44 File Offset: 0x00368C44
		public void CGCNNDLNJLH(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "Delete shadow";
			while (!KADBECGIMPD.NLJJMKFBPBK())
			{
				long num = KADBECGIMPD.EJPMFEJBGMN();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
				edpnahlghpl.JHMPIOAAIBF(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 7)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "OneHandSwordJab";
			}
		}

		// Token: 0x06007239 RID: 29241 RVA: 0x0036AAB8 File Offset: 0x00368CB8
		public void PEKGEMBPCJJ(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.HHMGLDMFCPF();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 5)
				{
					edpnahlghpl.MODEOKGGDBD = true;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("_HrDepthTex", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("ThisRenderer.bones[i].name is null", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x0600723A RID: 29242 RVA: 0x0036AB4C File Offset: 0x00368D4C
		public void LBADCJMGHPD(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.IBKCNEICPEL();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 4)
				{
					edpnahlghpl.MODEOKGGDBD = false;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("change me!", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("isRealView", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x0600723B RID: 29243 RVA: 0x0036ABE0 File Offset: 0x00368DE0
		public void PHGIOOCLHJI(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.ANPEIKGEDHJ();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
			edpnahlghpl.APJEMENHACF(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 8)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("TOD_Brightness", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("shop_t19", edpnahlghpl);
			}
		}

		// Token: 0x0600723C RID: 29244 RVA: 0x0036AC84 File Offset: 0x00368E84
		public void OPOMGMDBIOG(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.DNIIFBAIPBE();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.AGADBLDMILO(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 8)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("TOD_AmbientColor", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("[ACTk] A decimal must be created from exactly 16 bytes", edpnahlghpl);
			}
		}

		// Token: 0x0600723D RID: 29245 RVA: 0x0036AD28 File Offset: 0x00368F28
		public void ILPOGMHBPAC(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.ANPEIKGEDHJ();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.PODGKHBLJED(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 8)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("1HandHeavySwing", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("", edpnahlghpl);
			}
		}

		// Token: 0x0600723E RID: 29246 RVA: 0x0036ADCC File Offset: 0x00368FCC
		public void JFJNINIFMLE(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.DCGEOFHNBCN();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.FMHEFGFMLJI(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 1)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("IdleStand", edpnahlghpl);
			}
		}

		// Token: 0x0600723F RID: 29247 RVA: 0x0036AE70 File Offset: 0x00369070
		public string HFPKFOGFGOP(bool BGNPMOCLIGL = true)
		{
			string text = " ";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "" + pigpikmnnlh.CKAKMOCHBLF(BGNPMOCLIGL, false);
			}
			return text;
		}

		// Token: 0x06007240 RID: 29248 RVA: 0x0036AED8 File Offset: 0x003690D8
		public void IDOLDAAHGGL(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.IBKCNEICPEL();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 3)
				{
					edpnahlghpl.MODEOKGGDBD = true;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("inner_craft_wpn", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("move", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x06007241 RID: 29249 RVA: 0x0036AF6C File Offset: 0x0036916C
		public void CNGCCLAIKKE(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.DNIIFBAIPBE();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.JEPNENKOEOH(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 2)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("1HandSwordJabFootPush", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("qd_prise_titul", edpnahlghpl);
			}
		}

		// Token: 0x06007242 RID: 29250 RVA: 0x0036B010 File Offset: 0x00369210
		public void NJCJOFNIINF(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.DCGEOFHNBCN();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.EOECIOMLINH(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 8)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("OfficeSittingEyesRub", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("_WrinkleInfluences2", edpnahlghpl);
			}
		}

		// Token: 0x06007243 RID: 29251 RVA: 0x0036B0B4 File Offset: 0x003692B4
		public void KBIHCAMGPMH(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "_Params";
			while (!KADBECGIMPD.KFKIFJDHCHB())
			{
				long num = KADBECGIMPD.DCGEOFHNBCN();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
				edpnahlghpl.COMPGPHIOPJ(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 0)
				{
					edpnahlghpl.EFFAHDKPOJA = true;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "<color=blue>$&</color>";
			}
		}

		// Token: 0x06007244 RID: 29252 RVA: 0x0036B128 File Offset: 0x00369328
		public string OJBFBCPCGMA(bool BGNPMOCLIGL = true)
		{
			string text = "bright";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "OneHandSwordReady" + pigpikmnnlh.FGDAEJPLPKL(BGNPMOCLIGL, true);
			}
			return text;
		}

		// Token: 0x06007245 RID: 29253 RVA: 0x0036B190 File Offset: 0x00369390
		public void HFEGLHBFFFL(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JIKGMLGOAPG.Clear();
			string arg = "gi_cachhe";
			while (!KADBECGIMPD.JCEGOADAOOI)
			{
				long num = KADBECGIMPD.IBKCNEICPEL();
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
				edpnahlghpl.LBBBADCPGOI(num, KADBECGIMPD);
				if (this.NDDLLPAIHGM == 2)
				{
					edpnahlghpl.EFFAHDKPOJA = false;
				}
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				arg = arg + edpnahlghpl + "wpn_popl1";
			}
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x0036B204 File Offset: 0x00369404
		public void FGILAPNDFFP(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.HHMGLDMFCPF();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 8)
				{
					edpnahlghpl.MODEOKGGDBD = true;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("WoodSaw", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("Android", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x06007247 RID: 29255 RVA: 0x0036B298 File Offset: 0x00369498
		public string GLPHACIKEKL(bool BGNPMOCLIGL = true)
		{
			string text = "_FgCocMask";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "</color>" + pigpikmnnlh.HEMFCGODHLK(BGNPMOCLIGL, true);
			}
			return text;
		}

		// Token: 0x06007248 RID: 29256 RVA: 0x0036B300 File Offset: 0x00369500
		public void GGBINLJNDJA(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.IJDIMHAEAIE();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.GMDNABBJDJF(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 7)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("u_pin", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("IdleSlide", edpnahlghpl);
			}
		}

		// Token: 0x06007249 RID: 29257 RVA: 0x0036B3A4 File Offset: 0x003695A4
		public void NCBNACJFOGG(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.KLHDFFHONON();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 1)
				{
					edpnahlghpl.MODEOKGGDBD = false;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("RunBackRight", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x0600724A RID: 29258 RVA: 0x0036B438 File Offset: 0x00369638
		public void HOMLEFJEGJF(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.IBKCNEICPEL();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
			edpnahlghpl.KOBJOJMPFGC(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 2)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("OfficeSittingMouseMovement", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("IceHockeyIdle", edpnahlghpl);
			}
		}

		// Token: 0x0600724B RID: 29259 RVA: 0x0036B4DC File Offset: 0x003696DC
		public string CMFNMLNLHDD(bool BGNPMOCLIGL = true)
		{
			string text = "WSRButton error";
			foreach (OAFJCFOGGAF.PIGPIKMNNLH pigpikmnnlh in this.PNLAPCGPDDL)
			{
				text = text + "qd_prise_titul" + pigpikmnnlh.HEMFCGODHLK(BGNPMOCLIGL, false);
			}
			return text;
		}

		// Token: 0x0600724C RID: 29260 RVA: 0x0036B544 File Offset: 0x00369744
		public void GIIFICEMKPL(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.EJPMFEJBGMN();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 7)
				{
					edpnahlghpl.MODEOKGGDBD = false;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("_EdgeThreshold", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("http://www.root-motion.com/finalikdox/html/page11.html", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x0600724D RID: 29261 RVA: 0x0036B5D8 File Offset: 0x003697D8
		public void KHIIKKKHONC(HBPNMNGOFMA KADBECGIMPD)
		{
			long key = KADBECGIMPD.ANPEIKGEDHJ();
			if (this.JIKGMLGOAPG.ContainsKey(key))
			{
				OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = this.JIKGMLGOAPG[key];
				if (this.NDDLLPAIHGM == 5)
				{
					edpnahlghpl.MODEOKGGDBD = false;
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF(",", edpnahlghpl);
						return;
					}
				}
				else
				{
					this.JIKGMLGOAPG.Remove(key);
					if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
					{
						OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("{0:F2}, {1:F2}, {2:F2}, {3:F2}", edpnahlghpl);
					}
				}
			}
		}

		// Token: 0x0600724E RID: 29262 RVA: 0x0036B66C File Offset: 0x0036986C
		public void KNEMJLOBLNG(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.HFOPFEJDJFG();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(num);
			edpnahlghpl.OGDEGELLJJN(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 8)
			{
				edpnahlghpl.EFFAHDKPOJA = true;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("ignorelist", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("Player", edpnahlghpl);
			}
		}

		// Token: 0x0600724F RID: 29263 RVA: 0x0036B710 File Offset: 0x00369910
		public void GNNCKMCLJGE(HBPNMNGOFMA KADBECGIMPD)
		{
			long num = KADBECGIMPD.HHMGLDMFCPF();
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(num);
			edpnahlghpl.MGBIHPHPMBL(num, KADBECGIMPD);
			if (this.NDDLLPAIHGM == 8)
			{
				edpnahlghpl.EFFAHDKPOJA = false;
			}
			if (!this.JIKGMLGOAPG.ContainsKey(edpnahlghpl.LPFKFNLHGBI))
			{
				this.JIKGMLGOAPG.Add(edpnahlghpl.LPFKFNLHGBI, edpnahlghpl);
				if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
				{
					OAFJCFOGGAF.IKGFHGKKCPG.OEDMHKCBKJF("<color='#ff8040'>", edpnahlghpl);
					return;
				}
			}
			else if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == this.NDDLLPAIHGM)
			{
				OAFJCFOGGAF.IKGFHGKKCPG.GDMEEEMEBPD("post_19", edpnahlghpl);
			}
		}

		// Token: 0x040010B4 RID: 4276
		public int NDDLLPAIHGM;

		// Token: 0x040010B5 RID: 4277
		public string OFALPEIEOJE;

		// Token: 0x040010B6 RID: 4278
		public List<OAFJCFOGGAF.PIGPIKMNNLH> PNLAPCGPDDL;

		// Token: 0x040010B7 RID: 4279
		public Dictionary<long, OAFJCFOGGAF.EDPNAHLGHPL> JIKGMLGOAPG = new Dictionary<long, OAFJCFOGGAF.EDPNAHLGHPL>();
	}
}
