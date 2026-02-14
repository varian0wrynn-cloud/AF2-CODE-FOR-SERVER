using System;
using System.Collections.Generic;
using System.Xml;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Token: 0x02000178 RID: 376
internal class MDEKJCCIDIA
{
	// Token: 0x060051EA RID: 20970 RVA: 0x0025CE90 File Offset: 0x0025B090
	private void KMGAKKDABEK(ONKDCGNBALK ONPHLHKAGFP)
	{
		if (this.KBKJNEFDCFO != null)
		{
			int ilfhhdnjhnm = 1;
			if (this.AIIHCNKNNID != null)
			{
				ilfhhdnjhnm = this.AIIHCNKNNID.LPBLKNELCLO;
			}
			switch (this.KBKJNEFDCFO.BDJGKIEBGCA)
			{
			case MDEKJCCIDIA.EIHOIMIOGKJ.ResLot:
				this.KBKJNEFDCFO.BDHHPAEHFHG.JGGGGKHDNIP(ONPHLHKAGFP.OCHCODJIPHJ, 0f, IIBEEKCAAHK.ECOFBCMPIDO, IIBEEKCAAHK.ECOFBCMPIDO, IIBEEKCAAHK.ECOFBCMPIDO, ilfhhdnjhnm);
				return;
			case MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot:
				this.KBKJNEFDCFO.BDHHPAEHFHG.JGGGGKHDNIP(ONPHLHKAGFP.OCHCODJIPHJ, 0f, IIBEEKCAAHK.ECOFBCMPIDO, IIBEEKCAAHK.ECOFBCMPIDO, IIBEEKCAAHK.ECOFBCMPIDO, this.KBKJNEFDCFO.ILFHHDNJHNM);
				return;
			case MDEKJCCIDIA.EIHOIMIOGKJ.WeaponLot:
			{
				GUIStyle style = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperRight,
					wordWrap = true,
					richText = true,
					font = GuiProcessor.IKGFHGKKCPG.rusfont,
					fontSize = 14
				};
				float num = ONPHLHKAGFP.OCHCODJIPHJ.y + 2f;
				foreach (MDEKJCCIDIA.KCFIPOJDHGB kcfipojdhgb in this.DDKLFIHFFAO)
				{
					Rect rect = new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 4f, num, ONPHLHKAGFP.OCHCODJIPHJ.width - 8f, 58f);
					Rect rect2 = rect;
					rect2.x += ONPHLHKAGFP.OCBAOFLJBGP.OCHCODJIPHJ.x;
					rect2.y += ONPHLHKAGFP.OCBAOFLJBGP.OCHCODJIPHJ.y;
					GUIStyle ofpnedeamab = new GUIStyle
					{
						font = GuiProcessor.IKGFHGKKCPG.rusfont3,
						richText = true,
						alignment = TextAnchor.UpperLeft
					};
					GUI.Box(rect, "");
					kcfipojdhgb.MEJMEKODJAE.GKDJCJKMBEN(rect, ofpnedeamab);
					if (Event.current.type == EventType.MouseDown && Input.GetMouseButton(1) && rect2.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF))
					{
						this.DGMMBBEIMHI(kcfipojdhgb.MEJMEKODJAE);
						Debug.Log("MB Down lot=" + kcfipojdhgb.MEJMEKODJAE.BDHHPAEHFHG.BNIHFBMEPAB);
					}
					Rect position = rect;
					position.y += 5f;
					position.width -= 5f;
					string text = string.Format("{0} / {1}", JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, kcfipojdhgb.FKEDAOOHPPB, false), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, kcfipojdhgb.KAFDCOOEPID, false));
					if (kcfipojdhgb.JGNLJOJBAIB == 1)
					{
						text = string.Format("{0}", JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, kcfipojdhgb.FKEDAOOHPPB, false));
					}
					GUI.Label(position, text, style);
					Rect position2 = new Rect(rect.x + rect.width - 90f, rect.y + rect.height - 34f, 85f, 20f);
					float num2 = (float)(kcfipojdhgb.AONGINFINPD - DateTime.Now).TotalMinutes;
					Rect ochcodjiphj = new Rect(rect.x + 64f, rect.y + rect.height - 8f, rect.width - 72f, 6f);
					GameInterface.getI.renderPBar(ochcodjiphj, 1440f - num2, 1440f, 4, "", true);
					if (kcfipojdhgb.KLKFECAJPNN != JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI && kcfipojdhgb.JGNLJOJBAIB != 1 && GUI.Button(position2, JNBICAJIJMM.LEBHCLDODNI("auk_pbuykey")))
					{
						this.DBHJMNFNDDG = kcfipojdhgb;
						if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KFODJJIHNHP >= kcfipojdhgb.KAFDCOOEPID)
						{
							NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(347, kcfipojdhgb.EENFJPJEDFM);
							FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("cash.ogg", 0.5f);
							EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
							try
							{
								epmphjgalbe.OBCCLNMPGEJ((long)this.KBKJNEFDCFO.BDHHPAEHFHG.LPFKFNLHGBI);
								epmphjgalbe.GOMLLPFFPNP(this.GHKNANODLOI);
								NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(346, epmphjgalbe.JDPHBLHOLAD());
							}
							finally
							{
								epmphjgalbe.LMBPNFHKNGA();
							}
						}
					}
					if (kcfipojdhgb.KLKFECAJPNN != JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI)
					{
						position2.x -= 88f;
						if (kcfipojdhgb.JGNLJOJBAIB == 1)
						{
							position2.x += 88f;
						}
						if (GUI.Button(position2, JNBICAJIJMM.LEBHCLDODNI("auk_pstavka")))
						{
							this.DBHJMNFNDDG = kcfipojdhgb;
							string edaphmjenpk = string.Format(JNBICAJIJMM.LEBHCLDODNI("auk_pstinf"), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, kcfipojdhgb.FKEDAOOHPPB, false), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, kcfipojdhgb.KAFDCOOEPID, false));
							int num3 = (int)((float)kcfipojdhgb.FKEDAOOHPPB * 1.1f);
							num3 = (int)Mathf.Clamp((float)num3, (float)kcfipojdhgb.FKEDAOOHPPB, (float)kcfipojdhgb.KAFDCOOEPID * 0.99f);
							if (kcfipojdhgb.JGNLJOJBAIB == 1)
							{
								num3 = (int)((float)kcfipojdhgb.FKEDAOOHPPB * 1.1f);
							}
							JDCEFOFMGHB.IKGFHGKKCPG.NNMBEJIPPNF(JNBICAJIJMM.LEBHCLDODNI("auk_pstavka"), edaphmjenpk, (long)num3, new ONKDCGNBALK.CMMHGMILOIM(this.JGLDGBHDLFG), null);
						}
					}
					num += 58f;
				}
				GUIStyle style2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleCenter,
					wordWrap = true,
					richText = true,
					font = GuiProcessor.IKGFHGKKCPG.rusfont2,
					fontSize = 20
				};
				Rect position3 = new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 64f, ONPHLHKAGFP.OCHCODJIPHJ.y + 487f, 66f, 30f);
				string text2 = string.Format("{0}/{1}", this.GHKNANODLOI + 1, 1 + this.CMKDPADIMBO / 8);
				GUI.Label(position3, text2, style2);
				Rect position4 = new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 10f, ONPHLHKAGFP.OCHCODJIPHJ.y + 485f, 50f, 30f);
				if (GUI.Button(position4, "<<") && this.GHKNANODLOI > 0)
				{
					EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
					try
					{
						epmphjgalbe2.OBCCLNMPGEJ((long)this.KBKJNEFDCFO.BDHHPAEHFHG.LPFKFNLHGBI);
						epmphjgalbe2.GOMLLPFFPNP(this.GHKNANODLOI - 1);
						NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(346, epmphjgalbe2.JDPHBLHOLAD());
					}
					finally
					{
						epmphjgalbe2.LMBPNFHKNGA();
					}
				}
				position4.x += 120f;
				if (GUI.Button(position4, ">>"))
				{
					int num4 = this.CMKDPADIMBO / 8;
					if (this.GHKNANODLOI < num4)
					{
						EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
						try
						{
							epmphjgalbe3.OBCCLNMPGEJ((long)this.KBKJNEFDCFO.BDHHPAEHFHG.LPFKFNLHGBI);
							epmphjgalbe3.GOMLLPFFPNP(this.GHKNANODLOI + 1);
							NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(346, epmphjgalbe3.JDPHBLHOLAD());
						}
						finally
						{
							epmphjgalbe3.LMBPNFHKNGA();
						}
					}
				}
				break;
			}
			default:
				return;
			}
		}
	}

	// Token: 0x060051EB RID: 20971 RVA: 0x0025D630 File Offset: 0x0025B830
	public void LKBBEBPAHMG(ONKDCGNBALK OJIMHKHFOJI)
	{
		if (this.EFIBDEMHFDD.IHEILFHMLAG < 0)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
			return;
		}
		EKBAPCMPANI ekbapcmpani = this.EFIBDEMHFDD.LACAJHOHACK[this.EFIBDEMHFDD.IHEILFHMLAG] as EKBAPCMPANI;
		if (ekbapcmpani == null)
		{
			return;
		}
		if (!this.COKDFMFFDAE.MJHGLLIJMIM)
		{
			if (this.COKDFMFFDAE.DLHPFGHOINI >= (float)this.COKDFMFFDAE.BGGJKOMAKEE - 0.5f)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("invn_rec27"));
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
				return;
			}
			if (this.COKDFMFFDAE.DLHPFGHOINI >= (float)this.COKDFMFFDAE.BGGJKOMAKEE - ekbapcmpani.LODGJCMEGAI.OBEOJCGHOGL)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.LEBHCLDODNI("error"), JNBICAJIJMM.LEBHCLDODNI("invn_rec28"));
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
				return;
			}
		}
		JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO(3f, 0, JNBICAJIJMM.LEBHCLDODNI("invn_rec29"), new ONKDCGNBALK.CMMHGMILOIM(this.KNNILCKBAGM), false);
	}

	// Token: 0x060051EC RID: 20972 RVA: 0x0025D768 File Offset: 0x0025B968
	public void CDJPHCINIHE(HBPNMNGOFMA KADBECGIMPD)
	{
		JDCEFOFMGHB.JFIDAGABKID().BMOFIBGMIBK(this.ONGEHMJIMLO);
		this.DEFEALCKOKF = KADBECGIMPD.HFOPFEJDJFG();
		this.CDIFAABIAEG = KADBECGIMPD.KJIOFDCKIKO();
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("_", 248f);
		JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO(1917f, 0, JNBICAJIJMM.CELEPPAEKAB("ComeHere"), new ONKDCGNBALK.CMMHGMILOIM(this.ICCBGBDMNDI), false);
	}

	// Token: 0x060051ED RID: 20973 RVA: 0x0025D7D8 File Offset: 0x0025B9D8
	public void PDDMKCJLEBM(ONKDCGNBALK ONPHLHKAGFP)
	{
		if (GameInterface.getI.useWeapon != null)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-87, GameInterface.getI.useWeapon.LPFKFNLHGBI);
		}
	}

	// Token: 0x060051EE RID: 20974 RVA: 0x0025D804 File Offset: 0x0025BA04
	public int LPACNNDMOCN(EKBAPCMPANI MEJMEKODJAE)
	{
		if (JDCEFOFMGHB.IKGFHGKKCPG.MDBEKDJJHBI)
		{
			return -1;
		}
		if (MEJMEKODJAE == null)
		{
			return -1;
		}
		if (JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(this.ELLIGFJNLGM) != null)
		{
			return -1;
		}
		GUI.skin = GuiProcessor.IKGFHGKKCPG.alterSkin;
		this.EBKMEHACMJE = MEJMEKODJAE;
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		Vector2 vector2 = new Vector2(vector.x + 359f, vector.y - 1488f);
		if (vector2.x + 906f > (float)(Screen.width - 19))
		{
			vector2.x = (float)(Screen.width - -66 - 187);
		}
		if (vector2.y + this.GANOCEBJKJE > (float)(Screen.height - -5))
		{
			vector2.y = (float)(Screen.height - -94) - this.GANOCEBJKJE;
		}
		int num = JDCEFOFMGHB.JFIDAGABKID().DIBNCPKGGOF + 1;
		this.JDFMHNPDDHJ = false;
		if (!this.IHNJOHJCBMK)
		{
			GUI.ModalWindow(num, new Rect(vector2.x, vector2.y, 22f, this.GANOCEBJKJE), new GUI.WindowFunction(this.EAOLHBCPOJH), "demoLong");
		}
		return num;
	}

	// Token: 0x060051EF RID: 20975 RVA: 0x0025D93C File Offset: 0x0025BB3C
	public void CIIFCFGPPLD(HBPNMNGOFMA KADBECGIMPD)
	{
		this.ANBIJAKLCPC = KADBECGIMPD.HDBGOLAFOBK();
		this.GHKNANODLOI = KADBECGIMPD.HDBGOLAFOBK();
		this.CMKDPADIMBO = KADBECGIMPD.HDBGOLAFOBK();
		this.ANNJBBJIJLC.FNMCIACNOMH = false;
		this.ANNJBBJIJLC.MPKCOJHJIIB();
		this.DDKLFIHFFAO.Clear();
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			MDEKJCCIDIA.KCFIPOJDHGB kcfipojdhgb = new MDEKJCCIDIA.KCFIPOJDHGB();
			kcfipojdhgb.MPCPDBAANCL(KADBECGIMPD);
			this.DDKLFIHFFAO.Add(kcfipojdhgb);
			Debug.Log("new wpn lot " + kcfipojdhgb.EENFJPJEDFM);
		}
		Debug.Log("*** updateDetailWpnInfo  ");
	}

	// Token: 0x060051F0 RID: 20976 RVA: 0x0025D9D8 File Offset: 0x0025BBD8
	public void FPODOJJLNCD(HBPNMNGOFMA KADBECGIMPD)
	{
		if (this.MEOJOEJBNDI == null)
		{
			return;
		}
		this.JJNNIDBAEKL = null;
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().PLHAGCDJLPA(493f, 8f, JNBICAJIJMM.OOOKJHOHPNN("FBIK chain contains no nodes."), true);
		OCLNJMKDBKB oclnjmkdbkb = new OCLNJMKDBKB(onkdcgnbalk, 1724f, 1821f, 1436f, this.MEOJOEJBNDI.BDHHPAEHFHG, 1);
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, oclnjmkdbkb.OCHCODJIPHJ.x + oclnjmkdbkb.OCHCODJIPHJ.width + 549f, oclnjmkdbkb.OCHCODJIPHJ.y, this.MEOJOEJBNDI.NBKLEELCDBJ(true), false);
		lcoljopgdll.DFIGKKMMIAF = -31;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont3;
		new LCOLJOPGDLL(onkdcgnbalk, oclnjmkdbkb.OCHCODJIPHJ.x + oclnjmkdbkb.OCHCODJIPHJ.width + 1918f, oclnjmkdbkb.OCHCODJIPHJ.y + 1537f, string.Format(JNBICAJIJMM.PGJCPFNJNPM("Mouse X"), this.MEOJOEJBNDI.ILFHHDNJHNM), false).DFIGKKMMIAF = 2;
		float num = oclnjmkdbkb.OCHCODJIPHJ.y + oclnjmkdbkb.OCHCODJIPHJ.height + 1336f;
		KADBECGIMPD.AGNKAFLKCAG();
		int num2 = KADBECGIMPD.DOJKJHMJJNK();
		int num3 = KADBECGIMPD.LDLKLPJBIJN();
		int num4 = KADBECGIMPD.DOJKJHMJJNK();
		int num5 = KADBECGIMPD.KKOKFLMMAAK();
		new LCOLJOPGDLL(onkdcgnbalk, 193f, num, string.Format(JNBICAJIJMM.PGJCPFNJNPM("WorkerHammer2"), num4), false).DFIGKKMMIAF = 79;
		num += 1417f;
		new LCOLJOPGDLL(onkdcgnbalk, 263f, num, string.Format(JNBICAJIJMM.OOOKJHOHPNN("file:///"), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)Mathf.RoundToInt((float)num2), true)), false).DFIGKKMMIAF = -50;
		num += 1558f;
		new LCOLJOPGDLL(onkdcgnbalk, 224f, num, string.Format(JNBICAJIJMM.CDDCIKKDFMP("_BloomTex"), JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(1L, (long)Mathf.RoundToInt((float)num3), false)), false).DFIGKKMMIAF = -69;
		num += 1535f;
		new LCOLJOPGDLL(onkdcgnbalk, 1071f, num, string.Format(JNBICAJIJMM.DCEBAJIILPC("H:mm:ss"), JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(1L, (long)Mathf.RoundToInt((float)num5), true)), false).DFIGKKMMIAF = 40;
		num += 77f;
		num += 1273f;
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 482f, num, JNBICAJIJMM.DCEBAJIILPC("IdleReadyLook"), false);
		lcoljopgdll2.DFIGKKMMIAF = 68;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont3;
		num += 245f;
		this.BBOKGAOOIMG = (long)Mathf.RoundToInt((float)(num5 + num2) / 1886f);
		if (this.BBOKGAOOIMG == 0L)
		{
			this.BBOKGAOOIMG = (long)Mathf.RoundToInt(((float)this.MEOJOEJBNDI.LEADKFMCFCC * 1656f + (float)this.MEOJOEJBNDI.DELMOBCNBDB) / (float)this.MEOJOEJBNDI.BDHHPAEHFHG.HOALBMDJNDM);
		}
		if (this.BBOKGAOOIMG == 0L)
		{
			this.BBOKGAOOIMG = 0L;
		}
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, 1337f, num, onkdcgnbalk.OCHCODJIPHJ.width - 292f, 871f, "sunshine_ShadowToWorldScale", 1, null);
		num += 1269f;
		this.MPBHBNBJBLA = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 733f, num, JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, this.BBOKGAOOIMG, true), false)
		{
			DFIGKKMMIAF = -2,
			HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont
		};
		num += 1324f;
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 524f, egcaadaabpp.OCHCODJIPHJ.y + 1382f, 1022f, 711f, JNBICAJIJMM.BDKHMOOFHHK("auk_pstinf"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.MPHGGAKBHDE));
		num = egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height + 1949f;
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(onkdcgnbalk, 80f, num, JNBICAJIJMM.NGALDMFKMJH("gi_fridgice"), false);
		lcoljopgdll3.DFIGKKMMIAF = 79;
		lcoljopgdll3.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont3;
		num += 303f;
		EGCAADAABPP egcaadaabpp2 = new EGCAADAABPP(onkdcgnbalk, 1340f, num, onkdcgnbalk.OCHCODJIPHJ.width - 989f, 1502f, "KatanaReadyHigh", 1, null);
		num += 648f;
		this.MGPDHMPIEFB = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp2.OCHCODJIPHJ.x + 371f, num, JLFJEGIPIMM.PKGMBFEMKGP().MNMIJFNPIPI(1L, this.BBOKGAOOIMG * (long)this.MEOJOEJBNDI.ILFHHDNJHNM, false), true)
		{
			DFIGKKMMIAF = -124,
			HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont
		};
		num += 603f;
		long kfodjjihnhp = (long)(1 + Mathf.RoundToInt((float)(this.BBOKGAOOIMG * (long)this.MEOJOEJBNDI.ILFHHDNJHNM) * 1872f));
		num = egcaadaabpp2.OCHCODJIPHJ.y + egcaadaabpp2.OCHCODJIPHJ.height + 50f;
		LCOLJOPGDLL lcoljopgdll4 = new LCOLJOPGDLL(onkdcgnbalk, 1802f, num, JNBICAJIJMM.BDKHMOOFHHK("HeelClick"), false);
		lcoljopgdll4.DFIGKKMMIAF = -53;
		lcoljopgdll4.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont3;
		num += 402f;
		EGCAADAABPP egcaadaabpp3 = new EGCAADAABPP(onkdcgnbalk, 328f, num, onkdcgnbalk.OCHCODJIPHJ.width - 752f, 749f, "The 'color' command requires a color parameter of RRGGBBAA:\n", 1, null);
		num += 1799f;
		this.HMJIHCHAEFN = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp3.OCHCODJIPHJ.x + 511f, num, JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC(1L, kfodjjihnhp, true), true)
		{
			DFIGKKMMIAF = 95,
			HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont
		};
		num += 711f;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 671f - 568f, onkdcgnbalk.OCHCODJIPHJ.height - 1250f, 494f, 1766f, JNBICAJIJMM.CELEPPAEKAB("OfficeSittingHandRestFingerTap"), 38, null, new ONKDCGNBALK.CMMHGMILOIM(this.MPHGGAKBHDE));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 608f - 102f, onkdcgnbalk.OCHCODJIPHJ.height - 1317f, 756f, 1381f, JNBICAJIJMM.OOOKJHOHPNN("Censor OK. Object:"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.BLPLADOIPJG));
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(false);
	}

	// Token: 0x060051F1 RID: 20977 RVA: 0x0025E040 File Offset: 0x0025C240
	public void JLONPAMJDGL(ONKDCGNBALK JMBKDINHDLO)
	{
		Debug.Log("SoccerWalk");
		this.DCFMECEHGEM = JMBKDINHDLO.ODFEKBJCFMN;
		if (this.BBOKGAOOIMG > this.DCFMECEHGEM)
		{
			this.DCFMECEHGEM = this.BBOKGAOOIMG;
		}
		this.LCLCFPKANAH();
		Debug.Log("TenkokuModule");
	}

	// Token: 0x060051F2 RID: 20978 RVA: 0x0025E090 File Offset: 0x0025C290
	public void CEDPLPDLPJB(JNHLAGHJBAA ONPHLHKAGFP, JNHLAGHJBAA.FPAEEADMCIE HEABEPINGED)
	{
		if (HEABEPINGED != null && HEABEPINGED.NLIKAGGPANH != null)
		{
			this.ANNJBBJIJLC.MPKCOJHJIIB();
			this.ANNJBBJIJLC.FNMCIACNOMH = false;
			MDEKJCCIDIA.KCFIPOJDHGB kcfipojdhgb = HEABEPINGED.NLIKAGGPANH as MDEKJCCIDIA.KCFIPOJDHGB;
			switch (kcfipojdhgb.BDJGKIEBGCA)
			{
			case MDEKJCCIDIA.EIHOIMIOGKJ.ResLot:
				this.KBKJNEFDCFO = kcfipojdhgb;
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(340, this.KBKJNEFDCFO.BDHHPAEHFHG.LPFKFNLHGBI);
				return;
			case MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot:
				this.KBKJNEFDCFO = kcfipojdhgb;
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(345, this.KBKJNEFDCFO.EENFJPJEDFM);
				return;
			case MDEKJCCIDIA.EIHOIMIOGKJ.WeaponLot:
			{
				this.KBKJNEFDCFO = kcfipojdhgb;
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.OBCCLNMPGEJ((long)this.KBKJNEFDCFO.BDHHPAEHFHG.LPFKFNLHGBI);
					epmphjgalbe.GOMLLPFFPNP(0);
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(346, epmphjgalbe.JDPHBLHOLAD());
				}
				finally
				{
					epmphjgalbe.LMBPNFHKNGA();
				}
				break;
			}
			default:
				return;
			}
		}
	}

	// Token: 0x060051F3 RID: 20979 RVA: 0x0025E190 File Offset: 0x0025C390
	public void DJJBCHFACGN(ONKDCGNBALK JMAKEAHMLMI)
	{
		if (this.KKLEEIBNIBC != null)
		{
			if (this.KKLEEIBNIBC.MBKMKGABBGE == 114 && (this.KKLEEIBNIBC.JGNIDDBNGGP == 2 || this.AMBNJGDIDED == -114) && JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.NAFGMKJPLPC.Count > 0)
			{
				JDCEFOFMGHB.JFIDAGABKID().KGHDLHHLLIC(JNBICAJIJMM.EDKGBBIIBBC().HEIBEHAEHBM("Gesture Crowd Pump"), JNBICAJIJMM.CLIMNFDGOEG().NLJOLOBPCBJ("Loading "));
				this.KKLEEIBNIBC.BFHKBOPOFGB = false;
				this.KKLEEIBNIBC = null;
				JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB = true;
				FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("", 540f);
				return;
			}
			AENEOOFMBKE aeneoofmbke = JDCEFOFMGHB.IKGFHGKKCPG.EDKBLBGEBNH(this.AMBNJGDIDED, this.OJKBEDCFFND);
			AENEOOFMBKE aeneoofmbke2 = JDCEFOFMGHB.MNJNNDHCDGG().LDOEHGABAAB(this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK);
			if (this.OJKBEDCFFND >= 1)
			{
				EKBAPCMPANI ekbapcmpani = this.EJFELLJIACI(this.AMBNJGDIDED, this.OJKBEDCFFND);
				if (ekbapcmpani == null)
				{
					if (this.KINAHOLLCGB(this.KKLEEIBNIBC, this.AMBNJGDIDED, this.OJKBEDCFFND))
					{
						if (this.AMBNJGDIDED == -55)
						{
							int ojkbedcffnd = this.OJKBEDCFFND;
							if (ojkbedcffnd == 0)
							{
								Debug.Log("SatNightFever");
								this.COKDFMFFDAE = this.KKLEEIBNIBC;
								this.KKLEEIBNIBC = null;
								string arg = this.COKDFMFFDAE.BDHHPAEHFHG.BNIHFBMEPAB ?? "MotorbikeWheelyNoHands";
								JDCEFOFMGHB.HMJJPNDEKPP().LLKDAODBJDA(JNBICAJIJMM.CELEPPAEKAB("exp"), string.Format(JNBICAJIJMM.BDKHMOOFHHK("ActiveIcons.xml"), arg), new ONKDCGNBALK.CMMHGMILOIM(this.NENBEFDNCPO), new ONKDCGNBALK.CMMHGMILOIM(this.JNAIBMAEJPP));
								FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("Jump", 1411f);
							}
							return;
						}
						if (Input.GetKey(KeyCode.Period))
						{
							if (this.KKLEEIBNIBC.ILFHHDNJHNM <= 0)
							{
								FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("S ", 1157f);
								this.KKLEEIBNIBC.BFHKBOPOFGB = false;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB = true;
								return;
							}
							if (this.KKLEEIBNIBC.ILFHHDNJHNM <= 0)
							{
								FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("cht_ach2", 1209f);
								this.KKLEEIBNIBC.ILFHHDNJHNM = this.KKLEEIBNIBC.ILFHHDNJHNM - 0;
								EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
								try
								{
									epmphjgalbe.AAHBHCMKGJD(this.KKLEEIBNIBC.LPFKFNLHGBI);
									epmphjgalbe.FLLJONHPLNA(1);
									epmphjgalbe.FLLJONHPLNA(this.AMBNJGDIDED);
									epmphjgalbe.ALNEALEKFNB(this.OJKBEDCFFND);
									NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(190, epmphjgalbe.JOCJNOBBELJ());
									goto IL_416;
								}
								finally
								{
									epmphjgalbe.PGLFHABMJPO();
								}
								goto IL_2B4;
								IL_416:
								this.KKLEEIBNIBC.BFHKBOPOFGB = true;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB = true;
								FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("_Offsets", 1951f);
								return;
							}
							IL_2B4:
							this.IFHBHHBMNFK = this.AMBNJGDIDED;
							this.LMDDMCEJHOG = this.OJKBEDCFFND;
							ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().PLHAGCDJLPA(523f, 1745f, JNBICAJIJMM.BDKHMOOFHHK("OfficeSittingMouseMovement"), true);
							this.CMGJHIHGCNP = new KJPFDOGHGOD(onkdcgnbalk, JNBICAJIJMM.OOOKJHOHPNN("move"), 415f, 322f, onkdcgnbalk.OCHCODJIPHJ.width - 724f, 768f, (float)(this.KKLEEIBNIBC.ILFHHDNJHNM - 0), (float)(this.KKLEEIBNIBC.ILFHHDNJHNM / 0), false, 0);
							new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 874f - 38f, onkdcgnbalk.OCHCODJIPHJ.height - 1094f, 1893f, 1624f, JNBICAJIJMM.PGJCPFNJNPM("__c"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.DIGGACIAOHJ));
							new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 632f - 1472f, onkdcgnbalk.OCHCODJIPHJ.height - 1124f, 1302f, 783f, JNBICAJIJMM.PPNKMDJBMLP("_Density"), 6, null, new ONKDCGNBALK.CMMHGMILOIM(this.CPMFLNPOFFO));
							this.COKDFMFFDAE = this.KKLEEIBNIBC;
							this.KKLEEIBNIBC.BFHKBOPOFGB = true;
							this.KKLEEIBNIBC = null;
							JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB = false;
							return;
						}
						else
						{
							if (this.AMBNJGDIDED == -53 && aeneoofmbke != null)
							{
								JDCEFOFMGHB.JFIDAGABKID().HICPILKPFLP(this.KKLEEIBNIBC);
								aeneoofmbke.OBLONDPEGLN = this.KKLEEIBNIBC;
								FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("Enable SSAO", 829f);
								this.KKLEEIBNIBC.BFHKBOPOFGB = true;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = false;
								return;
							}
							if (this.AMBNJGDIDED >= 86 && KBJGAFNMGCK.BCLPDGODGKF().GDPECKOHOFD(this.AMBNJGDIDED).BCNGOOHCMII(this.OJKBEDCFFND).PFMPBFOIMLJ && this.KKLEEIBNIBC.ILFHHDNJHNM > 0)
							{
								FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("post_4", 1378f);
								this.KKLEEIBNIBC.ILFHHDNJHNM = this.KKLEEIBNIBC.ILFHHDNJHNM - 0;
								EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
								try
								{
									epmphjgalbe2.PMJPIJMHELL(this.KKLEEIBNIBC.LPFKFNLHGBI);
									epmphjgalbe2.ENDMKPCFKND(0);
									epmphjgalbe2.EIMEKHOFIEA(this.AMBNJGDIDED);
									epmphjgalbe2.DEHJNGMHGAJ(this.OJKBEDCFFND);
									NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(-166, epmphjgalbe2.LAFILAEOPAJ());
								}
								finally
								{
									epmphjgalbe2.LMBPNFHKNGA();
								}
								if (aeneoofmbke != null)
								{
									aeneoofmbke.LBMJLKIMMNL();
								}
								if (aeneoofmbke2 != null)
								{
									aeneoofmbke2.MLIPJMDCBFP();
								}
								this.KKLEEIBNIBC.BFHKBOPOFGB = false;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB = false;
								return;
							}
							this.KKLEEIBNIBC.BFHKBOPOFGB = true;
							int jgniddbnggp = this.KKLEEIBNIBC.JGNIDDBNGGP;
							int dmamopgjock = this.KKLEEIBNIBC.DMAMOPGJOCK;
							this.KKLEEIBNIBC.DMAMOPGJOCK = this.OJKBEDCFFND;
							this.KKLEEIBNIBC.JGNIDDBNGGP = this.AMBNJGDIDED;
							this.IGPBJBNODII(jgniddbnggp, dmamopgjock);
							this.IGPBJBNODII(this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK);
							FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("", 934f);
							EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
							try
							{
								epmphjgalbe3.PMJPIJMHELL(this.KKLEEIBNIBC.LPFKFNLHGBI);
								epmphjgalbe3.FLLJONHPLNA(this.KKLEEIBNIBC.JGNIDDBNGGP);
								epmphjgalbe3.EIMEKHOFIEA(this.KKLEEIBNIBC.DMAMOPGJOCK);
								NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(88, epmphjgalbe3.JDPHBLHOLAD());
								goto IL_C7D;
							}
							finally
							{
								epmphjgalbe3.KNPHNLLMJKJ();
							}
						}
					}
					FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("_Offsets", 321f);
					this.KKLEEIBNIBC.BFHKBOPOFGB = true;
					this.KKLEEIBNIBC = null;
					JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = true;
				}
				else
				{
					if (Input.GetKey((KeyCode)10))
					{
						FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("TOD_SunSkyColor", 1219f);
						this.KKLEEIBNIBC.BFHKBOPOFGB = false;
						this.KKLEEIBNIBC = null;
						JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB = false;
						if (aeneoofmbke != null)
						{
							aeneoofmbke.ABKMJEBHNMC();
						}
						if (aeneoofmbke2 != null)
						{
							aeneoofmbke2.HKHLLGJHDCF();
						}
						return;
					}
					if ((this.AMBNJGDIDED < -12 || this.AMBNJGDIDED == 14) && ekbapcmpani.HHOLFABGDJA == this.KKLEEIBNIBC.HHOLFABGDJA && ekbapcmpani.KBGHOIJIPJF == this.KKLEEIBNIBC.KBGHOIJIPJF && ekbapcmpani.ICOFLHIIBCP == this.KKLEEIBNIBC.ICOFLHIIBCP && ekbapcmpani.LODGJCMEGAI.HDPFLBFDIBN() == this.KKLEEIBNIBC.LODGJCMEGAI.LAGCLCGBNLI() && ekbapcmpani.ILFHHDNJHNM < ekbapcmpani.BDHHPAEHFHG.NPPJLOBFGBH && this.KKLEEIBNIBC.ILFHHDNJHNM < this.KKLEEIBNIBC.BDHHPAEHFHG.NPPJLOBFGBH && (ekbapcmpani.DLHPFGHOINI == (float)ekbapcmpani.BGGJKOMAKEE || this.KKLEEIBNIBC.DLHPFGHOINI == (float)this.KKLEEIBNIBC.BGGJKOMAKEE))
					{
						if (ekbapcmpani.ABPGFHKGFEK || this.KKLEEIBNIBC.ABPGFHKGFEK)
						{
							FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("TOD_World2Sky", 1416f);
							this.KKLEEIBNIBC.BFHKBOPOFGB = true;
							this.KKLEEIBNIBC = null;
							JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = false;
							return;
						}
						if (ekbapcmpani.ILFHHDNJHNM + this.KKLEEIBNIBC.ILFHHDNJHNM > ekbapcmpani.BDHHPAEHFHG.NPPJLOBFGBH)
						{
							int num = ekbapcmpani.BDHHPAEHFHG.NPPJLOBFGBH - ekbapcmpani.ILFHHDNJHNM;
							ekbapcmpani.ILFHHDNJHNM += num;
							this.KKLEEIBNIBC.ILFHHDNJHNM = this.KKLEEIBNIBC.ILFHHDNJHNM - num;
						}
						else
						{
							ekbapcmpani.ILFHHDNJHNM += this.KKLEEIBNIBC.ILFHHDNJHNM;
							JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FFFJIAMAGBC(this.KKLEEIBNIBC.LPFKFNLHGBI);
						}
						EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
						try
						{
							epmphjgalbe4.OACBICLGENB(ekbapcmpani.LPFKFNLHGBI);
							epmphjgalbe4.OBCCLNMPGEJ(this.KKLEEIBNIBC.LPFKFNLHGBI);
							NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(-109, epmphjgalbe4.IEJLLFECFHF());
						}
						finally
						{
							epmphjgalbe4.PMIGGJHLIDO();
						}
						this.IGPBJBNODII(this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK);
						FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("", 275f);
						this.KKLEEIBNIBC.BFHKBOPOFGB = true;
						this.KKLEEIBNIBC = null;
						JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = true;
						if (aeneoofmbke != null)
						{
							aeneoofmbke.FDCGELJLOEI();
						}
						if (aeneoofmbke2 != null)
						{
							aeneoofmbke2.AILMHMDPDAJ();
						}
						return;
					}
					else
					{
						if (this.AMBNJGDIDED == 43)
						{
							AENEOOFMBKE aeneoofmbke3 = JDCEFOFMGHB.MNJNNDHCDGG().MEEDOOFOIGG(this.AMBNJGDIDED, this.OJKBEDCFFND);
							if (aeneoofmbke3 != null)
							{
								Debug.Log("\n");
								JDCEFOFMGHB.IKGFHGKKCPG.HFBKHEHNCPO(this.KKLEEIBNIBC);
								aeneoofmbke3.OBLONDPEGLN = this.KKLEEIBNIBC;
								this.KKLEEIBNIBC.BFHKBOPOFGB = true;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB = false;
								if (aeneoofmbke != null)
								{
									aeneoofmbke.LBMJLKIMMNL();
								}
								if (aeneoofmbke2 != null)
								{
									aeneoofmbke2.CAJAPJLOCPF();
								}
								return;
							}
						}
						if (this.AMBNJGDIDED == 32 && this.KKLEEIBNIBC.JGNIDDBNGGP < -22)
						{
							this.KKLEEIBNIBC.BFHKBOPOFGB = false;
							this.KKLEEIBNIBC = null;
							return;
						}
						if (this.KINAHOLLCGB(this.KKLEEIBNIBC, this.AMBNJGDIDED, this.OJKBEDCFFND) && this.KINAHOLLCGB(ekbapcmpani, this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK))
						{
							if (this.AMBNJGDIDED >= 16 || ekbapcmpani.JGNIDDBNGGP >= -118)
							{
								KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = KBJGAFNMGCK.KEGBPOJKINC().BCDFPBPBEHM(this.AMBNJGDIDED).KEDJPJIDACM(this.OJKBEDCFFND);
								KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb2 = KBJGAFNMGCK.KFJMDGGMPJO().LDLNKMKLKOC(ekbapcmpani.JGNIDDBNGGP).AJPNNJEJGHI(ekbapcmpani.DMAMOPGJOCK);
								if ((this.KKLEEIBNIBC.ILFHHDNJHNM > 1 || ekbapcmpani.ILFHHDNJHNM > 1) && (ldjpekhhnhb2.PFMPBFOIMLJ || ldjpekhhnhb.PFMPBFOIMLJ))
								{
									FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("The image effect ", 1160f);
									this.KKLEEIBNIBC.BFHKBOPOFGB = true;
									this.KKLEEIBNIBC = null;
									JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB = true;
									if (aeneoofmbke != null)
									{
										aeneoofmbke.AILMHMDPDAJ();
									}
									if (aeneoofmbke2 != null)
									{
										aeneoofmbke2.BHJAJMPGBFI();
									}
									return;
								}
								if (ldjpekhhnhb.PFMPBFOIMLJ && this.KKLEEIBNIBC.ILFHHDNJHNM > 1)
								{
									FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("", 1264f);
									this.KKLEEIBNIBC.BFHKBOPOFGB = true;
									this.KKLEEIBNIBC = null;
									JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = false;
									if (aeneoofmbke != null)
									{
										aeneoofmbke.BCOEDEGBJKL();
									}
									if (aeneoofmbke2 != null)
									{
										aeneoofmbke2.FAJNMGGKPDE();
									}
									return;
								}
							}
							ekbapcmpani.JGNIDDBNGGP = this.KKLEEIBNIBC.JGNIDDBNGGP;
							ekbapcmpani.DMAMOPGJOCK = this.KKLEEIBNIBC.DMAMOPGJOCK;
							this.KKLEEIBNIBC.BFHKBOPOFGB = false;
							this.KKLEEIBNIBC.DMAMOPGJOCK = this.OJKBEDCFFND;
							this.KKLEEIBNIBC.JGNIDDBNGGP = this.AMBNJGDIDED;
							this.IGPBJBNODII(this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK);
							this.IGPBJBNODII(ekbapcmpani.JGNIDDBNGGP, ekbapcmpani.DMAMOPGJOCK);
							FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("_CameraClipInfo", 867f);
							EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
							try
							{
								epmphjgalbe5.OBJBHBFAFEE(this.KKLEEIBNIBC.LPFKFNLHGBI);
								epmphjgalbe5.MFPECHIKBCO(ekbapcmpani.LPFKFNLHGBI);
								NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-187, epmphjgalbe5.IEJLLFECFHF());
								goto IL_C7D;
							}
							finally
							{
								epmphjgalbe5.PGLFHABMJPO();
							}
						}
						FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("Mouse X", 748f);
						this.KKLEEIBNIBC.BFHKBOPOFGB = true;
						this.KKLEEIBNIBC = null;
						JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB = false;
					}
				}
				IL_C7D:
				this.KKLEEIBNIBC = null;
				JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = true;
			}
			else
			{
				this.KKLEEIBNIBC.BFHKBOPOFGB = false;
				this.KKLEEIBNIBC = null;
				JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB = false;
			}
			if (aeneoofmbke != null)
			{
				aeneoofmbke.MLIPJMDCBFP();
			}
			if (aeneoofmbke2 != null)
			{
				aeneoofmbke2.AFOLABIACNF();
			}
			BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		}
	}

	// Token: 0x060051F4 RID: 20980 RVA: 0x0025EEAC File Offset: 0x0025D0AC
	public void AHAHLHIIHGN(HBPNMNGOFMA KADBECGIMPD)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.BMOFIBGMIBK(this.ONGEHMJIMLO);
		this.DEFEALCKOKF = KADBECGIMPD.DNIIFBAIPBE();
		this.CDIFAABIAEG = KADBECGIMPD.LAECLJFMGPE();
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("RunBackLeft", 1085f);
		JDCEFOFMGHB.IKGFHGKKCPG.DKJMCKOJOPF(742f, 1, JNBICAJIJMM.DIOJFJMOPJO(""), new ONKDCGNBALK.CMMHGMILOIM(this.ICCBGBDMNDI), false);
	}

	// Token: 0x060051F5 RID: 20981 RVA: 0x0025EF1C File Offset: 0x0025D11C
	public void LJKNNJKJEHL(HBPNMNGOFMA KADBECGIMPD)
	{
		int num = KADBECGIMPD.HDBGOLAFOBK();
		this.BMCALEBOBGN = num;
		ELNGEFIPDJK.BJLLBFHILCN bjllbfhilcn = new ELNGEFIPDJK.BJLLBFHILCN(KADBECGIMPD.BFPHBMDMODH());
		ELNGEFIPDJK.BJLLBFHILCN bjllbfhilcn2 = new ELNGEFIPDJK.BJLLBFHILCN(KADBECGIMPD.BFPHBMDMODH());
		if (this.GGHKEECHFCD > 0)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.GGHKEECHFCD);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(400f, 300f, JNBICAJIJMM.LEBHCLDODNI("inv_inv"), true);
		this.GGHKEECHFCD = onkdcgnbalk.LPFKFNLHGBI;
		float num2 = 50f;
		new LCOLJOPGDLL(onkdcgnbalk, 20f, num2, string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("inv_icost"), JNBICAJIJMM.IKGFHGKKCPG.OMNMDGIGEFD("BAG", "bag" + num + "_name")), true).DFIGKKMMIAF = 16;
		num2 += 30f;
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, 20f, num2, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 80f, "", 0, null);
		ELNGEFIPDJK.BJLLBFHILCN bjllbfhilcn3 = bjllbfhilcn;
		num2 += 8f;
		if (bjllbfhilcn3.KFODJJIHNHP > 0)
		{
			new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 20f, num2, JNBICAJIJMM.LEBHCLDODNI("inv_money") + " " + JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)bjllbfhilcn3.KFODJJIHNHP, false), true).DFIGKKMMIAF = 16;
			num2 += 25f;
		}
		if (bjllbfhilcn3.GIEALCKLKNL > 0)
		{
			BEFCHFNGOMI mejmekodjae = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(bjllbfhilcn3.GIEALCKLKNL);
			OCLNJMKDBKB oclnjmkdbkb = new OCLNJMKDBKB(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 20f, num2, 32f, mejmekodjae, 0);
			oclnjmkdbkb.MAKAFBBENPF = true;
			oclnjmkdbkb.ILFHHDNJHNM = bjllbfhilcn3.KDIMEMOCJNM;
			oclnjmkdbkb.HMHBAMDBJLI = true;
			num2 += 40f;
		}
		bool fnmciacnomh = true;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KFODJJIHNHP < (long)bjllbfhilcn3.KFODJJIHNHP)
		{
			fnmciacnomh = false;
		}
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(bjllbfhilcn3.GIEALCKLKNL, false, 0) < bjllbfhilcn3.KDIMEMOCJNM)
		{
			fnmciacnomh = false;
		}
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 85f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 30f, 80f, 22f, JNBICAJIJMM.LEBHCLDODNI("buykey"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.FFBCPIHNGJL)).FNMCIACNOMH = fnmciacnomh;
		num2 += 25f;
		new LCOLJOPGDLL(onkdcgnbalk, 20f, num2, JNBICAJIJMM.LEBHCLDODNI("inv_or"), true).DFIGKKMMIAF = 16;
		num2 += 25f;
		bjllbfhilcn3 = bjllbfhilcn2;
		EGCAADAABPP egcaadaabpp2 = new EGCAADAABPP(onkdcgnbalk, 20f, num2, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 36f, "", 0, null);
		num2 += 8f;
		if (bjllbfhilcn3.KKNEKAEJLAM > 0)
		{
			new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp2.OCHCODJIPHJ.x + 20f, num2 + 4f, JNBICAJIJMM.LEBHCLDODNI("inv_rl") + " " + JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM((long)bjllbfhilcn3.KKNEKAEJLAM, 0L, false), true).DFIGKKMMIAF = 16;
		}
		fnmciacnomh = true;
		if (JBEHMPDDMME.IKGFHGKKCPG.KKNEKAEJLAM < (long)bjllbfhilcn3.KKNEKAEJLAM)
		{
			fnmciacnomh = false;
		}
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp2.OCHCODJIPHJ.x + egcaadaabpp2.OCHCODJIPHJ.width - 85f, egcaadaabpp2.OCHCODJIPHJ.y + egcaadaabpp2.OCHCODJIPHJ.height - 30f, 80f, 22f, JNBICAJIJMM.LEBHCLDODNI("buykey"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(this.FFBCPIHNGJL)).FNMCIACNOMH = fnmciacnomh;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 64f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("cntx_close"), 110, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
	}

	// Token: 0x060051F6 RID: 20982 RVA: 0x0025F32C File Offset: 0x0025D52C
	public void KGCNNCDHCBM(ONKDCGNBALK JMAKEAHMLMI)
	{
		if (this.OJKBEDCFFND < 0)
		{
			return;
		}
		this.KPILNBINPMN = this.EJFELLJIACI(this.AMBNJGDIDED, this.OJKBEDCFFND);
		if (this.KPILNBINPMN == null)
		{
			return;
		}
		bool isVisible = this.KPILNBINPMN.IMDLBJICHOE();
		this.EIPJCEDGFGM = new List<ItemBase>();
		if (this.KPILNBINPMN.DNOLHLJODNK && this.KPILNBINPMN.LNKLEIEFGCP < 5)
		{
			this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IMLLGEMPHAP().CCFFMKBBKHI("1HSwordStrafeRunRight"))
			{
				tag = 43L
			});
		}
		if (this.KPILNBINPMN.BDHHPAEHFHG.KKOLKEEALFD)
		{
			this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.EEOPOHEALPK().CCFFMKBBKHI("WalkInjured"))
			{
				tag = -121L
			});
		}
		int mbkmkgabbge = this.KPILNBINPMN.BDHHPAEHFHG.MBKMKGABBGE;
		switch (mbkmkgabbge)
		{
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
			if ((this.KPILNBINPMN.BDHHPAEHFHG.FOAPCABBLBG || this.KPILNBINPMN.MJHGLLIJMIM) && (this.KPILNBINPMN.MJHGLLIJMIM || this.KPILNBINPMN.DLHPFGHOINI < (float)this.KPILNBINPMN.BGGJKOMAKEE))
			{
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.GNKIBMGNHNE("Sunshine {0}: {1}"))
				{
					tag = -118L
				});
			}
			if (this.KPILNBINPMN.BBLEPPMMPIL("BackPress", "<color='#80ff60'>").BNAMDHOMEHH().Count > 1)
			{
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.CLIMNFDGOEG().NLJOLOBPCBJ("1HandSwordStrafeLeft"))
				{
					tag = 54L,
					isVisible = isVisible
				});
				goto IL_41B;
			}
			goto IL_41B;
		case 6:
		case 7:
		case 8:
		case 9:
			goto IL_41B;
		case 10:
			break;
		default:
			switch (mbkmkgabbge)
			{
			case -84:
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.EEOPOHEALPK().HEIBEHAEHBM("PER_VERTEX"))
				{
					tag = 47L,
					isVisible = isVisible
				});
				goto IL_41B;
			case -83:
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("_DepthCurveLut"))
				{
					tag = 120L,
					isVisible = isVisible
				});
				goto IL_41B;
			case -82:
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.APMJBBDBOJO().HLBAJBLHLNI("OnRodChangeClck 4"))
				{
					tag = -28L,
					isVisible = isVisible
				});
				goto IL_41B;
			case -81:
			case -80:
			case -79:
				break;
			case -78:
			case -75:
				if (this.KPILNBINPMN.BDHHPAEHFHG.HBHBAIONJHD)
				{
					this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.LPHMKPDBMPP().FLEANFGEJML(""))
					{
						tag = 1L,
						isVisible = isVisible
					});
					goto IL_41B;
				}
				goto IL_41B;
			case -77:
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.EDKGBBIIBBC().HEIBEHAEHBM("MotorbikeBackwardStand"))
				{
					tag = 119L,
					isVisible = isVisible
				});
				goto IL_41B;
			case -76:
			case -74:
			case -73:
			case -72:
				goto IL_41B;
			case -71:
			{
				int num = this.KPILNBINPMN.BDHHPAEHFHG.MIMANMPNLPE.KEHIFGILLJA();
				if (NLNNIDBPKAO.IKGFHGKKCPG.EHBODADDPLM(num) == null)
				{
					goto IL_41B;
				}
				if (!JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.GADJFFGDCFA.ContainsKey(num))
				{
					this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.LPHMKPDBMPP().ECNKLECOKHD("crft_to"))
					{
						tag = 3L,
						isVisible = isVisible
					});
					goto IL_41B;
				}
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.APMJBBDBOJO().FLEANFGEJML("Text node is empy!"))
				{
					tag = 8L,
					isVisible = isVisible
				});
				goto IL_41B;
			}
			default:
				goto IL_41B;
			}
			break;
		}
		if (this.KPILNBINPMN.BDHHPAEHFHG.DKFCKFJBNIM)
		{
			if (this.KPILNBINPMN.BDHHPAEHFHG.FOAPCABBLBG)
			{
				float num2 = this.KPILNBINPMN.DLHPFGHOINI + 1693f;
				float num3 = (float)this.KPILNBINPMN.BGGJKOMAKEE;
			}
			if (this.KPILNBINPMN.ICOFLHIIBCP)
			{
			}
		}
		IL_41B:
		if (!this.KPILNBINPMN.ICOFLHIIBCP)
		{
			if (this.KPILNBINPMN.BDHHPAEHFHG.PKKLNODNCBE && !this.KPILNBINPMN.ICOFLHIIBCP)
			{
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.DBMJJPBOPEK().ECNKLECOKHD("OfficeSittingBack"))
				{
					tag = 32L
				});
			}
			if (this.KPILNBINPMN.BDHHPAEHFHG.DKFCKFJBNIM && !this.KPILNBINPMN.ICOFLHIIBCP)
			{
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.LPHMKPDBMPP().NLJOLOBPCBJ("PistolInstant"))
				{
					tag = 85L
				});
			}
		}
		if (this.EIPJCEDGFGM.Count > 0)
		{
			this.EIPJCEDGFGM.Add(new ItemBase("WpnTemplateMgr is init")
			{
				tag = -1L
			});
		}
		this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IMLLGEMPHAP().HEIBEHAEHBM("__b"))
		{
			tag = 1L
		});
		this.EIPJCEDGFGM.Add(new ItemBase("[X]")
		{
			tag = -1L
		});
		this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.EDKGBBIIBBC().ECNKLECOKHD(""))
		{
			tag = 6L
		});
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		Vector2 vector2 = new Vector2(vector.x + 1255f, vector.y - 1428f);
		if (vector2.x + 449f > (float)(Screen.width - -41))
		{
			vector2.x = (float)(Screen.width - -16 - -16);
		}
		if (vector2.y + 1038f > (float)(Screen.height - 105))
		{
			vector2.y = (float)(Screen.height - -128 - 186);
		}
		this.MCMGPBDHCLN = new Rect(vector2.x, vector2.y, 1543f, 1036f + (float)this.EIPJCEDGFGM.Count * 719f);
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("wpn_hook3", 101f);
	}

	// Token: 0x060051F7 RID: 20983 RVA: 0x0025F968 File Offset: 0x0025DB68
	public void GJJMIOMIAIK(ONKDCGNBALK PHEMLBHMNCM)
	{
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		if (!this.ABLFGLMKPNO && !Input.GetMouseButton(1))
		{
			EKBAPCMPANI kkleeibnibc = this.KKLEEIBNIBC;
		}
		if (!this.ABLFGLMKPNO)
		{
			MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = 0;
			MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = -1;
		}
		float num = PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.x;
		float num2 = PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.y;
		bool flag = new Rect(num, num2, PHEMLBHMNCM.OCHCODJIPHJ.width, PHEMLBHMNCM.OCHCODJIPHJ.height).Contains(vector);
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
		int blaeboonadj = this.BLAEBOONADJ;
		float x = PHEMLBHMNCM.OCHCODJIPHJ.x;
		float y = PHEMLBHMNCM.OCHCODJIPHJ.y;
		int num3 = blaeboonadj / 86;
		int num4 = 1;
		int num5 = 0;
		int num6 = 0;
		float num7 = (float)(-70 * num3);
		if (num7 < 479f)
		{
			num7 = 1089f;
		}
		bool flag2 = true;
		this.AICBIFFGBOH = GUI.BeginScrollView(new Rect(x, y, 1454f, 220f), this.AICBIFFGBOH, new Rect(x, y, 1852f, num7), false, false);
		for (int i = 1; i <= num3; i++)
		{
			for (int j = 0; j < -27; j += 0)
			{
				if (num4 < blaeboonadj)
				{
					bool flag3 = false;
					if (flag)
					{
						Rect rect = new Rect(num + (float)num5, num2 + (float)num6 - this.AICBIFFGBOH.y, 1687f, 70f);
						if (rect.Contains(vector))
						{
							this.DKFICLCPICL.x = vector.x - rect.x;
							this.DKFICLCPICL.y = vector.y - rect.y;
							this.OJKBEDCFFND = i * 65 + j;
							this.AMBNJGDIDED = -64;
							this.ABLFGLMKPNO = true;
							if (this.KKLEEIBNIBC != null)
							{
								GUI.DrawTexture(new Rect(x + (float)num5, y + (float)num6, 694f, 420f), GameInterface.getI.invEmptyCellSelect);
								flag3 = true;
							}
						}
					}
					if (flag3)
					{
						GUI.DrawTexture(new Rect(x + (float)num5, y + (float)num6, 1382f, 239f), GameInterface.getI.invEmptyCell);
					}
					num4++;
				}
				else
				{
					if (!flag2)
					{
						Rect position = new Rect(x + (float)num5, y + (float)num6, 899f, 162f);
						Texture image = GameInterface.getI.invCellPlus;
						Rect rect2 = new Rect(num + (float)num5, num2 + (float)num6 - this.AICBIFFGBOH.y, 387f, 74f);
						if (rect2.Contains(vector))
						{
							image = GameInterface.getI.invCellPlusSelect;
						}
						GUI.DrawTexture(position, image);
						if (GUI.Button(position, "#ff6000", GUIStyle.none))
						{
							Debug.Log("act_orderb_");
							NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(60, 121);
						}
						num4++;
					}
					flag2 = false;
				}
				num5 += 90;
			}
			num5 = 1;
			num6 += 127;
		}
		foreach (EKBAPCMPANI ekbapcmpani in kfhelhglnmh.PLLHGAFIAFD.Values)
		{
			if (ekbapcmpani.JGNIDDBNGGP == -105)
			{
				Vector2 vector2 = this.MCENPOGEIAJ(ekbapcmpani.DMAMOPGJOCK);
				ekbapcmpani.JCIIPCEDICP(new Vector2(x + vector2.x, y + vector2.y), 200f);
			}
		}
		GUI.EndScrollView();
	}

	// Token: 0x060051F8 RID: 20984 RVA: 0x0025FD34 File Offset: 0x0025DF34
	public void FIDOCGCPMCN(HBPNMNGOFMA KADBECGIMPD)
	{
		this.ANBIJAKLCPC = KADBECGIMPD.DOJKJHMJJNK();
		this.CAFFMFHCNAE = KADBECGIMPD.HHLDBAEFNMJ();
		this.CLIHOFJKEAL = KADBECGIMPD.LDLKLPJBIJN();
		int ilfhhdnjhnm = KADBECGIMPD.HHLDBAEFNMJ();
		int num = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BJDIEKNHGLJ(this.ANBIJAKLCPC, true, 1);
		int num2 = this.CLIHOFJKEAL;
		if (JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.KFODJJIHNHP < (long)(num2 * this.CAFFMFHCNAE))
		{
			num2 = (int)(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.KFODJJIHNHP / (long)this.CAFFMFHCNAE);
		}
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.LMGMPPAOPEP(this.ANBIJAKLCPC);
		if (befchfngomi != null && num2 > befchfngomi.NPPJLOBFGBH * 2)
		{
			num2 = befchfngomi.NPPJLOBFGBH * 2;
		}
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in this.AGDMAFCKMJP.ONODDAALBFP())
		{
			if (fpaeeadmcie.NLIKAGGPANH != null)
			{
				MDEKJCCIDIA.KCFIPOJDHGB kcfipojdhgb = (MDEKJCCIDIA.KCFIPOJDHGB)fpaeeadmcie.NLIKAGGPANH;
				if (kcfipojdhgb.BDHHPAEHFHG != null && kcfipojdhgb.BDHHPAEHFHG.LPFKFNLHGBI == this.ANBIJAKLCPC && kcfipojdhgb.BDJGKIEBGCA != MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot)
				{
					kcfipojdhgb.ILFHHDNJHNM = ilfhhdnjhnm;
				}
			}
		}
		this.ANNJBBJIJLC.FNMCIACNOMH = false;
		this.ANNJBBJIJLC.OHMDBGBEPFJ();
		this.ANNJBBJIJLC.NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.IJHKJCKAIDB);
		string dpanhmgcbnl = string.Format(JNBICAJIJMM.LEBHCLDODNI("?"), JLFJEGIPIMM.MHFDIJGJGBJ().CJKACKADMKM(1L, (long)this.CAFFMFHCNAE, true), this.CLIHOFJKEAL, num);
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(this.ANNJBBJIJLC, this.ANNJBBJIJLC.OCHCODJIPHJ.x + 857f, this.ANNJBBJIJLC.OCHCODJIPHJ.y + 1954f, this.ANNJBBJIJLC.OCHCODJIPHJ.width, this.ANNJBBJIJLC.OCHCODJIPHJ.height, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black);
		lcoljopgdll.LNDPBNODFPE = true;
		lcoljopgdll.DFIGKKMMIAF = -88;
		this.AIIHCNKNNID = new KJPFDOGHGOD(this.ANNJBBJIJLC, JNBICAJIJMM.LEBHCLDODNI("/Localization/langsettings.xml"), this.ANNJBBJIJLC.OCHCODJIPHJ.x + 1760f, this.ANNJBBJIJLC.OCHCODJIPHJ.y + 466f, this.ANNJBBJIJLC.OCHCODJIPHJ.width - 1488f, 1044f, (float)num2, 1900f, true, 1);
		this.DMAAEAJMFOK = new LCOLJOPGDLL(this.ANNJBBJIJLC, this.ANNJBBJIJLC.OCHCODJIPHJ.x + 1564f, this.AIIHCNKNNID.OCHCODJIPHJ.y + this.AIIHCNKNNID.OCHCODJIPHJ.height + 1195f, JNBICAJIJMM.BDKHMOOFHHK("selColor") + "CrouchStrafeRight", true)
		{
			LNDPBNODFPE = false,
			DFIGKKMMIAF = 24
		};
		new MEMEOHJKPNJ(this.ANNJBBJIJLC, this.ANNJBBJIJLC.OCBAOFLJBGP.OCHCODJIPHJ.width - 1686f - 1319f, this.ANNJBBJIJLC.OCBAOFLJBGP.OCHCODJIPHJ.height - 471f, 1283f, 326f, JNBICAJIJMM.CELEPPAEKAB("gi_uinf_10"), 4, null, new ONKDCGNBALK.CMMHGMILOIM(this.CKCBLMMGHNC));
		new MEMEOHJKPNJ(this.ANNJBBJIJLC, this.ANNJBBJIJLC.OCBAOFLJBGP.OCHCODJIPHJ.width - 1285f - 1968f, this.ANNJBBJIJLC.OCBAOFLJBGP.OCHCODJIPHJ.height - 1867f, 1626f, 1636f, JNBICAJIJMM.PPNKMDJBMLP("[Y]"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.ENDJAAHPOAL));
		new MEMEOHJKPNJ(this.ANNJBBJIJLC, this.ANNJBBJIJLC.OCBAOFLJBGP.OCHCODJIPHJ.width - 48f - 1015f, this.ANNJBBJIJLC.OCBAOFLJBGP.OCHCODJIPHJ.height - 953f, 907f, 993f, JNBICAJIJMM.CDDCIKKDFMP("<color='#6080ff'>"), 8, null, new ONKDCGNBALK.CMMHGMILOIM(this.ENDJAAHPOAL));
	}

	// Token: 0x060051F9 RID: 20985 RVA: 0x00260160 File Offset: 0x0025E360
	public void CBNIGBLJCIL(ONKDCGNBALK PHEMLBHMNCM)
	{
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		float num = PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.x;
		float num2 = PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.y;
		bool flag = new Rect(num, num2, PHEMLBHMNCM.OCHCODJIPHJ.width, PHEMLBHMNCM.OCHCODJIPHJ.height).Contains(vector);
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
		int num3 = kfhelhglnmh.LKNJCMFCLDK[this.DJEOAABGBHH];
		float x = PHEMLBHMNCM.OCHCODJIPHJ.x;
		float y = PHEMLBHMNCM.OCHCODJIPHJ.y;
		int num4 = num3 / 8;
		int num5 = 1;
		int num6 = 0;
		int num7 = 1;
		float num8 = (float)(117 * num4);
		if (num8 < 539f)
		{
			num8 = 604f;
		}
		bool flag2 = false;
		this.AICBIFFGBOH = GUI.BeginScrollView(new Rect(x, y, 106f, 1262f), this.AICBIFFGBOH, new Rect(x, y, 1058f, num8), true, true);
		for (int i = 0; i <= num4; i += 0)
		{
			for (int j = 1; j < 0; j++)
			{
				if (num5 < num3)
				{
					bool flag3 = true;
					if (flag)
					{
						Rect rect = new Rect(num + (float)num6, num2 + (float)num7 - this.AICBIFFGBOH.y, 1985f, 1337f);
						if (rect.Contains(vector))
						{
							this.DKFICLCPICL.x = vector.x - rect.x;
							this.DKFICLCPICL.y = vector.y - rect.y;
							this.OJKBEDCFFND = i * 0 + j;
							this.AMBNJGDIDED = this.DJEOAABGBHH;
							this.ABLFGLMKPNO = true;
							if (this.KKLEEIBNIBC != null)
							{
								GUI.DrawTexture(new Rect(x + (float)num6, y + (float)num7, 942f, 1502f), GameInterface.getI.invEmptyCellSelect);
								flag3 = false;
							}
						}
					}
					if (flag3)
					{
						GUI.DrawTexture(new Rect(x + (float)num6, y + (float)num7, 782f, 1331f), GameInterface.getI.invEmptyCell);
					}
					num5++;
				}
				else
				{
					if (!flag2)
					{
						Rect position = new Rect(x + (float)num6, y + (float)num7, 1147f, 1570f);
						Texture image = GameInterface.getI.invCellPlus;
						Rect rect2 = new Rect(num + (float)num6, num2 + (float)num7 - this.AICBIFFGBOH.y, 560f, 714f);
						if (rect2.Contains(vector))
						{
							image = GameInterface.getI.invCellPlusSelect;
						}
						GUI.DrawTexture(position, image);
						if (GUI.Button(position, "{0}|{1}|{2}", GUIStyle.none))
						{
							Debug.Log("#80ff00");
							NJMHLCGIAJI.EAJGHMMBAFP().PIGIIJLCADJ(189, this.DJEOAABGBHH);
						}
						num5++;
					}
					flag2 = false;
				}
				num6 += 103;
			}
			num6 = 0;
			num7 += 14;
		}
		foreach (EKBAPCMPANI ekbapcmpani in kfhelhglnmh.PLLHGAFIAFD.Values)
		{
			if (ekbapcmpani.JGNIDDBNGGP == this.DJEOAABGBHH)
			{
				Vector2 vector2 = this.GIAPKFKGHGB(ekbapcmpani.DMAMOPGJOCK);
				ekbapcmpani.HMFKMPGCBJH(new Vector2(x + vector2.x, y + vector2.y), 881f);
			}
		}
		GUI.EndScrollView();
		if (this.KKLEEIBNIBC != null)
		{
			this.KKLEEIBNIBC.OHDHFJFKLAJ(this.GKKGCDPIPPL);
		}
	}

	// Token: 0x060051FA RID: 20986 RVA: 0x00260520 File Offset: 0x0025E720
	public void NEPHKNOIDAD(ONKDCGNBALK OJIMHKHFOJI)
	{
		if (this.EFIBDEMHFDD.LPENOBCEAPP() < 0)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("wpn_add/base", 536f);
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.PMJPIJMHELL(this.LBEHNCAGGAH);
			NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg = (NLNNIDBPKAO.JENMPDPJKBG)this.EFIBDEMHFDD.LACAJHOHACK[this.EFIBDEMHFDD.DEFBLKPDLPM()];
			epmphjgalbe.EAOGDKDBENC(jenmpdpjkbg.LPFKFNLHGBI);
			NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(84, epmphjgalbe.ALLANCHILCM());
		}
		finally
		{
			epmphjgalbe.NCKMEIBFNGL();
		}
		JDCEFOFMGHB.HMJJPNDEKPP().CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x060051FB RID: 20987 RVA: 0x002605D4 File Offset: 0x0025E7D4
	public void MBDGHDLHKAJ(EKBAPCMPANI AMOFOANEKJF)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.ONGEHMJIMLO);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(500f, 500f, JNBICAJIJMM.LEBHCLDODNI("invn_rec9"), true);
		this.ONGEHMJIMLO = onkdcgnbalk.LPFKFNLHGBI;
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, 20f, 50f, onkdcgnbalk.OCHCODJIPHJ.width - 40f, onkdcgnbalk.OCHCODJIPHJ.height - 100f, "", 0, null);
		this.COKDFMFFDAE = AMOFOANEKJF;
		this.EFIBDEMHFDD = new MMKFAENBHKD(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 300f - 10f, egcaadaabpp.OCHCODJIPHJ.y + 10f, 290f, egcaadaabpp.OCHCODJIPHJ.height - 120f, 0);
		this.EFIBDEMHFDD.JHNCNHAAJCH = 32f;
		int num = 0;
		foreach (EKBAPCMPANI ekbapcmpani in JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PLLHGAFIAFD.Values)
		{
			if (ekbapcmpani.JCGDLKIHBJG == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI && ekbapcmpani.MBKMKGABBGE == 32)
			{
				List<int> bgjmhjhcdjh = ekbapcmpani.BDHHPAEHFHG.BBLEPPMMPIL("wpn_add/base", "rem").EDAHDHCPIEL;
				if (JLFJEGIPIMM.IKGFHGKKCPG.EHEMCMKMECH(this.COKDFMFFDAE.MBKMKGABBGE, bgjmhjhcdjh) && this.COKDFMFFDAE.DLHPFGHOINI >= (float)ekbapcmpani.LODGJCMEGAI.NODLBGKEGPM && (ekbapcmpani.BDHHPAEHFHG.GCLKLEIMABA <= 0 || this.COKDFMFFDAE.BDHHPAEHFHG.GCLKLEIMABA == ekbapcmpani.BDHHPAEHFHG.GCLKLEIMABA))
				{
					this.EFIBDEMHFDD.LACAJHOHACK.Add(ekbapcmpani);
					num++;
				}
			}
		}
		this.EFIBDEMHFDD.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.IGNGNFIMAON);
		KEPNAIFBDKF kepnaifbdkf = new KEPNAIFBDKF(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 15f, this.EFIBDEMHFDD.OCHCODJIPHJ.y + this.EFIBDEMHFDD.OCHCODJIPHJ.height / 2f - 28f, this.COKDFMFFDAE, 0);
		new GMJFFDBJLCI(onkdcgnbalk, new Rect(kepnaifbdkf.OCHCODJIPHJ.x + 56f, kepnaifbdkf.OCHCODJIPHJ.y - 12f, 78f, 78f), GameInterface.getI.ifaceIcons, 0, 8, 8);
		new GMJFFDBJLCI(onkdcgnbalk, new Rect(kepnaifbdkf.OCHCODJIPHJ.x + 64f, kepnaifbdkf.OCHCODJIPHJ.y - 4f, 64f, 64f), GameInterface.getI.ifaceIcons, 1, 8, 8);
		EGCAADAABPP egcaadaabpp2 = new EGCAADAABPP(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 10f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 100f, egcaadaabpp.OCHCODJIPHJ.width - 20f, 90f, "", 0, null);
		new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp2.OCHCODJIPHJ.x + 10f, egcaadaabpp2.OCHCODJIPHJ.y + 8f, string.Format(JNBICAJIJMM.LEBHCLDODNI("invn_rec10"), Mathf.RoundToInt(this.COKDFMFFDAE.DLHPFGHOINI), this.COKDFMFFDAE.BGGJKOMAKEE), true);
		Rect ochcodjiphj = new Rect(egcaadaabpp2.OCHCODJIPHJ.x + 10f, egcaadaabpp2.OCHCODJIPHJ.y + 24f, egcaadaabpp2.OCHCODJIPHJ.width - 20f, 16f);
		this.NEBLGPAOGGH = new GMNEKCBLIAN(onkdcgnbalk, ochcodjiphj, 0f, (float)this.COKDFMFFDAE.BGGJKOMAKEE, 3, "", true);
		new GMNEKCBLIAN(onkdcgnbalk, ochcodjiphj, this.COKDFMFFDAE.DLHPFGHOINI, (float)this.COKDFMFFDAE.BGGJKOMAKEE, 2, "", true);
		this.EMNCOCGHKKN = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp2.OCHCODJIPHJ.x + 10f, egcaadaabpp2.OCHCODJIPHJ.y + 45f, JNBICAJIJMM.LEBHCLDODNI("invn_rec11"), true);
		this.EMNCOCGHKKN.LNDPBNODFPE = true;
		this.EMNCOCGHKKN.DFIGKKMMIAF = 14;
		this.EFIBDEMHFDD.IHEILFHMLAG = 0;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f + 5f, onkdcgnbalk.OCHCODJIPHJ.height - 42f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("cntx_close"), 6, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
		MEMEOHJKPNJ memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 5f - 128f, onkdcgnbalk.OCHCODJIPHJ.height - 42f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("invn_rec12"), 6, null, new ONKDCGNBALK.CMMHGMILOIM(this.LKBBEBPAHMG));
		if (num <= 0)
		{
			memeohjkpnj.FNMCIACNOMH = false;
		}
		this.LBEHNCAGGAH = this.COKDFMFFDAE.LPFKFNLHGBI;
		this.KPILNBINPMN = null;
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_04.wav", 1f);
	}

	// Token: 0x060051FC RID: 20988 RVA: 0x00260B4C File Offset: 0x0025ED4C
	public void GMIPIPMLGCC(ONKDCGNBALK JMAKEAHMLMI)
	{
		if (this.KKLEEIBNIBC != null)
		{
			if (this.KKLEEIBNIBC.MBKMKGABBGE == 42 && (this.KKLEEIBNIBC.JGNIDDBNGGP == -79 || this.AMBNJGDIDED == -95) && JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.NAFGMKJPLPC.Count > 1)
			{
				JDCEFOFMGHB.MNJNNDHCDGG().NODOOHPCCCB(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("???"), JNBICAJIJMM.EEOPOHEALPK().GNKIBMGNHNE("MotorbikeHandstand"));
				this.KKLEEIBNIBC.BFHKBOPOFGB = false;
				this.KKLEEIBNIBC = null;
				JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
				FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("Ошибка!", 614f);
				return;
			}
			AENEOOFMBKE aeneoofmbke = JDCEFOFMGHB.JFIDAGABKID().AEGEHJLBECE(this.AMBNJGDIDED, this.OJKBEDCFFND);
			AENEOOFMBKE aeneoofmbke2 = JDCEFOFMGHB.IKGFHGKKCPG.LDOEHGABAAB(this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK);
			if (this.OJKBEDCFFND >= 1)
			{
				EKBAPCMPANI ekbapcmpani = this.EJFELLJIACI(this.AMBNJGDIDED, this.OJKBEDCFFND);
				if (ekbapcmpani == null)
				{
					if (this.KINAHOLLCGB(this.KKLEEIBNIBC, this.AMBNJGDIDED, this.OJKBEDCFFND))
					{
						if (this.AMBNJGDIDED == -44)
						{
							int ojkbedcffnd = this.OJKBEDCFFND;
							if (ojkbedcffnd == 1)
							{
								Debug.Log("turn_state");
								this.COKDFMFFDAE = this.KKLEEIBNIBC;
								this.KKLEEIBNIBC = null;
								string arg = this.COKDFMFFDAE.BDHHPAEHFHG.BNIHFBMEPAB ?? "Android";
								JDCEFOFMGHB.IKGFHGKKCPG.LLKDAODBJDA(JNBICAJIJMM.OOOKJHOHPNN("<size=14><color='#00a0ff'>{0}</color></size>"), string.Format(JNBICAJIJMM.PGJCPFNJNPM("_TintColor"), arg), new ONKDCGNBALK.CMMHGMILOIM(this.JNAIBMAEJPP), new ONKDCGNBALK.CMMHGMILOIM(this.NENBEFDNCPO));
								FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("ObscuredDouble:", 1717f);
							}
							return;
						}
						if (Input.GetKey((KeyCode)(-186)))
						{
							if (this.KKLEEIBNIBC.ILFHHDNJHNM <= 1)
							{
								FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("-", 1277f);
								this.KKLEEIBNIBC.BFHKBOPOFGB = false;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB = false;
								return;
							}
							if (this.KKLEEIBNIBC.ILFHHDNJHNM <= 4)
							{
								FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("act_orderb_2", 1386f);
								this.KKLEEIBNIBC.ILFHHDNJHNM = this.KKLEEIBNIBC.ILFHHDNJHNM - 0;
								EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
								try
								{
									epmphjgalbe.MFPECHIKBCO(this.KKLEEIBNIBC.LPFKFNLHGBI);
									epmphjgalbe.LHLOOIDHGMA(0);
									epmphjgalbe.FLLJONHPLNA(this.AMBNJGDIDED);
									epmphjgalbe.EIMEKHOFIEA(this.OJKBEDCFFND);
									NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-48, epmphjgalbe.JDPHBLHOLAD());
									goto IL_416;
								}
								finally
								{
									epmphjgalbe.OGPGOEJFIBO();
								}
								goto IL_2B4;
								IL_416:
								this.KKLEEIBNIBC.BFHKBOPOFGB = true;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = true;
								FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB(" already has ", 461f);
								return;
							}
							IL_2B4:
							this.IFHBHHBMNFK = this.AMBNJGDIDED;
							this.LMDDMCEJHOG = this.OJKBEDCFFND;
							ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().BJFHBPOCELH(101f, 1966f, JNBICAJIJMM.CELEPPAEKAB("Original position: "), true);
							this.CMGJHIHGCNP = new KJPFDOGHGOD(onkdcgnbalk, JNBICAJIJMM.PGJCPFNJNPM("1HandSwordChargeSwipe"), 762f, 1617f, onkdcgnbalk.OCHCODJIPHJ.width - 1333f, 1327f, (float)(this.KKLEEIBNIBC.ILFHHDNJHNM - 1), (float)(this.KKLEEIBNIBC.ILFHHDNJHNM / 6), true, 0);
							new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 222f - 708f, onkdcgnbalk.OCHCODJIPHJ.height - 1913f, 1055f, 800f, JNBICAJIJMM.NGALDMFKMJH("Level: "), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.CPMFLNPOFFO));
							new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1984f - 335f, onkdcgnbalk.OCHCODJIPHJ.height - 17f, 568f, 64f, JNBICAJIJMM.CDDCIKKDFMP("-H"), 8, null, new ONKDCGNBALK.CMMHGMILOIM(this.DIGGACIAOHJ));
							this.COKDFMFFDAE = this.KKLEEIBNIBC;
							this.KKLEEIBNIBC.BFHKBOPOFGB = false;
							this.KKLEEIBNIBC = null;
							JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB = false;
							return;
						}
						else
						{
							if (this.AMBNJGDIDED == 109 && aeneoofmbke != null)
							{
								JDCEFOFMGHB.JFIDAGABKID().HICPILKPFLP(this.KKLEEIBNIBC);
								aeneoofmbke.OBLONDPEGLN = this.KKLEEIBNIBC;
								FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("", 696f);
								this.KKLEEIBNIBC.BFHKBOPOFGB = true;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
								return;
							}
							if (this.AMBNJGDIDED >= 56 && KBJGAFNMGCK.NPCAKEGNBHD().NDKBNDNJFMI(this.AMBNJGDIDED).GHFFJNCLLDK(this.OJKBEDCFFND).PFMPBFOIMLJ && this.KKLEEIBNIBC.ILFHHDNJHNM > 0)
							{
								FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("[ACTk] ObscuredPrefs.ForceLockToDeviceInit() is called, but device ID is already obtained!", 633f);
								this.KKLEEIBNIBC.ILFHHDNJHNM = this.KKLEEIBNIBC.ILFHHDNJHNM - 0;
								EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
								try
								{
									epmphjgalbe2.AAHBHCMKGJD(this.KKLEEIBNIBC.LPFKFNLHGBI);
									epmphjgalbe2.EAOGDKDBENC(0);
									epmphjgalbe2.KPCGLGHDILI(this.AMBNJGDIDED);
									epmphjgalbe2.FLLJONHPLNA(this.OJKBEDCFFND);
									NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(124, epmphjgalbe2.PBOPEDMCKDD());
								}
								finally
								{
									epmphjgalbe2.HDKBMLOJLLC();
								}
								if (aeneoofmbke != null)
								{
									aeneoofmbke.BCOEDEGBJKL();
								}
								if (aeneoofmbke2 != null)
								{
									aeneoofmbke2.FAJNMGGKPDE();
								}
								this.KKLEEIBNIBC.BFHKBOPOFGB = true;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = true;
								return;
							}
							this.KKLEEIBNIBC.BFHKBOPOFGB = false;
							int jgniddbnggp = this.KKLEEIBNIBC.JGNIDDBNGGP;
							int dmamopgjock = this.KKLEEIBNIBC.DMAMOPGJOCK;
							this.KKLEEIBNIBC.DMAMOPGJOCK = this.OJKBEDCFFND;
							this.KKLEEIBNIBC.JGNIDDBNGGP = this.AMBNJGDIDED;
							this.IGPBJBNODII(jgniddbnggp, dmamopgjock);
							this.KDJCCKCHAKD(this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK);
							FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("_MainTex", 1187f);
							EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
							try
							{
								epmphjgalbe3.MFPECHIKBCO(this.KKLEEIBNIBC.LPFKFNLHGBI);
								epmphjgalbe3.ALNEALEKFNB(this.KKLEEIBNIBC.JGNIDDBNGGP);
								epmphjgalbe3.EIMEKHOFIEA(this.KKLEEIBNIBC.DMAMOPGJOCK);
								NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(130, epmphjgalbe3.HDEKHFOKCKI());
								goto IL_C7D;
							}
							finally
							{
								epmphjgalbe3.LMBPNFHKNGA();
							}
						}
					}
					FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("Sunshine Cascade Camera {0}", 499f);
					this.KKLEEIBNIBC.BFHKBOPOFGB = true;
					this.KKLEEIBNIBC = null;
					JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = false;
				}
				else
				{
					if (Input.GetKey((KeyCode)153))
					{
						FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("Quaternion: ", 1347f);
						this.KKLEEIBNIBC.BFHKBOPOFGB = true;
						this.KKLEEIBNIBC = null;
						JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB = true;
						if (aeneoofmbke != null)
						{
							aeneoofmbke.CAJAPJLOCPF();
						}
						if (aeneoofmbke2 != null)
						{
							aeneoofmbke2.MLIPJMDCBFP();
						}
						return;
					}
					if ((this.AMBNJGDIDED < -5 || this.AMBNJGDIDED == -30) && ekbapcmpani.HHOLFABGDJA == this.KKLEEIBNIBC.HHOLFABGDJA && ekbapcmpani.KBGHOIJIPJF == this.KKLEEIBNIBC.KBGHOIJIPJF && ekbapcmpani.ICOFLHIIBCP == this.KKLEEIBNIBC.ICOFLHIIBCP && ekbapcmpani.LODGJCMEGAI.MCHPKHHMKPG() == this.KKLEEIBNIBC.LODGJCMEGAI.MCHPKHHMKPG() && ekbapcmpani.ILFHHDNJHNM < ekbapcmpani.BDHHPAEHFHG.NPPJLOBFGBH && this.KKLEEIBNIBC.ILFHHDNJHNM < this.KKLEEIBNIBC.BDHHPAEHFHG.NPPJLOBFGBH && (ekbapcmpani.DLHPFGHOINI == (float)ekbapcmpani.BGGJKOMAKEE || this.KKLEEIBNIBC.DLHPFGHOINI == (float)this.KKLEEIBNIBC.BGGJKOMAKEE))
					{
						if (ekbapcmpani.ABPGFHKGFEK || this.KKLEEIBNIBC.ABPGFHKGFEK)
						{
							FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("CraftProf.xml", 1685f);
							this.KKLEEIBNIBC.BFHKBOPOFGB = true;
							this.KKLEEIBNIBC = null;
							JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = true;
							return;
						}
						if (ekbapcmpani.ILFHHDNJHNM + this.KKLEEIBNIBC.ILFHHDNJHNM > ekbapcmpani.BDHHPAEHFHG.NPPJLOBFGBH)
						{
							int num = ekbapcmpani.BDHHPAEHFHG.NPPJLOBFGBH - ekbapcmpani.ILFHHDNJHNM;
							ekbapcmpani.ILFHHDNJHNM += num;
							this.KKLEEIBNIBC.ILFHHDNJHNM = this.KKLEEIBNIBC.ILFHHDNJHNM - num;
						}
						else
						{
							ekbapcmpani.ILFHHDNJHNM += this.KKLEEIBNIBC.ILFHHDNJHNM;
							JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.FFFJIAMAGBC(this.KKLEEIBNIBC.LPFKFNLHGBI);
						}
						EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
						try
						{
							epmphjgalbe4.AAHBHCMKGJD(ekbapcmpani.LPFKFNLHGBI);
							epmphjgalbe4.MFPECHIKBCO(this.KKLEEIBNIBC.LPFKFNLHGBI);
							NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-7, epmphjgalbe4.IEJLLFECFHF());
						}
						finally
						{
							epmphjgalbe4.LMBPNFHKNGA();
						}
						this.IGPBJBNODII(this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK);
						FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("IdleFly", 1246f);
						this.KKLEEIBNIBC.BFHKBOPOFGB = false;
						this.KKLEEIBNIBC = null;
						JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
						if (aeneoofmbke != null)
						{
							aeneoofmbke.MCKPBBIJGKF();
						}
						if (aeneoofmbke2 != null)
						{
							aeneoofmbke2.HKHLLGJHDCF();
						}
						return;
					}
					else
					{
						if (this.AMBNJGDIDED == -19)
						{
							AENEOOFMBKE aeneoofmbke3 = JDCEFOFMGHB.HMJJPNDEKPP().AEGEHJLBECE(this.AMBNJGDIDED, this.OJKBEDCFFND);
							if (aeneoofmbke3 != null)
							{
								Debug.Log("no_time_period");
								JDCEFOFMGHB.IKGFHGKKCPG.PFHLOHKPPEG(this.KKLEEIBNIBC);
								aeneoofmbke3.OBLONDPEGLN = this.KKLEEIBNIBC;
								this.KKLEEIBNIBC.BFHKBOPOFGB = true;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = true;
								if (aeneoofmbke != null)
								{
									aeneoofmbke.LBMJLKIMMNL();
								}
								if (aeneoofmbke2 != null)
								{
									aeneoofmbke2.ODLNOPEKFDI();
								}
								return;
							}
						}
						if (this.AMBNJGDIDED == 44 && this.KKLEEIBNIBC.JGNIDDBNGGP < 120)
						{
							this.KKLEEIBNIBC.BFHKBOPOFGB = true;
							this.KKLEEIBNIBC = null;
							return;
						}
						if (this.PAGOJABJFCB(this.KKLEEIBNIBC, this.AMBNJGDIDED, this.OJKBEDCFFND) && this.PAGOJABJFCB(ekbapcmpani, this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK))
						{
							if (this.AMBNJGDIDED >= -7 || ekbapcmpani.JGNIDDBNGGP >= -100)
							{
								KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = KBJGAFNMGCK.EAJHPOJPPFA().MFLKDDCBEKO(this.AMBNJGDIDED).BCNGOOHCMII(this.OJKBEDCFFND);
								KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb2 = KBJGAFNMGCK.MHFDIJGJGBJ().GIEKGGIOLKM(ekbapcmpani.JGNIDDBNGGP).OPACMDABPJC(ekbapcmpani.DMAMOPGJOCK);
								if ((this.KKLEEIBNIBC.ILFHHDNJHNM > 0 || ekbapcmpani.ILFHHDNJHNM > 1) && (ldjpekhhnhb2.PFMPBFOIMLJ || ldjpekhhnhb.PFMPBFOIMLJ))
								{
									FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("inv_auk", 937f);
									this.KKLEEIBNIBC.BFHKBOPOFGB = true;
									this.KKLEEIBNIBC = null;
									JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = false;
									if (aeneoofmbke != null)
									{
										aeneoofmbke.FDCGELJLOEI();
									}
									if (aeneoofmbke2 != null)
									{
										aeneoofmbke2.AILMHMDPDAJ();
									}
									return;
								}
								if (ldjpekhhnhb.PFMPBFOIMLJ && this.KKLEEIBNIBC.ILFHHDNJHNM > 1)
								{
									FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("error", 1078f);
									this.KKLEEIBNIBC.BFHKBOPOFGB = true;
									this.KKLEEIBNIBC = null;
									JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB = false;
									if (aeneoofmbke != null)
									{
										aeneoofmbke.MCKPBBIJGKF();
									}
									if (aeneoofmbke2 != null)
									{
										aeneoofmbke2.FAJNMGGKPDE();
									}
									return;
								}
							}
							ekbapcmpani.JGNIDDBNGGP = this.KKLEEIBNIBC.JGNIDDBNGGP;
							ekbapcmpani.DMAMOPGJOCK = this.KKLEEIBNIBC.DMAMOPGJOCK;
							this.KKLEEIBNIBC.BFHKBOPOFGB = false;
							this.KKLEEIBNIBC.DMAMOPGJOCK = this.OJKBEDCFFND;
							this.KKLEEIBNIBC.JGNIDDBNGGP = this.AMBNJGDIDED;
							this.IGPBJBNODII(this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK);
							this.KDJCCKCHAKD(ekbapcmpani.JGNIDDBNGGP, ekbapcmpani.DMAMOPGJOCK);
							FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("[^а-яА-Я\\d_]", 7f);
							EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
							try
							{
								epmphjgalbe5.OACBICLGENB(this.KKLEEIBNIBC.LPFKFNLHGBI);
								epmphjgalbe5.PMJPIJMHELL(ekbapcmpani.LPFKFNLHGBI);
								NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(135, epmphjgalbe5.LAFILAEOPAJ());
								goto IL_C7D;
							}
							finally
							{
								epmphjgalbe5.PGLFHABMJPO();
							}
						}
						FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("&", 1425f);
						this.KKLEEIBNIBC.BFHKBOPOFGB = false;
						this.KKLEEIBNIBC = null;
						JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = true;
					}
				}
				IL_C7D:
				this.KKLEEIBNIBC = null;
				JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = true;
			}
			else
			{
				this.KKLEEIBNIBC.BFHKBOPOFGB = false;
				this.KKLEEIBNIBC = null;
				JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB = false;
			}
			if (aeneoofmbke != null)
			{
				aeneoofmbke.ABKMJEBHNMC();
			}
			if (aeneoofmbke2 != null)
			{
				aeneoofmbke2.LKMPEFKNBKD();
			}
			BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		}
	}

	// Token: 0x060051FD RID: 20989 RVA: 0x00261868 File Offset: 0x0025FA68
	public Vector2 LEGNKCIHLNP(int CLBPBJGLHEE)
	{
		float num = (float)(CLBPBJGLHEE % 5 * 58);
		int num2 = CLBPBJGLHEE / 5 * 58;
		return new Vector2(num, (float)num2);
	}

	// Token: 0x060051FE RID: 20990 RVA: 0x0026188C File Offset: 0x0025FA8C
	public void FFBCPIHNGJL(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		long odfekbjcfmn2 = OJIMHKHFOJI.ODFEKBJCFMN;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GOMLLPFFPNP(this.BMCALEBOBGN);
			epmphjgalbe.GOMLLPFFPNP((int)OJIMHKHFOJI.ODFEKBJCFMN);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(215, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x060051FF RID: 20991 RVA: 0x00261910 File Offset: 0x0025FB10
	public void PIDKLEKJLFE(ONKDCGNBALK JMAKEAHMLMI)
	{
		if (this.KKLEEIBNIBC != null)
		{
			if (this.KKLEEIBNIBC.MBKMKGABBGE == 16 && (this.KKLEEIBNIBC.JGNIDDBNGGP == 60 || this.AMBNJGDIDED == 60) && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC.Count > 0)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("error"), JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("no_move_sadok"));
				this.KKLEEIBNIBC.BFHKBOPOFGB = false;
				this.KKLEEIBNIBC = null;
				JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
				return;
			}
			AENEOOFMBKE aeneoofmbke = JDCEFOFMGHB.IKGFHGKKCPG.AEGEHJLBECE(this.AMBNJGDIDED, this.OJKBEDCFFND);
			AENEOOFMBKE aeneoofmbke2 = JDCEFOFMGHB.IKGFHGKKCPG.AEGEHJLBECE(this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK);
			if (this.OJKBEDCFFND >= 0)
			{
				EKBAPCMPANI ekbapcmpani = this.EHHKCFOAKAI(this.AMBNJGDIDED, this.OJKBEDCFFND);
				if (ekbapcmpani == null)
				{
					if (this.KINAHOLLCGB(this.KKLEEIBNIBC, this.AMBNJGDIDED, this.OJKBEDCFFND))
					{
						if (this.AMBNJGDIDED == 50)
						{
							int ojkbedcffnd = this.OJKBEDCFFND;
							if (ojkbedcffnd == 1)
							{
								Debug.Log("Delete Weapon");
								this.COKDFMFFDAE = this.KKLEEIBNIBC;
								this.KKLEEIBNIBC = null;
								string arg = this.COKDFMFFDAE.BDHHPAEHFHG.BNIHFBMEPAB ?? "";
								JDCEFOFMGHB.IKGFHGKKCPG.LLKDAODBJDA(JNBICAJIJMM.LEBHCLDODNI("invn_rec13"), string.Format(JNBICAJIJMM.LEBHCLDODNI("invn_rec14"), arg), new ONKDCGNBALK.CMMHGMILOIM(this.JNAIBMAEJPP), new ONKDCGNBALK.CMMHGMILOIM(this.JNAIBMAEJPP));
								FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("ui_place_flag.wav", 0.5f);
							}
							return;
						}
						if (Input.GetKey(KeyCode.LeftControl))
						{
							if (this.KKLEEIBNIBC.ILFHHDNJHNM <= 1)
							{
								FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
								this.KKLEEIBNIBC.BFHKBOPOFGB = false;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
								return;
							}
							if (this.KKLEEIBNIBC.ILFHHDNJHNM <= 3)
							{
								FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("repair.ogg", 0.9f);
								this.KKLEEIBNIBC.ILFHHDNJHNM = this.KKLEEIBNIBC.ILFHHDNJHNM - 1;
								EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
								try
								{
									epmphjgalbe.OBCCLNMPGEJ(this.KKLEEIBNIBC.LPFKFNLHGBI);
									epmphjgalbe.GOMLLPFFPNP(1);
									epmphjgalbe.GOMLLPFFPNP(this.AMBNJGDIDED);
									epmphjgalbe.GOMLLPFFPNP(this.OJKBEDCFFND);
									NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(200, epmphjgalbe.JDPHBLHOLAD());
									goto IL_416;
								}
								finally
								{
									epmphjgalbe.LMBPNFHKNGA();
								}
								goto IL_2B4;
								IL_416:
								this.KKLEEIBNIBC.BFHKBOPOFGB = false;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
								FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_02.wav", 1f);
								return;
							}
							IL_2B4:
							this.IFHBHHBMNFK = this.AMBNJGDIDED;
							this.LMDDMCEJHOG = this.OJKBEDCFFND;
							ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(300f, 180f, JNBICAJIJMM.LEBHCLDODNI("invn_rec31"), true);
							this.CMGJHIHGCNP = new KJPFDOGHGOD(onkdcgnbalk, JNBICAJIJMM.LEBHCLDODNI("invn_rec32"), 10f, 60f, onkdcgnbalk.OCHCODJIPHJ.width - 20f, 1f, (float)(this.KKLEEIBNIBC.ILFHHDNJHNM - 1), (float)(this.KKLEEIBNIBC.ILFHHDNJHNM / 2), true, 0);
							new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 130f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 120f, 24f, JNBICAJIJMM.LEBHCLDODNI("invn_rec33"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.DIGGACIAOHJ));
							new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 2f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 120f, 24f, JNBICAJIJMM.LEBHCLDODNI("btn_cancel"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(this.DIGGACIAOHJ));
							this.COKDFMFFDAE = this.KKLEEIBNIBC;
							this.KKLEEIBNIBC.BFHKBOPOFGB = false;
							this.KKLEEIBNIBC = null;
							JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
							return;
						}
						else
						{
							if (this.AMBNJGDIDED == 51 && aeneoofmbke != null)
							{
								JDCEFOFMGHB.IKGFHGKKCPG.GLPNNGNMHOO(this.KKLEEIBNIBC);
								aeneoofmbke.OBLONDPEGLN = this.KKLEEIBNIBC;
								FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("repair.ogg", 0.9f);
								this.KKLEEIBNIBC.BFHKBOPOFGB = false;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
								return;
							}
							if (this.AMBNJGDIDED >= 53 && KBJGAFNMGCK.IKGFHGKKCPG.GIEKGGIOLKM(this.AMBNJGDIDED).GHFFJNCLLDK(this.OJKBEDCFFND).PFMPBFOIMLJ && this.KKLEEIBNIBC.ILFHHDNJHNM > 1)
							{
								FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("repair.ogg", 0.9f);
								this.KKLEEIBNIBC.ILFHHDNJHNM = this.KKLEEIBNIBC.ILFHHDNJHNM - 1;
								EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
								try
								{
									epmphjgalbe2.OBCCLNMPGEJ(this.KKLEEIBNIBC.LPFKFNLHGBI);
									epmphjgalbe2.GOMLLPFFPNP(1);
									epmphjgalbe2.GOMLLPFFPNP(this.AMBNJGDIDED);
									epmphjgalbe2.GOMLLPFFPNP(this.OJKBEDCFFND);
									NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(200, epmphjgalbe2.JDPHBLHOLAD());
								}
								finally
								{
									epmphjgalbe2.LMBPNFHKNGA();
								}
								if (aeneoofmbke != null)
								{
									aeneoofmbke.AFOLABIACNF();
								}
								if (aeneoofmbke2 != null)
								{
									aeneoofmbke2.AFOLABIACNF();
								}
								this.KKLEEIBNIBC.BFHKBOPOFGB = false;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
								return;
							}
							this.KKLEEIBNIBC.BFHKBOPOFGB = false;
							int jgniddbnggp = this.KKLEEIBNIBC.JGNIDDBNGGP;
							int dmamopgjock = this.KKLEEIBNIBC.DMAMOPGJOCK;
							this.KKLEEIBNIBC.DMAMOPGJOCK = this.OJKBEDCFFND;
							this.KKLEEIBNIBC.JGNIDDBNGGP = this.AMBNJGDIDED;
							this.IGPBJBNODII(jgniddbnggp, dmamopgjock);
							this.IGPBJBNODII(this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK);
							FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_02.wav", 1f);
							EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
							try
							{
								epmphjgalbe3.OBCCLNMPGEJ(this.KKLEEIBNIBC.LPFKFNLHGBI);
								epmphjgalbe3.GOMLLPFFPNP(this.KKLEEIBNIBC.JGNIDDBNGGP);
								epmphjgalbe3.GOMLLPFFPNP(this.KKLEEIBNIBC.DMAMOPGJOCK);
								NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(182, epmphjgalbe3.JDPHBLHOLAD());
								goto IL_C7D;
							}
							finally
							{
								epmphjgalbe3.LMBPNFHKNGA();
							}
						}
					}
					FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
					this.KKLEEIBNIBC.BFHKBOPOFGB = false;
					this.KKLEEIBNIBC = null;
					JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
				}
				else
				{
					if (Input.GetKey(KeyCode.LeftControl))
					{
						FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
						this.KKLEEIBNIBC.BFHKBOPOFGB = false;
						this.KKLEEIBNIBC = null;
						JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
						if (aeneoofmbke != null)
						{
							aeneoofmbke.AFOLABIACNF();
						}
						if (aeneoofmbke2 != null)
						{
							aeneoofmbke2.AFOLABIACNF();
						}
						return;
					}
					if ((this.AMBNJGDIDED < 50 || this.AMBNJGDIDED == 52) && ekbapcmpani.HHOLFABGDJA == this.KKLEEIBNIBC.HHOLFABGDJA && ekbapcmpani.KBGHOIJIPJF == this.KKLEEIBNIBC.KBGHOIJIPJF && ekbapcmpani.ICOFLHIIBCP == this.KKLEEIBNIBC.ICOFLHIIBCP && ekbapcmpani.LODGJCMEGAI.JDHDFEHFNNG() == this.KKLEEIBNIBC.LODGJCMEGAI.JDHDFEHFNNG() && ekbapcmpani.ILFHHDNJHNM < ekbapcmpani.BDHHPAEHFHG.NPPJLOBFGBH && this.KKLEEIBNIBC.ILFHHDNJHNM < this.KKLEEIBNIBC.BDHHPAEHFHG.NPPJLOBFGBH && (ekbapcmpani.DLHPFGHOINI == (float)ekbapcmpani.BGGJKOMAKEE || this.KKLEEIBNIBC.DLHPFGHOINI == (float)this.KKLEEIBNIBC.BGGJKOMAKEE))
					{
						if (ekbapcmpani.ABPGFHKGFEK || this.KKLEEIBNIBC.ABPGFHKGFEK)
						{
							FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
							this.KKLEEIBNIBC.BFHKBOPOFGB = false;
							this.KKLEEIBNIBC = null;
							JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
							return;
						}
						if (ekbapcmpani.ILFHHDNJHNM + this.KKLEEIBNIBC.ILFHHDNJHNM > ekbapcmpani.BDHHPAEHFHG.NPPJLOBFGBH)
						{
							int num = ekbapcmpani.BDHHPAEHFHG.NPPJLOBFGBH - ekbapcmpani.ILFHHDNJHNM;
							ekbapcmpani.ILFHHDNJHNM += num;
							this.KKLEEIBNIBC.ILFHHDNJHNM = this.KKLEEIBNIBC.ILFHHDNJHNM - num;
						}
						else
						{
							ekbapcmpani.ILFHHDNJHNM += this.KKLEEIBNIBC.ILFHHDNJHNM;
							JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MGKFACGMAOD(this.KKLEEIBNIBC.LPFKFNLHGBI);
						}
						EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
						try
						{
							epmphjgalbe4.OBCCLNMPGEJ(ekbapcmpani.LPFKFNLHGBI);
							epmphjgalbe4.OBCCLNMPGEJ(this.KKLEEIBNIBC.LPFKFNLHGBI);
							NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(195, epmphjgalbe4.JDPHBLHOLAD());
						}
						finally
						{
							epmphjgalbe4.LMBPNFHKNGA();
						}
						this.IGPBJBNODII(this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK);
						FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("repair.ogg", 0.9f);
						this.KKLEEIBNIBC.BFHKBOPOFGB = false;
						this.KKLEEIBNIBC = null;
						JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
						if (aeneoofmbke != null)
						{
							aeneoofmbke.AFOLABIACNF();
						}
						if (aeneoofmbke2 != null)
						{
							aeneoofmbke2.AFOLABIACNF();
						}
						return;
					}
					else
					{
						if (this.AMBNJGDIDED == 51)
						{
							AENEOOFMBKE aeneoofmbke3 = JDCEFOFMGHB.IKGFHGKKCPG.AEGEHJLBECE(this.AMBNJGDIDED, this.OJKBEDCFFND);
							if (aeneoofmbke3 != null)
							{
								Debug.Log("dragWeapon = null 3");
								JDCEFOFMGHB.IKGFHGKKCPG.GLPNNGNMHOO(this.KKLEEIBNIBC);
								aeneoofmbke3.OBLONDPEGLN = this.KKLEEIBNIBC;
								this.KKLEEIBNIBC.BFHKBOPOFGB = false;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
								if (aeneoofmbke != null)
								{
									aeneoofmbke.AFOLABIACNF();
								}
								if (aeneoofmbke2 != null)
								{
									aeneoofmbke2.AFOLABIACNF();
								}
								return;
							}
						}
						if (this.AMBNJGDIDED == 52 && this.KKLEEIBNIBC.JGNIDDBNGGP < 50)
						{
							this.KKLEEIBNIBC.BFHKBOPOFGB = false;
							this.KKLEEIBNIBC = null;
							return;
						}
						if (this.KINAHOLLCGB(this.KKLEEIBNIBC, this.AMBNJGDIDED, this.OJKBEDCFFND) && this.KINAHOLLCGB(ekbapcmpani, this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK))
						{
							if (this.AMBNJGDIDED >= 53 || ekbapcmpani.JGNIDDBNGGP >= 53)
							{
								KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = KBJGAFNMGCK.IKGFHGKKCPG.GIEKGGIOLKM(this.AMBNJGDIDED).GHFFJNCLLDK(this.OJKBEDCFFND);
								KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb2 = KBJGAFNMGCK.IKGFHGKKCPG.GIEKGGIOLKM(ekbapcmpani.JGNIDDBNGGP).GHFFJNCLLDK(ekbapcmpani.DMAMOPGJOCK);
								if ((this.KKLEEIBNIBC.ILFHHDNJHNM > 1 || ekbapcmpani.ILFHHDNJHNM > 1) && (ldjpekhhnhb2.PFMPBFOIMLJ || ldjpekhhnhb.PFMPBFOIMLJ))
								{
									FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
									this.KKLEEIBNIBC.BFHKBOPOFGB = false;
									this.KKLEEIBNIBC = null;
									JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
									if (aeneoofmbke != null)
									{
										aeneoofmbke.AFOLABIACNF();
									}
									if (aeneoofmbke2 != null)
									{
										aeneoofmbke2.AFOLABIACNF();
									}
									return;
								}
								if (ldjpekhhnhb.PFMPBFOIMLJ && this.KKLEEIBNIBC.ILFHHDNJHNM > 1)
								{
									FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
									this.KKLEEIBNIBC.BFHKBOPOFGB = false;
									this.KKLEEIBNIBC = null;
									JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
									if (aeneoofmbke != null)
									{
										aeneoofmbke.AFOLABIACNF();
									}
									if (aeneoofmbke2 != null)
									{
										aeneoofmbke2.AFOLABIACNF();
									}
									return;
								}
							}
							ekbapcmpani.JGNIDDBNGGP = this.KKLEEIBNIBC.JGNIDDBNGGP;
							ekbapcmpani.DMAMOPGJOCK = this.KKLEEIBNIBC.DMAMOPGJOCK;
							this.KKLEEIBNIBC.BFHKBOPOFGB = false;
							this.KKLEEIBNIBC.DMAMOPGJOCK = this.OJKBEDCFFND;
							this.KKLEEIBNIBC.JGNIDDBNGGP = this.AMBNJGDIDED;
							this.IGPBJBNODII(this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK);
							this.IGPBJBNODII(ekbapcmpani.JGNIDDBNGGP, ekbapcmpani.DMAMOPGJOCK);
							FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_02.wav", 1f);
							EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
							try
							{
								epmphjgalbe5.OBCCLNMPGEJ(this.KKLEEIBNIBC.LPFKFNLHGBI);
								epmphjgalbe5.OBCCLNMPGEJ(ekbapcmpani.LPFKFNLHGBI);
								NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(184, epmphjgalbe5.JDPHBLHOLAD());
								goto IL_C7D;
							}
							finally
							{
								epmphjgalbe5.LMBPNFHKNGA();
							}
						}
						FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
						this.KKLEEIBNIBC.BFHKBOPOFGB = false;
						this.KKLEEIBNIBC = null;
						JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
					}
				}
				IL_C7D:
				this.KKLEEIBNIBC = null;
				JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = true;
			}
			else
			{
				this.KKLEEIBNIBC.BFHKBOPOFGB = false;
				this.KKLEEIBNIBC = null;
				JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
			}
			if (aeneoofmbke != null)
			{
				aeneoofmbke.AFOLABIACNF();
			}
			if (aeneoofmbke2 != null)
			{
				aeneoofmbke2.AFOLABIACNF();
			}
			BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		}
	}

	// Token: 0x06005200 RID: 20992 RVA: 0x0026262C File Offset: 0x0026082C
	public void IFADELLPHJP(ONKDCGNBALK OJIMHKHFOJI)
	{
		Debug.Log("ArmFlex");
		if (Fisherman.getI != null && Fisherman.getI.MFENINHGBHM)
		{
			this.KOCKAHEKJDB();
			return;
		}
		Fisherman.getI.sendAction(6, 1700f, Vector3.zero);
		JDCEFOFMGHB.HMJJPNDEKPP().CBHHEHHNFKL(this.NGKLLCCLFCM);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().DKOFCBMKEPC(372f, 1536f, JNBICAJIJMM.CDDCIKKDFMP("Idle180"), true);
		this.NGKLLCCLFCM = onkdcgnbalk.LPFKFNLHGBI;
		onkdcgnbalk.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.LKEOMIACNIJ);
		onkdcgnbalk.ENCPJNMMMJI = new ONKDCGNBALK.CMMHGMILOIM(this.PIDKLEKJLFE);
		onkdcgnbalk.FONJHMOACFJ = new ONKDCGNBALK.CMMHGMILOIM(this.AIBOPCFGKFO);
		Rect rect = new Rect(1514f, 1800f, 1743f, 312f);
		new EGCAADAABPP(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, "GiantGrabThrow", 1, null).NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.NEPBGGBGCDD);
		new MGLHIBHDMPC(onkdcgnbalk, 1421f, 1938f, 1, GameInterface.getI.invBackMan);
		this.OEADFAEEJJP = new LCOLJOPGDLL(onkdcgnbalk, 541f, 628f, 1078f, 1079f, JNBICAJIJMM.CLIMNFDGOEG().NMIJBEJBGNB("Fist Pump 2", "" + this.DJEOAABGBHH + "SixStep"), TextAnchor.UpperCenter, Color.black);
		int num = 16;
		for (int i = 0; i <= JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.IPPNBPONFHK; i += 0)
		{
			this.CPCHDFOFJIA[i] = new MEMEOHJKPNJ(onkdcgnbalk, 952f, (float)num, 153f, 1529f, JNBICAJIJMM.EEOPOHEALPK().IPHGEPDFCJL("RollerBladeCrossoverRight", "_NeutralTonemapperParams1" + i + "move"), i, null, new ONKDCGNBALK.CMMHGMILOIM(this.ABCHPMBIAMH));
			if (i == this.DJEOAABGBHH)
			{
				this.CPCHDFOFJIA[i].HKPAEGGJNGG = true;
			}
			num += -75;
		}
		new EGCAADAABPP(onkdcgnbalk, 1155f, 1841f, onkdcgnbalk.OCHCODJIPHJ.width, onkdcgnbalk.OCHCODJIPHJ.height, "Textures/Fish/", 1, null).NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.BCLKJEKLGEN);
		new EGCAADAABPP(onkdcgnbalk, 1507f, 519f, 1409f, 1760f, "_SunPosition", 0, null).NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.CBNIGBLJCIL);
	}

	// Token: 0x06005201 RID: 20993 RVA: 0x002628A8 File Offset: 0x00260AA8
	public void AIBOPCFGKFO(ONKDCGNBALK JMAKEAHMLMI)
	{
		if (this.OJKBEDCFFND < 0)
		{
			return;
		}
		this.KPILNBINPMN = this.KIFEKEONBOL(this.AMBNJGDIDED, this.OJKBEDCFFND);
		if (this.KPILNBINPMN == null)
		{
			return;
		}
		bool isVisible = this.KPILNBINPMN.IMDLBJICHOE();
		this.EIPJCEDGFGM = new List<ItemBase>();
		if (this.KPILNBINPMN.DNOLHLJODNK && this.KPILNBINPMN.LNKLEIEFGCP < -66)
		{
			this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.CLIMNFDGOEG().ECNKLECOKHD("206000"))
			{
				tag = 79L
			});
		}
		if (this.KPILNBINPMN.BDHHPAEHFHG.KKOLKEEALFD)
		{
			this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.EKEBHIJMEML().FLEANFGEJML("Hidden/DepthOfField/MedianFilter"))
			{
				tag = -60L
			});
		}
		int mbkmkgabbge = this.KPILNBINPMN.BDHHPAEHFHG.MBKMKGABBGE;
		switch (mbkmkgabbge)
		{
		case 0:
		case 1:
		case 2:
		case 3:
		case 4:
			if ((this.KPILNBINPMN.BDHHPAEHFHG.FOAPCABBLBG || this.KPILNBINPMN.MJHGLLIJMIM) && (this.KPILNBINPMN.MJHGLLIJMIM || this.KPILNBINPMN.DLHPFGHOINI < (float)this.KPILNBINPMN.BGGJKOMAKEE))
			{
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IMLLGEMPHAP().CCFFMKBBKHI("L"))
				{
					tag = -38L
				});
			}
			if (this.KPILNBINPMN.LOLCPOPODKE("body", " ").MFHCGLHGAID().Count > 0)
			{
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IMLLGEMPHAP().DOEMGEAEBPN("Item "))
				{
					tag = 71L,
					isVisible = isVisible
				});
				goto IL_41B;
			}
			goto IL_41B;
		case 5:
		case 6:
		case 7:
		case 8:
			goto IL_41B;
		case 9:
			break;
		default:
			switch (mbkmkgabbge)
			{
			case -11:
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("Manifest: "))
				{
					tag = -116L,
					isVisible = isVisible
				});
				goto IL_41B;
			case -10:
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.DOEMGEAEBPN("u_pass"))
				{
					tag = -12L,
					isVisible = isVisible
				});
				goto IL_41B;
			case -9:
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.CKAOHMEKLMH("SexyDance"))
				{
					tag = 103L,
					isVisible = isVisible
				});
				goto IL_41B;
			case -8:
			case -7:
			case -6:
				break;
			case -5:
			case -2:
				if (this.KPILNBINPMN.BDHHPAEHFHG.HBHBAIONJHD)
				{
					this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.EKEBHIJMEML().HEIBEHAEHBM("Bone 1 of a BipedReferences limb is null."))
					{
						tag = 7L,
						isVisible = isVisible
					});
					goto IL_41B;
				}
				goto IL_41B;
			case -4:
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.DOEMGEAEBPN("crft_norec2"))
				{
					tag = -119L,
					isVisible = isVisible
				});
				goto IL_41B;
			case -3:
			case -1:
			case 0:
			case 1:
				goto IL_41B;
			case 2:
			{
				int num = this.KPILNBINPMN.BDHHPAEHFHG.MIMANMPNLPE.KMIOLLENCOL();
				if (NLNNIDBPKAO.IKGFHGKKCPG.PGAMAJNPFFE(num) == null)
				{
					goto IL_41B;
				}
				if (!JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.GADJFFGDCFA.ContainsKey(num))
				{
					this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.NLJOLOBPCBJ("itemsdata/items/item"))
					{
						tag = 2L,
						isVisible = isVisible
					});
					goto IL_41B;
				}
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("inv_useeff"))
				{
					tag = 1L,
					isVisible = isVisible
				});
				goto IL_41B;
			}
			default:
				goto IL_41B;
			}
			break;
		}
		if (this.KPILNBINPMN.BDHHPAEHFHG.DKFCKFJBNIM)
		{
			if (this.KPILNBINPMN.BDHHPAEHFHG.FOAPCABBLBG)
			{
				float num2 = this.KPILNBINPMN.DLHPFGHOINI + 508f;
				float num3 = (float)this.KPILNBINPMN.BGGJKOMAKEE;
			}
			if (this.KPILNBINPMN.ICOFLHIIBCP)
			{
			}
		}
		IL_41B:
		if (!this.KPILNBINPMN.ICOFLHIIBCP)
		{
			if (this.KPILNBINPMN.BDHHPAEHFHG.PKKLNODNCBE && !this.KPILNBINPMN.ICOFLHIIBCP)
			{
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.CLIMNFDGOEG().DOEMGEAEBPN("OfficeSittingReading"))
				{
					tag = -24L
				});
			}
			if (this.KPILNBINPMN.BDHHPAEHFHG.DKFCKFJBNIM && !this.KPILNBINPMN.ICOFLHIIBCP)
			{
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.DBMJJPBOPEK().CKAOHMEKLMH("signal_enable"))
				{
					tag = -74L
				});
			}
		}
		if (this.EIPJCEDGFGM.Count > 1)
		{
			this.EIPJCEDGFGM.Add(new ItemBase("Inventory manager is init")
			{
				tag = -1L
			});
		}
		this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.LPHMKPDBMPP().CCFFMKBBKHI(""))
		{
			tag = 1L
		});
		this.EIPJCEDGFGM.Add(new ItemBase("msg_other")
		{
			tag = -1L
		});
		this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.ECNKLECOKHD("wpn_add/base"))
		{
			tag = 3L
		});
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		Vector2 vector2 = new Vector2(vector.x + 1318f, vector.y - 1531f);
		if (vector2.x + 825f > (float)(Screen.width - 51))
		{
			vector2.x = (float)(Screen.width - 45 - -122);
		}
		if (vector2.y + 785f > (float)(Screen.height - 60))
		{
			vector2.y = (float)(Screen.height - 10 - -37);
		}
		this.MCMGPBDHCLN = new Rect(vector2.x, vector2.y, 78f, 961f + (float)this.EIPJCEDGFGM.Count * 158f);
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("Hit Point WeightCurve length is zero.", 1626f);
	}

	// Token: 0x06005202 RID: 20994 RVA: 0x00262EE4 File Offset: 0x002610E4
	public void AHJJJBAMEHE(ONKDCGNBALK JMBKDINHDLO)
	{
		Debug.Log("OK auk2KeyMEditOk---1");
		this.DCFMECEHGEM = JMBKDINHDLO.ODFEKBJCFMN;
		if (this.BBOKGAOOIMG > this.DCFMECEHGEM)
		{
			this.DCFMECEHGEM = this.BBOKGAOOIMG;
		}
		this.CMHGFDDMCAK();
		Debug.Log("OK auk2KeyMEditOk---2");
	}

	// Token: 0x06005203 RID: 20995 RVA: 0x00262F34 File Offset: 0x00261134
	public EKBAPCMPANI EHHKCFOAKAI(int JGNIDDBNGGP, int DMAMOPGJOCK)
	{
		foreach (EKBAPCMPANI ekbapcmpani in JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PLLHGAFIAFD.Values)
		{
			if (ekbapcmpani.JGNIDDBNGGP == JGNIDDBNGGP && ekbapcmpani.DMAMOPGJOCK == DMAMOPGJOCK && !ekbapcmpani.BFHKBOPOFGB)
			{
				return ekbapcmpani;
			}
		}
		return null;
	}

	// Token: 0x06005204 RID: 20996 RVA: 0x00262FB0 File Offset: 0x002611B0
	public void ADAJGDDDCPK(ONKDCGNBALK ONPHLHKAGFP)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(true);
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.OBJBHBFAFEE(this.COKDFMFFDAE.LPFKFNLHGBI);
			epmphjgalbe.GOMLLPFFPNP(this.POHLPMPEOKO.LKAGIEBPLAI);
			NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(183, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		JDCEFOFMGHB.IKGFHGKKCPG.DGFAPDDBHJB(this.ONGEHMJIMLO);
	}

	// Token: 0x06005205 RID: 20997 RVA: 0x00263030 File Offset: 0x00261230
	public void JBKMGGEGPCD(int APABMACIAOK, ONKDCGNBALK PHEMLBHMNCM, bool LNNOCAFJMAC = false)
	{
		if (LNNOCAFJMAC && BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() != null)
		{
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
			GUIStyle style = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperRight,
				wordWrap = true,
				richText = true,
				font = GuiProcessor.IKGFHGKKCPG.rusfont,
				fontSize = 12
			};
			Rect position = new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width - 354f, PHEMLBHMNCM.OCHCODJIPHJ.y + 430f, 300f, 22f);
			GUI.Label(position, string.Format(JNBICAJIJMM.LEBHCLDODNI("rod_inf1"), bgjkmcbhnak.FOAAFGBHDAH), style);
			position.y += 17f;
			double haajdghfica = (double)(Mathf.RoundToInt(bgjkmcbhnak.JJEFFBGECGL * 100f) / 100);
			int num = Mathf.RoundToInt(bgjkmcbhnak.IGDMILBFAPF * 100f) / 100;
			GUI.Label(position, string.Format(JNBICAJIJMM.LEBHCLDODNI("rod_inf2"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL(haajdghfica)), style);
			position.y += 17f;
		}
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		float num2 = PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.x;
		float num3 = PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.y;
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		if (PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.width < 600f)
		{
			return;
		}
		if (PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.width > 600f && LNNOCAFJMAC)
		{
			int num4 = (int)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MHIIBKILGBL("act_order");
			if (num4 == 0)
			{
				num4 = 100;
			}
			int num5 = num4 % 100;
			int num6 = (int)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MHIIBKILGBL("act_orderb_" + num5);
			string fggpeeghgmf = string.Format("act_prof_{0}", num4);
			int num7 = (int)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MHIIBKILGBL(fggpeeghgmf);
			GUIStyle style2 = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleCenter,
				wordWrap = true,
				richText = true,
				font = GuiProcessor.IKGFHGKKCPG.rusfont3,
				fontSize = 11
			};
			for (int i = 0; i < 6; i++)
			{
				string arg = "#000000";
				if (i == num6)
				{
					arg = "#003080";
				}
				if (i > num7)
				{
					GUI.enabled = false;
				}
				else
				{
					if (i == 0)
					{
						GUI.enabled = true;
					}
					string text = string.Format("<color='{0}'>{1}</color>", arg, JLFJEGIPIMM.IKGFHGKKCPG.IEICGMEMPIK(i + 1));
					Rect position2 = new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width - 65f - 40f, PHEMLBHMNCM.OCHCODJIPHJ.y + 75f + (float)(i * 19), 40f, 16f);
					if (GUI.Button(position2, ""))
					{
						FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("repair.ogg", 1f);
						JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.JCDBCEEKJPF(num4, i);
						DownPanelLogic.getI.OnRodChangeClck(num4);
					}
					GUI.Label(position2, text, style2);
				}
			}
		}
		GUI.enabled = true;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.IKGFHGKKCPG.GIEKGGIOLKM(APABMACIAOK);
		foreach (KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb in dcjidjjkjck.JHFOAGALPOD)
		{
			Rect position3 = new Rect(ldjpekhhnhb.NBADAMPJBBH.JLLJFKOGLHJ, ldjpekhhnhb.NBADAMPJBBH.OBEOJCGHOGL, 56f, 56f);
			bool flag = false;
			Rect rect = new Rect(num2 + ldjpekhhnhb.NBADAMPJBBH.JLLJFKOGLHJ, num3 + ldjpekhhnhb.NBADAMPJBBH.OBEOJCGHOGL, 58f, 58f);
			if (rect.Contains(vector))
			{
				this.OJKBEDCFFND = ldjpekhhnhb.LPFKFNLHGBI;
				this.AMBNJGDIDED = dcjidjjkjck.LPFKFNLHGBI;
				this.DKFICLCPICL.x = vector.x - rect.x;
				this.DKFICLCPICL.y = vector.y - rect.y;
				this.ABLFGLMKPNO = true;
			}
			bool flag2 = true;
			if (!flag && this.KKLEEIBNIBC != null && ldjpekhhnhb.OBGAGPMCPNK(this.KKLEEIBNIBC.BDHHPAEHFHG.MBKMKGABBGE))
			{
				GUI.DrawTexture(position3, GameInterface.getI.invEmptyCellSelect);
				flag2 = false;
			}
			if (flag2)
			{
				GUI.DrawTexture(position3, GameInterface.getI.invEmptyCell);
			}
			if (ldjpekhhnhb.OCEGMAKMPJB > 0)
			{
				GUI.DrawTextureWithTexCoords(position3, GameInterface.getI.cellsIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(ldjpekhhnhb.OCEGMAKMPJB, 8, 8));
			}
		}
		foreach (EKBAPCMPANI ekbapcmpani in kfhelhglnmh.PLLHGAFIAFD.Values)
		{
			if (ekbapcmpani.JGNIDDBNGGP == APABMACIAOK)
			{
				KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb2 = dcjidjjkjck.GHFFJNCLLDK(ekbapcmpani.DMAMOPGJOCK);
				if (ldjpekhhnhb2 == null)
				{
					Debug.LogError("No Cell wpn.cell=" + ekbapcmpani.DMAMOPGJOCK);
				}
				else
				{
					ekbapcmpani.JCIIPCEDICP(new Vector2(ldjpekhhnhb2.NBADAMPJBBH.JLLJFKOGLHJ, ldjpekhhnhb2.NBADAMPJBBH.OBEOJCGHOGL), 56f);
				}
			}
		}
	}

	// Token: 0x06005207 RID: 20999 RVA: 0x00263624 File Offset: 0x00261824
	public void ACPGHOPAMOH(ONKDCGNBALK PJNHODBDCEL)
	{
		int num = 0;
		int num2 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GMLFCKNNOPJ();
		Rect position = new Rect(PJNHODBDCEL.OCHCODJIPHJ.x - 38f, PJNHODBDCEL.OCHCODJIPHJ.y + 8f + (float)(num * 27), 40f, 26f);
		GUI.DrawTextureWithTexCoords(position, GameInterface.getI.RodOrderTexture, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB((num2 == 100) ? 0 : 1, 2, 4), true);
		if (GUI.Button(position, "", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("repair.ogg", 1f);
			DownPanelLogic.getI.OnRodChangeClck(100);
		}
		num++;
		Rect position2 = new Rect(PJNHODBDCEL.OCHCODJIPHJ.x - 38f, PJNHODBDCEL.OCHCODJIPHJ.y + 8f + (float)(num * 27), 40f, 26f);
		GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.RodOrderTexture, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(2 + ((num2 == 102) ? 0 : 1), 2, 4), true);
		if (GUI.Button(position2, "", GUIStyle.none))
		{
			DownPanelLogic.getI.OnRodChangeClck(102);
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("repair.ogg", 1f);
		}
		num++;
		Rect position3 = new Rect(PJNHODBDCEL.OCHCODJIPHJ.x - 38f, PJNHODBDCEL.OCHCODJIPHJ.y + 8f + (float)(num * 27), 40f, 26f);
		GUI.DrawTextureWithTexCoords(position3, GameInterface.getI.RodOrderTexture, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(4 + ((num2 == 101) ? 0 : 1), 2, 4), true);
		if (GUI.Button(position3, "", GUIStyle.none))
		{
			DownPanelLogic.getI.OnRodChangeClck(101);
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("repair.ogg", 1f);
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MNCBACCMAAA(num2);
		if (bgjkmcbhnak != null)
		{
			Rect position4 = new Rect(PJNHODBDCEL.OCHCODJIPHJ.x + PJNHODBDCEL.OCHCODJIPHJ.width - 83f, PJNHODBDCEL.OCHCODJIPHJ.y + 8f, 28f, 28f);
			int clbpbjglhee = 0;
			if (bgjkmcbhnak.IKKPFPJLPOL)
			{
				clbpbjglhee = bgjkmcbhnak.NKNCNHGDMLF.BDHHPAEHFHG.GCLKLEIMABA;
			}
			GUI.DrawTextureWithTexCoords(position4, GameInterface.getI.RodStatusTexture, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(clbpbjglhee, 8, 8), true);
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06005208 RID: 21000 RVA: 0x0026387D File Offset: 0x00261A7D
	// (set) Token: 0x0600520C RID: 21004 RVA: 0x0026463C File Offset: 0x0026283C
	public EKBAPCMPANI EHBIGHBEIDC
	{
		get
		{
			return this.EBKMEHACMJE;
		}
		set
		{
			this.EBKMEHACMJE = value;
		}
	}

	// Token: 0x06005209 RID: 21001 RVA: 0x00263888 File Offset: 0x00261A88
	public void CHBAGGLBMLG(ONKDCGNBALK JMAKEAHMLMI)
	{
		if (this.KKLEEIBNIBC != null)
		{
			if (this.KKLEEIBNIBC.MBKMKGABBGE == 40 && (this.KKLEEIBNIBC.JGNIDDBNGGP == -74 || this.AMBNJGDIDED == -120) && JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.NAFGMKJPLPC.Count > 0)
			{
				JDCEFOFMGHB.JFIDAGABKID().BEIDJANKEFD(JNBICAJIJMM.APMJBBDBOJO().NLJOLOBPCBJ("null"), JNBICAJIJMM.EEOPOHEALPK().HEIBEHAEHBM("Special"));
				this.KKLEEIBNIBC.BFHKBOPOFGB = false;
				this.KKLEEIBNIBC = null;
				JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB = true;
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("human_move_2.wav", 1043f);
				return;
			}
			AENEOOFMBKE aeneoofmbke = JDCEFOFMGHB.HMJJPNDEKPP().AEGEHJLBECE(this.AMBNJGDIDED, this.OJKBEDCFFND);
			AENEOOFMBKE aeneoofmbke2 = JDCEFOFMGHB.IKGFHGKKCPG.EDKBLBGEBNH(this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK);
			if (this.OJKBEDCFFND >= 1)
			{
				EKBAPCMPANI ekbapcmpani = this.EHHKCFOAKAI(this.AMBNJGDIDED, this.OJKBEDCFFND);
				if (ekbapcmpani == null)
				{
					if (this.PAGOJABJFCB(this.KKLEEIBNIBC, this.AMBNJGDIDED, this.OJKBEDCFFND))
					{
						if (this.AMBNJGDIDED == 64)
						{
							int ojkbedcffnd = this.OJKBEDCFFND;
							if (ojkbedcffnd == 0)
							{
								Debug.Log("cht_tofrendmsg");
								this.COKDFMFFDAE = this.KKLEEIBNIBC;
								this.KKLEEIBNIBC = null;
								string arg = this.COKDFMFFDAE.BDHHPAEHFHG.BNIHFBMEPAB ?? " listed as it's child.";
								JDCEFOFMGHB.HMJJPNDEKPP().LLKDAODBJDA(JNBICAJIJMM.PPNKMDJBMLP("ClimbRight"), string.Format(JNBICAJIJMM.PPNKMDJBMLP("cnt_energ"), arg), new ONKDCGNBALK.CMMHGMILOIM(this.NENBEFDNCPO), new ONKDCGNBALK.CMMHGMILOIM(this.NENBEFDNCPO));
								FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("BAG", 884f);
							}
							return;
						}
						if (Input.GetKey((KeyCode)138))
						{
							if (this.KKLEEIBNIBC.ILFHHDNJHNM <= 1)
							{
								FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("****softSpawn to ", 1026f);
								this.KKLEEIBNIBC.BFHKBOPOFGB = false;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = true;
								return;
							}
							if (this.KKLEEIBNIBC.ILFHHDNJHNM <= 0)
							{
								FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("_NoiseTex", 1831f);
								this.KKLEEIBNIBC.ILFHHDNJHNM = this.KKLEEIBNIBC.ILFHHDNJHNM - 0;
								EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
								try
								{
									epmphjgalbe.OBCCLNMPGEJ(this.KKLEEIBNIBC.LPFKFNLHGBI);
									epmphjgalbe.AEMAHNDEBKJ(0);
									epmphjgalbe.ENDMKPCFKND(this.AMBNJGDIDED);
									epmphjgalbe.AEMAHNDEBKJ(this.OJKBEDCFFND);
									NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-173, epmphjgalbe.LAFILAEOPAJ());
									goto IL_416;
								}
								finally
								{
									epmphjgalbe.HDKBMLOJLLC();
								}
								goto IL_2B4;
								IL_416:
								this.KKLEEIBNIBC.BFHKBOPOFGB = false;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = true;
								FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("_FullResolutionFiltering", 806f);
								return;
							}
							IL_2B4:
							this.IFHBHHBMNFK = this.AMBNJGDIDED;
							this.LMDDMCEJHOG = this.OJKBEDCFFND;
							ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().NCIDDNIKACI(1606f, 1805f, JNBICAJIJMM.BDKHMOOFHHK(" iterations for read and write"), true);
							this.CMGJHIHGCNP = new KJPFDOGHGOD(onkdcgnbalk, JNBICAJIJMM.DIOJFJMOPJO("ApplePick"), 1197f, 1325f, onkdcgnbalk.OCHCODJIPHJ.width - 380f, 403f, (float)(this.KKLEEIBNIBC.ILFHHDNJHNM - 0), (float)(this.KKLEEIBNIBC.ILFHHDNJHNM / 5), false, 0);
							new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1280f - 1720f, onkdcgnbalk.OCHCODJIPHJ.height - 523f, 276f, 485f, JNBICAJIJMM.CDDCIKKDFMP("RollerBladeSkateFwd"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.CPMFLNPOFFO));
							new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 931f - 669f, onkdcgnbalk.OCHCODJIPHJ.height - 413f, 557f, 382f, JNBICAJIJMM.CELEPPAEKAB("-no result-"), 7, null, new ONKDCGNBALK.CMMHGMILOIM(this.DIGGACIAOHJ));
							this.COKDFMFFDAE = this.KKLEEIBNIBC;
							this.KKLEEIBNIBC.BFHKBOPOFGB = false;
							this.KKLEEIBNIBC = null;
							JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB = true;
							return;
						}
						else
						{
							if (this.AMBNJGDIDED == -12 && aeneoofmbke != null)
							{
								JDCEFOFMGHB.HMJJPNDEKPP().GLPNNGNMHOO(this.KKLEEIBNIBC);
								aeneoofmbke.OBLONDPEGLN = this.KKLEEIBNIBC;
								FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("_GrainTex", 1700f);
								this.KKLEEIBNIBC.BFHKBOPOFGB = false;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB = true;
								return;
							}
							if (this.AMBNJGDIDED >= 63 && KBJGAFNMGCK.BBLINJLBAIL().KGPMEIGMNNG(this.AMBNJGDIDED).AJPNNJEJGHI(this.OJKBEDCFFND).PFMPBFOIMLJ && this.KKLEEIBNIBC.ILFHHDNJHNM > 1)
							{
								FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("name", 619f);
								this.KKLEEIBNIBC.ILFHHDNJHNM = this.KKLEEIBNIBC.ILFHHDNJHNM - 0;
								EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
								try
								{
									epmphjgalbe2.OACBICLGENB(this.KKLEEIBNIBC.LPFKFNLHGBI);
									epmphjgalbe2.GOMLLPFFPNP(0);
									epmphjgalbe2.PDEFLCIEMFF(this.AMBNJGDIDED);
									epmphjgalbe2.ALNEALEKFNB(this.OJKBEDCFFND);
									NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(188, epmphjgalbe2.ALLANCHILCM());
								}
								finally
								{
									epmphjgalbe2.PGLFHABMJPO();
								}
								if (aeneoofmbke != null)
								{
									aeneoofmbke.AFOLABIACNF();
								}
								if (aeneoofmbke2 != null)
								{
									aeneoofmbke2.ENGOGGKIGHD();
								}
								this.KKLEEIBNIBC.BFHKBOPOFGB = true;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = false;
								return;
							}
							this.KKLEEIBNIBC.BFHKBOPOFGB = true;
							int jgniddbnggp = this.KKLEEIBNIBC.JGNIDDBNGGP;
							int dmamopgjock = this.KKLEEIBNIBC.DMAMOPGJOCK;
							this.KKLEEIBNIBC.DMAMOPGJOCK = this.OJKBEDCFFND;
							this.KKLEEIBNIBC.JGNIDDBNGGP = this.AMBNJGDIDED;
							this.IGPBJBNODII(jgniddbnggp, dmamopgjock);
							this.IGPBJBNODII(this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK);
							FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("_Vignette_Color", 1645f);
							EPMPHJGALBE epmphjgalbe3 = new EPMPHJGALBE();
							try
							{
								epmphjgalbe3.OBJBHBFAFEE(this.KKLEEIBNIBC.LPFKFNLHGBI);
								epmphjgalbe3.AEMAHNDEBKJ(this.KKLEEIBNIBC.JGNIDDBNGGP);
								epmphjgalbe3.KPCGLGHDILI(this.KKLEEIBNIBC.DMAMOPGJOCK);
								NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(51, epmphjgalbe3.IEJLLFECFHF());
								goto IL_C7D;
							}
							finally
							{
								epmphjgalbe3.KNPHNLLMJKJ();
							}
						}
					}
					FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("cht_msg13", 1625f);
					this.KKLEEIBNIBC.BFHKBOPOFGB = true;
					this.KKLEEIBNIBC = null;
					JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB = true;
				}
				else
				{
					if (Input.GetKey((KeyCode)(-13)))
					{
						FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("", 1412f);
						this.KKLEEIBNIBC.BFHKBOPOFGB = true;
						this.KKLEEIBNIBC = null;
						JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB = false;
						if (aeneoofmbke != null)
						{
							aeneoofmbke.LBMJLKIMMNL();
						}
						if (aeneoofmbke2 != null)
						{
							aeneoofmbke2.AILMHMDPDAJ();
						}
						return;
					}
					if ((this.AMBNJGDIDED < 81 || this.AMBNJGDIDED == -38) && ekbapcmpani.HHOLFABGDJA == this.KKLEEIBNIBC.HHOLFABGDJA && ekbapcmpani.KBGHOIJIPJF == this.KKLEEIBNIBC.KBGHOIJIPJF && ekbapcmpani.ICOFLHIIBCP == this.KKLEEIBNIBC.ICOFLHIIBCP && ekbapcmpani.LODGJCMEGAI.HDPFLBFDIBN() == this.KKLEEIBNIBC.LODGJCMEGAI.LAGCLCGBNLI() && ekbapcmpani.ILFHHDNJHNM < ekbapcmpani.BDHHPAEHFHG.NPPJLOBFGBH && this.KKLEEIBNIBC.ILFHHDNJHNM < this.KKLEEIBNIBC.BDHHPAEHFHG.NPPJLOBFGBH && (ekbapcmpani.DLHPFGHOINI == (float)ekbapcmpani.BGGJKOMAKEE || this.KKLEEIBNIBC.DLHPFGHOINI == (float)this.KKLEEIBNIBC.BGGJKOMAKEE))
					{
						if (ekbapcmpani.ABPGFHKGFEK || this.KKLEEIBNIBC.ABPGFHKGFEK)
						{
							FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO(" ", 1847f);
							this.KKLEEIBNIBC.BFHKBOPOFGB = true;
							this.KKLEEIBNIBC = null;
							JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB = true;
							return;
						}
						if (ekbapcmpani.ILFHHDNJHNM + this.KKLEEIBNIBC.ILFHHDNJHNM > ekbapcmpani.BDHHPAEHFHG.NPPJLOBFGBH)
						{
							int num = ekbapcmpani.BDHHPAEHFHG.NPPJLOBFGBH - ekbapcmpani.ILFHHDNJHNM;
							ekbapcmpani.ILFHHDNJHNM += num;
							this.KKLEEIBNIBC.ILFHHDNJHNM = this.KKLEEIBNIBC.ILFHHDNJHNM - num;
						}
						else
						{
							ekbapcmpani.ILFHHDNJHNM += this.KKLEEIBNIBC.ILFHHDNJHNM;
							JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.MGKFACGMAOD(this.KKLEEIBNIBC.LPFKFNLHGBI);
						}
						EPMPHJGALBE epmphjgalbe4 = new EPMPHJGALBE();
						try
						{
							epmphjgalbe4.PMJPIJMHELL(ekbapcmpani.LPFKFNLHGBI);
							epmphjgalbe4.MFPECHIKBCO(this.KKLEEIBNIBC.LPFKFNLHGBI);
							NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(-174, epmphjgalbe4.IEJLLFECFHF());
						}
						finally
						{
							epmphjgalbe4.HDKBMLOJLLC();
						}
						this.KDJCCKCHAKD(this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK);
						FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("KEyeHistogram", 1418f);
						this.KKLEEIBNIBC.BFHKBOPOFGB = false;
						this.KKLEEIBNIBC = null;
						JDCEFOFMGHB.MNJNNDHCDGG().BFHKBOPOFGB = false;
						if (aeneoofmbke != null)
						{
							aeneoofmbke.FDCGELJLOEI();
						}
						if (aeneoofmbke2 != null)
						{
							aeneoofmbke2.HKHLLGJHDCF();
						}
						return;
					}
					else
					{
						if (this.AMBNJGDIDED == -13)
						{
							AENEOOFMBKE aeneoofmbke3 = JDCEFOFMGHB.HMJJPNDEKPP().BKCBOFCIHNG(this.AMBNJGDIDED, this.OJKBEDCFFND);
							if (aeneoofmbke3 != null)
							{
								Debug.Log("");
								JDCEFOFMGHB.IKGFHGKKCPG.GLPNNGNMHOO(this.KKLEEIBNIBC);
								aeneoofmbke3.OBLONDPEGLN = this.KKLEEIBNIBC;
								this.KKLEEIBNIBC.BFHKBOPOFGB = true;
								this.KKLEEIBNIBC = null;
								JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = true;
								if (aeneoofmbke != null)
								{
									aeneoofmbke.MCKPBBIJGKF();
								}
								if (aeneoofmbke2 != null)
								{
									aeneoofmbke2.MCKPBBIJGKF();
								}
								return;
							}
						}
						if (this.AMBNJGDIDED == -89 && this.KKLEEIBNIBC.JGNIDDBNGGP < -104)
						{
							this.KKLEEIBNIBC.BFHKBOPOFGB = true;
							this.KKLEEIBNIBC = null;
							return;
						}
						if (this.PAGOJABJFCB(this.KKLEEIBNIBC, this.AMBNJGDIDED, this.OJKBEDCFFND) && this.PAGOJABJFCB(ekbapcmpani, this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK))
						{
							if (this.AMBNJGDIDED >= -50 || ekbapcmpani.JGNIDDBNGGP >= -79)
							{
								KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb = KBJGAFNMGCK.KFJMDGGMPJO().GDPECKOHOFD(this.AMBNJGDIDED).FABHFGACNOH(this.OJKBEDCFFND);
								KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb2 = KBJGAFNMGCK.BBLINJLBAIL().NJELCEJFBBN(ekbapcmpani.JGNIDDBNGGP).DCJGDANEMPD(ekbapcmpani.DMAMOPGJOCK);
								if ((this.KKLEEIBNIBC.ILFHHDNJHNM > 1 || ekbapcmpani.ILFHHDNJHNM > 0) && (ldjpekhhnhb2.PFMPBFOIMLJ || ldjpekhhnhb.PFMPBFOIMLJ))
								{
									FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("wpn_fid3", 12f);
									this.KKLEEIBNIBC.BFHKBOPOFGB = true;
									this.KKLEEIBNIBC = null;
									JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = true;
									if (aeneoofmbke != null)
									{
										aeneoofmbke.HKHLLGJHDCF();
									}
									if (aeneoofmbke2 != null)
									{
										aeneoofmbke2.FDCGELJLOEI();
									}
									return;
								}
								if (ldjpekhhnhb.PFMPBFOIMLJ && this.KKLEEIBNIBC.ILFHHDNJHNM > 0)
								{
									FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("Citates.xml", 1700f);
									this.KKLEEIBNIBC.BFHKBOPOFGB = false;
									this.KKLEEIBNIBC = null;
									JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
									if (aeneoofmbke != null)
									{
										aeneoofmbke.LBMJLKIMMNL();
									}
									if (aeneoofmbke2 != null)
									{
										aeneoofmbke2.ENGOGGKIGHD();
									}
									return;
								}
							}
							ekbapcmpani.JGNIDDBNGGP = this.KKLEEIBNIBC.JGNIDDBNGGP;
							ekbapcmpani.DMAMOPGJOCK = this.KKLEEIBNIBC.DMAMOPGJOCK;
							this.KKLEEIBNIBC.BFHKBOPOFGB = false;
							this.KKLEEIBNIBC.DMAMOPGJOCK = this.OJKBEDCFFND;
							this.KKLEEIBNIBC.JGNIDDBNGGP = this.AMBNJGDIDED;
							this.IGPBJBNODII(this.KKLEEIBNIBC.JGNIDDBNGGP, this.KKLEEIBNIBC.DMAMOPGJOCK);
							this.KDJCCKCHAKD(ekbapcmpani.JGNIDDBNGGP, ekbapcmpani.DMAMOPGJOCK);
							FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("X", 621f);
							EPMPHJGALBE epmphjgalbe5 = new EPMPHJGALBE();
							try
							{
								epmphjgalbe5.OACBICLGENB(this.KKLEEIBNIBC.LPFKFNLHGBI);
								epmphjgalbe5.OBJBHBFAFEE(ekbapcmpani.LPFKFNLHGBI);
								NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(138, epmphjgalbe5.PBOPEDMCKDD());
								goto IL_C7D;
							}
							finally
							{
								epmphjgalbe5.HDKBMLOJLLC();
							}
						}
						FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("Poplavok", 1897f);
						this.KKLEEIBNIBC.BFHKBOPOFGB = false;
						this.KKLEEIBNIBC = null;
						JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = true;
					}
				}
				IL_C7D:
				this.KKLEEIBNIBC = null;
				JDCEFOFMGHB.HMJJPNDEKPP().BFHKBOPOFGB = false;
			}
			else
			{
				this.KKLEEIBNIBC.BFHKBOPOFGB = true;
				this.KKLEEIBNIBC = null;
				JDCEFOFMGHB.JFIDAGABKID().BFHKBOPOFGB = false;
			}
			if (aeneoofmbke != null)
			{
				aeneoofmbke.HKHLLGJHDCF();
			}
			if (aeneoofmbke2 != null)
			{
				aeneoofmbke2.FDCGELJLOEI();
			}
			BOIKJDICEMF.IKGFHGKKCPG.AACBHMPHHFM();
		}
	}

	// Token: 0x0600520A RID: 21002 RVA: 0x002645A4 File Offset: 0x002627A4
	private void CKCBLMMGHNC(ONKDCGNBALK OJIMHKHFOJI)
	{
		JDCEFOFMGHB.MNJNNDHCDGG().BMOFIBGMIBK(this.HEGMKNAMIHB);
	}

	// Token: 0x0600520B RID: 21003 RVA: 0x002645B8 File Offset: 0x002627B8
	public void HOAKHLKOMBO(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		long odfekbjcfmn2 = OJIMHKHFOJI.ODFEKBJCFMN;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.PDEFLCIEMFF(this.BMCALEBOBGN);
			epmphjgalbe.ENDMKPCFKND((int)OJIMHKHFOJI.ODFEKBJCFMN);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-131, epmphjgalbe.PBOPEDMCKDD());
		}
		finally
		{
			epmphjgalbe.KNPHNLLMJKJ();
		}
		JDCEFOFMGHB.JFIDAGABKID().BMOFIBGMIBK(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x0600520D RID: 21005 RVA: 0x00264648 File Offset: 0x00262848
	public void KOMKFLJHCNK(HBPNMNGOFMA KADBECGIMPD)
	{
		Debug.Log("***My Lots event ");
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			MDEKJCCIDIA.KCFIPOJDHGB kcfipojdhgb = new MDEKJCCIDIA.KCFIPOJDHGB();
			kcfipojdhgb.JMMDIMGMPBL(KADBECGIMPD);
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = this.AGDMAFCKMJP.MJMOMMKECMF(-100L);
			if (fpaeeadmcie == null)
			{
				fpaeeadmcie = this.AGDMAFCKMJP.MJMOMMKECMF(0L);
			}
			fpaeeadmcie.LGMBHELCEEL(kcfipojdhgb, (long)kcfipojdhgb.BDHHPAEHFHG.LPFKFNLHGBI).AHFGACFMGEJ = new JNHLAGHJBAA.FPAEEADMCIE.COGMIMMKMME(this.IKABEPNBLOG);
			Debug.Log("***Lots " + kcfipojdhgb.BDHHPAEHFHG.LPFKFNLHGBI);
		}
		if (this.AGDMAFCKMJP != null)
		{
			this.AGDMAFCKMJP.BIPMLHDDOMF();
		}
	}

	// Token: 0x0600520E RID: 21006 RVA: 0x002646EC File Offset: 0x002628EC
	public void KLIDBFOPOMB(ONKDCGNBALK JMBKDINHDLO)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO(3f, 0, JNBICAJIJMM.LEBHCLDODNI("invn_rec3"), new ONKDCGNBALK.CMMHGMILOIM(this.MMKPMIFOJFL), true);
	}

	// Token: 0x0600520F RID: 21007 RVA: 0x00264718 File Offset: 0x00262918
	public void GFJEGOHIAHL(HBPNMNGOFMA KADBECGIMPD)
	{
		this.ANBIJAKLCPC = KADBECGIMPD.HDBGOLAFOBK();
		this.CAFFMFHCNAE = KADBECGIMPD.HDBGOLAFOBK();
		this.CLIHOFJKEAL = KADBECGIMPD.HDBGOLAFOBK();
		int ilfhhdnjhnm = KADBECGIMPD.HDBGOLAFOBK();
		int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.ANBIJAKLCPC, false, 0);
		int num2 = this.CLIHOFJKEAL;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KFODJJIHNHP < (long)(num2 * this.CAFFMFHCNAE))
		{
			num2 = (int)(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KFODJJIHNHP / (long)this.CAFFMFHCNAE);
		}
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.ANBIJAKLCPC);
		if (befchfngomi != null && num2 > befchfngomi.NPPJLOBFGBH * 3)
		{
			num2 = befchfngomi.NPPJLOBFGBH * 3;
		}
		foreach (JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie in this.AGDMAFCKMJP.JKOMGKLFPEE())
		{
			if (fpaeeadmcie.NLIKAGGPANH != null)
			{
				MDEKJCCIDIA.KCFIPOJDHGB kcfipojdhgb = (MDEKJCCIDIA.KCFIPOJDHGB)fpaeeadmcie.NLIKAGGPANH;
				if (kcfipojdhgb.BDHHPAEHFHG != null && kcfipojdhgb.BDHHPAEHFHG.LPFKFNLHGBI == this.ANBIJAKLCPC && kcfipojdhgb.BDJGKIEBGCA != MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot)
				{
					kcfipojdhgb.ILFHHDNJHNM = ilfhhdnjhnm;
				}
			}
		}
		this.ANNJBBJIJLC.FNMCIACNOMH = true;
		this.ANNJBBJIJLC.MPKCOJHJIIB();
		this.ANNJBBJIJLC.NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.IJHKJCKAIDB);
		string dpanhmgcbnl = string.Format(JNBICAJIJMM.LEBHCLDODNI("inv_aukcinf"), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)this.CAFFMFHCNAE, false), this.CLIHOFJKEAL, num);
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(this.ANNJBBJIJLC, this.ANNJBBJIJLC.OCHCODJIPHJ.x + 10f, this.ANNJBBJIJLC.OCHCODJIPHJ.y + 10f, this.ANNJBBJIJLC.OCHCODJIPHJ.width, this.ANNJBBJIJLC.OCHCODJIPHJ.height, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black);
		lcoljopgdll.LNDPBNODFPE = true;
		lcoljopgdll.DFIGKKMMIAF = 16;
		this.AIIHCNKNNID = new KJPFDOGHGOD(this.ANNJBBJIJLC, JNBICAJIJMM.LEBHCLDODNI("buykey"), this.ANNJBBJIJLC.OCHCODJIPHJ.x + 10f, this.ANNJBBJIJLC.OCHCODJIPHJ.y + 80f, this.ANNJBBJIJLC.OCHCODJIPHJ.width - 20f, 1f, (float)num2, 1f, true, 0);
		this.DMAAEAJMFOK = new LCOLJOPGDLL(this.ANNJBBJIJLC, this.ANNJBBJIJLC.OCHCODJIPHJ.x + 10f, this.AIIHCNKNNID.OCHCODJIPHJ.y + this.AIIHCNKNNID.OCHCODJIPHJ.height + 10f, JNBICAJIJMM.LEBHCLDODNI("inv_auksum") + " ", true)
		{
			LNDPBNODFPE = true,
			DFIGKKMMIAF = 16
		};
		new MEMEOHJKPNJ(this.ANNJBBJIJLC, this.ANNJBBJIJLC.OCBAOFLJBGP.OCHCODJIPHJ.width - 135f - 30f, this.ANNJBBJIJLC.OCBAOFLJBGP.OCHCODJIPHJ.height - 65f, 120f, 24f, JNBICAJIJMM.LEBHCLDODNI("cntx_close"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(this.DPGPPIDPCIO));
		new MEMEOHJKPNJ(this.ANNJBBJIJLC, this.ANNJBBJIJLC.OCBAOFLJBGP.OCHCODJIPHJ.width - 270f - 30f, this.ANNJBBJIJLC.OCBAOFLJBGP.OCHCODJIPHJ.height - 65f, 120f, 24f, JNBICAJIJMM.LEBHCLDODNI("qd_refresh"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.ENDJAAHPOAL));
		new MEMEOHJKPNJ(this.ANNJBBJIJLC, this.ANNJBBJIJLC.OCBAOFLJBGP.OCHCODJIPHJ.width - 405f - 30f, this.ANNJBBJIJLC.OCBAOFLJBGP.OCHCODJIPHJ.height - 65f, 120f, 24f, JNBICAJIJMM.LEBHCLDODNI("buykey"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(this.ENDJAAHPOAL));
	}

	// Token: 0x06005210 RID: 21008 RVA: 0x00264B44 File Offset: 0x00262D44
	public void NEPBGGBGCDD(ONKDCGNBALK PJNHODBDCEL)
	{
		int num = 1;
		int num2 = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.GMLFCKNNOPJ();
		Rect position = new Rect(PJNHODBDCEL.OCHCODJIPHJ.x - 97f, PJNHODBDCEL.OCHCODJIPHJ.y + 128f + (float)(num * 81), 688f, 94f);
		GUI.DrawTextureWithTexCoords(position, GameInterface.getI.RodOrderTexture, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL((num2 == -35) ? 0 : 1, 6, 1), false);
		if (GUI.Button(position, "OfficeSittingMouseMovement", GUIStyle.none))
		{
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("FireBreath", 1551f);
			DownPanelLogic.getI.OnRodChangeClck(-127);
		}
		num += 0;
		Rect position2 = new Rect(PJNHODBDCEL.OCHCODJIPHJ.x - 1392f, PJNHODBDCEL.OCHCODJIPHJ.y + 1034f + (float)(num * 104), 1392f, 17f);
		GUI.DrawTextureWithTexCoords(position2, GameInterface.getI.RodOrderTexture, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(1 + ((num2 == 97) ? 1 : 0), 7, 8), true);
		if (GUI.Button(position2, "", GUIStyle.none))
		{
			DownPanelLogic.getI.FGLJAIFHALA(-3);
			FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("_FgOverlap", 61f);
		}
		num++;
		Rect position3 = new Rect(PJNHODBDCEL.OCHCODJIPHJ.x - 1574f, PJNHODBDCEL.OCHCODJIPHJ.y + 685f + (float)(num * 26), 23f, 459f);
		GUI.DrawTextureWithTexCoords(position3, GameInterface.getI.RodOrderTexture, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(6 + ((num2 == 106) ? 0 : 1), 5, 7), false);
		if (GUI.Button(position3, "Data loaded done", GUIStyle.none))
		{
			DownPanelLogic.getI.GKBNAKPBOAG(67);
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("ArmFlex", 167f);
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FJGNFCPLNNF(num2);
		if (bgjkmcbhnak != null)
		{
			Rect position4 = new Rect(PJNHODBDCEL.OCHCODJIPHJ.x + PJNHODBDCEL.OCHCODJIPHJ.width - 285f, PJNHODBDCEL.OCHCODJIPHJ.y + 1718f, 1026f, 1064f);
			int clbpbjglhee = 0;
			if (bgjkmcbhnak.IKKPFPJLPOL)
			{
				clbpbjglhee = bgjkmcbhnak.NKNCNHGDMLF.BDHHPAEHFHG.GCLKLEIMABA;
			}
			GUI.DrawTextureWithTexCoords(position4, GameInterface.getI.RodStatusTexture, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(clbpbjglhee, 5, 8), false);
		}
	}

	// Token: 0x06005211 RID: 21009 RVA: 0x00264DA0 File Offset: 0x00262FA0
	public void DIGGACIAOHJ(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn == 1L)
		{
			int num = this.CMGJHIHGCNP.LPBLKNELCLO;
			if (num < 1)
			{
				num = 1;
			}
			if (num > this.COKDFMFFDAE.ILFHHDNJHNM - 1)
			{
				num = this.COKDFMFFDAE.ILFHHDNJHNM - 1;
			}
			this.COKDFMFFDAE.ILFHHDNJHNM = this.COKDFMFFDAE.ILFHHDNJHNM - num;
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OBCCLNMPGEJ(this.COKDFMFFDAE.LPFKFNLHGBI);
				epmphjgalbe.GOMLLPFFPNP(num);
				epmphjgalbe.GOMLLPFFPNP(this.IFHBHHBMNFK);
				epmphjgalbe.GOMLLPFFPNP(this.LMDDMCEJHOG);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(200, epmphjgalbe.JDPHBLHOLAD());
			}
			finally
			{
				epmphjgalbe.LMBPNFHKNGA();
			}
			this.COKDFMFFDAE.BFHKBOPOFGB = false;
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("repair.ogg", 0.9f);
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
			return;
		}
		if (odfekbjcfmn != 2L)
		{
			return;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_02.wav", 1f);
		this.COKDFMFFDAE.BFHKBOPOFGB = false;
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06005212 RID: 21010 RVA: 0x00264EDC File Offset: 0x002630DC
	private void ANAOANECGJG(ONKDCGNBALK ONPHLHKAGFP)
	{
		GUI.skin = GuiProcessor.IKGFHGKKCPG.alterSkin;
		this.JDFMHNPDDHJ = true;
		GUI.Window(ONPHLHKAGFP.LPFKFNLHGBI, new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x, ONPHLHKAGFP.OCHCODJIPHJ.y, 360f, this.GANOCEBJKJE), new GUI.WindowFunction(this.EAOLHBCPOJH), "");
	}

	// Token: 0x06005213 RID: 21011 RVA: 0x00264F44 File Offset: 0x00263144
	public void EFDMFBIBEPP(HBPNMNGOFMA KADBECGIMPD)
	{
		long phjohhdokhc = KADBECGIMPD.DMABDIGCLKA();
		KADBECGIMPD.HHLDBAEFNMJ();
		this.LKNFODKOPED = KADBECGIMPD.MOBPFEEAMKD();
		float num = KADBECGIMPD.BIMMPENHGMD();
		int num2 = KADBECGIMPD.KDNDJNEGBDI();
		int num3 = KADBECGIMPD.CLPEKGGAMAI();
		int num4 = KADBECGIMPD.KKOKFLMMAAK();
		int num5 = KADBECGIMPD.AGNKAFLKCAG();
		int num6 = Mathf.RoundToInt(91f - this.LKNFODKOPED);
		this.OGDKMNAONFF = num6 / 4;
		if (num6 % 0 > 0)
		{
			this.OGDKMNAONFF++;
		}
		this.KNHAGPNAKIL = KADBECGIMPD.KKOKFLMMAAK();
		this.MBJANEBEGDF = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BJDIEKNHGLJ(this.KNHAGPNAKIL, true, 0);
		this.POHLPMPEOKO = new IIBEEKCAAHK((double)this.KNHAGPNAKIL, 216.0, 1753.0);
		this.POHLPMPEOKO.CGLGAFHNJGK((double)this.MBJANEBEGDF);
		Debug.Log("1HandSmallWeaponCombo" + num4);
		Debug.Log("gi_um_8" + num2);
		Debug.Log("ProneIdle" + num);
		EKBAPCMPANI ekbapcmpani = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BGPCJLDDCDN(phjohhdokhc);
		if (ekbapcmpani == null)
		{
			return;
		}
		this.COKDFMFFDAE = ekbapcmpani;
		JDCEFOFMGHB.IKGFHGKKCPG.BMOFIBGMIBK(this.ONGEHMJIMLO);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(1795f, 805f, JNBICAJIJMM.PPNKMDJBMLP("2000"), true);
		this.ONGEHMJIMLO = onkdcgnbalk.LPFKFNLHGBI;
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, 969f, 243f, onkdcgnbalk.OCHCODJIPHJ.width - 315f, onkdcgnbalk.OCHCODJIPHJ.height - 38f, "cnt_dstall", 1, null);
		new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 1834f, egcaadaabpp.OCHCODJIPHJ.y + 1266f, egcaadaabpp.OCHCODJIPHJ.width - 574f, 1636f, IHFEDJEMJMB.OELKEADDKPE().DOHHCICALIL(ekbapcmpani.MBKMKGABBGE) + "206000" + ekbapcmpani.FDJPJJJHHEG, TextAnchor.UpperLeft, Color.black).DFIGKKMMIAF = 114;
		new KEPNAIFBDKF(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width / 1605f - 1686f, egcaadaabpp.OCHCODJIPHJ.y + 1672f, ekbapcmpani, 0);
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 1808f, egcaadaabpp.OCHCODJIPHJ.y + 806f, egcaadaabpp.OCHCODJIPHJ.width - 1151f, 844f, ekbapcmpani.MEKPGCCFEOO(true), TextAnchor.UpperLeft, Color.black);
		lcoljopgdll.DFIGKKMMIAF = 54;
		lcoljopgdll.LNDPBNODFPE = false;
		int num7 = -40;
		new EGCAADAABPP(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 223f, egcaadaabpp.OCHCODJIPHJ.y + (float)num7, egcaadaabpp.OCHCODJIPHJ.width - 1125f, 1084f, "VA", 1, null);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 1177f, egcaadaabpp.OCHCODJIPHJ.y + (float)num7 + 965f, egcaadaabpp.OCHCODJIPHJ.width - 937f, 375f, JNBICAJIJMM.OOOKJHOHPNN("knopje.wav"), TextAnchor.UpperLeft, Color.black);
		lcoljopgdll2.DFIGKKMMIAF = -103;
		lcoljopgdll2.LNDPBNODFPE = true;
		num7 += -29;
		GINEDLOJIIF ginedlojiif = new GINEDLOJIIF(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 1234f, egcaadaabpp.OCHCODJIPHJ.y + (float)num7, 893f, num4, num5, num3);
		ginedlojiif.MAKAFBBENPF = false;
		ginedlojiif.HMHBAMDBJLI = true;
		num7 += -15;
		EGCAADAABPP egcaadaabpp2 = new EGCAADAABPP(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 1613f, egcaadaabpp.OCHCODJIPHJ.y + (float)num7, egcaadaabpp.OCHCODJIPHJ.width - 323f, 147f, "ClimbLeft", 1, null);
		long num8 = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BIHLDHKHPKE("Jump");
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 1986f, egcaadaabpp2.OCHCODJIPHJ.y + 1999f, egcaadaabpp.OCHCODJIPHJ.width - 1290f, 940f, string.Format(JNBICAJIJMM.NGALDMFKMJH("Leg"), num8), TextAnchor.UpperCenter, Color.black);
		lcoljopgdll3.DFIGKKMMIAF = -14;
		lcoljopgdll3.LNDPBNODFPE = false;
		this.GJHKBPOOILO = new GMNEKCBLIAN(onkdcgnbalk, new Rect(egcaadaabpp.OCHCODJIPHJ.x + 376f, egcaadaabpp2.OCHCODJIPHJ.y + 1091f, egcaadaabpp.OCHCODJIPHJ.width - 708f, 182f), this.LKNFODKOPED + (float)this.POHLPMPEOKO.LKAGIEBPLAI * 1483f, 169f, 7, "_Parameter", false);
		new GMNEKCBLIAN(onkdcgnbalk, new Rect(egcaadaabpp.OCHCODJIPHJ.x + 1230f, egcaadaabpp2.OCHCODJIPHJ.y + 529f, egcaadaabpp.OCHCODJIPHJ.width - 677f, 399f), this.LKNFODKOPED, 1841f, 0, "ACTk offers own collection of the secure types to let you protect your variables from <b>ANY</b> memory hacking tools (Cheat Engine, ArtMoney, GameCIH, Game Guardian, etc.).", true);
		egcaadaabpp2.NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.MLMDAJKNDDK);
		num7 += -7;
		ONKDCGNBALK onkdcgnbalk2 = new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 867f - 536f, onkdcgnbalk.OCHCODJIPHJ.height - 391f, 480f, 75f, JNBICAJIJMM.DCEBAJIILPC("Bilateral Blur"), 8, null, new ONKDCGNBALK.CMMHGMILOIM(this.ADAJGDDDCPK));
		bool fnmciacnomh = true;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KFODJJIHNHP < (long)num3)
		{
			fnmciacnomh = true;
		}
		if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BJDIEKNHGLJ(num4, true, 1) < num5)
		{
			fnmciacnomh = true;
		}
		if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BJDIEKNHGLJ(this.KNHAGPNAKIL, false, 1) < this.POHLPMPEOKO.KIDKOFKNPEP())
		{
			fnmciacnomh = false;
		}
		if (ekbapcmpani.LNKLEIEFGCP >= -108)
		{
			fnmciacnomh = true;
		}
		onkdcgnbalk2.FNMCIACNOMH = fnmciacnomh;
	}

	// Token: 0x06005214 RID: 21012 RVA: 0x00265581 File Offset: 0x00263781
	private void BKGBBNEFAHA(ONKDCGNBALK ONPHLHKAGFP)
	{
		JDCEFOFMGHB.HMJJPNDEKPP().BMOFIBGMIBK(this.ONGEHMJIMLO);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-163, this.COKDFMFFDAE.LPFKFNLHGBI);
	}

	// Token: 0x06005215 RID: 21013 RVA: 0x002655B0 File Offset: 0x002637B0
	public void KHLNFNEKCFC(ONKDCGNBALK PHEMLBHMNCM)
	{
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		float num = PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.x;
		float num2 = PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.y;
		bool flag = new Rect(num, num2, PHEMLBHMNCM.OCHCODJIPHJ.width, PHEMLBHMNCM.OCHCODJIPHJ.height).Contains(vector);
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		int num3 = kfhelhglnmh.LKNJCMFCLDK[this.DJEOAABGBHH];
		float x = PHEMLBHMNCM.OCHCODJIPHJ.x;
		float y = PHEMLBHMNCM.OCHCODJIPHJ.y;
		int num4 = num3 / 5;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		float num8 = (float)(58 * num4);
		if (num8 < 464f)
		{
			num8 = 464f;
		}
		bool flag2 = false;
		this.AICBIFFGBOH = GUI.BeginScrollView(new Rect(x, y, 308f, 464f), this.AICBIFFGBOH, new Rect(x, y, 290f, num8), false, false);
		for (int i = 0; i <= num4; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				if (num5 < num3)
				{
					bool flag3 = true;
					if (flag)
					{
						Rect rect = new Rect(num + (float)num6, num2 + (float)num7 - this.AICBIFFGBOH.y, 58f, 58f);
						if (rect.Contains(vector))
						{
							this.DKFICLCPICL.x = vector.x - rect.x;
							this.DKFICLCPICL.y = vector.y - rect.y;
							this.OJKBEDCFFND = i * 5 + j;
							this.AMBNJGDIDED = this.DJEOAABGBHH;
							this.ABLFGLMKPNO = true;
							if (this.KKLEEIBNIBC != null)
							{
								GUI.DrawTexture(new Rect(x + (float)num6, y + (float)num7, 56f, 56f), GameInterface.getI.invEmptyCellSelect);
								flag3 = false;
							}
						}
					}
					if (flag3)
					{
						GUI.DrawTexture(new Rect(x + (float)num6, y + (float)num7, 56f, 56f), GameInterface.getI.invEmptyCell);
					}
					num5++;
				}
				else
				{
					if (!flag2)
					{
						Rect position = new Rect(x + (float)num6, y + (float)num7, 56f, 56f);
						Texture image = GameInterface.getI.invCellPlus;
						Rect rect2 = new Rect(num + (float)num6, num2 + (float)num7 - this.AICBIFFGBOH.y, 58f, 58f);
						if (rect2.Contains(vector))
						{
							image = GameInterface.getI.invCellPlusSelect;
						}
						GUI.DrawTexture(position, image);
						if (GUI.Button(position, "", GUIStyle.none))
						{
							Debug.Log("Add inventory Click!");
							NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(210, this.DJEOAABGBHH);
						}
						num5++;
					}
					flag2 = true;
				}
				num6 += 58;
			}
			num6 = 0;
			num7 += 58;
		}
		foreach (EKBAPCMPANI ekbapcmpani in kfhelhglnmh.PLLHGAFIAFD.Values)
		{
			if (ekbapcmpani.JGNIDDBNGGP == this.DJEOAABGBHH)
			{
				Vector2 vector2 = this.LEGNKCIHLNP(ekbapcmpani.DMAMOPGJOCK);
				ekbapcmpani.JCIIPCEDICP(new Vector2(x + vector2.x, y + vector2.y), 56f);
			}
		}
		GUI.EndScrollView();
		if (this.KKLEEIBNIBC != null)
		{
			this.KKLEEIBNIBC.OHDHFJFKLAJ(this.GKKGCDPIPPL);
		}
	}

	// Token: 0x06005216 RID: 21014 RVA: 0x00265970 File Offset: 0x00263B70
	public void LDODFCNLANK(MMKFAENBHKD ONPHLHKAGFP, ItemBase HEABEPINGED)
	{
		if (HEABEPINGED != null)
		{
			EKBAPCMPANI ekbapcmpani = HEABEPINGED as EKBAPCMPANI;
			this.EMNCOCGHKKN.KIEJALOBCBB(string.Format(JNBICAJIJMM.DCEBAJIILPC("file://"), ekbapcmpani.LODGJCMEGAI.KEHIFGILLJA(), ekbapcmpani.LODGJCMEGAI.ICJDPPOJINN));
			this.NEBLGPAOGGH.EBLHAJDINBH = this.COKDFMFFDAE.DLHPFGHOINI + (float)ekbapcmpani.LODGJCMEGAI.KEHIFGILLJA();
		}
	}

	// Token: 0x06005217 RID: 21015 RVA: 0x002659E4 File Offset: 0x00263BE4
	public void MPICBGMIFGO(ONKDCGNBALK OJIMHKHFOJI)
	{
		if (this.EFIBDEMHFDD.IHEILFHMLAG < 0)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.OBCCLNMPGEJ(this.LBEHNCAGGAH);
			NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg = (NLNNIDBPKAO.JENMPDPJKBG)this.EFIBDEMHFDD.LACAJHOHACK[this.EFIBDEMHFDD.IHEILFHMLAG];
			epmphjgalbe.GOMLLPFFPNP(jenmpdpjkbg.LPFKFNLHGBI);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1430, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06005218 RID: 21016 RVA: 0x00265A98 File Offset: 0x00263C98
	public void JFPNGCBIDNF(ONKDCGNBALK JMBKDINHDLO)
	{
		this.BBOKGAOOIMG = JMBKDINHDLO.ODFEKBJCFMN;
		Debug.Log("OK aukKeyMEditOk");
		if (this.BBOKGAOOIMG > this.DCFMECEHGEM)
		{
			this.DCFMECEHGEM = this.BBOKGAOOIMG;
		}
		this.CMHGFDDMCAK();
	}

	// Token: 0x06005219 RID: 21017 RVA: 0x00265AD0 File Offset: 0x00263CD0
	public Vector2 GIAPKFKGHGB(int CLBPBJGLHEE)
	{
		float num = (float)(CLBPBJGLHEE % 5 * 77);
		int num2 = CLBPBJGLHEE / 8 * -123;
		return new Vector2(num, (float)num2);
	}

	// Token: 0x0600521A RID: 21018 RVA: 0x00265AF4 File Offset: 0x00263CF4
	public void LGFHOOHEBJG(ONKDCGNBALK JMAKEAHMLMI)
	{
		if (this.AMBNJGDIDED == 51)
		{
			return;
		}
		if (this.OJKBEDCFFND >= 0)
		{
			EKBAPCMPANI ekbapcmpani = this.EHHKCFOAKAI(this.AMBNJGDIDED, this.OJKBEDCFFND);
			if (ekbapcmpani != null)
			{
				this.GKKGCDPIPPL = this.DKFICLCPICL;
				ekbapcmpani.BFHKBOPOFGB = true;
				this.KKLEEIBNIBC = ekbapcmpani;
				JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = true;
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_08.wav", 1f);
			}
		}
	}

	// Token: 0x0600521B RID: 21019 RVA: 0x00265B64 File Offset: 0x00263D64
	public void LKEOMIACNIJ(ONKDCGNBALK JMAKEAHMLMI)
	{
		if (this.AMBNJGDIDED == 75)
		{
			return;
		}
		if (this.OJKBEDCFFND >= 1)
		{
			EKBAPCMPANI ekbapcmpani = this.KIFEKEONBOL(this.AMBNJGDIDED, this.OJKBEDCFFND);
			if (ekbapcmpani != null)
			{
				this.GKKGCDPIPPL = this.DKFICLCPICL;
				ekbapcmpani.BFHKBOPOFGB = false;
				this.KKLEEIBNIBC = ekbapcmpani;
				JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
				FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("qd_week", 1370f);
			}
		}
	}

	// Token: 0x0600521D RID: 21021 RVA: 0x00265C80 File Offset: 0x00263E80
	private void ENDJAAHPOAL(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		long num = odfekbjcfmn - 1L;
		if (num > 4L)
		{
			return;
		}
		switch ((uint)num)
		{
		case 0U:
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(340, this.KBKJNEFDCFO.BDHHPAEHFHG.LPFKFNLHGBI);
			return;
		case 1U:
		{
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.GOMLLPFFPNP(this.KBKJNEFDCFO.BDHHPAEHFHG.LPFKFNLHGBI);
				epmphjgalbe.GOMLLPFFPNP(this.CAFFMFHCNAE);
				epmphjgalbe.GOMLLPFFPNP(this.AIIHCNKNNID.LPBLKNELCLO);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(350, epmphjgalbe.JDPHBLHOLAD());
			}
			finally
			{
				epmphjgalbe.LMBPNFHKNGA();
			}
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
			return;
		}
		case 2U:
		case 3U:
			break;
		case 4U:
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(355, this.KBKJNEFDCFO.EENFJPJEDFM);
			break;
		default:
			return;
		}
	}

	// Token: 0x0600521E RID: 21022 RVA: 0x00265D98 File Offset: 0x00263F98
	public void HLKCELEKEKN(ONKDCGNBALK JMBKDINHDLO)
	{
		this.BBOKGAOOIMG = JMBKDINHDLO.ODFEKBJCFMN;
		Debug.Log("ScubaOK");
		if (this.BBOKGAOOIMG > this.DCFMECEHGEM)
		{
			this.DCFMECEHGEM = this.BBOKGAOOIMG;
		}
		this.LCLCFPKANAH();
	}

	// Token: 0x0600521F RID: 21023 RVA: 0x00265DD0 File Offset: 0x00263FD0
	public void MPHGGAKBHDE(ONKDCGNBALK JMBKDINHDLO)
	{
		long odfekbjcfmn = JMBKDINHDLO.ODFEKBJCFMN;
		if (odfekbjcfmn <= 2L)
		{
			if (odfekbjcfmn == 1L)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.NNMBEJIPPNF(JNBICAJIJMM.LEBHCLDODNI("auk_swtcost"), " ", this.BBOKGAOOIMG, new ONKDCGNBALK.CMMHGMILOIM(this.JFPNGCBIDNF), null);
				return;
			}
			if (odfekbjcfmn != 2L)
			{
				return;
			}
			JDCEFOFMGHB.IKGFHGKKCPG.NNMBEJIPPNF(JNBICAJIJMM.LEBHCLDODNI("auc_wcswcp"), " ", this.DCFMECEHGEM, new ONKDCGNBALK.CMMHGMILOIM(this.AHJJJBAMEHE), null);
			return;
		}
		else
		{
			if (odfekbjcfmn == 90L)
			{
				EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
				try
				{
					epmphjgalbe.OBCCLNMPGEJ(this.MEOJOEJBNDI.LPFKFNLHGBI);
					epmphjgalbe.OBCCLNMPGEJ(this.BBOKGAOOIMG);
					epmphjgalbe.OBCCLNMPGEJ(this.DCFMECEHGEM);
					epmphjgalbe.GOMLLPFFPNP(24);
					NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(316, epmphjgalbe.JDPHBLHOLAD());
				}
				finally
				{
					epmphjgalbe.LMBPNFHKNGA();
				}
				JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MGKFACGMAOD(this.MEOJOEJBNDI.LPFKFNLHGBI);
				this.MEOJOEJBNDI = null;
				JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(JMBKDINHDLO.OCBAOFLJBGP.LPFKFNLHGBI);
				return;
			}
			if (odfekbjcfmn != 100L)
			{
				return;
			}
			EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
			try
			{
				epmphjgalbe2.OBCCLNMPGEJ(this.MEOJOEJBNDI.LPFKFNLHGBI);
				epmphjgalbe2.OBCCLNMPGEJ(this.BBOKGAOOIMG);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(320, epmphjgalbe2.JDPHBLHOLAD());
			}
			finally
			{
				epmphjgalbe2.LMBPNFHKNGA();
			}
			JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MGKFACGMAOD(this.MEOJOEJBNDI.LPFKFNLHGBI);
			this.MEOJOEJBNDI = null;
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(JMBKDINHDLO.OCBAOFLJBGP.LPFKFNLHGBI);
			return;
		}
	}

	// Token: 0x06005220 RID: 21024 RVA: 0x00265F80 File Offset: 0x00264180
	public void BGBNNPNHCEF(ONKDCGNBALK ONPHLHKAGFP)
	{
		EKBAPCMPANI useWeapon = GameInterface.getI.useWeapon;
		int jgniddbnggp = useWeapon.JGNIDDBNGGP;
		int dmamopgjock = useWeapon.DMAMOPGJOCK;
		string palfnhclkaj = "aptek.ogg";
		switch (useWeapon.MBKMKGABBGE)
		{
		case 21:
			palfnhclkaj = "eat2.ogg";
			break;
		case 22:
			palfnhclkaj = "drink.wav";
			break;
		case 23:
			palfnhclkaj = "aptek.ogg";
			break;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE(palfnhclkaj, 1f);
		if (!useWeapon.BDHHPAEHFHG.FOAPCABBLBG)
		{
			useWeapon.ILFHHDNJHNM--;
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(JNBICAJIJMM.LEBHCLDODNI("gi_usei") + " " + useWeapon.JPBOPFNPNHC(true));
			if (useWeapon.ILFHHDNJHNM <= 0)
			{
				JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MGKFACGMAOD(useWeapon.LPFKFNLHGBI);
			}
		}
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1320, useWeapon.LPFKFNLHGBI);
		AENEOOFMBKE aeneoofmbke = JDCEFOFMGHB.IKGFHGKKCPG.AEGEHJLBECE(jgniddbnggp, dmamopgjock);
		if (aeneoofmbke != null)
		{
			aeneoofmbke.AFOLABIACNF();
		}
	}

	// Token: 0x06005221 RID: 21025 RVA: 0x00266080 File Offset: 0x00264280
	public void HOPJBHHKFKI(HBPNMNGOFMA KADBECGIMPD)
	{
		long phjohhdokhc = KADBECGIMPD.IJDIMHAEAIE();
		this.MEOJOEJBNDI = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.FCHLEBEMIBK(phjohhdokhc);
		if (this.MEOJOEJBNDI == null)
		{
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().NCIDDNIKACI(1781f, 1972f, JNBICAJIJMM.DCEBAJIILPC("IdleStrafeLeft"), true);
		KEPNAIFBDKF kepnaifbdkf = new KEPNAIFBDKF(onkdcgnbalk, 187f, 112f, this.MEOJOEJBNDI, 0);
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, kepnaifbdkf.OCHCODJIPHJ.x + kepnaifbdkf.OCHCODJIPHJ.width + 1656f, kepnaifbdkf.OCHCODJIPHJ.y, this.MEOJOEJBNDI.MBBMKNBDPDA(false), false);
		lcoljopgdll.DFIGKKMMIAF = 54;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont3;
		new LCOLJOPGDLL(onkdcgnbalk, kepnaifbdkf.OCHCODJIPHJ.x + kepnaifbdkf.OCHCODJIPHJ.width + 1531f, kepnaifbdkf.OCHCODJIPHJ.y + 922f, string.Format(JNBICAJIJMM.DCEBAJIILPC("\\"), this.MEOJOEJBNDI.ILFHHDNJHNM), true).DFIGKKMMIAF = 47;
		float num = KADBECGIMPD.BIMMPENHGMD();
		float num2 = KADBECGIMPD.MOBPFEEAMKD();
		float num3 = KADBECGIMPD.CGJIINADKNH();
		int num4 = KADBECGIMPD.KDNDJNEGBDI();
		float num5 = kepnaifbdkf.OCHCODJIPHJ.y + kepnaifbdkf.OCHCODJIPHJ.height + 815f;
		new LCOLJOPGDLL(onkdcgnbalk, 1684f, num5, string.Format(JNBICAJIJMM.LEBHCLDODNI("cash.ogg"), num4), true).DFIGKKMMIAF = 114;
		num5 += 760f;
		new LCOLJOPGDLL(onkdcgnbalk, 213f, num5, string.Format(JNBICAJIJMM.PPNKMDJBMLP("Vertical"), JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(0L, (long)Mathf.RoundToInt(num), true)), false).DFIGKKMMIAF = 82;
		num5 += 625f;
		new LCOLJOPGDLL(onkdcgnbalk, 495f, num5, string.Format(JNBICAJIJMM.DCEBAJIILPC("Anti-Cheat Toolkit Detectors"), JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(0L, (long)Mathf.RoundToInt(num2), false)), false).DFIGKKMMIAF = -43;
		num5 += 710f;
		new LCOLJOPGDLL(onkdcgnbalk, 375f, num5, string.Format(JNBICAJIJMM.DIOJFJMOPJO("FOVKick camera is null, please supply the camera to the constructor"), JLFJEGIPIMM.MHFDIJGJGBJ().MNMIJFNPIPI(0L, (long)Mathf.RoundToInt(num3), true)), true).DFIGKKMMIAF = -93;
		num5 += 757f;
		num5 += 328f;
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 1297f, num5, JNBICAJIJMM.CELEPPAEKAB("Flap_04.wav"), true);
		lcoljopgdll2.DFIGKKMMIAF = 81;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont3;
		num5 += 984f;
		this.BBOKGAOOIMG = (long)Mathf.RoundToInt(num3 * (float)this.MEOJOEJBNDI.ILFHHDNJHNM);
		if (this.BBOKGAOOIMG == 0L)
		{
			this.BBOKGAOOIMG = (long)Mathf.RoundToInt(num * (float)this.MEOJOEJBNDI.ILFHHDNJHNM);
		}
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, 1711f, num5, onkdcgnbalk.OCHCODJIPHJ.width - 1926f, 1654f, "demoLong", 1, null);
		num5 += 870f;
		this.MPBHBNBJBLA = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 1021f, num5, JLFJEGIPIMM.MHFDIJGJGBJ().OHNLAOJGCGC(1L, this.BBOKGAOOIMG, false), false)
		{
			DFIGKKMMIAF = -92,
			HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont
		};
		num5 += 1916f;
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 1010f, egcaadaabpp.OCHCODJIPHJ.y + 1031f, 290f, 809f, JNBICAJIJMM.OOOKJHOHPNN("_camRotate"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.MPHGGAKBHDE));
		num5 += 255f;
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(onkdcgnbalk, 814f, num5, JNBICAJIJMM.PGJCPFNJNPM("DENSITY"), false);
		lcoljopgdll3.DFIGKKMMIAF = 35;
		lcoljopgdll3.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont3;
		num5 += 833f;
		this.DCFMECEHGEM = (long)Mathf.RoundToInt(num2 * (float)this.MEOJOEJBNDI.ILFHHDNJHNM);
		if (this.BBOKGAOOIMG > this.DCFMECEHGEM)
		{
			this.DCFMECEHGEM = this.BBOKGAOOIMG;
		}
		EGCAADAABPP egcaadaabpp2 = new EGCAADAABPP(onkdcgnbalk, 1298f, num5, onkdcgnbalk.OCHCODJIPHJ.width - 36f, 1615f, "_Intensity", 1, null);
		num5 += 370f;
		this.JJNNIDBAEKL = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp2.OCHCODJIPHJ.x + 1564f, num5, JLFJEGIPIMM.PKGMBFEMKGP().MNMIJFNPIPI(0L, this.DCFMECEHGEM, false), false)
		{
			DFIGKKMMIAF = -12,
			HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont
		};
		num5 += 568f;
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp2.OCHCODJIPHJ.x + egcaadaabpp2.OCHCODJIPHJ.width - 243f, egcaadaabpp2.OCHCODJIPHJ.y + 596f, 715f, 1796f, JNBICAJIJMM.CELEPPAEKAB("_CameraToWorldMatrix"), 4, null, new ONKDCGNBALK.CMMHGMILOIM(this.MPHGGAKBHDE));
		long kfodjjihnhp = (long)(1 + Mathf.RoundToInt((float)(this.DCFMECEHGEM * (long)this.MEOJOEJBNDI.ILFHHDNJHNM) * 1047f));
		num5 = egcaadaabpp2.OCHCODJIPHJ.y + egcaadaabpp2.OCHCODJIPHJ.height + 566f;
		LCOLJOPGDLL lcoljopgdll4 = new LCOLJOPGDLL(onkdcgnbalk, 1797f, num5, JNBICAJIJMM.OOOKJHOHPNN("WoodCut"), true);
		lcoljopgdll4.DFIGKKMMIAF = -69;
		lcoljopgdll4.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont3;
		num5 += 1518f;
		EGCAADAABPP egcaadaabpp3 = new EGCAADAABPP(onkdcgnbalk, 427f, num5, onkdcgnbalk.OCHCODJIPHJ.width - 49f, 922f, "wpn_wgt", 0, null);
		num5 += 713f;
		this.HMJIHCHAEFN = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp3.OCHCODJIPHJ.x + 648f, num5, JLFJEGIPIMM.PKGMBFEMKGP().MNMIJFNPIPI(0L, kfodjjihnhp, false), true)
		{
			DFIGKKMMIAF = 32,
			HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont
		};
		num5 += 1017f;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1873f - 462f, onkdcgnbalk.OCHCODJIPHJ.height - 924f, 1561f, 1354f, JNBICAJIJMM.NGALDMFKMJH("MotorbikeHandstand"), -113, null, new ONKDCGNBALK.CMMHGMILOIM(this.MPHGGAKBHDE));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1722f - 566f, onkdcgnbalk.OCHCODJIPHJ.height - 273f, 520f, 459f, JNBICAJIJMM.LEBHCLDODNI("CHAT Empty"), 7, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.JFIDAGABKID().IBCKNOEANLN));
		JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(true);
	}

	// Token: 0x06005222 RID: 21026 RVA: 0x00266750 File Offset: 0x00264950
	public void FOONOMCNJPF(ONKDCGNBALK ONPHLHKAGFP)
	{
		EKBAPCMPANI useWeapon = GameInterface.getI.useWeapon;
		int jgniddbnggp = useWeapon.JGNIDDBNGGP;
		int dmamopgjock = useWeapon.DMAMOPGJOCK;
		string palfnhclkaj = "ALP=";
		switch (useWeapon.MBKMKGABBGE)
		{
		case 40:
			palfnhclkaj = "{0}.{1}.{2}";
			break;
		case 41:
			palfnhclkaj = "{0} {1}\n{2}";
			break;
		case 42:
			palfnhclkaj = "wpn_bait_sz";
			break;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO(palfnhclkaj, 1934f);
		if (!useWeapon.BDHHPAEHFHG.FOAPCABBLBG)
		{
			useWeapon.ILFHHDNJHNM -= 0;
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(JNBICAJIJMM.PPNKMDJBMLP("[F_EXP]") + "Label" + useWeapon.NBKLEELCDBJ(false));
			if (useWeapon.ILFHHDNJHNM <= 0)
			{
				JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.FFFJIAMAGBC(useWeapon.LPFKFNLHGBI);
			}
		}
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-9, useWeapon.LPFKFNLHGBI);
		AENEOOFMBKE aeneoofmbke = JDCEFOFMGHB.HMJJPNDEKPP().IGFAIGNHBEK(jgniddbnggp, dmamopgjock);
		if (aeneoofmbke != null)
		{
			aeneoofmbke.FDCGELJLOEI();
		}
	}

	// Token: 0x06005223 RID: 21027 RVA: 0x00266850 File Offset: 0x00264A50
	public void EAOLHBCPOJH(int PHJOHHDOKHC)
	{
		this.IHNJOHJCBMK = true;
		if (this.EBKMEHACMJE == null)
		{
			return;
		}
		GUI.BringWindowToFront(PHJOHHDOKHC);
		GUI.FocusWindow(PHJOHHDOKHC);
		GUI.skin = GuiProcessor.IKGFHGKKCPG.alterSkin;
		GUI.DrawTexture(new Rect(10f, 20f, 56f, 56f), GameInterface.getI.invEmptyCell);
		this.EBKMEHACMJE.JCIIPCEDICP(new Vector2(10f, 20f), 56f);
		if (this.JDFMHNPDDHJ && GUI.Button(new Rect(265f, this.GANOCEBJKJE - 35f, 80f, 20f), "OK"))
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(PHJOHHDOKHC);
		}
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperLeft,
			wordWrap = true,
			richText = true,
			font = GuiProcessor.IKGFHGKKCPG.rusfont3,
			fontSize = 11
		};
		guistyle.fontSize = 14;
		guistyle.alignment = TextAnchor.UpperLeft;
		string str = "";
		if (this.EBKMEHACMJE.ILFHHDNJHNM > 1)
		{
			str = string.Format(" " + JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("inv_pcs1"), this.EBKMEHACMJE.ILFHHDNJHNM);
		}
		if (this.EBKMEHACMJE.BDHHPAEHFHG.NPPJLOBFGBH > 1)
		{
			str = string.Format(" " + JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("inv_pcs2"), this.EBKMEHACMJE.ILFHHDNJHNM, this.EBKMEHACMJE.BDHHPAEHFHG.NPPJLOBFGBH);
		}
		GUI.Label(new Rect(75f, 20f, 250f, 20f), (this.EBKMEHACMJE.FDJPJJJHHEG + str) ?? "", guistyle);
		string arg = "";
		if (this.EBKMEHACMJE.MBKMKGABBGE == 12)
		{
			int ilockjiapfc = this.EBKMEHACMJE.BDHHPAEHFHG.ILOCKJIAPFC;
			if (ilockjiapfc > 0)
			{
				arg = JNBICAJIJMM.LEBHCLDODNI(string.Format("wpn_bait_typ_{0}", ilockjiapfc));
			}
		}
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.fontSize = 11;
		GUI.Label(new Rect(75f, 36f, 200f, 20f), string.Format("{0} {1}", IHFEDJEMJMB.IKGFHGKKCPG.JGLANEDNNAB(this.EBKMEHACMJE.MBKMKGABBGE), arg), guistyle);
		guistyle.fontSize = 12;
		guistyle.normal.textColor = new Color(0.1f, 0.1f, 0.1f, 1f);
		string text = "";
		string text2 = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("inv_nodur");
		if (this.EBKMEHACMJE.BDHHPAEHFHG.FOAPCABBLBG)
		{
			if (this.EBKMEHACMJE.BGGJKOMAKEE > 0)
			{
				text2 = string.Format("{0}/{1}", JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)this.EBKMEHACMJE.DLHPFGHOINI), this.EBKMEHACMJE.BGGJKOMAKEE);
				if (this.EBKMEHACMJE.DLHPFGHOINI < 30f)
				{
					text2 = "<color='#400000'>" + text2 + "</color>";
				}
				if (this.EBKMEHACMJE.DLHPFGHOINI >= 50f)
				{
					text2 = "<color='#004000'>" + text2 + "</color>";
				}
			}
			text2 = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("inv_dur") + " " + text2;
		}
		else
		{
			text2 = "";
		}
		GUI.Label(new Rect(75f, 60f, 400f, 20f), text + text2, guistyle);
		text = "";
		if (this.EBKMEHACMJE.ICOFLHIIBCP)
		{
			text = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("inv_pers") + "\n";
		}
		else if (this.EBKMEHACMJE.MAIGLJPCKKL)
		{
			text = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("inv_wpers") + "\n";
		}
		if (this.EBKMEHACMJE.DNOLHLJODNK)
		{
			text = text + JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("inv_impr") + "\n";
			GUI.DrawTextureWithTexCoords(new Rect(320f, 5f, 32f, 32f), GameInterface.getI.wpnImproveIcons, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(this.EBKMEHACMJE.LNKLEIEFGCP, 8, 4));
		}
		if (this.EBKMEHACMJE.BDHHPAEHFHG.GCLKLEIMABA > 0)
		{
			text = text + "<color='#001040'>" + JLFJEGIPIMM.IKGFHGKKCPG.HFNCFFLHBOP(this.EBKMEHACMJE.BDHHPAEHFHG.GCLKLEIMABA) + "</color>\n";
		}
		string text3 = this.EBKMEHACMJE.GDJBADNJNIO(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH);
		if (text3.Trim() != "")
		{
			text3 = "\n" + JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("inv_minreq") + "\n" + text3;
		}
		guistyle.normal.textColor = Color.black;
		guistyle.alignment = TextAnchor.UpperLeft;
		text = string.Concat(new string[]
		{
			text,
			this.EBKMEHACMJE.MEKPGCCFEOO(true),
			"\n",
			text3,
			"\n<color='#303030'><i>",
			this.EBKMEHACMJE.BDHHPAEHFHG.JCKHDHGIEEB,
			"</i></color>"
		});
		GUIContent content = new GUIContent(text);
		GUI.Label(new Rect(10f, 80f, 340f, 200f), content, guistyle);
		int num = (int)guistyle.CalcHeight(content, 340f);
		float num2 = (float)(90 + num);
		XmlNode gmncildpikp = this.EBKMEHACMJE.GMNCILDPIKP;
		if (gmncildpikp != null)
		{
			GUI.Label(new Rect(10f, num2, 340f, 200f), JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("inv_useeff"), guistyle);
			num2 += 20f;
			guistyle.fontSize = 11;
			foreach (object obj in gmncildpikp.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				if (xmlNode.Name == "effect" && xmlNode.Attributes != null)
				{
					int lpfkfnlhgbi = int.Parse(xmlNode.Attributes["id"].Value);
					IIBEEKCAAHK pgedldmlbbe = new IIBEEKCAAHK(xmlNode.Attributes["value"].Value);
					int cgnljcomfac = int.Parse(xmlNode.Attributes["time"].Value);
					FlyMessageManager.NGIAAOHFNPO flyIconTemplate = FlyMessageManager.getI.getFlyIconTemplate(lpfkfnlhgbi);
					if (flyIconTemplate != null)
					{
						GUI.DrawTexture(new Rect(10f, num2, 28f, 28f), flyIconTemplate.CFFHIODOGCH.KEDGAOBCNJG, ScaleMode.ScaleToFit);
						string text4 = string.Format(JNBICAJIJMM.LEBHCLDODNI("inv_effectinf"), flyIconTemplate.BEFIAPHPIBJ(pgedldmlbbe), JLFJEGIPIMM.IKGFHGKKCPG.CBBDFCOMGLP(cgnljcomfac));
						guistyle.fontSize = 12;
						GUI.Label(new Rect(45f, num2, 300f, 200f), text4, guistyle);
						num2 += 12f;
						guistyle.fontSize = 10;
						GUI.Label(new Rect(45f, num2, 300f, 200f), string.Format("<color='#000000'>{0}</color>", flyIconTemplate.FPEBEBGMGGH(pgedldmlbbe)), guistyle);
					}
					num2 += 32f;
				}
			}
		}
		this.GANOCEBJKJE = num2 + 30f;
		if (this.EBKMEHACMJE.BDHHPAEHFHG.AOBLCKFEKJE != null)
		{
			float num3 = (float)this.EBKMEHACMJE.BDHHPAEHFHG.AOBLCKFEKJE.width;
			float num4 = (float)this.EBKMEHACMJE.BDHHPAEHFHG.AOBLCKFEKJE.height;
			if (num3 > 0f)
			{
				float num5 = 1f;
				if (num3 > 200f)
				{
					num5 = 200f / num3;
				}
				num3 *= num5;
				num4 *= num5;
				GUI.DrawTexture(new Rect(180f - num3 / 2f, this.GANOCEBJKJE - 15f, num3, num4), this.EBKMEHACMJE.BDHHPAEHFHG.AOBLCKFEKJE);
				this.GANOCEBJKJE += num4 + 5f;
			}
		}
		if (this.EBKMEHACMJE.LABFBKENHAA > 0)
		{
			this.GANOCEBJKJE += 30f;
			int num6 = 0;
			for (int i = 0; i < this.EBKMEHACMJE.LABFBKENHAA; i++)
			{
				GUI.DrawTexture(new Rect((float)(10 + num6 * 30), this.GANOCEBJKJE - 55f, 28f, 29f), GameInterface.getI.invEmptyCell, ScaleMode.ScaleToFit);
				num6++;
			}
			num6 = 0;
			XmlNode nhfheigickp = this.EBKMEHACMJE.NHFHEIGICKP;
			if (nhfheigickp != null)
			{
				foreach (object obj2 in nhfheigickp.ChildNodes)
				{
					XmlNode xmlNode2 = (XmlNode)obj2;
					BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(xmlNode2.Name + "=" + xmlNode2.InnerText);
					if (diggohpgcnn.OKEBIHBDEOO("innerPerk"))
					{
						NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(diggohpgcnn.DIKKDGKIPEA);
					}
					num6++;
				}
			}
		}
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		string text5 = "";
		if (!this.EBKMEHACMJE.ICOFLHIIBCP)
		{
			if (this.EBKMEHACMJE.BDHHPAEHFHG.DAGKAGJCNAH)
			{
				text5 = text5 + JNBICAJIJMM.LEBHCLDODNI("inv_post") + " , ";
			}
			if (this.EBKMEHACMJE.BDHHPAEHFHG.DKFCKFJBNIM)
			{
				text5 = text5 + JNBICAJIJMM.LEBHCLDODNI("inv_auk") + " ";
			}
		}
		GUI.Label(new Rect(10f, this.GANOCEBJKJE - 20f, 340f, 20f), text5, guistyle);
	}

	// Token: 0x06005224 RID: 21028 RVA: 0x00267294 File Offset: 0x00265494
	private void MLMDAJKNDDK(ONKDCGNBALK ONPHLHKAGFP)
	{
		CLFFOBKFKDN.IKGFHGKKCPG.KKEPJMGFCMM(ONPHLHKAGFP, this.POHLPMPEOKO, (int)ONPHLHKAGFP.OCHCODJIPHJ.x, 400, ONPHLHKAGFP.OCHCODJIPHJ, this.OGDKMNAONFF, false, true);
		this.GJHKBPOOILO.EBLHAJDINBH = this.LKNFODKOPED + (float)(this.POHLPMPEOKO.LKAGIEBPLAI * 5);
	}

	// Token: 0x06005225 RID: 21029 RVA: 0x002672F4 File Offset: 0x002654F4
	public void IDPELCAAOFB(ONKDCGNBALK JMBKDINHDLO)
	{
		if (this.DJBELNNPCPO > 0)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.DJBELNNPCPO);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("SpinReel.ogg", 1f);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(300f, 400f, JNBICAJIJMM.LEBHCLDODNI("invn_win1"), true);
		this.DJBELNNPCPO = onkdcgnbalk.LPFKFNLHGBI;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 20f, 50f, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 22f, this.COKDFMFFDAE.JPBOPFNPNHC(false), TextAnchor.UpperCenter, Color.black);
		lcoljopgdll.LNDPBNODFPE = true;
		lcoljopgdll.DFIGKKMMIAF = 16;
		new KEPNAIFBDKF(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 28f, 70f, this.COKDFMFFDAE, 0);
		float num = 140f;
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 20f, num, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 22f, JNBICAJIJMM.LEBHCLDODNI("invn_rec1"), TextAnchor.UpperCenter, Color.black);
		lcoljopgdll2.LNDPBNODFPE = true;
		lcoljopgdll2.DFIGKKMMIAF = 16;
		num += 26f;
		num += 26f;
		foreach (IIBEEKCAAHK iibeekcaahk in this.NEGPPBJIHAF)
		{
			BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(iibeekcaahk.IBEIBAHKIAH);
			int num2 = iibeekcaahk.ICJDPPOJINN;
			new OCLNJMKDBKB(onkdcgnbalk, 40f, num, 32f, befchfngomi, 0);
			LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(onkdcgnbalk, 77f, num + 4f, string.Format(JNBICAJIJMM.LEBHCLDODNI("invn_rec2"), befchfngomi.JPBOPFNPNHC(false, -1), num2), true);
			lcoljopgdll3.LNDPBNODFPE = true;
			lcoljopgdll3.DFIGKKMMIAF = 14;
			num += 34f;
		}
		num += 26f;
		new DAOKDPKJDHH(onkdcgnbalk, new Rect(20f, onkdcgnbalk.OCHCODJIPHJ.height - 90f, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 35f), 2f, new ONKDCGNBALK.CMMHGMILOIM(this.HJEJLBFMAJC));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 64f, onkdcgnbalk.OCHCODJIPHJ.height - 42f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("btn_cancel"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
	}

	// Token: 0x06005226 RID: 21030 RVA: 0x00267594 File Offset: 0x00265794
	public void EBFGBLMGLBA(HBPNMNGOFMA KADBECGIMPD)
	{
		long phjohhdokhc = KADBECGIMPD.DNIIFBAIPBE();
		this.MEOJOEJBNDI = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FCHLEBEMIBK(phjohhdokhc);
		if (this.MEOJOEJBNDI == null)
		{
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(350f, 450f, JNBICAJIJMM.LEBHCLDODNI("auk_whead"), true);
		KEPNAIFBDKF kepnaifbdkf = new KEPNAIFBDKF(onkdcgnbalk, 20f, 50f, this.MEOJOEJBNDI, 0);
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, kepnaifbdkf.OCHCODJIPHJ.x + kepnaifbdkf.OCHCODJIPHJ.width + 5f, kepnaifbdkf.OCHCODJIPHJ.y, this.MEOJOEJBNDI.JPBOPFNPNHC(false), true);
		lcoljopgdll.DFIGKKMMIAF = 15;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont3;
		new LCOLJOPGDLL(onkdcgnbalk, kepnaifbdkf.OCHCODJIPHJ.x + kepnaifbdkf.OCHCODJIPHJ.width + 5f, kepnaifbdkf.OCHCODJIPHJ.y + 20f, string.Format(JNBICAJIJMM.LEBHCLDODNI("auk_wset"), this.MEOJOEJBNDI.ILFHHDNJHNM), true).DFIGKKMMIAF = 14;
		float num = KADBECGIMPD.FFDPCEAFGNF();
		float num2 = KADBECGIMPD.FFDPCEAFGNF();
		float num3 = KADBECGIMPD.FFDPCEAFGNF();
		int num4 = KADBECGIMPD.HDBGOLAFOBK();
		float num5 = kepnaifbdkf.OCHCODJIPHJ.y + kepnaifbdkf.OCHCODJIPHJ.height + 8f;
		new LCOLJOPGDLL(onkdcgnbalk, 20f, num5, string.Format(JNBICAJIJMM.LEBHCLDODNI("auk_wcnt"), num4), true).DFIGKKMMIAF = 14;
		num5 += 16f;
		new LCOLJOPGDLL(onkdcgnbalk, 20f, num5, string.Format(JNBICAJIJMM.LEBHCLDODNI("auk_wmin"), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)Mathf.RoundToInt(num), false)), true).DFIGKKMMIAF = 14;
		num5 += 16f;
		new LCOLJOPGDLL(onkdcgnbalk, 20f, num5, string.Format(JNBICAJIJMM.LEBHCLDODNI("auk_wmax"), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)Mathf.RoundToInt(num2), false)), true).DFIGKKMMIAF = 14;
		num5 += 16f;
		new LCOLJOPGDLL(onkdcgnbalk, 20f, num5, string.Format(JNBICAJIJMM.LEBHCLDODNI("auk_wavg"), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)Mathf.RoundToInt(num3), false)), true).DFIGKKMMIAF = 14;
		num5 += 16f;
		num5 += 16f;
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 20f, num5, JNBICAJIJMM.LEBHCLDODNI("auk_swtcost"), true);
		lcoljopgdll2.DFIGKKMMIAF = 15;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont3;
		num5 += 20f;
		this.BBOKGAOOIMG = (long)Mathf.RoundToInt(num3 * (float)this.MEOJOEJBNDI.ILFHHDNJHNM);
		if (this.BBOKGAOOIMG == 0L)
		{
			this.BBOKGAOOIMG = (long)Mathf.RoundToInt(num * (float)this.MEOJOEJBNDI.ILFHHDNJHNM);
		}
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, 20f, num5, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 40f, "", 0, null);
		num5 += 8f;
		this.MPBHBNBJBLA = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 10f, num5, JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, this.BBOKGAOOIMG, false), true)
		{
			DFIGKKMMIAF = 22,
			HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont
		};
		num5 += 22f;
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 90f, egcaadaabpp.OCHCODJIPHJ.y + 10f, 80f, 22f, JNBICAJIJMM.LEBHCLDODNI("auc_wcstc"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.MPHGGAKBHDE));
		num5 += 16f;
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(onkdcgnbalk, 20f, num5, JNBICAJIJMM.LEBHCLDODNI("auc_wcswcp"), true);
		lcoljopgdll3.DFIGKKMMIAF = 15;
		lcoljopgdll3.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont3;
		num5 += 20f;
		this.DCFMECEHGEM = (long)Mathf.RoundToInt(num2 * (float)this.MEOJOEJBNDI.ILFHHDNJHNM);
		if (this.BBOKGAOOIMG > this.DCFMECEHGEM)
		{
			this.DCFMECEHGEM = this.BBOKGAOOIMG;
		}
		EGCAADAABPP egcaadaabpp2 = new EGCAADAABPP(onkdcgnbalk, 20f, num5, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 40f, "", 0, null);
		num5 += 8f;
		this.JJNNIDBAEKL = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp2.OCHCODJIPHJ.x + 10f, num5, JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, this.DCFMECEHGEM, false), true)
		{
			DFIGKKMMIAF = 22,
			HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont
		};
		num5 += 22f;
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp2.OCHCODJIPHJ.x + egcaadaabpp2.OCHCODJIPHJ.width - 90f, egcaadaabpp2.OCHCODJIPHJ.y + 10f, 80f, 22f, JNBICAJIJMM.LEBHCLDODNI("auc_wcstc"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(this.MPHGGAKBHDE));
		long kfodjjihnhp = (long)(1 + Mathf.RoundToInt((float)(this.DCFMECEHGEM * (long)this.MEOJOEJBNDI.ILFHHDNJHNM) * 0.03f));
		num5 = egcaadaabpp2.OCHCODJIPHJ.y + egcaadaabpp2.OCHCODJIPHJ.height + 8f;
		LCOLJOPGDLL lcoljopgdll4 = new LCOLJOPGDLL(onkdcgnbalk, 20f, num5, JNBICAJIJMM.LEBHCLDODNI("auc_wsbor"), true);
		lcoljopgdll4.DFIGKKMMIAF = 15;
		lcoljopgdll4.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont3;
		num5 += 20f;
		EGCAADAABPP egcaadaabpp3 = new EGCAADAABPP(onkdcgnbalk, 20f, num5, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 36f, "", 0, null);
		num5 += 8f;
		this.HMJIHCHAEFN = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp3.OCHCODJIPHJ.x + 10f, num5, JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, kfodjjihnhp, false), true)
		{
			DFIGKKMMIAF = 22,
			HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont
		};
		num5 += 22f;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 130f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 120f, 24f, JNBICAJIJMM.LEBHCLDODNI("auc_toauk"), 90, null, new ONKDCGNBALK.CMMHGMILOIM(this.MPHGGAKBHDE));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 2f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 120f, 24f, JNBICAJIJMM.LEBHCLDODNI("btn_cancel"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
	}

	// Token: 0x06005227 RID: 21031 RVA: 0x00267C64 File Offset: 0x00265E64
	public void PKFEKICLLAF(HBPNMNGOFMA KADBECGIMPD)
	{
		if (this.MEOJOEJBNDI == null)
		{
			return;
		}
		this.JJNNIDBAEKL = null;
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(350f, 450f, JNBICAJIJMM.LEBHCLDODNI("auc_reshdr"), true);
		OCLNJMKDBKB oclnjmkdbkb = new OCLNJMKDBKB(onkdcgnbalk, 20f, 50f, 56f, this.MEOJOEJBNDI.BDHHPAEHFHG, 0);
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, oclnjmkdbkb.OCHCODJIPHJ.x + oclnjmkdbkb.OCHCODJIPHJ.width + 5f, oclnjmkdbkb.OCHCODJIPHJ.y, this.MEOJOEJBNDI.JPBOPFNPNHC(false), true);
		lcoljopgdll.DFIGKKMMIAF = 15;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont3;
		new LCOLJOPGDLL(onkdcgnbalk, oclnjmkdbkb.OCHCODJIPHJ.x + oclnjmkdbkb.OCHCODJIPHJ.width + 5f, oclnjmkdbkb.OCHCODJIPHJ.y + 20f, string.Format(JNBICAJIJMM.LEBHCLDODNI("auk_wset"), this.MEOJOEJBNDI.ILFHHDNJHNM), true).DFIGKKMMIAF = 14;
		float num = oclnjmkdbkb.OCHCODJIPHJ.y + oclnjmkdbkb.OCHCODJIPHJ.height + 8f;
		KADBECGIMPD.HDBGOLAFOBK();
		int num2 = KADBECGIMPD.HDBGOLAFOBK();
		int num3 = KADBECGIMPD.HDBGOLAFOBK();
		int num4 = KADBECGIMPD.HDBGOLAFOBK();
		int num5 = KADBECGIMPD.HDBGOLAFOBK();
		new LCOLJOPGDLL(onkdcgnbalk, 20f, num, string.Format(JNBICAJIJMM.LEBHCLDODNI("auk_wcnt"), num4), true).DFIGKKMMIAF = 14;
		num += 16f;
		new LCOLJOPGDLL(onkdcgnbalk, 20f, num, string.Format(JNBICAJIJMM.LEBHCLDODNI("auk_wmin"), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)Mathf.RoundToInt((float)num2), false)), true).DFIGKKMMIAF = 14;
		num += 16f;
		new LCOLJOPGDLL(onkdcgnbalk, 20f, num, string.Format(JNBICAJIJMM.LEBHCLDODNI("auk_wmax"), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)Mathf.RoundToInt((float)num3), false)), true).DFIGKKMMIAF = 14;
		num += 16f;
		new LCOLJOPGDLL(onkdcgnbalk, 20f, num, string.Format(JNBICAJIJMM.LEBHCLDODNI("auk_wavg"), JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)Mathf.RoundToInt((float)num5), false)), true).DFIGKKMMIAF = 14;
		num += 16f;
		num += 10f;
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 20f, num, JNBICAJIJMM.LEBHCLDODNI("auc_rescst"), true);
		lcoljopgdll2.DFIGKKMMIAF = 15;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont3;
		num += 20f;
		this.BBOKGAOOIMG = (long)Mathf.RoundToInt((float)(num5 + num2) / 2f);
		if (this.BBOKGAOOIMG == 0L)
		{
			this.BBOKGAOOIMG = (long)Mathf.RoundToInt(((float)this.MEOJOEJBNDI.LEADKFMCFCC * 100f + (float)this.MEOJOEJBNDI.DELMOBCNBDB) / (float)this.MEOJOEJBNDI.BDHHPAEHFHG.HOALBMDJNDM);
		}
		if (this.BBOKGAOOIMG == 0L)
		{
			this.BBOKGAOOIMG = 1L;
		}
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, 20f, num, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 40f, "", 0, null);
		num += 8f;
		this.MPBHBNBJBLA = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 10f, num, JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, this.BBOKGAOOIMG, false), true)
		{
			DFIGKKMMIAF = 22,
			HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont
		};
		num += 22f;
		new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 90f, egcaadaabpp.OCHCODJIPHJ.y + 10f, 80f, 22f, JNBICAJIJMM.LEBHCLDODNI("auc_wcstc"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.MPHGGAKBHDE));
		num = egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height + 8f;
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(onkdcgnbalk, 20f, num, JNBICAJIJMM.LEBHCLDODNI("auc_resallcst"), true);
		lcoljopgdll3.DFIGKKMMIAF = 15;
		lcoljopgdll3.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont3;
		num += 20f;
		EGCAADAABPP egcaadaabpp2 = new EGCAADAABPP(onkdcgnbalk, 20f, num, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 36f, "", 0, null);
		num += 8f;
		this.MGPDHMPIEFB = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp2.OCHCODJIPHJ.x + 10f, num, JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, this.BBOKGAOOIMG * (long)this.MEOJOEJBNDI.ILFHHDNJHNM, false), true)
		{
			DFIGKKMMIAF = 22,
			HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont
		};
		num += 22f;
		long kfodjjihnhp = (long)(1 + Mathf.RoundToInt((float)(this.BBOKGAOOIMG * (long)this.MEOJOEJBNDI.ILFHHDNJHNM) * 0.03f));
		num = egcaadaabpp2.OCHCODJIPHJ.y + egcaadaabpp2.OCHCODJIPHJ.height + 8f;
		LCOLJOPGDLL lcoljopgdll4 = new LCOLJOPGDLL(onkdcgnbalk, 20f, num, JNBICAJIJMM.LEBHCLDODNI("auc_wsbor"), true);
		lcoljopgdll4.DFIGKKMMIAF = 15;
		lcoljopgdll4.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont3;
		num += 20f;
		EGCAADAABPP egcaadaabpp3 = new EGCAADAABPP(onkdcgnbalk, 20f, num, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 36f, "", 0, null);
		num += 8f;
		this.HMJIHCHAEFN = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp3.OCHCODJIPHJ.x + 10f, num, JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, kfodjjihnhp, false), true)
		{
			DFIGKKMMIAF = 22,
			HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont
		};
		num += 22f;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 130f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 120f, 24f, JNBICAJIJMM.LEBHCLDODNI("auc_toauk"), 100, null, new ONKDCGNBALK.CMMHGMILOIM(this.MPHGGAKBHDE));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 2f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 120f, 24f, JNBICAJIJMM.LEBHCLDODNI("btn_cancel"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
	}

	// Token: 0x06005228 RID: 21032 RVA: 0x002682CC File Offset: 0x002664CC
	public void EIAHMMNHKAL(ONKDCGNBALK OJIMHKHFOJI)
	{
		Debug.Log("inventoryOpen");
		if (Fisherman.getI != null && Fisherman.getI.MFENINHGBHM)
		{
			this.KOCKAHEKJDB();
			return;
		}
		Fisherman.getI.sendAction(2, 4f, Vector3.zero);
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.NGKLLCCLFCM);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(1000f, 600f, JNBICAJIJMM.LEBHCLDODNI("inv_invheader"), true);
		this.NGKLLCCLFCM = onkdcgnbalk.LPFKFNLHGBI;
		onkdcgnbalk.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.LGFHOOHEBJG);
		onkdcgnbalk.ENCPJNMMMJI = new ONKDCGNBALK.CMMHGMILOIM(this.PIDKLEKJLFE);
		onkdcgnbalk.FONJHMOACFJ = new ONKDCGNBALK.CMMHGMILOIM(this.KCNKLPFDDDK);
		Rect rect = new Rect(718f, 68f, 225f, 355f);
		new EGCAADAABPP(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, "", 0, null).NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.ACPGHOPAMOH);
		new MGLHIBHDMPC(onkdcgnbalk, 400f, 60f, 0, GameInterface.getI.invBackMan);
		this.OEADFAEEJJP = new LCOLJOPGDLL(onkdcgnbalk, 20f, 60f, 300f, 30f, JNBICAJIJMM.IKGFHGKKCPG.OMNMDGIGEFD("BAG", "bag" + this.DJEOAABGBHH + "_info"), TextAnchor.UpperLeft, Color.black);
		int num = 80;
		for (int i = 1; i <= JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.IPPNBPONFHK; i++)
		{
			this.CPCHDFOFJIA[i] = new MEMEOHJKPNJ(onkdcgnbalk, 330f, (float)num, 100f, 20f, JNBICAJIJMM.IKGFHGKKCPG.OMNMDGIGEFD("BAG", "bag" + i + "_name"), i, null, new ONKDCGNBALK.CMMHGMILOIM(this.ABCHPMBIAMH));
			if (i == this.DJEOAABGBHH)
			{
				this.CPCHDFOFJIA[i].HKPAEGGJNGG = true;
			}
			num += 24;
		}
		new EGCAADAABPP(onkdcgnbalk, 0f, 0f, onkdcgnbalk.OCHCODJIPHJ.width, onkdcgnbalk.OCHCODJIPHJ.height, "", 0, null).NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.IJDODPNDNLK);
		new EGCAADAABPP(onkdcgnbalk, 20f, 80f, 290f, 464f, "", 0, null).NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.KHLNFNEKCFC);
	}

	// Token: 0x06005229 RID: 21033 RVA: 0x00268548 File Offset: 0x00266748
	public void IFGEEBANPJD(HBPNMNGOFMA KADBECGIMPD)
	{
		if (this.KBKJNEFDCFO != null)
		{
			this.KBKJNEFDCFO.JMMDIMGMPBL(KADBECGIMPD);
		}
		this.ANNJBBJIJLC.FNMCIACNOMH = true;
		this.ANNJBBJIJLC.MPKCOJHJIIB();
		this.ANNJBBJIJLC.NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.IJHKJCKAIDB);
		string dpanhmgcbnl = string.Format(JNBICAJIJMM.LEBHCLDODNI("inv_auklotinf"), this.KBKJNEFDCFO.ILFHHDNJHNM, JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, this.KBKJNEFDCFO.FKEDAOOHPPB, false), this.KBKJNEFDCFO.AONGINFINPD - TimeController.IKGFHGKKCPG.deltaTime);
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(this.ANNJBBJIJLC, this.ANNJBBJIJLC.OCHCODJIPHJ.x + 10f, this.ANNJBBJIJLC.OCHCODJIPHJ.y + 10f, this.ANNJBBJIJLC.OCHCODJIPHJ.width, this.ANNJBBJIJLC.OCHCODJIPHJ.height, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black);
		lcoljopgdll.LNDPBNODFPE = true;
		lcoljopgdll.DFIGKKMMIAF = 16;
		new MEMEOHJKPNJ(this.ANNJBBJIJLC, this.ANNJBBJIJLC.OCBAOFLJBGP.OCHCODJIPHJ.width - 135f - 30f, this.ANNJBBJIJLC.OCBAOFLJBGP.OCHCODJIPHJ.height - 55f, 120f, 24f, JNBICAJIJMM.LEBHCLDODNI("cntx_close"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(this.DPGPPIDPCIO));
		new MEMEOHJKPNJ(this.ANNJBBJIJLC, this.ANNJBBJIJLC.OCBAOFLJBGP.OCHCODJIPHJ.width - 405f - 30f, this.ANNJBBJIJLC.OCBAOFLJBGP.OCHCODJIPHJ.height - 55f, 120f, 24f, JNBICAJIJMM.LEBHCLDODNI("inv_auklotn"), 5, null, new ONKDCGNBALK.CMMHGMILOIM(this.ENDJAAHPOAL));
	}

	// Token: 0x0600522A RID: 21034 RVA: 0x0026872E File Offset: 0x0026692E
	public void CAGCMBLLFIB(ONKDCGNBALK ONPHLHKAGFP)
	{
		if (GameInterface.getI.useWeapon != null)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.MADKBBLOPGO(-153, GameInterface.getI.useWeapon.LPFKFNLHGBI);
		}
	}

	// Token: 0x0600522B RID: 21035 RVA: 0x0026875C File Offset: 0x0026695C
	public void PGDFEILABGA(HBPNMNGOFMA KADBECGIMPD)
	{
		long phjohhdokhc = KADBECGIMPD.DCGEOFHNBCN();
		KADBECGIMPD.KDNDJNEGBDI();
		this.LKNFODKOPED = KADBECGIMPD.BIMMPENHGMD();
		float num = KADBECGIMPD.BNDHIBEOKML();
		int num2 = KADBECGIMPD.AGNKAFLKCAG();
		int num3 = KADBECGIMPD.CLPEKGGAMAI();
		int num4 = KADBECGIMPD.HHLDBAEFNMJ();
		int num5 = KADBECGIMPD.IFDFHJLCHAE();
		int num6 = Mathf.RoundToInt(1122f - this.LKNFODKOPED);
		this.OGDKMNAONFF = num6 / 0;
		if (num6 % 7 > 0)
		{
			this.OGDKMNAONFF += 0;
		}
		this.KNHAGPNAKIL = KADBECGIMPD.AGNKAFLKCAG();
		this.MBJANEBEGDF = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BJDIEKNHGLJ(this.KNHAGPNAKIL, true, 1);
		this.POHLPMPEOKO = new IIBEEKCAAHK((double)this.KNHAGPNAKIL, 587.0, 240.0);
		this.POHLPMPEOKO.DFJKKEMEBCF((double)this.MBJANEBEGDF);
		Debug.Log("IdleStrafeRight" + num4);
		Debug.Log(" " + num2);
		Debug.Log("<color='{1}'>{0}</color>" + num);
		EKBAPCMPANI ekbapcmpani = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.FCHLEBEMIBK(phjohhdokhc);
		if (ekbapcmpani == null)
		{
			return;
		}
		this.COKDFMFFDAE = ekbapcmpani;
		JDCEFOFMGHB.HMJJPNDEKPP().KCNBOHEMLCI(this.ONGEHMJIMLO);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().NCIDDNIKACI(137f, 1299f, JNBICAJIJMM.DCEBAJIILPC("Forefeet Root"), false);
		this.ONGEHMJIMLO = onkdcgnbalk.LPFKFNLHGBI;
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, 1396f, 1327f, onkdcgnbalk.OCHCODJIPHJ.width - 1931f, onkdcgnbalk.OCHCODJIPHJ.height - 1385f, "TOD_CloudColor", 1, null);
		new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 36f, egcaadaabpp.OCHCODJIPHJ.y + 222f, egcaadaabpp.OCHCODJIPHJ.width - 1636f, 1983f, IHFEDJEMJMB.IKGFHGKKCPG.PLBJOFKHBIJ(ekbapcmpani.MBKMKGABBGE) + "OfficeSittingMouseMovement" + ekbapcmpani.FDJPJJJHHEG, TextAnchor.UpperCenter, Color.black).DFIGKKMMIAF = 127;
		new KEPNAIFBDKF(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width / 1368f - 1756f, egcaadaabpp.OCHCODJIPHJ.y + 1117f, ekbapcmpani, 1);
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 1362f, egcaadaabpp.OCHCODJIPHJ.y + 1950f, egcaadaabpp.OCHCODJIPHJ.width - 1789f, 19f, ekbapcmpani.MEKPGCCFEOO(true), TextAnchor.UpperLeft, Color.black);
		lcoljopgdll.DFIGKKMMIAF = 57;
		lcoljopgdll.LNDPBNODFPE = false;
		int num7 = -68;
		new EGCAADAABPP(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 254f, egcaadaabpp.OCHCODJIPHJ.y + (float)num7, egcaadaabpp.OCHCODJIPHJ.width - 1363f, 1405f, "LUX_LINEAR", 0, null);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 802f, egcaadaabpp.OCHCODJIPHJ.y + (float)num7 + 1580f, egcaadaabpp.OCHCODJIPHJ.width - 1765f, 1985f, JNBICAJIJMM.LEBHCLDODNI("_RgbTex"), TextAnchor.UpperLeft, Color.black);
		lcoljopgdll2.DFIGKKMMIAF = 47;
		lcoljopgdll2.LNDPBNODFPE = false;
		num7 += 72;
		GINEDLOJIIF ginedlojiif = new GINEDLOJIIF(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 110f, egcaadaabpp.OCHCODJIPHJ.y + (float)num7, 1334f, num4, num5, num3);
		ginedlojiif.MAKAFBBENPF = false;
		ginedlojiif.HMHBAMDBJLI = false;
		num7 += -11;
		EGCAADAABPP egcaadaabpp2 = new EGCAADAABPP(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 964f, egcaadaabpp.OCHCODJIPHJ.y + (float)num7, egcaadaabpp.OCHCODJIPHJ.width - 591f, 871f, "fchair", 1, null);
		long num8 = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BIHLDHKHPKE("Roller Blade Back Flip");
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 774f, egcaadaabpp2.OCHCODJIPHJ.y + 1349f, egcaadaabpp.OCHCODJIPHJ.width - 1947f, 972f, string.Format(JNBICAJIJMM.DIOJFJMOPJO("VIGNETTE_DESAT"), num8), TextAnchor.UpperLeft, Color.black);
		lcoljopgdll3.DFIGKKMMIAF = -67;
		lcoljopgdll3.LNDPBNODFPE = false;
		this.GJHKBPOOILO = new GMNEKCBLIAN(onkdcgnbalk, new Rect(egcaadaabpp.OCHCODJIPHJ.x + 1959f, egcaadaabpp2.OCHCODJIPHJ.y + 1301f, egcaadaabpp.OCHCODJIPHJ.width - 673f, 817f), this.LKNFODKOPED + (float)this.POHLPMPEOKO.KIDKOFKNPEP() * 1539f, 1513f, 6, "#mem Sound ", false);
		new GMNEKCBLIAN(onkdcgnbalk, new Rect(egcaadaabpp.OCHCODJIPHJ.x + 1383f, egcaadaabpp2.OCHCODJIPHJ.y + 1740f, egcaadaabpp.OCHCODJIPHJ.width - 629f, 1672f), this.LKNFODKOPED, 836f, 1, "-R-", false);
		egcaadaabpp2.NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.MLMDAJKNDDK);
		num7 += 46;
		ONKDCGNBALK onkdcgnbalk2 = new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 627f - 533f, onkdcgnbalk.OCHCODJIPHJ.height - 1629f, 71f, 1382f, JNBICAJIJMM.LEBHCLDODNI(""), 7, null, new ONKDCGNBALK.CMMHGMILOIM(this.ADAJGDDDCPK));
		bool fnmciacnomh = true;
		if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.KFODJJIHNHP < (long)num3)
		{
			fnmciacnomh = true;
		}
		if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BJDIEKNHGLJ(num4, true, 1) < num5)
		{
			fnmciacnomh = false;
		}
		if (JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BJDIEKNHGLJ(this.KNHAGPNAKIL, false, 1) < this.POHLPMPEOKO.KIDKOFKNPEP())
		{
			fnmciacnomh = false;
		}
		if (ekbapcmpani.LNKLEIEFGCP >= -54)
		{
			fnmciacnomh = false;
		}
		onkdcgnbalk2.FNMCIACNOMH = fnmciacnomh;
	}

	// Token: 0x0600522C RID: 21036 RVA: 0x00268D99 File Offset: 0x00266F99
	private void FHLJDAENBFP(ONKDCGNBALK ONPHLHKAGFP)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE(this.CDIFAABIAEG ? "start.ogg" : "Cloth_09.wav", 0.3f);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(230, this.DEFEALCKOKF);
	}

	// Token: 0x0600522D RID: 21037 RVA: 0x00268DD4 File Offset: 0x00266FD4
	public EKBAPCMPANI KIFEKEONBOL(int JGNIDDBNGGP, int DMAMOPGJOCK)
	{
		foreach (EKBAPCMPANI ekbapcmpani in JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.PLLHGAFIAFD.Values)
		{
			if (ekbapcmpani.JGNIDDBNGGP == JGNIDDBNGGP && ekbapcmpani.DMAMOPGJOCK == DMAMOPGJOCK && !ekbapcmpani.BFHKBOPOFGB)
			{
				return ekbapcmpani;
			}
		}
		return null;
	}

	// Token: 0x0600522E RID: 21038 RVA: 0x00268E50 File Offset: 0x00267050
	public void IJDODPNDNLK(ONKDCGNBALK PHEMLBHMNCM)
	{
		new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		if (!this.ABLFGLMKPNO && !Input.GetMouseButton(0))
		{
			EKBAPCMPANI kkleeibnibc = this.KKLEEIBNIBC;
		}
		if (!this.ABLFGLMKPNO)
		{
			MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = 0;
			MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = -1;
		}
		this.JBKMGGEGPCD(50, PHEMLBHMNCM, false);
		this.JBKMGGEGPCD(55, PHEMLBHMNCM, false);
		this.JBKMGGEGPCD(60, PHEMLBHMNCM, false);
		this.JBKMGGEGPCD(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KNNKJAEHDHF(), PHEMLBHMNCM, true);
	}

	// Token: 0x0600522F RID: 21039 RVA: 0x00022FCC File Offset: 0x000211CC
	public void GEKDJDMHMKC()
	{
	}

	// Token: 0x06005230 RID: 21040 RVA: 0x00268EE8 File Offset: 0x002670E8
	public void DLNBJCJAMFD(HBPNMNGOFMA KADBECGIMPD)
	{
		long phjohhdokhc = KADBECGIMPD.DNIIFBAIPBE();
		KADBECGIMPD.HDBGOLAFOBK();
		this.LKNFODKOPED = KADBECGIMPD.FFDPCEAFGNF();
		float num = KADBECGIMPD.FFDPCEAFGNF();
		int num2 = KADBECGIMPD.HDBGOLAFOBK();
		int num3 = KADBECGIMPD.HDBGOLAFOBK();
		int num4 = KADBECGIMPD.HDBGOLAFOBK();
		int num5 = KADBECGIMPD.HDBGOLAFOBK();
		int num6 = Mathf.RoundToInt(100f - this.LKNFODKOPED);
		this.OGDKMNAONFF = num6 / 5;
		if (num6 % 5 > 0)
		{
			this.OGDKMNAONFF++;
		}
		this.KNHAGPNAKIL = KADBECGIMPD.HDBGOLAFOBK();
		this.MBJANEBEGDF = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.KNHAGPNAKIL, false, 0);
		this.POHLPMPEOKO = new IIBEEKCAAHK((double)this.KNHAGPNAKIL, 0.0, 0.0);
		this.POHLPMPEOKO.ECDMPPDLHHH = (double)this.MBJANEBEGDF;
		Debug.Log("costwpn=" + num4);
		Debug.Log("toquality=" + num2);
		Debug.Log("paramsup=" + num);
		EKBAPCMPANI ekbapcmpani = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FCHLEBEMIBK(phjohhdokhc);
		if (ekbapcmpani == null)
		{
			return;
		}
		this.COKDFMFFDAE = ekbapcmpani;
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.ONGEHMJIMLO);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(400f, 540f, JNBICAJIJMM.LEBHCLDODNI("invn_rec5"), true);
		this.ONGEHMJIMLO = onkdcgnbalk.LPFKFNLHGBI;
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, 20f, 50f, onkdcgnbalk.OCHCODJIPHJ.width - 40f, onkdcgnbalk.OCHCODJIPHJ.height - 100f, "", 0, null);
		new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 10f, egcaadaabpp.OCHCODJIPHJ.y + 15f, egcaadaabpp.OCHCODJIPHJ.width - 20f, 22f, IHFEDJEMJMB.IKGFHGKKCPG.JGLANEDNNAB(ekbapcmpani.MBKMKGABBGE) + " " + ekbapcmpani.FDJPJJJHHEG, TextAnchor.UpperCenter, Color.black).DFIGKKMMIAF = 18;
		new KEPNAIFBDKF(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width / 2f - 28f, egcaadaabpp.OCHCODJIPHJ.y + 40f, ekbapcmpani, 0);
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 10f, egcaadaabpp.OCHCODJIPHJ.y + 115f, egcaadaabpp.OCHCODJIPHJ.width - 20f, 80f, ekbapcmpani.MEKPGCCFEOO(false), TextAnchor.UpperCenter, Color.black);
		lcoljopgdll.DFIGKKMMIAF = 14;
		lcoljopgdll.LNDPBNODFPE = true;
		int num7 = 200;
		new EGCAADAABPP(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 10f, egcaadaabpp.OCHCODJIPHJ.y + (float)num7, egcaadaabpp.OCHCODJIPHJ.width - 20f, 80f, "", 0, null);
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 15f, egcaadaabpp.OCHCODJIPHJ.y + (float)num7 + 10f, egcaadaabpp.OCHCODJIPHJ.width - 20f, 20f, JNBICAJIJMM.LEBHCLDODNI("invn_rec6"), TextAnchor.UpperCenter, Color.black);
		lcoljopgdll2.DFIGKKMMIAF = 18;
		lcoljopgdll2.LNDPBNODFPE = true;
		num7 += 40;
		GINEDLOJIIF ginedlojiif = new GINEDLOJIIF(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 15f, egcaadaabpp.OCHCODJIPHJ.y + (float)num7, 32f, num4, num5, num3);
		ginedlojiif.MAKAFBBENPF = true;
		ginedlojiif.HMHBAMDBJLI = true;
		num7 += 50;
		EGCAADAABPP egcaadaabpp2 = new EGCAADAABPP(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 10f, egcaadaabpp.OCHCODJIPHJ.y + (float)num7, egcaadaabpp.OCHCODJIPHJ.width - 20f, 120f, "", 0, null);
		long num8 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MHIIBKILGBL("impfail");
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 10f, egcaadaabpp2.OCHCODJIPHJ.y + 10f, egcaadaabpp.OCHCODJIPHJ.width - 20f, 80f, string.Format(JNBICAJIJMM.LEBHCLDODNI("invn_rec7"), num8), TextAnchor.UpperCenter, Color.black);
		lcoljopgdll3.DFIGKKMMIAF = 18;
		lcoljopgdll3.LNDPBNODFPE = true;
		this.GJHKBPOOILO = new GMNEKCBLIAN(onkdcgnbalk, new Rect(egcaadaabpp.OCHCODJIPHJ.x + 30f, egcaadaabpp2.OCHCODJIPHJ.y + 30f, egcaadaabpp.OCHCODJIPHJ.width - 60f, 20f), this.LKNFODKOPED + (float)this.POHLPMPEOKO.LKAGIEBPLAI * 10f, 100f, 2, "", false);
		new GMNEKCBLIAN(onkdcgnbalk, new Rect(egcaadaabpp.OCHCODJIPHJ.x + 30f, egcaadaabpp2.OCHCODJIPHJ.y + 30f, egcaadaabpp.OCHCODJIPHJ.width - 60f, 20f), this.LKNFODKOPED, 100f, 3, "", true);
		egcaadaabpp2.NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.MLMDAJKNDDK);
		num7 += 25;
		ONKDCGNBALK onkdcgnbalk2 = new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 64f, onkdcgnbalk.OCHCODJIPHJ.height - 42f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("invn_rec8"), 6, null, new ONKDCGNBALK.CMMHGMILOIM(this.LDOFFICAGHB));
		bool fnmciacnomh = true;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KFODJJIHNHP < (long)num3)
		{
			fnmciacnomh = false;
		}
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(num4, false, 0) < num5)
		{
			fnmciacnomh = false;
		}
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.KNHAGPNAKIL, false, 0) < this.POHLPMPEOKO.LKAGIEBPLAI)
		{
			fnmciacnomh = false;
		}
		if (ekbapcmpani.LNKLEIEFGCP >= 15)
		{
			fnmciacnomh = false;
		}
		onkdcgnbalk2.FNMCIACNOMH = fnmciacnomh;
	}

	// Token: 0x06005231 RID: 21041 RVA: 0x00269528 File Offset: 0x00267728
	public bool PAGOJABJFCB(EKBAPCMPANI MEJMEKODJAE, int JGNIDDBNGGP, int IJMHJKHNOAC)
	{
		if (JGNIDDBNGGP < -61)
		{
			return false;
		}
		if (JGNIDDBNGGP == -37)
		{
			return false;
		}
		if (JGNIDDBNGGP == 58)
		{
			return true;
		}
		bool flag = KBJGAFNMGCK.IOALEBMCEGM().LDLNKMKLKOC(JGNIDDBNGGP).OIBFINKINIL(IJMHJKHNOAC).HBFDOAPEKCB(MEJMEKODJAE.BDHHPAEHFHG.MBKMKGABBGE);
		if (MEJMEKODJAE.GOEGADLBGML > ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.CNOLCNDBLJE))
		{
			flag = false;
		}
		if (MEJMEKODJAE.BDHHPAEHFHG.MBOOFLANJID != 0)
		{
			if (MEJMEKODJAE.BDHHPAEHFHG.MBOOFLANJID == 1 && JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.GDJMBFGEMFJ != 0)
			{
				flag = true;
			}
			if (MEJMEKODJAE.BDHHPAEHFHG.MBOOFLANJID == 2 && JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.GDJMBFGEMFJ != 0)
			{
				flag = true;
			}
		}
		if (flag)
		{
			foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in MEJMEKODJAE.PKIICJOILKI)
			{
				if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI) < dlmglijdiai.CNOLCNDBLJE)
				{
					return false;
				}
			}
		}
		if (flag)
		{
			int num = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.KNNKJAEHDHF();
			if (JGNIDDBNGGP == num)
			{
				int num2 = 1;
				foreach (EKBAPCMPANI ekbapcmpani in JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PLLHGAFIAFD.Values)
				{
					if (ekbapcmpani.JGNIDDBNGGP == num && ekbapcmpani.BDHHPAEHFHG.GCLKLEIMABA > 1)
					{
						num2 = ekbapcmpani.BDHHPAEHFHG.GCLKLEIMABA;
						break;
					}
				}
				if (num2 > 0 && MEJMEKODJAE.BDHHPAEHFHG.GCLKLEIMABA > 0 && MEJMEKODJAE.BDHHPAEHFHG.GCLKLEIMABA != num2)
				{
					flag = false;
				}
			}
		}
		return flag;
	}

	// Token: 0x06005232 RID: 21042 RVA: 0x00022FCC File Offset: 0x000211CC
	public void MLNLPLKOIEM()
	{
	}

	// Token: 0x06005233 RID: 21043 RVA: 0x00269704 File Offset: 0x00267904
	public void LDOFFICAGHB(ONKDCGNBALK ONPHLHKAGFP)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.OBCCLNMPGEJ(this.COKDFMFFDAE.LPFKFNLHGBI);
			epmphjgalbe.GOMLLPFFPNP(this.POHLPMPEOKO.LKAGIEBPLAI);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(235, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.ONGEHMJIMLO);
	}

	// Token: 0x06005234 RID: 21044 RVA: 0x00269784 File Offset: 0x00267984
	public void OPKCNFFABDF(HBPNMNGOFMA KADBECGIMPD)
	{
		KADBECGIMPD.HDBGOLAFOBK();
		int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
		int num = KADBECGIMPD.HDBGOLAFOBK();
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi);
		if (befchfngomi != null)
		{
			string iabkgmnjljo = string.Format(JNBICAJIJMM.LEBHCLDODNI("inv_buymsg"), befchfngomi.JPBOPFNPNHC(false, -1), num);
			FlyMessageManager.getI.addMessageBig(iabkgmnjljo, Color.white, befchfngomi.LPFKFNLHGBI, befchfngomi.KBGHOIJIPJF);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("cash.ogg", 0.5f);
	}

	// Token: 0x06005235 RID: 21045 RVA: 0x00269804 File Offset: 0x00267A04
	public void GJFGHJIJNCA(HBPNMNGOFMA KADBECGIMPD)
	{
		if (this.HEGMKNAMIHB != 0)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.HEGMKNAMIHB);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(800f, 600f, JNBICAJIJMM.LEBHCLDODNI("auk_head"), true);
		this.HEGMKNAMIHB = onkdcgnbalk.LPFKFNLHGBI;
		this.AGDMAFCKMJP = new JNHLAGHJBAA(onkdcgnbalk, 20f, 45f, 310f, onkdcgnbalk.OCHCODJIPHJ.height - 65f, 0);
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.ABMDIOIJALO = Color.black;
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.IKGFHGKKCPG.CHFGNHKJNFG("Auktree.xml", false));
		JLFJEGIPIMM.IKGFHGKKCPG.GGKGFKPNEJK(this.AGDMAFCKMJP.EELDHNFBFOE, xmlDocument.SelectNodes("auk_data/categories/category"), false);
		this.AGDMAFCKMJP.BJPFFMKEHDL("aukTree");
		this.AGDMAFCKMJP.GIOGEHKMKDE = false;
		this.AGDMAFCKMJP.EELDHNFBFOE.ODFEKBJCFMN = -1L;
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.AOHDHGNCHHF = Color.black;
		this.AGDMAFCKMJP.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.CEDPLPDLPJB);
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
			int ilfhhdnjhnm = KADBECGIMPD.HDBGOLAFOBK();
			MDEKJCCIDIA.KCFIPOJDHGB kcfipojdhgb = new MDEKJCCIDIA.KCFIPOJDHGB();
			kcfipojdhgb.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			kcfipojdhgb.ILFHHDNJHNM = ilfhhdnjhnm;
			kcfipojdhgb.BDHHPAEHFHG = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi);
			if (kcfipojdhgb.BDHHPAEHFHG != null)
			{
				kcfipojdhgb.BDHHPAEHFHG.JIFFLPNBILE();
				JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = this.AGDMAFCKMJP.MJMOMMKECMF((long)kcfipojdhgb.BDHHPAEHFHG.MBKMKGABBGE);
				if (fpaeeadmcie == null)
				{
					fpaeeadmcie = this.AGDMAFCKMJP.MJMOMMKECMF(0L);
				}
				fpaeeadmcie.LGMBHELCEEL(kcfipojdhgb, (long)kcfipojdhgb.BDHHPAEHFHG.LPFKFNLHGBI).AHFGACFMGEJ = new JNHLAGHJBAA.FPAEEADMCIE.COGMIMMKMME(this.IKABEPNBLOG);
			}
		}
		this.AGDMAFCKMJP.JHNCNHAAJCH = 40f;
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, this.AGDMAFCKMJP.OCHCODJIPHJ.x + this.AGDMAFCKMJP.OCHCODJIPHJ.width + 10f, this.AGDMAFCKMJP.OCHCODJIPHJ.y - 4f, onkdcgnbalk.OCHCODJIPHJ.width - (this.AGDMAFCKMJP.OCHCODJIPHJ.x + this.AGDMAFCKMJP.OCHCODJIPHJ.width + 20f), this.AGDMAFCKMJP.OCHCODJIPHJ.height, "", 0, null);
		egcaadaabpp.NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.KMGAKKDABEK);
		this.ANNJBBJIJLC = new EGCAADAABPP(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 10f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 200f - 10f, egcaadaabpp.OCHCODJIPHJ.width - 20f, 200f, "", 0, null);
		this.ANNJBBJIJLC.FNMCIACNOMH = false;
	}

	// Token: 0x06005236 RID: 21046 RVA: 0x00269B10 File Offset: 0x00267D10
	public EKBAPCMPANI EJFELLJIACI(int JGNIDDBNGGP, int DMAMOPGJOCK)
	{
		foreach (EKBAPCMPANI ekbapcmpani in JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.PLLHGAFIAFD.Values)
		{
			if (ekbapcmpani.JGNIDDBNGGP == JGNIDDBNGGP && ekbapcmpani.DMAMOPGJOCK == DMAMOPGJOCK && !ekbapcmpani.BFHKBOPOFGB)
			{
				return ekbapcmpani;
			}
		}
		return null;
	}

	// Token: 0x06005237 RID: 21047 RVA: 0x00269B8C File Offset: 0x00267D8C
	public void CLMPFJHJOCL(ONKDCGNBALK PHEMLBHMNCM)
	{
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		if (!this.ABLFGLMKPNO && !Input.GetMouseButton(0))
		{
			EKBAPCMPANI kkleeibnibc = this.KKLEEIBNIBC;
		}
		if (!this.ABLFGLMKPNO)
		{
			MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = 0;
			MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = -1;
		}
		float num = PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.x;
		float num2 = PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.y;
		bool flag = new Rect(num, num2, PHEMLBHMNCM.OCHCODJIPHJ.width, PHEMLBHMNCM.OCHCODJIPHJ.height).Contains(vector);
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		int blaeboonadj = this.BLAEBOONADJ;
		float x = PHEMLBHMNCM.OCHCODJIPHJ.x;
		float y = PHEMLBHMNCM.OCHCODJIPHJ.y;
		int num3 = blaeboonadj / 9;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		float num7 = (float)(58 * num3);
		if (num7 < 464f)
		{
			num7 = 464f;
		}
		bool flag2 = false;
		this.AICBIFFGBOH = GUI.BeginScrollView(new Rect(x, y, 540f, 464f), this.AICBIFFGBOH, new Rect(x, y, 522f, num7), false, false);
		for (int i = 0; i <= num3; i++)
		{
			for (int j = 0; j < 9; j++)
			{
				if (num4 < blaeboonadj)
				{
					bool flag3 = true;
					if (flag)
					{
						Rect rect = new Rect(num + (float)num5, num2 + (float)num6 - this.AICBIFFGBOH.y, 58f, 58f);
						if (rect.Contains(vector))
						{
							this.DKFICLCPICL.x = vector.x - rect.x;
							this.DKFICLCPICL.y = vector.y - rect.y;
							this.OJKBEDCFFND = i * 9 + j;
							this.AMBNJGDIDED = 52;
							this.ABLFGLMKPNO = true;
							if (this.KKLEEIBNIBC != null)
							{
								GUI.DrawTexture(new Rect(x + (float)num5, y + (float)num6, 56f, 56f), GameInterface.getI.invEmptyCellSelect);
								flag3 = false;
							}
						}
					}
					if (flag3)
					{
						GUI.DrawTexture(new Rect(x + (float)num5, y + (float)num6, 56f, 56f), GameInterface.getI.invEmptyCell);
					}
					num4++;
				}
				else
				{
					if (!flag2)
					{
						Rect position = new Rect(x + (float)num5, y + (float)num6, 56f, 56f);
						Texture image = GameInterface.getI.invCellPlus;
						Rect rect2 = new Rect(num + (float)num5, num2 + (float)num6 - this.AICBIFFGBOH.y, 58f, 58f);
						if (rect2.Contains(vector))
						{
							image = GameInterface.getI.invCellPlusSelect;
						}
						GUI.DrawTexture(position, image);
						if (GUI.Button(position, "", GUIStyle.none))
						{
							Debug.Log("Add inventory Click!");
							NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(210, 52);
						}
						num4++;
					}
					flag2 = true;
				}
				num5 += 58;
			}
			num5 = 0;
			num6 += 58;
		}
		foreach (EKBAPCMPANI ekbapcmpani in kfhelhglnmh.PLLHGAFIAFD.Values)
		{
			if (ekbapcmpani.JGNIDDBNGGP == 52)
			{
				Vector2 vector2 = this.MCENPOGEIAJ(ekbapcmpani.DMAMOPGJOCK);
				ekbapcmpani.JCIIPCEDICP(new Vector2(x + vector2.x, y + vector2.y), 56f);
			}
		}
		GUI.EndScrollView();
	}

	// Token: 0x06005238 RID: 21048 RVA: 0x00269F58 File Offset: 0x00268158
	private void ICCBGBDMNDI(ONKDCGNBALK ONPHLHKAGFP)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE(this.CDIFAABIAEG ? "SoundMgr is init part 1" : "CraftProf.xml", 1820f);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-17, this.DEFEALCKOKF);
	}

	// Token: 0x06005239 RID: 21049 RVA: 0x0026463C File Offset: 0x0026283C
	public void EIPJDMDOHBI(EKBAPCMPANI DCCPCBLODIG)
	{
		this.EBKMEHACMJE = DCCPCBLODIG;
	}

	// Token: 0x0600523A RID: 21050 RVA: 0x00269F92 File Offset: 0x00268192
	private void MMKPMIFOJFL(ONKDCGNBALK ONPHLHKAGFP)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.ONGEHMJIMLO);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(199, this.COKDFMFFDAE.LPFKFNLHGBI);
	}

	// Token: 0x0600523B RID: 21051 RVA: 0x00269FC0 File Offset: 0x002681C0
	public ONKDCGNBALK JDIANCANDFJ(HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.sendAction(2, 4f, Vector3.zero);
		this.BLAEBOONADJ = KADBECGIMPD.HDBGOLAFOBK();
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(1000f, 600f, JNBICAJIJMM.LEBHCLDODNI("inv_invheader"), true);
		this.NGKLLCCLFCM = onkdcgnbalk.LPFKFNLHGBI;
		onkdcgnbalk.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.LGFHOOHEBJG);
		onkdcgnbalk.ENCPJNMMMJI = new ONKDCGNBALK.CMMHGMILOIM(this.PIDKLEKJLFE);
		onkdcgnbalk.FONJHMOACFJ = new ONKDCGNBALK.CMMHGMILOIM(this.KCNKLPFDDDK);
		this.OEADFAEEJJP = new LCOLJOPGDLL(onkdcgnbalk, 20f, 60f, 300f, 30f, JNBICAJIJMM.IKGFHGKKCPG.OMNMDGIGEFD("BAG", "bag" + this.DJEOAABGBHH + "_info"), TextAnchor.UpperLeft, Color.black);
		int num = 80;
		for (int i = 1; i <= JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.IPPNBPONFHK; i++)
		{
			this.CPCHDFOFJIA[i] = new MEMEOHJKPNJ(onkdcgnbalk, 330f, (float)num, 100f, 20f, JNBICAJIJMM.IKGFHGKKCPG.OMNMDGIGEFD("BAG", "bag" + i + "_name"), i, null, new ONKDCGNBALK.CMMHGMILOIM(this.ABCHPMBIAMH));
			if (i == this.DJEOAABGBHH)
			{
				this.CPCHDFOFJIA[i].HKPAEGGJNGG = true;
			}
			num += 24;
		}
		new EGCAADAABPP(onkdcgnbalk, 445f, 80f, onkdcgnbalk.OCHCODJIPHJ.width - 445f, 464f, "", 0, null).NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.CLMPFJHJOCL);
		new EGCAADAABPP(onkdcgnbalk, 20f, 80f, 290f, 464f, "", 0, null).NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.KHLNFNEKCFC);
		return onkdcgnbalk;
	}

	// Token: 0x0600523C RID: 21052 RVA: 0x0026A1A0 File Offset: 0x002683A0
	public ONKDCGNBALK KOCKAHEKJDB()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.NGKLLCCLFCM);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(530f, 600f, JNBICAJIJMM.LEBHCLDODNI("inv_invheader"), true);
		this.NGKLLCCLFCM = onkdcgnbalk.LPFKFNLHGBI;
		onkdcgnbalk.FJBIDGIINCP = new ONKDCGNBALK.CMMHGMILOIM(this.LGFHOOHEBJG);
		onkdcgnbalk.ENCPJNMMMJI = new ONKDCGNBALK.CMMHGMILOIM(this.PIDKLEKJLFE);
		onkdcgnbalk.FONJHMOACFJ = new ONKDCGNBALK.CMMHGMILOIM(this.KCNKLPFDDDK);
		this.OEADFAEEJJP = new LCOLJOPGDLL(onkdcgnbalk, 20f, 60f, 300f, 30f, JNBICAJIJMM.IKGFHGKKCPG.OMNMDGIGEFD("BAG", "bag" + this.DJEOAABGBHH + "_info"), TextAnchor.UpperLeft, Color.black);
		int num = 80;
		for (int i = 1; i <= JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.IPPNBPONFHK; i++)
		{
			this.CPCHDFOFJIA[i] = new MEMEOHJKPNJ(onkdcgnbalk, 330f, (float)num, 100f, 20f, JNBICAJIJMM.IKGFHGKKCPG.OMNMDGIGEFD("BAG", "bag" + i + "_name"), i, null, new ONKDCGNBALK.CMMHGMILOIM(this.ABCHPMBIAMH));
			if (i == this.DJEOAABGBHH)
			{
				this.CPCHDFOFJIA[i].HKPAEGGJNGG = true;
			}
			num += 24;
		}
		new EGCAADAABPP(onkdcgnbalk, 0f, 0f, onkdcgnbalk.OCHCODJIPHJ.width, onkdcgnbalk.OCHCODJIPHJ.height, "", 0, null).NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.IJDODPNDNLK);
		new EGCAADAABPP(onkdcgnbalk, 20f, 80f, 290f, 464f, "", 0, null).NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.KHLNFNEKCFC);
		return onkdcgnbalk;
	}

	// Token: 0x0600523D RID: 21053 RVA: 0x0026A36C File Offset: 0x0026856C
	public void BCLKJEKLGEN(ONKDCGNBALK PHEMLBHMNCM)
	{
		new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		if (!this.ABLFGLMKPNO && !Input.GetMouseButton(1))
		{
			EKBAPCMPANI kkleeibnibc = this.KKLEEIBNIBC;
		}
		if (!this.ABLFGLMKPNO)
		{
			MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = 1;
			MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = -1;
		}
		this.FMINAKGAHLB(29, PHEMLBHMNCM, true);
		this.JBKMGGEGPCD(-47, PHEMLBHMNCM, true);
		this.FMINAKGAHLB(72, PHEMLBHMNCM, false);
		this.FMINAKGAHLB(JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.KNNKJAEHDHF(), PHEMLBHMNCM, true);
	}

	// Token: 0x0600523E RID: 21054 RVA: 0x0026A404 File Offset: 0x00268604
	public void KNNILCKBAGM(ONKDCGNBALK ONPHLHKAGFP)
	{
		long lpfkfnlhgbi = this.COKDFMFFDAE.LPFKFNLHGBI;
		long lpfkfnlhgbi2 = (this.EFIBDEMHFDD.LACAJHOHACK[this.EFIBDEMHFDD.IHEILFHMLAG] as EKBAPCMPANI).LPFKFNLHGBI;
		Debug.Log(string.Concat(new object[]
		{
			"remWpn=",
			lpfkfnlhgbi,
			" remnabor=",
			lpfkfnlhgbi2
		}));
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.OBCCLNMPGEJ(lpfkfnlhgbi);
			epmphjgalbe.OBCCLNMPGEJ(lpfkfnlhgbi2);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(198, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("repair.ogg", 1f);
	}

	// Token: 0x0600523F RID: 21055 RVA: 0x0026A4CC File Offset: 0x002686CC
	public void CGBKGPPNMNM()
	{
		if (JDCEFOFMGHB.MNJNNDHCDGG().HILJENLHLDE(this.ELLIGFJNLGM) != null)
		{
			return;
		}
		if (this.KPILNBINPMN != null)
		{
			if (!this.IHNJOHJCBMK)
			{
				this.BKDCMGLAHAI();
			}
			this.OJKBEDCFFND = -1;
			return;
		}
		if (this.EBKMEHACMJE != null)
		{
			if (this.OCOMOGDADHE == this.EBKMEHACMJE.LPFKFNLHGBI)
			{
				this.NDAAMOJNKMP += Time.deltaTime;
			}
			else
			{
				this.NDAAMOJNKMP = 1326f;
			}
		}
		if (this.OJKBEDCFFND >= 1)
		{
			this.EBKMEHACMJE = this.EHHKCFOAKAI(this.AMBNJGDIDED, this.OJKBEDCFFND);
			if (this.EBKMEHACMJE == null)
			{
				this.NDAAMOJNKMP = 1666f;
				this.OCOMOGDADHE = 0L;
				JDCEFOFMGHB.IKGFHGKKCPG.AFLEEHDFHMJ = JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN[JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN.Count - 0].LPFKFNLHGBI;
				return;
			}
			if (this.NGKLLCCLFCM != JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN[JDCEFOFMGHB.JFIDAGABKID().ICKODGMJINN.Count - 0].LPFKFNLHGBI)
			{
				this.NDAAMOJNKMP = 1377f;
			}
			this.OCOMOGDADHE = this.EBKMEHACMJE.LPFKFNLHGBI;
			if (this.NDAAMOJNKMP > 1736f)
			{
				this.LPACNNDMOCN(this.EBKMEHACMJE);
			}
			if (Input.GetMouseButton(0) || Input.GetMouseButton(0))
			{
				this.NDAAMOJNKMP = 532f;
				this.OCOMOGDADHE = 0L;
				JDCEFOFMGHB.MNJNNDHCDGG().AFLEEHDFHMJ = JDCEFOFMGHB.MNJNNDHCDGG().ICKODGMJINN[JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count - 1].LPFKFNLHGBI;
				return;
			}
		}
		else
		{
			this.NDAAMOJNKMP = 119f;
			this.OCOMOGDADHE = 1L;
			JDCEFOFMGHB.MNJNNDHCDGG().AFLEEHDFHMJ = JDCEFOFMGHB.HMJJPNDEKPP().ICKODGMJINN[JDCEFOFMGHB.MNJNNDHCDGG().ICKODGMJINN.Count - 1].LPFKFNLHGBI;
		}
	}

	// Token: 0x06005240 RID: 21056 RVA: 0x0026A6B1 File Offset: 0x002688B1
	private void DPGPPIDPCIO(ONKDCGNBALK OJIMHKHFOJI)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.HEGMKNAMIHB);
	}

	// Token: 0x06005241 RID: 21057 RVA: 0x0026A6C3 File Offset: 0x002688C3
	public void EEKPMBPJIMB(ONKDCGNBALK ONPHLHKAGFP)
	{
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1710, GameInterface.getI.useWeapon.LPFKFNLHGBI);
	}

	// Token: 0x06005242 RID: 21058 RVA: 0x0026A6E4 File Offset: 0x002688E4
	public int OIMDOKBCEJE(EKBAPCMPANI MEJMEKODJAE)
	{
		if (JDCEFOFMGHB.IKGFHGKKCPG.MDBEKDJJHBI)
		{
			return -1;
		}
		if (MEJMEKODJAE == null)
		{
			return -1;
		}
		if (JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(this.ELLIGFJNLGM) != null)
		{
			return -1;
		}
		GUI.skin = GuiProcessor.IKGFHGKKCPG.alterSkin;
		this.EBKMEHACMJE = MEJMEKODJAE;
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		Vector2 vector2 = new Vector2(vector.x + 10f, vector.y - 120f);
		if (vector2.x + 360f > (float)(Screen.width - 10))
		{
			vector2.x = (float)(Screen.width - 10 - 360);
		}
		if (vector2.y + this.GANOCEBJKJE > (float)(Screen.height - 10))
		{
			vector2.y = (float)(Screen.height - 10) - this.GANOCEBJKJE;
		}
		int num = JDCEFOFMGHB.IKGFHGKKCPG.DIBNCPKGGOF + 2;
		this.JDFMHNPDDHJ = false;
		if (!this.IHNJOHJCBMK)
		{
			GUI.ModalWindow(num, new Rect(vector2.x, vector2.y, 360f, this.GANOCEBJKJE), new GUI.WindowFunction(this.EAOLHBCPOJH), "");
		}
		return num;
	}

	// Token: 0x06005243 RID: 21059 RVA: 0x0026A81C File Offset: 0x00268A1C
	public void ANILOGOGFEL(ONKDCGNBALK ONPHLHKAGFP)
	{
		if (GameInterface.getI.useWeapon != null)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(275, GameInterface.getI.useWeapon.LPFKFNLHGBI);
		}
	}

	// Token: 0x06005244 RID: 21060 RVA: 0x0026A848 File Offset: 0x00268A48
	public void ANFHJIIMJNL()
	{
		if (JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(this.ELLIGFJNLGM) != null)
		{
			return;
		}
		if (this.KPILNBINPMN != null)
		{
			if (!this.IHNJOHJCBMK)
			{
				this.MHPBAGMMDAD();
			}
			this.OJKBEDCFFND = -1;
			return;
		}
		if (this.EBKMEHACMJE != null)
		{
			if (this.OCOMOGDADHE == this.EBKMEHACMJE.LPFKFNLHGBI)
			{
				this.NDAAMOJNKMP += Time.deltaTime;
			}
			else
			{
				this.NDAAMOJNKMP = 0f;
			}
		}
		if (this.OJKBEDCFFND >= 0)
		{
			this.EBKMEHACMJE = this.EHHKCFOAKAI(this.AMBNJGDIDED, this.OJKBEDCFFND);
			if (this.EBKMEHACMJE == null)
			{
				this.NDAAMOJNKMP = 0f;
				this.OCOMOGDADHE = 0L;
				JDCEFOFMGHB.IKGFHGKKCPG.AFLEEHDFHMJ = JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN[JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count - 1].LPFKFNLHGBI;
				return;
			}
			if (this.NGKLLCCLFCM != JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN[JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count - 1].LPFKFNLHGBI)
			{
				this.NDAAMOJNKMP = 0f;
			}
			this.OCOMOGDADHE = this.EBKMEHACMJE.LPFKFNLHGBI;
			if (this.NDAAMOJNKMP > 0.9f)
			{
				this.OIMDOKBCEJE(this.EBKMEHACMJE);
			}
			if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
			{
				this.NDAAMOJNKMP = 0f;
				this.OCOMOGDADHE = 0L;
				JDCEFOFMGHB.IKGFHGKKCPG.AFLEEHDFHMJ = JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN[JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count - 1].LPFKFNLHGBI;
				return;
			}
		}
		else
		{
			this.NDAAMOJNKMP = 0f;
			this.OCOMOGDADHE = 0L;
			JDCEFOFMGHB.IKGFHGKKCPG.AFLEEHDFHMJ = JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN[JDCEFOFMGHB.IKGFHGKKCPG.ICKODGMJINN.Count - 1].LPFKFNLHGBI;
		}
	}

	// Token: 0x06005245 RID: 21061 RVA: 0x0026AA30 File Offset: 0x00268C30
	public void IGNGNFIMAON(MMKFAENBHKD ONPHLHKAGFP, ItemBase HEABEPINGED)
	{
		if (HEABEPINGED != null)
		{
			EKBAPCMPANI ekbapcmpani = HEABEPINGED as EKBAPCMPANI;
			this.EMNCOCGHKKN.FPIHOPOCAHA = string.Format(JNBICAJIJMM.LEBHCLDODNI("invn_rec4"), ekbapcmpani.LODGJCMEGAI.IBEIBAHKIAH, ekbapcmpani.LODGJCMEGAI.ICJDPPOJINN);
			this.NEBLGPAOGGH.EBLHAJDINBH = this.COKDFMFFDAE.DLHPFGHOINI + (float)ekbapcmpani.LODGJCMEGAI.IBEIBAHKIAH;
		}
	}

	// Token: 0x06005246 RID: 21062 RVA: 0x0026AAA4 File Offset: 0x00268CA4
	public void BKDCMGLAHAI()
	{
		if (JDCEFOFMGHB.HMJJPNDEKPP().MDBEKDJJHBI)
		{
			return;
		}
		if (this.KPILNBINPMN == null)
		{
			return;
		}
		GUI.skin = GuiProcessor.IKGFHGKKCPG.alterSkin;
		int num = JDCEFOFMGHB.HMJJPNDEKPP().DIBNCPKGGOF + 1;
		GUI.Window(num, this.MCMGPBDHCLN, new GUI.WindowFunction(this.GGDHIHEAEJG), JNBICAJIJMM.PGJCPFNJNPM("colorB"), GuiProcessor.PLGADNLAEGN().alterSkin.GetStyle("Idle Ready"));
		GUI.BringWindowToFront(num);
		JDCEFOFMGHB.HMJJPNDEKPP().AFLEEHDFHMJ = num;
	}

	// Token: 0x06005247 RID: 21063 RVA: 0x0026AB2C File Offset: 0x00268D2C
	public void GGDHIHEAEJG(int LPFKFNLHGBI)
	{
		if (this.KPILNBINPMN == null)
		{
			return;
		}
		GUI.skin = GuiProcessor.IKGFHGKKCPG.alterSkin;
		GUI.BringWindowToFront(LPFKFNLHGBI);
		GUI.FocusWindow(LPFKFNLHGBI);
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = Color.white;
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.wordWrap = true;
		guistyle.richText = true;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
		guistyle.fontSize = 11;
		int num = 25;
		foreach (ItemBase itemBase in this.EIPJCEDGFGM)
		{
			if (itemBase.tag <= 0L)
			{
				num += 15;
			}
			else
			{
				GUI.enabled = itemBase.isVisible;
				if (GUI.Button(new Rect(10f, (float)num, 140f, 20f), itemBase.ToString()))
				{
					JDCEFOFMGHB.IKGFHGKKCPG.BFHKBOPOFGB = false;
					if (this.KKLEEIBNIBC != null)
					{
						this.KKLEEIBNIBC.BFHKBOPOFGB = false;
						this.KKLEEIBNIBC = null;
					}
					long tag = itemBase.tag;
					if (tag <= 70L)
					{
						if (tag <= 10L)
						{
							long num2 = tag - 1L;
							if (num2 <= 4L)
							{
								switch ((uint)num2)
								{
								case 0U:
									this.COKDFMFFDAE = this.KPILNBINPMN;
									if (this.COKDFMFFDAE != null)
									{
										string arg = this.COKDFMFFDAE.BDHHPAEHFHG.BNIHFBMEPAB ?? "";
										JDCEFOFMGHB.IKGFHGKKCPG.LLKDAODBJDA(JNBICAJIJMM.LEBHCLDODNI("invn_rec13"), string.Format(JNBICAJIJMM.LEBHCLDODNI("invn_rec14"), arg), new ONKDCGNBALK.CMMHGMILOIM(this.JNAIBMAEJPP), new ONKDCGNBALK.CMMHGMILOIM(this.JNAIBMAEJPP));
									}
									FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_04.wav", 0.5f);
									this.KPILNBINPMN = null;
									goto IL_DB1;
								case 1U:
									this.KPILNBINPMN = null;
									FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
									goto IL_DB1;
								case 2U:
								case 3U:
									goto IL_DB1;
								case 4U:
									Debug.Log("Use!");
									GameInterface.getI.useWeapon = this.KPILNBINPMN;
									if (GameInterface.getI.useWeapon != null)
									{
										float num3 = GameInterface.getI.useWeapon.BDHHPAEHFHG.FPFMENFLGAA;
										if (num3 <= 1f)
										{
											num3 = 1f;
										}
										JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO(num3, 1, JNBICAJIJMM.LEBHCLDODNI("invn_rec15") + " " + GameInterface.getI.useWeapon.JPBOPFNPNHC(false) + " {0}", new ONKDCGNBALK.CMMHGMILOIM(this.ANILOGOGFEL), false);
										FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Cloth_05_00.wav", 0.5f);
									}
									this.KPILNBINPMN = null;
									goto IL_DB1;
								}
							}
							if (tag == 10L)
							{
								if (this.KPILNBINPMN == null)
								{
									return;
								}
								this.COKDFMFFDAE = this.KPILNBINPMN;
								this.MBDGHDLHKAJ(this.COKDFMFFDAE);
							}
						}
						else if (tag != 12L)
						{
							if (tag != 55L)
							{
								if (tag == 70L)
								{
									if (this.KPILNBINPMN == null)
									{
										return;
									}
									this.COKDFMFFDAE = this.KPILNBINPMN;
									this.KPILNBINPMN = null;
									ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(300f, 400f, JNBICAJIJMM.LEBHCLDODNI("invn_win1"), true);
									this.DJBELNNPCPO = onkdcgnbalk.LPFKFNLHGBI;
									LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 20f, 50f, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 22f, this.COKDFMFFDAE.JPBOPFNPNHC(false), TextAnchor.UpperCenter, Color.black);
									lcoljopgdll.LNDPBNODFPE = true;
									lcoljopgdll.DFIGKKMMIAF = 16;
									new KEPNAIFBDKF(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 28f, 70f, this.COKDFMFFDAE, 0);
									float num4 = 140f;
									LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(onkdcgnbalk, 20f, num4, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 22f, JNBICAJIJMM.LEBHCLDODNI("invn_rec22"), TextAnchor.UpperCenter, Color.black);
									lcoljopgdll2.LNDPBNODFPE = true;
									lcoljopgdll2.DFIGKKMMIAF = 16;
									num4 += 26f;
									num4 += 26f;
									foreach (IIBEEKCAAHK iibeekcaahk in this.COKDFMFFDAE.BDHHPAEHFHG.NEGPPBJIHAF)
									{
										BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(iibeekcaahk.IBEIBAHKIAH);
										int num5 = iibeekcaahk.ICJDPPOJINN;
										new OCLNJMKDBKB(onkdcgnbalk, 40f, num4, 32f, befchfngomi, 0);
										string arg2 = JNBICAJIJMM.LEBHCLDODNI("invn_ver1");
										if (iibeekcaahk.KGKNPAAMDJK < 100f)
										{
											arg2 = JNBICAJIJMM.LEBHCLDODNI("invn_ver2");
										}
										if (iibeekcaahk.KGKNPAAMDJK < 50f)
										{
											arg2 = JNBICAJIJMM.LEBHCLDODNI("invn_ver3");
										}
										if (iibeekcaahk.KGKNPAAMDJK < 25f)
										{
											arg2 = JNBICAJIJMM.LEBHCLDODNI("invn_ver4");
										}
										if (iibeekcaahk.KGKNPAAMDJK < 10f)
										{
											arg2 = JNBICAJIJMM.LEBHCLDODNI("invn_ver5");
										}
										if (iibeekcaahk.KGKNPAAMDJK < 1f)
										{
											arg2 = JNBICAJIJMM.LEBHCLDODNI("invn_ver6");
										}
										LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(onkdcgnbalk, 77f, num4 + 2f, string.Format(JNBICAJIJMM.LEBHCLDODNI("invn_rec23"), befchfngomi.JPBOPFNPNHC(false, -1), num5, arg2), true);
										lcoljopgdll3.LNDPBNODFPE = true;
										lcoljopgdll3.DFIGKKMMIAF = 14;
										num4 += 34f;
									}
									num4 += 26f;
									LCOLJOPGDLL lcoljopgdll4 = new LCOLJOPGDLL(onkdcgnbalk, 20f, num4, onkdcgnbalk.OCHCODJIPHJ.width - 40f, 40f, string.Format(JNBICAJIJMM.LEBHCLDODNI("invn_rec24"), 20, this.COKDFMFFDAE.ILFHHDNJHNM * 20, JBEHMPDDMME.IKGFHGKKCPG.JBJFBDONEFF), TextAnchor.UpperCenter, Color.black);
									lcoljopgdll4.LNDPBNODFPE = true;
									lcoljopgdll4.DFIGKKMMIAF = 12;
									this.NEGPPBJIHAF.Clear();
									new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 64f, onkdcgnbalk.OCHCODJIPHJ.height - 42f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("invn_rec25"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.IDPELCAAOFB));
									FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
								}
							}
							else
							{
								FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
								NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(230, this.KPILNBINPMN.LPFKFNLHGBI);
								this.KPILNBINPMN = null;
							}
						}
						else
						{
							if (this.KPILNBINPMN == null)
							{
								return;
							}
							this.COKDFMFFDAE = this.KPILNBINPMN;
							ONKDCGNBALK onkdcgnbalk2 = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(400f, 400f, JNBICAJIJMM.LEBHCLDODNI("invn_rec16"), true);
							this.ONGEHMJIMLO = onkdcgnbalk2.LPFKFNLHGBI;
							LCOLJOPGDLL lcoljopgdll5 = new LCOLJOPGDLL(onkdcgnbalk2, 20f, 50f, onkdcgnbalk2.OCHCODJIPHJ.width - 40f, 22f, this.COKDFMFFDAE.JPBOPFNPNHC(false), TextAnchor.UpperCenter, Color.black);
							lcoljopgdll5.LNDPBNODFPE = true;
							lcoljopgdll5.DFIGKKMMIAF = 16;
							new KEPNAIFBDKF(onkdcgnbalk2, onkdcgnbalk2.OCHCODJIPHJ.width / 2f - 28f, 70f, this.COKDFMFFDAE, 0);
							float num6 = 140f;
							LCOLJOPGDLL lcoljopgdll6 = new LCOLJOPGDLL(onkdcgnbalk2, 20f, num6, onkdcgnbalk2.OCHCODJIPHJ.width - 40f, 22f, JNBICAJIJMM.LEBHCLDODNI("invn_rec17"), TextAnchor.UpperCenter, Color.black);
							lcoljopgdll6.LNDPBNODFPE = true;
							lcoljopgdll6.DFIGKKMMIAF = 16;
							num6 += 26f;
							BEFCHFNGOMI befchfngomi2 = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(1230);
							int num7 = 1 + this.COKDFMFFDAE.KBGHOIJIPJF;
							new OCLNJMKDBKB(onkdcgnbalk2, 80f, num6, 32f, befchfngomi2, 0);
							LCOLJOPGDLL lcoljopgdll7 = new LCOLJOPGDLL(onkdcgnbalk2, 117f, num6 + 6f, befchfngomi2.JPBOPFNPNHC(false, -1) + " x" + num7, true);
							lcoljopgdll7.LNDPBNODFPE = true;
							lcoljopgdll7.DFIGKKMMIAF = 16;
							num6 += 39f;
							LCOLJOPGDLL lcoljopgdll8 = new LCOLJOPGDLL(onkdcgnbalk2, 20f, num6, onkdcgnbalk2.OCHCODJIPHJ.width - 40f, 22f, JNBICAJIJMM.LEBHCLDODNI("invn_rec18"), TextAnchor.UpperCenter, Color.black);
							lcoljopgdll8.LNDPBNODFPE = true;
							lcoljopgdll8.DFIGKKMMIAF = 16;
							num6 += 26f;
							List<IIBEEKCAAHK> list = this.KPILNBINPMN.BBLEPPMMPIL("wpn_add/base", "inner_craft_wpn").HDELBIDJNOK;
							int num8 = 0;
							foreach (IIBEEKCAAHK iibeekcaahk2 in list)
							{
								befchfngomi2 = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(iibeekcaahk2.IBEIBAHKIAH);
								int num9 = iibeekcaahk2.ICJDPPOJINN / 4;
								int num10 = iibeekcaahk2.ICJDPPOJINN / 2;
								if (num10 > 0)
								{
									num8++;
									new OCLNJMKDBKB(onkdcgnbalk2, 80f, num6, 32f, befchfngomi2, 0);
									LCOLJOPGDLL lcoljopgdll9 = new LCOLJOPGDLL(onkdcgnbalk2, 117f, num6 + 6f, string.Format(JNBICAJIJMM.LEBHCLDODNI("invn_rec19"), befchfngomi2.JPBOPFNPNHC(false, -1), num9, num10), true);
									lcoljopgdll9.LNDPBNODFPE = true;
									lcoljopgdll9.DFIGKKMMIAF = 16;
									num6 += 34f;
								}
							}
							if (num8 == 0)
							{
								num6 += 39f;
								LCOLJOPGDLL lcoljopgdll10 = new LCOLJOPGDLL(onkdcgnbalk2, 20f, num6, onkdcgnbalk2.OCHCODJIPHJ.width - 40f, 22f, JNBICAJIJMM.LEBHCLDODNI("invn_rec20"), TextAnchor.UpperCenter, Color.black);
								lcoljopgdll10.LNDPBNODFPE = true;
								lcoljopgdll10.DFIGKKMMIAF = 16;
							}
							new MEMEOHJKPNJ(onkdcgnbalk2, onkdcgnbalk2.OCHCODJIPHJ.width / 2f - 64f, onkdcgnbalk2.OCHCODJIPHJ.height - 42f, 128f, 24f, JNBICAJIJMM.LEBHCLDODNI("invn_rec21"), 6, null, new ONKDCGNBALK.CMMHGMILOIM(this.KLIDBFOPOMB));
							FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Cloth_05_00.wav", 0.5f);
							this.KPILNBINPMN = null;
						}
					}
					else if (tag <= 91L)
					{
						if (tag != 90L)
						{
							if (tag == 91L)
							{
								FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Cloth_05_00.wav", 0.5f);
								NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(315, this.KPILNBINPMN.LPFKFNLHGBI);
								this.MEOJOEJBNDI = this.KPILNBINPMN;
								this.KPILNBINPMN = null;
							}
						}
						else
						{
							FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Cloth_05_00.wav", 0.5f);
							NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(310, this.KPILNBINPMN.HHOLFABGDJA);
							this.MEOJOEJBNDI = this.KPILNBINPMN;
							this.KPILNBINPMN = null;
						}
					}
					else if (tag != 100L)
					{
						if (tag != 110L)
						{
							if (tag == 120L)
							{
								FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_04.wav", 1f);
								GameInterface.getI.useWeapon = this.KPILNBINPMN;
								if (GameInterface.getI.useWeapon != null)
								{
									JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO(2f, 1, JNBICAJIJMM.LEBHCLDODNI("invn_rec26") + " " + GameInterface.getI.useWeapon.JPBOPFNPNHC(false) + " {0}", new ONKDCGNBALK.CMMHGMILOIM(this.EEKPMBPJIMB), false);
								}
								this.KPILNBINPMN = null;
							}
						}
						else
						{
							if (this.KPILNBINPMN == null)
							{
								return;
							}
							ONKDCGNBALK onkdcgnbalk3 = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(500f, 300f, "Модификация предмета", true);
							EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk3, 20f, 40f, onkdcgnbalk3.OCHCODJIPHJ.width - 40f, onkdcgnbalk3.OCHCODJIPHJ.height - 95f, "", 0, null);
							this.EFIBDEMHFDD = new MMKFAENBHKD(onkdcgnbalk3, egcaadaabpp.OCHCODJIPHJ.x + egcaadaabpp.OCHCODJIPHJ.width - 300f - 10f, egcaadaabpp.OCHCODJIPHJ.y + 10f, 300f, egcaadaabpp.OCHCODJIPHJ.height - 20f, 0);
							this.EFIBDEMHFDD.JHNCNHAAJCH = 28f;
							new KEPNAIFBDKF(onkdcgnbalk3, egcaadaabpp.OCHCODJIPHJ.x + 30f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height / 2f - 28f, this.KPILNBINPMN, 0);
							new MEMEOHJKPNJ(onkdcgnbalk3, onkdcgnbalk3.OCHCODJIPHJ.width / 2f - 5f - 128f, onkdcgnbalk3.OCHCODJIPHJ.height - 45f, 128f, 24f, "Применить", 6, null, new ONKDCGNBALK.CMMHGMILOIM(this.MPICBGMIFGO));
							this.LBEHNCAGGAH = this.KPILNBINPMN.LPFKFNLHGBI;
							this.KPILNBINPMN = null;
							this.COKDFMFFDAE = null;
							FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_04.wav", 1f);
						}
					}
					else
					{
						FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_04.wav", 1f);
						GameInterface.getI.useWeapon = this.KPILNBINPMN;
						if (GameInterface.getI.useWeapon != null)
						{
							float num11 = GameInterface.getI.useWeapon.BBLEPPMMPIL("wpn_add/base", "usetime").PPAAACJOOGA;
							if (num11 <= 1f)
							{
								num11 = 1f;
							}
							JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO(num11, 1, JNBICAJIJMM.LEBHCLDODNI("invn_rec15") + " " + GameInterface.getI.useWeapon.JPBOPFNPNHC(false) + " {0}", new ONKDCGNBALK.CMMHGMILOIM(this.BGBNNPNHCEF), false);
							FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("food_draw.ogg", 1f);
						}
						this.KPILNBINPMN = null;
					}
				}
				IL_DB1:
				num += 26;
			}
		}
		GUI.enabled = true;
	}

	// Token: 0x06005248 RID: 21064 RVA: 0x0026B960 File Offset: 0x00269B60
	private void HJEJLBFMAJC(ONKDCGNBALK ONPHLHKAGFP)
	{
		if (this.COKDFMFFDAE != null)
		{
			Debug.Log("waitRefineOk!");
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(290, this.COKDFMFFDAE.LPFKFNLHGBI);
		}
	}

	// Token: 0x06005249 RID: 21065 RVA: 0x0026B990 File Offset: 0x00269B90
	public void JGLDGBHDLFG(ONKDCGNBALK ONPHLHKAGFP)
	{
		int bjppebpndnj = (int)ONPHLHKAGFP.ODFEKBJCFMN;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.OBCCLNMPGEJ(this.DBHJMNFNDDG.EENFJPJEDFM);
			epmphjgalbe.GOMLLPFFPNP(bjppebpndnj);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(348, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(ONPHLHKAGFP.OCBAOFLJBGP.LPFKFNLHGBI);
		epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.OBCCLNMPGEJ((long)this.KBKJNEFDCFO.BDHHPAEHFHG.LPFKFNLHGBI);
			epmphjgalbe.GOMLLPFFPNP(this.GHKNANODLOI);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(346, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("cash.ogg", 0.5f);
	}

	// Token: 0x0600524A RID: 21066 RVA: 0x0026BA70 File Offset: 0x00269C70
	public void FMINAKGAHLB(int APABMACIAOK, ONKDCGNBALK PHEMLBHMNCM, bool LNNOCAFJMAC = false)
	{
		if (LNNOCAFJMAC && BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() != null)
		{
			BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
			GUIStyle style = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleRight,
				wordWrap = false,
				richText = false,
				font = GuiProcessor.BBLINJLBAIL().rusfont,
				fontSize = -65
			};
			Rect position = new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width - 275f, PHEMLBHMNCM.OCHCODJIPHJ.y + 894f, 748f, 1856f);
			GUI.Label(position, string.Format(JNBICAJIJMM.BDKHMOOFHHK("Компонент\n"), bgjkmcbhnak.FOAAFGBHDAH), style);
			position.y += 1178f;
			double haajdghfica = (double)(Mathf.RoundToInt(bgjkmcbhnak.JJEFFBGECGL * 1738f) / 38);
			int num = Mathf.RoundToInt(bgjkmcbhnak.IGDMILBFAPF * 1968f) / -38;
			GUI.Label(position, string.Format(JNBICAJIJMM.LEBHCLDODNI("IdleDodgeLeft"), JLFJEGIPIMM.NNEAHAFBOHC().AHEHNKFHGOC(haajdghfica)), style);
			position.y += 158f;
		}
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		float num2 = PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.x;
		float num3 = PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.y + PHEMLBHMNCM.OCHCODJIPHJ.y;
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH;
		if (PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.width < 1478f)
		{
			return;
		}
		if (PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.width > 923f && LNNOCAFJMAC)
		{
			int num4 = (int)JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.MHIIBKILGBL("Backward Sitting Cheer");
			if (num4 == 0)
			{
				num4 = -65;
			}
			int num5 = num4 % 91;
			int num6 = (int)JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BIHLDHKHPKE(" r " + num5);
			string fggpeeghgmf = string.Format("'", num4);
			int num7 = (int)JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.MHIIBKILGBL(fggpeeghgmf);
			GUIStyle style2 = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperCenter,
				wordWrap = true,
				richText = false,
				font = GuiProcessor.BBLINJLBAIL().rusfont3,
				fontSize = -75
			};
			for (int i = 1; i < 1; i += 0)
			{
				string arg = "RunBackRight";
				if (i == num6)
				{
					arg = "Sitting Reading Coffee Sip";
				}
				if (i > num7)
				{
					GUI.enabled = false;
				}
				else
				{
					if (i == 0)
					{
						GUI.enabled = false;
					}
					string text = string.Format("none id=", arg, JLFJEGIPIMM.PKGMBFEMKGP().IEICGMEMPIK(i + 0));
					Rect position2 = new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width - 943f - 1301f, PHEMLBHMNCM.OCHCODJIPHJ.y + 1523f + (float)(i * -9), 806f, 175f);
					if (GUI.Button(position2, "Swim"))
					{
						FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("<b>Obscured types:</b>\n<color=\"#75C4EB\">", 630f);
						JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.FFLBHJPFGFK(num4, i);
						DownPanelLogic.getI.AFEMNJFFNCO(num4);
					}
					GUI.Label(position2, text, style2);
				}
			}
		}
		GUI.enabled = false;
		KBJGAFNMGCK.DCJIDJJKJCK dcjidjjkjck = KBJGAFNMGCK.EAJHPOJPPFA().NJELCEJFBBN(APABMACIAOK);
		foreach (KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb in dcjidjjkjck.JHFOAGALPOD)
		{
			Rect position3 = new Rect(ldjpekhhnhb.NBADAMPJBBH.CLAEAFMCDMP(), ldjpekhhnhb.NBADAMPJBBH.OAAKPMLGJJH(), 1188f, 84f);
			bool flag = false;
			Rect rect = new Rect(num2 + ldjpekhhnhb.NBADAMPJBBH.PHLLHDNNOMB(), num3 + ldjpekhhnhb.NBADAMPJBBH.OBEOJCGHOGL, 970f, 945f);
			if (rect.Contains(vector))
			{
				this.OJKBEDCFFND = ldjpekhhnhb.LPFKFNLHGBI;
				this.AMBNJGDIDED = dcjidjjkjck.LPFKFNLHGBI;
				this.DKFICLCPICL.x = vector.x - rect.x;
				this.DKFICLCPICL.y = vector.y - rect.y;
				this.ABLFGLMKPNO = false;
			}
			bool flag2 = true;
			if (!flag && this.KKLEEIBNIBC != null && ldjpekhhnhb.FBABFEDFMCH(this.KKLEEIBNIBC.BDHHPAEHFHG.MBKMKGABBGE))
			{
				GUI.DrawTexture(position3, GameInterface.getI.invEmptyCellSelect);
				flag2 = false;
			}
			if (flag2)
			{
				GUI.DrawTexture(position3, GameInterface.getI.invEmptyCell);
			}
			if (ldjpekhhnhb.OCEGMAKMPJB > 1)
			{
				GUI.DrawTextureWithTexCoords(position3, GameInterface.getI.cellsIcons, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(ldjpekhhnhb.OCEGMAKMPJB, 5, 8));
			}
		}
		foreach (EKBAPCMPANI ekbapcmpani in kfhelhglnmh.PLLHGAFIAFD.Values)
		{
			if (ekbapcmpani.JGNIDDBNGGP == APABMACIAOK)
			{
				KBJGAFNMGCK.LDJPEKHHNHB ldjpekhhnhb2 = dcjidjjkjck.GHFFJNCLLDK(ekbapcmpani.DMAMOPGJOCK);
				if (ldjpekhhnhb2 == null)
				{
					Debug.LogError("repair.ogg" + ekbapcmpani.DMAMOPGJOCK);
				}
				else
				{
					ekbapcmpani.PKOIFEBEOCP(new Vector2(ldjpekhhnhb2.NBADAMPJBBH.JLLJFKOGLHJ, ldjpekhhnhb2.NBADAMPJBBH.PDMNLDLGJNG()), 1648f);
				}
			}
		}
	}

	// Token: 0x0600524B RID: 21067 RVA: 0x0026C058 File Offset: 0x0026A258
	public void ABCHPMBIAMH(ONKDCGNBALK OJIMHKHFOJI)
	{
		Fisherman.getI.sendAction(2, 4f, Vector3.zero);
		for (int i = 1; i <= JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.IPPNBPONFHK; i++)
		{
			this.CPCHDFOFJIA[i].HKPAEGGJNGG = false;
		}
		if (OJIMHKHFOJI.ODFEKBJCFMN != (long)this.DJEOAABGBHH)
		{
			this.AICBIFFGBOH = Vector2.zero;
		}
		this.DJEOAABGBHH = (int)OJIMHKHFOJI.ODFEKBJCFMN;
		this.CPCHDFOFJIA[this.DJEOAABGBHH].HKPAEGGJNGG = true;
		this.OEADFAEEJJP.FPIHOPOCAHA = JNBICAJIJMM.IKGFHGKKCPG.OMNMDGIGEFD("BAG", "bag" + this.DJEOAABGBHH + "_info");
	}

	// Token: 0x0600524C RID: 21068 RVA: 0x0026C110 File Offset: 0x0026A310
	private void BHOJHJLINAK(ONKDCGNBALK ONPHLHKAGFP)
	{
		JDCEFOFMGHB.HMJJPNDEKPP().KCNBOHEMLCI(this.ONGEHMJIMLO);
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(168, this.COKDFMFFDAE.LPFKFNLHGBI);
	}

	// Token: 0x0600524D RID: 21069 RVA: 0x0026C13C File Offset: 0x0026A33C
	private void LCLCFPKANAH()
	{
		if (this.BBOKGAOOIMG == 0L)
		{
			this.BBOKGAOOIMG = 1L;
		}
		if (this.BBOKGAOOIMG > this.DCFMECEHGEM)
		{
			this.DCFMECEHGEM = this.BBOKGAOOIMG;
		}
		this.MPBHBNBJBLA.NBIEOFJEMKM(JLFJEGIPIMM.PKGMBFEMKGP().MNMIJFNPIPI(0L, this.BBOKGAOOIMG, false));
		if (this.MGPDHMPIEFB != null)
		{
			this.MGPDHMPIEFB.IBNDDDLHBML(JLFJEGIPIMM.PKGMBFEMKGP().MNMIJFNPIPI(0L, this.BBOKGAOOIMG * (long)this.MEOJOEJBNDI.ILFHHDNJHNM, false));
		}
		int num = 0 + Mathf.RoundToInt((float)(this.BBOKGAOOIMG * (long)this.MEOJOEJBNDI.ILFHHDNJHNM) * 57f);
		if (this.JJNNIDBAEKL != null)
		{
			this.JJNNIDBAEKL.LKGMDFCGOBG(JLFJEGIPIMM.IKGFHGKKCPG.MNMIJFNPIPI(1L, this.DCFMECEHGEM, false));
			num = 0 + Mathf.RoundToInt((float)(this.DCFMECEHGEM * (long)this.MEOJOEJBNDI.ILFHHDNJHNM) * 1027f);
		}
		if (this.HMJIHCHAEFN != null)
		{
			this.HMJIHCHAEFN.NBIEOFJEMKM(JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(1L, (long)num, false));
		}
	}

	// Token: 0x0600524E RID: 21070 RVA: 0x0026C250 File Offset: 0x0026A450
	private void IJHKJCKAIDB(ONKDCGNBALK ONPHLHKAGFP)
	{
		if (this.DMAAEAJMFOK != null)
		{
			this.DMAAEAJMFOK.FPIHOPOCAHA = JNBICAJIJMM.LEBHCLDODNI("inv_auksum") + " " + JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)(this.AIIHCNKNNID.LPBLKNELCLO * this.CAFFMFHCNAE), false);
		}
	}

	// Token: 0x0600524F RID: 21071 RVA: 0x0026C2A4 File Offset: 0x0026A4A4
	public bool KINAHOLLCGB(EKBAPCMPANI MEJMEKODJAE, int JGNIDDBNGGP, int IJMHJKHNOAC)
	{
		if (JGNIDDBNGGP < 50)
		{
			return true;
		}
		if (JGNIDDBNGGP == 52)
		{
			return true;
		}
		if (JGNIDDBNGGP == 51)
		{
			return true;
		}
		bool flag = KBJGAFNMGCK.IKGFHGKKCPG.GIEKGGIOLKM(JGNIDDBNGGP).GHFFJNCLLDK(IJMHJKHNOAC).OBGAGPMCPNK(MEJMEKODJAE.BDHHPAEHFHG.MBKMKGABBGE);
		if (MEJMEKODJAE.GOEGADLBGML > ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.CNOLCNDBLJE))
		{
			flag = false;
		}
		if (MEJMEKODJAE.BDHHPAEHFHG.MBOOFLANJID != 0)
		{
			if (MEJMEKODJAE.BDHHPAEHFHG.MBOOFLANJID == 1 && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GDJMBFGEMFJ != 1)
			{
				flag = false;
			}
			if (MEJMEKODJAE.BDHHPAEHFHG.MBOOFLANJID == 2 && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GDJMBFGEMFJ != 0)
			{
				flag = false;
			}
		}
		if (flag)
		{
			foreach (NLNNIDBPKAO.DLMGLIJDIAI dlmglijdiai in MEJMEKODJAE.PKIICJOILKI)
			{
				if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FFLOOHAEMIF(dlmglijdiai.LPFKFNLHGBI) < dlmglijdiai.CNOLCNDBLJE)
				{
					return false;
				}
			}
		}
		if (flag)
		{
			int num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KNNKJAEHDHF();
			if (JGNIDDBNGGP == num)
			{
				int num2 = 0;
				foreach (EKBAPCMPANI ekbapcmpani in JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PLLHGAFIAFD.Values)
				{
					if (ekbapcmpani.JGNIDDBNGGP == num && ekbapcmpani.BDHHPAEHFHG.GCLKLEIMABA > 0)
					{
						num2 = ekbapcmpani.BDHHPAEHFHG.GCLKLEIMABA;
						break;
					}
				}
				if (num2 > 0 && MEJMEKODJAE.BDHHPAEHFHG.GCLKLEIMABA > 0 && MEJMEKODJAE.BDHHPAEHFHG.GCLKLEIMABA != num2)
				{
					flag = false;
				}
			}
		}
		return flag;
	}

	// Token: 0x06005250 RID: 21072 RVA: 0x0026C480 File Offset: 0x0026A680
	public void KHPKOPHFDFB(HBPNMNGOFMA KADBECGIMPD)
	{
		Debug.Log("***Wpn Lots event ");
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
			int ilfhhdnjhnm = KADBECGIMPD.HDBGOLAFOBK();
			MDEKJCCIDIA.KCFIPOJDHGB kcfipojdhgb = new MDEKJCCIDIA.KCFIPOJDHGB();
			kcfipojdhgb.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.WeaponLot;
			kcfipojdhgb.ILFHHDNJHNM = ilfhhdnjhnm;
			kcfipojdhgb.BDHHPAEHFHG = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi);
			if (kcfipojdhgb.BDHHPAEHFHG != null)
			{
				kcfipojdhgb.BDHHPAEHFHG.JIFFLPNBILE();
				JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = this.AGDMAFCKMJP.MJMOMMKECMF((long)kcfipojdhgb.BDHHPAEHFHG.MBKMKGABBGE);
				if (fpaeeadmcie == null)
				{
					fpaeeadmcie = this.AGDMAFCKMJP.MJMOMMKECMF(0L);
				}
				fpaeeadmcie.LGMBHELCEEL(kcfipojdhgb, (long)kcfipojdhgb.BDHHPAEHFHG.LPFKFNLHGBI).AHFGACFMGEJ = new JNHLAGHJBAA.FPAEEADMCIE.COGMIMMKMME(this.IKABEPNBLOG);
			}
		}
	}

	// Token: 0x06005251 RID: 21073 RVA: 0x0026C53C File Offset: 0x0026A73C
	public void NENBEFDNCPO(ONKDCGNBALK OJIMHKHFOJI)
	{
		if (OJIMHKHFOJI.ODFEKBJCFMN == -83L)
		{
			JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.PBBBIFFPJBP(this.COKDFMFFDAE.LPFKFNLHGBI);
			this.IGPBJBNODII(this.COKDFMFFDAE.JGNIDDBNGGP, this.COKDFMFFDAE.DMAMOPGJOCK);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-43, this.COKDFMFFDAE.LPFKFNLHGBI);
			JDCEFOFMGHB.HMJJPNDEKPP().CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("val=", 1276f);
			return;
		}
		this.COKDFMFFDAE.BFHKBOPOFGB = true;
		JDCEFOFMGHB.HMJJPNDEKPP().KCNBOHEMLCI(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("money", 91f);
	}

	// Token: 0x06005252 RID: 21074 RVA: 0x0026C604 File Offset: 0x0026A804
	public void JNAIBMAEJPP(ONKDCGNBALK OJIMHKHFOJI)
	{
		if (OJIMHKHFOJI.ODFEKBJCFMN == 100L)
		{
			JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MGKFACGMAOD(this.COKDFMFFDAE.LPFKFNLHGBI);
			this.IGPBJBNODII(this.COKDFMFFDAE.JGNIDDBNGGP, this.COKDFMFFDAE.DMAMOPGJOCK);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(190, this.COKDFMFFDAE.LPFKFNLHGBI);
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("cut.ogg", 0.5f);
			return;
		}
		this.COKDFMFFDAE.BFHKBOPOFGB = false;
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_02.wav", 1f);
	}

	// Token: 0x06005253 RID: 21075 RVA: 0x0026C6CC File Offset: 0x0026A8CC
	public void CMHPCPPLPOO(ONKDCGNBALK ONPHLHKAGFP)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.OBJBHBFAFEE(this.COKDFMFFDAE.LPFKFNLHGBI);
			epmphjgalbe.ENDMKPCFKND(this.POHLPMPEOKO.PBMJIMLEHEC());
			NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(45, epmphjgalbe.IEJLLFECFHF());
		}
		finally
		{
			epmphjgalbe.BKKEFKANGIM();
		}
		JDCEFOFMGHB.HMJJPNDEKPP().CBHHEHHNFKL(this.ONGEHMJIMLO);
	}

	// Token: 0x06005254 RID: 21076 RVA: 0x0026C74C File Offset: 0x0026A94C
	public void DGMMBBEIMHI(EKBAPCMPANI MEJMEKODJAE)
	{
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(360f, 360f, MEJMEKODJAE.JPBOPFNPNHC(false), true);
		this.ELLIGFJNLGM = onkdcgnbalk.LPFKFNLHGBI;
		onkdcgnbalk.NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.ANAOANECGJG);
		this.EBKMEHACMJE = MEJMEKODJAE;
	}

	// Token: 0x06005255 RID: 21077 RVA: 0x0026C79C File Offset: 0x0026A99C
	public void DKPNCFJOKKJ(HBPNMNGOFMA KADBECGIMPD)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.ONGEHMJIMLO);
		this.DEFEALCKOKF = KADBECGIMPD.DNIIFBAIPBE();
		this.CDIFAABIAEG = KADBECGIMPD.FIFNOBGEKFF();
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("SpinReel.ogg", 1f);
		JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO(2f, 0, JNBICAJIJMM.LEBHCLDODNI("invn_rec5"), new ONKDCGNBALK.CMMHGMILOIM(this.FHLJDAENBFP), false);
	}

	// Token: 0x06005256 RID: 21078 RVA: 0x0026C80C File Offset: 0x0026AA0C
	private void IKABEPNBLOG(JNHLAGHJBAA.FPAEEADMCIE JEEEOEBNJDJ, ItemBase NLIKAGGPANH, Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
	{
		if (NLIKAGGPANH == null)
		{
			GUI.Label(COAGIAMOCIA, JEEEOEBNJDJ.ToString(), OFPNEDEAMAB);
			return;
		}
		MDEKJCCIDIA.KCFIPOJDHGB kcfipojdhgb = NLIKAGGPANH as MDEKJCCIDIA.KCFIPOJDHGB;
		switch (kcfipojdhgb.BDJGKIEBGCA)
		{
		case MDEKJCCIDIA.EIHOIMIOGKJ.ResLot:
			kcfipojdhgb.BDHHPAEHFHG.EJOBNFNDIHM(COAGIAMOCIA, OFPNEDEAMAB, " x" + kcfipojdhgb.ILFHHDNJHNM);
			return;
		case MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot:
			kcfipojdhgb.BDHHPAEHFHG.EJOBNFNDIHM(COAGIAMOCIA, OFPNEDEAMAB, " x" + kcfipojdhgb.ILFHHDNJHNM);
			return;
		case MDEKJCCIDIA.EIHOIMIOGKJ.WeaponLot:
		{
			BEFCHFNGOMI bdhhpaehfhg = kcfipojdhgb.BDHHPAEHFHG;
			Rect position = COAGIAMOCIA;
			position.y += 2f;
			position.height -= 4f;
			position.x += 2f;
			position.width -= 20f;
			GUI.Box(position, "");
			bdhhpaehfhg.EJOBNFNDIHM(COAGIAMOCIA, OFPNEDEAMAB, " x" + kcfipojdhgb.ILFHHDNJHNM);
			return;
		}
		case MDEKJCCIDIA.EIHOIMIOGKJ.MyWeaponLot:
			kcfipojdhgb.BDHHPAEHFHG.EJOBNFNDIHM(COAGIAMOCIA, OFPNEDEAMAB, " x" + kcfipojdhgb.ILFHHDNJHNM);
			return;
		default:
			return;
		}
	}

	// Token: 0x06005257 RID: 21079 RVA: 0x00022FCC File Offset: 0x000211CC
	public void CKJGPMHDJDD(HBPNMNGOFMA KADBECGIMPD)
	{
	}

	// Token: 0x06005258 RID: 21080 RVA: 0x0026C93C File Offset: 0x0026AB3C
	public void AIDIBIEDLMN(ONKDCGNBALK PHEMLBHMNCM)
	{
		new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		if (!this.ABLFGLMKPNO && !Input.GetMouseButton(1))
		{
			EKBAPCMPANI kkleeibnibc = this.KKLEEIBNIBC;
		}
		if (!this.ABLFGLMKPNO)
		{
			MDEKJCCIDIA.IKGFHGKKCPG.AMBNJGDIDED = 0;
			MDEKJCCIDIA.IKGFHGKKCPG.OJKBEDCFFND = -1;
		}
		this.FMINAKGAHLB(57, PHEMLBHMNCM, true);
		this.JBKMGGEGPCD(-66, PHEMLBHMNCM, true);
		this.JBKMGGEGPCD(-64, PHEMLBHMNCM, false);
		this.FMINAKGAHLB(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.KNNKJAEHDHF(), PHEMLBHMNCM, true);
	}

	// Token: 0x06005259 RID: 21081 RVA: 0x0026C9D4 File Offset: 0x0026ABD4
	public void IGPBJBNODII(int MNLJEKDCIMJ, int DMAMOPGJOCK)
	{
		if (MNLJEKDCIMJ == 60)
		{
			if (DMAMOPGJOCK == 1)
			{
				EKBAPCMPANI ekbapcmpani = this.EHHKCFOAKAI(60, 1);
				JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.AHBIPBIKKHM = ((ekbapcmpani != null) ? ekbapcmpani.HHOLFABGDJA : 0);
				if (Fisherman.getI != null)
				{
					Fisherman.getI.character.changeCap(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.AHBIPBIKKHM);
				}
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Cloth_07.wav", 0.7f);
				return;
			}
			if (DMAMOPGJOCK != 5)
			{
				if (DMAMOPGJOCK != 7)
				{
					return;
				}
				EKBAPCMPANI ekbapcmpani2 = this.EHHKCFOAKAI(60, 7);
				JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MAFHCKOECAN = ((ekbapcmpani2 != null) ? ekbapcmpani2.HHOLFABGDJA : 0);
				if (Fisherman.getI != null)
				{
					Fisherman.getI.character.changeCostume(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MAFHCKOECAN);
				}
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Cloth_01.wav", 0.7f);
			}
		}
	}

	// Token: 0x0600525A RID: 21082 RVA: 0x0026CAC4 File Offset: 0x0026ACC4
	public Vector2 MCENPOGEIAJ(int CLBPBJGLHEE)
	{
		float num = (float)(CLBPBJGLHEE % 9 * 58);
		int num2 = CLBPBJGLHEE / 9 * 58;
		return new Vector2(num, (float)num2);
	}

	// Token: 0x0600525B RID: 21083 RVA: 0x0026CAE8 File Offset: 0x0026ACE8
	public void CPMFLNPOFFO(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn == 1L)
		{
			int num = this.CMGJHIHGCNP.IDGBGCIIPNE();
			if (num < 1)
			{
				num = 1;
			}
			if (num > this.COKDFMFFDAE.ILFHHDNJHNM - 1)
			{
				num = this.COKDFMFFDAE.ILFHHDNJHNM - 0;
			}
			this.COKDFMFFDAE.ILFHHDNJHNM = this.COKDFMFFDAE.ILFHHDNJHNM - num;
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OBCCLNMPGEJ(this.COKDFMFFDAE.LPFKFNLHGBI);
				epmphjgalbe.GOMLLPFFPNP(num);
				epmphjgalbe.AEMAHNDEBKJ(this.IFHBHHBMNFK);
				epmphjgalbe.EIMEKHOFIEA(this.LMDDMCEJHOG);
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(83, epmphjgalbe.JOCJNOBBELJ());
			}
			finally
			{
				epmphjgalbe.PGLFHABMJPO();
			}
			this.COKDFMFFDAE.BFHKBOPOFGB = true;
			FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("\\", 1407f);
			JDCEFOFMGHB.IKGFHGKKCPG.DGFAPDDBHJB(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
			return;
		}
		if (odfekbjcfmn != 0L)
		{
			return;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("crft_to", 1344f);
		this.COKDFMFFDAE.BFHKBOPOFGB = true;
		JDCEFOFMGHB.MNJNNDHCDGG().KCNBOHEMLCI(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x0600525C RID: 21084 RVA: 0x0026CC24 File Offset: 0x0026AE24
	private void CMHGFDDMCAK()
	{
		if (this.BBOKGAOOIMG == 0L)
		{
			this.BBOKGAOOIMG = 1L;
		}
		if (this.BBOKGAOOIMG > this.DCFMECEHGEM)
		{
			this.DCFMECEHGEM = this.BBOKGAOOIMG;
		}
		this.MPBHBNBJBLA.FPIHOPOCAHA = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, this.BBOKGAOOIMG, false);
		if (this.MGPDHMPIEFB != null)
		{
			this.MGPDHMPIEFB.FPIHOPOCAHA = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, this.BBOKGAOOIMG * (long)this.MEOJOEJBNDI.ILFHHDNJHNM, false);
		}
		int num = 1 + Mathf.RoundToInt((float)(this.BBOKGAOOIMG * (long)this.MEOJOEJBNDI.ILFHHDNJHNM) * 0.03f);
		if (this.JJNNIDBAEKL != null)
		{
			this.JJNNIDBAEKL.FPIHOPOCAHA = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, this.DCFMECEHGEM, false);
			num = 1 + Mathf.RoundToInt((float)(this.DCFMECEHGEM * (long)this.MEOJOEJBNDI.ILFHHDNJHNM) * 0.03f);
		}
		if (this.HMJIHCHAEFN != null)
		{
			this.HMJIHCHAEFN.FPIHOPOCAHA = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)num, false);
		}
	}

	// Token: 0x0600525D RID: 21085 RVA: 0x0026CD38 File Offset: 0x0026AF38
	public void MHPBAGMMDAD()
	{
		if (JDCEFOFMGHB.IKGFHGKKCPG.MDBEKDJJHBI)
		{
			return;
		}
		if (this.KPILNBINPMN == null)
		{
			return;
		}
		GUI.skin = GuiProcessor.IKGFHGKKCPG.alterSkin;
		int num = JDCEFOFMGHB.IKGFHGKKCPG.DIBNCPKGGOF + 1;
		GUI.Window(num, this.MCMGPBDHCLN, new GUI.WindowFunction(this.GGDHIHEAEJG), JNBICAJIJMM.LEBHCLDODNI("invn_rec30"), GuiProcessor.IKGFHGKKCPG.alterSkin.GetStyle("Window"));
		GUI.BringWindowToFront(num);
		JDCEFOFMGHB.IKGFHGKKCPG.AFLEEHDFHMJ = num;
	}

	// Token: 0x0600525E RID: 21086 RVA: 0x0026CDC0 File Offset: 0x0026AFC0
	public void KCNKLPFDDDK(ONKDCGNBALK JMAKEAHMLMI)
	{
		if (this.OJKBEDCFFND < 0)
		{
			return;
		}
		this.KPILNBINPMN = this.EHHKCFOAKAI(this.AMBNJGDIDED, this.OJKBEDCFFND);
		if (this.KPILNBINPMN == null)
		{
			return;
		}
		bool isVisible = this.KPILNBINPMN.IMDLBJICHOE();
		this.EIPJCEDGFGM = new List<ItemBase>();
		if (this.KPILNBINPMN.DNOLHLJODNK && this.KPILNBINPMN.LNKLEIEFGCP < 15)
		{
			this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cntx_improve"))
			{
				tag = 55L
			});
		}
		if (this.KPILNBINPMN.BDHHPAEHFHG.KKOLKEEALFD)
		{
			this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cntx_refine"))
			{
				tag = 70L
			});
		}
		int mbkmkgabbge = this.KPILNBINPMN.BDHHPAEHFHG.MBKMKGABBGE;
		switch (mbkmkgabbge)
		{
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
			if ((this.KPILNBINPMN.BDHHPAEHFHG.FOAPCABBLBG || this.KPILNBINPMN.MJHGLLIJMIM) && (this.KPILNBINPMN.MJHGLLIJMIM || this.KPILNBINPMN.DLHPFGHOINI < (float)this.KPILNBINPMN.BGGJKOMAKEE))
			{
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cntx_rem"))
				{
					tag = 10L
				});
			}
			if (this.KPILNBINPMN.BBLEPPMMPIL("wpn_add/base", "inner_craft_wpn").HDELBIDJNOK.Count > 0)
			{
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cntx_razb"))
				{
					tag = 12L,
					isVisible = isVisible
				});
				goto IL_41B;
			}
			goto IL_41B;
		case 6:
		case 7:
		case 8:
		case 9:
			goto IL_41B;
		case 10:
			break;
		default:
			switch (mbkmkgabbge)
			{
			case 21:
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cntx_use"))
				{
					tag = 100L,
					isVisible = isVisible
				});
				goto IL_41B;
			case 22:
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cntx_use"))
				{
					tag = 100L,
					isVisible = isVisible
				});
				goto IL_41B;
			case 23:
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cntx_use"))
				{
					tag = 100L,
					isVisible = isVisible
				});
				goto IL_41B;
			case 24:
			case 25:
			case 26:
				break;
			case 27:
			case 30:
				if (this.KPILNBINPMN.BDHHPAEHFHG.HBHBAIONJHD)
				{
					this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cntx_use"))
					{
						tag = 5L,
						isVisible = isVisible
					});
					goto IL_41B;
				}
				goto IL_41B;
			case 28:
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cntx_teach"))
				{
					tag = 120L,
					isVisible = isVisible
				});
				goto IL_41B;
			case 29:
			case 31:
			case 32:
			case 33:
				goto IL_41B;
			case 34:
			{
				int num = this.KPILNBINPMN.BDHHPAEHFHG.MIMANMPNLPE.IBEIBAHKIAH;
				if (NLNNIDBPKAO.IKGFHGKKCPG.PKJMLDMLFCM(num) == null)
				{
					goto IL_41B;
				}
				if (!JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GADJFFGDCFA.ContainsKey(num))
				{
					this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cntx_teach"))
					{
						tag = 5L,
						isVisible = isVisible
					});
					goto IL_41B;
				}
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cntx_teachexp"))
				{
					tag = 5L,
					isVisible = isVisible
				});
				goto IL_41B;
			}
			default:
				goto IL_41B;
			}
			break;
		}
		if (this.KPILNBINPMN.BDHHPAEHFHG.DKFCKFJBNIM)
		{
			if (this.KPILNBINPMN.BDHHPAEHFHG.FOAPCABBLBG)
			{
				float num2 = this.KPILNBINPMN.DLHPFGHOINI + 0.01f;
				float num3 = (float)this.KPILNBINPMN.BGGJKOMAKEE;
			}
			if (this.KPILNBINPMN.ICOFLHIIBCP)
			{
			}
		}
		IL_41B:
		if (!this.KPILNBINPMN.ICOFLHIIBCP)
		{
			if (this.KPILNBINPMN.BDHHPAEHFHG.PKKLNODNCBE && !this.KPILNBINPMN.ICOFLHIIBCP)
			{
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cntx_wpnauk"))
				{
					tag = 91L
				});
			}
			if (this.KPILNBINPMN.BDHHPAEHFHG.DKFCKFJBNIM && !this.KPILNBINPMN.ICOFLHIIBCP)
			{
				this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cntx_resauk"))
				{
					tag = 90L
				});
			}
		}
		if (this.EIPJCEDGFGM.Count > 0)
		{
			this.EIPJCEDGFGM.Add(new ItemBase("")
			{
				tag = -1L
			});
		}
		this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cntx_drop"))
		{
			tag = 1L
		});
		this.EIPJCEDGFGM.Add(new ItemBase("")
		{
			tag = -1L
		});
		this.EIPJCEDGFGM.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cntx_close"))
		{
			tag = 2L
		});
		Vector2 vector = new Vector2(Input.mousePosition.x, (float)Screen.height - Input.mousePosition.y);
		Vector2 vector2 = new Vector2(vector.x + 15f, vector.y - 10f);
		if (vector2.x + 110f > (float)(Screen.width - 10))
		{
			vector2.x = (float)(Screen.width - 10 - 110);
		}
		if (vector2.y + 200f > (float)(Screen.height - 10))
		{
			vector2.y = (float)(Screen.height - 10 - 200);
		}
		this.MCMGPBDHCLN = new Rect(vector2.x, vector2.y, 160f, 28f + (float)this.EIPJCEDGFGM.Count * 26f);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
	}

	// Token: 0x0600525F RID: 21087 RVA: 0x0026D3FC File Offset: 0x0026B5FC
	public void KDJCCKCHAKD(int MNLJEKDCIMJ, int DMAMOPGJOCK)
	{
		if (MNLJEKDCIMJ == 56)
		{
			if (DMAMOPGJOCK == 1)
			{
				EKBAPCMPANI ekbapcmpani = this.KIFEKEONBOL(11, 0);
				JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.AHBIPBIKKHM = ((ekbapcmpani != null) ? ekbapcmpani.HHOLFABGDJA : 0);
				if (Fisherman.getI != null)
				{
					Fisherman.getI.character.BBGJHOMFBCG(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.AHBIPBIKKHM);
				}
				FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("Katana45DegSwing", 167f);
				return;
			}
			if (DMAMOPGJOCK != 1)
			{
				if (DMAMOPGJOCK != 2)
				{
					return;
				}
				EKBAPCMPANI ekbapcmpani2 = this.EJFELLJIACI(-61, 0);
				JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.MAFHCKOECAN = ((ekbapcmpani2 != null) ? ekbapcmpani2.HHOLFABGDJA : 1);
				if (Fisherman.getI != null)
				{
					Fisherman.getI.character.KHJMJMGFCME(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.MAFHCKOECAN);
				}
				FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("Rebirth", 1711f);
			}
		}
	}

	// Token: 0x04000C54 RID: 3156
	public const int KICOAAPJBGF = 50;

	// Token: 0x04000C55 RID: 3157
	public static MDEKJCCIDIA IKGFHGKKCPG = new MDEKJCCIDIA();

	// Token: 0x04000C56 RID: 3158
	public int DJEOAABGBHH = 1;

	// Token: 0x04000C57 RID: 3159
	private Vector2 AICBIFFGBOH = Vector2.zero;

	// Token: 0x04000C58 RID: 3160
	private readonly MEMEOHJKPNJ[] CPCHDFOFJIA = new MEMEOHJKPNJ[15];

	// Token: 0x04000C59 RID: 3161
	private LCOLJOPGDLL OEADFAEEJJP;

	// Token: 0x04000C5A RID: 3162
	public int OJKBEDCFFND = -1;

	// Token: 0x04000C5B RID: 3163
	public int AMBNJGDIDED;

	// Token: 0x04000C5C RID: 3164
	public EKBAPCMPANI KKLEEIBNIBC;

	// Token: 0x04000C5D RID: 3165
	public EKBAPCMPANI COKDFMFFDAE;

	// Token: 0x04000C5E RID: 3166
	public Vector2 GKKGCDPIPPL = Vector2.zero;

	// Token: 0x04000C5F RID: 3167
	public Vector2 DKFICLCPICL = Vector2.zero;

	// Token: 0x04000C60 RID: 3168
	private int DEKAMKHLFBM;

	// Token: 0x04000C61 RID: 3169
	public int NGKLLCCLFCM = -1;

	// Token: 0x04000C62 RID: 3170
	private Rect BMOHCPCBEBK;

	// Token: 0x04000C63 RID: 3171
	public float NDAAMOJNKMP;

	// Token: 0x04000C64 RID: 3172
	private long OCOMOGDADHE;

	// Token: 0x04000C65 RID: 3173
	private GHDNOAMIABN MBGAAPODHEO;

	// Token: 0x04000C66 RID: 3174
	public const int IAONDNBGFJA = 24;

	// Token: 0x04000C67 RID: 3175
	private int BMCALEBOBGN;

	// Token: 0x04000C68 RID: 3176
	private int GGHKEECHFCD;

	// Token: 0x04000C69 RID: 3177
	public int BLAEBOONADJ = 5;

	// Token: 0x04000C6A RID: 3178
	private const int KIPHALEDDKL = 9;

	// Token: 0x04000C6B RID: 3179
	private const int NGNPCGPHIHP = 52;

	// Token: 0x04000C6C RID: 3180
	private EKBAPCMPANI EBKMEHACMJE;

	// Token: 0x04000C6D RID: 3181
	private float GANOCEBJKJE = 280f;

	// Token: 0x04000C6E RID: 3182
	public bool IHNJOHJCBMK;

	// Token: 0x04000C6F RID: 3183
	public int ANBIJAKLCPC;

	// Token: 0x04000C70 RID: 3184
	public int CAFFMFHCNAE;

	// Token: 0x04000C71 RID: 3185
	public int CLIHOFJKEAL;

	// Token: 0x04000C72 RID: 3186
	private string FGPEPACCFIH = "";

	// Token: 0x04000C73 RID: 3187
	private List<MDEKJCCIDIA.KCFIPOJDHGB> DDKLFIHFFAO = new List<MDEKJCCIDIA.KCFIPOJDHGB>();

	// Token: 0x04000C74 RID: 3188
	private JNHLAGHJBAA AGDMAFCKMJP;

	// Token: 0x04000C75 RID: 3189
	private MDEKJCCIDIA.KCFIPOJDHGB KBKJNEFDCFO;

	// Token: 0x04000C76 RID: 3190
	private EGCAADAABPP ANNJBBJIJLC;

	// Token: 0x04000C77 RID: 3191
	private KJPFDOGHGOD AIIHCNKNNID;

	// Token: 0x04000C78 RID: 3192
	private LCOLJOPGDLL DMAAEAJMFOK;

	// Token: 0x04000C79 RID: 3193
	private int HEGMKNAMIHB;

	// Token: 0x04000C7A RID: 3194
	private MDEKJCCIDIA.KCFIPOJDHGB DBHJMNFNDDG;

	// Token: 0x04000C7B RID: 3195
	private int GHKNANODLOI;

	// Token: 0x04000C7C RID: 3196
	private int CMKDPADIMBO;

	// Token: 0x04000C7D RID: 3197
	private long BBOKGAOOIMG;

	// Token: 0x04000C7E RID: 3198
	private long DCFMECEHGEM;

	// Token: 0x04000C7F RID: 3199
	private LCOLJOPGDLL MPBHBNBJBLA;

	// Token: 0x04000C80 RID: 3200
	private LCOLJOPGDLL JJNNIDBAEKL;

	// Token: 0x04000C81 RID: 3201
	private LCOLJOPGDLL MGPDHMPIEFB;

	// Token: 0x04000C82 RID: 3202
	private LCOLJOPGDLL HMJIHCHAEFN;

	// Token: 0x04000C83 RID: 3203
	private GMNEKCBLIAN NEBLGPAOGGH;

	// Token: 0x04000C84 RID: 3204
	private LCOLJOPGDLL EMNCOCGHKKN;

	// Token: 0x04000C85 RID: 3205
	public int ONGEHMJIMLO = -1;

	// Token: 0x04000C86 RID: 3206
	public bool CDIFAABIAEG;

	// Token: 0x04000C87 RID: 3207
	public long DEFEALCKOKF;

	// Token: 0x04000C88 RID: 3208
	public const int DBIKJDCFFGI = 5;

	// Token: 0x04000C89 RID: 3209
	public float LKNFODKOPED;

	// Token: 0x04000C8A RID: 3210
	public int KNHAGPNAKIL;

	// Token: 0x04000C8B RID: 3211
	public int MBJANEBEGDF;

	// Token: 0x04000C8C RID: 3212
	public int OGDKMNAONFF = 10;

	// Token: 0x04000C8D RID: 3213
	public IIBEEKCAAHK POHLPMPEOKO;

	// Token: 0x04000C8E RID: 3214
	public GMNEKCBLIAN GJHKBPOOILO;

	// Token: 0x04000C8F RID: 3215
	public int DJBELNNPCPO;

	// Token: 0x04000C90 RID: 3216
	public List<IIBEEKCAAHK> NEGPPBJIHAF = new List<IIBEEKCAAHK>();

	// Token: 0x04000C91 RID: 3217
	private long LBEHNCAGGAH;

	// Token: 0x04000C92 RID: 3218
	private MMKFAENBHKD EFIBDEMHFDD;

	// Token: 0x04000C93 RID: 3219
	private Rect MCMGPBDHCLN;

	// Token: 0x04000C94 RID: 3220
	private bool JDFMHNPDDHJ;

	// Token: 0x04000C95 RID: 3221
	private int ELLIGFJNLGM = -1;

	// Token: 0x04000C96 RID: 3222
	private EKBAPCMPANI KPILNBINPMN;

	// Token: 0x04000C97 RID: 3223
	private EKBAPCMPANI MEOJOEJBNDI;

	// Token: 0x04000C98 RID: 3224
	private List<ItemBase> EIPJCEDGFGM = new List<ItemBase>();

	// Token: 0x04000C99 RID: 3225
	private KJPFDOGHGOD CMGJHIHGCNP;

	// Token: 0x04000C9A RID: 3226
	private int IFHBHHBMNFK;

	// Token: 0x04000C9B RID: 3227
	private int LMDDMCEJHOG;

	// Token: 0x04000C9C RID: 3228
	public bool ABLFGLMKPNO;

	// Token: 0x02000179 RID: 377
	public enum EIHOIMIOGKJ
	{
		// Token: 0x04000C9E RID: 3230
		ResLot,
		// Token: 0x04000C9F RID: 3231
		MyResLot,
		// Token: 0x04000CA0 RID: 3232
		WeaponLot,
		// Token: 0x04000CA1 RID: 3233
		MyWeaponLot
	}

	// Token: 0x0200017A RID: 378
	public class KCFIPOJDHGB : ItemBase
	{
		// Token: 0x06005260 RID: 21088 RVA: 0x0026D4EC File Offset: 0x0026B6EC
		public void KBPAIJIEHNF(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.JEFMHDJEEJC())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)7;
			this.EENFJPJEDFM = KADBECGIMPD.EJPMFEJBGMN();
			this.AONGINFINPD = KADBECGIMPD.PFKHMDDOHDN();
			this.KLKFECAJPNN = KADBECGIMPD.DMABDIGCLKA();
			this.JIFMHICCOJJ = KADBECGIMPD.HFOPFEJDJFG();
			this.JGNLJOJBAIB = KADBECGIMPD.IFDFHJLCHAE();
			this.HBIACFNHJEE = KADBECGIMPD.DCGEOFHNBCN();
			this.KAFDCOOEPID = KADBECGIMPD.HHMGLDMFCPF();
			this.FKEDAOOHPPB = KADBECGIMPD.ANPEIKGEDHJ();
			long lpfkfnlhgbi = KADBECGIMPD.DNIIFBAIPBE();
			int ilfhhdnjhnm = KADBECGIMPD.LDLKLPJBIJN();
			string clkmcahnhbm = KADBECGIMPD.PNBECHOLCJM();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CILBHAALIEF();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.EPCKOOOGNGK().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x0026D610 File Offset: 0x0026B810
		public void NBFEMLCPKKG(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.INLBHLOLOJH())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.ANPEIKGEDHJ();
			this.BDHHPAEHFHG = IHFEDJEMJMB.OELKEADDKPE().IMCJNFHAFGE(KADBECGIMPD.CLPEKGGAMAI());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.LDLKLPJBIJN();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.IFDFHJLCHAE();
			this.AONGINFINPD = KADBECGIMPD.MILGIGJBAJL();
		}

		// Token: 0x06005262 RID: 21090 RVA: 0x0026D688 File Offset: 0x0026B888
		public void APDCEKCGJAE(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.LILLHFLDMBH())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.WeaponLot;
			this.EENFJPJEDFM = KADBECGIMPD.KLHDFFHONON();
			this.AONGINFINPD = KADBECGIMPD.NIIFLPIEMFM();
			this.KLKFECAJPNN = KADBECGIMPD.IBKCNEICPEL();
			this.JIFMHICCOJJ = KADBECGIMPD.HHMGLDMFCPF();
			this.JGNLJOJBAIB = KADBECGIMPD.KDNDJNEGBDI();
			this.HBIACFNHJEE = KADBECGIMPD.IBKCNEICPEL();
			this.KAFDCOOEPID = KADBECGIMPD.HHMGLDMFCPF();
			this.FKEDAOOHPPB = KADBECGIMPD.IBKCNEICPEL();
			long lpfkfnlhgbi = KADBECGIMPD.DMABDIGCLKA();
			int ilfhhdnjhnm = KADBECGIMPD.IFDFHJLCHAE();
			string clkmcahnhbm = KADBECGIMPD.KDELAFDDGJH();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CILBHAALIEF();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.EPCKOOOGNGK().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
		}

		// Token: 0x06005263 RID: 21091 RVA: 0x0026D7AC File Offset: 0x0026B9AC
		public void CODIMEBFPML(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.INLBHLOLOJH())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.KLHDFFHONON();
			this.BDHHPAEHFHG = IHFEDJEMJMB.EDKKJNHDBPF().NKMGKJLONDK(KADBECGIMPD.IFDFHJLCHAE());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.HDBGOLAFOBK();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.HHLDBAEFNMJ();
			this.AONGINFINPD = KADBECGIMPD.NIIFLPIEMFM();
		}

		// Token: 0x06005264 RID: 21092 RVA: 0x0026D824 File Offset: 0x0026BA24
		public void NBHNPGCNDDI(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.HKBFCJDJCOB())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.IJDIMHAEAIE();
			this.BDHHPAEHFHG = IHFEDJEMJMB.OELKEADDKPE().IMCJNFHAFGE(KADBECGIMPD.IFDFHJLCHAE());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.IFDFHJLCHAE();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.HDBGOLAFOBK();
			this.AONGINFINPD = KADBECGIMPD.OODOKDPIMOF();
		}

		// Token: 0x06005265 RID: 21093 RVA: 0x0026D89C File Offset: 0x0026BA9C
		public void DCAOPMONKCA(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.BKIBKLFCCGP())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)4;
			this.EENFJPJEDFM = KADBECGIMPD.DMABDIGCLKA();
			this.AONGINFINPD = KADBECGIMPD.FCGGODFGMCB();
			this.KLKFECAJPNN = KADBECGIMPD.IBKCNEICPEL();
			this.JIFMHICCOJJ = KADBECGIMPD.HFOPFEJDJFG();
			this.JGNLJOJBAIB = KADBECGIMPD.CLPEKGGAMAI();
			this.HBIACFNHJEE = KADBECGIMPD.HFOPFEJDJFG();
			this.KAFDCOOEPID = KADBECGIMPD.DMABDIGCLKA();
			this.FKEDAOOHPPB = KADBECGIMPD.DNIIFBAIPBE();
			long lpfkfnlhgbi = KADBECGIMPD.DNIIFBAIPBE();
			int ilfhhdnjhnm = KADBECGIMPD.AGNKAFLKCAG();
			string clkmcahnhbm = KADBECGIMPD.LPKJHMGLCKA();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.KOJCECHBHLO().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x0026D9C0 File Offset: 0x0026BBC0
		public void DPFMAGCLBLF(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.KFKIFJDHCHB())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.IBKCNEICPEL();
			this.BDHHPAEHFHG = IHFEDJEMJMB.AGCBLDIBMNB().GBKMHIGNKJA(KADBECGIMPD.DOJKJHMJJNK());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.DOJKJHMJJNK();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.KDNDJNEGBDI();
			this.AONGINFINPD = KADBECGIMPD.OJNFAHFAKDO();
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x0026DA38 File Offset: 0x0026BC38
		public void KCKILOBLLOC(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.JCEGOADAOOI)
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.EJPMFEJBGMN();
			this.BDHHPAEHFHG = IHFEDJEMJMB.JHAAMBEFENP().LMGMPPAOPEP(KADBECGIMPD.LDLKLPJBIJN());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.HDBGOLAFOBK();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.AGNKAFLKCAG();
			this.AONGINFINPD = KADBECGIMPD.PFKHMDDOHDN();
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x0026DAB0 File Offset: 0x0026BCB0
		public void PJAAPAAJGJK(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.LILLHFLDMBH())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.IJDIMHAEAIE();
			this.BDHHPAEHFHG = IHFEDJEMJMB.JHAAMBEFENP().IMCJNFHAFGE(KADBECGIMPD.HHLDBAEFNMJ());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.IFDFHJLCHAE();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.DOJKJHMJJNK();
			this.AONGINFINPD = KADBECGIMPD.OJNFAHFAKDO();
		}

		// Token: 0x06005269 RID: 21097 RVA: 0x0026DB28 File Offset: 0x0026BD28
		public void FKNPDDECGOF(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.JCEGOADAOOI)
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)7;
			this.EENFJPJEDFM = KADBECGIMPD.IJDIMHAEAIE();
			this.AONGINFINPD = KADBECGIMPD.MLFLLBPGFIJ();
			this.KLKFECAJPNN = KADBECGIMPD.IJDIMHAEAIE();
			this.JIFMHICCOJJ = KADBECGIMPD.HFOPFEJDJFG();
			this.JGNLJOJBAIB = KADBECGIMPD.CLPEKGGAMAI();
			this.HBIACFNHJEE = KADBECGIMPD.DNIIFBAIPBE();
			this.KAFDCOOEPID = KADBECGIMPD.DMABDIGCLKA();
			this.FKEDAOOHPPB = KADBECGIMPD.DCGEOFHNBCN();
			long lpfkfnlhgbi = KADBECGIMPD.KLHDFFHONON();
			int ilfhhdnjhnm = KADBECGIMPD.KKOKFLMMAAK();
			string clkmcahnhbm = KADBECGIMPD.DHCMILPKJAL();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.BOBNPEAEECC().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x0026DC4C File Offset: 0x0026BE4C
		public void NGDMJNJPPBE(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.HKBFCJDJCOB())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.HHMGLDMFCPF();
			this.BDHHPAEHFHG = IHFEDJEMJMB.EDKKJNHDBPF().IMCJNFHAFGE(KADBECGIMPD.AGNKAFLKCAG());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.HHLDBAEFNMJ();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.KDNDJNEGBDI();
			this.AONGINFINPD = KADBECGIMPD.PFKHMDDOHDN();
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x0026DCC4 File Offset: 0x0026BEC4
		public void KBODFAHHOPC(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.DFLKBBNOGBG())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyWeaponLot;
			this.EENFJPJEDFM = KADBECGIMPD.ANPEIKGEDHJ();
			this.AONGINFINPD = KADBECGIMPD.FCGGODFGMCB();
			this.KLKFECAJPNN = KADBECGIMPD.HHMGLDMFCPF();
			this.JIFMHICCOJJ = KADBECGIMPD.HFOPFEJDJFG();
			this.JGNLJOJBAIB = KADBECGIMPD.DOJKJHMJJNK();
			this.HBIACFNHJEE = KADBECGIMPD.DCGEOFHNBCN();
			this.KAFDCOOEPID = KADBECGIMPD.IBKCNEICPEL();
			this.FKEDAOOHPPB = KADBECGIMPD.IJDIMHAEAIE();
			long lpfkfnlhgbi = KADBECGIMPD.ANPEIKGEDHJ();
			int ilfhhdnjhnm = KADBECGIMPD.KKOKFLMMAAK();
			string clkmcahnhbm = KADBECGIMPD.LPKJHMGLCKA();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.EPCKOOOGNGK().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JIFFLPNBILE();
			}
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x0026DDE8 File Offset: 0x0026BFE8
		public void PMJDCGPFFNH(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.ODIBHLOAGBC())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.IBKCNEICPEL();
			this.BDHHPAEHFHG = IHFEDJEMJMB.OELKEADDKPE().LMGMPPAOPEP(KADBECGIMPD.DOJKJHMJJNK());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.HDBGOLAFOBK();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.HDBGOLAFOBK();
			this.AONGINFINPD = KADBECGIMPD.HHAPCIKKNPB();
		}

		// Token: 0x0600526D RID: 21101 RVA: 0x0026DE60 File Offset: 0x0026C060
		public void IBCDGEBJOPE(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NLJJMKFBPBK())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)6;
			this.EENFJPJEDFM = KADBECGIMPD.DMABDIGCLKA();
			this.AONGINFINPD = KADBECGIMPD.OJNFAHFAKDO();
			this.KLKFECAJPNN = KADBECGIMPD.HHMGLDMFCPF();
			this.JIFMHICCOJJ = KADBECGIMPD.ANPEIKGEDHJ();
			this.JGNLJOJBAIB = KADBECGIMPD.DOJKJHMJJNK();
			this.HBIACFNHJEE = KADBECGIMPD.HFOPFEJDJFG();
			this.KAFDCOOEPID = KADBECGIMPD.IJDIMHAEAIE();
			this.FKEDAOOHPPB = KADBECGIMPD.DNIIFBAIPBE();
			long lpfkfnlhgbi = KADBECGIMPD.DCGEOFHNBCN();
			int ilfhhdnjhnm = KADBECGIMPD.CLPEKGGAMAI();
			string clkmcahnhbm = KADBECGIMPD.NCODBGMGNFD();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CILBHAALIEF();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.IKGFHGKKCPG.deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
		}

		// Token: 0x0600526E RID: 21102 RVA: 0x0026DF84 File Offset: 0x0026C184
		public void DJCFIJKAIMH(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.BKIBKLFCCGP())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.EJPMFEJBGMN();
			this.BDHHPAEHFHG = IHFEDJEMJMB.OOIJFNAMEDP().NKMGKJLONDK(KADBECGIMPD.AGNKAFLKCAG());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.CLPEKGGAMAI();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.DOJKJHMJJNK();
			this.AONGINFINPD = KADBECGIMPD.NIIFLPIEMFM();
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x0026DFFC File Offset: 0x0026C1FC
		public void NJAFFNGMFDM(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NLJJMKFBPBK())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.IJDIMHAEAIE();
			this.BDHHPAEHFHG = IHFEDJEMJMB.OELKEADDKPE().GBKMHIGNKJA(KADBECGIMPD.KKOKFLMMAAK());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.KKOKFLMMAAK();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.HDBGOLAFOBK();
			this.AONGINFINPD = KADBECGIMPD.OJNFAHFAKDO();
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x0026E074 File Offset: 0x0026C274
		public void DLCDDNFGIIF(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.IBMMOGHFCCE())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.EJPMFEJBGMN();
			this.AONGINFINPD = KADBECGIMPD.HGFHMFMNIEI();
			this.KLKFECAJPNN = KADBECGIMPD.IBKCNEICPEL();
			this.JIFMHICCOJJ = KADBECGIMPD.DMABDIGCLKA();
			this.JGNLJOJBAIB = KADBECGIMPD.LDLKLPJBIJN();
			this.HBIACFNHJEE = KADBECGIMPD.DCGEOFHNBCN();
			this.KAFDCOOEPID = KADBECGIMPD.HFOPFEJDJFG();
			this.FKEDAOOHPPB = KADBECGIMPD.IBKCNEICPEL();
			long lpfkfnlhgbi = KADBECGIMPD.IBKCNEICPEL();
			int ilfhhdnjhnm = KADBECGIMPD.HDBGOLAFOBK();
			string clkmcahnhbm = KADBECGIMPD.JJJJAGJCOGD();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.BOBNPEAEECC().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x0026E198 File Offset: 0x0026C398
		public void NFLIPPDCFPE(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.INLBHLOLOJH())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)8;
			this.EENFJPJEDFM = KADBECGIMPD.HFOPFEJDJFG();
			this.AONGINFINPD = KADBECGIMPD.NIIFLPIEMFM();
			this.KLKFECAJPNN = KADBECGIMPD.EJPMFEJBGMN();
			this.JIFMHICCOJJ = KADBECGIMPD.DNIIFBAIPBE();
			this.JGNLJOJBAIB = KADBECGIMPD.HDBGOLAFOBK();
			this.HBIACFNHJEE = KADBECGIMPD.DMABDIGCLKA();
			this.KAFDCOOEPID = KADBECGIMPD.HFOPFEJDJFG();
			this.FKEDAOOHPPB = KADBECGIMPD.IJDIMHAEAIE();
			long lpfkfnlhgbi = KADBECGIMPD.ANPEIKGEDHJ();
			int ilfhhdnjhnm = KADBECGIMPD.IFDFHJLCHAE();
			string clkmcahnhbm = KADBECGIMPD.BFPHBMDMODH();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CILBHAALIEF();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.EKEBHIJMEML().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x0026E2BC File Offset: 0x0026C4BC
		public void IPDMOOGEGDE(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.INLBHLOLOJH())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)7;
			this.EENFJPJEDFM = KADBECGIMPD.KLHDFFHONON();
			this.AONGINFINPD = KADBECGIMPD.OJNFAHFAKDO();
			this.KLKFECAJPNN = KADBECGIMPD.HFOPFEJDJFG();
			this.JIFMHICCOJJ = KADBECGIMPD.IJDIMHAEAIE();
			this.JGNLJOJBAIB = KADBECGIMPD.KKOKFLMMAAK();
			this.HBIACFNHJEE = KADBECGIMPD.DMABDIGCLKA();
			this.KAFDCOOEPID = KADBECGIMPD.IJDIMHAEAIE();
			this.FKEDAOOHPPB = KADBECGIMPD.DCGEOFHNBCN();
			long lpfkfnlhgbi = KADBECGIMPD.ANPEIKGEDHJ();
			int ilfhhdnjhnm = KADBECGIMPD.HDBGOLAFOBK();
			string clkmcahnhbm = KADBECGIMPD.FDIDEGHPJPF();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.KOJCECHBHLO().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JIFFLPNBILE();
			}
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x0026E3E0 File Offset: 0x0026C5E0
		public void KNJGCKNMABI(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.JCEGOADAOOI)
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.ANPEIKGEDHJ();
			this.BDHHPAEHFHG = IHFEDJEMJMB.OELKEADDKPE().GBKMHIGNKJA(KADBECGIMPD.DOJKJHMJJNK());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JIFFLPNBILE();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.HDBGOLAFOBK();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.AGNKAFLKCAG();
			this.AONGINFINPD = KADBECGIMPD.HGFHMFMNIEI();
		}

		// Token: 0x06005274 RID: 21108 RVA: 0x0026E458 File Offset: 0x0026C658
		public void EDOPPFCAAPM(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NNOJEFMEGEG())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)4;
			this.EENFJPJEDFM = KADBECGIMPD.DMABDIGCLKA();
			this.AONGINFINPD = KADBECGIMPD.HHAPCIKKNPB();
			this.KLKFECAJPNN = KADBECGIMPD.KLHDFFHONON();
			this.JIFMHICCOJJ = KADBECGIMPD.HFOPFEJDJFG();
			this.JGNLJOJBAIB = KADBECGIMPD.DOJKJHMJJNK();
			this.HBIACFNHJEE = KADBECGIMPD.HHMGLDMFCPF();
			this.KAFDCOOEPID = KADBECGIMPD.DMABDIGCLKA();
			this.FKEDAOOHPPB = KADBECGIMPD.DNIIFBAIPBE();
			long lpfkfnlhgbi = KADBECGIMPD.IJDIMHAEAIE();
			int ilfhhdnjhnm = KADBECGIMPD.HHLDBAEFNMJ();
			string clkmcahnhbm = KADBECGIMPD.BFPHBMDMODH();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.EKEBHIJMEML().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
		}

		// Token: 0x06005275 RID: 21109 RVA: 0x0026E57C File Offset: 0x0026C77C
		public void OBJNPJPLDMO(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NNOJEFMEGEG())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.DNIIFBAIPBE();
			this.AONGINFINPD = KADBECGIMPD.OJNFAHFAKDO();
			this.KLKFECAJPNN = KADBECGIMPD.HFOPFEJDJFG();
			this.JIFMHICCOJJ = KADBECGIMPD.KLHDFFHONON();
			this.JGNLJOJBAIB = KADBECGIMPD.DOJKJHMJJNK();
			this.HBIACFNHJEE = KADBECGIMPD.DCGEOFHNBCN();
			this.KAFDCOOEPID = KADBECGIMPD.ANPEIKGEDHJ();
			this.FKEDAOOHPPB = KADBECGIMPD.DCGEOFHNBCN();
			long lpfkfnlhgbi = KADBECGIMPD.DNIIFBAIPBE();
			int ilfhhdnjhnm = KADBECGIMPD.HHLDBAEFNMJ();
			string clkmcahnhbm = KADBECGIMPD.BFPHBMDMODH();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.EPCKOOOGNGK().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
		}

		// Token: 0x06005276 RID: 21110 RVA: 0x0026E6A0 File Offset: 0x0026C8A0
		public void BLINOFIGNNA(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.LILLHFLDMBH())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)5;
			this.EENFJPJEDFM = KADBECGIMPD.ANPEIKGEDHJ();
			this.AONGINFINPD = KADBECGIMPD.HHAPCIKKNPB();
			this.KLKFECAJPNN = KADBECGIMPD.EJPMFEJBGMN();
			this.JIFMHICCOJJ = KADBECGIMPD.HFOPFEJDJFG();
			this.JGNLJOJBAIB = KADBECGIMPD.KKOKFLMMAAK();
			this.HBIACFNHJEE = KADBECGIMPD.IJDIMHAEAIE();
			this.KAFDCOOEPID = KADBECGIMPD.KLHDFFHONON();
			this.FKEDAOOHPPB = KADBECGIMPD.HHMGLDMFCPF();
			long lpfkfnlhgbi = KADBECGIMPD.HFOPFEJDJFG();
			int ilfhhdnjhnm = KADBECGIMPD.CLPEKGGAMAI();
			string clkmcahnhbm = KADBECGIMPD.FDIDEGHPJPF();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CILBHAALIEF();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.EPCKOOOGNGK().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x0026E7C4 File Offset: 0x0026C9C4
		public void LGLAONOLEGB(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.DFLKBBNOGBG())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)5;
			this.EENFJPJEDFM = KADBECGIMPD.DNIIFBAIPBE();
			this.AONGINFINPD = KADBECGIMPD.OODOKDPIMOF();
			this.KLKFECAJPNN = KADBECGIMPD.EJPMFEJBGMN();
			this.JIFMHICCOJJ = KADBECGIMPD.DMABDIGCLKA();
			this.JGNLJOJBAIB = KADBECGIMPD.CLPEKGGAMAI();
			this.HBIACFNHJEE = KADBECGIMPD.DNIIFBAIPBE();
			this.KAFDCOOEPID = KADBECGIMPD.DNIIFBAIPBE();
			this.FKEDAOOHPPB = KADBECGIMPD.EJPMFEJBGMN();
			long lpfkfnlhgbi = KADBECGIMPD.ANPEIKGEDHJ();
			int ilfhhdnjhnm = KADBECGIMPD.HHLDBAEFNMJ();
			string clkmcahnhbm = KADBECGIMPD.DPLAJNEDGBL();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.KOJCECHBHLO().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
		}

		// Token: 0x06005278 RID: 21112 RVA: 0x0026E8E8 File Offset: 0x0026CAE8
		public void DGFELPFKBCB(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NNOJEFMEGEG())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)8;
			this.EENFJPJEDFM = KADBECGIMPD.IBKCNEICPEL();
			this.AONGINFINPD = KADBECGIMPD.PFKHMDDOHDN();
			this.KLKFECAJPNN = KADBECGIMPD.IJDIMHAEAIE();
			this.JIFMHICCOJJ = KADBECGIMPD.IJDIMHAEAIE();
			this.JGNLJOJBAIB = KADBECGIMPD.KDNDJNEGBDI();
			this.HBIACFNHJEE = KADBECGIMPD.HHMGLDMFCPF();
			this.KAFDCOOEPID = KADBECGIMPD.HHMGLDMFCPF();
			this.FKEDAOOHPPB = KADBECGIMPD.EJPMFEJBGMN();
			long lpfkfnlhgbi = KADBECGIMPD.IJDIMHAEAIE();
			int ilfhhdnjhnm = KADBECGIMPD.HHLDBAEFNMJ();
			string clkmcahnhbm = KADBECGIMPD.DPLAJNEDGBL();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.IKGFHGKKCPG.deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
		}

		// Token: 0x06005279 RID: 21113 RVA: 0x0026EA0C File Offset: 0x0026CC0C
		public void HIAAJNEEPLJ(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NNOJEFMEGEG())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)7;
			this.EENFJPJEDFM = KADBECGIMPD.DMABDIGCLKA();
			this.AONGINFINPD = KADBECGIMPD.FCGGODFGMCB();
			this.KLKFECAJPNN = KADBECGIMPD.HFOPFEJDJFG();
			this.JIFMHICCOJJ = KADBECGIMPD.DCGEOFHNBCN();
			this.JGNLJOJBAIB = KADBECGIMPD.IFDFHJLCHAE();
			this.HBIACFNHJEE = KADBECGIMPD.EJPMFEJBGMN();
			this.KAFDCOOEPID = KADBECGIMPD.DCGEOFHNBCN();
			this.FKEDAOOHPPB = KADBECGIMPD.HHMGLDMFCPF();
			long lpfkfnlhgbi = KADBECGIMPD.DMABDIGCLKA();
			int ilfhhdnjhnm = KADBECGIMPD.CLPEKGGAMAI();
			string clkmcahnhbm = KADBECGIMPD.JJJJAGJCOGD();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CILBHAALIEF();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.IKGFHGKKCPG.deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
		}

		// Token: 0x0600527A RID: 21114 RVA: 0x0026EB30 File Offset: 0x0026CD30
		public void HHBAGPLCKLD(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NNOJEFMEGEG())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.DMABDIGCLKA();
			this.BDHHPAEHFHG = IHFEDJEMJMB.AGCBLDIBMNB().GBKMHIGNKJA(KADBECGIMPD.HDBGOLAFOBK());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.LDLKLPJBIJN();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.DOJKJHMJJNK();
			this.AONGINFINPD = KADBECGIMPD.PFKHMDDOHDN();
		}

		// Token: 0x0600527B RID: 21115 RVA: 0x0026EBA8 File Offset: 0x0026CDA8
		public void LILDLOCIAIG(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.JEFMHDJEEJC())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.HHMGLDMFCPF();
			this.BDHHPAEHFHG = IHFEDJEMJMB.OELKEADDKPE().NKMGKJLONDK(KADBECGIMPD.DOJKJHMJJNK());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JIFFLPNBILE();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.KDNDJNEGBDI();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.HHLDBAEFNMJ();
			this.AONGINFINPD = KADBECGIMPD.HGFHMFMNIEI();
		}

		// Token: 0x0600527C RID: 21116 RVA: 0x0026EC20 File Offset: 0x0026CE20
		public void KAAJFKIDMAI(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.KFKIFJDHCHB())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)7;
			this.EENFJPJEDFM = KADBECGIMPD.IJDIMHAEAIE();
			this.AONGINFINPD = KADBECGIMPD.OJNFAHFAKDO();
			this.KLKFECAJPNN = KADBECGIMPD.KLHDFFHONON();
			this.JIFMHICCOJJ = KADBECGIMPD.DNIIFBAIPBE();
			this.JGNLJOJBAIB = KADBECGIMPD.DOJKJHMJJNK();
			this.HBIACFNHJEE = KADBECGIMPD.IBKCNEICPEL();
			this.KAFDCOOEPID = KADBECGIMPD.KLHDFFHONON();
			this.FKEDAOOHPPB = KADBECGIMPD.DMABDIGCLKA();
			long lpfkfnlhgbi = KADBECGIMPD.ANPEIKGEDHJ();
			int ilfhhdnjhnm = KADBECGIMPD.IFDFHJLCHAE();
			string clkmcahnhbm = KADBECGIMPD.DHCMILPKJAL();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.BOBNPEAEECC().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x0026ED44 File Offset: 0x0026CF44
		public void JJEDNAEDBEA(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NLJJMKFBPBK())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.EJPMFEJBGMN();
			this.BDHHPAEHFHG = IHFEDJEMJMB.OELKEADDKPE().GBKMHIGNKJA(KADBECGIMPD.AGNKAFLKCAG());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.DOJKJHMJJNK();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.IFDFHJLCHAE();
			this.AONGINFINPD = KADBECGIMPD.FCGGODFGMCB();
		}

		// Token: 0x0600527E RID: 21118 RVA: 0x0026EDBC File Offset: 0x0026CFBC
		public void GJHHGOOFPEF(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.LILLHFLDMBH())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.KLHDFFHONON();
			this.BDHHPAEHFHG = IHFEDJEMJMB.OOIJFNAMEDP().GBKMHIGNKJA(KADBECGIMPD.CLPEKGGAMAI());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.KDNDJNEGBDI();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.CLPEKGGAMAI();
			this.AONGINFINPD = KADBECGIMPD.IKJAOHGGCJD();
		}

		// Token: 0x0600527F RID: 21119 RVA: 0x0026EE34 File Offset: 0x0026D034
		public void JFBCECCFLGN(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.JCEGOADAOOI)
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.DNIIFBAIPBE();
			this.BDHHPAEHFHG = IHFEDJEMJMB.AGCBLDIBMNB().IMCJNFHAFGE(KADBECGIMPD.HDBGOLAFOBK());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.DOJKJHMJJNK();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.LDLKLPJBIJN();
			this.AONGINFINPD = KADBECGIMPD.NIIFLPIEMFM();
		}

		// Token: 0x06005280 RID: 21120 RVA: 0x0026EEAC File Offset: 0x0026D0AC
		public void PELKHOBKEGE(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NGIGCKBKLGK())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.EJPMFEJBGMN();
			this.AONGINFINPD = KADBECGIMPD.FCGGODFGMCB();
			this.KLKFECAJPNN = KADBECGIMPD.IJDIMHAEAIE();
			this.JIFMHICCOJJ = KADBECGIMPD.DCGEOFHNBCN();
			this.JGNLJOJBAIB = KADBECGIMPD.CLPEKGGAMAI();
			this.HBIACFNHJEE = KADBECGIMPD.DMABDIGCLKA();
			this.KAFDCOOEPID = KADBECGIMPD.EJPMFEJBGMN();
			this.FKEDAOOHPPB = KADBECGIMPD.IBKCNEICPEL();
			long lpfkfnlhgbi = KADBECGIMPD.IJDIMHAEAIE();
			int ilfhhdnjhnm = KADBECGIMPD.IFDFHJLCHAE();
			string clkmcahnhbm = KADBECGIMPD.DPLAJNEDGBL();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CILBHAALIEF();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.EPCKOOOGNGK().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JIFFLPNBILE();
			}
		}

		// Token: 0x06005281 RID: 21121 RVA: 0x0026EFD0 File Offset: 0x0026D1D0
		public void JOBPDOKDLJF(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.KFKIFJDHCHB())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.DMABDIGCLKA();
			this.BDHHPAEHFHG = IHFEDJEMJMB.OOIJFNAMEDP().LMGMPPAOPEP(KADBECGIMPD.KKOKFLMMAAK());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.IFDFHJLCHAE();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.KDNDJNEGBDI();
			this.AONGINFINPD = KADBECGIMPD.IKJAOHGGCJD();
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x0026F048 File Offset: 0x0026D248
		public void DNIOCBKLMCA(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NLJJMKFBPBK())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)5;
			this.EENFJPJEDFM = KADBECGIMPD.DNIIFBAIPBE();
			this.AONGINFINPD = KADBECGIMPD.HGFHMFMNIEI();
			this.KLKFECAJPNN = KADBECGIMPD.ANPEIKGEDHJ();
			this.JIFMHICCOJJ = KADBECGIMPD.IBKCNEICPEL();
			this.JGNLJOJBAIB = KADBECGIMPD.CLPEKGGAMAI();
			this.HBIACFNHJEE = KADBECGIMPD.IJDIMHAEAIE();
			this.KAFDCOOEPID = KADBECGIMPD.HFOPFEJDJFG();
			this.FKEDAOOHPPB = KADBECGIMPD.IJDIMHAEAIE();
			long lpfkfnlhgbi = KADBECGIMPD.EJPMFEJBGMN();
			int ilfhhdnjhnm = KADBECGIMPD.KDNDJNEGBDI();
			string clkmcahnhbm = KADBECGIMPD.LPKJHMGLCKA();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CILBHAALIEF();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.EPCKOOOGNGK().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
		}

		// Token: 0x06005283 RID: 21123 RVA: 0x0026F16C File Offset: 0x0026D36C
		public void CDMOJLMKNDJ(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.BKIBKLFCCGP())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.DCGEOFHNBCN();
			this.BDHHPAEHFHG = IHFEDJEMJMB.IKGFHGKKCPG.LMGMPPAOPEP(KADBECGIMPD.IFDFHJLCHAE());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.KKOKFLMMAAK();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.CLPEKGGAMAI();
			this.AONGINFINPD = KADBECGIMPD.OJNFAHFAKDO();
		}

		// Token: 0x06005284 RID: 21124 RVA: 0x0026F1E4 File Offset: 0x0026D3E4
		public void CHGKIKCDJEM(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.IBMMOGHFCCE())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.IBKCNEICPEL();
			this.BDHHPAEHFHG = IHFEDJEMJMB.JHAAMBEFENP().LMGMPPAOPEP(KADBECGIMPD.AGNKAFLKCAG());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.LDLKLPJBIJN();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.LDLKLPJBIJN();
			this.AONGINFINPD = KADBECGIMPD.PFKHMDDOHDN();
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x0026F25C File Offset: 0x0026D45C
		public void IEBLNNILILN(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.ODIBHLOAGBC())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)5;
			this.EENFJPJEDFM = KADBECGIMPD.DNIIFBAIPBE();
			this.AONGINFINPD = KADBECGIMPD.IKJAOHGGCJD();
			this.KLKFECAJPNN = KADBECGIMPD.DMABDIGCLKA();
			this.JIFMHICCOJJ = KADBECGIMPD.EJPMFEJBGMN();
			this.JGNLJOJBAIB = KADBECGIMPD.KDNDJNEGBDI();
			this.HBIACFNHJEE = KADBECGIMPD.HHMGLDMFCPF();
			this.KAFDCOOEPID = KADBECGIMPD.DMABDIGCLKA();
			this.FKEDAOOHPPB = KADBECGIMPD.DNIIFBAIPBE();
			long lpfkfnlhgbi = KADBECGIMPD.IJDIMHAEAIE();
			int ilfhhdnjhnm = KADBECGIMPD.AGNKAFLKCAG();
			string clkmcahnhbm = KADBECGIMPD.LPKJHMGLCKA();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CILBHAALIEF();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.KOJCECHBHLO().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
		}

		// Token: 0x06005286 RID: 21126 RVA: 0x0026F380 File Offset: 0x0026D580
		public void ILLPFEOGPHA(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NLJJMKFBPBK())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.HHMGLDMFCPF();
			this.BDHHPAEHFHG = IHFEDJEMJMB.NNEAHAFBOHC().GBKMHIGNKJA(KADBECGIMPD.IFDFHJLCHAE());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.LDLKLPJBIJN();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.HHLDBAEFNMJ();
			this.AONGINFINPD = KADBECGIMPD.OJNFAHFAKDO();
		}

		// Token: 0x06005287 RID: 21127 RVA: 0x0026F3F8 File Offset: 0x0026D5F8
		public void BPCOHOAGCAN(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.DFLKBBNOGBG())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.IJDIMHAEAIE();
			this.BDHHPAEHFHG = IHFEDJEMJMB.JHAAMBEFENP().NKMGKJLONDK(KADBECGIMPD.HHLDBAEFNMJ());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.HHLDBAEFNMJ();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.HDBGOLAFOBK();
			this.AONGINFINPD = KADBECGIMPD.MILGIGJBAJL();
		}

		// Token: 0x06005288 RID: 21128 RVA: 0x0026F470 File Offset: 0x0026D670
		public void ADIJMBCLFMP(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NLJJMKFBPBK())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)6;
			this.EENFJPJEDFM = KADBECGIMPD.DMABDIGCLKA();
			this.AONGINFINPD = KADBECGIMPD.HHAPCIKKNPB();
			this.KLKFECAJPNN = KADBECGIMPD.DNIIFBAIPBE();
			this.JIFMHICCOJJ = KADBECGIMPD.ANPEIKGEDHJ();
			this.JGNLJOJBAIB = KADBECGIMPD.IFDFHJLCHAE();
			this.HBIACFNHJEE = KADBECGIMPD.KLHDFFHONON();
			this.KAFDCOOEPID = KADBECGIMPD.HHMGLDMFCPF();
			this.FKEDAOOHPPB = KADBECGIMPD.DCGEOFHNBCN();
			long lpfkfnlhgbi = KADBECGIMPD.EJPMFEJBGMN();
			int ilfhhdnjhnm = KADBECGIMPD.DOJKJHMJJNK();
			string clkmcahnhbm = KADBECGIMPD.DHCMILPKJAL();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.KOJCECHBHLO().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
		}

		// Token: 0x06005289 RID: 21129 RVA: 0x0026F594 File Offset: 0x0026D794
		public void IPNODCMDOKD(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.PPAHBNGECGH())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.DNIIFBAIPBE();
			this.BDHHPAEHFHG = IHFEDJEMJMB.IKGFHGKKCPG.NKMGKJLONDK(KADBECGIMPD.DOJKJHMJJNK());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.KDNDJNEGBDI();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.HHLDBAEFNMJ();
			this.AONGINFINPD = KADBECGIMPD.MLFLLBPGFIJ();
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x0026F60C File Offset: 0x0026D80C
		public void MIEGGLJGLDJ(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.LILLHFLDMBH())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.HFOPFEJDJFG();
			this.BDHHPAEHFHG = IHFEDJEMJMB.OELKEADDKPE().IMCJNFHAFGE(KADBECGIMPD.IFDFHJLCHAE());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.IFDFHJLCHAE();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.CLPEKGGAMAI();
			this.AONGINFINPD = KADBECGIMPD.HHAPCIKKNPB();
		}

		// Token: 0x0600528C RID: 21132 RVA: 0x0026F684 File Offset: 0x0026D884
		public void EBGKACOAEOA(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NNOJEFMEGEG())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyWeaponLot;
			this.EENFJPJEDFM = KADBECGIMPD.IJDIMHAEAIE();
			this.AONGINFINPD = KADBECGIMPD.HHAPCIKKNPB();
			this.KLKFECAJPNN = KADBECGIMPD.KLHDFFHONON();
			this.JIFMHICCOJJ = KADBECGIMPD.EJPMFEJBGMN();
			this.JGNLJOJBAIB = KADBECGIMPD.HHLDBAEFNMJ();
			this.HBIACFNHJEE = KADBECGIMPD.ANPEIKGEDHJ();
			this.KAFDCOOEPID = KADBECGIMPD.IBKCNEICPEL();
			this.FKEDAOOHPPB = KADBECGIMPD.IBKCNEICPEL();
			long lpfkfnlhgbi = KADBECGIMPD.ANPEIKGEDHJ();
			int ilfhhdnjhnm = KADBECGIMPD.KDNDJNEGBDI();
			string clkmcahnhbm = KADBECGIMPD.DPLAJNEDGBL();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CILBHAALIEF();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.EKEBHIJMEML().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
		}

		// Token: 0x0600528D RID: 21133 RVA: 0x0026F7A8 File Offset: 0x0026D9A8
		public void EFMCIOELHGA(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NGIGCKBKLGK())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.DMABDIGCLKA();
			this.BDHHPAEHFHG = IHFEDJEMJMB.JHAAMBEFENP().IMCJNFHAFGE(KADBECGIMPD.KKOKFLMMAAK());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.HDBGOLAFOBK();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.KKOKFLMMAAK();
			this.AONGINFINPD = KADBECGIMPD.MLFLLBPGFIJ();
		}

		// Token: 0x0600528E RID: 21134 RVA: 0x0026F820 File Offset: 0x0026DA20
		public void NCBLINOLCNG(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NGIGCKBKLGK())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.HFOPFEJDJFG();
			this.BDHHPAEHFHG = IHFEDJEMJMB.OELKEADDKPE().NKMGKJLONDK(KADBECGIMPD.KDNDJNEGBDI());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.KKOKFLMMAAK();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.DOJKJHMJJNK();
			this.AONGINFINPD = KADBECGIMPD.OJNFAHFAKDO();
		}

		// Token: 0x0600528F RID: 21135 RVA: 0x0026F898 File Offset: 0x0026DA98
		public void AECABAHKBBF(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.INLBHLOLOJH())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.DMABDIGCLKA();
			this.BDHHPAEHFHG = IHFEDJEMJMB.NNEAHAFBOHC().IMCJNFHAFGE(KADBECGIMPD.KDNDJNEGBDI());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.HDBGOLAFOBK();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.HDBGOLAFOBK();
			this.AONGINFINPD = KADBECGIMPD.HHAPCIKKNPB();
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x0026F910 File Offset: 0x0026DB10
		public void ENMJOPDPKAE(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NNOJEFMEGEG())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.ANPEIKGEDHJ();
			this.BDHHPAEHFHG = IHFEDJEMJMB.EDKKJNHDBPF().LMGMPPAOPEP(KADBECGIMPD.CLPEKGGAMAI());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.DOJKJHMJJNK();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.CLPEKGGAMAI();
			this.AONGINFINPD = KADBECGIMPD.MILGIGJBAJL();
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x0026F988 File Offset: 0x0026DB88
		public void FHLOMHLNOAO(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.DFLKBBNOGBG())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.EJPMFEJBGMN();
			this.BDHHPAEHFHG = IHFEDJEMJMB.IKGFHGKKCPG.LMGMPPAOPEP(KADBECGIMPD.DOJKJHMJJNK());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.DOJKJHMJJNK();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.CLPEKGGAMAI();
			this.AONGINFINPD = KADBECGIMPD.NIIFLPIEMFM();
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x0026FA00 File Offset: 0x0026DC00
		public void AFEMIELCGMH(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.BKIBKLFCCGP())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.DMABDIGCLKA();
			this.AONGINFINPD = KADBECGIMPD.HGFHMFMNIEI();
			this.KLKFECAJPNN = KADBECGIMPD.HFOPFEJDJFG();
			this.JIFMHICCOJJ = KADBECGIMPD.KLHDFFHONON();
			this.JGNLJOJBAIB = KADBECGIMPD.KDNDJNEGBDI();
			this.HBIACFNHJEE = KADBECGIMPD.HHMGLDMFCPF();
			this.KAFDCOOEPID = KADBECGIMPD.IJDIMHAEAIE();
			this.FKEDAOOHPPB = KADBECGIMPD.KLHDFFHONON();
			long lpfkfnlhgbi = KADBECGIMPD.HFOPFEJDJFG();
			int ilfhhdnjhnm = KADBECGIMPD.KDNDJNEGBDI();
			string clkmcahnhbm = KADBECGIMPD.KDELAFDDGJH();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.EPCKOOOGNGK().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x0026FB24 File Offset: 0x0026DD24
		public void ACAMOCPJLLP(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.PPAHBNGECGH())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)4;
			this.EENFJPJEDFM = KADBECGIMPD.DCGEOFHNBCN();
			this.AONGINFINPD = KADBECGIMPD.FCGGODFGMCB();
			this.KLKFECAJPNN = KADBECGIMPD.EJPMFEJBGMN();
			this.JIFMHICCOJJ = KADBECGIMPD.ANPEIKGEDHJ();
			this.JGNLJOJBAIB = KADBECGIMPD.IFDFHJLCHAE();
			this.HBIACFNHJEE = KADBECGIMPD.ANPEIKGEDHJ();
			this.KAFDCOOEPID = KADBECGIMPD.IJDIMHAEAIE();
			this.FKEDAOOHPPB = KADBECGIMPD.DMABDIGCLKA();
			long lpfkfnlhgbi = KADBECGIMPD.KLHDFFHONON();
			int ilfhhdnjhnm = KADBECGIMPD.CLPEKGGAMAI();
			string clkmcahnhbm = KADBECGIMPD.KDELAFDDGJH();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CILBHAALIEF();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.IKGFHGKKCPG.deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
		}

		// Token: 0x06005294 RID: 21140 RVA: 0x0026FC48 File Offset: 0x0026DE48
		public void CBLECPFGMAJ(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NNOJEFMEGEG())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.DNIIFBAIPBE();
			this.BDHHPAEHFHG = IHFEDJEMJMB.IKGFHGKKCPG.LMGMPPAOPEP(KADBECGIMPD.AGNKAFLKCAG());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.HHLDBAEFNMJ();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.LDLKLPJBIJN();
			this.AONGINFINPD = KADBECGIMPD.PFKHMDDOHDN();
		}

		// Token: 0x06005295 RID: 21141 RVA: 0x0026FCC0 File Offset: 0x0026DEC0
		public void DMHOBAPBEDE(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.BKIBKLFCCGP())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)4;
			this.EENFJPJEDFM = KADBECGIMPD.IJDIMHAEAIE();
			this.AONGINFINPD = KADBECGIMPD.OODOKDPIMOF();
			this.KLKFECAJPNN = KADBECGIMPD.DMABDIGCLKA();
			this.JIFMHICCOJJ = KADBECGIMPD.EJPMFEJBGMN();
			this.JGNLJOJBAIB = KADBECGIMPD.CLPEKGGAMAI();
			this.HBIACFNHJEE = KADBECGIMPD.KLHDFFHONON();
			this.KAFDCOOEPID = KADBECGIMPD.DMABDIGCLKA();
			this.FKEDAOOHPPB = KADBECGIMPD.KLHDFFHONON();
			long lpfkfnlhgbi = KADBECGIMPD.DNIIFBAIPBE();
			int ilfhhdnjhnm = KADBECGIMPD.DOJKJHMJJNK();
			string clkmcahnhbm = KADBECGIMPD.FDIDEGHPJPF();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.IKGFHGKKCPG.deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x0026FDE4 File Offset: 0x0026DFE4
		public void BFDJHPBNKIJ(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NGIGCKBKLGK())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.DMABDIGCLKA();
			this.BDHHPAEHFHG = IHFEDJEMJMB.NNEAHAFBOHC().NKMGKJLONDK(KADBECGIMPD.AGNKAFLKCAG());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JIFFLPNBILE();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.LDLKLPJBIJN();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.KDNDJNEGBDI();
			this.AONGINFINPD = KADBECGIMPD.OJNFAHFAKDO();
		}

		// Token: 0x06005297 RID: 21143 RVA: 0x0026FE5C File Offset: 0x0026E05C
		public void BJDGDHIMPJO(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.ODIBHLOAGBC())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)8;
			this.EENFJPJEDFM = KADBECGIMPD.DCGEOFHNBCN();
			this.AONGINFINPD = KADBECGIMPD.MILGIGJBAJL();
			this.KLKFECAJPNN = KADBECGIMPD.HHMGLDMFCPF();
			this.JIFMHICCOJJ = KADBECGIMPD.HFOPFEJDJFG();
			this.JGNLJOJBAIB = KADBECGIMPD.HHLDBAEFNMJ();
			this.HBIACFNHJEE = KADBECGIMPD.HFOPFEJDJFG();
			this.KAFDCOOEPID = KADBECGIMPD.HFOPFEJDJFG();
			this.FKEDAOOHPPB = KADBECGIMPD.KLHDFFHONON();
			long lpfkfnlhgbi = KADBECGIMPD.ANPEIKGEDHJ();
			int ilfhhdnjhnm = KADBECGIMPD.DOJKJHMJJNK();
			string clkmcahnhbm = KADBECGIMPD.JJJJAGJCOGD();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CILBHAALIEF();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.BOBNPEAEECC().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x0026FF80 File Offset: 0x0026E180
		public void NAFAKFNNBJF(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NNOJEFMEGEG())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.WeaponLot;
			this.EENFJPJEDFM = KADBECGIMPD.HFOPFEJDJFG();
			this.AONGINFINPD = KADBECGIMPD.MILGIGJBAJL();
			this.KLKFECAJPNN = KADBECGIMPD.ANPEIKGEDHJ();
			this.JIFMHICCOJJ = KADBECGIMPD.IJDIMHAEAIE();
			this.JGNLJOJBAIB = KADBECGIMPD.KDNDJNEGBDI();
			this.HBIACFNHJEE = KADBECGIMPD.IJDIMHAEAIE();
			this.KAFDCOOEPID = KADBECGIMPD.DNIIFBAIPBE();
			this.FKEDAOOHPPB = KADBECGIMPD.IBKCNEICPEL();
			long lpfkfnlhgbi = KADBECGIMPD.ANPEIKGEDHJ();
			int ilfhhdnjhnm = KADBECGIMPD.DOJKJHMJJNK();
			string clkmcahnhbm = KADBECGIMPD.DHCMILPKJAL();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.EKEBHIJMEML().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JIFFLPNBILE();
			}
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x002700A4 File Offset: 0x0026E2A4
		public void CEPHAMOKBIN(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.HKBFCJDJCOB())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.DNIIFBAIPBE();
			this.BDHHPAEHFHG = IHFEDJEMJMB.IKGFHGKKCPG.LMGMPPAOPEP(KADBECGIMPD.HHLDBAEFNMJ());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.AGNKAFLKCAG();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.HDBGOLAFOBK();
			this.AONGINFINPD = KADBECGIMPD.FCGGODFGMCB();
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x0027011C File Offset: 0x0026E31C
		public void MJKPBLAMELE(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.ODIBHLOAGBC())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)8;
			this.EENFJPJEDFM = KADBECGIMPD.HHMGLDMFCPF();
			this.AONGINFINPD = KADBECGIMPD.NIIFLPIEMFM();
			this.KLKFECAJPNN = KADBECGIMPD.KLHDFFHONON();
			this.JIFMHICCOJJ = KADBECGIMPD.DNIIFBAIPBE();
			this.JGNLJOJBAIB = KADBECGIMPD.IFDFHJLCHAE();
			this.HBIACFNHJEE = KADBECGIMPD.DNIIFBAIPBE();
			this.KAFDCOOEPID = KADBECGIMPD.ANPEIKGEDHJ();
			this.FKEDAOOHPPB = KADBECGIMPD.HHMGLDMFCPF();
			long lpfkfnlhgbi = KADBECGIMPD.HHMGLDMFCPF();
			int ilfhhdnjhnm = KADBECGIMPD.KKOKFLMMAAK();
			string clkmcahnhbm = KADBECGIMPD.FDIDEGHPJPF();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.EPCKOOOGNGK().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x00270240 File Offset: 0x0026E440
		public void AODNIDLHAEH(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NNOJEFMEGEG())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.KLHDFFHONON();
			this.BDHHPAEHFHG = IHFEDJEMJMB.AGCBLDIBMNB().GBKMHIGNKJA(KADBECGIMPD.KDNDJNEGBDI());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.HHLDBAEFNMJ();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.LDLKLPJBIJN();
			this.AONGINFINPD = KADBECGIMPD.MLFLLBPGFIJ();
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x002702B8 File Offset: 0x0026E4B8
		public void MPCPDBAANCL(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.JCEGOADAOOI)
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.WeaponLot;
			this.EENFJPJEDFM = KADBECGIMPD.DNIIFBAIPBE();
			this.AONGINFINPD = KADBECGIMPD.IKJAOHGGCJD();
			this.KLKFECAJPNN = KADBECGIMPD.DNIIFBAIPBE();
			this.JIFMHICCOJJ = KADBECGIMPD.DNIIFBAIPBE();
			this.JGNLJOJBAIB = KADBECGIMPD.HDBGOLAFOBK();
			this.HBIACFNHJEE = KADBECGIMPD.DNIIFBAIPBE();
			this.KAFDCOOEPID = KADBECGIMPD.DNIIFBAIPBE();
			this.FKEDAOOHPPB = KADBECGIMPD.DNIIFBAIPBE();
			long lpfkfnlhgbi = KADBECGIMPD.DNIIFBAIPBE();
			int ilfhhdnjhnm = KADBECGIMPD.HDBGOLAFOBK();
			string clkmcahnhbm = KADBECGIMPD.BFPHBMDMODH();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.IKGFHGKKCPG.deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JIFFLPNBILE();
			}
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x002703DC File Offset: 0x0026E5DC
		public void IJPILOFKMLN(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.IBMMOGHFCCE())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.EJPMFEJBGMN();
			this.BDHHPAEHFHG = IHFEDJEMJMB.OELKEADDKPE().IMCJNFHAFGE(KADBECGIMPD.LDLKLPJBIJN());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.AGNKAFLKCAG();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.IFDFHJLCHAE();
			this.AONGINFINPD = KADBECGIMPD.MILGIGJBAJL();
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x00270454 File Offset: 0x0026E654
		public void HFFHMOGNGCL(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.JEFMHDJEEJC())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.HFOPFEJDJFG();
			this.BDHHPAEHFHG = IHFEDJEMJMB.NNEAHAFBOHC().LMGMPPAOPEP(KADBECGIMPD.DOJKJHMJJNK());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.DOJKJHMJJNK();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.LDLKLPJBIJN();
			this.AONGINFINPD = KADBECGIMPD.IKJAOHGGCJD();
		}

		// Token: 0x0600529F RID: 21151 RVA: 0x002704CC File Offset: 0x0026E6CC
		public void CAEODEOJHBE(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.LILLHFLDMBH())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)8;
			this.EENFJPJEDFM = KADBECGIMPD.IJDIMHAEAIE();
			this.AONGINFINPD = KADBECGIMPD.MILGIGJBAJL();
			this.KLKFECAJPNN = KADBECGIMPD.DNIIFBAIPBE();
			this.JIFMHICCOJJ = KADBECGIMPD.IBKCNEICPEL();
			this.JGNLJOJBAIB = KADBECGIMPD.LDLKLPJBIJN();
			this.HBIACFNHJEE = KADBECGIMPD.HFOPFEJDJFG();
			this.KAFDCOOEPID = KADBECGIMPD.HHMGLDMFCPF();
			this.FKEDAOOHPPB = KADBECGIMPD.DNIIFBAIPBE();
			long lpfkfnlhgbi = KADBECGIMPD.IBKCNEICPEL();
			int ilfhhdnjhnm = KADBECGIMPD.AGNKAFLKCAG();
			string clkmcahnhbm = KADBECGIMPD.FDIDEGHPJPF();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.EKEBHIJMEML().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JIFFLPNBILE();
			}
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x002705F0 File Offset: 0x0026E7F0
		public void CPDIMENEDBJ(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.LILLHFLDMBH())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.WeaponLot;
			this.EENFJPJEDFM = KADBECGIMPD.HFOPFEJDJFG();
			this.AONGINFINPD = KADBECGIMPD.OODOKDPIMOF();
			this.KLKFECAJPNN = KADBECGIMPD.HFOPFEJDJFG();
			this.JIFMHICCOJJ = KADBECGIMPD.HHMGLDMFCPF();
			this.JGNLJOJBAIB = KADBECGIMPD.AGNKAFLKCAG();
			this.HBIACFNHJEE = KADBECGIMPD.HFOPFEJDJFG();
			this.KAFDCOOEPID = KADBECGIMPD.DCGEOFHNBCN();
			this.FKEDAOOHPPB = KADBECGIMPD.HFOPFEJDJFG();
			long lpfkfnlhgbi = KADBECGIMPD.ANPEIKGEDHJ();
			int ilfhhdnjhnm = KADBECGIMPD.HHLDBAEFNMJ();
			string clkmcahnhbm = KADBECGIMPD.NCODBGMGNFD();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.BOBNPEAEECC().deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
		}

		// Token: 0x060052A1 RID: 21153 RVA: 0x00270714 File Offset: 0x0026E914
		public void HCFGFEICBIM(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.HKBFCJDJCOB())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.IJDIMHAEAIE();
			this.BDHHPAEHFHG = IHFEDJEMJMB.EDKKJNHDBPF().LMGMPPAOPEP(KADBECGIMPD.IFDFHJLCHAE());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.HDBGOLAFOBK();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.KDNDJNEGBDI();
			this.AONGINFINPD = KADBECGIMPD.OODOKDPIMOF();
		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x0027078C File Offset: 0x0026E98C
		public void GOBAGFDEONM(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.DFLKBBNOGBG())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.DNIIFBAIPBE();
			this.BDHHPAEHFHG = IHFEDJEMJMB.OELKEADDKPE().LMGMPPAOPEP(KADBECGIMPD.LDLKLPJBIJN());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JIFFLPNBILE();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.AGNKAFLKCAG();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.HDBGOLAFOBK();
			this.AONGINFINPD = KADBECGIMPD.PFKHMDDOHDN();
		}

		// Token: 0x060052A3 RID: 21155 RVA: 0x00270804 File Offset: 0x0026EA04
		public void APCEOHODOBA(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.JCEGOADAOOI)
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)4;
			this.EENFJPJEDFM = KADBECGIMPD.HHMGLDMFCPF();
			this.AONGINFINPD = KADBECGIMPD.PFKHMDDOHDN();
			this.KLKFECAJPNN = KADBECGIMPD.ANPEIKGEDHJ();
			this.JIFMHICCOJJ = KADBECGIMPD.DCGEOFHNBCN();
			this.JGNLJOJBAIB = KADBECGIMPD.IFDFHJLCHAE();
			this.HBIACFNHJEE = KADBECGIMPD.EJPMFEJBGMN();
			this.KAFDCOOEPID = KADBECGIMPD.DCGEOFHNBCN();
			this.FKEDAOOHPPB = KADBECGIMPD.IBKCNEICPEL();
			long lpfkfnlhgbi = KADBECGIMPD.DNIIFBAIPBE();
			int ilfhhdnjhnm = KADBECGIMPD.IFDFHJLCHAE();
			string clkmcahnhbm = KADBECGIMPD.NCODBGMGNFD();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CILBHAALIEF();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.IKGFHGKKCPG.deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x00270928 File Offset: 0x0026EB28
		public void AMDOGELHNOF(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.JCEGOADAOOI)
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.HHMGLDMFCPF();
			this.BDHHPAEHFHG = IHFEDJEMJMB.IKGFHGKKCPG.IMCJNFHAFGE(KADBECGIMPD.KDNDJNEGBDI());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.LDLKLPJBIJN();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.KDNDJNEGBDI();
			this.AONGINFINPD = KADBECGIMPD.HHAPCIKKNPB();
		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x002709A0 File Offset: 0x0026EBA0
		public void CNNBPPFAINF(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.KFKIFJDHCHB())
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.ResLot;
			this.EENFJPJEDFM = KADBECGIMPD.EJPMFEJBGMN();
			this.BDHHPAEHFHG = IHFEDJEMJMB.OOIJFNAMEDP().LMGMPPAOPEP(KADBECGIMPD.HHLDBAEFNMJ());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.CLPEKGGAMAI();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.AGNKAFLKCAG();
			this.AONGINFINPD = KADBECGIMPD.MLFLLBPGFIJ();
		}

		// Token: 0x060052A6 RID: 21158 RVA: 0x00270A18 File Offset: 0x0026EC18
		public void BBAPPOIOFDG(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.NNOJEFMEGEG())
			{
				return;
			}
			this.BDJGKIEBGCA = (MDEKJCCIDIA.EIHOIMIOGKJ)5;
			this.EENFJPJEDFM = KADBECGIMPD.IBKCNEICPEL();
			this.AONGINFINPD = KADBECGIMPD.HGFHMFMNIEI();
			this.KLKFECAJPNN = KADBECGIMPD.IBKCNEICPEL();
			this.JIFMHICCOJJ = KADBECGIMPD.ANPEIKGEDHJ();
			this.JGNLJOJBAIB = KADBECGIMPD.CLPEKGGAMAI();
			this.HBIACFNHJEE = KADBECGIMPD.KLHDFFHONON();
			this.KAFDCOOEPID = KADBECGIMPD.HFOPFEJDJFG();
			this.FKEDAOOHPPB = KADBECGIMPD.ANPEIKGEDHJ();
			long lpfkfnlhgbi = KADBECGIMPD.HHMGLDMFCPF();
			int ilfhhdnjhnm = KADBECGIMPD.IFDFHJLCHAE();
			string clkmcahnhbm = KADBECGIMPD.JJJJAGJCOGD();
			this.MEJMEKODJAE = new EKBAPCMPANI();
			this.MEJMEKODJAE.LPFKFNLHGBI = lpfkfnlhgbi;
			this.MEJMEKODJAE.ILFHHDNJHNM = ilfhhdnjhnm;
			this.MEJMEKODJAE.CLKMCAHNHBM = clkmcahnhbm;
			this.MEJMEKODJAE.CMBLJJMJMCE();
			this.MEJMEKODJAE.DLHPFGHOINI = (float)this.MEJMEKODJAE.BGGJKOMAKEE;
			this.AONGINFINPD += TimeController.IKGFHGKKCPG.deltaTime;
			this.BDHHPAEHFHG = this.MEJMEKODJAE.BDHHPAEHFHG;
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JLCGGFPBOCF();
			}
		}

		// Token: 0x060052A7 RID: 21159 RVA: 0x00270B3C File Offset: 0x0026ED3C
		public void JMMDIMGMPBL(HBPNMNGOFMA KADBECGIMPD)
		{
			if (KADBECGIMPD.JCEGOADAOOI)
			{
				return;
			}
			this.BDJGKIEBGCA = MDEKJCCIDIA.EIHOIMIOGKJ.MyResLot;
			this.EENFJPJEDFM = KADBECGIMPD.DNIIFBAIPBE();
			this.BDHHPAEHFHG = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(KADBECGIMPD.HDBGOLAFOBK());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JIFFLPNBILE();
			}
			this.ILFHHDNJHNM = KADBECGIMPD.HDBGOLAFOBK();
			this.FKEDAOOHPPB = (long)KADBECGIMPD.HDBGOLAFOBK();
			this.AONGINFINPD = KADBECGIMPD.IKJAOHGGCJD();
		}

		// Token: 0x04000CA2 RID: 3234
		public long EENFJPJEDFM;

		// Token: 0x04000CA3 RID: 3235
		public long KLKFECAJPNN;

		// Token: 0x04000CA4 RID: 3236
		public long JIFMHICCOJJ;

		// Token: 0x04000CA5 RID: 3237
		public MDEKJCCIDIA.EIHOIMIOGKJ BDJGKIEBGCA;

		// Token: 0x04000CA6 RID: 3238
		public int JGNLJOJBAIB;

		// Token: 0x04000CA7 RID: 3239
		public BEFCHFNGOMI BDHHPAEHFHG;

		// Token: 0x04000CA8 RID: 3240
		public EKBAPCMPANI MEJMEKODJAE;

		// Token: 0x04000CA9 RID: 3241
		public int ILFHHDNJHNM;

		// Token: 0x04000CAA RID: 3242
		public long HBIACFNHJEE;

		// Token: 0x04000CAB RID: 3243
		public long KAFDCOOEPID;

		// Token: 0x04000CAC RID: 3244
		public long NCDLAEEPAFE;

		// Token: 0x04000CAD RID: 3245
		public long FKEDAOOHPPB;

		// Token: 0x04000CAE RID: 3246
		public DateTime AONGINFINPD;
	}
}
