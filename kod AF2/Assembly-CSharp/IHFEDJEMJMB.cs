using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEngine;

// Token: 0x02000204 RID: 516
internal class IHFEDJEMJMB
{
	// Token: 0x060077EF RID: 30703 RVA: 0x00396CF6 File Offset: 0x00394EF6
	public string OLPPMBPFKGN(int OFGDGOAKPAG)
	{
		return JNBICAJIJMM.DBMJJPBOPEK().GOOKDBEDLHJ("Giant2HandSlamSwing", "lifeBar" + OFGDGOAKPAG);
	}

	// Token: 0x060077F0 RID: 30704 RVA: 0x00396D17 File Offset: 0x00394F17
	public static IHFEDJEMJMB NNEAHAFBOHC()
	{
		if (IHFEDJEMJMB.AGFGEGLPLMJ == null)
		{
			IHFEDJEMJMB.AGFGEGLPLMJ = new IHFEDJEMJMB();
			IHFEDJEMJMB.AGFGEGLPLMJ.OLEEAIFGCOM();
		}
		return IHFEDJEMJMB.AGFGEGLPLMJ;
	}

	// Token: 0x060077F1 RID: 30705 RVA: 0x00396D39 File Offset: 0x00394F39
	public string PAAJPMHLDEM(int OFGDGOAKPAG)
	{
		return JNBICAJIJMM.CLIMNFDGOEG().CAFEIHBPIJB("_CutoutReferenceTexture", "wpn_rod2" + OFGDGOAKPAG);
	}

	// Token: 0x060077F2 RID: 30706 RVA: 0x00396D5A File Offset: 0x00394F5A
	public string KAOIPKCILAA(int OFGDGOAKPAG)
	{
		return JNBICAJIJMM.EKEBHIJMEML().CAFEIHBPIJB("BowIdle", "HookPoint" + OFGDGOAKPAG);
	}

	// Token: 0x060077F3 RID: 30707 RVA: 0x00396D7B File Offset: 0x00394F7B
	public string CAGCDEPAICB(int LPFKFNLHGBI)
	{
		return this.MEHMPCCBDHE[LPFKFNLHGBI];
	}

	// Token: 0x060077F4 RID: 30708 RVA: 0x00396D89 File Offset: 0x00394F89
	public string DOFOPKPJDED(int OFGDGOAKPAG)
	{
		return JNBICAJIJMM.IKGFHGKKCPG.OMNMDGIGEFD("INTERFACE", "qname_" + OFGDGOAKPAG);
	}

	// Token: 0x060077F5 RID: 30709 RVA: 0x00396DAA File Offset: 0x00394FAA
	public void NDKJBHCGHCL(EKBAPCMPANI MEJMEKODJAE)
	{
		if (this.AEGGLCOIDNH.ContainsKey(MEJMEKODJAE.LPFKFNLHGBI))
		{
			this.AEGGLCOIDNH[MEJMEKODJAE.LPFKFNLHGBI] = MEJMEKODJAE;
			return;
		}
		this.AEGGLCOIDNH.Add(MEJMEKODJAE.LPFKFNLHGBI, MEJMEKODJAE);
	}

	// Token: 0x060077F6 RID: 30710 RVA: 0x00396DE4 File Offset: 0x00394FE4
	public static IHFEDJEMJMB AGCBLDIBMNB()
	{
		if (IHFEDJEMJMB.AGFGEGLPLMJ == null)
		{
			IHFEDJEMJMB.AGFGEGLPLMJ = new IHFEDJEMJMB();
			IHFEDJEMJMB.AGFGEGLPLMJ.BCMIIMNMKNO();
		}
		return IHFEDJEMJMB.AGFGEGLPLMJ;
	}

	// Token: 0x060077F7 RID: 30711 RVA: 0x00396E06 File Offset: 0x00395006
	public string BOKCIMBOIFF(int OFGDGOAKPAG)
	{
		return JNBICAJIJMM.IMLLGEMPHAP().CAFEIHBPIJB("hgtDst=", "BowReady2" + OFGDGOAKPAG);
	}

	// Token: 0x060077F8 RID: 30712 RVA: 0x00396E28 File Offset: 0x00395028
	public void ODONNAANIEP()
	{
		this.PLLHGAFIAFD.Clear();
		this.MEHMPCCBDHE.Clear();
		this.AEGGLCOIDNH.Clear();
		TextAsset textAsset = Resources.Load<TextAsset>("Weapons");
		if (textAsset == null)
		{
			Debug.LogError("textAsset is NULL! Path: Weapons");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		BEFCHFNGOMI befchfngomi = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf('=') >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.OKEBIHBDEOO("id"))
				{
					befchfngomi = new BEFCHFNGOMI
					{
						LPFKFNLHGBI = diggohpgcnn.DIKKDGKIPEA
					};
					this.PLLHGAFIAFD.Add(befchfngomi.LPFKFNLHGBI, befchfngomi);
				}
				if (befchfngomi != null)
				{
					if (diggohpgcnn.OKEBIHBDEOO("wtype"))
					{
						befchfngomi.MBKMKGABBGE = diggohpgcnn.DIKKDGKIPEA;
					}
					if (diggohpgcnn.OKEBIHBDEOO("maxcount"))
					{
						befchfngomi.NPPJLOBFGBH = diggohpgcnn.DIKKDGKIPEA;
					}
					if (diggohpgcnn.OKEBIHBDEOO("shopCount"))
					{
						befchfngomi.HOALBMDJNDM = diggohpgcnn.DIKKDGKIPEA;
					}
					if (diggohpgcnn.OKEBIHBDEOO("holes_min"))
					{
						befchfngomi.FPPHMHGLHMH = diggohpgcnn.DIKKDGKIPEA;
					}
					if (diggohpgcnn.OKEBIHBDEOO("holes_max"))
					{
						befchfngomi.EEENNAGKEGF = diggohpgcnn.DIKKDGKIPEA;
					}
					if (diggohpgcnn.OKEBIHBDEOO("addpar"))
					{
						befchfngomi.CLKMCAHNHBM = diggohpgcnn.IEIMMFODGFG;
					}
					if (diggohpgcnn.OKEBIHBDEOO("saleToShop"))
					{
						befchfngomi.NGHBADLCMEL = diggohpgcnn.KPAFFJNBLHK;
					}
					if (diggohpgcnn.OKEBIHBDEOO("saleToAuk"))
					{
						befchfngomi.DKFCKFJBNIM = diggohpgcnn.KPAFFJNBLHK;
					}
					if (diggohpgcnn.OKEBIHBDEOO("wpnToAuk"))
					{
						befchfngomi.PKKLNODNCBE = diggohpgcnn.KPAFFJNBLHK;
					}
					if (diggohpgcnn.OKEBIHBDEOO("refine") && diggohpgcnn.IEIMMFODGFG.Trim() != "")
					{
						befchfngomi.KKOLKEEALFD = true;
						befchfngomi.NEGPPBJIHAF = JLFJEGIPIMM.IKGFHGKKCPG.EBBOBJCKFPP(diggohpgcnn.IEIMMFODGFG);
					}
					if (diggohpgcnn.OKEBIHBDEOO("takeToFrend"))
					{
						befchfngomi.DAGKAGJCNAH = diggohpgcnn.KPAFFJNBLHK;
					}
					if (diggohpgcnn.OKEBIHBDEOO("isiznos"))
					{
						befchfngomi.FOAPCABBLBG = diggohpgcnn.KPAFFJNBLHK;
					}
					if (diggohpgcnn.OKEBIHBDEOO("subtype"))
					{
						befchfngomi.ILOCKJIAPFC = diggohpgcnn.DIKKDGKIPEA;
					}
					if (diggohpgcnn.OKEBIHBDEOO("viewType"))
					{
						befchfngomi.JALOCNOIDFJ = diggohpgcnn.DIKKDGKIPEA;
					}
					if (diggohpgcnn.OKEBIHBDEOO("wpnend"))
					{
						befchfngomi.CDNDMPBMLEH();
					}
				}
			}
		}
		XmlDocument xmlDocument = new XmlDocument();
		string xml = JNBICAJIJMM.IKGFHGKKCPG.CHFGNHKJNFG("WpnLang.xml", false);
		xmlDocument.LoadXml(xml);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("wpnlang/weapons/weapon");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Attributes != null)
				{
					int lpfkfnlhgbi = int.Parse(xmlNode.Attributes["id"].Value);
					befchfngomi = this.GBKMHIGNKJA(lpfkfnlhgbi);
				}
				if (befchfngomi != null)
				{
					foreach (object obj2 in xmlNode.ChildNodes)
					{
						XmlNode xmlNode2 = (XmlNode)obj2;
						if (xmlNode2.Name == "name")
						{
							befchfngomi.BNIHFBMEPAB = xmlNode2.InnerText;
						}
						if (xmlNode2.Name == "info")
						{
							befchfngomi.JCKHDHGIEEB = xmlNode2.InnerText;
						}
					}
				}
			}
		}
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("wpnlang/wpntypes/type");
		if (xmlNodeList2 != null)
		{
			this.MEHMPCCBDHE.Clear();
		}
		foreach (object obj3 in xmlNodeList2)
		{
			XmlNode xmlNode3 = (XmlNode)obj3;
			if (xmlNode3.Attributes != null)
			{
				int num = int.Parse(xmlNode3.Attributes["id"].Value);
				string value = xmlNode3.Attributes["name"].Value;
				if (this.MEHMPCCBDHE.ContainsKey(num))
				{
					Debug.LogError(string.Concat(new object[]
					{
						"wpnlang/wpntypes/type DUBLICATE ",
						num,
						" ",
						value
					}));
				}
				else
				{
					this.MEHMPCCBDHE.Add(num, value);
				}
			}
		}
		Debug.Log("WpnTemplateMgr is init");
		this.CFNIHPOBLBL = true;
	}

	// Token: 0x060077F9 RID: 30713 RVA: 0x003972E8 File Offset: 0x003954E8
	public BEFCHFNGOMI GBKMHIGNKJA(int LPFKFNLHGBI)
	{
		BEFCHFNGOMI befchfngomi = this.PLLHGAFIAFD.ContainsKey(LPFKFNLHGBI) ? this.PLLHGAFIAFD[LPFKFNLHGBI] : null;
		if (befchfngomi != null)
		{
			befchfngomi.JIFFLPNBILE();
		}
		return befchfngomi;
	}

	// Token: 0x060077FA RID: 30714 RVA: 0x0039731D File Offset: 0x0039551D
	public EKBAPCMPANI ANNEDNNNHIP(long LPFKFNLHGBI)
	{
		if (!this.AEGGLCOIDNH.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.AEGGLCOIDNH[LPFKFNLHGBI];
	}

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x060077FB RID: 30715 RVA: 0x0039733B File Offset: 0x0039553B
	public static IHFEDJEMJMB IKGFHGKKCPG
	{
		get
		{
			if (IHFEDJEMJMB.AGFGEGLPLMJ == null)
			{
				IHFEDJEMJMB.AGFGEGLPLMJ = new IHFEDJEMJMB();
				IHFEDJEMJMB.AGFGEGLPLMJ.ODONNAANIEP();
			}
			return IHFEDJEMJMB.AGFGEGLPLMJ;
		}
	}

	// Token: 0x060077FC RID: 30716 RVA: 0x0039735D File Offset: 0x0039555D
	public string GHPLKJHBOMJ(int OFGDGOAKPAG)
	{
		return JNBICAJIJMM.LPHMKPDBMPP().IPHGEPDFCJL("SkateboardKickPush", "-UNDERLINE" + OFGDGOAKPAG);
	}

	// Token: 0x060077FD RID: 30717 RVA: 0x00396D7B File Offset: 0x00394F7B
	public string CAIIPOJKBPO(int LPFKFNLHGBI)
	{
		return this.MEHMPCCBDHE[LPFKFNLHGBI];
	}

	// Token: 0x060077FF RID: 30719 RVA: 0x00396D7B File Offset: 0x00394F7B
	public string AGELAMIPPAJ(int LPFKFNLHGBI)
	{
		return this.MEHMPCCBDHE[LPFKFNLHGBI];
	}

	// Token: 0x06007800 RID: 30720 RVA: 0x00396D7B File Offset: 0x00394F7B
	public string GJIJPHLEHHF(int LPFKFNLHGBI)
	{
		return this.MEHMPCCBDHE[LPFKFNLHGBI];
	}

	// Token: 0x06007801 RID: 30721 RVA: 0x003973B0 File Offset: 0x003955B0
	public void NOHAIMDPDNE()
	{
		this.PLLHGAFIAFD.Clear();
		this.MEHMPCCBDHE.Clear();
		this.AEGGLCOIDNH.Clear();
		TextAsset textAsset = Resources.Load<TextAsset>(" %\n");
		if (textAsset == null)
		{
			Debug.LogError("---");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		BEFCHFNGOMI befchfngomi = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf('}') >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.BFJNMCOOKDH("002000"))
				{
					befchfngomi = new BEFCHFNGOMI
					{
						LPFKFNLHGBI = diggohpgcnn.DCGNALDFPDB()
					};
					this.PLLHGAFIAFD.Add(befchfngomi.LPFKFNLHGBI, befchfngomi);
				}
				if (befchfngomi != null)
				{
					if (diggohpgcnn.AKKCENFGNCC("_ExposureAdjustment"))
					{
						befchfngomi.MBKMKGABBGE = diggohpgcnn.IPPDIFCDJHE();
					}
					if (diggohpgcnn.LIBBKEKPAPJ("msgClick"))
					{
						befchfngomi.NPPJLOBFGBH = diggohpgcnn.CMNMAJAOGDK();
					}
					if (diggohpgcnn.LIBBKEKPAPJ("SelfBleedReduction"))
					{
						befchfngomi.HOALBMDJNDM = diggohpgcnn.IPPDIFCDJHE();
					}
					if (diggohpgcnn.LOMKLMPKJEC("_FogNoiseData"))
					{
						befchfngomi.FPPHMHGLHMH = diggohpgcnn.CMNMAJAOGDK();
					}
					if (diggohpgcnn.OKEBIHBDEOO("ACHIEVEMENT_1_1"))
					{
						befchfngomi.EEENNAGKEGF = diggohpgcnn.NOHLIOHBLMF();
					}
					if (diggohpgcnn.CPGPEHEHCPI("WoodCut"))
					{
						befchfngomi.CLKMCAHNHBM = diggohpgcnn.LEPDIDFPFBO();
					}
					if (diggohpgcnn.OKEBIHBDEOO("_HighlightSuppression"))
					{
						befchfngomi.NGHBADLCMEL = diggohpgcnn.LOLBCAIEFMN();
					}
					if (diggohpgcnn.CPGPEHEHCPI("TenkokuModule"))
					{
						befchfngomi.DKFCKFJBNIM = diggohpgcnn.KGFNAIIPHKL();
					}
					if (diggohpgcnn.LIBBKEKPAPJ("{2:D2}:{0:D2}:{1:D2}"))
					{
						befchfngomi.PKKLNODNCBE = diggohpgcnn.LOLBCAIEFMN();
					}
					if (diggohpgcnn.LIBBKEKPAPJ("wpn_rec4") && diggohpgcnn.LEPDIDFPFBO().Trim() != "auc_reshdr")
					{
						befchfngomi.KKOLKEEALFD = false;
						befchfngomi.NEGPPBJIHAF = JLFJEGIPIMM.MHFDIJGJGBJ().GGNCDNOAECO(diggohpgcnn.JPKKBIOMOFO());
					}
					if (diggohpgcnn.LIBBKEKPAPJ("wpn_hookf"))
					{
						befchfngomi.DAGKAGJCNAH = diggohpgcnn.DGEEJKEEHPE();
					}
					if (diggohpgcnn.LOMKLMPKJEC("_TintColor"))
					{
						befchfngomi.FOAPCABBLBG = diggohpgcnn.LOLBCAIEFMN();
					}
					if (diggohpgcnn.AKKCENFGNCC("invn_rec18"))
					{
						befchfngomi.ILOCKJIAPFC = diggohpgcnn.DIKKDGKIPEA;
					}
					if (diggohpgcnn.BFJNMCOOKDH("stretchWidth"))
					{
						befchfngomi.JALOCNOIDFJ = diggohpgcnn.CMNMAJAOGDK();
					}
					if (diggohpgcnn.AKKCENFGNCC("KatanaNinjaDraw"))
					{
						befchfngomi.CDNDMPBMLEH();
					}
				}
			}
		}
		XmlDocument xmlDocument = new XmlDocument();
		string xml = JNBICAJIJMM.DBMJJPBOPEK().CHFGNHKJNFG("Variables protection", false);
		xmlDocument.LoadXml(xml);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("repair.ogg");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Attributes != null)
				{
					int lpfkfnlhgbi = int.Parse(xmlNode.Attributes["cht_msg1"].Value);
					befchfngomi = this.LMGMPPAOPEP(lpfkfnlhgbi);
				}
				if (befchfngomi != null)
				{
					foreach (object obj2 in xmlNode.ChildNodes)
					{
						XmlNode xmlNode2 = (XmlNode)obj2;
						if (xmlNode2.Name == " ")
						{
							befchfngomi.BNIHFBMEPAB = xmlNode2.InnerText;
						}
						if (xmlNode2.Name == "")
						{
							befchfngomi.JCKHDHGIEEB = xmlNode2.InnerText;
						}
					}
				}
			}
		}
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("******** recept id=");
		if (xmlNodeList2 != null)
		{
			this.MEHMPCCBDHE.Clear();
		}
		foreach (object obj3 in xmlNodeList2)
		{
			XmlNode xmlNode3 = (XmlNode)obj3;
			if (xmlNode3.Attributes != null)
			{
				int num = int.Parse(xmlNode3.Attributes["SPECIAL"].Value);
				string value = xmlNode3.Attributes[""].Value;
				if (this.MEHMPCCBDHE.ContainsKey(num))
				{
					object[] array = new object[3];
					array[0] = "#400040";
					array[1] = num;
					array[1] = "crft_from";
					array[1] = value;
					Debug.LogError(string.Concat(array));
				}
				else
				{
					this.MEHMPCCBDHE.Add(num, value);
				}
			}
		}
		Debug.Log("_Rotation");
		this.CFNIHPOBLBL = true;
	}

	// Token: 0x06007802 RID: 30722 RVA: 0x00396D7B File Offset: 0x00394F7B
	public string PLBJOFKHBIJ(int LPFKFNLHGBI)
	{
		return this.MEHMPCCBDHE[LPFKFNLHGBI];
	}

	// Token: 0x06007803 RID: 30723 RVA: 0x00396D7B File Offset: 0x00394F7B
	public string DOHHCICALIL(int LPFKFNLHGBI)
	{
		return this.MEHMPCCBDHE[LPFKFNLHGBI];
	}

	// Token: 0x06007804 RID: 30724 RVA: 0x00397870 File Offset: 0x00395A70
	public string JDPKJHHNPEP(int OFGDGOAKPAG)
	{
		return JNBICAJIJMM.CLIMNFDGOEG().JDBGNILGMDO("fwgt_big_m", "STRIKETHROUGH" + OFGDGOAKPAG);
	}

	// Token: 0x06007805 RID: 30725 RVA: 0x00397894 File Offset: 0x00395A94
	public void NFAKJBGFDEE()
	{
		this.PLLHGAFIAFD.Clear();
		this.MEHMPCCBDHE.Clear();
		this.AEGGLCOIDNH.Clear();
		TextAsset textAsset = Resources.Load<TextAsset>("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_polygonal.html");
		if (textAsset == null)
		{
			Debug.LogError("wpn_add/base");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		BEFCHFNGOMI befchfngomi = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf('O') >= 1)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.BFJNMCOOKDH(" rod file="))
				{
					befchfngomi = new BEFCHFNGOMI
					{
						LPFKFNLHGBI = diggohpgcnn.DIKKDGKIPEA
					};
					this.PLLHGAFIAFD.Add(befchfngomi.LPFKFNLHGBI, befchfngomi);
				}
				if (befchfngomi != null)
				{
					if (diggohpgcnn.OKEBIHBDEOO("finger"))
					{
						befchfngomi.MBKMKGABBGE = diggohpgcnn.DCGNALDFPDB();
					}
					if (diggohpgcnn.AKKCENFGNCC("Gesture Hand Up"))
					{
						befchfngomi.NPPJLOBFGBH = diggohpgcnn.IGEAGOANELP();
					}
					if (diggohpgcnn.AKKCENFGNCC("\n"))
					{
						befchfngomi.HOALBMDJNDM = diggohpgcnn.NOHLIOHBLMF();
					}
					if (diggohpgcnn.CPGPEHEHCPI("<.*?>"))
					{
						befchfngomi.FPPHMHGLHMH = diggohpgcnn.DIKKDGKIPEA;
					}
					if (diggohpgcnn.LOMKLMPKJEC("_SceneFogParams"))
					{
						befchfngomi.EEENNAGKEGF = diggohpgcnn.IPPDIFCDJHE();
					}
					if (diggohpgcnn.JKHEMJCFJGJ("FOVKick camera is null, please supply the camera to the constructor"))
					{
						befchfngomi.CLKMCAHNHBM = diggohpgcnn.LEPDIDFPFBO();
					}
					if (diggohpgcnn.CPGPEHEHCPI("\n"))
					{
						befchfngomi.NGHBADLCMEL = diggohpgcnn.KPAFFJNBLHK;
					}
					if (diggohpgcnn.CPGPEHEHCPI("Windows"))
					{
						befchfngomi.DKFCKFJBNIM = diggohpgcnn.LOLBCAIEFMN();
					}
					if (diggohpgcnn.JKHEMJCFJGJ("USE_CORNER_DETECTION"))
					{
						befchfngomi.PKKLNODNCBE = diggohpgcnn.DGEEJKEEHPE();
					}
					if (diggohpgcnn.OKEBIHBDEOO("_name") && diggohpgcnn.IEIMMFODGFG.Trim() != "dragWeapon = null 3")
					{
						befchfngomi.KKOLKEEALFD = false;
						befchfngomi.NEGPPBJIHAF = JLFJEGIPIMM.PKGMBFEMKGP().EBBOBJCKFPP(diggohpgcnn.IEIMMFODGFG);
					}
					if (diggohpgcnn.LOMKLMPKJEC("BC "))
					{
						befchfngomi.DAGKAGJCNAH = diggohpgcnn.DGEEJKEEHPE();
					}
					if (diggohpgcnn.JKHEMJCFJGJ("Text:"))
					{
						befchfngomi.FOAPCABBLBG = diggohpgcnn.KGFNAIIPHKL();
					}
					if (diggohpgcnn.CPGPEHEHCPI("WeaponReload"))
					{
						befchfngomi.ILOCKJIAPFC = diggohpgcnn.DCGNALDFPDB();
					}
					if (diggohpgcnn.BFJNMCOOKDH("OfficeSittingHandRestFingerTap"))
					{
						befchfngomi.JALOCNOIDFJ = diggohpgcnn.IGEAGOANELP();
					}
					if (diggohpgcnn.CPGPEHEHCPI("{not_found}"))
					{
						befchfngomi.DOPPLDHAJPJ();
					}
				}
			}
		}
		XmlDocument xmlDocument = new XmlDocument();
		string xml = JNBICAJIJMM.EDKGBBIIBBC().BGOJCAABLNC("val=", true);
		xmlDocument.LoadXml(xml);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("SpinReel.ogg");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Attributes != null)
				{
					int lpfkfnlhgbi = int.Parse(xmlNode.Attributes["PersonManFisher"].Value);
					befchfngomi = this.GBKMHIGNKJA(lpfkfnlhgbi);
				}
				if (befchfngomi != null)
				{
					foreach (object obj2 in xmlNode.ChildNodes)
					{
						XmlNode xmlNode2 = (XmlNode)obj2;
						if (xmlNode2.Name == " ms")
						{
							befchfngomi.BNIHFBMEPAB = xmlNode2.InnerText;
						}
						if (xmlNode2.Name == "****************** CamEffector APPLY 0")
						{
							befchfngomi.JCKHDHGIEEB = xmlNode2.InnerText;
						}
					}
				}
			}
		}
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("_TintColor");
		if (xmlNodeList2 != null)
		{
			this.MEHMPCCBDHE.Clear();
		}
		foreach (object obj3 in xmlNodeList2)
		{
			XmlNode xmlNode3 = (XmlNode)obj3;
			if (xmlNode3.Attributes != null)
			{
				int num = int.Parse(xmlNode3.Attributes["AC_DITHERING"].Value);
				string value = xmlNode3.Attributes["\\"].Value;
				if (this.MEHMPCCBDHE.ContainsKey(num))
				{
					object[] array = new object[1];
					array[1] = "{0} / {1}";
					array[1] = num;
					array[0] = "WallRunRight";
					array[1] = value;
					Debug.LogError(string.Concat(array));
				}
				else
				{
					this.MEHMPCCBDHE.Add(num, value);
				}
			}
		}
		Debug.Log("id");
		this.CFNIHPOBLBL = false;
	}

	// Token: 0x06007806 RID: 30726 RVA: 0x0039731D File Offset: 0x0039551D
	public EKBAPCMPANI KCPEMCJBOJH(long LPFKFNLHGBI)
	{
		if (!this.AEGGLCOIDNH.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.AEGGLCOIDNH[LPFKFNLHGBI];
	}

	// Token: 0x06007807 RID: 30727 RVA: 0x00396DAA File Offset: 0x00394FAA
	public void GHHFNBJKINE(EKBAPCMPANI MEJMEKODJAE)
	{
		if (this.AEGGLCOIDNH.ContainsKey(MEJMEKODJAE.LPFKFNLHGBI))
		{
			this.AEGGLCOIDNH[MEJMEKODJAE.LPFKFNLHGBI] = MEJMEKODJAE;
			return;
		}
		this.AEGGLCOIDNH.Add(MEJMEKODJAE.LPFKFNLHGBI, MEJMEKODJAE);
	}

	// Token: 0x06007808 RID: 30728 RVA: 0x00397D54 File Offset: 0x00395F54
	public BEFCHFNGOMI LMGMPPAOPEP(int LPFKFNLHGBI)
	{
		BEFCHFNGOMI befchfngomi = this.PLLHGAFIAFD.ContainsKey(LPFKFNLHGBI) ? this.PLLHGAFIAFD[LPFKFNLHGBI] : null;
		if (befchfngomi != null)
		{
			befchfngomi.KEICEAJOGFD();
		}
		return befchfngomi;
	}

	// Token: 0x06007809 RID: 30729 RVA: 0x00397D89 File Offset: 0x00395F89
	public string IKCPDMPCIHA(int OFGDGOAKPAG)
	{
		return JNBICAJIJMM.APMJBBDBOJO().OMNMDGIGEFD("_ProjInfo", "category" + OFGDGOAKPAG);
	}

	// Token: 0x0600780A RID: 30730 RVA: 0x00396DAA File Offset: 0x00394FAA
	public void GFLFFCBJNDI(EKBAPCMPANI MEJMEKODJAE)
	{
		if (this.AEGGLCOIDNH.ContainsKey(MEJMEKODJAE.LPFKFNLHGBI))
		{
			this.AEGGLCOIDNH[MEJMEKODJAE.LPFKFNLHGBI] = MEJMEKODJAE;
			return;
		}
		this.AEGGLCOIDNH.Add(MEJMEKODJAE.LPFKFNLHGBI, MEJMEKODJAE);
	}

	// Token: 0x0600780B RID: 30731 RVA: 0x0039731D File Offset: 0x0039551D
	public EKBAPCMPANI IPGMHEHMAGJ(long LPFKFNLHGBI)
	{
		if (!this.AEGGLCOIDNH.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.AEGGLCOIDNH[LPFKFNLHGBI];
	}

	// Token: 0x0600780C RID: 30732 RVA: 0x00397DAC File Offset: 0x00395FAC
	public void IFJFGNEENGL()
	{
		this.PLLHGAFIAFD.Clear();
		this.MEHMPCCBDHE.Clear();
		this.AEGGLCOIDNH.Clear();
		TextAsset textAsset = Resources.Load<TextAsset>("wpn_add/base");
		if (textAsset == null)
		{
			Debug.LogError("SUNSHINE_ONE_CASCADE");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		BEFCHFNGOMI befchfngomi = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf('E') >= 1)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.LOMKLMPKJEC("RollerBladeSkateFwd"))
				{
					befchfngomi = new BEFCHFNGOMI
					{
						LPFKFNLHGBI = diggohpgcnn.IGEAGOANELP()
					};
					this.PLLHGAFIAFD.Add(befchfngomi.LPFKFNLHGBI, befchfngomi);
				}
				if (befchfngomi != null)
				{
					if (diggohpgcnn.LOMKLMPKJEC("stretchWidth"))
					{
						befchfngomi.MBKMKGABBGE = diggohpgcnn.DIKKDGKIPEA;
					}
					if (diggohpgcnn.LOMKLMPKJEC("****************  stopMusic "))
					{
						befchfngomi.NPPJLOBFGBH = diggohpgcnn.INFKMCKHMAN();
					}
					if (diggohpgcnn.BFJNMCOOKDH("1 Hand Sword Roll Attack"))
					{
						befchfngomi.HOALBMDJNDM = diggohpgcnn.INFKMCKHMAN();
					}
					if (diggohpgcnn.LIBBKEKPAPJ("Crouch180"))
					{
						befchfngomi.FPPHMHGLHMH = diggohpgcnn.DCGNALDFPDB();
					}
					if (diggohpgcnn.CPGPEHEHCPI("ust_msg"))
					{
						befchfngomi.EEENNAGKEGF = diggohpgcnn.IGEAGOANELP();
					}
					if (diggohpgcnn.CPGPEHEHCPI(" "))
					{
						befchfngomi.CLKMCAHNHBM = diggohpgcnn.JPKKBIOMOFO();
					}
					if (diggohpgcnn.LIBBKEKPAPJ(">>"))
					{
						befchfngomi.NGHBADLCMEL = diggohpgcnn.KGFNAIIPHKL();
					}
					if (diggohpgcnn.LOMKLMPKJEC(""))
					{
						befchfngomi.DKFCKFJBNIM = diggohpgcnn.KPAFFJNBLHK;
					}
					if (diggohpgcnn.OKEBIHBDEOO("<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}"))
					{
						befchfngomi.PKKLNODNCBE = diggohpgcnn.LOLBCAIEFMN();
					}
					if (diggohpgcnn.CPGPEHEHCPI("Error") && diggohpgcnn.JPKKBIOMOFO().Trim() != "Wait")
					{
						befchfngomi.KKOLKEEALFD = false;
						befchfngomi.NEGPPBJIHAF = JLFJEGIPIMM.NNEAHAFBOHC().JLMEIPNBKKM(diggohpgcnn.JPKKBIOMOFO());
					}
					if (diggohpgcnn.BFJNMCOOKDH("_BlurParams"))
					{
						befchfngomi.DAGKAGJCNAH = diggohpgcnn.KPAFFJNBLHK;
					}
					if (diggohpgcnn.AKKCENFGNCC("GiantGrabThrow2"))
					{
						befchfngomi.FOAPCABBLBG = diggohpgcnn.DGEEJKEEHPE();
					}
					if (diggohpgcnn.AKKCENFGNCC("holesFree"))
					{
						befchfngomi.ILOCKJIAPFC = diggohpgcnn.DIKKDGKIPEA;
					}
					if (diggohpgcnn.CPGPEHEHCPI("********* LoadAllAssets via ASYNC loadLevelTime="))
					{
						befchfngomi.JALOCNOIDFJ = diggohpgcnn.CMNMAJAOGDK();
					}
					if (diggohpgcnn.LIBBKEKPAPJ("harvestmsg3"))
					{
						befchfngomi.DOPPLDHAJPJ();
					}
				}
			}
		}
		XmlDocument xmlDocument = new XmlDocument();
		string xml = JNBICAJIJMM.EKEBHIJMEML().CHFGNHKJNFG("Idle Strafe Left", true);
		xmlDocument.LoadXml(xml);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("none id=");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Attributes != null)
				{
					int lpfkfnlhgbi = int.Parse(xmlNode.Attributes["FOG_OF_WAR_ON"].Value);
					befchfngomi = this.NKMGKJLONDK(lpfkfnlhgbi);
				}
				if (befchfngomi != null)
				{
					foreach (object obj2 in xmlNode.ChildNodes)
					{
						XmlNode xmlNode2 = (XmlNode)obj2;
						if (xmlNode2.Name == "8192")
						{
							befchfngomi.BNIHFBMEPAB = xmlNode2.InnerText;
						}
						if (xmlNode2.Name == "Original string:\n")
						{
							befchfngomi.JCKHDHGIEEB = xmlNode2.InnerText;
						}
					}
				}
			}
		}
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("");
		if (xmlNodeList2 != null)
		{
			this.MEHMPCCBDHE.Clear();
		}
		foreach (object obj3 in xmlNodeList2)
		{
			XmlNode xmlNode3 = (XmlNode)obj3;
			if (xmlNode3.Attributes != null)
			{
				int num = int.Parse(xmlNode3.Attributes["_AddCountitem.wav"].Value);
				string value = xmlNode3.Attributes["_ProjInfo"].Value;
				if (this.MEHMPCCBDHE.ContainsKey(num))
				{
					object[] array = new object[]
					{
						null,
						"IdleMeditate"
					};
					array[1] = num;
					array[5] = "</color>\n";
					array[4] = value;
					Debug.LogError(string.Concat(array));
				}
				else
				{
					this.MEHMPCCBDHE.Add(num, value);
				}
			}
		}
		Debug.Log("_BlurRadius4");
		this.CFNIHPOBLBL = true;
	}

	// Token: 0x0600780E RID: 30734 RVA: 0x00396DAA File Offset: 0x00394FAA
	public void BIEDIIEHBBP(EKBAPCMPANI MEJMEKODJAE)
	{
		if (this.AEGGLCOIDNH.ContainsKey(MEJMEKODJAE.LPFKFNLHGBI))
		{
			this.AEGGLCOIDNH[MEJMEKODJAE.LPFKFNLHGBI] = MEJMEKODJAE;
			return;
		}
		this.AEGGLCOIDNH.Add(MEJMEKODJAE.LPFKFNLHGBI, MEJMEKODJAE);
	}

	// Token: 0x0600780F RID: 30735 RVA: 0x0039826C File Offset: 0x0039646C
	public void BCMIIMNMKNO()
	{
		this.PLLHGAFIAFD.Clear();
		this.MEHMPCCBDHE.Clear();
		this.AEGGLCOIDNH.Clear();
		TextAsset textAsset = Resources.Load<TextAsset>("");
		if (textAsset == null)
		{
			Debug.LogError("catch2.ogg");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		BEFCHFNGOMI befchfngomi = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf('\u0011') >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.LIBBKEKPAPJ("inv_invheader"))
				{
					befchfngomi = new BEFCHFNGOMI
					{
						LPFKFNLHGBI = diggohpgcnn.INFKMCKHMAN()
					};
					this.PLLHGAFIAFD.Add(befchfngomi.LPFKFNLHGBI, befchfngomi);
				}
				if (befchfngomi != null)
				{
					if (diggohpgcnn.AKKCENFGNCC("action"))
					{
						befchfngomi.MBKMKGABBGE = diggohpgcnn.DCGNALDFPDB();
					}
					if (diggohpgcnn.LOMKLMPKJEC("PlayerPrefs:"))
					{
						befchfngomi.NPPJLOBFGBH = diggohpgcnn.DIKKDGKIPEA;
					}
					if (diggohpgcnn.CPGPEHEHCPI("BipedReferences spine bone at index "))
					{
						befchfngomi.HOALBMDJNDM = diggohpgcnn.DCGNALDFPDB();
					}
					if (diggohpgcnn.CPGPEHEHCPI(""))
					{
						befchfngomi.FPPHMHGLHMH = diggohpgcnn.LMNLDJABLMH();
					}
					if (diggohpgcnn.AKKCENFGNCC("post_5"))
					{
						befchfngomi.EEENNAGKEGF = diggohpgcnn.DIKKDGKIPEA;
					}
					if (diggohpgcnn.JKHEMJCFJGJ("24"))
					{
						befchfngomi.CLKMCAHNHBM = diggohpgcnn.IEIMMFODGFG;
					}
					if (diggohpgcnn.LOMKLMPKJEC("-H"))
					{
						befchfngomi.NGHBADLCMEL = diggohpgcnn.LOLBCAIEFMN();
					}
					if (diggohpgcnn.JKHEMJCFJGJ("DealerIdle"))
					{
						befchfngomi.DKFCKFJBNIM = diggohpgcnn.KGFNAIIPHKL();
					}
					if (diggohpgcnn.AKKCENFGNCC("MotorbikeTurnRight"))
					{
						befchfngomi.PKKLNODNCBE = diggohpgcnn.KPAFFJNBLHK;
					}
					if (diggohpgcnn.BFJNMCOOKDH("from prefab") && diggohpgcnn.JPKKBIOMOFO().Trim() != "\n")
					{
						befchfngomi.KKOLKEEALFD = false;
						befchfngomi.NEGPPBJIHAF = JLFJEGIPIMM.PKGMBFEMKGP().GHGPOJMCMKO(diggohpgcnn.IEIMMFODGFG);
					}
					if (diggohpgcnn.LOMKLMPKJEC("IdleDie"))
					{
						befchfngomi.DAGKAGJCNAH = diggohpgcnn.LOLBCAIEFMN();
					}
					if (diggohpgcnn.BFJNMCOOKDH("_TapMedium"))
					{
						befchfngomi.FOAPCABBLBG = diggohpgcnn.LOLBCAIEFMN();
					}
					if (diggohpgcnn.BFJNMCOOKDH("wpn_rod2"))
					{
						befchfngomi.ILOCKJIAPFC = diggohpgcnn.DCGNALDFPDB();
					}
					if (diggohpgcnn.LOMKLMPKJEC("WeaponStand"))
					{
						befchfngomi.JALOCNOIDFJ = diggohpgcnn.DCGNALDFPDB();
					}
					if (diggohpgcnn.CPGPEHEHCPI("wpn_line1"))
					{
						befchfngomi.DOPPLDHAJPJ();
					}
				}
			}
		}
		XmlDocument xmlDocument = new XmlDocument();
		string xml = JNBICAJIJMM.APMJBBDBOJO().GHPNJJIMCKF("_AdditiveReflection", true);
		xmlDocument.LoadXml(xml);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes(" ");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Attributes != null)
				{
					int lpfkfnlhgbi = int.Parse(xmlNode.Attributes["_Cull"].Value);
					befchfngomi = this.NKMGKJLONDK(lpfkfnlhgbi);
				}
				if (befchfngomi != null)
				{
					foreach (object obj2 in xmlNode.ChildNodes)
					{
						XmlNode xmlNode2 = (XmlNode)obj2;
						if (xmlNode2.Name == "?")
						{
							befchfngomi.BNIHFBMEPAB = xmlNode2.InnerText;
						}
						if (xmlNode2.Name == "BowInstant2")
						{
							befchfngomi.JCKHDHGIEEB = xmlNode2.InnerText;
						}
					}
				}
			}
		}
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("IKSolverFABRIKRoot contains no chains.");
		if (xmlNodeList2 != null)
		{
			this.MEHMPCCBDHE.Clear();
		}
		foreach (object obj3 in xmlNodeList2)
		{
			XmlNode xmlNode3 = (XmlNode)obj3;
			if (xmlNode3.Attributes != null)
			{
				int num = int.Parse(xmlNode3.Attributes["itemsdata/items/item"].Value);
				string value = xmlNode3.Attributes["fshop_btn2"].Value;
				if (this.MEHMPCCBDHE.ContainsKey(num))
				{
					object[] array = new object[3];
					array[0] = "_MinVelocity";
					array[1] = num;
					array[0] = "GestureNoFear";
					array[1] = value;
					Debug.LogError(string.Concat(array));
				}
				else
				{
					this.MEHMPCCBDHE.Add(num, value);
				}
			}
		}
		Debug.Log("Water");
		this.CFNIHPOBLBL = false;
	}

	// Token: 0x06007810 RID: 30736 RVA: 0x0039872C File Offset: 0x0039692C
	public BEFCHFNGOMI IMCJNFHAFGE(int LPFKFNLHGBI)
	{
		BEFCHFNGOMI befchfngomi = this.PLLHGAFIAFD.ContainsKey(LPFKFNLHGBI) ? this.PLLHGAFIAFD[LPFKFNLHGBI] : null;
		if (befchfngomi != null)
		{
			befchfngomi.KEICEAJOGFD();
		}
		return befchfngomi;
	}

	// Token: 0x06007811 RID: 30737 RVA: 0x00398764 File Offset: 0x00396964
	public void NKPIKHPNDAN()
	{
		this.PLLHGAFIAFD.Clear();
		this.MEHMPCCBDHE.Clear();
		this.AEGGLCOIDNH.Clear();
		TextAsset textAsset = Resources.Load<TextAsset>("chatconnecthelp");
		if (textAsset == null)
		{
			Debug.LogError("wpn/");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		BEFCHFNGOMI befchfngomi = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf(':') >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.BFJNMCOOKDH("wpn_chair3"))
				{
					befchfngomi = new BEFCHFNGOMI
					{
						LPFKFNLHGBI = diggohpgcnn.DIKKDGKIPEA
					};
					this.PLLHGAFIAFD.Add(befchfngomi.LPFKFNLHGBI, befchfngomi);
				}
				if (befchfngomi != null)
				{
					if (diggohpgcnn.OKEBIHBDEOO("Swim"))
					{
						befchfngomi.MBKMKGABBGE = diggohpgcnn.INFKMCKHMAN();
					}
					if (diggohpgcnn.LIBBKEKPAPJ("KneesIdle"))
					{
						befchfngomi.NPPJLOBFGBH = diggohpgcnn.DCGNALDFPDB();
					}
					if (diggohpgcnn.AKKCENFGNCC("Billboards reference not set."))
					{
						befchfngomi.HOALBMDJNDM = diggohpgcnn.IPPDIFCDJHE();
					}
					if (diggohpgcnn.OKEBIHBDEOO("1HandSwordRollAttack"))
					{
						befchfngomi.FPPHMHGLHMH = diggohpgcnn.HAJGAHPBJIB();
					}
					if (diggohpgcnn.BFJNMCOOKDH("emergencyMode"))
					{
						befchfngomi.EEENNAGKEGF = diggohpgcnn.DIKKDGKIPEA;
					}
					if (diggohpgcnn.AKKCENFGNCC("_Intensity"))
					{
						befchfngomi.CLKMCAHNHBM = diggohpgcnn.IEIMMFODGFG;
					}
					if (diggohpgcnn.LIBBKEKPAPJ("FlyForward"))
					{
						befchfngomi.NGHBADLCMEL = diggohpgcnn.KGFNAIIPHKL();
					}
					if (diggohpgcnn.LIBBKEKPAPJ("WeaponStand"))
					{
						befchfngomi.DKFCKFJBNIM = diggohpgcnn.LOLBCAIEFMN();
					}
					if (diggohpgcnn.LIBBKEKPAPJ("Giant2HandSlamSwing"))
					{
						befchfngomi.PKKLNODNCBE = diggohpgcnn.LOLBCAIEFMN();
					}
					if (diggohpgcnn.BFJNMCOOKDH("SkateboardKickPush") && diggohpgcnn.LEPDIDFPFBO().Trim() != "' that does not excist in the Node Chain.")
					{
						befchfngomi.KKOLKEEALFD = false;
						befchfngomi.NEGPPBJIHAF = JLFJEGIPIMM.IKGFHGKKCPG.GGNCDNOAECO(diggohpgcnn.LEPDIDFPFBO());
					}
					if (diggohpgcnn.OKEBIHBDEOO(" - "))
					{
						befchfngomi.DAGKAGJCNAH = diggohpgcnn.LOLBCAIEFMN();
					}
					if (diggohpgcnn.JKHEMJCFJGJ("MotorbikeSeatStandWheely"))
					{
						befchfngomi.FOAPCABBLBG = diggohpgcnn.DGEEJKEEHPE();
					}
					if (diggohpgcnn.CPGPEHEHCPI("_SSRMultiplier"))
					{
						befchfngomi.ILOCKJIAPFC = diggohpgcnn.IPPDIFCDJHE();
					}
					if (diggohpgcnn.AKKCENFGNCC("crft_to"))
					{
						befchfngomi.JALOCNOIDFJ = diggohpgcnn.DCGNALDFPDB();
					}
					if (diggohpgcnn.OKEBIHBDEOO("F3"))
					{
						befchfngomi.DOPPLDHAJPJ();
					}
				}
			}
		}
		XmlDocument xmlDocument = new XmlDocument();
		string xml = JNBICAJIJMM.CLIMNFDGOEG().DOJJAFNAHKF("12", true);
		xmlDocument.LoadXml(xml);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("S");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Attributes != null)
				{
					int lpfkfnlhgbi = int.Parse(xmlNode.Attributes["Life bar: "].Value);
					befchfngomi = this.LMGMPPAOPEP(lpfkfnlhgbi);
				}
				if (befchfngomi != null)
				{
					foreach (object obj2 in xmlNode.ChildNodes)
					{
						XmlNode xmlNode2 = (XmlNode)obj2;
						if (xmlNode2.Name == "")
						{
							befchfngomi.BNIHFBMEPAB = xmlNode2.InnerText;
						}
						if (xmlNode2.Name == "threshold")
						{
							befchfngomi.JCKHDHGIEEB = xmlNode2.InnerText;
						}
					}
				}
			}
		}
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("demoDouble");
		if (xmlNodeList2 != null)
		{
			this.MEHMPCCBDHE.Clear();
		}
		foreach (object obj3 in xmlNodeList2)
		{
			XmlNode xmlNode3 = (XmlNode)obj3;
			if (xmlNode3.Attributes != null)
			{
				int num = int.Parse(xmlNode3.Attributes["Jump"].Value);
				string value = xmlNode3.Attributes["IdleFight"].Value;
				if (this.MEHMPCCBDHE.ContainsKey(num))
				{
					object[] array = new object[]
					{
						"wpn_eat8"
					};
					array[0] = num;
					array[0] = "release";
					array[4] = value;
					Debug.LogError(string.Concat(array));
				}
				else
				{
					this.MEHMPCCBDHE.Add(num, value);
				}
			}
		}
		Debug.Log("name");
		this.CFNIHPOBLBL = false;
	}

	// Token: 0x06007812 RID: 30738 RVA: 0x00398C24 File Offset: 0x00396E24
	public void EIJDBGEKPMM()
	{
		this.PLLHGAFIAFD.Clear();
		this.MEHMPCCBDHE.Clear();
		this.AEGGLCOIDNH.Clear();
		TextAsset textAsset = Resources.Load<TextAsset>("PistolFire");
		if (textAsset == null)
		{
			Debug.LogError("Mouse X");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		BEFCHFNGOMI befchfngomi = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf('C') >= 1)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.BFJNMCOOKDH("level"))
				{
					befchfngomi = new BEFCHFNGOMI
					{
						LPFKFNLHGBI = diggohpgcnn.DIKKDGKIPEA
					};
					this.PLLHGAFIAFD.Add(befchfngomi.LPFKFNLHGBI, befchfngomi);
				}
				if (befchfngomi != null)
				{
					if (diggohpgcnn.OKEBIHBDEOO("FaceHit"))
					{
						befchfngomi.MBKMKGABBGE = diggohpgcnn.IGEAGOANELP();
					}
					if (diggohpgcnn.LIBBKEKPAPJ(" шт."))
					{
						befchfngomi.NPPJLOBFGBH = diggohpgcnn.LMNLDJABLMH();
					}
					if (diggohpgcnn.LOMKLMPKJEC("UIChat_alfa"))
					{
						befchfngomi.HOALBMDJNDM = diggohpgcnn.HAJGAHPBJIB();
					}
					if (diggohpgcnn.CPGPEHEHCPI("OneHandSwordIdle"))
					{
						befchfngomi.FPPHMHGLHMH = diggohpgcnn.INFKMCKHMAN();
					}
					if (diggohpgcnn.LIBBKEKPAPJ("<color='#804020'>"))
					{
						befchfngomi.EEENNAGKEGF = diggohpgcnn.DCGNALDFPDB();
					}
					if (diggohpgcnn.CPGPEHEHCPI("Windmill"))
					{
						befchfngomi.CLKMCAHNHBM = diggohpgcnn.JPKKBIOMOFO();
					}
					if (diggohpgcnn.OKEBIHBDEOO("_ConsoleSettings"))
					{
						befchfngomi.NGHBADLCMEL = diggohpgcnn.KGFNAIIPHKL();
					}
					if (diggohpgcnn.JKHEMJCFJGJ(""))
					{
						befchfngomi.DKFCKFJBNIM = diggohpgcnn.LOLBCAIEFMN();
					}
					if (diggohpgcnn.BFJNMCOOKDH("ok"))
					{
						befchfngomi.PKKLNODNCBE = diggohpgcnn.DGEEJKEEHPE();
					}
					if (diggohpgcnn.LIBBKEKPAPJ("__a") && diggohpgcnn.JPKKBIOMOFO().Trim() != "ClimbIdle")
					{
						befchfngomi.KKOLKEEALFD = true;
						befchfngomi.NEGPPBJIHAF = JLFJEGIPIMM.MHFDIJGJGBJ().MOKIEENMKJD(diggohpgcnn.LEPDIDFPFBO());
					}
					if (diggohpgcnn.OKEBIHBDEOO("IsStrafing"))
					{
						befchfngomi.DAGKAGJCNAH = diggohpgcnn.KGFNAIIPHKL();
					}
					if (diggohpgcnn.JKHEMJCFJGJ("leskaProc"))
					{
						befchfngomi.FOAPCABBLBG = diggohpgcnn.KGFNAIIPHKL();
					}
					if (diggohpgcnn.JKHEMJCFJGJ("walk"))
					{
						befchfngomi.ILOCKJIAPFC = diggohpgcnn.DCGNALDFPDB();
					}
					if (diggohpgcnn.BFJNMCOOKDH(""))
					{
						befchfngomi.JALOCNOIDFJ = diggohpgcnn.IPPDIFCDJHE();
					}
					if (diggohpgcnn.CPGPEHEHCPI("Crate Pull"))
					{
						befchfngomi.DOPPLDHAJPJ();
					}
				}
			}
		}
		XmlDocument xmlDocument = new XmlDocument();
		string xml = JNBICAJIJMM.EKEBHIJMEML().DOJJAFNAHKF("-U", false);
		xmlDocument.LoadXml(xml);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("auk_head");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Attributes != null)
				{
					int lpfkfnlhgbi = int.Parse(xmlNode.Attributes["Flashlight"].Value);
					befchfngomi = this.IMCJNFHAFGE(lpfkfnlhgbi);
				}
				if (befchfngomi != null)
				{
					foreach (object obj2 in xmlNode.ChildNodes)
					{
						XmlNode xmlNode2 = (XmlNode)obj2;
						if (xmlNode2.Name == "gi_um_passperk")
						{
							befchfngomi.BNIHFBMEPAB = xmlNode2.InnerText;
						}
						if (xmlNode2.Name == "Okay")
						{
							befchfngomi.JCKHDHGIEEB = xmlNode2.InnerText;
						}
					}
				}
			}
		}
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("wpn/");
		if (xmlNodeList2 != null)
		{
			this.MEHMPCCBDHE.Clear();
		}
		foreach (object obj3 in xmlNodeList2)
		{
			XmlNode xmlNode3 = (XmlNode)obj3;
			if (xmlNode3.Attributes != null)
			{
				int num = int.Parse(xmlNode3.Attributes["ClimbRight"].Value);
				string value = xmlNode3.Attributes["wpn_cat2"].Value;
				if (this.MEHMPCCBDHE.ContainsKey(num))
				{
					object[] array = new object[1];
					array[1] = "Weapon Run";
					array[0] = num;
					array[0] = "_TintColor";
					array[7] = value;
					Debug.LogError(string.Concat(array));
				}
				else
				{
					this.MEHMPCCBDHE.Add(num, value);
				}
			}
		}
		Debug.Log("How your health bar is stored in memory when obscured: ");
		this.CFNIHPOBLBL = false;
	}

	// Token: 0x06007813 RID: 30739 RVA: 0x003990E4 File Offset: 0x003972E4
	public string KPFIJBBPNEE(int OFGDGOAKPAG)
	{
		return JNBICAJIJMM.IMLLGEMPHAP().GOOKDBEDLHJ("val=", "" + OFGDGOAKPAG);
	}

	// Token: 0x06007814 RID: 30740 RVA: 0x00399108 File Offset: 0x00397308
	public void OLEEAIFGCOM()
	{
		this.PLLHGAFIAFD.Clear();
		this.MEHMPCCBDHE.Clear();
		this.AEGGLCOIDNH.Clear();
		TextAsset textAsset = Resources.Load<TextAsset>("turn_tminfo");
		if (textAsset == null)
		{
			Debug.LogError("knopje.wav");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		BEFCHFNGOMI befchfngomi = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf((char)-84) >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.LIBBKEKPAPJ("день"))
				{
					befchfngomi = new BEFCHFNGOMI
					{
						LPFKFNLHGBI = diggohpgcnn.DIKKDGKIPEA
					};
					this.PLLHGAFIAFD.Add(befchfngomi.LPFKFNLHGBI, befchfngomi);
				}
				if (befchfngomi != null)
				{
					if (diggohpgcnn.AKKCENFGNCC("R"))
					{
						befchfngomi.MBKMKGABBGE = diggohpgcnn.CMNMAJAOGDK();
					}
					if (diggohpgcnn.OKEBIHBDEOO(""))
					{
						befchfngomi.NPPJLOBFGBH = diggohpgcnn.HAJGAHPBJIB();
					}
					if (diggohpgcnn.AKKCENFGNCC("_RcpMaxBlurRadius"))
					{
						befchfngomi.HOALBMDJNDM = diggohpgcnn.INFKMCKHMAN();
					}
					if (diggohpgcnn.BFJNMCOOKDH("Roll"))
					{
						befchfngomi.FPPHMHGLHMH = diggohpgcnn.IGEAGOANELP();
					}
					if (diggohpgcnn.AKKCENFGNCC("IdleTyping"))
					{
						befchfngomi.EEENNAGKEGF = diggohpgcnn.LMNLDJABLMH();
					}
					if (diggohpgcnn.LIBBKEKPAPJ("U"))
					{
						befchfngomi.CLKMCAHNHBM = diggohpgcnn.IEIMMFODGFG;
					}
					if (diggohpgcnn.LOMKLMPKJEC("_FogAlpha"))
					{
						befchfngomi.NGHBADLCMEL = diggohpgcnn.KPAFFJNBLHK;
					}
					if (diggohpgcnn.OKEBIHBDEOO("implevel"))
					{
						befchfngomi.DKFCKFJBNIM = diggohpgcnn.KPAFFJNBLHK;
					}
					if (diggohpgcnn.OKEBIHBDEOO("spine"))
					{
						befchfngomi.PKKLNODNCBE = diggohpgcnn.KGFNAIIPHKL();
					}
					if (diggohpgcnn.CPGPEHEHCPI("dir") && diggohpgcnn.LEPDIDFPFBO().Trim() != "")
					{
						befchfngomi.KKOLKEEALFD = true;
						befchfngomi.NEGPPBJIHAF = JLFJEGIPIMM.NNEAHAFBOHC().EBBOBJCKFPP(diggohpgcnn.LEPDIDFPFBO());
					}
					if (diggohpgcnn.OKEBIHBDEOO(""))
					{
						befchfngomi.DAGKAGJCNAH = diggohpgcnn.DGEEJKEEHPE();
					}
					if (diggohpgcnn.LOMKLMPKJEC("IdleTurns"))
					{
						befchfngomi.FOAPCABBLBG = diggohpgcnn.KGFNAIIPHKL();
					}
					if (diggohpgcnn.OKEBIHBDEOO("_Color"))
					{
						befchfngomi.ILOCKJIAPFC = diggohpgcnn.NOHLIOHBLMF();
					}
					if (diggohpgcnn.CPGPEHEHCPI("txt"))
					{
						befchfngomi.JALOCNOIDFJ = diggohpgcnn.DCGNALDFPDB();
					}
					if (diggohpgcnn.AKKCENFGNCC(""))
					{
						befchfngomi.CDNDMPBMLEH();
					}
				}
			}
		}
		XmlDocument xmlDocument = new XmlDocument();
		string xml = JNBICAJIJMM.DBMJJPBOPEK().IDFHKHHNDEK("OfficeSittingEyesRub", true);
		xmlDocument.LoadXml(xml);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("???");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Attributes != null)
				{
					int lpfkfnlhgbi = int.Parse(xmlNode.Attributes["Rebirth"].Value);
					befchfngomi = this.IMCJNFHAFGE(lpfkfnlhgbi);
				}
				if (befchfngomi != null)
				{
					foreach (object obj2 in xmlNode.ChildNodes)
					{
						XmlNode xmlNode2 = (XmlNode)obj2;
						if (xmlNode2.Name == "x")
						{
							befchfngomi.BNIHFBMEPAB = xmlNode2.InnerText;
						}
						if (xmlNode2.Name == "Mouse ScrollWheel")
						{
							befchfngomi.JCKHDHGIEEB = xmlNode2.InnerText;
						}
					}
				}
			}
		}
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("WalkBackward");
		if (xmlNodeList2 != null)
		{
			this.MEHMPCCBDHE.Clear();
		}
		foreach (object obj3 in xmlNodeList2)
		{
			XmlNode xmlNode3 = (XmlNode)obj3;
			if (xmlNode3.Attributes != null)
			{
				int num = int.Parse(xmlNode3.Attributes["The shader "].Value);
				string value = xmlNode3.Attributes["SuicideHeadShot"].Value;
				if (this.MEHMPCCBDHE.ContainsKey(num))
				{
					object[] array = new object[8];
					array[0] = "{0:F2}, {1:F2}, {2:F2}, {3:F2}";
					array[0] = num;
					array[0] = "Second bone's position equals first bone's position in the biped's limb.";
					array[1] = value;
					Debug.LogError(string.Concat(array));
				}
				else
				{
					this.MEHMPCCBDHE.Add(num, value);
				}
			}
		}
		Debug.Log("Zombie Walk");
		this.CFNIHPOBLBL = false;
	}

	// Token: 0x06007815 RID: 30741 RVA: 0x003995C8 File Offset: 0x003977C8
	public string BMNACHPJOAD(int OFGDGOAKPAG)
	{
		return JNBICAJIJMM.EEOPOHEALPK().NMIJBEJBGNB(" ", "MotorbikeAirWalk" + OFGDGOAKPAG);
	}

	// Token: 0x06007816 RID: 30742 RVA: 0x003995E9 File Offset: 0x003977E9
	public string HPAPOKEMABH(int OFGDGOAKPAG)
	{
		return JNBICAJIJMM.IMLLGEMPHAP().IPHGEPDFCJL("#606000", "cntx_use" + OFGDGOAKPAG);
	}

	// Token: 0x06007817 RID: 30743 RVA: 0x0039960C File Offset: 0x0039780C
	public BEFCHFNGOMI NKMGKJLONDK(int LPFKFNLHGBI)
	{
		BEFCHFNGOMI befchfngomi = this.PLLHGAFIAFD.ContainsKey(LPFKFNLHGBI) ? this.PLLHGAFIAFD[LPFKFNLHGBI] : null;
		if (befchfngomi != null)
		{
			befchfngomi.JIFFLPNBILE();
		}
		return befchfngomi;
	}

	// Token: 0x06007818 RID: 30744 RVA: 0x00399641 File Offset: 0x00397841
	public static IHFEDJEMJMB EDKKJNHDBPF()
	{
		if (IHFEDJEMJMB.AGFGEGLPLMJ == null)
		{
			IHFEDJEMJMB.AGFGEGLPLMJ = new IHFEDJEMJMB();
			IHFEDJEMJMB.AGFGEGLPLMJ.NOHAIMDPDNE();
		}
		return IHFEDJEMJMB.AGFGEGLPLMJ;
	}

	// Token: 0x06007819 RID: 30745 RVA: 0x0039733B File Offset: 0x0039553B
	public static IHFEDJEMJMB JHAAMBEFENP()
	{
		if (IHFEDJEMJMB.AGFGEGLPLMJ == null)
		{
			IHFEDJEMJMB.AGFGEGLPLMJ = new IHFEDJEMJMB();
			IHFEDJEMJMB.AGFGEGLPLMJ.ODONNAANIEP();
		}
		return IHFEDJEMJMB.AGFGEGLPLMJ;
	}

	// Token: 0x0600781A RID: 30746 RVA: 0x00396D7B File Offset: 0x00394F7B
	public string OLHFAPEPJLK(int LPFKFNLHGBI)
	{
		return this.MEHMPCCBDHE[LPFKFNLHGBI];
	}

	// Token: 0x0600781B RID: 30747 RVA: 0x00399663 File Offset: 0x00397863
	public string GKJNKLOEHAC(int OFGDGOAKPAG)
	{
		return JNBICAJIJMM.EDKGBBIIBBC().IPHGEPDFCJL("WATER_SIMPLE", "-L-" + OFGDGOAKPAG);
	}

	// Token: 0x0600781C RID: 30748 RVA: 0x00396D7B File Offset: 0x00394F7B
	public string BJBKIFKFEBC(int LPFKFNLHGBI)
	{
		return this.MEHMPCCBDHE[LPFKFNLHGBI];
	}

	// Token: 0x0600781D RID: 30749 RVA: 0x00396D7B File Offset: 0x00394F7B
	public string MKCGOALNJDO(int LPFKFNLHGBI)
	{
		return this.MEHMPCCBDHE[LPFKFNLHGBI];
	}

	// Token: 0x0600781E RID: 30750 RVA: 0x00396DAA File Offset: 0x00394FAA
	public void GIKOEHDPFEA(EKBAPCMPANI MEJMEKODJAE)
	{
		if (this.AEGGLCOIDNH.ContainsKey(MEJMEKODJAE.LPFKFNLHGBI))
		{
			this.AEGGLCOIDNH[MEJMEKODJAE.LPFKFNLHGBI] = MEJMEKODJAE;
			return;
		}
		this.AEGGLCOIDNH.Add(MEJMEKODJAE.LPFKFNLHGBI, MEJMEKODJAE);
	}

	// Token: 0x0600781F RID: 30751 RVA: 0x0039731D File Offset: 0x0039551D
	public EKBAPCMPANI ILENAMANLIF(long LPFKFNLHGBI)
	{
		if (!this.AEGGLCOIDNH.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.AEGGLCOIDNH[LPFKFNLHGBI];
	}

	// Token: 0x06007820 RID: 30752 RVA: 0x00396D17 File Offset: 0x00394F17
	public static IHFEDJEMJMB OOIJFNAMEDP()
	{
		if (IHFEDJEMJMB.AGFGEGLPLMJ == null)
		{
			IHFEDJEMJMB.AGFGEGLPLMJ = new IHFEDJEMJMB();
			IHFEDJEMJMB.AGFGEGLPLMJ.OLEEAIFGCOM();
		}
		return IHFEDJEMJMB.AGFGEGLPLMJ;
	}

	// Token: 0x06007821 RID: 30753 RVA: 0x00399684 File Offset: 0x00397884
	public void MONMGKHOCAA()
	{
		this.PLLHGAFIAFD.Clear();
		this.MEHMPCCBDHE.Clear();
		this.AEGGLCOIDNH.Clear();
		TextAsset textAsset = Resources.Load<TextAsset>("");
		if (textAsset == null)
		{
			Debug.LogError("LUM_CONTRIB_ON");
			return;
		}
		TextReader textReader = new StringReader(textAsset.text);
		BEFCHFNGOMI befchfngomi = null;
		for (string text = textReader.ReadLine(); text != null; text = textReader.ReadLine())
		{
			if (text.LastIndexOf((char)-28) >= 0)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(text);
				if (diggohpgcnn.LIBBKEKPAPJ("_SunPosition"))
				{
					befchfngomi = new BEFCHFNGOMI
					{
						LPFKFNLHGBI = diggohpgcnn.IGEAGOANELP()
					};
					this.PLLHGAFIAFD.Add(befchfngomi.LPFKFNLHGBI, befchfngomi);
				}
				if (befchfngomi != null)
				{
					if (diggohpgcnn.LOMKLMPKJEC("MotorbikeLassoFwd"))
					{
						befchfngomi.MBKMKGABBGE = diggohpgcnn.IPPDIFCDJHE();
					}
					if (diggohpgcnn.OKEBIHBDEOO("_MotionBlurTmpCam"))
					{
						befchfngomi.NPPJLOBFGBH = diggohpgcnn.IGEAGOANELP();
					}
					if (diggohpgcnn.JKHEMJCFJGJ("Horizontal"))
					{
						befchfngomi.HOALBMDJNDM = diggohpgcnn.HAJGAHPBJIB();
					}
					if (diggohpgcnn.OKEBIHBDEOO("CrouchWalk"))
					{
						befchfngomi.FPPHMHGLHMH = diggohpgcnn.IPPDIFCDJHE();
					}
					if (diggohpgcnn.LOMKLMPKJEC("_Screen"))
					{
						befchfngomi.EEENNAGKEGF = diggohpgcnn.DIKKDGKIPEA;
					}
					if (diggohpgcnn.AKKCENFGNCC("<b>float:</b> "))
					{
						befchfngomi.CLKMCAHNHBM = diggohpgcnn.LEPDIDFPFBO();
					}
					if (diggohpgcnn.LIBBKEKPAPJ("_LayerThickness"))
					{
						befchfngomi.NGHBADLCMEL = diggohpgcnn.DGEEJKEEHPE();
					}
					if (diggohpgcnn.LIBBKEKPAPJ("BAG"))
					{
						befchfngomi.DKFCKFJBNIM = diggohpgcnn.KPAFFJNBLHK;
					}
					if (diggohpgcnn.OKEBIHBDEOO("IceHockeyGoalieReady"))
					{
						befchfngomi.PKKLNODNCBE = diggohpgcnn.KGFNAIIPHKL();
					}
					if (diggohpgcnn.LIBBKEKPAPJ("WizardBlock") && diggohpgcnn.IEIMMFODGFG.Trim() != "bag")
					{
						befchfngomi.KKOLKEEALFD = true;
						befchfngomi.NEGPPBJIHAF = JLFJEGIPIMM.IKGFHGKKCPG.JEJHNMMOHDG(diggohpgcnn.IEIMMFODGFG);
					}
					if (diggohpgcnn.AKKCENFGNCC("_Density"))
					{
						befchfngomi.DAGKAGJCNAH = diggohpgcnn.DGEEJKEEHPE();
					}
					if (diggohpgcnn.LIBBKEKPAPJ("no_repa"))
					{
						befchfngomi.FOAPCABBLBG = diggohpgcnn.KPAFFJNBLHK;
					}
					if (diggohpgcnn.BFJNMCOOKDH("TOD_Brightness"))
					{
						befchfngomi.ILOCKJIAPFC = diggohpgcnn.INFKMCKHMAN();
					}
					if (diggohpgcnn.JKHEMJCFJGJ("SexyDance3"))
					{
						befchfngomi.JALOCNOIDFJ = diggohpgcnn.LMNLDJABLMH();
					}
					if (diggohpgcnn.BFJNMCOOKDH("quests/qdynamic/qd"))
					{
						befchfngomi.DOPPLDHAJPJ();
					}
				}
			}
		}
		XmlDocument xmlDocument = new XmlDocument();
		string xml = JNBICAJIJMM.EDKGBBIIBBC().JPEDCGHDNPN("WalkInjured", false);
		xmlDocument.LoadXml(xml);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("http://www.root-motion.com/finalikdox/html/page10.html");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Attributes != null)
				{
					int lpfkfnlhgbi = int.Parse(xmlNode.Attributes["Calf"].Value);
					befchfngomi = this.IMCJNFHAFGE(lpfkfnlhgbi);
				}
				if (befchfngomi != null)
				{
					foreach (object obj2 in xmlNode.ChildNodes)
					{
						XmlNode xmlNode2 = (XmlNode)obj2;
						if (xmlNode2.Name == "PaperTurn.wav")
						{
							befchfngomi.BNIHFBMEPAB = xmlNode2.InnerText;
						}
						if (xmlNode2.Name == "SoccerKeeperReady")
						{
							befchfngomi.JCKHDHGIEEB = xmlNode2.InnerText;
						}
					}
				}
			}
		}
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("PistolFire");
		if (xmlNodeList2 != null)
		{
			this.MEHMPCCBDHE.Clear();
		}
		foreach (object obj3 in xmlNodeList2)
		{
			XmlNode xmlNode3 = (XmlNode)obj3;
			if (xmlNode3.Attributes != null)
			{
				int num = int.Parse(xmlNode3.Attributes["SneakLeft"].Value);
				string value = xmlNode3.Attributes["Turn"].Value;
				if (this.MEHMPCCBDHE.ContainsKey(num))
				{
					object[] array = new object[5];
					array[1] = "Open turnStatus";
					array[1] = num;
					array[7] = "fishFACTROR=";
					array[1] = value;
					Debug.LogError(string.Concat(array));
				}
				else
				{
					this.MEHMPCCBDHE.Add(num, value);
				}
			}
		}
		Debug.Log("PaperTurn.wav");
		this.CFNIHPOBLBL = false;
	}

	// Token: 0x06007822 RID: 30754 RVA: 0x0039731D File Offset: 0x0039551D
	public EKBAPCMPANI FKEFNLDGPHG(long LPFKFNLHGBI)
	{
		if (!this.AEGGLCOIDNH.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.AEGGLCOIDNH[LPFKFNLHGBI];
	}

	// Token: 0x06007823 RID: 30755 RVA: 0x00396D7B File Offset: 0x00394F7B
	public string GCIPBKDIBNJ(int LPFKFNLHGBI)
	{
		return this.MEHMPCCBDHE[LPFKFNLHGBI];
	}

	// Token: 0x06007824 RID: 30756 RVA: 0x0039731D File Offset: 0x0039551D
	public EKBAPCMPANI PECLEGJLBKL(long LPFKFNLHGBI)
	{
		if (!this.AEGGLCOIDNH.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.AEGGLCOIDNH[LPFKFNLHGBI];
	}

	// Token: 0x06007825 RID: 30757 RVA: 0x00399B44 File Offset: 0x00397D44
	public string CPKIEOIMBHF(int OFGDGOAKPAG)
	{
		return JNBICAJIJMM.APMJBBDBOJO().IPHGEPDFCJL(".unity3d", "noresult" + OFGDGOAKPAG);
	}

	// Token: 0x06007826 RID: 30758 RVA: 0x00396DE4 File Offset: 0x00394FE4
	public static IHFEDJEMJMB OELKEADDKPE()
	{
		if (IHFEDJEMJMB.AGFGEGLPLMJ == null)
		{
			IHFEDJEMJMB.AGFGEGLPLMJ = new IHFEDJEMJMB();
			IHFEDJEMJMB.AGFGEGLPLMJ.BCMIIMNMKNO();
		}
		return IHFEDJEMJMB.AGFGEGLPLMJ;
	}

	// Token: 0x06007827 RID: 30759 RVA: 0x0039731D File Offset: 0x0039551D
	public EKBAPCMPANI KKHCAIIOAJH(long LPFKFNLHGBI)
	{
		if (!this.AEGGLCOIDNH.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.AEGGLCOIDNH[LPFKFNLHGBI];
	}

	// Token: 0x06007828 RID: 30760 RVA: 0x00396D7B File Offset: 0x00394F7B
	public string JGLANEDNNAB(int LPFKFNLHGBI)
	{
		return this.MEHMPCCBDHE[LPFKFNLHGBI];
	}

	// Token: 0x06007829 RID: 30761 RVA: 0x00396DAA File Offset: 0x00394FAA
	public void EMALCAHNABG(EKBAPCMPANI MEJMEKODJAE)
	{
		if (this.AEGGLCOIDNH.ContainsKey(MEJMEKODJAE.LPFKFNLHGBI))
		{
			this.AEGGLCOIDNH[MEJMEKODJAE.LPFKFNLHGBI] = MEJMEKODJAE;
			return;
		}
		this.AEGGLCOIDNH.Add(MEJMEKODJAE.LPFKFNLHGBI, MEJMEKODJAE);
	}

	// Token: 0x0600782A RID: 30762 RVA: 0x0039731D File Offset: 0x0039551D
	public EKBAPCMPANI OGEECFGPCBK(long LPFKFNLHGBI)
	{
		if (!this.AEGGLCOIDNH.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.AEGGLCOIDNH[LPFKFNLHGBI];
	}

	// Token: 0x04001161 RID: 4449
	public int ECANLMPGGEH = 1;

	// Token: 0x04001162 RID: 4450
	private readonly Dictionary<int, BEFCHFNGOMI> PLLHGAFIAFD = new Dictionary<int, BEFCHFNGOMI>();

	// Token: 0x04001163 RID: 4451
	private readonly Dictionary<int, string> MEHMPCCBDHE = new Dictionary<int, string>();

	// Token: 0x04001164 RID: 4452
	private readonly Dictionary<long, EKBAPCMPANI> AEGGLCOIDNH = new Dictionary<long, EKBAPCMPANI>();

	// Token: 0x04001165 RID: 4453
	private static IHFEDJEMJMB AGFGEGLPLMJ;

	// Token: 0x04001166 RID: 4454
	private bool CFNIHPOBLBL;
}
