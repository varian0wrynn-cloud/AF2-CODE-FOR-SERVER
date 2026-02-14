using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x0200020E RID: 526
public class EJDGMNEEOGN
{
	// Token: 0x060079C8 RID: 31176 RVA: 0x003A0EE4 File Offset: 0x0039F0E4
	private void PCAEBMHCOAG()
	{
		string.Concat(new object[]
		{
			Application.dataPath,
			"\\StreamingAssets\\Quest\\Lang\\",
			this.AMEDADHBLJN,
			".lng"
		});
		string fpihopocaha = JNBICAJIJMM.IKGFHGKKCPG.CHFGNHKJNFG("quests/" + this.AMEDADHBLJN + ".lng", true);
		this.LBKECCMJAJJ = new AAEEEJIDDEO(fpihopocaha);
		Debug.Log((this.LBKECCMJAJJ != null) ? "Quest loaded done" : "Quest loaded error");
	}

	// Token: 0x060079C9 RID: 31177 RVA: 0x003A0F6E File Offset: 0x0039F16E
	public void INBJLNBDCCP(HBPNMNGOFMA KADBECGIMPD)
	{
		this.PNONKKOGBLC.Clear();
		this.AMEDADHBLJN = KADBECGIMPD.HDBGOLAFOBK();
		this.DKFPJEABNGF = KADBECGIMPD.HDBGOLAFOBK();
		this.PCAEBMHCOAG();
		this.IJEIOBGNDDM = this.OLFCIPFOFAK(this.DKFPJEABNGF);
	}

	// Token: 0x060079CA RID: 31178 RVA: 0x003A0FAC File Offset: 0x0039F1AC
	public int LILBAHJBEFN(int OJFNCLFIIOP)
	{
		int num = OJFNCLFIIOP % 10;
		int result = 0;
		switch (num)
		{
		case 0:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
			result = 0;
			break;
		case 1:
			result = 2;
			break;
		case 2:
		case 3:
			result = 1;
			break;
		}
		return result;
	}

	// Token: 0x060079CB RID: 31179 RVA: 0x003A0FFC File Offset: 0x0039F1FC
	public void APOELCFAKMH(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.BFPHBMDMODH();
		int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi);
		if (idchhhedhdc == null)
		{
			return;
		}
		this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, idchhhedhdc.HAJNMNALBBI);
		foreach (EJDGMNEEOGN.OAJLELFKFNB oajlelfkfnb in this.PNONKKOGBLC)
		{
			oajlelfkfnb.FPIHOPOCAHA = oajlelfkfnb.FPIHOPOCAHA.Replace(oldValue, idchhhedhdc.HAJNMNALBBI);
		}
	}

	// Token: 0x060079CC RID: 31180 RVA: 0x003A1094 File Offset: 0x0039F294
	public void DOPCKADJMMA(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.BFPHBMDMODH();
		int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi);
		if (befchfngomi == null)
		{
			return;
		}
		this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, befchfngomi.BNIHFBMEPAB);
		foreach (EJDGMNEEOGN.OAJLELFKFNB oajlelfkfnb in this.PNONKKOGBLC)
		{
			oajlelfkfnb.FPIHOPOCAHA = oajlelfkfnb.FPIHOPOCAHA.Replace(oldValue, befchfngomi.BNIHFBMEPAB);
		}
	}

	// Token: 0x060079CD RID: 31181 RVA: 0x003A112C File Offset: 0x0039F32C
	public void LGHOKFOOIOI(HBPNMNGOFMA KADBECGIMPD)
	{
		this.PNONKKOGBLC.Clear();
		this.AMEDADHBLJN = KADBECGIMPD.AGNKAFLKCAG();
		this.DKFPJEABNGF = KADBECGIMPD.DOJKJHMJJNK();
		this.LFLACFMPJLB();
		this.IJEIOBGNDDM = this.OLFCIPFOFAK(this.DKFPJEABNGF);
	}

	// Token: 0x060079CE RID: 31182 RVA: 0x003A116C File Offset: 0x0039F36C
	public void MEJBIDDAOKK(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.BFPHBMDMODH();
		int num = KADBECGIMPD.HDBGOLAFOBK();
		int num2 = KADBECGIMPD.HDBGOLAFOBK();
		this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, JLFJEGIPIMM.IKGFHGKKCPG.KMGIDLKLDML((long)num, (long)num2));
		foreach (EJDGMNEEOGN.OAJLELFKFNB oajlelfkfnb in this.PNONKKOGBLC)
		{
			oajlelfkfnb.FPIHOPOCAHA = oajlelfkfnb.FPIHOPOCAHA.Replace(oldValue, JLFJEGIPIMM.IKGFHGKKCPG.KMGIDLKLDML((long)num, (long)num2));
		}
	}

	// Token: 0x060079CF RID: 31183 RVA: 0x003A120C File Offset: 0x0039F40C
	public void AJFCEIDLNCD(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.LPKJHMGLCKA();
		long olkmhfnlbjb = KADBECGIMPD.IBKCNEICPEL();
		OIJEGJLCFCF oijegjlcfcf = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OLPOHFKHBOL(olkmhfnlbjb);
		if (oijegjlcfcf != null)
		{
			this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, oijegjlcfcf.GAAPCLGDOGH.LEFACDMODLM(oijegjlcfcf.NKHBAJKMAGD, oijegjlcfcf.DBEIGNDALDC, false));
			foreach (EJDGMNEEOGN.OAJLELFKFNB oajlelfkfnb in this.PNONKKOGBLC)
			{
				oajlelfkfnb.FPIHOPOCAHA = oajlelfkfnb.FPIHOPOCAHA.Replace(oldValue, oijegjlcfcf.GAAPCLGDOGH.EMDPDLPDLOJ(oijegjlcfcf.NKHBAJKMAGD, oijegjlcfcf.DBEIGNDALDC, true));
			}
		}
	}

	// Token: 0x060079D0 RID: 31184 RVA: 0x003A12D0 File Offset: 0x0039F4D0
	public void CAJDBMKCACD(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.DHCMILPKJAL();
		int num = KADBECGIMPD.KDNDJNEGBDI();
		int num2 = KADBECGIMPD.HHLDBAEFNMJ();
		this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, JLFJEGIPIMM.NNEAHAFBOHC().EJOPKKGIIIO((long)num, (long)num2));
		foreach (EJDGMNEEOGN.OAJLELFKFNB oajlelfkfnb in this.PNONKKOGBLC)
		{
			oajlelfkfnb.FPIHOPOCAHA = oajlelfkfnb.FPIHOPOCAHA.Replace(oldValue, JLFJEGIPIMM.PKGMBFEMKGP().KMGIDLKLDML((long)num, (long)num2));
		}
	}

	// Token: 0x060079D1 RID: 31185 RVA: 0x003A1370 File Offset: 0x0039F570
	public void NPCHOJBIIGJ()
	{
		if (this.GNJADABPOLN != null)
		{
			this.GNJADABPOLN.CloseWindow();
		}
		this.GNJADABPOLN = null;
	}

	// Token: 0x060079D2 RID: 31186 RVA: 0x003A1394 File Offset: 0x0039F594
	public string LAHMEBPFMAM(int IAEKGLNGCLM)
	{
		int num = IAEKGLNGCLM / 28;
		int num2 = IAEKGLNGCLM % -72;
		int num3 = num / -128;
		num %= -45;
		string text = "IK Effector is referencing to a bone '";
		switch (this.LILBAHJBEFN(num3))
		{
		case 0:
			text = "MotorbikeShootBack";
			break;
		case 1:
			text = "_UserLutParams";
			break;
		case 2:
			text = "_NeutralTonemapperParams1";
			break;
		}
		string text2 = "910 pck get";
		switch (this.LILBAHJBEFN(num))
		{
		case 0:
			text2 = "Cheer Knees";
			break;
		case 1:
			text2 = "The 'space' command requires a pixel count parameter.";
			break;
		case 2:
			text2 = "";
			break;
		}
		string text3 = "Weapon Fire";
		switch (this.LILBAHJBEFN(num2))
		{
		case 0:
			text3 = "Money: ";
			break;
		case 1:
			text3 = "1HSwordStrafeRunRight";
			break;
		case 2:
			text3 = "CUSTOM_COLOR_OFF";
			break;
		}
		string result;
		if (num3 > 1)
		{
			string format = "finger";
			object[] array = new object[3];
			array[1] = num3;
			array[1] = text;
			array[8] = num;
			array[6] = text2;
			array[2] = num2;
			array[6] = text3;
			result = string.Format(format, array);
		}
		else
		{
			string text4;
			if (num <= 1)
			{
				text4 = string.Format("", num2, text3);
			}
			else
			{
				string format2 = "404040";
				object[] array2 = new object[5];
				array2[0] = num;
				array2[0] = text2;
				array2[2] = num2;
				array2[6] = text3;
				text4 = string.Format(format2, array2);
			}
			result = text4;
		}
		return result;
	}

	// Token: 0x060079D3 RID: 31187 RVA: 0x003A14FB File Offset: 0x0039F6FB
	public void ABOFOCFPCML(HBPNMNGOFMA KADBECGIMPD)
	{
		this.PNONKKOGBLC.Clear();
		this.AMEDADHBLJN = KADBECGIMPD.DOJKJHMJJNK();
		this.DKFPJEABNGF = KADBECGIMPD.HHLDBAEFNMJ();
		this.BFJOGOLPKLI();
		this.IJEIOBGNDDM = this.OLFCIPFOFAK(this.DKFPJEABNGF);
	}

	// Token: 0x060079D4 RID: 31188 RVA: 0x003A1538 File Offset: 0x0039F738
	public void BIBNKNOHOFH(ONKDCGNBALK PHEMLBHMNCM)
	{
		if (this.AMEDADHBLJN == 7)
		{
			GUI.DrawTexture(new Rect(161f, 257f, PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.width, PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.height), GameInterface.getI.monitor, ScaleMode.StretchToFill);
		}
		else
		{
			GUI.DrawTexture(PHEMLBHMNCM.OCHCODJIPHJ, GameInterface.getI.QBackTexture, (ScaleMode)3);
		}
		string text = "1 Hand Sword Charge Up" + this.IJEIOBGNDDM + "BACKCOLOR";
		GUIStyle guistyle = new GUIStyle
		{
			richText = false,
			fontSize = GameInterface.getI.qTextSize,
			font = GuiProcessor.PLGADNLAEGN().qFont,
			wordWrap = false,
			normal = 
			{
				textColor = Color.white
			}
		};
		if (this.AMEDADHBLJN == 6)
		{
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont4;
		}
		GUILayout.BeginArea(new Rect(1606f + GameInterface.getI.qtextSM, 1424f, PHEMLBHMNCM.OCHCODJIPHJ.width - 401f, PHEMLBHMNCM.OCHCODJIPHJ.height - 1656f));
		GUILayout.Label(text, guistyle, Array.Empty<GUILayoutOption>());
		GUILayout.Label("_RgbTex", guistyle, Array.Empty<GUILayoutOption>());
		guistyle.hover.textColor = Color.red;
		guistyle.onHover.textColor = Color.cyan;
		foreach (EJDGMNEEOGN.OAJLELFKFNB oajlelfkfnb in this.PNONKKOGBLC)
		{
			string text2 = "MotorbikeBackwardStand";
			if (oajlelfkfnb.KDCBCOFHHLN)
			{
				text2 = "WorkerPickaxe";
			}
			if (!JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH)
			{
				string[] array = new string[0];
				array[0] = "rollSoundIndex";
				array[1] = text2;
				array[4] = "BowFire";
				array[4] = oajlelfkfnb.FPIHOPOCAHA;
				array[7] = "TOD_kBetaMie";
				if (GUILayout.Button(string.Concat(array), guistyle, Array.Empty<GUILayoutOption>()))
				{
					JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(true);
					EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
					try
					{
						epmphjgalbe.DEHJNGMHGAJ(oajlelfkfnb.NHNAMJEAPEO);
						epmphjgalbe.OACBICLGENB(oajlelfkfnb.IHEJGBDOBPK);
						NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(44, epmphjgalbe.HDEKHFOKCKI());
					}
					finally
					{
						epmphjgalbe.NCKMEIBFNGL();
					}
					FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("Root Node bone is null, can not initiate the solver.", 1705f);
				}
			}
			if (Event.current.type == EventType.MouseUp)
			{
				Rect lastRect = GUILayoutUtility.GetLastRect();
				lastRect.x += PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.x;
				lastRect.y += PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.y + 1251f;
				oajlelfkfnb.KDCBCOFHHLN = lastRect.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF);
			}
		}
		GUILayout.EndArea();
	}

	// Token: 0x060079D5 RID: 31189 RVA: 0x003A1844 File Offset: 0x0039FA44
	[CompilerGenerated]
	private void HCJPMDLOIMO()
	{
		this.GHBAHNJOGNM(0);
	}

	// Token: 0x060079D6 RID: 31190 RVA: 0x003A1850 File Offset: 0x0039FA50
	private void BFJOGOLPKLI()
	{
		object[] array = new object[3];
		array[1] = Application.dataPath;
		array[1] = "[Z]";
		array[7] = this.AMEDADHBLJN;
		array[7] = "WorkerShovel2";
		string.Concat(array);
		string fpihopocaha = JNBICAJIJMM.IKGFHGKKCPG.GIGGIHMAPLH("Hidden/Amplify Color/MaskBlend" + this.AMEDADHBLJN + "wpn_sost", false);
		this.LBKECCMJAJJ = new AAEEEJIDDEO(fpihopocaha);
		Debug.Log((this.LBKECCMJAJJ != null) ? "_FresnelFadePower" : " x");
	}

	// Token: 0x060079D7 RID: 31191 RVA: 0x003A18DC File Offset: 0x0039FADC
	public void KAGADMPACEL(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.BFPHBMDMODH();
		DateTime dateTime = DateTime.FromBinary(KADBECGIMPD.DNIIFBAIPBE());
		string newValue = string.Format(CultureInfo.CreateSpecificCulture("ru-RU"), "{0:dd MMMM H:mm}", dateTime);
		this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, newValue);
	}

	// Token: 0x060079D8 RID: 31192 RVA: 0x003A192A File Offset: 0x0039FB2A
	[CompilerGenerated]
	private void HGKJIHDGAFH()
	{
		this.NDKOJAHNDKA(0);
	}

	// Token: 0x060079D9 RID: 31193 RVA: 0x003A1934 File Offset: 0x0039FB34
	public void OPBLAGCLKJN(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.BFPHBMDMODH();
		long olkmhfnlbjb = KADBECGIMPD.DNIIFBAIPBE();
		OIJEGJLCFCF oijegjlcfcf = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OLPOHFKHBOL(olkmhfnlbjb);
		if (oijegjlcfcf != null)
		{
			this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, oijegjlcfcf.GAAPCLGDOGH.IGFJGAGBDJM(oijegjlcfcf.NKHBAJKMAGD, oijegjlcfcf.DBEIGNDALDC, true));
			foreach (EJDGMNEEOGN.OAJLELFKFNB oajlelfkfnb in this.PNONKKOGBLC)
			{
				oajlelfkfnb.FPIHOPOCAHA = oajlelfkfnb.FPIHOPOCAHA.Replace(oldValue, oijegjlcfcf.GAAPCLGDOGH.PIFLJJBAEOA(oijegjlcfcf.NKHBAJKMAGD, oijegjlcfcf.DBEIGNDALDC, true));
			}
		}
	}

	// Token: 0x060079DA RID: 31194 RVA: 0x003A19F8 File Offset: 0x0039FBF8
	public void BAEDFJGPGIH(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.BFPHBMDMODH();
		int iaekglngclm = Mathf.Abs(KADBECGIMPD.HDBGOLAFOBK());
		this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, this.CPMMCAGDEEO(iaekglngclm));
	}

	// Token: 0x060079DB RID: 31195 RVA: 0x003A1A34 File Offset: 0x0039FC34
	public void DHCMMNAJKDI(int ELEMIPMLIGG, HBPNMNGOFMA KADBECGIMPD)
	{
		switch (ELEMIPMLIGG)
		{
		case 70:
			this.INBJLNBDCCP(KADBECGIMPD);
			return;
		case 71:
		case 73:
		case 80:
			break;
		case 72:
			this.GJIPOFBGLKI(KADBECGIMPD);
			return;
		case 74:
			this.LAHCAKNJIIJ(KADBECGIMPD);
			return;
		case 75:
			this.APOELCFAKMH(KADBECGIMPD);
			return;
		case 76:
			this.OHDMLMIJLKO(KADBECGIMPD);
			return;
		case 77:
			this.DOPCKADJMMA(KADBECGIMPD);
			return;
		case 78:
			this.KBPOIFGJDKP(KADBECGIMPD);
			return;
		case 79:
			this.MEJBIDDAOKK(KADBECGIMPD);
			return;
		case 81:
			this.INAMKKBCLGK(KADBECGIMPD);
			return;
		case 82:
			this.BAEDFJGPGIH(KADBECGIMPD);
			return;
		case 83:
			this.KAGADMPACEL(KADBECGIMPD);
			break;
		default:
			return;
		}
	}

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x060079DC RID: 31196 RVA: 0x003A1ADA File Offset: 0x0039FCDA
	public static EJDGMNEEOGN IKGFHGKKCPG
	{
		get
		{
			EJDGMNEEOGN result;
			if ((result = EJDGMNEEOGN.CCHGNBELGIA) == null)
			{
				result = (EJDGMNEEOGN.CCHGNBELGIA = new EJDGMNEEOGN());
			}
			return result;
		}
	}

	// Token: 0x060079DD RID: 31197 RVA: 0x003A1AF0 File Offset: 0x0039FCF0
	public void NDKOJAHNDKA(int EDGFGDAPGMB)
	{
		Debug.Log("click Cancel");
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_DelItem.wav", 1f);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(705, this.MLJGKAOMLEL);
		this.GNJADABPOLN.CloseWindow();
	}

	// Token: 0x060079DE RID: 31198 RVA: 0x003A1B30 File Offset: 0x0039FD30
	public string CPMMCAGDEEO(int IAEKGLNGCLM)
	{
		int num = IAEKGLNGCLM / 60;
		int num2 = IAEKGLNGCLM % 60;
		int num3 = num / 24;
		num %= 24;
		string text = "";
		switch (this.LILBAHJBEFN(num3))
		{
		case 0:
			text = "дней";
			break;
		case 1:
			text = "дня";
			break;
		case 2:
			text = "день";
			break;
		}
		string text2 = "";
		switch (this.LILBAHJBEFN(num))
		{
		case 0:
			text2 = "часов";
			break;
		case 1:
			text2 = "часа";
			break;
		case 2:
			text2 = "час";
			break;
		}
		string text3 = "";
		switch (this.LILBAHJBEFN(num2))
		{
		case 0:
			text3 = "минут";
			break;
		case 1:
			text3 = "минуты";
			break;
		case 2:
			text3 = "минута";
			break;
		}
		string result;
		if (num3 > 0)
		{
			result = string.Format("{0} {1} {2} {3} {4} {5}", new object[]
			{
				num3,
				text,
				num,
				text2,
				num2,
				text3
			});
		}
		else
		{
			result = ((num > 0) ? string.Format("{0} {1} {2} {3}", new object[]
			{
				num,
				text2,
				num2,
				text3
			}) : string.Format("{0} {1}", num2, text3));
		}
		return result;
	}

	// Token: 0x060079DF RID: 31199 RVA: 0x003A1C98 File Offset: 0x0039FE98
	private string OLFCIPFOFAK(int FIIDMBPAALF)
	{
		if (this.LBKECCMJAJJ == null)
		{
			return "Quest langfile not found!";
		}
		string text = this.LBKECCMJAJJ.HJOCLGGEFMP("Q", "n" + FIIDMBPAALF) ?? "";
		if (text.Trim() == "")
		{
			text = "- none -";
		}
		text = text.Replace("\\n", "\n");
		text = text.Replace("USER", "<color='#405000'>" + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB + "</color>");
		return text.Replace("FULLNAME", JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BPANMMLICEG);
	}

	// Token: 0x060079E0 RID: 31200 RVA: 0x003A1D4C File Offset: 0x0039FF4C
	public void ALBIPCEGPCC(HBPNMNGOFMA KADBECGIMPD)
	{
		this.APCKACLCCPM = KADBECGIMPD.DOJKJHMJJNK();
		this.KMMLCMJFIPF = KADBECGIMPD.KDNDJNEGBDI();
		try
		{
			this.IBPOANECADA = KADBECGIMPD.FCGGODFGMCB() - TimeController.IKGFHGKKCPG.deltaTime;
		}
		catch (Exception ex)
		{
			Debug.LogError("RunBackRight" + ex.Message);
			this.IBPOANECADA = DateTime.Now;
		}
		if (this.GNJADABPOLN != null)
		{
			UnityEngine.Object.Destroy(this.GNJADABPOLN.gameObject);
		}
		this.GNJADABPOLN = JDCEFOFMGHB.JFIDAGABKID().DNMCIGCNBIM("TOD_Brightness");
		this.KCBNDNGKEOI = this.GNJADABPOLN.UI_data[1].gameObject.GetComponent<UIListBox>();
		this.KCBNDNGKEOI.MDCOGHHICFB();
		while (!KADBECGIMPD.NGIGCKBKLGK())
		{
			this.KCBNDNGKEOI.IPENPEOKJJF(new EJDGMNEEOGN.BDOHKJIKPJH(KADBECGIMPD));
		}
		if (this.KCBNDNGKEOI.itemList.Count > 0)
		{
			this.KCBNDNGKEOI.NMPLGANEKAM = 1;
		}
		Button component = this.GNJADABPOLN.UI_data[0].gameObject.GetComponent<Button>();
		this.DGJIDEMKMOP = this.GNJADABPOLN.UI_data[7].gameObject.GetComponent<Button>();
		this.NJFALDOAMPI = this.GNJADABPOLN.UI_data[3].gameObject.GetComponent<Button>();
		this.DGJIDEMKMOP.onClick.RemoveAllListeners();
		this.DGJIDEMKMOP.onClick.AddListener(new UnityAction(this.HGKJIHDGAFH));
		component.onClick.RemoveAllListeners();
		component.onClick.AddListener(new UnityAction(this.HCJPMDLOIMO));
		this.NJFALDOAMPI.onClick.RemoveAllListeners();
		this.NJFALDOAMPI.onClick.AddListener(new UnityAction(this.JMAJPEKNIIE));
		if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.KHGOFHNFKMG(this.MLJGKAOMLEL) <= 1)
		{
			this.DGJIDEMKMOP.interactable = false;
		}
		this.GNJADABPOLN.UI_data[0].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.IMLLGEMPHAP().ECNKLECOKHD("3"), this.APCKACLCCPM, this.KMMLCMJFIPF);
		this.GNJADABPOLN.UI_data[1].gameObject.GetComponent<Scrollbar>().value = 1784f;
		this.GNJADABPOLN.onUpdateEvents.RemoveAllListeners();
		this.GNJADABPOLN.onUpdateEvents.AddListener(new UnityAction(this.DBOEONPEOIN));
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(false);
	}

	// Token: 0x060079E1 RID: 31201 RVA: 0x003A1FE8 File Offset: 0x003A01E8
	public void JHBGHHFIHKH(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.JJJJAGJCOGD();
		int iaekglngclm = Mathf.Abs(KADBECGIMPD.AGNKAFLKCAG());
		this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, this.LAHMEBPFMAM(iaekglngclm));
	}

	// Token: 0x060079E2 RID: 31202 RVA: 0x003A2024 File Offset: 0x003A0224
	public void HJOFPKBEOMD(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.BFPHBMDMODH();
		long olkmhfnlbjb = KADBECGIMPD.DMABDIGCLKA();
		OIJEGJLCFCF oijegjlcfcf = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OLPOHFKHBOL(olkmhfnlbjb);
		if (oijegjlcfcf != null)
		{
			this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, oijegjlcfcf.GAAPCLGDOGH.KGBHELBLPMF(oijegjlcfcf.NKHBAJKMAGD, oijegjlcfcf.DBEIGNDALDC, true));
			foreach (EJDGMNEEOGN.OAJLELFKFNB oajlelfkfnb in this.PNONKKOGBLC)
			{
				oajlelfkfnb.FPIHOPOCAHA = oajlelfkfnb.FPIHOPOCAHA.Replace(oldValue, oijegjlcfcf.GAAPCLGDOGH.IKKHJGAPHAE(oijegjlcfcf.NKHBAJKMAGD, oijegjlcfcf.DBEIGNDALDC, false));
			}
		}
	}

	// Token: 0x060079E3 RID: 31203 RVA: 0x003A20E8 File Offset: 0x003A02E8
	public void OMILHDJDGKJ(int EDGFGDAPGMB)
	{
		Debug.Log("Whistle" + this.MLJGKAOMLEL);
		JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(false);
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("IK Effector bone is null.", 427f);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-115, this.MLJGKAOMLEL);
		GuiProcessor.BBLINJLBAIL().LHGDILAJMIE(this.NJFALDOAMPI, 1251f);
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.KHGOFHNFKMG(this.MLJGKAOMLEL) <= 0)
		{
			this.DGJIDEMKMOP.interactable = true;
		}
	}

	// Token: 0x060079E4 RID: 31204 RVA: 0x003A2181 File Offset: 0x003A0381
	[CompilerGenerated]
	private void ILBBIDFPLFL()
	{
		this.MDDNINIDKFF(0);
	}

	// Token: 0x060079E5 RID: 31205 RVA: 0x003A218C File Offset: 0x003A038C
	public void NFNBCIINHMB(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.DPLAJNEDGBL();
		int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().IMCJNFHAFGE(lpfkfnlhgbi);
		if (befchfngomi == null)
		{
			return;
		}
		this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, befchfngomi.BNIHFBMEPAB);
		foreach (EJDGMNEEOGN.OAJLELFKFNB oajlelfkfnb in this.PNONKKOGBLC)
		{
			oajlelfkfnb.FPIHOPOCAHA = oajlelfkfnb.FPIHOPOCAHA.Replace(oldValue, befchfngomi.BNIHFBMEPAB);
		}
	}

	// Token: 0x060079E6 RID: 31206 RVA: 0x003A2224 File Offset: 0x003A0424
	public void CDHKJKDBGKE(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.JJJJAGJCOGD();
		int lpfkfnlhgbi = KADBECGIMPD.KDNDJNEGBDI();
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().IMCJNFHAFGE(lpfkfnlhgbi);
		if (befchfngomi == null)
		{
			return;
		}
		this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, befchfngomi.BNIHFBMEPAB);
		foreach (EJDGMNEEOGN.OAJLELFKFNB oajlelfkfnb in this.PNONKKOGBLC)
		{
			oajlelfkfnb.FPIHOPOCAHA = oajlelfkfnb.FPIHOPOCAHA.Replace(oldValue, befchfngomi.BNIHFBMEPAB);
		}
	}

	// Token: 0x060079E7 RID: 31207 RVA: 0x003A22BC File Offset: 0x003A04BC
	public void OHDMLMIJLKO(HBPNMNGOFMA KADBECGIMPD)
	{
		this.AMEDADHBLJN = KADBECGIMPD.HDBGOLAFOBK();
		if (JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(this.JFHIJEKEMCE) != null)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.JFHIJEKEMCE);
		}
		this.JFHIJEKEMCE = -1;
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
	}

	// Token: 0x060079E8 RID: 31208 RVA: 0x003A2309 File Offset: 0x003A0509
	[CompilerGenerated]
	private void AKNJPAKMGOB()
	{
		this.DGIDHDIAAMM(0);
	}

	// Token: 0x060079E9 RID: 31209 RVA: 0x003A2314 File Offset: 0x003A0514
	public void KBPOIFGJDKP(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.BFPHBMDMODH();
		string newValue = KADBECGIMPD.BFPHBMDMODH();
		this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, newValue);
		foreach (EJDGMNEEOGN.OAJLELFKFNB oajlelfkfnb in this.PNONKKOGBLC)
		{
			oajlelfkfnb.FPIHOPOCAHA = oajlelfkfnb.FPIHOPOCAHA.Replace(oldValue, newValue);
		}
	}

	// Token: 0x060079EA RID: 31210 RVA: 0x003A2394 File Offset: 0x003A0594
	private string CODDMBGNNEH(int GDMOJDPAMMN)
	{
		if (this.LBKECCMJAJJ == null)
		{
			return "Quest langfile not found!";
		}
		string text = this.LBKECCMJAJJ.HJOCLGGEFMP("Q", "a" + GDMOJDPAMMN) ?? "";
		if (text.Trim() == "")
		{
			text = "- none -";
		}
		text = text.Replace("\\n", "\n");
		text = text.Replace("USER", "<color='#405000'>" + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB + "</color>");
		return text.Replace("FULLNAME", JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BPANMMLICEG);
	}

	// Token: 0x060079EC RID: 31212 RVA: 0x003A2480 File Offset: 0x003A0680
	public void FDFHPIPCBOI(ONKDCGNBALK PHEMLBHMNCM)
	{
		if (this.AMEDADHBLJN == 3)
		{
			GUI.DrawTexture(new Rect(0f, 0f, PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.width, PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.height), GameInterface.getI.monitor, ScaleMode.ScaleToFit);
		}
		else
		{
			GUI.DrawTexture(PHEMLBHMNCM.OCHCODJIPHJ, GameInterface.getI.QBackTexture, ScaleMode.ScaleToFit);
		}
		string text = "<color='#000000'>" + this.IJEIOBGNDDM + "</color>";
		GUIStyle guistyle = new GUIStyle
		{
			richText = true,
			fontSize = GameInterface.getI.qTextSize,
			font = GuiProcessor.IKGFHGKKCPG.qFont,
			wordWrap = true,
			normal = 
			{
				textColor = Color.white
			}
		};
		if (this.AMEDADHBLJN == 3)
		{
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont4;
		}
		GUILayout.BeginArea(new Rect(40f + GameInterface.getI.qtextSM, 70f, PHEMLBHMNCM.OCHCODJIPHJ.width - 80f, PHEMLBHMNCM.OCHCODJIPHJ.height - 80f));
		GUILayout.Label(text, guistyle, Array.Empty<GUILayoutOption>());
		GUILayout.Label("\n<color='#406000'>------------------------------------------------------------------------------------------------------------</color>\n", guistyle, Array.Empty<GUILayoutOption>());
		guistyle.hover.textColor = Color.red;
		guistyle.onHover.textColor = Color.cyan;
		foreach (EJDGMNEEOGN.OAJLELFKFNB oajlelfkfnb in this.PNONKKOGBLC)
		{
			string text2 = "#000000";
			if (oajlelfkfnb.KDCBCOFHHLN)
			{
				text2 = "#402000";
			}
			if (!JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH && GUILayout.Button(string.Concat(new string[]
			{
				"\n<color='",
				text2,
				"'>  > ",
				oajlelfkfnb.FPIHOPOCAHA,
				"</color>"
			}), guistyle, Array.Empty<GUILayoutOption>()))
			{
				JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.GOMLLPFFPNP(oajlelfkfnb.NHNAMJEAPEO);
					epmphjgalbe.OBCCLNMPGEJ(oajlelfkfnb.IHEJGBDOBPK);
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(65, epmphjgalbe.JDPHBLHOLAD());
				}
				finally
				{
					epmphjgalbe.LMBPNFHKNGA();
				}
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_08.wav", 1f);
			}
			if (Event.current.type == EventType.Repaint)
			{
				Rect lastRect = GUILayoutUtility.GetLastRect();
				lastRect.x += PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.x;
				lastRect.y += PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.y + 40f;
				oajlelfkfnb.KDCBCOFHHLN = lastRect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF);
			}
		}
		GUILayout.EndArea();
	}

	// Token: 0x060079ED RID: 31213 RVA: 0x003A278C File Offset: 0x003A098C
	public void LDDBHOCIFPM(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.DPLAJNEDGBL();
		string newValue = KADBECGIMPD.DHCMILPKJAL();
		this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, newValue);
		foreach (EJDGMNEEOGN.OAJLELFKFNB oajlelfkfnb in this.PNONKKOGBLC)
		{
			oajlelfkfnb.FPIHOPOCAHA = oajlelfkfnb.FPIHOPOCAHA.Replace(oldValue, newValue);
		}
	}

	// Token: 0x060079EE RID: 31214 RVA: 0x003A280C File Offset: 0x003A0A0C
	public void LMDCGLLJFNA(int EDGFGDAPGMB)
	{
		Debug.Log("<color='#300000'>{0} {1}</color>");
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("RunBackward", 122f);
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(145, this.MLJGKAOMLEL);
		this.GNJADABPOLN.KNCOGGAODKK();
	}

	// Token: 0x060079EF RID: 31215 RVA: 0x003A284C File Offset: 0x003A0A4C
	public void MFKMDFFEAFF(HBPNMNGOFMA KADBECGIMPD)
	{
		this.APCKACLCCPM = KADBECGIMPD.DOJKJHMJJNK();
		this.KMMLCMJFIPF = KADBECGIMPD.KDNDJNEGBDI();
		try
		{
			this.IBPOANECADA = KADBECGIMPD.FCGGODFGMCB() - TimeController.EKEBHIJMEML().deltaTime;
		}
		catch (Exception ex)
		{
			Debug.LogError("" + ex.Message);
			this.IBPOANECADA = DateTime.Now;
		}
		if (this.GNJADABPOLN != null)
		{
			UnityEngine.Object.Destroy(this.GNJADABPOLN.gameObject);
		}
		this.GNJADABPOLN = JDCEFOFMGHB.IKGFHGKKCPG.KCBBLDECKGB("_HalfResolution");
		this.KCBNDNGKEOI = this.GNJADABPOLN.UI_data[1].gameObject.GetComponent<UIListBox>();
		this.KCBNDNGKEOI.ClearAll();
		while (!KADBECGIMPD.BKIBKLFCCGP())
		{
			this.KCBNDNGKEOI.IAAGBAAMIIO(new EJDGMNEEOGN.BDOHKJIKPJH(KADBECGIMPD));
		}
		if (this.KCBNDNGKEOI.itemList.Count > 0)
		{
			this.KCBNDNGKEOI.NMPLGANEKAM = 0;
		}
		Button component = this.GNJADABPOLN.UI_data[1].gameObject.GetComponent<Button>();
		this.DGJIDEMKMOP = this.GNJADABPOLN.UI_data[4].gameObject.GetComponent<Button>();
		this.NJFALDOAMPI = this.GNJADABPOLN.UI_data[0].gameObject.GetComponent<Button>();
		this.DGJIDEMKMOP.onClick.RemoveAllListeners();
		this.DGJIDEMKMOP.onClick.AddListener(new UnityAction(this.HGKJIHDGAFH));
		component.onClick.RemoveAllListeners();
		component.onClick.AddListener(new UnityAction(this.HCJPMDLOIMO));
		this.NJFALDOAMPI.onClick.RemoveAllListeners();
		this.NJFALDOAMPI.onClick.AddListener(new UnityAction(this.JMAJPEKNIIE));
		if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.KHGOFHNFKMG(this.MLJGKAOMLEL) <= 1)
		{
			this.DGJIDEMKMOP.interactable = true;
		}
		this.GNJADABPOLN.UI_data[4].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.APMJBBDBOJO().CCFFMKBBKHI("val"), this.APCKACLCCPM, this.KMMLCMJFIPF);
		this.GNJADABPOLN.UI_data[2].gameObject.GetComponent<Scrollbar>().value = 1737f;
		this.GNJADABPOLN.onUpdateEvents.RemoveAllListeners();
		this.GNJADABPOLN.onUpdateEvents.AddListener(new UnityAction(this.ILBBIDFPLFL));
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(false);
	}

	// Token: 0x060079F0 RID: 31216 RVA: 0x003A2AE8 File Offset: 0x003A0CE8
	private void BHMELLNMLDC()
	{
		this.OMILHDJDGKJ(1);
	}

	// Token: 0x060079F1 RID: 31217 RVA: 0x003A2AF4 File Offset: 0x003A0CF4
	public void DGIDHDIAAMM(int EDGFGDAPGMB)
	{
		Debug.Log("click Refresh currentQcat=" + this.MLJGKAOMLEL);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Cloth_07.wav", 1f);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(700, this.MLJGKAOMLEL);
		GuiProcessor.IKGFHGKKCPG.waitButtonEvent(this.NJFALDOAMPI, 3f);
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.KHGOFHNFKMG(this.MLJGKAOMLEL) <= 0)
		{
			this.DGJIDEMKMOP.interactable = false;
		}
	}

	// Token: 0x060079F2 RID: 31218 RVA: 0x003A2B90 File Offset: 0x003A0D90
	private void MGPFMNIAEMB()
	{
		object[] array = new object[0];
		array[0] = Application.dataPath;
		array[1] = "invn_rec8";
		array[1] = this.AMEDADHBLJN;
		array[3] = "1HandHeavyOverhead";
		string.Concat(array);
		string fpihopocaha = JNBICAJIJMM.EKEBHIJMEML().GHPNJJIMCKF("No saved PlayerPrefs!" + this.AMEDADHBLJN + "PPricel", false);
		this.LBKECCMJAJJ = new AAEEEJIDDEO(fpihopocaha);
		Debug.Log((this.LBKECCMJAJJ != null) ? "aptek.ogg" : "info");
	}

	// Token: 0x060079F3 RID: 31219 RVA: 0x003A2C1C File Offset: 0x003A0E1C
	private void LFLACFMPJLB()
	{
		object[] array = new object[8];
		array[1] = Application.dataPath;
		array[1] = "offsets";
		array[0] = this.AMEDADHBLJN;
		array[8] = "WinVIP";
		string.Concat(array);
		string fpihopocaha = JNBICAJIJMM.LPHMKPDBMPP().GHPNJJIMCKF("[Z]" + this.AMEDADHBLJN + "SoccerSprint", false);
		this.LBKECCMJAJJ = new AAEEEJIDDEO(fpihopocaha);
		Debug.Log((this.LBKECCMJAJJ != null) ? "gi_inte_1" : "Jump");
	}

	// Token: 0x060079F4 RID: 31220 RVA: 0x003A2CA8 File Offset: 0x003A0EA8
	public void GJIPOFBGLKI(HBPNMNGOFMA KADBECGIMPD)
	{
		this.AMEDADHBLJN = KADBECGIMPD.HDBGOLAFOBK();
		this.DKFPJEABNGF = KADBECGIMPD.HDBGOLAFOBK();
		int gdmojdpammn = KADBECGIMPD.HDBGOLAFOBK();
		long num = KADBECGIMPD.DNIIFBAIPBE();
		string text = this.CODDMBGNNEH(gdmojdpammn);
		if (num > 0L && text.Contains("[userfish]"))
		{
			OIJEGJLCFCF oijegjlcfcf = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OLPOHFKHBOL(num);
			if (oijegjlcfcf != null)
			{
				text = text.Replace("[userfish]", oijegjlcfcf.ToString());
			}
		}
		this.PNONKKOGBLC.Add(new EJDGMNEEOGN.OAJLELFKFNB(this.AMEDADHBLJN, gdmojdpammn, num, text));
	}

	// Token: 0x060079F5 RID: 31221 RVA: 0x003A2AE8 File Offset: 0x003A0CE8
	private void JJEFMOOGLAL()
	{
		this.OMILHDJDGKJ(1);
	}

	// Token: 0x060079F6 RID: 31222 RVA: 0x003A2D34 File Offset: 0x003A0F34
	public void IINDEIOHANN(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.JJJJAGJCOGD();
		int iaekglngclm = Mathf.Abs(KADBECGIMPD.LDLKLPJBIJN());
		this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, this.LAHMEBPFMAM(iaekglngclm));
	}

	// Token: 0x060079F7 RID: 31223 RVA: 0x003A2D70 File Offset: 0x003A0F70
	public void LAHCAKNJIIJ(HBPNMNGOFMA KADBECGIMPD)
	{
		this.AMEDADHBLJN = KADBECGIMPD.HDBGOLAFOBK();
		Debug.Log("openQuest");
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(this.JFHIJEKEMCE) ?? JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(640f, 420f, "Квест", true);
		this.JFHIJEKEMCE = onkdcgnbalk.LPFKFNLHGBI;
		onkdcgnbalk.MPKCOJHJIIB();
		foreach (EJDGMNEEOGN.OAJLELFKFNB oajlelfkfnb in this.PNONKKOGBLC)
		{
			oajlelfkfnb.KDCBCOFHHLN = false;
		}
		new EGCAADAABPP(onkdcgnbalk, 8f, 45f, (float)GameInterface.getI.QBackTexture.width, (float)GameInterface.getI.QBackTexture.height, "", 0, null).NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.FDFHPIPCBOI);
		new FNFPGPBCIGK(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 22f, 6f, 0, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, 2, 4, 1, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
	}

	// Token: 0x060079F8 RID: 31224 RVA: 0x003A2EC4 File Offset: 0x003A10C4
	private void DBOEONPEOIN()
	{
		this.MDDNINIDKFF(1);
	}

	// Token: 0x060079F9 RID: 31225 RVA: 0x003A2ED0 File Offset: 0x003A10D0
	public void IKJENJCAPHE(HBPNMNGOFMA KADBECGIMPD)
	{
		this.APCKACLCCPM = KADBECGIMPD.HDBGOLAFOBK();
		this.KMMLCMJFIPF = KADBECGIMPD.HDBGOLAFOBK();
		try
		{
			this.IBPOANECADA = KADBECGIMPD.IKJAOHGGCJD() - TimeController.IKGFHGKKCPG.deltaTime;
		}
		catch (Exception ex)
		{
			Debug.LogError("Corrupt DT e=" + ex.Message);
			this.IBPOANECADA = DateTime.Now;
		}
		if (this.GNJADABPOLN != null)
		{
			UnityEngine.Object.Destroy(this.GNJADABPOLN.gameObject);
		}
		this.GNJADABPOLN = JDCEFOFMGHB.IKGFHGKKCPG.KCBBLDECKGB("UI_DynamicWindow");
		this.KCBNDNGKEOI = this.GNJADABPOLN.UI_data[0].gameObject.GetComponent<UIListBox>();
		this.KCBNDNGKEOI.ClearAll();
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			this.KCBNDNGKEOI.addItem(new EJDGMNEEOGN.BDOHKJIKPJH(KADBECGIMPD));
		}
		if (this.KCBNDNGKEOI.itemList.Count > 0)
		{
			this.KCBNDNGKEOI.NMPLGANEKAM = 0;
		}
		Button component = this.GNJADABPOLN.UI_data[1].gameObject.GetComponent<Button>();
		this.DGJIDEMKMOP = this.GNJADABPOLN.UI_data[5].gameObject.GetComponent<Button>();
		this.NJFALDOAMPI = this.GNJADABPOLN.UI_data[2].gameObject.GetComponent<Button>();
		this.DGJIDEMKMOP.onClick.RemoveAllListeners();
		this.DGJIDEMKMOP.onClick.AddListener(new UnityAction(this.HGKJIHDGAFH));
		component.onClick.RemoveAllListeners();
		component.onClick.AddListener(new UnityAction(this.HCJPMDLOIMO));
		this.NJFALDOAMPI.onClick.RemoveAllListeners();
		this.NJFALDOAMPI.onClick.AddListener(new UnityAction(this.JMAJPEKNIIE));
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.KHGOFHNFKMG(this.MLJGKAOMLEL) <= 0)
		{
			this.DGJIDEMKMOP.interactable = false;
		}
		this.GNJADABPOLN.UI_data[4].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("qd_taskcount"), this.APCKACLCCPM, this.KMMLCMJFIPF);
		this.GNJADABPOLN.UI_data[6].gameObject.GetComponent<Scrollbar>().value = 0f;
		this.GNJADABPOLN.onUpdateEvents.RemoveAllListeners();
		this.GNJADABPOLN.onUpdateEvents.AddListener(new UnityAction(this.ILBBIDFPLFL));
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
	}

	// Token: 0x060079FA RID: 31226 RVA: 0x003A316C File Offset: 0x003A136C
	public void PGAANCNHIHB(HBPNMNGOFMA KADBECGIMPD)
	{
		if (this.GNJADABPOLN != null)
		{
			UnityEngine.Object.Destroy(this.GNJADABPOLN.gameObject);
		}
		this.GNJADABPOLN = JDCEFOFMGHB.IKGFHGKKCPG.KCBBLDECKGB("UI_DynamicWindow");
		this.KCBNDNGKEOI = this.GNJADABPOLN.UI_data[0].gameObject.GetComponent<UIListBox>();
		this.KCBNDNGKEOI.ClearAll();
		QDWinLogic component = this.GNJADABPOLN.GetComponent<QDWinLogic>();
		if (component != null)
		{
			this.KCBNDNGKEOI.itemPrefab = component.turnItemPrefab;
		}
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			this.KCBNDNGKEOI.addItem(new GHMGDBLLEAG.TurnirItem(KADBECGIMPD));
		}
		this.GNJADABPOLN.UI_data[1].gameObject.SetActive(false);
		this.GNJADABPOLN.UI_data[5].gameObject.SetActive(false);
		this.GNJADABPOLN.UI_data[4].gameObject.SetActive(false);
		this.GNJADABPOLN.UI_data[6].gameObject.SetActive(false);
		this.NJFALDOAMPI = this.GNJADABPOLN.UI_data[2].gameObject.GetComponent<Button>();
		this.NJFALDOAMPI.onClick.AddListener(new UnityAction(this.AKNJPAKMGOB));
	}

	// Token: 0x060079FB RID: 31227 RVA: 0x00022FCC File Offset: 0x000211CC
	public void OPKPLBJPPPG(ONKDCGNBALK ONPHLHKAGFP)
	{
	}

	// Token: 0x060079FC RID: 31228 RVA: 0x003A32BC File Offset: 0x003A14BC
	public void INAMKKBCLGK(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.BFPHBMDMODH();
		long olkmhfnlbjb = KADBECGIMPD.DNIIFBAIPBE();
		OIJEGJLCFCF oijegjlcfcf = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OLPOHFKHBOL(olkmhfnlbjb);
		if (oijegjlcfcf != null)
		{
			this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, oijegjlcfcf.GAAPCLGDOGH.KGBHELBLPMF(oijegjlcfcf.NKHBAJKMAGD, oijegjlcfcf.DBEIGNDALDC, false));
			foreach (EJDGMNEEOGN.OAJLELFKFNB oajlelfkfnb in this.PNONKKOGBLC)
			{
				oajlelfkfnb.FPIHOPOCAHA = oajlelfkfnb.FPIHOPOCAHA.Replace(oldValue, oijegjlcfcf.GAAPCLGDOGH.KGBHELBLPMF(oijegjlcfcf.NKHBAJKMAGD, oijegjlcfcf.DBEIGNDALDC, false));
			}
		}
	}

	// Token: 0x060079FD RID: 31229 RVA: 0x003A2309 File Offset: 0x003A0509
	[CompilerGenerated]
	private void JMAJPEKNIIE()
	{
		this.DGIDHDIAAMM(0);
	}

	// Token: 0x060079FE RID: 31230 RVA: 0x003A3380 File Offset: 0x003A1580
	public void DIJOEGFJHHP(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.PNBECHOLCJM();
		int lpfkfnlhgbi = KADBECGIMPD.AGNKAFLKCAG();
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(lpfkfnlhgbi);
		if (idchhhedhdc == null)
		{
			return;
		}
		this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, idchhhedhdc.HAJNMNALBBI);
		foreach (EJDGMNEEOGN.OAJLELFKFNB oajlelfkfnb in this.PNONKKOGBLC)
		{
			oajlelfkfnb.FPIHOPOCAHA = oajlelfkfnb.FPIHOPOCAHA.Replace(oldValue, idchhhedhdc.HAJNMNALBBI);
		}
	}

	// Token: 0x060079FF RID: 31231 RVA: 0x003A3418 File Offset: 0x003A1618
	public void MDDNINIDKFF(int EDGFGDAPGMB)
	{
		if (this.INABMFOLKPF == null)
		{
			this.INABMFOLKPF = this.GNJADABPOLN.UI_data[3].gameObject.GetComponent<Text>();
		}
		if (this.INABMFOLKPF != null)
		{
			string str = "---";
			if (this.IBPOANECADA > DateTime.Now)
			{
				TimeSpan timeSpan = this.IBPOANECADA - DateTime.Now;
				str = string.Format("{2:D2}:{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
			}
			this.INABMFOLKPF.text = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("qd_tasktime") + str;
		}
	}

	// Token: 0x06007A00 RID: 31232 RVA: 0x003A34D8 File Offset: 0x003A16D8
	public void GHBAHNJOGNM(int EDGFGDAPGMB)
	{
		Debug.Log("click Ok");
		EJDGMNEEOGN.BDOHKJIKPJH bdohkjikpjh = (EJDGMNEEOGN.BDOHKJIKPJH)this.KCBNDNGKEOI.getCurrentItem();
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Cloth_07.wav", 1f);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(710, bdohkjikpjh.JMIGDLKKPAE);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		this.NJFALDOAMPI.interactable = false;
	}

	// Token: 0x06007A01 RID: 31233 RVA: 0x003A3540 File Offset: 0x003A1740
	public void DEDBNEKKMCH(HBPNMNGOFMA KADBECGIMPD)
	{
		if (this.GNJADABPOLN != null)
		{
			UnityEngine.Object.Destroy(this.GNJADABPOLN.gameObject);
		}
		this.GNJADABPOLN = JDCEFOFMGHB.HMJJPNDEKPP().CNHFECCCDIO("\n");
		this.KCBNDNGKEOI = this.GNJADABPOLN.UI_data[1].gameObject.GetComponent<UIListBox>();
		this.KCBNDNGKEOI.FPAOEIHJBOB();
		QDWinLogic component = this.GNJADABPOLN.GetComponent<QDWinLogic>();
		if (component != null)
		{
			this.KCBNDNGKEOI.itemPrefab = component.turnItemPrefab;
		}
		JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(true);
		while (!KADBECGIMPD.NLJJMKFBPBK())
		{
			this.KCBNDNGKEOI.CNNKFIDHPMK(new GHMGDBLLEAG.TurnirItem(KADBECGIMPD));
		}
		this.GNJADABPOLN.UI_data[1].gameObject.SetActive(false);
		this.GNJADABPOLN.UI_data[2].gameObject.SetActive(false);
		this.GNJADABPOLN.UI_data[4].gameObject.SetActive(true);
		this.GNJADABPOLN.UI_data[7].gameObject.SetActive(false);
		this.NJFALDOAMPI = this.GNJADABPOLN.UI_data[1].gameObject.GetComponent<Button>();
		this.NJFALDOAMPI.onClick.AddListener(new UnityAction(this.AKNJPAKMGOB));
	}

	// Token: 0x06007A02 RID: 31234 RVA: 0x003A3690 File Offset: 0x003A1890
	public void LIMLJJCBHBA(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.DHCMILPKJAL();
		int iaekglngclm = Mathf.Abs(KADBECGIMPD.KDNDJNEGBDI());
		this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, this.CPMMCAGDEEO(iaekglngclm));
	}

	// Token: 0x06007A03 RID: 31235 RVA: 0x003A36CC File Offset: 0x003A18CC
	public void MKOIGBOAAGA(HBPNMNGOFMA KADBECGIMPD)
	{
		string oldValue = KADBECGIMPD.BFPHBMDMODH();
		int num = KADBECGIMPD.AGNKAFLKCAG();
		int num2 = KADBECGIMPD.IFDFHJLCHAE();
		this.IJEIOBGNDDM = this.IJEIOBGNDDM.Replace(oldValue, JLFJEGIPIMM.IKGFHGKKCPG.EFHBGFMPCNJ((long)num, (long)num2));
		foreach (EJDGMNEEOGN.OAJLELFKFNB oajlelfkfnb in this.PNONKKOGBLC)
		{
			oajlelfkfnb.FPIHOPOCAHA = oajlelfkfnb.FPIHOPOCAHA.Replace(oldValue, JLFJEGIPIMM.PKGMBFEMKGP().EFHBGFMPCNJ((long)num, (long)num2));
		}
	}

	// Token: 0x04001195 RID: 4501
	private static EJDGMNEEOGN CCHGNBELGIA;

	// Token: 0x04001196 RID: 4502
	private int AMEDADHBLJN;

	// Token: 0x04001197 RID: 4503
	private int DKFPJEABNGF;

	// Token: 0x04001198 RID: 4504
	private AAEEEJIDDEO LBKECCMJAJJ;

	// Token: 0x04001199 RID: 4505
	private string IJEIOBGNDDM = "Text node is empy!";

	// Token: 0x0400119A RID: 4506
	private int JFHIJEKEMCE = -1;

	// Token: 0x0400119B RID: 4507
	private readonly List<EJDGMNEEOGN.OAJLELFKFNB> PNONKKOGBLC = new List<EJDGMNEEOGN.OAJLELFKFNB>();

	// Token: 0x0400119C RID: 4508
	private BaseWindow GNJADABPOLN;

	// Token: 0x0400119D RID: 4509
	private UIListBox KCBNDNGKEOI;

	// Token: 0x0400119E RID: 4510
	public int APCKACLCCPM;

	// Token: 0x0400119F RID: 4511
	public int KMMLCMJFIPF;

	// Token: 0x040011A0 RID: 4512
	public DateTime IBPOANECADA;

	// Token: 0x040011A1 RID: 4513
	private Button DGJIDEMKMOP;

	// Token: 0x040011A2 RID: 4514
	private Button NJFALDOAMPI;

	// Token: 0x040011A3 RID: 4515
	private Text INABMFOLKPF;

	// Token: 0x040011A4 RID: 4516
	public int MLJGKAOMLEL = 1000;

	// Token: 0x040011A5 RID: 4517
	private int JBOHIELFPBC = -1;

	// Token: 0x0200020F RID: 527
	public class GJAJLNFECFC
	{
		// Token: 0x040011A6 RID: 4518
		public string CKBEIDLJLCF;
	}

	// Token: 0x02000210 RID: 528
	public class NGMMKKEPKBJ : ItemBase
	{
		// Token: 0x040011A7 RID: 4519
		public const int EEFBFNKHOJM = 1;

		// Token: 0x040011A8 RID: 4520
		public const int HOACKKIPNMP = 2;

		// Token: 0x040011A9 RID: 4521
		public long AMNMIBIMHOG;

		// Token: 0x040011AA RID: 4522
		public int NHAJMDKJICA;

		// Token: 0x040011AB RID: 4523
		public int IMIBMHGGCJK;

		// Token: 0x040011AC RID: 4524
		public DateTime MCLGCHNCOJI;

		// Token: 0x040011AD RID: 4525
		public DateTime NDIGLDMFMOE;

		// Token: 0x040011AE RID: 4526
		public DateTime CFAGFNEMGCK;

		// Token: 0x040011AF RID: 4527
		public DODHLMFHFNL.QTask NELPNBJKNMJ;

		// Token: 0x040011B0 RID: 4528
		public int PNEDPPPEFFG;

		// Token: 0x040011B1 RID: 4529
		public string ABKNBDJHBCM = "-no result-";

		// Token: 0x040011B2 RID: 4530
		public string BGOKHDOHNGH = "-no info-";

		// Token: 0x040011B3 RID: 4531
		public IIBEEKCAAHK FBOFGGMDFFH;
	}

	// Token: 0x02000211 RID: 529
	public class OAJLELFKFNB
	{
		// Token: 0x06007A06 RID: 31238 RVA: 0x003A378A File Offset: 0x003A198A
		public OAJLELFKFNB(int IJDCDCGBFMB, int GDMOJDPAMMN, long BJPPEBPNDNJ, string CNIGJDMCCEN)
		{
			this.LFDALJDAKOE = IJDCDCGBFMB;
			this.NHNAMJEAPEO = GDMOJDPAMMN;
			this.FPIHOPOCAHA = CNIGJDMCCEN;
			this.IHEJGBDOBPK = BJPPEBPNDNJ;
		}

		// Token: 0x040011B4 RID: 4532
		public long IHEJGBDOBPK;

		// Token: 0x040011B5 RID: 4533
		public int LFDALJDAKOE;

		// Token: 0x040011B6 RID: 4534
		public int NHNAMJEAPEO;

		// Token: 0x040011B7 RID: 4535
		public string FPIHOPOCAHA;

		// Token: 0x040011B8 RID: 4536
		public bool KDCBCOFHHLN;
	}

	// Token: 0x02000212 RID: 530
	public struct EMOEAOFEKCO
	{
		// Token: 0x06007A07 RID: 31239 RVA: 0x003A37B0 File Offset: 0x003A19B0
		public string ICKLMKBIABJ()
		{
			string text = "===== ObscuredFloatTest =====\n";
			if (this.PLFEJBJOOFJ > 0)
			{
				text = IHFEDJEMJMB.EDKKJNHDBPF().GBKMHIGNKJA(this.PLFEJBJOOFJ).BNIHFBMEPAB;
				if (this.OKINDLNNJDA > 1)
				{
					text = string.Concat(new object[]
					{
						text,
						"ElvisLegsLoop",
						null,
						null,
						this.OKINDLNNJDA,
						null,
						"{0} / {1}"
					});
				}
				text += "wpn_bait1";
			}
			if (this.KFODJJIHNHP + this.HFOBJMOOLLD > 1)
			{
				text = text + "isKeyPress" + JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM((long)this.HFOBJMOOLLD, (long)this.KFODJJIHNHP, true) + "_Saturation";
			}
			if (this.MGLOOIONCPM > 1L)
			{
				text += string.Format(JNBICAJIJMM.EDKGBBIIBBC().FLEANFGEJML("Strafe Run Left"), this.MGLOOIONCPM);
			}
			if (this.FELCCFCIJCJ > 1)
			{
				text = text + string.Format(JNBICAJIJMM.EKEBHIJMEML().CKAOHMEKLMH("stretchWidth"), this.DFAGAPBIEBF) + string.Format(" is represented multiple times in BipedReferences eyes.", BHNDGIPPPCE.IKGFHGKKCPG.LNDJPOBICIA(this.FELCCFCIJCJ).BNIHFBMEPAB);
			}
			if (this.HKHMIIEIFNG > 1)
			{
				text += string.Format(JNBICAJIJMM.IKGFHGKKCPG.NLJOLOBPCBJ(""), NHCAOFIKNFE.IKGFHGKKCPG.FGNOEEAHKED(this.HKHMIIEIFNG, JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB, true, false));
			}
			return text;
		}

		// Token: 0x06007A08 RID: 31240 RVA: 0x003A3923 File Offset: 0x003A1B23
		private void DABEDLFGGMG()
		{
			this.KFODJJIHNHP = 0;
			this.HFOBJMOOLLD = 0;
			this.MGLOOIONCPM = 0L;
			this.FELCCFCIJCJ = 0;
			this.DFAGAPBIEBF = 1;
			this.PLFEJBJOOFJ = 1;
			this.OKINDLNNJDA = 0;
			this.JPMNBAOGPCL = " ";
		}

		// Token: 0x06007A09 RID: 31241 RVA: 0x003A3964 File Offset: 0x003A1B64
		public string CJMFHLIBCBM()
		{
			if (this.JPMNBAOGPCL == "HookPoint")
			{
				this.JPMNBAOGPCL = "gi_uinf_4i";
				if (this.PLFEJBJOOFJ > 0)
				{
					this.JPMNBAOGPCL = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.PLFEJBJOOFJ).CGMGBGABLFB(true, -1);
					if (this.OKINDLNNJDA > 0)
					{
						object[] array = new object[6];
						array[0] = this.JPMNBAOGPCL;
						array[0] = "Assets/Weapons/wbootsBase.unity3d";
						array[4] = this.OKINDLNNJDA;
						array[1] = "reel_type2";
						this.JPMNBAOGPCL = string.Concat(array);
					}
					this.JPMNBAOGPCL += "repair.ogg";
				}
				if (this.KFODJJIHNHP + this.HFOBJMOOLLD > 0)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + "gi_tit_ch" + JLFJEGIPIMM.MHFDIJGJGBJ().KMGIDLKLDML((long)this.HFOBJMOOLLD, (long)this.KFODJJIHNHP) + "double: ";
				}
				if (this.MGLOOIONCPM > 0L)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.IKGFHGKKCPG.ECNKLECOKHD("repair.ogg"), this.MGLOOIONCPM);
				}
				if (this.FELCCFCIJCJ > 0)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + string.Format(JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("_Vignette_Center"), this.DFAGAPBIEBF) + string.Format("RollerBladeStand", BHNDGIPPPCE.IKGFHGKKCPG.MBBCGHODIAM(this.FELCCFCIJCJ).BNIHFBMEPAB);
				}
				if (this.HKHMIIEIFNG > 1)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("fwgt_uniq_m"), NHCAOFIKNFE.IKGFHGKKCPG.KLCCFECNEAN(this.HKHMIIEIFNG, JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB, true, true));
				}
			}
			return this.JPMNBAOGPCL;
		}

		// Token: 0x06007A0A RID: 31242 RVA: 0x003A3B38 File Offset: 0x003A1D38
		private void DJDLPOODCPC()
		{
			this.KFODJJIHNHP = 0;
			this.HFOBJMOOLLD = 1;
			this.MGLOOIONCPM = 0L;
			this.FELCCFCIJCJ = 1;
			this.DFAGAPBIEBF = 1;
			this.PLFEJBJOOFJ = 0;
			this.OKINDLNNJDA = 1;
			this.JPMNBAOGPCL = "IdleSlide";
		}

		// Token: 0x06007A0B RID: 31243 RVA: 0x003A3B78 File Offset: 0x003A1D78
		public string JJPMKNKFPPN()
		{
			if (this.JPMNBAOGPCL == "mx=")
			{
				this.JPMNBAOGPCL = "_Metrics";
				if (this.PLFEJBJOOFJ > 0)
				{
					this.JPMNBAOGPCL = IHFEDJEMJMB.OOIJFNAMEDP().LMGMPPAOPEP(this.PLFEJBJOOFJ).IGDKBMGKKDO(true, -1);
					if (this.OKINDLNNJDA > 1)
					{
						object[] array = new object[3];
						array[1] = this.JPMNBAOGPCL;
						array[0] = "</color>\n";
						array[7] = this.OKINDLNNJDA;
						array[6] = "http://www.root-motion.com/finalikdox/html/page11.html";
						this.JPMNBAOGPCL = string.Concat(array);
					}
					this.JPMNBAOGPCL += "This script need an Image with a readbale Texture2D to work.";
				}
				if (this.KFODJJIHNHP + this.HFOBJMOOLLD > 1)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + "MotorbikeHeadstand" + JLFJEGIPIMM.NNEAHAFBOHC().EFHBGFMPCNJ((long)this.HFOBJMOOLLD, (long)this.KFODJJIHNHP) + "Mouse X";
				}
				if (this.MGLOOIONCPM > 0L)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.IMLLGEMPHAP().DOEMGEAEBPN("MotorbikeLassoFwd"), this.MGLOOIONCPM);
				}
				if (this.FELCCFCIJCJ > 0)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + string.Format(JNBICAJIJMM.EDKGBBIIBBC().DOEMGEAEBPN(""), this.DFAGAPBIEBF) + string.Format("1 Hand Sword", BHNDGIPPPCE.IKGFHGKKCPG.BBIIDLJHCNO(this.FELCCFCIJCJ).BNIHFBMEPAB);
				}
				if (this.HKHMIIEIFNG > 1)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.EKEBHIJMEML().HLBAJBLHLNI("ClimbUp"), NHCAOFIKNFE.IKGFHGKKCPG.BOOJJNEMLIF(this.HKHMIIEIFNG, JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BNIHFBMEPAB, true, true));
				}
			}
			return this.JPMNBAOGPCL;
		}

		// Token: 0x06007A0C RID: 31244 RVA: 0x003A3D4C File Offset: 0x003A1F4C
		public EMOEAOFEKCO(string DNHBPGOKLKD)
		{
			this = default(EJDGMNEEOGN.EMOEAOFEKCO);
			this.FBKCOEGMFNG();
			string[] array = DNHBPGOKLKD.Split(new char[]
			{
				';'
			});
			for (int i = 0; i < array.Length; i++)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(array[i]);
				if (diggohpgcnn.OKEBIHBDEOO("money"))
				{
					this.KFODJJIHNHP = diggohpgcnn.DIKKDGKIPEA;
				}
				if (diggohpgcnn.OKEBIHBDEOO("reals"))
				{
					this.HFOBJMOOLLD = diggohpgcnn.DIKKDGKIPEA;
				}
				if (diggohpgcnn.OKEBIHBDEOO("exp"))
				{
					this.MGLOOIONCPM = diggohpgcnn.DLJNOCONOJO;
				}
				if (diggohpgcnn.OKEBIHBDEOO("titul"))
				{
					this.HKHMIIEIFNG = diggohpgcnn.DIKKDGKIPEA;
				}
				if (diggohpgcnn.OKEBIHBDEOO("repfrac"))
				{
					IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(diggohpgcnn.IEIMMFODGFG);
					this.FELCCFCIJCJ = iibeekcaahk.IBEIBAHKIAH;
					this.DFAGAPBIEBF = iibeekcaahk.ICJDPPOJINN;
				}
				if (diggohpgcnn.OKEBIHBDEOO("wpn"))
				{
					IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(diggohpgcnn.IEIMMFODGFG);
					this.PLFEJBJOOFJ = iibeekcaahk2.IBEIBAHKIAH;
					this.OKINDLNNJDA = iibeekcaahk2.ICJDPPOJINN;
				}
			}
		}

		// Token: 0x06007A0D RID: 31245 RVA: 0x003A3E60 File Offset: 0x003A2060
		public string PBBDGIBHHID()
		{
			string text = "post_15";
			if (this.PLFEJBJOOFJ > 0)
			{
				text = IHFEDJEMJMB.JHAAMBEFENP().LMGMPPAOPEP(this.PLFEJBJOOFJ).BNIHFBMEPAB;
				if (this.OKINDLNNJDA > 1)
				{
					object[] array = new object[5];
					array[1] = text;
					array[1] = "Flap_08.wav";
					array[3] = this.OKINDLNNJDA;
					array[5] = "SixStep";
					text = string.Concat(array);
				}
				text += "SAMPLES_LOW";
			}
			if (this.KFODJJIHNHP + this.HFOBJMOOLLD > 0)
			{
				text = text + "IdleRun" + JLFJEGIPIMM.IKGFHGKKCPG.MNMIJFNPIPI((long)this.HFOBJMOOLLD, (long)this.KFODJJIHNHP, false) + "DrawDistance";
			}
			if (this.MGLOOIONCPM > 0L)
			{
				text += string.Format(JNBICAJIJMM.CLIMNFDGOEG().DOEMGEAEBPN("reel_type2"), this.MGLOOIONCPM);
			}
			if (this.FELCCFCIJCJ > 1)
			{
				text = text + string.Format(JNBICAJIJMM.DBMJJPBOPEK().FLEANFGEJML("SwimFreestyle"), this.DFAGAPBIEBF) + string.Format("{0}:{1}:{2}:{3}", BHNDGIPPPCE.IKGFHGKKCPG.CBMIJBEIKID(this.FELCCFCIJCJ).BNIHFBMEPAB);
			}
			if (this.HKHMIIEIFNG > 1)
			{
				text += string.Format(JNBICAJIJMM.APMJBBDBOJO().ECNKLECOKHD("txt"), NHCAOFIKNFE.IKGFHGKKCPG.MODOIHOIMBJ(this.HKHMIIEIFNG, JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB, false, false));
			}
			return text;
		}

		// Token: 0x06007A0E RID: 31246 RVA: 0x003A3FD4 File Offset: 0x003A21D4
		public string HLHHDFFDHGL()
		{
			if (this.JPMNBAOGPCL == " ms")
			{
				this.JPMNBAOGPCL = "Reset";
				if (this.PLFEJBJOOFJ > 1)
				{
					this.JPMNBAOGPCL = IHFEDJEMJMB.IKGFHGKKCPG.IMCJNFHAFGE(this.PLFEJBJOOFJ).MPKGPJJKCPK(true, -1);
					if (this.OKINDLNNJDA > 0)
					{
						object[] array = new object[8];
						array[0] = this.JPMNBAOGPCL;
						array[1] = "IsStrafing";
						array[6] = this.OKINDLNNJDA;
						array[8] = "WateringCanWatering";
						this.JPMNBAOGPCL = string.Concat(array);
					}
					this.JPMNBAOGPCL += " fid=";
				}
				if (this.KFODJJIHNHP + this.HFOBJMOOLLD > 0)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + "invn_rec23" + JLFJEGIPIMM.MHFDIJGJGBJ().KMGIDLKLDML((long)this.HFOBJMOOLLD, (long)this.KFODJJIHNHP) + "release";
				}
				if (this.MGLOOIONCPM > 1L)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.EEOPOHEALPK().CKAOHMEKLMH("\n"), this.MGLOOIONCPM);
				}
				if (this.FELCCFCIJCJ > 0)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + string.Format(JNBICAJIJMM.APMJBBDBOJO().ECNKLECOKHD("15"), this.DFAGAPBIEBF) + string.Format("qd_prise_exp", BHNDGIPPPCE.IKGFHGKKCPG.DAOFNEMHDLD(this.FELCCFCIJCJ).BNIHFBMEPAB);
				}
				if (this.HKHMIIEIFNG > 1)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.EDKGBBIIBBC().HLBAJBLHLNI("\n"), NHCAOFIKNFE.IKGFHGKKCPG.JKAENINHAIF(this.HKHMIIEIFNG, JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BNIHFBMEPAB, true, false));
				}
			}
			return this.JPMNBAOGPCL;
		}

		// Token: 0x06007A0F RID: 31247 RVA: 0x003A41A8 File Offset: 0x003A23A8
		public string NIDKKALEJIM()
		{
			if (this.JPMNBAOGPCL == " ms")
			{
				this.JPMNBAOGPCL = "UnityEngine.Vector4";
				if (this.PLFEJBJOOFJ > 1)
				{
					this.JPMNBAOGPCL = IHFEDJEMJMB.IKGFHGKKCPG.LMGMPPAOPEP(this.PLFEJBJOOFJ).LFEJHHMDEHO(false, -1);
					if (this.OKINDLNNJDA > 1)
					{
						object[] array = new object[5];
						array[1] = this.JPMNBAOGPCL;
						array[1] = "OneHandSwordRun";
						array[3] = this.OKINDLNNJDA;
						array[0] = " ";
						this.JPMNBAOGPCL = string.Concat(array);
					}
					this.JPMNBAOGPCL += "FS ";
				}
				if (this.KFODJJIHNHP + this.HFOBJMOOLLD > 1)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + "_TintColor" + JLFJEGIPIMM.NNEAHAFBOHC().EJOPKKGIIIO((long)this.HFOBJMOOLLD, (long)this.KFODJJIHNHP) + "Motion Blur";
				}
				if (this.MGLOOIONCPM > 1L)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.DBMJJPBOPEK().HLBAJBLHLNI("FaceHit"), this.MGLOOIONCPM);
				}
				if (this.FELCCFCIJCJ > 1)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + string.Format(JNBICAJIJMM.CLIMNFDGOEG().GNKIBMGNHNE("Sun reference not set."), this.DFAGAPBIEBF) + string.Format("", BHNDGIPPPCE.IKGFHGKKCPG.BBIIDLJHCNO(this.FELCCFCIJCJ).BNIHFBMEPAB);
				}
				if (this.HKHMIIEIFNG > 1)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.IKGFHGKKCPG.GNKIBMGNHNE("2000"), NHCAOFIKNFE.IKGFHGKKCPG.DGEINNMPILO(this.HKHMIIEIFNG, JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BNIHFBMEPAB, true, false));
				}
			}
			return this.JPMNBAOGPCL;
		}

		// Token: 0x06007A10 RID: 31248 RVA: 0x003A437C File Offset: 0x003A257C
		private void DHGNEOGDNDN()
		{
			this.KFODJJIHNHP = 0;
			this.HFOBJMOOLLD = 0;
			this.MGLOOIONCPM = 1L;
			this.FELCCFCIJCJ = 1;
			this.DFAGAPBIEBF = 1;
			this.PLFEJBJOOFJ = 1;
			this.OKINDLNNJDA = 1;
			this.JPMNBAOGPCL = "Bezier curve must have two or more control points!";
		}

		// Token: 0x06007A11 RID: 31249 RVA: 0x003A43BC File Offset: 0x003A25BC
		public override string ToString()
		{
			if (this.JPMNBAOGPCL == "")
			{
				this.JPMNBAOGPCL = "";
				if (this.PLFEJBJOOFJ > 0)
				{
					this.JPMNBAOGPCL = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.PLFEJBJOOFJ).JPBOPFNPNHC(false, -1);
					if (this.OKINDLNNJDA > 1)
					{
						this.JPMNBAOGPCL = string.Concat(new object[]
						{
							this.JPMNBAOGPCL,
							" x",
							this.OKINDLNNJDA,
							" "
						});
					}
					this.JPMNBAOGPCL += "; ";
				}
				if (this.KFODJJIHNHP + this.HFOBJMOOLLD > 0)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + "+" + JLFJEGIPIMM.IKGFHGKKCPG.KMGIDLKLDML((long)this.HFOBJMOOLLD, (long)this.KFODJJIHNHP) + "; ";
				}
				if (this.MGLOOIONCPM > 0L)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("qd_prise_exp"), this.MGLOOIONCPM);
				}
				if (this.FELCCFCIJCJ > 0)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("qd_prise_rep"), this.DFAGAPBIEBF) + string.Format(" \"{0}\"", BHNDGIPPPCE.IKGFHGKKCPG.JFOIIJGMKPM(this.FELCCFCIJCJ).BNIHFBMEPAB);
				}
				if (this.HKHMIIEIFNG > 0)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("qd_prise_titul"), NHCAOFIKNFE.IKGFHGKKCPG.HHJHDLHKJDF(this.HKHMIIEIFNG, JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB, false, false));
				}
			}
			return this.JPMNBAOGPCL;
		}

		// Token: 0x06007A12 RID: 31250 RVA: 0x003A4590 File Offset: 0x003A2790
		private void ICKCCGECBHL()
		{
			this.KFODJJIHNHP = 0;
			this.HFOBJMOOLLD = 1;
			this.MGLOOIONCPM = 1L;
			this.FELCCFCIJCJ = 0;
			this.DFAGAPBIEBF = 0;
			this.PLFEJBJOOFJ = 1;
			this.OKINDLNNJDA = 1;
			this.JPMNBAOGPCL = "RollerBladeSkateFwd";
		}

		// Token: 0x06007A13 RID: 31251 RVA: 0x003A45CF File Offset: 0x003A27CF
		private void AIKONFIFBIA()
		{
			this.KFODJJIHNHP = 1;
			this.HFOBJMOOLLD = 0;
			this.MGLOOIONCPM = 1L;
			this.FELCCFCIJCJ = 1;
			this.DFAGAPBIEBF = 1;
			this.PLFEJBJOOFJ = 1;
			this.OKINDLNNJDA = 0;
			this.JPMNBAOGPCL = "pointBuffer";
		}

		// Token: 0x06007A14 RID: 31252 RVA: 0x003A460E File Offset: 0x003A280E
		private void FFGAOEJAMKP()
		{
			this.KFODJJIHNHP = 0;
			this.HFOBJMOOLLD = 1;
			this.MGLOOIONCPM = 0L;
			this.FELCCFCIJCJ = 1;
			this.DFAGAPBIEBF = 0;
			this.PLFEJBJOOFJ = 0;
			this.OKINDLNNJDA = 0;
			this.JPMNBAOGPCL = "Vertical";
		}

		// Token: 0x06007A15 RID: 31253 RVA: 0x003A4650 File Offset: 0x003A2850
		public string APKBOMAKOBI()
		{
			string text = "VaderChoke";
			if (this.PLFEJBJOOFJ > 0)
			{
				text = IHFEDJEMJMB.NNEAHAFBOHC().NKMGKJLONDK(this.PLFEJBJOOFJ).BNIHFBMEPAB;
				if (this.OKINDLNNJDA > 1)
				{
					object[] array = new object[6];
					array[0] = text;
					array[0] = "StartRigidModule";
					array[4] = this.OKINDLNNJDA;
					array[5] = "sound";
					text = string.Concat(array);
				}
				text += "";
			}
			if (this.KFODJJIHNHP + this.HFOBJMOOLLD > 1)
			{
				text = text + "WallRunRight" + JLFJEGIPIMM.MHFDIJGJGBJ().CJKACKADMKM((long)this.HFOBJMOOLLD, (long)this.KFODJJIHNHP, false) + "_";
			}
			if (this.MGLOOIONCPM > 1L)
			{
				text += string.Format(JNBICAJIJMM.DBMJJPBOPEK().CKAOHMEKLMH("RunBackLeft"), this.MGLOOIONCPM);
			}
			if (this.FELCCFCIJCJ > 0)
			{
				text = text + string.Format(JNBICAJIJMM.CLIMNFDGOEG().ECNKLECOKHD(""), this.DFAGAPBIEBF) + string.Format("U", BHNDGIPPPCE.IKGFHGKKCPG.DIGLCANLIHG(this.FELCCFCIJCJ).BNIHFBMEPAB);
			}
			if (this.HKHMIIEIFNG > 1)
			{
				text += string.Format(JNBICAJIJMM.IKGFHGKKCPG.GNKIBMGNHNE("Hidden/DepthOfField/DepthOfField"), NHCAOFIKNFE.IKGFHGKKCPG.BEGAIJKPDDD(this.HKHMIIEIFNG, JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BNIHFBMEPAB, true, true));
			}
			return text;
		}

		// Token: 0x06007A16 RID: 31254 RVA: 0x003A47C4 File Offset: 0x003A29C4
		public string ENFKFAKLHNC()
		{
			string text = "Grounding layers are set to nothing. Please add a ground layer.";
			if (this.PLFEJBJOOFJ > 1)
			{
				text = IHFEDJEMJMB.IKGFHGKKCPG.IMCJNFHAFGE(this.PLFEJBJOOFJ).BNIHFBMEPAB;
				if (this.OKINDLNNJDA > 1)
				{
					object[] array = new object[6];
					array[1] = text;
					array[0] = "{0}Textures/Turnirs/{1}.png";
					array[7] = this.OKINDLNNJDA;
					array[0] = "demoVector3";
					text = string.Concat(array);
				}
				text += "RollerBladeStop";
			}
			if (this.KFODJJIHNHP + this.HFOBJMOOLLD > 1)
			{
				text = text + "wpn_cmp" + JLFJEGIPIMM.MHFDIJGJGBJ().CJKACKADMKM((long)this.HFOBJMOOLLD, (long)this.KFODJJIHNHP, false) + "cntx_teach";
			}
			if (this.MGLOOIONCPM > 0L)
			{
				text += string.Format(JNBICAJIJMM.LPHMKPDBMPP().GNKIBMGNHNE("Forward"), this.MGLOOIONCPM);
			}
			if (this.FELCCFCIJCJ > 1)
			{
				text = text + string.Format(JNBICAJIJMM.EEOPOHEALPK().HLBAJBLHLNI("1HandHeavyOverhead"), this.DFAGAPBIEBF) + string.Format("UIChat_alfa", BHNDGIPPPCE.IKGFHGKKCPG.DIGLCANLIHG(this.FELCCFCIJCJ).BNIHFBMEPAB);
			}
			if (this.HKHMIIEIFNG > 0)
			{
				text += string.Format(JNBICAJIJMM.EEOPOHEALPK().NLJOLOBPCBJ("fshop_btn2"), NHCAOFIKNFE.IKGFHGKKCPG.DGEINNMPILO(this.HKHMIIEIFNG, JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BNIHFBMEPAB, false, true));
			}
			return text;
		}

		// Token: 0x06007A17 RID: 31255 RVA: 0x003A4938 File Offset: 0x003A2B38
		public string HALGHCJFOJF()
		{
			string text = "Index out of range.";
			if (this.PLFEJBJOOFJ > 0)
			{
				text = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.PLFEJBJOOFJ).BNIHFBMEPAB;
				if (this.OKINDLNNJDA > 1)
				{
					object[] array = new object[]
					{
						null,
						text
					};
					array[1] = "WallRunLeft";
					array[7] = this.OKINDLNNJDA;
					array[7] = "sys";
					text = string.Concat(array);
				}
				text += "UNIQUE_SHADOW";
			}
			if (this.KFODJJIHNHP + this.HFOBJMOOLLD > 1)
			{
				text = text + "mainmenu" + JLFJEGIPIMM.PKGMBFEMKGP().OHNLAOJGCGC((long)this.HFOBJMOOLLD, (long)this.KFODJJIHNHP, true) + "_ClipToWorld";
			}
			if (this.MGLOOIONCPM > 0L)
			{
				text += string.Format(JNBICAJIJMM.EEOPOHEALPK().CKAOHMEKLMH("WizardEyeBeam"), this.MGLOOIONCPM);
			}
			if (this.FELCCFCIJCJ > 0)
			{
				text = text + string.Format(JNBICAJIJMM.EKEBHIJMEML().FLEANFGEJML("Hidden/ScreenSpaceReflection"), this.DFAGAPBIEBF) + string.Format("Pick Up ", BHNDGIPPPCE.IKGFHGKKCPG.AGDKFHGOFGH(this.FELCCFCIJCJ).BNIHFBMEPAB);
			}
			if (this.HKHMIIEIFNG > 0)
			{
				text += string.Format(JNBICAJIJMM.DBMJJPBOPEK().HEIBEHAEHBM("Button"), NHCAOFIKNFE.IKGFHGKKCPG.GLFILPFCMGN(this.HKHMIIEIFNG, JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB, false, false));
			}
			return text;
		}

		// Token: 0x06007A18 RID: 31256 RVA: 0x003A4AAC File Offset: 0x003A2CAC
		public string CFCIMGEJBNC()
		{
			string text = "SPACE";
			if (this.PLFEJBJOOFJ > 1)
			{
				text = IHFEDJEMJMB.EDKKJNHDBPF().GBKMHIGNKJA(this.PLFEJBJOOFJ).BNIHFBMEPAB;
				if (this.OKINDLNNJDA > 0)
				{
					object[] array = new object[8];
					array[0] = text;
					array[0] = "_INFO";
					array[0] = this.OKINDLNNJDA;
					array[4] = "CrouchStrafeRight";
					text = string.Concat(array);
				}
				text += "CrouchWalkBackward";
			}
			if (this.KFODJJIHNHP + this.HFOBJMOOLLD > 0)
			{
				text = text + "_Color" + JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC((long)this.HFOBJMOOLLD, (long)this.KFODJJIHNHP, true) + "LHandPunch";
			}
			if (this.MGLOOIONCPM > 0L)
			{
				text += string.Format(JNBICAJIJMM.LPHMKPDBMPP().CCFFMKBBKHI("SwimDogPaddle"), this.MGLOOIONCPM);
			}
			if (this.FELCCFCIJCJ > 0)
			{
				text = text + string.Format(JNBICAJIJMM.LPHMKPDBMPP().GNKIBMGNHNE("CrawlIdle"), this.DFAGAPBIEBF) + string.Format("Vertical", BHNDGIPPPCE.IKGFHGKKCPG.AGDKFHGOFGH(this.FELCCFCIJCJ).BNIHFBMEPAB);
			}
			if (this.HKHMIIEIFNG > 1)
			{
				text += string.Format(JNBICAJIJMM.DBMJJPBOPEK().HEIBEHAEHBM("<color='#300000'>{0} {1}</color>"), NHCAOFIKNFE.IKGFHGKKCPG.KOONNKMMCBB(this.HKHMIIEIFNG, JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BNIHFBMEPAB, false, true));
			}
			return text;
		}

		// Token: 0x06007A19 RID: 31257 RVA: 0x003A4C20 File Offset: 0x003A2E20
		public string BHLHEJCILKF()
		{
			if (this.JPMNBAOGPCL == "RendererD2 is init")
			{
				this.JPMNBAOGPCL = "Turn";
				if (this.PLFEJBJOOFJ > 1)
				{
					this.JPMNBAOGPCL = IHFEDJEMJMB.AGCBLDIBMNB().GBKMHIGNKJA(this.PLFEJBJOOFJ).CGMGBGABLFB(true, -1);
					if (this.OKINDLNNJDA > 0)
					{
						object[] array = new object[3];
						array[1] = this.JPMNBAOGPCL;
						array[0] = "GiantGrabIdle";
						array[5] = this.OKINDLNNJDA;
						array[3] = "error.wav";
						this.JPMNBAOGPCL = string.Concat(array);
					}
					this.JPMNBAOGPCL += "harvestmsg1";
				}
				if (this.KFODJJIHNHP + this.HFOBJMOOLLD > 0)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + "reflectQuality" + JLFJEGIPIMM.NNEAHAFBOHC().EJOPKKGIIIO((long)this.HFOBJMOOLLD, (long)this.KFODJJIHNHP) + "post_2";
				}
				if (this.MGLOOIONCPM > 1L)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI(">"), this.MGLOOIONCPM);
				}
				if (this.FELCCFCIJCJ > 0)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + string.Format(JNBICAJIJMM.EKEBHIJMEML().HLBAJBLHLNI("invn_rec5"), this.DFAGAPBIEBF) + string.Format("The 'VAlign' command requires an alignment parameter of ? (default) or B (bottom).", BHNDGIPPPCE.IKGFHGKKCPG.HFLGKMJEIKK(this.FELCCFCIJCJ).BNIHFBMEPAB);
				}
				if (this.HKHMIIEIFNG > 0)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.IMLLGEMPHAP().CKAOHMEKLMH("Windows/"), NHCAOFIKNFE.IKGFHGKKCPG.CNJKACEFHEI(this.HKHMIIEIFNG, JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BNIHFBMEPAB, false, false));
				}
			}
			return this.JPMNBAOGPCL;
		}

		// Token: 0x06007A1A RID: 31258 RVA: 0x003A4DF4 File Offset: 0x003A2FF4
		public string MJODNMLNFJC()
		{
			if (this.JPMNBAOGPCL == "The Root Node has to be one of the bones in the Spine or the Pelvis, can not initiate the solver.")
			{
				this.JPMNBAOGPCL = "";
				if (this.PLFEJBJOOFJ > 1)
				{
					this.JPMNBAOGPCL = IHFEDJEMJMB.EDKKJNHDBPF().GBKMHIGNKJA(this.PLFEJBJOOFJ).IGDKBMGKKDO(false, -1);
					if (this.OKINDLNNJDA > 1)
					{
						object[] array = new object[2];
						array[0] = this.JPMNBAOGPCL;
						array[1] = "wpn_add/addoptions/klevprop";
						array[7] = this.OKINDLNNJDA;
						array[8] = "The 'HAlign' command requires an alignment parameter of L (left), R (right), or C (center).";
						this.JPMNBAOGPCL = string.Concat(array);
					}
					this.JPMNBAOGPCL += "Elephant";
				}
				if (this.KFODJJIHNHP + this.HFOBJMOOLLD > 0)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + "IdleStun" + JLFJEGIPIMM.MHFDIJGJGBJ().KMGIDLKLDML((long)this.HFOBJMOOLLD, (long)this.KFODJJIHNHP) + "Start.tif";
				}
				if (this.MGLOOIONCPM > 0L)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.EKEBHIJMEML().CCFFMKBBKHI("WeaponReadyFire"), this.MGLOOIONCPM);
				}
				if (this.FELCCFCIJCJ > 1)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + string.Format(JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("910 pck get"), this.DFAGAPBIEBF) + string.Format("Shotgun Reload Magazine", BHNDGIPPPCE.IKGFHGKKCPG.CBMIJBEIKID(this.FELCCFCIJCJ).BNIHFBMEPAB);
				}
				if (this.HKHMIIEIFNG > 0)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.EKEBHIJMEML().ECNKLECOKHD("\n"), NHCAOFIKNFE.IKGFHGKKCPG.CGPPLMOFBDB(this.HKHMIIEIFNG, JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BNIHFBMEPAB, false, false));
				}
			}
			return this.JPMNBAOGPCL;
		}

		// Token: 0x06007A1B RID: 31259 RVA: 0x003A4FC8 File Offset: 0x003A31C8
		private void DBPCPMIBGMJ()
		{
			this.KFODJJIHNHP = 0;
			this.HFOBJMOOLLD = 0;
			this.MGLOOIONCPM = 1L;
			this.FELCCFCIJCJ = 0;
			this.DFAGAPBIEBF = 1;
			this.PLFEJBJOOFJ = 1;
			this.OKINDLNNJDA = 0;
			this.JPMNBAOGPCL = "ClimbRight";
		}

		// Token: 0x06007A1C RID: 31260 RVA: 0x003A5008 File Offset: 0x003A3208
		public string JHGPBNCOHHH()
		{
			if (this.JPMNBAOGPCL == "_NoiseScale")
			{
				this.JPMNBAOGPCL = "__WaterReflection";
				if (this.PLFEJBJOOFJ > 0)
				{
					this.JPMNBAOGPCL = IHFEDJEMJMB.OOIJFNAMEDP().NKMGKJLONDK(this.PLFEJBJOOFJ).MPKGPJJKCPK(false, -1);
					if (this.OKINDLNNJDA > 1)
					{
						object[] array = new object[]
						{
							this.JPMNBAOGPCL
						};
						array[0] = "sendLetterPress";
						array[8] = this.OKINDLNNJDA;
						array[1] = " iterations for read and write";
						this.JPMNBAOGPCL = string.Concat(array);
					}
					this.JPMNBAOGPCL += "wpn_onlym";
				}
				if (this.KFODJJIHNHP + this.HFOBJMOOLLD > 1)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + "- none -" + JLFJEGIPIMM.MHFDIJGJGBJ().EJOPKKGIIIO((long)this.HFOBJMOOLLD, (long)this.KFODJJIHNHP) + "/";
				}
				if (this.MGLOOIONCPM > 1L)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("_Offsets"), this.MGLOOIONCPM);
				}
				if (this.FELCCFCIJCJ > 0)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + string.Format(JNBICAJIJMM.LPHMKPDBMPP().NLJOLOBPCBJ("Rect: "), this.DFAGAPBIEBF) + string.Format("OneHandSwordBlock", BHNDGIPPPCE.IKGFHGKKCPG.HFLGKMJEIKK(this.FELCCFCIJCJ).BNIHFBMEPAB);
				}
				if (this.HKHMIIEIFNG > 1)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.IMLLGEMPHAP().HLBAJBLHLNI("Visit docs to see where PlayerPrefs are stored"), NHCAOFIKNFE.IKGFHGKKCPG.KOONNKMMCBB(this.HKHMIIEIFNG, JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BNIHFBMEPAB, true, true));
				}
			}
			return this.JPMNBAOGPCL;
		}

		// Token: 0x06007A1D RID: 31261 RVA: 0x003A51DC File Offset: 0x003A33DC
		private void OAIOJLMFFGK()
		{
			this.KFODJJIHNHP = 0;
			this.HFOBJMOOLLD = 1;
			this.MGLOOIONCPM = 0L;
			this.FELCCFCIJCJ = 0;
			this.DFAGAPBIEBF = 0;
			this.PLFEJBJOOFJ = 0;
			this.OKINDLNNJDA = 1;
			this.JPMNBAOGPCL = "Wizard2HandThrow";
		}

		// Token: 0x06007A1E RID: 31262 RVA: 0x003A521C File Offset: 0x003A341C
		public string BHNJDBFCCAL()
		{
			string text = "";
			if (this.PLFEJBJOOFJ > 0)
			{
				text = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.PLFEJBJOOFJ).BNIHFBMEPAB;
				if (this.OKINDLNNJDA > 1)
				{
					text = string.Concat(new object[]
					{
						text,
						" x",
						this.OKINDLNNJDA,
						" "
					});
				}
				text += "; ";
			}
			if (this.KFODJJIHNHP + this.HFOBJMOOLLD > 0)
			{
				text = text + "+" + JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM((long)this.HFOBJMOOLLD, (long)this.KFODJJIHNHP, true) + "; ";
			}
			if (this.MGLOOIONCPM > 0L)
			{
				text += string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("qd_prise_exp"), this.MGLOOIONCPM);
			}
			if (this.FELCCFCIJCJ > 0)
			{
				text = text + string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("qd_prise_rep"), this.DFAGAPBIEBF) + string.Format(" \"{0}\"", BHNDGIPPPCE.IKGFHGKKCPG.JFOIIJGMKPM(this.FELCCFCIJCJ).BNIHFBMEPAB);
			}
			if (this.HKHMIIEIFNG > 0)
			{
				text += string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("qd_prise_titul"), NHCAOFIKNFE.IKGFHGKKCPG.HHJHDLHKJDF(this.HKHMIIEIFNG, JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB, false, false));
			}
			return text;
		}

		// Token: 0x06007A1F RID: 31263 RVA: 0x003A5390 File Offset: 0x003A3590
		public string FPFGBCGLCMP()
		{
			string text = "App QUIT";
			if (this.PLFEJBJOOFJ > 1)
			{
				text = IHFEDJEMJMB.OELKEADDKPE().LMGMPPAOPEP(this.PLFEJBJOOFJ).BNIHFBMEPAB;
				if (this.OKINDLNNJDA > 0)
				{
					object[] array = new object[0];
					array[1] = text;
					array[0] = "IdleTurns";
					array[8] = this.OKINDLNNJDA;
					array[8] = "Weapon Reload";
					text = string.Concat(array);
				}
				text += "_Color";
			}
			if (this.KFODJJIHNHP + this.HFOBJMOOLLD > 0)
			{
				text = text + "btn_cancel" + JLFJEGIPIMM.NNEAHAFBOHC().MNMIJFNPIPI((long)this.HFOBJMOOLLD, (long)this.KFODJJIHNHP, true) + "#000000";
			}
			if (this.MGLOOIONCPM > 1L)
			{
				text += string.Format(JNBICAJIJMM.EKEBHIJMEML().HEIBEHAEHBM("MotorbikeWheely"), this.MGLOOIONCPM);
			}
			if (this.FELCCFCIJCJ > 0)
			{
				text = text + string.Format(JNBICAJIJMM.DBMJJPBOPEK().HLBAJBLHLNI("post_19"), this.DFAGAPBIEBF) + string.Format("Flap_02.wav", BHNDGIPPPCE.IKGFHGKKCPG.HFLGKMJEIKK(this.FELCCFCIJCJ).BNIHFBMEPAB);
			}
			if (this.HKHMIIEIFNG > 0)
			{
				text += string.Format(JNBICAJIJMM.EEOPOHEALPK().CCFFMKBBKHI("OfficeSitting"), NHCAOFIKNFE.IKGFHGKKCPG.JKAENINHAIF(this.HKHMIIEIFNG, JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BNIHFBMEPAB, false, true));
			}
			return text;
		}

		// Token: 0x06007A20 RID: 31264 RVA: 0x003A5504 File Offset: 0x003A3704
		public string NMBKBGNBAEM()
		{
			if (this.JPMNBAOGPCL == "Apply RELANG")
			{
				this.JPMNBAOGPCL = "<color='#003000'>{0}</color>";
				if (this.PLFEJBJOOFJ > 0)
				{
					this.JPMNBAOGPCL = IHFEDJEMJMB.AGCBLDIBMNB().NKMGKJLONDK(this.PLFEJBJOOFJ).JPBOPFNPNHC(false, -1);
					if (this.OKINDLNNJDA > 0)
					{
						object[] array = new object[7];
						array[0] = this.JPMNBAOGPCL;
						array[0] = "1HandSwordShieldBash";
						array[5] = this.OKINDLNNJDA;
						array[4] = "_PrevViewProj";
						this.JPMNBAOGPCL = string.Concat(array);
					}
					this.JPMNBAOGPCL += "";
				}
				if (this.KFODJJIHNHP + this.HFOBJMOOLLD > 0)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + "<color='#000000'>" + JLFJEGIPIMM.NNEAHAFBOHC().EFHBGFMPCNJ((long)this.HFOBJMOOLLD, (long)this.KFODJJIHNHP) + "IdleButtonPress";
				}
				if (this.MGLOOIONCPM > 0L)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.LPHMKPDBMPP().GNKIBMGNHNE("DealerShuffle"), this.MGLOOIONCPM);
				}
				if (this.FELCCFCIJCJ > 1)
				{
					this.JPMNBAOGPCL = this.JPMNBAOGPCL + string.Format(JNBICAJIJMM.DBMJJPBOPEK().HLBAJBLHLNI("cntx_close"), this.DFAGAPBIEBF) + string.Format("RollerBladeFrontFlip", BHNDGIPPPCE.IKGFHGKKCPG.GNHKBJKIHML(this.FELCCFCIJCJ).BNIHFBMEPAB);
				}
				if (this.HKHMIIEIFNG > 1)
				{
					this.JPMNBAOGPCL += string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("RotationLimitPolygonal reach cones are invalid."), NHCAOFIKNFE.IKGFHGKKCPG.HBMGCEMAPOK(this.HKHMIIEIFNG, JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB, true, true));
				}
			}
			return this.JPMNBAOGPCL;
		}

		// Token: 0x06007A21 RID: 31265 RVA: 0x003A56D8 File Offset: 0x003A38D8
		private void BHGBPNFEGML()
		{
			this.KFODJJIHNHP = 0;
			this.HFOBJMOOLLD = 1;
			this.MGLOOIONCPM = 1L;
			this.FELCCFCIJCJ = 0;
			this.DFAGAPBIEBF = 0;
			this.PLFEJBJOOFJ = 0;
			this.OKINDLNNJDA = 1;
			this.JPMNBAOGPCL = "active_obj_";
		}

		// Token: 0x06007A22 RID: 31266 RVA: 0x003A5717 File Offset: 0x003A3917
		private void FBKCOEGMFNG()
		{
			this.KFODJJIHNHP = 0;
			this.HFOBJMOOLLD = 0;
			this.MGLOOIONCPM = 0L;
			this.FELCCFCIJCJ = 0;
			this.DFAGAPBIEBF = 0;
			this.PLFEJBJOOFJ = 0;
			this.OKINDLNNJDA = 0;
			this.JPMNBAOGPCL = "";
		}

		// Token: 0x040011B9 RID: 4537
		public int HKHMIIEIFNG;

		// Token: 0x040011BA RID: 4538
		public int KFODJJIHNHP;

		// Token: 0x040011BB RID: 4539
		public int HFOBJMOOLLD;

		// Token: 0x040011BC RID: 4540
		public long MGLOOIONCPM;

		// Token: 0x040011BD RID: 4541
		public int FELCCFCIJCJ;

		// Token: 0x040011BE RID: 4542
		public int DFAGAPBIEBF;

		// Token: 0x040011BF RID: 4543
		public int PLFEJBJOOFJ;

		// Token: 0x040011C0 RID: 4544
		public int OKINDLNNJDA;

		// Token: 0x040011C1 RID: 4545
		private string JPMNBAOGPCL;
	}

	// Token: 0x02000213 RID: 531
	public class BDOHKJIKPJH : ItemBase
	{
		// Token: 0x06007A23 RID: 31267 RVA: 0x003A5758 File Offset: 0x003A3958
		public void HKIECBCNEDG(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.HFNHCIGCOBE();
				this.OLNGOHEPLBO.color = new Color(1570f, 1587f, 84f, 968f);
			}
		}

		// Token: 0x06007A24 RID: 31268 RVA: 0x003A57A8 File Offset: 0x003A39A8
		public void BGGCFGOPHCM(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.MMKLLFCKCAG();
				this.OLNGOHEPLBO.color = new Color(1720f, 528f, 1697f, 1958f);
			}
		}

		// Token: 0x06007A25 RID: 31269 RVA: 0x003A57F8 File Offset: 0x003A39F8
		public string PEAGILMFLGC(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 1 || this.HMDHFAKPMJD == 6)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.EDKKJNHDBPF().GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("FOG_EXP2", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("_ChromaticAberration_Spectrum", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("IdleSad", JNBICAJIJMM.EDKGBBIIBBC().CCFFMKBBKHI("UNITY DEBUG"));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("*** ActorMgr Scene is loaded:", "WeaponReadyFire");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.IKGFHGKKCPG.NKMGKJLONDK(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("IceHockeySlapShot", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("jamp", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("===== ObscuredFloatTest =====\n", JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_MainTex", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("WeaponRun", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("GiantGrabIdle", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("[ACTk] WallHack Detector: already running!", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A26 RID: 31270 RVA: 0x003A5988 File Offset: 0x003A3B88
		public string GEGBDJCICJN(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 1 || this.HMDHFAKPMJD == 4)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("wpn_add/base", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("<=|>=|!=", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("{0}:{1}:{2}:{3}", JNBICAJIJMM.IKGFHGKKCPG.HEIBEHAEHBM("u_UniqueShadowTextureFakePoint"));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace(" ", "Seat Stand");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.NNEAHAFBOHC().IMCJNFHAFGE(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("crft_recnt", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_RotationMatrix", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(1L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("WorkerShovel", JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("t_body", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_WaterLevel", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("gi_tit_sel", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A27 RID: 31271 RVA: 0x003A5B18 File Offset: 0x003A3D18
		public virtual void JGPDJOMMAIN(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.BPIGOGBBHLP(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "DeadmanFloat";
			if (Application.isEditor)
			{
				object[] array = new object[0];
				array[1] = this.PCPMJEDBDKO;
				array[1] = "BowFire";
				array[6] = this.FHNGFNCIPBP;
				array[3] = "wpn_chair3";
				str = string.Concat(array);
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.BBNHICAOOFM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = this.MEJJADAEGLP(this.DBPACEJBBNL);
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = "<color=\"#02C85F\"><b>ObscuredPrefs:</b></color>\nsecure, lot of additional types and extra options" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[0].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
			}
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.BOIIMMKPGHJ(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[3].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[103].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 0 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[100].gameObject.SetActive(true);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().IHOFGFGLNBM(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.GCDCMEKHBGD));
				return;
			}
			IKPEEEBENDE[7].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x003A5E44 File Offset: 0x003A4044
		public virtual void GFOBMJGIOOJ(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.CONHGLCNKHE(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "IdleMonster";
			if (Application.isEditor)
			{
				object[] array = new object[6];
				array[1] = this.PCPMJEDBDKO;
				array[0] = "MotorbikeBackwardSitting";
				array[6] = this.FHNGFNCIPBP;
				array[0] = "GestureChestPumpSalute";
				str = string.Concat(array);
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.BBNHICAOOFM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().text = this.IGBNHDPGGKH(this.DBPACEJBBNL);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = "Backward Sitting" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[7].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.BOIIMMKPGHJ(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[3].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[84].gameObject.SetActive(true);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				IKPEEEBENDE[86].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 0)
			{
				CKNLPGEPGGF.IKGFHGKKCPG.IHOFGFGLNBM(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.CKHHDJOIGLD));
				return;
			}
			IKPEEEBENDE[3].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x003A6170 File Offset: 0x003A4370
		public virtual void INMPECLHIID(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[5].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "Failed parsing atlas group.  Setting to group 0";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = false;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("_WrinkleInfluences3", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("◍◍◍", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A2A RID: 31274 RVA: 0x003A6310 File Offset: 0x003A4510
		public void FCJGHFAKKNE(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.PFFJJEJNKPB();
				this.OLNGOHEPLBO.color = new Color(1231f, 800f, 1905f, 1700f);
			}
		}

		// Token: 0x06007A2B RID: 31275 RVA: 0x003A6360 File Offset: 0x003A4560
		public virtual void OOCMPDPJPDL(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[8].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				this.KLGAIAGBPCD.text = "";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("_FogScatteringData", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("Katana45DegSwing", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("<color='#003000'>{0}</color>", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A2C RID: 31276 RVA: 0x003A6500 File Offset: 0x003A4700
		public string OCFPPAJHIPK(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 6 || this.HMDHFAKPMJD == 3)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().NKMGKJLONDK(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("[fish]", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("FOG_VOID_BOX", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("_EMISSION", JNBICAJIJMM.APMJBBDBOJO().HLBAJBLHLNI("IKSolverTrigonometric Bend Normal is Vector3.zero."));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("</color>", "IdleTyping");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.AGCBLDIBMNB().LMGMPPAOPEP(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("MotorbikeBackwardStand", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("/", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(1L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Below you can try to cheat few variables of the regular types and their obscured (secure) analogues (you may change initial values from Tester object inspector):", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("knopje.wav", string.Concat(0));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("MotorbikeShootLeft", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("SoccerKeeperStrafeRight", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("IdleSpew", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x003A6690 File Offset: 0x003A4890
		public virtual void BPDCPNLJFDM(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.KADJFNIOPEO(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 1;
			if (JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "LUX_GAMMA";
			if (Application.isEditor)
			{
				object[] array = new object[4];
				array[0] = this.PCPMJEDBDKO;
				array[0] = "Add random value";
				array[2] = this.FHNGFNCIPBP;
				array[1] = "Vertical";
				str = string.Concat(array);
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().text = this.OCIANCHCPKP(this.DBPACEJBBNL);
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = "IceHockeyShotLeft" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[8].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
			}
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.BOIIMMKPGHJ(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[6].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[44].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[-124].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.IKGFHGKKCPG.FKKFALIBPCF(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.OJPEKNEAOGH));
				return;
			}
			IKPEEEBENDE[6].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A2E RID: 31278 RVA: 0x003A69BC File Offset: 0x003A4BBC
		public virtual void LHEFHNJBAHB(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.BPIGOGBBHLP(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "SunshinePreferences";
			if (Application.isEditor)
			{
				object[] array = new object[3];
				array[1] = this.PCPMJEDBDKO;
				array[1] = "<color='#003000'>+{0} {1}</color>";
				array[4] = this.FHNGFNCIPBP;
				array[4] = "_Downsample";
				str = string.Concat(array);
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.BBNHICAOOFM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.PKKEHGLBKDE(this.DBPACEJBBNL);
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().text = "right" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[3].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.MECJHEKFKKP(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[8].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-118].gameObject.SetActive(true);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[120].gameObject.SetActive(true);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().GFPOJNDPMLC(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.DHHNFMDOPGH));
				return;
			}
			IKPEEEBENDE[3].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A2F RID: 31279 RVA: 0x003A6CE8 File Offset: 0x003A4EE8
		public virtual void EBBFEBPNLNF(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[1].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[6].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				this.KLGAIAGBPCD.text = "WeaponFire";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = false;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("auc_wcstc", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("IdleDodgeLeft", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format(" L ", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A30 RID: 31280 RVA: 0x003A6E88 File Offset: 0x003A5088
		public void DGLPHEBMNLM(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.NIOGJOFLPLH();
				this.OLNGOHEPLBO.color = new Color(398f, 447f, 1132f, 1673f);
			}
		}

		// Token: 0x06007A31 RID: 31281 RVA: 0x003A6ED8 File Offset: 0x003A50D8
		public virtual void JPPOMEMFLIC(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[0].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[5].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "_TintColor";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = false;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("WalkInjured", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("SUNSHINE_ONE_CASCADE", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("none", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A32 RID: 31282 RVA: 0x003A7078 File Offset: 0x003A5278
		public BDOHKJIKPJH(HBPNMNGOFMA KADBECGIMPD)
		{
			this.JMIGDLKKPAE = KADBECGIMPD.DNIIFBAIPBE();
			this.JOOKAILKHKB = KADBECGIMPD.HDBGOLAFOBK();
			this.PCPMJEDBDKO = KADBECGIMPD.HDBGOLAFOBK();
			this.HMDHFAKPMJD = KADBECGIMPD.HDBGOLAFOBK();
			this.KBGHOIJIPJF = KADBECGIMPD.HDBGOLAFOBK();
			this.GBLMLOPEFOA = KADBECGIMPD.HDBGOLAFOBK();
			this.FHNGFNCIPBP = KADBECGIMPD.HDBGOLAFOBK();
			this.ANKBIDMIGJI = KADBECGIMPD.HDBGOLAFOBK();
			this.IOGCILMDGOJ = KADBECGIMPD.HDBGOLAFOBK();
			this.FEIPJJLEDAG = KADBECGIMPD.HDBGOLAFOBK();
			this.MGNLHNLJJLD = KADBECGIMPD.IKJAOHGGCJD() - TimeController.IKGFHGKKCPG.deltaTime;
			this.PNKNHBJELOB = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.BFPHBMDMODH());
			this.PNEDPPPEFFG = KADBECGIMPD.HDBGOLAFOBK();
			this.HDELGEDDDCE = KADBECGIMPD.HDBGOLAFOBK();
			this.MIGBFMILDHD = KADBECGIMPD.HDBGOLAFOBK();
			this.NPPJLOBFGBH = KADBECGIMPD.HDBGOLAFOBK();
			this.CKOIFCIHPPP = KADBECGIMPD.HDBGOLAFOBK();
			this.GJHHMCNLCNL = KADBECGIMPD.HDBGOLAFOBK();
			this.KECFBIDINKG = KADBECGIMPD.HDBGOLAFOBK();
			this.HIFAKGDHNCM = KADBECGIMPD.HDBGOLAFOBK();
			this.NKJPKIEPOGH = string.Concat(this.PNKNHBJELOB);
		}

		// Token: 0x06007A33 RID: 31283 RVA: 0x003A71A8 File Offset: 0x003A53A8
		public string OHMFDNHNKFN(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 4 || this.HMDHFAKPMJD == 7)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.NNEAHAFBOHC().LMGMPPAOPEP(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("MotorbikeBackwardSitting", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("Forward", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("</color>", JNBICAJIJMM.EDKGBBIIBBC().HLBAJBLHLNI(""));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("SUNSHINE_FOUR_CASCADES", "_HighlightSuppression");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.JHAAMBEFENP().IMCJNFHAFGE(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("Sewing", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("ClimbIdle", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC(1L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("bool: ", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("UIChat_fontSize", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_MainTex", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("ClimbUp", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("UNDISTORT", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A34 RID: 31284 RVA: 0x003A7338 File Offset: 0x003A5538
		public virtual void FAIFIIDDAAG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[4].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "#000040";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("Invalid FBBIK setup. Please right-click on the component header and select 'Reinitiate'.", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("BipedReferences limb is completely stretched out in the initial pose. IK solver can not calculate the default bend plane for the limb. Please make sure you character's limbs are at least slightly bent in the initial pose. First bone: ", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x003A74D8 File Offset: 0x003A56D8
		public virtual void FMAHGBIDEPK(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.KBBCBFJINNG(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 1;
			if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "_UserLut_Params";
			if (Application.isEditor)
			{
				object[] array = new object[6];
				array[0] = this.PCPMJEDBDKO;
				array[0] = "Wheely No Hands";
				array[3] = this.FHNGFNCIPBP;
				array[5] = "removed";
				str = string.Concat(array);
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.BBNHICAOOFM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = this.CJKLJONCBAC(this.DBPACEJBBNL);
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = "GrounderIK does not support FABRIKRoot, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead." + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[8].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.PEJJOKHOLMF(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[8].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[11].gameObject.SetActive(true);
			if (this.FEIPJJLEDAG > 0 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[75].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 0)
			{
				CKNLPGEPGGF.IKGFHGKKCPG.GFPOJNDPMLC(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.CKOMEOHDOBF));
				return;
			}
			IKPEEEBENDE[0].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x003A7804 File Offset: 0x003A5A04
		public virtual void KEHIFCHMPGO(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[2].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[3].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "No IK assigned in HitReaction";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("</color>", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("file:///", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("ShotgunReloadMagazine", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x003A79A4 File Offset: 0x003A5BA4
		public string MEJJADAEGLP(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 5 || this.HMDHFAKPMJD == 4)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.NNEAHAFBOHC().NKMGKJLONDK(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("Materials/DFMLambertSolidColor", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("RollerBladeCrossoverRight", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("SatNightFever", JNBICAJIJMM.EDKGBBIIBBC().CCFFMKBBKHI(" %\n"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("ChannelCastOmni", "https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("Mutilate", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("inv_invheader", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("paper.wav", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("SatNightFever", string.Concat(0));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("StrafeRunLeft", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_ScreenSize", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("1", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x003A7B34 File Offset: 0x003A5D34
		public virtual void LLGDGMHIGHM(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.KBBCBFJINNG(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = " iterations for read and write";
			if (Application.isEditor)
			{
				object[] array = new object[8];
				array[0] = this.PCPMJEDBDKO;
				array[0] = "_HistoryTex";
				array[2] = this.FHNGFNCIPBP;
				array[8] = "walk";
				str = string.Concat(array);
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().text = this.GNONKCKHIJH(this.DBPACEJBBNL);
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = "SoccerSprint" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[3].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.PEJJOKHOLMF(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[0].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[49].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				IKPEEEBENDE[37].gameObject.SetActive(true);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 0)
			{
				CKNLPGEPGGF.IKGFHGKKCPG.FKKFALIBPCF(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.MKEHBBAEHEH));
				return;
			}
			IKPEEEBENDE[7].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A39 RID: 31289 RVA: 0x003A7E60 File Offset: 0x003A6060
		public virtual void HFDBELKGGPG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[3].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[8].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "ui_place_flag.wav";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = false;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("FishController", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("no_money", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("wpn_add/base", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A3A RID: 31290 RVA: 0x003A8000 File Offset: 0x003A6200
		public string ECCIJAFICIA(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 6 || this.HMDHFAKPMJD == 4)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OOIJFNAMEDP().NKMGKJLONDK(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("invn_rec27", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("name", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("MotorbikeHandstand", JNBICAJIJMM.EDKGBBIIBBC().HEIBEHAEHBM(" This is not possible to be called for standalone input. Please check your platform and code where this is called"));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("IdleFeedThrow", "R");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.EDKKJNHDBPF().LMGMPPAOPEP(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("isRagulaSet", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("OfficeSitting1LegStraight", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("ActorFish_", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("IdleMonster", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace(".", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("<color='#80ff00'>+ </color>", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("maxModelScale", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A3B RID: 31291 RVA: 0x003A8190 File Offset: 0x003A6390
		public string EMDEMNGPPCE(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 8 || this.HMDHFAKPMJD == 7)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.JHAAMBEFENP().IMCJNFHAFGE(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("sunshine_IsOrthographic", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace(" ms", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("private", JNBICAJIJMM.IMLLGEMPHAP().CKAOHMEKLMH("type_"));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("OneHandSwordRun", "Only Hinge Rotation Limits should be used on 2D IK solvers.");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.JHAAMBEFENP().NKMGKJLONDK(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("[curcnt]", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(1L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("</color>\n", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("bool:", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace(" for vert ", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("TOD_Directionality", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("BUMPED", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A3C RID: 31292 RVA: 0x003A8320 File Offset: 0x003A6520
		public string CDEMJCHIKPP(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 2 || this.HMDHFAKPMJD == 3)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.IMCJNFHAFGE(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("GiantGrabIdle2", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("PistolFire", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("Cheer Knees", JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("_WaterMap"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("800000", "error");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.NNEAHAFBOHC().NKMGKJLONDK(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("PaperTurn.wav", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("WizardBlock", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC(1L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_camIntensive", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("cht_tofrend", string.Concat(0));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("1HSwordStrafeRunLeft", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("22", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Lasso Back", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A3D RID: 31293 RVA: 0x003A84B0 File Offset: 0x003A66B0
		public string JPFLFCMKKGJ(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 6 || this.HMDHFAKPMJD == 3)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OOIJFNAMEDP().NKMGKJLONDK(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("MotorbikeLassoFwd", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("RightSplashPause", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("_MaskTex", JNBICAJIJMM.IKGFHGKKCPG.NLJOLOBPCBJ("allrec.ogg"));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("<color='#000000'>", "Item_Sell.ogg");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.OOIJFNAMEDP().GBKMHIGNKJA(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("IsStrafing", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Life bar: ", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Giant2HandSlamIdle", JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("ZombieIdle", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("******* playMusicBase  LocNewLogic", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("SneakLeft", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("{0} {1} {2} {3}", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A3E RID: 31294 RVA: 0x003A8640 File Offset: 0x003A6840
		public virtual void GEMBKIPIHCH(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.BPIGOGBBHLP(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "";
			if (Application.isEditor)
			{
				object[] array = new object[8];
				array[1] = this.PCPMJEDBDKO;
				array[0] = "_PixelsPerMeterAtOneMeter";
				array[3] = this.FHNGFNCIPBP;
				array[8] = "invn_rec21";
				str = string.Concat(array);
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().text = this.KBEPOLDLABE(this.DBPACEJBBNL);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().text = "space" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[6].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.PEJJOKHOLMF(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[7].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-91].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 0 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				IKPEEEBENDE[30].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().IHOFGFGLNBM(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.DHHNFMDOPGH));
				return;
			}
			IKPEEEBENDE[7].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A3F RID: 31295 RVA: 0x003A896C File Offset: 0x003A6B6C
		public void CBFLNEFBJMN(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.KEDGAOBCNJG;
				this.OLNGOHEPLBO.color = new Color(25f, 53f, 472f, 1117f);
			}
		}

		// Token: 0x06007A40 RID: 31296 RVA: 0x003A89BC File Offset: 0x003A6BBC
		public virtual void PIKNKNNODAI(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.KADJFNIOPEO(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "turn_state";
			if (Application.isEditor)
			{
				object[] array = new object[5];
				array[0] = this.PCPMJEDBDKO;
				array[0] = "iNPC";
				array[7] = this.FHNGFNCIPBP;
				array[5] = "maxspd";
				str = string.Concat(array);
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = this.JAIAAPKLBHO(this.DBPACEJBBNL);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = "Not UNsetting 'UniqueShadowSun.instance' because it points to someone else '{0}'!" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[3].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.HDLGMNLFDLB(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[8].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-66].gameObject.SetActive(true);
			if (this.FEIPJJLEDAG > 0 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[-64].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().FKKFALIBPCF(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.HFBOCBLODCD));
				return;
			}
			IKPEEEBENDE[3].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A41 RID: 31297 RVA: 0x003A8CE8 File Offset: 0x003A6EE8
		public virtual void NIIKCPFMCNF(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.KBBCBFJINNG(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "1HandHeavySwing2";
			if (Application.isEditor)
			{
				object[] array = new object[8];
				array[1] = this.PCPMJEDBDKO;
				array[0] = "_Speed";
				array[7] = this.FHNGFNCIPBP;
				array[0] = "=";
				str = string.Concat(array);
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.BBNHICAOOFM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = this.GOOCLIFMIJM(this.DBPACEJBBNL);
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = "CrouchWalk" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[7].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
			}
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.HDLGMNLFDLB(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[4].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-85].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[-71].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().GFPOJNDPMLC(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.CBFLNEFBJMN));
				return;
			}
			IKPEEEBENDE[5].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A42 RID: 31298 RVA: 0x003A9014 File Offset: 0x003A7214
		public void OLDHFJMJMKP(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.KEDGAOBCNJG;
				this.OLNGOHEPLBO.color = new Color(1f, 1f, 1f, 1f);
			}
		}

		// Token: 0x06007A43 RID: 31299 RVA: 0x003A9064 File Offset: 0x003A7264
		public virtual void DACJDGODBNG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[3].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[3].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = ".";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = false;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("(", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("C", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("_w", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A44 RID: 31300 RVA: 0x003A9204 File Offset: 0x003A7404
		public virtual void KJJGOPDNLGA(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.KBBCBFJINNG(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "RunBackward";
			if (Application.isEditor)
			{
				object[] array = new object[3];
				array[1] = this.PCPMJEDBDKO;
				array[1] = "RenderType";
				array[8] = this.FHNGFNCIPBP;
				array[5] = "ChannelCastOmni";
				str = string.Concat(array);
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.BBNHICAOOFM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = this.AFJEOLCNIHB(this.DBPACEJBBNL);
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = "" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[5].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.MECJHEKFKKP(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[0].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-2].gameObject.SetActive(true);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				IKPEEEBENDE[17].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().FKKFALIBPCF(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.HKIECBCNEDG));
				return;
			}
			IKPEEEBENDE[1].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A45 RID: 31301 RVA: 0x003A9530 File Offset: 0x003A7730
		public string GOOCLIFMIJM(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 7 || this.HMDHFAKPMJD == 7)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().LMGMPPAOPEP(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("_BlurRadius", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("IdleStand", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("Null", JNBICAJIJMM.EKEBHIJMEML().HLBAJBLHLNI("WizardEyeBeam"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("wpn_rec4", "wpn_bait1");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.OELKEADDKPE().NKMGKJLONDK(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("A", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Giant2HandSlamIdle", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("IdleMeditate", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("BlendDirection", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Downsamp", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("</color>\n", JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("WandStand", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A46 RID: 31302 RVA: 0x003A96C0 File Offset: 0x003A78C0
		public override void MLCFJPPIOJG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.CONHGLCNKHE(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "";
			if (Application.isEditor)
			{
				str = string.Concat(new object[]
				{
					this.PCPMJEDBDKO,
					": ",
					this.FHNGFNCIPBP,
					" "
				});
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.BBNHICAOOFM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = this.IGBNHDPGGKH(this.DBPACEJBBNL);
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = "x" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[6].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.PEJJOKHOLMF(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[7].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[9].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 0 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				IKPEEEBENDE[9].gameObject.SetActive(true);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 0)
			{
				CKNLPGEPGGF.IKGFHGKKCPG.GFPOJNDPMLC(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.OLDHFJMJMKP));
				return;
			}
			IKPEEEBENDE[3].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A47 RID: 31303 RVA: 0x003A99EC File Offset: 0x003A7BEC
		public string IKCGCJCGIPM(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 0 || this.HMDHFAKPMJD == 0)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().IMCJNFHAFGE(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("StrafeRunRight", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("QTask.xml", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("Kernel", JNBICAJIJMM.LPHMKPDBMPP().NLJOLOBPCBJ("_Specular"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("IceHockeyShotLeft", "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.EDKKJNHDBPF().GBKMHIGNKJA(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("category", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Injection Detected! Cause: ", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(1L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("u_email", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("1HandSwordChargeUp", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Ignore Raycast", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("1HandSwordRollAttack", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("The 'HAlign' command requires an alignment parameter of L (left), R (right), or C (center).", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A48 RID: 31304 RVA: 0x003A9B7C File Offset: 0x003A7D7C
		public virtual void JAHBIHLIJBL(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[0].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[7].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "H";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = false;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("MotorbikeSeatStandWheely", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("-STRIKETHROUGH", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A49 RID: 31305 RVA: 0x003A9D1C File Offset: 0x003A7F1C
		public string GLCKNPKINDE(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 0 || this.HMDHFAKPMJD == 2)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OOIJFNAMEDP().NKMGKJLONDK(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("Brow", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("demoLong", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("123", JNBICAJIJMM.APMJBBDBOJO().HEIBEHAEHBM(""));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("choldposx", " registered.");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.OOIJFNAMEDP().LMGMPPAOPEP(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("IKMappingSpine is missing the left upper arm bone.", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("wpn_onlym", JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO(1L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Cloth_01.wav", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_DepthExponent", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("OfficeSittingReadingPageFlip", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Cloth_07.wav", JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Handlebar Sit", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A4A RID: 31306 RVA: 0x003A9EAC File Offset: 0x003A80AC
		public override void FBBCBBGJIMC(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[2].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[7].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "wpn_eat7";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("1=", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("RunningDance", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("CheckResources () for ", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A4B RID: 31307 RVA: 0x003AA04C File Offset: 0x003A824C
		public virtual void MJJJHNJHIIM(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.KADJFNIOPEO(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "wpn_eat1";
			if (Application.isEditor)
			{
				object[] array = new object[0];
				array[1] = this.PCPMJEDBDKO;
				array[1] = "cash.ogg";
				array[4] = this.FHNGFNCIPBP;
				array[5] = "Directional";
				str = string.Concat(array);
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.BBNHICAOOFM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.BMNPGIJDINK(this.DBPACEJBBNL);
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = " is not supported on this platform!" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[4].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.KEBGFJDMLLH(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[0].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-117].gameObject.SetActive(true);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[90].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.IKGFHGKKCPG.GFPOJNDPMLC(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.KPOMDPLHMHG));
				return;
			}
			IKPEEEBENDE[2].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A4C RID: 31308 RVA: 0x003AA378 File Offset: 0x003A8578
		public string JAIAAPKLBHO(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 7 || this.HMDHFAKPMJD == 1)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.NNEAHAFBOHC().LMGMPPAOPEP(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("Giant2HandSlamSwing", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("\\ n", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("1 Hand Sword Ready", JNBICAJIJMM.IMLLGEMPHAP().CCFFMKBBKHI("\n"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("wpn_eat5", "_History2Weight");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.JHAAMBEFENP().LMGMPPAOPEP(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("SwimDogPaddle", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("The 'HAlign' command requires an alignment parameter of L (left), R (right), or C (center).", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("knopje.wav", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("NadeThrow", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("WizardOverhead", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("MotorbikeSeatStand", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("LUX_GAMMA", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A4D RID: 31309 RVA: 0x003AA508 File Offset: 0x003A8708
		public virtual void NLPHACBANBH(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.KBBCBFJINNG(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 1;
			if (JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "WandAttack";
			if (Application.isEditor)
			{
				object[] array = new object[1];
				array[1] = this.PCPMJEDBDKO;
				array[0] = "https://groups.google.com/forum/#!forum/final-ik";
				array[2] = this.FHNGFNCIPBP;
				array[5] = "RollerBladeGrindRoyale";
				str = string.Concat(array);
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.JAIAAPKLBHO(this.DBPACEJBBNL);
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = "_MainTex" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[8].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
			}
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.KEBGFJDMLLH(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[7].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-5].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 0 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				IKPEEEBENDE[-40].gameObject.SetActive(true);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.IKGFHGKKCPG.IHOFGFGLNBM(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.KJDGIFNFGPL));
				return;
			}
			IKPEEEBENDE[8].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A4E RID: 31310 RVA: 0x003AA834 File Offset: 0x003A8A34
		public string IGBNHDPGGKH(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 4 || this.HMDHFAKPMJD == 5)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("[wtemplid]", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("[fish]", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("[fish]", JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("qd_anyfish"));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("[fish]", "Случайный выбор");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("[baitid]", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("[weight]", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("[maxweight]", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("[curcnt]", string.Concat(0));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("[maxcnt]", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("[minwgt]", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("[maxwgt]", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A4F RID: 31311 RVA: 0x003AA9C4 File Offset: 0x003A8BC4
		public string KBEPOLDLABE(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 6 || this.HMDHFAKPMJD == 3)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.JHAAMBEFENP().NKMGKJLONDK(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("* *", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("Vertical", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("", JNBICAJIJMM.DBMJJPBOPEK().ECNKLECOKHD("Cloth_01.wav"));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("OfficeSitting1LegStraight", "SoccerKeeperReady");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.AGCBLDIBMNB().GBKMHIGNKJA(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("WeaponStand", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Thigh", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_InvGamma", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("OfficeSittingReading", string.Concat(0));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace(", ", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("https://www.youtube.com/watch?v=eP9-zycoHLk", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A50 RID: 31312 RVA: 0x003AAB54 File Offset: 0x003A8D54
		public string HPMCPENHMEB(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 8 || this.HMDHFAKPMJD == 2)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OOIJFNAMEDP().IMCJNFHAFGE(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("PistolReload", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("Assets/Weapons/wbaseLegs.unity3d", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("teech_perk", JNBICAJIJMM.IMLLGEMPHAP().HLBAJBLHLNI(""));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("BackPack Off", "Katana");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.NNEAHAFBOHC().GBKMHIGNKJA(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("PersonManFisher", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(1L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("first bone position is the same as second bone position.", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("wpn_eat1", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_threshold", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("#ffffff", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A51 RID: 31313 RVA: 0x003AACE4 File Offset: 0x003A8EE4
		public void KPOMDPLHMHG(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.AEIIBNOFLCM();
				this.OLNGOHEPLBO.color = new Color(430f, 1658f, 924f, 906f);
			}
		}

		// Token: 0x06007A52 RID: 31314 RVA: 0x003AAD34 File Offset: 0x003A8F34
		public void AJKCFKCBEPC(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.IOMNHBMOGLG();
				this.OLNGOHEPLBO.color = new Color(1009f, 1558f, 735f, 1478f);
			}
		}

		// Token: 0x06007A53 RID: 31315 RVA: 0x003AAD84 File Offset: 0x003A8F84
		public string GNONKCKHIJH(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 2 || this.HMDHFAKPMJD == 6)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.NNEAHAFBOHC().LMGMPPAOPEP(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("t_shoes", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("1HandSwordChargeHeavyBash", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace(" x", JNBICAJIJMM.EDKGBBIIBBC().CCFFMKBBKHI("OneHandSwordRun"));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("IdleSpew", "qd_prise_exp");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.AGCBLDIBMNB().IMCJNFHAFGE(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("_InvViewProj", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("C", JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("\n", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("L", string.Concat(0));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("gi_inte_1", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("</color>", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("sunshine_ShadowCoordDepthRayZ", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A54 RID: 31316 RVA: 0x003AAF14 File Offset: 0x003A9114
		public void JOPNLDGJNFD(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.NIOGJOFLPLH();
				this.OLNGOHEPLBO.color = new Color(1197f, 574f, 1504f, 558f);
			}
		}

		// Token: 0x06007A55 RID: 31317 RVA: 0x003AAF64 File Offset: 0x003A9164
		public virtual void MFEIIOJLAOA(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.CONHGLCNKHE(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 1;
			if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "CheckResources () for ";
			if (Application.isEditor)
			{
				object[] array = new object[4];
				array[0] = this.PCPMJEDBDKO;
				array[0] = "StartRigidModule";
				array[1] = this.FHNGFNCIPBP;
				array[1] = "abcd";
				str = string.Concat(array);
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().text = this.KBEPOLDLABE(this.DBPACEJBBNL);
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = "SexyDance3" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[5].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
			}
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.BOIIMMKPGHJ(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[3].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-83].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 0 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				IKPEEEBENDE[55].gameObject.SetActive(true);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.IKGFHGKKCPG.FKKFALIBPCF(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.KJDGIFNFGPL));
				return;
			}
			IKPEEEBENDE[7].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A56 RID: 31318 RVA: 0x003AB290 File Offset: 0x003A9490
		public override void IIBOLKLPAIN(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.KADJFNIOPEO(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 1;
			if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "_Radius";
			if (Application.isEditor)
			{
				object[] array = new object[6];
				array[1] = this.PCPMJEDBDKO;
				array[0] = "actor instaniateReel 4 ";
				array[3] = this.FHNGFNCIPBP;
				array[3] = "Vertical";
				str = string.Concat(array);
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.BBNHICAOOFM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().text = this.JPFLFCMKKGJ(this.DBPACEJBBNL);
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().text = "StaffStand" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[5].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.MECJHEKFKKP(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[5].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[111].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				IKPEEEBENDE[-36].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.IKGFHGKKCPG.FKKFALIBPCF(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.FCJGHFAKKNE));
				return;
			}
			IKPEEEBENDE[8].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A57 RID: 31319 RVA: 0x003AB5BC File Offset: 0x003A97BC
		public virtual void KEBMCOAFNKF(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[1].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[6].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "autherror";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("cancel", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("_SampleScale", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("Mouse ScrollWheel", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A58 RID: 31320 RVA: 0x003AB75C File Offset: 0x003A995C
		public virtual void KJCNNHGGELK(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.CONHGLCNKHE(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 1;
			if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "template";
			if (Application.isEditor)
			{
				object[] array = new object[3];
				array[0] = this.PCPMJEDBDKO;
				array[1] = "Bias";
				array[4] = this.FHNGFNCIPBP;
				array[7] = "XC";
				str = string.Concat(array);
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.BBNHICAOOFM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = this.JPFLFCMKKGJ(this.DBPACEJBBNL);
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = "[Z]" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[1].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
			}
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.KEBGFJDMLLH(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[8].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-18].gameObject.SetActive(true);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[-115].gameObject.SetActive(true);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 0)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().IHOFGFGLNBM(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.HFBOCBLODCD));
				return;
			}
			IKPEEEBENDE[3].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A59 RID: 31321 RVA: 0x003ABA88 File Offset: 0x003A9C88
		public void LBPLLHJOLFC(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.PFFJJEJNKPB();
				this.OLNGOHEPLBO.color = new Color(1381f, 183f, 448f, 1995f);
			}
		}

		// Token: 0x06007A5A RID: 31322 RVA: 0x003ABAD8 File Offset: 0x003A9CD8
		public string PKKEHGLBKDE(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 3 || this.HMDHFAKPMJD == 6)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.EDKKJNHDBPF().LMGMPPAOPEP(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("demoByteArray", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace(" с", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("msgOk", JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("rod_inf2"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("6", "");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.EDKKJNHDBPF().NKMGKJLONDK(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("</color></i>", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("FOG_LINEAR", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(1L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("http://www.root-motion.com/finalikdox/html/page7.html", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("FBIK chain length is 0, can't initiate solver.", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("WoodCut", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("SUNSHINE_OVERCAST_ON", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Road Points Marker", JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A5B RID: 31323 RVA: 0x003ABC68 File Offset: 0x003A9E68
		public virtual void DLKBOEANPKI(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[4].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[7].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				this.KLGAIAGBPCD.text = "1HandSwordChargeSwipe";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = false;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("PER_VERTEX", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("WandAttack2", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("wpn", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A5C RID: 31324 RVA: 0x003ABE08 File Offset: 0x003AA008
		public virtual void PHBKNOKGIOD(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[3].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = " ";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("KatanaReady", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("<color='#606080'>+{0}</color>", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("Roller Blade Turn Left", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A5D RID: 31325 RVA: 0x003ABFA8 File Offset: 0x003AA1A8
		public virtual void FJIEOCLFPLP(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.CONHGLCNKHE(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "IdleReadyLook";
			if (Application.isEditor)
			{
				object[] array = new object[0];
				array[0] = this.PCPMJEDBDKO;
				array[0] = "qd_tasktime";
				array[4] = this.FHNGFNCIPBP;
				array[5] = "GiantGrabThrow";
				str = string.Concat(array);
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = this.ECCIJAFICIA(this.DBPACEJBBNL);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = "R to reset fog." + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[5].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.MECJHEKFKKP(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[2].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-85].gameObject.SetActive(true);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				IKPEEEBENDE[-127].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().GFPOJNDPMLC(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.OLDHFJMJMKP));
				return;
			}
			IKPEEEBENDE[8].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A5E RID: 31326 RVA: 0x003AC2D4 File Offset: 0x003AA4D4
		public string DAMLMDFDOAO(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 2 || this.HMDHFAKPMJD == 4)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().NKMGKJLONDK(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("FlyRight", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("OneHandSwordBlock", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("_Slope", JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("MotorbikeLookBack"));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("TYPES", "frnd_ingame");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.JHAAMBEFENP().GBKMHIGNKJA(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("Button", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Handstand", JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("---", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("name", string.Concat(0));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("WizardPowerUp", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Flap_07.wav", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("PaperTurn.wav", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A5F RID: 31327 RVA: 0x003AC464 File Offset: 0x003AA664
		public void HBKFOAKPNNH(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.PFFJJEJNKPB();
				this.OLNGOHEPLBO.color = new Color(499f, 1716f, 1421f, 1118f);
			}
		}

		// Token: 0x06007A60 RID: 31328 RVA: 0x003AC4B4 File Offset: 0x003AA6B4
		public virtual void MCAJOPLHLEJ(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[7].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[5].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "_SecondTex";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = false;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("FBIK chain is null, can't initiate solver.", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("_FogSkyData", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("ScatterIntensityVolumeSky", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A61 RID: 31329 RVA: 0x003AC654 File Offset: 0x003AA854
		public void CKHHDJOIGLD(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.ANLLGCICOPP();
				this.OLNGOHEPLBO.color = new Color(195f, 1685f, 1825f, 1249f);
			}
		}

		// Token: 0x06007A62 RID: 31330 RVA: 0x003AC6A4 File Offset: 0x003AA8A4
		public string BMNPGIJDINK(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 1 || this.HMDHFAKPMJD == 1)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.EDKKJNHDBPF().GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("enableFog", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("\n", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("FlyForward", JNBICAJIJMM.IMLLGEMPHAP().GNKIBMGNHNE("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_full_body_biped_i_k.html"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("Start Interaction With ", "NOISE_ON");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.EDKKJNHDBPF().IMCJNFHAFGE(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("name", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("IKSolverLookAt eyes setup is invalid. Can't initiate solver.", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace(": ", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace(" for ", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace(" is represented multiple times in BipedReferences eyes.", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("GiantGrabIdle", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("SecondaryCausticsProjector", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A63 RID: 31331 RVA: 0x003AC834 File Offset: 0x003AAA34
		public override void IOJIPCHOIGC(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[1].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[6].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				this.KLGAIAGBPCD.text = "800000";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("Hidden/Post FX/Blit", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("ClimbUp", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("Отпущено {0} рыб, общим весом \n<color='#a000ff'>{1}</color>\nПолучено {2} опыта", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A64 RID: 31332 RVA: 0x003AC9D4 File Offset: 0x003AABD4
		public string PDOCKLOEFED(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 4 || this.HMDHFAKPMJD == 1)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().LMGMPPAOPEP(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("fishsplash{0}.ogg", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("_R_", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("MotorbikeLasso", JNBICAJIJMM.APMJBBDBOJO().HEIBEHAEHBM("value"));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("Mouse Y", "UV0");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.OELKEADDKPE().IMCJNFHAFGE(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("IceHockeyDekeMiddle", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Text node is empy!", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("stretchWidth", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("https://www.youtube.com/watch?v=wT8fViZpLmQ", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Cowboy1HandDraw", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A65 RID: 31333 RVA: 0x003ACB64 File Offset: 0x003AAD64
		public override void CLOEOBIEGKM(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[2].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[2].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				this.KLGAIAGBPCD.text = "Weapon Run Backward";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = false;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("Cloth_01.wav", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("SPACE", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A66 RID: 31334 RVA: 0x003ACD04 File Offset: 0x003AAF04
		public void CKOMEOHDOBF(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.NIOGJOFLPLH();
				this.OLNGOHEPLBO.color = new Color(1866f, 501f, 619f, 1689f);
			}
		}

		// Token: 0x06007A67 RID: 31335 RVA: 0x003ACD54 File Offset: 0x003AAF54
		public string PIJKGGPLAKB(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 2 || this.HMDHFAKPMJD == 0)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OOIJFNAMEDP().NKMGKJLONDK(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("Life bar: ", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("_FarCorner", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("low_root_level", JNBICAJIJMM.EEOPOHEALPK().CCFFMKBBKHI("Thumb"));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("", "openPodsak");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.EDKKJNHDBPF().LMGMPPAOPEP(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("_TraceBehindObjects", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("SoundMgr is init part 2", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(1L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("pf1m", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("USE_MASK", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("FONT", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Foot", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("MotorbikeShootBack", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A68 RID: 31336 RVA: 0x003ACEE4 File Offset: 0x003AB0E4
		public virtual void DGABHJOHIHE(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.KBBCBFJINNG(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "Player";
			if (Application.isEditor)
			{
				object[] array = new object[8];
				array[1] = this.PCPMJEDBDKO;
				array[0] = " ";
				array[7] = this.FHNGFNCIPBP;
				array[3] = "gi_letgoshe";
				str = string.Concat(array);
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = this.AFJEOLCNIHB(this.DBPACEJBBNL);
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().text = "button" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[6].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.HDLGMNLFDLB(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[4].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-71].gameObject.SetActive(true);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[4].gameObject.SetActive(true);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 0)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().FKKFALIBPCF(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.CBFLNEFBJMN));
				return;
			}
			IKPEEEBENDE[0].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A69 RID: 31337 RVA: 0x003AD210 File Offset: 0x003AB410
		public void CPOICDLANEB(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.EIMNFFAAHLI();
				this.OLNGOHEPLBO.color = new Color(1543f, 691f, 589f, 1906f);
			}
		}

		// Token: 0x06007A6A RID: 31338 RVA: 0x003AD260 File Offset: 0x003AB460
		public virtual void LDFLEGLPPNO(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.CONHGLCNKHE(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "jamp";
			if (Application.isEditor)
			{
				object[] array = new object[7];
				array[1] = this.PCPMJEDBDKO;
				array[1] = "RunDive";
				array[1] = this.FHNGFNCIPBP;
				array[2] = "";
				str = string.Concat(array);
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = this.LJGCAMJKDDI(this.DBPACEJBBNL);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = "FBIKBendGoal is deprecated, you can now a bend goal from the custom inspector of the FullBodyBipedIK component." + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[3].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.KEBGFJDMLLH(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[3].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[10].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				IKPEEEBENDE[10].gameObject.SetActive(true);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.IKGFHGKKCPG.GFPOJNDPMLC(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.OJPEKNEAOGH));
				return;
			}
			IKPEEEBENDE[8].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A6B RID: 31339 RVA: 0x003AD58C File Offset: 0x003AB78C
		public void MBALDMGIHGF(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.KEDGAOBCNJG;
				this.OLNGOHEPLBO.color = new Color(750f, 691f, 1528f, 492f);
			}
		}

		// Token: 0x06007A6C RID: 31340 RVA: 0x003AD5DC File Offset: 0x003AB7DC
		public string CJKLJONCBAC(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 1 || this.HMDHFAKPMJD == 8)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().IMCJNFHAFGE(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("_FoamContrast", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("Use!", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("_ExposureCompensation", JNBICAJIJMM.LPHMKPDBMPP().FLEANFGEJML("knopje.wav"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("PaperTurn.wav", "Backward Stand");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.NNEAHAFBOHC().GBKMHIGNKJA(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("Quest loaded done", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Idle Dodge Right", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(1L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("emergencyMode", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("IdleSpew", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("camouflage_id", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("shop_t8", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace(" ?", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A6D RID: 31341 RVA: 0x003AD76C File Offset: 0x003AB96C
		public string CBBBBILOJFN(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 5 || this.HMDHFAKPMJD == 0)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.JHAAMBEFENP().IMCJNFHAFGE(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("Bezier curve must have two or more control points!", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("Tops", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("</color>", JNBICAJIJMM.CLIMNFDGOEG().NLJOLOBPCBJ("CrouchWalkBackward"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("Fishing", "1");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.AGCBLDIBMNB().IMCJNFHAFGE(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("Vertical", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Hip", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(1L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("WRINKLE_MAPS", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("MotorbikeShootFwd", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("(", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("loc", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("IKSolverFABRIKRoot chain at index ", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A6E RID: 31342 RVA: 0x003AD8FC File Offset: 0x003ABAFC
		public void COHKJDDAKFA(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.AEIIBNOFLCM();
				this.OLNGOHEPLBO.color = new Color(1546f, 1847f, 609f, 1469f);
			}
		}

		// Token: 0x06007A6F RID: 31343 RVA: 0x003AD94C File Offset: 0x003ABB4C
		public string MOICHKEGIDA(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 3 || this.HMDHFAKPMJD == 8)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.IMCJNFHAFGE(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("rollTENSIONKG=", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("crft_useres", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("choldposx", JNBICAJIJMM.EEOPOHEALPK().DOEMGEAEBPN("Turn"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("_TintColor", "saleToShop");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.IKGFHGKKCPG.IMCJNFHAFGE(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("_RgbTex", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("inv_invheader", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("repair.ogg", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("", string.Concat(0));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Delete", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("http://www.root-motion.com/finalikdox/html/page12.html", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Idle Fly", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A70 RID: 31344 RVA: 0x003ADADC File Offset: 0x003ABCDC
		public void HNGEECMPLOB(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.PFFJJEJNKPB();
				this.OLNGOHEPLBO.color = new Color(1430f, 1506f, 1999f, 1488f);
			}
		}

		// Token: 0x06007A71 RID: 31345 RVA: 0x003ADB2C File Offset: 0x003ABD2C
		public void HFBOCBLODCD(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.LECMGDEDAKF();
				this.OLNGOHEPLBO.color = new Color(1911f, 1627f, 58f, 806f);
			}
		}

		// Token: 0x06007A72 RID: 31346 RVA: 0x003ADB7C File Offset: 0x003ABD7C
		public virtual void NOGBEGPCFBP(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.CONHGLCNKHE(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "<color='#003000'>";
			if (Application.isEditor)
			{
				object[] array = new object[6];
				array[1] = this.PCPMJEDBDKO;
				array[1] = "WeaponInstant";
				array[4] = this.FHNGFNCIPBP;
				array[2] = "IdleStrafeRight";
				str = string.Concat(array);
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = this.CGIMCHPIBAK(this.DBPACEJBBNL);
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = "IdleButtonPress" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[8].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.MECJHEKFKKP(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[3].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-121].gameObject.SetActive(true);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[107].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 0)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().IHOFGFGLNBM(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.HBKFOAKPNNH));
				return;
			}
			IKPEEEBENDE[5].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A73 RID: 31347 RVA: 0x003ADEA8 File Offset: 0x003AC0A8
		public virtual void DNHEGIFKAMP(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[1].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "WeaponRun";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("IdleSlide", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 0)
				{
					this.KLGAIAGBPCD.text = string.Format(" x", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("1HSwordStrafeRunLeft", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A74 RID: 31348 RVA: 0x003AE048 File Offset: 0x003AC248
		public string AFJEOLCNIHB(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 6 || this.HMDHFAKPMJD == 4)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.IMCJNFHAFGE(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("Materials/VolumetricFog", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("Sitting Reading Lean Back", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n", JNBICAJIJMM.EDKGBBIIBBC().HEIBEHAEHBM(" not found"));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("Body", "offsets");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.OOIJFNAMEDP().GBKMHIGNKJA(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("Horizontal", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("#02C85F", JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("double: ", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("reqperk", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("#402000", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_Color", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A75 RID: 31349 RVA: 0x003AE1D8 File Offset: 0x003AC3D8
		public string LJGCAMJKDDI(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 1 || this.HMDHFAKPMJD == 7)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OOIJFNAMEDP().NKMGKJLONDK(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("_Intensity", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("Billboards reference not set.", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("Ban OK. Object:", JNBICAJIJMM.APMJBBDBOJO().CCFFMKBBKHI("money2.wav"));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("nowp", "_Color");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.JHAAMBEFENP().GBKMHIGNKJA(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("IdleButtonPress", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_ProjInfoRight", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_Offsets", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("", string.Concat(0));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_Power", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("[ACTk] WallHack Detector: can't be started since it doesn't exists in scene or not yet initialized!", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("(", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A76 RID: 31350 RVA: 0x003AE368 File Offset: 0x003AC568
		public void OJPEKNEAOGH(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.EJOLKDKEKCG();
				this.OLNGOHEPLBO.color = new Color(1662f, 273f, 757f, 542f);
			}
		}

		// Token: 0x06007A77 RID: 31351 RVA: 0x003AE3B8 File Offset: 0x003AC5B8
		public string OCIANCHCPKP(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 6 || this.HMDHFAKPMJD == 6)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().NKMGKJLONDK(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("UnityEngine.Color", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("***Wpn Lots event ", JNBICAJIJMM.IMLLGEMPHAP().HLBAJBLHLNI("\n"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("LOC_NAMES", "_WaterMap");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("catid", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("enable", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("DropType", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("ThisRenderer.bones[i].name is null", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_Contrast", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("invn_rec5", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Giant3HitCombo2", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A78 RID: 31352 RVA: 0x003AE548 File Offset: 0x003AC748
		public void KJDGIFNFGPL(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.IOMNHBMOGLG();
				this.OLNGOHEPLBO.color = new Color(1808f, 709f, 861f, 384f);
			}
		}

		// Token: 0x06007A79 RID: 31353 RVA: 0x003AE598 File Offset: 0x003AC798
		public virtual void EGGLICFLLON(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.BPIGOGBBHLP(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 1;
			if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = " ";
			if (Application.isEditor)
			{
				object[] array = new object[5];
				array[1] = this.PCPMJEDBDKO;
				array[0] = ", ";
				array[5] = this.FHNGFNCIPBP;
				array[3] = "_LightPosition";
				str = string.Concat(array);
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.OHMFDNHNKFN(this.DBPACEJBBNL);
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = "OneHandSwordSwing" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[7].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
			}
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.PEJJOKHOLMF(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[8].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[30].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 0 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[27].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 0)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().GFPOJNDPMLC(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.CKHHDJOIGLD));
				return;
			}
			IKPEEEBENDE[1].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A7A RID: 31354 RVA: 0x003AE8C4 File Offset: 0x003ACAC4
		public virtual void CKEADHDIJAO(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.CONHGLCNKHE(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "GestureNoFear";
			if (Application.isEditor)
			{
				object[] array = new object[1];
				array[1] = this.PCPMJEDBDKO;
				array[1] = ".png";
				array[5] = this.FHNGFNCIPBP;
				array[3] = "Error - ";
				str = string.Concat(array);
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.BBNHICAOOFM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().text = this.FCDBBPLBLBN(this.DBPACEJBBNL);
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = "Mech" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[7].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.PEJJOKHOLMF(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[3].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-118].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 0 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[-87].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.IKGFHGKKCPG.GFPOJNDPMLC(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.CKOMEOHDOBF));
				return;
			}
			IKPEEEBENDE[6].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A7B RID: 31355 RVA: 0x003AEBF0 File Offset: 0x003ACDF0
		public void KJHHPGDELEM(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.IOMNHBMOGLG();
				this.OLNGOHEPLBO.color = new Color(1808f, 14f, 1599f, 1267f);
			}
		}

		// Token: 0x06007A7C RID: 31356 RVA: 0x003AEC40 File Offset: 0x003ACE40
		public virtual void DMIICJFCNBH(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.BPIGOGBBHLP(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "Actor";
			if (Application.isEditor)
			{
				object[] array = new object[3];
				array[1] = this.PCPMJEDBDKO;
				array[0] = "IdleTurns";
				array[8] = this.FHNGFNCIPBP;
				array[4] = "Mirror Refl Camera id";
				str = string.Concat(array);
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = this.KFBAPPLPHEF(this.DBPACEJBBNL);
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = "Horizontal" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[3].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.HDLGMNLFDLB(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[4].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-92].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				IKPEEEBENDE[-82].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 0)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().FKKFALIBPCF(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.HKIECBCNEDG));
				return;
			}
			IKPEEEBENDE[0].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A7D RID: 31357 RVA: 0x003AEF6C File Offset: 0x003AD16C
		public virtual void FNEIPGNIBEE(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[2].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[5].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "only_one";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("_BlurTexture", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("wpn_tank2", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("3", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A7E RID: 31358 RVA: 0x003AF10C File Offset: 0x003AD30C
		public virtual void HEDPAFDCIHH(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[1].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[5].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				this.KLGAIAGBPCD.text = "Flares";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("{0}", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("Apply RELANG", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("1 Hand Sword Jab ready strafe left", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A7F RID: 31359 RVA: 0x003AF2AC File Offset: 0x003AD4AC
		public virtual void BAOGLNMFMFJ(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.KBBCBFJINNG(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "OneHandSwordReady";
			if (Application.isEditor)
			{
				object[] array = new object[]
				{
					this.PCPMJEDBDKO,
					"Shoot Right",
					null,
					null,
					this.FHNGFNCIPBP
				};
				array[4] = "No Template! ID=";
				str = string.Concat(array);
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.BBNHICAOOFM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = this.AFJEOLCNIHB(this.DBPACEJBBNL);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = "DISTANCE_CUTOFF_OFF" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[3].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.MECJHEKFKKP(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[3].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-122].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[-109].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 0)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().GFPOJNDPMLC(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.JOPNLDGJNFD));
				return;
			}
			IKPEEEBENDE[4].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A80 RID: 31360 RVA: 0x003AF5D8 File Offset: 0x003AD7D8
		public virtual void JNCENEOIPBD(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[5].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "WorkerPickaxe2";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("invn_rec23", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("wpn_eat6", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("\n", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A81 RID: 31361 RVA: 0x003AF778 File Offset: 0x003AD978
		public virtual void BJHHHGAMAJI(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[4].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[2].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "isMoving";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = false;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("IceHockeyGoalieReady", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("1HandSwordStrafeLeft", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A82 RID: 31362 RVA: 0x003AF918 File Offset: 0x003ADB18
		public string KFBAPPLPHEF(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 5 || this.HMDHFAKPMJD == 3)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().IMCJNFHAFGE(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("-none-", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("6", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("</color>", JNBICAJIJMM.EEOPOHEALPK().CKAOHMEKLMH("No IK assigned in HitReaction"));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("gi_nlheader2", "ENABLE_COLOR_GRADING");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.OOIJFNAMEDP().GBKMHIGNKJA(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("gi_uinf_6", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("SelfBleedReduction", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC(1L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Hidden/DepthOfField/BokehSplatting", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("FlyUp", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace(" from ", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("GiantEat", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("ControlledPlayer", JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A83 RID: 31363 RVA: 0x003AFAA8 File Offset: 0x003ADCA8
		public override void OIBMJLCALOJ(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[2].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "buykey";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("StaffStand", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("inv_inv", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("size", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A84 RID: 31364 RVA: 0x003AFC48 File Offset: 0x003ADE48
		public virtual void PBFGKGCFECB(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.KBBCBFJINNG(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 1;
			if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "";
			if (Application.isEditor)
			{
				object[] array = new object[3];
				array[1] = this.PCPMJEDBDKO;
				array[1] = "http://af-2.ru/?q=store";
				array[5] = this.FHNGFNCIPBP;
				array[6] = "Speed";
				str = string.Concat(array);
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.BBNHICAOOFM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = this.DNKBNHKKCGE(this.DBPACEJBBNL);
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = "GiantGrabIdle2" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[6].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.PEJJOKHOLMF(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[0].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[79].gameObject.SetActive(true);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[4].gameObject.SetActive(true);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().FKKFALIBPCF(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.JOPNLDGJNFD));
				return;
			}
			IKPEEEBENDE[7].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A85 RID: 31365 RVA: 0x003AFF74 File Offset: 0x003AE174
		public virtual void NDHNJEEKPIK(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.KBBCBFJINNG(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 1;
			if (JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "OfficeSittingEyesRub";
			if (Application.isEditor)
			{
				object[] array = new object[4];
				array[1] = this.PCPMJEDBDKO;
				array[1] = "{0} FPS";
				array[2] = this.FHNGFNCIPBP;
				array[0] = "Swim";
				str = string.Concat(array);
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().text = this.IGBNHDPGGKH(this.DBPACEJBBNL);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = "category" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[2].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.MECJHEKFKKP(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[5].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-69].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				IKPEEEBENDE[-95].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 0)
			{
				CKNLPGEPGGF.IKGFHGKKCPG.IHOFGFGLNBM(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.HKIECBCNEDG));
				return;
			}
			IKPEEEBENDE[2].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A86 RID: 31366 RVA: 0x003B02A0 File Offset: 0x003AE4A0
		public virtual void GDGEJAEGFEC(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[2].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[3].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "_FogWaterLevel";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = false;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("shop_t10", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("[curcnt]", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A87 RID: 31367 RVA: 0x003B0440 File Offset: 0x003AE640
		public virtual void HOPINKAHGIK(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[6].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "componentA=";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("no_task", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("{", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("Giant Grab Throw", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A88 RID: 31368 RVA: 0x003B05E0 File Offset: 0x003AE7E0
		public string NLFAFKOICHN(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 5 || this.HMDHFAKPMJD == 1)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("isBigFish", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("cht_msg21", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("Ready Fight", JNBICAJIJMM.CLIMNFDGOEG().NLJOLOBPCBJ("RussianDance"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("GestureChestPumpSalute", "FireBreath");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.EDKKJNHDBPF().GBKMHIGNKJA(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("IdleStand", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("TOD_LightDirection", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(1L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("TOD_CloudDensity", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("-S", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_RgbTex", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("[Attachments] Failed to find ProBuilder object on the attachments object '{0}'.", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A89 RID: 31369 RVA: 0x003B0770 File Offset: 0x003AE970
		public virtual void AMBDKGDDEJE(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[3].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[7].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "CrawlLocomotion";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = false;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("null", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("Cowboy1HandDraw", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("intensity", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A8A RID: 31370 RVA: 0x003B0910 File Offset: 0x003AEB10
		public string PNNIJDENGBM(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 6 || this.HMDHFAKPMJD == 3)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.JHAAMBEFENP().IMCJNFHAFGE(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("RollerBladeSkateFwd", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("DENSITY", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("IK chain has no Bones.", JNBICAJIJMM.EKEBHIJMEML().CCFFMKBBKHI("Use!"));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("--", "_EmissionColor");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.EDKKJNHDBPF().IMCJNFHAFGE(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("WalkDehydrated", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Mouse X", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("WATERMODE", string.Concat(0));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("IdleRun", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("x2", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("gi_tit_sel", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A8B RID: 31371 RVA: 0x003B0AA0 File Offset: 0x003AECA0
		public virtual void JMGBPNJNPBI(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.KBBCBFJINNG(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 1;
			if (JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "Wand/Staff";
			if (Application.isEditor)
			{
				object[] array = new object[7];
				array[0] = this.PCPMJEDBDKO;
				array[1] = "CUSTOM_COLOR_OFF";
				array[0] = this.FHNGFNCIPBP;
				array[7] = "onHyperLinkActivated: ";
				str = string.Concat(array);
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = this.CBBBBILOJFN(this.DBPACEJBBNL);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = "fshop_ks2" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[3].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
			}
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.PEJJOKHOLMF(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[7].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-115].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 0 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				IKPEEEBENDE[-104].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 0)
			{
				CKNLPGEPGGF.IKGFHGKKCPG.FKKFALIBPCF(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.COHKJDDAKFA));
				return;
			}
			IKPEEEBENDE[7].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A8C RID: 31372 RVA: 0x003B0DCC File Offset: 0x003AEFCC
		public virtual void EIBFANABAIH(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.KBBCBFJINNG(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 1;
			if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "1=";
			if (Application.isEditor)
			{
				object[] array = new object[7];
				array[1] = this.PCPMJEDBDKO;
				array[1] = "ZombieCrawl";
				array[4] = this.FHNGFNCIPBP;
				array[3] = " x";
				str = string.Concat(array);
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.BBNHICAOOFM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = this.IKCGCJCGIPM(this.DBPACEJBBNL);
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = "GrounderIK does not support AimIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead." + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[2].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
			}
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.KEBGFJDMLLH(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[0].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[104].gameObject.SetActive(true);
			if (this.FEIPJJLEDAG > 0 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[-28].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().GFPOJNDPMLC(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.BGGCFGOPHCM));
				return;
			}
			IKPEEEBENDE[6].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A8D RID: 31373 RVA: 0x003B10F8 File Offset: 0x003AF2F8
		public string MNNOCFJLHMP(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 4 || this.HMDHFAKPMJD == 2)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.EDKKJNHDBPF().LMGMPPAOPEP(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("linebreak.ogg", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("MotorbikeHeadstand", JNBICAJIJMM.APMJBBDBOJO().HLBAJBLHLNI("delaccconfirm"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("Hand", "-none-");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.EDKKJNHDBPF().LMGMPPAOPEP(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("#ffffff", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("IdleSlide", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("", JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("|", string.Concat(0));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("post_11", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("UnityEngine.Vector2", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Brow", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A8E RID: 31374 RVA: 0x003B1288 File Offset: 0x003AF488
		public virtual void FODAIILAILN(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.KBBCBFJINNG(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "Bone01";
			if (Application.isEditor)
			{
				object[] array = new object[1];
				array[1] = this.PCPMJEDBDKO;
				array[1] = "MotorbikeLassoBack";
				array[2] = this.FHNGFNCIPBP;
				array[4] = "sunshine_ShadowCoordDepthRayV";
				str = string.Concat(array);
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.BBNHICAOOFM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = this.MOICHKEGIDA(this.DBPACEJBBNL);
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = "_Grain_Params1" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[5].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.HDLGMNLFDLB(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[1].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[73].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[48].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 0)
			{
				CKNLPGEPGGF.IKGFHGKKCPG.FKKFALIBPCF(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.CBFLNEFBJMN));
				return;
			}
			IKPEEEBENDE[6].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A8F RID: 31375 RVA: 0x003B15B4 File Offset: 0x003AF7B4
		public void GCDCMEKHBGD(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.EIMNFFAAHLI();
				this.OLNGOHEPLBO.color = new Color(425f, 1407f, 947f, 1853f);
			}
		}

		// Token: 0x06007A90 RID: 31376 RVA: 0x003B1604 File Offset: 0x003AF804
		public virtual void PDEPNADPDDN(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.KADJFNIOPEO(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "</color>";
			if (Application.isEditor)
			{
				object[] array = new object[7];
				array[1] = this.PCPMJEDBDKO;
				array[0] = "error";
				array[6] = this.FHNGFNCIPBP;
				array[2] = "error";
				str = string.Concat(array);
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = this.FCDBBPLBLBN(this.DBPACEJBBNL);
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = "BackPackSearch" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[2].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.BOIIMMKPGHJ(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[8].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-124].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				IKPEEEBENDE[-107].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 0)
			{
				CKNLPGEPGGF.IKGFHGKKCPG.FKKFALIBPCF(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.HKIECBCNEDG));
				return;
			}
			IKPEEEBENDE[6].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A91 RID: 31377 RVA: 0x003B1930 File Offset: 0x003AFB30
		public void IHGHKABLDBD(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.HFNHCIGCOBE();
				this.OLNGOHEPLBO.color = new Color(722f, 1166f, 1130f, 701f);
			}
		}

		// Token: 0x06007A92 RID: 31378 RVA: 0x003B1980 File Offset: 0x003AFB80
		public virtual void GGOOCAFCEHG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[8].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[3].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				this.KLGAIAGBPCD.text = "[ACTk] Obscured Cheating Detector: can't be started since it doesn't exists in scene or not yet initialized!";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("ShotgunReloadMagazine", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("DealerIdle", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("offsets", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A93 RID: 31379 RVA: 0x003B1B20 File Offset: 0x003AFD20
		public string HPCHOAECDME(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 2 || this.HMDHFAKPMJD == 7)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.EDKKJNHDBPF().GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("name", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("IKMappingSpine is missing the left thigh bone.", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("CratePull", JNBICAJIJMM.EDKGBBIIBBC().NLJOLOBPCBJ("Mouse ScrollWheel"));
			}
			if (this.CKOIFCIHPPP < 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("", "auk buy result: ");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.AGCBLDIBMNB().IMCJNFHAFGE(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("WorkerHammer2", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_Offsets", JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("23", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("SwimFreestyle", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("1HSwordStrafeRunLeft", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_Parameter", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("IKSolverAim poleAxis is Vector3.zero.", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A94 RID: 31380 RVA: 0x003B1CB0 File Offset: 0x003AFEB0
		public string DNKBNHKKCGE(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 1 || this.HMDHFAKPMJD == 7)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().NKMGKJLONDK(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("_ScaleOffsetRes", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("_RefractTex", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("ActorFish", JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("[ACTk] Obscured Cheating Detector: can't be started since it doesn't exists in scene or not yet initialized!"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("ProneLocomotion", "MotorbikeBackwardStand");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.AGCBLDIBMNB().NKMGKJLONDK(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("ui_place_flag.wav", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("SoccerTackle", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("UIChat_fontInterval", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("WizardEyeBeam", string.Concat(0));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("ff2000", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("crunch.ogg", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("wgt_kg", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A95 RID: 31381 RVA: 0x003B1E40 File Offset: 0x003B0040
		public virtual void DOGADPFMOLI(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[2].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[0].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				this.KLGAIAGBPCD.text = "LookUp";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = false;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("[name]", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A96 RID: 31382 RVA: 0x003B1FE0 File Offset: 0x003B01E0
		public string CEIMIJHBGCO(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 3 || this.HMDHFAKPMJD == 5)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().LMGMPPAOPEP(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("* read base id=", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace(">", JNBICAJIJMM.LPHMKPDBMPP().HEIBEHAEHBM(""));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("Attempting to remove texture that was not allocated: {0}", "_FogHeightData");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.IKGFHGKKCPG.LMGMPPAOPEP(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("минуты", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("isNoShowChat", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("fanfare.wav", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("line_type", string.Concat(0));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("cht_msg19", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("GestureCutThroat", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("FacePalm", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A97 RID: 31383 RVA: 0x003B2170 File Offset: 0x003B0370
		public override void AAJMALCKJHE(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[6].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				this.KLGAIAGBPCD.text = "---";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = false;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("{2:D2}:{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("{2}:{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A98 RID: 31384 RVA: 0x003B2310 File Offset: 0x003B0510
		public virtual void OMLPJNBGPNP(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[2].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[5].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				this.KLGAIAGBPCD.text = "error.wav";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = false;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("Current fog preset: ", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("\n", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("OneHandSwordIdle", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007A99 RID: 31385 RVA: 0x003B24B0 File Offset: 0x003B06B0
		public virtual void GCFKLNJLCMF(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.CONHGLCNKHE(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 1;
			if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "wpn_rod4";
			if (Application.isEditor)
			{
				object[] array = new object[1];
				array[1] = this.PCPMJEDBDKO;
				array[1] = "MotorbikeTurnRight";
				array[1] = this.FHNGFNCIPBP;
				array[4] = "No MeshFilter!";
				str = string.Concat(array);
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.GEGBDJCICJN(this.DBPACEJBBNL);
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = "</color>" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[0].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
			}
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.KEBGFJDMLLH(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[5].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[50].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				IKPEEEBENDE[101].gameObject.SetActive(true);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 0)
			{
				CKNLPGEPGGF.IKGFHGKKCPG.GFPOJNDPMLC(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.DHHNFMDOPGH));
				return;
			}
			IKPEEEBENDE[3].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A9A RID: 31386 RVA: 0x003B27DC File Offset: 0x003B09DC
		public override void FOMFEBJINLG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.BPIGOGBBHLP(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 1;
			if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "_NoiseTex";
			if (Application.isEditor)
			{
				object[] array = new object[3];
				array[0] = this.PCPMJEDBDKO;
				array[0] = "auk_head";
				array[3] = this.FHNGFNCIPBP;
				array[1] = "";
				str = string.Concat(array);
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.LGMHLKOECAA(this.DBPACEJBBNL);
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = "firsStartInfoPanel" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[2].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.PEJJOKHOLMF(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[2].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[97].gameObject.SetActive(false);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[-88].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 0)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().FKKFALIBPCF(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.KJHHPGDELEM));
				return;
			}
			IKPEEEBENDE[3].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A9B RID: 31387 RVA: 0x003B2B08 File Offset: 0x003B0D08
		public void NOPACDGFCIO(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.IOMNHBMOGLG();
				this.OLNGOHEPLBO.color = new Color(1720f, 213f, 1098f, 1531f);
			}
		}

		// Token: 0x06007A9C RID: 31388 RVA: 0x003B2B58 File Offset: 0x003B0D58
		public virtual void NGHHEKHHLGJ(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.KADJFNIOPEO(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 1;
			if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[0].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = " ур. ";
			if (Application.isEditor)
			{
				object[] array = new object[2];
				array[0] = this.PCPMJEDBDKO;
				array[1] = "";
				array[8] = this.FHNGFNCIPBP;
				array[8] = "Kernel";
				str = string.Concat(array);
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().text = this.DAMLMDFDOAO(this.DBPACEJBBNL);
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = "</color>" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[8].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
			}
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.MECJHEKFKKP(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[0].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[55].gameObject.SetActive(true);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				IKPEEEBENDE[82].gameObject.SetActive(false);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().IHOFGFGLNBM(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.KJHHPGDELEM));
				return;
			}
			IKPEEEBENDE[7].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A9D RID: 31389 RVA: 0x003B2E84 File Offset: 0x003B1084
		public string FHOLLNLOJMD(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 2 || this.HMDHFAKPMJD == 8)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.EDKKJNHDBPF().LMGMPPAOPEP(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("Ban action", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("\n", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("textAsset is NULL! Path: Cells", JNBICAJIJMM.LPHMKPDBMPP().HEIBEHAEHBM("The 'BackColor' command requires a color parameter of RRGGBBAA or '?'."));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("WalkInjured", " length is zero.");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.AGCBLDIBMNB().LMGMPPAOPEP(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("Hidden/Post FX/Builtin Debug Views", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("forSex", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("GiantGrabIdle2", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("cntx_teach", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Grounding layers are set to nothing. Please add a ground layer.", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("wpn_hook1", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("' that does not excist in the Node Chain.", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007A9E RID: 31390 RVA: 0x003B3014 File Offset: 0x003B1214
		public virtual void NKPLOEPKGLG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.KADJFNIOPEO(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 1;
			if (JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "JNT_L_Hand";
			if (Application.isEditor)
			{
				object[] array = new object[4];
				array[0] = this.PCPMJEDBDKO;
				array[1] = "Post Process Scatter Shader Missing...";
				array[5] = this.FHNGFNCIPBP;
				array[5] = "costwpn=";
				str = string.Concat(array);
			}
			IKPEEEBENDE[1].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.BBNHICAOOFM(this.FHNGFNCIPBP);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = this.CBBBBILOJFN(this.DBPACEJBBNL);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = "MotorbikeShootRight" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[2].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.PEJJOKHOLMF(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[4].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[-34].gameObject.SetActive(true);
			if (this.FEIPJJLEDAG > 0 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				IKPEEEBENDE[-128].gameObject.SetActive(true);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 1)
			{
				CKNLPGEPGGF.PFOLNEGNIPP().FKKFALIBPCF(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.NOPACDGFCIO));
				return;
			}
			IKPEEEBENDE[6].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007A9F RID: 31391 RVA: 0x003B3340 File Offset: 0x003B1540
		public override void FJBBDHGJKFP(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[4].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				this.KLGAIAGBPCD.text = " ms";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("Walk Injured", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("buykey", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("https://www.youtube.com/watch?v=eP9-zycoHLk", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007AA0 RID: 31392 RVA: 0x003B34E0 File Offset: 0x003B16E0
		public void DHHNFMDOPGH(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.HFNHCIGCOBE();
				this.OLNGOHEPLBO.color = new Color(530f, 306f, 26f, 1125f);
			}
		}

		// Token: 0x06007AA1 RID: 31393 RVA: 0x003B3530 File Offset: 0x003B1730
		public string CGIMCHPIBAK(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 4 || this.HMDHFAKPMJD == 6)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.IMCJNFHAFGE(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("bs_cost", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("Vertical", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("[LH &]", JNBICAJIJMM.IMLLGEMPHAP().GNKIBMGNHNE("_Offsets"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("ClimbIdle", "_AutoExposure");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.OOIJFNAMEDP().NKMGKJLONDK(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("ROPE dst=", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Cells", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Current fog preset: ", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("RollerBladeJump", string.Concat(0));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Server is closed", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Loot", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_MainTex", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007AA2 RID: 31394 RVA: 0x003B36C0 File Offset: 0x003B18C0
		public virtual void GNCENLCOFFG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[2].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[6].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				this.KLGAIAGBPCD.text = "";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("UnityEngine.Vector4", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("OnOperationResponse: Unknow Response", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007AA3 RID: 31395 RVA: 0x003B3860 File Offset: 0x003B1A60
		public virtual void HGBHPHEJPLG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[7].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[3].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "_WaterLevel";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("inv_useeff", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("Make sure you are not placing 2 or more FBBIK effectors of the same chain to exactly the same position.", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("BlackSmithHammer", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007AA4 RID: 31396 RVA: 0x003B3A00 File Offset: 0x003B1C00
		public virtual void GPKMBJIOEOK(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[8].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "RollerBladeStop";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("800000", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("offsets", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007AA5 RID: 31397 RVA: 0x003B3BA0 File Offset: 0x003B1DA0
		public virtual void MAMHFDJCIGK(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.DBPACEJBBNL = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.KBBCBFJINNG(this.PCPMJEDBDKO, this.JOOKAILKHKB);
			Color color = GameInterface.getI.qualityColors[this.KBGHOIJIPJF];
			int num = 0;
			if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF.ContainsKey(this.FHNGFNCIPBP))
			{
				num = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.DHPFKNOBLNF[this.FHNGFNCIPBP].KIAPLLDGFNH;
			}
			if (num == 0)
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = color;
			}
			else
			{
				IKPEEEBENDE[1].gameObject.GetComponent<Image>().color = Color.white;
			}
			string str = "";
			if (Application.isEditor)
			{
				object[] array = new object[5];
				array[1] = this.PCPMJEDBDKO;
				array[0] = "TOD_SunSkyColor";
				array[0] = this.FHNGFNCIPBP;
				array[8] = "PaperTurn.wav";
				str = string.Concat(array);
			}
			IKPEEEBENDE[0].gameObject.GetComponent<Image>().sprite = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.NGAMDONKFIM(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = str + JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.BFGKADMHBFO(this.FHNGFNCIPBP);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = this.GLCKNPKINDE(this.DBPACEJBBNL);
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().color = color;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = this.NKJPKIEPOGH;
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = "Crouch180" + this.ANKBIDMIGJI;
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[7].gameObject.GetComponent<Button>();
			}
			Color color2 = color;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA)
			{
				color2 = Color.red;
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
			}
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().text = BHNDGIPPPCE.IKGFHGKKCPG.MECJHEKFKKP(kfhelhglnmh.PNEDPPPEFFG, this.GBLMLOPEFOA);
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().color = color2;
			this.OLNGOHEPLBO = IKPEEEBENDE[0].gameObject.GetComponent<RawImage>();
			IKPEEEBENDE[33].gameObject.SetActive(true);
			if (this.FEIPJJLEDAG > 1 && this.IOGCILMDGOJ >= this.FEIPJJLEDAG)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				IKPEEEBENDE[-40].gameObject.SetActive(true);
			}
			if (this.PNKNHBJELOB.PLFEJBJOOFJ > 0)
			{
				CKNLPGEPGGF.IKGFHGKKCPG.FKKFALIBPCF(this.PNKNHBJELOB.PLFEJBJOOFJ, new CKNLPGEPGGF.FADFMDIHCIN(this.OPNGMBNCCMA));
				return;
			}
			IKPEEEBENDE[3].gameObject.GetComponent<RectTransform>();
		}

		// Token: 0x06007AA6 RID: 31398 RVA: 0x003B3ECC File Offset: 0x003B20CC
		public void OPNGMBNCCMA(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.PFFJJEJNKPB();
				this.OLNGOHEPLBO.color = new Color(35f, 1899f, 1495f, 930f);
			}
		}

		// Token: 0x06007AA7 RID: 31399 RVA: 0x003B3F1C File Offset: 0x003B211C
		public virtual void HKDDEMOFBDF(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[7].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[1].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				this.KLGAIAGBPCD.text = "BlendDirection";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = false;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("Health bar after few usual operations: ", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format(" iterations for read and write", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("_ChromaticAberration", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007AA8 RID: 31400 RVA: 0x003B40BC File Offset: 0x003B22BC
		public virtual void BFPBDEOLFAB(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[6].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[3].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = false;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("_ALPHABLEND_ON", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("MotorbikeAirWalk", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("knopje.wav", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007AA9 RID: 31401 RVA: 0x003B425C File Offset: 0x003B245C
		public string FCDBBPLBLBN(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 1 || this.HMDHFAKPMJD == 3)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.IMCJNFHAFGE(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("SuicideHeadShot", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("IceHockey Goalie Save 2", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("crft_from", JNBICAJIJMM.EEOPOHEALPK().FLEANFGEJML("{0:f3}"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("SatNightFever", "firsStartMovePanel");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.JHAAMBEFENP().NKMGKJLONDK(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("fshop_msg1", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("u_pass", JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Kernel", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace(" iterations for read and write", string.Concat(0));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("- none -", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("<color='", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007AAA RID: 31402 RVA: 0x003B43EC File Offset: 0x003B25EC
		public string LGMHLKOECAA(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 5 || this.HMDHFAKPMJD == 4)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().NKMGKJLONDK(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("SixStep", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("drink.wav", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace(" iterations for read and write", JNBICAJIJMM.EDKGBBIIBBC().GNKIBMGNHNE("WorkerPickaxe2"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("?", " : ");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.EDKKJNHDBPF().GBKMHIGNKJA(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("IdleTyping", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("IceHockeyDekeMiddle", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Idle Dodge Right", string.Concat(0));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("quests/qdynamic/qd", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("isBreak", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("t_lashes", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007AAB RID: 31403 RVA: 0x003B457C File Offset: 0x003B277C
		public virtual void FJHPBGKKEKC(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[5].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[4].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = true;
				}
				this.KLGAIAGBPCD.text = "brow";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("TYPES", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 0)
				{
					this.KLGAIAGBPCD.text = string.Format("ambientVolume", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("t_hair", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007AAC RID: 31404 RVA: 0x003B471C File Offset: 0x003B291C
		public string IMAFGGPBOFB(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 1)
			{
				if (this.HMDHFAKPMJD == 3 || this.HMDHFAKPMJD == 6)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().IMCJNFHAFGE(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("Giant2HandSlamSwing", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("_CameraWS", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("post_18", JNBICAJIJMM.LPHMKPDBMPP().CKAOHMEKLMH("langRefresh"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace(",", "OfficeSittingReading");
			}
			if (this.MIGBFMILDHD > 1)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.NNEAHAFBOHC().NKMGKJLONDK(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("FS ", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Warp index out of range.", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC(0L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_mesh", JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("", string.Concat(1));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("_NoiseScale", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("RunBackward", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Full Body IK is missing the left thigh node.", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x06007AAD RID: 31405 RVA: 0x003B48AC File Offset: 0x003B2AAC
		public virtual void GFALIBIDMDH(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			if (this.GACACKNJKJN == null)
			{
				this.GACACKNJKJN = IKPEEEBENDE[6].gameObject.GetComponent<Button>();
			}
			if (this.KLGAIAGBPCD == null)
			{
				this.KLGAIAGBPCD = IKPEEEBENDE[8].gameObject.GetComponent<Text>();
			}
			if (this.MGNLHNLJJLD < DateTime.Now)
			{
				if (this.GACACKNJKJN != null)
				{
					this.GACACKNJKJN.interactable = false;
				}
				this.KLGAIAGBPCD.text = "+";
				return;
			}
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
			if (kfhelhglnmh.NCJELEIMHGO(kfhelhglnmh.PNEDPPPEFFG) < this.GBLMLOPEFOA && this.GACACKNJKJN != null)
			{
				this.GACACKNJKJN.interactable = true;
			}
			TimeSpan timeSpan = this.MGNLHNLJJLD - DateTime.Now;
			if (this.KLGAIAGBPCD != null)
			{
				if (timeSpan.Days > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				if (timeSpan.Hours > 1)
				{
					this.KLGAIAGBPCD.text = string.Format("BowReady2", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Hours);
					return;
				}
				this.KLGAIAGBPCD.text = string.Format("Actor_{0}_{1}_ragula", timeSpan.Minutes, timeSpan.Seconds);
			}
		}

		// Token: 0x06007AAE RID: 31406 RVA: 0x003B4A4C File Offset: 0x003B2C4C
		public void MKEHBBAEHEH(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			if (this.OLNGOHEPLBO != null)
			{
				this.OLNGOHEPLBO.texture = NOFCHOFPHAD.MMKLLFCKCAG();
				this.OLNGOHEPLBO.color = new Color(1640f, 742f, 1788f, 261f);
			}
		}

		// Token: 0x06007AAF RID: 31407 RVA: 0x003B4A9C File Offset: 0x003B2C9C
		public string JNDFPBPDKJF(string DHMBNNPDPMO)
		{
			if (this.CKOIFCIHPPP > 0)
			{
				if (this.HMDHFAKPMJD == 2 || this.HMDHFAKPMJD == 1)
				{
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().IMCJNFHAFGE(this.CKOIFCIHPPP);
					if (befchfngomi != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("auk_wcnt", befchfngomi.BNIHFBMEPAB);
					}
				}
				else
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.CKOIFCIHPPP);
					if (idchhhedhdc != null)
					{
						DHMBNNPDPMO = DHMBNNPDPMO.Replace("IdleRun", idchhhedhdc.HAJNMNALBBI);
					}
				}
			}
			if (this.CKOIFCIHPPP == 0)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("post_msg4", JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("wpn_wgt"));
			}
			if (this.CKOIFCIHPPP < 1)
			{
				DHMBNNPDPMO = DHMBNNPDPMO.Replace("_Sensitivity", "DISTORT");
			}
			if (this.MIGBFMILDHD > 0)
			{
				BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.EDKKJNHDBPF().GBKMHIGNKJA(this.MIGBFMILDHD);
				if (befchfngomi2 != null)
				{
					DHMBNNPDPMO = DHMBNNPDPMO.Replace("loc", befchfngomi2.BNIHFBMEPAB);
				}
			}
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC(1L));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("UnityEngine.Vector2", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("inv_invheader", string.Concat(0));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Obscured type cheating detected!", string.Concat(this.NPPJLOBFGBH));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("#a0a0a0", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.KECFBIDINKG));
			DHMBNNPDPMO = DHMBNNPDPMO.Replace("Cloth_07.wav", JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.HIFAKGDHNCM));
			return DHMBNNPDPMO;
		}

		// Token: 0x040011C2 RID: 4546
		public long JMIGDLKKPAE;

		// Token: 0x040011C3 RID: 4547
		public int JOOKAILKHKB;

		// Token: 0x040011C4 RID: 4548
		public int PCPMJEDBDKO;

		// Token: 0x040011C5 RID: 4549
		public int HMDHFAKPMJD;

		// Token: 0x040011C6 RID: 4550
		public int KBGHOIJIPJF;

		// Token: 0x040011C7 RID: 4551
		public int GBLMLOPEFOA;

		// Token: 0x040011C8 RID: 4552
		public int FHNGFNCIPBP;

		// Token: 0x040011C9 RID: 4553
		public int ANKBIDMIGJI;

		// Token: 0x040011CA RID: 4554
		public DateTime MGNLHNLJJLD;

		// Token: 0x040011CB RID: 4555
		public int PNEDPPPEFFG;

		// Token: 0x040011CC RID: 4556
		public int HDELGEDDDCE;

		// Token: 0x040011CD RID: 4557
		public int MIGBFMILDHD;

		// Token: 0x040011CE RID: 4558
		public int NPPJLOBFGBH;

		// Token: 0x040011CF RID: 4559
		public int CKOIFCIHPPP;

		// Token: 0x040011D0 RID: 4560
		public int GJHHMCNLCNL;

		// Token: 0x040011D1 RID: 4561
		public int KECFBIDINKG;

		// Token: 0x040011D2 RID: 4562
		public int HIFAKGDHNCM;

		// Token: 0x040011D3 RID: 4563
		public int IOGCILMDGOJ;

		// Token: 0x040011D4 RID: 4564
		public int FEIPJJLEDAG;

		// Token: 0x040011D5 RID: 4565
		public EJDGMNEEOGN.EMOEAOFEKCO PNKNHBJELOB;

		// Token: 0x040011D6 RID: 4566
		public string BJLIBIPBOBE;

		// Token: 0x040011D7 RID: 4567
		public string DBPACEJBBNL;

		// Token: 0x040011D8 RID: 4568
		public string NKJPKIEPOGH;

		// Token: 0x040011D9 RID: 4569
		private RawImage OLNGOHEPLBO;

		// Token: 0x040011DA RID: 4570
		private Button GACACKNJKJN;

		// Token: 0x040011DB RID: 4571
		private Text KLGAIAGBPCD;
	}
}
