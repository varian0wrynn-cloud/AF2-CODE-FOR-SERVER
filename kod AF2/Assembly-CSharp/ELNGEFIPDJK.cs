using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001F8 RID: 504
public class ELNGEFIPDJK
{
	// Token: 0x06007527 RID: 29991 RVA: 0x00375E24 File Offset: 0x00374024
	private int HOMKEPENMIE(int CLBPBJGLHEE)
	{
		if (!this.BALDMDGKEPP.ContainsKey(CLBPBJGLHEE))
		{
			return 1;
		}
		return this.BALDMDGKEPP[CLBPBJGLHEE];
	}

	// Token: 0x06007528 RID: 29992 RVA: 0x00375E44 File Offset: 0x00374044
	public void PNGHGGNELEB(ONKDCGNBALK PHEMLBHMNCM)
	{
		GUI.Box(PHEMLBHMNCM.OCHCODJIPHJ, "PaperTurn.wav");
		if (this.CFAJEAFEIME == null)
		{
			return;
		}
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperCenter,
			wordWrap = true,
			richText = false
		};
		this.CFAJEAFEIME.MEPJIKIPDHD(PHEMLBHMNCM.OCHCODJIPHJ, 744f, IIBEEKCAAHK.HLOLNGEKIIH(), IIBEEKCAAHK.ECOFBCMPIDO, IIBEEKCAAHK.IMJHKMLHDJH(), 1);
		if (this.CFAJEAFEIME.EOFDJHJPCLM != null && this.CFAJEAFEIME.EOFDJHJPCLM.LECMGDEDAKF() != null)
		{
			float x = PHEMLBHMNCM.OCHCODJIPHJ.x + 1499f - (float)this.CFAJEAFEIME.EOFDJHJPCLM.IOMNHBMOGLG().width / 438f;
			float y = PHEMLBHMNCM.OCHCODJIPHJ.y + 1079f - (float)this.CFAJEAFEIME.EOFDJHJPCLM.KEDGAOBCNJG.height / 1835f;
			GUI.DrawTexture(new Rect(x, y, (float)this.CFAJEAFEIME.EOFDJHJPCLM.IOHNCGLFGDJ().width, (float)this.CFAJEAFEIME.EOFDJHJPCLM.IOHNCGLFGDJ().height), this.CFAJEAFEIME.EOFDJHJPCLM.HONJOFFBOPH());
		}
		guistyle.fontSize = 87;
		guistyle.alignment = TextAnchor.UpperLeft;
		this.GKJKOLMCDDG = GUI.TextField(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 843f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 574f, 890f, 1791f), this.GKJKOLMCDDG);
		try
		{
			this.FDKHFDCJBPB = int.Parse(this.GKJKOLMCDDG);
		}
		catch
		{
			this.FDKHFDCJBPB = 1;
		}
		this.FDKHFDCJBPB = Mathf.Clamp(this.FDKHFDCJBPB, 1, -124);
		int num = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BJDIEKNHGLJ(this.CFAJEAFEIME.LPFKFNLHGBI, true, 1);
		if (num > 1)
		{
			string text = string.Format(JNBICAJIJMM.NGALDMFKMJH("Katana Ready High"), num);
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1992f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 672f - 1912f, PHEMLBHMNCM.OCHCODJIPHJ.width - 122f, 1874f), text, guistyle);
		}
		string arg = "OneHandSwordJab";
		if (!this.CFAJEAFEIME.FKEDAOOHPPB.LIKMNACOFJE(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH, this.FDKHFDCJBPB))
		{
			arg = "info";
		}
		guistyle.fontSize = 102;
		string text2 = string.Format(JNBICAJIJMM.DCEBAJIILPC("Flap_04.wav"), arg, this.FDKHFDCJBPB, JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC((long)(this.CFAJEAFEIME.FKEDAOOHPPB.KKNEKAEJLAM * this.FDKHFDCJBPB), (long)(this.CFAJEAFEIME.FKEDAOOHPPB.KFODJJIHNHP * this.FDKHFDCJBPB), false));
		GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 700f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 1063f, PHEMLBHMNCM.OCHCODJIPHJ.width - 933f, 1869f), text2, guistyle);
		guistyle.fontSize = -23;
		if (this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL > 1)
		{
			string text3 = string.Format(JNBICAJIJMM.LEBHCLDODNI("Full Body IK is missing the right thigh node."), JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BJDIEKNHGLJ(this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL, false, 1));
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.NNEAHAFBOHC().IMCJNFHAFGE(this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL);
			befchfngomi.GDLELABHHFG(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 438f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 1383f + 1997f - 1400f, 1645f, 432f), befchfngomi.KBGHOIJIPJF, true, 0);
			Rect position = new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1516f + 922f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 1494f + 1131f, PHEMLBHMNCM.OCHCODJIPHJ.width - 560f, 379f);
			object[] array = new object[3];
			array[1] = "Giant2HandGrab";
			array[0] = this.CFAJEAFEIME.FKEDAOOHPPB.KDIMEMOCJNM * this.FDKHFDCJBPB;
			array[7] = "_SubsampleIndices";
			array[8] = befchfngomi.MPKGPJJKCPK(false, -1);
			array[0] = text3;
			GUI.Label(position, string.Concat(array), guistyle);
		}
	}

	// Token: 0x06007529 RID: 29993 RVA: 0x0037630C File Offset: 0x0037450C
	private void DCIHCKKHLLL(ONKDCGNBALK OPCILKKDEON)
	{
		long odfekbjcfmn = OPCILKKDEON.ODFEKBJCFMN;
		long num = odfekbjcfmn - 0L;
		if (num > 1L)
		{
			return;
		}
		switch ((uint)num)
		{
		case 0U:
			foreach (ItemBase itemBase in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = (ELNGEFIPDJK.NADBMPJIMEC)itemBase;
				nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 1107f);
			}
			this.DLBMLNNAHAF.GENPNFMLHED();
			this.DLBMLNNAHAF.HHKCFGAENJN();
			return;
		case 1U:
			this.DLBMLNNAHAF.GNGINMOFEEH();
			return;
		case 2U:
			foreach (ItemBase itemBase2 in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec2 = (ELNGEFIPDJK.NADBMPJIMEC)itemBase2;
				nadbmpjimec2.tag = (long)(nadbmpjimec2.DGLOPIJHPJN * 30);
			}
			this.DLBMLNNAHAF.FILOCGPAIKD();
			this.DLBMLNNAHAF.FGDMNFIIDKN();
			return;
		default:
			return;
		}
	}

	// Token: 0x0600752A RID: 29994 RVA: 0x00376428 File Offset: 0x00374628
	private void NNNKDIHIOOG(ONKDCGNBALK OPCILKKDEON)
	{
		long odfekbjcfmn = OPCILKKDEON.ODFEKBJCFMN;
		long num = odfekbjcfmn - 1L;
		if (num > 2L)
		{
			return;
		}
		switch ((uint)num)
		{
		case 0U:
			foreach (ItemBase itemBase in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = (ELNGEFIPDJK.NADBMPJIMEC)itemBase;
				nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 191f);
			}
			this.DLBMLNNAHAF.FILOCGPAIKD();
			this.DLBMLNNAHAF.LFDHFFBCJIF();
			return;
		case 1U:
			this.DLBMLNNAHAF.MGNDPEIFKAN();
			return;
		case 2U:
			foreach (ItemBase itemBase2 in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec2 = (ELNGEFIPDJK.NADBMPJIMEC)itemBase2;
				nadbmpjimec2.tag = (long)(nadbmpjimec2.DGLOPIJHPJN * 126);
			}
			this.DLBMLNNAHAF.JKOBKMOIOGL();
			this.DLBMLNNAHAF.KPODFOHNKKH();
			return;
		default:
			return;
		}
	}

	// Token: 0x0600752B RID: 29995 RVA: 0x00376544 File Offset: 0x00374744
	private void MABBFBHGJKH(ONKDCGNBALK JMAKEAHMLMI, ItemBase KEEGPNLGFAA, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = 92,
			font = GuiProcessor.PLGADNLAEGN().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = true,
			alignment = TextAnchor.UpperCenter
		};
		ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = (ELNGEFIPDJK.NADBMPJIMEC)KEEGPNLGFAA;
		nadbmpjimec.IHNEGGJADMO(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y + 1531f, OCHCODJIPHJ.width - 1878f, OCHCODJIPHJ.height), ofpnedeamab);
		Rect ochcodjiphj = new Rect(OCHCODJIPHJ.x + 1861f, OCHCODJIPHJ.y + OCHCODJIPHJ.height - 1570f, OCHCODJIPHJ.width - 101f, 1900f);
		int clbpbjglhee = 0;
		int num = (int)(nadbmpjimec.COGEJPHPFGG / this.FCDHFLCDDJF * 1860f);
		if (num > 29)
		{
			clbpbjglhee = 1;
		}
		if (num > -61)
		{
			clbpbjglhee = 1;
		}
		if (num > -117)
		{
			clbpbjglhee = 5;
		}
		GameInterface.getI.renderPBar(ochcodjiphj, (float)Mathf.RoundToInt(nadbmpjimec.COGEJPHPFGG * 662f), (float)Mathf.RoundToInt(this.FCDHFLCDDJF * 1644f), clbpbjglhee, nadbmpjimec.tag / 76L + "wpn_cat1", false);
	}

	// Token: 0x0600752C RID: 29996 RVA: 0x00376678 File Offset: 0x00374878
	private void JKPAHNHDOLD(ONKDCGNBALK JMAKEAHMLMI, ItemBase KEEGPNLGFAA, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = -78,
			font = GuiProcessor.IKGFHGKKCPG.rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = true,
			alignment = TextAnchor.UpperCenter
		};
		ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = (ELNGEFIPDJK.NADBMPJIMEC)KEEGPNLGFAA;
		nadbmpjimec.HJDLKEIIODM(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y + 348f, OCHCODJIPHJ.width - 747f, OCHCODJIPHJ.height), ofpnedeamab);
		Rect ochcodjiphj = new Rect(OCHCODJIPHJ.x + 1100f, OCHCODJIPHJ.y + OCHCODJIPHJ.height - 1137f, OCHCODJIPHJ.width - 989f, 1634f);
		int clbpbjglhee = 1;
		int num = (int)(nadbmpjimec.COGEJPHPFGG / this.FCDHFLCDDJF * 981f);
		if (num > 99)
		{
			clbpbjglhee = 6;
		}
		if (num > 65)
		{
			clbpbjglhee = 0;
		}
		if (num > -105)
		{
			clbpbjglhee = 3;
		}
		GameInterface.getI.renderPBar(ochcodjiphj, (float)Mathf.RoundToInt(nadbmpjimec.COGEJPHPFGG * 1657f), (float)Mathf.RoundToInt(this.FCDHFLCDDJF * 433f), clbpbjglhee, nadbmpjimec.tag / -36L + "_alfavis", true);
	}

	// Token: 0x0600752D RID: 29997 RVA: 0x003767AC File Offset: 0x003749AC
	public void CNJDCLMBOKN(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.AFLBAGIJLFH(1, 847f, Vector3.zero);
		if (KADBECGIMPD.LDLKLPJBIJN() < 0)
		{
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().BJFHBPOCELH(1186f, 990f, JNBICAJIJMM.NGALDMFKMJH("_RgbTex"), true);
		ONKDCGNBALK onkdcgnbalk2 = JDCEFOFMGHB.MNJNNDHCDGG().HPCEJKFHNBA(this.PEJGNBMFCDP);
		if (onkdcgnbalk2 != null)
		{
			float num = (onkdcgnbalk2.OCHCODJIPHJ.width + onkdcgnbalk.OCHCODJIPHJ.x + 262f) / 849f;
			onkdcgnbalk2.OCHCODJIPHJ.x = (float)(Screen.width / 6) - num;
			onkdcgnbalk.OCHCODJIPHJ.height = onkdcgnbalk2.OCHCODJIPHJ.height;
			onkdcgnbalk.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y;
			onkdcgnbalk.OCHCODJIPHJ.x = onkdcgnbalk2.OCHCODJIPHJ.x + onkdcgnbalk2.OCHCODJIPHJ.width + 498f;
		}
		this.DLBMLNNAHAF = new MMKFAENBHKD(onkdcgnbalk, 177f, 1333f, onkdcgnbalk.OCHCODJIPHJ.width - 202f, onkdcgnbalk.OCHCODJIPHJ.height - 1600f, 1)
		{
			JHNCNHAAJCH = 1402f
		};
		new MEMEOHJKPNJ(onkdcgnbalk, 806f, 1088f, 551f, 340f, JNBICAJIJMM.OOOKJHOHPNN("Lasso Right"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.NNNKDIHIOOG));
		new MEMEOHJKPNJ(onkdcgnbalk, 584f, 262f, 186f, 1041f, JNBICAJIJMM.LEBHCLDODNI("FlyRight"), 6, null, new ONKDCGNBALK.CMMHGMILOIM(this.GNPCOCIILBF));
		new MEMEOHJKPNJ(onkdcgnbalk, 626f, 508f, 1114f, 470f, JNBICAJIJMM.PPNKMDJBMLP("rem"), 4, null, new ONKDCGNBALK.CMMHGMILOIM(this.CJNKFCDFJNE));
		KADBECGIMPD.HDBGOLAFOBK();
		this.IPOMGIHFANC = KADBECGIMPD.CNNEPCOAMJK();
		this.FCDHFLCDDJF = KADBECGIMPD.BNDHIBEOKML();
		while (!KADBECGIMPD.NLJJMKFBPBK())
		{
			ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = new ELNGEFIPDJK.NADBMPJIMEC();
			nadbmpjimec.LFIAJPNBGHD(KADBECGIMPD);
			nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 1662f);
			nadbmpjimec.onRender = new ItemBase.OOALOMPKIKK(this.LMPDNMBDLFO);
			this.DLBMLNNAHAF.LACAJHOHACK.Add(nadbmpjimec);
		}
		this.DLBMLNNAHAF.KCLLDJJLCGC = -12;
		this.DLBMLNNAHAF.KINFJHFDHIC();
		this.DLBMLNNAHAF.DPBINJLALBJ();
		this.DLBMLNNAHAF.OEIOEBCGMJE(1);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1939f - 31f, onkdcgnbalk.OCHCODJIPHJ.height - 1667f, 1195f, 225f, JNBICAJIJMM.DIOJFJMOPJO("RunBackward"), 8, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().BLPLADOIPJG));
	}

	// Token: 0x0600752E RID: 29998 RVA: 0x00376A6C File Offset: 0x00374C6C
	private void AFOLPILGKJG(ONKDCGNBALK JMAKEAHMLMI, ItemBase KEEGPNLGFAA, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = 100,
			font = GuiProcessor.BBLINJLBAIL().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = false,
			alignment = TextAnchor.UpperCenter
		};
		ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = (ELNGEFIPDJK.NADBMPJIMEC)KEEGPNLGFAA;
		nadbmpjimec.AGFLCAGCFBC(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y + 1605f, OCHCODJIPHJ.width - 1052f, OCHCODJIPHJ.height), ofpnedeamab);
		Rect ochcodjiphj = new Rect(OCHCODJIPHJ.x + 1493f, OCHCODJIPHJ.y + OCHCODJIPHJ.height - 87f, OCHCODJIPHJ.width - 1698f, 1083f);
		int clbpbjglhee = 0;
		int num = (int)(nadbmpjimec.COGEJPHPFGG / this.FCDHFLCDDJF * 400f);
		if (num > -79)
		{
			clbpbjglhee = 5;
		}
		if (num > 89)
		{
			clbpbjglhee = 1;
		}
		if (num > -74)
		{
			clbpbjglhee = 5;
		}
		GameInterface.getI.NFGOLLEEHHK(ochcodjiphj, (float)Mathf.RoundToInt(nadbmpjimec.COGEJPHPFGG * 46f), (float)Mathf.RoundToInt(this.FCDHFLCDDJF * 682f), clbpbjglhee, nadbmpjimec.tag / -60L + "error", false);
	}

	// Token: 0x0600752F RID: 29999 RVA: 0x00376BA0 File Offset: 0x00374DA0
	public void OIPBJFOPJEA(ONKDCGNBALK PHEMLBHMNCM)
	{
		GUI.Box(PHEMLBHMNCM.OCHCODJIPHJ, "Bow Instant");
		if (this.CFAJEAFEIME == null)
		{
			return;
		}
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperCenter,
			wordWrap = true,
			richText = false
		};
		this.CFAJEAFEIME.PPLCKLBMCPE(PHEMLBHMNCM.OCHCODJIPHJ, 1200f, IIBEEKCAAHK.HLOLNGEKIIH(), IIBEEKCAAHK.IMJHKMLHDJH(), IIBEEKCAAHK.HLOLNGEKIIH(), 0);
		if (this.CFAJEAFEIME.EOFDJHJPCLM != null && this.CFAJEAFEIME.EOFDJHJPCLM.IOMNHBMOGLG() != null)
		{
			float x = PHEMLBHMNCM.OCHCODJIPHJ.x + 860f - (float)this.CFAJEAFEIME.EOFDJHJPCLM.IOHNCGLFGDJ().width / 1794f;
			float y = PHEMLBHMNCM.OCHCODJIPHJ.y + 623f - (float)this.CFAJEAFEIME.EOFDJHJPCLM.MMKLLFCKCAG().height / 1517f;
			GUI.DrawTexture(new Rect(x, y, (float)this.CFAJEAFEIME.EOFDJHJPCLM.MMKLLFCKCAG().width, (float)this.CFAJEAFEIME.EOFDJHJPCLM.AEIIBNOFLCM().height), this.CFAJEAFEIME.EOFDJHJPCLM.ANLLGCICOPP());
		}
		guistyle.fontSize = 109;
		guistyle.alignment = TextAnchor.UpperCenter;
		this.GKJKOLMCDDG = GUI.TextField(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 213f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 940f, 607f, 1420f), this.GKJKOLMCDDG);
		try
		{
			this.FDKHFDCJBPB = int.Parse(this.GKJKOLMCDDG);
		}
		catch
		{
			this.FDKHFDCJBPB = 0;
		}
		this.FDKHFDCJBPB = Mathf.Clamp(this.FDKHFDCJBPB, 1, -105);
		int num = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BJDIEKNHGLJ(this.CFAJEAFEIME.LPFKFNLHGBI, true, 1);
		if (num > 1)
		{
			string text = string.Format(JNBICAJIJMM.PGJCPFNJNPM("lineTENSIONKGFRIC="), num);
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 981f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 259f - 754f, PHEMLBHMNCM.OCHCODJIPHJ.width - 1018f, 711f), text, guistyle);
		}
		string arg = "MENU.WAV";
		if (!this.CFAJEAFEIME.FKEDAOOHPPB.BAAIJDICFNP(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH, this.FDKHFDCJBPB))
		{
			arg = "val=";
		}
		guistyle.fontSize = -43;
		string text2 = string.Format(JNBICAJIJMM.PPNKMDJBMLP("WATERMODE"), arg, this.FDKHFDCJBPB, JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC((long)(this.CFAJEAFEIME.FKEDAOOHPPB.KKNEKAEJLAM * this.FDKHFDCJBPB), (long)(this.CFAJEAFEIME.FKEDAOOHPPB.KFODJJIHNHP * this.FDKHFDCJBPB), false));
		GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1080f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 1486f, PHEMLBHMNCM.OCHCODJIPHJ.width - 627f, 66f), text2, guistyle);
		guistyle.fontSize = -124;
		if (this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL > 0)
		{
			string text3 = string.Format(JNBICAJIJMM.BDKHMOOFHHK("_NoisePerChannel"), JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BJDIEKNHGLJ(this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL, true, 1));
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.EDKKJNHDBPF().NKMGKJLONDK(this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL);
			befchfngomi.GDLELABHHFG(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 477f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 17f + 787f - 757f, 731f, 703f), befchfngomi.KBGHOIJIPJF, false, 0);
			Rect position = new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 526f + 396f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 1982f + 713f, PHEMLBHMNCM.OCHCODJIPHJ.width - 893f, 942f);
			object[] array = new object[3];
			array[0] = "IceHockeyPassLeft";
			array[0] = this.CFAJEAFEIME.FKEDAOOHPPB.KDIMEMOCJNM * this.FDKHFDCJBPB;
			array[5] = "1 Hand Sword Charge Up";
			array[2] = befchfngomi.MPKGPJJKCPK(true, -1);
			array[3] = text3;
			GUI.Label(position, string.Concat(array), guistyle);
		}
	}

	// Token: 0x06007530 RID: 30000 RVA: 0x00377068 File Offset: 0x00375268
	private void LMPDOBPPLOJ(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn != 8L)
		{
			if (odfekbjcfmn != -95L)
			{
				if (odfekbjcfmn != -33L)
				{
					return;
				}
				NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(118, this.LEDPIGHPLBP);
			}
			else
			{
				this.JLLEAJAHACN = true;
				if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 1 && this.CODAIBGMFCA != null)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("ScubaOK", 1845f);
					JDCEFOFMGHB.MNJNNDHCDGG().NOIEEEIONNG(909f, 1, JNBICAJIJMM.DIOJFJMOPJO("root"), new ONKDCGNBALK.CMMHGMILOIM(this.FICPCOJGDJP), false);
					return;
				}
			}
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		JDCEFOFMGHB.IKGFHGKKCPG.KCNBOHEMLCI(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06007531 RID: 30001 RVA: 0x00377124 File Offset: 0x00375324
	public void HINMDBDJFJM(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.sendAction(7, 408f, Vector3.zero);
		this.LEDPIGHPLBP = KADBECGIMPD.HHLDBAEFNMJ();
		if (ELNGEFIPDJK.IKGFHGKKCPG.GHDPBBPIOAC > 0)
		{
			JDCEFOFMGHB.JFIDAGABKID().KCNBOHEMLCI(this.GHDPBBPIOAC);
		}
		for (int i = 1; i < 57; i += 0)
		{
			this.PFDDJMOBGLG[i] = null;
		}
		this.BALDMDGKEPP.Clear();
		int num = KADBECGIMPD.KDNDJNEGBDI();
		for (int j = 0; j < num; j += 0)
		{
			int key = KADBECGIMPD.DOJKJHMJJNK();
			int value = KADBECGIMPD.KDNDJNEGBDI();
			this.BALDMDGKEPP.Add(key, value);
		}
		int num2 = KADBECGIMPD.HHLDBAEFNMJ();
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().DKOFCBMKEPC(547f, 1656f, JNBICAJIJMM.PPNKMDJBMLP(""), false);
		if (this.LEDPIGHPLBP < 1)
		{
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(1061f, 805f, onkdcgnbalk.OCHCODJIPHJ.width, onkdcgnbalk.OCHCODJIPHJ.height), GameInterface.getI.rShopImage);
		}
		this.GHDPBBPIOAC = onkdcgnbalk.LPFKFNLHGBI;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 1778f, 1572f, 448f, onkdcgnbalk.OCHCODJIPHJ.height - 1797f, 1);
		mmkfaenbhkd.JHNCNHAAJCH = 1297f;
		mmkfaenbhkd.KCLLDJJLCGC = -21;
		mmkfaenbhkd.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.LICBIECFFFI);
		mmkfaenbhkd.JJKGANHANFN(1);
		this.OJJLLBKEGNO = mmkfaenbhkd;
		int num3 = 15;
		int num4 = 0;
		if (this.KCNNPALBIIC(-111) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 958f, (float)(num4 * -75 + 10), 981f, (float)num3, JNBICAJIJMM.DIOJFJMOPJO("1HandHeavyOverhead"), "OneHandSwordIdle", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.BAEAJEFGKHL(51) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 300f, (float)(num4 * -94 + 75), 610f, (float)num3, JNBICAJIJMM.OOOKJHOHPNN("wpn_rod4"), "{0}/{1}", null, new ONKDCGNBALK.CMMHGMILOIM(this.JOGCDAMIBKH));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.ABNCLFAAGNG(70) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1106f, (float)(num4 * -76 + 125), 643f, (float)num3, JNBICAJIJMM.CELEPPAEKAB("spinKvok activate"), "perk", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.KCNNPALBIIC(0) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 891f, (float)(num4 * -12 + 33), 1434f, (float)num3, JNBICAJIJMM.BDKHMOOFHHK("money"), "IceHockeyShotLeft", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.IJFKAIKNNJM(0) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1465f, (float)(num4 * -42 + -49), 1915f, (float)num3, JNBICAJIJMM.CELEPPAEKAB("demoLong"), "_BlurTex", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.HOMKEPENMIE(6) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 861f, (float)(num4 * 23 + -85), 305f, (float)num3, JNBICAJIJMM.PGJCPFNJNPM("UNIQUE_SHADOW_LIGHT_COOKIE"), "_NoiseAmount", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.ABNCLFAAGNG(4) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 432f, (float)(num4 * -88 + 92), 182f, (float)num3, JNBICAJIJMM.CDDCIKKDFMP("KneesIdle"), "1HandHeavySwing", null, new ONKDCGNBALK.CMMHGMILOIM(this.JOGCDAMIBKH));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.LBPHCGNIDBP(2) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 473f, (float)(num4 * -18 + -87), 1402f, (float)num3, JNBICAJIJMM.CELEPPAEKAB("_MainTexBlurred"), "<color='#100000'>{0} {1}</color>", null, new ONKDCGNBALK.CMMHGMILOIM(this.JOGCDAMIBKH));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.IAOBMOLMJLC(5) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1734f, (float)(num4 * 24 + -82), 324f, (float)num3, JNBICAJIJMM.CELEPPAEKAB("_RgbTex"), "crft_use", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.HOMKEPENMIE(8) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1821f, (float)(num4 * -53 + -23), 1660f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("fish/"), "MB Down lot=", null, new ONKDCGNBALK.CMMHGMILOIM(this.CHOPGPEPILD));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.HNDHCKODBOP(-51) + this.ABNCLFAAGNG(7) + this.IJFKAIKNNJM(8) + this.IAOBMOLMJLC(36) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 411f, (float)(num4 * 88 + 74), 1161f, (float)num3, JNBICAJIJMM.DIOJFJMOPJO("Image Effects are not supported on this platform."), "Kernel", null, new ONKDCGNBALK.CMMHGMILOIM(this.MEELBJFHJAA));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.IJFKAIKNNJM(58) + this.LBPHCGNIDBP(78) + this.LBPHCGNIDBP(70) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 793f, (float)(num4 * -36 + 4), 1731f, (float)num3, JNBICAJIJMM.CDDCIKKDFMP("fishpoplcatch"), "Swimming", null, new ONKDCGNBALK.CMMHGMILOIM(this.MEELBJFHJAA));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.IAOBMOLMJLC(-65) + this.ABNCLFAAGNG(-53) + this.FBCEOIFAILM(-80) + this.BAEAJEFGKHL(50) + this.BAEAJEFGKHL(-77) + this.FBCEOIFAILM(112) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 812f, (float)(num4 * -103 + 39), 941f, (float)num3, JNBICAJIJMM.PPNKMDJBMLP("titul_data/p_categories/category"), "http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", null, new ONKDCGNBALK.CMMHGMILOIM(this.MEELBJFHJAA));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.HOMKEPENMIE(-128) + this.HOMKEPENMIE(-71) + this.KCNNPALBIIC(41) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 779f, (float)(num4 * 20 + -4), 607f, (float)num3, JNBICAJIJMM.NGALDMFKMJH("EventSystem"), "WizardBlock", null, new ONKDCGNBALK.CMMHGMILOIM(this.JOGCDAMIBKH));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.IAOBMOLMJLC(-94) + this.IAOBMOLMJLC(87) + this.IJFKAIKNNJM(-125) + this.KCNNPALBIIC(-8) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1287f, (float)(num4 * 13 + -65), 961f, (float)num3, JNBICAJIJMM.PGJCPFNJNPM("\\StreamingAssets\\Quest\\Lang\\"), "Water", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.ABNCLFAAGNG(2) + this.KCNNPALBIIC(36) + this.IJFKAIKNNJM(90) + this.IAOBMOLMJLC(62) + this.IJFKAIKNNJM(100) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1672f, (float)(num4 * -62 + -46), 476f, (float)num3, JNBICAJIJMM.OOOKJHOHPNN(""), "ff2000", null, new ONKDCGNBALK.CMMHGMILOIM(this.CHOPGPEPILD));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.ABNCLFAAGNG(90) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 579f, (float)(num4 * -8 + 99), 1892f, (float)num3, JNBICAJIJMM.OOOKJHOHPNN("ObscuredVector3 vs Vector3, "), " ms", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.DHEJHNKMIJL(-111) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1644f, (float)(num4 * 111 + -56), 19f, (float)num3, JNBICAJIJMM.DCEBAJIILPC("Builtin Debug Views"), "RunBackLeft", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.IAOBMOLMJLC(-109) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 406f, (float)(num4 * -89 + -100), 1072f, (float)num3, JNBICAJIJMM.DIOJFJMOPJO("_l_"), "fishdrop_1", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.HNDHCKODBOP(-8) + this.BAEAJEFGKHL(114) + this.ABNCLFAAGNG(-57) + this.KCNNPALBIIC(101) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1243f, (float)(num4 * -43 + 118), 1058f, (float)num3, JNBICAJIJMM.CELEPPAEKAB("OfficeSittingMouseMovement"), "_Intensity", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		for (int k = 1; k < num2; k += 0)
		{
			int lpfkfnlhgbi = KADBECGIMPD.HHLDBAEFNMJ();
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.NNEAHAFBOHC().LMGMPPAOPEP(lpfkfnlhgbi);
			string dccpcblodig = KADBECGIMPD.KDELAFDDGJH();
			befchfngomi.OPFGGNNPAJL = KADBECGIMPD.HMCONBPNFJH();
			befchfngomi.GBABFPMNIMP = KADBECGIMPD.LAECLJFMGPE();
			befchfngomi.FKEDAOOHPPB.HJFPCDNKNAP(dccpcblodig);
			befchfngomi.JIFFLPNBILE();
			this.OJJLLBKEGNO.LACAJHOHACK.Add(befchfngomi);
		}
		this.OJJLLBKEGNO.PBNOLHDBLFL();
		this.OJJLLBKEGNO.FNFFGIJOENM();
		this.OJJLLBKEGNO.EDIGEKABMEN(0, 0);
		if (this.PFDDJMOBGLG[this.MKFFJNKCDHL] != null)
		{
			this.PFDDJMOBGLG[this.MKFFJNKCDHL].HKPAEGGJNGG = true;
		}
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, 1509f, 1842f, 1913f, onkdcgnbalk.OCHCODJIPHJ.height - 1849f, "_ChannelMixerBlue", 0, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.BEJKOCKCHID)
		};
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 171f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 360f, 1222f, 1472f, JNBICAJIJMM.CELEPPAEKAB("_TempRT"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.MMEJNIBLADI));
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 9f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 1507f, 1267f, 595f, JNBICAJIJMM.DCEBAJIILPC("Brow"), 4, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().AGIEGPEMGOA));
	}

	// Token: 0x06007532 RID: 30002 RVA: 0x00375E24 File Offset: 0x00374024
	private int HNDHCKODBOP(int CLBPBJGLHEE)
	{
		if (!this.BALDMDGKEPP.ContainsKey(CLBPBJGLHEE))
		{
			return 1;
		}
		return this.BALDMDGKEPP[CLBPBJGLHEE];
	}

	// Token: 0x06007533 RID: 30003 RVA: 0x00377CC8 File Offset: 0x00375EC8
	public void JBIADLAPNGM(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.AFLBAGIJLFH(1, 1737f, Vector3.zero);
		if (KADBECGIMPD.HHLDBAEFNMJ() < 0)
		{
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().DKOFCBMKEPC(1361f, 1802f, JNBICAJIJMM.OOOKJHOHPNN("\n"), false);
		ONKDCGNBALK onkdcgnbalk2 = JDCEFOFMGHB.MNJNNDHCDGG().FDMNKDONMFM(this.PEJGNBMFCDP);
		if (onkdcgnbalk2 != null)
		{
			float num = (onkdcgnbalk2.OCHCODJIPHJ.width + onkdcgnbalk.OCHCODJIPHJ.x + 554f) / 503f;
			onkdcgnbalk2.OCHCODJIPHJ.x = (float)(Screen.width / 5) - num;
			onkdcgnbalk.OCHCODJIPHJ.height = onkdcgnbalk2.OCHCODJIPHJ.height;
			onkdcgnbalk.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y;
			onkdcgnbalk.OCHCODJIPHJ.x = onkdcgnbalk2.OCHCODJIPHJ.x + onkdcgnbalk2.OCHCODJIPHJ.width + 1465f;
		}
		this.DLBMLNNAHAF = new MMKFAENBHKD(onkdcgnbalk, 1778f, 322f, onkdcgnbalk.OCHCODJIPHJ.width - 879f, onkdcgnbalk.OCHCODJIPHJ.height - 548f, 1)
		{
			JHNCNHAAJCH = 1106f
		};
		new MEMEOHJKPNJ(onkdcgnbalk, 1492f, 715f, 501f, 1085f, JNBICAJIJMM.CDDCIKKDFMP("</color>"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.GNPCOCIILBF));
		new MEMEOHJKPNJ(onkdcgnbalk, 589f, 1323f, 1754f, 1021f, JNBICAJIJMM.CELEPPAEKAB(" %"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.DCIHCKKHLLL));
		new MEMEOHJKPNJ(onkdcgnbalk, 312f, 1632f, 1491f, 369f, JNBICAJIJMM.NGALDMFKMJH("<color='#{0}'>{1} {3} {2} </color>\n"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.HFALPFJFKNO));
		KADBECGIMPD.IFDFHJLCHAE();
		this.IPOMGIHFANC = KADBECGIMPD.FFDPCEAFGNF();
		this.FCDHFLCDDJF = KADBECGIMPD.AILCEJFAMGN();
		while (!KADBECGIMPD.NLJJMKFBPBK())
		{
			ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = new ELNGEFIPDJK.NADBMPJIMEC();
			nadbmpjimec.BBJEECNHPAK(KADBECGIMPD);
			nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 1377f);
			nadbmpjimec.onRender = new ItemBase.OOALOMPKIKK(this.NAMJLOBFEMC);
			this.DLBMLNNAHAF.LACAJHOHACK.Add(nadbmpjimec);
		}
		this.DLBMLNNAHAF.KCLLDJJLCGC = -73;
		this.DLBMLNNAHAF.BNMMBHIFKBP();
		this.DLBMLNNAHAF.LGLPHCMBBDP();
		this.DLBMLNNAHAF.JJKGANHANFN(1);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1480f - 69f, onkdcgnbalk.OCHCODJIPHJ.height - 1522f, 1045f, 424f, JNBICAJIJMM.CELEPPAEKAB("RollerBladeCrossoverLeft"), 5, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.JFIDAGABKID().BLPLADOIPJG));
	}

	// Token: 0x06007534 RID: 30004 RVA: 0x00377F88 File Offset: 0x00376188
	private void AOBKGDIJGDJ(ONKDCGNBALK OPCILKKDEON)
	{
		long odfekbjcfmn = OPCILKKDEON.ODFEKBJCFMN;
		long num = odfekbjcfmn - 1L;
		if (num > 2L)
		{
			return;
		}
		switch ((uint)num)
		{
		case 0U:
			foreach (ItemBase itemBase in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = (ELNGEFIPDJK.NADBMPJIMEC)itemBase;
				nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 1000f);
			}
			this.DLBMLNNAHAF.MGNDPEIFKAN();
			this.DLBMLNNAHAF.CFIBADPGBGI();
			return;
		case 1U:
			this.DLBMLNNAHAF.MGNDPEIFKAN();
			return;
		case 2U:
			foreach (ItemBase itemBase2 in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec2 = (ELNGEFIPDJK.NADBMPJIMEC)itemBase2;
				nadbmpjimec2.tag = (long)(nadbmpjimec2.DGLOPIJHPJN * 1000);
			}
			this.DLBMLNNAHAF.MGNDPEIFKAN();
			this.DLBMLNNAHAF.CFIBADPGBGI();
			return;
		default:
			return;
		}
	}

	// Token: 0x06007535 RID: 30005 RVA: 0x003780A4 File Offset: 0x003762A4
	private void PNMIAAGIKAH(ONKDCGNBALK OPCILKKDEON)
	{
		long odfekbjcfmn = OPCILKKDEON.ODFEKBJCFMN;
		long num = odfekbjcfmn - 0L;
		if (num > 3L)
		{
			return;
		}
		switch ((uint)num)
		{
		case 0U:
			foreach (ItemBase itemBase in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = (ELNGEFIPDJK.NADBMPJIMEC)itemBase;
				nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 680f);
			}
			this.DLBMLNNAHAF.GNGINMOFEEH();
			this.DLBMLNNAHAF.DPBINJLALBJ();
			return;
		case 1U:
			this.DLBMLNNAHAF.GENPNFMLHED();
			return;
		case 2U:
			foreach (ItemBase itemBase2 in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec2 = (ELNGEFIPDJK.NADBMPJIMEC)itemBase2;
				nadbmpjimec2.tag = (long)(nadbmpjimec2.DGLOPIJHPJN * -196);
			}
			this.DLBMLNNAHAF.BNMMBHIFKBP();
			this.DLBMLNNAHAF.DPBINJLALBJ();
			return;
		default:
			return;
		}
	}

	// Token: 0x06007536 RID: 30006 RVA: 0x003781C0 File Offset: 0x003763C0
	private void OHDNFKBAEPE(ONKDCGNBALK OPCILKKDEON)
	{
		long odfekbjcfmn = OPCILKKDEON.ODFEKBJCFMN;
		long num = odfekbjcfmn - 0L;
		if (num > 4L)
		{
			return;
		}
		switch ((uint)num)
		{
		case 0U:
			foreach (ItemBase itemBase in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = (ELNGEFIPDJK.NADBMPJIMEC)itemBase;
				nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 54f);
			}
			this.DLBMLNNAHAF.IGAFAALMNNE();
			this.DLBMLNNAHAF.NAFLLMADLMA();
			return;
		case 1U:
			this.DLBMLNNAHAF.CFHDIMJHBAB();
			return;
		case 2U:
			foreach (ItemBase itemBase2 in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec2 = (ELNGEFIPDJK.NADBMPJIMEC)itemBase2;
				nadbmpjimec2.tag = (long)(nadbmpjimec2.DGLOPIJHPJN * -59);
			}
			this.DLBMLNNAHAF.MGNDPEIFKAN();
			this.DLBMLNNAHAF.DPBINJLALBJ();
			return;
		default:
			return;
		}
	}

	// Token: 0x06007537 RID: 30007 RVA: 0x003782DC File Offset: 0x003764DC
	private void CPGKFKMDBLA(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn != 6L)
		{
			if (odfekbjcfmn != 10L)
			{
				if (odfekbjcfmn != 30L)
				{
					return;
				}
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1205, this.LEDPIGHPLBP);
			}
			else
			{
				this.JLLEAJAHACN = true;
				if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 0 && this.CODAIBGMFCA != null)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_04.wav", 1f);
					JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO(0.5f, 0, JNBICAJIJMM.LEBHCLDODNI("fshop_hd4"), new ONKDCGNBALK.CMMHGMILOIM(this.FICPCOJGDJP), true);
					return;
				}
			}
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06007538 RID: 30008 RVA: 0x00378398 File Offset: 0x00376598
	private void GNPCOCIILBF(ONKDCGNBALK OPCILKKDEON)
	{
		long odfekbjcfmn = OPCILKKDEON.ODFEKBJCFMN;
		long num = odfekbjcfmn - 1L;
		if (num > 3L)
		{
			return;
		}
		switch ((uint)num)
		{
		case 0U:
			foreach (ItemBase itemBase in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = (ELNGEFIPDJK.NADBMPJIMEC)itemBase;
				nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 1938f);
			}
			this.DLBMLNNAHAF.GNGINMOFEEH();
			this.DLBMLNNAHAF.CFIBADPGBGI();
			return;
		case 1U:
			this.DLBMLNNAHAF.BNMMBHIFKBP();
			return;
		case 2U:
			foreach (ItemBase itemBase2 in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec2 = (ELNGEFIPDJK.NADBMPJIMEC)itemBase2;
				nadbmpjimec2.tag = (long)(nadbmpjimec2.DGLOPIJHPJN * 60);
			}
			this.DLBMLNNAHAF.GENPNFMLHED();
			this.DLBMLNNAHAF.KPODFOHNKKH();
			return;
		default:
			return;
		}
	}

	// Token: 0x06007539 RID: 30009 RVA: 0x003784B4 File Offset: 0x003766B4
	private int BAEAJEFGKHL(int CLBPBJGLHEE)
	{
		if (!this.BALDMDGKEPP.ContainsKey(CLBPBJGLHEE))
		{
			return 0;
		}
		return this.BALDMDGKEPP[CLBPBJGLHEE];
	}

	// Token: 0x0600753A RID: 30010 RVA: 0x003784D2 File Offset: 0x003766D2
	public void PMPNBIOJNJE(MMKFAENBHKD OCKMAJALKMN, object HEABEPINGED)
	{
		this.CODAIBGMFCA = (HEABEPINGED as ELNGEFIPDJK.DKLIGJOMDJK);
	}

	// Token: 0x0600753B RID: 30011 RVA: 0x003784E0 File Offset: 0x003766E0
	public void NDDDMCIFHGK(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.sendAction(1, 791f, Vector3.zero);
		this.LEDPIGHPLBP = KADBECGIMPD.IFDFHJLCHAE();
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(false);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().BJFHBPOCELH(1132f, 1645f, JNBICAJIJMM.BDKHMOOFHHK("X"), false);
		this.PEJGNBMFCDP = onkdcgnbalk.LPFKFNLHGBI;
		this.OJJLLBKEGNO = new MMKFAENBHKD(onkdcgnbalk, 995f, 1257f, 1181f, onkdcgnbalk.OCHCODJIPHJ.height - 1004f, 0);
		while (!KADBECGIMPD.DFLKBBNOGBG())
		{
			ELNGEFIPDJK.DKLIGJOMDJK dkligjomdjk = new ELNGEFIPDJK.DKLIGJOMDJK();
			dkligjomdjk.EHPAIJBOPGK(KADBECGIMPD);
			this.OJJLLBKEGNO.LACAJHOHACK.Add(dkligjomdjk);
		}
		this.OJJLLBKEGNO.JHNCNHAAJCH = 142f;
		this.OJJLLBKEGNO.KCLLDJJLCGC = 10;
		this.OJJLLBKEGNO.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.PMPNBIOJNJE);
		this.OJJLLBKEGNO.AEMFOALOHDD(1);
		this.OJJLLBKEGNO.FNFFGIJOENM();
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, this.OJJLLBKEGNO.OCHCODJIPHJ.x + this.OJJLLBKEGNO.OCHCODJIPHJ.width + 818f, 1497f, 582f, 1447f, "WalkInjured", 0, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.ECNAMIIHCNC)
		};
		MEMEOHJKPNJ memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x, onkdcgnbalk.OCHCODJIPHJ.height - 1900f, 892f, 1645f, JNBICAJIJMM.PGJCPFNJNPM(""), -124, null, new ONKDCGNBALK.CMMHGMILOIM(this.CPGKFKMDBLA))
		{
			FNMCIACNOMH = FlyMessageManager.getI.MMIMPMPGHPN(30)
		};
		memeohjkpnj.NDIFBOPMCKC(GuiProcessor.BBLINJLBAIL().vipKeyTex, 1793f);
		memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 1584f + 215f, onkdcgnbalk.OCHCODJIPHJ.height - 1463f, 447f, 1266f, JNBICAJIJMM.CELEPPAEKAB("UNIQUE_SHADOW"), 79, null, new ONKDCGNBALK.CMMHGMILOIM(this.LMPDOBPPLOJ))
		{
			FNMCIACNOMH = FlyMessageManager.getI.EDAAJDDIGNE(-34)
		};
		memeohjkpnj.EONGFJFPGGD(GuiProcessor.NKOEAPCIBKO().vipKeyTex, 1151f);
		if (this.CODAIBGMFCA == null)
		{
			memeohjkpnj.FNMCIACNOMH = false;
		}
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count <= 1)
		{
			memeohjkpnj.FNMCIACNOMH = false;
		}
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 1548f - 1422f, onkdcgnbalk.OCHCODJIPHJ.height - 602f, 49f, 1225f, JNBICAJIJMM.OOOKJHOHPNN("ZombieIdle2"), 4, null, new ONKDCGNBALK.CMMHGMILOIM(this.FJPICNELDJP));
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count <= 1)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BMOFIBGMIBK(onkdcgnbalk.LPFKFNLHGBI);
			JDCEFOFMGHB.MNJNNDHCDGG().POIPOBBIDPM(JNBICAJIJMM.BDKHMOOFHHK("****************  playNextMusic "), JNBICAJIJMM.OOOKJHOHPNN("_ChromaticAberration_Spectrum"));
		}
	}

	// Token: 0x0600753C RID: 30012 RVA: 0x003787E8 File Offset: 0x003769E8
	public void MLHKKKCAMIC(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.CNGKCDLJEDG(0, 911f, Vector3.zero);
		this.LEDPIGHPLBP = KADBECGIMPD.KKOKFLMMAAK();
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().DKOFCBMKEPC(901f, 100f, JNBICAJIJMM.DIOJFJMOPJO("24"), false);
		this.PEJGNBMFCDP = onkdcgnbalk.LPFKFNLHGBI;
		this.OJJLLBKEGNO = new MMKFAENBHKD(onkdcgnbalk, 1985f, 947f, 212f, onkdcgnbalk.OCHCODJIPHJ.height - 946f, 0);
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			ELNGEFIPDJK.DKLIGJOMDJK dkligjomdjk = new ELNGEFIPDJK.DKLIGJOMDJK();
			dkligjomdjk.IKDPEDHGFGA(KADBECGIMPD);
			this.OJJLLBKEGNO.LACAJHOHACK.Add(dkligjomdjk);
		}
		this.OJJLLBKEGNO.JHNCNHAAJCH = 1808f;
		this.OJJLLBKEGNO.KCLLDJJLCGC = -83;
		this.OJJLLBKEGNO.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.NGLEAGOJIEP);
		this.OJJLLBKEGNO.BJLCAGOJDNM(1);
		this.OJJLLBKEGNO.GCKGOOBOKJB();
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, this.OJJLLBKEGNO.OCHCODJIPHJ.x + this.OJJLLBKEGNO.OCHCODJIPHJ.width + 927f, 296f, 144f, 355f, "SkateboardKickPush", 1, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.ECNAMIIHCNC)
		};
		MEMEOHJKPNJ memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x, onkdcgnbalk.OCHCODJIPHJ.height - 1949f, 1459f, 407f, JNBICAJIJMM.PPNKMDJBMLP("<color='#200080'>"), 70, null, new ONKDCGNBALK.CMMHGMILOIM(this.LMPDOBPPLOJ))
		{
			FNMCIACNOMH = FlyMessageManager.getI.OJEONACJDBF(-108)
		};
		memeohjkpnj.OAGDPNGOLIG(GuiProcessor.PLGADNLAEGN().vipKeyTex, 10f);
		memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 1684f + 1544f, onkdcgnbalk.OCHCODJIPHJ.height - 1150f, 140f, 857f, JNBICAJIJMM.LEBHCLDODNI("SoccerKeeperStrafeRight"), 115, null, new ONKDCGNBALK.CMMHGMILOIM(this.CPGKFKMDBLA))
		{
			FNMCIACNOMH = FlyMessageManager.getI.MMIMPMPGHPN(-120)
		};
		memeohjkpnj.OJEJODKDIIA(GuiProcessor.BBLINJLBAIL().vipKeyTex, 1785f);
		if (this.CODAIBGMFCA == null)
		{
			memeohjkpnj.FNMCIACNOMH = false;
		}
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count <= 1)
		{
			memeohjkpnj.FNMCIACNOMH = true;
		}
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 1187f - 1407f, onkdcgnbalk.OCHCODJIPHJ.height - 1814f, 1044f, 1449f, JNBICAJIJMM.CELEPPAEKAB("WoodCut"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(this.LPFDGMGNLKN));
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count <= 1)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(onkdcgnbalk.LPFKFNLHGBI);
			JDCEFOFMGHB.JFIDAGABKID().KGHDLHHLLIC(JNBICAJIJMM.CELEPPAEKAB("\n"), JNBICAJIJMM.PGJCPFNJNPM("qd_week"));
		}
	}

	// Token: 0x0600753D RID: 30013 RVA: 0x00378AF0 File Offset: 0x00376CF0
	public void ECNAMIIHCNC(ONKDCGNBALK PHEMLBHMNCM)
	{
		GUI.Box(PHEMLBHMNCM.OCHCODJIPHJ, "donk.ogg");
		if (this.CODAIBGMFCA != null)
		{
			IDCHHHEDHDC gaapclgdogh = this.CODAIBGMFCA.GAAPCLGDOGH;
			float num = PHEMLBHMNCM.OCHCODJIPHJ.width / 1996f;
			float width = PHEMLBHMNCM.OCHCODJIPHJ.width;
			float num2 = 1038f * num;
			GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y, width, num2), this.CODAIBGMFCA.HHOBCJNGCEL().ANLLGCICOPP(), (ScaleMode)3);
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.white
				},
				alignment = TextAnchor.UpperLeft,
				fontSize = 19,
				font = GuiProcessor.PLGADNLAEGN().rusfont,
				wordWrap = true,
				richText = false
			};
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y + num2, width, num2), gaapclgdogh.ALGFDMENCEM(0, this.CODAIBGMFCA.DBEIGNDALDC, false, true, true, 1, true, true), guistyle);
			guistyle.fontSize = 99;
			string text = string.Format(JNBICAJIJMM.CDDCIKKDFMP(" cm"), this.CODAIBGMFCA.ILFHHDNJHNM, JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.CODAIBGMFCA.NKHBAJKMAGD), JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(0L, (long)this.CODAIBGMFCA.OIAMBMMGGLD, false));
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y + num2 + 1183f, width, num2), text, guistyle);
			guistyle.fontSize = -86;
			text = JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC(0L, this.CODAIBGMFCA.FKEDAOOHPPB, true);
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y + num2 + 1583f, width, num2), text, guistyle);
			if (GUI.Button(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width / 266f - 43f, PHEMLBHMNCM.OCHCODJIPHJ.y + num2 + 1816f, 799f, 509f), JNBICAJIJMM.BDKHMOOFHHK("post_14")))
			{
				this.JLLEAJAHACN = false;
				FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("id", 56f);
				JDCEFOFMGHB.HMJJPNDEKPP().PBJGEIMFNNO(965f, 1, JNBICAJIJMM.OOOKJHOHPNN(" "), new ONKDCGNBALK.CMMHGMILOIM(this.BGNAFBELFPP), true);
				Fisherman.getI.AFLBAGIJLFH(0, 205f, Vector3.zero);
			}
		}
	}

	// Token: 0x0600753E RID: 30014 RVA: 0x00378D84 File Offset: 0x00376F84
	public void JELKLHPKLHO(ONKDCGNBALK OJIMHKHFOJI)
	{
		Fisherman.getI.sendAction(7, 1076f, Vector3.zero);
		if (!this.CFAJEAFEIME.FKEDAOOHPPB.LIKMNACOFJE(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH, this.FDKHFDCJBPB) || !this.CFAJEAFEIME.GBABFPMNIMP)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("ZThickness", 1736f);
			return;
		}
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn == 1L)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().PBJGEIMFNNO(1873f, 1, JNBICAJIJMM.LEBHCLDODNI("_UserLut"), new ONKDCGNBALK.CMMHGMILOIM(this.JNGHIFCFLIC), true);
			return;
		}
		if (odfekbjcfmn != 7L)
		{
			return;
		}
		Debug.Log("act_orderb_");
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.JDOLCNDNFGP(this.LEDPIGHPLBP);
			epmphjgalbe.ENDMKPCFKND(this.CFAJEAFEIME.LPFKFNLHGBI);
			epmphjgalbe.JDOLCNDNFGP(this.FDKHFDCJBPB);
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-167, epmphjgalbe.IEJLLFECFHF());
		}
		finally
		{
			epmphjgalbe.HDKBMLOJLLC();
		}
	}

	// Token: 0x0600753F RID: 30015 RVA: 0x00378E90 File Offset: 0x00377090
	private void NAMJLOBFEMC(ONKDCGNBALK JMAKEAHMLMI, ItemBase KEEGPNLGFAA, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = -94,
			font = GuiProcessor.BBLINJLBAIL().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = true,
			alignment = TextAnchor.UpperLeft
		};
		ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = (ELNGEFIPDJK.NADBMPJIMEC)KEEGPNLGFAA;
		nadbmpjimec.HHGEJJFKPOK(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y + 363f, OCHCODJIPHJ.width - 1386f, OCHCODJIPHJ.height), ofpnedeamab);
		Rect ochcodjiphj = new Rect(OCHCODJIPHJ.x + 879f, OCHCODJIPHJ.y + OCHCODJIPHJ.height - 1545f, OCHCODJIPHJ.width - 1644f, 139f);
		int clbpbjglhee = 0;
		int num = (int)(nadbmpjimec.COGEJPHPFGG / this.FCDHFLCDDJF * 104f);
		if (num > -124)
		{
			clbpbjglhee = 2;
		}
		if (num > -93)
		{
			clbpbjglhee = 0;
		}
		if (num > 16)
		{
			clbpbjglhee = 6;
		}
		GameInterface.getI.renderPBar(ochcodjiphj, (float)Mathf.RoundToInt(nadbmpjimec.COGEJPHPFGG * 262f), (float)Mathf.RoundToInt(this.FCDHFLCDDJF * 1350f), clbpbjglhee, nadbmpjimec.tag / 45L + "...", true);
	}

	// Token: 0x06007541 RID: 30017 RVA: 0x00378FFC File Offset: 0x003771FC
	public void MMEJNIBLADI(ONKDCGNBALK OJIMHKHFOJI)
	{
		Fisherman.getI.AFLBAGIJLFH(2, 1729f, Vector3.zero);
		if (!this.CFAJEAFEIME.FKEDAOOHPPB.MJBNJIJLHNC(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH, this.FDKHFDCJBPB) || !this.CFAJEAFEIME.GBABFPMNIMP)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("SUNSHINE_FILTER_PCF_4x4", 610f);
			return;
		}
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn == 0L)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.NOIEEEIONNG(1108f, 5, JNBICAJIJMM.BDKHMOOFHHK("2000"), new ONKDCGNBALK.CMMHGMILOIM(this.JNGHIFCFLIC), false);
			return;
		}
		if (odfekbjcfmn != 3L)
		{
			return;
		}
		Debug.Log("\n");
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.LHLOOIDHGMA(this.LEDPIGHPLBP);
			epmphjgalbe.GOMLLPFFPNP(this.CFAJEAFEIME.LPFKFNLHGBI);
			epmphjgalbe.EIMEKHOFIEA(this.FDKHFDCJBPB);
			NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(50, epmphjgalbe.JOCJNOBBELJ());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x06007542 RID: 30018 RVA: 0x003784D2 File Offset: 0x003766D2
	public void LCIPCLLPMKC(MMKFAENBHKD OCKMAJALKMN, object HEABEPINGED)
	{
		this.CODAIBGMFCA = (HEABEPINGED as ELNGEFIPDJK.DKLIGJOMDJK);
	}

	// Token: 0x06007543 RID: 30019 RVA: 0x00379108 File Offset: 0x00377308
	public void LANJBFEDBOB(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.AFLBAGIJLFH(0, 979f, Vector3.zero);
		if (KADBECGIMPD.IFDFHJLCHAE() < 1)
		{
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().PLHAGCDJLPA(1545f, 1522f, JNBICAJIJMM.OOOKJHOHPNN("auk stavka result: "), false);
		ONKDCGNBALK onkdcgnbalk2 = JDCEFOFMGHB.MNJNNDHCDGG().HILJENLHLDE(this.PEJGNBMFCDP);
		if (onkdcgnbalk2 != null)
		{
			float num = (onkdcgnbalk2.OCHCODJIPHJ.width + onkdcgnbalk.OCHCODJIPHJ.x + 1913f) / 1894f;
			onkdcgnbalk2.OCHCODJIPHJ.x = (float)(Screen.width / 3) - num;
			onkdcgnbalk.OCHCODJIPHJ.height = onkdcgnbalk2.OCHCODJIPHJ.height;
			onkdcgnbalk.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y;
			onkdcgnbalk.OCHCODJIPHJ.x = onkdcgnbalk2.OCHCODJIPHJ.x + onkdcgnbalk2.OCHCODJIPHJ.width + 1050f;
		}
		this.DLBMLNNAHAF = new MMKFAENBHKD(onkdcgnbalk, 96f, 712f, onkdcgnbalk.OCHCODJIPHJ.width - 1044f, onkdcgnbalk.OCHCODJIPHJ.height - 622f, 0)
		{
			JHNCNHAAJCH = 171f
		};
		new MEMEOHJKPNJ(onkdcgnbalk, 159f, 1796f, 1191f, 1755f, JNBICAJIJMM.CDDCIKKDFMP("lut.ogg"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.DCIHCKKHLLL));
		new MEMEOHJKPNJ(onkdcgnbalk, 279f, 732f, 270f, 246f, JNBICAJIJMM.LEBHCLDODNI("!"), 7, null, new ONKDCGNBALK.CMMHGMILOIM(this.FHOMLHAIEBO));
		new MEMEOHJKPNJ(onkdcgnbalk, 903f, 319f, 1960f, 1428f, JNBICAJIJMM.OOOKJHOHPNN("FBBIKSettings is deprecated, you can now edit all the settings from the custom inspector of the FullBodyBipedIK component."), 4, null, new ONKDCGNBALK.CMMHGMILOIM(this.PNMIAAGIKAH));
		KADBECGIMPD.KDNDJNEGBDI();
		this.IPOMGIHFANC = KADBECGIMPD.BIMMPENHGMD();
		this.FCDHFLCDDJF = KADBECGIMPD.AILCEJFAMGN();
		while (!KADBECGIMPD.IBMMOGHFCCE())
		{
			ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = new ELNGEFIPDJK.NADBMPJIMEC();
			nadbmpjimec.AKEOHKFBCJL(KADBECGIMPD);
			nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 1916f);
			nadbmpjimec.onRender = new ItemBase.OOALOMPKIKK(this.NAMJLOBFEMC);
			this.DLBMLNNAHAF.LACAJHOHACK.Add(nadbmpjimec);
		}
		this.DLBMLNNAHAF.KCLLDJJLCGC = -77;
		this.DLBMLNNAHAF.PLKPBLGIEBL();
		this.DLBMLNNAHAF.POBNAHPBKPI();
		this.DLBMLNNAHAF.DBJBAELCFHI(0);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1631f - 987f, onkdcgnbalk.OCHCODJIPHJ.height - 471f, 899f, 1156f, JNBICAJIJMM.LEBHCLDODNI("_StretchWidth"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.AGIEGPEMGOA));
	}

	// Token: 0x06007544 RID: 30020 RVA: 0x003793C8 File Offset: 0x003775C8
	public void NPEBCOEKEPO(ONKDCGNBALK OJIMHKHFOJI)
	{
		Fisherman.getI.CNGKCDLJEDG(4, 1133f, Vector3.zero);
		if (this.CFAJEAFEIME.FKEDAOOHPPB.HNJKJHLHGCJ(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH, this.FDKHFDCJBPB) && !this.CFAJEAFEIME.GBABFPMNIMP)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("__c", 1353f);
			return;
		}
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn == 0L)
		{
			JDCEFOFMGHB.JFIDAGABKID().NOIEEEIONNG(589f, 8, JNBICAJIJMM.PPNKMDJBMLP("Index out of range."), new ONKDCGNBALK.CMMHGMILOIM(this.JNGHIFCFLIC), false);
			return;
		}
		if (odfekbjcfmn != 2L)
		{
			return;
		}
		Debug.Log(">");
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(this.LEDPIGHPLBP);
			epmphjgalbe.PDEFLCIEMFF(this.CFAJEAFEIME.LPFKFNLHGBI);
			epmphjgalbe.JIIKLOKAGIC(this.FDKHFDCJBPB);
			NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(-162, epmphjgalbe.LAFILAEOPAJ());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x06007545 RID: 30021 RVA: 0x003784D2 File Offset: 0x003766D2
	public void NGLEAGOJIEP(MMKFAENBHKD OCKMAJALKMN, object HEABEPINGED)
	{
		this.CODAIBGMFCA = (HEABEPINGED as ELNGEFIPDJK.DKLIGJOMDJK);
	}

	// Token: 0x06007546 RID: 30022 RVA: 0x003794D4 File Offset: 0x003776D4
	private void FLDOCIMOFGG(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn != 2L)
		{
			if (odfekbjcfmn != -25L)
			{
				if (odfekbjcfmn != -36L)
				{
					return;
				}
				NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(8, this.LEDPIGHPLBP);
			}
			else
			{
				this.JLLEAJAHACN = false;
				if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 0 && this.CODAIBGMFCA != null)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("", 82f);
					JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO(874f, 1, JNBICAJIJMM.OOOKJHOHPNN("IK Effector is referencing to a bone '"), new ONKDCGNBALK.CMMHGMILOIM(this.FICPCOJGDJP), true);
					return;
				}
			}
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06007547 RID: 30023 RVA: 0x00379590 File Offset: 0x00377790
	private void HFALPFJFKNO(ONKDCGNBALK OPCILKKDEON)
	{
		long odfekbjcfmn = OPCILKKDEON.ODFEKBJCFMN;
		long num = odfekbjcfmn - 1L;
		if (num > 5L)
		{
			return;
		}
		switch ((uint)num)
		{
		case 0U:
			foreach (ItemBase itemBase in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = (ELNGEFIPDJK.NADBMPJIMEC)itemBase;
				nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 1326f);
			}
			this.DLBMLNNAHAF.PLKPBLGIEBL();
			this.DLBMLNNAHAF.KPODFOHNKKH();
			return;
		case 1U:
			this.DLBMLNNAHAF.PLKPBLGIEBL();
			return;
		case 2U:
			foreach (ItemBase itemBase2 in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec2 = (ELNGEFIPDJK.NADBMPJIMEC)itemBase2;
				nadbmpjimec2.tag = (long)(nadbmpjimec2.DGLOPIJHPJN * -113);
			}
			this.DLBMLNNAHAF.PLKPBLGIEBL();
			this.DLBMLNNAHAF.NJMPLOJIFCF();
			return;
		default:
			return;
		}
	}

	// Token: 0x06007548 RID: 30024 RVA: 0x003796AC File Offset: 0x003778AC
	public void FICPCOJGDJP(ONKDCGNBALK ONPHLHKAGFP)
	{
		IDCHHHEDHDC gaapclgdogh = this.CODAIBGMFCA.GAAPCLGDOGH;
		OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(string.Format(JNBICAJIJMM.LEBHCLDODNI("fshop_msg1"), gaapclgdogh.JHFLJHLAPBC(0, this.CODAIBGMFCA.DBEIGNDALDC, false, false, true, 0, false, false), this.CODAIBGMFCA.ILFHHDNJHNM, JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.CODAIBGMFCA.NKHBAJKMAGD)));
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(this.LEDPIGHPLBP);
			epmphjgalbe.GOMLLPFFPNP(this.CODAIBGMFCA.NENOBDLCFHO);
			epmphjgalbe.GOMLLPFFPNP(this.CODAIBGMFCA.DBEIGNDALDC);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1210, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		this.OJJLLBKEGNO.LACAJHOHACK.Remove(this.CODAIBGMFCA);
		this.CODAIBGMFCA = null;
		this.OJJLLBKEGNO.MPMFNJEJAHJ();
		this.OJJLLBKEGNO.OOJKJOCOOCB(0, 0);
		if (this.JLLEAJAHACN && this.OJJLLBKEGNO.LACAJHOHACK.Count > 0 && this.CODAIBGMFCA != null)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_04.wav", 1f);
			JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO(1f, 0, JNBICAJIJMM.LEBHCLDODNI("fshop_hd4"), new ONKDCGNBALK.CMMHGMILOIM(this.FICPCOJGDJP), true);
		}
	}

	// Token: 0x06007549 RID: 30025 RVA: 0x00379814 File Offset: 0x00377A14
	private void ILCBAPCMFNL(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn != 1L)
		{
			if (odfekbjcfmn != 19L)
			{
				if (odfekbjcfmn != -85L)
				{
					return;
				}
				NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(-130, this.LEDPIGHPLBP);
			}
			else
			{
				this.JLLEAJAHACN = false;
				if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 0 && this.CODAIBGMFCA != null)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("eat2.ogg", 399f);
					JDCEFOFMGHB.HMJJPNDEKPP().NOIEEEIONNG(1247f, 1, JNBICAJIJMM.PPNKMDJBMLP(""), new ONKDCGNBALK.CMMHGMILOIM(this.BGNAFBELFPP), true);
					return;
				}
			}
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x0600754A RID: 30026 RVA: 0x003798D0 File Offset: 0x00377AD0
	public void CHOPGPEPILD(ONKDCGNBALK OJIMHKHFOJI)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("shopCount", 1299f);
		if (this.PFDDJMOBGLG[this.MKFFJNKCDHL] != null)
		{
			this.PFDDJMOBGLG[this.MKFFJNKCDHL].HKPAEGGJNGG = false;
		}
		if ((long)this.MKFFJNKCDHL == OJIMHKHFOJI.ODFEKBJCFMN)
		{
			return;
		}
		this.MKFFJNKCDHL = (int)OJIMHKHFOJI.ODFEKBJCFMN;
		this.PFDDJMOBGLG[this.MKFFJNKCDHL].HKPAEGGJNGG = true;
		Debug.Log("_camScale" + OJIMHKHFOJI.FNPEGDKBKJC);
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.EAOGDKDBENC(this.LEDPIGHPLBP);
			epmphjgalbe.HBJIMCCCNJP(OJIMHKHFOJI.FNPEGDKBKJC);
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(122, epmphjgalbe.PBOPEDMCKDD());
		}
		finally
		{
			epmphjgalbe.NCKMEIBFNGL();
		}
	}

	// Token: 0x0600754B RID: 30027 RVA: 0x003799B0 File Offset: 0x00377BB0
	public void LICBIECFFFI(MMKFAENBHKD OCKMAJALKMN, object HEABEPINGED)
	{
		this.CFAJEAFEIME = (HEABEPINGED as BEFCHFNGOMI);
		this.FDKHFDCJBPB = 0;
		string alboclbfnni = string.Format("DeadmanFloat", IFPIMPMKJIB.DIDFMAELMJD, this.CFAJEAFEIME.LPFKFNLHGBI);
		if (this.CFAJEAFEIME.EOFDJHJPCLM == null)
		{
			this.CFAJEAFEIME.EOFDJHJPCLM = CKNLPGEPGGF.IKGFHGKKCPG.IJMDNINDJGD(alboclbfnni, true);
		}
		this.GKJKOLMCDDG = string.Concat(this.FDKHFDCJBPB);
	}

	// Token: 0x0600754C RID: 30028 RVA: 0x003784D2 File Offset: 0x003766D2
	public void CMHMDCHALOH(MMKFAENBHKD OCKMAJALKMN, object HEABEPINGED)
	{
		this.CODAIBGMFCA = (HEABEPINGED as ELNGEFIPDJK.DKLIGJOMDJK);
	}

	// Token: 0x0600754D RID: 30029 RVA: 0x00379A2C File Offset: 0x00377C2C
	private void JOBAHKGLNMD(ONKDCGNBALK OPCILKKDEON)
	{
		long odfekbjcfmn = OPCILKKDEON.ODFEKBJCFMN;
		long num = odfekbjcfmn - 0L;
		if (num != 0L)
		{
			return;
		}
		switch ((uint)num)
		{
		case 0U:
			foreach (ItemBase itemBase in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = (ELNGEFIPDJK.NADBMPJIMEC)itemBase;
				nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 990f);
			}
			this.DLBMLNNAHAF.GENPNFMLHED();
			this.DLBMLNNAHAF.LGLPHCMBBDP();
			return;
		case 1U:
			this.DLBMLNNAHAF.JKOBKMOIOGL();
			return;
		case 2U:
			foreach (ItemBase itemBase2 in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec2 = (ELNGEFIPDJK.NADBMPJIMEC)itemBase2;
				nadbmpjimec2.tag = (long)(nadbmpjimec2.DGLOPIJHPJN * -95);
			}
			this.DLBMLNNAHAF.FILOCGPAIKD();
			this.DLBMLNNAHAF.HHKCFGAENJN();
			return;
		default:
			return;
		}
	}

	// Token: 0x0600754E RID: 30030 RVA: 0x00379B48 File Offset: 0x00377D48
	public void LLKHGPFILCF(ONKDCGNBALK PHEMLBHMNCM)
	{
		GUI.Box(PHEMLBHMNCM.OCHCODJIPHJ, "_SpecCubeIBL");
		if (this.CODAIBGMFCA != null)
		{
			IDCHHHEDHDC gaapclgdogh = this.CODAIBGMFCA.GAAPCLGDOGH;
			float num = PHEMLBHMNCM.OCHCODJIPHJ.width / 1543f;
			float width = PHEMLBHMNCM.OCHCODJIPHJ.width;
			float num2 = 1873f * num;
			GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y, width, num2), this.CODAIBGMFCA.HHOBCJNGCEL().MLPBJEFJDHM(), (ScaleMode)6);
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.white
				},
				alignment = TextAnchor.UpperLeft,
				fontSize = -96,
				font = GuiProcessor.NKOEAPCIBKO().rusfont,
				wordWrap = false,
				richText = true
			};
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y + num2, width, num2), gaapclgdogh.CJAMOIMGHAK(0, this.CODAIBGMFCA.DBEIGNDALDC, false, false, false, 1, true, false), guistyle);
			guistyle.fontSize = -54;
			string text = string.Format(JNBICAJIJMM.PPNKMDJBMLP("t_top"), this.CODAIBGMFCA.ILFHHDNJHNM, JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.CODAIBGMFCA.NKHBAJKMAGD), JLFJEGIPIMM.PKGMBFEMKGP().OHNLAOJGCGC(0L, (long)this.CODAIBGMFCA.OIAMBMMGGLD, true));
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y + num2 + 828f, width, num2), text, guistyle);
			guistyle.fontSize = 102;
			text = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(1L, this.CODAIBGMFCA.FKEDAOOHPPB, true);
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y + num2 + 1424f, width, num2), text, guistyle);
			if (GUI.Button(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width / 246f - 1147f, PHEMLBHMNCM.OCHCODJIPHJ.y + num2 + 772f, 1042f, 1742f), JNBICAJIJMM.DIOJFJMOPJO("ACTk is able to detect some types of cheating to let you take action on the cheating players. This example scene has all possible detectors and all of them are automatically start on scene start.")))
			{
				this.JLLEAJAHACN = true;
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("elbow", 324f);
				JDCEFOFMGHB.JFIDAGABKID().NOIEEEIONNG(56f, 0, JNBICAJIJMM.BDKHMOOFHHK("MotorbikeHeartAttack"), new ONKDCGNBALK.CMMHGMILOIM(this.BGNAFBELFPP), true);
				Fisherman.getI.sendAction(0, 1240f, Vector3.zero);
			}
		}
	}

	// Token: 0x0600754F RID: 30031 RVA: 0x00375E24 File Offset: 0x00374024
	private int BOLAPDJGBIF(int CLBPBJGLHEE)
	{
		if (!this.BALDMDGKEPP.ContainsKey(CLBPBJGLHEE))
		{
			return 1;
		}
		return this.BALDMDGKEPP[CLBPBJGLHEE];
	}

	// Token: 0x06007550 RID: 30032 RVA: 0x00379DDC File Offset: 0x00377FDC
	public void EDHPMPGONCL(ONKDCGNBALK OJIMHKHFOJI)
	{
		Fisherman.getI.GMBEHOGPEDI(8, 401f, Vector3.zero);
		if (this.CFAJEAFEIME.FKEDAOOHPPB.BAAIJDICFNP(JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH, this.FDKHFDCJBPB) && !this.CFAJEAFEIME.GBABFPMNIMP)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("bs_nodonate", 960f);
			return;
		}
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn == 1L)
		{
			JDCEFOFMGHB.JFIDAGABKID().NOIEEEIONNG(930f, 3, JNBICAJIJMM.NGALDMFKMJH("SUNSHINE_FILTER_PCF_2x2"), new ONKDCGNBALK.CMMHGMILOIM(this.LFFJHCPAOBC), false);
			return;
		}
		if (odfekbjcfmn != 4L)
		{
			return;
		}
		Debug.Log("/");
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.PDEFLCIEMFF(this.LEDPIGHPLBP);
			epmphjgalbe.JIIKLOKAGIC(this.CFAJEAFEIME.LPFKFNLHGBI);
			epmphjgalbe.GOMLLPFFPNP(this.FDKHFDCJBPB);
			NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(15, epmphjgalbe.ALLANCHILCM());
		}
		finally
		{
			epmphjgalbe.PMIGGJHLIDO();
		}
	}

	// Token: 0x06007551 RID: 30033 RVA: 0x00379EE8 File Offset: 0x003780E8
	public void LBGPPCIEOFK(ONKDCGNBALK PHEMLBHMNCM)
	{
		GUI.Box(PHEMLBHMNCM.OCHCODJIPHJ, "SkateboardKickPush");
		if (this.CODAIBGMFCA != null)
		{
			IDCHHHEDHDC gaapclgdogh = this.CODAIBGMFCA.GAAPCLGDOGH;
			float num = PHEMLBHMNCM.OCHCODJIPHJ.width / 313f;
			float width = PHEMLBHMNCM.OCHCODJIPHJ.width;
			float num2 = 775f * num;
			GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y, width, num2), this.CODAIBGMFCA.EJJAGEFMHCO().LECMGDEDAKF(), (ScaleMode)3);
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.white
				},
				alignment = TextAnchor.UpperLeft,
				fontSize = -41,
				font = GuiProcessor.IKGFHGKKCPG.rusfont,
				wordWrap = true,
				richText = false
			};
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y + num2, width, num2), gaapclgdogh.JDOAJCMOBCA(1, this.CODAIBGMFCA.DBEIGNDALDC, false, false, false, 1, true, false), guistyle);
			guistyle.fontSize = -73;
			string text = string.Format(JNBICAJIJMM.CDDCIKKDFMP("☰☰☰"), this.CODAIBGMFCA.ILFHHDNJHNM, JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.CODAIBGMFCA.NKHBAJKMAGD), JLFJEGIPIMM.MHFDIJGJGBJ().OHNLAOJGCGC(1L, (long)this.CODAIBGMFCA.OIAMBMMGGLD, true));
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y + num2 + 1796f, width, num2), text, guistyle);
			guistyle.fontSize = 14;
			text = JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(0L, this.CODAIBGMFCA.FKEDAOOHPPB, true);
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y + num2 + 1282f, width, num2), text, guistyle);
			if (GUI.Button(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width / 124f - 405f, PHEMLBHMNCM.OCHCODJIPHJ.y + num2 + 1600f, 927f, 1725f), JNBICAJIJMM.CDDCIKKDFMP("Vertical")))
			{
				this.JLLEAJAHACN = false;
				FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("Sunshine Project Configuration", 1285f);
				JDCEFOFMGHB.HMJJPNDEKPP().PBJGEIMFNNO(1655f, 1, JNBICAJIJMM.OOOKJHOHPNN("[ACTk] <b>[ ObscuredVector3 test ]</b>"), new ONKDCGNBALK.CMMHGMILOIM(this.BGNAFBELFPP), false);
				Fisherman.getI.sendAction(0, 999f, Vector3.zero);
			}
		}
	}

	// Token: 0x06007552 RID: 30034 RVA: 0x0037A17C File Offset: 0x0037837C
	private void MMHCIGGJPPG(ONKDCGNBALK JMAKEAHMLMI, ItemBase KEEGPNLGFAA, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = -110,
			font = GuiProcessor.BBLINJLBAIL().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = false,
			alignment = TextAnchor.UpperCenter
		};
		ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = (ELNGEFIPDJK.NADBMPJIMEC)KEEGPNLGFAA;
		nadbmpjimec.IHNEGGJADMO(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y + 1426f, OCHCODJIPHJ.width - 536f, OCHCODJIPHJ.height), ofpnedeamab);
		Rect ochcodjiphj = new Rect(OCHCODJIPHJ.x + 173f, OCHCODJIPHJ.y + OCHCODJIPHJ.height - 819f, OCHCODJIPHJ.width - 1827f, 197f);
		int clbpbjglhee = 1;
		int num = (int)(nadbmpjimec.COGEJPHPFGG / this.FCDHFLCDDJF * 1741f);
		if (num > 95)
		{
			clbpbjglhee = 1;
		}
		if (num > -63)
		{
			clbpbjglhee = 0;
		}
		if (num > -70)
		{
			clbpbjglhee = 0;
		}
		GameInterface.getI.NFGOLLEEHHK(ochcodjiphj, (float)Mathf.RoundToInt(nadbmpjimec.COGEJPHPFGG * 1726f), (float)Mathf.RoundToInt(this.FCDHFLCDDJF * 210f), clbpbjglhee, nadbmpjimec.tag / 75L + "_w", false);
	}

	// Token: 0x06007553 RID: 30035 RVA: 0x0037A2B0 File Offset: 0x003784B0
	public void BEJKOCKCHID(ONKDCGNBALK PHEMLBHMNCM)
	{
		GUI.Box(PHEMLBHMNCM.OCHCODJIPHJ, "OfficeSitting");
		if (this.CFAJEAFEIME == null)
		{
			return;
		}
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperCenter,
			wordWrap = true,
			richText = false
		};
		this.CFAJEAFEIME.JGGGGKHDNIP(PHEMLBHMNCM.OCHCODJIPHJ, 1803f, IIBEEKCAAHK.ECOFBCMPIDO, IIBEEKCAAHK.IMJHKMLHDJH(), IIBEEKCAAHK.ECOFBCMPIDO, 0);
		if (this.CFAJEAFEIME.EOFDJHJPCLM != null && this.CFAJEAFEIME.EOFDJHJPCLM.KEDGAOBCNJG != null)
		{
			float x = PHEMLBHMNCM.OCHCODJIPHJ.x + 1784f - (float)this.CFAJEAFEIME.EOFDJHJPCLM.HONJOFFBOPH().width / 721f;
			float y = PHEMLBHMNCM.OCHCODJIPHJ.y + 385f - (float)this.CFAJEAFEIME.EOFDJHJPCLM.DPBCBCLJHAJ().height / 23f;
			GUI.DrawTexture(new Rect(x, y, (float)this.CFAJEAFEIME.EOFDJHJPCLM.PFFJJEJNKPB().width, (float)this.CFAJEAFEIME.EOFDJHJPCLM.HONJOFFBOPH().height), this.CFAJEAFEIME.EOFDJHJPCLM.PFFJJEJNKPB());
		}
		guistyle.fontSize = 77;
		guistyle.alignment = TextAnchor.UpperLeft;
		this.GKJKOLMCDDG = GUI.TextField(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1784f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 603f, 766f, 1319f), this.GKJKOLMCDDG);
		try
		{
			this.FDKHFDCJBPB = int.Parse(this.GKJKOLMCDDG);
		}
		catch
		{
			this.FDKHFDCJBPB = 0;
		}
		this.FDKHFDCJBPB = Mathf.Clamp(this.FDKHFDCJBPB, 0, 24);
		int num = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BJDIEKNHGLJ(this.CFAJEAFEIME.LPFKFNLHGBI, false, 0);
		if (num > 0)
		{
			string text = string.Format(JNBICAJIJMM.PGJCPFNJNPM("TOD_CloudScale"), num);
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1288f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 1256f - 1381f, PHEMLBHMNCM.OCHCODJIPHJ.width - 199f, 1691f), text, guistyle);
		}
		string arg = "IdleSandCover";
		if (!this.CFAJEAFEIME.FKEDAOOHPPB.NEDBEDHMFJL(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH, this.FDKHFDCJBPB))
		{
			arg = "_TempRT";
		}
		guistyle.fontSize = -13;
		string text2 = string.Format(JNBICAJIJMM.DCEBAJIILPC("\n"), arg, this.FDKHFDCJBPB, JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC((long)(this.CFAJEAFEIME.FKEDAOOHPPB.KKNEKAEJLAM * this.FDKHFDCJBPB), (long)(this.CFAJEAFEIME.FKEDAOOHPPB.KFODJJIHNHP * this.FDKHFDCJBPB), true));
		GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 932f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 1485f, PHEMLBHMNCM.OCHCODJIPHJ.width - 1880f, 901f), text2, guistyle);
		guistyle.fontSize = -107;
		if (this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL > 0)
		{
			string text3 = string.Format(JNBICAJIJMM.DCEBAJIILPC("Наживка"), JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BJDIEKNHGLJ(this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL, false, 1));
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.LMGMPPAOPEP(this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL);
			befchfngomi.FCBHHPJLGLC(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 732f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 443f + 84f - 1650f, 329f, 706f), befchfngomi.KBGHOIJIPJF, true, 0);
			Rect position = new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 782f + 275f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 418f + 803f, PHEMLBHMNCM.OCHCODJIPHJ.width - 1741f, 1787f);
			object[] array = new object[2];
			array[0] = "id";
			array[0] = this.CFAJEAFEIME.FKEDAOOHPPB.KDIMEMOCJNM * this.FDKHFDCJBPB;
			array[2] = "RightSplashPause";
			array[1] = befchfngomi.IGDKBMGKKDO(false, -1);
			array[5] = text3;
			GUI.Label(position, string.Concat(array), guistyle);
		}
	}

	// Token: 0x06007554 RID: 30036 RVA: 0x0037A778 File Offset: 0x00378978
	public void BIPIJFNBOBB(MMKFAENBHKD OCKMAJALKMN, object HEABEPINGED)
	{
		this.CFAJEAFEIME = (HEABEPINGED as BEFCHFNGOMI);
		this.FDKHFDCJBPB = 0;
		string alboclbfnni = string.Format("Weapon Ready", IFPIMPMKJIB.NEJIPLDOMMC(), this.CFAJEAFEIME.LPFKFNLHGBI);
		if (this.CFAJEAFEIME.EOFDJHJPCLM == null)
		{
			this.CFAJEAFEIME.EOFDJHJPCLM = CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(alboclbfnni, true);
		}
		this.GKJKOLMCDDG = string.Concat(this.FDKHFDCJBPB);
	}

	// Token: 0x06007555 RID: 30037 RVA: 0x0037A7F4 File Offset: 0x003789F4
	public void MEELBJFHJAA(ONKDCGNBALK OJIMHKHFOJI)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("L Hand Punch", 1841f);
		if (this.PFDDJMOBGLG[this.MKFFJNKCDHL] != null)
		{
			this.PFDDJMOBGLG[this.MKFFJNKCDHL].HKPAEGGJNGG = false;
		}
		if ((long)this.MKFFJNKCDHL == OJIMHKHFOJI.ODFEKBJCFMN)
		{
			return;
		}
		this.MKFFJNKCDHL = (int)OJIMHKHFOJI.ODFEKBJCFMN;
		this.PFDDJMOBGLG[this.MKFFJNKCDHL].HKPAEGGJNGG = false;
		Debug.Log(" --- ? ---" + OJIMHKHFOJI.FNPEGDKBKJC);
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(true);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.ALNEALEKFNB(this.LEDPIGHPLBP);
			epmphjgalbe.NEHCMOODKIN(OJIMHKHFOJI.FNPEGDKBKJC);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(114, epmphjgalbe.IEJLLFECFHF());
		}
		finally
		{
			epmphjgalbe.HDKBMLOJLLC();
		}
	}

	// Token: 0x06007556 RID: 30038 RVA: 0x0037A8D4 File Offset: 0x00378AD4
	private void KODOABLENCC(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn != 8L)
		{
			if (odfekbjcfmn != 41L)
			{
				if (odfekbjcfmn != 38L)
				{
					return;
				}
				NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(163, this.LEDPIGHPLBP);
			}
			else
			{
				this.JLLEAJAHACN = true;
				if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 1 && this.CODAIBGMFCA != null)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("name", 61f);
					JDCEFOFMGHB.MNJNNDHCDGG().DKJMCKOJOPF(1620f, 1, JNBICAJIJMM.BDKHMOOFHHK("Water"), new ONKDCGNBALK.CMMHGMILOIM(this.FICPCOJGDJP), true);
					return;
				}
			}
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		JDCEFOFMGHB.JFIDAGABKID().DGFAPDDBHJB(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06007557 RID: 30039 RVA: 0x003784D2 File Offset: 0x003766D2
	public void NABIAMAIALJ(MMKFAENBHKD OCKMAJALKMN, object HEABEPINGED)
	{
		this.CODAIBGMFCA = (HEABEPINGED as ELNGEFIPDJK.DKLIGJOMDJK);
	}

	// Token: 0x06007558 RID: 30040 RVA: 0x0037A990 File Offset: 0x00378B90
	private void CDFNLMPOEKH(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn != 8L)
		{
			if (odfekbjcfmn != 34L)
			{
				if (odfekbjcfmn != -84L)
				{
					return;
				}
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(9, this.LEDPIGHPLBP);
			}
			else
			{
				this.JLLEAJAHACN = true;
				if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 1 && this.CODAIBGMFCA != null)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("PistolReady", 1431f);
					JDCEFOFMGHB.MNJNNDHCDGG().NOIEEEIONNG(1080f, 1, JNBICAJIJMM.PGJCPFNJNPM(" "), new ONKDCGNBALK.CMMHGMILOIM(this.OENPCHAPOLA), false);
					return;
				}
			}
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		JDCEFOFMGHB.IKGFHGKKCPG.KCNBOHEMLCI(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06007559 RID: 30041 RVA: 0x0037AA4C File Offset: 0x00378C4C
	public void MKPEBPIHHJB(ONKDCGNBALK OJIMHKHFOJI)
	{
		Fisherman.getI.GMBEHOGPEDI(0, 184f, Vector3.zero);
		if (!this.CFAJEAFEIME.FKEDAOOHPPB.BAFNIPIGGIP(JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH, this.FDKHFDCJBPB) || !this.CFAJEAFEIME.GBABFPMNIMP)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("_MainTex", 165f);
			return;
		}
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn == 1L)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().DKJMCKOJOPF(1835f, 1, JNBICAJIJMM.NGALDMFKMJH("error.wav"), new ONKDCGNBALK.CMMHGMILOIM(this.EDHPMPGONCL), false);
			return;
		}
		if (odfekbjcfmn != 7L)
		{
			return;
		}
		Debug.Log("Jump");
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.JDOLCNDNFGP(this.LEDPIGHPLBP);
			epmphjgalbe.JDOLCNDNFGP(this.CFAJEAFEIME.LPFKFNLHGBI);
			epmphjgalbe.ENDMKPCFKND(this.FDKHFDCJBPB);
			NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(181, epmphjgalbe.ALLANCHILCM());
		}
		finally
		{
			epmphjgalbe.PMIGGJHLIDO();
		}
	}

	// Token: 0x0600755A RID: 30042 RVA: 0x003784B4 File Offset: 0x003766B4
	private int IAOBMOLMJLC(int CLBPBJGLHEE)
	{
		if (!this.BALDMDGKEPP.ContainsKey(CLBPBJGLHEE))
		{
			return 0;
		}
		return this.BALDMDGKEPP[CLBPBJGLHEE];
	}

	// Token: 0x0600755B RID: 30043 RVA: 0x00375E24 File Offset: 0x00374024
	private int FBCEOIFAILM(int CLBPBJGLHEE)
	{
		if (!this.BALDMDGKEPP.ContainsKey(CLBPBJGLHEE))
		{
			return 1;
		}
		return this.BALDMDGKEPP[CLBPBJGLHEE];
	}

	// Token: 0x0600755C RID: 30044 RVA: 0x0037AB58 File Offset: 0x00378D58
	private void LMPFENOKCAC(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn != 0L)
		{
			if (odfekbjcfmn != -66L)
			{
				if (odfekbjcfmn != 97L)
				{
					return;
				}
				NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(12, this.LEDPIGHPLBP);
			}
			else
			{
				this.JLLEAJAHACN = false;
				if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 1 && this.CODAIBGMFCA != null)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("_", 1168f);
					JDCEFOFMGHB.MNJNNDHCDGG().PBJGEIMFNNO(1331f, 1, JNBICAJIJMM.CDDCIKKDFMP("KatanaReady"), new ONKDCGNBALK.CMMHGMILOIM(this.FICPCOJGDJP), true);
					return;
				}
			}
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		JDCEFOFMGHB.MNJNNDHCDGG().KCNBOHEMLCI(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x0600755D RID: 30045 RVA: 0x0037AC14 File Offset: 0x00378E14
	public void LFHNJMDJPDN(MMKFAENBHKD OCKMAJALKMN, object HEABEPINGED)
	{
		this.CFAJEAFEIME = (HEABEPINGED as BEFCHFNGOMI);
		this.FDKHFDCJBPB = 0;
		string alboclbfnni = string.Format("", IFPIMPMKJIB.AFJFDKAGKLD(), this.CFAJEAFEIME.LPFKFNLHGBI);
		if (this.CFAJEAFEIME.EOFDJHJPCLM == null)
		{
			this.CFAJEAFEIME.EOFDJHJPCLM = CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(alboclbfnni, true);
		}
		this.GKJKOLMCDDG = string.Concat(this.FDKHFDCJBPB);
	}

	// Token: 0x0600755E RID: 30046 RVA: 0x0037AC90 File Offset: 0x00378E90
	private void FJPICNELDJP(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn != 3L)
		{
			if (odfekbjcfmn != 39L)
			{
				if (odfekbjcfmn != 100L)
				{
					return;
				}
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-21, this.LEDPIGHPLBP);
			}
			else
			{
				this.JLLEAJAHACN = true;
				if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 0 && this.CODAIBGMFCA != null)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("Player", 1088f);
					JDCEFOFMGHB.MNJNNDHCDGG().DKJMCKOJOPF(641f, 1, JNBICAJIJMM.PPNKMDJBMLP("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version."), new ONKDCGNBALK.CMMHGMILOIM(this.FICPCOJGDJP), true);
					return;
				}
			}
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		JDCEFOFMGHB.MNJNNDHCDGG().DGFAPDDBHJB(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x0600755F RID: 30047 RVA: 0x0037AD4C File Offset: 0x00378F4C
	private void EBCPAECPEJI(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn != 2L)
		{
			if (odfekbjcfmn != -16L)
			{
				if (odfekbjcfmn != 68L)
				{
					return;
				}
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(48, this.LEDPIGHPLBP);
			}
			else
			{
				this.JLLEAJAHACN = true;
				if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 0 && this.CODAIBGMFCA != null)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("name", 1432f);
					JDCEFOFMGHB.IKGFHGKKCPG.NOIEEEIONNG(1328f, 1, JNBICAJIJMM.DIOJFJMOPJO("http://www.root-motion.com/finalikdox/html/page9.html"), new ONKDCGNBALK.CMMHGMILOIM(this.FICPCOJGDJP), false);
					return;
				}
			}
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		JDCEFOFMGHB.MNJNNDHCDGG().DGFAPDDBHJB(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06007560 RID: 30048 RVA: 0x0037AE08 File Offset: 0x00379008
	public void KONOGPMOHAD(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.AFLBAGIJLFH(4, 1118f, Vector3.zero);
		this.LEDPIGHPLBP = KADBECGIMPD.LDLKLPJBIJN();
		if (ELNGEFIPDJK.IKGFHGKKCPG.GHDPBBPIOAC > 0)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().KCNBOHEMLCI(this.GHDPBBPIOAC);
		}
		for (int i = 0; i < -46; i++)
		{
			this.PFDDJMOBGLG[i] = null;
		}
		this.BALDMDGKEPP.Clear();
		int num = KADBECGIMPD.HDBGOLAFOBK();
		for (int j = 1; j < num; j += 0)
		{
			int key = KADBECGIMPD.AGNKAFLKCAG();
			int value = KADBECGIMPD.KDNDJNEGBDI();
			this.BALDMDGKEPP.Add(key, value);
		}
		int num2 = KADBECGIMPD.KDNDJNEGBDI();
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().NCIDDNIKACI(1422f, 924f, JNBICAJIJMM.CELEPPAEKAB(" "), false);
		if (this.LEDPIGHPLBP < 0)
		{
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(837f, 222f, onkdcgnbalk.OCHCODJIPHJ.width, onkdcgnbalk.OCHCODJIPHJ.height), GameInterface.getI.rShopImage);
		}
		this.GHDPBBPIOAC = onkdcgnbalk.LPFKFNLHGBI;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 947f, 1384f, 1706f, onkdcgnbalk.OCHCODJIPHJ.height - 499f, 1);
		mmkfaenbhkd.JHNCNHAAJCH = 1937f;
		mmkfaenbhkd.KCLLDJJLCGC = 11;
		mmkfaenbhkd.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.LICBIECFFFI);
		mmkfaenbhkd.AEMFOALOHDD(1);
		this.OJJLLBKEGNO = mmkfaenbhkd;
		int num3 = -18;
		int num4 = 1;
		if (this.BOLAPDJGBIF(-15) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1932f, (float)(num4 * 77 + -53), 234f, (float)num3, JNBICAJIJMM.OOOKJHOHPNN("wpn_line1"), "The font size '", null, new ONKDCGNBALK.CMMHGMILOIM(this.MEELBJFHJAA));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.BAEAJEFGKHL(-70) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 239f, (float)(num4 * 6 + 57), 192f, (float)num3, JNBICAJIJMM.PPNKMDJBMLP("wpnend"), "camouflage_id", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.BAEAJEFGKHL(-30) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1049f, (float)(num4 * -18 + -83), 2f, (float)num3, JNBICAJIJMM.DIOJFJMOPJO("_AddCountitem.wav"), "Kernel", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.LBPHCGNIDBP(0) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 302f, (float)(num4 * 112 + 52), 1401f, (float)num3, JNBICAJIJMM.DIOJFJMOPJO("inventoryOpen"), "Idle Run", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.ABNCLFAAGNG(1) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 834f, (float)(num4 * -40 + -119), 1881f, (float)num3, JNBICAJIJMM.NGALDMFKMJH("IdleDodgeRight"), "OneHandSwordReady", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.DHEJHNKMIJL(3) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 258f, (float)(num4 * -89 + 117), 1161f, (float)num3, JNBICAJIJMM.DCEBAJIILPC("_SSAO"), "knopje.wav", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.ABNCLFAAGNG(0) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 786f, (float)(num4 * 118 + -104), 1975f, (float)num3, JNBICAJIJMM.CDDCIKKDFMP("Original string:\n"), "Index out of range.", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.FBCEOIFAILM(8) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 100f, (float)(num4 * -21 + -123), 1311f, (float)num3, JNBICAJIJMM.BDKHMOOFHHK("FishPointer"), "offsets", null, new ONKDCGNBALK.CMMHGMILOIM(this.JOGCDAMIBKH));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.BOLAPDJGBIF(2) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1063f, (float)(num4 * 21 + -89), 1974f, (float)num3, JNBICAJIJMM.PPNKMDJBMLP("fshop_btn1"), "checkPet 1", null, new ONKDCGNBALK.CMMHGMILOIM(this.JOGCDAMIBKH));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.IJFKAIKNNJM(0) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 793f, (float)(num4 * 18 + -94), 468f, (float)num3, JNBICAJIJMM.CELEPPAEKAB("Mouse X"), "inv_money", null, new ONKDCGNBALK.CMMHGMILOIM(this.MEELBJFHJAA));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.HNDHCKODBOP(-38) + this.FBCEOIFAILM(8) + this.DHEJHNKMIJL(4) + this.ABNCLFAAGNG(-19) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 293f, (float)(num4 * 63 + -52), 1808f, (float)num3, JNBICAJIJMM.PGJCPFNJNPM("EventSystem"), "_ReflectionTexture1", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.ABNCLFAAGNG(-7) + this.BAEAJEFGKHL(78) + this.KCNNPALBIIC(-84) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 958f, (float)(num4 * -18 + -43), 838f, (float)num3, JNBICAJIJMM.NGALDMFKMJH("Transforms is null."), " \n", null, new ONKDCGNBALK.CMMHGMILOIM(this.CHOPGPEPILD));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.BOLAPDJGBIF(62) + this.BOLAPDJGBIF(89) + this.DHEJHNKMIJL(108) + this.LBPHCGNIDBP(16) + this.IJFKAIKNNJM(76) + this.HNDHCKODBOP(-25) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1631f, (float)(num4 * 21 + 5), 1196f, (float)num3, JNBICAJIJMM.PGJCPFNJNPM("/"), "Invalid references, one or more Transforms are missing.", null, new ONKDCGNBALK.CMMHGMILOIM(this.CHOPGPEPILD));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.HOMKEPENMIE(101) + this.HOMKEPENMIE(38) + this.BOLAPDJGBIF(-30) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1712f, (float)(num4 * -107 + -42), 835f, (float)num3, JNBICAJIJMM.DCEBAJIILPC(" has been unloaded successfully"), "VA ", null, new ONKDCGNBALK.CMMHGMILOIM(this.CHOPGPEPILD));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.HOMKEPENMIE(-71) + this.BOLAPDJGBIF(60) + this.DHEJHNKMIJL(39) + this.HNDHCKODBOP(77) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 162f, (float)(num4 * -77 + 114), 1164f, (float)num3, JNBICAJIJMM.PPNKMDJBMLP("_SSAO"), "PaperTurn.wav", null, new ONKDCGNBALK.CMMHGMILOIM(this.MEELBJFHJAA));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.KCNNPALBIIC(20) + this.IAOBMOLMJLC(114) + this.IJFKAIKNNJM(101) + this.BOLAPDJGBIF(64) + this.ABNCLFAAGNG(-3) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1249f, (float)(num4 * 96 + 80), 576f, (float)num3, JNBICAJIJMM.DCEBAJIILPC("codepage"), "UIChat_alfa", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.FBCEOIFAILM(114) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1997f, (float)(num4 * -46 + 123), 648f, (float)num3, JNBICAJIJMM.OOOKJHOHPNN("Transform is null."), "wpn_hookf", null, new ONKDCGNBALK.CMMHGMILOIM(this.MEELBJFHJAA));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.BAEAJEFGKHL(18) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 993f, (float)(num4 * -125 + -107), 878f, (float)num3, JNBICAJIJMM.CELEPPAEKAB("______________________________"), "_WrinkleOcclusionStrengths", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.HNDHCKODBOP(-28) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 375f, (float)(num4 * 77 + 99), 1921f, (float)num3, JNBICAJIJMM.BDKHMOOFHHK("costume_"), "finger", null, new ONKDCGNBALK.CMMHGMILOIM(this.MEELBJFHJAA));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.HOMKEPENMIE(-34) + this.ABNCLFAAGNG(46) + this.IAOBMOLMJLC(52) + this.HOMKEPENMIE(111) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 144f, (float)(num4 * -123 + 13), 1000f, (float)num3, JNBICAJIJMM.DCEBAJIILPC("IdleReadyCrouch"), "Чат очищен", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		for (int k = 0; k < num2; k++)
		{
			int lpfkfnlhgbi = KADBECGIMPD.KKOKFLMMAAK();
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OOIJFNAMEDP().NKMGKJLONDK(lpfkfnlhgbi);
			string dccpcblodig = KADBECGIMPD.DPLAJNEDGBL();
			befchfngomi.OPFGGNNPAJL = KADBECGIMPD.BAPGFMDPGKM();
			befchfngomi.GBABFPMNIMP = KADBECGIMPD.AJECAOJPOKA();
			befchfngomi.FKEDAOOHPPB.EHCMHODHIMG(dccpcblodig);
			befchfngomi.KEICEAJOGFD();
			this.OJJLLBKEGNO.LACAJHOHACK.Add(befchfngomi);
		}
		this.OJJLLBKEGNO.IADNHBBEDCJ();
		this.OJJLLBKEGNO.PHHNPGFNNCB();
		this.OJJLLBKEGNO.HNAMFMFHIGH(0, 1);
		if (this.PFDDJMOBGLG[this.MKFFJNKCDHL] != null)
		{
			this.PFDDJMOBGLG[this.MKFFJNKCDHL].HKPAEGGJNGG = false;
		}
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, 453f, 510f, 956f, onkdcgnbalk.OCHCODJIPHJ.height - 535f, "FlyBackward", 0, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.BEJKOCKCHID)
		};
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 1538f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 1972f, 482f, 537f, JNBICAJIJMM.DCEBAJIILPC("_TintColor"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.LFFJHCPAOBC));
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 1384f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 76f, 1986f, 271f, JNBICAJIJMM.LEBHCLDODNI("BowIdle"), 4, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.ODBGHCIJOHA));
	}

	// Token: 0x06007561 RID: 30049 RVA: 0x0037B9AC File Offset: 0x00379BAC
	private void EEPDPHBNJAK(ONKDCGNBALK OPCILKKDEON)
	{
		long odfekbjcfmn = OPCILKKDEON.ODFEKBJCFMN;
		long num = odfekbjcfmn - 0L;
		if (num > 2L)
		{
			return;
		}
		switch ((uint)num)
		{
		case 0U:
			foreach (ItemBase itemBase in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = (ELNGEFIPDJK.NADBMPJIMEC)itemBase;
				nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 1781f);
			}
			this.DLBMLNNAHAF.KINFJHFDHIC();
			this.DLBMLNNAHAF.NAFLLMADLMA();
			return;
		case 1U:
			this.DLBMLNNAHAF.CFHDIMJHBAB();
			return;
		case 2U:
			foreach (ItemBase itemBase2 in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec2 = (ELNGEFIPDJK.NADBMPJIMEC)itemBase2;
				nadbmpjimec2.tag = (long)(nadbmpjimec2.DGLOPIJHPJN * 136);
			}
			this.DLBMLNNAHAF.PLKPBLGIEBL();
			this.DLBMLNNAHAF.HHKCFGAENJN();
			return;
		default:
			return;
		}
	}

	// Token: 0x06007562 RID: 30050 RVA: 0x0037BAC8 File Offset: 0x00379CC8
	public void CFGCLBNKECI(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.CNGKCDLJEDG(1, 1851f, Vector3.zero);
		if (KADBECGIMPD.DOJKJHMJJNK() < 0)
		{
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().BJFHBPOCELH(1446f, 528f, JNBICAJIJMM.DIOJFJMOPJO("wpn_dress1"), false);
		ONKDCGNBALK onkdcgnbalk2 = JDCEFOFMGHB.JFIDAGABKID().IJAEDDCCNHG(this.PEJGNBMFCDP);
		if (onkdcgnbalk2 != null)
		{
			float num = (onkdcgnbalk2.OCHCODJIPHJ.width + onkdcgnbalk.OCHCODJIPHJ.x + 196f) / 1548f;
			onkdcgnbalk2.OCHCODJIPHJ.x = (float)(Screen.width / 6) - num;
			onkdcgnbalk.OCHCODJIPHJ.height = onkdcgnbalk2.OCHCODJIPHJ.height;
			onkdcgnbalk.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y;
			onkdcgnbalk.OCHCODJIPHJ.x = onkdcgnbalk2.OCHCODJIPHJ.x + onkdcgnbalk2.OCHCODJIPHJ.width + 341f;
		}
		this.DLBMLNNAHAF = new MMKFAENBHKD(onkdcgnbalk, 827f, 710f, onkdcgnbalk.OCHCODJIPHJ.width - 716f, onkdcgnbalk.OCHCODJIPHJ.height - 802f, 0)
		{
			JHNCNHAAJCH = 1832f
		};
		new MEMEOHJKPNJ(onkdcgnbalk, 1693f, 1669f, 1911f, 29f, JNBICAJIJMM.CELEPPAEKAB("invn_rec17"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.EEPDPHBNJAK));
		new MEMEOHJKPNJ(onkdcgnbalk, 1726f, 1638f, 174f, 974f, JNBICAJIJMM.NGALDMFKMJH("rollTENSIONKG="), 8, null, new ONKDCGNBALK.CMMHGMILOIM(this.NNNKDIHIOOG));
		new MEMEOHJKPNJ(onkdcgnbalk, 1404f, 1023f, 30f, 1392f, JNBICAJIJMM.PGJCPFNJNPM("x{0} {1}\n"), 5, null, new ONKDCGNBALK.CMMHGMILOIM(this.FHOMLHAIEBO));
		KADBECGIMPD.DOJKJHMJJNK();
		this.IPOMGIHFANC = KADBECGIMPD.ECJLJGDNFMN();
		this.FCDHFLCDDJF = KADBECGIMPD.BNDHIBEOKML();
		while (!KADBECGIMPD.HKBFCJDJCOB())
		{
			ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = new ELNGEFIPDJK.NADBMPJIMEC();
			nadbmpjimec.JEDDGGGGOCJ(KADBECGIMPD);
			nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 395f);
			nadbmpjimec.onRender = new ItemBase.OOALOMPKIKK(this.MABBFBHGJKH);
			this.DLBMLNNAHAF.LACAJHOHACK.Add(nadbmpjimec);
		}
		this.DLBMLNNAHAF.KCLLDJJLCGC = 14;
		this.DLBMLNNAHAF.GNGINMOFEEH();
		this.DLBMLNNAHAF.HHKCFGAENJN();
		this.DLBMLNNAHAF.NEKOMKJDIIE(0);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1533f - 1658f, onkdcgnbalk.OCHCODJIPHJ.height - 226f, 485f, 1891f, JNBICAJIJMM.LEBHCLDODNI(""), 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
	}

	// Token: 0x06007563 RID: 30051 RVA: 0x0037BD88 File Offset: 0x00379F88
	public void DILGNBIOOFC(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.CNGKCDLJEDG(0, 630f, Vector3.zero);
		if (KADBECGIMPD.AGNKAFLKCAG() < 0)
		{
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().BJFHBPOCELH(118f, 1912f, JNBICAJIJMM.PGJCPFNJNPM("OfficeSitting45DegLeg"), false);
		ONKDCGNBALK onkdcgnbalk2 = JDCEFOFMGHB.JFIDAGABKID().FDMNKDONMFM(this.PEJGNBMFCDP);
		if (onkdcgnbalk2 != null)
		{
			float num = (onkdcgnbalk2.OCHCODJIPHJ.width + onkdcgnbalk.OCHCODJIPHJ.x + 341f) / 893f;
			onkdcgnbalk2.OCHCODJIPHJ.x = (float)(Screen.width / 4) - num;
			onkdcgnbalk.OCHCODJIPHJ.height = onkdcgnbalk2.OCHCODJIPHJ.height;
			onkdcgnbalk.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y;
			onkdcgnbalk.OCHCODJIPHJ.x = onkdcgnbalk2.OCHCODJIPHJ.x + onkdcgnbalk2.OCHCODJIPHJ.width + 327f;
		}
		this.DLBMLNNAHAF = new MMKFAENBHKD(onkdcgnbalk, 286f, 277f, onkdcgnbalk.OCHCODJIPHJ.width - 1947f, onkdcgnbalk.OCHCODJIPHJ.height - 393f, 0)
		{
			JHNCNHAAJCH = 1134f
		};
		new MEMEOHJKPNJ(onkdcgnbalk, 596f, 1856f, 1133f, 1f, JNBICAJIJMM.CDDCIKKDFMP("PistolLeftHandStab"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.OHDNFKBAEPE));
		new MEMEOHJKPNJ(onkdcgnbalk, 1264f, 600f, 114f, 1070f, JNBICAJIJMM.CDDCIKKDFMP("wpn_add/addoptions/klevprop"), 5, null, new ONKDCGNBALK.CMMHGMILOIM(this.FHOMLHAIEBO));
		new MEMEOHJKPNJ(onkdcgnbalk, 425f, 1937f, 1143f, 1951f, JNBICAJIJMM.DCEBAJIILPC("UNITY_COLORSPACE_GAMMA"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(this.FHOMLHAIEBO));
		KADBECGIMPD.LDLKLPJBIJN();
		this.IPOMGIHFANC = KADBECGIMPD.CGJIINADKNH();
		this.FCDHFLCDDJF = KADBECGIMPD.MOBPFEEAMKD();
		while (!KADBECGIMPD.NNOJEFMEGEG())
		{
			ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = new ELNGEFIPDJK.NADBMPJIMEC();
			nadbmpjimec.AKEOHKFBCJL(KADBECGIMPD);
			nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 810f);
			nadbmpjimec.onRender = new ItemBase.OOALOMPKIKK(this.LMPDNMBDLFO);
			this.DLBMLNNAHAF.LACAJHOHACK.Add(nadbmpjimec);
		}
		this.DLBMLNNAHAF.KCLLDJJLCGC = -91;
		this.DLBMLNNAHAF.PLKPBLGIEBL();
		this.DLBMLNNAHAF.OAAANLCENCF();
		this.DLBMLNNAHAF.AGFFDCECLBF(1);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 779f - 1056f, onkdcgnbalk.OCHCODJIPHJ.height - 623f, 1087f, 1653f, JNBICAJIJMM.BDKHMOOFHHK("short:"), 5, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.JFIDAGABKID().HMBGLALKHCP));
	}

	// Token: 0x06007564 RID: 30052 RVA: 0x0037C048 File Offset: 0x0037A248
	public void JFKDADMHFJK(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.sendAction(1, 4f, Vector3.zero);
		this.LEDPIGHPLBP = KADBECGIMPD.HDBGOLAFOBK();
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(850f, 450f, JNBICAJIJMM.LEBHCLDODNI("fshop_header"), true);
		this.PEJGNBMFCDP = onkdcgnbalk.LPFKFNLHGBI;
		this.OJJLLBKEGNO = new MMKFAENBHKD(onkdcgnbalk, 20f, 49f, 450f, onkdcgnbalk.OCHCODJIPHJ.height - 70f, 0);
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			ELNGEFIPDJK.DKLIGJOMDJK dkligjomdjk = new ELNGEFIPDJK.DKLIGJOMDJK();
			dkligjomdjk.ACJDDOEADFK(KADBECGIMPD);
			this.OJJLLBKEGNO.LACAJHOHACK.Add(dkligjomdjk);
		}
		this.OJJLLBKEGNO.JHNCNHAAJCH = 44f;
		this.OJJLLBKEGNO.KCLLDJJLCGC = 14;
		this.OJJLLBKEGNO.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.PMPNBIOJNJE);
		this.OJJLLBKEGNO.IHEILFHMLAG = 0;
		this.OJJLLBKEGNO.MPMFNJEJAHJ();
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, this.OJJLLBKEGNO.OCHCODJIPHJ.x + this.OJJLLBKEGNO.OCHCODJIPHJ.width + 15f, 45f, 356f, 340f, "", 0, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.OBNGDIJKEOE)
		};
		MEMEOHJKPNJ memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x, onkdcgnbalk.OCHCODJIPHJ.height - 42f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("fshop_btn1"), 30, null, new ONKDCGNBALK.CMMHGMILOIM(this.CPGKFKMDBLA))
		{
			FNMCIACNOMH = FlyMessageManager.getI.checkFlyIcon(20)
		};
		memeohjkpnj.EONGFJFPGGD(GuiProcessor.IKGFHGKKCPG.vipKeyTex, 16f);
		memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 128f + 6f, onkdcgnbalk.OCHCODJIPHJ.height - 42f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("fshop_btn3"), 10, null, new ONKDCGNBALK.CMMHGMILOIM(this.CPGKFKMDBLA))
		{
			FNMCIACNOMH = FlyMessageManager.getI.checkFlyIcon(20)
		};
		memeohjkpnj.EONGFJFPGGD(GuiProcessor.IKGFHGKKCPG.vipKeyTex, 16f);
		if (this.CODAIBGMFCA == null)
		{
			memeohjkpnj.FNMCIACNOMH = false;
		}
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count <= 0)
		{
			memeohjkpnj.FNMCIACNOMH = false;
		}
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 7f - 70f, onkdcgnbalk.OCHCODJIPHJ.height - 42f, 70f, 24f, JNBICAJIJMM.LEBHCLDODNI("cntx_close"), 6, null, new ONKDCGNBALK.CMMHGMILOIM(this.CPGKFKMDBLA));
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count <= 0)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(onkdcgnbalk.LPFKFNLHGBI);
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("fshop_hd2"), JNBICAJIJMM.LEBHCLDODNI("fshop_hd3"));
		}
	}

	// Token: 0x06007565 RID: 30053 RVA: 0x0037C350 File Offset: 0x0037A550
	public void OENPCHAPOLA(ONKDCGNBALK ONPHLHKAGFP)
	{
		IDCHHHEDHDC gaapclgdogh = this.CODAIBGMFCA.GAAPCLGDOGH;
		OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(string.Format(JNBICAJIJMM.NGALDMFKMJH("FOG_SCATTERING_ON"), gaapclgdogh.CJAMOIMGHAK(0, this.CODAIBGMFCA.DBEIGNDALDC, false, false, false, 1, true, true), this.CODAIBGMFCA.ILFHHDNJHNM, JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.CODAIBGMFCA.NKHBAJKMAGD)));
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.LHLOOIDHGMA(this.LEDPIGHPLBP);
			epmphjgalbe.JIIKLOKAGIC(this.CODAIBGMFCA.NENOBDLCFHO);
			epmphjgalbe.DEHJNGMHGAJ(this.CODAIBGMFCA.DBEIGNDALDC);
			NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(23, epmphjgalbe.IEJLLFECFHF());
		}
		finally
		{
			epmphjgalbe.NCKMEIBFNGL();
		}
		this.OJJLLBKEGNO.LACAJHOHACK.Remove(this.CODAIBGMFCA);
		this.CODAIBGMFCA = null;
		this.OJJLLBKEGNO.FNFFGIJOENM();
		this.OJJLLBKEGNO.OOJKJOCOOCB(0, 0);
		if (this.JLLEAJAHACN && this.OJJLLBKEGNO.LACAJHOHACK.Count > 0 && this.CODAIBGMFCA != null)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("", 476f);
			JDCEFOFMGHB.JFIDAGABKID().NOIEEEIONNG(1382f, 0, JNBICAJIJMM.PPNKMDJBMLP("heart.wav"), new ONKDCGNBALK.CMMHGMILOIM(this.OENPCHAPOLA), false);
		}
	}

	// Token: 0x06007566 RID: 30054 RVA: 0x003784B4 File Offset: 0x003766B4
	private int LBPHCGNIDBP(int CLBPBJGLHEE)
	{
		if (!this.BALDMDGKEPP.ContainsKey(CLBPBJGLHEE))
		{
			return 0;
		}
		return this.BALDMDGKEPP[CLBPBJGLHEE];
	}

	// Token: 0x06007567 RID: 30055 RVA: 0x0037C4B8 File Offset: 0x0037A6B8
	public void MONAMIJKDED(ONKDCGNBALK OJIMHKHFOJI)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("offsets", 1440f);
		if (this.PFDDJMOBGLG[this.MKFFJNKCDHL] != null)
		{
			this.PFDDJMOBGLG[this.MKFFJNKCDHL].HKPAEGGJNGG = false;
		}
		if ((long)this.MKFFJNKCDHL == OJIMHKHFOJI.ODFEKBJCFMN)
		{
			return;
		}
		this.MKFFJNKCDHL = (int)OJIMHKHFOJI.ODFEKBJCFMN;
		this.PFDDJMOBGLG[this.MKFFJNKCDHL].HKPAEGGJNGG = true;
		Debug.Log("#a02000" + OJIMHKHFOJI.FNPEGDKBKJC);
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.PDEFLCIEMFF(this.LEDPIGHPLBP);
			epmphjgalbe.FINMMGHAHFI(OJIMHKHFOJI.FNPEGDKBKJC);
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(50, epmphjgalbe.JOCJNOBBELJ());
		}
		finally
		{
			epmphjgalbe.PMIGGJHLIDO();
		}
	}

	// Token: 0x06007569 RID: 30057 RVA: 0x0037C5A4 File Offset: 0x0037A7A4
	public void MKGGPLKILJC(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.sendAction(8, 646f, Vector3.zero);
		this.LEDPIGHPLBP = KADBECGIMPD.KKOKFLMMAAK();
		if (ELNGEFIPDJK.IKGFHGKKCPG.GHDPBBPIOAC > 1)
		{
			JDCEFOFMGHB.JFIDAGABKID().DGFAPDDBHJB(this.GHDPBBPIOAC);
		}
		for (int i = 0; i < -93; i++)
		{
			this.PFDDJMOBGLG[i] = null;
		}
		this.BALDMDGKEPP.Clear();
		int num = KADBECGIMPD.DOJKJHMJJNK();
		for (int j = 1; j < num; j += 0)
		{
			int key = KADBECGIMPD.DOJKJHMJJNK();
			int value = KADBECGIMPD.HDBGOLAFOBK();
			this.BALDMDGKEPP.Add(key, value);
		}
		int num2 = KADBECGIMPD.HHLDBAEFNMJ();
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().BJFHBPOCELH(1898f, 1976f, JNBICAJIJMM.DIOJFJMOPJO("wpn_eat1"), false);
		if (this.LEDPIGHPLBP < 0)
		{
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(1461f, 1552f, onkdcgnbalk.OCHCODJIPHJ.width, onkdcgnbalk.OCHCODJIPHJ.height), GameInterface.getI.rShopImage);
		}
		this.GHDPBBPIOAC = onkdcgnbalk.LPFKFNLHGBI;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 411f, 322f, 702f, onkdcgnbalk.OCHCODJIPHJ.height - 1949f, 1);
		mmkfaenbhkd.JHNCNHAAJCH = 1870f;
		mmkfaenbhkd.KCLLDJJLCGC = 32;
		mmkfaenbhkd.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.LFHNJMDJPDN);
		mmkfaenbhkd.IIBCAICFEEF(0);
		this.OJJLLBKEGNO = mmkfaenbhkd;
		int num3 = 94;
		int num4 = 1;
		if (this.IAOBMOLMJLC(19) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1795f, (float)(num4 * -112 + -107), 1365f, (float)num3, JNBICAJIJMM.CDDCIKKDFMP(""), "  Balls Fired: ", null, new ONKDCGNBALK.CMMHGMILOIM(this.MEELBJFHJAA));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.FBCEOIFAILM(-112) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 379f, (float)(num4 * 109 + -30), 16f, (float)num3, JNBICAJIJMM.DIOJFJMOPJO("cnt_energ"), "SneakRight", null, new ONKDCGNBALK.CMMHGMILOIM(this.CHOPGPEPILD));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.HOMKEPENMIE(-3) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1056f, (float)(num4 * 71 + -24), 1068f, (float)num3, JNBICAJIJMM.PPNKMDJBMLP("Move around with WASD or cursor keys, space to jump"), ".unity3d", null, new ONKDCGNBALK.CMMHGMILOIM(this.CHOPGPEPILD));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.HOMKEPENMIE(0) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 362f, (float)(num4 * -41 + 117), 41f, (float)num3, JNBICAJIJMM.DCEBAJIILPC("change channel press"), "WeaponReload", null, new ONKDCGNBALK.CMMHGMILOIM(this.JOGCDAMIBKH));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.DHEJHNKMIJL(1) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1729f, (float)(num4 * -50 + 90), 622f, (float)num3, JNBICAJIJMM.PGJCPFNJNPM("_StretchWidth"), "chnam1", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.BAEAJEFGKHL(0) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1937f, (float)(num4 * 119 + -68), 1645f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("IdleFly"), "Bend Constraint is referencing to a bone '", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.HNDHCKODBOP(1) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 8f, (float)(num4 * -35 + -50), 1304f, (float)num3, JNBICAJIJMM.OOOKJHOHPNN("_CenterRadius"), "Projector reference not set.", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(1) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 248f, (float)(num4 * -85 + -11), 376f, (float)num3, JNBICAJIJMM.OOOKJHOHPNN("PistolFire"), " ", null, new ONKDCGNBALK.CMMHGMILOIM(this.JOGCDAMIBKH));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.DHEJHNKMIJL(5) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 528f, (float)(num4 * -73 + -127), 1486f, (float)num3, JNBICAJIJMM.CELEPPAEKAB("Right"), "noDress", null, new ONKDCGNBALK.CMMHGMILOIM(this.CHOPGPEPILD));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.KCNNPALBIIC(8) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1352f, (float)(num4 * -37 + -88), 164f, (float)num3, JNBICAJIJMM.PPNKMDJBMLP("1HandSwordChargeSwipe"), "PoplDrop", null, new ONKDCGNBALK.CMMHGMILOIM(this.CHOPGPEPILD));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.LBPHCGNIDBP(56) + this.HNDHCKODBOP(3) + this.HOMKEPENMIE(6) + this.ABNCLFAAGNG(-74) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1094f, (float)(num4 * -9 + 15), 1886f, (float)num3, JNBICAJIJMM.OOOKJHOHPNN(""), "clavicle", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.KCNNPALBIIC(71) + this.FBCEOIFAILM(47) + this.HOMKEPENMIE(18) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1216f, (float)(num4 * 48 + -5), 1818f, (float)num3, JNBICAJIJMM.NGALDMFKMJH("_Offsets"), "OfficeSittingReadingCoffeeSip", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.HNDHCKODBOP(16) + this.ABNCLFAAGNG(-12) + this.LBPHCGNIDBP(97) + this.LBPHCGNIDBP(-112) + this.DHEJHNKMIJL(-86) + this.HNDHCKODBOP(91) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 84f, (float)(num4 * 101 + -99), 1576f, (float)num3, JNBICAJIJMM.CDDCIKKDFMP("Formatted Label"), "Post Process Debug Shader Missing...", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.DHEJHNKMIJL(-35) + this.IJFKAIKNNJM(45) + this.BOLAPDJGBIF(55) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 886f, (float)(num4 * 76 + -59), 1793f, (float)num3, JNBICAJIJMM.OOOKJHOHPNN("baseQuality"), "Windmill", null, new ONKDCGNBALK.CMMHGMILOIM(this.JOGCDAMIBKH));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.HNDHCKODBOP(-102) + this.HOMKEPENMIE(41) + this.BAEAJEFGKHL(12) + this.HNDHCKODBOP(-28) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 867f, (float)(num4 * 28 + -10), 1697f, (float)num3, JNBICAJIJMM.DCEBAJIILPC("SoccerKeeperDiveStrafeFarRight"), "Move around with WASD or cursor keys, space to jump, F key to change fog style, T to toggle fog on/off.", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(-5) + this.BOLAPDJGBIF(-51) + this.LBPHCGNIDBP(52) + this.HOMKEPENMIE(-32) + this.LBPHCGNIDBP(7) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1313f, (float)(num4 * 125 + -97), 557f, (float)num3, JNBICAJIJMM.NGALDMFKMJH("PistolInstant"), "MotorbikeIdle", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.BAEAJEFGKHL(68) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 692f, (float)(num4 * -11 + -63), 1331f, (float)num3, JNBICAJIJMM.CDDCIKKDFMP("\n"), "isRealView", null, new ONKDCGNBALK.CMMHGMILOIM(this.CHOPGPEPILD));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.ABNCLFAAGNG(-113) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 36f, (float)(num4 * 38 + -101), 1365f, (float)num3, JNBICAJIJMM.PPNKMDJBMLP("IdleStun"), "WoodSaw", null, new ONKDCGNBALK.CMMHGMILOIM(this.CHOPGPEPILD));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.HNDHCKODBOP(-46) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 102f, (float)(num4 * -69 + -14), 1476f, (float)num3, JNBICAJIJMM.CDDCIKKDFMP("wpn_add/base"), "Mouse Y", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.HNDHCKODBOP(68) + this.KCNNPALBIIC(-91) + this.IAOBMOLMJLC(-17) + this.LBPHCGNIDBP(83) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 610f, (float)(num4 * -31 + -123), 546f, (float)num3, JNBICAJIJMM.PPNKMDJBMLP("IdleSlide"), "_DepthFade", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		for (int k = 0; k < num2; k++)
		{
			int lpfkfnlhgbi = KADBECGIMPD.IFDFHJLCHAE();
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.EDKKJNHDBPF().IMCJNFHAFGE(lpfkfnlhgbi);
			string dccpcblodig = KADBECGIMPD.KDELAFDDGJH();
			befchfngomi.OPFGGNNPAJL = KADBECGIMPD.NMMCKDBOJDO();
			befchfngomi.GBABFPMNIMP = KADBECGIMPD.DADCGPGEHFK();
			befchfngomi.FKEDAOOHPPB.AHFLAENCMCM(dccpcblodig);
			befchfngomi.JIFFLPNBILE();
			this.OJJLLBKEGNO.LACAJHOHACK.Add(befchfngomi);
		}
		this.OJJLLBKEGNO.MCGGBEBAIJO();
		this.OJJLLBKEGNO.BEHAGGLKAJH();
		this.OJJLLBKEGNO.BPHFJLIEAAA(1, 1);
		if (this.PFDDJMOBGLG[this.MKFFJNKCDHL] != null)
		{
			this.PFDDJMOBGLG[this.MKFFJNKCDHL].HKPAEGGJNGG = false;
		}
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, 1017f, 716f, 1757f, onkdcgnbalk.OCHCODJIPHJ.height - 1683f, "\n", 1, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.BEJKOCKCHID)
		};
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 51f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 1668f, 1863f, 1273f, JNBICAJIJMM.NGALDMFKMJH("Add random value"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.MMEJNIBLADI));
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 1428f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 1215f, 73f, 1025f, JNBICAJIJMM.DCEBAJIILPC("Middle click"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().ODBGHCIJOHA));
	}

	// Token: 0x0600756A RID: 30058 RVA: 0x0037D148 File Offset: 0x0037B348
	public void OBNGDIJKEOE(ONKDCGNBALK PHEMLBHMNCM)
	{
		GUI.Box(PHEMLBHMNCM.OCHCODJIPHJ, "");
		if (this.CODAIBGMFCA != null)
		{
			IDCHHHEDHDC gaapclgdogh = this.CODAIBGMFCA.GAAPCLGDOGH;
			float num = PHEMLBHMNCM.OCHCODJIPHJ.width / 512f;
			float width = PHEMLBHMNCM.OCHCODJIPHJ.width;
			float num2 = 256f * num;
			GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y, width, num2), this.CODAIBGMFCA.EJJAGEFMHCO().KEDGAOBCNJG, ScaleMode.ScaleToFit);
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.white
				},
				alignment = TextAnchor.UpperCenter,
				fontSize = 16,
				font = GuiProcessor.IKGFHGKKCPG.rusfont,
				wordWrap = true,
				richText = true
			};
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y + num2, width, num2), gaapclgdogh.JHFLJHLAPBC(0, this.CODAIBGMFCA.DBEIGNDALDC, false, false, false, 0, false, false), guistyle);
			guistyle.fontSize = 14;
			string text = string.Format(JNBICAJIJMM.LEBHCLDODNI("fshop_msg2"), this.CODAIBGMFCA.ILFHHDNJHNM, JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.CODAIBGMFCA.NKHBAJKMAGD), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)this.CODAIBGMFCA.OIAMBMMGGLD, false));
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y + num2 + 26f, width, num2), text, guistyle);
			guistyle.fontSize = 18;
			text = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, this.CODAIBGMFCA.FKEDAOOHPPB, false);
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y + num2 + 90f, width, num2), text, guistyle);
			if (GUI.Button(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width / 2f - 80f, PHEMLBHMNCM.OCHCODJIPHJ.y + num2 + 115f, 160f, 30f), JNBICAJIJMM.LEBHCLDODNI("fshop_btn2")))
			{
				this.JLLEAJAHACN = false;
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_04.wav", 1f);
				JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO(1f, 0, JNBICAJIJMM.LEBHCLDODNI("fshop_hd4"), new ONKDCGNBALK.CMMHGMILOIM(this.FICPCOJGDJP), false);
				Fisherman.getI.sendAction(1, 4f, Vector3.zero);
			}
		}
	}

	// Token: 0x0600756B RID: 30059 RVA: 0x003784B4 File Offset: 0x003766B4
	private int ABNCLFAAGNG(int CLBPBJGLHEE)
	{
		if (!this.BALDMDGKEPP.ContainsKey(CLBPBJGLHEE))
		{
			return 0;
		}
		return this.BALDMDGKEPP[CLBPBJGLHEE];
	}

	// Token: 0x0600756C RID: 30060 RVA: 0x0037D3DC File Offset: 0x0037B5DC
	public void JAMPKHIMEJD(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.sendAction(3, 12f, Vector3.zero);
		this.LEDPIGHPLBP = KADBECGIMPD.HDBGOLAFOBK();
		if (ELNGEFIPDJK.IKGFHGKKCPG.GHDPBBPIOAC > 0)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.GHDPBBPIOAC);
		}
		for (int i = 0; i < 20; i++)
		{
			this.PFDDJMOBGLG[i] = null;
		}
		this.BALDMDGKEPP.Clear();
		int num = KADBECGIMPD.HDBGOLAFOBK();
		for (int j = 0; j < num; j++)
		{
			int key = KADBECGIMPD.HDBGOLAFOBK();
			int value = KADBECGIMPD.HDBGOLAFOBK();
			this.BALDMDGKEPP.Add(key, value);
		}
		int num2 = KADBECGIMPD.HDBGOLAFOBK();
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(890f, 600f, JNBICAJIJMM.LEBHCLDODNI("shop_header"), true);
		if (this.LEDPIGHPLBP < 0)
		{
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(0f, 0f, onkdcgnbalk.OCHCODJIPHJ.width, onkdcgnbalk.OCHCODJIPHJ.height), GameInterface.getI.rShopImage);
		}
		this.GHDPBBPIOAC = onkdcgnbalk.LPFKFNLHGBI;
		this.OJJLLBKEGNO = new MMKFAENBHKD(onkdcgnbalk, 155f, 44f, 300f, onkdcgnbalk.OCHCODJIPHJ.height - 60f, 0)
		{
			JHNCNHAAJCH = 64f,
			KCLLDJJLCGC = 11,
			LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.GCDKFNHFDLN),
			IHEILFHMLAG = 0
		};
		int num3 = 24;
		int num4 = 0;
		if (this.LBPHCGNIDBP(10) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t1"), "10", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(12) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t2"), "12", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(11) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t3"), "11", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(0) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t4"), "0", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(1) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t5"), "1", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(3) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t6"), "3", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(2) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t7"), "2", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(4) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t8"), "4", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(5) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t9"), "5", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(6) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t10"), "6", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(9) + this.LBPHCGNIDBP(8) + this.LBPHCGNIDBP(7) + this.LBPHCGNIDBP(13) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t11"), "7,13,9,8", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(14) + this.LBPHCGNIDBP(15) + this.LBPHCGNIDBP(16) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t12"), "14,15,16,36", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(17) + this.LBPHCGNIDBP(18) + this.LBPHCGNIDBP(19) + this.LBPHCGNIDBP(20) + this.LBPHCGNIDBP(29) + this.LBPHCGNIDBP(33) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t13"), "17,18,19,20,29,33", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(21) + this.LBPHCGNIDBP(22) + this.LBPHCGNIDBP(23) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t14"), "21,22,23", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(24) + this.LBPHCGNIDBP(25) + this.LBPHCGNIDBP(26) + this.LBPHCGNIDBP(28) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t15"), "24,25,26,28", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(27) + this.LBPHCGNIDBP(29) + this.LBPHCGNIDBP(30) + this.LBPHCGNIDBP(31) + this.LBPHCGNIDBP(32) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t16"), "27,29,30,31,32", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(34) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t17"), "34", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(90) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t20"), "90", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(100) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t18"), "100", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.LBPHCGNIDBP(37) + this.LBPHCGNIDBP(38) + this.LBPHCGNIDBP(39) + this.LBPHCGNIDBP(40) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 20f, (float)(num4 * 26 + 44), 120f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("shop_t19"), "37,38,39,40", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		for (int k = 0; k < num2; k++)
		{
			int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi);
			string dccpcblodig = KADBECGIMPD.BFPHBMDMODH();
			befchfngomi.OPFGGNNPAJL = KADBECGIMPD.EIMAIEJKHKF();
			befchfngomi.GBABFPMNIMP = KADBECGIMPD.FIFNOBGEKFF();
			befchfngomi.FKEDAOOHPPB.HJFPCDNKNAP(dccpcblodig);
			befchfngomi.JIFFLPNBILE();
			this.OJJLLBKEGNO.LACAJHOHACK.Add(befchfngomi);
		}
		this.OJJLLBKEGNO.NBCAEJHKLMG();
		this.OJJLLBKEGNO.MPMFNJEJAHJ();
		this.OJJLLBKEGNO.OOJKJOCOOCB(0, 0);
		if (this.PFDDJMOBGLG[this.MKFFJNKCDHL] != null)
		{
			this.PFDDJMOBGLG[this.MKFFJNKCDHL].HKPAEGGJNGG = true;
		}
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, 470f, 40f, 400f, onkdcgnbalk.OCHCODJIPHJ.height - 55f, "", 0, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.ILJAFBIGGIH)
		};
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 215f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 35f, 100f, 24f, JNBICAJIJMM.LEBHCLDODNI("buykey"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.EHHNDFPMKHD));
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 110f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 35f, 100f, 24f, JNBICAJIJMM.LEBHCLDODNI("cntx_close"), 6, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
	}

	// Token: 0x0600756D RID: 30061 RVA: 0x0037DF80 File Offset: 0x0037C180
	private void LPFDGMGNLKN(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn != 0L)
		{
			if (odfekbjcfmn != -88L)
			{
				if (odfekbjcfmn != -78L)
				{
					return;
				}
				NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(67, this.LEDPIGHPLBP);
			}
			else
			{
				this.JLLEAJAHACN = false;
				if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 0 && this.CODAIBGMFCA != null)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("ApplePick", 1565f);
					JDCEFOFMGHB.JFIDAGABKID().PBJGEIMFNNO(1363f, 0, JNBICAJIJMM.DCEBAJIILPC("WeaponReadyFire"), new ONKDCGNBALK.CMMHGMILOIM(this.FICPCOJGDJP), true);
					return;
				}
			}
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		JDCEFOFMGHB.HMJJPNDEKPP().KCNBOHEMLCI(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x0600756E RID: 30062 RVA: 0x0037E03C File Offset: 0x0037C23C
	private void FHOMLHAIEBO(ONKDCGNBALK OPCILKKDEON)
	{
		long odfekbjcfmn = OPCILKKDEON.ODFEKBJCFMN;
		long num = odfekbjcfmn - 0L;
		if (num > 5L)
		{
			return;
		}
		switch ((uint)num)
		{
		case 0U:
			foreach (ItemBase itemBase in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = (ELNGEFIPDJK.NADBMPJIMEC)itemBase;
				nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 82f);
			}
			this.DLBMLNNAHAF.JKOBKMOIOGL();
			this.DLBMLNNAHAF.HHKCFGAENJN();
			return;
		case 1U:
			this.DLBMLNNAHAF.PLKPBLGIEBL();
			return;
		case 2U:
			foreach (ItemBase itemBase2 in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec2 = (ELNGEFIPDJK.NADBMPJIMEC)itemBase2;
				nadbmpjimec2.tag = (long)(nadbmpjimec2.DGLOPIJHPJN * -185);
			}
			this.DLBMLNNAHAF.GNGINMOFEEH();
			this.DLBMLNNAHAF.HHKCFGAENJN();
			return;
		default:
			return;
		}
	}

	// Token: 0x0600756F RID: 30063 RVA: 0x0037E158 File Offset: 0x0037C358
	public void ILJAFBIGGIH(ONKDCGNBALK PHEMLBHMNCM)
	{
		GUI.Box(PHEMLBHMNCM.OCHCODJIPHJ, "");
		if (this.CFAJEAFEIME == null)
		{
			return;
		}
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperLeft,
			wordWrap = true,
			richText = true
		};
		this.CFAJEAFEIME.JGGGGKHDNIP(PHEMLBHMNCM.OCHCODJIPHJ, 1f, IIBEEKCAAHK.ECOFBCMPIDO, IIBEEKCAAHK.ECOFBCMPIDO, IIBEEKCAAHK.ECOFBCMPIDO, 0);
		if (this.CFAJEAFEIME.EOFDJHJPCLM != null && this.CFAJEAFEIME.EOFDJHJPCLM.KEDGAOBCNJG != null)
		{
			float x = PHEMLBHMNCM.OCHCODJIPHJ.x + 200f - (float)this.CFAJEAFEIME.EOFDJHJPCLM.KEDGAOBCNJG.width / 2f;
			float y = PHEMLBHMNCM.OCHCODJIPHJ.y + 340f - (float)this.CFAJEAFEIME.EOFDJHJPCLM.KEDGAOBCNJG.height / 2f;
			GUI.DrawTexture(new Rect(x, y, (float)this.CFAJEAFEIME.EOFDJHJPCLM.KEDGAOBCNJG.width, (float)this.CFAJEAFEIME.EOFDJHJPCLM.KEDGAOBCNJG.height), this.CFAJEAFEIME.EOFDJHJPCLM.KEDGAOBCNJG);
		}
		guistyle.fontSize = 14;
		guistyle.alignment = TextAnchor.UpperLeft;
		this.GKJKOLMCDDG = GUI.TextField(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 10f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 35f, 65f, 20f), this.GKJKOLMCDDG);
		try
		{
			this.FDKHFDCJBPB = int.Parse(this.GKJKOLMCDDG);
		}
		catch
		{
			this.FDKHFDCJBPB = 1;
		}
		this.FDKHFDCJBPB = Mathf.Clamp(this.FDKHFDCJBPB, 1, 10);
		int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.CFAJEAFEIME.LPFKFNLHGBI, false, 0);
		if (num > 0)
		{
			string text = string.Format(JNBICAJIJMM.LEBHCLDODNI("shop_ycnt"), num);
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 10f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 80f - 20f, PHEMLBHMNCM.OCHCODJIPHJ.width - 20f, 25f), text, guistyle);
		}
		string arg = "#004000";
		if (!this.CFAJEAFEIME.FKEDAOOHPPB.LGOIEIELNBL(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH, this.FDKHFDCJBPB))
		{
			arg = "#400000";
		}
		guistyle.fontSize = 18;
		string text2 = string.Format(JNBICAJIJMM.LEBHCLDODNI("shop_bccost"), arg, this.FDKHFDCJBPB, JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM((long)(this.CFAJEAFEIME.FKEDAOOHPPB.KKNEKAEJLAM * this.FDKHFDCJBPB), (long)(this.CFAJEAFEIME.FKEDAOOHPPB.KFODJJIHNHP * this.FDKHFDCJBPB), false));
		GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 10f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 80f, PHEMLBHMNCM.OCHCODJIPHJ.width - 20f, 25f), text2, guistyle);
		guistyle.fontSize = 14;
		if (this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL > 0)
		{
			string text3 = string.Format(JNBICAJIJMM.LEBHCLDODNI("shop_bccount"), JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL, false, 0));
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL);
			befchfngomi.FCBHHPJLGLC(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 10f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 80f + 22f - 6f, 22f, 22f), befchfngomi.KBGHOIJIPJF, false, 0);
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 10f + 24f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 80f + 22f, PHEMLBHMNCM.OCHCODJIPHJ.width - 20f, 25f), string.Concat(new object[]
			{
				"x",
				this.CFAJEAFEIME.FKEDAOOHPPB.KDIMEMOCJNM * this.FDKHFDCJBPB,
				" ",
				befchfngomi.JPBOPFNPNHC(false, -1),
				text3
			}), guistyle);
		}
	}

	// Token: 0x06007570 RID: 30064 RVA: 0x0037E620 File Offset: 0x0037C820
	private void CJNKFCDFJNE(ONKDCGNBALK OPCILKKDEON)
	{
		long odfekbjcfmn = OPCILKKDEON.ODFEKBJCFMN;
		long num = odfekbjcfmn - 0L;
		if (num > 1L)
		{
			return;
		}
		switch ((uint)num)
		{
		case 0U:
			foreach (ItemBase itemBase in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = (ELNGEFIPDJK.NADBMPJIMEC)itemBase;
				nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 272f);
			}
			this.DLBMLNNAHAF.KINFJHFDHIC();
			this.DLBMLNNAHAF.HHKCFGAENJN();
			return;
		case 1U:
			this.DLBMLNNAHAF.CFHDIMJHBAB();
			return;
		case 2U:
			foreach (ItemBase itemBase2 in this.DLBMLNNAHAF.LACAJHOHACK)
			{
				ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec2 = (ELNGEFIPDJK.NADBMPJIMEC)itemBase2;
				nadbmpjimec2.tag = (long)(nadbmpjimec2.DGLOPIJHPJN * 181);
			}
			this.DLBMLNNAHAF.MGNDPEIFKAN();
			this.DLBMLNNAHAF.DPBINJLALBJ();
			return;
		default:
			return;
		}
	}

	// Token: 0x06007571 RID: 30065 RVA: 0x0037E73C File Offset: 0x0037C93C
	public void NLCLEPLHKEH(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.AFLBAGIJLFH(0, 1188f, Vector3.zero);
		if (KADBECGIMPD.CLPEKGGAMAI() < 0)
		{
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.PJHMHBAGFAN(193f, 122f, JNBICAJIJMM.NGALDMFKMJH("Flap_08.wav"), true);
		ONKDCGNBALK onkdcgnbalk2 = JDCEFOFMGHB.MNJNNDHCDGG().HPCEJKFHNBA(this.PEJGNBMFCDP);
		if (onkdcgnbalk2 != null)
		{
			float num = (onkdcgnbalk2.OCHCODJIPHJ.width + onkdcgnbalk.OCHCODJIPHJ.x + 603f) / 318f;
			onkdcgnbalk2.OCHCODJIPHJ.x = (float)(Screen.width / 5) - num;
			onkdcgnbalk.OCHCODJIPHJ.height = onkdcgnbalk2.OCHCODJIPHJ.height;
			onkdcgnbalk.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y;
			onkdcgnbalk.OCHCODJIPHJ.x = onkdcgnbalk2.OCHCODJIPHJ.x + onkdcgnbalk2.OCHCODJIPHJ.width + 1393f;
		}
		this.DLBMLNNAHAF = new MMKFAENBHKD(onkdcgnbalk, 113f, 1810f, onkdcgnbalk.OCHCODJIPHJ.width - 1241f, onkdcgnbalk.OCHCODJIPHJ.height - 715f, 1)
		{
			JHNCNHAAJCH = 843f
		};
		new MEMEOHJKPNJ(onkdcgnbalk, 1210f, 251f, 80f, 1826f, JNBICAJIJMM.CELEPPAEKAB("USER ID="), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.CJNKFCDFJNE));
		new MEMEOHJKPNJ(onkdcgnbalk, 1390f, 958f, 1729f, 1317f, JNBICAJIJMM.NGALDMFKMJH("<size=14><color='#00d0ff'>{0}</color></size>"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.EEPDPHBNJAK));
		new MEMEOHJKPNJ(onkdcgnbalk, 1570f, 125f, 255f, 1123f, JNBICAJIJMM.DCEBAJIILPC("Soccer Walk"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.OHDNFKBAEPE));
		KADBECGIMPD.KKOKFLMMAAK();
		this.IPOMGIHFANC = KADBECGIMPD.DNGDPHIHLBG();
		this.FCDHFLCDDJF = KADBECGIMPD.DNGDPHIHLBG();
		while (!KADBECGIMPD.DFLKBBNOGBG())
		{
			ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = new ELNGEFIPDJK.NADBMPJIMEC();
			nadbmpjimec.BBJEECNHPAK(KADBECGIMPD);
			nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 1734f);
			nadbmpjimec.onRender = new ItemBase.OOALOMPKIKK(this.JKPAHNHDOLD);
			this.DLBMLNNAHAF.LACAJHOHACK.Add(nadbmpjimec);
		}
		this.DLBMLNNAHAF.KCLLDJJLCGC = -114;
		this.DLBMLNNAHAF.JKOBKMOIOGL();
		this.DLBMLNNAHAF.LGLPHCMBBDP();
		this.DLBMLNNAHAF.AEMFOALOHDD(1);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1702f - 189f, onkdcgnbalk.OCHCODJIPHJ.height - 1892f, 1154f, 1499f, JNBICAJIJMM.BDKHMOOFHHK("wpn_lv"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().BLPLADOIPJG));
	}

	// Token: 0x06007572 RID: 30066 RVA: 0x0037E9FC File Offset: 0x0037CBFC
	public void EFOKJCNMIOG(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.CNGKCDLJEDG(1, 841f, Vector3.zero);
		if (KADBECGIMPD.HDBGOLAFOBK() < 0)
		{
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().DKOFCBMKEPC(1117f, 1312f, JNBICAJIJMM.PGJCPFNJNPM("http://j.mp/1gxg1tf"), false);
		ONKDCGNBALK onkdcgnbalk2 = JDCEFOFMGHB.IKGFHGKKCPG.HPCEJKFHNBA(this.PEJGNBMFCDP);
		if (onkdcgnbalk2 != null)
		{
			float num = (onkdcgnbalk2.OCHCODJIPHJ.width + onkdcgnbalk.OCHCODJIPHJ.x + 1468f) / 946f;
			onkdcgnbalk2.OCHCODJIPHJ.x = (float)(Screen.width / 2) - num;
			onkdcgnbalk.OCHCODJIPHJ.height = onkdcgnbalk2.OCHCODJIPHJ.height;
			onkdcgnbalk.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y;
			onkdcgnbalk.OCHCODJIPHJ.x = onkdcgnbalk2.OCHCODJIPHJ.x + onkdcgnbalk2.OCHCODJIPHJ.width + 1808f;
		}
		this.DLBMLNNAHAF = new MMKFAENBHKD(onkdcgnbalk, 12f, 1434f, onkdcgnbalk.OCHCODJIPHJ.width - 1290f, onkdcgnbalk.OCHCODJIPHJ.height - 1221f, 1)
		{
			JHNCNHAAJCH = 1128f
		};
		new MEMEOHJKPNJ(onkdcgnbalk, 1799f, 1854f, 1968f, 122f, JNBICAJIJMM.PGJCPFNJNPM("VolumetricFogAndMist/CopyDepth"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.CJNKFCDFJNE));
		new MEMEOHJKPNJ(onkdcgnbalk, 551f, 1017f, 757f, 1943f, JNBICAJIJMM.LEBHCLDODNI("Open openTurnirWindow"), 5, null, new ONKDCGNBALK.CMMHGMILOIM(this.PNMIAAGIKAH));
		new MEMEOHJKPNJ(onkdcgnbalk, 926f, 536f, 1328f, 484f, JNBICAJIJMM.BDKHMOOFHHK("FASTEST"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.GNPCOCIILBF));
		KADBECGIMPD.AGNKAFLKCAG();
		this.IPOMGIHFANC = KADBECGIMPD.BNDHIBEOKML();
		this.FCDHFLCDDJF = KADBECGIMPD.FFDPCEAFGNF();
		while (!KADBECGIMPD.INLBHLOLOJH())
		{
			ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = new ELNGEFIPDJK.NADBMPJIMEC();
			nadbmpjimec.PHJLPFHDIBP(KADBECGIMPD);
			nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 1694f);
			nadbmpjimec.onRender = new ItemBase.OOALOMPKIKK(this.MABBFBHGJKH);
			this.DLBMLNNAHAF.LACAJHOHACK.Add(nadbmpjimec);
		}
		this.DLBMLNNAHAF.KCLLDJJLCGC = 25;
		this.DLBMLNNAHAF.KINFJHFDHIC();
		this.DLBMLNNAHAF.LFDHFFBCJIF();
		this.DLBMLNNAHAF.AGFFDCECLBF(1);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 514f - 270f, onkdcgnbalk.OCHCODJIPHJ.height - 1537f, 272f, 802f, JNBICAJIJMM.PGJCPFNJNPM("InteractionObject Multiplier 'Curve' "), 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.ODBGHCIJOHA));
	}

	// Token: 0x06007573 RID: 30067 RVA: 0x0037ECBC File Offset: 0x0037CEBC
	public void KPFLMEHIGLE(ONKDCGNBALK PHEMLBHMNCM)
	{
		GUI.Box(PHEMLBHMNCM.OCHCODJIPHJ, "file://");
		if (this.CFAJEAFEIME == null)
		{
			return;
		}
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperLeft,
			wordWrap = false,
			richText = false
		};
		this.CFAJEAFEIME.PPLCKLBMCPE(PHEMLBHMNCM.OCHCODJIPHJ, 27f, IIBEEKCAAHK.ECOFBCMPIDO, IIBEEKCAAHK.HLOLNGEKIIH(), IIBEEKCAAHK.ECOFBCMPIDO, 0);
		if (this.CFAJEAFEIME.EOFDJHJPCLM != null && this.CFAJEAFEIME.EOFDJHJPCLM.MLPBJEFJDHM() != null)
		{
			float x = PHEMLBHMNCM.OCHCODJIPHJ.x + 1528f - (float)this.CFAJEAFEIME.EOFDJHJPCLM.MLPBJEFJDHM().width / 797f;
			float y = PHEMLBHMNCM.OCHCODJIPHJ.y + 1201f - (float)this.CFAJEAFEIME.EOFDJHJPCLM.PFFJJEJNKPB().height / 1526f;
			GUI.DrawTexture(new Rect(x, y, (float)this.CFAJEAFEIME.EOFDJHJPCLM.MMKLLFCKCAG().width, (float)this.CFAJEAFEIME.EOFDJHJPCLM.NIOGJOFLPLH().height), this.CFAJEAFEIME.EOFDJHJPCLM.HFNHCIGCOBE());
		}
		guistyle.fontSize = -88;
		guistyle.alignment = TextAnchor.UpperCenter;
		this.GKJKOLMCDDG = GUI.TextField(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1285f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 1583f, 431f, 1849f), this.GKJKOLMCDDG);
		try
		{
			this.FDKHFDCJBPB = int.Parse(this.GKJKOLMCDDG);
		}
		catch
		{
			this.FDKHFDCJBPB = 0;
		}
		this.FDKHFDCJBPB = Mathf.Clamp(this.FDKHFDCJBPB, 1, 108);
		int num = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BJDIEKNHGLJ(this.CFAJEAFEIME.LPFKFNLHGBI, false, 1);
		if (num > 1)
		{
			string text = string.Format(JNBICAJIJMM.PGJCPFNJNPM("#002000"), num);
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 528f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 464f - 1674f, PHEMLBHMNCM.OCHCODJIPHJ.width - 367f, 468f), text, guistyle);
		}
		string arg = "6";
		if (!this.CFAJEAFEIME.FKEDAOOHPPB.LIKMNACOFJE(JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH, this.FDKHFDCJBPB))
		{
			arg = "Mutilate";
		}
		guistyle.fontSize = -73;
		string text2 = string.Format(JNBICAJIJMM.CELEPPAEKAB("wpn_add/base"), arg, this.FDKHFDCJBPB, JLFJEGIPIMM.NNEAHAFBOHC().MNMIJFNPIPI((long)(this.CFAJEAFEIME.FKEDAOOHPPB.KKNEKAEJLAM * this.FDKHFDCJBPB), (long)(this.CFAJEAFEIME.FKEDAOOHPPB.KFODJJIHNHP * this.FDKHFDCJBPB), true));
		GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1959f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 286f, PHEMLBHMNCM.OCHCODJIPHJ.width - 673f, 31f), text2, guistyle);
		guistyle.fontSize = -28;
		if (this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL > 1)
		{
			string text3 = string.Format(JNBICAJIJMM.CELEPPAEKAB("SneakLeft"), JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BJDIEKNHGLJ(this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL, false, 0));
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().GBKMHIGNKJA(this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL);
			befchfngomi.FCBHHPJLGLC(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1639f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 978f + 385f - 1034f, 1577f, 1377f), befchfngomi.KBGHOIJIPJF, true, 0);
			Rect position = new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1088f + 1452f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 578f + 1479f, PHEMLBHMNCM.OCHCODJIPHJ.width - 823f, 880f);
			object[] array = new object[0];
			array[1] = "_ColorBuffer";
			array[0] = this.CFAJEAFEIME.FKEDAOOHPPB.KDIMEMOCJNM * this.FDKHFDCJBPB;
			array[0] = "cntx_drop";
			array[4] = befchfngomi.MPKGPJJKCPK(false, -1);
			array[4] = text3;
			GUI.Label(position, string.Concat(array), guistyle);
		}
	}

	// Token: 0x06007574 RID: 30068 RVA: 0x0037F184 File Offset: 0x0037D384
	public void AAGGLHKIKDI(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.GMBEHOGPEDI(1, 253f, Vector3.zero);
		if (KADBECGIMPD.HDBGOLAFOBK() < 0)
		{
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.PLHAGCDJLPA(38f, 1047f, JNBICAJIJMM.BDKHMOOFHHK("\n"), true);
		ONKDCGNBALK onkdcgnbalk2 = JDCEFOFMGHB.IKGFHGKKCPG.FDMNKDONMFM(this.PEJGNBMFCDP);
		if (onkdcgnbalk2 != null)
		{
			float num = (onkdcgnbalk2.OCHCODJIPHJ.width + onkdcgnbalk.OCHCODJIPHJ.x + 1191f) / 1012f;
			onkdcgnbalk2.OCHCODJIPHJ.x = (float)(Screen.width / 7) - num;
			onkdcgnbalk.OCHCODJIPHJ.height = onkdcgnbalk2.OCHCODJIPHJ.height;
			onkdcgnbalk.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y;
			onkdcgnbalk.OCHCODJIPHJ.x = onkdcgnbalk2.OCHCODJIPHJ.x + onkdcgnbalk2.OCHCODJIPHJ.width + 31f;
		}
		this.DLBMLNNAHAF = new MMKFAENBHKD(onkdcgnbalk, 1625f, 548f, onkdcgnbalk.OCHCODJIPHJ.width - 1390f, onkdcgnbalk.OCHCODJIPHJ.height - 1675f, 1)
		{
			JHNCNHAAJCH = 401f
		};
		new MEMEOHJKPNJ(onkdcgnbalk, 1129f, 600f, 561f, 1919f, JNBICAJIJMM.PPNKMDJBMLP("Hidden/Post FX/Uber Shader"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.HFALPFJFKNO));
		new MEMEOHJKPNJ(onkdcgnbalk, 1683f, 1194f, 473f, 1934f, JNBICAJIJMM.NGALDMFKMJH("Ring"), 7, null, new ONKDCGNBALK.CMMHGMILOIM(this.OHDNFKBAEPE));
		new MEMEOHJKPNJ(onkdcgnbalk, 1854f, 1555f, 255f, 1691f, JNBICAJIJMM.LEBHCLDODNI("Press C key to create a cloud-shape fog area, B for box-shape fog area, X to remove all."), 5, null, new ONKDCGNBALK.CMMHGMILOIM(this.GNPCOCIILBF));
		KADBECGIMPD.KDNDJNEGBDI();
		this.IPOMGIHFANC = KADBECGIMPD.BNDHIBEOKML();
		this.FCDHFLCDDJF = KADBECGIMPD.CNNEPCOAMJK();
		while (!KADBECGIMPD.IBMMOGHFCCE())
		{
			ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = new ELNGEFIPDJK.NADBMPJIMEC();
			nadbmpjimec.IGHPCGGMHOO(KADBECGIMPD);
			nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 1682f);
			nadbmpjimec.onRender = new ItemBase.OOALOMPKIKK(this.JKPAHNHDOLD);
			this.DLBMLNNAHAF.LACAJHOHACK.Add(nadbmpjimec);
		}
		this.DLBMLNNAHAF.KCLLDJJLCGC = -78;
		this.DLBMLNNAHAF.KINFJHFDHIC();
		this.DLBMLNNAHAF.HHKCFGAENJN();
		this.DLBMLNNAHAF.PDEGHKDPJFP(0);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1007f - 726f, onkdcgnbalk.OCHCODJIPHJ.height - 1994f, 1015f, 80f, JNBICAJIJMM.PPNKMDJBMLP("_FogAreaPosition"), 4, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().IBCKNOEANLN));
	}

	// Token: 0x06007575 RID: 30069 RVA: 0x0037F444 File Offset: 0x0037D644
	public void PFFPCAMAFMM(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.sendAction(1, 4f, Vector3.zero);
		if (KADBECGIMPD.HDBGOLAFOBK() < 0)
		{
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(400f, 560f, JNBICAJIJMM.LEBHCLDODNI("fshop_hd1"), true);
		ONKDCGNBALK onkdcgnbalk2 = JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(this.PEJGNBMFCDP);
		if (onkdcgnbalk2 != null)
		{
			float num = (onkdcgnbalk2.OCHCODJIPHJ.width + onkdcgnbalk.OCHCODJIPHJ.x + 20f) / 2f;
			onkdcgnbalk2.OCHCODJIPHJ.x = (float)(Screen.width / 2) - num;
			onkdcgnbalk.OCHCODJIPHJ.height = onkdcgnbalk2.OCHCODJIPHJ.height;
			onkdcgnbalk.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y;
			onkdcgnbalk.OCHCODJIPHJ.x = onkdcgnbalk2.OCHCODJIPHJ.x + onkdcgnbalk2.OCHCODJIPHJ.width + 20f;
		}
		this.DLBMLNNAHAF = new MMKFAENBHKD(onkdcgnbalk, 20f, 85f, onkdcgnbalk.OCHCODJIPHJ.width - 40f, onkdcgnbalk.OCHCODJIPHJ.height - 145f, 0)
		{
			JHNCNHAAJCH = 50f
		};
		new MEMEOHJKPNJ(onkdcgnbalk, 20f, 52f, 100f, 22f, JNBICAJIJMM.LEBHCLDODNI("fshop_ks1"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.AOBKGDIJGDJ));
		new MEMEOHJKPNJ(onkdcgnbalk, 125f, 52f, 100f, 22f, JNBICAJIJMM.LEBHCLDODNI("fshop_ks2"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(this.AOBKGDIJGDJ));
		new MEMEOHJKPNJ(onkdcgnbalk, 230f, 52f, 100f, 22f, JNBICAJIJMM.LEBHCLDODNI("fshop_ks3"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(this.AOBKGDIJGDJ));
		KADBECGIMPD.HDBGOLAFOBK();
		this.IPOMGIHFANC = KADBECGIMPD.FFDPCEAFGNF();
		this.FCDHFLCDDJF = KADBECGIMPD.FFDPCEAFGNF();
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = new ELNGEFIPDJK.NADBMPJIMEC();
			nadbmpjimec.ACJDDOEADFK(KADBECGIMPD);
			nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 1000f);
			nadbmpjimec.onRender = new ItemBase.OOALOMPKIKK(this.LMPDNMBDLFO);
			this.DLBMLNNAHAF.LACAJHOHACK.Add(nadbmpjimec);
		}
		this.DLBMLNNAHAF.KCLLDJJLCGC = 11;
		this.DLBMLNNAHAF.MGNDPEIFKAN();
		this.DLBMLNNAHAF.CFIBADPGBGI();
		this.DLBMLNNAHAF.IHEILFHMLAG = 0;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 64f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("cntx_close"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
	}

	// Token: 0x06007576 RID: 30070 RVA: 0x0037F704 File Offset: 0x0037D904
	public void LMAFKFBAAGG(ONKDCGNBALK OJIMHKHFOJI)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_04.wav", 1f);
		if (this.PFDDJMOBGLG[this.MKFFJNKCDHL] != null)
		{
			this.PFDDJMOBGLG[this.MKFFJNKCDHL].HKPAEGGJNGG = false;
		}
		if ((long)this.MKFFJNKCDHL == OJIMHKHFOJI.ODFEKBJCFMN)
		{
			return;
		}
		this.MKFFJNKCDHL = (int)OJIMHKHFOJI.ODFEKBJCFMN;
		this.PFDDJMOBGLG[this.MKFFJNKCDHL].HKPAEGGJNGG = true;
		Debug.Log("mask=" + OJIMHKHFOJI.FNPEGDKBKJC);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(this.LEDPIGHPLBP);
			epmphjgalbe.NEHCMOODKIN(OJIMHKHFOJI.FNPEGDKBKJC);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1300, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x06007577 RID: 30071 RVA: 0x0037F7E4 File Offset: 0x0037D9E4
	public void NLMOLMLPBPK(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.CNGKCDLJEDG(1, 1974f, Vector3.zero);
		this.LEDPIGHPLBP = KADBECGIMPD.HDBGOLAFOBK();
		JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(true);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.DKOFCBMKEPC(1588f, 717f, JNBICAJIJMM.PGJCPFNJNPM("Swim Freestyle"), false);
		this.PEJGNBMFCDP = onkdcgnbalk.LPFKFNLHGBI;
		this.OJJLLBKEGNO = new MMKFAENBHKD(onkdcgnbalk, 268f, 417f, 701f, onkdcgnbalk.OCHCODJIPHJ.height - 458f, 0);
		while (!KADBECGIMPD.NNOJEFMEGEG())
		{
			ELNGEFIPDJK.DKLIGJOMDJK dkligjomdjk = new ELNGEFIPDJK.DKLIGJOMDJK();
			dkligjomdjk.BNBGJPJMPAC(KADBECGIMPD);
			this.OJJLLBKEGNO.LACAJHOHACK.Add(dkligjomdjk);
		}
		this.OJJLLBKEGNO.JHNCNHAAJCH = 362f;
		this.OJJLLBKEGNO.KCLLDJJLCGC = 35;
		this.OJJLLBKEGNO.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.OEHCIHFOHJK);
		this.OJJLLBKEGNO.BJLCAGOJDNM(1);
		this.OJJLLBKEGNO.IJEHPMOIPAA();
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, this.OJJLLBKEGNO.OCHCODJIPHJ.x + this.OJJLLBKEGNO.OCHCODJIPHJ.width + 1370f, 1019f, 5f, 739f, "final ok: ", 0, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.LBGPPCIEOFK)
		};
		MEMEOHJKPNJ memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x, onkdcgnbalk.OCHCODJIPHJ.height - 388f, 1287f, 1660f, JNBICAJIJMM.PGJCPFNJNPM(""), 70, null, new ONKDCGNBALK.CMMHGMILOIM(this.KODOABLENCC))
		{
			FNMCIACNOMH = FlyMessageManager.getI.JFDCLBPFLNI(127)
		};
		memeohjkpnj.OGFLIGFJBFG(GuiProcessor.PLGADNLAEGN().vipKeyTex, 578f);
		memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 1961f + 1318f, onkdcgnbalk.OCHCODJIPHJ.height - 1569f, 229f, 1572f, JNBICAJIJMM.CELEPPAEKAB("isWoman"), 116, null, new ONKDCGNBALK.CMMHGMILOIM(this.FJPICNELDJP))
		{
			FNMCIACNOMH = FlyMessageManager.getI.NGDLNNPNHBL(80)
		};
		memeohjkpnj.JKMDIBLBMDL(GuiProcessor.NKOEAPCIBKO().vipKeyTex, 1574f);
		if (this.CODAIBGMFCA == null)
		{
			memeohjkpnj.FNMCIACNOMH = true;
		}
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count <= 1)
		{
			memeohjkpnj.FNMCIACNOMH = true;
		}
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 153f - 362f, onkdcgnbalk.OCHCODJIPHJ.height - 1982f, 1687f, 732f, JNBICAJIJMM.CDDCIKKDFMP("mid"), 4, null, new ONKDCGNBALK.CMMHGMILOIM(this.LMPDOBPPLOJ));
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count <= 1)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().CBHHEHHNFKL(onkdcgnbalk.LPFKFNLHGBI);
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.PPNKMDJBMLP("3"), JNBICAJIJMM.OOOKJHOHPNN("droplinemsg1"));
		}
	}

	// Token: 0x06007578 RID: 30072 RVA: 0x003784D2 File Offset: 0x003766D2
	public void OEHCIHFOHJK(MMKFAENBHKD OCKMAJALKMN, object HEABEPINGED)
	{
		this.CODAIBGMFCA = (HEABEPINGED as ELNGEFIPDJK.DKLIGJOMDJK);
	}

	// Token: 0x06007579 RID: 30073 RVA: 0x0037FAEC File Offset: 0x0037DCEC
	public void EHHNDFPMKHD(ONKDCGNBALK OJIMHKHFOJI)
	{
		Fisherman.getI.sendAction(3, 12f, Vector3.zero);
		if (!this.CFAJEAFEIME.FKEDAOOHPPB.LGOIEIELNBL(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH, this.FDKHFDCJBPB) || !this.CFAJEAFEIME.GBABFPMNIMP)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
			return;
		}
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn == 1L)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO(1f, 2, JNBICAJIJMM.LEBHCLDODNI("shop_wl"), new ONKDCGNBALK.CMMHGMILOIM(this.EHHNDFPMKHD), false);
			return;
		}
		if (odfekbjcfmn != 2L)
		{
			return;
		}
		Debug.Log("BuY");
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(this.LEDPIGHPLBP);
			epmphjgalbe.GOMLLPFFPNP(this.CFAJEAFEIME.LPFKFNLHGBI);
			epmphjgalbe.GOMLLPFFPNP(this.FDKHFDCJBPB);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1310, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x0600757A RID: 30074 RVA: 0x0037FBF8 File Offset: 0x0037DDF8
	public void OBMCDPCHFLN(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.sendAction(0, 1274f, Vector3.zero);
		this.LEDPIGHPLBP = KADBECGIMPD.CLPEKGGAMAI();
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().PJHMHBAGFAN(849f, 1978f, JNBICAJIJMM.CELEPPAEKAB("cntx_close"), true);
		this.PEJGNBMFCDP = onkdcgnbalk.LPFKFNLHGBI;
		this.OJJLLBKEGNO = new MMKFAENBHKD(onkdcgnbalk, 383f, 836f, 1404f, onkdcgnbalk.OCHCODJIPHJ.height - 1828f, 1);
		while (!KADBECGIMPD.NNOJEFMEGEG())
		{
			ELNGEFIPDJK.DKLIGJOMDJK dkligjomdjk = new ELNGEFIPDJK.DKLIGJOMDJK();
			dkligjomdjk.CMEFHGFMAAK(KADBECGIMPD);
			this.OJJLLBKEGNO.LACAJHOHACK.Add(dkligjomdjk);
		}
		this.OJJLLBKEGNO.JHNCNHAAJCH = 182f;
		this.OJJLLBKEGNO.KCLLDJJLCGC = -60;
		this.OJJLLBKEGNO.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.PMPNBIOJNJE);
		this.OJJLLBKEGNO.PDEGHKDPJFP(1);
		this.OJJLLBKEGNO.NIJOHIBNLEI();
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, this.OJJLLBKEGNO.OCHCODJIPHJ.x + this.OJJLLBKEGNO.OCHCODJIPHJ.width + 1468f, 150f, 737f, 1599f, "FlyDown", 0, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.ECNAMIIHCNC)
		};
		MEMEOHJKPNJ memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x, onkdcgnbalk.OCHCODJIPHJ.height - 1870f, 1898f, 1718f, JNBICAJIJMM.NGALDMFKMJH("_BlurFilterDistance"), -18, null, new ONKDCGNBALK.CMMHGMILOIM(this.BGJHJIKLNAF))
		{
			FNMCIACNOMH = FlyMessageManager.getI.MMIMPMPGHPN(-24)
		};
		memeohjkpnj.EONGFJFPGGD(GuiProcessor.PLGADNLAEGN().vipKeyTex, 1616f);
		memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 331f + 1264f, onkdcgnbalk.OCHCODJIPHJ.height - 928f, 446f, 480f, JNBICAJIJMM.OOOKJHOHPNN("\n"), -79, null, new ONKDCGNBALK.CMMHGMILOIM(this.CDFNLMPOEKH))
		{
			FNMCIACNOMH = FlyMessageManager.getI.MMIMPMPGHPN(61)
		};
		memeohjkpnj.JKMDIBLBMDL(GuiProcessor.PLGADNLAEGN().vipKeyTex, 1317f);
		if (this.CODAIBGMFCA == null)
		{
			memeohjkpnj.FNMCIACNOMH = true;
		}
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count <= 0)
		{
			memeohjkpnj.FNMCIACNOMH = true;
		}
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 492f - 575f, onkdcgnbalk.OCHCODJIPHJ.height - 702f, 567f, 653f, JNBICAJIJMM.CELEPPAEKAB("NEW FISH!"), 4, null, new ONKDCGNBALK.CMMHGMILOIM(this.KODOABLENCC));
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count <= 1)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().BMOFIBGMIBK(onkdcgnbalk.LPFKFNLHGBI);
			JDCEFOFMGHB.HMJJPNDEKPP().NODOOHPCCCB(JNBICAJIJMM.DCEBAJIILPC("WeaponRunBackward"), JNBICAJIJMM.DIOJFJMOPJO("DepthTolerance"));
		}
	}

	// Token: 0x0600757B RID: 30075 RVA: 0x0037FF00 File Offset: 0x0037E100
	public void CFFJPIIOOHB(ONKDCGNBALK PHEMLBHMNCM)
	{
		GUI.Box(PHEMLBHMNCM.OCHCODJIPHJ, "Katana Horizontal Swing");
		if (this.CFAJEAFEIME == null)
		{
			return;
		}
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperLeft,
			wordWrap = true,
			richText = false
		};
		this.CFAJEAFEIME.PPLCKLBMCPE(PHEMLBHMNCM.OCHCODJIPHJ, 344f, IIBEEKCAAHK.HLOLNGEKIIH(), IIBEEKCAAHK.HLOLNGEKIIH(), IIBEEKCAAHK.IMJHKMLHDJH(), 0);
		if (this.CFAJEAFEIME.EOFDJHJPCLM != null && this.CFAJEAFEIME.EOFDJHJPCLM.AEIIBNOFLCM() != null)
		{
			float x = PHEMLBHMNCM.OCHCODJIPHJ.x + 1167f - (float)this.CFAJEAFEIME.EOFDJHJPCLM.KEDGAOBCNJG.width / 114f;
			float y = PHEMLBHMNCM.OCHCODJIPHJ.y + 1527f - (float)this.CFAJEAFEIME.EOFDJHJPCLM.PFFJJEJNKPB().height / 1601f;
			GUI.DrawTexture(new Rect(x, y, (float)this.CFAJEAFEIME.EOFDJHJPCLM.MMKLLFCKCAG().width, (float)this.CFAJEAFEIME.EOFDJHJPCLM.IOHNCGLFGDJ().height), this.CFAJEAFEIME.EOFDJHJPCLM.NIOGJOFLPLH());
		}
		guistyle.fontSize = 70;
		guistyle.alignment = TextAnchor.UpperLeft;
		this.GKJKOLMCDDG = GUI.TextField(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 583f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 1736f, 1941f, 652f), this.GKJKOLMCDDG);
		try
		{
			this.FDKHFDCJBPB = int.Parse(this.GKJKOLMCDDG);
		}
		catch
		{
			this.FDKHFDCJBPB = 0;
		}
		this.FDKHFDCJBPB = Mathf.Clamp(this.FDKHFDCJBPB, 0, -19);
		int num = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BJDIEKNHGLJ(this.CFAJEAFEIME.LPFKFNLHGBI, true, 1);
		if (num > 1)
		{
			string text = string.Format(JNBICAJIJMM.PPNKMDJBMLP("MotorbikeLassoBack"), num);
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 509f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 45f - 1574f, PHEMLBHMNCM.OCHCODJIPHJ.width - 819f, 848f), text, guistyle);
		}
		string arg = "System.Boolean";
		if (!this.CFAJEAFEIME.FKEDAOOHPPB.NEDBEDHMFJL(JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH, this.FDKHFDCJBPB))
		{
			arg = "6";
		}
		guistyle.fontSize = 90;
		string text2 = string.Format(JNBICAJIJMM.CELEPPAEKAB("DITHER_ON"), arg, this.FDKHFDCJBPB, JLFJEGIPIMM.MHFDIJGJGBJ().MNMIJFNPIPI((long)(this.CFAJEAFEIME.FKEDAOOHPPB.KKNEKAEJLAM * this.FDKHFDCJBPB), (long)(this.CFAJEAFEIME.FKEDAOOHPPB.KFODJJIHNHP * this.FDKHFDCJBPB), true));
		GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 120f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 569f, PHEMLBHMNCM.OCHCODJIPHJ.width - 1211f, 1873f), text2, guistyle);
		guistyle.fontSize = -55;
		if (this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL > 1)
		{
			string text3 = string.Format(JNBICAJIJMM.DIOJFJMOPJO("crft_norec2"), JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BJDIEKNHGLJ(this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL, true, 1));
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().NKMGKJLONDK(this.CFAJEAFEIME.FKEDAOOHPPB.GIEALCKLKNL);
			befchfngomi.GDLELABHHFG(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 657f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 904f + 1053f - 1321f, 1405f, 1977f), befchfngomi.KBGHOIJIPJF, true, 1);
			Rect position = new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 726f + 1782f, PHEMLBHMNCM.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.height - 1244f + 18f, PHEMLBHMNCM.OCHCODJIPHJ.width - 703f, 964f);
			object[] array = new object[0];
			array[0] = "CardPlayerIdle";
			array[0] = this.CFAJEAFEIME.FKEDAOOHPPB.KDIMEMOCJNM * this.FDKHFDCJBPB;
			array[8] = "RollerBladeGrindRoyale";
			array[0] = befchfngomi.MPKGPJJKCPK(true, -1);
			array[8] = text3;
			GUI.Label(position, string.Concat(array), guistyle);
		}
	}

	// Token: 0x0600757C RID: 30076 RVA: 0x003803C8 File Offset: 0x0037E5C8
	public void LFFJHCPAOBC(ONKDCGNBALK OJIMHKHFOJI)
	{
		Fisherman.getI.CNGKCDLJEDG(4, 840f, Vector3.zero);
		if (!this.CFAJEAFEIME.FKEDAOOHPPB.LMIDHPINCKN(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH, this.FDKHFDCJBPB) || !this.CFAJEAFEIME.GBABFPMNIMP)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("HandPoint", 461f);
			return;
		}
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn == 0L)
		{
			JDCEFOFMGHB.JFIDAGABKID().NOIEEEIONNG(15f, 3, JNBICAJIJMM.LEBHCLDODNI("3"), new ONKDCGNBALK.CMMHGMILOIM(this.MKPEBPIHHJB), true);
			return;
		}
		if (odfekbjcfmn != 4L)
		{
			return;
		}
		Debug.Log("BackPackOff");
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.KPCGLGHDILI(this.LEDPIGHPLBP);
			epmphjgalbe.AEMAHNDEBKJ(this.CFAJEAFEIME.LPFKFNLHGBI);
			epmphjgalbe.DEHJNGMHGAJ(this.FDKHFDCJBPB);
			NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(-181, epmphjgalbe.PBOPEDMCKDD());
		}
		finally
		{
			epmphjgalbe.KNPHNLLMJKJ();
		}
	}

	// Token: 0x0600757D RID: 30077 RVA: 0x003804D4 File Offset: 0x0037E6D4
	public void PIDIFBNDEMD(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.sendAction(1, 1151f, Vector3.zero);
		this.LEDPIGHPLBP = KADBECGIMPD.IFDFHJLCHAE();
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().PLHAGCDJLPA(818f, 13f, JNBICAJIJMM.LEBHCLDODNI(" (hair back)"), false);
		this.PEJGNBMFCDP = onkdcgnbalk.LPFKFNLHGBI;
		this.OJJLLBKEGNO = new MMKFAENBHKD(onkdcgnbalk, 318f, 1064f, 326f, onkdcgnbalk.OCHCODJIPHJ.height - 1610f, 0);
		while (!KADBECGIMPD.NNOJEFMEGEG())
		{
			ELNGEFIPDJK.DKLIGJOMDJK dkligjomdjk = new ELNGEFIPDJK.DKLIGJOMDJK();
			dkligjomdjk.MDLNEBJIGJI(KADBECGIMPD);
			this.OJJLLBKEGNO.LACAJHOHACK.Add(dkligjomdjk);
		}
		this.OJJLLBKEGNO.JHNCNHAAJCH = 928f;
		this.OJJLLBKEGNO.KCLLDJJLCGC = 23;
		this.OJJLLBKEGNO.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.OEHCIHFOHJK);
		this.OJJLLBKEGNO.OEIOEBCGMJE(0);
		this.OJJLLBKEGNO.PHHNPGFNNCB();
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, this.OJJLLBKEGNO.OCHCODJIPHJ.x + this.OJJLLBKEGNO.OCHCODJIPHJ.width + 43f, 126f, 975f, 1685f, "TOD_CloudColor", 1, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.ECNAMIIHCNC)
		};
		MEMEOHJKPNJ memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x, onkdcgnbalk.OCHCODJIPHJ.height - 432f, 326f, 1196f, JNBICAJIJMM.LEBHCLDODNI("USE_CORNER_DETECTION"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.LMPDOBPPLOJ))
		{
			FNMCIACNOMH = FlyMessageManager.getI.JFDCLBPFLNI(-67)
		};
		memeohjkpnj.OAGDPNGOLIG(GuiProcessor.BBLINJLBAIL().vipKeyTex, 355f);
		memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 692f + 516f, onkdcgnbalk.OCHCODJIPHJ.height - 936f, 1935f, 1077f, JNBICAJIJMM.CELEPPAEKAB("IdleStandingJump"), -121, null, new ONKDCGNBALK.CMMHGMILOIM(this.ILCBAPCMFNL))
		{
			FNMCIACNOMH = FlyMessageManager.getI.EDAAJDDIGNE(70)
		};
		memeohjkpnj.EDLPHHCCEJE(GuiProcessor.IKGFHGKKCPG.vipKeyTex, 1482f);
		if (this.CODAIBGMFCA == null)
		{
			memeohjkpnj.FNMCIACNOMH = false;
		}
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count <= 1)
		{
			memeohjkpnj.FNMCIACNOMH = true;
		}
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 939f - 120f, onkdcgnbalk.OCHCODJIPHJ.height - 1958f, 391f, 1500f, JNBICAJIJMM.NGALDMFKMJH("Detects common types of wall hack cheating: walking through the walls (Rigidbody and CharacterController modules), shooting through the walls (Raycast module), looking through the walls (Wireframe module)."), 5, null, new ONKDCGNBALK.CMMHGMILOIM(this.FJPICNELDJP));
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count <= 0)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BMOFIBGMIBK(onkdcgnbalk.LPFKFNLHGBI);
			JDCEFOFMGHB.JFIDAGABKID().BEIDJANKEFD(JNBICAJIJMM.BDKHMOOFHHK("Mouse X"), JNBICAJIJMM.BDKHMOOFHHK("BAG"));
		}
	}

	// Token: 0x0600757E RID: 30078 RVA: 0x003807DC File Offset: 0x0037E9DC
	public void AHHHEKLIKKA(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.sendAction(1, 882f, Vector3.zero);
		if (KADBECGIMPD.DOJKJHMJJNK() < 0)
		{
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().NCIDDNIKACI(448f, 1227f, JNBICAJIJMM.PGJCPFNJNPM("invn_rec26"), true);
		ONKDCGNBALK onkdcgnbalk2 = JDCEFOFMGHB.MNJNNDHCDGG().HPCEJKFHNBA(this.PEJGNBMFCDP);
		if (onkdcgnbalk2 != null)
		{
			float num = (onkdcgnbalk2.OCHCODJIPHJ.width + onkdcgnbalk.OCHCODJIPHJ.x + 1558f) / 1755f;
			onkdcgnbalk2.OCHCODJIPHJ.x = (float)(Screen.width / 0) - num;
			onkdcgnbalk.OCHCODJIPHJ.height = onkdcgnbalk2.OCHCODJIPHJ.height;
			onkdcgnbalk.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y;
			onkdcgnbalk.OCHCODJIPHJ.x = onkdcgnbalk2.OCHCODJIPHJ.x + onkdcgnbalk2.OCHCODJIPHJ.width + 237f;
		}
		this.DLBMLNNAHAF = new MMKFAENBHKD(onkdcgnbalk, 710f, 481f, onkdcgnbalk.OCHCODJIPHJ.width - 1048f, onkdcgnbalk.OCHCODJIPHJ.height - 935f, 1)
		{
			JHNCNHAAJCH = 1152f
		};
		new MEMEOHJKPNJ(onkdcgnbalk, 602f, 1362f, 807f, 1336f, JNBICAJIJMM.CDDCIKKDFMP("IdleMouthWipe"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.JOBAHKGLNMD));
		new MEMEOHJKPNJ(onkdcgnbalk, 1290f, 1737f, 510f, 247f, JNBICAJIJMM.PPNKMDJBMLP("<color='#a0b0a0'>{0}</color><color='#50e020'>$</color>"), 7, null, new ONKDCGNBALK.CMMHGMILOIM(this.PNMIAAGIKAH));
		new MEMEOHJKPNJ(onkdcgnbalk, 61f, 493f, 326f, 681f, JNBICAJIJMM.PPNKMDJBMLP("space"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.AOBKGDIJGDJ));
		KADBECGIMPD.AGNKAFLKCAG();
		this.IPOMGIHFANC = KADBECGIMPD.DNGDPHIHLBG();
		this.FCDHFLCDDJF = KADBECGIMPD.CNNEPCOAMJK();
		while (!KADBECGIMPD.NNOJEFMEGEG())
		{
			ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = new ELNGEFIPDJK.NADBMPJIMEC();
			nadbmpjimec.JCFIDPHLFLB(KADBECGIMPD);
			nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 1209f);
			nadbmpjimec.onRender = new ItemBase.OOALOMPKIKK(this.NAMJLOBFEMC);
			this.DLBMLNNAHAF.LACAJHOHACK.Add(nadbmpjimec);
		}
		this.DLBMLNNAHAF.KCLLDJJLCGC = -99;
		this.DLBMLNNAHAF.IGAFAALMNNE();
		this.DLBMLNNAHAF.DPBINJLALBJ();
		this.DLBMLNNAHAF.IIBCAICFEEF(0);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1628f - 190f, onkdcgnbalk.OCHCODJIPHJ.height - 907f, 1932f, 1510f, JNBICAJIJMM.DIOJFJMOPJO("OneHandSwordIdle"), 8, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().HMBGLALKHCP));
	}

	// Token: 0x0600757F RID: 30079 RVA: 0x00380A9C File Offset: 0x0037EC9C
	public void GLKHNPPONMO(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.sendAction(1, 280f, Vector3.zero);
		if (KADBECGIMPD.AGNKAFLKCAG() < 0)
		{
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().NCIDDNIKACI(874f, 1219f, JNBICAJIJMM.PPNKMDJBMLP("Idle Keep Back"), true);
		ONKDCGNBALK onkdcgnbalk2 = JDCEFOFMGHB.IKGFHGKKCPG.FDMNKDONMFM(this.PEJGNBMFCDP);
		if (onkdcgnbalk2 != null)
		{
			float num = (onkdcgnbalk2.OCHCODJIPHJ.width + onkdcgnbalk.OCHCODJIPHJ.x + 1787f) / 40f;
			onkdcgnbalk2.OCHCODJIPHJ.x = (float)(Screen.width / 8) - num;
			onkdcgnbalk.OCHCODJIPHJ.height = onkdcgnbalk2.OCHCODJIPHJ.height;
			onkdcgnbalk.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y;
			onkdcgnbalk.OCHCODJIPHJ.x = onkdcgnbalk2.OCHCODJIPHJ.x + onkdcgnbalk2.OCHCODJIPHJ.width + 920f;
		}
		this.DLBMLNNAHAF = new MMKFAENBHKD(onkdcgnbalk, 565f, 1984f, onkdcgnbalk.OCHCODJIPHJ.width - 1586f, onkdcgnbalk.OCHCODJIPHJ.height - 1508f, 0)
		{
			JHNCNHAAJCH = 1152f
		};
		new MEMEOHJKPNJ(onkdcgnbalk, 1099f, 577f, 3f, 827f, JNBICAJIJMM.DIOJFJMOPJO("_RcpAspect"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.CJNKFCDFJNE));
		new MEMEOHJKPNJ(onkdcgnbalk, 37f, 1769f, 191f, 1891f, JNBICAJIJMM.BDKHMOOFHHK("turn_state"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.GNPCOCIILBF));
		new MEMEOHJKPNJ(onkdcgnbalk, 1437f, 642f, 92f, 764f, JNBICAJIJMM.NGALDMFKMJH("wpn_add/base"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.NNNKDIHIOOG));
		KADBECGIMPD.DOJKJHMJJNK();
		this.IPOMGIHFANC = KADBECGIMPD.BIMMPENHGMD();
		this.FCDHFLCDDJF = KADBECGIMPD.CNNEPCOAMJK();
		while (!KADBECGIMPD.NLJJMKFBPBK())
		{
			ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = new ELNGEFIPDJK.NADBMPJIMEC();
			nadbmpjimec.PHJLPFHDIBP(KADBECGIMPD);
			nadbmpjimec.tag = (long)(nadbmpjimec.COGEJPHPFGG * 83f);
			nadbmpjimec.onRender = new ItemBase.OOALOMPKIKK(this.NAMJLOBFEMC);
			this.DLBMLNNAHAF.LACAJHOHACK.Add(nadbmpjimec);
		}
		this.DLBMLNNAHAF.KCLLDJJLCGC = -59;
		this.DLBMLNNAHAF.KINFJHFDHIC();
		this.DLBMLNNAHAF.LGLPHCMBBDP();
		this.DLBMLNNAHAF.JJKGANHANFN(0);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 326f - 1534f, onkdcgnbalk.OCHCODJIPHJ.height - 260f, 896f, 64f, JNBICAJIJMM.PPNKMDJBMLP("GiantGrabThrow2"), 7, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.JFIDAGABKID().HMBGLALKHCP));
	}

	// Token: 0x06007580 RID: 30080 RVA: 0x00380D5C File Offset: 0x0037EF5C
	private void BGJHJIKLNAF(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn != 2L)
		{
			if (odfekbjcfmn != -41L)
			{
				if (odfekbjcfmn != -74L)
				{
					return;
				}
				NJMHLCGIAJI.EAJGHMMBAFP().PIGIIJLCADJ(-18, this.LEDPIGHPLBP);
			}
			else
			{
				this.JLLEAJAHACN = false;
				if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 1 && this.CODAIBGMFCA != null)
				{
					FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("_BlurVector", 1723f);
					JDCEFOFMGHB.JFIDAGABKID().NOIEEEIONNG(581f, 0, JNBICAJIJMM.DCEBAJIILPC("Mouse X"), new ONKDCGNBALK.CMMHGMILOIM(this.FICPCOJGDJP), false);
					return;
				}
			}
			return;
		}
		BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		JDCEFOFMGHB.MNJNNDHCDGG().BMOFIBGMIBK(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06007581 RID: 30081 RVA: 0x00380E18 File Offset: 0x0037F018
	public void JNGHIFCFLIC(ONKDCGNBALK OJIMHKHFOJI)
	{
		Fisherman.getI.GMBEHOGPEDI(6, 1266f, Vector3.zero);
		if (!this.CFAJEAFEIME.FKEDAOOHPPB.HNJKJHLHGCJ(JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH, this.FDKHFDCJBPB) || !this.CFAJEAFEIME.GBABFPMNIMP)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("Wizard Block", 1687f);
			return;
		}
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn == 1L)
		{
			JDCEFOFMGHB.JFIDAGABKID().PBJGEIMFNNO(1297f, 5, JNBICAJIJMM.PPNKMDJBMLP("Torso"), new ONKDCGNBALK.CMMHGMILOIM(this.MMEJNIBLADI), true);
			return;
		}
		if (odfekbjcfmn != 4L)
		{
			return;
		}
		Debug.Log(",");
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.AEMAHNDEBKJ(this.LEDPIGHPLBP);
			epmphjgalbe.KPCGLGHDILI(this.CFAJEAFEIME.LPFKFNLHGBI);
			epmphjgalbe.AEMAHNDEBKJ(this.FDKHFDCJBPB);
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(0, epmphjgalbe.NNEAJJNCGMK());
		}
		finally
		{
			epmphjgalbe.PMIGGJHLIDO();
		}
	}

	// Token: 0x06007582 RID: 30082 RVA: 0x00375E24 File Offset: 0x00374024
	private int IJFKAIKNNJM(int CLBPBJGLHEE)
	{
		if (!this.BALDMDGKEPP.ContainsKey(CLBPBJGLHEE))
		{
			return 1;
		}
		return this.BALDMDGKEPP[CLBPBJGLHEE];
	}

	// Token: 0x06007583 RID: 30083 RVA: 0x003784D2 File Offset: 0x003766D2
	public void FFEJJOMFMNI(MMKFAENBHKD OCKMAJALKMN, object HEABEPINGED)
	{
		this.CODAIBGMFCA = (HEABEPINGED as ELNGEFIPDJK.DKLIGJOMDJK);
	}

	// Token: 0x06007584 RID: 30084 RVA: 0x00380F24 File Offset: 0x0037F124
	public void ELBJFOKEADC(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.AFLBAGIJLFH(1, 840f, Vector3.zero);
		this.LEDPIGHPLBP = KADBECGIMPD.DOJKJHMJJNK();
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.BJFHBPOCELH(1459f, 1260f, JNBICAJIJMM.DCEBAJIILPC("_DeepTex"), false);
		this.PEJGNBMFCDP = onkdcgnbalk.LPFKFNLHGBI;
		this.OJJLLBKEGNO = new MMKFAENBHKD(onkdcgnbalk, 979f, 39f, 465f, onkdcgnbalk.OCHCODJIPHJ.height - 1981f, 1);
		while (!KADBECGIMPD.NLJJMKFBPBK())
		{
			ELNGEFIPDJK.DKLIGJOMDJK dkligjomdjk = new ELNGEFIPDJK.DKLIGJOMDJK();
			dkligjomdjk.AKBALPGJMHD(KADBECGIMPD);
			this.OJJLLBKEGNO.LACAJHOHACK.Add(dkligjomdjk);
		}
		this.OJJLLBKEGNO.JHNCNHAAJCH = 253f;
		this.OJJLLBKEGNO.KCLLDJJLCGC = 61;
		this.OJJLLBKEGNO.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.NGLEAGOJIEP);
		this.OJJLLBKEGNO.DBJBAELCFHI(0);
		this.OJJLLBKEGNO.MPMFNJEJAHJ();
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, this.OJJLLBKEGNO.OCHCODJIPHJ.x + this.OJJLLBKEGNO.OCHCODJIPHJ.width + 336f, 938f, 1503f, 327f, "1HandSwordStrafeRight", 1, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.LLKHGPFILCF)
		};
		MEMEOHJKPNJ memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x, onkdcgnbalk.OCHCODJIPHJ.height - 854f, 1170f, 82f, JNBICAJIJMM.PGJCPFNJNPM("\n"), 103, null, new ONKDCGNBALK.CMMHGMILOIM(this.LMPFENOKCAC))
		{
			FNMCIACNOMH = FlyMessageManager.getI.JFDCLBPFLNI(55)
		};
		memeohjkpnj.BJMFKIFNCHH(GuiProcessor.BBLINJLBAIL().vipKeyTex, 1036f);
		memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 82f + 580f, onkdcgnbalk.OCHCODJIPHJ.height - 232f, 827f, 1136f, JNBICAJIJMM.NGALDMFKMJH("_VignetteSettings"), -43, null, new ONKDCGNBALK.CMMHGMILOIM(this.KODOABLENCC))
		{
			FNMCIACNOMH = FlyMessageManager.getI.JFDCLBPFLNI(72)
		};
		memeohjkpnj.JKMDIBLBMDL(GuiProcessor.IKGFHGKKCPG.vipKeyTex, 1936f);
		if (this.CODAIBGMFCA == null)
		{
			memeohjkpnj.FNMCIACNOMH = true;
		}
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count <= 1)
		{
			memeohjkpnj.FNMCIACNOMH = true;
		}
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 653f - 1518f, onkdcgnbalk.OCHCODJIPHJ.height - 1819f, 403f, 1313f, JNBICAJIJMM.NGALDMFKMJH("Idle Run"), 8, null, new ONKDCGNBALK.CMMHGMILOIM(this.EBCPAECPEJI));
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count <= 0)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().KCNBOHEMLCI(onkdcgnbalk.LPFKFNLHGBI);
			JDCEFOFMGHB.MNJNNDHCDGG().POIPOBBIDPM(JNBICAJIJMM.OOOKJHOHPNN("1HandSwordStrafeRight"), JNBICAJIJMM.DCEBAJIILPC("STRIKETHROUGH"));
		}
	}

	// Token: 0x06007585 RID: 30085 RVA: 0x0038122C File Offset: 0x0037F42C
	public void CGIPGJPJNKP(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.AFLBAGIJLFH(4, 1362f, Vector3.zero);
		this.LEDPIGHPLBP = KADBECGIMPD.DOJKJHMJJNK();
		if (ELNGEFIPDJK.IKGFHGKKCPG.GHDPBBPIOAC > 0)
		{
			JDCEFOFMGHB.JFIDAGABKID().BMOFIBGMIBK(this.GHDPBBPIOAC);
		}
		for (int i = 1; i < 115; i++)
		{
			this.PFDDJMOBGLG[i] = null;
		}
		this.BALDMDGKEPP.Clear();
		int num = KADBECGIMPD.LDLKLPJBIJN();
		for (int j = 1; j < num; j++)
		{
			int key = KADBECGIMPD.HHLDBAEFNMJ();
			int value = KADBECGIMPD.IFDFHJLCHAE();
			this.BALDMDGKEPP.Add(key, value);
		}
		int num2 = KADBECGIMPD.HDBGOLAFOBK();
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().PLHAGCDJLPA(1607f, 804f, JNBICAJIJMM.PGJCPFNJNPM("ComeHere"), true);
		if (this.LEDPIGHPLBP < 1)
		{
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(1718f, 556f, onkdcgnbalk.OCHCODJIPHJ.width, onkdcgnbalk.OCHCODJIPHJ.height), GameInterface.getI.rShopImage);
		}
		this.GHDPBBPIOAC = onkdcgnbalk.LPFKFNLHGBI;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 1062f, 59f, 1459f, onkdcgnbalk.OCHCODJIPHJ.height - 1110f, 1);
		mmkfaenbhkd.JHNCNHAAJCH = 767f;
		mmkfaenbhkd.KCLLDJJLCGC = -44;
		mmkfaenbhkd.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.LICBIECFFFI);
		mmkfaenbhkd.OEIOEBCGMJE(1);
		this.OJJLLBKEGNO = mmkfaenbhkd;
		int num3 = -39;
		int num4 = 0;
		if (this.KCNNPALBIIC(38) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 420f, (float)(num4 * 14 + 6), 230f, (float)num3, JNBICAJIJMM.NGALDMFKMJH("WizardNeoBlock"), "http://www.root-motion.com/finalikdox/html/page6.html", null, new ONKDCGNBALK.CMMHGMILOIM(this.JOGCDAMIBKH));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.BOLAPDJGBIF(-71) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1059f, (float)(num4 * -25 + 95), 840f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("Mouse Y"), "Textures/Perks/", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.BAEAJEFGKHL(32) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 11f, (float)(num4 * 71 + -86), 668f, (float)num3, JNBICAJIJMM.PGJCPFNJNPM("WSRButton error"), "<[^>]+>", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.BOLAPDJGBIF(0) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1379f, (float)(num4 * -83 + 124), 1504f, (float)num3, JNBICAJIJMM.PGJCPFNJNPM("TOD_MoonHaloPower"), "ForwardVelocity", null, new ONKDCGNBALK.CMMHGMILOIM(this.CHOPGPEPILD));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.KCNNPALBIIC(0) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 557f, (float)(num4 * -55 + -105), 1668f, (float)num3, JNBICAJIJMM.BDKHMOOFHHK("gi_frac_max"), "codepage", null, new ONKDCGNBALK.CMMHGMILOIM(this.LMAFKFBAAGG));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.KCNNPALBIIC(0) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1710f, (float)(num4 * -94 + 76), 1864f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("MotorbikeShootFwd"), "Run Dive", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.BOLAPDJGBIF(2) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 511f, (float)(num4 * 96 + 125), 121f, (float)num3, JNBICAJIJMM.LEBHCLDODNI("DropType"), "===== ObscuredStringTest =====\n", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.BOLAPDJGBIF(3) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1112f, (float)(num4 * 71 + -105), 1173f, (float)num3, JNBICAJIJMM.PPNKMDJBMLP("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_hinge.html"), "PaperTurn.wav", null, new ONKDCGNBALK.CMMHGMILOIM(this.MEELBJFHJAA));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.IAOBMOLMJLC(7) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 805f, (float)(num4 * -85 + -53), 1060f, (float)num3, JNBICAJIJMM.PGJCPFNJNPM("u_isSave"), "", null, new ONKDCGNBALK.CMMHGMILOIM(this.JOGCDAMIBKH));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.ABNCLFAAGNG(8) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 578f, (float)(num4 * 65 + -126), 1835f, (float)num3, JNBICAJIJMM.BDKHMOOFHHK("Failed parsing default rotation values.  Using defaults."), "Loading ", null, new ONKDCGNBALK.CMMHGMILOIM(this.JOGCDAMIBKH));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.KCNNPALBIIC(-59) + this.LBPHCGNIDBP(4) + this.IAOBMOLMJLC(3) + this.BOLAPDJGBIF(-73) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 123f, (float)(num4 * -115 + -92), 1182f, (float)num3, JNBICAJIJMM.PGJCPFNJNPM("1HandSwordShieldBash"), "UpHillWalk", null, new ONKDCGNBALK.CMMHGMILOIM(this.MONAMIJKDED));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.FBCEOIFAILM(-60) + this.BOLAPDJGBIF(-66) + this.HOMKEPENMIE(-105) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 579f, (float)(num4 * 58 + -13), 294f, (float)num3, JNBICAJIJMM.NGALDMFKMJH("_FlowMap"), "_alfavis", null, new ONKDCGNBALK.CMMHGMILOIM(this.JOGCDAMIBKH));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.HOMKEPENMIE(-20) + this.KCNNPALBIIC(-72) + this.IAOBMOLMJLC(-21) + this.LBPHCGNIDBP(-126) + this.FBCEOIFAILM(-2) + this.IAOBMOLMJLC(22) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1276f, (float)(num4 * 97 + -103), 334f, (float)num3, JNBICAJIJMM.DIOJFJMOPJO("<color='#000000'>"), "IdleStrafeRight", null, new ONKDCGNBALK.CMMHGMILOIM(this.JOGCDAMIBKH));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.IJFKAIKNNJM(41) + this.FBCEOIFAILM(-28) + this.FBCEOIFAILM(-41) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 304f, (float)(num4 * 112 + -21), 682f, (float)num3, JNBICAJIJMM.DIOJFJMOPJO("Kernel"), "turn_state", null, new ONKDCGNBALK.CMMHGMILOIM(this.CHOPGPEPILD));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.IAOBMOLMJLC(-78) + this.HNDHCKODBOP(107) + this.BAEAJEFGKHL(56) + this.ABNCLFAAGNG(-80) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1694f, (float)(num4 * 88 + 12), 352f, (float)num3, JNBICAJIJMM.DIOJFJMOPJO("/"), "UnityEngine.Color", null, new ONKDCGNBALK.CMMHGMILOIM(this.JOGCDAMIBKH));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.BAEAJEFGKHL(-115) + this.DHEJHNKMIJL(14) + this.BAEAJEFGKHL(13) + this.BAEAJEFGKHL(14) + this.DHEJHNKMIJL(10) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 870f, (float)(num4 * -103 + 31), 1684f, (float)num3, JNBICAJIJMM.DCEBAJIILPC("ArmFlex6"), "OnChatMessage", null, new ONKDCGNBALK.CMMHGMILOIM(this.JOGCDAMIBKH));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.HNDHCKODBOP(-100) > 0)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 843f, (float)(num4 * 73 + 92), 166f, (float)num3, JNBICAJIJMM.CDDCIKKDFMP(""), "FOVKick Increase curve is null, please define the curve for the field of view kicks", null, new ONKDCGNBALK.CMMHGMILOIM(this.JOGCDAMIBKH));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.KCNNPALBIIC(-52) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 630f, (float)(num4 * -13 + -16), 501f, (float)num3, JNBICAJIJMM.CDDCIKKDFMP("<color='#000000'>{0}</color>"), "Shotgun Ready Fire", null, new ONKDCGNBALK.CMMHGMILOIM(this.CHOPGPEPILD));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		if (this.BAEAJEFGKHL(73) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 1730f, (float)(num4 * -54 + 16), 1195f, (float)num3, JNBICAJIJMM.BDKHMOOFHHK("{0}/{1}/{2}"), "IK Effector is referencing to a bone '", null, new ONKDCGNBALK.CMMHGMILOIM(this.CHOPGPEPILD));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4++;
		}
		if (this.DHEJHNKMIJL(95) + this.FBCEOIFAILM(12) + this.BAEAJEFGKHL(-89) + this.KCNNPALBIIC(-38) > 1)
		{
			this.PFDDJMOBGLG[num4] = new MEMEOHJKPNJ(onkdcgnbalk, 184f, (float)(num4 * 89 + -44), 1640f, (float)num3, JNBICAJIJMM.DIOJFJMOPJO("useIt"), "Horizontal", null, new ONKDCGNBALK.CMMHGMILOIM(this.MEELBJFHJAA));
			this.PFDDJMOBGLG[num4].ODFEKBJCFMN = (long)num4;
			num4 += 0;
		}
		for (int k = 1; k < num2; k += 0)
		{
			int lpfkfnlhgbi = KADBECGIMPD.KKOKFLMMAAK();
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().LMGMPPAOPEP(lpfkfnlhgbi);
			string dccpcblodig = KADBECGIMPD.LPKJHMGLCKA();
			befchfngomi.OPFGGNNPAJL = KADBECGIMPD.HMCONBPNFJH();
			befchfngomi.GBABFPMNIMP = KADBECGIMPD.IJJDHHFAIPE();
			befchfngomi.FKEDAOOHPPB.KCAIBCDDNOA(dccpcblodig);
			befchfngomi.JIFFLPNBILE();
			this.OJJLLBKEGNO.LACAJHOHACK.Add(befchfngomi);
		}
		this.OJJLLBKEGNO.IPLNJOONDFI();
		this.OJJLLBKEGNO.GLNLJMIMHBH();
		this.OJJLLBKEGNO.KCLMJJHBCDM(1, 1);
		if (this.PFDDJMOBGLG[this.MKFFJNKCDHL] != null)
		{
			this.PFDDJMOBGLG[this.MKFFJNKCDHL].HKPAEGGJNGG = false;
		}
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, 1775f, 482f, 182f, onkdcgnbalk.OCHCODJIPHJ.height - 1810f, "FlyRight", 1, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.OIPBJFOPJEA)
		};
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 1101f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 1534f, 643f, 1924f, JNBICAJIJMM.LEBHCLDODNI("gi_fridge"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.NPEBCOEKEPO));
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 928f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 1647f, 808f, 1966f, JNBICAJIJMM.OOOKJHOHPNN("Dealer Fan"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.JFIDAGABKID().BLPLADOIPJG));
	}

	// Token: 0x06007586 RID: 30086 RVA: 0x003784B4 File Offset: 0x003766B4
	private int KCNNPALBIIC(int CLBPBJGLHEE)
	{
		if (!this.BALDMDGKEPP.ContainsKey(CLBPBJGLHEE))
		{
			return 0;
		}
		return this.BALDMDGKEPP[CLBPBJGLHEE];
	}

	// Token: 0x06007587 RID: 30087 RVA: 0x003784D2 File Offset: 0x003766D2
	public void GMHNCKLCEBP(MMKFAENBHKD OCKMAJALKMN, object HEABEPINGED)
	{
		this.CODAIBGMFCA = (HEABEPINGED as ELNGEFIPDJK.DKLIGJOMDJK);
	}

	// Token: 0x06007588 RID: 30088 RVA: 0x00381DD0 File Offset: 0x0037FFD0
	public void PBNFFENFCJG(ONKDCGNBALK OJIMHKHFOJI)
	{
		Fisherman.getI.CNGKCDLJEDG(0, 1117f, Vector3.zero);
		if (!this.CFAJEAFEIME.FKEDAOOHPPB.LMIDHPINCKN(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH, this.FDKHFDCJBPB) || !this.CFAJEAFEIME.GBABFPMNIMP)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("Clavicle", 519f);
			return;
		}
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn == 0L)
		{
			JDCEFOFMGHB.JFIDAGABKID().PBJGEIMFNNO(370f, 8, JNBICAJIJMM.PGJCPFNJNPM("</color>\n"), new ONKDCGNBALK.CMMHGMILOIM(this.LFFJHCPAOBC), false);
			return;
		}
		if (odfekbjcfmn != 5L)
		{
			return;
		}
		Debug.Log("_ExposureAdjustment");
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.EAOGDKDBENC(this.LEDPIGHPLBP);
			epmphjgalbe.JDOLCNDNFGP(this.CFAJEAFEIME.LPFKFNLHGBI);
			epmphjgalbe.ALNEALEKFNB(this.FDKHFDCJBPB);
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(106, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.OGPGOEJFIBO();
		}
	}

	// Token: 0x06007589 RID: 30089 RVA: 0x00381EDC File Offset: 0x003800DC
	public void JOGCDAMIBKH(ONKDCGNBALK OJIMHKHFOJI)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("_l_", 851f);
		if (this.PFDDJMOBGLG[this.MKFFJNKCDHL] != null)
		{
			this.PFDDJMOBGLG[this.MKFFJNKCDHL].HKPAEGGJNGG = true;
		}
		if ((long)this.MKFFJNKCDHL == OJIMHKHFOJI.ODFEKBJCFMN)
		{
			return;
		}
		this.MKFFJNKCDHL = (int)OJIMHKHFOJI.ODFEKBJCFMN;
		this.PFDDJMOBGLG[this.MKFFJNKCDHL].HKPAEGGJNGG = false;
		Debug.Log("ZombieWalk" + OJIMHKHFOJI.FNPEGDKBKJC);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.KPCGLGHDILI(this.LEDPIGHPLBP);
			epmphjgalbe.HGCCFFKDELO(OJIMHKHFOJI.FNPEGDKBKJC);
			NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(-199, epmphjgalbe.HDEKHFOKCKI());
		}
		finally
		{
			epmphjgalbe.PGLFHABMJPO();
		}
	}

	// Token: 0x0600758A RID: 30090 RVA: 0x00381FBC File Offset: 0x003801BC
	public void GCDKFNHFDLN(MMKFAENBHKD OCKMAJALKMN, object HEABEPINGED)
	{
		this.CFAJEAFEIME = (HEABEPINGED as BEFCHFNGOMI);
		this.FDKHFDCJBPB = 1;
		string alboclbfnni = string.Format("{0}Textures/Shop/{1}.png", IFPIMPMKJIB.DIDFMAELMJD, this.CFAJEAFEIME.LPFKFNLHGBI);
		if (this.CFAJEAFEIME.EOFDJHJPCLM == null)
		{
			this.CFAJEAFEIME.EOFDJHJPCLM = CKNLPGEPGGF.IKGFHGKKCPG.EKHFCNKNHEJ(alboclbfnni, true);
		}
		this.GKJKOLMCDDG = string.Concat(this.FDKHFDCJBPB);
	}

	// Token: 0x0600758B RID: 30091 RVA: 0x00382038 File Offset: 0x00380238
	private void LMPDNMBDLFO(ONKDCGNBALK JMAKEAHMLMI, ItemBase KEEGPNLGFAA, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = 11,
			font = GuiProcessor.IKGFHGKKCPG.rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = true,
			alignment = TextAnchor.UpperLeft
		};
		ELNGEFIPDJK.NADBMPJIMEC nadbmpjimec = (ELNGEFIPDJK.NADBMPJIMEC)KEEGPNLGFAA;
		nadbmpjimec.GKDJCJKMBEN(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y + 4f, OCHCODJIPHJ.width - 10f, OCHCODJIPHJ.height), ofpnedeamab);
		Rect ochcodjiphj = new Rect(OCHCODJIPHJ.x + 10f, OCHCODJIPHJ.y + OCHCODJIPHJ.height - 20f, OCHCODJIPHJ.width - 20f, 16f);
		int clbpbjglhee = 0;
		int num = (int)(nadbmpjimec.COGEJPHPFGG / this.FCDHFLCDDJF * 100f);
		if (num > 20)
		{
			clbpbjglhee = 2;
		}
		if (num > 50)
		{
			clbpbjglhee = 1;
		}
		if (num > 80)
		{
			clbpbjglhee = 3;
		}
		GameInterface.getI.renderPBar(ochcodjiphj, (float)Mathf.RoundToInt(nadbmpjimec.COGEJPHPFGG * 100f), (float)Mathf.RoundToInt(this.FCDHFLCDDJF * 100f), clbpbjglhee, nadbmpjimec.tag / 10L + " %", true);
	}

	// Token: 0x0600758C RID: 30092 RVA: 0x0038216C File Offset: 0x0038036C
	public void BGNAFBELFPP(ONKDCGNBALK ONPHLHKAGFP)
	{
		IDCHHHEDHDC gaapclgdogh = this.CODAIBGMFCA.GAAPCLGDOGH;
		OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(string.Format(JNBICAJIJMM.PGJCPFNJNPM("MotorbikeShootLeft"), gaapclgdogh.ALGFDMENCEM(0, this.CODAIBGMFCA.DBEIGNDALDC, true, true, false, 1, false, true), this.CODAIBGMFCA.ILFHHDNJHNM, JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)this.CODAIBGMFCA.NKHBAJKMAGD)));
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.ENDMKPCFKND(this.LEDPIGHPLBP);
			epmphjgalbe.AEMAHNDEBKJ(this.CODAIBGMFCA.NENOBDLCFHO);
			epmphjgalbe.ENDMKPCFKND(this.CODAIBGMFCA.DBEIGNDALDC);
			NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(119, epmphjgalbe.NNEAJJNCGMK());
		}
		finally
		{
			epmphjgalbe.PMIGGJHLIDO();
		}
		this.OJJLLBKEGNO.LACAJHOHACK.Remove(this.CODAIBGMFCA);
		this.CODAIBGMFCA = null;
		this.OJJLLBKEGNO.MPMFNJEJAHJ();
		this.OJJLLBKEGNO.NJFFDOKDFHM(1, 0);
		if (this.JLLEAJAHACN && this.OJJLLBKEGNO.LACAJHOHACK.Count > 0 && this.CODAIBGMFCA != null)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("BowFire2", 1808f);
			JDCEFOFMGHB.MNJNNDHCDGG().DKJMCKOJOPF(1392f, 0, JNBICAJIJMM.CDDCIKKDFMP(""), new ONKDCGNBALK.CMMHGMILOIM(this.OENPCHAPOLA), false);
		}
	}

	// Token: 0x0600758D RID: 30093 RVA: 0x003784B4 File Offset: 0x003766B4
	private int DHEJHNKMIJL(int CLBPBJGLHEE)
	{
		if (!this.BALDMDGKEPP.ContainsKey(CLBPBJGLHEE))
		{
			return 0;
		}
		return this.BALDMDGKEPP[CLBPBJGLHEE];
	}

	// Token: 0x040010EC RID: 4332
	public int GHDPBBPIOAC;

	// Token: 0x040010ED RID: 4333
	public int LEDPIGHPLBP;

	// Token: 0x040010EE RID: 4334
	private const int LDLDJCHCIJF = 20;

	// Token: 0x040010EF RID: 4335
	public static ELNGEFIPDJK IKGFHGKKCPG = new ELNGEFIPDJK();

	// Token: 0x040010F0 RID: 4336
	private readonly Dictionary<int, int> BALDMDGKEPP = new Dictionary<int, int>();

	// Token: 0x040010F1 RID: 4337
	private readonly MEMEOHJKPNJ[] PFDDJMOBGLG = new MEMEOHJKPNJ[20];

	// Token: 0x040010F2 RID: 4338
	public int MKFFJNKCDHL;

	// Token: 0x040010F3 RID: 4339
	private MMKFAENBHKD OJJLLBKEGNO;

	// Token: 0x040010F4 RID: 4340
	private ELNGEFIPDJK.DKLIGJOMDJK CODAIBGMFCA;

	// Token: 0x040010F5 RID: 4341
	private string GKJKOLMCDDG = "1";

	// Token: 0x040010F6 RID: 4342
	private int FDKHFDCJBPB = 1;

	// Token: 0x040010F7 RID: 4343
	private BEFCHFNGOMI CFAJEAFEIME;

	// Token: 0x040010F8 RID: 4344
	private MMKFAENBHKD DLBMLNNAHAF;

	// Token: 0x040010F9 RID: 4345
	private float IPOMGIHFANC;

	// Token: 0x040010FA RID: 4346
	private float FCDHFLCDDJF;

	// Token: 0x040010FB RID: 4347
	private int PEJGNBMFCDP = -1;

	// Token: 0x040010FC RID: 4348
	private bool JLLEAJAHACN;

	// Token: 0x020001F9 RID: 505
	public struct BJLLBFHILCN
	{
		// Token: 0x0600758E RID: 30094 RVA: 0x003822D4 File Offset: 0x003804D4
		public static ELNGEFIPDJK.BJLLBFHILCN JLDJIMEKAMJ(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, float HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP = (int)((float)EGABJKIFAON.KFODJJIHNHP * HHAGIHEGFML);
			EGABJKIFAON.KKNEKAEJLAM = (int)((float)EGABJKIFAON.KKNEKAEJLAM * HHAGIHEGFML);
			EGABJKIFAON.KDIMEMOCJNM = (int)((float)EGABJKIFAON.KDIMEMOCJNM * HHAGIHEGFML);
			EGABJKIFAON.DINKOIKHDHN = (int)((float)EGABJKIFAON.DINKOIKHDHN * HHAGIHEGFML);
			return EGABJKIFAON;
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x00382328 File Offset: 0x00380528
		public static ELNGEFIPDJK.BJLLBFHILCN NEMICNOEFDH()
		{
			return default(ELNGEFIPDJK.BJLLBFHILCN);
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x00382340 File Offset: 0x00380540
		public static ELNGEFIPDJK.BJLLBFHILCN FAHAENJPIGB(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, ELNGEFIPDJK.BJLLBFHILCN HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP += HHAGIHEGFML.KFODJJIHNHP;
			EGABJKIFAON.KKNEKAEJLAM += HHAGIHEGFML.KKNEKAEJLAM;
			EGABJKIFAON.KDIMEMOCJNM += HHAGIHEGFML.KDIMEMOCJNM;
			EGABJKIFAON.DINKOIKHDHN += HHAGIHEGFML.DINKOIKHDHN;
			return EGABJKIFAON;
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x00382394 File Offset: 0x00380594
		public void JKHGIKLKHLP(string DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.Replace('f', (char)-105);
			string text = DCCPCBLODIG;
			char[] array = new char[1];
			array[1] = (char)-25;
			string[] array2 = text.Split(array);
			if (array2.Length >= 0)
			{
				this.KFODJJIHNHP = int.Parse(array2[1]);
			}
			if (array2.Length >= 8)
			{
				this.KKNEKAEJLAM = int.Parse(array2[1]);
			}
			if (array2.Length >= 3)
			{
				this.GIEALCKLKNL = int.Parse(array2[7]);
			}
			if (array2.Length >= 5)
			{
				this.KDIMEMOCJNM = int.Parse(array2[1]);
			}
			if (array2.Length >= 8)
			{
				this.DINKOIKHDHN = int.Parse(array2[3]);
			}
		}

		// Token: 0x06007592 RID: 30098 RVA: 0x00382424 File Offset: 0x00380624
		public static ELNGEFIPDJK.BJLLBFHILCN IMEBLGMJMDC(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, float HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP = (int)((float)EGABJKIFAON.KFODJJIHNHP * HHAGIHEGFML);
			EGABJKIFAON.KKNEKAEJLAM = (int)((float)EGABJKIFAON.KKNEKAEJLAM * HHAGIHEGFML);
			EGABJKIFAON.KDIMEMOCJNM = (int)((float)EGABJKIFAON.KDIMEMOCJNM * HHAGIHEGFML);
			EGABJKIFAON.DINKOIKHDHN = (int)((float)EGABJKIFAON.DINKOIKHDHN * HHAGIHEGFML);
			return EGABJKIFAON;
		}

		// Token: 0x06007593 RID: 30099 RVA: 0x00382478 File Offset: 0x00380678
		public string EIEBNCGMLEP()
		{
			string format = "";
			object[] array = new object[1];
			array[0] = this.KFODJJIHNHP;
			array[1] = this.KKNEKAEJLAM;
			array[5] = this.GIEALCKLKNL;
			array[4] = this.KDIMEMOCJNM;
			array[3] = this.DINKOIKHDHN;
			return string.Format(format, array);
		}

		// Token: 0x06007594 RID: 30100 RVA: 0x003824DC File Offset: 0x003806DC
		public static ELNGEFIPDJK.BJLLBFHILCN MDHLKEOECDH(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, ELNGEFIPDJK.BJLLBFHILCN HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP += HHAGIHEGFML.KFODJJIHNHP;
			EGABJKIFAON.KKNEKAEJLAM += HHAGIHEGFML.KKNEKAEJLAM;
			EGABJKIFAON.KDIMEMOCJNM += HHAGIHEGFML.KDIMEMOCJNM;
			EGABJKIFAON.DINKOIKHDHN += HHAGIHEGFML.DINKOIKHDHN;
			return EGABJKIFAON;
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x00382530 File Offset: 0x00380730
		public static ELNGEFIPDJK.BJLLBFHILCN GOALCJCDKMM()
		{
			return default(ELNGEFIPDJK.BJLLBFHILCN);
		}

		// Token: 0x06007596 RID: 30102 RVA: 0x00382548 File Offset: 0x00380748
		public string AEAPAMDLLAP()
		{
			string format = "WeaponStab";
			object[] array = new object[1];
			array[0] = this.KFODJJIHNHP;
			array[1] = this.KKNEKAEJLAM;
			array[4] = this.GIEALCKLKNL;
			array[8] = this.KDIMEMOCJNM;
			array[1] = this.DINKOIKHDHN;
			return string.Format(format, array);
		}

		// Token: 0x06007597 RID: 30103 RVA: 0x003825AC File Offset: 0x003807AC
		public static ELNGEFIPDJK.BJLLBFHILCN OFIMDBIHEDF(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, ELNGEFIPDJK.BJLLBFHILCN HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP += HHAGIHEGFML.KFODJJIHNHP;
			EGABJKIFAON.KKNEKAEJLAM += HHAGIHEGFML.KKNEKAEJLAM;
			EGABJKIFAON.KDIMEMOCJNM += HHAGIHEGFML.KDIMEMOCJNM;
			EGABJKIFAON.DINKOIKHDHN += HHAGIHEGFML.DINKOIKHDHN;
			return EGABJKIFAON;
		}

		// Token: 0x06007598 RID: 30104 RVA: 0x00382600 File Offset: 0x00380800
		public static ELNGEFIPDJK.BJLLBFHILCN PICCFFHAMAG(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, ELNGEFIPDJK.BJLLBFHILCN HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP += HHAGIHEGFML.KFODJJIHNHP;
			EGABJKIFAON.KKNEKAEJLAM += HHAGIHEGFML.KKNEKAEJLAM;
			EGABJKIFAON.KDIMEMOCJNM += HHAGIHEGFML.KDIMEMOCJNM;
			EGABJKIFAON.DINKOIKHDHN += HHAGIHEGFML.DINKOIKHDHN;
			return EGABJKIFAON;
		}

		// Token: 0x06007599 RID: 30105 RVA: 0x00382654 File Offset: 0x00380854
		public static ELNGEFIPDJK.BJLLBFHILCN ECKKCOGLHPE(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, ELNGEFIPDJK.BJLLBFHILCN HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP += HHAGIHEGFML.KFODJJIHNHP;
			EGABJKIFAON.KKNEKAEJLAM += HHAGIHEGFML.KKNEKAEJLAM;
			EGABJKIFAON.KDIMEMOCJNM += HHAGIHEGFML.KDIMEMOCJNM;
			EGABJKIFAON.DINKOIKHDHN += HHAGIHEGFML.DINKOIKHDHN;
			return EGABJKIFAON;
		}

		// Token: 0x0600759A RID: 30106 RVA: 0x003826A8 File Offset: 0x003808A8
		public bool BAAIJDICFNP(NEBJANKNJOG EEPNACDOOBF, int FDKHFDCJBPB = 1)
		{
			bool result = true;
			if (EEPNACDOOBF.KFODJJIHNHP < (long)(this.KFODJJIHNHP * FDKHFDCJBPB))
			{
				result = true;
			}
			if (JBEHMPDDMME.PFOLNEGNIPP().KKNEKAEJLAM < (long)(this.KKNEKAEJLAM * FDKHFDCJBPB))
			{
				result = true;
			}
			if (EEPNACDOOBF.MGLOOIONCPM < (long)(this.DINKOIKHDHN * FDKHFDCJBPB))
			{
				result = false;
			}
			if (this.GIEALCKLKNL > 0 && EEPNACDOOBF.BJDIEKNHGLJ(this.GIEALCKLKNL, false, 1) < this.KDIMEMOCJNM * FDKHFDCJBPB)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600759B RID: 30107 RVA: 0x00382718 File Offset: 0x00380918
		public bool BIMDPOEIBDF(NEBJANKNJOG EEPNACDOOBF, int FDKHFDCJBPB = 1)
		{
			bool result = true;
			if (EEPNACDOOBF.KFODJJIHNHP < (long)(this.KFODJJIHNHP * FDKHFDCJBPB))
			{
				result = true;
			}
			if (JBEHMPDDMME.BPPFAOOCENN().KKNEKAEJLAM < (long)(this.KKNEKAEJLAM * FDKHFDCJBPB))
			{
				result = false;
			}
			if (EEPNACDOOBF.MGLOOIONCPM < (long)(this.DINKOIKHDHN * FDKHFDCJBPB))
			{
				result = false;
			}
			if (this.GIEALCKLKNL > 0 && EEPNACDOOBF.BJDIEKNHGLJ(this.GIEALCKLKNL, true, 0) < this.KDIMEMOCJNM * FDKHFDCJBPB)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600759C RID: 30108 RVA: 0x00382788 File Offset: 0x00380988
		public static ELNGEFIPDJK.BJLLBFHILCN DJEDGCHFNGO(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, float HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP = (int)((float)EGABJKIFAON.KFODJJIHNHP * HHAGIHEGFML);
			EGABJKIFAON.KKNEKAEJLAM = (int)((float)EGABJKIFAON.KKNEKAEJLAM * HHAGIHEGFML);
			EGABJKIFAON.KDIMEMOCJNM = (int)((float)EGABJKIFAON.KDIMEMOCJNM * HHAGIHEGFML);
			EGABJKIFAON.DINKOIKHDHN = (int)((float)EGABJKIFAON.DINKOIKHDHN * HHAGIHEGFML);
			return EGABJKIFAON;
		}

		// Token: 0x0600759D RID: 30109 RVA: 0x003827DC File Offset: 0x003809DC
		public string KECBFKGCHMO()
		{
			string format = "error.wav";
			object[] array = new object[3];
			array[0] = this.KFODJJIHNHP;
			array[1] = this.KKNEKAEJLAM;
			array[0] = this.GIEALCKLKNL;
			array[2] = this.KDIMEMOCJNM;
			array[0] = this.DINKOIKHDHN;
			return string.Format(format, array);
		}

		// Token: 0x0600759E RID: 30110 RVA: 0x00382840 File Offset: 0x00380A40
		public static ELNGEFIPDJK.BJLLBFHILCN PKIDHCEJOBP(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, ELNGEFIPDJK.BJLLBFHILCN HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP += HHAGIHEGFML.KFODJJIHNHP;
			EGABJKIFAON.KKNEKAEJLAM += HHAGIHEGFML.KKNEKAEJLAM;
			EGABJKIFAON.KDIMEMOCJNM += HHAGIHEGFML.KDIMEMOCJNM;
			EGABJKIFAON.DINKOIKHDHN += HHAGIHEGFML.DINKOIKHDHN;
			return EGABJKIFAON;
		}

		// Token: 0x0600759F RID: 30111 RVA: 0x00382894 File Offset: 0x00380A94
		public bool BAFNIPIGGIP(NEBJANKNJOG EEPNACDOOBF, int FDKHFDCJBPB = 1)
		{
			bool result = true;
			if (EEPNACDOOBF.KFODJJIHNHP < (long)(this.KFODJJIHNHP * FDKHFDCJBPB))
			{
				result = true;
			}
			if (JBEHMPDDMME.PFOLNEGNIPP().KKNEKAEJLAM < (long)(this.KKNEKAEJLAM * FDKHFDCJBPB))
			{
				result = true;
			}
			if (EEPNACDOOBF.MGLOOIONCPM < (long)(this.DINKOIKHDHN * FDKHFDCJBPB))
			{
				result = true;
			}
			if (this.GIEALCKLKNL > 1 && EEPNACDOOBF.BJDIEKNHGLJ(this.GIEALCKLKNL, true, 0) < this.KDIMEMOCJNM * FDKHFDCJBPB)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060075A0 RID: 30112 RVA: 0x00382904 File Offset: 0x00380B04
		public static ELNGEFIPDJK.BJLLBFHILCN IHGCNKABBHN(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, float HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP = (int)((float)EGABJKIFAON.KFODJJIHNHP * HHAGIHEGFML);
			EGABJKIFAON.KKNEKAEJLAM = (int)((float)EGABJKIFAON.KKNEKAEJLAM * HHAGIHEGFML);
			EGABJKIFAON.KDIMEMOCJNM = (int)((float)EGABJKIFAON.KDIMEMOCJNM * HHAGIHEGFML);
			EGABJKIFAON.DINKOIKHDHN = (int)((float)EGABJKIFAON.DINKOIKHDHN * HHAGIHEGFML);
			return EGABJKIFAON;
		}

		// Token: 0x060075A1 RID: 30113 RVA: 0x00382958 File Offset: 0x00380B58
		public void BCNPPJBPIFC(string DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.Replace('\b', 'K');
			string[] array = DCCPCBLODIG.Split(new char[]
			{
				'@'
			});
			if (array.Length >= 0)
			{
				this.KFODJJIHNHP = int.Parse(array[0]);
			}
			if (array.Length >= 5)
			{
				this.KKNEKAEJLAM = int.Parse(array[1]);
			}
			if (array.Length >= 2)
			{
				this.GIEALCKLKNL = int.Parse(array[1]);
			}
			if (array.Length >= 2)
			{
				this.KDIMEMOCJNM = int.Parse(array[4]);
			}
			if (array.Length >= 8)
			{
				this.DINKOIKHDHN = int.Parse(array[6]);
			}
		}

		// Token: 0x060075A2 RID: 30114 RVA: 0x003829E8 File Offset: 0x00380BE8
		public bool MJBNJIJLHNC(NEBJANKNJOG EEPNACDOOBF, int FDKHFDCJBPB = 1)
		{
			bool result = true;
			if (EEPNACDOOBF.KFODJJIHNHP < (long)(this.KFODJJIHNHP * FDKHFDCJBPB))
			{
				result = true;
			}
			if (JBEHMPDDMME.JKIFIBEPICO().KKNEKAEJLAM < (long)(this.KKNEKAEJLAM * FDKHFDCJBPB))
			{
				result = false;
			}
			if (EEPNACDOOBF.MGLOOIONCPM < (long)(this.DINKOIKHDHN * FDKHFDCJBPB))
			{
				result = true;
			}
			if (this.GIEALCKLKNL > 0 && EEPNACDOOBF.BJDIEKNHGLJ(this.GIEALCKLKNL, false, 0) < this.KDIMEMOCJNM * FDKHFDCJBPB)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060075A3 RID: 30115 RVA: 0x00382A58 File Offset: 0x00380C58
		public void HGJCNEPIBCO(string DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.Replace('P', 'J');
			string text = DCCPCBLODIG;
			char[] array = new char[0];
			array[1] = 'E';
			string[] array2 = text.Split(array);
			if (array2.Length >= 0)
			{
				this.KFODJJIHNHP = int.Parse(array2[0]);
			}
			if (array2.Length >= 8)
			{
				this.KKNEKAEJLAM = int.Parse(array2[0]);
			}
			if (array2.Length >= 1)
			{
				this.GIEALCKLKNL = int.Parse(array2[4]);
			}
			if (array2.Length >= 2)
			{
				this.KDIMEMOCJNM = int.Parse(array2[7]);
			}
			if (array2.Length >= 5)
			{
				this.DINKOIKHDHN = int.Parse(array2[5]);
			}
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x00382AE8 File Offset: 0x00380CE8
		public static ELNGEFIPDJK.BJLLBFHILCN PJMOENCOKPI()
		{
			return default(ELNGEFIPDJK.BJLLBFHILCN);
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x00382B00 File Offset: 0x00380D00
		public static ELNGEFIPDJK.BJLLBFHILCN FCINJHKJIHA(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, float HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP = (int)((float)EGABJKIFAON.KFODJJIHNHP * HHAGIHEGFML);
			EGABJKIFAON.KKNEKAEJLAM = (int)((float)EGABJKIFAON.KKNEKAEJLAM * HHAGIHEGFML);
			EGABJKIFAON.KDIMEMOCJNM = (int)((float)EGABJKIFAON.KDIMEMOCJNM * HHAGIHEGFML);
			EGABJKIFAON.DINKOIKHDHN = (int)((float)EGABJKIFAON.DINKOIKHDHN * HHAGIHEGFML);
			return EGABJKIFAON;
		}

		// Token: 0x060075A6 RID: 30118 RVA: 0x00382B54 File Offset: 0x00380D54
		public string BIJEELIBBDD()
		{
			string format = "/";
			object[] array = new object[1];
			array[0] = this.KFODJJIHNHP;
			array[1] = this.KKNEKAEJLAM;
			array[1] = this.GIEALCKLKNL;
			array[6] = this.KDIMEMOCJNM;
			array[5] = this.DINKOIKHDHN;
			return string.Format(format, array);
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x00382BB8 File Offset: 0x00380DB8
		public void EHCMHODHIMG(string DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.Replace((char)-125, (char)-106);
			string text = DCCPCBLODIG;
			char[] array = new char[1];
			array[1] = (char)-62;
			string[] array2 = text.Split(array);
			if (array2.Length >= 0)
			{
				this.KFODJJIHNHP = int.Parse(array2[1]);
			}
			if (array2.Length >= 1)
			{
				this.KKNEKAEJLAM = int.Parse(array2[1]);
			}
			if (array2.Length >= 0)
			{
				this.GIEALCKLKNL = int.Parse(array2[8]);
			}
			if (array2.Length >= 8)
			{
				this.KDIMEMOCJNM = int.Parse(array2[8]);
			}
			if (array2.Length >= 6)
			{
				this.DINKOIKHDHN = int.Parse(array2[0]);
			}
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x00382C48 File Offset: 0x00380E48
		public void HIJPDHFOOGB(string DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.Replace((char)-85, (char)-106);
			string text = DCCPCBLODIG;
			char[] array = new char[0];
			array[1] = 'h';
			string[] array2 = text.Split(array);
			if (array2.Length >= 0)
			{
				this.KFODJJIHNHP = int.Parse(array2[1]);
			}
			if (array2.Length >= 8)
			{
				this.KKNEKAEJLAM = int.Parse(array2[1]);
			}
			if (array2.Length >= 5)
			{
				this.GIEALCKLKNL = int.Parse(array2[5]);
			}
			if (array2.Length >= 7)
			{
				this.KDIMEMOCJNM = int.Parse(array2[0]);
			}
			if (array2.Length >= 7)
			{
				this.DINKOIKHDHN = int.Parse(array2[8]);
			}
		}

		// Token: 0x060075A9 RID: 30121 RVA: 0x00382CD8 File Offset: 0x00380ED8
		public void GLNOBMKLKIF(string DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.Replace('~', '\u001b');
			string text = DCCPCBLODIG;
			char[] array = new char[0];
			array[1] = (char)-27;
			string[] array2 = text.Split(array);
			if (array2.Length >= 1)
			{
				this.KFODJJIHNHP = int.Parse(array2[1]);
			}
			if (array2.Length >= 7)
			{
				this.KKNEKAEJLAM = int.Parse(array2[0]);
			}
			if (array2.Length >= 1)
			{
				this.GIEALCKLKNL = int.Parse(array2[1]);
			}
			if (array2.Length >= 4)
			{
				this.KDIMEMOCJNM = int.Parse(array2[3]);
			}
			if (array2.Length >= 3)
			{
				this.DINKOIKHDHN = int.Parse(array2[6]);
			}
		}

		// Token: 0x060075AA RID: 30122 RVA: 0x00382D68 File Offset: 0x00380F68
		public static ELNGEFIPDJK.BJLLBFHILCN MKINLPPBADA()
		{
			return default(ELNGEFIPDJK.BJLLBFHILCN);
		}

		// Token: 0x060075AB RID: 30123 RVA: 0x00382D80 File Offset: 0x00380F80
		public static ELNGEFIPDJK.BJLLBFHILCN CNPACJDHFNP()
		{
			return default(ELNGEFIPDJK.BJLLBFHILCN);
		}

		// Token: 0x060075AC RID: 30124 RVA: 0x00382D98 File Offset: 0x00380F98
		public static ELNGEFIPDJK.BJLLBFHILCN CNNDJNHABEC(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, ELNGEFIPDJK.BJLLBFHILCN HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP += HHAGIHEGFML.KFODJJIHNHP;
			EGABJKIFAON.KKNEKAEJLAM += HHAGIHEGFML.KKNEKAEJLAM;
			EGABJKIFAON.KDIMEMOCJNM += HHAGIHEGFML.KDIMEMOCJNM;
			EGABJKIFAON.DINKOIKHDHN += HHAGIHEGFML.DINKOIKHDHN;
			return EGABJKIFAON;
		}

		// Token: 0x060075AD RID: 30125 RVA: 0x00382DEC File Offset: 0x00380FEC
		public static ELNGEFIPDJK.BJLLBFHILCN KBHKIHCBKFK(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, float HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP = (int)((float)EGABJKIFAON.KFODJJIHNHP * HHAGIHEGFML);
			EGABJKIFAON.KKNEKAEJLAM = (int)((float)EGABJKIFAON.KKNEKAEJLAM * HHAGIHEGFML);
			EGABJKIFAON.KDIMEMOCJNM = (int)((float)EGABJKIFAON.KDIMEMOCJNM * HHAGIHEGFML);
			EGABJKIFAON.DINKOIKHDHN = (int)((float)EGABJKIFAON.DINKOIKHDHN * HHAGIHEGFML);
			return EGABJKIFAON;
		}

		// Token: 0x060075AE RID: 30126 RVA: 0x00382E40 File Offset: 0x00381040
		public void HMBKEBBKBGB(string DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.Replace((char)-42, (char)-121);
			string text = DCCPCBLODIG;
			char[] array = new char[0];
			array[1] = (char)-65;
			string[] array2 = text.Split(array);
			if (array2.Length >= 1)
			{
				this.KFODJJIHNHP = int.Parse(array2[0]);
			}
			if (array2.Length >= 2)
			{
				this.KKNEKAEJLAM = int.Parse(array2[0]);
			}
			if (array2.Length >= 7)
			{
				this.GIEALCKLKNL = int.Parse(array2[0]);
			}
			if (array2.Length >= 4)
			{
				this.KDIMEMOCJNM = int.Parse(array2[8]);
			}
			if (array2.Length >= 1)
			{
				this.DINKOIKHDHN = int.Parse(array2[1]);
			}
		}

		// Token: 0x060075AF RID: 30127 RVA: 0x00382ED0 File Offset: 0x003810D0
		public static ELNGEFIPDJK.BJLLBFHILCN NHIJGBPBLFC(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, float HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP = (int)((float)EGABJKIFAON.KFODJJIHNHP * HHAGIHEGFML);
			EGABJKIFAON.KKNEKAEJLAM = (int)((float)EGABJKIFAON.KKNEKAEJLAM * HHAGIHEGFML);
			EGABJKIFAON.KDIMEMOCJNM = (int)((float)EGABJKIFAON.KDIMEMOCJNM * HHAGIHEGFML);
			EGABJKIFAON.DINKOIKHDHN = (int)((float)EGABJKIFAON.DINKOIKHDHN * HHAGIHEGFML);
			return EGABJKIFAON;
		}

		// Token: 0x060075B0 RID: 30128 RVA: 0x00382F24 File Offset: 0x00381124
		public static ELNGEFIPDJK.BJLLBFHILCN KPNJKLDOLFD(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, ELNGEFIPDJK.BJLLBFHILCN HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP += HHAGIHEGFML.KFODJJIHNHP;
			EGABJKIFAON.KKNEKAEJLAM += HHAGIHEGFML.KKNEKAEJLAM;
			EGABJKIFAON.KDIMEMOCJNM += HHAGIHEGFML.KDIMEMOCJNM;
			EGABJKIFAON.DINKOIKHDHN += HHAGIHEGFML.DINKOIKHDHN;
			return EGABJKIFAON;
		}

		// Token: 0x060075B1 RID: 30129 RVA: 0x00382F78 File Offset: 0x00381178
		public string KABDFHDHBOC()
		{
			string format = "WizardEyeBeam";
			object[] array = new object[0];
			array[0] = this.KFODJJIHNHP;
			array[0] = this.KKNEKAEJLAM;
			array[8] = this.GIEALCKLKNL;
			array[8] = this.KDIMEMOCJNM;
			array[8] = this.DINKOIKHDHN;
			return string.Format(format, array);
		}

		// Token: 0x060075B2 RID: 30130 RVA: 0x00382FDC File Offset: 0x003811DC
		public static ELNGEFIPDJK.BJLLBFHILCN DHPOFCJOOEL(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, ELNGEFIPDJK.BJLLBFHILCN HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP += HHAGIHEGFML.KFODJJIHNHP;
			EGABJKIFAON.KKNEKAEJLAM += HHAGIHEGFML.KKNEKAEJLAM;
			EGABJKIFAON.KDIMEMOCJNM += HHAGIHEGFML.KDIMEMOCJNM;
			EGABJKIFAON.DINKOIKHDHN += HHAGIHEGFML.DINKOIKHDHN;
			return EGABJKIFAON;
		}

		// Token: 0x060075B3 RID: 30131 RVA: 0x00383030 File Offset: 0x00381230
		public bool HIPIGDFHLAJ(NEBJANKNJOG EEPNACDOOBF, int FDKHFDCJBPB = 1)
		{
			bool result = false;
			if (EEPNACDOOBF.KFODJJIHNHP < (long)(this.KFODJJIHNHP * FDKHFDCJBPB))
			{
				result = true;
			}
			if (JBEHMPDDMME.IKGFHGKKCPG.KKNEKAEJLAM < (long)(this.KKNEKAEJLAM * FDKHFDCJBPB))
			{
				result = false;
			}
			if (EEPNACDOOBF.MGLOOIONCPM < (long)(this.DINKOIKHDHN * FDKHFDCJBPB))
			{
				result = true;
			}
			if (this.GIEALCKLKNL > 1 && EEPNACDOOBF.BJDIEKNHGLJ(this.GIEALCKLKNL, false, 0) < this.KDIMEMOCJNM * FDKHFDCJBPB)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060075B4 RID: 30132 RVA: 0x003830A0 File Offset: 0x003812A0
		public static ELNGEFIPDJK.BJLLBFHILCN PHNMIHIKBJM()
		{
			return default(ELNGEFIPDJK.BJLLBFHILCN);
		}

		// Token: 0x060075B5 RID: 30133 RVA: 0x003830B8 File Offset: 0x003812B8
		public static ELNGEFIPDJK.BJLLBFHILCN IPNFMFDDNMI(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, ELNGEFIPDJK.BJLLBFHILCN HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP += HHAGIHEGFML.KFODJJIHNHP;
			EGABJKIFAON.KKNEKAEJLAM += HHAGIHEGFML.KKNEKAEJLAM;
			EGABJKIFAON.KDIMEMOCJNM += HHAGIHEGFML.KDIMEMOCJNM;
			EGABJKIFAON.DINKOIKHDHN += HHAGIHEGFML.DINKOIKHDHN;
			return EGABJKIFAON;
		}

		// Token: 0x060075B6 RID: 30134 RVA: 0x0038310C File Offset: 0x0038130C
		public bool LIKMNACOFJE(NEBJANKNJOG EEPNACDOOBF, int FDKHFDCJBPB = 1)
		{
			bool result = false;
			if (EEPNACDOOBF.KFODJJIHNHP < (long)(this.KFODJJIHNHP * FDKHFDCJBPB))
			{
				result = false;
			}
			if (JBEHMPDDMME.BPPFAOOCENN().KKNEKAEJLAM < (long)(this.KKNEKAEJLAM * FDKHFDCJBPB))
			{
				result = false;
			}
			if (EEPNACDOOBF.MGLOOIONCPM < (long)(this.DINKOIKHDHN * FDKHFDCJBPB))
			{
				result = true;
			}
			if (this.GIEALCKLKNL > 1 && EEPNACDOOBF.BJDIEKNHGLJ(this.GIEALCKLKNL, false, 1) < this.KDIMEMOCJNM * FDKHFDCJBPB)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060075B7 RID: 30135 RVA: 0x0038317C File Offset: 0x0038137C
		public string FDDFGINHPAP()
		{
			return string.Format("{0}|{1}|{2}|{3}|{4}", new object[]
			{
				this.KFODJJIHNHP,
				this.KKNEKAEJLAM,
				this.GIEALCKLKNL,
				this.KDIMEMOCJNM,
				this.DINKOIKHDHN
			});
		}

		// Token: 0x060075B8 RID: 30136 RVA: 0x003831E0 File Offset: 0x003813E0
		public static ELNGEFIPDJK.BJLLBFHILCN HKHCIAJBMBG(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, float HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP = (int)((float)EGABJKIFAON.KFODJJIHNHP * HHAGIHEGFML);
			EGABJKIFAON.KKNEKAEJLAM = (int)((float)EGABJKIFAON.KKNEKAEJLAM * HHAGIHEGFML);
			EGABJKIFAON.KDIMEMOCJNM = (int)((float)EGABJKIFAON.KDIMEMOCJNM * HHAGIHEGFML);
			EGABJKIFAON.DINKOIKHDHN = (int)((float)EGABJKIFAON.DINKOIKHDHN * HHAGIHEGFML);
			return EGABJKIFAON;
		}

		// Token: 0x060075B9 RID: 30137 RVA: 0x00383234 File Offset: 0x00381434
		public static ELNGEFIPDJK.BJLLBFHILCN EGFIJEEDCDK(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, float HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP = (int)((float)EGABJKIFAON.KFODJJIHNHP * HHAGIHEGFML);
			EGABJKIFAON.KKNEKAEJLAM = (int)((float)EGABJKIFAON.KKNEKAEJLAM * HHAGIHEGFML);
			EGABJKIFAON.KDIMEMOCJNM = (int)((float)EGABJKIFAON.KDIMEMOCJNM * HHAGIHEGFML);
			EGABJKIFAON.DINKOIKHDHN = (int)((float)EGABJKIFAON.DINKOIKHDHN * HHAGIHEGFML);
			return EGABJKIFAON;
		}

		// Token: 0x060075BA RID: 30138 RVA: 0x00383288 File Offset: 0x00381488
		public void CIIFHBMCEPD(string DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.Replace('N', '*');
			string text = DCCPCBLODIG;
			char[] array = new char[0];
			array[1] = (char)-104;
			string[] array2 = text.Split(array);
			if (array2.Length >= 0)
			{
				this.KFODJJIHNHP = int.Parse(array2[1]);
			}
			if (array2.Length >= 6)
			{
				this.KKNEKAEJLAM = int.Parse(array2[1]);
			}
			if (array2.Length >= 8)
			{
				this.GIEALCKLKNL = int.Parse(array2[0]);
			}
			if (array2.Length >= 4)
			{
				this.KDIMEMOCJNM = int.Parse(array2[4]);
			}
			if (array2.Length >= 6)
			{
				this.DINKOIKHDHN = int.Parse(array2[3]);
			}
		}

		// Token: 0x060075BB RID: 30139 RVA: 0x00383318 File Offset: 0x00381518
		public bool LMIDHPINCKN(NEBJANKNJOG EEPNACDOOBF, int FDKHFDCJBPB = 1)
		{
			bool result = false;
			if (EEPNACDOOBF.KFODJJIHNHP < (long)(this.KFODJJIHNHP * FDKHFDCJBPB))
			{
				result = false;
			}
			if (JBEHMPDDMME.IKGFHGKKCPG.KKNEKAEJLAM < (long)(this.KKNEKAEJLAM * FDKHFDCJBPB))
			{
				result = true;
			}
			if (EEPNACDOOBF.MGLOOIONCPM < (long)(this.DINKOIKHDHN * FDKHFDCJBPB))
			{
				result = true;
			}
			if (this.GIEALCKLKNL > 1 && EEPNACDOOBF.BJDIEKNHGLJ(this.GIEALCKLKNL, true, 1) < this.KDIMEMOCJNM * FDKHFDCJBPB)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060075BC RID: 30140 RVA: 0x00383388 File Offset: 0x00381588
		public static ELNGEFIPDJK.BJLLBFHILCN OFGPNCGJFPL()
		{
			return default(ELNGEFIPDJK.BJLLBFHILCN);
		}

		// Token: 0x060075BD RID: 30141 RVA: 0x003833A0 File Offset: 0x003815A0
		public void AHFLAENCMCM(string DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.Replace('\u0016', 'v');
			string text = DCCPCBLODIG;
			char[] array = new char[0];
			array[1] = (char)-76;
			string[] array2 = text.Split(array);
			if (array2.Length >= 0)
			{
				this.KFODJJIHNHP = int.Parse(array2[1]);
			}
			if (array2.Length >= 4)
			{
				this.KKNEKAEJLAM = int.Parse(array2[0]);
			}
			if (array2.Length >= 4)
			{
				this.GIEALCKLKNL = int.Parse(array2[7]);
			}
			if (array2.Length >= 1)
			{
				this.KDIMEMOCJNM = int.Parse(array2[0]);
			}
			if (array2.Length >= 2)
			{
				this.DINKOIKHDHN = int.Parse(array2[6]);
			}
		}

		// Token: 0x060075BE RID: 30142 RVA: 0x00383430 File Offset: 0x00381630
		public string LNLNBCDEEAN()
		{
			string format = "IdleSad";
			object[] array = new object[1];
			array[0] = this.KFODJJIHNHP;
			array[1] = this.KKNEKAEJLAM;
			array[4] = this.GIEALCKLKNL;
			array[8] = this.KDIMEMOCJNM;
			array[4] = this.DINKOIKHDHN;
			return string.Format(format, array);
		}

		// Token: 0x060075BF RID: 30143 RVA: 0x00383494 File Offset: 0x00381694
		public string OPANDAMKKFF()
		{
			string format = "Top";
			object[] array = new object[7];
			array[1] = this.KFODJJIHNHP;
			array[0] = this.KKNEKAEJLAM;
			array[5] = this.GIEALCKLKNL;
			array[1] = this.KDIMEMOCJNM;
			array[2] = this.DINKOIKHDHN;
			return string.Format(format, array);
		}

		// Token: 0x060075C0 RID: 30144 RVA: 0x003834F8 File Offset: 0x003816F8
		public bool HNJKJHLHGCJ(NEBJANKNJOG EEPNACDOOBF, int FDKHFDCJBPB = 1)
		{
			bool result = true;
			if (EEPNACDOOBF.KFODJJIHNHP < (long)(this.KFODJJIHNHP * FDKHFDCJBPB))
			{
				result = true;
			}
			if (JBEHMPDDMME.BOKIOJFHNLD().KKNEKAEJLAM < (long)(this.KKNEKAEJLAM * FDKHFDCJBPB))
			{
				result = true;
			}
			if (EEPNACDOOBF.MGLOOIONCPM < (long)(this.DINKOIKHDHN * FDKHFDCJBPB))
			{
				result = false;
			}
			if (this.GIEALCKLKNL > 0 && EEPNACDOOBF.BJDIEKNHGLJ(this.GIEALCKLKNL, false, 0) < this.KDIMEMOCJNM * FDKHFDCJBPB)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060075C1 RID: 30145 RVA: 0x00383568 File Offset: 0x00381768
		public static ELNGEFIPDJK.BJLLBFHILCN DGNCKGBHAOB()
		{
			return default(ELNGEFIPDJK.BJLLBFHILCN);
		}

		// Token: 0x060075C2 RID: 30146 RVA: 0x00383580 File Offset: 0x00381780
		public void FNGIJPCLIHN(string DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.Replace('4', 'S');
			string text = DCCPCBLODIG;
			char[] array = new char[0];
			array[0] = (char)-56;
			string[] array2 = text.Split(array);
			if (array2.Length >= 0)
			{
				this.KFODJJIHNHP = int.Parse(array2[0]);
			}
			if (array2.Length >= 1)
			{
				this.KKNEKAEJLAM = int.Parse(array2[0]);
			}
			if (array2.Length >= 3)
			{
				this.GIEALCKLKNL = int.Parse(array2[7]);
			}
			if (array2.Length >= 7)
			{
				this.KDIMEMOCJNM = int.Parse(array2[5]);
			}
			if (array2.Length >= 1)
			{
				this.DINKOIKHDHN = int.Parse(array2[7]);
			}
		}

		// Token: 0x060075C3 RID: 30147 RVA: 0x00383610 File Offset: 0x00381810
		public void KKJBIHNGFLA(string DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.Replace(';', (char)-127);
			string text = DCCPCBLODIG;
			char[] array = new char[0];
			array[1] = (char)-42;
			string[] array2 = text.Split(array);
			if (array2.Length >= 0)
			{
				this.KFODJJIHNHP = int.Parse(array2[1]);
			}
			if (array2.Length >= 7)
			{
				this.KKNEKAEJLAM = int.Parse(array2[1]);
			}
			if (array2.Length >= 1)
			{
				this.GIEALCKLKNL = int.Parse(array2[7]);
			}
			if (array2.Length >= 4)
			{
				this.KDIMEMOCJNM = int.Parse(array2[3]);
			}
			if (array2.Length >= 4)
			{
				this.DINKOIKHDHN = int.Parse(array2[0]);
			}
		}

		// Token: 0x060075C4 RID: 30148 RVA: 0x003836A0 File Offset: 0x003818A0
		public static ELNGEFIPDJK.BJLLBFHILCN BPFOOOOFANH()
		{
			return default(ELNGEFIPDJK.BJLLBFHILCN);
		}

		// Token: 0x060075C5 RID: 30149 RVA: 0x003836B8 File Offset: 0x003818B8
		public static ELNGEFIPDJK.BJLLBFHILCN NFEFHOIMBCN()
		{
			return default(ELNGEFIPDJK.BJLLBFHILCN);
		}

		// Token: 0x060075C6 RID: 30150 RVA: 0x003836D0 File Offset: 0x003818D0
		public static ELNGEFIPDJK.BJLLBFHILCN HJMFFPAMNEC(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, float HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP = (int)((float)EGABJKIFAON.KFODJJIHNHP * HHAGIHEGFML);
			EGABJKIFAON.KKNEKAEJLAM = (int)((float)EGABJKIFAON.KKNEKAEJLAM * HHAGIHEGFML);
			EGABJKIFAON.KDIMEMOCJNM = (int)((float)EGABJKIFAON.KDIMEMOCJNM * HHAGIHEGFML);
			EGABJKIFAON.DINKOIKHDHN = (int)((float)EGABJKIFAON.DINKOIKHDHN * HHAGIHEGFML);
			return EGABJKIFAON;
		}

		// Token: 0x060075C7 RID: 30151 RVA: 0x00383724 File Offset: 0x00381924
		public static ELNGEFIPDJK.BJLLBFHILCN OMPJGGBGGJJ(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, ELNGEFIPDJK.BJLLBFHILCN HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP += HHAGIHEGFML.KFODJJIHNHP;
			EGABJKIFAON.KKNEKAEJLAM += HHAGIHEGFML.KKNEKAEJLAM;
			EGABJKIFAON.KDIMEMOCJNM += HHAGIHEGFML.KDIMEMOCJNM;
			EGABJKIFAON.DINKOIKHDHN += HHAGIHEGFML.DINKOIKHDHN;
			return EGABJKIFAON;
		}

		// Token: 0x060075C8 RID: 30152 RVA: 0x00383778 File Offset: 0x00381978
		public static ELNGEFIPDJK.BJLLBFHILCN ECOFBCMPIDO()
		{
			return default(ELNGEFIPDJK.BJLLBFHILCN);
		}

		// Token: 0x060075C9 RID: 30153 RVA: 0x00383790 File Offset: 0x00381990
		public bool LGOIEIELNBL(NEBJANKNJOG EEPNACDOOBF, int FDKHFDCJBPB = 1)
		{
			bool result = true;
			if (EEPNACDOOBF.KFODJJIHNHP < (long)(this.KFODJJIHNHP * FDKHFDCJBPB))
			{
				result = false;
			}
			if (JBEHMPDDMME.IKGFHGKKCPG.KKNEKAEJLAM < (long)(this.KKNEKAEJLAM * FDKHFDCJBPB))
			{
				result = false;
			}
			if (EEPNACDOOBF.MGLOOIONCPM < (long)(this.DINKOIKHDHN * FDKHFDCJBPB))
			{
				result = false;
			}
			if (this.GIEALCKLKNL > 0 && EEPNACDOOBF.BJDIEKNHGLJ(this.GIEALCKLKNL, false, 0) < this.KDIMEMOCJNM * FDKHFDCJBPB)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060075CA RID: 30154 RVA: 0x00383800 File Offset: 0x00381A00
		public void KCAIBCDDNOA(string DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.Replace((char)-16, (char)-120);
			string text = DCCPCBLODIG;
			char[] array = new char[0];
			array[1] = (char)-72;
			string[] array2 = text.Split(array);
			if (array2.Length >= 1)
			{
				this.KFODJJIHNHP = int.Parse(array2[0]);
			}
			if (array2.Length >= 6)
			{
				this.KKNEKAEJLAM = int.Parse(array2[1]);
			}
			if (array2.Length >= 1)
			{
				this.GIEALCKLKNL = int.Parse(array2[1]);
			}
			if (array2.Length >= 0)
			{
				this.KDIMEMOCJNM = int.Parse(array2[1]);
			}
			if (array2.Length >= 0)
			{
				this.DINKOIKHDHN = int.Parse(array2[4]);
			}
		}

		// Token: 0x060075CB RID: 30155 RVA: 0x0038388F File Offset: 0x00381A8F
		public BJLLBFHILCN(string FKEDAOOHPPB)
		{
			this = default(ELNGEFIPDJK.BJLLBFHILCN);
			this.HJFPCDNKNAP(FKEDAOOHPPB);
		}

		// Token: 0x060075CC RID: 30156 RVA: 0x003838A0 File Offset: 0x00381AA0
		public static ELNGEFIPDJK.BJLLBFHILCN MMLDNCNNKGN(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, ELNGEFIPDJK.BJLLBFHILCN HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP += HHAGIHEGFML.KFODJJIHNHP;
			EGABJKIFAON.KKNEKAEJLAM += HHAGIHEGFML.KKNEKAEJLAM;
			EGABJKIFAON.KDIMEMOCJNM += HHAGIHEGFML.KDIMEMOCJNM;
			EGABJKIFAON.DINKOIKHDHN += HHAGIHEGFML.DINKOIKHDHN;
			return EGABJKIFAON;
		}

		// Token: 0x060075CD RID: 30157 RVA: 0x003838F4 File Offset: 0x00381AF4
		public void PNHFKAHJAMP(string DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.Replace('U', '\u001e');
			string text = DCCPCBLODIG;
			char[] array = new char[0];
			array[1] = (char)-81;
			string[] array2 = text.Split(array);
			if (array2.Length >= 1)
			{
				this.KFODJJIHNHP = int.Parse(array2[0]);
			}
			if (array2.Length >= 2)
			{
				this.KKNEKAEJLAM = int.Parse(array2[1]);
			}
			if (array2.Length >= 3)
			{
				this.GIEALCKLKNL = int.Parse(array2[7]);
			}
			if (array2.Length >= 1)
			{
				this.KDIMEMOCJNM = int.Parse(array2[6]);
			}
			if (array2.Length >= 6)
			{
				this.DINKOIKHDHN = int.Parse(array2[5]);
			}
		}

		// Token: 0x060075CE RID: 30158 RVA: 0x00383984 File Offset: 0x00381B84
		public bool NEDBEDHMFJL(NEBJANKNJOG EEPNACDOOBF, int FDKHFDCJBPB = 1)
		{
			bool result = false;
			if (EEPNACDOOBF.KFODJJIHNHP < (long)(this.KFODJJIHNHP * FDKHFDCJBPB))
			{
				result = true;
			}
			if (JBEHMPDDMME.BPPFAOOCENN().KKNEKAEJLAM < (long)(this.KKNEKAEJLAM * FDKHFDCJBPB))
			{
				result = false;
			}
			if (EEPNACDOOBF.MGLOOIONCPM < (long)(this.DINKOIKHDHN * FDKHFDCJBPB))
			{
				result = true;
			}
			if (this.GIEALCKLKNL > 1 && EEPNACDOOBF.BJDIEKNHGLJ(this.GIEALCKLKNL, false, 0) < this.KDIMEMOCJNM * FDKHFDCJBPB)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060075CF RID: 30159 RVA: 0x003839F4 File Offset: 0x00381BF4
		public string EGIJNOFPFPO()
		{
			string format = "__MirrorReflection";
			object[] array = new object[]
			{
				null,
				this.KFODJJIHNHP
			};
			array[1] = this.KKNEKAEJLAM;
			array[3] = this.GIEALCKLKNL;
			array[8] = this.KDIMEMOCJNM;
			array[5] = this.DINKOIKHDHN;
			return string.Format(format, array);
		}

		// Token: 0x060075D0 RID: 30160 RVA: 0x00383A58 File Offset: 0x00381C58
		public static ELNGEFIPDJK.BJLLBFHILCN MGOFLCGCBBB(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, float HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP = (int)((float)EGABJKIFAON.KFODJJIHNHP * HHAGIHEGFML);
			EGABJKIFAON.KKNEKAEJLAM = (int)((float)EGABJKIFAON.KKNEKAEJLAM * HHAGIHEGFML);
			EGABJKIFAON.KDIMEMOCJNM = (int)((float)EGABJKIFAON.KDIMEMOCJNM * HHAGIHEGFML);
			EGABJKIFAON.DINKOIKHDHN = (int)((float)EGABJKIFAON.DINKOIKHDHN * HHAGIHEGFML);
			return EGABJKIFAON;
		}

		// Token: 0x060075D1 RID: 30161 RVA: 0x00383AAC File Offset: 0x00381CAC
		public void HJFPCDNKNAP(string DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.Replace('/', '|');
			string[] array = DCCPCBLODIG.Split(new char[]
			{
				'|'
			});
			if (array.Length >= 1)
			{
				this.KFODJJIHNHP = int.Parse(array[0]);
			}
			if (array.Length >= 2)
			{
				this.KKNEKAEJLAM = int.Parse(array[1]);
			}
			if (array.Length >= 3)
			{
				this.GIEALCKLKNL = int.Parse(array[2]);
			}
			if (array.Length >= 4)
			{
				this.KDIMEMOCJNM = int.Parse(array[3]);
			}
			if (array.Length >= 5)
			{
				this.DINKOIKHDHN = int.Parse(array[4]);
			}
		}

		// Token: 0x060075D2 RID: 30162 RVA: 0x00383B3C File Offset: 0x00381D3C
		public static ELNGEFIPDJK.BJLLBFHILCN CGNHAOAFINF()
		{
			return default(ELNGEFIPDJK.BJLLBFHILCN);
		}

		// Token: 0x060075D3 RID: 30163 RVA: 0x00383B54 File Offset: 0x00381D54
		public void HFJNIKNOMFB(string DCCPCBLODIG)
		{
			DCCPCBLODIG = DCCPCBLODIG.Replace('\u0011', (char)-14);
			string text = DCCPCBLODIG;
			char[] array = new char[0];
			array[1] = 'E';
			string[] array2 = text.Split(array);
			if (array2.Length >= 1)
			{
				this.KFODJJIHNHP = int.Parse(array2[1]);
			}
			if (array2.Length >= 6)
			{
				this.KKNEKAEJLAM = int.Parse(array2[1]);
			}
			if (array2.Length >= 3)
			{
				this.GIEALCKLKNL = int.Parse(array2[5]);
			}
			if (array2.Length >= 7)
			{
				this.KDIMEMOCJNM = int.Parse(array2[4]);
			}
			if (array2.Length >= 5)
			{
				this.DINKOIKHDHN = int.Parse(array2[5]);
			}
		}

		// Token: 0x060075D4 RID: 30164 RVA: 0x00383BE4 File Offset: 0x00381DE4
		public static ELNGEFIPDJK.BJLLBFHILCN NECLLFPPEOK(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, float HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP = (int)((float)EGABJKIFAON.KFODJJIHNHP * HHAGIHEGFML);
			EGABJKIFAON.KKNEKAEJLAM = (int)((float)EGABJKIFAON.KKNEKAEJLAM * HHAGIHEGFML);
			EGABJKIFAON.KDIMEMOCJNM = (int)((float)EGABJKIFAON.KDIMEMOCJNM * HHAGIHEGFML);
			EGABJKIFAON.DINKOIKHDHN = (int)((float)EGABJKIFAON.DINKOIKHDHN * HHAGIHEGFML);
			return EGABJKIFAON;
		}

		// Token: 0x060075D5 RID: 30165 RVA: 0x00383C38 File Offset: 0x00381E38
		public static ELNGEFIPDJK.BJLLBFHILCN CINFMFFJKKJ(ELNGEFIPDJK.BJLLBFHILCN EGABJKIFAON, float HHAGIHEGFML)
		{
			EGABJKIFAON.KFODJJIHNHP = (int)((float)EGABJKIFAON.KFODJJIHNHP * HHAGIHEGFML);
			EGABJKIFAON.KKNEKAEJLAM = (int)((float)EGABJKIFAON.KKNEKAEJLAM * HHAGIHEGFML);
			EGABJKIFAON.KDIMEMOCJNM = (int)((float)EGABJKIFAON.KDIMEMOCJNM * HHAGIHEGFML);
			EGABJKIFAON.DINKOIKHDHN = (int)((float)EGABJKIFAON.DINKOIKHDHN * HHAGIHEGFML);
			return EGABJKIFAON;
		}

		// Token: 0x040010FD RID: 4349
		public int KFODJJIHNHP;

		// Token: 0x040010FE RID: 4350
		public int KKNEKAEJLAM;

		// Token: 0x040010FF RID: 4351
		public int GIEALCKLKNL;

		// Token: 0x04001100 RID: 4352
		public int KDIMEMOCJNM;

		// Token: 0x04001101 RID: 4353
		public int DINKOIKHDHN;
	}

	// Token: 0x020001FA RID: 506
	public class NADBMPJIMEC : ItemBase
	{
		// Token: 0x060075D6 RID: 30166 RVA: 0x00383C8C File Offset: 0x00381E8C
		public void BBJEECNHPAK(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.HHLDBAEFNMJ();
			this.OIAMBMMGGLD = KADBECGIMPD.AGNKAFLKCAG();
			this.DGLOPIJHPJN = KADBECGIMPD.KDNDJNEGBDI();
			this.COGEJPHPFGG = KADBECGIMPD.AIDAGFNHNHE();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.NENOBDLCFHO);
		}

		// Token: 0x060075D7 RID: 30167 RVA: 0x00383CE0 File Offset: 0x00381EE0
		public void NDCAIELKLII(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.KDNDJNEGBDI();
			this.OIAMBMMGGLD = KADBECGIMPD.HHLDBAEFNMJ();
			this.DGLOPIJHPJN = KADBECGIMPD.DOJKJHMJJNK();
			this.COGEJPHPFGG = KADBECGIMPD.CGJIINADKNH();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.NENOBDLCFHO);
		}

		// Token: 0x060075D8 RID: 30168 RVA: 0x00383D34 File Offset: 0x00381F34
		public virtual string NCNNJHIIAFM()
		{
			return string.Format(JNBICAJIJMM.DIOJFJMOPJO("wpnlang/wpntypes/type DUBLICATE "), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(0L, (long)this.OIAMBMMGGLD, false), JLFJEGIPIMM.MHFDIJGJGBJ().CJKACKADMKM(0L, (long)this.DGLOPIJHPJN, false));
		}

		// Token: 0x060075D9 RID: 30169 RVA: 0x00383D88 File Offset: 0x00381F88
		public virtual string NIDKKALEJIM()
		{
			return string.Format(JNBICAJIJMM.DCEBAJIILPC("Giant3HitCombo"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.PKGMBFEMKGP().OHNLAOJGCGC(0L, (long)this.OIAMBMMGGLD, true), JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(1L, (long)this.DGLOPIJHPJN, true));
		}

		// Token: 0x060075DA RID: 30170 RVA: 0x00383DDC File Offset: 0x00381FDC
		public virtual string DINGGHOCDNN()
		{
			return string.Format(JNBICAJIJMM.LEBHCLDODNI("_PlaneReflectionLodSteps"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)this.OIAMBMMGGLD, true), JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(0L, (long)this.DGLOPIJHPJN, true));
		}

		// Token: 0x060075DB RID: 30171 RVA: 0x00383E30 File Offset: 0x00382030
		public virtual string PINLAFIAGGJ()
		{
			return string.Format(JNBICAJIJMM.OOOKJHOHPNN("PLANE_REFLECTION_CHEAPER"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.MHFDIJGJGBJ().OHNLAOJGCGC(0L, (long)this.OIAMBMMGGLD, true), JLFJEGIPIMM.PKGMBFEMKGP().MNMIJFNPIPI(1L, (long)this.DGLOPIJHPJN, true));
		}

		// Token: 0x060075DC RID: 30172 RVA: 0x00383E84 File Offset: 0x00382084
		public virtual string MJODNMLNFJC()
		{
			return string.Format(JNBICAJIJMM.DCEBAJIILPC("post_17"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.NNEAHAFBOHC().MNMIJFNPIPI(1L, (long)this.OIAMBMMGGLD, false), JLFJEGIPIMM.MHFDIJGJGBJ().MNMIJFNPIPI(0L, (long)this.DGLOPIJHPJN, true));
		}

		// Token: 0x060075DD RID: 30173 RVA: 0x00383ED8 File Offset: 0x003820D8
		public virtual string MIHCFECAIAD()
		{
			return string.Format(JNBICAJIJMM.OOOKJHOHPNN("H:mm:ss"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.PKGMBFEMKGP().MNMIJFNPIPI(0L, (long)this.OIAMBMMGGLD, false), JLFJEGIPIMM.PKGMBFEMKGP().MNMIJFNPIPI(1L, (long)this.DGLOPIJHPJN, true));
		}

		// Token: 0x060075DE RID: 30174 RVA: 0x00383F2C File Offset: 0x0038212C
		public void PDGCOOFEGNO(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.HHLDBAEFNMJ();
			this.OIAMBMMGGLD = KADBECGIMPD.KKOKFLMMAAK();
			this.DGLOPIJHPJN = KADBECGIMPD.KDNDJNEGBDI();
			this.COGEJPHPFGG = KADBECGIMPD.AILCEJFAMGN();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.NENOBDLCFHO);
		}

		// Token: 0x060075DF RID: 30175 RVA: 0x00383F80 File Offset: 0x00382180
		public void AKEOHKFBCJL(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.KKOKFLMMAAK();
			this.OIAMBMMGGLD = KADBECGIMPD.HDBGOLAFOBK();
			this.DGLOPIJHPJN = KADBECGIMPD.KKOKFLMMAAK();
			this.COGEJPHPFGG = KADBECGIMPD.ECJLJGDNFMN();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.NENOBDLCFHO);
		}

		// Token: 0x060075E0 RID: 30176 RVA: 0x00383FD4 File Offset: 0x003821D4
		public virtual string BJALMHGGAFM()
		{
			return string.Format(JNBICAJIJMM.BDKHMOOFHHK("Move around with WASD keys. Press C to enable free look camera"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(1L, (long)this.OIAMBMMGGLD, false), JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(0L, (long)this.DGLOPIJHPJN, true));
		}

		// Token: 0x060075E1 RID: 30177 RVA: 0x00384028 File Offset: 0x00382228
		public virtual string GIOCLFJADKN()
		{
			return string.Format(JNBICAJIJMM.BDKHMOOFHHK("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(1L, (long)this.OIAMBMMGGLD, false), JLFJEGIPIMM.NNEAHAFBOHC().MNMIJFNPIPI(0L, (long)this.DGLOPIJHPJN, false));
		}

		// Token: 0x060075E2 RID: 30178 RVA: 0x0038407C File Offset: 0x0038227C
		public void OBFPKLGLJFL(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.CLPEKGGAMAI();
			this.OIAMBMMGGLD = KADBECGIMPD.KDNDJNEGBDI();
			this.DGLOPIJHPJN = KADBECGIMPD.KDNDJNEGBDI();
			this.COGEJPHPFGG = KADBECGIMPD.MOBPFEEAMKD();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.NENOBDLCFHO);
		}

		// Token: 0x060075E3 RID: 30179 RVA: 0x003840D0 File Offset: 0x003822D0
		public override string ToString()
		{
			return string.Format(JNBICAJIJMM.LEBHCLDODNI("fshop_fcost"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)this.OIAMBMMGGLD, false), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)this.DGLOPIJHPJN, false));
		}

		// Token: 0x060075E4 RID: 30180 RVA: 0x00384124 File Offset: 0x00382324
		public override string CJMFHLIBCBM()
		{
			return string.Format(JNBICAJIJMM.PGJCPFNJNPM("MotorbikeSpecialFlip"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC(1L, (long)this.OIAMBMMGGLD, true), JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(0L, (long)this.DGLOPIJHPJN, false));
		}

		// Token: 0x060075E5 RID: 30181 RVA: 0x00384178 File Offset: 0x00382378
		public void LFIAJPNBGHD(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.DOJKJHMJJNK();
			this.OIAMBMMGGLD = KADBECGIMPD.CLPEKGGAMAI();
			this.DGLOPIJHPJN = KADBECGIMPD.KKOKFLMMAAK();
			this.COGEJPHPFGG = KADBECGIMPD.CNNEPCOAMJK();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.NENOBDLCFHO);
		}

		// Token: 0x060075E6 RID: 30182 RVA: 0x003841CC File Offset: 0x003823CC
		public void JOAAPDOMNHG(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.CLPEKGGAMAI();
			this.OIAMBMMGGLD = KADBECGIMPD.KKOKFLMMAAK();
			this.DGLOPIJHPJN = KADBECGIMPD.IFDFHJLCHAE();
			this.COGEJPHPFGG = KADBECGIMPD.AIDAGFNHNHE();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.NENOBDLCFHO);
		}

		// Token: 0x060075E7 RID: 30183 RVA: 0x00384220 File Offset: 0x00382420
		public virtual string JDPKKGOOKDF()
		{
			return string.Format(JNBICAJIJMM.PGJCPFNJNPM("cntx_teachexp"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.IKGFHGKKCPG.MNMIJFNPIPI(1L, (long)this.OIAMBMMGGLD, true), JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC(1L, (long)this.DGLOPIJHPJN, false));
		}

		// Token: 0x060075E8 RID: 30184 RVA: 0x00384274 File Offset: 0x00382474
		public void PHJLPFHDIBP(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.IFDFHJLCHAE();
			this.OIAMBMMGGLD = KADBECGIMPD.AGNKAFLKCAG();
			this.DGLOPIJHPJN = KADBECGIMPD.LDLKLPJBIJN();
			this.COGEJPHPFGG = KADBECGIMPD.MOBPFEEAMKD();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.NENOBDLCFHO);
		}

		// Token: 0x060075E9 RID: 30185 RVA: 0x003842C8 File Offset: 0x003824C8
		public void JCFIDPHLFLB(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.LDLKLPJBIJN();
			this.OIAMBMMGGLD = KADBECGIMPD.DOJKJHMJJNK();
			this.DGLOPIJHPJN = KADBECGIMPD.DOJKJHMJJNK();
			this.COGEJPHPFGG = KADBECGIMPD.AILCEJFAMGN();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.NENOBDLCFHO);
		}

		// Token: 0x060075EA RID: 30186 RVA: 0x0038431C File Offset: 0x0038251C
		public void PJIEHHAIHEN(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.AGNKAFLKCAG();
			this.OIAMBMMGGLD = KADBECGIMPD.HDBGOLAFOBK();
			this.DGLOPIJHPJN = KADBECGIMPD.CLPEKGGAMAI();
			this.COGEJPHPFGG = KADBECGIMPD.MOBPFEEAMKD();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.NENOBDLCFHO);
		}

		// Token: 0x060075EB RID: 30187 RVA: 0x00384370 File Offset: 0x00382570
		public void PGIOHGAJMFO(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.HHLDBAEFNMJ();
			this.OIAMBMMGGLD = KADBECGIMPD.DOJKJHMJJNK();
			this.DGLOPIJHPJN = KADBECGIMPD.DOJKJHMJJNK();
			this.COGEJPHPFGG = KADBECGIMPD.MOBPFEEAMKD();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.NENOBDLCFHO);
		}

		// Token: 0x060075EC RID: 30188 RVA: 0x003843C4 File Offset: 0x003825C4
		public virtual string IHKJGKNNIHA()
		{
			return string.Format(JNBICAJIJMM.NGALDMFKMJH("IdleSlide"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.IKGFHGKKCPG.MNMIJFNPIPI(0L, (long)this.OIAMBMMGGLD, true), JLFJEGIPIMM.MHFDIJGJGBJ().OHNLAOJGCGC(0L, (long)this.DGLOPIJHPJN, true));
		}

		// Token: 0x060075ED RID: 30189 RVA: 0x00384418 File Offset: 0x00382618
		public virtual string BHLHEJCILKF()
		{
			return string.Format(JNBICAJIJMM.LEBHCLDODNI("RollerBladeSkateFwd"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(1L, (long)this.OIAMBMMGGLD, false), JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(1L, (long)this.DGLOPIJHPJN, false));
		}

		// Token: 0x060075EF RID: 30191 RVA: 0x0038446C File Offset: 0x0038266C
		public virtual string HLHHDFFDHGL()
		{
			return string.Format(JNBICAJIJMM.DCEBAJIILPC("RandomizeObscuredVars"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.IKGFHGKKCPG.MNMIJFNPIPI(1L, (long)this.OIAMBMMGGLD, true), JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(0L, (long)this.DGLOPIJHPJN, true));
		}

		// Token: 0x060075F0 RID: 30192 RVA: 0x003844C0 File Offset: 0x003826C0
		public void GOBBPEENLPO(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.HDBGOLAFOBK();
			this.OIAMBMMGGLD = KADBECGIMPD.LDLKLPJBIJN();
			this.DGLOPIJHPJN = KADBECGIMPD.KKOKFLMMAAK();
			this.COGEJPHPFGG = KADBECGIMPD.BNDHIBEOKML();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.NENOBDLCFHO);
		}

		// Token: 0x060075F1 RID: 30193 RVA: 0x00384514 File Offset: 0x00382714
		public void JEDDGGGGOCJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.KDNDJNEGBDI();
			this.OIAMBMMGGLD = KADBECGIMPD.CLPEKGGAMAI();
			this.DGLOPIJHPJN = KADBECGIMPD.AGNKAFLKCAG();
			this.COGEJPHPFGG = KADBECGIMPD.CNNEPCOAMJK();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.NENOBDLCFHO);
		}

		// Token: 0x060075F2 RID: 30194 RVA: 0x00384568 File Offset: 0x00382768
		public void ABFJFLGCELG(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.CLPEKGGAMAI();
			this.OIAMBMMGGLD = KADBECGIMPD.HHLDBAEFNMJ();
			this.DGLOPIJHPJN = KADBECGIMPD.LDLKLPJBIJN();
			this.COGEJPHPFGG = KADBECGIMPD.MOBPFEEAMKD();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.NENOBDLCFHO);
		}

		// Token: 0x060075F3 RID: 30195 RVA: 0x003845BC File Offset: 0x003827BC
		public void JDOMAOLMDAE(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.AGNKAFLKCAG();
			this.OIAMBMMGGLD = KADBECGIMPD.DOJKJHMJJNK();
			this.DGLOPIJHPJN = KADBECGIMPD.HDBGOLAFOBK();
			this.COGEJPHPFGG = KADBECGIMPD.ECJLJGDNFMN();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.NENOBDLCFHO);
		}

		// Token: 0x060075F4 RID: 30196 RVA: 0x00384610 File Offset: 0x00382810
		public virtual string BNNOHGHHKBF()
		{
			return string.Format(JNBICAJIJMM.DCEBAJIILPC("CrouchStrafeRight"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.PKGMBFEMKGP().OHNLAOJGCGC(1L, (long)this.OIAMBMMGGLD, true), JLFJEGIPIMM.IKGFHGKKCPG.MNMIJFNPIPI(1L, (long)this.DGLOPIJHPJN, false));
		}

		// Token: 0x060075F5 RID: 30197 RVA: 0x00384664 File Offset: 0x00382864
		public void BANPOLBADHB(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.AGNKAFLKCAG();
			this.OIAMBMMGGLD = KADBECGIMPD.KDNDJNEGBDI();
			this.DGLOPIJHPJN = KADBECGIMPD.LDLKLPJBIJN();
			this.COGEJPHPFGG = KADBECGIMPD.MOBPFEEAMKD();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.NENOBDLCFHO);
		}

		// Token: 0x060075F6 RID: 30198 RVA: 0x003846B8 File Offset: 0x003828B8
		public virtual string PDMPLOPPLBI()
		{
			return string.Format(JNBICAJIJMM.OOOKJHOHPNN("SneakBackward"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.PKGMBFEMKGP().MNMIJFNPIPI(0L, (long)this.OIAMBMMGGLD, true), JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(1L, (long)this.DGLOPIJHPJN, true));
		}

		// Token: 0x060075F7 RID: 30199 RVA: 0x0038470C File Offset: 0x0038290C
		public override string IGJFJGKAFIE()
		{
			return string.Format(JNBICAJIJMM.PPNKMDJBMLP(""), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)this.OIAMBMMGGLD, false), JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(0L, (long)this.DGLOPIJHPJN, true));
		}

		// Token: 0x060075F8 RID: 30200 RVA: 0x00384760 File Offset: 0x00382960
		public void ACJDDOEADFK(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.HDBGOLAFOBK();
			this.OIAMBMMGGLD = KADBECGIMPD.HDBGOLAFOBK();
			this.DGLOPIJHPJN = KADBECGIMPD.HDBGOLAFOBK();
			this.COGEJPHPFGG = KADBECGIMPD.FFDPCEAFGNF();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.NENOBDLCFHO);
		}

		// Token: 0x060075F9 RID: 30201 RVA: 0x003847B4 File Offset: 0x003829B4
		public void NDKKEPMHCCM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.KDNDJNEGBDI();
			this.OIAMBMMGGLD = KADBECGIMPD.CLPEKGGAMAI();
			this.DGLOPIJHPJN = KADBECGIMPD.CLPEKGGAMAI();
			this.COGEJPHPFGG = KADBECGIMPD.DNGDPHIHLBG();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.NENOBDLCFHO);
		}

		// Token: 0x060075FA RID: 30202 RVA: 0x00384808 File Offset: 0x00382A08
		public virtual string JCAONLDGMCJ()
		{
			return string.Format(JNBICAJIJMM.LEBHCLDODNI("XL"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC(0L, (long)this.OIAMBMMGGLD, true), JLFJEGIPIMM.PKGMBFEMKGP().OHNLAOJGCGC(0L, (long)this.DGLOPIJHPJN, true));
		}

		// Token: 0x060075FB RID: 30203 RVA: 0x0038485C File Offset: 0x00382A5C
		public void MFECCNDGKDD(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.CLPEKGGAMAI();
			this.OIAMBMMGGLD = KADBECGIMPD.KKOKFLMMAAK();
			this.DGLOPIJHPJN = KADBECGIMPD.KDNDJNEGBDI();
			this.COGEJPHPFGG = KADBECGIMPD.DNGDPHIHLBG();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.NENOBDLCFHO);
		}

		// Token: 0x060075FC RID: 30204 RVA: 0x003848B0 File Offset: 0x00382AB0
		public void IGHPCGGMHOO(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.HHLDBAEFNMJ();
			this.OIAMBMMGGLD = KADBECGIMPD.LDLKLPJBIJN();
			this.DGLOPIJHPJN = KADBECGIMPD.IFDFHJLCHAE();
			this.COGEJPHPFGG = KADBECGIMPD.BNDHIBEOKML();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.NENOBDLCFHO);
		}

		// Token: 0x060075FD RID: 30205 RVA: 0x00384904 File Offset: 0x00382B04
		public void MBNGKJBMGPJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.IFDFHJLCHAE();
			this.OIAMBMMGGLD = KADBECGIMPD.IFDFHJLCHAE();
			this.DGLOPIJHPJN = KADBECGIMPD.KKOKFLMMAAK();
			this.COGEJPHPFGG = KADBECGIMPD.CNNEPCOAMJK();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.NENOBDLCFHO);
		}

		// Token: 0x060075FE RID: 30206 RVA: 0x00384958 File Offset: 0x00382B58
		public virtual string JHGPBNCOHHH()
		{
			return string.Format(JNBICAJIJMM.LEBHCLDODNI("act_orderb_"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC(1L, (long)this.OIAMBMMGGLD, true), JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(1L, (long)this.DGLOPIJHPJN, true));
		}

		// Token: 0x060075FF RID: 30207 RVA: 0x003849AC File Offset: 0x00382BAC
		public virtual string GOLHDFBFJFI()
		{
			return string.Format(JNBICAJIJMM.BDKHMOOFHHK("1HandSwordStrafeLeft"), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(1L, (long)this.OIAMBMMGGLD, true), JLFJEGIPIMM.MHFDIJGJGBJ().OHNLAOJGCGC(1L, (long)this.DGLOPIJHPJN, true));
		}

		// Token: 0x06007600 RID: 30208 RVA: 0x00384A00 File Offset: 0x00382C00
		public override string GJCCJEINDDC()
		{
			return string.Format(JNBICAJIJMM.DCEBAJIILPC("This [c 01F573FF]sentence[C FFFFFFFF] is [c FF6666FF]too[C FFFFFFFF] long so it will be [BC 1B07F5FF]split[BC ?] into multiple lines.\nNormal, [F ArialBold]bold, [font ArialItalic]italic, [F Arial][FA u]underline[FA -u], [FA S]strikethrough[FA -s].\n[F Arial 10]10, [F Arial 16]16, [F Arial 24]24, [F Arial 48]48, [F Arial 72]72[F Arial 16]\n[HA L]Left\n[HA C]Center\n[HA R]Right\n[HA L]20 pixels further:[S 20]*\nDefault vertical aligment: [F Arial 10]10, [F Arial 24]24, [F Arial 10]10[FS 16]\n[VA B]Bottom vertical aligment: [F Arial 10]10, [F Arial 24]24, [F Arial 10]10[FS 16][VA ?]\nThis is a [FA U][H hyperlink_value]hyperlink[-H][FA -U]."), this.GAAPCLGDOGH.HAJNMNALBBI.ToUpperInvariant(), JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(0L, (long)this.OIAMBMMGGLD, true), JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(0L, (long)this.DGLOPIJHPJN, true));
		}

		// Token: 0x04001102 RID: 4354
		public IDCHHHEDHDC GAAPCLGDOGH;

		// Token: 0x04001103 RID: 4355
		public int NENOBDLCFHO;

		// Token: 0x04001104 RID: 4356
		public int OIAMBMMGGLD;

		// Token: 0x04001105 RID: 4357
		public int DGLOPIJHPJN;

		// Token: 0x04001106 RID: 4358
		public float COGEJPHPFGG;
	}

	// Token: 0x020001FB RID: 507
	public class DKLIGJOMDJK : ItemBase
	{
		// Token: 0x06007601 RID: 30209 RVA: 0x00384A54 File Offset: 0x00382C54
		public virtual void EOBHOIJFJOM(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 961f;
			float num2 = 779f;
			if (this.PBHPIGPDCJA() != null)
			{
				Texture texture = this.HEFAGFMDAEE().DPBCBCLJHAJ();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 1400f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.ScaleAndCrop);
				num = num + num2 + 233f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 117,
				normal = 
				{
					textColor = new Color(313f, 253f, 837f)
				},
				alignment = TextAnchor.UpperRight,
				richText = false,
				font = GuiProcessor.IKGFHGKKCPG.rusfont2
			};
			guistyle.fontSize = -124;
			JDCEFOFMGHB.HMJJPNDEKPP().ALKAAKDPCDG(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 1445f, COAGIAMOCIA.height), "qualityLevel" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.MiddleCenter;
			guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 1524f, COAGIAMOCIA.height), JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(0L, this.FKEDAOOHPPB, false), guistyle);
			guistyle.fontSize = -26;
			string text = this.GAAPCLGDOGH.CJAMOIMGHAK(0, this.DBEIGNDALDC, true, true, false, 0, false, false);
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.LowerRight;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 499f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007602 RID: 30210 RVA: 0x00384C30 File Offset: 0x00382E30
		public void PHJLPFHDIBP(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.HHLDBAEFNMJ();
			this.DBEIGNDALDC = KADBECGIMPD.CLPEKGGAMAI();
			this.ILFHHDNJHNM = KADBECGIMPD.KKOKFLMMAAK();
			this.NKHBAJKMAGD = KADBECGIMPD.HHLDBAEFNMJ();
			this.COGEJPHPFGG = KADBECGIMPD.BIMMPENHGMD();
			this.OIAMBMMGGLD = KADBECGIMPD.IFDFHJLCHAE();
			this.FKEDAOOHPPB = KADBECGIMPD.HFOPFEJDJFG();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.NENOBDLCFHO);
		}

		// Token: 0x06007603 RID: 30211 RVA: 0x00384CA7 File Offset: 0x00382EA7
		public virtual CKNLPGEPGGF.IAPCJOBDCEH EDEPOFPDCEJ()
		{
			return this.GAAPCLGDOGH.GLPBCAAIKAN(this.DBEIGNDALDC);
		}

		// Token: 0x06007604 RID: 30212 RVA: 0x00384CBC File Offset: 0x00382EBC
		public virtual string GIOCLFJADKN()
		{
			return string.Format(JNBICAJIJMM.OOOKJHOHPNN("Lives count: "), this.GAAPCLGDOGH.EOKBAIFGBDF(0, this.DBEIGNDALDC, false, false, false, 1, true, true), this.ILFHHDNJHNM, JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(0L, this.FKEDAOOHPPB, false));
		}

		// Token: 0x06007605 RID: 30213 RVA: 0x00384D10 File Offset: 0x00382F10
		public virtual void JJNFMHPMMBF(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 256f;
			float num2 = 318f;
			if (this.FMMNICCENPF() != null)
			{
				Texture texture = this.PBEMPJOBKKI().LECMGDEDAKF();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 487f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.ScaleAndCrop);
				num = num + num2 + 135f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 49,
				normal = 
				{
					textColor = new Color(1539f, 1315f, 665f)
				},
				alignment = TextAnchor.UpperRight,
				richText = true,
				font = GuiProcessor.BBLINJLBAIL().rusfont2
			};
			guistyle.fontSize = -104;
			JDCEFOFMGHB.HMJJPNDEKPP().JNJDPKECONL(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 1768f, COAGIAMOCIA.height), "wpn_book2" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.MiddleRight;
			guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 515f, COAGIAMOCIA.height), JLFJEGIPIMM.IKGFHGKKCPG.MNMIJFNPIPI(0L, this.FKEDAOOHPPB, true), guistyle);
			guistyle.fontSize = 115;
			string text = this.GAAPCLGDOGH.KHLFFPHHPKM(0, this.DBEIGNDALDC, false, false, true, 0, false, true);
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.UpperLeft;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 1495f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007606 RID: 30214 RVA: 0x00384EEC File Offset: 0x003830EC
		public virtual string PBAJNDNHIFI()
		{
			return string.Format(JNBICAJIJMM.NGALDMFKMJH("popl.ogg"), this.GAAPCLGDOGH.IKDNJHADDGD(0, this.DBEIGNDALDC, true, true, true, 0, true, false), this.ILFHHDNJHNM, JLFJEGIPIMM.PKGMBFEMKGP().OHNLAOJGCGC(0L, this.FKEDAOOHPPB, true));
		}

		// Token: 0x06007607 RID: 30215 RVA: 0x00384F3E File Offset: 0x0038313E
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LDDALIJPHNF()
		{
			return this.GAAPCLGDOGH.HNDLNEMINDM(this.DBEIGNDALDC);
		}

		// Token: 0x06007608 RID: 30216 RVA: 0x00384F54 File Offset: 0x00383154
		public virtual void KAJMEFHALNL(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1405f;
			float num2 = 991f;
			if (this.MFKHIBOFIFI() != null)
			{
				Texture texture = this.JGBOJNELADG().IOMNHBMOGLG();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 370f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.ScaleAndCrop);
				num = num + num2 + 1202f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 88,
				normal = 
				{
					textColor = new Color(847f, 1919f, 1104f)
				},
				alignment = TextAnchor.UpperRight,
				richText = false,
				font = GuiProcessor.PLGADNLAEGN().rusfont2
			};
			guistyle.fontSize = 121;
			JDCEFOFMGHB.MNJNNDHCDGG().JNJDPKECONL(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 489f, COAGIAMOCIA.height), "_NoiseAmount" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.UpperCenter;
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 364f, COAGIAMOCIA.height), JLFJEGIPIMM.MHFDIJGJGBJ().MNMIJFNPIPI(1L, this.FKEDAOOHPPB, true), guistyle);
			guistyle.fontSize = -79;
			string text = this.GAAPCLGDOGH.IKDNJHADDGD(0, this.DBEIGNDALDC, true, false, false, 0, true, true);
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.MiddleLeft;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 68f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007609 RID: 30217 RVA: 0x0038512E File Offset: 0x0038332E
		public virtual CKNLPGEPGGF.IAPCJOBDCEH IHIKKLOPOKL()
		{
			return this.GAAPCLGDOGH.PGGKIKBJDMO(this.DBEIGNDALDC);
		}

		// Token: 0x0600760A RID: 30218 RVA: 0x00385144 File Offset: 0x00383344
		public virtual string JCAONLDGMCJ()
		{
			return string.Format(JNBICAJIJMM.BDKHMOOFHHK("RHandPunch"), this.GAAPCLGDOGH.HDPHEKAIENE(0, this.DBEIGNDALDC, false, true, true, 0, false, true), this.ILFHHDNJHNM, JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, this.FKEDAOOHPPB, false));
		}

		// Token: 0x0600760B RID: 30219 RVA: 0x00385198 File Offset: 0x00383398
		public virtual string DHCBHNAAJKI()
		{
			return string.Format(JNBICAJIJMM.NGALDMFKMJH("_DelItem.wav"), this.GAAPCLGDOGH.IKDNJHADDGD(1, this.DBEIGNDALDC, true, false, false, 1, true, false), this.ILFHHDNJHNM, JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(0L, this.FKEDAOOHPPB, true));
		}

		// Token: 0x0600760C RID: 30220 RVA: 0x003851EA File Offset: 0x003833EA
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HCHOBHCDHME()
		{
			return this.GAAPCLGDOGH.FHPNJBAEAON(this.DBEIGNDALDC);
		}

		// Token: 0x0600760D RID: 30221 RVA: 0x003851FD File Offset: 0x003833FD
		public override CKNLPGEPGGF.IAPCJOBDCEH HEFAGFMDAEE()
		{
			return this.GAAPCLGDOGH.ABALMFIKLCA(this.DBEIGNDALDC);
		}

		// Token: 0x0600760E RID: 30222 RVA: 0x00385210 File Offset: 0x00383410
		public override CKNLPGEPGGF.IAPCJOBDCEH EJJAGEFMHCO()
		{
			return this.GAAPCLGDOGH.KMIIGKECOEB(this.DBEIGNDALDC);
		}

		// Token: 0x0600760F RID: 30223 RVA: 0x00385224 File Offset: 0x00383424
		public virtual void PGIGNJBMNFE(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1429f;
			float num2 = 1489f;
			if (this.PDJBFPOAPBA() != null)
			{
				Texture texture = this.PDJBFPOAPBA().EJOLKDKEKCG();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 373f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.StretchToFill);
				num = num + num2 + 1828f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = -99,
				normal = 
				{
					textColor = new Color(1023f, 1996f, 503f)
				},
				alignment = TextAnchor.UpperCenter,
				richText = false,
				font = GuiProcessor.NKOEAPCIBKO().rusfont2
			};
			guistyle.fontSize = 3;
			JDCEFOFMGHB.JFIDAGABKID().JNJDPKECONL(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 727f, COAGIAMOCIA.height), "FrontKick" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.UpperRight;
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 443f, COAGIAMOCIA.height), JLFJEGIPIMM.IKGFHGKKCPG.MNMIJFNPIPI(0L, this.FKEDAOOHPPB, false), guistyle);
			guistyle.fontSize = 73;
			string text = this.GAAPCLGDOGH.IKDNJHADDGD(0, this.DBEIGNDALDC, true, false, true, 1, false, false);
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.LowerRight;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 1309f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007610 RID: 30224 RVA: 0x00385400 File Offset: 0x00383600
		public virtual void HNAPBJJIMIK(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 145f;
			float num2 = 1095f;
			if (this.MFKHIBOFIFI() != null)
			{
				Texture texture = this.JGBOJNELADG().DPBCBCLJHAJ();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 1896f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.ScaleAndCrop);
				num = num + num2 + 23f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 105,
				normal = 
				{
					textColor = new Color(1043f, 830f, 1595f)
				},
				alignment = TextAnchor.MiddleRight,
				richText = true,
				font = GuiProcessor.BBLINJLBAIL().rusfont2
			};
			guistyle.fontSize = 118;
			JDCEFOFMGHB.HMJJPNDEKPP().ALKAAKDPCDG(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 892f, COAGIAMOCIA.height), "hair" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.MiddleCenter;
			guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 997f, COAGIAMOCIA.height), JLFJEGIPIMM.IKGFHGKKCPG.MNMIJFNPIPI(0L, this.FKEDAOOHPPB, false), guistyle);
			guistyle.fontSize = 30;
			string text = this.GAAPCLGDOGH.HDPHEKAIENE(0, this.DBEIGNDALDC, false, true, false, 0, true, false);
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 653f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007611 RID: 30225 RVA: 0x003855DA File Offset: 0x003837DA
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LFPIIPOHIEK()
		{
			return this.GAAPCLGDOGH.FGLONDNIKKC(this.DBEIGNDALDC);
		}

		// Token: 0x06007612 RID: 30226 RVA: 0x003855F0 File Offset: 0x003837F0
		public override string IBLEHFEBIMG()
		{
			return string.Format(JNBICAJIJMM.DCEBAJIILPC("SneakIdle"), this.GAAPCLGDOGH.PMCDDOJPKGF(0, this.DBEIGNDALDC, true, false, false, 0, true, true), this.ILFHHDNJHNM, JLFJEGIPIMM.IKGFHGKKCPG.MNMIJFNPIPI(0L, this.FKEDAOOHPPB, false));
		}

		// Token: 0x06007613 RID: 30227 RVA: 0x00385644 File Offset: 0x00383844
		public virtual void PLGEAJCLBPO(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 104f;
			float num2 = 852f;
			if (this.PPJOPGPEFGI() != null)
			{
				Texture texture = this.FMMNICCENPF().AEIIBNOFLCM();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 697f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.StretchToFill);
				num = num + num2 + 1768f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 12,
				normal = 
				{
					textColor = new Color(1995f, 29f, 377f)
				},
				alignment = TextAnchor.LowerRight,
				richText = true,
				font = GuiProcessor.IKGFHGKKCPG.rusfont2
			};
			guistyle.fontSize = 24;
			JDCEFOFMGHB.HMJJPNDEKPP().ALKAAKDPCDG(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 258f, COAGIAMOCIA.height), "_Offsets" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.MiddleCenter;
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 1980f, COAGIAMOCIA.height), JLFJEGIPIMM.PKGMBFEMKGP().MNMIJFNPIPI(1L, this.FKEDAOOHPPB, false), guistyle);
			guistyle.fontSize = 91;
			string text = this.GAAPCLGDOGH.JEBLNCGOHEA(0, this.DBEIGNDALDC, true, true, true, 1, true, true);
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.MiddleRight;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 767f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007614 RID: 30228 RVA: 0x00385820 File Offset: 0x00383A20
		public void KJPLPMMALEF(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.KDNDJNEGBDI();
			this.DBEIGNDALDC = KADBECGIMPD.HHLDBAEFNMJ();
			this.ILFHHDNJHNM = KADBECGIMPD.DOJKJHMJJNK();
			this.NKHBAJKMAGD = KADBECGIMPD.IFDFHJLCHAE();
			this.COGEJPHPFGG = KADBECGIMPD.MOBPFEEAMKD();
			this.OIAMBMMGGLD = KADBECGIMPD.AGNKAFLKCAG();
			this.FKEDAOOHPPB = KADBECGIMPD.IBKCNEICPEL();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.NENOBDLCFHO);
		}

		// Token: 0x06007615 RID: 30229 RVA: 0x00385898 File Offset: 0x00383A98
		public virtual void DIHMGHHLEDC(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 659f;
			float num2 = 507f;
			if (this.HFAGADCJACL() != null)
			{
				Texture texture = this.KHIDJHKNNFC().MLPBJEFJDHM();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 1287f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.ScaleAndCrop);
				num = num + num2 + 783f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = -63,
				normal = 
				{
					textColor = new Color(369f, 1382f, 1263f)
				},
				alignment = TextAnchor.MiddleLeft,
				richText = true,
				font = GuiProcessor.IKGFHGKKCPG.rusfont2
			};
			guistyle.fontSize = -84;
			JDCEFOFMGHB.JFIDAGABKID().JNJDPKECONL(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 211f, COAGIAMOCIA.height), "_DepthExponent" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.MiddleRight;
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 1392f, COAGIAMOCIA.height), JLFJEGIPIMM.PKGMBFEMKGP().OHNLAOJGCGC(1L, this.FKEDAOOHPPB, true), guistyle);
			guistyle.fontSize = 42;
			string text = this.GAAPCLGDOGH.ALGFDMENCEM(0, this.DBEIGNDALDC, false, true, false, 1, true, false);
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.LowerCenter;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 388f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007616 RID: 30230 RVA: 0x00385A74 File Offset: 0x00383C74
		public virtual string KCBJCGOINMK()
		{
			return string.Format(JNBICAJIJMM.CDDCIKKDFMP("crft_to"), this.GAAPCLGDOGH.KEJLIPNGFCL(1, this.DBEIGNDALDC, true, false, false, 0, true, true), this.ILFHHDNJHNM, JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(0L, this.FKEDAOOHPPB, true));
		}

		// Token: 0x06007617 RID: 30231 RVA: 0x00385AC8 File Offset: 0x00383CC8
		public void IKDPEDHGFGA(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.CLPEKGGAMAI();
			this.DBEIGNDALDC = KADBECGIMPD.DOJKJHMJJNK();
			this.ILFHHDNJHNM = KADBECGIMPD.LDLKLPJBIJN();
			this.NKHBAJKMAGD = KADBECGIMPD.HHLDBAEFNMJ();
			this.COGEJPHPFGG = KADBECGIMPD.AIDAGFNHNHE();
			this.OIAMBMMGGLD = KADBECGIMPD.DOJKJHMJJNK();
			this.FKEDAOOHPPB = KADBECGIMPD.DMABDIGCLKA();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.NENOBDLCFHO);
		}

		// Token: 0x06007618 RID: 30232 RVA: 0x00385B40 File Offset: 0x00383D40
		public void MBNGKJBMGPJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.LDLKLPJBIJN();
			this.DBEIGNDALDC = KADBECGIMPD.AGNKAFLKCAG();
			this.ILFHHDNJHNM = KADBECGIMPD.CLPEKGGAMAI();
			this.NKHBAJKMAGD = KADBECGIMPD.DOJKJHMJJNK();
			this.COGEJPHPFGG = KADBECGIMPD.CNNEPCOAMJK();
			this.OIAMBMMGGLD = KADBECGIMPD.HHLDBAEFNMJ();
			this.FKEDAOOHPPB = KADBECGIMPD.HHMGLDMFCPF();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.NENOBDLCFHO);
		}

		// Token: 0x06007619 RID: 30233 RVA: 0x00385BB8 File Offset: 0x00383DB8
		public void IEMABEFJCNJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.KKOKFLMMAAK();
			this.DBEIGNDALDC = KADBECGIMPD.IFDFHJLCHAE();
			this.ILFHHDNJHNM = KADBECGIMPD.KDNDJNEGBDI();
			this.NKHBAJKMAGD = KADBECGIMPD.CLPEKGGAMAI();
			this.COGEJPHPFGG = KADBECGIMPD.AILCEJFAMGN();
			this.OIAMBMMGGLD = KADBECGIMPD.KKOKFLMMAAK();
			this.FKEDAOOHPPB = KADBECGIMPD.ANPEIKGEDHJ();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.NENOBDLCFHO);
		}

		// Token: 0x0600761A RID: 30234 RVA: 0x00385C2F File Offset: 0x00383E2F
		public override CKNLPGEPGGF.IAPCJOBDCEH APLAAOCGECL()
		{
			return this.GAAPCLGDOGH.MMKENFCICCE(this.DBEIGNDALDC);
		}

		// Token: 0x0600761B RID: 30235 RVA: 0x00385C44 File Offset: 0x00383E44
		public virtual void GOJJILMEBMD(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 355f;
			float num2 = 804f;
			if (this.JGBOJNELADG() != null)
			{
				Texture texture = this.HHOBCJNGCEL().OABDBIAHOJH();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 507f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.ScaleAndCrop);
				num = num + num2 + 1382f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 10,
				normal = 
				{
					textColor = new Color(1720f, 777f, 514f)
				},
				alignment = TextAnchor.UpperCenter,
				richText = false,
				font = GuiProcessor.IKGFHGKKCPG.rusfont2
			};
			guistyle.fontSize = -49;
			JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 582f, COAGIAMOCIA.height), "WandStand" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.MiddleRight;
			guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 1133f, COAGIAMOCIA.height), JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(1L, this.FKEDAOOHPPB, false), guistyle);
			guistyle.fontSize = -5;
			string text = this.GAAPCLGDOGH.CJAMOIMGHAK(1, this.DBEIGNDALDC, false, false, true, 1, false, true);
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.MiddleRight;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 1465f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x0600761C RID: 30236 RVA: 0x00385E20 File Offset: 0x00384020
		public virtual string MIHCFECAIAD()
		{
			return string.Format(JNBICAJIJMM.OOOKJHOHPNN("wpn_chair1"), this.GAAPCLGDOGH.HDPHEKAIENE(0, this.DBEIGNDALDC, false, true, true, 1, false, false), this.ILFHHDNJHNM, JLFJEGIPIMM.MHFDIJGJGBJ().CJKACKADMKM(0L, this.FKEDAOOHPPB, false));
		}

		// Token: 0x0600761D RID: 30237 RVA: 0x00384F3E File Offset: 0x0038313E
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HKHAONBKECM()
		{
			return this.GAAPCLGDOGH.HNDLNEMINDM(this.DBEIGNDALDC);
		}

		// Token: 0x0600761E RID: 30238 RVA: 0x00385E74 File Offset: 0x00384074
		public virtual string NILBMGFGPPB()
		{
			return string.Format(JNBICAJIJMM.OOOKJHOHPNN("KatanaVerticalSwing"), this.GAAPCLGDOGH.HDPHEKAIENE(0, this.DBEIGNDALDC, false, false, false, 0, true, true), this.ILFHHDNJHNM, JLFJEGIPIMM.IKGFHGKKCPG.MNMIJFNPIPI(1L, this.FKEDAOOHPPB, false));
		}

		// Token: 0x0600761F RID: 30239 RVA: 0x00385EC6 File Offset: 0x003840C6
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DDIDFFABBIO()
		{
			return this.GAAPCLGDOGH.LANMGLMKPNA(this.DBEIGNDALDC);
		}

		// Token: 0x06007620 RID: 30240 RVA: 0x00385EDC File Offset: 0x003840DC
		public void GHJEIECNPCH(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.CLPEKGGAMAI();
			this.DBEIGNDALDC = KADBECGIMPD.HDBGOLAFOBK();
			this.ILFHHDNJHNM = KADBECGIMPD.DOJKJHMJJNK();
			this.NKHBAJKMAGD = KADBECGIMPD.KKOKFLMMAAK();
			this.COGEJPHPFGG = KADBECGIMPD.CGJIINADKNH();
			this.OIAMBMMGGLD = KADBECGIMPD.KKOKFLMMAAK();
			this.FKEDAOOHPPB = KADBECGIMPD.DNIIFBAIPBE();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.NENOBDLCFHO);
		}

		// Token: 0x06007622 RID: 30242 RVA: 0x00385F53 File Offset: 0x00384153
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HFIHJIOLJIK()
		{
			return this.GAAPCLGDOGH.BJNDAAKGGLP(this.DBEIGNDALDC);
		}

		// Token: 0x06007623 RID: 30243 RVA: 0x00385F68 File Offset: 0x00384168
		public void BGIDCHGAIEK(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.LDLKLPJBIJN();
			this.DBEIGNDALDC = KADBECGIMPD.HHLDBAEFNMJ();
			this.ILFHHDNJHNM = KADBECGIMPD.KKOKFLMMAAK();
			this.NKHBAJKMAGD = KADBECGIMPD.CLPEKGGAMAI();
			this.COGEJPHPFGG = KADBECGIMPD.AIDAGFNHNHE();
			this.OIAMBMMGGLD = KADBECGIMPD.HHLDBAEFNMJ();
			this.FKEDAOOHPPB = KADBECGIMPD.ANPEIKGEDHJ();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.NENOBDLCFHO);
		}

		// Token: 0x06007624 RID: 30244 RVA: 0x00385FE0 File Offset: 0x003841E0
		public override void AGFLCAGCFBC(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 816f;
			float num2 = 37f;
			if (this.PDJBFPOAPBA() != null)
			{
				Texture texture = this.PPJOPGPEFGI().IOHNCGLFGDJ();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 416f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.StretchToFill);
				num = num + num2 + 1742f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 102,
				normal = 
				{
					textColor = new Color(802f, 799f, 1276f)
				},
				alignment = TextAnchor.MiddleCenter,
				richText = true,
				font = GuiProcessor.PLGADNLAEGN().rusfont2
			};
			guistyle.fontSize = -99;
			JDCEFOFMGHB.HMJJPNDEKPP().JNJDPKECONL(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 445f, COAGIAMOCIA.height), "IdleReadyLook" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.LowerCenter;
			guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 1696f, COAGIAMOCIA.height), JLFJEGIPIMM.NNEAHAFBOHC().MNMIJFNPIPI(1L, this.FKEDAOOHPPB, true), guistyle);
			guistyle.fontSize = 97;
			string text = this.GAAPCLGDOGH.JDOAJCMOBCA(1, this.DBEIGNDALDC, true, false, true, 0, true, true);
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.LowerLeft;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 1476f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007625 RID: 30245 RVA: 0x003861BC File Offset: 0x003843BC
		public virtual string IBNCBKOPEOC()
		{
			return string.Format(JNBICAJIJMM.PGJCPFNJNPM("holes_min"), this.GAAPCLGDOGH.IKDNJHADDGD(0, this.DBEIGNDALDC, true, false, true, 0, false, false), this.ILFHHDNJHNM, JLFJEGIPIMM.MHFDIJGJGBJ().MNMIJFNPIPI(1L, this.FKEDAOOHPPB, true));
		}

		// Token: 0x06007626 RID: 30246 RVA: 0x00386210 File Offset: 0x00384410
		public virtual string NKOIIHFDNHP()
		{
			return string.Format(JNBICAJIJMM.PGJCPFNJNPM("rait_2"), this.GAAPCLGDOGH.PMCDDOJPKGF(0, this.DBEIGNDALDC, true, false, false, 1, true, true), this.ILFHHDNJHNM, JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC(0L, this.FKEDAOOHPPB, false));
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x003851FD File Offset: 0x003833FD
		public virtual CKNLPGEPGGF.IAPCJOBDCEH GCLHFHNKONE()
		{
			return this.GAAPCLGDOGH.ABALMFIKLCA(this.DBEIGNDALDC);
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x00386264 File Offset: 0x00384464
		public virtual void LJJNBAFMGOP(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1318f;
			float num2 = 1067f;
			if (this.GKPOPMAAGIJ() != null)
			{
				Texture texture = this.PBEMPJOBKKI().NIOGJOFLPLH();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 755f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.StretchToFill);
				num = num + num2 + 668f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = -93,
				normal = 
				{
					textColor = new Color(1372f, 1601f, 41f)
				},
				alignment = TextAnchor.UpperRight,
				richText = false,
				font = GuiProcessor.IKGFHGKKCPG.rusfont2
			};
			guistyle.fontSize = -20;
			JDCEFOFMGHB.HMJJPNDEKPP().JNJDPKECONL(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 1385f, COAGIAMOCIA.height), "{0}|{1}|{2}" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.LowerCenter;
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 767f, COAGIAMOCIA.height), JLFJEGIPIMM.IKGFHGKKCPG.MNMIJFNPIPI(1L, this.FKEDAOOHPPB, true), guistyle);
			guistyle.fontSize = -44;
			string text = this.GAAPCLGDOGH.JHFLJHLAPBC(0, this.DBEIGNDALDC, true, true, true, 0, false, false);
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.MiddleCenter;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 1105f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007629 RID: 30249 RVA: 0x00386440 File Offset: 0x00384640
		public override string ToString()
		{
			return string.Format(JNBICAJIJMM.LEBHCLDODNI("fshop_fcost2"), this.GAAPCLGDOGH.JHFLJHLAPBC(0, this.DBEIGNDALDC, false, false, false, 0, false, false), this.ILFHHDNJHNM, JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, this.FKEDAOOHPPB, false));
		}

		// Token: 0x0600762A RID: 30250 RVA: 0x00386494 File Offset: 0x00384694
		public virtual string ADOAJOFIPAM()
		{
			return string.Format(JNBICAJIJMM.CDDCIKKDFMP("1 Hand Sword"), this.GAAPCLGDOGH.KEJLIPNGFCL(1, this.DBEIGNDALDC, false, false, false, 1, false, false), this.ILFHHDNJHNM, JLFJEGIPIMM.PKGMBFEMKGP().MNMIJFNPIPI(0L, this.FKEDAOOHPPB, false));
		}

		// Token: 0x0600762B RID: 30251 RVA: 0x003864E8 File Offset: 0x003846E8
		public virtual void KNDDBNIOKEG(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 909f;
			float num2 = 268f;
			if (this.FMMNICCENPF() != null)
			{
				Texture texture = this.PPJOPGPEFGI().NIOGJOFLPLH();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 419f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.ScaleAndCrop);
				num = num + num2 + 297f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = -18,
				normal = 
				{
					textColor = new Color(860f, 1825f, 1608f)
				},
				alignment = TextAnchor.MiddleCenter,
				richText = false,
				font = GuiProcessor.PLGADNLAEGN().rusfont2
			};
			guistyle.fontSize = -104;
			JDCEFOFMGHB.HMJJPNDEKPP().ALKAAKDPCDG(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 1670f, COAGIAMOCIA.height), " " + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.LowerRight;
			guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 1832f, COAGIAMOCIA.height), JLFJEGIPIMM.NNEAHAFBOHC().MNMIJFNPIPI(1L, this.FKEDAOOHPPB, true), guistyle);
			guistyle.fontSize = -61;
			string text = this.GAAPCLGDOGH.JDOAJCMOBCA(1, this.DBEIGNDALDC, false, false, false, 0, false, true);
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.LowerLeft;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 453f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x0600762C RID: 30252 RVA: 0x00385210 File Offset: 0x00383410
		public virtual CKNLPGEPGGF.IAPCJOBDCEH IPEDEEMNPFN()
		{
			return this.GAAPCLGDOGH.KMIIGKECOEB(this.DBEIGNDALDC);
		}

		// Token: 0x0600762D RID: 30253 RVA: 0x003866C4 File Offset: 0x003848C4
		public virtual string NMBKBGNBAEM()
		{
			return string.Format(JNBICAJIJMM.NGALDMFKMJH("Error! "), this.GAAPCLGDOGH.KCPAGJLJPIA(0, this.DBEIGNDALDC, false, false, true, 1, true, true), this.ILFHHDNJHNM, JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(0L, this.FKEDAOOHPPB, false));
		}

		// Token: 0x0600762E RID: 30254 RVA: 0x00386718 File Offset: 0x00384918
		public virtual void FGPIIDOFGDN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1617f;
			float num2 = 820f;
			if (this.HFAGADCJACL() != null)
			{
				Texture texture = this.BHPAALLBMHL().AEIIBNOFLCM();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 299f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.ScaleAndCrop);
				num = num + num2 + 765f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = -55,
				normal = 
				{
					textColor = new Color(431f, 1054f, 1068f)
				},
				alignment = TextAnchor.UpperLeft,
				richText = true,
				font = GuiProcessor.PLGADNLAEGN().rusfont2
			};
			guistyle.fontSize = 106;
			JDCEFOFMGHB.MNJNNDHCDGG().JNJDPKECONL(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 577f, COAGIAMOCIA.height), "_InvScreenSize" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.MiddleLeft;
			guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 1758f, COAGIAMOCIA.height), JLFJEGIPIMM.MHFDIJGJGBJ().MNMIJFNPIPI(0L, this.FKEDAOOHPPB, false), guistyle);
			guistyle.fontSize = 71;
			string text = this.GAAPCLGDOGH.EOKBAIFGBDF(1, this.DBEIGNDALDC, false, false, false, 1, true, true);
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.MiddleCenter;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 389f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x0600762F RID: 30255 RVA: 0x00385F53 File Offset: 0x00384153
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DEOMJEEMGMI()
		{
			return this.GAAPCLGDOGH.BJNDAAKGGLP(this.DBEIGNDALDC);
		}

		// Token: 0x06007630 RID: 30256 RVA: 0x003868F4 File Offset: 0x00384AF4
		public virtual string CFPMCOPINOH()
		{
			return string.Format(JNBICAJIJMM.CDDCIKKDFMP("Aim Transform unassigned in Aim IK solver. Please Assign a Transform (lineal descendant to the last bone in the spine) that you want to be aimed at IKPosition"), this.GAAPCLGDOGH.KHLFFPHHPKM(0, this.DBEIGNDALDC, false, true, false, 0, true, true), this.ILFHHDNJHNM, JLFJEGIPIMM.PKGMBFEMKGP().OHNLAOJGCGC(1L, this.FKEDAOOHPPB, true));
		}

		// Token: 0x06007631 RID: 30257 RVA: 0x00386948 File Offset: 0x00384B48
		public void LIOCPGBEBBN(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.CLPEKGGAMAI();
			this.DBEIGNDALDC = KADBECGIMPD.DOJKJHMJJNK();
			this.ILFHHDNJHNM = KADBECGIMPD.HHLDBAEFNMJ();
			this.NKHBAJKMAGD = KADBECGIMPD.KDNDJNEGBDI();
			this.COGEJPHPFGG = KADBECGIMPD.CGJIINADKNH();
			this.OIAMBMMGGLD = KADBECGIMPD.KKOKFLMMAAK();
			this.FKEDAOOHPPB = KADBECGIMPD.IJDIMHAEAIE();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.NENOBDLCFHO);
		}

		// Token: 0x06007632 RID: 30258 RVA: 0x003869C0 File Offset: 0x00384BC0
		public void CGPPELKIANF(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.HDBGOLAFOBK();
			this.DBEIGNDALDC = KADBECGIMPD.KKOKFLMMAAK();
			this.ILFHHDNJHNM = KADBECGIMPD.IFDFHJLCHAE();
			this.NKHBAJKMAGD = KADBECGIMPD.KDNDJNEGBDI();
			this.COGEJPHPFGG = KADBECGIMPD.MOBPFEEAMKD();
			this.OIAMBMMGGLD = KADBECGIMPD.DOJKJHMJJNK();
			this.FKEDAOOHPPB = KADBECGIMPD.IBKCNEICPEL();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.NENOBDLCFHO);
		}

		// Token: 0x06007633 RID: 30259 RVA: 0x00386A38 File Offset: 0x00384C38
		public virtual void COFFCOCOJFK(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 241f;
			float num2 = 728f;
			if (this.BHPAALLBMHL() != null)
			{
				Texture texture = this.HEFAGFMDAEE().IOHNCGLFGDJ();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 1633f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.StretchToFill);
				num = num + num2 + 759f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 85,
				normal = 
				{
					textColor = new Color(1835f, 1046f, 1658f)
				},
				alignment = TextAnchor.MiddleCenter,
				richText = true,
				font = GuiProcessor.BBLINJLBAIL().rusfont2
			};
			guistyle.fontSize = -113;
			JDCEFOFMGHB.JFIDAGABKID().ALKAAKDPCDG(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 1477f, COAGIAMOCIA.height), "MotorbikeLassoLeft" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.LowerLeft;
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 1457f, COAGIAMOCIA.height), JLFJEGIPIMM.IKGFHGKKCPG.MNMIJFNPIPI(0L, this.FKEDAOOHPPB, true), guistyle);
			guistyle.fontSize = 13;
			string text = this.GAAPCLGDOGH.JEBLNCGOHEA(0, this.DBEIGNDALDC, true, true, false, 1, false, true);
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 227f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007634 RID: 30260 RVA: 0x00386C14 File Offset: 0x00384E14
		public virtual string DGOBKBBGGKN()
		{
			return string.Format(JNBICAJIJMM.DIOJFJMOPJO("FlyBackward"), this.GAAPCLGDOGH.IKDNJHADDGD(1, this.DBEIGNDALDC, false, false, true, 1, true, true), this.ILFHHDNJHNM, JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, this.FKEDAOOHPPB, false));
		}

		// Token: 0x06007635 RID: 30261 RVA: 0x00385C2F File Offset: 0x00383E2F
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FNILAAJAOEI()
		{
			return this.GAAPCLGDOGH.MMKENFCICCE(this.DBEIGNDALDC);
		}

		// Token: 0x06007636 RID: 30262 RVA: 0x00386C68 File Offset: 0x00384E68
		public virtual void LGOPKHJEKGG(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 656f;
			float num2 = 1247f;
			if (this.HFAGADCJACL() != null)
			{
				Texture texture = this.ENCJNMNEANC().DPBCBCLJHAJ();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 1504f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.ScaleAndCrop);
				num = num + num2 + 1110f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 28,
				normal = 
				{
					textColor = new Color(1961f, 1126f, 501f)
				},
				alignment = TextAnchor.MiddleCenter,
				richText = true,
				font = GuiProcessor.IKGFHGKKCPG.rusfont2
			};
			guistyle.fontSize = 77;
			JDCEFOFMGHB.MNJNNDHCDGG().JNJDPKECONL(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 1907f, COAGIAMOCIA.height), "RollerBladeFrontFlip" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.UpperLeft;
			guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 391f, COAGIAMOCIA.height), JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(0L, this.FKEDAOOHPPB, true), guistyle);
			guistyle.fontSize = 83;
			string text = this.GAAPCLGDOGH.HDPHEKAIENE(0, this.DBEIGNDALDC, false, true, false, 1, true, false);
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 924f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007637 RID: 30263 RVA: 0x00386E44 File Offset: 0x00385044
		public override void GKDJCJKMBEN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 0f;
			float num2 = 1f;
			if (this.EJJAGEFMHCO() != null)
			{
				Texture texture = this.EJJAGEFMHCO().KEDGAOBCNJG;
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 15f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.StretchToFill);
				num = num + num2 + 5f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 18,
				normal = 
				{
					textColor = new Color(0.8f, 0.6f, 0.3f)
				},
				alignment = TextAnchor.MiddleRight,
				richText = true,
				font = GuiProcessor.IKGFHGKKCPG.rusfont2
			};
			guistyle.fontSize = 22;
			JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 8f, COAGIAMOCIA.height), "x" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.MiddleRight;
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 24f, COAGIAMOCIA.height), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, this.FKEDAOOHPPB, false), guistyle);
			guistyle.fontSize = 18;
			string text = this.GAAPCLGDOGH.JHFLJHLAPBC(0, this.DBEIGNDALDC, false, false, false, 0, false, false);
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.MiddleLeft;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 15f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007638 RID: 30264 RVA: 0x00385EC6 File Offset: 0x003840C6
		public virtual CKNLPGEPGGF.IAPCJOBDCEH GODNMDFNNBL()
		{
			return this.GAAPCLGDOGH.LANMGLMKPNA(this.DBEIGNDALDC);
		}

		// Token: 0x06007639 RID: 30265 RVA: 0x00387020 File Offset: 0x00385220
		public void MDLNEBJIGJI(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.IFDFHJLCHAE();
			this.DBEIGNDALDC = KADBECGIMPD.HHLDBAEFNMJ();
			this.ILFHHDNJHNM = KADBECGIMPD.LDLKLPJBIJN();
			this.NKHBAJKMAGD = KADBECGIMPD.KDNDJNEGBDI();
			this.COGEJPHPFGG = KADBECGIMPD.FFDPCEAFGNF();
			this.OIAMBMMGGLD = KADBECGIMPD.KKOKFLMMAAK();
			this.FKEDAOOHPPB = KADBECGIMPD.EJPMFEJBGMN();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.NENOBDLCFHO);
		}

		// Token: 0x0600763A RID: 30266 RVA: 0x00385C2F File Offset: 0x00383E2F
		public virtual CKNLPGEPGGF.IAPCJOBDCEH OAJANJBLPNC()
		{
			return this.GAAPCLGDOGH.MMKENFCICCE(this.DBEIGNDALDC);
		}

		// Token: 0x0600763B RID: 30267 RVA: 0x00387098 File Offset: 0x00385298
		public virtual string DIACBNHNDCJ()
		{
			return string.Format(JNBICAJIJMM.CELEPPAEKAB("> "), this.GAAPCLGDOGH.CJAMOIMGHAK(0, this.DBEIGNDALDC, true, true, false, 0, true, false), this.ILFHHDNJHNM, JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(0L, this.FKEDAOOHPPB, true));
		}

		// Token: 0x0600763C RID: 30268 RVA: 0x003870EC File Offset: 0x003852EC
		public void ACJDDOEADFK(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.HDBGOLAFOBK();
			this.DBEIGNDALDC = KADBECGIMPD.HDBGOLAFOBK();
			this.ILFHHDNJHNM = KADBECGIMPD.HDBGOLAFOBK();
			this.NKHBAJKMAGD = KADBECGIMPD.HDBGOLAFOBK();
			this.COGEJPHPFGG = KADBECGIMPD.FFDPCEAFGNF();
			this.OIAMBMMGGLD = KADBECGIMPD.HDBGOLAFOBK();
			this.FKEDAOOHPPB = KADBECGIMPD.DNIIFBAIPBE();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.NENOBDLCFHO);
		}

		// Token: 0x0600763D RID: 30269 RVA: 0x00387164 File Offset: 0x00385364
		public virtual void CIEKGIHHAFF(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 616f;
			float num2 = 938f;
			if (this.MFKHIBOFIFI() != null)
			{
				Texture texture = this.HFAGADCJACL().EJOLKDKEKCG();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 42f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.StretchToFill);
				num = num + num2 + 1971f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 5,
				normal = 
				{
					textColor = new Color(54f, 1180f, 594f)
				},
				alignment = TextAnchor.MiddleCenter,
				richText = true,
				font = GuiProcessor.IKGFHGKKCPG.rusfont2
			};
			guistyle.fontSize = -14;
			JDCEFOFMGHB.JFIDAGABKID().JNJDPKECONL(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 496f, COAGIAMOCIA.height), "Fist Pump" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.MiddleCenter;
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 1990f, COAGIAMOCIA.height), JLFJEGIPIMM.MHFDIJGJGBJ().CJKACKADMKM(1L, this.FKEDAOOHPPB, false), guistyle);
			guistyle.fontSize = 89;
			string text = this.GAAPCLGDOGH.CJAMOIMGHAK(0, this.DBEIGNDALDC, true, false, false, 0, false, true);
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.LowerRight;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 1275f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x0600763E RID: 30270 RVA: 0x00384CA7 File Offset: 0x00382EA7
		public virtual CKNLPGEPGGF.IAPCJOBDCEH GFPKGBJHPAO()
		{
			return this.GAAPCLGDOGH.GLPBCAAIKAN(this.DBEIGNDALDC);
		}

		// Token: 0x0600763F RID: 30271 RVA: 0x00387340 File Offset: 0x00385540
		public void JDOMAOLMDAE(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.HDBGOLAFOBK();
			this.DBEIGNDALDC = KADBECGIMPD.IFDFHJLCHAE();
			this.ILFHHDNJHNM = KADBECGIMPD.DOJKJHMJJNK();
			this.NKHBAJKMAGD = KADBECGIMPD.HHLDBAEFNMJ();
			this.COGEJPHPFGG = KADBECGIMPD.AIDAGFNHNHE();
			this.OIAMBMMGGLD = KADBECGIMPD.KKOKFLMMAAK();
			this.FKEDAOOHPPB = KADBECGIMPD.HHMGLDMFCPF();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.NENOBDLCFHO);
		}

		// Token: 0x06007640 RID: 30272 RVA: 0x003873B8 File Offset: 0x003855B8
		public virtual string AOJIJIPBKPB()
		{
			return string.Format(JNBICAJIJMM.CDDCIKKDFMP(" assetbundle(s) in memory before unloading "), this.GAAPCLGDOGH.ALGFDMENCEM(1, this.DBEIGNDALDC, false, false, true, 0, false, false), this.ILFHHDNJHNM, JLFJEGIPIMM.PKGMBFEMKGP().MNMIJFNPIPI(1L, this.FKEDAOOHPPB, true));
		}

		// Token: 0x06007641 RID: 30273 RVA: 0x0038740C File Offset: 0x0038560C
		public virtual string OEAEGBAEEPP()
		{
			return string.Format(JNBICAJIJMM.LEBHCLDODNI("__Refraction Camera id"), this.GAAPCLGDOGH.KEJLIPNGFCL(1, this.DBEIGNDALDC, false, true, true, 0, true, true), this.ILFHHDNJHNM, JLFJEGIPIMM.MHFDIJGJGBJ().CJKACKADMKM(1L, this.FKEDAOOHPPB, false));
		}

		// Token: 0x06007642 RID: 30274 RVA: 0x00387460 File Offset: 0x00385660
		public virtual void GNFHLHEHBPG(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1491f;
			float num2 = 586f;
			if (this.PDJBFPOAPBA() != null)
			{
				Texture texture = this.ENCJNMNEANC().DPBCBCLJHAJ();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 342f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.StretchToFill);
				num = num + num2 + 898f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = -37,
				normal = 
				{
					textColor = new Color(536f, 1604f, 181f)
				},
				alignment = TextAnchor.LowerLeft,
				richText = true,
				font = GuiProcessor.IKGFHGKKCPG.rusfont2
			};
			guistyle.fontSize = 126;
			JDCEFOFMGHB.JFIDAGABKID().ALKAAKDPCDG(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 19f, COAGIAMOCIA.height), "_NAME" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.UpperRight;
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 710f, COAGIAMOCIA.height), JLFJEGIPIMM.MHFDIJGJGBJ().MNMIJFNPIPI(0L, this.FKEDAOOHPPB, false), guistyle);
			guistyle.fontSize = 4;
			string text = this.GAAPCLGDOGH.EOKBAIFGBDF(1, this.DBEIGNDALDC, false, true, false, 0, false, true);
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 1664f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007643 RID: 30275 RVA: 0x00384F3E File Offset: 0x0038313E
		public virtual CKNLPGEPGGF.IAPCJOBDCEH AIHENNHGODP()
		{
			return this.GAAPCLGDOGH.HNDLNEMINDM(this.DBEIGNDALDC);
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x003851FD File Offset: 0x003833FD
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DCIMNIONGEM()
		{
			return this.GAAPCLGDOGH.ABALMFIKLCA(this.DBEIGNDALDC);
		}

		// Token: 0x06007645 RID: 30277 RVA: 0x0038763C File Offset: 0x0038583C
		public virtual void HEMKDCKEKOD(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1875f;
			float num2 = 645f;
			if (this.JGBOJNELADG() != null)
			{
				Texture texture = this.MFKHIBOFIFI().LECMGDEDAKF();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 1369f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.StretchToFill);
				num = num + num2 + 952f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 55,
				normal = 
				{
					textColor = new Color(82f, 1285f, 384f)
				},
				alignment = TextAnchor.UpperLeft,
				richText = true,
				font = GuiProcessor.BBLINJLBAIL().rusfont2
			};
			guistyle.fontSize = -111;
			JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 1908f, COAGIAMOCIA.height), "OneHandSwordIdle" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.UpperCenter;
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 1898f, COAGIAMOCIA.height), JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(0L, this.FKEDAOOHPPB, false), guistyle);
			guistyle.fontSize = -17;
			string text = this.GAAPCLGDOGH.IKDNJHADDGD(1, this.DBEIGNDALDC, true, false, true, 0, false, false);
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.UpperCenter;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 604f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007646 RID: 30278 RVA: 0x003851FD File Offset: 0x003833FD
		public override CKNLPGEPGGF.IAPCJOBDCEH GKPOPMAAGIJ()
		{
			return this.GAAPCLGDOGH.ABALMFIKLCA(this.DBEIGNDALDC);
		}

		// Token: 0x06007647 RID: 30279 RVA: 0x00387818 File Offset: 0x00385A18
		public void EHPAIJBOPGK(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.LDLKLPJBIJN();
			this.DBEIGNDALDC = KADBECGIMPD.DOJKJHMJJNK();
			this.ILFHHDNJHNM = KADBECGIMPD.KDNDJNEGBDI();
			this.NKHBAJKMAGD = KADBECGIMPD.DOJKJHMJJNK();
			this.COGEJPHPFGG = KADBECGIMPD.CGJIINADKNH();
			this.OIAMBMMGGLD = KADBECGIMPD.LDLKLPJBIJN();
			this.FKEDAOOHPPB = KADBECGIMPD.DCGEOFHNBCN();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.NENOBDLCFHO);
		}

		// Token: 0x06007648 RID: 30280 RVA: 0x00387890 File Offset: 0x00385A90
		public virtual void DBJLENKPKDF(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1509f;
			float num2 = 390f;
			if (this.PDJBFPOAPBA() != null)
			{
				Texture texture = this.JGBOJNELADG().LECMGDEDAKF();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 505f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.ScaleAndCrop);
				num = num + num2 + 1574f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = -71,
				normal = 
				{
					textColor = new Color(438f, 518f, 658f)
				},
				alignment = TextAnchor.MiddleRight,
				richText = false,
				font = GuiProcessor.NKOEAPCIBKO().rusfont2
			};
			guistyle.fontSize = 23;
			JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 929f, COAGIAMOCIA.height), "\n" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.LowerRight;
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 590f, COAGIAMOCIA.height), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, this.FKEDAOOHPPB, true), guistyle);
			guistyle.fontSize = 91;
			string text = this.GAAPCLGDOGH.PMCDDOJPKGF(1, this.DBEIGNDALDC, true, true, true, 0, false, true);
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.UpperRight;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 1538f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007649 RID: 30281 RVA: 0x00387A6C File Offset: 0x00385C6C
		public void BNBGJPJMPAC(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.AGNKAFLKCAG();
			this.DBEIGNDALDC = KADBECGIMPD.KDNDJNEGBDI();
			this.ILFHHDNJHNM = KADBECGIMPD.AGNKAFLKCAG();
			this.NKHBAJKMAGD = KADBECGIMPD.LDLKLPJBIJN();
			this.COGEJPHPFGG = KADBECGIMPD.ECJLJGDNFMN();
			this.OIAMBMMGGLD = KADBECGIMPD.HDBGOLAFOBK();
			this.FKEDAOOHPPB = KADBECGIMPD.DMABDIGCLKA();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.NENOBDLCFHO);
		}

		// Token: 0x0600764A RID: 30282 RVA: 0x00385C2F File Offset: 0x00383E2F
		public virtual CKNLPGEPGGF.IAPCJOBDCEH CJDBDJMFEGK()
		{
			return this.GAAPCLGDOGH.MMKENFCICCE(this.DBEIGNDALDC);
		}

		// Token: 0x0600764B RID: 30283 RVA: 0x00387AE4 File Offset: 0x00385CE4
		public virtual void LHEHCODOHCC(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1593f;
			float num2 = 982f;
			if (this.KHIDJHKNNFC() != null)
			{
				Texture texture = this.GKPOPMAAGIJ().HONJOFFBOPH();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 961f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.ScaleAndCrop);
				num = num + num2 + 1266f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 103,
				normal = 
				{
					textColor = new Color(1750f, 163f, 288f)
				},
				alignment = TextAnchor.LowerLeft,
				richText = false,
				font = GuiProcessor.BBLINJLBAIL().rusfont2
			};
			guistyle.fontSize = -117;
			JDCEFOFMGHB.MNJNNDHCDGG().ALKAAKDPCDG(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 261f, COAGIAMOCIA.height), "wpn_rem4" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.UpperCenter;
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 816f, COAGIAMOCIA.height), JLFJEGIPIMM.PKGMBFEMKGP().MNMIJFNPIPI(1L, this.FKEDAOOHPPB, false), guistyle);
			guistyle.fontSize = 65;
			string text = this.GAAPCLGDOGH.JDOAJCMOBCA(0, this.DBEIGNDALDC, true, true, false, 0, true, false);
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.LowerRight;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 259f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x0600764C RID: 30284 RVA: 0x00387CC0 File Offset: 0x00385EC0
		public virtual void FCFDKJKNNAD(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 572f;
			float num2 = 674f;
			if (this.FMMNICCENPF() != null)
			{
				Texture texture = this.PDJBFPOAPBA().MMKLLFCKCAG();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 1361f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.ScaleAndCrop);
				num = num + num2 + 1591f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 91,
				normal = 
				{
					textColor = new Color(338f, 1169f, 361f)
				},
				alignment = TextAnchor.LowerRight,
				richText = true,
				font = GuiProcessor.PLGADNLAEGN().rusfont2
			};
			guistyle.fontSize = 77;
			JDCEFOFMGHB.IKGFHGKKCPG.ALKAAKDPCDG(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 331f, COAGIAMOCIA.height), "CratePull" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.LowerCenter;
			guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 1974f, COAGIAMOCIA.height), JLFJEGIPIMM.NNEAHAFBOHC().MNMIJFNPIPI(1L, this.FKEDAOOHPPB, false), guistyle);
			guistyle.fontSize = -6;
			string text = this.GAAPCLGDOGH.JDOAJCMOBCA(0, this.DBEIGNDALDC, true, true, false, 1, false, false);
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.MiddleRight;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 1838f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x0600764D RID: 30285 RVA: 0x00387E9C File Offset: 0x0038609C
		public virtual string NAAOOABFHKB()
		{
			return string.Format(JNBICAJIJMM.PPNKMDJBMLP("perks/rperk"), this.GAAPCLGDOGH.JEBLNCGOHEA(0, this.DBEIGNDALDC, false, false, false, 1, true, false), this.ILFHHDNJHNM, JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(1L, this.FKEDAOOHPPB, true));
		}

		// Token: 0x0600764E RID: 30286 RVA: 0x00387EF0 File Offset: 0x003860F0
		public virtual void DGFIBJBEJAF(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1945f;
			float num2 = 856f;
			if (this.MFKHIBOFIFI() != null)
			{
				Texture texture = this.HFAGADCJACL().MMKLLFCKCAG();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 1981f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.ScaleAndCrop);
				num = num + num2 + 1724f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 19,
				normal = 
				{
					textColor = new Color(245f, 1389f, 245f)
				},
				alignment = TextAnchor.MiddleLeft,
				richText = true,
				font = GuiProcessor.NKOEAPCIBKO().rusfont2
			};
			guistyle.fontSize = 82;
			JDCEFOFMGHB.HMJJPNDEKPP().ALKAAKDPCDG(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 1024f, COAGIAMOCIA.height), "bag" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.LowerRight;
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 1900f, COAGIAMOCIA.height), JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(0L, this.FKEDAOOHPPB, true), guistyle);
			guistyle.fontSize = 111;
			string text = this.GAAPCLGDOGH.CJAMOIMGHAK(0, this.DBEIGNDALDC, false, true, false, 0, true, false);
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.LowerRight;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 940f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x0600764F RID: 30287 RVA: 0x003880CC File Offset: 0x003862CC
		public virtual string MJODNMLNFJC()
		{
			return string.Format(JNBICAJIJMM.DIOJFJMOPJO("FlyDown"), this.GAAPCLGDOGH.JDOAJCMOBCA(0, this.DBEIGNDALDC, true, true, false, 0, false, false), this.ILFHHDNJHNM, JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, this.FKEDAOOHPPB, false));
		}

		// Token: 0x06007650 RID: 30288 RVA: 0x00388120 File Offset: 0x00386320
		public virtual void JNPFLPLDAGA(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 208f;
			float num2 = 701f;
			if (this.KHIDJHKNNFC() != null)
			{
				Texture texture = this.HHOBCJNGCEL().HFNHCIGCOBE();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 500f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.StretchToFill);
				num = num + num2 + 1178f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 53,
				normal = 
				{
					textColor = new Color(343f, 1110f, 1598f)
				},
				alignment = TextAnchor.LowerLeft,
				richText = false,
				font = GuiProcessor.PLGADNLAEGN().rusfont2
			};
			guistyle.fontSize = 39;
			JDCEFOFMGHB.JFIDAGABKID().ALKAAKDPCDG(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 641f, COAGIAMOCIA.height), " already has " + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.MiddleCenter;
			guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 570f, COAGIAMOCIA.height), JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(1L, this.FKEDAOOHPPB, true), guistyle);
			guistyle.fontSize = -4;
			string text = this.GAAPCLGDOGH.KCPAGJLJPIA(0, this.DBEIGNDALDC, true, false, true, 0, true, true);
			OFPNEDEAMAB.font = GuiProcessor.PLGADNLAEGN().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.LowerCenter;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 1496f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007651 RID: 30289 RVA: 0x00385210 File Offset: 0x00383410
		public virtual CKNLPGEPGGF.IAPCJOBDCEH OIPEGDKJMBH()
		{
			return this.GAAPCLGDOGH.KMIIGKECOEB(this.DBEIGNDALDC);
		}

		// Token: 0x06007652 RID: 30290 RVA: 0x003882FC File Offset: 0x003864FC
		public virtual void GGFNOOJBHLM(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 551f;
			float num2 = 1995f;
			if (this.PDJBFPOAPBA() != null)
			{
				Texture texture = this.EJJAGEFMHCO().HFNHCIGCOBE();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 313f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.StretchToFill);
				num = num + num2 + 1897f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = -112,
				normal = 
				{
					textColor = new Color(54f, 1158f, 698f)
				},
				alignment = TextAnchor.LowerLeft,
				richText = false,
				font = GuiProcessor.BBLINJLBAIL().rusfont2
			};
			guistyle.fontSize = -64;
			JDCEFOFMGHB.HMJJPNDEKPP().JNJDPKECONL(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 1105f, COAGIAMOCIA.height), "IdleReadyCrouch" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.UpperRight;
			guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 947f, COAGIAMOCIA.height), JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC(0L, this.FKEDAOOHPPB, false), guistyle);
			guistyle.fontSize = 52;
			string text = this.GAAPCLGDOGH.KCPAGJLJPIA(1, this.DBEIGNDALDC, true, false, false, 0, true, false);
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.MiddleRight;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 727f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007653 RID: 30291 RVA: 0x003884D8 File Offset: 0x003866D8
		public virtual string BNNOHGHHKBF()
		{
			return string.Format(JNBICAJIJMM.PGJCPFNJNPM("MotorbikeTurnRight"), this.GAAPCLGDOGH.CJAMOIMGHAK(0, this.DBEIGNDALDC, true, false, true, 0, false, true), this.ILFHHDNJHNM, JLFJEGIPIMM.MHFDIJGJGBJ().OHNLAOJGCGC(0L, this.FKEDAOOHPPB, true));
		}

		// Token: 0x06007654 RID: 30292 RVA: 0x0038852C File Offset: 0x0038672C
		public virtual string PFNDMCPAGLP()
		{
			return string.Format(JNBICAJIJMM.BDKHMOOFHHK("kill"), this.GAAPCLGDOGH.IKDNJHADDGD(1, this.DBEIGNDALDC, true, false, false, 1, true, false), this.ILFHHDNJHNM, JLFJEGIPIMM.MHFDIJGJGBJ().MNMIJFNPIPI(1L, this.FKEDAOOHPPB, false));
		}

		// Token: 0x06007655 RID: 30293 RVA: 0x00388580 File Offset: 0x00386780
		public void CMEFHGFMAAK(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.KKOKFLMMAAK();
			this.DBEIGNDALDC = KADBECGIMPD.KDNDJNEGBDI();
			this.ILFHHDNJHNM = KADBECGIMPD.HHLDBAEFNMJ();
			this.NKHBAJKMAGD = KADBECGIMPD.HHLDBAEFNMJ();
			this.COGEJPHPFGG = KADBECGIMPD.AILCEJFAMGN();
			this.OIAMBMMGGLD = KADBECGIMPD.DOJKJHMJJNK();
			this.FKEDAOOHPPB = KADBECGIMPD.DMABDIGCLKA();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.NENOBDLCFHO);
		}

		// Token: 0x06007656 RID: 30294 RVA: 0x003885F8 File Offset: 0x003867F8
		public void AKBALPGJMHD(HBPNMNGOFMA KADBECGIMPD)
		{
			this.NENOBDLCFHO = KADBECGIMPD.DOJKJHMJJNK();
			this.DBEIGNDALDC = KADBECGIMPD.IFDFHJLCHAE();
			this.ILFHHDNJHNM = KADBECGIMPD.HHLDBAEFNMJ();
			this.NKHBAJKMAGD = KADBECGIMPD.HHLDBAEFNMJ();
			this.COGEJPHPFGG = KADBECGIMPD.CGJIINADKNH();
			this.OIAMBMMGGLD = KADBECGIMPD.CLPEKGGAMAI();
			this.FKEDAOOHPPB = KADBECGIMPD.DCGEOFHNBCN();
			this.GAAPCLGDOGH = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(this.NENOBDLCFHO);
		}

		// Token: 0x06007657 RID: 30295 RVA: 0x00388670 File Offset: 0x00386870
		public virtual string NIDKKALEJIM()
		{
			return string.Format(JNBICAJIJMM.NGALDMFKMJH("startB"), this.GAAPCLGDOGH.KHLFFPHHPKM(1, this.DBEIGNDALDC, false, true, false, 1, true, false), this.ILFHHDNJHNM, JLFJEGIPIMM.IKGFHGKKCPG.MNMIJFNPIPI(1L, this.FKEDAOOHPPB, true));
		}

		// Token: 0x06007658 RID: 30296 RVA: 0x003886C4 File Offset: 0x003868C4
		public virtual void OOOHOIOFEKD(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1112f;
			float num2 = 478f;
			if (this.APLAAOCGECL() != null)
			{
				Texture texture = this.PDJBFPOAPBA().IOHNCGLFGDJ();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 1903f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.StretchToFill);
				num = num + num2 + 1087f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 61,
				normal = 
				{
					textColor = new Color(121f, 46f, 1754f)
				},
				alignment = TextAnchor.UpperCenter,
				richText = true,
				font = GuiProcessor.IKGFHGKKCPG.rusfont2
			};
			guistyle.fontSize = -38;
			JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 1793f, COAGIAMOCIA.height), "{0}\n{1}" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.UpperLeft;
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 701f, COAGIAMOCIA.height), JLFJEGIPIMM.MHFDIJGJGBJ().OHNLAOJGCGC(1L, this.FKEDAOOHPPB, false), guistyle);
			guistyle.fontSize = -81;
			string text = this.GAAPCLGDOGH.PMCDDOJPKGF(0, this.DBEIGNDALDC, false, true, false, 0, true, false);
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.UpperRight;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 184f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x06007659 RID: 30297 RVA: 0x003888A0 File Offset: 0x00386AA0
		public virtual string GAOJCHIOICI()
		{
			return string.Format(JNBICAJIJMM.PPNKMDJBMLP("Katana Ninja Draw"), this.GAAPCLGDOGH.HDPHEKAIENE(0, this.DBEIGNDALDC, false, false, false, 0, false, true), this.ILFHHDNJHNM, JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC(1L, this.FKEDAOOHPPB, true));
		}

		// Token: 0x0600765A RID: 30298 RVA: 0x003888F4 File Offset: 0x00386AF4
		public virtual void HHBLLIKDCBB(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 209f;
			float num2 = 1924f;
			if (this.PDJBFPOAPBA() != null)
			{
				Texture texture = this.GKPOPMAAGIJ().EJOLKDKEKCG();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 1813f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.ScaleAndCrop);
				num = num + num2 + 809f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 15,
				normal = 
				{
					textColor = new Color(715f, 216f, 1955f)
				},
				alignment = TextAnchor.UpperCenter,
				richText = true,
				font = GuiProcessor.NKOEAPCIBKO().rusfont2
			};
			guistyle.fontSize = 63;
			JDCEFOFMGHB.JFIDAGABKID().ALKAAKDPCDG(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 63f, COAGIAMOCIA.height), "UnityEngine.Vector3" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.LowerCenter;
			guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 1666f, COAGIAMOCIA.height), JLFJEGIPIMM.PKGMBFEMKGP().OHNLAOJGCGC(0L, this.FKEDAOOHPPB, true), guistyle);
			guistyle.fontSize = -24;
			string text = this.GAAPCLGDOGH.HDPHEKAIENE(1, this.DBEIGNDALDC, true, false, true, 0, false, false);
			OFPNEDEAMAB.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.LowerLeft;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 591f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x0600765B RID: 30299 RVA: 0x00388AD0 File Offset: 0x00386CD0
		public virtual void IKDEPKLOGCH(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1636f;
			float num2 = 102f;
			if (this.KHIDJHKNNFC() != null)
			{
				Texture texture = this.PPJOPGPEFGI().IOHNCGLFGDJ();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 1811f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.ScaleAndCrop);
				num = num + num2 + 476f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 91,
				normal = 
				{
					textColor = new Color(1318f, 216f, 918f)
				},
				alignment = TextAnchor.MiddleCenter,
				richText = true,
				font = GuiProcessor.NKOEAPCIBKO().rusfont2
			};
			guistyle.fontSize = 96;
			JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 1994f, COAGIAMOCIA.height), "ZombieCrawl" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.MiddleLeft;
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 869f, COAGIAMOCIA.height), JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(1L, this.FKEDAOOHPPB, false), guistyle);
			guistyle.fontSize = 101;
			string text = this.GAAPCLGDOGH.CJAMOIMGHAK(1, this.DBEIGNDALDC, true, true, true, 1, true, true);
			OFPNEDEAMAB.font = GuiProcessor.BBLINJLBAIL().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.LowerRight;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 1731f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x0600765C RID: 30300 RVA: 0x00385EC6 File Offset: 0x003840C6
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LNHLBIOOINI()
		{
			return this.GAAPCLGDOGH.LANMGLMKPNA(this.DBEIGNDALDC);
		}

		// Token: 0x0600765D RID: 30301 RVA: 0x00388CAC File Offset: 0x00386EAC
		public virtual void KMAJAKPJLBI(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			float num = 1575f;
			float num2 = 1369f;
			if (this.JGBOJNELADG() != null)
			{
				Texture texture = this.BHPAALLBMHL().PFFJJEJNKPB();
				float num3 = COAGIAMOCIA.height / (float)texture.height;
				num2 = (float)texture.width * num3;
				float height = (float)texture.height * num3;
				GUI.DrawTexture(new Rect(COAGIAMOCIA.x - 1608f, COAGIAMOCIA.y, num2, height), texture, ScaleMode.StretchToFill);
				num = num + num2 + 1935f;
			}
			GUIStyle guistyle = new GUIStyle
			{
				fontSize = 119,
				normal = 
				{
					textColor = new Color(730f, 720f, 235f)
				},
				alignment = TextAnchor.UpperCenter,
				richText = true,
				font = GuiProcessor.BBLINJLBAIL().rusfont2
			};
			guistyle.fontSize = 18;
			JDCEFOFMGHB.HMJJPNDEKPP().JNJDPKECONL(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, num2 - 1753f, COAGIAMOCIA.height), "ComeHere" + this.ILFHHDNJHNM, guistyle);
			guistyle.alignment = TextAnchor.UpperRight;
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			GUI.Label(new Rect(COAGIAMOCIA.x, COAGIAMOCIA.y, COAGIAMOCIA.width - 1778f, COAGIAMOCIA.height), JLFJEGIPIMM.IKGFHGKKCPG.MNMIJFNPIPI(1L, this.FKEDAOOHPPB, false), guistyle);
			guistyle.fontSize = 41;
			string text = this.GAAPCLGDOGH.PMCDDOJPKGF(0, this.DBEIGNDALDC, false, false, false, 1, true, false);
			OFPNEDEAMAB.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			OFPNEDEAMAB.alignment = TextAnchor.LowerCenter;
			GUI.Label(new Rect(COAGIAMOCIA.x + num, COAGIAMOCIA.y, COAGIAMOCIA.width - 1816f, COAGIAMOCIA.height), text, OFPNEDEAMAB);
		}

		// Token: 0x04001107 RID: 4359
		public IDCHHHEDHDC GAAPCLGDOGH;

		// Token: 0x04001108 RID: 4360
		public int NENOBDLCFHO;

		// Token: 0x04001109 RID: 4361
		public int DBEIGNDALDC;

		// Token: 0x0400110A RID: 4362
		public int ILFHHDNJHNM;

		// Token: 0x0400110B RID: 4363
		public int NKHBAJKMAGD;

		// Token: 0x0400110C RID: 4364
		public int OIAMBMMGGLD;

		// Token: 0x0400110D RID: 4365
		public float COGEJPHPFGG;

		// Token: 0x0400110E RID: 4366
		public long FKEDAOOHPPB;
	}
}
