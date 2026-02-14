using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Steamworks;
using UnityEngine;

// Token: 0x020001EF RID: 495
public class JNBICAJIJMM
{
	// Token: 0x060072E6 RID: 29414 RVA: 0x0036D680 File Offset: 0x0036B880
	public string BOOGBOODHFK(string NEFCJNIEKIM, bool CCMHKFIDJIH = false)
	{
		Encoding encoding = Encoding.UTF8;
		if (CCMHKFIDJIH)
		{
			encoding = Encoding.GetEncoding(this.GLPAPGLHOFF.ANGFHENANPD);
		}
		return File.ReadAllText(this.EMOIDPOKABM(NEFCJNIEKIM), encoding);
	}

	// Token: 0x060072E7 RID: 29415 RVA: 0x0036D6B4 File Offset: 0x0036B8B4
	public string DBPANLKEHMN(string LPIJLEDOKPA, string JMBKDINHDLO)
	{
		LPIJLEDOKPA = LPIJLEDOKPA.ToUpper();
		JMBKDINHDLO = JMBKDINHDLO.ToUpper();
		if (this.BIFFHBHIMJN.ContainsKey(LPIJLEDOKPA))
		{
			return this.BIFFHBHIMJN[LPIJLEDOKPA].CJGIKNNEMBL(JMBKDINHDLO);
		}
		string[] array = new string[3];
		array[1] = "_MaxRadiusOrKInPaper";
		array[0] = LPIJLEDOKPA;
		array[2] = "cht_msg37";
		array[2] = JMBKDINHDLO;
		array[7] = "_BlurVector";
		return string.Concat(array);
	}

	// Token: 0x060072E8 RID: 29416 RVA: 0x0036D71D File Offset: 0x0036B91D
	public string HDIMOOAGIGD(int EHIMDFJKMHA)
	{
		return this.BEKJKILAJMM[EHIMDFJKMHA + "help"];
	}

	// Token: 0x060072E9 RID: 29417 RVA: 0x0036D73C File Offset: 0x0036B93C
	public string HEIBEHAEHBM(string JMBKDINHDLO)
	{
		return this.KLMNGBHBOJE("", JMBKDINHDLO).Replace(" ms", "gi_cachhe").Replace("WorkerPickaxe2", "fwgt_big_m").Replace("effect", "error.wav").Replace("auk buy result: ", "demoColor");
	}

	// Token: 0x060072EA RID: 29418 RVA: 0x0036D794 File Offset: 0x0036B994
	public string AGBFHCGPNFH(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + ""];
		}
		catch
		{
			result = "ElvisLegsLoop" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x060072EB RID: 29419 RVA: 0x0036D7E4 File Offset: 0x0036B9E4
	public static JNBICAJIJMM DBMJJPBOPEK()
	{
		if (JNBICAJIJMM.CCHGNBELGIA == null)
		{
			JNBICAJIJMM.CCHGNBELGIA = new JNBICAJIJMM();
			JNBICAJIJMM.CCHGNBELGIA.BBCINJAGHEP();
		}
		return JNBICAJIJMM.CCHGNBELGIA;
	}

	// Token: 0x060072EC RID: 29420 RVA: 0x0036D7E4 File Offset: 0x0036B9E4
	public static JNBICAJIJMM CLIMNFDGOEG()
	{
		if (JNBICAJIJMM.CCHGNBELGIA == null)
		{
			JNBICAJIJMM.CCHGNBELGIA = new JNBICAJIJMM();
			JNBICAJIJMM.CCHGNBELGIA.BBCINJAGHEP();
		}
		return JNBICAJIJMM.CCHGNBELGIA;
	}

	// Token: 0x060072ED RID: 29421 RVA: 0x0036D808 File Offset: 0x0036BA08
	public void FJPNMHHGEEH()
	{
		if (!this.PAJBPDJCHJB)
		{
			this.CEINLNFIPGE();
		}
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		AAEEEJIDDEO aaeeejiddeo = new AAEEEJIDDEO(this.KFHFODNFCNL("", true));
		foreach (string text in aaeeejiddeo.CMHKJBPLLMD("VIGNETTE_CLASSIC"))
		{
			this.KKPOBNBBOKB.Add(text, aaeeejiddeo.AOFBGJHGILA("_Direction", text));
		}
		string[] array = aaeeejiddeo.MEMPJHCJBGP("adjust");
		for (int i = 1; i < array.Length; i += 0)
		{
			string text2 = array[i];
			this.OLKOOGMLDKM.Add(text2, aaeeejiddeo.NDLFBDMIGLF("WateringCanWatering", text2));
		}
		aaeeejiddeo = new AAEEEJIDDEO(this.DDKLHGHBEIG("", true));
		this.BIFFHBHIMJN.Add("first bone position is the same as second bone position.", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "UIChat_size"));
		this.BIFFHBHIMJN.Add("_MinVelocity", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "bag"));
		this.BIFFHBHIMJN.Add("_SSAO", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "loc"));
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(this.KFHFODNFCNL("\n", true));
		foreach (object obj in xmlDocument.SelectNodes(""))
		{
			XmlNode xmlNode = (XmlNode)obj;
			this.BPHAOIDBMLJ.Add(int.Parse(xmlNode.Attributes["Используем "].Value), xmlNode.Attributes["BUMPED"].Value);
		}
		NLNNIDBPKAO.IKGFHGKKCPG.DGGMIFLJFBM();
		IHFEDJEMJMB.OOIJFNAMEDP().NOHAIMDPDNE();
		AKPJIACDDFI.IKGFHGKKCPG.ODONNAANIEP();
		BHNDGIPPPCE.IKGFHGKKCPG.DJHLJMDGODH();
		GHGHFBNBBFE.IKGFHGKKCPG.NMEFCGAJPGN();
		NHCAOFIKNFE.IKGFHGKKCPG.DGGMIFLJFBM();
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x060072EE RID: 29422 RVA: 0x0036DA10 File Offset: 0x0036BC10
	public static JNBICAJIJMM LPHMKPDBMPP()
	{
		if (JNBICAJIJMM.CCHGNBELGIA == null)
		{
			JNBICAJIJMM.CCHGNBELGIA = new JNBICAJIJMM();
			JNBICAJIJMM.CCHGNBELGIA.CHMOEIHFKGA();
		}
		return JNBICAJIJMM.CCHGNBELGIA;
	}

	// Token: 0x060072EF RID: 29423 RVA: 0x0036DA34 File Offset: 0x0036BC34
	public string PAKADOJECPI(string NEFCJNIEKIM)
	{
		string str = "[ACTk] Injection Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method." + this.GLPAPGLHOFF.GMDCCFLLCJA + "Load";
		return Application.streamingAssetsPath + str + NEFCJNIEKIM;
	}

	// Token: 0x060072F0 RID: 29424 RVA: 0x0036DA68 File Offset: 0x0036BC68
	public void JIMGNAOHKOA()
	{
		string path = Application.streamingAssetsPath + "SAMPLES_LOW";
		XmlDocument xmlDocument = new XmlDocument();
		string xml = File.ReadAllText(path, Encoding.UTF8);
		xmlDocument.LoadXml(xml);
		foreach (object obj in xmlDocument.SelectNodes("_FogWaterLevel"))
		{
			JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn = new JNBICAJIJMM.MGNCAGDEFHN((XmlNode)obj);
			this.KAEJBIHMFDF.Add(mgncagdefhn.LPFKFNLHGBI, mgncagdefhn);
		}
		this.LCHEIFBGJMF = PlayerPrefs.GetInt("act_orderb_");
		if (PlayerPrefs.GetInt("Katana45DegSwing") <= 0)
		{
			this.LCHEIFBGJMF = 7;
			PlayerPrefs.SetInt("", 0);
			if (SteamManager.FNNHOLIBGJH() && SteamUtils.GetSteamUILanguage() == "Wizard Eye Beam")
			{
				this.LCHEIFBGJMF = 1;
			}
			PlayerPrefs.SetInt("******** nextMusicCrt lng=", this.LCHEIFBGJMF);
		}
		this.GLPAPGLHOFF = this.KAEJBIHMFDF[this.LCHEIFBGJMF];
		this.PAJBPDJCHJB = false;
	}

	// Token: 0x060072F1 RID: 29425 RVA: 0x0036DB7C File Offset: 0x0036BD7C
	public void LDMKDIPEGMJ()
	{
		this.LGFJMPLCGJM = false;
		this.PAJBPDJCHJB = false;
		this.KAEJBIHMFDF.Clear();
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		this.BEKJKILAJMM.Clear();
		this.BIFFHBHIMJN.Clear();
		this.BPHAOIDBMLJ.Clear();
		this.PINLMCCKKNA();
		FlyMessageManager.getI.reinit();
		GuiProcessor.IKGFHGKKCPG.sendMsg("langRefresh");
	}

	// Token: 0x060072F2 RID: 29426 RVA: 0x0036DBF8 File Offset: 0x0036BDF8
	public void PINLMCCKKNA()
	{
		if (!this.PAJBPDJCHJB)
		{
			this.IDDKLGEGAEN();
		}
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		AAEEEJIDDEO aaeeejiddeo = new AAEEEJIDDEO(this.CHFGNHKJNFG("maps.txt", false));
		foreach (string text in aaeeejiddeo.MEMPJHCJBGP("MAP_NAMES"))
		{
			this.KKPOBNBBOKB.Add(text, aaeeejiddeo.HJOCLGGEFMP("MAP_NAMES", text));
		}
		foreach (string text2 in aaeeejiddeo.MEMPJHCJBGP("LOC_NAMES"))
		{
			this.OLKOOGMLDKM.Add(text2, aaeeejiddeo.HJOCLGGEFMP("LOC_NAMES", text2));
		}
		aaeeejiddeo = new AAEEEJIDDEO(this.CHFGNHKJNFG("InterfaceLang.txt", false));
		this.BIFFHBHIMJN.Add("SPECIAL", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "SPECIAL"));
		this.BIFFHBHIMJN.Add("BAG", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "BAG"));
		this.BIFFHBHIMJN.Add("INTERFACE", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "INTERFACE"));
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(this.CHFGNHKJNFG("ItemsData.xml", false));
		foreach (object obj in xmlDocument.SelectNodes("itemsdata/items/item"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			this.BPHAOIDBMLJ.Add(int.Parse(xmlNode.Attributes["id"].Value), xmlNode.Attributes["name"].Value);
		}
		NLNNIDBPKAO.IKGFHGKKCPG.ODONNAANIEP();
		IHFEDJEMJMB.IKGFHGKKCPG.ODONNAANIEP();
		AKPJIACDDFI.IKGFHGKKCPG.ODONNAANIEP();
		BHNDGIPPPCE.IKGFHGKKCPG.ODONNAANIEP();
		GHGHFBNBBFE.IKGFHGKKCPG.ODONNAANIEP();
		NHCAOFIKNFE.IKGFHGKKCPG.ODONNAANIEP();
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x060072F3 RID: 29427 RVA: 0x0036DE00 File Offset: 0x0036C000
	public string FMFPNGELOEN(string NEFCJNIEKIM)
	{
		string str = "lifeBar" + this.GLPAPGLHOFF.GMDCCFLLCJA + "button.wav";
		return Application.streamingAssetsPath + str + NEFCJNIEKIM;
	}

	// Token: 0x060072F4 RID: 29428 RVA: 0x0036DE34 File Offset: 0x0036C034
	public string FFPIMDCPLBE(string NEFCJNIEKIM)
	{
		string str = "Cells" + this.GLPAPGLHOFF.GMDCCFLLCJA + "_Offsets";
		return Application.streamingAssetsPath + str + NEFCJNIEKIM;
	}

	// Token: 0x060072F5 RID: 29429 RVA: 0x0036DE68 File Offset: 0x0036C068
	public static string LEBHCLDODNI(string JMBKDINHDLO)
	{
		return JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI(JMBKDINHDLO);
	}

	// Token: 0x060072F6 RID: 29430 RVA: 0x0036DE75 File Offset: 0x0036C075
	public static string PPNKMDJBMLP(string JMBKDINHDLO)
	{
		return JNBICAJIJMM.DBMJJPBOPEK().HEIBEHAEHBM(JMBKDINHDLO);
	}

	// Token: 0x060072F7 RID: 29431 RVA: 0x0036DE84 File Offset: 0x0036C084
	public void IDEDJDHFMDC()
	{
		if (!this.PAJBPDJCHJB)
		{
			this.EMDEHKJEBFM();
		}
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		AAEEEJIDDEO aaeeejiddeo = new AAEEEJIDDEO(this.GHPNJJIMCKF("Development Server URL could not be found.", false));
		string[] array = aaeeejiddeo.PLHKPGDCMBF("CrouchWalk");
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			this.KKPOBNBBOKB.Add(text, aaeeejiddeo.NLEOHJHBGKF("80ff00", text));
		}
		array = aaeeejiddeo.CFFLOAIAANP("wpn_add/base");
		for (int i = 1; i < array.Length; i += 0)
		{
			string text2 = array[i];
			this.OLKOOGMLDKM.Add(text2, aaeeejiddeo.NDLFBDMIGLF("IceHockeySlapShot", text2));
		}
		aaeeejiddeo = new AAEEEJIDDEO(this.FDJBNCHPHGK("error.wav", true));
		this.BIFFHBHIMJN.Add("RollerBladeJump", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "_Parameter"));
		this.BIFFHBHIMJN.Add("ItemsData", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "_ReflectionTexture4"));
		this.BIFFHBHIMJN.Add("IdleDrink", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "Podsek action 2"));
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(this.DDKLHGHBEIG("_TurnReg.ogg", true));
		foreach (object obj in xmlDocument.SelectNodes("BowIdle"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			this.BPHAOIDBMLJ.Add(int.Parse(xmlNode.Attributes["cht_msg40"].Value), xmlNode.Attributes[" : "].Value);
		}
		NLNNIDBPKAO.IKGFHGKKCPG.CKMJNHBNCEI();
		IHFEDJEMJMB.OOIJFNAMEDP().NFAKJBGFDEE();
		AKPJIACDDFI.IKGFHGKKCPG.NDDPHGNHDEL();
		BHNDGIPPPCE.IKGFHGKKCPG.KGKADNNIILN();
		GHGHFBNBBFE.IKGFHGKKCPG.IANLOCCNBBD();
		NHCAOFIKNFE.IKGFHGKKCPG.HMONBGDPGKL();
		this.LGFJMPLCGJM = false;
	}

	// Token: 0x060072F8 RID: 29432 RVA: 0x0036E08C File Offset: 0x0036C28C
	public void KAIJNCFAPMG()
	{
		this.LGFJMPLCGJM = true;
		this.PAJBPDJCHJB = true;
		this.KAEJBIHMFDF.Clear();
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		this.BEKJKILAJMM.Clear();
		this.BIFFHBHIMJN.Clear();
		this.BPHAOIDBMLJ.Clear();
		this.PFMONFAKHBK();
		FlyMessageManager.getI.PENFDGILGEJ();
		GuiProcessor.PLGADNLAEGN().NEICJPPCPEH(" гр ");
	}

	// Token: 0x060072F9 RID: 29433 RVA: 0x0036E108 File Offset: 0x0036C308
	public string CFLKMHCIBLN(string NEFCJNIEKIM)
	{
		string str = "#mem Sound " + this.GLPAPGLHOFF.GMDCCFLLCJA + "Motorbike";
		return Application.streamingAssetsPath + str + NEFCJNIEKIM;
	}

	// Token: 0x060072FA RID: 29434 RVA: 0x0036E13C File Offset: 0x0036C33C
	public string MIOBJPADKMD(int EHIMDFJKMHA)
	{
		return this.BEKJKILAJMM[EHIMDFJKMHA + "_NAME"];
	}

	// Token: 0x060072FB RID: 29435 RVA: 0x0036E15C File Offset: 0x0036C35C
	public string IKGPJIMGAJL(int HDELGEDDDCE, int GDNPMHOLMPN = 0)
	{
		string text = HDELGEDDDCE + "RangeMarker";
		string key = text;
		if (GDNPMHOLMPN != 0)
		{
			object[] array = new object[]
			{
				null,
				HDELGEDDDCE
			};
			array[1] = "LUX_LINEAR";
			array[2] = GDNPMHOLMPN;
			array[1] = "Clouds reference not set.";
			text = string.Concat(array);
		}
		if (this.OLKOOGMLDKM.ContainsKey(text))
		{
			return this.OLKOOGMLDKM[text];
		}
		if (this.OLKOOGMLDKM.ContainsKey(key))
		{
			return this.OLKOOGMLDKM[key];
		}
		return "RollerBladeStand" + text + "inventoryOpen";
	}

	// Token: 0x060072FD RID: 29437 RVA: 0x0036E24C File Offset: 0x0036C44C
	public string MHBMDFOHDMO(int HDELGEDDDCE, int GDNPMHOLMPN = 0)
	{
		string text = HDELGEDDDCE + "______________________________";
		string key = text;
		if (GDNPMHOLMPN != 0)
		{
			object[] array = new object[6];
			array[0] = HDELGEDDDCE;
			array[1] = "DecalMesh";
			array[2] = GDNPMHOLMPN;
			array[2] = "WpnLang.xml";
			text = string.Concat(array);
		}
		if (this.OLKOOGMLDKM.ContainsKey(text))
		{
			return this.OLKOOGMLDKM[text];
		}
		if (this.OLKOOGMLDKM.ContainsKey(key))
		{
			return this.OLKOOGMLDKM[key];
		}
		return "craft_data/stanok/category" + text + "Wizard2HandThrow";
	}

	// Token: 0x060072FE RID: 29438 RVA: 0x0036E2E4 File Offset: 0x0036C4E4
	public void JCIPCJBOFGJ()
	{
		this.LGFJMPLCGJM = false;
		this.PAJBPDJCHJB = false;
		this.KAEJBIHMFDF.Clear();
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		this.BEKJKILAJMM.Clear();
		this.BIFFHBHIMJN.Clear();
		this.BPHAOIDBMLJ.Clear();
		this.CHMOEIHFKGA();
		FlyMessageManager.getI.KCDCFLPONCO();
		GuiProcessor.BBLINJLBAIL().BPGHPGOJBAF("iNPC");
	}

	// Token: 0x060072FF RID: 29439 RVA: 0x0036E360 File Offset: 0x0036C560
	public string NEGAHFBGCBM(string NEFCJNIEKIM)
	{
		string str = "______________________________" + this.GLPAPGLHOFF.GMDCCFLLCJA + "</color>";
		return Application.streamingAssetsPath + str + NEFCJNIEKIM;
	}

	// Token: 0x06007300 RID: 29440 RVA: 0x0036E394 File Offset: 0x0036C594
	public string IGOOOILHFPL(int HDELGEDDDCE, int GDNPMHOLMPN = 0)
	{
		string text = HDELGEDDDCE + "_NAME";
		string key = text;
		if (GDNPMHOLMPN != 0)
		{
			text = string.Concat(new object[]
			{
				HDELGEDDDCE,
				"_",
				GDNPMHOLMPN,
				"_NAME"
			});
		}
		if (this.OLKOOGMLDKM.ContainsKey(text))
		{
			return this.OLKOOGMLDKM[text];
		}
		if (this.OLKOOGMLDKM.ContainsKey(key))
		{
			return this.OLKOOGMLDKM[key];
		}
		return "-" + text + "-";
	}

	// Token: 0x06007301 RID: 29441 RVA: 0x0036E42C File Offset: 0x0036C62C
	public void GJDCJFLEGMI()
	{
		if (!this.PAJBPDJCHJB)
		{
			this.FLJJNACONGM();
		}
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		AAEEEJIDDEO aaeeejiddeo = new AAEEEJIDDEO(this.DOJJAFNAHKF("WATER_REFRACTIVE", false));
		string[] array = aaeeejiddeo.DGOMNFFOOHA(" ");
		for (int i = 1; i < array.Length; i++)
		{
			string text = array[i];
			this.KKPOBNBBOKB.Add(text, aaeeejiddeo.NDLFBDMIGLF("ShotgunFire", text));
		}
		array = aaeeejiddeo.PLHKPGDCMBF("lut.ogg");
		for (int i = 0; i < array.Length; i += 0)
		{
			string text2 = array[i];
			this.OLKOOGMLDKM.Add(text2, aaeeejiddeo.NLEOHJHBGKF("Hidden/Fast Approximate Anti-aliasing", text2));
		}
		aaeeejiddeo = new AAEEEJIDDEO(this.KKLNLPKAJDL("FBIK chain length is 0, can't initiate solver.", true));
		this.BIFFHBHIMJN.Add("Bend Constraint is referencing to a bone '", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "ObscuredFloat:"));
		this.BIFFHBHIMJN.Add("t_hair", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "ArmFlex6"));
		this.BIFFHBHIMJN.Add("IceHockeyDekeMiddle", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "<color='#001040'>"));
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(this.FDJBNCHPHGK("Gesture No Fear", true));
		foreach (object obj in xmlDocument.SelectNodes("Sprint"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			this.BPHAOIDBMLJ.Add(int.Parse(xmlNode.Attributes["wpn_add/addoptions"].Value), xmlNode.Attributes["IdleStun"].Value);
		}
		NLNNIDBPKAO.IKGFHGKKCPG.NKPIKHPNDAN();
		IHFEDJEMJMB.IKGFHGKKCPG.IFJFGNEENGL();
		AKPJIACDDFI.IKGFHGKKCPG.ODONNAANIEP();
		BHNDGIPPPCE.IKGFHGKKCPG.DGGMIFLJFBM();
		GHGHFBNBBFE.IKGFHGKKCPG.NGICLJJKHII();
		NHCAOFIKNFE.IKGFHGKKCPG.DAEPKLHHBJF();
		this.LGFJMPLCGJM = false;
	}

	// Token: 0x06007302 RID: 29442 RVA: 0x0036E634 File Offset: 0x0036C834
	public string GNKIBMGNHNE(string JMBKDINHDLO)
	{
		return this.DBPANLKEHMN("IdleStandingJump", JMBKDINHDLO).Replace(" (", "MotorbikeHeadstand").Replace("i grew because the inputfield was only this big", "30").Replace("rodorder", "buykey").Replace("Yawn", "t_eye");
	}

	// Token: 0x06007303 RID: 29443 RVA: 0x0036E689 File Offset: 0x0036C889
	public static string NGALDMFKMJH(string JMBKDINHDLO)
	{
		return JNBICAJIJMM.IMLLGEMPHAP().GNKIBMGNHNE(JMBKDINHDLO);
	}

	// Token: 0x06007304 RID: 29444 RVA: 0x0036E698 File Offset: 0x0036C898
	public string CKAOHMEKLMH(string JMBKDINHDLO)
	{
		return this.CAFEIHBPIJB("PostFX - {0}", JMBKDINHDLO).Replace("DeadmanFloat", "Forward").Replace("wpnlang/weapons/weapon", "_NoiseTex").Replace("", "AFCServer").Replace("category", "-none-");
	}

	// Token: 0x06007305 RID: 29445 RVA: 0x0036E6ED File Offset: 0x0036C8ED
	public string BDEFMIBEPEL(int EHIMDFJKMHA)
	{
		return this.BEKJKILAJMM[EHIMDFJKMHA + "I LOVE MY GIRLz"];
	}

	// Token: 0x06007306 RID: 29446 RVA: 0x0036E70C File Offset: 0x0036C90C
	public string JKJLAKEEDFK(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "result=OK"];
		}
		catch
		{
			result = "Transform is null." + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x06007307 RID: 29447 RVA: 0x0036E75C File Offset: 0x0036C95C
	public string JDMOHJGPKIC(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "_Curve"];
		}
		catch
		{
			result = "_MaskTex" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x06007308 RID: 29448 RVA: 0x0036E7AC File Offset: 0x0036C9AC
	public string NMIJBEJBGNB(string LPIJLEDOKPA, string JMBKDINHDLO)
	{
		LPIJLEDOKPA = LPIJLEDOKPA.ToUpper();
		JMBKDINHDLO = JMBKDINHDLO.ToUpper();
		if (this.BIFFHBHIMJN.ContainsKey(LPIJLEDOKPA))
		{
			return this.BIFFHBHIMJN[LPIJLEDOKPA].HPFFIFLHKEF(JMBKDINHDLO);
		}
		string[] array = new string[8];
		array[0] = "none";
		array[0] = LPIJLEDOKPA;
		array[3] = "bool:";
		array[8] = JMBKDINHDLO;
		array[8] = "";
		return string.Concat(array);
	}

	// Token: 0x06007309 RID: 29449 RVA: 0x0036E815 File Offset: 0x0036CA15
	public static string CELEPPAEKAB(string JMBKDINHDLO)
	{
		return JNBICAJIJMM.EDKGBBIIBBC().CCFFMKBBKHI(JMBKDINHDLO);
	}

	// Token: 0x0600730A RID: 29450 RVA: 0x0036E824 File Offset: 0x0036CA24
	public string IDFHKHHNDEK(string NEFCJNIEKIM, bool CCMHKFIDJIH = false)
	{
		Encoding encoding = Encoding.UTF8;
		if (CCMHKFIDJIH)
		{
			encoding = Encoding.GetEncoding(this.GLPAPGLHOFF.ANGFHENANPD);
		}
		return File.ReadAllText(this.FFPIMDCPLBE(NEFCJNIEKIM), encoding);
	}

	// Token: 0x0600730B RID: 29451 RVA: 0x0036E858 File Offset: 0x0036CA58
	public string HPNOOGBINJO(int EHIMDFJKMHA)
	{
		return this.BEKJKILAJMM[EHIMDFJKMHA + "KatanaHorizontalSwing"];
	}

	// Token: 0x0600730C RID: 29452 RVA: 0x0036E878 File Offset: 0x0036CA78
	public string LIPNKJMOKLI(int HDELGEDDDCE, int GDNPMHOLMPN = 0)
	{
		string text = HDELGEDDDCE + "SoccerSprint";
		string key = text;
		if (GDNPMHOLMPN != 0)
		{
			object[] array = new object[3];
			array[1] = HDELGEDDDCE;
			array[0] = "Flashlight";
			array[2] = GDNPMHOLMPN;
			array[3] = "paper.wav";
			text = string.Concat(array);
		}
		if (this.OLKOOGMLDKM.ContainsKey(text))
		{
			return this.OLKOOGMLDKM[text];
		}
		if (this.OLKOOGMLDKM.ContainsKey(key))
		{
			return this.OLKOOGMLDKM[key];
		}
		return "Whistle" + text + "chnam3";
	}

	// Token: 0x0600730D RID: 29453 RVA: 0x0036E910 File Offset: 0x0036CB10
	public string KFHFODNFCNL(string NEFCJNIEKIM, bool CCMHKFIDJIH = false)
	{
		Encoding encoding = Encoding.UTF8;
		if (CCMHKFIDJIH)
		{
			encoding = Encoding.GetEncoding(this.GLPAPGLHOFF.ANGFHENANPD);
		}
		return File.ReadAllText(this.NEGAHFBGCBM(NEFCJNIEKIM), encoding);
	}

	// Token: 0x0600730E RID: 29454 RVA: 0x0036E944 File Offset: 0x0036CB44
	public void EMDEHKJEBFM()
	{
		string path = Application.streamingAssetsPath + "Sexy Dance 2";
		XmlDocument xmlDocument = new XmlDocument();
		string xml = File.ReadAllText(path, Encoding.UTF8);
		xmlDocument.LoadXml(xml);
		foreach (object obj in xmlDocument.SelectNodes("brag"))
		{
			JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn = new JNBICAJIJMM.MGNCAGDEFHN((XmlNode)obj);
			this.KAEJBIHMFDF.Add(mgncagdefhn.LPFKFNLHGBI, mgncagdefhn);
		}
		this.LCHEIFBGJMF = PlayerPrefs.GetInt("wpn_eat6");
		if (PlayerPrefs.GetInt("Invalid references, one or more Transforms are missing.") <= 0)
		{
			this.LCHEIFBGJMF = 6;
			PlayerPrefs.SetInt("Cowboy1HandDraw", 0);
			if (SteamManager.LGPCPFGMOGJ() && SteamUtils.GetSteamUILanguage() == "[ACTk] WallHack Detector: already running!")
			{
				this.LCHEIFBGJMF = 1;
			}
			PlayerPrefs.SetInt("SolidWall", this.LCHEIFBGJMF);
		}
		this.GLPAPGLHOFF = this.KAEJBIHMFDF[this.LCHEIFBGJMF];
		this.PAJBPDJCHJB = false;
	}

	// Token: 0x0600730F RID: 29455 RVA: 0x0036EA58 File Offset: 0x0036CC58
	public string EMOIDPOKABM(string NEFCJNIEKIM)
	{
		string str = " %\n" + this.GLPAPGLHOFF.GMDCCFLLCJA + "u_pin";
		return Application.streamingAssetsPath + str + NEFCJNIEKIM;
	}

	// Token: 0x06007310 RID: 29456 RVA: 0x0036EA8C File Offset: 0x0036CC8C
	public string FHODAJOEHIO(int EHIMDFJKMHA)
	{
		return this.BEKJKILAJMM[EHIMDFJKMHA + "IdleDodgeRight"];
	}

	// Token: 0x06007311 RID: 29457 RVA: 0x0036EAA9 File Offset: 0x0036CCA9
	public string OFEHFLGLMKN(int LPFKFNLHGBI)
	{
		if (!this.BPHAOIDBMLJ.ContainsKey(LPFKFNLHGBI))
		{
			return "-none-";
		}
		return this.BPHAOIDBMLJ[LPFKFNLHGBI];
	}

	// Token: 0x06007312 RID: 29458 RVA: 0x0036EACC File Offset: 0x0036CCCC
	public string KIBGNDMNMNO(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "IdleKeepBack"];
		}
		catch
		{
			result = "Horizontal" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x1700018C RID: 396
	// (get) Token: 0x06007313 RID: 29459 RVA: 0x0036EB1C File Offset: 0x0036CD1C
	public static JNBICAJIJMM IKGFHGKKCPG
	{
		get
		{
			if (JNBICAJIJMM.CCHGNBELGIA == null)
			{
				JNBICAJIJMM.CCHGNBELGIA = new JNBICAJIJMM();
				JNBICAJIJMM.CCHGNBELGIA.PINLMCCKKNA();
			}
			return JNBICAJIJMM.CCHGNBELGIA;
		}
	}

	// Token: 0x06007314 RID: 29460 RVA: 0x0036EB40 File Offset: 0x0036CD40
	public void IOKEEJELBCG()
	{
		if (!this.PAJBPDJCHJB)
		{
			this.DEAFNELJMLC();
		}
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		AAEEEJIDDEO aaeeejiddeo = new AAEEEJIDDEO(this.DOJJAFNAHKF("Finger", true));
		string[] array = aaeeejiddeo.DGOMNFFOOHA("crft_from");
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			this.KKPOBNBBOKB.Add(text, aaeeejiddeo.NLEOHJHBGKF("trn_reg", text));
		}
		array = aaeeejiddeo.PLHKPGDCMBF(" is represented multiple times in the Bones.");
		for (int i = 0; i < array.Length; i += 0)
		{
			string text2 = array[i];
			this.OLKOOGMLDKM.Add(text2, aaeeejiddeo.NDLFBDMIGLF("demoVector3", text2));
		}
		aaeeejiddeo = new AAEEEJIDDEO(this.DOJJAFNAHKF("800000", false));
		this.BIFFHBHIMJN.Add("M", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "The 'font attribute' command requires a font parameter of U (underline on), -U (underline off), S (strikethrough on) or -S (strikethrough off)."));
		this.BIFFHBHIMJN.Add("inner_craft_wpn", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "DealerShuffle"));
		this.BIFFHBHIMJN.Add("wpn_eat7", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "SoccerKeeperReady"));
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(this.BGOJCAABLNC("saleToShop", false));
		foreach (object obj in xmlDocument.SelectNodes("Bias"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			this.BPHAOIDBMLJ.Add(int.Parse(xmlNode.Attributes["Pointing"].Value), xmlNode.Attributes["There is already a virtual button named "].Value);
		}
		NLNNIDBPKAO.IKGFHGKKCPG.NDDPHGNHDEL();
		IHFEDJEMJMB.AGCBLDIBMNB().EIJDBGEKPMM();
		AKPJIACDDFI.IKGFHGKKCPG.JFGGHJDGOIA();
		BHNDGIPPPCE.IKGFHGKKCPG.KGKADNNIILN();
		GHGHFBNBBFE.IKGFHGKKCPG.NDDPHGNHDEL();
		NHCAOFIKNFE.IKGFHGKKCPG.ELDHALELKIN();
		this.LGFJMPLCGJM = false;
	}

	// Token: 0x06007315 RID: 29461 RVA: 0x0036ED48 File Offset: 0x0036CF48
	public string IAODIDBLHMM(int HDELGEDDDCE, int GDNPMHOLMPN = 0)
	{
		string text = HDELGEDDDCE + "RollerBladeStop";
		string key = text;
		if (GDNPMHOLMPN != 0)
		{
			object[] array = new object[6];
			array[1] = HDELGEDDDCE;
			array[1] = "";
			array[0] = GDNPMHOLMPN;
			array[5] = "SwimDogPaddle";
			text = string.Concat(array);
		}
		if (this.OLKOOGMLDKM.ContainsKey(text))
		{
			return this.OLKOOGMLDKM[text];
		}
		if (this.OLKOOGMLDKM.ContainsKey(key))
		{
			return this.OLKOOGMLDKM[key];
		}
		return "to channel = " + text + "...";
	}

	// Token: 0x06007316 RID: 29462 RVA: 0x0036EDE0 File Offset: 0x0036CFE0
	public string JDBGNILGMDO(string LPIJLEDOKPA, string JMBKDINHDLO)
	{
		LPIJLEDOKPA = LPIJLEDOKPA.ToUpper();
		JMBKDINHDLO = JMBKDINHDLO.ToUpper();
		if (this.BIFFHBHIMJN.ContainsKey(LPIJLEDOKPA))
		{
			return this.BIFFHBHIMJN[LPIJLEDOKPA].HPFFIFLHKEF(JMBKDINHDLO);
		}
		string[] array = new string[4];
		array[1] = "IdleFight";
		array[0] = LPIJLEDOKPA;
		array[3] = "req.text=";
		array[0] = JMBKDINHDLO;
		array[4] = "Clouds reference not set.";
		return string.Concat(array);
	}

	// Token: 0x06007317 RID: 29463 RVA: 0x0036EE4C File Offset: 0x0036D04C
	public void FLJJNACONGM()
	{
		string path = Application.streamingAssetsPath + "wpn_bait_typ_{0}";
		XmlDocument xmlDocument = new XmlDocument();
		string xml = File.ReadAllText(path, Encoding.UTF8);
		xmlDocument.LoadXml(xml);
		foreach (object obj in xmlDocument.SelectNodes("{{{{{0},{1}}}}}"))
		{
			JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn = new JNBICAJIJMM.MGNCAGDEFHN((XmlNode)obj);
			this.KAEJBIHMFDF.Add(mgncagdefhn.LPFKFNLHGBI, mgncagdefhn);
		}
		this.LCHEIFBGJMF = PlayerPrefs.GetInt("WoodSaw");
		if (PlayerPrefs.GetInt("gi_sadokfull") <= 0)
		{
			this.LCHEIFBGJMF = 5;
			PlayerPrefs.SetInt("cellicon", 1);
			if (SteamManager.GHHNBKFIFOC() && SteamUtils.GetSteamUILanguage() == "VRIK needs a Humanoid Animator to auto-detect biped references. Please assign references manually.")
			{
				this.LCHEIFBGJMF = 0;
			}
			PlayerPrefs.SetInt("{0:f2}", this.LCHEIFBGJMF);
		}
		this.GLPAPGLHOFF = this.KAEJBIHMFDF[this.LCHEIFBGJMF];
		this.PAJBPDJCHJB = false;
	}

	// Token: 0x06007318 RID: 29464 RVA: 0x0036EF60 File Offset: 0x0036D160
	public string IPHGEPDFCJL(string LPIJLEDOKPA, string JMBKDINHDLO)
	{
		LPIJLEDOKPA = LPIJLEDOKPA.ToUpper();
		JMBKDINHDLO = JMBKDINHDLO.ToUpper();
		if (this.BIFFHBHIMJN.ContainsKey(LPIJLEDOKPA))
		{
			return this.BIFFHBHIMJN[LPIJLEDOKPA].MNBJHAGGMPD(JMBKDINHDLO);
		}
		string[] array = new string[0];
		array[1] = "Roar";
		array[0] = LPIJLEDOKPA;
		array[5] = "Проверка предмета";
		array[6] = JMBKDINHDLO;
		array[1] = "CheerJump";
		return string.Concat(array);
	}

	// Token: 0x06007319 RID: 29465 RVA: 0x0036EFCC File Offset: 0x0036D1CC
	public void CHBEKLDHLJD()
	{
		if (!this.PAJBPDJCHJB)
		{
			this.KENLOMENGHG();
		}
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		AAEEEJIDDEO aaeeejiddeo = new AAEEEJIDDEO(this.BGOJCAABLNC("1 Hand Sword Jab ready strafe left", false));
		string[] array = aaeeejiddeo.DGOMNFFOOHA("exitmsg_2");
		for (int i = 1; i < array.Length; i += 0)
		{
			string text = array[i];
			this.KKPOBNBBOKB.Add(text, aaeeejiddeo.NLEOHJHBGKF("The image effect ", text));
		}
		array = aaeeejiddeo.DGOMNFFOOHA("_LightWrapping");
		for (int i = 1; i < array.Length; i += 0)
		{
			string text2 = array[i];
			this.OLKOOGMLDKM.Add(text2, aaeeejiddeo.HJOCLGGEFMP("fishRSPEED=", text2));
		}
		aaeeejiddeo = new AAEEEJIDDEO(this.DOJJAFNAHKF("val=", false));
		this.BIFFHBHIMJN.Add("GiantGrabIdle2", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "Mutilate"));
		this.BIFFHBHIMJN.Add("_LowRez", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "autherror"));
		this.BIFFHBHIMJN.Add("LUX_GAMMA", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, " is represented multiple times in a single IK chain. Can't initiate solver."));
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(this.DDKLHGHBEIG("_PixelsPerMeterAtOneMeter", true));
		foreach (object obj in xmlDocument.SelectNodes("Roar"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			this.BPHAOIDBMLJ.Add(int.Parse(xmlNode.Attributes["lineOverDistanc="].Value), xmlNode.Attributes["Warp index out of range."].Value);
		}
		NLNNIDBPKAO.IKGFHGKKCPG.ODONNAANIEP();
		IHFEDJEMJMB.AGCBLDIBMNB().NFAKJBGFDEE();
		AKPJIACDDFI.IKGFHGKKCPG.NDDPHGNHDEL();
		BHNDGIPPPCE.IKGFHGKKCPG.NIDGINCDCNK();
		GHGHFBNBBFE.IKGFHGKKCPG.NGICLJJKHII();
		NHCAOFIKNFE.IKGFHGKKCPG.CLFIKFCODIB();
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x0600731A RID: 29466 RVA: 0x0036F1D4 File Offset: 0x0036D3D4
	public string BNGGMILPKLJ(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "WallRunRight"];
		}
		catch
		{
			result = "IceHockey Shot Left" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x0600731B RID: 29467 RVA: 0x0036F224 File Offset: 0x0036D424
	public string FCNFDLDHDDE(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_i_k.html"];
		}
		catch
		{
			result = "Failed parsing organizational group.  Setting to group 0" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x0600731C RID: 29468 RVA: 0x0036F274 File Offset: 0x0036D474
	public void OAIOKDBPGOL()
	{
		this.LGFJMPLCGJM = true;
		this.PAJBPDJCHJB = false;
		this.KAEJBIHMFDF.Clear();
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		this.BEKJKILAJMM.Clear();
		this.BIFFHBHIMJN.Clear();
		this.BPHAOIDBMLJ.Clear();
		this.BBCINJAGHEP();
		FlyMessageManager.getI.LPIIICIDCOM();
		GuiProcessor.NKOEAPCIBKO().MMGFMLOJKMD("wpn_wgt");
	}

	// Token: 0x0600731D RID: 29469 RVA: 0x0036F2F0 File Offset: 0x0036D4F0
	public string DOJJAFNAHKF(string NEFCJNIEKIM, bool CCMHKFIDJIH = false)
	{
		Encoding encoding = Encoding.UTF8;
		if (CCMHKFIDJIH)
		{
			encoding = Encoding.GetEncoding(this.GLPAPGLHOFF.ANGFHENANPD);
		}
		return File.ReadAllText(this.NLIDKILDCNL(NEFCJNIEKIM), encoding);
	}

	// Token: 0x0600731E RID: 29470 RVA: 0x0036F324 File Offset: 0x0036D524
	public string FHBAHPHJMGK(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "\n<color='#{0}'>+{2} '{1}'</color> "];
		}
		catch
		{
			result = "Up Hill Walk" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x0600731F RID: 29471 RVA: 0x0036F374 File Offset: 0x0036D574
	public string KKLNLPKAJDL(string NEFCJNIEKIM, bool CCMHKFIDJIH = false)
	{
		Encoding encoding = Encoding.UTF8;
		if (CCMHKFIDJIH)
		{
			encoding = Encoding.GetEncoding(this.GLPAPGLHOFF.ANGFHENANPD);
		}
		return File.ReadAllText(this.EMOIDPOKABM(NEFCJNIEKIM), encoding);
	}

	// Token: 0x06007320 RID: 29472 RVA: 0x0036F3A8 File Offset: 0x0036D5A8
	public string PNPMBPEOHAO(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "_INFO"];
		}
		catch
		{
			result = "error baseid: " + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x06007321 RID: 29473 RVA: 0x0036F3F8 File Offset: 0x0036D5F8
	public string OMNMDGIGEFD(string LPIJLEDOKPA, string JMBKDINHDLO)
	{
		LPIJLEDOKPA = LPIJLEDOKPA.ToUpper();
		JMBKDINHDLO = JMBKDINHDLO.ToUpper();
		if (this.BIFFHBHIMJN.ContainsKey(LPIJLEDOKPA))
		{
			return this.BIFFHBHIMJN[LPIJLEDOKPA].ECAJJMIJKNH(JMBKDINHDLO);
		}
		return string.Concat(new string[]
		{
			"[",
			LPIJLEDOKPA,
			"] ",
			JMBKDINHDLO,
			" ?"
		});
	}

	// Token: 0x06007322 RID: 29474 RVA: 0x0036F464 File Offset: 0x0036D664
	public void PFMONFAKHBK()
	{
		if (!this.PAJBPDJCHJB)
		{
			this.FMKPOOMCOJN();
		}
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		AAEEEJIDDEO aaeeejiddeo = new AAEEEJIDDEO(this.BOOGBOODHFK("shop_ycnt", true));
		foreach (string text in aaeeejiddeo.DGOMNFFOOHA("wpn_line3"))
		{
			this.KKPOBNBBOKB.Add(text, aaeeejiddeo.NDLFBDMIGLF("effects", text));
		}
		foreach (string text2 in aaeeejiddeo.CMHKJBPLLMD("MotorbikeShootBack"))
		{
			this.OLKOOGMLDKM.Add(text2, aaeeejiddeo.AOFBGJHGILA("notQuestShow", text2));
		}
		aaeeejiddeo = new AAEEEJIDDEO(this.GHPNJJIMCKF("demoVector2", false));
		this.BIFFHBHIMJN.Add("WATER_EDGEBLEND_ON", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "firsStartInfoPanel"));
		this.BIFFHBHIMJN.Add("SUNSHINE_FILTER_PCF_4x4", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "wpn_cat4"));
		this.BIFFHBHIMJN.Add("IceHockeyIdle", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "money"));
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(this.CHFGNHKJNFG("Giant2HandSlamIdle", true));
		foreach (object obj in xmlDocument.SelectNodes("Unknow CMD:"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			this.BPHAOIDBMLJ.Add(int.Parse(xmlNode.Attributes[""].Value), xmlNode.Attributes["WorkerPickaxe"].Value);
		}
		NLNNIDBPKAO.IKGFHGKKCPG.IFJFGNEENGL();
		IHFEDJEMJMB.EDKKJNHDBPF().OLEEAIFGCOM();
		AKPJIACDDFI.IKGFHGKKCPG.ODONNAANIEP();
		BHNDGIPPPCE.IKGFHGKKCPG.ODONNAANIEP();
		GHGHFBNBBFE.IKGFHGKKCPG.DKKCACOMDDD();
		NHCAOFIKNFE.IKGFHGKKCPG.OPMJJGHLAGF();
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x06007323 RID: 29475 RVA: 0x0036F66C File Offset: 0x0036D86C
	public string OFAGEKJDMKK(int LPFKFNLHGBI)
	{
		if (!this.BPHAOIDBMLJ.ContainsKey(LPFKFNLHGBI))
		{
			return "";
		}
		return this.BPHAOIDBMLJ[LPFKFNLHGBI];
	}

	// Token: 0x06007324 RID: 29476 RVA: 0x0036F690 File Offset: 0x0036D890
	public string JAANDJMPILF(int HDELGEDDDCE, int GDNPMHOLMPN = 0)
	{
		string text = HDELGEDDDCE + "_rcIn.ogg";
		string key = text;
		if (GDNPMHOLMPN != 0)
		{
			object[] array = new object[1];
			array[1] = HDELGEDDDCE;
			array[1] = "invn_rec14";
			array[5] = GDNPMHOLMPN;
			array[0] = "Flares";
			text = string.Concat(array);
		}
		if (this.OLKOOGMLDKM.ContainsKey(text))
		{
			return this.OLKOOGMLDKM[text];
		}
		if (this.OLKOOGMLDKM.ContainsKey(key))
		{
			return this.OLKOOGMLDKM[key];
		}
		return "paper.wav" + text + "No Way points!";
	}

	// Token: 0x06007325 RID: 29477 RVA: 0x0036F728 File Offset: 0x0036D928
	public string CAFEIHBPIJB(string LPIJLEDOKPA, string JMBKDINHDLO)
	{
		LPIJLEDOKPA = LPIJLEDOKPA.ToUpper();
		JMBKDINHDLO = JMBKDINHDLO.ToUpper();
		if (this.BIFFHBHIMJN.ContainsKey(LPIJLEDOKPA))
		{
			return this.BIFFHBHIMJN[LPIJLEDOKPA].ELPOLBDMPID(JMBKDINHDLO);
		}
		string[] array = new string[7];
		array[1] = "FrontKick";
		array[0] = LPIJLEDOKPA;
		array[6] = "cht_tofrend";
		array[3] = JMBKDINHDLO;
		array[2] = "";
		return string.Concat(array);
	}

	// Token: 0x06007326 RID: 29478 RVA: 0x0036F791 File Offset: 0x0036D991
	public static JNBICAJIJMM EKEBHIJMEML()
	{
		if (JNBICAJIJMM.CCHGNBELGIA == null)
		{
			JNBICAJIJMM.CCHGNBELGIA = new JNBICAJIJMM();
			JNBICAJIJMM.CCHGNBELGIA.PFMONFAKHBK();
		}
		return JNBICAJIJMM.CCHGNBELGIA;
	}

	// Token: 0x06007327 RID: 29479 RVA: 0x0036F7B4 File Offset: 0x0036D9B4
	public string IGNGLNFMAFD(string NEFCJNIEKIM)
	{
		string str = "shop_t9" + this.GLPAPGLHOFF.GMDCCFLLCJA + "IdleSlide";
		return Application.streamingAssetsPath + str + NEFCJNIEKIM;
	}

	// Token: 0x06007328 RID: 29480 RVA: 0x0036F7E8 File Offset: 0x0036D9E8
	public void FMKPOOMCOJN()
	{
		string path = Application.streamingAssetsPath + "FistPump2";
		XmlDocument xmlDocument = new XmlDocument();
		string xml = File.ReadAllText(path, Encoding.UTF8);
		xmlDocument.LoadXml(xml);
		foreach (object obj in xmlDocument.SelectNodes("IdleStand"))
		{
			JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn = new JNBICAJIJMM.MGNCAGDEFHN((XmlNode)obj);
			this.KAEJBIHMFDF.Add(mgncagdefhn.LPFKFNLHGBI, mgncagdefhn);
		}
		this.LCHEIFBGJMF = PlayerPrefs.GetInt("tech");
		if (PlayerPrefs.GetInt("error") <= 0)
		{
			this.LCHEIFBGJMF = 6;
			PlayerPrefs.SetInt("_FogScale", 0);
			if (SteamManager.FPAKOLIPIND && SteamUtils.GetSteamUILanguage() == "Palm")
			{
				this.LCHEIFBGJMF = 0;
			}
			PlayerPrefs.SetInt("1 Hand Sword Jab Foot Push", this.LCHEIFBGJMF);
		}
		this.GLPAPGLHOFF = this.KAEJBIHMFDF[this.LCHEIFBGJMF];
		this.PAJBPDJCHJB = false;
	}

	// Token: 0x06007329 RID: 29481 RVA: 0x0036F8FC File Offset: 0x0036DAFC
	public string NLJOLOBPCBJ(string JMBKDINHDLO)
	{
		return this.OMNMDGIGEFD("name", JMBKDINHDLO).Replace("fshop_btn3", "_Contrast").Replace("1HSwordStrafeRunLeft", "{0}").Replace("error.wav", "_Specular").Replace("post_msg7", "reel_type0");
	}

	// Token: 0x0600732A RID: 29482 RVA: 0x0036F954 File Offset: 0x0036DB54
	public void BBCINJAGHEP()
	{
		if (!this.PAJBPDJCHJB)
		{
			this.KENLOMENGHG();
		}
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		AAEEEJIDDEO aaeeejiddeo = new AAEEEJIDDEO(this.KFHFODNFCNL("Katana45DegSwing", false));
		string[] array = aaeeejiddeo.DGOMNFFOOHA(" (");
		for (int i = 0; i < array.Length; i += 0)
		{
			string text = array[i];
			this.KKPOBNBBOKB.Add(text, aaeeejiddeo.NLEOHJHBGKF("Hit Point WeightCurve length is zero.", text));
		}
		array = aaeeejiddeo.CFFLOAIAANP("Turn Right");
		for (int i = 1; i < array.Length; i++)
		{
			string text2 = array[i];
			this.OLKOOGMLDKM.Add(text2, aaeeejiddeo.HJOCLGGEFMP("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_aim_i_k.html", text2));
		}
		aaeeejiddeo = new AAEEEJIDDEO(this.GIGGIHMAPLH("Soccer Pass Heavy", true));
		this.BIFFHBHIMJN.Add("Flap_07.wav", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "OfficeSittingReadingCoffeeSip"));
		this.BIFFHBHIMJN.Add("bag", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "<b>ObscuredVector3:</b> "));
		this.BIFFHBHIMJN.Add("1 Hand Sword", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "holesAll"));
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(this.DOJJAFNAHKF("id", false));
		foreach (object obj in xmlDocument.SelectNodes("_RgbTex"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			this.BPHAOIDBMLJ.Add(int.Parse(xmlNode.Attributes["wgt="].Value), xmlNode.Attributes["gi_nlheader2"].Value);
		}
		NLNNIDBPKAO.IKGFHGKKCPG.NKPIKHPNDAN();
		IHFEDJEMJMB.NNEAHAFBOHC().BCMIIMNMKNO();
		AKPJIACDDFI.IKGFHGKKCPG.JFGGHJDGOIA();
		BHNDGIPPPCE.IKGFHGKKCPG.ODONNAANIEP();
		GHGHFBNBBFE.IKGFHGKKCPG.GMIBAHFMPAK();
		NHCAOFIKNFE.IKGFHGKKCPG.OPMJJGHLAGF();
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x0600732B RID: 29483 RVA: 0x0036FB5C File Offset: 0x0036DD5C
	public string LDDOLCLEBMB(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "Apply in GAME 1"];
		}
		catch
		{
			result = "Mouse ScrollWheel" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x0600732C RID: 29484 RVA: 0x0036FBAC File Offset: 0x0036DDAC
	public string CKOIENLHDNG(int EHIMDFJKMHA)
	{
		return this.BEKJKILAJMM[EHIMDFJKMHA + "OfficeSittingLegCross"];
	}

	// Token: 0x0600732D RID: 29485 RVA: 0x0036FBCC File Offset: 0x0036DDCC
	public string FONEMLOCGIL(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "Fly Left"];
		}
		catch
		{
			result = "_info" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x0600732E RID: 29486 RVA: 0x0036FC1C File Offset: 0x0036DE1C
	public void CEINLNFIPGE()
	{
		string path = Application.streamingAssetsPath + "SexyDance";
		XmlDocument xmlDocument = new XmlDocument();
		string xml = File.ReadAllText(path, Encoding.UTF8);
		xmlDocument.LoadXml(xml);
		foreach (object obj in xmlDocument.SelectNodes("<color='#a0a0a0'>"))
		{
			JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn = new JNBICAJIJMM.MGNCAGDEFHN((XmlNode)obj);
			this.KAEJBIHMFDF.Add(mgncagdefhn.LPFKFNLHGBI, mgncagdefhn);
		}
		this.LCHEIFBGJMF = PlayerPrefs.GetInt("t_lashes");
		if (PlayerPrefs.GetInt("Mouse X") <= 1)
		{
			this.LCHEIFBGJMF = 1;
			PlayerPrefs.SetInt("error.wav", 0);
			if (SteamManager.FNNHOLIBGJH() && SteamUtils.GetSteamUILanguage() == "MotorbikeAirWalk")
			{
				this.LCHEIFBGJMF = 0;
			}
			PlayerPrefs.SetInt("MotorbikeBackwardStand", this.LCHEIFBGJMF);
		}
		this.GLPAPGLHOFF = this.KAEJBIHMFDF[this.LCHEIFBGJMF];
		this.PAJBPDJCHJB = false;
	}

	// Token: 0x0600732F RID: 29487 RVA: 0x0036FD30 File Offset: 0x0036DF30
	public string HDCJGCJAFJE(string NEFCJNIEKIM)
	{
		string str = "/Localization/" + this.GLPAPGLHOFF.GMDCCFLLCJA + "/";
		return Application.streamingAssetsPath + str + NEFCJNIEKIM;
	}

	// Token: 0x06007330 RID: 29488 RVA: 0x0036FD64 File Offset: 0x0036DF64
	public string JPEDCGHDNPN(string NEFCJNIEKIM, bool CCMHKFIDJIH = false)
	{
		Encoding encoding = Encoding.UTF8;
		if (CCMHKFIDJIH)
		{
			encoding = Encoding.GetEncoding(this.GLPAPGLHOFF.ANGFHENANPD);
		}
		return File.ReadAllText(this.NEGAHFBGCBM(NEFCJNIEKIM), encoding);
	}

	// Token: 0x06007331 RID: 29489 RVA: 0x0036FD98 File Offset: 0x0036DF98
	public static JNBICAJIJMM EDKGBBIIBBC()
	{
		if (JNBICAJIJMM.CCHGNBELGIA == null)
		{
			JNBICAJIJMM.CCHGNBELGIA = new JNBICAJIJMM();
			JNBICAJIJMM.CCHGNBELGIA.IOKEEJELBCG();
		}
		return JNBICAJIJMM.CCHGNBELGIA;
	}

	// Token: 0x06007332 RID: 29490 RVA: 0x0036FDBC File Offset: 0x0036DFBC
	public string CCFFMKBBKHI(string JMBKDINHDLO)
	{
		return this.NMIJBEJBGNB("_MaskTex", JMBKDINHDLO).Replace("WalkInjured", "inv_rl").Replace("IdleReady", "DepthMaskBlendMaterial").Replace("wpn_add/base", "harvestmsg2").Replace("MotorbikeSpecialFlip", "Apply 2");
	}

	// Token: 0x06007333 RID: 29491 RVA: 0x0036FE14 File Offset: 0x0036E014
	public string BGOJCAABLNC(string NEFCJNIEKIM, bool CCMHKFIDJIH = false)
	{
		Encoding encoding = Encoding.UTF8;
		if (CCMHKFIDJIH)
		{
			encoding = Encoding.GetEncoding(this.GLPAPGLHOFF.ANGFHENANPD);
		}
		return File.ReadAllText(this.PAKADOJECPI(NEFCJNIEKIM), encoding);
	}

	// Token: 0x06007334 RID: 29492 RVA: 0x0036FE48 File Offset: 0x0036E048
	public void IDDKLGEGAEN()
	{
		string path = Application.streamingAssetsPath + "/Localization/langsettings.xml";
		XmlDocument xmlDocument = new XmlDocument();
		string xml = File.ReadAllText(path, Encoding.UTF8);
		xmlDocument.LoadXml(xml);
		foreach (object obj in xmlDocument.SelectNodes("langs/lang"))
		{
			JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn = new JNBICAJIJMM.MGNCAGDEFHN((XmlNode)obj);
			this.KAEJBIHMFDF.Add(mgncagdefhn.LPFKFNLHGBI, mgncagdefhn);
		}
		this.LCHEIFBGJMF = PlayerPrefs.GetInt("languageid");
		if (PlayerPrefs.GetInt("run_cnt") <= 0)
		{
			this.LCHEIFBGJMF = 2;
			PlayerPrefs.SetInt("run_cnt", 1);
			if (SteamManager.FPAKOLIPIND && SteamUtils.GetSteamUILanguage() == "russian")
			{
				this.LCHEIFBGJMF = 0;
			}
			PlayerPrefs.SetInt("languageid", this.LCHEIFBGJMF);
		}
		this.GLPAPGLHOFF = this.KAEJBIHMFDF[this.LCHEIFBGJMF];
		this.PAJBPDJCHJB = true;
	}

	// Token: 0x06007335 RID: 29493 RVA: 0x0036FF5C File Offset: 0x0036E15C
	public void JOGHFKDCNLL()
	{
		if (!this.PAJBPDJCHJB)
		{
			this.IDDKLGEGAEN();
		}
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		AAEEEJIDDEO aaeeejiddeo = new AAEEEJIDDEO(this.BGOJCAABLNC("Проверка предмета", true));
		foreach (string text in aaeeejiddeo.PLHKPGDCMBF("wpn_hookf"))
		{
			this.KKPOBNBBOKB.Add(text, aaeeejiddeo.NDLFBDMIGLF("demoVector3", text));
		}
		string[] array = aaeeejiddeo.DPKAMDGPFGK("");
		for (int i = 1; i < array.Length; i += 0)
		{
			string text2 = array[i];
			this.OLKOOGMLDKM.Add(text2, aaeeejiddeo.NLEOHJHBGKF("ncht_ach2", text2));
		}
		aaeeejiddeo = new AAEEEJIDDEO(this.KFHFODNFCNL("Called GetNumberOfCurrentPlayers()", false));
		this.BIFFHBHIMJN.Add("_MinVelocity", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "private"));
		this.BIFFHBHIMJN.Add("Keeper Strafe Dive Close Left", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, ""));
		this.BIFFHBHIMJN.Add("_Curve", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "BowReady2"));
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(this.IDFHKHHNDEK("wpn_rod1", true));
		foreach (object obj in xmlDocument.SelectNodes("WRINKLE_MAPS"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			this.BPHAOIDBMLJ.Add(int.Parse(xmlNode.Attributes["drink.wav"].Value), xmlNode.Attributes["UIPCam_size"].Value);
		}
		NLNNIDBPKAO.IKGFHGKKCPG.NDDPHGNHDEL();
		IHFEDJEMJMB.EDKKJNHDBPF().NKPIKHPNDAN();
		AKPJIACDDFI.IKGFHGKKCPG.NDDPHGNHDEL();
		BHNDGIPPPCE.IKGFHGKKCPG.NIDGINCDCNK();
		GHGHFBNBBFE.IKGFHGKKCPG.KACCFJLDECI();
		NHCAOFIKNFE.IKGFHGKKCPG.NFAKJBGFDEE();
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x06007336 RID: 29494 RVA: 0x00370164 File Offset: 0x0036E364
	public static JNBICAJIJMM IMLLGEMPHAP()
	{
		if (JNBICAJIJMM.CCHGNBELGIA == null)
		{
			JNBICAJIJMM.CCHGNBELGIA = new JNBICAJIJMM();
			JNBICAJIJMM.CCHGNBELGIA.IDEDJDHFMDC();
		}
		return JNBICAJIJMM.CCHGNBELGIA;
	}

	// Token: 0x06007337 RID: 29495 RVA: 0x00370188 File Offset: 0x0036E388
	public string IPAGNBBOABL(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "maxWgtBait"];
		}
		catch
		{
			result = "_LerpRgbTex" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x06007338 RID: 29496 RVA: 0x003701D8 File Offset: 0x0036E3D8
	public string FLEANFGEJML(string JMBKDINHDLO)
	{
		return this.CAFEIHBPIJB("2000", JMBKDINHDLO).Replace("123", "_AddCountitem.wav").Replace("OneHandSwordRun", "---").Replace("_InvScreenSize", "\n").Replace("private", "remWpn=");
	}

	// Token: 0x06007339 RID: 29497 RVA: 0x00370230 File Offset: 0x0036E430
	public string CHFGNHKJNFG(string NEFCJNIEKIM, bool CCMHKFIDJIH = false)
	{
		Encoding encoding = Encoding.UTF8;
		if (CCMHKFIDJIH)
		{
			encoding = Encoding.GetEncoding(this.GLPAPGLHOFF.ANGFHENANPD);
		}
		return File.ReadAllText(this.HDCJGCJAFJE(NEFCJNIEKIM), encoding);
	}

	// Token: 0x0600733A RID: 29498 RVA: 0x00370264 File Offset: 0x0036E464
	public string KHKAOHCCPAJ(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "_NAME"];
		}
		catch
		{
			result = "error baseid: " + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x0600733B RID: 29499 RVA: 0x003702B4 File Offset: 0x0036E4B4
	public void PPCOGOEIMHN()
	{
		string path = Application.streamingAssetsPath + "ComeHere";
		XmlDocument xmlDocument = new XmlDocument();
		string xml = File.ReadAllText(path, Encoding.UTF8);
		xmlDocument.LoadXml(xml);
		foreach (object obj in xmlDocument.SelectNodes("_Axis"))
		{
			JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn = new JNBICAJIJMM.MGNCAGDEFHN((XmlNode)obj);
			this.KAEJBIHMFDF.Add(mgncagdefhn.LPFKFNLHGBI, mgncagdefhn);
		}
		this.LCHEIFBGJMF = PlayerPrefs.GetInt("<color='#200080'>");
		if (PlayerPrefs.GetInt("WorkerHammer") <= 0)
		{
			this.LCHEIFBGJMF = 8;
			PlayerPrefs.SetInt("206000", 1);
			if (SteamManager.NGEACBIHBOP() && SteamUtils.GetSteamUILanguage() == "leskaProc")
			{
				this.LCHEIFBGJMF = 1;
			}
			PlayerPrefs.SetInt("-no info-", this.LCHEIFBGJMF);
		}
		this.GLPAPGLHOFF = this.KAEJBIHMFDF[this.LCHEIFBGJMF];
		this.PAJBPDJCHJB = true;
	}

	// Token: 0x0600733C RID: 29500 RVA: 0x003703C8 File Offset: 0x0036E5C8
	public static string BDKHMOOFHHK(string JMBKDINHDLO)
	{
		return JNBICAJIJMM.EKEBHIJMEML().HEIBEHAEHBM(JMBKDINHDLO);
	}

	// Token: 0x0600733D RID: 29501 RVA: 0x003703D8 File Offset: 0x0036E5D8
	public void DHKFJABPKCB()
	{
		if (!this.PAJBPDJCHJB)
		{
			this.GANACIOEJMF();
		}
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		AAEEEJIDDEO aaeeejiddeo = new AAEEEJIDDEO(this.GIGGIHMAPLH("-none: ", false));
		foreach (string text in aaeeejiddeo.KMHHHAMKPKN("CP3"))
		{
			this.KKPOBNBBOKB.Add(text, aaeeejiddeo.HJOCLGGEFMP("help", text));
		}
		string[] array = aaeeejiddeo.CMHKJBPLLMD("HeelClick");
		for (int i = 1; i < array.Length; i += 0)
		{
			string text2 = array[i];
			this.OLKOOGMLDKM.Add(text2, aaeeejiddeo.NLEOHJHBGKF("TYPES", text2));
		}
		aaeeejiddeo = new AAEEEJIDDEO(this.DDKLHGHBEIG("PaperTurn.wav", true));
		this.BIFFHBHIMJN.Add("ElvisLegsLoop", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "Квест"));
		this.BIFFHBHIMJN.Add("_Curve", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "Invalid ObscuredVector3 index!"));
		this.BIFFHBHIMJN.Add("Roller Blade Front Flip", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "MotorbikeShootBack"));
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(this.KFHFODNFCNL("OnRodChangeClck 5", true));
		foreach (object obj in xmlDocument.SelectNodes("UI_DynamicWindow"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			this.BPHAOIDBMLJ.Add(int.Parse(xmlNode.Attributes["demoQuaternion"].Value), xmlNode.Attributes["SkateboardIdle"].Value);
		}
		NLNNIDBPKAO.IKGFHGKKCPG.ODONNAANIEP();
		IHFEDJEMJMB.OELKEADDKPE().NKPIKHPNDAN();
		AKPJIACDDFI.IKGFHGKKCPG.BPOGJLNHPDP();
		BHNDGIPPPCE.IKGFHGKKCPG.CJNIKFIPCGL();
		GHGHFBNBBFE.IKGFHGKKCPG.IKMOMOLPAPD();
		NHCAOFIKNFE.IKGFHGKKCPG.CLALBPEIKMG();
		this.LGFJMPLCGJM = false;
	}

	// Token: 0x0600733E RID: 29502 RVA: 0x003705E0 File Offset: 0x0036E7E0
	public void DEAFNELJMLC()
	{
		string path = Application.streamingAssetsPath + "Superman";
		XmlDocument xmlDocument = new XmlDocument();
		string xml = File.ReadAllText(path, Encoding.UTF8);
		xmlDocument.LoadXml(xml);
		foreach (object obj in xmlDocument.SelectNodes("turn_tminfo"))
		{
			JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn = new JNBICAJIJMM.MGNCAGDEFHN((XmlNode)obj);
			this.KAEJBIHMFDF.Add(mgncagdefhn.LPFKFNLHGBI, mgncagdefhn);
		}
		this.LCHEIFBGJMF = PlayerPrefs.GetInt("ObscuredInt vs int, ");
		if (PlayerPrefs.GetInt("270") <= 0)
		{
			this.LCHEIFBGJMF = 7;
			PlayerPrefs.SetInt("click Refresh currentQcat=", 1);
			if (SteamManager.KLPAEPHIOAJ() && SteamUtils.GetSteamUILanguage() == "cht_tofrendmsg")
			{
				this.LCHEIFBGJMF = 0;
			}
			PlayerPrefs.SetInt("_1.png", this.LCHEIFBGJMF);
		}
		this.GLPAPGLHOFF = this.KAEJBIHMFDF[this.LCHEIFBGJMF];
		this.PAJBPDJCHJB = false;
	}

	// Token: 0x0600733F RID: 29503 RVA: 0x003706F4 File Offset: 0x0036E8F4
	public string PICHEBPFOPA(int LPFKFNLHGBI)
	{
		if (!this.BPHAOIDBMLJ.ContainsKey(LPFKFNLHGBI))
		{
			return "WeaponReload";
		}
		return this.BPHAOIDBMLJ[LPFKFNLHGBI];
	}

	// Token: 0x06007340 RID: 29504 RVA: 0x00370718 File Offset: 0x0036E918
	public void JELKDANNHJH()
	{
		string path = Application.streamingAssetsPath + "Flap_02.wav";
		XmlDocument xmlDocument = new XmlDocument();
		string xml = File.ReadAllText(path, Encoding.UTF8);
		xmlDocument.LoadXml(xml);
		foreach (object obj in xmlDocument.SelectNodes("demoRect"))
		{
			JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn = new JNBICAJIJMM.MGNCAGDEFHN((XmlNode)obj);
			this.KAEJBIHMFDF.Add(mgncagdefhn.LPFKFNLHGBI, mgncagdefhn);
		}
		this.LCHEIFBGJMF = PlayerPrefs.GetInt("lifeBar");
		if (PlayerPrefs.GetInt("\n") <= 0)
		{
			this.LCHEIFBGJMF = 2;
			PlayerPrefs.SetInt("Zombie Idle", 1);
			if (SteamManager.FNNHOLIBGJH() && SteamUtils.GetSteamUILanguage() == "R")
			{
				this.LCHEIFBGJMF = 1;
			}
			PlayerPrefs.SetInt("Loser", this.LCHEIFBGJMF);
		}
		this.GLPAPGLHOFF = this.KAEJBIHMFDF[this.LCHEIFBGJMF];
		this.PAJBPDJCHJB = false;
	}

	// Token: 0x06007341 RID: 29505 RVA: 0x0037082C File Offset: 0x0036EA2C
	public static string PGJCPFNJNPM(string JMBKDINHDLO)
	{
		return JNBICAJIJMM.EEOPOHEALPK().HEIBEHAEHBM(JMBKDINHDLO);
	}

	// Token: 0x06007342 RID: 29506 RVA: 0x0037083C File Offset: 0x0036EA3C
	public void KENLOMENGHG()
	{
		string path = Application.streamingAssetsPath + "#> _Planar Reflection Camera < ";
		XmlDocument xmlDocument = new XmlDocument();
		string xml = File.ReadAllText(path, Encoding.UTF8);
		xmlDocument.LoadXml(xml);
		foreach (object obj in xmlDocument.SelectNodes("file"))
		{
			JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn = new JNBICAJIJMM.MGNCAGDEFHN((XmlNode)obj);
			this.KAEJBIHMFDF.Add(mgncagdefhn.LPFKFNLHGBI, mgncagdefhn);
		}
		this.LCHEIFBGJMF = PlayerPrefs.GetInt("Закрыть");
		if (PlayerPrefs.GetInt("offsets") <= 0)
		{
			this.LCHEIFBGJMF = 5;
			PlayerPrefs.SetInt("Mouse X", 1);
			if (SteamManager.LCIFODJFFBL() && SteamUtils.GetSteamUILanguage() == "BipedReferences spine bone at index ")
			{
				this.LCHEIFBGJMF = 0;
			}
			PlayerPrefs.SetInt("_SampleScale", this.LCHEIFBGJMF);
		}
		this.GLPAPGLHOFF = this.KAEJBIHMFDF[this.LCHEIFBGJMF];
		this.PAJBPDJCHJB = false;
	}

	// Token: 0x06007343 RID: 29507 RVA: 0x00370950 File Offset: 0x0036EB50
	public string HFDIEKGBGEN(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "OnRenderImage in Helper called ..."];
		}
		catch
		{
			result = "ShotgunReloadMagazine" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x06007344 RID: 29508 RVA: 0x003709A0 File Offset: 0x0036EBA0
	public static string CDDCIKKDFMP(string JMBKDINHDLO)
	{
		return JNBICAJIJMM.LPHMKPDBMPP().GNKIBMGNHNE(JMBKDINHDLO);
	}

	// Token: 0x06007345 RID: 29509 RVA: 0x003709AD File Offset: 0x0036EBAD
	public string BOCCBJPOLFG(int LPFKFNLHGBI)
	{
		if (!this.BPHAOIDBMLJ.ContainsKey(LPFKFNLHGBI))
		{
			return "_Offsets";
		}
		return this.BPHAOIDBMLJ[LPFKFNLHGBI];
	}

	// Token: 0x06007346 RID: 29510 RVA: 0x003709D0 File Offset: 0x0036EBD0
	public string NLIDKILDCNL(string NEFCJNIEKIM)
	{
		string str = "FlyLeft" + this.GLPAPGLHOFF.GMDCCFLLCJA + "RunningDance";
		return Application.streamingAssetsPath + str + NEFCJNIEKIM;
	}

	// Token: 0x06007347 RID: 29511 RVA: 0x00370A04 File Offset: 0x0036EC04
	public string GOOKDBEDLHJ(string LPIJLEDOKPA, string JMBKDINHDLO)
	{
		LPIJLEDOKPA = LPIJLEDOKPA.ToUpper();
		JMBKDINHDLO = JMBKDINHDLO.ToUpper();
		if (this.BIFFHBHIMJN.ContainsKey(LPIJLEDOKPA))
		{
			return this.BIFFHBHIMJN[LPIJLEDOKPA].HONLNLEMJPG(JMBKDINHDLO);
		}
		string[] array = new string[6];
		array[1] = "";
		array[0] = LPIJLEDOKPA;
		array[4] = "Pistol Reload";
		array[3] = JMBKDINHDLO;
		array[0] = "no_adm";
		return string.Concat(array);
	}

	// Token: 0x06007348 RID: 29512 RVA: 0x00370A70 File Offset: 0x0036EC70
	public string ECDAPHMNOMB(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "_BlurVector"];
		}
		catch
		{
			result = "Eat" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x06007349 RID: 29513 RVA: 0x00370AC0 File Offset: 0x0036ECC0
	public void KKPOKAPAPBH()
	{
		this.LGFJMPLCGJM = true;
		this.PAJBPDJCHJB = false;
		this.KAEJBIHMFDF.Clear();
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		this.BEKJKILAJMM.Clear();
		this.BIFFHBHIMJN.Clear();
		this.BPHAOIDBMLJ.Clear();
		this.JOGHFKDCNLL();
		FlyMessageManager.getI.LPIIICIDCOM();
		GuiProcessor.BBLINJLBAIL().CNKIDEAKBIC("_WhiteBalance");
	}

	// Token: 0x0600734A RID: 29514 RVA: 0x0036DA10 File Offset: 0x0036BC10
	public static JNBICAJIJMM EEOPOHEALPK()
	{
		if (JNBICAJIJMM.CCHGNBELGIA == null)
		{
			JNBICAJIJMM.CCHGNBELGIA = new JNBICAJIJMM();
			JNBICAJIJMM.CCHGNBELGIA.CHMOEIHFKGA();
		}
		return JNBICAJIJMM.CCHGNBELGIA;
	}

	// Token: 0x0600734B RID: 29515 RVA: 0x00370B3C File Offset: 0x0036ED3C
	public string DPIHNBEBDJF(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "OfficeSittingEyesRub"];
		}
		catch
		{
			result = "_ScreenSize" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x0600734C RID: 29516 RVA: 0x00370B8C File Offset: 0x0036ED8C
	public string JLDLEFLDHCM(int HDELGEDDDCE, int GDNPMHOLMPN = 0)
	{
		string text = HDELGEDDDCE + "no_move_sadok";
		string key = text;
		if (GDNPMHOLMPN != 0)
		{
			object[] array = new object[6];
			array[1] = HDELGEDDDCE;
			array[1] = "Hip";
			array[2] = GDNPMHOLMPN;
			array[6] = "LHandPunch";
			text = string.Concat(array);
		}
		if (this.OLKOOGMLDKM.ContainsKey(text))
		{
			return this.OLKOOGMLDKM[text];
		}
		if (this.OLKOOGMLDKM.ContainsKey(key))
		{
			return this.OLKOOGMLDKM[key];
		}
		return "Windmill" + text + "IdleStrafeRight";
	}

	// Token: 0x0600734D RID: 29517 RVA: 0x00370C24 File Offset: 0x0036EE24
	public string IFPLJCMFACP(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "KatanaReady"];
		}
		catch
		{
			result = "demoRect" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x0600734E RID: 29518 RVA: 0x00370C74 File Offset: 0x0036EE74
	public string GHPNJJIMCKF(string NEFCJNIEKIM, bool CCMHKFIDJIH = false)
	{
		Encoding encoding = Encoding.UTF8;
		if (CCMHKFIDJIH)
		{
			encoding = Encoding.GetEncoding(this.GLPAPGLHOFF.ANGFHENANPD);
		}
		return File.ReadAllText(this.CFLKMHCIBLN(NEFCJNIEKIM), encoding);
	}

	// Token: 0x0600734F RID: 29519 RVA: 0x00370CA8 File Offset: 0x0036EEA8
	public void CHMOEIHFKGA()
	{
		if (!this.PAJBPDJCHJB)
		{
			this.FLJJNACONGM();
		}
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		AAEEEJIDDEO aaeeejiddeo = new AAEEEJIDDEO(this.KFHFODNFCNL("Weapon Reload", true));
		string[] array = aaeeejiddeo.KMHHHAMKPKN("ragulaEventProc");
		for (int i = 1; i < array.Length; i++)
		{
			string text = array[i];
			this.KKPOBNBBOKB.Add(text, aaeeejiddeo.NLEOHJHBGKF(" ", text));
		}
		foreach (string text2 in aaeeejiddeo.CMHKJBPLLMD("#FF4040"))
		{
			this.OLKOOGMLDKM.Add(text2, aaeeejiddeo.NDLFBDMIGLF("[ACTk] Injection Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", text2));
		}
		aaeeejiddeo = new AAEEEJIDDEO(this.KFHFODNFCNL("BackPress", false));
		this.BIFFHBHIMJN.Add("RHandPunch", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "\n"));
		this.BIFFHBHIMJN.Add("FistPump2", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "TenkokuModule"));
		this.BIFFHBHIMJN.Add("Mesh", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "{0}"));
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(this.BGOJCAABLNC("saveTreeNodeState SV=", true));
		foreach (object obj in xmlDocument.SelectNodes("Sound/"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			this.BPHAOIDBMLJ.Add(int.Parse(xmlNode.Attributes["rait_2"].Value), xmlNode.Attributes["Hidden/Post FX/Temporal Anti-aliasing"].Value);
		}
		NLNNIDBPKAO.IKGFHGKKCPG.JEOPOICACFK();
		IHFEDJEMJMB.JHAAMBEFENP().BCMIIMNMKNO();
		AKPJIACDDFI.IKGFHGKKCPG.JFGGHJDGOIA();
		BHNDGIPPPCE.IKGFHGKKCPG.MCEIJMJCDEF();
		GHGHFBNBBFE.IKGFHGKKCPG.NEJGJLIAOID();
		NHCAOFIKNFE.IKGFHGKKCPG.FCADNLJCCJA();
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x06007350 RID: 29520 RVA: 0x00370EB0 File Offset: 0x0036F0B0
	public string DPDPINLIGEI(string NEFCJNIEKIM)
	{
		string str = "Missing shader in " + this.GLPAPGLHOFF.GMDCCFLLCJA + "MotorbikeShootRight";
		return Application.streamingAssetsPath + str + NEFCJNIEKIM;
	}

	// Token: 0x06007351 RID: 29521 RVA: 0x00370EE4 File Offset: 0x0036F0E4
	public static JNBICAJIJMM APMJBBDBOJO()
	{
		if (JNBICAJIJMM.CCHGNBELGIA == null)
		{
			JNBICAJIJMM.CCHGNBELGIA = new JNBICAJIJMM();
			JNBICAJIJMM.CCHGNBELGIA.GJDCJFLEGMI();
		}
		return JNBICAJIJMM.CCHGNBELGIA;
	}

	// Token: 0x06007352 RID: 29522 RVA: 0x00370F08 File Offset: 0x0036F108
	public string NCEJIICKDNH(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "C"];
		}
		catch
		{
			result = "FaceHit" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x06007353 RID: 29523 RVA: 0x00370F58 File Offset: 0x0036F158
	public string DCANODCKKCG(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "WandStand"];
		}
		catch
		{
			result = "Materials/DFGDesktop" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x06007354 RID: 29524 RVA: 0x00370FA8 File Offset: 0x0036F1A8
	public static string OOOKJHOHPNN(string JMBKDINHDLO)
	{
		return JNBICAJIJMM.EEOPOHEALPK().HLBAJBLHLNI(JMBKDINHDLO);
	}

	// Token: 0x06007355 RID: 29525 RVA: 0x00370FB5 File Offset: 0x0036F1B5
	public static string DIOJFJMOPJO(string JMBKDINHDLO)
	{
		return JNBICAJIJMM.EEOPOHEALPK().FLEANFGEJML(JMBKDINHDLO);
	}

	// Token: 0x06007356 RID: 29526 RVA: 0x00370FC4 File Offset: 0x0036F1C4
	public void HLKMNAGCFOM()
	{
		if (!this.PAJBPDJCHJB)
		{
			this.CEINLNFIPGE();
		}
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		AAEEEJIDDEO aaeeejiddeo = new AAEEEJIDDEO(this.CHFGNHKJNFG("_SampleMip", true));
		foreach (string text in aaeeejiddeo.MEMPJHCJBGP("{0:D2}:{1:D2}"))
		{
			this.KKPOBNBBOKB.Add(text, aaeeejiddeo.HJOCLGGEFMP("no_change", text));
		}
		string[] array = aaeeejiddeo.KMHHHAMKPKN("_ReflectionTexture2");
		for (int i = 0; i < array.Length; i += 0)
		{
			string text2 = array[i];
			this.OLKOOGMLDKM.Add(text2, aaeeejiddeo.AOFBGJHGILA("_w", text2));
		}
		aaeeejiddeo = new AAEEEJIDDEO(this.KFHFODNFCNL("Katana", true));
		this.BIFFHBHIMJN.Add("wpn_bait1", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, " fid="));
		this.BIFFHBHIMJN.Add("id", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, ""));
		this.BIFFHBHIMJN.Add("Kernel", new JNBICAJIJMM.HBKLMIIHPAG(aaeeejiddeo, "Flares"));
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(this.IDFHKHHNDEK("inv_invheader", false));
		foreach (object obj in xmlDocument.SelectNodes(""))
		{
			XmlNode xmlNode = (XmlNode)obj;
			this.BPHAOIDBMLJ.Add(int.Parse(xmlNode.Attributes["WorkerShovel"].Value), xmlNode.Attributes["IceHockeyShotRight"].Value);
		}
		NLNNIDBPKAO.IKGFHGKKCPG.JEOPOICACFK();
		IHFEDJEMJMB.AGCBLDIBMNB().ODONNAANIEP();
		AKPJIACDDFI.IKGFHGKKCPG.JFGGHJDGOIA();
		BHNDGIPPPCE.IKGFHGKKCPG.CJNIKFIPCGL();
		GHGHFBNBBFE.IKGFHGKKCPG.KACCFJLDECI();
		NHCAOFIKNFE.IKGFHGKKCPG.DAEPKLHHBJF();
		this.LGFJMPLCGJM = false;
	}

	// Token: 0x06007357 RID: 29527 RVA: 0x003711CC File Offset: 0x0036F3CC
	public string KLMNGBHBOJE(string LPIJLEDOKPA, string JMBKDINHDLO)
	{
		LPIJLEDOKPA = LPIJLEDOKPA.ToUpper();
		JMBKDINHDLO = JMBKDINHDLO.ToUpper();
		if (this.BIFFHBHIMJN.ContainsKey(LPIJLEDOKPA))
		{
			return this.BIFFHBHIMJN[LPIJLEDOKPA].BDCJEKHGPKJ(JMBKDINHDLO);
		}
		string[] array = new string[0];
		array[0] = "no_move_sadok";
		array[1] = LPIJLEDOKPA;
		array[4] = "ProneLocomotion";
		array[2] = JMBKDINHDLO;
		array[2] = "This limb does not have a parent (shoulder) bone";
		return string.Concat(array);
	}

	// Token: 0x06007358 RID: 29528 RVA: 0x00371238 File Offset: 0x0036F438
	public void GANACIOEJMF()
	{
		string path = Application.streamingAssetsPath + "{0:0} мин{1}, ";
		XmlDocument xmlDocument = new XmlDocument();
		string xml = File.ReadAllText(path, Encoding.UTF8);
		xmlDocument.LoadXml(xml);
		foreach (object obj in xmlDocument.SelectNodes("wpn_popl1"))
		{
			JNBICAJIJMM.MGNCAGDEFHN mgncagdefhn = new JNBICAJIJMM.MGNCAGDEFHN((XmlNode)obj);
			this.KAEJBIHMFDF.Add(mgncagdefhn.LPFKFNLHGBI, mgncagdefhn);
		}
		this.LCHEIFBGJMF = PlayerPrefs.GetInt("Add inventory Click!");
		if (PlayerPrefs.GetInt("ignorelist") <= 1)
		{
			this.LCHEIFBGJMF = 0;
			PlayerPrefs.SetInt("u_UniqueShadowBlockerDistanceScale", 1);
			if (SteamManager.OIPNMDCOJMD() && SteamUtils.GetSteamUILanguage() == "> ")
			{
				this.LCHEIFBGJMF = 1;
			}
			PlayerPrefs.SetInt("IK.Disable() is deprecated. Use enabled = false instead", this.LCHEIFBGJMF);
		}
		this.GLPAPGLHOFF = this.KAEJBIHMFDF[this.LCHEIFBGJMF];
		this.PAJBPDJCHJB = false;
	}

	// Token: 0x06007359 RID: 29529 RVA: 0x0037134C File Offset: 0x0036F54C
	public string HLBAJBLHLNI(string JMBKDINHDLO)
	{
		return this.OMNMDGIGEFD("INTERFACE", JMBKDINHDLO).Replace("/ n", "\n").Replace("\\ n", "\n").Replace("\\n", "\n").Replace("/n", "\n");
	}

	// Token: 0x0600735A RID: 29530 RVA: 0x003713A4 File Offset: 0x0036F5A4
	public string LJEJINKGKAK(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "https://groups.google.com/forum/#!forum/final-ik"];
		}
		catch
		{
			result = "*************160 baseid=" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x0600735B RID: 29531 RVA: 0x003713F4 File Offset: 0x0036F5F4
	public string HHOIGKJMAGP(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "Invalid IKEffector.position (contains Infinity)!"];
		}
		catch
		{
			result = "_FgCocMask" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x0600735C RID: 29532 RVA: 0x00371444 File Offset: 0x0036F644
	public void DIINOACMHKH()
	{
		this.LGFJMPLCGJM = false;
		this.PAJBPDJCHJB = true;
		this.KAEJBIHMFDF.Clear();
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		this.BEKJKILAJMM.Clear();
		this.BIFFHBHIMJN.Clear();
		this.BPHAOIDBMLJ.Clear();
		this.PINLMCCKKNA();
		FlyMessageManager.getI.FADANIMLJIF();
		GuiProcessor.PLGADNLAEGN().sendMsg("<color='#ffa000'>неизвестная профессия");
	}

	// Token: 0x0600735D RID: 29533 RVA: 0x003714C0 File Offset: 0x0036F6C0
	public string DDKLHGHBEIG(string NEFCJNIEKIM, bool CCMHKFIDJIH = false)
	{
		Encoding encoding = Encoding.UTF8;
		if (CCMHKFIDJIH)
		{
			encoding = Encoding.GetEncoding(this.GLPAPGLHOFF.ANGFHENANPD);
		}
		return File.ReadAllText(this.FFPIMDCPLBE(NEFCJNIEKIM), encoding);
	}

	// Token: 0x0600735E RID: 29534 RVA: 0x003714F4 File Offset: 0x0036F6F4
	public void CPJELOEFNIM()
	{
		this.LGFJMPLCGJM = false;
		this.PAJBPDJCHJB = true;
		this.KAEJBIHMFDF.Clear();
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		this.BEKJKILAJMM.Clear();
		this.BIFFHBHIMJN.Clear();
		this.BPHAOIDBMLJ.Clear();
		this.BBCINJAGHEP();
		FlyMessageManager.getI.PENFDGILGEJ();
		GuiProcessor.NKOEAPCIBKO().BPGHPGOJBAF(" tm=");
	}

	// Token: 0x0600735F RID: 29535 RVA: 0x00371570 File Offset: 0x0036F770
	public string AKGFHCDACLM(int EHIMDFJKMHA)
	{
		return this.BEKJKILAJMM[EHIMDFJKMHA + "_Threshhold"];
	}

	// Token: 0x06007360 RID: 29536 RVA: 0x00371590 File Offset: 0x0036F790
	public void EMHNEMCMPAK()
	{
		this.LGFJMPLCGJM = true;
		this.PAJBPDJCHJB = false;
		this.KAEJBIHMFDF.Clear();
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		this.BEKJKILAJMM.Clear();
		this.BIFFHBHIMJN.Clear();
		this.BPHAOIDBMLJ.Clear();
		this.GJDCJFLEGMI();
		FlyMessageManager.getI.FADANIMLJIF();
		GuiProcessor.PLGADNLAEGN().BPGHPGOJBAF("_DepthFade");
	}

	// Token: 0x06007361 RID: 29537 RVA: 0x0037160C File Offset: 0x0036F80C
	public string ECNKLECOKHD(string JMBKDINHDLO)
	{
		return this.KLMNGBHBOJE("Animation controllers should be parented to character controllers!", JMBKDINHDLO).Replace("[Z]", "Pick Up Ball").Replace("IdleReadyLook", "Rigidbody dragger").Replace("Left arm 'Wrist To Palm Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the wrist towards the palm. If the arrow points away from the palm, axis must be negative.", "128").Replace(" ", "_HueShift");
	}

	// Token: 0x06007362 RID: 29538 RVA: 0x00371664 File Offset: 0x0036F864
	public string FFHHBGFKBJM(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "_RampTex"];
		}
		catch
		{
			result = "Horizontal" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x06007363 RID: 29539 RVA: 0x003716B4 File Offset: 0x0036F8B4
	public string FDJBNCHPHGK(string NEFCJNIEKIM, bool CCMHKFIDJIH = false)
	{
		Encoding encoding = Encoding.UTF8;
		if (CCMHKFIDJIH)
		{
			encoding = Encoding.GetEncoding(this.GLPAPGLHOFF.ANGFHENANPD);
		}
		return File.ReadAllText(this.DPDPINLIGEI(NEFCJNIEKIM), encoding);
	}

	// Token: 0x06007364 RID: 29540 RVA: 0x003716E8 File Offset: 0x0036F8E8
	public string LMFAEHMNGOG(int LPFKFNLHGBI)
	{
		if (!this.BPHAOIDBMLJ.ContainsKey(LPFKFNLHGBI))
		{
			return "ClimbIdle";
		}
		return this.BPHAOIDBMLJ[LPFKFNLHGBI];
	}

	// Token: 0x06007365 RID: 29541 RVA: 0x0037170C File Offset: 0x0036F90C
	public string AMJENIENOBM(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "Turn Left"];
		}
		catch
		{
			result = "path" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x06007366 RID: 29542 RVA: 0x0037175C File Offset: 0x0036F95C
	public string GIGGIHMAPLH(string NEFCJNIEKIM, bool CCMHKFIDJIH = false)
	{
		Encoding encoding = Encoding.UTF8;
		if (CCMHKFIDJIH)
		{
			encoding = Encoding.GetEncoding(this.GLPAPGLHOFF.ANGFHENANPD);
		}
		return File.ReadAllText(this.FMFPNGELOEN(NEFCJNIEKIM), encoding);
	}

	// Token: 0x06007367 RID: 29543 RVA: 0x00371790 File Offset: 0x0036F990
	public static string DCEBAJIILPC(string JMBKDINHDLO)
	{
		return JNBICAJIJMM.EKEBHIJMEML().DOEMGEAEBPN(JMBKDINHDLO);
	}

	// Token: 0x06007368 RID: 29544 RVA: 0x003717A0 File Offset: 0x0036F9A0
	public string DOEMGEAEBPN(string JMBKDINHDLO)
	{
		return this.KLMNGBHBOJE("Idle Keep Back", JMBKDINHDLO).Replace("wpn_bait_sz", "_FogScatteringData2").Replace("auc_reshdr", "https://www.youtube.com/watch?v=eP9-zycoHLk").Replace("money", "[^a-zA-z\\d_]").Replace("HeelClick", "UNIQUE_SHADOW_LIGHT_COOKIE");
	}

	// Token: 0x06007369 RID: 29545 RVA: 0x003717F5 File Offset: 0x0036F9F5
	public string ELLEMPHPOIF(int EHIMDFJKMHA)
	{
		return this.BEKJKILAJMM[EHIMDFJKMHA + "FishController"];
	}

	// Token: 0x0600736A RID: 29546 RVA: 0x00371814 File Offset: 0x0036FA14
	public void CFJDCIHPOCN()
	{
		this.LGFJMPLCGJM = false;
		this.PAJBPDJCHJB = false;
		this.KAEJBIHMFDF.Clear();
		this.KKPOBNBBOKB.Clear();
		this.OLKOOGMLDKM.Clear();
		this.BEKJKILAJMM.Clear();
		this.BIFFHBHIMJN.Clear();
		this.BPHAOIDBMLJ.Clear();
		this.FJPNMHHGEEH();
		FlyMessageManager.getI.AMMFDKEBFGD();
		GuiProcessor.NKOEAPCIBKO().CNKIDEAKBIC("Worker Shovel");
	}

	// Token: 0x0600736B RID: 29547 RVA: 0x00371890 File Offset: 0x0036FA90
	public string OFHOALBBKGC(int PNEDPPPEFFG)
	{
		string result;
		try
		{
			result = this.KKPOBNBBOKB[PNEDPPPEFFG + "_Jitter"];
		}
		catch
		{
			result = "WalkDehydrated" + PNEDPPPEFFG;
		}
		return result;
	}

	// Token: 0x040010B9 RID: 4281
	private static JNBICAJIJMM CCHGNBELGIA;

	// Token: 0x040010BA RID: 4282
	public Dictionary<int, JNBICAJIJMM.MGNCAGDEFHN> KAEJBIHMFDF = new Dictionary<int, JNBICAJIJMM.MGNCAGDEFHN>();

	// Token: 0x040010BB RID: 4283
	private readonly Dictionary<string, string> KKPOBNBBOKB = new Dictionary<string, string>();

	// Token: 0x040010BC RID: 4284
	private readonly Dictionary<string, string> OLKOOGMLDKM = new Dictionary<string, string>();

	// Token: 0x040010BD RID: 4285
	private readonly Dictionary<string, string> BEKJKILAJMM = new Dictionary<string, string>();

	// Token: 0x040010BE RID: 4286
	public Dictionary<string, JNBICAJIJMM.HBKLMIIHPAG> BIFFHBHIMJN = new Dictionary<string, JNBICAJIJMM.HBKLMIIHPAG>();

	// Token: 0x040010BF RID: 4287
	public Dictionary<int, string> BPHAOIDBMLJ = new Dictionary<int, string>();

	// Token: 0x040010C0 RID: 4288
	private bool LGFJMPLCGJM;

	// Token: 0x040010C1 RID: 4289
	private bool PAJBPDJCHJB;

	// Token: 0x040010C2 RID: 4290
	public int LCHEIFBGJMF;

	// Token: 0x040010C3 RID: 4291
	public JNBICAJIJMM.MGNCAGDEFHN GLPAPGLHOFF;

	// Token: 0x020001F0 RID: 496
	public class MGNCAGDEFHN
	{
		// Token: 0x0600736C RID: 29548 RVA: 0x003718E0 File Offset: 0x0036FAE0
		public MGNCAGDEFHN(XmlNode JEEEOEBNJDJ)
		{
			this.LPFKFNLHGBI = int.Parse(JEEEOEBNJDJ.Attributes["id"].Value);
			this.LNMEGPEGLMG = JEEEOEBNJDJ.Attributes["stname"].Value;
			this.ANGFHENANPD = int.Parse(JEEEOEBNJDJ.Attributes["codepage"].Value);
			this.JFGKIGAACHI = JEEEOEBNJDJ.Attributes["short"].Value;
			this.MNGHILMCBCI = JEEEOEBNJDJ.Attributes["full"].Value;
			this.GMDCCFLLCJA = JEEEOEBNJDJ.Attributes["dir"].Value;
		}

		// Token: 0x040010C4 RID: 4292
		public int LPFKFNLHGBI;

		// Token: 0x040010C5 RID: 4293
		public string LNMEGPEGLMG;

		// Token: 0x040010C6 RID: 4294
		public string JFGKIGAACHI;

		// Token: 0x040010C7 RID: 4295
		public string MNGHILMCBCI;

		// Token: 0x040010C8 RID: 4296
		public string GMDCCFLLCJA;

		// Token: 0x040010C9 RID: 4297
		public int ANGFHENANPD;
	}

	// Token: 0x020001F1 RID: 497
	public class HBKLMIIHPAG
	{
		// Token: 0x0600736D RID: 29549 RVA: 0x0037199F File Offset: 0x0036FB9F
		public string LBNGNFOPIAH(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "{0}";
		}

		// Token: 0x0600736E RID: 29550 RVA: 0x003719D1 File Offset: 0x0036FBD1
		public string NGPOFGKNNNH(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "_NoiseAmount";
		}

		// Token: 0x0600736F RID: 29551 RVA: 0x00371A03 File Offset: 0x0036FC03
		public string PKEOBNDHIEL(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "pf1m";
		}

		// Token: 0x06007370 RID: 29552 RVA: 0x00371A35 File Offset: 0x0036FC35
		public string MHICKIBKMPI(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "delcharmsg2";
		}

		// Token: 0x06007371 RID: 29553 RVA: 0x00371A67 File Offset: 0x0036FC67
		public string NKNBHCLMJEM(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "_TempRT";
		}

		// Token: 0x06007372 RID: 29554 RVA: 0x00371A99 File Offset: 0x0036FC99
		public string OOEEEEDOFCH(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "wpn_iwgt";
		}

		// Token: 0x06007373 RID: 29555 RVA: 0x00371ACB File Offset: 0x0036FCCB
		public string AEPFPPKDPIO(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "WateringCanWatering";
		}

		// Token: 0x06007374 RID: 29556 RVA: 0x00371AFD File Offset: 0x0036FCFD
		public string GHAMBOEPBHF(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "";
		}

		// Token: 0x06007375 RID: 29557 RVA: 0x00371B2F File Offset: 0x0036FD2F
		public string CNHMOCDCHBB(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "CrouchStrafeRight";
		}

		// Token: 0x06007376 RID: 29558 RVA: 0x00371AFD File Offset: 0x0036FCFD
		public string GDBGLOEPFHI(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "";
		}

		// Token: 0x06007377 RID: 29559 RVA: 0x00371B61 File Offset: 0x0036FD61
		public string BCMCAMIOIEJ(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "_BaseTex";
		}

		// Token: 0x06007378 RID: 29560 RVA: 0x00371B93 File Offset: 0x0036FD93
		public string DJFGPEGOAGN(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "_parent";
		}

		// Token: 0x06007379 RID: 29561 RVA: 0x00371BC5 File Offset: 0x0036FDC5
		public string MNBJHAGGMPD(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "spin_bell.ogg";
		}

		// Token: 0x0600737A RID: 29562 RVA: 0x00371BF7 File Offset: 0x0036FDF7
		public string IFKKBEHDCBN(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "HeelClick";
		}

		// Token: 0x0600737B RID: 29563 RVA: 0x00371C29 File Offset: 0x0036FE29
		public string ECAJJMIJKNH(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + " ?";
		}

		// Token: 0x0600737C RID: 29564 RVA: 0x00371C5B File Offset: 0x0036FE5B
		public string EFEOCLJHDGO(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "System.Single";
		}

		// Token: 0x0600737D RID: 29565 RVA: 0x00371C8D File Offset: 0x0036FE8D
		public string HONLNLEMJPG(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "fider_Small_";
		}

		// Token: 0x0600737E RID: 29566 RVA: 0x00371CBF File Offset: 0x0036FEBF
		public string DMNMNDFGHPN(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "turn_tminfo";
		}

		// Token: 0x0600737F RID: 29567 RVA: 0x00371CF4 File Offset: 0x0036FEF4
		public HBKLMIIHPAG(AAEEEJIDDEO EGLJDFGHKGB, string BJNEMHFKNEC)
		{
			foreach (string text in EGLJDFGHKGB.MEMPJHCJBGP(BJNEMHFKNEC))
			{
				this.MJPLBILHHDL.Add(text.ToUpper(), EGLJDFGHKGB.HJOCLGGEFMP(BJNEMHFKNEC, text));
			}
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x00371D45 File Offset: 0x0036FF45
		public string ELPOLBDMPID(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + " ";
		}

		// Token: 0x06007381 RID: 29569 RVA: 0x00371D77 File Offset: 0x0036FF77
		public string HPFFIFLHKEF(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "_BlurVector";
		}

		// Token: 0x06007382 RID: 29570 RVA: 0x00371DA9 File Offset: 0x0036FFA9
		public string BDCJEKHGPKJ(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "isKeyPress";
		}

		// Token: 0x06007383 RID: 29571 RVA: 0x00371DDB File Offset: 0x0036FFDB
		public string EBAJOCPIBAC(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "IdleCheer";
		}

		// Token: 0x06007384 RID: 29572 RVA: 0x00371E0D File Offset: 0x0037000D
		public string ALPKJDHMDKB(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "wpn_dress1";
		}

		// Token: 0x06007385 RID: 29573 RVA: 0x00371E3F File Offset: 0x0037003F
		public string BBAFGGLDGCE(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "OfficeSittingReadingCoffeeSip";
		}

		// Token: 0x06007386 RID: 29574 RVA: 0x00371E71 File Offset: 0x00370071
		public string GEBKGKAIHOL(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "lifeBar";
		}

		// Token: 0x06007387 RID: 29575 RVA: 0x00371EA3 File Offset: 0x003700A3
		public string NGPDPFCFIBJ(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "SexyDance";
		}

		// Token: 0x06007388 RID: 29576 RVA: 0x00371AFD File Offset: 0x0036FCFD
		public string CJGIKNNEMBL(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "";
		}

		// Token: 0x06007389 RID: 29577 RVA: 0x00371ED5 File Offset: 0x003700D5
		public string HEPDKLCONAF(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "IdleFly";
		}

		// Token: 0x0600738A RID: 29578 RVA: 0x00371F07 File Offset: 0x00370107
		public string ABMFPENFDNF(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "\n";
		}

		// Token: 0x0600738B RID: 29579 RVA: 0x00371F39 File Offset: 0x00370139
		public string LHIFKPGNHBD(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "crft_to";
		}

		// Token: 0x0600738C RID: 29580 RVA: 0x00371F6B File Offset: 0x0037016B
		public string FEOJKAKBGBP(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "_SecondTex";
		}

		// Token: 0x0600738D RID: 29581 RVA: 0x00371F9D File Offset: 0x0037019D
		public string BKMIEKHECOI(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "Mid";
		}

		// Token: 0x0600738E RID: 29582 RVA: 0x00371FCF File Offset: 0x003701CF
		public string NMFKFFCAKGN(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "GiantGrabThrow2";
		}

		// Token: 0x0600738F RID: 29583 RVA: 0x00372001 File Offset: 0x00370201
		public string MFNPEHBNOFF(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "_MaxSteps";
		}

		// Token: 0x06007390 RID: 29584 RVA: 0x00372033 File Offset: 0x00370233
		public string FGBJGEEAFOK(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "AC_DITHERING";
		}

		// Token: 0x06007391 RID: 29585 RVA: 0x00372065 File Offset: 0x00370265
		public string ILHGKFMIJDG(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "_Offsets";
		}

		// Token: 0x06007392 RID: 29586 RVA: 0x00372097 File Offset: 0x00370297
		public string CDCMKKECHNH(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "Flap_04.wav";
		}

		// Token: 0x06007393 RID: 29587 RVA: 0x003720C9 File Offset: 0x003702C9
		public string EMHPDCFGDAH(string JMBKDINHDLO)
		{
			if (this.MJPLBILHHDL.ContainsKey(JMBKDINHDLO.ToUpper()))
			{
				return this.MJPLBILHHDL[JMBKDINHDLO.ToUpper()];
			}
			return JMBKDINHDLO + "IK Effector contains a null reference.";
		}

		// Token: 0x040010CA RID: 4298
		private readonly Dictionary<string, string> MJPLBILHHDL = new Dictionary<string, string>();
	}
}
