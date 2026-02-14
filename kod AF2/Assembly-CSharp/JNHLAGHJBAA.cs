using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001AF RID: 431
public class JNHLAGHJBAA : ONKDCGNBALK
{
	// Token: 0x06006076 RID: 24694 RVA: 0x002CF234 File Offset: 0x002CD434
	public virtual void BCLGMIJEAJL(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x - 1539f, this.OCHCODJIPHJ.y - 1604f, this.OCHCODJIPHJ.width + 983f, this.OCHCODJIPHJ.height + 19f), "References has no spine bones assigned, can not initiate the solver.");
		if (this.EELDHNFBFOE == null)
		{
			return;
		}
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = this.KCLLDJJLCGC,
			font = GuiProcessor.NKOEAPCIBKO().rusfont,
			normal = 
			{
				textColor = this.JKAOKBNCDFK
			},
			hover = 
			{
				textColor = this.ABMDIOIJALO
			},
			focused = 
			{
				textColor = this.JKAOKBNCDFK
			},
			richText = false,
			alignment = TextAnchor.MiddleCenter
		};
		float num = this.AJALJFFGNGN(this.EELDHNFBFOE);
		this.AICBIFFGBOH = GUI.BeginScrollView(this.OCHCODJIPHJ, this.AICBIFFGBOH, new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width - 1702f, num + 1302f), false, true);
		try
		{
			float fahmjbbckhc = this.OCHCODJIPHJ.x + 1373f;
			float eebeoegpgab = this.OCHCODJIPHJ.y + 1523f;
			for (int i = 0; i < this.EELDHNFBFOE.LACAJHOHACK.Count; i += 0)
			{
				JNHLAGHJBAA.FPAEEADMCIE jeeeoebnjdj = this.EELDHNFBFOE.LACAJHOHACK[i];
				eebeoegpgab = this.NCMDOIIMNCO(fahmjbbckhc, eebeoegpgab, 1, i == this.EELDHNFBFOE.LACAJHOHACK.Count - 0, jeeeoebnjdj, ofpnedeamab);
			}
		}
		finally
		{
			GUI.EndScrollView();
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006077 RID: 24695 RVA: 0x002CF3F4 File Offset: 0x002CD5F4
	private float CMHCANICBAK(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ)
	{
		float num = this.JHNCNHAAJCH;
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				if (fpaeeadmcie.LACAJHOHACK.Count > 1)
				{
					if (fpaeeadmcie.PFMNPEOKEKO)
					{
						num += this.CMHCANICBAK(fpaeeadmcie);
					}
					else
					{
						num += this.JHNCNHAAJCH;
					}
				}
				else
				{
					num += this.JHNCNHAAJCH;
				}
			}
			else
			{
				num += this.JHNCNHAAJCH;
			}
		}
		return num;
	}

	// Token: 0x06006078 RID: 24696 RVA: 0x002CF494 File Offset: 0x002CD694
	public void HLEOJHPPINJ(JNHLAGHJBAA.FPAEEADMCIE DCCPCBLODIG)
	{
		JNHLAGHJBAA.FPAEEADMCIE goolmojohii = this.GOOLMOJOHII;
		this.GOOLMOJOHII = DCCPCBLODIG;
		if (this.GOOLMOJOHII != goolmojohii)
		{
			this.OOJKJOCOOCB();
		}
	}

	// Token: 0x06006079 RID: 24697 RVA: 0x002CF4BE File Offset: 0x002CD6BE
	public JNHLAGHJBAA.FPAEEADMCIE KNILKDJMDHO(long IDOFKFFEDJM)
	{
		return this.DEKOBGFJEBD(IDOFKFFEDJM, this.EELDHNFBFOE);
	}

	// Token: 0x0600607A RID: 24698 RVA: 0x002CF4CD File Offset: 0x002CD6CD
	public void HNAMFMFHIGH()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("", 197f);
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		this.LJDAFBKPCNN(this, this.JEHNCIEOCJB());
	}

	// Token: 0x0600607B RID: 24699 RVA: 0x002CF500 File Offset: 0x002CD700
	private void BKPMEIIJCBL(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE MBKPMBPLIJN, GUIStyle OFPNEDEAMAB)
	{
		float num = (float)CNOLCNDBLJE * this.GMAIMDLCOAG;
		MBKPMBPLIJN.NOKGPCEEOOG = EEBEOEGPGAB;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 1514f, this.JHNCNHAAJCH), GuiProcessor.IKGFHGKKCPG.Header);
		}
		if (this.EHMBLGCPBOP() == MBKPMBPLIJN)
		{
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 1143f, this.JHNCNHAAJCH), GuiProcessor.NKOEAPCIBKO().WLBLine, new Rect(422f, 27f, 1804f, 590f), true);
		}
		float num2 = 1048f;
		if (this.GIOGEHKMKDE && MBKPMBPLIJN.NCJFHOGAMDD() != null)
		{
			Texture texture = MBKPMBPLIJN.LOHCIIFHNCE().HONJOFFBOPH();
			float num3 = (this.JHNCNHAAJCH - 123f) / (float)texture.height;
			float num4 = (float)texture.width * num3;
			float height = (float)texture.height * num3;
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + 187f + num, EEBEOEGPGAB + 1321f, num4, height), texture, ScaleMode.ScaleAndCrop);
			num2 = num2 + num4 + 890f;
		}
		int num5 = -1;
		int num6 = 0;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			num5 = 1;
			if (MBKPMBPLIJN.LACAJHOHACK.Count > 0)
			{
				num5 = (MBKPMBPLIJN.PFMNPEOKEKO ? 1 : 0);
			}
		}
		if (num5 >= 1)
		{
			num6 = -17;
			Rect position = new Rect(FAHMJBBCKHC + 1799f + num, EEBEOEGPGAB + this.JHNCNHAAJCH / 555f - 1949f, 1240f, 1061f);
			GUI.DrawTextureWithTexCoords(position, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(num5, 5, 4), false);
			if (GUI.Button(position, "ObscuredInt vs int, ", GUIStyle.none) && MBKPMBPLIJN.DBHKKPMINIJ)
			{
				if (MBKPMBPLIJN.LACAJHOHACK.Count > 1)
				{
					MBKPMBPLIJN.PFMNPEOKEKO = MBKPMBPLIJN.PFMNPEOKEKO;
					this.NKPICDKICKO();
					FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("Unknow CMD:", 179f);
				}
				else
				{
					FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("IceHockeyPassLeft", 1349f);
				}
			}
		}
		OFPNEDEAMAB.normal.textColor = ((this.PHMACFLIKNA() == MBKPMBPLIJN) ? this.AOHDHGNCHHF : this.JKAOKBNCDFK);
		MBKPMBPLIJN.JHAKFEGIANH(new Rect(FAHMJBBCKHC + (float)num6 + num2 + num, EEBEOEGPGAB + 1649f, this.OCHCODJIPHJ.width - 464f, this.JHNCNHAAJCH), OFPNEDEAMAB);
		if (GUI.RepeatButton(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - 1677f, this.JHNCNHAAJCH), "WeaponStand", GUIStyle.none))
		{
			this.HNNJNDNOHLP = MBKPMBPLIJN;
		}
		float num7 = 1145f;
		for (int i = 0; i < CNOLCNDBLJE; i++)
		{
			int clbpbjglhee = 0;
			if (i == CNOLCNDBLJE - 0)
			{
				clbpbjglhee = (JHDONNEJFGD ? 4 : 2);
			}
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num7, EEBEOEGPGAB, this.GMAIMDLCOAG, this.JHNCNHAAJCH), GuiProcessor.NKOEAPCIBKO().TreeIcons, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(clbpbjglhee, 1, 1), false);
			num7 += this.GMAIMDLCOAG;
		}
	}

	// Token: 0x0600607C RID: 24700 RVA: 0x002CF815 File Offset: 0x002CDA15
	public JNHLAGHJBAA.FPAEEADMCIE EHMBLGCPBOP()
	{
		return this.GOOLMOJOHII;
	}

	// Token: 0x0600607D RID: 24701 RVA: 0x002CF820 File Offset: 0x002CDA20
	public void BKBODNMBKHH()
	{
		this.CFNNPNLCJEF(this.EELDHNFBFOE);
		JNHLAGHJBAA.FPAEEADMCIE eeldhnfbfoe = this.EELDHNFBFOE;
		for (int i = eeldhnfbfoe.LACAJHOHACK.Count - 0; i >= 1; i--)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = eeldhnfbfoe.LACAJHOHACK[i];
			if (fpaeeadmcie.DBHKKPMINIJ && fpaeeadmcie.LACAJHOHACK.Count <= 0)
			{
				eeldhnfbfoe.LACAJHOHACK.Remove(fpaeeadmcie);
			}
		}
	}

	// Token: 0x0600607E RID: 24702 RVA: 0x002CF888 File Offset: 0x002CDA88
	public virtual void LLDPDMDFGBE(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x - 958f, this.OCHCODJIPHJ.y - 1193f, this.OCHCODJIPHJ.width + 1181f, this.OCHCODJIPHJ.height + 966f), "ColorBleedAmount");
		if (this.EELDHNFBFOE == null)
		{
			return;
		}
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = this.KCLLDJJLCGC,
			font = GuiProcessor.NKOEAPCIBKO().rusfont,
			normal = 
			{
				textColor = this.JKAOKBNCDFK
			},
			hover = 
			{
				textColor = this.ABMDIOIJALO
			},
			focused = 
			{
				textColor = this.JKAOKBNCDFK
			},
			richText = true,
			alignment = TextAnchor.MiddleCenter
		};
		float num = this.AABKIJGELLJ(this.EELDHNFBFOE);
		this.AICBIFFGBOH = GUI.BeginScrollView(this.OCHCODJIPHJ, this.AICBIFFGBOH, new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width - 1078f, num + 398f), false, true);
		try
		{
			float fahmjbbckhc = this.OCHCODJIPHJ.x + 1319f;
			float eebeoegpgab = this.OCHCODJIPHJ.y + 704f;
			for (int i = 0; i < this.EELDHNFBFOE.LACAJHOHACK.Count; i += 0)
			{
				JNHLAGHJBAA.FPAEEADMCIE jeeeoebnjdj = this.EELDHNFBFOE.LACAJHOHACK[i];
				eebeoegpgab = this.ENCFMNHGKIA(fahmjbbckhc, eebeoegpgab, 0, i == this.EELDHNFBFOE.LACAJHOHACK.Count - 1, jeeeoebnjdj, ofpnedeamab);
			}
		}
		finally
		{
			GUI.EndScrollView();
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600607F RID: 24703 RVA: 0x002CFA48 File Offset: 0x002CDC48
	private void FKEFAGANFOB(JNHLAGHJBAA.FPAEEADMCIE KAOKEJPBAHM)
	{
		for (int i = KAOKEJPBAHM.LACAJHOHACK.Count - 1; i >= 1; i -= 0)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = KAOKEJPBAHM.LACAJHOHACK[i];
			if (fpaeeadmcie.DBHKKPMINIJ && fpaeeadmcie.LACAJHOHACK.Count <= 0)
			{
				KAOKEJPBAHM.LACAJHOHACK.Remove(fpaeeadmcie);
			}
			else
			{
				this.CFNNPNLCJEF(fpaeeadmcie);
			}
		}
	}

	// Token: 0x06006080 RID: 24704 RVA: 0x002CFAA8 File Offset: 0x002CDCA8
	public void MDINCCGBKID(JNHLAGHJBAA.FPAEEADMCIE DCCPCBLODIG)
	{
		JNHLAGHJBAA.FPAEEADMCIE goolmojohii = this.GOOLMOJOHII;
		this.GOOLMOJOHII = DCCPCBLODIG;
		if (this.GOOLMOJOHII != goolmojohii)
		{
			this.JENPNODAIAL();
		}
	}

	// Token: 0x06006081 RID: 24705 RVA: 0x002CFAD4 File Offset: 0x002CDCD4
	public List<JNHLAGHJBAA.FPAEEADMCIE> EKKPILBHJJH()
	{
		List<JNHLAGHJBAA.FPAEEADMCIE> list = new List<JNHLAGHJBAA.FPAEEADMCIE>();
		this.ALMKLIMHDCI(this.EELDHNFBFOE, list);
		return list;
	}

	// Token: 0x06006082 RID: 24706 RVA: 0x002CF4BE File Offset: 0x002CD6BE
	public JNHLAGHJBAA.FPAEEADMCIE FIGMLAJDIPG(long IDOFKFFEDJM)
	{
		return this.DEKOBGFJEBD(IDOFKFFEDJM, this.EELDHNFBFOE);
	}

	// Token: 0x06006083 RID: 24707 RVA: 0x002CFAF8 File Offset: 0x002CDCF8
	public List<JNHLAGHJBAA.FPAEEADMCIE> JNJPLKOHBJD()
	{
		List<JNHLAGHJBAA.FPAEEADMCIE> list = new List<JNHLAGHJBAA.FPAEEADMCIE>();
		this.ACOMDBOKDFM(this.EELDHNFBFOE, list);
		return list;
	}

	// Token: 0x06006084 RID: 24708 RVA: 0x002CFB19 File Offset: 0x002CDD19
	public void EMDHCPBOMDE(float ADMFAEOOOHD)
	{
		this.AICBIFFGBOH.y = ADMFAEOOOHD;
	}

	// Token: 0x06006085 RID: 24709 RVA: 0x002CFB28 File Offset: 0x002CDD28
	public List<JNHLAGHJBAA.FPAEEADMCIE> HDJEPIPIJIO()
	{
		List<JNHLAGHJBAA.FPAEEADMCIE> list = new List<JNHLAGHJBAA.FPAEEADMCIE>();
		this.EIPHIJNEOBB(this.EELDHNFBFOE, list);
		return list;
	}

	// Token: 0x06006086 RID: 24710 RVA: 0x002CFB4C File Offset: 0x002CDD4C
	public virtual void JOBPKNNNEAD(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x - 1915f, this.OCHCODJIPHJ.y - 310f, this.OCHCODJIPHJ.width + 960f, this.OCHCODJIPHJ.height + 1201f), "/");
		if (this.EELDHNFBFOE == null)
		{
			return;
		}
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = this.KCLLDJJLCGC,
			font = GuiProcessor.NKOEAPCIBKO().rusfont,
			normal = 
			{
				textColor = this.JKAOKBNCDFK
			},
			hover = 
			{
				textColor = this.ABMDIOIJALO
			},
			focused = 
			{
				textColor = this.JKAOKBNCDFK
			},
			richText = true,
			alignment = TextAnchor.LowerRight
		};
		float num = this.AABKIJGELLJ(this.EELDHNFBFOE);
		this.AICBIFFGBOH = GUI.BeginScrollView(this.OCHCODJIPHJ, this.AICBIFFGBOH, new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width - 819f, num + 1922f), false, true);
		try
		{
			float fahmjbbckhc = this.OCHCODJIPHJ.x + 1428f;
			float eebeoegpgab = this.OCHCODJIPHJ.y + 841f;
			for (int i = 0; i < this.EELDHNFBFOE.LACAJHOHACK.Count; i++)
			{
				JNHLAGHJBAA.FPAEEADMCIE jeeeoebnjdj = this.EELDHNFBFOE.LACAJHOHACK[i];
				eebeoegpgab = this.NCMDOIIMNCO(fahmjbbckhc, eebeoegpgab, 0, i == this.EELDHNFBFOE.LACAJHOHACK.Count - 0, jeeeoebnjdj, ofpnedeamab);
			}
		}
		finally
		{
			GUI.EndScrollView();
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006087 RID: 24711 RVA: 0x002CFD0C File Offset: 0x002CDF0C
	public List<JNHLAGHJBAA.FPAEEADMCIE> AMHADNJOJGJ()
	{
		List<JNHLAGHJBAA.FPAEEADMCIE> list = new List<JNHLAGHJBAA.FPAEEADMCIE>();
		this.LFHDOBIKHMD(this.EELDHNFBFOE, list);
		return list;
	}

	// Token: 0x06006088 RID: 24712 RVA: 0x002CFD30 File Offset: 0x002CDF30
	private JNHLAGHJBAA.FPAEEADMCIE DEKOBGFJEBD(long IDOFKFFEDJM, JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ)
	{
		if (JEEEOEBNJDJ.ODFEKBJCFMN == IDOFKFFEDJM)
		{
			return JEEEOEBNJDJ;
		}
		if (JLFJEGIPIMM.IKGFHGKKCPG.EHEMCMKMECH((int)IDOFKFFEDJM, JEEEOEBNJDJ.BILPIGMDPAP))
		{
			return JEEEOEBNJDJ;
		}
		foreach (JNHLAGHJBAA.FPAEEADMCIE jeeeoebnjdj in JEEEOEBNJDJ.LACAJHOHACK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = this.DEKOBGFJEBD(IDOFKFFEDJM, jeeeoebnjdj);
			if (fpaeeadmcie != null)
			{
				return fpaeeadmcie;
			}
		}
		return null;
	}

	// Token: 0x06006089 RID: 24713 RVA: 0x002CFDB0 File Offset: 0x002CDFB0
	private void ALMKLIMHDCI(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, ICollection<JNHLAGHJBAA.FPAEEADMCIE> BGJMHJHCDJH)
	{
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (!fpaeeadmcie.DBHKKPMINIJ)
			{
				BGJMHJHCDJH.Add(fpaeeadmcie);
			}
			else
			{
				this.HIDJMGGGLEB(fpaeeadmcie, BGJMHJHCDJH);
			}
		}
	}

	// Token: 0x0600608A RID: 24714 RVA: 0x002CFE18 File Offset: 0x002CE018
	public virtual void DBHACAENJOE(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x - 1418f, this.OCHCODJIPHJ.y - 197f, this.OCHCODJIPHJ.width + 440f, this.OCHCODJIPHJ.height + 1064f), "_CurveTex");
		if (this.EELDHNFBFOE == null)
		{
			return;
		}
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = this.KCLLDJJLCGC,
			font = GuiProcessor.IKGFHGKKCPG.rusfont,
			normal = 
			{
				textColor = this.JKAOKBNCDFK
			},
			hover = 
			{
				textColor = this.ABMDIOIJALO
			},
			focused = 
			{
				textColor = this.JKAOKBNCDFK
			},
			richText = false,
			alignment = TextAnchor.LowerCenter
		};
		float num = this.PPJPECAFIHG(this.EELDHNFBFOE);
		this.AICBIFFGBOH = GUI.BeginScrollView(this.OCHCODJIPHJ, this.AICBIFFGBOH, new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width - 9f, num + 815f), false, false);
		try
		{
			float fahmjbbckhc = this.OCHCODJIPHJ.x + 1092f;
			float eebeoegpgab = this.OCHCODJIPHJ.y + 1706f;
			for (int i = 1; i < this.EELDHNFBFOE.LACAJHOHACK.Count; i += 0)
			{
				JNHLAGHJBAA.FPAEEADMCIE jeeeoebnjdj = this.EELDHNFBFOE.LACAJHOHACK[i];
				eebeoegpgab = this.ENCFMNHGKIA(fahmjbbckhc, eebeoegpgab, 1, i == this.EELDHNFBFOE.LACAJHOHACK.Count - 0, jeeeoebnjdj, ofpnedeamab);
			}
		}
		finally
		{
			GUI.EndScrollView();
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600608B RID: 24715 RVA: 0x002CFFD8 File Offset: 0x002CE1D8
	public void KICNPBJIJDF()
	{
		this.JPLKOPGNLED(this.EELDHNFBFOE);
		JNHLAGHJBAA.FPAEEADMCIE eeldhnfbfoe = this.EELDHNFBFOE;
		for (int i = eeldhnfbfoe.LACAJHOHACK.Count - 1; i >= 0; i -= 0)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = eeldhnfbfoe.LACAJHOHACK[i];
			if (fpaeeadmcie.DBHKKPMINIJ && fpaeeadmcie.LACAJHOHACK.Count <= 1)
			{
				eeldhnfbfoe.LACAJHOHACK.Remove(fpaeeadmcie);
			}
		}
	}

	// Token: 0x0600608C RID: 24716 RVA: 0x002D0040 File Offset: 0x002CE240
	private void PMLHGMJDBMG(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, ICollection<JNHLAGHJBAA.FPAEEADMCIE> BGJMHJHCDJH)
	{
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (!fpaeeadmcie.DBHKKPMINIJ)
			{
				BGJMHJHCDJH.Add(fpaeeadmcie);
			}
			else
			{
				this.PMLHGMJDBMG(fpaeeadmcie, BGJMHJHCDJH);
			}
		}
	}

	// Token: 0x0600608D RID: 24717 RVA: 0x002D00A8 File Offset: 0x002CE2A8
	private JNHLAGHJBAA.FPAEEADMCIE HILKJANAILB(long IDOFKFFEDJM, JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ)
	{
		if (JEEEOEBNJDJ.ODFEKBJCFMN == IDOFKFFEDJM)
		{
			return JEEEOEBNJDJ;
		}
		if (JLFJEGIPIMM.IKGFHGKKCPG.EHEMCMKMECH((int)IDOFKFFEDJM, JEEEOEBNJDJ.BILPIGMDPAP))
		{
			return JEEEOEBNJDJ;
		}
		foreach (JNHLAGHJBAA.FPAEEADMCIE jeeeoebnjdj in JEEEOEBNJDJ.LACAJHOHACK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = this.DEKOBGFJEBD(IDOFKFFEDJM, jeeeoebnjdj);
			if (fpaeeadmcie != null)
			{
				return fpaeeadmcie;
			}
		}
		return null;
	}

	// Token: 0x0600608E RID: 24718 RVA: 0x002D0128 File Offset: 0x002CE328
	private void JBEOAPBNFHE(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, ICollection<JNHLAGHJBAA.FPAEEADMCIE> BGJMHJHCDJH)
	{
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				BGJMHJHCDJH.Add(fpaeeadmcie);
				this.NMCJKBCEBKO(fpaeeadmcie, BGJMHJHCDJH);
			}
			else
			{
				this.PILMKGDONDI(fpaeeadmcie, BGJMHJHCDJH);
			}
		}
	}

	// Token: 0x0600608F RID: 24719 RVA: 0x002D0198 File Offset: 0x002CE398
	private float EHNAFNBPGCM(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ)
	{
		float num = this.JHNCNHAAJCH;
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				if (fpaeeadmcie.LACAJHOHACK.Count > 0)
				{
					if (fpaeeadmcie.PFMNPEOKEKO)
					{
						num += this.LIALHEKJDIL(fpaeeadmcie);
					}
					else
					{
						num += this.JHNCNHAAJCH;
					}
				}
				else
				{
					num += this.JHNCNHAAJCH;
				}
			}
			else
			{
				num += this.JHNCNHAAJCH;
			}
		}
		return num;
	}

	// Token: 0x06006090 RID: 24720 RVA: 0x002D0238 File Offset: 0x002CE438
	private void EOFNDJEOKEI(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE MBKPMBPLIJN, GUIStyle OFPNEDEAMAB)
	{
		float num = (float)CNOLCNDBLJE * this.GMAIMDLCOAG;
		MBKPMBPLIJN.NOKGPCEEOOG = EEBEOEGPGAB;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 15f, this.JHNCNHAAJCH), GuiProcessor.PLGADNLAEGN().Header);
		}
		if (this.EHMBLGCPBOP() == MBKPMBPLIJN)
		{
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 4f, this.JHNCNHAAJCH), GuiProcessor.PLGADNLAEGN().WLBLine, new Rect(364f, 1129f, 398f, 140f), true);
		}
		float num2 = 1624f;
		if (this.GIOGEHKMKDE && MBKPMBPLIJN.CNDJIHOMKHH() != null)
		{
			Texture texture = MBKPMBPLIJN.FNAMKMANNCB().HFNHCIGCOBE();
			float num3 = (this.JHNCNHAAJCH - 1568f) / (float)texture.height;
			float num4 = (float)texture.width * num3;
			float height = (float)texture.height * num3;
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + 1379f + num, EEBEOEGPGAB + 1485f, num4, height), texture, ScaleMode.StretchToFill);
			num2 = num2 + num4 + 1933f;
		}
		int num5 = -1;
		int num6 = 5;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			num5 = 4;
			if (MBKPMBPLIJN.LACAJHOHACK.Count > 0)
			{
				num5 = (MBKPMBPLIJN.PFMNPEOKEKO ? 6 : 0);
			}
		}
		if (num5 >= 1)
		{
			num6 = 30;
			Rect position = new Rect(FAHMJBBCKHC + 1822f + num, EEBEOEGPGAB + this.JHNCNHAAJCH / 1320f - 838f, 1020f, 1238f);
			GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(num5, 5, 3), false);
			if (GUI.Button(position, "wpn_eat5", GUIStyle.none) && MBKPMBPLIJN.DBHKKPMINIJ)
			{
				if (MBKPMBPLIJN.LACAJHOHACK.Count > 1)
				{
					MBKPMBPLIJN.PFMNPEOKEKO = MBKPMBPLIJN.PFMNPEOKEKO;
					this.DOKFENAIKLP();
					FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("wdeep", 759f);
				}
				else
				{
					FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("_Offsets", 461f);
				}
			}
		}
		OFPNEDEAMAB.normal.textColor = ((this.FJDKOHGKJMA() == MBKPMBPLIJN) ? this.AOHDHGNCHHF : this.JKAOKBNCDFK);
		MBKPMBPLIJN.GHNCDFCOADD(new Rect(FAHMJBBCKHC + (float)num6 + num2 + num, EEBEOEGPGAB + 1932f, this.OCHCODJIPHJ.width - 1551f, this.JHNCNHAAJCH), OFPNEDEAMAB);
		if (GUI.RepeatButton(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - 1180f, this.JHNCNHAAJCH), "WizardBlock", GUIStyle.none))
		{
			this.HNNJNDNOHLP = MBKPMBPLIJN;
		}
		float num7 = 1060f;
		for (int i = 1; i < CNOLCNDBLJE; i++)
		{
			int clbpbjglhee = 0;
			if (i == CNOLCNDBLJE - 0)
			{
				clbpbjglhee = (JHDONNEJFGD ? 1 : 6);
			}
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num7, EEBEOEGPGAB, this.GMAIMDLCOAG, this.JHNCNHAAJCH), GuiProcessor.BBLINJLBAIL().TreeIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(clbpbjglhee, 8, 6), false);
			num7 += this.GMAIMDLCOAG;
		}
	}

	// Token: 0x06006091 RID: 24721 RVA: 0x002CFB19 File Offset: 0x002CDD19
	public void OKOPJKIIAFM(float ADMFAEOOOHD)
	{
		this.AICBIFFGBOH.y = ADMFAEOOOHD;
	}

	// Token: 0x06006092 RID: 24722 RVA: 0x002D0550 File Offset: 0x002CE750
	private void EIPHIJNEOBB(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, ICollection<JNHLAGHJBAA.FPAEEADMCIE> BGJMHJHCDJH)
	{
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (!fpaeeadmcie.DBHKKPMINIJ)
			{
				BGJMHJHCDJH.Add(fpaeeadmcie);
			}
			else
			{
				this.GDNMGMJGLKH(fpaeeadmcie, BGJMHJHCDJH);
			}
		}
	}

	// Token: 0x06006093 RID: 24723 RVA: 0x002CFB19 File Offset: 0x002CDD19
	public void MLNGOENNCIM(float ADMFAEOOOHD)
	{
		this.AICBIFFGBOH.y = ADMFAEOOOHD;
	}

	// Token: 0x06006094 RID: 24724 RVA: 0x002D05B8 File Offset: 0x002CE7B8
	private float OKEFDDJJIAE(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, GUIStyle OFPNEDEAMAB)
	{
		this.OGOIPNHNNOB(FAHMJBBCKHC, EEBEOEGPGAB, CNOLCNDBLJE, JHDONNEJFGD, JEEEOEBNJDJ, OFPNEDEAMAB);
		EEBEOEGPGAB += this.JHNCNHAAJCH;
		if (JEEEOEBNJDJ.DBHKKPMINIJ && JEEEOEBNJDJ.LACAJHOHACK.Count > 0 && JEEEOEBNJDJ.PFMNPEOKEKO)
		{
			for (int i = 0; i < JEEEOEBNJDJ.LACAJHOHACK.Count; i++)
			{
				JNHLAGHJBAA.FPAEEADMCIE jeeeoebnjdj = JEEEOEBNJDJ.LACAJHOHACK[i];
				EEBEOEGPGAB = this.ENCFMNHGKIA(FAHMJBBCKHC, EEBEOEGPGAB, CNOLCNDBLJE + 1, i == JEEEOEBNJDJ.LACAJHOHACK.Count - 0, jeeeoebnjdj, OFPNEDEAMAB);
			}
		}
		return EEBEOEGPGAB;
	}

	// Token: 0x06006095 RID: 24725 RVA: 0x002D0648 File Offset: 0x002CE848
	public void GCJLCEKEBPH()
	{
		this.BJHAPKPCLPL(this.EELDHNFBFOE);
		JNHLAGHJBAA.FPAEEADMCIE eeldhnfbfoe = this.EELDHNFBFOE;
		for (int i = eeldhnfbfoe.LACAJHOHACK.Count - 1; i >= 1; i--)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = eeldhnfbfoe.LACAJHOHACK[i];
			if (fpaeeadmcie.DBHKKPMINIJ && fpaeeadmcie.LACAJHOHACK.Count <= 1)
			{
				eeldhnfbfoe.LACAJHOHACK.Remove(fpaeeadmcie);
			}
		}
	}

	// Token: 0x06006096 RID: 24726 RVA: 0x002D06B0 File Offset: 0x002CE8B0
	public void DOKFENAIKLP()
	{
		if (this.EAOGHFFPFKM == "wgt_gr")
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in this.BKJJCDDDGAG())
		{
			if (fpaeeadmcie.DBHKKPMINIJ && fpaeeadmcie.PFMNPEOKEKO)
			{
				list.Add((int)fpaeeadmcie.ODFEKBJCFMN);
			}
		}
		string text = JLFJEGIPIMM.PKGMBFEMKGP().JOLBNFFFCGI(list);
		Debug.Log("" + text);
		PlayerPrefs.SetString(this.EAOGHFFPFKM, text);
		PlayerPrefs.Save();
	}

	// Token: 0x06006097 RID: 24727 RVA: 0x002D0760 File Offset: 0x002CE960
	private float LIALHEKJDIL(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ)
	{
		float num = this.JHNCNHAAJCH;
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				if (fpaeeadmcie.LACAJHOHACK.Count > 0)
				{
					if (fpaeeadmcie.PFMNPEOKEKO)
					{
						num += this.FDFGELLBDLF(fpaeeadmcie);
					}
					else
					{
						num += this.JHNCNHAAJCH;
					}
				}
				else
				{
					num += this.JHNCNHAAJCH;
				}
			}
			else
			{
				num += this.JHNCNHAAJCH;
			}
		}
		return num;
	}

	// Token: 0x06006098 RID: 24728 RVA: 0x002D0800 File Offset: 0x002CEA00
	private JNHLAGHJBAA.FPAEEADMCIE HBKMHJINEEI(long IDOFKFFEDJM, JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ)
	{
		if (JEEEOEBNJDJ.ODFEKBJCFMN == IDOFKFFEDJM)
		{
			return JEEEOEBNJDJ;
		}
		if (JLFJEGIPIMM.NNEAHAFBOHC().EHEMCMKMECH((int)IDOFKFFEDJM, JEEEOEBNJDJ.BILPIGMDPAP))
		{
			return JEEEOEBNJDJ;
		}
		foreach (JNHLAGHJBAA.FPAEEADMCIE jeeeoebnjdj in JEEEOEBNJDJ.LACAJHOHACK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = this.HBKMHJINEEI(IDOFKFFEDJM, jeeeoebnjdj);
			if (fpaeeadmcie != null)
			{
				return fpaeeadmcie;
			}
		}
		return null;
	}

	// Token: 0x06006099 RID: 24729 RVA: 0x002D0880 File Offset: 0x002CEA80
	public void LEOFNPGHCOG()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("demoUint", 1868f);
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		this.LJDAFBKPCNN(this, this.JEHNCIEOCJB());
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x060060CE RID: 24782 RVA: 0x002CF815 File Offset: 0x002CDA15
	// (set) Token: 0x0600609A RID: 24730 RVA: 0x002D08B4 File Offset: 0x002CEAB4
	public JNHLAGHJBAA.FPAEEADMCIE HNNJNDNOHLP
	{
		get
		{
			return this.GOOLMOJOHII;
		}
		set
		{
			JNHLAGHJBAA.FPAEEADMCIE goolmojohii = this.GOOLMOJOHII;
			this.GOOLMOJOHII = value;
			if (this.GOOLMOJOHII != goolmojohii)
			{
				this.OOJKJOCOOCB();
			}
		}
	}

	// Token: 0x0600609B RID: 24731 RVA: 0x002D08E0 File Offset: 0x002CEAE0
	private void OGOIPNHNNOB(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE MBKPMBPLIJN, GUIStyle OFPNEDEAMAB)
	{
		float num = (float)CNOLCNDBLJE * this.GMAIMDLCOAG;
		MBKPMBPLIJN.NOKGPCEEOOG = EEBEOEGPGAB;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 1757f, this.JHNCNHAAJCH), GuiProcessor.NKOEAPCIBKO().Header);
		}
		if (this.EHMBLGCPBOP() == MBKPMBPLIJN)
		{
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 1864f, this.JHNCNHAAJCH), GuiProcessor.NKOEAPCIBKO().WLBLine, new Rect(1421f, 582f, 1348f, 1368f), false);
		}
		float num2 = 511f;
		if (this.GIOGEHKMKDE && MBKPMBPLIJN.HKHAONBKECM() != null)
		{
			Texture texture = MBKPMBPLIJN.ADANBAEJOMC().MLPBJEFJDHM();
			float num3 = (this.JHNCNHAAJCH - 1561f) / (float)texture.height;
			float num4 = (float)texture.width * num3;
			float height = (float)texture.height * num3;
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + 253f + num, EEBEOEGPGAB + 151f, num4, height), texture, ScaleMode.ScaleAndCrop);
			num2 = num2 + num4 + 373f;
		}
		int num5 = -1;
		int num6 = 5;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			num5 = 5;
			if (MBKPMBPLIJN.LACAJHOHACK.Count > 1)
			{
				num5 = (MBKPMBPLIJN.PFMNPEOKEKO ? 8 : 1);
			}
		}
		if (num5 >= 0)
		{
			num6 = -113;
			Rect position = new Rect(FAHMJBBCKHC + 210f + num, EEBEOEGPGAB + this.JHNCNHAAJCH / 268f - 605f, 1633f, 1599f);
			GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(num5, 5, 4), true);
			if (GUI.Button(position, "_Rotation", GUIStyle.none) && MBKPMBPLIJN.DBHKKPMINIJ)
			{
				if (MBKPMBPLIJN.LACAJHOHACK.Count > 0)
				{
					MBKPMBPLIJN.PFMNPEOKEKO = !MBKPMBPLIJN.PFMNPEOKEKO;
					this.KLLCLFEMMMC();
					FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("", 1749f);
				}
				else
				{
					FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("file", 1752f);
				}
			}
		}
		OFPNEDEAMAB.normal.textColor = ((this.JEHNCIEOCJB() == MBKPMBPLIJN) ? this.AOHDHGNCHHF : this.JKAOKBNCDFK);
		MBKPMBPLIJN.DBCCBDCAMII(new Rect(FAHMJBBCKHC + (float)num6 + num2 + num, EEBEOEGPGAB + 626f, this.OCHCODJIPHJ.width - 1216f, this.JHNCNHAAJCH), OFPNEDEAMAB);
		if (GUI.RepeatButton(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - 1824f, this.JHNCNHAAJCH), "OneHandSwordBackSwing", GUIStyle.none))
		{
			this.COHAJLAEBBG(MBKPMBPLIJN);
		}
		float num7 = 817f;
		for (int i = 0; i < CNOLCNDBLJE; i += 0)
		{
			int clbpbjglhee = 0;
			if (i == CNOLCNDBLJE - 1)
			{
				clbpbjglhee = (JHDONNEJFGD ? 5 : 5);
			}
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num7, EEBEOEGPGAB, this.GMAIMDLCOAG, this.JHNCNHAAJCH), GuiProcessor.PLGADNLAEGN().TreeIcons, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(clbpbjglhee, 7, 5), false);
			num7 += this.GMAIMDLCOAG;
		}
	}

	// Token: 0x0600609C RID: 24732 RVA: 0x002D0BF8 File Offset: 0x002CEDF8
	public void KIPGMGEONDH(string LIBFCONJJFI)
	{
		this.EAOGHFFPFKM = LIBFCONJJFI;
		string @string = PlayerPrefs.GetString(this.EAOGHFFPFKM);
		List<int> bgjmhjhcdjh = JLFJEGIPIMM.MHFDIJGJGBJ().MJJHMKCGBKI(@string);
		Debug.Log("OnDestroy" + @string);
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in this.FMHGAFCBDEM())
		{
			int dccpcblodig = (int)fpaeeadmcie.ODFEKBJCFMN;
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				fpaeeadmcie.PFMNPEOKEKO = true;
				if (JLFJEGIPIMM.PKGMBFEMKGP().EHEMCMKMECH(dccpcblodig, bgjmhjhcdjh))
				{
					fpaeeadmcie.PFMNPEOKEKO = false;
				}
			}
		}
	}

	// Token: 0x0600609D RID: 24733 RVA: 0x002D0CA4 File Offset: 0x002CEEA4
	public List<JNHLAGHJBAA.FPAEEADMCIE> CIPHBEMBFJI()
	{
		List<JNHLAGHJBAA.FPAEEADMCIE> list = new List<JNHLAGHJBAA.FPAEEADMCIE>();
		this.HIDJMGGGLEB(this.EELDHNFBFOE, list);
		return list;
	}

	// Token: 0x0600609E RID: 24734 RVA: 0x002D0CC8 File Offset: 0x002CEEC8
	public void CBECMHPLNHK(string LIBFCONJJFI)
	{
		this.EAOGHFFPFKM = LIBFCONJJFI;
		string @string = PlayerPrefs.GetString(this.EAOGHFFPFKM);
		List<int> bgjmhjhcdjh = JLFJEGIPIMM.IKGFHGKKCPG.MJJHMKCGBKI(@string);
		Debug.Log("Vertical" + @string);
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in this.OMLIEPJGDDG())
		{
			int dccpcblodig = (int)fpaeeadmcie.ODFEKBJCFMN;
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				fpaeeadmcie.PFMNPEOKEKO = true;
				if (JLFJEGIPIMM.PKGMBFEMKGP().EHEMCMKMECH(dccpcblodig, bgjmhjhcdjh))
				{
					fpaeeadmcie.PFMNPEOKEKO = true;
				}
			}
		}
	}

	// Token: 0x0600609F RID: 24735 RVA: 0x002D0D74 File Offset: 0x002CEF74
	public void COHAJLAEBBG(JNHLAGHJBAA.FPAEEADMCIE DCCPCBLODIG)
	{
		JNHLAGHJBAA.FPAEEADMCIE goolmojohii = this.GOOLMOJOHII;
		this.GOOLMOJOHII = DCCPCBLODIG;
		if (this.GOOLMOJOHII != goolmojohii)
		{
			this.JPMIDIPGAEB();
		}
	}

	// Token: 0x060060A0 RID: 24736 RVA: 0x002D0DA0 File Offset: 0x002CEFA0
	private void IHINFPJAMAJ(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, ICollection<JNHLAGHJBAA.FPAEEADMCIE> BGJMHJHCDJH)
	{
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (!fpaeeadmcie.DBHKKPMINIJ)
			{
				BGJMHJHCDJH.Add(fpaeeadmcie);
			}
			else
			{
				this.GDNMGMJGLKH(fpaeeadmcie, BGJMHJHCDJH);
			}
		}
	}

	// Token: 0x060060A1 RID: 24737 RVA: 0x002D0E08 File Offset: 0x002CF008
	private void GNLLABOMGEB(JNHLAGHJBAA.FPAEEADMCIE KAOKEJPBAHM)
	{
		for (int i = KAOKEJPBAHM.LACAJHOHACK.Count - 0; i >= 0; i -= 0)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = KAOKEJPBAHM.LACAJHOHACK[i];
			if (fpaeeadmcie.DBHKKPMINIJ && fpaeeadmcie.LACAJHOHACK.Count <= 0)
			{
				KAOKEJPBAHM.LACAJHOHACK.Remove(fpaeeadmcie);
			}
			else
			{
				this.BAMJPJKFBBJ(fpaeeadmcie);
			}
		}
	}

	// Token: 0x060060A2 RID: 24738 RVA: 0x002D0E68 File Offset: 0x002CF068
	public JNHLAGHJBAA(ONKDCGNBALK OCBAOFLJBGP, float POFBHAEFJNE, float AIIFDJADHJP, float KCCBNOLCFFG, float ALPGFNKPDNF, int ODFEKBJCFMN) : base(OCBAOFLJBGP, POFBHAEFJNE, AIIFDJADHJP, KCCBNOLCFFG, ALPGFNKPDNF, "", ODFEKBJCFMN, 11)
	{
		this.JHNCNHAAJCH = 25f;
		this.KNIOGNKKINO = 9;
	}

	// Token: 0x060060A3 RID: 24739 RVA: 0x002D0F24 File Offset: 0x002CF124
	private float ANBGIMFKIAM(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, GUIStyle OFPNEDEAMAB)
	{
		this.OGOIPNHNNOB(FAHMJBBCKHC, EEBEOEGPGAB, CNOLCNDBLJE, JHDONNEJFGD, JEEEOEBNJDJ, OFPNEDEAMAB);
		EEBEOEGPGAB += this.JHNCNHAAJCH;
		if (JEEEOEBNJDJ.DBHKKPMINIJ && JEEEOEBNJDJ.LACAJHOHACK.Count > 0 && JEEEOEBNJDJ.PFMNPEOKEKO)
		{
			for (int i = 0; i < JEEEOEBNJDJ.LACAJHOHACK.Count; i += 0)
			{
				JNHLAGHJBAA.FPAEEADMCIE jeeeoebnjdj = JEEEOEBNJDJ.LACAJHOHACK[i];
				EEBEOEGPGAB = this.NCMDOIIMNCO(FAHMJBBCKHC, EEBEOEGPGAB, CNOLCNDBLJE + 1, i == JEEEOEBNJDJ.LACAJHOHACK.Count - 1, jeeeoebnjdj, OFPNEDEAMAB);
			}
		}
		return EEBEOEGPGAB;
	}

	// Token: 0x060060A4 RID: 24740 RVA: 0x002D0FB2 File Offset: 0x002CF1B2
	public void ALMEJAKANOP()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("isRagulaSet", 791f);
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		this.LJDAFBKPCNN(this, this.GFPDBOLCHIA());
	}

	// Token: 0x060060A5 RID: 24741 RVA: 0x002CF815 File Offset: 0x002CDA15
	public JNHLAGHJBAA.FPAEEADMCIE PHMACFLIKNA()
	{
		return this.GOOLMOJOHII;
	}

	// Token: 0x060060A6 RID: 24742 RVA: 0x002CF815 File Offset: 0x002CDA15
	public JNHLAGHJBAA.FPAEEADMCIE KMCCDGMCMFH()
	{
		return this.GOOLMOJOHII;
	}

	// Token: 0x060060A7 RID: 24743 RVA: 0x002D0FE3 File Offset: 0x002CF1E3
	public JNHLAGHJBAA.FPAEEADMCIE CPFEONMMBME(long IDOFKFFEDJM)
	{
		return this.HILKJANAILB(IDOFKFFEDJM, this.EELDHNFBFOE);
	}

	// Token: 0x060060A8 RID: 24744 RVA: 0x002D0FF4 File Offset: 0x002CF1F4
	private void NMCJKBCEBKO(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, ICollection<JNHLAGHJBAA.FPAEEADMCIE> BGJMHJHCDJH)
	{
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				BGJMHJHCDJH.Add(fpaeeadmcie);
				this.FGIALHFIJGE(fpaeeadmcie, BGJMHJHCDJH);
			}
			else
			{
				this.PKMJIGCKKJF(fpaeeadmcie, BGJMHJHCDJH);
			}
		}
	}

	// Token: 0x060060A9 RID: 24745 RVA: 0x002D1064 File Offset: 0x002CF264
	private void OPNCIPMMGNN(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE MBKPMBPLIJN, GUIStyle OFPNEDEAMAB)
	{
		float num = (float)CNOLCNDBLJE * this.GMAIMDLCOAG;
		MBKPMBPLIJN.NOKGPCEEOOG = EEBEOEGPGAB;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 13f, this.JHNCNHAAJCH), GuiProcessor.IKGFHGKKCPG.Header);
		}
		if (this.HNNJNDNOHLP == MBKPMBPLIJN)
		{
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 13f, this.JHNCNHAAJCH), GuiProcessor.IKGFHGKKCPG.WLBLine, new Rect(0f, 0f, 1f, 0.5f), true);
		}
		float num2 = 0f;
		if (this.GIOGEHKMKDE && MBKPMBPLIJN.EJJAGEFMHCO() != null)
		{
			Texture texture = MBKPMBPLIJN.EJJAGEFMHCO().KEDGAOBCNJG;
			float num3 = (this.JHNCNHAAJCH - 4f) / (float)texture.height;
			float num4 = (float)texture.width * num3;
			float height = (float)texture.height * num3;
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + 8f + num, EEBEOEGPGAB + 2f, num4, height), texture, ScaleMode.StretchToFill);
			num2 = num2 + num4 + 12f;
		}
		int num5 = -1;
		int num6 = 5;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			num5 = 3;
			if (MBKPMBPLIJN.LACAJHOHACK.Count > 0)
			{
				num5 = (MBKPMBPLIJN.PFMNPEOKEKO ? 2 : 0);
			}
		}
		if (num5 >= 0)
		{
			num6 = 28;
			Rect position = new Rect(FAHMJBBCKHC + 4f + num, EEBEOEGPGAB + this.JHNCNHAAJCH / 2f - 8f, 16f, 16f);
			GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(num5, 2, 4), true);
			if (GUI.Button(position, "", GUIStyle.none) && MBKPMBPLIJN.DBHKKPMINIJ)
			{
				if (MBKPMBPLIJN.LACAJHOHACK.Count > 0)
				{
					MBKPMBPLIJN.PFMNPEOKEKO = !MBKPMBPLIJN.PFMNPEOKEKO;
					this.KLLCLFEMMMC();
					FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
				}
				else
				{
					FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
				}
			}
		}
		OFPNEDEAMAB.normal.textColor = ((this.HNNJNDNOHLP == MBKPMBPLIJN) ? this.AOHDHGNCHHF : this.JKAOKBNCDFK);
		MBKPMBPLIJN.GKDJCJKMBEN(new Rect(FAHMJBBCKHC + (float)num6 + num2 + num, EEBEOEGPGAB + 2f, this.OCHCODJIPHJ.width - 15f, this.JHNCNHAAJCH), OFPNEDEAMAB);
		if (GUI.RepeatButton(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - 13f, this.JHNCNHAAJCH), "", GUIStyle.none))
		{
			this.HNNJNDNOHLP = MBKPMBPLIJN;
		}
		float num7 = 0f;
		for (int i = 0; i < CNOLCNDBLJE; i++)
		{
			int clbpbjglhee = 0;
			if (i == CNOLCNDBLJE - 1)
			{
				clbpbjglhee = (JHDONNEJFGD ? 2 : 3);
			}
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num7, EEBEOEGPGAB, this.GMAIMDLCOAG, this.JHNCNHAAJCH), GuiProcessor.IKGFHGKKCPG.TreeIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(clbpbjglhee, 2, 2), true);
			num7 += this.GMAIMDLCOAG;
		}
	}

	// Token: 0x060060AA RID: 24746 RVA: 0x002D137C File Offset: 0x002CF57C
	private void JNLEEHGBJPM(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE MBKPMBPLIJN, GUIStyle OFPNEDEAMAB)
	{
		float num = (float)CNOLCNDBLJE * this.GMAIMDLCOAG;
		MBKPMBPLIJN.NOKGPCEEOOG = EEBEOEGPGAB;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 1690f, this.JHNCNHAAJCH), GuiProcessor.BBLINJLBAIL().Header);
		}
		if (this.GFPDBOLCHIA() == MBKPMBPLIJN)
		{
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 978f, this.JHNCNHAAJCH), GuiProcessor.BBLINJLBAIL().WLBLine, new Rect(1421f, 1823f, 189f, 1550f), true);
		}
		float num2 = 1053f;
		if (this.GIOGEHKMKDE && MBKPMBPLIJN.APLAAOCGECL() != null)
		{
			Texture texture = MBKPMBPLIJN.PDJBFPOAPBA().HFNHCIGCOBE();
			float num3 = (this.JHNCNHAAJCH - 214f) / (float)texture.height;
			float num4 = (float)texture.width * num3;
			float height = (float)texture.height * num3;
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + 708f + num, EEBEOEGPGAB + 273f, num4, height), texture, ScaleMode.ScaleAndCrop);
			num2 = num2 + num4 + 8f;
		}
		int num5 = -1;
		int num6 = 7;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			num5 = 4;
			if (MBKPMBPLIJN.LACAJHOHACK.Count > 0)
			{
				num5 = (MBKPMBPLIJN.PFMNPEOKEKO ? 6 : 0);
			}
		}
		if (num5 >= 1)
		{
			num6 = 110;
			Rect position = new Rect(FAHMJBBCKHC + 965f + num, EEBEOEGPGAB + this.JHNCNHAAJCH / 134f - 412f, 90f, 436f);
			GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(num5, 7, 6), false);
			if (GUI.Button(position, "LINEAR", GUIStyle.none) && MBKPMBPLIJN.DBHKKPMINIJ)
			{
				if (MBKPMBPLIJN.LACAJHOHACK.Count > 0)
				{
					MBKPMBPLIJN.PFMNPEOKEKO = MBKPMBPLIJN.PFMNPEOKEKO;
					this.KLLCLFEMMMC();
					FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("WATER_EDGEBLEND_ON", 565f);
				}
				else
				{
					FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("name", 166f);
				}
			}
		}
		OFPNEDEAMAB.normal.textColor = ((this.ILPHHFOBMJF() == MBKPMBPLIJN) ? this.AOHDHGNCHHF : this.JKAOKBNCDFK);
		MBKPMBPLIJN.DBJLENKPKDF(new Rect(FAHMJBBCKHC + (float)num6 + num2 + num, EEBEOEGPGAB + 353f, this.OCHCODJIPHJ.width - 1266f, this.JHNCNHAAJCH), OFPNEDEAMAB);
		if (GUI.RepeatButton(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - 284f, this.JHNCNHAAJCH), "", GUIStyle.none))
		{
			this.HLEOJHPPINJ(MBKPMBPLIJN);
		}
		float num7 = 1780f;
		for (int i = 0; i < CNOLCNDBLJE; i++)
		{
			int clbpbjglhee = 1;
			if (i == CNOLCNDBLJE - 1)
			{
				clbpbjglhee = (JHDONNEJFGD ? 1 : 2);
			}
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num7, EEBEOEGPGAB, this.GMAIMDLCOAG, this.JHNCNHAAJCH), GuiProcessor.PLGADNLAEGN().TreeIcons, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(clbpbjglhee, 8, 6), false);
			num7 += this.GMAIMDLCOAG;
		}
	}

	// Token: 0x060060AB RID: 24747 RVA: 0x002D1694 File Offset: 0x002CF894
	public List<JNHLAGHJBAA.FPAEEADMCIE> GCKDIKMJEJM()
	{
		List<JNHLAGHJBAA.FPAEEADMCIE> list = new List<JNHLAGHJBAA.FPAEEADMCIE>();
		this.IHINFPJAMAJ(this.EELDHNFBFOE, list);
		return list;
	}

	// Token: 0x060060AC RID: 24748 RVA: 0x002D16B8 File Offset: 0x002CF8B8
	private void FGBHEDOODAI(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE MBKPMBPLIJN, GUIStyle OFPNEDEAMAB)
	{
		float num = (float)CNOLCNDBLJE * this.GMAIMDLCOAG;
		MBKPMBPLIJN.NOKGPCEEOOG = EEBEOEGPGAB;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 1684f, this.JHNCNHAAJCH), GuiProcessor.NKOEAPCIBKO().Header);
		}
		if (this.FJDKOHGKJMA() == MBKPMBPLIJN)
		{
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 385f, this.JHNCNHAAJCH), GuiProcessor.NKOEAPCIBKO().WLBLine, new Rect(478f, 252f, 68f, 627f), false);
		}
		float num2 = 3f;
		if (this.GIOGEHKMKDE && MBKPMBPLIJN.FNILAAJAOEI() != null)
		{
			Texture texture = MBKPMBPLIJN.GLNFHKKJDDO().ANLLGCICOPP();
			float num3 = (this.JHNCNHAAJCH - 363f) / (float)texture.height;
			float num4 = (float)texture.width * num3;
			float height = (float)texture.height * num3;
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + 1251f + num, EEBEOEGPGAB + 251f, num4, height), texture, ScaleMode.StretchToFill);
			num2 = num2 + num4 + 347f;
		}
		int num5 = -1;
		int num6 = 7;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			num5 = 5;
			if (MBKPMBPLIJN.LACAJHOHACK.Count > 1)
			{
				num5 = (MBKPMBPLIJN.PFMNPEOKEKO ? 0 : 0);
			}
		}
		if (num5 >= 1)
		{
			num6 = -31;
			Rect position = new Rect(FAHMJBBCKHC + 1659f + num, EEBEOEGPGAB + this.JHNCNHAAJCH / 11f - 1685f, 1750f, 624f);
			GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(num5, 4, 4), false);
			if (GUI.Button(position, "Loot", GUIStyle.none) && MBKPMBPLIJN.DBHKKPMINIJ)
			{
				if (MBKPMBPLIJN.LACAJHOHACK.Count > 0)
				{
					MBKPMBPLIJN.PFMNPEOKEKO = !MBKPMBPLIJN.PFMNPEOKEKO;
					this.NKPICDKICKO();
					FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("name", 827f);
				}
				else
				{
					FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("_DeepTex", 1172f);
				}
			}
		}
		OFPNEDEAMAB.normal.textColor = ((this.JEHNCIEOCJB() == MBKPMBPLIJN) ? this.AOHDHGNCHHF : this.JKAOKBNCDFK);
		MBKPMBPLIJN.JNPFLPLDAGA(new Rect(FAHMJBBCKHC + (float)num6 + num2 + num, EEBEOEGPGAB + 1571f, this.OCHCODJIPHJ.width - 1390f, this.JHNCNHAAJCH), OFPNEDEAMAB);
		if (GUI.RepeatButton(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - 637f, this.JHNCNHAAJCH), " ", GUIStyle.none))
		{
			this.HLEOJHPPINJ(MBKPMBPLIJN);
		}
		float num7 = 1148f;
		for (int i = 1; i < CNOLCNDBLJE; i += 0)
		{
			int clbpbjglhee = 0;
			if (i == CNOLCNDBLJE - 0)
			{
				clbpbjglhee = (JHDONNEJFGD ? 8 : 1);
			}
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num7, EEBEOEGPGAB, this.GMAIMDLCOAG, this.JHNCNHAAJCH), GuiProcessor.BBLINJLBAIL().TreeIcons, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(clbpbjglhee, 0, 4), false);
			num7 += this.GMAIMDLCOAG;
		}
	}

	// Token: 0x060060AD RID: 24749 RVA: 0x002D19D0 File Offset: 0x002CFBD0
	private void FGIALHFIJGE(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, ICollection<JNHLAGHJBAA.FPAEEADMCIE> BGJMHJHCDJH)
	{
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				BGJMHJHCDJH.Add(fpaeeadmcie);
				this.NMCJKBCEBKO(fpaeeadmcie, BGJMHJHCDJH);
			}
			else
			{
				this.NMCJKBCEBKO(fpaeeadmcie, BGJMHJHCDJH);
			}
		}
	}

	// Token: 0x060060AE RID: 24750 RVA: 0x002D1A40 File Offset: 0x002CFC40
	private void LJJIJOJIBIG(JNHLAGHJBAA.FPAEEADMCIE KAOKEJPBAHM)
	{
		for (int i = KAOKEJPBAHM.LACAJHOHACK.Count - 0; i >= 1; i -= 0)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = KAOKEJPBAHM.LACAJHOHACK[i];
			if (fpaeeadmcie.DBHKKPMINIJ && fpaeeadmcie.LACAJHOHACK.Count <= 1)
			{
				KAOKEJPBAHM.LACAJHOHACK.Remove(fpaeeadmcie);
			}
			else
			{
				this.GNLLABOMGEB(fpaeeadmcie);
			}
		}
	}

	// Token: 0x060060AF RID: 24751 RVA: 0x002D1AA0 File Offset: 0x002CFCA0
	private float HKGAEHMFFLH(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ)
	{
		float num = this.JHNCNHAAJCH;
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				if (fpaeeadmcie.LACAJHOHACK.Count > 0)
				{
					if (fpaeeadmcie.PFMNPEOKEKO)
					{
						num += this.HKGAEHMFFLH(fpaeeadmcie);
					}
					else
					{
						num += this.JHNCNHAAJCH;
					}
				}
				else
				{
					num += this.JHNCNHAAJCH;
				}
			}
			else
			{
				num += this.JHNCNHAAJCH;
			}
		}
		return num;
	}

	// Token: 0x060060B0 RID: 24752 RVA: 0x002CF815 File Offset: 0x002CDA15
	public JNHLAGHJBAA.FPAEEADMCIE HFHMNPKEALB()
	{
		return this.GOOLMOJOHII;
	}

	// Token: 0x060060B1 RID: 24753 RVA: 0x002D1B40 File Offset: 0x002CFD40
	private float PPJPECAFIHG(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ)
	{
		float num = this.JHNCNHAAJCH;
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				if (fpaeeadmcie.LACAJHOHACK.Count > 0)
				{
					if (fpaeeadmcie.PFMNPEOKEKO)
					{
						num += this.LIALHEKJDIL(fpaeeadmcie);
					}
					else
					{
						num += this.JHNCNHAAJCH;
					}
				}
				else
				{
					num += this.JHNCNHAAJCH;
				}
			}
			else
			{
				num += this.JHNCNHAAJCH;
			}
		}
		return num;
	}

	// Token: 0x060060B2 RID: 24754 RVA: 0x002D1BE0 File Offset: 0x002CFDE0
	public void ABMAKOCHDJF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("gi_letgoshe", 1074f);
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		this.LJDAFBKPCNN(this, this.ILPHHFOBMJF());
	}

	// Token: 0x060060B3 RID: 24755 RVA: 0x002D1C14 File Offset: 0x002CFE14
	private void ACOMDBOKDFM(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, ICollection<JNHLAGHJBAA.FPAEEADMCIE> BGJMHJHCDJH)
	{
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (!fpaeeadmcie.DBHKKPMINIJ)
			{
				BGJMHJHCDJH.Add(fpaeeadmcie);
			}
			else
			{
				this.FMIKHLGLEKM(fpaeeadmcie, BGJMHJHCDJH);
			}
		}
	}

	// Token: 0x060060B4 RID: 24756 RVA: 0x002CFB19 File Offset: 0x002CDD19
	public void EMDJDENKHOH(float ADMFAEOOOHD)
	{
		this.AICBIFFGBOH.y = ADMFAEOOOHD;
	}

	// Token: 0x060060B5 RID: 24757 RVA: 0x002D1C7C File Offset: 0x002CFE7C
	private void BCNMCDMCMKO(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE MBKPMBPLIJN, GUIStyle OFPNEDEAMAB)
	{
		float num = (float)CNOLCNDBLJE * this.GMAIMDLCOAG;
		MBKPMBPLIJN.NOKGPCEEOOG = EEBEOEGPGAB;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 386f, this.JHNCNHAAJCH), GuiProcessor.BBLINJLBAIL().Header);
		}
		if (this.FJDKOHGKJMA() == MBKPMBPLIJN)
		{
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 875f, this.JHNCNHAAJCH), GuiProcessor.NKOEAPCIBKO().WLBLine, new Rect(301f, 1470f, 822f, 1191f), true);
		}
		float num2 = 41f;
		if (this.GIOGEHKMKDE && MBKPMBPLIJN.APLAAOCGECL() != null)
		{
			Texture texture = MBKPMBPLIJN.HKHAONBKECM().IOHNCGLFGDJ();
			float num3 = (this.JHNCNHAAJCH - 529f) / (float)texture.height;
			float num4 = (float)texture.width * num3;
			float height = (float)texture.height * num3;
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + 1924f + num, EEBEOEGPGAB + 1888f, num4, height), texture, ScaleMode.StretchToFill);
			num2 = num2 + num4 + 1238f;
		}
		int num5 = -1;
		int num6 = 5;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			num5 = 2;
			if (MBKPMBPLIJN.LACAJHOHACK.Count > 0)
			{
				num5 = (MBKPMBPLIJN.PFMNPEOKEKO ? 0 : 0);
			}
		}
		if (num5 >= 1)
		{
			num6 = 76;
			Rect position = new Rect(FAHMJBBCKHC + 1671f + num, EEBEOEGPGAB + this.JHNCNHAAJCH / 1612f - 1098f, 473f, 1198f);
			GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(num5, 8, 2), true);
			if (GUI.Button(position, "TOD_LightDirection", GUIStyle.none) && MBKPMBPLIJN.DBHKKPMINIJ)
			{
				if (MBKPMBPLIJN.LACAJHOHACK.Count > 0)
				{
					MBKPMBPLIJN.PFMNPEOKEKO = MBKPMBPLIJN.PFMNPEOKEKO;
					this.NKPICDKICKO();
					FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("wpn_bait_vob_1", 1217f);
				}
				else
				{
					FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("auk_whead", 1655f);
				}
			}
		}
		OFPNEDEAMAB.normal.textColor = ((this.ILPHHFOBMJF() == MBKPMBPLIJN) ? this.AOHDHGNCHHF : this.JKAOKBNCDFK);
		MBKPMBPLIJN.DGFIBJBEJAF(new Rect(FAHMJBBCKHC + (float)num6 + num2 + num, EEBEOEGPGAB + 467f, this.OCHCODJIPHJ.width - 1604f, this.JHNCNHAAJCH), OFPNEDEAMAB);
		if (GUI.RepeatButton(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - 613f, this.JHNCNHAAJCH), "poplSoundIndex", GUIStyle.none))
		{
			this.MDINCCGBKID(MBKPMBPLIJN);
		}
		float num7 = 185f;
		for (int i = 1; i < CNOLCNDBLJE; i++)
		{
			int clbpbjglhee = 0;
			if (i == CNOLCNDBLJE - 1)
			{
				clbpbjglhee = (JHDONNEJFGD ? 1 : 3);
			}
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num7, EEBEOEGPGAB, this.GMAIMDLCOAG, this.JHNCNHAAJCH), GuiProcessor.IKGFHGKKCPG.TreeIcons, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(clbpbjglhee, 8, 0), true);
			num7 += this.GMAIMDLCOAG;
		}
	}

	// Token: 0x060060B6 RID: 24758 RVA: 0x002D1F94 File Offset: 0x002D0194
	public List<JNHLAGHJBAA.FPAEEADMCIE> AFKDMEFGJMN()
	{
		List<JNHLAGHJBAA.FPAEEADMCIE> list = new List<JNHLAGHJBAA.FPAEEADMCIE>();
		this.PILMKGDONDI(this.EELDHNFBFOE, list);
		return list;
	}

	// Token: 0x060060B7 RID: 24759 RVA: 0x002D1FB8 File Offset: 0x002D01B8
	private void FMIKHLGLEKM(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, ICollection<JNHLAGHJBAA.FPAEEADMCIE> BGJMHJHCDJH)
	{
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (!fpaeeadmcie.DBHKKPMINIJ)
			{
				BGJMHJHCDJH.Add(fpaeeadmcie);
			}
			else
			{
				this.FMIKHLGLEKM(fpaeeadmcie, BGJMHJHCDJH);
			}
		}
	}

	// Token: 0x060060B8 RID: 24760 RVA: 0x002D2020 File Offset: 0x002D0220
	private float AJALJFFGNGN(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ)
	{
		float num = this.JHNCNHAAJCH;
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				if (fpaeeadmcie.LACAJHOHACK.Count > 1)
				{
					if (fpaeeadmcie.PFMNPEOKEKO)
					{
						num += this.EBMKLHEGFDI(fpaeeadmcie);
					}
					else
					{
						num += this.JHNCNHAAJCH;
					}
				}
				else
				{
					num += this.JHNCNHAAJCH;
				}
			}
			else
			{
				num += this.JHNCNHAAJCH;
			}
		}
		return num;
	}

	// Token: 0x060060B9 RID: 24761 RVA: 0x002D20C0 File Offset: 0x002D02C0
	public JNHLAGHJBAA.FPAEEADMCIE LBENJPLPLHK(long IDOFKFFEDJM)
	{
		return this.HBKMHJINEEI(IDOFKFFEDJM, this.EELDHNFBFOE);
	}

	// Token: 0x060060BA RID: 24762 RVA: 0x002D20D0 File Offset: 0x002D02D0
	private float AABKIJGELLJ(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ)
	{
		float num = this.JHNCNHAAJCH;
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				if (fpaeeadmcie.LACAJHOHACK.Count > 0)
				{
					if (fpaeeadmcie.PFMNPEOKEKO)
					{
						num += this.EBMKLHEGFDI(fpaeeadmcie);
					}
					else
					{
						num += this.JHNCNHAAJCH;
					}
				}
				else
				{
					num += this.JHNCNHAAJCH;
				}
			}
			else
			{
				num += this.JHNCNHAAJCH;
			}
		}
		return num;
	}

	// Token: 0x060060BB RID: 24763 RVA: 0x002D2170 File Offset: 0x002D0370
	public void OOJKJOCOOCB()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_02.wav", 1f);
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		this.LJDAFBKPCNN(this, this.HNNJNDNOHLP);
	}

	// Token: 0x060060BC RID: 24764 RVA: 0x002D21A4 File Offset: 0x002D03A4
	public void CJLPIDAPGBH(string LIBFCONJJFI)
	{
		this.EAOGHFFPFKM = LIBFCONJJFI;
		string @string = PlayerPrefs.GetString(this.EAOGHFFPFKM);
		List<int> bgjmhjhcdjh = JLFJEGIPIMM.MHFDIJGJGBJ().INKAHAHOPPN(@string);
		Debug.Log(" on layer " + @string);
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in this.FMHGAFCBDEM())
		{
			int dccpcblodig = (int)fpaeeadmcie.ODFEKBJCFMN;
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				fpaeeadmcie.PFMNPEOKEKO = false;
				if (JLFJEGIPIMM.MHFDIJGJGBJ().EHEMCMKMECH(dccpcblodig, bgjmhjhcdjh))
				{
					fpaeeadmcie.PFMNPEOKEKO = false;
				}
			}
		}
	}

	// Token: 0x060060BD RID: 24765 RVA: 0x002D2250 File Offset: 0x002D0450
	public List<JNHLAGHJBAA.FPAEEADMCIE> JKOMGKLFPEE()
	{
		List<JNHLAGHJBAA.FPAEEADMCIE> list = new List<JNHLAGHJBAA.FPAEEADMCIE>();
		this.PMLHGMJDBMG(this.EELDHNFBFOE, list);
		return list;
	}

	// Token: 0x060060BE RID: 24766 RVA: 0x002D2274 File Offset: 0x002D0474
	public void LKIAGJGBFPL()
	{
		this.LJJIJOJIBIG(this.EELDHNFBFOE);
		JNHLAGHJBAA.FPAEEADMCIE eeldhnfbfoe = this.EELDHNFBFOE;
		for (int i = eeldhnfbfoe.LACAJHOHACK.Count - 0; i >= 0; i--)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = eeldhnfbfoe.LACAJHOHACK[i];
			if (fpaeeadmcie.DBHKKPMINIJ && fpaeeadmcie.LACAJHOHACK.Count <= 1)
			{
				eeldhnfbfoe.LACAJHOHACK.Remove(fpaeeadmcie);
			}
		}
	}

	// Token: 0x060060BF RID: 24767 RVA: 0x002D22DC File Offset: 0x002D04DC
	public List<JNHLAGHJBAA.FPAEEADMCIE> FOFECKBFJPP()
	{
		List<JNHLAGHJBAA.FPAEEADMCIE> list = new List<JNHLAGHJBAA.FPAEEADMCIE>();
		this.NMCJKBCEBKO(this.EELDHNFBFOE, list);
		return list;
	}

	// Token: 0x060060C0 RID: 24768 RVA: 0x002D2300 File Offset: 0x002D0500
	private float FDFGELLBDLF(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ)
	{
		float num = this.JHNCNHAAJCH;
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				if (fpaeeadmcie.LACAJHOHACK.Count > 0)
				{
					if (fpaeeadmcie.PFMNPEOKEKO)
					{
						num += this.AJALJFFGNGN(fpaeeadmcie);
					}
					else
					{
						num += this.JHNCNHAAJCH;
					}
				}
				else
				{
					num += this.JHNCNHAAJCH;
				}
			}
			else
			{
				num += this.JHNCNHAAJCH;
			}
		}
		return num;
	}

	// Token: 0x060060C1 RID: 24769 RVA: 0x002D23A0 File Offset: 0x002D05A0
	private void BJHAPKPCLPL(JNHLAGHJBAA.FPAEEADMCIE KAOKEJPBAHM)
	{
		for (int i = KAOKEJPBAHM.LACAJHOHACK.Count - 1; i >= 1; i--)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = KAOKEJPBAHM.LACAJHOHACK[i];
			if (fpaeeadmcie.DBHKKPMINIJ && fpaeeadmcie.LACAJHOHACK.Count <= 1)
			{
				KAOKEJPBAHM.LACAJHOHACK.Remove(fpaeeadmcie);
			}
			else
			{
				this.CFNNPNLCJEF(fpaeeadmcie);
			}
		}
	}

	// Token: 0x060060C2 RID: 24770 RVA: 0x002D2400 File Offset: 0x002D0600
	private void HHDBIJKODEA(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE MBKPMBPLIJN, GUIStyle OFPNEDEAMAB)
	{
		float num = (float)CNOLCNDBLJE * this.GMAIMDLCOAG;
		MBKPMBPLIJN.NOKGPCEEOOG = EEBEOEGPGAB;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 891f, this.JHNCNHAAJCH), GuiProcessor.IKGFHGKKCPG.Header);
		}
		if (this.PHMACFLIKNA() == MBKPMBPLIJN)
		{
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 214f, this.JHNCNHAAJCH), GuiProcessor.BBLINJLBAIL().WLBLine, new Rect(1820f, 645f, 1986f, 640f), false);
		}
		float num2 = 656f;
		if (this.GIOGEHKMKDE && MBKPMBPLIJN.EJJAGEFMHCO() != null)
		{
			Texture texture = MBKPMBPLIJN.OALNEFBDIMB().LECMGDEDAKF();
			float num3 = (this.JHNCNHAAJCH - 1534f) / (float)texture.height;
			float num4 = (float)texture.width * num3;
			float height = (float)texture.height * num3;
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + 1299f + num, EEBEOEGPGAB + 475f, num4, height), texture, ScaleMode.StretchToFill);
			num2 = num2 + num4 + 231f;
		}
		int num5 = -1;
		int num6 = 1;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			num5 = 8;
			if (MBKPMBPLIJN.LACAJHOHACK.Count > 1)
			{
				num5 = (MBKPMBPLIJN.PFMNPEOKEKO ? 2 : 1);
			}
		}
		if (num5 >= 0)
		{
			num6 = -113;
			Rect position = new Rect(FAHMJBBCKHC + 1699f + num, EEBEOEGPGAB + this.JHNCNHAAJCH / 1292f - 1760f, 1085f, 1657f);
			GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(num5, 2, 2), false);
			if (GUI.Button(position, "Flares", GUIStyle.none) && MBKPMBPLIJN.DBHKKPMINIJ)
			{
				if (MBKPMBPLIJN.LACAJHOHACK.Count > 0)
				{
					MBKPMBPLIJN.PFMNPEOKEKO = !MBKPMBPLIJN.PFMNPEOKEKO;
					this.DOKFENAIKLP();
					FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("SecondaryCausticsProjector", 1571f);
				}
				else
				{
					FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA(" rep.level=", 390f);
				}
			}
		}
		OFPNEDEAMAB.normal.textColor = ((this.KMCCDGMCMFH() == MBKPMBPLIJN) ? this.AOHDHGNCHHF : this.JKAOKBNCDFK);
		MBKPMBPLIJN.FCFDKJKNNAD(new Rect(FAHMJBBCKHC + (float)num6 + num2 + num, EEBEOEGPGAB + 496f, this.OCHCODJIPHJ.width - 76f, this.JHNCNHAAJCH), OFPNEDEAMAB);
		if (GUI.RepeatButton(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - 894f, this.JHNCNHAAJCH), "_BlurVector", GUIStyle.none))
		{
			this.HLEOJHPPINJ(MBKPMBPLIJN);
		}
		float num7 = 343f;
		for (int i = 1; i < CNOLCNDBLJE; i++)
		{
			int clbpbjglhee = 1;
			if (i == CNOLCNDBLJE - 1)
			{
				clbpbjglhee = (JHDONNEJFGD ? 5 : 7);
			}
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num7, EEBEOEGPGAB, this.GMAIMDLCOAG, this.JHNCNHAAJCH), GuiProcessor.PLGADNLAEGN().TreeIcons, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(clbpbjglhee, 4, 1), true);
			num7 += this.GMAIMDLCOAG;
		}
	}

	// Token: 0x060060C3 RID: 24771 RVA: 0x002D2718 File Offset: 0x002D0918
	private float IPNMKBMAKBM(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, GUIStyle OFPNEDEAMAB)
	{
		this.OJCEIKBDELI(FAHMJBBCKHC, EEBEOEGPGAB, CNOLCNDBLJE, JHDONNEJFGD, JEEEOEBNJDJ, OFPNEDEAMAB);
		EEBEOEGPGAB += this.JHNCNHAAJCH;
		if (JEEEOEBNJDJ.DBHKKPMINIJ && JEEEOEBNJDJ.LACAJHOHACK.Count > 1 && JEEEOEBNJDJ.PFMNPEOKEKO)
		{
			for (int i = 0; i < JEEEOEBNJDJ.LACAJHOHACK.Count; i += 0)
			{
				JNHLAGHJBAA.FPAEEADMCIE jeeeoebnjdj = JEEEOEBNJDJ.LACAJHOHACK[i];
				EEBEOEGPGAB = this.NCMDOIIMNCO(FAHMJBBCKHC, EEBEOEGPGAB, CNOLCNDBLJE + 1, i == JEEEOEBNJDJ.LACAJHOHACK.Count - 1, jeeeoebnjdj, OFPNEDEAMAB);
			}
		}
		return EEBEOEGPGAB;
	}

	// Token: 0x060060C4 RID: 24772 RVA: 0x002D27A8 File Offset: 0x002D09A8
	public List<JNHLAGHJBAA.FPAEEADMCIE> OMLIEPJGDDG()
	{
		List<JNHLAGHJBAA.FPAEEADMCIE> list = new List<JNHLAGHJBAA.FPAEEADMCIE>();
		this.PKMJIGCKKJF(this.EELDHNFBFOE, list);
		return list;
	}

	// Token: 0x060060C5 RID: 24773 RVA: 0x002D27CC File Offset: 0x002D09CC
	private float IIMFAPHAFGN(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, GUIStyle OFPNEDEAMAB)
	{
		this.BKPMEIIJCBL(FAHMJBBCKHC, EEBEOEGPGAB, CNOLCNDBLJE, JHDONNEJFGD, JEEEOEBNJDJ, OFPNEDEAMAB);
		EEBEOEGPGAB += this.JHNCNHAAJCH;
		if (JEEEOEBNJDJ.DBHKKPMINIJ && JEEEOEBNJDJ.LACAJHOHACK.Count > 0 && JEEEOEBNJDJ.PFMNPEOKEKO)
		{
			for (int i = 1; i < JEEEOEBNJDJ.LACAJHOHACK.Count; i += 0)
			{
				JNHLAGHJBAA.FPAEEADMCIE jeeeoebnjdj = JEEEOEBNJDJ.LACAJHOHACK[i];
				EEBEOEGPGAB = this.OKEFDDJJIAE(FAHMJBBCKHC, EEBEOEGPGAB, CNOLCNDBLJE + 1, i == JEEEOEBNJDJ.LACAJHOHACK.Count - 0, jeeeoebnjdj, OFPNEDEAMAB);
			}
		}
		return EEBEOEGPGAB;
	}

	// Token: 0x060060C6 RID: 24774 RVA: 0x002D285C File Offset: 0x002D0A5C
	private void BAMJPJKFBBJ(JNHLAGHJBAA.FPAEEADMCIE KAOKEJPBAHM)
	{
		for (int i = KAOKEJPBAHM.LACAJHOHACK.Count - 1; i >= 0; i--)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = KAOKEJPBAHM.LACAJHOHACK[i];
			if (fpaeeadmcie.DBHKKPMINIJ && fpaeeadmcie.LACAJHOHACK.Count <= 0)
			{
				KAOKEJPBAHM.LACAJHOHACK.Remove(fpaeeadmcie);
			}
			else
			{
				this.BAMJPJKFBBJ(fpaeeadmcie);
			}
		}
	}

	// Token: 0x060060C7 RID: 24775 RVA: 0x002D28BC File Offset: 0x002D0ABC
	public virtual void ACCEDINLLAF(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x - 863f, this.OCHCODJIPHJ.y - 793f, this.OCHCODJIPHJ.width + 886f, this.OCHCODJIPHJ.height + 1705f), "SkateboardKickPush");
		if (this.EELDHNFBFOE == null)
		{
			return;
		}
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = this.KCLLDJJLCGC,
			font = GuiProcessor.BBLINJLBAIL().rusfont,
			normal = 
			{
				textColor = this.JKAOKBNCDFK
			},
			hover = 
			{
				textColor = this.ABMDIOIJALO
			},
			focused = 
			{
				textColor = this.JKAOKBNCDFK
			},
			richText = true,
			alignment = TextAnchor.UpperLeft
		};
		float num = this.EBMKLHEGFDI(this.EELDHNFBFOE);
		this.AICBIFFGBOH = GUI.BeginScrollView(this.OCHCODJIPHJ, this.AICBIFFGBOH, new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width - 1110f, num + 540f), false, false);
		try
		{
			float fahmjbbckhc = this.OCHCODJIPHJ.x + 1809f;
			float eebeoegpgab = this.OCHCODJIPHJ.y + 1297f;
			for (int i = 0; i < this.EELDHNFBFOE.LACAJHOHACK.Count; i += 0)
			{
				JNHLAGHJBAA.FPAEEADMCIE jeeeoebnjdj = this.EELDHNFBFOE.LACAJHOHACK[i];
				eebeoegpgab = this.IPNMKBMAKBM(fahmjbbckhc, eebeoegpgab, 1, i == this.EELDHNFBFOE.LACAJHOHACK.Count - 1, jeeeoebnjdj, ofpnedeamab);
			}
		}
		finally
		{
			GUI.EndScrollView();
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x060060C8 RID: 24776 RVA: 0x002D2A7C File Offset: 0x002D0C7C
	private void GDNMGMJGLKH(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, ICollection<JNHLAGHJBAA.FPAEEADMCIE> BGJMHJHCDJH)
	{
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (!fpaeeadmcie.DBHKKPMINIJ)
			{
				BGJMHJHCDJH.Add(fpaeeadmcie);
			}
			else
			{
				this.EIPHIJNEOBB(fpaeeadmcie, BGJMHJHCDJH);
			}
		}
	}

	// Token: 0x060060C9 RID: 24777 RVA: 0x002D2AE4 File Offset: 0x002D0CE4
	public void HAEOLOLPLCF()
	{
		this.FKEFAGANFOB(this.EELDHNFBFOE);
		JNHLAGHJBAA.FPAEEADMCIE eeldhnfbfoe = this.EELDHNFBFOE;
		for (int i = eeldhnfbfoe.LACAJHOHACK.Count - 1; i >= 0; i -= 0)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = eeldhnfbfoe.LACAJHOHACK[i];
			if (fpaeeadmcie.DBHKKPMINIJ && fpaeeadmcie.LACAJHOHACK.Count <= 1)
			{
				eeldhnfbfoe.LACAJHOHACK.Remove(fpaeeadmcie);
			}
		}
	}

	// Token: 0x060060CA RID: 24778 RVA: 0x002D2B4C File Offset: 0x002D0D4C
	private void PILMKGDONDI(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, ICollection<JNHLAGHJBAA.FPAEEADMCIE> BGJMHJHCDJH)
	{
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				BGJMHJHCDJH.Add(fpaeeadmcie);
				this.PILMKGDONDI(fpaeeadmcie, BGJMHJHCDJH);
			}
			else
			{
				this.PILMKGDONDI(fpaeeadmcie, BGJMHJHCDJH);
			}
		}
	}

	// Token: 0x060060CB RID: 24779 RVA: 0x002D2BBC File Offset: 0x002D0DBC
	private float NCMDOIIMNCO(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, GUIStyle OFPNEDEAMAB)
	{
		this.OPNCIPMMGNN(FAHMJBBCKHC, EEBEOEGPGAB, CNOLCNDBLJE, JHDONNEJFGD, JEEEOEBNJDJ, OFPNEDEAMAB);
		EEBEOEGPGAB += this.JHNCNHAAJCH;
		if (JEEEOEBNJDJ.DBHKKPMINIJ && JEEEOEBNJDJ.LACAJHOHACK.Count > 0 && JEEEOEBNJDJ.PFMNPEOKEKO)
		{
			for (int i = 0; i < JEEEOEBNJDJ.LACAJHOHACK.Count; i++)
			{
				JNHLAGHJBAA.FPAEEADMCIE jeeeoebnjdj = JEEEOEBNJDJ.LACAJHOHACK[i];
				EEBEOEGPGAB = this.NCMDOIIMNCO(FAHMJBBCKHC, EEBEOEGPGAB, CNOLCNDBLJE + 1, i == JEEEOEBNJDJ.LACAJHOHACK.Count - 1, jeeeoebnjdj, OFPNEDEAMAB);
			}
		}
		return EEBEOEGPGAB;
	}

	// Token: 0x060060CC RID: 24780 RVA: 0x002D2C4C File Offset: 0x002D0E4C
	private void CFNNPNLCJEF(JNHLAGHJBAA.FPAEEADMCIE KAOKEJPBAHM)
	{
		for (int i = KAOKEJPBAHM.LACAJHOHACK.Count - 1; i >= 0; i -= 0)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = KAOKEJPBAHM.LACAJHOHACK[i];
			if (fpaeeadmcie.DBHKKPMINIJ && fpaeeadmcie.LACAJHOHACK.Count <= 0)
			{
				KAOKEJPBAHM.LACAJHOHACK.Remove(fpaeeadmcie);
			}
			else
			{
				this.CFNNPNLCJEF(fpaeeadmcie);
			}
		}
	}

	// Token: 0x060060CD RID: 24781 RVA: 0x002CFB19 File Offset: 0x002CDD19
	public void JOHECNHOKDE(float ADMFAEOOOHD)
	{
		this.AICBIFFGBOH.y = ADMFAEOOOHD;
	}

	// Token: 0x060060CF RID: 24783 RVA: 0x002D2CAC File Offset: 0x002D0EAC
	public List<JNHLAGHJBAA.FPAEEADMCIE> IPLFLNINBBB()
	{
		List<JNHLAGHJBAA.FPAEEADMCIE> list = new List<JNHLAGHJBAA.FPAEEADMCIE>();
		this.HBODAKHEEDM(this.EELDHNFBFOE, list);
		return list;
	}

	// Token: 0x060060D0 RID: 24784 RVA: 0x002D2CD0 File Offset: 0x002D0ED0
	private void PKMJIGCKKJF(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, ICollection<JNHLAGHJBAA.FPAEEADMCIE> BGJMHJHCDJH)
	{
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				BGJMHJHCDJH.Add(fpaeeadmcie);
				this.FGIALHFIJGE(fpaeeadmcie, BGJMHJHCDJH);
			}
			else
			{
				this.PKMJIGCKKJF(fpaeeadmcie, BGJMHJHCDJH);
			}
		}
	}

	// Token: 0x060060D1 RID: 24785 RVA: 0x002D2D40 File Offset: 0x002D0F40
	public void JPMIDIPGAEB()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("MotorbikeTurnLeft", 1964f);
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		this.LJDAFBKPCNN(this, this.HFHMNPKEALB());
	}

	// Token: 0x060060D2 RID: 24786 RVA: 0x002D2D74 File Offset: 0x002D0F74
	private void PKGIFFDFBKF(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE MBKPMBPLIJN, GUIStyle OFPNEDEAMAB)
	{
		float num = (float)CNOLCNDBLJE * this.GMAIMDLCOAG;
		MBKPMBPLIJN.NOKGPCEEOOG = EEBEOEGPGAB;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 1264f, this.JHNCNHAAJCH), GuiProcessor.NKOEAPCIBKO().Header);
		}
		if (this.ILPHHFOBMJF() == MBKPMBPLIJN)
		{
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 724f, this.JHNCNHAAJCH), GuiProcessor.BBLINJLBAIL().WLBLine, new Rect(1213f, 606f, 1474f, 580f), false);
		}
		float num2 = 603f;
		if (this.GIOGEHKMKDE && MBKPMBPLIJN.FNOAAAFNLDJ() != null)
		{
			Texture texture = MBKPMBPLIJN.PDJBFPOAPBA().MLPBJEFJDHM();
			float num3 = (this.JHNCNHAAJCH - 609f) / (float)texture.height;
			float num4 = (float)texture.width * num3;
			float height = (float)texture.height * num3;
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + 1406f + num, EEBEOEGPGAB + 1582f, num4, height), texture, ScaleMode.ScaleAndCrop);
			num2 = num2 + num4 + 459f;
		}
		int num5 = -1;
		int num6 = 8;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			num5 = 8;
			if (MBKPMBPLIJN.LACAJHOHACK.Count > 0)
			{
				num5 = (MBKPMBPLIJN.PFMNPEOKEKO ? 4 : 0);
			}
		}
		if (num5 >= 0)
		{
			num6 = -32;
			Rect position = new Rect(FAHMJBBCKHC + 1962f + num, EEBEOEGPGAB + this.JHNCNHAAJCH / 225f - 499f, 5f, 665f);
			GUI.DrawTextureWithTexCoords(position, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(num5, 2, 8), true);
			if (GUI.Button(position, "", GUIStyle.none) && MBKPMBPLIJN.DBHKKPMINIJ)
			{
				if (MBKPMBPLIJN.LACAJHOHACK.Count > 0)
				{
					MBKPMBPLIJN.PFMNPEOKEKO = MBKPMBPLIJN.PFMNPEOKEKO;
					this.DOKFENAIKLP();
					FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE(" ", 716f);
				}
				else
				{
					FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("Below you can try to cheat few variables of the regular types and their obscured (secure) analogues (you may change initial values from Tester object inspector):", 1226f);
				}
			}
		}
		OFPNEDEAMAB.normal.textColor = ((this.EHMBLGCPBOP() == MBKPMBPLIJN) ? this.AOHDHGNCHHF : this.JKAOKBNCDFK);
		MBKPMBPLIJN.LHEHCODOHCC(new Rect(FAHMJBBCKHC + (float)num6 + num2 + num, EEBEOEGPGAB + 1546f, this.OCHCODJIPHJ.width - 706f, this.JHNCNHAAJCH), OFPNEDEAMAB);
		if (GUI.RepeatButton(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - 831f, this.JHNCNHAAJCH), "Player", GUIStyle.none))
		{
			this.HLEOJHPPINJ(MBKPMBPLIJN);
		}
		float num7 = 1130f;
		for (int i = 1; i < CNOLCNDBLJE; i++)
		{
			int clbpbjglhee = 1;
			if (i == CNOLCNDBLJE - 0)
			{
				clbpbjglhee = (JHDONNEJFGD ? 4 : 7);
			}
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num7, EEBEOEGPGAB, this.GMAIMDLCOAG, this.JHNCNHAAJCH), GuiProcessor.BBLINJLBAIL().TreeIcons, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(clbpbjglhee, 4, 4), false);
			num7 += this.GMAIMDLCOAG;
		}
	}

	// Token: 0x060060D3 RID: 24787 RVA: 0x002D308C File Offset: 0x002D128C
	private void JPLKOPGNLED(JNHLAGHJBAA.FPAEEADMCIE KAOKEJPBAHM)
	{
		for (int i = KAOKEJPBAHM.LACAJHOHACK.Count - 1; i >= 1; i -= 0)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = KAOKEJPBAHM.LACAJHOHACK[i];
			if (fpaeeadmcie.DBHKKPMINIJ && fpaeeadmcie.LACAJHOHACK.Count <= 1)
			{
				KAOKEJPBAHM.LACAJHOHACK.Remove(fpaeeadmcie);
			}
			else
			{
				this.JPLKOPGNLED(fpaeeadmcie);
			}
		}
	}

	// Token: 0x060060D4 RID: 24788 RVA: 0x002CF815 File Offset: 0x002CDA15
	public JNHLAGHJBAA.FPAEEADMCIE GFPDBOLCHIA()
	{
		return this.GOOLMOJOHII;
	}

	// Token: 0x060060D5 RID: 24789 RVA: 0x002CF4BE File Offset: 0x002CD6BE
	public JNHLAGHJBAA.FPAEEADMCIE OKGDCIFMPAF(long IDOFKFFEDJM)
	{
		return this.DEKOBGFJEBD(IDOFKFFEDJM, this.EELDHNFBFOE);
	}

	// Token: 0x060060D6 RID: 24790 RVA: 0x002CF815 File Offset: 0x002CDA15
	public JNHLAGHJBAA.FPAEEADMCIE ILPHHFOBMJF()
	{
		return this.GOOLMOJOHII;
	}

	// Token: 0x060060D7 RID: 24791 RVA: 0x002D30EC File Offset: 0x002D12EC
	private void LFHDOBIKHMD(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, ICollection<JNHLAGHJBAA.FPAEEADMCIE> BGJMHJHCDJH)
	{
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				BGJMHJHCDJH.Add(fpaeeadmcie);
				this.PILMKGDONDI(fpaeeadmcie, BGJMHJHCDJH);
			}
			else
			{
				this.FGIALHFIJGE(fpaeeadmcie, BGJMHJHCDJH);
			}
		}
	}

	// Token: 0x060060D8 RID: 24792 RVA: 0x002D315C File Offset: 0x002D135C
	public override void HFJFBDPNCCB(bool CFMPGCJMHJM)
	{
		GUI.Box(new Rect(this.OCHCODJIPHJ.x - 4f, this.OCHCODJIPHJ.y - 4f, this.OCHCODJIPHJ.width + 10f, this.OCHCODJIPHJ.height + 8f), "");
		if (this.EELDHNFBFOE == null)
		{
			return;
		}
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = this.KCLLDJJLCGC,
			font = GuiProcessor.IKGFHGKKCPG.rusfont,
			normal = 
			{
				textColor = this.JKAOKBNCDFK
			},
			hover = 
			{
				textColor = this.ABMDIOIJALO
			},
			focused = 
			{
				textColor = this.JKAOKBNCDFK
			},
			richText = true,
			alignment = TextAnchor.MiddleLeft
		};
		float num = this.HKGAEHMFFLH(this.EELDHNFBFOE);
		this.AICBIFFGBOH = GUI.BeginScrollView(this.OCHCODJIPHJ, this.AICBIFFGBOH, new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width - 18f, num + 20f), false, false);
		try
		{
			float fahmjbbckhc = this.OCHCODJIPHJ.x + 5f;
			float eebeoegpgab = this.OCHCODJIPHJ.y + 5f;
			for (int i = 0; i < this.EELDHNFBFOE.LACAJHOHACK.Count; i++)
			{
				JNHLAGHJBAA.FPAEEADMCIE jeeeoebnjdj = this.EELDHNFBFOE.LACAJHOHACK[i];
				eebeoegpgab = this.NCMDOIIMNCO(fahmjbbckhc, eebeoegpgab, 0, i == this.EELDHNFBFOE.LACAJHOHACK.Count - 1, jeeeoebnjdj, ofpnedeamab);
			}
		}
		finally
		{
			GUI.EndScrollView();
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x060060D9 RID: 24793 RVA: 0x002D331C File Offset: 0x002D151C
	private float OPMKBMEIENM(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, GUIStyle OFPNEDEAMAB)
	{
		this.OGOIPNHNNOB(FAHMJBBCKHC, EEBEOEGPGAB, CNOLCNDBLJE, JHDONNEJFGD, JEEEOEBNJDJ, OFPNEDEAMAB);
		EEBEOEGPGAB += this.JHNCNHAAJCH;
		if (JEEEOEBNJDJ.DBHKKPMINIJ && JEEEOEBNJDJ.LACAJHOHACK.Count > 0 && JEEEOEBNJDJ.PFMNPEOKEKO)
		{
			for (int i = 1; i < JEEEOEBNJDJ.LACAJHOHACK.Count; i++)
			{
				JNHLAGHJBAA.FPAEEADMCIE jeeeoebnjdj = JEEEOEBNJDJ.LACAJHOHACK[i];
				EEBEOEGPGAB = this.OPMKBMEIENM(FAHMJBBCKHC, EEBEOEGPGAB, CNOLCNDBLJE + 0, i == JEEEOEBNJDJ.LACAJHOHACK.Count - 0, jeeeoebnjdj, OFPNEDEAMAB);
			}
		}
		return EEBEOEGPGAB;
	}

	// Token: 0x060060DA RID: 24794 RVA: 0x002D33AC File Offset: 0x002D15AC
	private void HBODAKHEEDM(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, ICollection<JNHLAGHJBAA.FPAEEADMCIE> BGJMHJHCDJH)
	{
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (!fpaeeadmcie.DBHKKPMINIJ)
			{
				BGJMHJHCDJH.Add(fpaeeadmcie);
			}
			else
			{
				this.ALMKLIMHDCI(fpaeeadmcie, BGJMHJHCDJH);
			}
		}
	}

	// Token: 0x060060DB RID: 24795 RVA: 0x002CFB19 File Offset: 0x002CDD19
	public void PGDIPMJOPLH(float ADMFAEOOOHD)
	{
		this.AICBIFFGBOH.y = ADMFAEOOOHD;
	}

	// Token: 0x060060DC RID: 24796 RVA: 0x002D3414 File Offset: 0x002D1614
	public void BIPMLHDDOMF()
	{
		this.BAMJPJKFBBJ(this.EELDHNFBFOE);
		JNHLAGHJBAA.FPAEEADMCIE eeldhnfbfoe = this.EELDHNFBFOE;
		for (int i = eeldhnfbfoe.LACAJHOHACK.Count - 1; i >= 0; i--)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = eeldhnfbfoe.LACAJHOHACK[i];
			if (fpaeeadmcie.DBHKKPMINIJ && fpaeeadmcie.LACAJHOHACK.Count <= 0)
			{
				eeldhnfbfoe.LACAJHOHACK.Remove(fpaeeadmcie);
			}
		}
	}

	// Token: 0x060060DD RID: 24797 RVA: 0x002D347C File Offset: 0x002D167C
	private float EBMKLHEGFDI(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ)
	{
		float num = this.JHNCNHAAJCH;
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				if (fpaeeadmcie.LACAJHOHACK.Count > 1)
				{
					if (fpaeeadmcie.PFMNPEOKEKO)
					{
						num += this.PPJPECAFIHG(fpaeeadmcie);
					}
					else
					{
						num += this.JHNCNHAAJCH;
					}
				}
				else
				{
					num += this.JHNCNHAAJCH;
				}
			}
			else
			{
				num += this.JHNCNHAAJCH;
			}
		}
		return num;
	}

	// Token: 0x060060DE RID: 24798 RVA: 0x002D351C File Offset: 0x002D171C
	public void PCNHIOCHPPM()
	{
		this.JPLKOPGNLED(this.EELDHNFBFOE);
		JNHLAGHJBAA.FPAEEADMCIE eeldhnfbfoe = this.EELDHNFBFOE;
		for (int i = eeldhnfbfoe.LACAJHOHACK.Count - 0; i >= 1; i -= 0)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = eeldhnfbfoe.LACAJHOHACK[i];
			if (fpaeeadmcie.DBHKKPMINIJ && fpaeeadmcie.LACAJHOHACK.Count <= 0)
			{
				eeldhnfbfoe.LACAJHOHACK.Remove(fpaeeadmcie);
			}
		}
	}

	// Token: 0x060060DF RID: 24799 RVA: 0x002D3584 File Offset: 0x002D1784
	public List<JNHLAGHJBAA.FPAEEADMCIE> BKJJCDDDGAG()
	{
		List<JNHLAGHJBAA.FPAEEADMCIE> list = new List<JNHLAGHJBAA.FPAEEADMCIE>();
		this.PKMJIGCKKJF(this.EELDHNFBFOE, list);
		return list;
	}

	// Token: 0x060060E0 RID: 24800 RVA: 0x002D35A8 File Offset: 0x002D17A8
	public void NKPICDKICKO()
	{
		if (this.EAOGHFFPFKM == "")
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in this.AFKDMEFGJMN())
		{
			if (fpaeeadmcie.DBHKKPMINIJ && fpaeeadmcie.PFMNPEOKEKO)
			{
				list.Add((int)fpaeeadmcie.ODFEKBJCFMN);
			}
		}
		string text = JLFJEGIPIMM.MHFDIJGJGBJ().JLMIECEIAPP(list);
		Debug.Log("" + text);
		PlayerPrefs.SetString(this.EAOGHFFPFKM, text);
		PlayerPrefs.Save();
	}

	// Token: 0x060060E1 RID: 24801 RVA: 0x002D3658 File Offset: 0x002D1858
	public List<JNHLAGHJBAA.FPAEEADMCIE> FMHGAFCBDEM()
	{
		List<JNHLAGHJBAA.FPAEEADMCIE> list = new List<JNHLAGHJBAA.FPAEEADMCIE>();
		this.NMCJKBCEBKO(this.EELDHNFBFOE, list);
		return list;
	}

	// Token: 0x060060E2 RID: 24802 RVA: 0x002D367C File Offset: 0x002D187C
	private float AMBJHFDOBJG(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, GUIStyle OFPNEDEAMAB)
	{
		this.PKGIFFDFBKF(FAHMJBBCKHC, EEBEOEGPGAB, CNOLCNDBLJE, JHDONNEJFGD, JEEEOEBNJDJ, OFPNEDEAMAB);
		EEBEOEGPGAB += this.JHNCNHAAJCH;
		if (JEEEOEBNJDJ.DBHKKPMINIJ && JEEEOEBNJDJ.LACAJHOHACK.Count > 0 && JEEEOEBNJDJ.PFMNPEOKEKO)
		{
			for (int i = 0; i < JEEEOEBNJDJ.LACAJHOHACK.Count; i += 0)
			{
				JNHLAGHJBAA.FPAEEADMCIE jeeeoebnjdj = JEEEOEBNJDJ.LACAJHOHACK[i];
				EEBEOEGPGAB = this.IPNMKBMAKBM(FAHMJBBCKHC, EEBEOEGPGAB, CNOLCNDBLJE + 0, i == JEEEOEBNJDJ.LACAJHOHACK.Count - 0, jeeeoebnjdj, OFPNEDEAMAB);
			}
		}
		return EEBEOEGPGAB;
	}

	// Token: 0x060060E3 RID: 24803 RVA: 0x002D370C File Offset: 0x002D190C
	public List<JNHLAGHJBAA.FPAEEADMCIE> FMMIBCCLDMG()
	{
		List<JNHLAGHJBAA.FPAEEADMCIE> list = new List<JNHLAGHJBAA.FPAEEADMCIE>();
		this.FMIKHLGLEKM(this.EELDHNFBFOE, list);
		return list;
	}

	// Token: 0x060060E4 RID: 24804 RVA: 0x002CF4BE File Offset: 0x002CD6BE
	public JNHLAGHJBAA.FPAEEADMCIE MJMOMMKECMF(long IDOFKFFEDJM)
	{
		return this.DEKOBGFJEBD(IDOFKFFEDJM, this.EELDHNFBFOE);
	}

	// Token: 0x060060E5 RID: 24805 RVA: 0x002D3730 File Offset: 0x002D1930
	public void BJPFFMKEHDL(string LIBFCONJJFI)
	{
		this.EAOGHFFPFKM = LIBFCONJJFI;
		string @string = PlayerPrefs.GetString(this.EAOGHFFPFKM);
		List<int> bgjmhjhcdjh = JLFJEGIPIMM.IKGFHGKKCPG.INKAHAHOPPN(@string);
		Debug.Log("loadTreeNodeState SV=" + @string);
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in this.AFKDMEFGJMN())
		{
			int dccpcblodig = (int)fpaeeadmcie.ODFEKBJCFMN;
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				fpaeeadmcie.PFMNPEOKEKO = false;
				if (JLFJEGIPIMM.IKGFHGKKCPG.EHEMCMKMECH(dccpcblodig, bgjmhjhcdjh))
				{
					fpaeeadmcie.PFMNPEOKEKO = true;
				}
			}
		}
	}

	// Token: 0x060060E6 RID: 24806 RVA: 0x002CFB19 File Offset: 0x002CDD19
	public void FLDAKMIBHHP(float ADMFAEOOOHD)
	{
		this.AICBIFFGBOH.y = ADMFAEOOOHD;
	}

	// Token: 0x060060E7 RID: 24807 RVA: 0x002CFB19 File Offset: 0x002CDD19
	public void LFCOPAGBFEO(float ADMFAEOOOHD)
	{
		this.AICBIFFGBOH.y = ADMFAEOOOHD;
	}

	// Token: 0x060060E8 RID: 24808 RVA: 0x002CF815 File Offset: 0x002CDA15
	public JNHLAGHJBAA.FPAEEADMCIE JEHNCIEOCJB()
	{
		return this.GOOLMOJOHII;
	}

	// Token: 0x060060E9 RID: 24809 RVA: 0x002D37DC File Offset: 0x002D19DC
	public void KLLCLFEMMMC()
	{
		if (this.EAOGHFFPFKM == "")
		{
			return;
		}
		List<int> list = new List<int>();
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in this.AFKDMEFGJMN())
		{
			if (fpaeeadmcie.DBHKKPMINIJ && fpaeeadmcie.PFMNPEOKEKO)
			{
				list.Add((int)fpaeeadmcie.ODFEKBJCFMN);
			}
		}
		string text = JLFJEGIPIMM.IKGFHGKKCPG.JOLBNFFFCGI(list);
		Debug.Log("saveTreeNodeState SV=" + text);
		PlayerPrefs.SetString(this.EAOGHFFPFKM, text);
		PlayerPrefs.Save();
	}

	// Token: 0x060060EA RID: 24810 RVA: 0x002D388C File Offset: 0x002D1A8C
	public void JENPNODAIAL()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("FlyDown", 1080f);
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		this.LJDAFBKPCNN(this, this.PHMACFLIKNA());
	}

	// Token: 0x060060EB RID: 24811 RVA: 0x002D38BD File Offset: 0x002D1ABD
	public void PGMEFJNDGEI()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("S ", 659f);
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		this.LJDAFBKPCNN(this, this.GFPDBOLCHIA());
	}

	// Token: 0x060060EC RID: 24812 RVA: 0x002D38F0 File Offset: 0x002D1AF0
	public void MGDOCKCJKKN(string LIBFCONJJFI)
	{
		this.EAOGHFFPFKM = LIBFCONJJFI;
		string @string = PlayerPrefs.GetString(this.EAOGHFFPFKM);
		List<int> bgjmhjhcdjh = JLFJEGIPIMM.NNEAHAFBOHC().INKAHAHOPPN(@string);
		Debug.Log("silence" + @string);
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in this.OMLIEPJGDDG())
		{
			int dccpcblodig = (int)fpaeeadmcie.ODFEKBJCFMN;
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				fpaeeadmcie.PFMNPEOKEKO = true;
				if (JLFJEGIPIMM.PKGMBFEMKGP().EHEMCMKMECH(dccpcblodig, bgjmhjhcdjh))
				{
					fpaeeadmcie.PFMNPEOKEKO = false;
				}
			}
		}
	}

	// Token: 0x060060ED RID: 24813 RVA: 0x002CFB19 File Offset: 0x002CDD19
	public void IEMMBAMBBAN(float ADMFAEOOOHD)
	{
		this.AICBIFFGBOH.y = ADMFAEOOOHD;
	}

	// Token: 0x060060EE RID: 24814 RVA: 0x002D399C File Offset: 0x002D1B9C
	private void OJCEIKBDELI(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE MBKPMBPLIJN, GUIStyle OFPNEDEAMAB)
	{
		float num = (float)CNOLCNDBLJE * this.GMAIMDLCOAG;
		MBKPMBPLIJN.NOKGPCEEOOG = EEBEOEGPGAB;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 1607f, this.JHNCNHAAJCH), GuiProcessor.NKOEAPCIBKO().Header);
		}
		if (this.ILPHHFOBMJF() == MBKPMBPLIJN)
		{
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - num + 1816f, this.JHNCNHAAJCH), GuiProcessor.NKOEAPCIBKO().WLBLine, new Rect(404f, 853f, 523f, 57f), true);
		}
		float num2 = 924f;
		if (this.GIOGEHKMKDE && MBKPMBPLIJN.GLNFHKKJDDO() != null)
		{
			Texture texture = MBKPMBPLIJN.EJJAGEFMHCO().AEIIBNOFLCM();
			float num3 = (this.JHNCNHAAJCH - 881f) / (float)texture.height;
			float num4 = (float)texture.width * num3;
			float height = (float)texture.height * num3;
			GUI.DrawTexture(new Rect(FAHMJBBCKHC + 691f + num, EEBEOEGPGAB + 1776f, num4, height), texture, ScaleMode.StretchToFill);
			num2 = num2 + num4 + 499f;
		}
		int num5 = -1;
		int num6 = 7;
		if (MBKPMBPLIJN.DBHKKPMINIJ)
		{
			num5 = 8;
			if (MBKPMBPLIJN.LACAJHOHACK.Count > 0)
			{
				num5 = (MBKPMBPLIJN.PFMNPEOKEKO ? 1 : 1);
			}
		}
		if (num5 >= 1)
		{
			num6 = -85;
			Rect position = new Rect(FAHMJBBCKHC + 1919f + num, EEBEOEGPGAB + this.JHNCNHAAJCH / 1409f - 1321f, 1403f, 1194f);
			GUI.DrawTextureWithTexCoords(position, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(num5, 1, 7), false);
			if (GUI.Button(position, "MotorbikeLassoFwd", GUIStyle.none) && MBKPMBPLIJN.DBHKKPMINIJ)
			{
				if (MBKPMBPLIJN.LACAJHOHACK.Count > 1)
				{
					MBKPMBPLIJN.PFMNPEOKEKO = MBKPMBPLIJN.PFMNPEOKEKO;
					this.DOKFENAIKLP();
					FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("Right", 1067f);
				}
				else
				{
					FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("trn_end", 963f);
				}
			}
		}
		OFPNEDEAMAB.normal.textColor = ((this.KMCCDGMCMFH() == MBKPMBPLIJN) ? this.AOHDHGNCHHF : this.JKAOKBNCDFK);
		MBKPMBPLIJN.FGPIIDOFGDN(new Rect(FAHMJBBCKHC + (float)num6 + num2 + num, EEBEOEGPGAB + 154f, this.OCHCODJIPHJ.width - 1013f, this.JHNCNHAAJCH), OFPNEDEAMAB);
		if (GUI.RepeatButton(new Rect(FAHMJBBCKHC + num, EEBEOEGPGAB, this.OCHCODJIPHJ.width - 1344f, this.JHNCNHAAJCH), ", ", GUIStyle.none))
		{
			this.HNNJNDNOHLP = MBKPMBPLIJN;
		}
		float num7 = 1007f;
		for (int i = 0; i < CNOLCNDBLJE; i++)
		{
			int clbpbjglhee = 1;
			if (i == CNOLCNDBLJE - 0)
			{
				clbpbjglhee = (JHDONNEJFGD ? 4 : 5);
			}
			GUI.DrawTextureWithTexCoords(new Rect(FAHMJBBCKHC + num7, EEBEOEGPGAB, this.GMAIMDLCOAG, this.JHNCNHAAJCH), GuiProcessor.NKOEAPCIBKO().TreeIcons, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(clbpbjglhee, 8, 0), true);
			num7 += this.GMAIMDLCOAG;
		}
	}

	// Token: 0x060060EF RID: 24815 RVA: 0x002D3CB4 File Offset: 0x002D1EB4
	private float ENCFMNHGKIA(float FAHMJBBCKHC, float EEBEOEGPGAB, int CNOLCNDBLJE, bool JHDONNEJFGD, JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, GUIStyle OFPNEDEAMAB)
	{
		this.FGBHEDOODAI(FAHMJBBCKHC, EEBEOEGPGAB, CNOLCNDBLJE, JHDONNEJFGD, JEEEOEBNJDJ, OFPNEDEAMAB);
		EEBEOEGPGAB += this.JHNCNHAAJCH;
		if (JEEEOEBNJDJ.DBHKKPMINIJ && JEEEOEBNJDJ.LACAJHOHACK.Count > 0 && JEEEOEBNJDJ.PFMNPEOKEKO)
		{
			for (int i = 0; i < JEEEOEBNJDJ.LACAJHOHACK.Count; i++)
			{
				JNHLAGHJBAA.FPAEEADMCIE jeeeoebnjdj = JEEEOEBNJDJ.LACAJHOHACK[i];
				EEBEOEGPGAB = this.AMBJHFDOBJG(FAHMJBBCKHC, EEBEOEGPGAB, CNOLCNDBLJE + 1, i == JEEEOEBNJDJ.LACAJHOHACK.Count - 0, jeeeoebnjdj, OFPNEDEAMAB);
			}
		}
		return EEBEOEGPGAB;
	}

	// Token: 0x060060F0 RID: 24816 RVA: 0x002D3D44 File Offset: 0x002D1F44
	private float JKINPIAPJGE(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ)
	{
		float num = this.JHNCNHAAJCH;
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (fpaeeadmcie.DBHKKPMINIJ)
			{
				if (fpaeeadmcie.LACAJHOHACK.Count > 0)
				{
					if (fpaeeadmcie.PFMNPEOKEKO)
					{
						num += this.PPJPECAFIHG(fpaeeadmcie);
					}
					else
					{
						num += this.JHNCNHAAJCH;
					}
				}
				else
				{
					num += this.JHNCNHAAJCH;
				}
			}
			else
			{
				num += this.JHNCNHAAJCH;
			}
		}
		return num;
	}

	// Token: 0x060060F1 RID: 24817 RVA: 0x002CF815 File Offset: 0x002CDA15
	public JNHLAGHJBAA.FPAEEADMCIE FJDKOHGKJMA()
	{
		return this.GOOLMOJOHII;
	}

	// Token: 0x060060F2 RID: 24818 RVA: 0x002D3DE4 File Offset: 0x002D1FE4
	public List<JNHLAGHJBAA.FPAEEADMCIE> ONODDAALBFP()
	{
		List<JNHLAGHJBAA.FPAEEADMCIE> list = new List<JNHLAGHJBAA.FPAEEADMCIE>();
		this.PMLHGMJDBMG(this.EELDHNFBFOE, list);
		return list;
	}

	// Token: 0x060060F3 RID: 24819 RVA: 0x002D3E08 File Offset: 0x002D2008
	private void HIDJMGGGLEB(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, ICollection<JNHLAGHJBAA.FPAEEADMCIE> BGJMHJHCDJH)
	{
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in JEEEOEBNJDJ.LACAJHOHACK)
		{
			if (!fpaeeadmcie.DBHKKPMINIJ)
			{
				BGJMHJHCDJH.Add(fpaeeadmcie);
			}
			else
			{
				this.HBODAKHEEDM(fpaeeadmcie, BGJMHJHCDJH);
			}
		}
	}

	// Token: 0x04000DF5 RID: 3573
	public JNHLAGHJBAA.FPAEEADMCIE EELDHNFBFOE = new JNHLAGHJBAA.FPAEEADMCIE();

	// Token: 0x04000DF6 RID: 3574
	public float JHNCNHAAJCH;

	// Token: 0x04000DF7 RID: 3575
	public int KCLLDJJLCGC = 14;

	// Token: 0x04000DF8 RID: 3576
	public float GMAIMDLCOAG = 30f;

	// Token: 0x04000DF9 RID: 3577
	public bool GIOGEHKMKDE = true;

	// Token: 0x04000DFA RID: 3578
	public string EAOGHFFPFKM = "";

	// Token: 0x04000DFB RID: 3579
	public Color JKAOKBNCDFK = new Color(0.8f, 0.8f, 0.8f, 1f);

	// Token: 0x04000DFC RID: 3580
	public Color ABMDIOIJALO = new Color(0.8f, 0.8f, 0.8f, 1f);

	// Token: 0x04000DFD RID: 3581
	public Color AOHDHGNCHHF = Color.white;

	// Token: 0x04000DFE RID: 3582
	public JNHLAGHJBAA.KDLBACIBOEF LJDAFBKPCNN;

	// Token: 0x04000DFF RID: 3583
	private Vector2 AICBIFFGBOH = Vector2.zero;

	// Token: 0x04000E00 RID: 3584
	private JNHLAGHJBAA.FPAEEADMCIE GOOLMOJOHII;

	// Token: 0x020001B0 RID: 432
	public class FPAEEADMCIE
	{
		// Token: 0x060060F4 RID: 24820 RVA: 0x002D3E70 File Offset: 0x002D2070
		public void EBFNKPBFOIK(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.IHNEGGJADMO(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x060060F5 RID: 24821 RVA: 0x002D3EE8 File Offset: 0x002D20E8
		public JNHLAGHJBAA.FPAEEADMCIE LGMBHELCEEL(ItemBase OHBFBGCKLID, long KAMAJPKHICF = -1L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = "",
				NLIKAGGPANH = OHBFBGCKLID,
				ODFEKBJCFMN = KAMAJPKHICF
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = true;
			return fpaeeadmcie;
		}

		// Token: 0x060060F6 RID: 24822 RVA: 0x002D3F28 File Offset: 0x002D2128
		public JNHLAGHJBAA.FPAEEADMCIE NEGLEBJHNOL(ItemBase OHBFBGCKLID, long KAMAJPKHICF = -1L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = "IceHockey Goalie Save 2",
				NLIKAGGPANH = OHBFBGCKLID,
				ODFEKBJCFMN = KAMAJPKHICF
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = true;
			return fpaeeadmcie;
		}

		// Token: 0x060060F7 RID: 24823 RVA: 0x002D3F68 File Offset: 0x002D2168
		public JNHLAGHJBAA.FPAEEADMCIE BKDIIPFBIDK(ItemBase OHBFBGCKLID, long KAMAJPKHICF = -1L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = "Roar",
				NLIKAGGPANH = OHBFBGCKLID,
				ODFEKBJCFMN = KAMAJPKHICF
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = false;
			return fpaeeadmcie;
		}

		// Token: 0x060060F8 RID: 24824 RVA: 0x002D3FA8 File Offset: 0x002D21A8
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HDLBAJBALOF()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.HFAGADCJACL();
			}
			return null;
		}

		// Token: 0x060060F9 RID: 24825 RVA: 0x002D3FC0 File Offset: 0x002D21C0
		public JNHLAGHJBAA.FPAEEADMCIE AEJLOIFLHIB(string KEIEIAAKHHK, long PPJJJAGNADB, List<int> ANGDGMIFPLK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			fpaeeadmcie.DBHKKPMINIJ = true;
			fpaeeadmcie.BILPIGMDPAP = ANGDGMIFPLK;
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x060060FA RID: 24826 RVA: 0x002D400C File Offset: 0x002D220C
		public JNHLAGHJBAA.FPAEEADMCIE BKAIEDOBODI(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = false
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x060060FB RID: 24827 RVA: 0x002D4048 File Offset: 0x002D2248
		public virtual string OKJEDFNFDML()
		{
			string str = "\n";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x060060FC RID: 24828 RVA: 0x002D4081 File Offset: 0x002D2281
		public virtual CKNLPGEPGGF.IAPCJOBDCEH KHIDJHKNNFC()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.MFKHIBOFIFI();
			}
			return null;
		}

		// Token: 0x060060FD RID: 24829 RVA: 0x002D4098 File Offset: 0x002D2298
		public JNHLAGHJBAA.FPAEEADMCIE HPGJHBANKPJ(ItemBase OHBFBGCKLID, long KAMAJPKHICF = -1L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = "ChannelCastOmni",
				NLIKAGGPANH = OHBFBGCKLID,
				ODFEKBJCFMN = KAMAJPKHICF
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = false;
			return fpaeeadmcie;
		}

		// Token: 0x060060FE RID: 24830 RVA: 0x002D40D8 File Offset: 0x002D22D8
		public JNHLAGHJBAA.FPAEEADMCIE OCJIGFPFLAN(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = false
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x060060FF RID: 24831 RVA: 0x002D4114 File Offset: 0x002D2314
		public void DGFIBJBEJAF(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.GKDJCJKMBEN(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06006100 RID: 24832 RVA: 0x002D418C File Offset: 0x002D238C
		public JNHLAGHJBAA.FPAEEADMCIE JOLIJLGLHEB(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006101 RID: 24833 RVA: 0x002D41C8 File Offset: 0x002D23C8
		public JNHLAGHJBAA.FPAEEADMCIE KHMHFEHKJFB(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006102 RID: 24834 RVA: 0x002D4204 File Offset: 0x002D2404
		public virtual string FOIFFCPAJMI()
		{
			string str = "";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x06006103 RID: 24835 RVA: 0x002D4240 File Offset: 0x002D2440
		public JNHLAGHJBAA.FPAEEADMCIE EFHGGOCDLJE(string KEIEIAAKHHK, long PPJJJAGNADB, List<int> ANGDGMIFPLK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			fpaeeadmcie.DBHKKPMINIJ = true;
			fpaeeadmcie.BILPIGMDPAP = ANGDGMIFPLK;
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006104 RID: 24836 RVA: 0x002D428C File Offset: 0x002D248C
		public JNHLAGHJBAA.FPAEEADMCIE BIKMBPJLDMJ(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = false;
			return fpaeeadmcie;
		}

		// Token: 0x06006105 RID: 24837 RVA: 0x002D42CC File Offset: 0x002D24CC
		public JNHLAGHJBAA.FPAEEADMCIE FHFJLKCCCJB(ItemBase OHBFBGCKLID, long KAMAJPKHICF = -1L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = " ",
				NLIKAGGPANH = OHBFBGCKLID,
				ODFEKBJCFMN = KAMAJPKHICF
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = false;
			return fpaeeadmcie;
		}

		// Token: 0x06006106 RID: 24838 RVA: 0x002D430C File Offset: 0x002D250C
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FNAMKMANNCB()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.KHIDJHKNNFC();
			}
			return null;
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x002D4324 File Offset: 0x002D2524
		public void FCFDKJKNNAD(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.LKLDEGJIJAC(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06006108 RID: 24840 RVA: 0x002D439C File Offset: 0x002D259C
		public JNHLAGHJBAA.FPAEEADMCIE NILHMHCHCEF(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = true;
			return fpaeeadmcie;
		}

		// Token: 0x06006109 RID: 24841 RVA: 0x002D43DC File Offset: 0x002D25DC
		public void AGFLCAGCFBC(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.GGFPEBNLLEG(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x0600610A RID: 24842 RVA: 0x002D4454 File Offset: 0x002D2654
		public void LHEHCODOHCC(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.AGFLCAGCFBC(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x0600610B RID: 24843 RVA: 0x002D44CC File Offset: 0x002D26CC
		public virtual string NCNNJHIIAFM()
		{
			string str = "Jump";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x0600610C RID: 24844 RVA: 0x002D4508 File Offset: 0x002D2708
		public JNHLAGHJBAA.FPAEEADMCIE OEKFNLPBGCA(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = false
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x0600610D RID: 24845 RVA: 0x002D4544 File Offset: 0x002D2744
		public JNHLAGHJBAA.FPAEEADMCIE ENLCOEICJBB(string KEIEIAAKHHK, long PPJJJAGNADB, List<int> ANGDGMIFPLK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			fpaeeadmcie.DBHKKPMINIJ = true;
			fpaeeadmcie.BILPIGMDPAP = ANGDGMIFPLK;
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x0600610E RID: 24846 RVA: 0x002D4590 File Offset: 0x002D2790
		public JNHLAGHJBAA.FPAEEADMCIE ICPLJPEIIEN(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x0600610F RID: 24847 RVA: 0x002D45CC File Offset: 0x002D27CC
		public JNHLAGHJBAA.FPAEEADMCIE AIOFPIKGFMG(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = false;
			return fpaeeadmcie;
		}

		// Token: 0x06006110 RID: 24848 RVA: 0x002D460C File Offset: 0x002D280C
		public JNHLAGHJBAA.FPAEEADMCIE OLFAFFCHPNP(ItemBase OHBFBGCKLID, long KAMAJPKHICF = -1L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = "[ACTk] <b>[ Performance tests ]</b>",
				NLIKAGGPANH = OHBFBGCKLID,
				ODFEKBJCFMN = KAMAJPKHICF
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = false;
			return fpaeeadmcie;
		}

		// Token: 0x06006111 RID: 24849 RVA: 0x002D464C File Offset: 0x002D284C
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HKHAONBKECM()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.BHPAALLBMHL();
			}
			return null;
		}

		// Token: 0x06006112 RID: 24850 RVA: 0x002D4664 File Offset: 0x002D2864
		public JNHLAGHJBAA.FPAEEADMCIE LMIMAFJEBHA(ItemBase OHBFBGCKLID, long KAMAJPKHICF = -1L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = "Kernel",
				NLIKAGGPANH = OHBFBGCKLID,
				ODFEKBJCFMN = KAMAJPKHICF
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = true;
			return fpaeeadmcie;
		}

		// Token: 0x06006113 RID: 24851 RVA: 0x002D46A4 File Offset: 0x002D28A4
		public JNHLAGHJBAA.FPAEEADMCIE NPOBMCOEFKK(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = true;
			return fpaeeadmcie;
		}

		// Token: 0x06006114 RID: 24852 RVA: 0x002D46E4 File Offset: 0x002D28E4
		public JNHLAGHJBAA.FPAEEADMCIE MIAONNLIGAN(ItemBase OHBFBGCKLID, long KAMAJPKHICF = -1L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = "CrouchStrafeLeft",
				NLIKAGGPANH = OHBFBGCKLID,
				ODFEKBJCFMN = KAMAJPKHICF
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = true;
			return fpaeeadmcie;
		}

		// Token: 0x06006115 RID: 24853 RVA: 0x002D4724 File Offset: 0x002D2924
		public virtual string CJMFHLIBCBM()
		{
			string str = "GestureWonderful";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x06006116 RID: 24854 RVA: 0x002D4760 File Offset: 0x002D2960
		public void HHBLLIKDCBB(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.GHNCDFCOADD(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06006117 RID: 24855 RVA: 0x002D47D8 File Offset: 0x002D29D8
		public virtual CKNLPGEPGGF.IAPCJOBDCEH EJJAGEFMHCO()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.EJJAGEFMHCO();
			}
			return null;
		}

		// Token: 0x06006118 RID: 24856 RVA: 0x002D47F0 File Offset: 0x002D29F0
		public JNHLAGHJBAA.FPAEEADMCIE MENGHIADOPM(string KEIEIAAKHHK, long PPJJJAGNADB, List<int> ANGDGMIFPLK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = false
			};
			fpaeeadmcie.DBHKKPMINIJ = true;
			fpaeeadmcie.BILPIGMDPAP = ANGDGMIFPLK;
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006119 RID: 24857 RVA: 0x002D483C File Offset: 0x002D2A3C
		public JNHLAGHJBAA.FPAEEADMCIE EGGHFPPCNDP(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = false;
			return fpaeeadmcie;
		}

		// Token: 0x0600611A RID: 24858 RVA: 0x002D430C File Offset: 0x002D250C
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LICCJMNJLCM()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.KHIDJHKNNFC();
			}
			return null;
		}

		// Token: 0x0600611B RID: 24859 RVA: 0x002D487C File Offset: 0x002D2A7C
		public JNHLAGHJBAA.FPAEEADMCIE BKHOOBPKKFC(string KEIEIAAKHHK, long PPJJJAGNADB, List<int> ANGDGMIFPLK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = false
			};
			fpaeeadmcie.DBHKKPMINIJ = true;
			fpaeeadmcie.BILPIGMDPAP = ANGDGMIFPLK;
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x0600611C RID: 24860 RVA: 0x002D48C8 File Offset: 0x002D2AC8
		public JNHLAGHJBAA.FPAEEADMCIE GHKNGPFKHEI(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = false
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x0600611D RID: 24861 RVA: 0x002D4904 File Offset: 0x002D2B04
		public virtual string BHLHEJCILKF()
		{
			string str = "isPersonal";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x0600611E RID: 24862 RVA: 0x002D4940 File Offset: 0x002D2B40
		public void IPJJKNBJEIF(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.PFECLGBDGNH(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x0600611F RID: 24863 RVA: 0x002D49B8 File Offset: 0x002D2BB8
		public void JBFOPFFEFJD(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.PKJNOAKJGOD(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06006120 RID: 24864 RVA: 0x002D4A30 File Offset: 0x002D2C30
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DKNEPLMPHOD()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.PBHPIGPDCJA();
			}
			return null;
		}

		// Token: 0x06006121 RID: 24865 RVA: 0x002D4A48 File Offset: 0x002D2C48
		public JNHLAGHJBAA.FPAEEADMCIE LJLABFGCNIO(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006122 RID: 24866 RVA: 0x002D4A30 File Offset: 0x002D2C30
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FNOAAAFNLDJ()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.PBHPIGPDCJA();
			}
			return null;
		}

		// Token: 0x06006123 RID: 24867 RVA: 0x002D4A84 File Offset: 0x002D2C84
		public void HJDLKEIIODM(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.AGFLCAGCFBC(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06006124 RID: 24868 RVA: 0x002D4AFC File Offset: 0x002D2CFC
		public virtual string KGHKBMFEEDH()
		{
			string str = "BowReady";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x06006125 RID: 24869 RVA: 0x002D4B38 File Offset: 0x002D2D38
		public JNHLAGHJBAA.FPAEEADMCIE MGAHJJGKNPM(string KEIEIAAKHHK, long PPJJJAGNADB, List<int> ANGDGMIFPLK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = false
			};
			fpaeeadmcie.DBHKKPMINIJ = false;
			fpaeeadmcie.BILPIGMDPAP = ANGDGMIFPLK;
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006126 RID: 24870 RVA: 0x002D4B84 File Offset: 0x002D2D84
		public virtual string BGJEBOEAINF()
		{
			string str = "MotorbikeShootBack";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x06006127 RID: 24871 RVA: 0x002D4BC0 File Offset: 0x002D2DC0
		public JNHLAGHJBAA.FPAEEADMCIE APKJANCLGFN(ItemBase OHBFBGCKLID, long KAMAJPKHICF = -1L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = "u_pin",
				NLIKAGGPANH = OHBFBGCKLID,
				ODFEKBJCFMN = KAMAJPKHICF
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = false;
			return fpaeeadmcie;
		}

		// Token: 0x06006128 RID: 24872 RVA: 0x002D4C00 File Offset: 0x002D2E00
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LNHLBIOOINI()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.JGBOJNELADG();
			}
			return null;
		}

		// Token: 0x06006129 RID: 24873 RVA: 0x002D4C00 File Offset: 0x002D2E00
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LOHCIIFHNCE()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.JGBOJNELADG();
			}
			return null;
		}

		// Token: 0x0600612A RID: 24874 RVA: 0x002D4C17 File Offset: 0x002D2E17
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HHOBCJNGCEL()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.HEFAGFMDAEE();
			}
			return null;
		}

		// Token: 0x0600612B RID: 24875 RVA: 0x002D4C30 File Offset: 0x002D2E30
		public JNHLAGHJBAA.FPAEEADMCIE DFKPAOJDABD(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = true;
			return fpaeeadmcie;
		}

		// Token: 0x0600612C RID: 24876 RVA: 0x002D4C70 File Offset: 0x002D2E70
		public JNHLAGHJBAA.FPAEEADMCIE BKAFLNMHCHP(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = false;
			return fpaeeadmcie;
		}

		// Token: 0x0600612D RID: 24877 RVA: 0x002D4CAD File Offset: 0x002D2EAD
		public virtual CKNLPGEPGGF.IAPCJOBDCEH CNDJIHOMKHH()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.PBEMPJOBKKI();
			}
			return null;
		}

		// Token: 0x0600612E RID: 24878 RVA: 0x002D4CC4 File Offset: 0x002D2EC4
		public virtual string JJPMKNKFPPN()
		{
			string str = "KneesIdle";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x0600612F RID: 24879 RVA: 0x002D4D00 File Offset: 0x002D2F00
		public void JNPFLPLDAGA(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.BOHKFACPFIJ(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06006130 RID: 24880 RVA: 0x002D4D78 File Offset: 0x002D2F78
		public JNHLAGHJBAA.FPAEEADMCIE PBPBPBPPFNG(ItemBase OHBFBGCKLID, long KAMAJPKHICF = -1L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = "IdleReadyLook",
				NLIKAGGPANH = OHBFBGCKLID,
				ODFEKBJCFMN = KAMAJPKHICF
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = false;
			return fpaeeadmcie;
		}

		// Token: 0x06006131 RID: 24881 RVA: 0x002D4DB8 File Offset: 0x002D2FB8
		public void AGNMECAOOJI(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.GHNCDFCOADD(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06006132 RID: 24882 RVA: 0x002D4E30 File Offset: 0x002D3030
		public JNHLAGHJBAA.FPAEEADMCIE LNAEGNFDOAL(ItemBase OHBFBGCKLID, long KAMAJPKHICF = -1L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = "StaffAttack",
				NLIKAGGPANH = OHBFBGCKLID,
				ODFEKBJCFMN = KAMAJPKHICF
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = false;
			return fpaeeadmcie;
		}

		// Token: 0x06006133 RID: 24883 RVA: 0x002D4E70 File Offset: 0x002D3070
		public virtual string MJODNMLNFJC()
		{
			string str = "ChannelCastDirected";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x06006134 RID: 24884 RVA: 0x002D4EAC File Offset: 0x002D30AC
		public JNHLAGHJBAA.FPAEEADMCIE DHHCGNOLGCD(string KEIEIAAKHHK, long PPJJJAGNADB, List<int> ANGDGMIFPLK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			fpaeeadmcie.DBHKKPMINIJ = true;
			fpaeeadmcie.BILPIGMDPAP = ANGDGMIFPLK;
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006135 RID: 24885 RVA: 0x002D4EF8 File Offset: 0x002D30F8
		public virtual string GCIGMHOJAIM()
		{
			string str = "_HighlightSuppression";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x06006136 RID: 24886 RVA: 0x002D4F34 File Offset: 0x002D3134
		public JNHLAGHJBAA.FPAEEADMCIE IBDKLMNFKOE(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = true;
			return fpaeeadmcie;
		}

		// Token: 0x06006137 RID: 24887 RVA: 0x002D4F74 File Offset: 0x002D3174
		public void COFFCOCOJFK(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.PKJNOAKJGOD(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06006138 RID: 24888 RVA: 0x002D4FEC File Offset: 0x002D31EC
		public JNHLAGHJBAA.FPAEEADMCIE DHHCGNOLGCD(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006139 RID: 24889 RVA: 0x002D5028 File Offset: 0x002D3228
		public virtual string OKEAOIBHKIN()
		{
			string str = " ";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x0600613A RID: 24890 RVA: 0x002D5064 File Offset: 0x002D3264
		public virtual string FJGIAILHMIF()
		{
			string str = "";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x0600613B RID: 24891 RVA: 0x002D50A0 File Offset: 0x002D32A0
		public virtual string IBNCBKOPEOC()
		{
			string str = "_noinfo";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x0600613C RID: 24892 RVA: 0x002D50DC File Offset: 0x002D32DC
		public virtual string CEOAKEEKAMH()
		{
			string str = "[F_EXP]";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x0600613D RID: 24893 RVA: 0x002D5118 File Offset: 0x002D3318
		public JNHLAGHJBAA.FPAEEADMCIE NGDPNEPKHNM(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x0600613E RID: 24894 RVA: 0x002D5154 File Offset: 0x002D3354
		public JNHLAGHJBAA.FPAEEADMCIE INILCDHEJNA(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = false
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x0600613F RID: 24895 RVA: 0x002D4CAD File Offset: 0x002D2EAD
		public virtual CKNLPGEPGGF.IAPCJOBDCEH PFKIHEHMLDB()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.PBEMPJOBKKI();
			}
			return null;
		}

		// Token: 0x06006140 RID: 24896 RVA: 0x002D5190 File Offset: 0x002D3390
		public JNHLAGHJBAA.FPAEEADMCIE BILKADMKFIG(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = false
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006141 RID: 24897 RVA: 0x002D51CC File Offset: 0x002D33CC
		public virtual CKNLPGEPGGF.IAPCJOBDCEH ADANBAEJOMC()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.APLAAOCGECL();
			}
			return null;
		}

		// Token: 0x06006142 RID: 24898 RVA: 0x002D51E4 File Offset: 0x002D33E4
		public JNHLAGHJBAA.FPAEEADMCIE CGPJECOPFOG(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = false
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006143 RID: 24899 RVA: 0x002D5220 File Offset: 0x002D3420
		public JNHLAGHJBAA.FPAEEADMCIE EHAOPAHELMC(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = false
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x002D525C File Offset: 0x002D345C
		public virtual string DFHAGGBIEIH()
		{
			string str = "";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x06006146 RID: 24902 RVA: 0x002D52BC File Offset: 0x002D34BC
		public JNHLAGHJBAA.FPAEEADMCIE BHMMDNDHMOC(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = true;
			return fpaeeadmcie;
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x002D52FC File Offset: 0x002D34FC
		public void DBCCBDCAMII(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.BOHKFACPFIJ(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x002D5374 File Offset: 0x002D3574
		public virtual string BJALMHGGAFM()
		{
			string str = "IdleDodgeLeft";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x002D53B0 File Offset: 0x002D35B0
		public JNHLAGHJBAA.FPAEEADMCIE FLNIOEAADNK(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = false;
			return fpaeeadmcie;
		}

		// Token: 0x0600614A RID: 24906 RVA: 0x002D4A30 File Offset: 0x002D2C30
		public virtual CKNLPGEPGGF.IAPCJOBDCEH MFKHIBOFIFI()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.PBHPIGPDCJA();
			}
			return null;
		}

		// Token: 0x0600614B RID: 24907 RVA: 0x002D4C00 File Offset: 0x002D2E00
		public virtual CKNLPGEPGGF.IAPCJOBDCEH ENCJNMNEANC()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.JGBOJNELADG();
			}
			return null;
		}

		// Token: 0x0600614C RID: 24908 RVA: 0x002D53F0 File Offset: 0x002D35F0
		public JNHLAGHJBAA.FPAEEADMCIE LGGHNMLMFMN(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x0600614D RID: 24909 RVA: 0x002D542C File Offset: 0x002D362C
		public virtual string JMCNJFKMDKI()
		{
			string str = "C ";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x0600614E RID: 24910 RVA: 0x002D5468 File Offset: 0x002D3668
		public JNHLAGHJBAA.FPAEEADMCIE IIBPHNMPPMA(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = false
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x0600614F RID: 24911 RVA: 0x002D4C17 File Offset: 0x002D2E17
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FNILAAJAOEI()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.HEFAGFMDAEE();
			}
			return null;
		}

		// Token: 0x06006150 RID: 24912 RVA: 0x002D54A4 File Offset: 0x002D36A4
		public JNHLAGHJBAA.FPAEEADMCIE JEMFFJDKGEO(string KEIEIAAKHHK, long PPJJJAGNADB, List<int> ANGDGMIFPLK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			fpaeeadmcie.DBHKKPMINIJ = true;
			fpaeeadmcie.BILPIGMDPAP = ANGDGMIFPLK;
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006151 RID: 24913 RVA: 0x002D54F0 File Offset: 0x002D36F0
		public virtual string PBAJNDNHIFI()
		{
			string str = "_BlurRadius4";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x06006152 RID: 24914 RVA: 0x002D552C File Offset: 0x002D372C
		public void JHAKFEGIANH(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.BOHKFACPFIJ(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06006153 RID: 24915 RVA: 0x002D55A4 File Offset: 0x002D37A4
		public JNHLAGHJBAA.FPAEEADMCIE MAOGNFOPMNJ(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = false;
			return fpaeeadmcie;
		}

		// Token: 0x06006154 RID: 24916 RVA: 0x002D55E4 File Offset: 0x002D37E4
		public JNHLAGHJBAA.FPAEEADMCIE DEDKJKEDABG(string KEIEIAAKHHK, long PPJJJAGNADB, List<int> ANGDGMIFPLK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = false
			};
			fpaeeadmcie.DBHKKPMINIJ = false;
			fpaeeadmcie.BILPIGMDPAP = ANGDGMIFPLK;
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006155 RID: 24917 RVA: 0x002D5630 File Offset: 0x002D3830
		public JNHLAGHJBAA.FPAEEADMCIE GAMOPPJJAGA(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006156 RID: 24918 RVA: 0x002D566C File Offset: 0x002D386C
		public JNHLAGHJBAA.FPAEEADMCIE NIOLPMPHMNO(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006157 RID: 24919 RVA: 0x002D56A8 File Offset: 0x002D38A8
		public JNHLAGHJBAA.FPAEEADMCIE JGJPDACKLPO(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = true;
			return fpaeeadmcie;
		}

		// Token: 0x06006158 RID: 24920 RVA: 0x002D56E8 File Offset: 0x002D38E8
		public JNHLAGHJBAA.FPAEEADMCIE MDGHNJGLPOH(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006159 RID: 24921 RVA: 0x002D5724 File Offset: 0x002D3924
		public JNHLAGHJBAA.FPAEEADMCIE BOHINAMJGBL(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = true;
			return fpaeeadmcie;
		}

		// Token: 0x0600615A RID: 24922 RVA: 0x002D5761 File Offset: 0x002D3961
		public virtual CKNLPGEPGGF.IAPCJOBDCEH OALNEFBDIMB()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ENCJNMNEANC();
			}
			return null;
		}

		// Token: 0x0600615B RID: 24923 RVA: 0x002D5778 File Offset: 0x002D3978
		public virtual CKNLPGEPGGF.IAPCJOBDCEH GLNFHKKJDDO()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.GKPOPMAAGIJ();
			}
			return null;
		}

		// Token: 0x0600615C RID: 24924 RVA: 0x002D5790 File Offset: 0x002D3990
		public JNHLAGHJBAA.FPAEEADMCIE OMFFPFKGIBI(string KEIEIAAKHHK, long PPJJJAGNADB, List<int> ANGDGMIFPLK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = false
			};
			fpaeeadmcie.DBHKKPMINIJ = false;
			fpaeeadmcie.BILPIGMDPAP = ANGDGMIFPLK;
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x0600615D RID: 24925 RVA: 0x002D57DC File Offset: 0x002D39DC
		public JNHLAGHJBAA.FPAEEADMCIE DDJEPPHOIME(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = false;
			return fpaeeadmcie;
		}

		// Token: 0x0600615E RID: 24926 RVA: 0x002D581C File Offset: 0x002D3A1C
		public JNHLAGHJBAA.FPAEEADMCIE NOLKFNDMNPO(ItemBase OHBFBGCKLID, long KAMAJPKHICF = -1L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = "IX",
				NLIKAGGPANH = OHBFBGCKLID,
				ODFEKBJCFMN = KAMAJPKHICF
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = false;
			return fpaeeadmcie;
		}

		// Token: 0x0600615F RID: 24927 RVA: 0x002D585C File Offset: 0x002D3A5C
		public void GHNCDFCOADD(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.DNLOFIPAEBD(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06006160 RID: 24928 RVA: 0x002D58D4 File Offset: 0x002D3AD4
		public JNHLAGHJBAA.FPAEEADMCIE JKGFEINNJKH(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = false;
			return fpaeeadmcie;
		}

		// Token: 0x06006161 RID: 24929 RVA: 0x002D5914 File Offset: 0x002D3B14
		public JNHLAGHJBAA.FPAEEADMCIE BLNKMFIBIEJ(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006162 RID: 24930 RVA: 0x002D5950 File Offset: 0x002D3B50
		public JNHLAGHJBAA.FPAEEADMCIE DDJEHJCCPPE(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = false;
			return fpaeeadmcie;
		}

		// Token: 0x06006163 RID: 24931 RVA: 0x002D5990 File Offset: 0x002D3B90
		public JNHLAGHJBAA.FPAEEADMCIE DKMGEMLNNNE(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = true;
			return fpaeeadmcie;
		}

		// Token: 0x06006164 RID: 24932 RVA: 0x002D59D0 File Offset: 0x002D3BD0
		public JNHLAGHJBAA.FPAEEADMCIE LGMBHELCEEL(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = true;
			return fpaeeadmcie;
		}

		// Token: 0x06006165 RID: 24933 RVA: 0x002D5A10 File Offset: 0x002D3C10
		public JNHLAGHJBAA.FPAEEADMCIE OFFKLECDGMK(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006166 RID: 24934 RVA: 0x002D5A4C File Offset: 0x002D3C4C
		public JNHLAGHJBAA.FPAEEADMCIE EBCNJHDPLBC(string KEIEIAAKHHK, long PPJJJAGNADB, List<int> ANGDGMIFPLK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			fpaeeadmcie.DBHKKPMINIJ = true;
			fpaeeadmcie.BILPIGMDPAP = ANGDGMIFPLK;
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006167 RID: 24935 RVA: 0x002D5761 File Offset: 0x002D3961
		public virtual CKNLPGEPGGF.IAPCJOBDCEH NCJFHOGAMDD()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ENCJNMNEANC();
			}
			return null;
		}

		// Token: 0x06006168 RID: 24936 RVA: 0x002D5A98 File Offset: 0x002D3C98
		public override string ToString()
		{
			string str = "";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x06006169 RID: 24937 RVA: 0x002D5AD4 File Offset: 0x002D3CD4
		public void DBJLENKPKDF(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.LGNFBDKJPIJ(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x0600616A RID: 24938 RVA: 0x002D5B4C File Offset: 0x002D3D4C
		public JNHLAGHJBAA.FPAEEADMCIE INBLFMOMBJJ(string KEIEIAAKHHK, long PPJJJAGNADB = 0L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x0600616B RID: 24939 RVA: 0x002D5B88 File Offset: 0x002D3D88
		public JNHLAGHJBAA.FPAEEADMCIE DHDLMHAHFKC(string KEIEIAAKHHK, long PPJJJAGNADB, List<int> ANGDGMIFPLK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = false
			};
			fpaeeadmcie.DBHKKPMINIJ = false;
			fpaeeadmcie.BILPIGMDPAP = ANGDGMIFPLK;
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x0600616C RID: 24940 RVA: 0x002D4C00 File Offset: 0x002D2E00
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HKPLBOEPHNB()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.JGBOJNELADG();
			}
			return null;
		}

		// Token: 0x0600616D RID: 24941 RVA: 0x002D5BD4 File Offset: 0x002D3DD4
		public JNHLAGHJBAA.FPAEEADMCIE PHEMMGABEKG(ItemBase OHBFBGCKLID, long KAMAJPKHICF = -1L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = "_MinVelocity",
				NLIKAGGPANH = OHBFBGCKLID,
				ODFEKBJCFMN = KAMAJPKHICF
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = true;
			return fpaeeadmcie;
		}

		// Token: 0x0600616E RID: 24942 RVA: 0x002D5C14 File Offset: 0x002D3E14
		public void FGPIIDOFGDN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.AGFLCAGCFBC(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x0600616F RID: 24943 RVA: 0x002D5761 File Offset: 0x002D3961
		public virtual CKNLPGEPGGF.IAPCJOBDCEH JMNBEKPPGLP()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ENCJNMNEANC();
			}
			return null;
		}

		// Token: 0x06006170 RID: 24944 RVA: 0x002D5C8C File Offset: 0x002D3E8C
		public void GKDJCJKMBEN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.GKDJCJKMBEN(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06006171 RID: 24945 RVA: 0x002D5D04 File Offset: 0x002D3F04
		public JNHLAGHJBAA.FPAEEADMCIE HNNLJCGIKEL(ItemBase OHBFBGCKLID, long KAMAJPKHICF = -1L)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = "Kernel",
				NLIKAGGPANH = OHBFBGCKLID,
				ODFEKBJCFMN = KAMAJPKHICF
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = true;
			return fpaeeadmcie;
		}

		// Token: 0x06006172 RID: 24946 RVA: 0x002D5D44 File Offset: 0x002D3F44
		public JNHLAGHJBAA.FPAEEADMCIE LOPPPLDCBFM(string KEIEIAAKHHK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = -1L
			};
			this.LACAJHOHACK.Add(fpaeeadmcie);
			this.DBHKKPMINIJ = true;
			return fpaeeadmcie;
		}

		// Token: 0x06006173 RID: 24947 RVA: 0x002D5D84 File Offset: 0x002D3F84
		public void HJCODOHGIKH(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			OFPNEDEAMAB.normal.textColor = (this.DBHKKPMINIJ ? OFPNEDEAMAB.hover.textColor : OFPNEDEAMAB.focused.textColor);
			if (this.AHFGACFMGEJ != null)
			{
				this.AHFGACFMGEJ(this, this.NLIKAGGPANH, COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			if (this.NLIKAGGPANH != null)
			{
				this.NLIKAGGPANH.LGNFBDKJPIJ(COAGIAMOCIA, OFPNEDEAMAB);
				return;
			}
			GUI.Label(COAGIAMOCIA, this.ToString(), OFPNEDEAMAB);
		}

		// Token: 0x06006174 RID: 24948 RVA: 0x002D5DFC File Offset: 0x002D3FFC
		public JNHLAGHJBAA.FPAEEADMCIE NDJLBKDCNOL(string KEIEIAAKHHK, long PPJJJAGNADB, List<int> ANGDGMIFPLK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			fpaeeadmcie.DBHKKPMINIJ = false;
			fpaeeadmcie.BILPIGMDPAP = ANGDGMIFPLK;
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006175 RID: 24949 RVA: 0x002D5E48 File Offset: 0x002D4048
		public JNHLAGHJBAA.FPAEEADMCIE OOLACINKAAL(string KEIEIAAKHHK, long PPJJJAGNADB, List<int> ANGDGMIFPLK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = true
			};
			fpaeeadmcie.DBHKKPMINIJ = false;
			fpaeeadmcie.BILPIGMDPAP = ANGDGMIFPLK;
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006176 RID: 24950 RVA: 0x002D5E94 File Offset: 0x002D4094
		public JNHLAGHJBAA.FPAEEADMCIE GDMHAKADIDD(string KEIEIAAKHHK, long PPJJJAGNADB, List<int> ANGDGMIFPLK)
		{
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = new JNHLAGHJBAA.FPAEEADMCIE
			{
				CEEIHOLNALH = KEIEIAAKHHK,
				NLIKAGGPANH = null,
				ODFEKBJCFMN = PPJJJAGNADB,
				DBHKKPMINIJ = false
			};
			fpaeeadmcie.DBHKKPMINIJ = false;
			fpaeeadmcie.BILPIGMDPAP = ANGDGMIFPLK;
			this.LACAJHOHACK.Add(fpaeeadmcie);
			return fpaeeadmcie;
		}

		// Token: 0x06006177 RID: 24951 RVA: 0x002D4A30 File Offset: 0x002D2C30
		public virtual CKNLPGEPGGF.IAPCJOBDCEH GKPOPMAAGIJ()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.PBHPIGPDCJA();
			}
			return null;
		}

		// Token: 0x06006178 RID: 24952 RVA: 0x002D4081 File Offset: 0x002D2281
		public virtual CKNLPGEPGGF.IAPCJOBDCEH PDJBFPOAPBA()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.MFKHIBOFIFI();
			}
			return null;
		}

		// Token: 0x06006179 RID: 24953 RVA: 0x002D5EE0 File Offset: 0x002D40E0
		public virtual string DLGLBACGDGB()
		{
			string str = "spinbreak.ogg";
			bool isEditor = Application.isEditor;
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.ToString();
			}
			return this.CEEIHOLNALH + str;
		}

		// Token: 0x0600617A RID: 24954 RVA: 0x002D5F19 File Offset: 0x002D4119
		public virtual CKNLPGEPGGF.IAPCJOBDCEH APLAAOCGECL()
		{
			if (this.NLIKAGGPANH != null)
			{
				return this.NLIKAGGPANH.PPJOPGPEFGI();
			}
			return null;
		}

		// Token: 0x04000E01 RID: 3585
		public float NOKGPCEEOOG;

		// Token: 0x04000E02 RID: 3586
		public long ODFEKBJCFMN;

		// Token: 0x04000E03 RID: 3587
		public List<int> BILPIGMDPAP = new List<int>();

		// Token: 0x04000E04 RID: 3588
		public bool DBHKKPMINIJ;

		// Token: 0x04000E05 RID: 3589
		public string CEEIHOLNALH;

		// Token: 0x04000E06 RID: 3590
		public bool PFMNPEOKEKO = true;

		// Token: 0x04000E07 RID: 3591
		public JNHLAGHJBAA.FPAEEADMCIE.COGMIMMKMME AHFGACFMGEJ;

		// Token: 0x04000E08 RID: 3592
		public ItemBase NLIKAGGPANH;

		// Token: 0x04000E09 RID: 3593
		public List<JNHLAGHJBAA.FPAEEADMCIE> LACAJHOHACK = new List<JNHLAGHJBAA.FPAEEADMCIE>();

		// Token: 0x020001B1 RID: 433
		// (Invoke) Token: 0x0600617C RID: 24956
		public delegate void COGMIMMKMME(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, ItemBase NLIKAGGPANH, Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB);
	}

	// Token: 0x020001B2 RID: 434
	// (Invoke) Token: 0x06006180 RID: 24960
	public delegate void KDLBACIBOEF(JNHLAGHJBAA ONPHLHKAGFP, JNHLAGHJBAA.FPAEEADMCIE HEABEPINGED);
}
