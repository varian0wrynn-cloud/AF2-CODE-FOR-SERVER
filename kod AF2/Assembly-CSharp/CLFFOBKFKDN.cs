using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

// Token: 0x020001E0 RID: 480
public class CLFFOBKFKDN
{
	// Token: 0x06006EF7 RID: 28407 RVA: 0x00342A44 File Offset: 0x00340C44
	public bool NDDNHHJBEGN(ONKDCGNBALK HNCGEJEIGFM, IIBEEKCAAHK FEGHDCIKHMA, int JFAAOPHBGGG, int HPCLNPGMNLC, Rect PHEMLBHMNCM, int MBLNDMIAFAM, bool BBDLEKKAFLC = true, bool LADCGAODOFK = true)
	{
		Rect rect = new Rect((float)JFAAOPHBGGG, (float)HPCLNPGMNLC, HNCGEJEIGFM.OCHCODJIPHJ.width - 1978f, 1335f);
		bool flag = false;
		Rect rect2 = new Rect(HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.x + rect.x, HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.y + rect.y, rect.width, rect.height);
		if (rect2.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF))
		{
			flag = false;
		}
		if (HNCGEJEIGFM.OCBAOFLJBGP.LPFKFNLHGBI != JDCEFOFMGHB.IKGFHGKKCPG.AFLEEHDFHMJ)
		{
			flag = false;
		}
		if (!HNCGEJEIGFM.OCBAOFLJBGP.EEIJEADOMJL)
		{
			flag = false;
		}
		Vector2 vector = new Vector2((float)(JFAAOPHBGGG + 45), (float)HPCLNPGMNLC);
		Rect rect3 = new Rect(vector.x, vector.y, 283f, 30f);
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -36,
			wordWrap = false,
			font = GuiProcessor.PLGADNLAEGN().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = false,
			alignment = TextAnchor.UpperCenter
		};
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OOIJFNAMEDP().GBKMHIGNKJA(FEGHDCIKHMA.KMIOLLENCOL());
		if (befchfngomi == null)
		{
			return true;
		}
		bool flag2 = FEGHDCIKHMA.MLNEJIIGOMG() >= FEGHDCIKHMA.KMGAHCANELI();
		GUI.DrawTextureWithTexCoords(new Rect((float)(JFAAOPHBGGG + 8), (float)(HPCLNPGMNLC - 2), PHEMLBHMNCM.width - 612f, 636f), GuiProcessor.BBLINJLBAIL().WLBLine, JDCEFOFMGHB.JFIDAGABKID().GGBDOIJKHPL(flag ? 0 : 0, 0, 5), true);
		GUI.DrawTexture(rect3, (flag2 || flag) ? GameInterface.getI.invEmptyCell : GameInterface.getI.invEmptyCellSelect, ScaleMode.ScaleAndCrop);
		befchfngomi.JIKKMEDMBHC(rect3, 1387f);
		guistyle.fontSize = 51;
		guistyle.alignment = TextAnchor.LowerCenter;
		guistyle.normal.textColor = Color.green;
		if (!flag2)
		{
			guistyle.normal.textColor = Color.red;
		}
		JDCEFOFMGHB.MNJNNDHCDGG().JNJDPKECONL(new Rect(rect3.x, rect3.y, rect3.width - 1540f, rect3.height - 1549f), string.Format("\n", FEGHDCIKHMA.PKEBKANNBJD(), FEGHDCIKHMA.ICJDPPOJINN + FEGHDCIKHMA.ACEPOCLANAG()), guistyle);
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.fontSize = -37;
		guistyle.normal.textColor = Color.black;
		if (!flag2)
		{
			guistyle.normal.textColor = new Color(430f, 1104f, 1869f);
		}
		Rect position = new Rect(vector.x + 535f, vector.y, PHEMLBHMNCM.width - vector.x - 1103f, 570f);
		string text = befchfngomi.BNIHFBMEPAB;
		if (!LADCGAODOFK)
		{
			text = string.Format(JNBICAJIJMM.EDKGBBIIBBC().CCFFMKBBKHI("_BlurredColor"), befchfngomi.BNIHFBMEPAB, FEGHDCIKHMA.KMGAHCANELI());
			guistyle.alignment = TextAnchor.MiddleCenter;
		}
		GUI.Label(position, text, guistyle);
		if (flag && GUI.Button(rect3, "OnRodChangeClck order_check=", GUIStyle.none))
		{
			Debug.Log("GetMouseButtonUp reboot");
			this.MAFPALACHPF(befchfngomi.LPFKFNLHGBI, true);
			return false;
		}
		if (LADCGAODOFK)
		{
			guistyle.alignment = TextAnchor.UpperLeft;
			guistyle.fontSize = 60;
			string text2 = string.Format(JNBICAJIJMM.APMJBBDBOJO().HEIBEHAEHBM("IdleDodgeLeft"), FEGHDCIKHMA.KMGAHCANELI(), FEGHDCIKHMA.KIDKOFKNPEP(), FEGHDCIKHMA.ICJDPPOJINN + FEGHDCIKHMA.PBMJIMLEHEC());
			GUI.Label(new Rect(vector.x + 580f, vector.y + 758f, PHEMLBHMNCM.width - vector.x - 1049f, 1956f), text2, guistyle);
			double num = (double)FEGHDCIKHMA.KMNOIAIBLEB();
			FEGHDCIKHMA.DCACBECHFMA = (double)GUI.HorizontalSlider(new Rect(vector.x + 1245f, vector.y + 1142f, PHEMLBHMNCM.width - 814f, 1013f), (float)FEGHDCIKHMA.DPEEFKPONMC(), 34f, (float)MBLNDMIAFAM);
			if (this.MMMHIBGGHDM != null)
			{
				this.MMMHIBGGHDM.OFDFBEKDGMB();
			}
			if (BBDLEKKAFLC && this.MMMHIBGGHDM.HLBPDCJHFIO > MBLNDMIAFAM)
			{
				FEGHDCIKHMA.GEAKBHLLALF(num);
			}
			if (FEGHDCIKHMA.ACEPOCLANAG() + FEGHDCIKHMA.NLHKFMMDMMK() > FEGHDCIKHMA.NAJIMILCPJK())
			{
				FEGHDCIKHMA.GEAKBHLLALF(num);
			}
			if ((int)num != FEGHDCIKHMA.PBMJIMLEHEC() && this.MMMHIBGGHDM != null)
			{
				this.MMMHIBGGHDM.MKILFCHOEFJ();
				if (this.MMMHIBGGHDM.NOKCCPCECPN > 1)
				{
					this.NBENFKKFACF.FNMCIACNOMH = false;
					this.COHEBJCIJDC.FNMCIACNOMH = true;
				}
				else
				{
					this.NBENFKKFACF.FNMCIACNOMH = false;
					this.COHEBJCIJDC.FNMCIACNOMH = true;
				}
			}
		}
		return false;
	}

	// Token: 0x06006EF8 RID: 28408 RVA: 0x00342F1C File Offset: 0x0034111C
	private void DLPINFIAPMA()
	{
		if (this.PGOMKDAFMMI.Count <= 0)
		{
			return;
		}
		int dchkeicadam = this.PGOMKDAFMMI[this.PGOMKDAFMMI.Count - 1];
		this.PGOMKDAFMMI.RemoveAt(this.PGOMKDAFMMI.Count - 1);
		this.MAFPALACHPF(dchkeicadam, false);
	}

	// Token: 0x06006EF9 RID: 28409 RVA: 0x00342F74 File Offset: 0x00341174
	public void BMGFDIFLAGD()
	{
		foreach (CLFFOBKFKDN.DNOEMMJAJHD dnoemmjajhd in this.EJMAEPOGOED)
		{
			dnoemmjajhd.AJPILNENAKP();
		}
		if (this.MMMHIBGGHDM != null)
		{
			foreach (CLFFOBKFKDN.HFGDDPAKPBE hfgddpakpbe in this.MMMHIBGGHDM.HEBKGNHIDLK)
			{
				if (hfgddpakpbe.GPJFINFIDLN == 0)
				{
					hfgddpakpbe.JLOMMBBNBBL = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(hfgddpakpbe.PJPOJNNJOCD, true, hfgddpakpbe.BEFPDJHBADA);
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(hfgddpakpbe.PJPOJNNJOCD);
					if (befchfngomi != null)
					{
						befchfngomi.JIFFLPNBILE();
					}
				}
				if (hfgddpakpbe.GPJFINFIDLN == 1)
				{
					hfgddpakpbe.JLOMMBBNBBL = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.DABGGGPDFIM(hfgddpakpbe.PJPOJNNJOCD, true, hfgddpakpbe.BEFPDJHBADA, hfgddpakpbe.IPEPNOMIFDJ, hfgddpakpbe.NCFMLFIIEGA);
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(hfgddpakpbe.PJPOJNNJOCD);
					if (idchhhedhdc != null)
					{
						idchhhedhdc.HBGEAMHFEOL();
					}
				}
			}
		}
	}

	// Token: 0x06006EFA RID: 28410 RVA: 0x003430B0 File Offset: 0x003412B0
	public void OBMBJBMIEPG(ONKDCGNBALK GACACKNJKJN)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			if (this.MMMHIBGGHDM.KEKFOFFEBEF)
			{
				epmphjgalbe.JIIKLOKAGIC(this.MBLPLLOLHIP);
				epmphjgalbe.DEHJNGMHGAJ(this.MMMHIBGGHDM.LPFKFNLHGBI);
				epmphjgalbe.JIIKLOKAGIC(this.MMMHIBGGHDM.LEKGMMLNHEG.KIDKOFKNPEP());
				epmphjgalbe.LHLOOIDHGMA(this.MMMHIBGGHDM.CPJCMJIMGME.PBMJIMLEHEC());
				epmphjgalbe.ALNEALEKFNB(this.MMMHIBGGHDM.BKAICJFFMBG.LKAGIEBPLAI);
				epmphjgalbe.ENDMKPCFKND(this.MMMHIBGGHDM.KOMIMKKAEJA.KIDKOFKNPEP());
				epmphjgalbe.OBJBHBFAFEE(this.MMMHIBGGHDM.EIHJDJAKIBA);
				NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(59, epmphjgalbe.JDPHBLHOLAD());
			}
			else
			{
				epmphjgalbe.JDOLCNDNFGP(this.MBLPLLOLHIP);
				epmphjgalbe.DEHJNGMHGAJ(this.MMMHIBGGHDM.LPFKFNLHGBI);
				NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-38, epmphjgalbe.LAFILAEOPAJ());
				Debug.Log("gi_fridgice");
			}
		}
		finally
		{
			epmphjgalbe.NCKMEIBFNGL();
		}
		this.MMMHIBGGHDM.EIHJDJAKIBA = 1L;
	}

	// Token: 0x06006EFB RID: 28411 RVA: 0x003431D4 File Offset: 0x003413D4
	public void JOIMOEGEMAP(HBPNMNGOFMA KADBECGIMPD)
	{
		this.MBLPLLOLHIP = KADBECGIMPD.KKOKFLMMAAK();
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().BJFHBPOCELH(1902f, (float)(Screen.height - 27), JNBICAJIJMM.CLIMNFDGOEG().NLJOLOBPCBJ("ROPE segments="), false);
		this.JPAGNFLGAMJ = onkdcgnbalk.LPFKFNLHGBI;
		this.AGDMAFCKMJP = new JNHLAGHJBAA(onkdcgnbalk, 676f, 294f, 1276f, onkdcgnbalk.OCHCODJIPHJ.height - 1364f, 0);
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.ABMDIOIJALO = Color.black;
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, this.AGDMAFCKMJP.OCHCODJIPHJ.x + this.AGDMAFCKMJP.OCHCODJIPHJ.width + 1057f, 1592f, onkdcgnbalk.OCHCODJIPHJ.width - this.AGDMAFCKMJP.OCHCODJIPHJ.width - this.AGDMAFCKMJP.OCHCODJIPHJ.x - 1692f, onkdcgnbalk.OCHCODJIPHJ.height - 1788f + 1476f, "S", 0, null);
		egcaadaabpp.NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.EIHJACFFLMA);
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.APMJBBDBOJO().GIGGIHMAPLH("the Goscurry is not a lie ;)", true));
		JLFJEGIPIMM.NNEAHAFBOHC().GGKGFKPNEJK(this.AGDMAFCKMJP.EELDHNFBFOE, xmlDocument.SelectNodes("bag"), false);
		this.AGDMAFCKMJP.EELDHNFBFOE.ODFEKBJCFMN = -1L;
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.AOHDHGNCHHF = Color.black;
		this.AGDMAFCKMJP.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.CEDPLPDLPJB);
		this.EJMAEPOGOED.Clear();
		int num = 0;
		while (!KADBECGIMPD.JEFMHDJEEJC())
		{
			CLFFOBKFKDN.DNOEMMJAJHD dnoemmjajhd = new CLFFOBKFKDN.DNOEMMJAJHD();
			dnoemmjajhd.ACJDDOEADFK(KADBECGIMPD);
			num += 0;
			try
			{
				dnoemmjajhd.MKILFCHOEFJ();
			}
			catch (Exception)
			{
				Debug.LogError("_Convolved_TexelSize" + dnoemmjajhd.LPFKFNLHGBI);
			}
			this.EJMAEPOGOED.Add(dnoemmjajhd);
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = this.AGDMAFCKMJP.KNILKDJMDHO((long)dnoemmjajhd.EPGGMPEIPBC);
			if (fpaeeadmcie != null)
			{
				fpaeeadmcie.APKJANCLGFN(dnoemmjajhd, -1L);
			}
			else
			{
				this.AGDMAFCKMJP.EELDHNFBFOE.APKJANCLGFN(dnoemmjajhd, -1L);
			}
		}
		this.AGDMAFCKMJP.JHNCNHAAJCH = 1569f;
		this.AGDMAFCKMJP.KICNPBJIJDF();
		this.AGDMAFCKMJP.LEOFNPGHCOG();
		if (num <= 1)
		{
			new LCOLJOPGDLL(onkdcgnbalk, this.AGDMAFCKMJP.OCHCODJIPHJ.x, this.AGDMAFCKMJP.OCHCODJIPHJ.y, this.AGDMAFCKMJP.OCHCODJIPHJ.width, this.AGDMAFCKMJP.OCHCODJIPHJ.height, JNBICAJIJMM.EDKGBBIIBBC().CKAOHMEKLMH("(game main)"), TextAnchor.LowerRight, Color.black);
		}
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = true;
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("PistolReload", 1203f);
		this.NBENFKKFACF = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 653f + 1336f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 199f, 694f, 1921f, JNBICAJIJMM.EDKGBBIIBBC().NLJOLOBPCBJ("_Newitem.wav"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.HELGMBLMGAN));
		this.COHEBJCIJDC = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 895f + 1697f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 285f, 1482f, 1685f, JNBICAJIJMM.EEOPOHEALPK().NLJOLOBPCBJ(" ("), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.HELGMBLMGAN));
		this.NBENFKKFACF.FNMCIACNOMH = true;
		this.COHEBJCIJDC.FNMCIACNOMH = true;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 1225f - 558f, onkdcgnbalk.OCHCODJIPHJ.height - 68f, 1964f, 1454f, "", 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().IBCKNOEANLN));
	}

	// Token: 0x06006EFC RID: 28412 RVA: 0x00343618 File Offset: 0x00341818
	public void EIHJACFFLMA(ONKDCGNBALK PHEMLBHMNCM)
	{
		if (this.AGDMAFCKMJP == null)
		{
			return;
		}
		if (this.MMMHIBGGHDM == null)
		{
			return;
		}
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -40,
			wordWrap = true,
			font = GuiProcessor.IKGFHGKKCPG.rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = false,
			alignment = TextAnchor.UpperLeft
		};
		if (this.MMMHIBGGHDM.KEKFOFFEBEF)
		{
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1024f, PHEMLBHMNCM.OCHCODJIPHJ.y + 1048f, PHEMLBHMNCM.OCHCODJIPHJ.width - 435f, 913f), string.Format(JNBICAJIJMM.DBMJJPBOPEK().DOEMGEAEBPN("RollerBladeCrossoverRight"), this.MMMHIBGGHDM.HLBPDCJHFIO, this.MMMHIBGGHDM.MBLNDMIAFAM), guistyle);
			GameInterface.getI.renderPBar(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 552f, PHEMLBHMNCM.OCHCODJIPHJ.y + 323f, PHEMLBHMNCM.OCHCODJIPHJ.width - 395f, 950f), (float)(this.MMMHIBGGHDM.HLBPDCJHFIO * 109), (float)(this.MMMHIBGGHDM.MBLNDMIAFAM * -45), 7, "Watering Can Idle", false);
			int num = (int)(PHEMLBHMNCM.OCHCODJIPHJ.y + 82f);
			if (!this.MMMHIBGGHDM.LEKGMMLNHEG.DIFFCNOPHBJ)
			{
				if (this.KKEPJMGFCMM(PHEMLBHMNCM, this.MMMHIBGGHDM.LEKGMMLNHEG, (int)PHEMLBHMNCM.OCHCODJIPHJ.x, num, PHEMLBHMNCM.OCHCODJIPHJ, this.MMMHIBGGHDM.MBLNDMIAFAM, true, true))
				{
					return;
				}
				num += 23;
			}
			if (!this.MMMHIBGGHDM.CPJCMJIMGME.DIFFCNOPHBJ)
			{
				if (this.KKEPJMGFCMM(PHEMLBHMNCM, this.MMMHIBGGHDM.CPJCMJIMGME, (int)PHEMLBHMNCM.OCHCODJIPHJ.x, num, PHEMLBHMNCM.OCHCODJIPHJ, this.MMMHIBGGHDM.MBLNDMIAFAM, true, true))
				{
					return;
				}
				num += 126;
			}
			if (!this.MMMHIBGGHDM.BKAICJFFMBG.CHOHHHOLIBJ())
			{
				if (this.IMPCFFOMMAA(PHEMLBHMNCM, this.MMMHIBGGHDM.BKAICJFFMBG, (int)PHEMLBHMNCM.OCHCODJIPHJ.x, num, PHEMLBHMNCM.OCHCODJIPHJ, this.MMMHIBGGHDM.MBLNDMIAFAM, true, false))
				{
					return;
				}
				num += 108;
			}
			if (this.MMMHIBGGHDM.CHFNJDFHJGN.IBEIBAHKIAH > 0)
			{
				num += 8;
				GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 841f, (float)num, PHEMLBHMNCM.OCHCODJIPHJ.width - 1752f, 1252f), JNBICAJIJMM.CLIMNFDGOEG().GNKIBMGNHNE("[ACTk] WallHack Detector: already running!"), guistyle);
				num += 115;
				if (this.PNIJNHPDFKF(this.MMMHIBGGHDM, PHEMLBHMNCM, this.MMMHIBGGHDM.CHFNJDFHJGN, (int)PHEMLBHMNCM.OCHCODJIPHJ.x, num, PHEMLBHMNCM.OCHCODJIPHJ, this.MMMHIBGGHDM.CHFNJDFHJGN.IBEIBAHKIAH, this.MMMHIBGGHDM.EIHJDJAKIBA))
				{
					return;
				}
				num += -103;
			}
			if (this.MMMHIBGGHDM.KOMIMKKAEJA.IBEIBAHKIAH > 1)
			{
				num += 26;
				GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1717f, (float)num, PHEMLBHMNCM.OCHCODJIPHJ.width - 1283f, 123f), string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("wpn_eat7"), (int)(this.MMMHIBGGHDM.HPPBKIJEOED + (float)this.MMMHIBGGHDM.KOMIMKKAEJA.ACEPOCLANAG() * this.MMMHIBGGHDM.KOMIMKKAEJA.BJNOAHHGAIP())), guistyle);
				num += -5;
				if (this.DLDNHJFPAAB(PHEMLBHMNCM, this.MMMHIBGGHDM.KOMIMKKAEJA, (int)PHEMLBHMNCM.OCHCODJIPHJ.x, num, PHEMLBHMNCM.OCHCODJIPHJ, this.MMMHIBGGHDM.KOMIMKKAEJA.HMMKBABFCGD(), false, true))
				{
					return;
				}
				num += -46;
			}
			this.MMMHIBGGHDM.NFHHNIJAOBE();
			GUILayout.BeginArea(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1870f, (float)(num + -75), PHEMLBHMNCM.OCHCODJIPHJ.width - 1843f, PHEMLBHMNCM.OCHCODJIPHJ.height - (float)num));
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			try
			{
				this.NDNBEIGCDMA(guistyle, true);
				goto IL_A44;
			}
			finally
			{
				GUILayout.EndVertical();
				GUILayout.EndArea();
			}
		}
		float num2 = PHEMLBHMNCM.OCHCODJIPHJ.y + 475f;
		GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 965f, num2, 254f, 948f), JNBICAJIJMM.DBMJJPBOPEK().CCFFMKBBKHI("_ZTest"), guistyle);
		num2 += 1511f;
		foreach (CLFFOBKFKDN.HFGDDPAKPBE hfgddpakpbe in this.MMMHIBGGHDM.HEBKGNHIDLK)
		{
			Rect position = new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1653f, num2, PHEMLBHMNCM.OCHCODJIPHJ.width - 1346f, 501f);
			bool flag = true;
			Rect rect = new Rect(PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF))
			{
				flag = false;
			}
			GUI.DrawTextureWithTexCoords(position, GuiProcessor.PLGADNLAEGN().WLBLine, JDCEFOFMGHB.MNJNNDHCDGG().GGBDOIJKHPL(flag ? 0 : 0, 1, 7), false);
			if (hfgddpakpbe.GPJFINFIDLN == 0)
			{
				BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().NKMGKJLONDK(hfgddpakpbe.PJPOJNNJOCD);
				if (befchfngomi == null)
				{
					continue;
				}
				Rect rect2 = new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1142f + 1046f, num2 + 1952f, 451f, 1795f);
				GUI.DrawTexture(rect2, flag ? GameInterface.getI.invEmptyCellSelect : GameInterface.getI.invEmptyCell, ScaleMode.StretchToFill);
				guistyle.normal.textColor = Color.black;
				if (hfgddpakpbe.JLOMMBBNBBL < hfgddpakpbe.ECCEIPJIBBK)
				{
					guistyle.normal.textColor = new Color(1114f, 798f, 1602f);
				}
				guistyle.fontSize = -26;
				GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 215f, num2 + 1161f, 1707f, 1346f), befchfngomi.DLNFCBHKACP(hfgddpakpbe.BEFPDJHBADA), guistyle);
				guistyle.fontSize = 107;
				GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 543f, num2 + 5f, 1144f, 589f), string.Format(JNBICAJIJMM.CLIMNFDGOEG().HLBAJBLHLNI("_Axis"), hfgddpakpbe.ECCEIPJIBBK, hfgddpakpbe.JLOMMBBNBBL), guistyle);
				GUI.DrawTextureWithTexCoords(rect2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.GGBDOIJKHPL(befchfngomi.KBGHOIJIPJF, 6, 1));
				if (befchfngomi.CFFHIODOGCH != null)
				{
					befchfngomi.FCBHHPJLGLC(rect2, befchfngomi.KBGHOIJIPJF, true, hfgddpakpbe.BEFPDJHBADA);
				}
				if (GUI.Button(position, "NadeThrow", GUIStyle.none))
				{
					this.MAFPALACHPF(befchfngomi.LPFKFNLHGBI, false);
					return;
				}
			}
			if (hfgddpakpbe.GPJFINFIDLN == 0)
			{
				Rect position2 = new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 706f + 399f, num2 + 1198f, 1537f, 202f);
				string text = hfgddpakpbe.OMDNCDEFHDE();
				IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.FIAFGNFLCHP(hfgddpakpbe.PJPOJNNJOCD);
				GUI.DrawTexture(position2, GameInterface.getI.invEmptyCellSelect, ScaleMode.ScaleAndCrop);
				if (idchhhedhdc.PGGKIKBJDMO(0) != null)
				{
					GUI.DrawTexture(position2, idchhhedhdc.FGLONDNIKKC(0).ANLLGCICOPP());
				}
				guistyle.normal.textColor = Color.black;
				if (hfgddpakpbe.JLOMMBBNBBL < hfgddpakpbe.ECCEIPJIBBK)
				{
					guistyle.normal.textColor = new Color(1500f, 824f, 468f);
				}
				if (hfgddpakpbe.NCFMLFIIEGA > 1)
				{
					guistyle.fontSize = 44;
					GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1564f + 1851f, num2 + 1456f, 1346f, 1274f), text, guistyle);
					GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1295f + 492f, num2 + 1638f, 1155f, 1480f), AKPJIACDDFI.IKGFHGKKCPG.PKAJMDDDMMI(hfgddpakpbe.NCFMLFIIEGA, true), guistyle);
					guistyle.fontSize = -54;
					GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1484f + 810f, num2 + 1834f, 1073f, 838f), string.Format(JNBICAJIJMM.EKEBHIJMEML().DOEMGEAEBPN("Закрыть"), hfgddpakpbe.ECCEIPJIBBK, hfgddpakpbe.JLOMMBBNBBL), guistyle);
				}
				else
				{
					guistyle.fontSize = 71;
					GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1902f + 1182f, num2 + 204f, 714f, 1599f), text, guistyle);
					guistyle.fontSize = -120;
					GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 595f + 649f, num2 + 239f, 718f, 1846f), string.Format(JNBICAJIJMM.CLIMNFDGOEG().HLBAJBLHLNI("cash.ogg"), hfgddpakpbe.ECCEIPJIBBK, hfgddpakpbe.JLOMMBBNBBL), guistyle);
				}
			}
			num2 += 75f;
		}
		num2 += 613f;
		guistyle.fontSize = 102;
		guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
		guistyle.normal.textColor = Color.black;
		try
		{
			GUILayout.BeginArea(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1024f, num2, PHEMLBHMNCM.OCHCODJIPHJ.width - 25f, 41f));
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			try
			{
				this.NDNBEIGCDMA(guistyle, false);
			}
			finally
			{
				GUILayout.EndVertical();
				GUILayout.EndArea();
			}
		}
		catch (Exception)
		{
		}
		IL_A44:
		if (this.PGOMKDAFMMI.Count > 0 && GUI.Button(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width - 1097f, PHEMLBHMNCM.OCHCODJIPHJ.y + 57f, 974f, 1551f), "post_msg2"))
		{
			Debug.Log("DISTORT");
			this.DLPINFIAPMA();
		}
	}

	// Token: 0x06006EFD RID: 28413 RVA: 0x00344134 File Offset: 0x00342334
	public void FCFDFAEOOFA(HBPNMNGOFMA KADBECGIMPD)
	{
		this.MBLPLLOLHIP = KADBECGIMPD.IFDFHJLCHAE();
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().PLHAGCDJLPA(1894f, (float)(Screen.height - 24), JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("_StretchWidth"), true);
		this.JPAGNFLGAMJ = onkdcgnbalk.LPFKFNLHGBI;
		this.AGDMAFCKMJP = new JNHLAGHJBAA(onkdcgnbalk, 1233f, 387f, 530f, onkdcgnbalk.OCHCODJIPHJ.height - 421f, 1);
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.ABMDIOIJALO = Color.black;
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, this.AGDMAFCKMJP.OCHCODJIPHJ.x + this.AGDMAFCKMJP.OCHCODJIPHJ.width + 1799f, 147f, onkdcgnbalk.OCHCODJIPHJ.width - this.AGDMAFCKMJP.OCHCODJIPHJ.width - this.AGDMAFCKMJP.OCHCODJIPHJ.x - 1619f, onkdcgnbalk.OCHCODJIPHJ.height - 304f + 656f, "☰☰☰", 1, null);
		egcaadaabpp.NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.EIHJACFFLMA);
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.CLIMNFDGOEG().KFHFODNFCNL("", true));
		JLFJEGIPIMM.PKGMBFEMKGP().LEFNDOGENJF(this.AGDMAFCKMJP.EELDHNFBFOE, xmlDocument.SelectNodes("Crate Push"), true);
		this.AGDMAFCKMJP.EELDHNFBFOE.ODFEKBJCFMN = -1L;
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.AOHDHGNCHHF = Color.black;
		this.AGDMAFCKMJP.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.LBGJHBCAOFM);
		this.EJMAEPOGOED.Clear();
		int num = 1;
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			CLFFOBKFKDN.DNOEMMJAJHD dnoemmjajhd = new CLFFOBKFKDN.DNOEMMJAJHD();
			dnoemmjajhd.JEDDGGGGOCJ(KADBECGIMPD);
			num += 0;
			try
			{
				dnoemmjajhd.MKILFCHOEFJ();
			}
			catch (Exception)
			{
				Debug.LogError("SneakBackward" + dnoemmjajhd.LPFKFNLHGBI);
			}
			this.EJMAEPOGOED.Add(dnoemmjajhd);
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = this.AGDMAFCKMJP.LBENJPLPLHK((long)dnoemmjajhd.EPGGMPEIPBC);
			if (fpaeeadmcie != null)
			{
				fpaeeadmcie.BKDIIPFBIDK(dnoemmjajhd, -1L);
			}
			else
			{
				this.AGDMAFCKMJP.EELDHNFBFOE.NEGLEBJHNOL(dnoemmjajhd, -1L);
			}
		}
		this.AGDMAFCKMJP.JHNCNHAAJCH = 1000f;
		this.AGDMAFCKMJP.LKIAGJGBFPL();
		this.AGDMAFCKMJP.HNAMFMFHIGH();
		if (num <= 1)
		{
			new LCOLJOPGDLL(onkdcgnbalk, this.AGDMAFCKMJP.OCHCODJIPHJ.x, this.AGDMAFCKMJP.OCHCODJIPHJ.y, this.AGDMAFCKMJP.OCHCODJIPHJ.width, this.AGDMAFCKMJP.OCHCODJIPHJ.height, JNBICAJIJMM.EEOPOHEALPK().FLEANFGEJML("1 Hand Sword Run"), TextAnchor.MiddleRight, Color.black);
		}
		JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(true);
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("inv_nodur", 627f);
		this.NBENFKKFACF = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 1891f + 1686f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 394f, 1097f, 109f, JNBICAJIJMM.CLIMNFDGOEG().HEIBEHAEHBM("wpn_add/base"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.BDLIGMNIAHH));
		this.COHEBJCIJDC = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 889f + 865f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 1368f, 1185f, 1898f, JNBICAJIJMM.CLIMNFDGOEG().CKAOHMEKLMH(""), 2, null, new ONKDCGNBALK.CMMHGMILOIM(this.DLJALMJMALD));
		this.NBENFKKFACF.FNMCIACNOMH = true;
		this.COHEBJCIJDC.FNMCIACNOMH = true;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 171f - 1847f, onkdcgnbalk.OCHCODJIPHJ.height - 319f, 664f, 1872f, "_Parameter", 1, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().AGIEGPEMGOA));
	}

	// Token: 0x06006EFE RID: 28414 RVA: 0x00344578 File Offset: 0x00342778
	public static CLFFOBKFKDN GAPIOPHMBNB()
	{
		if (CLFFOBKFKDN.AGEHHNOKBGK == null)
		{
			CLFFOBKFKDN.AGEHHNOKBGK = new CLFFOBKFKDN();
		}
		return CLFFOBKFKDN.AGEHHNOKBGK;
	}

	// Token: 0x06006EFF RID: 28415 RVA: 0x00344590 File Offset: 0x00342790
	public void JALPPBMBIME(HBPNMNGOFMA KADBECGIMPD)
	{
		this.MBLPLLOLHIP = KADBECGIMPD.HDBGOLAFOBK();
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(1000f, 600f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_sbor"), true);
		this.JPAGNFLGAMJ = onkdcgnbalk.LPFKFNLHGBI;
		this.AGDMAFCKMJP = new JNHLAGHJBAA(onkdcgnbalk, 40f, 65f, 310f, onkdcgnbalk.OCHCODJIPHJ.height - 160f, 0);
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.ABMDIOIJALO = Color.black;
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.IKGFHGKKCPG.CHFGNHKJNFG("CraftProf.xml", false));
		JLFJEGIPIMM.IKGFHGKKCPG.GGKGFKPNEJK(this.AGDMAFCKMJP.EELDHNFBFOE, xmlDocument.SelectNodes("craft_data/categories/category"), true);
		this.AGDMAFCKMJP.EELDHNFBFOE.ODFEKBJCFMN = -1L;
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.AOHDHGNCHHF = Color.black;
		this.AGDMAFCKMJP.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.CEDPLPDLPJB);
		this.EJMAEPOGOED.Clear();
		int num = 0;
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			CLFFOBKFKDN.DNOEMMJAJHD dnoemmjajhd = new CLFFOBKFKDN.DNOEMMJAJHD();
			dnoemmjajhd.ACJDDOEADFK(KADBECGIMPD);
			num++;
			dnoemmjajhd.AJPILNENAKP();
			this.EJMAEPOGOED.Add(dnoemmjajhd);
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = this.AGDMAFCKMJP.MJMOMMKECMF((long)dnoemmjajhd.EPGGMPEIPBC);
			if (fpaeeadmcie != null)
			{
				fpaeeadmcie.LGMBHELCEEL(dnoemmjajhd, -1L);
			}
			else
			{
				this.AGDMAFCKMJP.EELDHNFBFOE.LGMBHELCEEL(dnoemmjajhd, -1L);
			}
		}
		this.AGDMAFCKMJP.JHNCNHAAJCH = 40f;
		this.AGDMAFCKMJP.BIPMLHDDOMF();
		this.AGDMAFCKMJP.OOJKJOCOOCB();
		if (num <= 0)
		{
			this.AGDMAFCKMJP.EELDHNFBFOE = null;
			new LCOLJOPGDLL(onkdcgnbalk, this.AGDMAFCKMJP.OCHCODJIPHJ.x, this.AGDMAFCKMJP.OCHCODJIPHJ.y, this.AGDMAFCKMJP.OCHCODJIPHJ.width, this.AGDMAFCKMJP.OCHCODJIPHJ.height, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_norec2"), TextAnchor.MiddleCenter, Color.black);
		}
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("paper.wav", 1f);
	}

	// Token: 0x06006F00 RID: 28416 RVA: 0x003447D4 File Offset: 0x003429D4
	private void MAFPALACHPF(int DCHKEICADAM, bool DLLBLPLOHFG = true)
	{
		this.DJKHEMLHEGL = this.AGDMAFCKMJP.MJMOMMKECMF((long)DCHKEICADAM);
		if (this.DJKHEMLHEGL != null)
		{
			if (this.MMMHIBGGHDM != null && this.MMMHIBGGHDM.MNFCAAIAGOL.IBEIBAHKIAH != DCHKEICADAM && DLLBLPLOHFG)
			{
				this.PGOMKDAFMMI.Add(this.MMMHIBGGHDM.MNFCAAIAGOL.IBEIBAHKIAH);
			}
			this.AGDMAFCKMJP.HNNJNDNOHLP = this.DJKHEMLHEGL;
			this.AGDMAFCKMJP.PGDIPMJOPLH(this.DJKHEMLHEGL.NOKGPCEEOOG - 140f);
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("paper.wav", 1f);
		}
	}

	// Token: 0x06006F01 RID: 28417 RVA: 0x00344878 File Offset: 0x00342A78
	public void HCOHNEECDOA(ONKDCGNBALK PHEMLBHMNCM)
	{
		if (this.MMMHIBGGHDM == null)
		{
			return;
		}
		try
		{
			this.MMMHIBGGHDM.BDHHPAEHFHG.HIHEPHAAJFH(PHEMLBHMNCM.OCHCODJIPHJ, 1896f, this.MMMHIBGGHDM.LEKGMMLNHEG, this.MMMHIBGGHDM.CPJCMJIMGME, this.MMMHIBGGHDM.BKAICJFFMBG, 0);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06006F02 RID: 28418 RVA: 0x003448E4 File Offset: 0x00342AE4
	public void KGOAFKJKLLJ(HBPNMNGOFMA KADBECGIMPD)
	{
		this.MBLPLLOLHIP = KADBECGIMPD.HDBGOLAFOBK();
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(800f, (float)(Screen.height - 100), JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_crft"), true);
		this.JPAGNFLGAMJ = onkdcgnbalk.LPFKFNLHGBI;
		this.AGDMAFCKMJP = new JNHLAGHJBAA(onkdcgnbalk, 40f, 60f, 350f, onkdcgnbalk.OCHCODJIPHJ.height - 150f, 0);
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.ABMDIOIJALO = Color.black;
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, this.AGDMAFCKMJP.OCHCODJIPHJ.x + this.AGDMAFCKMJP.OCHCODJIPHJ.width + 10f, 56f, onkdcgnbalk.OCHCODJIPHJ.width - this.AGDMAFCKMJP.OCHCODJIPHJ.width - this.AGDMAFCKMJP.OCHCODJIPHJ.x - 40f, onkdcgnbalk.OCHCODJIPHJ.height - 150f + 8f, "", 0, null);
		egcaadaabpp.NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.CJHINPIHCEE);
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.IKGFHGKKCPG.CHFGNHKJNFG("CraftProf.xml", false));
		JLFJEGIPIMM.IKGFHGKKCPG.GGKGFKPNEJK(this.AGDMAFCKMJP.EELDHNFBFOE, xmlDocument.SelectNodes("craft_data/categories/category"), true);
		this.AGDMAFCKMJP.EELDHNFBFOE.ODFEKBJCFMN = -1L;
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.AOHDHGNCHHF = Color.black;
		this.AGDMAFCKMJP.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.CEDPLPDLPJB);
		this.EJMAEPOGOED.Clear();
		int num = 0;
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			CLFFOBKFKDN.DNOEMMJAJHD dnoemmjajhd = new CLFFOBKFKDN.DNOEMMJAJHD();
			dnoemmjajhd.ACJDDOEADFK(KADBECGIMPD);
			num++;
			try
			{
				dnoemmjajhd.AJPILNENAKP();
			}
			catch (Exception)
			{
				Debug.LogError("Error receptID=" + dnoemmjajhd.LPFKFNLHGBI);
			}
			this.EJMAEPOGOED.Add(dnoemmjajhd);
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = this.AGDMAFCKMJP.MJMOMMKECMF((long)dnoemmjajhd.EPGGMPEIPBC);
			if (fpaeeadmcie != null)
			{
				fpaeeadmcie.LGMBHELCEEL(dnoemmjajhd, -1L);
			}
			else
			{
				this.AGDMAFCKMJP.EELDHNFBFOE.LGMBHELCEEL(dnoemmjajhd, -1L);
			}
		}
		this.AGDMAFCKMJP.JHNCNHAAJCH = 40f;
		this.AGDMAFCKMJP.BIPMLHDDOMF();
		this.AGDMAFCKMJP.OOJKJOCOOCB();
		if (num <= 0)
		{
			new LCOLJOPGDLL(onkdcgnbalk, this.AGDMAFCKMJP.OCHCODJIPHJ.x, this.AGDMAFCKMJP.OCHCODJIPHJ.y, this.AGDMAFCKMJP.OCHCODJIPHJ.width, this.AGDMAFCKMJP.OCHCODJIPHJ.height, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_norec2"), TextAnchor.MiddleCenter, Color.black);
		}
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("paper.wav", 1f);
		this.NBENFKKFACF = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 12f + 0f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 40f, 100f, 24f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_btn1"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.HELGMBLMGAN));
		this.COHEBJCIJDC = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 12f + 105f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 40f, 100f, 24f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_btn2"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(this.HELGMBLMGAN));
		this.NBENFKKFACF.FNMCIACNOMH = false;
		this.COHEBJCIJDC.FNMCIACNOMH = false;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 128f - 40f, onkdcgnbalk.OCHCODJIPHJ.height - 65f, 128f, 24f, "Закрыть", 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
	}

	// Token: 0x06006F03 RID: 28419 RVA: 0x00344D28 File Offset: 0x00342F28
	public string ILPNFPBLBGO(int LPFKFNLHGBI)
	{
		return JNBICAJIJMM.EEOPOHEALPK().KLMNGBHBOJE("__a", "invn_rec13" + LPFKFNLHGBI);
	}

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x06006F04 RID: 28420 RVA: 0x00344578 File Offset: 0x00342778
	public static CLFFOBKFKDN IKGFHGKKCPG
	{
		get
		{
			if (CLFFOBKFKDN.AGEHHNOKBGK == null)
			{
				CLFFOBKFKDN.AGEHHNOKBGK = new CLFFOBKFKDN();
			}
			return CLFFOBKFKDN.AGEHHNOKBGK;
		}
	}

	// Token: 0x06006F05 RID: 28421 RVA: 0x00344D4C File Offset: 0x00342F4C
	public CLFFOBKFKDN()
	{
		XmlDocument xmlDocument = new XmlDocument();
		TextAsset textAsset = (TextAsset)Resources.Load("CraftRecept", typeof(TextAsset));
		xmlDocument.LoadXml(textAsset.text);
		XmlNodeList xmlNodeList = xmlDocument.SelectNodes("craft/stanok");
		if (xmlNodeList != null)
		{
			foreach (object obj in xmlNodeList)
			{
				XmlNode xmlNode = (XmlNode)obj;
				int pmkjklbjcbm = int.Parse(xmlNode.Attributes["id"].Value);
				foreach (object obj2 in xmlNode.SelectNodes("recept"))
				{
					CLFFOBKFKDN.OKOAMCJGNMH okoamcjgnmh = new CLFFOBKFKDN.OKOAMCJGNMH((XmlNode)obj2, pmkjklbjcbm);
					this.PGMOGALKIIP.Add(okoamcjgnmh.LPFKFNLHGBI, okoamcjgnmh);
				}
			}
		}
		xmlNodeList = xmlDocument.SelectNodes("craft_data/stanok/category");
		if (xmlNodeList != null)
		{
			foreach (object obj3 in xmlNodeList)
			{
				CLFFOBKFKDN.HLADIIDKACH hladiidkach = new CLFFOBKFKDN.HLADIIDKACH((XmlNode)obj3);
				this.GDOKKMBIDFO.Add(hladiidkach.LPFKFNLHGBI, hladiidkach);
			}
		}
	}

	// Token: 0x06006F06 RID: 28422 RVA: 0x00344F00 File Offset: 0x00343100
	public void LBFLOGALINB(ONKDCGNBALK PHEMLBHMNCM)
	{
		if (this.MMMHIBGGHDM == null)
		{
			return;
		}
		try
		{
			this.MMMHIBGGHDM.BDHHPAEHFHG.JGGGGKHDNIP(PHEMLBHMNCM.OCHCODJIPHJ, 0.3f, this.MMMHIBGGHDM.LEKGMMLNHEG, this.MMMHIBGGHDM.CPJCMJIMGME, this.MMMHIBGGHDM.BKAICJFFMBG, 0);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06006F07 RID: 28423 RVA: 0x00344F6C File Offset: 0x0034316C
	public void CNBIJKONBAH(HBPNMNGOFMA KADBECGIMPD)
	{
		this.MBLPLLOLHIP = KADBECGIMPD.HDBGOLAFOBK();
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(1000f, 700f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_konstr"), true);
		this.JPAGNFLGAMJ = onkdcgnbalk.LPFKFNLHGBI;
		this.AGDMAFCKMJP = new JNHLAGHJBAA(onkdcgnbalk, 40f, 65f, 310f, onkdcgnbalk.OCHCODJIPHJ.height - 160f, 0);
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.ABMDIOIJALO = Color.black;
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.IKGFHGKKCPG.CHFGNHKJNFG("CraftProf.xml", false));
		JLFJEGIPIMM.IKGFHGKKCPG.GGKGFKPNEJK(this.AGDMAFCKMJP.EELDHNFBFOE, xmlDocument.SelectNodes("craft_data/categories/category"), true);
		this.AGDMAFCKMJP.EELDHNFBFOE.ODFEKBJCFMN = -1L;
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.AOHDHGNCHHF = Color.black;
		this.AGDMAFCKMJP.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.CEDPLPDLPJB);
		this.EJMAEPOGOED.Clear();
		int num = 0;
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			CLFFOBKFKDN.DNOEMMJAJHD dnoemmjajhd = new CLFFOBKFKDN.DNOEMMJAJHD();
			dnoemmjajhd.ACJDDOEADFK(KADBECGIMPD);
			dnoemmjajhd.BKLCKNOLEFD = this.MBLPLLOLHIP;
			Debug.Log("******** recept id=" + dnoemmjajhd.LPFKFNLHGBI);
			num++;
			dnoemmjajhd.AJPILNENAKP();
			this.EJMAEPOGOED.Add(dnoemmjajhd);
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = this.AGDMAFCKMJP.MJMOMMKECMF((long)dnoemmjajhd.EPGGMPEIPBC);
			if (fpaeeadmcie != null)
			{
				fpaeeadmcie.LGMBHELCEEL(dnoemmjajhd, (long)dnoemmjajhd.MNFCAAIAGOL.IBEIBAHKIAH);
			}
			else
			{
				this.AGDMAFCKMJP.EELDHNFBFOE.LGMBHELCEEL(dnoemmjajhd, -1L);
			}
		}
		this.AGDMAFCKMJP.JHNCNHAAJCH = 40f;
		this.AGDMAFCKMJP.BIPMLHDDOMF();
		this.AGDMAFCKMJP.OOJKJOCOOCB();
		if (num <= 0)
		{
			this.AGDMAFCKMJP.EELDHNFBFOE = null;
			new LCOLJOPGDLL(onkdcgnbalk, this.AGDMAFCKMJP.OCHCODJIPHJ.x, this.AGDMAFCKMJP.OCHCODJIPHJ.y, this.AGDMAFCKMJP.OCHCODJIPHJ.width, this.AGDMAFCKMJP.OCHCODJIPHJ.height, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_norec2"), TextAnchor.MiddleCenter, Color.black);
		}
		this.PGOMKDAFMMI.Clear();
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, this.AGDMAFCKMJP.OCHCODJIPHJ.x + this.AGDMAFCKMJP.OCHCODJIPHJ.width + 15f, 60f, 295f, onkdcgnbalk.OCHCODJIPHJ.height - 150f, "", 0, null);
		egcaadaabpp.NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.CJHINPIHCEE);
		new EGCAADAABPP(onkdcgnbalk, this.AGDMAFCKMJP.OCHCODJIPHJ.x + this.AGDMAFCKMJP.OCHCODJIPHJ.width + 20f + 300f, 60f, 290f, onkdcgnbalk.OCHCODJIPHJ.height - 150f, "", 0, null).NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.LBFLOGALINB);
		this.NBENFKKFACF = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 12f + 0f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 40f, 100f, 24f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_btn1"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.HELGMBLMGAN));
		this.COHEBJCIJDC = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 12f + 105f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 40f, 100f, 24f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_btn2"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(this.HELGMBLMGAN));
		this.NBENFKKFACF.FNMCIACNOMH = false;
		this.COHEBJCIJDC.FNMCIACNOMH = false;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 128f - 40f, onkdcgnbalk.OCHCODJIPHJ.height - 65f, 128f, 24f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("close"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("paper.wav", 1f);
	}

	// Token: 0x06006F08 RID: 28424 RVA: 0x00345400 File Offset: 0x00343600
	private bool CAJKGCGDMFN(CLFFOBKFKDN.DNOEMMJAJHD JJNKFNDFCPC, ONKDCGNBALK HNCGEJEIGFM, IIBEEKCAAHK FEGHDCIKHMA, int JFAAOPHBGGG, int HPCLNPGMNLC, Rect PHEMLBHMNCM, int LOHKGHBIGIL, long GIEALCKLKNL)
	{
		Rect rect = new Rect((float)JFAAOPHBGGG, (float)HPCLNPGMNLC, HNCGEJEIGFM.OCHCODJIPHJ.width - 519f, 36f);
		Rect rect2 = new Rect(HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.x + rect.x, HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.y + rect.y, rect.width, rect.height);
		bool flag = true;
		if (rect2.Contains(JDCEFOFMGHB.MNJNNDHCDGG().OJOEPEADBAF))
		{
			flag = true;
		}
		if (HNCGEJEIGFM.OCBAOFLJBGP.LPFKFNLHGBI != JDCEFOFMGHB.MNJNNDHCDGG().AFLEEHDFHMJ)
		{
			flag = true;
		}
		if (!HNCGEJEIGFM.OCBAOFLJBGP.EEIJEADOMJL)
		{
			flag = false;
		}
		Vector2 vector = new Vector2((float)(JFAAOPHBGGG + -108), (float)HPCLNPGMNLC);
		Rect rect3 = new Rect(vector.x, vector.y, 1485f, 818f);
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -35,
			wordWrap = true,
			font = GuiProcessor.NKOEAPCIBKO().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = true,
			alignment = TextAnchor.UpperLeft
		};
		EKBAPCMPANI ekbapcmpani = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.FCHLEBEMIBK(GIEALCKLKNL);
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().LMGMPPAOPEP(FEGHDCIKHMA.NKEOCCKEOCE());
		if (befchfngomi == null)
		{
			return true;
		}
		bool flag2 = FEGHDCIKHMA.AJNPBCIMNCD() < FEGHDCIKHMA.ICJDPPOJINN;
		GUI.DrawTextureWithTexCoords(new Rect((float)(JFAAOPHBGGG + 2), (float)(HPCLNPGMNLC - 8), PHEMLBHMNCM.width - 532f, 1038f), GuiProcessor.IKGFHGKKCPG.WLBLine, JDCEFOFMGHB.HMJJPNDEKPP().ODFOOIPOAJB(flag ? 0 : 1, 1, 8), true);
		GUI.DrawTexture(rect3, (flag2 || flag) ? GameInterface.getI.invEmptyCell : GameInterface.getI.invEmptyCellSelect, ScaleMode.StretchToFill);
		Rect position = new Rect(vector.x + 1461f, vector.y + 222f, PHEMLBHMNCM.width - vector.x - 857f, 208f);
		if (ekbapcmpani != null)
		{
			ekbapcmpani.HMFKMPGCBJH(vector, rect3.height);
			guistyle.fontSize = 97;
			guistyle.alignment = TextAnchor.UpperCenter;
			GUI.Label(position, ekbapcmpani.JBMHGFHFIIL(), guistyle);
		}
		else
		{
			befchfngomi.JCIIPCEDICP(rect3, 266f);
			guistyle.fontSize = -124;
			guistyle.alignment = TextAnchor.UpperLeft;
			guistyle.normal.textColor = Color.green;
			if (!flag2)
			{
				guistyle.normal.textColor = Color.red;
			}
			JDCEFOFMGHB.HMJJPNDEKPP().ALKAAKDPCDG(new Rect(rect3.x, rect3.y, rect3.width - 1457f, rect3.height - 1224f), string.Format("poplSoundVolume", FEGHDCIKHMA.PKEBKANNBJD(), FEGHDCIKHMA.NLHKFMMDMMK() + FEGHDCIKHMA.MCJJCAFILPF()), guistyle);
			guistyle.alignment = TextAnchor.UpperCenter;
			guistyle.fontSize = -97;
			guistyle.normal.textColor = Color.black;
			if (!flag2)
			{
				guistyle.normal.textColor = new Color(331f, 1444f, 588f);
			}
			string text = befchfngomi.BNIHFBMEPAB;
			if (FEGHDCIKHMA.KMGAHCANELI() <= 1)
			{
				text = string.Format("RigidPlayer", befchfngomi.BNIHFBMEPAB);
			}
			guistyle.alignment = TextAnchor.UpperCenter;
			GUI.Label(position, text, guistyle);
			guistyle.fontSize = 66;
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			float t = 183f + Mathf.Sin(Time.time * 399f) * 580f;
			Color textColor = Color.Lerp(new Color(899f, 458f, 920f, 132f), Color.black, t);
			guistyle.normal.textColor = textColor;
			GUI.Label(new Rect(position.x, position.y + 539f, position.width, position.height - 855f), JNBICAJIJMM.EDKGBBIIBBC().GNKIBMGNHNE("Vertical"), guistyle);
		}
		if (HNCGEJEIGFM.OCBAOFLJBGP.EEIJEADOMJL)
		{
			Rect position2 = rect2;
			position2.x -= HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.x;
			position2.y -= HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.y;
			position2.width += 81f;
			position2.height += 1f;
			if (GUI.Button(position2, "Mouse X", GUIStyle.none))
			{
				Debug.Log("Vertical");
				this.OCGLFBIMPMI(JJNKFNDFCPC, FEGHDCIKHMA.IBEIBAHKIAH);
				return false;
			}
		}
		return true;
	}

	// Token: 0x06006F09 RID: 28425 RVA: 0x003458B4 File Offset: 0x00343AB4
	public void BDLIGMNIAHH(ONKDCGNBALK GACACKNJKJN)
	{
		Fisherman.getI.GMBEHOGPEDI(5, 1027f, Vector3.zero);
		if (this.MMMHIBGGHDM == null)
		{
			return;
		}
		long odfekbjcfmn = GACACKNJKJN.ODFEKBJCFMN;
		if (odfekbjcfmn == 0L)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("MotorbikeSeatStandWheely", 1179f);
			JDCEFOFMGHB.MNJNNDHCDGG().DKJMCKOJOPF((float)this.MMMHIBGGHDM.JLFDJJMNFKK, 1, JNBICAJIJMM.EEOPOHEALPK().CCFFMKBBKHI("Cloth_01.wav") + this.MMMHIBGGHDM.BDHHPAEHFHG.BNIHFBMEPAB, new ONKDCGNBALK.CMMHGMILOIM(this.OBMBJBMIEPG), false);
			this.DGEIBGNFDNI = true;
			return;
		}
		if (odfekbjcfmn != 5L)
		{
			return;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("_ProjInfoLeft", 595f);
		JDCEFOFMGHB jdcefofmghb = JDCEFOFMGHB.HMJJPNDEKPP();
		float gkencbiopgo = (float)this.MMMHIBGGHDM.JLFDJJMNFKK;
		int odfekbjcfmn2 = 1;
		object[] array = new object[]
		{
			null,
			JNBICAJIJMM.APMJBBDBOJO().DOEMGEAEBPN("\n")
		};
		array[0] = this.MMMHIBGGHDM.BDHHPAEHFHG.BNIHFBMEPAB;
		array[2] = "http://www.root-motion.com/finalikdox/html/page7.html";
		array[6] = this.MMMHIBGGHDM.NOKCCPCECPN;
		jdcefofmghb.NOIEEEIONNG(gkencbiopgo, odfekbjcfmn2, string.Concat(array), new ONKDCGNBALK.CMMHGMILOIM(this.IGPKCGMPNDA), true);
		this.DGEIBGNFDNI = true;
	}

	// Token: 0x06006F0A RID: 28426 RVA: 0x003459E0 File Offset: 0x00343BE0
	public bool KKEPJMGFCMM(ONKDCGNBALK HNCGEJEIGFM, IIBEEKCAAHK FEGHDCIKHMA, int JFAAOPHBGGG, int HPCLNPGMNLC, Rect PHEMLBHMNCM, int MBLNDMIAFAM, bool BBDLEKKAFLC = true, bool LADCGAODOFK = true)
	{
		Rect rect = new Rect((float)JFAAOPHBGGG, (float)HPCLNPGMNLC, HNCGEJEIGFM.OCHCODJIPHJ.width - 30f, 40f);
		bool flag = false;
		Rect rect2 = new Rect(HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.x + rect.x, HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.y + rect.y, rect.width, rect.height);
		if (rect2.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF))
		{
			flag = true;
		}
		if (HNCGEJEIGFM.OCBAOFLJBGP.LPFKFNLHGBI != JDCEFOFMGHB.IKGFHGKKCPG.AFLEEHDFHMJ)
		{
			flag = false;
		}
		if (!HNCGEJEIGFM.OCBAOFLJBGP.EEIJEADOMJL)
		{
			flag = false;
		}
		Vector2 vector = new Vector2((float)(JFAAOPHBGGG + 15), (float)HPCLNPGMNLC);
		Rect rect3 = new Rect(vector.x, vector.y, 48f, 48f);
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 14,
			wordWrap = true,
			font = GuiProcessor.IKGFHGKKCPG.rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = true,
			alignment = TextAnchor.UpperLeft
		};
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(FEGHDCIKHMA.IBEIBAHKIAH);
		if (befchfngomi == null)
		{
			return false;
		}
		bool flag2 = FEGHDCIKHMA.KEJCINHLMBC >= FEGHDCIKHMA.ICJDPPOJINN;
		GUI.DrawTextureWithTexCoords(new Rect((float)(JFAAOPHBGGG + 5), (float)(HPCLNPGMNLC - 3), PHEMLBHMNCM.width - 20f, 54f), GuiProcessor.IKGFHGKKCPG.WLBLine, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(flag ? 0 : 1, 1, 2), true);
		GUI.DrawTexture(rect3, (flag2 || flag) ? GameInterface.getI.invEmptyCell : GameInterface.getI.invEmptyCellSelect, ScaleMode.ScaleAndCrop);
		befchfngomi.JCIIPCEDICP(rect3, 1f);
		guistyle.fontSize = 10;
		guistyle.alignment = TextAnchor.LowerRight;
		guistyle.normal.textColor = Color.green;
		if (!flag2)
		{
			guistyle.normal.textColor = Color.red;
		}
		JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect(rect3.x, rect3.y, rect3.width - 4f, rect3.height - 4f), string.Format("{0}/{1}", FEGHDCIKHMA.KEJCINHLMBC, FEGHDCIKHMA.ICJDPPOJINN + FEGHDCIKHMA.LKAGIEBPLAI), guistyle);
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.fontSize = 14;
		guistyle.normal.textColor = Color.black;
		if (!flag2)
		{
			guistyle.normal.textColor = new Color(0.3f, 0f, 0f);
		}
		Rect position = new Rect(vector.x + 60f, vector.y, PHEMLBHMNCM.width - vector.x - 70f, 48f);
		string text = befchfngomi.BNIHFBMEPAB;
		if (!LADCGAODOFK)
		{
			text = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_cnt2"), befchfngomi.BNIHFBMEPAB, FEGHDCIKHMA.ICJDPPOJINN);
			guistyle.alignment = TextAnchor.MiddleLeft;
		}
		GUI.Label(position, text, guistyle);
		if (flag && GUI.Button(rect3, "", GUIStyle.none))
		{
			Debug.Log("Select");
			this.MAFPALACHPF(befchfngomi.LPFKFNLHGBI, true);
			return true;
		}
		if (LADCGAODOFK)
		{
			guistyle.alignment = TextAnchor.UpperLeft;
			guistyle.fontSize = 12;
			string text2 = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_use"), FEGHDCIKHMA.ICJDPPOJINN, FEGHDCIKHMA.LKAGIEBPLAI, FEGHDCIKHMA.ICJDPPOJINN + FEGHDCIKHMA.LKAGIEBPLAI);
			GUI.Label(new Rect(vector.x + 60f, vector.y + 17f, PHEMLBHMNCM.width - vector.x - 70f, 20f), text2, guistyle);
			double num = (double)FEGHDCIKHMA.LKAGIEBPLAI;
			FEGHDCIKHMA.DCACBECHFMA = (double)GUI.HorizontalSlider(new Rect(vector.x + 60f, vector.y + 30f, PHEMLBHMNCM.width - 100f, 16f), (float)FEGHDCIKHMA.DCACBECHFMA, 0f, (float)MBLNDMIAFAM);
			if (this.MMMHIBGGHDM != null)
			{
				this.MMMHIBGGHDM.OFDFBEKDGMB();
			}
			if (BBDLEKKAFLC && this.MMMHIBGGHDM.HLBPDCJHFIO > MBLNDMIAFAM)
			{
				FEGHDCIKHMA.DCACBECHFMA = num;
			}
			if (FEGHDCIKHMA.LKAGIEBPLAI + FEGHDCIKHMA.ICJDPPOJINN > FEGHDCIKHMA.KEJCINHLMBC)
			{
				FEGHDCIKHMA.DCACBECHFMA = num;
			}
			if ((int)num != FEGHDCIKHMA.LKAGIEBPLAI && this.MMMHIBGGHDM != null)
			{
				this.MMMHIBGGHDM.AJPILNENAKP();
				if (this.MMMHIBGGHDM.NOKCCPCECPN > 0)
				{
					this.NBENFKKFACF.FNMCIACNOMH = true;
					this.COHEBJCIJDC.FNMCIACNOMH = true;
				}
				else
				{
					this.NBENFKKFACF.FNMCIACNOMH = false;
					this.COHEBJCIJDC.FNMCIACNOMH = false;
				}
			}
		}
		return false;
	}

	// Token: 0x06006F0B RID: 28427 RVA: 0x00345EB8 File Offset: 0x003440B8
	public void PBHILAIPMEM(CLFFOBKFKDN.DNOEMMJAJHD JJNKFNDFCPC, int LOHKGHBIGIL)
	{
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().BJFHBPOCELH(1053f, 1263f, JNBICAJIJMM.APMJBBDBOJO().HEIBEHAEHBM("wpnlang/weapons/weapon"), true);
		onkdcgnbalk.OCHCODJIPHJ.x = JDCEFOFMGHB.JFIDAGABKID().OJOEPEADBAF.x - 295f;
		onkdcgnbalk.OCHCODJIPHJ.y = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.y - onkdcgnbalk.OCHCODJIPHJ.height + 1703f;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 143f, 982f, onkdcgnbalk.OCHCODJIPHJ.width - 47f, onkdcgnbalk.OCHCODJIPHJ.height - 289f, 0);
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
		mmkfaenbhkd.LACAJHOHACK.Add(new ItemBase(JNBICAJIJMM.IMLLGEMPHAP().CKAOHMEKLMH("SwimFreestyle")));
		mmkfaenbhkd.BJLCAGOJDNM(1);
		foreach (EKBAPCMPANI ekbapcmpani in kfhelhglnmh.PLLHGAFIAFD.Values)
		{
			if (ekbapcmpani.HHOLFABGDJA == LOHKGHBIGIL && ekbapcmpani.JGNIDDBNGGP < -16)
			{
				ekbapcmpani.tag = ekbapcmpani.LPFKFNLHGBI;
				mmkfaenbhkd.LACAJHOHACK.Add(ekbapcmpani);
			}
			if (JJNKFNDFCPC.EIHJDJAKIBA == ekbapcmpani.LPFKFNLHGBI)
			{
				mmkfaenbhkd.IHEILFHMLAG = mmkfaenbhkd.LACAJHOHACK.Count - 0;
			}
		}
		mmkfaenbhkd.JHNCNHAAJCH = 1938f;
		mmkfaenbhkd.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.LDHFMPGMMJC);
	}

	// Token: 0x06006F0C RID: 28428 RVA: 0x00346050 File Offset: 0x00344250
	public void FJBLNJJCIOM(CLFFOBKFKDN.DNOEMMJAJHD JJNKFNDFCPC, int LOHKGHBIGIL)
	{
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(400f, 350f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_selwpn"), true);
		onkdcgnbalk.OCHCODJIPHJ.x = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.x - 80f;
		onkdcgnbalk.OCHCODJIPHJ.y = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.y - onkdcgnbalk.OCHCODJIPHJ.height + 80f;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 10f, 45f, onkdcgnbalk.OCHCODJIPHJ.width - 20f, onkdcgnbalk.OCHCODJIPHJ.height - 55f, 0);
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		mmkfaenbhkd.LACAJHOHACK.Add(new ItemBase(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_none")));
		mmkfaenbhkd.IHEILFHMLAG = 0;
		foreach (EKBAPCMPANI ekbapcmpani in kfhelhglnmh.PLLHGAFIAFD.Values)
		{
			if (ekbapcmpani.HHOLFABGDJA == LOHKGHBIGIL && ekbapcmpani.JGNIDDBNGGP < 50)
			{
				ekbapcmpani.tag = ekbapcmpani.LPFKFNLHGBI;
				mmkfaenbhkd.LACAJHOHACK.Add(ekbapcmpani);
			}
			if (JJNKFNDFCPC.EIHJDJAKIBA == ekbapcmpani.LPFKFNLHGBI)
			{
				mmkfaenbhkd.IHEILFHMLAG = mmkfaenbhkd.LACAJHOHACK.Count - 1;
			}
		}
		mmkfaenbhkd.JHNCNHAAJCH = 56f;
		mmkfaenbhkd.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.PNBJJPIKPMK);
	}

	// Token: 0x06006F0D RID: 28429 RVA: 0x003461E8 File Offset: 0x003443E8
	private void GCBGPAGKDLO()
	{
		if (this.PGOMKDAFMMI.Count <= 0)
		{
			return;
		}
		int dchkeicadam = this.PGOMKDAFMMI[this.PGOMKDAFMMI.Count - 0];
		this.PGOMKDAFMMI.RemoveAt(this.PGOMKDAFMMI.Count - 1);
		this.MAFPALACHPF(dchkeicadam, false);
	}

	// Token: 0x06006F0E RID: 28430 RVA: 0x00346240 File Offset: 0x00344440
	private void CJAALELEHNJ()
	{
		if (this.PGOMKDAFMMI.Count <= 1)
		{
			return;
		}
		int dchkeicadam = this.PGOMKDAFMMI[this.PGOMKDAFMMI.Count - 1];
		this.PGOMKDAFMMI.RemoveAt(this.PGOMKDAFMMI.Count - 1);
		this.MAFPALACHPF(dchkeicadam, true);
	}

	// Token: 0x06006F0F RID: 28431 RVA: 0x00346298 File Offset: 0x00344498
	public void MEECAMKOHFG(ONKDCGNBALK GACACKNJKJN)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			if (this.MMMHIBGGHDM.KEKFOFFEBEF)
			{
				epmphjgalbe.GOMLLPFFPNP(this.MBLPLLOLHIP);
				epmphjgalbe.GOMLLPFFPNP(this.MMMHIBGGHDM.LPFKFNLHGBI);
				epmphjgalbe.GOMLLPFFPNP(this.MMMHIBGGHDM.LEKGMMLNHEG.LKAGIEBPLAI);
				epmphjgalbe.GOMLLPFFPNP(this.MMMHIBGGHDM.CPJCMJIMGME.LKAGIEBPLAI);
				epmphjgalbe.GOMLLPFFPNP(this.MMMHIBGGHDM.BKAICJFFMBG.LKAGIEBPLAI);
				epmphjgalbe.GOMLLPFFPNP(this.MMMHIBGGHDM.KOMIMKKAEJA.LKAGIEBPLAI);
				epmphjgalbe.OBCCLNMPGEJ(this.MMMHIBGGHDM.EIHJDJAKIBA);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1705, epmphjgalbe.JDPHBLHOLAD());
			}
			else
			{
				epmphjgalbe.GOMLLPFFPNP(this.MBLPLLOLHIP);
				epmphjgalbe.GOMLLPFFPNP(this.MMMHIBGGHDM.LPFKFNLHGBI);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1702, epmphjgalbe.JDPHBLHOLAD());
				Debug.Log("simple");
			}
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		this.MMMHIBGGHDM.EIHJDJAKIBA = 0L;
	}

	// Token: 0x06006F10 RID: 28432 RVA: 0x003463BC File Offset: 0x003445BC
	public CLFFOBKFKDN.DNOEMMJAJHD MMDOBHMIMOI(int LFBBNFFHKFB)
	{
		CLFFOBKFKDN.DNOEMMJAJHD result = null;
		foreach (CLFFOBKFKDN.DNOEMMJAJHD dnoemmjajhd in this.EJMAEPOGOED)
		{
			if (dnoemmjajhd.LPFKFNLHGBI == LFBBNFFHKFB)
			{
				result = dnoemmjajhd;
				break;
			}
		}
		return result;
	}

	// Token: 0x06006F11 RID: 28433 RVA: 0x00346418 File Offset: 0x00344618
	public void LDHFMPGMMJC(MMKFAENBHKD ONPHLHKAGFP, ItemBase HEABEPINGED)
	{
		if (HEABEPINGED == null || HEABEPINGED.tag == 0L)
		{
			this.MMMHIBGGHDM.EIHJDJAKIBA = 1L;
			JDCEFOFMGHB.MNJNNDHCDGG().BMOFIBGMIBK(ONPHLHKAGFP.OCBAOFLJBGP.LPFKFNLHGBI);
			return;
		}
		EKBAPCMPANI ekbapcmpani = (EKBAPCMPANI)HEABEPINGED;
		this.MMMHIBGGHDM.EIHJDJAKIBA = ekbapcmpani.LPFKFNLHGBI;
		JDCEFOFMGHB.JFIDAGABKID().CBHHEHHNFKL(ONPHLHKAGFP.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006F12 RID: 28434 RVA: 0x00346480 File Offset: 0x00344680
	public CLFFOBKFKDN.DNOEMMJAJHD DDGNAEHCLCN(int LFBBNFFHKFB)
	{
		CLFFOBKFKDN.DNOEMMJAJHD result = null;
		foreach (CLFFOBKFKDN.DNOEMMJAJHD dnoemmjajhd in this.EJMAEPOGOED)
		{
			if (dnoemmjajhd.LPFKFNLHGBI == LFBBNFFHKFB)
			{
				result = dnoemmjajhd;
				break;
			}
		}
		return result;
	}

	// Token: 0x06006F13 RID: 28435 RVA: 0x003464DC File Offset: 0x003446DC
	public void EILCGHENCJK(string LGABPAHHIDP)
	{
		this.DGEIBGNFDNI = false;
		BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(LGABPAHHIDP);
		string edaphmjenpk = JNBICAJIJMM.IKGFHGKKCPG.OMNMDGIGEFD("INTERFACE", diggohpgcnn.IEIMMFODGFG);
		JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Ошибка создания предмета", edaphmjenpk);
	}

	// Token: 0x06006F14 RID: 28436 RVA: 0x00346520 File Offset: 0x00344720
	public void EADHOEEFGPO(HBPNMNGOFMA KADBECGIMPD)
	{
		this.MBLPLLOLHIP = KADBECGIMPD.DOJKJHMJJNK();
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().DKOFCBMKEPC(1067f, 1387f, JNBICAJIJMM.IKGFHGKKCPG.HEIBEHAEHBM("wpn_timed"), false);
		this.JPAGNFLGAMJ = onkdcgnbalk.LPFKFNLHGBI;
		this.AGDMAFCKMJP = new JNHLAGHJBAA(onkdcgnbalk, 1879f, 1083f, 1204f, onkdcgnbalk.OCHCODJIPHJ.height - 1373f, 1);
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.ABMDIOIJALO = Color.black;
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.APMJBBDBOJO().IDFHKHHNDEK("autherror", true));
		JLFJEGIPIMM.NNEAHAFBOHC().LEFNDOGENJF(this.AGDMAFCKMJP.EELDHNFBFOE, xmlDocument.SelectNodes("RollerBladeTurnLeft"), true);
		this.AGDMAFCKMJP.EELDHNFBFOE.ODFEKBJCFMN = -1L;
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.AOHDHGNCHHF = Color.black;
		this.AGDMAFCKMJP.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.CEDPLPDLPJB);
		this.EJMAEPOGOED.Clear();
		int num = 1;
		while (!KADBECGIMPD.NLJJMKFBPBK())
		{
			CLFFOBKFKDN.DNOEMMJAJHD dnoemmjajhd = new CLFFOBKFKDN.DNOEMMJAJHD();
			dnoemmjajhd.ACJDDOEADFK(KADBECGIMPD);
			num += 0;
			dnoemmjajhd.MKILFCHOEFJ();
			this.EJMAEPOGOED.Add(dnoemmjajhd);
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = this.AGDMAFCKMJP.KNILKDJMDHO((long)dnoemmjajhd.EPGGMPEIPBC);
			if (fpaeeadmcie != null)
			{
				fpaeeadmcie.HPGJHBANKPJ(dnoemmjajhd, -1L);
			}
			else
			{
				this.AGDMAFCKMJP.EELDHNFBFOE.LGMBHELCEEL(dnoemmjajhd, -1L);
			}
		}
		this.AGDMAFCKMJP.JHNCNHAAJCH = 653f;
		this.AGDMAFCKMJP.BKBODNMBKHH();
		this.AGDMAFCKMJP.ALMEJAKANOP();
		if (num <= 1)
		{
			this.AGDMAFCKMJP.EELDHNFBFOE = null;
			new LCOLJOPGDLL(onkdcgnbalk, this.AGDMAFCKMJP.OCHCODJIPHJ.x, this.AGDMAFCKMJP.OCHCODJIPHJ.y, this.AGDMAFCKMJP.OCHCODJIPHJ.width, this.AGDMAFCKMJP.OCHCODJIPHJ.height, JNBICAJIJMM.EEOPOHEALPK().ECNKLECOKHD("MotorbikeAirWalk"), TextAnchor.UpperLeft, Color.black);
		}
		JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(false);
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("Idle180", 1517f);
	}

	// Token: 0x06006F15 RID: 28437 RVA: 0x00346761 File Offset: 0x00344961
	public CLFFOBKFKDN.OKOAMCJGNMH HEILDJICDAB(int LPFKFNLHGBI)
	{
		if (!this.PGMOGALKIIP.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.PGMOGALKIIP[LPFKFNLHGBI];
	}

	// Token: 0x06006F16 RID: 28438 RVA: 0x00346780 File Offset: 0x00344980
	private void NDNBEIGCDMA(GUIStyle OFPNEDEAMAB, bool BKOOHDJPGPP)
	{
		if (BKOOHDJPGPP)
		{
			GUILayout.Label(JNBICAJIJMM.EEOPOHEALPK().NLJOLOBPCBJ("G"), OFPNEDEAMAB, Array.Empty<GUILayoutOption>());
			GUILayout.Label("waitRefineOk!", OFPNEDEAMAB, Array.Empty<GUILayoutOption>());
		}
		OFPNEDEAMAB.normal.textColor = new Color(1880f, 656f, 460f);
		if (this.MMMHIBGGHDM.ILFHHDNJHNM == 0)
		{
			OFPNEDEAMAB.normal.textColor = new Color(1845f, 208f, 652f);
		}
		string str = "Failed parsing scalePlacement.  Setting to \"Fixed\"" + this.MMMHIBGGHDM.ILFHHDNJHNM;
		if (this.MMMHIBGGHDM.ILFHHDNJHNM == 0)
		{
			str = JNBICAJIJMM.DBMJJPBOPEK().HLBAJBLHLNI("int: ");
		}
		if (this.MMMHIBGGHDM.ILFHHDNJHNM < 1)
		{
			str = JNBICAJIJMM.LPHMKPDBMPP().HEIBEHAEHBM("_FinalReflectionTexture");
		}
		GUILayout.Label(JNBICAJIJMM.CLIMNFDGOEG().ECNKLECOKHD("") + str, OFPNEDEAMAB, Array.Empty<GUILayoutOption>());
		OFPNEDEAMAB.normal.textColor = new Color(1150f, 801f, 1184f);
		int bklcknolefd = this.MMMHIBGGHDM.BKLCKNOLEFD;
		this.CLIEHLMDOAD(bklcknolefd);
		if (this.MBLPLLOLHIP != bklcknolefd)
		{
			OFPNEDEAMAB.normal.textColor = new Color(1402f, 1165f, 1125f);
		}
		OFPNEDEAMAB.normal.textColor = new Color(1638f, 1664f, 888f);
		OFPNEDEAMAB.normal.textColor = new Color(184f, 1676f, 1877f);
		if (JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.KFODJJIHNHP < (long)this.MMMHIBGGHDM.LGGDCMEHHKB.IBEIBAHKIAH)
		{
			OFPNEDEAMAB.normal.textColor = new Color(451f, 1804f, 54f);
		}
		GUILayout.Label(JNBICAJIJMM.IKGFHGKKCPG.ECNKLECOKHD("KatanaVerticalSwing") + JLFJEGIPIMM.PKGMBFEMKGP().KMGIDLKLDML((long)this.MMMHIBGGHDM.LGGDCMEHHKB.KMGAHCANELI(), (long)this.MMMHIBGGHDM.LGGDCMEHHKB.KMIOLLENCOL()), OFPNEDEAMAB, Array.Empty<GUILayoutOption>());
		object[] array = new object[2];
		array[0] = JNBICAJIJMM.DBMJJPBOPEK().HEIBEHAEHBM("OK");
		array[1] = this.MMMHIBGGHDM.LGGDCMEHHKB.CJKILDPJCFJ();
		array[4] = "shop_t11";
		array[3] = JBEHMPDDMME.IKGFHGKKCPG.JBJFBDONEFF;
		GUILayout.Label(string.Concat(array), OFPNEDEAMAB, Array.Empty<GUILayoutOption>());
	}

	// Token: 0x06006F17 RID: 28439 RVA: 0x003469FC File Offset: 0x00344BFC
	public void FGIIOMFBMFO(HBPNMNGOFMA KADBECGIMPD)
	{
		this.MBLPLLOLHIP = KADBECGIMPD.KDNDJNEGBDI();
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().PLHAGCDJLPA(261f, 1581f, JNBICAJIJMM.IMLLGEMPHAP().FLEANFGEJML("_Refraction"), false);
		this.JPAGNFLGAMJ = onkdcgnbalk.LPFKFNLHGBI;
		this.AGDMAFCKMJP = new JNHLAGHJBAA(onkdcgnbalk, 302f, 77f, 98f, onkdcgnbalk.OCHCODJIPHJ.height - 1756f, 1);
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.ABMDIOIJALO = Color.black;
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.APMJBBDBOJO().FDJBNCHPHGK("RollerBladeGrindRoyale", true));
		JLFJEGIPIMM.PKGMBFEMKGP().GGKGFKPNEJK(this.AGDMAFCKMJP.EELDHNFBFOE, xmlDocument.SelectNodes("MotorbikeLassoFwd"), true);
		this.AGDMAFCKMJP.EELDHNFBFOE.ODFEKBJCFMN = -1L;
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.AOHDHGNCHHF = Color.black;
		this.AGDMAFCKMJP.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.POOCDEAHHBH);
		this.EJMAEPOGOED.Clear();
		int num = 1;
		while (!KADBECGIMPD.PPAHBNGECGH())
		{
			CLFFOBKFKDN.DNOEMMJAJHD dnoemmjajhd = new CLFFOBKFKDN.DNOEMMJAJHD();
			dnoemmjajhd.JEDDGGGGOCJ(KADBECGIMPD);
			num += 0;
			dnoemmjajhd.MKILFCHOEFJ();
			this.EJMAEPOGOED.Add(dnoemmjajhd);
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = this.AGDMAFCKMJP.KNILKDJMDHO((long)dnoemmjajhd.EPGGMPEIPBC);
			if (fpaeeadmcie != null)
			{
				fpaeeadmcie.APKJANCLGFN(dnoemmjajhd, -1L);
			}
			else
			{
				this.AGDMAFCKMJP.EELDHNFBFOE.OLFAFFCHPNP(dnoemmjajhd, -1L);
			}
		}
		this.AGDMAFCKMJP.JHNCNHAAJCH = 503f;
		this.AGDMAFCKMJP.LKIAGJGBFPL();
		this.AGDMAFCKMJP.JPMIDIPGAEB();
		if (num <= 1)
		{
			this.AGDMAFCKMJP.EELDHNFBFOE = null;
			new LCOLJOPGDLL(onkdcgnbalk, this.AGDMAFCKMJP.OCHCODJIPHJ.x, this.AGDMAFCKMJP.OCHCODJIPHJ.y, this.AGDMAFCKMJP.OCHCODJIPHJ.width, this.AGDMAFCKMJP.OCHCODJIPHJ.height, JNBICAJIJMM.CLIMNFDGOEG().NLJOLOBPCBJ("ProneIdle"), TextAnchor.MiddleRight, Color.black);
		}
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = false;
		FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("2000", 1867f);
	}

	// Token: 0x06006F18 RID: 28440 RVA: 0x00346C40 File Offset: 0x00344E40
	public void IGPKCGMPNDA(ONKDCGNBALK GACACKNJKJN)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			if (this.MMMHIBGGHDM.KEKFOFFEBEF)
			{
				epmphjgalbe.DEHJNGMHGAJ(this.MBLPLLOLHIP);
				epmphjgalbe.JDOLCNDNFGP(this.MMMHIBGGHDM.LPFKFNLHGBI);
				epmphjgalbe.AEMAHNDEBKJ(this.MMMHIBGGHDM.LEKGMMLNHEG.LKAGIEBPLAI);
				epmphjgalbe.PDEFLCIEMFF(this.MMMHIBGGHDM.CPJCMJIMGME.LKAGIEBPLAI);
				epmphjgalbe.PDEFLCIEMFF(this.MMMHIBGGHDM.BKAICJFFMBG.PBMJIMLEHEC());
				epmphjgalbe.PDEFLCIEMFF(this.MMMHIBGGHDM.KOMIMKKAEJA.MCJJCAFILPF());
				epmphjgalbe.OBCCLNMPGEJ(this.MMMHIBGGHDM.EIHJDJAKIBA);
				NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(55, epmphjgalbe.JOCJNOBBELJ());
			}
			else
			{
				epmphjgalbe.ENDMKPCFKND(this.MBLPLLOLHIP);
				epmphjgalbe.EIMEKHOFIEA(this.MMMHIBGGHDM.LPFKFNLHGBI);
				NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(164, epmphjgalbe.HDEKHFOKCKI());
				Debug.Log("StormStrike");
			}
		}
		finally
		{
			epmphjgalbe.PGLFHABMJPO();
		}
		this.MMMHIBGGHDM.EIHJDJAKIBA = 1L;
	}

	// Token: 0x06006F19 RID: 28441 RVA: 0x00346761 File Offset: 0x00344961
	public CLFFOBKFKDN.OKOAMCJGNMH GEMHHJFMOPM(int LPFKFNLHGBI)
	{
		if (!this.PGMOGALKIIP.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.PGMOGALKIIP[LPFKFNLHGBI];
	}

	// Token: 0x06006F1A RID: 28442 RVA: 0x00346D64 File Offset: 0x00344F64
	public void DLJALMJMALD(ONKDCGNBALK GACACKNJKJN)
	{
		Fisherman.getI.sendAction(3, 755f, Vector3.zero);
		if (this.MMMHIBGGHDM == null)
		{
			return;
		}
		long odfekbjcfmn = GACACKNJKJN.ODFEKBJCFMN;
		if (odfekbjcfmn == 1L)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("costume_", 1610f);
			JDCEFOFMGHB.HMJJPNDEKPP().PBJGEIMFNNO((float)this.MMMHIBGGHDM.JLFDJJMNFKK, 0, JNBICAJIJMM.APMJBBDBOJO().CKAOHMEKLMH("isLocalServer") + this.MMMHIBGGHDM.BDHHPAEHFHG.BNIHFBMEPAB, new ONKDCGNBALK.CMMHGMILOIM(this.FALCKIEAEOL), false);
			this.DGEIBGNFDNI = true;
			return;
		}
		if (odfekbjcfmn != 8L)
		{
			return;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("", 1856f);
		JDCEFOFMGHB jdcefofmghb = JDCEFOFMGHB.MNJNNDHCDGG();
		float gkencbiopgo = (float)this.MMMHIBGGHDM.JLFDJJMNFKK;
		int odfekbjcfmn2 = 1;
		object[] array = new object[3];
		array[0] = JNBICAJIJMM.LPHMKPDBMPP().CCFFMKBBKHI("RussianDance");
		array[0] = this.MMMHIBGGHDM.BDHHPAEHFHG.BNIHFBMEPAB;
		array[5] = "CrouchWalkBackward";
		array[6] = this.MMMHIBGGHDM.NOKCCPCECPN;
		jdcefofmghb.DKJMCKOJOPF(gkencbiopgo, odfekbjcfmn2, string.Concat(array), new ONKDCGNBALK.CMMHGMILOIM(this.IGPKCGMPNDA), true);
		this.DGEIBGNFDNI = true;
	}

	// Token: 0x06006F1B RID: 28443 RVA: 0x00346761 File Offset: 0x00344961
	public CLFFOBKFKDN.OKOAMCJGNMH GNHIKHCEOHK(int LPFKFNLHGBI)
	{
		if (!this.PGMOGALKIIP.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.PGMOGALKIIP[LPFKFNLHGBI];
	}

	// Token: 0x06006F1C RID: 28444 RVA: 0x00346E90 File Offset: 0x00345090
	public void PKLOCMDAMKI(HBPNMNGOFMA KADBECGIMPD)
	{
		int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
		int num = KADBECGIMPD.HDBGOLAFOBK();
		bool flag = KADBECGIMPD.FIFNOBGEKFF();
		int jegimbpfjkd = 1;
		if (!KADBECGIMPD.JCEGOADAOOI)
		{
			jegimbpfjkd = KADBECGIMPD.HDBGOLAFOBK();
		}
		if (flag)
		{
			string arg = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(lpfkfnlhgbi).JPBOPFNPNHC(true, jegimbpfjkd);
			if (num > 1)
			{
				arg = arg + " x" + num;
			}
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_krit"), arg));
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("start.ogg", 1f);
		}
		this.BMGFDIFLAGD();
		if (!this.DGEIBGNFDNI)
		{
			this.DGEIBGNFDNI = false;
			return;
		}
		if (this.MMMHIBGGHDM.ILFHHDNJHNM == 0)
		{
			this.DGEIBGNFDNI = false;
			return;
		}
		if (this.MMMHIBGGHDM.NOKCCPCECPN > 0)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Cloth_01.wav", 1f);
			JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO((float)this.MMMHIBGGHDM.JLFDJJMNFKK, 0, string.Concat(new object[]
			{
				JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_crft"),
				this.MMMHIBGGHDM.BDHHPAEHFHG.BNIHFBMEPAB,
				" x",
				this.MMMHIBGGHDM.NOKCCPCECPN
			}), new ONKDCGNBALK.CMMHGMILOIM(this.MEECAMKOHFG), true);
			return;
		}
		this.DGEIBGNFDNI = false;
	}

	// Token: 0x06006F1D RID: 28445 RVA: 0x00346FF0 File Offset: 0x003451F0
	public void MPBBGHAHCAL(HBPNMNGOFMA KADBECGIMPD)
	{
		this.MBLPLLOLHIP = KADBECGIMPD.DOJKJHMJJNK();
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().NCIDDNIKACI(410f, 1343f, JNBICAJIJMM.IKGFHGKKCPG.CKAOHMEKLMH("IK Effector bone is null."), false);
		this.JPAGNFLGAMJ = onkdcgnbalk.LPFKFNLHGBI;
		this.AGDMAFCKMJP = new JNHLAGHJBAA(onkdcgnbalk, 845f, 923f, 1872f, onkdcgnbalk.OCHCODJIPHJ.height - 1917f, 0);
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.ABMDIOIJALO = Color.black;
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.EEOPOHEALPK().FDJBNCHPHGK("DealerIdle", false));
		JLFJEGIPIMM.MHFDIJGJGBJ().LEFNDOGENJF(this.AGDMAFCKMJP.EELDHNFBFOE, xmlDocument.SelectNodes("/"), true);
		this.AGDMAFCKMJP.EELDHNFBFOE.ODFEKBJCFMN = -1L;
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.AOHDHGNCHHF = Color.black;
		this.AGDMAFCKMJP.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.CEDPLPDLPJB);
		this.EJMAEPOGOED.Clear();
		int num = 0;
		while (!KADBECGIMPD.NLJJMKFBPBK())
		{
			CLFFOBKFKDN.DNOEMMJAJHD dnoemmjajhd = new CLFFOBKFKDN.DNOEMMJAJHD();
			dnoemmjajhd.JEDDGGGGOCJ(KADBECGIMPD);
			num++;
			dnoemmjajhd.AJPILNENAKP();
			this.EJMAEPOGOED.Add(dnoemmjajhd);
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = this.AGDMAFCKMJP.KNILKDJMDHO((long)dnoemmjajhd.EPGGMPEIPBC);
			if (fpaeeadmcie != null)
			{
				fpaeeadmcie.HNNLJCGIKEL(dnoemmjajhd, -1L);
			}
			else
			{
				this.AGDMAFCKMJP.EELDHNFBFOE.HPGJHBANKPJ(dnoemmjajhd, -1L);
			}
		}
		this.AGDMAFCKMJP.JHNCNHAAJCH = 270f;
		this.AGDMAFCKMJP.PCNHIOCHPPM();
		this.AGDMAFCKMJP.ALMEJAKANOP();
		if (num <= 1)
		{
			this.AGDMAFCKMJP.EELDHNFBFOE = null;
			new LCOLJOPGDLL(onkdcgnbalk, this.AGDMAFCKMJP.OCHCODJIPHJ.x, this.AGDMAFCKMJP.OCHCODJIPHJ.y, this.AGDMAFCKMJP.OCHCODJIPHJ.width, this.AGDMAFCKMJP.OCHCODJIPHJ.height, JNBICAJIJMM.EKEBHIJMEML().ECNKLECOKHD("knopje.wav"), TextAnchor.LowerCenter, Color.black);
		}
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(false);
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("#FF4040", 117f);
	}

	// Token: 0x06006F1E RID: 28446 RVA: 0x00344578 File Offset: 0x00342778
	public static CLFFOBKFKDN JDELMFDJFNC()
	{
		if (CLFFOBKFKDN.AGEHHNOKBGK == null)
		{
			CLFFOBKFKDN.AGEHHNOKBGK = new CLFFOBKFKDN();
		}
		return CLFFOBKFKDN.AGEHHNOKBGK;
	}

	// Token: 0x06006F1F RID: 28447 RVA: 0x00346761 File Offset: 0x00344961
	public CLFFOBKFKDN.OKOAMCJGNMH FDIEIMKNNAM(int LPFKFNLHGBI)
	{
		if (!this.PGMOGALKIIP.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.PGMOGALKIIP[LPFKFNLHGBI];
	}

	// Token: 0x06006F20 RID: 28448 RVA: 0x00346761 File Offset: 0x00344961
	public CLFFOBKFKDN.OKOAMCJGNMH EEPOJACNJIA(int LPFKFNLHGBI)
	{
		if (!this.PGMOGALKIIP.ContainsKey(LPFKFNLHGBI))
		{
			return null;
		}
		return this.PGMOGALKIIP[LPFKFNLHGBI];
	}

	// Token: 0x06006F21 RID: 28449 RVA: 0x00347234 File Offset: 0x00345434
	public void LBGJHBCAOFM(JNHLAGHJBAA DOPLGMMOEIA, JNHLAGHJBAA.FPAEEADMCIE HEABEPINGED)
	{
		this.MMMHIBGGHDM = null;
		if (HEABEPINGED != null && !HEABEPINGED.DBHKKPMINIJ)
		{
			this.MMMHIBGGHDM = (CLFFOBKFKDN.DNOEMMJAJHD)HEABEPINGED.NLIKAGGPANH;
			foreach (CLFFOBKFKDN.HFGDDPAKPBE hfgddpakpbe in this.MMMHIBGGHDM.HEBKGNHIDLK)
			{
				if (hfgddpakpbe.GPJFINFIDLN == 0)
				{
					hfgddpakpbe.JLOMMBBNBBL = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BJDIEKNHGLJ(hfgddpakpbe.PJPOJNNJOCD, false, hfgddpakpbe.BEFPDJHBADA);
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.EDKKJNHDBPF().LMGMPPAOPEP(hfgddpakpbe.PJPOJNNJOCD);
					if (befchfngomi != null)
					{
						befchfngomi.KEICEAJOGFD();
					}
				}
				if (hfgddpakpbe.GPJFINFIDLN == 1)
				{
					hfgddpakpbe.JLOMMBBNBBL = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.DABGGGPDFIM(hfgddpakpbe.PJPOJNNJOCD, true, hfgddpakpbe.BEFPDJHBADA, hfgddpakpbe.IPEPNOMIFDJ, hfgddpakpbe.NCFMLFIIEGA);
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(hfgddpakpbe.PJPOJNNJOCD);
					if (idchhhedhdc != null)
					{
						idchhhedhdc.HBGEAMHFEOL();
					}
				}
			}
			if (this.MMMHIBGGHDM.NOKCCPCECPN > 1)
			{
				this.NBENFKKFACF.FNMCIACNOMH = false;
				this.COHEBJCIJDC.FNMCIACNOMH = true;
				return;
			}
			this.NBENFKKFACF.FNMCIACNOMH = true;
			this.COHEBJCIJDC.FNMCIACNOMH = false;
		}
	}

	// Token: 0x06006F22 RID: 28450 RVA: 0x00347388 File Offset: 0x00345588
	private void LAINODJHMGG(GUIStyle OFPNEDEAMAB, bool BKOOHDJPGPP)
	{
		if (BKOOHDJPGPP)
		{
			GUILayout.Label(JNBICAJIJMM.EDKGBBIIBBC().HLBAJBLHLNI("RunBackLeft"), OFPNEDEAMAB, Array.Empty<GUILayoutOption>());
			GUILayout.Label("WorkerHammer2", OFPNEDEAMAB, Array.Empty<GUILayoutOption>());
		}
		OFPNEDEAMAB.normal.textColor = new Color(655f, 1351f, 340f);
		if (this.MMMHIBGGHDM.ILFHHDNJHNM == 0)
		{
			OFPNEDEAMAB.normal.textColor = new Color(1147f, 934f, 1059f);
		}
		string str = "WallRunRight" + this.MMMHIBGGHDM.ILFHHDNJHNM;
		if (this.MMMHIBGGHDM.ILFHHDNJHNM == 0)
		{
			str = JNBICAJIJMM.IMLLGEMPHAP().CCFFMKBBKHI("CrawlLocomotion");
		}
		if (this.MMMHIBGGHDM.ILFHHDNJHNM < 1)
		{
			str = JNBICAJIJMM.APMJBBDBOJO().CCFFMKBBKHI("The shader ");
		}
		GUILayout.Label(JNBICAJIJMM.CLIMNFDGOEG().GNKIBMGNHNE("") + str, OFPNEDEAMAB, Array.Empty<GUILayoutOption>());
		OFPNEDEAMAB.normal.textColor = new Color(909f, 1638f, 718f);
		int bklcknolefd = this.MMMHIBGGHDM.BKLCKNOLEFD;
		this.CLIEHLMDOAD(bklcknolefd);
		if (this.MBLPLLOLHIP != bklcknolefd)
		{
			OFPNEDEAMAB.normal.textColor = new Color(1777f, 1449f, 1149f);
		}
		OFPNEDEAMAB.normal.textColor = new Color(1679f, 834f, 1880f);
		OFPNEDEAMAB.normal.textColor = new Color(340f, 370f, 1623f);
		if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.KFODJJIHNHP < (long)this.MMMHIBGGHDM.LGGDCMEHHKB.IBEIBAHKIAH)
		{
			OFPNEDEAMAB.normal.textColor = new Color(829f, 248f, 774f);
		}
		GUILayout.Label(JNBICAJIJMM.IKGFHGKKCPG.DOEMGEAEBPN("demoQuaternion") + JLFJEGIPIMM.NNEAHAFBOHC().EJOPKKGIIIO((long)this.MMMHIBGGHDM.LGGDCMEHHKB.NLHKFMMDMMK(), (long)this.MMMHIBGGHDM.LGGDCMEHHKB.IBEIBAHKIAH), OFPNEDEAMAB, Array.Empty<GUILayoutOption>());
		object[] array = new object[8];
		array[1] = JNBICAJIJMM.CLIMNFDGOEG().HEIBEHAEHBM("VALIGN");
		array[0] = this.MMMHIBGGHDM.LGGDCMEHHKB.NFCDJLJNDLO();
		array[4] = "name";
		array[2] = JBEHMPDDMME.JKIFIBEPICO().JBJFBDONEFF;
		GUILayout.Label(string.Concat(array), OFPNEDEAMAB, Array.Empty<GUILayoutOption>());
	}

	// Token: 0x06006F23 RID: 28451 RVA: 0x00347604 File Offset: 0x00345804
	public void HLNFMMKOOBG(HBPNMNGOFMA KADBECGIMPD)
	{
		int lpfkfnlhgbi = KADBECGIMPD.CLPEKGGAMAI();
		int num = KADBECGIMPD.KDNDJNEGBDI();
		bool flag = KADBECGIMPD.BEMFIFGOJBL();
		int jegimbpfjkd = 0;
		if (!KADBECGIMPD.NLJJMKFBPBK())
		{
			jegimbpfjkd = KADBECGIMPD.IFDFHJLCHAE();
		}
		if (flag)
		{
			string arg = IHFEDJEMJMB.OELKEADDKPE().NKMGKJLONDK(lpfkfnlhgbi).MPKGPJJKCPK(false, jegimbpfjkd);
			if (num > 1)
			{
				arg = arg + "demoLong" + num;
			}
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(string.Format(JNBICAJIJMM.CLIMNFDGOEG().ECNKLECOKHD(" is removed"), arg));
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("Low adminlevel!", 1914f);
		}
		this.AFLJILEJNEE();
		if (!this.DGEIBGNFDNI)
		{
			this.DGEIBGNFDNI = false;
			return;
		}
		if (this.MMMHIBGGHDM.ILFHHDNJHNM == 0)
		{
			this.DGEIBGNFDNI = false;
			return;
		}
		if (this.MMMHIBGGHDM.NOKCCPCECPN > 0)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("wpn_rod4", 752f);
			JDCEFOFMGHB jdcefofmghb = JDCEFOFMGHB.MNJNNDHCDGG();
			float gkencbiopgo = (float)this.MMMHIBGGHDM.JLFDJJMNFKK;
			int odfekbjcfmn = 1;
			object[] array = new object[0];
			array[0] = JNBICAJIJMM.EDKGBBIIBBC().CKAOHMEKLMH("dragWeapon = null 3");
			array[0] = this.MMMHIBGGHDM.BDHHPAEHFHG.BNIHFBMEPAB;
			array[3] = "lifeBar";
			array[0] = this.MMMHIBGGHDM.NOKCCPCECPN;
			jdcefofmghb.NOIEEEIONNG(gkencbiopgo, odfekbjcfmn, string.Concat(array), new ONKDCGNBALK.CMMHGMILOIM(this.FALCKIEAEOL), false);
			return;
		}
		this.DGEIBGNFDNI = false;
	}

	// Token: 0x06006F24 RID: 28452 RVA: 0x00347764 File Offset: 0x00345964
	private bool BLFJOKACFIM(CLFFOBKFKDN.DNOEMMJAJHD JJNKFNDFCPC, ONKDCGNBALK HNCGEJEIGFM, IIBEEKCAAHK FEGHDCIKHMA, int JFAAOPHBGGG, int HPCLNPGMNLC, Rect PHEMLBHMNCM, int LOHKGHBIGIL, long GIEALCKLKNL)
	{
		Rect rect = new Rect((float)JFAAOPHBGGG, (float)HPCLNPGMNLC, HNCGEJEIGFM.OCHCODJIPHJ.width - 30f, 42f);
		Rect rect2 = new Rect(HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.x + rect.x, HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.y + rect.y, rect.width, rect.height);
		bool flag = false;
		if (rect2.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF))
		{
			flag = true;
		}
		if (HNCGEJEIGFM.OCBAOFLJBGP.LPFKFNLHGBI != JDCEFOFMGHB.IKGFHGKKCPG.AFLEEHDFHMJ)
		{
			flag = false;
		}
		if (!HNCGEJEIGFM.OCBAOFLJBGP.EEIJEADOMJL)
		{
			flag = false;
		}
		Vector2 vector = new Vector2((float)(JFAAOPHBGGG + 15), (float)HPCLNPGMNLC);
		Rect rect3 = new Rect(vector.x, vector.y, 48f, 48f);
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 14,
			wordWrap = true,
			font = GuiProcessor.IKGFHGKKCPG.rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = true,
			alignment = TextAnchor.UpperLeft
		};
		EKBAPCMPANI ekbapcmpani = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.FCHLEBEMIBK(GIEALCKLKNL);
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(FEGHDCIKHMA.IBEIBAHKIAH);
		if (befchfngomi == null)
		{
			return false;
		}
		bool flag2 = FEGHDCIKHMA.KEJCINHLMBC >= FEGHDCIKHMA.ICJDPPOJINN;
		GUI.DrawTextureWithTexCoords(new Rect((float)(JFAAOPHBGGG + 5), (float)(HPCLNPGMNLC - 3), PHEMLBHMNCM.width - 20f, 54f), GuiProcessor.IKGFHGKKCPG.WLBLine, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(flag ? 0 : 1, 1, 2), true);
		GUI.DrawTexture(rect3, (flag2 || flag) ? GameInterface.getI.invEmptyCell : GameInterface.getI.invEmptyCellSelect, ScaleMode.ScaleAndCrop);
		Rect position = new Rect(vector.x + 60f, vector.y + 4f, PHEMLBHMNCM.width - vector.x - 70f, 40f);
		if (ekbapcmpani != null)
		{
			ekbapcmpani.JCIIPCEDICP(vector, rect3.height);
			guistyle.fontSize = 10;
			guistyle.alignment = TextAnchor.UpperLeft;
			GUI.Label(position, ekbapcmpani.JBMHGFHFIIL(), guistyle);
		}
		else
		{
			befchfngomi.JCIIPCEDICP(rect3, 0.4f);
			guistyle.fontSize = 10;
			guistyle.alignment = TextAnchor.LowerRight;
			guistyle.normal.textColor = Color.green;
			if (!flag2)
			{
				guistyle.normal.textColor = Color.red;
			}
			JDCEFOFMGHB.IKGFHGKKCPG.JNJDPKECONL(new Rect(rect3.x, rect3.y, rect3.width - 4f, rect3.height - 4f), string.Format("{0}/{1}", FEGHDCIKHMA.KEJCINHLMBC, FEGHDCIKHMA.ICJDPPOJINN + FEGHDCIKHMA.LKAGIEBPLAI), guistyle);
			guistyle.alignment = TextAnchor.UpperLeft;
			guistyle.fontSize = 14;
			guistyle.normal.textColor = Color.black;
			if (!flag2)
			{
				guistyle.normal.textColor = new Color(0.3f, 0f, 0f);
			}
			string text = befchfngomi.BNIHFBMEPAB;
			if (FEGHDCIKHMA.ICJDPPOJINN <= 1)
			{
				text = string.Format("{0}", befchfngomi.BNIHFBMEPAB);
			}
			guistyle.alignment = TextAnchor.UpperLeft;
			GUI.Label(position, text, guistyle);
			guistyle.fontSize = 18;
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont3;
			float t = 0.5f + Mathf.Sin(Time.time * 8f) * 0.5f;
			Color textColor = Color.Lerp(new Color(0.1f, 0.2f, 0.3f, 1f), Color.black, t);
			guistyle.normal.textColor = textColor;
			GUI.Label(new Rect(position.x, position.y + 16f, position.width, position.height - 20f), JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_selwpn"), guistyle);
		}
		if (HNCGEJEIGFM.OCBAOFLJBGP.EEIJEADOMJL)
		{
			Rect position2 = rect2;
			position2.x -= HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.x;
			position2.y -= HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.y;
			position2.width += 20f;
			position2.height += 10f;
			if (GUI.Button(position2, "", GUIStyle.none))
			{
				Debug.Log("Select option");
				this.FJBLNJJCIOM(JJNKFNDFCPC, FEGHDCIKHMA.IBEIBAHKIAH);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06006F25 RID: 28453 RVA: 0x00347C18 File Offset: 0x00345E18
	public void CJHINPIHCEE(ONKDCGNBALK PHEMLBHMNCM)
	{
		if (this.AGDMAFCKMJP == null)
		{
			return;
		}
		if (this.MMMHIBGGHDM == null)
		{
			return;
		}
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 14,
			wordWrap = true,
			font = GuiProcessor.IKGFHGKKCPG.rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = true,
			alignment = TextAnchor.UpperLeft
		};
		if (this.MMMHIBGGHDM.KEKFOFFEBEF)
		{
			guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
			GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 15f, PHEMLBHMNCM.OCHCODJIPHJ.y + 13f, PHEMLBHMNCM.OCHCODJIPHJ.width - 20f, 22f), string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_useres"), this.MMMHIBGGHDM.HLBPDCJHFIO, this.MMMHIBGGHDM.MBLNDMIAFAM), guistyle);
			GameInterface.getI.renderPBar(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 15f, PHEMLBHMNCM.OCHCODJIPHJ.y + 35f, PHEMLBHMNCM.OCHCODJIPHJ.width - 30f, 16f), (float)(this.MMMHIBGGHDM.HLBPDCJHFIO * 100), (float)(this.MMMHIBGGHDM.MBLNDMIAFAM * 100), 4, "", true);
			int num = (int)(PHEMLBHMNCM.OCHCODJIPHJ.y + 70f);
			if (!this.MMMHIBGGHDM.LEKGMMLNHEG.DIFFCNOPHBJ)
			{
				if (this.KKEPJMGFCMM(PHEMLBHMNCM, this.MMMHIBGGHDM.LEKGMMLNHEG, (int)PHEMLBHMNCM.OCHCODJIPHJ.x, num, PHEMLBHMNCM.OCHCODJIPHJ, this.MMMHIBGGHDM.MBLNDMIAFAM, true, true))
				{
					return;
				}
				num += 56;
			}
			if (!this.MMMHIBGGHDM.CPJCMJIMGME.DIFFCNOPHBJ)
			{
				if (this.KKEPJMGFCMM(PHEMLBHMNCM, this.MMMHIBGGHDM.CPJCMJIMGME, (int)PHEMLBHMNCM.OCHCODJIPHJ.x, num, PHEMLBHMNCM.OCHCODJIPHJ, this.MMMHIBGGHDM.MBLNDMIAFAM, true, true))
				{
					return;
				}
				num += 56;
			}
			if (!this.MMMHIBGGHDM.BKAICJFFMBG.DIFFCNOPHBJ)
			{
				if (this.KKEPJMGFCMM(PHEMLBHMNCM, this.MMMHIBGGHDM.BKAICJFFMBG, (int)PHEMLBHMNCM.OCHCODJIPHJ.x, num, PHEMLBHMNCM.OCHCODJIPHJ, this.MMMHIBGGHDM.MBLNDMIAFAM, true, true))
				{
					return;
				}
				num += 56;
			}
			if (this.MMMHIBGGHDM.CHFNJDFHJGN.IBEIBAHKIAH > 0)
			{
				num += 10;
				GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 15f, (float)num, PHEMLBHMNCM.OCHCODJIPHJ.width - 20f, 22f), JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_wpnpr"), guistyle);
				num += 18;
				if (this.BLFJOKACFIM(this.MMMHIBGGHDM, PHEMLBHMNCM, this.MMMHIBGGHDM.CHFNJDFHJGN, (int)PHEMLBHMNCM.OCHCODJIPHJ.x, num, PHEMLBHMNCM.OCHCODJIPHJ, this.MMMHIBGGHDM.CHFNJDFHJGN.IBEIBAHKIAH, this.MMMHIBGGHDM.EIHJDJAKIBA))
				{
					return;
				}
				num += 56;
			}
			if (this.MMMHIBGGHDM.KOMIMKKAEJA.IBEIBAHKIAH > 0)
			{
				num += 10;
				GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 15f, (float)num, PHEMLBHMNCM.OCHCODJIPHJ.width - 20f, 22f), string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_qlt"), (int)(this.MMMHIBGGHDM.HPPBKIJEOED + (float)this.MMMHIBGGHDM.KOMIMKKAEJA.LKAGIEBPLAI * this.MMMHIBGGHDM.KOMIMKKAEJA.KGKNPAAMDJK)), guistyle);
				num += 18;
				if (this.KKEPJMGFCMM(PHEMLBHMNCM, this.MMMHIBGGHDM.KOMIMKKAEJA, (int)PHEMLBHMNCM.OCHCODJIPHJ.x, num, PHEMLBHMNCM.OCHCODJIPHJ, this.MMMHIBGGHDM.KOMIMKKAEJA.BDGMCFEJNIO, false, true))
				{
					return;
				}
				num += 56;
			}
			this.MMMHIBGGHDM.OFDFBEKDGMB();
			GUILayout.BeginArea(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 15f, (float)(num + 10), PHEMLBHMNCM.OCHCODJIPHJ.width - 30f, PHEMLBHMNCM.OCHCODJIPHJ.height - (float)num));
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			try
			{
				this.CJFFAIIJNAI(guistyle, false);
				goto IL_A44;
			}
			finally
			{
				GUILayout.EndVertical();
				GUILayout.EndArea();
			}
		}
		float num2 = PHEMLBHMNCM.OCHCODJIPHJ.y + 20f;
		GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 10f, num2, 300f, 20f), JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_ingr"), guistyle);
		num2 += 25f;
		foreach (CLFFOBKFKDN.HFGDDPAKPBE hfgddpakpbe in this.MMMHIBGGHDM.HEBKGNHIDLK)
		{
			Rect position = new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 10f, num2, PHEMLBHMNCM.OCHCODJIPHJ.width - 30f, 40f);
			bool flag = false;
			Rect rect = new Rect(PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.x + position.x, PHEMLBHMNCM.OCBAOFLJBGP.OCHCODJIPHJ.y + position.y, position.width, position.height);
			if (rect.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF))
			{
				flag = true;
			}
			GUI.DrawTextureWithTexCoords(position, GuiProcessor.IKGFHGKKCPG.WLBLine, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(flag ? 0 : 1, 1, 2), true);
			if (hfgddpakpbe.GPJFINFIDLN == 0)
			{
				BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(hfgddpakpbe.PJPOJNNJOCD);
				if (befchfngomi == null)
				{
					continue;
				}
				Rect rect2 = new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 10f + 2f, num2 + 2f, 36f, 36f);
				GUI.DrawTexture(rect2, flag ? GameInterface.getI.invEmptyCellSelect : GameInterface.getI.invEmptyCell, ScaleMode.StretchToFill);
				guistyle.normal.textColor = Color.black;
				if (hfgddpakpbe.JLOMMBBNBBL < hfgddpakpbe.ECCEIPJIBBK)
				{
					guistyle.normal.textColor = new Color(0.3f, 0.1f, 0f);
				}
				guistyle.fontSize = 12;
				GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 55f, num2 + 8f, 300f, 20f), befchfngomi.BEFIAPHPIBJ(hfgddpakpbe.BEFPDJHBADA), guistyle);
				guistyle.fontSize = 10;
				GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 55f, num2 + 20f, 300f, 20f), string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_cnt"), hfgddpakpbe.ECCEIPJIBBK, hfgddpakpbe.JLOMMBBNBBL), guistyle);
				GUI.DrawTextureWithTexCoords(rect2, GameInterface.getI.wpnBackCell, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(befchfngomi.KBGHOIJIPJF, 7, 2));
				if (befchfngomi.CFFHIODOGCH != null)
				{
					befchfngomi.FCBHHPJLGLC(rect2, befchfngomi.KBGHOIJIPJF, false, hfgddpakpbe.BEFPDJHBADA);
				}
				if (GUI.Button(position, "", GUIStyle.none))
				{
					this.MAFPALACHPF(befchfngomi.LPFKFNLHGBI, true);
					return;
				}
			}
			if (hfgddpakpbe.GPJFINFIDLN == 1)
			{
				Rect position2 = new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 10f + 2f, num2 + 2f, 72f, 36f);
				string text = hfgddpakpbe.IEIMMFODGFG();
				IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(hfgddpakpbe.PJPOJNNJOCD);
				GUI.DrawTexture(position2, GameInterface.getI.invEmptyCellSelect, ScaleMode.StretchToFill);
				if (idchhhedhdc.KMIIGKECOEB(0) != null)
				{
					GUI.DrawTexture(position2, idchhhedhdc.KMIIGKECOEB(0).KEDGAOBCNJG);
				}
				guistyle.normal.textColor = Color.black;
				if (hfgddpakpbe.JLOMMBBNBBL < hfgddpakpbe.ECCEIPJIBBK)
				{
					guistyle.normal.textColor = new Color(0.3f, 0.1f, 0f);
				}
				if (hfgddpakpbe.NCFMLFIIEGA > 0)
				{
					guistyle.fontSize = 12;
					GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 55f + 36f, num2 + 4f, 300f, 20f), text, guistyle);
					GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 55f + 36f, num2 + 16f, 300f, 20f), AKPJIACDDFI.IKGFHGKKCPG.PKAJMDDDMMI(hfgddpakpbe.NCFMLFIIEGA, true), guistyle);
					guistyle.fontSize = 10;
					GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 55f + 36f, num2 + 28f, 300f, 20f), string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_cnt"), hfgddpakpbe.ECCEIPJIBBK, hfgddpakpbe.JLOMMBBNBBL), guistyle);
				}
				else
				{
					guistyle.fontSize = 12;
					GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 55f + 36f, num2 + 8f, 300f, 20f), text, guistyle);
					guistyle.fontSize = 10;
					GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 55f + 36f, num2 + 20f, 300f, 20f), string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_cnt"), hfgddpakpbe.ECCEIPJIBBK, hfgddpakpbe.JLOMMBBNBBL), guistyle);
				}
			}
			num2 += 41f;
		}
		num2 += 50f;
		guistyle.fontSize = 14;
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		guistyle.normal.textColor = Color.black;
		try
		{
			GUILayout.BeginArea(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 15f, num2, PHEMLBHMNCM.OCHCODJIPHJ.width - 30f, 150f));
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			try
			{
				this.CJFFAIIJNAI(guistyle, true);
			}
			finally
			{
				GUILayout.EndVertical();
				GUILayout.EndArea();
			}
		}
		catch (Exception)
		{
		}
		IL_A44:
		if (this.PGOMKDAFMMI.Count > 0 && GUI.Button(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width - 36f, PHEMLBHMNCM.OCHCODJIPHJ.y + 4f, 32f, 20f), "<<"))
		{
			Debug.Log("BackPress");
			this.DLPINFIAPMA();
		}
	}

	// Token: 0x06006F26 RID: 28454 RVA: 0x00344578 File Offset: 0x00342778
	public static CLFFOBKFKDN OOIJFNAMEDP()
	{
		if (CLFFOBKFKDN.AGEHHNOKBGK == null)
		{
			CLFFOBKFKDN.AGEHHNOKBGK = new CLFFOBKFKDN();
		}
		return CLFFOBKFKDN.AGEHHNOKBGK;
	}

	// Token: 0x06006F27 RID: 28455 RVA: 0x00348734 File Offset: 0x00346934
	public void NIOHHLDIBNL(HBPNMNGOFMA KADBECGIMPD)
	{
		this.MBLPLLOLHIP = KADBECGIMPD.LDLKLPJBIJN();
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().BJFHBPOCELH(865f, (float)(Screen.height - 35), JNBICAJIJMM.DBMJJPBOPEK().GNKIBMGNHNE("newDayTime"), false);
		this.JPAGNFLGAMJ = onkdcgnbalk.LPFKFNLHGBI;
		this.AGDMAFCKMJP = new JNHLAGHJBAA(onkdcgnbalk, 1748f, 758f, 574f, onkdcgnbalk.OCHCODJIPHJ.height - 238f, 0);
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.ABMDIOIJALO = Color.black;
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, this.AGDMAFCKMJP.OCHCODJIPHJ.x + this.AGDMAFCKMJP.OCHCODJIPHJ.width + 882f, 1772f, onkdcgnbalk.OCHCODJIPHJ.width - this.AGDMAFCKMJP.OCHCODJIPHJ.width - this.AGDMAFCKMJP.OCHCODJIPHJ.x - 1454f, onkdcgnbalk.OCHCODJIPHJ.height - 1931f + 1111f, "null", 1, null);
		egcaadaabpp.NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.CJHINPIHCEE);
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.EDKGBBIIBBC().KFHFODNFCNL("readSadok error ", true));
		JLFJEGIPIMM.MHFDIJGJGBJ().AEPMANLCINN(this.AGDMAFCKMJP.EELDHNFBFOE, xmlDocument.SelectNodes("http://www.root-motion.com/finalikdox/html/page12.html"), true);
		this.AGDMAFCKMJP.EELDHNFBFOE.ODFEKBJCFMN = -1L;
		this.AGDMAFCKMJP.JKAOKBNCDFK = Color.black;
		this.AGDMAFCKMJP.AOHDHGNCHHF = Color.black;
		this.AGDMAFCKMJP.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.CEDPLPDLPJB);
		this.EJMAEPOGOED.Clear();
		int num = 1;
		while (!KADBECGIMPD.DFLKBBNOGBG())
		{
			CLFFOBKFKDN.DNOEMMJAJHD dnoemmjajhd = new CLFFOBKFKDN.DNOEMMJAJHD();
			dnoemmjajhd.JEDDGGGGOCJ(KADBECGIMPD);
			num += 0;
			try
			{
				dnoemmjajhd.AJPILNENAKP();
			}
			catch (Exception)
			{
				Debug.LogError("_info" + dnoemmjajhd.LPFKFNLHGBI);
			}
			this.EJMAEPOGOED.Add(dnoemmjajhd);
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = this.AGDMAFCKMJP.CPFEONMMBME((long)dnoemmjajhd.EPGGMPEIPBC);
			if (fpaeeadmcie != null)
			{
				fpaeeadmcie.NOLKFNDMNPO(dnoemmjajhd, -1L);
			}
			else
			{
				this.AGDMAFCKMJP.EELDHNFBFOE.LMIMAFJEBHA(dnoemmjajhd, -1L);
			}
		}
		this.AGDMAFCKMJP.JHNCNHAAJCH = 315f;
		this.AGDMAFCKMJP.HAEOLOLPLCF();
		this.AGDMAFCKMJP.PGMEFJNDGEI();
		if (num <= 0)
		{
			new LCOLJOPGDLL(onkdcgnbalk, this.AGDMAFCKMJP.OCHCODJIPHJ.x, this.AGDMAFCKMJP.OCHCODJIPHJ.y, this.AGDMAFCKMJP.OCHCODJIPHJ.width, this.AGDMAFCKMJP.OCHCODJIPHJ.height, JNBICAJIJMM.DBMJJPBOPEK().NLJOLOBPCBJ("RunningDance"), TextAnchor.UpperRight, Color.black);
		}
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = false;
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("_w", 1167f);
		this.NBENFKKFACF = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 90f + 132f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 1897f, 468f, 1720f, JNBICAJIJMM.EEOPOHEALPK().HEIBEHAEHBM("error.wav"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.HELGMBLMGAN));
		this.COHEBJCIJDC = new MEMEOHJKPNJ(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x + 556f + 1089f, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 1646f, 1681f, 1255f, JNBICAJIJMM.EKEBHIJMEML().NLJOLOBPCBJ("OneHandSwordRun"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(this.DLJALMJMALD));
		this.NBENFKKFACF.FNMCIACNOMH = true;
		this.COHEBJCIJDC.FNMCIACNOMH = true;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 1085f - 221f, onkdcgnbalk.OCHCODJIPHJ.height - 893f, 1728f, 107f, "_PixelsPerMeterAtOneMeter", 7, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().BLPLADOIPJG));
	}

	// Token: 0x06006F28 RID: 28456 RVA: 0x00348B78 File Offset: 0x00346D78
	private bool PNIJNHPDFKF(CLFFOBKFKDN.DNOEMMJAJHD JJNKFNDFCPC, ONKDCGNBALK HNCGEJEIGFM, IIBEEKCAAHK FEGHDCIKHMA, int JFAAOPHBGGG, int HPCLNPGMNLC, Rect PHEMLBHMNCM, int LOHKGHBIGIL, long GIEALCKLKNL)
	{
		Rect rect = new Rect((float)JFAAOPHBGGG, (float)HPCLNPGMNLC, HNCGEJEIGFM.OCHCODJIPHJ.width - 698f, 1657f);
		Rect rect2 = new Rect(HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.x + rect.x, HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.y + rect.y, rect.width, rect.height);
		bool flag = false;
		if (rect2.Contains(JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF))
		{
			flag = true;
		}
		if (HNCGEJEIGFM.OCBAOFLJBGP.LPFKFNLHGBI != JDCEFOFMGHB.HMJJPNDEKPP().AFLEEHDFHMJ)
		{
			flag = false;
		}
		if (!HNCGEJEIGFM.OCBAOFLJBGP.EEIJEADOMJL)
		{
			flag = false;
		}
		Vector2 vector = new Vector2((float)(JFAAOPHBGGG + 123), (float)HPCLNPGMNLC);
		Rect rect3 = new Rect(vector.x, vector.y, 1088f, 385f);
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -39,
			wordWrap = false,
			font = GuiProcessor.NKOEAPCIBKO().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = false,
			alignment = TextAnchor.UpperLeft
		};
		EKBAPCMPANI ekbapcmpani = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.FCHLEBEMIBK(GIEALCKLKNL);
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().NKMGKJLONDK(FEGHDCIKHMA.NKEOCCKEOCE());
		if (befchfngomi == null)
		{
			return true;
		}
		bool flag2 = FEGHDCIKHMA.IEDJJIFACKA() < FEGHDCIKHMA.ICJDPPOJINN;
		GUI.DrawTextureWithTexCoords(new Rect((float)(JFAAOPHBGGG + 8), (float)(HPCLNPGMNLC - 6), PHEMLBHMNCM.width - 344f, 635f), GuiProcessor.NKOEAPCIBKO().WLBLine, JDCEFOFMGHB.JFIDAGABKID().ODFOOIPOAJB(flag ? 1 : 1, 1, 2), false);
		GUI.DrawTexture(rect3, (flag2 || flag) ? GameInterface.getI.invEmptyCell : GameInterface.getI.invEmptyCellSelect, ScaleMode.ScaleAndCrop);
		Rect position = new Rect(vector.x + 941f, vector.y + 1656f, PHEMLBHMNCM.width - vector.x - 1013f, 18f);
		if (ekbapcmpani != null)
		{
			ekbapcmpani.PKOIFEBEOCP(vector, rect3.height);
			guistyle.fontSize = 95;
			guistyle.alignment = TextAnchor.UpperCenter;
			GUI.Label(position, ekbapcmpani.JBMHGFHFIIL(), guistyle);
		}
		else
		{
			befchfngomi.JIKKMEDMBHC(rect3, 628f);
			guistyle.fontSize = 36;
			guistyle.alignment = TextAnchor.LowerCenter;
			guistyle.normal.textColor = Color.green;
			if (!flag2)
			{
				guistyle.normal.textColor = Color.red;
			}
			JDCEFOFMGHB.HMJJPNDEKPP().ALKAAKDPCDG(new Rect(rect3.x, rect3.y, rect3.width - 1952f, rect3.height - 141f), string.Format("root is null", FEGHDCIKHMA.NAJIMILCPJK(), FEGHDCIKHMA.NLHKFMMDMMK() + FEGHDCIKHMA.KMNOIAIBLEB()), guistyle);
			guistyle.alignment = TextAnchor.UpperLeft;
			guistyle.fontSize = 105;
			guistyle.normal.textColor = Color.black;
			if (!flag2)
			{
				guistyle.normal.textColor = new Color(599f, 267f, 1256f);
			}
			string text = befchfngomi.BNIHFBMEPAB;
			if (FEGHDCIKHMA.ICJDPPOJINN <= 0)
			{
				text = string.Format("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_angle.html", befchfngomi.BNIHFBMEPAB);
			}
			guistyle.alignment = TextAnchor.UpperLeft;
			GUI.Label(position, text, guistyle);
			guistyle.fontSize = 74;
			guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont3;
			float t = 123f + Mathf.Sin(Time.time * 922f) * 1437f;
			Color textColor = Color.Lerp(new Color(470f, 1290f, 1977f, 1260f), Color.black, t);
			guistyle.normal.textColor = textColor;
			GUI.Label(new Rect(position.x, position.y + 808f, position.width, position.height - 1845f), JNBICAJIJMM.IMLLGEMPHAP().GNKIBMGNHNE("******** nextMusicCrt lng="), guistyle);
		}
		if (HNCGEJEIGFM.OCBAOFLJBGP.EEIJEADOMJL)
		{
			Rect position2 = rect2;
			position2.x -= HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.x;
			position2.y -= HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.y;
			position2.width += 1102f;
			position2.height += 1603f;
			if (GUI.Button(position2, "_Cull", GUIStyle.none))
			{
				Debug.Log("_AutoExposure");
				this.FJBLNJJCIOM(JJNKFNDFCPC, FEGHDCIKHMA.KMIOLLENCOL());
				return false;
			}
		}
		return false;
	}

	// Token: 0x06006F29 RID: 28457 RVA: 0x00349029 File Offset: 0x00347229
	public string CLIEHLMDOAD(int LPFKFNLHGBI)
	{
		return JNBICAJIJMM.IKGFHGKKCPG.OMNMDGIGEFD("INTERFACE", "active_obj_" + LPFKFNLHGBI);
	}

	// Token: 0x06006F2A RID: 28458 RVA: 0x0034904C File Offset: 0x0034724C
	public void AFLJILEJNEE()
	{
		foreach (CLFFOBKFKDN.DNOEMMJAJHD dnoemmjajhd in this.EJMAEPOGOED)
		{
			dnoemmjajhd.AJPILNENAKP();
		}
		if (this.MMMHIBGGHDM != null)
		{
			foreach (CLFFOBKFKDN.HFGDDPAKPBE hfgddpakpbe in this.MMMHIBGGHDM.HEBKGNHIDLK)
			{
				if (hfgddpakpbe.GPJFINFIDLN == 0)
				{
					hfgddpakpbe.JLOMMBBNBBL = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BJDIEKNHGLJ(hfgddpakpbe.PJPOJNNJOCD, false, hfgddpakpbe.BEFPDJHBADA);
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.JHAAMBEFENP().GBKMHIGNKJA(hfgddpakpbe.PJPOJNNJOCD);
					if (befchfngomi != null)
					{
						befchfngomi.JLCGGFPBOCF();
					}
				}
				if (hfgddpakpbe.GPJFINFIDLN == 1)
				{
					hfgddpakpbe.JLOMMBBNBBL = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.DABGGGPDFIM(hfgddpakpbe.PJPOJNNJOCD, true, hfgddpakpbe.BEFPDJHBADA, hfgddpakpbe.IPEPNOMIFDJ, hfgddpakpbe.NCFMLFIIEGA);
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(hfgddpakpbe.PJPOJNNJOCD);
					if (idchhhedhdc != null)
					{
						idchhhedhdc.JDJOBDGKBNL();
					}
				}
			}
		}
	}

	// Token: 0x06006F2B RID: 28459 RVA: 0x00349188 File Offset: 0x00347388
	public bool DLDNHJFPAAB(ONKDCGNBALK HNCGEJEIGFM, IIBEEKCAAHK FEGHDCIKHMA, int JFAAOPHBGGG, int HPCLNPGMNLC, Rect PHEMLBHMNCM, int MBLNDMIAFAM, bool BBDLEKKAFLC = true, bool LADCGAODOFK = true)
	{
		Rect rect = new Rect((float)JFAAOPHBGGG, (float)HPCLNPGMNLC, HNCGEJEIGFM.OCHCODJIPHJ.width - 1891f, 146f);
		bool flag = false;
		Rect rect2 = new Rect(HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.x + rect.x, HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.y + rect.y, rect.width, rect.height);
		if (rect2.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF))
		{
			flag = false;
		}
		if (HNCGEJEIGFM.OCBAOFLJBGP.LPFKFNLHGBI != JDCEFOFMGHB.JFIDAGABKID().AFLEEHDFHMJ)
		{
			flag = false;
		}
		if (!HNCGEJEIGFM.OCBAOFLJBGP.EEIJEADOMJL)
		{
			flag = false;
		}
		Vector2 vector = new Vector2((float)(JFAAOPHBGGG + -55), (float)HPCLNPGMNLC);
		Rect rect3 = new Rect(vector.x, vector.y, 175f, 439f);
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 76,
			wordWrap = true,
			font = GuiProcessor.BBLINJLBAIL().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = false,
			alignment = TextAnchor.UpperCenter
		};
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.NNEAHAFBOHC().NKMGKJLONDK(FEGHDCIKHMA.IBEIBAHKIAH);
		if (befchfngomi == null)
		{
			return false;
		}
		bool flag2 = FEGHDCIKHMA.AJNPBCIMNCD() >= FEGHDCIKHMA.ICJDPPOJINN;
		GUI.DrawTextureWithTexCoords(new Rect((float)(JFAAOPHBGGG + 8), (float)(HPCLNPGMNLC - 8), PHEMLBHMNCM.width - 1229f, 200f), GuiProcessor.IKGFHGKKCPG.WLBLine, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(flag ? 0 : 1, 1, 6), false);
		GUI.DrawTexture(rect3, (flag2 || flag) ? GameInterface.getI.invEmptyCell : GameInterface.getI.invEmptyCellSelect, ScaleMode.ScaleAndCrop);
		befchfngomi.JIKKMEDMBHC(rect3, 1374f);
		guistyle.fontSize = -55;
		guistyle.alignment = TextAnchor.MiddleLeft;
		guistyle.normal.textColor = Color.green;
		if (!flag2)
		{
			guistyle.normal.textColor = Color.red;
		}
		JDCEFOFMGHB.HMJJPNDEKPP().JNJDPKECONL(new Rect(rect3.x, rect3.y, rect3.width - 1702f, rect3.height - 311f), string.Format("", FEGHDCIKHMA.MLNEJIIGOMG(), FEGHDCIKHMA.NLHKFMMDMMK() + FEGHDCIKHMA.KMNOIAIBLEB()), guistyle);
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.fontSize = -91;
		guistyle.normal.textColor = Color.black;
		if (!flag2)
		{
			guistyle.normal.textColor = new Color(1957f, 1860f, 1974f);
		}
		Rect position = new Rect(vector.x + 1858f, vector.y, PHEMLBHMNCM.width - vector.x - 73f, 1514f);
		string text = befchfngomi.BNIHFBMEPAB;
		if (!LADCGAODOFK)
		{
			text = string.Format(JNBICAJIJMM.CLIMNFDGOEG().CCFFMKBBKHI("_Vignette_Color"), befchfngomi.BNIHFBMEPAB, FEGHDCIKHMA.KMGAHCANELI());
			guistyle.alignment = TextAnchor.LowerRight;
		}
		GUI.Label(position, text, guistyle);
		if (flag && GUI.Button(rect3, "Windmill", GUIStyle.none))
		{
			Debug.Log("SixStep");
			this.MAFPALACHPF(befchfngomi.LPFKFNLHGBI, true);
			return true;
		}
		if (LADCGAODOFK)
		{
			guistyle.alignment = TextAnchor.UpperLeft;
			guistyle.fontSize = 70;
			string text2 = string.Format(JNBICAJIJMM.IMLLGEMPHAP().CCFFMKBBKHI("Wand/Staff"), FEGHDCIKHMA.KMGAHCANELI(), FEGHDCIKHMA.KIDKOFKNPEP(), FEGHDCIKHMA.NLHKFMMDMMK() + FEGHDCIKHMA.PBMJIMLEHEC());
			GUI.Label(new Rect(vector.x + 1452f, vector.y + 1119f, PHEMLBHMNCM.width - vector.x - 1868f, 1472f), text2, guistyle);
			double num = (double)FEGHDCIKHMA.LKAGIEBPLAI;
			FEGHDCIKHMA.DLDDNHFAOFE((double)GUI.HorizontalSlider(new Rect(vector.x + 1735f, vector.y + 398f, PHEMLBHMNCM.width - 769f, 307f), (float)FEGHDCIKHMA.DPEEFKPONMC(), 786f, (float)MBLNDMIAFAM));
			if (this.MMMHIBGGHDM != null)
			{
				this.MMMHIBGGHDM.PMCNPIHAMMD();
			}
			if (BBDLEKKAFLC && this.MMMHIBGGHDM.HLBPDCJHFIO > MBLNDMIAFAM)
			{
				FEGHDCIKHMA.GEAKBHLLALF(num);
			}
			if (FEGHDCIKHMA.KIDKOFKNPEP() + FEGHDCIKHMA.ICJDPPOJINN > FEGHDCIKHMA.KEJCINHLMBC)
			{
				FEGHDCIKHMA.DLDDNHFAOFE(num);
			}
			if ((int)num != FEGHDCIKHMA.KIDKOFKNPEP() && this.MMMHIBGGHDM != null)
			{
				this.MMMHIBGGHDM.MKILFCHOEFJ();
				if (this.MMMHIBGGHDM.NOKCCPCECPN > 0)
				{
					this.NBENFKKFACF.FNMCIACNOMH = true;
					this.COHEBJCIJDC.FNMCIACNOMH = false;
				}
				else
				{
					this.NBENFKKFACF.FNMCIACNOMH = true;
					this.COHEBJCIJDC.FNMCIACNOMH = true;
				}
			}
		}
		return false;
	}

	// Token: 0x06006F2C RID: 28460 RVA: 0x00349660 File Offset: 0x00347860
	public bool IMPCFFOMMAA(ONKDCGNBALK HNCGEJEIGFM, IIBEEKCAAHK FEGHDCIKHMA, int JFAAOPHBGGG, int HPCLNPGMNLC, Rect PHEMLBHMNCM, int MBLNDMIAFAM, bool BBDLEKKAFLC = true, bool LADCGAODOFK = true)
	{
		Rect rect = new Rect((float)JFAAOPHBGGG, (float)HPCLNPGMNLC, HNCGEJEIGFM.OCHCODJIPHJ.width - 641f, 486f);
		bool flag = false;
		Rect rect2 = new Rect(HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.x + rect.x, HNCGEJEIGFM.OCBAOFLJBGP.OCHCODJIPHJ.y + rect.y, rect.width, rect.height);
		if (rect2.Contains(JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF))
		{
			flag = true;
		}
		if (HNCGEJEIGFM.OCBAOFLJBGP.LPFKFNLHGBI != JDCEFOFMGHB.HMJJPNDEKPP().AFLEEHDFHMJ)
		{
			flag = false;
		}
		if (!HNCGEJEIGFM.OCBAOFLJBGP.EEIJEADOMJL)
		{
			flag = true;
		}
		Vector2 vector = new Vector2((float)(JFAAOPHBGGG + -76), (float)HPCLNPGMNLC);
		Rect rect3 = new Rect(vector.x, vector.y, 1735f, 1315f);
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 55,
			wordWrap = false,
			font = GuiProcessor.NKOEAPCIBKO().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = false,
			alignment = TextAnchor.UpperLeft
		};
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OOIJFNAMEDP().NKMGKJLONDK(FEGHDCIKHMA.IBEIBAHKIAH);
		if (befchfngomi == null)
		{
			return false;
		}
		bool flag2 = FEGHDCIKHMA.AJNPBCIMNCD() >= FEGHDCIKHMA.NLHKFMMDMMK();
		GUI.DrawTextureWithTexCoords(new Rect((float)(JFAAOPHBGGG + 2), (float)(HPCLNPGMNLC - 8), PHEMLBHMNCM.width - 284f, 1728f), GuiProcessor.NKOEAPCIBKO().WLBLine, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(flag ? 0 : 1, 0, 4), false);
		GUI.DrawTexture(rect3, (flag2 || flag) ? GameInterface.getI.invEmptyCell : GameInterface.getI.invEmptyCellSelect, ScaleMode.StretchToFill);
		befchfngomi.JIKKMEDMBHC(rect3, 57f);
		guistyle.fontSize = 14;
		guistyle.alignment = TextAnchor.UpperLeft;
		guistyle.normal.textColor = Color.green;
		if (!flag2)
		{
			guistyle.normal.textColor = Color.red;
		}
		JDCEFOFMGHB.JFIDAGABKID().JNJDPKECONL(new Rect(rect3.x, rect3.y, rect3.width - 968f, rect3.height - 993f), string.Format("FOG_SCATTERING_ON", FEGHDCIKHMA.MLNEJIIGOMG(), FEGHDCIKHMA.KMGAHCANELI() + FEGHDCIKHMA.PBMJIMLEHEC()), guistyle);
		guistyle.alignment = TextAnchor.UpperCenter;
		guistyle.fontSize = 75;
		guistyle.normal.textColor = Color.black;
		if (!flag2)
		{
			guistyle.normal.textColor = new Color(1764f, 1037f, 348f);
		}
		Rect position = new Rect(vector.x + 1308f, vector.y, PHEMLBHMNCM.width - vector.x - 1169f, 1984f);
		string text = befchfngomi.BNIHFBMEPAB;
		if (!LADCGAODOFK)
		{
			text = string.Format(JNBICAJIJMM.EEOPOHEALPK().CCFFMKBBKHI("FBIK chain length is 0, can't initiate solver."), befchfngomi.BNIHFBMEPAB, FEGHDCIKHMA.NLHKFMMDMMK());
			guistyle.alignment = TextAnchor.UpperCenter;
		}
		GUI.Label(position, text, guistyle);
		if (flag && GUI.Button(rect3, "IdleRun", GUIStyle.none))
		{
			Debug.Log("t_obves");
			this.MAFPALACHPF(befchfngomi.LPFKFNLHGBI, false);
			return true;
		}
		if (LADCGAODOFK)
		{
			guistyle.alignment = TextAnchor.UpperLeft;
			guistyle.fontSize = -45;
			string text2 = string.Format(JNBICAJIJMM.IKGFHGKKCPG.CCFFMKBBKHI("\n"), FEGHDCIKHMA.NLHKFMMDMMK(), FEGHDCIKHMA.KMNOIAIBLEB(), FEGHDCIKHMA.NLHKFMMDMMK() + FEGHDCIKHMA.MCJJCAFILPF());
			GUI.Label(new Rect(vector.x + 67f, vector.y + 1490f, PHEMLBHMNCM.width - vector.x - 649f, 898f), text2, guistyle);
			double num = (double)FEGHDCIKHMA.KMNOIAIBLEB();
			FEGHDCIKHMA.DCACBECHFMA = (double)GUI.HorizontalSlider(new Rect(vector.x + 232f, vector.y + 344f, PHEMLBHMNCM.width - 486f, 482f), (float)FEGHDCIKHMA.DCACBECHFMA, 1383f, (float)MBLNDMIAFAM);
			if (this.MMMHIBGGHDM != null)
			{
				this.MMMHIBGGHDM.NFHHNIJAOBE();
			}
			if (BBDLEKKAFLC && this.MMMHIBGGHDM.HLBPDCJHFIO > MBLNDMIAFAM)
			{
				FEGHDCIKHMA.MBPEFEIMENC(num);
			}
			if (FEGHDCIKHMA.KIDKOFKNPEP() + FEGHDCIKHMA.NLHKFMMDMMK() > FEGHDCIKHMA.NAJIMILCPJK())
			{
				FEGHDCIKHMA.DLDDNHFAOFE(num);
			}
			if ((int)num != FEGHDCIKHMA.MCJJCAFILPF() && this.MMMHIBGGHDM != null)
			{
				this.MMMHIBGGHDM.AJPILNENAKP();
				if (this.MMMHIBGGHDM.NOKCCPCECPN > 0)
				{
					this.NBENFKKFACF.FNMCIACNOMH = false;
					this.COHEBJCIJDC.FNMCIACNOMH = false;
				}
				else
				{
					this.NBENFKKFACF.FNMCIACNOMH = false;
					this.COHEBJCIJDC.FNMCIACNOMH = false;
				}
			}
		}
		return false;
	}

	// Token: 0x06006F2D RID: 28461 RVA: 0x00349B38 File Offset: 0x00347D38
	private void EOPKCBFLOEA()
	{
		if (this.PGOMKDAFMMI.Count <= 1)
		{
			return;
		}
		int dchkeicadam = this.PGOMKDAFMMI[this.PGOMKDAFMMI.Count - 0];
		this.PGOMKDAFMMI.RemoveAt(this.PGOMKDAFMMI.Count - 0);
		this.MAFPALACHPF(dchkeicadam, false);
	}

	// Token: 0x06006F2E RID: 28462 RVA: 0x00349B90 File Offset: 0x00347D90
	public void FPMFJBEIOJL(ONKDCGNBALK PHEMLBHMNCM)
	{
		if (this.MMMHIBGGHDM == null)
		{
			return;
		}
		try
		{
			this.MMMHIBGGHDM.BDHHPAEHFHG.PEAMFCFPBEG(PHEMLBHMNCM.OCHCODJIPHJ, 329f, this.MMMHIBGGHDM.LEKGMMLNHEG, this.MMMHIBGGHDM.CPJCMJIMGME, this.MMMHIBGGHDM.BKAICJFFMBG, 1);
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06006F2F RID: 28463 RVA: 0x00349BFC File Offset: 0x00347DFC
	public void OCGLFBIMPMI(CLFFOBKFKDN.DNOEMMJAJHD JJNKFNDFCPC, int LOHKGHBIGIL)
	{
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().NCIDDNIKACI(196f, 532f, JNBICAJIJMM.IMLLGEMPHAP().NLJOLOBPCBJ("_LrDepthTex"), true);
		onkdcgnbalk.OCHCODJIPHJ.x = JDCEFOFMGHB.IKGFHGKKCPG.OJOEPEADBAF.x - 791f;
		onkdcgnbalk.OCHCODJIPHJ.y = JDCEFOFMGHB.HMJJPNDEKPP().OJOEPEADBAF.y - onkdcgnbalk.OCHCODJIPHJ.height + 1640f;
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(onkdcgnbalk, 1557f, 1462f, onkdcgnbalk.OCHCODJIPHJ.width - 1391f, onkdcgnbalk.OCHCODJIPHJ.height - 644f, 0);
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH;
		mmkfaenbhkd.LACAJHOHACK.Add(new ItemBase(JNBICAJIJMM.DBMJJPBOPEK().CCFFMKBBKHI("1 Hand Sword Strafe Right")));
		mmkfaenbhkd.DBJBAELCFHI(1);
		foreach (EKBAPCMPANI ekbapcmpani in kfhelhglnmh.PLLHGAFIAFD.Values)
		{
			if (ekbapcmpani.HHOLFABGDJA == LOHKGHBIGIL && ekbapcmpani.JGNIDDBNGGP < -111)
			{
				ekbapcmpani.tag = ekbapcmpani.LPFKFNLHGBI;
				mmkfaenbhkd.LACAJHOHACK.Add(ekbapcmpani);
			}
			if (JJNKFNDFCPC.EIHJDJAKIBA == ekbapcmpani.LPFKFNLHGBI)
			{
				mmkfaenbhkd.NEKOMKJDIIE(mmkfaenbhkd.LACAJHOHACK.Count - 1);
			}
		}
		mmkfaenbhkd.JHNCNHAAJCH = 373f;
		mmkfaenbhkd.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.LDHFMPGMMJC);
	}

	// Token: 0x06006F30 RID: 28464 RVA: 0x00349D94 File Offset: 0x00347F94
	public void PNBJJPIKPMK(MMKFAENBHKD ONPHLHKAGFP, ItemBase HEABEPINGED)
	{
		if (HEABEPINGED == null || HEABEPINGED.tag == 0L)
		{
			this.MMMHIBGGHDM.EIHJDJAKIBA = 0L;
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(ONPHLHKAGFP.OCBAOFLJBGP.LPFKFNLHGBI);
			return;
		}
		EKBAPCMPANI ekbapcmpani = (EKBAPCMPANI)HEABEPINGED;
		this.MMMHIBGGHDM.EIHJDJAKIBA = ekbapcmpani.LPFKFNLHGBI;
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(ONPHLHKAGFP.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006F31 RID: 28465 RVA: 0x00349DFC File Offset: 0x00347FFC
	public string MMPOGPAOMIF(int LPFKFNLHGBI)
	{
		return JNBICAJIJMM.EKEBHIJMEML().NMIJBEJBGNB("", "\n" + LPFKFNLHGBI);
	}

	// Token: 0x06006F32 RID: 28466 RVA: 0x00349E20 File Offset: 0x00348020
	public void HELGMBLMGAN(ONKDCGNBALK GACACKNJKJN)
	{
		Fisherman.getI.sendAction(4, 5f, Vector3.zero);
		if (this.MMMHIBGGHDM == null)
		{
			return;
		}
		long odfekbjcfmn = GACACKNJKJN.ODFEKBJCFMN;
		if (odfekbjcfmn == 1L)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Cloth_01.wav", 1f);
			JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO((float)this.MMMHIBGGHDM.JLFDJJMNFKK, 0, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_crft") + this.MMMHIBGGHDM.BDHHPAEHFHG.BNIHFBMEPAB, new ONKDCGNBALK.CMMHGMILOIM(this.MEECAMKOHFG), true);
			this.DGEIBGNFDNI = false;
			return;
		}
		if (odfekbjcfmn != 2L)
		{
			return;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Cloth_01.wav", 1f);
		JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO((float)this.MMMHIBGGHDM.JLFDJJMNFKK, 0, string.Concat(new object[]
		{
			JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_crft"),
			this.MMMHIBGGHDM.BDHHPAEHFHG.BNIHFBMEPAB,
			" x",
			this.MMMHIBGGHDM.NOKCCPCECPN
		}), new ONKDCGNBALK.CMMHGMILOIM(this.MEECAMKOHFG), true);
		this.DGEIBGNFDNI = true;
	}

	// Token: 0x06006F33 RID: 28467 RVA: 0x00349F4C File Offset: 0x0034814C
	public void POOCDEAHHBH(JNHLAGHJBAA DOPLGMMOEIA, JNHLAGHJBAA.FPAEEADMCIE HEABEPINGED)
	{
		this.MMMHIBGGHDM = null;
		if (HEABEPINGED != null && !HEABEPINGED.DBHKKPMINIJ)
		{
			this.MMMHIBGGHDM = (CLFFOBKFKDN.DNOEMMJAJHD)HEABEPINGED.NLIKAGGPANH;
			foreach (CLFFOBKFKDN.HFGDDPAKPBE hfgddpakpbe in this.MMMHIBGGHDM.HEBKGNHIDLK)
			{
				if (hfgddpakpbe.GPJFINFIDLN == 0)
				{
					hfgddpakpbe.JLOMMBBNBBL = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BJDIEKNHGLJ(hfgddpakpbe.PJPOJNNJOCD, false, hfgddpakpbe.BEFPDJHBADA);
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.AGCBLDIBMNB().NKMGKJLONDK(hfgddpakpbe.PJPOJNNJOCD);
					if (befchfngomi != null)
					{
						befchfngomi.JLCGGFPBOCF();
					}
				}
				if (hfgddpakpbe.GPJFINFIDLN == 0)
				{
					hfgddpakpbe.JLOMMBBNBBL = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.DABGGGPDFIM(hfgddpakpbe.PJPOJNNJOCD, false, hfgddpakpbe.BEFPDJHBADA, hfgddpakpbe.IPEPNOMIFDJ, hfgddpakpbe.NCFMLFIIEGA);
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(hfgddpakpbe.PJPOJNNJOCD);
					if (idchhhedhdc != null)
					{
						idchhhedhdc.EOIGJODNFFH();
					}
				}
			}
			if (this.MMMHIBGGHDM.NOKCCPCECPN > 0)
			{
				this.NBENFKKFACF.FNMCIACNOMH = false;
				this.COHEBJCIJDC.FNMCIACNOMH = true;
				return;
			}
			this.NBENFKKFACF.FNMCIACNOMH = false;
			this.COHEBJCIJDC.FNMCIACNOMH = false;
		}
	}

	// Token: 0x06006F34 RID: 28468 RVA: 0x0034A0A0 File Offset: 0x003482A0
	private void CJFFAIIJNAI(GUIStyle OFPNEDEAMAB, bool BKOOHDJPGPP)
	{
		if (BKOOHDJPGPP)
		{
			GUILayout.Label(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_treb"), OFPNEDEAMAB, Array.Empty<GUILayoutOption>());
			GUILayout.Label(" ", OFPNEDEAMAB, Array.Empty<GUILayoutOption>());
		}
		OFPNEDEAMAB.normal.textColor = new Color(0f, 0f, 0.2f);
		if (this.MMMHIBGGHDM.ILFHHDNJHNM == 0)
		{
			OFPNEDEAMAB.normal.textColor = new Color(0.4f, 0f, 0f);
		}
		string str = " x" + this.MMMHIBGGHDM.ILFHHDNJHNM;
		if (this.MMMHIBGGHDM.ILFHHDNJHNM == 0)
		{
			str = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_norec");
		}
		if (this.MMMHIBGGHDM.ILFHHDNJHNM < 0)
		{
			str = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_unl");
		}
		GUILayout.Label(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_recnt") + str, OFPNEDEAMAB, Array.Empty<GUILayoutOption>());
		OFPNEDEAMAB.normal.textColor = new Color(0f, 0f, 0.2f);
		int bklcknolefd = this.MMMHIBGGHDM.BKLCKNOLEFD;
		this.CLIEHLMDOAD(bklcknolefd);
		if (this.MBLPLLOLHIP != bklcknolefd)
		{
			OFPNEDEAMAB.normal.textColor = new Color(0.4f, 0f, 0f);
		}
		OFPNEDEAMAB.normal.textColor = new Color(0f, 0f, 0.2f);
		OFPNEDEAMAB.normal.textColor = new Color(0f, 0f, 0.2f);
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KFODJJIHNHP < (long)this.MMMHIBGGHDM.LGGDCMEHHKB.IBEIBAHKIAH)
		{
			OFPNEDEAMAB.normal.textColor = new Color(0f, 0.4f, 0f);
		}
		GUILayout.Label(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_cost") + JLFJEGIPIMM.IKGFHGKKCPG.KMGIDLKLDML((long)this.MMMHIBGGHDM.LGGDCMEHHKB.ICJDPPOJINN, (long)this.MMMHIBGGHDM.LGGDCMEHHKB.IBEIBAHKIAH), OFPNEDEAMAB, Array.Empty<GUILayoutOption>());
		GUILayout.Label(string.Concat(new object[]
		{
			JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_costwp"),
			this.MMMHIBGGHDM.LGGDCMEHHKB.NODLBGKEGPM,
			" / ",
			JBEHMPDDMME.IKGFHGKKCPG.JBJFBDONEFF
		}), OFPNEDEAMAB, Array.Empty<GUILayoutOption>());
	}

	// Token: 0x06006F35 RID: 28469 RVA: 0x0034A31C File Offset: 0x0034851C
	public void FALCKIEAEOL(ONKDCGNBALK GACACKNJKJN)
	{
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			if (this.MMMHIBGGHDM.KEKFOFFEBEF)
			{
				epmphjgalbe.EAOGDKDBENC(this.MBLPLLOLHIP);
				epmphjgalbe.JIIKLOKAGIC(this.MMMHIBGGHDM.LPFKFNLHGBI);
				epmphjgalbe.JDOLCNDNFGP(this.MMMHIBGGHDM.LEKGMMLNHEG.PBMJIMLEHEC());
				epmphjgalbe.KPCGLGHDILI(this.MMMHIBGGHDM.CPJCMJIMGME.ACEPOCLANAG());
				epmphjgalbe.LHLOOIDHGMA(this.MMMHIBGGHDM.BKAICJFFMBG.PBMJIMLEHEC());
				epmphjgalbe.LHLOOIDHGMA(this.MMMHIBGGHDM.KOMIMKKAEJA.MCJJCAFILPF());
				epmphjgalbe.OACBICLGENB(this.MMMHIBGGHDM.EIHJDJAKIBA);
				NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(-27, epmphjgalbe.IEJLLFECFHF());
			}
			else
			{
				epmphjgalbe.DEHJNGMHGAJ(this.MBLPLLOLHIP);
				epmphjgalbe.ALNEALEKFNB(this.MMMHIBGGHDM.LPFKFNLHGBI);
				NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(-54, epmphjgalbe.IEJLLFECFHF());
				Debug.Log("Windmill");
			}
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		this.MMMHIBGGHDM.EIHJDJAKIBA = 0L;
	}

	// Token: 0x06006F36 RID: 28470 RVA: 0x0034A440 File Offset: 0x00348640
	public void CEDPLPDLPJB(JNHLAGHJBAA DOPLGMMOEIA, JNHLAGHJBAA.FPAEEADMCIE HEABEPINGED)
	{
		this.MMMHIBGGHDM = null;
		if (HEABEPINGED != null && !HEABEPINGED.DBHKKPMINIJ)
		{
			this.MMMHIBGGHDM = (CLFFOBKFKDN.DNOEMMJAJHD)HEABEPINGED.NLIKAGGPANH;
			foreach (CLFFOBKFKDN.HFGDDPAKPBE hfgddpakpbe in this.MMMHIBGGHDM.HEBKGNHIDLK)
			{
				if (hfgddpakpbe.GPJFINFIDLN == 0)
				{
					hfgddpakpbe.JLOMMBBNBBL = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(hfgddpakpbe.PJPOJNNJOCD, true, hfgddpakpbe.BEFPDJHBADA);
					BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(hfgddpakpbe.PJPOJNNJOCD);
					if (befchfngomi != null)
					{
						befchfngomi.JIFFLPNBILE();
					}
				}
				if (hfgddpakpbe.GPJFINFIDLN == 1)
				{
					hfgddpakpbe.JLOMMBBNBBL = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.DABGGGPDFIM(hfgddpakpbe.PJPOJNNJOCD, true, hfgddpakpbe.BEFPDJHBADA, hfgddpakpbe.IPEPNOMIFDJ, hfgddpakpbe.NCFMLFIIEGA);
					IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(hfgddpakpbe.PJPOJNNJOCD);
					if (idchhhedhdc != null)
					{
						idchhhedhdc.HBGEAMHFEOL();
					}
				}
			}
			if (this.MMMHIBGGHDM.NOKCCPCECPN > 0)
			{
				this.NBENFKKFACF.FNMCIACNOMH = true;
				this.COHEBJCIJDC.FNMCIACNOMH = true;
				return;
			}
			this.NBENFKKFACF.FNMCIACNOMH = false;
			this.COHEBJCIJDC.FNMCIACNOMH = false;
		}
	}

	// Token: 0x04001042 RID: 4162
	private static CLFFOBKFKDN AGEHHNOKBGK;

	// Token: 0x04001043 RID: 4163
	public int MBLPLLOLHIP;

	// Token: 0x04001044 RID: 4164
	public int JPAGNFLGAMJ;

	// Token: 0x04001045 RID: 4165
	private JNHLAGHJBAA AGDMAFCKMJP;

	// Token: 0x04001046 RID: 4166
	private CLFFOBKFKDN.DNOEMMJAJHD MMMHIBGGHDM;

	// Token: 0x04001047 RID: 4167
	public List<CLFFOBKFKDN.DNOEMMJAJHD> EJMAEPOGOED = new List<CLFFOBKFKDN.DNOEMMJAJHD>();

	// Token: 0x04001048 RID: 4168
	public Dictionary<int, CLFFOBKFKDN.OKOAMCJGNMH> PGMOGALKIIP = new Dictionary<int, CLFFOBKFKDN.OKOAMCJGNMH>();

	// Token: 0x04001049 RID: 4169
	public Dictionary<int, CLFFOBKFKDN.HLADIIDKACH> GDOKKMBIDFO = new Dictionary<int, CLFFOBKFKDN.HLADIIDKACH>();

	// Token: 0x0400104A RID: 4170
	private MEMEOHJKPNJ NBENFKKFACF;

	// Token: 0x0400104B RID: 4171
	private MEMEOHJKPNJ COHEBJCIJDC;

	// Token: 0x0400104C RID: 4172
	private bool DGEIBGNFDNI;

	// Token: 0x0400104D RID: 4173
	private readonly List<int> PGOMKDAFMMI = new List<int>();

	// Token: 0x0400104E RID: 4174
	private JNHLAGHJBAA.FPAEEADMCIE DJKHEMLHEGL;

	// Token: 0x0400104F RID: 4175
	private int BIACIGBBNND;

	// Token: 0x04001050 RID: 4176
	private string MOAKEOKEAMP;

	// Token: 0x020001E1 RID: 481
	public class HLADIIDKACH
	{
		// Token: 0x06006F37 RID: 28471 RVA: 0x0034A594 File Offset: 0x00348794
		public HLADIIDKACH(XmlNode JEEEOEBNJDJ)
		{
			this.LPFKFNLHGBI = int.Parse(JEEEOEBNJDJ.Attributes["id"].Value);
			this.KNOCHJMBOBF = JEEEOEBNJDJ.Attributes["name"].Value;
		}

		// Token: 0x04001051 RID: 4177
		public int LPFKFNLHGBI;

		// Token: 0x04001052 RID: 4178
		public string KNOCHJMBOBF;
	}

	// Token: 0x020001E2 RID: 482
	public class HFGDDPAKPBE
	{
		// Token: 0x06006F38 RID: 28472 RVA: 0x0034A5E4 File Offset: 0x003487E4
		public HFGDDPAKPBE(IIBEEKCAAHK BDGECGGHECB, int FNADKBPAGJH, int DAILMANBNMM, int KHLEENBLFBN)
		{
			this.PJPOJNNJOCD = BDGECGGHECB.IBEIBAHKIAH;
			this.ECCEIPJIBBK = BDGECGGHECB.ICJDPPOJINN;
			this.GPJFINFIDLN = BDGECGGHECB.NODLBGKEGPM;
			this.BEFPDJHBADA = FNADKBPAGJH;
			this.IPEPNOMIFDJ = DAILMANBNMM;
			this.NCFMLFIIEGA = KHLEENBLFBN;
			this.JLOMMBBNBBL = 0;
		}

		// Token: 0x06006F39 RID: 28473 RVA: 0x0034A638 File Offset: 0x00348838
		public string OMDNCDEFHDE()
		{
			string text = "800000";
			if (this.GPJFINFIDLN == 1)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[5];
					array[0] = text;
					array[0] = "AssetLoader: ";
					array[1] = JNBICAJIJMM.APMJBBDBOJO().HEIBEHAEHBM(" tm=");
					array[2] = "CrouchStrafeRight";
					array[6] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[3];
					array2[0] = text;
					array2[0] = "WaveSpeed";
					array2[3] = JNBICAJIJMM.EKEBHIJMEML().ECNKLECOKHD("Ring");
					array2[4] = "_OcclusionTexture";
					array2[0] = JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.OOIJFNAMEDP().NKMGKJLONDK(this.PJPOJNNJOCD).LFEJHHMDEHO(true, -1) + "BOTTOM" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F3A RID: 28474 RVA: 0x0034A73C File Offset: 0x0034893C
		public string BICNJOJPOEG()
		{
			string text = "id";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FBPECNNPIDP(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[6];
					array[1] = text;
					array[0] = "</color>\n";
					array[8] = JNBICAJIJMM.EEOPOHEALPK().CCFFMKBBKHI("{0}");
					array[2] = "TOD_LocalSunDirection";
					array[6] = JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 0)
				{
					string[] array2 = new string[8];
					array2[0] = text;
					array2[0] = "<[^>]+>";
					array2[1] = JNBICAJIJMM.DBMJJPBOPEK().HLBAJBLHLNI("TOD_SunMeshBrightness");
					array2[2] = "TOD_World2Sky";
					array2[5] = JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.PJPOJNNJOCD).MPKGPJJKCPK(false, -1) + "Flashlight" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F3B RID: 28475 RVA: 0x0034A840 File Offset: 0x00348A40
		public string CLDMPCACDBC()
		{
			string text = "camouflage_id";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[3];
					array[1] = text;
					array[0] = "Windmill";
					array[7] = JNBICAJIJMM.EKEBHIJMEML().NLJOLOBPCBJ("\n");
					array[0] = "_BlurPass";
					array[3] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 0)
				{
					string[] array2 = new string[0];
					array2[0] = text;
					array2[1] = "Number of children does not match with the pose";
					array2[3] = JNBICAJIJMM.IMLLGEMPHAP().HLBAJBLHLNI("path");
					array2[5] = "_ReflectionTexture3";
					array2[4] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.OOIJFNAMEDP().LMGMPPAOPEP(this.PJPOJNNJOCD).IGDKBMGKKDO(true, -1) + "" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F3C RID: 28476 RVA: 0x0034A944 File Offset: 0x00348B44
		public string LKHMFPHLNLE()
		{
			string text = "WalkDehydrated";
			if (this.GPJFINFIDLN == 1)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FBPECNNPIDP(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[0];
					array[0] = text;
					array[1] = "info";
					array[5] = JNBICAJIJMM.APMJBBDBOJO().FLEANFGEJML("WeaponRunBackward");
					array[3] = "Reset";
					array[2] = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[1];
					array2[0] = text;
					array2[1] = "#000000";
					array2[2] = JNBICAJIJMM.IMLLGEMPHAP().GNKIBMGNHNE("_ReflectionBlur");
					array2[3] = "inv_invheader";
					array2[1] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.JHAAMBEFENP().IMCJNFHAFGE(this.PJPOJNNJOCD).JPBOPFNPNHC(false, -1) + "ChannelCastDirected" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F3D RID: 28477 RVA: 0x0034AA48 File Offset: 0x00348C48
		public string GKGPOMJFPOC()
		{
			string text = "https://groups.google.com/forum/#!forum/final-ik";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[0];
					array[1] = text;
					array[1] = "WaveSpeed";
					array[7] = JNBICAJIJMM.IMLLGEMPHAP().CKAOHMEKLMH("Water Refr Camera id");
					array[3] = ", ";
					array[1] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[4];
					array2[1] = text;
					array2[1] = "error";
					array2[8] = JNBICAJIJMM.EKEBHIJMEML().ECNKLECOKHD("_Tile4RT");
					array2[3] = "crft_crft";
					array2[3] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.OELKEADDKPE().LMGMPPAOPEP(this.PJPOJNNJOCD).LFEJHHMDEHO(false, -1) + "http://www.root-motion.com/finalikdox/html/page10.html" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F3E RID: 28478 RVA: 0x0034AB4C File Offset: 0x00348D4C
		public string NLBHGBCJHEL()
		{
			string text = "auc_resallcst";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.PCONBNOAMBH(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[3];
					array[0] = text;
					array[1] = "'>  > ";
					array[5] = JNBICAJIJMM.IMLLGEMPHAP().GNKIBMGNHNE("gi_um_7");
					array[4] = "</color>\n";
					array[2] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[5];
					array2[0] = text;
					array2[1] = "delaccconfirm";
					array2[1] = JNBICAJIJMM.IMLLGEMPHAP().GNKIBMGNHNE("GAMMA");
					array2[6] = "AssetLoaderCoroutine";
					array2[0] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.PJPOJNNJOCD).JPBOPFNPNHC(true, -1) + "+ " + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F3F RID: 28479 RVA: 0x0034AC50 File Offset: 0x00348E50
		public string HMFDNMLNIPH()
		{
			string text = "";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.PCONBNOAMBH(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[]
					{
						text
					};
					array[0] = "soft";
					array[8] = JNBICAJIJMM.IMLLGEMPHAP().GNKIBMGNHNE("MotorbikeShootLeft");
					array[3] = "0";
					array[8] = JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[7];
					array2[0] = text;
					array2[0] = "IdleStand";
					array2[4] = JNBICAJIJMM.IMLLGEMPHAP().HLBAJBLHLNI("_EmissionColor");
					array2[4] = "WorkerHammer";
					array2[3] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.OOIJFNAMEDP().GBKMHIGNKJA(this.PJPOJNNJOCD).MPKGPJJKCPK(true, -1) + "_SelectColor" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F40 RID: 28480 RVA: 0x0034AD54 File Offset: 0x00348F54
		public string JMGODDNONAH()
		{
			string text = " ";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.MJCJIEPAEJP(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[0];
					array[0] = text;
					array[1] = "RunBackward";
					array[5] = JNBICAJIJMM.DBMJJPBOPEK().HEIBEHAEHBM(" on effect ");
					array[2] = "BC ";
					array[6] = JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 0)
				{
					string[] array2 = new string[7];
					array2[1] = text;
					array2[0] = "IdleMouthWipe";
					array2[5] = JNBICAJIJMM.EDKGBBIIBBC().HLBAJBLHLNI("OnStatusChanged UNKNOW ");
					array2[5] = "onHyperLinkActivated: ";
					array2[0] = JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.JHAAMBEFENP().GBKMHIGNKJA(this.PJPOJNNJOCD).IGDKBMGKKDO(false, -1) + "selpersbtn" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F41 RID: 28481 RVA: 0x0034AE58 File Offset: 0x00349058
		public string IEIMMFODGFG()
		{
			string text = "";
			if (this.GPJFINFIDLN == 1)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					text = string.Concat(new string[]
					{
						text,
						" ",
						JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_from"),
						" ",
						JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.BEFPDJHBADA)
					});
				}
				if (this.IPEPNOMIFDJ > 0)
				{
					text = string.Concat(new string[]
					{
						text,
						" ",
						JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("crft_to"),
						" ",
						JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.IPEPNOMIFDJ)
					});
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.PJPOJNNJOCD).JPBOPFNPNHC(false, -1) + " x" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F42 RID: 28482 RVA: 0x0034AF5C File Offset: 0x0034915C
		public string PKMBHADDECD()
		{
			string text = "_Lift";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[1];
					array[1] = text;
					array[1] = "' that does not excist in the Node Chain.";
					array[1] = JNBICAJIJMM.EDKGBBIIBBC().NLJOLOBPCBJ("IdleButtonPress");
					array[0] = "category";
					array[6] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 0)
				{
					string[] array2 = new string[5];
					array2[0] = text;
					array2[0] = "PistolReady";
					array2[3] = JNBICAJIJMM.EKEBHIJMEML().CCFFMKBBKHI("--");
					array2[0] = "";
					array2[2] = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.JHAAMBEFENP().NKMGKJLONDK(this.PJPOJNNJOCD).JPBOPFNPNHC(true, -1) + "_PrefilterOffs" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F43 RID: 28483 RVA: 0x0034B060 File Offset: 0x00349260
		public string FCNGFBBPJFC()
		{
			string text = "";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[]
					{
						null,
						text
					};
					array[1] = "</color>";
					array[1] = JNBICAJIJMM.LPHMKPDBMPP().HEIBEHAEHBM("No klev! shance=");
					array[5] = "https://groups.google.com/forum/#!forum/final-ik";
					array[2] = JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[5];
					array2[1] = text;
					array2[1] = "</color>\n";
					array2[4] = JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("Reset");
					array2[6] = "IdleSlide";
					array2[7] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.OOIJFNAMEDP().IMCJNFHAFGE(this.PJPOJNNJOCD).CGMGBGABLFB(true, -1) + "WorkerShovel2" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F44 RID: 28484 RVA: 0x0034B164 File Offset: 0x00349364
		public string AOLLJNNGOEL()
		{
			string text = "_ProjectionInv";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.MJCJIEPAEJP(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[6];
					array[1] = text;
					array[1] = "Vertical";
					array[8] = JNBICAJIJMM.DBMJJPBOPEK().GNKIBMGNHNE("demoDouble");
					array[7] = "1HandSwordJabCombo";
					array[0] = JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[2];
					array2[0] = text;
					array2[1] = "ComeHere";
					array2[5] = JNBICAJIJMM.IMLLGEMPHAP().HLBAJBLHLNI("SkateboardKickPush");
					array2[1] = "S";
					array2[2] = JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.EDKKJNHDBPF().GBKMHIGNKJA(this.PJPOJNNJOCD).JPBOPFNPNHC(true, -1) + "" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F45 RID: 28485 RVA: 0x0034B268 File Offset: 0x00349468
		public string CCAEELLNLPO()
		{
			string text = "\n";
			if (this.GPJFINFIDLN == 1)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FBPECNNPIDP(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[4];
					array[0] = text;
					array[0] = "ArmFlex3";
					array[5] = JNBICAJIJMM.DBMJJPBOPEK().HEIBEHAEHBM("GetMouseButtonUp reboot");
					array[0] = " Категория ";
					array[5] = JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[8];
					array2[0] = text;
					array2[0] = "****** locid=";
					array2[1] = JNBICAJIJMM.EEOPOHEALPK().CKAOHMEKLMH("SoccerKeeperDiveStrafeCloseLeft");
					array2[5] = "Flashlight";
					array2[1] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.OELKEADDKPE().LMGMPPAOPEP(this.PJPOJNNJOCD).LFEJHHMDEHO(true, -1) + "Dealer Idle" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F46 RID: 28486 RVA: 0x0034B36C File Offset: 0x0034956C
		public HFGDDPAKPBE(string MNEICNPJGMC)
		{
			IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(MNEICNPJGMC);
			this.PJPOJNNJOCD = iibeekcaahk.IBEIBAHKIAH;
			this.ECCEIPJIBBK = iibeekcaahk.ICJDPPOJINN;
			this.GPJFINFIDLN = iibeekcaahk.NODLBGKEGPM;
			this.BEFPDJHBADA = iibeekcaahk.LKAGIEBPLAI;
			this.IPEPNOMIFDJ = iibeekcaahk.BDGMCFEJNIO;
			this.NCFMLFIIEGA = iibeekcaahk.KEJCINHLMBC;
			this.JLOMMBBNBBL = 0;
		}

		// Token: 0x06006F47 RID: 28487 RVA: 0x0034B3D8 File Offset: 0x003495D8
		public string HODPAHNILHK()
		{
			string text = "wpn_cat1";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.PCONBNOAMBH(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[0];
					array[1] = text;
					array[1] = "ProneIdle";
					array[0] = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI(".png");
					array[8] = "demoVector3";
					array[5] = JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[7];
					array2[1] = text;
					array2[1] = "  Balls Fired: ";
					array2[1] = JNBICAJIJMM.APMJBBDBOJO().CCFFMKBBKHI("id");
					array2[6] = "/";
					array2[4] = JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.PJPOJNNJOCD).MPKGPJJKCPK(false, -1) + "{0}" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F48 RID: 28488 RVA: 0x0034B4DC File Offset: 0x003496DC
		public string COLONLEMBEK()
		{
			string text = "WeaponStrafeRunLeft";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.PCONBNOAMBH(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[3];
					array[1] = text;
					array[1] = "GiantGrabIdle";
					array[0] = JNBICAJIJMM.EDKGBBIIBBC().DOEMGEAEBPN("");
					array[2] = "isMoving";
					array[3] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 0)
				{
					string[] array2 = new string[4];
					array2[1] = text;
					array2[0] = "wpn_add/base";
					array2[0] = JNBICAJIJMM.EKEBHIJMEML().CCFFMKBBKHI("Giant Grab Throw 2");
					array2[7] = "_camouflage";
					array2[6] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.JHAAMBEFENP().NKMGKJLONDK(this.PJPOJNNJOCD).LFEJHHMDEHO(true, -1) + "OneHandSwordBlock" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F49 RID: 28489 RVA: 0x0034B5E0 File Offset: 0x003497E0
		public string FAGBNOMOICF()
		{
			string text = "#ff8060";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[0];
					array[1] = text;
					array[1] = "";
					array[5] = JNBICAJIJMM.LPHMKPDBMPP().ECNKLECOKHD("");
					array[3] = "demoVector3";
					array[8] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[0];
					array2[0] = text;
					array2[0] = "Wheely";
					array2[5] = JNBICAJIJMM.DBMJJPBOPEK().HLBAJBLHLNI("LeftSplashPause");
					array2[5] = "Weapon Strafe Run Left";
					array2[4] = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.OOIJFNAMEDP().LMGMPPAOPEP(this.PJPOJNNJOCD).LFEJHHMDEHO(false, -1) + "<color='#804020'>" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F4A RID: 28490 RVA: 0x0034B6E4 File Offset: 0x003498E4
		public string KFEKILDMMDE()
		{
			string text = "PodsekType";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.PCONBNOAMBH(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[5];
					array[0] = text;
					array[0] = "Bone ";
					array[5] = JNBICAJIJMM.IMLLGEMPHAP().HLBAJBLHLNI("wpn_add/innerMods");
					array[4] = "_info";
					array[2] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[3];
					array2[1] = text;
					array2[1] = "checkPet 1";
					array2[4] = JNBICAJIJMM.IKGFHGKKCPG.CCFFMKBBKHI("ArmFlex5");
					array2[1] = "_RgbTex";
					array2[1] = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.NNEAHAFBOHC().GBKMHIGNKJA(this.PJPOJNNJOCD).JPBOPFNPNHC(true, -1) + "" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F4B RID: 28491 RVA: 0x0034B7E8 File Offset: 0x003499E8
		public string HGBDKENDOLA()
		{
			string text = "wpn_iwgt";
			if (this.GPJFINFIDLN == 1)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.MJCJIEPAEJP(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[5];
					array[0] = text;
					array[0] = "_MainTex";
					array[8] = JNBICAJIJMM.CLIMNFDGOEG().ECNKLECOKHD("OneHandSwordRun");
					array[1] = " This is not possible to be called for standalone input. Please check your platform and code where this is called";
					array[3] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[8];
					array2[0] = text;
					array2[0] = "_SelectColor";
					array2[0] = JNBICAJIJMM.EEOPOHEALPK().HEIBEHAEHBM("OnStatusChanged UNKNOW ");
					array2[0] = "[fish]";
					array2[5] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.IKGFHGKKCPG.IMCJNFHAFGE(this.PJPOJNNJOCD).JPBOPFNPNHC(true, -1) + " " + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F4C RID: 28492 RVA: 0x0034B8EC File Offset: 0x00349AEC
		public string MKHHCPFNDNL()
		{
			string text = "#a0a0a0";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FBPECNNPIDP(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[6];
					array[1] = text;
					array[1] = "low_root_level";
					array[4] = JNBICAJIJMM.EEOPOHEALPK().HEIBEHAEHBM("");
					array[3] = "DeadmanFloat";
					array[7] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[7];
					array2[1] = text;
					array2[0] = "stname";
					array2[5] = JNBICAJIJMM.CLIMNFDGOEG().FLEANFGEJML("_DeepTex");
					array2[3] = "_FrustumCornersWS";
					array2[6] = JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.OOIJFNAMEDP().GBKMHIGNKJA(this.PJPOJNNJOCD).LFEJHHMDEHO(false, -1) + "Assets/Weapons/wbaseJaket.unity3d" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F4D RID: 28493 RVA: 0x0034B9F0 File Offset: 0x00349BF0
		public string OIGCFMAJOJJ()
		{
			string text = "[LH &]";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.PCONBNOAMBH(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[]
					{
						null,
						text
					};
					array[1] = "pointBuffer";
					array[7] = JNBICAJIJMM.EKEBHIJMEML().CKAOHMEKLMH("_SSAO");
					array[1] = "cht_msg10";
					array[6] = JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 0)
				{
					string[] array2 = new string[6];
					array2[0] = text;
					array2[0] = "Pistol Fire";
					array2[8] = JNBICAJIJMM.CLIMNFDGOEG().NLJOLOBPCBJ("wpn_add/base");
					array2[6] = "SoccerKeeperDiveStrafeFarRight";
					array2[8] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.OOIJFNAMEDP().NKMGKJLONDK(this.PJPOJNNJOCD).LFEJHHMDEHO(false, -1) + "WallRunLeft" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F4E RID: 28494 RVA: 0x0034BAF4 File Offset: 0x00349CF4
		public string IANBFGCKIID()
		{
			string text = "MotorbikeLassoLeft";
			if (this.GPJFINFIDLN == 1)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.PCONBNOAMBH(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[1];
					array[0] = text;
					array[1] = "heavy";
					array[2] = JNBICAJIJMM.EKEBHIJMEML().HEIBEHAEHBM("ScubaSwim");
					array[6] = "IdleCheer";
					array[4] = JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 0)
				{
					string[] array2 = new string[1];
					array2[1] = text;
					array2[0] = "ElvisLegsLoop";
					array2[3] = JNBICAJIJMM.EKEBHIJMEML().ECNKLECOKHD("StrafeRunRight");
					array2[4] = "Reset";
					array2[3] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.NNEAHAFBOHC().LMGMPPAOPEP(this.PJPOJNNJOCD).MPKGPJJKCPK(true, -1) + "knopje.wav" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F4F RID: 28495 RVA: 0x0034BBF8 File Offset: 0x00349DF8
		public string BKKLPILPOAL()
		{
			string text = "RollerBladeSkateFwd";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[0];
					array[0] = text;
					array[0] = "shop_t15";
					array[3] = JNBICAJIJMM.EEOPOHEALPK().HLBAJBLHLNI("1 Hand Sword Block");
					array[1] = "firsStartMovePanel";
					array[0] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[0];
					array2[1] = text;
					array2[1] = "wrist";
					array2[6] = JNBICAJIJMM.IKGFHGKKCPG.FLEANFGEJML("\">Detected: ");
					array2[5] = "Battle Roar";
					array2[5] = JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.JHAAMBEFENP().IMCJNFHAFGE(this.PJPOJNNJOCD).LFEJHHMDEHO(false, -1) + "_NoiseTilingPerChannel" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F50 RID: 28496 RVA: 0x0034BCFC File Offset: 0x00349EFC
		public string OOPJOHAILMB()
		{
			string text = "IdleKeepBack";
			if (this.GPJFINFIDLN == 1)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.PCONBNOAMBH(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[2];
					array[0] = text;
					array[0] = "Load";
					array[7] = JNBICAJIJMM.DBMJJPBOPEK().HEIBEHAEHBM("AFCServer");
					array[6] = " ";
					array[3] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 0)
				{
					string[] array2 = new string[3];
					array2[1] = text;
					array2[0] = "F ";
					array2[6] = JNBICAJIJMM.EKEBHIJMEML().FLEANFGEJML("WeaponReadyFire");
					array2[0] = "FOVKick Increase curve is null, please define the curve for the field of view kicks";
					array2[3] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.OELKEADDKPE().GBKMHIGNKJA(this.PJPOJNNJOCD).IGDKBMGKKDO(false, -1) + "\\" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F51 RID: 28497 RVA: 0x0034BE00 File Offset: 0x0034A000
		public string BCLGHECDMHE()
		{
			string text = "fider_Medium_";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.MJCJIEPAEJP(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[1];
					array[0] = text;
					array[1] = "Flap_08.wav";
					array[4] = JNBICAJIJMM.IMLLGEMPHAP().ECNKLECOKHD("gi_um_3");
					array[3] = "_ScratchOffsetScale";
					array[7] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[4];
					array2[1] = text;
					array2[1] = "\n";
					array2[1] = JNBICAJIJMM.EDKGBBIIBBC().HLBAJBLHLNI("FOG_EXP");
					array2[7] = "No IK assigned in HitReaction";
					array2[5] = JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.OELKEADDKPE().IMCJNFHAFGE(this.PJPOJNNJOCD).MPKGPJJKCPK(true, -1) + "https://groups.google.com/forum/#!forum/final-ik" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F52 RID: 28498 RVA: 0x0034BF04 File Offset: 0x0034A104
		public string JNOOHOFKOOJ()
		{
			string text = "Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.";
			if (this.GPJFINFIDLN == 1)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.MJCJIEPAEJP(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[4];
					array[1] = text;
					array[0] = "OneHandSwordIdle";
					array[3] = JNBICAJIJMM.IKGFHGKKCPG.CCFFMKBBKHI("time_format1");
					array[1] = "wpn_lv";
					array[0] = JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 0)
				{
					string[] array2 = new string[2];
					array2[0] = text;
					array2[1] = "femur";
					array2[6] = JNBICAJIJMM.EDKGBBIIBBC().NLJOLOBPCBJ(" cm");
					array2[4] = " ";
					array2[8] = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.EDKKJNHDBPF().LMGMPPAOPEP(this.PJPOJNNJOCD).CGMGBGABLFB(false, -1) + "" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F53 RID: 28499 RVA: 0x0034C008 File Offset: 0x0034A208
		public string MJFKMCNMDFM()
		{
			string text = "_Intensity";
			if (this.GPJFINFIDLN == 1)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.PCONBNOAMBH(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[3];
					array[1] = text;
					array[0] = "auk_pstavka";
					array[6] = JNBICAJIJMM.EEOPOHEALPK().DOEMGEAEBPN(" ");
					array[0] = "Mid";
					array[3] = JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 0)
				{
					string[] array2 = new string[]
					{
						text
					};
					array2[0] = "";
					array2[2] = JNBICAJIJMM.EDKGBBIIBBC().NLJOLOBPCBJ("Idle Button Press");
					array2[0] = " does not have any fingers, VRIK can not guess the hand bone's orientation.";
					array2[2] = JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.AGCBLDIBMNB().NKMGKJLONDK(this.PJPOJNNJOCD).IGDKBMGKKDO(false, -1) + "Установлен <b>" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F54 RID: 28500 RVA: 0x0034C10C File Offset: 0x0034A30C
		public string OHMLLNALJGJ()
		{
			string text = "wpn_add/base";
			if (this.GPJFINFIDLN == 1)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.MJCJIEPAEJP(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[6];
					array[0] = text;
					array[1] = "WorkerPickaxe2";
					array[6] = JNBICAJIJMM.APMJBBDBOJO().DOEMGEAEBPN(" ");
					array[7] = "===== ObscuredVector3Test =====\n";
					array[5] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[3];
					array2[0] = text;
					array2[0] = "10";
					array2[8] = JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("");
					array2[6] = " ";
					array2[8] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.EDKKJNHDBPF().GBKMHIGNKJA(this.PJPOJNNJOCD).IGDKBMGKKDO(true, -1) + "FBIK chain length is 0, can't initiate solver." + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F55 RID: 28501 RVA: 0x0034C210 File Offset: 0x0034A410
		public string ECOKJKJBGDH()
		{
			string text = "FishOnRod";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.MJCJIEPAEJP(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[3];
					array[0] = text;
					array[0] = " ";
					array[8] = JNBICAJIJMM.DBMJJPBOPEK().DOEMGEAEBPN("inv_post");
					array[3] = "_AdaptationMin";
					array[0] = JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 0)
				{
					string[] array2 = new string[7];
					array2[0] = text;
					array2[0] = "_Offsets";
					array2[3] = JNBICAJIJMM.LPHMKPDBMPP().HLBAJBLHLNI("Jump");
					array2[4] = "IceHockeyGoalieSave2";
					array2[5] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.IKGFHGKKCPG.LMGMPPAOPEP(this.PJPOJNNJOCD).JPBOPFNPNHC(true, -1) + "_SSRMultiplier" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F56 RID: 28502 RVA: 0x0034C314 File Offset: 0x0034A514
		public string GFOFDKDMEOG()
		{
			string text = "VaderChoke";
			if (this.GPJFINFIDLN == 1)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[]
					{
						null,
						text
					};
					array[0] = "\n";
					array[1] = JNBICAJIJMM.IMLLGEMPHAP().HEIBEHAEHBM("Here you can overview common ACTk features and try to cheat something yourself.");
					array[4] = "IdleFight";
					array[1] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[0];
					array2[0] = text;
					array2[1] = "ElvisLegsLoop";
					array2[0] = JNBICAJIJMM.CLIMNFDGOEG().NLJOLOBPCBJ("Wizard2HandThrow");
					array2[0] = "SneakBackward";
					array2[5] = JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.AGCBLDIBMNB().LMGMPPAOPEP(this.PJPOJNNJOCD).JPBOPFNPNHC(false, -1) + "Lasso Back" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F57 RID: 28503 RVA: 0x0034C418 File Offset: 0x0034A618
		public string OJNIDMFGAKO()
		{
			string text = "WATER_REFLECTIVE";
			if (this.GPJFINFIDLN == 1)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FBPECNNPIDP(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[3];
					array[0] = text;
					array[1] = "ClimbRight";
					array[3] = JNBICAJIJMM.EEOPOHEALPK().HLBAJBLHLNI("StormStrike");
					array[2] = "isRagulaSet";
					array[1] = JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[5];
					array2[0] = text;
					array2[0] = "Antares Console";
					array2[1] = JNBICAJIJMM.APMJBBDBOJO().HEIBEHAEHBM("_HeightParams");
					array2[0] = "_Skybox";
					array2[5] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.EDKKJNHDBPF().GBKMHIGNKJA(this.PJPOJNNJOCD).IGDKBMGKKDO(true, -1) + "_CameraClipInfo" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F58 RID: 28504 RVA: 0x0034C51C File Offset: 0x0034A71C
		public string GPHEPANIIKP()
		{
			string text = "intensity";
			if (this.GPJFINFIDLN == 1)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FBPECNNPIDP(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[0];
					array[1] = text;
					array[0] = "DepthTolerance";
					array[2] = JNBICAJIJMM.EDKGBBIIBBC().FLEANFGEJML("[S ");
					array[5] = "uierror6.wav";
					array[4] = JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[0];
					array2[0] = text;
					array2[0] = "?";
					array2[0] = JNBICAJIJMM.CLIMNFDGOEG().HLBAJBLHLNI("VolumetricFogAndMist/CopyDepth");
					array2[2] = "ComeHere";
					array2[1] = JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.PJPOJNNJOCD).MPKGPJJKCPK(true, -1) + "rollSoundPitch" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F59 RID: 28505 RVA: 0x0034C620 File Offset: 0x0034A820
		public string KBLHJENNKCD()
		{
			string text = "CratePush";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[1];
					array[0] = text;
					array[1] = "OfficeSittingBack";
					array[7] = JNBICAJIJMM.LPHMKPDBMPP().CKAOHMEKLMH("IceHockeyDekeMiddle");
					array[5] = "_DayToNight";
					array[8] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 0)
				{
					string[] array2 = new string[]
					{
						null,
						text
					};
					array2[0] = "_History3Weight";
					array2[0] = JNBICAJIJMM.EKEBHIJMEML().HLBAJBLHLNI("Vertical");
					array2[6] = "__c";
					array2[8] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.JHAAMBEFENP().LMGMPPAOPEP(this.PJPOJNNJOCD).CGMGBGABLFB(true, -1) + "isWoman" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F5A RID: 28506 RVA: 0x0034C724 File Offset: 0x0034A924
		public string EOKJPDNFCLO()
		{
			string text = "1HandHeavySwing2";
			if (this.GPJFINFIDLN == 1)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.MJCJIEPAEJP(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[]
					{
						text,
						"UIChat_fontInterval"
					};
					array[0] = JNBICAJIJMM.CLIMNFDGOEG().CCFFMKBBKHI("\n");
					array[1] = "isPaint";
					array[8] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 0)
				{
					string[] array2 = new string[0];
					array2[1] = text;
					array2[0] = "[ACTk] A decimal must be created from exactly 16 bytes";
					array2[0] = JNBICAJIJMM.EEOPOHEALPK().GNKIBMGNHNE("id");
					array2[8] = "reputaion/fractions/fraction";
					array2[2] = JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.OOIJFNAMEDP().LMGMPPAOPEP(this.PJPOJNNJOCD).MPKGPJJKCPK(true, -1) + "does not exist." + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F5B RID: 28507 RVA: 0x0034C828 File Offset: 0x0034AA28
		public string FJAPIIEMAND()
		{
			string text = "SexyDance3";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.MJCJIEPAEJP(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[3];
					array[0] = text;
					array[1] = "_SelectColor";
					array[2] = JNBICAJIJMM.APMJBBDBOJO().DOEMGEAEBPN("OnGround");
					array[4] = "Name: ";
					array[1] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 0)
				{
					string[] array2 = new string[7];
					array2[0] = text;
					array2[0] = "Vertical";
					array2[3] = JNBICAJIJMM.CLIMNFDGOEG().GNKIBMGNHNE("_FogOfWarSize");
					array2[5] = "u_UniqueShadowTexture";
					array2[6] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.OELKEADDKPE().GBKMHIGNKJA(this.PJPOJNNJOCD).CGMGBGABLFB(false, -1) + "bag" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F5C RID: 28508 RVA: 0x0034C92C File Offset: 0x0034AB2C
		public string LGKIGOGNLHM()
		{
			string text = "Katana";
			if (this.GPJFINFIDLN == 1)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.PCONBNOAMBH(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[]
					{
						null,
						text
					};
					array[1] = "";
					array[8] = JNBICAJIJMM.IMLLGEMPHAP().HLBAJBLHLNI("val=");
					array[6] = "SoccerKeeperDiveStrafeFarRight";
					array[2] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 0)
				{
					string[] array2 = new string[0];
					array2[1] = text;
					array2[1] = "WeaponReady";
					array2[6] = JNBICAJIJMM.CLIMNFDGOEG().GNKIBMGNHNE("\n");
					array2[2] = "******* playMusicBase  LocNewLogic";
					array2[8] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.IKGFHGKKCPG.LMGMPPAOPEP(this.PJPOJNNJOCD).CGMGBGABLFB(false, -1) + "Invalid bone hierarchy detected. IK requires for it's bones to be parented to each other in descending order." + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F5D RID: 28509 RVA: 0x0034CA30 File Offset: 0x0034AC30
		public string JEJCNPDEOAI()
		{
			string text = "Ambient Occlusion";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FFBIBLMCIGK(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 0)
				{
					string[] array = new string[]
					{
						text,
						"body"
					};
					array[1] = JNBICAJIJMM.DBMJJPBOPEK().DOEMGEAEBPN("Score: ");
					array[7] = "Ambient Occlusion";
					array[2] = JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 1)
				{
					string[] array2 = new string[4];
					array2[1] = text;
					array2[1] = "UIChat_channel";
					array2[3] = JNBICAJIJMM.EEOPOHEALPK().HLBAJBLHLNI("[ACTk] Are you trying to read regular PlayerPrefs data using ObscuredPrefs (key = ");
					array2[3] = "Attempting to set limb orientation to Vector3.zero axis";
					array2[8] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.IKGFHGKKCPG.IMCJNFHAFGE(this.PJPOJNNJOCD).MPKGPJJKCPK(false, -1) + "gi_um_lv" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x06006F5E RID: 28510 RVA: 0x0034CB34 File Offset: 0x0034AD34
		public string GEPMABHOIBP()
		{
			string text = "UNIQUE_SHADOW_LIGHT_COOKIE";
			if (this.GPJFINFIDLN == 0)
			{
				text = AKPJIACDDFI.IKGFHGKKCPG.FBPECNNPIDP(this.PJPOJNNJOCD);
				if (this.BEFPDJHBADA > 1)
				{
					string[] array = new string[]
					{
						null,
						text
					};
					array[1] = "Palm";
					array[0] = JNBICAJIJMM.LPHMKPDBMPP().HEIBEHAEHBM("_rcIn.ogg");
					array[2] = " locid=";
					array[0] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)this.BEFPDJHBADA);
					text = string.Concat(array);
				}
				if (this.IPEPNOMIFDJ > 0)
				{
					string[] array2 = new string[8];
					array2[1] = text;
					array2[0] = "_BloomTex";
					array2[6] = JNBICAJIJMM.EEOPOHEALPK().FLEANFGEJML("1");
					array2[1] = "_Distortion";
					array2[7] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)this.IPEPNOMIFDJ);
					text = string.Concat(array2);
				}
			}
			if (this.GPJFINFIDLN == 0)
			{
				text = IHFEDJEMJMB.EDKKJNHDBPF().NKMGKJLONDK(this.PJPOJNNJOCD).IGDKBMGKKDO(true, -1) + "act_order" + this.ECCEIPJIBBK;
			}
			return text;
		}

		// Token: 0x04001053 RID: 4179
		public int GPJFINFIDLN;

		// Token: 0x04001054 RID: 4180
		public int PJPOJNNJOCD;

		// Token: 0x04001055 RID: 4181
		public int ECCEIPJIBBK;

		// Token: 0x04001056 RID: 4182
		public int JLOMMBBNBBL;

		// Token: 0x04001057 RID: 4183
		public int BEFPDJHBADA;

		// Token: 0x04001058 RID: 4184
		public int IPEPNOMIFDJ;

		// Token: 0x04001059 RID: 4185
		public int NCFMLFIIEGA;
	}

	// Token: 0x020001E3 RID: 483
	public class OKOAMCJGNMH
	{
		// Token: 0x06006F5F RID: 28511 RVA: 0x0034CC38 File Offset: 0x0034AE38
		public OKOAMCJGNMH(XmlNode JEEEOEBNJDJ, int PMKJKLBJCBM)
		{
			this.BKLCKNOLEFD = PMKJKLBJCBM;
			this.LPFKFNLHGBI = int.Parse(JEEEOEBNJDJ.Attributes["id"].Value);
			this.DPJIBJLPFEL = int.Parse(JEEEOEBNJDJ.Attributes["category"].Value);
			this.DGMNCGFAMBL = 0;
			if (JEEEOEBNJDJ.Attributes["type"] != null)
			{
				this.DGMNCGFAMBL = int.Parse(JEEEOEBNJDJ.Attributes["type"].Value);
			}
			foreach (object obj in JEEEOEBNJDJ.ChildNodes)
			{
				XmlNode xmlNode = (XmlNode)obj;
				BNOOIOKIFJC.DIGGOHPGCNN diggohpgcnn = new BNOOIOKIFJC.DIGGOHPGCNN(xmlNode.Name + "=" + xmlNode.InnerText);
				if (diggohpgcnn.OKEBIHBDEOO("result_id"))
				{
					this.MNFCAAIAGOL = diggohpgcnn.NKBGGIFKLLB;
				}
				if (diggohpgcnn.OKEBIHBDEOO("req_prof"))
				{
					this.ABLFIGDGCBG = diggohpgcnn.DIKKDGKIPEA;
				}
				if (diggohpgcnn.OKEBIHBDEOO("profy_minlevel"))
				{
					this.LKCIDOHHADJ = diggohpgcnn.DIKKDGKIPEA;
				}
				if (diggohpgcnn.OKEBIHBDEOO("craft_time"))
				{
					this.JLFDJJMNFKK = diggohpgcnn.DIKKDGKIPEA;
				}
				if (diggohpgcnn.OKEBIHBDEOO("componentA"))
				{
					this.AGDBFHLEFEE.Add(diggohpgcnn.FCIMOMDBEDL);
				}
				if (diggohpgcnn.OKEBIHBDEOO("componentB"))
				{
					this.AGDBFHLEFEE.Add(diggohpgcnn.FCIMOMDBEDL);
				}
				if (diggohpgcnn.OKEBIHBDEOO("componentC"))
				{
					this.AGDBFHLEFEE.Add(diggohpgcnn.FCIMOMDBEDL);
				}
				if (diggohpgcnn.OKEBIHBDEOO("componentD"))
				{
					this.AGDBFHLEFEE.Add(diggohpgcnn.FCIMOMDBEDL);
				}
				if (diggohpgcnn.OKEBIHBDEOO("passive"))
				{
					this.AGDBFHLEFEE.Add(diggohpgcnn.FCIMOMDBEDL);
				}
				if (diggohpgcnn.OKEBIHBDEOO("ingredients"))
				{
					foreach (object obj2 in xmlNode.ChildNodes)
					{
						XmlNode xmlNode2 = (XmlNode)obj2;
						this.HEBKGNHIDLK.Add(new CLFFOBKFKDN.HFGDDPAKPBE(xmlNode2.InnerText));
					}
				}
			}
		}

		// Token: 0x0400105A RID: 4186
		public int LPFKFNLHGBI;

		// Token: 0x0400105B RID: 4187
		public int DPJIBJLPFEL;

		// Token: 0x0400105C RID: 4188
		public IIBEEKCAAHK MNFCAAIAGOL;

		// Token: 0x0400105D RID: 4189
		public int DGMNCGFAMBL;

		// Token: 0x0400105E RID: 4190
		public int ABLFIGDGCBG;

		// Token: 0x0400105F RID: 4191
		public int BKLCKNOLEFD;

		// Token: 0x04001060 RID: 4192
		public int JLFDJJMNFKK;

		// Token: 0x04001061 RID: 4193
		public int LKCIDOHHADJ;

		// Token: 0x04001062 RID: 4194
		public List<CLFFOBKFKDN.HFGDDPAKPBE> HEBKGNHIDLK = new List<CLFFOBKFKDN.HFGDDPAKPBE>();

		// Token: 0x04001063 RID: 4195
		public List<IIBEEKCAAHK> AGDBFHLEFEE = new List<IIBEEKCAAHK>();
	}

	// Token: 0x020001E4 RID: 484
	public class DNOEMMJAJHD : ItemBase
	{
		// Token: 0x06006F60 RID: 28512 RVA: 0x0034CEC8 File Offset: 0x0034B0C8
		private void FDNDCOADIOB(HBPNMNGOFMA KADBECGIMPD)
		{
			this.MNFCAAIAGOL = KADBECGIMPD.CMIFMMMBBNO();
			this.ILFHHDNJHNM = KADBECGIMPD.DOJKJHMJJNK();
			this.LGGDCMEHHKB = KADBECGIMPD.OEHCLGOFDPN();
			this.JLFDJJMNFKK = KADBECGIMPD.AGNKAFLKCAG();
			this.EPGGMPEIPBC = KADBECGIMPD.AGNKAFLKCAG();
			this.ABLFIGDGCBG = KADBECGIMPD.IFDFHJLCHAE();
			this.LKCIDOHHADJ = KADBECGIMPD.IFDFHJLCHAE();
			int num = KADBECGIMPD.LDLKLPJBIJN();
			for (int i = 0; i < num; i++)
			{
				IIBEEKCAAHK bdgecgghecb = KADBECGIMPD.ANALPOIJPHJ();
				int fnadkbpagjh = KADBECGIMPD.CLPEKGGAMAI();
				int dailmanbnmm = KADBECGIMPD.HHLDBAEFNMJ();
				int khleenblfbn = KADBECGIMPD.LDLKLPJBIJN();
				this.HEBKGNHIDLK.Add(new CLFFOBKFKDN.HFGDDPAKPBE(bdgecgghecb, fnadkbpagjh, dailmanbnmm, khleenblfbn));
			}
			this.BDHHPAEHFHG = IHFEDJEMJMB.IKGFHGKKCPG.IMCJNFHAFGE(this.MNFCAAIAGOL.NKEOCCKEOCE());
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.HKHPGCHCHAI();
			}
			this.KEKFOFFEBEF = false;
		}

		// Token: 0x06006F61 RID: 28513 RVA: 0x0034CFA8 File Offset: 0x0034B1A8
		public void AJPILNENAKP()
		{
			this.NOKCCPCECPN = 9999;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
			if (this.KEKFOFFEBEF)
			{
				if (!this.LEKGMMLNHEG.DIFFCNOPHBJ)
				{
					this.LEKGMMLNHEG.ECDMPPDLHHH = (double)kfhelhglnmh.BJDIEKNHGLJ(this.LEKGMMLNHEG.IBEIBAHKIAH, true, 0);
					int num = this.LEKGMMLNHEG.KEJCINHLMBC / (this.LEKGMMLNHEG.ICJDPPOJINN + this.LEKGMMLNHEG.LKAGIEBPLAI);
					if (num < this.NOKCCPCECPN)
					{
						this.NOKCCPCECPN = num;
					}
				}
				if (!this.CPJCMJIMGME.DIFFCNOPHBJ)
				{
					this.CPJCMJIMGME.ECDMPPDLHHH = (double)kfhelhglnmh.BJDIEKNHGLJ(this.CPJCMJIMGME.IBEIBAHKIAH, true, 0);
					int num2 = this.CPJCMJIMGME.KEJCINHLMBC / (this.CPJCMJIMGME.ICJDPPOJINN + this.CPJCMJIMGME.LKAGIEBPLAI);
					if (num2 < this.NOKCCPCECPN)
					{
						this.NOKCCPCECPN = num2;
					}
				}
				if (!this.BKAICJFFMBG.DIFFCNOPHBJ)
				{
					this.BKAICJFFMBG.ECDMPPDLHHH = (double)kfhelhglnmh.BJDIEKNHGLJ(this.BKAICJFFMBG.IBEIBAHKIAH, true, 0);
					int num3 = this.BKAICJFFMBG.KEJCINHLMBC / (this.BKAICJFFMBG.ICJDPPOJINN + this.BKAICJFFMBG.LKAGIEBPLAI);
					if (num3 < this.NOKCCPCECPN)
					{
						this.NOKCCPCECPN = num3;
					}
				}
				if (this.KOMIMKKAEJA.IBEIBAHKIAH > 0)
				{
					this.KOMIMKKAEJA.ECDMPPDLHHH = (double)kfhelhglnmh.BJDIEKNHGLJ(this.KOMIMKKAEJA.IBEIBAHKIAH, true, 0);
					if (this.KOMIMKKAEJA.LKAGIEBPLAI + this.KOMIMKKAEJA.ICJDPPOJINN > 0)
					{
						int num4 = this.KOMIMKKAEJA.KEJCINHLMBC / (this.KOMIMKKAEJA.ICJDPPOJINN + this.KOMIMKKAEJA.LKAGIEBPLAI);
						if (num4 < this.NOKCCPCECPN)
						{
							this.NOKCCPCECPN = num4;
						}
					}
				}
				if (this.CHFNJDFHJGN.IBEIBAHKIAH > 0)
				{
					this.CHFNJDFHJGN.ECDMPPDLHHH = (double)kfhelhglnmh.BJDIEKNHGLJ(this.CHFNJDFHJGN.IBEIBAHKIAH, true, 0);
					if (this.CHFNJDFHJGN.ICJDPPOJINN > 0)
					{
						int num5 = this.CHFNJDFHJGN.KEJCINHLMBC / this.CHFNJDFHJGN.ICJDPPOJINN;
						if (num5 < this.NOKCCPCECPN)
						{
							this.NOKCCPCECPN = num5;
						}
					}
				}
				this.HLBPDCJHFIO = this.LEKGMMLNHEG.LKAGIEBPLAI + this.CPJCMJIMGME.LKAGIEBPLAI + this.BKAICJFFMBG.LKAGIEBPLAI;
			}
			else
			{
				foreach (CLFFOBKFKDN.HFGDDPAKPBE hfgddpakpbe in this.HEBKGNHIDLK)
				{
					if (hfgddpakpbe.GPJFINFIDLN == 0)
					{
						int num6 = kfhelhglnmh.BJDIEKNHGLJ(hfgddpakpbe.PJPOJNNJOCD, true, hfgddpakpbe.BEFPDJHBADA) / hfgddpakpbe.ECCEIPJIBBK;
						if (num6 < this.NOKCCPCECPN)
						{
							this.NOKCCPCECPN = num6;
						}
					}
					if (hfgddpakpbe.GPJFINFIDLN == 1)
					{
						int num7 = kfhelhglnmh.DABGGGPDFIM(hfgddpakpbe.PJPOJNNJOCD, true, hfgddpakpbe.BEFPDJHBADA, hfgddpakpbe.IPEPNOMIFDJ, hfgddpakpbe.NCFMLFIIEGA) / hfgddpakpbe.ECCEIPJIBBK;
						if (num7 < this.NOKCCPCECPN)
						{
							this.NOKCCPCECPN = num7;
						}
					}
				}
			}
			if (this.ILFHHDNJHNM >= 0 && this.NOKCCPCECPN > this.ILFHHDNJHNM)
			{
				this.NOKCCPCECPN = this.ILFHHDNJHNM;
			}
		}

		// Token: 0x06006F62 RID: 28514 RVA: 0x0034D2F8 File Offset: 0x0034B4F8
		public override string ToString()
		{
			string text = "???";
			if (this.BDHHPAEHFHG != null)
			{
				text = this.BDHHPAEHFHG.BNIHFBMEPAB;
			}
			if (this.MNFCAAIAGOL.ICJDPPOJINN > 1)
			{
				text = text + " x" + this.MNFCAAIAGOL.ICJDPPOJINN;
			}
			return text;
		}

		// Token: 0x06006F63 RID: 28515 RVA: 0x0034D34C File Offset: 0x0034B54C
		public virtual CKNLPGEPGGF.IAPCJOBDCEH DEOMJEEMGMI()
		{
			return null;
		}

		// Token: 0x06006F64 RID: 28516 RVA: 0x0034D35C File Offset: 0x0034B55C
		public void NFHHNIJAOBE()
		{
			this.HLBPDCJHFIO = 0;
			this.HLBPDCJHFIO += this.LEKGMMLNHEG.KIDKOFKNPEP();
			this.HLBPDCJHFIO += this.CPJCMJIMGME.LKAGIEBPLAI;
			this.HLBPDCJHFIO += this.BKAICJFFMBG.KIDKOFKNPEP();
		}

		// Token: 0x06006F65 RID: 28517 RVA: 0x0034D3B8 File Offset: 0x0034B5B8
		public override CKNLPGEPGGF.IAPCJOBDCEH EJJAGEFMHCO()
		{
			return null;
		}

		// Token: 0x06006F66 RID: 28518 RVA: 0x0034D3C8 File Offset: 0x0034B5C8
		public virtual CKNLPGEPGGF.IAPCJOBDCEH HKHAONBKECM()
		{
			return null;
		}

		// Token: 0x06006F67 RID: 28519 RVA: 0x0034D3D8 File Offset: 0x0034B5D8
		private void JIJFKCGCNIP(HBPNMNGOFMA KADBECGIMPD)
		{
			this.MNFCAAIAGOL = KADBECGIMPD.EIMAIEJKHKF();
			this.ILFHHDNJHNM = KADBECGIMPD.HDBGOLAFOBK();
			this.LGGDCMEHHKB = KADBECGIMPD.EIMAIEJKHKF();
			this.JLFDJJMNFKK = KADBECGIMPD.HDBGOLAFOBK();
			this.EPGGMPEIPBC = KADBECGIMPD.HDBGOLAFOBK();
			this.ABLFIGDGCBG = KADBECGIMPD.HDBGOLAFOBK();
			this.LKCIDOHHADJ = KADBECGIMPD.HDBGOLAFOBK();
			int num = KADBECGIMPD.HDBGOLAFOBK();
			for (int i = 0; i < num; i++)
			{
				IIBEEKCAAHK bdgecgghecb = KADBECGIMPD.EIMAIEJKHKF();
				int fnadkbpagjh = KADBECGIMPD.HDBGOLAFOBK();
				int dailmanbnmm = KADBECGIMPD.HDBGOLAFOBK();
				int khleenblfbn = KADBECGIMPD.HDBGOLAFOBK();
				this.HEBKGNHIDLK.Add(new CLFFOBKFKDN.HFGDDPAKPBE(bdgecgghecb, fnadkbpagjh, dailmanbnmm, khleenblfbn));
			}
			this.BDHHPAEHFHG = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.MNFCAAIAGOL.IBEIBAHKIAH);
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JIFFLPNBILE();
			}
			this.KEKFOFFEBEF = false;
		}

		// Token: 0x06006F68 RID: 28520 RVA: 0x0034D4B8 File Offset: 0x0034B6B8
		public virtual string JJPMKNKFPPN()
		{
			string text = "_AllowBackwardsRays";
			if (this.BDHHPAEHFHG != null)
			{
				text = this.BDHHPAEHFHG.BNIHFBMEPAB;
			}
			if (this.MNFCAAIAGOL.KMGAHCANELI() > 1)
			{
				text = text + "Try to change this Vector3 in memory:\n" + this.MNFCAAIAGOL.NLHKFMMDMMK();
			}
			return text;
		}

		// Token: 0x06006F69 RID: 28521 RVA: 0x0034D50C File Offset: 0x0034B70C
		public virtual string NIDKKALEJIM()
		{
			string text = "#000000";
			if (this.BDHHPAEHFHG != null)
			{
				text = this.BDHHPAEHFHG.BNIHFBMEPAB;
			}
			if (this.MNFCAAIAGOL.KMGAHCANELI() > 1)
			{
				text = text + "SoccerWalk" + this.MNFCAAIAGOL.ICJDPPOJINN;
			}
			return text;
		}

		// Token: 0x06006F6A RID: 28522 RVA: 0x0034D560 File Offset: 0x0034B760
		public void MKILFCHOEFJ()
		{
			this.NOKCCPCECPN = 173;
			NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
			if (this.KEKFOFFEBEF)
			{
				if (!this.LEKGMMLNHEG.DIFFCNOPHBJ)
				{
					this.LEKGMMLNHEG.CJFCIFAJNJA((double)kfhelhglnmh.BJDIEKNHGLJ(this.LEKGMMLNHEG.KEHIFGILLJA(), true, 1));
					int num = this.LEKGMMLNHEG.MLNEJIIGOMG() / (this.LEKGMMLNHEG.KMGAHCANELI() + this.LEKGMMLNHEG.MCJJCAFILPF());
					if (num < this.NOKCCPCECPN)
					{
						this.NOKCCPCECPN = num;
					}
				}
				if (!this.CPJCMJIMGME.CHOHHHOLIBJ())
				{
					this.CPJCMJIMGME.CGLGAFHNJGK((double)kfhelhglnmh.BJDIEKNHGLJ(this.CPJCMJIMGME.KMIOLLENCOL(), false, 1));
					int num2 = this.CPJCMJIMGME.OAMPMLIIJPH() / (this.CPJCMJIMGME.KMGAHCANELI() + this.CPJCMJIMGME.PBMJIMLEHEC());
					if (num2 < this.NOKCCPCECPN)
					{
						this.NOKCCPCECPN = num2;
					}
				}
				if (!this.BKAICJFFMBG.CHOHHHOLIBJ())
				{
					this.BKAICJFFMBG.CGLGAFHNJGK((double)kfhelhglnmh.BJDIEKNHGLJ(this.BKAICJFFMBG.NKEOCCKEOCE(), false, 0));
					int num3 = this.BKAICJFFMBG.MLNEJIIGOMG() / (this.BKAICJFFMBG.KMGAHCANELI() + this.BKAICJFFMBG.KIDKOFKNPEP());
					if (num3 < this.NOKCCPCECPN)
					{
						this.NOKCCPCECPN = num3;
					}
				}
				if (this.KOMIMKKAEJA.KMIOLLENCOL() > 0)
				{
					this.KOMIMKKAEJA.CGLGAFHNJGK((double)kfhelhglnmh.BJDIEKNHGLJ(this.KOMIMKKAEJA.KEHIFGILLJA(), true, 0));
					if (this.KOMIMKKAEJA.ACEPOCLANAG() + this.KOMIMKKAEJA.ICJDPPOJINN > 0)
					{
						int num4 = this.KOMIMKKAEJA.PKEBKANNBJD() / (this.KOMIMKKAEJA.ICJDPPOJINN + this.KOMIMKKAEJA.KMNOIAIBLEB());
						if (num4 < this.NOKCCPCECPN)
						{
							this.NOKCCPCECPN = num4;
						}
					}
				}
				if (this.CHFNJDFHJGN.KEHIFGILLJA() > 0)
				{
					this.CHFNJDFHJGN.JKMBJCCIGHB((double)kfhelhglnmh.BJDIEKNHGLJ(this.CHFNJDFHJGN.KMIOLLENCOL(), true, 0));
					if (this.CHFNJDFHJGN.KMGAHCANELI() > 1)
					{
						int num5 = this.CHFNJDFHJGN.MLNEJIIGOMG() / this.CHFNJDFHJGN.ICJDPPOJINN;
						if (num5 < this.NOKCCPCECPN)
						{
							this.NOKCCPCECPN = num5;
						}
					}
				}
				this.HLBPDCJHFIO = this.LEKGMMLNHEG.MCJJCAFILPF() + this.CPJCMJIMGME.LKAGIEBPLAI + this.BKAICJFFMBG.KIDKOFKNPEP();
			}
			else
			{
				foreach (CLFFOBKFKDN.HFGDDPAKPBE hfgddpakpbe in this.HEBKGNHIDLK)
				{
					if (hfgddpakpbe.GPJFINFIDLN == 0)
					{
						int num6 = kfhelhglnmh.BJDIEKNHGLJ(hfgddpakpbe.PJPOJNNJOCD, true, hfgddpakpbe.BEFPDJHBADA) / hfgddpakpbe.ECCEIPJIBBK;
						if (num6 < this.NOKCCPCECPN)
						{
							this.NOKCCPCECPN = num6;
						}
					}
					if (hfgddpakpbe.GPJFINFIDLN == 0)
					{
						int num7 = kfhelhglnmh.DABGGGPDFIM(hfgddpakpbe.PJPOJNNJOCD, false, hfgddpakpbe.BEFPDJHBADA, hfgddpakpbe.IPEPNOMIFDJ, hfgddpakpbe.NCFMLFIIEGA) / hfgddpakpbe.ECCEIPJIBBK;
						if (num7 < this.NOKCCPCECPN)
						{
							this.NOKCCPCECPN = num7;
						}
					}
				}
			}
			if (this.ILFHHDNJHNM >= 1 && this.NOKCCPCECPN > this.ILFHHDNJHNM)
			{
				this.NOKCCPCECPN = this.ILFHHDNJHNM;
			}
		}

		// Token: 0x06006F6B RID: 28523 RVA: 0x0034D8B0 File Offset: 0x0034BAB0
		public void JEDDGGGGOCJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = KADBECGIMPD.CLPEKGGAMAI();
			this.BKLCKNOLEFD = KADBECGIMPD.HHLDBAEFNMJ();
			this.DGMNCGFAMBL = KADBECGIMPD.CLPEKGGAMAI();
			int dgmncgfambl = this.DGMNCGFAMBL;
			if (dgmncgfambl == 0)
			{
				this.JIJFKCGCNIP(KADBECGIMPD);
				return;
			}
			if (dgmncgfambl != 1)
			{
				return;
			}
			this.OAKCFGOLKLA(KADBECGIMPD);
		}

		// Token: 0x06006F6C RID: 28524 RVA: 0x0034D900 File Offset: 0x0034BB00
		public virtual CKNLPGEPGGF.IAPCJOBDCEH JKEFCDPEGPG()
		{
			return null;
		}

		// Token: 0x06006F6E RID: 28526 RVA: 0x0034D968 File Offset: 0x0034BB68
		public override void GKDJCJKMBEN(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			Rect ochcodjiphj = new Rect(COAGIAMOCIA.x + 2f, COAGIAMOCIA.y + 2f, COAGIAMOCIA.height - 4f, COAGIAMOCIA.height - 4f);
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.FCBHHPJLGLC(ochcodjiphj, this.BDHHPAEHFHG.KBGHOIJIPJF, true, 0);
			}
			else
			{
				ochcodjiphj.width = 0f;
			}
			int fontSize = OFPNEDEAMAB.fontSize;
			string arg = "#000000";
			if (this.NOKCCPCECPN == 0)
			{
				arg = "#404040";
			}
			string arg2 = "";
			if (this.NOKCCPCECPN > 0)
			{
				arg2 = "(" + this.NOKCCPCECPN + ")";
			}
			OFPNEDEAMAB.fontSize = 9;
			GUI.Label(new Rect(COAGIAMOCIA.x + 8f + ochcodjiphj.width, COAGIAMOCIA.y - 8f, COAGIAMOCIA.width - 15f - ochcodjiphj.width, COAGIAMOCIA.height), string.Format("<color='{0}'>{1}</color>", arg, IHFEDJEMJMB.IKGFHGKKCPG.JGLANEDNNAB(this.BDHHPAEHFHG.MBKMKGABBGE)), OFPNEDEAMAB);
			OFPNEDEAMAB.fontSize = 12;
			GUI.Label(new Rect(COAGIAMOCIA.x + 8f + ochcodjiphj.width, COAGIAMOCIA.y + 4f, COAGIAMOCIA.width - 15f - ochcodjiphj.width, COAGIAMOCIA.height), string.Format("<color='{0}'>{1}  {2}</color>", arg, this.ToString(), arg2), OFPNEDEAMAB);
			OFPNEDEAMAB.fontSize = fontSize;
		}

		// Token: 0x06006F6F RID: 28527 RVA: 0x0034DB00 File Offset: 0x0034BD00
		public void OFDFBEKDGMB()
		{
			this.HLBPDCJHFIO = 0;
			this.HLBPDCJHFIO += this.LEKGMMLNHEG.LKAGIEBPLAI;
			this.HLBPDCJHFIO += this.CPJCMJIMGME.LKAGIEBPLAI;
			this.HLBPDCJHFIO += this.BKAICJFFMBG.LKAGIEBPLAI;
		}

		// Token: 0x06006F70 RID: 28528 RVA: 0x0034DB5C File Offset: 0x0034BD5C
		public void PMCNPIHAMMD()
		{
			this.HLBPDCJHFIO = 1;
			this.HLBPDCJHFIO += this.LEKGMMLNHEG.LKAGIEBPLAI;
			this.HLBPDCJHFIO += this.CPJCMJIMGME.KIDKOFKNPEP();
			this.HLBPDCJHFIO += this.BKAICJFFMBG.MCJJCAFILPF();
		}

		// Token: 0x06006F71 RID: 28529 RVA: 0x0034DBB8 File Offset: 0x0034BDB8
		public void ACJDDOEADFK(HBPNMNGOFMA KADBECGIMPD)
		{
			this.LPFKFNLHGBI = KADBECGIMPD.HDBGOLAFOBK();
			this.BKLCKNOLEFD = KADBECGIMPD.HDBGOLAFOBK();
			this.DGMNCGFAMBL = KADBECGIMPD.HDBGOLAFOBK();
			int dgmncgfambl = this.DGMNCGFAMBL;
			if (dgmncgfambl == 0)
			{
				this.JIJFKCGCNIP(KADBECGIMPD);
				return;
			}
			if (dgmncgfambl != 1)
			{
				return;
			}
			this.OAKCFGOLKLA(KADBECGIMPD);
		}

		// Token: 0x06006F72 RID: 28530 RVA: 0x0034DC08 File Offset: 0x0034BE08
		private void LEGBNCDGAJJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.MNFCAAIAGOL = KADBECGIMPD.JIFFKNJHLCM();
			this.ILFHHDNJHNM = KADBECGIMPD.HHLDBAEFNMJ();
			this.LGGDCMEHHKB = KADBECGIMPD.JEHOEBJMMOI();
			this.JLFDJJMNFKK = KADBECGIMPD.DOJKJHMJJNK();
			this.EPGGMPEIPBC = KADBECGIMPD.AGNKAFLKCAG();
			this.ABLFIGDGCBG = KADBECGIMPD.KKOKFLMMAAK();
			this.LKCIDOHHADJ = KADBECGIMPD.KKOKFLMMAAK();
			this.MBLNDMIAFAM = KADBECGIMPD.DOJKJHMJJNK();
			this.LEKGMMLNHEG = KADBECGIMPD.JEHOEBJMMOI();
			this.CPJCMJIMGME = KADBECGIMPD.LICHMNLLOAB();
			this.BKAICJFFMBG = KADBECGIMPD.HMCONBPNFJH();
			this.OFBGBDGKHCF = KADBECGIMPD.OFGFAEJNKEH();
			this.CHFNJDFHJGN = KADBECGIMPD.JEHOEBJMMOI();
			this.HPPBKIJEOED = KADBECGIMPD.AIDAGFNHNHE();
			this.KOMIMKKAEJA = KADBECGIMPD.DAKECHGPCFI();
			int num = this.KOMIMKKAEJA.ICJDPPOJINN;
			this.KOMIMKKAEJA = new IIBEEKCAAHK((double)this.KOMIMKKAEJA.KMIOLLENCOL(), 1543.0, (double)this.KOMIMKKAEJA.KGKNPAAMDJK);
			this.KOMIMKKAEJA.MIJKHGIGELG = (double)num;
			this.BDHHPAEHFHG = IHFEDJEMJMB.JHAAMBEFENP().LMGMPPAOPEP(this.MNFCAAIAGOL.IBEIBAHKIAH);
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.KEICEAJOGFD();
			}
			this.KEKFOFFEBEF = false;
			Debug.Log("allrec.ogg" + this.LEKGMMLNHEG);
		}

		// Token: 0x06006F73 RID: 28531 RVA: 0x0034DD58 File Offset: 0x0034BF58
		private void OAKCFGOLKLA(HBPNMNGOFMA KADBECGIMPD)
		{
			this.MNFCAAIAGOL = KADBECGIMPD.EIMAIEJKHKF();
			this.ILFHHDNJHNM = KADBECGIMPD.HDBGOLAFOBK();
			this.LGGDCMEHHKB = KADBECGIMPD.EIMAIEJKHKF();
			this.JLFDJJMNFKK = KADBECGIMPD.HDBGOLAFOBK();
			this.EPGGMPEIPBC = KADBECGIMPD.HDBGOLAFOBK();
			this.ABLFIGDGCBG = KADBECGIMPD.HDBGOLAFOBK();
			this.LKCIDOHHADJ = KADBECGIMPD.HDBGOLAFOBK();
			this.MBLNDMIAFAM = KADBECGIMPD.HDBGOLAFOBK();
			this.LEKGMMLNHEG = KADBECGIMPD.EIMAIEJKHKF();
			this.CPJCMJIMGME = KADBECGIMPD.EIMAIEJKHKF();
			this.BKAICJFFMBG = KADBECGIMPD.EIMAIEJKHKF();
			this.OFBGBDGKHCF = KADBECGIMPD.EIMAIEJKHKF();
			this.CHFNJDFHJGN = KADBECGIMPD.EIMAIEJKHKF();
			this.HPPBKIJEOED = KADBECGIMPD.FFDPCEAFGNF();
			this.KOMIMKKAEJA = KADBECGIMPD.EIMAIEJKHKF();
			int num = this.KOMIMKKAEJA.ICJDPPOJINN;
			this.KOMIMKKAEJA = new IIBEEKCAAHK((double)this.KOMIMKKAEJA.IBEIBAHKIAH, 0.0, (double)this.KOMIMKKAEJA.KGKNPAAMDJK);
			this.KOMIMKKAEJA.MIJKHGIGELG = (double)num;
			this.BDHHPAEHFHG = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.MNFCAAIAGOL.IBEIBAHKIAH);
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.JIFFLPNBILE();
			}
			this.KEKFOFFEBEF = true;
			Debug.Log("componentA=" + this.LEKGMMLNHEG);
		}

		// Token: 0x06006F74 RID: 28532 RVA: 0x0034DEA8 File Offset: 0x0034C0A8
		public virtual void KAJMEFHALNL(Rect COAGIAMOCIA, GUIStyle OFPNEDEAMAB)
		{
			Rect ochcodjiphj = new Rect(COAGIAMOCIA.x + 894f, COAGIAMOCIA.y + 1990f, COAGIAMOCIA.height - 898f, COAGIAMOCIA.height - 1873f);
			if (this.BDHHPAEHFHG != null)
			{
				this.BDHHPAEHFHG.GDLELABHHFG(ochcodjiphj, this.BDHHPAEHFHG.KBGHOIJIPJF, true, 0);
			}
			else
			{
				ochcodjiphj.width = 411f;
			}
			int fontSize = OFPNEDEAMAB.fontSize;
			string arg = "_camScale";
			if (this.NOKCCPCECPN == 0)
			{
				arg = "BowFire";
			}
			string arg2 = "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_target.html";
			if (this.NOKCCPCECPN > 0)
			{
				arg2 = "wpn_rec5" + this.NOKCCPCECPN + "Cloud ";
			}
			OFPNEDEAMAB.fontSize = -104;
			GUI.Label(new Rect(COAGIAMOCIA.x + 483f + ochcodjiphj.width, COAGIAMOCIA.y - 1049f, COAGIAMOCIA.width - 1597f - ochcodjiphj.width, COAGIAMOCIA.height), string.Format("Mouse X", arg, IHFEDJEMJMB.EDKKJNHDBPF().GJIJPHLEHHF(this.BDHHPAEHFHG.MBKMKGABBGE)), OFPNEDEAMAB);
			OFPNEDEAMAB.fontSize = -55;
			GUI.Label(new Rect(COAGIAMOCIA.x + 851f + ochcodjiphj.width, COAGIAMOCIA.y + 795f, COAGIAMOCIA.width - 464f - ochcodjiphj.width, COAGIAMOCIA.height), string.Format("Downsamp", arg, this.ToString(), arg2), OFPNEDEAMAB);
			OFPNEDEAMAB.fontSize = fontSize;
		}

		// Token: 0x06006F75 RID: 28533 RVA: 0x0034E040 File Offset: 0x0034C240
		public virtual CKNLPGEPGGF.IAPCJOBDCEH LDDALIJPHNF()
		{
			return null;
		}

		// Token: 0x06006F76 RID: 28534 RVA: 0x0034E050 File Offset: 0x0034C250
		public void ACAAKLNHDIO()
		{
			this.HLBPDCJHFIO = 0;
			this.HLBPDCJHFIO += this.LEKGMMLNHEG.MCJJCAFILPF();
			this.HLBPDCJHFIO += this.CPJCMJIMGME.MCJJCAFILPF();
			this.HLBPDCJHFIO += this.BKAICJFFMBG.KIDKOFKNPEP();
		}

		// Token: 0x06006F77 RID: 28535 RVA: 0x0034E0AC File Offset: 0x0034C2AC
		public override CKNLPGEPGGF.IAPCJOBDCEH BHPAALLBMHL()
		{
			return null;
		}

		// Token: 0x06006F78 RID: 28536 RVA: 0x0034E0BC File Offset: 0x0034C2BC
		public virtual CKNLPGEPGGF.IAPCJOBDCEH PGFNEDLFAFD()
		{
			return null;
		}

		// Token: 0x04001064 RID: 4196
		public int LPFKFNLHGBI;

		// Token: 0x04001065 RID: 4197
		public int BKLCKNOLEFD;

		// Token: 0x04001066 RID: 4198
		public int DGMNCGFAMBL;

		// Token: 0x04001067 RID: 4199
		public bool KEKFOFFEBEF;

		// Token: 0x04001068 RID: 4200
		public int EPGGMPEIPBC;

		// Token: 0x04001069 RID: 4201
		public int ILFHHDNJHNM;

		// Token: 0x0400106A RID: 4202
		public BEFCHFNGOMI BDHHPAEHFHG;

		// Token: 0x0400106B RID: 4203
		public int NOKCCPCECPN;

		// Token: 0x0400106C RID: 4204
		public IIBEEKCAAHK MNFCAAIAGOL;

		// Token: 0x0400106D RID: 4205
		public IIBEEKCAAHK LGGDCMEHHKB;

		// Token: 0x0400106E RID: 4206
		public IIBEEKCAAHK KOMIMKKAEJA;

		// Token: 0x0400106F RID: 4207
		public float HPPBKIJEOED;

		// Token: 0x04001070 RID: 4208
		public int JLFDJJMNFKK;

		// Token: 0x04001071 RID: 4209
		public int ABLFIGDGCBG;

		// Token: 0x04001072 RID: 4210
		public int LKCIDOHHADJ;

		// Token: 0x04001073 RID: 4211
		public List<CLFFOBKFKDN.HFGDDPAKPBE> HEBKGNHIDLK = new List<CLFFOBKFKDN.HFGDDPAKPBE>();

		// Token: 0x04001074 RID: 4212
		public int MBLNDMIAFAM;

		// Token: 0x04001075 RID: 4213
		public IIBEEKCAAHK LEKGMMLNHEG = new IIBEEKCAAHK();

		// Token: 0x04001076 RID: 4214
		public IIBEEKCAAHK CPJCMJIMGME = new IIBEEKCAAHK();

		// Token: 0x04001077 RID: 4215
		public IIBEEKCAAHK BKAICJFFMBG = new IIBEEKCAAHK();

		// Token: 0x04001078 RID: 4216
		public IIBEEKCAAHK OFBGBDGKHCF = new IIBEEKCAAHK();

		// Token: 0x04001079 RID: 4217
		public IIBEEKCAAHK CHFNJDFHJGN = new IIBEEKCAAHK();

		// Token: 0x0400107A RID: 4218
		public long EIHJDJAKIBA;

		// Token: 0x0400107B RID: 4219
		public int HLBPDCJHFIO;
	}
}
