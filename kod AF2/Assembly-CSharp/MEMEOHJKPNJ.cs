using System;
using UnityEngine;

// Token: 0x020001A0 RID: 416
public class MEMEOHJKPNJ : ONKDCGNBALK
{
	// Token: 0x06005CDE RID: 23774 RVA: 0x002B7498 File Offset: 0x002B5698
	public virtual void EGKHIENICMJ(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		bool enabled = GUI.enabled;
		GUI.enabled = this.FNMCIACNOMH;
		if (this.FNMCIACNOMH && Input.GetMouseButton(0) && (this.OHNAHKMBABD && CFMPGCJMHJM))
		{
			ochcodjiphj.x += 1646f;
			ochcodjiphj.y += 592f;
		}
		bool flag;
		if (this.CKEIHEEMLIL == null)
		{
			GUIStyle guistyle = new GUIStyle(GUI.skin.FindStyle(" ms"));
			guistyle.fontSize = this.KCLLDJJLCGC;
			if (this.HKPAEGGJNGG)
			{
				guistyle.normal.textColor = new Color(1641f, 584f, 1432f, 1409f);
				guistyle.hover.textColor = new Color(1550f, 1367f, 782f, 1494f);
				guistyle.active.textColor = new Color(1359f, 828f, 731f, 1668f);
			}
			flag = GUI.Button(ochcodjiphj, this.DPANHMGCBNL, guistyle);
			if (this.ELOHBOIKEHE != null)
			{
				GUI.DrawTexture(new Rect(ochcodjiphj.x + 312f, ochcodjiphj.y + ochcodjiphj.height / 249f - this.BOEGHBFJJOJ.y / 303f, this.BOEGHBFJJOJ.x, this.BOEGHBFJJOJ.y), this.ELOHBOIKEHE, (ScaleMode)8);
			}
		}
		else
		{
			flag = GUI.Button(ochcodjiphj, this.CKEIHEEMLIL, GUIStyle.none);
			if (this.DPANHMGCBNL != "u_UniqueShadowTexture")
			{
				Rect position = ochcodjiphj;
				position.x += this.BHFHCEPANMI;
				GUIStyle style = new GUIStyle
				{
					fontStyle = FontStyle.Bold,
					fontSize = this.KCLLDJJLCGC,
					alignment = TextAnchor.UpperCenter,
					normal = 
					{
						textColor = new Color(1128f, 1301f, 641f, 1342f)
					}
				};
				GUI.Label(position, this.DPANHMGCBNL, style);
			}
		}
		if (flag)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.FFMGKOIMOPE(true);
			if (CFMPGCJMHJM && this.FNMCIACNOMH && this.LJIEPIPIAJC != null)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("wpn_bait_sz", 1962f);
				this.LJIEPIPIAJC(this);
			}
		}
		GUI.enabled = enabled;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005CDF RID: 23775 RVA: 0x002B7700 File Offset: 0x002B5900
	public virtual void LCOKOEMNPEL(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		bool enabled = GUI.enabled;
		GUI.enabled = this.FNMCIACNOMH;
		if (this.FNMCIACNOMH && Input.GetMouseButton(1) && (this.OHNAHKMBABD && CFMPGCJMHJM))
		{
			ochcodjiphj.x += 1328f;
			ochcodjiphj.y += 1249f;
		}
		bool flag;
		if (this.CKEIHEEMLIL == null)
		{
			GUIStyle guistyle = new GUIStyle(GUI.skin.FindStyle("%)"));
			guistyle.fontSize = this.KCLLDJJLCGC;
			if (this.HKPAEGGJNGG)
			{
				guistyle.normal.textColor = new Color(207f, 45f, 1822f, 373f);
				guistyle.hover.textColor = new Color(1827f, 1153f, 1213f, 1023f);
				guistyle.active.textColor = new Color(619f, 1607f, 1843f, 1423f);
			}
			flag = GUI.Button(ochcodjiphj, this.DPANHMGCBNL, guistyle);
			if (this.ELOHBOIKEHE != null)
			{
				GUI.DrawTexture(new Rect(ochcodjiphj.x + 1424f, ochcodjiphj.y + ochcodjiphj.height / 236f - this.BOEGHBFJJOJ.y / 763f, this.BOEGHBFJJOJ.x, this.BOEGHBFJJOJ.y), this.ELOHBOIKEHE, ScaleMode.ScaleAndCrop);
			}
		}
		else
		{
			flag = GUI.Button(ochcodjiphj, this.CKEIHEEMLIL, GUIStyle.none);
			if (this.DPANHMGCBNL != "wpn_eat1")
			{
				Rect position = ochcodjiphj;
				position.x += this.BHFHCEPANMI;
				GUIStyle style = new GUIStyle
				{
					fontStyle = FontStyle.Normal,
					fontSize = this.KCLLDJJLCGC,
					alignment = TextAnchor.UpperRight,
					normal = 
					{
						textColor = new Color(1615f, 526f, 376f, 1020f)
					}
				};
				GUI.Label(position, this.DPANHMGCBNL, style);
			}
		}
		if (flag)
		{
			JDCEFOFMGHB.JFIDAGABKID().GMCOPAMLIPL = false;
			if (CFMPGCJMHJM && this.FNMCIACNOMH && this.LJIEPIPIAJC != null)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("obscured focus oO", 1107f);
				this.LJIEPIPIAJC(this);
			}
		}
		GUI.enabled = enabled;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005CE0 RID: 23776 RVA: 0x002B7966 File Offset: 0x002B5B66
	public void NDIFBOPMCKC(Texture IDOMFFNBLHE, float BBOODPCDKAJ)
	{
		this.ELOHBOIKEHE = IDOMFFNBLHE;
		this.BOEGHBFJJOJ = new Vector2(BBOODPCDKAJ, BBOODPCDKAJ);
	}

	// Token: 0x06005CE1 RID: 23777 RVA: 0x002B797C File Offset: 0x002B5B7C
	public virtual void MBABINJIPDF(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		bool enabled = GUI.enabled;
		GUI.enabled = this.FNMCIACNOMH;
		if (this.FNMCIACNOMH && Input.GetMouseButton(0) && (this.OHNAHKMBABD && CFMPGCJMHJM))
		{
			ochcodjiphj.x += 548f;
			ochcodjiphj.y += 58f;
		}
		bool flag;
		if (this.CKEIHEEMLIL == null)
		{
			GUIStyle guistyle = new GUIStyle(GUI.skin.FindStyle("_FoamContrast"));
			guistyle.fontSize = this.KCLLDJJLCGC;
			if (this.HKPAEGGJNGG)
			{
				guistyle.normal.textColor = new Color(1664f, 1561f, 1532f, 1658f);
				guistyle.hover.textColor = new Color(1112f, 1497f, 471f, 1970f);
				guistyle.active.textColor = new Color(926f, 434f, 1294f, 806f);
			}
			flag = GUI.Button(ochcodjiphj, this.DPANHMGCBNL, guistyle);
			if (this.ELOHBOIKEHE != null)
			{
				GUI.DrawTexture(new Rect(ochcodjiphj.x + 684f, ochcodjiphj.y + ochcodjiphj.height / 1250f - this.BOEGHBFJJOJ.y / 197f, this.BOEGHBFJJOJ.x, this.BOEGHBFJJOJ.y), this.ELOHBOIKEHE, ScaleMode.StretchToFill);
			}
		}
		else
		{
			flag = GUI.Button(ochcodjiphj, this.CKEIHEEMLIL, GUIStyle.none);
			if (this.DPANHMGCBNL != "_MotionBlurTmpCam")
			{
				Rect position = ochcodjiphj;
				position.x += this.BHFHCEPANMI;
				GUIStyle style = new GUIStyle
				{
					fontStyle = FontStyle.Normal,
					fontSize = this.KCLLDJJLCGC,
					alignment = TextAnchor.UpperLeft,
					normal = 
					{
						textColor = new Color(1037f, 1819f, 1616f, 454f)
					}
				};
				GUI.Label(position, this.DPANHMGCBNL, style);
			}
		}
		if (flag)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().GMCOPAMLIPL = true;
			if (CFMPGCJMHJM && this.FNMCIACNOMH && this.LJIEPIPIAJC != null)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("Wizard Block", 1856f);
				this.LJIEPIPIAJC(this);
			}
		}
		GUI.enabled = enabled;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005CE2 RID: 23778 RVA: 0x002B7BE4 File Offset: 0x002B5DE4
	public virtual void JOBPKNNNEAD(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		bool enabled = GUI.enabled;
		GUI.enabled = this.FNMCIACNOMH;
		if (this.FNMCIACNOMH && Input.GetMouseButton(1) && (this.OHNAHKMBABD && CFMPGCJMHJM))
		{
			ochcodjiphj.x += 1966f;
			ochcodjiphj.y += 313f;
		}
		bool flag;
		if (this.CKEIHEEMLIL == null)
		{
			GUIStyle guistyle = new GUIStyle(GUI.skin.FindStyle("inv_pcs1"));
			guistyle.fontSize = this.KCLLDJJLCGC;
			if (this.HKPAEGGJNGG)
			{
				guistyle.normal.textColor = new Color(1705f, 812f, 1325f, 348f);
				guistyle.hover.textColor = new Color(1920f, 433f, 228f, 756f);
				guistyle.active.textColor = new Color(103f, 1823f, 38f, 1388f);
			}
			flag = GUI.Button(ochcodjiphj, this.DPANHMGCBNL, guistyle);
			if (this.ELOHBOIKEHE != null)
			{
				GUI.DrawTexture(new Rect(ochcodjiphj.x + 686f, ochcodjiphj.y + ochcodjiphj.height / 872f - this.BOEGHBFJJOJ.y / 136f, this.BOEGHBFJJOJ.x, this.BOEGHBFJJOJ.y), this.ELOHBOIKEHE, ScaleMode.StretchToFill);
			}
		}
		else
		{
			flag = GUI.Button(ochcodjiphj, this.CKEIHEEMLIL, GUIStyle.none);
			if (this.DPANHMGCBNL != "PLANE_REFLECTION")
			{
				Rect position = ochcodjiphj;
				position.x += this.BHFHCEPANMI;
				GUIStyle style = new GUIStyle
				{
					fontStyle = FontStyle.Bold,
					fontSize = this.KCLLDJJLCGC,
					alignment = TextAnchor.UpperCenter,
					normal = 
					{
						textColor = new Color(1858f, 1531f, 1570f, 955f)
					}
				};
				GUI.Label(position, this.DPANHMGCBNL, style);
			}
		}
		if (flag)
		{
			JDCEFOFMGHB.JFIDAGABKID().OHHMBDOICNG(false);
			if (CFMPGCJMHJM && this.FNMCIACNOMH && this.LJIEPIPIAJC != null)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("Delete Weapon", 592f);
				this.LJIEPIPIAJC(this);
			}
		}
		GUI.enabled = enabled;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005CE3 RID: 23779 RVA: 0x002B7966 File Offset: 0x002B5B66
	public void JKMDIBLBMDL(Texture IDOMFFNBLHE, float BBOODPCDKAJ)
	{
		this.ELOHBOIKEHE = IDOMFFNBLHE;
		this.BOEGHBFJJOJ = new Vector2(BBOODPCDKAJ, BBOODPCDKAJ);
	}

	// Token: 0x06005CE4 RID: 23780 RVA: 0x002B7E4C File Offset: 0x002B604C
	public virtual void KNCJKEEICGO(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		bool enabled = GUI.enabled;
		GUI.enabled = this.FNMCIACNOMH;
		if (this.FNMCIACNOMH && Input.GetMouseButton(0) && (this.OHNAHKMBABD && CFMPGCJMHJM))
		{
			ochcodjiphj.x += 666f;
			ochcodjiphj.y += 1398f;
		}
		bool flag;
		if (this.CKEIHEEMLIL == null)
		{
			GUIStyle guistyle = new GUIStyle(GUI.skin.FindStyle("error.wav"));
			guistyle.fontSize = this.KCLLDJJLCGC;
			if (this.HKPAEGGJNGG)
			{
				guistyle.normal.textColor = new Color(1006f, 773f, 446f, 527f);
				guistyle.hover.textColor = new Color(1876f, 1369f, 176f, 470f);
				guistyle.active.textColor = new Color(1930f, 1127f, 375f, 1624f);
			}
			flag = GUI.Button(ochcodjiphj, this.DPANHMGCBNL, guistyle);
			if (this.ELOHBOIKEHE != null)
			{
				GUI.DrawTexture(new Rect(ochcodjiphj.x + 1006f, ochcodjiphj.y + ochcodjiphj.height / 1433f - this.BOEGHBFJJOJ.y / 1434f, this.BOEGHBFJJOJ.x, this.BOEGHBFJJOJ.y), this.ELOHBOIKEHE, ScaleMode.ScaleToFit);
			}
		}
		else
		{
			flag = GUI.Button(ochcodjiphj, this.CKEIHEEMLIL, GUIStyle.none);
			if (this.DPANHMGCBNL != "")
			{
				Rect position = ochcodjiphj;
				position.x += this.BHFHCEPANMI;
				GUIStyle style = new GUIStyle
				{
					fontStyle = FontStyle.Bold,
					fontSize = this.KCLLDJJLCGC,
					alignment = TextAnchor.LowerLeft,
					normal = 
					{
						textColor = new Color(96f, 540f, 1664f, 1342f)
					}
				};
				GUI.Label(position, this.DPANHMGCBNL, style);
			}
		}
		if (flag)
		{
			JDCEFOFMGHB.JFIDAGABKID().FFMGKOIMOPE(true);
			if (CFMPGCJMHJM && this.FNMCIACNOMH && this.LJIEPIPIAJC != null)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("PistolReload", 1893f);
				this.LJIEPIPIAJC(this);
			}
		}
		GUI.enabled = enabled;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005CE5 RID: 23781 RVA: 0x002B80B4 File Offset: 0x002B62B4
	public virtual void GMLICBKPPCC(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		bool enabled = GUI.enabled;
		GUI.enabled = this.FNMCIACNOMH;
		if (this.FNMCIACNOMH && Input.GetMouseButton(1) && (this.OHNAHKMBABD && CFMPGCJMHJM))
		{
			ochcodjiphj.x += 370f;
			ochcodjiphj.y += 423f;
		}
		bool flag;
		if (this.CKEIHEEMLIL == null)
		{
			GUIStyle guistyle = new GUIStyle(GUI.skin.FindStyle("delacc"));
			guistyle.fontSize = this.KCLLDJJLCGC;
			if (this.HKPAEGGJNGG)
			{
				guistyle.normal.textColor = new Color(1746f, 502f, 1149f, 2f);
				guistyle.hover.textColor = new Color(1408f, 1950f, 493f, 1654f);
				guistyle.active.textColor = new Color(1258f, 1360f, 824f, 1590f);
			}
			flag = GUI.Button(ochcodjiphj, this.DPANHMGCBNL, guistyle);
			if (this.ELOHBOIKEHE != null)
			{
				GUI.DrawTexture(new Rect(ochcodjiphj.x + 206f, ochcodjiphj.y + ochcodjiphj.height / 1856f - this.BOEGHBFJJOJ.y / 77f, this.BOEGHBFJJOJ.x, this.BOEGHBFJJOJ.y), this.ELOHBOIKEHE, (ScaleMode)5);
			}
		}
		else
		{
			flag = GUI.Button(ochcodjiphj, this.CKEIHEEMLIL, GUIStyle.none);
			if (this.DPANHMGCBNL != "1 Hand Sword Jab ready strafe right")
			{
				Rect position = ochcodjiphj;
				position.x += this.BHFHCEPANMI;
				GUIStyle style = new GUIStyle
				{
					fontStyle = FontStyle.Bold,
					fontSize = this.KCLLDJJLCGC,
					alignment = TextAnchor.LowerRight,
					normal = 
					{
						textColor = new Color(759f, 1858f, 43f, 1937f)
					}
				};
				GUI.Label(position, this.DPANHMGCBNL, style);
			}
		}
		if (flag)
		{
			JDCEFOFMGHB.JFIDAGABKID().OHHMBDOICNG(true);
			if (CFMPGCJMHJM && this.FNMCIACNOMH && this.LJIEPIPIAJC != null)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("Root transform is null. Can't initiate Grounding.", 1221f);
				this.LJIEPIPIAJC(this);
			}
		}
		GUI.enabled = enabled;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005CE6 RID: 23782 RVA: 0x002B7966 File Offset: 0x002B5B66
	public void ACEHAFIPABP(Texture IDOMFFNBLHE, float BBOODPCDKAJ)
	{
		this.ELOHBOIKEHE = IDOMFFNBLHE;
		this.BOEGHBFJJOJ = new Vector2(BBOODPCDKAJ, BBOODPCDKAJ);
	}

	// Token: 0x06005CE7 RID: 23783 RVA: 0x002B7966 File Offset: 0x002B5B66
	public void EDLPHHCCEJE(Texture IDOMFFNBLHE, float BBOODPCDKAJ)
	{
		this.ELOHBOIKEHE = IDOMFFNBLHE;
		this.BOEGHBFJJOJ = new Vector2(BBOODPCDKAJ, BBOODPCDKAJ);
	}

	// Token: 0x06005CE8 RID: 23784 RVA: 0x002B7966 File Offset: 0x002B5B66
	public void EONGFJFPGGD(Texture IDOMFFNBLHE, float BBOODPCDKAJ)
	{
		this.ELOHBOIKEHE = IDOMFFNBLHE;
		this.BOEGHBFJJOJ = new Vector2(BBOODPCDKAJ, BBOODPCDKAJ);
	}

	// Token: 0x06005CE9 RID: 23785 RVA: 0x002B7966 File Offset: 0x002B5B66
	public void GOABAJDGJHF(Texture IDOMFFNBLHE, float BBOODPCDKAJ)
	{
		this.ELOHBOIKEHE = IDOMFFNBLHE;
		this.BOEGHBFJJOJ = new Vector2(BBOODPCDKAJ, BBOODPCDKAJ);
	}

	// Token: 0x06005CEA RID: 23786 RVA: 0x002B7966 File Offset: 0x002B5B66
	public void OAGDPNGOLIG(Texture IDOMFFNBLHE, float BBOODPCDKAJ)
	{
		this.ELOHBOIKEHE = IDOMFFNBLHE;
		this.BOEGHBFJJOJ = new Vector2(BBOODPCDKAJ, BBOODPCDKAJ);
	}

	// Token: 0x06005CEB RID: 23787 RVA: 0x002B831C File Offset: 0x002B651C
	public MEMEOHJKPNJ(ONKDCGNBALK OCBAOFLJBGP, float POFBHAEFJNE, float AIIFDJADHJP, float CGHAOFGOEFI, float GGAEPDHOCEC, string DPANHMGCBNL, string ODFEKBJCFMN, Texture KEDGAOBCNJG, ONKDCGNBALK.CMMHGMILOIM LJIEPIPIAJC) : base(OCBAOFLJBGP, POFBHAEFJNE, AIIFDJADHJP, CGHAOFGOEFI, GGAEPDHOCEC, DPANHMGCBNL, 0, 3)
	{
		this.KNIOGNKKINO = 3;
		this.CKEIHEEMLIL = KEDGAOBCNJG;
		this.FNPEGDKBKJC = ODFEKBJCFMN;
		this.LJIEPIPIAJC = LJIEPIPIAJC;
	}

	// Token: 0x06005CEC RID: 23788 RVA: 0x002B7966 File Offset: 0x002B5B66
	public void OJEJODKDIIA(Texture IDOMFFNBLHE, float BBOODPCDKAJ)
	{
		this.ELOHBOIKEHE = IDOMFFNBLHE;
		this.BOEGHBFJJOJ = new Vector2(BBOODPCDKAJ, BBOODPCDKAJ);
	}

	// Token: 0x06005CED RID: 23789 RVA: 0x002B7966 File Offset: 0x002B5B66
	public void OGFLIGFJBFG(Texture IDOMFFNBLHE, float BBOODPCDKAJ)
	{
		this.ELOHBOIKEHE = IDOMFFNBLHE;
		this.BOEGHBFJJOJ = new Vector2(BBOODPCDKAJ, BBOODPCDKAJ);
	}

	// Token: 0x06005CEE RID: 23790 RVA: 0x002B7966 File Offset: 0x002B5B66
	public void BJMFKIFNCHH(Texture IDOMFFNBLHE, float BBOODPCDKAJ)
	{
		this.ELOHBOIKEHE = IDOMFFNBLHE;
		this.BOEGHBFJJOJ = new Vector2(BBOODPCDKAJ, BBOODPCDKAJ);
	}

	// Token: 0x06005CEF RID: 23791 RVA: 0x002B836C File Offset: 0x002B656C
	public virtual void BFHPJCKICCE(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		bool enabled = GUI.enabled;
		GUI.enabled = this.FNMCIACNOMH;
		if (this.FNMCIACNOMH && Input.GetMouseButton(1) && (this.OHNAHKMBABD && CFMPGCJMHJM))
		{
			ochcodjiphj.x += 521f;
			ochcodjiphj.y += 1582f;
		}
		bool flag;
		if (this.CKEIHEEMLIL == null)
		{
			GUIStyle guistyle = new GUIStyle(GUI.skin.FindStyle("MotorbikeLookBack"));
			guistyle.fontSize = this.KCLLDJJLCGC;
			if (this.HKPAEGGJNGG)
			{
				guistyle.normal.textColor = new Color(1463f, 1366f, 647f, 1324f);
				guistyle.hover.textColor = new Color(1625f, 1042f, 837f, 1174f);
				guistyle.active.textColor = new Color(1633f, 1631f, 1874f, 326f);
			}
			flag = GUI.Button(ochcodjiphj, this.DPANHMGCBNL, guistyle);
			if (this.ELOHBOIKEHE != null)
			{
				GUI.DrawTexture(new Rect(ochcodjiphj.x + 1364f, ochcodjiphj.y + ochcodjiphj.height / 1924f - this.BOEGHBFJJOJ.y / 822f, this.BOEGHBFJJOJ.x, this.BOEGHBFJJOJ.y), this.ELOHBOIKEHE, (ScaleMode)3);
			}
		}
		else
		{
			flag = GUI.Button(ochcodjiphj, this.CKEIHEEMLIL, GUIStyle.none);
			if (this.DPANHMGCBNL != "|")
			{
				Rect position = ochcodjiphj;
				position.x += this.BHFHCEPANMI;
				GUIStyle style = new GUIStyle
				{
					fontStyle = FontStyle.Bold,
					fontSize = this.KCLLDJJLCGC,
					alignment = TextAnchor.UpperRight,
					normal = 
					{
						textColor = new Color(51f, 910f, 508f, 1289f)
					}
				};
				GUI.Label(position, this.DPANHMGCBNL, style);
			}
		}
		if (flag)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL = true;
			if (CFMPGCJMHJM && this.FNMCIACNOMH && this.LJIEPIPIAJC != null)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("wpn_line1", 441f);
				this.LJIEPIPIAJC(this);
			}
		}
		GUI.enabled = enabled;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005CF0 RID: 23792 RVA: 0x002B85D4 File Offset: 0x002B67D4
	public override void HFJFBDPNCCB(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		bool enabled = GUI.enabled;
		GUI.enabled = this.FNMCIACNOMH;
		if (this.FNMCIACNOMH && Input.GetMouseButton(0) && (this.OHNAHKMBABD && CFMPGCJMHJM))
		{
			ochcodjiphj.x += 1f;
			ochcodjiphj.y += 1f;
		}
		bool flag;
		if (this.CKEIHEEMLIL == null)
		{
			GUIStyle guistyle = new GUIStyle(GUI.skin.FindStyle("Button"));
			guistyle.fontSize = this.KCLLDJJLCGC;
			if (this.HKPAEGGJNGG)
			{
				guistyle.normal.textColor = new Color(0f, 0.2f, 0.3f, 1f);
				guistyle.hover.textColor = new Color(0f, 0.2f, 0.3f, 1f);
				guistyle.active.textColor = new Color(0f, 0.2f, 0.3f, 1f);
			}
			flag = GUI.Button(ochcodjiphj, this.DPANHMGCBNL, guistyle);
			if (this.ELOHBOIKEHE != null)
			{
				GUI.DrawTexture(new Rect(ochcodjiphj.x + 6f, ochcodjiphj.y + ochcodjiphj.height / 2f - this.BOEGHBFJJOJ.y / 2f, this.BOEGHBFJJOJ.x, this.BOEGHBFJJOJ.y), this.ELOHBOIKEHE, ScaleMode.ScaleToFit);
			}
		}
		else
		{
			flag = GUI.Button(ochcodjiphj, this.CKEIHEEMLIL, GUIStyle.none);
			if (this.DPANHMGCBNL != "")
			{
				Rect position = ochcodjiphj;
				position.x += this.BHFHCEPANMI;
				GUIStyle style = new GUIStyle
				{
					fontStyle = FontStyle.Normal,
					fontSize = this.KCLLDJJLCGC,
					alignment = TextAnchor.MiddleLeft,
					normal = 
					{
						textColor = new Color(0.8f, 0.8f, 0.6f, 1f)
					}
				};
				GUI.Label(position, this.DPANHMGCBNL, style);
			}
		}
		if (flag)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL = true;
			if (CFMPGCJMHJM && this.FNMCIACNOMH && this.LJIEPIPIAJC != null)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
				this.LJIEPIPIAJC(this);
			}
		}
		GUI.enabled = enabled;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005CF1 RID: 23793 RVA: 0x002B883C File Offset: 0x002B6A3C
	public MEMEOHJKPNJ(ONKDCGNBALK OCBAOFLJBGP, float POFBHAEFJNE, float AIIFDJADHJP, float CGHAOFGOEFI, float GGAEPDHOCEC, string DPANHMGCBNL, int ODFEKBJCFMN, Texture KEDGAOBCNJG, ONKDCGNBALK.CMMHGMILOIM LJIEPIPIAJC) : base(OCBAOFLJBGP, POFBHAEFJNE, AIIFDJADHJP, CGHAOFGOEFI, GGAEPDHOCEC, DPANHMGCBNL, ODFEKBJCFMN, 3)
	{
		this.KNIOGNKKINO = 3;
		this.CKEIHEEMLIL = KEDGAOBCNJG;
		this.LJIEPIPIAJC = LJIEPIPIAJC;
	}

	// Token: 0x06005CF2 RID: 23794 RVA: 0x002B8888 File Offset: 0x002B6A88
	public virtual void KCHEILEJGPL(bool CFMPGCJMHJM)
	{
		Rect ochcodjiphj = this.OCHCODJIPHJ;
		bool enabled = GUI.enabled;
		GUI.enabled = this.FNMCIACNOMH;
		if (this.FNMCIACNOMH && Input.GetMouseButton(1) && (this.OHNAHKMBABD && CFMPGCJMHJM))
		{
			ochcodjiphj.x += 249f;
			ochcodjiphj.y += 1183f;
		}
		bool flag;
		if (this.CKEIHEEMLIL == null)
		{
			GUIStyle guistyle = new GUIStyle(GUI.skin.FindStyle("Okay"));
			guistyle.fontSize = this.KCLLDJJLCGC;
			if (this.HKPAEGGJNGG)
			{
				guistyle.normal.textColor = new Color(1677f, 922f, 1086f, 761f);
				guistyle.hover.textColor = new Color(862f, 876f, 370f, 891f);
				guistyle.active.textColor = new Color(356f, 1166f, 1552f, 1430f);
			}
			flag = GUI.Button(ochcodjiphj, this.DPANHMGCBNL, guistyle);
			if (this.ELOHBOIKEHE != null)
			{
				GUI.DrawTexture(new Rect(ochcodjiphj.x + 1975f, ochcodjiphj.y + ochcodjiphj.height / 192f - this.BOEGHBFJJOJ.y / 1029f, this.BOEGHBFJJOJ.x, this.BOEGHBFJJOJ.y), this.ELOHBOIKEHE, (ScaleMode)4);
			}
		}
		else
		{
			flag = GUI.Button(ochcodjiphj, this.CKEIHEEMLIL, GUIStyle.none);
			if (this.DPANHMGCBNL != "_DelItem.wav")
			{
				Rect position = ochcodjiphj;
				position.x += this.BHFHCEPANMI;
				GUIStyle style = new GUIStyle
				{
					fontStyle = FontStyle.Bold,
					fontSize = this.KCLLDJJLCGC,
					alignment = TextAnchor.UpperCenter,
					normal = 
					{
						textColor = new Color(424f, 782f, 1634f, 985f)
					}
				};
				GUI.Label(position, this.DPANHMGCBNL, style);
			}
		}
		if (flag)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().OHHMBDOICNG(true);
			if (CFMPGCJMHJM && this.FNMCIACNOMH && this.LJIEPIPIAJC != null)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("", 1640f);
				this.LJIEPIPIAJC(this);
			}
		}
		GUI.enabled = enabled;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005CF3 RID: 23795 RVA: 0x002B7966 File Offset: 0x002B5B66
	public void NBNDIKDANHL(Texture IDOMFFNBLHE, float BBOODPCDKAJ)
	{
		this.ELOHBOIKEHE = IDOMFFNBLHE;
		this.BOEGHBFJJOJ = new Vector2(BBOODPCDKAJ, BBOODPCDKAJ);
	}

	// Token: 0x06005CF4 RID: 23796 RVA: 0x002B7966 File Offset: 0x002B5B66
	public void MLCLKFJLGNP(Texture IDOMFFNBLHE, float BBOODPCDKAJ)
	{
		this.ELOHBOIKEHE = IDOMFFNBLHE;
		this.BOEGHBFJJOJ = new Vector2(BBOODPCDKAJ, BBOODPCDKAJ);
	}

	// Token: 0x06005CF5 RID: 23797 RVA: 0x002B7966 File Offset: 0x002B5B66
	public void FKNKCMNJPEJ(Texture IDOMFFNBLHE, float BBOODPCDKAJ)
	{
		this.ELOHBOIKEHE = IDOMFFNBLHE;
		this.BOEGHBFJJOJ = new Vector2(BBOODPCDKAJ, BBOODPCDKAJ);
	}

	// Token: 0x04000DB6 RID: 3510
	private readonly Texture CKEIHEEMLIL;

	// Token: 0x04000DB7 RID: 3511
	public float BHFHCEPANMI = 36f;

	// Token: 0x04000DB8 RID: 3512
	public bool HKPAEGGJNGG;

	// Token: 0x04000DB9 RID: 3513
	public Texture ELOHBOIKEHE;

	// Token: 0x04000DBA RID: 3514
	public Vector2 BOEGHBFJJOJ;

	// Token: 0x04000DBB RID: 3515
	public int KCLLDJJLCGC = 12;
}
