using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using UnityEngine;

// Token: 0x02000156 RID: 342
public class BHNDGIPPPCE
{
	// Token: 0x06004812 RID: 18450 RVA: 0x0022544B File Offset: 0x0022364B
	public string FMBCGEFGBPF(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "Cowboy1HandDraw";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x06004813 RID: 18451 RVA: 0x00225472 File Offset: 0x00223672
	public BHNDGIPPPCE.FCKCCMDIIFK HFNMIMPDEGJ(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI];
	}

	// Token: 0x06004814 RID: 18452 RVA: 0x00225472 File Offset: 0x00223672
	public BHNDGIPPPCE.FCKCCMDIIFK GNHKBJKIHML(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI];
	}

	// Token: 0x06004815 RID: 18453 RVA: 0x00225490 File Offset: 0x00223690
	public string GDJMOAIOLFO(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "IdleDodgeRight";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x06004816 RID: 18454 RVA: 0x00225472 File Offset: 0x00223672
	public BHNDGIPPPCE.FCKCCMDIIFK LNDJPOBICIA(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI];
	}

	// Token: 0x06004817 RID: 18455 RVA: 0x002254B7 File Offset: 0x002236B7
	public List<int> BJKLJFEKHKJ()
	{
		return new List<int>(this.ANHKBEJMHMM.Keys);
	}

	// Token: 0x06004818 RID: 18456 RVA: 0x002254B7 File Offset: 0x002236B7
	public List<int> FOJAKIAAMAC()
	{
		return new List<int>(this.ANHKBEJMHMM.Keys);
	}

	// Token: 0x06004819 RID: 18457 RVA: 0x002254C9 File Offset: 0x002236C9
	public string EHDMEFHCDHA(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "MotorbikeLassoFwd";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x0600481A RID: 18458 RVA: 0x00225472 File Offset: 0x00223672
	public BHNDGIPPPCE.FCKCCMDIIFK BOBDOLHFIMK(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI];
	}

	// Token: 0x0600481B RID: 18459 RVA: 0x002254F0 File Offset: 0x002236F0
	public string PEJJOKHOLMF(int HMKPHPAACII, int CNOLCNDBLJE)
	{
		BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk = this.JFOIIJGMKPM(HMKPHPAACII);
		if (fckccmdiifk != null)
		{
			return fckccmdiifk.CJNHPHAOEDL(CNOLCNDBLJE);
		}
		return "-none-";
	}

	// Token: 0x0600481C RID: 18460 RVA: 0x002254B7 File Offset: 0x002236B7
	public List<int> GDKAGDPHDBI()
	{
		return new List<int>(this.ANHKBEJMHMM.Keys);
	}

	// Token: 0x0600481D RID: 18461 RVA: 0x00225518 File Offset: 0x00223718
	public void GMKBDNJIBMG()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("PersonManFisher", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.KGAFADNEKBP.Clear();
		this.ANHKBEJMHMM.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("[baitid]");
		if (xmlNodeList != null)
		{
			foreach (BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk in xmlNodeList.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.FCKCCMDIIFK>(BHNDGIPPPCE.<>c.<>9.AIJOLGDBJAL)))
			{
				this.ANHKBEJMHMM.Add(fckccmdiifk.LPFKFNLHGBI, fckccmdiifk);
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.EKEBHIJMEML().DOJJAFNAHKF("Nub", false));
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("IdleStrafeLeft");
		if (xmlNodeList2 != null)
		{
			foreach (BHNDGIPPPCE.AFLDOAKOMOE afldoakomoe in xmlNodeList2.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.AFLDOAKOMOE>(BHNDGIPPPCE.<>c.<>9.OPBHDLJFMAE)))
			{
				this.KGAFADNEKBP.Add(afldoakomoe.LPFKFNLHGBI, afldoakomoe);
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("Mouse Y");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				try
				{
					int key = int.Parse(xmlNode.Attributes["error.wav"].Value);
					string value = xmlNode.Attributes["_OcclusionTexture"].Value;
					this.ANHKBEJMHMM[key].BNIHFBMEPAB = value;
				}
				catch (Exception message)
				{
					Debug.LogError(message);
				}
			}
		}
	}

	// Token: 0x0600481E RID: 18462 RVA: 0x00225472 File Offset: 0x00223672
	public BHNDGIPPPCE.FCKCCMDIIFK BBIIDLJHCNO(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI];
	}

	// Token: 0x0600481F RID: 18463 RVA: 0x0022573C File Offset: 0x0022393C
	public string HDLGMNLFDLB(int HMKPHPAACII, int CNOLCNDBLJE)
	{
		BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk = this.BOBDOLHFIMK(HMKPHPAACII);
		if (fckccmdiifk != null)
		{
			return fckccmdiifk.AKBCDIJIOEN(CNOLCNDBLJE);
		}
		return "IceHockeyPassLeft";
	}

	// Token: 0x06004820 RID: 18464 RVA: 0x00225764 File Offset: 0x00223964
	public void NEJGJLIAOID()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("#url Sound ", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.KGAFADNEKBP.Clear();
		this.ANHKBEJMHMM.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("ObscuredLong:");
		if (xmlNodeList != null)
		{
			foreach (BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk in xmlNodeList.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.FCKCCMDIIFK>(BHNDGIPPPCE.<>c.<>9.LCPEMLHJCIB)))
			{
				this.ANHKBEJMHMM.Add(fckccmdiifk.LPFKFNLHGBI, fckccmdiifk);
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.LPHMKPDBMPP().GHPNJJIMCKF("Vertical", true));
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("release");
		if (xmlNodeList2 != null)
		{
			foreach (BHNDGIPPPCE.AFLDOAKOMOE afldoakomoe in xmlNodeList2.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.AFLDOAKOMOE>(BHNDGIPPPCE.<>c.<>9.HHMPAGBGKCL)))
			{
				this.KGAFADNEKBP.Add(afldoakomoe.LPFKFNLHGBI, afldoakomoe);
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("{0}Textures/Turnirs/{1}.png");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				try
				{
					int key = int.Parse(xmlNode.Attributes["Select option"].Value);
					string value = xmlNode.Attributes[" "].Value;
					this.ANHKBEJMHMM[key].BNIHFBMEPAB = value;
				}
				catch (Exception message)
				{
					Debug.LogError(message);
				}
			}
		}
	}

	// Token: 0x06004821 RID: 18465 RVA: 0x00225988 File Offset: 0x00223B88
	public string IIFCDPEMCBA(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "\n";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x06004822 RID: 18466 RVA: 0x002259AF File Offset: 0x00223BAF
	public string IBAJDDBAAIO(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "_InvScreenSize";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x06004823 RID: 18467 RVA: 0x00225472 File Offset: 0x00223672
	public BHNDGIPPPCE.FCKCCMDIIFK AGDKFHGOFGH(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI];
	}

	// Token: 0x06004824 RID: 18468 RVA: 0x002259D6 File Offset: 0x00223BD6
	public string HGPHMPAFCFC(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "icon_data/icon";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x06004825 RID: 18469 RVA: 0x00225A00 File Offset: 0x00223C00
	public void CKMJNHBNCEI()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("AssetLoaderCoroutine", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.KGAFADNEKBP.Clear();
		this.ANHKBEJMHMM.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("run");
		if (xmlNodeList != null)
		{
			foreach (BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk in xmlNodeList.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.FCKCCMDIIFK>(BHNDGIPPPCE.<>c.<>9.PBBNLDINJLN)))
			{
				this.ANHKBEJMHMM.Add(fckccmdiifk.LPFKFNLHGBI, fckccmdiifk);
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.DBMJJPBOPEK().DOJJAFNAHKF("click Ok", true));
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("sunshine_ShadowFadeParams");
		if (xmlNodeList2 != null)
		{
			foreach (BHNDGIPPPCE.AFLDOAKOMOE afldoakomoe in xmlNodeList2.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.AFLDOAKOMOE>(BHNDGIPPPCE.<>c.<>9.MCMDEDHGOLE)))
			{
				this.KGAFADNEKBP.Add(afldoakomoe.LPFKFNLHGBI, afldoakomoe);
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("HA ");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				try
				{
					int key = int.Parse(xmlNode.Attributes["\n"].Value);
					string value = xmlNode.Attributes["{"].Value;
					this.ANHKBEJMHMM[key].BNIHFBMEPAB = value;
				}
				catch (Exception message)
				{
					Debug.LogError(message);
				}
			}
		}
	}

	// Token: 0x06004826 RID: 18470 RVA: 0x00225C24 File Offset: 0x00223E24
	public void CJNIKFIPCGL()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Hyperlink_", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.KGAFADNEKBP.Clear();
		this.ANHKBEJMHMM.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("fishToSPEED=");
		if (xmlNodeList != null)
		{
			foreach (BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk in xmlNodeList.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.FCKCCMDIIFK>(BHNDGIPPPCE.<>c.<>9.DFGEIPKLIOD)))
			{
				this.ANHKBEJMHMM.Add(fckccmdiifk.LPFKFNLHGBI, fckccmdiifk);
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.APMJBBDBOJO().GIGGIHMAPLH("_CameraToWorldMatrix", false));
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("knopje.wav");
		if (xmlNodeList2 != null)
		{
			foreach (BHNDGIPPPCE.AFLDOAKOMOE afldoakomoe in xmlNodeList2.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.AFLDOAKOMOE>(BHNDGIPPPCE.<>c.<>9.IOFNFKFNFCK)))
			{
				this.KGAFADNEKBP.Add(afldoakomoe.LPFKFNLHGBI, afldoakomoe);
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("_name");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				try
				{
					int key = int.Parse(xmlNode.Attributes["Vertical"].Value);
					string value = xmlNode.Attributes["_FogAlpha"].Value;
					this.ANHKBEJMHMM[key].BNIHFBMEPAB = value;
				}
				catch (Exception message)
				{
					Debug.LogError(message);
				}
			}
		}
	}

	// Token: 0x06004827 RID: 18471 RVA: 0x00225E48 File Offset: 0x00224048
	public void JFGGHJDGOIA()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Windmill", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.KGAFADNEKBP.Clear();
		this.ANHKBEJMHMM.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("Crouching");
		if (xmlNodeList != null)
		{
			foreach (BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk in xmlNodeList.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.FCKCCMDIIFK>(BHNDGIPPPCE.<>c.<>9.DFGEIPKLIOD)))
			{
				this.ANHKBEJMHMM.Add(fckccmdiifk.LPFKFNLHGBI, fckccmdiifk);
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.CLIMNFDGOEG().DOJJAFNAHKF("_BokehParams", true));
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("money");
		if (xmlNodeList2 != null)
		{
			foreach (BHNDGIPPPCE.AFLDOAKOMOE afldoakomoe in xmlNodeList2.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.AFLDOAKOMOE>(BHNDGIPPPCE.<>c.<>9.EMNBBLJMAGI)))
			{
				this.KGAFADNEKBP.Add(afldoakomoe.LPFKFNLHGBI, afldoakomoe);
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("MotorbikeShootBack");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				try
				{
					int key = int.Parse(xmlNode.Attributes["threshold"].Value);
					string value = xmlNode.Attributes["RunBackward"].Value;
					this.ANHKBEJMHMM[key].BNIHFBMEPAB = value;
				}
				catch (Exception message)
				{
					Debug.LogError(message);
				}
			}
		}
	}

	// Token: 0x06004828 RID: 18472 RVA: 0x00225472 File Offset: 0x00223672
	public BHNDGIPPPCE.FCKCCMDIIFK JFOIIJGMKPM(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI];
	}

	// Token: 0x06004829 RID: 18473 RVA: 0x0022606C File Offset: 0x0022426C
	public void KGKADNNIILN()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("invn_rec19", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.KGAFADNEKBP.Clear();
		this.ANHKBEJMHMM.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("OneHandSwordSwing");
		if (xmlNodeList != null)
		{
			foreach (BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk in xmlNodeList.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.FCKCCMDIIFK>(BHNDGIPPPCE.<>c.<>9.KDHEFIEEBLP)))
			{
				this.ANHKBEJMHMM.Add(fckccmdiifk.LPFKFNLHGBI, fckccmdiifk);
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.IKGFHGKKCPG.DDKLHGHBEIG("1HSwordStrafeRunRight", true));
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("BOTTOM");
		if (xmlNodeList2 != null)
		{
			foreach (BHNDGIPPPCE.AFLDOAKOMOE afldoakomoe in xmlNodeList2.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.AFLDOAKOMOE>(BHNDGIPPPCE.<>c.<>9.ONDMFKKKLIN)))
			{
				this.KGAFADNEKBP.Add(afldoakomoe.LPFKFNLHGBI, afldoakomoe);
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("GiantGrabIdle");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				try
				{
					int key = int.Parse(xmlNode.Attributes["_Color"].Value);
					string value = xmlNode.Attributes["offsets"].Value;
					this.ANHKBEJMHMM[key].BNIHFBMEPAB = value;
				}
				catch (Exception message)
				{
					Debug.LogError(message);
				}
			}
		}
	}

	// Token: 0x0600482A RID: 18474 RVA: 0x00225472 File Offset: 0x00223672
	public BHNDGIPPPCE.FCKCCMDIIFK DAOFNEMHDLD(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI];
	}

	// Token: 0x0600482B RID: 18475 RVA: 0x00225988 File Offset: 0x00223B88
	public string KPEPDIMKBLM(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "\n";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x0600482C RID: 18476 RVA: 0x002254B7 File Offset: 0x002236B7
	public List<int> AJICFPJEGNI()
	{
		return new List<int>(this.ANHKBEJMHMM.Keys);
	}

	// Token: 0x0600482D RID: 18477 RVA: 0x00226290 File Offset: 0x00224490
	public string FGBHMGECIGI(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "1HSwordStrafeRunLeft";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x0600482E RID: 18478 RVA: 0x002262B8 File Offset: 0x002244B8
	public void ODONNAANIEP()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("RepFractions", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.KGAFADNEKBP.Clear();
		this.ANHKBEJMHMM.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("reputaion/fractions/fraction");
		if (xmlNodeList != null)
		{
			foreach (BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk in xmlNodeList.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.FCKCCMDIIFK>(BHNDGIPPPCE.<>c.<>9.ANBGLLOFKOL)))
			{
				this.ANHKBEJMHMM.Add(fckccmdiifk.LPFKFNLHGBI, fckccmdiifk);
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.IKGFHGKKCPG.CHFGNHKJNFG("RepFractions.xml", false));
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("reputaion/levels/replevels");
		if (xmlNodeList2 != null)
		{
			foreach (BHNDGIPPPCE.AFLDOAKOMOE afldoakomoe in xmlNodeList2.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.AFLDOAKOMOE>(BHNDGIPPPCE.<>c.<>9.GOIAMKHANPM)))
			{
				this.KGAFADNEKBP.Add(afldoakomoe.LPFKFNLHGBI, afldoakomoe);
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("reputaion/fractions/fraction");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				try
				{
					int key = int.Parse(xmlNode.Attributes["id"].Value);
					string value = xmlNode.Attributes["name"].Value;
					this.ANHKBEJMHMM[key].BNIHFBMEPAB = value;
				}
				catch (Exception message)
				{
					Debug.LogError(message);
				}
			}
		}
	}

	// Token: 0x0600482F RID: 18479 RVA: 0x002264DC File Offset: 0x002246DC
	public string BBACDNFKPOH(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "_SpawnHeuristic";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x06004830 RID: 18480 RVA: 0x00225472 File Offset: 0x00223672
	public BHNDGIPPPCE.FCKCCMDIIFK CBMIJBEIKID(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI];
	}

	// Token: 0x06004831 RID: 18481 RVA: 0x00225472 File Offset: 0x00223672
	public BHNDGIPPPCE.FCKCCMDIIFK DIGLCANLIHG(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI];
	}

	// Token: 0x06004832 RID: 18482 RVA: 0x00226504 File Offset: 0x00224704
	public void NIDGINCDCNK()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("DISTANCE_CUTOFF_ON", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.KGAFADNEKBP.Clear();
		this.ANHKBEJMHMM.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("sys");
		if (xmlNodeList != null)
		{
			foreach (BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk in xmlNodeList.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.FCKCCMDIIFK>(BHNDGIPPPCE.<>c.<>9.JADGNOPEPKN)))
			{
				this.ANHKBEJMHMM.Add(fckccmdiifk.LPFKFNLHGBI, fckccmdiifk);
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.LPHMKPDBMPP().JPEDCGHDNPN("ElvisLegsLoop", false));
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("GiantEat");
		if (xmlNodeList2 != null)
		{
			foreach (BHNDGIPPPCE.AFLDOAKOMOE afldoakomoe in xmlNodeList2.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.AFLDOAKOMOE>(BHNDGIPPPCE.<>c.<>9.OENKPOMFLKD)))
			{
				this.KGAFADNEKBP.Add(afldoakomoe.LPFKFNLHGBI, afldoakomoe);
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("<color='#{0}'>{1} {3} {2} </color>\n");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				try
				{
					int key = int.Parse(xmlNode.Attributes[" cm"].Value);
					string value = xmlNode.Attributes["\n"].Value;
					this.ANHKBEJMHMM[key].BNIHFBMEPAB = value;
				}
				catch (Exception message)
				{
					Debug.LogError(message);
				}
			}
		}
	}

	// Token: 0x06004833 RID: 18483 RVA: 0x00226728 File Offset: 0x00224928
	public string DBKIBIABELK(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "-none-";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x06004834 RID: 18484 RVA: 0x00225472 File Offset: 0x00223672
	public BHNDGIPPPCE.FCKCCMDIIFK HFLGKMJEIKK(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI];
	}

	// Token: 0x06004835 RID: 18485 RVA: 0x00226750 File Offset: 0x00224950
	public string KEBGFJDMLLH(int HMKPHPAACII, int CNOLCNDBLJE)
	{
		BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk = this.CBMIJBEIKID(HMKPHPAACII);
		if (fckccmdiifk != null)
		{
			return fckccmdiifk.FBGJLBKHKOK(CNOLCNDBLJE);
		}
		return "adjust";
	}

	// Token: 0x06004836 RID: 18486 RVA: 0x002254B7 File Offset: 0x002236B7
	public List<int> NGFDHCLINEC()
	{
		return new List<int>(this.ANHKBEJMHMM.Keys);
	}

	// Token: 0x06004837 RID: 18487 RVA: 0x002254B7 File Offset: 0x002236B7
	public List<int> NIICKMOOLJO()
	{
		return new List<int>(this.ANHKBEJMHMM.Keys);
	}

	// Token: 0x06004838 RID: 18488 RVA: 0x00226775 File Offset: 0x00224975
	public string FMIAMFLAHCC(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "Extinguish";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x06004839 RID: 18489 RVA: 0x0022679C File Offset: 0x0022499C
	public string KEIFNAJGCOJ(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "</color>\n";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x0600483B RID: 18491 RVA: 0x002267CF File Offset: 0x002249CF
	public string LIDKECONLNN(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "Brow";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x0600483C RID: 18492 RVA: 0x00225472 File Offset: 0x00223672
	public BHNDGIPPPCE.FCKCCMDIIFK BBDBKCDJLNF(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI];
	}

	// Token: 0x0600483D RID: 18493 RVA: 0x002254B7 File Offset: 0x002236B7
	public List<int> NKDHBLHFBKF()
	{
		return new List<int>(this.ANHKBEJMHMM.Keys);
	}

	// Token: 0x0600483E RID: 18494 RVA: 0x002267F8 File Offset: 0x002249F8
	public string MECJHEKFKKP(int HMKPHPAACII, int CNOLCNDBLJE)
	{
		BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk = this.DAOFNEMHDLD(HMKPHPAACII);
		if (fckccmdiifk != null)
		{
			return fckccmdiifk.CICOPHPLCMD(CNOLCNDBLJE);
		}
		return "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_quadruped.html";
	}

	// Token: 0x0600483F RID: 18495 RVA: 0x0022544B File Offset: 0x0022364B
	public string GGDFFKGPBPB(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "Cowboy1HandDraw";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x06004840 RID: 18496 RVA: 0x0022681D File Offset: 0x00224A1D
	public string NFHAADOBGKD(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "FistPump";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x06004841 RID: 18497 RVA: 0x00225472 File Offset: 0x00223672
	public BHNDGIPPPCE.FCKCCMDIIFK GOMNHKCHBGP(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI];
	}

	// Token: 0x06004842 RID: 18498 RVA: 0x002254B7 File Offset: 0x002236B7
	public List<int> JCNNECANBIH()
	{
		return new List<int>(this.ANHKBEJMHMM.Keys);
	}

	// Token: 0x06004843 RID: 18499 RVA: 0x002254B7 File Offset: 0x002236B7
	public List<int> DCPIGHFIAJO()
	{
		return new List<int>(this.ANHKBEJMHMM.Keys);
	}

	// Token: 0x06004844 RID: 18500 RVA: 0x00226844 File Offset: 0x00224A44
	public string CJLJDFMNEGK(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "UnityEngine.Vector3";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x06004845 RID: 18501 RVA: 0x002254B7 File Offset: 0x002236B7
	public List<int> OBOPJFPIAJE()
	{
		return new List<int>(this.ANHKBEJMHMM.Keys);
	}

	// Token: 0x06004846 RID: 18502 RVA: 0x0022686C File Offset: 0x00224A6C
	public void DJHLJMDGODH()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("_Offsets", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.KGAFADNEKBP.Clear();
		this.ANHKBEJMHMM.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_polygonal.html");
		if (xmlNodeList != null)
		{
			foreach (BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk in xmlNodeList.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.FCKCCMDIIFK>(BHNDGIPPPCE.<>c.<>9.GBNHLFMAEHG)))
			{
				this.ANHKBEJMHMM.Add(fckccmdiifk.LPFKFNLHGBI, fckccmdiifk);
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.CLIMNFDGOEG().BGOJCAABLNC("______________________________", true));
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("[ACTk] A decimal must be created from exactly 16 bytes");
		if (xmlNodeList2 != null)
		{
			foreach (BHNDGIPPPCE.AFLDOAKOMOE afldoakomoe in xmlNodeList2.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.AFLDOAKOMOE>(BHNDGIPPPCE.<>c.<>9.OPBHDLJFMAE)))
			{
				this.KGAFADNEKBP.Add(afldoakomoe.LPFKFNLHGBI, afldoakomoe);
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("Invalid IKEffector.positionOffset (contains NaN)! Please make sure not to set IKEffector.positionOffset to NaN values.");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				try
				{
					int key = int.Parse(xmlNode.Attributes["Apply 7"].Value);
					string value = xmlNode.Attributes["ok"].Value;
					this.ANHKBEJMHMM[key].BNIHFBMEPAB = value;
				}
				catch (Exception message)
				{
					Debug.LogError(message);
				}
			}
		}
	}

	// Token: 0x06004847 RID: 18503 RVA: 0x00226A90 File Offset: 0x00224C90
	public string IOEKFCDDLBF(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "error.wav";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x06004848 RID: 18504 RVA: 0x00226AB7 File Offset: 0x00224CB7
	public string CPGLGONDLJM(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "LHandPunch";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x06004849 RID: 18505 RVA: 0x00226ADE File Offset: 0x00224CDE
	public string CIOKKMACOKJ(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "</color>";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x0600484A RID: 18506 RVA: 0x002254B7 File Offset: 0x002236B7
	public List<int> KEAKAEKDILC()
	{
		return new List<int>(this.ANHKBEJMHMM.Keys);
	}

	// Token: 0x0600484C RID: 18508 RVA: 0x002254B7 File Offset: 0x002236B7
	public List<int> ICJICICHDFG()
	{
		return new List<int>(this.ANHKBEJMHMM.Keys);
	}

	// Token: 0x0600484D RID: 18509 RVA: 0x00226B23 File Offset: 0x00224D23
	public string INGGEJOLADP(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "Mouse ScrollWheel";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x0600484E RID: 18510 RVA: 0x00225472 File Offset: 0x00223672
	public BHNDGIPPPCE.FCKCCMDIIFK MBBCGHODIAM(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI];
	}

	// Token: 0x0600484F RID: 18511 RVA: 0x00226B4C File Offset: 0x00224D4C
	public string BOIIMMKPGHJ(int HMKPHPAACII, int CNOLCNDBLJE)
	{
		BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk = this.HFLGKMJEIKK(HMKPHPAACII);
		if (fckccmdiifk != null)
		{
			return fckccmdiifk.MMOBNJGNOIG(CNOLCNDBLJE);
		}
		return "Save";
	}

	// Token: 0x06004850 RID: 18512 RVA: 0x00226B71 File Offset: 0x00224D71
	public string NHGMIIEDCOP(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "IdleStand";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x06004851 RID: 18513 RVA: 0x00226B98 File Offset: 0x00224D98
	public void MCEIJMJCDEF()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("SoccerKeeperDiveStrafeFarLeft", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.KGAFADNEKBP.Clear();
		this.ANHKBEJMHMM.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("Invalid vertex colors assigned to ");
		if (xmlNodeList != null)
		{
			foreach (BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk in xmlNodeList.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.FCKCCMDIIFK>(BHNDGIPPPCE.<>c.<>9.GCCAOBCPPLL)))
			{
				this.ANHKBEJMHMM.Add(fckccmdiifk.LPFKFNLHGBI, fckccmdiifk);
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.CLIMNFDGOEG().IDFHKHHNDEK("already_exist", false));
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("=");
		if (xmlNodeList2 != null)
		{
			foreach (BHNDGIPPPCE.AFLDOAKOMOE afldoakomoe in xmlNodeList2.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.AFLDOAKOMOE>(BHNDGIPPPCE.<>c.<>9.OPBHDLJFMAE)))
			{
				this.KGAFADNEKBP.Add(afldoakomoe.LPFKFNLHGBI, afldoakomoe);
			}
		}
		xmlNodeList = xmlDocument.SelectNodes(" ");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				try
				{
					int key = int.Parse(xmlNode.Attributes["Whistle"].Value);
					string value = xmlNode.Attributes["RollerBladeTurnRight"].Value;
					this.ANHKBEJMHMM[key].BNIHFBMEPAB = value;
				}
				catch (Exception message)
				{
					Debug.LogError(message);
				}
			}
		}
	}

	// Token: 0x06004852 RID: 18514 RVA: 0x00226DBC File Offset: 0x00224FBC
	public string IIMAODMOCAE(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "Mirror Refl Camera id";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x06004853 RID: 18515 RVA: 0x00226DE4 File Offset: 0x00224FE4
	public void DGGMIFLJFBM()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("8", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.KGAFADNEKBP.Clear();
		this.ANHKBEJMHMM.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("WeaponStab");
		if (xmlNodeList != null)
		{
			foreach (BHNDGIPPPCE.FCKCCMDIIFK fckccmdiifk in xmlNodeList.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.FCKCCMDIIFK>(BHNDGIPPPCE.<>c.<>9.IBCJOFKHILC)))
			{
				this.ANHKBEJMHMM.Add(fckccmdiifk.LPFKFNLHGBI, fckccmdiifk);
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.EKEBHIJMEML().BGOJCAABLNC("GetMouseButtonUp reboot", true));
		XmlNodeList xmlNodeList2 = xmlDocument.SelectNodes("maxWgtBait");
		if (xmlNodeList2 != null)
		{
			foreach (BHNDGIPPPCE.AFLDOAKOMOE afldoakomoe in xmlNodeList2.Cast<XmlNode>().Select(new Func<XmlNode, BHNDGIPPPCE.AFLDOAKOMOE>(BHNDGIPPPCE.<>c.<>9.DFDKODPOENJ)))
			{
				this.KGAFADNEKBP.Add(afldoakomoe.LPFKFNLHGBI, afldoakomoe);
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				try
				{
					int key = int.Parse(xmlNode.Attributes["</color>"].Value);
					string value = xmlNode.Attributes["Climbing Idle"].Value;
					this.ANHKBEJMHMM[key].BNIHFBMEPAB = value;
				}
				catch (Exception message)
				{
					Debug.LogError(message);
				}
			}
		}
	}

	// Token: 0x06004854 RID: 18516 RVA: 0x00227008 File Offset: 0x00225208
	public string AEOJFOLJGPJ(int LPFKFNLHGBI)
	{
		if (!this.ANHKBEJMHMM.ContainsKey(LPFKFNLHGBI))
		{
			return "TOD_Sky2World";
		}
		return this.ANHKBEJMHMM[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x04000B5C RID: 2908
	public static readonly BHNDGIPPPCE IKGFHGKKCPG = new BHNDGIPPPCE();

	// Token: 0x04000B5D RID: 2909
	private readonly Dictionary<int, BHNDGIPPPCE.FCKCCMDIIFK> ANHKBEJMHMM = new Dictionary<int, BHNDGIPPPCE.FCKCCMDIIFK>();

	// Token: 0x04000B5E RID: 2910
	private readonly Dictionary<int, BHNDGIPPPCE.AFLDOAKOMOE> KGAFADNEKBP = new Dictionary<int, BHNDGIPPPCE.AFLDOAKOMOE>();

	// Token: 0x02000157 RID: 343
	public class MKIEEEENAMA : ItemBase
	{
		// Token: 0x06004856 RID: 18518 RVA: 0x0022702F File Offset: 0x0022522F
		public override string IBLEHFEBIMG()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004857 RID: 18519 RVA: 0x0022703C File Offset: 0x0022523C
		public virtual int HNMBNDHMGMI(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 1;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x06004858 RID: 18520 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string OEAEGBAEEPP()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004859 RID: 18521 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH AIHENNHGODP()
		{
			return null;
		}

		// Token: 0x0600485A RID: 18522 RVA: 0x00227074 File Offset: 0x00225274
		public override int EEIMGILODKM(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 1;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600485B RID: 18523 RVA: 0x002270AC File Offset: 0x002252AC
		public virtual int DALNEPDCGEK(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 0;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x0600485C RID: 18524 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH AAMMIELGJNA()
		{
			return null;
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string OCJAOJLHOFO()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x0600485E RID: 18526 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HCHOBHCDHME()
		{
			return null;
		}

		// Token: 0x0600485F RID: 18527 RVA: 0x002270E4 File Offset: 0x002252E4
		public virtual int OKFPGBKONAN(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 0;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x06004860 RID: 18528 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string KBHGJLAEMFH()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004861 RID: 18529 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string MIHCFECAIAD()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004862 RID: 18530 RVA: 0x0022711C File Offset: 0x0022531C
		public virtual int JLDACJOFMJJ(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 1;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06004863 RID: 18531 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DEOMJEEMGMI()
		{
			return null;
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string CBPDHBKDMGC()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004865 RID: 18533 RVA: 0x0022702F File Offset: 0x0022522F
		public override string CJMFHLIBCBM()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004866 RID: 18534 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string AOJIJIPBKPB()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004867 RID: 18535 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string NEEHKIJGJKB()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004868 RID: 18536 RVA: 0x00227154 File Offset: 0x00225354
		public virtual int NGKJCKJOJPC(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 1;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06004869 RID: 18537 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH MNHHOADANDG()
		{
			return null;
		}

		// Token: 0x0600486A RID: 18538 RVA: 0x0022718C File Offset: 0x0022538C
		public virtual int IPLNJOONDFI(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 0;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x002271C4 File Offset: 0x002253C4
		public override int OKJGDAHOCBG(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 1;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string IBNCBKOPEOC()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x0600486D RID: 18541 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string EOAGNAKKDMK()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x0600486E RID: 18542 RVA: 0x002271FC File Offset: 0x002253FC
		public virtual int DFGPHMNBCPP(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 0;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x0600486F RID: 18543 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DCIMNIONGEM()
		{
			return null;
		}

		// Token: 0x06004870 RID: 18544 RVA: 0x0022702F File Offset: 0x0022522F
		public override string DIJJDHMMGCA()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004871 RID: 18545 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string JHGPBNCOHHH()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004872 RID: 18546 RVA: 0x0022702F File Offset: 0x0022522F
		public override string ToString()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004873 RID: 18547 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH EJJAGEFMHCO()
		{
			return null;
		}

		// Token: 0x06004874 RID: 18548 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HAEJBFNEIOM()
		{
			return null;
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH ELFEJJNOKPC()
		{
			return null;
		}

		// Token: 0x06004876 RID: 18550 RVA: 0x00227234 File Offset: 0x00225434
		public override int BLCCPFGCANC(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 0;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x0022726C File Offset: 0x0022546C
		public virtual int HCAFIJGEELE(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 1;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06004878 RID: 18552 RVA: 0x002272A4 File Offset: 0x002254A4
		public virtual int GLDGNENMFNM(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 0;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06004879 RID: 18553 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH IPEDEEMNPFN()
		{
			return null;
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string ALELIIHGHGH()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x002272DC File Offset: 0x002254DC
		public virtual int PMHKENHEHGM(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 1;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x0600487C RID: 18556 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LOHCIIFHNCE()
		{
			return null;
		}

		// Token: 0x0600487D RID: 18557 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string HDPLEBMIHFA()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x0600487E RID: 18558 RVA: 0x00227314 File Offset: 0x00225514
		public virtual int BEPGBMNACPO(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 0;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600487F RID: 18559 RVA: 0x0022702F File Offset: 0x0022522F
		public override string BACHFNMDOLO()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004880 RID: 18560 RVA: 0x0022734C File Offset: 0x0022554C
		public virtual int IFMPGAHGKBJ(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 0;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x06004881 RID: 18561 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string JCAONLDGMCJ()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004882 RID: 18562 RVA: 0x00227384 File Offset: 0x00225584
		public virtual int PBNOLHDBLFL(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 0;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string FGNNJFJLENH()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004884 RID: 18564 RVA: 0x002273BC File Offset: 0x002255BC
		public virtual int LJHPFCHEEAG(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 0;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x06004885 RID: 18565 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string HLHHDFFDHGL()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004886 RID: 18566 RVA: 0x002273F4 File Offset: 0x002255F4
		public virtual int PNCBMBOFKNP(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 1;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH OMDGBKHPPMH()
		{
			return null;
		}

		// Token: 0x06004888 RID: 18568 RVA: 0x0022742C File Offset: 0x0022562C
		public virtual int HNGNBANCGAC(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 1;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x06004889 RID: 18569 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DKEKMPAFIPD()
		{
			return null;
		}

		// Token: 0x0600488A RID: 18570 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string AHFDMABJGOL()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x0600488B RID: 18571 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH GPIDMMEHMKF()
		{
			return null;
		}

		// Token: 0x0600488C RID: 18572 RVA: 0x00227464 File Offset: 0x00225664
		public virtual int BHCDJKOPKHD(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 0;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x0022749C File Offset: 0x0022569C
		public virtual int JLDFEHFAKBM(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 1;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH PBHPIGPDCJA()
		{
			return null;
		}

		// Token: 0x0600488F RID: 18575 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string PINLAFIAGGJ()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004890 RID: 18576 RVA: 0x002274D4 File Offset: 0x002256D4
		public virtual int OFLOPECEHLM(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 1;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x06004891 RID: 18577 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH HFAGADCJACL()
		{
			return null;
		}

		// Token: 0x06004892 RID: 18578 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH MINPNPKJCMA()
		{
			return null;
		}

		// Token: 0x06004893 RID: 18579 RVA: 0x0022750C File Offset: 0x0022570C
		public virtual int BMDCHEODDGA(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 0;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x06004894 RID: 18580 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HJKJBOMEHHJ()
		{
			return null;
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string DHCBHNAAJKI()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004896 RID: 18582 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string NILBMGFGPPB()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x00227544 File Offset: 0x00225744
		public virtual int PPDPKFBKIPH(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 0;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06004898 RID: 18584 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DKGBLACIOMH()
		{
			return null;
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LKGPLALBDDJ()
		{
			return null;
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH GKPOPMAAGIJ()
		{
			return null;
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string NAAOOABFHKB()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x0022757C File Offset: 0x0022577C
		public virtual int CIBEGCNAMGA(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 1;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x0600489D RID: 18589 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LFBLJHDFPCO()
		{
			return null;
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x002275B4 File Offset: 0x002257B4
		public virtual int LAEBNJPLGHJ(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 0;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x002275EC File Offset: 0x002257EC
		public virtual int MKAPJCABOPH(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 1;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x00227624 File Offset: 0x00225824
		public override int CAGEGAFLKMG(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 0;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x060048A1 RID: 18593 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string FJGIAILHMIF()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string DIACBNHNDCJ()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x0022702F File Offset: 0x0022522F
		public virtual string DGOBKBBGGKN()
		{
			return this.NGABBHKOAHE.BNIHFBMEPAB;
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x0022765C File Offset: 0x0022585C
		public override int NBCAEJHKLMG(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 0;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH PGFNEDLFAFD()
		{
			return null;
		}

		// Token: 0x060048A6 RID: 18598 RVA: 0x00227694 File Offset: 0x00225894
		public virtual int PAPOPNHNEPA(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 1;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060048A7 RID: 18599 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH MJCDKHIJNAE()
		{
			return null;
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x002276CC File Offset: 0x002258CC
		public override int HFCKNENEKKP(ItemBase MBKPMBPLIJN)
		{
			BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)MBKPMBPLIJN;
			int result = 1;
			if (mkieeeenama.LPFKFNLHGBI > this.LPFKFNLHGBI)
			{
				result = -1;
			}
			if (mkieeeenama.LPFKFNLHGBI < this.LPFKFNLHGBI)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x04000B5F RID: 2911
		public int LPFKFNLHGBI;

		// Token: 0x04000B60 RID: 2912
		public int CNOLCNDBLJE;

		// Token: 0x04000B61 RID: 2913
		public int GKCKHINIJPH;

		// Token: 0x04000B62 RID: 2914
		public BHNDGIPPPCE.FCKCCMDIIFK NGABBHKOAHE;
	}

	// Token: 0x02000158 RID: 344
	public class AFLDOAKOMOE
	{
		// Token: 0x060048A9 RID: 18601 RVA: 0x00227701 File Offset: 0x00225901
		public string EGAKADGKHHG(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "qualityLevel";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048AA RID: 18602 RVA: 0x00227727 File Offset: 0x00225927
		public string MKBAHNMPMJB(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return ";";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048AB RID: 18603 RVA: 0x0022774D File Offset: 0x0022594D
		public string KOPGGODACAE(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048AC RID: 18604 RVA: 0x00227773 File Offset: 0x00225973
		public string DODIGOPIANI(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "auk_pstavka";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048AD RID: 18605 RVA: 0x00227799 File Offset: 0x00225999
		public string IDJDEAGKFKM(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "_DepthScale";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048AE RID: 18606 RVA: 0x002277BF File Offset: 0x002259BF
		public string APKFPJKJCEM(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "ui_default_click.wav";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048AF RID: 18607 RVA: 0x002277E5 File Offset: 0x002259E5
		public string HHCCCIHAOJG(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "Soccer Walk";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048B0 RID: 18608 RVA: 0x0022780B File Offset: 0x00225A0B
		public string DONLMCLHMDJ(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "FishOnRod";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048B1 RID: 18609 RVA: 0x00227831 File Offset: 0x00225A31
		public string JOIPBDBKHPD(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "_VignetteTex";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x00227857 File Offset: 0x00225A57
		public string FEGJGPBJPII(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "GiantGrabThrow2";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048B3 RID: 18611 RVA: 0x0022787D File Offset: 0x00225A7D
		public string DJIFBIACCEG(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "gi_uinf_11";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048B4 RID: 18612 RVA: 0x002278A3 File Offset: 0x00225AA3
		public string GOAHADBLPBL(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "IdleStandingJump";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048B5 RID: 18613 RVA: 0x002278C9 File Offset: 0x00225AC9
		public string PIICBGHOPDG(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "#ff8060";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048B6 RID: 18614 RVA: 0x002278EF File Offset: 0x00225AEF
		public string DLNIPCCLLEA(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "Materials/DFMLambertSolidColor";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x00227915 File Offset: 0x00225B15
		public string MKIIIECDGKD(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "file:///";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x0022793B File Offset: 0x00225B3B
		public string GHEOKOIAJIN(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "MotorbikeSuperman";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048B9 RID: 18617 RVA: 0x00227961 File Offset: 0x00225B61
		public string HHIFOGNPBEM(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x00227987 File Offset: 0x00225B87
		public string JMJHPIMIIOM(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "WallSit";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x002279AD File Offset: 0x00225BAD
		public string KONFHFGOANA(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "invn_rec5";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x002279D3 File Offset: 0x00225BD3
		public string KJKMHPGDAIC(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "ldGo not found";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x002279F9 File Offset: 0x00225BF9
		public string EJKCOONODLH(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "_RgbTex";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x00227A1F File Offset: 0x00225C1F
		public string HOAHJMMANDB(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "_BlurRadius4";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x00227A45 File Offset: 0x00225C45
		public string BJPCCJNFKAD(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "brow";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x00227A6B File Offset: 0x00225C6B
		public string INBHHBIANAG(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "Knees Idle";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x00227A91 File Offset: 0x00225C91
		public string OPJHEJFBAPF(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "_ExposureCompensation";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x00227961 File Offset: 0x00225B61
		public string BEFIAPHPIBJ(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x00227AB7 File Offset: 0x00225CB7
		public string IFPACMMEJGP(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "cht_msg18";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x00227ADD File Offset: 0x00225CDD
		public string PMHIEHMEHLP(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "invn_rec13";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x00227B03 File Offset: 0x00225D03
		public string BLLENKMHKNC(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "No collider assigned for a HitPointBone in the HitReaction component.";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x00227B29 File Offset: 0x00225D29
		public string BLKGHNIOKJB(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "Jump";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x00227B4F File Offset: 0x00225D4F
		public string DLNFCBHKACP(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "<color='#80ff60'>";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x00227B75 File Offset: 0x00225D75
		public string DIPHLPIPHHP(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "32";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x00227B9C File Offset: 0x00225D9C
		public AFLDOAKOMOE(XmlNode JEEEOEBNJDJ)
		{
			if (JEEEOEBNJDJ.Attributes != null)
			{
				this.LPFKFNLHGBI = int.Parse(JEEEOEBNJDJ.Attributes["id"].Value);
			}
			foreach (XmlNode xmlNode in JEEEOEBNJDJ.ChildNodes.Cast<XmlNode>().Where(new Func<XmlNode, bool>(BHNDGIPPPCE.AFLDOAKOMOE.<>c.<>9.AOJKCMDHNJA)))
			{
				this.KBFPEKNEIJC.Add(xmlNode.InnerText);
			}
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x00227C58 File Offset: 0x00225E58
		public string HGEBOOHJIEJ(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "</color>\n";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x00227C7E File Offset: 0x00225E7E
		public string MGGAIHJABCM(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "Wizard1HandThrow";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x00227CA4 File Offset: 0x00225EA4
		public string HIHPHACKAIE(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "WizardNeoBlock";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048CD RID: 18637 RVA: 0x00227CCA File Offset: 0x00225ECA
		public string AIFNPMFILMC(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "auk_wcnt";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048CE RID: 18638 RVA: 0x00227CF0 File Offset: 0x00225EF0
		public string JOMHHAPOMDO(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "\\n";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x00227D16 File Offset: 0x00225F16
		public string EKEGGAMBDFK(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "fishdrop_3";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x00227D3C File Offset: 0x00225F3C
		public string KDKILDJEELH(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 0 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "IKSolverFABRIKRoot chain at index ";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x00227D62 File Offset: 0x00225F62
		public string GDKMPIJJEKO(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "IceHockeyShotLeft";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x00227D88 File Offset: 0x00225F88
		public string EPPHDCDCHNF(int CNOLCNDBLJE)
		{
			if (CNOLCNDBLJE < 1 || CNOLCNDBLJE >= this.KBFPEKNEIJC.Count)
			{
				return "autherror";
			}
			return this.KBFPEKNEIJC[CNOLCNDBLJE];
		}

		// Token: 0x04000B63 RID: 2915
		public int LPFKFNLHGBI;

		// Token: 0x04000B64 RID: 2916
		public List<string> KBFPEKNEIJC = new List<string>();
	}

	// Token: 0x0200015A RID: 346
	public class FCKCCMDIIFK
	{
		// Token: 0x060048FB RID: 18683 RVA: 0x00228030 File Offset: 0x00226230
		public int JPEMLJEKCCB(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x0022804C File Offset: 0x0022624C
		public string MPJHMGOOLNI(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].HHCCCIHAOJG(CNOLCNDBLJE);
		}

		// Token: 0x060048FD RID: 18685 RVA: 0x00228069 File Offset: 0x00226269
		public string NFKIPHFFLDG(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].BLLENKMHKNC(CNOLCNDBLJE);
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x00228086 File Offset: 0x00226286
		public int KDDAHILHIEF()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 0;
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x00228030 File Offset: 0x00226230
		public int PLBOILPEJFG(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x002280A9 File Offset: 0x002262A9
		public string LGCHLKLAMKF(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].EJKCOONODLH(CNOLCNDBLJE);
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x002280C6 File Offset: 0x002262C6
		public string KKFOPDFOADB(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KOPGGODACAE(CNOLCNDBLJE);
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x00228030 File Offset: 0x00226230
		public int PPEGAMBCNKO(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x002280E3 File Offset: 0x002262E3
		public string IANEDEDHKJN(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].BEFIAPHPIBJ(CNOLCNDBLJE);
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x00228086 File Offset: 0x00226286
		public int KKFINFKOBOB()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 0;
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x00228086 File Offset: 0x00226286
		public int IJNGFDPPJCH()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 0;
		}

		// Token: 0x06004906 RID: 18694 RVA: 0x00228030 File Offset: 0x00226230
		public int MHHPMBKFOFO(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004907 RID: 18695 RVA: 0x00228100 File Offset: 0x00226300
		public string DHDALGPMPMN(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].EGAKADGKHHG(CNOLCNDBLJE);
		}

		// Token: 0x06004908 RID: 18696 RVA: 0x00228086 File Offset: 0x00226286
		public int AFKAHEDIMOJ()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 0;
		}

		// Token: 0x06004909 RID: 18697 RVA: 0x0022811D File Offset: 0x0022631D
		public string OOBONOKCMDC(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].MGGAIHJABCM(CNOLCNDBLJE);
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x00228030 File Offset: 0x00226230
		public int AHEDHMBDHFD(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600490B RID: 18699 RVA: 0x00228030 File Offset: 0x00226230
		public int GIADDELABCJ(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x0022813A File Offset: 0x0022633A
		public string CDDLPAGILMO(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].DONLMCLHMDJ(CNOLCNDBLJE);
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x00228030 File Offset: 0x00226230
		public int LEEHFACALMO(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600490E RID: 18702 RVA: 0x00228030 File Offset: 0x00226230
		public int EFCBIOALKNO(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600490F RID: 18703 RVA: 0x00228086 File Offset: 0x00226286
		public int MKFAMLGKINH()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 0;
		}

		// Token: 0x06004910 RID: 18704 RVA: 0x00228086 File Offset: 0x00226286
		public int AMAIECJNHNG()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 0;
		}

		// Token: 0x06004911 RID: 18705 RVA: 0x00228086 File Offset: 0x00226286
		public int LJMGIHFEHMP()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 0;
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x00228086 File Offset: 0x00226286
		public int CPEIOPHOLAA()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 0;
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x00228030 File Offset: 0x00226230
		public int CLJGHAMIMCD(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x00228086 File Offset: 0x00226286
		public int JIKMCBOPDKC()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 0;
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x00228157 File Offset: 0x00226357
		public int GGHEBHMABKF()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 1;
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x00228086 File Offset: 0x00226286
		public int AOJDOCEGGJD()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 0;
		}

		// Token: 0x06004917 RID: 18711 RVA: 0x0022817A File Offset: 0x0022637A
		public string NMKBPHLNBDE(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].DODIGOPIANI(CNOLCNDBLJE);
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x002280E3 File Offset: 0x002262E3
		public string NKLHDFNECDC(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].BEFIAPHPIBJ(CNOLCNDBLJE);
		}

		// Token: 0x06004919 RID: 18713 RVA: 0x00228198 File Offset: 0x00226398
		public FCKCCMDIIFK(XmlNode JEEEOEBNJDJ)
		{
			if (JEEEOEBNJDJ.Attributes != null)
			{
				this.LPFKFNLHGBI = int.Parse(JEEEOEBNJDJ.Attributes["id"].Value);
			}
			foreach (object obj in JEEEOEBNJDJ.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN("val=" + xmlNode.InnerText);
				if (xmlNode.Name == "startA")
				{
					this.DAAEJIEHCCC = diggohpgcnn.DIKKDGKIPEA;
				}
				if (xmlNode.Name == "startB")
				{
					this.DBJFAKLFLFN = diggohpgcnn.DIKKDGKIPEA;
				}
				if (xmlNode.Name == "kfB")
				{
					this.NGGGABIEMOI = diggohpgcnn.PPAAACJOOGA;
				}
				if (xmlNode.Name == "repnames")
				{
					this.EOOEFPBLMNC = diggohpgcnn.DIKKDGKIPEA;
				}
			}
		}

		// Token: 0x0600491A RID: 18714 RVA: 0x002280E3 File Offset: 0x002262E3
		public string CJNHPHAOEDL(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].BEFIAPHPIBJ(CNOLCNDBLJE);
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x0022813A File Offset: 0x0022633A
		public string NLFAGGKEJOJ(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].DONLMCLHMDJ(CNOLCNDBLJE);
		}

		// Token: 0x0600491C RID: 18716 RVA: 0x002280A9 File Offset: 0x002262A9
		public string LJDCEAAPOJG(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].EJKCOONODLH(CNOLCNDBLJE);
		}

		// Token: 0x0600491D RID: 18717 RVA: 0x00228030 File Offset: 0x00226230
		public int BFAJCADIEHD(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600491E RID: 18718 RVA: 0x00228086 File Offset: 0x00226286
		public int PHGLOHOFCNN()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 0;
		}

		// Token: 0x0600491F RID: 18719 RVA: 0x002282AC File Offset: 0x002264AC
		public string BLICEFILIJN(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].DIPHLPIPHHP(CNOLCNDBLJE);
		}

		// Token: 0x06004920 RID: 18720 RVA: 0x00228030 File Offset: 0x00226230
		public int HNPLHAKBJEJ(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x00228030 File Offset: 0x00226230
		public int FLHGELMKLAI(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x002282C9 File Offset: 0x002264C9
		public string LEHLOIBJHPK(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].DLNFCBHKACP(CNOLCNDBLJE);
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x00228157 File Offset: 0x00226357
		public int FHPJOMKJNKI()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 1;
		}

		// Token: 0x06004924 RID: 18724 RVA: 0x002282E6 File Offset: 0x002264E6
		public string CPNPJCMLMIN(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].HIHPHACKAIE(CNOLCNDBLJE);
		}

		// Token: 0x06004925 RID: 18725 RVA: 0x00228303 File Offset: 0x00226503
		public string GEMOHKBMCDM(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].IDJDEAGKFKM(CNOLCNDBLJE);
		}

		// Token: 0x06004926 RID: 18726 RVA: 0x00228320 File Offset: 0x00226520
		public string LEKKCOMPCMN(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].INBHHBIANAG(CNOLCNDBLJE);
		}

		// Token: 0x06004927 RID: 18727 RVA: 0x00228086 File Offset: 0x00226286
		public int HIAJDDNAJEM()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 0;
		}

		// Token: 0x06004928 RID: 18728 RVA: 0x00228030 File Offset: 0x00226230
		public int DNNLMIBDPNH(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004929 RID: 18729 RVA: 0x00228030 File Offset: 0x00226230
		public int LGGBCHCKJBB(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x00228030 File Offset: 0x00226230
		public int BFPDOOBGEGL(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600492B RID: 18731 RVA: 0x0022833D File Offset: 0x0022653D
		public string IDKMNCOBADK(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].EKEGGAMBDFK(CNOLCNDBLJE);
		}

		// Token: 0x0600492C RID: 18732 RVA: 0x00228157 File Offset: 0x00226357
		public int EMCJCNJIGIG()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 1;
		}

		// Token: 0x0600492D RID: 18733 RVA: 0x00228157 File Offset: 0x00226357
		public int EMPNJBCODIP()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 1;
		}

		// Token: 0x0600492E RID: 18734 RVA: 0x00228030 File Offset: 0x00226230
		public int OFOBKGEEAEB(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600492F RID: 18735 RVA: 0x00228030 File Offset: 0x00226230
		public int ECBHOIHEPPB(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004930 RID: 18736 RVA: 0x0022835A File Offset: 0x0022655A
		public string CIDLLLNBLCN(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].JMJHPIMIIOM(CNOLCNDBLJE);
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x00228157 File Offset: 0x00226357
		public int LOEEKJMMEPF()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 1;
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x00228377 File Offset: 0x00226577
		public string MCEADPEMPEG(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].DJIFBIACCEG(CNOLCNDBLJE);
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x00228394 File Offset: 0x00226594
		public string AKBCDIJIOEN(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].PIICBGHOPDG(CNOLCNDBLJE);
		}

		// Token: 0x06004934 RID: 18740 RVA: 0x00228157 File Offset: 0x00226357
		public int OJEHNIDJEKP()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 1;
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x002283B1 File Offset: 0x002265B1
		public string ILHGJBLFGHA(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].HHIFOGNPBEM(CNOLCNDBLJE);
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x00228086 File Offset: 0x00226286
		public int GAIDEJDIGGH()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 0;
		}

		// Token: 0x06004937 RID: 18743 RVA: 0x00228030 File Offset: 0x00226230
		public int BFENKFLINLE(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x00228030 File Offset: 0x00226230
		public int BFPNMLPJMMK(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004939 RID: 18745 RVA: 0x00228069 File Offset: 0x00226269
		public string BEIALABAAHM(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].BLLENKMHKNC(CNOLCNDBLJE);
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x00228030 File Offset: 0x00226230
		public int BBKKGOMLAPI(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x00228157 File Offset: 0x00226357
		public int PMFFIFFCGNF()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 1;
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x00228030 File Offset: 0x00226230
		public int GCNBGNAJCCD(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x00228086 File Offset: 0x00226286
		public int OBHHJKBPBID()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 0;
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x00228030 File Offset: 0x00226230
		public int CPLDADLIDMB(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x00228030 File Offset: 0x00226230
		public int OOKDKALMPFN(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004940 RID: 18752 RVA: 0x00228030 File Offset: 0x00226230
		public int PPNFAOPFHLG(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004941 RID: 18753 RVA: 0x00228157 File Offset: 0x00226357
		public int PJAIFKLAHJO()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 1;
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x00228157 File Offset: 0x00226357
		public int MJIHGFHCCMB()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 1;
		}

		// Token: 0x06004943 RID: 18755 RVA: 0x002280A9 File Offset: 0x002262A9
		public string JBKAEOHFNMH(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].EJKCOONODLH(CNOLCNDBLJE);
		}

		// Token: 0x06004944 RID: 18756 RVA: 0x002283CE File Offset: 0x002265CE
		public string BBHPHDAGPLB(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].EPPHDCDCHNF(CNOLCNDBLJE);
		}

		// Token: 0x06004945 RID: 18757 RVA: 0x00228320 File Offset: 0x00226520
		public string LFGFCHEOCAE(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].INBHHBIANAG(CNOLCNDBLJE);
		}

		// Token: 0x06004946 RID: 18758 RVA: 0x00228030 File Offset: 0x00226230
		public int MCKFNPHJOPJ(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004947 RID: 18759 RVA: 0x00228030 File Offset: 0x00226230
		public int FLOCPGHEADH(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x002280C6 File Offset: 0x002262C6
		public string OIEIAPJKLIE(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KOPGGODACAE(CNOLCNDBLJE);
		}

		// Token: 0x06004949 RID: 18761 RVA: 0x00228030 File Offset: 0x00226230
		public int KCOBOJOPDEJ(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600494A RID: 18762 RVA: 0x00228157 File Offset: 0x00226357
		public int KDAEIINGDFI()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 1;
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x00228030 File Offset: 0x00226230
		public int LIBAHJLOHPH(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600494C RID: 18764 RVA: 0x00228030 File Offset: 0x00226230
		public int HNPBEACLKGA(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600494D RID: 18765 RVA: 0x00228157 File Offset: 0x00226357
		public int AJKPFBFJECI()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 1;
		}

		// Token: 0x0600494E RID: 18766 RVA: 0x002283EB File Offset: 0x002265EB
		public string MMOBNJGNOIG(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].BLKGHNIOKJB(CNOLCNDBLJE);
		}

		// Token: 0x0600494F RID: 18767 RVA: 0x00228157 File Offset: 0x00226357
		public int HDOMPFOIFHC()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 1;
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x00228030 File Offset: 0x00226230
		public int LEKKCBCCNIE(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x00228157 File Offset: 0x00226357
		public int OKGLPABBPKB()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 1;
		}

		// Token: 0x06004952 RID: 18770 RVA: 0x00228030 File Offset: 0x00226230
		public int CGNCLOGCPBI(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004953 RID: 18771 RVA: 0x002283EB File Offset: 0x002265EB
		public string BGNKPNFAJPL(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].BLKGHNIOKJB(CNOLCNDBLJE);
		}

		// Token: 0x06004954 RID: 18772 RVA: 0x00228408 File Offset: 0x00226608
		public string PNFACDLPJEH(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].JOMHHAPOMDO(CNOLCNDBLJE);
		}

		// Token: 0x06004955 RID: 18773 RVA: 0x00228030 File Offset: 0x00226230
		public int FEFOIAOCDNP(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004956 RID: 18774 RVA: 0x00228030 File Offset: 0x00226230
		public int CPJJCPIJNEO(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004957 RID: 18775 RVA: 0x00228030 File Offset: 0x00226230
		public int JMADOOFFBDP(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004958 RID: 18776 RVA: 0x00228030 File Offset: 0x00226230
		public int LFGPLFOPGBB(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004959 RID: 18777 RVA: 0x00228425 File Offset: 0x00226625
		public string ANNELHLKKLA(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KDKILDJEELH(CNOLCNDBLJE);
		}

		// Token: 0x0600495A RID: 18778 RVA: 0x00228030 File Offset: 0x00226230
		public int CEKIFOBDFBJ(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600495B RID: 18779 RVA: 0x002282AC File Offset: 0x002264AC
		public string CICOPHPLCMD(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].DIPHLPIPHHP(CNOLCNDBLJE);
		}

		// Token: 0x0600495C RID: 18780 RVA: 0x00228030 File Offset: 0x00226230
		public int DOILPEMEOPD(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x002283EB File Offset: 0x002265EB
		public string BOMLGBJEFJK(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].BLKGHNIOKJB(CNOLCNDBLJE);
		}

		// Token: 0x0600495E RID: 18782 RVA: 0x00228030 File Offset: 0x00226230
		public int BPBOPBIHDMI(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600495F RID: 18783 RVA: 0x00228442 File Offset: 0x00226642
		public string BNLJHEDLHMN(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].PMHIEHMEHLP(CNOLCNDBLJE);
		}

		// Token: 0x06004960 RID: 18784 RVA: 0x00228086 File Offset: 0x00226286
		public int BCMPKHDDFKK()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 0;
		}

		// Token: 0x06004961 RID: 18785 RVA: 0x00228030 File Offset: 0x00226230
		public int NEPFHKJNIAO(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x00228157 File Offset: 0x00226357
		public int FKLICOLEHDI()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 1;
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x00228030 File Offset: 0x00226230
		public int ALPEOCJBBMJ(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004964 RID: 18788 RVA: 0x00228030 File Offset: 0x00226230
		public int NEIPEBOLCJF(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x0022845F File Offset: 0x0022665F
		public string NDFJLICIFEC(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].BJPCCJNFKAD(CNOLCNDBLJE);
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x0022847C File Offset: 0x0022667C
		public string FBGJLBKHKOK(int CNOLCNDBLJE)
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].AIFNPMFILMC(CNOLCNDBLJE);
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x00228157 File Offset: 0x00226357
		public int BGNIEJBMOAJ()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 1;
		}

		// Token: 0x06004968 RID: 18792 RVA: 0x00228030 File Offset: 0x00226230
		public int EDMHBNNENDA(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x06004969 RID: 18793 RVA: 0x00228157 File Offset: 0x00226357
		public int NDNMJIKNIJF()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 1;
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x00228030 File Offset: 0x00226230
		public int PDMEBGJGFLC(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x00228030 File Offset: 0x00226230
		public int DAAOBOJJNCJ(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x00228030 File Offset: 0x00226230
		public int LHJLMOEHGDG(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x00228030 File Offset: 0x00226230
		public int EACPOHBKEAK(int CNOLCNDBLJE)
		{
			return (int)((float)this.DAAEJIEHCCC + (float)this.DBJFAKLFLFN * this.NGGGABIEMOI * (float)CNOLCNDBLJE);
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x00228086 File Offset: 0x00226286
		public int CIJLOBEEEDP()
		{
			return BHNDGIPPPCE.IKGFHGKKCPG.KGAFADNEKBP[this.EOOEFPBLMNC].KBFPEKNEIJC.Count - 0;
		}

		// Token: 0x04000B67 RID: 2919
		public int LPFKFNLHGBI;

		// Token: 0x04000B68 RID: 2920
		public string BNIHFBMEPAB;

		// Token: 0x04000B69 RID: 2921
		public int EOOEFPBLMNC;

		// Token: 0x04000B6A RID: 2922
		public int DAAEJIEHCCC;

		// Token: 0x04000B6B RID: 2923
		public int DBJFAKLFLFN;

		// Token: 0x04000B6C RID: 2924
		public float NGGGABIEMOI;
	}
}
