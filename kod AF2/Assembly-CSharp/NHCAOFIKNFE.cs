using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;
using UnityEngine;

// Token: 0x0200015C RID: 348
public class NHCAOFIKNFE
{
	// Token: 0x060049BF RID: 18879 RVA: 0x002284B8 File Offset: 0x002266B8
	public string KMGADIEIJHM(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("http://j.mp/1FRAL5L", BNIHFBMEPAB);
			text = text.Replace((char)-120, (char)(KJAGFDIIKFC ? -104 : -31));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "id", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x060049C0 RID: 18880 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO DGFJCOIHHGH(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049C1 RID: 18881 RVA: 0x00228538 File Offset: 0x00226738
	public Color EAHDLJIDFOC(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(363f, 675f, 425f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049C2 RID: 18882 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO BOKALEBEKDC(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049C3 RID: 18883 RVA: 0x0022857C File Offset: 0x0022677C
	public Color MDLJBINCHEP(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(457f, 1794f, 1012f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049C4 RID: 18884 RVA: 0x002285C0 File Offset: 0x002267C0
	public void CLFIKFCODIB()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("name", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.EDKGBBIIBBC().FDJBNCHPHGK("Billboards reference not set.", true));
		foreach (object obj in xmlDocument.SelectNodes("sunshine_ShadowCoordDepthRayZ"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["Pistol"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["double: "].Value);
			string value = xmlNode.Attributes["/"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x060049C5 RID: 18885 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO DGCIHNHGCCO(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049C6 RID: 18886 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO GMPFAJCDENI(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049C7 RID: 18887 RVA: 0x002286B8 File Offset: 0x002268B8
	public string HBMGCEMAPOK(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("Smoking1", BNIHFBMEPAB);
			text = text.Replace('B', (char)(KJAGFDIIKFC ? -123 : -16));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "Wizard2HandThrow", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x060049C8 RID: 18888 RVA: 0x0022871C File Offset: 0x0022691C
	public Color BAHOIALGCFF(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(698f, 280f, 79f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049C9 RID: 18889 RVA: 0x00228760 File Offset: 0x00226960
	public Color DDLCBNBPEFI(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(336f, 227f, 609f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049CA RID: 18890 RVA: 0x002287A4 File Offset: 0x002269A4
	public Color IPIDCNGCDLE(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(673f, 296f, 416f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049CB RID: 18891 RVA: 0x002287E8 File Offset: 0x002269E8
	public void OEICAEDHEPC()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("ProneLocomotion", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.EKEBHIJMEML().BGOJCAABLNC("ChannelCastOmni", false));
		foreach (object obj in xmlDocument.SelectNodes("WATER_VERTEX_DISPLACEMENT_OFF"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["signal_enable"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["ArmFlex"].Value);
			string value = xmlNode.Attributes["CrawlLocomotion"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x060049CC RID: 18892 RVA: 0x002288E0 File Offset: 0x00226AE0
	public void DGGMIFLJFBM()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("_LoopCount", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.IKGFHGKKCPG.DOJJAFNAHKF("GAMMA", false));
		foreach (object obj in xmlDocument.SelectNodes("gi_uinf_1i"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["error.wav"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["signal_enable"].Value);
			string value = xmlNode.Attributes[""].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x060049CD RID: 18893 RVA: 0x002289D8 File Offset: 0x00226BD8
	public string HPPPPEHMEKL(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("http://af-2.ru/?q=store", BNIHFBMEPAB);
			text = text.Replace('|', (char)(KJAGFDIIKFC ? -18 : 9));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "showUsersInChat", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x060049CE RID: 18894 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO FKKEGDFAPPN(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049CF RID: 18895 RVA: 0x00228A3C File Offset: 0x00226C3C
	public void DAEPKLHHBJF()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("sunshine_CascadeNearRatiosSq", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.APMJBBDBOJO().FDJBNCHPHGK("TOD_MoonSkyColor", true));
		foreach (object obj in xmlDocument.SelectNodes(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package."))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["<color='#a0ff60'>"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["Sorry, VRIK Script reference is not finished yet."].Value);
			string value = xmlNode.Attributes[" is represented multiple times in the same BipedReferences limb."].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x060049D0 RID: 18896 RVA: 0x00228B34 File Offset: 0x00226D34
	public Color PGEJCFIBKJG(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(273f, 1868f, 1939f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049D1 RID: 18897 RVA: 0x00228B78 File Offset: 0x00226D78
	public string DGEINNMPILO(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("Failed parsing scalePlacement.  Setting to \"Fixed\"", BNIHFBMEPAB);
			text = text.Replace('t', (char)(KJAGFDIIKFC ? 30 : -69));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "RollerBladeJump", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x060049D2 RID: 18898 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO OGEPFGKONOK(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049D3 RID: 18899 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO EPDAHHDKGKN(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049D4 RID: 18900 RVA: 0x00228BDC File Offset: 0x00226DDC
	public void NOHAIMDPDNE()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("360SpinDeath", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.EEOPOHEALPK().DOJJAFNAHKF("selectTitulId=", false));
		foreach (object obj in xmlDocument.SelectNodes("http://j.mp/1gxg1tf"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["_BlurredColor"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["Assets/Weapons/baseLegs.unity3d"].Value);
			string value = xmlNode.Attributes[">"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x060049D5 RID: 18901 RVA: 0x00228CD4 File Offset: 0x00226ED4
	public Color IEMMANBNHNP(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(512f, 758f, 1116f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049D6 RID: 18902 RVA: 0x00228D18 File Offset: 0x00226F18
	public string GLFILPFCMGN(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("4", BNIHFBMEPAB);
			text = text.Replace('D', (char)(KJAGFDIIKFC ? -101 : 27));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "Weapon Fire", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x060049D7 RID: 18903 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO KINJGGIHLAC(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049D8 RID: 18904 RVA: 0x00228D7C File Offset: 0x00226F7C
	public void HMONBGDPGKL()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("sys", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.APMJBBDBOJO().CHFGNHKJNFG("(", false));
		foreach (object obj in xmlDocument.SelectNodes("Podsek action 2"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["IdleStun"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["_History2Weight"].Value);
			string value = xmlNode.Attributes["<color='#602060'>"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x060049D9 RID: 18905 RVA: 0x00228E74 File Offset: 0x00227074
	public void NFIEAPBGGKJ()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("MotorbikeSuperman", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.CLIMNFDGOEG().FDJBNCHPHGK("Roller Blade Roll", true));
		foreach (object obj in xmlDocument.SelectNodes("none id="))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["_BlurSize"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["Skateboard"].Value);
			string value = xmlNode.Attributes["Goscurry is not a lie ;)"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x060049DA RID: 18906 RVA: 0x00228F6C File Offset: 0x0022716C
	public void NMKBGMBCHCH()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("MotorbikeShootLeft", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.CLIMNFDGOEG().CHFGNHKJNFG("", true));
		foreach (object obj in xmlDocument.SelectNodes("</color>"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["Apply 1"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["error.wav"].Value);
			string value = xmlNode.Attributes["ambientVolume"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x060049DB RID: 18907 RVA: 0x00229064 File Offset: 0x00227264
	public void OFJONGKNLCD()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("GAMMA", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.IMLLGEMPHAP().JPEDCGHDNPN("#> _Shadow Camera < ", false));
		foreach (object obj in xmlDocument.SelectNodes("Vertical"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["RollerBladeGrindRoyale"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["_TintColor"].Value);
			string value = xmlNode.Attributes["invn_rec2"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x060049DC RID: 18908 RVA: 0x0022915C File Offset: 0x0022735C
	public string DJMOAHJEBFF(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("Giant2HandSlamIdle", BNIHFBMEPAB);
			text = text.Replace((char)-86, KJAGFDIIKFC ? 'w' : '\b');
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "RollerBladeTurnLeft", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x060049DD RID: 18909 RVA: 0x002291C0 File Offset: 0x002273C0
	public Color EPIPJGHICLD(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(1145f, 1007f, 907f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049DE RID: 18910 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO PGGENNIGKAG(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049DF RID: 18911 RVA: 0x00229204 File Offset: 0x00227404
	public string HPLMICJFPAK(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("This is a hidden [H hidden]hyperlink[-H].\nThis is a visible [FA U][H visible]hyperlink[-H][FA -U].", BNIHFBMEPAB);
			text = text.Replace('\u0013', (char)(KJAGFDIIKFC ? -118 : 0));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "<size=12><color='{0}'>{1}</color></size>", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x060049E0 RID: 18912 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO NIOHNJCNOHL(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049E1 RID: 18913 RVA: 0x00229268 File Offset: 0x00227468
	public string PKOFLNMMADN(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("", BNIHFBMEPAB);
			text = text.Replace((char)-61, (char)(KJAGFDIIKFC ? -64 : -65));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "reel_type", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x060049E2 RID: 18914 RVA: 0x002292CC File Offset: 0x002274CC
	public Color PKADGGDGBGO(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(1717f, 164f, 405f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049E3 RID: 18915 RVA: 0x00229310 File Offset: 0x00227510
	public void ELDHALELKIN()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Invalid vertex colors assigned to ", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.LPHMKPDBMPP().GHPNJJIMCKF("Root", false));
		foreach (object obj in xmlDocument.SelectNodes("Bow Instant"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["invn_ver1"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["VaderChoke"].Value);
			string value = xmlNode.Attributes["wpn_book1"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x060049E4 RID: 18916 RVA: 0x00229408 File Offset: 0x00227608
	public Color AAGFEIGBGBM(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(530f, 99f, 106f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049E5 RID: 18917 RVA: 0x0022944C File Offset: 0x0022764C
	public Color LPCFLOFAOMF(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(1789f, 481f, 1646f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049E6 RID: 18918 RVA: 0x00229490 File Offset: 0x00227690
	public void BLBAFAPODIP()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Cowboy1HandDraw", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.DBMJJPBOPEK().KKLNLPKAJDL("Twist", false));
		foreach (object obj in xmlDocument.SelectNodes("SoccerKeeperDiveStrafeCloseRight"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes[""].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["<[^>]+>"].Value);
			string value = xmlNode.Attributes["\n"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x060049E7 RID: 18919 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO OAKPODFKMEI(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049E8 RID: 18920 RVA: 0x00229588 File Offset: 0x00227788
	public void HGCFKEMKGPK()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("<color='#6080ff'>", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.CLIMNFDGOEG().DDKLHGHBEIG(" ", true));
		foreach (object obj in xmlDocument.SelectNodes(" %"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["IceHockeyShotRight"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["WoodCut"].Value);
			string value = xmlNode.Attributes["__a"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x060049E9 RID: 18921 RVA: 0x00229680 File Offset: 0x00227880
	public void BOIOCDEHDAE()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("<b>ObscuredString:</b> ", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.LPHMKPDBMPP().BOOGBOODHFK("Right", true));
		foreach (object obj in xmlDocument.SelectNodes("none"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["OnTriggerExit"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["4"].Value);
			string value = xmlNode.Attributes["id"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x060049EA RID: 18922 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO EHEEIFJGLFK(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049EB RID: 18923 RVA: 0x00229778 File Offset: 0x00227978
	public Color IFJLOKKAAMK(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(1809f, 1535f, 305f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049EC RID: 18924 RVA: 0x002297BC File Offset: 0x002279BC
	public Color CNENPBMADGI(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(594f, 91f, 376f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049ED RID: 18925 RVA: 0x00229800 File Offset: 0x00227A00
	public Color JCMJOKAIMLJ(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(1637f, 1364f, 160f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049EE RID: 18926 RVA: 0x00229844 File Offset: 0x00227A44
	public Color HCINMKFKAHJ(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(1019f, 1036f, 1319f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049EF RID: 18927 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO HCPFODDMKJF(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049F0 RID: 18928 RVA: 0x00229888 File Offset: 0x00227A88
	public string KLCCFECNEAN(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("wpn_chair2", BNIHFBMEPAB);
			text = text.Replace('>', KJAGFDIIKFC ? 'Z' : '8');
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "Flares", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x060049F1 RID: 18929 RVA: 0x002298EC File Offset: 0x00227AEC
	public string BEGAIJKPDDD(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("FishbragContainer", BNIHFBMEPAB);
			text = text.Replace((char)-53, (char)(KJAGFDIIKFC ? -6 : 85));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "_TileMaxLoop", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x060049F2 RID: 18930 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO JAKCCPGDCFK(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049F3 RID: 18931 RVA: 0x00229950 File Offset: 0x00227B50
	public string KOONNKMMCBB(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("string: ", BNIHFBMEPAB);
			text = text.Replace((char)-28, (char)(KJAGFDIIKFC ? -80 : 120));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "USE_DIAG_SEARCH", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x060049F4 RID: 18932 RVA: 0x002299B4 File Offset: 0x00227BB4
	public string FGNOEEAHKED(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("help", BNIHFBMEPAB);
			text = text.Replace((char)-9, (char)(KJAGFDIIKFC ? 38 : -31));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "Failed parsing organizational group.  Setting to group 0", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x060049F5 RID: 18933 RVA: 0x00229A18 File Offset: 0x00227C18
	public Color KGMAMJMJOHF(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(1785f, 686f, 1512f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049F6 RID: 18934 RVA: 0x00229A5C File Offset: 0x00227C5C
	public string LCILNGKKLPN(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("holes_max", BNIHFBMEPAB);
			text = text.Replace('/', (char)(KJAGFDIIKFC ? -83 : -12));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x060049F7 RID: 18935 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO GGGDFBJCMIH(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049F8 RID: 18936 RVA: 0x00229AC0 File Offset: 0x00227CC0
	public Color PMJBHIIILIP(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(328f, 598f, 191f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049F9 RID: 18937 RVA: 0x00229B04 File Offset: 0x00227D04
	public string BCDJLDLHEKP(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("BlackSmithForge", BNIHFBMEPAB);
			text = text.Replace('%', (char)(KJAGFDIIKFC ? 86 : -62));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "1", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x060049FA RID: 18938 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO JOAMONKNOMK(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049FB RID: 18939 RVA: 0x00229B68 File Offset: 0x00227D68
	public Color POHHAIPMJOA(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(1995f, 1037f, 264f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049FC RID: 18940 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO GMHEMMIKGKE(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049FD RID: 18941 RVA: 0x00229BAC File Offset: 0x00227DAC
	public Color KMCDCHNINAF(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(1266f, 1288f, 1513f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x060049FE RID: 18942 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO DEEADEPFPFI(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x060049FF RID: 18943 RVA: 0x00229BF0 File Offset: 0x00227DF0
	public string HHJHDLHKJDF(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("[name]", BNIHFBMEPAB);
			text = text.Replace('~', KJAGFDIIKFC ? '\n' : ' ');
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "<[^>]+>", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x06004A00 RID: 18944 RVA: 0x00229C54 File Offset: 0x00227E54
	public void ELPPMLOCLAI()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("-UNDERLINE", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.LPHMKPDBMPP().FDJBNCHPHGK("Wizard2HandThrow", true));
		foreach (object obj in xmlDocument.SelectNodes(" ms"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["only_one"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["gi_nach"].Value);
			string value = xmlNode.Attributes["WizardBlock"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A01 RID: 18945 RVA: 0x00229D4C File Offset: 0x00227F4C
	public string EDCDLKNNBGC(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("\n", BNIHFBMEPAB);
			text = text.Replace('\u0014', KJAGFDIIKFC ? 'F' : '<');
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "\n", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x06004A02 RID: 18946 RVA: 0x00229DB0 File Offset: 0x00227FB0
	public void NBDFDKJGBAH()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Quadruped", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.IKGFHGKKCPG.BGOJCAABLNC("OfficeSittingReadingCoffeeSip", false));
		foreach (object obj in xmlDocument.SelectNodes("WizardEyeBeam"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["\n"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["Collar"].Value);
			string value = xmlNode.Attributes["Moustaches"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A03 RID: 18947 RVA: 0x00229EA8 File Offset: 0x002280A8
	public void BNCLGBHPNPE()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("error.wav", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.DBMJJPBOPEK().IDFHKHHNDEK("минут", true));
		foreach (object obj in xmlDocument.SelectNodes("autherror"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["+{0}"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["SoccerKeeperStrafeRight"].Value);
			string value = xmlNode.Attributes["_alfavis"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A05 RID: 18949 RVA: 0x00229FB4 File Offset: 0x002281B4
	public void NGHJIJKGJMH()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("http://www.root-motion.com/finalikdox/html/page9.html", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.DBMJJPBOPEK().BOOGBOODHFK("Water", false));
		foreach (object obj in xmlDocument.SelectNodes("Idle Strafe Right"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["crft_from"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["Node transform is null in FBIK chain."].Value);
			string value = xmlNode.Attributes[" "].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A07 RID: 18951 RVA: 0x0022A0B8 File Offset: 0x002282B8
	public string KAPFCADBPMI(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace(".png", BNIHFBMEPAB);
			text = text.Replace('\b', (char)(KJAGFDIIKFC ? 15 : -1));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "type_", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x06004A08 RID: 18952 RVA: 0x0022A11C File Offset: 0x0022831C
	public void NMEFCGAJPGN()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("ShotgunReloadChamber", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.EDKGBBIIBBC().GIGGIHMAPLH("\n", true));
		foreach (object obj in xmlDocument.SelectNodes("<[^>]*>"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["t_top"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["Water"].Value);
			string value = xmlNode.Attributes["_Vibrance"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A09 RID: 18953 RVA: 0x0022A214 File Offset: 0x00228414
	public Color HGKEGJEKGJF(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(972f, 940f, 1482f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x06004A0A RID: 18954 RVA: 0x0022A258 File Offset: 0x00228458
	public void ODONNAANIEP()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Titul", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.IKGFHGKKCPG.CHFGNHKJNFG("Titul.xml", false));
		foreach (object obj in xmlDocument.SelectNodes("titul_data/tituls/titul"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["id"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["catid"].Value);
			string value = xmlNode.Attributes["name"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A0B RID: 18955 RVA: 0x0022A350 File Offset: 0x00228550
	public Color GAMCOCKKBME(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(1140f, 418f, 1918f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x06004A0C RID: 18956 RVA: 0x0022A394 File Offset: 0x00228594
	public Color LDMBLNONMOI(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(1653f, 863f, 1002f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x06004A0D RID: 18957 RVA: 0x0022A3D8 File Offset: 0x002285D8
	public void CKMJNHBNCEI()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.IKGFHGKKCPG.IDFHKHHNDEK("shop_wl", true));
		foreach (object obj in xmlDocument.SelectNodes("_LerpAmount"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes[": "].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["BowFire"].Value);
			string value = xmlNode.Attributes["repair.ogg"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A0E RID: 18958 RVA: 0x0022A4D0 File Offset: 0x002286D0
	public Color HDCDPPALBLL(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(1326f, 300f, 1750f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x06004A0F RID: 18959 RVA: 0x0022A514 File Offset: 0x00228714
	public string JKAENINHAIF(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("_ChromaticAberration_Amount", BNIHFBMEPAB);
			text = text.Replace((char)-93, (char)(KJAGFDIIKFC ? -41 : -62));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "WATER_REFLECTIVE", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x06004A10 RID: 18960 RVA: 0x0022A578 File Offset: 0x00228778
	public Color AFIJMFJPNJP(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(1594f, 1273f, 1434f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x06004A11 RID: 18961 RVA: 0x0022A5BC File Offset: 0x002287BC
	public string CNJKACEFHEI(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("error", BNIHFBMEPAB);
			text = text.Replace('\u0016', (char)(KJAGFDIIKFC ? -83 : 127));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "exp", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x06004A12 RID: 18962 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO DGKLGAPAHLK(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x06004A13 RID: 18963 RVA: 0x0022A620 File Offset: 0x00228820
	public Color KNJPPODPKNC(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(815f, 733f, 1558f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x06004A14 RID: 18964 RVA: 0x0022A664 File Offset: 0x00228864
	public string CABGPFFNFPH(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("F2", BNIHFBMEPAB);
			text = text.Replace((char)-122, KJAGFDIIKFC ? ':' : 'b');
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "3", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x06004A15 RID: 18965 RVA: 0x0022A6C8 File Offset: 0x002288C8
	public void NFAKJBGFDEE()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("crft_ingr", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.CLIMNFDGOEG().DDKLHGHBEIG("offsets", true));
		foreach (object obj in xmlDocument.SelectNodes("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_hinge.html"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["[ACTk] Obscured Cheating Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["{0}.{1}.{2}.{3}"].Value);
			string value = xmlNode.Attributes["ProneLocomotion"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A16 RID: 18966 RVA: 0x0022A7C0 File Offset: 0x002289C0
	public void LILKJKNMCDK()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("WeaponReadyFire", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.IKGFHGKKCPG.JPEDCGHDNPN("IdleButtonPress", true));
		foreach (object obj in xmlDocument.SelectNodes("\n<color='#{0}'>+{2} '{1}'</color> "))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["BackPackSearch"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["MotorbikeHeadstand"].Value);
			string value = xmlNode.Attributes["\n"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A17 RID: 18967 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO IGAMCCDOEDG(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x06004A18 RID: 18968 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO NFJEGMGNAOK(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x06004A19 RID: 18969 RVA: 0x0022A8B8 File Offset: 0x00228AB8
	public Color KOACFBDMKKB(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(0.7f, 0.7f, 0.7f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x06004A1A RID: 18970 RVA: 0x0022A8FC File Offset: 0x00228AFC
	public Color BNPKGGNMCML(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(106f, 1619f, 1355f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x06004A1B RID: 18971 RVA: 0x0022A940 File Offset: 0x00228B40
	public Color EAMOABDGALF(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(1650f, 532f, 1911f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x06004A1C RID: 18972 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO HPDBDCJGJOP(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x06004A1D RID: 18973 RVA: 0x0022A984 File Offset: 0x00228B84
	public void GDPJHAKMDHO()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("DealerShuffle", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.DBMJJPBOPEK().GHPNJJIMCKF("crft_to", false));
		foreach (object obj in xmlDocument.SelectNodes("https://www.youtube.com/watch?v=eP9-zycoHLk"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["There is already a virtual axis named "].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["Close Antares Console"].Value);
			string value = xmlNode.Attributes["Katana Ready Low"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A1E RID: 18974 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO AFLKABHIIOP(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x06004A1F RID: 18975 RVA: 0x0022AA7C File Offset: 0x00228C7C
	public void GHDFNBBJCLJ()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("ClimbUp", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.CLIMNFDGOEG().KKLNLPKAJDL("\n", false));
		foreach (object obj in xmlDocument.SelectNodes(""))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["crft_norec2"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["change channek close"].Value);
			string value = xmlNode.Attributes["Horizontal"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A20 RID: 18976 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO APFNHBLMIEK(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x06004A21 RID: 18977 RVA: 0x0022AB74 File Offset: 0x00228D74
	public string EBGHGKKMMGH(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("_EmissionColor", BNIHFBMEPAB);
			text = text.Replace((char)-59, (char)(KJAGFDIIKFC ? 74 : -75));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "WoodCut", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x06004A22 RID: 18978 RVA: 0x0022ABD8 File Offset: 0x00228DD8
	public void FCADNLJCCJA()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("X", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.LPHMKPDBMPP().DDKLHGHBEIG("_Threshhold", true));
		foreach (object obj in xmlDocument.SelectNodes("дня"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["<color='#808080'>[{2}]</color> <color='#c0c0c0'>{0}</color>: {1}"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["IdleSpew"].Value);
			string value = xmlNode.Attributes["_MotionAmount"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A23 RID: 18979 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO DLOOONOJLHD(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x06004A24 RID: 18980 RVA: 0x0022ACD0 File Offset: 0x00228ED0
	public Color JMODIGNMPJP(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(1387f, 1923f, 1814f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x06004A25 RID: 18981 RVA: 0x0022AD14 File Offset: 0x00228F14
	public void NIDGINCDCNK()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("7,13,9,8", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.APMJBBDBOJO().BOOGBOODHFK("", false));
		foreach (object obj in xmlDocument.SelectNodes("Level: "))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["ObscuredString:"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["IdleFight"].Value);
			string value = xmlNode.Attributes["_FullResolutionFiltering"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A26 RID: 18982 RVA: 0x0022AE0C File Offset: 0x0022900C
	public void HHBLMKHEMEA()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("WeaponReady", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.EDKGBBIIBBC().KKLNLPKAJDL("RenderType", true));
		foreach (object obj in xmlDocument.SelectNodes("ComeHere"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["hgtDst="].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["\n"].Value);
			string value = xmlNode.Attributes["4 samples"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A27 RID: 18983 RVA: 0x0022AF04 File Offset: 0x00229104
	public string CDFDGCAOMLM(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("GestureHandUp", BNIHFBMEPAB);
			text = text.Replace((char)-68, KJAGFDIIKFC ? 'Y' : '2');
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "#ffffff", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x06004A28 RID: 18984 RVA: 0x0022AF68 File Offset: 0x00229168
	public void OPMJJGHLAGF()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("KatanaReady", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.DBMJJPBOPEK().DOJJAFNAHKF("isRodOpen", true));
		foreach (object obj in xmlDocument.SelectNodes("SoundMgr is init part 2"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["Sun Light was not configured, and couldn't find appropriate Direction Light..."].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["base"].Value);
			string value = xmlNode.Attributes["https://groups.google.com/forum/#!forum/final-ik"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A29 RID: 18985 RVA: 0x0022B060 File Offset: 0x00229260
	public string FOJGKJPMIOC(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("Worker Hammer", BNIHFBMEPAB);
			text = text.Replace('6', KJAGFDIIKFC ? ']' : 'c');
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "Cloth_01.wav", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x06004A2A RID: 18986 RVA: 0x0022B0C4 File Offset: 0x002292C4
	public Color JMPLBJGLJFB(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(17f, 803f, 767f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x06004A2B RID: 18987 RVA: 0x0022B108 File Offset: 0x00229308
	public string MODOIHOIMBJ(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("IceHockeyGoalieSave1", BNIHFBMEPAB);
			text = text.Replace((char)-66, (char)(KJAGFDIIKFC ? 15 : -40));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "PrimaryCausticsProjector", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x06004A2C RID: 18988 RVA: 0x0022B16C File Offset: 0x0022936C
	public string IAIPLNNKKPK(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("loc", BNIHFBMEPAB);
			text = text.Replace(']', (char)(KJAGFDIIKFC ? -78 : -77));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "{0}", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x06004A2D RID: 18989 RVA: 0x0022B1D0 File Offset: 0x002293D0
	public void KGKADNNIILN()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("recept", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.EEOPOHEALPK().KFHFODNFCNL("LHandPunch", false));
		foreach (object obj in xmlDocument.SelectNodes("to channel = "))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["FOG_LINEAR"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["-H"].Value);
			string value = xmlNode.Attributes["isFishOnRod"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A2E RID: 18990 RVA: 0x0022851A File Offset: 0x0022671A
	public NHCAOFIKNFE.IOPMLIFDBKO BJBDOLFFCFK(int LPFKFNLHGBI)
	{
		if (!this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.JJLPDGEKOJL[LPFKFNLHGBI];
	}

	// Token: 0x06004A2F RID: 18991 RVA: 0x0022B2C8 File Offset: 0x002294C8
	public void OJKPACEFPHK()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("OfficeSitting1LegStraight", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.EEOPOHEALPK().GIGGIHMAPLH("Textures/Noise3", false));
		foreach (object obj in xmlDocument.SelectNodes("**************** RatingBoard readFromServer"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes[" "].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["<color=\"#0287C8\"><b>Anti-Cheat Toolkit Sandbox</b></color>"].Value);
			string value = xmlNode.Attributes["SwimDogPaddle"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A30 RID: 18992 RVA: 0x0022B3C0 File Offset: 0x002295C0
	public Color AIELPFAHFOC(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(1750f, 358f, 714f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x06004A31 RID: 18993 RVA: 0x0022B404 File Offset: 0x00229604
	public string CGPPLMOFBDB(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("", BNIHFBMEPAB);
			text = text.Replace((char)-37, (char)(KJAGFDIIKFC ? -75 : -87));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "-none-", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x06004A32 RID: 18994 RVA: 0x0022B468 File Offset: 0x00229668
	public string BOOJJNEMLIF(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("_Overlay", BNIHFBMEPAB);
			text = text.Replace((char)-102, (char)(KJAGFDIIKFC ? -43 : -102));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, "{z}", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x06004A33 RID: 18995 RVA: 0x0022B4CC File Offset: 0x002296CC
	public void NKPIKHPNDAN()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("1HandSwordShieldBash", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.DBMJJPBOPEK().KFHFODNFCNL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", false));
		foreach (object obj in xmlDocument.SelectNodes("sadokfull"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["1"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes[""].Value);
			string value = xmlNode.Attributes["IdleSpew"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A34 RID: 18996 RVA: 0x0022B5C4 File Offset: 0x002297C4
	public string GGGFKBAAADC(int LPFKFNLHGBI, string BNIHFBMEPAB = "", bool KJAGFDIIKFC = false, bool EFLPJHMLOOA = true)
	{
		string text = BNIHFBMEPAB;
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			text = this.JJLPDGEKOJL[LPFKFNLHGBI].HKHMIIEIFNG.Replace("info", BNIHFBMEPAB);
			text = text.Replace('y', (char)(KJAGFDIIKFC ? 105 : -73));
			if (!EFLPJHMLOOA)
			{
				text = Regex.Replace(text, " --- ? ---", string.Empty);
			}
		}
		return text;
	}

	// Token: 0x06004A35 RID: 18997 RVA: 0x0022B628 File Offset: 0x00229828
	public void CLALBPEIKMG()
	{
		this.JJLPDGEKOJL.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("{0}", typeof(TextAsset));
		xmlDocument.LoadXml(JNBICAJIJMM.EKEBHIJMEML().BGOJCAABLNC("ShotgunReloadMagazine", true));
		foreach (object obj in xmlDocument.SelectNodes("#80ff00"))
		{
			XmlNode xmlNode = (XmlNode)obj;
			int num = int.Parse(xmlNode.Attributes["mid"].Value);
			int pcpmjedbdko = int.Parse(xmlNode.Attributes["Apply 5"].Value);
			string value = xmlNode.Attributes["autherror"].Value;
			this.JJLPDGEKOJL.Add(num, new NHCAOFIKNFE.IOPMLIFDBKO(num, pcpmjedbdko, value));
		}
	}

	// Token: 0x06004A36 RID: 18998 RVA: 0x0022B720 File Offset: 0x00229920
	public Color PIGLJDBPGPJ(int LPFKFNLHGBI)
	{
		Color lbcgackjcjb = new Color(1593f, 417f, 424f);
		if (this.JJLPDGEKOJL.ContainsKey(LPFKFNLHGBI))
		{
			lbcgackjcjb = this.JJLPDGEKOJL[LPFKFNLHGBI].LBCGACKJCJB;
		}
		return lbcgackjcjb;
	}

	// Token: 0x04000B70 RID: 2928
	public static NHCAOFIKNFE IKGFHGKKCPG = new NHCAOFIKNFE();

	// Token: 0x04000B71 RID: 2929
	public Dictionary<int, NHCAOFIKNFE.IOPMLIFDBKO> JJLPDGEKOJL = new Dictionary<int, NHCAOFIKNFE.IOPMLIFDBKO>();

	// Token: 0x0200015D RID: 349
	public class IOPMLIFDBKO : ItemBase
	{
		// Token: 0x06004A37 RID: 18999 RVA: 0x0022B764 File Offset: 0x00229964
		public override CKNLPGEPGGF.IAPCJOBDCEH KHIDJHKNNFC()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "SoccerKeeperStrafeLeft" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A38 RID: 19000 RVA: 0x0022B78C File Offset: 0x0022998C
		public virtual string PDMPLOPPLBI()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH != null)
			{
				text = text.Replace("V", JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "FlyBackward", string.Empty);
		}

		// Token: 0x06004A39 RID: 19001 RVA: 0x0022B7D9 File Offset: 0x002299D9
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LNHLBIOOINI()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "SkateForward" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A3A RID: 19002 RVA: 0x0022B800 File Offset: 0x00229A00
		public virtual string MFPEPELOHBL()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH != null)
			{
				text = text.Replace("_FogOfWarSize", JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "_Screen", string.Empty);
		}

		// Token: 0x06004A3B RID: 19003 RVA: 0x0022B84D File Offset: 0x00229A4D
		public virtual CKNLPGEPGGF.IAPCJOBDCEH GCLHFHNKONE()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "<color='#001020'><i>" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A3C RID: 19004 RVA: 0x0022B873 File Offset: 0x00229A73
		public virtual CKNLPGEPGGF.IAPCJOBDCEH GODNMDFNNBL()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "name" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A3D RID: 19005 RVA: 0x0022B899 File Offset: 0x00229A99
		public virtual CKNLPGEPGGF.IAPCJOBDCEH JJMPHKEBPBC()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "jamp" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x0022B8C0 File Offset: 0x00229AC0
		public virtual string PGOGIIBBPLM()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH != null)
			{
				text = text.Replace("HYPERLINK", JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "Top", string.Empty);
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x0022B90D File Offset: 0x00229B0D
		public virtual CKNLPGEPGGF.IAPCJOBDCEH AJJOMBGHGBD()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x0022B934 File Offset: 0x00229B34
		public virtual string HGANAOPCKFC()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
			{
				text = text.Replace("UnityEngine.Vector2", JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "<color='#003000'>+{0} {1}</color>", string.Empty);
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x0022B981 File Offset: 0x00229B81
		public virtual CKNLPGEPGGF.IAPCJOBDCEH JKEFCDPEGPG()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "Mouse X" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x0022B9A7 File Offset: 0x00229BA7
		public virtual CKNLPGEPGGF.IAPCJOBDCEH MNHHOADANDG()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "OfficeSittingLegCross" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x0022B9CD File Offset: 0x00229BCD
		public override CKNLPGEPGGF.IAPCJOBDCEH JGBOJNELADG()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "Life bar: " + this.JFHBDBHIOII);
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x0022B9F4 File Offset: 0x00229BF4
		public virtual string NCNNJHIIAFM()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH != null)
			{
				text = text.Replace("UIChat_fontSize", JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, ": ", string.Empty);
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x0022BA44 File Offset: 0x00229C44
		public virtual string CFPMCOPINOH()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
			{
				text = text.Replace(" value=", JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "Apply 3", string.Empty);
		}

		// Token: 0x06004A46 RID: 19014 RVA: 0x0022BA91 File Offset: 0x00229C91
		public virtual CKNLPGEPGGF.IAPCJOBDCEH CJDBDJMFEGK()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "Wrist" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x0022BAB8 File Offset: 0x00229CB8
		public virtual string CEOAKEEKAMH()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH != null)
			{
				text = text.Replace(" ", JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, " ", string.Empty);
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x0022BB08 File Offset: 0x00229D08
		public override string CJMFHLIBCBM()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH != null)
			{
				text = text.Replace("ObscuredVector3 vs Vector3, ", JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "turn_base1", string.Empty);
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x0022BB55 File Offset: 0x00229D55
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FMELNFODNLL()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "_CenterRadius" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x0022BB7B File Offset: 0x00229D7B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH OFPLJEDIFMK()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "https://groups.google.com/forum/#!forum/final-ik" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x0022BBA1 File Offset: 0x00229DA1
		public virtual CKNLPGEPGGF.IAPCJOBDCEH ELFEJJNOKPC()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, ")" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A4C RID: 19020 RVA: 0x0022BBC8 File Offset: 0x00229DC8
		public virtual string DIACBNHNDCJ()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH != null)
			{
				text = text.Replace("_BlurRadius4", JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "_MaxCoC", string.Empty);
		}

		// Token: 0x06004A4D RID: 19021 RVA: 0x0022BC18 File Offset: 0x00229E18
		public virtual string NIDKKALEJIM()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH != null)
			{
				text = text.Replace("SoccerKeeperStrafeLeft", JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "demoLong", string.Empty);
		}

		// Token: 0x06004A4E RID: 19022 RVA: 0x0022BC68 File Offset: 0x00229E68
		public override string EDBCGCIHHKA()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH != null)
			{
				text = text.Replace("_WaterLevel", JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "money", string.Empty);
		}

		// Token: 0x06004A4F RID: 19023 RVA: 0x0022BCB8 File Offset: 0x00229EB8
		public virtual string PNAEJEIKIOO()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH != null)
			{
				text = text.Replace("???", JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "_BlurVector", string.Empty);
		}

		// Token: 0x06004A50 RID: 19024 RVA: 0x0022BD08 File Offset: 0x00229F08
		public virtual string PBAJNDNHIFI()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH != null)
			{
				text = text.Replace("OfficeSittingReadingPageFlip", JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "human_move_2.wav", string.Empty);
		}

		// Token: 0x06004A51 RID: 19025 RVA: 0x0022BD58 File Offset: 0x00229F58
		public virtual string FGNNJFJLENH()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH != null)
			{
				text = text.Replace("IKSolverLookAt spine setup is invalid. Can't initiate solver.", JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "_TileTexDebug", string.Empty);
		}

		// Token: 0x06004A52 RID: 19026 RVA: 0x0022BDA8 File Offset: 0x00229FA8
		public virtual string NMBKBGNBAEM()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH != null)
			{
				text = text.Replace("crft_ingr", JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "", string.Empty);
		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x0022BDF5 File Offset: 0x00229FF5
		public virtual CKNLPGEPGGF.IAPCJOBDCEH MDFFEHKPBHO()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, " on layer " + this.JFHBDBHIOII);
		}

		// Token: 0x06004A54 RID: 19028 RVA: 0x0022BE1B File Offset: 0x0022A01B
		public override CKNLPGEPGGF.IAPCJOBDCEH PPJOPGPEFGI()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "-" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A55 RID: 19029 RVA: 0x0022BE44 File Offset: 0x0022A044
		public override string IGJFJGKAFIE()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH != null)
			{
				text = text.Replace("</color>\n", JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "<color=\"", string.Empty);
		}

		// Token: 0x06004A56 RID: 19030 RVA: 0x0022BBA1 File Offset: 0x00229DA1
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LFBLJHDFPCO()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, ")" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A57 RID: 19031 RVA: 0x0022BE91 File Offset: 0x0022A091
		public virtual CKNLPGEPGGF.IAPCJOBDCEH AMBFDBDHIEJ()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "reals" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A58 RID: 19032 RVA: 0x0022BEB8 File Offset: 0x0022A0B8
		public override string ToString()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
			{
				text = text.Replace("[name]", JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "<.*?>", string.Empty);
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x0022BF05 File Offset: 0x0022A105
		public override CKNLPGEPGGF.IAPCJOBDCEH HFAGADCJACL()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "IdleFeedThrow" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x0022BF2B File Offset: 0x0022A12B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH JFFFDKGGPOL()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "crft_krit" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x0022BF54 File Offset: 0x0022A154
		public virtual string DHCBHNAAJKI()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH != null)
			{
				text = text.Replace("♼ ", JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "Point", string.Empty);
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x0022BFA1 File Offset: 0x0022A1A1
		public override CKNLPGEPGGF.IAPCJOBDCEH HHOBCJNGCEL()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "FlyBackward" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x0022BFC7 File Offset: 0x0022A1C7
		public virtual CKNLPGEPGGF.IAPCJOBDCEH PLEHKPMDEFJ()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "Квест" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x0022BFED File Offset: 0x0022A1ED
		public override CKNLPGEPGGF.IAPCJOBDCEH APLAAOCGECL()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "long: " + this.JFHBDBHIOII);
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x0022C014 File Offset: 0x0022A214
		public virtual string DGOBKBBGGKN()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH != null)
			{
				text = text.Replace("gi_uinf_1i", JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "CrouchStrafeRight", string.Empty);
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x0022C064 File Offset: 0x0022A264
		public virtual string MIHCFECAIAD()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH != null)
			{
				text = text.Replace("</color>", JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "CratePull", string.Empty);
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x0022C0B1 File Offset: 0x0022A2B1
		public virtual CKNLPGEPGGF.IAPCJOBDCEH OAJANJBLPNC()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "?" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x0022C0D7 File Offset: 0x0022A2D7
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LINIEFNDEEF()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "1HandSwordShieldBash" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x0022C100 File Offset: 0x0022A300
		public virtual string GMLGLOOIEAA()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH != null)
			{
				text = text.Replace("offsets", JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "auk_pbuykey", string.Empty);
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x0022C14D File Offset: 0x0022A34D
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FEBAFNCKCGA()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "!" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x0022C173 File Offset: 0x0022A373
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DEOMJEEMGMI()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "часа" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x0022C19C File Offset: 0x0022A39C
		public virtual string AHFDMABJGOL()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
			{
				text = text.Replace("ElvisLegsLoop", JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "invn_rec17", string.Empty);
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x0022C1EC File Offset: 0x0022A3EC
		public virtual string JDPKKGOOKDF()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH != null)
			{
				text = text.Replace("neck", JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "OfficeSitting1LegStraight", string.Empty);
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x0022C23C File Offset: 0x0022A43C
		public override string IBLEHFEBIMG()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH != null)
			{
				text = text.Replace("WeaponStrafeRunLeft", JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "gi_um_2", string.Empty);
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x0022C28C File Offset: 0x0022A48C
		public virtual string IHKJGKNNIHA()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH != null)
			{
				text = text.Replace("repair.ogg", JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "anfish", string.Empty);
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x0022C2D9 File Offset: 0x0022A4D9
		public override CKNLPGEPGGF.IAPCJOBDCEH PBHPIGPDCJA()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "Wizard Neo Block" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x0022C300 File Offset: 0x0022A500
		public override string BACHFNMDOLO()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH != null)
			{
				text = text.Replace("ProneIdle", JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "adjust", string.Empty);
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x0022C34D File Offset: 0x0022A54D
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DDIDFFABBIO()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "_Lift" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x0022C374 File Offset: 0x0022A574
		public virtual string MDAPFDLEEGN()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH != null)
			{
				text = text.Replace("_ExposureAdjustment", JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "  my=", string.Empty);
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x0022C3C1 File Offset: 0x0022A5C1
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FGKHJANCMEM()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "FBBIK is null. Will not update the InteractionSystem" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x0022C3E8 File Offset: 0x0022A5E8
		public virtual string AOJIJIPBKPB()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH != null)
			{
				text = text.Replace("ok", JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "effect", string.Empty);
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x0022C438 File Offset: 0x0022A638
		public virtual string FJGIAILHMIF()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH != null)
			{
				text = text.Replace("<.*?>", JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "_FogDistance", string.Empty);
		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x0022C488 File Offset: 0x0022A688
		public virtual string DFHAGGBIEIH()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH != null)
			{
				text = text.Replace("_DistanceParams", JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "GiantGrabThrow2", string.Empty);
		}

		// Token: 0x06004A72 RID: 19058 RVA: 0x0022C4D8 File Offset: 0x0022A6D8
		public override string GJCCJEINDDC()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH != null)
			{
				text = text.Replace("MotorbikeLookBack", JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "★{0}", string.Empty);
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x0022C525 File Offset: 0x0022A725
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HOFOHFJDBLN()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "IdleStrafeLeft" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x0022C54B File Offset: 0x0022A74B
		public override CKNLPGEPGGF.IAPCJOBDCEH PBEMPJOBKKI()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "linebreak.ogg" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x0022C574 File Offset: 0x0022A774
		public override string DIJJDHMMGCA()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH != null)
			{
				text = text.Replace("<color='#003000'>+{0} {1}</color>", JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "_WrinkleInfluences2", string.Empty);
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x0022C5C4 File Offset: 0x0022A7C4
		public virtual string NKOIIHFDNHP()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH != null)
			{
				text = text.Replace("error.wav", JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "Lives count: ", string.Empty);
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x0022C614 File Offset: 0x0022A814
		public virtual string DIPEOLHEMHK()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH != null)
			{
				text = text.Replace("Giant3HitCombo", JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "No saved ObscuredPrefs!", string.Empty);
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x0022C661 File Offset: 0x0022A861
		public override CKNLPGEPGGF.IAPCJOBDCEH EJJAGEFMHCO()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "titul_" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x0022C688 File Offset: 0x0022A888
		public virtual string GIOCLFJADKN()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
			{
				text = text.Replace("?", JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "ShotgunFire", string.Empty);
		}

		// Token: 0x06004A7A RID: 19066 RVA: 0x0022C6D8 File Offset: 0x0022A8D8
		public virtual string KCBJCGOINMK()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH != null)
			{
				text = text.Replace("UpHillWalk", JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "Missing shader in ", string.Empty);
		}

		// Token: 0x06004A7B RID: 19067 RVA: 0x0022C725 File Offset: 0x0022A925
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HKHAONBKECM()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "id" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A7C RID: 19068 RVA: 0x0022C74B File Offset: 0x0022A94B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH IGBGJOLJFKJ()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "Keeper Strafe Right" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A7D RID: 19069 RVA: 0x0022C774 File Offset: 0x0022A974
		public IOPMLIFDBKO(int LDLCFLIPOFH, int PCPMJEDBDKO, string NNEGJECCNCN)
		{
			this.JFHBDBHIOII = LDLCFLIPOFH;
			this.GCLKLEIMABA = PCPMJEDBDKO;
			this.HKHMIIEIFNG = NNEGJECCNCN;
			this.HKHMIIEIFNG = this.HKHMIIEIFNG.Replace("{", "<");
			this.HKHMIIEIFNG = this.HKHMIIEIFNG.Replace("}", ">");
		}

		// Token: 0x06004A7E RID: 19070 RVA: 0x0022C7EC File Offset: 0x0022A9EC
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FNIIBBGCFMB()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "ProcessOnlyMaterial" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x0022C814 File Offset: 0x0022AA14
		public virtual string JHGPBNCOHHH()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH != null)
			{
				text = text.Replace("wpn_add/base", JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "name", string.Empty);
		}

		// Token: 0x06004A80 RID: 19072 RVA: 0x0022C864 File Offset: 0x0022AA64
		public virtual string ADOAJOFIPAM()
		{
			string text = this.HKHMIIEIFNG;
			if (JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH != null)
			{
				text = text.Replace("</color>\n", JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB);
			}
			return Regex.Replace(text, "_FogOfWarSize", string.Empty);
		}

		// Token: 0x06004A81 RID: 19073 RVA: 0x0022C8B1 File Offset: 0x0022AAB1
		public virtual CKNLPGEPGGF.IAPCJOBDCEH GPIDMMEHMKF()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "Criticals" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A82 RID: 19074 RVA: 0x0022C8D7 File Offset: 0x0022AAD7
		public virtual CKNLPGEPGGF.IAPCJOBDCEH ENCCFPGCLHA()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "<color='#80ffff'>" + this.JFHBDBHIOII);
		}

		// Token: 0x06004A83 RID: 19075 RVA: 0x0022C8FD File Offset: 0x0022AAFD
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LOHCIIFHNCE()
		{
			return new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.titulIcon, "UnityEngine.Color" + this.JFHBDBHIOII);
		}

		// Token: 0x04000B72 RID: 2930
		public int GCLKLEIMABA;

		// Token: 0x04000B73 RID: 2931
		public int JFHBDBHIOII;

		// Token: 0x04000B74 RID: 2932
		public string HKHMIIEIFNG;

		// Token: 0x04000B75 RID: 2933
		public Color LBCGACKJCJB = new Color(0.5f, 0.9f, 1f);
	}
}
