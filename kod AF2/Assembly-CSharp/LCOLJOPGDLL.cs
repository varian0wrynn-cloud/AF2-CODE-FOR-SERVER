using System;
using UnityEngine;

// Token: 0x020001A9 RID: 425
public class LCOLJOPGDLL : ONKDCGNBALK
{
	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06005ECF RID: 24271 RVA: 0x002C6611 File Offset: 0x002C4811
	// (set) Token: 0x06005EEF RID: 24303 RVA: 0x002C6619 File Offset: 0x002C4819
	public Color LBCGACKJCJB
	{
		get
		{
			return this.EDGLFKODKBE;
		}
		set
		{
			this.EDGLFKODKBE = value;
			this.JMNAEPGEICL = true;
		}
	}

	// Token: 0x06005ED0 RID: 24272 RVA: 0x002C6619 File Offset: 0x002C4819
	public void EBMGNGGPGLG(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = true;
	}

	// Token: 0x06005ED1 RID: 24273 RVA: 0x002C6629 File Offset: 0x002C4829
	public string HEJCCNBBPNA()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005ED2 RID: 24274 RVA: 0x002C6631 File Offset: 0x002C4831
	public void MOFACMDBGEB(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = false;
	}

	// Token: 0x06005ED3 RID: 24275 RVA: 0x002C6641 File Offset: 0x002C4841
	public void LKGMDFCGOBG(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005ED4 RID: 24276 RVA: 0x002C664C File Offset: 0x002C484C
	public LCOLJOPGDLL(ONKDCGNBALK OCBAOFLJBGP, float POFBHAEFJNE, float AIIFDJADHJP, string DPANHMGCBNL, bool OMIFOCPDKIB = true) : base(OCBAOFLJBGP, POFBHAEFJNE, AIIFDJADHJP, 400f, 22f, DPANHMGCBNL, 0, 5)
	{
		this.KNIOGNKKINO = 5;
		this.IJCEDOGBHKE = DPANHMGCBNL;
		this.DEKGJCBMCHG = TextAnchor.UpperLeft;
		this.LBCGACKJCJB = Color.black;
		this.JMNAEPGEICL = true;
		this.LNDPBNODFPE = OMIFOCPDKIB;
		this.DFIGKKMMIAF = 12;
		this.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
	}

	// Token: 0x06005ED5 RID: 24277 RVA: 0x002C6641 File Offset: 0x002C4841
	public void IBNDDDLHBML(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005ED6 RID: 24278 RVA: 0x002C6641 File Offset: 0x002C4841
	public void AFOBLNNIEEJ(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005ED7 RID: 24279 RVA: 0x002C6629 File Offset: 0x002C4829
	public string EBFMOIKLDBO()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005ED8 RID: 24280 RVA: 0x002C6629 File Offset: 0x002C4829
	public string MFCFIPICGNA()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005ED9 RID: 24281 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color ANIALNBLHIF()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005EDA RID: 24282 RVA: 0x002C66CC File Offset: 0x002C48CC
	public virtual void MPFNCLBOKPH(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.BPCBPMDOEBA())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = false;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.JFIDAGABKID().ALKAAKDPCDG(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005EDB RID: 24283 RVA: 0x002C6629 File Offset: 0x002C4829
	public string LHPJHHJGEKO()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005EDC RID: 24284 RVA: 0x002C6629 File Offset: 0x002C4829
	public string ENOODIBMKMF()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005EDD RID: 24285 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color MIJAPAKMPKB()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005EDE RID: 24286 RVA: 0x002C6641 File Offset: 0x002C4841
	public void BMAMECMNDBO(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005EDF RID: 24287 RVA: 0x002C6629 File Offset: 0x002C4829
	public string BEICGBMNHJD()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005EE0 RID: 24288 RVA: 0x002C6629 File Offset: 0x002C4829
	public string EKMCDIFKNDO()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005EE1 RID: 24289 RVA: 0x002C6629 File Offset: 0x002C4829
	public string PLHABPDBEHG()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005EE2 RID: 24290 RVA: 0x002C6631 File Offset: 0x002C4831
	public void GEDEJKFHALD(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = false;
	}

	// Token: 0x06005EE3 RID: 24291 RVA: 0x002C67B0 File Offset: 0x002C49B0
	public virtual void OECNEDDNMGC(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.MAKPMJNMMAJ())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = true;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005EE4 RID: 24292 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color BPCBPMDOEBA()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005EE5 RID: 24293 RVA: 0x002C6641 File Offset: 0x002C4841
	public void HEGBCJBPHEH(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005EE6 RID: 24294 RVA: 0x002C6894 File Offset: 0x002C4A94
	public virtual void ALMIBDPAIHE(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.FMMOFJDIAJN())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = true;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.HMJJPNDEKPP().ALKAAKDPCDG(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005EE7 RID: 24295 RVA: 0x002C6629 File Offset: 0x002C4829
	public string GBIBJLNOOAD()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005EE8 RID: 24296 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color BHLDAIFKGKO()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005EE9 RID: 24297 RVA: 0x002C6978 File Offset: 0x002C4B78
	public virtual void ENCCJFKCHIE(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.FMMOFJDIAJN())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = false;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.ALKAAKDPCDG(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005EEA RID: 24298 RVA: 0x002C6629 File Offset: 0x002C4829
	public string BMDKKDEJFPN()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005EEB RID: 24299 RVA: 0x002C6A5C File Offset: 0x002C4C5C
	public virtual void BCLGMIJEAJL(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.BMHILMGOICK())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = false;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.JFIDAGABKID().ALKAAKDPCDG(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005EEC RID: 24300 RVA: 0x002C6B40 File Offset: 0x002C4D40
	public virtual void LKNFIMJJPPO(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.JPADAMDGOEF())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = true;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.HMJJPNDEKPP().JNJDPKECONL(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005EED RID: 24301 RVA: 0x002C6C24 File Offset: 0x002C4E24
	public LCOLJOPGDLL(ONKDCGNBALK OCBAOFLJBGP, float POFBHAEFJNE, float AIIFDJADHJP, string DPANHMGCBNL, bool OMIFOCPDKIB, Color FAODPFDPCLH) : base(OCBAOFLJBGP, POFBHAEFJNE, AIIFDJADHJP, 400f, 22f, DPANHMGCBNL, 0, 5)
	{
		this.KNIOGNKKINO = 5;
		this.IJCEDOGBHKE = DPANHMGCBNL;
		this.DEKGJCBMCHG = TextAnchor.UpperLeft;
		this.LBCGACKJCJB = FAODPFDPCLH;
		this.JMNAEPGEICL = true;
		this.LNDPBNODFPE = OMIFOCPDKIB;
		this.DFIGKKMMIAF = 12;
		this.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
	}

	// Token: 0x06005EEE RID: 24302 RVA: 0x002C6631 File Offset: 0x002C4831
	public void GABBMJPJAOO(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = false;
	}

	// Token: 0x06005EF0 RID: 24304 RVA: 0x002C6CA0 File Offset: 0x002C4EA0
	public virtual void KCHEILEJGPL(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.NHHLBMJNKEC())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = false;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.HMJJPNDEKPP().ALKAAKDPCDG(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005EF1 RID: 24305 RVA: 0x002C6D84 File Offset: 0x002C4F84
	public virtual void NEJHDECOINE(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.BMKFHFAAMNC())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = false;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.JFIDAGABKID().JNJDPKECONL(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005EF2 RID: 24306 RVA: 0x002C6629 File Offset: 0x002C4829
	public string HEDDFEPGOPK()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005EF3 RID: 24307 RVA: 0x002C6641 File Offset: 0x002C4841
	public void MFFGAOLFFLI(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005EF4 RID: 24308 RVA: 0x002C6E68 File Offset: 0x002C5068
	public virtual void DLBGNLEIMPB(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.BHLDAIFKGKO())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = true;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.JFIDAGABKID().ALKAAKDPCDG(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005EF5 RID: 24309 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color APBHDPNHCOJ()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x06005EF6 RID: 24310 RVA: 0x002C6629 File Offset: 0x002C4829
	// (set) Token: 0x06005F2B RID: 24363 RVA: 0x002C6641 File Offset: 0x002C4841
	public string FPIHOPOCAHA
	{
		get
		{
			return this.IJCEDOGBHKE;
		}
		set
		{
			this.IJCEDOGBHKE = value;
		}
	}

	// Token: 0x06005EF7 RID: 24311 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color IJGMEBMOLAL()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005EF8 RID: 24312 RVA: 0x002C6F4C File Offset: 0x002C514C
	public virtual void BIDJEHMBJAK(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.KAIIKNKNCON())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = true;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.JFIDAGABKID().ALKAAKDPCDG(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005EF9 RID: 24313 RVA: 0x002C6641 File Offset: 0x002C4841
	public void LEGHEJEDFBI(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005EFA RID: 24314 RVA: 0x002C6641 File Offset: 0x002C4841
	public void FNBPGKNNHPA(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005EFB RID: 24315 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color OJFHNMHPHHB()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005EFC RID: 24316 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color NONIMODPKKH()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005EFD RID: 24317 RVA: 0x002C6619 File Offset: 0x002C4819
	public void CKMAIBLGPHC(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = true;
	}

	// Token: 0x06005EFE RID: 24318 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color JPADAMDGOEF()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005EFF RID: 24319 RVA: 0x002C6631 File Offset: 0x002C4831
	public void GHCCIOAJFIH(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = false;
	}

	// Token: 0x06005F00 RID: 24320 RVA: 0x002C6619 File Offset: 0x002C4819
	public void PDCJMCLDNBA(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = true;
	}

	// Token: 0x06005F01 RID: 24321 RVA: 0x002C7030 File Offset: 0x002C5230
	public virtual void BBJPPDGJGLK(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.GHPJCGAEJAL())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = false;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.MNJNNDHCDGG().JNJDPKECONL(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005F02 RID: 24322 RVA: 0x002C6629 File Offset: 0x002C4829
	public string OBDPMLNFCBG()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F03 RID: 24323 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color KAIIKNKNCON()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005F04 RID: 24324 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color KKECGMCLNCO()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005F05 RID: 24325 RVA: 0x002C6629 File Offset: 0x002C4829
	public string INJHMGJDCIG()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F06 RID: 24326 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color MEMGGANPHGI()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005F07 RID: 24327 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color DLFENIBMGHB()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005F08 RID: 24328 RVA: 0x002C6631 File Offset: 0x002C4831
	public void GDFICJKDCDO(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = false;
	}

	// Token: 0x06005F09 RID: 24329 RVA: 0x002C6631 File Offset: 0x002C4831
	public void ELFEMMEBOGG(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = false;
	}

	// Token: 0x06005F0A RID: 24330 RVA: 0x002C6631 File Offset: 0x002C4831
	public void BNGNMFHLKAL(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = false;
	}

	// Token: 0x06005F0B RID: 24331 RVA: 0x002C6641 File Offset: 0x002C4841
	public void GNEDDOALEGF(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F0C RID: 24332 RVA: 0x002C6641 File Offset: 0x002C4841
	public void NBIEOFJEMKM(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F0D RID: 24333 RVA: 0x002C6629 File Offset: 0x002C4829
	public string FKHKFEIMHPA()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F0E RID: 24334 RVA: 0x002C6641 File Offset: 0x002C4841
	public void DLNFAELJBGG(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F0F RID: 24335 RVA: 0x002C7114 File Offset: 0x002C5314
	public virtual void GONDOLEPIGL(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.KKECGMCLNCO())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = false;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.MNJNNDHCDGG().ALKAAKDPCDG(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005F10 RID: 24336 RVA: 0x002C6641 File Offset: 0x002C4841
	public void GMCLHMMIBDM(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F11 RID: 24337 RVA: 0x002C71F8 File Offset: 0x002C53F8
	public virtual void AGFPCNIBKFN(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.IJGMEBMOLAL())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = true;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.JFIDAGABKID().JNJDPKECONL(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005F12 RID: 24338 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color FMMOFJDIAJN()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005F13 RID: 24339 RVA: 0x002C6641 File Offset: 0x002C4841
	public void JAJCDAGJBII(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F14 RID: 24340 RVA: 0x002C72DC File Offset: 0x002C54DC
	public LCOLJOPGDLL(ONKDCGNBALK OCBAOFLJBGP, float POFBHAEFJNE, float AIIFDJADHJP, float CGHAOFGOEFI, float GGAEPDHOCEC, string DPANHMGCBNL, TextAnchor GOHBJIDJFAH, Color ANMONOAPCJA) : base(OCBAOFLJBGP, POFBHAEFJNE, AIIFDJADHJP, CGHAOFGOEFI, GGAEPDHOCEC, DPANHMGCBNL, 0, 5)
	{
		this.KNIOGNKKINO = 5;
		this.IJCEDOGBHKE = DPANHMGCBNL;
		this.DEKGJCBMCHG = GOHBJIDJFAH;
		this.LBCGACKJCJB = ANMONOAPCJA;
		this.JMNAEPGEICL = true;
		this.DFIGKKMMIAF = 12;
		this.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
	}

	// Token: 0x06005F15 RID: 24341 RVA: 0x002C6641 File Offset: 0x002C4841
	public void OMEENABNNDK(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F16 RID: 24342 RVA: 0x002C6619 File Offset: 0x002C4819
	public void BMGMCLKBMAB(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = true;
	}

	// Token: 0x06005F17 RID: 24343 RVA: 0x002C6619 File Offset: 0x002C4819
	public void COMKBPKOCIO(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = true;
	}

	// Token: 0x06005F18 RID: 24344 RVA: 0x002C6619 File Offset: 0x002C4819
	public void JJDELGHAKBP(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = true;
	}

	// Token: 0x06005F19 RID: 24345 RVA: 0x002C6629 File Offset: 0x002C4829
	public string IPDHFMHHKDI()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F1A RID: 24346 RVA: 0x002C6629 File Offset: 0x002C4829
	public string POEKPNMHDIA()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F1B RID: 24347 RVA: 0x002C734C File Offset: 0x002C554C
	public virtual void CIGCFHLCMPB(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.DIOIMGGGBOE())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = false;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.ALKAAKDPCDG(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005F1C RID: 24348 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color BMHILMGOICK()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005F1D RID: 24349 RVA: 0x002C6619 File Offset: 0x002C4819
	public void IJBDFDFDIPJ(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = true;
	}

	// Token: 0x06005F1E RID: 24350 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color DIOIMGGGBOE()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005F1F RID: 24351 RVA: 0x002C6629 File Offset: 0x002C4829
	public string ODJBKPKGGPE()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F20 RID: 24352 RVA: 0x002C6629 File Offset: 0x002C4829
	public string KHBGOACIACG()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F21 RID: 24353 RVA: 0x002C6631 File Offset: 0x002C4831
	public void LIFOLOPHEPH(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = false;
	}

	// Token: 0x06005F22 RID: 24354 RVA: 0x002C6641 File Offset: 0x002C4841
	public void KIEJALOBCBB(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F23 RID: 24355 RVA: 0x002C6631 File Offset: 0x002C4831
	public void CECODLIGPHP(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = false;
	}

	// Token: 0x06005F24 RID: 24356 RVA: 0x002C7430 File Offset: 0x002C5630
	public virtual void LMJOMDDIKKK(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.LBCGACKJCJB)
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = false;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.HMJJPNDEKPP().ALKAAKDPCDG(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005F25 RID: 24357 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color OHCEJMBLJBF()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005F26 RID: 24358 RVA: 0x002C6629 File Offset: 0x002C4829
	public string MEHFNPOPLNI()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F27 RID: 24359 RVA: 0x002C7514 File Offset: 0x002C5714
	public virtual void NJCFBDPPKOB(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.APBHDPNHCOJ())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = true;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.JFIDAGABKID().ALKAAKDPCDG(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005F28 RID: 24360 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color HHPDNHHOLIJ()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005F29 RID: 24361 RVA: 0x002C6619 File Offset: 0x002C4819
	public void HKMFEIMFMAI(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = true;
	}

	// Token: 0x06005F2A RID: 24362 RVA: 0x002C6619 File Offset: 0x002C4819
	public void DLCECAKHLDD(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = true;
	}

	// Token: 0x06005F2C RID: 24364 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color IOLDHBFNEDD()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005F2D RID: 24365 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color GHPJCGAEJAL()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005F2E RID: 24366 RVA: 0x002C6619 File Offset: 0x002C4819
	public void HPCBLPIAHMI(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = true;
	}

	// Token: 0x06005F2F RID: 24367 RVA: 0x002C6629 File Offset: 0x002C4829
	public string OPBGLFAGGJC()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F30 RID: 24368 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color MAKPMJNMMAJ()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005F31 RID: 24369 RVA: 0x002C75F8 File Offset: 0x002C57F8
	public virtual void BFHPJCKICCE(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.BHLDAIFKGKO())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = false;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.ALKAAKDPCDG(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005F32 RID: 24370 RVA: 0x002C6629 File Offset: 0x002C4829
	public string IPMDLIFLINA()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F33 RID: 24371 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color CODDLCPGIOC()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005F34 RID: 24372 RVA: 0x002C6641 File Offset: 0x002C4841
	public void DJMCGBJDIIJ(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F35 RID: 24373 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color HGCINDKOLLG()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005F36 RID: 24374 RVA: 0x002C76DC File Offset: 0x002C58DC
	public virtual void JAGNNAKCJMK(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.BPCBPMDOEBA())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = true;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005F37 RID: 24375 RVA: 0x002C6629 File Offset: 0x002C4829
	public string HJDKEKMMAPJ()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F38 RID: 24376 RVA: 0x002C77C0 File Offset: 0x002C59C0
	public virtual void EGKHIENICMJ(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.MIJAPAKMPKB())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = false;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.HMJJPNDEKPP().ALKAAKDPCDG(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005F39 RID: 24377 RVA: 0x002C6641 File Offset: 0x002C4841
	public void LCELAFPJLMA(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F3A RID: 24378 RVA: 0x002C6641 File Offset: 0x002C4841
	public void HGMEJGKFBIK(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F3B RID: 24379 RVA: 0x002C78A4 File Offset: 0x002C5AA4
	public override void HFJFBDPNCCB(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.LBCGACKJCJB)
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = true;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005F3C RID: 24380 RVA: 0x002C6629 File Offset: 0x002C4829
	public string OHEBBGBGJHB()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F3D RID: 24381 RVA: 0x002C6641 File Offset: 0x002C4841
	public void JCLMALMIBIO(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F3E RID: 24382 RVA: 0x002C6629 File Offset: 0x002C4829
	public string BDHFHCMFJNB()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F3F RID: 24383 RVA: 0x002C6641 File Offset: 0x002C4841
	public void HGFGOMIHCJK(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F40 RID: 24384 RVA: 0x002C6631 File Offset: 0x002C4831
	public void AOOCNBCBKGN(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = false;
	}

	// Token: 0x06005F41 RID: 24385 RVA: 0x002C6631 File Offset: 0x002C4831
	public void CALCPHKKDMO(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = false;
	}

	// Token: 0x06005F42 RID: 24386 RVA: 0x002C6629 File Offset: 0x002C4829
	public string BMGLHPCLLAD()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F43 RID: 24387 RVA: 0x002C6641 File Offset: 0x002C4841
	public void IIMDMCFPCNB(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F44 RID: 24388 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color FMNPIMMFPEG()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005F45 RID: 24389 RVA: 0x002C7988 File Offset: 0x002C5B88
	public virtual void GFCAFLELBAK(bool CFMPGCJMHJM)
	{
		GUI.skin.label.alignment = this.DEKGJCBMCHG;
		if (this.JMNAEPGEICL)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = (this.LNDPBNODFPE ? Color.black : this.MEMGGANPHGI())
				},
				alignment = this.DEKGJCBMCHG
			};
			guistyle.fontSize = this.DFIGKKMMIAF;
			guistyle.font = this.HOBLHFPJKFA;
			guistyle.wordWrap = false;
			guistyle.richText = this.LNDPBNODFPE;
			if (this.DIPMPPLBELB)
			{
				JDCEFOFMGHB.HMJJPNDEKPP().JNJDPKECONL(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			else
			{
				GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE, guistyle);
			}
			if (this.DDPBIINJABJ)
			{
				this.JDNBDIPLPPO = GUILayoutUtility.GetLastRect();
				return;
			}
		}
		else
		{
			GUI.Label(this.OCHCODJIPHJ, this.IJCEDOGBHKE);
		}
	}

	// Token: 0x06005F46 RID: 24390 RVA: 0x002C6641 File Offset: 0x002C4841
	public void IGELPAEBJLM(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F47 RID: 24391 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color NHHLBMJNKEC()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005F48 RID: 24392 RVA: 0x002C6611 File Offset: 0x002C4811
	public Color BMKFHFAAMNC()
	{
		return this.EDGLFKODKBE;
	}

	// Token: 0x06005F49 RID: 24393 RVA: 0x002C6641 File Offset: 0x002C4841
	public void CAIMFOFBEII(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F4A RID: 24394 RVA: 0x002C6619 File Offset: 0x002C4819
	public void JJOIHBLMFNE(Color DCCPCBLODIG)
	{
		this.EDGLFKODKBE = DCCPCBLODIG;
		this.JMNAEPGEICL = true;
	}

	// Token: 0x06005F4B RID: 24395 RVA: 0x002C6641 File Offset: 0x002C4841
	public void JMEEHBLINMK(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F4C RID: 24396 RVA: 0x002C6641 File Offset: 0x002C4841
	public void JBBMLKHCAHG(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F4D RID: 24397 RVA: 0x002C7A6C File Offset: 0x002C5C6C
	public LCOLJOPGDLL(ONKDCGNBALK OCBAOFLJBGP, float POFBHAEFJNE, float AIIFDJADHJP, float CGHAOFGOEFI, float GGAEPDHOCEC, string DPANHMGCBNL, TextAnchor GOHBJIDJFAH, Color ANMONOAPCJA, bool HAPMIGNKLBM) : base(OCBAOFLJBGP, POFBHAEFJNE, AIIFDJADHJP, CGHAOFGOEFI, GGAEPDHOCEC, DPANHMGCBNL, 0, 5)
	{
		this.KNIOGNKKINO = 5;
		this.IJCEDOGBHKE = DPANHMGCBNL;
		this.DEKGJCBMCHG = GOHBJIDJFAH;
		this.LBCGACKJCJB = ANMONOAPCJA;
		this.JMNAEPGEICL = true;
		this.DIPMPPLBELB = HAPMIGNKLBM;
		this.DFIGKKMMIAF = 12;
		this.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
	}

	// Token: 0x06005F4E RID: 24398 RVA: 0x002C6629 File Offset: 0x002C4829
	public string IJHCAOPJDND()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F4F RID: 24399 RVA: 0x002C6629 File Offset: 0x002C4829
	public string JNHGPNIFPPN()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F50 RID: 24400 RVA: 0x002C6629 File Offset: 0x002C4829
	public string HAMLGFHDGLF()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F51 RID: 24401 RVA: 0x002C6629 File Offset: 0x002C4829
	public string GJEAPJHFDJI()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F52 RID: 24402 RVA: 0x002C6641 File Offset: 0x002C4841
	public void ENNIMCJCCCJ(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F53 RID: 24403 RVA: 0x002C6641 File Offset: 0x002C4841
	public void BNJBKEDEPOL(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x06005F54 RID: 24404 RVA: 0x002C6629 File Offset: 0x002C4829
	public string FDLKLFEMEPE()
	{
		return this.IJCEDOGBHKE;
	}

	// Token: 0x06005F55 RID: 24405 RVA: 0x002C6641 File Offset: 0x002C4841
	public void NFKFOIDNBNL(string DCCPCBLODIG)
	{
		this.IJCEDOGBHKE = DCCPCBLODIG;
	}

	// Token: 0x04000DD8 RID: 3544
	private string IJCEDOGBHKE = "";

	// Token: 0x04000DD9 RID: 3545
	private bool JMNAEPGEICL;

	// Token: 0x04000DDA RID: 3546
	private readonly TextAnchor DEKGJCBMCHG;

	// Token: 0x04000DDB RID: 3547
	private Color EDGLFKODKBE;

	// Token: 0x04000DDC RID: 3548
	private readonly bool DIPMPPLBELB;

	// Token: 0x04000DDD RID: 3549
	public int DFIGKKMMIAF;

	// Token: 0x04000DDE RID: 3550
	public Font HOBLHFPJKFA;

	// Token: 0x04000DDF RID: 3551
	public bool LNDPBNODFPE = true;

	// Token: 0x04000DE0 RID: 3552
	public bool DDPBIINJABJ;

	// Token: 0x04000DE1 RID: 3553
	public Rect JDNBDIPLPPO;

	// Token: 0x04000DE2 RID: 3554
	public string NOFPHJDJNFL;
}
