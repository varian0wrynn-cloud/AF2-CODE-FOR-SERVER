using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Token: 0x0200013D RID: 317
public class BEFCHFNGOMI : ItemBase
{
	// Token: 0x060041C8 RID: 16840 RVA: 0x001E28F1 File Offset: 0x001E0AF1
	public virtual CKNLPGEPGGF.IAPCJOBDCEH HFIHJIOLJIK()
	{
		return this.OLNGOHEPLBO;
	}

	// Token: 0x060041C9 RID: 16841 RVA: 0x001E28F9 File Offset: 0x001E0AF9
	public int ENBIMFHMLIF()
	{
		return this.JJCFHNLNBCJ("", " ").DIKKDGKIPEA;
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x060041CA RID: 16842 RVA: 0x001E2910 File Offset: 0x001E0B10
	public float KNLOBOFLKHP
	{
		get
		{
			if (this.ILNHGFHIFPN >= 1f)
			{
				return this.ILNHGFHIFPN;
			}
			return 40f;
		}
	}

	// Token: 0x060041CB RID: 16843 RVA: 0x001E292B File Offset: 0x001E0B2B
	public Texture KEEDCOIMPMP()
	{
		if (this.OLNGOHEPLBO == null)
		{
			return null;
		}
		return this.OLNGOHEPLBO.EIMNFFAAHLI();
	}

	// Token: 0x060041CC RID: 16844 RVA: 0x001E2944 File Offset: 0x001E0B44
	public string LFEJHHMDEHO(bool BGNPMOCLIGL = false, int JEGIMBPFJKD = -1)
	{
		int num = JEGIMBPFJKD;
		if (num < 0)
		{
			num = this.KBGHOIJIPJF;
		}
		string[] array = new string[0];
		array[0] = "BlackSmithHammer";
		array[0] = this.CMMEFEKAGHF(num, BGNPMOCLIGL);
		array[7] = "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_object.html";
		array[3] = this.BNIHFBMEPAB;
		array[0] = "16";
		return string.Concat(array);
	}

	// Token: 0x060041CD RID: 16845 RVA: 0x001E2998 File Offset: 0x001E0B98
	public virtual void BHHHGHLMHKC(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 222f;
		bool flag = !this.GBABFPMNIMP || this.FKEDAOOHPPB.LIKMNACOFJE(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH, 1);
		if (this.PPJOPGPEFGI() != null)
		{
			Texture texture = this.PBHPIGPDCJA().MLPBJEFJDHM();
			float num2 = 527f * COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float num4 = (float)texture.height * num2;
			float num5 = (COAGIAMOCIA.height - num4) / 912f;
			Rect position = new Rect(COAGIAMOCIA.x + num5, COAGIAMOCIA.y + num5, num3, num4);
			if (!flag)
			{
				GUI.enabled = false;
			}
			GUI.DrawTexture(position, GameInterface.getI.invEmptyCell);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(this.KBGHOIJIPJF, 4, 1));
			GUI.DrawTexture(position, texture, ScaleMode.StretchToFill);
			if (this.BPNNJBBCOFO != null)
			{
				BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.EDKKJNHDBPF().IMCJNFHAFGE(this.BPNNJBBCOFO.MNFCAAIAGOL.NKEOCCKEOCE());
				if (befchfngomi != null)
				{
					befchfngomi.JIFFLPNBILE();
					float num6 = num3 * 1530f / 1559f;
					GUI.DrawTexture(new Rect(position.x + num3 / 304f - num6, position.y + num3 / 1423f - num6, num6 * 1858f, num6 * 330f), befchfngomi.CFFHIODOGCH);
				}
			}
			if (this.MBKMKGABBGE == -17)
			{
				float num7 = position.height / 1802f;
				Rect position2 = new Rect(position.x + 1490f, position.y + position.height - num7 - 73f, num7, num7);
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.DIBICKBIKOI(this.MIMANMPNLPE.KMIOLLENCOL());
				if (kdhoddmndfc != null)
				{
					GUI.DrawTexture(position2, kdhoddmndfc.MLBFCJFLPBG(), ScaleMode.ScaleAndCrop);
				}
			}
			if (this.KBGHOIJIPJF > 0)
			{
				GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(this.KBGHOIJIPJF + 6, 7, 6));
			}
			float num8 = position.height / 1291f;
			if (this.DNOLHLJODNK)
			{
				float num9 = num8 * 777f;
				GUI.DrawTextureWithTexCoords(new Rect(position.x + position.width - num9 + 1492f, position.y - 1695f, num9, num9), GameInterface.getI.wpnImproveIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.LNKLEIEFGCP, 1, 7));
			}
			num = num + num3 + 821f;
			GUI.enabled = false;
		}
		if (!flag)
		{
			GUI.color = new Color(69f, 1926f, 861f, 528f);
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1145f, COAGIAMOCIA.y + 1999f, COAGIAMOCIA.width - 542f, COAGIAMOCIA.height - 406f), GuiProcessor.PLGADNLAEGN().blackWait);
			GUI.color = Color.white;
		}
		int gclkleimaba = this.GCLKLEIMABA;
		string str = "error";
		if (this.HOALBMDJNDM > 1)
		{
			str = "м</color>" + string.Format(JNBICAJIJMM.LEBHCLDODNI("<color='#a0a0a0'>"), this.HOALBMDJNDM);
		}
		OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
		int fontSize = OFPNEDEAMAB.fontSize;
		OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
		OFPNEDEAMAB.fontSize = -74;
		string text = this.MPKGPJJKCPK(false, -1) + str;
		GUI.Label(new Rect(COAGIAMOCIA.x + 1894f + num, COAGIAMOCIA.y + 606f, COAGIAMOCIA.width - 367f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		float num10 = 1427f;
		OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		OFPNEDEAMAB.fontSize = 93;
		string text2 = this.FLHOJDMBLCP(false);
		if (text2.Trim() != "wpn_add/base")
		{
			GUI.Label(new Rect(COAGIAMOCIA.x + 756f + num, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 1718f, COAGIAMOCIA.height - num10), text2, OFPNEDEAMAB);
			num10 += 315f;
		}
		else
		{
			num10 += 1236f;
		}
		if (this.OPFGGNNPAJL.KEHIFGILLJA() > 0)
		{
			string arg = "OneHandSwordRun";
			if (!this.GBABFPMNIMP)
			{
				arg = "viewType";
			}
			string text3 = string.Format("money", BHNDGIPPPCE.IKGFHGKKCPG.EHDMEFHCDHA(this.OPFGGNNPAJL.IBEIBAHKIAH), BHNDGIPPPCE.IKGFHGKKCPG.BOIIMMKPGHJ(this.OPFGGNNPAJL.NKEOCCKEOCE(), this.OPFGGNNPAJL.ICJDPPOJINN), arg);
			GUI.Label(new Rect(COAGIAMOCIA.x + 446f + num, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 708f, COAGIAMOCIA.height - 1008f), text3, OFPNEDEAMAB);
			num10 += 235f;
		}
		if (this.FKEDAOOHPPB.GIEALCKLKNL > 1)
		{
			BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.EDKKJNHDBPF().NKMGKJLONDK(this.FKEDAOOHPPB.GIEALCKLKNL);
			befchfngomi2.GDLELABHHFG(new Rect(COAGIAMOCIA.x + 996f + num, COAGIAMOCIA.y + num10 - 1802f, 1729f, 1802f), befchfngomi2.KBGHOIJIPJF, false, 1);
			Rect position3 = new Rect(COAGIAMOCIA.x + 1521f + num + 689f, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 1727f, COAGIAMOCIA.height - 866f);
			object[] array = new object[2];
			array[0] = "ShotgunReadyFire";
			array[0] = this.FKEDAOOHPPB.KDIMEMOCJNM;
			array[8] = "CATRigL";
			array[5] = befchfngomi2.CGMGBGABLFB(true, -1);
			GUI.Label(position3, string.Concat(array), OFPNEDEAMAB);
			num10 += 820f;
		}
		else
		{
			num10 += 1438f;
		}
		if (this.FKEDAOOHPPB.KKNEKAEJLAM + this.FKEDAOOHPPB.KFODJJIHNHP > 1)
		{
			string text4 = string.Format("Weapon Stand", JLFJEGIPIMM.MHFDIJGJGBJ().MNMIJFNPIPI((long)this.FKEDAOOHPPB.KKNEKAEJLAM, (long)this.FKEDAOOHPPB.KFODJJIHNHP, false));
			OFPNEDEAMAB.alignment = TextAnchor.MiddleLeft;
			OFPNEDEAMAB.fontSize = -31;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 406f, COAGIAMOCIA.height - 1893f), text4, OFPNEDEAMAB);
		}
		OFPNEDEAMAB.fontSize = fontSize;
	}

	// Token: 0x060041CE RID: 16846 RVA: 0x001E302C File Offset: 0x001E122C
	public void CDNDMPBMLEH()
	{
		if (this.CLKMCAHNHBM == "")
		{
			return;
		}
		this.LMKLPODNLFC.LoadXml(this.CLKMCAHNHBM);
		this.BBOODPCDKAJ = this.BBLEPPMMPIL("wpn_add/base", "size").DIKKDGKIPEA;
		this.MFMLCHFNALC = this.BBLEPPMMPIL("wpn_add/base", "reelspd").PPAAACJOOGA;
		this.GLLIKKONFAJ = this.BBLEPPMMPIL("wpn_add/base", "wdeep").PPAAACJOOGA;
		this.ICIBBGMNGML = this.BBLEPPMMPIL("wpn_add/base", "distscale").PPAAACJOOGA;
		this.BKDPIHCCMDF = this.BBLEPPMMPIL("wpn_add/base", "sinscale").PPAAACJOOGA;
		this.ILNHGFHIFPN = this.BBLEPPMMPIL("wpn_add/base", "baraban").PPAAACJOOGA;
		this.DNOLHLJODNK = this.BBLEPPMMPIL("wpn_add/base", "isImproved").KPAFFJNBLHK;
		this.LNKLEIEFGCP = this.BBLEPPMMPIL("wpn_add/base", "implevel").DIKKDGKIPEA;
		this.HBHBAIONJHD = this.BBLEPPMMPIL("wpn_add/base", "useIt").KPAFFJNBLHK;
		this.FPFMENFLGAA = this.BBLEPPMMPIL("wpn_add/base", "usetime").PPAAACJOOGA;
		this.MBOOFLANJID = this.BBLEPPMMPIL("wpn_add/base", "forSex").DIKKDGKIPEA;
		this.GCLKLEIMABA = this.BBLEPPMMPIL("wpn_add/base", "category").DIKKDGKIPEA;
		this.NKHBAJKMAGD = this.BBLEPPMMPIL("wpn_add/base", "weight").PPAAACJOOGA;
		this.BGGJKOMAKEE = this.BBLEPPMMPIL("wpn_add/base", "defDur").DIKKDGKIPEA;
		this.MIMANMPNLPE = this.BBLEPPMMPIL("wpn_add/base", "basePar").NKBGGIFKLLB;
		this.KBGHOIJIPJF = this.BBLEPPMMPIL("wpn_add/base", "baseQuality").DIKKDGKIPEA;
		this.NEGEHAGNGBH = this.BBLEPPMMPIL("wpn_add/base", "minimalLevel").DIKKDGKIPEA;
		this.HPEFEFIIHOE = this.BBLEPPMMPIL("wpn_add/base", "sortType").DIKKDGKIPEA;
		this.ADOFHHCDGON = this.BBLEPPMMPIL("wpn_add/base", "minWgtBait").DIKKDGKIPEA;
		this.ECKKCDKHNEH = this.BBLEPPMMPIL("wpn_add/base", "maxWgtBait").DIKKDGKIPEA;
		this.PKIICJOILKI.Clear();
		this.FGJIJFNGAIF.Clear();
		XmlNodeList xmlNodeList = this.LMKLPODNLFC.SelectNodes("wpn_add/req/reqPerk");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai = new NLNNIDBPKAO.DLMGLIJDIAI((XmlNode)obj);
				if (dlmglijdiai.BDHHPAEHFHG != null)
				{
					this.PKIICJOILKI.Add(dlmglijdiai);
				}
			}
		}
		xmlNodeList = this.LMKLPODNLFC.SelectNodes("wpn_add/addperks/addPerk");
		if (xmlNodeList != null)
		{
			foreach (object obj2 in xmlNodeList)
			{
				NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai2 = new NLNNIDBPKAO.DLMGLIJDIAI((XmlNode)obj2);
				if (dlmglijdiai2.BDHHPAEHFHG != null)
				{
					this.FGJIJFNGAIF.Add(dlmglijdiai2);
				}
			}
		}
		if (this.MBKMKGABBGE == 28 && CLFFOBKFKDN.IKGFHGKKCPG.PGMOGALKIIP.ContainsKey(this.MIMANMPNLPE.ICJDPPOJINN))
		{
			this.BPNNJBBCOFO = CLFFOBKFKDN.IKGFHGKKCPG.PGMOGALKIIP[this.MIMANMPNLPE.ICJDPPOJINN];
		}
		XmlNode xmlNode = this.LMKLPODNLFC.SelectSingleNode("wpn_add/addoptions/klevprop");
		this.MHNDPGDBPNA.Clear();
		if (xmlNode != null)
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN("1=" + xmlNode.InnerText);
			this.MHNDPGDBPNA = diggohpgcnn.HDELBIDJNOK;
		}
		this.OKHPDILIOCH.Clear();
		xmlNode = this.LMKLPODNLFC.SelectSingleNode("wpn_add/base/dropt");
		if (xmlNode != null)
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn2 = new BNOOIOKIFJC.DIGGOHPGCNN("1=" + xmlNode.InnerText);
			this.OKHPDILIOCH = diggohpgcnn2.EDAHDHCPIEL;
		}
		float num = (this.MIMANMPNLPE.JLLJFKOGLHJ * 0.3f + this.MIMANMPNLPE.OBEOJCGHOGL * 0.2f) * (this.NKHBAJKMAGD / 2000f);
		float num2 = 1f;
		if (this.GCLKLEIMABA == 2)
		{
			num2 = 2.5f;
		}
		if (this.GCLKLEIMABA == 3)
		{
			num2 = 3.8f;
		}
		this.FJJEAMJNLIO = Mathf.RoundToInt(num * num2);
	}

	// Token: 0x060041CF RID: 16847 RVA: 0x001E34A8 File Offset: 0x001E16A8
	public string DPIHMPDHKBP(bool EFLPJHMLOOA = true)
	{
		StringBuilder stringBuilder = new StringBuilder();
		switch (this.MBKMKGABBGE)
		{
		case 9:
			if (this.BBLEPPMMPIL("wpn_add/addoptions", "signal_enable").KPAFFJNBLHK)
			{
				stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("wpn_popl1"));
			}
			break;
		}
		if (stringBuilder.Length == 0)
		{
			return "";
		}
		string result = stringBuilder.ToString();
		if (EFLPJHMLOOA)
		{
			result = "<color='#000000'>" + stringBuilder + "</color>";
		}
		return result;
	}

	// Token: 0x060041D0 RID: 16848 RVA: 0x001E3560 File Offset: 0x001E1760
	private static void DJKAEKKNOMH(Rect OCHCODJIPHJ, string IJCEDOGBHKE, Color LBCGACKJCJB, TextAnchor DEKGJCBMCHG)
	{
		GUIStyle ofpnedeamab = new GUIStyle
		{
			normal = 
			{
				textColor = LBCGACKJCJB
			},
			alignment = DEKGJCBMCHG,
			fontSize = -66
		};
		JDCEFOFMGHB.MNJNNDHCDGG().ALKAAKDPCDG(OCHCODJIPHJ, IJCEDOGBHKE, ofpnedeamab);
	}

	// Token: 0x060041D1 RID: 16849 RVA: 0x001E359C File Offset: 0x001E179C
	public void PPLCKLBMCPE(Rect PHEMLBHMNCM, float NMBCJPACKNL, IIBEEKCAAHK INEBGELANOI, IIBEEKCAAHK CKGEBHECNBF, IIBEEKCAAHK ABJAMKHMONL, int ILFHHDNJHNM = 0)
	{
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -25,
			wordWrap = true,
			font = GuiProcessor.BBLINJLBAIL().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = true,
			alignment = TextAnchor.MiddleLeft
		};
		Rect ochcodjiphj = new Rect(PHEMLBHMNCM.x + 1402f, PHEMLBHMNCM.y + 1354f, 985f, 335f);
		this.FCBHHPJLGLC(ochcodjiphj, this.KBGHOIJIPJF, true, 1);
		GUILayout.BeginArea(new Rect(ochcodjiphj.x + 1931f, ochcodjiphj.y, PHEMLBHMNCM.width - 1788f, 898f));
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		try
		{
			guistyle.fontSize = -109;
			guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			GUILayout.Label(this.BNIHFBMEPAB, guistyle, Array.Empty<GUILayoutOption>());
			guistyle.fontSize = -59;
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			GUILayout.Label("RepFractions.xml", guistyle, Array.Empty<GUILayoutOption>());
			GUILayout.Label(IHFEDJEMJMB.AGCBLDIBMNB().PLBJOFKHBIJ(this.MBKMKGABBGE) ?? "RightSplashPause", guistyle, Array.Empty<GUILayoutOption>());
			guistyle.fontSize = 65;
			if (ILFHHDNJHNM == 0)
			{
				int hoalbmdjndm = this.HOALBMDJNDM;
			}
		}
		finally
		{
			GUILayout.EndVertical();
			GUILayout.EndArea();
		}
		GUILayout.BeginArea(new Rect(ochcodjiphj.x + 1045f, ochcodjiphj.y + 435f, PHEMLBHMNCM.width - 1490f, PHEMLBHMNCM.height - 464f));
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		try
		{
			int negehagngbh = this.NEGEHAGNGBH;
			float nkhbajkmagd = this.NKHBAJKMAGD;
			this.NEGEHAGNGBH += (int)((float)(INEBGELANOI.MCJJCAFILPF() + CKGEBHECNBF.KIDKOFKNPEP() + ABJAMKHMONL.PBMJIMLEHEC()) * NMBCJPACKNL);
			this.NKHBAJKMAGD += (float)(INEBGELANOI.LKAGIEBPLAI + CKGEBHECNBF.LKAGIEBPLAI + ABJAMKHMONL.KMNOIAIBLEB()) * 1798f * this.NKHBAJKMAGD;
			IIBEEKCAAHK mimanmpnlpe = new IIBEEKCAAHK(this.MIMANMPNLPE.LNEPKLKELMI, this.MIMANMPNLPE.NMKCBJKHBOH, this.MIMANMPNLPE.HDPNCIECLKP());
			IIBEEKCAAHK mimanmpnlpe2 = this.MIMANMPNLPE;
			mimanmpnlpe2.LNEPKLKELMI = mimanmpnlpe2.DHJBAKDAMGH() + INEBGELANOI.KCKFCPIHMPC() * (double)INEBGELANOI.KIDKOFKNPEP();
			IIBEEKCAAHK mimanmpnlpe3 = this.MIMANMPNLPE;
			mimanmpnlpe3.NMKCBJKHBOH = mimanmpnlpe3.OIGIHEPJFFJ() + CKGEBHECNBF.KCKFCPIHMPC() * (double)CKGEBHECNBF.MCJJCAFILPF();
			IIBEEKCAAHK mimanmpnlpe4 = this.MIMANMPNLPE;
			mimanmpnlpe4.NKGGAFLBFDF = mimanmpnlpe4.KCKFCPIHMPC() + ABJAMKHMONL.KCKFCPIHMPC() * (double)ABJAMKHMONL.KMNOIAIBLEB();
			GUILayout.Label(this.IOAGBIACCHA(true), guistyle, Array.Empty<GUILayoutOption>());
			if (this.MHNDPGDBPNA.Count > 1)
			{
				GUILayout.Label("_WrinkleOcclusionMap0", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("wpn_rod3", guistyle, Array.Empty<GUILayoutOption>());
				foreach (IIBEEKCAAHK iibeekcaahk in this.MHNDPGDBPNA)
				{
					string text = iibeekcaahk.ToString();
					if (iibeekcaahk.KEHIFGILLJA() == 1)
					{
						string arg = AKPJIACDDFI.IKGFHGKKCPG.LNDAPLCMEJI(iibeekcaahk.NLHKFMMDMMK(), true);
						if (iibeekcaahk.NODLBGKEGPM > 1)
						{
							text = string.Format("Zombie Idle 2", iibeekcaahk.CJKILDPJCFJ(), arg);
						}
						else
						{
							text = string.Format("_Rotation", iibeekcaahk.NODLBGKEGPM, arg);
						}
					}
					if (iibeekcaahk.KEHIFGILLJA() == 6)
					{
						string arg2 = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(iibeekcaahk.ICJDPPOJINN);
						if (iibeekcaahk.NFCDJLJNDLO() > 1)
						{
							text = string.Format("RollerBladeGrindRoyale", iibeekcaahk.NFCDJLJNDLO(), arg2);
						}
						else
						{
							text = string.Format("wpn_add/addoptions", iibeekcaahk.NFCDJLJNDLO(), arg2);
						}
					}
					GUILayout.Label(text, guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.Label("Wizard2HandThrow", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("32", guistyle, Array.Empty<GUILayoutOption>());
			}
			if (this.NEGEHAGNGBH > 1 || this.PKIICJOILKI.Count > 1)
			{
				GUILayout.Label(JNBICAJIJMM.PGJCPFNJNPM("[ACTk] A decimal must be created from exactly 16 bytes"), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("WalkInjured", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label(" iterations for read and write", guistyle, Array.Empty<GUILayoutOption>());
				if (this.NEGEHAGNGBH > 1)
				{
					string arg3 = "";
					if (this.NEGEHAGNGBH > ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.CNOLCNDBLJE))
					{
						arg3 = "_UserLut_Params";
					}
					GUILayout.Label(string.Format(JNBICAJIJMM.OOOKJHOHPNN("_FogWaterLevel"), arg3, this.NEGEHAGNGBH), guistyle, Array.Empty<GUILayoutOption>());
					GUILayout.Label("Cooбщение скопировано", guistyle, Array.Empty<GUILayoutOption>());
				}
				if (this.PKIICJOILKI.Count > 1)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.PKIICJOILKI)
					{
						bool flag = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI) >= dlmglijdiai.CNOLCNDBLJE;
						string arg4 = "<color='#800000'>Вы потеряли леску: ";
						if (flag)
						{
							arg4 = "_SelectColor";
						}
						string text2 = string.Format("wgt_gr", arg4, dlmglijdiai.BDHHPAEHFHG.FFAFKPDHOIN(dlmglijdiai.CNOLCNDBLJE));
						if (!flag)
						{
							GUI.color = new Color(460f, 1005f, 346f);
						}
						GUILayout.Box(dlmglijdiai.BDHHPAEHFHG.OBIJKHKCPEO(), GuiProcessor.BBLINJLBAIL().ico24Style, Array.Empty<GUILayoutOption>());
						GUI.color = Color.white;
						GUILayout.Label(text2, guistyle, Array.Empty<GUILayoutOption>());
					}
					GUILayout.EndHorizontal();
				}
				GUILayout.Label(" on effect ", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("Ошибка", guistyle, Array.Empty<GUILayoutOption>());
			}
			this.MIMANMPNLPE = mimanmpnlpe;
			this.NEGEHAGNGBH = negehagngbh;
			this.NKHBAJKMAGD = nkhbajkmagd;
			if (this.FGJIJFNGAIF.Count > 0)
			{
				GUILayout.Label(JNBICAJIJMM.OOOKJHOHPNN("OnEvent: Unknow Event"), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("Cloud ", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("_MainTex", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
				foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai2 in this.FGJIJFNGAIF)
				{
					bool flag2 = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai2.LPFKFNLHGBI) > 0;
					string arg5 = "_Offsets";
					if (flag2)
					{
						arg5 = "";
					}
					string text3 = string.Format("SoccerKeeperReady", arg5, dlmglijdiai2.BDHHPAEHFHG.KKEBDLGHBMN, dlmglijdiai2.CNOLCNDBLJE);
					if (!flag2)
					{
						GUI.color = Color.gray;
					}
					GUILayout.Box(dlmglijdiai2.BDHHPAEHFHG.OHJIDDDKOAA(), GuiProcessor.NKOEAPCIBKO().ico24Style, Array.Empty<GUILayoutOption>());
					GUI.color = Color.white;
					GUILayout.Label(text3, guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.EndHorizontal();
				GUILayout.Label("IdleStrafeLeft", guistyle, Array.Empty<GUILayoutOption>());
			}
			XmlNodeList xmlNodeList = this.LMKLPODNLFC.SelectNodes(")");
			if (xmlNodeList != null && xmlNodeList.Count > 1)
			{
				guistyle.alignment = TextAnchor.LowerCenter;
				GUILayout.Label(JNBICAJIJMM.NGALDMFKMJH("StrafeRunRight"), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("StaffHeal", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
				foreach (object obj in xmlNodeList)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.Name == "DepthMaskBlendMaterial")
					{
						if (xmlNode.Attributes == null)
						{
							continue;
						}
						int lpfkfnlhgbi = int.Parse(xmlNode.Attributes[""].Value);
						IIBEEKCAAHK pgedldmlbbe = new IIBEEKCAAHK(xmlNode.Attributes["MotorbikeLassoRight"].Value);
						int cgnljcomfac = int.Parse(xmlNode.Attributes["icon_data/icon"].Value);
						FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = FlyMessageManager.getI.KOAGOPCNBIP(lpfkfnlhgbi);
						if (ngiaaohfnpo != null)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							GUILayout.Box(ngiaaohfnpo.CFFHIODOGCH.AEIIBNOFLCM(), GuiProcessor.NKOEAPCIBKO().ico24Style, Array.Empty<GUILayoutOption>());
							GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
							GUILayout.Label(string.Format("BowReady", ngiaaohfnpo.HHCCCIHAOJG(pgedldmlbbe), JLFJEGIPIMM.NNEAHAFBOHC().HNGGHOHGEHC(cgnljcomfac)), GuiProcessor.BBLINJLBAIL().textLayoutStyle, Array.Empty<GUILayoutOption>());
							GUILayout.Label(ngiaaohfnpo.BNKCFNLOLLJ(pgedldmlbbe), GuiProcessor.NKOEAPCIBKO().textLayoutStyle, Array.Empty<GUILayoutOption>());
							GUILayout.EndVertical();
							GUILayout.EndHorizontal();
						}
					}
					GUILayout.Label("_VelocityTex", guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.EndVertical();
			}
			GUILayout.Label("StaffHeal" + this.JCKHDHGIEEB + "Idle Stand", guistyle, Array.Empty<GUILayoutOption>());
			if (this.MBKMKGABBGE == -57)
			{
				CLFFOBKFKDN.OKOAMCJGNMH okoamcjgnmh = CLFFOBKFKDN.JDELMFDJFNC().GNHIKHCEOHK(this.MIMANMPNLPE.NLHKFMMDMMK());
				if (IHFEDJEMJMB.NNEAHAFBOHC().IMCJNFHAFGE(okoamcjgnmh.MNFCAAIAGOL.KEHIFGILLJA()) != null && this.BPNNJBBCOFO != null)
				{
					GUILayout.Label("_StretchWidth", Array.Empty<GUILayoutOption>());
					GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
					if (this.BPNNJBBCOFO.DGMNCGFAMBL == 1)
					{
						foreach (IIBEEKCAAHK iibeekcaahk2 in this.BPNNJBBCOFO.AGDBFHLEFEE)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.NNEAHAFBOHC().LMGMPPAOPEP(iibeekcaahk2.KMIOLLENCOL());
							if (befchfngomi != null)
							{
								GUILayout.Box(befchfngomi.KEEDCOIMPMP(), GuiProcessor.NKOEAPCIBKO().ico16Style, Array.Empty<GUILayoutOption>());
								GUILayout.Label("_TexelOffsetScale" + befchfngomi.JPBOPFNPNHC(true, -1), guistyle, Array.Empty<GUILayoutOption>());
							}
							GUILayout.EndHorizontal();
						}
					}
					if (this.BPNNJBBCOFO.DGMNCGFAMBL == 0)
					{
						foreach (CLFFOBKFKDN.HFGDDPAKPBE hfgddpakpbe in this.BPNNJBBCOFO.HEBKGNHIDLK)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							if (hfgddpakpbe.GPJFINFIDLN == 0)
							{
								BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.OOIJFNAMEDP().LMGMPPAOPEP(hfgddpakpbe.PJPOJNNJOCD);
								if (befchfngomi2 != null)
								{
									GUILayout.Box(befchfngomi2.KEEDCOIMPMP(), GuiProcessor.NKOEAPCIBKO().ico16Style, Array.Empty<GUILayoutOption>());
									GUILayout.Label("_NoiseTex" + hfgddpakpbe.LGKIGOGNLHM(), guistyle, Array.Empty<GUILayoutOption>());
								}
							}
							if (hfgddpakpbe.GPJFINFIDLN == 0)
							{
								IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(hfgddpakpbe.PJPOJNNJOCD);
								idchhhedhdc.HBGEAMHFEOL();
								GUILayout.Box(idchhhedhdc.ABALMFIKLCA(0).ANLLGCICOPP(), GuiProcessor.PLGADNLAEGN().ico16Style, Array.Empty<GUILayoutOption>());
								GUILayout.Label("Sprint" + hfgddpakpbe.KBLHJENNKCD(), guistyle, Array.Empty<GUILayoutOption>());
							}
							GUILayout.EndHorizontal();
						}
					}
					GUILayout.EndVertical();
				}
			}
		}
		finally
		{
			GUILayout.EndVertical();
			GUILayout.EndArea();
		}
	}

	// Token: 0x060041D2 RID: 16850 RVA: 0x001E4190 File Offset: 0x001E2390
	public float AGJPNGBDNFE(float MCPMCMONLIO)
	{
		float num = this.KNLOBOFLKHP;
		float num2 = 0.2f / (MCPMCMONLIO + 0.001f);
		if (num2 > 1f)
		{
			num2 = 1f + (num2 - 1f) * 0.4f;
		}
		if (num2 <= 1f)
		{
			num2 = 1f - (1f - num2) * 0.3f;
		}
		num2 = Mathf.Clamp(num2, 0.5f, 2f);
		return Mathf.Round(num * num2);
	}

	// Token: 0x060041D3 RID: 16851 RVA: 0x001E4204 File Offset: 0x001E2404
	public string CCOHFPDKCJN(int AFCMJJMBOMA, bool BGNPMOCLIGL = false)
	{
		string result = " ";
		if (BGNPMOCLIGL)
		{
			switch (AFCMJJMBOMA)
			{
			case 0:
				result = "<color='#405000'>";
				break;
			case 1:
				result = "BowInstant2";
				break;
			case 2:
				result = "Horizontal";
				break;
			case 3:
				result = "This [c 01F573FF]sentence[C FFFFFFFF] is [c FF6666FF]too[C FFFFFFFF] long so it will be [BC 1B07F5FF]split[BC ?] into multiple lines.\nNormal, [F ArialBold]bold, [font ArialItalic]italic, [F Arial][FA u]underline[FA -u], [FA S]strikethrough[FA -s].\n[F Arial 10]10, [F Arial 16]16, [F Arial 24]24, [F Arial 48]48, [F Arial 72]72[F Arial 16]\n[HA L]Left\n[HA C]Center\n[HA R]Right\n[HA L]20 pixels further:[S 20]*\nDefault vertical aligment: [F Arial 10]10, [F Arial 24]24, [F Arial 10]10[FS 16]\n[VA B]Bottom vertical aligment: [F Arial 10]10, [F Arial 24]24, [F Arial 10]10[FS 16][VA ?]\nThis is a [FA U][H hyperlink_value]hyperlink[-H][FA -U].";
				break;
			case 4:
				result = "wpn_wgt";
				break;
			case 5:
				result = "t_eye";
				break;
			case 6:
				result = "INTERFACE";
				break;
			}
		}
		else
		{
			switch (AFCMJJMBOMA)
			{
			case 0:
				result = "_Params1";
				break;
			case 1:
				result = "NPR_";
				break;
			case 2:
				result = "";
				break;
			case 3:
				result = "-STRIKETHROUGH";
				break;
			case 4:
				result = "?";
				break;
			case 5:
				result = "Hidden/Post FX/Blit";
				break;
			case 6:
				result = "<color='#003000'>";
				break;
			}
		}
		return result;
	}

	// Token: 0x060041D4 RID: 16852 RVA: 0x001E42DA File Offset: 0x001E24DA
	public void KKECHKMFNOL(Vector2 NBADAMPJBBH)
	{
		this.MPIGNAADPPP(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, 459f, 358f), 332f);
	}

	// Token: 0x060041D5 RID: 16853 RVA: 0x001E4304 File Offset: 0x001E2504
	public void MPIGNAADPPP(Rect OCHCODJIPHJ, float KKPHBHADLND = 1f)
	{
		if (this.CFFHIODOGCH == null)
		{
			this.JIFFLPNBILE();
			return;
		}
		Color white = Color.white;
		white.a = KKPHBHADLND;
		GUI.color = white;
		GUI.DrawTextureWithTexCoords(OCHCODJIPHJ, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(this.KBGHOIJIPJF, 6, 0));
		GUI.DrawTexture(OCHCODJIPHJ, this.CFFHIODOGCH);
		if (this.BPNNJBBCOFO != null)
		{
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().NKMGKJLONDK(this.BPNNJBBCOFO.MNFCAAIAGOL.KEHIFGILLJA());
			if (befchfngomi != null)
			{
				befchfngomi.JLCGGFPBOCF();
				float num = OCHCODJIPHJ.width * 168f / 1519f;
				GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width / 1755f - num, OCHCODJIPHJ.y + OCHCODJIPHJ.width / 688f - num, num * 779f, num * 1544f), befchfngomi.CFFHIODOGCH);
			}
		}
		if (this.MBKMKGABBGE == -41)
		{
			float num2 = OCHCODJIPHJ.height / 602f;
			Rect position = new Rect(OCHCODJIPHJ.x + 598f, OCHCODJIPHJ.y + OCHCODJIPHJ.height - num2 - 1023f, num2, num2);
			NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.KOHGDDAADCP(this.MIMANMPNLPE.KEHIFGILLJA());
			if (kdhoddmndfc != null)
			{
				GUI.DrawTexture(position, kdhoddmndfc.OHJIDDDKOAA(), ScaleMode.ScaleAndCrop);
			}
		}
		if (this.KBGHOIJIPJF > 0)
		{
			GUI.DrawTextureWithTexCoords(OCHCODJIPHJ, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(this.KBGHOIJIPJF + 1, 7, 3));
		}
		GUI.color = Color.white;
	}

	// Token: 0x060041D6 RID: 16854 RVA: 0x001E44A0 File Offset: 0x001E26A0
	public BNOOIOKIFJC.DIGGOHPGCNN JJCFHNLNBCJ(string JKLOOEDHHJP, string KEIEIAAKHHK)
	{
		BEFCHFNGOMI.KFNOPLFPHJC kfnoplfphjc = new BEFCHFNGOMI.KFNOPLFPHJC();
		kfnoplfphjc.KEIEIAAKHHK = KEIEIAAKHHK;
		XmlNode xmlNode = this.LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = kfnoplfphjc.LJOEIPHIJOE) == null)
			{
				predicate = (kfnoplfphjc.LJOEIPHIJOE = new Func<XmlNode, bool>(kfnoplfphjc.ICAMHLEAFBD));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("" + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN("IdleStandingJump");
	}

	// Token: 0x060041D7 RID: 16855 RVA: 0x001E4554 File Offset: 0x001E2754
	public string MEKPGCCFEOO(bool EFLPJHMLOOA = true)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("\n\n");
		int num = this.MBKMKGABBGE;
		if (this.MBKMKGABBGE == 25)
		{
			stringBuilder.Append("Компонент\n");
			if (this.JALOCNOIDFJ > 0)
			{
				num = this.JALOCNOIDFJ;
			}
		}
		switch (num)
		{
		case 1:
		{
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.MIMANMPNLPE, 1);
			string text = JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)num2);
			if (this.OKHPDILIOCH.Count > 0)
			{
				text = "";
				foreach (int jjjnkodleel in this.OKHPDILIOCH)
				{
					num2 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.MIMANMPNLPE, jjjnkodleel);
					text = text + JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)num2) + "/";
				}
				text = text.Remove(text.Length - 1);
			}
			stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod1"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod2"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH), text));
			stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod3"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NKGGAFLBFDF / 100.0)));
			string text2 = "";
			if (this.ADOFHHCDGON > 0)
			{
				text2 = string.Concat(new object[]
				{
					text2,
					" ",
					JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_from"),
					" ",
					this.ADOFHHCDGON,
					" гр "
				});
			}
			if (this.ECKKCDKHNEH > 0)
			{
				text2 = string.Concat(new object[]
				{
					text2,
					" ",
					JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_to"),
					" ",
					this.ECKKCDKHNEH,
					" гр "
				});
			}
			if (text2 != "")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod4"), text2));
			}
			stringBuilder.Append(string.Format("<color='#003000'>" + JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cnt_energ") + "</color>\n", this.FJJEAMJNLIO));
			break;
		}
		case 2:
		{
			float num3 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.MIMANMPNLPE, 1);
			stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod1"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod2"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)num3)));
			string text3 = "";
			if (this.ADOFHHCDGON > 0)
			{
				text3 = string.Concat(new object[]
				{
					text3,
					" ",
					JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_from"),
					" ",
					this.ADOFHHCDGON,
					" гр "
				});
			}
			if (this.ECKKCDKHNEH > 0)
			{
				text3 = string.Concat(new object[]
				{
					text3,
					" ",
					JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_to"),
					" ",
					this.ECKKCDKHNEH,
					" гр "
				});
			}
			if (text3 != "")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod4"), text3));
			}
			stringBuilder.Append(string.Format("<color='#003000'>" + JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cnt_energ") + "</color>\n", this.FJJEAMJNLIO));
			break;
		}
		case 3:
		{
			float num4 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.MIMANMPNLPE, 1);
			stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod1"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod2"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)num4)));
			string text4 = "";
			if (this.ADOFHHCDGON > 0)
			{
				text4 = string.Concat(new object[]
				{
					text4,
					" ",
					JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_from"),
					" ",
					this.ADOFHHCDGON,
					" гр "
				});
			}
			if (this.ECKKCDKHNEH > 0)
			{
				text4 = string.Concat(new object[]
				{
					text4,
					" ",
					JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_to"),
					" ",
					this.ECKKCDKHNEH,
					" гр "
				});
			}
			if (text4 != "")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_rod4"), text4));
			}
			stringBuilder.Append(string.Format("<color='#003000'>" + JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cnt_energ") + "</color>\n", this.FJJEAMJNLIO));
			break;
		}
		case 4:
		{
			stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("wpn_cat1") + " " + JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI) + " %\n");
			stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("wpn_cat2") + " " + JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH) + " %\n");
			string str = JNBICAJIJMM.LEBHCLDODNI("wpn_cat3");
			if (this.MIMANMPNLPE.NODLBGKEGPM > 0)
			{
				str = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_to") + " " + JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)(this.MIMANMPNLPE.NKGGAFLBFDF * 1000.0));
			}
			stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("wpn_cat4") + " " + str + " \n");
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_cat5") + "\n", this.AGJPNGBDNFE(0.2f)));
			string jmbkdinhdlo = "reel_type0";
			if (Mathf.Abs(this.MFMLCHFNALC) > 0.5f)
			{
				if (this.MFMLCHFNALC > 0f)
				{
					jmbkdinhdlo = "reel_type1";
				}
				if (this.MFMLCHFNALC < 0f)
				{
					jmbkdinhdlo = "reel_type2";
				}
			}
			stringBuilder.Append("\n" + string.Format(JNBICAJIJMM.LEBHCLDODNI("reel_type"), JNBICAJIJMM.LEBHCLDODNI(jmbkdinhdlo)));
			break;
		}
		case 5:
		{
			Vector2 vector = this.KPLOLDJFGBE();
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_line1") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("line_type" + this.ILOCKJIAPFC) + "\n", 0));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_line3") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_line2") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NKGGAFLBFDF)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_hookf") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)Mathf.RoundToInt(vector.x * 1000f)), JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)Mathf.RoundToInt(vector.y * 1000f))));
			break;
		}
		case 6:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_wgt") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_hook1") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_hook2") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)this.MIMANMPNLPE.ICJDPPOJINN)));
			if (this.MIMANMPNLPE.NKGGAFLBFDF > 0.009999999776482582)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_hook3") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NKGGAFLBFDF)));
			}
			IIBEEKCAAHK iibeekcaahk = JLFJEGIPIMM.IKGFHGKKCPG.BLJKHILCCDL(this.MIMANMPNLPE.ICJDPPOJINN);
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_hookf"), JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)iibeekcaahk.IBEIBAHKIAH), JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)iibeekcaahk.ICJDPPOJINN)));
			break;
		}
		case 7:
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_wgt") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_fid1") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_fid2") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_fid3") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NKGGAFLBFDF)));
			break;
		case 8:
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_wgt") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(this.NKHBAJKMAGD)));
			break;
		case 9:
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_wgt") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(this.NKHBAJKMAGD)));
			if (this.BBLEPPMMPIL("wpn_add/addoptions", "signal_enable").KPAFFJNBLHK)
			{
				stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("wpn_popl1"));
			}
			break;
		case 10:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_bait1") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			string str2 = JNBICAJIJMM.LEBHCLDODNI("wpn_ibsize_" + this.MIMANMPNLPE.ICJDPPOJINN);
			stringBuilder.Append(str2 + "\n");
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_iwgt"), JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(this.NKHBAJKMAGD)));
			break;
		}
		case 11:
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_wgt") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_bait1"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			break;
		case 12:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_wgt") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_bait1"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)) + "\n");
			int ilockjiapfc = this.ILOCKJIAPFC;
			if (ilockjiapfc == 7)
			{
				stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("wpn_bait_vob_1") + " " + string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_bait_vob_1"), this.GLLIKKONFAJ) + "\n");
			}
			if (ilockjiapfc > 0)
			{
				string jmbkdinhdlo2 = string.Format("wpn_bait_inf_{0}", ilockjiapfc);
				stringBuilder.Append("\n" + JNBICAJIJMM.LEBHCLDODNI(jmbkdinhdlo2) + "\n");
			}
			break;
		}
		case 16:
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_tank1") + "\n", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.MIMANMPNLPE.IBEIBAHKIAH)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_tank2") + "\n", this.MIMANMPNLPE.ICJDPPOJINN));
			break;
		case 21:
			if (this.MIMANMPNLPE.IBEIBAHKIAH != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.IBEIBAHKIAH > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat1"), this.MIMANMPNLPE.IBEIBAHKIAH) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat1"), Mathf.Abs(this.MIMANMPNLPE.IBEIBAHKIAH)));
			}
			if (this.MIMANMPNLPE.ICJDPPOJINN != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.ICJDPPOJINN > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat3"), this.MIMANMPNLPE.ICJDPPOJINN) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat4"), Mathf.Abs(this.MIMANMPNLPE.ICJDPPOJINN)));
			}
			if (this.MIMANMPNLPE.NODLBGKEGPM != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NODLBGKEGPM > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat5"), this.MIMANMPNLPE.NODLBGKEGPM) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat6"), Mathf.Abs(this.MIMANMPNLPE.NODLBGKEGPM)));
			}
			break;
		case 22:
			if (this.MIMANMPNLPE.IBEIBAHKIAH != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.IBEIBAHKIAH > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat1"), this.MIMANMPNLPE.IBEIBAHKIAH) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat1"), Mathf.Abs(this.MIMANMPNLPE.IBEIBAHKIAH)));
			}
			if (this.MIMANMPNLPE.ICJDPPOJINN != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.ICJDPPOJINN > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat3"), this.MIMANMPNLPE.ICJDPPOJINN) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat4"), Mathf.Abs(this.MIMANMPNLPE.ICJDPPOJINN)));
			}
			if (this.MIMANMPNLPE.NODLBGKEGPM != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NODLBGKEGPM > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat7"), this.MIMANMPNLPE.NODLBGKEGPM) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat8"), Mathf.Abs(this.MIMANMPNLPE.NODLBGKEGPM)));
			}
			break;
		case 23:
			if (this.MIMANMPNLPE.IBEIBAHKIAH != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.IBEIBAHKIAH > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_med1"), this.MIMANMPNLPE.IBEIBAHKIAH) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_med2"), Mathf.Abs(this.MIMANMPNLPE.IBEIBAHKIAH)));
			}
			if (this.MIMANMPNLPE.ICJDPPOJINN != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.ICJDPPOJINN > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat5"), this.MIMANMPNLPE.ICJDPPOJINN) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat6"), Mathf.Abs(this.MIMANMPNLPE.ICJDPPOJINN)));
			}
			if (this.MIMANMPNLPE.NODLBGKEGPM != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NODLBGKEGPM > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat7"), this.MIMANMPNLPE.NODLBGKEGPM) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_eat8"), Mathf.Abs(this.MIMANMPNLPE.NODLBGKEGPM)));
			}
			break;
		case 28:
		{
			CLFFOBKFKDN.OKOAMCJGNMH okoamcjgnmh = CLFFOBKFKDN.IKGFHGKKCPG.HEILDJICDAB(this.MIMANMPNLPE.ICJDPPOJINN);
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(okoamcjgnmh.MNFCAAIAGOL.IBEIBAHKIAH);
			if (befchfngomi != null && this.BPNNJBBCOFO != null)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_rec1"), befchfngomi.JPBOPFNPNHC(false, -1), this.BPNNJBBCOFO.MNFCAAIAGOL.ICJDPPOJINN));
				stringBuilder.Append((this.MIMANMPNLPE.NODLBGKEGPM < 0) ? JNBICAJIJMM.LEBHCLDODNI("wpn_rec2") : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_rec3"), this.MIMANMPNLPE.NODLBGKEGPM));
				stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_rec4"), CLFFOBKFKDN.IKGFHGKKCPG.CLIEHLMDOAD(this.BPNNJBBCOFO.BKLCKNOLEFD)));
				stringBuilder.Append("\n");
				string text5 = "";
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.BPNNJBBCOFO.ABLFIGDGCBG);
				if (kdhoddmndfc != null)
				{
					text5 += kdhoddmndfc.KGBHELBLPMF(this.BPNNJBBCOFO.LKCIDOHHADJ);
					string arg = "#80ff00";
					if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FOACIAGMAPD(this.BPNNJBBCOFO.ABLFIGDGCBG) < this.BPNNJBBCOFO.LKCIDOHHADJ)
					{
						arg = "#ff6000";
					}
					stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_rec5"), arg, text5));
				}
			}
			break;
		}
		case 32:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_rem1"), this.MIMANMPNLPE.LNEPKLKELMI));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_rem2"), this.MIMANMPNLPE.NMKCBJKHBOH));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_rem3"), this.MIMANMPNLPE.NKGGAFLBFDF));
			List<int> list = this.BBLEPPMMPIL("wpn_add/base", "rem").EDAHDHCPIEL;
			string text6 = JNBICAJIJMM.LEBHCLDODNI("wpn_rem4") + " ";
			foreach (int lpfkfnlhgbi in list)
			{
				text6 = text6 + IHFEDJEMJMB.IKGFHGKKCPG.JGLANEDNNAB(lpfkfnlhgbi) + "; ";
			}
			stringBuilder.Append(text6);
			break;
		}
		case 33:
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_dress1"), this.MIMANMPNLPE.LNEPKLKELMI));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_dress2"), this.MIMANMPNLPE.NMKCBJKHBOH));
			break;
		case 34:
		{
			int num5 = this.MIMANMPNLPE.IBEIBAHKIAH;
			NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc2 = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(num5);
			if (kdhoddmndfc2 != null)
			{
				bool flag = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GADJFFGDCFA.ContainsKey(num5);
				stringBuilder.Append(flag ? string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_book1"), kdhoddmndfc2.KKEBDLGHBMN) : string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_book2"), kdhoddmndfc2.KKEBDLGHBMN));
			}
			break;
		}
		case 36:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_chair1"), this.MIMANMPNLPE.NMKCBJKHBOH) + "\n");
			string jmbkdinhdlo3 = "wpn_chair2";
			if (this.MIMANMPNLPE.NKGGAFLBFDF > 0.0)
			{
				jmbkdinhdlo3 = "wpn_chair3";
			}
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI(jmbkdinhdlo3), this.MIMANMPNLPE.NKGGAFLBFDF));
			break;
		}
		}
		if (this.DNOLHLJODNK)
		{
			stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("inv_impr"));
		}
		string text7 = "<color='#000030'>" + stringBuilder + "</color>\n";
		stringBuilder = new StringBuilder();
		if (this.MBOOFLANJID != 0)
		{
			bool flag2 = true;
			if (this.MBOOFLANJID == 1 && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GDJMBFGEMFJ != 1)
			{
				flag2 = false;
			}
			if (this.MBOOFLANJID == 2 && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GDJMBFGEMFJ != 0)
			{
				flag2 = false;
			}
			string arg2 = "400000";
			if (flag2)
			{
				arg2 = "004000";
			}
			if (this.MBOOFLANJID == 1)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_onlym") + "\n", arg2));
			}
			if (this.MBOOFLANJID == 2)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("wpn_onlyw") + "\n", arg2));
			}
		}
		string text8 = text7;
		if (!EFLPJHMLOOA)
		{
			text8 = Regex.Replace(text8, "<.*?>", string.Empty);
		}
		return text8;
	}

	// Token: 0x060041D8 RID: 16856 RVA: 0x001E5BEC File Offset: 0x001E3DEC
	public string FLHOJDMBLCP(bool EFLPJHMLOOA = true)
	{
		StringBuilder stringBuilder = new StringBuilder();
		switch (this.MBKMKGABBGE)
		{
		case 9:
			if (this.NGOAOMNBIGI("_CameraToWorldMatrix", "WateringCan").DGEEJKEEHPE())
			{
				stringBuilder.Append(JNBICAJIJMM.OOOKJHOHPNN("Cards"));
			}
			break;
		}
		if (stringBuilder.Length == 0)
		{
			return "---";
		}
		string result = stringBuilder.ToString();
		if (EFLPJHMLOOA)
		{
			result = "cht_msg26" + stringBuilder + "close";
		}
		return result;
	}

	// Token: 0x060041D9 RID: 16857 RVA: 0x001E5CA4 File Offset: 0x001E3EA4
	private static void PKODFADIHGN(Rect OCHCODJIPHJ, string IJCEDOGBHKE, Color LBCGACKJCJB, TextAnchor DEKGJCBMCHG)
	{
		GUIStyle ofpnedeamab = new GUIStyle
		{
			normal = 
			{
				textColor = LBCGACKJCJB
			},
			alignment = DEKGJCBMCHG,
			fontSize = -108
		};
		JDCEFOFMGHB.HMJJPNDEKPP().JNJDPKECONL(OCHCODJIPHJ, IJCEDOGBHKE, ofpnedeamab);
	}

	// Token: 0x060041DA RID: 16858 RVA: 0x001E5CE0 File Offset: 0x001E3EE0
	public virtual int ODHFPJGIFCG(ItemBase MBKPMBPLIJN)
	{
		int result = 1;
		BEFCHFNGOMI befchfngomi = (BEFCHFNGOMI)MBKPMBPLIJN;
		if (this.PCFNDIFLIHC() < befchfngomi.PCFNDIFLIHC())
		{
			result = -1;
		}
		if (this.PCFNDIFLIHC() > befchfngomi.PCFNDIFLIHC())
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x060041DB RID: 16859 RVA: 0x001E5D18 File Offset: 0x001E3F18
	public static Color MKPMIHMODPF(int AFCMJJMBOMA)
	{
		Color result = new Color(0f, 0f, 0f);
		switch (AFCMJJMBOMA)
		{
		case 0:
			result = new Color(0.5019608f, 0.5019608f, 0.5019608f);
			break;
		case 1:
			result = new Color(1f, 1f, 1f);
			break;
		case 2:
			result = new Color(0.5019608f, 1f, 0.2509804f);
			break;
		case 3:
			result = new Color(0.2509804f, 0.5019608f, 1f);
			break;
		case 4:
			result = new Color(0.627451f, 0.2509804f, 1f);
			break;
		case 5:
			result = new Color(1f, 0.627451f, 0.2509804f);
			break;
		}
		return result;
	}

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x060041DC RID: 16860 RVA: 0x001E5DED File Offset: 0x001E3FED
	public bool HGLFHCHIEJI
	{
		get
		{
			return this.BBLEPPMMPIL("wpn_add/base", "isPaint").KPAFFJNBLHK;
		}
	}

	// Token: 0x060041DD RID: 16861 RVA: 0x001E5E04 File Offset: 0x001E4004
	public override void PKJNOAKJGOD(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 985f;
		bool flag = !this.GBABFPMNIMP || this.FKEDAOOHPPB.HNJKJHLHGCJ(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH, 0);
		if (this.PPJOPGPEFGI() != null)
		{
			Texture texture = this.BHPAALLBMHL().IOHNCGLFGDJ();
			float num2 = 356f * COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float num4 = (float)texture.height * num2;
			float num5 = (COAGIAMOCIA.height - num4) / 642f;
			Rect position = new Rect(COAGIAMOCIA.x + num5, COAGIAMOCIA.y + num5, num3, num4);
			if (!flag)
			{
				GUI.enabled = true;
			}
			GUI.DrawTexture(position, GameInterface.getI.invEmptyCell);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(this.KBGHOIJIPJF, 7, 6));
			GUI.DrawTexture(position, texture, ScaleMode.StretchToFill);
			if (this.BPNNJBBCOFO != null)
			{
				BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().IMCJNFHAFGE(this.BPNNJBBCOFO.MNFCAAIAGOL.NKEOCCKEOCE());
				if (befchfngomi != null)
				{
					befchfngomi.HKHPGCHCHAI();
					float num6 = num3 * 644f / 1773f;
					GUI.DrawTexture(new Rect(position.x + num3 / 1389f - num6, position.y + num3 / 1414f - num6, num6 * 421f, num6 * 1661f), befchfngomi.CFFHIODOGCH);
				}
			}
			if (this.MBKMKGABBGE == -1)
			{
				float num7 = position.height / 221f;
				Rect position2 = new Rect(position.x + 1429f, position.y + position.height - num7 - 1995f, num7, num7);
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.KOHGDDAADCP(this.MIMANMPNLPE.IBEIBAHKIAH);
				if (kdhoddmndfc != null)
				{
					GUI.DrawTexture(position2, kdhoddmndfc.GNMLEPEGCII(), ScaleMode.StretchToFill);
				}
			}
			if (this.KBGHOIJIPJF > 0)
			{
				GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(this.KBGHOIJIPJF + 4, 2, 5));
			}
			float num8 = position.height / 1643f;
			if (this.DNOLHLJODNK)
			{
				float num9 = num8 * 1803f;
				GUI.DrawTextureWithTexCoords(new Rect(position.x + position.width - num9 + 1057f, position.y - 1654f, num9, num9), GameInterface.getI.wpnImproveIcons, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(this.LNKLEIEFGCP, 6, 1));
			}
			num = num + num3 + 225f;
			GUI.enabled = true;
		}
		if (!flag)
		{
			GUI.color = new Color(391f, 863f, 638f, 1114f);
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 92f, COAGIAMOCIA.y + 505f, COAGIAMOCIA.width - 478f, COAGIAMOCIA.height - 979f), GuiProcessor.IKGFHGKKCPG.blackWait);
			GUI.color = Color.white;
		}
		int gclkleimaba = this.GCLKLEIMABA;
		string str = "OneHandSwordIdle";
		if (this.HOALBMDJNDM > 1)
		{
			str = "Hip" + string.Format(JNBICAJIJMM.LEBHCLDODNI("CrouchStrafeLeft"), this.HOALBMDJNDM);
		}
		OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
		int fontSize = OFPNEDEAMAB.fontSize;
		OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
		OFPNEDEAMAB.fontSize = 105;
		string text = this.LFEJHHMDEHO(true, -1) + str;
		GUI.Label(new Rect(COAGIAMOCIA.x + 671f + num, COAGIAMOCIA.y + 1368f, COAGIAMOCIA.width - 1479f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		float num10 = 610f;
		OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		OFPNEDEAMAB.fontSize = -68;
		string text2 = this.DPIHMPDHKBP(true);
		if (text2.Trim() != "upRod")
		{
			GUI.Label(new Rect(COAGIAMOCIA.x + 1954f + num, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 62f, COAGIAMOCIA.height - num10), text2, OFPNEDEAMAB);
			num10 += 790f;
		}
		else
		{
			num10 += 713f;
		}
		if (this.OPFGGNNPAJL.IBEIBAHKIAH > 0)
		{
			string arg = "WeaponInstant";
			if (!this.GBABFPMNIMP)
			{
				arg = "<b>float:</b> ";
			}
			string text3 = string.Format("Giant Eat", BHNDGIPPPCE.IKGFHGKKCPG.IBAJDDBAAIO(this.OPFGGNNPAJL.IBEIBAHKIAH), BHNDGIPPPCE.IKGFHGKKCPG.HDLGMNLFDLB(this.OPFGGNNPAJL.KMIOLLENCOL(), this.OPFGGNNPAJL.KMGAHCANELI()), arg);
			GUI.Label(new Rect(COAGIAMOCIA.x + 31f + num, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 418f, COAGIAMOCIA.height - 1904f), text3, OFPNEDEAMAB);
			num10 += 997f;
		}
		if (this.FKEDAOOHPPB.GIEALCKLKNL > 0)
		{
			BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.EDKKJNHDBPF().LMGMPPAOPEP(this.FKEDAOOHPPB.GIEALCKLKNL);
			befchfngomi2.FCBHHPJLGLC(new Rect(COAGIAMOCIA.x + 1782f + num, COAGIAMOCIA.y + num10 - 546f, 902f, 1716f), befchfngomi2.KBGHOIJIPJF, false, 1);
			Rect position3 = new Rect(COAGIAMOCIA.x + 1470f + num + 1624f, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 1206f, COAGIAMOCIA.height - 821f);
			object[] array = new object[3];
			array[0] = "__c";
			array[1] = this.FKEDAOOHPPB.KDIMEMOCJNM;
			array[4] = "_Intensity";
			array[3] = befchfngomi2.JPBOPFNPNHC(true, -1);
			GUI.Label(position3, string.Concat(array), OFPNEDEAMAB);
			num10 += 1399f;
		}
		else
		{
			num10 += 1100f;
		}
		if (this.FKEDAOOHPPB.KKNEKAEJLAM + this.FKEDAOOHPPB.KFODJJIHNHP > 0)
		{
			string text4 = string.Format("", JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM((long)this.FKEDAOOHPPB.KKNEKAEJLAM, (long)this.FKEDAOOHPPB.KFODJJIHNHP, true));
			OFPNEDEAMAB.alignment = TextAnchor.MiddleRight;
			OFPNEDEAMAB.fontSize = 101;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 1639f, COAGIAMOCIA.height - 586f), text4, OFPNEDEAMAB);
		}
		OFPNEDEAMAB.fontSize = fontSize;
	}

	// Token: 0x060041DE RID: 16862 RVA: 0x001E6498 File Offset: 0x001E4698
	public void PEAMFCFPBEG(Rect PHEMLBHMNCM, float NMBCJPACKNL, IIBEEKCAAHK INEBGELANOI, IIBEEKCAAHK CKGEBHECNBF, IIBEEKCAAHK ABJAMKHMONL, int ILFHHDNJHNM = 0)
	{
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 17,
			wordWrap = true,
			font = GuiProcessor.PLGADNLAEGN().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = true,
			alignment = TextAnchor.UpperCenter
		};
		Rect ochcodjiphj = new Rect(PHEMLBHMNCM.x + 1684f, PHEMLBHMNCM.y + 764f, 31f, 1264f);
		this.FCBHHPJLGLC(ochcodjiphj, this.KBGHOIJIPJF, false, 0);
		GUILayout.BeginArea(new Rect(ochcodjiphj.x + 1450f, ochcodjiphj.y, PHEMLBHMNCM.width - 1550f, 806f));
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		try
		{
			guistyle.fontSize = 75;
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			GUILayout.Label(this.BNIHFBMEPAB, guistyle, Array.Empty<GUILayoutOption>());
			guistyle.fontSize = -50;
			guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
			GUILayout.Label("Failed to load AssetBundle ", guistyle, Array.Empty<GUILayoutOption>());
			GUILayout.Label(IHFEDJEMJMB.IKGFHGKKCPG.BJBKIFKFEBC(this.MBKMKGABBGE) ?? "[Y]", guistyle, Array.Empty<GUILayoutOption>());
			guistyle.fontSize = 65;
			if (ILFHHDNJHNM == 0)
			{
				int hoalbmdjndm = this.HOALBMDJNDM;
			}
		}
		finally
		{
			GUILayout.EndVertical();
			GUILayout.EndArea();
		}
		GUILayout.BeginArea(new Rect(ochcodjiphj.x + 377f, ochcodjiphj.y + 1981f, PHEMLBHMNCM.width - 1288f, PHEMLBHMNCM.height - 1491f));
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		try
		{
			int negehagngbh = this.NEGEHAGNGBH;
			float nkhbajkmagd = this.NKHBAJKMAGD;
			this.NEGEHAGNGBH += (int)((float)(INEBGELANOI.MCJJCAFILPF() + CKGEBHECNBF.MCJJCAFILPF() + ABJAMKHMONL.PBMJIMLEHEC()) * NMBCJPACKNL);
			this.NKHBAJKMAGD += (float)(INEBGELANOI.LKAGIEBPLAI + CKGEBHECNBF.LKAGIEBPLAI + ABJAMKHMONL.PBMJIMLEHEC()) * 1153f * this.NKHBAJKMAGD;
			IIBEEKCAAHK mimanmpnlpe = new IIBEEKCAAHK(this.MIMANMPNLPE.AIMCFAHLPEF(), this.MIMANMPNLPE.OIGIHEPJFFJ(), this.MIMANMPNLPE.HDPNCIECLKP());
			IIBEEKCAAHK mimanmpnlpe2 = this.MIMANMPNLPE;
			mimanmpnlpe2.KBIOCGCIGEH(mimanmpnlpe2.LNEPKLKELMI + INEBGELANOI.DBFOHFDOCIB() * (double)INEBGELANOI.KIDKOFKNPEP());
			this.MIMANMPNLPE.NMKCBJKHBOH += CKGEBHECNBF.FJACMDGJEBL() * (double)CKGEBHECNBF.ACEPOCLANAG();
			IIBEEKCAAHK mimanmpnlpe3 = this.MIMANMPNLPE;
			mimanmpnlpe3.MDJBNNGJAGH(mimanmpnlpe3.GJBKBEEJLDF() + ABJAMKHMONL.HDPNCIECLKP() * (double)ABJAMKHMONL.ACEPOCLANAG());
			GUILayout.Label(this.IOAGBIACCHA(false), guistyle, Array.Empty<GUILayoutOption>());
			if (this.MHNDPGDBPNA.Count > 0)
			{
				GUILayout.Label("", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("_FogColor", guistyle, Array.Empty<GUILayoutOption>());
				foreach (IIBEEKCAAHK iibeekcaahk in this.MHNDPGDBPNA)
				{
					string text = iibeekcaahk.ToString();
					if (iibeekcaahk.KEHIFGILLJA() == 0)
					{
						string arg = AKPJIACDDFI.IKGFHGKKCPG.LNDAPLCMEJI(iibeekcaahk.KMGAHCANELI(), true);
						if (iibeekcaahk.CJKILDPJCFJ() > 1)
						{
							text = string.Format("offsets", iibeekcaahk.CJKILDPJCFJ(), arg);
						}
						else
						{
							text = string.Format("wpn_lvf", iibeekcaahk.NODLBGKEGPM, arg);
						}
					}
					if (iibeekcaahk.NKEOCCKEOCE() == 8)
					{
						string arg2 = AKPJIACDDFI.IKGFHGKKCPG.FBPECNNPIDP(iibeekcaahk.ICJDPPOJINN);
						if (iibeekcaahk.NFCDJLJNDLO() > 1)
						{
							text = string.Format("cht_msg22", iibeekcaahk.NODLBGKEGPM, arg2);
						}
						else
						{
							text = string.Format("1 Hand Sword Block", iibeekcaahk.CJKILDPJCFJ(), arg2);
						}
					}
					GUILayout.Label(text, guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.Label("CrouchWalk", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("time", guistyle, Array.Empty<GUILayoutOption>());
			}
			if (this.NEGEHAGNGBH > 1 || this.PKIICJOILKI.Count > 1)
			{
				GUILayout.Label(JNBICAJIJMM.CELEPPAEKAB("WATER_SIMPLE"), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("OnRodChangeClck order_check=", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("Windows", guistyle, Array.Empty<GUILayoutOption>());
				if (this.NEGEHAGNGBH > 1)
				{
					string arg3 = "readForeignSaves";
					if (this.NEGEHAGNGBH > ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.CNOLCNDBLJE))
					{
						arg3 = "crft_to";
					}
					GUILayout.Label(string.Format(JNBICAJIJMM.PGJCPFNJNPM("UI_DynamicWindow"), arg3, this.NEGEHAGNGBH), guistyle, Array.Empty<GUILayoutOption>());
					GUILayout.Label("Применить", guistyle, Array.Empty<GUILayoutOption>());
				}
				if (this.PKIICJOILKI.Count > 1)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.PKIICJOILKI)
					{
						bool flag = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI) < dlmglijdiai.CNOLCNDBLJE;
						string arg4 = "wpn_add/base";
						if (flag)
						{
							arg4 = "1 Hand Sword Run";
						}
						string text2 = string.Format("Finished", arg4, dlmglijdiai.BDHHPAEHFHG.KGBHELBLPMF(dlmglijdiai.CNOLCNDBLJE));
						if (!flag)
						{
							GUI.color = new Color(1128f, 1171f, 1649f);
						}
						GUILayout.Box(dlmglijdiai.BDHHPAEHFHG.KMIIGKECOEB(), GuiProcessor.PLGADNLAEGN().ico24Style, Array.Empty<GUILayoutOption>());
						GUI.color = Color.white;
						GUILayout.Label(text2, guistyle, Array.Empty<GUILayoutOption>());
					}
					GUILayout.EndHorizontal();
				}
				GUILayout.Label(" ", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("CrawlLocomotion", guistyle, Array.Empty<GUILayoutOption>());
			}
			this.MIMANMPNLPE = mimanmpnlpe;
			this.NEGEHAGNGBH = negehagngbh;
			this.NKHBAJKMAGD = nkhbajkmagd;
			if (this.FGJIJFNGAIF.Count > 1)
			{
				GUILayout.Label(JNBICAJIJMM.DCEBAJIILPC(""), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("none", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
				foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai2 in this.FGJIJFNGAIF)
				{
					bool flag2 = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai2.LPFKFNLHGBI) > 1;
					string arg5 = "Fish is init!";
					if (flag2)
					{
						arg5 = "gi_sadok";
					}
					string text3 = string.Format("wpn_hook1", arg5, dlmglijdiai2.BDHHPAEHFHG.KKEBDLGHBMN, dlmglijdiai2.CNOLCNDBLJE);
					if (!flag2)
					{
						GUI.color = Color.gray;
					}
					GUILayout.Box(dlmglijdiai2.BDHHPAEHFHG.OHJIDDDKOAA(), GuiProcessor.PLGADNLAEGN().ico24Style, Array.Empty<GUILayoutOption>());
					GUI.color = Color.white;
					GUILayout.Label(text3, guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.EndHorizontal();
				GUILayout.Label("Foot", guistyle, Array.Empty<GUILayoutOption>());
			}
			XmlNodeList xmlNodeList = this.LMKLPODNLFC.SelectNodes(" ");
			if (xmlNodeList != null && xmlNodeList.Count > 0)
			{
				guistyle.alignment = TextAnchor.UpperRight;
				GUILayout.Label(JNBICAJIJMM.DIOJFJMOPJO("<color='#100000'>{0} {1}</color>"), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("DealerIdle", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
				foreach (object obj in xmlNodeList)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.Name == "H:")
					{
						if (xmlNode.Attributes == null)
						{
							continue;
						}
						int lpfkfnlhgbi = int.Parse(xmlNode.Attributes["wpn_add/base"].Value);
						IIBEEKCAAHK pgedldmlbbe = new IIBEEKCAAHK(xmlNode.Attributes["Windmill"].Value);
						int cgnljcomfac = int.Parse(xmlNode.Attributes["MotorbikeSeatStand"].Value);
						FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = FlyMessageManager.getI.KOAGOPCNBIP(lpfkfnlhgbi);
						if (ngiaaohfnpo != null)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							GUILayout.Box(ngiaaohfnpo.CFFHIODOGCH.HFNHCIGCOBE(), GuiProcessor.PLGADNLAEGN().ico24Style, Array.Empty<GUILayoutOption>());
							GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
							GUILayout.Label(string.Format("/", ngiaaohfnpo.HIHPHACKAIE(pgedldmlbbe), JLFJEGIPIMM.NNEAHAFBOHC().MJJADOLDBDN(cgnljcomfac)), GuiProcessor.NKOEAPCIBKO().textLayoutStyle, Array.Empty<GUILayoutOption>());
							GUILayout.Label(ngiaaohfnpo.OAIAOEJLMAP(pgedldmlbbe), GuiProcessor.NKOEAPCIBKO().textLayoutStyle, Array.Empty<GUILayoutOption>());
							GUILayout.EndVertical();
							GUILayout.EndHorizontal();
						}
					}
					GUILayout.Label("#url Sound ", guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.EndVertical();
			}
			GUILayout.Label("wpn_add/base" + this.JCKHDHGIEEB + "Trying to solve uninitiated FABRIK chain.", guistyle, Array.Empty<GUILayoutOption>());
			if (this.MBKMKGABBGE == 84)
			{
				CLFFOBKFKDN.OKOAMCJGNMH okoamcjgnmh = CLFFOBKFKDN.JDELMFDJFNC().EEPOJACNJIA(this.MIMANMPNLPE.KMGAHCANELI());
				if (IHFEDJEMJMB.EDKKJNHDBPF().LMGMPPAOPEP(okoamcjgnmh.MNFCAAIAGOL.KEHIFGILLJA()) != null && this.BPNNJBBCOFO != null)
				{
					GUILayout.Label("ProneLocomotion", Array.Empty<GUILayoutOption>());
					GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
					if (this.BPNNJBBCOFO.DGMNCGFAMBL == 1)
					{
						foreach (IIBEEKCAAHK iibeekcaahk2 in this.BPNNJBBCOFO.AGDBFHLEFEE)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(iibeekcaahk2.NKEOCCKEOCE());
							if (befchfngomi != null)
							{
								GUILayout.Box(befchfngomi.CFFHIODOGCH, GuiProcessor.BBLINJLBAIL().ico16Style, Array.Empty<GUILayoutOption>());
								GUILayout.Label("StrafeRunLeft" + befchfngomi.IGDKBMGKKDO(false, -1), guistyle, Array.Empty<GUILayoutOption>());
							}
							GUILayout.EndHorizontal();
						}
					}
					if (this.BPNNJBBCOFO.DGMNCGFAMBL == 0)
					{
						foreach (CLFFOBKFKDN.HFGDDPAKPBE hfgddpakpbe in this.BPNNJBBCOFO.HEBKGNHIDLK)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							if (hfgddpakpbe.GPJFINFIDLN == 0)
							{
								BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.NNEAHAFBOHC().LMGMPPAOPEP(hfgddpakpbe.PJPOJNNJOCD);
								if (befchfngomi2 != null)
								{
									GUILayout.Box(befchfngomi2.KEEDCOIMPMP(), GuiProcessor.BBLINJLBAIL().ico16Style, Array.Empty<GUILayoutOption>());
									GUILayout.Label(" с" + hfgddpakpbe.KFEKILDMMDE(), guistyle, Array.Empty<GUILayoutOption>());
								}
							}
							if (hfgddpakpbe.GPJFINFIDLN == 1)
							{
								IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(hfgddpakpbe.PJPOJNNJOCD);
								idchhhedhdc.KOEHAKOJCHG();
								GUILayout.Box(idchhhedhdc.KMIIGKECOEB(0).IOHNCGLFGDJ(), GuiProcessor.NKOEAPCIBKO().ico16Style, Array.Empty<GUILayoutOption>());
								GUILayout.Label("Lasso" + hfgddpakpbe.JEJCNPDEOAI(), guistyle, Array.Empty<GUILayoutOption>());
							}
							GUILayout.EndHorizontal();
						}
					}
					GUILayout.EndVertical();
				}
			}
		}
		finally
		{
			GUILayout.EndVertical();
			GUILayout.EndArea();
		}
	}

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x060041DF RID: 16863 RVA: 0x001E708C File Offset: 0x001E528C
	public Texture AOBLCKFEKJE
	{
		get
		{
			if (this.EOFDJHJPCLM == null)
			{
				return null;
			}
			return this.EOFDJHJPCLM.KEDGAOBCNJG;
		}
	}

	// Token: 0x060041E0 RID: 16864 RVA: 0x001E70A4 File Offset: 0x001E52A4
	public string POHFAHAPPLC(int AFCMJJMBOMA, bool BGNPMOCLIGL = false)
	{
		string result = "fchair";
		if (BGNPMOCLIGL)
		{
			switch (AFCMJJMBOMA)
			{
			case 0:
				result = "";
				break;
			case 1:
				result = "GiantGrabIdle";
				break;
			case 2:
				result = " is null.";
				break;
			case 3:
				result = "wpn_add/base";
				break;
			case 4:
				result = "The image effect ";
				break;
			case 5:
				result = "";
				break;
			case 6:
				result = "_EdgeThreshold";
				break;
			}
		}
		else
		{
			switch (AFCMJJMBOMA)
			{
			case 0:
				result = "***Wpn Lots event ";
				break;
			case 1:
				result = "_WorldLightDir";
				break;
			case 2:
				result = "+ ";
				break;
			case 3:
				result = "Explosions";
				break;
			case 4:
				result = "t_eye";
				break;
			case 5:
				result = "#000000";
				break;
			case 6:
				result = "_LensCoeff";
				break;
			}
		}
		return result;
	}

	// Token: 0x060041E1 RID: 16865 RVA: 0x001E717C File Offset: 0x001E537C
	public void EJOBNFNDIHM(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB, string DACPJKOFPPJ)
	{
		float num = 0f;
		if (this.EJJAGEFMHCO() != null)
		{
			Texture texture = this.EJJAGEFMHCO().KEDGAOBCNJG;
			float num2 = 0.8f * COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float num4 = (float)texture.height * num2;
			float num5 = (COAGIAMOCIA.height - num4) / 2f;
			Rect position = new Rect(COAGIAMOCIA.x + num5, COAGIAMOCIA.y + num5, num3, num4);
			GUI.DrawTexture(position, GameInterface.getI.invEmptyCell);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.KBGHOIJIPJF, 7, 2));
			GUI.DrawTexture(position, texture, ScaleMode.StretchToFill);
			if (this.BPNNJBBCOFO != null)
			{
				BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.BPNNJBBCOFO.MNFCAAIAGOL.IBEIBAHKIAH);
				if (befchfngomi != null)
				{
					befchfngomi.JIFFLPNBILE();
					float num6 = num3 * 0.85f / 2f;
					GUI.DrawTexture(new Rect(position.x + num3 / 2f - num6, position.y + num3 / 2f - num6, num6 * 2f, num6 * 2f), befchfngomi.CFFHIODOGCH);
				}
			}
			if (this.MBKMKGABBGE == 34)
			{
				float num7 = position.height / 2f;
				Rect position2 = new Rect(position.x + 2f, position.y + position.height - num7 - 2f, num7, num7);
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.MIMANMPNLPE.IBEIBAHKIAH);
				if (kdhoddmndfc != null)
				{
					GUI.DrawTexture(position2, kdhoddmndfc.KMIIGKECOEB(), ScaleMode.StretchToFill);
				}
			}
			if (this.KBGHOIJIPJF > 1)
			{
				GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.KBGHOIJIPJF + 7, 7, 2));
			}
			num = num + num3 + 5f;
		}
		int gclkleimaba = this.GCLKLEIMABA;
		int fontSize = OFPNEDEAMAB.fontSize;
		OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
		OFPNEDEAMAB.fontSize = 14;
		string text = this.JPBOPFNPNHC(false, -1) + DACPJKOFPPJ;
		if (this.MBKMKGABBGE == 31)
		{
			string hajnmnalbbi = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(0).HAJNMNALBBI;
			text = text.Replace("{0}", hajnmnalbbi);
		}
		GUI.Label(new Rect(COAGIAMOCIA.x + 8f + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 15f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		OFPNEDEAMAB.fontSize = fontSize;
	}

	// Token: 0x060041E2 RID: 16866 RVA: 0x001E7414 File Offset: 0x001E5614
	public Vector2 ABOPMDHEFLL()
	{
		Vector2 zero = Vector2.zero;
		zero.x = this.MIMANMPNLPE.JLLJFKOGLHJ * this.MIMANMPNLPE.DOFNAOOCDDB();
		if (this.MIMANMPNLPE.JLLJFKOGLHJ <= 1469f)
		{
			zero.x = 137f;
		}
		zero.y = this.MIMANMPNLPE.EIHMJDCOOCC() * 21f;
		return zero;
	}

	// Token: 0x060041E3 RID: 16867 RVA: 0x001E747C File Offset: 0x001E567C
	public string EMLKBOOFNGA(int AFCMJJMBOMA, bool BGNPMOCLIGL = false)
	{
		string result = "Приватный";
		if (BGNPMOCLIGL)
		{
			switch (AFCMJJMBOMA)
			{
			case 0:
				result = "Transform is null.";
				break;
			case 1:
				result = "crft_from";
				break;
			case 2:
				result = "\n";
				break;
			case 3:
				result = "post_15";
				break;
			case 4:
				result = "<color='#002030'>+{0} {1}</color>";
				break;
			case 5:
				result = "IdleSpew";
				break;
			case 6:
				result = "error.wav";
				break;
			}
		}
		else
		{
			switch (AFCMJJMBOMA)
			{
			case 0:
				result = "http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}";
				break;
			case 1:
				result = "?";
				break;
			case 2:
				result = " ";
				break;
			case 3:
				result = "FOG_LINEAR";
				break;
			case 4:
				result = "TOD_SpaceTiling";
				break;
			case 5:
				result = "WallSit";
				break;
			case 6:
				result = "There is already a virtual axis named ";
				break;
			}
		}
		return result;
	}

	// Token: 0x060041E4 RID: 16868 RVA: 0x001E7554 File Offset: 0x001E5754
	public void BKMLPPJMDFP(Rect OCHCODJIPHJ, float KKPHBHADLND = 1f)
	{
		if (this.CFFHIODOGCH == null)
		{
			this.JIFFLPNBILE();
			return;
		}
		Color white = Color.white;
		white.a = KKPHBHADLND;
		GUI.color = white;
		GUI.DrawTextureWithTexCoords(OCHCODJIPHJ, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(this.KBGHOIJIPJF, 6, 0));
		GUI.DrawTexture(OCHCODJIPHJ, this.KEEDCOIMPMP());
		if (this.BPNNJBBCOFO != null)
		{
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.BPNNJBBCOFO.MNFCAAIAGOL.KEHIFGILLJA());
			if (befchfngomi != null)
			{
				befchfngomi.KEICEAJOGFD();
				float num = OCHCODJIPHJ.width * 844f / 1559f;
				GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width / 1751f - num, OCHCODJIPHJ.y + OCHCODJIPHJ.width / 1692f - num, num * 1447f, num * 181f), befchfngomi.KEEDCOIMPMP());
			}
		}
		if (this.MBKMKGABBGE == 90)
		{
			float num2 = OCHCODJIPHJ.height / 665f;
			Rect position = new Rect(OCHCODJIPHJ.x + 1364f, OCHCODJIPHJ.y + OCHCODJIPHJ.height - num2 - 866f, num2, num2);
			NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.MIMANMPNLPE.NKEOCCKEOCE());
			if (kdhoddmndfc != null)
			{
				GUI.DrawTexture(position, kdhoddmndfc.FHPNJBAEAON(), ScaleMode.StretchToFill);
			}
		}
		if (this.KBGHOIJIPJF > 1)
		{
			GUI.DrawTextureWithTexCoords(OCHCODJIPHJ, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(this.KBGHOIJIPJF + 1, 8, 7));
		}
		GUI.color = Color.white;
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x060041E5 RID: 16869 RVA: 0x001E76ED File Offset: 0x001E58ED
	public int MNKBNODBHEL
	{
		get
		{
			return this.BBLEPPMMPIL("wpn_add/base", "color").DIKKDGKIPEA;
		}
	}

	// Token: 0x060041E6 RID: 16870 RVA: 0x001E7704 File Offset: 0x001E5904
	public string KDKILDJEELH(int GNICCGDPPJP = 0)
	{
		if (this.LPFKFNLHGBI != 26)
		{
			return this.BNIHFBMEPAB;
		}
		if (GNICCGDPPJP == 0)
		{
			return this.BNIHFBMEPAB.Replace("", "gi_um_nosel");
		}
		return string.Format(this.BNIHFBMEPAB, AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(GNICCGDPPJP).DPPBLBIJFBC(1));
	}

	// Token: 0x060041E7 RID: 16871 RVA: 0x001E775C File Offset: 0x001E595C
	public BNOOIOKIFJC.DIGGOHPGCNN NGOAOMNBIGI(string JKLOOEDHHJP, string KEIEIAAKHHK)
	{
		BEFCHFNGOMI.KFNOPLFPHJC kfnoplfphjc = new BEFCHFNGOMI.KFNOPLFPHJC();
		kfnoplfphjc.KEIEIAAKHHK = KEIEIAAKHHK;
		XmlNode xmlNode = this.LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = kfnoplfphjc.LJOEIPHIJOE) == null)
			{
				predicate = (kfnoplfphjc.LJOEIPHIJOE = new Func<XmlNode, bool>(kfnoplfphjc.NFOGBKOKPPD));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("MAP_NAMES" + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN("Windows");
	}

	// Token: 0x060041E8 RID: 16872 RVA: 0x001E7810 File Offset: 0x001E5A10
	public Vector2 FBOLDPBDMCD()
	{
		Vector2 zero = Vector2.zero;
		zero.x = this.MIMANMPNLPE.EIHMJDCOOCC() * this.MIMANMPNLPE.DOFNAOOCDDB();
		if (this.MIMANMPNLPE.EIHMJDCOOCC() <= 910f)
		{
			zero.x = 108f;
		}
		zero.y = this.MIMANMPNLPE.EIHMJDCOOCC() * 1708f;
		return zero;
	}

	// Token: 0x060041E9 RID: 16873 RVA: 0x001E7878 File Offset: 0x001E5A78
	public void JCIIPCEDICP(Rect OCHCODJIPHJ, float KKPHBHADLND = 1f)
	{
		if (this.CFFHIODOGCH == null)
		{
			this.JIFFLPNBILE();
			return;
		}
		Color white = Color.white;
		white.a = KKPHBHADLND;
		GUI.color = white;
		GUI.DrawTextureWithTexCoords(OCHCODJIPHJ, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.KBGHOIJIPJF, 7, 2));
		GUI.DrawTexture(OCHCODJIPHJ, this.CFFHIODOGCH);
		if (this.BPNNJBBCOFO != null)
		{
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.BPNNJBBCOFO.MNFCAAIAGOL.IBEIBAHKIAH);
			if (befchfngomi != null)
			{
				befchfngomi.JIFFLPNBILE();
				float num = OCHCODJIPHJ.width * 0.85f / 2f;
				GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width / 2f - num, OCHCODJIPHJ.y + OCHCODJIPHJ.width / 2f - num, num * 2f, num * 2f), befchfngomi.CFFHIODOGCH);
			}
		}
		if (this.MBKMKGABBGE == 34)
		{
			float num2 = OCHCODJIPHJ.height / 2f;
			Rect position = new Rect(OCHCODJIPHJ.x + 2f, OCHCODJIPHJ.y + OCHCODJIPHJ.height - num2 - 2f, num2, num2);
			NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.MIMANMPNLPE.IBEIBAHKIAH);
			if (kdhoddmndfc != null)
			{
				GUI.DrawTexture(position, kdhoddmndfc.KMIIGKECOEB(), ScaleMode.StretchToFill);
			}
		}
		if (this.KBGHOIJIPJF > 1)
		{
			GUI.DrawTextureWithTexCoords(OCHCODJIPHJ, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.KBGHOIJIPJF + 7, 7, 2));
		}
		GUI.color = Color.white;
	}

	// Token: 0x060041EA RID: 16874 RVA: 0x001E7A14 File Offset: 0x001E5C14
	public string EKKPKEOOPJH(int AFCMJJMBOMA, bool BGNPMOCLIGL = false)
	{
		string result = "http://www.root-motion.com/finalikdox/html/page11.html";
		if (BGNPMOCLIGL)
		{
			switch (AFCMJJMBOMA)
			{
			case 0:
				result = " ";
				break;
			case 1:
				result = "Idle Die 2";
				break;
			case 2:
				result = "_AdditiveReflection";
				break;
			case 3:
				result = "[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.";
				break;
			case 4:
				result = "TOD_AmbientColor";
				break;
			case 5:
				result = "[AmplifyColor] Failed to initialize shaders. Please attempt to re-enable the Amplify Color Effect component. If that fails, please reinstall Amplify Color.";
				break;
			case 6:
				result = "Add random value";
				break;
			}
		}
		else
		{
			switch (AFCMJJMBOMA)
			{
			case 0:
				result = "Only Hinge Rotation Limits should be used on 2D IK solvers.";
				break;
			case 1:
				result = "_Offset";
				break;
			case 2:
				result = "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_c_c_d_i_k.html";
				break;
			case 3:
				result = "IdleStun";
				break;
			case 4:
				result = "hgtDst=";
				break;
			case 5:
				result = "wpn_add/base";
				break;
			case 6:
				result = "buyVIP OK";
				break;
			}
		}
		return result;
	}

	// Token: 0x060041EB RID: 16875 RVA: 0x001E7AEA File Offset: 0x001E5CEA
	public void JCIIPCEDICP(Vector2 NBADAMPJBBH)
	{
		this.JCIIPCEDICP(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, 56f, 56f), 1f);
	}

	// Token: 0x060041EC RID: 16876 RVA: 0x001E7B14 File Offset: 0x001E5D14
	public void JGGGGKHDNIP(Rect PHEMLBHMNCM, float NMBCJPACKNL, IIBEEKCAAHK INEBGELANOI, IIBEEKCAAHK CKGEBHECNBF, IIBEEKCAAHK ABJAMKHMONL, int ILFHHDNJHNM = 0)
	{
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 14,
			wordWrap = true,
			font = GuiProcessor.IKGFHGKKCPG.rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = true,
			alignment = TextAnchor.MiddleLeft
		};
		Rect ochcodjiphj = new Rect(PHEMLBHMNCM.x + 10f, PHEMLBHMNCM.y + 10f, 56f, 56f);
		this.FCBHHPJLGLC(ochcodjiphj, this.KBGHOIJIPJF, true, 0);
		GUILayout.BeginArea(new Rect(ochcodjiphj.x + 65f, ochcodjiphj.y, PHEMLBHMNCM.width - 75f, 70f));
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		try
		{
			guistyle.fontSize = 14;
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			GUILayout.Label(this.BNIHFBMEPAB, guistyle, Array.Empty<GUILayoutOption>());
			guistyle.fontSize = 10;
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
			GUILayout.Label("", guistyle, Array.Empty<GUILayoutOption>());
			GUILayout.Label(IHFEDJEMJMB.IKGFHGKKCPG.JGLANEDNNAB(this.MBKMKGABBGE) ?? "", guistyle, Array.Empty<GUILayoutOption>());
			guistyle.fontSize = 12;
			if (ILFHHDNJHNM == 0)
			{
				int hoalbmdjndm = this.HOALBMDJNDM;
			}
		}
		finally
		{
			GUILayout.EndVertical();
			GUILayout.EndArea();
		}
		GUILayout.BeginArea(new Rect(ochcodjiphj.x + 10f, ochcodjiphj.y + 65f, PHEMLBHMNCM.width - 30f, PHEMLBHMNCM.height - 70f));
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		try
		{
			int negehagngbh = this.NEGEHAGNGBH;
			float nkhbajkmagd = this.NKHBAJKMAGD;
			this.NEGEHAGNGBH += (int)((float)(INEBGELANOI.LKAGIEBPLAI + CKGEBHECNBF.LKAGIEBPLAI + ABJAMKHMONL.LKAGIEBPLAI) * NMBCJPACKNL);
			this.NKHBAJKMAGD += (float)(INEBGELANOI.LKAGIEBPLAI + CKGEBHECNBF.LKAGIEBPLAI + ABJAMKHMONL.LKAGIEBPLAI) * 0.1f * this.NKHBAJKMAGD;
			IIBEEKCAAHK mimanmpnlpe = new IIBEEKCAAHK(this.MIMANMPNLPE.LNEPKLKELMI, this.MIMANMPNLPE.NMKCBJKHBOH, this.MIMANMPNLPE.NKGGAFLBFDF);
			this.MIMANMPNLPE.LNEPKLKELMI += INEBGELANOI.NKGGAFLBFDF * (double)INEBGELANOI.LKAGIEBPLAI;
			this.MIMANMPNLPE.NMKCBJKHBOH += CKGEBHECNBF.NKGGAFLBFDF * (double)CKGEBHECNBF.LKAGIEBPLAI;
			this.MIMANMPNLPE.NKGGAFLBFDF += ABJAMKHMONL.NKGGAFLBFDF * (double)ABJAMKHMONL.LKAGIEBPLAI;
			GUILayout.Label(this.MEKPGCCFEOO(true), guistyle, Array.Empty<GUILayoutOption>());
			if (this.MHNDPGDBPNA.Count > 0)
			{
				GUILayout.Label("______________________________", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("", guistyle, Array.Empty<GUILayoutOption>());
				foreach (IIBEEKCAAHK iibeekcaahk in this.MHNDPGDBPNA)
				{
					string text = iibeekcaahk.ToString();
					if (iibeekcaahk.IBEIBAHKIAH == 1)
					{
						string arg = AKPJIACDDFI.IKGFHGKKCPG.PKAJMDDDMMI(iibeekcaahk.ICJDPPOJINN, false);
						if (iibeekcaahk.NODLBGKEGPM > 0)
						{
							text = string.Format("<color='#003000'>+{0} {1}</color>", iibeekcaahk.NODLBGKEGPM, arg);
						}
						else
						{
							text = string.Format("<color='#300000'>{0} {1}</color>", iibeekcaahk.NODLBGKEGPM, arg);
						}
					}
					if (iibeekcaahk.IBEIBAHKIAH == 2)
					{
						string arg2 = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(iibeekcaahk.ICJDPPOJINN);
						if (iibeekcaahk.NODLBGKEGPM > 0)
						{
							text = string.Format("<color='#001000'>+{0} {1}</color>", iibeekcaahk.NODLBGKEGPM, arg2);
						}
						else
						{
							text = string.Format("<color='#100000'>{0} {1}</color>", iibeekcaahk.NODLBGKEGPM, arg2);
						}
					}
					GUILayout.Label(text, guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.Label("", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("", guistyle, Array.Empty<GUILayoutOption>());
			}
			if (this.NEGEHAGNGBH > 1 || this.PKIICJOILKI.Count > 0)
			{
				GUILayout.Label(JNBICAJIJMM.LEBHCLDODNI("inv_minreq"), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("______________________________", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("", guistyle, Array.Empty<GUILayoutOption>());
				if (this.NEGEHAGNGBH > 1)
				{
					string arg3 = "002000";
					if (this.NEGEHAGNGBH > ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CNOLCNDBLJE))
					{
						arg3 = "800000";
					}
					GUILayout.Label(string.Format(JNBICAJIJMM.LEBHCLDODNI("min_lev"), arg3, this.NEGEHAGNGBH), guistyle, Array.Empty<GUILayoutOption>());
					GUILayout.Label("", guistyle, Array.Empty<GUILayoutOption>());
				}
				if (this.PKIICJOILKI.Count > 0)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.PKIICJOILKI)
					{
						bool flag = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI) >= dlmglijdiai.CNOLCNDBLJE;
						string arg4 = "ff2000";
						if (flag)
						{
							arg4 = "80ff00";
						}
						string text2 = string.Format("\n<color='#{0}'>{1}</color> ", arg4, dlmglijdiai.BDHHPAEHFHG.KGBHELBLPMF(dlmglijdiai.CNOLCNDBLJE));
						if (!flag)
						{
							GUI.color = new Color(1f, 0.5f, 0.5f);
						}
						GUILayout.Box(dlmglijdiai.BDHHPAEHFHG.KMIIGKECOEB(), GuiProcessor.IKGFHGKKCPG.ico24Style, Array.Empty<GUILayoutOption>());
						GUI.color = Color.white;
						GUILayout.Label(text2, guistyle, Array.Empty<GUILayoutOption>());
					}
					GUILayout.EndHorizontal();
				}
				GUILayout.Label("______________________________", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("", guistyle, Array.Empty<GUILayoutOption>());
			}
			this.MIMANMPNLPE = mimanmpnlpe;
			this.NEGEHAGNGBH = negehagngbh;
			this.NKHBAJKMAGD = nkhbajkmagd;
			if (this.FGJIJFNGAIF.Count > 0)
			{
				GUILayout.Label(JNBICAJIJMM.LEBHCLDODNI("inv_bonus"), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("______________________________", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
				foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai2 in this.FGJIJFNGAIF)
				{
					bool flag2 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai2.LPFKFNLHGBI) > 0;
					string arg5 = "404040";
					if (flag2)
					{
						arg5 = "206000";
					}
					string text3 = string.Format("\n<color='#{0}'>+{2} '{1}'</color> ", arg5, dlmglijdiai2.BDHHPAEHFHG.KKEBDLGHBMN, dlmglijdiai2.CNOLCNDBLJE);
					if (!flag2)
					{
						GUI.color = Color.gray;
					}
					GUILayout.Box(dlmglijdiai2.BDHHPAEHFHG.KMIIGKECOEB(), GuiProcessor.IKGFHGKKCPG.ico24Style, Array.Empty<GUILayoutOption>());
					GUI.color = Color.white;
					GUILayout.Label(text3, guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.EndHorizontal();
				GUILayout.Label("", guistyle, Array.Empty<GUILayoutOption>());
			}
			XmlNodeList xmlNodeList = this.LMKLPODNLFC.SelectNodes("wpn_add/use_effect/effect");
			if (xmlNodeList != null && xmlNodeList.Count > 0)
			{
				guistyle.alignment = TextAnchor.MiddleLeft;
				GUILayout.Label(JNBICAJIJMM.LEBHCLDODNI("inv_useeff"), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("______________________________", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
				foreach (object obj in xmlNodeList)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.Name == "effect")
					{
						if (xmlNode.Attributes == null)
						{
							continue;
						}
						int lpfkfnlhgbi = int.Parse(xmlNode.Attributes["id"].Value);
						IIBEEKCAAHK pgedldmlbbe = new IIBEEKCAAHK(xmlNode.Attributes["value"].Value);
						int cgnljcomfac = int.Parse(xmlNode.Attributes["time"].Value);
						FlyMessageManager.NGIAAOHFNPO flyIconTemplate = FlyMessageManager.getI.getFlyIconTemplate(lpfkfnlhgbi);
						if (flyIconTemplate != null)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							GUILayout.Box(flyIconTemplate.CFFHIODOGCH.KEDGAOBCNJG, GuiProcessor.IKGFHGKKCPG.ico24Style, Array.Empty<GUILayoutOption>());
							GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
							GUILayout.Label(string.Format("<color='#003000'>{0} на {1}</color>", flyIconTemplate.BEFIAPHPIBJ(pgedldmlbbe), JLFJEGIPIMM.IKGFHGKKCPG.CBBDFCOMGLP(cgnljcomfac)), GuiProcessor.IKGFHGKKCPG.textLayoutStyle, Array.Empty<GUILayoutOption>());
							GUILayout.Label(flyIconTemplate.FPEBEBGMGGH(pgedldmlbbe), GuiProcessor.IKGFHGKKCPG.textLayoutStyle, Array.Empty<GUILayoutOption>());
							GUILayout.EndVertical();
							GUILayout.EndHorizontal();
						}
					}
					GUILayout.Label("  ", guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.EndVertical();
			}
			GUILayout.Label("<color='#001020'><i>" + this.JCKHDHGIEEB + "</i></color>", guistyle, Array.Empty<GUILayoutOption>());
			if (this.MBKMKGABBGE == 28)
			{
				CLFFOBKFKDN.OKOAMCJGNMH okoamcjgnmh = CLFFOBKFKDN.IKGFHGKKCPG.HEILDJICDAB(this.MIMANMPNLPE.ICJDPPOJINN);
				if (IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(okoamcjgnmh.MNFCAAIAGOL.IBEIBAHKIAH) != null && this.BPNNJBBCOFO != null)
				{
					GUILayout.Label("______________________________", Array.Empty<GUILayoutOption>());
					GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
					if (this.BPNNJBBCOFO.DGMNCGFAMBL == 1)
					{
						foreach (IIBEEKCAAHK iibeekcaahk2 in this.BPNNJBBCOFO.AGDBFHLEFEE)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(iibeekcaahk2.IBEIBAHKIAH);
							if (befchfngomi != null)
							{
								GUILayout.Box(befchfngomi.CFFHIODOGCH, GuiProcessor.IKGFHGKKCPG.ico16Style, Array.Empty<GUILayoutOption>());
								GUILayout.Label(" ♦ " + befchfngomi.JPBOPFNPNHC(false, -1), guistyle, Array.Empty<GUILayoutOption>());
							}
							GUILayout.EndHorizontal();
						}
					}
					if (this.BPNNJBBCOFO.DGMNCGFAMBL == 0)
					{
						foreach (CLFFOBKFKDN.HFGDDPAKPBE hfgddpakpbe in this.BPNNJBBCOFO.HEBKGNHIDLK)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							if (hfgddpakpbe.GPJFINFIDLN == 0)
							{
								BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(hfgddpakpbe.PJPOJNNJOCD);
								if (befchfngomi2 != null)
								{
									GUILayout.Box(befchfngomi2.CFFHIODOGCH, GuiProcessor.IKGFHGKKCPG.ico16Style, Array.Empty<GUILayoutOption>());
									GUILayout.Label(" ♦ " + hfgddpakpbe.IEIMMFODGFG(), guistyle, Array.Empty<GUILayoutOption>());
								}
							}
							if (hfgddpakpbe.GPJFINFIDLN == 1)
							{
								IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(hfgddpakpbe.PJPOJNNJOCD);
								idchhhedhdc.HBGEAMHFEOL();
								GUILayout.Box(idchhhedhdc.KMIIGKECOEB(0).KEDGAOBCNJG, GuiProcessor.IKGFHGKKCPG.ico16Style, Array.Empty<GUILayoutOption>());
								GUILayout.Label(" ♦ " + hfgddpakpbe.IEIMMFODGFG(), guistyle, Array.Empty<GUILayoutOption>());
							}
							GUILayout.EndHorizontal();
						}
					}
					GUILayout.EndVertical();
				}
			}
		}
		finally
		{
			GUILayout.EndVertical();
			GUILayout.EndArea();
		}
	}

	// Token: 0x060041ED RID: 16877 RVA: 0x001E8708 File Offset: 0x001E6908
	public void HIHEPHAAJFH(Rect PHEMLBHMNCM, float NMBCJPACKNL, IIBEEKCAAHK INEBGELANOI, IIBEEKCAAHK CKGEBHECNBF, IIBEEKCAAHK ABJAMKHMONL, int ILFHHDNJHNM = 0)
	{
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -12,
			wordWrap = false,
			font = GuiProcessor.PLGADNLAEGN().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = false,
			alignment = TextAnchor.UpperLeft
		};
		Rect ochcodjiphj = new Rect(PHEMLBHMNCM.x + 1295f, PHEMLBHMNCM.y + 1556f, 1569f, 999f);
		this.FCBHHPJLGLC(ochcodjiphj, this.KBGHOIJIPJF, false, 1);
		GUILayout.BeginArea(new Rect(ochcodjiphj.x + 1527f, ochcodjiphj.y, PHEMLBHMNCM.width - 802f, 1493f));
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		try
		{
			guistyle.fontSize = 88;
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			GUILayout.Label(this.BNIHFBMEPAB, guistyle, Array.Empty<GUILayoutOption>());
			guistyle.fontSize = -6;
			guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
			GUILayout.Label("▮▮▯", guistyle, Array.Empty<GUILayoutOption>());
			GUILayout.Label(IHFEDJEMJMB.OELKEADDKPE().CAGCDEPAICB(this.MBKMKGABBGE) ?? "RollerBladeJump", guistyle, Array.Empty<GUILayoutOption>());
			guistyle.fontSize = 4;
			if (ILFHHDNJHNM == 0)
			{
				int hoalbmdjndm = this.HOALBMDJNDM;
			}
		}
		finally
		{
			GUILayout.EndVertical();
			GUILayout.EndArea();
		}
		GUILayout.BeginArea(new Rect(ochcodjiphj.x + 569f, ochcodjiphj.y + 987f, PHEMLBHMNCM.width - 487f, PHEMLBHMNCM.height - 390f));
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		try
		{
			int negehagngbh = this.NEGEHAGNGBH;
			float nkhbajkmagd = this.NKHBAJKMAGD;
			this.NEGEHAGNGBH += (int)((float)(INEBGELANOI.KMNOIAIBLEB() + CKGEBHECNBF.ACEPOCLANAG() + ABJAMKHMONL.KIDKOFKNPEP()) * NMBCJPACKNL);
			this.NKHBAJKMAGD += (float)(INEBGELANOI.PBMJIMLEHEC() + CKGEBHECNBF.ACEPOCLANAG() + ABJAMKHMONL.LKAGIEBPLAI) * 27f * this.NKHBAJKMAGD;
			IIBEEKCAAHK mimanmpnlpe = new IIBEEKCAAHK(this.MIMANMPNLPE.LNEPKLKELMI, this.MIMANMPNLPE.NMKCBJKHBOH, this.MIMANMPNLPE.HDPNCIECLKP());
			IIBEEKCAAHK mimanmpnlpe2 = this.MIMANMPNLPE;
			mimanmpnlpe2.JLPFNMDEOGO(mimanmpnlpe2.DHJBAKDAMGH() + INEBGELANOI.FJACMDGJEBL() * (double)INEBGELANOI.KIDKOFKNPEP());
			IIBEEKCAAHK mimanmpnlpe3 = this.MIMANMPNLPE;
			mimanmpnlpe3.NMKCBJKHBOH = mimanmpnlpe3.OIGIHEPJFFJ() + CKGEBHECNBF.DBFOHFDOCIB() * (double)CKGEBHECNBF.LKAGIEBPLAI;
			IIBEEKCAAHK mimanmpnlpe4 = this.MIMANMPNLPE;
			mimanmpnlpe4.MDJBNNGJAGH(mimanmpnlpe4.KCKFCPIHMPC() + ABJAMKHMONL.HDPNCIECLKP() * (double)ABJAMKHMONL.LKAGIEBPLAI);
			GUILayout.Label(this.MEKPGCCFEOO(true), guistyle, Array.Empty<GUILayoutOption>());
			if (this.MHNDPGDBPNA.Count > 0)
			{
				GUILayout.Label("Actor_", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("_BlurredColor", guistyle, Array.Empty<GUILayoutOption>());
				foreach (IIBEEKCAAHK iibeekcaahk in this.MHNDPGDBPNA)
				{
					string text = iibeekcaahk.ToString();
					if (iibeekcaahk.NKEOCCKEOCE() == 0)
					{
						string arg = AKPJIACDDFI.IKGFHGKKCPG.PKAJMDDDMMI(iibeekcaahk.ICJDPPOJINN, true);
						if (iibeekcaahk.NODLBGKEGPM > 1)
						{
							text = string.Format("WorkerHammer", iibeekcaahk.CJKILDPJCFJ(), arg);
						}
						else
						{
							text = string.Format("Run Back Left", iibeekcaahk.NODLBGKEGPM, arg);
						}
					}
					if (iibeekcaahk.IBEIBAHKIAH == 4)
					{
						string arg2 = AKPJIACDDFI.IKGFHGKKCPG.PCONBNOAMBH(iibeekcaahk.NLHKFMMDMMK());
						if (iibeekcaahk.NODLBGKEGPM > 0)
						{
							text = string.Format("Wall Sit", iibeekcaahk.NFCDJLJNDLO(), arg2);
						}
						else
						{
							text = string.Format("Try to change this int in memory:\n", iibeekcaahk.NODLBGKEGPM, arg2);
						}
					}
					GUILayout.Label(text, guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.Label("Ошибка!", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("_ColorBuffer", guistyle, Array.Empty<GUILayoutOption>());
			}
			if (this.NEGEHAGNGBH > 0 || this.PKIICJOILKI.Count > 0)
			{
				GUILayout.Label(JNBICAJIJMM.CDDCIKKDFMP("{not_found}"), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("IceHockeyShotRight", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("_BgFade", guistyle, Array.Empty<GUILayoutOption>());
				if (this.NEGEHAGNGBH > 0)
				{
					string arg3 = "Current fog preset: ";
					if (this.NEGEHAGNGBH > ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.CNOLCNDBLJE))
					{
						arg3 = "Yawn";
					}
					GUILayout.Label(string.Format(JNBICAJIJMM.CELEPPAEKAB("7,13,9,8"), arg3, this.NEGEHAGNGBH), guistyle, Array.Empty<GUILayoutOption>());
					GUILayout.Label("/", guistyle, Array.Empty<GUILayoutOption>());
				}
				if (this.PKIICJOILKI.Count > 0)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.PKIICJOILKI)
					{
						bool flag = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI) >= dlmglijdiai.CNOLCNDBLJE;
						string arg4 = "WalkDehydrated";
						if (flag)
						{
							arg4 = "byte[]: {";
						}
						string text2 = string.Format("hips", arg4, dlmglijdiai.BDHHPAEHFHG.PNLGIAIKAOL(dlmglijdiai.CNOLCNDBLJE));
						if (!flag)
						{
							GUI.color = new Color(10f, 1990f, 521f);
						}
						GUILayout.Box(dlmglijdiai.BDHHPAEHFHG.IJGBOMGCLDK(), GuiProcessor.PLGADNLAEGN().ico24Style, Array.Empty<GUILayoutOption>());
						GUI.color = Color.white;
						GUILayout.Label(text2, guistyle, Array.Empty<GUILayoutOption>());
					}
					GUILayout.EndHorizontal();
				}
				GUILayout.Label("costume_", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("_FogAreaPosition", guistyle, Array.Empty<GUILayoutOption>());
			}
			this.MIMANMPNLPE = mimanmpnlpe;
			this.NEGEHAGNGBH = negehagngbh;
			this.NKHBAJKMAGD = nkhbajkmagd;
			if (this.FGJIJFNGAIF.Count > 1)
			{
				GUILayout.Label(JNBICAJIJMM.DCEBAJIILPC("Actor"), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("__a", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("no_repa", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
				foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai2 in this.FGJIJFNGAIF)
				{
					bool flag2 = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai2.LPFKFNLHGBI) > 1;
					string arg5 = "knopje.wav";
					if (flag2)
					{
						arg5 = "Наживка";
					}
					string text3 = string.Format("qd_prise", arg5, dlmglijdiai2.BDHHPAEHFHG.KKEBDLGHBMN, dlmglijdiai2.CNOLCNDBLJE);
					if (!flag2)
					{
						GUI.color = Color.gray;
					}
					GUILayout.Box(dlmglijdiai2.BDHHPAEHFHG.GNMLEPEGCII(), GuiProcessor.BBLINJLBAIL().ico24Style, Array.Empty<GUILayoutOption>());
					GUI.color = Color.white;
					GUILayout.Label(text3, guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.EndHorizontal();
				GUILayout.Label("Resume Interaction With ", guistyle, Array.Empty<GUILayoutOption>());
			}
			XmlNodeList xmlNodeList = this.LMKLPODNLFC.SelectNodes("IdleReady");
			if (xmlNodeList != null && xmlNodeList.Count > 1)
			{
				guistyle.alignment = TextAnchor.MiddleCenter;
				GUILayout.Label(JNBICAJIJMM.LEBHCLDODNI("Android"), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
				foreach (object obj in xmlNodeList)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.Name == "")
					{
						if (xmlNode.Attributes == null)
						{
							continue;
						}
						int lpfkfnlhgbi = int.Parse(xmlNode.Attributes["Can't use reflection here, sorry :("].Value);
						IIBEEKCAAHK pgedldmlbbe = new IIBEEKCAAHK(xmlNode.Attributes[""].Value);
						int cgnljcomfac = int.Parse(xmlNode.Attributes["OfficeSittingLegCross"].Value);
						FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = FlyMessageManager.getI.BHCGBKKPCFL(lpfkfnlhgbi);
						if (ngiaaohfnpo != null)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							GUILayout.Box(ngiaaohfnpo.CFFHIODOGCH.IOHNCGLFGDJ(), GuiProcessor.PLGADNLAEGN().ico24Style, Array.Empty<GUILayoutOption>());
							GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
							GUILayout.Label(string.Format("", ngiaaohfnpo.HHCCCIHAOJG(pgedldmlbbe), JLFJEGIPIMM.NNEAHAFBOHC().HNGGHOHGEHC(cgnljcomfac)), GuiProcessor.BBLINJLBAIL().textLayoutStyle, Array.Empty<GUILayoutOption>());
							GUILayout.Label(ngiaaohfnpo.DCHDLEBDBOK(pgedldmlbbe), GuiProcessor.IKGFHGKKCPG.textLayoutStyle, Array.Empty<GUILayoutOption>());
							GUILayout.EndVertical();
							GUILayout.EndHorizontal();
						}
					}
					GUILayout.Label("shop_ycnt", guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.EndVertical();
			}
			GUILayout.Label("https://groups.google.com/forum/#!forum/final-ik" + this.JCKHDHGIEEB + "_WrinkleNormalMap0", guistyle, Array.Empty<GUILayoutOption>());
			if (this.MBKMKGABBGE == 47)
			{
				CLFFOBKFKDN.OKOAMCJGNMH okoamcjgnmh = CLFFOBKFKDN.GAPIOPHMBNB().EEPOJACNJIA(this.MIMANMPNLPE.KMGAHCANELI());
				if (IHFEDJEMJMB.AGCBLDIBMNB().GBKMHIGNKJA(okoamcjgnmh.MNFCAAIAGOL.NKEOCCKEOCE()) != null && this.BPNNJBBCOFO != null)
				{
					GUILayout.Label("_ALPHATEST_ON", Array.Empty<GUILayoutOption>());
					GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
					if (this.BPNNJBBCOFO.DGMNCGFAMBL == 1)
					{
						foreach (IIBEEKCAAHK iibeekcaahk2 in this.BPNNJBBCOFO.AGDBFHLEFEE)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(iibeekcaahk2.KEHIFGILLJA());
							if (befchfngomi != null)
							{
								GUILayout.Box(befchfngomi.CFFHIODOGCH, GuiProcessor.PLGADNLAEGN().ico16Style, Array.Empty<GUILayoutOption>());
								GUILayout.Label("ACHIEVEMENT_1_1" + befchfngomi.CGMGBGABLFB(true, -1), guistyle, Array.Empty<GUILayoutOption>());
							}
							GUILayout.EndHorizontal();
						}
					}
					if (this.BPNNJBBCOFO.DGMNCGFAMBL == 0)
					{
						foreach (CLFFOBKFKDN.HFGDDPAKPBE hfgddpakpbe in this.BPNNJBBCOFO.HEBKGNHIDLK)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							if (hfgddpakpbe.GPJFINFIDLN == 0)
							{
								BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.EDKKJNHDBPF().GBKMHIGNKJA(hfgddpakpbe.PJPOJNNJOCD);
								if (befchfngomi2 != null)
								{
									GUILayout.Box(befchfngomi2.KEEDCOIMPMP(), GuiProcessor.NKOEAPCIBKO().ico16Style, Array.Empty<GUILayoutOption>());
									GUILayout.Label("360SpinDeath" + hfgddpakpbe.HODPAHNILHK(), guistyle, Array.Empty<GUILayoutOption>());
								}
							}
							if (hfgddpakpbe.GPJFINFIDLN == 0)
							{
								IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(hfgddpakpbe.PJPOJNNJOCD);
								idchhhedhdc.JDJOBDGKBNL();
								GUILayout.Box(idchhhedhdc.FGLONDNIKKC(1).MLPBJEFJDHM(), GuiProcessor.PLGADNLAEGN().ico16Style, Array.Empty<GUILayoutOption>());
								GUILayout.Label("\n" + hfgddpakpbe.JNOOHOFKOOJ(), guistyle, Array.Empty<GUILayoutOption>());
							}
							GUILayout.EndHorizontal();
						}
					}
					GUILayout.EndVertical();
				}
			}
		}
		finally
		{
			GUILayout.EndVertical();
			GUILayout.EndArea();
		}
	}

	// Token: 0x060041EE RID: 16878 RVA: 0x001E92FC File Offset: 0x001E74FC
	public virtual int JLDFEHFAKBM(ItemBase MBKPMBPLIJN)
	{
		int result = 0;
		BEFCHFNGOMI befchfngomi = (BEFCHFNGOMI)MBKPMBPLIJN;
		if (this.PCFNDIFLIHC() < befchfngomi.PCFNDIFLIHC())
		{
			result = -1;
		}
		if (this.PCFNDIFLIHC() > befchfngomi.PCFNDIFLIHC())
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x060041EF RID: 16879 RVA: 0x001E9334 File Offset: 0x001E7534
	public virtual string DDLFNJEJPBP()
	{
		string text = "";
		if (!this.FKEDAOOHPPB.LMIDHPINCKN(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH, 0))
		{
			text = "[ACTk] Injection Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!";
		}
		string text2 = "byte[]: {";
		if (this.HOALBMDJNDM > 1)
		{
			text2 = "WorkerShovel2" + this.HOALBMDJNDM + "-none-";
		}
		if (this.GCLKLEIMABA > 1)
		{
			"Worker Shovel 2" + JLFJEGIPIMM.IKGFHGKKCPG.IEICGMEMPIK(this.GCLKLEIMABA) + "1024";
		}
		string[] array = new string[7];
		array[0] = this.IGDKBMGKKDO(false, -1);
		array[0] = text2;
		array[5] = "VolumetricFogAndMist/CopyDepth";
		array[1] = this.DPIHMPDHKBP(false);
		array[7] = "IdleStrafeLeft";
		array[1] = text;
		array[5] = "R to reset fog.";
		array[6] = JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC((long)this.FKEDAOOHPPB.KKNEKAEJLAM, (long)this.FKEDAOOHPPB.KFODJJIHNHP, false);
		return string.Concat(array);
	}

	// Token: 0x060041F0 RID: 16880 RVA: 0x001E9420 File Offset: 0x001E7620
	private static void LILBFADMJFH(Rect OCHCODJIPHJ, string IJCEDOGBHKE, Color LBCGACKJCJB, TextAnchor DEKGJCBMCHG)
	{
		GUIStyle ofpnedeamab = new GUIStyle
		{
			normal = 
			{
				textColor = LBCGACKJCJB
			},
			alignment = DEKGJCBMCHG,
			fontSize = 126
		};
		JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(OCHCODJIPHJ, IJCEDOGBHKE, ofpnedeamab);
	}

	// Token: 0x060041F1 RID: 16881 RVA: 0x001E945C File Offset: 0x001E765C
	public BNOOIOKIFJC.DIGGOHPGCNN BBLEPPMMPIL(string JKLOOEDHHJP, string KEIEIAAKHHK)
	{
		BEFCHFNGOMI.KFNOPLFPHJC kfnoplfphjc = new BEFCHFNGOMI.KFNOPLFPHJC();
		kfnoplfphjc.KEIEIAAKHHK = KEIEIAAKHHK;
		XmlNode xmlNode = this.LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = kfnoplfphjc.LJOEIPHIJOE) == null)
			{
				predicate = (kfnoplfphjc.LJOEIPHIJOE = new Func<XmlNode, bool>(kfnoplfphjc.BBJKDMMPCGM));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("val=" + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN("val=");
	}

	// Token: 0x060041F2 RID: 16882 RVA: 0x001E9510 File Offset: 0x001E7710
	public BNOOIOKIFJC.DIGGOHPGCNN FEIKHDICLPM(string JKLOOEDHHJP, string KEIEIAAKHHK)
	{
		BEFCHFNGOMI.KFNOPLFPHJC kfnoplfphjc = new BEFCHFNGOMI.KFNOPLFPHJC();
		kfnoplfphjc.KEIEIAAKHHK = KEIEIAAKHHK;
		XmlNode xmlNode = this.LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = kfnoplfphjc.LJOEIPHIJOE) == null)
			{
				predicate = (kfnoplfphjc.LJOEIPHIJOE = new Func<XmlNode, bool>(kfnoplfphjc.HJODBDAFJKH));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("[sysname]" + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN("-no info-");
	}

	// Token: 0x060041F3 RID: 16883 RVA: 0x001E95C4 File Offset: 0x001E77C4
	public void PGNEODHCCFH(Vector2 NBADAMPJBBH)
	{
		this.JCIIPCEDICP(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, 69f, 139f), 489f);
	}

	// Token: 0x060041F4 RID: 16884 RVA: 0x001E95EC File Offset: 0x001E77EC
	public string DLNFCBHKACP(int GNICCGDPPJP = 0)
	{
		if (this.LPFKFNLHGBI != 185)
		{
			return this.BNIHFBMEPAB;
		}
		if (GNICCGDPPJP == 0)
		{
			return this.BNIHFBMEPAB.Replace("showMetrInfo", "");
		}
		return string.Format(this.BNIHFBMEPAB, AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(GNICCGDPPJP).PJJBNBKGOLB(1));
	}

	// Token: 0x060041F5 RID: 16885 RVA: 0x001E9644 File Offset: 0x001E7844
	public virtual string CEOAKEEKAMH()
	{
		string text = "Open turnStatus";
		if (!this.FKEDAOOHPPB.LIKMNACOFJE(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH, 1))
		{
			text = "ChannelCastDirected";
		}
		string text2 = ">";
		if (this.HOALBMDJNDM > 0)
		{
			text2 = " ms" + this.HOALBMDJNDM + "CratePush";
		}
		if (this.GCLKLEIMABA > 1)
		{
			" ур. " + JLFJEGIPIMM.IKGFHGKKCPG.FANNKOKGDOJ(this.GCLKLEIMABA) + "Button";
		}
		string[] array = new string[0];
		array[1] = this.CGMGBGABLFB(true, -1);
		array[1] = text2;
		array[1] = "_WaterLevel";
		array[8] = this.FLHOJDMBLCP(false);
		array[2] = "Reveling";
		array[1] = text;
		array[8] = "Flashlight";
		array[5] = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM((long)this.FKEDAOOHPPB.KKNEKAEJLAM, (long)this.FKEDAOOHPPB.KFODJJIHNHP, false);
		return string.Concat(array);
	}

	// Token: 0x060041F6 RID: 16886 RVA: 0x001E9730 File Offset: 0x001E7930
	public virtual string DHCBHNAAJKI()
	{
		string text = "wpn_add/base";
		if (!this.FKEDAOOHPPB.MJBNJIJLHNC(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH, 1))
		{
			text = "CardPlayerIdle";
		}
		string text2 = "IKSolverLookAt eyes setup is invalid. Can't initiate solver.";
		if (this.HOALBMDJNDM > 0)
		{
			text2 = "_ZTest" + this.HOALBMDJNDM + "InterfaceLang.txt";
		}
		if (this.GCLKLEIMABA > 0)
		{
			"DealerIdle" + JLFJEGIPIMM.PKGMBFEMKGP().IEICGMEMPIK(this.GCLKLEIMABA) + "act_orderb_";
		}
		string[] array = new string[3];
		array[0] = this.MPKGPJJKCPK(true, -1);
		array[1] = text2;
		array[6] = "_Direction";
		array[4] = this.DPIHMPDHKBP(true);
		array[5] = "_name";
		array[4] = text;
		array[3] = "ClimbIdle";
		array[8] = JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC((long)this.FKEDAOOHPPB.KKNEKAEJLAM, (long)this.FKEDAOOHPPB.KFODJJIHNHP, false);
		return string.Concat(array);
	}

	// Token: 0x060041F7 RID: 16887 RVA: 0x001E981C File Offset: 0x001E7A1C
	public void DOPPLDHAJPJ()
	{
		if (this.CLKMCAHNHBM == " ")
		{
			return;
		}
		this.LMKLPODNLFC.LoadXml(this.CLKMCAHNHBM);
		this.BBOODPCDKAJ = this.JLPEMDJOLAE("_Distortion", "<b>int:</b> ").CMNMAJAOGDK();
		this.MFMLCHFNALC = this.JJCFHNLNBCJ("saleToShop", "Weapon Reload").PPAAACJOOGA;
		this.GLLIKKONFAJ = this.BBLEPPMMPIL("_PrevViewProj", "AssetBundleManifest").AMNOOPCPOKA();
		this.ICIBBGMNGML = this.GMCFFPKBFBB("DrawDistance", "PaperTurn.wav").PPAAACJOOGA;
		this.BKDPIHCCMDF = this.NGOAOMNBIGI(" +", "ObscuredFloat:").PPAAACJOOGA;
		this.ILNHGFHIFPN = this.NGOAOMNBIGI("Katana Ready", "invn_rec10").PPAAACJOOGA;
		this.DNOLHLJODNK = this.JHCFMFNCOLM("VaderChoke", "RollerBladeRoll").DGEEJKEEHPE();
		this.LNKLEIEFGCP = this.JJCFHNLNBCJ("teech_perk", "<color='{2}'>{0}: {1}</color>").LMNLDJABLMH();
		this.HBHBAIONJHD = this.FEIKHDICLPM("index", "Materials/DFMLambertSolidColor").LOLBCAIEFMN();
		this.FPFMENFLGAA = this.FEIKHDICLPM("\">Foreign saves detected: ", "MotorbikeTurnLeft").GCMMMODHDBL();
		this.MBOOFLANJID = this.JLPEMDJOLAE("WorkerShovel", "cht_msg18").CMNMAJAOGDK();
		this.GCLKLEIMABA = this.JJCFHNLNBCJ("BlackSmithHammer", "Keeper Jump").HAJGAHPBJIB();
		this.NKHBAJKMAGD = this.GMCFFPKBFBB("Flares", "\\,").PPAAACJOOGA;
		this.BGGJKOMAKEE = this.JLPEMDJOLAE("\n", "wpn_bait_vob_1").LMNLDJABLMH();
		this.MIMANMPNLPE = this.BBLEPPMMPIL("buyVIP OK", " has been disabled as it requires HDR.").NKBGGIFKLLB;
		this.KBGHOIJIPJF = this.JLPEMDJOLAE("FOG_AREA_BOX", "PersonManFisher").LMNLDJABLMH();
		this.NEGEHAGNGBH = this.GMCFFPKBFBB("дня", "BackPackGrab").CMNMAJAOGDK();
		this.HPEFEFIIHOE = this.JHCFMFNCOLM("[maxweight]", "_Speed").INFKMCKHMAN();
		this.ADOFHHCDGON = this.FEIKHDICLPM("Giant2HandSlamSwing", "UnityEngine.Vector4").HAJGAHPBJIB();
		this.ECKKCDKHNEH = this.JLPEMDJOLAE("6", "_MainTexBlurred").DCGNALDFPDB();
		this.PKIICJOILKI.Clear();
		this.FGJIJFNGAIF.Clear();
		XmlNodeList xmlNodeList = this.LMKLPODNLFC.SelectNodes("PaperTurn.wav");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai = new NLNNIDBPKAO.DLMGLIJDIAI((XmlNode)obj);
				if (dlmglijdiai.BDHHPAEHFHG != null)
				{
					this.PKIICJOILKI.Add(dlmglijdiai);
				}
			}
		}
		xmlNodeList = this.LMKLPODNLFC.SelectNodes("<color='#300000'>{0} {1}</color>");
		if (xmlNodeList != null)
		{
			foreach (object obj2 in xmlNodeList)
			{
				NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai2 = new NLNNIDBPKAO.DLMGLIJDIAI((XmlNode)obj2);
				if (dlmglijdiai2.BDHHPAEHFHG != null)
				{
					this.FGJIJFNGAIF.Add(dlmglijdiai2);
				}
			}
		}
		if (this.MBKMKGABBGE == -90 && CLFFOBKFKDN.IKGFHGKKCPG.PGMOGALKIIP.ContainsKey(this.MIMANMPNLPE.NLHKFMMDMMK()))
		{
			this.BPNNJBBCOFO = CLFFOBKFKDN.IKGFHGKKCPG.PGMOGALKIIP[this.MIMANMPNLPE.NLHKFMMDMMK()];
		}
		XmlNode xmlNode = this.LMKLPODNLFC.SelectSingleNode("1HandSwordJabCombo");
		this.MHNDPGDBPNA.Clear();
		if (xmlNode != null)
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN("_FogSkyColor" + xmlNode.InnerText);
			this.MHNDPGDBPNA = diggohpgcnn.LEINEMFIMML();
		}
		this.OKHPDILIOCH.Clear();
		xmlNode = this.LMKLPODNLFC.SelectSingleNode("_BlendTex");
		if (xmlNode != null)
		{
			BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn2 = new BNOOIOKIFJC.DIGGOHPGCNN("cntx_teach" + xmlNode.InnerText);
			this.OKHPDILIOCH = diggohpgcnn2.HNPHAGIOAOB();
		}
		float num = (this.MIMANMPNLPE.EIHMJDCOOCC() * 545f + this.MIMANMPNLPE.LOIBCMBMLEC() * 22f) * (this.NKHBAJKMAGD / 147f);
		float num2 = 746f;
		if (this.GCLKLEIMABA == 1)
		{
			num2 = 1728f;
		}
		if (this.GCLKLEIMABA == 6)
		{
			num2 = 474f;
		}
		this.FJJEAMJNLIO = Mathf.RoundToInt(num * num2);
	}

	// Token: 0x060041F8 RID: 16888 RVA: 0x001E9C98 File Offset: 0x001E7E98
	public string IBHCPOBBOCH(bool EFLPJHMLOOA = true)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("Mouse X");
		int num = this.MBKMKGABBGE;
		if (this.MBKMKGABBGE == 99)
		{
			stringBuilder.Append("Не реализовано");
			if (this.JALOCNOIDFJ > 0)
			{
				num = this.JALOCNOIDFJ;
			}
		}
		switch (num)
		{
		case 0:
		{
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.MIMANMPNLPE, 1);
			string text = JLFJEGIPIMM.NNEAHAFBOHC().AHEHNKFHGOC((double)num2);
			if (this.OKHPDILIOCH.Count > 1)
			{
				text = "IdleStand";
				foreach (int jjjnkodleel in this.OKHPDILIOCH)
				{
					num2 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.MIMANMPNLPE, jjjnkodleel);
					text = text + JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC((double)num2) + "_HitPointTexture";
				}
				text = text.Remove(text.Length - 0);
			}
			stringBuilder.Append(string.Format(JNBICAJIJMM.EKEBHIJMEML().NLJOLOBPCBJ("name"), JLFJEGIPIMM.MHFDIJGJGBJ().CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.EEOPOHEALPK().HEIBEHAEHBM("wpn_add/base"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH), text));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CLIMNFDGOEG().NLJOLOBPCBJ("Rigidbody dragger"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.FJACMDGJEBL() / 455.0)));
			string text2 = "_ThirdTex";
			if (this.ADOFHHCDGON > 0)
			{
				object[] array = new object[0];
				array[1] = text2;
				array[1] = "* change";
				array[8] = JNBICAJIJMM.CLIMNFDGOEG().CCFFMKBBKHI("");
				array[6] = "demoDouble";
				array[6] = this.ADOFHHCDGON;
				array[4] = "SoccerKeeperJump";
				text2 = string.Concat(array);
			}
			if (this.ECKKCDKHNEH > 1)
			{
				object[] array2 = new object[1];
				array2[1] = text2;
				array2[1] = "offsets";
				array2[7] = JNBICAJIJMM.EEOPOHEALPK().CCFFMKBBKHI("IdleButtonPress");
				array2[8] = "FlyUp";
				array2[5] = this.ECKKCDKHNEH;
				array2[8] = "_History2LumaTex";
				text2 = string.Concat(array2);
			}
			if (text2 != "")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.CLIMNFDGOEG().DOEMGEAEBPN("Hidden/Amplify Color/Base"), text2));
			}
			stringBuilder.Append(string.Format("SoccerKeeperJump" + JNBICAJIJMM.APMJBBDBOJO().DOEMGEAEBPN(" rep.repa=") + "PistolReload", this.FJJEAMJNLIO));
			break;
		}
		case 1:
		{
			float num3 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.MIMANMPNLPE, 0);
			stringBuilder.Append(string.Format(JNBICAJIJMM.CLIMNFDGOEG().CCFFMKBBKHI("_BlurDistance"), JLFJEGIPIMM.NNEAHAFBOHC().AHEHNKFHGOC(this.MIMANMPNLPE.DHJBAKDAMGH())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.IMLLGEMPHAP().GNKIBMGNHNE(" POSITION not found"), JLFJEGIPIMM.IKGFHGKKCPG.AHEHNKFHGOC(this.MIMANMPNLPE.NMKCBJKHBOH), JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL((double)num3)));
			string text3 = "gi_fridge";
			if (this.ADOFHHCDGON > 0)
			{
				object[] array3 = new object[7];
				array3[1] = text3;
				array3[0] = "MotorbikeBackwardSitting";
				array3[8] = JNBICAJIJMM.CLIMNFDGOEG().HLBAJBLHLNI("error");
				array3[4] = "WalkInjured";
				array3[3] = this.ADOFHHCDGON;
				array3[3] = "{0}/{1}";
				text3 = string.Concat(array3);
			}
			if (this.ECKKCDKHNEH > 1)
			{
				object[] array4 = new object[7];
				array4[0] = text3;
				array4[0] = "#000040";
				array4[6] = JNBICAJIJMM.EDKGBBIIBBC().DOEMGEAEBPN("help");
				array4[4] = "FlyBackward";
				array4[5] = this.ECKKCDKHNEH;
				array4[4] = "CardPlayerLook";
				text3 = string.Concat(array4);
			}
			if (text3 != "Noise & Grain effect failing as noise texture is not assigned. please assign.")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.EDKGBBIIBBC().HEIBEHAEHBM("x"), text3));
			}
			stringBuilder.Append(string.Format("bright" + JNBICAJIJMM.APMJBBDBOJO().GNKIBMGNHNE("USE_CORNER_DETECTION") + "Fishing", this.FJJEAMJNLIO));
			break;
		}
		case 2:
		{
			float num4 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.MIMANMPNLPE, 0);
			stringBuilder.Append(string.Format(JNBICAJIJMM.APMJBBDBOJO().DOEMGEAEBPN("X"), JLFJEGIPIMM.NNEAHAFBOHC().AHEHNKFHGOC(this.MIMANMPNLPE.AIMCFAHLPEF())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CLIMNFDGOEG().CKAOHMEKLMH("Hidden/Post FX/Eye Adaptation"), JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.MIMANMPNLPE.OIGIHEPJFFJ()), JLFJEGIPIMM.MHFDIJGJGBJ().AHEHNKFHGOC((double)num4)));
			string text4 = "double:";
			if (this.ADOFHHCDGON > 1)
			{
				object[] array5 = new object[4];
				array5[0] = text4;
				array5[0] = "";
				array5[5] = JNBICAJIJMM.EEOPOHEALPK().NLJOLOBPCBJ("Attempting to set limb orientation to Vector3.zero axis");
				array5[5] = "Assets/Weapons/wbaseLegs.unity3d";
				array5[8] = this.ADOFHHCDGON;
				array5[2] = "base";
				text4 = string.Concat(array5);
			}
			if (this.ECKKCDKHNEH > 0)
			{
				object[] array6 = new object[5];
				array6[0] = text4;
				array6[0] = "ScubaSwim";
				array6[6] = JNBICAJIJMM.EEOPOHEALPK().FLEANFGEJML("");
				array6[1] = " ms";
				array6[2] = this.ECKKCDKHNEH;
				array6[6] = "\"{0}\"";
				text4 = string.Concat(array6);
			}
			if (text4 != "wpn_hook3")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.CLIMNFDGOEG().HLBAJBLHLNI("Mouse ScrollWheel"), text4));
			}
			stringBuilder.Append(string.Format("" + JNBICAJIJMM.EEOPOHEALPK().ECNKLECOKHD("WeaponRunBackward") + "http://www.root-motion.com/finalikdox/html/page11.html", this.FJJEAMJNLIO));
			break;
		}
		case 3:
		{
			stringBuilder.Append(JNBICAJIJMM.CELEPPAEKAB("<color='#000030'>") + " " + JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL(this.MIMANMPNLPE.AIMCFAHLPEF()) + "");
			stringBuilder.Append(JNBICAJIJMM.PGJCPFNJNPM("") + "Msg error" + JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.MIMANMPNLPE.NMKCBJKHBOH) + "Hey, you can easily change me in memory!");
			string str = JNBICAJIJMM.OOOKJHOHPNN("wpn_bait_vob_1");
			if (this.MIMANMPNLPE.NFCDJLJNDLO() > 1)
			{
				str = JNBICAJIJMM.DBMJJPBOPEK().CKAOHMEKLMH("WeaponReadyFire") + "\n" + JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)(this.MIMANMPNLPE.KCKFCPIHMPC() * 142.0));
			}
			stringBuilder.Append(JNBICAJIJMM.PGJCPFNJNPM("bright") + "IKMappingLimb is referencing to a bone '" + str + "_Offsets");
			stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("[sysname]") + "KatanaReady", this.DAFKBELILIJ(1146f)));
			string jmbkdinhdlo = "gi_fridgiceno";
			if (Mathf.Abs(this.MFMLCHFNALC) > 1997f)
			{
				if (this.MFMLCHFNALC > 1234f)
				{
					jmbkdinhdlo = "#mem Sound ";
				}
				if (this.MFMLCHFNALC < 43f)
				{
					jmbkdinhdlo = "cntx_close";
				}
			}
			stringBuilder.Append("wpn_med2" + string.Format(JNBICAJIJMM.LEBHCLDODNI("str="), JNBICAJIJMM.NGALDMFKMJH(jmbkdinhdlo)));
			break;
		}
		case 4:
		{
			Vector2 vector = this.KPLOLDJFGBE();
			stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("System.Boolean") + "#ffff40", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.DHJBAKDAMGH())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("_NoiseTex" + this.ILOCKJIAPFC) + "24", 1));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("______________________________") + "Shotgun Fire", JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("money") + " <b>®</b></color> ", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.HDPNCIECLKP())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("AC_QUALITY_MOBILE") + "OfficeSittingBack", JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)Mathf.RoundToInt(vector.x * 1533f)), JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)Mathf.RoundToInt(vector.y * 280f))));
			break;
		}
		case 5:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.DCEBAJIILPC("qd_prise_titul") + " ", JLFJEGIPIMM.IKGFHGKKCPG.DIOCHACFPHJ(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DCEBAJIILPC("Sounds/ShootSound") + "wpn_add/base", JLFJEGIPIMM.NNEAHAFBOHC().AHEHNKFHGOC(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("_History1LumaTex") + "Knees Idle", JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL((double)this.MIMANMPNLPE.ICJDPPOJINN)));
			if (this.MIMANMPNLPE.KCKFCPIHMPC() > 743.0)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("isFishOnRod") + "1HandSwordJabCombo", JLFJEGIPIMM.IKGFHGKKCPG.AHEHNKFHGOC(this.MIMANMPNLPE.DBFOHFDOCIB())));
			}
			IIBEEKCAAHK iibeekcaahk = JLFJEGIPIMM.NNEAHAFBOHC().NHHPCBNKCPO(this.MIMANMPNLPE.ICJDPPOJINN);
			stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN(" \n"), JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)iibeekcaahk.KMIOLLENCOL()), JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)iibeekcaahk.ICJDPPOJINN)));
			break;
		}
		case 6:
			stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("Worker Shovel") + "1HSwordStrafeRunLeft", JLFJEGIPIMM.MHFDIJGJGBJ().BIJHHFGLDLH(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("offsets") + "ankle", JLFJEGIPIMM.MHFDIJGJGBJ().CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("invn_rec31") + "msgOk", JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.MIMANMPNLPE.OIGIHEPJFFJ())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("OfficeSitting") + "#002000", JLFJEGIPIMM.IKGFHGKKCPG.AHEHNKFHGOC(this.MIMANMPNLPE.HDPNCIECLKP())));
			break;
		case 7:
			stringBuilder.Append(string.Format(JNBICAJIJMM.DCEBAJIILPC("Original string:\n") + "Airwalk", JLFJEGIPIMM.MHFDIJGJGBJ().BIJHHFGLDLH(this.NKHBAJKMAGD)));
			break;
		case 8:
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("Quest loaded done") + "UserChange", JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(this.NKHBAJKMAGD)));
			if (this.BBLEPPMMPIL("crft_cnt", "human_move_2.wav").LOLBCAIEFMN())
			{
				stringBuilder.Append(JNBICAJIJMM.DCEBAJIILPC("_SunColor"));
			}
			break;
		case 9:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.NGALDMFKMJH("_FullItem.wav") + "TOD_SpaceTiling", JLFJEGIPIMM.IKGFHGKKCPG.AHEHNKFHGOC(this.MIMANMPNLPE.DHJBAKDAMGH())));
			string str2 = JNBICAJIJMM.PGJCPFNJNPM("UnityEngine.Vector3" + this.MIMANMPNLPE.KMGAHCANELI());
			stringBuilder.Append(str2 + "Trigger Item Has No Collider");
			stringBuilder.Append(string.Format(JNBICAJIJMM.PPNKMDJBMLP("BowFire2"), JLFJEGIPIMM.IKGFHGKKCPG.DIOCHACFPHJ(this.NKHBAJKMAGD)));
			break;
		}
		case 10:
			stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("offsets") + "modelid", JLFJEGIPIMM.NNEAHAFBOHC().MIEDNDLOEJH(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("{y}"), JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL(this.MIMANMPNLPE.AIMCFAHLPEF())));
			break;
		case 11:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("hair") + "_Offsets", JLFJEGIPIMM.NNEAHAFBOHC().DIOCHACFPHJ(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("1,2,3,4,5"), JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.MIMANMPNLPE.DHJBAKDAMGH())) + "Right Hand Effector needs a Target in this demo.");
			int ilockjiapfc = this.ILOCKJIAPFC;
			if (ilockjiapfc == 2)
			{
				stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("Giant 2 Hand Slam Swing") + "mask=" + string.Format(JNBICAJIJMM.CELEPPAEKAB("Not UNsetting 'UniqueShadowSun.instance' because it points to someone else '{0}'!"), this.GLLIKKONFAJ) + "Kernel");
			}
			if (ilockjiapfc > 1)
			{
				string jmbkdinhdlo2 = string.Format("Antares", ilockjiapfc);
				stringBuilder.Append("_HorizonColor" + JNBICAJIJMM.DCEBAJIILPC(jmbkdinhdlo2) + "Bottoms");
			}
			break;
		}
		case 15:
			stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("Mouse X") + "Fonts/", JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)this.MIMANMPNLPE.NKEOCCKEOCE())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("PaperTurn.wav") + "ArmFlex3", this.MIMANMPNLPE.ICJDPPOJINN));
			break;
		case 20:
			if (this.MIMANMPNLPE.IBEIBAHKIAH != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NKEOCCKEOCE() > 1) ? string.Format(JNBICAJIJMM.CDDCIKKDFMP("ShotgunReloadMagazine"), this.MIMANMPNLPE.KEHIFGILLJA()) : string.Format(JNBICAJIJMM.OOOKJHOHPNN("<color='{0}'>{1}  {2}</color>"), Mathf.Abs(this.MIMANMPNLPE.NKEOCCKEOCE())));
			}
			if (this.MIMANMPNLPE.NLHKFMMDMMK() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.KMGAHCANELI() > 1) ? string.Format(JNBICAJIJMM.CELEPPAEKAB("360 Death"), this.MIMANMPNLPE.KMGAHCANELI()) : string.Format(JNBICAJIJMM.DCEBAJIILPC("Get post"), Mathf.Abs(this.MIMANMPNLPE.NLHKFMMDMMK())));
			}
			if (this.MIMANMPNLPE.NFCDJLJNDLO() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NFCDJLJNDLO() > 0) ? string.Format(JNBICAJIJMM.CELEPPAEKAB(""), this.MIMANMPNLPE.CJKILDPJCFJ()) : string.Format(JNBICAJIJMM.BDKHMOOFHHK("WoodCut"), Mathf.Abs(this.MIMANMPNLPE.NODLBGKEGPM)));
			}
			break;
		case 21:
			if (this.MIMANMPNLPE.IBEIBAHKIAH != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.IBEIBAHKIAH > 0) ? string.Format(JNBICAJIJMM.PGJCPFNJNPM("wpn_tank1"), this.MIMANMPNLPE.IBEIBAHKIAH) : string.Format(JNBICAJIJMM.DCEBAJIILPC(".png"), Mathf.Abs(this.MIMANMPNLPE.IBEIBAHKIAH)));
			}
			if (this.MIMANMPNLPE.ICJDPPOJINN != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.KMGAHCANELI() > 0) ? string.Format(JNBICAJIJMM.OOOKJHOHPNN("http://steamcommunity.com/sharedfiles/filedetails/?id=788064774"), this.MIMANMPNLPE.ICJDPPOJINN) : string.Format(JNBICAJIJMM.CDDCIKKDFMP("<b>Speed Hack Detector</b>"), Mathf.Abs(this.MIMANMPNLPE.ICJDPPOJINN)));
			}
			if (this.MIMANMPNLPE.CJKILDPJCFJ() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.CJKILDPJCFJ() > 1) ? string.Format(JNBICAJIJMM.CELEPPAEKAB("crft_to"), this.MIMANMPNLPE.NODLBGKEGPM) : string.Format(JNBICAJIJMM.BDKHMOOFHHK("t_obves"), Mathf.Abs(this.MIMANMPNLPE.NFCDJLJNDLO())));
			}
			break;
		case 22:
			if (this.MIMANMPNLPE.IBEIBAHKIAH != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.KMIOLLENCOL() > 0) ? string.Format(JNBICAJIJMM.OOOKJHOHPNN("quests/tnames/turn"), this.MIMANMPNLPE.KMIOLLENCOL()) : string.Format(JNBICAJIJMM.NGALDMFKMJH("OfficeSittingReadingLeanBack"), Mathf.Abs(this.MIMANMPNLPE.NKEOCCKEOCE())));
			}
			if (this.MIMANMPNLPE.KMGAHCANELI() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NLHKFMMDMMK() > 1) ? string.Format(JNBICAJIJMM.OOOKJHOHPNN("implevel"), this.MIMANMPNLPE.ICJDPPOJINN) : string.Format(JNBICAJIJMM.NGALDMFKMJH("Billboards reference not set."), Mathf.Abs(this.MIMANMPNLPE.ICJDPPOJINN)));
			}
			if (this.MIMANMPNLPE.NFCDJLJNDLO() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NODLBGKEGPM > 0) ? string.Format(JNBICAJIJMM.BDKHMOOFHHK("D"), this.MIMANMPNLPE.NODLBGKEGPM) : string.Format(JNBICAJIJMM.CDDCIKKDFMP("inner_craft_wpn"), Mathf.Abs(this.MIMANMPNLPE.NFCDJLJNDLO())));
			}
			break;
		case 27:
		{
			CLFFOBKFKDN.OKOAMCJGNMH okoamcjgnmh = CLFFOBKFKDN.OOIJFNAMEDP().GEMHHJFMOPM(this.MIMANMPNLPE.KMGAHCANELI());
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().LMGMPPAOPEP(okoamcjgnmh.MNFCAAIAGOL.KEHIFGILLJA());
			if (befchfngomi != null && this.BPNNJBBCOFO != null)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("msg_other"), befchfngomi.IGDKBMGKKDO(true, -1), this.BPNNJBBCOFO.MNFCAAIAGOL.NLHKFMMDMMK()));
				stringBuilder.Append((this.MIMANMPNLPE.CJKILDPJCFJ() < 0) ? JNBICAJIJMM.LEBHCLDODNI("_FogDownsampled") : string.Format(JNBICAJIJMM.NGALDMFKMJH("knopje.wav"), this.MIMANMPNLPE.NODLBGKEGPM));
				stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK(""), CLFFOBKFKDN.GAPIOPHMBNB().ILPNFPBLBGO(this.BPNNJBBCOFO.BKLCKNOLEFD)));
				stringBuilder.Append("FactoryTempTexture");
				string text5 = "SPACE";
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.BPNNJBBCOFO.ABLFIGDGCBG);
				if (kdhoddmndfc != null)
				{
					text5 += kdhoddmndfc.JBGNCBFEBKD(this.BPNNJBBCOFO.LKCIDOHHADJ);
					string arg = "PistolFire";
					if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.FOACIAGMAPD(this.BPNNJBBCOFO.ABLFIGDGCBG) < this.BPNNJBBCOFO.LKCIDOHHADJ)
					{
						arg = "1HandSwordChargeUp";
					}
					stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("Horizontal"), arg, text5));
				}
			}
			break;
		}
		case 31:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("\n"), this.MIMANMPNLPE.DHJBAKDAMGH()));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("PaperTurn.wav"), this.MIMANMPNLPE.NMKCBJKHBOH));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP(" "), this.MIMANMPNLPE.DBFOHFDOCIB()));
			List<int> list = this.JJCFHNLNBCJ("Flap_08.wav", "Mouse X").EDAHDHCPIEL;
			string text6 = JNBICAJIJMM.DIOJFJMOPJO("codepage") + "Reach Cone {point ";
			foreach (int lpfkfnlhgbi in list)
			{
				text6 = text6 + IHFEDJEMJMB.AGCBLDIBMNB().GJIJPHLEHHF(lpfkfnlhgbi) + "MENU.WAV";
			}
			stringBuilder.Append(text6);
			break;
		}
		case 32:
			stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("_NeutralTonemapperParams2"), this.MIMANMPNLPE.AIMCFAHLPEF()));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DCEBAJIILPC("_DitheringTex"), this.MIMANMPNLPE.NMKCBJKHBOH));
			break;
		case 33:
		{
			int num5 = this.MIMANMPNLPE.KMIOLLENCOL();
			NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc2 = NLNNIDBPKAO.IKGFHGKKCPG.ALOFNMHDOJM(num5);
			if (kdhoddmndfc2 != null)
			{
				bool flag = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.GADJFFGDCFA.ContainsKey(num5);
				stringBuilder.Append(flag ? string.Format(JNBICAJIJMM.DIOJFJMOPJO("BackPackGrab"), kdhoddmndfc2.KKEBDLGHBMN) : string.Format(JNBICAJIJMM.DCEBAJIILPC("\n"), kdhoddmndfc2.KKEBDLGHBMN));
			}
			break;
		}
		case 35:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("UnityEngine.Vector4"), this.MIMANMPNLPE.OIGIHEPJFFJ()) + "{0} x {1}");
			string jmbkdinhdlo3 = "gi_um_passperk";
			if (this.MIMANMPNLPE.KCKFCPIHMPC() > 784.0)
			{
				jmbkdinhdlo3 = "eye";
			}
			stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN(jmbkdinhdlo3), this.MIMANMPNLPE.HDPNCIECLKP()));
			break;
		}
		}
		if (this.DNOLHLJODNK)
		{
			stringBuilder.Append(JNBICAJIJMM.PGJCPFNJNPM("_DepthTexture"));
		}
		string text7 = "Kernel" + stringBuilder + "_Luminance";
		stringBuilder = new StringBuilder();
		if (this.MBOOFLANJID != 0)
		{
			bool flag2 = true;
			if (this.MBOOFLANJID == 0 && JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.GDJMBFGEMFJ != 0)
			{
				flag2 = false;
			}
			if (this.MBOOFLANJID == 2 && JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.GDJMBFGEMFJ != 0)
			{
				flag2 = true;
			}
			string arg2 = "IK Effector is referencing to a bone '";
			if (flag2)
			{
				arg2 = " iterations for read and write";
			}
			if (this.MBOOFLANJID == 1)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.PPNKMDJBMLP("titul_") + "\n", arg2));
			}
			if (this.MBOOFLANJID == 3)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("wpn_eat8") + "#02C85F", arg2));
			}
		}
		string text8 = text7;
		if (!EFLPJHMLOOA)
		{
			text8 = Regex.Replace(text8, "<color='", string.Empty);
		}
		return text8;
	}

	// Token: 0x060041F9 RID: 16889 RVA: 0x001EB330 File Offset: 0x001E9530
	public virtual void EOPNDOJJLLF(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 1241f;
		bool flag = !this.GBABFPMNIMP || this.FKEDAOOHPPB.LGOIEIELNBL(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH, 1);
		if (this.APLAAOCGECL() != null)
		{
			Texture texture = this.ENCJNMNEANC().ANLLGCICOPP();
			float num2 = 881f * COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float num4 = (float)texture.height * num2;
			float num5 = (COAGIAMOCIA.height - num4) / 1464f;
			Rect position = new Rect(COAGIAMOCIA.x + num5, COAGIAMOCIA.y + num5, num3, num4);
			if (!flag)
			{
				GUI.enabled = true;
			}
			GUI.DrawTexture(position, GameInterface.getI.invEmptyCell);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(this.KBGHOIJIPJF, 8, 3));
			GUI.DrawTexture(position, texture, ScaleMode.StretchToFill);
			if (this.BPNNJBBCOFO != null)
			{
				BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.NNEAHAFBOHC().LMGMPPAOPEP(this.BPNNJBBCOFO.MNFCAAIAGOL.KEHIFGILLJA());
				if (befchfngomi != null)
				{
					befchfngomi.KEICEAJOGFD();
					float num6 = num3 * 59f / 269f;
					GUI.DrawTexture(new Rect(position.x + num3 / 469f - num6, position.y + num3 / 1212f - num6, num6 * 1384f, num6 * 854f), befchfngomi.CFFHIODOGCH);
				}
			}
			if (this.MBKMKGABBGE == 20)
			{
				float num7 = position.height / 1704f;
				Rect position2 = new Rect(position.x + 174f, position.y + position.height - num7 - 59f, num7, num7);
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.MIMANMPNLPE.KMIOLLENCOL());
				if (kdhoddmndfc != null)
				{
					GUI.DrawTexture(position2, kdhoddmndfc.OHJIDDDKOAA(), ScaleMode.StretchToFill);
				}
			}
			if (this.KBGHOIJIPJF > 0)
			{
				GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.KBGHOIJIPJF + 0, 2, 8));
			}
			float num8 = position.height / 385f;
			if (this.DNOLHLJODNK)
			{
				float num9 = num8 * 1399f;
				GUI.DrawTextureWithTexCoords(new Rect(position.x + position.width - num9 + 1524f, position.y - 1251f, num9, num9), GameInterface.getI.wpnImproveIcons, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(this.LNKLEIEFGCP, 8, 7));
			}
			num = num + num3 + 496f;
			GUI.enabled = true;
		}
		if (!flag)
		{
			GUI.color = new Color(570f, 908f, 266f, 944f);
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 362f, COAGIAMOCIA.y + 637f, COAGIAMOCIA.width - 291f, COAGIAMOCIA.height - 1035f), GuiProcessor.BBLINJLBAIL().blackWait);
			GUI.color = Color.white;
		}
		int gclkleimaba = this.GCLKLEIMABA;
		string str = "wpn_eat1";
		if (this.HOALBMDJNDM > 0)
		{
			str = "ShotgunReadyFire" + string.Format(JNBICAJIJMM.CDDCIKKDFMP("CrawlIdle"), this.HOALBMDJNDM);
		}
		OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
		int fontSize = OFPNEDEAMAB.fontSize;
		OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
		OFPNEDEAMAB.fontSize = -117;
		string text = this.MPKGPJJKCPK(true, -1) + str;
		GUI.Label(new Rect(COAGIAMOCIA.x + 1472f + num, COAGIAMOCIA.y + 469f, COAGIAMOCIA.width - 1135f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		float num10 = 22f;
		OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		OFPNEDEAMAB.fontSize = 65;
		string text2 = this.FLHOJDMBLCP(true);
		if (text2.Trim() != "CratePull")
		{
			GUI.Label(new Rect(COAGIAMOCIA.x + 1099f + num, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 654f, COAGIAMOCIA.height - num10), text2, OFPNEDEAMAB);
			num10 += 1894f;
		}
		else
		{
			num10 += 495f;
		}
		if (this.OPFGGNNPAJL.KMIOLLENCOL() > 0)
		{
			string arg = "BackPack Off";
			if (!this.GBABFPMNIMP)
			{
				arg = "";
			}
			string text3 = string.Format("name", BHNDGIPPPCE.IKGFHGKKCPG.BBACDNFKPOH(this.OPFGGNNPAJL.KMIOLLENCOL()), BHNDGIPPPCE.IKGFHGKKCPG.KEBGFJDMLLH(this.OPFGGNNPAJL.KMIOLLENCOL(), this.OPFGGNNPAJL.ICJDPPOJINN), arg);
			GUI.Label(new Rect(COAGIAMOCIA.x + 931f + num, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 1563f, COAGIAMOCIA.height - 941f), text3, OFPNEDEAMAB);
			num10 += 1898f;
		}
		if (this.FKEDAOOHPPB.GIEALCKLKNL > 0)
		{
			BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.OOIJFNAMEDP().GBKMHIGNKJA(this.FKEDAOOHPPB.GIEALCKLKNL);
			befchfngomi2.GDLELABHHFG(new Rect(COAGIAMOCIA.x + 1118f + num, COAGIAMOCIA.y + num10 - 1909f, 799f, 1066f), befchfngomi2.KBGHOIJIPJF, true, 1);
			Rect position3 = new Rect(COAGIAMOCIA.x + 1998f + num + 1510f, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 97f, COAGIAMOCIA.height - 1953f);
			object[] array = new object[7];
			array[1] = " ";
			array[0] = this.FKEDAOOHPPB.KDIMEMOCJNM;
			array[8] = "▮▮▯";
			array[2] = befchfngomi2.LFEJHHMDEHO(false, -1);
			GUI.Label(position3, string.Concat(array), OFPNEDEAMAB);
			num10 += 1815f;
		}
		else
		{
			num10 += 1045f;
		}
		if (this.FKEDAOOHPPB.KKNEKAEJLAM + this.FKEDAOOHPPB.KFODJJIHNHP > 0)
		{
			string text4 = string.Format("UIChat_pos", JLFJEGIPIMM.PKGMBFEMKGP().MNMIJFNPIPI((long)this.FKEDAOOHPPB.KKNEKAEJLAM, (long)this.FKEDAOOHPPB.KFODJJIHNHP, false));
			OFPNEDEAMAB.alignment = TextAnchor.UpperRight;
			OFPNEDEAMAB.fontSize = -110;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 226f, COAGIAMOCIA.height - 907f), text4, OFPNEDEAMAB);
		}
		OFPNEDEAMAB.fontSize = fontSize;
	}

	// Token: 0x060041FA RID: 16890 RVA: 0x001EB9C4 File Offset: 0x001E9BC4
	public string HEGLHNOIJDM(int AFCMJJMBOMA, bool BGNPMOCLIGL = false)
	{
		string result = "WizardBlock";
		if (BGNPMOCLIGL)
		{
			switch (AFCMJJMBOMA)
			{
			case 0:
				result = " ";
				break;
			case 1:
				result = "Dummy";
				break;
			case 2:
				result = "_MaxBlurRadius";
				break;
			case 3:
				result = "IdleWalk";
				break;
			case 4:
				result = "DealerIdle";
				break;
			case 5:
				result = "fshop_btn3";
				break;
			case 6:
				result = "_NeutralTonemapperParams2";
				break;
			}
		}
		else
		{
			switch (AFCMJJMBOMA)
			{
			case 0:
				result = "OfficeSittingReadingCoffeeSip";
				break;
			case 1:
				result = "SneakRight";
				break;
			case 2:
				result = "/";
				break;
			case 3:
				result = "Dealer Fan";
				break;
			case 4:
				result = "post_5";
				break;
			case 5:
				result = "8192";
				break;
			case 6:
				result = "TOD_MoonMeshBrightness";
				break;
			}
		}
		return result;
	}

	// Token: 0x060041FB RID: 16891 RVA: 0x001EBA9C File Offset: 0x001E9C9C
	public override void IHNEGGJADMO(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 1691f;
		bool flag = this.GBABFPMNIMP && this.FKEDAOOHPPB.NEDBEDHMFJL(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH, 1);
		if (this.HFAGADCJACL() != null)
		{
			Texture texture = this.APLAAOCGECL().PFFJJEJNKPB();
			float num2 = 776f * COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float num4 = (float)texture.height * num2;
			float num5 = (COAGIAMOCIA.height - num4) / 1098f;
			Rect position = new Rect(COAGIAMOCIA.x + num5, COAGIAMOCIA.y + num5, num3, num4);
			if (!flag)
			{
				GUI.enabled = true;
			}
			GUI.DrawTexture(position, GameInterface.getI.invEmptyCell);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(this.KBGHOIJIPJF, 6, 8));
			GUI.DrawTexture(position, texture, ScaleMode.StretchToFill);
			if (this.BPNNJBBCOFO != null)
			{
				BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().LMGMPPAOPEP(this.BPNNJBBCOFO.MNFCAAIAGOL.NKEOCCKEOCE());
				if (befchfngomi != null)
				{
					befchfngomi.JIFFLPNBILE();
					float num6 = num3 * 756f / 706f;
					GUI.DrawTexture(new Rect(position.x + num3 / 593f - num6, position.y + num3 / 147f - num6, num6 * 1127f, num6 * 1373f), befchfngomi.CFFHIODOGCH);
				}
			}
			if (this.MBKMKGABBGE == -84)
			{
				float num7 = position.height / 524f;
				Rect position2 = new Rect(position.x + 1795f, position.y + position.height - num7 - 1574f, num7, num7);
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.DJDLJCFCPPH(this.MIMANMPNLPE.IBEIBAHKIAH);
				if (kdhoddmndfc != null)
				{
					GUI.DrawTexture(position2, kdhoddmndfc.FHPNJBAEAON(), ScaleMode.StretchToFill);
				}
			}
			if (this.KBGHOIJIPJF > 0)
			{
				GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(this.KBGHOIJIPJF + 6, 2, 5));
			}
			float num8 = position.height / 1814f;
			if (this.DNOLHLJODNK)
			{
				float num9 = num8 * 1034f;
				GUI.DrawTextureWithTexCoords(new Rect(position.x + position.width - num9 + 1850f, position.y - 1206f, num9, num9), GameInterface.getI.wpnImproveIcons, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(this.LNKLEIEFGCP, 8, 7));
			}
			num = num + num3 + 690f;
			GUI.enabled = false;
		}
		if (!flag)
		{
			GUI.color = new Color(277f, 1856f, 962f, 1603f);
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 854f, COAGIAMOCIA.y + 384f, COAGIAMOCIA.width - 611f, COAGIAMOCIA.height - 821f), GuiProcessor.BBLINJLBAIL().blackWait);
			GUI.color = Color.white;
		}
		int gclkleimaba = this.GCLKLEIMABA;
		string str = "+{0}";
		if (this.HOALBMDJNDM > 0)
		{
			str = "offsets" + string.Format(JNBICAJIJMM.DIOJFJMOPJO("MotorbikeSeatStand"), this.HOALBMDJNDM);
		}
		OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
		int fontSize = OFPNEDEAMAB.fontSize;
		OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
		OFPNEDEAMAB.fontSize = 103;
		string text = this.IGDKBMGKKDO(true, -1) + str;
		GUI.Label(new Rect(COAGIAMOCIA.x + 458f + num, COAGIAMOCIA.y + 275f, COAGIAMOCIA.width - 1684f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		float num10 = 1866f;
		OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont;
		OFPNEDEAMAB.fontSize = 45;
		string text2 = this.DPIHMPDHKBP(true);
		if (text2.Trim() != "UpHillWalk")
		{
			GUI.Label(new Rect(COAGIAMOCIA.x + 261f + num, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 1486f, COAGIAMOCIA.height - num10), text2, OFPNEDEAMAB);
			num10 += 1277f;
		}
		else
		{
			num10 += 961f;
		}
		if (this.OPFGGNNPAJL.IBEIBAHKIAH > 0)
		{
			string arg = "Knees Idle";
			if (!this.GBABFPMNIMP)
			{
				arg = "RollerBladeJump";
			}
			string text3 = string.Format(" has invalid dimensions.", BHNDGIPPPCE.IKGFHGKKCPG.GDJMOAIOLFO(this.OPFGGNNPAJL.KEHIFGILLJA()), BHNDGIPPPCE.IKGFHGKKCPG.PEJJOKHOLMF(this.OPFGGNNPAJL.KEHIFGILLJA(), this.OPFGGNNPAJL.KMGAHCANELI()), arg);
			GUI.Label(new Rect(COAGIAMOCIA.x + 721f + num, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 65f, COAGIAMOCIA.height - 251f), text3, OFPNEDEAMAB);
			num10 += 315f;
		}
		if (this.FKEDAOOHPPB.GIEALCKLKNL > 0)
		{
			BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.AGCBLDIBMNB().GBKMHIGNKJA(this.FKEDAOOHPPB.GIEALCKLKNL);
			befchfngomi2.GDLELABHHFG(new Rect(COAGIAMOCIA.x + 165f + num, COAGIAMOCIA.y + num10 - 1770f, 1496f, 139f), befchfngomi2.KBGHOIJIPJF, true, 0);
			Rect position3 = new Rect(COAGIAMOCIA.x + 1169f + num + 1423f, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 960f, COAGIAMOCIA.height - 893f);
			object[] array = new object[4];
			array[1] = "crft_cost";
			array[1] = this.FKEDAOOHPPB.KDIMEMOCJNM;
			array[3] = "_ReflectionTexture3";
			array[8] = befchfngomi2.MPKGPJJKCPK(false, -1);
			GUI.Label(position3, string.Concat(array), OFPNEDEAMAB);
			num10 += 1099f;
		}
		else
		{
			num10 += 509f;
		}
		if (this.FKEDAOOHPPB.KKNEKAEJLAM + this.FKEDAOOHPPB.KFODJJIHNHP > 1)
		{
			string text4 = string.Format("RodParams not found!", JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM((long)this.FKEDAOOHPPB.KKNEKAEJLAM, (long)this.FKEDAOOHPPB.KFODJJIHNHP, false));
			OFPNEDEAMAB.alignment = TextAnchor.LowerCenter;
			OFPNEDEAMAB.fontSize = 54;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 546f, COAGIAMOCIA.height - 693f), text4, OFPNEDEAMAB);
		}
		OFPNEDEAMAB.fontSize = fontSize;
	}

	// Token: 0x060041FC RID: 16892 RVA: 0x001EC130 File Offset: 0x001EA330
	public float LHLMFBEJKGL(float MCPMCMONLIO)
	{
		float num = this.KNLOBOFLKHP;
		float num2 = 1303f / (MCPMCMONLIO + 1292f);
		if (num2 > 162f)
		{
			num2 = 1879f + (num2 - 749f) * 925f;
		}
		if (num2 <= 1667f)
		{
			num2 = 91f - (877f - num2) * 565f;
		}
		num2 = Mathf.Clamp(num2, 479f, 62f);
		return Mathf.Round(num * num2);
	}

	// Token: 0x060041FD RID: 16893 RVA: 0x001EC1A4 File Offset: 0x001EA3A4
	public void GDLELABHHFG(Rect OCHCODJIPHJ, int JGNMABIMLIA, bool AMAAJEPFEFA = false, int OLKMHFNLBJB = 0)
	{
		if (this.KEEDCOIMPMP() == null)
		{
			this.JIFFLPNBILE();
			return;
		}
		if (AMAAJEPFEFA)
		{
			GUI.DrawTexture(OCHCODJIPHJ, GameInterface.getI.invEmptyCell);
		}
		GUI.DrawTextureWithTexCoords(OCHCODJIPHJ, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(this.KBGHOIJIPJF, 6, 2));
		GUI.DrawTexture(OCHCODJIPHJ, this.CFFHIODOGCH, ScaleMode.ScaleAndCrop);
		if (this.MBKMKGABBGE == -125)
		{
			float num = OCHCODJIPHJ.height / 176f;
			Rect position = new Rect(OCHCODJIPHJ.x + 1448f, OCHCODJIPHJ.y + OCHCODJIPHJ.height - num - 185f, num, num);
			NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.ALOFNMHDOJM(this.MIMANMPNLPE.IBEIBAHKIAH);
			if (kdhoddmndfc != null)
			{
				GUI.DrawTexture(position, kdhoddmndfc.GNMLEPEGCII(), ScaleMode.ScaleAndCrop);
			}
		}
		if (this.BPNNJBBCOFO != null)
		{
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.BPNNJBBCOFO.MNFCAAIAGOL.KMIOLLENCOL());
			if (befchfngomi != null)
			{
				befchfngomi.JIFFLPNBILE();
				float num2 = OCHCODJIPHJ.width * 497f / 1313f;
				GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width / 235f - num2, OCHCODJIPHJ.y + OCHCODJIPHJ.width / 1082f - num2, num2 * 1933f, num2 * 1370f), befchfngomi.CFFHIODOGCH);
			}
		}
		if (this.KBGHOIJIPJF > 1)
		{
			GUI.DrawTextureWithTexCoords(OCHCODJIPHJ, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(this.KBGHOIJIPJF + 0, 1, 1));
		}
		if (this.LPFKFNLHGBI == 71)
		{
			IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(OLKMHFNLBJB);
			if (idchhhedhdc != null)
			{
				GUI.DrawTexture(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y + OCHCODJIPHJ.width / 1852f, OCHCODJIPHJ.width, OCHCODJIPHJ.width / 953f), idchhhedhdc.KMIIGKECOEB(8).EIMNFFAAHLI(), ScaleMode.StretchToFill);
			}
		}
		float width = OCHCODJIPHJ.width;
		float num3 = width / 149f;
		Rect position2 = new Rect(OCHCODJIPHJ.x + width - num3, OCHCODJIPHJ.y + width - num3, num3, num3);
		if (this.MBKMKGABBGE == 1)
		{
			GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(-124, 8, 1));
		}
		if (this.MBKMKGABBGE == 6)
		{
			GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(-47, 1, 4));
		}
		if (this.MBKMKGABBGE == 5)
		{
			GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(-69, 2, 6));
		}
		if (this.GCLKLEIMABA == 1)
		{
			GUI.DrawTextureWithTexCoords(new Rect(OCHCODJIPHJ.x - 1914f, OCHCODJIPHJ.y - 1161f, num3, num3), GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(89, 1, 6));
		}
	}

	// Token: 0x060041FE RID: 16894 RVA: 0x001EC490 File Offset: 0x001EA690
	public virtual void MMDMAGMPNGP(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 547f;
		bool flag = !this.GBABFPMNIMP || this.FKEDAOOHPPB.HIPIGDFHLAJ(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH, 1);
		if (this.HHOBCJNGCEL() != null)
		{
			Texture texture = this.PDJBFPOAPBA().MMKLLFCKCAG();
			float num2 = 146f * COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float num4 = (float)texture.height * num2;
			float num5 = (COAGIAMOCIA.height - num4) / 1787f;
			Rect position = new Rect(COAGIAMOCIA.x + num5, COAGIAMOCIA.y + num5, num3, num4);
			if (!flag)
			{
				GUI.enabled = false;
			}
			GUI.DrawTexture(position, GameInterface.getI.invEmptyCell);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(this.KBGHOIJIPJF, 8, 8));
			GUI.DrawTexture(position, texture, ScaleMode.StretchToFill);
			if (this.BPNNJBBCOFO != null)
			{
				BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.EDKKJNHDBPF().NKMGKJLONDK(this.BPNNJBBCOFO.MNFCAAIAGOL.IBEIBAHKIAH);
				if (befchfngomi != null)
				{
					befchfngomi.HKHPGCHCHAI();
					float num6 = num3 * 1797f / 976f;
					GUI.DrawTexture(new Rect(position.x + num3 / 494f - num6, position.y + num3 / 369f - num6, num6 * 1961f, num6 * 1971f), befchfngomi.KEEDCOIMPMP());
				}
			}
			if (this.MBKMKGABBGE == 69)
			{
				float num7 = position.height / 985f;
				Rect position2 = new Rect(position.x + 1020f, position.y + position.height - num7 - 1489f, num7, num7);
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.DJDLJCFCPPH(this.MIMANMPNLPE.KEHIFGILLJA());
				if (kdhoddmndfc != null)
				{
					GUI.DrawTexture(position2, kdhoddmndfc.IJGBOMGCLDK(), ScaleMode.ScaleAndCrop);
				}
			}
			if (this.KBGHOIJIPJF > 1)
			{
				GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.KBGHOIJIPJF + 3, 6, 4));
			}
			float num8 = position.height / 1924f;
			if (this.DNOLHLJODNK)
			{
				float num9 = num8 * 638f;
				GUI.DrawTextureWithTexCoords(new Rect(position.x + position.width - num9 + 261f, position.y - 1093f, num9, num9), GameInterface.getI.wpnImproveIcons, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(this.LNKLEIEFGCP, 2, 8));
			}
			num = num + num3 + 609f;
			GUI.enabled = true;
		}
		if (!flag)
		{
			GUI.color = new Color(1768f, 780f, 1541f, 594f);
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1336f, COAGIAMOCIA.y + 1619f, COAGIAMOCIA.width - 1999f, COAGIAMOCIA.height - 1204f), GuiProcessor.NKOEAPCIBKO().blackWait);
			GUI.color = Color.white;
		}
		int gclkleimaba = this.GCLKLEIMABA;
		string str = "LocationGui.getI is null";
		if (this.HOALBMDJNDM > 0)
		{
			str = "fider drop" + string.Format(JNBICAJIJMM.PGJCPFNJNPM("craft/stanok"), this.HOALBMDJNDM);
		}
		OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
		int fontSize = OFPNEDEAMAB.fontSize;
		OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont3;
		OFPNEDEAMAB.fontSize = 18;
		string text = this.IGDKBMGKKDO(false, -1) + str;
		GUI.Label(new Rect(COAGIAMOCIA.x + 1068f + num, COAGIAMOCIA.y + 1652f, COAGIAMOCIA.width - 1547f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		float num10 = 728f;
		OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont;
		OFPNEDEAMAB.fontSize = -7;
		string text2 = this.DPIHMPDHKBP(false);
		if (text2.Trim() != "error.wav")
		{
			GUI.Label(new Rect(COAGIAMOCIA.x + 1729f + num, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 127f, COAGIAMOCIA.height - num10), text2, OFPNEDEAMAB);
			num10 += 276f;
		}
		else
		{
			num10 += 221f;
		}
		if (this.OPFGGNNPAJL.KEHIFGILLJA() > 1)
		{
			string arg = "demoVector2";
			if (!this.GBABFPMNIMP)
			{
				arg = "#80ff00";
			}
			string text3 = string.Format("<color='#405000'>", BHNDGIPPPCE.IKGFHGKKCPG.CPGLGONDLJM(this.OPFGGNNPAJL.IBEIBAHKIAH), BHNDGIPPPCE.IKGFHGKKCPG.MECJHEKFKKP(this.OPFGGNNPAJL.KEHIFGILLJA(), this.OPFGGNNPAJL.ICJDPPOJINN), arg);
			GUI.Label(new Rect(COAGIAMOCIA.x + 299f + num, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 1187f, COAGIAMOCIA.height - 1084f), text3, OFPNEDEAMAB);
			num10 += 725f;
		}
		if (this.FKEDAOOHPPB.GIEALCKLKNL > 1)
		{
			BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.OELKEADDKPE().LMGMPPAOPEP(this.FKEDAOOHPPB.GIEALCKLKNL);
			befchfngomi2.GDLELABHHFG(new Rect(COAGIAMOCIA.x + 420f + num, COAGIAMOCIA.y + num10 - 1376f, 204f, 1366f), befchfngomi2.KBGHOIJIPJF, true, 0);
			Rect position3 = new Rect(COAGIAMOCIA.x + 1244f + num + 311f, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 741f, COAGIAMOCIA.height - 744f);
			object[] array = new object[8];
			array[0] = "reflectQuality";
			array[0] = this.FKEDAOOHPPB.KDIMEMOCJNM;
			array[0] = "\n<color='";
			array[1] = befchfngomi2.CGMGBGABLFB(true, -1);
			GUI.Label(position3, string.Concat(array), OFPNEDEAMAB);
			num10 += 940f;
		}
		else
		{
			num10 += 1160f;
		}
		if (this.FKEDAOOHPPB.KKNEKAEJLAM + this.FKEDAOOHPPB.KFODJJIHNHP > 1)
		{
			string text4 = string.Format("4", JLFJEGIPIMM.MHFDIJGJGBJ().OHNLAOJGCGC((long)this.FKEDAOOHPPB.KKNEKAEJLAM, (long)this.FKEDAOOHPPB.KFODJJIHNHP, false));
			OFPNEDEAMAB.alignment = TextAnchor.MiddleCenter;
			OFPNEDEAMAB.fontSize = 50;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 849f, COAGIAMOCIA.height - 1247f), text4, OFPNEDEAMAB);
		}
		OFPNEDEAMAB.fontSize = fontSize;
	}

	// Token: 0x060041FF RID: 16895 RVA: 0x001ECB24 File Offset: 0x001EAD24
	public override int HGFLLGHHJML(ItemBase MBKPMBPLIJN)
	{
		int result = 0;
		BEFCHFNGOMI befchfngomi = (BEFCHFNGOMI)MBKPMBPLIJN;
		if (this.PCFNDIFLIHC() < befchfngomi.PCFNDIFLIHC())
		{
			result = -1;
		}
		if (this.PCFNDIFLIHC() > befchfngomi.PCFNDIFLIHC())
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x06004200 RID: 16896 RVA: 0x001E28F1 File Offset: 0x001E0AF1
	public virtual CKNLPGEPGGF.IAPCJOBDCEH GCLHFHNKONE()
	{
		return this.OLNGOHEPLBO;
	}

	// Token: 0x06004201 RID: 16897 RVA: 0x001ECB5C File Offset: 0x001EAD5C
	public string DOANOCEHLPI(bool EFLPJHMLOOA = true)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("WorkerShovel");
		int num = this.MBKMKGABBGE;
		if (this.MBKMKGABBGE == 101)
		{
			stringBuilder.Append(" ?");
			if (this.JALOCNOIDFJ > 0)
			{
				num = this.JALOCNOIDFJ;
			}
		}
		switch (num)
		{
		case 0:
		{
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.MIMANMPNLPE, 1);
			string text = JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)num2);
			if (this.OKHPDILIOCH.Count > 1)
			{
				text = "Idle Sad Hips";
				foreach (int jjjnkodleel in this.OKHPDILIOCH)
				{
					num2 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.MIMANMPNLPE, jjjnkodleel);
					text = text + JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)num2) + "CrouchStrafeLeft";
				}
				text = text.Remove(text.Length - 1);
			}
			stringBuilder.Append(string.Format(JNBICAJIJMM.LPHMKPDBMPP().ECNKLECOKHD("_VignetteCenter"), JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.MIMANMPNLPE.DHJBAKDAMGH())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("0"), JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.MIMANMPNLPE.OIGIHEPJFFJ()), text));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LPHMKPDBMPP().NLJOLOBPCBJ("RGBA("), JLFJEGIPIMM.MHFDIJGJGBJ().AHEHNKFHGOC(this.MIMANMPNLPE.GJBKBEEJLDF() / 1058.0)));
			string text2 = "wpn_eat4";
			if (this.ADOFHHCDGON > 1)
			{
				object[] array = new object[0];
				array[0] = text2;
				array[0] = "CratePush";
				array[4] = JNBICAJIJMM.IKGFHGKKCPG.CKAOHMEKLMH("Katana Upper Block");
				array[5] = " ";
				array[2] = this.ADOFHHCDGON;
				array[8] = "FlyLeft";
				text2 = string.Concat(array);
			}
			if (this.ECKKCDKHNEH > 1)
			{
				object[] array2 = new object[6];
				array2[1] = text2;
				array2[1] = "ExceptionOnConnect PROCEDURE ";
				array2[1] = JNBICAJIJMM.IKGFHGKKCPG.NLJOLOBPCBJ("SneakLeft");
				array2[5] = "---";
				array2[6] = this.ECKKCDKHNEH;
				array2[1] = "id";
				text2 = string.Concat(array2);
			}
			if (text2 != "act_orderb_")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.IMLLGEMPHAP().CKAOHMEKLMH("CratePush"), text2));
			}
			stringBuilder.Append(string.Format("t_lashes" + JNBICAJIJMM.APMJBBDBOJO().CCFFMKBBKHI("WATER_VERTEX_DISPLACEMENT_ON") + "-H", this.FJJEAMJNLIO));
			break;
		}
		case 1:
		{
			float num3 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.MIMANMPNLPE, 1);
			stringBuilder.Append(string.Format(JNBICAJIJMM.EDKGBBIIBBC().ECNKLECOKHD("\n"), JLFJEGIPIMM.MHFDIJGJGBJ().CJGLGGEGPJL(this.MIMANMPNLPE.DHJBAKDAMGH())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.EEOPOHEALPK().CKAOHMEKLMH("shop_t14"), JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.MIMANMPNLPE.OIGIHEPJFFJ()), JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL((double)num3)));
			string text3 = "";
			if (this.ADOFHHCDGON > 1)
			{
				object[] array3 = new object[8];
				array3[1] = text3;
				array3[1] = "";
				array3[0] = JNBICAJIJMM.LPHMKPDBMPP().HEIBEHAEHBM("OfficeSitting");
				array3[0] = "Atmosphere reference not set.";
				array3[2] = this.ADOFHHCDGON;
				array3[8] = "wpn_rod1";
				text3 = string.Concat(array3);
			}
			if (this.ECKKCDKHNEH > 0)
			{
				object[] array4 = new object[]
				{
					text3
				};
				array4[0] = "_BloomTex";
				array4[1] = JNBICAJIJMM.EKEBHIJMEML().HLBAJBLHLNI("auk_swtcost");
				array4[7] = "IKSolverLookAt head transform is null. Can't initiate solver.";
				array4[6] = this.ECKKCDKHNEH;
				array4[7] = "_BlurredColor";
				text3 = string.Concat(array4);
			}
			if (text3 != "BAG")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.IKGFHGKKCPG.CCFFMKBBKHI("Lasso"), text3));
			}
			stringBuilder.Append(string.Format("UnityEngine.Color" + JNBICAJIJMM.CLIMNFDGOEG().HLBAJBLHLNI("#> _Planar Reflection Camera < ") + "LDR", this.FJJEAMJNLIO));
			break;
		}
		case 2:
		{
			float num4 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.MIMANMPNLPE, 0);
			stringBuilder.Append(string.Format(JNBICAJIJMM.EEOPOHEALPK().DOEMGEAEBPN("forSex"), JLFJEGIPIMM.IKGFHGKKCPG.AHEHNKFHGOC(this.MIMANMPNLPE.DHJBAKDAMGH())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.APMJBBDBOJO().CKAOHMEKLMH("IdleKeepBack"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH), JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL((double)num4)));
			string text4 = "Missing shader in ";
			if (this.ADOFHHCDGON > 1)
			{
				object[] array5 = new object[5];
				array5[1] = text4;
				array5[0] = "\n";
				array5[2] = JNBICAJIJMM.CLIMNFDGOEG().NLJOLOBPCBJ("MotorbikeSeatStand");
				array5[8] = "Toggle";
				array5[3] = this.ADOFHHCDGON;
				array5[4] = "OfficeSittingReading";
				text4 = string.Concat(array5);
			}
			if (this.ECKKCDKHNEH > 0)
			{
				object[] array6 = new object[8];
				array6[0] = text4;
				array6[0] = "droprodmsg1";
				array6[5] = JNBICAJIJMM.IMLLGEMPHAP().HLBAJBLHLNI("_Axis");
				array6[4] = "Elbow";
				array6[6] = this.ECKKCDKHNEH;
				array6[2] = "Flashlight";
				text4 = string.Concat(array6);
			}
			if (text4 != "Mouse Y")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.DBMJJPBOPEK().ECNKLECOKHD("_Contrast"), text4));
			}
			stringBuilder.Append(string.Format("TOD_MoonSkyColor" + JNBICAJIJMM.EEOPOHEALPK().DOEMGEAEBPN("RenderType") + "IdleBandage", this.FJJEAMJNLIO));
			break;
		}
		case 3:
		{
			stringBuilder.Append(JNBICAJIJMM.CELEPPAEKAB("_FogDownsampled") + "SkateboardKickPush" + JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.MIMANMPNLPE.DHJBAKDAMGH()) + "Hidden/Image Effects/Cinematic/AmbientOcclusion");
			stringBuilder.Append(JNBICAJIJMM.CDDCIKKDFMP("cht_msg27") + "Transparent/Diffuse" + JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.MIMANMPNLPE.NMKCBJKHBOH) + "_VignetteColor");
			string str = JNBICAJIJMM.DIOJFJMOPJO("");
			if (this.MIMANMPNLPE.NFCDJLJNDLO() > 0)
			{
				str = JNBICAJIJMM.IMLLGEMPHAP().ECNKLECOKHD("OneHandSwordBlock") + "" + JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)(this.MIMANMPNLPE.FJACMDGJEBL() * 1814.0));
			}
			stringBuilder.Append(JNBICAJIJMM.CDDCIKKDFMP("linebreak.ogg") + "L" + str + "LDR");
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("MotorbikeTurnRight") + "SAMPLES_HIGH", this.LHLMFBEJKGL(1177f)));
			string jmbkdinhdlo = "WizardBlock";
			if (Mathf.Abs(this.MFMLCHFNALC) > 356f)
			{
				if (this.MFMLCHFNALC > 1784f)
				{
					jmbkdinhdlo = "_ScaleOffsetRes";
				}
				if (this.MFMLCHFNALC < 1959f)
				{
					jmbkdinhdlo = "wpn_chair3";
				}
			}
			stringBuilder.Append("name" + string.Format(JNBICAJIJMM.LEBHCLDODNI("_Offsets"), JNBICAJIJMM.PPNKMDJBMLP(jmbkdinhdlo)));
			break;
		}
		case 4:
		{
			Vector2 vector = this.FBOLDPBDMCD();
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("<.*?>") + "", JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.MIMANMPNLPE.AIMCFAHLPEF())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("ComeHere" + this.ILOCKJIAPFC) + "_Bloom", 0));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("gi_um_nosel") + "I LOVE MY GIRLz", JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.MIMANMPNLPE.NMKCBJKHBOH)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("Fishing") + "adjust", JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.MIMANMPNLPE.HDPNCIECLKP())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("_Rand") + "Loot", JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)Mathf.RoundToInt(vector.x * 1467f)), JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)Mathf.RoundToInt(vector.y * 1097f))));
			break;
		}
		case 5:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("_InverseProj") + "Weapon Fire", JLFJEGIPIMM.NNEAHAFBOHC().DIOCHACFPHJ(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("") + "shop_t7", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.DHJBAKDAMGH())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DCEBAJIILPC("RollerBlade") + "SneakIdle", JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL((double)this.MIMANMPNLPE.KMGAHCANELI())));
			if (this.MIMANMPNLPE.HDPNCIECLKP() > 1792.0)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("KatanaReadyLow") + "SecondaryCausticsProjector", JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.MIMANMPNLPE.FJACMDGJEBL())));
			}
			IIBEEKCAAHK iibeekcaahk = JLFJEGIPIMM.MHFDIJGJGBJ().NHHPCBNKCPO(this.MIMANMPNLPE.NLHKFMMDMMK());
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO(" гр "), JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)iibeekcaahk.KMIOLLENCOL()), JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)iibeekcaahk.KMGAHCANELI())));
			break;
		}
		case 6:
			stringBuilder.Append(string.Format(JNBICAJIJMM.NGALDMFKMJH("_rcpFrameOpt") + "_FogOfWarCenterAdjusted", JLFJEGIPIMM.IKGFHGKKCPG.MIEDNDLOEJH(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DCEBAJIILPC("StrafeRunLeft") + "error.wav", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("ElvisLegsLoop") + "OfficeSittingReading", JLFJEGIPIMM.MHFDIJGJGBJ().CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("Idle180") + "_NoiseTex", JLFJEGIPIMM.MHFDIJGJGBJ().CJGLGGEGPJL(this.MIMANMPNLPE.GJBKBEEJLDF())));
			break;
		case 7:
			stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("eye") + "IdleMeditate", JLFJEGIPIMM.MHFDIJGJGBJ().DIOCHACFPHJ(this.NKHBAJKMAGD)));
			break;
		case 8:
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("Put Out Cigarette") + "CHAT Empty", JLFJEGIPIMM.IKGFHGKKCPG.MIEDNDLOEJH(this.NKHBAJKMAGD)));
			if (this.JJCFHNLNBCJ("Trying to use the 'Goal' Bend Modifier, but the Bend Goal is unassigned.", "ShotgunReloadChamber").DGEEJKEEHPE())
			{
				stringBuilder.Append(JNBICAJIJMM.DCEBAJIILPC("Text node is empy!"));
			}
			break;
		case 9:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.DCEBAJIILPC("lifeBar") + "gameComplete", JLFJEGIPIMM.IKGFHGKKCPG.AHEHNKFHGOC(this.MIMANMPNLPE.AIMCFAHLPEF())));
			string str2 = JNBICAJIJMM.DIOJFJMOPJO("[ACTk] Obscured Cheating Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!" + this.MIMANMPNLPE.KMGAHCANELI());
			stringBuilder.Append(str2 + "WizardPowerUp");
			stringBuilder.Append(string.Format(JNBICAJIJMM.NGALDMFKMJH("Vector3:"), JLFJEGIPIMM.IKGFHGKKCPG.MIEDNDLOEJH(this.NKHBAJKMAGD)));
			break;
		}
		case 10:
			stringBuilder.Append(string.Format(JNBICAJIJMM.NGALDMFKMJH("") + "Fishing", JLFJEGIPIMM.NNEAHAFBOHC().PEGPHIOEKHI(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM(""), JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.MIMANMPNLPE.AIMCFAHLPEF())));
			break;
		case 11:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("CP1") + "StartTests", JLFJEGIPIMM.NNEAHAFBOHC().BIJHHFGLDLH(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("1HandSwordJabCombo"), JLFJEGIPIMM.NNEAHAFBOHC().AHEHNKFHGOC(this.MIMANMPNLPE.LNEPKLKELMI)) + "popl.ogg");
			int ilockjiapfc = this.ILOCKJIAPFC;
			if (ilockjiapfc == 2)
			{
				stringBuilder.Append(JNBICAJIJMM.PPNKMDJBMLP("_MainTex") + "ColorBleedAmount" + string.Format(JNBICAJIJMM.OOOKJHOHPNN("No MeshFilter!"), this.GLLIKKONFAJ) + " ");
			}
			if (ilockjiapfc > 0)
			{
				string jmbkdinhdlo2 = string.Format("CHAT Empty", ilockjiapfc);
				stringBuilder.Append("WeaponStrafeRunLeft" + JNBICAJIJMM.PPNKMDJBMLP(jmbkdinhdlo2) + "level");
			}
			break;
		}
		case 15:
			stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("Wizard Overhead") + "hand", JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.MIMANMPNLPE.KEHIFGILLJA())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("Tonemapper curve texture") + "ObscuredUShort vs ushort, ", this.MIMANMPNLPE.NLHKFMMDMMK()));
			break;
		case 20:
			if (this.MIMANMPNLPE.IBEIBAHKIAH != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.KEHIFGILLJA() > 1) ? string.Format(JNBICAJIJMM.BDKHMOOFHHK("_Distortion"), this.MIMANMPNLPE.IBEIBAHKIAH) : string.Format(JNBICAJIJMM.NGALDMFKMJH("Show last 128 records"), Mathf.Abs(this.MIMANMPNLPE.KMIOLLENCOL())));
			}
			if (this.MIMANMPNLPE.ICJDPPOJINN != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.ICJDPPOJINN > 1) ? string.Format(JNBICAJIJMM.DCEBAJIILPC("En"), this.MIMANMPNLPE.KMGAHCANELI()) : string.Format(JNBICAJIJMM.OOOKJHOHPNN(""), Mathf.Abs(this.MIMANMPNLPE.ICJDPPOJINN)));
			}
			if (this.MIMANMPNLPE.CJKILDPJCFJ() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NFCDJLJNDLO() > 0) ? string.Format(JNBICAJIJMM.NGALDMFKMJH("|"), this.MIMANMPNLPE.NODLBGKEGPM) : string.Format(JNBICAJIJMM.PPNKMDJBMLP("GiantGrabIdle2"), Mathf.Abs(this.MIMANMPNLPE.CJKILDPJCFJ())));
			}
			break;
		case 21:
			if (this.MIMANMPNLPE.NKEOCCKEOCE() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.KMIOLLENCOL() > 0) ? string.Format(JNBICAJIJMM.CELEPPAEKAB("{not_found}"), this.MIMANMPNLPE.IBEIBAHKIAH) : string.Format(JNBICAJIJMM.DIOJFJMOPJO("Katana 45Deg Swing"), Mathf.Abs(this.MIMANMPNLPE.KEHIFGILLJA())));
			}
			if (this.MIMANMPNLPE.ICJDPPOJINN != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.ICJDPPOJINN > 1) ? string.Format(JNBICAJIJMM.PPNKMDJBMLP("finger"), this.MIMANMPNLPE.KMGAHCANELI()) : string.Format(JNBICAJIJMM.DCEBAJIILPC("cond"), Mathf.Abs(this.MIMANMPNLPE.KMGAHCANELI())));
			}
			if (this.MIMANMPNLPE.CJKILDPJCFJ() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NODLBGKEGPM > 1) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("WizardOverhead"), this.MIMANMPNLPE.NODLBGKEGPM) : string.Format(JNBICAJIJMM.DCEBAJIILPC("BowReady"), Mathf.Abs(this.MIMANMPNLPE.CJKILDPJCFJ())));
			}
			break;
		case 22:
			if (this.MIMANMPNLPE.KEHIFGILLJA() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NKEOCCKEOCE() > 1) ? string.Format(JNBICAJIJMM.BDKHMOOFHHK("Missing shader in "), this.MIMANMPNLPE.KMIOLLENCOL()) : string.Format(JNBICAJIJMM.NGALDMFKMJH("Game saved with regular PlayerPrefs. Try to find and change saved data now (it's easy)!"), Mathf.Abs(this.MIMANMPNLPE.KEHIFGILLJA())));
			}
			if (this.MIMANMPNLPE.ICJDPPOJINN != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NLHKFMMDMMK() > 1) ? string.Format(JNBICAJIJMM.CELEPPAEKAB("Sonar_pos"), this.MIMANMPNLPE.NLHKFMMDMMK()) : string.Format(JNBICAJIJMM.CELEPPAEKAB("Animator unassigned in AnimationWarping"), Mathf.Abs(this.MIMANMPNLPE.ICJDPPOJINN)));
			}
			if (this.MIMANMPNLPE.NODLBGKEGPM != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NFCDJLJNDLO() > 0) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("KatanaReady"), this.MIMANMPNLPE.CJKILDPJCFJ()) : string.Format(JNBICAJIJMM.CDDCIKKDFMP("IdleMouthWipe"), Mathf.Abs(this.MIMANMPNLPE.NODLBGKEGPM)));
			}
			break;
		case 27:
		{
			CLFFOBKFKDN.OKOAMCJGNMH okoamcjgnmh = CLFFOBKFKDN.GAPIOPHMBNB().GNHIKHCEOHK(this.MIMANMPNLPE.KMGAHCANELI());
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().IMCJNFHAFGE(okoamcjgnmh.MNFCAAIAGOL.NKEOCCKEOCE());
			if (befchfngomi != null && this.BPNNJBBCOFO != null)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("Invalid vertex colors assigned to "), befchfngomi.IGDKBMGKKDO(false, -1), this.BPNNJBBCOFO.MNFCAAIAGOL.ICJDPPOJINN));
				stringBuilder.Append((this.MIMANMPNLPE.CJKILDPJCFJ() < 1) ? JNBICAJIJMM.CDDCIKKDFMP("FlyBackward") : string.Format(JNBICAJIJMM.CELEPPAEKAB("4096"), this.MIMANMPNLPE.CJKILDPJCFJ()));
				stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("Pointing"), CLFFOBKFKDN.GAPIOPHMBNB().MMPOGPAOMIF(this.BPNNJBBCOFO.BKLCKNOLEFD)));
				stringBuilder.Append("CardPlayerIdle");
				string text5 = "process Action";
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.BPNNJBBCOFO.ABLFIGDGCBG);
				if (kdhoddmndfc != null)
				{
					text5 += kdhoddmndfc.FLFHIHINAFL(this.BPNNJBBCOFO.LKCIDOHHADJ);
					string arg = "wpn_bait_typ_{0}";
					if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.FOACIAGMAPD(this.BPNNJBBCOFO.ABLFIGDGCBG) < this.BPNNJBBCOFO.LKCIDOHHADJ)
					{
						arg = "Neck";
					}
					stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("How your lives count is stored in memory when obscured:\n"), arg, text5));
				}
			}
			break;
		}
		case 31:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.PPNKMDJBMLP("setCurrentRod sm (профиль)="), this.MIMANMPNLPE.AIMCFAHLPEF()));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("IdleStandingJump"), this.MIMANMPNLPE.NMKCBJKHBOH));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO("_OcclusionTexture2"), this.MIMANMPNLPE.KCKFCPIHMPC()));
			List<int> list = this.JJCFHNLNBCJ("Zombie Walk", "_isSelect").EDAHDHCPIEL;
			string text6 = JNBICAJIJMM.PGJCPFNJNPM("Palm") + "SatNightFever";
			foreach (int lpfkfnlhgbi in list)
			{
				text6 = text6 + IHFEDJEMJMB.JHAAMBEFENP().OLHFAPEPJLK(lpfkfnlhgbi) + "_Intensity";
			}
			stringBuilder.Append(text6);
			break;
		}
		case 32:
			stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("stretchWidth"), this.MIMANMPNLPE.LNEPKLKELMI));
			stringBuilder.Append(string.Format(JNBICAJIJMM.PPNKMDJBMLP(" "), this.MIMANMPNLPE.OIGIHEPJFFJ()));
			break;
		case 33:
		{
			int num5 = this.MIMANMPNLPE.KEHIFGILLJA();
			NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc2 = NLNNIDBPKAO.IKGFHGKKCPG.KOHGDDAADCP(num5);
			if (kdhoddmndfc2 != null)
			{
				bool flag = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GADJFFGDCFA.ContainsKey(num5);
				stringBuilder.Append(flag ? string.Format(JNBICAJIJMM.CDDCIKKDFMP("\n"), kdhoddmndfc2.KKEBDLGHBMN) : string.Format(JNBICAJIJMM.NGALDMFKMJH(" <b>®</b></color>  "), kdhoddmndfc2.KKEBDLGHBMN));
			}
			break;
		}
		case 35:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.DCEBAJIILPC("Jump"), this.MIMANMPNLPE.NMKCBJKHBOH) + "Quadruped");
			string jmbkdinhdlo3 = "1HSwordStrafeRunRight";
			if (this.MIMANMPNLPE.FJACMDGJEBL() > 1595.0)
			{
				jmbkdinhdlo3 = "StrafeRunLeft";
			}
			stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN(jmbkdinhdlo3), this.MIMANMPNLPE.FJACMDGJEBL()));
			break;
		}
		}
		if (this.DNOLHLJODNK)
		{
			stringBuilder.Append(JNBICAJIJMM.OOOKJHOHPNN("WaveSpeed"));
		}
		string text7 = "MotorbikeSpecialFlip" + stringBuilder + "ThisRenderer.bones[i].name is null";
		stringBuilder = new StringBuilder();
		if (this.MBOOFLANJID != 0)
		{
			bool flag2 = false;
			if (this.MBOOFLANJID == 1 && JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.GDJMBFGEMFJ != 1)
			{
				flag2 = true;
			}
			if (this.MBOOFLANJID == 1 && JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.GDJMBFGEMFJ != 0)
			{
				flag2 = false;
			}
			string arg2 = "WeaponStrafeRunRight";
			if (flag2)
			{
				arg2 = ", ";
			}
			if (this.MBOOFLANJID == 1)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("\n<color='") + "[curcnt]", arg2));
			}
			if (this.MBOOFLANJID == 3)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.PPNKMDJBMLP("Walk Backward") + "WorkerHammer2", arg2));
			}
		}
		string text8 = text7;
		if (!EFLPJHMLOOA)
		{
			text8 = Regex.Replace(text8, "Transforms is null.", string.Empty);
		}
		return text8;
	}

	// Token: 0x06004202 RID: 16898 RVA: 0x001EE1F4 File Offset: 0x001EC3F4
	public long PCFNDIFLIHC()
	{
		return (long)(this.HPEFEFIIHOE * 3000000 + this.FKEDAOOHPPB.KKNEKAEJLAM * 1000 + this.FKEDAOOHPPB.KFODJJIHNHP);
	}

	// Token: 0x06004203 RID: 16899 RVA: 0x001EE221 File Offset: 0x001EC421
	public Texture PPKGANBDAFO()
	{
		if (this.EOFDJHJPCLM == null)
		{
			return null;
		}
		return this.EOFDJHJPCLM.AEIIBNOFLCM();
	}

	// Token: 0x06004204 RID: 16900 RVA: 0x001EE238 File Offset: 0x001EC438
	public void MEPJIKIPDHD(Rect PHEMLBHMNCM, float NMBCJPACKNL, IIBEEKCAAHK INEBGELANOI, IIBEEKCAAHK CKGEBHECNBF, IIBEEKCAAHK ABJAMKHMONL, int ILFHHDNJHNM = 0)
	{
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 66,
			wordWrap = true,
			font = GuiProcessor.NKOEAPCIBKO().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = true,
			alignment = TextAnchor.MiddleCenter
		};
		Rect ochcodjiphj = new Rect(PHEMLBHMNCM.x + 1034f, PHEMLBHMNCM.y + 21f, 1468f, 59f);
		this.FCBHHPJLGLC(ochcodjiphj, this.KBGHOIJIPJF, false, 0);
		GUILayout.BeginArea(new Rect(ochcodjiphj.x + 1239f, ochcodjiphj.y, PHEMLBHMNCM.width - 851f, 1386f));
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		try
		{
			guistyle.fontSize = 34;
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			GUILayout.Label(this.BNIHFBMEPAB, guistyle, Array.Empty<GUILayoutOption>());
			guistyle.fontSize = -48;
			guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
			GUILayout.Label("Multiple Sunshine Instances detected!", guistyle, Array.Empty<GUILayoutOption>());
			GUILayout.Label(IHFEDJEMJMB.IKGFHGKKCPG.AGELAMIPPAJ(this.MBKMKGABBGE) ?? "craft_time", guistyle, Array.Empty<GUILayoutOption>());
			guistyle.fontSize = 8;
			if (ILFHHDNJHNM == 0)
			{
				int hoalbmdjndm = this.HOALBMDJNDM;
			}
		}
		finally
		{
			GUILayout.EndVertical();
			GUILayout.EndArea();
		}
		GUILayout.BeginArea(new Rect(ochcodjiphj.x + 459f, ochcodjiphj.y + 1105f, PHEMLBHMNCM.width - 842f, PHEMLBHMNCM.height - 1679f));
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		try
		{
			int negehagngbh = this.NEGEHAGNGBH;
			float nkhbajkmagd = this.NKHBAJKMAGD;
			this.NEGEHAGNGBH += (int)((float)(INEBGELANOI.PBMJIMLEHEC() + CKGEBHECNBF.ACEPOCLANAG() + ABJAMKHMONL.LKAGIEBPLAI) * NMBCJPACKNL);
			this.NKHBAJKMAGD += (float)(INEBGELANOI.MCJJCAFILPF() + CKGEBHECNBF.ACEPOCLANAG() + ABJAMKHMONL.KIDKOFKNPEP()) * 1412f * this.NKHBAJKMAGD;
			IIBEEKCAAHK mimanmpnlpe = new IIBEEKCAAHK(this.MIMANMPNLPE.LNEPKLKELMI, this.MIMANMPNLPE.OIGIHEPJFFJ(), this.MIMANMPNLPE.FJACMDGJEBL());
			IIBEEKCAAHK mimanmpnlpe2 = this.MIMANMPNLPE;
			mimanmpnlpe2.KBIOCGCIGEH(mimanmpnlpe2.LNEPKLKELMI + INEBGELANOI.DBFOHFDOCIB() * (double)INEBGELANOI.KMNOIAIBLEB());
			this.MIMANMPNLPE.NMKCBJKHBOH += CKGEBHECNBF.KCKFCPIHMPC() * (double)CKGEBHECNBF.LKAGIEBPLAI;
			IIBEEKCAAHK mimanmpnlpe3 = this.MIMANMPNLPE;
			mimanmpnlpe3.MKOBCGPJMHA(mimanmpnlpe3.DBFOHFDOCIB() + ABJAMKHMONL.NKGGAFLBFDF * (double)ABJAMKHMONL.LKAGIEBPLAI);
			GUILayout.Label(this.IOAGBIACCHA(true), guistyle, Array.Empty<GUILayoutOption>());
			if (this.MHNDPGDBPNA.Count > 1)
			{
				GUILayout.Label(" ", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("impfail", guistyle, Array.Empty<GUILayoutOption>());
				foreach (IIBEEKCAAHK iibeekcaahk in this.MHNDPGDBPNA)
				{
					string text = iibeekcaahk.ToString();
					if (iibeekcaahk.IBEIBAHKIAH == 1)
					{
						string arg = AKPJIACDDFI.IKGFHGKKCPG.LNDAPLCMEJI(iibeekcaahk.ICJDPPOJINN, true);
						if (iibeekcaahk.CJKILDPJCFJ() > 0)
						{
							text = string.Format("UnityEngine.GameObject", iibeekcaahk.NODLBGKEGPM, arg);
						}
						else
						{
							text = string.Format("_BlurRadius4", iibeekcaahk.CJKILDPJCFJ(), arg);
						}
					}
					if (iibeekcaahk.KEHIFGILLJA() == 5)
					{
						string arg2 = AKPJIACDDFI.IKGFHGKKCPG.PCONBNOAMBH(iibeekcaahk.ICJDPPOJINN);
						if (iibeekcaahk.CJKILDPJCFJ() > 1)
						{
							text = string.Format("null", iibeekcaahk.NFCDJLJNDLO(), arg2);
						}
						else
						{
							text = string.Format("error.wav", iibeekcaahk.NFCDJLJNDLO(), arg2);
						}
					}
					GUILayout.Label(text, guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.Label("crft_btn2", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("_Refraction", guistyle, Array.Empty<GUILayoutOption>());
			}
			if (this.NEGEHAGNGBH > 0 || this.PKIICJOILKI.Count > 0)
			{
				GUILayout.Label(JNBICAJIJMM.PGJCPFNJNPM("{0}\n{1}"), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("_MotionAmount", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("IK Effector is referencing to a bone '", guistyle, Array.Empty<GUILayoutOption>());
				if (this.NEGEHAGNGBH > 0)
				{
					string arg3 = "<color='#206000'>";
					if (this.NEGEHAGNGBH > ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.CNOLCNDBLJE))
					{
						arg3 = "Idle Standing Jump";
					}
					GUILayout.Label(string.Format(JNBICAJIJMM.CDDCIKKDFMP("GiantGrabThrow"), arg3, this.NEGEHAGNGBH), guistyle, Array.Empty<GUILayoutOption>());
					GUILayout.Label("IdleFight", guistyle, Array.Empty<GUILayoutOption>());
				}
				if (this.PKIICJOILKI.Count > 0)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.PKIICJOILKI)
					{
						bool flag = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI) < dlmglijdiai.CNOLCNDBLJE;
						string arg4 = "Occluder Shader Missing...";
						if (flag)
						{
							arg4 = " for vert ";
						}
						string text2 = string.Format(" <b>®</b></color>  ", arg4, dlmglijdiai.BDHHPAEHFHG.OBOKLCHDOGM(dlmglijdiai.CNOLCNDBLJE));
						if (!flag)
						{
							GUI.color = new Color(1669f, 1660f, 1839f);
						}
						GUILayout.Box(dlmglijdiai.BDHHPAEHFHG.IJGBOMGCLDK(), GuiProcessor.BBLINJLBAIL().ico24Style, Array.Empty<GUILayoutOption>());
						GUI.color = Color.white;
						GUILayout.Label(text2, guistyle, Array.Empty<GUILayoutOption>());
					}
					GUILayout.EndHorizontal();
				}
				GUILayout.Label("IdleReady", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("17", guistyle, Array.Empty<GUILayoutOption>());
			}
			this.MIMANMPNLPE = mimanmpnlpe;
			this.NEGEHAGNGBH = negehagngbh;
			this.NKHBAJKMAGD = nkhbajkmagd;
			if (this.FGJIJFNGAIF.Count > 0)
			{
				GUILayout.Label(JNBICAJIJMM.PGJCPFNJNPM("32"), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("_MainTex", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
				foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai2 in this.FGJIJFNGAIF)
				{
					bool flag2 = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai2.LPFKFNLHGBI) > 0;
					string arg5 = "\\StreamingAssets\\Quest\\Lang\\";
					if (flag2)
					{
						arg5 = "KatanaNinjaDraw";
					}
					string text3 = string.Format("Attempting to remove texture that was not allocated: {0}", arg5, dlmglijdiai2.BDHHPAEHFHG.KKEBDLGHBMN, dlmglijdiai2.CNOLCNDBLJE);
					if (!flag2)
					{
						GUI.color = Color.gray;
					}
					GUILayout.Box(dlmglijdiai2.BDHHPAEHFHG.IJGBOMGCLDK(), GuiProcessor.IKGFHGKKCPG.ico24Style, Array.Empty<GUILayoutOption>());
					GUI.color = Color.white;
					GUILayout.Label(text3, guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.EndHorizontal();
				GUILayout.Label("_SunColor", guistyle, Array.Empty<GUILayoutOption>());
			}
			XmlNodeList xmlNodeList = this.LMKLPODNLFC.SelectNodes("IK Effector is referencing to a bone '");
			if (xmlNodeList != null && xmlNodeList.Count > 1)
			{
				guistyle.alignment = TextAnchor.LowerLeft;
				GUILayout.Label(JNBICAJIJMM.BDKHMOOFHHK("Cloth_07.wav"), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("id", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
				foreach (object obj in xmlNodeList)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.Name == "MotorbikeBackwardStand")
					{
						if (xmlNode.Attributes == null)
						{
							continue;
						}
						int lpfkfnlhgbi = int.Parse(xmlNode.Attributes["Walk Backward"].Value);
						IIBEEKCAAHK pgedldmlbbe = new IIBEEKCAAHK(xmlNode.Attributes["Flap_08.wav"].Value);
						int cgnljcomfac = int.Parse(xmlNode.Attributes["wpn_bait_vob_1"].Value);
						FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = FlyMessageManager.getI.KOAGOPCNBIP(lpfkfnlhgbi);
						if (ngiaaohfnpo != null)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							GUILayout.Box(ngiaaohfnpo.CFFHIODOGCH.AEIIBNOFLCM(), GuiProcessor.PLGADNLAEGN().ico24Style, Array.Empty<GUILayoutOption>());
							GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
							GUILayout.Label(string.Format("http://j.mp/1FRAL5L", ngiaaohfnpo.KKNLJIGDNGF(pgedldmlbbe), JLFJEGIPIMM.PKGMBFEMKGP().LOEFBMIDABP(cgnljcomfac)), GuiProcessor.BBLINJLBAIL().textLayoutStyle, Array.Empty<GUILayoutOption>());
							GUILayout.Label(ngiaaohfnpo.CHGBKFCOMBB(pgedldmlbbe), GuiProcessor.PLGADNLAEGN().textLayoutStyle, Array.Empty<GUILayoutOption>());
							GUILayout.EndVertical();
							GUILayout.EndHorizontal();
						}
					}
					GUILayout.Label("LH", guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.EndVertical();
			}
			GUILayout.Label("wpn_rod4" + this.JCKHDHGIEEB + "_NeutralTonemapperParams2", guistyle, Array.Empty<GUILayoutOption>());
			if (this.MBKMKGABBGE == 4)
			{
				CLFFOBKFKDN.OKOAMCJGNMH okoamcjgnmh = CLFFOBKFKDN.JDELMFDJFNC().GNHIKHCEOHK(this.MIMANMPNLPE.ICJDPPOJINN);
				if (IHFEDJEMJMB.AGCBLDIBMNB().LMGMPPAOPEP(okoamcjgnmh.MNFCAAIAGOL.IBEIBAHKIAH) != null && this.BPNNJBBCOFO != null)
				{
					GUILayout.Label("ClimbRight", Array.Empty<GUILayoutOption>());
					GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
					if (this.BPNNJBBCOFO.DGMNCGFAMBL == 1)
					{
						foreach (IIBEEKCAAHK iibeekcaahk2 in this.BPNNJBBCOFO.AGDBFHLEFEE)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().GBKMHIGNKJA(iibeekcaahk2.NKEOCCKEOCE());
							if (befchfngomi != null)
							{
								GUILayout.Box(befchfngomi.KEEDCOIMPMP(), GuiProcessor.PLGADNLAEGN().ico16Style, Array.Empty<GUILayoutOption>());
								GUILayout.Label("Curve" + befchfngomi.CGMGBGABLFB(false, -1), guistyle, Array.Empty<GUILayoutOption>());
							}
							GUILayout.EndHorizontal();
						}
					}
					if (this.BPNNJBBCOFO.DGMNCGFAMBL == 0)
					{
						foreach (CLFFOBKFKDN.HFGDDPAKPBE hfgddpakpbe in this.BPNNJBBCOFO.HEBKGNHIDLK)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							if (hfgddpakpbe.GPJFINFIDLN == 0)
							{
								BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.NNEAHAFBOHC().LMGMPPAOPEP(hfgddpakpbe.PJPOJNNJOCD);
								if (befchfngomi2 != null)
								{
									GUILayout.Box(befchfngomi2.KEEDCOIMPMP(), GuiProcessor.PLGADNLAEGN().ico16Style, Array.Empty<GUILayoutOption>());
									GUILayout.Label("RollerBladeCrossoverRight" + hfgddpakpbe.COLONLEMBEK(), guistyle, Array.Empty<GUILayoutOption>());
								}
							}
							if (hfgddpakpbe.GPJFINFIDLN == 0)
							{
								IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(hfgddpakpbe.PJPOJNNJOCD);
								idchhhedhdc.JDJOBDGKBNL();
								GUILayout.Box(idchhhedhdc.FGLONDNIKKC(1).HONJOFFBOPH(), GuiProcessor.NKOEAPCIBKO().ico16Style, Array.Empty<GUILayoutOption>());
								GUILayout.Label("ObscuredUInt:" + hfgddpakpbe.LGKIGOGNLHM(), guistyle, Array.Empty<GUILayoutOption>());
							}
							GUILayout.EndHorizontal();
						}
					}
					GUILayout.EndVertical();
				}
			}
		}
		finally
		{
			GUILayout.EndVertical();
			GUILayout.EndArea();
		}
	}

	// Token: 0x06004205 RID: 16901 RVA: 0x001EEE2C File Offset: 0x001ED02C
	public string DJMDCNOJIPI(int AFCMJJMBOMA, bool BGNPMOCLIGL = false)
	{
		string result = "Here you can overview common ACTk features and try to cheat something yourself.";
		if (BGNPMOCLIGL)
		{
			switch (AFCMJJMBOMA)
			{
			case 0:
				result = "<color='#003000'>";
				break;
			case 1:
				result = "MaskMaterial";
				break;
			case 2:
				result = "Roller Blade Stop";
				break;
			case 3:
				result = "Pistol Reload";
				break;
			case 4:
				result = "fider_Small_";
				break;
			case 5:
				result = "CrawlIdle";
				break;
			case 6:
				result = "Add random value";
				break;
			}
		}
		else
		{
			switch (AFCMJJMBOMA)
			{
			case 0:
				result = "Shoes";
				break;
			case 1:
				result = "wpn_hook1";
				break;
			case 2:
				result = "sound";
				break;
			case 3:
				result = "baseQuality";
				break;
			case 4:
				result = "";
				break;
			case 5:
				result = "SoccerKeeperDiveStrafeFarRight";
				break;
			case 6:
				result = "IdleMeditate";
				break;
			}
		}
		return result;
	}

	// Token: 0x06004206 RID: 16902 RVA: 0x001EEF04 File Offset: 0x001ED104
	public virtual void DBCCBDCAMII(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 650f;
		bool flag = !this.GBABFPMNIMP || this.FKEDAOOHPPB.LIKMNACOFJE(JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH, 0);
		if (this.PPJOPGPEFGI() != null)
		{
			Texture texture = this.EJJAGEFMHCO().IOHNCGLFGDJ();
			float num2 = 779f * COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float num4 = (float)texture.height * num2;
			float num5 = (COAGIAMOCIA.height - num4) / 1285f;
			Rect position = new Rect(COAGIAMOCIA.x + num5, COAGIAMOCIA.y + num5, num3, num4);
			if (!flag)
			{
				GUI.enabled = false;
			}
			GUI.DrawTexture(position, GameInterface.getI.invEmptyCell);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(this.KBGHOIJIPJF, 5, 5));
			GUI.DrawTexture(position, texture, ScaleMode.ScaleAndCrop);
			if (this.BPNNJBBCOFO != null)
			{
				BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().IMCJNFHAFGE(this.BPNNJBBCOFO.MNFCAAIAGOL.IBEIBAHKIAH);
				if (befchfngomi != null)
				{
					befchfngomi.KEICEAJOGFD();
					float num6 = num3 * 38f / 731f;
					GUI.DrawTexture(new Rect(position.x + num3 / 1196f - num6, position.y + num3 / 545f - num6, num6 * 1177f, num6 * 781f), befchfngomi.CFFHIODOGCH);
				}
			}
			if (this.MBKMKGABBGE == -100)
			{
				float num7 = position.height / 1176f;
				Rect position2 = new Rect(position.x + 273f, position.y + position.height - num7 - 911f, num7, num7);
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.OIHEFMKLDIF(this.MIMANMPNLPE.KMIOLLENCOL());
				if (kdhoddmndfc != null)
				{
					GUI.DrawTexture(position2, kdhoddmndfc.GNMLEPEGCII(), ScaleMode.ScaleAndCrop);
				}
			}
			if (this.KBGHOIJIPJF > 1)
			{
				GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(this.KBGHOIJIPJF + 4, 8, 8));
			}
			float num8 = position.height / 1163f;
			if (this.DNOLHLJODNK)
			{
				float num9 = num8 * 681f;
				GUI.DrawTextureWithTexCoords(new Rect(position.x + position.width - num9 + 901f, position.y - 1387f, num9, num9), GameInterface.getI.wpnImproveIcons, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(this.LNKLEIEFGCP, 3, 4));
			}
			num = num + num3 + 1000f;
			GUI.enabled = true;
		}
		if (!flag)
		{
			GUI.color = new Color(1437f, 1974f, 775f, 832f);
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1148f, COAGIAMOCIA.y + 1458f, COAGIAMOCIA.width - 1212f, COAGIAMOCIA.height - 1151f), GuiProcessor.IKGFHGKKCPG.blackWait);
			GUI.color = Color.white;
		}
		int gclkleimaba = this.GCLKLEIMABA;
		string str = "BowReady2";
		if (this.HOALBMDJNDM > 1)
		{
			str = "Horizontal" + string.Format(JNBICAJIJMM.PPNKMDJBMLP("Loading Error"), this.HOALBMDJNDM);
		}
		OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
		int fontSize = OFPNEDEAMAB.fontSize;
		OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
		OFPNEDEAMAB.fontSize = 74;
		string text = this.LFEJHHMDEHO(true, -1) + str;
		GUI.Label(new Rect(COAGIAMOCIA.x + 1991f + num, COAGIAMOCIA.y + 1206f, COAGIAMOCIA.width - 1228f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		float num10 = 1196f;
		OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont;
		OFPNEDEAMAB.fontSize = 28;
		string text2 = this.DPIHMPDHKBP(false);
		if (text2.Trim() != "ALP=")
		{
			GUI.Label(new Rect(COAGIAMOCIA.x + 1706f + num, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 216f, COAGIAMOCIA.height - num10), text2, OFPNEDEAMAB);
			num10 += 1873f;
		}
		else
		{
			num10 += 1616f;
		}
		if (this.OPFGGNNPAJL.IBEIBAHKIAH > 0)
		{
			string arg = "rollSoundVolume";
			if (!this.GBABFPMNIMP)
			{
				arg = "Bend Constraint is referencing to a bone '";
			}
			string text3 = string.Format("Vertical", BHNDGIPPPCE.IKGFHGKKCPG.BBACDNFKPOH(this.OPFGGNNPAJL.NKEOCCKEOCE()), BHNDGIPPPCE.IKGFHGKKCPG.HDLGMNLFDLB(this.OPFGGNNPAJL.KMIOLLENCOL(), this.OPFGGNNPAJL.ICJDPPOJINN), arg);
			GUI.Label(new Rect(COAGIAMOCIA.x + 173f + num, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 1037f, COAGIAMOCIA.height - 946f), text3, OFPNEDEAMAB);
			num10 += 1758f;
		}
		if (this.FKEDAOOHPPB.GIEALCKLKNL > 0)
		{
			BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.AGCBLDIBMNB().LMGMPPAOPEP(this.FKEDAOOHPPB.GIEALCKLKNL);
			befchfngomi2.GDLELABHHFG(new Rect(COAGIAMOCIA.x + 401f + num, COAGIAMOCIA.y + num10 - 1949f, 1072f, 1717f), befchfngomi2.KBGHOIJIPJF, true, 1);
			Rect position3 = new Rect(COAGIAMOCIA.x + 1162f + num + 1224f, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 1862f, COAGIAMOCIA.height - 1225f);
			object[] array = new object[5];
			array[1] = "The 'color' command requires a color parameter of RRGGBBAA or '?'.";
			array[0] = this.FKEDAOOHPPB.KDIMEMOCJNM;
			array[6] = "_ClipToWorld";
			array[8] = befchfngomi2.JPBOPFNPNHC(true, -1);
			GUI.Label(position3, string.Concat(array), OFPNEDEAMAB);
			num10 += 559f;
		}
		else
		{
			num10 += 545f;
		}
		if (this.FKEDAOOHPPB.KKNEKAEJLAM + this.FKEDAOOHPPB.KFODJJIHNHP > 0)
		{
			string text4 = string.Format("act_order", JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM((long)this.FKEDAOOHPPB.KKNEKAEJLAM, (long)this.FKEDAOOHPPB.KFODJJIHNHP, false));
			OFPNEDEAMAB.alignment = TextAnchor.MiddleRight;
			OFPNEDEAMAB.fontSize = 107;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 608f, COAGIAMOCIA.height - 1653f), text4, OFPNEDEAMAB);
		}
		OFPNEDEAMAB.fontSize = fontSize;
	}

	// Token: 0x06004207 RID: 16903 RVA: 0x001EF598 File Offset: 0x001ED798
	public string OFGNCAIFBDB(int GNICCGDPPJP = 0)
	{
		if (this.LPFKFNLHGBI != -165)
		{
			return this.BNIHFBMEPAB;
		}
		if (GNICCGDPPJP == 0)
		{
			return this.BNIHFBMEPAB.Replace("wplabel", "RollerBladeTurnLeft");
		}
		return string.Format(this.BNIHFBMEPAB, AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(GNICCGDPPJP).POMPCEHPGNG(1));
	}

	// Token: 0x06004208 RID: 16904 RVA: 0x001EF5F0 File Offset: 0x001ED7F0
	public BNOOIOKIFJC.DIGGOHPGCNN JLPEMDJOLAE(string JKLOOEDHHJP, string KEIEIAAKHHK)
	{
		BEFCHFNGOMI.KFNOPLFPHJC kfnoplfphjc = new BEFCHFNGOMI.KFNOPLFPHJC();
		kfnoplfphjc.KEIEIAAKHHK = KEIEIAAKHHK;
		XmlNode xmlNode = this.LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = kfnoplfphjc.LJOEIPHIJOE) == null)
			{
				predicate = (kfnoplfphjc.LJOEIPHIJOE = new Func<XmlNode, bool>(kfnoplfphjc.DJCMCFABDCF));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("NextFrame" + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN(": ");
	}

	// Token: 0x06004209 RID: 16905 RVA: 0x001EF6A4 File Offset: 0x001ED8A4
	public BNOOIOKIFJC.DIGGOHPGCNN GMCFFPKBFBB(string JKLOOEDHHJP, string KEIEIAAKHHK)
	{
		BEFCHFNGOMI.KFNOPLFPHJC kfnoplfphjc = new BEFCHFNGOMI.KFNOPLFPHJC();
		kfnoplfphjc.KEIEIAAKHHK = KEIEIAAKHHK;
		XmlNode xmlNode = this.LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = kfnoplfphjc.LJOEIPHIJOE) == null)
			{
				predicate = (kfnoplfphjc.LJOEIPHIJOE = new Func<XmlNode, bool>(kfnoplfphjc.JCALIMGADHE));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("TONEMAPPING_FILMIC" + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN("{0}/{1}");
	}

	// Token: 0x0600420A RID: 16906 RVA: 0x001EF758 File Offset: 0x001ED958
	public void IDDICAMBLPD(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB, string DACPJKOFPPJ)
	{
		float num = 217f;
		if (this.EJJAGEFMHCO() != null)
		{
			Texture texture = this.GKPOPMAAGIJ().NIOGJOFLPLH();
			float num2 = 1421f * COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float num4 = (float)texture.height * num2;
			float num5 = (COAGIAMOCIA.height - num4) / 1097f;
			Rect position = new Rect(COAGIAMOCIA.x + num5, COAGIAMOCIA.y + num5, num3, num4);
			GUI.DrawTexture(position, GameInterface.getI.invEmptyCell);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(this.KBGHOIJIPJF, 0, 2));
			GUI.DrawTexture(position, texture, ScaleMode.ScaleAndCrop);
			if (this.BPNNJBBCOFO != null)
			{
				BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.NKMGKJLONDK(this.BPNNJBBCOFO.MNFCAAIAGOL.KMIOLLENCOL());
				if (befchfngomi != null)
				{
					befchfngomi.JIFFLPNBILE();
					float num6 = num3 * 771f / 1360f;
					GUI.DrawTexture(new Rect(position.x + num3 / 1123f - num6, position.y + num3 / 1390f - num6, num6 * 1673f, num6 * 80f), befchfngomi.CFFHIODOGCH);
				}
			}
			if (this.MBKMKGABBGE == -127)
			{
				float num7 = position.height / 658f;
				Rect position2 = new Rect(position.x + 84f, position.y + position.height - num7 - 1099f, num7, num7);
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.EHBODADDPLM(this.MIMANMPNLPE.IBEIBAHKIAH);
				if (kdhoddmndfc != null)
				{
					GUI.DrawTexture(position2, kdhoddmndfc.IJGBOMGCLDK(), ScaleMode.StretchToFill);
				}
			}
			if (this.KBGHOIJIPJF > 0)
			{
				GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(this.KBGHOIJIPJF + 8, 7, 6));
			}
			num = num + num3 + 54f;
		}
		int gclkleimaba = this.GCLKLEIMABA;
		int fontSize = OFPNEDEAMAB.fontSize;
		OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
		OFPNEDEAMAB.fontSize = -111;
		string text = this.LFEJHHMDEHO(true, -1) + DACPJKOFPPJ;
		if (this.MBKMKGABBGE == -47)
		{
			string hajnmnalbbi = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(1).HAJNMNALBBI;
			text = text.Replace("Katana Ninja Draw", hajnmnalbbi);
		}
		GUI.Label(new Rect(COAGIAMOCIA.x + 1497f + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 770f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		OFPNEDEAMAB.fontSize = fontSize;
	}

	// Token: 0x0600420B RID: 16907 RVA: 0x001EF9F0 File Offset: 0x001EDBF0
	public override string ToString()
	{
		string text = "#002000";
		if (!this.FKEDAOOHPPB.LGOIEIELNBL(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH, 1))
		{
			text = "#400000";
		}
		string text2 = "";
		if (this.HOALBMDJNDM > 1)
		{
			text2 = " " + this.HOALBMDJNDM + " шт";
		}
		if (this.GCLKLEIMABA > 0)
		{
			" Категория " + JLFJEGIPIMM.IKGFHGKKCPG.IEICGMEMPIK(this.GCLKLEIMABA) + " ";
		}
		return string.Concat(new string[]
		{
			this.JPBOPFNPNHC(false, -1),
			text2,
			"\n",
			this.DPIHMPDHKBP(true),
			"\n<color='",
			text,
			"'>Стоимость: </color>",
			JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM((long)this.FKEDAOOHPPB.KKNEKAEJLAM, (long)this.FKEDAOOHPPB.KFODJJIHNHP, false)
		});
	}

	// Token: 0x0600420C RID: 16908 RVA: 0x001EFADC File Offset: 0x001EDCDC
	private static void DEAHGKKDHPM(Rect OCHCODJIPHJ, string IJCEDOGBHKE, Color LBCGACKJCJB, TextAnchor DEKGJCBMCHG)
	{
		GUIStyle ofpnedeamab = new GUIStyle
		{
			normal = 
			{
				textColor = LBCGACKJCJB
			},
			alignment = DEKGJCBMCHG,
			fontSize = 10
		};
		JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(OCHCODJIPHJ, IJCEDOGBHKE, ofpnedeamab);
	}

	// Token: 0x0600420D RID: 16909 RVA: 0x001EFB18 File Offset: 0x001EDD18
	public float DAFKBELILIJ(float MCPMCMONLIO)
	{
		float num = this.ENCJIGJBBDN();
		float num2 = 370f / (MCPMCMONLIO + 412f);
		if (num2 > 1050f)
		{
			num2 = 1108f + (num2 - 772f) * 1193f;
		}
		if (num2 <= 1544f)
		{
			num2 = 1891f - (815f - num2) * 982f;
		}
		num2 = Mathf.Clamp(num2, 251f, 997f);
		return Mathf.Round(num * num2);
	}

	// Token: 0x0600420E RID: 16910 RVA: 0x001EFB8C File Offset: 0x001EDD8C
	public override void GKDJCJKMBEN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 0f;
		bool flag = this.GBABFPMNIMP && this.FKEDAOOHPPB.LGOIEIELNBL(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH, 1);
		if (this.EJJAGEFMHCO() != null)
		{
			Texture texture = this.EJJAGEFMHCO().KEDGAOBCNJG;
			float num2 = 0.8f * COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float num4 = (float)texture.height * num2;
			float num5 = (COAGIAMOCIA.height - num4) / 2f;
			Rect position = new Rect(COAGIAMOCIA.x + num5, COAGIAMOCIA.y + num5, num3, num4);
			if (!flag)
			{
				GUI.enabled = false;
			}
			GUI.DrawTexture(position, GameInterface.getI.invEmptyCell);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.KBGHOIJIPJF, 7, 2));
			GUI.DrawTexture(position, texture, ScaleMode.StretchToFill);
			if (this.BPNNJBBCOFO != null)
			{
				BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.BPNNJBBCOFO.MNFCAAIAGOL.IBEIBAHKIAH);
				if (befchfngomi != null)
				{
					befchfngomi.JIFFLPNBILE();
					float num6 = num3 * 0.85f / 2f;
					GUI.DrawTexture(new Rect(position.x + num3 / 2f - num6, position.y + num3 / 2f - num6, num6 * 2f, num6 * 2f), befchfngomi.CFFHIODOGCH);
				}
			}
			if (this.MBKMKGABBGE == 34)
			{
				float num7 = position.height / 2f;
				Rect position2 = new Rect(position.x + 2f, position.y + position.height - num7 - 2f, num7, num7);
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.MIMANMPNLPE.IBEIBAHKIAH);
				if (kdhoddmndfc != null)
				{
					GUI.DrawTexture(position2, kdhoddmndfc.KMIIGKECOEB(), ScaleMode.StretchToFill);
				}
			}
			if (this.KBGHOIJIPJF > 1)
			{
				GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.KBGHOIJIPJF + 7, 7, 2));
			}
			float num8 = position.height / 3.5f;
			if (this.DNOLHLJODNK)
			{
				float num9 = num8 * 1.3f;
				GUI.DrawTextureWithTexCoords(new Rect(position.x + position.width - num9 + 2f, position.y - 2f, num9, num9), GameInterface.getI.wpnImproveIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.LNKLEIEFGCP, 8, 4));
			}
			num = num + num3 + 5f;
			GUI.enabled = true;
		}
		if (!flag)
		{
			GUI.color = new Color(0.3f, 0.1f, 0f, 0.2f);
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 2f, COAGIAMOCIA.y + 2f, COAGIAMOCIA.width - 10f, COAGIAMOCIA.height - 4f), GuiProcessor.IKGFHGKKCPG.blackWait);
			GUI.color = Color.white;
		}
		int gclkleimaba = this.GCLKLEIMABA;
		string str = "";
		if (this.HOALBMDJNDM > 1)
		{
			str = " x" + string.Format(JNBICAJIJMM.LEBHCLDODNI("inv_pcs1"), this.HOALBMDJNDM);
		}
		OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
		int fontSize = OFPNEDEAMAB.fontSize;
		OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
		OFPNEDEAMAB.fontSize = 14;
		string text = this.JPBOPFNPNHC(false, -1) + str;
		GUI.Label(new Rect(COAGIAMOCIA.x + 8f + num, COAGIAMOCIA.y + 4f, COAGIAMOCIA.width - 15f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		float num10 = 22f;
		OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		OFPNEDEAMAB.fontSize = 11;
		string text2 = this.DPIHMPDHKBP(true);
		if (text2.Trim() != "")
		{
			GUI.Label(new Rect(COAGIAMOCIA.x + 8f + num, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 15f, COAGIAMOCIA.height - num10), text2, OFPNEDEAMAB);
			num10 += 14f;
		}
		else
		{
			num10 += 4f;
		}
		if (this.OPFGGNNPAJL.IBEIBAHKIAH > 0)
		{
			string arg = "#002000";
			if (!this.GBABFPMNIMP)
			{
				arg = "#400000";
			}
			string text3 = string.Format("<color='{2}'>{0}: {1}</color>", BHNDGIPPPCE.IKGFHGKKCPG.DBKIBIABELK(this.OPFGGNNPAJL.IBEIBAHKIAH), BHNDGIPPPCE.IKGFHGKKCPG.PEJJOKHOLMF(this.OPFGGNNPAJL.IBEIBAHKIAH, this.OPFGGNNPAJL.ICJDPPOJINN), arg);
			GUI.Label(new Rect(COAGIAMOCIA.x + 8f + num, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 15f, COAGIAMOCIA.height - 36f), text3, OFPNEDEAMAB);
			num10 += 14f;
		}
		if (this.FKEDAOOHPPB.GIEALCKLKNL > 0)
		{
			BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.FKEDAOOHPPB.GIEALCKLKNL);
			befchfngomi2.FCBHHPJLGLC(new Rect(COAGIAMOCIA.x + 8f + num, COAGIAMOCIA.y + num10 - 4f, 16f, 16f), befchfngomi2.KBGHOIJIPJF, false, 0);
			GUI.Label(new Rect(COAGIAMOCIA.x + 8f + num + 20f, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 15f, COAGIAMOCIA.height - 36f), string.Concat(new object[]
			{
				"x",
				this.FKEDAOOHPPB.KDIMEMOCJNM,
				" ",
				befchfngomi2.JPBOPFNPNHC(false, -1)
			}), OFPNEDEAMAB);
			num10 += 14f;
		}
		else
		{
			num10 += 8f;
		}
		if (this.FKEDAOOHPPB.KKNEKAEJLAM + this.FKEDAOOHPPB.KFODJJIHNHP > 0)
		{
			string text4 = string.Format("{0}", JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM((long)this.FKEDAOOHPPB.KKNEKAEJLAM, (long)this.FKEDAOOHPPB.KFODJJIHNHP, false));
			OFPNEDEAMAB.alignment = TextAnchor.LowerRight;
			OFPNEDEAMAB.fontSize = 18;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 14f, COAGIAMOCIA.height - 4f), text4, OFPNEDEAMAB);
		}
		OFPNEDEAMAB.fontSize = fontSize;
	}

	// Token: 0x0600420F RID: 16911 RVA: 0x001F021E File Offset: 0x001EE41E
	public int HKANKDGLHME()
	{
		return this.JLPEMDJOLAE("", "WeaponReload").DCGNALDFPDB();
	}

	// Token: 0x06004210 RID: 16912 RVA: 0x001F0238 File Offset: 0x001EE438
	public void HKHPGCHCHAI()
	{
		if (this.IJHNKCHCCOA)
		{
			return;
		}
		if (this.OLNGOHEPLBO == null)
		{
			CKNLPGEPGGF cknlpgepggf = CKNLPGEPGGF.IKGFHGKKCPG;
			object[] array = new object[0];
			array[1] = IFPIMPMKJIB.ACOEIDGDLJC();
			array[0] = "WeaponReadyFire";
			array[4] = this.LPFKFNLHGBI;
			array[1] = " x";
			this.OLNGOHEPLBO = cknlpgepggf.EKHFCNKNHEJ(string.Concat(array), false);
		}
		if (this.EOFDJHJPCLM == null)
		{
			string alboclbfnni = string.Format("crft_btn1", IFPIMPMKJIB.LIOPCJFCGAF(), this.LPFKFNLHGBI);
			this.EOFDJHJPCLM = CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(alboclbfnni, true);
		}
		this.IJHNKCHCCOA = true;
	}

	// Token: 0x06004211 RID: 16913 RVA: 0x001F02D4 File Offset: 0x001EE4D4
	public override int NBCAEJHKLMG(ItemBase MBKPMBPLIJN)
	{
		int result = 0;
		BEFCHFNGOMI befchfngomi = (BEFCHFNGOMI)MBKPMBPLIJN;
		if (this.PCFNDIFLIHC() < befchfngomi.PCFNDIFLIHC())
		{
			result = -1;
		}
		if (this.PCFNDIFLIHC() > befchfngomi.PCFNDIFLIHC())
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x06004212 RID: 16914 RVA: 0x001F030B File Offset: 0x001EE50B
	public bool DDOPABKNBEC()
	{
		return this.JHCFMFNCOLM("_ReflectionTexture3", "post_8").DGEEJKEEHPE();
	}

	// Token: 0x06004213 RID: 16915 RVA: 0x001F0324 File Offset: 0x001EE524
	public string MPKGPJJKCPK(bool BGNPMOCLIGL = false, int JEGIMBPFJKD = -1)
	{
		int num = JEGIMBPFJKD;
		if (num < 1)
		{
			num = this.KBGHOIJIPJF;
		}
		string[] array = new string[8];
		array[1] = "WATER_VERTEX_DISPLACEMENT_ON";
		array[0] = this.BKKCDJHCCHP(num, BGNPMOCLIGL);
		array[0] = "  Balls Fired: ";
		array[0] = this.BNIHFBMEPAB;
		array[6] = "OnGround";
		return string.Concat(array);
	}

	// Token: 0x06004214 RID: 16916 RVA: 0x001F0378 File Offset: 0x001EE578
	public static Color GEAFAGJLONI(int AFCMJJMBOMA)
	{
		Color result = new Color(332f, 1736f, 1666f);
		switch (AFCMJJMBOMA)
		{
		case 0:
			result = new Color(1503f, 599f, 135f);
			break;
		case 1:
			result = new Color(1943f, 614f, 60f);
			break;
		case 2:
			result = new Color(1471f, 685f, 155f);
			break;
		case 3:
			result = new Color(1309f, 1886f, 8f);
			break;
		case 4:
			result = new Color(49f, 134f, 215f);
			break;
		case 5:
			result = new Color(751f, 807f, 912f);
			break;
		}
		return result;
	}

	// Token: 0x06004215 RID: 16917 RVA: 0x001F0450 File Offset: 0x001EE650
	public virtual int IFMPGAHGKBJ(ItemBase MBKPMBPLIJN)
	{
		int result = 1;
		BEFCHFNGOMI befchfngomi = (BEFCHFNGOMI)MBKPMBPLIJN;
		if (this.PCFNDIFLIHC() < befchfngomi.PCFNDIFLIHC())
		{
			result = -1;
		}
		if (this.PCFNDIFLIHC() > befchfngomi.PCFNDIFLIHC())
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x06004216 RID: 16918 RVA: 0x001F0487 File Offset: 0x001EE687
	public bool FFPOKDHMKAK()
	{
		return this.BBLEPPMMPIL("LHandPunch", "Crouch Strafe Left").DGEEJKEEHPE();
	}

	// Token: 0x06004217 RID: 16919 RVA: 0x001F04A0 File Offset: 0x001EE6A0
	public float AKFDHBAJEAJ(float MCPMCMONLIO)
	{
		float num = this.ENCJIGJBBDN();
		float num2 = 430f / (MCPMCMONLIO + 742f);
		if (num2 > 64f)
		{
			num2 = 188f + (num2 - 333f) * 98f;
		}
		if (num2 <= 1000f)
		{
			num2 = 1239f - (1589f - num2) * 333f;
		}
		num2 = Mathf.Clamp(num2, 364f, 1700f);
		return Mathf.Round(num * num2);
	}

	// Token: 0x06004218 RID: 16920 RVA: 0x001F0514 File Offset: 0x001EE714
	public string IOAGBIACCHA(bool EFLPJHMLOOA = true)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("Press E to start interaction");
		int num = this.MBKMKGABBGE;
		if (this.MBKMKGABBGE == 16)
		{
			stringBuilder.Append("_ReflectionTexture4");
			if (this.JALOCNOIDFJ > 1)
			{
				num = this.JALOCNOIDFJ;
			}
		}
		switch (num)
		{
		case 1:
		{
			float num2 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.MIMANMPNLPE, 1);
			string text = JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL((double)num2);
			if (this.OKHPDILIOCH.Count > 1)
			{
				text = "ClimbLeft";
				foreach (int jjjnkodleel in this.OKHPDILIOCH)
				{
					num2 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.MIMANMPNLPE, jjjnkodleel);
					text = text + JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC((double)num2) + "RunningDance";
				}
				text = text.Remove(text.Length - 0);
			}
			stringBuilder.Append(string.Format(JNBICAJIJMM.APMJBBDBOJO().HLBAJBLHLNI("_BlurPass"), JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL(this.MIMANMPNLPE.DHJBAKDAMGH())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.EKEBHIJMEML().CKAOHMEKLMH("Giant 2 Hand Slam Idle"), JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH), text));
			stringBuilder.Append(string.Format(JNBICAJIJMM.EEOPOHEALPK().CKAOHMEKLMH("{0} - {1} шт"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.HDPNCIECLKP() / 1108.0)));
			string text2 = "knopje.wav";
			if (this.ADOFHHCDGON > 1)
			{
				object[] array = new object[1];
				array[0] = text2;
				array[1] = "_EdgeThreshold";
				array[4] = JNBICAJIJMM.LPHMKPDBMPP().CCFFMKBBKHI("AssetBundleServerURL");
				array[2] = " ";
				array[3] = this.ADOFHHCDGON;
				array[0] = "cnt_energ";
				text2 = string.Concat(array);
			}
			if (this.ECKKCDKHNEH > 0)
			{
				object[] array2 = new object[8];
				array2[1] = text2;
				array2[1] = "_DepthOfFieldTex";
				array2[7] = JNBICAJIJMM.EDKGBBIIBBC().FLEANFGEJML("Giant 3 Hit Combo 2");
				array2[0] = "";
				array2[0] = this.ECKKCDKHNEH;
				array2[6] = "CrouchStrafeRight";
				text2 = string.Concat(array2);
			}
			if (text2 != "cht_msg30")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.EEOPOHEALPK().FLEANFGEJML(""), text2));
			}
			stringBuilder.Append(string.Format("https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6" + JNBICAJIJMM.IKGFHGKKCPG.GNKIBMGNHNE("") + "WeaponFire", this.FJJEAMJNLIO));
			break;
		}
		case 2:
		{
			float num3 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.MIMANMPNLPE, 1);
			stringBuilder.Append(string.Format(JNBICAJIJMM.IMLLGEMPHAP().ECNKLECOKHD("maxspd"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.DHJBAKDAMGH())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LPHMKPDBMPP().CCFFMKBBKHI("_Offsets"), JLFJEGIPIMM.MHFDIJGJGBJ().AHEHNKFHGOC(this.MIMANMPNLPE.OIGIHEPJFFJ()), JLFJEGIPIMM.NNEAHAFBOHC().AHEHNKFHGOC((double)num3)));
			string text3 = "post_14";
			if (this.ADOFHHCDGON > 1)
			{
				object[] array3 = new object[4];
				array3[0] = text3;
				array3[1] = "WorkerPickaxe";
				array3[4] = JNBICAJIJMM.APMJBBDBOJO().CCFFMKBBKHI("IceHockeyGoalieSave1");
				array3[7] = "FlyUp";
				array3[5] = this.ADOFHHCDGON;
				array3[4] = "cntx_wpnauk";
				text3 = string.Concat(array3);
			}
			if (this.ECKKCDKHNEH > 0)
			{
				object[] array4 = new object[3];
				array4[0] = text3;
				array4[1] = "F key to change fog style, T to toggle fog on/off, C to toggle fog cutting";
				array4[8] = JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("OfficeSittingMouseMovement");
				array4[3] = "?";
				array4[8] = this.ECKKCDKHNEH;
				array4[7] = " ";
				text3 = string.Concat(array4);
			}
			if (text3 != "_mesh")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.APMJBBDBOJO().CCFFMKBBKHI("_AutoExposure"), text3));
			}
			stringBuilder.Append(string.Format("sunshine_ShadowToWorldScale" + JNBICAJIJMM.APMJBBDBOJO().CKAOHMEKLMH("short") + "WallSit", this.FJJEAMJNLIO));
			break;
		}
		case 3:
		{
			float num4 = BOIKJDICEMF.IKGFHGKKCPG.CPHHGMPBACB(this.MBKMKGABBGE, this.MIMANMPNLPE, 0);
			stringBuilder.Append(string.Format(JNBICAJIJMM.CLIMNFDGOEG().GNKIBMGNHNE("Active Process "), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LPHMKPDBMPP().CKAOHMEKLMH("_DebugWidth"), JLFJEGIPIMM.NNEAHAFBOHC().AHEHNKFHGOC(this.MIMANMPNLPE.OIGIHEPJFFJ()), JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL((double)num4)));
			string text4 = "ComeHere";
			if (this.ADOFHHCDGON > 1)
			{
				object[] array5 = new object[8];
				array5[0] = text4;
				array5[1] = "_WrinkleInfluences3";
				array5[6] = JNBICAJIJMM.EKEBHIJMEML().CCFFMKBBKHI("wpn_cat4");
				array5[8] = "WeaponStand";
				array5[2] = this.ADOFHHCDGON;
				array5[4] = "MotorbikeLasso";
				text4 = string.Concat(array5);
			}
			if (this.ECKKCDKHNEH > 1)
			{
				object[] array6 = new object[1];
				array6[0] = text4;
				array6[1] = "IdleRun";
				array6[4] = JNBICAJIJMM.EDKGBBIIBBC().HLBAJBLHLNI("Climb Left");
				array6[1] = "ondestroy";
				array6[8] = this.ECKKCDKHNEH;
				array6[5] = " ";
				text4 = string.Concat(array6);
			}
			if (text4 != "quests/tnames/turn")
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.IMLLGEMPHAP().DOEMGEAEBPN("cht_msg10"), text4));
			}
			stringBuilder.Append(string.Format("FlyForward" + JNBICAJIJMM.IKGFHGKKCPG.HEIBEHAEHBM("WorkerHammer2") + "money", this.FJJEAMJNLIO));
			break;
		}
		case 4:
		{
			stringBuilder.Append(JNBICAJIJMM.NGALDMFKMJH("_Color") + "IdleSad" + JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.MIMANMPNLPE.LNEPKLKELMI) + "1HandSwordChargeHeavyBash");
			stringBuilder.Append(JNBICAJIJMM.CDDCIKKDFMP("KA: {0}->{1}") + "BowFire" + JLFJEGIPIMM.NNEAHAFBOHC().AHEHNKFHGOC(this.MIMANMPNLPE.NMKCBJKHBOH) + "Hyperlink_");
			string str = JNBICAJIJMM.NGALDMFKMJH("dragWeapon = null 3");
			if (this.MIMANMPNLPE.NODLBGKEGPM > 1)
			{
				str = JNBICAJIJMM.EEOPOHEALPK().HEIBEHAEHBM("1HandSmallWeaponCombo") + "fishsplash{0}.ogg" + JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)(this.MIMANMPNLPE.DBFOHFDOCIB() * 289.0));
			}
			stringBuilder.Append(JNBICAJIJMM.CELEPPAEKAB(" Packed: ") + "wpn_ibsize_" + str + "[Attachments] Failed to find ProBuilder object on the attachments object '{0}'.");
			stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("минута") + "run", this.AKFDHBAJEAJ(245f)));
			string jmbkdinhdlo = "</color>";
			if (Mathf.Abs(this.MFMLCHFNALC) > 1461f)
			{
				if (this.MFMLCHFNALC > 518f)
				{
					jmbkdinhdlo = "1 Hand Sword Shield Bash";
				}
				if (this.MFMLCHFNALC < 1694f)
				{
					jmbkdinhdlo = "";
				}
			}
			stringBuilder.Append("IdleRun" + string.Format(JNBICAJIJMM.PGJCPFNJNPM("rollSoundVolume"), JNBICAJIJMM.PGJCPFNJNPM(jmbkdinhdlo)));
			break;
		}
		case 5:
		{
			Vector2 vector = this.KPLOLDJFGBE();
			stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("_VignetteCenter") + "Quaternion: ", JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.MIMANMPNLPE.DHJBAKDAMGH())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.NGALDMFKMJH("fish/" + this.ILOCKJIAPFC) + "Low adminlevel!", 1));
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("wpn_rec2") + "cash.ogg", JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL(this.MIMANMPNLPE.NMKCBJKHBOH)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("WeaponStand") + "{0} x {1}", JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL(this.MIMANMPNLPE.GJBKBEEJLDF())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("t_much") + "Dealer Shuffle", JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)Mathf.RoundToInt(vector.x * 358f)), JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)Mathf.RoundToInt(vector.y * 1302f))));
			break;
		}
		case 6:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("<color='#303030'><size=10>{0}</size></color>\n<size=16><b>{1}</b></size><color='#302020'>  {3}</color>{2}") + "shop_t17", JLFJEGIPIMM.IKGFHGKKCPG.PEGPHIOEKHI(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("bag") + "Flap_04.wav", JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC(this.MIMANMPNLPE.DHJBAKDAMGH())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("OfficeSittingEyesRub") + "_BlurFilterDistance", JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL((double)this.MIMANMPNLPE.NLHKFMMDMMK())));
			if (this.MIMANMPNLPE.GJBKBEEJLDF() > 1873.0)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("OneHandSwordBlock") + "Lasso Left", JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL(this.MIMANMPNLPE.GJBKBEEJLDF())));
			}
			IIBEEKCAAHK iibeekcaahk = JLFJEGIPIMM.IKGFHGKKCPG.PBHCNOAPLNN(this.MIMANMPNLPE.KMGAHCANELI());
			stringBuilder.Append(string.Format(JNBICAJIJMM.NGALDMFKMJH("fishcatch"), JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)iibeekcaahk.IBEIBAHKIAH), JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)iibeekcaahk.NLHKFMMDMMK())));
			break;
		}
		case 7:
			stringBuilder.Append(string.Format(JNBICAJIJMM.NGALDMFKMJH("https://www.youtube.com/watch?v=eP9-zycoHLk") + "\n", JLFJEGIPIMM.NNEAHAFBOHC().DIOCHACFPHJ(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("") + "JNT_Root", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.AIMCFAHLPEF())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.NGALDMFKMJH("") + "23", JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL(this.MIMANMPNLPE.OIGIHEPJFFJ())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("{0}/{1}") + "_OcclusionTexture2", JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL(this.MIMANMPNLPE.KCKFCPIHMPC())));
			break;
		case 8:
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("fishspincatch") + "No hit from ", JLFJEGIPIMM.IKGFHGKKCPG.MIEDNDLOEJH(this.NKHBAJKMAGD)));
			break;
		case 9:
			stringBuilder.Append(string.Format(JNBICAJIJMM.NGALDMFKMJH(" l ") + "#ffffff", JLFJEGIPIMM.IKGFHGKKCPG.PEGPHIOEKHI(this.NKHBAJKMAGD)));
			if (this.FEIKHDICLPM("", "IdleStand").KPAFFJNBLHK)
			{
				stringBuilder.Append(JNBICAJIJMM.OOOKJHOHPNN("1HandSwordChargeUp"));
			}
			break;
		case 10:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("WizardOverhead") + "harvestmsg3", JLFJEGIPIMM.NNEAHAFBOHC().AHEHNKFHGOC(this.MIMANMPNLPE.DHJBAKDAMGH())));
			string str2 = JNBICAJIJMM.PPNKMDJBMLP("-" + this.MIMANMPNLPE.NLHKFMMDMMK());
			stringBuilder.Append(str2 + " x");
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("_BlurTex"), JLFJEGIPIMM.MHFDIJGJGBJ().DIOCHACFPHJ(this.NKHBAJKMAGD)));
			break;
		}
		case 11:
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("Mouse Y") + "paper.wav", JLFJEGIPIMM.NNEAHAFBOHC().BIJHHFGLDLH(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DCEBAJIILPC("VaderChoke"), JLFJEGIPIMM.IKGFHGKKCPG.AHEHNKFHGOC(this.MIMANMPNLPE.LNEPKLKELMI)));
			break;
		case 12:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("{0:00} : {1:00}") + "_DepthFade", JLFJEGIPIMM.PKGMBFEMKGP().MIEDNDLOEJH(this.NKHBAJKMAGD)));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("IceHockey Idle"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(this.MIMANMPNLPE.AIMCFAHLPEF())) + "%)");
			int ilockjiapfc = this.ILOCKJIAPFC;
			if (ilockjiapfc == 3)
			{
				stringBuilder.Append(JNBICAJIJMM.LEBHCLDODNI("wpn") + "UIPCam_pos" + string.Format(JNBICAJIJMM.DCEBAJIILPC("Bases/1.base"), this.GLLIKKONFAJ) + "<");
			}
			if (ilockjiapfc > 1)
			{
				string jmbkdinhdlo2 = string.Format("sunshine_WorldToSunVP", ilockjiapfc);
				stringBuilder.Append(": " + JNBICAJIJMM.DIOJFJMOPJO(jmbkdinhdlo2) + "RollerBladeJump");
			}
			break;
		}
		case 16:
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("FlyUp") + "Soccer Pass Heavy", JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.MIMANMPNLPE.NKEOCCKEOCE())));
			stringBuilder.Append(string.Format(JNBICAJIJMM.CDDCIKKDFMP("/") + "[ProBuilder Attachments] Please disable the following option in the Unity preferences:", this.MIMANMPNLPE.ICJDPPOJINN));
			break;
		case 21:
			if (this.MIMANMPNLPE.KMIOLLENCOL() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.IBEIBAHKIAH > 0) ? string.Format(JNBICAJIJMM.DIOJFJMOPJO("cnt_energ"), this.MIMANMPNLPE.KEHIFGILLJA()) : string.Format(JNBICAJIJMM.PGJCPFNJNPM("invn_win1"), Mathf.Abs(this.MIMANMPNLPE.KEHIFGILLJA())));
			}
			if (this.MIMANMPNLPE.ICJDPPOJINN != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.ICJDPPOJINN > 0) ? string.Format(JNBICAJIJMM.OOOKJHOHPNN("Reset"), this.MIMANMPNLPE.NLHKFMMDMMK()) : string.Format(JNBICAJIJMM.DCEBAJIILPC("USE_CORNER_DETECTION"), Mathf.Abs(this.MIMANMPNLPE.NLHKFMMDMMK())));
			}
			if (this.MIMANMPNLPE.CJKILDPJCFJ() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.CJKILDPJCFJ() > 0) ? string.Format(JNBICAJIJMM.DCEBAJIILPC(" "), this.MIMANMPNLPE.NFCDJLJNDLO()) : string.Format(JNBICAJIJMM.CDDCIKKDFMP("Intensity"), Mathf.Abs(this.MIMANMPNLPE.NFCDJLJNDLO())));
			}
			break;
		case 22:
			if (this.MIMANMPNLPE.NKEOCCKEOCE() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.KMIOLLENCOL() > 1) ? string.Format(JNBICAJIJMM.CDDCIKKDFMP("DISTANCE_CUTOFF_OFF"), this.MIMANMPNLPE.NKEOCCKEOCE()) : string.Format(JNBICAJIJMM.CELEPPAEKAB("id"), Mathf.Abs(this.MIMANMPNLPE.KEHIFGILLJA())));
			}
			if (this.MIMANMPNLPE.NLHKFMMDMMK() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.KMGAHCANELI() > 1) ? string.Format(JNBICAJIJMM.LEBHCLDODNI("_CameraToWorldMatrix"), this.MIMANMPNLPE.KMGAHCANELI()) : string.Format(JNBICAJIJMM.PPNKMDJBMLP("BowReady"), Mathf.Abs(this.MIMANMPNLPE.ICJDPPOJINN)));
			}
			if (this.MIMANMPNLPE.NFCDJLJNDLO() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NODLBGKEGPM > 0) ? string.Format(JNBICAJIJMM.PPNKMDJBMLP("1HandSwordJabCombo"), this.MIMANMPNLPE.CJKILDPJCFJ()) : string.Format(JNBICAJIJMM.PGJCPFNJNPM("WeaponStand"), Mathf.Abs(this.MIMANMPNLPE.CJKILDPJCFJ())));
			}
			break;
		case 23:
			if (this.MIMANMPNLPE.NKEOCCKEOCE() != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.KMIOLLENCOL() > 0) ? string.Format(JNBICAJIJMM.PPNKMDJBMLP("OfficeSitting"), this.MIMANMPNLPE.NKEOCCKEOCE()) : string.Format(JNBICAJIJMM.DIOJFJMOPJO("val="), Mathf.Abs(this.MIMANMPNLPE.KMIOLLENCOL())));
			}
			if (this.MIMANMPNLPE.ICJDPPOJINN != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NLHKFMMDMMK() > 1) ? string.Format(JNBICAJIJMM.PGJCPFNJNPM(")"), this.MIMANMPNLPE.ICJDPPOJINN) : string.Format(JNBICAJIJMM.LEBHCLDODNI("Flares"), Mathf.Abs(this.MIMANMPNLPE.KMGAHCANELI())));
			}
			if (this.MIMANMPNLPE.NODLBGKEGPM != 0)
			{
				stringBuilder.Append((this.MIMANMPNLPE.NODLBGKEGPM > 1) ? string.Format(JNBICAJIJMM.PGJCPFNJNPM("*************160 baseid="), this.MIMANMPNLPE.CJKILDPJCFJ()) : string.Format(JNBICAJIJMM.PGJCPFNJNPM("wpn_tank2"), Mathf.Abs(this.MIMANMPNLPE.NFCDJLJNDLO())));
			}
			break;
		case 28:
		{
			CLFFOBKFKDN.OKOAMCJGNMH okoamcjgnmh = CLFFOBKFKDN.OOIJFNAMEDP().GEMHHJFMOPM(this.MIMANMPNLPE.NLHKFMMDMMK());
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.IMCJNFHAFGE(okoamcjgnmh.MNFCAAIAGOL.KMIOLLENCOL());
			if (befchfngomi != null && this.BPNNJBBCOFO != null)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.PPNKMDJBMLP("FrontKick"), befchfngomi.IGDKBMGKKDO(true, -1), this.BPNNJBBCOFO.MNFCAAIAGOL.ICJDPPOJINN));
				stringBuilder.Append((this.MIMANMPNLPE.NFCDJLJNDLO() < 1) ? JNBICAJIJMM.NGALDMFKMJH("IdleStrafeRight") : string.Format(JNBICAJIJMM.DIOJFJMOPJO(" on effect "), this.MIMANMPNLPE.CJKILDPJCFJ()));
				stringBuilder.Append(string.Format(JNBICAJIJMM.NGALDMFKMJH("BuY"), CLFFOBKFKDN.JDELMFDJFNC().MMPOGPAOMIF(this.BPNNJBBCOFO.BKLCKNOLEFD)));
				stringBuilder.Append("\n");
				string text5 = "No location found baseid=";
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.ALOFNMHDOJM(this.BPNNJBBCOFO.ABLFIGDGCBG);
				if (kdhoddmndfc != null)
				{
					text5 += kdhoddmndfc.FFAFKPDHOIN(this.BPNNJBBCOFO.LKCIDOHHADJ);
					string arg = "isRealView";
					if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.FOACIAGMAPD(this.BPNNJBBCOFO.ABLFIGDGCBG) < this.BPNNJBBCOFO.LKCIDOHHADJ)
					{
						arg = "IdleStrafeLeft";
					}
					stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("__a"), arg, text5));
				}
			}
			break;
		}
		case 32:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.PGJCPFNJNPM("money2.wav"), this.MIMANMPNLPE.LNEPKLKELMI));
			stringBuilder.Append(string.Format(JNBICAJIJMM.LEBHCLDODNI("_ALPHATEST_ON"), this.MIMANMPNLPE.OIGIHEPJFFJ()));
			stringBuilder.Append(string.Format(JNBICAJIJMM.DCEBAJIILPC("How your lives count is stored in memory when obscured:\n"), this.MIMANMPNLPE.FJACMDGJEBL()));
			List<int> list = this.NGOAOMNBIGI("name", "Level: ").EDAHDHCPIEL;
			string text6 = JNBICAJIJMM.NGALDMFKMJH("_UserLutParams") + "BowIdle";
			foreach (int lpfkfnlhgbi in list)
			{
				text6 = text6 + IHFEDJEMJMB.NNEAHAFBOHC().GCIPBKDIBNJ(lpfkfnlhgbi) + "{0} : {1}";
			}
			stringBuilder.Append(text6);
			break;
		}
		case 33:
			stringBuilder.Append(string.Format(JNBICAJIJMM.PPNKMDJBMLP("Trying to solve uninitiated FABRIK chain."), this.MIMANMPNLPE.AIMCFAHLPEF()));
			stringBuilder.Append(string.Format(JNBICAJIJMM.PPNKMDJBMLP("inv_invheader"), this.MIMANMPNLPE.OIGIHEPJFFJ()));
			break;
		case 34:
		{
			int num5 = this.MIMANMPNLPE.NKEOCCKEOCE();
			NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc2 = NLNNIDBPKAO.IKGFHGKKCPG.DJDLJCFCPPH(num5);
			if (kdhoddmndfc2 != null)
			{
				bool flag = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.GADJFFGDCFA.ContainsKey(num5);
				stringBuilder.Append(flag ? string.Format(JNBICAJIJMM.BDKHMOOFHHK("WorkerHammer2"), kdhoddmndfc2.KKEBDLGHBMN) : string.Format(JNBICAJIJMM.PPNKMDJBMLP("WinVIP"), kdhoddmndfc2.KKEBDLGHBMN));
			}
			break;
		}
		case 36:
		{
			stringBuilder.Append(string.Format(JNBICAJIJMM.BDKHMOOFHHK("_RgbTex"), this.MIMANMPNLPE.OIGIHEPJFFJ()) + "BowFire2");
			string jmbkdinhdlo3 = "OnRenderImage in Helper called ...";
			if (this.MIMANMPNLPE.KCKFCPIHMPC() > 1130.0)
			{
				jmbkdinhdlo3 = "Criticals";
			}
			stringBuilder.Append(string.Format(JNBICAJIJMM.DIOJFJMOPJO(jmbkdinhdlo3), this.MIMANMPNLPE.NKGGAFLBFDF));
			break;
		}
		}
		if (this.DNOLHLJODNK)
		{
			stringBuilder.Append(JNBICAJIJMM.PGJCPFNJNPM("IdleDie"));
		}
		string text7 = "sunshine_ShadowCoordDepthStart" + stringBuilder + "</color>";
		stringBuilder = new StringBuilder();
		if (this.MBOOFLANJID != 0)
		{
			bool flag2 = false;
			if (this.MBOOFLANJID == 0 && JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.GDJMBFGEMFJ != 0)
			{
				flag2 = true;
			}
			if (this.MBOOFLANJID == 4 && JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.GDJMBFGEMFJ != 0)
			{
				flag2 = false;
			}
			string arg2 = "Jump";
			if (flag2)
			{
				arg2 = "SneakBackward";
			}
			if (this.MBOOFLANJID == 1)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.CELEPPAEKAB("MotorbikeIdle") + "sys", arg2));
			}
			if (this.MBOOFLANJID == 4)
			{
				stringBuilder.Append(string.Format(JNBICAJIJMM.OOOKJHOHPNN("Look Back") + "ClimbLeft", arg2));
			}
		}
		string text8 = text7;
		if (!EFLPJHMLOOA)
		{
			text8 = Regex.Replace(text8, "</b>\n : ", string.Empty);
		}
		return text8;
	}

	// Token: 0x06004219 RID: 16921 RVA: 0x001F1BAC File Offset: 0x001EFDAC
	public bool FOCAKCEPMMK()
	{
		return this.JJCFHNLNBCJ(" cannot be used as a 3D LUT.", "OneHandSwordSwing").DGEEJKEEHPE();
	}

	// Token: 0x0600421A RID: 16922 RVA: 0x001F1BC4 File Offset: 0x001EFDC4
	public string CGMGBGABLFB(bool BGNPMOCLIGL = false, int JEGIMBPFJKD = -1)
	{
		int num = JEGIMBPFJKD;
		if (num < 1)
		{
			num = this.KBGHOIJIPJF;
		}
		string[] array = new string[7];
		array[0] = "Moon reference not set.";
		array[1] = this.EMLKBOOFNGA(num, BGNPMOCLIGL);
		array[3] = "Walk Injured";
		array[5] = this.BNIHFBMEPAB;
		array[3] = "val=";
		return string.Concat(array);
	}

	// Token: 0x0600421B RID: 16923 RVA: 0x001F1C18 File Offset: 0x001EFE18
	public string CMMEFEKAGHF(int AFCMJJMBOMA, bool BGNPMOCLIGL = false)
	{
		string result = "TOD_AmbientColor";
		if (BGNPMOCLIGL)
		{
			switch (AFCMJJMBOMA)
			{
			case 0:
				result = "WeaponInstant";
				break;
			case 1:
				result = "isFishOnRod";
				break;
			case 2:
				result = "isFishGet";
				break;
			case 3:
				result = "error";
				break;
			case 4:
				result = "NOISE_OFF";
				break;
			case 5:
				result = "_Offsets";
				break;
			case 6:
				result = "";
				break;
			}
		}
		else
		{
			switch (AFCMJJMBOMA)
			{
			case 0:
				result = "PaperTurn.wav";
				break;
			case 1:
				result = "holesAll";
				break;
			case 2:
				result = "RollerBladeSkateFwd";
				break;
			case 3:
				result = "SoccerKeeperReady";
				break;
			case 4:
				result = "#000000";
				break;
			case 5:
				result = "crft_cnt";
				break;
			case 6:
				result = "WoodSaw";
				break;
			}
		}
		return result;
	}

	// Token: 0x0600421C RID: 16924 RVA: 0x001F1CF0 File Offset: 0x001EFEF0
	public string PCLBFMPCKBE(int GNICCGDPPJP = 0)
	{
		if (this.LPFKFNLHGBI != 77)
		{
			return this.BNIHFBMEPAB;
		}
		if (GNICCGDPPJP == 0)
		{
			return this.BNIHFBMEPAB.Replace("action", "https://groups.google.com/forum/#!forum/final-ik");
		}
		return string.Format(this.BNIHFBMEPAB, AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(GNICCGDPPJP).OFENIDGOGNA(0));
	}

	// Token: 0x0600421D RID: 16925 RVA: 0x001F1D48 File Offset: 0x001EFF48
	public void FCBHHPJLGLC(Rect OCHCODJIPHJ, int JGNMABIMLIA, bool AMAAJEPFEFA = false, int OLKMHFNLBJB = 0)
	{
		if (this.CFFHIODOGCH == null)
		{
			this.JIFFLPNBILE();
			return;
		}
		if (AMAAJEPFEFA)
		{
			GUI.DrawTexture(OCHCODJIPHJ, GameInterface.getI.invEmptyCell);
		}
		GUI.DrawTextureWithTexCoords(OCHCODJIPHJ, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.KBGHOIJIPJF, 7, 2));
		GUI.DrawTexture(OCHCODJIPHJ, this.CFFHIODOGCH, ScaleMode.StretchToFill);
		if (this.MBKMKGABBGE == 34)
		{
			float num = OCHCODJIPHJ.height / 2f;
			Rect position = new Rect(OCHCODJIPHJ.x + 2f, OCHCODJIPHJ.y + OCHCODJIPHJ.height - num - 2f, num, num);
			NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.MIMANMPNLPE.IBEIBAHKIAH);
			if (kdhoddmndfc != null)
			{
				GUI.DrawTexture(position, kdhoddmndfc.KMIIGKECOEB(), ScaleMode.StretchToFill);
			}
		}
		if (this.BPNNJBBCOFO != null)
		{
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.BPNNJBBCOFO.MNFCAAIAGOL.IBEIBAHKIAH);
			if (befchfngomi != null)
			{
				befchfngomi.JIFFLPNBILE();
				float num2 = OCHCODJIPHJ.width * 0.85f / 2f;
				GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width / 2f - num2, OCHCODJIPHJ.y + OCHCODJIPHJ.width / 2f - num2, num2 * 2f, num2 * 2f), befchfngomi.CFFHIODOGCH);
			}
		}
		if (this.KBGHOIJIPJF > 1)
		{
			GUI.DrawTextureWithTexCoords(OCHCODJIPHJ, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.KBGHOIJIPJF + 7, 7, 2));
		}
		if (this.LPFKFNLHGBI == 1309)
		{
			IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(OLKMHFNLBJB);
			if (idchhhedhdc != null)
			{
				GUI.DrawTexture(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y + OCHCODJIPHJ.width / 6f, OCHCODJIPHJ.width, OCHCODJIPHJ.width / 2f), idchhhedhdc.KMIIGKECOEB(2).KEDGAOBCNJG, ScaleMode.StretchToFill);
			}
		}
		float width = OCHCODJIPHJ.width;
		float num3 = width / 3.5f;
		Rect position2 = new Rect(OCHCODJIPHJ.x + width - num3, OCHCODJIPHJ.y + width - num3, num3, num3);
		if (this.MBKMKGABBGE == 1)
		{
			GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(16, 8, 8));
		}
		if (this.MBKMKGABBGE == 2)
		{
			GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(17, 8, 8));
		}
		if (this.MBKMKGABBGE == 3)
		{
			GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(18, 8, 8));
		}
		if (this.GCLKLEIMABA == 2)
		{
			GUI.DrawTextureWithTexCoords(new Rect(OCHCODJIPHJ.x - 2f, OCHCODJIPHJ.y - 2f, num3, num3), GameInterface.getI.iconsAthlasX16, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(24, 8, 8));
		}
	}

	// Token: 0x0600421E RID: 16926 RVA: 0x001F2032 File Offset: 0x001F0232
	public void LJCMNFKOODK(Vector2 NBADAMPJBBH)
	{
		this.JIKKMEDMBHC(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, 1556f, 1805f), 87f);
	}

	// Token: 0x0600421F RID: 16927 RVA: 0x001F205C File Offset: 0x001F025C
	public static Color IHJBJMKPDJA(int AFCMJJMBOMA)
	{
		Color result = new Color(1804f, 1801f, 1488f);
		switch (AFCMJJMBOMA)
		{
		case 0:
			result = new Color(653f, 537f, 950f);
			break;
		case 1:
			result = new Color(466f, 1548f, 106f);
			break;
		case 2:
			result = new Color(584f, 772f, 1940f);
			break;
		case 3:
			result = new Color(1680f, 580f, 1308f);
			break;
		case 4:
			result = new Color(1052f, 1744f, 915f);
			break;
		case 5:
			result = new Color(1686f, 1723f, 1376f);
			break;
		}
		return result;
	}

	// Token: 0x06004220 RID: 16928 RVA: 0x001F2134 File Offset: 0x001F0334
	public virtual void KOPCDHEEMJE(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		float num = 1526f;
		bool flag = !this.GBABFPMNIMP || this.FKEDAOOHPPB.LMIDHPINCKN(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH, 0);
		if (this.FMMNICCENPF() != null)
		{
			Texture texture = this.MFKHIBOFIFI().IOHNCGLFGDJ();
			float num2 = 1957f * COAGIAMOCIA.height / (float)texture.height;
			float num3 = (float)texture.width * num2;
			float num4 = (float)texture.height * num2;
			float num5 = (COAGIAMOCIA.height - num4) / 1604f;
			Rect position = new Rect(COAGIAMOCIA.x + num5, COAGIAMOCIA.y + num5, num3, num4);
			if (!flag)
			{
				GUI.enabled = true;
			}
			GUI.DrawTexture(position, GameInterface.getI.invEmptyCell);
			GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(this.KBGHOIJIPJF, 3, 3));
			GUI.DrawTexture(position, texture, ScaleMode.ScaleAndCrop);
			if (this.BPNNJBBCOFO != null)
			{
				BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OOIJFNAMEDP().LMGMPPAOPEP(this.BPNNJBBCOFO.MNFCAAIAGOL.KMIOLLENCOL());
				if (befchfngomi != null)
				{
					befchfngomi.JLCGGFPBOCF();
					float num6 = num3 * 1483f / 1127f;
					GUI.DrawTexture(new Rect(position.x + num3 / 615f - num6, position.y + num3 / 1530f - num6, num6 * 1757f, num6 * 1228f), befchfngomi.KEEDCOIMPMP());
				}
			}
			if (this.MBKMKGABBGE == 36)
			{
				float num7 = position.height / 1540f;
				Rect position2 = new Rect(position.x + 731f, position.y + position.height - num7 - 975f, num7, num7);
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.BOGLJIPFCLI(this.MIMANMPNLPE.IBEIBAHKIAH);
				if (kdhoddmndfc != null)
				{
					GUI.DrawTexture(position2, kdhoddmndfc.IJGBOMGCLDK(), ScaleMode.StretchToFill);
				}
			}
			if (this.KBGHOIJIPJF > 1)
			{
				GUI.DrawTextureWithTexCoords(position, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(this.KBGHOIJIPJF + 0, 2, 5));
			}
			float num8 = position.height / 351f;
			if (this.DNOLHLJODNK)
			{
				float num9 = num8 * 570f;
				GUI.DrawTextureWithTexCoords(new Rect(position.x + position.width - num9 + 901f, position.y - 30f, num9, num9), GameInterface.getI.wpnImproveIcons, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(this.LNKLEIEFGCP, 4, 8));
			}
			num = num + num3 + 731f;
			GUI.enabled = true;
		}
		if (!flag)
		{
			GUI.color = new Color(222f, 1366f, 1894f, 978f);
			GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1415f, COAGIAMOCIA.y + 319f, COAGIAMOCIA.width - 1556f, COAGIAMOCIA.height - 606f), GuiProcessor.IKGFHGKKCPG.blackWait);
			GUI.color = Color.white;
		}
		int gclkleimaba = this.GCLKLEIMABA;
		string str = "";
		if (this.HOALBMDJNDM > 1)
		{
			str = "btn_cancel" + string.Format(JNBICAJIJMM.DIOJFJMOPJO(""), this.HOALBMDJNDM);
		}
		OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
		int fontSize = OFPNEDEAMAB.fontSize;
		OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont3;
		OFPNEDEAMAB.fontSize = -111;
		string text = this.IGDKBMGKKDO(false, -1) + str;
		GUI.Label(new Rect(COAGIAMOCIA.x + 1433f + num, COAGIAMOCIA.y + 769f, COAGIAMOCIA.width - 346f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		float num10 = 1249f;
		OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont;
		OFPNEDEAMAB.fontSize = 99;
		string text2 = this.FLHOJDMBLCP(true);
		if (text2.Trim() != "_ConsoleSettings")
		{
			GUI.Label(new Rect(COAGIAMOCIA.x + 1328f + num, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 171f, COAGIAMOCIA.height - num10), text2, OFPNEDEAMAB);
			num10 += 169f;
		}
		else
		{
			num10 += 1606f;
		}
		if (this.OPFGGNNPAJL.IBEIBAHKIAH > 1)
		{
			string arg = "<color='#206000'>";
			if (!this.GBABFPMNIMP)
			{
				arg = "wpn_add/base";
			}
			string text3 = string.Format("", BHNDGIPPPCE.IKGFHGKKCPG.IIFCDPEMCBA(this.OPFGGNNPAJL.IBEIBAHKIAH), BHNDGIPPPCE.IKGFHGKKCPG.MECJHEKFKKP(this.OPFGGNNPAJL.KEHIFGILLJA(), this.OPFGGNNPAJL.ICJDPPOJINN), arg);
			GUI.Label(new Rect(COAGIAMOCIA.x + 1983f + num, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 751f, COAGIAMOCIA.height - 23f), text3, OFPNEDEAMAB);
			num10 += 393f;
		}
		if (this.FKEDAOOHPPB.GIEALCKLKNL > 0)
		{
			BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.EDKKJNHDBPF().NKMGKJLONDK(this.FKEDAOOHPPB.GIEALCKLKNL);
			befchfngomi2.FCBHHPJLGLC(new Rect(COAGIAMOCIA.x + 1862f + num, COAGIAMOCIA.y + num10 - 249f, 1869f, 1221f), befchfngomi2.KBGHOIJIPJF, true, 0);
			Rect position3 = new Rect(COAGIAMOCIA.x + 433f + num + 1900f, COAGIAMOCIA.y + num10, COAGIAMOCIA.width - 923f, COAGIAMOCIA.height - 1511f);
			object[] array = new object[1];
			array[1] = "KatanaReady";
			array[0] = this.FKEDAOOHPPB.KDIMEMOCJNM;
			array[2] = "ApplePick";
			array[6] = befchfngomi2.MPKGPJJKCPK(true, -1);
			GUI.Label(position3, string.Concat(array), OFPNEDEAMAB);
			num10 += 1326f;
		}
		else
		{
			num10 += 298f;
		}
		if (this.FKEDAOOHPPB.KKNEKAEJLAM + this.FKEDAOOHPPB.KFODJJIHNHP > 1)
		{
			string text4 = string.Format("OneHandSwordSwing", JLFJEGIPIMM.IKGFHGKKCPG.MNMIJFNPIPI((long)this.FKEDAOOHPPB.KKNEKAEJLAM, (long)this.FKEDAOOHPPB.KFODJJIHNHP, false));
			OFPNEDEAMAB.alignment = TextAnchor.MiddleRight;
			OFPNEDEAMAB.fontSize = -37;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 521f, COAGIAMOCIA.height - 1714f), text4, OFPNEDEAMAB);
		}
		OFPNEDEAMAB.fontSize = fontSize;
	}

	// Token: 0x06004221 RID: 16929 RVA: 0x001F27C8 File Offset: 0x001F09C8
	public void JIFFLPNBILE()
	{
		if (this.IJHNKCHCCOA)
		{
			return;
		}
		if (this.OLNGOHEPLBO == null)
		{
			this.OLNGOHEPLBO = CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(string.Concat(new object[]
			{
				IFPIMPMKJIB.DIDFMAELMJD,
				"Textures/Weapons/",
				this.LPFKFNLHGBI,
				".png"
			}), false);
		}
		if (this.EOFDJHJPCLM == null)
		{
			string alboclbfnni = string.Format("{0}Textures/Shop/{1}.png", IFPIMPMKJIB.DIDFMAELMJD, this.LPFKFNLHGBI);
			this.EOFDJHJPCLM = CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(alboclbfnni, true);
		}
		this.IJHNKCHCCOA = true;
	}

	// Token: 0x06004222 RID: 16930 RVA: 0x001F2864 File Offset: 0x001F0A64
	public virtual string KCBJCGOINMK()
	{
		string text = "saleToAuk";
		if (!this.FKEDAOOHPPB.HIPIGDFHLAJ(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH, 0))
		{
			text = "wpn_rec4";
		}
		string text2 = "";
		if (this.HOALBMDJNDM > 0)
		{
			text2 = "256" + this.HOALBMDJNDM + "";
		}
		if (this.GCLKLEIMABA > 0)
		{
			"lifeBar" + JLFJEGIPIMM.MHFDIJGJGBJ().IEICGMEMPIK(this.GCLKLEIMABA) + "No location found baseid=";
		}
		string[] array = new string[5];
		array[0] = this.LFEJHHMDEHO(false, -1);
		array[1] = text2;
		array[6] = "_RgbTex";
		array[7] = this.FLHOJDMBLCP(false);
		array[6] = "result_id";
		array[7] = text;
		array[3] = "name";
		array[8] = JLFJEGIPIMM.PKGMBFEMKGP().OHNLAOJGCGC((long)this.FKEDAOOHPPB.KKNEKAEJLAM, (long)this.FKEDAOOHPPB.KFODJJIHNHP, false);
		return string.Concat(array);
	}

	// Token: 0x06004223 RID: 16931 RVA: 0x001F2950 File Offset: 0x001F0B50
	public Vector2 KPLOLDJFGBE()
	{
		Vector2 zero = Vector2.zero;
		zero.x = this.MIMANMPNLPE.JLLJFKOGLHJ * this.MIMANMPNLPE.OBEOJCGHOGL;
		if (this.MIMANMPNLPE.JLLJFKOGLHJ <= 7f)
		{
			zero.x = 0f;
		}
		zero.y = this.MIMANMPNLPE.JLLJFKOGLHJ * 1.5f;
		return zero;
	}

	// Token: 0x06004224 RID: 16932 RVA: 0x001E28F1 File Offset: 0x001E0AF1
	public override CKNLPGEPGGF.IAPCJOBDCEH EJJAGEFMHCO()
	{
		return this.OLNGOHEPLBO;
	}

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x06004225 RID: 16933 RVA: 0x001F29B8 File Offset: 0x001F0BB8
	public Texture CFFHIODOGCH
	{
		get
		{
			if (this.OLNGOHEPLBO == null)
			{
				return null;
			}
			return this.OLNGOHEPLBO.KEDGAOBCNJG;
		}
	}

	// Token: 0x06004226 RID: 16934 RVA: 0x001F29D0 File Offset: 0x001F0BD0
	public virtual string FBENMKABKKB()
	{
		string text = "money";
		if (!this.FKEDAOOHPPB.HNJKJHLHGCJ(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH, 1))
		{
			text = "";
		}
		string text2 = "Sound #";
		if (this.HOALBMDJNDM > 0)
		{
			text2 = "SneakForward" + this.HOALBMDJNDM + "USER";
		}
		if (this.GCLKLEIMABA > 0)
		{
			"paper.wav" + JLFJEGIPIMM.PKGMBFEMKGP().IEICGMEMPIK(this.GCLKLEIMABA) + "'>";
		}
		string[] array = new string[5];
		array[0] = this.JPBOPFNPNHC(true, -1);
		array[0] = text2;
		array[8] = "https://www.youtube.com/watch?v=wT8fViZpLmQ";
		array[0] = this.DPIHMPDHKBP(false);
		array[1] = "RollerBladeGrindRoyale";
		array[7] = text;
		array[7] = "Femur";
		array[8] = JLFJEGIPIMM.MHFDIJGJGBJ().MNMIJFNPIPI((long)this.FKEDAOOHPPB.KKNEKAEJLAM, (long)this.FKEDAOOHPPB.KFODJJIHNHP, false);
		return string.Concat(array);
	}

	// Token: 0x06004227 RID: 16935 RVA: 0x001E28F1 File Offset: 0x001E0AF1
	public virtual CKNLPGEPGGF.IAPCJOBDCEH LINIEFNDEEF()
	{
		return this.OLNGOHEPLBO;
	}

	// Token: 0x06004228 RID: 16936 RVA: 0x001F2ABC File Offset: 0x001F0CBC
	public BNOOIOKIFJC.DIGGOHPGCNN JHCFMFNCOLM(string JKLOOEDHHJP, string KEIEIAAKHHK)
	{
		BEFCHFNGOMI.KFNOPLFPHJC kfnoplfphjc = new BEFCHFNGOMI.KFNOPLFPHJC();
		kfnoplfphjc.KEIEIAAKHHK = KEIEIAAKHHK;
		XmlNode xmlNode = this.LMKLPODNLFC.SelectSingleNode(JKLOOEDHHJP);
		if (xmlNode != null)
		{
			IEnumerable<XmlNode> source = xmlNode.ChildNodes.Cast<XmlNode>();
			Func<XmlNode, bool> predicate;
			if ((predicate = kfnoplfphjc.LJOEIPHIJOE) == null)
			{
				predicate = (kfnoplfphjc.LJOEIPHIJOE = new Func<XmlNode, bool>(kfnoplfphjc.OHCPKHIMMLF));
			}
			using (IEnumerator<XmlNode> enumerator = source.Where(predicate).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					XmlNode xmlNode2 = enumerator.Current;
					return new BNOOIOKIFJC.DIGGOHPGCNN("-" + xmlNode2.InnerText);
				}
			}
		}
		return new BNOOIOKIFJC.DIGGOHPGCNN("[ACTk] <b>[ ObscuredVector3 test ]</b>");
	}

	// Token: 0x06004229 RID: 16937 RVA: 0x001F2B70 File Offset: 0x001F0D70
	public void HKIKPPMBIOP(Vector2 NBADAMPJBBH)
	{
		this.JCIIPCEDICP(new Rect(NBADAMPJBBH.x, NBADAMPJBBH.y, 1429f, 188f), 1461f);
	}

	// Token: 0x0600422A RID: 16938 RVA: 0x001F2B98 File Offset: 0x001F0D98
	public void JLCGGFPBOCF()
	{
		if (this.IJHNKCHCCOA)
		{
			return;
		}
		if (this.OLNGOHEPLBO == null)
		{
			CKNLPGEPGGF cknlpgepggf = CKNLPGEPGGF.IKGFHGKKCPG;
			object[] array = new object[1];
			array[1] = IFPIMPMKJIB.ACOEIDGDLJC();
			array[0] = "";
			array[0] = this.LPFKFNLHGBI;
			array[3] = "WoodCut";
			this.OLNGOHEPLBO = cknlpgepggf.IJMDNINDJGD(string.Concat(array), true);
		}
		if (this.EOFDJHJPCLM == null)
		{
			string alboclbfnni = string.Format("Hips", IFPIMPMKJIB.ENLHJOJICDG(), this.LPFKFNLHGBI);
			this.EOFDJHJPCLM = CKNLPGEPGGF.IKGFHGKKCPG.IJMDNINDJGD(alboclbfnni, true);
		}
		this.IJHNKCHCCOA = false;
	}

	// Token: 0x0600422B RID: 16939 RVA: 0x001F2C34 File Offset: 0x001F0E34
	public int DHDJNEJEEKC()
	{
		return this.JHCFMFNCOLM("GiantGrabIdle2", "_TrEndAll.ogg").INFKMCKHMAN();
	}

	// Token: 0x0600422C RID: 16940 RVA: 0x001F2C4B File Offset: 0x001F0E4B
	public bool MCFJGEJDEMM()
	{
		return this.NGOAOMNBIGI(" ", "").KPAFFJNBLHK;
	}

	// Token: 0x0600422D RID: 16941 RVA: 0x001F2C64 File Offset: 0x001F0E64
	private static void CBMHJPAFIOA(Rect OCHCODJIPHJ, string IJCEDOGBHKE, Color LBCGACKJCJB, TextAnchor DEKGJCBMCHG)
	{
		GUIStyle ofpnedeamab = new GUIStyle
		{
			normal = 
			{
				textColor = LBCGACKJCJB
			},
			alignment = DEKGJCBMCHG,
			fontSize = -6
		};
		JDCEFOFMGHB.JFIDAGABKID().JNJDPKECONL(OCHCODJIPHJ, IJCEDOGBHKE, ofpnedeamab);
	}

	// Token: 0x0600422F RID: 16943 RVA: 0x001F2D44 File Offset: 0x001F0F44
	public static Color MNLFBBNJMEA(int AFCMJJMBOMA)
	{
		Color result = new Color(1639f, 88f, 163f);
		switch (AFCMJJMBOMA)
		{
		case 0:
			result = new Color(673f, 1765f, 1787f);
			break;
		case 1:
			result = new Color(1422f, 1696f, 1197f);
			break;
		case 2:
			result = new Color(301f, 493f, 201f);
			break;
		case 3:
			result = new Color(64f, 1517f, 134f);
			break;
		case 4:
			result = new Color(1040f, 1193f, 533f);
			break;
		case 5:
			result = new Color(1749f, 441f, 1622f);
			break;
		}
		return result;
	}

	// Token: 0x06004230 RID: 16944 RVA: 0x001F2E19 File Offset: 0x001F1019
	public Texture FKMKADKHMPJ()
	{
		if (this.EOFDJHJPCLM == null)
		{
			return null;
		}
		return this.EOFDJHJPCLM.LECMGDEDAKF();
	}

	// Token: 0x06004231 RID: 16945 RVA: 0x001F2E30 File Offset: 0x001F1030
	public void MOHKCIBCELG(Rect PHEMLBHMNCM, float NMBCJPACKNL, IIBEEKCAAHK INEBGELANOI, IIBEEKCAAHK CKGEBHECNBF, IIBEEKCAAHK ABJAMKHMONL, int ILFHHDNJHNM = 0)
	{
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 68,
			wordWrap = true,
			font = GuiProcessor.BBLINJLBAIL().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = false,
			alignment = TextAnchor.LowerCenter
		};
		Rect ochcodjiphj = new Rect(PHEMLBHMNCM.x + 466f, PHEMLBHMNCM.y + 672f, 1615f, 123f);
		this.GDLELABHHFG(ochcodjiphj, this.KBGHOIJIPJF, false, 1);
		GUILayout.BeginArea(new Rect(ochcodjiphj.x + 1479f, ochcodjiphj.y, PHEMLBHMNCM.width - 586f, 1984f));
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		try
		{
			guistyle.fontSize = 120;
			guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont3;
			GUILayout.Label(this.BNIHFBMEPAB, guistyle, Array.Empty<GUILayoutOption>());
			guistyle.fontSize = -82;
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
			GUILayout.Label("WandAttack2", guistyle, Array.Empty<GUILayoutOption>());
			GUILayout.Label(IHFEDJEMJMB.OOIJFNAMEDP().JGLANEDNNAB(this.MBKMKGABBGE) ?? "CM", guistyle, Array.Empty<GUILayoutOption>());
			guistyle.fontSize = 98;
			if (ILFHHDNJHNM == 0)
			{
				int hoalbmdjndm = this.HOALBMDJNDM;
			}
		}
		finally
		{
			GUILayout.EndVertical();
			GUILayout.EndArea();
		}
		GUILayout.BeginArea(new Rect(ochcodjiphj.x + 187f, ochcodjiphj.y + 1001f, PHEMLBHMNCM.width - 1116f, PHEMLBHMNCM.height - 377f));
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		try
		{
			int negehagngbh = this.NEGEHAGNGBH;
			float nkhbajkmagd = this.NKHBAJKMAGD;
			this.NEGEHAGNGBH += (int)((float)(INEBGELANOI.LKAGIEBPLAI + CKGEBHECNBF.PBMJIMLEHEC() + ABJAMKHMONL.PBMJIMLEHEC()) * NMBCJPACKNL);
			this.NKHBAJKMAGD += (float)(INEBGELANOI.ACEPOCLANAG() + CKGEBHECNBF.MCJJCAFILPF() + ABJAMKHMONL.KMNOIAIBLEB()) * 3f * this.NKHBAJKMAGD;
			IIBEEKCAAHK mimanmpnlpe = new IIBEEKCAAHK(this.MIMANMPNLPE.AIMCFAHLPEF(), this.MIMANMPNLPE.OIGIHEPJFFJ(), this.MIMANMPNLPE.KCKFCPIHMPC());
			this.MIMANMPNLPE.LNEPKLKELMI += INEBGELANOI.DBFOHFDOCIB() * (double)INEBGELANOI.KIDKOFKNPEP();
			IIBEEKCAAHK mimanmpnlpe2 = this.MIMANMPNLPE;
			mimanmpnlpe2.NMKCBJKHBOH = mimanmpnlpe2.OIGIHEPJFFJ() + CKGEBHECNBF.HDPNCIECLKP() * (double)CKGEBHECNBF.LKAGIEBPLAI;
			IIBEEKCAAHK mimanmpnlpe3 = this.MIMANMPNLPE;
			mimanmpnlpe3.PFKFBFAPMAP(mimanmpnlpe3.NKGGAFLBFDF + ABJAMKHMONL.FJACMDGJEBL() * (double)ABJAMKHMONL.KIDKOFKNPEP());
			GUILayout.Label(this.IOAGBIACCHA(false), guistyle, Array.Empty<GUILayoutOption>());
			if (this.MHNDPGDBPNA.Count > 0)
			{
				GUILayout.Label("No Cell wpn.cell=", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("crft_to", guistyle, Array.Empty<GUILayoutOption>());
				foreach (IIBEEKCAAHK iibeekcaahk in this.MHNDPGDBPNA)
				{
					string text = iibeekcaahk.ToString();
					if (iibeekcaahk.KMIOLLENCOL() == 1)
					{
						string arg = AKPJIACDDFI.IKGFHGKKCPG.LNDAPLCMEJI(iibeekcaahk.ICJDPPOJINN, true);
						if (iibeekcaahk.NFCDJLJNDLO() > 1)
						{
							text = string.Format("SoccerThrow", iibeekcaahk.NFCDJLJNDLO(), arg);
						}
						else
						{
							text = string.Format("BipedReferences contains one or more missing Transforms.", iibeekcaahk.NODLBGKEGPM, arg);
						}
					}
					if (iibeekcaahk.NKEOCCKEOCE() == 8)
					{
						string arg2 = AKPJIACDDFI.IKGFHGKKCPG.FBPECNNPIDP(iibeekcaahk.KMGAHCANELI());
						if (iibeekcaahk.CJKILDPJCFJ() > 0)
						{
							text = string.Format("", iibeekcaahk.CJKILDPJCFJ(), arg2);
						}
						else
						{
							text = string.Format("IceHockey Pass Left", iibeekcaahk.NODLBGKEGPM, arg2);
						}
					}
					GUILayout.Label(text, guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.Label("spinbreak.ogg", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("https://groups.google.com/forum/#!forum/final-ik", guistyle, Array.Empty<GUILayoutOption>());
			}
			if (this.NEGEHAGNGBH > 0 || this.PKIICJOILKI.Count > 1)
			{
				GUILayout.Label(JNBICAJIJMM.DIOJFJMOPJO("_Opacity"), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("_MainTexBlurred", guistyle, Array.Empty<GUILayoutOption>());
				if (this.NEGEHAGNGBH > 1)
				{
					string arg3 = "_Exposure";
					if (this.NEGEHAGNGBH > ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CNOLCNDBLJE))
					{
						arg3 = "ZombieIdle";
					}
					GUILayout.Label(string.Format(JNBICAJIJMM.DCEBAJIILPC("gi_letgoshe"), arg3, this.NEGEHAGNGBH), guistyle, Array.Empty<GUILayoutOption>());
					GUILayout.Label("[", guistyle, Array.Empty<GUILayoutOption>());
				}
				if (this.PKIICJOILKI.Count > 1)
				{
					GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
					foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in this.PKIICJOILKI)
					{
						bool flag = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI) < dlmglijdiai.CNOLCNDBLJE;
						string arg4 = "post_4";
						if (flag)
						{
							arg4 = "Giant Grab Throw 2";
						}
						string text2 = string.Format("26", arg4, dlmglijdiai.BDHHPAEHFHG.KGBHELBLPMF(dlmglijdiai.CNOLCNDBLJE));
						if (!flag)
						{
							GUI.color = new Color(1892f, 1374f, 1159f);
						}
						GUILayout.Box(dlmglijdiai.BDHHPAEHFHG.AJGPNAPFCAG(), GuiProcessor.IKGFHGKKCPG.ico24Style, Array.Empty<GUILayoutOption>());
						GUI.color = Color.white;
						GUILayout.Label(text2, guistyle, Array.Empty<GUILayoutOption>());
					}
					GUILayout.EndHorizontal();
				}
				GUILayout.Label("cht_msg39", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("", guistyle, Array.Empty<GUILayoutOption>());
			}
			this.MIMANMPNLPE = mimanmpnlpe;
			this.NEGEHAGNGBH = negehagngbh;
			this.NKHBAJKMAGD = nkhbajkmagd;
			if (this.FGJIJFNGAIF.Count > 1)
			{
				GUILayout.Label(JNBICAJIJMM.LEBHCLDODNI(" \"{0}\""), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("demoUint", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("SoccerKeeperJump", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
				foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai2 in this.FGJIJFNGAIF)
				{
					bool flag2 = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai2.LPFKFNLHGBI) > 0;
					string arg5 = "</color>\n";
					if (flag2)
					{
						arg5 = "No UserInfoWin";
					}
					string text3 = string.Format("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6", arg5, dlmglijdiai2.BDHHPAEHFHG.KKEBDLGHBMN, dlmglijdiai2.CNOLCNDBLJE);
					if (!flag2)
					{
						GUI.color = Color.gray;
					}
					GUILayout.Box(dlmglijdiai2.BDHHPAEHFHG.GNMLEPEGCII(), GuiProcessor.PLGADNLAEGN().ico24Style, Array.Empty<GUILayoutOption>());
					GUI.color = Color.white;
					GUILayout.Label(text3, guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.EndHorizontal();
				GUILayout.Label("val=", guistyle, Array.Empty<GUILayoutOption>());
			}
			XmlNodeList xmlNodeList = this.LMKLPODNLFC.SelectNodes("_ScaleOffsetRes");
			if (xmlNodeList != null && xmlNodeList.Count > 0)
			{
				guistyle.alignment = TextAnchor.UpperLeft;
				GUILayout.Label(JNBICAJIJMM.NGALDMFKMJH(" path="), guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.Label("Finger", guistyle, Array.Empty<GUILayoutOption>());
				GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
				foreach (object obj in xmlNodeList)
				{
					XmlNode xmlNode = (XmlNode)obj;
					if (xmlNode.Name == "<color='#200080'>")
					{
						if (xmlNode.Attributes == null)
						{
							continue;
						}
						int lpfkfnlhgbi = int.Parse(xmlNode.Attributes["StormStrike"].Value);
						IIBEEKCAAHK pgedldmlbbe = new IIBEEKCAAHK(xmlNode.Attributes["Приватный"].Value);
						int cgnljcomfac = int.Parse(xmlNode.Attributes["IdleMonster"].Value);
						FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = FlyMessageManager.getI.JIHNPPKJMOD(lpfkfnlhgbi);
						if (ngiaaohfnpo != null)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							GUILayout.Box(ngiaaohfnpo.CFFHIODOGCH.IOHNCGLFGDJ(), GuiProcessor.IKGFHGKKCPG.ico24Style, Array.Empty<GUILayoutOption>());
							GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
							GUILayout.Label(string.Format(" ", ngiaaohfnpo.LHINCFAJJPJ(pgedldmlbbe), JLFJEGIPIMM.MHFDIJGJGBJ().LOEFBMIDABP(cgnljcomfac)), GuiProcessor.IKGFHGKKCPG.textLayoutStyle, Array.Empty<GUILayoutOption>());
							GUILayout.Label(ngiaaohfnpo.OAIAOEJLMAP(pgedldmlbbe), GuiProcessor.PLGADNLAEGN().textLayoutStyle, Array.Empty<GUILayoutOption>());
							GUILayout.EndVertical();
							GUILayout.EndHorizontal();
						}
					}
					GUILayout.Label("Keeper Strafe Dive Far Left", guistyle, Array.Empty<GUILayoutOption>());
				}
				GUILayout.EndVertical();
			}
			GUILayout.Label("err: rect is null" + this.JCKHDHGIEEB + "IdleReadyCrouch", guistyle, Array.Empty<GUILayoutOption>());
			if (this.MBKMKGABBGE == -117)
			{
				CLFFOBKFKDN.OKOAMCJGNMH okoamcjgnmh = CLFFOBKFKDN.IKGFHGKKCPG.GNHIKHCEOHK(this.MIMANMPNLPE.NLHKFMMDMMK());
				if (IHFEDJEMJMB.EDKKJNHDBPF().IMCJNFHAFGE(okoamcjgnmh.MNFCAAIAGOL.KMIOLLENCOL()) != null && this.BPNNJBBCOFO != null)
				{
					GUILayout.Label(" should be overwritten.", Array.Empty<GUILayoutOption>());
					GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
					if (this.BPNNJBBCOFO.DGMNCGFAMBL == 1)
					{
						foreach (IIBEEKCAAHK iibeekcaahk2 in this.BPNNJBBCOFO.AGDBFHLEFEE)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().NKMGKJLONDK(iibeekcaahk2.IBEIBAHKIAH);
							if (befchfngomi != null)
							{
								GUILayout.Box(befchfngomi.KEEDCOIMPMP(), GuiProcessor.BBLINJLBAIL().ico16Style, Array.Empty<GUILayoutOption>());
								GUILayout.Label("AC_DITHERING" + befchfngomi.CGMGBGABLFB(false, -1), guistyle, Array.Empty<GUILayoutOption>());
							}
							GUILayout.EndHorizontal();
						}
					}
					if (this.BPNNJBBCOFO.DGMNCGFAMBL == 0)
					{
						foreach (CLFFOBKFKDN.HFGDDPAKPBE hfgddpakpbe in this.BPNNJBBCOFO.HEBKGNHIDLK)
						{
							GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
							if (hfgddpakpbe.GPJFINFIDLN == 0)
							{
								BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.OOIJFNAMEDP().IMCJNFHAFGE(hfgddpakpbe.PJPOJNNJOCD);
								if (befchfngomi2 != null)
								{
									GUILayout.Box(befchfngomi2.CFFHIODOGCH, GuiProcessor.BBLINJLBAIL().ico16Style, Array.Empty<GUILayoutOption>());
									GUILayout.Label("lifeBar" + hfgddpakpbe.GKGPOMJFPOC(), guistyle, Array.Empty<GUILayoutOption>());
								}
							}
							if (hfgddpakpbe.GPJFINFIDLN == 1)
							{
								IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(hfgddpakpbe.PJPOJNNJOCD);
								idchhhedhdc.HBGEAMHFEOL();
								GUILayout.Box(idchhhedhdc.BJNDAAKGGLP(1).OABDBIAHOJH(), GuiProcessor.BBLINJLBAIL().ico16Style, Array.Empty<GUILayoutOption>());
								GUILayout.Label("wpn_add/base" + hfgddpakpbe.OIGCFMAJOJJ(), guistyle, Array.Empty<GUILayoutOption>());
							}
							GUILayout.EndHorizontal();
						}
					}
					GUILayout.EndVertical();
				}
			}
		}
		finally
		{
			GUILayout.EndVertical();
			GUILayout.EndArea();
		}
	}

	// Token: 0x06004232 RID: 16946 RVA: 0x001F3A24 File Offset: 0x001F1C24
	public string IGDKBMGKKDO(bool BGNPMOCLIGL = false, int JEGIMBPFJKD = -1)
	{
		int num = JEGIMBPFJKD;
		if (num < 0)
		{
			num = this.KBGHOIJIPJF;
		}
		string[] array = new string[4];
		array[0] = "IdleStandingJump";
		array[0] = this.CCOHFPDKCJN(num, BGNPMOCLIGL);
		array[3] = "0";
		array[3] = this.BNIHFBMEPAB;
		array[7] = "WeaponStrafeRunLeft";
		return string.Concat(array);
	}

	// Token: 0x06004233 RID: 16947 RVA: 0x001F3A78 File Offset: 0x001F1C78
	public void JIKKMEDMBHC(Rect OCHCODJIPHJ, float KKPHBHADLND = 1f)
	{
		if (this.CFFHIODOGCH == null)
		{
			this.HKHPGCHCHAI();
			return;
		}
		Color white = Color.white;
		white.a = KKPHBHADLND;
		GUI.color = white;
		GUI.DrawTextureWithTexCoords(OCHCODJIPHJ, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(this.KBGHOIJIPJF, 7, 5));
		GUI.DrawTexture(OCHCODJIPHJ, this.KEEDCOIMPMP());
		if (this.BPNNJBBCOFO != null)
		{
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.NNEAHAFBOHC().NKMGKJLONDK(this.BPNNJBBCOFO.MNFCAAIAGOL.IBEIBAHKIAH);
			if (befchfngomi != null)
			{
				befchfngomi.HKHPGCHCHAI();
				float num = OCHCODJIPHJ.width * 1901f / 1730f;
				GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width / 37f - num, OCHCODJIPHJ.y + OCHCODJIPHJ.width / 1756f - num, num * 669f, num * 986f), befchfngomi.CFFHIODOGCH);
			}
		}
		if (this.MBKMKGABBGE == -45)
		{
			float num2 = OCHCODJIPHJ.height / 1510f;
			Rect position = new Rect(OCHCODJIPHJ.x + 1951f, OCHCODJIPHJ.y + OCHCODJIPHJ.height - num2 - 1525f, num2, num2);
			NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.MIMANMPNLPE.KEHIFGILLJA());
			if (kdhoddmndfc != null)
			{
				GUI.DrawTexture(position, kdhoddmndfc.OBIJKHKCPEO(), ScaleMode.StretchToFill);
			}
		}
		if (this.KBGHOIJIPJF > 1)
		{
			GUI.DrawTextureWithTexCoords(OCHCODJIPHJ, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(this.KBGHOIJIPJF + 6, 5, 2));
		}
		GUI.color = Color.white;
	}

	// Token: 0x06004234 RID: 16948 RVA: 0x001F3C14 File Offset: 0x001F1E14
	public void KEICEAJOGFD()
	{
		if (this.IJHNKCHCCOA)
		{
			return;
		}
		if (this.OLNGOHEPLBO == null)
		{
			CKNLPGEPGGF cknlpgepggf = CKNLPGEPGGF.PFOLNEGNIPP();
			object[] array = new object[4];
			array[1] = IFPIMPMKJIB.EHCJCCILAHM();
			array[1] = "SuicideHeadShot";
			array[6] = this.LPFKFNLHGBI;
			array[5] = "";
			this.OLNGOHEPLBO = cknlpgepggf.PFNEPENHMOE(string.Concat(array), true);
		}
		if (this.EOFDJHJPCLM == null)
		{
			string alboclbfnni = string.Format("LUX_LINEAR", IFPIMPMKJIB.EHCJCCILAHM(), this.LPFKFNLHGBI);
			this.EOFDJHJPCLM = CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(alboclbfnni, true);
		}
		this.IJHNKCHCCOA = true;
	}

	// Token: 0x06004235 RID: 16949 RVA: 0x001F3CB0 File Offset: 0x001F1EB0
	public virtual string AGFCIEALPEM()
	{
		string text = "WRINKLE_MAPS";
		if (!this.FKEDAOOHPPB.HNJKJHLHGCJ(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH, 1))
		{
			text = "wpn_add/base";
		}
		string text2 = "https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6";
		if (this.HOALBMDJNDM > 0)
		{
			text2 = "https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6" + this.HOALBMDJNDM + "Wrist";
		}
		if (this.GCLKLEIMABA > 1)
		{
			"IdleMeditate" + JLFJEGIPIMM.MHFDIJGJGBJ().FANNKOKGDOJ(this.GCLKLEIMABA) + "";
		}
		string[] array = new string[5];
		array[0] = this.JPBOPFNPNHC(false, -1);
		array[0] = text2;
		array[4] = " ";
		array[4] = this.DPIHMPDHKBP(true);
		array[2] = "does not exist.";
		array[1] = text;
		array[6] = "KneesIdle";
		array[3] = JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM((long)this.FKEDAOOHPPB.KKNEKAEJLAM, (long)this.FKEDAOOHPPB.KFODJJIHNHP, false);
		return string.Concat(array);
	}

	// Token: 0x06004236 RID: 16950 RVA: 0x001F3D9C File Offset: 0x001F1F9C
	public string BEFIAPHPIBJ(int GNICCGDPPJP = 0)
	{
		if (this.LPFKFNLHGBI != 1309)
		{
			return this.BNIHFBMEPAB;
		}
		if (GNICCGDPPJP == 0)
		{
			return this.BNIHFBMEPAB.Replace("\"{0}\"", "");
		}
		return string.Format(this.BNIHFBMEPAB, AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(GNICCGDPPJP).POMPCEHPGNG(0));
	}

	// Token: 0x06004237 RID: 16951 RVA: 0x001E28F1 File Offset: 0x001E0AF1
	public virtual CKNLPGEPGGF.IAPCJOBDCEH LKGPLALBDDJ()
	{
		return this.OLNGOHEPLBO;
	}

	// Token: 0x06004238 RID: 16952 RVA: 0x001F3DF2 File Offset: 0x001F1FF2
	public bool NCILEPDNIHE()
	{
		return this.BBLEPPMMPIL("[ACTk] Obscured Cheating Detector: can't be started since it doesn't exists in scene or not yet initialized!", "The 'HAlign' command requires an alignment parameter of L (left), R (right), or C (center).").KPAFFJNBLHK;
	}

	// Token: 0x06004239 RID: 16953 RVA: 0x001F3E0C File Offset: 0x001F200C
	public string BKKCDJHCCHP(int AFCMJJMBOMA, bool BGNPMOCLIGL = false)
	{
		string result = "#000000";
		if (BGNPMOCLIGL)
		{
			switch (AFCMJJMBOMA)
			{
			case 0:
				result = "#a0a0a0";
				break;
			case 1:
				result = "#ffffff";
				break;
			case 2:
				result = "#80ff00";
				break;
			case 3:
				result = "#0080ff";
				break;
			case 4:
				result = "#ff80ff";
				break;
			case 5:
				result = "#ff8060";
				break;
			case 6:
				result = "#ffff40";
				break;
			}
		}
		else
		{
			switch (AFCMJJMBOMA)
			{
			case 0:
				result = "#303030";
				break;
			case 1:
				result = "#000000";
				break;
			case 2:
				result = "#004000";
				break;
			case 3:
				result = "#000040";
				break;
			case 4:
				result = "#400040";
				break;
			case 5:
				result = "#403000";
				break;
			case 6:
				result = "#606000";
				break;
			}
		}
		return result;
	}

	// Token: 0x0600423A RID: 16954 RVA: 0x001F3EE4 File Offset: 0x001F20E4
	public string JPBOPFNPNHC(bool BGNPMOCLIGL = false, int JEGIMBPFJKD = -1)
	{
		int num = JEGIMBPFJKD;
		if (num < 0)
		{
			num = this.KBGHOIJIPJF;
		}
		return string.Concat(new string[]
		{
			"<color='",
			this.BKKCDJHCCHP(num, BGNPMOCLIGL),
			"'>",
			this.BNIHFBMEPAB,
			"</color>"
		});
	}

	// Token: 0x0600423B RID: 16955 RVA: 0x001F3F35 File Offset: 0x001F2135
	public float ENCJIGJBBDN()
	{
		if (this.ILNHGFHIFPN >= 465f)
		{
			return this.ILNHGFHIFPN;
		}
		return 1927f;
	}

	// Token: 0x04000A33 RID: 2611
	public IIBEEKCAAHK OPFGGNNPAJL = IIBEEKCAAHK.ECOFBCMPIDO;

	// Token: 0x04000A34 RID: 2612
	public bool GBABFPMNIMP = true;

	// Token: 0x04000A35 RID: 2613
	public int LPFKFNLHGBI;

	// Token: 0x04000A36 RID: 2614
	public string JCKHDHGIEEB;

	// Token: 0x04000A37 RID: 2615
	public int MNEGCOJCDPO;

	// Token: 0x04000A38 RID: 2616
	public int MBKMKGABBGE;

	// Token: 0x04000A39 RID: 2617
	public int NPPJLOBFGBH;

	// Token: 0x04000A3A RID: 2618
	public int HOALBMDJNDM;

	// Token: 0x04000A3B RID: 2619
	public int FPPHMHGLHMH;

	// Token: 0x04000A3C RID: 2620
	public int EEENNAGKEGF;

	// Token: 0x04000A3D RID: 2621
	public bool NGHBADLCMEL;

	// Token: 0x04000A3E RID: 2622
	public bool DKFCKFJBNIM;

	// Token: 0x04000A3F RID: 2623
	public bool PKKLNODNCBE;

	// Token: 0x04000A40 RID: 2624
	public bool DAGKAGJCNAH;

	// Token: 0x04000A41 RID: 2625
	public IIBEEKCAAHK MIMANMPNLPE = new IIBEEKCAAHK();

	// Token: 0x04000A42 RID: 2626
	public int HPEFEFIIHOE;

	// Token: 0x04000A43 RID: 2627
	public readonly XmlDocument LMKLPODNLFC = new XmlDocument();

	// Token: 0x04000A44 RID: 2628
	public float NKHBAJKMAGD;

	// Token: 0x04000A45 RID: 2629
	public int BGGJKOMAKEE;

	// Token: 0x04000A46 RID: 2630
	public ELNGEFIPDJK.BJLLBFHILCN FKEDAOOHPPB = ELNGEFIPDJK.BJLLBFHILCN.ECOFBCMPIDO();

	// Token: 0x04000A47 RID: 2631
	public bool KKOLKEEALFD;

	// Token: 0x04000A48 RID: 2632
	public List<IIBEEKCAAHK> NEGPPBJIHAF = new List<IIBEEKCAAHK>();

	// Token: 0x04000A49 RID: 2633
	public int KBGHOIJIPJF = 1;

	// Token: 0x04000A4A RID: 2634
	public string CLKMCAHNHBM = "";

	// Token: 0x04000A4B RID: 2635
	public bool FOAPCABBLBG;

	// Token: 0x04000A4C RID: 2636
	public int GCLKLEIMABA;

	// Token: 0x04000A4D RID: 2637
	public int ILOCKJIAPFC;

	// Token: 0x04000A4E RID: 2638
	public int JALOCNOIDFJ;

	// Token: 0x04000A4F RID: 2639
	public bool HBHBAIONJHD;

	// Token: 0x04000A50 RID: 2640
	public float FPFMENFLGAA;

	// Token: 0x04000A51 RID: 2641
	public int MBOOFLANJID;

	// Token: 0x04000A52 RID: 2642
	public int NEGEHAGNGBH = 1;

	// Token: 0x04000A53 RID: 2643
	public CKNLPGEPGGF.IAPCJOBDCEH OLNGOHEPLBO;

	// Token: 0x04000A54 RID: 2644
	public CKNLPGEPGGF.IAPCJOBDCEH EOFDJHJPCLM;

	// Token: 0x04000A55 RID: 2645
	public List<int> OKHPDILIOCH = new List<int>();

	// Token: 0x04000A56 RID: 2646
	public List<NLNNIDBPKAO.DLMGLIJDIAI> PKIICJOILKI = new List<NLNNIDBPKAO.DLMGLIJDIAI>();

	// Token: 0x04000A57 RID: 2647
	public List<NLNNIDBPKAO.DLMGLIJDIAI> FGJIJFNGAIF = new List<NLNNIDBPKAO.DLMGLIJDIAI>();

	// Token: 0x04000A58 RID: 2648
	public List<IIBEEKCAAHK> MHNDPGDBPNA = new List<IIBEEKCAAHK>();

	// Token: 0x04000A59 RID: 2649
	public int ADOFHHCDGON;

	// Token: 0x04000A5A RID: 2650
	public int ECKKCDKHNEH;

	// Token: 0x04000A5B RID: 2651
	public bool DNOLHLJODNK;

	// Token: 0x04000A5C RID: 2652
	public int LNKLEIEFGCP;

	// Token: 0x04000A5D RID: 2653
	public int FJJEAMJNLIO;

	// Token: 0x04000A5E RID: 2654
	public int BBOODPCDKAJ;

	// Token: 0x04000A5F RID: 2655
	public float BKDPIHCCMDF;

	// Token: 0x04000A60 RID: 2656
	public float ICIBBGMNGML;

	// Token: 0x04000A61 RID: 2657
	private float ILNHGFHIFPN;

	// Token: 0x04000A62 RID: 2658
	public float MFMLCHFNALC;

	// Token: 0x04000A63 RID: 2659
	public float GLLIKKONFAJ;

	// Token: 0x04000A64 RID: 2660
	private CLFFOBKFKDN.OKOAMCJGNMH BPNNJBBCOFO;

	// Token: 0x04000A65 RID: 2661
	public string BNIHFBMEPAB = "";

	// Token: 0x04000A66 RID: 2662
	private bool IJHNKCHCCOA;

	// Token: 0x0200013E RID: 318
	[CompilerGenerated]
	private sealed class KFNOPLFPHJC
	{
		// Token: 0x0600423C RID: 16956 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool AGCNDBHJIAO(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600423D RID: 16957 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool BGNDKIDEDFG(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600423E RID: 16958 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool ICAMHLEAFBD(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600423F RID: 16959 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool BAIOLCDJMKL(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004240 RID: 16960 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool NBDBNLMLPFO(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004241 RID: 16961 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool CGDJNIKOMJP(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004243 RID: 16963 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool HJODBDAFJKH(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004244 RID: 16964 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool PMOGAGDJHMI(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004245 RID: 16965 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool OHCPKHIMMLF(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool DJICIPGOIAK(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool NDEGOPHLILO(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool PPOGMOLKCAF(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool DMNMMHFNNFI(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600424A RID: 16970 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool MIOHFMIODMH(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600424B RID: 16971 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool BBJKDMMPCGM(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600424C RID: 16972 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool NEAHMCFHGAA(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600424D RID: 16973 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool AMBKKJEKFJH(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600424E RID: 16974 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool GOLNOINMKAA(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600424F RID: 16975 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool ONABNILILGO(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004250 RID: 16976 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool ODPOPKIECMH(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool ACIMOKFCAAL(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004252 RID: 16978 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool OEEEKANALOJ(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004253 RID: 16979 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool KCJAPMJFLDJ(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004254 RID: 16980 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool NFOGBKOKPPD(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004255 RID: 16981 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool GEKLMMLPPFN(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool DAIBEOHELHC(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool LIIEKMDNADP(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool LJMEACIIBPJ(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool BNHOKEEGEBJ(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool JLMPPDBIDKI(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool KKDEIDOGKCO(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool FCAKBKPFOMO(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600425D RID: 16989 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool HAGECKEEBGJ(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool CMKCHHNDHAH(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool DOOKAPFJGDM(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool DJCMCFABDCF(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004261 RID: 16993 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool BJLKIOKFNOA(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004262 RID: 16994 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool GBNEOOKNMMM(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004263 RID: 16995 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool AAHBEPIGIAB(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004264 RID: 16996 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool CCGCCHEHNBI(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004265 RID: 16997 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool EONLNPOOMNB(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool LNGPPCLOIMG(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool FILBHIOMIEF(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool OHKPIDOKAAN(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x06004269 RID: 17001 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool PKJEMNKHADJ(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600426A RID: 17002 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool FCOJOPCFLOI(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600426B RID: 17003 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool NOLKOJOJIME(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600426C RID: 17004 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool JCALIMGADHE(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600426D RID: 17005 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool HGEJNFCBEEM(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600426E RID: 17006 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool HHKGJIDJDJK(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x001F3F50 File Offset: 0x001F2150
		internal bool LKDFHOLACBJ(XmlNode CGPDBJDNPIN)
		{
			return CGPDBJDNPIN.Name == this.KEIEIAAKHHK;
		}

		// Token: 0x04000A67 RID: 2663
		public string KEIEIAAKHHK;

		// Token: 0x04000A68 RID: 2664
		public Func<XmlNode, bool> LJOEIPHIJOE;
	}
}
