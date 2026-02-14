using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

// Token: 0x0200014C RID: 332
internal class HKFHAAKFIOA
{
	// Token: 0x06004663 RID: 18019 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG PBNOPOLLFIL(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x06004664 RID: 18020 RVA: 0x002131C4 File Offset: 0x002113C4
	public void BMBPIDNIKJK()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("OneHandSwordIdle", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("MotorbikeLassoLeft");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["wpn_add/base"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["{0:00} : {1:00}"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["reel_type2"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.ENLHJOJICDG() ?? "Wall Run Left");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x06004665 RID: 18021 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA JKIFIBEPICO()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x06004666 RID: 18022 RVA: 0x00213318 File Offset: 0x00211518
	public void DAEPKLHHBJF()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("KatanaReady", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("cht_msg40");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["IdleMeditate"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["gi_nl2"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["Flap_08.wav"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.BKKFFINMJBO() ?? "Giant 2 Hand Slam Idle");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x06004667 RID: 18023 RVA: 0x00213454 File Offset: 0x00211654
	public void NEJGJLIAOID()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Idle Ready", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("KatanaReady");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["invn_ver5"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["Horizontal"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["Eyes"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.EHCJCCILAHM() ?? "F");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x06004668 RID: 18024 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG LMJFDMJJACL(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x06004669 RID: 18025 RVA: 0x00213590 File Offset: 0x00211790
	public void BCPJIMFBALD()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("_HSV", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("rollSoundIndex");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["WorkerPickaxe2"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["WeaponInstant"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["BackPackSearch"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.EHCJCCILAHM() ?? "KatanaReady");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x0600466A RID: 18026 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG MGPACJCNOLI(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x0600466B RID: 18027 RVA: 0x002136CC File Offset: 0x002118CC
	public void BCMIIMNMKNO()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("{0:0} ч{1}, ", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("codepage");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["fishFACTROR="].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["LUX_GAMMA"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["The 'color' command requires a color parameter of RRGGBBAA:\n"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.AFJFDKAGKLD() ?? "");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x0600466C RID: 18028 RVA: 0x00213808 File Offset: 0x00211A08
	public void FADNAPBLBAF()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("+{0}", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("OnDestroy ");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["_LayerThickness"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["wpn_bait1"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["VIGNETTE_FILMIC"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.EHCJCCILAHM() ?? "Right");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x0600466D RID: 18029 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG GJBBJONKBBG(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x0600466E RID: 18030 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG HHLKHGMJFMO(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x0600466F RID: 18031 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA IOALEBMCEGM()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x06004670 RID: 18032 RVA: 0x00213944 File Offset: 0x00211B44
	public void HCOECDPAKFF()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("DealerIdle", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("_FinalBlendParameters");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["Ban OK. Object:"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["How your lives count is stored in memory when obscured: "].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes[")?"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.ENLHJOJICDG() ?? "crft_selwpn");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x06004671 RID: 18033 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA COKMLONPCFJ()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x06004672 RID: 18034 RVA: 0x00213A80 File Offset: 0x00211C80
	public void DGGMIFLJFBM()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("offsets", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("Criticals");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["WeaponReload"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["IdleTurns"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["************ isChangedRod *********"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.ENLHJOJICDG() ?? "Bases/{0}/");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x06004673 RID: 18035 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA IKGFHGKKCPG
	{
		get
		{
			HKFHAAKFIOA result;
			if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
			{
				result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
			}
			return result;
		}
	}

	// Token: 0x06004674 RID: 18036 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA PALDDOGILLH()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x06004675 RID: 18037 RVA: 0x00213BBC File Offset: 0x00211DBC
	public void IKAGNIGACFD()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load(" ", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("wpn_master");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes[""].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["No Entries Dictionary"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["qualityLevel"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.LCEBBHPKOHO() ?? "Horizontal");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x06004676 RID: 18038 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA NKFMJMHAAOB()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x06004677 RID: 18039 RVA: 0x00213CF8 File Offset: 0x00211EF8
	public void NMEFCGAJPGN()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("_History3LumaTex", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("BlackSmithHammer");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["error: mainAsset is null"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes[""].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["_MainTex"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.DIDFMAELMJD ?? "Mouse X");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x06004678 RID: 18040 RVA: 0x00213E34 File Offset: 0x00212034
	public void IJDNNNOFGBI()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load(" ", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("IK unassigned in FABRIKChain.");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["error.wav"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["PistolReload"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes[""].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.LIOPCJFCGAF() ?? "_Texture");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x06004679 RID: 18041 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG AIJFKOGGLMA(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x0600467A RID: 18042 RVA: 0x00213F70 File Offset: 0x00212170
	public void DKKCACOMDDD()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("DecalMesh", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("}");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["t_top"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["_ScratchOffsetScale"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes[" iterations for read and write"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.EEAKGGDJAGB() ?? "Shoes");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x0600467B RID: 18043 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA JKDAKILNPJN()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x0600467C RID: 18044 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG BJGFOODHBOH(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x0600467D RID: 18045 RVA: 0x002140AC File Offset: 0x002122AC
	public void AJMANAHGMMA()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Second bone's position equals first bone's position in the biped's limb.", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("Jump");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["showUsersInChat"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["Couldn't get avatar."].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["Turn"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.EEAKGGDJAGB() ?? "KatanaReadyHigh");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x0600467E RID: 18046 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA OPFODKDDIKI()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x0600467F RID: 18047 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG GHIBONGPCCB(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x06004680 RID: 18048 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA BOKIOJFHNLD()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x06004681 RID: 18049 RVA: 0x002141E8 File Offset: 0x002123E8
	public void IHAKLNJOAJE()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("\n", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("SneakLeft");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes[""].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["post_4"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["knopje.wav"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.DIDFMAELMJD ?? "gameComplete");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x06004682 RID: 18050 RVA: 0x00214324 File Offset: 0x00212524
	public void NIDGINCDCNK()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("4096", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("NprPhysPoint");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["ObscuredString:"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["ui_default_click.wav"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["_Radius2"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.AFJFDKAGKLD() ?? "sunshine_OvercastVectorsUV");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x06004683 RID: 18051 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA DBMGGDPPPED()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x06004684 RID: 18052 RVA: 0x00214460 File Offset: 0x00212660
	public void GMIBAHFMPAK()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("OneHandSwordRun");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes[" ms"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes[""].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.DIDFMAELMJD ?? "FrontKick");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x06004685 RID: 18053 RVA: 0x0021459C File Offset: 0x0021279C
	public void NGICLJJKHII()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("WorkerPickaxe", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("206000");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["thumb"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["_TintColor"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes[""].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.ACOEIDGDLJC() ?? "OfficeSittingHandRestFingerTap");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x06004686 RID: 18054 RVA: 0x002146D8 File Offset: 0x002128D8
	public void HEKGHDDKOLG()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("\n", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("Hidden/Amplify Color/DepthMask");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["wpn_eat7"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["GestureCrowdPump"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["IdleDie"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.EHCJCCILAHM() ?? "_Offsets");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x06004687 RID: 18055 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG FIBGIMNAPLM(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x06004689 RID: 18057 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA NLOGJHEFMHM()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x0600468A RID: 18058 RVA: 0x00214828 File Offset: 0x00212A28
	public void GHDFNBBJCLJ()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("selectedTask", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("reel_type");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["; "].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["</color>\n"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes[""].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.ACOEIDGDLJC() ?? "1HandSwordStrafeLeft");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x0600468B RID: 18059 RVA: 0x00214964 File Offset: 0x00212B64
	public void NKPIKHPNDAN()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Add random value", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("[");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["Skateboard"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["rod.lineDistance = "].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["OneHandSwordReady"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.EEAKGGDJAGB() ?? "PistolLeftHandStab");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x0600468C RID: 18060 RVA: 0x00214AA0 File Offset: 0x00212CA0
	public void ODONNAANIEP()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("ItemsData", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("itemsdata/items/item");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["id"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["name"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["ondestroy"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.DIDFMAELMJD ?? "");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x0600468D RID: 18061 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG BDKIANJFIJC(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x0600468E RID: 18062 RVA: 0x00214BDC File Offset: 0x00212DDC
	public void IKMOMOLPAPD()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("wpn_dress2");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["<color='{0}'> {1} ур {2}</color>\n"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["[ACTk] "].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["\n"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.EEAKGGDJAGB() ?? "IdleRun");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x0600468F RID: 18063 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA EAJNKCEOELM()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x06004690 RID: 18064 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA GALDNPBIINC()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x06004691 RID: 18065 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA NPCAKEGNBHD()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x06004692 RID: 18066 RVA: 0x00214D18 File Offset: 0x00212F18
	public void IANLOCCNBBD()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("t_bottom", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("offsets");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["DealerIdle"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["Button"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["RenderTextureUtilityTempTexture"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.NEJIPLDOMMC() ?? "name");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x06004693 RID: 18067 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG FJLDAKJBCKC(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x06004694 RID: 18068 RVA: 0x00214E54 File Offset: 0x00213054
	public void JEOPOICACFK()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("invn_rec9", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("1HandSmallWeaponCombo");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["CratePush"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["IdleStand"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["UI_ArtWindow"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.EHCJCCILAHM() ?? "360SpinDeath");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x06004695 RID: 18069 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG GONBEKDDKKI(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x06004696 RID: 18070 RVA: 0x00214F90 File Offset: 0x00213190
	public void GINBNCHGKDC()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Motorbike", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("{{ {{{0}:{1}}}, {{{2}:{3}}} }}");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["WATER_EDGEBLEND_ON"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["calf"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes[""].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.BKKFFINMJBO() ?? "MotorbikeSeatStand");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x06004697 RID: 18071 RVA: 0x002150CC File Offset: 0x002132CC
	public void OEICAEDHEPC()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("<[^>]+>", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("anfish");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["CheerKnees"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["ScatterColor"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["1HandSwordStrafeLeft"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.BKKFFINMJBO() ?? "showUsersInChat");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x06004698 RID: 18072 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA GOAFHIDOEKH()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x06004699 RID: 18073 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA BDJEDMJLJDC()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x0600469A RID: 18074 RVA: 0x00215208 File Offset: 0x00213408
	public void ELDHALELKIN()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Game saved with regular PlayerPrefs. Try to find and change saved data now (it's easy)!", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("_OcclusionTexture1");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["Отмена"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["teech_perk"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["wpn_eat6"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.LIOPCJFCGAF() ?? "Smoking 2");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x0600469B RID: 18075 RVA: 0x00215344 File Offset: 0x00213544
	public void HGCFKEMKGPK()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Wall hack Detected!", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("UV2");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["\"{0}\""].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["knopje.wav"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["UnityEngine.Color"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.LCEBBHPKOHO() ?? "17,18,19,20,29,33");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x0600469C RID: 18076 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA NEIPLKACAHP()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x0600469D RID: 18077 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG BGIHHPNNLEN(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x0600469E RID: 18078 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG EBCALLCOMCD(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x0600469F RID: 18079 RVA: 0x00215480 File Offset: 0x00213680
	public void IBKHIBMJELN()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Decal", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("Hidden/Post FX/Builtin Debug Views");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes[" for "].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["HDR"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["wpn_cat4"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.ENLHJOJICDG() ?? "KatanaReadyHigh");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046A0 RID: 18080 RVA: 0x002155BC File Offset: 0x002137BC
	public void IFJFGNEENGL()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("offsets", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("Floating point textures aren't supported on this device ({0})");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes[" rep.repa="].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["no_perk"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["Flap_02.wav"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.NEJIPLDOMMC() ?? "дней");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046A1 RID: 18081 RVA: 0x002156F8 File Offset: 0x002138F8
	public void NFIEAPBGGKJ()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("t_top", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("wpn_add/base");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["BuY"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["IdleStandingJump"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["ShotgunFire"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.EHCJCCILAHM() ?? "NOISE_ON");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046A2 RID: 18082 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG EPHFODIKCGI(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x060046A3 RID: 18083 RVA: 0x00215834 File Offset: 0x00213A34
	public void IMHMBHGMNDG()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("VaderChoke", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("L");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["Shoot Right"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["OnChatMessage"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["-none-"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.ENLHJOJICDG() ?? "Zone ");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046A4 RID: 18084 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA OBDBAABBAKB()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x060046A5 RID: 18085 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG PDCGICILLKO(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x060046A6 RID: 18086 RVA: 0x00215970 File Offset: 0x00213B70
	public void NMKBGMBCHCH()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("isFishOnRod", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("cht_msg9");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["("].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["_PixelsPerMeterAtOneMeter"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["TOD_World2Sky"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.LCEBBHPKOHO() ?? "русский");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046A7 RID: 18087 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG EFFMHKEGLOF(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x060046A8 RID: 18088 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG LLLDGBAMANK(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x060046A9 RID: 18089 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA NKKDGPINOAJ()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x060046AA RID: 18090 RVA: 0x00215AAC File Offset: 0x00213CAC
	public void GMKBDNJIBMG()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("dropMass", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("demoVector3");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["MotorbikeHeartAttack"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["BowFire"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["WandStand"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.DIDFMAELMJD ?? "_SpawnHeuristic");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046AB RID: 18091 RVA: 0x00215BE8 File Offset: 0x00213DE8
	public void LNKHIEIFHNC()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("</color>", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("****** locid=");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["BAG"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["_ScaleOffsetRes"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["Vertical"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.ENLHJOJICDG() ?? "WeaponRun");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046AC RID: 18092 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG GKMEKGMNEOB(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x060046AD RID: 18093 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA KDOHACAPEPM()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x060046AE RID: 18094 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA JFEKGPPJLCB()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x060046AF RID: 18095 RVA: 0x00215D24 File Offset: 0x00213F24
	public void HHBLMKHEMEA()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("'>  > ", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_f_b_b_i_k.html");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["_FogAlpha"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes[" L "].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["\n"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.ENLHJOJICDG() ?? "");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046B0 RID: 18096 RVA: 0x00215E60 File Offset: 0x00214060
	public void EEFOMFOJEKJ()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("wpn_add/base", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("FlyDown");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["Blending "].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes[" "].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["__c"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.NEJIPLDOMMC() ?? "PistolFire");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046B1 RID: 18097 RVA: 0x00215F9C File Offset: 0x0021419C
	public void GDEGPEEPKNK()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("name", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("RollerBladeStop");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["Failed parsing organizational group.  Setting to group 0"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["</color>"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["_mesh"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.DIDFMAELMJD ?? "showUsersInChat");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046B2 RID: 18098 RVA: 0x002160D8 File Offset: 0x002142D8
	public void KACCFJLDECI()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("repa send", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("RunningDance");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["t_bottom"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["UV3"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["_DepthOfFieldCoCTex"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.EHCJCCILAHM() ?? "trn_start");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046B3 RID: 18099 RVA: 0x00216214 File Offset: 0x00214414
	public void DOAOGBHDCLA()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("360SpinDeath", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("|");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["IdleSadHips"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["gi_um_1"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls."].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.ENLHJOJICDG() ?? "_Intensity");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046B4 RID: 18100 RVA: 0x00216350 File Offset: 0x00214550
	public void EJHABFICIBG()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("wpn_book1", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("gi_uinf_7");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes[""].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes[""].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["_Color"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.ENLHJOJICDG() ?? "gi_nl1");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046B5 RID: 18101 RVA: 0x0021648C File Offset: 0x0021468C
	public void HHFMCEGDDMD()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load(" ", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("WandStand");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["Orthographic"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["wpn_wgt"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["Z"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.BKKFFINMJBO() ?? "{0}");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046B6 RID: 18102 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG CLKACDIILKA(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x060046B7 RID: 18103 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG GJAHNJBLCCF(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x060046B8 RID: 18104 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG NPLNALHBPNB(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x060046B9 RID: 18105 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA KEGBPOJKINC()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x060046BA RID: 18106 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG GCDBJKNCCMC(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x060046BB RID: 18107 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG GLLHGGPJCHC(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x060046BC RID: 18108 RVA: 0x002165C8 File Offset: 0x002147C8
	public void BOIOCDEHDAE()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("offsets", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("https://www.youtube.com/watch?v=r5jiZnsDH3M");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["The font size '"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["hair"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["frnd_ingame"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.NEJIPLDOMMC() ?? "gi_uinf_8");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046BD RID: 18109 RVA: 0x00216704 File Offset: 0x00214904
	public void KGKADNNIILN()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load(" ", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["RollerBladeTurnRight"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["wpn_rod1"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["Giant3HitCombo"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.ACOEIDGDLJC() ?? " ");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046BE RID: 18110 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA PAMNIOIJGNK()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x060046BF RID: 18111 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA IEFIFAEBNDI()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x060046C0 RID: 18112 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA EAJHPOJPPFA()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x060046C1 RID: 18113 RVA: 0x00216840 File Offset: 0x00214A40
	public void KAJJIMDHOEO()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("lut.ogg", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("WallSit");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["{0}"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["LocationGui.getI.backLockImage is null"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["Textures/Fish/"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.LIOPCJFCGAF() ?? "post_7");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046C2 RID: 18114 RVA: 0x0021697C File Offset: 0x00214B7C
	public void KDCOIKBDHFM()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("wpn_add/addperks/addPerk", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("isKeyPress");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["OK auk2KeyMEditOk---1"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["[LH &]"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["  locid="].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.LCEBBHPKOHO() ?? "KatanaReadyHigh");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046C3 RID: 18115 RVA: 0x00216AB8 File Offset: 0x00214CB8
	public void IPIPEMJDKOO()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Katana", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("_ChromaticAberration_Amount");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["1HandSwordStrafeLeft"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["_TintColor"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["UIChat_channel"].Value) != 0);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.BKKFFINMJBO() ?? "Shotgun Reload Chamber");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046C4 RID: 18116 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG DBAJBJMBHGD(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x060046C5 RID: 18117 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG IBBNKFOBBKE(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x060046C6 RID: 18118 RVA: 0x00216BF4 File Offset: 0x00214DF4
	public void HMONBGDPGKL()
	{
		this.LACAJHOHACK.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("steamider", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("inv_auklotn");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				HKFHAAKFIOA.KIDJNHEMIGG kidjnhemigg = new HKFHAAKFIOA.KIDJNHEMIGG();
				if (xmlNode.Attributes != null)
				{
					kidjnhemigg.LPFKFNLHGBI = int.Parse(xmlNode.Attributes["t_eye"].Value);
					kidjnhemigg.KNOCHJMBOBF = xmlNode.Attributes["WeaponStand"].Value;
					kidjnhemigg.JKABAPOGOAG = (int.Parse(xmlNode.Attributes["titul"].Value) > 1);
					kidjnhemigg.ELJPNJEPLOA = (IFPIMPMKJIB.BKKFFINMJBO() ?? "Idle Dodge Left");
					this.LACAJHOHACK.Add(kidjnhemigg.LPFKFNLHGBI, kidjnhemigg);
				}
			}
		}
	}

	// Token: 0x060046C7 RID: 18119 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG NMEKLOGCHEB(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x060046C8 RID: 18120 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG KCJIJJMJNEA(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x060046C9 RID: 18121 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA OOIJFNAMEDP()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x060046CA RID: 18122 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG FJOHIFPPGIE(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x060046CB RID: 18123 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA IFLFANPMLMM()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x060046CC RID: 18124 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG EPOLGEFHDJH(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x060046CD RID: 18125 RVA: 0x002131A6 File Offset: 0x002113A6
	public HKFHAAKFIOA.KIDJNHEMIGG EDNJMDFAGNE(int LPFKFNLHGBI)
	{
		if (!this.LACAJHOHACK.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.LACAJHOHACK[LPFKFNLHGBI];
	}

	// Token: 0x060046CE RID: 18126 RVA: 0x00213300 File Offset: 0x00211500
	public static HKFHAAKFIOA MIDMOLEKANJ()
	{
		HKFHAAKFIOA result;
		if ((result = HKFHAAKFIOA.CCHGNBELGIA) == null)
		{
			result = (HKFHAAKFIOA.CCHGNBELGIA = new HKFHAAKFIOA());
		}
		return result;
	}

	// Token: 0x04000B1B RID: 2843
	private static HKFHAAKFIOA CCHGNBELGIA;

	// Token: 0x04000B1C RID: 2844
	private readonly Dictionary<int, HKFHAAKFIOA.KIDJNHEMIGG> LACAJHOHACK = new Dictionary<int, HKFHAAKFIOA.KIDJNHEMIGG>();

	// Token: 0x0200014D RID: 333
	public class KIDJNHEMIGG
	{
		// Token: 0x04000B1D RID: 2845
		public int LPFKFNLHGBI;

		// Token: 0x04000B1E RID: 2846
		public bool JKABAPOGOAG;

		// Token: 0x04000B1F RID: 2847
		public string KNOCHJMBOBF;

		// Token: 0x04000B20 RID: 2848
		public string ELJPNJEPLOA;
	}
}
