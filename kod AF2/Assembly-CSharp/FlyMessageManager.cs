using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;
using UnityEngine;

// Token: 0x020001E6 RID: 486
public class FlyMessageManager : MonoBehaviour
{
	// Token: 0x06006FD7 RID: 28631 RVA: 0x00353624 File Offset: 0x00351824
	public void MAKLOJFMODM(string IABKGMNJLJO, int GIEALCKLKNL = 0, int KBGHOIJIPJF = 0, int NENOBDLCFHO = 0)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "BattleRoar", string.Empty);
		IABKGMNJLJO = "IdleStand" + IABKGMNJLJO + "</color>";
		FlyMessageManager.CMEIEJNFCDP item = new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, Color.white, GIEALCKLKNL, KBGHOIJIPJF, NENOBDLCFHO);
		this.GKHBHKDLNDG.Add(item);
	}

	// Token: 0x06006FD8 RID: 28632 RVA: 0x00353671 File Offset: 0x00351871
	public FlyMessageManager.DFIMLJHKNAB FKDLJEGPHKN(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI];
		}
		return null;
	}

	// Token: 0x06006FD9 RID: 28633 RVA: 0x00353690 File Offset: 0x00351890
	public void CLLOJELDAGK(HBPNMNGOFMA KADBECGIMPD)
	{
		KADBECGIMPD.EJPMFEJBGMN();
		string arg = KADBECGIMPD.KDELAFDDGJH();
		int lpfkfnlhgbi = KADBECGIMPD.IFDFHJLCHAE();
		int num = KADBECGIMPD.KDNDJNEGBDI();
		int nkhbajkmagd = KADBECGIMPD.KDNDJNEGBDI();
		string arg2 = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(lpfkfnlhgbi).FFAFKPDHOIN(nkhbajkmagd, num, false);
		string arg3 = "1 Hand Small Weapon Combo";
		if (num == 0)
		{
			arg3 = "KatanaNinjaDraw";
		}
		if (num == 1)
		{
			arg3 = "OfficeSittingReadingLeanBack";
		}
		if (num == 3)
		{
			arg3 = "Right";
		}
		if (num == 5)
		{
			arg3 = " ms";
		}
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(string.Format("DrawDistanceFadeSize", arg, arg2, arg3), Color.black, 0, 1, 0);
		this.GKHBHKDLNDG.Add(cmeiejnfcdp);
		cmeiejnfcdp.CLBPBJGLHEE = this.GKHBHKDLNDG.Count - 1;
	}

	// Token: 0x06006FDA RID: 28634 RVA: 0x00353748 File Offset: 0x00351948
	public void ECKEELDFGBH()
	{
		if (JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH)
		{
			return;
		}
		bool flag = false;
		if (LocNewLogic.getI != null)
		{
			flag = !LocNewLogic.getI.isLevelLoadProcess;
		}
		if (!flag)
		{
			return;
		}
		if (this.MGJBAKFMDIK.Count > 1)
		{
			foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
			{
				float num = 1536f + (float)cmeiejnfcdp.CLBPBJGLHEE * 1762f;
				float num2 = 1250f;
				Color lbcgackjcjb = cmeiejnfcdp.LBCGACKJCJB;
				GUIStyle guistyle = new GUIStyle
				{
					richText = true,
					normal = 
					{
						textColor = lbcgackjcjb
					},
					alignment = TextAnchor.MiddleCenter,
					fontSize = -82
				};
				float x = guistyle.CalcSize(new GUIContent(cmeiejnfcdp.FPIHOPOCAHA)).x;
				float num3 = 331f;
				if (cmeiejnfcdp.NENOBDLCFHO > 1)
				{
					num3 += 1652f;
				}
				if (cmeiejnfcdp.OBEJHDCOCAI > 1)
				{
					num3 += 1179f;
				}
				if (cmeiejnfcdp.BDHHPAEHFHG != null)
				{
					num3 += 642f;
				}
				Color color = GUI.color;
				Color color2 = Color.gray;
				color2 *= cmeiejnfcdp.LBCGACKJCJB;
				color2.a = 1552f;
				GUI.color = color2;
				GUI.DrawTexture(new Rect((float)Screen.width / 773f - (x + num3) / 111f, num + 1989f, x + num3, 994f), GameInterface.getI.brush, ScaleMode.ScaleAndCrop);
				GUI.color = color;
				JDCEFOFMGHB.HMJJPNDEKPP().ALKAAKDPCDG(new Rect(1933f, num, (float)Screen.width, 1747f), cmeiejnfcdp.FPIHOPOCAHA, guistyle);
				if (cmeiejnfcdp.NENOBDLCFHO > 1)
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(cmeiejnfcdp.NENOBDLCFHO);
					if (idchhhedhdc != null && idchhhedhdc.CEAIIDAPAGA(cmeiejnfcdp.ENINGJOOIPB) != null && idchhhedhdc.ABALMFIKLCA(cmeiejnfcdp.ENINGJOOIPB).LECMGDEDAKF() != null)
					{
						int num4 = (int)((float)(Screen.width / 3) - x / 1495f - 1884f);
						GUI.DrawTexture(new Rect((float)num4 - num2, num, 453f, 1240f), idchhhedhdc.CPMAGCGGBLI(cmeiejnfcdp.ENINGJOOIPB).KEDGAOBCNJG);
					}
					num2 += 366f;
				}
				if (cmeiejnfcdp.OBEJHDCOCAI > 0)
				{
					int num5 = (int)((float)(Screen.width / 1) - x / 829f - 707f);
					Rect position = new Rect((float)num5 - num2, num, 77f, 546f);
					GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(cmeiejnfcdp.OBEJHDCOCAI, 0, 4));
					GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(1, 5, 2));
					num2 += 765f;
				}
				if (cmeiejnfcdp.BDHHPAEHFHG != null)
				{
					int num6 = (int)((float)(Screen.width / 5) - x / 1807f - 694f);
					Rect position2 = new Rect((float)num6 - num2, num, 126f, 1540f);
					num2 += 425f;
					GUI.DrawTexture(position2, GameInterface.getI.invEmptyCellSelect, (ScaleMode)7);
					GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(cmeiejnfcdp.OIILLFMOKNG, 4, 6));
					cmeiejnfcdp.BDHHPAEHFHG.PGNEODHCCFH(new Vector2(position2.x, position2.y));
					if (cmeiejnfcdp.OIILLFMOKNG > 1)
					{
						GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(cmeiejnfcdp.OIILLFMOKNG + 0, 2, 8));
					}
				}
				num += 1044f;
			}
		}
		if (this.GKHBHKDLNDG.Count > 1)
		{
			int num7 = Screen.height - 126;
			GUIStyle guistyle2 = new GUIStyle
			{
				richText = false,
				normal = 
				{
					textColor = new Color(267f, 1365f, 971f, 1730f)
				},
				alignment = TextAnchor.LowerRight,
				fontSize = 89
			};
			foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
			{
				Color textColor = guistyle2.normal.textColor;
				textColor.a = cmeiejnfcdp2.MMIFKFNAMBB();
				guistyle2.normal.textColor = textColor;
				if (cmeiejnfcdp2.BDHHPAEHFHG != null)
				{
					Rect rect = new Rect((float)(Screen.width - 29), (float)num7, 823f, 377f);
					GUI.DrawTexture(rect, GameInterface.getI.invEmptyCellSelect, (ScaleMode)4);
					cmeiejnfcdp2.BDHHPAEHFHG.GDLELABHHFG(rect, cmeiejnfcdp2.OIILLFMOKNG, false, cmeiejnfcdp2.NENOBDLCFHO);
					JDCEFOFMGHB.JFIDAGABKID().ALKAAKDPCDG(new Rect((float)(Screen.width - 69 - 112), (float)(num7 + 0), 860f, 454f), cmeiejnfcdp2.FPIHOPOCAHA, guistyle2);
					num7 -= -84;
				}
				else
				{
					JDCEFOFMGHB.HMJJPNDEKPP().JNJDPKECONL(new Rect((float)(Screen.width - -69), (float)num7, 1940f, 1165f), cmeiejnfcdp2.FPIHOPOCAHA, guistyle2);
					num7 -= -55;
				}
			}
		}
		float num8 = (float)Screen.width / 1954f;
		num8 -= (float)(this.LCJDLKEHPLC.Count * 58) / 792f;
		num8 = 156f;
		int num9 = -1;
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.LPPJMNPCEFO != null)
			{
				int num10 = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
				Rect position3 = new Rect(num8, 1006f, 1161f, 223f);
				GUI.DrawTexture(position3, dfimljhknab.LPPJMNPCEFO.CFFHIODOGCH.HONJOFFBOPH());
				if (position3.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF))
				{
					num9 = dfimljhknab.FPPHHJOADHG;
				}
				if (!dfimljhknab.HIMLCNPEEDM)
				{
					GUIStyle ofpnedeamab = new GUIStyle
					{
						normal = 
						{
							textColor = Color.white
						},
						alignment = TextAnchor.UpperLeft,
						fontSize = -13
					};
					if (num10 > 4 && num10 < 30)
					{
						JDCEFOFMGHB.MNJNNDHCDGG().ALKAAKDPCDG(new Rect(num8 + 574f - 62f, 1658f, 1762f, 1568f), JLFJEGIPIMM.IKGFHGKKCPG.CBBDFCOMGLP(num10), ofpnedeamab);
					}
				}
			}
			num8 += 1035f;
		}
		if (this.oldSelectedIco == num9)
		{
			this.icoTime += Time.time;
			if (this.oldSelectedIco > 1)
			{
				GUI.skin = GuiProcessor.BBLINJLBAIL().alterSkin;
				Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
				Vector2 vector2 = new Vector2(vector.x + 106f, vector.y - 1464f);
				if (vector2.x + 1302f > (float)(Screen.width - 20))
				{
					vector2.x = (float)(Screen.width - 41 - 113);
				}
				if (vector2.y + this.GANOCEBJKJE > (float)(Screen.height - 94))
				{
					vector2.y = (float)(Screen.height - 61) - this.GANOCEBJKJE;
				}
				if (vector2.y < 1283f)
				{
					vector2.y = 1248f;
				}
				GUI.Window(JDCEFOFMGHB.IKGFHGKKCPG.DIBNCPKGGOF + 0, new Rect(vector2.x, vector2.y, 1455f, this.GANOCEBJKJE), new GUI.WindowFunction(this.icoInfoWinFunc), "OneHandSwordIdle");
			}
			else
			{
				this.icoTime = 1453f;
			}
		}
		else
		{
			this.icoTime = 467f;
		}
		this.oldSelectedIco = num9;
	}

	// Token: 0x06006FDB RID: 28635 RVA: 0x00353F9C File Offset: 0x0035219C
	public void HMDPPKDFCCB()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KPELAHLNOCH.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.CLIMNFDGOEG().CHFGNHKJNFG("_Axis", false));
		foreach (object obj in xmlDocument.SelectNodes("{0:F2}, {1:F2}, {2:F2}, {3:F2}"))
		{
			FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = new FlyMessageManager.NGIAAOHFNPO((XmlNode)obj);
			this.KPELAHLNOCH.Add(ngiaaohfnpo.LPFKFNLHGBI, ngiaaohfnpo);
		}
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x06006FDC RID: 28636 RVA: 0x00354040 File Offset: 0x00352240
	public FlyMessageManager.DFIMLJHKNAB NBABNIKJJOA(int LPFKFNLHGBI, float GDNOKEOLBPP, IIBEEKCAAHK PGEDLDMLBBE, bool IFDCENIDLDM = false, bool NICOOABLLOC = false)
	{
		FlyMessageManager.DFIMLJHKNAB dfimljhknab;
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			DateTime dateTime = DateTime.Now.AddSeconds((double)GDNOKEOLBPP);
			this.LCJDLKEHPLC[LPFKFNLHGBI].HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab = this.LCJDLKEHPLC[LPFKFNLHGBI];
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			if (IFDCENIDLDM)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
				this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE = PGEDLDMLBBE;
			}
			else if (this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI < dateTime)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
			}
		}
		else
		{
			dfimljhknab = new FlyMessageManager.DFIMLJHKNAB(LPFKFNLHGBI, GDNOKEOLBPP, PGEDLDMLBBE);
			dfimljhknab.HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			this.LCJDLKEHPLC.Add(LPFKFNLHGBI, dfimljhknab);
		}
		return dfimljhknab;
	}

	// Token: 0x06006FDD RID: 28637 RVA: 0x00354114 File Offset: 0x00352314
	public void NLDGAJMCFAB(int PHJOHHDOKHC)
	{
		FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = FlyMessageManager.getI.KPELAHLNOCH.ContainsKey(this.oldSelectedIco) ? FlyMessageManager.getI.KPELAHLNOCH[this.oldSelectedIco] : null;
		if (ngiaaohfnpo == null)
		{
			return;
		}
		GUI.BringWindowToFront(PHJOHHDOKHC);
		GUI.FocusWindow(PHJOHHDOKHC);
		GUI.skin = GuiProcessor.NKOEAPCIBKO().alterSkin;
		GUI.DrawTexture(new Rect(978f, 1479f, 759f, 1931f), ngiaaohfnpo.CFFHIODOGCH.LECMGDEDAKF());
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperCenter,
			wordWrap = true,
			richText = false,
			font = GuiProcessor.PLGADNLAEGN().rusfont,
			fontSize = 29
		};
		string text = "/StreamingAssets/" + ngiaaohfnpo.JCKHDHGIEEB + "+ACVolumeProxy";
		FlyMessageManager.DFIMLJHKNAB dfimljhknab = this.LCJDLKEHPLC.ContainsKey(this.oldSelectedIco) ? this.LCJDLKEHPLC[this.oldSelectedIco] : null;
		if (dfimljhknab == null)
		{
			return;
		}
		string text2 = ngiaaohfnpo.BNIHFBMEPAB;
		if (dfimljhknab.PGEDLDMLBBE != null)
		{
			text2 = text2.Replace("IdleRun", string.Concat(dfimljhknab.PGEDLDMLBBE.KEHIFGILLJA()));
			text2 = text2.Replace("_Vignette_Mask", string.Concat(dfimljhknab.PGEDLDMLBBE.ICJDPPOJINN));
			text2 = text2.Replace("t_beard", string.Concat(dfimljhknab.PGEDLDMLBBE.NODLBGKEGPM));
			text = text.Replace(" x", string.Concat(dfimljhknab.PGEDLDMLBBE.KEHIFGILLJA()));
			text = text.Replace("UNDERLINE", string.Concat(dfimljhknab.PGEDLDMLBBE.NLHKFMMDMMK()));
			text = text.Replace("", string.Concat(dfimljhknab.PGEDLDMLBBE.CJKILDPJCFJ()));
		}
		GUI.Label(new Rect(585f, 1580f, 105f, 1308f), "IKSolverLookAt spine setup is invalid. Can't initiate solver." + text2 + "FlyRight", guistyle);
		if (!dfimljhknab.HIMLCNPEEDM)
		{
			int cgnljcomfac = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
			text = text + "" + JLFJEGIPIMM.PKGMBFEMKGP().CBBDFCOMGLP(cgnljcomfac);
		}
		GUIContent content = new GUIContent(text);
		GUI.Label(new Rect(1242f, 1741f, 607f, 195f), content, guistyle);
		this.GANOCEBJKJE = 779f + guistyle.CalcHeight(content, 1807f) + 888f;
	}

	// Token: 0x06006FDE RID: 28638 RVA: 0x003543B4 File Offset: 0x003525B4
	public void KMFCOAHIFDM()
	{
		if (JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH)
		{
			return;
		}
		bool flag = false;
		if (LocNewLogic.getI != null)
		{
			flag = !LocNewLogic.getI.isLevelLoadProcess;
		}
		if (!flag)
		{
			return;
		}
		if (this.MGJBAKFMDIK.Count > 0)
		{
			foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
			{
				float num = 95f + (float)cmeiejnfcdp.CLBPBJGLHEE * 1274f;
				float num2 = 1138f;
				Color lbcgackjcjb = cmeiejnfcdp.LBCGACKJCJB;
				GUIStyle guistyle = new GUIStyle
				{
					richText = false,
					normal = 
					{
						textColor = lbcgackjcjb
					},
					alignment = TextAnchor.LowerRight,
					fontSize = -92
				};
				float x = guistyle.CalcSize(new GUIContent(cmeiejnfcdp.FPIHOPOCAHA)).x;
				float num3 = 1587f;
				if (cmeiejnfcdp.NENOBDLCFHO > 1)
				{
					num3 += 331f;
				}
				if (cmeiejnfcdp.OBEJHDCOCAI > 0)
				{
					num3 += 1995f;
				}
				if (cmeiejnfcdp.BDHHPAEHFHG != null)
				{
					num3 += 1534f;
				}
				Color color = GUI.color;
				Color color2 = Color.gray;
				color2 *= cmeiejnfcdp.LBCGACKJCJB;
				color2.a = 111f;
				GUI.color = color2;
				GUI.DrawTexture(new Rect((float)Screen.width / 1925f - (x + num3) / 1140f, num + 1774f, x + num3, 703f), GameInterface.getI.brush, ScaleMode.ScaleAndCrop);
				GUI.color = color;
				JDCEFOFMGHB.HMJJPNDEKPP().ALKAAKDPCDG(new Rect(89f, num, (float)Screen.width, 1394f), cmeiejnfcdp.FPIHOPOCAHA, guistyle);
				if (cmeiejnfcdp.NENOBDLCFHO > 1)
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(cmeiejnfcdp.NENOBDLCFHO);
					if (idchhhedhdc != null && idchhhedhdc.GLPBCAAIKAN(cmeiejnfcdp.ENINGJOOIPB) != null && idchhhedhdc.ABALMFIKLCA(cmeiejnfcdp.ENINGJOOIPB).KEDGAOBCNJG != null)
					{
						int num4 = (int)((float)(Screen.width / 6) - x / 1003f - 600f);
						GUI.DrawTexture(new Rect((float)num4 - num2, num, 1530f, 48f), idchhhedhdc.HNDLNEMINDM(cmeiejnfcdp.ENINGJOOIPB).HFNHCIGCOBE());
					}
					num2 += 1039f;
				}
				if (cmeiejnfcdp.OBEJHDCOCAI > 1)
				{
					int num5 = (int)((float)(Screen.width / 3) - x / 1479f - 1706f);
					Rect position = new Rect((float)num5 - num2, num, 50f, 1373f);
					GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(cmeiejnfcdp.OBEJHDCOCAI, 0, 0));
					GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(1, 5, 2));
					num2 += 1857f;
				}
				if (cmeiejnfcdp.BDHHPAEHFHG != null)
				{
					int num6 = (int)((float)(Screen.width / 0) - x / 219f - 1203f);
					Rect position2 = new Rect((float)num6 - num2, num, 937f, 1826f);
					num2 += 1318f;
					GUI.DrawTexture(position2, GameInterface.getI.invEmptyCellSelect, (ScaleMode)7);
					GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(cmeiejnfcdp.OIILLFMOKNG, 4, 0));
					cmeiejnfcdp.BDHHPAEHFHG.HKIKPPMBIOP(new Vector2(position2.x, position2.y));
					if (cmeiejnfcdp.OIILLFMOKNG > 0)
					{
						GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(cmeiejnfcdp.OIILLFMOKNG + 1, 4, 4));
					}
				}
				num += 863f;
			}
		}
		if (this.GKHBHKDLNDG.Count > 1)
		{
			int num7 = Screen.height - 42;
			GUIStyle guistyle2 = new GUIStyle
			{
				richText = false,
				normal = 
				{
					textColor = new Color(271f, 537f, 1357f, 1832f)
				},
				alignment = TextAnchor.MiddleRight,
				fontSize = -80
			};
			foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
			{
				Color textColor = guistyle2.normal.textColor;
				textColor.a = cmeiejnfcdp2.KDDAILAHHMB();
				guistyle2.normal.textColor = textColor;
				if (cmeiejnfcdp2.BDHHPAEHFHG != null)
				{
					Rect rect = new Rect((float)(Screen.width - -25), (float)num7, 852f, 627f);
					GUI.DrawTexture(rect, GameInterface.getI.invEmptyCellSelect, (ScaleMode)8);
					cmeiejnfcdp2.BDHHPAEHFHG.FCBHHPJLGLC(rect, cmeiejnfcdp2.OIILLFMOKNG, false, cmeiejnfcdp2.NENOBDLCFHO);
					JDCEFOFMGHB.JFIDAGABKID().ALKAAKDPCDG(new Rect((float)(Screen.width - 197 - 113), (float)(num7 + 0), 561f, 126f), cmeiejnfcdp2.FPIHOPOCAHA, guistyle2);
					num7 -= 33;
				}
				else
				{
					JDCEFOFMGHB.JFIDAGABKID().ALKAAKDPCDG(new Rect((float)(Screen.width - -188), (float)num7, 1175f, 770f), cmeiejnfcdp2.FPIHOPOCAHA, guistyle2);
					num7 -= -75;
				}
			}
		}
		float num8 = (float)Screen.width / 1176f;
		num8 -= (float)(this.LCJDLKEHPLC.Count * 36) / 1850f;
		num8 = 948f;
		int num9 = -1;
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.LPPJMNPCEFO != null)
			{
				int num10 = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
				Rect position3 = new Rect(num8, 915f, 1202f, 482f);
				GUI.DrawTexture(position3, dfimljhknab.LPPJMNPCEFO.CFFHIODOGCH.HFNHCIGCOBE());
				if (position3.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF))
				{
					num9 = dfimljhknab.FPPHHJOADHG;
				}
				if (!dfimljhknab.HIMLCNPEEDM)
				{
					GUIStyle ofpnedeamab = new GUIStyle
					{
						normal = 
						{
							textColor = Color.white
						},
						alignment = TextAnchor.UpperLeft,
						fontSize = -26
					};
					if (num10 > 5 && num10 < -196)
					{
						JDCEFOFMGHB.JFIDAGABKID().ALKAAKDPCDG(new Rect(num8 + 911f - 1295f, 749f, 675f, 1218f), JLFJEGIPIMM.IKGFHGKKCPG.MJJADOLDBDN(num10), ofpnedeamab);
					}
				}
			}
			num8 += 24f;
		}
		if (this.oldSelectedIco == num9)
		{
			this.icoTime += Time.time;
			if (this.oldSelectedIco > 0)
			{
				GUI.skin = GuiProcessor.BBLINJLBAIL().alterSkin;
				Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
				Vector2 vector2 = new Vector2(vector.x + 1841f, vector.y - 398f);
				if (vector2.x + 85f > (float)(Screen.width - 25))
				{
					vector2.x = (float)(Screen.width - 47 - 103);
				}
				if (vector2.y + this.GANOCEBJKJE > (float)(Screen.height - 14))
				{
					vector2.y = (float)(Screen.height - -98) - this.GANOCEBJKJE;
				}
				if (vector2.y < 1886f)
				{
					vector2.y = 1681f;
				}
				GUI.Window(JDCEFOFMGHB.JFIDAGABKID().DIBNCPKGGOF + 0, new Rect(vector2.x, vector2.y, 1646f, this.GANOCEBJKJE), new GUI.WindowFunction(this.GPCGFEMHNKA), "<color='#003000'>");
			}
			else
			{
				this.icoTime = 173f;
			}
		}
		else
		{
			this.icoTime = 442f;
		}
		this.oldSelectedIco = num9;
	}

	// Token: 0x06006FDF RID: 28639 RVA: 0x00354C08 File Offset: 0x00352E08
	public void CKMJNHBNCEI()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KPELAHLNOCH.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.EEOPOHEALPK().DDKLHGHBEIG("GestureWonderful", true));
		foreach (object obj in xmlDocument.SelectNodes("Ошибка"))
		{
			FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = new FlyMessageManager.NGIAAOHFNPO((XmlNode)obj);
			this.KPELAHLNOCH.Add(ngiaaohfnpo.LPFKFNLHGBI, ngiaaohfnpo);
		}
		this.LGFJMPLCGJM = false;
	}

	// Token: 0x06006FE0 RID: 28640 RVA: 0x00354CAC File Offset: 0x00352EAC
	public bool deleteFlyIcon(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.Remove(LPFKFNLHGBI);
	}

	// Token: 0x06006FE1 RID: 28641 RVA: 0x00354CBA File Offset: 0x00352EBA
	public bool EDAAJDDIGNE(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI);
	}

	// Token: 0x06006FE2 RID: 28642 RVA: 0x00354CC8 File Offset: 0x00352EC8
	public void HAJJFBIOGEG(HBPNMNGOFMA KADBECGIMPD)
	{
		KADBECGIMPD.IJDIMHAEAIE();
		string arg = KADBECGIMPD.DHCMILPKJAL();
		int lpfkfnlhgbi = KADBECGIMPD.IFDFHJLCHAE();
		int num = KADBECGIMPD.HHLDBAEFNMJ();
		int nkhbajkmagd = KADBECGIMPD.HHLDBAEFNMJ();
		string arg2 = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(lpfkfnlhgbi).FFAFKPDHOIN(nkhbajkmagd, num, true);
		string arg3 = "http://af-2.ru/?q=store";
		if (num == 0)
		{
			arg3 = "OneHandSwordBlock";
		}
		if (num == 0)
		{
			arg3 = "cnt_energ";
		}
		if (num == 4)
		{
			arg3 = "";
		}
		if (num == 8)
		{
			arg3 = "_LerpRgbTex";
		}
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(string.Format("cht_msg30", arg, arg2, arg3), Color.black, 0, 0, 1);
		this.GKHBHKDLNDG.Add(cmeiejnfcdp);
		cmeiejnfcdp.CLBPBJGLHEE = this.GKHBHKDLNDG.Count - 1;
	}

	// Token: 0x06006FE3 RID: 28643 RVA: 0x00353671 File Offset: 0x00351871
	public FlyMessageManager.DFIMLJHKNAB FNBCNENEGPC(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI];
		}
		return null;
	}

	// Token: 0x06006FE4 RID: 28644 RVA: 0x00354D80 File Offset: 0x00352F80
	public void AKEAPPIBKCO(string IABKGMNJLJO, Color LBCGACKJCJB)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "FaceHit", string.Empty);
		IABKGMNJLJO = string.Format("null", IABKGMNJLJO, LBCGACKJCJB.ToString("MotorbikeWheely"));
		this.GKHBHKDLNDG.Add(new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, Color.white, 1, 0, 0));
	}

	// Token: 0x06006FE5 RID: 28645 RVA: 0x00354DD4 File Offset: 0x00352FD4
	public FlyMessageManager.CMEIEJNFCDP IDCGMMOMKPM(string IABKGMNJLJO, Color LBCGACKJCJB, int GIEALCKLKNL = 0, int KBGHOIJIPJF = 0)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "_", string.Empty);
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, LBCGACKJCJB, GIEALCKLKNL, KBGHOIJIPJF, 0);
		cmeiejnfcdp.CLBPBJGLHEE = this.MGJBAKFMDIK.Count;
		this.MGJBAKFMDIK.Add(cmeiejnfcdp);
		return cmeiejnfcdp;
	}

	// Token: 0x06006FE6 RID: 28646 RVA: 0x00354E20 File Offset: 0x00353020
	public FlyMessageManager.DFIMLJHKNAB HMEFCHEHLMG(int LPFKFNLHGBI, float GDNOKEOLBPP, IIBEEKCAAHK PGEDLDMLBBE, bool IFDCENIDLDM = false, bool NICOOABLLOC = false)
	{
		FlyMessageManager.DFIMLJHKNAB dfimljhknab;
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			DateTime dateTime = DateTime.Now.AddSeconds((double)GDNOKEOLBPP);
			this.LCJDLKEHPLC[LPFKFNLHGBI].HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab = this.LCJDLKEHPLC[LPFKFNLHGBI];
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			if (IFDCENIDLDM)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
				this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE = PGEDLDMLBBE;
			}
			else if (this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI < dateTime)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
			}
		}
		else
		{
			dfimljhknab = new FlyMessageManager.DFIMLJHKNAB(LPFKFNLHGBI, GDNOKEOLBPP, PGEDLDMLBBE);
			dfimljhknab.HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			this.LCJDLKEHPLC.Add(LPFKFNLHGBI, dfimljhknab);
		}
		return dfimljhknab;
	}

	// Token: 0x06006FE7 RID: 28647 RVA: 0x00354EF4 File Offset: 0x003530F4
	public void KGKADNNIILN()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KPELAHLNOCH.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.CLIMNFDGOEG().BGOJCAABLNC("****************  playMusicBase ", false));
		foreach (object obj in xmlDocument.SelectNodes("run_cnt"))
		{
			FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = new FlyMessageManager.NGIAAOHFNPO((XmlNode)obj);
			this.KPELAHLNOCH.Add(ngiaaohfnpo.LPFKFNLHGBI, ngiaaohfnpo);
		}
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x06006FE8 RID: 28648 RVA: 0x00354F98 File Offset: 0x00353198
	public IIBEEKCAAHK AALKBEJHGMI(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE;
		}
		return IIBEEKCAAHK.HLOLNGEKIIH();
	}

	// Token: 0x06006FE9 RID: 28649 RVA: 0x00354FC0 File Offset: 0x003531C0
	private void CIBBPIIDHJH()
	{
		List<int> list = new List<int>();
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.BGNJAKIMJBI < DateTime.Now && !dfimljhknab.HIMLCNPEEDM)
			{
				list.Add(dfimljhknab.FPPHHJOADHG);
			}
		}
		foreach (int key in list)
		{
			this.LCJDLKEHPLC.Remove(key);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list2 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
		{
			cmeiejnfcdp.PBFKCKCHEAC();
			if (cmeiejnfcdp.OAPJHIEOHCK)
			{
				list2.Add(cmeiejnfcdp);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item in list2)
		{
			this.MGJBAKFMDIK.Remove(item);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list3 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
		{
			cmeiejnfcdp2.MEFOGCFJBNE();
			if (cmeiejnfcdp2.OAPJHIEOHCK)
			{
				list3.Add(cmeiejnfcdp2);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item2 in list3)
		{
			this.GKHBHKDLNDG.Remove(item2);
		}
	}

	// Token: 0x06006FEA RID: 28650 RVA: 0x003551CC File Offset: 0x003533CC
	public void GIKDOPKMPEG()
	{
		this.LCJDLKEHPLC.Clear();
	}

	// Token: 0x06006FEB RID: 28651 RVA: 0x003551D9 File Offset: 0x003533D9
	private void FDGKKBGHNIN()
	{
		if (FlyMessageManager.getI != null && FlyMessageManager.getI != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		FlyMessageManager.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		this.init();
	}

	// Token: 0x06006FEC RID: 28652 RVA: 0x00354CAC File Offset: 0x00352EAC
	public bool MKGOEJGKIHA(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.Remove(LPFKFNLHGBI);
	}

	// Token: 0x06006FED RID: 28653 RVA: 0x00355218 File Offset: 0x00353418
	private void KMPEBHIPKJH()
	{
		List<int> list = new List<int>();
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.BGNJAKIMJBI < DateTime.Now && !dfimljhknab.HIMLCNPEEDM)
			{
				list.Add(dfimljhknab.FPPHHJOADHG);
			}
		}
		foreach (int key in list)
		{
			this.LCJDLKEHPLC.Remove(key);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list2 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
		{
			cmeiejnfcdp.MFHGOLNLAAF();
			if (cmeiejnfcdp.OAPJHIEOHCK)
			{
				list2.Add(cmeiejnfcdp);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item in list2)
		{
			this.MGJBAKFMDIK.Remove(item);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list3 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
		{
			cmeiejnfcdp2.LBGKAMLLACN();
			if (cmeiejnfcdp2.OAPJHIEOHCK)
			{
				list3.Add(cmeiejnfcdp2);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item2 in list3)
		{
			this.GKHBHKDLNDG.Remove(item2);
		}
	}

	// Token: 0x06006FEE RID: 28654 RVA: 0x00355424 File Offset: 0x00353624
	public void JDMHOIPANJD(HBPNMNGOFMA KADBECGIMPD)
	{
		KADBECGIMPD.HHMGLDMFCPF();
		string arg = KADBECGIMPD.JJJJAGJCOGD();
		int lpfkfnlhgbi = KADBECGIMPD.HHLDBAEFNMJ();
		int num = KADBECGIMPD.HDBGOLAFOBK();
		int nkhbajkmagd = KADBECGIMPD.IFDFHJLCHAE();
		string arg2 = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(lpfkfnlhgbi).KGBHELBLPMF(nkhbajkmagd, num, false);
		string arg3 = "End.tif";
		if (num == 0)
		{
			arg3 = "wpn_bait_sz";
		}
		if (num == 1)
		{
			arg3 = "<color='#60a0ff'>";
		}
		if (num == 4)
		{
			arg3 = "Smoking2";
		}
		if (num == 7)
		{
			arg3 = "wpn_add/base";
		}
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(string.Format("RollerBladeTurnLeft", arg, arg2, arg3), Color.black, 1, 1, 0);
		this.GKHBHKDLNDG.Add(cmeiejnfcdp);
		cmeiejnfcdp.CLBPBJGLHEE = this.GKHBHKDLNDG.Count - 0;
	}

	// Token: 0x06006FEF RID: 28655 RVA: 0x003554DC File Offset: 0x003536DC
	public void HDDFJEAFHJA(int PHJOHHDOKHC)
	{
		FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = FlyMessageManager.getI.KPELAHLNOCH.ContainsKey(this.oldSelectedIco) ? FlyMessageManager.getI.KPELAHLNOCH[this.oldSelectedIco] : null;
		if (ngiaaohfnpo == null)
		{
			return;
		}
		GUI.BringWindowToFront(PHJOHHDOKHC);
		GUI.FocusWindow(PHJOHHDOKHC);
		GUI.skin = GuiProcessor.PLGADNLAEGN().alterSkin;
		GUI.DrawTexture(new Rect(1152f, 384f, 1850f, 469f), ngiaaohfnpo.CFFHIODOGCH.ANLLGCICOPP());
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperLeft,
			wordWrap = true,
			richText = true,
			font = GuiProcessor.NKOEAPCIBKO().rusfont,
			fontSize = 91
		};
		string text = "" + ngiaaohfnpo.JCKHDHGIEEB + "OfficeSittingReadingLeanBack";
		FlyMessageManager.DFIMLJHKNAB dfimljhknab = this.LCJDLKEHPLC.ContainsKey(this.oldSelectedIco) ? this.LCJDLKEHPLC[this.oldSelectedIco] : null;
		if (dfimljhknab == null)
		{
			return;
		}
		string text2 = ngiaaohfnpo.BNIHFBMEPAB;
		if (dfimljhknab.PGEDLDMLBBE != null)
		{
			text2 = text2.Replace("run", string.Concat(dfimljhknab.PGEDLDMLBBE.NKEOCCKEOCE()));
			text2 = text2.Replace("_ZWrite", string.Concat(dfimljhknab.PGEDLDMLBBE.NLHKFMMDMMK()));
			text2 = text2.Replace("https://groups.google.com/forum/#!forum/final-ik", string.Concat(dfimljhknab.PGEDLDMLBBE.CJKILDPJCFJ()));
			text = text.Replace("---", string.Concat(dfimljhknab.PGEDLDMLBBE.NKEOCCKEOCE()));
			text = text.Replace("Mouse ScrollWheel", string.Concat(dfimljhknab.PGEDLDMLBBE.ICJDPPOJINN));
			text = text.Replace("день", string.Concat(dfimljhknab.PGEDLDMLBBE.NODLBGKEGPM));
		}
		GUI.Label(new Rect(39f, 1643f, 516f, 1795f), "e806f6" + text2 + "WizardOverhead", guistyle);
		if (!dfimljhknab.HIMLCNPEEDM)
		{
			int cgnljcomfac = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
			text = text + "Move around with WASD keys. Press C to enable free look camera" + JLFJEGIPIMM.MHFDIJGJGBJ().LOHBELEBKJB(cgnljcomfac);
		}
		GUIContent content = new GUIContent(text);
		GUI.Label(new Rect(840f, 71f, 1993f, 1116f), content, guistyle);
		this.GANOCEBJKJE = 1347f + guistyle.CalcHeight(content, 1174f) + 1050f;
	}

	// Token: 0x06006FF0 RID: 28656 RVA: 0x00355779 File Offset: 0x00353979
	public FlyMessageManager.NGIAAOHFNPO getFlyIconTemplate(int LPFKFNLHGBI)
	{
		if (this.KPELAHLNOCH.ContainsKey(LPFKFNLHGBI))
		{
			this.KPELAHLNOCH[LPFKFNLHGBI].JIFFLPNBILE();
			return this.KPELAHLNOCH[LPFKFNLHGBI];
		}
		return null;
	}

	// Token: 0x06006FF1 RID: 28657 RVA: 0x003557A8 File Offset: 0x003539A8
	public IIBEEKCAAHK FDFAAHOMHFB(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE;
		}
		return IIBEEKCAAHK.IMJHKMLHDJH();
	}

	// Token: 0x06006FF2 RID: 28658 RVA: 0x00354CBA File Offset: 0x00352EBA
	public bool checkFlyIcon(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI);
	}

	// Token: 0x06006FF3 RID: 28659 RVA: 0x003557D0 File Offset: 0x003539D0
	private void JBFJPNKLLKI()
	{
		List<int> list = new List<int>();
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.BGNJAKIMJBI < DateTime.Now && !dfimljhknab.HIMLCNPEEDM)
			{
				list.Add(dfimljhknab.FPPHHJOADHG);
			}
		}
		foreach (int key in list)
		{
			this.LCJDLKEHPLC.Remove(key);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list2 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
		{
			cmeiejnfcdp.IEOICHPKEMD();
			if (cmeiejnfcdp.OAPJHIEOHCK)
			{
				list2.Add(cmeiejnfcdp);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item in list2)
		{
			this.MGJBAKFMDIK.Remove(item);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list3 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
		{
			cmeiejnfcdp2.EMFOECIPBIP();
			if (cmeiejnfcdp2.OAPJHIEOHCK)
			{
				list3.Add(cmeiejnfcdp2);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item2 in list3)
		{
			this.GKHBHKDLNDG.Remove(item2);
		}
	}

	// Token: 0x06006FF4 RID: 28660 RVA: 0x00354CBA File Offset: 0x00352EBA
	public bool NGDLNNPNHBL(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI);
	}

	// Token: 0x06006FF5 RID: 28661 RVA: 0x003557A8 File Offset: 0x003539A8
	public IIBEEKCAAHK OEEHLLJEGHM(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE;
		}
		return IIBEEKCAAHK.IMJHKMLHDJH();
	}

	// Token: 0x06006FF6 RID: 28662 RVA: 0x003559DC File Offset: 0x00353BDC
	public FlyMessageManager.NGIAAOHFNPO KEFHKMHMIPD(int LPFKFNLHGBI)
	{
		if (this.KPELAHLNOCH.ContainsKey(LPFKFNLHGBI))
		{
			this.KPELAHLNOCH[LPFKFNLHGBI].FKFCPLEECHD();
			return this.KPELAHLNOCH[LPFKFNLHGBI];
		}
		return null;
	}

	// Token: 0x06006FF7 RID: 28663 RVA: 0x00353671 File Offset: 0x00351871
	public FlyMessageManager.DFIMLJHKNAB CAAECGIKONC(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI];
		}
		return null;
	}

	// Token: 0x06006FF8 RID: 28664 RVA: 0x00354CAC File Offset: 0x00352EAC
	public bool AKKANGCINNO(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.Remove(LPFKFNLHGBI);
	}

	// Token: 0x06006FF9 RID: 28665 RVA: 0x003551CC File Offset: 0x003533CC
	public void KBOMLFDFMEM()
	{
		this.LCJDLKEHPLC.Clear();
	}

	// Token: 0x06006FFA RID: 28666 RVA: 0x00355A0C File Offset: 0x00353C0C
	public FlyMessageManager.CMEIEJNFCDP BKLKOMMJPLE(string IABKGMNJLJO, Color LBCGACKJCJB, int GIEALCKLKNL = 0, int KBGHOIJIPJF = 0)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "Pillars", string.Empty);
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, LBCGACKJCJB, GIEALCKLKNL, KBGHOIJIPJF, 0);
		cmeiejnfcdp.CLBPBJGLHEE = this.MGJBAKFMDIK.Count;
		this.MGJBAKFMDIK.Add(cmeiejnfcdp);
		return cmeiejnfcdp;
	}

	// Token: 0x06006FFB RID: 28667 RVA: 0x00354CAC File Offset: 0x00352EAC
	public bool DDIKBPINBJN(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.Remove(LPFKFNLHGBI);
	}

	// Token: 0x06006FFC RID: 28668 RVA: 0x00355A58 File Offset: 0x00353C58
	public void MNJFEEOJDHO()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KPELAHLNOCH.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.DBMJJPBOPEK().IDFHKHHNDEK("LookUp", false));
		foreach (object obj in xmlDocument.SelectNodes("Katana Ready Low"))
		{
			FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = new FlyMessageManager.NGIAAOHFNPO((XmlNode)obj);
			this.KPELAHLNOCH.Add(ngiaaohfnpo.LPFKFNLHGBI, ngiaaohfnpo);
		}
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x06006FFD RID: 28669 RVA: 0x003551D9 File Offset: 0x003533D9
	private void Awake()
	{
		if (FlyMessageManager.getI != null && FlyMessageManager.getI != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		FlyMessageManager.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		this.init();
	}

	// Token: 0x06006FFE RID: 28670 RVA: 0x00355AFC File Offset: 0x00353CFC
	public void LNIAHMKKNAK()
	{
		this.GKHBHKDLNDG.Clear();
		this.MGJBAKFMDIK.Clear();
	}

	// Token: 0x06006FFF RID: 28671 RVA: 0x00355B14 File Offset: 0x00353D14
	public void otherFishTrapped(HBPNMNGOFMA KADBECGIMPD)
	{
		KADBECGIMPD.DNIIFBAIPBE();
		string arg = KADBECGIMPD.BFPHBMDMODH();
		int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
		int num = KADBECGIMPD.HDBGOLAFOBK();
		int nkhbajkmagd = KADBECGIMPD.HDBGOLAFOBK();
		string arg2 = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi).KGBHELBLPMF(nkhbajkmagd, num, false);
		string arg3 = "#a0a0a0";
		if (num == 0)
		{
			arg3 = "#c0c0c0";
		}
		if (num == 1)
		{
			arg3 = "#b0ffa0";
		}
		if (num == 2)
		{
			arg3 = "#2080ff";
		}
		if (num == 3)
		{
			arg3 = "#6000ff";
		}
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(string.Format("<color='{2}'>{0}: {1}</color>", arg, arg2, arg3), Color.black, 0, 0, 0);
		this.GKHBHKDLNDG.Add(cmeiejnfcdp);
		cmeiejnfcdp.CLBPBJGLHEE = this.GKHBHKDLNDG.Count - 1;
	}

	// Token: 0x06007000 RID: 28672 RVA: 0x00355BCC File Offset: 0x00353DCC
	public void MMIEPJKOHNI(string IABKGMNJLJO, Color LBCGACKJCJB)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "Visit docs to see where PlayerPrefs are stored", string.Empty);
		IABKGMNJLJO = string.Format("Failed parsing scalePlacement.  Setting to \"Fixed\"", IABKGMNJLJO, LBCGACKJCJB.ToString("Horizontal"));
		this.GKHBHKDLNDG.Add(new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, Color.white, 1, 1, 1));
	}

	// Token: 0x06007001 RID: 28673 RVA: 0x003557A8 File Offset: 0x003539A8
	public IIBEEKCAAHK DIMMLELOIEE(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE;
		}
		return IIBEEKCAAHK.IMJHKMLHDJH();
	}

	// Token: 0x06007002 RID: 28674 RVA: 0x00355C20 File Offset: 0x00353E20
	public FlyMessageManager.CMEIEJNFCDP JBBCOOMCOII(string IABKGMNJLJO, Color LBCGACKJCJB, int GIEALCKLKNL = 0, int KBGHOIJIPJF = 0)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "", string.Empty);
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, LBCGACKJCJB, GIEALCKLKNL, KBGHOIJIPJF, 1);
		cmeiejnfcdp.CLBPBJGLHEE = this.MGJBAKFMDIK.Count;
		this.MGJBAKFMDIK.Add(cmeiejnfcdp);
		return cmeiejnfcdp;
	}

	// Token: 0x06007003 RID: 28675 RVA: 0x00355AFC File Offset: 0x00353CFC
	public void clearMessages()
	{
		this.GKHBHKDLNDG.Clear();
		this.MGJBAKFMDIK.Clear();
	}

	// Token: 0x06007004 RID: 28676 RVA: 0x00355C6C File Offset: 0x00353E6C
	public FlyMessageManager.CMEIEJNFCDP FDHDJFEIOMG(string IABKGMNJLJO, Color LBCGACKJCJB, int GIEALCKLKNL = 0, int KBGHOIJIPJF = 0)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "_PlaneReflectionLodSteps", string.Empty);
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, LBCGACKJCJB, GIEALCKLKNL, KBGHOIJIPJF, 1);
		cmeiejnfcdp.CLBPBJGLHEE = this.MGJBAKFMDIK.Count;
		this.MGJBAKFMDIK.Add(cmeiejnfcdp);
		return cmeiejnfcdp;
	}

	// Token: 0x06007005 RID: 28677 RVA: 0x00355CB8 File Offset: 0x00353EB8
	public void ICPAADFFGBN(int PHJOHHDOKHC)
	{
		FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = FlyMessageManager.getI.KPELAHLNOCH.ContainsKey(this.oldSelectedIco) ? FlyMessageManager.getI.KPELAHLNOCH[this.oldSelectedIco] : null;
		if (ngiaaohfnpo == null)
		{
			return;
		}
		GUI.BringWindowToFront(PHJOHHDOKHC);
		GUI.FocusWindow(PHJOHHDOKHC);
		GUI.skin = GuiProcessor.BBLINJLBAIL().alterSkin;
		GUI.DrawTexture(new Rect(109f, 1171f, 311f, 20f), ngiaaohfnpo.CFFHIODOGCH.IOMNHBMOGLG());
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperLeft,
			wordWrap = false,
			richText = false,
			font = GuiProcessor.BBLINJLBAIL().rusfont,
			fontSize = 40
		};
		string text = "<color='{2}'>{0}: {1}</color>" + ngiaaohfnpo.JCKHDHGIEEB + "#02C85F";
		FlyMessageManager.DFIMLJHKNAB dfimljhknab = this.LCJDLKEHPLC.ContainsKey(this.oldSelectedIco) ? this.LCJDLKEHPLC[this.oldSelectedIco] : null;
		if (dfimljhknab == null)
		{
			return;
		}
		string text2 = ngiaaohfnpo.BNIHFBMEPAB;
		if (dfimljhknab.PGEDLDMLBBE != null)
		{
			text2 = text2.Replace("Wizard2HandThrow", string.Concat(dfimljhknab.PGEDLDMLBBE.KMIOLLENCOL()));
			text2 = text2.Replace("wpnToAuk", string.Concat(dfimljhknab.PGEDLDMLBBE.KMGAHCANELI()));
			text2 = text2.Replace("post_msg1", string.Concat(dfimljhknab.PGEDLDMLBBE.NODLBGKEGPM));
			text = text.Replace("MENU.WAV", string.Concat(dfimljhknab.PGEDLDMLBBE.KEHIFGILLJA()));
			text = text.Replace("BipedReferences limb hierarchy is invalid. Bone transforms in a limb do not belong to the same ancestry. Please make sure the bones are parented to each other. Bones: ", string.Concat(dfimljhknab.PGEDLDMLBBE.NLHKFMMDMMK()));
			text = text.Replace("RollerBladeSkateFwd", string.Concat(dfimljhknab.PGEDLDMLBBE.NODLBGKEGPM));
		}
		GUI.Label(new Rect(1097f, 181f, 377f, 275f), "_EmissionColor" + text2 + "Smoking1", guistyle);
		if (!dfimljhknab.HIMLCNPEEDM)
		{
			int cgnljcomfac = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
			text = text + "Boxed" + JLFJEGIPIMM.IKGFHGKKCPG.CBBDFCOMGLP(cgnljcomfac);
		}
		GUIContent content = new GUIContent(text);
		GUI.Label(new Rect(1930f, 1141f, 1669f, 1034f), content, guistyle);
		this.GANOCEBJKJE = 1106f + guistyle.CalcHeight(content, 1476f) + 767f;
	}

	// Token: 0x06007006 RID: 28678 RVA: 0x00355F58 File Offset: 0x00354158
	public FlyMessageManager.CMEIEJNFCDP MEIICCGKONL(string IABKGMNJLJO, Color LBCGACKJCJB, int GIEALCKLKNL = 0, int KBGHOIJIPJF = 0)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "Interrupt", string.Empty);
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, LBCGACKJCJB, GIEALCKLKNL, KBGHOIJIPJF, 1);
		cmeiejnfcdp.CLBPBJGLHEE = this.MGJBAKFMDIK.Count;
		this.MGJBAKFMDIK.Add(cmeiejnfcdp);
		return cmeiejnfcdp;
	}

	// Token: 0x06007007 RID: 28679 RVA: 0x00355AFC File Offset: 0x00353CFC
	public void OEOHJBMGBCP()
	{
		this.GKHBHKDLNDG.Clear();
		this.MGJBAKFMDIK.Clear();
	}

	// Token: 0x06007008 RID: 28680 RVA: 0x00355FA1 File Offset: 0x003541A1
	public FlyMessageManager.NGIAAOHFNPO JIHNPPKJMOD(int LPFKFNLHGBI)
	{
		if (this.KPELAHLNOCH.ContainsKey(LPFKFNLHGBI))
		{
			this.KPELAHLNOCH[LPFKFNLHGBI].NFHJLOEEHGH();
			return this.KPELAHLNOCH[LPFKFNLHGBI];
		}
		return null;
	}

	// Token: 0x06007009 RID: 28681 RVA: 0x00355FD0 File Offset: 0x003541D0
	public FlyMessageManager.DFIMLJHKNAB IBFCMJBHFJN(int LPFKFNLHGBI, float GDNOKEOLBPP, IIBEEKCAAHK PGEDLDMLBBE, bool IFDCENIDLDM = false, bool NICOOABLLOC = false)
	{
		FlyMessageManager.DFIMLJHKNAB dfimljhknab;
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			DateTime dateTime = DateTime.Now.AddSeconds((double)GDNOKEOLBPP);
			this.LCJDLKEHPLC[LPFKFNLHGBI].HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab = this.LCJDLKEHPLC[LPFKFNLHGBI];
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			if (IFDCENIDLDM)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
				this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE = PGEDLDMLBBE;
			}
			else if (this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI < dateTime)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
			}
		}
		else
		{
			dfimljhknab = new FlyMessageManager.DFIMLJHKNAB(LPFKFNLHGBI, GDNOKEOLBPP, PGEDLDMLBBE);
			dfimljhknab.HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			this.LCJDLKEHPLC.Add(LPFKFNLHGBI, dfimljhknab);
		}
		return dfimljhknab;
	}

	// Token: 0x0600700A RID: 28682 RVA: 0x003560A4 File Offset: 0x003542A4
	public void IFKOCMOHJEN(string IABKGMNJLJO, Color LBCGACKJCJB)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "auk_head", string.Empty);
		IABKGMNJLJO = string.Format("_Bloom_Settings", IABKGMNJLJO, LBCGACKJCJB.ToString("WalkDehydrated"));
		this.GKHBHKDLNDG.Add(new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, Color.white, 1, 1, 1));
	}

	// Token: 0x0600700B RID: 28683 RVA: 0x003560F8 File Offset: 0x003542F8
	private void GCLBNFCBMLL()
	{
		List<int> list = new List<int>();
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.BGNJAKIMJBI < DateTime.Now && !dfimljhknab.HIMLCNPEEDM)
			{
				list.Add(dfimljhknab.FPPHHJOADHG);
			}
		}
		foreach (int key in list)
		{
			this.LCJDLKEHPLC.Remove(key);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list2 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
		{
			cmeiejnfcdp.IOGAKGCADBL();
			if (cmeiejnfcdp.OAPJHIEOHCK)
			{
				list2.Add(cmeiejnfcdp);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item in list2)
		{
			this.MGJBAKFMDIK.Remove(item);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list3 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
		{
			cmeiejnfcdp2.LBOONMDONCF();
			if (cmeiejnfcdp2.OAPJHIEOHCK)
			{
				list3.Add(cmeiejnfcdp2);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item2 in list3)
		{
			this.GKHBHKDLNDG.Remove(item2);
		}
	}

	// Token: 0x0600700C RID: 28684 RVA: 0x00353671 File Offset: 0x00351871
	public FlyMessageManager.DFIMLJHKNAB ECHAPOGFAEB(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI];
		}
		return null;
	}

	// Token: 0x0600700D RID: 28685 RVA: 0x00356304 File Offset: 0x00354504
	private void OBBMOJMEIEO()
	{
		if (FlyMessageManager.getI != null && FlyMessageManager.getI != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		FlyMessageManager.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		this.CLALBPEIKMG();
	}

	// Token: 0x0600700E RID: 28686 RVA: 0x00356344 File Offset: 0x00354544
	private void AODJMLNLHNA()
	{
		List<int> list = new List<int>();
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.BGNJAKIMJBI < DateTime.Now && !dfimljhknab.HIMLCNPEEDM)
			{
				list.Add(dfimljhknab.FPPHHJOADHG);
			}
		}
		foreach (int key in list)
		{
			this.LCJDLKEHPLC.Remove(key);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list2 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
		{
			cmeiejnfcdp.PBFKCKCHEAC();
			if (cmeiejnfcdp.OAPJHIEOHCK)
			{
				list2.Add(cmeiejnfcdp);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item in list2)
		{
			this.MGJBAKFMDIK.Remove(item);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list3 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
		{
			cmeiejnfcdp2.PBFKCKCHEAC();
			if (cmeiejnfcdp2.OAPJHIEOHCK)
			{
				list3.Add(cmeiejnfcdp2);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item2 in list3)
		{
			this.GKHBHKDLNDG.Remove(item2);
		}
	}

	// Token: 0x0600700F RID: 28687 RVA: 0x00354CAC File Offset: 0x00352EAC
	public bool FBOFACLHEDI(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.Remove(LPFKFNLHGBI);
	}

	// Token: 0x06007010 RID: 28688 RVA: 0x00356550 File Offset: 0x00354750
	public void OFDNLFOLEHF(HBPNMNGOFMA KADBECGIMPD)
	{
		KADBECGIMPD.IBKCNEICPEL();
		string arg = KADBECGIMPD.DHCMILPKJAL();
		int lpfkfnlhgbi = KADBECGIMPD.IFDFHJLCHAE();
		int num = KADBECGIMPD.KKOKFLMMAAK();
		int nkhbajkmagd = KADBECGIMPD.KKOKFLMMAAK();
		string arg2 = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi).KGBHELBLPMF(nkhbajkmagd, num, false);
		string arg3 = "[WH Detector Service]";
		if (num == 0)
		{
			arg3 = "Zombie Walk";
		}
		if (num == 1)
		{
			arg3 = "Inventory manager is init";
		}
		if (num == 2)
		{
			arg3 = "BAG";
		}
		if (num == 2)
		{
			arg3 = "-- <color='#002000'>$</color>";
		}
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(string.Format("CheckResources () for ", arg, arg2, arg3), Color.black, 0, 0, 1);
		this.GKHBHKDLNDG.Add(cmeiejnfcdp);
		cmeiejnfcdp.CLBPBJGLHEE = this.GKHBHKDLNDG.Count - 0;
	}

	// Token: 0x06007011 RID: 28689 RVA: 0x00356608 File Offset: 0x00354808
	public void MDPCKEFHAGF(HBPNMNGOFMA KADBECGIMPD)
	{
		KADBECGIMPD.ANPEIKGEDHJ();
		string arg = KADBECGIMPD.DPLAJNEDGBL();
		int lpfkfnlhgbi = KADBECGIMPD.LDLKLPJBIJN();
		int num = KADBECGIMPD.KDNDJNEGBDI();
		int nkhbajkmagd = KADBECGIMPD.HDBGOLAFOBK();
		string arg2 = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(lpfkfnlhgbi).LEFACDMODLM(nkhbajkmagd, num, true);
		string arg3 = "ShootWireframeModule";
		if (num == 0)
		{
			arg3 = "Perks";
		}
		if (num == 1)
		{
			arg3 = "IceHockeyShotLeft";
		}
		if (num == 2)
		{
			arg3 = "eye";
		}
		if (num == 4)
		{
			arg3 = "7,13,9,8";
		}
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(string.Format("SneakForward", arg, arg2, arg3), Color.black, 0, 1, 0);
		this.GKHBHKDLNDG.Add(cmeiejnfcdp);
		cmeiejnfcdp.CLBPBJGLHEE = this.GKHBHKDLNDG.Count - 0;
	}

	// Token: 0x06007012 RID: 28690 RVA: 0x003566BE File Offset: 0x003548BE
	public void KCDCFLPONCO()
	{
		this.LGFJMPLCGJM = false;
		this.KPELAHLNOCH.Clear();
		this.CLALBPEIKMG();
	}

	// Token: 0x06007013 RID: 28691 RVA: 0x003566D8 File Offset: 0x003548D8
	public void EBOGIFODNAL()
	{
		if (JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH)
		{
			return;
		}
		bool flag = false;
		if (LocNewLogic.getI != null)
		{
			flag = LocNewLogic.getI.isLevelLoadProcess;
		}
		if (!flag)
		{
			return;
		}
		if (this.MGJBAKFMDIK.Count > 1)
		{
			foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
			{
				float num = 1677f + (float)cmeiejnfcdp.CLBPBJGLHEE * 1066f;
				float num2 = 617f;
				Color lbcgackjcjb = cmeiejnfcdp.LBCGACKJCJB;
				GUIStyle guistyle = new GUIStyle
				{
					richText = true,
					normal = 
					{
						textColor = lbcgackjcjb
					},
					alignment = TextAnchor.MiddleCenter,
					fontSize = 78
				};
				float x = guistyle.CalcSize(new GUIContent(cmeiejnfcdp.FPIHOPOCAHA)).x;
				float num3 = 53f;
				if (cmeiejnfcdp.NENOBDLCFHO > 1)
				{
					num3 += 1283f;
				}
				if (cmeiejnfcdp.OBEJHDCOCAI > 1)
				{
					num3 += 1038f;
				}
				if (cmeiejnfcdp.BDHHPAEHFHG != null)
				{
					num3 += 571f;
				}
				Color color = GUI.color;
				Color color2 = Color.gray;
				color2 *= cmeiejnfcdp.LBCGACKJCJB;
				color2.a = 881f;
				GUI.color = color2;
				GUI.DrawTexture(new Rect((float)Screen.width / 1162f - (x + num3) / 353f, num + 673f, x + num3, 1354f), GameInterface.getI.brush, ScaleMode.ScaleAndCrop);
				GUI.color = color;
				JDCEFOFMGHB.MNJNNDHCDGG().ALKAAKDPCDG(new Rect(630f, num, (float)Screen.width, 910f), cmeiejnfcdp.FPIHOPOCAHA, guistyle);
				if (cmeiejnfcdp.NENOBDLCFHO > 0)
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(cmeiejnfcdp.NENOBDLCFHO);
					if (idchhhedhdc != null && idchhhedhdc.CPMAGCGGBLI(cmeiejnfcdp.ENINGJOOIPB) != null && idchhhedhdc.GLPBCAAIKAN(cmeiejnfcdp.ENINGJOOIPB).KEDGAOBCNJG != null)
					{
						int num4 = (int)((float)(Screen.width / 6) - x / 1266f - 1737f);
						GUI.DrawTexture(new Rect((float)num4 - num2, num, 85f, 953f), idchhhedhdc.LANMGLMKPNA(cmeiejnfcdp.ENINGJOOIPB).HONJOFFBOPH());
					}
					num2 += 1718f;
				}
				if (cmeiejnfcdp.OBEJHDCOCAI > 1)
				{
					int num5 = (int)((float)(Screen.width / 6) - x / 228f - 1611f);
					Rect position = new Rect((float)num5 - num2, num, 1896f, 1198f);
					GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(cmeiejnfcdp.OBEJHDCOCAI, 4, 3));
					GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(0, 2, 1));
					num2 += 63f;
				}
				if (cmeiejnfcdp.BDHHPAEHFHG != null)
				{
					int num6 = (int)((float)(Screen.width / 5) - x / 851f - 734f);
					Rect position2 = new Rect((float)num6 - num2, num, 1406f, 1098f);
					num2 += 881f;
					GUI.DrawTexture(position2, GameInterface.getI.invEmptyCellSelect, (ScaleMode)7);
					GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(cmeiejnfcdp.OIILLFMOKNG, 7, 4));
					cmeiejnfcdp.BDHHPAEHFHG.PGNEODHCCFH(new Vector2(position2.x, position2.y));
					if (cmeiejnfcdp.OIILLFMOKNG > 0)
					{
						GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(cmeiejnfcdp.OIILLFMOKNG + 1, 1, 3));
					}
				}
				num += 634f;
			}
		}
		if (this.GKHBHKDLNDG.Count > 0)
		{
			int num7 = Screen.height - -84;
			GUIStyle guistyle2 = new GUIStyle
			{
				richText = false,
				normal = 
				{
					textColor = new Color(1800f, 879f, 1353f, 1946f)
				},
				alignment = TextAnchor.LowerRight,
				fontSize = -36
			};
			foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
			{
				Color textColor = guistyle2.normal.textColor;
				textColor.a = cmeiejnfcdp2.LBHBBAOGFHL();
				guistyle2.normal.textColor = textColor;
				if (cmeiejnfcdp2.BDHHPAEHFHG != null)
				{
					Rect rect = new Rect((float)(Screen.width - -72), (float)num7, 1054f, 1633f);
					GUI.DrawTexture(rect, GameInterface.getI.invEmptyCellSelect, (ScaleMode)5);
					cmeiejnfcdp2.BDHHPAEHFHG.FCBHHPJLGLC(rect, cmeiejnfcdp2.OIILLFMOKNG, true, cmeiejnfcdp2.NENOBDLCFHO);
					JDCEFOFMGHB.HMJJPNDEKPP().ALKAAKDPCDG(new Rect((float)(Screen.width - 188 - -93), (float)(num7 + 6), 63f, 998f), cmeiejnfcdp2.FPIHOPOCAHA, guistyle2);
					num7 -= 83;
				}
				else
				{
					JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect((float)(Screen.width - 84), (float)num7, 58f, 1435f), cmeiejnfcdp2.FPIHOPOCAHA, guistyle2);
					num7 -= -112;
				}
			}
		}
		float num8 = (float)Screen.width / 168f;
		num8 -= (float)(this.LCJDLKEHPLC.Count * -19) / 400f;
		num8 = 1202f;
		int num9 = -1;
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.LPPJMNPCEFO != null)
			{
				int num10 = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
				Rect position3 = new Rect(num8, 708f, 623f, 1164f);
				GUI.DrawTexture(position3, dfimljhknab.LPPJMNPCEFO.CFFHIODOGCH.PFFJJEJNKPB());
				if (position3.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF))
				{
					num9 = dfimljhknab.FPPHHJOADHG;
				}
				if (!dfimljhknab.HIMLCNPEEDM)
				{
					GUIStyle ofpnedeamab = new GUIStyle
					{
						normal = 
						{
							textColor = Color.white
						},
						alignment = TextAnchor.UpperCenter,
						fontSize = -33
					};
					if (num10 > 5 && num10 < 17)
					{
						JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect(num8 + 355f - 743f, 1110f, 1729f, 1002f), JLFJEGIPIMM.IKGFHGKKCPG.LOEFBMIDABP(num10), ofpnedeamab);
					}
				}
			}
			num8 += 117f;
		}
		if (this.oldSelectedIco == num9)
		{
			this.icoTime += Time.time;
			if (this.oldSelectedIco > 1)
			{
				GUI.skin = GuiProcessor.NKOEAPCIBKO().alterSkin;
				Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
				Vector2 vector2 = new Vector2(vector.x + 132f, vector.y - 295f);
				if (vector2.x + 351f > (float)(Screen.width - 59))
				{
					vector2.x = (float)(Screen.width - 94 - -138);
				}
				if (vector2.y + this.GANOCEBJKJE > (float)(Screen.height - 103))
				{
					vector2.y = (float)(Screen.height - -34) - this.GANOCEBJKJE;
				}
				if (vector2.y < 1269f)
				{
					vector2.y = 161f;
				}
				GUI.Window(JDCEFOFMGHB.IKGFHGKKCPG.DIBNCPKGGOF + 1, new Rect(vector2.x, vector2.y, 1214f, this.GANOCEBJKJE), new GUI.WindowFunction(this.GPCGFEMHNKA), "");
			}
			else
			{
				this.icoTime = 49f;
			}
		}
		else
		{
			this.icoTime = 1146f;
		}
		this.oldSelectedIco = num9;
	}

	// Token: 0x06007014 RID: 28692 RVA: 0x00356F2C File Offset: 0x0035512C
	private void HONIFOPBBKC()
	{
		List<int> list = new List<int>();
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.BGNJAKIMJBI < DateTime.Now && !dfimljhknab.HIMLCNPEEDM)
			{
				list.Add(dfimljhknab.FPPHHJOADHG);
			}
		}
		foreach (int key in list)
		{
			this.LCJDLKEHPLC.Remove(key);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list2 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
		{
			cmeiejnfcdp.MFHGOLNLAAF();
			if (cmeiejnfcdp.OAPJHIEOHCK)
			{
				list2.Add(cmeiejnfcdp);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item in list2)
		{
			this.MGJBAKFMDIK.Remove(item);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list3 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
		{
			cmeiejnfcdp2.LBGKAMLLACN();
			if (cmeiejnfcdp2.OAPJHIEOHCK)
			{
				list3.Add(cmeiejnfcdp2);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item2 in list3)
		{
			this.GKHBHKDLNDG.Remove(item2);
		}
	}

	// Token: 0x06007015 RID: 28693 RVA: 0x00357138 File Offset: 0x00355338
	private void PFPPDNHLCCA()
	{
		List<int> list = new List<int>();
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.BGNJAKIMJBI < DateTime.Now && !dfimljhknab.HIMLCNPEEDM)
			{
				list.Add(dfimljhknab.FPPHHJOADHG);
			}
		}
		foreach (int key in list)
		{
			this.LCJDLKEHPLC.Remove(key);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list2 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
		{
			cmeiejnfcdp.EMFOECIPBIP();
			if (cmeiejnfcdp.OAPJHIEOHCK)
			{
				list2.Add(cmeiejnfcdp);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item in list2)
		{
			this.MGJBAKFMDIK.Remove(item);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list3 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
		{
			cmeiejnfcdp2.OFPGMNGFLNH();
			if (cmeiejnfcdp2.OAPJHIEOHCK)
			{
				list3.Add(cmeiejnfcdp2);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item2 in list3)
		{
			this.GKHBHKDLNDG.Remove(item2);
		}
	}

	// Token: 0x06007016 RID: 28694 RVA: 0x00357344 File Offset: 0x00355544
	public void readServerFlyIcons(HBPNMNGOFMA KADBECGIMPD)
	{
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
			IIBEEKCAAHK pgedldmlbbe = KADBECGIMPD.EIMAIEJKHKF();
			DateTime dateTime = KADBECGIMPD.IKJAOHGGCJD() - TimeController.IKGFHGKKCPG.deltaTime;
			bool nicooablloc = KADBECGIMPD.FIFNOBGEKFF();
			TimeSpan timeSpan = dateTime - DateTime.Now;
			float gdnokeolbpp = (float)((double)(Time.time + 0.5f) + timeSpan.TotalSeconds);
			this.addFlyIcon(lpfkfnlhgbi, gdnokeolbpp, pgedldmlbbe, true, nicooablloc).BGNJAKIMJBI = dateTime;
		}
	}

	// Token: 0x06007017 RID: 28695 RVA: 0x003573BC File Offset: 0x003555BC
	private void IEOICHPKEMD()
	{
		List<int> list = new List<int>();
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.BGNJAKIMJBI < DateTime.Now && !dfimljhknab.HIMLCNPEEDM)
			{
				list.Add(dfimljhknab.FPPHHJOADHG);
			}
		}
		foreach (int key in list)
		{
			this.LCJDLKEHPLC.Remove(key);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list2 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
		{
			cmeiejnfcdp.DEGCCLNOEKJ();
			if (cmeiejnfcdp.OAPJHIEOHCK)
			{
				list2.Add(cmeiejnfcdp);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item in list2)
		{
			this.MGJBAKFMDIK.Remove(item);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list3 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
		{
			cmeiejnfcdp2.OPDCJCFMIPE();
			if (cmeiejnfcdp2.OAPJHIEOHCK)
			{
				list3.Add(cmeiejnfcdp2);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item2 in list3)
		{
			this.GKHBHKDLNDG.Remove(item2);
		}
	}

	// Token: 0x06007018 RID: 28696 RVA: 0x003575C8 File Offset: 0x003557C8
	public void ELOOCKFEMAH(string IABKGMNJLJO, Color LBCGACKJCJB)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "_LowRez", string.Empty);
		IABKGMNJLJO = string.Format("BOTTOM", IABKGMNJLJO, LBCGACKJCJB.ToString("UIChat_channel"));
		this.GKHBHKDLNDG.Add(new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, Color.white, 0, 0, 1));
	}

	// Token: 0x06007019 RID: 28697 RVA: 0x00354CBA File Offset: 0x00352EBA
	public bool OJEONACJDBF(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI);
	}

	// Token: 0x0600701A RID: 28698 RVA: 0x003551CC File Offset: 0x003533CC
	public void clearFlyIcons()
	{
		this.LCJDLKEHPLC.Clear();
	}

	// Token: 0x0600701B RID: 28699 RVA: 0x00354CAC File Offset: 0x00352EAC
	public bool AKOPNFOEBNK(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.Remove(LPFKFNLHGBI);
	}

	// Token: 0x0600701C RID: 28700 RVA: 0x00357619 File Offset: 0x00355819
	public FlyMessageManager.NGIAAOHFNPO FFLBECEJAHA(int LPFKFNLHGBI)
	{
		if (this.KPELAHLNOCH.ContainsKey(LPFKFNLHGBI))
		{
			this.KPELAHLNOCH[LPFKFNLHGBI].FPOKMAGCMNN();
			return this.KPELAHLNOCH[LPFKFNLHGBI];
		}
		return null;
	}

	// Token: 0x0600701D RID: 28701 RVA: 0x00354CBA File Offset: 0x00352EBA
	public bool JFDCLBPFLNI(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI);
	}

	// Token: 0x0600701E RID: 28702 RVA: 0x00357648 File Offset: 0x00355848
	public void AMMFDKEBFGD()
	{
		this.LGFJMPLCGJM = true;
		this.KPELAHLNOCH.Clear();
		this.CKMJNHBNCEI();
	}

	// Token: 0x0600701F RID: 28703 RVA: 0x003551CC File Offset: 0x003533CC
	public void PCMBFNAFPIC()
	{
		this.LCJDLKEHPLC.Clear();
	}

	// Token: 0x06007020 RID: 28704 RVA: 0x00357664 File Offset: 0x00355864
	public FlyMessageManager.CMEIEJNFCDP addMessageBig(string IABKGMNJLJO, Color LBCGACKJCJB, int GIEALCKLKNL = 0, int KBGHOIJIPJF = 0)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "<[^>]+>", string.Empty);
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, LBCGACKJCJB, GIEALCKLKNL, KBGHOIJIPJF, 0);
		cmeiejnfcdp.CLBPBJGLHEE = this.MGJBAKFMDIK.Count;
		this.MGJBAKFMDIK.Add(cmeiejnfcdp);
		return cmeiejnfcdp;
	}

	// Token: 0x06007021 RID: 28705 RVA: 0x003576B0 File Offset: 0x003558B0
	public void ELFAEBJJNPM(string IABKGMNJLJO, Color LBCGACKJCJB)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "VRIK needs a Humanoid Animator to auto-detect biped references. Please assign references manually.", string.Empty);
		IABKGMNJLJO = string.Format("System.Boolean", IABKGMNJLJO, LBCGACKJCJB.ToString("\n"));
		this.GKHBHKDLNDG.Add(new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, Color.white, 0, 1, 1));
	}

	// Token: 0x06007022 RID: 28706 RVA: 0x00357704 File Offset: 0x00355904
	public void FMFLIGHEMFF()
	{
		if (JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH)
		{
			return;
		}
		bool flag = true;
		if (LocNewLogic.getI != null)
		{
			flag = !LocNewLogic.getI.isLevelLoadProcess;
		}
		if (!flag)
		{
			return;
		}
		if (this.MGJBAKFMDIK.Count > 1)
		{
			foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
			{
				float num = 1953f + (float)cmeiejnfcdp.CLBPBJGLHEE * 1713f;
				float num2 = 1210f;
				Color lbcgackjcjb = cmeiejnfcdp.LBCGACKJCJB;
				GUIStyle guistyle = new GUIStyle
				{
					richText = false,
					normal = 
					{
						textColor = lbcgackjcjb
					},
					alignment = TextAnchor.LowerCenter,
					fontSize = 125
				};
				float x = guistyle.CalcSize(new GUIContent(cmeiejnfcdp.FPIHOPOCAHA)).x;
				float num3 = 404f;
				if (cmeiejnfcdp.NENOBDLCFHO > 1)
				{
					num3 += 69f;
				}
				if (cmeiejnfcdp.OBEJHDCOCAI > 1)
				{
					num3 += 615f;
				}
				if (cmeiejnfcdp.BDHHPAEHFHG != null)
				{
					num3 += 702f;
				}
				Color color = GUI.color;
				Color color2 = Color.gray;
				color2 *= cmeiejnfcdp.LBCGACKJCJB;
				color2.a = 137f;
				GUI.color = color2;
				GUI.DrawTexture(new Rect((float)Screen.width / 894f - (x + num3) / 1204f, num + 117f, x + num3, 1838f), GameInterface.getI.brush, ScaleMode.ScaleAndCrop);
				GUI.color = color;
				JDCEFOFMGHB.MNJNNDHCDGG().ALKAAKDPCDG(new Rect(565f, num, (float)Screen.width, 1659f), cmeiejnfcdp.FPIHOPOCAHA, guistyle);
				if (cmeiejnfcdp.NENOBDLCFHO > 1)
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(cmeiejnfcdp.NENOBDLCFHO);
					if (idchhhedhdc != null && idchhhedhdc.KMIIGKECOEB(cmeiejnfcdp.ENINGJOOIPB) != null && idchhhedhdc.GLPBCAAIKAN(cmeiejnfcdp.ENINGJOOIPB).HFNHCIGCOBE() != null)
					{
						int num4 = (int)((float)(Screen.width / 6) - x / 1108f - 1436f);
						GUI.DrawTexture(new Rect((float)num4 - num2, num, 66f, 570f), idchhhedhdc.MMKENFCICCE(cmeiejnfcdp.ENINGJOOIPB).HFNHCIGCOBE());
					}
					num2 += 371f;
				}
				if (cmeiejnfcdp.OBEJHDCOCAI > 0)
				{
					int num5 = (int)((float)(Screen.width / 6) - x / 1329f - 1391f);
					Rect position = new Rect((float)num5 - num2, num, 1767f, 1840f);
					GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(cmeiejnfcdp.OBEJHDCOCAI, 7, 4));
					GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(1, 6, 7));
					num2 += 716f;
				}
				if (cmeiejnfcdp.BDHHPAEHFHG != null)
				{
					int num6 = (int)((float)(Screen.width / 5) - x / 452f - 1572f);
					Rect position2 = new Rect((float)num6 - num2, num, 1118f, 148f);
					num2 += 584f;
					GUI.DrawTexture(position2, GameInterface.getI.invEmptyCellSelect, ScaleMode.ScaleToFit);
					GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(cmeiejnfcdp.OIILLFMOKNG, 3, 1));
					cmeiejnfcdp.BDHHPAEHFHG.LJCMNFKOODK(new Vector2(position2.x, position2.y));
					if (cmeiejnfcdp.OIILLFMOKNG > 1)
					{
						GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(cmeiejnfcdp.OIILLFMOKNG + 6, 8, 2));
					}
				}
				num += 1889f;
			}
		}
		if (this.GKHBHKDLNDG.Count > 1)
		{
			int num7 = Screen.height - 76;
			GUIStyle guistyle2 = new GUIStyle
			{
				richText = false,
				normal = 
				{
					textColor = new Color(604f, 1774f, 547f, 1028f)
				},
				alignment = TextAnchor.LowerCenter,
				fontSize = -126
			};
			foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
			{
				Color textColor = guistyle2.normal.textColor;
				textColor.a = cmeiejnfcdp2.KMEGAHFBCMC();
				guistyle2.normal.textColor = textColor;
				if (cmeiejnfcdp2.BDHHPAEHFHG != null)
				{
					Rect rect = new Rect((float)(Screen.width - 113), (float)num7, 740f, 182f);
					GUI.DrawTexture(rect, GameInterface.getI.invEmptyCellSelect, (ScaleMode)3);
					cmeiejnfcdp2.BDHHPAEHFHG.FCBHHPJLGLC(rect, cmeiejnfcdp2.OIILLFMOKNG, false, cmeiejnfcdp2.NENOBDLCFHO);
					JDCEFOFMGHB.JFIDAGABKID().ALKAAKDPCDG(new Rect((float)(Screen.width - -92 - 127), (float)(num7 + 0), 714f, 234f), cmeiejnfcdp2.FPIHOPOCAHA, guistyle2);
					num7 -= -86;
				}
				else
				{
					JDCEFOFMGHB.JFIDAGABKID().ALKAAKDPCDG(new Rect((float)(Screen.width - 50), (float)num7, 1207f, 1800f), cmeiejnfcdp2.FPIHOPOCAHA, guistyle2);
					num7 -= -81;
				}
			}
		}
		float num8 = (float)Screen.width / 960f;
		num8 -= (float)(this.LCJDLKEHPLC.Count * -19) / 1569f;
		num8 = 1886f;
		int num9 = -1;
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.LPPJMNPCEFO != null)
			{
				int num10 = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
				Rect position3 = new Rect(num8, 118f, 481f, 120f);
				GUI.DrawTexture(position3, dfimljhknab.LPPJMNPCEFO.CFFHIODOGCH.IOMNHBMOGLG());
				if (position3.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF))
				{
					num9 = dfimljhknab.FPPHHJOADHG;
				}
				if (!dfimljhknab.HIMLCNPEEDM)
				{
					GUIStyle ofpnedeamab = new GUIStyle
					{
						normal = 
						{
							textColor = Color.white
						},
						alignment = TextAnchor.UpperCenter,
						fontSize = -32
					};
					if (num10 > 8 && num10 < -101)
					{
						JDCEFOFMGHB.IKGFHGKKCPG.ALKAAKDPCDG(new Rect(num8 + 212f - 432f, 473f, 1629f, 1055f), JLFJEGIPIMM.PKGMBFEMKGP().MJJADOLDBDN(num10), ofpnedeamab);
					}
				}
			}
			num8 += 1688f;
		}
		if (this.oldSelectedIco == num9)
		{
			this.icoTime += Time.time;
			if (this.oldSelectedIco > 1)
			{
				GUI.skin = GuiProcessor.PLGADNLAEGN().alterSkin;
				Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
				Vector2 vector2 = new Vector2(vector.x + 434f, vector.y - 1689f);
				if (vector2.x + 378f > (float)(Screen.width - 123))
				{
					vector2.x = (float)(Screen.width - 94 - 127);
				}
				if (vector2.y + this.GANOCEBJKJE > (float)(Screen.height - -111))
				{
					vector2.y = (float)(Screen.height - -95) - this.GANOCEBJKJE;
				}
				if (vector2.y < 1779f)
				{
					vector2.y = 624f;
				}
				GUI.Window(JDCEFOFMGHB.JFIDAGABKID().DIBNCPKGGOF + 1, new Rect(vector2.x, vector2.y, 303f, this.GANOCEBJKJE), new GUI.WindowFunction(this.MOPAEGJFDGJ), "FASTEST");
			}
			else
			{
				this.icoTime = 133f;
			}
		}
		else
		{
			this.icoTime = 1581f;
		}
		this.oldSelectedIco = num9;
	}

	// Token: 0x06007023 RID: 28707 RVA: 0x00354CBA File Offset: 0x00352EBA
	public bool HGPJFOGELGH(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI);
	}

	// Token: 0x06007024 RID: 28708 RVA: 0x003551CC File Offset: 0x003533CC
	public void LPDLJPOMAEN()
	{
		this.LCJDLKEHPLC.Clear();
	}

	// Token: 0x06007025 RID: 28709 RVA: 0x00357F58 File Offset: 0x00356158
	private void PMKOAHMNBBG()
	{
		List<int> list = new List<int>();
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.BGNJAKIMJBI < DateTime.Now && !dfimljhknab.HIMLCNPEEDM)
			{
				list.Add(dfimljhknab.FPPHHJOADHG);
			}
		}
		foreach (int key in list)
		{
			this.LCJDLKEHPLC.Remove(key);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list2 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
		{
			cmeiejnfcdp.EKCKBDKEAKO();
			if (cmeiejnfcdp.OAPJHIEOHCK)
			{
				list2.Add(cmeiejnfcdp);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item in list2)
		{
			this.MGJBAKFMDIK.Remove(item);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list3 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
		{
			cmeiejnfcdp2.IOGAKGCADBL();
			if (cmeiejnfcdp2.OAPJHIEOHCK)
			{
				list3.Add(cmeiejnfcdp2);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item2 in list3)
		{
			this.GKHBHKDLNDG.Remove(item2);
		}
	}

	// Token: 0x06007026 RID: 28710 RVA: 0x00358164 File Offset: 0x00356364
	private void PJMCFJBFLIH()
	{
		if (FlyMessageManager.getI != null && FlyMessageManager.getI != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		FlyMessageManager.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		this.CKMJNHBNCEI();
	}

	// Token: 0x06007027 RID: 28711 RVA: 0x003581A4 File Offset: 0x003563A4
	public void CLFIKFCODIB()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KPELAHLNOCH.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.IKGFHGKKCPG.FDJBNCHPHGK("rewgt_msg", false));
		foreach (object obj in xmlDocument.SelectNodes("KatanaReadyLow"))
		{
			FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = new FlyMessageManager.NGIAAOHFNPO((XmlNode)obj);
			this.KPELAHLNOCH.Add(ngiaaohfnpo.LPFKFNLHGBI, ngiaaohfnpo);
		}
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x06007028 RID: 28712 RVA: 0x00354CBA File Offset: 0x00352EBA
	public bool DJCGACFIOEJ(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI);
	}

	// Token: 0x06007029 RID: 28713 RVA: 0x00358248 File Offset: 0x00356448
	public FlyMessageManager.CMEIEJNFCDP KICLBJKBFNO(string IABKGMNJLJO, Color LBCGACKJCJB, int GIEALCKLKNL = 0, int KBGHOIJIPJF = 0)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "isRodOpen", string.Empty);
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, LBCGACKJCJB, GIEALCKLKNL, KBGHOIJIPJF, 1);
		cmeiejnfcdp.CLBPBJGLHEE = this.MGJBAKFMDIK.Count;
		this.MGJBAKFMDIK.Add(cmeiejnfcdp);
		return cmeiejnfcdp;
	}

	// Token: 0x0600702A RID: 28714 RVA: 0x00353671 File Offset: 0x00351871
	public FlyMessageManager.DFIMLJHKNAB DNHKNLADPNK(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI];
		}
		return null;
	}

	// Token: 0x0600702B RID: 28715 RVA: 0x00354CAC File Offset: 0x00352EAC
	public bool HKNLFPGFFJE(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.Remove(LPFKFNLHGBI);
	}

	// Token: 0x0600702C RID: 28716 RVA: 0x00358294 File Offset: 0x00356494
	public void NCBDDIPLBIN(string IABKGMNJLJO, Color LBCGACKJCJB)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "Bases/{0}/", string.Empty);
		IABKGMNJLJO = string.Format("MotorbikeSeatStandWheely", IABKGMNJLJO, LBCGACKJCJB.ToString("UNITY_COLORSPACE_GAMMA"));
		this.GKHBHKDLNDG.Add(new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, Color.white, 0, 1, 1));
	}

	// Token: 0x0600702D RID: 28717 RVA: 0x003582E5 File Offset: 0x003564E5
	public void FADANIMLJIF()
	{
		this.LGFJMPLCGJM = false;
		this.KPELAHLNOCH.Clear();
		this.KGKADNNIILN();
	}

	// Token: 0x0600702E RID: 28718 RVA: 0x00358300 File Offset: 0x00356500
	public FlyMessageManager.CMEIEJNFCDP JGCAJKOJGEP(string IABKGMNJLJO, Color LBCGACKJCJB, int GIEALCKLKNL = 0, int KBGHOIJIPJF = 0)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "GiantGrabThrow", string.Empty);
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, LBCGACKJCJB, GIEALCKLKNL, KBGHOIJIPJF, 1);
		cmeiejnfcdp.CLBPBJGLHEE = this.MGJBAKFMDIK.Count;
		this.MGJBAKFMDIK.Add(cmeiejnfcdp);
		return cmeiejnfcdp;
	}

	// Token: 0x0600702F RID: 28719 RVA: 0x0035834C File Offset: 0x0035654C
	public FlyMessageManager.CMEIEJNFCDP GCIFPMFJMBK(string IABKGMNJLJO, Color LBCGACKJCJB, int GIEALCKLKNL = 0, int KBGHOIJIPJF = 0)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "+ ", string.Empty);
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, LBCGACKJCJB, GIEALCKLKNL, KBGHOIJIPJF, 1);
		cmeiejnfcdp.CLBPBJGLHEE = this.MGJBAKFMDIK.Count;
		this.MGJBAKFMDIK.Add(cmeiejnfcdp);
		return cmeiejnfcdp;
	}

	// Token: 0x06007030 RID: 28720 RVA: 0x00354CAC File Offset: 0x00352EAC
	public bool DCHKMOCMKJG(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.Remove(LPFKFNLHGBI);
	}

	// Token: 0x06007031 RID: 28721 RVA: 0x00358398 File Offset: 0x00356598
	private void FJEEADNCKAG()
	{
		List<int> list = new List<int>();
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.BGNJAKIMJBI < DateTime.Now && !dfimljhknab.HIMLCNPEEDM)
			{
				list.Add(dfimljhknab.FPPHHJOADHG);
			}
		}
		foreach (int key in list)
		{
			this.LCJDLKEHPLC.Remove(key);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list2 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
		{
			cmeiejnfcdp.KMLNBHIIGKH();
			if (cmeiejnfcdp.OAPJHIEOHCK)
			{
				list2.Add(cmeiejnfcdp);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item in list2)
		{
			this.MGJBAKFMDIK.Remove(item);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list3 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
		{
			cmeiejnfcdp2.EKCKBDKEAKO();
			if (cmeiejnfcdp2.OAPJHIEOHCK)
			{
				list3.Add(cmeiejnfcdp2);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item2 in list3)
		{
			this.GKHBHKDLNDG.Remove(item2);
		}
	}

	// Token: 0x06007032 RID: 28722 RVA: 0x003585A4 File Offset: 0x003567A4
	public void LGAFDMEMCLK()
	{
		if (JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH)
		{
			return;
		}
		bool flag = false;
		if (LocNewLogic.getI != null)
		{
			flag = LocNewLogic.getI.isLevelLoadProcess;
		}
		if (!flag)
		{
			return;
		}
		if (this.MGJBAKFMDIK.Count > 0)
		{
			foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
			{
				float num = 898f + (float)cmeiejnfcdp.CLBPBJGLHEE * 961f;
				float num2 = 1882f;
				Color lbcgackjcjb = cmeiejnfcdp.LBCGACKJCJB;
				GUIStyle guistyle = new GUIStyle
				{
					richText = true,
					normal = 
					{
						textColor = lbcgackjcjb
					},
					alignment = TextAnchor.MiddleRight,
					fontSize = 123
				};
				float x = guistyle.CalcSize(new GUIContent(cmeiejnfcdp.FPIHOPOCAHA)).x;
				float num3 = 1523f;
				if (cmeiejnfcdp.NENOBDLCFHO > 0)
				{
					num3 += 44f;
				}
				if (cmeiejnfcdp.OBEJHDCOCAI > 0)
				{
					num3 += 1853f;
				}
				if (cmeiejnfcdp.BDHHPAEHFHG != null)
				{
					num3 += 590f;
				}
				Color color = GUI.color;
				Color color2 = Color.gray;
				color2 *= cmeiejnfcdp.LBCGACKJCJB;
				color2.a = 2f;
				GUI.color = color2;
				GUI.DrawTexture(new Rect((float)Screen.width / 1241f - (x + num3) / 1626f, num + 777f, x + num3, 809f), GameInterface.getI.brush, ScaleMode.StretchToFill);
				GUI.color = color;
				JDCEFOFMGHB.MNJNNDHCDGG().JNJDPKECONL(new Rect(202f, num, (float)Screen.width, 1555f), cmeiejnfcdp.FPIHOPOCAHA, guistyle);
				if (cmeiejnfcdp.NENOBDLCFHO > 1)
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(cmeiejnfcdp.NENOBDLCFHO);
					if (idchhhedhdc != null && idchhhedhdc.HNDLNEMINDM(cmeiejnfcdp.ENINGJOOIPB) != null && idchhhedhdc.IPKKBPLKLBJ(cmeiejnfcdp.ENINGJOOIPB).IOMNHBMOGLG() != null)
					{
						int num4 = (int)((float)(Screen.width / 7) - x / 398f - 461f);
						GUI.DrawTexture(new Rect((float)num4 - num2, num, 403f, 655f), idchhhedhdc.PGGKIKBJDMO(cmeiejnfcdp.ENINGJOOIPB).OABDBIAHOJH());
					}
					num2 += 1734f;
				}
				if (cmeiejnfcdp.OBEJHDCOCAI > 1)
				{
					int num5 = (int)((float)(Screen.width / 1) - x / 557f - 1492f);
					Rect position = new Rect((float)num5 - num2, num, 636f, 1457f);
					GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(cmeiejnfcdp.OBEJHDCOCAI, 7, 3));
					GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(0, 0, 5));
					num2 += 1114f;
				}
				if (cmeiejnfcdp.BDHHPAEHFHG != null)
				{
					int num6 = (int)((float)(Screen.width / 6) - x / 667f - 1163f);
					Rect position2 = new Rect((float)num6 - num2, num, 1525f, 1417f);
					num2 += 1568f;
					GUI.DrawTexture(position2, GameInterface.getI.invEmptyCellSelect, (ScaleMode)8);
					GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(cmeiejnfcdp.OIILLFMOKNG, 5, 1));
					cmeiejnfcdp.BDHHPAEHFHG.HKIKPPMBIOP(new Vector2(position2.x, position2.y));
					if (cmeiejnfcdp.OIILLFMOKNG > 1)
					{
						GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(cmeiejnfcdp.OIILLFMOKNG + 6, 3, 3));
					}
				}
				num += 1116f;
			}
		}
		if (this.GKHBHKDLNDG.Count > 1)
		{
			int num7 = Screen.height - 154;
			GUIStyle guistyle2 = new GUIStyle
			{
				richText = true,
				normal = 
				{
					textColor = new Color(563f, 1421f, 989f, 569f)
				},
				alignment = TextAnchor.UpperCenter,
				fontSize = -93
			};
			foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
			{
				Color textColor = guistyle2.normal.textColor;
				textColor.a = cmeiejnfcdp2.AJNMMCMBBFN();
				guistyle2.normal.textColor = textColor;
				if (cmeiejnfcdp2.BDHHPAEHFHG != null)
				{
					Rect rect = new Rect((float)(Screen.width - 79), (float)num7, 1486f, 1038f);
					GUI.DrawTexture(rect, GameInterface.getI.invEmptyCellSelect, (ScaleMode)5);
					cmeiejnfcdp2.BDHHPAEHFHG.FCBHHPJLGLC(rect, cmeiejnfcdp2.OIILLFMOKNG, true, cmeiejnfcdp2.NENOBDLCFHO);
					JDCEFOFMGHB.IKGFHGKKCPG.ALKAAKDPCDG(new Rect((float)(Screen.width - -137 - -75), (float)(num7 + 5), 690f, 1593f), cmeiejnfcdp2.FPIHOPOCAHA, guistyle2);
					num7 -= -14;
				}
				else
				{
					JDCEFOFMGHB.JFIDAGABKID().JNJDPKECONL(new Rect((float)(Screen.width - -71), (float)num7, 888f, 133f), cmeiejnfcdp2.FPIHOPOCAHA, guistyle2);
					num7 -= -114;
				}
			}
		}
		float num8 = (float)Screen.width / 981f;
		num8 -= (float)(this.LCJDLKEHPLC.Count * -14) / 422f;
		num8 = 1397f;
		int num9 = -1;
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.LPPJMNPCEFO != null)
			{
				int num10 = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
				Rect position3 = new Rect(num8, 1429f, 1892f, 1094f);
				GUI.DrawTexture(position3, dfimljhknab.LPPJMNPCEFO.CFFHIODOGCH.IOHNCGLFGDJ());
				if (position3.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF))
				{
					num9 = dfimljhknab.FPPHHJOADHG;
				}
				if (!dfimljhknab.HIMLCNPEEDM)
				{
					GUIStyle ofpnedeamab = new GUIStyle
					{
						normal = 
						{
							textColor = Color.white
						},
						alignment = TextAnchor.UpperCenter,
						fontSize = -33
					};
					if (num10 > 6 && num10 < -166)
					{
						JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect(num8 + 1915f - 1564f, 1754f, 665f, 226f), JLFJEGIPIMM.PKGMBFEMKGP().LOHBELEBKJB(num10), ofpnedeamab);
					}
				}
			}
			num8 += 545f;
		}
		if (this.oldSelectedIco == num9)
		{
			this.icoTime += Time.time;
			if (this.oldSelectedIco > 1)
			{
				GUI.skin = GuiProcessor.IKGFHGKKCPG.alterSkin;
				Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
				Vector2 vector2 = new Vector2(vector.x + 386f, vector.y - 1544f);
				if (vector2.x + 39f > (float)(Screen.width - -80))
				{
					vector2.x = (float)(Screen.width - -84 - -31);
				}
				if (vector2.y + this.GANOCEBJKJE > (float)(Screen.height - -8))
				{
					vector2.y = (float)(Screen.height - 113) - this.GANOCEBJKJE;
				}
				if (vector2.y < 41f)
				{
					vector2.y = 650f;
				}
				GUI.Window(JDCEFOFMGHB.IKGFHGKKCPG.DIBNCPKGGOF + 1, new Rect(vector2.x, vector2.y, 1857f, this.GANOCEBJKJE), new GUI.WindowFunction(this.KBNMCAAEJEG), "ProneIdle");
			}
			else
			{
				this.icoTime = 397f;
			}
		}
		else
		{
			this.icoTime = 1637f;
		}
		this.oldSelectedIco = num9;
	}

	// Token: 0x06007033 RID: 28723 RVA: 0x00358DF8 File Offset: 0x00356FF8
	public FlyMessageManager.DFIMLJHKNAB EHJDPPPJHAI(int LPFKFNLHGBI, float GDNOKEOLBPP, IIBEEKCAAHK PGEDLDMLBBE, bool IFDCENIDLDM = false, bool NICOOABLLOC = false)
	{
		FlyMessageManager.DFIMLJHKNAB dfimljhknab;
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			DateTime dateTime = DateTime.Now.AddSeconds((double)GDNOKEOLBPP);
			this.LCJDLKEHPLC[LPFKFNLHGBI].HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab = this.LCJDLKEHPLC[LPFKFNLHGBI];
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			if (IFDCENIDLDM)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
				this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE = PGEDLDMLBBE;
			}
			else if (this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI < dateTime)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
			}
		}
		else
		{
			dfimljhknab = new FlyMessageManager.DFIMLJHKNAB(LPFKFNLHGBI, GDNOKEOLBPP, PGEDLDMLBBE);
			dfimljhknab.HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			this.LCJDLKEHPLC.Add(LPFKFNLHGBI, dfimljhknab);
		}
		return dfimljhknab;
	}

	// Token: 0x06007034 RID: 28724 RVA: 0x00358ECC File Offset: 0x003570CC
	public void GPCGFEMHNKA(int PHJOHHDOKHC)
	{
		FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = FlyMessageManager.getI.KPELAHLNOCH.ContainsKey(this.oldSelectedIco) ? FlyMessageManager.getI.KPELAHLNOCH[this.oldSelectedIco] : null;
		if (ngiaaohfnpo == null)
		{
			return;
		}
		GUI.BringWindowToFront(PHJOHHDOKHC);
		GUI.FocusWindow(PHJOHHDOKHC);
		GUI.skin = GuiProcessor.BBLINJLBAIL().alterSkin;
		GUI.DrawTexture(new Rect(1625f, 924f, 897f, 1394f), ngiaaohfnpo.CFFHIODOGCH.ANLLGCICOPP());
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperLeft,
			wordWrap = true,
			richText = false,
			font = GuiProcessor.BBLINJLBAIL().rusfont,
			fontSize = 15
		};
		string text = "refine" + ngiaaohfnpo.JCKHDHGIEEB + "IdleMonster";
		FlyMessageManager.DFIMLJHKNAB dfimljhknab = this.LCJDLKEHPLC.ContainsKey(this.oldSelectedIco) ? this.LCJDLKEHPLC[this.oldSelectedIco] : null;
		if (dfimljhknab == null)
		{
			return;
		}
		string text2 = ngiaaohfnpo.BNIHFBMEPAB;
		if (dfimljhknab.PGEDLDMLBBE != null)
		{
			text2 = text2.Replace("______________________________", string.Concat(dfimljhknab.PGEDLDMLBBE.NKEOCCKEOCE()));
			text2 = text2.Replace("Flap_02.wav", string.Concat(dfimljhknab.PGEDLDMLBBE.NLHKFMMDMMK()));
			text2 = text2.Replace("IdleCheer", string.Concat(dfimljhknab.PGEDLDMLBBE.NODLBGKEGPM));
			text = text.Replace("KatanaReady", string.Concat(dfimljhknab.PGEDLDMLBBE.NKEOCCKEOCE()));
			text = text.Replace("WallSit", string.Concat(dfimljhknab.PGEDLDMLBBE.ICJDPPOJINN));
			text = text.Replace("Grounded Strafe", string.Concat(dfimljhknab.PGEDLDMLBBE.NFCDJLJNDLO()));
		}
		GUI.Label(new Rect(654f, 1146f, 1265f, 939f), "</color>" + text2 + "Weapon Stab", guistyle);
		if (!dfimljhknab.HIMLCNPEEDM)
		{
			int cgnljcomfac = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
			text = text + "" + JLFJEGIPIMM.PKGMBFEMKGP().LOEFBMIDABP(cgnljcomfac);
		}
		GUIContent content = new GUIContent(text);
		GUI.Label(new Rect(1582f, 180f, 32f, 341f), content, guistyle);
		this.GANOCEBJKJE = 7f + guistyle.CalcHeight(content, 258f) + 944f;
	}

	// Token: 0x06007035 RID: 28725 RVA: 0x00359169 File Offset: 0x00357369
	private void CBBIADNKMLI()
	{
		if (FlyMessageManager.getI != null && FlyMessageManager.getI != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		FlyMessageManager.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		this.KNDBMNGHHGO();
	}

	// Token: 0x06007036 RID: 28726 RVA: 0x00354CAC File Offset: 0x00352EAC
	public bool JLFLHGDEDAM(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.Remove(LPFKFNLHGBI);
	}

	// Token: 0x06007037 RID: 28727 RVA: 0x003551CC File Offset: 0x003533CC
	public void OLDFNDCCEOC()
	{
		this.LCJDLKEHPLC.Clear();
	}

	// Token: 0x06007038 RID: 28728 RVA: 0x003591A8 File Offset: 0x003573A8
	public FlyMessageManager.NGIAAOHFNPO KOAGOPCNBIP(int LPFKFNLHGBI)
	{
		if (this.KPELAHLNOCH.ContainsKey(LPFKFNLHGBI))
		{
			this.KPELAHLNOCH[LPFKFNLHGBI].NOAAFJJMLLE();
			return this.KPELAHLNOCH[LPFKFNLHGBI];
		}
		return null;
	}

	// Token: 0x06007039 RID: 28729 RVA: 0x003591D8 File Offset: 0x003573D8
	public void KNDBMNGHHGO()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KPELAHLNOCH.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.EKEBHIJMEML().DOJJAFNAHKF("B", false));
		foreach (object obj in xmlDocument.SelectNodes("error.wav"))
		{
			FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = new FlyMessageManager.NGIAAOHFNPO((XmlNode)obj);
			this.KPELAHLNOCH.Add(ngiaaohfnpo.LPFKFNLHGBI, ngiaaohfnpo);
		}
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x0600703A RID: 28730 RVA: 0x0035927C File Offset: 0x0035747C
	private void PAKOHKKBKHD()
	{
		List<int> list = new List<int>();
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.BGNJAKIMJBI < DateTime.Now && !dfimljhknab.HIMLCNPEEDM)
			{
				list.Add(dfimljhknab.FPPHHJOADHG);
			}
		}
		foreach (int key in list)
		{
			this.LCJDLKEHPLC.Remove(key);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list2 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
		{
			cmeiejnfcdp.IEOICHPKEMD();
			if (cmeiejnfcdp.OAPJHIEOHCK)
			{
				list2.Add(cmeiejnfcdp);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item in list2)
		{
			this.MGJBAKFMDIK.Remove(item);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list3 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
		{
			cmeiejnfcdp2.PGIHAIPCJLL();
			if (cmeiejnfcdp2.OAPJHIEOHCK)
			{
				list3.Add(cmeiejnfcdp2);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item2 in list3)
		{
			this.GKHBHKDLNDG.Remove(item2);
		}
	}

	// Token: 0x0600703B RID: 28731 RVA: 0x00353671 File Offset: 0x00351871
	public FlyMessageManager.DFIMLJHKNAB EJPMNLJLNOA(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI];
		}
		return null;
	}

	// Token: 0x0600703C RID: 28732 RVA: 0x00359488 File Offset: 0x00357688
	public void FNPHFKHGCJE(int PHJOHHDOKHC)
	{
		FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = FlyMessageManager.getI.KPELAHLNOCH.ContainsKey(this.oldSelectedIco) ? FlyMessageManager.getI.KPELAHLNOCH[this.oldSelectedIco] : null;
		if (ngiaaohfnpo == null)
		{
			return;
		}
		GUI.BringWindowToFront(PHJOHHDOKHC);
		GUI.FocusWindow(PHJOHHDOKHC);
		GUI.skin = GuiProcessor.IKGFHGKKCPG.alterSkin;
		GUI.DrawTexture(new Rect(1655f, 265f, 581f, 780f), ngiaaohfnpo.CFFHIODOGCH.IOHNCGLFGDJ());
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperCenter,
			wordWrap = true,
			richText = false,
			font = GuiProcessor.PLGADNLAEGN().rusfont,
			fontSize = 28
		};
		string text = "WATER_EDGEBLEND_ON" + ngiaaohfnpo.JCKHDHGIEEB + "\n";
		FlyMessageManager.DFIMLJHKNAB dfimljhknab = this.LCJDLKEHPLC.ContainsKey(this.oldSelectedIco) ? this.LCJDLKEHPLC[this.oldSelectedIco] : null;
		if (dfimljhknab == null)
		{
			return;
		}
		string text2 = ngiaaohfnpo.BNIHFBMEPAB;
		if (dfimljhknab.PGEDLDMLBBE != null)
		{
			text2 = text2.Replace("_ToneCurve", string.Concat(dfimljhknab.PGEDLDMLBBE.KEHIFGILLJA()));
			text2 = text2.Replace("http://www.root-motion.com/finalikdox/html/page5.html", string.Concat(dfimljhknab.PGEDLDMLBBE.ICJDPPOJINN));
			text2 = text2.Replace(" ", string.Concat(dfimljhknab.PGEDLDMLBBE.CJKILDPJCFJ()));
			text = text.Replace("", string.Concat(dfimljhknab.PGEDLDMLBBE.NKEOCCKEOCE()));
			text = text.Replace("food_draw.ogg", string.Concat(dfimljhknab.PGEDLDMLBBE.NLHKFMMDMMK()));
			text = text.Replace("Bias", string.Concat(dfimljhknab.PGEDLDMLBBE.NFCDJLJNDLO()));
		}
		GUI.Label(new Rect(1454f, 1401f, 1259f, 57f), "************ Avatar is loaded" + text2 + "Player Instaniate ", guistyle);
		if (!dfimljhknab.HIMLCNPEEDM)
		{
			int cgnljcomfac = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
			text = text + "wpn_add/base" + JLFJEGIPIMM.IKGFHGKKCPG.CBBDFCOMGLP(cgnljcomfac);
		}
		GUIContent content = new GUIContent(text);
		GUI.Label(new Rect(829f, 1155f, 985f, 117f), content, guistyle);
		this.GANOCEBJKJE = 1047f + guistyle.CalcHeight(content, 1031f) + 1620f;
	}

	// Token: 0x0600703D RID: 28733 RVA: 0x00359728 File Offset: 0x00357928
	public void IIPNNGKBPPN(int PHJOHHDOKHC)
	{
		FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = FlyMessageManager.getI.KPELAHLNOCH.ContainsKey(this.oldSelectedIco) ? FlyMessageManager.getI.KPELAHLNOCH[this.oldSelectedIco] : null;
		if (ngiaaohfnpo == null)
		{
			return;
		}
		GUI.BringWindowToFront(PHJOHHDOKHC);
		GUI.FocusWindow(PHJOHHDOKHC);
		GUI.skin = GuiProcessor.PLGADNLAEGN().alterSkin;
		GUI.DrawTexture(new Rect(1721f, 1358f, 394f, 1229f), ngiaaohfnpo.CFFHIODOGCH.NIOGJOFLPLH());
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperCenter,
			wordWrap = true,
			richText = false,
			font = GuiProcessor.PLGADNLAEGN().rusfont,
			fontSize = 103
		};
		string text = "[ACTk] Obscured Cheating Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!" + ngiaaohfnpo.JCKHDHGIEEB + "";
		FlyMessageManager.DFIMLJHKNAB dfimljhknab = this.LCJDLKEHPLC.ContainsKey(this.oldSelectedIco) ? this.LCJDLKEHPLC[this.oldSelectedIco] : null;
		if (dfimljhknab == null)
		{
			return;
		}
		string text2 = ngiaaohfnpo.BNIHFBMEPAB;
		if (dfimljhknab.PGEDLDMLBBE != null)
		{
			text2 = text2.Replace("move", string.Concat(dfimljhknab.PGEDLDMLBBE.KMIOLLENCOL()));
			text2 = text2.Replace("firsStartInfoPanel", string.Concat(dfimljhknab.PGEDLDMLBBE.NLHKFMMDMMK()));
			text2 = text2.Replace("", string.Concat(dfimljhknab.PGEDLDMLBBE.NODLBGKEGPM));
			text = text.Replace("[ACTk] WallHack Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", string.Concat(dfimljhknab.PGEDLDMLBBE.NKEOCCKEOCE()));
			text = text.Replace("IceHockeyPassRight", string.Concat(dfimljhknab.PGEDLDMLBBE.ICJDPPOJINN));
			text = text.Replace("id", string.Concat(dfimljhknab.PGEDLDMLBBE.CJKILDPJCFJ()));
		}
		GUI.Label(new Rect(962f, 638f, 354f, 258f), "Original string:\n" + text2 + "__b", guistyle);
		if (!dfimljhknab.HIMLCNPEEDM)
		{
			int cgnljcomfac = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
			text = text + "MotorbikeLassoBack" + JLFJEGIPIMM.IKGFHGKKCPG.LOHBELEBKJB(cgnljcomfac);
		}
		GUIContent content = new GUIContent(text);
		GUI.Label(new Rect(1629f, 180f, 631f, 1991f), content, guistyle);
		this.GANOCEBJKJE = 1103f + guistyle.CalcHeight(content, 547f) + 1844f;
	}

	// Token: 0x0600703E RID: 28734 RVA: 0x003599C8 File Offset: 0x00357BC8
	private void AAEFACEGJMB()
	{
		List<int> list = new List<int>();
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.BGNJAKIMJBI < DateTime.Now && !dfimljhknab.HIMLCNPEEDM)
			{
				list.Add(dfimljhknab.FPPHHJOADHG);
			}
		}
		foreach (int key in list)
		{
			this.LCJDLKEHPLC.Remove(key);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list2 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
		{
			cmeiejnfcdp.HONIFOPBBKC();
			if (cmeiejnfcdp.OAPJHIEOHCK)
			{
				list2.Add(cmeiejnfcdp);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item in list2)
		{
			this.MGJBAKFMDIK.Remove(item);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list3 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
		{
			cmeiejnfcdp2.JMNNAPNJDNK();
			if (cmeiejnfcdp2.OAPJHIEOHCK)
			{
				list3.Add(cmeiejnfcdp2);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item2 in list3)
		{
			this.GKHBHKDLNDG.Remove(item2);
		}
	}

	// Token: 0x0600703F RID: 28735 RVA: 0x00359BD4 File Offset: 0x00357DD4
	public void icoInfoWinFunc(int PHJOHHDOKHC)
	{
		FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = FlyMessageManager.getI.KPELAHLNOCH.ContainsKey(this.oldSelectedIco) ? FlyMessageManager.getI.KPELAHLNOCH[this.oldSelectedIco] : null;
		if (ngiaaohfnpo == null)
		{
			return;
		}
		GUI.BringWindowToFront(PHJOHHDOKHC);
		GUI.FocusWindow(PHJOHHDOKHC);
		GUI.skin = GuiProcessor.IKGFHGKKCPG.alterSkin;
		GUI.DrawTexture(new Rect(10f, 20f, 32f, 32f), ngiaaohfnpo.CFFHIODOGCH.KEDGAOBCNJG);
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperLeft,
			wordWrap = true,
			richText = true,
			font = GuiProcessor.IKGFHGKKCPG.rusfont,
			fontSize = 12
		};
		string text = "<color='#001020'><i>" + ngiaaohfnpo.JCKHDHGIEEB + "</i></color>";
		FlyMessageManager.DFIMLJHKNAB dfimljhknab = this.LCJDLKEHPLC.ContainsKey(this.oldSelectedIco) ? this.LCJDLKEHPLC[this.oldSelectedIco] : null;
		if (dfimljhknab == null)
		{
			return;
		}
		string text2 = ngiaaohfnpo.BNIHFBMEPAB;
		if (dfimljhknab.PGEDLDMLBBE != null)
		{
			text2 = text2.Replace("[X]", string.Concat(dfimljhknab.PGEDLDMLBBE.IBEIBAHKIAH));
			text2 = text2.Replace("[Y]", string.Concat(dfimljhknab.PGEDLDMLBBE.ICJDPPOJINN));
			text2 = text2.Replace("[Z]", string.Concat(dfimljhknab.PGEDLDMLBBE.NODLBGKEGPM));
			text = text.Replace("[X]", string.Concat(dfimljhknab.PGEDLDMLBBE.IBEIBAHKIAH));
			text = text.Replace("[Y]", string.Concat(dfimljhknab.PGEDLDMLBBE.ICJDPPOJINN));
			text = text.Replace("[Z]", string.Concat(dfimljhknab.PGEDLDMLBBE.NODLBGKEGPM));
		}
		GUI.Label(new Rect(52f, 20f, 260f, 20f), "<color='#000000'>" + text2 + "</color>", guistyle);
		if (!dfimljhknab.HIMLCNPEEDM)
		{
			int cgnljcomfac = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
			text = text + "\n\n " + JLFJEGIPIMM.IKGFHGKKCPG.CBBDFCOMGLP(cgnljcomfac);
		}
		GUIContent content = new GUIContent(text);
		GUI.Label(new Rect(52f, 50f, 280f, 200f), content, guistyle);
		this.GANOCEBJKJE = 52f + guistyle.CalcHeight(content, 280f) + 20f;
	}

	// Token: 0x06007040 RID: 28736 RVA: 0x00353671 File Offset: 0x00351871
	public FlyMessageManager.DFIMLJHKNAB IHPHKMLOCHJ(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI];
		}
		return null;
	}

	// Token: 0x06007041 RID: 28737 RVA: 0x00359E74 File Offset: 0x00358074
	public FlyMessageManager.CMEIEJNFCDP ODLGBMGAKGF(string IABKGMNJLJO, Color LBCGACKJCJB, int GIEALCKLKNL = 0, int KBGHOIJIPJF = 0)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "--", string.Empty);
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, LBCGACKJCJB, GIEALCKLKNL, KBGHOIJIPJF, 0);
		cmeiejnfcdp.CLBPBJGLHEE = this.MGJBAKFMDIK.Count;
		this.MGJBAKFMDIK.Add(cmeiejnfcdp);
		return cmeiejnfcdp;
	}

	// Token: 0x06007042 RID: 28738 RVA: 0x00355AFC File Offset: 0x00353CFC
	public void GHEEOOGDGBJ()
	{
		this.GKHBHKDLNDG.Clear();
		this.MGJBAKFMDIK.Clear();
	}

	// Token: 0x06007043 RID: 28739 RVA: 0x003551CC File Offset: 0x003533CC
	public void CFGDGKHCFPP()
	{
		this.LCJDLKEHPLC.Clear();
	}

	// Token: 0x06007044 RID: 28740 RVA: 0x00359EC0 File Offset: 0x003580C0
	public void EGBHFOIAIDF(HBPNMNGOFMA KADBECGIMPD)
	{
		while (!KADBECGIMPD.JEFMHDJEEJC())
		{
			int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
			IIBEEKCAAHK pgedldmlbbe = KADBECGIMPD.JPHHGPIDDOA();
			DateTime dateTime = KADBECGIMPD.NIIFLPIEMFM() - TimeController.BOBNPEAEECC().deltaTime;
			bool nicooablloc = KADBECGIMPD.FIFNOBGEKFF();
			TimeSpan timeSpan = dateTime - DateTime.Now;
			float gdnokeolbpp = (float)((double)(Time.time + 320f) + timeSpan.TotalSeconds);
			this.OEEDLBFKPPD(lpfkfnlhgbi, gdnokeolbpp, pgedldmlbbe, true, nicooablloc).BGNJAKIMJBI = dateTime;
		}
	}

	// Token: 0x06007045 RID: 28741 RVA: 0x00359F38 File Offset: 0x00358138
	public void ADEDKOGFMME(HBPNMNGOFMA KADBECGIMPD)
	{
		KADBECGIMPD.IJDIMHAEAIE();
		string arg = KADBECGIMPD.LPKJHMGLCKA();
		int lpfkfnlhgbi = KADBECGIMPD.CLPEKGGAMAI();
		int num = KADBECGIMPD.KKOKFLMMAAK();
		int nkhbajkmagd = KADBECGIMPD.IFDFHJLCHAE();
		string arg2 = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(lpfkfnlhgbi).EMDPDLPDLOJ(nkhbajkmagd, num, true);
		string arg3 = "ArmFlex2";
		if (num == 0)
		{
			arg3 = "LDR";
		}
		if (num == 0)
		{
			arg3 = "WRINKLE_MAPS";
		}
		if (num == 8)
		{
			arg3 = "_UV_Transform";
		}
		if (num == 8)
		{
			arg3 = "foot";
		}
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(string.Format("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", arg, arg2, arg3), Color.black, 1, 1, 0);
		this.GKHBHKDLNDG.Add(cmeiejnfcdp);
		cmeiejnfcdp.CLBPBJGLHEE = this.GKHBHKDLNDG.Count - 1;
	}

	// Token: 0x06007046 RID: 28742 RVA: 0x00359FEE File Offset: 0x003581EE
	public IIBEEKCAAHK PIHMHKCPHND(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE;
		}
		return IIBEEKCAAHK.ECOFBCMPIDO;
	}

	// Token: 0x06007047 RID: 28743 RVA: 0x0035A018 File Offset: 0x00358218
	private void Update()
	{
		List<int> list = new List<int>();
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.BGNJAKIMJBI < DateTime.Now && !dfimljhknab.HIMLCNPEEDM)
			{
				list.Add(dfimljhknab.FPPHHJOADHG);
			}
		}
		foreach (int key in list)
		{
			this.LCJDLKEHPLC.Remove(key);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list2 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
		{
			cmeiejnfcdp.FANPFKHEDPA();
			if (cmeiejnfcdp.OAPJHIEOHCK)
			{
				list2.Add(cmeiejnfcdp);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item in list2)
		{
			this.MGJBAKFMDIK.Remove(item);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list3 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
		{
			cmeiejnfcdp2.FANPFKHEDPA();
			if (cmeiejnfcdp2.OAPJHIEOHCK)
			{
				list3.Add(cmeiejnfcdp2);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item2 in list3)
		{
			this.GKHBHKDLNDG.Remove(item2);
		}
	}

	// Token: 0x06007048 RID: 28744 RVA: 0x0035A224 File Offset: 0x00358424
	public void FHKCHOLADPC()
	{
		if (JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH)
		{
			return;
		}
		bool flag = false;
		if (LocNewLogic.getI != null)
		{
			flag = !LocNewLogic.getI.isLevelLoadProcess;
		}
		if (!flag)
		{
			return;
		}
		if (this.MGJBAKFMDIK.Count > 1)
		{
			foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
			{
				float num = 388f + (float)cmeiejnfcdp.CLBPBJGLHEE * 524f;
				float num2 = 1712f;
				Color lbcgackjcjb = cmeiejnfcdp.LBCGACKJCJB;
				GUIStyle guistyle = new GUIStyle
				{
					richText = false,
					normal = 
					{
						textColor = lbcgackjcjb
					},
					alignment = TextAnchor.LowerCenter,
					fontSize = -5
				};
				float x = guistyle.CalcSize(new GUIContent(cmeiejnfcdp.FPIHOPOCAHA)).x;
				float num3 = 401f;
				if (cmeiejnfcdp.NENOBDLCFHO > 0)
				{
					num3 += 1554f;
				}
				if (cmeiejnfcdp.OBEJHDCOCAI > 0)
				{
					num3 += 1367f;
				}
				if (cmeiejnfcdp.BDHHPAEHFHG != null)
				{
					num3 += 346f;
				}
				Color color = GUI.color;
				Color color2 = Color.gray;
				color2 *= cmeiejnfcdp.LBCGACKJCJB;
				color2.a = 1319f;
				GUI.color = color2;
				GUI.DrawTexture(new Rect((float)Screen.width / 501f - (x + num3) / 588f, num + 71f, x + num3, 602f), GameInterface.getI.brush, ScaleMode.StretchToFill);
				GUI.color = color;
				JDCEFOFMGHB.MNJNNDHCDGG().ALKAAKDPCDG(new Rect(1574f, num, (float)Screen.width, 456f), cmeiejnfcdp.FPIHOPOCAHA, guistyle);
				if (cmeiejnfcdp.NENOBDLCFHO > 1)
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(cmeiejnfcdp.NENOBDLCFHO);
					if (idchhhedhdc != null && idchhhedhdc.HNDLNEMINDM(cmeiejnfcdp.ENINGJOOIPB) != null && idchhhedhdc.ABALMFIKLCA(cmeiejnfcdp.ENINGJOOIPB).LECMGDEDAKF() != null)
					{
						int num4 = (int)((float)(Screen.width / 8) - x / 443f - 583f);
						GUI.DrawTexture(new Rect((float)num4 - num2, num, 884f, 1051f), idchhhedhdc.LANMGLMKPNA(cmeiejnfcdp.ENINGJOOIPB).KEDGAOBCNJG);
					}
					num2 += 1774f;
				}
				if (cmeiejnfcdp.OBEJHDCOCAI > 0)
				{
					int num5 = (int)((float)(Screen.width / 1) - x / 172f - 138f);
					Rect position = new Rect((float)num5 - num2, num, 1658f, 1373f);
					GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(cmeiejnfcdp.OBEJHDCOCAI, 2, 8));
					GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(1, 1, 0));
					num2 += 654f;
				}
				if (cmeiejnfcdp.BDHHPAEHFHG != null)
				{
					int num6 = (int)((float)(Screen.width / 8) - x / 538f - 1039f);
					Rect position2 = new Rect((float)num6 - num2, num, 487f, 626f);
					num2 += 1823f;
					GUI.DrawTexture(position2, GameInterface.getI.invEmptyCellSelect, (ScaleMode)6);
					GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(cmeiejnfcdp.OIILLFMOKNG, 5, 8));
					cmeiejnfcdp.BDHHPAEHFHG.JCIIPCEDICP(new Vector2(position2.x, position2.y));
					if (cmeiejnfcdp.OIILLFMOKNG > 1)
					{
						GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(cmeiejnfcdp.OIILLFMOKNG + 4, 4, 8));
					}
				}
				num += 992f;
			}
		}
		if (this.GKHBHKDLNDG.Count > 0)
		{
			int num7 = Screen.height - 51;
			GUIStyle guistyle2 = new GUIStyle
			{
				richText = false,
				normal = 
				{
					textColor = new Color(81f, 1128f, 1410f, 645f)
				},
				alignment = TextAnchor.MiddleRight,
				fontSize = -113
			};
			foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
			{
				Color textColor = guistyle2.normal.textColor;
				textColor.a = cmeiejnfcdp2.DHNMLPILJLC();
				guistyle2.normal.textColor = textColor;
				if (cmeiejnfcdp2.BDHHPAEHFHG != null)
				{
					Rect rect = new Rect((float)(Screen.width - -72), (float)num7, 1381f, 1886f);
					GUI.DrawTexture(rect, GameInterface.getI.invEmptyCellSelect, (ScaleMode)7);
					cmeiejnfcdp2.BDHHPAEHFHG.GDLELABHHFG(rect, cmeiejnfcdp2.OIILLFMOKNG, false, cmeiejnfcdp2.NENOBDLCFHO);
					JDCEFOFMGHB.JFIDAGABKID().ALKAAKDPCDG(new Rect((float)(Screen.width - -43 - -64), (float)(num7 + 7), 1743f, 518f), cmeiejnfcdp2.FPIHOPOCAHA, guistyle2);
					num7 -= 113;
				}
				else
				{
					JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect((float)(Screen.width - 137), (float)num7, 1917f, 501f), cmeiejnfcdp2.FPIHOPOCAHA, guistyle2);
					num7 -= 46;
				}
			}
		}
		float num8 = (float)Screen.width / 1816f;
		num8 -= (float)(this.LCJDLKEHPLC.Count * -31) / 1374f;
		num8 = 1902f;
		int num9 = -1;
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.LPPJMNPCEFO != null)
			{
				int num10 = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
				Rect position3 = new Rect(num8, 1878f, 1228f, 1332f);
				GUI.DrawTexture(position3, dfimljhknab.LPPJMNPCEFO.CFFHIODOGCH.KEDGAOBCNJG);
				if (position3.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF))
				{
					num9 = dfimljhknab.FPPHHJOADHG;
				}
				if (!dfimljhknab.HIMLCNPEEDM)
				{
					GUIStyle ofpnedeamab = new GUIStyle
					{
						normal = 
						{
							textColor = Color.white
						},
						alignment = TextAnchor.UpperCenter,
						fontSize = -109
					};
					if (num10 > 2 && num10 < -69)
					{
						JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect(num8 + 1272f - 1460f, 939f, 1199f, 672f), JLFJEGIPIMM.PKGMBFEMKGP().CBBDFCOMGLP(num10), ofpnedeamab);
					}
				}
			}
			num8 += 8f;
		}
		if (this.oldSelectedIco == num9)
		{
			this.icoTime += Time.time;
			if (this.oldSelectedIco > 0)
			{
				GUI.skin = GuiProcessor.IKGFHGKKCPG.alterSkin;
				Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
				Vector2 vector2 = new Vector2(vector.x + 414f, vector.y - 601f);
				if (vector2.x + 1105f > (float)(Screen.width - -34))
				{
					vector2.x = (float)(Screen.width - -114 - -93);
				}
				if (vector2.y + this.GANOCEBJKJE > (float)(Screen.height - -83))
				{
					vector2.y = (float)(Screen.height - 50) - this.GANOCEBJKJE;
				}
				if (vector2.y < 1481f)
				{
					vector2.y = 1336f;
				}
				GUI.Window(JDCEFOFMGHB.MNJNNDHCDGG().DIBNCPKGGOF + 0, new Rect(vector2.x, vector2.y, 97f, this.GANOCEBJKJE), new GUI.WindowFunction(this.OJAAAOJNHDD), "textAsset is NULL! Path: Weapons");
			}
			else
			{
				this.icoTime = 797f;
			}
		}
		else
		{
			this.icoTime = 756f;
		}
		this.oldSelectedIco = num9;
	}

	// Token: 0x06007049 RID: 28745 RVA: 0x00359FEE File Offset: 0x003581EE
	public IIBEEKCAAHK GEENAFMKIKI(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE;
		}
		return IIBEEKCAAHK.ECOFBCMPIDO;
	}

	// Token: 0x0600704A RID: 28746 RVA: 0x0035AA78 File Offset: 0x00358C78
	public void ABLOELFEPOG(HBPNMNGOFMA KADBECGIMPD)
	{
		KADBECGIMPD.DCGEOFHNBCN();
		string arg = KADBECGIMPD.DHCMILPKJAL();
		int lpfkfnlhgbi = KADBECGIMPD.AGNKAFLKCAG();
		int num = KADBECGIMPD.KDNDJNEGBDI();
		int nkhbajkmagd = KADBECGIMPD.AGNKAFLKCAG();
		string arg2 = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(lpfkfnlhgbi).FFAFKPDHOIN(nkhbajkmagd, num, true);
		string arg3 = "inv_bonus";
		if (num == 0)
		{
			arg3 = "Idle Fly";
		}
		if (num == 1)
		{
			arg3 = "ScatterDitherData";
		}
		if (num == 6)
		{
			arg3 = "{not_found}";
		}
		if (num == 4)
		{
			arg3 = "#b0ffa0";
		}
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(string.Format("shop_t10", arg, arg2, arg3), Color.black, 1, 0, 0);
		this.GKHBHKDLNDG.Add(cmeiejnfcdp);
		cmeiejnfcdp.CLBPBJGLHEE = this.GKHBHKDLNDG.Count - 1;
	}

	// Token: 0x0600704B RID: 28747 RVA: 0x0035AB30 File Offset: 0x00358D30
	public void OJAAAOJNHDD(int PHJOHHDOKHC)
	{
		FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = FlyMessageManager.getI.KPELAHLNOCH.ContainsKey(this.oldSelectedIco) ? FlyMessageManager.getI.KPELAHLNOCH[this.oldSelectedIco] : null;
		if (ngiaaohfnpo == null)
		{
			return;
		}
		GUI.BringWindowToFront(PHJOHHDOKHC);
		GUI.FocusWindow(PHJOHHDOKHC);
		GUI.skin = GuiProcessor.PLGADNLAEGN().alterSkin;
		GUI.DrawTexture(new Rect(789f, 1150f, 325f, 43f), ngiaaohfnpo.CFFHIODOGCH.IOMNHBMOGLG());
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperCenter,
			wordWrap = true,
			richText = false,
			font = GuiProcessor.BBLINJLBAIL().rusfont,
			fontSize = -33
		};
		string text = "' is not a valid integer" + ngiaaohfnpo.JCKHDHGIEEB + "Cards";
		FlyMessageManager.DFIMLJHKNAB dfimljhknab = this.LCJDLKEHPLC.ContainsKey(this.oldSelectedIco) ? this.LCJDLKEHPLC[this.oldSelectedIco] : null;
		if (dfimljhknab == null)
		{
			return;
		}
		string text2 = ngiaaohfnpo.BNIHFBMEPAB;
		if (dfimljhknab.PGEDLDMLBBE != null)
		{
			text2 = text2.Replace("A joint has just been broken!, force: ", string.Concat(dfimljhknab.PGEDLDMLBBE.IBEIBAHKIAH));
			text2 = text2.Replace("IdleSpew", string.Concat(dfimljhknab.PGEDLDMLBBE.NLHKFMMDMMK()));
			text2 = text2.Replace("sunshine_ShadowParamsAndHalfTexel", string.Concat(dfimljhknab.PGEDLDMLBBE.NODLBGKEGPM));
			text = text.Replace("name", string.Concat(dfimljhknab.PGEDLDMLBBE.KMIOLLENCOL()));
			text = text.Replace("Sound ", string.Concat(dfimljhknab.PGEDLDMLBBE.ICJDPPOJINN));
			text = text.Replace("", string.Concat(dfimljhknab.PGEDLDMLBBE.NFCDJLJNDLO()));
		}
		GUI.Label(new Rect(1950f, 1939f, 591f, 678f), "" + text2 + "<color='#000000'>--------------------------------------------------------</color>", guistyle);
		if (!dfimljhknab.HIMLCNPEEDM)
		{
			int cgnljcomfac = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
			text = text + "OnChatMessage" + JLFJEGIPIMM.IKGFHGKKCPG.LOHBELEBKJB(cgnljcomfac);
		}
		GUIContent content = new GUIContent(text);
		GUI.Label(new Rect(1378f, 1377f, 1641f, 261f), content, guistyle);
		this.GANOCEBJKJE = 471f + guistyle.CalcHeight(content, 557f) + 1695f;
	}

	// Token: 0x0600704C RID: 28748 RVA: 0x0035ADD0 File Offset: 0x00358FD0
	private void IGEICBNMPAD()
	{
		List<int> list = new List<int>();
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.BGNJAKIMJBI < DateTime.Now && !dfimljhknab.HIMLCNPEEDM)
			{
				list.Add(dfimljhknab.FPPHHJOADHG);
			}
		}
		foreach (int key in list)
		{
			this.LCJDLKEHPLC.Remove(key);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list2 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
		{
			cmeiejnfcdp.CBBLGEDCJBF();
			if (cmeiejnfcdp.OAPJHIEOHCK)
			{
				list2.Add(cmeiejnfcdp);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item in list2)
		{
			this.MGJBAKFMDIK.Remove(item);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list3 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
		{
			cmeiejnfcdp2.JPHLMNIMDHH();
			if (cmeiejnfcdp2.OAPJHIEOHCK)
			{
				list3.Add(cmeiejnfcdp2);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item2 in list3)
		{
			this.GKHBHKDLNDG.Remove(item2);
		}
	}

	// Token: 0x0600704D RID: 28749 RVA: 0x00353671 File Offset: 0x00351871
	public FlyMessageManager.DFIMLJHKNAB DJBOEFDLPDH(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI];
		}
		return null;
	}

	// Token: 0x0600704E RID: 28750 RVA: 0x0035AFDC File Offset: 0x003591DC
	public FlyMessageManager.DFIMLJHKNAB GHKLOINGEIH(int LPFKFNLHGBI, float GDNOKEOLBPP, IIBEEKCAAHK PGEDLDMLBBE, bool IFDCENIDLDM = false, bool NICOOABLLOC = false)
	{
		FlyMessageManager.DFIMLJHKNAB dfimljhknab;
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			DateTime dateTime = DateTime.Now.AddSeconds((double)GDNOKEOLBPP);
			this.LCJDLKEHPLC[LPFKFNLHGBI].HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab = this.LCJDLKEHPLC[LPFKFNLHGBI];
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			if (IFDCENIDLDM)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
				this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE = PGEDLDMLBBE;
			}
			else if (this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI < dateTime)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
			}
		}
		else
		{
			dfimljhknab = new FlyMessageManager.DFIMLJHKNAB(LPFKFNLHGBI, GDNOKEOLBPP, PGEDLDMLBBE);
			dfimljhknab.HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			this.LCJDLKEHPLC.Add(LPFKFNLHGBI, dfimljhknab);
		}
		return dfimljhknab;
	}

	// Token: 0x0600704F RID: 28751 RVA: 0x00355AFC File Offset: 0x00353CFC
	public void CGKPOCMEDGJ()
	{
		this.GKHBHKDLNDG.Clear();
		this.MGJBAKFMDIK.Clear();
	}

	// Token: 0x06007050 RID: 28752 RVA: 0x0035B0B0 File Offset: 0x003592B0
	public FlyMessageManager.DFIMLJHKNAB OEEDLBFKPPD(int LPFKFNLHGBI, float GDNOKEOLBPP, IIBEEKCAAHK PGEDLDMLBBE, bool IFDCENIDLDM = false, bool NICOOABLLOC = false)
	{
		FlyMessageManager.DFIMLJHKNAB dfimljhknab;
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			DateTime dateTime = DateTime.Now.AddSeconds((double)GDNOKEOLBPP);
			this.LCJDLKEHPLC[LPFKFNLHGBI].HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab = this.LCJDLKEHPLC[LPFKFNLHGBI];
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			if (IFDCENIDLDM)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
				this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE = PGEDLDMLBBE;
			}
			else if (this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI < dateTime)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
			}
		}
		else
		{
			dfimljhknab = new FlyMessageManager.DFIMLJHKNAB(LPFKFNLHGBI, GDNOKEOLBPP, PGEDLDMLBBE);
			dfimljhknab.HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			this.LCJDLKEHPLC.Add(LPFKFNLHGBI, dfimljhknab);
		}
		return dfimljhknab;
	}

	// Token: 0x06007051 RID: 28753 RVA: 0x0035B184 File Offset: 0x00359384
	public void PMOFPBKPKAP(string IABKGMNJLJO, Color LBCGACKJCJB)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "RollerBladeJump", string.Empty);
		IABKGMNJLJO = string.Format("KatanaReady", IABKGMNJLJO, LBCGACKJCJB.ToString("Clear reference not set."));
		this.GKHBHKDLNDG.Add(new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, Color.white, 1, 1, 0));
	}

	// Token: 0x06007052 RID: 28754 RVA: 0x0035B1D8 File Offset: 0x003593D8
	public void addRightMessage(string IABKGMNJLJO, int GIEALCKLKNL = 0, int KBGHOIJIPJF = 0, int NENOBDLCFHO = 0)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "<[^>]+>", string.Empty);
		IABKGMNJLJO = "<color='#c0c080'>" + IABKGMNJLJO + "</color>";
		FlyMessageManager.CMEIEJNFCDP item = new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, Color.white, GIEALCKLKNL, KBGHOIJIPJF, NENOBDLCFHO);
		this.GKHBHKDLNDG.Add(item);
	}

	// Token: 0x06007053 RID: 28755 RVA: 0x003557A8 File Offset: 0x003539A8
	public IIBEEKCAAHK AMLGJKLIFON(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE;
		}
		return IIBEEKCAAHK.IMJHKMLHDJH();
	}

	// Token: 0x06007054 RID: 28756 RVA: 0x00353671 File Offset: 0x00351871
	public FlyMessageManager.DFIMLJHKNAB JMCILBEKJKP(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI];
		}
		return null;
	}

	// Token: 0x06007055 RID: 28757 RVA: 0x00354CBA File Offset: 0x00352EBA
	public bool MMIMPMPGHPN(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI);
	}

	// Token: 0x06007056 RID: 28758 RVA: 0x0035B228 File Offset: 0x00359428
	public void OCOKIIJDPAE(HBPNMNGOFMA KADBECGIMPD)
	{
		while (!KADBECGIMPD.DFLKBBNOGBG())
		{
			int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
			IIBEEKCAAHK pgedldmlbbe = KADBECGIMPD.FCLPDDODOJP();
			DateTime dateTime = KADBECGIMPD.MILGIGJBAJL() - TimeController.IKGFHGKKCPG.deltaTime;
			bool nicooablloc = KADBECGIMPD.AJECAOJPOKA();
			TimeSpan timeSpan = dateTime - DateTime.Now;
			float gdnokeolbpp = (float)((double)(Time.time + 548f) + timeSpan.TotalSeconds);
			this.EHJDPPPJHAI(lpfkfnlhgbi, gdnokeolbpp, pgedldmlbbe, false, nicooablloc).BGNJAKIMJBI = dateTime;
		}
	}

	// Token: 0x06007057 RID: 28759 RVA: 0x0035B2A0 File Offset: 0x003594A0
	public void addRightMessageColored(string IABKGMNJLJO, Color LBCGACKJCJB)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "<[^>]+>", string.Empty);
		IABKGMNJLJO = string.Format("<color='#{1}'>{0}</color>", IABKGMNJLJO, LBCGACKJCJB.ToString("0x"));
		this.GKHBHKDLNDG.Add(new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, Color.white, 0, 0, 0));
	}

	// Token: 0x06007058 RID: 28760 RVA: 0x0035B2F4 File Offset: 0x003594F4
	public void CLALBPEIKMG()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KPELAHLNOCH.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.DBMJJPBOPEK().GIGGIHMAPLH("WorkerShovel", true));
		foreach (object obj in xmlDocument.SelectNodes("isWoman"))
		{
			FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = new FlyMessageManager.NGIAAOHFNPO((XmlNode)obj);
			this.KPELAHLNOCH.Add(ngiaaohfnpo.LPFKFNLHGBI, ngiaaohfnpo);
		}
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x06007059 RID: 28761 RVA: 0x00359FEE File Offset: 0x003581EE
	public IIBEEKCAAHK getFlyIconForce(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE;
		}
		return IIBEEKCAAHK.ECOFBCMPIDO;
	}

	// Token: 0x0600705A RID: 28762 RVA: 0x0035B398 File Offset: 0x00359598
	public void reinit()
	{
		this.LGFJMPLCGJM = false;
		this.KPELAHLNOCH.Clear();
		this.init();
	}

	// Token: 0x0600705B RID: 28763 RVA: 0x0035B3B4 File Offset: 0x003595B4
	public void CBEFKGBCAHK()
	{
		if (JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH)
		{
			return;
		}
		bool flag = true;
		if (LocNewLogic.getI != null)
		{
			flag = LocNewLogic.getI.isLevelLoadProcess;
		}
		if (!flag)
		{
			return;
		}
		if (this.MGJBAKFMDIK.Count > 0)
		{
			foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
			{
				float num = 373f + (float)cmeiejnfcdp.CLBPBJGLHEE * 287f;
				float num2 = 605f;
				Color lbcgackjcjb = cmeiejnfcdp.LBCGACKJCJB;
				GUIStyle guistyle = new GUIStyle
				{
					richText = true,
					normal = 
					{
						textColor = lbcgackjcjb
					},
					alignment = TextAnchor.LowerCenter,
					fontSize = -69
				};
				float x = guistyle.CalcSize(new GUIContent(cmeiejnfcdp.FPIHOPOCAHA)).x;
				float num3 = 1195f;
				if (cmeiejnfcdp.NENOBDLCFHO > 0)
				{
					num3 += 824f;
				}
				if (cmeiejnfcdp.OBEJHDCOCAI > 0)
				{
					num3 += 295f;
				}
				if (cmeiejnfcdp.BDHHPAEHFHG != null)
				{
					num3 += 547f;
				}
				Color color = GUI.color;
				Color color2 = Color.gray;
				color2 *= cmeiejnfcdp.LBCGACKJCJB;
				color2.a = 606f;
				GUI.color = color2;
				GUI.DrawTexture(new Rect((float)Screen.width / 1293f - (x + num3) / 952f, num + 1794f, x + num3, 1036f), GameInterface.getI.brush, ScaleMode.StretchToFill);
				GUI.color = color;
				JDCEFOFMGHB.IKGFHGKKCPG.ALKAAKDPCDG(new Rect(1005f, num, (float)Screen.width, 1852f), cmeiejnfcdp.FPIHOPOCAHA, guistyle);
				if (cmeiejnfcdp.NENOBDLCFHO > 0)
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(cmeiejnfcdp.NENOBDLCFHO);
					if (idchhhedhdc != null && idchhhedhdc.CPMAGCGGBLI(cmeiejnfcdp.ENINGJOOIPB) != null && idchhhedhdc.IPKKBPLKLBJ(cmeiejnfcdp.ENINGJOOIPB).MMKLLFCKCAG() != null)
					{
						int num4 = (int)((float)(Screen.width / 3) - x / 1010f - 398f);
						GUI.DrawTexture(new Rect((float)num4 - num2, num, 976f, 537f), idchhhedhdc.FHPNJBAEAON(cmeiejnfcdp.ENINGJOOIPB).IOHNCGLFGDJ());
					}
					num2 += 71f;
				}
				if (cmeiejnfcdp.OBEJHDCOCAI > 0)
				{
					int num5 = (int)((float)(Screen.width / 0) - x / 803f - 803f);
					Rect position = new Rect((float)num5 - num2, num, 554f, 1229f);
					GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(cmeiejnfcdp.OBEJHDCOCAI, 3, 1));
					GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(1, 6, 0));
					num2 += 800f;
				}
				if (cmeiejnfcdp.BDHHPAEHFHG != null)
				{
					int num6 = (int)((float)(Screen.width / 5) - x / 699f - 318f);
					Rect position2 = new Rect((float)num6 - num2, num, 698f, 170f);
					num2 += 1775f;
					GUI.DrawTexture(position2, GameInterface.getI.invEmptyCellSelect, (ScaleMode)6);
					GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(cmeiejnfcdp.OIILLFMOKNG, 2, 0));
					cmeiejnfcdp.BDHHPAEHFHG.KKECHKMFNOL(new Vector2(position2.x, position2.y));
					if (cmeiejnfcdp.OIILLFMOKNG > 0)
					{
						GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(cmeiejnfcdp.OIILLFMOKNG + 5, 2, 4));
					}
				}
				num += 515f;
			}
		}
		if (this.GKHBHKDLNDG.Count > 0)
		{
			int num7 = Screen.height - 186;
			GUIStyle guistyle2 = new GUIStyle
			{
				richText = true,
				normal = 
				{
					textColor = new Color(1277f, 207f, 645f, 1178f)
				},
				alignment = TextAnchor.UpperCenter,
				fontSize = -44
			};
			foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
			{
				Color textColor = guistyle2.normal.textColor;
				textColor.a = cmeiejnfcdp2.HFKLLNAOOIM();
				guistyle2.normal.textColor = textColor;
				if (cmeiejnfcdp2.BDHHPAEHFHG != null)
				{
					Rect rect = new Rect((float)(Screen.width - -128), (float)num7, 21f, 1865f);
					GUI.DrawTexture(rect, GameInterface.getI.invEmptyCellSelect, (ScaleMode)7);
					cmeiejnfcdp2.BDHHPAEHFHG.GDLELABHHFG(rect, cmeiejnfcdp2.OIILLFMOKNG, true, cmeiejnfcdp2.NENOBDLCFHO);
					JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect((float)(Screen.width - 182 - 6), (float)(num7 + 8), 361f, 1015f), cmeiejnfcdp2.FPIHOPOCAHA, guistyle2);
					num7 -= 127;
				}
				else
				{
					JDCEFOFMGHB.IKGFHGKKCPG.ALKAAKDPCDG(new Rect((float)(Screen.width - 135), (float)num7, 1153f, 422f), cmeiejnfcdp2.FPIHOPOCAHA, guistyle2);
					num7 -= -108;
				}
			}
		}
		float num8 = (float)Screen.width / 839f;
		num8 -= (float)(this.LCJDLKEHPLC.Count * -49) / 1530f;
		num8 = 27f;
		int num9 = -1;
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.LPPJMNPCEFO != null)
			{
				int num10 = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
				Rect position3 = new Rect(num8, 18f, 313f, 834f);
				GUI.DrawTexture(position3, dfimljhknab.LPPJMNPCEFO.CFFHIODOGCH.EIMNFFAAHLI());
				if (position3.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF))
				{
					num9 = dfimljhknab.FPPHHJOADHG;
				}
				if (!dfimljhknab.HIMLCNPEEDM)
				{
					GUIStyle ofpnedeamab = new GUIStyle
					{
						normal = 
						{
							textColor = Color.white
						},
						alignment = TextAnchor.UpperLeft,
						fontSize = 94
					};
					if (num10 > 0 && num10 < -95)
					{
						JDCEFOFMGHB.HMJJPNDEKPP().ALKAAKDPCDG(new Rect(num8 + 760f - 728f, 1815f, 1225f, 1376f), JLFJEGIPIMM.NNEAHAFBOHC().LOEFBMIDABP(num10), ofpnedeamab);
					}
				}
			}
			num8 += 1622f;
		}
		if (this.oldSelectedIco == num9)
		{
			this.icoTime += Time.time;
			if (this.oldSelectedIco > 0)
			{
				GUI.skin = GuiProcessor.BBLINJLBAIL().alterSkin;
				Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
				Vector2 vector2 = new Vector2(vector.x + 40f, vector.y - 314f);
				if (vector2.x + 677f > (float)(Screen.width - -89))
				{
					vector2.x = (float)(Screen.width - -124 - -175);
				}
				if (vector2.y + this.GANOCEBJKJE > (float)(Screen.height - -52))
				{
					vector2.y = (float)(Screen.height - 0) - this.GANOCEBJKJE;
				}
				if (vector2.y < 363f)
				{
					vector2.y = 894f;
				}
				GUI.Window(JDCEFOFMGHB.MNJNNDHCDGG().DIBNCPKGGOF + 1, new Rect(vector2.x, vector2.y, 1063f, this.GANOCEBJKJE), new GUI.WindowFunction(this.IIPNNGKBPPN), "wpn_add/addoptions");
			}
			else
			{
				this.icoTime = 1547f;
			}
		}
		else
		{
			this.icoTime = 1512f;
		}
		this.oldSelectedIco = num9;
	}

	// Token: 0x0600705C RID: 28764 RVA: 0x00355AFC File Offset: 0x00353CFC
	public void IDNGBKFPNDJ()
	{
		this.GKHBHKDLNDG.Clear();
		this.MGJBAKFMDIK.Clear();
	}

	// Token: 0x0600705D RID: 28765 RVA: 0x0035BC08 File Offset: 0x00359E08
	public void init()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KPELAHLNOCH.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.IKGFHGKKCPG.CHFGNHKJNFG("ActiveIcons.xml", false));
		foreach (object obj in xmlDocument.SelectNodes("icon_data/icon"))
		{
			FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = new FlyMessageManager.NGIAAOHFNPO((XmlNode)obj);
			this.KPELAHLNOCH.Add(ngiaaohfnpo.LPFKFNLHGBI, ngiaaohfnpo);
		}
		this.LGFJMPLCGJM = true;
	}

	// Token: 0x0600705E RID: 28766 RVA: 0x00354CBA File Offset: 0x00352EBA
	public bool NBCJHFMPDEH(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI);
	}

	// Token: 0x0600705F RID: 28767 RVA: 0x0035BCAC File Offset: 0x00359EAC
	public void LECKCLOFJCI(string IABKGMNJLJO, Color LBCGACKJCJB)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "Crawl Locomotion", string.Empty);
		IABKGMNJLJO = string.Format("Mouse ScrollWheel", IABKGMNJLJO, LBCGACKJCJB.ToString("i grew because the inputfield was only this big"));
		this.GKHBHKDLNDG.Add(new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, Color.white, 0, 0, 0));
	}

	// Token: 0x06007060 RID: 28768 RVA: 0x0035BD00 File Offset: 0x00359F00
	public void KBNMCAAEJEG(int PHJOHHDOKHC)
	{
		FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = FlyMessageManager.getI.KPELAHLNOCH.ContainsKey(this.oldSelectedIco) ? FlyMessageManager.getI.KPELAHLNOCH[this.oldSelectedIco] : null;
		if (ngiaaohfnpo == null)
		{
			return;
		}
		GUI.BringWindowToFront(PHJOHHDOKHC);
		GUI.FocusWindow(PHJOHHDOKHC);
		GUI.skin = GuiProcessor.IKGFHGKKCPG.alterSkin;
		GUI.DrawTexture(new Rect(331f, 1899f, 1148f, 679f), ngiaaohfnpo.CFFHIODOGCH.HONJOFFBOPH());
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperCenter,
			wordWrap = true,
			richText = false,
			font = GuiProcessor.PLGADNLAEGN().rusfont,
			fontSize = -100
		};
		string text = "_BlurRadius4" + ngiaaohfnpo.JCKHDHGIEEB + "_BlurTex";
		FlyMessageManager.DFIMLJHKNAB dfimljhknab = this.LCJDLKEHPLC.ContainsKey(this.oldSelectedIco) ? this.LCJDLKEHPLC[this.oldSelectedIco] : null;
		if (dfimljhknab == null)
		{
			return;
		}
		string text2 = ngiaaohfnpo.BNIHFBMEPAB;
		if (dfimljhknab.PGEDLDMLBBE != null)
		{
			text2 = text2.Replace("MotorbikeLassoLeft", string.Concat(dfimljhknab.PGEDLDMLBBE.KEHIFGILLJA()));
			text2 = text2.Replace("_TapMedium", string.Concat(dfimljhknab.PGEDLDMLBBE.NLHKFMMDMMK()));
			text2 = text2.Replace("|", string.Concat(dfimljhknab.PGEDLDMLBBE.NFCDJLJNDLO()));
			text = text.Replace("IdleMonster", string.Concat(dfimljhknab.PGEDLDMLBBE.KMIOLLENCOL()));
			text = text.Replace("DealerShuffle", string.Concat(dfimljhknab.PGEDLDMLBBE.ICJDPPOJINN));
			text = text.Replace("Invalid ObscuredVector3 index!", string.Concat(dfimljhknab.PGEDLDMLBBE.NODLBGKEGPM));
		}
		GUI.Label(new Rect(193f, 1161f, 217f, 1690f), "OneHandSwordBackSwing" + text2 + "__c", guistyle);
		if (!dfimljhknab.HIMLCNPEEDM)
		{
			int cgnljcomfac = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
			text = text + " x" + JLFJEGIPIMM.PKGMBFEMKGP().LOEFBMIDABP(cgnljcomfac);
		}
		GUIContent content = new GUIContent(text);
		GUI.Label(new Rect(1794f, 963f, 821f, 905f), content, guistyle);
		this.GANOCEBJKJE = 563f + guistyle.CalcHeight(content, 689f) + 343f;
	}

	// Token: 0x06007061 RID: 28769 RVA: 0x0035BFA0 File Offset: 0x0035A1A0
	public void OPCBJJGFCHH(string IABKGMNJLJO, Color LBCGACKJCJB)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "DealerShuffle", string.Empty);
		IABKGMNJLJO = string.Format("linebreak.ogg", IABKGMNJLJO, LBCGACKJCJB.ToString("wpn_rec1"));
		this.GKHBHKDLNDG.Add(new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, Color.white, 0, 1, 1));
	}

	// Token: 0x06007062 RID: 28770 RVA: 0x00354F98 File Offset: 0x00353198
	public IIBEEKCAAHK MMAMJBOJOAC(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE;
		}
		return IIBEEKCAAHK.HLOLNGEKIIH();
	}

	// Token: 0x06007063 RID: 28771 RVA: 0x0035BFF4 File Offset: 0x0035A1F4
	public void KHKAALCHGMD(int PHJOHHDOKHC)
	{
		FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = FlyMessageManager.getI.KPELAHLNOCH.ContainsKey(this.oldSelectedIco) ? FlyMessageManager.getI.KPELAHLNOCH[this.oldSelectedIco] : null;
		if (ngiaaohfnpo == null)
		{
			return;
		}
		GUI.BringWindowToFront(PHJOHHDOKHC);
		GUI.FocusWindow(PHJOHHDOKHC);
		GUI.skin = GuiProcessor.IKGFHGKKCPG.alterSkin;
		GUI.DrawTexture(new Rect(1386f, 790f, 1791f, 1795f), ngiaaohfnpo.CFFHIODOGCH.HFNHCIGCOBE());
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperCenter,
			wordWrap = false,
			richText = true,
			font = GuiProcessor.PLGADNLAEGN().rusfont,
			fontSize = 112
		};
		string text = " remnabor=" + ngiaaohfnpo.JCKHDHGIEEB + "crunch.ogg";
		FlyMessageManager.DFIMLJHKNAB dfimljhknab = this.LCJDLKEHPLC.ContainsKey(this.oldSelectedIco) ? this.LCJDLKEHPLC[this.oldSelectedIco] : null;
		if (dfimljhknab == null)
		{
			return;
		}
		string text2 = ngiaaohfnpo.BNIHFBMEPAB;
		if (dfimljhknab.PGEDLDMLBBE != null)
		{
			text2 = text2.Replace("CrouchStrafeLeft", string.Concat(dfimljhknab.PGEDLDMLBBE.NKEOCCKEOCE()));
			text2 = text2.Replace("isRun", string.Concat(dfimljhknab.PGEDLDMLBBE.KMGAHCANELI()));
			text2 = text2.Replace("Trail", string.Concat(dfimljhknab.PGEDLDMLBBE.NODLBGKEGPM));
			text = text.Replace("_CurTex", string.Concat(dfimljhknab.PGEDLDMLBBE.IBEIBAHKIAH));
			text = text.Replace("****************** CamEffector APPLY 1", string.Concat(dfimljhknab.PGEDLDMLBBE.KMGAHCANELI()));
			text = text.Replace("CrouchStrafeLeft", string.Concat(dfimljhknab.PGEDLDMLBBE.NFCDJLJNDLO()));
		}
		GUI.Label(new Rect(1358f, 679f, 1868f, 1783f), "Mutilate" + text2 + "invn_ver2", guistyle);
		if (!dfimljhknab.HIMLCNPEEDM)
		{
			int cgnljcomfac = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
			text = text + "{0}" + JLFJEGIPIMM.PKGMBFEMKGP().LOEFBMIDABP(cgnljcomfac);
		}
		GUIContent content = new GUIContent(text);
		GUI.Label(new Rect(1900f, 1396f, 798f, 815f), content, guistyle);
		this.GANOCEBJKJE = 1261f + guistyle.CalcHeight(content, 716f) + 835f;
	}

	// Token: 0x06007064 RID: 28772 RVA: 0x0035C294 File Offset: 0x0035A494
	public void IMAFEEIJJIH(HBPNMNGOFMA KADBECGIMPD)
	{
		KADBECGIMPD.ANPEIKGEDHJ();
		string arg = KADBECGIMPD.DHCMILPKJAL();
		int lpfkfnlhgbi = KADBECGIMPD.HHLDBAEFNMJ();
		int num = KADBECGIMPD.HHLDBAEFNMJ();
		int nkhbajkmagd = KADBECGIMPD.IFDFHJLCHAE();
		string arg2 = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi).KGBHELBLPMF(nkhbajkmagd, num, false);
		string arg3 = "MotorbikeHeadstand";
		if (num == 0)
		{
			arg3 = "wpn_add/base";
		}
		if (num == 0)
		{
			arg3 = "Mouse Y";
		}
		if (num == 0)
		{
			arg3 = "RollerBladeTurnRight";
		}
		if (num == 5)
		{
			arg3 = "t_body";
		}
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(string.Format("post_15", arg, arg2, arg3), Color.black, 1, 1, 1);
		this.GKHBHKDLNDG.Add(cmeiejnfcdp);
		cmeiejnfcdp.CLBPBJGLHEE = this.GKHBHKDLNDG.Count - 1;
	}

	// Token: 0x06007065 RID: 28773 RVA: 0x00354CAC File Offset: 0x00352EAC
	public bool CCEOFHGEDJI(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.Remove(LPFKFNLHGBI);
	}

	// Token: 0x06007066 RID: 28774 RVA: 0x00354CAC File Offset: 0x00352EAC
	public bool IFNBNECNJKO(int LPFKFNLHGBI)
	{
		return this.LCJDLKEHPLC.Remove(LPFKFNLHGBI);
	}

	// Token: 0x06007067 RID: 28775 RVA: 0x0035C34C File Offset: 0x0035A54C
	public void JLEOMNAIEPA(HBPNMNGOFMA KADBECGIMPD)
	{
		KADBECGIMPD.DCGEOFHNBCN();
		string arg = KADBECGIMPD.BFPHBMDMODH();
		int lpfkfnlhgbi = KADBECGIMPD.HHLDBAEFNMJ();
		int num = KADBECGIMPD.IFDFHJLCHAE();
		int nkhbajkmagd = KADBECGIMPD.IFDFHJLCHAE();
		string arg2 = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi).FFAFKPDHOIN(nkhbajkmagd, num, false);
		string arg3 = "wpn_book2";
		if (num == 0)
		{
			arg3 = "Bases/{0}/";
		}
		if (num == 1)
		{
			arg3 = "MotorbikeWheelyNoHands";
		}
		if (num == 8)
		{
			arg3 = "wgt_gr";
		}
		if (num == 0)
		{
			arg3 = "SysAlert.wav";
		}
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(string.Format(" x", arg, arg2, arg3), Color.black, 0, 1, 0);
		this.GKHBHKDLNDG.Add(cmeiejnfcdp);
		cmeiejnfcdp.CLBPBJGLHEE = this.GKHBHKDLNDG.Count - 0;
	}

	// Token: 0x06007068 RID: 28776 RVA: 0x0035C404 File Offset: 0x0035A604
	public void MOPAEGJFDGJ(int PHJOHHDOKHC)
	{
		FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = FlyMessageManager.getI.KPELAHLNOCH.ContainsKey(this.oldSelectedIco) ? FlyMessageManager.getI.KPELAHLNOCH[this.oldSelectedIco] : null;
		if (ngiaaohfnpo == null)
		{
			return;
		}
		GUI.BringWindowToFront(PHJOHHDOKHC);
		GUI.FocusWindow(PHJOHHDOKHC);
		GUI.skin = GuiProcessor.BBLINJLBAIL().alterSkin;
		GUI.DrawTexture(new Rect(958f, 1465f, 857f, 1397f), ngiaaohfnpo.CFFHIODOGCH.IOHNCGLFGDJ());
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperLeft,
			wordWrap = true,
			richText = true,
			font = GuiProcessor.BBLINJLBAIL().rusfont,
			fontSize = -119
		};
		string text = "ObscuredPrefs vs PlayerPrefs, " + ngiaaohfnpo.JCKHDHGIEEB + "IdleDie2";
		FlyMessageManager.DFIMLJHKNAB dfimljhknab = this.LCJDLKEHPLC.ContainsKey(this.oldSelectedIco) ? this.LCJDLKEHPLC[this.oldSelectedIco] : null;
		if (dfimljhknab == null)
		{
			return;
		}
		string text2 = ngiaaohfnpo.BNIHFBMEPAB;
		if (dfimljhknab.PGEDLDMLBBE != null)
		{
			text2 = text2.Replace("References has no spine bones assigned, can not initiate the solver.", string.Concat(dfimljhknab.PGEDLDMLBBE.KMIOLLENCOL()));
			text2 = text2.Replace("", string.Concat(dfimljhknab.PGEDLDMLBBE.KMGAHCANELI()));
			text2 = text2.Replace("Giant 2 Hand Grab/Throw", string.Concat(dfimljhknab.PGEDLDMLBBE.NFCDJLJNDLO()));
			text = text.Replace("shop_bccost", string.Concat(dfimljhknab.PGEDLDMLBBE.KEHIFGILLJA()));
			text = text.Replace("SatNightFever", string.Concat(dfimljhknab.PGEDLDMLBBE.KMGAHCANELI()));
			text = text.Replace("wpn_add/base", string.Concat(dfimljhknab.PGEDLDMLBBE.CJKILDPJCFJ()));
		}
		GUI.Label(new Rect(371f, 1061f, 73f, 456f), "<color='#003000'>" + text2 + "tintColor", guistyle);
		if (!dfimljhknab.HIMLCNPEEDM)
		{
			int cgnljcomfac = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
			text = text + "wpn_bait1" + JLFJEGIPIMM.PKGMBFEMKGP().MJJADOLDBDN(cgnljcomfac);
		}
		GUIContent content = new GUIContent(text);
		GUI.Label(new Rect(727f, 1620f, 1607f, 1881f), content, guistyle);
		this.GANOCEBJKJE = 1760f + guistyle.CalcHeight(content, 677f) + 198f;
	}

	// Token: 0x06007069 RID: 28777 RVA: 0x0035C6A4 File Offset: 0x0035A8A4
	public FlyMessageManager.DFIMLJHKNAB KDKDJBKKDDK(int LPFKFNLHGBI, float GDNOKEOLBPP, IIBEEKCAAHK PGEDLDMLBBE, bool IFDCENIDLDM = false, bool NICOOABLLOC = false)
	{
		FlyMessageManager.DFIMLJHKNAB dfimljhknab;
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			DateTime dateTime = DateTime.Now.AddSeconds((double)GDNOKEOLBPP);
			this.LCJDLKEHPLC[LPFKFNLHGBI].HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab = this.LCJDLKEHPLC[LPFKFNLHGBI];
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			if (IFDCENIDLDM)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
				this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE = PGEDLDMLBBE;
			}
			else if (this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI < dateTime)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
			}
		}
		else
		{
			dfimljhknab = new FlyMessageManager.DFIMLJHKNAB(LPFKFNLHGBI, GDNOKEOLBPP, PGEDLDMLBBE);
			dfimljhknab.HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			this.LCJDLKEHPLC.Add(LPFKFNLHGBI, dfimljhknab);
		}
		return dfimljhknab;
	}

	// Token: 0x0600706A RID: 28778 RVA: 0x0035C778 File Offset: 0x0035A978
	public void LPIIICIDCOM()
	{
		this.LGFJMPLCGJM = true;
		this.KPELAHLNOCH.Clear();
		this.HMDPPKDFCCB();
	}

	// Token: 0x0600706B RID: 28779 RVA: 0x0035C794 File Offset: 0x0035A994
	public void JFMIPDEHBOJ(HBPNMNGOFMA KADBECGIMPD)
	{
		while (!KADBECGIMPD.KFKIFJDHCHB())
		{
			int lpfkfnlhgbi = KADBECGIMPD.KKOKFLMMAAK();
			IIBEEKCAAHK pgedldmlbbe = KADBECGIMPD.BAPGFMDPGKM();
			DateTime dateTime = KADBECGIMPD.OODOKDPIMOF() - TimeController.EKEBHIJMEML().deltaTime;
			bool nicooablloc = KADBECGIMPD.ELDBJFLCMAJ();
			TimeSpan timeSpan = dateTime - DateTime.Now;
			float gdnokeolbpp = (float)((double)(Time.time + 260f) + timeSpan.TotalSeconds);
			this.NBABNIKJJOA(lpfkfnlhgbi, gdnokeolbpp, pgedldmlbbe, false, nicooablloc).BGNJAKIMJBI = dateTime;
		}
	}

	// Token: 0x0600706C RID: 28780 RVA: 0x0035C80C File Offset: 0x0035AA0C
	public FlyMessageManager.DFIMLJHKNAB KGIGDKHACCJ(int LPFKFNLHGBI, float GDNOKEOLBPP, IIBEEKCAAHK PGEDLDMLBBE, bool IFDCENIDLDM = false, bool NICOOABLLOC = false)
	{
		FlyMessageManager.DFIMLJHKNAB dfimljhknab;
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			DateTime dateTime = DateTime.Now.AddSeconds((double)GDNOKEOLBPP);
			this.LCJDLKEHPLC[LPFKFNLHGBI].HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab = this.LCJDLKEHPLC[LPFKFNLHGBI];
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			if (IFDCENIDLDM)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
				this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE = PGEDLDMLBBE;
			}
			else if (this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI < dateTime)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
			}
		}
		else
		{
			dfimljhknab = new FlyMessageManager.DFIMLJHKNAB(LPFKFNLHGBI, GDNOKEOLBPP, PGEDLDMLBBE);
			dfimljhknab.HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			this.LCJDLKEHPLC.Add(LPFKFNLHGBI, dfimljhknab);
		}
		return dfimljhknab;
	}

	// Token: 0x0600706D RID: 28781 RVA: 0x003551CC File Offset: 0x003533CC
	public void KJOJGONGLHA()
	{
		this.LCJDLKEHPLC.Clear();
	}

	// Token: 0x0600706E RID: 28782 RVA: 0x0035C8E0 File Offset: 0x0035AAE0
	public FlyMessageManager.DFIMLJHKNAB addFlyIcon(int LPFKFNLHGBI, float GDNOKEOLBPP, IIBEEKCAAHK PGEDLDMLBBE, bool IFDCENIDLDM = false, bool NICOOABLLOC = false)
	{
		FlyMessageManager.DFIMLJHKNAB dfimljhknab;
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			DateTime dateTime = DateTime.Now.AddSeconds((double)GDNOKEOLBPP);
			this.LCJDLKEHPLC[LPFKFNLHGBI].HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab = this.LCJDLKEHPLC[LPFKFNLHGBI];
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			if (IFDCENIDLDM)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
				this.LCJDLKEHPLC[LPFKFNLHGBI].PGEDLDMLBBE = PGEDLDMLBBE;
			}
			else if (this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI < dateTime)
			{
				this.LCJDLKEHPLC[LPFKFNLHGBI].BGNJAKIMJBI = dateTime;
			}
		}
		else
		{
			dfimljhknab = new FlyMessageManager.DFIMLJHKNAB(LPFKFNLHGBI, GDNOKEOLBPP, PGEDLDMLBBE);
			dfimljhknab.HOAPIDBKIHG = IFDCENIDLDM;
			dfimljhknab.HIMLCNPEEDM = NICOOABLLOC;
			this.LCJDLKEHPLC.Add(LPFKFNLHGBI, dfimljhknab);
		}
		return dfimljhknab;
	}

	// Token: 0x06007070 RID: 28784 RVA: 0x003551CC File Offset: 0x003533CC
	public void GOJPFBLLBLC()
	{
		this.LCJDLKEHPLC.Clear();
	}

	// Token: 0x06007071 RID: 28785 RVA: 0x0035CA08 File Offset: 0x0035AC08
	public void FCLMFGGODJI(string IABKGMNJLJO, Color LBCGACKJCJB)
	{
		IABKGMNJLJO = Regex.Replace(IABKGMNJLJO, "PrimaryCausticsProjector", string.Empty);
		IABKGMNJLJO = string.Format("", IABKGMNJLJO, LBCGACKJCJB.ToString("ara_trail_mesh"));
		this.GKHBHKDLNDG.Add(new FlyMessageManager.CMEIEJNFCDP(IABKGMNJLJO, Color.white, 0, 0, 1));
	}

	// Token: 0x06007072 RID: 28786 RVA: 0x0035CA59 File Offset: 0x0035AC59
	public void PENFDGILGEJ()
	{
		this.LGFJMPLCGJM = true;
		this.KPELAHLNOCH.Clear();
		this.init();
	}

	// Token: 0x06007073 RID: 28787 RVA: 0x00357619 File Offset: 0x00355819
	public FlyMessageManager.NGIAAOHFNPO BHCGBKKPCFL(int LPFKFNLHGBI)
	{
		if (this.KPELAHLNOCH.ContainsKey(LPFKFNLHGBI))
		{
			this.KPELAHLNOCH[LPFKFNLHGBI].FPOKMAGCMNN();
			return this.KPELAHLNOCH[LPFKFNLHGBI];
		}
		return null;
	}

	// Token: 0x06007074 RID: 28788 RVA: 0x0035CA74 File Offset: 0x0035AC74
	public void KGLJBBPGCKP(HBPNMNGOFMA KADBECGIMPD)
	{
		KADBECGIMPD.DMABDIGCLKA();
		string arg = KADBECGIMPD.LPKJHMGLCKA();
		int lpfkfnlhgbi = KADBECGIMPD.LDLKLPJBIJN();
		int num = KADBECGIMPD.LDLKLPJBIJN();
		int nkhbajkmagd = KADBECGIMPD.LDLKLPJBIJN();
		string arg2 = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi).MNMIOMIDKHH(nkhbajkmagd, num, true);
		string arg3 = "|";
		if (num == 0)
		{
			arg3 = "<color='#b0a0c0'>";
		}
		if (num == 0)
		{
			arg3 = "_DepthScale";
		}
		if (num == 7)
		{
			arg3 = "ZombieIdle2";
		}
		if (num == 4)
		{
			arg3 = "name";
		}
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(string.Format("", arg, arg2, arg3), Color.black, 0, 1, 1);
		this.GKHBHKDLNDG.Add(cmeiejnfcdp);
		cmeiejnfcdp.CLBPBJGLHEE = this.GKHBHKDLNDG.Count - 1;
	}

	// Token: 0x06007075 RID: 28789 RVA: 0x0035CB2C File Offset: 0x0035AD2C
	public void NJJCNEDJENG(HBPNMNGOFMA KADBECGIMPD)
	{
		KADBECGIMPD.HFOPFEJDJFG();
		string arg = KADBECGIMPD.JJJJAGJCOGD();
		int lpfkfnlhgbi = KADBECGIMPD.CLPEKGGAMAI();
		int num = KADBECGIMPD.DOJKJHMJJNK();
		int nkhbajkmagd = KADBECGIMPD.KDNDJNEGBDI();
		string arg2 = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(lpfkfnlhgbi).IGFJGAGBDJM(nkhbajkmagd, num, true);
		string arg3 = " ♦ ";
		if (num == 0)
		{
			arg3 = "ZombieCrawl";
		}
		if (num == 1)
		{
			arg3 = "Weapon Fire";
		}
		if (num == 0)
		{
			arg3 = "and I needed";
		}
		if (num == 4)
		{
			arg3 = "ust_msg";
		}
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(string.Format("SneakIdle", arg, arg2, arg3), Color.black, 0, 0, 1);
		this.GKHBHKDLNDG.Add(cmeiejnfcdp);
		cmeiejnfcdp.CLBPBJGLHEE = this.GKHBHKDLNDG.Count - 0;
	}

	// Token: 0x06007076 RID: 28790 RVA: 0x0035CBE4 File Offset: 0x0035ADE4
	public void AFAMFHBFCMI()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.KPELAHLNOCH.Clear();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.EDKGBBIIBBC().KFHFODNFCNL("nowp", false));
		foreach (object obj in xmlDocument.SelectNodes("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6"))
		{
			FlyMessageManager.NGIAAOHFNPO ngiaaohfnpo = new FlyMessageManager.NGIAAOHFNPO((XmlNode)obj);
			this.KPELAHLNOCH.Add(ngiaaohfnpo.LPFKFNLHGBI, ngiaaohfnpo);
		}
		this.LGFJMPLCGJM = false;
	}

	// Token: 0x06007077 RID: 28791 RVA: 0x0035CC88 File Offset: 0x0035AE88
	public void EJPCMKJEPJP(HBPNMNGOFMA KADBECGIMPD)
	{
		KADBECGIMPD.HFOPFEJDJFG();
		string arg = KADBECGIMPD.BFPHBMDMODH();
		int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
		int num = KADBECGIMPD.KKOKFLMMAAK();
		int nkhbajkmagd = KADBECGIMPD.CLPEKGGAMAI();
		string arg2 = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(lpfkfnlhgbi).IGFJGAGBDJM(nkhbajkmagd, num, false);
		string arg3 = "";
		if (num == 0)
		{
			arg3 = "Space reference not set.";
		}
		if (num == 1)
		{
			arg3 = "RunDive";
		}
		if (num == 8)
		{
			arg3 = "and 'Result' are the same.";
		}
		if (num == 8)
		{
			arg3 = "Window test";
		}
		FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp = new FlyMessageManager.CMEIEJNFCDP(string.Format("t_beard", arg, arg2, arg3), Color.black, 0, 1, 1);
		this.GKHBHKDLNDG.Add(cmeiejnfcdp);
		cmeiejnfcdp.CLBPBJGLHEE = this.GKHBHKDLNDG.Count - 1;
	}

	// Token: 0x06007078 RID: 28792 RVA: 0x0035CD40 File Offset: 0x0035AF40
	private void GCCAPOHGAHA()
	{
		List<int> list = new List<int>();
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.BGNJAKIMJBI < DateTime.Now && !dfimljhknab.HIMLCNPEEDM)
			{
				list.Add(dfimljhknab.FPPHHJOADHG);
			}
		}
		foreach (int key in list)
		{
			this.LCJDLKEHPLC.Remove(key);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list2 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
		{
			cmeiejnfcdp.MFHGOLNLAAF();
			if (cmeiejnfcdp.OAPJHIEOHCK)
			{
				list2.Add(cmeiejnfcdp);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item in list2)
		{
			this.MGJBAKFMDIK.Remove(item);
		}
		List<FlyMessageManager.CMEIEJNFCDP> list3 = new List<FlyMessageManager.CMEIEJNFCDP>();
		foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
		{
			cmeiejnfcdp2.IEOICHPKEMD();
			if (cmeiejnfcdp2.OAPJHIEOHCK)
			{
				list3.Add(cmeiejnfcdp2);
			}
		}
		foreach (FlyMessageManager.CMEIEJNFCDP item2 in list3)
		{
			this.GKHBHKDLNDG.Remove(item2);
		}
	}

	// Token: 0x06007079 RID: 28793 RVA: 0x00353671 File Offset: 0x00351871
	public FlyMessageManager.DFIMLJHKNAB getFlyIcon(int LPFKFNLHGBI)
	{
		if (this.LCJDLKEHPLC.ContainsKey(LPFKFNLHGBI))
		{
			return this.LCJDLKEHPLC[LPFKFNLHGBI];
		}
		return null;
	}

	// Token: 0x0600707A RID: 28794 RVA: 0x0035CF4C File Offset: 0x0035B14C
	public void OnPostGUI()
	{
		if (JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH)
		{
			return;
		}
		bool flag = true;
		if (LocNewLogic.getI != null)
		{
			flag = !LocNewLogic.getI.isLevelLoadProcess;
		}
		if (!flag)
		{
			return;
		}
		if (this.MGJBAKFMDIK.Count > 0)
		{
			foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp in this.MGJBAKFMDIK)
			{
				float num = 110f + (float)cmeiejnfcdp.CLBPBJGLHEE * 56f;
				float num2 = 0f;
				Color lbcgackjcjb = cmeiejnfcdp.LBCGACKJCJB;
				GUIStyle guistyle = new GUIStyle
				{
					richText = true,
					normal = 
					{
						textColor = lbcgackjcjb
					},
					alignment = TextAnchor.MiddleCenter,
					fontSize = 22
				};
				float x = guistyle.CalcSize(new GUIContent(cmeiejnfcdp.FPIHOPOCAHA)).x;
				float num3 = 80f;
				if (cmeiejnfcdp.NENOBDLCFHO > 0)
				{
					num3 += 120f;
				}
				if (cmeiejnfcdp.OBEJHDCOCAI > 0)
				{
					num3 += 60f;
				}
				if (cmeiejnfcdp.BDHHPAEHFHG != null)
				{
					num3 += 60f;
				}
				Color color = GUI.color;
				Color color2 = Color.gray;
				color2 *= cmeiejnfcdp.LBCGACKJCJB;
				color2.a = 0.25f;
				GUI.color = color2;
				GUI.DrawTexture(new Rect((float)Screen.width / 2f - (x + num3) / 2f, num + 8f, x + num3, 40f), GameInterface.getI.brush, ScaleMode.ScaleAndCrop);
				GUI.color = color;
				JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect(0f, num, (float)Screen.width, 56f), cmeiejnfcdp.FPIHOPOCAHA, guistyle);
				if (cmeiejnfcdp.NENOBDLCFHO > 0)
				{
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(cmeiejnfcdp.NENOBDLCFHO);
					if (idchhhedhdc != null && idchhhedhdc.KMIIGKECOEB(cmeiejnfcdp.ENINGJOOIPB) != null && idchhhedhdc.KMIIGKECOEB(cmeiejnfcdp.ENINGJOOIPB).KEDGAOBCNJG != null)
					{
						int num4 = (int)((float)(Screen.width / 2) - x / 2f - 120f);
						GUI.DrawTexture(new Rect((float)num4 - num2, num, 112f, 56f), idchhhedhdc.KMIIGKECOEB(cmeiejnfcdp.ENINGJOOIPB).KEDGAOBCNJG);
					}
					num2 += 120f;
				}
				if (cmeiejnfcdp.OBEJHDCOCAI > 0)
				{
					int num5 = (int)((float)(Screen.width / 2) - x / 2f - 64f);
					Rect position = new Rect((float)num5 - num2, num, 56f, 56f);
					GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(cmeiejnfcdp.OBEJHDCOCAI, 8, 8));
					GUI.DrawTextureWithTexCoords(position, GameInterface.getI.achives, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(0, 8, 8));
					num2 += 60f;
				}
				if (cmeiejnfcdp.BDHHPAEHFHG != null)
				{
					int num6 = (int)((float)(Screen.width / 2) - x / 2f - 64f);
					Rect position2 = new Rect((float)num6 - num2, num, 56f, 56f);
					num2 += 60f;
					GUI.DrawTexture(position2, GameInterface.getI.invEmptyCellSelect, ScaleMode.ScaleToFit);
					GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(cmeiejnfcdp.OIILLFMOKNG, 7, 2));
					cmeiejnfcdp.BDHHPAEHFHG.JCIIPCEDICP(new Vector2(position2.x, position2.y));
					if (cmeiejnfcdp.OIILLFMOKNG > 1)
					{
						GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(cmeiejnfcdp.OIILLFMOKNG + 7, 7, 2));
					}
				}
				num += 56f;
			}
		}
		if (this.GKHBHKDLNDG.Count > 0)
		{
			int num7 = Screen.height - 180;
			GUIStyle guistyle2 = new GUIStyle
			{
				richText = true,
				normal = 
				{
					textColor = new Color(0.2f, 0.9f, 0.9f, 1f)
				},
				alignment = TextAnchor.LowerRight,
				fontSize = 12
			};
			foreach (FlyMessageManager.CMEIEJNFCDP cmeiejnfcdp2 in this.GKHBHKDLNDG)
			{
				Color textColor = guistyle2.normal.textColor;
				textColor.a = cmeiejnfcdp2.DAMNCMMHLBF;
				guistyle2.normal.textColor = textColor;
				if (cmeiejnfcdp2.BDHHPAEHFHG != null)
				{
					Rect rect = new Rect((float)(Screen.width - 33), (float)num7, 32f, 32f);
					GUI.DrawTexture(rect, GameInterface.getI.invEmptyCellSelect, ScaleMode.ScaleToFit);
					cmeiejnfcdp2.BDHHPAEHFHG.FCBHHPJLGLC(rect, cmeiejnfcdp2.OIILLFMOKNG, false, cmeiejnfcdp2.NENOBDLCFHO);
					JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect((float)(Screen.width - 505 - 33), (float)(num7 + 5), 500f, 20f), cmeiejnfcdp2.FPIHOPOCAHA, guistyle2);
					num7 -= 33;
				}
				else
				{
					JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect((float)(Screen.width - 505), (float)num7, 500f, 20f), cmeiejnfcdp2.FPIHOPOCAHA, guistyle2);
					num7 -= 16;
				}
			}
		}
		float num8 = (float)Screen.width / 2f;
		num8 -= (float)(this.LCJDLKEHPLC.Count * 34) / 2f;
		num8 = 280f;
		int num9 = -1;
		foreach (FlyMessageManager.DFIMLJHKNAB dfimljhknab in this.LCJDLKEHPLC.Values)
		{
			if (dfimljhknab.LPPJMNPCEFO != null)
			{
				int num10 = (int)(dfimljhknab.BGNJAKIMJBI - DateTime.Now).TotalSeconds;
				Rect position3 = new Rect(num8, 10f, 32f, 32f);
				GUI.DrawTexture(position3, dfimljhknab.LPPJMNPCEFO.CFFHIODOGCH.KEDGAOBCNJG);
				if (position3.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF))
				{
					num9 = dfimljhknab.FPPHHJOADHG;
				}
				if (!dfimljhknab.HIMLCNPEEDM)
				{
					GUIStyle ofpnedeamab = new GUIStyle
					{
						normal = 
						{
							textColor = Color.white
						},
						alignment = TextAnchor.UpperCenter,
						fontSize = 9
					};
					if (num10 > 3 && num10 < 3540)
					{
						JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect(num8 + 16f - 20f, 44f, 40f, 20f), JLFJEGIPIMM.IKGFHGKKCPG.CBBDFCOMGLP(num10), ofpnedeamab);
					}
				}
			}
			num8 += 34f;
		}
		if (this.oldSelectedIco == num9)
		{
			this.icoTime += Time.time;
			if (this.oldSelectedIco > 0)
			{
				GUI.skin = GuiProcessor.IKGFHGKKCPG.alterSkin;
				Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
				Vector2 vector2 = new Vector2(vector.x + 10f, vector.y - 120f);
				if (vector2.x + 260f > (float)(Screen.width - 10))
				{
					vector2.x = (float)(Screen.width - 10 - 260);
				}
				if (vector2.y + this.GANOCEBJKJE > (float)(Screen.height - 10))
				{
					vector2.y = (float)(Screen.height - 10) - this.GANOCEBJKJE;
				}
				if (vector2.y < 10f)
				{
					vector2.y = 10f;
				}
				GUI.Window(JDCEFOFMGHB.IKGFHGKKCPG.DIBNCPKGGOF + 1, new Rect(vector2.x, vector2.y, 340f, this.GANOCEBJKJE), new GUI.WindowFunction(this.icoInfoWinFunc), "");
			}
			else
			{
				this.icoTime = 0f;
			}
		}
		else
		{
			this.icoTime = 0f;
		}
		this.oldSelectedIco = num9;
	}

	// Token: 0x0400107E RID: 4222
	public static FlyMessageManager getI;

	// Token: 0x0400107F RID: 4223
	private readonly List<FlyMessageManager.CMEIEJNFCDP> MGJBAKFMDIK = new List<FlyMessageManager.CMEIEJNFCDP>();

	// Token: 0x04001080 RID: 4224
	private readonly List<FlyMessageManager.CMEIEJNFCDP> GKHBHKDLNDG = new List<FlyMessageManager.CMEIEJNFCDP>();

	// Token: 0x04001081 RID: 4225
	private Dictionary<int, FlyMessageManager.DFIMLJHKNAB> LCJDLKEHPLC = new Dictionary<int, FlyMessageManager.DFIMLJHKNAB>();

	// Token: 0x04001082 RID: 4226
	private readonly Dictionary<int, FlyMessageManager.NGIAAOHFNPO> KPELAHLNOCH = new Dictionary<int, FlyMessageManager.NGIAAOHFNPO>();

	// Token: 0x04001083 RID: 4227
	public float icoTime;

	// Token: 0x04001084 RID: 4228
	public int oldSelectedIco = -1;

	// Token: 0x04001085 RID: 4229
	private float GANOCEBJKJE = 180f;

	// Token: 0x04001086 RID: 4230
	private bool LGFJMPLCGJM;

	// Token: 0x020001E7 RID: 487
	public class CMEIEJNFCDP
	{
		// Token: 0x0600707B RID: 28795 RVA: 0x0035D7A0 File Offset: 0x0035B9A0
		public float KDPCPLINBDG()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1665f, 1959f);
		}

		// Token: 0x0600707C RID: 28796 RVA: 0x0035D7B8 File Offset: 0x0035B9B8
		public void PGIHAIPCJLL()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 368f;
				if (this.ODIDICEAHKK >= 764f)
				{
					this.MBGDNFAEFNE = false;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 954f;
				this.GCMDBMOJPAC -= Time.deltaTime * 1383f;
				if (this.GCMDBMOJPAC <= 1143f)
				{
					this.OAPJHIEOHCK = false;
				}
			}
		}

		// Token: 0x0600707D RID: 28797 RVA: 0x0035D840 File Offset: 0x0035BA40
		public void JLFBDOPFDDJ()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 28f;
				if (this.ODIDICEAHKK >= 1470f)
				{
					this.MBGDNFAEFNE = true;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 126f;
				this.GCMDBMOJPAC -= Time.deltaTime * 1730f;
				if (this.GCMDBMOJPAC <= 940f)
				{
					this.OAPJHIEOHCK = false;
				}
			}
		}

		// Token: 0x0600707E RID: 28798 RVA: 0x0035D8C8 File Offset: 0x0035BAC8
		public void CJHBCHBOLBI()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 168f;
				if (this.ODIDICEAHKK >= 1073f)
				{
					this.MBGDNFAEFNE = true;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 394f;
				this.GCMDBMOJPAC -= Time.deltaTime * 795f;
				if (this.GCMDBMOJPAC <= 339f)
				{
					this.OAPJHIEOHCK = true;
				}
			}
		}

		// Token: 0x0600707F RID: 28799 RVA: 0x0035D950 File Offset: 0x0035BB50
		public void IEOICHPKEMD()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 998f;
				if (this.ODIDICEAHKK >= 744f)
				{
					this.MBGDNFAEFNE = false;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 1714f;
				this.GCMDBMOJPAC -= Time.deltaTime * 1686f;
				if (this.GCMDBMOJPAC <= 1499f)
				{
					this.OAPJHIEOHCK = false;
				}
			}
		}

		// Token: 0x06007080 RID: 28800 RVA: 0x0035D9D6 File Offset: 0x0035BBD6
		public float IKPLLNBIKKD()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 527f, 1204f);
		}

		// Token: 0x06007081 RID: 28801 RVA: 0x0035D9ED File Offset: 0x0035BBED
		public float PMKEJGINIGD()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1014f, 1178f);
		}

		// Token: 0x06007082 RID: 28802 RVA: 0x0035DA04 File Offset: 0x0035BC04
		public void CBBLGEDCJBF()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 1532f;
				if (this.ODIDICEAHKK >= 156f)
				{
					this.MBGDNFAEFNE = false;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 1511f;
				this.GCMDBMOJPAC -= Time.deltaTime * 1482f;
				if (this.GCMDBMOJPAC <= 1076f)
				{
					this.OAPJHIEOHCK = true;
				}
			}
		}

		// Token: 0x06007083 RID: 28803 RVA: 0x0035DA8A File Offset: 0x0035BC8A
		public float LBHBBAOGFHL()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 932f, 67f);
		}

		// Token: 0x06007084 RID: 28804 RVA: 0x0035DAA1 File Offset: 0x0035BCA1
		public float DPKHMPIDMLG()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 850f, 1851f);
		}

		// Token: 0x06007085 RID: 28805 RVA: 0x0035DAB8 File Offset: 0x0035BCB8
		public float AJNMMCMBBFN()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 955f, 262f);
		}

		// Token: 0x06007086 RID: 28806 RVA: 0x0035DACF File Offset: 0x0035BCCF
		public float EJIHPKNIFFB()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1678f, 1583f);
		}

		// Token: 0x06007087 RID: 28807 RVA: 0x0035DAE6 File Offset: 0x0035BCE6
		public float CKJOFMEKLNB()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1695f, 211f);
		}

		// Token: 0x06007088 RID: 28808 RVA: 0x0035DB00 File Offset: 0x0035BD00
		public void EMFOECIPBIP()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 220f;
				if (this.ODIDICEAHKK >= 401f)
				{
					this.MBGDNFAEFNE = true;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 1954f;
				this.GCMDBMOJPAC -= Time.deltaTime * 80f;
				if (this.GCMDBMOJPAC <= 1485f)
				{
					this.OAPJHIEOHCK = true;
				}
			}
		}

		// Token: 0x06007089 RID: 28809 RVA: 0x0035DB86 File Offset: 0x0035BD86
		public float OBFKOHLLBOP()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 814f, 843f);
		}

		// Token: 0x0600708A RID: 28810 RVA: 0x0035DBA0 File Offset: 0x0035BDA0
		public void KMLNBHIIGKH()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 1943f;
				if (this.ODIDICEAHKK >= 1722f)
				{
					this.MBGDNFAEFNE = false;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 1933f;
				this.GCMDBMOJPAC -= Time.deltaTime * 1517f;
				if (this.GCMDBMOJPAC <= 112f)
				{
					this.OAPJHIEOHCK = true;
				}
			}
		}

		// Token: 0x0600708B RID: 28811 RVA: 0x0035DC26 File Offset: 0x0035BE26
		public float GCGFFJHIBCI()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 778f, 1443f);
		}

		// Token: 0x0600708C RID: 28812 RVA: 0x0035DC3D File Offset: 0x0035BE3D
		public float OHPMEENPENN()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1524f, 1902f);
		}

		// Token: 0x0600708D RID: 28813 RVA: 0x0035DC54 File Offset: 0x0035BE54
		public float MMIFKFNAMBB()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1868f, 191f);
		}

		// Token: 0x0600708E RID: 28814 RVA: 0x0035DC6B File Offset: 0x0035BE6B
		public float JMIGGEACCDM()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1744f, 647f);
		}

		// Token: 0x0600708F RID: 28815 RVA: 0x0035DC84 File Offset: 0x0035BE84
		public void PBFKCKCHEAC()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 107f;
				if (this.ODIDICEAHKK >= 1310f)
				{
					this.MBGDNFAEFNE = false;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 500f;
				this.GCMDBMOJPAC -= Time.deltaTime * 327f;
				if (this.GCMDBMOJPAC <= 3f)
				{
					this.OAPJHIEOHCK = true;
				}
			}
		}

		// Token: 0x06007090 RID: 28816 RVA: 0x0035DD0A File Offset: 0x0035BF0A
		public float IKHHLCGJMGB()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1500f, 995f);
		}

		// Token: 0x06007091 RID: 28817 RVA: 0x0035DD21 File Offset: 0x0035BF21
		public float MPEOEINCHDP()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1742f, 461f);
		}

		// Token: 0x06007092 RID: 28818 RVA: 0x0035DD38 File Offset: 0x0035BF38
		public void EKCKBDKEAKO()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 1302f;
				if (this.ODIDICEAHKK >= 41f)
				{
					this.MBGDNFAEFNE = false;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 105f;
				this.GCMDBMOJPAC -= Time.deltaTime * 499f;
				if (this.GCMDBMOJPAC <= 1584f)
				{
					this.OAPJHIEOHCK = true;
				}
			}
		}

		// Token: 0x06007093 RID: 28819 RVA: 0x0035DDC0 File Offset: 0x0035BFC0
		public void HONIFOPBBKC()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 940f;
				if (this.ODIDICEAHKK >= 1868f)
				{
					this.MBGDNFAEFNE = false;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 172f;
				this.GCMDBMOJPAC -= Time.deltaTime * 52f;
				if (this.GCMDBMOJPAC <= 1217f)
				{
					this.OAPJHIEOHCK = true;
				}
			}
		}

		// Token: 0x06007094 RID: 28820 RVA: 0x0035DE46 File Offset: 0x0035C046
		public float PLPKKAFNGLL()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 453f, 912f);
		}

		// Token: 0x06007095 RID: 28821 RVA: 0x0035DE5D File Offset: 0x0035C05D
		public float DGDLEHKCDOO()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1575f, 1496f);
		}

		// Token: 0x06007096 RID: 28822 RVA: 0x0035DE74 File Offset: 0x0035C074
		public void HMLNMHOMMNO()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 320f;
				if (this.ODIDICEAHKK >= 1608f)
				{
					this.MBGDNFAEFNE = true;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 71f;
				this.GCMDBMOJPAC -= Time.deltaTime * 1304f;
				if (this.GCMDBMOJPAC <= 905f)
				{
					this.OAPJHIEOHCK = true;
				}
			}
		}

		// Token: 0x06007097 RID: 28823 RVA: 0x0035DEFC File Offset: 0x0035C0FC
		public void LBGKAMLLACN()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 733f;
				if (this.ODIDICEAHKK >= 887f)
				{
					this.MBGDNFAEFNE = true;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 296f;
				this.GCMDBMOJPAC -= Time.deltaTime * 1966f;
				if (this.GCMDBMOJPAC <= 401f)
				{
					this.OAPJHIEOHCK = false;
				}
			}
		}

		// Token: 0x06007098 RID: 28824 RVA: 0x0035DF84 File Offset: 0x0035C184
		public void BEDAJLJFAFO()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 258f;
				if (this.ODIDICEAHKK >= 1978f)
				{
					this.MBGDNFAEFNE = false;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 1230f;
				this.GCMDBMOJPAC -= Time.deltaTime * 672f;
				if (this.GCMDBMOJPAC <= 1210f)
				{
					this.OAPJHIEOHCK = false;
				}
			}
		}

		// Token: 0x06007099 RID: 28825 RVA: 0x0035E00C File Offset: 0x0035C20C
		public void PJHEGHHOJHJ()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 1406f;
				if (this.ODIDICEAHKK >= 38f)
				{
					this.MBGDNFAEFNE = true;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 513f;
				this.GCMDBMOJPAC -= Time.deltaTime * 171f;
				if (this.GCMDBMOJPAC <= 1418f)
				{
					this.OAPJHIEOHCK = false;
				}
			}
		}

		// Token: 0x0600709A RID: 28826 RVA: 0x0035E092 File Offset: 0x0035C292
		public float GKDAPONHAPN()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 10f, 1626f);
		}

		// Token: 0x0600709B RID: 28827 RVA: 0x0035E0A9 File Offset: 0x0035C2A9
		public float AKCNFGDPNOE()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1492f, 506f);
		}

		// Token: 0x0600709C RID: 28828 RVA: 0x0035E0C0 File Offset: 0x0035C2C0
		public float MBFAOCCENLH()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 484f, 1198f);
		}

		// Token: 0x0600709D RID: 28829 RVA: 0x0035E0D8 File Offset: 0x0035C2D8
		public void JIBKGOFOPHJ()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 1147f;
				if (this.ODIDICEAHKK >= 1787f)
				{
					this.MBGDNFAEFNE = true;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 230f;
				this.GCMDBMOJPAC -= Time.deltaTime * 656f;
				if (this.GCMDBMOJPAC <= 1381f)
				{
					this.OAPJHIEOHCK = false;
				}
			}
		}

		// Token: 0x0600709E RID: 28830 RVA: 0x0035E160 File Offset: 0x0035C360
		public void FPLNDDMFFKG()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 1371f;
				if (this.ODIDICEAHKK >= 1388f)
				{
					this.MBGDNFAEFNE = true;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 1043f;
				this.GCMDBMOJPAC -= Time.deltaTime * 172f;
				if (this.GCMDBMOJPAC <= 1493f)
				{
					this.OAPJHIEOHCK = true;
				}
			}
		}

		// Token: 0x0600709F RID: 28831 RVA: 0x0035E1E6 File Offset: 0x0035C3E6
		public float DDMPCHGCMOO()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 894f, 818f);
		}

		// Token: 0x060070A0 RID: 28832 RVA: 0x0035E200 File Offset: 0x0035C400
		public void MEFOGCFJBNE()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 161f;
				if (this.ODIDICEAHKK >= 1453f)
				{
					this.MBGDNFAEFNE = true;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 698f;
				this.GCMDBMOJPAC -= Time.deltaTime * 1022f;
				if (this.GCMDBMOJPAC <= 1042f)
				{
					this.OAPJHIEOHCK = false;
				}
			}
		}

		// Token: 0x060070A1 RID: 28833 RVA: 0x0035E288 File Offset: 0x0035C488
		public CMEIEJNFCDP(string IABKGMNJLJO, Color FAODPFDPCLH, int JGDFEKKHDAE = 0, int KBGHOIJIPJF = 0, int OLKMHFNLBJB = 0)
		{
			this.LBCGACKJCJB = FAODPFDPCLH;
			this.NENOBDLCFHO = OLKMHFNLBJB;
			this.FPIHOPOCAHA = IABKGMNJLJO;
			this.MBGDNFAEFNE = true;
			this.OIILLFMOKNG = KBGHOIJIPJF;
			this.BDHHPAEHFHG = null;
			if (JGDFEKKHDAE > 0)
			{
				this.BDHHPAEHFHG = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(JGDFEKKHDAE);
				if (this.BDHHPAEHFHG != null)
				{
					this.BDHHPAEHFHG.JIFFLPNBILE();
				}
				if (JGDFEKKHDAE == 1309)
				{
					AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.NENOBDLCFHO).JIFFLPNBILE(2);
				}
			}
			this.GCMDBMOJPAC = 1f;
			this.ODIDICEAHKK = 0f;
		}

		// Token: 0x060070A2 RID: 28834 RVA: 0x0035E330 File Offset: 0x0035C530
		public void FANPFKHEDPA()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 0.4f;
				if (this.ODIDICEAHKK >= 1f)
				{
					this.MBGDNFAEFNE = false;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 0.3f;
				this.GCMDBMOJPAC -= Time.deltaTime * 0.3f;
				if (this.GCMDBMOJPAC <= 0f)
				{
					this.OAPJHIEOHCK = true;
				}
			}
		}

		// Token: 0x060070A3 RID: 28835 RVA: 0x0035E3B8 File Offset: 0x0035C5B8
		public void OFPGMNGFLNH()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 1964f;
				if (this.ODIDICEAHKK >= 37f)
				{
					this.MBGDNFAEFNE = true;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 503f;
				this.GCMDBMOJPAC -= Time.deltaTime * 105f;
				if (this.GCMDBMOJPAC <= 5f)
				{
					this.OAPJHIEOHCK = true;
				}
			}
		}

		// Token: 0x060070A4 RID: 28836 RVA: 0x0035E43E File Offset: 0x0035C63E
		public float OOGDCFALHJP()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 723f, 343f);
		}

		// Token: 0x060070A5 RID: 28837 RVA: 0x0035E458 File Offset: 0x0035C658
		public void BJOICAKCPLI()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 331f;
				if (this.ODIDICEAHKK >= 687f)
				{
					this.MBGDNFAEFNE = true;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 202f;
				this.GCMDBMOJPAC -= Time.deltaTime * 671f;
				if (this.GCMDBMOJPAC <= 767f)
				{
					this.OAPJHIEOHCK = false;
				}
			}
		}

		// Token: 0x060070A6 RID: 28838 RVA: 0x0035E4E0 File Offset: 0x0035C6E0
		public void DEGCCLNOEKJ()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 262f;
				if (this.ODIDICEAHKK >= 1133f)
				{
					this.MBGDNFAEFNE = true;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 1593f;
				this.GCMDBMOJPAC -= Time.deltaTime * 1914f;
				if (this.GCMDBMOJPAC <= 1452f)
				{
					this.OAPJHIEOHCK = false;
				}
			}
		}

		// Token: 0x060070A7 RID: 28839 RVA: 0x0035E566 File Offset: 0x0035C766
		public float IHPADFBMALN()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1847f, 1186f);
		}

		// Token: 0x060070A8 RID: 28840 RVA: 0x0035E580 File Offset: 0x0035C780
		public void IOGAKGCADBL()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 970f;
				if (this.ODIDICEAHKK >= 679f)
				{
					this.MBGDNFAEFNE = true;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 424f;
				this.GCMDBMOJPAC -= Time.deltaTime * 1220f;
				if (this.GCMDBMOJPAC <= 192f)
				{
					this.OAPJHIEOHCK = true;
				}
			}
		}

		// Token: 0x060070A9 RID: 28841 RVA: 0x0035E606 File Offset: 0x0035C806
		public float FCCKIDCIDGO()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1583f, 847f);
		}

		// Token: 0x060070AA RID: 28842 RVA: 0x0035E61D File Offset: 0x0035C81D
		public float HMFLJNDGLKE()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1147f, 1252f);
		}

		// Token: 0x060070AB RID: 28843 RVA: 0x0035E634 File Offset: 0x0035C834
		public float DOHNONOAMBN()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 676f, 160f);
		}

		// Token: 0x060070AC RID: 28844 RVA: 0x0035E64C File Offset: 0x0035C84C
		public void JMNNAPNJDNK()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 1092f;
				if (this.ODIDICEAHKK >= 1430f)
				{
					this.MBGDNFAEFNE = false;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 514f;
				this.GCMDBMOJPAC -= Time.deltaTime * 41f;
				if (this.GCMDBMOJPAC <= 1498f)
				{
					this.OAPJHIEOHCK = false;
				}
			}
		}

		// Token: 0x060070AD RID: 28845 RVA: 0x0035E6D4 File Offset: 0x0035C8D4
		public void MFHGOLNLAAF()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 631f;
				if (this.ODIDICEAHKK >= 1392f)
				{
					this.MBGDNFAEFNE = true;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 811f;
				this.GCMDBMOJPAC -= Time.deltaTime * 1992f;
				if (this.GCMDBMOJPAC <= 858f)
				{
					this.OAPJHIEOHCK = true;
				}
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060070AE RID: 28846 RVA: 0x0035E75A File Offset: 0x0035C95A
		public float DAMNCMMHLBF
		{
			get
			{
				return Mathf.Clamp(this.GCMDBMOJPAC, 0f, 1f);
			}
		}

		// Token: 0x060070AF RID: 28847 RVA: 0x0035E771 File Offset: 0x0035C971
		public float HFKLLNAOOIM()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1952f, 1362f);
		}

		// Token: 0x060070B0 RID: 28848 RVA: 0x0035E788 File Offset: 0x0035C988
		public void LBOONMDONCF()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 776f;
				if (this.ODIDICEAHKK >= 1758f)
				{
					this.MBGDNFAEFNE = false;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 1702f;
				this.GCMDBMOJPAC -= Time.deltaTime * 1201f;
				if (this.GCMDBMOJPAC <= 1596f)
				{
					this.OAPJHIEOHCK = true;
				}
			}
		}

		// Token: 0x060070B1 RID: 28849 RVA: 0x0035E80E File Offset: 0x0035CA0E
		public float KMEGAHFBCMC()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1219f, 594f);
		}

		// Token: 0x060070B2 RID: 28850 RVA: 0x0035E828 File Offset: 0x0035CA28
		public void FOHLAIIMNFB()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 1634f;
				if (this.ODIDICEAHKK >= 938f)
				{
					this.MBGDNFAEFNE = true;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 630f;
				this.GCMDBMOJPAC -= Time.deltaTime * 1139f;
				if (this.GCMDBMOJPAC <= 1954f)
				{
					this.OAPJHIEOHCK = true;
				}
			}
		}

		// Token: 0x060070B3 RID: 28851 RVA: 0x0035E8B0 File Offset: 0x0035CAB0
		public void OPDCJCFMIPE()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 485f;
				if (this.ODIDICEAHKK >= 1900f)
				{
					this.MBGDNFAEFNE = false;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 585f;
				this.GCMDBMOJPAC -= Time.deltaTime * 1643f;
				if (this.GCMDBMOJPAC <= 1926f)
				{
					this.OAPJHIEOHCK = false;
				}
			}
		}

		// Token: 0x060070B4 RID: 28852 RVA: 0x0035E938 File Offset: 0x0035CB38
		public void JPHLMNIMDHH()
		{
			if (this.MBGDNFAEFNE)
			{
				this.ODIDICEAHKK += Time.deltaTime * 128f;
				if (this.ODIDICEAHKK >= 338f)
				{
					this.MBGDNFAEFNE = false;
					return;
				}
			}
			else
			{
				this.ODIDICEAHKK -= Time.deltaTime * 1440f;
				this.GCMDBMOJPAC -= Time.deltaTime * 541f;
				if (this.GCMDBMOJPAC <= 1642f)
				{
					this.OAPJHIEOHCK = true;
				}
			}
		}

		// Token: 0x060070B5 RID: 28853 RVA: 0x0035E9BE File Offset: 0x0035CBBE
		public float DHNMLPILJLC()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 876f, 1308f);
		}

		// Token: 0x060070B6 RID: 28854 RVA: 0x0035E9D5 File Offset: 0x0035CBD5
		public float KDDAILAHHMB()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1995f, 1708f);
		}

		// Token: 0x060070B7 RID: 28855 RVA: 0x0035E9EC File Offset: 0x0035CBEC
		public float MKMHNNCIBOM()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 348f, 931f);
		}

		// Token: 0x060070B8 RID: 28856 RVA: 0x0035EA03 File Offset: 0x0035CC03
		public float IIHDFALBNCA()
		{
			return Mathf.Clamp(this.GCMDBMOJPAC, 1478f, 403f);
		}

		// Token: 0x04001087 RID: 4231
		public bool OAPJHIEOHCK;

		// Token: 0x04001088 RID: 4232
		public int CLBPBJGLHEE;

		// Token: 0x04001089 RID: 4233
		public readonly BEFCHFNGOMI BDHHPAEHFHG;

		// Token: 0x0400108A RID: 4234
		public int NENOBDLCFHO;

		// Token: 0x0400108B RID: 4235
		public int ENINGJOOIPB;

		// Token: 0x0400108C RID: 4236
		public int OBEJHDCOCAI;

		// Token: 0x0400108D RID: 4237
		public readonly int OIILLFMOKNG;

		// Token: 0x0400108E RID: 4238
		public readonly string FPIHOPOCAHA;

		// Token: 0x0400108F RID: 4239
		public Color LBCGACKJCJB = Color.white;

		// Token: 0x04001090 RID: 4240
		private bool MBGDNFAEFNE;

		// Token: 0x04001091 RID: 4241
		private float GCMDBMOJPAC;

		// Token: 0x04001092 RID: 4242
		private float ODIDICEAHKK;
	}

	// Token: 0x020001E8 RID: 488
	public class NGIAAOHFNPO
	{
		// Token: 0x060070B9 RID: 28857 RVA: 0x0035EA1C File Offset: 0x0035CC1C
		public string HMIPBNPBKCN(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("gi_inte_5", "_ReflectionBlur").Replace("[ProBuilder Attachments] 'Strip PB Scripts on Build' in Preferences / ProBuilder.", string.Concat(PGEDLDMLBBE.DHJBAKDAMGH())).Replace("bright", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("______________________________", string.Concat(PGEDLDMLBBE.NKGGAFLBFDF));
		}

		// Token: 0x060070BA RID: 28858 RVA: 0x0035EA8C File Offset: 0x0035CC8C
		public string INBHHBIANAG(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("{0} FPS", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("UserChange", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("ShotgunReadyFire", string.Concat(PGEDLDMLBBE.KCKFCPIHMPC()));
		}

		// Token: 0x060070BB RID: 28859 RVA: 0x0035EAF0 File Offset: 0x0035CCF0
		public string MKIIIECDGKD(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("_Rotation", string.Concat(PGEDLDMLBBE.DHJBAKDAMGH())).Replace("Crate Push", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("Water", string.Concat(PGEDLDMLBBE.HDPNCIECLKP()));
		}

		// Token: 0x060070BC RID: 28860 RVA: 0x0035EB51 File Offset: 0x0035CD51
		public void KBFFOIHMPLI()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(string.Format(IFPIMPMKJIB.AFJFDKAGKLD() + "I'm regular string", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x060070BD RID: 28861 RVA: 0x0035EB8C File Offset: 0x0035CD8C
		public string HFKPCLOBBNL(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace(", ", string.Concat(PGEDLDMLBBE.AIMCFAHLPEF())).Replace("https://www.youtube.com/watch?v=eP9-zycoHLk", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("512", string.Concat(PGEDLDMLBBE.KCKFCPIHMPC()));
		}

		// Token: 0x060070BE RID: 28862 RVA: 0x0035EBF0 File Offset: 0x0035CDF0
		public string JOMHHAPOMDO(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("error.wav", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("/", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("Sonar_pos", string.Concat(PGEDLDMLBBE.FJACMDGJEBL()));
		}

		// Token: 0x060070BF RID: 28863 RVA: 0x0035EC54 File Offset: 0x0035CE54
		public string HGEBOOHJIEJ(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("WizardOverhead", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("name", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("---", string.Concat(PGEDLDMLBBE.FJACMDGJEBL()));
		}

		// Token: 0x060070C0 RID: 28864 RVA: 0x0035ECB8 File Offset: 0x0035CEB8
		public string ELOGHPDBEEP(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("GiantGrabIdle2", "GAMMA").Replace("SUNSHINE_FILTER_HARD", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("IdleReady", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("Не реализовано", string.Concat(PGEDLDMLBBE.DBFOHFDOCIB()));
		}

		// Token: 0x060070C1 RID: 28865 RVA: 0x0035ED28 File Offset: 0x0035CF28
		public void IFMMLKBEDDH()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.IKGFHGKKCPG.PFNEPENHMOE(string.Format(IFPIMPMKJIB.ENLHJOJICDG() + "", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x060070C2 RID: 28866 RVA: 0x0035ED62 File Offset: 0x0035CF62
		public void LKGIOOAEJFP()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.PFOLNEGNIPP().EKHFCNKNHEJ(string.Format(IFPIMPMKJIB.EEAKGGDJAGB() + "ingredients", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x060070C3 RID: 28867 RVA: 0x0035ED9C File Offset: 0x0035CF9C
		public string IFACEMDDOCE(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("_AdaptationSpeed", "\n").Replace("human_move_2.wav", string.Concat(PGEDLDMLBBE.DHJBAKDAMGH())).Replace("Trying to solve uninitiated FABRIK chain.", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("post_13", string.Concat(PGEDLDMLBBE.HDPNCIECLKP()));
		}

		// Token: 0x060070C4 RID: 28868 RVA: 0x0035EE0C File Offset: 0x0035D00C
		public void KMJHLHOBBIL()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(string.Format(IFPIMPMKJIB.EEAKGGDJAGB() + "WoodCut", this.LPFKFNLHGBI), false);
			}
		}

		// Token: 0x060070C5 RID: 28869 RVA: 0x0035EE46 File Offset: 0x0035D046
		public void CDNDGMJMCPC()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.IKGFHGKKCPG.PFNEPENHMOE(string.Format(IFPIMPMKJIB.ACOEIDGDLJC() + "Climb to the top of the mountain to see the clouds (WASD keys to move).", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x060070C6 RID: 28870 RVA: 0x0035EE80 File Offset: 0x0035D080
		public string FEJDILHNLFJ(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("", "TAA History").Replace(" Packed: ", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("_LerpRgbTex", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace(",", string.Concat(PGEDLDMLBBE.DBFOHFDOCIB()));
		}

		// Token: 0x060070C7 RID: 28871 RVA: 0x0035EEF0 File Offset: 0x0035D0F0
		public void HAOLEOKBGLJ()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.PFOLNEGNIPP().EKHFCNKNHEJ(string.Format(IFPIMPMKJIB.LCEBBHPKOHO() + "Textures/Bases/", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x060070C8 RID: 28872 RVA: 0x0035EF2C File Offset: 0x0035D12C
		public string LHINCFAJJPJ(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("http://af-2.ru/?q=user/register", string.Concat(PGEDLDMLBBE.AIMCFAHLPEF())).Replace("\n", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("Mouse ScrollWheel", string.Concat(PGEDLDMLBBE.DBFOHFDOCIB()));
		}

		// Token: 0x060070C9 RID: 28873 RVA: 0x0035EF8D File Offset: 0x0035D18D
		public void CCKLIPELKJN()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.PFOLNEGNIPP().PFNEPENHMOE(string.Format(IFPIMPMKJIB.AFJFDKAGKLD() + "_BlurVector", this.LPFKFNLHGBI), false);
			}
		}

		// Token: 0x060070CA RID: 28874 RVA: 0x0035EFC7 File Offset: 0x0035D1C7
		public void KFLOBJCCHKN()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.IKGFHGKKCPG.PFNEPENHMOE(string.Format(IFPIMPMKJIB.LCEBBHPKOHO() + "25", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x060070CB RID: 28875 RVA: 0x0035F004 File Offset: 0x0035D204
		public string PIICBGHOPDG(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("Missing shader for image effect {0}", string.Concat(PGEDLDMLBBE.DHJBAKDAMGH())).Replace("body", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace(">", string.Concat(PGEDLDMLBBE.DBFOHFDOCIB()));
		}

		// Token: 0x060070CC RID: 28876 RVA: 0x0035F068 File Offset: 0x0035D268
		public string CAOEIHLCEEG(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("wpn_add/base", "perks/perk").Replace("****************  playMusic 2=", string.Concat(PGEDLDMLBBE.DHJBAKDAMGH())).Replace("USE_PREDICATION", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("inv_wpers", string.Concat(PGEDLDMLBBE.HDPNCIECLKP()));
		}

		// Token: 0x060070CD RID: 28877 RVA: 0x0035F0D8 File Offset: 0x0035D2D8
		public string ABCAKPONCAA(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("torso", "SoccerSprint").Replace("WireframeBack", string.Concat(PGEDLDMLBBE.AIMCFAHLPEF())).Replace("R", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("Mouse ScrollWheel", string.Concat(PGEDLDMLBBE.FJACMDGJEBL()));
		}

		// Token: 0x060070CE RID: 28878 RVA: 0x0035F148 File Offset: 0x0035D348
		public string DHOAHKPPFJD(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("loc", "Kernel").Replace("_BlurPass", string.Concat(PGEDLDMLBBE.DHJBAKDAMGH())).Replace("BipedReferences limb is completely stretched out in the initial pose. IK solver can not calculate the default bend plane for the limb. Please make sure you character's limbs are at least slightly bent in the initial pose. First bone: ", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("shop_ycnt", string.Concat(PGEDLDMLBBE.FJACMDGJEBL()));
		}

		// Token: 0x060070CF RID: 28879 RVA: 0x0035F1B8 File Offset: 0x0035D3B8
		public void FDFHBCMJGCK()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.PFOLNEGNIPP().IJMDNINDJGD(string.Format(IFPIMPMKJIB.LCEBBHPKOHO() + "LUM_CONTRIB_ON", this.LPFKFNLHGBI), false);
			}
		}

		// Token: 0x060070D0 RID: 28880 RVA: 0x0035F1F4 File Offset: 0x0035D3F4
		public string FPEBEBGMGGH(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("\\n", "\n").Replace("[X]", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("[Y]", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("[Z]", string.Concat(PGEDLDMLBBE.NKGGAFLBFDF));
		}

		// Token: 0x060070D1 RID: 28881 RVA: 0x0035F264 File Offset: 0x0035D464
		public string BAKGJJPJJCM(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("Assets/Weapons/baseLegs.unity3d", string.Concat(PGEDLDMLBBE.DHJBAKDAMGH())).Replace("Walk Backward", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("WeaponRun", string.Concat(PGEDLDMLBBE.DBFOHFDOCIB()));
		}

		// Token: 0x060070D2 RID: 28882 RVA: 0x0035F2C8 File Offset: 0x0035D4C8
		public string ONNDIBJKHFM(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("Eye", "_r_").Replace("_ProjInfoLeft", string.Concat(PGEDLDMLBBE.AIMCFAHLPEF())).Replace("", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("rodorder", string.Concat(PGEDLDMLBBE.NKGGAFLBFDF));
		}

		// Token: 0x060070D3 RID: 28883 RVA: 0x0035F338 File Offset: 0x0035D538
		public string KKNLJIGDNGF(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("SecondaryCausticsProjector", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("Formatted Label", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("Error! ", string.Concat(PGEDLDMLBBE.NKGGAFLBFDF));
		}

		// Token: 0x060070D4 RID: 28884 RVA: 0x0035F39C File Offset: 0x0035D59C
		public string PMAJCBFGFII(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("OfficeSittingReadingLeanBack", "MotorbikeLassoBack").Replace("JNT_Root", string.Concat(PGEDLDMLBBE.DHJBAKDAMGH())).Replace("", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("openPodsak", string.Concat(PGEDLDMLBBE.DBFOHFDOCIB()));
		}

		// Token: 0x060070D5 RID: 28885 RVA: 0x0035F40C File Offset: 0x0035D60C
		public void BIBNGENEFNC()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.IKGFHGKKCPG.PFNEPENHMOE(string.Format(IFPIMPMKJIB.NEJIPLDOMMC() + "<color='#303030'><size=10>{0}</size></color>\n<size=16><b>{1}</b></size><color='#302020'>  {3}</color>{2}", this.LPFKFNLHGBI), false);
			}
		}

		// Token: 0x060070D6 RID: 28886 RVA: 0x0035F446 File Offset: 0x0035D646
		public void ADPHGNFIBAF()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.PFOLNEGNIPP().EKHFCNKNHEJ(string.Format(IFPIMPMKJIB.ACOEIDGDLJC() + "_rcpFrame", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x060070D7 RID: 28887 RVA: 0x0035F480 File Offset: 0x0035D680
		public string ADCPABDHFKC(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("OfficeSittingMouseMovement", " ").Replace("IceHockeyIdle", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("ShotgunReadyFire", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("FogAreaCullingManager missing script.", string.Concat(PGEDLDMLBBE.DBFOHFDOCIB()));
		}

		// Token: 0x060070D8 RID: 28888 RVA: 0x0035F4F0 File Offset: 0x0035D6F0
		public string CHGBKFCOMBB(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("  ", " %\n").Replace("TOD_World2Sky", string.Concat(PGEDLDMLBBE.DHJBAKDAMGH())).Replace("FishModel", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("stacheaderok", string.Concat(PGEDLDMLBBE.NKGGAFLBFDF));
		}

		// Token: 0x060070D9 RID: 28889 RVA: 0x0035F560 File Offset: 0x0035D760
		public string ANHOELDLCFL(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("CrouchStrafeRight", "condAnchor").Replace("name", string.Concat(PGEDLDMLBBE.AIMCFAHLPEF())).Replace("OneHandSwordBlock", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("error", string.Concat(PGEDLDMLBBE.NKGGAFLBFDF));
		}

		// Token: 0x060070DA RID: 28890 RVA: 0x0035F5D0 File Offset: 0x0035D7D0
		public string KNJCHMKOGLE(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("_Tile8RT", "Colors length of ").Replace("{0} FPS", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("_Curve", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("FlyBackward", string.Concat(PGEDLDMLBBE.GJBKBEEJLDF()));
		}

		// Token: 0x060070DB RID: 28891 RVA: 0x0035F640 File Offset: 0x0035D840
		public string OFBNBBBMKFN(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("Turn", string.Concat(PGEDLDMLBBE.DHJBAKDAMGH())).Replace("money2.wav", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("Roller Blade Turn Right", string.Concat(PGEDLDMLBBE.FJACMDGJEBL()));
		}

		// Token: 0x060070DC RID: 28892 RVA: 0x0035F6A4 File Offset: 0x0035D8A4
		public string OAIAOEJLMAP(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("cancel", "3").Replace("FBBIKSettings is deprecated, you can now edit all the settings from the custom inspector of the FullBodyBipedIK component.", string.Concat(PGEDLDMLBBE.AIMCFAHLPEF())).Replace("IdleWalk", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("Try to change this Vector3 in memory:\n", string.Concat(PGEDLDMLBBE.KCKFCPIHMPC()));
		}

		// Token: 0x060070DD RID: 28893 RVA: 0x0035F714 File Offset: 0x0035D914
		public void FKFCPLEECHD()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.PFOLNEGNIPP().IJMDNINDJGD(string.Format(IFPIMPMKJIB.ACOEIDGDLJC() + "FULLNAME", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x060070DE RID: 28894 RVA: 0x0035F750 File Offset: 0x0035D950
		public NGIAAOHFNPO(XmlNode JEEEOEBNJDJ)
		{
			if (JEEEOEBNJDJ.Attributes == null)
			{
				return;
			}
			this.LPFKFNLHGBI = int.Parse(JEEEOEBNJDJ.Attributes["id"].Value);
			this.BNIHFBMEPAB = JEEEOEBNJDJ.Attributes["name"].Value;
			this.JCKHDHGIEEB = JEEEOEBNJDJ.Attributes["info"].Value;
		}

		// Token: 0x060070DF RID: 28895 RVA: 0x0035F7C4 File Offset: 0x0035D9C4
		public string BLLENKMHKNC(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("https://www.youtube.com/watch?v=eP9-zycoHLk", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("", string.Concat(PGEDLDMLBBE.GJBKBEEJLDF()));
		}

		// Token: 0x060070E0 RID: 28896 RVA: 0x0035F828 File Offset: 0x0035DA28
		public string HCAOAPMIEKN(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("componentD", "FishPointer").Replace("Mirror Refl Camera id", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("cntx_resauk", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("IdleButtonPress", string.Concat(PGEDLDMLBBE.HDPNCIECLKP()));
		}

		// Token: 0x060070E1 RID: 28897 RVA: 0x0035F898 File Offset: 0x0035DA98
		public string AHKJJIKIINI(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("{0}.{1}.{2}", "no_perk").Replace("Weapon Run Backward", string.Concat(PGEDLDMLBBE.AIMCFAHLPEF())).Replace(" ms", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("Cowboy1HandDraw", string.Concat(PGEDLDMLBBE.HDPNCIECLKP()));
		}

		// Token: 0x060070E2 RID: 28898 RVA: 0x0035F908 File Offset: 0x0035DB08
		public void CKACJBCFLCH()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.IKGFHGKKCPG.PFNEPENHMOE(string.Format(IFPIMPMKJIB.LIOPCJFCGAF() + "Giant3HitCombo", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x060070E3 RID: 28899 RVA: 0x0035F944 File Offset: 0x0035DB44
		public string FJJOMKNCKLG(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("*** updateDetailWpnInfo  ", "ROPE dst=").Replace("The shader ", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("The font '", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("\n", string.Concat(PGEDLDMLBBE.FJACMDGJEBL()));
		}

		// Token: 0x060070E4 RID: 28900 RVA: 0x0035F9B4 File Offset: 0x0035DBB4
		public void IEDIJECAKCE()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.PFOLNEGNIPP().IJMDNINDJGD(string.Format(IFPIMPMKJIB.EHCJCCILAHM() + "Zombie", this.LPFKFNLHGBI), false);
			}
		}

		// Token: 0x060070E5 RID: 28901 RVA: 0x0035F9F0 File Offset: 0x0035DBF0
		public string EJKCOONODLH(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("_Offsets", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("error", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("KneesIdle", string.Concat(PGEDLDMLBBE.DBFOHFDOCIB()));
		}

		// Token: 0x060070E6 RID: 28902 RVA: 0x0035FA54 File Offset: 0x0035DC54
		public string DCHDLEBDBOK(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("rodEventProc act=", "SatNightFever").Replace(" ", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("sadokfull2", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("demoLong", string.Concat(PGEDLDMLBBE.NKGGAFLBFDF));
		}

		// Token: 0x060070E7 RID: 28903 RVA: 0x0035FAC4 File Offset: 0x0035DCC4
		public string HHCCCIHAOJG(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace(" ", string.Concat(PGEDLDMLBBE.DHJBAKDAMGH())).Replace("cntx_improve", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("_FgOverlap", string.Concat(PGEDLDMLBBE.FJACMDGJEBL()));
		}

		// Token: 0x060070E8 RID: 28904 RVA: 0x0035FB28 File Offset: 0x0035DD28
		public string HIHPHACKAIE(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("_HalfResolution", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("__a", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("non MonoBehaviour", string.Concat(PGEDLDMLBBE.DBFOHFDOCIB()));
		}

		// Token: 0x060070E9 RID: 28905 RVA: 0x0035FB89 File Offset: 0x0035DD89
		public void BOKKHMIEOJA()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.PFOLNEGNIPP().PFNEPENHMOE(string.Format(IFPIMPMKJIB.ENLHJOJICDG() + "WireframeCamera", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x060070EA RID: 28906 RVA: 0x0035FBC3 File Offset: 0x0035DDC3
		public void CLKEKANENBJ()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.PFOLNEGNIPP().EKHFCNKNHEJ(string.Format(IFPIMPMKJIB.ACOEIDGDLJC() + "Character Not Active!", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x060070EB RID: 28907 RVA: 0x0035FC00 File Offset: 0x0035DE00
		public string HKPLLHJHNGB(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("JNT_Root", "_ColorBuffer").Replace("Motorbike", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("SysAlert.wav", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("HeelClick", string.Concat(PGEDLDMLBBE.FJACMDGJEBL()));
		}

		// Token: 0x060070EC RID: 28908 RVA: 0x0035FC70 File Offset: 0x0035DE70
		public string PCLBFMPCKBE(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("Mouse ScrollWheel", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("componentA=", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("", string.Concat(PGEDLDMLBBE.FJACMDGJEBL()));
		}

		// Token: 0x060070ED RID: 28909 RVA: 0x0035FCD1 File Offset: 0x0035DED1
		public void NFHJLOEEHGH()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.PFOLNEGNIPP().IJMDNINDJGD(string.Format(IFPIMPMKJIB.EHCJCCILAHM() + "MotorbikeWheelyNoHands", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x060070EE RID: 28910 RVA: 0x0035FD0B File Offset: 0x0035DF0B
		public void FPOKMAGCMNN()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(string.Format(IFPIMPMKJIB.BKKFFINMJBO() + "[F_EXP]", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x060070EF RID: 28911 RVA: 0x0035FD48 File Offset: 0x0035DF48
		public string BEFIAPHPIBJ(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("[X]", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("[Y]", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("[Z]", string.Concat(PGEDLDMLBBE.NKGGAFLBFDF));
		}

		// Token: 0x060070F0 RID: 28912 RVA: 0x0035FDAC File Offset: 0x0035DFAC
		public string ADDMIKCAKDP(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("offsets", "RollerBlade").Replace("PaperTurn.wav", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("IceHockeyDekeMiddle", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("Femur", string.Concat(PGEDLDMLBBE.DBFOHFDOCIB()));
		}

		// Token: 0x060070F1 RID: 28913 RVA: 0x0035FE1C File Offset: 0x0035E01C
		public void LDJNBMIPAHN()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.PFOLNEGNIPP().EKHFCNKNHEJ(string.Format(IFPIMPMKJIB.AFJFDKAGKLD() + "WallRunRight", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x060070F2 RID: 28914 RVA: 0x0035FE58 File Offset: 0x0035E058
		public string GOAHADBLPBL(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("U", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("-H", string.Concat(PGEDLDMLBBE.HDPNCIECLKP()));
		}

		// Token: 0x060070F3 RID: 28915 RVA: 0x0035FEBC File Offset: 0x0035E0BC
		public string HHIFOGNPBEM(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("space", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("Bow", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("IdleStand", string.Concat(PGEDLDMLBBE.GJBKBEEJLDF()));
		}

		// Token: 0x060070F4 RID: 28916 RVA: 0x0035FF20 File Offset: 0x0035E120
		public string LAEMPBBBAIE(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("AUTO_KEY_VALUE", "Camera Pivot").Replace("<[^>]*>", string.Concat(PGEDLDMLBBE.DHJBAKDAMGH())).Replace(".", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("IKSolverFABRIKRoot chain at index ", string.Concat(PGEDLDMLBBE.DBFOHFDOCIB()));
		}

		// Token: 0x060070F5 RID: 28917 RVA: 0x0035FF90 File Offset: 0x0035E190
		public void OHAJLHEGKNE()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.IKGFHGKKCPG.PFNEPENHMOE(string.Format(IFPIMPMKJIB.LCEBBHPKOHO() + "sortType", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x060070F6 RID: 28918 RVA: 0x0035FFCA File Offset: 0x0035E1CA
		public void NOAAFJJMLLE()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.IKGFHGKKCPG.IJMDNINDJGD(string.Format(IFPIMPMKJIB.ACOEIDGDLJC() + "IdleMeditate", this.LPFKFNLHGBI), false);
			}
		}

		// Token: 0x060070F7 RID: 28919 RVA: 0x00360004 File Offset: 0x0035E204
		public string MJGABJIDBJC(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("IdleDie2", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace(" has been disabled as it's not supported on the current platform.", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("wpn_rod1", string.Concat(PGEDLDMLBBE.KCKFCPIHMPC()));
		}

		// Token: 0x060070F8 RID: 28920 RVA: 0x00360068 File Offset: 0x0035E268
		public string BIDADBBBIPE(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("ProneIdle", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("file://", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("800000", string.Concat(PGEDLDMLBBE.GJBKBEEJLDF()));
		}

		// Token: 0x060070F9 RID: 28921 RVA: 0x003600C9 File Offset: 0x0035E2C9
		public void NFCBJNIGBME()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.PFOLNEGNIPP().IJMDNINDJGD(string.Format(IFPIMPMKJIB.EHCJCCILAHM() + "---", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x060070FA RID: 28922 RVA: 0x00360103 File Offset: 0x0035E303
		public void BNADBGJABML()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.PFOLNEGNIPP().PFNEPENHMOE(string.Format(IFPIMPMKJIB.ACOEIDGDLJC() + "SoccerSprint", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x060070FB RID: 28923 RVA: 0x00360140 File Offset: 0x0035E340
		public string BLKGHNIOKJB(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("UnityEngine.Vector3", string.Concat(PGEDLDMLBBE.AIMCFAHLPEF())).Replace("_History3Weight", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("[ACTk] WallHack Detector: can't be started since it doesn't exists in scene or not yet initialized!", string.Concat(PGEDLDMLBBE.DBFOHFDOCIB()));
		}

		// Token: 0x060070FC RID: 28924 RVA: 0x003601A1 File Offset: 0x0035E3A1
		public void JBOJODKBNLP()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.PFOLNEGNIPP().EKHFCNKNHEJ(string.Format(IFPIMPMKJIB.ENLHJOJICDG() + "IdleTyping", this.LPFKFNLHGBI), false);
			}
		}

		// Token: 0x060070FD RID: 28925 RVA: 0x003601DC File Offset: 0x0035E3DC
		public string BNKCFNLOLLJ(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("???", "PrimaryCausticsProjector").Replace("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_object.html", string.Concat(PGEDLDMLBBE.AIMCFAHLPEF())).Replace("<color='#000000'>{0}</color><color='#002000'>☢</color>", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("Animator unassigned in AnimationWarping", string.Concat(PGEDLDMLBBE.FJACMDGJEBL()));
		}

		// Token: 0x060070FE RID: 28926 RVA: 0x0036024C File Offset: 0x0035E44C
		public void JIFFLPNBILE()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(string.Format(IFPIMPMKJIB.DIDFMAELMJD + "Textures/FlyIcons/{0}.png", this.LPFKFNLHGBI), false);
			}
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x00360288 File Offset: 0x0035E488
		public string FCILHBKIOBC(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.JCKHDHGIEEB.Replace("fish/", "S").Replace("crft_wpnpr", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("hlp_", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("SteamManager", string.Concat(PGEDLDMLBBE.NKGGAFLBFDF));
		}

		// Token: 0x06007100 RID: 28928 RVA: 0x003602F8 File Offset: 0x0035E4F8
		public string DONLMCLHMDJ(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("spinbreak.ogg", string.Concat(PGEDLDMLBBE.AIMCFAHLPEF())).Replace("Please assign all Bones to the IK solver.", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("MotorbikeLookBack", string.Concat(PGEDLDMLBBE.HDPNCIECLKP()));
		}

		// Token: 0x06007101 RID: 28929 RVA: 0x00360359 File Offset: 0x0035E559
		public void KEICEAJOGFD()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.IKGFHGKKCPG.IJMDNINDJGD(string.Format(IFPIMPMKJIB.ACOEIDGDLJC() + "Autoclear", this.LPFKFNLHGBI), true);
			}
		}

		// Token: 0x06007102 RID: 28930 RVA: 0x00360394 File Offset: 0x0035E594
		public string EDGHIKDBNLB(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("", string.Concat(PGEDLDMLBBE.LNEPKLKELMI)).Replace("Kernel", string.Concat(PGEDLDMLBBE.NMKCBJKHBOH)).Replace("\n", string.Concat(PGEDLDMLBBE.FJACMDGJEBL()));
		}

		// Token: 0x06007103 RID: 28931 RVA: 0x003603F5 File Offset: 0x0035E5F5
		public void NFFPJJCOJHP()
		{
			if (this.CFFHIODOGCH == null)
			{
				this.CFFHIODOGCH = CKNLPGEPGGF.PFOLNEGNIPP().EKHFCNKNHEJ(string.Format(IFPIMPMKJIB.ENLHJOJICDG() + "[ACTk] <b>[ ObscuredInt test ]</b>", this.LPFKFNLHGBI), false);
			}
		}

		// Token: 0x06007104 RID: 28932 RVA: 0x00360430 File Offset: 0x0035E630
		public string ABGNNNKKAKJ(IIBEEKCAAHK PGEDLDMLBBE)
		{
			return this.BNIHFBMEPAB.Replace("004000", string.Concat(PGEDLDMLBBE.AIMCFAHLPEF())).Replace(" This is not possible to be called for standalone input. Please check your platform and code where this is called", string.Concat(PGEDLDMLBBE.OIGIHEPJFFJ())).Replace("Jump", string.Concat(PGEDLDMLBBE.KCKFCPIHMPC()));
		}

		// Token: 0x04001093 RID: 4243
		public int LPFKFNLHGBI;

		// Token: 0x04001094 RID: 4244
		public string BNIHFBMEPAB;

		// Token: 0x04001095 RID: 4245
		public string JCKHDHGIEEB;

		// Token: 0x04001096 RID: 4246
		public CKNLPGEPGGF.IAPCJOBDCEH CFFHIODOGCH;
	}

	// Token: 0x020001E9 RID: 489
	public class DFIMLJHKNAB
	{
		// Token: 0x06007105 RID: 28933 RVA: 0x00360494 File Offset: 0x0035E694
		public DFIMLJHKNAB(int LPFKFNLHGBI, float IEONDAPHIID, IIBEEKCAAHK GIBKPOMKLKJ)
		{
			this.HOAPIDBKIHG = false;
			this.FPPHHJOADHG = LPFKFNLHGBI;
			this.BGNJAKIMJBI = DateTime.Now.AddSeconds((double)IEONDAPHIID);
			this.PGEDLDMLBBE = GIBKPOMKLKJ;
			this.LPPJMNPCEFO = (FlyMessageManager.getI.KPELAHLNOCH.ContainsKey(LPFKFNLHGBI) ? FlyMessageManager.getI.KPELAHLNOCH[LPFKFNLHGBI] : null);
			if (this.LPPJMNPCEFO != null)
			{
				this.LPPJMNPCEFO.JIFFLPNBILE();
				return;
			}
			Debug.LogError("****** FlyIcon tmpl is null id=" + LPFKFNLHGBI);
		}

		// Token: 0x04001097 RID: 4247
		public int FPPHHJOADHG;

		// Token: 0x04001098 RID: 4248
		public bool HOAPIDBKIHG;

		// Token: 0x04001099 RID: 4249
		public FlyMessageManager.NGIAAOHFNPO LPPJMNPCEFO;

		// Token: 0x0400109A RID: 4250
		public bool HIMLCNPEEDM;

		// Token: 0x0400109B RID: 4251
		public IIBEEKCAAHK PGEDLDMLBBE;

		// Token: 0x0400109C RID: 4252
		public DateTime BGNJAKIMJBI;
	}
}
