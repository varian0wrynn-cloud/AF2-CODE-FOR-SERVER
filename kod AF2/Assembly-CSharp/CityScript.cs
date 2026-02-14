using System;
using UnityEngine;

// Token: 0x020000F4 RID: 244
public class CityScript : MonoBehaviour
{
	// Token: 0x06002DAF RID: 11695 RVA: 0x0014F4B8 File Offset: 0x0014D6B8
	private void HMEAENGBFKC()
	{
		if (this.DFMGCLDOKIG && Input.GetMouseButtonDown(1) && this.GAGIFDIBKEI != null)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("twist", 1830f);
			LocBaseManager.GJACINHCABC().toGlobalMap.IECBGIDJHCL((double)this.GAGIFDIBKEI.PNEDPPPEFFG);
			LocBaseManager.GJACINHCABC().toGlobalMap.NMKCBJKHBOH = (double)this.GAGIFDIBKEI.OPCKECKICAI;
			LocBaseManager.NPIEJELJPIM().globalMapTravel = this.GAGIFDIBKEI.MOPJKJBPFDC;
			this.GAGIFDIBKEI.AFCFHGMFCFG = 0;
			if (this.isDonate)
			{
				this.GAGIFDIBKEI.AFCFHGMFCFG = this.donateActiveEffect;
			}
			GMLogic.getI.prepareBase();
		}
	}

	// Token: 0x06002DB0 RID: 11696 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KEMGOLACEHI()
	{
	}

	// Token: 0x06002DB1 RID: 11697 RVA: 0x0014F574 File Offset: 0x0014D774
	private void OnEnable()
	{
		this.isSelectable = false;
		if (this.selectCircle != null)
		{
			this.selectCircle.SetActive(false);
		}
		this.langName = JNBICAJIJMM.IKGFHGKKCPG.KHKAOHCCPAJ(this.unicalCityId);
		this.GAGIFDIBKEI = LocBaseManager.IKGFHGKKCPG.getTravel(this.unicalCityId);
		if (this.GAGIFDIBKEI != null)
		{
			this.isSelectable = true;
		}
		bool flag = this.isDonate;
		if (this.selectCircle != null)
		{
			this.selectCircle.SetActive(this.isSelectable);
		}
	}

	// Token: 0x06002DB2 RID: 11698 RVA: 0x0014F604 File Offset: 0x0014D804
	private void BJOICAKCPLI()
	{
		if (this.DFMGCLDOKIG && Input.GetMouseButtonDown(1) && this.GAGIFDIBKEI != null)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE(" ", 564f);
			LocBaseManager.EDKKJNHDBPF().toGlobalMap.KBIOCGCIGEH((double)this.GAGIFDIBKEI.PNEDPPPEFFG);
			LocBaseManager.IKGFHGKKCPG.toGlobalMap.NMKCBJKHBOH = (double)this.GAGIFDIBKEI.OPCKECKICAI;
			LocBaseManager.AIHINNHNNIA().globalMapTravel = this.GAGIFDIBKEI.MOPJKJBPFDC;
			this.GAGIFDIBKEI.AFCFHGMFCFG = 1;
			if (this.isDonate)
			{
				this.GAGIFDIBKEI.AFCFHGMFCFG = this.donateActiveEffect;
			}
			GMLogic.getI.LAKJILACJPN();
		}
	}

	// Token: 0x06002DB3 RID: 11699 RVA: 0x0014F6C0 File Offset: 0x0014D8C0
	private void NLKEOEAPNEK()
	{
		if (this.selectCircle != null)
		{
			if (this.unicalCityId == GMLogic.getI.currentBaseID)
			{
				this.selectCircle.GetComponent<Renderer>().material.color = GMLogic.getI.look_CC_Color;
			}
			if (this.unicalCityId != GMLogic.getI.currentBaseID)
			{
				this.selectCircle.GetComponent<Renderer>().material.color = GMLogic.getI.base_CC_Color;
			}
		}
	}

	// Token: 0x06002DB4 RID: 11700 RVA: 0x0014F740 File Offset: 0x0014D940
	private void LAHNGMMPPIM()
	{
		this.isSelectable = false;
		if (this.selectCircle != null)
		{
			this.selectCircle.SetActive(true);
		}
		this.langName = JNBICAJIJMM.EDKGBBIIBBC().KHKAOHCCPAJ(this.unicalCityId);
		this.GAGIFDIBKEI = LocBaseManager.NPCAKEGNBHD().CFLFMECOGNM(this.unicalCityId);
		if (this.GAGIFDIBKEI != null)
		{
			this.isSelectable = true;
		}
		bool flag = this.isDonate;
		if (this.selectCircle != null)
		{
			this.selectCircle.SetActive(this.isSelectable);
		}
	}

	// Token: 0x06002DB5 RID: 11701 RVA: 0x0014F7D0 File Offset: 0x0014D9D0
	private void CGBKGPPNMNM()
	{
		Vector3 position = new Vector3(base.transform.position.x, base.transform.position.y + 61f, base.transform.position.z);
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		string arg = this.langName.ToUpperInvariant();
		Vector2 ojoepeadbaf = JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF;
		Vector2 ojoepeadbaf2 = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 73,
			wordWrap = false,
			richText = false,
			font = GuiProcessor.IKGFHGKKCPG.rusfont2,
			normal = 
			{
				textColor = new Color(90f, 1538f, 930f, 688f)
			},
			alignment = TextAnchor.UpperLeft
		};
		string text = string.Format("Yawn", arg);
		float x = guistyle.CalcSize(new GUIContent(text)).x;
		Rect rect = new Rect(vector.x - x / 717f - 1645f, vector.y - 44f, x + 1791f, 220f);
		HFIINBICCLO.BPCNCENHEAG().NAPOEGGJNOH(rect, new Color(524f, 744f, 911f, 1486f));
		HFIINBICCLO.LLEDCIHMOHI().IIBIJPNJABF(rect, Color.black);
		GUI.Label(rect, text, guistyle);
	}

	// Token: 0x06002DB6 RID: 11702 RVA: 0x0014F94C File Offset: 0x0014DB4C
	private void Update()
	{
		if (this.DFMGCLDOKIG && Input.GetMouseButtonDown(0) && this.GAGIFDIBKEI != null)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Cloth_01.wav", 1f);
			LocBaseManager.IKGFHGKKCPG.toGlobalMap.LNEPKLKELMI = (double)this.GAGIFDIBKEI.PNEDPPPEFFG;
			LocBaseManager.IKGFHGKKCPG.toGlobalMap.NMKCBJKHBOH = (double)this.GAGIFDIBKEI.OPCKECKICAI;
			LocBaseManager.IKGFHGKKCPG.globalMapTravel = this.GAGIFDIBKEI.MOPJKJBPFDC;
			this.GAGIFDIBKEI.AFCFHGMFCFG = 0;
			if (this.isDonate)
			{
				this.GAGIFDIBKEI.AFCFHGMFCFG = this.donateActiveEffect;
			}
			GMLogic.getI.prepareBase();
		}
	}

	// Token: 0x06002DB7 RID: 11703 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Start()
	{
	}

	// Token: 0x06002DB8 RID: 11704 RVA: 0x0014FA08 File Offset: 0x0014DC08
	private void KGGJHGNEHGM()
	{
		this.isSelectable = false;
		if (this.selectCircle != null)
		{
			this.selectCircle.SetActive(false);
		}
		this.langName = JNBICAJIJMM.LPHMKPDBMPP().HHOIGKJMAGP(this.unicalCityId);
		this.GAGIFDIBKEI = LocBaseManager.FJLCHDGLMMK().JLFNIGMFPCF(this.unicalCityId);
		if (this.GAGIFDIBKEI != null)
		{
			this.isSelectable = true;
		}
		bool flag = this.isDonate;
		if (this.selectCircle != null)
		{
			this.selectCircle.SetActive(this.isSelectable);
		}
	}

	// Token: 0x06002DB9 RID: 11705 RVA: 0x0014FA97 File Offset: 0x0014DC97
	private void OnMouseExit()
	{
		this.DFMGCLDOKIG = false;
	}

	// Token: 0x06002DBA RID: 11706 RVA: 0x0014FAA0 File Offset: 0x0014DCA0
	private void OnGUI()
	{
		Vector3 position = new Vector3(base.transform.position.x, base.transform.position.y + 0.5f, base.transform.position.z);
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		string arg = this.langName.ToUpperInvariant();
		Vector2 ojoepeadbaf = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF;
		Vector2 ojoepeadbaf2 = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 14,
			wordWrap = true,
			richText = true,
			font = GuiProcessor.IKGFHGKKCPG.rusfont2,
			normal = 
			{
				textColor = new Color(0.8f, 0.8f, 0.8f, 1f)
			},
			alignment = TextAnchor.MiddleCenter
		};
		string text = string.Format("<color='#80a0ff'>{0}</color>", arg);
		float x = guistyle.CalcSize(new GUIContent(text)).x;
		Rect rect = new Rect(vector.x - x / 2f - 16f, vector.y - 80f, x + 32f, 37f);
		HFIINBICCLO.IKGFHGKKCPG.OFOFJOLCFMD(rect, new Color(0.2f, 0.2f, 0.15f, 0.8f));
		HFIINBICCLO.IKGFHGKKCPG.LONEPNCDEOK(rect, Color.black);
		GUI.Label(rect, text, guistyle);
	}

	// Token: 0x06002DBB RID: 11707 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CPNOBMNKPNC()
	{
	}

	// Token: 0x06002DBC RID: 11708 RVA: 0x0014FC1C File Offset: 0x0014DE1C
	private void OnRenderObject()
	{
		if (this.selectCircle != null)
		{
			if (this.unicalCityId == GMLogic.getI.currentBaseID)
			{
				this.selectCircle.GetComponent<Renderer>().material.color = GMLogic.getI.look_CC_Color;
			}
			if (this.unicalCityId != GMLogic.getI.currentBaseID)
			{
				this.selectCircle.GetComponent<Renderer>().material.color = GMLogic.getI.base_CC_Color;
			}
		}
	}

	// Token: 0x06002DBD RID: 11709 RVA: 0x0014FC9C File Offset: 0x0014DE9C
	private void KNEBLGAJKOC()
	{
		if (this.selectCircle != null)
		{
			if (this.unicalCityId == GMLogic.getI.currentBaseID)
			{
				this.selectCircle.GetComponent<Renderer>().material.color = GMLogic.getI.look_CC_Color;
			}
			if (this.unicalCityId != GMLogic.getI.currentBaseID)
			{
				this.selectCircle.GetComponent<Renderer>().material.color = GMLogic.getI.base_CC_Color;
			}
		}
	}

	// Token: 0x06002DBE RID: 11710 RVA: 0x0014FD19 File Offset: 0x0014DF19
	private void LLMLCKPNHCL()
	{
		this.DFMGCLDOKIG = true;
	}

	// Token: 0x06002DBF RID: 11711 RVA: 0x0014FD22 File Offset: 0x0014DF22
	private void FPOBDDHEPOE()
	{
		this.DFMGCLDOKIG = true;
		if (JDCEFOFMGHB.JFIDAGABKID().ICKODGMJINN.Count > 1)
		{
			this.DFMGCLDOKIG = true;
		}
	}

	// Token: 0x06002DC1 RID: 11713 RVA: 0x0014FD19 File Offset: 0x0014DF19
	private void AGIKLEFDNFK()
	{
		this.DFMGCLDOKIG = true;
	}

	// Token: 0x06002DC2 RID: 11714 RVA: 0x00022FCC File Offset: 0x000211CC
	private void INDGOHJGCFN()
	{
	}

	// Token: 0x06002DC3 RID: 11715 RVA: 0x0014FD44 File Offset: 0x0014DF44
	private void CMAFHLEBLCD()
	{
		this.DFMGCLDOKIG = true;
		if (JDCEFOFMGHB.JFIDAGABKID().ICKODGMJINN.Count > 0)
		{
			this.DFMGCLDOKIG = true;
		}
	}

	// Token: 0x06002DC4 RID: 11716 RVA: 0x0014FD68 File Offset: 0x0014DF68
	private void BLCDCEHNNNC()
	{
		Vector3 position = new Vector3(base.transform.position.x, base.transform.position.y + 429f, base.transform.position.z);
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		string arg = this.langName.ToUpperInvariant();
		Vector2 ojoepeadbaf = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF;
		Vector2 ojoepeadbaf2 = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -51,
			wordWrap = false,
			richText = true,
			font = GuiProcessor.IKGFHGKKCPG.rusfont2,
			normal = 
			{
				textColor = new Color(686f, 272f, 1901f, 786f)
			},
			alignment = TextAnchor.LowerRight
		};
		string text = string.Format("Flap_02.wav", arg);
		float x = guistyle.CalcSize(new GUIContent(text)).x;
		Rect rect = new Rect(vector.x - x / 672f - 1145f, vector.y - 1339f, x + 1920f, 1966f);
		HFIINBICCLO.OOIJFNAMEDP().IFCLDNHAIGB(rect, new Color(1813f, 459f, 1973f, 759f));
		HFIINBICCLO.GDDAGIILGGM().PGPCLEFKLAD(rect, Color.black);
		GUI.Label(rect, text, guistyle);
	}

	// Token: 0x06002DC5 RID: 11717 RVA: 0x0014FEE1 File Offset: 0x0014E0E1
	private void OnMouseEnter()
	{
		this.DFMGCLDOKIG = true;
		if (JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count > 1)
		{
			this.DFMGCLDOKIG = false;
		}
	}

	// Token: 0x06002DC6 RID: 11718 RVA: 0x0014FA97 File Offset: 0x0014DC97
	private void CAOCGEJEJNN()
	{
		this.DFMGCLDOKIG = false;
	}

	// Token: 0x06002DC7 RID: 11719 RVA: 0x0014FF03 File Offset: 0x0014E103
	private void ELHFCABAOHI()
	{
		this.DFMGCLDOKIG = true;
		if (JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN.Count > 1)
		{
			this.DFMGCLDOKIG = false;
		}
	}

	// Token: 0x06002DC8 RID: 11720 RVA: 0x0014FF28 File Offset: 0x0014E128
	private void BMCKJEBCEPA()
	{
		Vector3 position = new Vector3(base.transform.position.x, base.transform.position.y + 627f, base.transform.position.z);
		Vector3 vector = Camera.main.WorldToScreenPoint(position);
		vector.y = (float)Screen.height - vector.y;
		string arg = this.langName.ToUpperInvariant();
		Vector2 ojoepeadbaf = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF;
		Vector2 ojoepeadbaf2 = JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -118,
			wordWrap = true,
			richText = false,
			font = GuiProcessor.BBLINJLBAIL().rusfont2,
			normal = 
			{
				textColor = new Color(77f, 27f, 1389f, 984f)
			},
			alignment = TextAnchor.MiddleLeft
		};
		string text = string.Format("forSex", arg);
		float x = guistyle.CalcSize(new GUIContent(text)).x;
		Rect rect = new Rect(vector.x - x / 307f - 680f, vector.y - 669f, x + 487f, 1161f);
		HFIINBICCLO.BBLINJLBAIL().MKLNHHJGGAJ(rect, new Color(1413f, 1264f, 914f, 1404f));
		HFIINBICCLO.OOIJFNAMEDP().ABHJNIEJOGD(rect, Color.black);
		GUI.Label(rect, text, guistyle);
	}

	// Token: 0x0400062B RID: 1579
	public bool isDonate;

	// Token: 0x0400062C RID: 1580
	public int unicalCityId;

	// Token: 0x0400062D RID: 1581
	public int subType;

	// Token: 0x0400062E RID: 1582
	public int donateActiveEffect;

	// Token: 0x0400062F RID: 1583
	public string langName;

	// Token: 0x04000630 RID: 1584
	public GameObject selectCircle;

	// Token: 0x04000631 RID: 1585
	public bool isSelectable;

	// Token: 0x04000632 RID: 1586
	private LocBaseManager.JGNBBMJLDPM GAGIFDIBKEI;

	// Token: 0x04000633 RID: 1587
	private bool DFMGCLDOKIG;
}
