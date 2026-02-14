using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

// Token: 0x0200014E RID: 334
public class NLNNIDBPKAO
{
	// Token: 0x060046D0 RID: 18128 RVA: 0x00216D30 File Offset: 0x00214F30
	public NLNNIDBPKAO.KDHODDMNDFC ALOFNMHDOJM(int LPFKFNLHGBI)
	{
		if (!this.GADJFFGDCFA.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.GADJFFGDCFA[LPFKFNLHGBI];
	}

	// Token: 0x060046D1 RID: 18129 RVA: 0x00216D50 File Offset: 0x00214F50
	public void DGGMIFLJFBM()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Called GetNumberOfCurrentPlayers()", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.GADJFFGDCFA.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("wpn_add/addoptions");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = new NLNNIDBPKAO.KDHODDMNDFC(xmlNode);
				kdhoddmndfc.POKJFJBHDOJ = true;
				this.GADJFFGDCFA.Add(kdhoddmndfc.LPFKFNLHGBI, kdhoddmndfc);
				foreach (object obj2 in xmlNode.SelectNodes("[0-9]*_)"))
				{
					NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc2 = new NLNNIDBPKAO.KDHODDMNDFC((XmlNode)obj2);
					kdhoddmndfc2.POKJFJBHDOJ = false;
					kdhoddmndfc2.IHBEJDJINAI = kdhoddmndfc.LPFKFNLHGBI;
					kdhoddmndfc.BFBFHEGGOKL.Add(kdhoddmndfc2);
					this.GADJFFGDCFA.Add(kdhoddmndfc2.LPFKFNLHGBI, kdhoddmndfc2);
				}
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.CLIMNFDGOEG().DDKLHGHBEIG("KatanaReady", false));
		xmlNodeList = xmlDocument.SelectNodes("WaterQuad");
		foreach (object obj3 in xmlNodeList)
		{
			XmlNode xmlNode2 = (XmlNode)obj3;
			try
			{
				int key = int.Parse(xmlNode2.Attributes["Wait"].Value);
				if (this.GADJFFGDCFA.ContainsKey(key))
				{
					this.GADJFFGDCFA[key].AAOPDCCCNFK(xmlNode2);
				}
			}
			catch (Exception message)
			{
				Debug.LogError(message);
			}
		}
		Debug.Log("Demo");
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x060046D2 RID: 18130 RVA: 0x00216D30 File Offset: 0x00214F30
	public NLNNIDBPKAO.KDHODDMNDFC DJDLJCFCPPH(int LPFKFNLHGBI)
	{
		if (!this.GADJFFGDCFA.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.GADJFFGDCFA[LPFKFNLHGBI];
	}

	// Token: 0x060046D3 RID: 18131 RVA: 0x00216D30 File Offset: 0x00214F30
	public NLNNIDBPKAO.KDHODDMNDFC OIHEFMKLDIF(int LPFKFNLHGBI)
	{
		if (!this.GADJFFGDCFA.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.GADJFFGDCFA[LPFKFNLHGBI];
	}

	// Token: 0x060046D4 RID: 18132 RVA: 0x00216F64 File Offset: 0x00215164
	public string IKEEJCNNFOL(int LPFKFNLHGBI)
	{
		return this.KHCBCNJIKFE[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x060046D5 RID: 18133 RVA: 0x00216F78 File Offset: 0x00215178
	public void OLDMKILEBHO()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("PistolInstant", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.GADJFFGDCFA.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes(" dataid=");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = new NLNNIDBPKAO.KDHODDMNDFC(xmlNode);
				kdhoddmndfc.POKJFJBHDOJ = true;
				this.GADJFFGDCFA.Add(kdhoddmndfc.LPFKFNLHGBI, kdhoddmndfc);
				foreach (object obj2 in xmlNode.SelectNodes("' that does not excist in the Node Chain."))
				{
					NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc2 = new NLNNIDBPKAO.KDHODDMNDFC((XmlNode)obj2);
					kdhoddmndfc2.POKJFJBHDOJ = true;
					kdhoddmndfc2.IHBEJDJINAI = kdhoddmndfc.LPFKFNLHGBI;
					kdhoddmndfc.BFBFHEGGOKL.Add(kdhoddmndfc2);
					this.GADJFFGDCFA.Add(kdhoddmndfc2.LPFKFNLHGBI, kdhoddmndfc2);
				}
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.LPHMKPDBMPP().DDKLHGHBEIG("BowIdle", false));
		xmlNodeList = xmlDocument.SelectNodes("isFishGet");
		foreach (object obj3 in xmlNodeList)
		{
			XmlNode xmlNode2 = (XmlNode)obj3;
			try
			{
				int key = int.Parse(xmlNode2.Attributes["ok"].Value);
				if (this.GADJFFGDCFA.ContainsKey(key))
				{
					this.GADJFFGDCFA[key].HPKKPKAJCME(xmlNode2);
				}
			}
			catch (Exception message)
			{
				Debug.LogError(message);
			}
		}
		Debug.Log("inv_rl");
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x060046D6 RID: 18134 RVA: 0x00216F64 File Offset: 0x00215164
	public string OAEDHGGKPBB(int LPFKFNLHGBI)
	{
		return this.KHCBCNJIKFE[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x060046D7 RID: 18135 RVA: 0x00216F64 File Offset: 0x00215164
	public string PLBALPPOEJF(int LPFKFNLHGBI)
	{
		return this.KHCBCNJIKFE[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x060046D8 RID: 18136 RVA: 0x00216F64 File Offset: 0x00215164
	public string BEBJCJONLBC(int LPFKFNLHGBI)
	{
		return this.KHCBCNJIKFE[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x060046D9 RID: 18137 RVA: 0x00216D30 File Offset: 0x00214F30
	public NLNNIDBPKAO.KDHODDMNDFC DIBICKBIKOI(int LPFKFNLHGBI)
	{
		if (!this.GADJFFGDCFA.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.GADJFFGDCFA[LPFKFNLHGBI];
	}

	// Token: 0x060046DA RID: 18138 RVA: 0x00216D30 File Offset: 0x00214F30
	public NLNNIDBPKAO.KDHODDMNDFC BEAODBGBIKC(int LPFKFNLHGBI)
	{
		if (!this.GADJFFGDCFA.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.GADJFFGDCFA[LPFKFNLHGBI];
	}

	// Token: 0x060046DB RID: 18139 RVA: 0x00216F64 File Offset: 0x00215164
	public string MFFFGEEEACA(int LPFKFNLHGBI)
	{
		return this.KHCBCNJIKFE[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x060046DC RID: 18140 RVA: 0x00216D30 File Offset: 0x00214F30
	public NLNNIDBPKAO.KDHODDMNDFC EHBODADDPLM(int LPFKFNLHGBI)
	{
		if (!this.GADJFFGDCFA.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.GADJFFGDCFA[LPFKFNLHGBI];
	}

	// Token: 0x060046DD RID: 18141 RVA: 0x0021718C File Offset: 0x0021538C
	public void NDDPHGNHDEL()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("FlyForward", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.GADJFFGDCFA.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("wpn_dress2");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = new NLNNIDBPKAO.KDHODDMNDFC(xmlNode);
				kdhoddmndfc.POKJFJBHDOJ = false;
				this.GADJFFGDCFA.Add(kdhoddmndfc.LPFKFNLHGBI, kdhoddmndfc);
				foreach (object obj2 in xmlNode.SelectNodes("CP0"))
				{
					NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc2 = new NLNNIDBPKAO.KDHODDMNDFC((XmlNode)obj2);
					kdhoddmndfc2.POKJFJBHDOJ = false;
					kdhoddmndfc2.IHBEJDJINAI = kdhoddmndfc.LPFKFNLHGBI;
					kdhoddmndfc.BFBFHEGGOKL.Add(kdhoddmndfc2);
					this.GADJFFGDCFA.Add(kdhoddmndfc2.LPFKFNLHGBI, kdhoddmndfc2);
				}
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.DBMJJPBOPEK().BGOJCAABLNC("adjust", false));
		xmlNodeList = xmlDocument.SelectNodes("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.");
		foreach (object obj3 in xmlNodeList)
		{
			XmlNode xmlNode2 = (XmlNode)obj3;
			try
			{
				int key = int.Parse(xmlNode2.Attributes["SUNSHINE_FILTER_PCF_3x3"].Value);
				if (this.GADJFFGDCFA.ContainsKey(key))
				{
					this.GADJFFGDCFA[key].KJCMLMPDJCD(xmlNode2);
				}
			}
			catch (Exception message)
			{
				Debug.LogError(message);
			}
		}
		Debug.Log("linebreak.ogg");
		this.LGFJMPLCGJM = false;
	}

	// Token: 0x060046DE RID: 18142 RVA: 0x00216D30 File Offset: 0x00214F30
	public NLNNIDBPKAO.KDHODDMNDFC DIJBEPJDOLJ(int LPFKFNLHGBI)
	{
		if (!this.GADJFFGDCFA.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.GADJFFGDCFA[LPFKFNLHGBI];
	}

	// Token: 0x060046DF RID: 18143 RVA: 0x00216F64 File Offset: 0x00215164
	public string GLOFLBPOLDI(int LPFKFNLHGBI)
	{
		return this.KHCBCNJIKFE[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x060046E0 RID: 18144 RVA: 0x00216F64 File Offset: 0x00215164
	public string DMCNMGDPHHB(int LPFKFNLHGBI)
	{
		return this.KHCBCNJIKFE[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x060046E1 RID: 18145 RVA: 0x00216D30 File Offset: 0x00214F30
	public NLNNIDBPKAO.KDHODDMNDFC PKDGNOPNDMD(int LPFKFNLHGBI)
	{
		if (!this.GADJFFGDCFA.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.GADJFFGDCFA[LPFKFNLHGBI];
	}

	// Token: 0x060046E2 RID: 18146 RVA: 0x002173A0 File Offset: 0x002155A0
	public void IHAKLNJOAJE()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Detects cheating of any Obscured type (except ObscuredPrefs, it has own detection features) used in project.", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.GADJFFGDCFA.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("offsets");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = new NLNNIDBPKAO.KDHODDMNDFC(xmlNode);
				kdhoddmndfc.POKJFJBHDOJ = false;
				this.GADJFFGDCFA.Add(kdhoddmndfc.LPFKFNLHGBI, kdhoddmndfc);
				foreach (object obj2 in xmlNode.SelectNodes("inv_bonus"))
				{
					NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc2 = new NLNNIDBPKAO.KDHODDMNDFC((XmlNode)obj2);
					kdhoddmndfc2.POKJFJBHDOJ = false;
					kdhoddmndfc2.IHBEJDJINAI = kdhoddmndfc.LPFKFNLHGBI;
					kdhoddmndfc.BFBFHEGGOKL.Add(kdhoddmndfc2);
					this.GADJFFGDCFA.Add(kdhoddmndfc2.LPFKFNLHGBI, kdhoddmndfc2);
				}
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.APMJBBDBOJO().BGOJCAABLNC("Full Body IK is missing the left upper arm node.", true));
		xmlNodeList = xmlDocument.SelectNodes("msgCancel");
		foreach (object obj3 in xmlNodeList)
		{
			XmlNode xmlNode2 = (XmlNode)obj3;
			try
			{
				int key = int.Parse(xmlNode2.Attributes["Hidden/Amplify Color/BlendCache"].Value);
				if (this.GADJFFGDCFA.ContainsKey(key))
				{
					this.GADJFFGDCFA[key].HPKKPKAJCME(xmlNode2);
				}
			}
			catch (Exception message)
			{
				Debug.LogError(message);
			}
		}
		Debug.Log("cht_tofrend");
		this.LGFJMPLCGJM = false;
	}

	// Token: 0x060046E4 RID: 18148 RVA: 0x002175C0 File Offset: 0x002157C0
	public void IFJFGNEENGL()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("OneHandSwordSwing", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.GADJFFGDCFA.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("1HandSwordStrafeLeft");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = new NLNNIDBPKAO.KDHODDMNDFC(xmlNode);
				kdhoddmndfc.POKJFJBHDOJ = false;
				this.GADJFFGDCFA.Add(kdhoddmndfc.LPFKFNLHGBI, kdhoddmndfc);
				foreach (object obj2 in xmlNode.SelectNodes("OneHandSwordBlock"))
				{
					NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc2 = new NLNNIDBPKAO.KDHODDMNDFC((XmlNode)obj2);
					kdhoddmndfc2.POKJFJBHDOJ = false;
					kdhoddmndfc2.IHBEJDJINAI = kdhoddmndfc.LPFKFNLHGBI;
					kdhoddmndfc.BFBFHEGGOKL.Add(kdhoddmndfc2);
					this.GADJFFGDCFA.Add(kdhoddmndfc2.LPFKFNLHGBI, kdhoddmndfc2);
				}
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.LPHMKPDBMPP().JPEDCGHDNPN("RHandPunch", true));
		xmlNodeList = xmlDocument.SelectNodes("LMB to shoot the Dummy, RMB to rotate the camera.");
		foreach (object obj3 in xmlNodeList)
		{
			XmlNode xmlNode2 = (XmlNode)obj3;
			try
			{
				int key = int.Parse(xmlNode2.Attributes["cntx_rem"].Value);
				if (this.GADJFFGDCFA.ContainsKey(key))
				{
					this.GADJFFGDCFA[key].HPKKPKAJCME(xmlNode2);
				}
			}
			catch (Exception message)
			{
				Debug.LogError(message);
			}
		}
		Debug.Log("wpn_add/base");
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x060046E5 RID: 18149 RVA: 0x00216F64 File Offset: 0x00215164
	public string JHPMKGEFNOH(int LPFKFNLHGBI)
	{
		return this.KHCBCNJIKFE[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x060046E6 RID: 18150 RVA: 0x00216F64 File Offset: 0x00215164
	public string EGPANCJLDFJ(int LPFKFNLHGBI)
	{
		return this.KHCBCNJIKFE[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x060046E7 RID: 18151 RVA: 0x00216F64 File Offset: 0x00215164
	public string ONFLKNECFLL(int LPFKFNLHGBI)
	{
		return this.KHCBCNJIKFE[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x060046E8 RID: 18152 RVA: 0x00216F64 File Offset: 0x00215164
	public string KBLLOPLOEAJ(int LPFKFNLHGBI)
	{
		return this.KHCBCNJIKFE[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x060046E9 RID: 18153 RVA: 0x00216F64 File Offset: 0x00215164
	public string EPHFPEPIBGC(int LPFKFNLHGBI)
	{
		return this.KHCBCNJIKFE[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x060046EA RID: 18154 RVA: 0x00216F64 File Offset: 0x00215164
	public string CGBFMIGPPAM(int LPFKFNLHGBI)
	{
		return this.KHCBCNJIKFE[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x060046EB RID: 18155 RVA: 0x002177D4 File Offset: 0x002159D4
	public void ODONNAANIEP()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Perks", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.GADJFFGDCFA.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("perks/rperk");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = new NLNNIDBPKAO.KDHODDMNDFC(xmlNode);
				kdhoddmndfc.POKJFJBHDOJ = true;
				this.GADJFFGDCFA.Add(kdhoddmndfc.LPFKFNLHGBI, kdhoddmndfc);
				foreach (object obj2 in xmlNode.SelectNodes("perk"))
				{
					NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc2 = new NLNNIDBPKAO.KDHODDMNDFC((XmlNode)obj2);
					kdhoddmndfc2.POKJFJBHDOJ = false;
					kdhoddmndfc2.IHBEJDJINAI = kdhoddmndfc.LPFKFNLHGBI;
					kdhoddmndfc.BFBFHEGGOKL.Add(kdhoddmndfc2);
					this.GADJFFGDCFA.Add(kdhoddmndfc2.LPFKFNLHGBI, kdhoddmndfc2);
				}
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.IKGFHGKKCPG.CHFGNHKJNFG("Perks.xml", false));
		xmlNodeList = xmlDocument.SelectNodes("perks/perk");
		foreach (object obj3 in xmlNodeList)
		{
			XmlNode xmlNode2 = (XmlNode)obj3;
			try
			{
				int key = int.Parse(xmlNode2.Attributes["id"].Value);
				if (this.GADJFFGDCFA.ContainsKey(key))
				{
					this.GADJFFGDCFA[key].KJCMLMPDJCD(xmlNode2);
				}
			}
			catch (Exception message)
			{
				Debug.LogError(message);
			}
		}
		Debug.Log("*** Perks is init");
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x060046EC RID: 18156 RVA: 0x00216F64 File Offset: 0x00215164
	public string MPLCPPDMDIE(int LPFKFNLHGBI)
	{
		return this.KHCBCNJIKFE[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x060046ED RID: 18157 RVA: 0x00216F64 File Offset: 0x00215164
	public string GHJHNACAFPH(int LPFKFNLHGBI)
	{
		return this.KHCBCNJIKFE[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x060046EE RID: 18158 RVA: 0x00216F64 File Offset: 0x00215164
	public string KPFDOFCBADJ(int LPFKFNLHGBI)
	{
		return this.KHCBCNJIKFE[LPFKFNLHGBI].BNIHFBMEPAB;
	}

	// Token: 0x060046EF RID: 18159 RVA: 0x002179E8 File Offset: 0x00215BE8
	public void CKMJNHBNCEI()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Wall Run Left", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.GADJFFGDCFA.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("dropMass");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = new NLNNIDBPKAO.KDHODDMNDFC(xmlNode);
				kdhoddmndfc.POKJFJBHDOJ = false;
				this.GADJFFGDCFA.Add(kdhoddmndfc.LPFKFNLHGBI, kdhoddmndfc);
				foreach (object obj2 in xmlNode.SelectNodes("SUNSHINE_FOUR_CASCADES"))
				{
					NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc2 = new NLNNIDBPKAO.KDHODDMNDFC((XmlNode)obj2);
					kdhoddmndfc2.POKJFJBHDOJ = false;
					kdhoddmndfc2.IHBEJDJINAI = kdhoddmndfc.LPFKFNLHGBI;
					kdhoddmndfc.BFBFHEGGOKL.Add(kdhoddmndfc2);
					this.GADJFFGDCFA.Add(kdhoddmndfc2.LPFKFNLHGBI, kdhoddmndfc2);
				}
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.IKGFHGKKCPG.DOJJAFNAHKF(" cannot be used as a 3D LUT.", true));
		xmlNodeList = xmlDocument.SelectNodes("demoUint");
		foreach (object obj3 in xmlNodeList)
		{
			XmlNode xmlNode2 = (XmlNode)obj3;
			try
			{
				int key = int.Parse(xmlNode2.Attributes[" iterations for read and write"].Value);
				if (this.GADJFFGDCFA.ContainsKey(key))
				{
					this.GADJFFGDCFA[key].AAOPDCCCNFK(xmlNode2);
				}
			}
			catch (Exception message)
			{
				Debug.LogError(message);
			}
		}
		Debug.Log("S");
		this.LGFJMPLCGJM = false;
	}

	// Token: 0x060046F0 RID: 18160 RVA: 0x00217BFC File Offset: 0x00215DFC
	public void NKPIKHPNDAN()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.GADJFFGDCFA.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("Shake Hands");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = new NLNNIDBPKAO.KDHODDMNDFC(xmlNode);
				kdhoddmndfc.POKJFJBHDOJ = true;
				this.GADJFFGDCFA.Add(kdhoddmndfc.LPFKFNLHGBI, kdhoddmndfc);
				foreach (object obj2 in xmlNode.SelectNodes("<color='#ff0000'>Вы сломали удочку</color>"))
				{
					NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc2 = new NLNNIDBPKAO.KDHODDMNDFC((XmlNode)obj2);
					kdhoddmndfc2.POKJFJBHDOJ = false;
					kdhoddmndfc2.IHBEJDJINAI = kdhoddmndfc.LPFKFNLHGBI;
					kdhoddmndfc.BFBFHEGGOKL.Add(kdhoddmndfc2);
					this.GADJFFGDCFA.Add(kdhoddmndfc2.LPFKFNLHGBI, kdhoddmndfc2);
				}
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.APMJBBDBOJO().GHPNJJIMCKF("_NoiseTilingPerChannel", false));
		xmlNodeList = xmlDocument.SelectNodes("");
		foreach (object obj3 in xmlNodeList)
		{
			XmlNode xmlNode2 = (XmlNode)obj3;
			try
			{
				int key = int.Parse(xmlNode2.Attributes["Water Refr Camera id"].Value);
				if (this.GADJFFGDCFA.ContainsKey(key))
				{
					this.GADJFFGDCFA[key].HPKKPKAJCME(xmlNode2);
				}
			}
			catch (Exception message)
			{
				Debug.LogError(message);
			}
		}
		Debug.Log("Sewing");
		this.LGFJMPLCGJM = false;
	}

	// Token: 0x060046F1 RID: 18161 RVA: 0x00217E10 File Offset: 0x00216010
	public void JEOPOICACFK()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("Flap_04.wav", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		this.GADJFFGDCFA.Clear();
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("_Refraction");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc = new NLNNIDBPKAO.KDHODDMNDFC(xmlNode);
				kdhoddmndfc.POKJFJBHDOJ = true;
				this.GADJFFGDCFA.Add(kdhoddmndfc.LPFKFNLHGBI, kdhoddmndfc);
				foreach (object obj2 in xmlNode.SelectNodes("fshop_hd4"))
				{
					NLNNIDBPKAO.KDHODDMNDFC kdhoddmndfc2 = new NLNNIDBPKAO.KDHODDMNDFC((XmlNode)obj2);
					kdhoddmndfc2.POKJFJBHDOJ = true;
					kdhoddmndfc2.IHBEJDJINAI = kdhoddmndfc.LPFKFNLHGBI;
					kdhoddmndfc.BFBFHEGGOKL.Add(kdhoddmndfc2);
					this.GADJFFGDCFA.Add(kdhoddmndfc2.LPFKFNLHGBI, kdhoddmndfc2);
				}
			}
		}
		xmlDocument.LoadXml(JNBICAJIJMM.DBMJJPBOPEK().IDFHKHHNDEK("cht_ach1", true));
		xmlNodeList = xmlDocument.SelectNodes("Hip");
		foreach (object obj3 in xmlNodeList)
		{
			XmlNode xmlNode2 = (XmlNode)obj3;
			try
			{
				int key = int.Parse(xmlNode2.Attributes["_FilteredReflections"].Value);
				if (this.GADJFFGDCFA.ContainsKey(key))
				{
					this.GADJFFGDCFA[key].AAOPDCCCNFK(xmlNode2);
				}
			}
			catch (Exception message)
			{
				Debug.LogError(message);
			}
		}
		Debug.Log("_ZTest");
		this.LGFJMPLCGJM = false;
	}

	// Token: 0x060046F2 RID: 18162 RVA: 0x00216D30 File Offset: 0x00214F30
	public NLNNIDBPKAO.KDHODDMNDFC PGAMAJNPFFE(int LPFKFNLHGBI)
	{
		if (!this.GADJFFGDCFA.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.GADJFFGDCFA[LPFKFNLHGBI];
	}

	// Token: 0x060046F3 RID: 18163 RVA: 0x00216D30 File Offset: 0x00214F30
	public NLNNIDBPKAO.KDHODDMNDFC BOGLJIPFCLI(int LPFKFNLHGBI)
	{
		if (!this.GADJFFGDCFA.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.GADJFFGDCFA[LPFKFNLHGBI];
	}

	// Token: 0x060046F4 RID: 18164 RVA: 0x00216D30 File Offset: 0x00214F30
	public NLNNIDBPKAO.KDHODDMNDFC JEFCOLDKFPI(int LPFKFNLHGBI)
	{
		if (!this.GADJFFGDCFA.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.GADJFFGDCFA[LPFKFNLHGBI];
	}

	// Token: 0x060046F6 RID: 18166 RVA: 0x00216D30 File Offset: 0x00214F30
	public NLNNIDBPKAO.KDHODDMNDFC PKJMLDMLFCM(int LPFKFNLHGBI)
	{
		if (!this.GADJFFGDCFA.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.GADJFFGDCFA[LPFKFNLHGBI];
	}

	// Token: 0x060046F7 RID: 18167 RVA: 0x00216D30 File Offset: 0x00214F30
	public NLNNIDBPKAO.KDHODDMNDFC KOHGDDAADCP(int LPFKFNLHGBI)
	{
		if (!this.GADJFFGDCFA.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.GADJFFGDCFA[LPFKFNLHGBI];
	}

	// Token: 0x04000B21 RID: 2849
	public static NLNNIDBPKAO IKGFHGKKCPG = new NLNNIDBPKAO();

	// Token: 0x04000B22 RID: 2850
	public Dictionary<int, NLNNIDBPKAO.KDHODDMNDFC> GADJFFGDCFA = new Dictionary<int, NLNNIDBPKAO.KDHODDMNDFC>();

	// Token: 0x04000B23 RID: 2851
	public Dictionary<int, NLNNIDBPKAO.FEBMOGBHGCO> KHCBCNJIKFE = new Dictionary<int, NLNNIDBPKAO.FEBMOGBHGCO>();

	// Token: 0x04000B24 RID: 2852
	public List<NLNNIDBPKAO.EAMIKNFOBON> DCGIFKJNMFH = new List<NLNNIDBPKAO.EAMIKNFOBON>();

	// Token: 0x04000B25 RID: 2853
	private bool LGFJMPLCGJM;

	// Token: 0x0200014F RID: 335
	public class FEBMOGBHGCO
	{
		// Token: 0x060046F8 RID: 18168 RVA: 0x00218050 File Offset: 0x00216250
		public FEBMOGBHGCO(XmlNode JEEEOEBNJDJ)
		{
			if (JEEEOEBNJDJ.Attributes == null)
			{
				return;
			}
			this.LPFKFNLHGBI = int.Parse(JEEEOEBNJDJ.Attributes["id"].Value);
			this.BNIHFBMEPAB = JEEEOEBNJDJ.Attributes["name"].Value;
			this.IGNOCJJBMFN = (int.Parse(JEEEOEBNJDJ.Attributes["enable"].Value) > 0);
			this.AHJLANKIJLM = int.Parse(JEEEOEBNJDJ.Attributes["reqperk"].Value);
		}

		// Token: 0x04000B26 RID: 2854
		public int LPFKFNLHGBI;

		// Token: 0x04000B27 RID: 2855
		public string BNIHFBMEPAB;

		// Token: 0x04000B28 RID: 2856
		public bool IGNOCJJBMFN;

		// Token: 0x04000B29 RID: 2857
		public int AHJLANKIJLM = -1;
	}

	// Token: 0x02000150 RID: 336
	public class EAMIKNFOBON
	{
		// Token: 0x060046F9 RID: 18169 RVA: 0x002180F4 File Offset: 0x002162F4
		public EAMIKNFOBON(XmlNode JEEEOEBNJDJ)
		{
			if (JEEEOEBNJDJ.Attributes == null)
			{
				return;
			}
			this.GBMLOGHHLBG = int.Parse(JEEEOEBNJDJ.Attributes["hp"].Value);
			this.CKOECIAKCJD = int.Parse(JEEEOEBNJDJ.Attributes["vp"].Value);
			this.CLBPBJGLHEE = int.Parse(JEEEOEBNJDJ.Attributes["index"].Value);
			this.AMBHGDJLEHK = int.Parse(JEEEOEBNJDJ.Attributes["dir"].Value);
		}

		// Token: 0x04000B2A RID: 2858
		public int CLBPBJGLHEE;

		// Token: 0x04000B2B RID: 2859
		public int GBMLOGHHLBG;

		// Token: 0x04000B2C RID: 2860
		public int CKOECIAKCJD;

		// Token: 0x04000B2D RID: 2861
		public int AMBHGDJLEHK;
	}

	// Token: 0x02000151 RID: 337
	public class KDHODDMNDFC
	{
		// Token: 0x060046FA RID: 18170 RVA: 0x00218190 File Offset: 0x00216390
		public string DDFCFOHNHNN(int PFKPFBKEFFB = 0)
		{
			return this.KKEBDLGHBMN + "The 'BackColor' command requires a color parameter of RRGGBBAA or '?'." + PFKPFBKEFFB;
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x002181A8 File Offset: 0x002163A8
		public void KHDEGOLNLOK(XmlNode JEEEOEBNJDJ)
		{
			this.KKEBDLGHBMN = JEEEOEBNJDJ.Attributes["drink.wav"].Value + "Packet processor error cmd: ";
			this.PAALJNAKJEG = JEEEOEBNJDJ.Attributes["SoccerKeeperStrafeLeft"].Value;
		}

		// Token: 0x060046FC RID: 18172 RVA: 0x002181F8 File Offset: 0x002163F8
		public Texture IJGBOMGCLDK()
		{
			if (this.AJFCDFFJLHG == null)
			{
				if (this.POKJFJBHDOJ)
				{
					CKNLPGEPGGF cknlpgepggf = CKNLPGEPGGF.PFOLNEGNIPP();
					object[] array = new object[6];
					array[0] = IFPIMPMKJIB.LIOPCJFCGAF();
					array[0] = " x";
					array[3] = this.LPFKFNLHGBI;
					array[2] = "lifeBar";
					this.AJFCDFFJLHG = cknlpgepggf.EKHFCNKNHEJ(string.Concat(array), true);
				}
				else
				{
					this.AJFCDFFJLHG = new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.PerkIcon, "H" + this.LPFKFNLHGBI);
				}
			}
			return this.AJFCDFFJLHG.DPBCBCLJHAJ();
		}

		// Token: 0x060046FD RID: 18173 RVA: 0x00218290 File Offset: 0x00216490
		public void AAOPDCCCNFK(XmlNode JEEEOEBNJDJ)
		{
			this.KKEBDLGHBMN = JEEEOEBNJDJ.Attributes["FishOnRod"].Value + "Low adminlevel!";
			this.PAALJNAKJEG = JEEEOEBNJDJ.Attributes["OneHandSwordRun"].Value;
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x002182DD File Offset: 0x002164DD
		public string OBOKLCHDOGM(int PFKPFBKEFFB = 0)
		{
			return this.KKEBDLGHBMN + "fishdrop_1" + PFKPFBKEFFB;
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x002182F5 File Offset: 0x002164F5
		public int HIPNFPODHKK(int CNOLCNDBLJE, NEBJANKNJOG EEPNACDOOBF)
		{
			return (int)(this.OEAJOHJLFIN.JLLJFKOGLHJ + this.OEAJOHJLFIN.LOIBCMBMLEC() * (this.OEAJOHJLFIN.GHEGIJFKEON() + (float)CNOLCNDBLJE));
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x0021831E File Offset: 0x0021651E
		public string FLFHIHINAFL(int PFKPFBKEFFB = 0)
		{
			return this.KKEBDLGHBMN + "BowInstant" + PFKPFBKEFFB;
		}

		// Token: 0x06004701 RID: 18177 RVA: 0x00218336 File Offset: 0x00216536
		public int CLJNLLAAEIN(int CNOLCNDBLJE, NEBJANKNJOG EEPNACDOOBF)
		{
			return (int)(this.OEAJOHJLFIN.CLAEAFMCDMP() + this.OEAJOHJLFIN.LOIBCMBMLEC() * (this.OEAJOHJLFIN.KGKNPAAMDJK + (float)CNOLCNDBLJE));
		}

		// Token: 0x06004702 RID: 18178 RVA: 0x00218360 File Offset: 0x00216560
		public Texture AJGPNAPFCAG()
		{
			if (this.AJFCDFFJLHG == null)
			{
				if (this.POKJFJBHDOJ)
				{
					CKNLPGEPGGF cknlpgepggf = CKNLPGEPGGF.PFOLNEGNIPP();
					object[] array = new object[5];
					array[0] = IFPIMPMKJIB.ENLHJOJICDG();
					array[0] = "gi_uinf_4";
					array[6] = this.LPFKFNLHGBI;
					array[8] = "_BlurVector";
					this.AJFCDFFJLHG = cknlpgepggf.EKHFCNKNHEJ(string.Concat(array), false);
				}
				else
				{
					this.AJFCDFFJLHG = new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.PerkIcon, "IdleStrafeLeft" + this.LPFKFNLHGBI);
				}
			}
			return this.AJFCDFFJLHG.DPBCBCLJHAJ();
		}

		// Token: 0x06004703 RID: 18179 RVA: 0x002183F8 File Offset: 0x002165F8
		public Texture OBIJKHKCPEO()
		{
			if (this.AJFCDFFJLHG == null)
			{
				if (this.POKJFJBHDOJ)
				{
					CKNLPGEPGGF cknlpgepggf = CKNLPGEPGGF.IKGFHGKKCPG;
					object[] array = new object[0];
					array[1] = IFPIMPMKJIB.AFJFDKAGKLD();
					array[0] = "";
					array[0] = this.LPFKFNLHGBI;
					array[7] = "______________________________";
					this.AJFCDFFJLHG = cknlpgepggf.PFNEPENHMOE(string.Concat(array), true);
				}
				else
				{
					this.AJFCDFFJLHG = new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.PerkIcon, "App QUIT" + this.LPFKFNLHGBI);
				}
			}
			return this.AJFCDFFJLHG.EJOLKDKEKCG();
		}

		// Token: 0x06004704 RID: 18180 RVA: 0x00218490 File Offset: 0x00216690
		public Texture GNMLEPEGCII()
		{
			if (this.AJFCDFFJLHG == null)
			{
				if (this.POKJFJBHDOJ)
				{
					CKNLPGEPGGF cknlpgepggf = CKNLPGEPGGF.PFOLNEGNIPP();
					object[] array = new object[6];
					array[0] = IFPIMPMKJIB.DIDFMAELMJD;
					array[1] = "; ";
					array[3] = this.LPFKFNLHGBI;
					array[4] = "1HandSmallWeaponCombo";
					this.AJFCDFFJLHG = cknlpgepggf.IJMDNINDJGD(string.Concat(array), false);
				}
				else
				{
					this.AJFCDFFJLHG = new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.PerkIcon, "OfficeSitting" + this.LPFKFNLHGBI);
				}
			}
			return this.AJFCDFFJLHG.KEDGAOBCNJG;
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x00218526 File Offset: 0x00216726
		public string JBGNCBFEBKD(int PFKPFBKEFFB = 0)
		{
			return this.KKEBDLGHBMN + "WizardBlock" + PFKPFBKEFFB;
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x00218540 File Offset: 0x00216740
		public Texture MLBFCJFLPBG()
		{
			if (this.AJFCDFFJLHG == null)
			{
				if (this.POKJFJBHDOJ)
				{
					CKNLPGEPGGF cknlpgepggf = CKNLPGEPGGF.PFOLNEGNIPP();
					object[] array = new object[3];
					array[0] = IFPIMPMKJIB.EEAKGGDJAGB();
					array[0] = "Forward";
					array[3] = this.LPFKFNLHGBI;
					array[6] = "modelid";
					this.AJFCDFFJLHG = cknlpgepggf.IJMDNINDJGD(string.Concat(array), true);
				}
				else
				{
					this.AJFCDFFJLHG = new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.PerkIcon, "FlyRight" + this.LPFKFNLHGBI);
				}
			}
			return this.AJFCDFFJLHG.HONJOFFBOPH();
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x002185D6 File Offset: 0x002167D6
		public int IDHBKPFHALB(int CNOLCNDBLJE, NEBJANKNJOG EEPNACDOOBF)
		{
			return (int)(this.OEAJOHJLFIN.JLLJFKOGLHJ + this.OEAJOHJLFIN.OBEOJCGHOGL * (this.OEAJOHJLFIN.KGKNPAAMDJK + (float)CNOLCNDBLJE));
		}

		// Token: 0x06004708 RID: 18184 RVA: 0x00218600 File Offset: 0x00216800
		public KDHODDMNDFC(XmlNode JEEEOEBNJDJ)
		{
			if (JEEEOEBNJDJ.Attributes != null)
			{
				this.LPFKFNLHGBI = int.Parse(JEEEOEBNJDJ.Attributes["id"].Value);
				this.DCCPCBLODIG = new IIBEEKCAAHK(JEEEOEBNJDJ.Attributes["val"].Value);
				this.OEAJOHJLFIN = new IIBEEKCAAHK(JEEEOEBNJDJ.Attributes["tech"].Value);
			}
		}

		// Token: 0x06004709 RID: 18185 RVA: 0x00218686 File Offset: 0x00216886
		public string KGBHELBLPMF(int PFKPFBKEFFB = 0)
		{
			return this.KKEBDLGHBMN + "- " + PFKPFBKEFFB;
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x002186A0 File Offset: 0x002168A0
		public Texture OHJIDDDKOAA()
		{
			if (this.AJFCDFFJLHG == null)
			{
				if (this.POKJFJBHDOJ)
				{
					CKNLPGEPGGF cknlpgepggf = CKNLPGEPGGF.PFOLNEGNIPP();
					object[] array = new object[7];
					array[0] = IFPIMPMKJIB.BKKFFINMJBO();
					array[0] = "<color=\"";
					array[4] = this.LPFKFNLHGBI;
					array[5] = "WeaponInstant";
					this.AJFCDFFJLHG = cknlpgepggf.PFNEPENHMOE(string.Concat(array), false);
				}
				else
				{
					this.AJFCDFFJLHG = new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.PerkIcon, "_" + this.LPFKFNLHGBI);
				}
			}
			return this.AJFCDFFJLHG.EIMNFFAAHLI();
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x00218738 File Offset: 0x00216938
		public Texture KMIIGKECOEB()
		{
			if (this.AJFCDFFJLHG == null)
			{
				if (this.POKJFJBHDOJ)
				{
					this.AJFCDFFJLHG = CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(string.Concat(new object[]
					{
						IFPIMPMKJIB.DIDFMAELMJD,
						"Textures/Perks/",
						this.LPFKFNLHGBI,
						".png"
					}), false);
				}
				else
				{
					this.AJFCDFFJLHG = new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.PerkIcon, "perk_" + this.LPFKFNLHGBI);
				}
			}
			return this.AJFCDFFJLHG.KEDGAOBCNJG;
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x002187CE File Offset: 0x002169CE
		public string PNLGIAIKAOL(int PFKPFBKEFFB = 0)
		{
			return this.KKEBDLGHBMN + "BowInstant2" + PFKPFBKEFFB;
		}

		// Token: 0x0600470D RID: 18189 RVA: 0x002187E6 File Offset: 0x002169E6
		public string FFAFKPDHOIN(int PFKPFBKEFFB = 0)
		{
			return this.KKEBDLGHBMN + "gi_um_9" + PFKPFBKEFFB;
		}

		// Token: 0x0600470E RID: 18190 RVA: 0x00218800 File Offset: 0x00216A00
		public void KJCMLMPDJCD(XmlNode JEEEOEBNJDJ)
		{
			this.KKEBDLGHBMN = JEEEOEBNJDJ.Attributes["name"].Value + " ";
			this.PAALJNAKJEG = JEEEOEBNJDJ.Attributes["info"].Value;
		}

		// Token: 0x0600470F RID: 18191 RVA: 0x0021884D File Offset: 0x00216A4D
		public string IIEACLAECEI(int PFKPFBKEFFB = 0)
		{
			return this.KKEBDLGHBMN + "sys" + PFKPFBKEFFB;
		}

		// Token: 0x06004710 RID: 18192 RVA: 0x00218868 File Offset: 0x00216A68
		public Texture CIBLMLGGANE()
		{
			if (this.AJFCDFFJLHG == null)
			{
				if (this.POKJFJBHDOJ)
				{
					CKNLPGEPGGF cknlpgepggf = CKNLPGEPGGF.PFOLNEGNIPP();
					object[] array = new object[3];
					array[0] = IFPIMPMKJIB.ENLHJOJICDG();
					array[1] = "Sunshine Cascade Camera {0}";
					array[0] = this.LPFKFNLHGBI;
					array[4] = "SoccerKeeperDiveStrafeFarRight";
					this.AJFCDFFJLHG = cknlpgepggf.PFNEPENHMOE(string.Concat(array), false);
				}
				else
				{
					this.AJFCDFFJLHG = new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.PerkIcon, "_threshold" + this.LPFKFNLHGBI);
				}
			}
			return this.AJFCDFFJLHG.EIMNFFAAHLI();
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x002188FE File Offset: 0x00216AFE
		public int IIGJKPHEOIO(int CNOLCNDBLJE, NEBJANKNJOG EEPNACDOOBF)
		{
			return (int)(this.OEAJOHJLFIN.CLAEAFMCDMP() + this.OEAJOHJLFIN.OAAKPMLGJJH() * (this.OEAJOHJLFIN.EPPEFJDDOHN() + (float)CNOLCNDBLJE));
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x00218928 File Offset: 0x00216B28
		public Texture FHPNJBAEAON()
		{
			if (this.AJFCDFFJLHG == null)
			{
				if (this.POKJFJBHDOJ)
				{
					CKNLPGEPGGF cknlpgepggf = CKNLPGEPGGF.IKGFHGKKCPG;
					object[] array = new object[4];
					array[1] = IFPIMPMKJIB.EEAKGGDJAGB();
					array[1] = "KatanaReadyHigh";
					array[7] = this.LPFKFNLHGBI;
					array[0] = "Null";
					this.AJFCDFFJLHG = cknlpgepggf.PFNEPENHMOE(string.Concat(array), false);
				}
				else
				{
					this.AJFCDFFJLHG = new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.PerkIcon, " " + this.LPFKFNLHGBI);
				}
			}
			return this.AJFCDFFJLHG.MMKLLFCKCAG();
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x002189C0 File Offset: 0x00216BC0
		public Texture LANMGLMKPNA()
		{
			if (this.AJFCDFFJLHG == null)
			{
				if (this.POKJFJBHDOJ)
				{
					CKNLPGEPGGF cknlpgepggf = CKNLPGEPGGF.PFOLNEGNIPP();
					object[] array = new object[5];
					array[0] = IFPIMPMKJIB.BKKFFINMJBO();
					array[0] = "\n";
					array[4] = this.LPFKFNLHGBI;
					array[2] = "_Threshhold";
					this.AJFCDFFJLHG = cknlpgepggf.PFNEPENHMOE(string.Concat(array), true);
				}
				else
				{
					this.AJFCDFFJLHG = new CKNLPGEPGGF.IAPCJOBDCEH(GameInterface.getI.PerkIcon, "USE_PREDICATION" + this.LPFKFNLHGBI);
				}
			}
			return this.AJFCDFFJLHG.HONJOFFBOPH();
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x00218A58 File Offset: 0x00216C58
		public void HPKKPKAJCME(XmlNode JEEEOEBNJDJ)
		{
			this.KKEBDLGHBMN = JEEEOEBNJDJ.Attributes["killPodsek"].Value + "Item ";
			this.PAALJNAKJEG = JEEEOEBNJDJ.Attributes["WeaponReadyFire"].Value;
		}

		// Token: 0x04000B2E RID: 2862
		public bool POKJFJBHDOJ;

		// Token: 0x04000B2F RID: 2863
		public int IHBEJDJINAI;

		// Token: 0x04000B30 RID: 2864
		public int LPFKFNLHGBI;

		// Token: 0x04000B31 RID: 2865
		public List<NLNNIDBPKAO.KDHODDMNDFC> BFBFHEGGOKL = new List<NLNNIDBPKAO.KDHODDMNDFC>();

		// Token: 0x04000B32 RID: 2866
		public IIBEEKCAAHK DCCPCBLODIG;

		// Token: 0x04000B33 RID: 2867
		public IIBEEKCAAHK OEAJOHJLFIN;

		// Token: 0x04000B34 RID: 2868
		public string PAALJNAKJEG;

		// Token: 0x04000B35 RID: 2869
		public string KKEBDLGHBMN;

		// Token: 0x04000B36 RID: 2870
		public CKNLPGEPGGF.IAPCJOBDCEH AJFCDFFJLHG;
	}

	// Token: 0x02000152 RID: 338
	public class DLMGLIJDIAI
	{
		// Token: 0x06004715 RID: 18197 RVA: 0x00218AA8 File Offset: 0x00216CA8
		public DLMGLIJDIAI(XmlNode JEEEOEBNJDJ)
		{
			IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(JEEEOEBNJDJ.InnerText);
			this.LPFKFNLHGBI = iibeekcaahk.IBEIBAHKIAH;
			this.CNOLCNDBLJE = iibeekcaahk.ICJDPPOJINN;
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.LPFKFNLHGBI);
		}

		// Token: 0x04000B37 RID: 2871
		public int LPFKFNLHGBI;

		// Token: 0x04000B38 RID: 2872
		public int CNOLCNDBLJE;

		// Token: 0x04000B39 RID: 2873
		public NLNNIDBPKAO.KDHODDMNDFC BDHHPAEHFHG;
	}

	// Token: 0x02000153 RID: 339
	public class JENMPDPJKBG : ItemBase
	{
		// Token: 0x06004716 RID: 18198 RVA: 0x00218AF8 File Offset: 0x00216CF8
		public virtual string IPDCPCECFBC()
		{
			string arg = "StrafeRunRight" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "CrouchStrafeRight" + this.DLGCNLKFOKN;
			}
			return string.Format("BowInstant", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x00218B60 File Offset: 0x00216D60
		public override void GKDJCJKMBEN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 0f;
			if (this.EJJAGEFMHCO() != null)
			{
				Texture texture = this.EJJAGEFMHCO().KEDGAOBCNJG;
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 0.8f;
				float num4 = (float)texture.height * num2 * 0.8f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 8f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 2f - 4f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 5f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(0.2f, 0.2f, 0.2f);
			}
			if (this.JAGMEPMLCCP == 5)
			{
				black = new Color(0.2f, 0.1f, 0f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("{0}+{1}={2}", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = 14;
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 8f + num, num5, COAGIAMOCIA.width - 15f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + " " + str, OFPNEDEAMAB);
			num5 += 18f;
			OFPNEDEAMAB.fontSize = 10;
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 5)
			{
				num6 = 5;
			}
			text = text.Replace("{x}", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num6));
			text = text.Replace("{y}", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("{z}", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NKGGAFLBFDF * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 8f + num, num5, COAGIAMOCIA.width - 15f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 12f;
			if (this.JAGMEPMLCCP < 5 && this.ODBICLOCIMO)
			{
				GameInterface.getI.renderPBar(new Rect(COAGIAMOCIA.x + 8f + num, num5, COAGIAMOCIA.width - 140f, 10f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 4, "", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 8f + num, num5, COAGIAMOCIA.width - 15f, 24f), JNBICAJIJMM.LEBHCLDODNI("prk_max"), OFPNEDEAMAB);
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x00218EA4 File Offset: 0x002170A4
		public virtual void JEIHFPODKIN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 854f;
			if (this.EJJAGEFMHCO() != null)
			{
				Texture texture = this.GKPOPMAAGIJ().EIMNFFAAHLI();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1754f;
				float num4 = (float)texture.height * num2 * 1166f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 725f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 1451f - 1581f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 880f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(1351f, 65f, 391f);
			}
			if (this.JAGMEPMLCCP == 7)
			{
				black = new Color(1471f, 206f, 77f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("IKMappingSpine is missing the right thigh bone.", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = -75;
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 147f + num, num5, COAGIAMOCIA.width - 407f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "inv_pcs2" + str, OFPNEDEAMAB);
			num5 += 1903f;
			OFPNEDEAMAB.fontSize = 37;
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 0;
			if (num6 > 7)
			{
				num6 = 6;
			}
			text = text.Replace("ShotgunReloadChamber", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.DHJBAKDAMGH() * (double)num6));
			text = text.Replace("_ChromaticAberration_Spectrum", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("TOD_MoonCloudColor", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.HDPNCIECLKP() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 209f + num, num5, COAGIAMOCIA.width - 1335f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1203f;
			if (this.JAGMEPMLCCP < 1 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 695f + num, num5, COAGIAMOCIA.width - 487f, 1973f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 1, "OfficeSitting1LegStraight", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1177f + num, num5, COAGIAMOCIA.width - 825f, 564f), JNBICAJIJMM.NGALDMFKMJH("****softSpawn from "), OFPNEDEAMAB);
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x002191E8 File Offset: 0x002173E8
		public void OPBFPNHFFID(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.OMCMPDMJFOJ();
			this.JAGMEPMLCCP = KADBECGIMPD.HDBGOLAFOBK();
			this.DLGCNLKFOKN = KADBECGIMPD.HHLDBAEFNMJ();
			this.KLPANBANBDI = KADBECGIMPD.DNGDPHIHLBG();
			this.GNNDLEAFCND = KADBECGIMPD.DOJKJHMJJNK();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.PGAMAJNPFFE(this.LPFKFNLHGBI);
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x00219247 File Offset: 0x00217447
		public virtual CKNLPGEPGGF.IAPCJOBDCEH BFHNHJEJFMM()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.CIBLMLGGANE();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x00219278 File Offset: 0x00217478
		public void NJACMNGHPMF(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.BLNIHNKJJPJ();
			this.JAGMEPMLCCP = KADBECGIMPD.HDBGOLAFOBK();
			this.DLGCNLKFOKN = KADBECGIMPD.AGNKAFLKCAG();
			this.KLPANBANBDI = KADBECGIMPD.AILCEJFAMGN();
			this.GNNDLEAFCND = KADBECGIMPD.DOJKJHMJJNK();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.PGAMAJNPFFE(this.LPFKFNLHGBI);
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x002192D7 File Offset: 0x002174D7
		public override CKNLPGEPGGF.IAPCJOBDCEH JGBOJNELADG()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.FHPNJBAEAON();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x00219308 File Offset: 0x00217508
		public virtual string JODMFMFAOEG()
		{
			string arg = "invn_ver4" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "_Intensity" + this.DLGCNLKFOKN;
			}
			return string.Format("rait_1", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x0600471E RID: 18206 RVA: 0x00219370 File Offset: 0x00217570
		public void ICNCPGCDACO(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.DADCGPGEHFK();
			this.JAGMEPMLCCP = KADBECGIMPD.KDNDJNEGBDI();
			this.DLGCNLKFOKN = KADBECGIMPD.IFDFHJLCHAE();
			this.KLPANBANBDI = KADBECGIMPD.DNGDPHIHLBG();
			this.GNNDLEAFCND = KADBECGIMPD.KKOKFLMMAAK();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.BEAODBGBIKC(this.LPFKFNLHGBI);
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x002193D0 File Offset: 0x002175D0
		public virtual string GAOJCHIOICI()
		{
			string arg = "WalkDehydrated" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "AntaresController" + this.DLGCNLKFOKN;
			}
			return string.Format("' that does not excist in the Node Chain.", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004720 RID: 18208 RVA: 0x00219438 File Offset: 0x00217638
		public virtual CKNLPGEPGGF.IAPCJOBDCEH CNKLIGGOKJB()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.IJGBOMGCLDK();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x06004721 RID: 18209 RVA: 0x00219468 File Offset: 0x00217668
		public virtual string DHCBHNAAJKI()
		{
			string arg = "Hidden/Amplify Color/Blend" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "LUX_LINEAR" + this.DLGCNLKFOKN;
			}
			return string.Format("</color>\n", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004722 RID: 18210 RVA: 0x002194D0 File Offset: 0x002176D0
		public virtual void FGPIIDOFGDN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 206f;
			if (this.HEFAGFMDAEE() != null)
			{
				Texture texture = this.BHPAALLBMHL().KEDGAOBCNJG;
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 310f;
				float num4 = (float)texture.height * num2 * 29f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 646f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 375f - 1452f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 1992f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(1796f, 1577f, 952f);
			}
			if (this.JAGMEPMLCCP == 5)
			{
				black = new Color(1963f, 1618f, 1901f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("<color='#003000'>{0}</color>", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			OFPNEDEAMAB.fontSize = -14;
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 1180f + num, num5, COAGIAMOCIA.width - 881f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "repair.ogg" + str, OFPNEDEAMAB);
			num5 += 999f;
			OFPNEDEAMAB.fontSize = 26;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 6)
			{
				num6 = 3;
			}
			text = text.Replace("RussianDance", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.DHJBAKDAMGH() * (double)num6));
			text = text.Replace("\">Foreign saves detected: ", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("IdleWalk", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.DBFOHFDOCIB() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 654f + num, num5, COAGIAMOCIA.width - 1258f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 150f;
			if (this.JAGMEPMLCCP < 8 && this.ODBICLOCIMO)
			{
				GameInterface.getI.renderPBar(new Rect(COAGIAMOCIA.x + 182f + num, num5, COAGIAMOCIA.width - 1156f, 1095f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 3, "", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1508f + num, num5, COAGIAMOCIA.width - 179f, 1306f), JNBICAJIJMM.NGALDMFKMJH("_OcclusionTexture"), OFPNEDEAMAB);
		}

		// Token: 0x06004723 RID: 18211 RVA: 0x00219814 File Offset: 0x00217A14
		public void DMEIDCMMBBH(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.LAECLJFMGPE();
			this.JAGMEPMLCCP = KADBECGIMPD.AGNKAFLKCAG();
			this.DLGCNLKFOKN = KADBECGIMPD.KDNDJNEGBDI();
			this.KLPANBANBDI = KADBECGIMPD.DNGDPHIHLBG();
			this.GNNDLEAFCND = KADBECGIMPD.KKOKFLMMAAK();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.BEAODBGBIKC(this.LPFKFNLHGBI);
		}

		// Token: 0x06004724 RID: 18212 RVA: 0x00219874 File Offset: 0x00217A74
		public void MMFCCCJFMAM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.FIFNOBGEKFF();
			this.JAGMEPMLCCP = KADBECGIMPD.AGNKAFLKCAG();
			this.DLGCNLKFOKN = KADBECGIMPD.LDLKLPJBIJN();
			this.KLPANBANBDI = KADBECGIMPD.DNGDPHIHLBG();
			this.GNNDLEAFCND = KADBECGIMPD.IFDFHJLCHAE();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.PKDGNOPNDMD(this.LPFKFNLHGBI);
		}

		// Token: 0x06004725 RID: 18213 RVA: 0x002198D4 File Offset: 0x00217AD4
		public virtual string AHFDMABJGOL()
		{
			string arg = "aptek.ogg" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "ArmFlex4" + this.DLGCNLKFOKN;
			}
			return string.Format(" ms", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004726 RID: 18214 RVA: 0x0021993C File Offset: 0x00217B3C
		public virtual string JHHDLHJEEEB()
		{
			string arg = "" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "Downsamp" + this.DLGCNLKFOKN;
			}
			return string.Format("PaperTurn.wav", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x002199A4 File Offset: 0x00217BA4
		public void LHLCHNLBBNP(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.LAECLJFMGPE();
			this.JAGMEPMLCCP = KADBECGIMPD.KKOKFLMMAAK();
			this.DLGCNLKFOKN = KADBECGIMPD.LDLKLPJBIJN();
			this.KLPANBANBDI = KADBECGIMPD.CNNEPCOAMJK();
			this.GNNDLEAFCND = KADBECGIMPD.HDBGOLAFOBK();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.PGAMAJNPFFE(this.LPFKFNLHGBI);
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x00219A04 File Offset: 0x00217C04
		public virtual string CBPDHBKDMGC()
		{
			string arg = "linebreak.ogg" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "LookUp" + this.DLGCNLKFOKN;
			}
			return string.Format("Idle Drink", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004729 RID: 18217 RVA: 0x00219A6C File Offset: 0x00217C6C
		public virtual CKNLPGEPGGF.IAPCJOBDCEH CFNEGDGGOOG()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.OHJIDDDKOAA();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x0600472A RID: 18218 RVA: 0x00219A9C File Offset: 0x00217C9C
		public void CKEMHEKOFEM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.ELDBJFLCMAJ();
			this.JAGMEPMLCCP = KADBECGIMPD.IFDFHJLCHAE();
			this.DLGCNLKFOKN = KADBECGIMPD.IFDFHJLCHAE();
			this.KLPANBANBDI = KADBECGIMPD.MOBPFEEAMKD();
			this.GNNDLEAFCND = KADBECGIMPD.CLPEKGGAMAI();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.LPFKFNLHGBI);
		}

		// Token: 0x0600472B RID: 18219 RVA: 0x00219AFC File Offset: 0x00217CFC
		public virtual void IDDEBGDPJEI(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 752f;
			if (this.PPJOPGPEFGI() != null)
			{
				Texture texture = this.PPJOPGPEFGI().NIOGJOFLPLH();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 454f;
				float num4 = (float)texture.height * num2 * 1484f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1146f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 290f - 1527f, num3, num4), texture, ScaleMode.ScaleAndCrop);
				num = num + num3 + 195f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(496f, 732f, 1043f);
			}
			if (this.JAGMEPMLCCP == 1)
			{
				black = new Color(718f, 1225f, 235f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("template", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = -22;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 1111f + num, num5, COAGIAMOCIA.width - 933f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "camouflage_scale" + str, OFPNEDEAMAB);
			num5 += 1057f;
			OFPNEDEAMAB.fontSize = 115;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 0;
			if (num6 > 5)
			{
				num6 = 5;
			}
			text = text.Replace("RandomizeObscuredVars", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num6));
			text = text.Replace("_FogNoiseData", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("Roller Blade Stop", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.FJACMDGJEBL() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1980f + num, num5, COAGIAMOCIA.width - 1745f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1191f;
			if (this.JAGMEPMLCCP < 6 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 675f + num, num5, COAGIAMOCIA.width - 77f, 1553f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 6, "wpn_eat7", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1266f + num, num5, COAGIAMOCIA.width - 212f, 891f), JNBICAJIJMM.DIOJFJMOPJO("SoccerKeeperReady"), OFPNEDEAMAB);
		}

		// Token: 0x0600472C RID: 18220 RVA: 0x00219E40 File Offset: 0x00218040
		public virtual void LPNPLPPKDKL(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1993f;
			if (this.HFAGADCJACL() != null)
			{
				Texture texture = this.HFAGADCJACL().IOHNCGLFGDJ();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1335f;
				float num4 = (float)texture.height * num2 * 1494f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1235f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 1541f - 1051f, num3, num4), texture, ScaleMode.ScaleAndCrop);
				num = num + num3 + 931f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(190f, 517f, 1652f);
			}
			if (this.JAGMEPMLCCP == 5)
			{
				black = new Color(835f, 1633f, 396f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("none", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = -47;
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 609f + num, num5, COAGIAMOCIA.width - 1638f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "JumpLeg" + str, OFPNEDEAMAB);
			num5 += 1241f;
			OFPNEDEAMAB.fontSize = 27;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 0;
			if (num6 > 5)
			{
				num6 = 3;
			}
			text = text.Replace("LocationGui.getI is null", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.AIMCFAHLPEF() * (double)num6));
			text = text.Replace("_Intensity", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.KCKFCPIHMPC() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 339f + num, num5, COAGIAMOCIA.width - 456f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1964f;
			if (this.JAGMEPMLCCP < 1 && this.ODBICLOCIMO)
			{
				GameInterface.getI.renderPBar(new Rect(COAGIAMOCIA.x + 551f + num, num5, COAGIAMOCIA.width - 1212f, 819f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 8, "", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1375f + num, num5, COAGIAMOCIA.width - 919f, 66f), JNBICAJIJMM.LEBHCLDODNI("BowInstant2"), OFPNEDEAMAB);
		}

		// Token: 0x0600472D RID: 18221 RVA: 0x0021A184 File Offset: 0x00218384
		public virtual void JJNFMHPMMBF(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 300f;
			if (this.PBEMPJOBKKI() != null)
			{
				Texture texture = this.HEFAGFMDAEE().MLPBJEFJDHM();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1963f;
				float num4 = (float)texture.height * num2 * 13f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 981f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 1307f - 1752f, num3, num4), texture, ScaleMode.ScaleAndCrop);
				num = num + num3 + 619f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(141f, 1761f, 363f);
			}
			if (this.JAGMEPMLCCP == 1)
			{
				black = new Color(1654f, 1337f, 1961f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("_Tile2RT", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = 47;
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 174f + num, num5, COAGIAMOCIA.width - 1392f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "KatanaNinjaDraw" + str, OFPNEDEAMAB);
			num5 += 1347f;
			OFPNEDEAMAB.fontSize = -28;
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 0;
			if (num6 > 6)
			{
				num6 = 6;
			}
			text = text.Replace("_info", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.AIMCFAHLPEF() * (double)num6));
			text = text.Replace("ScubaSwim", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("Turn", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.FJACMDGJEBL() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 960f + num, num5, COAGIAMOCIA.width - 880f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1298f;
			if (this.JAGMEPMLCCP < 6 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 444f + num, num5, COAGIAMOCIA.width - 1870f, 499f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 4, "Worker Pickaxe 2", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1773f + num, num5, COAGIAMOCIA.width - 737f, 990f), JNBICAJIJMM.CDDCIKKDFMP("http://steamcommunity.com/sharedfiles/filedetails/?id=788064774"), OFPNEDEAMAB);
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x0021A4C8 File Offset: 0x002186C8
		public virtual void MHONLKBHHMH(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1693f;
			if (this.MFKHIBOFIFI() != null)
			{
				Texture texture = this.PPJOPGPEFGI().PFFJJEJNKPB();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 667f;
				float num4 = (float)texture.height * num2 * 274f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 593f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 1288f - 700f, num3, num4), texture, ScaleMode.ScaleAndCrop);
				num = num + num3 + 1376f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(863f, 1304f, 819f);
			}
			if (this.JAGMEPMLCCP == 3)
			{
				black = new Color(1491f, 1086f, 345f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("OfficeSitting45DegLeg", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			OFPNEDEAMAB.fontSize = -95;
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 494f + num, num5, COAGIAMOCIA.width - 1105f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "Textures/Noise3" + str, OFPNEDEAMAB);
			num5 += 1597f;
			OFPNEDEAMAB.fontSize = 68;
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 0;
			if (num6 > 8)
			{
				num6 = 6;
			}
			text = text.Replace("How your health bar is stored in memory when obscured:\n", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num6));
			text = text.Replace("IKMappingSpine is missing the right upper arm bone.", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("_Offsets", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NKGGAFLBFDF * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1961f + num, num5, COAGIAMOCIA.width - 881f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 38f;
			if (this.JAGMEPMLCCP < 3 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 691f + num, num5, COAGIAMOCIA.width - 1540f, 52f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 5, "Giant3HitCombo", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1606f + num, num5, COAGIAMOCIA.width - 1639f, 1802f), JNBICAJIJMM.NGALDMFKMJH("crft_cnt"), OFPNEDEAMAB);
		}

		// Token: 0x0600472F RID: 18223 RVA: 0x0021A80C File Offset: 0x00218A0C
		public void OAEKBDCGNNM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.ELDBJFLCMAJ();
			this.JAGMEPMLCCP = KADBECGIMPD.KKOKFLMMAAK();
			this.DLGCNLKFOKN = KADBECGIMPD.CLPEKGGAMAI();
			this.KLPANBANBDI = KADBECGIMPD.BNDHIBEOKML();
			this.GNNDLEAFCND = KADBECGIMPD.CLPEKGGAMAI();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.PGAMAJNPFFE(this.LPFKFNLHGBI);
		}

		// Token: 0x06004730 RID: 18224 RVA: 0x0021A86C File Offset: 0x00218A6C
		public void PIGMKNFEHGH(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.IOEEPNCKLJD();
			this.JAGMEPMLCCP = KADBECGIMPD.AGNKAFLKCAG();
			this.DLGCNLKFOKN = KADBECGIMPD.HDBGOLAFOBK();
			this.KLPANBANBDI = KADBECGIMPD.AIDAGFNHNHE();
			this.GNNDLEAFCND = KADBECGIMPD.DOJKJHMJJNK();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.DIBICKBIKOI(this.LPFKFNLHGBI);
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x0021A8CC File Offset: 0x00218ACC
		public void AFBHCINPPCG(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.BLNIHNKJJPJ();
			this.JAGMEPMLCCP = KADBECGIMPD.AGNKAFLKCAG();
			this.DLGCNLKFOKN = KADBECGIMPD.HHLDBAEFNMJ();
			this.KLPANBANBDI = KADBECGIMPD.MOBPFEEAMKD();
			this.GNNDLEAFCND = KADBECGIMPD.IFDFHJLCHAE();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.PGAMAJNPFFE(this.LPFKFNLHGBI);
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x0021A92B File Offset: 0x00218B2B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HCFIMEHPBMH()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.OBIJKHKCPEO();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x0021A95C File Offset: 0x00218B5C
		public virtual void HJCODOHGIKH(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1416f;
			if (this.ENCJNMNEANC() != null)
			{
				Texture texture = this.HEFAGFMDAEE().KEDGAOBCNJG;
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 546f;
				float num4 = (float)texture.height * num2 * 336f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 957f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 840f - 550f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 901f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(504f, 1036f, 411f);
			}
			if (this.JAGMEPMLCCP == 2)
			{
				black = new Color(1876f, 1079f, 733f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("wpn_hook1", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			OFPNEDEAMAB.fontSize = -92;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 878f + num, num5, COAGIAMOCIA.width - 1884f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "Steam Overlay has been closed" + str, OFPNEDEAMAB);
			num5 += 898f;
			OFPNEDEAMAB.fontSize = -14;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 0)
			{
				num6 = 5;
			}
			text = text.Replace("Backward Sitting", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num6));
			text = text.Replace("---------- NetManager is init", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("SoccerSprint", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NKGGAFLBFDF * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1866f + num, num5, COAGIAMOCIA.width - 426f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 772f;
			if (this.JAGMEPMLCCP < 4 && this.ODBICLOCIMO)
			{
				GameInterface.getI.renderPBar(new Rect(COAGIAMOCIA.x + 635f + num, num5, COAGIAMOCIA.width - 1867f, 39f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 7, "FlyRight", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1278f + num, num5, COAGIAMOCIA.width - 744f, 1094f), JNBICAJIJMM.PGJCPFNJNPM("2000"), OFPNEDEAMAB);
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x0021ACA0 File Offset: 0x00218EA0
		public virtual void KCOFDBDGNAB(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1455f;
			if (this.PBHPIGPDCJA() != null)
			{
				Texture texture = this.EJJAGEFMHCO().EJOLKDKEKCG();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 910f;
				float num4 = (float)texture.height * num2 * 1313f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1174f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 1551f - 1723f, num3, num4), texture, ScaleMode.ScaleAndCrop);
				num = num + num3 + 1453f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(612f, 41f, 1627f);
			}
			if (this.JAGMEPMLCCP == 5)
			{
				black = new Color(1068f, 1085f, 1346f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("usr_inf_a1", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			OFPNEDEAMAB.fontSize = -77;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 1150f + num, num5, COAGIAMOCIA.width - 942f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "Error via final request" + str, OFPNEDEAMAB);
			num5 += 1317f;
			OFPNEDEAMAB.fontSize = -58;
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 1)
			{
				num6 = 3;
			}
			text = text.Replace("left", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.DHJBAKDAMGH() * (double)num6));
			text = text.Replace("error.wav", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("_EMISSION", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.FJACMDGJEBL() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1181f + num, num5, COAGIAMOCIA.width - 194f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 767f;
			if (this.JAGMEPMLCCP < 4 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 711f + num, num5, COAGIAMOCIA.width - 8f, 777f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 6, "reel_type", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1385f + num, num5, COAGIAMOCIA.width - 1438f, 1624f), JNBICAJIJMM.BDKHMOOFHHK("wpn_add/base"), OFPNEDEAMAB);
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x0021AFE4 File Offset: 0x002191E4
		public virtual void KMAJAKPJLBI(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 106f;
			if (this.MFKHIBOFIFI() != null)
			{
				Texture texture = this.PPJOPGPEFGI().ANLLGCICOPP();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 305f;
				float num4 = (float)texture.height * num2 * 1793f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 164f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 1940f - 1057f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 1817f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(573f, 1906f, 1874f);
			}
			if (this.JAGMEPMLCCP == 1)
			{
				black = new Color(1801f, 972f, 162f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("3", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = 66;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 1620f + num, num5, COAGIAMOCIA.width - 85f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "WorkerHammer" + str, OFPNEDEAMAB);
			num5 += 1553f;
			OFPNEDEAMAB.fontSize = 5;
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 0;
			if (num6 > 8)
			{
				num6 = 3;
			}
			text = text.Replace("offsets", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.DHJBAKDAMGH() * (double)num6));
			text = text.Replace("move", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("IceHockeyGoalieSave1", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.KCKFCPIHMPC() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 594f + num, num5, COAGIAMOCIA.width - 27f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 656f;
			if (this.JAGMEPMLCCP < 0 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 983f + num, num5, COAGIAMOCIA.width - 1474f, 119f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 5, "SoccerWalk", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 318f + num, num5, COAGIAMOCIA.width - 978f, 1038f), JNBICAJIJMM.PPNKMDJBMLP("BlurDepthTollerance"), OFPNEDEAMAB);
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x0021B325 File Offset: 0x00219525
		public virtual CKNLPGEPGGF.IAPCJOBDCEH OALNEFBDIMB()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.GNMLEPEGCII();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x0021B358 File Offset: 0x00219558
		public virtual void DJCOPKOPMPC(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 348f;
			if (this.BHPAALLBMHL() != null)
			{
				Texture texture = this.ENCJNMNEANC().HONJOFFBOPH();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1046f;
				float num4 = (float)texture.height * num2 * 1695f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 549f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 1034f - 1945f, num3, num4), texture, ScaleMode.ScaleAndCrop);
				num = num + num3 + 1615f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(259f, 35f, 515f);
			}
			if (this.JAGMEPMLCCP == 4)
			{
				black = new Color(1851f, 1028f, 42f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("_FlowMap", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = 52;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 1448f + num, num5, COAGIAMOCIA.width - 1463f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "_NeutralTonemapperParams1" + str, OFPNEDEAMAB);
			num5 += 720f;
			OFPNEDEAMAB.fontSize = 113;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 0;
			if (num6 > 6)
			{
				num6 = 7;
			}
			text = text.Replace("Assets/Weapons/baseJaket.unity3d", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num6));
			text = text.Replace(" from ", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("Error receptID=", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.FJACMDGJEBL() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1108f + num, num5, COAGIAMOCIA.width - 1092f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1078f;
			if (this.JAGMEPMLCCP < 7 && this.ODBICLOCIMO)
			{
				GameInterface.getI.renderPBar(new Rect(COAGIAMOCIA.x + 1304f + num, num5, COAGIAMOCIA.width - 1034f, 1629f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 1, "bag", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 804f + num, num5, COAGIAMOCIA.width - 281f, 1650f), JNBICAJIJMM.BDKHMOOFHHK("gameComplete"), OFPNEDEAMAB);
		}

		// Token: 0x06004738 RID: 18232 RVA: 0x0021B69C File Offset: 0x0021989C
		public virtual string DIACBNHNDCJ()
		{
			string arg = "_Texture" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "" + this.DLGCNLKFOKN;
			}
			return string.Format("Soccer Walk", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x0021B325 File Offset: 0x00219525
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DGILLFBNNGD()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.GNMLEPEGCII();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x0600473A RID: 18234 RVA: 0x0021B704 File Offset: 0x00219904
		public void GIFMPLIKNDN(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.OMCMPDMJFOJ();
			this.JAGMEPMLCCP = KADBECGIMPD.KKOKFLMMAAK();
			this.DLGCNLKFOKN = KADBECGIMPD.LDLKLPJBIJN();
			this.KLPANBANBDI = KADBECGIMPD.AILCEJFAMGN();
			this.GNNDLEAFCND = KADBECGIMPD.CLPEKGGAMAI();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.OIHEFMKLDIF(this.LPFKFNLHGBI);
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x0021B764 File Offset: 0x00219964
		public void INPLCDOKDGO(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.ELDBJFLCMAJ();
			this.JAGMEPMLCCP = KADBECGIMPD.KKOKFLMMAAK();
			this.DLGCNLKFOKN = KADBECGIMPD.IFDFHJLCHAE();
			this.KLPANBANBDI = KADBECGIMPD.DNGDPHIHLBG();
			this.GNNDLEAFCND = KADBECGIMPD.DOJKJHMJJNK();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.KOHGDDAADCP(this.LPFKFNLHGBI);
		}

		// Token: 0x0600473C RID: 18236 RVA: 0x0021B7C4 File Offset: 0x002199C4
		public virtual string IIBPDPDEBNA()
		{
			string arg = "shop_t19" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "" + this.DLGCNLKFOKN;
			}
			return string.Format(" ", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x0021B82C File Offset: 0x00219A2C
		public virtual void EOBHOIJFJOM(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 585f;
			if (this.ENCJNMNEANC() != null)
			{
				Texture texture = this.HHOBCJNGCEL().KEDGAOBCNJG;
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 771f;
				float num4 = (float)texture.height * num2 * 554f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 587f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 951f - 463f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 996f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(1942f, 1190f, 718f);
			}
			if (this.JAGMEPMLCCP == 1)
			{
				black = new Color(1141f, 730f, 1187f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("{0}Textures/Turnirs/{1}.png", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = 92;
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 104f + num, num5, COAGIAMOCIA.width - 1502f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "ObscuredByte:" + str, OFPNEDEAMAB);
			num5 += 238f;
			OFPNEDEAMAB.fontSize = -4;
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 1)
			{
				num6 = 4;
			}
			text = text.Replace("LHandPunch", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.AIMCFAHLPEF() * (double)num6));
			text = text.Replace("", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("\n", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.KCKFCPIHMPC() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1856f + num, num5, COAGIAMOCIA.width - 855f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1165f;
			if (this.JAGMEPMLCCP < 5 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 372f + num, num5, COAGIAMOCIA.width - 750f, 431f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 7, "Wand/Staff", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1509f + num, num5, COAGIAMOCIA.width - 1475f, 1305f), JNBICAJIJMM.CDDCIKKDFMP("SoccerKeeperReady"), OFPNEDEAMAB);
		}

		// Token: 0x0600473E RID: 18238 RVA: 0x0021B325 File Offset: 0x00219525
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LOHCIIFHNCE()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.GNMLEPEGCII();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x0021BB70 File Offset: 0x00219D70
		public virtual string BDINNEPKJOJ()
		{
			string arg = "repair.ogg" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "id" + this.DLGCNLKFOKN;
			}
			return string.Format("_ALPHATEST_ON", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004740 RID: 18240 RVA: 0x0021BBD8 File Offset: 0x00219DD8
		public virtual void CCOEBADOMEJ(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 97f;
			if (this.HHOBCJNGCEL() != null)
			{
				Texture texture = this.JGBOJNELADG().DPBCBCLJHAJ();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 95f;
				float num4 = (float)texture.height * num2 * 1133f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1749f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 658f - 1878f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 1525f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(1740f, 901f, 423f);
			}
			if (this.JAGMEPMLCCP == 3)
			{
				black = new Color(39f, 799f, 1546f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("WandStand", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = 96;
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 1686f + num, num5, COAGIAMOCIA.width - 888f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "0" + str, OFPNEDEAMAB);
			num5 += 1721f;
			OFPNEDEAMAB.fontSize = -80;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 0;
			if (num6 > 0)
			{
				num6 = 3;
			}
			text = text.Replace("Katana", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num6));
			text = text.Replace("str=", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("minWgtBait", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.FJACMDGJEBL() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1290f + num, num5, COAGIAMOCIA.width - 1458f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 446f;
			if (this.JAGMEPMLCCP < 6 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 844f + num, num5, COAGIAMOCIA.width - 594f, 1444f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 4, "_Offsets", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 695f + num, num5, COAGIAMOCIA.width - 949f, 113f), JNBICAJIJMM.PPNKMDJBMLP("Try Goscurry! Or better buy it!"), OFPNEDEAMAB);
		}

		// Token: 0x06004741 RID: 18241 RVA: 0x0021BF1C File Offset: 0x0021A11C
		public virtual string MOBHDMJGEEC()
		{
			string arg = "," + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "only_one" + this.DLGCNLKFOKN;
			}
			return string.Format(" x", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004742 RID: 18242 RVA: 0x0021BF84 File Offset: 0x0021A184
		public override void AGFLCAGCFBC(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1391f;
			if (this.JGBOJNELADG() != null)
			{
				Texture texture = this.HFAGADCJACL().ANLLGCICOPP();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 886f;
				float num4 = (float)texture.height * num2 * 87f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1633f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 431f - 1888f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 1930f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(1624f, 596f, 704f);
			}
			if (this.JAGMEPMLCCP == 2)
			{
				black = new Color(86f, 399f, 1616f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("heavy", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = -73;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 905f + num, num5, COAGIAMOCIA.width - 1646f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "\n" + str, OFPNEDEAMAB);
			num5 += 1451f;
			OFPNEDEAMAB.fontSize = 36;
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 6)
			{
				num6 = 7;
			}
			text = text.Replace("IdleButtonPress", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num6));
			text = text.Replace("MotorbikeSeatStand", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("Weapons", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.GJBKBEEJLDF() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 316f + num, num5, COAGIAMOCIA.width - 1512f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1409f;
			if (this.JAGMEPMLCCP < 8 && this.ODBICLOCIMO)
			{
				GameInterface.getI.renderPBar(new Rect(COAGIAMOCIA.x + 176f + num, num5, COAGIAMOCIA.width - 1025f, 513f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 8, " x", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 982f + num, num5, COAGIAMOCIA.width - 1509f, 197f), JNBICAJIJMM.BDKHMOOFHHK("RollerBladeRoll"), OFPNEDEAMAB);
		}

		// Token: 0x06004743 RID: 18243 RVA: 0x0021C2C8 File Offset: 0x0021A4C8
		public virtual void EPGNPALKOEE(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1917f;
			if (this.BHPAALLBMHL() != null)
			{
				Texture texture = this.EJJAGEFMHCO().IOMNHBMOGLG();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1033f;
				float num4 = (float)texture.height * num2 * 663f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1270f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 813f - 1985f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 421f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(1583f, 1693f, 1279f);
			}
			if (this.JAGMEPMLCCP == 1)
			{
				black = new Color(48f, 643f, 1372f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("bs_nomoney", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			OFPNEDEAMAB.fontSize = 124;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 175f + num, num5, COAGIAMOCIA.width - 1318f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "crft_wpnpr" + str, OFPNEDEAMAB);
			num5 += 300f;
			OFPNEDEAMAB.fontSize = 98;
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 6)
			{
				num6 = 7;
			}
			text = text.Replace("cht_msg37", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.DHJBAKDAMGH() * (double)num6));
			text = text.Replace("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("FS", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.DBFOHFDOCIB() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1933f + num, num5, COAGIAMOCIA.width - 1739f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 121f;
			if (this.JAGMEPMLCCP < 2 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 634f + num, num5, COAGIAMOCIA.width - 582f, 1942f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 5, "ZombieWalk", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1728f + num, num5, COAGIAMOCIA.width - 1863f, 1160f), JNBICAJIJMM.CELEPPAEKAB("move"), OFPNEDEAMAB);
		}

		// Token: 0x06004744 RID: 18244 RVA: 0x0021C60C File Offset: 0x0021A80C
		public virtual void GGFNOOJBHLM(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 666f;
			if (this.PPJOPGPEFGI() != null)
			{
				Texture texture = this.MFKHIBOFIFI().EIMNFFAAHLI();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 377f;
				float num4 = (float)texture.height * num2 * 398f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1710f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 1551f - 1222f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 54f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(1134f, 981f, 340f);
			}
			if (this.JAGMEPMLCCP == 7)
			{
				black = new Color(1263f, 1120f, 1860f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format(" point=", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = 19;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 1332f + num, num5, COAGIAMOCIA.width - 1650f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "demoColor" + str, OFPNEDEAMAB);
			num5 += 1158f;
			OFPNEDEAMAB.fontSize = 122;
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 0)
			{
				num6 = 6;
			}
			text = text.Replace("Climb to the top of the mountain to see the clouds (WASD keys to move).", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.DHJBAKDAMGH() * (double)num6));
			text = text.Replace("auc_toauk", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("BlackSmithForge", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.HDPNCIECLKP() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 447f + num, num5, COAGIAMOCIA.width - 1455f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 59f;
			if (this.JAGMEPMLCCP < 7 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 1890f + num, num5, COAGIAMOCIA.width - 876f, 1032f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 5, "_UserLutParams", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1866f + num, num5, COAGIAMOCIA.width - 1048f, 1684f), JNBICAJIJMM.DIOJFJMOPJO("no_change"), OFPNEDEAMAB);
		}

		// Token: 0x06004745 RID: 18245 RVA: 0x0021C950 File Offset: 0x0021AB50
		public void MFENIEFBGFM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.JNOKJCDAPPA();
			this.JAGMEPMLCCP = KADBECGIMPD.LDLKLPJBIJN();
			this.DLGCNLKFOKN = KADBECGIMPD.IFDFHJLCHAE();
			this.KLPANBANBDI = KADBECGIMPD.AILCEJFAMGN();
			this.GNNDLEAFCND = KADBECGIMPD.DOJKJHMJJNK();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.DIBICKBIKOI(this.LPFKFNLHGBI);
		}

		// Token: 0x06004746 RID: 18246 RVA: 0x0021C9AF File Offset: 0x0021ABAF
		public virtual CKNLPGEPGGF.IAPCJOBDCEH MINPNPKJCMA()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.LANMGLMKPNA();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x0021C9E0 File Offset: 0x0021ABE0
		public void PBJFGIFFACM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.OMCMPDMJFOJ();
			this.JAGMEPMLCCP = KADBECGIMPD.IFDFHJLCHAE();
			this.DLGCNLKFOKN = KADBECGIMPD.LDLKLPJBIJN();
			this.KLPANBANBDI = KADBECGIMPD.BIMMPENHGMD();
			this.GNNDLEAFCND = KADBECGIMPD.CLPEKGGAMAI();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.DJDLJCFCPPH(this.LPFKFNLHGBI);
		}

		// Token: 0x06004748 RID: 18248 RVA: 0x0021CA3F File Offset: 0x0021AC3F
		public virtual CKNLPGEPGGF.IAPCJOBDCEH EGCPOEHHGHE()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.KMIIGKECOEB();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x0021CA6F File Offset: 0x0021AC6F
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HOFOHFJDBLN()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.AJGPNAPFCAG();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x0600474A RID: 18250 RVA: 0x0021CAA0 File Offset: 0x0021ACA0
		public void JCGOIOHJBCL(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.KJIOFDCKIKO();
			this.JAGMEPMLCCP = KADBECGIMPD.HHLDBAEFNMJ();
			this.DLGCNLKFOKN = KADBECGIMPD.AGNKAFLKCAG();
			this.KLPANBANBDI = KADBECGIMPD.FFDPCEAFGNF();
			this.GNNDLEAFCND = KADBECGIMPD.LDLKLPJBIJN();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.DJDLJCFCPPH(this.LPFKFNLHGBI);
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x0021CB00 File Offset: 0x0021AD00
		public void NLEMGHNOEOI(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.DADCGPGEHFK();
			this.JAGMEPMLCCP = KADBECGIMPD.KDNDJNEGBDI();
			this.DLGCNLKFOKN = KADBECGIMPD.CLPEKGGAMAI();
			this.KLPANBANBDI = KADBECGIMPD.AILCEJFAMGN();
			this.GNNDLEAFCND = KADBECGIMPD.CLPEKGGAMAI();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.PGAMAJNPFFE(this.LPFKFNLHGBI);
		}

		// Token: 0x0600474C RID: 18252 RVA: 0x0021CB60 File Offset: 0x0021AD60
		public void CMIMIMIDIBJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.ELDBJFLCMAJ();
			this.JAGMEPMLCCP = KADBECGIMPD.CLPEKGGAMAI();
			this.DLGCNLKFOKN = KADBECGIMPD.IFDFHJLCHAE();
			this.KLPANBANBDI = KADBECGIMPD.FFDPCEAFGNF();
			this.GNNDLEAFCND = KADBECGIMPD.IFDFHJLCHAE();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.BEAODBGBIKC(this.LPFKFNLHGBI);
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x0021CBC0 File Offset: 0x0021ADC0
		public virtual string HGANAOPCKFC()
		{
			string arg = "wpn_hook2" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "IKMappingLimb is referencing to a bone '" + this.DLGCNLKFOKN;
			}
			return string.Format("t_body", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x00219247 File Offset: 0x00217447
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LFBLJHDFPCO()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.CIBLMLGGANE();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x0021CC28 File Offset: 0x0021AE28
		public void EOBJGKCIGEA(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.DADCGPGEHFK();
			this.JAGMEPMLCCP = KADBECGIMPD.LDLKLPJBIJN();
			this.DLGCNLKFOKN = KADBECGIMPD.CLPEKGGAMAI();
			this.KLPANBANBDI = KADBECGIMPD.AIDAGFNHNHE();
			this.GNNDLEAFCND = KADBECGIMPD.IFDFHJLCHAE();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.DIBICKBIKOI(this.LPFKFNLHGBI);
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x0021CC88 File Offset: 0x0021AE88
		public virtual void FHCALPKCAJH(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 397f;
			if (this.PBHPIGPDCJA() != null)
			{
				Texture texture = this.APLAAOCGECL().AEIIBNOFLCM();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 376f;
				float num4 = (float)texture.height * num2 * 1719f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1014f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 1670f - 1892f, num3, num4), texture, ScaleMode.ScaleAndCrop);
				num = num + num3 + 1171f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(672f, 450f, 1443f);
			}
			if (this.JAGMEPMLCCP == 8)
			{
				black = new Color(1263f, 1194f, 205f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("MovementZ", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			OFPNEDEAMAB.fontSize = 51;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 209f + num, num5, COAGIAMOCIA.width - 991f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "float: " + str, OFPNEDEAMAB);
			num5 += 1352f;
			OFPNEDEAMAB.fontSize = 84;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 0;
			if (num6 > 5)
			{
				num6 = 1;
			}
			text = text.Replace("_Offsets", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.DHJBAKDAMGH() * (double)num6));
			text = text.Replace("", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("WorkerPickaxe2", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NKGGAFLBFDF * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 242f + num, num5, COAGIAMOCIA.width - 1922f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 709f;
			if (this.JAGMEPMLCCP < 7 && this.ODBICLOCIMO)
			{
				GameInterface.getI.renderPBar(new Rect(COAGIAMOCIA.x + 1885f + num, num5, COAGIAMOCIA.width - 447f, 217f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 7, "WallHack Detector", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1651f + num, num5, COAGIAMOCIA.width - 1065f, 1777f), JNBICAJIJMM.CELEPPAEKAB("{0:f2}"), OFPNEDEAMAB);
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x0021CFCC File Offset: 0x0021B1CC
		public virtual void NPGGHFKPKNN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 193f;
			if (this.PPJOPGPEFGI() != null)
			{
				Texture texture = this.HHOBCJNGCEL().IOHNCGLFGDJ();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1402f;
				float num4 = (float)texture.height * num2 * 1500f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 61f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 19f - 650f, num3, num4), texture, ScaleMode.ScaleAndCrop);
				num = num + num3 + 1325f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(1079f, 1011f, 1084f);
			}
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(733f, 1025f, 1188f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("Wand Attack", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = 98;
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 474f + num, num5, COAGIAMOCIA.width - 1980f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "_" + str, OFPNEDEAMAB);
			num5 += 1530f;
			OFPNEDEAMAB.fontSize = 17;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 0;
			if (num6 > 2)
			{
				num6 = 7;
			}
			text = text.Replace("", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.AIMCFAHLPEF() * (double)num6));
			text = text.Replace("ComeHere", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("_Refraction", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.HDPNCIECLKP() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1132f + num, num5, COAGIAMOCIA.width - 1423f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 573f;
			if (this.JAGMEPMLCCP < 2 && this.ODBICLOCIMO)
			{
				GameInterface.getI.renderPBar(new Rect(COAGIAMOCIA.x + 338f + num, num5, COAGIAMOCIA.width - 1183f, 1344f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 2, "RollerBladeTurnRight", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 843f + num, num5, COAGIAMOCIA.width - 1164f, 600f), JNBICAJIJMM.PPNKMDJBMLP("Sound #"), OFPNEDEAMAB);
		}

		// Token: 0x06004752 RID: 18258 RVA: 0x0021CA3F File Offset: 0x0021AC3F
		public override CKNLPGEPGGF.IAPCJOBDCEH EJJAGEFMHCO()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.KMIIGKECOEB();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x06004753 RID: 18259 RVA: 0x0021D310 File Offset: 0x0021B510
		public override string IGJFJGKAFIE()
		{
			string arg = "ENABLE_DITHERING" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "DoActivateTrigger" + this.DLGCNLKFOKN;
			}
			return string.Format("nowp", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x0021D378 File Offset: 0x0021B578
		public void CDPNDFCLPKL(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.DADCGPGEHFK();
			this.JAGMEPMLCCP = KADBECGIMPD.CLPEKGGAMAI();
			this.DLGCNLKFOKN = KADBECGIMPD.IFDFHJLCHAE();
			this.KLPANBANBDI = KADBECGIMPD.ECJLJGDNFMN();
			this.GNNDLEAFCND = KADBECGIMPD.DOJKJHMJJNK();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.LPFKFNLHGBI);
		}

		// Token: 0x06004755 RID: 18261 RVA: 0x0021D3D8 File Offset: 0x0021B5D8
		public virtual string OCJAOJLHOFO()
		{
			string arg = "Crouch 180" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "inv_impr" + this.DLGCNLKFOKN;
			}
			return string.Format("wpn_add/base", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004756 RID: 18262 RVA: 0x0021D440 File Offset: 0x0021B640
		public virtual void PKGEAICKGNL(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 875f;
			if (this.JGBOJNELADG() != null)
			{
				Texture texture = this.BHPAALLBMHL().ANLLGCICOPP();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1013f;
				float num4 = (float)texture.height * num2 * 402f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1935f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 155f - 909f, num3, num4), texture, ScaleMode.ScaleAndCrop);
				num = num + num3 + 1967f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(539f, 1756f, 1692f);
			}
			if (this.JAGMEPMLCCP == 4)
			{
				black = new Color(717f, 1663f, 1885f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("<color='#FF8C42'>[{2}]</color> <color='#FF8C42'>{0}: {1}</color>", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = 94;
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 697f + num, num5, COAGIAMOCIA.width - 429f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "IdleStandingJump" + str, OFPNEDEAMAB);
			num5 += 734f;
			OFPNEDEAMAB.fontSize = -93;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 3)
			{
				num6 = 8;
			}
			text = text.Replace("RunDive", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num6));
			text = text.Replace("", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("firsStartMovePanel", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NKGGAFLBFDF * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 558f + num, num5, COAGIAMOCIA.width - 1925f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 162f;
			if (this.JAGMEPMLCCP < 8 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 46f + num, num5, COAGIAMOCIA.width - 1180f, 115f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 0, "Lash", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1564f + num, num5, COAGIAMOCIA.width - 1006f, 1954f), JNBICAJIJMM.PGJCPFNJNPM("Six Step"), OFPNEDEAMAB);
		}

		// Token: 0x06004757 RID: 18263 RVA: 0x0021D784 File Offset: 0x0021B984
		public void JIHJKMKOKOE(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.IOEEPNCKLJD();
			this.JAGMEPMLCCP = KADBECGIMPD.KDNDJNEGBDI();
			this.DLGCNLKFOKN = KADBECGIMPD.AGNKAFLKCAG();
			this.KLPANBANBDI = KADBECGIMPD.CNNEPCOAMJK();
			this.GNNDLEAFCND = KADBECGIMPD.KDNDJNEGBDI();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.EHBODADDPLM(this.LPFKFNLHGBI);
		}

		// Token: 0x06004758 RID: 18264 RVA: 0x0021A92B File Offset: 0x00218B2B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DKNEPLMPHOD()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.OBIJKHKCPEO();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x06004759 RID: 18265 RVA: 0x00219438 File Offset: 0x00217638
		public virtual CKNLPGEPGGF.IAPCJOBDCEH PFKIHEHMLDB()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.IJGBOMGCLDK();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x0600475A RID: 18266 RVA: 0x0021D7E4 File Offset: 0x0021B9E4
		public virtual string MJODNMLNFJC()
		{
			string arg = "_WrinkleMask" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "Vertical" + this.DLGCNLKFOKN;
			}
			return string.Format("", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x0600475B RID: 18267 RVA: 0x0021CA3F File Offset: 0x0021AC3F
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LICCJMNJLCM()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.KMIIGKECOEB();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x0600475C RID: 18268 RVA: 0x0021D84C File Offset: 0x0021BA4C
		public override CKNLPGEPGGF.IAPCJOBDCEH MFKHIBOFIFI()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.MLBFCJFLPBG();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x0600475D RID: 18269 RVA: 0x0021D87C File Offset: 0x0021BA7C
		public virtual void KCGNEEOPIJL(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1192f;
			if (this.FMMNICCENPF() != null)
			{
				Texture texture = this.PPJOPGPEFGI().MLPBJEFJDHM();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 385f;
				float num4 = (float)texture.height * num2 * 1569f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 11f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 1129f - 106f, num3, num4), texture, ScaleMode.ScaleAndCrop);
				num = num + num3 + 1940f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(1602f, 822f, 262f);
			}
			if (this.JAGMEPMLCCP == 3)
			{
				black = new Color(1317f, 266f, 626f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("wpnend", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			OFPNEDEAMAB.fontSize = 37;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 752f + num, num5, COAGIAMOCIA.width - 1909f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "quests/" + str, OFPNEDEAMAB);
			num5 += 1102f;
			OFPNEDEAMAB.fontSize = 120;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 1)
			{
				num6 = 8;
			}
			text = text.Replace("Idle Die", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.DHJBAKDAMGH() * (double)num6));
			text = text.Replace("TOD_MoonMeshColor", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("\n", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.DBFOHFDOCIB() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1145f + num, num5, COAGIAMOCIA.width - 214f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1102f;
			if (this.JAGMEPMLCCP < 7 && this.ODBICLOCIMO)
			{
				GameInterface.getI.renderPBar(new Rect(COAGIAMOCIA.x + 965f + num, num5, COAGIAMOCIA.width - 1287f, 918f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 3, "_n", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1727f + num, num5, COAGIAMOCIA.width - 1059f, 1085f), JNBICAJIJMM.DCEBAJIILPC("[/quote]"), OFPNEDEAMAB);
		}

		// Token: 0x0600475E RID: 18270 RVA: 0x0021DBC0 File Offset: 0x0021BDC0
		public override string JGAHPHMADKC()
		{
			string arg = "CratePush" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "KneesIdle" + this.DLGCNLKFOKN;
			}
			return string.Format("OfficeSittingHandRestFingerTap", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x0600475F RID: 18271 RVA: 0x0021DC28 File Offset: 0x0021BE28
		public virtual string KGHKBMFEEDH()
		{
			string arg = "UI_UserInfoWinow" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "StartRigidModule" + this.DLGCNLKFOKN;
			}
			return string.Format("Cloth_07.wav", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004760 RID: 18272 RVA: 0x0021DC90 File Offset: 0x0021BE90
		public virtual string DGOBKBBGGKN()
		{
			string arg = "/" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "No fish in fishModelData modelid=" + this.DLGCNLKFOKN;
			}
			return string.Format("Third bone's position equals second bone's position in the biped's limb.", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004761 RID: 18273 RVA: 0x0021DCF8 File Offset: 0x0021BEF8
		public virtual void ODCJPHBLBBC(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1015f;
			if (this.JGBOJNELADG() != null)
			{
				Texture texture = this.APLAAOCGECL().MLPBJEFJDHM();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1925f;
				float num4 = (float)texture.height * num2 * 1508f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 424f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 984f - 1649f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 1700f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(1859f, 1858f, 687f);
			}
			if (this.JAGMEPMLCCP == 6)
			{
				black = new Color(280f, 1982f, 1372f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("KatanaReadyHigh", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = 123;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 966f + num, num5, COAGIAMOCIA.width - 953f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "" + str, OFPNEDEAMAB);
			num5 += 602f;
			OFPNEDEAMAB.fontSize = -94;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 0;
			if (num6 > 2)
			{
				num6 = 5;
			}
			text = text.Replace("\\", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.AIMCFAHLPEF() * (double)num6));
			text = text.Replace("wpn_eat8", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("_ClipToWorld", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.GJBKBEEJLDF() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 467f + num, num5, COAGIAMOCIA.width - 1609f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1339f;
			if (this.JAGMEPMLCCP < 3 && this.ODBICLOCIMO)
			{
				GameInterface.getI.renderPBar(new Rect(COAGIAMOCIA.x + 231f + num, num5, COAGIAMOCIA.width - 619f, 1965f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 6, "DepthTolerance", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 5f + num, num5, COAGIAMOCIA.width - 73f, 166f), JNBICAJIJMM.LEBHCLDODNI("Apply 10"), OFPNEDEAMAB);
		}

		// Token: 0x06004762 RID: 18274 RVA: 0x0021D84C File Offset: 0x0021BA4C
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DKEKMPAFIPD()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.MLBFCJFLPBG();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x06004763 RID: 18275 RVA: 0x0021E03C File Offset: 0x0021C23C
		public void BKOGJMILOEH(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.IOEEPNCKLJD();
			this.JAGMEPMLCCP = KADBECGIMPD.HHLDBAEFNMJ();
			this.DLGCNLKFOKN = KADBECGIMPD.KDNDJNEGBDI();
			this.KLPANBANBDI = KADBECGIMPD.BIMMPENHGMD();
			this.GNNDLEAFCND = KADBECGIMPD.HHLDBAEFNMJ();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.KOHGDDAADCP(this.LPFKFNLHGBI);
		}

		// Token: 0x06004764 RID: 18276 RVA: 0x0021E09C File Offset: 0x0021C29C
		public void EOOIPHHBJLK(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.BEMFIFGOJBL();
			this.JAGMEPMLCCP = KADBECGIMPD.IFDFHJLCHAE();
			this.DLGCNLKFOKN = KADBECGIMPD.HDBGOLAFOBK();
			this.KLPANBANBDI = KADBECGIMPD.DNGDPHIHLBG();
			this.GNNDLEAFCND = KADBECGIMPD.KDNDJNEGBDI();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.BEAODBGBIKC(this.LPFKFNLHGBI);
		}

		// Token: 0x06004765 RID: 18277 RVA: 0x002192D7 File Offset: 0x002174D7
		public virtual CKNLPGEPGGF.IAPCJOBDCEH GCLHFHNKONE()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.FHPNJBAEAON();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x06004766 RID: 18278 RVA: 0x0021CA3F File Offset: 0x0021AC3F
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FMELNFODNLL()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.KMIIGKECOEB();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x06004767 RID: 18279 RVA: 0x0021E0FC File Offset: 0x0021C2FC
		public virtual void OIIAMFKBGJE(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1094f;
			if (this.KHIDJHKNNFC() != null)
			{
				Texture texture = this.HEFAGFMDAEE().PFFJJEJNKPB();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 409f;
				float num4 = (float)texture.height * num2 * 788f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1299f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 952f - 129f, num3, num4), texture, ScaleMode.ScaleAndCrop);
				num = num + num3 + 122f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(680f, 1119f, 1005f);
			}
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(265f, 44f, 706f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("Ring", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = -48;
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 980f + num, num5, COAGIAMOCIA.width - 1795f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "\n<color='" + str, OFPNEDEAMAB);
			num5 += 1223f;
			OFPNEDEAMAB.fontSize = -10;
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 0)
			{
				num6 = 4;
			}
			text = text.Replace(" {0} сек", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.AIMCFAHLPEF() * (double)num6));
			text = text.Replace("PaperTurn.wav", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("_Specular", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.GJBKBEEJLDF() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 447f + num, num5, COAGIAMOCIA.width - 254f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1892f;
			if (this.JAGMEPMLCCP < 7 && this.ODBICLOCIMO)
			{
				GameInterface.getI.renderPBar(new Rect(COAGIAMOCIA.x + 430f + num, num5, COAGIAMOCIA.width - 479f, 1047f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 3, "MotorbikeHandstand", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1486f + num, num5, COAGIAMOCIA.width - 187f, 1819f), JNBICAJIJMM.CELEPPAEKAB("RenderType"), OFPNEDEAMAB);
		}

		// Token: 0x06004768 RID: 18280 RVA: 0x0021E440 File Offset: 0x0021C640
		public void KJLKIIGLBMG(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.LAECLJFMGPE();
			this.JAGMEPMLCCP = KADBECGIMPD.KDNDJNEGBDI();
			this.DLGCNLKFOKN = KADBECGIMPD.HHLDBAEFNMJ();
			this.KLPANBANBDI = KADBECGIMPD.MOBPFEEAMKD();
			this.GNNDLEAFCND = KADBECGIMPD.CLPEKGGAMAI();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.ALOFNMHDOJM(this.LPFKFNLHGBI);
		}

		// Token: 0x06004769 RID: 18281 RVA: 0x0021E4A0 File Offset: 0x0021C6A0
		public virtual void GNFHLHEHBPG(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 812f;
			if (this.HHOBCJNGCEL() != null)
			{
				Texture texture = this.KHIDJHKNNFC().DPBCBCLJHAJ();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 926f;
				float num4 = (float)texture.height * num2 * 1849f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1373f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 879f - 215f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 1120f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(134f, 1863f, 1147f);
			}
			if (this.JAGMEPMLCCP == 3)
			{
				black = new Color(875f, 1844f, 1405f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("iNPC", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			OFPNEDEAMAB.fontSize = -107;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 1320f + num, num5, COAGIAMOCIA.width - 767f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "AC_TONEMAPPING" + str, OFPNEDEAMAB);
			num5 += 1483f;
			OFPNEDEAMAB.fontSize = 14;
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 0;
			if (num6 > 2)
			{
				num6 = 8;
			}
			text = text.Replace("---------- NetManager is init", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.DHJBAKDAMGH() * (double)num6));
			text = text.Replace("-none-", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.GJBKBEEJLDF() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1981f + num, num5, COAGIAMOCIA.width - 1398f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1112f;
			if (this.JAGMEPMLCCP < 6 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 557f + num, num5, COAGIAMOCIA.width - 1288f, 1256f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 5, "inv_money", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 304f + num, num5, COAGIAMOCIA.width - 1043f, 537f), JNBICAJIJMM.DCEBAJIILPC("RenderTextures are not supported on this platform."), OFPNEDEAMAB);
		}

		// Token: 0x0600476A RID: 18282 RVA: 0x0021A92B File Offset: 0x00218B2B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FONGCOCMAPG()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.OBIJKHKCPEO();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x0600476B RID: 18283 RVA: 0x0021E7E4 File Offset: 0x0021C9E4
		public virtual void PMEKOPDPNFD(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1031f;
			if (this.ENCJNMNEANC() != null)
			{
				Texture texture = this.MFKHIBOFIFI().MMKLLFCKCAG();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 260f;
				float num4 = (float)texture.height * num2 * 821f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1824f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 1899f - 1862f, num3, num4), texture, ScaleMode.ScaleAndCrop);
				num = num + num3 + 1812f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(1655f, 886f, 931f);
			}
			if (this.JAGMEPMLCCP == 4)
			{
				black = new Color(1108f, 1861f, 153f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("RollerBladeStand", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = 52;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 318f + num, num5, COAGIAMOCIA.width - 556f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "1 H Sword Charge Heavy Bash" + str, OFPNEDEAMAB);
			num5 += 175f;
			OFPNEDEAMAB.fontSize = -103;
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 0;
			if (num6 > 4)
			{
				num6 = 7;
			}
			text = text.Replace("", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.DHJBAKDAMGH() * (double)num6));
			text = text.Replace("_1.png", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("https://groups.google.com/forum/#!forum/final-ik", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.KCKFCPIHMPC() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1902f + num, num5, COAGIAMOCIA.width - 948f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1540f;
			if (this.JAGMEPMLCCP < 0 && this.ODBICLOCIMO)
			{
				GameInterface.getI.renderPBar(new Rect(COAGIAMOCIA.x + 1020f + num, num5, COAGIAMOCIA.width - 227f, 1721f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 2, " %", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 694f + num, num5, COAGIAMOCIA.width - 1959f, 1444f), JNBICAJIJMM.PGJCPFNJNPM("offsets"), OFPNEDEAMAB);
		}

		// Token: 0x0600476C RID: 18284 RVA: 0x0021EB28 File Offset: 0x0021CD28
		public void GMNGDNMEBGI(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.BEMFIFGOJBL();
			this.JAGMEPMLCCP = KADBECGIMPD.CLPEKGGAMAI();
			this.DLGCNLKFOKN = KADBECGIMPD.HHLDBAEFNMJ();
			this.KLPANBANBDI = KADBECGIMPD.AILCEJFAMGN();
			this.GNNDLEAFCND = KADBECGIMPD.HHLDBAEFNMJ();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.DJDLJCFCPPH(this.LPFKFNLHGBI);
		}

		// Token: 0x0600476D RID: 18285 RVA: 0x0021EB88 File Offset: 0x0021CD88
		public virtual string ANJOEAHHDGC()
		{
			string arg = "DealerShuffle" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "_VignetteCenter" + this.DLGCNLKFOKN;
			}
			return string.Format("shop_wl", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x0600476E RID: 18286 RVA: 0x0021EBF0 File Offset: 0x0021CDF0
		public virtual string PMPNLAFNBBC()
		{
			string arg = "HH:mm" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "" + this.DLGCNLKFOKN;
			}
			return string.Format("IdleCheer", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x0600476F RID: 18287 RVA: 0x0021EC58 File Offset: 0x0021CE58
		public void CMNCNBNECPP(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.LAECLJFMGPE();
			this.JAGMEPMLCCP = KADBECGIMPD.KDNDJNEGBDI();
			this.DLGCNLKFOKN = KADBECGIMPD.KKOKFLMMAAK();
			this.KLPANBANBDI = KADBECGIMPD.AIDAGFNHNHE();
			this.GNNDLEAFCND = KADBECGIMPD.DOJKJHMJJNK();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.ALOFNMHDOJM(this.LPFKFNLHGBI);
		}

		// Token: 0x06004770 RID: 18288 RVA: 0x0021CA3F File Offset: 0x0021AC3F
		public virtual CKNLPGEPGGF.IAPCJOBDCEH GFPKGBJHPAO()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.KMIIGKECOEB();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x06004771 RID: 18289 RVA: 0x0021A92B File Offset: 0x00218B2B
		public override CKNLPGEPGGF.IAPCJOBDCEH BHPAALLBMHL()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.OBIJKHKCPEO();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x06004772 RID: 18290 RVA: 0x0021ECB8 File Offset: 0x0021CEB8
		public void DKJAGPHGJBP(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.JNOKJCDAPPA();
			this.JAGMEPMLCCP = KADBECGIMPD.HHLDBAEFNMJ();
			this.DLGCNLKFOKN = KADBECGIMPD.KDNDJNEGBDI();
			this.KLPANBANBDI = KADBECGIMPD.BNDHIBEOKML();
			this.GNNDLEAFCND = KADBECGIMPD.IFDFHJLCHAE();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.EHBODADDPLM(this.LPFKFNLHGBI);
		}

		// Token: 0x06004773 RID: 18291 RVA: 0x0021ED18 File Offset: 0x0021CF18
		public void IPHMJFEBBJC(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.FIFNOBGEKFF();
			this.JAGMEPMLCCP = KADBECGIMPD.HDBGOLAFOBK();
			this.DLGCNLKFOKN = KADBECGIMPD.HDBGOLAFOBK();
			this.KLPANBANBDI = KADBECGIMPD.FFDPCEAFGNF();
			this.GNNDLEAFCND = KADBECGIMPD.HDBGOLAFOBK();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(this.LPFKFNLHGBI);
		}

		// Token: 0x06004774 RID: 18292 RVA: 0x0021ED78 File Offset: 0x0021CF78
		public void PMLJOPKPOMH(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.IJJDHHFAIPE();
			this.JAGMEPMLCCP = KADBECGIMPD.KDNDJNEGBDI();
			this.DLGCNLKFOKN = KADBECGIMPD.CLPEKGGAMAI();
			this.KLPANBANBDI = KADBECGIMPD.CNNEPCOAMJK();
			this.GNNDLEAFCND = KADBECGIMPD.IFDFHJLCHAE();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.BEAODBGBIKC(this.LPFKFNLHGBI);
		}

		// Token: 0x06004775 RID: 18293 RVA: 0x0021EDD8 File Offset: 0x0021CFD8
		public virtual void FLOGBHKFADM(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1014f;
			if (this.PBHPIGPDCJA() != null)
			{
				Texture texture = this.EJJAGEFMHCO().HONJOFFBOPH();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 770f;
				float num4 = (float)texture.height * num2 * 1590f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1142f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 319f - 802f, num3, num4), texture, ScaleMode.ScaleAndCrop);
				num = num + num3 + 1781f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(462f, 805f, 28f);
			}
			if (this.JAGMEPMLCCP == 8)
			{
				black = new Color(1538f, 1672f, 702f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("IKSolverAim axis is Vector3.zero.", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			OFPNEDEAMAB.fontSize = -85;
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 550f + num, num5, COAGIAMOCIA.width - 140f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "_ExposureAdjustment" + str, OFPNEDEAMAB);
			num5 += 1941f;
			OFPNEDEAMAB.fontSize = -79;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 6)
			{
				num6 = 5;
			}
			text = text.Replace("Ready Crouch", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num6));
			text = text.Replace(" is null.", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NKGGAFLBFDF * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1948f + num, num5, COAGIAMOCIA.width - 1995f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 284f;
			if (this.JAGMEPMLCCP < 1 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 1733f + num, num5, COAGIAMOCIA.width - 494f, 1408f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 7, "WorkerHammer", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 114f + num, num5, COAGIAMOCIA.width - 1949f, 1362f), JNBICAJIJMM.LEBHCLDODNI("_parent"), OFPNEDEAMAB);
		}

		// Token: 0x06004776 RID: 18294 RVA: 0x0021F11C File Offset: 0x0021D31C
		public void FIGMIHBMPOF(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.JNOKJCDAPPA();
			this.JAGMEPMLCCP = KADBECGIMPD.HHLDBAEFNMJ();
			this.DLGCNLKFOKN = KADBECGIMPD.DOJKJHMJJNK();
			this.KLPANBANBDI = KADBECGIMPD.CGJIINADKNH();
			this.GNNDLEAFCND = KADBECGIMPD.DOJKJHMJJNK();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.PGAMAJNPFFE(this.LPFKFNLHGBI);
		}

		// Token: 0x06004777 RID: 18295 RVA: 0x0021CA3F File Offset: 0x0021AC3F
		public virtual CKNLPGEPGGF.IAPCJOBDCEH KIDDBNPKLDE()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.KMIIGKECOEB();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x06004778 RID: 18296 RVA: 0x0021F17C File Offset: 0x0021D37C
		public virtual string EGBCKBILIGA()
		{
			string arg = "No saved PlayerPrefs!" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "<color='#a0a0a0'>" + this.DLGCNLKFOKN;
			}
			return string.Format("_SampleScale", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004779 RID: 18297 RVA: 0x00219247 File Offset: 0x00217447
		public virtual CKNLPGEPGGF.IAPCJOBDCEH GLNFHKKJDDO()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.CIBLMLGGANE();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x0600477A RID: 18298 RVA: 0x0021F1E4 File Offset: 0x0021D3E4
		public JENMPDPJKBG(int IOMCHDLHIHO, HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = IOMCHDLHIHO;
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(IOMCHDLHIHO);
			if (KADBECGIMPD != null)
			{
				this.IPHMJFEBBJC(KADBECGIMPD);
			}
		}

		// Token: 0x0600477B RID: 18299 RVA: 0x0021B325 File Offset: 0x00219525
		public virtual CKNLPGEPGGF.IAPCJOBDCEH OOCOINPMAIP()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.GNMLEPEGCII();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x0600477C RID: 18300 RVA: 0x0021F210 File Offset: 0x0021D410
		public virtual string JKGHGFFFGEH()
		{
			string arg = "WATER_VERTEX_DISPLACEMENT_ON" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "id" + this.DLGCNLKFOKN;
			}
			return string.Format("<color='{0}'>{1}  {2}</color>", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x0600477D RID: 18301 RVA: 0x0021F278 File Offset: 0x0021D478
		public virtual string DFJKJAIKCMA()
		{
			string arg = "Server is closed" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "Below you can try to cheat few variables of the regular types and their obscured (secure) analogues (you may change initial values from Tester object inspector):" + this.DLGCNLKFOKN;
			}
			return string.Format("[LH &]", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x0600477E RID: 18302 RVA: 0x0021F2E0 File Offset: 0x0021D4E0
		public virtual string IJOKJHOKJOB()
		{
			string arg = "<color='" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "MotorbikeLassoRight" + this.DLGCNLKFOKN;
			}
			return string.Format("{0}/{1}", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x0021F348 File Offset: 0x0021D548
		public override void GHNCDFCOADD(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1243f;
			if (this.BHPAALLBMHL() != null)
			{
				Texture texture = this.APLAAOCGECL().EIMNFFAAHLI();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1570f;
				float num4 = (float)texture.height * num2 * 1157f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1054f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 1755f - 1516f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 232f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(89f, 442f, 1802f);
			}
			if (this.JAGMEPMLCCP == 7)
			{
				black = new Color(1207f, 1970f, 495f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = -51;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 1160f + num, num5, COAGIAMOCIA.width - 1081f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "MotorbikeBackwardSittingCheer" + str, OFPNEDEAMAB);
			num5 += 979f;
			OFPNEDEAMAB.fontSize = 90;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 0;
			if (num6 > 7)
			{
				num6 = 4;
			}
			text = text.Replace("auc_toauk", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.AIMCFAHLPEF() * (double)num6));
			text = text.Replace("wpn_add/base", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("DealerShuffle", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.FJACMDGJEBL() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 191f + num, num5, COAGIAMOCIA.width - 919f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 987f;
			if (this.JAGMEPMLCCP < 5 && this.ODBICLOCIMO)
			{
				GameInterface.getI.renderPBar(new Rect(COAGIAMOCIA.x + 256f + num, num5, COAGIAMOCIA.width - 893f, 1051f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 8, "(game main)", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1585f + num, num5, COAGIAMOCIA.width - 1624f, 733f), JNBICAJIJMM.LEBHCLDODNI("http://steamcommunity.com/sharedfiles/filedetails/?id=788064774"), OFPNEDEAMAB);
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x0021D84C File Offset: 0x0021BA4C
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HLOCHEPHKCB()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.MLBFCJFLPBG();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x0021F68C File Offset: 0x0021D88C
		public virtual void IKDEPKLOGCH(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1373f;
			if (this.BHPAALLBMHL() != null)
			{
				Texture texture = this.BHPAALLBMHL().MMKLLFCKCAG();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1844f;
				float num4 = (float)texture.height * num2 * 1463f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 711f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 1197f - 243f, num3, num4), texture, ScaleMode.ScaleAndCrop);
				num = num + num3 + 349f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(420f, 1131f, 566f);
			}
			if (this.JAGMEPMLCCP == 8)
			{
				black = new Color(77f, 802f, 549f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("ok", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			OFPNEDEAMAB.fontSize = -101;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 68f + num, num5, COAGIAMOCIA.width - 1719f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "fchair_" + str, OFPNEDEAMAB);
			num5 += 952f;
			OFPNEDEAMAB.fontSize = -95;
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 6)
			{
				num6 = 3;
			}
			text = text.Replace("IdleStand", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.AIMCFAHLPEF() * (double)num6));
			text = text.Replace("BowInstant", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("gi_uinf_2i", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.FJACMDGJEBL() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1780f + num, num5, COAGIAMOCIA.width - 1688f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 591f;
			if (this.JAGMEPMLCCP < 7 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 759f + num, num5, COAGIAMOCIA.width - 1582f, 248f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 7, "\n", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 446f + num, num5, COAGIAMOCIA.width - 353f, 923f), JNBICAJIJMM.CDDCIKKDFMP("Hidden/Post FX/Motion Blur"), OFPNEDEAMAB);
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x0021F9D0 File Offset: 0x0021DBD0
		public virtual void LNHHBEOABGP(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 423f;
			if (this.GKPOPMAAGIJ() != null)
			{
				Texture texture = this.PBEMPJOBKKI().HONJOFFBOPH();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1804f;
				float num4 = (float)texture.height * num2 * 320f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1064f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 1903f - 752f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 800f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(26f, 703f, 1682f);
			}
			if (this.JAGMEPMLCCP == 1)
			{
				black = new Color(1791f, 1851f, 61f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("Femur", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			OFPNEDEAMAB.fontSize = -92;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 421f + num, num5, COAGIAMOCIA.width - 1577f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "invn_rec28" + str, OFPNEDEAMAB);
			num5 += 1676f;
			OFPNEDEAMAB.fontSize = -88;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 3)
			{
				num6 = 7;
			}
			text = text.Replace("", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num6));
			text = text.Replace("Hidden/Post FX/Motion Blur", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("HeelClick", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NKGGAFLBFDF * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 921f + num, num5, COAGIAMOCIA.width - 1179f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 84f;
			if (this.JAGMEPMLCCP < 3 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 1266f + num, num5, COAGIAMOCIA.width - 1916f, 651f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 7, "SYS", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 459f + num, num5, COAGIAMOCIA.width - 695f, 1015f), JNBICAJIJMM.PPNKMDJBMLP("gi_um_nosel"), OFPNEDEAMAB);
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x0021D84C File Offset: 0x0021BA4C
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HINHFMALJOG()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.MLBFCJFLPBG();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x06004784 RID: 18308 RVA: 0x0021FD14 File Offset: 0x0021DF14
		public virtual string DDLFNJEJPBP()
		{
			string arg = "gi_um_passperk" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "isRodInWater" + this.DLGCNLKFOKN;
			}
			return string.Format("UnityEngine.Color", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x0021FD7C File Offset: 0x0021DF7C
		public virtual string FBENMKABKKB()
		{
			string arg = "CratePull" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "TOD_Sky2World" + this.DLGCNLKFOKN;
			}
			return string.Format("wpn_eat3", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004786 RID: 18310 RVA: 0x0021FDE4 File Offset: 0x0021DFE4
		public virtual void DBCCBDCAMII(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 401f;
			if (this.PDJBFPOAPBA() != null)
			{
				Texture texture = this.GKPOPMAAGIJ().EIMNFFAAHLI();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 514f;
				float num4 = (float)texture.height * num2 * 809f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1743f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 1548f - 1805f, num3, num4), texture, ScaleMode.ScaleAndCrop);
				num = num + num3 + 1293f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(43f, 906f, 1795f);
			}
			if (this.JAGMEPMLCCP == 1)
			{
				black = new Color(190f, 251f, 1907f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("_UserLutParams", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = -111;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 598f + num, num5, COAGIAMOCIA.width - 1788f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "IdleStandingJump" + str, OFPNEDEAMAB);
			num5 += 335f;
			OFPNEDEAMAB.fontSize = -113;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 1)
			{
				num6 = 6;
			}
			text = text.Replace("JumpLeg", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num6));
			text = text.Replace(" path=", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("auc_wsbor", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.HDPNCIECLKP() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1628f + num, num5, COAGIAMOCIA.width - 759f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1387f;
			if (this.JAGMEPMLCCP < 6 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 286f + num, num5, COAGIAMOCIA.width - 960f, 1520f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 8, "Button", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 755f + num, num5, COAGIAMOCIA.width - 1166f, 102f), JNBICAJIJMM.NGALDMFKMJH("BAG"), OFPNEDEAMAB);
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x00220128 File Offset: 0x0021E328
		public virtual string NAAOOABFHKB()
		{
			string arg = "No Way points!" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "id" + this.DLGCNLKFOKN;
			}
			return string.Format("OfficeSittingHandRestFingerTap", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x00220190 File Offset: 0x0021E390
		public void BFIHGBEHHOG(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.DADCGPGEHFK();
			this.JAGMEPMLCCP = KADBECGIMPD.KKOKFLMMAAK();
			this.DLGCNLKFOKN = KADBECGIMPD.KDNDJNEGBDI();
			this.KLPANBANBDI = KADBECGIMPD.MOBPFEEAMKD();
			this.GNNDLEAFCND = KADBECGIMPD.IFDFHJLCHAE();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.JEFCOLDKFPI(this.LPFKFNLHGBI);
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x00219A6C File Offset: 0x00217C6C
		public virtual CKNLPGEPGGF.IAPCJOBDCEH MJHGGHLFFFK()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.OHJIDDDKOAA();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x002201F0 File Offset: 0x0021E3F0
		public void HJMKDDJNBNB(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.AJECAOJPOKA();
			this.JAGMEPMLCCP = KADBECGIMPD.HDBGOLAFOBK();
			this.DLGCNLKFOKN = KADBECGIMPD.KDNDJNEGBDI();
			this.KLPANBANBDI = KADBECGIMPD.BIMMPENHGMD();
			this.GNNDLEAFCND = KADBECGIMPD.AGNKAFLKCAG();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.KOHGDDAADCP(this.LPFKFNLHGBI);
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x00220250 File Offset: 0x0021E450
		public void AEBJGLGLFPG(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.BLNIHNKJJPJ();
			this.JAGMEPMLCCP = KADBECGIMPD.CLPEKGGAMAI();
			this.DLGCNLKFOKN = KADBECGIMPD.LDLKLPJBIJN();
			this.KLPANBANBDI = KADBECGIMPD.BIMMPENHGMD();
			this.GNNDLEAFCND = KADBECGIMPD.LDLKLPJBIJN();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.KOHGDDAADCP(this.LPFKFNLHGBI);
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x00219247 File Offset: 0x00217447
		public virtual CKNLPGEPGGF.IAPCJOBDCEH AIHENNHGODP()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.CIBLMLGGANE();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x002202B0 File Offset: 0x0021E4B0
		public void AJBMLMPFKNL(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.IOEEPNCKLJD();
			this.JAGMEPMLCCP = KADBECGIMPD.KKOKFLMMAAK();
			this.DLGCNLKFOKN = KADBECGIMPD.HHLDBAEFNMJ();
			this.KLPANBANBDI = KADBECGIMPD.CGJIINADKNH();
			this.GNNDLEAFCND = KADBECGIMPD.HDBGOLAFOBK();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.KOHGDDAADCP(this.LPFKFNLHGBI);
		}

		// Token: 0x0600478E RID: 18318 RVA: 0x00220310 File Offset: 0x0021E510
		public virtual string KBHGJLAEMFH()
		{
			string arg = "DestroyNow" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "IdleReadyCrouch" + this.DLGCNLKFOKN;
			}
			return string.Format("fshop_hd4", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x0600478F RID: 18319 RVA: 0x00220378 File Offset: 0x0021E578
		public virtual string DLGLBACGDGB()
		{
			string arg = "{0} {1}" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "Vertical" + this.DLGCNLKFOKN;
			}
			return string.Format("", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x06004790 RID: 18320 RVA: 0x002203E0 File Offset: 0x0021E5E0
		public override void HJDLKEIIODM(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1184f;
			if (this.FMMNICCENPF() != null)
			{
				Texture texture = this.BHPAALLBMHL().EIMNFFAAHLI();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1247f;
				float num4 = (float)texture.height * num2 * 801f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1914f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 477f - 137f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 1319f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(761f, 785f, 46f);
			}
			if (this.JAGMEPMLCCP == 3)
			{
				black = new Color(809f, 1431f, 1846f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("Assets/Weapons/wbaseJaket.unity3d", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = -83;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 1077f + num, num5, COAGIAMOCIA.width - 568f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "Mouse X" + str, OFPNEDEAMAB);
			num5 += 282f;
			OFPNEDEAMAB.fontSize = -33;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 6)
			{
				num6 = 8;
			}
			text = text.Replace("GestureCutThroat", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num6));
			text = text.Replace("cntx_close", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("Sunshine Lightmap", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.HDPNCIECLKP() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1944f + num, num5, COAGIAMOCIA.width - 1452f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1759f;
			if (this.JAGMEPMLCCP < 8 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 925f + num, num5, COAGIAMOCIA.width - 1996f, 947f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 8, "B", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1870f + num, num5, COAGIAMOCIA.width - 414f, 227f), JNBICAJIJMM.CELEPPAEKAB("name"), OFPNEDEAMAB);
		}

		// Token: 0x06004791 RID: 18321 RVA: 0x00220724 File Offset: 0x0021E924
		public void AKIGALINJKI(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.OMCMPDMJFOJ();
			this.JAGMEPMLCCP = KADBECGIMPD.CLPEKGGAMAI();
			this.DLGCNLKFOKN = KADBECGIMPD.KKOKFLMMAAK();
			this.KLPANBANBDI = KADBECGIMPD.BNDHIBEOKML();
			this.GNNDLEAFCND = KADBECGIMPD.IFDFHJLCHAE();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.PGAMAJNPFFE(this.LPFKFNLHGBI);
		}

		// Token: 0x06004792 RID: 18322 RVA: 0x00220784 File Offset: 0x0021E984
		public void GCFEGKBEDFF(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.DADCGPGEHFK();
			this.JAGMEPMLCCP = KADBECGIMPD.KKOKFLMMAAK();
			this.DLGCNLKFOKN = KADBECGIMPD.CLPEKGGAMAI();
			this.KLPANBANBDI = KADBECGIMPD.ECJLJGDNFMN();
			this.GNNDLEAFCND = KADBECGIMPD.HHLDBAEFNMJ();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.PGAMAJNPFFE(this.LPFKFNLHGBI);
		}

		// Token: 0x06004793 RID: 18323 RVA: 0x002207E4 File Offset: 0x0021E9E4
		public void JGGBPBJEIDP(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.OMCMPDMJFOJ();
			this.JAGMEPMLCCP = KADBECGIMPD.CLPEKGGAMAI();
			this.DLGCNLKFOKN = KADBECGIMPD.IFDFHJLCHAE();
			this.KLPANBANBDI = KADBECGIMPD.BNDHIBEOKML();
			this.GNNDLEAFCND = KADBECGIMPD.KDNDJNEGBDI();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.DIJBEPJDOLJ(this.LPFKFNLHGBI);
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x00220844 File Offset: 0x0021EA44
		public virtual void BIPHIOAKMAB(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 621f;
			if (this.HFAGADCJACL() != null)
			{
				Texture texture = this.PBEMPJOBKKI().HONJOFFBOPH();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1092f;
				float num4 = (float)texture.height * num2 * 1578f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 64f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 835f - 1285f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 1637f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(1294f, 1782f, 294f);
			}
			if (this.JAGMEPMLCCP == 8)
			{
				black = new Color(1038f, 15f, 278f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("demoByteArray", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			OFPNEDEAMAB.fontSize = -18;
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 187f + num, num5, COAGIAMOCIA.width - 1566f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "WATER_REFLECTIVE" + str, OFPNEDEAMAB);
			num5 += 725f;
			OFPNEDEAMAB.fontSize = -1;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 0)
			{
				num6 = 8;
			}
			text = text.Replace("****************  playNextMusic ", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.AIMCFAHLPEF() * (double)num6));
			text = text.Replace("WeaponStand", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("ComeHere", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.FJACMDGJEBL() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1038f + num, num5, COAGIAMOCIA.width - 1828f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1153f;
			if (this.JAGMEPMLCCP < 8 && this.ODBICLOCIMO)
			{
				GameInterface.getI.renderPBar(new Rect(COAGIAMOCIA.x + 883f + num, num5, COAGIAMOCIA.width - 1875f, 1196f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 6, "vp", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1687f + num, num5, COAGIAMOCIA.width - 737f, 1533f), JNBICAJIJMM.CELEPPAEKAB("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/"), OFPNEDEAMAB);
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x00219A6C File Offset: 0x00217C6C
		public virtual CKNLPGEPGGF.IAPCJOBDCEH PNCEDJHCAJE()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.OHJIDDDKOAA();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x06004796 RID: 18326 RVA: 0x00220B88 File Offset: 0x0021ED88
		public virtual void HHBLLIKDCBB(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1828f;
			if (this.APLAAOCGECL() != null)
			{
				Texture texture = this.FMMNICCENPF().OABDBIAHOJH();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1342f;
				float num4 = (float)texture.height * num2 * 348f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 803f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 110f - 1704f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 301f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(39f, 1309f, 403f);
			}
			if (this.JAGMEPMLCCP == 7)
			{
				black = new Color(642f, 381f, 147f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("1HandSmallWeaponCombo", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = 27;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 1943f + num, num5, COAGIAMOCIA.width - 1234f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "Please select the effectors to interact with." + str, OFPNEDEAMAB);
			num5 += 365f;
			OFPNEDEAMAB.fontSize = -48;
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 2)
			{
				num6 = 4;
			}
			text = text.Replace("error", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num6));
			text = text.Replace("<b>Obscured Cheating Detector</b>", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("lineDistance=", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.DBFOHFDOCIB() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1472f + num, num5, COAGIAMOCIA.width - 1419f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 325f;
			if (this.JAGMEPMLCCP < 4 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 93f + num, num5, COAGIAMOCIA.width - 1036f, 657f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 8, "<color='{0}'> Очков работы: {1}</color>", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1273f + num, num5, COAGIAMOCIA.width - 282f, 1459f), JNBICAJIJMM.PPNKMDJBMLP("Sunshine Project Configuration"), OFPNEDEAMAB);
		}

		// Token: 0x06004797 RID: 18327 RVA: 0x00220ECC File Offset: 0x0021F0CC
		public void AEBDFBHLMCC(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.BEMFIFGOJBL();
			this.JAGMEPMLCCP = KADBECGIMPD.HHLDBAEFNMJ();
			this.DLGCNLKFOKN = KADBECGIMPD.KDNDJNEGBDI();
			this.KLPANBANBDI = KADBECGIMPD.CNNEPCOAMJK();
			this.GNNDLEAFCND = KADBECGIMPD.IFDFHJLCHAE();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.EHBODADDPLM(this.LPFKFNLHGBI);
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x00219247 File Offset: 0x00217447
		public virtual CKNLPGEPGGF.IAPCJOBDCEH NCEHHOOBOFL()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.CIBLMLGGANE();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x00220F2C File Offset: 0x0021F12C
		public virtual string NILBMGFGPPB()
		{
			string arg = "ZombieCrawl" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "quests/qdynamic/qd" + this.DLGCNLKFOKN;
			}
			return string.Format("</color>", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x0600479A RID: 18330 RVA: 0x00220F94 File Offset: 0x0021F194
		public override string CJMFHLIBCBM()
		{
			string arg = "" + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "invn_rec21" + this.DLGCNLKFOKN;
			}
			return string.Format("{0:F2}, {1:F2}, {2:F2}", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x0600479B RID: 18331 RVA: 0x00220FFC File Offset: 0x0021F1FC
		public virtual void AJPAHPBOLLK(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1554f;
			if (this.ENCJNMNEANC() != null)
			{
				Texture texture = this.HHOBCJNGCEL().LECMGDEDAKF();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1441f;
				float num4 = (float)texture.height * num2 * 1954f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1685f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 148f - 1650f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 1258f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(1024f, 184f, 1184f);
			}
			if (this.JAGMEPMLCCP == 6)
			{
				black = new Color(209f, 1634f, 1978f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("TAA History", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			OFPNEDEAMAB.fontSize = -85;
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 818f + num, num5, COAGIAMOCIA.width - 1498f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "Try to change this float in memory:\n" + str, OFPNEDEAMAB);
			num5 += 806f;
			OFPNEDEAMAB.fontSize = 106;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 0;
			if (num6 > 5)
			{
				num6 = 4;
			}
			text = text.Replace("Open turnStatus", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num6));
			text = text.Replace("gi_um_0", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.KCKFCPIHMPC() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 270f + num, num5, COAGIAMOCIA.width - 1577f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 126f;
			if (this.JAGMEPMLCCP < 3 && this.ODBICLOCIMO)
			{
				GameInterface.getI.renderPBar(new Rect(COAGIAMOCIA.x + 723f + num, num5, COAGIAMOCIA.width - 628f, 1152f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 0, "selectTitulId=", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1332f + num, num5, COAGIAMOCIA.width - 921f, 861f), JNBICAJIJMM.CELEPPAEKAB("1 Hand Heavy Swing 2"), OFPNEDEAMAB);
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x002192D7 File Offset: 0x002174D7
		public virtual CKNLPGEPGGF.IAPCJOBDCEH MDFFEHKPBHO()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.FHPNJBAEAON();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x00219A6C File Offset: 0x00217C6C
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HAEJBFNEIOM()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.OHJIDDDKOAA();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x00221340 File Offset: 0x0021F540
		public virtual void DBJLENKPKDF(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 238f;
			if (this.PBHPIGPDCJA() != null)
			{
				Texture texture = this.HFAGADCJACL().MMKLLFCKCAG();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1323f;
				float num4 = (float)texture.height * num2 * 301f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1247f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 147f - 560f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 824f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(921f, 1871f, 1482f);
			}
			if (this.JAGMEPMLCCP == 4)
			{
				black = new Color(1139f, 1932f, 682f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("_ALPHATEST_ON", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = -99;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 864f + num, num5, COAGIAMOCIA.width - 1112f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "MotorbikeShootBack" + str, OFPNEDEAMAB);
			num5 += 1834f;
			OFPNEDEAMAB.fontSize = 72;
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 3)
			{
				num6 = 8;
			}
			text = text.Replace("MotorbikeHeartAttack", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num6));
			text = text.Replace("firsStartInfoPanel", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("_Params", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.HDPNCIECLKP() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 977f + num, num5, COAGIAMOCIA.width - 636f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1761f;
			if (this.JAGMEPMLCCP < 2 && this.ODBICLOCIMO)
			{
				GameInterface.getI.renderPBar(new Rect(COAGIAMOCIA.x + 509f + num, num5, COAGIAMOCIA.width - 781f, 123f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 4, "\n", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1694f + num, num5, COAGIAMOCIA.width - 1640f, 921f), JNBICAJIJMM.DIOJFJMOPJO("Demo"), OFPNEDEAMAB);
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x0021B325 File Offset: 0x00219525
		public virtual CKNLPGEPGGF.IAPCJOBDCEH OAJANJBLPNC()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.GNMLEPEGCII();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x00221684 File Offset: 0x0021F884
		public void LPJDKDKOABN(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.DADCGPGEHFK();
			this.JAGMEPMLCCP = KADBECGIMPD.AGNKAFLKCAG();
			this.DLGCNLKFOKN = KADBECGIMPD.HHLDBAEFNMJ();
			this.KLPANBANBDI = KADBECGIMPD.DNGDPHIHLBG();
			this.GNNDLEAFCND = KADBECGIMPD.AGNKAFLKCAG();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.DJDLJCFCPPH(this.LPFKFNLHGBI);
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x002216E4 File Offset: 0x0021F8E4
		public void DOGNCKICIAG(HBPNMNGOFMA KADBECGIMPD)
		{
			this.ODBICLOCIMO = KADBECGIMPD.AJECAOJPOKA();
			this.JAGMEPMLCCP = KADBECGIMPD.HDBGOLAFOBK();
			this.DLGCNLKFOKN = KADBECGIMPD.IFDFHJLCHAE();
			this.KLPANBANBDI = KADBECGIMPD.BIMMPENHGMD();
			this.GNNDLEAFCND = KADBECGIMPD.DOJKJHMJJNK();
			this.BDHHPAEHFHG = NLNNIDBPKAO.IKGFHGKKCPG.KOHGDDAADCP(this.LPFKFNLHGBI);
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x00221744 File Offset: 0x0021F944
		public virtual void BGINBEFMNBL(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 334f;
			if (this.PBEMPJOBKKI() != null)
			{
				Texture texture = this.HFAGADCJACL().HONJOFFBOPH();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1578f;
				float num4 = (float)texture.height * num2 * 1384f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 1233f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 1075f - 1217f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 243f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(1896f, 95f, 488f);
			}
			if (this.JAGMEPMLCCP == 8)
			{
				black = new Color(919f, 1864f, 1984f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("ECHO ON ", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			OFPNEDEAMAB.fontSize = 122;
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 1141f + num, num5, COAGIAMOCIA.width - 1836f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "Backward Stand" + str, OFPNEDEAMAB);
			num5 += 139f;
			OFPNEDEAMAB.fontSize = 10;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 0;
			if (num6 > 0)
			{
				num6 = 2;
			}
			text = text.Replace("BowReady", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num6));
			text = text.Replace("wpn_med2", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("PrimaryCausticsProjector", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NKGGAFLBFDF * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 984f + num, num5, COAGIAMOCIA.width - 1896f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1658f;
			if (this.JAGMEPMLCCP < 3 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 1986f + num, num5, COAGIAMOCIA.width - 1086f, 927f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 5, "Mouse Y", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1935f + num, num5, COAGIAMOCIA.width - 1924f, 640f), JNBICAJIJMM.CDDCIKKDFMP("ObscuredPrefs:"), OFPNEDEAMAB);
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x00221A88 File Offset: 0x0021FC88
		public override string ToString()
		{
			string arg = " ур. " + this.JAGMEPMLCCP;
			if (this.DLGCNLKFOKN != this.JAGMEPMLCCP)
			{
				arg = "/" + this.DLGCNLKFOKN;
			}
			return string.Format("{0} {1}\n{2}", this.BDHHPAEHFHG.KKEBDLGHBMN, arg, this.BDHHPAEHFHG.PAALJNAKJEG);
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x0021CA6F File Offset: 0x0021AC6F
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DPIKOLIHBHD()
		{
			if (this.BDHHPAEHFHG != null)
			{
				if (this.BDHHPAEHFHG.AJFCDFFJLHG == null)
				{
					this.BDHHPAEHFHG.AJGPNAPFCAG();
				}
				return this.BDHHPAEHFHG.AJFCDFFJLHG;
			}
			return null;
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x00221AF0 File Offset: 0x0021FCF0
		public override void HBOFDBKHMHC(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1031f;
			if (this.JGBOJNELADG() != null)
			{
				Texture texture = this.HHOBCJNGCEL().ANLLGCICOPP();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 1240f;
				float num4 = (float)texture.height * num2 * 1480f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 189f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 110f - 663f, num3, num4), texture, ScaleMode.StretchToFill);
				num = num + num3 + 829f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(1578f, 250f, 1405f);
			}
			if (this.JAGMEPMLCCP == 3)
			{
				black = new Color(1317f, 1946f, 1588f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("OneHandSwordIdle", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			OFPNEDEAMAB.fontSize = -78;
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 1841f + num, num5, COAGIAMOCIA.width - 1843f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "pelvis" + str, OFPNEDEAMAB);
			num5 += 218f;
			OFPNEDEAMAB.fontSize = -88;
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 1;
			if (num6 > 3)
			{
				num6 = 5;
			}
			text = text.Replace("UpHillWalk", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.AIMCFAHLPEF() * (double)num6));
			text = text.Replace("SoccerKeeperStrafeRight", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num6));
			text = text.Replace("Transforms is null.", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.KCKFCPIHMPC() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1444f + num, num5, COAGIAMOCIA.width - 386f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 258f;
			if (this.JAGMEPMLCCP < 0 && this.ODBICLOCIMO)
			{
				GameInterface.getI.renderPBar(new Rect(COAGIAMOCIA.x + 442f + num, num5, COAGIAMOCIA.width - 101f, 182f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 4, "IdleDodgeLeft", false);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 520f + num, num5, COAGIAMOCIA.width - 1076f, 1657f), JNBICAJIJMM.CELEPPAEKAB("\n"), OFPNEDEAMAB);
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x00221E34 File Offset: 0x00220034
		public virtual void LKJAGLHDAKK(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 563f;
			if (this.HHOBCJNGCEL() != null)
			{
				Texture texture = this.BHPAALLBMHL().EIMNFFAAHLI();
				float num2 = COAGIAMOCIA.height / (float)texture.height;
				float num3 = (float)texture.width * num2 * 130f;
				float num4 = (float)texture.height * num2 * 453f;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x + 415f, COAGIAMOCIA.y + (COAGIAMOCIA.height - num4) / 1619f - 164f, num3, num4), texture, ScaleMode.ScaleAndCrop);
				num = num + num3 + 263f;
			}
			float num5 = COAGIAMOCIA.y;
			Color black = Color.black;
			if (this.JAGMEPMLCCP == 0)
			{
				black = new Color(1862f, 596f, 1470f);
			}
			if (this.JAGMEPMLCCP == 3)
			{
				black = new Color(491f, 1214f, 1944f);
			}
			OFPNEDEAMAB.normal.textColor = black;
			string str = string.Concat(this.JAGMEPMLCCP);
			if (this.JAGMEPMLCCP != this.DLGCNLKFOKN)
			{
				str = string.Format("Anti-Cheat Toolkit Detectors", this.JAGMEPMLCCP, this.DLGCNLKFOKN - this.JAGMEPMLCCP, this.DLGCNLKFOKN);
			}
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			OFPNEDEAMAB.fontSize = -24;
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont3;
			GUI.Label(new Rect(COAGIAMOCIA.x + 419f + num, num5, COAGIAMOCIA.width - 950f, COAGIAMOCIA.height), this.BDHHPAEHFHG.KKEBDLGHBMN + "http://af-2.ru/?q=store" + str, OFPNEDEAMAB);
			num5 += 1444f;
			OFPNEDEAMAB.fontSize = 16;
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont;
			string text = this.BDHHPAEHFHG.PAALJNAKJEG;
			int num6 = this.JAGMEPMLCCP + 0;
			if (num6 > 0)
			{
				num6 = 7;
			}
			text = text.Replace("t_hair", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.DHJBAKDAMGH() * (double)num6));
			text = text.Replace("_BlurVector", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num6));
			text = text.Replace("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6", string.Concat(this.BDHHPAEHFHG.DCCPCBLODIG.KCKFCPIHMPC() * (double)num6));
			GUI.Label(new Rect(COAGIAMOCIA.x + 1233f + num, num5, COAGIAMOCIA.width - 1615f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
			num5 += 1675f;
			if (this.JAGMEPMLCCP < 8 && this.ODBICLOCIMO)
			{
				GameInterface.getI.NFGOLLEEHHK(new Rect(COAGIAMOCIA.x + 1267f + num, num5, COAGIAMOCIA.width - 286f, 157f), this.KLPANBANBDI, (float)this.GNNDLEAFCND, 7, "CratePush", true);
				return;
			}
			GUI.Label(new Rect(COAGIAMOCIA.x + 1008f + num, num5, COAGIAMOCIA.width - 942f, 629f), JNBICAJIJMM.PPNKMDJBMLP("AQUAS_Reflection not found"), OFPNEDEAMAB);
		}

		// Token: 0x04000B3A RID: 2874
		public int LPFKFNLHGBI;

		// Token: 0x04000B3B RID: 2875
		public int JAGMEPMLCCP;

		// Token: 0x04000B3C RID: 2876
		public int DLGCNLKFOKN;

		// Token: 0x04000B3D RID: 2877
		public float KLPANBANBDI;

		// Token: 0x04000B3E RID: 2878
		public int GNNDLEAFCND;

		// Token: 0x04000B3F RID: 2879
		public bool ODBICLOCIMO;

		// Token: 0x04000B40 RID: 2880
		public NLNNIDBPKAO.KDHODDMNDFC BDHHPAEHFHG;
	}
}
