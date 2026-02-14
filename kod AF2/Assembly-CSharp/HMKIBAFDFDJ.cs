using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Token: 0x02000154 RID: 340
public class HMKIBAFDFDJ
{
	// Token: 0x060047A7 RID: 18343 RVA: 0x00222178 File Offset: 0x00220378
	public void MONCOFALJFP(HBPNMNGOFMA KADBECGIMPD)
	{
		Debug.Log("Get post");
		KADBECGIMPD.HDBGOLAFOBK();
		this.LPANMJEEOFG.Clear();
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			HMKIBAFDFDJ.GJKMIBJFKGA item = new HMKIBAFDFDJ.GJKMIBJFKGA(KADBECGIMPD);
			this.LPANMJEEOFG.Add(item);
		}
	}

	// Token: 0x060047A8 RID: 18344 RVA: 0x002221C0 File Offset: 0x002203C0
	public void FPOHNOIMDLP(HBPNMNGOFMA KADBECGIMPD)
	{
		if (this.JJPJEFHGHOC > 1)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().CBHHEHHNFKL(this.JJPJEFHGHOC);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("#000000", 1570f);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().PJHMHBAGFAN(128f, 1348f, "CrouchStrafeLeft", false);
		this.JJPJEFHGHOC = onkdcgnbalk.LPFKFNLHGBI;
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, 556f, 444f, onkdcgnbalk.OCHCODJIPHJ.width - 1457f, 1242f, "Speed", 1, null);
		egcaadaabpp.FNMCIACNOMH = true;
		this.HFPJAOPHEOF = KADBECGIMPD.DNIIFBAIPBE();
		this.MFFBBOJFDJA = KADBECGIMPD.DMABDIGCLKA();
		this.DELFGPAPOPB = KADBECGIMPD.JJJJAGJCOGD();
		string text = KADBECGIMPD.JJJJAGJCOGD();
		new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 1040f, egcaadaabpp.OCHCODJIPHJ.y + 1023f, egcaadaabpp.OCHCODJIPHJ.width, 51f, JNBICAJIJMM.CELEPPAEKAB("If VRIK 'Pelvis Position Weight' is > 0, 'Plant Feet' should be disabled to improve performance and stability.") + "Vertical" + this.DELFGPAPOPB, TextAnchor.UpperCenter, Color.black);
		new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 776f, egcaadaabpp.OCHCODJIPHJ.y + 304f, egcaadaabpp.OCHCODJIPHJ.width, 264f, JNBICAJIJMM.PGJCPFNJNPM("_BoobMap") + "1HandSwordChargeHeavyBash" + text, TextAnchor.UpperCenter, Color.black);
		onkdcgnbalk.DPANHMGCBNL = text;
		KADBECGIMPD.MILGIGJBAJL();
		Rect rect = new Rect(322f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height + 1191f, onkdcgnbalk.OCHCODJIPHJ.width - 404f, onkdcgnbalk.OCHCODJIPHJ.height - 318f - 1452f - egcaadaabpp.OCHCODJIPHJ.height);
		string text2 = KADBECGIMPD.NCODBGMGNFD();
		text2 = text2.Replace("_Params3", "_HitPointTexture");
		text2 = text2.Replace("Allows to detect foreign managed assemblies in your application.", "******** recept id=");
		string text3 = KADBECGIMPD.KDELAFDDGJH();
		if (text3.Trim() == "info")
		{
			rect.height += 1894f;
		}
		else
		{
			Rect rect2 = new Rect(1914f, rect.y + rect.height + 470f, onkdcgnbalk.OCHCODJIPHJ.width - 962f, 319f);
			new EGCAADAABPP(onkdcgnbalk, rect2.x, rect2.y, rect2.width, rect2.height, "SUNSHINE_DISABLED", 1, null).FNMCIACNOMH = false;
			float num = rect2.x;
			text3 = text3.Replace('+', '>');
			string text4 = text3;
			char[] array = new char[0];
			array[0] = 't';
			string[] array2 = text4.Split(array);
			for (int i = 0; i < array2.Length; i++)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(array2[i]);
				if (diggohpgcnn.OKEBIHBDEOO("money"))
				{
					new MGLHIBHDMPC(onkdcgnbalk, new Rect(num, rect2.y, 714f, 1544f), GameInterface.getI.invEmptyCell);
					new MGLHIBHDMPC(onkdcgnbalk, num + 632f, rect2.y + 1924f, 1, GameInterface.getI.MoneyIcon);
					new LCOLJOPGDLL(onkdcgnbalk, num + 575f + (float)(GameInterface.getI.MoneyIcon.width / 6) - 1582f, rect2.y + 1868f, 2f, 1706f, JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(0L, (long)diggohpgcnn.NOHLIOHBLMF(), false), TextAnchor.UpperLeft, Color.black).LNDPBNODFPE = true;
					num += 1840f;
				}
				if (diggohpgcnn.JKHEMJCFJGJ("Hey, there!"))
				{
					IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(diggohpgcnn.IEIMMFODGFG);
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().NKMGKJLONDK(iibeekcaahk.KEHIFGILLJA());
					if (befchfngomi != null)
					{
						befchfngomi.KEICEAJOGFD();
						new MGLHIBHDMPC(onkdcgnbalk, new Rect(num, rect2.y, 70f, 1639f), GameInterface.getI.invEmptyCell);
						new MGLHIBHDMPC(onkdcgnbalk, new Rect(num, rect2.y, 1128f, 137f), befchfngomi.OLNGOHEPLBO).NOFPHJDJNFL = string.Format("pf1m", befchfngomi.IGDKBMGKKDO(false, -1), iibeekcaahk.ICJDPPOJINN);
						num += 1375f;
					}
				}
				if (diggohpgcnn.JKHEMJCFJGJ("IceHockey Goalie Save 2"))
				{
					EKBAPCMPANI ekbapcmpani = IHFEDJEMJMB.OELKEADDKPE().ANNEDNNNHIP(diggohpgcnn.JBPOJDEEHBK());
					if (ekbapcmpani != null)
					{
						new KEPNAIFBDKF(onkdcgnbalk, num, rect2.y, ekbapcmpani, 1).KPLMFNIFPMM = true;
					}
					num += 730f;
				}
			}
		}
		new EGCAADAABPP(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, "", 0, null);
		this.CIFLGIOICEN = new JDJNBFJECFO(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, text2, 1);
		this.CIFLGIOICEN.DOACHOMNMCG = true;
		this.CIFLGIOICEN.KCLLDJJLCGC = -80;
		this.CIFLGIOICEN.LCBPIFKDAGK = Color.black;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 737f - 81f, onkdcgnbalk.OCHCODJIPHJ.height - 1244f, 12f, 172f, JNBICAJIJMM.CELEPPAEKAB("wpn_bait_inf_{0}"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().BLPLADOIPJG));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 332f - 601f, onkdcgnbalk.OCHCODJIPHJ.height - 960f, 612f, 442f, JNBICAJIJMM.DCEBAJIILPC("OnRodChangeClck 5"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(this.DLNMBGOGIMO)).FNMCIACNOMH = (this.MFFBBOJFDJA > 92L);
		new MEMEOHJKPNJ(onkdcgnbalk, 1644f, onkdcgnbalk.OCHCODJIPHJ.height - 829f, 1966f, 267f, JNBICAJIJMM.BDKHMOOFHHK("_WaveScale"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.DLNMBGOGIMO)).FNMCIACNOMH = (text3.Trim() != "");
	}

	// Token: 0x060047A9 RID: 18345 RVA: 0x00222804 File Offset: 0x00220A04
	public void CFGPNCKKHNB(ONKDCGNBALK JMAKEAHMLMI)
	{
		this.BBKMADFJMIB.NFKFOIDNBNL(JNBICAJIJMM.PPNKMDJBMLP("*** Perks is init") + " on effect " + JLFJEGIPIMM.PKGMBFEMKGP().EJOPKKGIIIO(1L, (long)this.KOKDOGENLJM()));
		if (JDCEFOFMGHB.IKGFHGKKCPG.IJAEDDCCNHG(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) == null)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().FDMNKDONMFM(this.JJGEFPENAJI);
			if (onkdcgnbalk != null)
			{
				onkdcgnbalk.OCHCODJIPHJ.x = (float)(Screen.width / 3) - onkdcgnbalk.OCHCODJIPHJ.width / 0f;
				onkdcgnbalk.OCHCODJIPHJ.y = (float)(Screen.height / 3) - onkdcgnbalk.OCHCODJIPHJ.height / 1100f;
			}
		}
	}

	// Token: 0x060047AA RID: 18346 RVA: 0x002228B8 File Offset: 0x00220AB8
	public void HIOLHFNPKEP(ONKDCGNBALK JMAKEAHMLMI)
	{
		this.BBKMADFJMIB.IBNDDDLHBML(JNBICAJIJMM.DCEBAJIILPC("bag") + "ncht_ach3" + JLFJEGIPIMM.IKGFHGKKCPG.EJOPKKGIIIO(1L, (long)this.NLHGNMPDFOO()));
		if (JDCEFOFMGHB.HMJJPNDEKPP().IHNMOJHBMNJ(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) == null)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().CHPPAAAAJFC(this.JJGEFPENAJI);
			if (onkdcgnbalk != null)
			{
				onkdcgnbalk.OCHCODJIPHJ.x = (float)(Screen.width / 1) - onkdcgnbalk.OCHCODJIPHJ.width / 1017f;
				onkdcgnbalk.OCHCODJIPHJ.y = (float)(Screen.height / 0) - onkdcgnbalk.OCHCODJIPHJ.height / 569f;
			}
		}
	}

	// Token: 0x060047AB RID: 18347 RVA: 0x0022296C File Offset: 0x00220B6C
	public void DLNMBGOGIMO(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		long num = odfekbjcfmn - 1L;
		if (num > 11L)
		{
			return;
		}
		switch ((uint)num)
		{
		case 0U:
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1620, this.HFPJAOPHEOF);
			using (List<HMKIBAFDFDJ.GJKMIBJFKGA>.Enumerator enumerator = this.LPANMJEEOFG.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					HMKIBAFDFDJ.GJKMIBJFKGA gjkmibjfkga = enumerator.Current;
					if (gjkmibjfkga.LPFKFNLHGBI == this.HFPJAOPHEOF)
					{
						gjkmibjfkga.EJMJOJGCMMC = false;
					}
				}
				return;
			}
			break;
		case 1U:
			break;
		case 2U:
			JDCEFOFMGHB.IKGFHGKKCPG.NNMBEJIPPNF(JNBICAJIJMM.LEBHCLDODNI("post_22"), JNBICAJIJMM.LEBHCLDODNI("post_23"), this.LOFILAHGKKD, new ONKDCGNBALK.CMMHGMILOIM(this.BPBBEKAKOAM), null);
			return;
		case 3U:
			if (this.MENCECDAAII.FPIHOPOCAHA.Trim() != "")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(45, this.MENCECDAAII.FPIHOPOCAHA);
				return;
			}
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
			return;
		case 4U:
			if (JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) != null)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM);
				ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(this.JJGEFPENAJI);
				if (onkdcgnbalk != null)
				{
					onkdcgnbalk.OCHCODJIPHJ.x = (float)(Screen.width / 2) - onkdcgnbalk.OCHCODJIPHJ.width / 2f;
					return;
				}
				return;
			}
			else
			{
				ONKDCGNBALK onkdcgnbalk2 = MDEKJCCIDIA.IKGFHGKKCPG.KOCKAHEKJDB();
				onkdcgnbalk2.OCHCODJIPHJ.x = (float)(Screen.width / 2 + 20);
				onkdcgnbalk2.GENHHJPGOFK = false;
				ONKDCGNBALK onkdcgnbalk3 = JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(this.JJGEFPENAJI);
				if (onkdcgnbalk3 != null)
				{
					onkdcgnbalk3.OCHCODJIPHJ.x = (float)(Screen.width / 2) - onkdcgnbalk3.OCHCODJIPHJ.width - 20f;
					return;
				}
				return;
			}
			break;
		case 5U:
		case 6U:
		case 7U:
		case 8U:
		case 10U:
			return;
		case 9U:
		{
			bool flag = true;
			foreach (HMKIBAFDFDJ.GJKMIBJFKGA gjkmibjfkga2 in this.LPANMJEEOFG)
			{
				if (gjkmibjfkga2.LPFKFNLHGBI == this.GALAGDCKNKI)
				{
					flag = !gjkmibjfkga2.EJMJOJGCMMC;
				}
			}
			if (flag)
			{
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1640, this.GALAGDCKNKI);
			}
			else
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("post_msg7"));
			}
			for (int i = 0; i < this.LPANMJEEOFG.Count; i++)
			{
				if (this.LPANMJEEOFG[i].LPFKFNLHGBI == this.GALAGDCKNKI)
				{
					this.LPANMJEEOFG.RemoveAt(i);
					break;
				}
			}
			this.MCNPBFIPJGI(this.BPMFFMJFDFB);
			return;
		}
		case 11U:
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1650, this.HFPJAOPHEOF);
			return;
		default:
			return;
		}
		if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CNOLCNDBLJE) < 5)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("error"), JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("newletter"));
			return;
		}
		this.MGBJMKIIMPO(this.DELFGPAPOPB);
		return;
	}

	// Token: 0x060047AD RID: 18349 RVA: 0x00222CD4 File Offset: 0x00220ED4
	public void IHDCKGKLDDP(HBPNMNGOFMA KADBECGIMPD)
	{
		int num = KADBECGIMPD.KDNDJNEGBDI();
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(false);
		Debug.Log("\n" + num);
		switch (num)
		{
		case 0:
			JDCEFOFMGHB.JFIDAGABKID().DGFAPDDBHJB(this.JJGEFPENAJI);
			JDCEFOFMGHB.IKGFHGKKCPG.POIPOBBIDPM("Windmill", JNBICAJIJMM.CDDCIKKDFMP("V"));
			return;
		case 1:
			JDCEFOFMGHB.IKGFHGKKCPG.POIPOBBIDPM(JNBICAJIJMM.NGALDMFKMJH("costume_"), JNBICAJIJMM.CDDCIKKDFMP("knopje.wav"));
			return;
		case 2:
			JDCEFOFMGHB.JFIDAGABKID().KGHDLHHLLIC(JNBICAJIJMM.OOOKJHOHPNN("_DelItem.wav"), JNBICAJIJMM.BDKHMOOFHHK("UI_MapWindow_b"));
			return;
		case 3:
			JDCEFOFMGHB.HMJJPNDEKPP().NODOOHPCCCB(JNBICAJIJMM.CELEPPAEKAB("SoccerSprint"), JNBICAJIJMM.PGJCPFNJNPM("Zombie Idle 2"));
			return;
		case 4:
			JDCEFOFMGHB.MNJNNDHCDGG().NODOOHPCCCB(JNBICAJIJMM.DIOJFJMOPJO("_WrinkleOcclusionMap2"), JNBICAJIJMM.PPNKMDJBMLP("_ALPHATEST_ON"));
			return;
		case 5:
			JDCEFOFMGHB.MNJNNDHCDGG().NODOOHPCCCB(JNBICAJIJMM.LEBHCLDODNI("Climb Up"), JNBICAJIJMM.NGALDMFKMJH("\n"));
			return;
		default:
			return;
		}
	}

	// Token: 0x060047AE RID: 18350 RVA: 0x00222DEC File Offset: 0x00220FEC
	public void PAGDOCEKACB(ONKDCGNBALK JMAKEAHMLMI)
	{
		this.BBKMADFJMIB.FNBPGKNNHPA(JNBICAJIJMM.OOOKJHOHPNN("usetime") + "INTERFACE" + JLFJEGIPIMM.IKGFHGKKCPG.EJOPKKGIIIO(1L, (long)this.KOKDOGENLJM()));
		if (JDCEFOFMGHB.IKGFHGKKCPG.IHNMOJHBMNJ(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) == null)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().HILJENLHLDE(this.JJGEFPENAJI);
			if (onkdcgnbalk != null)
			{
				onkdcgnbalk.OCHCODJIPHJ.x = (float)(Screen.width / 6) - onkdcgnbalk.OCHCODJIPHJ.width / 1686f;
				onkdcgnbalk.OCHCODJIPHJ.y = (float)(Screen.height / 8) - onkdcgnbalk.OCHCODJIPHJ.height / 1297f;
			}
		}
	}

	// Token: 0x060047AF RID: 18351 RVA: 0x00222EA0 File Offset: 0x002210A0
	private void MCNPBFIPJGI(MMKFAENBHKD LAHPPNFNJGJ)
	{
		foreach (HMKIBAFDFDJ.GJKMIBJFKGA gjkmibjfkga in this.LPANMJEEOFG)
		{
			gjkmibjfkga.onRender = new ItemBase.OOALOMPKIKK(HMKIBAFDFDJ.FBNJLPMNBME);
			LAHPPNFNJGJ.LACAJHOHACK.Add(gjkmibjfkga);
		}
	}

	// Token: 0x060047B0 RID: 18352 RVA: 0x00222F0C File Offset: 0x0022110C
	private void NGCBNENGLMF(MMKFAENBHKD LAHPPNFNJGJ, ItemBase FLGGHCELHHO)
	{
		this.MENCECDAAII.FPIHOPOCAHA = ((JBEHMPDDMME.PKGHFEGONDH)FLGGHCELHHO).HGGLNBKFHKK;
	}

	// Token: 0x060047B1 RID: 18353 RVA: 0x00222F24 File Offset: 0x00221124
	private void GAIEDGCOEEH(MMKFAENBHKD LAHPPNFNJGJ)
	{
		foreach (HMKIBAFDFDJ.GJKMIBJFKGA gjkmibjfkga in this.LPANMJEEOFG)
		{
			gjkmibjfkga.onRender = new ItemBase.OOALOMPKIKK(HMKIBAFDFDJ.NFMAAKCJAEO);
			LAHPPNFNJGJ.LACAJHOHACK.Add(gjkmibjfkga);
		}
	}

	// Token: 0x060047B2 RID: 18354 RVA: 0x00222F90 File Offset: 0x00221190
	private static void FBNJLPMNBME(ONKDCGNBALK JLEJDINFJOF, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		HMKIBAFDFDJ.GJKMIBJFKGA gjkmibjfkga = (HMKIBAFDFDJ.GJKMIBJFKGA)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 11,
			font = GuiProcessor.IKGFHGKKCPG.rusfont,
			normal = 
			{
				textColor = (gjkmibjfkga.OJHLIAKCPJI ? Color.black : new Color(0f, 0.1f, 0.3f))
			},
			richText = true,
			alignment = TextAnchor.UpperLeft
		};
		int clbpbjglhee;
		if (gjkmibjfkga.EJMJOJGCMMC)
		{
			clbpbjglhee = (gjkmibjfkga.OJHLIAKCPJI ? 3 : 2);
		}
		else
		{
			clbpbjglhee = (gjkmibjfkga.OJHLIAKCPJI ? 1 : 0);
		}
		GUI.DrawTextureWithTexCoords(new Rect(OCHCODJIPHJ.x + 3f, OCHCODJIPHJ.y + 8f, 32f, 32f), GameInterface.getI.postIconsTexture, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(clbpbjglhee, 4, 1));
		string arg = string.Format("{0:dd/MM/yyyy в HH:mm}", gjkmibjfkga.EAPALMJECLD);
		string text = string.Format(JNBICAJIJMM.LEBHCLDODNI("post_9"), gjkmibjfkga.DELFGPAPOPB, arg);
		Rect position = new Rect(OCHCODJIPHJ.x + 16f + 32f, OCHCODJIPHJ.y + 12f, OCHCODJIPHJ.width - 32f, 20f);
		GUI.Label(position, text, guistyle);
		position.y += 12f;
		position.height = 16f;
		guistyle.fontSize = 14;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
		guistyle.fontStyle = FontStyle.Normal;
		guistyle.normal.textColor = (gjkmibjfkga.OJHLIAKCPJI ? Color.black : new Color(0f, 0.1f, 0.3f));
		GUI.Label(position, gjkmibjfkga.LODAKIGCDLK, guistyle);
		if (GUI.Button(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 95f, OCHCODJIPHJ.y + 4f, 90f, 20f), JNBICAJIJMM.LEBHCLDODNI("post_8")))
		{
			MMKFAENBHKD mmkfaenbhkd = (MMKFAENBHKD)JLEJDINFJOF;
			int dccpcblodig = mmkfaenbhkd.LACAJHOHACK.IndexOf(EKKILFOCDJF);
			mmkfaenbhkd.IHEILFHMLAG = dccpcblodig;
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.7f);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1610, gjkmibjfkga.LPFKFNLHGBI);
			gjkmibjfkga.OJHLIAKCPJI = true;
		}
	}

	// Token: 0x060047B3 RID: 18355 RVA: 0x002231E0 File Offset: 0x002213E0
	public void DBBDDGBIDBB(ONKDCGNBALK JMAKEAHMLMI)
	{
		this.BBKMADFJMIB.FPIHOPOCAHA = JNBICAJIJMM.LEBHCLDODNI("post_14") + " " + JLFJEGIPIMM.IKGFHGKKCPG.KMGIDLKLDML(0L, (long)this.NLHGNMPDFOO());
		if (JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(MDEKJCCIDIA.IKGFHGKKCPG.NGKLLCCLFCM) == null)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(this.JJGEFPENAJI);
			if (onkdcgnbalk != null)
			{
				onkdcgnbalk.OCHCODJIPHJ.x = (float)(Screen.width / 2) - onkdcgnbalk.OCHCODJIPHJ.width / 2f;
				onkdcgnbalk.OCHCODJIPHJ.y = (float)(Screen.height / 2) - onkdcgnbalk.OCHCODJIPHJ.height / 2f;
			}
		}
	}

	// Token: 0x060047B4 RID: 18356 RVA: 0x00223294 File Offset: 0x00221494
	private int KOKDOGENLJM()
	{
		int num = 32;
		num += (int)this.LOFILAHGKKD / 95;
		if (this.PDFGKGGNDBK.OBLONDPEGLN != null)
		{
			num += 102;
		}
		if (this.DLNOIHPFNAO.OBLONDPEGLN != null)
		{
			num += -10;
		}
		if (this.HAEIIGCPGPP.OBLONDPEGLN != null)
		{
			num += -30;
		}
		if (FlyMessageManager.getI.MMIMPMPGHPN(-62))
		{
			num /= 5;
		}
		return num;
	}

	// Token: 0x060047B5 RID: 18357 RVA: 0x002232FC File Offset: 0x002214FC
	private static void NFMAAKCJAEO(ONKDCGNBALK JLEJDINFJOF, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		HMKIBAFDFDJ.GJKMIBJFKGA gjkmibjfkga = (HMKIBAFDFDJ.GJKMIBJFKGA)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 20,
			font = GuiProcessor.IKGFHGKKCPG.rusfont,
			normal = 
			{
				textColor = (gjkmibjfkga.OJHLIAKCPJI ? Color.black : new Color(1177f, 222f, 1876f))
			},
			richText = true,
			alignment = TextAnchor.UpperCenter
		};
		int clbpbjglhee;
		if (gjkmibjfkga.EJMJOJGCMMC)
		{
			clbpbjglhee = (gjkmibjfkga.OJHLIAKCPJI ? 2 : 4);
		}
		else
		{
			clbpbjglhee = (gjkmibjfkga.OJHLIAKCPJI ? 1 : 0);
		}
		GUI.DrawTextureWithTexCoords(new Rect(OCHCODJIPHJ.x + 78f, OCHCODJIPHJ.y + 1922f, 515f, 1832f), GameInterface.getI.postIconsTexture, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(clbpbjglhee, 5, 0));
		string arg = string.Format("Hit", gjkmibjfkga.EAPALMJECLD);
		string text = string.Format(JNBICAJIJMM.LEBHCLDODNI("offsets"), gjkmibjfkga.DELFGPAPOPB, arg);
		Rect position = new Rect(OCHCODJIPHJ.x + 953f + 913f, OCHCODJIPHJ.y + 1926f, OCHCODJIPHJ.width - 1820f, 337f);
		GUI.Label(position, text, guistyle);
		position.y += 651f;
		position.height = 1748f;
		guistyle.fontSize = -112;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
		guistyle.fontStyle = FontStyle.Bold;
		guistyle.normal.textColor = (gjkmibjfkga.OJHLIAKCPJI ? Color.black : new Color(140f, 95f, 312f));
		GUI.Label(position, gjkmibjfkga.LODAKIGCDLK, guistyle);
		if (GUI.Button(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 1938f, OCHCODJIPHJ.y + 835f, 205f, 637f), JNBICAJIJMM.NGALDMFKMJH("RunJump")))
		{
			MMKFAENBHKD mmkfaenbhkd = (MMKFAENBHKD)JLEJDINFJOF;
			int dccpcblodig = mmkfaenbhkd.LACAJHOHACK.IndexOf(EKKILFOCDJF);
			mmkfaenbhkd.NEKOMKJDIIE(dccpcblodig);
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("KatanaVerticalSwing", 1464f);
			NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(-192, gjkmibjfkga.LPFKFNLHGBI);
			gjkmibjfkga.OJHLIAKCPJI = true;
		}
	}

	// Token: 0x060047B6 RID: 18358 RVA: 0x0022354C File Offset: 0x0022174C
	public void JEAEDEDINMJ(HBPNMNGOFMA KADBECGIMPD)
	{
		int num = KADBECGIMPD.HDBGOLAFOBK();
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		Debug.Log("code=" + num);
		switch (num)
		{
		case 0:
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.JJGEFPENAJI);
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("", JNBICAJIJMM.LEBHCLDODNI("post_msg1"));
			return;
		case 1:
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("post_msg2"));
			return;
		case 2:
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("post_msg3"));
			return;
		case 3:
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("post_msg4"));
			return;
		case 4:
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("post_msg5"));
			return;
		case 5:
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("post_msg6"));
			return;
		default:
			return;
		}
	}

	// Token: 0x060047B7 RID: 18359 RVA: 0x00223664 File Offset: 0x00221864
	public void BPBBEKAKOAM(ONKDCGNBALK OJIMHKHFOJI)
	{
		this.LOFILAHGKKD = OJIMHKHFOJI.ODFEKBJCFMN;
		if (this.LOFILAHGKKD > JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KFODJJIHNHP)
		{
			this.LOFILAHGKKD = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KFODJJIHNHP;
		}
		this.LCDIJGFAJIO.FPIHOPOCAHA = JLFJEGIPIMM.IKGFHGKKCPG.KMGIDLKLDML(0L, this.LOFILAHGKKD);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("money2.wav", 1f);
	}

	// Token: 0x060047B8 RID: 18360 RVA: 0x002236DC File Offset: 0x002218DC
	public void OPIGAPFABPI(HBPNMNGOFMA KADBECGIMPD)
	{
		int num = KADBECGIMPD.AGNKAFLKCAG();
		JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(true);
		Debug.Log("Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()" + num);
		switch (num)
		{
		case 0:
			JDCEFOFMGHB.JFIDAGABKID().CBHHEHHNFKL(this.JJGEFPENAJI);
			JDCEFOFMGHB.HMJJPNDEKPP().KGHDLHHLLIC("ApplePick", JNBICAJIJMM.PGJCPFNJNPM("FlyRight"));
			return;
		case 1:
			JDCEFOFMGHB.IKGFHGKKCPG.NODOOHPCCCB(JNBICAJIJMM.LEBHCLDODNI("[ACTk] Injection Detector: already running!"), JNBICAJIJMM.CELEPPAEKAB("_Params2"));
			return;
		case 2:
			JDCEFOFMGHB.HMJJPNDEKPP().KGHDLHHLLIC(JNBICAJIJMM.NGALDMFKMJH("Y (G)"), JNBICAJIJMM.CDDCIKKDFMP(" %"));
			return;
		case 3:
			JDCEFOFMGHB.HMJJPNDEKPP().NODOOHPCCCB(JNBICAJIJMM.PGJCPFNJNPM(""), JNBICAJIJMM.DIOJFJMOPJO("1HandSwordStrafeRight"));
			return;
		case 4:
			JDCEFOFMGHB.MNJNNDHCDGG().NODOOHPCCCB(JNBICAJIJMM.OOOKJHOHPNN("_Position"), JNBICAJIJMM.BDKHMOOFHHK("locData not found"));
			return;
		case 5:
			JDCEFOFMGHB.HMJJPNDEKPP().KGHDLHHLLIC(JNBICAJIJMM.NGALDMFKMJH("error"), JNBICAJIJMM.OOOKJHOHPNN("IceHockeyDekeMiddle"));
			return;
		default:
			return;
		}
	}

	// Token: 0x060047B9 RID: 18361 RVA: 0x002237F4 File Offset: 0x002219F4
	public void BCCOGADEDDO(HBPNMNGOFMA KADBECGIMPD)
	{
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(300f, 430f, JNBICAJIJMM.LEBHCLDODNI("post_17"), true);
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 20f, 60f, onkdcgnbalk.OCHCODJIPHJ.width - 40f, onkdcgnbalk.OCHCODJIPHJ.height - 120f, 0);
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			JBEHMPDDMME.PKGHFEGONDH item = new JBEHMPDDMME.PKGHFEGONDH(KADBECGIMPD);
			mmkfaenbhkd.LACAJHOHACK.Add(item);
		}
		mmkfaenbhkd.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.NGCBNENGLMF);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 64f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("post_4"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
	}

	// Token: 0x060047BA RID: 18362 RVA: 0x002238DC File Offset: 0x00221ADC
	public void CNMBNMAGLDD(HBPNMNGOFMA KADBECGIMPD)
	{
		if (this.JJPJEFHGHOC > 0)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.JJPJEFHGHOC);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(660f, 435f, "", true);
		this.JJPJEFHGHOC = onkdcgnbalk.LPFKFNLHGBI;
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, 20f, 60f, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 35f, "", 0, null);
		egcaadaabpp.FNMCIACNOMH = false;
		this.HFPJAOPHEOF = KADBECGIMPD.DNIIFBAIPBE();
		this.MFFBBOJFDJA = KADBECGIMPD.DNIIFBAIPBE();
		this.DELFGPAPOPB = KADBECGIMPD.BFPHBMDMODH();
		string text = KADBECGIMPD.BFPHBMDMODH();
		new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 10f, egcaadaabpp.OCHCODJIPHJ.y + 4f, egcaadaabpp.OCHCODJIPHJ.width, 16f, JNBICAJIJMM.LEBHCLDODNI("post_10") + " " + this.DELFGPAPOPB, TextAnchor.UpperLeft, Color.black);
		new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 10f, egcaadaabpp.OCHCODJIPHJ.y + 20f, egcaadaabpp.OCHCODJIPHJ.width, 16f, JNBICAJIJMM.LEBHCLDODNI("post_11") + " " + text, TextAnchor.UpperLeft, Color.black);
		onkdcgnbalk.DPANHMGCBNL = text;
		KADBECGIMPD.IKJAOHGGCJD();
		Rect rect = new Rect(20f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height + 5f, onkdcgnbalk.OCHCODJIPHJ.width - 40f, onkdcgnbalk.OCHCODJIPHJ.height - 168f - 10f - egcaadaabpp.OCHCODJIPHJ.height);
		string text2 = KADBECGIMPD.BFPHBMDMODH();
		text2 = text2.Replace("[quote]", "<i><color='#202020'>");
		text2 = text2.Replace("[/quote]", "</color></i>");
		string text3 = KADBECGIMPD.BFPHBMDMODH();
		if (text3.Trim() == "")
		{
			rect.height += 61f;
		}
		else
		{
			Rect rect2 = new Rect(20f, rect.y + rect.height + 5f, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 56f);
			new EGCAADAABPP(onkdcgnbalk, rect2.x, rect2.y, rect2.width, rect2.height, "", 0, null).FNMCIACNOMH = false;
			float num = rect2.x;
			text3 = text3.Replace(';', '\n');
			string[] array = text3.Split(new char[]
			{
				'\n'
			});
			for (int i = 0; i < array.Length; i++)
			{
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(array[i]);
				if (diggohpgcnn.OKEBIHBDEOO("money"))
				{
					new MGLHIBHDMPC(onkdcgnbalk, new Rect(num, rect2.y, 56f, 56f), GameInterface.getI.invEmptyCell);
					new MGLHIBHDMPC(onkdcgnbalk, num + 8f, rect2.y + 20f, 0, GameInterface.getI.MoneyIcon);
					new LCOLJOPGDLL(onkdcgnbalk, num + 8f + (float)(GameInterface.getI.MoneyIcon.width / 2) - 75f, rect2.y + 8f, 150f, 22f, JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)diggohpgcnn.DIKKDGKIPEA, false), TextAnchor.UpperCenter, Color.black).LNDPBNODFPE = true;
					num += 60f;
				}
				if (diggohpgcnn.OKEBIHBDEOO("template"))
				{
					IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(diggohpgcnn.IEIMMFODGFG);
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(iibeekcaahk.IBEIBAHKIAH);
					if (befchfngomi != null)
					{
						befchfngomi.JIFFLPNBILE();
						new MGLHIBHDMPC(onkdcgnbalk, new Rect(num, rect2.y, 56f, 56f), GameInterface.getI.invEmptyCell);
						new MGLHIBHDMPC(onkdcgnbalk, new Rect(num, rect2.y, 56f, 56f), befchfngomi.OLNGOHEPLBO).NOFPHJDJNFL = string.Format("{0} - {1} шт", befchfngomi.JPBOPFNPNHC(false, -1), iibeekcaahk.ICJDPPOJINN);
						num += 60f;
					}
				}
				if (diggohpgcnn.OKEBIHBDEOO("weapon"))
				{
					EKBAPCMPANI ekbapcmpani = IHFEDJEMJMB.IKGFHGKKCPG.IPGMHEHMAGJ(diggohpgcnn.DLJNOCONOJO);
					if (ekbapcmpani != null)
					{
						new KEPNAIFBDKF(onkdcgnbalk, num, rect2.y, ekbapcmpani, 0).KPLMFNIFPMM = true;
					}
					num += 60f;
				}
			}
		}
		new EGCAADAABPP(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, "", 0, null);
		this.CIFLGIOICEN = new JDJNBFJECFO(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, text2, 0);
		this.CIFLGIOICEN.DOACHOMNMCG = false;
		this.CIFLGIOICEN.KCLLDJJLCGC = 14;
		this.CIFLGIOICEN.LCBPIFKDAGK = Color.black;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 128f - 20f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("post_4"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 256f - 30f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("post_12"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(this.DLNMBGOGIMO)).FNMCIACNOMH = (this.MFFBBOJFDJA > 10L);
		new MEMEOHJKPNJ(onkdcgnbalk, 20f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("post_13"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.DLNMBGOGIMO)).FNMCIACNOMH = (text3.Trim() != "");
	}

	// Token: 0x060047BB RID: 18363 RVA: 0x00223F20 File Offset: 0x00222120
	private int NLHGNMPDFOO()
	{
		int num = 10;
		num += (int)this.LOFILAHGKKD / 10;
		if (this.PDFGKGGNDBK.OBLONDPEGLN != null)
		{
			num += 100;
		}
		if (this.DLNOIHPFNAO.OBLONDPEGLN != null)
		{
			num += 100;
		}
		if (this.HAEIIGCPGPP.OBLONDPEGLN != null)
		{
			num += 100;
		}
		if (FlyMessageManager.getI.checkFlyIcon(20))
		{
			num /= 2;
		}
		return num;
	}

	// Token: 0x060047BC RID: 18364 RVA: 0x00223F88 File Offset: 0x00222188
	public void ACKHMEIGDKB(HBPNMNGOFMA KADBECGIMPD)
	{
		int num = KADBECGIMPD.AGNKAFLKCAG();
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(true);
		Debug.Log("knopje.wav" + num);
		switch (num)
		{
		case 0:
			JDCEFOFMGHB.IKGFHGKKCPG.DGFAPDDBHJB(this.JJGEFPENAJI);
			JDCEFOFMGHB.JFIDAGABKID().NODOOHPCCCB("_FogOfWarCenterAdjusted", JNBICAJIJMM.PPNKMDJBMLP("_ALPHATEST_ON"));
			return;
		case 1:
			JDCEFOFMGHB.HMJJPNDEKPP().BEIDJANKEFD(JNBICAJIJMM.BDKHMOOFHHK("_TextureSize"), JNBICAJIJMM.DIOJFJMOPJO("delcharmsg1"));
			return;
		case 2:
			JDCEFOFMGHB.HMJJPNDEKPP().KGHDLHHLLIC(JNBICAJIJMM.BDKHMOOFHHK(""), JNBICAJIJMM.DIOJFJMOPJO("cht_ae"));
			return;
		case 3:
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.BDKHMOOFHHK(""), JNBICAJIJMM.DCEBAJIILPC("Tip"));
			return;
		case 4:
			JDCEFOFMGHB.JFIDAGABKID().BEIDJANKEFD(JNBICAJIJMM.NGALDMFKMJH("System.Boolean"), JNBICAJIJMM.CDDCIKKDFMP("MotorbikeIdle"));
			return;
		case 5:
			JDCEFOFMGHB.MNJNNDHCDGG().BEIDJANKEFD(JNBICAJIJMM.DCEBAJIILPC("craft_data/categories/category"), JNBICAJIJMM.CELEPPAEKAB("CrawlLocomotion"));
			return;
		default:
			return;
		}
	}

	// Token: 0x060047BD RID: 18365 RVA: 0x002240A0 File Offset: 0x002222A0
	public void HLNCHDINJPK(ONKDCGNBALK OJIMHKHFOJI)
	{
		Debug.Log("sendLetterPress");
		if (this.MENCECDAAII.FPIHOPOCAHA.Trim() == "")
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.NEHCMOODKIN(this.MENCECDAAII.FPIHOPOCAHA);
			epmphjgalbe.NEHCMOODKIN(this.EAMAHJPCCAB.FPIHOPOCAHA);
			epmphjgalbe.NEHCMOODKIN(this.CIFLGIOICEN.FPIHOPOCAHA);
			epmphjgalbe.OBCCLNMPGEJ(this.LOFILAHGKKD);
			List<long> list = new List<long>();
			if (this.PDFGKGGNDBK.OBLONDPEGLN != null)
			{
				list.Add(this.PDFGKGGNDBK.OBLONDPEGLN.LPFKFNLHGBI);
			}
			if (this.DLNOIHPFNAO.OBLONDPEGLN != null)
			{
				list.Add(this.DLNOIHPFNAO.OBLONDPEGLN.LPFKFNLHGBI);
			}
			if (this.HAEIIGCPGPP.OBLONDPEGLN != null)
			{
				list.Add(this.HAEIIGCPGPP.OBLONDPEGLN.LPFKFNLHGBI);
			}
			epmphjgalbe.GOMLLPFFPNP(list.Count);
			foreach (long bjppebpndnj in list)
			{
				epmphjgalbe.OBCCLNMPGEJ(bjppebpndnj);
			}
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1660, epmphjgalbe.JDPHBLHOLAD());
			JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x060047BE RID: 18366 RVA: 0x00224238 File Offset: 0x00222438
	public void NEIEPJHLLMB(HBPNMNGOFMA KADBECGIMPD)
	{
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().PJHMHBAGFAN(421f, 414f, JNBICAJIJMM.LEBHCLDODNI("Attempting to set limb orientation to Vector3.zero axis"), true);
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 1535f, 596f, onkdcgnbalk.OCHCODJIPHJ.width - 1929f, onkdcgnbalk.OCHCODJIPHJ.height - 1897f, 0);
		while (!KADBECGIMPD.NLJJMKFBPBK())
		{
			JBEHMPDDMME.PKGHFEGONDH item = new JBEHMPDDMME.PKGHFEGONDH(KADBECGIMPD);
			mmkfaenbhkd.LACAJHOHACK.Add(item);
		}
		mmkfaenbhkd.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.NGCBNENGLMF);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 734f - 1805f, onkdcgnbalk.OCHCODJIPHJ.height - 698f, 1742f, 763f, JNBICAJIJMM.CELEPPAEKAB("http://www.root-motion.com/finalikdox/html/page3.html"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.JFIDAGABKID().HMBGLALKHCP));
	}

	// Token: 0x060047BF RID: 18367 RVA: 0x0022431D File Offset: 0x0022251D
	private void LPCLHLHICMO(MMKFAENBHKD LAHPPNFNJGJ, ItemBase HJGAIDNGOID)
	{
		this.GALAGDCKNKI = ((HMKIBAFDFDJ.GJKMIBJFKGA)HJGAIDNGOID).LPFKFNLHGBI;
	}

	// Token: 0x060047C0 RID: 18368 RVA: 0x00224330 File Offset: 0x00222530
	public void FAEBBEBLAMF()
	{
		if (this.BGENLIJOAGO > 0)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.BGENLIJOAGO);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(560f, 530f, JNBICAJIJMM.LEBHCLDODNI("post_2"), true);
		this.BGENLIJOAGO = onkdcgnbalk.LPFKFNLHGBI;
		Rect ochcodjiphj = new Rect(20f, 60f, onkdcgnbalk.OCHCODJIPHJ.width - 40f, onkdcgnbalk.OCHCODJIPHJ.height - 115f);
		new MGLHIBHDMPC(onkdcgnbalk, ochcodjiphj, GameInterface.getI.PaperTexture);
		this.BPMFFMJFDFB = new MMKFAENBHKD(onkdcgnbalk, ochcodjiphj.x, ochcodjiphj.y, ochcodjiphj.width, ochcodjiphj.height, 0)
		{
			JHNCNHAAJCH = 48f
		};
		this.MCNPBFIPJGI(this.BPMFFMJFDFB);
		if (this.LPANMJEEOFG.Count == 0)
		{
			new LCOLJOPGDLL(onkdcgnbalk, this.BPMFFMJFDFB.OCHCODJIPHJ.x, this.BPMFFMJFDFB.OCHCODJIPHJ.y, this.BPMFFMJFDFB.OCHCODJIPHJ.width, this.BPMFFMJFDFB.OCHCODJIPHJ.height, JNBICAJIJMM.LEBHCLDODNI("post_3"), TextAnchor.MiddleCenter, Color.black);
		}
		this.BPMFFMJFDFB.KCLLDJJLCGC = 12;
		this.BPMFFMJFDFB.NBCAEJHKLMG();
		this.BPMFFMJFDFB.IHEILFHMLAG = 0;
		this.BPMFFMJFDFB.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.LPCLHLHICMO);
		this.DELFGPAPOPB = "";
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 128f - 20f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 120f, 24f, JNBICAJIJMM.LEBHCLDODNI("post_4"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 256f - 30f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 120f, 24f, JNBICAJIJMM.LEBHCLDODNI("post_5"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(this.DLNMBGOGIMO));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 384f - 30f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 120f, 24f, JNBICAJIJMM.LEBHCLDODNI("post_6"), 10, null, new ONKDCGNBALK.CMMHGMILOIM(this.DLNMBGOGIMO));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 512f - 30f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 120f, 24f, JNBICAJIJMM.LEBHCLDODNI("post_7"), 12, null, new ONKDCGNBALK.CMMHGMILOIM(this.DLNMBGOGIMO));
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
	}

	// Token: 0x060047C1 RID: 18369 RVA: 0x00224608 File Offset: 0x00222808
	public void MGBJMKIIMPO(string IEDEFOANFMM)
	{
		this.LOFILAHGKKD = 0L;
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(640f, 535f, JNBICAJIJMM.LEBHCLDODNI("post_15"), true);
		this.JJGEFPENAJI = onkdcgnbalk.LPFKFNLHGBI;
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, 20f, 60f, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 100f, "", 0, null);
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 5f, egcaadaabpp.OCHCODJIPHJ.y + 5f, JNBICAJIJMM.LEBHCLDODNI("post_16"), true);
		lcoljopgdll.LBCGACKJCJB = Color.black;
		lcoljopgdll.DFIGKKMMIAF = 14;
		this.MENCECDAAII = new GHDNOAMIABN(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 5f, egcaadaabpp.OCHCODJIPHJ.y + 20f, 300f, 24f, IEDEFOANFMM, 0);
		new MEMEOHJKPNJ(onkdcgnbalk, this.MENCECDAAII.OCHCODJIPHJ.x + this.MENCECDAAII.OCHCODJIPHJ.width + 5f, this.MENCECDAAII.OCHCODJIPHJ.y, 70f, 24f, JNBICAJIJMM.LEBHCLDODNI("post_17"), 4, null, new ONKDCGNBALK.CMMHGMILOIM(this.DLNMBGOGIMO));
		new MEMEOHJKPNJ(onkdcgnbalk, this.MENCECDAAII.OCHCODJIPHJ.x + this.MENCECDAAII.OCHCODJIPHJ.width + 80f, this.MENCECDAAII.OCHCODJIPHJ.y, 70f, 24f, JNBICAJIJMM.LEBHCLDODNI("post_18"), 0, null, null);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 5f, egcaadaabpp.OCHCODJIPHJ.y + 55f, JNBICAJIJMM.LEBHCLDODNI("post_19"), true);
		lcoljopgdll2.LBCGACKJCJB = Color.black;
		lcoljopgdll2.DFIGKKMMIAF = 14;
		this.EAMAHJPCCAB = new GHDNOAMIABN(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 5f, egcaadaabpp.OCHCODJIPHJ.y + 70f, egcaadaabpp.OCHCODJIPHJ.width - 10f, 24f, "", 0);
		Rect rect = new Rect(20f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height + 5f, onkdcgnbalk.OCHCODJIPHJ.width - 40f, onkdcgnbalk.OCHCODJIPHJ.height - 168f - 50f - egcaadaabpp.OCHCODJIPHJ.height);
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(rect.x, rect.y, rect.width, rect.height), GameInterface.getI.QBackTexture);
		new EGCAADAABPP(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, "", 0, null);
		this.CIFLGIOICEN = new JDJNBFJECFO(onkdcgnbalk, rect.x + 40f, rect.y, rect.width - 40f, rect.height, "", 0);
		this.CIFLGIOICEN.DOACHOMNMCG = true;
		this.CIFLGIOICEN.KCLLDJJLCGC = 14;
		this.CIFLGIOICEN.LCBPIFKDAGK = Color.black;
		float num = onkdcgnbalk.OCHCODJIPHJ.width / 2f;
		EGCAADAABPP egcaadaabpp2 = new EGCAADAABPP(onkdcgnbalk, 20f, onkdcgnbalk.OCHCODJIPHJ.height - 115f - 30f, num - 25f, 66f, "", 0, null);
		EGCAADAABPP egcaadaabpp3 = new EGCAADAABPP(onkdcgnbalk, num + 5f, onkdcgnbalk.OCHCODJIPHJ.height - 115f - 30f, num - 25f, 66f, "", 0, null);
		new FNFPGPBCIGK(onkdcgnbalk, egcaadaabpp2.OCHCODJIPHJ.x + 5f, egcaadaabpp2.OCHCODJIPHJ.y + 5f, 3, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, 2, 4, 0, new ONKDCGNBALK.CMMHGMILOIM(this.DLNMBGOGIMO));
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp2.OCHCODJIPHJ.x + 26f, egcaadaabpp2.OCHCODJIPHJ.y + 7f, JNBICAJIJMM.LEBHCLDODNI("post_20"), true);
		lcoljopgdll3.LBCGACKJCJB = Color.black;
		lcoljopgdll3.DFIGKKMMIAF = 14;
		this.LCDIJGFAJIO = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp2.OCHCODJIPHJ.x + 15f, egcaadaabpp2.OCHCODJIPHJ.y + 30f, JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, this.LOFILAHGKKD, false), true)
		{
			LNDPBNODFPE = true,
			LBCGACKJCJB = Color.black,
			DFIGKKMMIAF = 18
		};
		new FNFPGPBCIGK(onkdcgnbalk, egcaadaabpp3.OCHCODJIPHJ.x + 5f, egcaadaabpp3.OCHCODJIPHJ.y + egcaadaabpp3.OCHCODJIPHJ.height / 2f - 8f, 5, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, 2, 4, 0, new ONKDCGNBALK.CMMHGMILOIM(this.DLNMBGOGIMO));
		this.PDFGKGGNDBK = new AENEOOFMBKE(onkdcgnbalk, egcaadaabpp3.OCHCODJIPHJ.x + 26f + 0f, egcaadaabpp3.OCHCODJIPHJ.y + 5f, 1, 51);
		this.DLNOIHPFNAO = new AENEOOFMBKE(onkdcgnbalk, egcaadaabpp3.OCHCODJIPHJ.x + 26f + 60f, egcaadaabpp3.OCHCODJIPHJ.y + 5f, 2, 51);
		this.HAEIIGCPGPP = new AENEOOFMBKE(onkdcgnbalk, egcaadaabpp3.OCHCODJIPHJ.x + 26f + 120f, egcaadaabpp3.OCHCODJIPHJ.y + 5f, 3, 51);
		this.PDFGKGGNDBK.OAJFBGDGGHD = false;
		this.DLNOIHPFNAO.OAJFBGDGGHD = false;
		this.HAEIIGCPGPP.OAJFBGDGGHD = false;
		this.PDFGKGGNDBK.PBHHLLKCICM = false;
		this.DLNOIHPFNAO.PBHHLLKCICM = false;
		this.HAEIIGCPGPP.PBHHLLKCICM = false;
		this.BBKMADFJMIB = new LCOLJOPGDLL(onkdcgnbalk, 20f, egcaadaabpp2.OCHCODJIPHJ.y + egcaadaabpp2.OCHCODJIPHJ.height + 5f, JNBICAJIJMM.LEBHCLDODNI("post_21") + " " + JLFJEGIPIMM.IKGFHGKKCPG.KMGIDLKLDML(0L, (long)this.NLHGNMPDFOO()), true);
		this.BBKMADFJMIB.LBCGACKJCJB = Color.black;
		this.BBKMADFJMIB.DFIGKKMMIAF = 14;
		this.BBKMADFJMIB.LNDPBNODFPE = true;
		this.BBKMADFJMIB.NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.DBBDDGBIDBB);
		this.BBKMADFJMIB.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 128f - 20f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("post_4"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
		new MEMEOHJKPNJ(onkdcgnbalk, 20f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("post_5"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.HLNCHDINJPK));
	}

	// Token: 0x04000B41 RID: 2881
	public static HMKIBAFDFDJ IKGFHGKKCPG = new HMKIBAFDFDJ();

	// Token: 0x04000B42 RID: 2882
	public List<HMKIBAFDFDJ.GJKMIBJFKGA> LPANMJEEOFG = new List<HMKIBAFDFDJ.GJKMIBJFKGA>();

	// Token: 0x04000B43 RID: 2883
	private MMKFAENBHKD BPMFFMJFDFB;

	// Token: 0x04000B44 RID: 2884
	private int BGENLIJOAGO = -1;

	// Token: 0x04000B45 RID: 2885
	private int JJPJEFHGHOC = -1;

	// Token: 0x04000B46 RID: 2886
	private long GALAGDCKNKI = -1L;

	// Token: 0x04000B47 RID: 2887
	private long HFPJAOPHEOF = -1L;

	// Token: 0x04000B48 RID: 2888
	private long MFFBBOJFDJA = -1L;

	// Token: 0x04000B49 RID: 2889
	private string DELFGPAPOPB;

	// Token: 0x04000B4A RID: 2890
	private GHDNOAMIABN MENCECDAAII;

	// Token: 0x04000B4B RID: 2891
	private GHDNOAMIABN EAMAHJPCCAB;

	// Token: 0x04000B4C RID: 2892
	private long LOFILAHGKKD;

	// Token: 0x04000B4D RID: 2893
	private AENEOOFMBKE KOHGFJALNGD;

	// Token: 0x04000B4E RID: 2894
	private LCOLJOPGDLL LCDIJGFAJIO;

	// Token: 0x04000B4F RID: 2895
	private LCOLJOPGDLL BBKMADFJMIB;

	// Token: 0x04000B50 RID: 2896
	private AENEOOFMBKE PDFGKGGNDBK;

	// Token: 0x04000B51 RID: 2897
	private AENEOOFMBKE DLNOIHPFNAO;

	// Token: 0x04000B52 RID: 2898
	private AENEOOFMBKE HAEIIGCPGPP;

	// Token: 0x04000B53 RID: 2899
	private JDJNBFJECFO CIFLGIOICEN;

	// Token: 0x04000B54 RID: 2900
	private int EOLIHBPOLNJ;

	// Token: 0x04000B55 RID: 2901
	public int JJGEFPENAJI;

	// Token: 0x02000155 RID: 341
	public class GJKMIBJFKGA : ItemBase
	{
		// Token: 0x060047C3 RID: 18371 RVA: 0x00224DAF File Offset: 0x00222FAF
		public virtual string FGNNJFJLENH()
		{
			return string.Format(JNBICAJIJMM.DIOJFJMOPJO("IceHockeyGoalieReady"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LFPIIPOHIEK()
		{
			return null;
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HKHAONBKECM()
		{
			return null;
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x00224DD7 File Offset: 0x00222FD7
		public virtual string MFPEPELOHBL()
		{
			return string.Format(JNBICAJIJMM.NGALDMFKMJH("[name]"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047C7 RID: 18375 RVA: 0x00224DFF File Offset: 0x00222FFF
		public virtual string PFNDMCPAGLP()
		{
			return string.Format(JNBICAJIJMM.PPNKMDJBMLP(" ms"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH AIHENNHGODP()
		{
			return null;
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x00224E27 File Offset: 0x00223027
		public virtual string DINGGHOCDNN()
		{
			return string.Format(JNBICAJIJMM.OOOKJHOHPNN("name"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x00224E4F File Offset: 0x0022304F
		public virtual string CBPDHBKDMGC()
		{
			return string.Format(JNBICAJIJMM.LEBHCLDODNI("Intensity"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047CB RID: 18379 RVA: 0x00224E77 File Offset: 0x00223077
		public virtual string NIDKKALEJIM()
		{
			return string.Format(JNBICAJIJMM.BDKHMOOFHHK("X2"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047CC RID: 18380 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH IPEDEEMNPFN()
		{
			return null;
		}

		// Token: 0x060047CD RID: 18381 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FEBAFNCKCGA()
		{
			return null;
		}

		// Token: 0x060047CE RID: 18382 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HGGBDGJLKKA()
		{
			return null;
		}

		// Token: 0x060047CF RID: 18383 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH PGFNEDLFAFD()
		{
			return null;
		}

		// Token: 0x060047D0 RID: 18384 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH GODNMDFNNBL()
		{
			return null;
		}

		// Token: 0x060047D1 RID: 18385 RVA: 0x00224E9F File Offset: 0x0022309F
		public virtual string BJALMHGGAFM()
		{
			return string.Format(JNBICAJIJMM.CDDCIKKDFMP(""), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047D2 RID: 18386 RVA: 0x00224EC7 File Offset: 0x002230C7
		public virtual string AGFCIEALPEM()
		{
			return string.Format(JNBICAJIJMM.CDDCIKKDFMP("knopje.wav"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047D3 RID: 18387 RVA: 0x00224EEF File Offset: 0x002230EF
		public virtual string HGANAOPCKFC()
		{
			return string.Format(JNBICAJIJMM.DCEBAJIILPC("qualityLevel"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x00224F17 File Offset: 0x00223117
		public virtual string JCAONLDGMCJ()
		{
			return string.Format(JNBICAJIJMM.CELEPPAEKAB("wpn_onlyw"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047D5 RID: 18389 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FGKHJANCMEM()
		{
			return null;
		}

		// Token: 0x060047D6 RID: 18390 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH BHPAALLBMHL()
		{
			return null;
		}

		// Token: 0x060047D7 RID: 18391 RVA: 0x00224F3F File Offset: 0x0022313F
		public virtual string DHCBHNAAJKI()
		{
			return string.Format(JNBICAJIJMM.NGALDMFKMJH("close"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x00224F67 File Offset: 0x00223167
		public virtual string CEOAKEEKAMH()
		{
			return string.Format(JNBICAJIJMM.LEBHCLDODNI("ShotgunFire"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DEOMJEEMGMI()
		{
			return null;
		}

		// Token: 0x060047DA RID: 18394 RVA: 0x00224F8F File Offset: 0x0022318F
		public virtual string NHDAHNIOAFD()
		{
			return string.Format(JNBICAJIJMM.LEBHCLDODNI("WATER_REFRACTIVE"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047DB RID: 18395 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LNHLBIOOINI()
		{
			return null;
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x00224FB7 File Offset: 0x002231B7
		public virtual string GAOJCHIOICI()
		{
			return string.Format(JNBICAJIJMM.NGALDMFKMJH("_Tile2RT"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH PBEMPJOBKKI()
		{
			return null;
		}

		// Token: 0x060047DE RID: 18398 RVA: 0x00224FDF File Offset: 0x002231DF
		public virtual string JODMFMFAOEG()
		{
			return string.Format(JNBICAJIJMM.PGJCPFNJNPM("cnt_energ"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047DF RID: 18399 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH GPIDMMEHMKF()
		{
			return null;
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HJKJBOMEHHJ()
		{
			return null;
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x00225007 File Offset: 0x00223207
		public virtual string DIACBNHNDCJ()
		{
			return string.Format(JNBICAJIJMM.CELEPPAEKAB("1="), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH HHOBCJNGCEL()
		{
			return null;
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HAEJBFNEIOM()
		{
			return null;
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH EJJAGEFMHCO()
		{
			return null;
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH HFAGADCJACL()
		{
			return null;
		}

		// Token: 0x060047E6 RID: 18406 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH MINPNPKJCMA()
		{
			return null;
		}

		// Token: 0x060047E7 RID: 18407 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH JMNBEKPPGLP()
		{
			return null;
		}

		// Token: 0x060047E8 RID: 18408 RVA: 0x0022502F File Offset: 0x0022322F
		public virtual string PINLAFIAGGJ()
		{
			return string.Format(JNBICAJIJMM.DIOJFJMOPJO("One of the bones in the Finger Rig is null, can not initiate solvers."), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x00225057 File Offset: 0x00223257
		public virtual string IGPNJMFIDOD()
		{
			return string.Format(JNBICAJIJMM.NGALDMFKMJH("Swim Idle"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047EA RID: 18410 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH GFPKGBJHPAO()
		{
			return null;
		}

		// Token: 0x060047EB RID: 18411 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DKNEPLMPHOD()
		{
			return null;
		}

		// Token: 0x060047EC RID: 18412 RVA: 0x0022507F File Offset: 0x0022327F
		public virtual string CFPMCOPINOH()
		{
			return string.Format(JNBICAJIJMM.DCEBAJIILPC("Kernel"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x002250A7 File Offset: 0x002232A7
		public virtual string PGOGIIBBPLM()
		{
			return string.Format(JNBICAJIJMM.OOOKJHOHPNN("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x002250CF File Offset: 0x002232CF
		public virtual string MDAPFDLEEGN()
		{
			return string.Format(JNBICAJIJMM.BDKHMOOFHHK("id"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x002250F7 File Offset: 0x002232F7
		public virtual string NDCLLIMPLEE()
		{
			return string.Format(JNBICAJIJMM.BDKHMOOFHHK("icon_data/icon"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047F0 RID: 18416 RVA: 0x0022511F File Offset: 0x0022331F
		public override string ToString()
		{
			return string.Format(JNBICAJIJMM.LEBHCLDODNI("post_1"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047F1 RID: 18417 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH ENCCFPGCLHA()
		{
			return null;
		}

		// Token: 0x060047F2 RID: 18418 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FEHBDOHNGGN()
		{
			return null;
		}

		// Token: 0x060047F3 RID: 18419 RVA: 0x00225147 File Offset: 0x00223347
		public virtual string NJECBCLINBO()
		{
			return string.Format(JNBICAJIJMM.PPNKMDJBMLP("Y (G)"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047F4 RID: 18420 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH IGBGJOLJFKJ()
		{
			return null;
		}

		// Token: 0x060047F5 RID: 18421 RVA: 0x0022516F File Offset: 0x0022336F
		public virtual string PNAEJEIKIOO()
		{
			return string.Format(JNBICAJIJMM.DIOJFJMOPJO("Bases/{0}/"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047F6 RID: 18422 RVA: 0x00225197 File Offset: 0x00223397
		public override string DIJJDHMMGCA()
		{
			return string.Format(JNBICAJIJMM.DCEBAJIILPC("<b>float:</b> "), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047F7 RID: 18423 RVA: 0x002251BF File Offset: 0x002233BF
		public virtual string AOJIJIPBKPB()
		{
			return string.Format(JNBICAJIJMM.OOOKJHOHPNN(""), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047F8 RID: 18424 RVA: 0x002251E7 File Offset: 0x002233E7
		public virtual string MJODNMLNFJC()
		{
			return string.Format(JNBICAJIJMM.PPNKMDJBMLP("and |assert |break |class |continue |def |del |elif |else |except |exec |finally |for |from |global |if |import |in |is |lambda |not |or |pass |print |raise |return |try |while |yield |None |True |False "), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047F9 RID: 18425 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DCIMNIONGEM()
		{
			return null;
		}

		// Token: 0x060047FA RID: 18426 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH BCKMFMCJDOG()
		{
			return null;
		}

		// Token: 0x060047FB RID: 18427 RVA: 0x0022520F File Offset: 0x0022340F
		public virtual string NCNNJHIIAFM()
		{
			return string.Format(JNBICAJIJMM.PPNKMDJBMLP("\n"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047FC RID: 18428 RVA: 0x00225237 File Offset: 0x00223437
		public virtual string NKOIIHFDNHP()
		{
			return string.Format(JNBICAJIJMM.LEBHCLDODNI("MotorbikeShootLeft"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x060047FD RID: 18429 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH AAMMIELGJNA()
		{
			return null;
		}

		// Token: 0x060047FE RID: 18430 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH OJONMJNDGAA()
		{
			return null;
		}

		// Token: 0x060047FF RID: 18431 RVA: 0x0022525F File Offset: 0x0022345F
		public virtual string DGOBKBBGGKN()
		{
			return string.Format(JNBICAJIJMM.CDDCIKKDFMP("post_4"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x06004800 RID: 18432 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH OAJANJBLPNC()
		{
			return null;
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LINIEFNDEEF()
		{
			return null;
		}

		// Token: 0x06004802 RID: 18434 RVA: 0x00225287 File Offset: 0x00223487
		public virtual string JHGPBNCOHHH()
		{
			return string.Format(JNBICAJIJMM.BDKHMOOFHHK("offsets"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x06004803 RID: 18435 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH PPJOPGPEFGI()
		{
			return null;
		}

		// Token: 0x06004804 RID: 18436 RVA: 0x002252AF File Offset: 0x002234AF
		public virtual string FPPLGDMIGKI()
		{
			return string.Format(JNBICAJIJMM.CDDCIKKDFMP("WateringCanWatering"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x06004805 RID: 18437 RVA: 0x002252D8 File Offset: 0x002234D8
		public GJKMIBJFKGA(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = KADBECGIMPD.DNIIFBAIPBE();
			this.DELFGPAPOPB = KADBECGIMPD.BFPHBMDMODH();
			this.LODAKIGCDLK = KADBECGIMPD.BFPHBMDMODH();
			this.EAPALMJECLD = KADBECGIMPD.IKJAOHGGCJD();
			this.EJMJOJGCMMC = KADBECGIMPD.FIFNOBGEKFF();
			this.OJHLIAKCPJI = KADBECGIMPD.FIFNOBGEKFF();
		}

		// Token: 0x06004806 RID: 18438 RVA: 0x00225333 File Offset: 0x00223533
		public virtual string HLHHDFFDHGL()
		{
			return string.Format(JNBICAJIJMM.CELEPPAEKAB("post_20"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x06004807 RID: 18439 RVA: 0x0022535B File Offset: 0x0022355B
		public virtual string EFODDEDDHCE()
		{
			return string.Format(JNBICAJIJMM.DIOJFJMOPJO("**"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x06004808 RID: 18440 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH FNIIBBGCFMB()
		{
			return null;
		}

		// Token: 0x06004809 RID: 18441 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HCHOBHCDHME()
		{
			return null;
		}

		// Token: 0x0600480A RID: 18442 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DDIDFFABBIO()
		{
			return null;
		}

		// Token: 0x0600480B RID: 18443 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public virtual CKNLPGEPGGF.IAPCJOBDCEH EDEPOFPDCEJ()
		{
			return null;
		}

		// Token: 0x0600480C RID: 18444 RVA: 0x00225383 File Offset: 0x00223583
		public virtual string GIOCLFJADKN()
		{
			return string.Format(JNBICAJIJMM.NGALDMFKMJH("6"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x0600480D RID: 18445 RVA: 0x002253AB File Offset: 0x002235AB
		public virtual string BHLHEJCILKF()
		{
			return string.Format(JNBICAJIJMM.BDKHMOOFHHK("noemail"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x0600480E RID: 18446 RVA: 0x002253D3 File Offset: 0x002235D3
		public virtual string DIPEOLHEMHK()
		{
			return string.Format(JNBICAJIJMM.DCEBAJIILPC("ZombieIdle"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x0600480F RID: 18447 RVA: 0x002253FB File Offset: 0x002235FB
		public override string OOLIOFBGDKC()
		{
			return string.Format(JNBICAJIJMM.BDKHMOOFHHK("v {0}.{1}.{2}"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x06004810 RID: 18448 RVA: 0x00225423 File Offset: 0x00223623
		public virtual string HDPLEBMIHFA()
		{
			return string.Format(JNBICAJIJMM.DCEBAJIILPC("u_pass"), this.DELFGPAPOPB, this.EAPALMJECLD, this.LODAKIGCDLK);
		}

		// Token: 0x06004811 RID: 18449 RVA: 0x000FFA6B File Offset: 0x000FDC6B
		public override CKNLPGEPGGF.IAPCJOBDCEH APLAAOCGECL()
		{
			return null;
		}

		// Token: 0x04000B56 RID: 2902
		public long LPFKFNLHGBI;

		// Token: 0x04000B57 RID: 2903
		public string LODAKIGCDLK;

		// Token: 0x04000B58 RID: 2904
		public string DELFGPAPOPB;

		// Token: 0x04000B59 RID: 2905
		public DateTime EAPALMJECLD;

		// Token: 0x04000B5A RID: 2906
		public bool EJMJOJGCMMC;

		// Token: 0x04000B5B RID: 2907
		public bool OJHLIAKCPJI;
	}
}
