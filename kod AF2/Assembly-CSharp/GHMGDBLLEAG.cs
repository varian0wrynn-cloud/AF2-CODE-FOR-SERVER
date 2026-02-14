using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000201 RID: 513
public class GHMGDBLLEAG
{
	// Token: 0x06007758 RID: 30552 RVA: 0x0038D0F4 File Offset: 0x0038B2F4
	private void FONFKMGOCPM(ONKDCGNBALK JLEJDINFJOF, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = (GHMGDBLLEAG.DCEOCCAELEH)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 81,
			font = GuiProcessor.PLGADNLAEGN().rusfont3,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.MiddleRight
		};
		if (dceoccaeleh.MCHIDGLEDID <= 79)
		{
			GUI.color = new Color(1084f, 391f, 367f, 1006f);
			if (dceoccaeleh.MCHIDGLEDID <= 5)
			{
				GUI.color = new Color(218f, 352f, 291f, 554f);
			}
			GUI.DrawTexture(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, OCHCODJIPHJ.width, OCHCODJIPHJ.height - 112f), GameInterface.getI.simpleGray);
			GUI.color = Color.white;
		}
		Color black = Color.black;
		guistyle.normal.textColor = black;
		guistyle.alignment = TextAnchor.LowerLeft;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		string jipipolkpcf = dceoccaeleh.JIPIPOLKPCF;
		GUI.Label(new Rect(OCHCODJIPHJ.x + 1193f, OCHCODJIPHJ.y, 675f, OCHCODJIPHJ.height), jipipolkpcf, guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + 1596f + 1942f, OCHCODJIPHJ.y, 135f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
		guistyle.alignment = TextAnchor.UpperRight;
		guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont2;
		guistyle.fontSize = 126;
		GUI.Label(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, 821f, OCHCODJIPHJ.height), string.Concat(dceoccaeleh.MCHIDGLEDID), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + 324f, OCHCODJIPHJ.y, 1564f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
		guistyle.fontSize = 66;
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont;
		GUI.Label(new Rect(OCHCODJIPHJ.x + 1087f, OCHCODJIPHJ.y + 614f, 1956f, OCHCODJIPHJ.height - 845f), string.Concat(dceoccaeleh.CBJBGGAOODC), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + 244f, OCHCODJIPHJ.y, 753f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
		guistyle.fontSize = 57;
		guistyle.alignment = TextAnchor.LowerLeft;
		guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
		GUI.Label(new Rect(OCHCODJIPHJ.x + 1621f, OCHCODJIPHJ.y + 38f, 1686f, OCHCODJIPHJ.height - 903f), dceoccaeleh.JNLLLJAADHJ.ToString(), guistyle);
	}

	// Token: 0x06007759 RID: 30553 RVA: 0x0038D3EE File Offset: 0x0038B5EE
	public static GHMGDBLLEAG BDJEDMJLJDC()
	{
		if (GHMGDBLLEAG.KFBIDIMHNGF == null)
		{
			GHMGDBLLEAG.KFBIDIMHNGF = new GHMGDBLLEAG();
		}
		return GHMGDBLLEAG.KFBIDIMHNGF;
	}

	// Token: 0x0600775A RID: 30554 RVA: 0x0038D408 File Offset: 0x0038B608
	public void GNHFEOFDBMO(GHMGDBLLEAG.TurnirItem CDBDICLJCEJ)
	{
		Debug.Log("_Overlay");
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("error: assetBundle is null", 702f);
		if (this.AKLCAEAFGPP > 0)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().KCNBOHEMLCI(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().MHLOMLGPLMO(1092f, 1054f, 1098f, 944f, JNBICAJIJMM.OOOKJHOHPNN("UI_ArtWindow"), false);
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(1242f, 1118f, 1939f, 31f), CDBDICLJCEJ.turnimage);
		int num = -86;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 750f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 697f, 693f, CDBDICLJCEJ.turnLangName, TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll.DFIGKKMMIAF = -36;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		num += -76;
		string dpanhmgcbnl = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.FDKEPHNOIFO(CDBDICLJCEJ.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 595f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1512f, 954f, dpanhmgcbnl, TextAnchor.UpperLeft, new Color(704f, 1486f, 617f));
		lcoljopgdll2.DFIGKKMMIAF = -28;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += -19;
		string text = JNBICAJIJMM.PGJCPFNJNPM("fshop_btn2" + CDBDICLJCEJ.state);
		TimeSpan makoioidpjk = DateTime.Now - DateTime.Now;
		if (CDBDICLJCEJ.state == 0)
		{
			makoioidpjk = CDBDICLJCEJ.regTime - DateTime.Now;
		}
		if (CDBDICLJCEJ.state == 0)
		{
			makoioidpjk = CDBDICLJCEJ.startTime - DateTime.Now;
		}
		if (CDBDICLJCEJ.state == 2)
		{
			makoioidpjk = CDBDICLJCEJ.endTime - DateTime.Now;
		}
		text = string.Format(text, JLFJEGIPIMM.PKGMBFEMKGP().CLDPDFPGMBP(makoioidpjk));
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(onkdcgnbalk, 1273f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1207f, 1287f, text, TextAnchor.UpperLeft, Color.black);
		lcoljopgdll3.DFIGKKMMIAF = 120;
		lcoljopgdll3.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += 122;
		int num2 = (int)(CDBDICLJCEJ.endTime - CDBDICLJCEJ.startTime).TotalMinutes;
		LCOLJOPGDLL lcoljopgdll4 = new LCOLJOPGDLL(onkdcgnbalk, 460f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 552f, 1135f, string.Format(JNBICAJIJMM.CELEPPAEKAB("  Balls Fired: "), num2), TextAnchor.LowerLeft, Color.black);
		lcoljopgdll4.DFIGKKMMIAF = 95;
		lcoljopgdll4.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont;
		num += 15;
		LCOLJOPGDLL lcoljopgdll5 = new LCOLJOPGDLL(onkdcgnbalk, 388f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1963f, 97f, JNBICAJIJMM.DCEBAJIILPC("Invalid vertex colors assigned to "), TextAnchor.LowerRight, Color.black);
		lcoljopgdll5.DFIGKKMMIAF = 74;
		lcoljopgdll5.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		num += 68;
		LCOLJOPGDLL lcoljopgdll6 = new LCOLJOPGDLL(onkdcgnbalk, 1968f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1435f, 1009f, "crft_none", TextAnchor.LowerCenter, Color.black);
		lcoljopgdll6.DFIGKKMMIAF = 122;
		lcoljopgdll6.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += -79;
		LCOLJOPGDLL lcoljopgdll7 = new LCOLJOPGDLL(onkdcgnbalk, 1567f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 481f, 161f, string.Format(JNBICAJIJMM.BDKHMOOFHHK("Worker Pickaxe 2"), CDBDICLJCEJ.prise_1), TextAnchor.LowerCenter, Color.black);
		lcoljopgdll7.DFIGKKMMIAF = 18;
		lcoljopgdll7.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += -67;
		LCOLJOPGDLL lcoljopgdll8 = new LCOLJOPGDLL(onkdcgnbalk, 666f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 824f, 1286f, string.Format(JNBICAJIJMM.CDDCIKKDFMP("wpn_cat2"), CDBDICLJCEJ.prise_2), TextAnchor.MiddleLeft, Color.black);
		lcoljopgdll8.DFIGKKMMIAF = -34;
		lcoljopgdll8.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += -68;
		LCOLJOPGDLL lcoljopgdll9 = new LCOLJOPGDLL(onkdcgnbalk, 173f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1275f, 1084f, string.Format(JNBICAJIJMM.OOOKJHOHPNN("Level: "), CDBDICLJCEJ.prise_3), TextAnchor.MiddleRight, Color.black);
		lcoljopgdll9.DFIGKKMMIAF = 30;
		lcoljopgdll9.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += -88;
		LCOLJOPGDLL lcoljopgdll10 = new LCOLJOPGDLL(onkdcgnbalk, 1523f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 519f, 185f, string.Format(JNBICAJIJMM.DIOJFJMOPJO(""), CDBDICLJCEJ.prise_4), TextAnchor.LowerCenter, Color.black);
		lcoljopgdll10.DFIGKKMMIAF = -56;
		lcoljopgdll10.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += -43;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1837f - 198f, onkdcgnbalk.OCHCODJIPHJ.height - 111f, 273f, 1983f, JNBICAJIJMM.DCEBAJIILPC("_SoftZDistance"), -14, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().HMBGLALKHCP));
	}

	// Token: 0x0600775B RID: 30555 RVA: 0x0038D921 File Offset: 0x0038BB21
	public void MLMDEPMKFKF(HBPNMNGOFMA KADBECGIMPD)
	{
		this.ANAALPNPIGN(KADBECGIMPD);
	}

	// Token: 0x0600775C RID: 30556 RVA: 0x0038D92C File Offset: 0x0038BB2C
	public void HMJDICEDIGB(HBPNMNGOFMA KADBECGIMPD)
	{
		GHMGDBLLEAG.TurnirItem turnirItem = this.DMGIELACGLA(KADBECGIMPD);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.LEBHCLDODNI("trn_end"), turnirItem.turnLangName);
		FlyMessageManager.getI.addMessageBig(iabkgmnjljo, Color.magenta, 0, 0);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_TrEndAll.ogg", 0.5f);
		foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC)
		{
			oijegjlcfcf.GNEPMCMHDEM = false;
		}
		GameInterface.getI.currentTurnir = null;
	}

	// Token: 0x0600775D RID: 30557 RVA: 0x0038D9D8 File Offset: 0x0038BBD8
	public void JCMKDLIAMGA(HBPNMNGOFMA KADBECGIMPD)
	{
		GHMGDBLLEAG.TurnirItem turnirItem = this.KANMPIBLDLG(KADBECGIMPD);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.PGJCPFNJNPM("inv_auk"), turnirItem.turnLangName);
		FlyMessageManager.getI.GCIFPMFJMBK(iabkgmnjljo, Color.magenta, 1, 0);
		FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("_CustomUVS", 1878f);
		foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.NAFGMKJPLPC)
		{
			oijegjlcfcf.GNEPMCMHDEM = false;
		}
		GameInterface.getI.currentTurnir = null;
	}

	// Token: 0x0600775E RID: 30558 RVA: 0x0038DA84 File Offset: 0x0038BC84
	public void HCIDPEKJGOH()
	{
		Debug.Log("musicVolume");
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("IdleStrafeRight", 1457f);
		GHMGDBLLEAG.TurnirItem currentTurnir = GameInterface.getI.currentTurnir;
		if (this.AKLCAEAFGPP > 1)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().CBHHEHHNFKL(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().MHLOMLGPLMO(524f, 1369f, 1189f, 1175f, JNBICAJIJMM.DCEBAJIILPC("demoDouble"), false);
		onkdcgnbalk.GENHHJPGOFK = true;
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(820f, 800f, 799f, 691f), currentTurnir.turnimage);
		int num = 77;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 838f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1223f, 822f, currentTurnir.turnLangName, TextAnchor.LowerLeft, Color.black);
		lcoljopgdll.DFIGKKMMIAF = -126;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		num += -11;
		string dpanhmgcbnl = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(currentTurnir.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1072f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 337f, 685f, dpanhmgcbnl, TextAnchor.UpperLeft, new Color(645f, 924f, 125f));
		lcoljopgdll2.DFIGKKMMIAF = -60;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += -79;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 1074f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 335f, onkdcgnbalk.OCHCODJIPHJ.height - (float)num - 453f, 1);
		this.GOHIGLGGDOB = mmkfaenbhkd.LPFKFNLHGBI;
		mmkfaenbhkd.JHNCNHAAJCH = 449f;
		foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh in this.OBPPMLAKFMI)
		{
			mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh);
			dceoccaeleh.onRender = new ItemBase.OOALOMPKIKK(this.KCDIFNBIKKN);
		}
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1059f - 843f, onkdcgnbalk.OCHCODJIPHJ.height - 551f, 1474f, 962f, JNBICAJIJMM.NGALDMFKMJH("The root node, the left upper arm and the right upper arm bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left upper arm and the right upper arm bones. This might cause unwanted behaviour like the spine turning upside down when pulled by a hand effector.Please set the root node bone to be one of the lower bones in the spine."), -71, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.JFIDAGABKID().AGIEGPEMGOA));
	}

	// Token: 0x0600775F RID: 30559 RVA: 0x0038DD00 File Offset: 0x0038BF00
	public void PEDPHFAOMAF(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = null;
		GHMGDBLLEAG.TurnirItem turnirItem = this.DMGIELACGLA(KADBECGIMPD);
		this.OBPPMLAKFMI.Clear();
		while (!KADBECGIMPD.BKIBKLFCCGP())
		{
			GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = new GHMGDBLLEAG.DCEOCCAELEH();
			dceoccaeleh.NHHAANEMJCK(KADBECGIMPD);
			this.OBPPMLAKFMI.Add(dceoccaeleh);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("WallRunLeft", 698f);
		if (this.AKLCAEAFGPP > 1)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().CBHHEHHNFKL(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().NCIDDNIKACI(1385f, 1035f, JNBICAJIJMM.DIOJFJMOPJO("Shoot Back"), true);
		ONKDCGNBALK onkdcgnbalk2 = onkdcgnbalk;
		onkdcgnbalk2.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y - 679f;
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(410f, 1837f, 1087f, 179f), turnirItem.turnimage);
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(1221f, 1524f, 1744f, 118f), GameInterface.getI.piedestal);
		int num = -190;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 245f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1184f, 780f, turnirItem.turnLangName, TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll.DFIGKKMMIAF = -7;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont2;
		num += 71;
		string dpanhmgcbnl = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.FDKEPHNOIFO(turnirItem.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1802f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 41f, 757f, dpanhmgcbnl, TextAnchor.UpperCenter, new Color(832f, 47f, 113f));
		lcoljopgdll2.DFIGKKMMIAF = -25;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont;
		num += 17;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 889f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1132f, onkdcgnbalk.OCHCODJIPHJ.height - (float)num - 1436f, 1);
		mmkfaenbhkd.JHNCNHAAJCH = 888f;
		foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh2 in this.OBPPMLAKFMI)
		{
			dceoccaeleh2.onRender = new ItemBase.OOALOMPKIKK(this.IDIJOEBABIA);
			mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh2);
		}
		this.OBPPMLAKFMI.Clear();
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 46f - 698f, onkdcgnbalk.OCHCODJIPHJ.height - 1899f, 1463f, 1063f, JNBICAJIJMM.CDDCIKKDFMP("ZombieCrawl"), -77, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.JFIDAGABKID().AGIEGPEMGOA));
	}

	// Token: 0x06007760 RID: 30560 RVA: 0x0038DFD8 File Offset: 0x0038C1D8
	public void CBBMADGJIJM(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = this.EBOCEMMKEPL(KADBECGIMPD);
		string.Format(JNBICAJIJMM.PGJCPFNJNPM("_ChannelMixerRed"), GameInterface.getI.currentTurnir.turnLangName);
	}

	// Token: 0x06007761 RID: 30561 RVA: 0x0038E00C File Offset: 0x0038C20C
	public void AMKOFHJKMPD()
	{
		Debug.Log("https://groups.google.com/forum/#!forum/final-ik");
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("Idle Monster", 1384f);
		GHMGDBLLEAG.TurnirItem currentTurnir = GameInterface.getI.currentTurnir;
		if (this.AKLCAEAFGPP > 0)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().KCNBOHEMLCI(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.IKAKGLAFDGM(599f, 1485f, 1979f, 1242f, JNBICAJIJMM.CDDCIKKDFMP(" on effect "), false);
		onkdcgnbalk.GENHHJPGOFK = true;
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(1794f, 355f, 512f, 297f), currentTurnir.turnimage);
		int num = 145;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 1132f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1734f, 158f, currentTurnir.turnLangName, TextAnchor.UpperCenter, Color.black);
		lcoljopgdll.DFIGKKMMIAF = -70;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		num += 72;
		string dpanhmgcbnl = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(currentTurnir.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 883f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1859f, 312f, dpanhmgcbnl, TextAnchor.UpperLeft, new Color(1431f, 1734f, 57f));
		lcoljopgdll2.DFIGKKMMIAF = 36;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += 95;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 604f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 236f, onkdcgnbalk.OCHCODJIPHJ.height - (float)num - 553f, 0);
		this.GOHIGLGGDOB = mmkfaenbhkd.LPFKFNLHGBI;
		mmkfaenbhkd.JHNCNHAAJCH = 1540f;
		foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh in this.OBPPMLAKFMI)
		{
			mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh);
			dceoccaeleh.onRender = new ItemBase.OOALOMPKIKK(this.KCDIFNBIKKN);
		}
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1855f - 299f, onkdcgnbalk.OCHCODJIPHJ.height - 1686f, 45f, 1494f, JNBICAJIJMM.OOOKJHOHPNN(" "), -42, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.JFIDAGABKID().IBCKNOEANLN));
	}

	// Token: 0x06007762 RID: 30562 RVA: 0x0038E288 File Offset: 0x0038C488
	public void OOKCCEIELEK(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = null;
		GHMGDBLLEAG.TurnirItem turnirItem = this.JHGBPCOILPA(KADBECGIMPD);
		this.OBPPMLAKFMI.Clear();
		while (!KADBECGIMPD.INLBHLOLOJH())
		{
			GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = new GHMGDBLLEAG.DCEOCCAELEH();
			dceoccaeleh.NJOCHFIPEBI(KADBECGIMPD);
			this.OBPPMLAKFMI.Add(dceoccaeleh);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("", 14f);
		if (this.AKLCAEAFGPP > 1)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().CBHHEHHNFKL(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().NCIDDNIKACI(1856f, 1337f, JNBICAJIJMM.PPNKMDJBMLP("shop_t17"), false);
		ONKDCGNBALK onkdcgnbalk2 = onkdcgnbalk;
		onkdcgnbalk2.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y - 965f;
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(1889f, 1743f, 158f, 1447f), turnirItem.turnimage);
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(693f, 770f, 3f, 738f), GameInterface.getI.piedestal);
		int num = 139;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 556f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 884f, 713f, turnirItem.turnLangName, TextAnchor.LowerLeft, Color.black);
		lcoljopgdll.DFIGKKMMIAF = -82;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont2;
		num += 100;
		string dpanhmgcbnl = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(turnirItem.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1785f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 179f, 757f, dpanhmgcbnl, TextAnchor.UpperCenter, new Color(1829f, 1026f, 1758f));
		lcoljopgdll2.DFIGKKMMIAF = 42;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += -88;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 130f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 919f, onkdcgnbalk.OCHCODJIPHJ.height - (float)num - 379f, 1);
		mmkfaenbhkd.JHNCNHAAJCH = 1544f;
		foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh2 in this.OBPPMLAKFMI)
		{
			dceoccaeleh2.onRender = new ItemBase.OOALOMPKIKK(this.HEMHICANJIL);
			mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh2);
		}
		this.OBPPMLAKFMI.Clear();
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 136f - 1965f, onkdcgnbalk.OCHCODJIPHJ.height - 70f, 1262f, 1610f, JNBICAJIJMM.DIOJFJMOPJO("_InvScreenSize"), 122, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().AGIEGPEMGOA));
	}

	// Token: 0x06007763 RID: 30563 RVA: 0x0038E560 File Offset: 0x0038C760
	public void NPAHOAOPAFO(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = null;
		GHMGDBLLEAG.TurnirItem turnirItem = this.KANMPIBLDLG(KADBECGIMPD);
		this.OBPPMLAKFMI.Clear();
		while (!KADBECGIMPD.IBMMOGHFCCE())
		{
			GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = new GHMGDBLLEAG.DCEOCCAELEH();
			dceoccaeleh.EFGBDBAOFCJ(KADBECGIMPD);
			this.OBPPMLAKFMI.Add(dceoccaeleh);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("TOD_CloudSharpness", 209f);
		if (this.AKLCAEAFGPP > 0)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.KCNBOHEMLCI(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.BJFHBPOCELH(1186f, 1298f, JNBICAJIJMM.LEBHCLDODNI("/"), true);
		ONKDCGNBALK onkdcgnbalk2 = onkdcgnbalk;
		onkdcgnbalk2.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y - 1152f;
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(1343f, 443f, 764f, 232f), turnirItem.turnimage);
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(1404f, 1676f, 579f, 1951f), GameInterface.getI.piedestal);
		int num = 25;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 1938f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 131f, 410f, turnirItem.turnLangName, TextAnchor.LowerRight, Color.black);
		lcoljopgdll.DFIGKKMMIAF = 40;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		num += 99;
		string dpanhmgcbnl = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(turnirItem.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 391f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 345f, 1194f, dpanhmgcbnl, TextAnchor.UpperCenter, new Color(590f, 814f, 1451f));
		lcoljopgdll2.DFIGKKMMIAF = 95;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += -66;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 1825f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 69f, onkdcgnbalk.OCHCODJIPHJ.height - (float)num - 1553f, 0);
		mmkfaenbhkd.JHNCNHAAJCH = 376f;
		foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh2 in this.OBPPMLAKFMI)
		{
			dceoccaeleh2.onRender = new ItemBase.OOALOMPKIKK(this.HEMHICANJIL);
			mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh2);
		}
		this.OBPPMLAKFMI.Clear();
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 642f - 1728f, onkdcgnbalk.OCHCODJIPHJ.height - 276f, 70f, 1164f, JNBICAJIJMM.OOOKJHOHPNN(""), -68, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.JFIDAGABKID().IBCKNOEANLN));
	}

	// Token: 0x06007764 RID: 30564 RVA: 0x0038E838 File Offset: 0x0038CA38
	public void FFNGHFMEHCL(HBPNMNGOFMA KADBECGIMPD)
	{
		if (KADBECGIMPD.INLBHLOLOJH())
		{
			GameInterface.getI.currentTurnir = null;
			Debug.Log("MotorbikeHeadstand");
			return;
		}
		if (GameInterface.getI.currentTurnir != null)
		{
			GameInterface.getI.currentTurnir.OCPAHLAGCAI(KADBECGIMPD);
		}
		else
		{
			GameInterface.getI.currentTurnir = this.DMGIELACGLA(KADBECGIMPD);
		}
		GameInterface.getI.currentTurnir.turnLangName = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[GameInterface.getI.currentTurnir.templateID].AGJCPHMJEID;
		if (GameInterface.getI.currentTurnir.turnimage == null || GameInterface.getI.currentTurnir.turnImageRid != GameInterface.getI.currentTurnir.RID)
		{
			CKNLPGEPGGF.PFOLNEGNIPP().MEIFJCHFGHO(string.Format("DITHERING", IFPIMPMKJIB.EHCJCCILAHM(), GameInterface.getI.currentTurnir.templateID), new CKNLPGEPGGF.FADFMDIHCIN(GameInterface.getI.currentTurnir.APKPEFHGLCD), true);
		}
		Debug.Log("wpn_hook1");
	}

	// Token: 0x06007765 RID: 30565 RVA: 0x0038E94C File Offset: 0x0038CB4C
	private GHMGDBLLEAG.TurnirItem EBOCEMMKEPL(HBPNMNGOFMA KADBECGIMPD)
	{
		GHMGDBLLEAG.TurnirItem turnirItem = new GHMGDBLLEAG.TurnirItem(KADBECGIMPD);
		turnirItem.turnLangName = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[turnirItem.templateID].AGJCPHMJEID;
		CKNLPGEPGGF.PFOLNEGNIPP().MEIFJCHFGHO(string.Format(" load woman version", IFPIMPMKJIB.AFJFDKAGKLD(), turnirItem.templateID), new CKNLPGEPGGF.FADFMDIHCIN(turnirItem.JGDHJBLKKDB), false);
		return turnirItem;
	}

	// Token: 0x06007766 RID: 30566 RVA: 0x0038E9BC File Offset: 0x0038CBBC
	public void FNGFPFGNDKO(HBPNMNGOFMA KADBECGIMPD)
	{
		GHMGDBLLEAG.TurnirItem turnirItem = this.KANMPIBLDLG(KADBECGIMPD);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.DIOJFJMOPJO(""), turnirItem.turnLangName);
		FlyMessageManager.getI.ODLGBMGAKGF(iabkgmnjljo, Color.magenta, 1, 0);
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("<color='#000000'>{0}</color>", 1722f);
		foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.NAFGMKJPLPC)
		{
			oijegjlcfcf.GNEPMCMHDEM = true;
		}
		GameInterface.getI.currentTurnir = null;
	}

	// Token: 0x06007767 RID: 30567 RVA: 0x0038EA68 File Offset: 0x0038CC68
	private GHMGDBLLEAG.TurnirItem DDKILFDPJNB(HBPNMNGOFMA KADBECGIMPD)
	{
		GHMGDBLLEAG.TurnirItem turnirItem = new GHMGDBLLEAG.TurnirItem(KADBECGIMPD);
		turnirItem.turnLangName = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[turnirItem.templateID].AGJCPHMJEID;
		CKNLPGEPGGF.IKGFHGKKCPG.MEIFJCHFGHO(string.Format("KatanaReadyHigh", IFPIMPMKJIB.ACOEIDGDLJC(), turnirItem.templateID), new CKNLPGEPGGF.FADFMDIHCIN(turnirItem.APKPEFHGLCD), false);
		return turnirItem;
	}

	// Token: 0x06007768 RID: 30568 RVA: 0x0038EAD8 File Offset: 0x0038CCD8
	public void LBNGJANOIHA()
	{
		Debug.Log("wpn_line2");
		FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("_AutoExposure", 1712f);
		GHMGDBLLEAG.TurnirItem currentTurnir = GameInterface.getI.currentTurnir;
		if (this.AKLCAEAFGPP > 0)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().BMOFIBGMIBK(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().OACLNHIDKIB(1164f, 485f, 196f, 545f, JNBICAJIJMM.OOOKJHOHPNN("wpn_rod1"), true);
		onkdcgnbalk.GENHHJPGOFK = true;
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(1139f, 1900f, 269f, 42f), currentTurnir.turnimage);
		int num = 115;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 1183f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1086f, 1934f, currentTurnir.turnLangName, TextAnchor.LowerLeft, Color.black);
		lcoljopgdll.DFIGKKMMIAF = 35;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont2;
		num += -5;
		string dpanhmgcbnl = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(currentTurnir.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 678f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 896f, 1386f, dpanhmgcbnl, TextAnchor.UpperLeft, new Color(1016f, 264f, 948f));
		lcoljopgdll2.DFIGKKMMIAF = 53;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += -13;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 267f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1682f, onkdcgnbalk.OCHCODJIPHJ.height - (float)num - 267f, 1);
		this.GOHIGLGGDOB = mmkfaenbhkd.LPFKFNLHGBI;
		mmkfaenbhkd.JHNCNHAAJCH = 823f;
		foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh in this.OBPPMLAKFMI)
		{
			mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh);
			dceoccaeleh.onRender = new ItemBase.OOALOMPKIKK(this.KCDIFNBIKKN);
		}
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 917f - 1233f, onkdcgnbalk.OCHCODJIPHJ.height - 1601f, 1721f, 482f, JNBICAJIJMM.DIOJFJMOPJO("Bezier curve must have two or more control points!"), -81, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().ODBGHCIJOHA));
	}

	// Token: 0x06007769 RID: 30569 RVA: 0x0038ED54 File Offset: 0x0038CF54
	public void MJCKIOMLFON(HBPNMNGOFMA KADBECGIMPD)
	{
		if (KADBECGIMPD.LILLHFLDMBH())
		{
			GameInterface.getI.currentTurnir = null;
			Debug.Log("Katana");
			return;
		}
		if (GameInterface.getI.currentTurnir != null)
		{
			GameInterface.getI.currentTurnir.GNFKNBMMCNM(KADBECGIMPD);
		}
		else
		{
			GameInterface.getI.currentTurnir = this.KANMPIBLDLG(KADBECGIMPD);
		}
		GameInterface.getI.currentTurnir.turnLangName = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[GameInterface.getI.currentTurnir.templateID].AGJCPHMJEID;
		if (GameInterface.getI.currentTurnir.turnimage == null || GameInterface.getI.currentTurnir.turnImageRid != GameInterface.getI.currentTurnir.RID)
		{
			CKNLPGEPGGF.IKGFHGKKCPG.MEIFJCHFGHO(string.Format("Invalid ObscuredVector2 index!", IFPIMPMKJIB.EEAKGGDJAGB(), GameInterface.getI.currentTurnir.templateID), new CKNLPGEPGGF.FADFMDIHCIN(GameInterface.getI.currentTurnir.APKPEFHGLCD), true);
		}
		Debug.Log("_FogAlpha");
	}

	// Token: 0x0600776A RID: 30570 RVA: 0x0038EE68 File Offset: 0x0038D068
	public void EBFODNCBFOF()
	{
		Debug.Log("<b>Speed Hack Detector</b>");
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("Mouse Y", 317f);
		GHMGDBLLEAG.TurnirItem currentTurnir = GameInterface.getI.currentTurnir;
		if (this.AKLCAEAFGPP > 1)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().BMOFIBGMIBK(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().HOHNMCIOEOB(1812f, 891f, 1665f, 457f, JNBICAJIJMM.CELEPPAEKAB("Error via final request"), false);
		onkdcgnbalk.GENHHJPGOFK = false;
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(875f, 390f, 262f, 1345f), currentTurnir.turnimage);
		int num = 29;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 1619f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 350f, 20f, currentTurnir.turnLangName, TextAnchor.MiddleLeft, Color.black);
		lcoljopgdll.DFIGKKMMIAF = -122;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		num += 78;
		string dpanhmgcbnl = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(currentTurnir.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1491f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 919f, 10f, dpanhmgcbnl, TextAnchor.UpperLeft, new Color(1050f, 139f, 414f));
		lcoljopgdll2.DFIGKKMMIAF = -8;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += 93;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 803f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 11f, onkdcgnbalk.OCHCODJIPHJ.height - (float)num - 1957f, 1);
		this.GOHIGLGGDOB = mmkfaenbhkd.LPFKFNLHGBI;
		mmkfaenbhkd.JHNCNHAAJCH = 667f;
		foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh in this.OBPPMLAKFMI)
		{
			mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh);
			dceoccaeleh.onRender = new ItemBase.OOALOMPKIKK(this.BDLFIMGDDAP);
		}
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1315f - 361f, onkdcgnbalk.OCHCODJIPHJ.height - 1623f, 1009f, 584f, JNBICAJIJMM.PPNKMDJBMLP("ClimbUp"), -76, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().ODBGHCIJOHA));
	}

	// Token: 0x0600776B RID: 30571 RVA: 0x0038F0E4 File Offset: 0x0038D2E4
	public void KPIJDCNCOGC()
	{
		Debug.Log("/Sound/Music/MusicList.xml");
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("Loot", 459f);
		GHMGDBLLEAG.TurnirItem currentTurnir = GameInterface.getI.currentTurnir;
		if (this.AKLCAEAFGPP > 1)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().DGFAPDDBHJB(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().MBADDJEJANJ(118f, 137f, 1672f, 1743f, JNBICAJIJMM.OOOKJHOHPNN("WATER_REFRACTIVE"), true);
		onkdcgnbalk.GENHHJPGOFK = true;
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(435f, 562f, 841f, 104f), currentTurnir.turnimage);
		int num = 183;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 671f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 338f, 1891f, currentTurnir.turnLangName, TextAnchor.MiddleLeft, Color.black);
		lcoljopgdll.DFIGKKMMIAF = -93;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		num += -76;
		string dpanhmgcbnl = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(currentTurnir.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1334f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 123f, 30f, dpanhmgcbnl, TextAnchor.UpperCenter, new Color(482f, 210f, 1854f));
		lcoljopgdll2.DFIGKKMMIAF = -85;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += -42;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 529f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1297f, onkdcgnbalk.OCHCODJIPHJ.height - (float)num - 776f, 0);
		this.GOHIGLGGDOB = mmkfaenbhkd.LPFKFNLHGBI;
		mmkfaenbhkd.JHNCNHAAJCH = 1054f;
		foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh in this.OBPPMLAKFMI)
		{
			mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh);
			dceoccaeleh.onRender = new ItemBase.OOALOMPKIKK(this.BDLFIMGDDAP);
		}
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1103f - 1204f, onkdcgnbalk.OCHCODJIPHJ.height - 695f, 1313f, 74f, JNBICAJIJMM.CDDCIKKDFMP("wpn_eat4"), -93, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().HMBGLALKHCP));
	}

	// Token: 0x0600776C RID: 30572 RVA: 0x0038F360 File Offset: 0x0038D560
	public void DALLIDDJFGF(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = null;
		GHMGDBLLEAG.TurnirItem turnirItem = this.DMGIELACGLA(KADBECGIMPD);
		this.OBPPMLAKFMI.Clear();
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = new GHMGDBLLEAG.DCEOCCAELEH();
			dceoccaeleh.OCPAHLAGCAI(KADBECGIMPD);
			this.OBPPMLAKFMI.Add(dceoccaeleh);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_TrEndWin.ogg", 1f);
		if (this.AKLCAEAFGPP > 0)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(500f, 500f, JNBICAJIJMM.LEBHCLDODNI("qd_week"), true);
		ONKDCGNBALK onkdcgnbalk2 = onkdcgnbalk;
		onkdcgnbalk2.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y - 80f;
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(1f, 2f, 304f, 150f), turnirItem.turnimage);
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(304f, 2f, 198f, 150f), GameInterface.getI.piedestal);
		int num = 158;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 5f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 10f, 46f, turnirItem.turnLangName, TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll.DFIGKKMMIAF = 24;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		num += 40;
		string dpanhmgcbnl = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(turnirItem.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 5f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 10f, 40f, dpanhmgcbnl, TextAnchor.UpperCenter, new Color(0f, 0.2f, 0.3f));
		lcoljopgdll2.DFIGKKMMIAF = 14;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += 45;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 6f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 12f, onkdcgnbalk.OCHCODJIPHJ.height - (float)num - 60f, 0);
		mmkfaenbhkd.JHNCNHAAJCH = 28f;
		foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh2 in this.OBPPMLAKFMI)
		{
			dceoccaeleh2.onRender = new ItemBase.OOALOMPKIKK(this.IDIJOEBABIA);
			mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh2);
		}
		this.OBPPMLAKFMI.Clear();
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 64f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("cntx_close"), 110, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
	}

	// Token: 0x0600776D RID: 30573 RVA: 0x0038F638 File Offset: 0x0038D838
	public void EIEHOFPGGNP(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = null;
		GHMGDBLLEAG.TurnirItem turnirItem = this.DDKILFDPJNB(KADBECGIMPD);
		this.OBPPMLAKFMI.Clear();
		while (!KADBECGIMPD.JEFMHDJEEJC())
		{
			GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = new GHMGDBLLEAG.DCEOCCAELEH();
			dceoccaeleh.LBINIIGHCMG(KADBECGIMPD);
			this.OBPPMLAKFMI.Add(dceoccaeleh);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("", 853f);
		if (this.AKLCAEAFGPP > 0)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().DGFAPDDBHJB(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().BJFHBPOCELH(1776f, 13f, JNBICAJIJMM.NGALDMFKMJH("LHandPunch"), true);
		ONKDCGNBALK onkdcgnbalk2 = onkdcgnbalk;
		onkdcgnbalk2.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y - 1849f;
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(1507f, 774f, 910f, 848f), turnirItem.turnimage);
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(1026f, 1726f, 313f, 327f), GameInterface.getI.piedestal);
		int num = 100;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 1286f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 287f, 78f, turnirItem.turnLangName, TextAnchor.UpperLeft, Color.black);
		lcoljopgdll.DFIGKKMMIAF = -51;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		num += 89;
		string dpanhmgcbnl = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.FDKEPHNOIFO(turnirItem.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1562f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1632f, 601f, dpanhmgcbnl, TextAnchor.UpperCenter, new Color(1433f, 15f, 1126f));
		lcoljopgdll2.DFIGKKMMIAF = 62;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += 78;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 1987f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1076f, onkdcgnbalk.OCHCODJIPHJ.height - (float)num - 510f, 0);
		mmkfaenbhkd.JHNCNHAAJCH = 1507f;
		foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh2 in this.OBPPMLAKFMI)
		{
			dceoccaeleh2.onRender = new ItemBase.OOALOMPKIKK(this.MEONMGIKDLD);
			mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh2);
		}
		this.OBPPMLAKFMI.Clear();
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 982f - 1913f, onkdcgnbalk.OCHCODJIPHJ.height - 977f, 1786f, 106f, JNBICAJIJMM.LEBHCLDODNI(","), 97, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.ODBGHCIJOHA));
	}

	// Token: 0x0600776E RID: 30574 RVA: 0x0038D3EE File Offset: 0x0038B5EE
	public static GHMGDBLLEAG BPCNCENHEAG()
	{
		if (GHMGDBLLEAG.KFBIDIMHNGF == null)
		{
			GHMGDBLLEAG.KFBIDIMHNGF = new GHMGDBLLEAG();
		}
		return GHMGDBLLEAG.KFBIDIMHNGF;
	}

	// Token: 0x0600776F RID: 30575 RVA: 0x0038F910 File Offset: 0x0038DB10
	public void KCENEMPKKNH(GHMGDBLLEAG.TurnirItem CDBDICLJCEJ)
	{
		Debug.Log("OfficeSittingLegCross");
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("D:/NET_Poligon/ServerPhotonAF2/AFCServer/assets/Data/", 1951f);
		if (this.AKLCAEAFGPP > 1)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().KCNBOHEMLCI(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.CMCDKPPJLNP(1404f, 813f, 1703f, 1088f, JNBICAJIJMM.LEBHCLDODNI("Podsek action 1"), true);
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(34f, 511f, 1295f, 478f), CDBDICLJCEJ.turnimage);
		int num = -154;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 975f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 29f, 1135f, CDBDICLJCEJ.turnLangName, TextAnchor.UpperCenter, Color.black);
		lcoljopgdll.DFIGKKMMIAF = 76;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont2;
		num += -20;
		string dpanhmgcbnl = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(CDBDICLJCEJ.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 423f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1765f, 1402f, dpanhmgcbnl, TextAnchor.UpperCenter, new Color(1513f, 1277f, 89f));
		lcoljopgdll2.DFIGKKMMIAF = -117;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += -36;
		string text = JNBICAJIJMM.LEBHCLDODNI("chatconnecthelp" + CDBDICLJCEJ.state);
		TimeSpan makoioidpjk = DateTime.Now - DateTime.Now;
		if (CDBDICLJCEJ.state == 0)
		{
			makoioidpjk = CDBDICLJCEJ.regTime - DateTime.Now;
		}
		if (CDBDICLJCEJ.state == 0)
		{
			makoioidpjk = CDBDICLJCEJ.startTime - DateTime.Now;
		}
		if (CDBDICLJCEJ.state == 7)
		{
			makoioidpjk = CDBDICLJCEJ.endTime - DateTime.Now;
		}
		text = string.Format(text, JLFJEGIPIMM.MHFDIJGJGBJ().CLDPDFPGMBP(makoioidpjk));
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(onkdcgnbalk, 194f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 800f, 21f, text, TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll3.DFIGKKMMIAF = 10;
		lcoljopgdll3.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += 68;
		int num2 = (int)(CDBDICLJCEJ.endTime - CDBDICLJCEJ.startTime).TotalMinutes;
		LCOLJOPGDLL lcoljopgdll4 = new LCOLJOPGDLL(onkdcgnbalk, 1243f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1335f, 391f, string.Format(JNBICAJIJMM.CDDCIKKDFMP("Leg"), num2), TextAnchor.UpperCenter, Color.black);
		lcoljopgdll4.DFIGKKMMIAF = -2;
		lcoljopgdll4.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += 9;
		LCOLJOPGDLL lcoljopgdll5 = new LCOLJOPGDLL(onkdcgnbalk, 1417f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1941f, 1422f, JNBICAJIJMM.CELEPPAEKAB("_Parameter"), TextAnchor.UpperRight, Color.black);
		lcoljopgdll5.DFIGKKMMIAF = 78;
		lcoljopgdll5.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		num += 29;
		LCOLJOPGDLL lcoljopgdll6 = new LCOLJOPGDLL(onkdcgnbalk, 497f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1083f, 1880f, "http://www.root-motion.com/finalikdox/html/page3.html", TextAnchor.UpperRight, Color.black);
		lcoljopgdll6.DFIGKKMMIAF = 94;
		lcoljopgdll6.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += 114;
		LCOLJOPGDLL lcoljopgdll7 = new LCOLJOPGDLL(onkdcgnbalk, 1535f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1613f, 1002f, string.Format(JNBICAJIJMM.BDKHMOOFHHK("IdleFeedThrow"), CDBDICLJCEJ.prise_1), TextAnchor.UpperRight, Color.black);
		lcoljopgdll7.DFIGKKMMIAF = 45;
		lcoljopgdll7.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont;
		num += -10;
		LCOLJOPGDLL lcoljopgdll8 = new LCOLJOPGDLL(onkdcgnbalk, 1100f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1678f, 209f, string.Format(JNBICAJIJMM.BDKHMOOFHHK("x2"), CDBDICLJCEJ.prise_2), TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll8.DFIGKKMMIAF = 76;
		lcoljopgdll8.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += 21;
		LCOLJOPGDLL lcoljopgdll9 = new LCOLJOPGDLL(onkdcgnbalk, 261f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 455f, 737f, string.Format(JNBICAJIJMM.NGALDMFKMJH(""), CDBDICLJCEJ.prise_3), TextAnchor.UpperCenter, Color.black);
		lcoljopgdll9.DFIGKKMMIAF = -99;
		lcoljopgdll9.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += -116;
		LCOLJOPGDLL lcoljopgdll10 = new LCOLJOPGDLL(onkdcgnbalk, 1335f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 667f, 524f, string.Format(JNBICAJIJMM.NGALDMFKMJH("_SampleMip"), CDBDICLJCEJ.prise_4), TextAnchor.LowerCenter, Color.black);
		lcoljopgdll10.DFIGKKMMIAF = 57;
		lcoljopgdll10.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += 11;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1110f - 919f, onkdcgnbalk.OCHCODJIPHJ.height - 282f, 526f, 1338f, JNBICAJIJMM.DCEBAJIILPC("_FresnelFade"), 90, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().HMBGLALKHCP));
	}

	// Token: 0x06007770 RID: 30576 RVA: 0x0038FE2C File Offset: 0x0038E02C
	private void HEMHICANJIL(ONKDCGNBALK JLEJDINFJOF, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = (GHMGDBLLEAG.DCEOCCAELEH)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -41,
			font = GuiProcessor.IKGFHGKKCPG.rusfont3,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.LowerCenter
		};
		if (dceoccaeleh.MCHIDGLEDID <= -69)
		{
			GUI.color = new Color(813f, 1653f, 318f, 1356f);
			if (dceoccaeleh.MCHIDGLEDID <= 7)
			{
				GUI.color = new Color(1857f, 1775f, 1492f, 315f);
			}
			GUI.DrawTexture(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, OCHCODJIPHJ.width, OCHCODJIPHJ.height - 1691f), GameInterface.getI.simpleGray);
			GUI.color = Color.white;
		}
		Color black = Color.black;
		guistyle.normal.textColor = black;
		guistyle.alignment = TextAnchor.LowerLeft;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		string jipipolkpcf = dceoccaeleh.JIPIPOLKPCF;
		GUI.Label(new Rect(OCHCODJIPHJ.x + 1146f, OCHCODJIPHJ.y, 1141f, OCHCODJIPHJ.height), jipipolkpcf, guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + 1840f + 1525f, OCHCODJIPHJ.y, 43f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
		guistyle.alignment = TextAnchor.UpperRight;
		guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont2;
		guistyle.fontSize = 6;
		GUI.Label(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, 170f, OCHCODJIPHJ.height), string.Concat(dceoccaeleh.MCHIDGLEDID), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + 864f, OCHCODJIPHJ.y, 433f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
		guistyle.fontSize = 32;
		guistyle.alignment = TextAnchor.MiddleLeft;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		GUI.Label(new Rect(OCHCODJIPHJ.x + 1830f, OCHCODJIPHJ.y + 1258f, 726f, OCHCODJIPHJ.height - 1011f), string.Concat(dceoccaeleh.CBJBGGAOODC), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + 215f, OCHCODJIPHJ.y, 1738f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
		guistyle.fontSize = 26;
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		GUI.Label(new Rect(OCHCODJIPHJ.x + 234f, OCHCODJIPHJ.y + 273f, 203f, OCHCODJIPHJ.height - 237f), dceoccaeleh.JNLLLJAADHJ.ToString(), guistyle);
	}

	// Token: 0x06007771 RID: 30577 RVA: 0x00390128 File Offset: 0x0038E328
	private void KCDIFNBIKKN(ONKDCGNBALK JLEJDINFJOF, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = (GHMGDBLLEAG.DCEOCCAELEH)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 125,
			font = GuiProcessor.IKGFHGKKCPG.rusfont3,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.MiddleLeft
		};
		if (dceoccaeleh.MCHIDGLEDID <= 0)
		{
			GUI.color = new Color(1543f, 1905f, 1179f, 299f);
			GUI.DrawTexture(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, OCHCODJIPHJ.width, OCHCODJIPHJ.height - 1665f), GameInterface.getI.simpleGray);
			GUI.color = Color.white;
		}
		Color black = Color.black;
		guistyle.normal.textColor = black;
		guistyle.alignment = TextAnchor.LowerCenter;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		string jipipolkpcf = dceoccaeleh.JIPIPOLKPCF;
		GUI.Label(new Rect(OCHCODJIPHJ.x + 937f, OCHCODJIPHJ.y, OCHCODJIPHJ.width - 1421f, OCHCODJIPHJ.height), jipipolkpcf, guistyle);
		guistyle.alignment = TextAnchor.LowerLeft;
		guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont2;
		guistyle.fontSize = 125;
		GUI.Label(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, 586f, OCHCODJIPHJ.height), string.Concat(dceoccaeleh.MCHIDGLEDID), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + 1207f, OCHCODJIPHJ.y, 1387f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
		guistyle.fontSize = -100;
		guistyle.alignment = TextAnchor.UpperRight;
		guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
		GUI.Label(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 855f, OCHCODJIPHJ.y + 901f, 27f, OCHCODJIPHJ.height - 1159f), string.Concat(dceoccaeleh.CBJBGGAOODC), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 37f, OCHCODJIPHJ.y, 1301f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
	}

	// Token: 0x06007772 RID: 30578 RVA: 0x00390370 File Offset: 0x0038E570
	public void MKEGIENOPCE(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = null;
		GHMGDBLLEAG.TurnirItem turnirItem = this.DDKILFDPJNB(KADBECGIMPD);
		this.OBPPMLAKFMI.Clear();
		while (!KADBECGIMPD.INLBHLOLOJH())
		{
			GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = new GHMGDBLLEAG.DCEOCCAELEH();
			dceoccaeleh.MBJKBKOLBKE(KADBECGIMPD);
			this.OBPPMLAKFMI.Add(dceoccaeleh);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("[weight]", 1226f);
		if (this.AKLCAEAFGPP > 1)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BMOFIBGMIBK(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.DKOFCBMKEPC(1629f, 150f, JNBICAJIJMM.LEBHCLDODNI("RollerBladeFrontFlip"), false);
		ONKDCGNBALK onkdcgnbalk2 = onkdcgnbalk;
		onkdcgnbalk2.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y - 1213f;
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(1661f, 1691f, 15f, 60f), turnirItem.turnimage);
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(235f, 628f, 1143f, 268f), GameInterface.getI.piedestal);
		int num = -174;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 1511f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1794f, 199f, turnirItem.turnLangName, TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll.DFIGKKMMIAF = -67;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		num += -80;
		string dpanhmgcbnl = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(turnirItem.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 776f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1902f, 1836f, dpanhmgcbnl, TextAnchor.UpperCenter, new Color(759f, 1926f, 1373f));
		lcoljopgdll2.DFIGKKMMIAF = 78;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += 122;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 1458f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 539f, onkdcgnbalk.OCHCODJIPHJ.height - (float)num - 1066f, 1);
		mmkfaenbhkd.JHNCNHAAJCH = 1667f;
		foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh2 in this.OBPPMLAKFMI)
		{
			dceoccaeleh2.onRender = new ItemBase.OOALOMPKIKK(this.MEONMGIKDLD);
			mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh2);
		}
		this.OBPPMLAKFMI.Clear();
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 788f - 78f, onkdcgnbalk.OCHCODJIPHJ.height - 1779f, 1072f, 1454f, JNBICAJIJMM.CDDCIKKDFMP("Assets/Heads/head_"), -79, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().HMBGLALKHCP));
	}

	// Token: 0x06007773 RID: 30579 RVA: 0x00390648 File Offset: 0x0038E848
	public void JGEDNAKJCAP(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = this.DMGIELACGLA(KADBECGIMPD);
		this.OBPPMLAKFMI.Clear();
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = new GHMGDBLLEAG.DCEOCCAELEH();
			dceoccaeleh.OCPAHLAGCAI(KADBECGIMPD);
			this.OBPPMLAKFMI.Add(dceoccaeleh);
		}
		if (GameInterface.getI.currentTurnir.state == 2)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(this.AKLCAEAFGPP);
			if (onkdcgnbalk == null)
			{
				return;
			}
			MMKFAENBHKD mmkfaenbhkd = onkdcgnbalk.ADEOBKDFGOP(this.GOHIGLGGDOB) as MMKFAENBHKD;
			if (mmkfaenbhkd != null)
			{
				mmkfaenbhkd.LACAJHOHACK.Clear();
				foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh2 in this.OBPPMLAKFMI)
				{
					dceoccaeleh2.onRender = new ItemBase.OOALOMPKIKK(this.BDLFIMGDDAP);
					mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh2);
				}
			}
		}
		if (GameInterface.getI.currentTurnir.state >= 100)
		{
			GameInterface.getI.currentTurnir = null;
		}
	}

	// Token: 0x06007774 RID: 30580 RVA: 0x0039075C File Offset: 0x0038E95C
	private void PBJOMHHPCCN(ONKDCGNBALK JLEJDINFJOF, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = (GHMGDBLLEAG.DCEOCCAELEH)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 84,
			font = GuiProcessor.BBLINJLBAIL().rusfont3,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.MiddleLeft
		};
		if (dceoccaeleh.MCHIDGLEDID <= 6)
		{
			GUI.color = new Color(993f, 302f, 1559f, 278f);
			GUI.DrawTexture(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, OCHCODJIPHJ.width, OCHCODJIPHJ.height - 1812f), GameInterface.getI.simpleGray);
			GUI.color = Color.white;
		}
		Color black = Color.black;
		guistyle.normal.textColor = black;
		guistyle.alignment = TextAnchor.UpperCenter;
		guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
		string jipipolkpcf = dceoccaeleh.JIPIPOLKPCF;
		GUI.Label(new Rect(OCHCODJIPHJ.x + 1456f, OCHCODJIPHJ.y, OCHCODJIPHJ.width - 496f, OCHCODJIPHJ.height), jipipolkpcf, guistyle);
		guistyle.alignment = TextAnchor.MiddleCenter;
		guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont2;
		guistyle.fontSize = 12;
		GUI.Label(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, 128f, OCHCODJIPHJ.height), string.Concat(dceoccaeleh.MCHIDGLEDID), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + 255f, OCHCODJIPHJ.y, 1309f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
		guistyle.fontSize = -24;
		guistyle.alignment = TextAnchor.MiddleCenter;
		guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont;
		GUI.Label(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 54f, OCHCODJIPHJ.y + 1566f, 309f, OCHCODJIPHJ.height - 1280f), string.Concat(dceoccaeleh.CBJBGGAOODC), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 391f, OCHCODJIPHJ.y, 1345f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
	}

	// Token: 0x06007775 RID: 30581 RVA: 0x003909A4 File Offset: 0x0038EBA4
	public void MLIENFDJKKD(HBPNMNGOFMA KADBECGIMPD)
	{
		GHMGDBLLEAG.TurnirItem turnirItem = this.DMGIELACGLA(KADBECGIMPD);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.PGJCPFNJNPM("SoccerSprint"), turnirItem.turnLangName);
		FlyMessageManager.getI.MEIICCGKONL(iabkgmnjljo, Color.magenta, 0, 0);
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("MotorbikeTurnLeft", 1984f);
		foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.NAFGMKJPLPC)
		{
			oijegjlcfcf.GNEPMCMHDEM = true;
		}
		GameInterface.getI.currentTurnir = null;
	}

	// Token: 0x06007776 RID: 30582 RVA: 0x00390A50 File Offset: 0x0038EC50
	public void LOEAGDFDPEO(GHMGDBLLEAG.TurnirItem CDBDICLJCEJ)
	{
		Debug.Log("RollerBladeGrindRoyale");
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("IdleReadyCrouch", 872f);
		if (this.AKLCAEAFGPP > 0)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().BMOFIBGMIBK(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().IKAKGLAFDGM(1561f, 976f, 487f, 97f, JNBICAJIJMM.LEBHCLDODNI("gi_nl1"), false);
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(1560f, 1753f, 1111f, 1569f), CDBDICLJCEJ.turnimage);
		int num = 32;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 873f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 938f, 1603f, CDBDICLJCEJ.turnLangName, TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll.DFIGKKMMIAF = 121;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		num += -12;
		string dpanhmgcbnl = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.FDKEPHNOIFO(CDBDICLJCEJ.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 994f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1224f, 628f, dpanhmgcbnl, TextAnchor.UpperCenter, new Color(556f, 1701f, 1912f));
		lcoljopgdll2.DFIGKKMMIAF = -123;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += -97;
		string text = JNBICAJIJMM.DCEBAJIILPC("_Amplitude" + CDBDICLJCEJ.state);
		TimeSpan makoioidpjk = DateTime.Now - DateTime.Now;
		if (CDBDICLJCEJ.state == 0)
		{
			makoioidpjk = CDBDICLJCEJ.regTime - DateTime.Now;
		}
		if (CDBDICLJCEJ.state == 1)
		{
			makoioidpjk = CDBDICLJCEJ.startTime - DateTime.Now;
		}
		if (CDBDICLJCEJ.state == 6)
		{
			makoioidpjk = CDBDICLJCEJ.endTime - DateTime.Now;
		}
		text = string.Format(text, JLFJEGIPIMM.PKGMBFEMKGP().CLDPDFPGMBP(makoioidpjk));
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(onkdcgnbalk, 1287f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1803f, 1719f, text, TextAnchor.LowerLeft, Color.black);
		lcoljopgdll3.DFIGKKMMIAF = -107;
		lcoljopgdll3.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont;
		num += -42;
		int num2 = (int)(CDBDICLJCEJ.endTime - CDBDICLJCEJ.startTime).TotalMinutes;
		LCOLJOPGDLL lcoljopgdll4 = new LCOLJOPGDLL(onkdcgnbalk, 1509f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1608f, 1488f, string.Format(JNBICAJIJMM.DIOJFJMOPJO("-STRIKETHROUGH"), num2), TextAnchor.UpperLeft, Color.black);
		lcoljopgdll4.DFIGKKMMIAF = -42;
		lcoljopgdll4.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += -37;
		LCOLJOPGDLL lcoljopgdll5 = new LCOLJOPGDLL(onkdcgnbalk, 1584f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1406f, 753f, JNBICAJIJMM.BDKHMOOFHHK("MotorbikeLassoRight"), TextAnchor.LowerLeft, Color.black);
		lcoljopgdll5.DFIGKKMMIAF = 72;
		lcoljopgdll5.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		num += -126;
		LCOLJOPGDLL lcoljopgdll6 = new LCOLJOPGDLL(onkdcgnbalk, 319f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1006f, 1325f, "fshop_hd4", TextAnchor.UpperCenter, Color.black);
		lcoljopgdll6.DFIGKKMMIAF = -120;
		lcoljopgdll6.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont;
		num += 0;
		LCOLJOPGDLL lcoljopgdll7 = new LCOLJOPGDLL(onkdcgnbalk, 1274f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 574f, 53f, string.Format(JNBICAJIJMM.CDDCIKKDFMP("readSadok error "), CDBDICLJCEJ.prise_1), TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll7.DFIGKKMMIAF = -77;
		lcoljopgdll7.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += -92;
		LCOLJOPGDLL lcoljopgdll8 = new LCOLJOPGDLL(onkdcgnbalk, 1823f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1766f, 1445f, string.Format(JNBICAJIJMM.LEBHCLDODNI(""), CDBDICLJCEJ.prise_2), TextAnchor.MiddleLeft, Color.black);
		lcoljopgdll8.DFIGKKMMIAF = -10;
		lcoljopgdll8.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += 67;
		LCOLJOPGDLL lcoljopgdll9 = new LCOLJOPGDLL(onkdcgnbalk, 338f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1422f, 1890f, string.Format(JNBICAJIJMM.LEBHCLDODNI(""), CDBDICLJCEJ.prise_3), TextAnchor.LowerRight, Color.black);
		lcoljopgdll9.DFIGKKMMIAF = 32;
		lcoljopgdll9.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += -4;
		LCOLJOPGDLL lcoljopgdll10 = new LCOLJOPGDLL(onkdcgnbalk, 295f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1159f, 1702f, string.Format(JNBICAJIJMM.BDKHMOOFHHK("RodParams not found!"), CDBDICLJCEJ.prise_4), TextAnchor.UpperCenter, Color.black);
		lcoljopgdll10.DFIGKKMMIAF = 17;
		lcoljopgdll10.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont;
		num += 19;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 281f - 478f, onkdcgnbalk.OCHCODJIPHJ.height - 428f, 1157f, 104f, JNBICAJIJMM.DIOJFJMOPJO("Mouse X"), -98, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.JFIDAGABKID().BLPLADOIPJG));
	}

	// Token: 0x06007777 RID: 30583 RVA: 0x00390F69 File Offset: 0x0038F169
	public void DLHLJPDINPK(HBPNMNGOFMA KADBECGIMPD)
	{
		this.KANMPIBLDLG(KADBECGIMPD);
	}

	// Token: 0x06007778 RID: 30584 RVA: 0x00390F73 File Offset: 0x0038F173
	public void BLALOJIGPFG(HBPNMNGOFMA KADBECGIMPD)
	{
		this.DDKILFDPJNB(KADBECGIMPD);
	}

	// Token: 0x06007779 RID: 30585 RVA: 0x00390F80 File Offset: 0x0038F180
	private void MEONMGIKDLD(ONKDCGNBALK JLEJDINFJOF, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = (GHMGDBLLEAG.DCEOCCAELEH)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -115,
			font = GuiProcessor.BBLINJLBAIL().rusfont3,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.LowerLeft
		};
		if (dceoccaeleh.MCHIDGLEDID <= 13)
		{
			GUI.color = new Color(743f, 1757f, 1154f, 988f);
			if (dceoccaeleh.MCHIDGLEDID <= 3)
			{
				GUI.color = new Color(840f, 472f, 1936f, 461f);
			}
			GUI.DrawTexture(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, OCHCODJIPHJ.width, OCHCODJIPHJ.height - 1827f), GameInterface.getI.simpleGray);
			GUI.color = Color.white;
		}
		Color black = Color.black;
		guistyle.normal.textColor = black;
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
		string jipipolkpcf = dceoccaeleh.JIPIPOLKPCF;
		GUI.Label(new Rect(OCHCODJIPHJ.x + 4f, OCHCODJIPHJ.y, 1239f, OCHCODJIPHJ.height), jipipolkpcf, guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + 268f + 825f, OCHCODJIPHJ.y, 1157f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
		guistyle.alignment = TextAnchor.LowerLeft;
		guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont2;
		guistyle.fontSize = 95;
		GUI.Label(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, 1144f, OCHCODJIPHJ.height), string.Concat(dceoccaeleh.MCHIDGLEDID), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + 624f, OCHCODJIPHJ.y, 1193f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
		guistyle.fontSize = -121;
		guistyle.alignment = TextAnchor.MiddleLeft;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		GUI.Label(new Rect(OCHCODJIPHJ.x + 1107f, OCHCODJIPHJ.y + 1632f, 1336f, OCHCODJIPHJ.height - 791f), string.Concat(dceoccaeleh.CBJBGGAOODC), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + 381f, OCHCODJIPHJ.y, 282f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
		guistyle.fontSize = -106;
		guistyle.alignment = TextAnchor.LowerCenter;
		guistyle.font = GuiProcessor.PLGADNLAEGN().rusfont;
		GUI.Label(new Rect(OCHCODJIPHJ.x + 194f, OCHCODJIPHJ.y + 21f, 1172f, OCHCODJIPHJ.height - 1068f), dceoccaeleh.JNLLLJAADHJ.ToString(), guistyle);
	}

	// Token: 0x0600777A RID: 30586 RVA: 0x0039127C File Offset: 0x0038F47C
	public void ILEPBFOHDGH(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = null;
		GHMGDBLLEAG.TurnirItem turnirItem = this.EBOCEMMKEPL(KADBECGIMPD);
		this.OBPPMLAKFMI.Clear();
		while (!KADBECGIMPD.INLBHLOLOJH())
		{
			GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = new GHMGDBLLEAG.DCEOCCAELEH();
			dceoccaeleh.KHOPKCFJPBF(KADBECGIMPD);
			this.OBPPMLAKFMI.Add(dceoccaeleh);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB(")", 1624f);
		if (this.AKLCAEAFGPP > 0)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().DGFAPDDBHJB(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().PLHAGCDJLPA(1398f, 826f, JNBICAJIJMM.LEBHCLDODNI("</color>\n"), true);
		ONKDCGNBALK onkdcgnbalk2 = onkdcgnbalk;
		onkdcgnbalk2.OCHCODJIPHJ.y = onkdcgnbalk2.OCHCODJIPHJ.y - 1340f;
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(1018f, 804f, 336f, 1354f), turnirItem.turnimage);
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(543f, 1655f, 1461f, 1888f), GameInterface.getI.piedestal);
		int num = 40;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 1196f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 779f, 1137f, turnirItem.turnLangName, TextAnchor.LowerRight, Color.black);
		lcoljopgdll.DFIGKKMMIAF = 118;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont2;
		num += 6;
		string dpanhmgcbnl = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(turnirItem.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 815f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1466f, 1642f, dpanhmgcbnl, TextAnchor.UpperLeft, new Color(622f, 1528f, 126f));
		lcoljopgdll2.DFIGKKMMIAF = 17;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont;
		num += 112;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 1917f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1761f, onkdcgnbalk.OCHCODJIPHJ.height - (float)num - 681f, 0);
		mmkfaenbhkd.JHNCNHAAJCH = 1498f;
		foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh2 in this.OBPPMLAKFMI)
		{
			dceoccaeleh2.onRender = new ItemBase.OOALOMPKIKK(this.HEMHICANJIL);
			mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh2);
		}
		this.OBPPMLAKFMI.Clear();
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 942f - 1851f, onkdcgnbalk.OCHCODJIPHJ.height - 1633f, 1518f, 1436f, JNBICAJIJMM.NGALDMFKMJH("[ACTk] Obscured Cheating Detector: already running!"), -97, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.AGIEGPEMGOA));
	}

	// Token: 0x0600777B RID: 30587 RVA: 0x00391554 File Offset: 0x0038F754
	public void OCAMPAMMCKM()
	{
		Debug.Log("RollerBladeCrossoverRight");
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("implevel", 988f);
		GHMGDBLLEAG.TurnirItem currentTurnir = GameInterface.getI.currentTurnir;
		if (this.AKLCAEAFGPP > 0)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().KCNBOHEMLCI(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().CADIECCNBKA(49f, 327f, 41f, 455f, JNBICAJIJMM.NGALDMFKMJH("name"), true);
		onkdcgnbalk.GENHHJPGOFK = true;
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(963f, 913f, 1912f, 684f), currentTurnir.turnimage);
		int num = -10;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 46f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1355f, 1356f, currentTurnir.turnLangName, TextAnchor.UpperLeft, Color.black);
		lcoljopgdll.DFIGKKMMIAF = -117;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont2;
		num += 83;
		string dpanhmgcbnl = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.AGOMCKLDHEC(currentTurnir.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 284f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 206f, 1827f, dpanhmgcbnl, TextAnchor.UpperCenter, new Color(66f, 1199f, 319f));
		lcoljopgdll2.DFIGKKMMIAF = -19;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += 121;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 1337f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 883f, onkdcgnbalk.OCHCODJIPHJ.height - (float)num - 969f, 0);
		this.GOHIGLGGDOB = mmkfaenbhkd.LPFKFNLHGBI;
		mmkfaenbhkd.JHNCNHAAJCH = 1210f;
		foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh in this.OBPPMLAKFMI)
		{
			mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh);
			dceoccaeleh.onRender = new ItemBase.OOALOMPKIKK(this.BDLFIMGDDAP);
		}
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1816f - 199f, onkdcgnbalk.OCHCODJIPHJ.height - 1583f, 1009f, 750f, JNBICAJIJMM.DCEBAJIILPC("Save"), 6, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().AGIEGPEMGOA));
	}

	// Token: 0x0600777C RID: 30588 RVA: 0x003917D0 File Offset: 0x0038F9D0
	public void GANPECIMCHC(GHMGDBLLEAG.TurnirItem CDBDICLJCEJ)
	{
		Debug.Log("https://www.youtube.com/watch?v=r5jiZnsDH3M");
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("MotorbikeLookBack", 1297f);
		if (this.AKLCAEAFGPP > 0)
		{
			JDCEFOFMGHB.JFIDAGABKID().CBHHEHHNFKL(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().OACLNHIDKIB(605f, 1991f, 213f, 596f, JNBICAJIJMM.DIOJFJMOPJO("BEREG!"), false);
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(816f, 766f, 599f, 1799f), CDBDICLJCEJ.turnimage);
		int num = -143;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 670f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1403f, 211f, CDBDICLJCEJ.turnLangName, TextAnchor.UpperRight, Color.black);
		lcoljopgdll.DFIGKKMMIAF = 4;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		num += 15;
		string dpanhmgcbnl = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.FDKEPHNOIFO(CDBDICLJCEJ.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1516f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 748f, 1909f, dpanhmgcbnl, TextAnchor.UpperCenter, new Color(670f, 359f, 1702f));
		lcoljopgdll2.DFIGKKMMIAF = 19;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += 20;
		string text = JNBICAJIJMM.DCEBAJIILPC("BackPackSearch" + CDBDICLJCEJ.state);
		TimeSpan makoioidpjk = DateTime.Now - DateTime.Now;
		if (CDBDICLJCEJ.state == 0)
		{
			makoioidpjk = CDBDICLJCEJ.regTime - DateTime.Now;
		}
		if (CDBDICLJCEJ.state == 0)
		{
			makoioidpjk = CDBDICLJCEJ.startTime - DateTime.Now;
		}
		if (CDBDICLJCEJ.state == 1)
		{
			makoioidpjk = CDBDICLJCEJ.endTime - DateTime.Now;
		}
		text = string.Format(text, JLFJEGIPIMM.MHFDIJGJGBJ().CLDPDFPGMBP(makoioidpjk));
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(onkdcgnbalk, 408f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 380f, 703f, text, TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll3.DFIGKKMMIAF = 51;
		lcoljopgdll3.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont;
		num += -121;
		int num2 = (int)(CDBDICLJCEJ.endTime - CDBDICLJCEJ.startTime).TotalMinutes;
		LCOLJOPGDLL lcoljopgdll4 = new LCOLJOPGDLL(onkdcgnbalk, 571f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 568f, 483f, string.Format(JNBICAJIJMM.OOOKJHOHPNN("Player Instaniate "), num2), TextAnchor.LowerLeft, Color.black);
		lcoljopgdll4.DFIGKKMMIAF = -125;
		lcoljopgdll4.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += 47;
		LCOLJOPGDLL lcoljopgdll5 = new LCOLJOPGDLL(onkdcgnbalk, 1778f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 132f, 3f, JNBICAJIJMM.LEBHCLDODNI("[maxcnt]"), TextAnchor.UpperRight, Color.black);
		lcoljopgdll5.DFIGKKMMIAF = -23;
		lcoljopgdll5.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		num += -23;
		LCOLJOPGDLL lcoljopgdll6 = new LCOLJOPGDLL(onkdcgnbalk, 101f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 728f, 255f, "_NoiseTex", TextAnchor.LowerLeft, Color.black);
		lcoljopgdll6.DFIGKKMMIAF = -81;
		lcoljopgdll6.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont;
		num += 119;
		LCOLJOPGDLL lcoljopgdll7 = new LCOLJOPGDLL(onkdcgnbalk, 1631f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 511f, 1445f, string.Format(JNBICAJIJMM.DCEBAJIILPC("error: already initialized"), CDBDICLJCEJ.prise_1), TextAnchor.UpperRight, Color.black);
		lcoljopgdll7.DFIGKKMMIAF = 116;
		lcoljopgdll7.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += -84;
		LCOLJOPGDLL lcoljopgdll8 = new LCOLJOPGDLL(onkdcgnbalk, 191f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1419f, 1583f, string.Format(JNBICAJIJMM.OOOKJHOHPNN("IKMappingSpine does not contain any nodes."), CDBDICLJCEJ.prise_2), TextAnchor.UpperLeft, Color.black);
		lcoljopgdll8.DFIGKKMMIAF = -109;
		lcoljopgdll8.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += -119;
		LCOLJOPGDLL lcoljopgdll9 = new LCOLJOPGDLL(onkdcgnbalk, 465f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 634f, 325f, string.Format(JNBICAJIJMM.OOOKJHOHPNN("newHour"), CDBDICLJCEJ.prise_3), TextAnchor.LowerRight, Color.black);
		lcoljopgdll9.DFIGKKMMIAF = -74;
		lcoljopgdll9.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += -14;
		LCOLJOPGDLL lcoljopgdll10 = new LCOLJOPGDLL(onkdcgnbalk, 227f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1698f, 1742f, string.Format(JNBICAJIJMM.LEBHCLDODNI("TOD_MoonDirection"), CDBDICLJCEJ.prise_4), TextAnchor.LowerLeft, Color.black);
		lcoljopgdll10.DFIGKKMMIAF = -118;
		lcoljopgdll10.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += -88;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1679f - 124f, onkdcgnbalk.OCHCODJIPHJ.height - 1104f, 1525f, 1027f, JNBICAJIJMM.CELEPPAEKAB("Cheer Jump"), -8, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().IBCKNOEANLN));
	}

	// Token: 0x0600777D RID: 30589 RVA: 0x00391CEC File Offset: 0x0038FEEC
	public void NCELHNMLLIB()
	{
		Debug.Log("_HitPosition");
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("help", 138f);
		GHMGDBLLEAG.TurnirItem currentTurnir = GameInterface.getI.currentTurnir;
		if (this.AKLCAEAFGPP > 1)
		{
			JDCEFOFMGHB.JFIDAGABKID().KCNBOHEMLCI(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().IKAKGLAFDGM(644f, 1473f, 1140f, 1789f, JNBICAJIJMM.PPNKMDJBMLP("Low adminlevel!"), false);
		onkdcgnbalk.GENHHJPGOFK = false;
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(990f, 631f, 297f, 1031f), currentTurnir.turnimage);
		int num = 190;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 1289f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 88f, 88f, currentTurnir.turnLangName, TextAnchor.UpperLeft, Color.black);
		lcoljopgdll.DFIGKKMMIAF = 29;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		num += -128;
		string dpanhmgcbnl = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(currentTurnir.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1546f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1284f, 1317f, dpanhmgcbnl, TextAnchor.UpperLeft, new Color(755f, 1159f, 336f));
		lcoljopgdll2.DFIGKKMMIAF = 96;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += -72;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 1540f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 277f, onkdcgnbalk.OCHCODJIPHJ.height - (float)num - 479f, 0);
		this.GOHIGLGGDOB = mmkfaenbhkd.LPFKFNLHGBI;
		mmkfaenbhkd.JHNCNHAAJCH = 1555f;
		foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh in this.OBPPMLAKFMI)
		{
			mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh);
			dceoccaeleh.onRender = new ItemBase.OOALOMPKIKK(this.BDHANEHEMLO);
		}
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 995f - 993f, onkdcgnbalk.OCHCODJIPHJ.height - 488f, 1962f, 473f, JNBICAJIJMM.DIOJFJMOPJO("C "), -39, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().AGIEGPEMGOA));
	}

	// Token: 0x0600777E RID: 30590 RVA: 0x0038D3EE File Offset: 0x0038B5EE
	public static GHMGDBLLEAG GALDNPBIINC()
	{
		if (GHMGDBLLEAG.KFBIDIMHNGF == null)
		{
			GHMGDBLLEAG.KFBIDIMHNGF = new GHMGDBLLEAG();
		}
		return GHMGDBLLEAG.KFBIDIMHNGF;
	}

	// Token: 0x0600777F RID: 30591 RVA: 0x00391F68 File Offset: 0x00390168
	public void PFBCPPFPPFO(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = this.EBOCEMMKEPL(KADBECGIMPD);
		this.OBPPMLAKFMI.Clear();
		while (!KADBECGIMPD.KFKIFJDHCHB())
		{
			GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = new GHMGDBLLEAG.DCEOCCAELEH();
			dceoccaeleh.ODAFODFACKN(KADBECGIMPD);
			this.OBPPMLAKFMI.Add(dceoccaeleh);
		}
		if (GameInterface.getI.currentTurnir.state == 1)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().HPCEJKFHNBA(this.AKLCAEAFGPP);
			if (onkdcgnbalk == null)
			{
				return;
			}
			MMKFAENBHKD mmkfaenbhkd = onkdcgnbalk.ADEOBKDFGOP(this.GOHIGLGGDOB) as MMKFAENBHKD;
			if (mmkfaenbhkd != null)
			{
				mmkfaenbhkd.LACAJHOHACK.Clear();
				foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh2 in this.OBPPMLAKFMI)
				{
					dceoccaeleh2.onRender = new ItemBase.OOALOMPKIKK(this.BDLFIMGDDAP);
					mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh2);
				}
			}
		}
		if (GameInterface.getI.currentTurnir.state >= -88)
		{
			GameInterface.getI.currentTurnir = null;
		}
	}

	// Token: 0x06007780 RID: 30592 RVA: 0x0039207C File Offset: 0x0039027C
	public void ECIDEOPOJDP(HBPNMNGOFMA KADBECGIMPD)
	{
		if (KADBECGIMPD.HKBFCJDJCOB())
		{
			GameInterface.getI.currentTurnir = null;
			Debug.Log("fider_Empty.ogg");
			return;
		}
		if (GameInterface.getI.currentTurnir != null)
		{
			GameInterface.getI.currentTurnir.GNFKNBMMCNM(KADBECGIMPD);
		}
		else
		{
			GameInterface.getI.currentTurnir = this.ANAALPNPIGN(KADBECGIMPD);
		}
		GameInterface.getI.currentTurnir.turnLangName = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[GameInterface.getI.currentTurnir.templateID].AGJCPHMJEID;
		if (GameInterface.getI.currentTurnir.turnimage == null || GameInterface.getI.currentTurnir.turnImageRid != GameInterface.getI.currentTurnir.RID)
		{
			CKNLPGEPGGF.PFOLNEGNIPP().PPMAFOGDGAK(string.Format("#80ff00", IFPIMPMKJIB.ENLHJOJICDG(), GameInterface.getI.currentTurnir.templateID), new CKNLPGEPGGF.FADFMDIHCIN(GameInterface.getI.currentTurnir.JGDHJBLKKDB), true);
		}
		Debug.Log("Mouse Y");
	}

	// Token: 0x06007781 RID: 30593 RVA: 0x0038D3EE File Offset: 0x0038B5EE
	public static GHMGDBLLEAG NPCAKEGNBHD()
	{
		if (GHMGDBLLEAG.KFBIDIMHNGF == null)
		{
			GHMGDBLLEAG.KFBIDIMHNGF = new GHMGDBLLEAG();
		}
		return GHMGDBLLEAG.KFBIDIMHNGF;
	}

	// Token: 0x06007782 RID: 30594 RVA: 0x00392190 File Offset: 0x00390390
	private void BDLFIMGDDAP(ONKDCGNBALK JLEJDINFJOF, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = (GHMGDBLLEAG.DCEOCCAELEH)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 13,
			font = GuiProcessor.IKGFHGKKCPG.rusfont3,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperRight
		};
		if (dceoccaeleh.MCHIDGLEDID <= 3)
		{
			GUI.color = new Color(0.8f, 1f, 0.8f, 0.5f);
			GUI.DrawTexture(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, OCHCODJIPHJ.width, OCHCODJIPHJ.height - 1f), GameInterface.getI.simpleGray);
			GUI.color = Color.white;
		}
		Color black = Color.black;
		guistyle.normal.textColor = black;
		guistyle.alignment = TextAnchor.MiddleLeft;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		string jipipolkpcf = dceoccaeleh.JIPIPOLKPCF;
		GUI.Label(new Rect(OCHCODJIPHJ.x + 52f, OCHCODJIPHJ.y, OCHCODJIPHJ.width - 64f, OCHCODJIPHJ.height), jipipolkpcf, guistyle);
		guistyle.alignment = TextAnchor.MiddleCenter;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont2;
		guistyle.fontSize = 22;
		GUI.Label(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, 28f, OCHCODJIPHJ.height), string.Concat(dceoccaeleh.MCHIDGLEDID), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + 30f, OCHCODJIPHJ.y, 6f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
		guistyle.fontSize = 14;
		guistyle.alignment = TextAnchor.MiddleRight;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		GUI.Label(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 80f, OCHCODJIPHJ.y + 2f, 70f, OCHCODJIPHJ.height - 2f), string.Concat(dceoccaeleh.CBJBGGAOODC), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 88f, OCHCODJIPHJ.y, 6f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
	}

	// Token: 0x06007783 RID: 30595 RVA: 0x003923D8 File Offset: 0x003905D8
	private GHMGDBLLEAG.TurnirItem KANMPIBLDLG(HBPNMNGOFMA KADBECGIMPD)
	{
		GHMGDBLLEAG.TurnirItem turnirItem = new GHMGDBLLEAG.TurnirItem(KADBECGIMPD);
		turnirItem.turnLangName = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[turnirItem.templateID].AGJCPHMJEID;
		CKNLPGEPGGF.IKGFHGKKCPG.PPMAFOGDGAK(string.Format("RollerBladeStand", IFPIMPMKJIB.LCEBBHPKOHO(), turnirItem.templateID), new CKNLPGEPGGF.FADFMDIHCIN(turnirItem.APKPEFHGLCD), false);
		return turnirItem;
	}

	// Token: 0x06007784 RID: 30596 RVA: 0x0038D3EE File Offset: 0x0038B5EE
	public static GHMGDBLLEAG MJMIPFAINJP()
	{
		if (GHMGDBLLEAG.KFBIDIMHNGF == null)
		{
			GHMGDBLLEAG.KFBIDIMHNGF = new GHMGDBLLEAG();
		}
		return GHMGDBLLEAG.KFBIDIMHNGF;
	}

	// Token: 0x06007785 RID: 30597 RVA: 0x0038D3EE File Offset: 0x0038B5EE
	public static GHMGDBLLEAG BOBNPEAEECC()
	{
		if (GHMGDBLLEAG.KFBIDIMHNGF == null)
		{
			GHMGDBLLEAG.KFBIDIMHNGF = new GHMGDBLLEAG();
		}
		return GHMGDBLLEAG.KFBIDIMHNGF;
	}

	// Token: 0x06007786 RID: 30598 RVA: 0x00392448 File Offset: 0x00390648
	private GHMGDBLLEAG.TurnirItem ANAALPNPIGN(HBPNMNGOFMA KADBECGIMPD)
	{
		GHMGDBLLEAG.TurnirItem turnirItem = new GHMGDBLLEAG.TurnirItem(KADBECGIMPD);
		turnirItem.turnLangName = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[turnirItem.templateID].AGJCPHMJEID;
		CKNLPGEPGGF.IKGFHGKKCPG.MEIFJCHFGHO(string.Format("_dev007", IFPIMPMKJIB.ENLHJOJICDG(), turnirItem.templateID), new CKNLPGEPGGF.FADFMDIHCIN(turnirItem.JGDHJBLKKDB), true);
		return turnirItem;
	}

	// Token: 0x06007787 RID: 30599 RVA: 0x003924B8 File Offset: 0x003906B8
	public void GOGGIFIOONC()
	{
		Debug.Log("SOURCE_GBUFFER");
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("wpn_eat4", 713f);
		GHMGDBLLEAG.TurnirItem currentTurnir = GameInterface.getI.currentTurnir;
		if (this.AKLCAEAFGPP > 0)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().BMOFIBGMIBK(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().CADIECCNBKA(175f, 1476f, 958f, 296f, JNBICAJIJMM.NGALDMFKMJH("_ScratchTex"), false);
		onkdcgnbalk.GENHHJPGOFK = true;
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(130f, 1305f, 1125f, 1672f), currentTurnir.turnimage);
		int num = -32;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 1610f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 859f, 1791f, currentTurnir.turnLangName, TextAnchor.MiddleLeft, Color.black);
		lcoljopgdll.DFIGKKMMIAF = -33;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		num += -102;
		string dpanhmgcbnl = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.FDKEPHNOIFO(currentTurnir.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1299f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1853f, 141f, dpanhmgcbnl, TextAnchor.UpperLeft, new Color(1852f, 142f, 413f));
		lcoljopgdll2.DFIGKKMMIAF = 113;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont;
		num += 31;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 492f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1645f, onkdcgnbalk.OCHCODJIPHJ.height - (float)num - 1109f, 0);
		this.GOHIGLGGDOB = mmkfaenbhkd.LPFKFNLHGBI;
		mmkfaenbhkd.JHNCNHAAJCH = 866f;
		foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh in this.OBPPMLAKFMI)
		{
			mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh);
			dceoccaeleh.onRender = new ItemBase.OOALOMPKIKK(this.PBJOMHHPCCN);
		}
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1759f - 279f, onkdcgnbalk.OCHCODJIPHJ.height - 1720f, 1891f, 554f, JNBICAJIJMM.CELEPPAEKAB(" rep.repa="), -48, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.IBCKNOEANLN));
	}

	// Token: 0x06007788 RID: 30600 RVA: 0x00392734 File Offset: 0x00390934
	private void BDHANEHEMLO(ONKDCGNBALK JLEJDINFJOF, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = (GHMGDBLLEAG.DCEOCCAELEH)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 33,
			font = GuiProcessor.BBLINJLBAIL().rusfont3,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperCenter
		};
		if (dceoccaeleh.MCHIDGLEDID <= 6)
		{
			GUI.color = new Color(255f, 152f, 1050f, 212f);
			GUI.DrawTexture(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, OCHCODJIPHJ.width, OCHCODJIPHJ.height - 1565f), GameInterface.getI.simpleGray);
			GUI.color = Color.white;
		}
		Color black = Color.black;
		guistyle.normal.textColor = black;
		guistyle.alignment = TextAnchor.UpperRight;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		string jipipolkpcf = dceoccaeleh.JIPIPOLKPCF;
		GUI.Label(new Rect(OCHCODJIPHJ.x + 563f, OCHCODJIPHJ.y, OCHCODJIPHJ.width - 782f, OCHCODJIPHJ.height), jipipolkpcf, guistyle);
		guistyle.alignment = TextAnchor.MiddleCenter;
		guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont2;
		guistyle.fontSize = -120;
		GUI.Label(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, 260f, OCHCODJIPHJ.height), string.Concat(dceoccaeleh.MCHIDGLEDID), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + 841f, OCHCODJIPHJ.y, 135f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
		guistyle.fontSize = -80;
		guistyle.alignment = TextAnchor.LowerRight;
		guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
		GUI.Label(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 290f, OCHCODJIPHJ.y + 80f, 1944f, OCHCODJIPHJ.height - 1036f), string.Concat(dceoccaeleh.CBJBGGAOODC), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 1474f, OCHCODJIPHJ.y, 1135f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
	}

	// Token: 0x0600778A RID: 30602 RVA: 0x0039299B File Offset: 0x00390B9B
	public void NHFEBDABANM(HBPNMNGOFMA KADBECGIMPD)
	{
		this.EBOCEMMKEPL(KADBECGIMPD);
	}

	// Token: 0x0600778B RID: 30603 RVA: 0x003929A8 File Offset: 0x00390BA8
	public void BJPAAELJBEN(HBPNMNGOFMA KADBECGIMPD)
	{
		if (KADBECGIMPD.ODIBHLOAGBC())
		{
			GameInterface.getI.currentTurnir = null;
			Debug.Log("MotorbikeShootBack");
			return;
		}
		if (GameInterface.getI.currentTurnir != null)
		{
			GameInterface.getI.currentTurnir.OCPAHLAGCAI(KADBECGIMPD);
		}
		else
		{
			GameInterface.getI.currentTurnir = this.DDKILFDPJNB(KADBECGIMPD);
		}
		GameInterface.getI.currentTurnir.turnLangName = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[GameInterface.getI.currentTurnir.templateID].AGJCPHMJEID;
		if (GameInterface.getI.currentTurnir.turnimage == null || GameInterface.getI.currentTurnir.turnImageRid != GameInterface.getI.currentTurnir.RID)
		{
			CKNLPGEPGGF.IKGFHGKKCPG.MEIFJCHFGHO(string.Format("knopje.wav", IFPIMPMKJIB.NEJIPLDOMMC(), GameInterface.getI.currentTurnir.templateID), new CKNLPGEPGGF.FADFMDIHCIN(GameInterface.getI.currentTurnir.FPGIOBCEIPG), false);
		}
		Debug.Log("Bow Idle");
	}

	// Token: 0x0600778C RID: 30604 RVA: 0x0039299B File Offset: 0x00390B9B
	public void KEJGDPNAFPH(HBPNMNGOFMA KADBECGIMPD)
	{
		this.EBOCEMMKEPL(KADBECGIMPD);
	}

	// Token: 0x0600778D RID: 30605 RVA: 0x00392ABC File Offset: 0x00390CBC
	public void EOLJCBIMFDK(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = this.DDKILFDPJNB(KADBECGIMPD);
		string.Format(JNBICAJIJMM.DIOJFJMOPJO("UnityEngine.Color"), GameInterface.getI.currentTurnir.turnLangName);
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x0600778E RID: 30606 RVA: 0x0038D3EE File Offset: 0x0038B5EE
	public static GHMGDBLLEAG IKGFHGKKCPG
	{
		get
		{
			if (GHMGDBLLEAG.KFBIDIMHNGF == null)
			{
				GHMGDBLLEAG.KFBIDIMHNGF = new GHMGDBLLEAG();
			}
			return GHMGDBLLEAG.KFBIDIMHNGF;
		}
	}

	// Token: 0x0600778F RID: 30607 RVA: 0x00392AF0 File Offset: 0x00390CF0
	public void CADOIDFCPJP()
	{
		Debug.Log("WpnLang.xml");
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("_camIntensive", 775f);
		GHMGDBLLEAG.TurnirItem currentTurnir = GameInterface.getI.currentTurnir;
		if (this.AKLCAEAFGPP > 0)
		{
			JDCEFOFMGHB.JFIDAGABKID().BMOFIBGMIBK(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().HOHNMCIOEOB(488f, 1980f, 1584f, 1435f, JNBICAJIJMM.NGALDMFKMJH("Sitting Reading"), false);
		onkdcgnbalk.GENHHJPGOFK = false;
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(32f, 979f, 1415f, 350f), currentTurnir.turnimage);
		int num = -199;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 727f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1265f, 1128f, currentTurnir.turnLangName, TextAnchor.LowerLeft, Color.black);
		lcoljopgdll.DFIGKKMMIAF = 36;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont2;
		num += 2;
		string dpanhmgcbnl = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(currentTurnir.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 314f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 663f, 1258f, dpanhmgcbnl, TextAnchor.UpperCenter, new Color(1305f, 1987f, 1492f));
		lcoljopgdll2.DFIGKKMMIAF = -125;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += 87;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 825f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1211f, onkdcgnbalk.OCHCODJIPHJ.height - (float)num - 654f, 1);
		this.GOHIGLGGDOB = mmkfaenbhkd.LPFKFNLHGBI;
		mmkfaenbhkd.JHNCNHAAJCH = 833f;
		foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh in this.OBPPMLAKFMI)
		{
			mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh);
			dceoccaeleh.onRender = new ItemBase.OOALOMPKIKK(this.BDLFIMGDDAP);
		}
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1924f - 1640f, onkdcgnbalk.OCHCODJIPHJ.height - 650f, 1171f, 697f, JNBICAJIJMM.PGJCPFNJNPM("invn_rec19"), -95, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().BLPLADOIPJG));
	}

	// Token: 0x06007790 RID: 30608 RVA: 0x00392D6C File Offset: 0x00390F6C
	public void JLOHCGNILNC(HBPNMNGOFMA KADBECGIMPD)
	{
		if (KADBECGIMPD.JCEGOADAOOI)
		{
			GameInterface.getI.currentTurnir = null;
			Debug.Log("NO TURN");
			return;
		}
		if (GameInterface.getI.currentTurnir != null)
		{
			GameInterface.getI.currentTurnir.OCPAHLAGCAI(KADBECGIMPD);
		}
		else
		{
			GameInterface.getI.currentTurnir = this.DMGIELACGLA(KADBECGIMPD);
		}
		GameInterface.getI.currentTurnir.turnLangName = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[GameInterface.getI.currentTurnir.templateID].AGJCPHMJEID;
		if (GameInterface.getI.currentTurnir.turnimage == null || GameInterface.getI.currentTurnir.turnImageRid != GameInterface.getI.currentTurnir.RID)
		{
			CKNLPGEPGGF.IKGFHGKKCPG.PPMAFOGDGAK(string.Format("{0}Textures/Turnirs/{1}.png", IFPIMPMKJIB.DIDFMAELMJD, GameInterface.getI.currentTurnir.templateID), new CKNLPGEPGGF.FADFMDIHCIN(GameInterface.getI.currentTurnir.JGDHJBLKKDB), false);
		}
		Debug.Log("readTurnir STATUS");
	}

	// Token: 0x06007791 RID: 30609 RVA: 0x00392E80 File Offset: 0x00391080
	public void IAJHBKIFNFJ(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = this.EBOCEMMKEPL(KADBECGIMPD);
		string.Format(JNBICAJIJMM.PPNKMDJBMLP("WeaponStrafeRunLeft"), GameInterface.getI.currentTurnir.turnLangName);
	}

	// Token: 0x06007792 RID: 30610 RVA: 0x00392EB4 File Offset: 0x003910B4
	public void HAPLHOHNOLM(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = this.ANAALPNPIGN(KADBECGIMPD);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.NGALDMFKMJH("FactoryTempTexture"), GameInterface.getI.currentTurnir.turnLangName);
		FlyMessageManager.getI.KICLBJKBFNO(iabkgmnjljo, Color.magenta, 0, 1);
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("Kernel", 857f);
	}

	// Token: 0x06007793 RID: 30611 RVA: 0x00392F18 File Offset: 0x00391118
	public void FIFJCHFDEEF(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = this.ANAALPNPIGN(KADBECGIMPD);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.DIOJFJMOPJO("newHour"), GameInterface.getI.currentTurnir.turnLangName);
		FlyMessageManager.getI.JBBCOOMCOII(iabkgmnjljo, Color.magenta, 0, 0);
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("IdleRun", 952f);
	}

	// Token: 0x06007794 RID: 30612 RVA: 0x0038D3EE File Offset: 0x0038B5EE
	public static GHMGDBLLEAG EEOPOHEALPK()
	{
		if (GHMGDBLLEAG.KFBIDIMHNGF == null)
		{
			GHMGDBLLEAG.KFBIDIMHNGF = new GHMGDBLLEAG();
		}
		return GHMGDBLLEAG.KFBIDIMHNGF;
	}

	// Token: 0x06007795 RID: 30613 RVA: 0x00392F7C File Offset: 0x0039117C
	public void HHLDCFFDOGO(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = this.JHGBPCOILPA(KADBECGIMPD);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.LEBHCLDODNI("SexyDance2"), GameInterface.getI.currentTurnir.turnLangName);
		FlyMessageManager.getI.KICLBJKBFNO(iabkgmnjljo, Color.magenta, 0, 0);
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("Mouse X", 1735f);
	}

	// Token: 0x06007796 RID: 30614 RVA: 0x00392FE0 File Offset: 0x003911E0
	public void FILKDFIOCBE(HBPNMNGOFMA KADBECGIMPD)
	{
		if (KADBECGIMPD.INLBHLOLOJH())
		{
			GameInterface.getI.currentTurnir = null;
			Debug.Log("_Params1");
			return;
		}
		if (GameInterface.getI.currentTurnir != null)
		{
			GameInterface.getI.currentTurnir.MONADJLANAE(KADBECGIMPD);
		}
		else
		{
			GameInterface.getI.currentTurnir = this.DDKILFDPJNB(KADBECGIMPD);
		}
		GameInterface.getI.currentTurnir.turnLangName = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[GameInterface.getI.currentTurnir.templateID].AGJCPHMJEID;
		if (GameInterface.getI.currentTurnir.turnimage == null || GameInterface.getI.currentTurnir.turnImageRid != GameInterface.getI.currentTurnir.RID)
		{
			CKNLPGEPGGF.PFOLNEGNIPP().MEIFJCHFGHO(string.Format("crft_from", IFPIMPMKJIB.EHCJCCILAHM(), GameInterface.getI.currentTurnir.templateID), new CKNLPGEPGGF.FADFMDIHCIN(GameInterface.getI.currentTurnir.JGDHJBLKKDB), true);
		}
		Debug.Log("pempty");
	}

	// Token: 0x06007797 RID: 30615 RVA: 0x003930F4 File Offset: 0x003912F4
	private void OLBHIGIMLDN(ONKDCGNBALK JLEJDINFJOF, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = (GHMGDBLLEAG.DCEOCCAELEH)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 109,
			font = GuiProcessor.IKGFHGKKCPG.rusfont3,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.LowerRight
		};
		if (dceoccaeleh.MCHIDGLEDID <= 2)
		{
			GUI.color = new Color(1032f, 1481f, 1289f, 130f);
			GUI.DrawTexture(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, OCHCODJIPHJ.width, OCHCODJIPHJ.height - 1360f), GameInterface.getI.simpleGray);
			GUI.color = Color.white;
		}
		Color black = Color.black;
		guistyle.normal.textColor = black;
		guistyle.alignment = TextAnchor.LowerCenter;
		guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
		string jipipolkpcf = dceoccaeleh.JIPIPOLKPCF;
		GUI.Label(new Rect(OCHCODJIPHJ.x + 569f, OCHCODJIPHJ.y, OCHCODJIPHJ.width - 1331f, OCHCODJIPHJ.height), jipipolkpcf, guistyle);
		guistyle.alignment = TextAnchor.MiddleRight;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont2;
		guistyle.fontSize = -25;
		GUI.Label(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, 1976f, OCHCODJIPHJ.height), string.Concat(dceoccaeleh.MCHIDGLEDID), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + 724f, OCHCODJIPHJ.y, 265f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
		guistyle.fontSize = 6;
		guistyle.alignment = TextAnchor.LowerLeft;
		guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
		GUI.Label(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 1651f, OCHCODJIPHJ.y + 80f, 485f, OCHCODJIPHJ.height - 346f), string.Concat(dceoccaeleh.CBJBGGAOODC), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 987f, OCHCODJIPHJ.y, 242f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
	}

	// Token: 0x06007798 RID: 30616 RVA: 0x0039333C File Offset: 0x0039153C
	public void FPFBHMAIPBC(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = this.DMGIELACGLA(KADBECGIMPD);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.PGJCPFNJNPM("UNDISTORT"), GameInterface.getI.currentTurnir.turnLangName);
		FlyMessageManager.getI.IDCGMMOMKPM(iabkgmnjljo, Color.magenta, 0, 0);
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("1HandSwordShieldBash", 801f);
	}

	// Token: 0x06007799 RID: 30617 RVA: 0x003933A0 File Offset: 0x003915A0
	public void BGOBGAOKDGA(HBPNMNGOFMA KADBECGIMPD)
	{
		GHMGDBLLEAG.TurnirItem turnirItem = this.DDKILFDPJNB(KADBECGIMPD);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.OOOKJHOHPNN(" is represented multiple times in the Bones."), turnirItem.turnLangName);
		FlyMessageManager.getI.FDHDJFEIOMG(iabkgmnjljo, Color.magenta, 1, 1);
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("Staff Stand", 576f);
		foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.NAFGMKJPLPC)
		{
			oijegjlcfcf.GNEPMCMHDEM = false;
		}
		GameInterface.getI.currentTurnir = null;
	}

	// Token: 0x0600779A RID: 30618 RVA: 0x0039344C File Offset: 0x0039164C
	public void COIGCDLGJLM(HBPNMNGOFMA KADBECGIMPD)
	{
		this.DMGIELACGLA(KADBECGIMPD);
	}

	// Token: 0x0600779B RID: 30619 RVA: 0x00393456 File Offset: 0x00391656
	public void GEPJKICLINO(HBPNMNGOFMA KADBECGIMPD)
	{
		this.JHGBPCOILPA(KADBECGIMPD);
	}

	// Token: 0x0600779C RID: 30620 RVA: 0x00393460 File Offset: 0x00391660
	public void AIOPMEMEBHI(GHMGDBLLEAG.TurnirItem CDBDICLJCEJ)
	{
		Debug.Log("Open openTurnirWindow");
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("drag_onmousedown.wav", 1f);
		if (this.AKLCAEAFGPP > 0)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.HOHNMCIOEOB(10f, 220f, 308f, 450f, JNBICAJIJMM.LEBHCLDODNI("qd_week"), true);
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(1f, 2f, 304f, 150f), CDBDICLJCEJ.turnimage);
		int num = 156;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 5f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 10f, 40f, CDBDICLJCEJ.turnLangName, TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll.DFIGKKMMIAF = 22;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		num += 32;
		string dpanhmgcbnl = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(CDBDICLJCEJ.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 15f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 30f, 46f, dpanhmgcbnl, TextAnchor.UpperCenter, new Color(0f, 0.2f, 0.3f));
		lcoljopgdll2.DFIGKKMMIAF = 14;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += 30;
		string text = JNBICAJIJMM.LEBHCLDODNI("turn_state" + CDBDICLJCEJ.state);
		TimeSpan makoioidpjk = DateTime.Now - DateTime.Now;
		if (CDBDICLJCEJ.state == 0)
		{
			makoioidpjk = CDBDICLJCEJ.regTime - DateTime.Now;
		}
		if (CDBDICLJCEJ.state == 1)
		{
			makoioidpjk = CDBDICLJCEJ.startTime - DateTime.Now;
		}
		if (CDBDICLJCEJ.state == 2)
		{
			makoioidpjk = CDBDICLJCEJ.endTime - DateTime.Now;
		}
		text = string.Format(text, JLFJEGIPIMM.IKGFHGKKCPG.CLDPDFPGMBP(makoioidpjk));
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(onkdcgnbalk, 5f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 10f, 40f, text, TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll3.DFIGKKMMIAF = 12;
		lcoljopgdll3.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += 22;
		int num2 = (int)(CDBDICLJCEJ.endTime - CDBDICLJCEJ.startTime).TotalMinutes;
		LCOLJOPGDLL lcoljopgdll4 = new LCOLJOPGDLL(onkdcgnbalk, 5f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 10f, 40f, string.Format(JNBICAJIJMM.LEBHCLDODNI("turn_tminfo"), num2), TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll4.DFIGKKMMIAF = 12;
		lcoljopgdll4.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += 32;
		LCOLJOPGDLL lcoljopgdll5 = new LCOLJOPGDLL(onkdcgnbalk, 5f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 10f, 40f, JNBICAJIJMM.LEBHCLDODNI("prisefond"), TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll5.DFIGKKMMIAF = 18;
		lcoljopgdll5.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		num += 18;
		LCOLJOPGDLL lcoljopgdll6 = new LCOLJOPGDLL(onkdcgnbalk, 5f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 10f, 40f, "------------------------------------------------------", TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll6.DFIGKKMMIAF = 12;
		lcoljopgdll6.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += 22;
		LCOLJOPGDLL lcoljopgdll7 = new LCOLJOPGDLL(onkdcgnbalk, 5f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 10f, 40f, string.Format(JNBICAJIJMM.LEBHCLDODNI("pf1m"), CDBDICLJCEJ.prise_1), TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll7.DFIGKKMMIAF = 14;
		lcoljopgdll7.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += 18;
		LCOLJOPGDLL lcoljopgdll8 = new LCOLJOPGDLL(onkdcgnbalk, 5f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 10f, 40f, string.Format(JNBICAJIJMM.LEBHCLDODNI("pf2m"), CDBDICLJCEJ.prise_2), TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll8.DFIGKKMMIAF = 14;
		lcoljopgdll8.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += 18;
		LCOLJOPGDLL lcoljopgdll9 = new LCOLJOPGDLL(onkdcgnbalk, 5f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 10f, 40f, string.Format(JNBICAJIJMM.LEBHCLDODNI("pf3m"), CDBDICLJCEJ.prise_3), TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll9.DFIGKKMMIAF = 14;
		lcoljopgdll9.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += 18;
		LCOLJOPGDLL lcoljopgdll10 = new LCOLJOPGDLL(onkdcgnbalk, 5f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 10f, 40f, string.Format(JNBICAJIJMM.LEBHCLDODNI("pf4_10m"), CDBDICLJCEJ.prise_4), TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll10.DFIGKKMMIAF = 14;
		lcoljopgdll10.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += 18;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 64f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("cntx_close"), 110, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
	}

	// Token: 0x0600779D RID: 30621 RVA: 0x0039397C File Offset: 0x00391B7C
	public void HCNENCIJMKL(HBPNMNGOFMA KADBECGIMPD)
	{
		GHMGDBLLEAG.TurnirItem turnirItem = this.EBOCEMMKEPL(KADBECGIMPD);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.DIOJFJMOPJO("ACTk offers own collection of the secure types to let you protect your variables from <b>ANY</b> memory hacking tools (Cheat Engine, ArtMoney, GameCIH, Game Guardian, etc.)."), turnirItem.turnLangName);
		FlyMessageManager.getI.KICLBJKBFNO(iabkgmnjljo, Color.magenta, 1, 0);
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("", 1058f);
		foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.NAFGMKJPLPC)
		{
			oijegjlcfcf.GNEPMCMHDEM = false;
		}
		GameInterface.getI.currentTurnir = null;
	}

	// Token: 0x0600779E RID: 30622 RVA: 0x00393A28 File Offset: 0x00391C28
	public void ILGFOOODONH(HBPNMNGOFMA KADBECGIMPD)
	{
		if (KADBECGIMPD.LILLHFLDMBH())
		{
			GameInterface.getI.currentTurnir = null;
			Debug.Log("Crouching");
			return;
		}
		if (GameInterface.getI.currentTurnir != null)
		{
			GameInterface.getI.currentTurnir.MONADJLANAE(KADBECGIMPD);
		}
		else
		{
			GameInterface.getI.currentTurnir = this.ANAALPNPIGN(KADBECGIMPD);
		}
		GameInterface.getI.currentTurnir.turnLangName = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[GameInterface.getI.currentTurnir.templateID].AGJCPHMJEID;
		if (GameInterface.getI.currentTurnir.turnimage == null || GameInterface.getI.currentTurnir.turnImageRid != GameInterface.getI.currentTurnir.RID)
		{
			CKNLPGEPGGF.IKGFHGKKCPG.MEIFJCHFGHO(string.Format("_CurveParams", IFPIMPMKJIB.ACOEIDGDLJC(), GameInterface.getI.currentTurnir.templateID), new CKNLPGEPGGF.FADFMDIHCIN(GameInterface.getI.currentTurnir.FPGIOBCEIPG), false);
		}
		Debug.Log("---");
	}

	// Token: 0x0600779F RID: 30623 RVA: 0x00393B3C File Offset: 0x00391D3C
	public void PJAJPGEIILE(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = this.DMGIELACGLA(KADBECGIMPD);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.LEBHCLDODNI("trn_start"), GameInterface.getI.currentTurnir.turnLangName);
		FlyMessageManager.getI.addMessageBig(iabkgmnjljo, Color.magenta, 0, 0);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_TrStartYou.ogg", 0.5f);
	}

	// Token: 0x060077A0 RID: 30624 RVA: 0x00390F69 File Offset: 0x0038F169
	public void KNODODAHLEG(HBPNMNGOFMA KADBECGIMPD)
	{
		this.KANMPIBLDLG(KADBECGIMPD);
	}

	// Token: 0x060077A1 RID: 30625 RVA: 0x00393BA0 File Offset: 0x00391DA0
	public void ECFMAMKPMKC(HBPNMNGOFMA KADBECGIMPD)
	{
		GHMGDBLLEAG.TurnirItem turnirItem = this.ANAALPNPIGN(KADBECGIMPD);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.CDDCIKKDFMP("FOG_EXP"), turnirItem.turnLangName);
		FlyMessageManager.getI.KICLBJKBFNO(iabkgmnjljo, Color.magenta, 0, 0);
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("", 1632f);
		foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.NAFGMKJPLPC)
		{
			oijegjlcfcf.GNEPMCMHDEM = true;
		}
		GameInterface.getI.currentTurnir = null;
	}

	// Token: 0x060077A2 RID: 30626 RVA: 0x00393C4C File Offset: 0x00391E4C
	public void MDFNNPFMHGH(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = this.EBOCEMMKEPL(KADBECGIMPD);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.CDDCIKKDFMP("noworkpoints"), GameInterface.getI.currentTurnir.turnLangName);
		FlyMessageManager.getI.GCIFPMFJMBK(iabkgmnjljo, Color.magenta, 0, 0);
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("ProneIdle", 694f);
	}

	// Token: 0x060077A3 RID: 30627 RVA: 0x00393CB0 File Offset: 0x00391EB0
	private GHMGDBLLEAG.TurnirItem JHGBPCOILPA(HBPNMNGOFMA KADBECGIMPD)
	{
		GHMGDBLLEAG.TurnirItem turnirItem = new GHMGDBLLEAG.TurnirItem(KADBECGIMPD);
		turnirItem.turnLangName = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[turnirItem.templateID].AGJCPHMJEID;
		CKNLPGEPGGF.IKGFHGKKCPG.MEIFJCHFGHO(string.Format("https://groups.google.com/forum/#!forum/final-ik", IFPIMPMKJIB.LCEBBHPKOHO(), turnirItem.templateID), new CKNLPGEPGGF.FADFMDIHCIN(turnirItem.JGDHJBLKKDB), false);
		return turnirItem;
	}

	// Token: 0x060077A4 RID: 30628 RVA: 0x00393D20 File Offset: 0x00391F20
	public void ONAAIBOOHFB(HBPNMNGOFMA KADBECGIMPD)
	{
		if (KADBECGIMPD.ODIBHLOAGBC())
		{
			GameInterface.getI.currentTurnir = null;
			Debug.Log("OfficeSitting1LegStraight");
			return;
		}
		if (GameInterface.getI.currentTurnir != null)
		{
			GameInterface.getI.currentTurnir.FEEODCOLNIN(KADBECGIMPD);
		}
		else
		{
			GameInterface.getI.currentTurnir = this.DMGIELACGLA(KADBECGIMPD);
		}
		GameInterface.getI.currentTurnir.turnLangName = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[GameInterface.getI.currentTurnir.templateID].AGJCPHMJEID;
		if (GameInterface.getI.currentTurnir.turnimage == null || GameInterface.getI.currentTurnir.turnImageRid != GameInterface.getI.currentTurnir.RID)
		{
			CKNLPGEPGGF.PFOLNEGNIPP().PPMAFOGDGAK(string.Format("Demo 1 scene: windy mist fog style. Notice the subtle fog animation. To change look, select Main Camera and check image effect settings in inspector.", IFPIMPMKJIB.ENLHJOJICDG(), GameInterface.getI.currentTurnir.templateID), new CKNLPGEPGGF.FADFMDIHCIN(GameInterface.getI.currentTurnir.JGDHJBLKKDB), false);
		}
		Debug.Log("GestureCutThroat");
	}

	// Token: 0x060077A5 RID: 30629 RVA: 0x00393E34 File Offset: 0x00392034
	public void NBOGIANADPP(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = this.DMGIELACGLA(KADBECGIMPD);
		this.OBPPMLAKFMI.Clear();
		while (!KADBECGIMPD.LILLHFLDMBH())
		{
			GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = new GHMGDBLLEAG.DCEOCCAELEH();
			dceoccaeleh.BOEIGJBBGKL(KADBECGIMPD);
			this.OBPPMLAKFMI.Add(dceoccaeleh);
		}
		if (GameInterface.getI.currentTurnir.state == 3)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().IJAEDDCCNHG(this.AKLCAEAFGPP);
			if (onkdcgnbalk == null)
			{
				return;
			}
			MMKFAENBHKD mmkfaenbhkd = onkdcgnbalk.ADEOBKDFGOP(this.GOHIGLGGDOB) as MMKFAENBHKD;
			if (mmkfaenbhkd != null)
			{
				mmkfaenbhkd.LACAJHOHACK.Clear();
				foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh2 in this.OBPPMLAKFMI)
				{
					dceoccaeleh2.onRender = new ItemBase.OOALOMPKIKK(this.BDLFIMGDDAP);
					mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh2);
				}
			}
		}
		if (GameInterface.getI.currentTurnir.state >= 59)
		{
			GameInterface.getI.currentTurnir = null;
		}
	}

	// Token: 0x060077A6 RID: 30630 RVA: 0x00393F48 File Offset: 0x00392148
	public void PHMPFGKCLNK(GHMGDBLLEAG.TurnirItem CDBDICLJCEJ)
	{
		Debug.Log(" ");
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("</color>", 1056f);
		if (this.AKLCAEAFGPP > 1)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.KCNBOHEMLCI(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().MBADDJEJANJ(160f, 1924f, 1123f, 539f, JNBICAJIJMM.BDKHMOOFHHK("wpn_rod4"), false);
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(43f, 1961f, 1976f, 1059f), CDBDICLJCEJ.turnimage);
		int num = 177;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 574f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1813f, 828f, CDBDICLJCEJ.turnLangName, TextAnchor.UpperRight, Color.black);
		lcoljopgdll.DFIGKKMMIAF = 22;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		num += -70;
		string dpanhmgcbnl = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.OIKOCJOOPDP.AGOMCKLDHEC(CDBDICLJCEJ.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 769f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1167f, 1583f, dpanhmgcbnl, TextAnchor.UpperLeft, new Color(300f, 1688f, 192f));
		lcoljopgdll2.DFIGKKMMIAF = -51;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += -52;
		string text = JNBICAJIJMM.NGALDMFKMJH("SUNSHINE_OVERCAST_ON" + CDBDICLJCEJ.state);
		TimeSpan makoioidpjk = DateTime.Now - DateTime.Now;
		if (CDBDICLJCEJ.state == 0)
		{
			makoioidpjk = CDBDICLJCEJ.regTime - DateTime.Now;
		}
		if (CDBDICLJCEJ.state == 0)
		{
			makoioidpjk = CDBDICLJCEJ.startTime - DateTime.Now;
		}
		if (CDBDICLJCEJ.state == 7)
		{
			makoioidpjk = CDBDICLJCEJ.endTime - DateTime.Now;
		}
		text = string.Format(text, JLFJEGIPIMM.IKGFHGKKCPG.CLDPDFPGMBP(makoioidpjk));
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(onkdcgnbalk, 316f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 5f, 866f, text, TextAnchor.LowerLeft, Color.black);
		lcoljopgdll3.DFIGKKMMIAF = -17;
		lcoljopgdll3.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont;
		num += 86;
		int num2 = (int)(CDBDICLJCEJ.endTime - CDBDICLJCEJ.startTime).TotalMinutes;
		LCOLJOPGDLL lcoljopgdll4 = new LCOLJOPGDLL(onkdcgnbalk, 273f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 987f, 1734f, string.Format(JNBICAJIJMM.BDKHMOOFHHK("langs/lang"), num2), TextAnchor.LowerLeft, Color.black);
		lcoljopgdll4.DFIGKKMMIAF = -20;
		lcoljopgdll4.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont;
		num += -114;
		LCOLJOPGDLL lcoljopgdll5 = new LCOLJOPGDLL(onkdcgnbalk, 997f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 336f, 1974f, JNBICAJIJMM.DIOJFJMOPJO("{0}KLIK_10.tif"), TextAnchor.MiddleLeft, Color.black);
		lcoljopgdll5.DFIGKKMMIAF = -14;
		lcoljopgdll5.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		num += -63;
		LCOLJOPGDLL lcoljopgdll6 = new LCOLJOPGDLL(onkdcgnbalk, 1635f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1413f, 280f, "-L-", TextAnchor.LowerLeft, Color.black);
		lcoljopgdll6.DFIGKKMMIAF = 88;
		lcoljopgdll6.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += 109;
		LCOLJOPGDLL lcoljopgdll7 = new LCOLJOPGDLL(onkdcgnbalk, 236f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 931f, 1933f, string.Format(JNBICAJIJMM.PGJCPFNJNPM("BackPackGrab"), CDBDICLJCEJ.prise_1), TextAnchor.LowerLeft, Color.black);
		lcoljopgdll7.DFIGKKMMIAF = 84;
		lcoljopgdll7.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += -96;
		LCOLJOPGDLL lcoljopgdll8 = new LCOLJOPGDLL(onkdcgnbalk, 1660f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1054f, 1020f, string.Format(JNBICAJIJMM.OOOKJHOHPNN("repair.ogg"), CDBDICLJCEJ.prise_2), TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll8.DFIGKKMMIAF = 19;
		lcoljopgdll8.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += -83;
		LCOLJOPGDLL lcoljopgdll9 = new LCOLJOPGDLL(onkdcgnbalk, 187f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 720f, 1509f, string.Format(JNBICAJIJMM.DCEBAJIILPC(" on layer "), CDBDICLJCEJ.prise_3), TextAnchor.MiddleLeft, Color.black);
		lcoljopgdll9.DFIGKKMMIAF = 127;
		lcoljopgdll9.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += 38;
		LCOLJOPGDLL lcoljopgdll10 = new LCOLJOPGDLL(onkdcgnbalk, 1352f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 217f, 576f, string.Format(JNBICAJIJMM.DCEBAJIILPC(" is represented multiple times in the Bones."), CDBDICLJCEJ.prise_4), TextAnchor.LowerCenter, Color.black);
		lcoljopgdll10.DFIGKKMMIAF = 111;
		lcoljopgdll10.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += -119;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 902f - 1724f, onkdcgnbalk.OCHCODJIPHJ.height - 1190f, 37f, 1181f, JNBICAJIJMM.CDDCIKKDFMP("{{{{{0},{1}}}}}"), -124, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().IBCKNOEANLN));
	}

	// Token: 0x060077A7 RID: 30631 RVA: 0x00394464 File Offset: 0x00392664
	public void JDPEDEKFEGE()
	{
		Debug.Log("Open turnStatus");
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("drag_onmousedown.wav", 1f);
		GHMGDBLLEAG.TurnirItem currentTurnir = GameInterface.getI.currentTurnir;
		if (this.AKLCAEAFGPP > 0)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.HOHNMCIOEOB(10f, 220f, 308f, 450f, JNBICAJIJMM.LEBHCLDODNI("qd_week"), true);
		onkdcgnbalk.GENHHJPGOFK = false;
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(1f, 2f, 304f, 150f), currentTurnir.turnimage);
		int num = 156;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 5f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 10f, 28f, currentTurnir.turnLangName, TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll.DFIGKKMMIAF = 22;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		num += 32;
		string dpanhmgcbnl = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(currentTurnir.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 15f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 30f, 40f, dpanhmgcbnl, TextAnchor.UpperCenter, new Color(0f, 0.2f, 0.5f));
		lcoljopgdll2.DFIGKKMMIAF = 14;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont;
		num += 40;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 6f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 12f, onkdcgnbalk.OCHCODJIPHJ.height - (float)num - 60f, 0);
		this.GOHIGLGGDOB = mmkfaenbhkd.LPFKFNLHGBI;
		mmkfaenbhkd.JHNCNHAAJCH = 28f;
		foreach (GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh in this.OBPPMLAKFMI)
		{
			mmkfaenbhkd.LACAJHOHACK.Add(dceoccaeleh);
			dceoccaeleh.onRender = new ItemBase.OOALOMPKIKK(this.BDLFIMGDDAP);
		}
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 64f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("cntx_close"), 110, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
	}

	// Token: 0x060077A8 RID: 30632 RVA: 0x003946E0 File Offset: 0x003928E0
	public void FMHEDFFJOFF(GHMGDBLLEAG.TurnirItem CDBDICLJCEJ)
	{
		Debug.Log("_MidGrey");
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("Text node is empy!", 184f);
		if (this.AKLCAEAFGPP > 1)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().KCNBOHEMLCI(this.AKLCAEAFGPP);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().HOHNMCIOEOB(1457f, 1633f, 531f, 1219f, JNBICAJIJMM.NGALDMFKMJH(""), true);
		this.AKLCAEAFGPP = onkdcgnbalk.LPFKFNLHGBI;
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(1484f, 212f, 975f, 1242f), CDBDICLJCEJ.turnimage);
		int num = -83;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 27f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1237f, 667f, CDBDICLJCEJ.turnLangName, TextAnchor.UpperLeft, Color.black);
		lcoljopgdll.DFIGKKMMIAF = -44;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont2;
		num += 59;
		string dpanhmgcbnl = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.AGOMCKLDHEC(CDBDICLJCEJ.task);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 892f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1156f, 1126f, dpanhmgcbnl, TextAnchor.UpperLeft, new Color(1102f, 1918f, 1884f));
		lcoljopgdll2.DFIGKKMMIAF = 79;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += -116;
		string text = JNBICAJIJMM.CELEPPAEKAB("https://www.youtube.com/watch?v=wT8fViZpLmQ" + CDBDICLJCEJ.state);
		TimeSpan makoioidpjk = DateTime.Now - DateTime.Now;
		if (CDBDICLJCEJ.state == 0)
		{
			makoioidpjk = CDBDICLJCEJ.regTime - DateTime.Now;
		}
		if (CDBDICLJCEJ.state == 0)
		{
			makoioidpjk = CDBDICLJCEJ.startTime - DateTime.Now;
		}
		if (CDBDICLJCEJ.state == 1)
		{
			makoioidpjk = CDBDICLJCEJ.endTime - DateTime.Now;
		}
		text = string.Format(text, JLFJEGIPIMM.MHFDIJGJGBJ().CLDPDFPGMBP(makoioidpjk));
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(onkdcgnbalk, 551f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 435f, 987f, text, TextAnchor.UpperRight, Color.black);
		lcoljopgdll3.DFIGKKMMIAF = -52;
		lcoljopgdll3.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += 33;
		int num2 = (int)(CDBDICLJCEJ.endTime - CDBDICLJCEJ.startTime).TotalMinutes;
		LCOLJOPGDLL lcoljopgdll4 = new LCOLJOPGDLL(onkdcgnbalk, 655f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1828f, 1581f, string.Format(JNBICAJIJMM.BDKHMOOFHHK(""), num2), TextAnchor.UpperCenter, Color.black);
		lcoljopgdll4.DFIGKKMMIAF = -92;
		lcoljopgdll4.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += 110;
		LCOLJOPGDLL lcoljopgdll5 = new LCOLJOPGDLL(onkdcgnbalk, 1603f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1106f, 1266f, JNBICAJIJMM.PGJCPFNJNPM("human_move_2.wav"), TextAnchor.LowerCenter, Color.black);
		lcoljopgdll5.DFIGKKMMIAF = -23;
		lcoljopgdll5.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont2;
		num += -20;
		LCOLJOPGDLL lcoljopgdll6 = new LCOLJOPGDLL(onkdcgnbalk, 811f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 468f, 704f, "SoccerStartKick", TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll6.DFIGKKMMIAF = -17;
		lcoljopgdll6.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += -83;
		LCOLJOPGDLL lcoljopgdll7 = new LCOLJOPGDLL(onkdcgnbalk, 1714f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 646f, 1601f, string.Format(JNBICAJIJMM.LEBHCLDODNI("ComeHere"), CDBDICLJCEJ.prise_1), TextAnchor.UpperLeft, Color.black);
		lcoljopgdll7.DFIGKKMMIAF = -33;
		lcoljopgdll7.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont;
		num += 122;
		LCOLJOPGDLL lcoljopgdll8 = new LCOLJOPGDLL(onkdcgnbalk, 424f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 807f, 1600f, string.Format(JNBICAJIJMM.LEBHCLDODNI("vignetteIntensity"), CDBDICLJCEJ.prise_2), TextAnchor.UpperRight, Color.black);
		lcoljopgdll8.DFIGKKMMIAF = 52;
		lcoljopgdll8.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont;
		num += 45;
		LCOLJOPGDLL lcoljopgdll9 = new LCOLJOPGDLL(onkdcgnbalk, 828f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 1881f, 1496f, string.Format(JNBICAJIJMM.LEBHCLDODNI("#403000"), CDBDICLJCEJ.prise_3), TextAnchor.MiddleLeft, Color.black);
		lcoljopgdll9.DFIGKKMMIAF = -87;
		lcoljopgdll9.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += 63;
		LCOLJOPGDLL lcoljopgdll10 = new LCOLJOPGDLL(onkdcgnbalk, 812f, (float)num, onkdcgnbalk.OCHCODJIPHJ.width - 618f, 441f, string.Format(JNBICAJIJMM.NGALDMFKMJH("OfficeSittingMouseMovement"), CDBDICLJCEJ.prise_4), TextAnchor.MiddleCenter, Color.black);
		lcoljopgdll10.DFIGKKMMIAF = 114;
		lcoljopgdll10.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont;
		num += 56;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 83f - 1731f, onkdcgnbalk.OCHCODJIPHJ.height - 756f, 1408f, 1722f, JNBICAJIJMM.PPNKMDJBMLP("enable"), -8, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().AGIEGPEMGOA));
	}

	// Token: 0x060077A9 RID: 30633 RVA: 0x00394BFC File Offset: 0x00392DFC
	public void EHNLNIBDHCK(HBPNMNGOFMA KADBECGIMPD)
	{
		if (KADBECGIMPD.BKIBKLFCCGP())
		{
			GameInterface.getI.currentTurnir = null;
			Debug.Log("ZombieCrawl");
			return;
		}
		if (GameInterface.getI.currentTurnir != null)
		{
			GameInterface.getI.currentTurnir.GNFKNBMMCNM(KADBECGIMPD);
		}
		else
		{
			GameInterface.getI.currentTurnir = this.KANMPIBLDLG(KADBECGIMPD);
		}
		GameInterface.getI.currentTurnir.turnLangName = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[GameInterface.getI.currentTurnir.templateID].AGJCPHMJEID;
		if (GameInterface.getI.currentTurnir.turnimage == null || GameInterface.getI.currentTurnir.turnImageRid != GameInterface.getI.currentTurnir.RID)
		{
			CKNLPGEPGGF.PFOLNEGNIPP().MEIFJCHFGHO(string.Format("_ProjectToPixelMatrix", IFPIMPMKJIB.DIDFMAELMJD, GameInterface.getI.currentTurnir.templateID), new CKNLPGEPGGF.FADFMDIHCIN(GameInterface.getI.currentTurnir.APKPEFHGLCD), true);
		}
		Debug.Log("fish/");
	}

	// Token: 0x060077AA RID: 30634 RVA: 0x00394D10 File Offset: 0x00392F10
	public void CHEIJHEGOJA(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = this.DMGIELACGLA(KADBECGIMPD);
		string.Format(JNBICAJIJMM.LEBHCLDODNI("trn_reg"), GameInterface.getI.currentTurnir.turnLangName);
	}

	// Token: 0x060077AB RID: 30635 RVA: 0x00394D42 File Offset: 0x00392F42
	public void CIMBKMLONNN(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = this.DMGIELACGLA(KADBECGIMPD);
		string.Format(JNBICAJIJMM.NGALDMFKMJH("_RangeScale"), GameInterface.getI.currentTurnir.turnLangName);
	}

	// Token: 0x060077AC RID: 30636 RVA: 0x00394D74 File Offset: 0x00392F74
	public void OKLNBHBLLAD(HBPNMNGOFMA KADBECGIMPD)
	{
		GHMGDBLLEAG.TurnirItem turnirItem = this.JHGBPCOILPA(KADBECGIMPD);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.DIOJFJMOPJO("wgt_kg"), turnirItem.turnLangName);
		FlyMessageManager.getI.ODLGBMGAKGF(iabkgmnjljo, Color.magenta, 0, 0);
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("", 1587f);
		foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.NAFGMKJPLPC)
		{
			oijegjlcfcf.GNEPMCMHDEM = false;
		}
		GameInterface.getI.currentTurnir = null;
	}

	// Token: 0x060077AD RID: 30637 RVA: 0x00394E20 File Offset: 0x00393020
	private void IDIJOEBABIA(ONKDCGNBALK JLEJDINFJOF, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		GHMGDBLLEAG.DCEOCCAELEH dceoccaeleh = (GHMGDBLLEAG.DCEOCCAELEH)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 13,
			font = GuiProcessor.IKGFHGKKCPG.rusfont3,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperRight
		};
		if (dceoccaeleh.MCHIDGLEDID <= 10)
		{
			GUI.color = new Color(0.9f, 0.9f, 0.8f, 0.5f);
			if (dceoccaeleh.MCHIDGLEDID <= 3)
			{
				GUI.color = new Color(0.8f, 1f, 0.8f, 0.5f);
			}
			GUI.DrawTexture(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, OCHCODJIPHJ.width, OCHCODJIPHJ.height - 1f), GameInterface.getI.simpleGray);
			GUI.color = Color.white;
		}
		Color black = Color.black;
		guistyle.normal.textColor = black;
		guistyle.alignment = TextAnchor.MiddleLeft;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		string jipipolkpcf = dceoccaeleh.JIPIPOLKPCF;
		GUI.Label(new Rect(OCHCODJIPHJ.x + 52f, OCHCODJIPHJ.y, 160f, OCHCODJIPHJ.height), jipipolkpcf, guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + 52f + 160f, OCHCODJIPHJ.y, 6f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
		guistyle.alignment = TextAnchor.MiddleCenter;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont2;
		guistyle.fontSize = 22;
		GUI.Label(new Rect(OCHCODJIPHJ.x, OCHCODJIPHJ.y, 28f, OCHCODJIPHJ.height), string.Concat(dceoccaeleh.MCHIDGLEDID), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + 30f, OCHCODJIPHJ.y, 6f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
		guistyle.fontSize = 14;
		guistyle.alignment = TextAnchor.MiddleRight;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		GUI.Label(new Rect(OCHCODJIPHJ.x + 200f, OCHCODJIPHJ.y + 2f, 82f, OCHCODJIPHJ.height - 2f), string.Concat(dceoccaeleh.CBJBGGAOODC), guistyle);
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + 286f, OCHCODJIPHJ.y, 6f, OCHCODJIPHJ.height), GameInterface.getI.linevertival);
		guistyle.fontSize = 14;
		guistyle.alignment = TextAnchor.MiddleRight;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		GUI.Label(new Rect(OCHCODJIPHJ.x + 290f, OCHCODJIPHJ.y + 2f, 166f, OCHCODJIPHJ.height - 2f), dceoccaeleh.JNLLLJAADHJ.ToString(), guistyle);
	}

	// Token: 0x060077AE RID: 30638 RVA: 0x0039511A File Offset: 0x0039331A
	public void AOOGODFEGPD(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = this.KANMPIBLDLG(KADBECGIMPD);
		string.Format(JNBICAJIJMM.CELEPPAEKAB("ShotgunReloadChamber"), GameInterface.getI.currentTurnir.turnLangName);
	}

	// Token: 0x060077AF RID: 30639 RVA: 0x0038D3EE File Offset: 0x0038B5EE
	public static GHMGDBLLEAG IELNFGAEHNE()
	{
		if (GHMGDBLLEAG.KFBIDIMHNGF == null)
		{
			GHMGDBLLEAG.KFBIDIMHNGF = new GHMGDBLLEAG();
		}
		return GHMGDBLLEAG.KFBIDIMHNGF;
	}

	// Token: 0x060077B0 RID: 30640 RVA: 0x0039514C File Offset: 0x0039334C
	public void MCGCIEAGOBO(HBPNMNGOFMA KADBECGIMPD)
	{
		GHMGDBLLEAG.TurnirItem turnirItem = this.KANMPIBLDLG(KADBECGIMPD);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.DCEBAJIILPC("m_bAuthorized={0} m_ulOrderID={1} m_unAppID={2}"), turnirItem.turnLangName);
		FlyMessageManager.getI.FDHDJFEIOMG(iabkgmnjljo, Color.magenta, 0, 1);
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("Loot", 430f);
		foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.NAFGMKJPLPC)
		{
			oijegjlcfcf.GNEPMCMHDEM = true;
		}
		GameInterface.getI.currentTurnir = null;
	}

	// Token: 0x060077B1 RID: 30641 RVA: 0x003951F8 File Offset: 0x003933F8
	public void DNLLKJLLKEA(HBPNMNGOFMA KADBECGIMPD)
	{
		GameInterface.getI.currentTurnir = this.EBOCEMMKEPL(KADBECGIMPD);
		string.Format(JNBICAJIJMM.NGALDMFKMJH("RHandPunch"), GameInterface.getI.currentTurnir.turnLangName);
	}

	// Token: 0x060077B2 RID: 30642 RVA: 0x0039522C File Offset: 0x0039342C
	private GHMGDBLLEAG.TurnirItem DMGIELACGLA(HBPNMNGOFMA KADBECGIMPD)
	{
		GHMGDBLLEAG.TurnirItem turnirItem = new GHMGDBLLEAG.TurnirItem(KADBECGIMPD);
		turnirItem.turnLangName = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[turnirItem.templateID].AGJCPHMJEID;
		CKNLPGEPGGF.IKGFHGKKCPG.PPMAFOGDGAK(string.Format("{0}Textures/Turnirs/{1}.png", IFPIMPMKJIB.DIDFMAELMJD, turnirItem.templateID), new CKNLPGEPGGF.FADFMDIHCIN(turnirItem.JGDHJBLKKDB), false);
		return turnirItem;
	}

	// Token: 0x04001144 RID: 4420
	private static GHMGDBLLEAG KFBIDIMHNGF;

	// Token: 0x04001145 RID: 4421
	public int GOHIGLGGDOB = -1;

	// Token: 0x04001146 RID: 4422
	public List<GHMGDBLLEAG.DCEOCCAELEH> OBPPMLAKFMI = new List<GHMGDBLLEAG.DCEOCCAELEH>();

	// Token: 0x04001147 RID: 4423
	private int AKLCAEAFGPP = -1;

	// Token: 0x02000202 RID: 514
	[Serializable]
	public class TurnirItem : ItemBase
	{
		// Token: 0x060077B3 RID: 30643 RVA: 0x0039529C File Offset: 0x0039349C
		public virtual void HGPPGJPEPEE(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.imgtex = IKPEEEBENDE[1].gameObject.GetComponent<RawImage>();
			this.imgtex.texture = CKNLPGEPGGF.IKGFHGKKCPG.FPMCLKLBEPB();
			this.imgtex.color = new Color(1153f, 621f, 1563f, 312f);
			CKNLPGEPGGF.PFOLNEGNIPP().MEIFJCHFGHO(string.Format("cht_msg2", IFPIMPMKJIB.NEJIPLDOMMC(), this.templateID), new CKNLPGEPGGF.FADFMDIHCIN(this.APKPEFHGLCD), true);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[this.templateID].AGJCPHMJEID;
			string text = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.OIKOCJOOPDP.AGOMCKLDHEC(this.task);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = text;
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.CELEPPAEKAB("\n"), JNBICAJIJMM.APMJBBDBOJO().FCNFDLDHDDE(this.baseid));
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.DIOJFJMOPJO("money"), this.levels.KMIOLLENCOL(), this.levels.NLHKFMMDMMK());
			string text2 = JNBICAJIJMM.LEBHCLDODNI("Mouse Y" + this.state);
			TimeSpan makoioidpjk = DateTime.Now - DateTime.Now;
			if (this.state == 0)
			{
				makoioidpjk = this.regTime - DateTime.Now;
			}
			if (this.state == 0)
			{
				makoioidpjk = this.startTime - DateTime.Now;
			}
			if (this.state == 4)
			{
				makoioidpjk = this.endTime - DateTime.Now;
			}
			text2 = string.Format(text2, JLFJEGIPIMM.PKGMBFEMKGP().CLDPDFPGMBP(makoioidpjk));
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().text = text2;
			int num = (int)(this.endTime - this.startTime).TotalMinutes;
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.NGALDMFKMJH("ZombieIdle"), num);
			IKPEEEBENDE[1].gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(this.BAGNPHMCJNJ));
		}

		// Token: 0x060077B4 RID: 30644 RVA: 0x00395503 File Offset: 0x00393703
		public void APKPEFHGLCD(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			this.turnimage = NOFCHOFPHAD;
			if (this.imgtex != null)
			{
				this.imgtex.texture = this.turnimage.DPBCBCLJHAJ();
			}
			this.turnImageRid = this.RID;
		}

		// Token: 0x060077B5 RID: 30645 RVA: 0x0039553C File Offset: 0x0039373C
		public override void MLCFJPPIOJG(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.imgtex = IKPEEEBENDE[0].gameObject.GetComponent<RawImage>();
			this.imgtex.texture = CKNLPGEPGGF.IKGFHGKKCPG.FPMCLKLBEPB();
			this.imgtex.color = new Color(1f, 1f, 1f, 1f);
			CKNLPGEPGGF.IKGFHGKKCPG.PPMAFOGDGAK(string.Format("{0}Textures/Turnirs/{1}.png", IFPIMPMKJIB.DIDFMAELMJD, this.templateID), new CKNLPGEPGGF.FADFMDIHCIN(this.JGDHJBLKKDB), false);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[this.templateID].AGJCPHMJEID;
			string text = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(this.task);
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = text;
			IKPEEEBENDE[3].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.LEBHCLDODNI("turn_base1"), JNBICAJIJMM.IKGFHGKKCPG.KHKAOHCCPAJ(this.baseid));
			IKPEEEBENDE[4].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.LEBHCLDODNI("turn_levels"), this.levels.IBEIBAHKIAH, this.levels.ICJDPPOJINN);
			string text2 = JNBICAJIJMM.LEBHCLDODNI("turn_state" + this.state);
			TimeSpan makoioidpjk = DateTime.Now - DateTime.Now;
			if (this.state == 0)
			{
				makoioidpjk = this.regTime - DateTime.Now;
			}
			if (this.state == 1)
			{
				makoioidpjk = this.startTime - DateTime.Now;
			}
			if (this.state == 2)
			{
				makoioidpjk = this.endTime - DateTime.Now;
			}
			text2 = string.Format(text2, JLFJEGIPIMM.IKGFHGKKCPG.CLDPDFPGMBP(makoioidpjk));
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = text2;
			int num = (int)(this.endTime - this.startTime).TotalMinutes;
			IKPEEEBENDE[5].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.LEBHCLDODNI("turn_tminfo"), num);
			IKPEEEBENDE[8].gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(this.INDFHCGECGF));
		}

		// Token: 0x060077B6 RID: 30646 RVA: 0x003957A3 File Offset: 0x003939A3
		public void EFLKJEMIEBG()
		{
			GHMGDBLLEAG.BPCNCENHEAG().GNHFEOFDBMO(this);
		}

		// Token: 0x060077B7 RID: 30647 RVA: 0x003957B0 File Offset: 0x003939B0
		public void GNFKNBMMCNM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.RID = KADBECGIMPD.DCGEOFHNBCN();
			this.templateID = KADBECGIMPD.HDBGOLAFOBK();
			this.state = KADBECGIMPD.KKOKFLMMAAK();
			this.baseid = KADBECGIMPD.CLPEKGGAMAI();
			this.levels = KADBECGIMPD.EIMAIEJKHKF();
			this.usrsInTurn = KADBECGIMPD.IFDFHJLCHAE();
			this.regTime = KADBECGIMPD.IKJAOHGGCJD() - TimeController.EKEBHIJMEML().deltaTime;
			this.startTime = KADBECGIMPD.HGFHMFMNIEI() - TimeController.KOJCECHBHLO().deltaTime;
			this.endTime = KADBECGIMPD.MILGIGJBAJL() - TimeController.IKGFHGKKCPG.deltaTime;
			this.result = KADBECGIMPD.LPKJHMGLCKA();
			this.prise_1 = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.FDIDEGHPJPF());
			this.prise_2 = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.DPLAJNEDGBL());
			this.prise_3 = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.FDIDEGHPJPF());
			this.prise_4 = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.KDELAFDDGJH());
			KADBECGIMPD.HHMGLDMFCPF();
			this.task = new DODHLMFHFNL.QTask();
			this.task.ONIJHKMCCHH(KADBECGIMPD);
		}

		// Token: 0x060077B8 RID: 30648 RVA: 0x003958C4 File Offset: 0x00393AC4
		private void BAGNPHMCJNJ()
		{
			this.GBIMCGOIOOC();
		}

		// Token: 0x060077B9 RID: 30649 RVA: 0x003958CC File Offset: 0x00393ACC
		public void GBIMCGOIOOC()
		{
			GHMGDBLLEAG.IELNFGAEHNE().LOEAGDFDPEO(this);
		}

		// Token: 0x060077BA RID: 30650 RVA: 0x003958DC File Offset: 0x00393ADC
		public void MONADJLANAE(HBPNMNGOFMA KADBECGIMPD)
		{
			this.RID = KADBECGIMPD.HFOPFEJDJFG();
			this.templateID = KADBECGIMPD.CLPEKGGAMAI();
			this.state = KADBECGIMPD.IFDFHJLCHAE();
			this.baseid = KADBECGIMPD.KKOKFLMMAAK();
			this.levels = KADBECGIMPD.OEHCLGOFDPN();
			this.usrsInTurn = KADBECGIMPD.KKOKFLMMAAK();
			this.regTime = KADBECGIMPD.OODOKDPIMOF() - TimeController.EKEBHIJMEML().deltaTime;
			this.startTime = KADBECGIMPD.PFKHMDDOHDN() - TimeController.IKGFHGKKCPG.deltaTime;
			this.endTime = KADBECGIMPD.MILGIGJBAJL() - TimeController.EKEBHIJMEML().deltaTime;
			this.result = KADBECGIMPD.LPKJHMGLCKA();
			this.prise_1 = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.LPKJHMGLCKA());
			this.prise_2 = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.FDIDEGHPJPF());
			this.prise_3 = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.NCODBGMGNFD());
			this.prise_4 = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.NCODBGMGNFD());
			KADBECGIMPD.DNIIFBAIPBE();
			this.task = new DODHLMFHFNL.QTask();
			this.task.IHONANEEDOC(KADBECGIMPD);
		}

		// Token: 0x060077BB RID: 30651 RVA: 0x003959F0 File Offset: 0x00393BF0
		private void ODEIPBHOIPJ()
		{
			this.MCDABNGADAD();
		}

		// Token: 0x060077BC RID: 30652 RVA: 0x003959F8 File Offset: 0x00393BF8
		public virtual void NKBOMOAMPOO(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.imgtex = IKPEEEBENDE[1].gameObject.GetComponent<RawImage>();
			this.imgtex.texture = CKNLPGEPGGF.PFOLNEGNIPP().FPMCLKLBEPB();
			this.imgtex.color = new Color(198f, 1839f, 315f, 836f);
			CKNLPGEPGGF.IKGFHGKKCPG.PPMAFOGDGAK(string.Format("", IFPIMPMKJIB.EHCJCCILAHM(), this.templateID), new CKNLPGEPGGF.FADFMDIHCIN(this.APKPEFHGLCD), true);
			IKPEEEBENDE[0].gameObject.GetComponent<Text>().text = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[this.templateID].AGJCPHMJEID;
			string text = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.CDFCKFCEHGB(this.task);
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().text = text;
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.OOOKJHOHPNN("template"), JNBICAJIJMM.CLIMNFDGOEG().KHKAOHCCPAJ(this.baseid));
			IKPEEEBENDE[6].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.PPNKMDJBMLP("error"), this.levels.NKEOCCKEOCE(), this.levels.NLHKFMMDMMK());
			string text2 = JNBICAJIJMM.DCEBAJIILPC("RollerBladeJump" + this.state);
			TimeSpan makoioidpjk = DateTime.Now - DateTime.Now;
			if (this.state == 0)
			{
				makoioidpjk = this.regTime - DateTime.Now;
			}
			if (this.state == 0)
			{
				makoioidpjk = this.startTime - DateTime.Now;
			}
			if (this.state == 6)
			{
				makoioidpjk = this.endTime - DateTime.Now;
			}
			text2 = string.Format(text2, JLFJEGIPIMM.PKGMBFEMKGP().CLDPDFPGMBP(makoioidpjk));
			IKPEEEBENDE[2].gameObject.GetComponent<Text>().text = text2;
			int num = (int)(this.endTime - this.startTime).TotalMinutes;
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.DCEBAJIILPC("Curve"), num);
			IKPEEEBENDE[8].gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(this.ODEIPBHOIPJ));
		}

		// Token: 0x060077BD RID: 30653 RVA: 0x00395C5F File Offset: 0x00393E5F
		public TurnirItem(HBPNMNGOFMA KADBECGIMPD)
		{
			this.OCPAHLAGCAI(KADBECGIMPD);
		}

		// Token: 0x060077BE RID: 30654 RVA: 0x003959F0 File Offset: 0x00393BF0
		[CompilerGenerated]
		private void INDFHCGECGF()
		{
			this.MCDABNGADAD();
		}

		// Token: 0x060077BF RID: 30655 RVA: 0x00395C70 File Offset: 0x00393E70
		public virtual void FNEIPGNIBEE(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			string text = JNBICAJIJMM.LEBHCLDODNI("LUX_LINEAR" + this.state);
			TimeSpan makoioidpjk = DateTime.Now - DateTime.Now;
			if (this.state == 0)
			{
				makoioidpjk = this.regTime - DateTime.Now;
			}
			if (this.state == 0)
			{
				makoioidpjk = this.startTime - DateTime.Now;
			}
			if (this.state == 4)
			{
				makoioidpjk = this.endTime - DateTime.Now;
			}
			text = string.Format(text, JLFJEGIPIMM.IKGFHGKKCPG.CLDPDFPGMBP(makoioidpjk));
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = text;
		}

		// Token: 0x060077C0 RID: 30656 RVA: 0x00395D20 File Offset: 0x00393F20
		public virtual void HJPFIDCAPGA(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			this.imgtex = IKPEEEBENDE[1].gameObject.GetComponent<RawImage>();
			this.imgtex.texture = CKNLPGEPGGF.IKGFHGKKCPG.FLDLBIHLNKM();
			this.imgtex.color = new Color(1051f, 1013f, 1893f, 1832f);
			CKNLPGEPGGF.PFOLNEGNIPP().PPMAFOGDGAK(string.Format("_OcclusionTexture2", IFPIMPMKJIB.BKKFFINMJBO(), this.templateID), new CKNLPGEPGGF.FADFMDIHCIN(this.FPGIOBCEIPG), true);
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.OIKOCJOOPDP.GCPONGMMAAI[this.templateID].AGJCPHMJEID;
			string text = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.OIKOCJOOPDP.FDKEPHNOIFO(this.task);
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = text;
			IKPEEEBENDE[1].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.PPNKMDJBMLP("SwimDogPaddle"), JNBICAJIJMM.CLIMNFDGOEG().HFDIEKGBGEN(this.baseid));
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.PPNKMDJBMLP("WeaponRun"), this.levels.KEHIFGILLJA(), this.levels.KMGAHCANELI());
			string text2 = JNBICAJIJMM.CDDCIKKDFMP("GestureWonderful" + this.state);
			TimeSpan makoioidpjk = DateTime.Now - DateTime.Now;
			if (this.state == 0)
			{
				makoioidpjk = this.regTime - DateTime.Now;
			}
			if (this.state == 1)
			{
				makoioidpjk = this.startTime - DateTime.Now;
			}
			if (this.state == 1)
			{
				makoioidpjk = this.endTime - DateTime.Now;
			}
			text2 = string.Format(text2, JLFJEGIPIMM.MHFDIJGJGBJ().CLDPDFPGMBP(makoioidpjk));
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = text2;
			int num = (int)(this.endTime - this.startTime).TotalMinutes;
			IKPEEEBENDE[8].gameObject.GetComponent<Text>().text = string.Format(JNBICAJIJMM.OOOKJHOHPNN("Hyperlink_"), num);
			IKPEEEBENDE[0].gameObject.GetComponent<Button>().onClick.AddListener(new UnityAction(this.ODEIPBHOIPJ));
		}

		// Token: 0x060077C1 RID: 30657 RVA: 0x00395F88 File Offset: 0x00394188
		public override void AAJMALCKJHE(RectTransform[] IKPEEEBENDE, RectTransform ONPHLHKAGFP)
		{
			if (IKPEEEBENDE == null)
			{
				return;
			}
			string text = JNBICAJIJMM.LEBHCLDODNI("turn_state" + this.state);
			TimeSpan makoioidpjk = DateTime.Now - DateTime.Now;
			if (this.state == 0)
			{
				makoioidpjk = this.regTime - DateTime.Now;
			}
			if (this.state == 1)
			{
				makoioidpjk = this.startTime - DateTime.Now;
			}
			if (this.state == 2)
			{
				makoioidpjk = this.endTime - DateTime.Now;
			}
			text = string.Format(text, JLFJEGIPIMM.IKGFHGKKCPG.CLDPDFPGMBP(makoioidpjk));
			IKPEEEBENDE[7].gameObject.GetComponent<Text>().text = text;
		}

		// Token: 0x060077C2 RID: 30658 RVA: 0x003959F0 File Offset: 0x00393BF0
		private void NECBCHOEOAG()
		{
			this.MCDABNGADAD();
		}

		// Token: 0x060077C3 RID: 30659 RVA: 0x00396038 File Offset: 0x00394238
		public void OCPAHLAGCAI(HBPNMNGOFMA KADBECGIMPD)
		{
			this.RID = KADBECGIMPD.DNIIFBAIPBE();
			this.templateID = KADBECGIMPD.HDBGOLAFOBK();
			this.state = KADBECGIMPD.HDBGOLAFOBK();
			this.baseid = KADBECGIMPD.HDBGOLAFOBK();
			this.levels = KADBECGIMPD.EIMAIEJKHKF();
			this.usrsInTurn = KADBECGIMPD.HDBGOLAFOBK();
			this.regTime = KADBECGIMPD.IKJAOHGGCJD() - TimeController.IKGFHGKKCPG.deltaTime;
			this.startTime = KADBECGIMPD.IKJAOHGGCJD() - TimeController.IKGFHGKKCPG.deltaTime;
			this.endTime = KADBECGIMPD.IKJAOHGGCJD() - TimeController.IKGFHGKKCPG.deltaTime;
			this.result = KADBECGIMPD.BFPHBMDMODH();
			this.prise_1 = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.BFPHBMDMODH());
			this.prise_2 = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.BFPHBMDMODH());
			this.prise_3 = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.BFPHBMDMODH());
			this.prise_4 = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.BFPHBMDMODH());
			KADBECGIMPD.DNIIFBAIPBE();
			this.task = new DODHLMFHFNL.QTask();
			this.task.OCPAHLAGCAI(KADBECGIMPD);
		}

		// Token: 0x060077C4 RID: 30660 RVA: 0x0039614C File Offset: 0x0039434C
		public void CPDOBILDDPD()
		{
			GHMGDBLLEAG.EEOPOHEALPK().AIOPMEMEBHI(this);
		}

		// Token: 0x060077C5 RID: 30661 RVA: 0x00396159 File Offset: 0x00394359
		public void MCDABNGADAD()
		{
			GHMGDBLLEAG.IKGFHGKKCPG.AIOPMEMEBHI(this);
		}

		// Token: 0x060077C6 RID: 30662 RVA: 0x00396166 File Offset: 0x00394366
		public void JGDHJBLKKDB(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			this.turnimage = NOFCHOFPHAD;
			if (this.imgtex != null)
			{
				this.imgtex.texture = this.turnimage.KEDGAOBCNJG;
			}
			this.turnImageRid = this.RID;
		}

		// Token: 0x060077C7 RID: 30663 RVA: 0x0039619F File Offset: 0x0039439F
		public void FPGIOBCEIPG(CKNLPGEPGGF.IAPCJOBDCEH NOFCHOFPHAD)
		{
			this.turnimage = NOFCHOFPHAD;
			if (this.imgtex != null)
			{
				this.imgtex.texture = this.turnimage.PFFJJEJNKPB();
			}
			this.turnImageRid = this.RID;
		}

		// Token: 0x060077C8 RID: 30664 RVA: 0x003961D8 File Offset: 0x003943D8
		public void FEEODCOLNIN(HBPNMNGOFMA KADBECGIMPD)
		{
			this.RID = KADBECGIMPD.IJDIMHAEAIE();
			this.templateID = KADBECGIMPD.KDNDJNEGBDI();
			this.state = KADBECGIMPD.AGNKAFLKCAG();
			this.baseid = KADBECGIMPD.KKOKFLMMAAK();
			this.levels = KADBECGIMPD.LICHMNLLOAB();
			this.usrsInTurn = KADBECGIMPD.LDLKLPJBIJN();
			this.regTime = KADBECGIMPD.FCGGODFGMCB() - TimeController.EPCKOOOGNGK().deltaTime;
			this.startTime = KADBECGIMPD.MILGIGJBAJL() - TimeController.EPCKOOOGNGK().deltaTime;
			this.endTime = KADBECGIMPD.MILGIGJBAJL() - TimeController.EKEBHIJMEML().deltaTime;
			this.result = KADBECGIMPD.BFPHBMDMODH();
			this.prise_1 = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.JJJJAGJCOGD());
			this.prise_2 = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.LPKJHMGLCKA());
			this.prise_3 = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.KDELAFDDGJH());
			this.prise_4 = new EJDGMNEEOGN.EMOEAOFEKCO(KADBECGIMPD.PNBECHOLCJM());
			KADBECGIMPD.DCGEOFHNBCN();
			this.task = new DODHLMFHFNL.QTask();
			this.task.PACODAINDCD(KADBECGIMPD);
		}

		// Token: 0x04001148 RID: 4424
		public long RID;

		// Token: 0x04001149 RID: 4425
		public int templateID;

		// Token: 0x0400114A RID: 4426
		public int state;

		// Token: 0x0400114B RID: 4427
		public int baseid;

		// Token: 0x0400114C RID: 4428
		public IIBEEKCAAHK levels;

		// Token: 0x0400114D RID: 4429
		public int usrsInTurn;

		// Token: 0x0400114E RID: 4430
		public DateTime regTime;

		// Token: 0x0400114F RID: 4431
		public DateTime startTime;

		// Token: 0x04001150 RID: 4432
		public DateTime endTime;

		// Token: 0x04001151 RID: 4433
		public string result;

		// Token: 0x04001152 RID: 4434
		public DODHLMFHFNL.QTask task;

		// Token: 0x04001153 RID: 4435
		public CKNLPGEPGGF.IAPCJOBDCEH turnimage;

		// Token: 0x04001154 RID: 4436
		public long turnImageRid;

		// Token: 0x04001155 RID: 4437
		public EJDGMNEEOGN.EMOEAOFEKCO prise_1;

		// Token: 0x04001156 RID: 4438
		public EJDGMNEEOGN.EMOEAOFEKCO prise_2;

		// Token: 0x04001157 RID: 4439
		public EJDGMNEEOGN.EMOEAOFEKCO prise_3;

		// Token: 0x04001158 RID: 4440
		public EJDGMNEEOGN.EMOEAOFEKCO prise_4;

		// Token: 0x04001159 RID: 4441
		public string turnLangName;

		// Token: 0x0400115A RID: 4442
		private RawImage imgtex;
	}

	// Token: 0x02000203 RID: 515
	public class DCEOCCAELEH : ItemBase
	{
		// Token: 0x060077C9 RID: 30665 RVA: 0x003962EC File Offset: 0x003944EC
		public virtual string JHGPBNCOHHH()
		{
			return string.Format("<color='#400000'>", this.MCHIDGLEDID, this.JIPIPOLKPCF, this.CBJBGGAOODC);
		}

		// Token: 0x060077CA RID: 30666 RVA: 0x00396314 File Offset: 0x00394514
		public void BOEIGJBBGKL(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.IJDIMHAEAIE();
			this.MCHIDGLEDID = KADBECGIMPD.AGNKAFLKCAG();
			this.CBJBGGAOODC = KADBECGIMPD.IFDFHJLCHAE();
			this.JIPIPOLKPCF = KADBECGIMPD.LPKJHMGLCKA();
			this.PNKNHBJELOB = KADBECGIMPD.DPLAJNEDGBL();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077CB RID: 30667 RVA: 0x00396370 File Offset: 0x00394570
		public void NHHAANEMJCK(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.ANPEIKGEDHJ();
			this.MCHIDGLEDID = KADBECGIMPD.KKOKFLMMAAK();
			this.CBJBGGAOODC = KADBECGIMPD.DOJKJHMJJNK();
			this.JIPIPOLKPCF = KADBECGIMPD.BFPHBMDMODH();
			this.PNKNHBJELOB = KADBECGIMPD.PNBECHOLCJM();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077CC RID: 30668 RVA: 0x003963CC File Offset: 0x003945CC
		public void ABKLGDFPBEJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.DNIIFBAIPBE();
			this.MCHIDGLEDID = KADBECGIMPD.HHLDBAEFNMJ();
			this.CBJBGGAOODC = KADBECGIMPD.HHLDBAEFNMJ();
			this.JIPIPOLKPCF = KADBECGIMPD.NCODBGMGNFD();
			this.PNKNHBJELOB = KADBECGIMPD.LPKJHMGLCKA();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077CD RID: 30669 RVA: 0x00396428 File Offset: 0x00394628
		public void ODAFODFACKN(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.HHMGLDMFCPF();
			this.MCHIDGLEDID = KADBECGIMPD.KKOKFLMMAAK();
			this.CBJBGGAOODC = KADBECGIMPD.IFDFHJLCHAE();
			this.JIPIPOLKPCF = KADBECGIMPD.DPLAJNEDGBL();
			this.PNKNHBJELOB = KADBECGIMPD.BFPHBMDMODH();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077CE RID: 30670 RVA: 0x00396482 File Offset: 0x00394682
		public override string ToString()
		{
			return string.Format("{0}-{1}={2}", this.MCHIDGLEDID, this.JIPIPOLKPCF, this.CBJBGGAOODC);
		}

		// Token: 0x060077CF RID: 30671 RVA: 0x003964AC File Offset: 0x003946AC
		public void OLGEDIFBGNL(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.HHMGLDMFCPF();
			this.MCHIDGLEDID = KADBECGIMPD.DOJKJHMJJNK();
			this.CBJBGGAOODC = KADBECGIMPD.IFDFHJLCHAE();
			this.JIPIPOLKPCF = KADBECGIMPD.NCODBGMGNFD();
			this.PNKNHBJELOB = KADBECGIMPD.BFPHBMDMODH();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077D0 RID: 30672 RVA: 0x00396506 File Offset: 0x00394706
		public virtual string PDMPLOPPLBI()
		{
			return string.Format("https://www.youtube.com/watch?v=eP9-zycoHLk", this.MCHIDGLEDID, this.JIPIPOLKPCF, this.CBJBGGAOODC);
		}

		// Token: 0x060077D1 RID: 30673 RVA: 0x0039652E File Offset: 0x0039472E
		public virtual string CEOAKEEKAMH()
		{
			return string.Format("onHyperLinkActivated: ", this.MCHIDGLEDID, this.JIPIPOLKPCF, this.CBJBGGAOODC);
		}

		// Token: 0x060077D2 RID: 30674 RVA: 0x00396558 File Offset: 0x00394758
		public void KIALEELDFDJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.HFOPFEJDJFG();
			this.MCHIDGLEDID = KADBECGIMPD.HHLDBAEFNMJ();
			this.CBJBGGAOODC = KADBECGIMPD.CLPEKGGAMAI();
			this.JIPIPOLKPCF = KADBECGIMPD.JJJJAGJCOGD();
			this.PNKNHBJELOB = KADBECGIMPD.FDIDEGHPJPF();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077D3 RID: 30675 RVA: 0x003965B4 File Offset: 0x003947B4
		public void FEEODCOLNIN(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.DCGEOFHNBCN();
			this.MCHIDGLEDID = KADBECGIMPD.HHLDBAEFNMJ();
			this.CBJBGGAOODC = KADBECGIMPD.KDNDJNEGBDI();
			this.JIPIPOLKPCF = KADBECGIMPD.KDELAFDDGJH();
			this.PNKNHBJELOB = KADBECGIMPD.PNBECHOLCJM();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077D4 RID: 30676 RVA: 0x0039660E File Offset: 0x0039480E
		public virtual string DHCBHNAAJKI()
		{
			return string.Format("wpn_med2", this.MCHIDGLEDID, this.JIPIPOLKPCF, this.CBJBGGAOODC);
		}

		// Token: 0x060077D5 RID: 30677 RVA: 0x00396638 File Offset: 0x00394838
		public void MPMELFMBFAN(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.HFOPFEJDJFG();
			this.MCHIDGLEDID = KADBECGIMPD.IFDFHJLCHAE();
			this.CBJBGGAOODC = KADBECGIMPD.IFDFHJLCHAE();
			this.JIPIPOLKPCF = KADBECGIMPD.KDELAFDDGJH();
			this.PNKNHBJELOB = KADBECGIMPD.JJJJAGJCOGD();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077D7 RID: 30679 RVA: 0x00396692 File Offset: 0x00394892
		public virtual string NHDAHNIOAFD()
		{
			return string.Format("No location found baseid=", this.MCHIDGLEDID, this.JIPIPOLKPCF, this.CBJBGGAOODC);
		}

		// Token: 0x060077D8 RID: 30680 RVA: 0x003966BA File Offset: 0x003948BA
		public override string IGJFJGKAFIE()
		{
			return string.Format("MidBlendLut", this.MCHIDGLEDID, this.JIPIPOLKPCF, this.CBJBGGAOODC);
		}

		// Token: 0x060077D9 RID: 30681 RVA: 0x003966E4 File Offset: 0x003948E4
		public void NCKKHDFHBEF(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.IJDIMHAEAIE();
			this.MCHIDGLEDID = KADBECGIMPD.KKOKFLMMAAK();
			this.CBJBGGAOODC = KADBECGIMPD.HDBGOLAFOBK();
			this.JIPIPOLKPCF = KADBECGIMPD.DPLAJNEDGBL();
			this.PNKNHBJELOB = KADBECGIMPD.KDELAFDDGJH();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077DA RID: 30682 RVA: 0x00396740 File Offset: 0x00394940
		public void OCPAHLAGCAI(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.DNIIFBAIPBE();
			this.MCHIDGLEDID = KADBECGIMPD.HDBGOLAFOBK();
			this.CBJBGGAOODC = KADBECGIMPD.HDBGOLAFOBK();
			this.JIPIPOLKPCF = KADBECGIMPD.BFPHBMDMODH();
			this.PNKNHBJELOB = KADBECGIMPD.BFPHBMDMODH();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077DB RID: 30683 RVA: 0x0039679A File Offset: 0x0039499A
		public virtual string BHLHEJCILKF()
		{
			return string.Format("<color='#303030'><size=10>{0}</size></color>\n<size=16><b>{1}</b></size><color='#302020'>  {3}</color>{2}", this.MCHIDGLEDID, this.JIPIPOLKPCF, this.CBJBGGAOODC);
		}

		// Token: 0x060077DC RID: 30684 RVA: 0x003967C2 File Offset: 0x003949C2
		public virtual string JJPMKNKFPPN()
		{
			return string.Format("id", this.MCHIDGLEDID, this.JIPIPOLKPCF, this.CBJBGGAOODC);
		}

		// Token: 0x060077DD RID: 30685 RVA: 0x003967EA File Offset: 0x003949EA
		public virtual string GIOCLFJADKN()
		{
			return string.Format(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.MCHIDGLEDID, this.JIPIPOLKPCF, this.CBJBGGAOODC);
		}

		// Token: 0x060077DE RID: 30686 RVA: 0x00396812 File Offset: 0x00394A12
		public virtual string NMBKBGNBAEM()
		{
			return string.Format("ShotgunFire", this.MCHIDGLEDID, this.JIPIPOLKPCF, this.CBJBGGAOODC);
		}

		// Token: 0x060077DF RID: 30687 RVA: 0x0039683C File Offset: 0x00394A3C
		public void KKLMGOBGMHD(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.IJDIMHAEAIE();
			this.MCHIDGLEDID = KADBECGIMPD.IFDFHJLCHAE();
			this.CBJBGGAOODC = KADBECGIMPD.KDNDJNEGBDI();
			this.JIPIPOLKPCF = KADBECGIMPD.FDIDEGHPJPF();
			this.PNKNHBJELOB = KADBECGIMPD.LPKJHMGLCKA();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077E0 RID: 30688 RVA: 0x00396896 File Offset: 0x00394A96
		public virtual string AOJIJIPBKPB()
		{
			return string.Format("IdleStun", this.MCHIDGLEDID, this.JIPIPOLKPCF, this.CBJBGGAOODC);
		}

		// Token: 0x060077E1 RID: 30689 RVA: 0x003968C0 File Offset: 0x00394AC0
		public void BIGEEOCOICN(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.DCGEOFHNBCN();
			this.MCHIDGLEDID = KADBECGIMPD.KKOKFLMMAAK();
			this.CBJBGGAOODC = KADBECGIMPD.KKOKFLMMAAK();
			this.JIPIPOLKPCF = KADBECGIMPD.LPKJHMGLCKA();
			this.PNKNHBJELOB = KADBECGIMPD.KDELAFDDGJH();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077E2 RID: 30690 RVA: 0x0039691A File Offset: 0x00394B1A
		public virtual string NCNNJHIIAFM()
		{
			return string.Format("Add random value", this.MCHIDGLEDID, this.JIPIPOLKPCF, this.CBJBGGAOODC);
		}

		// Token: 0x060077E3 RID: 30691 RVA: 0x00396944 File Offset: 0x00394B44
		public void KAOKKLLOFBE(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.EJPMFEJBGMN();
			this.MCHIDGLEDID = KADBECGIMPD.HDBGOLAFOBK();
			this.CBJBGGAOODC = KADBECGIMPD.IFDFHJLCHAE();
			this.JIPIPOLKPCF = KADBECGIMPD.DHCMILPKJAL();
			this.PNKNHBJELOB = KADBECGIMPD.FDIDEGHPJPF();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077E4 RID: 30692 RVA: 0x0039699E File Offset: 0x00394B9E
		public virtual string OCJAOJLHOFO()
		{
			return string.Format("u_UniqueShadowBlockerWidth", this.MCHIDGLEDID, this.JIPIPOLKPCF, this.CBJBGGAOODC);
		}

		// Token: 0x060077E5 RID: 30693 RVA: 0x003969C8 File Offset: 0x00394BC8
		public void HLJFBOLPOMG(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.HHMGLDMFCPF();
			this.MCHIDGLEDID = KADBECGIMPD.HDBGOLAFOBK();
			this.CBJBGGAOODC = KADBECGIMPD.KDNDJNEGBDI();
			this.JIPIPOLKPCF = KADBECGIMPD.LPKJHMGLCKA();
			this.PNKNHBJELOB = KADBECGIMPD.JJJJAGJCOGD();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077E6 RID: 30694 RVA: 0x00396A24 File Offset: 0x00394C24
		public void LBINIIGHCMG(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.DMABDIGCLKA();
			this.MCHIDGLEDID = KADBECGIMPD.HHLDBAEFNMJ();
			this.CBJBGGAOODC = KADBECGIMPD.IFDFHJLCHAE();
			this.JIPIPOLKPCF = KADBECGIMPD.DPLAJNEDGBL();
			this.PNKNHBJELOB = KADBECGIMPD.FDIDEGHPJPF();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x00396A7E File Offset: 0x00394C7E
		public virtual string HLHHDFFDHGL()
		{
			return string.Format("KatanaVerticalSwing", this.MCHIDGLEDID, this.JIPIPOLKPCF, this.CBJBGGAOODC);
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x00396AA8 File Offset: 0x00394CA8
		public void MBJKBKOLBKE(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.DCGEOFHNBCN();
			this.MCHIDGLEDID = KADBECGIMPD.AGNKAFLKCAG();
			this.CBJBGGAOODC = KADBECGIMPD.KKOKFLMMAAK();
			this.JIPIPOLKPCF = KADBECGIMPD.FDIDEGHPJPF();
			this.PNKNHBJELOB = KADBECGIMPD.PNBECHOLCJM();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077E9 RID: 30697 RVA: 0x00396B04 File Offset: 0x00394D04
		public void KHOPKCFJPBF(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.DCGEOFHNBCN();
			this.MCHIDGLEDID = KADBECGIMPD.AGNKAFLKCAG();
			this.CBJBGGAOODC = KADBECGIMPD.IFDFHJLCHAE();
			this.JIPIPOLKPCF = KADBECGIMPD.DPLAJNEDGBL();
			this.PNKNHBJELOB = KADBECGIMPD.LPKJHMGLCKA();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077EA RID: 30698 RVA: 0x00396B60 File Offset: 0x00394D60
		public void EFGBDBAOFCJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.HHMGLDMFCPF();
			this.MCHIDGLEDID = KADBECGIMPD.DOJKJHMJJNK();
			this.CBJBGGAOODC = KADBECGIMPD.AGNKAFLKCAG();
			this.JIPIPOLKPCF = KADBECGIMPD.PNBECHOLCJM();
			this.PNKNHBJELOB = KADBECGIMPD.PNBECHOLCJM();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077EB RID: 30699 RVA: 0x00396BBC File Offset: 0x00394DBC
		public void NJOCHFIPEBI(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.DMABDIGCLKA();
			this.MCHIDGLEDID = KADBECGIMPD.KDNDJNEGBDI();
			this.CBJBGGAOODC = KADBECGIMPD.KDNDJNEGBDI();
			this.JIPIPOLKPCF = KADBECGIMPD.FDIDEGHPJPF();
			this.PNKNHBJELOB = KADBECGIMPD.JJJJAGJCOGD();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077EC RID: 30700 RVA: 0x00396C18 File Offset: 0x00394E18
		public void MPCIALDHHKN(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.DMABDIGCLKA();
			this.MCHIDGLEDID = KADBECGIMPD.KDNDJNEGBDI();
			this.CBJBGGAOODC = KADBECGIMPD.HDBGOLAFOBK();
			this.JIPIPOLKPCF = KADBECGIMPD.BFPHBMDMODH();
			this.PNKNHBJELOB = KADBECGIMPD.NCODBGMGNFD();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077ED RID: 30701 RVA: 0x00396C74 File Offset: 0x00394E74
		public void GNFKNBMMCNM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LIEMOHDFBBL = KADBECGIMPD.DCGEOFHNBCN();
			this.MCHIDGLEDID = KADBECGIMPD.AGNKAFLKCAG();
			this.CBJBGGAOODC = KADBECGIMPD.KDNDJNEGBDI();
			this.JIPIPOLKPCF = KADBECGIMPD.FDIDEGHPJPF();
			this.PNKNHBJELOB = KADBECGIMPD.NCODBGMGNFD();
			this.JNLLLJAADHJ = new EJDGMNEEOGN.EMOEAOFEKCO(this.PNKNHBJELOB);
		}

		// Token: 0x060077EE RID: 30702 RVA: 0x00396CCE File Offset: 0x00394ECE
		public virtual string PFNDMCPAGLP()
		{
			return string.Format("<color='#103000'>", this.MCHIDGLEDID, this.JIPIPOLKPCF, this.CBJBGGAOODC);
		}

		// Token: 0x0400115B RID: 4443
		public long LIEMOHDFBBL;

		// Token: 0x0400115C RID: 4444
		public string JIPIPOLKPCF;

		// Token: 0x0400115D RID: 4445
		public int CBJBGGAOODC;

		// Token: 0x0400115E RID: 4446
		public int MCHIDGLEDID;

		// Token: 0x0400115F RID: 4447
		public string PNKNHBJELOB;

		// Token: 0x04001160 RID: 4448
		public EJDGMNEEOGN.EMOEAOFEKCO JNLLLJAADHJ;
	}
}
