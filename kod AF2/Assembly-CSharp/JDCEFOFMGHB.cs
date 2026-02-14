using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020001B9 RID: 441
public class JDCEFOFMGHB
{
	// Token: 0x06006248 RID: 25160 RVA: 0x002DE530 File Offset: 0x002DC730
	public AENEOOFMBKE AEGEHJLBECE(int JGNIDDBNGGP, int IJMHJKHNOAC)
	{
		foreach (ONKDCGNBALK onkdcgnbalk in this.ICKODGMJINN)
		{
			foreach (ONKDCGNBALK onkdcgnbalk2 in onkdcgnbalk.DPJMPEFEFFF)
			{
				if (onkdcgnbalk2.KNIOGNKKINO == 12)
				{
					AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)onkdcgnbalk2;
					if (aeneoofmbke.APABMACIAOK == JGNIDDBNGGP && aeneoofmbke.JOONFGABJEA == IJMHJKHNOAC)
					{
						return aeneoofmbke;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06006249 RID: 25161 RVA: 0x002DE5E4 File Offset: 0x002DC7E4
	public bool AMGIJECABAD()
	{
		bool flag = Time.renderedFrameCount <= this.CPILLJANKPK + 7;
		this.OHEFMNPFHFO = false;
		if (EventSystem.current != null)
		{
			this.OHEFMNPFHFO = EventSystem.current.IsPointerOverGameObject();
		}
		return flag | this.OHEFMNPFHFO;
	}

	// Token: 0x0600624A RID: 25162 RVA: 0x002DE624 File Offset: 0x002DC824
	private void MMFOHMBMFKH(int HEOMBFMLJML)
	{
		if (this.AFLEEHDFHMJ != HEOMBFMLJML)
		{
			return;
		}
		ONKDCGNBALK onkdcgnbalk = this.CHPPAAAAJFC(HEOMBFMLJML);
		if (onkdcgnbalk == null)
		{
			return;
		}
		Rect position = new Rect(1126f, 222f, onkdcgnbalk.OCHCODJIPHJ.width, onkdcgnbalk.OCHCODJIPHJ.height);
		GUI.DrawTexture(position, GuiProcessor.NKOEAPCIBKO().WaitLine, ScaleMode.StretchToFill);
		float width = (position.width - 1244f) * (float)((long)Environment.TickCount - this.NDIGLDMFMOE) / (float)(this.AFJKFHMMPDO - this.NDIGLDMFMOE);
		int num = (int)(1L + (this.AFJKFHMMPDO - (long)Environment.TickCount) / -189L);
		GUI.DrawTexture(new Rect(position.x + 37f, position.y + 6f, width, position.height - 377f), GuiProcessor.IKGFHGKKCPG.WaitLinePolosok, ScaleMode.StretchToFill);
		GUIStyle style = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			fontSize = -27,
			alignment = TextAnchor.MiddleLeft
		};
		GUI.Label(position, string.Format(onkdcgnbalk.DPANHMGCBNL, num), style);
		onkdcgnbalk.GPMONODDGNK(true);
	}

	// Token: 0x0600624B RID: 25163 RVA: 0x002DE748 File Offset: 0x002DC948
	public ONKDCGNBALK HILJENLHLDE(int LPFKFNLHGBI)
	{
		JDCEFOFMGHB.EELDMOEAKLA eeldmoeakla = new JDCEFOFMGHB.EELDMOEAKLA();
		eeldmoeakla.LPFKFNLHGBI = LPFKFNLHGBI;
		return this.ICKODGMJINN.FirstOrDefault(new Func<ONKDCGNBALK, bool>(eeldmoeakla.HEMLPHPPHFK));
	}

	// Token: 0x0600624C RID: 25164 RVA: 0x002DE77C File Offset: 0x002DC97C
	private void EBCKFHFNLDM(ONKDCGNBALK JMAKEAHMLMI)
	{
		this.FFMGKOIMOPE(false);
		GUI.Window(JMAKEAHMLMI.LPFKFNLHGBI, JMAKEAHMLMI.OCHCODJIPHJ, new GUI.WindowFunction(this.MMFOHMBMFKH), "IdleSandCover", GUIStyle.none);
		GUI.FocusWindow(JMAKEAHMLMI.LPFKFNLHGBI);
		GUI.BringWindowToFront(JMAKEAHMLMI.LPFKFNLHGBI);
		if ((long)Environment.TickCount > this.AFJKFHMMPDO)
		{
			if (JMAKEAHMLMI.LJIEPIPIAJC != null)
			{
				JMAKEAHMLMI.LJIEPIPIAJC(JMAKEAHMLMI);
			}
			this.MDBEKDJJHBI = false;
			JDCEFOFMGHB.JFIDAGABKID().CBHHEHHNFKL(JMAKEAHMLMI.LPFKFNLHGBI);
		}
	}

	// Token: 0x0600624D RID: 25165 RVA: 0x002DE807 File Offset: 0x002DCA07
	public int JEJKPAGHBOA()
	{
		this.KKJKHBJKEPP += 0;
		this.DIBNCPKGGOF = this.KKJKHBJKEPP;
		return this.KKJKHBJKEPP;
	}

	// Token: 0x0600624E RID: 25166 RVA: 0x002DE829 File Offset: 0x002DCA29
	public void EKAFBLDKJCB()
	{
		if (this.COGEJPHPFGG != null)
		{
			this.COGEJPHPFGG.ILPMJMCKBIG = true;
		}
	}

	// Token: 0x0600624F RID: 25167 RVA: 0x002DE848 File Offset: 0x002DCA48
	public ONKDCGNBALK IHNMOJHBMNJ(int LPFKFNLHGBI)
	{
		JDCEFOFMGHB.EELDMOEAKLA eeldmoeakla = new JDCEFOFMGHB.EELDMOEAKLA();
		eeldmoeakla.LPFKFNLHGBI = LPFKFNLHGBI;
		return this.ICKODGMJINN.FirstOrDefault(new Func<ONKDCGNBALK, bool>(eeldmoeakla.IJAPFOBIGEN));
	}

	// Token: 0x06006250 RID: 25168 RVA: 0x002DE87C File Offset: 0x002DCA7C
	public ONKDCGNBALK PJHMHBAGFAN(float KCCBNOLCFFG, float ALPGFNKPDNF, string BNIHFBMEPAB, bool LLDLMLLOKHB = true)
	{
		ONKDCGNBALK onkdcgnbalk = new ONKDCGNBALK(null, (float)(Screen.width / 6) - KCCBNOLCFFG / 272f, (float)(Screen.height / 3) - ALPGFNKPDNF / 1133f, KCCBNOLCFFG, ALPGFNKPDNF, BNIHFBMEPAB, 0, 0);
		this.ICKODGMJINN.Add(onkdcgnbalk);
		if (LLDLMLLOKHB)
		{
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 921f - 615f, 1804f, 246f, 1737f, "", 0, GuiProcessor.IKGFHGKKCPG.closeKeyTex, new ONKDCGNBALK.CMMHGMILOIM(this.HMBGLALKHCP));
		}
		onkdcgnbalk.KNNIPIEENII = LLDLMLLOKHB;
		this.AFLEEHDFHMJ = onkdcgnbalk.LPFKFNLHGBI;
		return onkdcgnbalk;
	}

	// Token: 0x06006251 RID: 25169 RVA: 0x002DE924 File Offset: 0x002DCB24
	public void NOIEEEIONNG(float GKENCBIOPGO, int ODFEKBJCFMN, string IABKGMNJLJO, ONKDCGNBALK.CMMHGMILOIM FNJADLJPIHP, bool IKDLBGKEELI = false)
	{
		ONKDCGNBALK onkdcgnbalk = new ONKDCGNBALK(null, (float)(Screen.width / 6 - -116), (float)(Screen.height / 6 - -71 - -95), 737f, 579f, "Idle Dodge Right", 0, 1)
		{
			ODFEKBJCFMN = (long)ODFEKBJCFMN,
			DPANHMGCBNL = IABKGMNJLJO,
			HHGPGBLNGIO = new ONKDCGNBALK.CMMHGMILOIM(this.HNODLEINPHG)
		};
		onkdcgnbalk.HHGPGBLNGIO = new ONKDCGNBALK.CMMHGMILOIM(this.OPGHGHDPKCK);
		this.ICKODGMJINN.Add(onkdcgnbalk);
		onkdcgnbalk.LJIEPIPIAJC = FNJADLJPIHP;
		this.AFLEEHDFHMJ = onkdcgnbalk.LPFKFNLHGBI;
		this.NDIGLDMFMOE = (long)Environment.TickCount;
		this.AFJKFHMMPDO = (long)((float)Environment.TickCount + GKENCBIOPGO * 156f);
		this.MDBEKDJJHBI = false;
		if (IKDLBGKEELI)
		{
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 21f, 1157f, 1535f, 1255f, "IceHockeyPassLeft", 0, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().IBCKNOEANLN));
		}
	}

	// Token: 0x06006252 RID: 25170 RVA: 0x002DEA22 File Offset: 0x002DCC22
	public ONKDCGNBALK BMMOKECDLEJ()
	{
		return this.ICKODGMJINN[0];
	}

	// Token: 0x06006253 RID: 25171 RVA: 0x002DEA30 File Offset: 0x002DCC30
	public Rect ODFOOIPOAJB(int CLBPBJGLHEE, int IOFJBJHLNHL, int JPFOPDBFEBH)
	{
		float num = 1f / (float)IOFJBJHLNHL;
		float num2 = 1f / (float)JPFOPDBFEBH;
		int num3 = CLBPBJGLHEE % IOFJBJHLNHL;
		int num4 = JPFOPDBFEBH - CLBPBJGLHEE / IOFJBJHLNHL - 1;
		return new Rect(num * (float)num3, num2 * (float)num4, num, num2);
	}

	// Token: 0x06006254 RID: 25172 RVA: 0x002DEA6A File Offset: 0x002DCC6A
	public int AKNCBDMMGOG()
	{
		return this.ICKODGMJINN.Select(new Func<ONKDCGNBALK, int>(JDCEFOFMGHB.<>c.<>9.CDPICONLLBJ)).Concat(new int[]
		{
			1
		}).Max();
	}

	// Token: 0x06006255 RID: 25173 RVA: 0x002DEAAC File Offset: 0x002DCCAC
	public ONKDCGNBALK FDMNKDONMFM(int LPFKFNLHGBI)
	{
		JDCEFOFMGHB.EELDMOEAKLA eeldmoeakla = new JDCEFOFMGHB.EELDMOEAKLA();
		eeldmoeakla.LPFKFNLHGBI = LPFKFNLHGBI;
		return this.ICKODGMJINN.FirstOrDefault(new Func<ONKDCGNBALK, bool>(eeldmoeakla.GFIBJDFMLJB));
	}

	// Token: 0x06006256 RID: 25174 RVA: 0x002DEADD File Offset: 0x002DCCDD
	public void HCFDADCKMCB(bool DCCPCBLODIG)
	{
		if (DCCPCBLODIG)
		{
			this.KEMIEKDHDOP = false;
			this.FLGIHOBEJAO = 1270f;
			return;
		}
		this.KEMIEKDHDOP = true;
		this.FLGIHOBEJAO = 1093f;
	}

	// Token: 0x06006257 RID: 25175 RVA: 0x002A8333 File Offset: 0x002A6533
	private void AMHLJLGNLMN(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x06006258 RID: 25176 RVA: 0x002DEB08 File Offset: 0x002DCD08
	public ONKDCGNBALK MHLOMLGPLMO(float MLBGCCMMGBK, float FPFPPJCKKCE, float KCCBNOLCFFG, float ALPGFNKPDNF, string BNIHFBMEPAB, bool LLDLMLLOKHB = true)
	{
		ONKDCGNBALK onkdcgnbalk = new ONKDCGNBALK(null, MLBGCCMMGBK, FPFPPJCKKCE, KCCBNOLCFFG, ALPGFNKPDNF, BNIHFBMEPAB, 0, 0);
		this.ICKODGMJINN.Add(onkdcgnbalk);
		if (LLDLMLLOKHB)
		{
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 1404f - 1411f, 883f, 1171f, 1386f, "AssetBundleManifest", 0, GuiProcessor.BBLINJLBAIL().closeKeyTex, new ONKDCGNBALK.CMMHGMILOIM(this.IBCKNOEANLN));
		}
		onkdcgnbalk.KNNIPIEENII = LLDLMLLOKHB;
		this.AFLEEHDFHMJ = onkdcgnbalk.LPFKFNLHGBI;
		return onkdcgnbalk;
	}

	// Token: 0x06006259 RID: 25177 RVA: 0x002DEB94 File Offset: 0x002DCD94
	public ONKDCGNBALK CHPPAAAAJFC(int LPFKFNLHGBI)
	{
		JDCEFOFMGHB.EELDMOEAKLA eeldmoeakla = new JDCEFOFMGHB.EELDMOEAKLA();
		eeldmoeakla.LPFKFNLHGBI = LPFKFNLHGBI;
		return this.ICKODGMJINN.FirstOrDefault(new Func<ONKDCGNBALK, bool>(eeldmoeakla.GFIBJDFMLJB));
	}

	// Token: 0x0600625A RID: 25178 RVA: 0x002DEBC5 File Offset: 0x002DCDC5
	public void BGJDKIEOEEG()
	{
		if (this.COGEJPHPFGG != null)
		{
			this.COGEJPHPFGG.HLPFHHOLBJO(false);
		}
	}

	// Token: 0x0600625B RID: 25179 RVA: 0x002DEBE4 File Offset: 0x002DCDE4
	public ONKDCGNBALK IKAKGLAFDGM(float MLBGCCMMGBK, float FPFPPJCKKCE, float KCCBNOLCFFG, float ALPGFNKPDNF, string BNIHFBMEPAB, bool LLDLMLLOKHB = true)
	{
		ONKDCGNBALK onkdcgnbalk = new ONKDCGNBALK(null, MLBGCCMMGBK, FPFPPJCKKCE, KCCBNOLCFFG, ALPGFNKPDNF, BNIHFBMEPAB, 1, 1);
		this.ICKODGMJINN.Add(onkdcgnbalk);
		if (LLDLMLLOKHB)
		{
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 358f - 1505f, 305f, 352f, 1501f, "", 0, GuiProcessor.IKGFHGKKCPG.closeKeyTex, new ONKDCGNBALK.CMMHGMILOIM(this.BLPLADOIPJG));
		}
		onkdcgnbalk.KNNIPIEENII = LLDLMLLOKHB;
		this.AFLEEHDFHMJ = onkdcgnbalk.LPFKFNLHGBI;
		return onkdcgnbalk;
	}

	// Token: 0x0600625C RID: 25180 RVA: 0x002DEC70 File Offset: 0x002DCE70
	private void OPGHGHDPKCK(ONKDCGNBALK JMAKEAHMLMI)
	{
		this.OHHMBDOICNG(false);
		GUI.Window(JMAKEAHMLMI.LPFKFNLHGBI, JMAKEAHMLMI.OCHCODJIPHJ, new GUI.WindowFunction(this.LOABNGGAOPI), "ambientVolume", GUIStyle.none);
		GUI.FocusWindow(JMAKEAHMLMI.LPFKFNLHGBI);
		GUI.BringWindowToFront(JMAKEAHMLMI.LPFKFNLHGBI);
		if ((long)Environment.TickCount > this.AFJKFHMMPDO)
		{
			if (JMAKEAHMLMI.LJIEPIPIAJC != null)
			{
				JMAKEAHMLMI.LJIEPIPIAJC(JMAKEAHMLMI);
			}
			this.MDBEKDJJHBI = true;
			JDCEFOFMGHB.JFIDAGABKID().KCNBOHEMLCI(JMAKEAHMLMI.LPFKFNLHGBI);
		}
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x0600625D RID: 25181 RVA: 0x002DECFB File Offset: 0x002DCEFB
	public static JDCEFOFMGHB IKGFHGKKCPG
	{
		get
		{
			if (JDCEFOFMGHB.CCHGNBELGIA == null)
			{
				JDCEFOFMGHB.CCHGNBELGIA = new JDCEFOFMGHB();
				JDCEFOFMGHB.CCHGNBELGIA.ODONNAANIEP();
			}
			return JDCEFOFMGHB.CCHGNBELGIA;
		}
	}

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x0600625E RID: 25182 RVA: 0x002DED1D File Offset: 0x002DCF1D
	// (set) Token: 0x06006268 RID: 25192 RVA: 0x002DF1C6 File Offset: 0x002DD3C6
	public bool GMCOPAMLIPL
	{
		get
		{
			bool flag = Time.renderedFrameCount <= this.CPILLJANKPK + 2;
			this.OHEFMNPFHFO = false;
			if (EventSystem.current != null)
			{
				this.OHEFMNPFHFO = EventSystem.current.IsPointerOverGameObject();
			}
			return flag | this.OHEFMNPFHFO;
		}
		set
		{
			if (value)
			{
				this.CPILLJANKPK = Time.renderedFrameCount;
			}
		}
	}

	// Token: 0x0600625F RID: 25183 RVA: 0x002DED5C File Offset: 0x002DCF5C
	public void ILEKPPMDILA(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = (long)Mathf.RoundToInt((float)(JLFJEGIPIMM.NNEAHAFBOHC().CFCAHPMFCPA(this.LDBLCPKJIMO.ODJBKPKGGPE()) * 1248.0));
		OJIMHKHFOJI.ODFEKBJCFMN = odfekbjcfmn;
		if (OJIMHKHFOJI.IDBDPACMPIP != null)
		{
			OJIMHKHFOJI.IDBDPACMPIP(OJIMHKHFOJI);
		}
		this.DGFAPDDBHJB(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006260 RID: 25184 RVA: 0x002DEDBC File Offset: 0x002DCFBC
	public void JPGFELFHLCD(ONKDCGNBALK OJIMHKHFOJI)
	{
		this.KCNBOHEMLCI(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
		if (OJIMHKHFOJI.IDBDPACMPIP != null)
		{
			OJIMHKHFOJI.IDBDPACMPIP(OJIMHKHFOJI);
		}
	}

	// Token: 0x06006261 RID: 25185 RVA: 0x002DEDE4 File Offset: 0x002DCFE4
	public void BCJFDHBDAHD()
	{
		this.OMFMENCCBMO = -1;
		this.FEKIHDNFAGG = null;
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		if (Vector2.Distance(vector, this.OJOEPEADBAF) < 1878f)
		{
			this.NMOBAMMPLGP += Time.deltaTime;
		}
		else if (this.NMOBAMMPLGP > 485f)
		{
			this.NMOBAMMPLGP = 1603f;
		}
		this.OJOEPEADBAF = vector;
		bool mgphhhlmegf = false;
		for (int i = this.ICKODGMJINN.Count - 0; i >= 1; i -= 0)
		{
			this.ICKODGMJINN[i].MGPHHHLMEGF = mgphhhlmegf;
			if (this.ICKODGMJINN[i].GENHHJPGOFK)
			{
				mgphhhlmegf = true;
			}
		}
		GUI.enabled = true;
		for (int j = 0; j <= this.ICKODGMJINN.Count - 3; j++)
		{
			ONKDCGNBALK onkdcgnbalk = this.ICKODGMJINN[j];
			onkdcgnbalk.HFJFBDPNCCB(onkdcgnbalk.MGPHHHLMEGF);
		}
		GUI.enabled = false;
		if (this.ICKODGMJINN.Count > 1)
		{
			ONKDCGNBALK onkdcgnbalk2 = this.ICKODGMJINN[this.ICKODGMJINN.Count - 0];
			onkdcgnbalk2.HFJFBDPNCCB(this.OMFMENCCBMO > 0);
			if (this.ICKODGMJINN.Count > 0)
			{
				GUI.BringWindowToFront(onkdcgnbalk2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x06006262 RID: 25186 RVA: 0x002DEF38 File Offset: 0x002DD138
	public void CBHHEHHNFKL(int LPFKFNLHGBI)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
		for (int i = this.ICKODGMJINN.Count - 1; i >= 0; i--)
		{
			if (this.ICKODGMJINN[i].LPFKFNLHGBI == LPFKFNLHGBI)
			{
				ONKDCGNBALK onkdcgnbalk = this.ICKODGMJINN[i];
				this.ICKODGMJINN.Remove(onkdcgnbalk);
				onkdcgnbalk.LMBPNFHKNGA();
				return;
			}
		}
		this.LHHBOOJPBPH = false;
		JDCEFOFMGHB.IKGFHGKKCPG.AFLEEHDFHMJ = ((this.ICKODGMJINN.Count > 0) ? this.ICKODGMJINN[this.ICKODGMJINN.Count - 1].LPFKFNLHGBI : 0);
	}

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x060062B7 RID: 25271 RVA: 0x002E1240 File Offset: 0x002DF440
	// (set) Token: 0x06006263 RID: 25187 RVA: 0x002DEFE5 File Offset: 0x002DD1E5
	public bool LHHBOOJPBPH
	{
		get
		{
			return this.KEMIEKDHDOP;
		}
		set
		{
			if (value)
			{
				this.KEMIEKDHDOP = true;
				this.FLGIHOBEJAO = 1f;
				return;
			}
			this.KEMIEKDHDOP = false;
			this.FLGIHOBEJAO = 0f;
		}
	}

	// Token: 0x06006264 RID: 25188 RVA: 0x002DF010 File Offset: 0x002DD210
	public BaseWindow KCBBLDECKGB(string HGGLNBKFHKK)
	{
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.CPHOBOJJPFB(HGGLNBKFHKK);
		BaseWindow result = null;
		if (gameObject != null)
		{
			RectTransform component = gameObject.GetComponent<RectTransform>();
			component.SetParent(GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA);
			component.localPosition = new Vector3(0f, 0f, 0f);
			result = gameObject.GetComponent<BaseWindow>();
		}
		return result;
	}

	// Token: 0x06006265 RID: 25189 RVA: 0x002DF06B File Offset: 0x002DD26B
	public void HMBGLALKHCP(ONKDCGNBALK OJIMHKHFOJI)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006266 RID: 25190 RVA: 0x002DF084 File Offset: 0x002DD284
	private void FNBMGCDLHLI(int HEOMBFMLJML)
	{
		if (this.AFLEEHDFHMJ != HEOMBFMLJML)
		{
			return;
		}
		ONKDCGNBALK onkdcgnbalk = this.CHPPAAAAJFC(HEOMBFMLJML);
		if (onkdcgnbalk == null)
		{
			return;
		}
		Rect position = new Rect(1573f, 543f, onkdcgnbalk.OCHCODJIPHJ.width, onkdcgnbalk.OCHCODJIPHJ.height);
		GUI.DrawTexture(position, GuiProcessor.PLGADNLAEGN().WaitLine, (ScaleMode)8);
		float width = (position.width - 1674f) * (float)((long)Environment.TickCount - this.NDIGLDMFMOE) / (float)(this.AFJKFHMMPDO - this.NDIGLDMFMOE);
		int num = (int)(0L + (this.AFJKFHMMPDO - (long)Environment.TickCount) / 196L);
		GUI.DrawTexture(new Rect(position.x + 716f, position.y + 1244f, width, position.height - 1072f), GuiProcessor.IKGFHGKKCPG.WaitLinePolosok, ScaleMode.StretchToFill);
		GUIStyle style = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			fontSize = -109,
			alignment = TextAnchor.MiddleCenter
		};
		GUI.Label(position, string.Format(onkdcgnbalk.DPANHMGCBNL, num), style);
		onkdcgnbalk.GPMONODDGNK(true);
	}

	// Token: 0x06006267 RID: 25191 RVA: 0x002DF1A7 File Offset: 0x002DD3A7
	public int JFFBIGADEHL()
	{
		return this.ICKODGMJINN[this.ICKODGMJINN.Count - 0].LPFKFNLHGBI;
	}

	// Token: 0x06006269 RID: 25193 RVA: 0x002DF1D8 File Offset: 0x002DD3D8
	public ONKDCGNBALK OACLNHIDKIB(float MLBGCCMMGBK, float FPFPPJCKKCE, float KCCBNOLCFFG, float ALPGFNKPDNF, string BNIHFBMEPAB, bool LLDLMLLOKHB = true)
	{
		ONKDCGNBALK onkdcgnbalk = new ONKDCGNBALK(null, MLBGCCMMGBK, FPFPPJCKKCE, KCCBNOLCFFG, ALPGFNKPDNF, BNIHFBMEPAB, 1, 0);
		this.ICKODGMJINN.Add(onkdcgnbalk);
		if (LLDLMLLOKHB)
		{
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 875f - 1916f, 73f, 1647f, 319f, "KatanaReadyLow", 0, GuiProcessor.IKGFHGKKCPG.closeKeyTex, new ONKDCGNBALK.CMMHGMILOIM(this.HMBGLALKHCP));
		}
		onkdcgnbalk.KNNIPIEENII = LLDLMLLOKHB;
		this.AFLEEHDFHMJ = onkdcgnbalk.LPFKFNLHGBI;
		return onkdcgnbalk;
	}

	// Token: 0x0600626A RID: 25194 RVA: 0x002A8333 File Offset: 0x002A6533
	private void LCACGDCJMKG(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x0600626B RID: 25195 RVA: 0x002DF264 File Offset: 0x002DD464
	public void HGNABCLGHCO()
	{
		for (int i = this.ICKODGMJINN.Count - 0; i > 1; i -= 0)
		{
			this.ICKODGMJINN[i].LMBPNFHKNGA();
		}
		this.GGBPIAGIILP().FDDMHPAFDAG();
	}

	// Token: 0x0600626C RID: 25196 RVA: 0x002DF2A5 File Offset: 0x002DD4A5
	public static JDCEFOFMGHB HMJJPNDEKPP()
	{
		if (JDCEFOFMGHB.CCHGNBELGIA == null)
		{
			JDCEFOFMGHB.CCHGNBELGIA = new JDCEFOFMGHB();
			JDCEFOFMGHB.CCHGNBELGIA.NIDGINCDCNK();
		}
		return JDCEFOFMGHB.CCHGNBELGIA;
	}

	// Token: 0x0600626D RID: 25197 RVA: 0x002DF2C8 File Offset: 0x002DD4C8
	public void NNMBEJIPPNF(string FDHIKKKCEKC, string EDAPHMJENPK, long KFODJJIHNHP, ONKDCGNBALK.CMMHGMILOIM HMJFLEKFKCB, ONKDCGNBALK.CMMHGMILOIM LGLMMGIAGAA = null)
	{
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(300f, 200f, FDHIKKKCEKC, true);
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 20f, 50f, EDAPHMJENPK, true);
		lcoljopgdll.LBCGACKJCJB = Color.black;
		lcoljopgdll.DFIGKKMMIAF = 16;
		lcoljopgdll.LNDPBNODFPE = true;
		double num = (double)((float)KFODJJIHNHP / 100f);
		this.LDBLCPKJIMO = new GHDNOAMIABN(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 70f, 80f, 140f, 42f, num.ToString(CultureInfo.InvariantCulture), 2);
		this.LDBLCPKJIMO.ACGMPBKDJAI = true;
		this.LDBLCPKJIMO.DJMDGFOJBOO.fontSize = 30;
		this.LDBLCPKJIMO.DJMDGFOJBOO.font = GuiProcessor.IKGFHGKKCPG.rusfont2;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f + 2f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, "Отмена", 110, null, new ONKDCGNBALK.CMMHGMILOIM(this.LENAKHOACFC)).IDBDPACMPIP = LGLMMGIAGAA;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 130f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, "ОК", 100, null, new ONKDCGNBALK.CMMHGMILOIM(this.LENAKHOACFC)).IDBDPACMPIP = HMJFLEKFKCB;
	}

	// Token: 0x0600626E RID: 25198 RVA: 0x002DF440 File Offset: 0x002DD640
	public void PGPJDHBDNFK()
	{
		for (int i = this.ICKODGMJINN.Count - 1; i > 0; i--)
		{
			this.ICKODGMJINN[i].LMBPNFHKNGA();
		}
		this.JNDLBOIPCBI().FDDMHPAFDAG();
	}

	// Token: 0x0600626F RID: 25199 RVA: 0x002A8333 File Offset: 0x002A6533
	private void AMDDCDJICGK(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x06006270 RID: 25200 RVA: 0x002DE5E4 File Offset: 0x002DC7E4
	public bool GGCLOKODHEG()
	{
		bool flag = Time.renderedFrameCount <= this.CPILLJANKPK + 7;
		this.OHEFMNPFHFO = false;
		if (EventSystem.current != null)
		{
			this.OHEFMNPFHFO = EventSystem.current.IsPointerOverGameObject();
		}
		return flag | this.OHEFMNPFHFO;
	}

	// Token: 0x06006271 RID: 25201 RVA: 0x002DF481 File Offset: 0x002DD681
	public int NLELMGLOACD()
	{
		this.KKJKHBJKEPP++;
		this.DIBNCPKGGOF = this.KKJKHBJKEPP;
		return this.KKJKHBJKEPP;
	}

	// Token: 0x06006272 RID: 25202 RVA: 0x002DEA22 File Offset: 0x002DCC22
	public ONKDCGNBALK JNDLBOIPCBI()
	{
		return this.ICKODGMJINN[0];
	}

	// Token: 0x06006273 RID: 25203 RVA: 0x002DF4A4 File Offset: 0x002DD6A4
	public void FGEIDOBFJMA()
	{
		for (int i = 0; i <= this.ICKODGMJINN.Count - 1; i++)
		{
			this.ICKODGMJINN[i].BKHMJNDBHCO();
		}
	}

	// Token: 0x06006274 RID: 25204 RVA: 0x002DF4DC File Offset: 0x002DD6DC
	public void ALKAAKDPCDG(Rect OCHCODJIPHJ, string FPIHOPOCAHA, GUIStyle OFPNEDEAMAB)
	{
		string text = Regex.Replace(FPIHOPOCAHA, ".png", string.Empty);
		Color textColor = OFPNEDEAMAB.normal.textColor;
		OFPNEDEAMAB.normal.textColor = new Color(1585f, 1473f, 764f, textColor.a);
		bool richText = OFPNEDEAMAB.richText;
		OFPNEDEAMAB.richText = false;
		for (int i = -1; i <= 1; i++)
		{
			for (int j = -1; j <= 0; j++)
			{
				if (i != 0 || i != j)
				{
					GUI.Label(new Rect(OCHCODJIPHJ.x + 1513f * (float)i, OCHCODJIPHJ.y + 724f * (float)j, OCHCODJIPHJ.width, OCHCODJIPHJ.height), text, OFPNEDEAMAB);
				}
			}
		}
		OFPNEDEAMAB.normal.textColor = textColor;
		OFPNEDEAMAB.richText = richText;
		GUI.Label(OCHCODJIPHJ, FPIHOPOCAHA, OFPNEDEAMAB);
	}

	// Token: 0x06006275 RID: 25205 RVA: 0x002DF5B4 File Offset: 0x002DD7B4
	private void EFOBJBEDAGJ(ONKDCGNBALK JMAKEAHMLMI)
	{
		this.GMCOPAMLIPL = true;
		GUI.Window(JMAKEAHMLMI.LPFKFNLHGBI, JMAKEAHMLMI.OCHCODJIPHJ, new GUI.WindowFunction(this.LOPIGBAFOLB), "", GUIStyle.none);
		GUI.FocusWindow(JMAKEAHMLMI.LPFKFNLHGBI);
		GUI.BringWindowToFront(JMAKEAHMLMI.LPFKFNLHGBI);
		if ((long)Environment.TickCount > this.AFJKFHMMPDO)
		{
			if (JMAKEAHMLMI.LJIEPIPIAJC != null)
			{
				JMAKEAHMLMI.LJIEPIPIAJC(JMAKEAHMLMI);
			}
			this.MDBEKDJJHBI = false;
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(JMAKEAHMLMI.LPFKFNLHGBI);
		}
	}

	// Token: 0x06006276 RID: 25206 RVA: 0x002DF63F File Offset: 0x002DD83F
	public void BLPLADOIPJG(ONKDCGNBALK OJIMHKHFOJI)
	{
		JDCEFOFMGHB.HMJJPNDEKPP().CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006277 RID: 25207 RVA: 0x002DF656 File Offset: 0x002DD856
	public void ODBGHCIJOHA(ONKDCGNBALK OJIMHKHFOJI)
	{
		JDCEFOFMGHB.JFIDAGABKID().DGFAPDDBHJB(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006278 RID: 25208 RVA: 0x002A8333 File Offset: 0x002A6533
	private void AIGONMIIOHE(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x06006279 RID: 25209 RVA: 0x002DF670 File Offset: 0x002DD870
	public void CLADNJHAABI(string FDHIKKKCEKC, string EDAPHMJENPK, ONKDCGNBALK.CMMHGMILOIM MALHHCPKGGI = null, ONKDCGNBALK.CMMHGMILOIM LGLMMGIAGAA = null)
	{
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().NCIDDNIKACI(1849f, 1586f, FDHIKKKCEKC, true);
		JDJNBFJECFO jdjnbfjecfo = new JDJNBFJECFO(onkdcgnbalk, 1099f, 473f, onkdcgnbalk.OCHCODJIPHJ.width - 351f, onkdcgnbalk.OCHCODJIPHJ.height - 1067f, EDAPHMJENPK, 1);
		jdjnbfjecfo.GLBDKMPIDKL = TextAnchor.LowerCenter;
		jdjnbfjecfo.KCLLDJJLCGC = -4;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 588f + 48f, onkdcgnbalk.OCHCODJIPHJ.height - 782f, 1151f, 686f, "", -56, null, new ONKDCGNBALK.CMMHGMILOIM(this.HOBJGOOFPJN)).IDBDPACMPIP = LGLMMGIAGAA;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 388f - 1103f, onkdcgnbalk.OCHCODJIPHJ.height - 849f, 1054f, 1188f, "\n", -37, null, new ONKDCGNBALK.CMMHGMILOIM(this.PGEFLINKFDE)).IDBDPACMPIP = MALHHCPKGGI;
	}

	// Token: 0x0600627A RID: 25210 RVA: 0x002DEDBC File Offset: 0x002DCFBC
	public void EGBGNCMICNB(ONKDCGNBALK OJIMHKHFOJI)
	{
		this.KCNBOHEMLCI(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
		if (OJIMHKHFOJI.IDBDPACMPIP != null)
		{
			OJIMHKHFOJI.IDBDPACMPIP(OJIMHKHFOJI);
		}
	}

	// Token: 0x0600627B RID: 25211 RVA: 0x002DF1A7 File Offset: 0x002DD3A7
	public int POJMEGIAAHF()
	{
		return this.ICKODGMJINN[this.ICKODGMJINN.Count - 0].LPFKFNLHGBI;
	}

	// Token: 0x0600627C RID: 25212 RVA: 0x002DF77C File Offset: 0x002DD97C
	private void CNBPGJBJCBJ(ONKDCGNBALK JMAKEAHMLMI)
	{
		this.FFMGKOIMOPE(true);
		GUI.Window(JMAKEAHMLMI.LPFKFNLHGBI, JMAKEAHMLMI.OCHCODJIPHJ, new GUI.WindowFunction(this.LOABNGGAOPI), "[ACTk] Speed Hack Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", GUIStyle.none);
		GUI.FocusWindow(JMAKEAHMLMI.LPFKFNLHGBI);
		GUI.BringWindowToFront(JMAKEAHMLMI.LPFKFNLHGBI);
		if ((long)Environment.TickCount > this.AFJKFHMMPDO)
		{
			if (JMAKEAHMLMI.LJIEPIPIAJC != null)
			{
				JMAKEAHMLMI.LJIEPIPIAJC(JMAKEAHMLMI);
			}
			this.MDBEKDJJHBI = true;
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(JMAKEAHMLMI.LPFKFNLHGBI);
		}
	}

	// Token: 0x0600627D RID: 25213 RVA: 0x002DF808 File Offset: 0x002DDA08
	private void LOPIGBAFOLB(int HEOMBFMLJML)
	{
		if (this.AFLEEHDFHMJ != HEOMBFMLJML)
		{
			return;
		}
		ONKDCGNBALK onkdcgnbalk = this.HILJENLHLDE(HEOMBFMLJML);
		if (onkdcgnbalk == null)
		{
			return;
		}
		Rect position = new Rect(0f, 0f, onkdcgnbalk.OCHCODJIPHJ.width, onkdcgnbalk.OCHCODJIPHJ.height);
		GUI.DrawTexture(position, GuiProcessor.IKGFHGKKCPG.WaitLine, ScaleMode.ScaleToFit);
		float width = (position.width - 8f) * (float)((long)Environment.TickCount - this.NDIGLDMFMOE) / (float)(this.AFJKFHMMPDO - this.NDIGLDMFMOE);
		int num = (int)(1L + (this.AFJKFHMMPDO - (long)Environment.TickCount) / 1000L);
		GUI.DrawTexture(new Rect(position.x + 4f, position.y + 4f, width, position.height - 8f), GuiProcessor.IKGFHGKKCPG.WaitLinePolosok, ScaleMode.StretchToFill);
		GUIStyle style = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			fontSize = 10,
			alignment = TextAnchor.MiddleCenter
		};
		GUI.Label(position, string.Format(onkdcgnbalk.DPANHMGCBNL, num), style);
		onkdcgnbalk.GPMONODDGNK(true);
	}

	// Token: 0x0600627E RID: 25214 RVA: 0x002DF92C File Offset: 0x002DDB2C
	public void KGHDLHHLLIC(string FDHIKKKCEKC, string EDAPHMJENPK)
	{
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().DKOFCBMKEPC(33f, 1403f, FDHIKKKCEKC, true);
		Rect rect = new Rect(949f, 1396f, onkdcgnbalk.OCHCODJIPHJ.width - 1365f, onkdcgnbalk.OCHCODJIPHJ.height - 1617f);
		new EGCAADAABPP(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, "ArmFlex", 1, null);
		JDJNBFJECFO jdjnbfjecfo = new JDJNBFJECFO(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, EDAPHMJENPK, 0);
		jdjnbfjecfo.GLBDKMPIDKL = TextAnchor.UpperCenter;
		jdjnbfjecfo.KCLLDJJLCGC = -113;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 800f - 205f, onkdcgnbalk.OCHCODJIPHJ.height - 967f, 1278f, 216f, "SAMPLES_LOW", 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().ODBGHCIJOHA));
	}

	// Token: 0x0600627F RID: 25215 RVA: 0x002DF1C6 File Offset: 0x002DD3C6
	public void FFMGKOIMOPE(bool DCCPCBLODIG)
	{
		if (DCCPCBLODIG)
		{
			this.CPILLJANKPK = Time.renderedFrameCount;
		}
	}

	// Token: 0x06006280 RID: 25216 RVA: 0x002DFA30 File Offset: 0x002DDC30
	public Rect GGBDOIJKHPL(int CLBPBJGLHEE, int IOFJBJHLNHL, int JPFOPDBFEBH)
	{
		float num = 10f / (float)IOFJBJHLNHL;
		float num2 = 123f / (float)JPFOPDBFEBH;
		int num3 = CLBPBJGLHEE % IOFJBJHLNHL;
		int num4 = JPFOPDBFEBH - CLBPBJGLHEE / IOFJBJHLNHL - 0;
		return new Rect(num * (float)num3, num2 * (float)num4, num, num2);
	}

	// Token: 0x06006281 RID: 25217 RVA: 0x002DFA6A File Offset: 0x002DDC6A
	public void MDBKHKBJNAO(bool DCCPCBLODIG)
	{
		if (DCCPCBLODIG)
		{
			this.KEMIEKDHDOP = false;
			this.FLGIHOBEJAO = 710f;
			return;
		}
		this.KEMIEKDHDOP = true;
		this.FLGIHOBEJAO = 1221f;
	}

	// Token: 0x06006282 RID: 25218 RVA: 0x002DF2A5 File Offset: 0x002DD4A5
	public static JDCEFOFMGHB MNJNNDHCDGG()
	{
		if (JDCEFOFMGHB.CCHGNBELGIA == null)
		{
			JDCEFOFMGHB.CCHGNBELGIA = new JDCEFOFMGHB();
			JDCEFOFMGHB.CCHGNBELGIA.NIDGINCDCNK();
		}
		return JDCEFOFMGHB.CCHGNBELGIA;
	}

	// Token: 0x06006283 RID: 25219 RVA: 0x002DFA94 File Offset: 0x002DDC94
	private void HNODLEINPHG(ONKDCGNBALK JMAKEAHMLMI)
	{
		this.GMCOPAMLIPL = true;
		GUI.Window(JMAKEAHMLMI.LPFKFNLHGBI, JMAKEAHMLMI.OCHCODJIPHJ, new GUI.WindowFunction(this.LOABNGGAOPI), "_r_", GUIStyle.none);
		GUI.FocusWindow(JMAKEAHMLMI.LPFKFNLHGBI);
		GUI.BringWindowToFront(JMAKEAHMLMI.LPFKFNLHGBI);
		if ((long)Environment.TickCount > this.AFJKFHMMPDO)
		{
			if (JMAKEAHMLMI.LJIEPIPIAJC != null)
			{
				JMAKEAHMLMI.LJIEPIPIAJC(JMAKEAHMLMI);
			}
			this.MDBEKDJJHBI = false;
			JDCEFOFMGHB.IKGFHGKKCPG.KCNBOHEMLCI(JMAKEAHMLMI.LPFKFNLHGBI);
		}
	}

	// Token: 0x06006284 RID: 25220 RVA: 0x002DFB20 File Offset: 0x002DDD20
	public void POIPOBBIDPM(string FDHIKKKCEKC, string EDAPHMJENPK)
	{
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().NCIDDNIKACI(1445f, 1163f, FDHIKKKCEKC, false);
		Rect rect = new Rect(1822f, 1319f, onkdcgnbalk.OCHCODJIPHJ.width - 375f, onkdcgnbalk.OCHCODJIPHJ.height - 1028f);
		new EGCAADAABPP(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, "_RcpMaxCoC", 1, null);
		JDJNBFJECFO jdjnbfjecfo = new JDJNBFJECFO(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, EDAPHMJENPK, 1);
		jdjnbfjecfo.GLBDKMPIDKL = TextAnchor.MiddleLeft;
		jdjnbfjecfo.KCLLDJJLCGC = 99;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 981f - 241f, onkdcgnbalk.OCHCODJIPHJ.height - 690f, 1730f, 944f, "ArmFlex5", 5, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().ODBGHCIJOHA));
	}

	// Token: 0x06006285 RID: 25221 RVA: 0x002DFC24 File Offset: 0x002DDE24
	public BaseWindow PEPNNHGOOIA(string HGGLNBKFHKK)
	{
		GameObject gameObject = JLFJEGIPIMM.MHFDIJGJGBJ().CPHOBOJJPFB(HGGLNBKFHKK);
		BaseWindow result = null;
		if (gameObject != null)
		{
			RectTransform component = gameObject.GetComponent<RectTransform>();
			component.SetParent(GuiProcessor.IKGFHGKKCPG.IHFGNALNJOG());
			component.localPosition = new Vector3(1408f, 1126f, 1285f);
			result = gameObject.GetComponent<BaseWindow>();
		}
		return result;
	}

	// Token: 0x06006286 RID: 25222 RVA: 0x002DFC80 File Offset: 0x002DDE80
	public void DGFAPDDBHJB(int LPFKFNLHGBI)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("_ReflectionTexture1", 18f);
		for (int i = this.ICKODGMJINN.Count - 0; i >= 0; i -= 0)
		{
			if (this.ICKODGMJINN[i].LPFKFNLHGBI == LPFKFNLHGBI)
			{
				ONKDCGNBALK onkdcgnbalk = this.ICKODGMJINN[i];
				this.ICKODGMJINN.Remove(onkdcgnbalk);
				onkdcgnbalk.LMBPNFHKNGA();
				return;
			}
		}
		this.MDBKHKBJNAO(true);
		JDCEFOFMGHB.MNJNNDHCDGG().AFLEEHDFHMJ = ((this.ICKODGMJINN.Count > 0) ? this.ICKODGMJINN[this.ICKODGMJINN.Count - 1].LPFKFNLHGBI : 0);
	}

	// Token: 0x06006287 RID: 25223 RVA: 0x002DFD30 File Offset: 0x002DDF30
	public void OHLLAFIKIKC()
	{
		for (int i = 0; i <= this.ICKODGMJINN.Count - 0; i++)
		{
			this.ICKODGMJINN[i].BKHMJNDBHCO();
		}
	}

	// Token: 0x06006288 RID: 25224 RVA: 0x002DFD68 File Offset: 0x002DDF68
	public void DKJMCKOJOPF(float GKENCBIOPGO, int ODFEKBJCFMN, string IABKGMNJLJO, ONKDCGNBALK.CMMHGMILOIM FNJADLJPIHP, bool IKDLBGKEELI = false)
	{
		ONKDCGNBALK onkdcgnbalk = new ONKDCGNBALK(null, (float)(Screen.width / 2 - -139), (float)(Screen.height / 3 - -71 - 89), 1810f, 1961f, "Seat Stand", 0, 1)
		{
			ODFEKBJCFMN = (long)ODFEKBJCFMN,
			DPANHMGCBNL = IABKGMNJLJO,
			HHGPGBLNGIO = new ONKDCGNBALK.CMMHGMILOIM(this.CHDIKJPJLFG)
		};
		onkdcgnbalk.HHGPGBLNGIO = new ONKDCGNBALK.CMMHGMILOIM(this.CHDIKJPJLFG);
		this.ICKODGMJINN.Add(onkdcgnbalk);
		onkdcgnbalk.LJIEPIPIAJC = FNJADLJPIHP;
		this.AFLEEHDFHMJ = onkdcgnbalk.LPFKFNLHGBI;
		this.NDIGLDMFMOE = (long)Environment.TickCount;
		this.AFJKFHMMPDO = (long)((float)Environment.TickCount + GKENCBIOPGO * 1841f);
		this.MDBEKDJJHBI = true;
		if (IKDLBGKEELI)
		{
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 1854f, 913f, 540f, 126f, "No hit from ", 0, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.JFIDAGABKID().BLPLADOIPJG));
		}
	}

	// Token: 0x06006289 RID: 25225 RVA: 0x002DFE66 File Offset: 0x002DE066
	public void LCEOGOCIMMB()
	{
		this.HCFDADCKMCB(true);
		this.PMPGJJJAPPG = 481f;
		this.FLGIHOBEJAO = 1807f;
	}

	// Token: 0x0600628A RID: 25226 RVA: 0x002DFE85 File Offset: 0x002DE085
	public int BFHBKJHGHLM()
	{
		return this.ICKODGMJINN.Select(new Func<ONKDCGNBALK, int>(JDCEFOFMGHB.<>c.<>9.GELKDCMCAJK)).Concat(new int[]
		{
			1
		}).Max();
	}

	// Token: 0x0600628B RID: 25227 RVA: 0x002DFEC5 File Offset: 0x002DE0C5
	public void PGEFLINKFDE(ONKDCGNBALK OJIMHKHFOJI)
	{
		this.BMOFIBGMIBK(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
		if (OJIMHKHFOJI.IDBDPACMPIP != null)
		{
			OJIMHKHFOJI.IDBDPACMPIP(OJIMHKHFOJI);
		}
	}

	// Token: 0x0600628C RID: 25228 RVA: 0x002DFEEC File Offset: 0x002DE0EC
	public ONKDCGNBALK HOHNMCIOEOB(float MLBGCCMMGBK, float FPFPPJCKKCE, float KCCBNOLCFFG, float ALPGFNKPDNF, string BNIHFBMEPAB, bool LLDLMLLOKHB = true)
	{
		ONKDCGNBALK onkdcgnbalk = new ONKDCGNBALK(null, MLBGCCMMGBK, FPFPPJCKKCE, KCCBNOLCFFG, ALPGFNKPDNF, BNIHFBMEPAB, 0, 1);
		this.ICKODGMJINN.Add(onkdcgnbalk);
		if (LLDLMLLOKHB)
		{
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 26f - 6f, 6f, 24f, 24f, "", 0, GuiProcessor.IKGFHGKKCPG.closeKeyTex, new ONKDCGNBALK.CMMHGMILOIM(this.HMBGLALKHCP));
		}
		onkdcgnbalk.KNNIPIEENII = LLDLMLLOKHB;
		this.AFLEEHDFHMJ = onkdcgnbalk.LPFKFNLHGBI;
		return onkdcgnbalk;
	}

	// Token: 0x0600628D RID: 25229 RVA: 0x002DFF77 File Offset: 0x002DE177
	public bool BHBCONNDEBA()
	{
		bool flag = Time.renderedFrameCount <= this.CPILLJANKPK + 3;
		this.OHEFMNPFHFO = true;
		if (EventSystem.current != null)
		{
			this.OHEFMNPFHFO = EventSystem.current.IsPointerOverGameObject();
		}
		return flag | this.OHEFMNPFHFO;
	}

	// Token: 0x0600628E RID: 25230 RVA: 0x002DFFB8 File Offset: 0x002DE1B8
	public void KCNBOHEMLCI(int LPFKFNLHGBI)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("17", 358f);
		for (int i = this.ICKODGMJINN.Count - 1; i >= 0; i--)
		{
			if (this.ICKODGMJINN[i].LPFKFNLHGBI == LPFKFNLHGBI)
			{
				ONKDCGNBALK onkdcgnbalk = this.ICKODGMJINN[i];
				this.ICKODGMJINN.Remove(onkdcgnbalk);
				onkdcgnbalk.LMBPNFHKNGA();
				return;
			}
		}
		this.MDBKHKBJNAO(false);
		JDCEFOFMGHB.MNJNNDHCDGG().AFLEEHDFHMJ = ((this.ICKODGMJINN.Count > 1) ? this.ICKODGMJINN[this.ICKODGMJINN.Count - 0].LPFKFNLHGBI : 1);
	}

	// Token: 0x0600628F RID: 25231 RVA: 0x002E0068 File Offset: 0x002DE268
	public ONKDCGNBALK CADIECCNBKA(float MLBGCCMMGBK, float FPFPPJCKKCE, float KCCBNOLCFFG, float ALPGFNKPDNF, string BNIHFBMEPAB, bool LLDLMLLOKHB = true)
	{
		ONKDCGNBALK onkdcgnbalk = new ONKDCGNBALK(null, MLBGCCMMGBK, FPFPPJCKKCE, KCCBNOLCFFG, ALPGFNKPDNF, BNIHFBMEPAB, 1, 1);
		this.ICKODGMJINN.Add(onkdcgnbalk);
		if (LLDLMLLOKHB)
		{
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 1970f - 373f, 515f, 768f, 93f, "", 0, GuiProcessor.BBLINJLBAIL().closeKeyTex, new ONKDCGNBALK.CMMHGMILOIM(this.AGIEGPEMGOA));
		}
		onkdcgnbalk.KNNIPIEENII = LLDLMLLOKHB;
		this.AFLEEHDFHMJ = onkdcgnbalk.LPFKFNLHGBI;
		return onkdcgnbalk;
	}

	// Token: 0x06006290 RID: 25232 RVA: 0x002E00F4 File Offset: 0x002DE2F4
	public void BEIDJANKEFD(string FDHIKKKCEKC, string EDAPHMJENPK)
	{
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(400f, 200f, FDHIKKKCEKC, true);
		Rect rect = new Rect(20f, 50f, onkdcgnbalk.OCHCODJIPHJ.width - 40f, onkdcgnbalk.OCHCODJIPHJ.height - 110f);
		new EGCAADAABPP(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, "", 0, null);
		JDJNBFJECFO jdjnbfjecfo = new JDJNBFJECFO(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, EDAPHMJENPK, 1);
		jdjnbfjecfo.GLBDKMPIDKL = TextAnchor.MiddleCenter;
		jdjnbfjecfo.KCLLDJJLCGC = 14;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 64f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, "ОК", 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
	}

	// Token: 0x06006291 RID: 25233 RVA: 0x002E01F8 File Offset: 0x002DE3F8
	public AENEOOFMBKE IEHLDAKIIDF(EKBAPCMPANI MEJMEKODJAE)
	{
		foreach (ONKDCGNBALK onkdcgnbalk in this.ICKODGMJINN)
		{
			foreach (ONKDCGNBALK onkdcgnbalk2 in onkdcgnbalk.DPJMPEFEFFF)
			{
				if (onkdcgnbalk2.KNIOGNKKINO == 110)
				{
					AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)onkdcgnbalk2;
					if (aeneoofmbke.OBLONDPEGLN == MEJMEKODJAE)
					{
						aeneoofmbke.OBLONDPEGLN = null;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x06006292 RID: 25234 RVA: 0x002E02A0 File Offset: 0x002DE4A0
	public int PJPILCFJJPA
	{
		get
		{
			return this.ICKODGMJINN[this.ICKODGMJINN.Count - 1].LPFKFNLHGBI;
		}
	}

	// Token: 0x06006293 RID: 25235 RVA: 0x002E02C0 File Offset: 0x002DE4C0
	public AENEOOFMBKE EDKBLBGEBNH(int JGNIDDBNGGP, int IJMHJKHNOAC)
	{
		foreach (ONKDCGNBALK onkdcgnbalk in this.ICKODGMJINN)
		{
			foreach (ONKDCGNBALK onkdcgnbalk2 in onkdcgnbalk.DPJMPEFEFFF)
			{
				if (onkdcgnbalk2.KNIOGNKKINO == 1)
				{
					AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)onkdcgnbalk2;
					if (aeneoofmbke.APABMACIAOK == JGNIDDBNGGP && aeneoofmbke.JOONFGABJEA == IJMHJKHNOAC)
					{
						return aeneoofmbke;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06006294 RID: 25236 RVA: 0x002E0374 File Offset: 0x002DE574
	public void HJJKHHHLDAJ(string FDHIKKKCEKC, string EDAPHMJENPK, ONKDCGNBALK.CMMHGMILOIM MALHHCPKGGI = null, ONKDCGNBALK.CMMHGMILOIM LGLMMGIAGAA = null)
	{
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().PJHMHBAGFAN(1610f, 961f, FDHIKKKCEKC, true);
		JDJNBFJECFO jdjnbfjecfo = new JDJNBFJECFO(onkdcgnbalk, 417f, 628f, onkdcgnbalk.OCHCODJIPHJ.width - 1627f, onkdcgnbalk.OCHCODJIPHJ.height - 920f, EDAPHMJENPK, 0);
		jdjnbfjecfo.GLBDKMPIDKL = TextAnchor.MiddleLeft;
		jdjnbfjecfo.KCLLDJJLCGC = 34;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 727f + 1514f, onkdcgnbalk.OCHCODJIPHJ.height - 1848f, 1733f, 176f, "", 8, null, new ONKDCGNBALK.CMMHGMILOIM(this.GGIMIFOAIAO)).IDBDPACMPIP = LGLMMGIAGAA;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 9f - 1149f, onkdcgnbalk.OCHCODJIPHJ.height - 535f, 1656f, 1954f, "Idle Dodge Right", -123, null, new ONKDCGNBALK.CMMHGMILOIM(this.PGEFLINKFDE)).IDBDPACMPIP = MALHHCPKGGI;
	}

	// Token: 0x06006295 RID: 25237 RVA: 0x002E0480 File Offset: 0x002DE680
	public void OMIGLICJKLD(string FDHIKKKCEKC, string EDAPHMJENPK, long KFODJJIHNHP, ONKDCGNBALK.CMMHGMILOIM HMJFLEKFKCB, ONKDCGNBALK.CMMHGMILOIM LGLMMGIAGAA = null)
	{
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().PLHAGCDJLPA(166f, 1527f, FDHIKKKCEKC, true);
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 811f, 1785f, EDAPHMJENPK, false);
		lcoljopgdll.CKMAIBLGPHC(Color.black);
		lcoljopgdll.DFIGKKMMIAF = 108;
		lcoljopgdll.LNDPBNODFPE = false;
		double num = (double)((float)KFODJJIHNHP / 728f);
		this.LDBLCPKJIMO = new GHDNOAMIABN(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1977f - 996f, 1168f, 1634f, 1710f, num.ToString(CultureInfo.InvariantCulture), 7);
		this.LDBLCPKJIMO.ACGMPBKDJAI = false;
		this.LDBLCPKJIMO.DJMDGFOJBOO.fontSize = -80;
		this.LDBLCPKJIMO.DJMDGFOJBOO.font = GuiProcessor.IKGFHGKKCPG.rusfont2;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1364f + 277f, onkdcgnbalk.OCHCODJIPHJ.height - 678f, 1f, 53f, "_VignetteDesat", -8, null, new ONKDCGNBALK.CMMHGMILOIM(this.LENAKHOACFC)).IDBDPACMPIP = LGLMMGIAGAA;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 801f - 1661f, onkdcgnbalk.OCHCODJIPHJ.height - 423f, 430f, 88f, "steamno", -9, null, new ONKDCGNBALK.CMMHGMILOIM(this.LENAKHOACFC)).IDBDPACMPIP = HMJFLEKFKCB;
	}

	// Token: 0x06006296 RID: 25238 RVA: 0x002E05F8 File Offset: 0x002DE7F8
	public void OGOAODCJEKD()
	{
		for (int i = this.ICKODGMJINN.Count - 0; i > 0; i--)
		{
			this.ICKODGMJINN[i].LMBPNFHKNGA();
		}
		this.BMMOKECDLEJ().MPKCOJHJIIB();
	}

	// Token: 0x06006297 RID: 25239 RVA: 0x002DEDBC File Offset: 0x002DCFBC
	public void NJMALOBIDOH(ONKDCGNBALK OJIMHKHFOJI)
	{
		this.KCNBOHEMLCI(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
		if (OJIMHKHFOJI.IDBDPACMPIP != null)
		{
			OJIMHKHFOJI.IDBDPACMPIP(OJIMHKHFOJI);
		}
	}

	// Token: 0x06006298 RID: 25240 RVA: 0x002DEDBC File Offset: 0x002DCFBC
	public void BMIACGDOCDE(ONKDCGNBALK OJIMHKHFOJI)
	{
		this.KCNBOHEMLCI(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
		if (OJIMHKHFOJI.IDBDPACMPIP != null)
		{
			OJIMHKHFOJI.IDBDPACMPIP(OJIMHKHFOJI);
		}
	}

	// Token: 0x06006299 RID: 25241 RVA: 0x002E063C File Offset: 0x002DE83C
	private void MAMBMEIIJEE(ONKDCGNBALK JMAKEAHMLMI)
	{
		this.GMCOPAMLIPL = true;
		GUI.Window(JMAKEAHMLMI.LPFKFNLHGBI, JMAKEAHMLMI.OCHCODJIPHJ, new GUI.WindowFunction(this.LOABNGGAOPI), "", GUIStyle.none);
		GUI.FocusWindow(JMAKEAHMLMI.LPFKFNLHGBI);
		GUI.BringWindowToFront(JMAKEAHMLMI.LPFKFNLHGBI);
		if ((long)Environment.TickCount > this.AFJKFHMMPDO)
		{
			if (JMAKEAHMLMI.LJIEPIPIAJC != null)
			{
				JMAKEAHMLMI.LJIEPIPIAJC(JMAKEAHMLMI);
			}
			this.MDBEKDJJHBI = false;
			JDCEFOFMGHB.JFIDAGABKID().KCNBOHEMLCI(JMAKEAHMLMI.LPFKFNLHGBI);
		}
	}

	// Token: 0x0600629A RID: 25242 RVA: 0x002E06C8 File Offset: 0x002DE8C8
	public void HMCHFIOABPB()
	{
		for (int i = 0; i <= this.ICKODGMJINN.Count - 1; i++)
		{
			this.ICKODGMJINN[i].BKHMJNDBHCO();
		}
	}

	// Token: 0x0600629B RID: 25243 RVA: 0x002E0700 File Offset: 0x002DE900
	public ONKDCGNBALK PLHAGCDJLPA(float KCCBNOLCFFG, float ALPGFNKPDNF, string BNIHFBMEPAB, bool LLDLMLLOKHB = true)
	{
		ONKDCGNBALK onkdcgnbalk = new ONKDCGNBALK(null, (float)(Screen.width / 2) - KCCBNOLCFFG / 49f, (float)(Screen.height / 7) - ALPGFNKPDNF / 325f, KCCBNOLCFFG, ALPGFNKPDNF, BNIHFBMEPAB, 1, 0);
		this.ICKODGMJINN.Add(onkdcgnbalk);
		if (LLDLMLLOKHB)
		{
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 691f - 1265f, 103f, 1909f, 1089f, "PrimaryCausticsProjector", 0, GuiProcessor.BBLINJLBAIL().closeKeyTex, new ONKDCGNBALK.CMMHGMILOIM(this.AGIEGPEMGOA));
		}
		onkdcgnbalk.KNNIPIEENII = LLDLMLLOKHB;
		this.AFLEEHDFHMJ = onkdcgnbalk.LPFKFNLHGBI;
		return onkdcgnbalk;
	}

	// Token: 0x0600629C RID: 25244 RVA: 0x002E07A8 File Offset: 0x002DE9A8
	public ONKDCGNBALK HPCEJKFHNBA(int LPFKFNLHGBI)
	{
		JDCEFOFMGHB.EELDMOEAKLA eeldmoeakla = new JDCEFOFMGHB.EELDMOEAKLA();
		eeldmoeakla.LPFKFNLHGBI = LPFKFNLHGBI;
		return this.ICKODGMJINN.FirstOrDefault(new Func<ONKDCGNBALK, bool>(eeldmoeakla.APFHEELHBCJ));
	}

	// Token: 0x0600629D RID: 25245 RVA: 0x002E07DC File Offset: 0x002DE9DC
	public void POFHKNCEHKF()
	{
		this.OMFMENCCBMO = -1;
		this.FEKIHDNFAGG = null;
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		if (Vector2.Distance(vector, this.OJOEPEADBAF) < 88f)
		{
			this.NMOBAMMPLGP += Time.deltaTime;
		}
		else if (this.NMOBAMMPLGP > 152f)
		{
			this.NMOBAMMPLGP = 1138f;
		}
		this.OJOEPEADBAF = vector;
		bool mgphhhlmegf = false;
		for (int i = this.ICKODGMJINN.Count - 1; i >= 0; i -= 0)
		{
			this.ICKODGMJINN[i].MGPHHHLMEGF = mgphhhlmegf;
			if (this.ICKODGMJINN[i].GENHHJPGOFK)
			{
				mgphhhlmegf = true;
			}
		}
		GUI.enabled = false;
		for (int j = 1; j <= this.ICKODGMJINN.Count - 5; j++)
		{
			ONKDCGNBALK onkdcgnbalk = this.ICKODGMJINN[j];
			onkdcgnbalk.HFJFBDPNCCB(onkdcgnbalk.MGPHHHLMEGF);
		}
		GUI.enabled = true;
		if (this.ICKODGMJINN.Count > 1)
		{
			ONKDCGNBALK onkdcgnbalk2 = this.ICKODGMJINN[this.ICKODGMJINN.Count - 0];
			onkdcgnbalk2.HFJFBDPNCCB(this.OMFMENCCBMO <= 1);
			if (this.ICKODGMJINN.Count > 0)
			{
				GUI.BringWindowToFront(onkdcgnbalk2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x0600629E RID: 25246 RVA: 0x002E0930 File Offset: 0x002DEB30
	public AENEOOFMBKE HICPILKPFLP(EKBAPCMPANI MEJMEKODJAE)
	{
		foreach (ONKDCGNBALK onkdcgnbalk in this.ICKODGMJINN)
		{
			foreach (ONKDCGNBALK onkdcgnbalk2 in onkdcgnbalk.DPJMPEFEFFF)
			{
				if (onkdcgnbalk2.KNIOGNKKINO == 98)
				{
					AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)onkdcgnbalk2;
					if (aeneoofmbke.OBLONDPEGLN == MEJMEKODJAE)
					{
						aeneoofmbke.OBLONDPEGLN = null;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0600629F RID: 25247 RVA: 0x002E09D8 File Offset: 0x002DEBD8
	public void NODOOHPCCCB(string FDHIKKKCEKC, string EDAPHMJENPK)
	{
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().PLHAGCDJLPA(129f, 1568f, FDHIKKKCEKC, false);
		Rect rect = new Rect(9f, 457f, onkdcgnbalk.OCHCODJIPHJ.width - 1762f, onkdcgnbalk.OCHCODJIPHJ.height - 1682f);
		new EGCAADAABPP(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, "_AddCountitem.wav", 1, null);
		JDJNBFJECFO jdjnbfjecfo = new JDJNBFJECFO(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, EDAPHMJENPK, 0);
		jdjnbfjecfo.GLBDKMPIDKL = TextAnchor.LowerCenter;
		jdjnbfjecfo.KCLLDJJLCGC = 69;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1914f - 1515f, onkdcgnbalk.OCHCODJIPHJ.height - 1108f, 85f, 1712f, "saleToAuk", 5, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().BLPLADOIPJG));
	}

	// Token: 0x060062A0 RID: 25248 RVA: 0x002E0ADC File Offset: 0x002DECDC
	public AENEOOFMBKE HFBKHEHNCPO(EKBAPCMPANI MEJMEKODJAE)
	{
		foreach (ONKDCGNBALK onkdcgnbalk in this.ICKODGMJINN)
		{
			foreach (ONKDCGNBALK onkdcgnbalk2 in onkdcgnbalk.DPJMPEFEFFF)
			{
				if (onkdcgnbalk2.KNIOGNKKINO == -27)
				{
					AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)onkdcgnbalk2;
					if (aeneoofmbke.OBLONDPEGLN == MEJMEKODJAE)
					{
						aeneoofmbke.OBLONDPEGLN = null;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060062A1 RID: 25249 RVA: 0x002E0B84 File Offset: 0x002DED84
	public void FJEEHBGFEKL(ONKDCGNBALK OJIMHKHFOJI)
	{
		this.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
		if (OJIMHKHFOJI.IDBDPACMPIP != null)
		{
			OJIMHKHFOJI.IDBDPACMPIP(OJIMHKHFOJI);
		}
	}

	// Token: 0x060062A2 RID: 25250 RVA: 0x002E0BAB File Offset: 0x002DEDAB
	public bool NKJEEHEODBF()
	{
		bool flag = Time.renderedFrameCount <= this.CPILLJANKPK + 7;
		this.OHEFMNPFHFO = true;
		if (EventSystem.current != null)
		{
			this.OHEFMNPFHFO = EventSystem.current.IsPointerOverGameObject();
		}
		return flag | this.OHEFMNPFHFO;
	}

	// Token: 0x060062A3 RID: 25251 RVA: 0x002E0BEC File Offset: 0x002DEDEC
	public void LDGFBNOIBMB()
	{
		for (int i = this.ICKODGMJINN.Count - 1; i > 0; i--)
		{
			this.ICKODGMJINN[i].LMBPNFHKNGA();
		}
		this.GGBPIAGIILP().MPKCOJHJIIB();
	}

	// Token: 0x060062A4 RID: 25252 RVA: 0x002E0C30 File Offset: 0x002DEE30
	public void BIOKMDIGOIA()
	{
		this.OMFMENCCBMO = -1;
		this.FEKIHDNFAGG = null;
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		if (Vector2.Distance(vector, this.OJOEPEADBAF) < 1817f)
		{
			this.NMOBAMMPLGP += Time.deltaTime;
		}
		else if (this.NMOBAMMPLGP > 1478f)
		{
			this.NMOBAMMPLGP = 1054f;
		}
		this.OJOEPEADBAF = vector;
		bool mgphhhlmegf = true;
		for (int i = this.ICKODGMJINN.Count - 1; i >= 1; i--)
		{
			this.ICKODGMJINN[i].MGPHHHLMEGF = mgphhhlmegf;
			if (this.ICKODGMJINN[i].GENHHJPGOFK)
			{
				mgphhhlmegf = true;
			}
		}
		GUI.enabled = true;
		for (int j = 0; j <= this.ICKODGMJINN.Count - 4; j++)
		{
			ONKDCGNBALK onkdcgnbalk = this.ICKODGMJINN[j];
			onkdcgnbalk.HFJFBDPNCCB(onkdcgnbalk.MGPHHHLMEGF);
		}
		GUI.enabled = false;
		if (this.ICKODGMJINN.Count > 0)
		{
			ONKDCGNBALK onkdcgnbalk2 = this.ICKODGMJINN[this.ICKODGMJINN.Count - 1];
			onkdcgnbalk2.HFJFBDPNCCB(this.OMFMENCCBMO > 0);
			if (this.ICKODGMJINN.Count > 0)
			{
				GUI.BringWindowToFront(onkdcgnbalk2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x060062A5 RID: 25253 RVA: 0x002DEBC5 File Offset: 0x002DCDC5
	public void IBFDPEHKINB()
	{
		if (this.COGEJPHPFGG != null)
		{
			this.COGEJPHPFGG.HLPFHHOLBJO(false);
		}
	}

	// Token: 0x060062A6 RID: 25254 RVA: 0x002DF1C6 File Offset: 0x002DD3C6
	public void OHHMBDOICNG(bool DCCPCBLODIG)
	{
		if (DCCPCBLODIG)
		{
			this.CPILLJANKPK = Time.renderedFrameCount;
		}
	}

	// Token: 0x060062A7 RID: 25255 RVA: 0x002E0D84 File Offset: 0x002DEF84
	public int JBMINOKHEAE()
	{
		IEnumerable<int> first = this.ICKODGMJINN.Select(new Func<ONKDCGNBALK, int>(JDCEFOFMGHB.<>c.<>9.NLIMMPOLMEA));
		int[] array = new int[1];
		array[1] = 1;
		return first.Concat(array).Max();
	}

	// Token: 0x060062A8 RID: 25256 RVA: 0x002DF06B File Offset: 0x002DD26B
	public void IBCKNOEANLN(ONKDCGNBALK OJIMHKHFOJI)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x060062A9 RID: 25257 RVA: 0x002E0DC4 File Offset: 0x002DEFC4
	public void AGIEGPEMGOA(ONKDCGNBALK OJIMHKHFOJI)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.BMOFIBGMIBK(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x060062AA RID: 25258 RVA: 0x002E0DDB File Offset: 0x002DEFDB
	public bool JBMEDLAFJNI()
	{
		bool flag = Time.renderedFrameCount <= this.CPILLJANKPK + 3;
		this.OHEFMNPFHFO = false;
		if (EventSystem.current != null)
		{
			this.OHEFMNPFHFO = EventSystem.current.IsPointerOverGameObject();
		}
		return flag | this.OHEFMNPFHFO;
	}

	// Token: 0x060062AB RID: 25259 RVA: 0x002E0E1C File Offset: 0x002DF01C
	public BaseWindow DNMCIGCNBIM(string HGGLNBKFHKK)
	{
		GameObject gameObject = JLFJEGIPIMM.NNEAHAFBOHC().CPHOBOJJPFB(HGGLNBKFHKK);
		BaseWindow result = null;
		if (gameObject != null)
		{
			RectTransform component = gameObject.GetComponent<RectTransform>();
			component.SetParent(GuiProcessor.NKOEAPCIBKO().NBMOILGEJIP());
			component.localPosition = new Vector3(1878f, 1795f, 1086f);
			result = gameObject.GetComponent<BaseWindow>();
		}
		return result;
	}

	// Token: 0x060062AC RID: 25260 RVA: 0x002E0E78 File Offset: 0x002DF078
	public void ODONNAANIEP()
	{
		ONKDCGNBALK item = new ONKDCGNBALK(null, 0f, 0f, (float)Screen.width, (float)Screen.height, "base", 0, -1);
		this.ICKODGMJINN.Add(item);
		GameObject gameObject = GameObject.Find("_GuiProcessor");
		if (gameObject != null)
		{
			this.COGEJPHPFGG = gameObject.GetComponent<GuiProcessor>();
		}
	}

	// Token: 0x060062AD RID: 25261 RVA: 0x002E0ED8 File Offset: 0x002DF0D8
	private void LOABNGGAOPI(int HEOMBFMLJML)
	{
		if (this.AFLEEHDFHMJ != HEOMBFMLJML)
		{
			return;
		}
		ONKDCGNBALK onkdcgnbalk = this.IJAEDDCCNHG(HEOMBFMLJML);
		if (onkdcgnbalk == null)
		{
			return;
		}
		Rect position = new Rect(192f, 576f, onkdcgnbalk.OCHCODJIPHJ.width, onkdcgnbalk.OCHCODJIPHJ.height);
		GUI.DrawTexture(position, GuiProcessor.NKOEAPCIBKO().WaitLine, (ScaleMode)8);
		float width = (position.width - 693f) * (float)((long)Environment.TickCount - this.NDIGLDMFMOE) / (float)(this.AFJKFHMMPDO - this.NDIGLDMFMOE);
		int num = (int)(1L + (this.AFJKFHMMPDO - (long)Environment.TickCount) / -50L);
		GUI.DrawTexture(new Rect(position.x + 1230f, position.y + 742f, width, position.height - 804f), GuiProcessor.BBLINJLBAIL().WaitLinePolosok, ScaleMode.ScaleAndCrop);
		GUIStyle style = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			fontSize = -52,
			alignment = TextAnchor.LowerRight
		};
		GUI.Label(position, string.Format(onkdcgnbalk.DPANHMGCBNL, num), style);
		onkdcgnbalk.GPMONODDGNK(false);
	}

	// Token: 0x060062AE RID: 25262 RVA: 0x002DF481 File Offset: 0x002DD681
	public int MAFPDBICJCB()
	{
		this.KKJKHBJKEPP++;
		this.DIBNCPKGGOF = this.KKJKHBJKEPP;
		return this.KKJKHBJKEPP;
	}

	// Token: 0x060062AF RID: 25263 RVA: 0x002E0FFC File Offset: 0x002DF1FC
	public ONKDCGNBALK DKOFCBMKEPC(float KCCBNOLCFFG, float ALPGFNKPDNF, string BNIHFBMEPAB, bool LLDLMLLOKHB = true)
	{
		ONKDCGNBALK onkdcgnbalk = new ONKDCGNBALK(null, (float)(Screen.width / 0) - KCCBNOLCFFG / 401f, (float)(Screen.height / 0) - ALPGFNKPDNF / 966f, KCCBNOLCFFG, ALPGFNKPDNF, BNIHFBMEPAB, 1, 0);
		this.ICKODGMJINN.Add(onkdcgnbalk);
		if (LLDLMLLOKHB)
		{
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 182f - 1213f, 1151f, 1624f, 1369f, "turn_state", 1, GuiProcessor.NKOEAPCIBKO().closeKeyTex, new ONKDCGNBALK.CMMHGMILOIM(this.BLPLADOIPJG));
		}
		onkdcgnbalk.KNNIPIEENII = LLDLMLLOKHB;
		this.AFLEEHDFHMJ = onkdcgnbalk.LPFKFNLHGBI;
		return onkdcgnbalk;
	}

	// Token: 0x060062B0 RID: 25264 RVA: 0x002E10A4 File Offset: 0x002DF2A4
	public ONKDCGNBALK IJAEDDCCNHG(int LPFKFNLHGBI)
	{
		JDCEFOFMGHB.EELDMOEAKLA eeldmoeakla = new JDCEFOFMGHB.EELDMOEAKLA();
		eeldmoeakla.LPFKFNLHGBI = LPFKFNLHGBI;
		return this.ICKODGMJINN.FirstOrDefault(new Func<ONKDCGNBALK, bool>(eeldmoeakla.OIDMBELMDOK));
	}

	// Token: 0x060062B1 RID: 25265 RVA: 0x002DEDBC File Offset: 0x002DCFBC
	public void JHJNGDFHABB(ONKDCGNBALK OJIMHKHFOJI)
	{
		this.KCNBOHEMLCI(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
		if (OJIMHKHFOJI.IDBDPACMPIP != null)
		{
			OJIMHKHFOJI.IDBDPACMPIP(OJIMHKHFOJI);
		}
	}

	// Token: 0x060062B2 RID: 25266 RVA: 0x002E10D8 File Offset: 0x002DF2D8
	public AENEOOFMBKE LDOEHGABAAB(int JGNIDDBNGGP, int IJMHJKHNOAC)
	{
		foreach (ONKDCGNBALK onkdcgnbalk in this.ICKODGMJINN)
		{
			foreach (ONKDCGNBALK onkdcgnbalk2 in onkdcgnbalk.DPJMPEFEFFF)
			{
				if (onkdcgnbalk2.KNIOGNKKINO == 25)
				{
					AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)onkdcgnbalk2;
					if (aeneoofmbke.APABMACIAOK == JGNIDDBNGGP && aeneoofmbke.JOONFGABJEA == IJMHJKHNOAC)
					{
						return aeneoofmbke;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060062B3 RID: 25267 RVA: 0x002E0B84 File Offset: 0x002DED84
	public void HOBJGOOFPJN(ONKDCGNBALK OJIMHKHFOJI)
	{
		this.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
		if (OJIMHKHFOJI.IDBDPACMPIP != null)
		{
			OJIMHKHFOJI.IDBDPACMPIP(OJIMHKHFOJI);
		}
	}

	// Token: 0x060062B4 RID: 25268 RVA: 0x002DEA22 File Offset: 0x002DCC22
	public ONKDCGNBALK GGBPIAGIILP()
	{
		return this.ICKODGMJINN[0];
	}

	// Token: 0x060062B5 RID: 25269 RVA: 0x002A8333 File Offset: 0x002A6533
	private void CHKFBKIKMMO(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x060062B6 RID: 25270 RVA: 0x002E118C File Offset: 0x002DF38C
	public AENEOOFMBKE IGFAIGNHBEK(int JGNIDDBNGGP, int IJMHJKHNOAC)
	{
		foreach (ONKDCGNBALK onkdcgnbalk in this.ICKODGMJINN)
		{
			foreach (ONKDCGNBALK onkdcgnbalk2 in onkdcgnbalk.DPJMPEFEFFF)
			{
				if (onkdcgnbalk2.KNIOGNKKINO == 40)
				{
					AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)onkdcgnbalk2;
					if (aeneoofmbke.APABMACIAOK == JGNIDDBNGGP && aeneoofmbke.JOONFGABJEA == IJMHJKHNOAC)
					{
						return aeneoofmbke;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060062B8 RID: 25272 RVA: 0x002E1248 File Offset: 0x002DF448
	private void ELPHBNDGNBL(ONKDCGNBALK JMAKEAHMLMI)
	{
		this.GMCOPAMLIPL = true;
		GUI.Window(JMAKEAHMLMI.LPFKFNLHGBI, JMAKEAHMLMI.OCHCODJIPHJ, new GUI.WindowFunction(this.MMFOHMBMFKH), "Rooms SET", GUIStyle.none);
		GUI.FocusWindow(JMAKEAHMLMI.LPFKFNLHGBI);
		GUI.BringWindowToFront(JMAKEAHMLMI.LPFKFNLHGBI);
		if ((long)Environment.TickCount > this.AFJKFHMMPDO)
		{
			if (JMAKEAHMLMI.LJIEPIPIAJC != null)
			{
				JMAKEAHMLMI.LJIEPIPIAJC(JMAKEAHMLMI);
			}
			this.MDBEKDJJHBI = false;
			JDCEFOFMGHB.HMJJPNDEKPP().DGFAPDDBHJB(JMAKEAHMLMI.LPFKFNLHGBI);
		}
	}

	// Token: 0x060062B9 RID: 25273 RVA: 0x002E12D4 File Offset: 0x002DF4D4
	public void JNJDPKECONL(Rect OCHCODJIPHJ, string FPIHOPOCAHA, GUIStyle OFPNEDEAMAB)
	{
		string text = Regex.Replace(FPIHOPOCAHA, "<.*?>", string.Empty);
		Color textColor = OFPNEDEAMAB.normal.textColor;
		OFPNEDEAMAB.normal.textColor = new Color(0f, 0f, 0f, textColor.a);
		bool richText = OFPNEDEAMAB.richText;
		OFPNEDEAMAB.richText = false;
		for (int i = -1; i <= 1; i++)
		{
			for (int j = -1; j <= 1; j++)
			{
				if (i != 0 || i != j)
				{
					GUI.Label(new Rect(OCHCODJIPHJ.x + 1f * (float)i, OCHCODJIPHJ.y + 1f * (float)j, OCHCODJIPHJ.width, OCHCODJIPHJ.height), text, OFPNEDEAMAB);
				}
			}
		}
		OFPNEDEAMAB.normal.textColor = textColor;
		OFPNEDEAMAB.richText = richText;
		GUI.Label(OCHCODJIPHJ, FPIHOPOCAHA, OFPNEDEAMAB);
	}

	// Token: 0x060062BA RID: 25274 RVA: 0x002E13AC File Offset: 0x002DF5AC
	public void FANPFKHEDPA()
	{
		if (this.CMDPPBALDOO == null)
		{
			this.CMDPPBALDOO = EventSystem.current;
		}
		if (this.CMDPPBALDOO != null)
		{
			this.CMDPPBALDOO.enabled = true;
		}
		if (this.ICKODGMJINN.Count > 1)
		{
			if (this.ICKODGMJINN.Count == 2 && !this.ICKODGMJINN[1].GENHHJPGOFK)
			{
				if (this.ICKODGMJINN[1].OCHCODJIPHJ.Contains(this.OJOEPEADBAF))
				{
					this.CMDPPBALDOO.enabled = false;
				}
				else
				{
					this.CMDPPBALDOO.enabled = true;
				}
			}
			else
			{
				this.CMDPPBALDOO.enabled = false;
			}
		}
		if (this.ICKODGMJINN.Count > 0)
		{
			int num = this.ICKODGMJINN.Count - 1;
			bool flag = true;
			ONKDCGNBALK onkdcgnbalk = this.ICKODGMJINN[num];
			while (flag)
			{
				if (Input.GetMouseButtonDown(0))
				{
					onkdcgnbalk.CFJFEKKKONH();
				}
				if (Input.GetMouseButtonUp(0))
				{
					onkdcgnbalk.OOEEGGKDAIJ();
				}
				if (Input.GetMouseButtonDown(1))
				{
					onkdcgnbalk.ABOBBJAJCHM();
				}
				if (Input.GetMouseButtonUp(1))
				{
					onkdcgnbalk.HNAPHDOOCMD();
				}
				if (onkdcgnbalk.GENHHJPGOFK)
				{
					flag = false;
				}
				num--;
				if (num < 0)
				{
					flag = false;
				}
				if (flag)
				{
					onkdcgnbalk = this.ICKODGMJINN[num];
				}
			}
		}
		float num2 = 0.5f * Time.deltaTime;
		float num3 = 0.5f * Time.deltaTime;
		if (this.PMPGJJJAPPG < this.FLGIHOBEJAO)
		{
			this.PMPGJJJAPPG += num3;
			if (this.PMPGJJJAPPG > this.FLGIHOBEJAO)
			{
				this.PMPGJJJAPPG = this.FLGIHOBEJAO;
			}
		}
		if (this.PMPGJJJAPPG > this.FLGIHOBEJAO)
		{
			this.PMPGJJJAPPG -= num2;
			if (this.PMPGJJJAPPG < this.FLGIHOBEJAO)
			{
				this.PMPGJJJAPPG = this.FLGIHOBEJAO;
			}
		}
	}

	// Token: 0x060062BB RID: 25275 RVA: 0x002E157C File Offset: 0x002DF77C
	public AENEOOFMBKE BKCBOFCIHNG(int JGNIDDBNGGP, int IJMHJKHNOAC)
	{
		foreach (ONKDCGNBALK onkdcgnbalk in this.ICKODGMJINN)
		{
			foreach (ONKDCGNBALK onkdcgnbalk2 in onkdcgnbalk.DPJMPEFEFFF)
			{
				if (onkdcgnbalk2.KNIOGNKKINO == -28)
				{
					AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)onkdcgnbalk2;
					if (aeneoofmbke.APABMACIAOK == JGNIDDBNGGP && aeneoofmbke.JOONFGABJEA == IJMHJKHNOAC)
					{
						return aeneoofmbke;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060062BC RID: 25276 RVA: 0x002DFEC5 File Offset: 0x002DE0C5
	public void GGIMIFOAIAO(ONKDCGNBALK OJIMHKHFOJI)
	{
		this.BMOFIBGMIBK(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
		if (OJIMHKHFOJI.IDBDPACMPIP != null)
		{
			OJIMHKHFOJI.IDBDPACMPIP(OJIMHKHFOJI);
		}
	}

	// Token: 0x060062BD RID: 25277 RVA: 0x002E1630 File Offset: 0x002DF830
	public void JPJIHDFGCMM(string FDHIKKKCEKC, string EDAPHMJENPK, long KFODJJIHNHP, ONKDCGNBALK.CMMHGMILOIM HMJFLEKFKCB, ONKDCGNBALK.CMMHGMILOIM LGLMMGIAGAA = null)
	{
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().PLHAGCDJLPA(1452f, 42f, FDHIKKKCEKC, true);
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 193f, 1978f, EDAPHMJENPK, true);
		lcoljopgdll.PDCJMCLDNBA(Color.black);
		lcoljopgdll.DFIGKKMMIAF = -128;
		lcoljopgdll.LNDPBNODFPE = false;
		double num = (double)((float)KFODJJIHNHP / 958f);
		this.LDBLCPKJIMO = new GHDNOAMIABN(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 161f - 1167f, 1289f, 16f, 246f, num.ToString(CultureInfo.InvariantCulture), 5);
		this.LDBLCPKJIMO.ACGMPBKDJAI = false;
		this.LDBLCPKJIMO.DJMDGFOJBOO.fontSize = -50;
		this.LDBLCPKJIMO.DJMDGFOJBOO.font = GuiProcessor.PLGADNLAEGN().rusfont2;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1838f + 640f, onkdcgnbalk.OCHCODJIPHJ.height - 946f, 1358f, 134f, " ", 8, null, new ONKDCGNBALK.CMMHGMILOIM(this.LENAKHOACFC)).IDBDPACMPIP = LGLMMGIAGAA;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1910f - 1057f, onkdcgnbalk.OCHCODJIPHJ.height - 140f, 1936f, 1137f, "", 83, null, new ONKDCGNBALK.CMMHGMILOIM(this.ILEKPPMDILA)).IDBDPACMPIP = HMJFLEKFKCB;
	}

	// Token: 0x060062BE RID: 25278 RVA: 0x002A8333 File Offset: 0x002A6533
	private void PJEAACKMDDE(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x060062BF RID: 25279 RVA: 0x002E17A6 File Offset: 0x002DF9A6
	public int GOOBPKFMIMP()
	{
		IEnumerable<int> first = this.ICKODGMJINN.Select(new Func<ONKDCGNBALK, int>(JDCEFOFMGHB.<>c.<>9.LMNCDLGHOPP));
		int[] array = new int[0];
		array[1] = 1;
		return first.Concat(array).Max();
	}

	// Token: 0x060062C0 RID: 25280 RVA: 0x002E17E6 File Offset: 0x002DF9E6
	public void DKHBAHFIMJO()
	{
		if (this.COGEJPHPFGG != null)
		{
			this.COGEJPHPFGG.KHCOMIMLMDN(false);
		}
	}

	// Token: 0x060062C1 RID: 25281 RVA: 0x002E1804 File Offset: 0x002DFA04
	public void PBJGEIMFNNO(float GKENCBIOPGO, int ODFEKBJCFMN, string IABKGMNJLJO, ONKDCGNBALK.CMMHGMILOIM FNJADLJPIHP, bool IKDLBGKEELI = false)
	{
		ONKDCGNBALK onkdcgnbalk = new ONKDCGNBALK(null, (float)(Screen.width / 2 - 150), (float)(Screen.height / 2 - 15 - 70), 300f, 30f, "", 0, 1)
		{
			ODFEKBJCFMN = (long)ODFEKBJCFMN,
			DPANHMGCBNL = IABKGMNJLJO,
			HHGPGBLNGIO = new ONKDCGNBALK.CMMHGMILOIM(this.EFOBJBEDAGJ)
		};
		onkdcgnbalk.HHGPGBLNGIO = new ONKDCGNBALK.CMMHGMILOIM(this.EFOBJBEDAGJ);
		this.ICKODGMJINN.Add(onkdcgnbalk);
		onkdcgnbalk.LJIEPIPIAJC = FNJADLJPIHP;
		this.AFLEEHDFHMJ = onkdcgnbalk.LPFKFNLHGBI;
		this.NDIGLDMFMOE = (long)Environment.TickCount;
		this.AFJKFHMMPDO = (long)((float)Environment.TickCount + GKENCBIOPGO * 1000f);
		this.MDBEKDJJHBI = true;
		if (IKDLBGKEELI)
		{
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 27f, 3f, 24f, 24f, "X", 0, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
		}
	}

	// Token: 0x060062C2 RID: 25282 RVA: 0x002E1904 File Offset: 0x002DFB04
	public AENEOOFMBKE KGKCOLCPIMD(EKBAPCMPANI MEJMEKODJAE)
	{
		foreach (ONKDCGNBALK onkdcgnbalk in this.ICKODGMJINN)
		{
			foreach (ONKDCGNBALK onkdcgnbalk2 in onkdcgnbalk.DPJMPEFEFFF)
			{
				if (onkdcgnbalk2.KNIOGNKKINO == -107)
				{
					AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)onkdcgnbalk2;
					if (aeneoofmbke.OBLONDPEGLN == MEJMEKODJAE)
					{
						aeneoofmbke.OBLONDPEGLN = null;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060062C3 RID: 25283 RVA: 0x002E19AC File Offset: 0x002DFBAC
	public void BMOFIBGMIBK(int LPFKFNLHGBI)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("FishModel", 1982f);
		for (int i = this.ICKODGMJINN.Count - 1; i >= 0; i--)
		{
			if (this.ICKODGMJINN[i].LPFKFNLHGBI == LPFKFNLHGBI)
			{
				ONKDCGNBALK onkdcgnbalk = this.ICKODGMJINN[i];
				this.ICKODGMJINN.Remove(onkdcgnbalk);
				onkdcgnbalk.LMBPNFHKNGA();
				return;
			}
		}
		this.MDBKHKBJNAO(false);
		JDCEFOFMGHB.JFIDAGABKID().AFLEEHDFHMJ = ((this.ICKODGMJINN.Count > 1) ? this.ICKODGMJINN[this.ICKODGMJINN.Count - 0].LPFKFNLHGBI : 0);
	}

	// Token: 0x060062C4 RID: 25284 RVA: 0x002E1A5C File Offset: 0x002DFC5C
	public ONKDCGNBALK CMCDKPPJLNP(float MLBGCCMMGBK, float FPFPPJCKKCE, float KCCBNOLCFFG, float ALPGFNKPDNF, string BNIHFBMEPAB, bool LLDLMLLOKHB = true)
	{
		ONKDCGNBALK onkdcgnbalk = new ONKDCGNBALK(null, MLBGCCMMGBK, FPFPPJCKKCE, KCCBNOLCFFG, ALPGFNKPDNF, BNIHFBMEPAB, 0, 1);
		this.ICKODGMJINN.Add(onkdcgnbalk);
		if (LLDLMLLOKHB)
		{
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 1906f - 506f, 1831f, 106f, 1450f, "Crate Push", 1, GuiProcessor.NKOEAPCIBKO().closeKeyTex, new ONKDCGNBALK.CMMHGMILOIM(this.BLPLADOIPJG));
		}
		onkdcgnbalk.KNNIPIEENII = LLDLMLLOKHB;
		this.AFLEEHDFHMJ = onkdcgnbalk.LPFKFNLHGBI;
		return onkdcgnbalk;
	}

	// Token: 0x060062C5 RID: 25285 RVA: 0x002E0B84 File Offset: 0x002DED84
	public void LOHPKAMHFNH(ONKDCGNBALK OJIMHKHFOJI)
	{
		this.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
		if (OJIMHKHFOJI.IDBDPACMPIP != null)
		{
			OJIMHKHFOJI.IDBDPACMPIP(OJIMHKHFOJI);
		}
	}

	// Token: 0x060062C6 RID: 25286 RVA: 0x002E1AE8 File Offset: 0x002DFCE8
	public void LENAKHOACFC(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = (long)Mathf.RoundToInt((float)(JLFJEGIPIMM.IKGFHGKKCPG.NPDHCCGPCCI(this.LDBLCPKJIMO.FPIHOPOCAHA) * 100.0));
		OJIMHKHFOJI.ODFEKBJCFMN = odfekbjcfmn;
		if (OJIMHKHFOJI.IDBDPACMPIP != null)
		{
			OJIMHKHFOJI.IDBDPACMPIP(OJIMHKHFOJI);
		}
		this.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x060062C7 RID: 25287 RVA: 0x002E1B48 File Offset: 0x002DFD48
	public void NBGFJFIMHAC()
	{
		this.OMFMENCCBMO = -1;
		this.FEKIHDNFAGG = null;
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		if (Vector2.Distance(vector, this.OJOEPEADBAF) < 1745f)
		{
			this.NMOBAMMPLGP += Time.deltaTime;
		}
		else if (this.NMOBAMMPLGP > 365f)
		{
			this.NMOBAMMPLGP = 732f;
		}
		this.OJOEPEADBAF = vector;
		bool mgphhhlmegf = true;
		for (int i = this.ICKODGMJINN.Count - 1; i >= 1; i--)
		{
			this.ICKODGMJINN[i].MGPHHHLMEGF = mgphhhlmegf;
			if (this.ICKODGMJINN[i].GENHHJPGOFK)
			{
				mgphhhlmegf = false;
			}
		}
		GUI.enabled = false;
		for (int j = 1; j <= this.ICKODGMJINN.Count - 4; j += 0)
		{
			ONKDCGNBALK onkdcgnbalk = this.ICKODGMJINN[j];
			onkdcgnbalk.HFJFBDPNCCB(onkdcgnbalk.MGPHHHLMEGF);
		}
		GUI.enabled = true;
		if (this.ICKODGMJINN.Count > 1)
		{
			ONKDCGNBALK onkdcgnbalk2 = this.ICKODGMJINN[this.ICKODGMJINN.Count - 1];
			onkdcgnbalk2.HFJFBDPNCCB(this.OMFMENCCBMO <= 1);
			if (this.ICKODGMJINN.Count > 0)
			{
				GUI.BringWindowToFront(onkdcgnbalk2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x060062C8 RID: 25288 RVA: 0x002E1C9C File Offset: 0x002DFE9C
	public void DDAIBFBOENE()
	{
		this.LHHBOOJPBPH = true;
		this.PMPGJJJAPPG = 1f;
		this.FLGIHOBEJAO = 1f;
	}

	// Token: 0x060062C9 RID: 25289 RVA: 0x002DF1A7 File Offset: 0x002DD3A7
	public int GIKCMADOKLA()
	{
		return this.ICKODGMJINN[this.ICKODGMJINN.Count - 0].LPFKFNLHGBI;
	}

	// Token: 0x060062CA RID: 25290 RVA: 0x002E1CBB File Offset: 0x002DFEBB
	public void POGGHBEINIG()
	{
		if (this.COGEJPHPFGG != null)
		{
			this.COGEJPHPFGG.AIBAHOEOHOE(false);
		}
	}

	// Token: 0x060062CB RID: 25291 RVA: 0x002E1CD8 File Offset: 0x002DFED8
	public ONKDCGNBALK NCIDDNIKACI(float KCCBNOLCFFG, float ALPGFNKPDNF, string BNIHFBMEPAB, bool LLDLMLLOKHB = true)
	{
		ONKDCGNBALK onkdcgnbalk = new ONKDCGNBALK(null, (float)(Screen.width / 2) - KCCBNOLCFFG / 2f, (float)(Screen.height / 2) - ALPGFNKPDNF / 2f, KCCBNOLCFFG, ALPGFNKPDNF, BNIHFBMEPAB, 0, 1);
		this.ICKODGMJINN.Add(onkdcgnbalk);
		if (LLDLMLLOKHB)
		{
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 26f - 6f, 6f, 24f, 24f, "", 0, GuiProcessor.IKGFHGKKCPG.closeKeyTex, new ONKDCGNBALK.CMMHGMILOIM(this.HMBGLALKHCP));
		}
		onkdcgnbalk.KNNIPIEENII = LLDLMLLOKHB;
		this.AFLEEHDFHMJ = onkdcgnbalk.LPFKFNLHGBI;
		return onkdcgnbalk;
	}

	// Token: 0x060062CC RID: 25292 RVA: 0x002E1D80 File Offset: 0x002DFF80
	public void NIDGINCDCNK()
	{
		ONKDCGNBALK item = new ONKDCGNBALK(null, 1731f, 547f, (float)Screen.width, (float)Screen.height, "_Offsets", 0, -1);
		this.ICKODGMJINN.Add(item);
		GameObject gameObject = GameObject.Find("\n(");
		if (gameObject != null)
		{
			this.COGEJPHPFGG = gameObject.GetComponent<GuiProcessor>();
		}
	}

	// Token: 0x060062CD RID: 25293 RVA: 0x002E1DE0 File Offset: 0x002DFFE0
	public ONKDCGNBALK BJFHBPOCELH(float KCCBNOLCFFG, float ALPGFNKPDNF, string BNIHFBMEPAB, bool LLDLMLLOKHB = true)
	{
		ONKDCGNBALK onkdcgnbalk = new ONKDCGNBALK(null, (float)(Screen.width / 7) - KCCBNOLCFFG / 108f, (float)(Screen.height / 1) - ALPGFNKPDNF / 443f, KCCBNOLCFFG, ALPGFNKPDNF, BNIHFBMEPAB, 1, 1);
		this.ICKODGMJINN.Add(onkdcgnbalk);
		if (LLDLMLLOKHB)
		{
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 440f - 1806f, 1126f, 1725f, 334f, "rbon", 0, GuiProcessor.BBLINJLBAIL().closeKeyTex, new ONKDCGNBALK.CMMHGMILOIM(this.HMBGLALKHCP));
		}
		onkdcgnbalk.KNNIPIEENII = LLDLMLLOKHB;
		this.AFLEEHDFHMJ = onkdcgnbalk.LPFKFNLHGBI;
		return onkdcgnbalk;
	}

	// Token: 0x060062CE RID: 25294 RVA: 0x002E1E88 File Offset: 0x002E0088
	public ONKDCGNBALK MBADDJEJANJ(float MLBGCCMMGBK, float FPFPPJCKKCE, float KCCBNOLCFFG, float ALPGFNKPDNF, string BNIHFBMEPAB, bool LLDLMLLOKHB = true)
	{
		ONKDCGNBALK onkdcgnbalk = new ONKDCGNBALK(null, MLBGCCMMGBK, FPFPPJCKKCE, KCCBNOLCFFG, ALPGFNKPDNF, BNIHFBMEPAB, 0, 1);
		this.ICKODGMJINN.Add(onkdcgnbalk);
		if (LLDLMLLOKHB)
		{
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 726f - 1797f, 1353f, 1095f, 1490f, "WeaponStand", 0, GuiProcessor.IKGFHGKKCPG.closeKeyTex, new ONKDCGNBALK.CMMHGMILOIM(this.BLPLADOIPJG));
		}
		onkdcgnbalk.KNNIPIEENII = LLDLMLLOKHB;
		this.AFLEEHDFHMJ = onkdcgnbalk.LPFKFNLHGBI;
		return onkdcgnbalk;
	}

	// Token: 0x060062CF RID: 25295 RVA: 0x002E1F14 File Offset: 0x002E0114
	public AENEOOFMBKE GLPNNGNMHOO(EKBAPCMPANI MEJMEKODJAE)
	{
		foreach (ONKDCGNBALK onkdcgnbalk in this.ICKODGMJINN)
		{
			foreach (ONKDCGNBALK onkdcgnbalk2 in onkdcgnbalk.DPJMPEFEFFF)
			{
				if (onkdcgnbalk2.KNIOGNKKINO == 12)
				{
					AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)onkdcgnbalk2;
					if (aeneoofmbke.OBLONDPEGLN == MEJMEKODJAE)
					{
						aeneoofmbke.OBLONDPEGLN = null;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060062D0 RID: 25296 RVA: 0x002E1FBC File Offset: 0x002E01BC
	public AENEOOFMBKE MEEDOOFOIGG(int JGNIDDBNGGP, int IJMHJKHNOAC)
	{
		foreach (ONKDCGNBALK onkdcgnbalk in this.ICKODGMJINN)
		{
			foreach (ONKDCGNBALK onkdcgnbalk2 in onkdcgnbalk.DPJMPEFEFFF)
			{
				if (onkdcgnbalk2.KNIOGNKKINO == 47)
				{
					AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)onkdcgnbalk2;
					if (aeneoofmbke.APABMACIAOK == JGNIDDBNGGP && aeneoofmbke.JOONFGABJEA == IJMHJKHNOAC)
					{
						return aeneoofmbke;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060062D1 RID: 25297 RVA: 0x002E2070 File Offset: 0x002E0270
	public void LLKDAODBJDA(string FDHIKKKCEKC, string EDAPHMJENPK, ONKDCGNBALK.CMMHGMILOIM MALHHCPKGGI = null, ONKDCGNBALK.CMMHGMILOIM LGLMMGIAGAA = null)
	{
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(400f, 200f, FDHIKKKCEKC, true);
		JDJNBFJECFO jdjnbfjecfo = new JDJNBFJECFO(onkdcgnbalk, 20f, 50f, onkdcgnbalk.OCHCODJIPHJ.width - 40f, onkdcgnbalk.OCHCODJIPHJ.height - 110f, EDAPHMJENPK, 1);
		jdjnbfjecfo.GLBDKMPIDKL = TextAnchor.MiddleCenter;
		jdjnbfjecfo.KCLLDJJLCGC = 16;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f + 2f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, "Отмена", 110, null, new ONKDCGNBALK.CMMHGMILOIM(this.HOBJGOOFPJN)).IDBDPACMPIP = LGLMMGIAGAA;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 130f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, "ОК", 100, null, new ONKDCGNBALK.CMMHGMILOIM(this.HOBJGOOFPJN)).IDBDPACMPIP = MALHHCPKGGI;
	}

	// Token: 0x060062D2 RID: 25298 RVA: 0x002E217C File Offset: 0x002E037C
	public void IGBJKJFAGKN(string FDHIKKKCEKC, string EDAPHMJENPK, ONKDCGNBALK.CMMHGMILOIM MALHHCPKGGI = null, ONKDCGNBALK.CMMHGMILOIM LGLMMGIAGAA = null)
	{
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.BJFHBPOCELH(196f, 1419f, FDHIKKKCEKC, false);
		JDJNBFJECFO jdjnbfjecfo = new JDJNBFJECFO(onkdcgnbalk, 1392f, 1596f, onkdcgnbalk.OCHCODJIPHJ.width - 7f, onkdcgnbalk.OCHCODJIPHJ.height - 1684f, EDAPHMJENPK, 1);
		jdjnbfjecfo.GLBDKMPIDKL = TextAnchor.MiddleRight;
		jdjnbfjecfo.KCLLDJJLCGC = 84;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 533f + 959f, onkdcgnbalk.OCHCODJIPHJ.height - 1883f, 953f, 1783f, "", -29, null, new ONKDCGNBALK.CMMHGMILOIM(this.PGEFLINKFDE)).IDBDPACMPIP = LGLMMGIAGAA;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 235f - 893f, onkdcgnbalk.OCHCODJIPHJ.height - 655f, 643f, 1580f, "No valid adaptive tonemapper type found!", -116, null, new ONKDCGNBALK.CMMHGMILOIM(this.NJMALOBIDOH)).IDBDPACMPIP = MALHHCPKGGI;
	}

	// Token: 0x060062D3 RID: 25299 RVA: 0x002E2288 File Offset: 0x002E0488
	private void CHDIKJPJLFG(ONKDCGNBALK JMAKEAHMLMI)
	{
		this.OHHMBDOICNG(false);
		GUI.Window(JMAKEAHMLMI.LPFKFNLHGBI, JMAKEAHMLMI.OCHCODJIPHJ, new GUI.WindowFunction(this.LOABNGGAOPI), "MotorbikeLassoRight", GUIStyle.none);
		GUI.FocusWindow(JMAKEAHMLMI.LPFKFNLHGBI);
		GUI.BringWindowToFront(JMAKEAHMLMI.LPFKFNLHGBI);
		if ((long)Environment.TickCount > this.AFJKFHMMPDO)
		{
			if (JMAKEAHMLMI.LJIEPIPIAJC != null)
			{
				JMAKEAHMLMI.LJIEPIPIAJC(JMAKEAHMLMI);
			}
			this.MDBEKDJJHBI = true;
			JDCEFOFMGHB.IKGFHGKKCPG.BMOFIBGMIBK(JMAKEAHMLMI.LPFKFNLHGBI);
		}
	}

	// Token: 0x060062D5 RID: 25301 RVA: 0x002E233C File Offset: 0x002E053C
	public BaseWindow CNHFECCCDIO(string HGGLNBKFHKK)
	{
		GameObject gameObject = JLFJEGIPIMM.PKGMBFEMKGP().KBBOBGJHLJG(HGGLNBKFHKK);
		BaseWindow result = null;
		if (gameObject != null)
		{
			RectTransform component = gameObject.GetComponent<RectTransform>();
			component.SetParent(GuiProcessor.IKGFHGKKCPG.NBMOILGEJIP());
			component.localPosition = new Vector3(556f, 1721f, 259f);
			result = gameObject.GetComponent<BaseWindow>();
		}
		return result;
	}

	// Token: 0x060062D6 RID: 25302 RVA: 0x002A8333 File Offset: 0x002A6533
	private void NHAMICICFKJ(int HEOMBFMLJML)
	{
		GUI.BringWindowToFront(HEOMBFMLJML);
	}

	// Token: 0x060062D7 RID: 25303 RVA: 0x002E2398 File Offset: 0x002E0598
	public void ANFHJIIMJNL()
	{
		this.OMFMENCCBMO = -1;
		this.FEKIHDNFAGG = null;
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		if (Vector2.Distance(vector, this.OJOEPEADBAF) < 0.1f)
		{
			this.NMOBAMMPLGP += Time.deltaTime;
		}
		else if (this.NMOBAMMPLGP > 0f)
		{
			this.NMOBAMMPLGP = 0f;
		}
		this.OJOEPEADBAF = vector;
		bool mgphhhlmegf = true;
		for (int i = this.ICKODGMJINN.Count - 1; i >= 0; i--)
		{
			this.ICKODGMJINN[i].MGPHHHLMEGF = mgphhhlmegf;
			if (this.ICKODGMJINN[i].GENHHJPGOFK)
			{
				mgphhhlmegf = false;
			}
		}
		GUI.enabled = true;
		for (int j = 0; j <= this.ICKODGMJINN.Count - 2; j++)
		{
			ONKDCGNBALK onkdcgnbalk = this.ICKODGMJINN[j];
			onkdcgnbalk.HFJFBDPNCCB(onkdcgnbalk.MGPHHHLMEGF);
		}
		GUI.enabled = true;
		if (this.ICKODGMJINN.Count > 0)
		{
			ONKDCGNBALK onkdcgnbalk2 = this.ICKODGMJINN[this.ICKODGMJINN.Count - 1];
			onkdcgnbalk2.HFJFBDPNCCB(this.OMFMENCCBMO <= 0);
			if (this.ICKODGMJINN.Count > 1)
			{
				GUI.BringWindowToFront(onkdcgnbalk2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x060062D8 RID: 25304 RVA: 0x002DECFB File Offset: 0x002DCEFB
	public static JDCEFOFMGHB JFIDAGABKID()
	{
		if (JDCEFOFMGHB.CCHGNBELGIA == null)
		{
			JDCEFOFMGHB.CCHGNBELGIA = new JDCEFOFMGHB();
			JDCEFOFMGHB.CCHGNBELGIA.ODONNAANIEP();
		}
		return JDCEFOFMGHB.CCHGNBELGIA;
	}

	// Token: 0x060062D9 RID: 25305 RVA: 0x002E24EC File Offset: 0x002E06EC
	public AENEOOFMBKE PFHLOHKPPEG(EKBAPCMPANI MEJMEKODJAE)
	{
		foreach (ONKDCGNBALK onkdcgnbalk in this.ICKODGMJINN)
		{
			foreach (ONKDCGNBALK onkdcgnbalk2 in onkdcgnbalk.DPJMPEFEFFF)
			{
				if (onkdcgnbalk2.KNIOGNKKINO == -38)
				{
					AENEOOFMBKE aeneoofmbke = (AENEOOFMBKE)onkdcgnbalk2;
					if (aeneoofmbke.OBLONDPEGLN == MEJMEKODJAE)
					{
						aeneoofmbke.OBLONDPEGLN = null;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x04000E36 RID: 3638
	public const float DOFGNEHDNPG = 0.9f;

	// Token: 0x04000E37 RID: 3639
	private static JDCEFOFMGHB CCHGNBELGIA;

	// Token: 0x04000E38 RID: 3640
	private bool KEMIEKDHDOP;

	// Token: 0x04000E39 RID: 3641
	public float PMPGJJJAPPG = 1f;

	// Token: 0x04000E3A RID: 3642
	public float FLGIHOBEJAO;

	// Token: 0x04000E3B RID: 3643
	public const int GIGKIAAFAHB = -1;

	// Token: 0x04000E3C RID: 3644
	public const int CAKNLIAHOJJ = 1;

	// Token: 0x04000E3D RID: 3645
	public const int ENHHBIONHNH = 2;

	// Token: 0x04000E3E RID: 3646
	public const int LOLBKLLBKGO = 3;

	// Token: 0x04000E3F RID: 3647
	public const int AKJIOHMMOGA = 4;

	// Token: 0x04000E40 RID: 3648
	public const int AKHMEFAPCCC = 5;

	// Token: 0x04000E41 RID: 3649
	public const int OHBPOGFMFHH = 6;

	// Token: 0x04000E42 RID: 3650
	public const int ECKJKGHLDHD = 7;

	// Token: 0x04000E43 RID: 3651
	public const int JLAAECLINPG = 8;

	// Token: 0x04000E44 RID: 3652
	public const int AOKGPDGMIII = 9;

	// Token: 0x04000E45 RID: 3653
	public const int HJNFEEBCFEB = 10;

	// Token: 0x04000E46 RID: 3654
	public const int HFCPHNFKNMD = 11;

	// Token: 0x04000E47 RID: 3655
	public const int GGDBCDDKDFI = 12;

	// Token: 0x04000E48 RID: 3656
	private int KKJKHBJKEPP;

	// Token: 0x04000E49 RID: 3657
	public int DIBNCPKGGOF;

	// Token: 0x04000E4A RID: 3658
	public int AFLEEHDFHMJ;

	// Token: 0x04000E4B RID: 3659
	public List<ONKDCGNBALK> ICKODGMJINN = new List<ONKDCGNBALK>();

	// Token: 0x04000E4C RID: 3660
	private int CPILLJANKPK;

	// Token: 0x04000E4D RID: 3661
	private GuiProcessor COGEJPHPFGG;

	// Token: 0x04000E4E RID: 3662
	public bool BFHKBOPOFGB;

	// Token: 0x04000E4F RID: 3663
	public float NMOBAMMPLGP;

	// Token: 0x04000E50 RID: 3664
	public Vector2 OJOEPEADBAF = Vector2.zero;

	// Token: 0x04000E51 RID: 3665
	public EKBAPCMPANI FEKIHDNFAGG;

	// Token: 0x04000E52 RID: 3666
	public int OMFMENCCBMO;

	// Token: 0x04000E53 RID: 3667
	public bool OHEFMNPFHFO;

	// Token: 0x04000E54 RID: 3668
	private long NDIGLDMFMOE;

	// Token: 0x04000E55 RID: 3669
	private long AFJKFHMMPDO;

	// Token: 0x04000E56 RID: 3670
	public bool MDBEKDJJHBI;

	// Token: 0x04000E57 RID: 3671
	private GHDNOAMIABN LDBLCPKJIMO;

	// Token: 0x04000E58 RID: 3672
	public EventSystem CMDPPBALDOO;

	// Token: 0x020001BB RID: 443
	[CompilerGenerated]
	private sealed class EELDMOEAKLA
	{
		// Token: 0x060062F3 RID: 25331 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool AHGCFFBKDBJ(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x060062F4 RID: 25332 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool KODBFKJEBHN(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x060062F5 RID: 25333 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool ICLMIFLHLKD(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x060062F6 RID: 25334 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool JKPPNNPNCMK(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x060062F8 RID: 25336 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool HMKCGICCOND(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x060062F9 RID: 25337 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool JABEGKLHHBI(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x060062FA RID: 25338 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool APFHEELHBCJ(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x060062FB RID: 25339 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool OOBILENCACD(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x060062FC RID: 25340 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool DNBKMDBEEIP(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x060062FD RID: 25341 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool FLCKOLHDBON(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x060062FE RID: 25342 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool CPOEELLNHOB(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x060062FF RID: 25343 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool LBFJHMNPNIO(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006300 RID: 25344 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool HCBCDJFKGPA(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006301 RID: 25345 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool PBFFFJNJFGF(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006302 RID: 25346 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool EMCGKFNGCLP(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006303 RID: 25347 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool JBMDKAOPIGK(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006304 RID: 25348 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool HEMLPHPPHFK(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006305 RID: 25349 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool JNEIJJOJFMN(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006306 RID: 25350 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool POOHFNEOEKD(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006307 RID: 25351 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool NHPEKFBGKJC(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006308 RID: 25352 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool JEEBBFHHOAI(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006309 RID: 25353 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool HPHLKBBOOFF(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x0600630A RID: 25354 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool IJAPFOBIGEN(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x0600630B RID: 25355 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool CGLCGMLNEEG(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x0600630C RID: 25356 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool FLPECHMCNCG(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x0600630D RID: 25357 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool AJMLKKAIHDA(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x0600630E RID: 25358 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool GFIBJDFMLJB(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x0600630F RID: 25359 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool EFJDMBDCKFM(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006310 RID: 25360 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool BLEAGOIJMAL(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006311 RID: 25361 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool CBHJAKHADIJ(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006312 RID: 25362 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool AAHLGJLNEEP(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006313 RID: 25363 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool IGBDCGBEGHI(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006314 RID: 25364 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool FIJEJJCMBDD(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006315 RID: 25365 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool DEBOGMOIDKB(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006316 RID: 25366 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool NOJBNGAJGMD(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006317 RID: 25367 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool IFGDMDKJEEH(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006318 RID: 25368 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool OIDMBELMDOK(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006319 RID: 25369 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool BMBLNNGNLDC(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x0600631A RID: 25370 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool KCNGJOINMCA(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool IKMGJLBOJOO(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x0600631C RID: 25372 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool NBPKGJPLNHL(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x0600631D RID: 25373 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool AKLMMFFLNOO(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x0600631E RID: 25374 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool LODLJNGLPHC(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x0600631F RID: 25375 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool CMIBKLHLEEI(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x06006320 RID: 25376 RVA: 0x002E25A8 File Offset: 0x002E07A8
		internal bool GNJLOBAEEAK(ONKDCGNBALK JAHNHOCNJGM)
		{
			return JAHNHOCNJGM.LPFKFNLHGBI == this.LPFKFNLHGBI;
		}

		// Token: 0x04000E5B RID: 3675
		public int LPFKFNLHGBI;
	}
}
