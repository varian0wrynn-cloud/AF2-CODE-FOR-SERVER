using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Token: 0x02000170 RID: 368
public class GameInterface : MonoBehaviour
{
	// Token: 0x06004F80 RID: 20352 RVA: 0x002429DC File Offset: 0x00240BDC
	private void MEGHJAJGDDE(ONKDCGNBALK ONPHLHKAGFP)
	{
		OIJEGJLCFCF dolfjggbdjf = this.DOLFJGGBDJF;
		if (dolfjggbdjf == null)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC.Add(dolfjggbdjf);
			this.DBELGCHKMOE.LACAJHOHACK.Remove(dolfjggbdjf);
			this.DBELGCHKMOE.AIGDILGELKO();
			this.OJJLLBKEGNO.LACAJHOHACK.Add(dolfjggbdjf);
			this.OJJLLBKEGNO.FNFFGIJOENM();
			epmphjgalbe.LHLOOIDHGMA(this.currentHolodId);
			epmphjgalbe.OBCCLNMPGEJ(dolfjggbdjf.LPFKFNLHGBI);
			NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(-90, epmphjgalbe.ALLANCHILCM());
			FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("<<", 1181f);
			this.DOAEGLOBFCD();
			this.NMOEPACMOHK();
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x06004F81 RID: 20353 RVA: 0x00242AB0 File Offset: 0x00240CB0
	public void openSadok(int HGCCAHPEFGO = 0, bool HAEEEHGKFMG = false)
	{
		this.currentSadokId = HGCCAHPEFGO;
		int count = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC.Count;
		if (HAEEEHGKFMG && this.sadokWinId > 0 && JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(this.sadokWinId) != null)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.sadokWinId);
			return;
		}
		if (this.sadokWinId > 0)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.sadokWinId);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(this.sadokWinId);
		if (onkdcgnbalk == null)
		{
			onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(952f, 505f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("sadok"), true);
		}
		else
		{
			onkdcgnbalk.MPKCOJHJIIB();
		}
		this.sadokWinId = onkdcgnbalk.LPFKFNLHGBI;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 130f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 120f, 24f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("close"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 130f - 250f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 120f, 24f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("release"), 12, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 130f - 375f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 120f, 24f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("brag"), 16, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress));
		Rect ochcodjiphj = new Rect(20f, 70f, 380f, onkdcgnbalk.OCHCODJIPHJ.height - 113f);
		new MGLHIBHDMPC(onkdcgnbalk, ochcodjiphj, this.PaperTexture);
		this.OJJLLBKEGNO = new MMKFAENBHKD(onkdcgnbalk, ochcodjiphj.x, ochcodjiphj.y, ochcodjiphj.width, ochcodjiphj.height, 0);
		new KLIKIJOLPPJ(onkdcgnbalk, this.OJJLLBKEGNO.OCHCODJIPHJ.x, onkdcgnbalk.OCHCODJIPHJ.height - 32f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("altosad"), 0, HPGKIJLKCIH.IKGFHGKKCPG.MPNJKJKDMLK).LJIEPIPIAJC = new ONKDCGNBALK.CMMHGMILOIM(this.DHJCIDBHIGJ);
		List<OIJEGJLCFCF> list = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC;
		if (this.currentSadokId == 1)
		{
			list = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KNFMGIBLMHB;
		}
		foreach (OIJEGJLCFCF oijegjlcfcf in list)
		{
			if (oijegjlcfcf.HGCCAHPEFGO == this.currentSadokId)
			{
				this.OJJLLBKEGNO.LACAJHOHACK.Add(oijegjlcfcf);
			}
		}
		ochcodjiphj = new Rect(420f, 46f, 512f, 390f);
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 0)
		{
			new MGLHIBHDMPC(onkdcgnbalk, ochcodjiphj, this.sadokImage);
			new EGCAADAABPP(onkdcgnbalk, ochcodjiphj.x, ochcodjiphj.y, ochcodjiphj.width, ochcodjiphj.height, "", 0, null).NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.sadokPanelRender);
		}
		new LCOLJOPGDLL(onkdcgnbalk, ochcodjiphj.x + 10f, ochcodjiphj.y + 8f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("csadok"), true);
		new MEMEOHJKPNJ(onkdcgnbalk, ochcodjiphj.x + 10f, ochcodjiphj.y + 25f, 32f, 32f, "1", 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress)).FNMCIACNOMH = (this.currentSadokId == 1);
		new MEMEOHJKPNJ(onkdcgnbalk, ochcodjiphj.x + 10f + 38f, ochcodjiphj.y + 25f, 32f, 32f, "2", 2, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress)).FNMCIACNOMH = (this.currentSadokId == 0);
		bool fnmciacnomh = this.IPNACPKIELJ();
		if (this.currentSadokId == 0)
		{
			this.rembtn = new MEMEOHJKPNJ(onkdcgnbalk, ochcodjiphj.x + 10f, ochcodjiphj.y + 64f, 70f, 24f, ">> 2 >>", 3, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress))
			{
				FNMCIACNOMH = fnmciacnomh
			};
		}
		if (this.currentSadokId == 1)
		{
			this.rembtn = new MEMEOHJKPNJ(onkdcgnbalk, ochcodjiphj.x + 10f, ochcodjiphj.y + 64f, 70f, 24f, "<< 1 <<", 4, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress))
			{
				FNMCIACNOMH = fnmciacnomh
			};
		}
		this.OJJLLBKEGNO.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.sadokItemChange);
		this.OJJLLBKEGNO.IHEILFHMLAG = this.OJJLLBKEGNO.LACAJHOHACK.Count - 1;
		this.OJJLLBKEGNO.MPMFNJEJAHJ();
		if (this.CODAIBGMFCA == null || this.OJJLLBKEGNO.IHEILFHMLAG < 0)
		{
			this.rembtn.FNMCIACNOMH = false;
		}
		this.OHIPOCGKHDE = new LCOLJOPGDLL(onkdcgnbalk, 20f, 50f, 400f, 20f, "---", TextAnchor.UpperLeft, Color.black)
		{
			LNDPBNODFPE = true
		};
		this.AFEHNJCCJAF();
	}

	// Token: 0x06004F82 RID: 20354 RVA: 0x00243034 File Offset: 0x00241234
	private void IEOICHPKEMD()
	{
		if (Input.GetKeyDown((KeyCode)(-76)) && JDCEFOFMGHB.JFIDAGABKID().HILJENLHLDE(this.sadokWinId) != null && this.CODAIBGMFCA != null)
		{
			this.GKBCONBIMIN();
		}
	}

	// Token: 0x06004F83 RID: 20355 RVA: 0x00243060 File Offset: 0x00241260
	public void MNJCDKFJKCA(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn != 1L)
		{
			if (odfekbjcfmn != 6L)
			{
				return;
			}
			this.HPICBMCMAEC();
			if (this.BLKAFFPKEBA)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("Anti-Cheat Toolkit Detectors", 286f);
				return;
			}
			if (FlyMessageManager.getI.HGPJFOGELGH(120))
			{
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Hyperlink_", 749f);
				return;
			}
			if (this.DBELGCHKMOE.NAIIDOFAJKG() < 0)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("OfficeSittingEyesRub", 1059f);
				return;
			}
			if (this.DBELGCHKMOE.LACAJHOHACK.Count > 1)
			{
				OIJEGJLCFCF oijegjlcfcf = (OIJEGJLCFCF)this.DBELGCHKMOE.LACAJHOHACK[this.DBELGCHKMOE.HHJKOIJGNAK()];
				oijegjlcfcf.HGCCAHPEFGO = 1;
				this.DOLFJGGBDJF = oijegjlcfcf;
				JDCEFOFMGHB.HMJJPNDEKPP().NOIEEEIONNG(1260f, 1, "{{{{{0},{1}}}}}", new ONKDCGNBALK.CMMHGMILOIM(this.MEGHJAJGDDE), true);
				return;
			}
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("error: assetBundle is null", 668f);
			return;
		}
		else
		{
			if (this.DBELGCHKMOE.LACAJHOHACK.Count >= this.holodFreeCell)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB(" has invalid children array. Child index is < 0.", 956f);
				return;
			}
			if (this.OJJLLBKEGNO.NAIIDOFAJKG() < 1)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("StrafeRunRight", 1258f);
				return;
			}
			if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 0)
			{
				OIJEGJLCFCF dolfjggbdjf = (OIJEGJLCFCF)this.OJJLLBKEGNO.LACAJHOHACK[this.OJJLLBKEGNO.FJNDDAMCLFL()];
				this.DOLFJGGBDJF = dolfjggbdjf;
				JDCEFOFMGHB.MNJNNDHCDGG().PBJGEIMFNNO(580f, 0, "SneakIdle", new ONKDCGNBALK.CMMHGMILOIM(this.APADGLBHPGK), false);
				return;
			}
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("</color>", 364f);
			return;
		}
	}

	// Token: 0x06004F84 RID: 20356 RVA: 0x00243228 File Offset: 0x00241428
	public void openFishWin(OIJEGJLCFCF CFBLFPPOIKE)
	{
		CFBLFPPOIKE.GAAPCLGDOGH.JIFFLPNBILE(CFBLFPPOIKE.DBEIGNDALDC);
		this.CODAIBGMFCA = CFBLFPPOIKE;
		string iabkgmnjljo;
		if (this.CODAIBGMFCA.GAAPCLGDOGH.KIJMCOPFLCN == 1)
		{
			iabkgmnjljo = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_cachhe"), this.CODAIBGMFCA.LHNOBJDFOOJ(true));
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
		}
		else
		{
			iabkgmnjljo = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_cachshe"), this.CODAIBGMFCA.LHNOBJDFOOJ(true));
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.MPNJKJKDMLK)
		{
			Color lbcgackjcjb = new Color(0.8f, 0.9f, 0.8f, 1f);
			if (this.CODAIBGMFCA.DBEIGNDALDC == 1)
			{
				lbcgackjcjb = new Color(0.5f, 1f, 0.1f, 1f);
			}
			if (this.CODAIBGMFCA.DBEIGNDALDC == 2)
			{
				lbcgackjcjb = new Color(0.1f, 0.5f, 1f, 1f);
			}
			if (this.CODAIBGMFCA.GEFOGEDMLJA)
			{
				lbcgackjcjb = new Color(0.9f, 0.8f, 0f, 1f);
			}
			FlyMessageManager.getI.addMessageBig(iabkgmnjljo, lbcgackjcjb, 0, 0).NENOBDLCFHO = this.CODAIBGMFCA.NENOBDLCFHO;
			this.getFish(-1, false);
			bool knobfamemjc = HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC;
			return;
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC && ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) < 3000f)
		{
			this.MKICPMKFLFN(CFBLFPPOIKE, -1f);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(Fisherman.getI.transform.position, 0.3f);
		bool flag = false;
		int num = 0;
		int num2 = 0;
		foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC)
		{
			num += oijegjlcfcf.NKHBAJKMAGD;
			num2++;
		}
		num -= CFBLFPPOIKE.NKHBAJKMAGD;
		num2--;
		if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.ICJDPPOJINN || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.IBEIBAHKIAH)
		{
			flag = true;
		}
		if (LocNewLogic.getI.GFWin != null)
		{
			LocNewLogic.getI.GFWin.gameObject.SetActive(true);
			LocNewLogic.getI.GFWin.newFish(this.CODAIBGMFCA, flag);
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(570f, 540f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_cachfish"), false);
		onkdcgnbalk.KNNIPIEENII = false;
		onkdcgnbalk.NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.OnPostFishWin);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f + 2f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("release"), 13, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress));
		bool flag2 = true;
		if (flag)
		{
			new LCOLJOPGDLL(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 256f, onkdcgnbalk.OCHCODJIPHJ.height - 65f, 512f, 20f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("sadokfull2"), TextAnchor.UpperCenter, Color.red);
			flag2 = false;
		}
		else
		{
			string dpanhmgcbnl = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_sadok"), new object[]
			{
				num2,
				BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.ICJDPPOJINN,
				JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)num),
				JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.IBEIBAHKIAH)
			});
			new LCOLJOPGDLL(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 256f, onkdcgnbalk.OCHCODJIPHJ.height - 65f, 512f, 20f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black);
		}
		Rect ochcodjiphj = new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 2f - 256f, 60f, 512f, 400f);
		new MGLHIBHDMPC(onkdcgnbalk, ochcodjiphj, this.fgetImage);
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(ochcodjiphj.x, ochcodjiphj.y, 512f, 242f), this.fgetImagesBases[JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG]);
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, ochcodjiphj.x, ochcodjiphj.y, ochcodjiphj.width, ochcodjiphj.height, "", 0, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.sadokPanelRender)
		};
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 65f, egcaadaabpp.OCHCODJIPHJ.width - 20f, 60f, string.Format("<color='#606080'>+{0}</color>", CFBLFPPOIKE.MGLOOIONCPM), TextAnchor.UpperRight, new Color(0.7f, 0.7f, 0.7f));
		lcoljopgdll.LNDPBNODFPE = true;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		lcoljopgdll.DFIGKKMMIAF = 44;
		this.BLKAFFPKEBA = !flag2;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 260f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("getfish"), 14, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress)).FNMCIACNOMH = flag2;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f + 132f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("withquest"), 20, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress));
	}

	// Token: 0x06004F85 RID: 20357 RVA: 0x00243884 File Offset: 0x00241A84
	public void JDKLENKPFNP(HBPNMNGOFMA KADBECGIMPD)
	{
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("onDisconnect PROCEDURE", Vector3.zero, GuiProcessor.IKGFHGKKCPG.OODKDLPBAIP());
		this.UID_info = KADBECGIMPD.HFOPFEJDJFG();
		UserInfoWin component = gameObject.GetComponent<UserInfoWin>();
		if (component != null)
		{
			component.DJINFPNFCNC(this.UID_info, KADBECGIMPD);
			return;
		}
		Debug.LogError("RollerBladeGrindRoyale");
	}

	// Token: 0x06004F86 RID: 20358 RVA: 0x002438E4 File Offset: 0x00241AE4
	public void releaseFromSadok()
	{
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(286, this.CODAIBGMFCA.LPFKFNLHGBI);
		this.OJJLLBKEGNO.LACAJHOHACK.Remove(this.CODAIBGMFCA);
		JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC.Remove(this.CODAIBGMFCA);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_letgoshe"), this.CODAIBGMFCA.LHNOBJDFOOJ(true));
		if (this.CODAIBGMFCA.GAAPCLGDOGH.KIJMCOPFLCN == 1)
		{
			iabkgmnjljo = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_letgohe"), this.CODAIBGMFCA.LHNOBJDFOOJ(true));
		}
		OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
		this.CODAIBGMFCA = null;
		this.OJJLLBKEGNO.MPMFNJEJAHJ();
		this.OJJLLBKEGNO.OOJKJOCOOCB(0, 0);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("fishsplash2.ogg", 1f);
		this.AFEHNJCCJAF();
	}

	// Token: 0x06004F87 RID: 20359 RVA: 0x002439D8 File Offset: 0x00241BD8
	public void ONNMFFFGBPD(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GOJICKHNGEE.Count <= 1)
		{
			new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x, PHEMLBHMNCM.y, PHEMLBHMNCM.width, PHEMLBHMNCM.height, JNBICAJIJMM.DIOJFJMOPJO("_TintColor"), TextAnchor.UpperLeft, Color.black);
			return;
		}
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(JMAKEAHMLMI, PHEMLBHMNCM.x + 1793f, PHEMLBHMNCM.y + 1572f, PHEMLBHMNCM.width - 891f, PHEMLBHMNCM.height - 1415f, 0)
		{
			JHNCNHAAJCH = 1606f
		};
		mmkfaenbhkd.KPLMFNIFPMM = true;
		foreach (BHNDGIPPPCE.MKIEEEENAMA mkieeeenama in JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GOJICKHNGEE)
		{
			mkieeeenama.onRender = new ItemBase.OOALOMPKIKK(this.BCMNJILJHEL);
			mmkfaenbhkd.LACAJHOHACK.Add(mkieeeenama);
		}
		mmkfaenbhkd.KCLLDJJLCGC = 16;
		mmkfaenbhkd.NBCAEJHKLMG();
		mmkfaenbhkd.OEIOEBCGMJE(0);
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(false);
	}

	// Token: 0x06004F88 RID: 20360 RVA: 0x00243B04 File Offset: 0x00241D04
	private void EILGNEMPLAL(ONKDCGNBALK ONPHLHKAGFP)
	{
		OIJEGJLCFCF dolfjggbdjf = this.DOLFJGGBDJF;
		if (dolfjggbdjf == null)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC.Add(dolfjggbdjf);
			this.DBELGCHKMOE.LACAJHOHACK.Remove(dolfjggbdjf);
			this.DBELGCHKMOE.FNFFGIJOENM();
			this.OJJLLBKEGNO.LACAJHOHACK.Add(dolfjggbdjf);
			this.OJJLLBKEGNO.FNFFGIJOENM();
			epmphjgalbe.FLLJONHPLNA(this.currentHolodId);
			epmphjgalbe.OBCCLNMPGEJ(dolfjggbdjf.LPFKFNLHGBI);
			NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-121, epmphjgalbe.NNEAJJNCGMK());
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("delacc", 1558f);
			this.ACKCODOIBCL();
			this.OAGIEPJBMPH();
		}
		finally
		{
			epmphjgalbe.HDKBMLOJLLC();
		}
	}

	// Token: 0x06004F89 RID: 20361 RVA: 0x00243BD8 File Offset: 0x00241DD8
	private void MKICPMKFLFN(OIJEGJLCFCF CFBLFPPOIKE, float DEFNNEGPNEI)
	{
		if (this.brgCntr == null)
		{
			Fisherman.getI.bragfish = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("FishbragContainer", Vector3.zero, Fisherman.getI.leftHandRodPoint);
			if (Fisherman.getI.bragfish == null)
			{
				return;
			}
			this.brgCntr = Fisherman.getI.bragfish.GetComponent<BragFish>();
			Fisherman.getI.bragfish.transform.localRotation = Quaternion.identity;
			Fisherman.getI.bragfish.transform.localScale = new Vector3(1f, 1f, 1f);
			Fisherman.getI.bragfish.transform.localPosition = Vector3.zero;
			this.brgCntr.fishInstance(CFBLFPPOIKE.NENOBDLCFHO, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NBLJCEHNKAK), false);
		}
		if (Fisherman.getI.podsakObject != null)
		{
			UnityEngine.Object.Destroy(Fisherman.getI.podsakObject);
			Fisherman.getI.podsakObject = null;
		}
		Fisherman.getI.getBragCntrl.LJIEPIPIAJC(true);
		if (DEFNNEGPNEI > 0f)
		{
			base.StartCoroutine(this.IKNBAFLKELI(DEFNNEGPNEI));
		}
	}

	// Token: 0x06004F8A RID: 20362 RVA: 0x00243D18 File Offset: 0x00241F18
	public void JJDIBICNMMC(int LPFKFNLHGBI, HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.GMBEHOGPEDI(5, 1427f, Vector3.zero);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().IHNMOJHBMNJ(this.OJNFLOAOILJ);
		if (onkdcgnbalk == null)
		{
			onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().NCIDDNIKACI(1567f, 264f, "_camScale", true);
		}
		else
		{
			onkdcgnbalk.FDDMHPAFDAG();
		}
		this.OJNFLOAOILJ = onkdcgnbalk.LPFKFNLHGBI;
		int num = 59;
		new EGCAADAABPP(onkdcgnbalk, 1497f, 46f, 1715f, 490f, "0x", 1, null);
		MEMEOHJKPNJ memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, 251f, (float)num, 916f, 122f, JNBICAJIJMM.DBMJJPBOPEK().CCFFMKBBKHI("_BlurRadius4"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.JIPLBMFECMH));
		memeohjkpnj.HKPAEGGJNGG = (LPFKFNLHGBI == 1);
		memeohjkpnj.KCLLDJJLCGC = -80;
		num += -75;
		MEMEOHJKPNJ memeohjkpnj2 = new MEMEOHJKPNJ(onkdcgnbalk, 1793f, (float)num, 1201f, 1536f, JNBICAJIJMM.IKGFHGKKCPG.CKAOHMEKLMH("(Org: "), 5, null, new ONKDCGNBALK.CMMHGMILOIM(this.infoWinKeyPress));
		memeohjkpnj2.HKPAEGGJNGG = (LPFKFNLHGBI == 7);
		memeohjkpnj2.KCLLDJJLCGC = 113;
		num += -106;
		MEMEOHJKPNJ memeohjkpnj3 = new MEMEOHJKPNJ(onkdcgnbalk, 365f, (float)num, 1067f, 243f, JNBICAJIJMM.EKEBHIJMEML().CKAOHMEKLMH("Mouse Y"), 5, null, new ONKDCGNBALK.CMMHGMILOIM(this.JIPLBMFECMH));
		memeohjkpnj3.HKPAEGGJNGG = (LPFKFNLHGBI == 3);
		memeohjkpnj3.KCLLDJJLCGC = 99;
		num += 55;
		MEMEOHJKPNJ memeohjkpnj4 = new MEMEOHJKPNJ(onkdcgnbalk, 739f, (float)num, 847f, 1254f, JNBICAJIJMM.IMLLGEMPHAP().ECNKLECOKHD("[maxcnt]"), 8, null, new ONKDCGNBALK.CMMHGMILOIM(this.MKJGPNKJFDL));
		memeohjkpnj4.HKPAEGGJNGG = (LPFKFNLHGBI == 7);
		memeohjkpnj4.KCLLDJJLCGC = 79;
		num += 86;
		MEMEOHJKPNJ memeohjkpnj5 = new MEMEOHJKPNJ(onkdcgnbalk, 1250f, (float)num, 278f, 1398f, JNBICAJIJMM.APMJBBDBOJO().HLBAJBLHLNI("toe"), -94, null, new ONKDCGNBALK.CMMHGMILOIM(this.JIPLBMFECMH));
		memeohjkpnj5.HKPAEGGJNGG = (LPFKFNLHGBI == 67);
		memeohjkpnj5.KCLLDJJLCGC = -44;
		num += -75;
		MEMEOHJKPNJ memeohjkpnj6 = new MEMEOHJKPNJ(onkdcgnbalk, 1292f, (float)num, 615f, 1339f, JNBICAJIJMM.LPHMKPDBMPP().DOEMGEAEBPN("SneakRight"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.MKJGPNKJFDL));
		memeohjkpnj6.HKPAEGGJNGG = (LPFKFNLHGBI == 2);
		memeohjkpnj6.KCLLDJJLCGC = 81;
		num += 109;
		MEMEOHJKPNJ memeohjkpnj7 = new MEMEOHJKPNJ(onkdcgnbalk, 1581f, (float)num, 1318f, 1681f, JNBICAJIJMM.EKEBHIJMEML().FLEANFGEJML("isRodInWater"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.JIPLBMFECMH));
		memeohjkpnj7.HKPAEGGJNGG = (LPFKFNLHGBI == 6);
		memeohjkpnj7.KCLLDJJLCGC = 126;
		num += 47;
		num += 17;
		MEMEOHJKPNJ memeohjkpnj8 = new MEMEOHJKPNJ(onkdcgnbalk, 688f, (float)num, 1880f, 915f, JNBICAJIJMM.IMLLGEMPHAP().CKAOHMEKLMH(" iterations for read and write"), 4, null, null);
		memeohjkpnj8.HKPAEGGJNGG = (LPFKFNLHGBI == 2);
		memeohjkpnj8.FNMCIACNOMH = false;
		memeohjkpnj8.KCLLDJJLCGC = 74;
		memeohjkpnj8.FNMCIACNOMH = true;
		num += -59;
		MEMEOHJKPNJ memeohjkpnj9 = new MEMEOHJKPNJ(onkdcgnbalk, 954f, (float)num, 223f, 186f, JNBICAJIJMM.LPHMKPDBMPP().CKAOHMEKLMH("[WH Detector Service]"), 3, null, null);
		memeohjkpnj9.HKPAEGGJNGG = (LPFKFNLHGBI == 1);
		memeohjkpnj9.FNMCIACNOMH = true;
		memeohjkpnj9.KCLLDJJLCGC = -63;
		memeohjkpnj9.FNMCIACNOMH = false;
		num += 69;
		MEMEOHJKPNJ memeohjkpnj10 = new MEMEOHJKPNJ(onkdcgnbalk, 1555f, (float)num, 1402f, 265f, JNBICAJIJMM.DBMJJPBOPEK().NLJOLOBPCBJ(""), 6, null, null);
		memeohjkpnj10.HKPAEGGJNGG = (LPFKFNLHGBI == 8);
		memeohjkpnj10.FNMCIACNOMH = false;
		memeohjkpnj10.KCLLDJJLCGC = 119;
		memeohjkpnj10.FNMCIACNOMH = false;
		Rect rect = new Rect(1426f, 1820f, onkdcgnbalk.OCHCODJIPHJ.width - 292f, onkdcgnbalk.OCHCODJIPHJ.height - 30f);
		new MGLHIBHDMPC(onkdcgnbalk, rect, this.PaperTexture);
		new EGCAADAABPP(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, "Wizard1HandThrow", 1, null);
		switch (LPFKFNLHGBI)
		{
		case 1:
			this.HIJHNGLFMHB(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 2:
			this.NGLOHLKGALF(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 3:
			this.openReputationWindow(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 4:
			this.OIGCNADEHGB(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 7:
			this.JIKIOGPPIFC(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 8:
			this.CMNKNPKIMOH(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 9:
			this.openAchivesWin(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		}
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = true;
	}

	// Token: 0x06004F8B RID: 20363 RVA: 0x00244180 File Offset: 0x00242380
	private void AEMFAOIFNCO(JNHLAGHJBAA AGDMAFCKMJP, JNHLAGHJBAA.FPAEEADMCIE AOJKIAFNLAC)
	{
		if (AOJKIAFNLAC != null && !AOJKIAFNLAC.DBHKKPMINIJ)
		{
			this.OKFIFPBAAFG = (int)AOJKIAFNLAC.ODFEKBJCFMN;
			Debug.Log("selectTitulId=" + this.OKFIFPBAAFG);
			NHCAOFIKNFE.IKGFHGKKCPG.HHJHDLHKJDF(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HKHMIIEIFNG, JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB, false, true);
			string arg = NHCAOFIKNFE.IKGFHGKKCPG.HHJHDLHKJDF(this.OKFIFPBAAFG, JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB, false, true);
			string dccpcblodig = string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_tit_inf"), arg, "---");
			this.IKFFNBOCGFL.FPIHOPOCAHA = dccpcblodig;
		}
	}

	// Token: 0x06004F8C RID: 20364 RVA: 0x00244234 File Offset: 0x00242434
	private void HAILFEKCJGC(JNHLAGHJBAA AGDMAFCKMJP, JNHLAGHJBAA.FPAEEADMCIE AOJKIAFNLAC)
	{
		if (AOJKIAFNLAC != null && !AOJKIAFNLAC.DBHKKPMINIJ)
		{
			this.OKFIFPBAAFG = (int)AOJKIAFNLAC.ODFEKBJCFMN;
			Debug.Log("invn_rec13" + this.OKFIFPBAAFG);
			NHCAOFIKNFE.IKGFHGKKCPG.MODOIHOIMBJ(JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.HKHMIIEIFNG, JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BNIHFBMEPAB, true, true);
			string arg = NHCAOFIKNFE.IKGFHGKKCPG.GGGFKBAAADC(this.OKFIFPBAAFG, JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BNIHFBMEPAB, false, true);
			string dccpcblodig = string.Format(JNBICAJIJMM.DIOJFJMOPJO(", point "), arg, "Закрыть");
			this.IKFFNBOCGFL.FPIHOPOCAHA = dccpcblodig;
		}
	}

	// Token: 0x06004F8D RID: 20365 RVA: 0x002442E8 File Offset: 0x002424E8
	public void NNLCCLIBECP(ONKDCGNBALK ONPHLHKAGFP)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("_LogLut", 1540f);
		int dnhbpgoklkd = (int)ONPHLHKAGFP.ODFEKBJCFMN;
		JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(true);
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(135, dnhbpgoklkd);
		NJMHLCGIAJI.EAJGHMMBAFP().GDNKCAOHEPL(-19, "1 Hand Sword Charge Swipe");
	}

	// Token: 0x06004F8E RID: 20366 RVA: 0x00244340 File Offset: 0x00242540
	public void ECHGDPPJPEA(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn != 0L)
		{
			if (odfekbjcfmn != 2L)
			{
				return;
			}
			this.ACKCODOIBCL();
			if (this.BLKAFFPKEBA)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("Attempting to set limb orientation to Vector3.zero axis", 1475f);
				return;
			}
			if (FlyMessageManager.getI.EDAAJDDIGNE(-123))
			{
				FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("\nу вас есть ", 827f);
				return;
			}
			if (this.DBELGCHKMOE.HHJKOIJGNAK() < 1)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("demoByteArray", 565f);
				return;
			}
			if (this.DBELGCHKMOE.LACAJHOHACK.Count > 0)
			{
				OIJEGJLCFCF oijegjlcfcf = (OIJEGJLCFCF)this.DBELGCHKMOE.LACAJHOHACK[this.DBELGCHKMOE.FJNDDAMCLFL()];
				oijegjlcfcf.HGCCAHPEFGO = 1;
				this.DOLFJGGBDJF = oijegjlcfcf;
				JDCEFOFMGHB.HMJJPNDEKPP().DKJMCKOJOPF(428f, 1, "ResetObject", new ONKDCGNBALK.CMMHGMILOIM(this.EBKBNILDMGG), true);
				return;
			}
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("OfficeSitting45DegLeg", 719f);
			return;
		}
		else
		{
			if (this.DBELGCHKMOE.LACAJHOHACK.Count >= this.holodFreeCell)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("OfficeSittingEyesRub", 1583f);
				return;
			}
			if (this.OJJLLBKEGNO.FJNDDAMCLFL() < 0)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB(" {0} сек", 704f);
				return;
			}
			if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 0)
			{
				OIJEGJLCFCF dolfjggbdjf = (OIJEGJLCFCF)this.OJJLLBKEGNO.LACAJHOHACK[this.OJJLLBKEGNO.IHEILFHMLAG];
				this.DOLFJGGBDJF = dolfjggbdjf;
				JDCEFOFMGHB.HMJJPNDEKPP().DKJMCKOJOPF(1309f, 1, "IdleSpew", new ONKDCGNBALK.CMMHGMILOIM(this.HFHGKJCGBBD), false);
				return;
			}
			FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("Mutilate", 1205f);
			return;
		}
	}

	// Token: 0x06004F8F RID: 20367 RVA: 0x00244508 File Offset: 0x00242708
	public void MLOPNFPMMLH(ONKDCGNBALK ONPHLHKAGFP)
	{
		int num = (int)JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BIHLDHKHPKE("basePar");
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 80,
			font = GuiProcessor.NKOEAPCIBKO().rusfont3,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperLeft
		};
		if (num > 0)
		{
			NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.PKJMLDMLFCM(num);
			if (jenmpdpjkbg != null)
			{
				guistyle.alignment = TextAnchor.UpperLeft;
				GUI.DrawTexture(new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 1225f, ONPHLHKAGFP.OCHCODJIPHJ.y + 220f, 1481f, 756f), jenmpdpjkbg.BDHHPAEHFHG.OHJIDDDKOAA());
				guistyle.fontStyle = FontStyle.Normal;
				string str = string.Format(JNBICAJIJMM.IMLLGEMPHAP().HEIBEHAEHBM("<color='#303030'><size=10>{0}</size></color>\n<size=16><b>{1}</b></size><color='#302020'>  {3}</color>{2}"), jenmpdpjkbg.JAGMEPMLCCP);
				if (jenmpdpjkbg.JAGMEPMLCCP == 0)
				{
					str = JNBICAJIJMM.APMJBBDBOJO().DOEMGEAEBPN("codepage");
				}
				if (jenmpdpjkbg.JAGMEPMLCCP == 0)
				{
					str = JNBICAJIJMM.DBMJJPBOPEK().NLJOLOBPCBJ(" POSITION not found");
				}
				GUI.Label(new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 900f, ONPHLHKAGFP.OCHCODJIPHJ.y + 1326f, 183f, 1211f), jenmpdpjkbg.BDHHPAEHFHG.KKEBDLGHBMN + str, guistyle);
				guistyle.fontStyle = FontStyle.Normal;
				guistyle.fontSize = -88;
				guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
				string text = jenmpdpjkbg.BDHHPAEHFHG.PAALJNAKJEG;
				int num2 = jenmpdpjkbg.JAGMEPMLCCP + 1;
				if (num2 > 0)
				{
					num2 = 2;
				}
				text = text.Replace("_FogSpeed", string.Concat(jenmpdpjkbg.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num2));
				text = text.Replace("/StreamingAssets/", string.Concat(jenmpdpjkbg.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num2));
				text = text.Replace("money", string.Concat(jenmpdpjkbg.BDHHPAEHFHG.DCCPCBLODIG.FJACMDGJEBL() * (double)num2));
				GUI.Label(new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 1036f, ONPHLHKAGFP.OCHCODJIPHJ.y + 1797f, 1609f, 141f), text, guistyle);
				this.renderPBar(new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 1441f, ONPHLHKAGFP.OCHCODJIPHJ.y + 1639f, ONPHLHKAGFP.OCHCODJIPHJ.width - 1179f, 1977f), jenmpdpjkbg.KLPANBANBDI, (float)jenmpdpjkbg.GNNDLEAFCND, 8, string.Format("Loser", Mathf.FloorToInt(jenmpdpjkbg.KLPANBANBDI), jenmpdpjkbg.GNNDLEAFCND), true);
				return;
			}
		}
		else
		{
			GUI.Label(ONPHLHKAGFP.OCHCODJIPHJ, JNBICAJIJMM.OOOKJHOHPNN("help"), guistyle);
		}
	}

	// Token: 0x06004F90 RID: 20368 RVA: 0x002447F0 File Offset: 0x002429F0
	public void HolodKeyPress(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn != 1L)
		{
			if (odfekbjcfmn != 2L)
			{
				return;
			}
			this.AFEHNJCCJAF();
			if (this.BLKAFFPKEBA)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
				return;
			}
			if (FlyMessageManager.getI.checkFlyIcon(11))
			{
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
				return;
			}
			if (this.DBELGCHKMOE.IHEILFHMLAG < 0)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
				return;
			}
			if (this.DBELGCHKMOE.LACAJHOHACK.Count > 0)
			{
				OIJEGJLCFCF oijegjlcfcf = (OIJEGJLCFCF)this.DBELGCHKMOE.LACAJHOHACK[this.DBELGCHKMOE.IHEILFHMLAG];
				oijegjlcfcf.HGCCAHPEFGO = 0;
				this.DOLFJGGBDJF = oijegjlcfcf;
				JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO(0.5f, 0, "", new ONKDCGNBALK.CMMHGMILOIM(this.KJPBMHACAFG), false);
				return;
			}
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
			return;
		}
		else
		{
			if (this.DBELGCHKMOE.LACAJHOHACK.Count >= this.holodFreeCell)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
				return;
			}
			if (this.OJJLLBKEGNO.IHEILFHMLAG < 0)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
				return;
			}
			if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 0)
			{
				OIJEGJLCFCF dolfjggbdjf = (OIJEGJLCFCF)this.OJJLLBKEGNO.LACAJHOHACK[this.OJJLLBKEGNO.IHEILFHMLAG];
				this.DOLFJGGBDJF = dolfjggbdjf;
				JDCEFOFMGHB.IKGFHGKKCPG.PBJGEIMFNNO(0.5f, 0, "", new ONKDCGNBALK.CMMHGMILOIM(this.FLDFHGHNLNN), false);
				return;
			}
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
			return;
		}
	}

	// Token: 0x06004F91 RID: 20369 RVA: 0x002449B8 File Offset: 0x00242BB8
	public void CICLBLJKEDF(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn != 1L)
		{
			if (odfekbjcfmn != 0L)
			{
				return;
			}
			this.ACKCODOIBCL();
			if (this.BLKAFFPKEBA)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("error.wav", 741f);
				return;
			}
			if (FlyMessageManager.getI.OJEONACJDBF(78))
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("Weapon Fire", 1260f);
				return;
			}
			if (this.DBELGCHKMOE.HHJKOIJGNAK() < 1)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("CrouchStrafeLeft", 45f);
				return;
			}
			if (this.DBELGCHKMOE.LACAJHOHACK.Count > 0)
			{
				OIJEGJLCFCF oijegjlcfcf = (OIJEGJLCFCF)this.DBELGCHKMOE.LACAJHOHACK[this.DBELGCHKMOE.IHEILFHMLAG];
				oijegjlcfcf.HGCCAHPEFGO = 1;
				this.DOLFJGGBDJF = oijegjlcfcf;
				JDCEFOFMGHB.JFIDAGABKID().PBJGEIMFNNO(274f, 0, "Cloth_07.wav", new ONKDCGNBALK.CMMHGMILOIM(this.EILGNEMPLAL), false);
				return;
			}
			FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP(" ", 1430f);
			return;
		}
		else
		{
			if (this.DBELGCHKMOE.LACAJHOHACK.Count >= this.holodFreeCell)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("uint:", 1170f);
				return;
			}
			if (this.OJJLLBKEGNO.DEFBLKPDLPM() < 0)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("u_UniqueShadowMatrix", 1791f);
				return;
			}
			if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 0)
			{
				OIJEGJLCFCF dolfjggbdjf = (OIJEGJLCFCF)this.OJJLLBKEGNO.LACAJHOHACK[this.OJJLLBKEGNO.NAIIDOFAJKG()];
				this.DOLFJGGBDJF = dolfjggbdjf;
				JDCEFOFMGHB.HMJJPNDEKPP().NOIEEEIONNG(872f, 1, "active_obj_", new ONKDCGNBALK.CMMHGMILOIM(this.FLDFHGHNLNN), true);
				return;
			}
			FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("TOD_MoonCloudColor", 1846f);
			return;
		}
	}

	// Token: 0x06004F92 RID: 20370 RVA: 0x00244B7F File Offset: 0x00242D7F
	private void Awake()
	{
		if (GameInterface.getI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		HPGKIJLKCIH.IKGFHGKKCPG.PINLMCCKKNA();
		GameInterface.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		CKNLPGEPGGF.IKGFHGKKCPG.PINLMCCKKNA();
	}

	// Token: 0x06004F93 RID: 20371 RVA: 0x00244BC0 File Offset: 0x00242DC0
	public void NFGOLLEEHHK(Rect OCHCODJIPHJ, float EBLHAJDINBH, float EJBJCJJMOPJ, int CLBPBJGLHEE, string JCKHDHGIEEB = "", bool IMOJBPPCJAM = false)
	{
		if (EBLHAJDINBH < 398f)
		{
			EBLHAJDINBH = 992f;
		}
		if (EBLHAJDINBH > EJBJCJJMOPJ)
		{
			EBLHAJDINBH = EJBJCJJMOPJ;
		}
		Rect position = new Rect(OCHCODJIPHJ.x - 194f, OCHCODJIPHJ.y, OCHCODJIPHJ.width + 1794f, OCHCODJIPHJ.height);
		if (IMOJBPPCJAM)
		{
			GUIStyle style = GUI.skin.customStyles[1];
			GUI.Box(position, "?", style);
		}
		if (EBLHAJDINBH > 591f)
		{
			float num = OCHCODJIPHJ.width * EBLHAJDINBH / EJBJCJJMOPJ;
			if (num > 1406f)
			{
				GUI.DrawTextureWithTexCoords(new Rect(OCHCODJIPHJ.x - 1427f, OCHCODJIPHJ.y, num + 524f, OCHCODJIPHJ.height), this.UserParamLines, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(CLBPBJGLHEE, 1, 2), false);
			}
		}
		if (JCKHDHGIEEB != "http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}")
		{
			GUIStyle style2 = new GUIStyle
			{
				fontSize = -10,
				font = GuiProcessor.NKOEAPCIBKO().rusfont,
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.LowerCenter
			};
			GUI.Label(OCHCODJIPHJ, JCKHDHGIEEB, style2);
		}
	}

	// Token: 0x06004F94 RID: 20372 RVA: 0x00244CD8 File Offset: 0x00242ED8
	public void CECLLEPOEMM(HBPNMNGOFMA KADBECGIMPD)
	{
		Debug.Log("_LerpRgbTex");
		List<ELCMHGJLFOL.FDEPADNCGIF> list = new List<ELCMHGJLFOL.FDEPADNCGIF>();
		KADBECGIMPD.IFDFHJLCHAE();
		KADBECGIMPD.HHLDBAEFNMJ();
		while (!KADBECGIMPD.INLBHLOLOJH())
		{
			long num = KADBECGIMPD.IJDIMHAEAIE();
			ELCMHGJLFOL.FDEPADNCGIF fdepadncgif = ELCMHGJLFOL.IKGFHGKKCPG.BCBCICJDIEF(num);
			if (fdepadncgif == null)
			{
				fdepadncgif = new ELCMHGJLFOL.FDEPADNCGIF(num);
				ELCMHGJLFOL.IKGFHGKKCPG.AJJPEOKLKKL(fdepadncgif);
			}
			fdepadncgif.MPCIALDHHKN(KADBECGIMPD);
			list.Add(fdepadncgif);
		}
		if (this.OFNLHPKLHGI != null)
		{
			UnityEngine.Object.Destroy(this.OFNLHPKLHGI);
		}
		this.OFNLHPKLHGI = JDCEFOFMGHB.HMJJPNDEKPP().PEPNNHGOOIA("{0}+{1}={2}");
		ArtAllWin component = this.OFNLHPKLHGI.GetComponent<ArtAllWin>();
		if (component != null)
		{
			foreach (ELCMHGJLFOL.FDEPADNCGIF jlfioojljod in list)
			{
				component.HOJDHPPDOIG(jlfioojljod);
			}
			component.myArtelBtn.interactable = true;
			component.createArtelBtn.interactable = false;
			component.applArtelBtn.interactable = true;
		}
	}

	// Token: 0x06004F95 RID: 20373 RVA: 0x00244DF0 File Offset: 0x00242FF0
	public void NGIFLCKKKOK(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH;
		Color color = Color.black;
		int num = -25;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + PHEMLBHMNCM.width - 201f, PHEMLBHMNCM.y + (float)num - 293f, 666f, 1137f, string.Concat(kfhelhglnmh.CCCPNHIJJOP), TextAnchor.LowerCenter, Color.gray);
		lcoljopgdll.LNDPBNODFPE = false;
		lcoljopgdll.GHCCIOAJFIH(Color.gray);
		lcoljopgdll.DFIGKKMMIAF = 116;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont2;
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1620f, PHEMLBHMNCM.y + (float)num, kfhelhglnmh.BNIHFBMEPAB, true);
		lcoljopgdll2.ELFEMMEBOGG(Color.black);
		lcoljopgdll2.DFIGKKMMIAF = 35;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont2;
		num += -89;
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1408f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.PPNKMDJBMLP("name"), kfhelhglnmh.CNOLCNDBLJE, JLFJEGIPIMM.MHFDIJGJGBJ().PCFPPAKMGGB(kfhelhglnmh.OJDEJEJMNKD)), true);
		lcoljopgdll3.HPCBLPIAHMI(Color.black);
		lcoljopgdll3.DFIGKKMMIAF = -74;
		num += 11;
		int num2 = 0 + ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.PGEDLDMLBBE) / -84;
		string str;
		if (ObscuredInt.LBDMFALMOLD(kfhelhglnmh.PGEDLDMLBBE) != ObscuredInt.LBDMFALMOLD(kfhelhglnmh.ELBKLOECINC))
		{
			str = string.Format("Применить", ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.ELBKLOECINC) - ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.PGEDLDMLBBE), kfhelhglnmh.ELBKLOECINC);
		}
		else
		{
			str = "inv_dur";
		}
		color = ((num2 > 0) ? new Color(573f, 1215f, 1867f) : new Color(1414f, 753f, 876f));
		LCOLJOPGDLL lcoljopgdll4 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 392f, PHEMLBHMNCM.y + (float)num + 1650f, JNBICAJIJMM.BDKHMOOFHHK("post_msg5"), true);
		lcoljopgdll4.GABBMJPJAOO(new Color(1566f, 1631f, 1412f));
		lcoljopgdll4.DFIGKKMMIAF = 24;
		new FNFPGPBCIGK(JMAKEAHMLMI, PHEMLBHMNCM.x + 531f, PHEMLBHMNCM.y + (float)num + 346f, 1, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, 1, 6, 0, new ONKDCGNBALK.CMMHGMILOIM(this.NNLCCLIBECP)).FNMCIACNOMH = (kfhelhglnmh.CCCPNHIJJOP < num2);
		LCOLJOPGDLL lcoljopgdll5 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 566f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.DIOJFJMOPJO("_parent"), kfhelhglnmh.PGEDLDMLBBE) + str, true, color);
		lcoljopgdll5.DFIGKKMMIAF = 24;
		lcoljopgdll5.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont2;
		num += 106;
		if (ObscuredInt.GOOIABGKMHK(kfhelhglnmh.FLHJLFHELPE) != ObscuredInt.LBDMFALMOLD(kfhelhglnmh.EDICLBDIPGG))
		{
			str = string.Format("BowReady", ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.EDICLBDIPGG) - ObscuredInt.LBDMFALMOLD(kfhelhglnmh.FLHJLFHELPE), kfhelhglnmh.EDICLBDIPGG);
		}
		else
		{
			str = "";
		}
		num2 = 0 + ObscuredInt.GOOIABGKMHK(kfhelhglnmh.FLHJLFHELPE) / -90;
		LCOLJOPGDLL lcoljopgdll6 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1332f, PHEMLBHMNCM.y + (float)num + 339f, JNBICAJIJMM.CELEPPAEKAB("18"), true);
		lcoljopgdll6.ELFEMMEBOGG(new Color(879f, 1912f, 261f));
		lcoljopgdll6.DFIGKKMMIAF = 1;
		color = ((num2 > 0) ? new Color(359f, 1144f, 1841f) : new Color(44f, 1228f, 1517f));
		LCOLJOPGDLL lcoljopgdll7 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 421f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("SoccerTackle"), kfhelhglnmh.FLHJLFHELPE) + str, true, color);
		lcoljopgdll7.CECODLIGPHP(color);
		lcoljopgdll7.DFIGKKMMIAF = -57;
		lcoljopgdll7.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont2;
		new FNFPGPBCIGK(JMAKEAHMLMI, PHEMLBHMNCM.x + 115f, PHEMLBHMNCM.y + (float)num + 1077f, 0, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, 7, 0, 0, new ONKDCGNBALK.CMMHGMILOIM(this.NNLCCLIBECP)).FNMCIACNOMH = (kfhelhglnmh.CCCPNHIJJOP >= num2);
		num += -36;
		if (ObscuredInt.LBDMFALMOLD(kfhelhglnmh.JOMLIJFFFDE) != ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.PIHKKCBCNHO))
		{
			str = string.Format("Low adminlevel!", ObscuredInt.LBDMFALMOLD(kfhelhglnmh.PIHKKCBCNHO) - ObscuredInt.GOOIABGKMHK(kfhelhglnmh.JOMLIJFFFDE), kfhelhglnmh.PIHKKCBCNHO);
		}
		else
		{
			str = "{0} {1}";
		}
		num2 = 1 + ObscuredInt.LBDMFALMOLD(kfhelhglnmh.JOMLIJFFFDE) / 62;
		color = ((num2 > 1) ? new Color(1226f, 1816f, 1430f) : new Color(704f, 619f, 1830f));
		LCOLJOPGDLL lcoljopgdll8 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 308f, PHEMLBHMNCM.y + (float)num + 618f, JNBICAJIJMM.DIOJFJMOPJO("u_UniqueShadowFilterWidth"), false);
		lcoljopgdll8.ELFEMMEBOGG(new Color(1482f, 1367f, 1614f));
		lcoljopgdll8.DFIGKKMMIAF = -90;
		LCOLJOPGDLL lcoljopgdll9 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 206f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.BDKHMOOFHHK("<color='#6080ff'>"), kfhelhglnmh.JOMLIJFFFDE) + str, true, color);
		lcoljopgdll9.BNGNMFHLKAL(color);
		lcoljopgdll9.DFIGKKMMIAF = -30;
		lcoljopgdll9.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		new FNFPGPBCIGK(JMAKEAHMLMI, PHEMLBHMNCM.x + 1596f, PHEMLBHMNCM.y + (float)num + 1143f, 2, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, 3, 5, 1, new ONKDCGNBALK.CMMHGMILOIM(this.NNLCCLIBECP)).FNMCIACNOMH = (kfhelhglnmh.CCCPNHIJJOP >= num2);
		num += 85;
		if (ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.LFMMMBOLJCL) != ObscuredInt.LBDMFALMOLD(kfhelhglnmh.FJAIPNCKOKK))
		{
			str = string.Format("_CurveParams", ObscuredInt.GOOIABGKMHK(kfhelhglnmh.FJAIPNCKOKK) - ObscuredInt.GOOIABGKMHK(kfhelhglnmh.LFMMMBOLJCL), kfhelhglnmh.FJAIPNCKOKK);
		}
		else
		{
			str = "No Way points!";
		}
		num2 = 1 + ObscuredInt.GOOIABGKMHK(kfhelhglnmh.LFMMMBOLJCL) / -11;
		color = ((num2 > 1) ? new Color(813f, 1739f, 1314f) : new Color(1466f, 554f, 1875f));
		LCOLJOPGDLL lcoljopgdll10 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 615f, PHEMLBHMNCM.y + (float)num + 604f, JNBICAJIJMM.CELEPPAEKAB(" гр "), false);
		lcoljopgdll10.MOFACMDBGEB(new Color(1937f, 30f, 874f));
		lcoljopgdll10.DFIGKKMMIAF = -61;
		LCOLJOPGDLL lcoljopgdll11 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 269f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("IdleSpew"), kfhelhglnmh.LFMMMBOLJCL) + str, false, color);
		lcoljopgdll11.JJOIHBLMFNE(color);
		lcoljopgdll11.DFIGKKMMIAF = -46;
		lcoljopgdll11.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		new FNFPGPBCIGK(JMAKEAHMLMI, PHEMLBHMNCM.x + 1829f, PHEMLBHMNCM.y + (float)num + 1649f, 2, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, 8, 1, 0, new ONKDCGNBALK.CMMHGMILOIM(this.NNLCCLIBECP)).FNMCIACNOMH = (kfhelhglnmh.CCCPNHIJJOP < num2);
		num += 50;
		num += -64;
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() != null)
		{
			LCOLJOPGDLL lcoljopgdll12 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 524f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("1 Hand Sword Roll Attack"), JLFJEGIPIMM.NNEAHAFBOHC().DIOCHACFPHJ(BOIKJDICEMF.IKGFHGKKCPG.GDPNONOLEAB() * 1853f)), false);
			lcoljopgdll12.BNGNMFHLKAL(Color.black);
			lcoljopgdll12.DFIGKKMMIAF = 54;
			num += 21;
			LCOLJOPGDLL lcoljopgdll13 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 573f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.DIOJFJMOPJO("_RgbTex"), JLFJEGIPIMM.PKGMBFEMKGP().PEGPHIOEKHI(BOIKJDICEMF.IKGFHGKKCPG.AFGBIBMHOAI)), false);
			lcoljopgdll13.BMGMCLKBMAB(Color.black);
			lcoljopgdll13.DFIGKKMMIAF = 94;
			num += 62;
		}
		LCOLJOPGDLL lcoljopgdll14 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 466f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.DCEBAJIILPC("_AdaptTex"), JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL((double)(kfhelhglnmh.JACELJHFHNN * 1077f))), false);
		lcoljopgdll14.JJOIHBLMFNE(Color.black);
		lcoljopgdll14.DFIGKKMMIAF = -27;
		num += -101;
		LCOLJOPGDLL lcoljopgdll15 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 545f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.NGALDMFKMJH(" гр "), JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL((double)(kfhelhglnmh.GGDJKCPNPPI * 349f))), false);
		lcoljopgdll15.HKMFEIMFMAI(Color.black);
		lcoljopgdll15.DFIGKKMMIAF = -73;
		num += 16;
		LCOLJOPGDLL lcoljopgdll16 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1472f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.CELEPPAEKAB(""), JLFJEGIPIMM.IKGFHGKKCPG.AHEHNKFHGOC((double)(kfhelhglnmh.PBLCJCLFFAL * 1363f))), true);
		lcoljopgdll16.GABBMJPJAOO(Color.black);
		lcoljopgdll16.DFIGKKMMIAF = 2;
		num += 86;
		LCOLJOPGDLL lcoljopgdll17 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 208f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("bag"), JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL((double)kfhelhglnmh.BCINOMMOKJE), kfhelhglnmh.GPPPGBLEKMF), false);
		lcoljopgdll17.JJDELGHAKBP(Color.black);
		lcoljopgdll17.DFIGKKMMIAF = -84;
		num += -25;
		LCOLJOPGDLL lcoljopgdll18 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 90f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.CELEPPAEKAB("OfficeSittingLegCross"), JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL((double)kfhelhglnmh.GCLLMNHFMND), kfhelhglnmh.MOPMCAMIENJ), false);
		lcoljopgdll18.CKMAIBLGPHC(Color.black);
		lcoljopgdll18.DFIGKKMMIAF = -45;
		num += -63;
		LCOLJOPGDLL lcoljopgdll19 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 865f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.NGALDMFKMJH("OfficeSittingMouseMovement"), JLFJEGIPIMM.PKGMBFEMKGP().CJGLGGEGPJL((double)kfhelhglnmh.PMOJDCHIAHE), kfhelhglnmh.LJOPDPNIAEG), false);
		lcoljopgdll19.LBCGACKJCJB = Color.black;
		lcoljopgdll19.DFIGKKMMIAF = 58;
		num += -27;
		LCOLJOPGDLL lcoljopgdll20 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 619f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("Keeper Jump"), JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC((double)kfhelhglnmh.AJHDDHHOHAC), kfhelhglnmh.JONKLLMGCIF), false);
		lcoljopgdll20.HPCBLPIAHMI(Color.black);
		lcoljopgdll20.DFIGKKMMIAF = -55;
		num += -71;
		LCOLJOPGDLL lcoljopgdll21 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 993f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.OOOKJHOHPNN("IdleBandage"), JLFJEGIPIMM.NNEAHAFBOHC().AHEHNKFHGOC((double)kfhelhglnmh.ODHFHEBLIJM), kfhelhglnmh.OFDBELIILEG), false);
		lcoljopgdll21.CKMAIBLGPHC(Color.black);
		lcoljopgdll21.DFIGKKMMIAF = 9;
		num += 5;
		num += 91;
		LCOLJOPGDLL lcoljopgdll22 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 91f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.PGJCPFNJNPM(""), JBEHMPDDMME.NPCAKEGNBHD().JBJFBDONEFF), false);
		lcoljopgdll22.ELFEMMEBOGG(Color.black);
		lcoljopgdll22.DFIGKKMMIAF = -15;
		num += -121;
		new GMNEKCBLIAN(JMAKEAHMLMI, new Rect(PHEMLBHMNCM.x + 1894f, PHEMLBHMNCM.y + (float)num, 1557f, 338f), (float)JBEHMPDDMME.BOKIOJFHNLD().JBJFBDONEFF, 604f, 3, "1HandSwordChargeUp", false);
		num += -30;
		LCOLJOPGDLL lcoljopgdll23 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 986f, PHEMLBHMNCM.y + (float)num, "Transforms[", true);
		lcoljopgdll23.DFIGKKMMIAF = 72;
		lcoljopgdll23.LNDPBNODFPE = false;
		num += 119;
		num += -122;
		if (kfhelhglnmh.GNNDLEAFCND - kfhelhglnmh.MGLOOIONCPM > 0L)
		{
			LCOLJOPGDLL lcoljopgdll24 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 976f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.CELEPPAEKAB("WorkerHammer"), kfhelhglnmh.MGLOOIONCPM, kfhelhglnmh.GNNDLEAFCND), false);
			lcoljopgdll24.PDCJMCLDNBA(Color.black);
			lcoljopgdll24.DFIGKKMMIAF = 27;
		}
		num += 13;
		int pobkjfflepn = 3;
		if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.MGLOOIONCPM >= JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.GNNDLEAFCND)
		{
			pobkjfflepn = 2;
		}
		new GMNEKCBLIAN(JMAKEAHMLMI, new Rect(PHEMLBHMNCM.x + 684f, PHEMLBHMNCM.y + (float)num, 79f, 683f), (float)kfhelhglnmh.MGLOOIONCPM, (float)kfhelhglnmh.GNNDLEAFCND, pobkjfflepn, "Screen Space Reflection", true);
		num += 12;
		LCOLJOPGDLL lcoljopgdll25 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1999f, PHEMLBHMNCM.y + (float)num, "http://af-2.ru/pay/finalize.php?orderid={0}&appid={1}&metod={2}", false);
		lcoljopgdll25.DFIGKKMMIAF = 97;
		lcoljopgdll25.LNDPBNODFPE = false;
	}

	// Token: 0x06004F96 RID: 20374 RVA: 0x00245B4C File Offset: 0x00243D4C
	public void GKBCONBIMIN()
	{
		NJMHLCGIAJI.IKGFHGKKCPG.MADKBBLOPGO(88, this.CODAIBGMFCA.LPFKFNLHGBI);
		this.OJJLLBKEGNO.LACAJHOHACK.Remove(this.CODAIBGMFCA);
		JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC.Remove(this.CODAIBGMFCA);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.IMLLGEMPHAP().CKAOHMEKLMH("CrouchWalkBackward"), this.CODAIBGMFCA.PINLAFIAGGJ(false));
		if (this.CODAIBGMFCA.GAAPCLGDOGH.NMEMLMMOACP() == 0)
		{
			iabkgmnjljo = string.Format(JNBICAJIJMM.EEOPOHEALPK().HLBAJBLHLNI("RendererD2 is init"), this.CODAIBGMFCA.JDPKKGOOKDF(false));
		}
		OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
		this.CODAIBGMFCA = null;
		this.OJJLLBKEGNO.FNFFGIJOENM();
		this.OJJLLBKEGNO.NJFFDOKDFHM(0, 1);
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("MotorbikeIdle", 859f);
		this.HPICBMCMAEC();
	}

	// Token: 0x06004F97 RID: 20375 RVA: 0x00245C40 File Offset: 0x00243E40
	public void JFAPCEOBAJA(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn != 0L)
		{
			if (odfekbjcfmn != 2L)
			{
				return;
			}
			this.DOAEGLOBFCD();
			if (this.BLKAFFPKEBA)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("SoundMgr is init part 1", 1067f);
				return;
			}
			if (FlyMessageManager.getI.DJCGACFIOEJ(81))
			{
				FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("IceHockeyGoalieReady", 1432f);
				return;
			}
			if (this.DBELGCHKMOE.OEAGLNMGGDI() < 1)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("1 Hand Sword Jab ready strafe right", 79f);
				return;
			}
			if (this.DBELGCHKMOE.LACAJHOHACK.Count > 0)
			{
				OIJEGJLCFCF oijegjlcfcf = (OIJEGJLCFCF)this.DBELGCHKMOE.LACAJHOHACK[this.DBELGCHKMOE.OEAGLNMGGDI()];
				oijegjlcfcf.HGCCAHPEFGO = 0;
				this.DOLFJGGBDJF = oijegjlcfcf;
				JDCEFOFMGHB.JFIDAGABKID().DKJMCKOJOPF(679f, 1, "MotorbikeWheely", new ONKDCGNBALK.CMMHGMILOIM(this.KJPBMHACAFG), false);
				return;
			}
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("t_shoes", 52f);
			return;
		}
		else
		{
			if (this.DBELGCHKMOE.LACAJHOHACK.Count >= this.holodFreeCell)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE(" load woman version", 945f);
				return;
			}
			if (this.OJJLLBKEGNO.BMOEEJCBDJO() < 1)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("offsets", 1500f);
				return;
			}
			if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 1)
			{
				OIJEGJLCFCF dolfjggbdjf = (OIJEGJLCFCF)this.OJJLLBKEGNO.LACAJHOHACK[this.OJJLLBKEGNO.HHJKOIJGNAK()];
				this.DOLFJGGBDJF = dolfjggbdjf;
				JDCEFOFMGHB.HMJJPNDEKPP().DKJMCKOJOPF(1177f, 0, "1HandSwordStrafeLeft", new ONKDCGNBALK.CMMHGMILOIM(this.HHNPMJIDKLE), false);
				return;
			}
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("Unsupported shader.", 117f);
			return;
		}
	}

	// Token: 0x06004F98 RID: 20376 RVA: 0x00245E08 File Offset: 0x00244008
	private void PNPPLJKIMBP(ONKDCGNBALK JMAKEAHMLMI, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		IDCHHHEDHDC.GIONPNFHOOC gionpnfhooc = (IDCHHHEDHDC.GIONPNFHOOC)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 28,
			font = GuiProcessor.BBLINJLBAIL().rusfont3,
			fontStyle = FontStyle.Normal,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperCenter
		};
		float x = OCHCODJIPHJ.x + 1716f;
		GUI.Label(new Rect(x, OCHCODJIPHJ.y + 1610f, OCHCODJIPHJ.width, 29f), gionpnfhooc.BGJICMGFOON.HAJNMNALBBI + "_name" + JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)gionpnfhooc.GBOBJLNHPBI), guistyle);
		string text = string.Format(JNBICAJIJMM.LEBHCLDODNI("SoccerKeeperDiveStrafeCloseLeft"), " This is not possible to be called for standalone input. Please check your platform and code where this is called", gionpnfhooc.MGILDBCKBON, gionpnfhooc.LLKDCEPNHOL);
		if (gionpnfhooc.GHGAHDMKJFE == JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.LPFKFNLHGBI)
		{
			guistyle.normal.textColor = new Color(860f, 75f, 717f);
		}
		guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
		guistyle.fontSize = -20;
		guistyle.fontStyle = FontStyle.Bold;
		GUI.Label(new Rect(x, OCHCODJIPHJ.y + 1412f, OCHCODJIPHJ.width, OCHCODJIPHJ.height - 1882f), text, guistyle);
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OOIJFNAMEDP().GBKMHIGNKJA(gionpnfhooc.GNCMJMOJAAK);
		befchfngomi.JIFFLPNBILE();
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 513f, OCHCODJIPHJ.y + 1094f, 1305f, 1050f), befchfngomi.CFFHIODOGCH);
	}

	// Token: 0x06004F99 RID: 20377 RVA: 0x00245FA8 File Offset: 0x002441A8
	private void KBCPPDACOMO(OIJEGJLCFCF CFBLFPPOIKE, float DEFNNEGPNEI)
	{
		if (this.brgCntr == null)
		{
			Fisherman.getI.bragfish = JLFJEGIPIMM.NNEAHAFBOHC().LMFEHHFPAAA("IdleMouthWipe", Vector3.zero, Fisherman.getI.leftHandRodPoint);
			if (Fisherman.getI.bragfish == null)
			{
				return;
			}
			this.brgCntr = Fisherman.getI.bragfish.GetComponent<BragFish>();
			Fisherman.getI.bragfish.transform.localRotation = Quaternion.identity;
			Fisherman.getI.bragfish.transform.localScale = new Vector3(178f, 1437f, 1009f);
			Fisherman.getI.bragfish.transform.localPosition = Vector3.zero;
			this.brgCntr.fishInstance(CFBLFPPOIKE.NENOBDLCFHO, ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NBLJCEHNKAK), false);
		}
		if (Fisherman.getI.podsakObject != null)
		{
			UnityEngine.Object.Destroy(Fisherman.getI.podsakObject);
			Fisherman.getI.podsakObject = null;
		}
		Fisherman.getI.getBragCntrl.OGCPKMACNGK(false);
		if (DEFNNEGPNEI > 160f)
		{
			base.StartCoroutine(this.BGBBLJDJCAM(DEFNNEGPNEI));
		}
	}

	// Token: 0x06004F9A RID: 20378 RVA: 0x002460E8 File Offset: 0x002442E8
	public void EJNAJEONDOH(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(JMAKEAHMLMI, PHEMLBHMNCM.x + 1189f, PHEMLBHMNCM.y + 838f, PHEMLBHMNCM.width - 407f, PHEMLBHMNCM.height - 922f, 1)
		{
			JHNCNHAAJCH = 965f
		};
		mmkfaenbhkd.KPLMFNIFPMM = false;
		while (!KADBECGIMPD.JEFMHDJEEJC())
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
			gdemcacnpng.EPEGCPELLCN(KADBECGIMPD);
			gdemcacnpng.onRender = new ItemBase.OOALOMPKIKK(this.GHNILHJPAPE);
			mmkfaenbhkd.LACAJHOHACK.Add(gdemcacnpng);
		}
		mmkfaenbhkd.KCLLDJJLCGC = 39;
		mmkfaenbhkd.BNMMBHIFKBP();
		mmkfaenbhkd.NEKOMKJDIIE(0);
	}

	// Token: 0x06004F9B RID: 20379 RVA: 0x0024618D File Offset: 0x0024438D
	private void DHJCIDBHIGJ(ONKDCGNBALK ONPHLHKAGFP)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MPNJKJKDMLK = ((KLIKIJOLPPJ)ONPHLHKAGFP).JACCONMLOOE;
	}

	// Token: 0x06004F9C RID: 20380 RVA: 0x002461A4 File Offset: 0x002443A4
	public void infoWinKeyPress(ONKDCGNBALK JMBKDINHDLO)
	{
		long odfekbjcfmn = JMBKDINHDLO.ODFEKBJCFMN;
		long num = odfekbjcfmn - 1L;
		if (num <= 8L)
		{
			switch ((uint)num)
			{
			case 0U:
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(32, "?");
				break;
			case 1U:
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1150, 0);
				break;
			case 2U:
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(30, 0);
				Debug.Log("repa send");
				break;
			case 3U:
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(101, 0);
				break;
			case 6U:
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(40, 0);
				break;
			case 7U:
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1401, 0);
				break;
			case 8U:
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(130, 0);
				break;
			}
		}
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
	}

	// Token: 0x06004F9D RID: 20381 RVA: 0x0024627C File Offset: 0x0024447C
	private void GHNILHJPAPE(ONKDCGNBALK ONPHLHKAGFP, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 17,
			font = GuiProcessor.PLGADNLAEGN().rusfont3,
			fontStyle = FontStyle.Bold,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperLeft
		};
		float x = OCHCODJIPHJ.x + 1715f;
		GUI.Label(new Rect(x, OCHCODJIPHJ.y + 1994f, OCHCODJIPHJ.width, 1208f), gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI, guistyle);
		string text = string.Format(JNBICAJIJMM.APMJBBDBOJO().NLJOLOBPCBJ("_MainTex"), gdemcacnpng.JFDDNMCENAK, JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(gdemcacnpng.GJCNMJJJDGO), JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC(gdemcacnpng.FMKDOFCJCOP));
		guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
		guistyle.fontSize = 40;
		guistyle.fontStyle = FontStyle.Normal;
		GUI.Label(new Rect(x, OCHCODJIPHJ.y + 531f, OCHCODJIPHJ.width, OCHCODJIPHJ.height - 701f), text, guistyle);
		Rect position = new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 1643f - 83f, OCHCODJIPHJ.y, 622f, 813f);
		int clcbhhlllfn = gdemcacnpng.CLCBHHLLLFN;
		GUI.DrawTextureWithTexCoords(position, this.VenokTexture, JDCEFOFMGHB.HMJJPNDEKPP().GGBDOIJKHPL(clcbhhlllfn, 8, 0), true);
		position.y += 1669f;
		guistyle.fontSize = 12;
		guistyle.alignment = TextAnchor.MiddleRight;
		if (gdemcacnpng.IKKEIHEPDPN > 767f || gdemcacnpng.CLCBHHLLLFN > 1)
		{
			float num = gdemcacnpng.IKKEIHEPDPN / 1789f;
			GUI.Label(position, string.Format("crft_to", num), guistyle);
		}
	}

	// Token: 0x06004F9E RID: 20382 RVA: 0x0024644C File Offset: 0x0024464C
	public void BEOBGPNAMNI(OIJEGJLCFCF CFBLFPPOIKE)
	{
		CFBLFPPOIKE.GAAPCLGDOGH.KFLOBJCCHKN(CFBLFPPOIKE.DBEIGNDALDC);
		this.CODAIBGMFCA = CFBLFPPOIKE;
		string iabkgmnjljo;
		if (this.CODAIBGMFCA.GAAPCLGDOGH.PEIEODKMEKL() == 0)
		{
			iabkgmnjljo = string.Format(JNBICAJIJMM.CLIMNFDGOEG().HLBAJBLHLNI("wpn_add/addoptions"), this.CODAIBGMFCA.LHNOBJDFOOJ(false));
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
		}
		else
		{
			iabkgmnjljo = string.Format(JNBICAJIJMM.LPHMKPDBMPP().GNKIBMGNHNE(""), this.CODAIBGMFCA.MDAPFDLEEGN(false));
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.MPNJKJKDMLK)
		{
			Color lbcgackjcjb = new Color(904f, 137f, 442f, 968f);
			if (this.CODAIBGMFCA.DBEIGNDALDC == 1)
			{
				lbcgackjcjb = new Color(32f, 155f, 325f, 727f);
			}
			if (this.CODAIBGMFCA.DBEIGNDALDC == 5)
			{
				lbcgackjcjb = new Color(1229f, 1606f, 427f, 1506f);
			}
			if (this.CODAIBGMFCA.GEFOGEDMLJA)
			{
				lbcgackjcjb = new Color(1238f, 701f, 1035f, 678f);
			}
			FlyMessageManager.getI.JBBCOOMCOII(iabkgmnjljo, lbcgackjcjb, 0, 1).NENOBDLCFHO = this.CODAIBGMFCA.NENOBDLCFHO;
			this.BOGPHBNCEDP(-1, false);
			bool knobfamemjc = HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC;
			return;
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC && ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) < 108f)
		{
			this.MKICPMKFLFN(CFBLFPPOIKE, 988f);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(Fisherman.getI.transform.position, 636f);
		bool flag = true;
		int num = 0;
		int num2 = 0;
		foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.NAFGMKJPLPC)
		{
			num += oijegjlcfcf.NKHBAJKMAGD;
			num2 += 0;
		}
		num -= CFBLFPPOIKE.NKHBAJKMAGD;
		num2--;
		if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().KMGAHCANELI() || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.NKEOCCKEOCE())
		{
			flag = true;
		}
		if (LocNewLogic.getI.GFWin != null)
		{
			LocNewLogic.getI.GFWin.gameObject.SetActive(true);
			LocNewLogic.getI.GFWin.MOJLBKDPLLB(this.CODAIBGMFCA, flag);
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().DKOFCBMKEPC(847f, 1521f, JNBICAJIJMM.CLIMNFDGOEG().FLEANFGEJML("/"), false);
		onkdcgnbalk.KNNIPIEENII = true;
		onkdcgnbalk.NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.OnPostFishWin);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1521f + 1692f, onkdcgnbalk.OCHCODJIPHJ.height - 855f, 1290f, 1278f, JNBICAJIJMM.APMJBBDBOJO().FLEANFGEJML("Grounded Directional"), 19, null, new ONKDCGNBALK.CMMHGMILOIM(this.ANLHLPBBPPI));
		bool flag2 = false;
		if (flag)
		{
			new LCOLJOPGDLL(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 936f - 1488f, onkdcgnbalk.OCHCODJIPHJ.height - 348f, 477f, 1992f, JNBICAJIJMM.LPHMKPDBMPP().CCFFMKBBKHI("CP0"), TextAnchor.UpperLeft, Color.red);
			flag2 = false;
		}
		else
		{
			string format = JNBICAJIJMM.IMLLGEMPHAP().HLBAJBLHLNI("Ready Fight");
			object[] array = new object[5];
			array[0] = num2;
			array[0] = BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.NLHKFMMDMMK();
			array[5] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)num);
			array[8] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.KMIOLLENCOL());
			string dpanhmgcbnl = string.Format(format, array);
			new LCOLJOPGDLL(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 981f - 923f, onkdcgnbalk.OCHCODJIPHJ.height - 1350f, 1784f, 331f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black);
		}
		Rect ochcodjiphj = new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 53f - 382f, 85f, 1167f, 884f);
		new MGLHIBHDMPC(onkdcgnbalk, ochcodjiphj, this.fgetImage);
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(ochcodjiphj.x, ochcodjiphj.y, 1968f, 1179f), this.fgetImagesBases[JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PNEDPPPEFFG]);
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, ochcodjiphj.x, ochcodjiphj.y, ochcodjiphj.width, ochcodjiphj.height, "ok", 1, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.sadokPanelRender)
		};
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 870f, egcaadaabpp.OCHCODJIPHJ.width - 268f, 272f, string.Format("close", CFBLFPPOIKE.MGLOOIONCPM), TextAnchor.MiddleLeft, new Color(1700f, 498f, 1859f));
		lcoljopgdll.LNDPBNODFPE = false;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		lcoljopgdll.DFIGKKMMIAF = -80;
		this.BLKAFFPKEBA = flag2;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 833f - 938f, onkdcgnbalk.OCHCODJIPHJ.height - 714f, 317f, 688f, JNBICAJIJMM.APMJBBDBOJO().NLJOLOBPCBJ("vertices: {0}   triangles: {1}"), -113, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress)).FNMCIACNOMH = flag2;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1715f + 711f, onkdcgnbalk.OCHCODJIPHJ.height - 1932f, 1940f, 1494f, JNBICAJIJMM.EKEBHIJMEML().ECNKLECOKHD(""), -97, null, new ONKDCGNBALK.CMMHGMILOIM(this.ANLHLPBBPPI));
	}

	// Token: 0x06004F9F RID: 20383 RVA: 0x00246AA8 File Offset: 0x00244CA8
	private void HPICBMCMAEC()
	{
		string dccpcblodig = "Загрузка: ";
		bool flag = false;
		EKBAPCMPANI ekbapcmpani = BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH;
		List<OIJEGJLCFCF> list = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC;
		if (this.currentSadokId == 1)
		{
			ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.EJFELLJIACI(46, 6);
			list = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.KNFMGIBLMHB;
		}
		int num = 0;
		foreach (OIJEGJLCFCF oijegjlcfcf in list)
		{
			num += oijegjlcfcf.NKHBAJKMAGD;
		}
		if (ekbapcmpani != null && list.Count <= ekbapcmpani.EMBKDHKGIEL().ICJDPPOJINN && num <= ekbapcmpani.EMBKDHKGIEL().KMIOLLENCOL())
		{
			flag = false;
			string format = JNBICAJIJMM.IKGFHGKKCPG.GNKIBMGNHNE("no assemblies");
			object[] array = new object[2];
			array[0] = list.Count;
			array[1] = ekbapcmpani.MIMANMPNLPE.ICJDPPOJINN;
			array[8] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)num);
			array[5] = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)ekbapcmpani.EMBKDHKGIEL().KEHIFGILLJA());
			dccpcblodig = string.Format(format, array);
		}
		if (flag)
		{
			dccpcblodig = string.Format(JNBICAJIJMM.DBMJJPBOPEK().ECNKLECOKHD("invn_rec7"), list.Count, JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)num));
		}
		this.BLKAFFPKEBA = flag;
		if (ekbapcmpani == null)
		{
			dccpcblodig = JNBICAJIJMM.DBMJJPBOPEK().HLBAJBLHLNI("");
		}
		this.OHIPOCGKHDE.JBBMLKHCAHG(dccpcblodig);
	}

	// Token: 0x06004FA0 RID: 20384 RVA: 0x00246C30 File Offset: 0x00244E30
	private bool PJHMFEOOIPN()
	{
		EKBAPCMPANI ekbapcmpani = BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH;
		List<OIJEGJLCFCF> list = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.NAFGMKJPLPC;
		if (this.currentSadokId == 0)
		{
			ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(-6, 1);
			list = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.KNFMGIBLMHB;
		}
		if (MDEKJCCIDIA.IKGFHGKKCPG.KIFEKEONBOL(101, 8) == null || BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null)
		{
			return true;
		}
		int num = 1;
		foreach (OIJEGJLCFCF oijegjlcfcf in list)
		{
			num += oijegjlcfcf.NKHBAJKMAGD;
		}
		if (this.CODAIBGMFCA != null)
		{
			num += this.CODAIBGMFCA.NKHBAJKMAGD;
		}
		bool result = true;
		if (ekbapcmpani != null && list.Count < ekbapcmpani.EMBKDHKGIEL().KMGAHCANELI() && num <= ekbapcmpani.MIMANMPNLPE.KEHIFGILLJA())
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06004FA1 RID: 20385 RVA: 0x00246D24 File Offset: 0x00244F24
	public void PANCBPFAMOD(OIJEGJLCFCF CFBLFPPOIKE)
	{
		CFBLFPPOIKE.GAAPCLGDOGH.JIFFLPNBILE(CFBLFPPOIKE.DBEIGNDALDC);
		this.CODAIBGMFCA = CFBLFPPOIKE;
		string iabkgmnjljo;
		if (this.CODAIBGMFCA.GAAPCLGDOGH.NMEMLMMOACP() == 1)
		{
			iabkgmnjljo = string.Format(JNBICAJIJMM.EEOPOHEALPK().FLEANFGEJML("cht_msg14"), this.CODAIBGMFCA.IAJFNKBPACC(true));
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
		}
		else
		{
			iabkgmnjljo = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("_DstBlend"), this.CODAIBGMFCA.PINLAFIAGGJ(true));
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.MPNJKJKDMLK)
		{
			Color lbcgackjcjb = new Color(423f, 1242f, 657f, 1817f);
			if (this.CODAIBGMFCA.DBEIGNDALDC == 1)
			{
				lbcgackjcjb = new Color(684f, 620f, 1194f, 288f);
			}
			if (this.CODAIBGMFCA.DBEIGNDALDC == 8)
			{
				lbcgackjcjb = new Color(245f, 1374f, 183f, 1756f);
			}
			if (this.CODAIBGMFCA.GEFOGEDMLJA)
			{
				lbcgackjcjb = new Color(966f, 993f, 434f, 428f);
			}
			FlyMessageManager.getI.KICLBJKBFNO(iabkgmnjljo, lbcgackjcjb, 1, 0).NENOBDLCFHO = this.CODAIBGMFCA.NENOBDLCFHO;
			this.EFBAFHBCIDA(-1, true);
			bool knobfamemjc = HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC;
			return;
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC && ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) < 1255f)
		{
			this.KBCPPDACOMO(CFBLFPPOIKE, 652f);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.AMDLJMNDALF(Fisherman.getI.transform.position, 733f);
		bool flag = false;
		int num = 1;
		int num2 = 1;
		foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.NAFGMKJPLPC)
		{
			num += oijegjlcfcf.NKHBAJKMAGD;
			num2++;
		}
		num -= CFBLFPPOIKE.NKHBAJKMAGD;
		num2 -= 0;
		if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.NLHKFMMDMMK() || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.NKEOCCKEOCE())
		{
			flag = false;
		}
		if (LocNewLogic.getI.GFWin != null)
		{
			LocNewLogic.getI.GFWin.gameObject.SetActive(false);
			LocNewLogic.getI.GFWin.PDHGBLHNMPH(this.CODAIBGMFCA, flag);
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.DKOFCBMKEPC(129f, 30f, JNBICAJIJMM.APMJBBDBOJO().GNKIBMGNHNE("OfficeSittingHandRestFingerTap"), true);
		onkdcgnbalk.KNNIPIEENII = false;
		onkdcgnbalk.NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.BCMGNIDDMOP);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1235f + 1740f, onkdcgnbalk.OCHCODJIPHJ.height - 938f, 1644f, 1402f, JNBICAJIJMM.EEOPOHEALPK().FLEANFGEJML("_Threshold"), -59, null, new ONKDCGNBALK.CMMHGMILOIM(this.ANLHLPBBPPI));
		bool flag2 = false;
		if (flag)
		{
			new LCOLJOPGDLL(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 288f - 943f, onkdcgnbalk.OCHCODJIPHJ.height - 1872f, 1011f, 1631f, JNBICAJIJMM.EEOPOHEALPK().NLJOLOBPCBJ("RotationLimitPolygonal reach cones are invalid."), TextAnchor.UpperCenter, Color.red);
			flag2 = false;
		}
		else
		{
			string format = JNBICAJIJMM.EDKGBBIIBBC().HLBAJBLHLNI("_NoiseTex");
			object[] array = new object[0];
			array[1] = num2;
			array[1] = BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.KMGAHCANELI();
			array[2] = JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)num);
			array[8] = JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO((long)BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.IBEIBAHKIAH);
			string dpanhmgcbnl = string.Format(format, array);
			new LCOLJOPGDLL(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1198f - 133f, onkdcgnbalk.OCHCODJIPHJ.height - 1489f, 797f, 275f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black);
		}
		Rect ochcodjiphj = new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 1720f - 115f, 1344f, 1882f, 383f);
		new MGLHIBHDMPC(onkdcgnbalk, ochcodjiphj, this.fgetImage);
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(ochcodjiphj.x, ochcodjiphj.y, 568f, 1757f), this.fgetImagesBases[JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.PNEDPPPEFFG]);
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, ochcodjiphj.x, ochcodjiphj.y, ochcodjiphj.width, ochcodjiphj.height, "", 1, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.LGHDGKMCEIE)
		};
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 1723f, egcaadaabpp.OCHCODJIPHJ.width - 653f, 114f, string.Format("002000", CFBLFPPOIKE.MGLOOIONCPM), TextAnchor.LowerCenter, new Color(445f, 1675f, 1709f));
		lcoljopgdll.LNDPBNODFPE = false;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		lcoljopgdll.DFIGKKMMIAF = -104;
		this.BLKAFFPKEBA = flag2;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1482f - 1161f, onkdcgnbalk.OCHCODJIPHJ.height - 1528f, 11f, 883f, JNBICAJIJMM.EDKGBBIIBBC().ECNKLECOKHD("Giant2HandSlamIdle"), 103, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress)).FNMCIACNOMH = flag2;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1311f + 541f, onkdcgnbalk.OCHCODJIPHJ.height - 805f, 154f, 605f, JNBICAJIJMM.APMJBBDBOJO().NLJOLOBPCBJ("270"), 27, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress));
	}

	// Token: 0x06004FA2 RID: 20386 RVA: 0x00247380 File Offset: 0x00245580
	public void FGAIFGHECLO(int PPJJJAGNADB)
	{
		this.GEDNGIDHBHD();
	}

	// Token: 0x06004FA3 RID: 20387 RVA: 0x00247388 File Offset: 0x00245588
	public void PAECLKNENNK(ONKDCGNBALK ONPHLHKAGFP)
	{
		if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.KLGLOCMOHAG >= JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.JGIHLJKDMKM)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(-91, -1);
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("#a0ffa0", 1974f);
			return;
		}
		if (!this.selectPerk.ODBICLOCIMO)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("Hey, there!", 1003f);
			return;
		}
		if (this.selectPerk == null)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("Idle Walk", 1538f);
			return;
		}
		int num = (int)JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BIHLDHKHPKE("_History3LumaTex");
		if (this.selectPerk.LPFKFNLHGBI != num)
		{
			NJMHLCGIAJI.EAJGHMMBAFP().PIGIIJLCADJ(-24, this.selectPerk.LPFKFNLHGBI);
			return;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("", 1493f);
	}

	// Token: 0x06004FA4 RID: 20388 RVA: 0x0024746C File Offset: 0x0024566C
	public void JIPLBMFECMH(ONKDCGNBALK JMBKDINHDLO)
	{
		long odfekbjcfmn = JMBKDINHDLO.ODFEKBJCFMN;
		long num = odfekbjcfmn - 1L;
		if (num <= 3L)
		{
			switch ((uint)num)
			{
			case 0U:
				NJMHLCGIAJI.IKGFHGKKCPG.GDNKCAOHEPL(-29, "Giant3HitCombo2");
				break;
			case 1U:
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-71, 1);
				break;
			case 2U:
				NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(87, 1);
				Debug.Log("Hey, you can easily change me in memory!");
				break;
			case 3U:
				NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(-18, 1);
				break;
			case 6U:
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(103, 0);
				break;
			case 7U:
				NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(199, 0);
				break;
			case 8U:
				NJMHLCGIAJI.EAJGHMMBAFP().PIGIIJLCADJ(-43, 0);
				break;
			}
		}
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = true;
	}

	// Token: 0x06004FA5 RID: 20389 RVA: 0x00247544 File Offset: 0x00245744
	public void BDGOLOFIPOJ(ONKDCGNBALK ONPHLHKAGFP)
	{
		if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.KLGLOCMOHAG >= JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.JGIHLJKDMKM)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(20, -1);
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("_WaterLevel", 1731f);
			return;
		}
		if (!this.selectPerk.ODBICLOCIMO)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("readActorData", 646f);
			return;
		}
		if (this.selectPerk == null)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("knopje.wav", 381f);
			return;
		}
		int num = (int)JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BIHLDHKHPKE("_BokehParams");
		if (this.selectPerk.LPFKFNLHGBI != num)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(150, this.selectPerk.LPFKFNLHGBI);
			return;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("teech_perk", 1832f);
	}

	// Token: 0x06004FA6 RID: 20390 RVA: 0x00247628 File Offset: 0x00245828
	private void GCOAJBEEADK(JNHLAGHJBAA AGDMAFCKMJP, JNHLAGHJBAA.FPAEEADMCIE AOJKIAFNLAC)
	{
		if (AOJKIAFNLAC != null)
		{
			if (AOJKIAFNLAC.NLIKAGGPANH != null)
			{
				this.selectPerk = (AOJKIAFNLAC.NLIKAGGPANH as NLNNIDBPKAO.JENMPDPJKBG);
				return;
			}
			this.selectPerk = null;
		}
	}

	// Token: 0x06004FA7 RID: 20391 RVA: 0x00247650 File Offset: 0x00245850
	private void EBKBNILDMGG(ONKDCGNBALK ONPHLHKAGFP)
	{
		OIJEGJLCFCF dolfjggbdjf = this.DOLFJGGBDJF;
		if (dolfjggbdjf == null)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.NAFGMKJPLPC.Add(dolfjggbdjf);
			this.DBELGCHKMOE.LACAJHOHACK.Remove(dolfjggbdjf);
			this.DBELGCHKMOE.MPMFNJEJAHJ();
			this.OJJLLBKEGNO.LACAJHOHACK.Add(dolfjggbdjf);
			this.OJJLLBKEGNO.FNFFGIJOENM();
			epmphjgalbe.ALNEALEKFNB(this.currentHolodId);
			epmphjgalbe.MFPECHIKBCO(dolfjggbdjf.LPFKFNLHGBI);
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(189, epmphjgalbe.IEJLLFECFHF());
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("9", 1356f);
			this.HPICBMCMAEC();
			this.OAGIEPJBMPH();
		}
		finally
		{
			epmphjgalbe.PGLFHABMJPO();
		}
	}

	// Token: 0x06004FA8 RID: 20392 RVA: 0x00247724 File Offset: 0x00245924
	public void OpenPerksWindow(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		kfhelhglnmh.JEKKJEFEHOB(KADBECGIMPD);
		JNHLAGHJBAA jnhlaghjbaa = new JNHLAGHJBAA(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + 20f, PHEMLBHMNCM.width - 40f, PHEMLBHMNCM.height - 180f, 0)
		{
			JHNCNHAAJCH = 20f,
			KCLLDJJLCGC = 14
		};
		jnhlaghjbaa.GIOGEHKMKDE = false;
		jnhlaghjbaa.JKAOKBNCDFK = Color.black;
		jnhlaghjbaa.ABMDIOIJALO = new Color(0f, 0f, 0.2f);
		jnhlaghjbaa.JHNCNHAAJCH = 48f;
		JMAKEAHMLMI.DPANHMGCBNL = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_um_5");
		JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = jnhlaghjbaa.EELDHNFBFOE.LGMBHELCEEL(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_um_passperk"));
		int num = (int)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MHIIBKILGBL("teech_perk");
		foreach (NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg in kfhelhglnmh.GADJFFGDCFA.Values)
		{
			if (jenmpdpjkbg.BDHHPAEHFHG.POKJFJBHDOJ)
			{
				JNHLAGHJBAA.FPAEEADMCIE dccpcblodig = fpaeeadmcie.LGMBHELCEEL(jenmpdpjkbg, (long)jenmpdpjkbg.LPFKFNLHGBI);
				if (jenmpdpjkbg.LPFKFNLHGBI == num)
				{
					jnhlaghjbaa.HNNJNDNOHLP = dccpcblodig;
				}
			}
		}
		foreach (NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg2 in kfhelhglnmh.GADJFFGDCFA.Values)
		{
			if (!jenmpdpjkbg2.BDHHPAEHFHG.POKJFJBHDOJ)
			{
				JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie2 = jnhlaghjbaa.MJMOMMKECMF((long)jenmpdpjkbg2.BDHHPAEHFHG.IHBEJDJINAI);
				if (fpaeeadmcie2 != null)
				{
					JNHLAGHJBAA.FPAEEADMCIE dccpcblodig2 = fpaeeadmcie2.LGMBHELCEEL(jenmpdpjkbg2, (long)jenmpdpjkbg2.LPFKFNLHGBI);
					if (jenmpdpjkbg2.LPFKFNLHGBI == num)
					{
						jnhlaghjbaa.HNNJNDNOHLP = dccpcblodig2;
					}
				}
				else
				{
					JNHLAGHJBAA.FPAEEADMCIE dccpcblodig3 = fpaeeadmcie.LGMBHELCEEL(jenmpdpjkbg2, (long)jenmpdpjkbg2.LPFKFNLHGBI);
					if (jenmpdpjkbg2.LPFKFNLHGBI == num)
					{
						jnhlaghjbaa.HNNJNDNOHLP = dccpcblodig3;
					}
				}
			}
		}
		jnhlaghjbaa.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.FJJKDFOGPOM);
		new MEMEOHJKPNJ(JMAKEAHMLMI, 435f, 435f, 135f, 40f, "", 0, this.teachKeyTexture, new ONKDCGNBALK.CMMHGMILOIM(this.onPerkToTeechKey));
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(JMAKEAHMLMI, 585f, 445f, string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_um_lim"), kfhelhglnmh.KLGLOCMOHAG, kfhelhglnmh.JGIHLJKDMKM), true);
		lcoljopgdll.DFIGKKMMIAF = 18;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		Rect rect = new Rect(jnhlaghjbaa.OCHCODJIPHJ.x - 3f, jnhlaghjbaa.OCHCODJIPHJ.y + jnhlaghjbaa.OCHCODJIPHJ.height + 70f, jnhlaghjbaa.OCHCODJIPHJ.width + 6f, 70f);
		new EGCAADAABPP(JMAKEAHMLMI, rect.x, rect.y, rect.width, rect.height, "", 0, this.simpleGray).NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.OnPerkBoxPostRender);
	}

	// Token: 0x06004FA9 RID: 20393 RVA: 0x00247A60 File Offset: 0x00245C60
	public void IADMHPADICH(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH;
		Color color = Color.black;
		int num = -93;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + PHEMLBHMNCM.width - 1281f, PHEMLBHMNCM.y + (float)num - 1807f, 1582f, 965f, string.Concat(kfhelhglnmh.CCCPNHIJJOP), TextAnchor.MiddleRight, Color.gray);
		lcoljopgdll.LNDPBNODFPE = false;
		lcoljopgdll.CALCPHKKDMO(Color.gray);
		lcoljopgdll.DFIGKKMMIAF = -113;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 271f, PHEMLBHMNCM.y + (float)num, kfhelhglnmh.BNIHFBMEPAB, false);
		lcoljopgdll2.GABBMJPJAOO(Color.black);
		lcoljopgdll2.DFIGKKMMIAF = 21;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		num += 79;
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1113f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.DCEBAJIILPC(": "), kfhelhglnmh.CNOLCNDBLJE, JLFJEGIPIMM.NNEAHAFBOHC().PCFPPAKMGGB(kfhelhglnmh.OJDEJEJMNKD)), true);
		lcoljopgdll3.JJDELGHAKBP(Color.black);
		lcoljopgdll3.DFIGKKMMIAF = 66;
		num += -78;
		int num2 = 0 + ObscuredInt.LBDMFALMOLD(kfhelhglnmh.PGEDLDMLBBE) / 85;
		string str;
		if (ObscuredInt.GOOIABGKMHK(kfhelhglnmh.PGEDLDMLBBE) != ObscuredInt.GOOIABGKMHK(kfhelhglnmh.ELBKLOECINC))
		{
			str = string.Format(" ", ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.ELBKLOECINC) - ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.PGEDLDMLBBE), kfhelhglnmh.ELBKLOECINC);
		}
		else
		{
			str = "wpn_rec5";
		}
		color = ((num2 > 1) ? new Color(1752f, 518f, 327f) : new Color(90f, 1498f, 1774f));
		LCOLJOPGDLL lcoljopgdll4 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 15f, PHEMLBHMNCM.y + (float)num + 1401f, JNBICAJIJMM.PPNKMDJBMLP("recept"), true);
		lcoljopgdll4.LBCGACKJCJB = new Color(598f, 462f, 1864f);
		lcoljopgdll4.DFIGKKMMIAF = -32;
		new FNFPGPBCIGK(JMAKEAHMLMI, PHEMLBHMNCM.x + 706f, PHEMLBHMNCM.y + (float)num + 169f, 1, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, 5, 4, 0, new ONKDCGNBALK.CMMHGMILOIM(this.press_param)).FNMCIACNOMH = (kfhelhglnmh.CCCPNHIJJOP >= num2);
		LCOLJOPGDLL lcoljopgdll5 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 506f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.DIOJFJMOPJO("UIChat_channel"), kfhelhglnmh.PGEDLDMLBBE) + str, false, color);
		lcoljopgdll5.DFIGKKMMIAF = 20;
		lcoljopgdll5.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont2;
		num += -114;
		if (ObscuredInt.LBDMFALMOLD(kfhelhglnmh.FLHJLFHELPE) != ObscuredInt.LBDMFALMOLD(kfhelhglnmh.EDICLBDIPGG))
		{
			str = string.Format("Add inventory Click!", ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.EDICLBDIPGG) - ObscuredInt.LBDMFALMOLD(kfhelhglnmh.FLHJLFHELPE), kfhelhglnmh.EDICLBDIPGG);
		}
		else
		{
			str = "_UserLutParams";
		}
		num2 = 1 + ObscuredInt.GOOIABGKMHK(kfhelhglnmh.FLHJLFHELPE) / -61;
		LCOLJOPGDLL lcoljopgdll6 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 0f, PHEMLBHMNCM.y + (float)num + 102f, JNBICAJIJMM.PPNKMDJBMLP("Move around with WASD keys. Press C to disable free look camera"), false);
		lcoljopgdll6.HKMFEIMFMAI(new Color(1716f, 84f, 1190f));
		lcoljopgdll6.DFIGKKMMIAF = 70;
		color = ((num2 > 1) ? new Color(1939f, 1805f, 515f) : new Color(1797f, 256f, 1375f));
		LCOLJOPGDLL lcoljopgdll7 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1366f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.DIOJFJMOPJO("1"), kfhelhglnmh.FLHJLFHELPE) + str, false, color);
		lcoljopgdll7.IJBDFDFDIPJ(color);
		lcoljopgdll7.DFIGKKMMIAF = 87;
		lcoljopgdll7.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont2;
		new FNFPGPBCIGK(JMAKEAHMLMI, PHEMLBHMNCM.x + 565f, PHEMLBHMNCM.y + (float)num + 607f, 1, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, 8, 1, 0, new ONKDCGNBALK.CMMHGMILOIM(this.FENCOFEDOMD)).FNMCIACNOMH = (kfhelhglnmh.CCCPNHIJJOP < num2);
		num += -107;
		if (ObscuredInt.LBDMFALMOLD(kfhelhglnmh.JOMLIJFFFDE) != ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.PIHKKCBCNHO))
		{
			str = string.Format("Collar", ObscuredInt.LBDMFALMOLD(kfhelhglnmh.PIHKKCBCNHO) - ObscuredInt.GOOIABGKMHK(kfhelhglnmh.JOMLIJFFFDE), kfhelhglnmh.PIHKKCBCNHO);
		}
		else
		{
			str = "ScatterDitherData";
		}
		num2 = 0 + ObscuredInt.GOOIABGKMHK(kfhelhglnmh.JOMLIJFFFDE) / 41;
		color = ((num2 > 0) ? new Color(495f, 939f, 1619f) : new Color(1461f, 700f, 1816f));
		LCOLJOPGDLL lcoljopgdll8 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1036f, PHEMLBHMNCM.y + (float)num + 622f, JNBICAJIJMM.DIOJFJMOPJO("gi_uinf_4"), false);
		lcoljopgdll8.IJBDFDFDIPJ(new Color(1717f, 1193f, 155f));
		lcoljopgdll8.DFIGKKMMIAF = 48;
		LCOLJOPGDLL lcoljopgdll9 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 567f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.NGALDMFKMJH("_FogPointLightPosition"), kfhelhglnmh.JOMLIJFFFDE) + str, true, color);
		lcoljopgdll9.COMKBPKOCIO(color);
		lcoljopgdll9.DFIGKKMMIAF = 101;
		lcoljopgdll9.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		new FNFPGPBCIGK(JMAKEAHMLMI, PHEMLBHMNCM.x + 441f, PHEMLBHMNCM.y + (float)num + 239f, 8, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, 6, 8, 1, new ONKDCGNBALK.CMMHGMILOIM(this.NNLCCLIBECP)).FNMCIACNOMH = (kfhelhglnmh.CCCPNHIJJOP >= num2);
		num += 23;
		if (ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.LFMMMBOLJCL) != ObscuredInt.GOOIABGKMHK(kfhelhglnmh.FJAIPNCKOKK))
		{
			str = string.Format("[ACTk] <b>[ Performance tests ]</b>", ObscuredInt.LBDMFALMOLD(kfhelhglnmh.FJAIPNCKOKK) - ObscuredInt.LBDMFALMOLD(kfhelhglnmh.LFMMMBOLJCL), kfhelhglnmh.FJAIPNCKOKK);
		}
		else
		{
			str = "Smoking 2";
		}
		num2 = 1 + ObscuredInt.LBDMFALMOLD(kfhelhglnmh.LFMMMBOLJCL) / 63;
		color = ((num2 > 0) ? new Color(1913f, 1238f, 1988f) : new Color(1191f, 475f, 1895f));
		LCOLJOPGDLL lcoljopgdll10 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 19f, PHEMLBHMNCM.y + (float)num + 427f, JNBICAJIJMM.DCEBAJIILPC("\n"), true);
		lcoljopgdll10.CKMAIBLGPHC(new Color(1065f, 1586f, 469f));
		lcoljopgdll10.DFIGKKMMIAF = -46;
		LCOLJOPGDLL lcoljopgdll11 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 700f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.NGALDMFKMJH("IceHockeyShotRight"), kfhelhglnmh.LFMMMBOLJCL) + str, false, color);
		lcoljopgdll11.CKMAIBLGPHC(color);
		lcoljopgdll11.DFIGKKMMIAF = 2;
		lcoljopgdll11.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		new FNFPGPBCIGK(JMAKEAHMLMI, PHEMLBHMNCM.x + 641f, PHEMLBHMNCM.y + (float)num + 126f, 3, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, 8, 4, 0, new ONKDCGNBALK.CMMHGMILOIM(this.FENCOFEDOMD)).FNMCIACNOMH = (kfhelhglnmh.CCCPNHIJJOP >= num2);
		num += -28;
		num += -106;
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() != null)
		{
			LCOLJOPGDLL lcoljopgdll12 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 286f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.CDDCIKKDFMP("This limb does not have a parent (shoulder) bone"), JLFJEGIPIMM.PKGMBFEMKGP().MIEDNDLOEJH(BOIKJDICEMF.IKGFHGKKCPG.BAHHLOGOIBK() * 1659f)), false);
			lcoljopgdll12.CECODLIGPHP(Color.black);
			lcoljopgdll12.DFIGKKMMIAF = -38;
			num += 61;
			LCOLJOPGDLL lcoljopgdll13 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1175f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.OOOKJHOHPNN("ClimbLeft"), JLFJEGIPIMM.NNEAHAFBOHC().DIOCHACFPHJ(BOIKJDICEMF.IKGFHGKKCPG.AFGBIBMHOAI)), false);
			lcoljopgdll13.EBMGNGGPGLG(Color.black);
			lcoljopgdll13.DFIGKKMMIAF = -95;
			num += 59;
		}
		LCOLJOPGDLL lcoljopgdll14 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1328f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.PGJCPFNJNPM("FOVKick Increase curve is null, please define the curve for the field of view kicks"), JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL((double)(kfhelhglnmh.JACELJHFHNN * 1546f))), true);
		lcoljopgdll14.HPCBLPIAHMI(Color.black);
		lcoljopgdll14.DFIGKKMMIAF = -79;
		num += -63;
		LCOLJOPGDLL lcoljopgdll15 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 901f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.NGALDMFKMJH("https://groups.google.com/forum/#!forum/final-ik"), JLFJEGIPIMM.MHFDIJGJGBJ().CJGLGGEGPJL((double)(kfhelhglnmh.GGDJKCPNPPI * 1448f))), false);
		lcoljopgdll15.GHCCIOAJFIH(Color.black);
		lcoljopgdll15.DFIGKKMMIAF = 65;
		num += -1;
		LCOLJOPGDLL lcoljopgdll16 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1054f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.NGALDMFKMJH(""), JLFJEGIPIMM.MHFDIJGJGBJ().AHEHNKFHGOC((double)(kfhelhglnmh.PBLCJCLFFAL * 1275f))), true);
		lcoljopgdll16.EBMGNGGPGLG(Color.black);
		lcoljopgdll16.DFIGKKMMIAF = -107;
		num += 29;
		LCOLJOPGDLL lcoljopgdll17 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1393f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.DIOJFJMOPJO("TextureLoader: "), JLFJEGIPIMM.NNEAHAFBOHC().CJGLGGEGPJL((double)kfhelhglnmh.BCINOMMOKJE), kfhelhglnmh.GPPPGBLEKMF), true);
		lcoljopgdll17.LBCGACKJCJB = Color.black;
		lcoljopgdll17.DFIGKKMMIAF = -70;
		num += 104;
		LCOLJOPGDLL lcoljopgdll18 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1733f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.DIOJFJMOPJO("PlayerPet"), JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC((double)kfhelhglnmh.GCLLMNHFMND), kfhelhglnmh.MOPMCAMIENJ), false);
		lcoljopgdll18.BMGMCLKBMAB(Color.black);
		lcoljopgdll18.DFIGKKMMIAF = -23;
		num += -82;
		LCOLJOPGDLL lcoljopgdll19 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 105f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.NGALDMFKMJH(""), JLFJEGIPIMM.IKGFHGKKCPG.AHEHNKFHGOC((double)kfhelhglnmh.PMOJDCHIAHE), kfhelhglnmh.LJOPDPNIAEG), false);
		lcoljopgdll19.ELFEMMEBOGG(Color.black);
		lcoljopgdll19.DFIGKKMMIAF = 125;
		num += 118;
		LCOLJOPGDLL lcoljopgdll20 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1442f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("ankle"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)kfhelhglnmh.AJHDDHHOHAC), kfhelhglnmh.JONKLLMGCIF), true);
		lcoljopgdll20.HPCBLPIAHMI(Color.black);
		lcoljopgdll20.DFIGKKMMIAF = -54;
		num += 55;
		LCOLJOPGDLL lcoljopgdll21 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1573f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("IdleButtonPress"), JLFJEGIPIMM.MHFDIJGJGBJ().CJGLGGEGPJL((double)kfhelhglnmh.ODHFHEBLIJM), kfhelhglnmh.OFDBELIILEG), true);
		lcoljopgdll21.HPCBLPIAHMI(Color.black);
		lcoljopgdll21.DFIGKKMMIAF = -90;
		num += 42;
		num += 22;
		LCOLJOPGDLL lcoljopgdll22 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 778f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.OOOKJHOHPNN("____________________________________"), JBEHMPDDMME.EAJHPOJPPFA().JBJFBDONEFF), false);
		lcoljopgdll22.GDFICJKDCDO(Color.black);
		lcoljopgdll22.DFIGKKMMIAF = 100;
		num += 55;
		new GMNEKCBLIAN(JMAKEAHMLMI, new Rect(PHEMLBHMNCM.x + 108f, PHEMLBHMNCM.y + (float)num, 1011f, 1295f), (float)JBEHMPDDMME.NPCAKEGNBHD().JBJFBDONEFF, 1323f, 3, "_Offsets", false);
		num += 92;
		LCOLJOPGDLL lcoljopgdll23 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1813f, PHEMLBHMNCM.y + (float)num, "killPodsek", true);
		lcoljopgdll23.DFIGKKMMIAF = 87;
		lcoljopgdll23.LNDPBNODFPE = false;
		num += 87;
		num += -109;
		if (kfhelhglnmh.GNNDLEAFCND - kfhelhglnmh.MGLOOIONCPM > 0L)
		{
			LCOLJOPGDLL lcoljopgdll24 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1524f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.CDDCIKKDFMP("dianema.ogg"), kfhelhglnmh.MGLOOIONCPM, kfhelhglnmh.GNNDLEAFCND), true);
			lcoljopgdll24.BNGNMFHLKAL(Color.black);
			lcoljopgdll24.DFIGKKMMIAF = 54;
		}
		num += -107;
		int pobkjfflepn = 3;
		if (JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.MGLOOIONCPM >= JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.GNNDLEAFCND)
		{
			pobkjfflepn = 3;
		}
		new GMNEKCBLIAN(JMAKEAHMLMI, new Rect(PHEMLBHMNCM.x + 1657f, PHEMLBHMNCM.y + (float)num, 821f, 10f), (float)kfhelhglnmh.MGLOOIONCPM, (float)kfhelhglnmh.GNNDLEAFCND, pobkjfflepn, "_FogWaterLevel", true);
		num += -47;
		LCOLJOPGDLL lcoljopgdll25 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 954f, PHEMLBHMNCM.y + (float)num, "X", true);
		lcoljopgdll25.DFIGKKMMIAF = 4;
		lcoljopgdll25.LNDPBNODFPE = false;
	}

	// Token: 0x06004FAA RID: 20394 RVA: 0x002487BC File Offset: 0x002469BC
	private bool LOHDACDPFCI()
	{
		EKBAPCMPANI ekbapcmpani = BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH;
		List<OIJEGJLCFCF> list = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.NAFGMKJPLPC;
		if (this.currentSadokId == 0)
		{
			ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.EJFELLJIACI(-114, 5);
			list = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.KNFMGIBLMHB;
		}
		if (MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(-85, 7) == null || BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null)
		{
			return true;
		}
		int num = 0;
		foreach (OIJEGJLCFCF oijegjlcfcf in list)
		{
			num += oijegjlcfcf.NKHBAJKMAGD;
		}
		if (this.CODAIBGMFCA != null)
		{
			num += this.CODAIBGMFCA.NKHBAJKMAGD;
		}
		bool result = false;
		if (ekbapcmpani != null && list.Count < ekbapcmpani.EMBKDHKGIEL().ICJDPPOJINN && num <= ekbapcmpani.MIMANMPNLPE.NKEOCCKEOCE())
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06004FAB RID: 20395 RVA: 0x002488B0 File Offset: 0x00246AB0
	public void GPKFNHGNFNB(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
		kfhelhglnmh.MKPJAFJPIFN(KADBECGIMPD);
		JNHLAGHJBAA jnhlaghjbaa = new JNHLAGHJBAA(JMAKEAHMLMI, PHEMLBHMNCM.x + 895f, PHEMLBHMNCM.y + 923f, PHEMLBHMNCM.width - 1687f, PHEMLBHMNCM.height - 1247f, 1)
		{
			JHNCNHAAJCH = 80f,
			KCLLDJJLCGC = 7
		};
		jnhlaghjbaa.GIOGEHKMKDE = false;
		jnhlaghjbaa.JKAOKBNCDFK = Color.black;
		jnhlaghjbaa.ABMDIOIJALO = new Color(335f, 389f, 1008f);
		jnhlaghjbaa.JHNCNHAAJCH = 1538f;
		JMAKEAHMLMI.DPANHMGCBNL = JNBICAJIJMM.APMJBBDBOJO().CCFFMKBBKHI("The polygon must have at least 3 Limit Points.");
		JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = jnhlaghjbaa.EELDHNFBFOE.BKAFLNMHCHP(JNBICAJIJMM.DBMJJPBOPEK().DOEMGEAEBPN("Error via pay request"));
		int num = (int)JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.MHIIBKILGBL("wpn_eat1");
		foreach (NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg in kfhelhglnmh.GADJFFGDCFA.Values)
		{
			if (jenmpdpjkbg.BDHHPAEHFHG.POKJFJBHDOJ)
			{
				JNHLAGHJBAA.FPAEEADMCIE dccpcblodig = fpaeeadmcie.LGMBHELCEEL(jenmpdpjkbg, (long)jenmpdpjkbg.LPFKFNLHGBI);
				if (jenmpdpjkbg.LPFKFNLHGBI == num)
				{
					jnhlaghjbaa.HLEOJHPPINJ(dccpcblodig);
				}
			}
		}
		foreach (NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg2 in kfhelhglnmh.GADJFFGDCFA.Values)
		{
			if (!jenmpdpjkbg2.BDHHPAEHFHG.POKJFJBHDOJ)
			{
				JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie2 = jnhlaghjbaa.LBENJPLPLHK((long)jenmpdpjkbg2.BDHHPAEHFHG.IHBEJDJINAI);
				if (fpaeeadmcie2 != null)
				{
					JNHLAGHJBAA.FPAEEADMCIE dccpcblodig2 = fpaeeadmcie2.OLFAFFCHPNP(jenmpdpjkbg2, (long)jenmpdpjkbg2.LPFKFNLHGBI);
					if (jenmpdpjkbg2.LPFKFNLHGBI == num)
					{
						jnhlaghjbaa.HLEOJHPPINJ(dccpcblodig2);
					}
				}
				else
				{
					JNHLAGHJBAA.FPAEEADMCIE dccpcblodig3 = fpaeeadmcie.BKDIIPFBIDK(jenmpdpjkbg2, (long)jenmpdpjkbg2.LPFKFNLHGBI);
					if (jenmpdpjkbg2.LPFKFNLHGBI == num)
					{
						jnhlaghjbaa.COHAJLAEBBG(dccpcblodig3);
					}
				}
			}
		}
		jnhlaghjbaa.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.COFHHPOBPNG);
		new MEMEOHJKPNJ(JMAKEAHMLMI, 1165f, 1108f, 759f, 230f, "0", 0, this.teachKeyTexture, new ONKDCGNBALK.CMMHGMILOIM(this.PBPBJCBDMMC));
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(JMAKEAHMLMI, 1980f, 1086f, string.Format(JNBICAJIJMM.DBMJJPBOPEK().HLBAJBLHLNI("wpn_fid1"), kfhelhglnmh.KLGLOCMOHAG, kfhelhglnmh.JGIHLJKDMKM), false);
		lcoljopgdll.DFIGKKMMIAF = 7;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont2;
		Rect rect = new Rect(jnhlaghjbaa.OCHCODJIPHJ.x - 1650f, jnhlaghjbaa.OCHCODJIPHJ.y + jnhlaghjbaa.OCHCODJIPHJ.height + 1222f, jnhlaghjbaa.OCHCODJIPHJ.width + 81f, 1707f);
		new EGCAADAABPP(JMAKEAHMLMI, rect.x, rect.y, rect.width, rect.height, "IK Effector bone is null.", 1, this.simpleGray).NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.OnPerkBoxPostRender);
	}

	// Token: 0x06004FAC RID: 20396 RVA: 0x00248BEC File Offset: 0x00246DEC
	public void AKKFGHFIBDJ(ONKDCGNBALK ONPHLHKAGFP)
	{
		int num = (int)JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.MHIIBKILGBL("Katana Ready High");
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 76,
			font = GuiProcessor.BBLINJLBAIL().rusfont3,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.LowerRight
		};
		if (num > 0)
		{
			NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.PKJMLDMLFCM(num);
			if (jenmpdpjkbg != null)
			{
				guistyle.alignment = TextAnchor.UpperCenter;
				GUI.DrawTexture(new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 29f, ONPHLHKAGFP.OCHCODJIPHJ.y + 784f, 1430f, 877f), jenmpdpjkbg.BDHHPAEHFHG.KMIIGKECOEB());
				guistyle.fontStyle = FontStyle.Bold;
				string str = string.Format(JNBICAJIJMM.EKEBHIJMEML().FLEANFGEJML("turn_levels"), jenmpdpjkbg.JAGMEPMLCCP);
				if (jenmpdpjkbg.JAGMEPMLCCP == 0)
				{
					str = JNBICAJIJMM.IKGFHGKKCPG.ECNKLECOKHD("OfficeSittingReadingLeanBack");
				}
				if (jenmpdpjkbg.JAGMEPMLCCP == 3)
				{
					str = JNBICAJIJMM.APMJBBDBOJO().CCFFMKBBKHI("wgt_gr");
				}
				GUI.Label(new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 1523f, ONPHLHKAGFP.OCHCODJIPHJ.y + 423f, 1306f, 605f), jenmpdpjkbg.BDHHPAEHFHG.KKEBDLGHBMN + str, guistyle);
				guistyle.fontStyle = FontStyle.Bold;
				guistyle.fontSize = 108;
				guistyle.font = GuiProcessor.BBLINJLBAIL().rusfont;
				string text = jenmpdpjkbg.BDHHPAEHFHG.PAALJNAKJEG;
				int num2 = jenmpdpjkbg.JAGMEPMLCCP + 0;
				if (num2 > 2)
				{
					num2 = 5;
				}
				text = text.Replace("=", string.Concat(jenmpdpjkbg.BDHHPAEHFHG.DCCPCBLODIG.AIMCFAHLPEF() * (double)num2));
				text = text.Replace("Zombie Walk", string.Concat(jenmpdpjkbg.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num2));
				text = text.Replace("wpn_add/base", string.Concat(jenmpdpjkbg.BDHHPAEHFHG.DCCPCBLODIG.HDPNCIECLKP() * (double)num2));
				GUI.Label(new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 446f, ONPHLHKAGFP.OCHCODJIPHJ.y + 153f, 684f, 1568f), text, guistyle);
				this.NFGOLLEEHHK(new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 48f, ONPHLHKAGFP.OCHCODJIPHJ.y + 768f, ONPHLHKAGFP.OCHCODJIPHJ.width - 1501f, 563f), jenmpdpjkbg.KLPANBANBDI, (float)jenmpdpjkbg.GNNDLEAFCND, 1, string.Format("_ZWrite", Mathf.FloorToInt(jenmpdpjkbg.KLPANBANBDI), jenmpdpjkbg.GNNDLEAFCND), true);
				return;
			}
		}
		else
		{
			GUI.Label(ONPHLHKAGFP.OCHCODJIPHJ, JNBICAJIJMM.BDKHMOOFHHK("_ColorBuffer"), guistyle);
		}
	}

	// Token: 0x06004FAD RID: 20397 RVA: 0x00248ED3 File Offset: 0x002470D3
	public void OGLNLPMBNGN(ONKDCGNBALK OJIMHKHFOJI)
	{
		OJIMHKHFOJI.OCBAOFLJBGP.LMBPNFHKNGA();
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(52, this.OKFIFPBAAFG);
	}

	// Token: 0x06004FAE RID: 20398 RVA: 0x00248EF4 File Offset: 0x002470F4
	private void BCMNJILJHEL(ONKDCGNBALK JLEJDINFJOF, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 83,
			font = GuiProcessor.NKOEAPCIBKO().rusfont3,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperCenter
		};
		Color black = Color.black;
		if (mkieeeenama.NGABBHKOAHE.PMFFIFFCGNF() == mkieeeenama.CNOLCNDBLJE)
		{
			black = new Color(1891f, 1813f, 226f);
		}
		guistyle.normal.textColor = black;
		string text = string.Format(JNBICAJIJMM.DIOJFJMOPJO("SUNSHINE_FILTER_PCF_4x4"), mkieeeenama.NGABBHKOAHE.BNIHFBMEPAB, mkieeeenama.NGABBHKOAHE.CIDLLLNBLCN(mkieeeenama.CNOLCNDBLJE));
		Rect rect = new Rect(OCHCODJIPHJ.x + 1134f, OCHCODJIPHJ.y + 998f, OCHCODJIPHJ.width - 451f, 200f);
		GUI.Label(rect, text, guistyle);
		rect.y += 982f;
		rect.height = 879f;
		guistyle.alignment = TextAnchor.LowerCenter;
		guistyle.fontSize = -68;
		guistyle.fontStyle = FontStyle.Normal;
		guistyle.normal.textColor = Color.black;
		string text2 = string.Format("", mkieeeenama.GKCKHINIJPH, mkieeeenama.NGABBHKOAHE.LHJLMOEHGDG(mkieeeenama.CNOLCNDBLJE));
		if (mkieeeenama.NGABBHKOAHE.AFKAHEDIMOJ() == mkieeeenama.CNOLCNDBLJE)
		{
			text2 = JNBICAJIJMM.NGALDMFKMJH("knopje.wav");
		}
		else
		{
			this.NFGOLLEEHHK(rect, (float)mkieeeenama.GKCKHINIJPH, (float)mkieeeenama.NGABBHKOAHE.DOILPEMEOPD(mkieeeenama.CNOLCNDBLJE), 4, "", true);
		}
		GUI.Label(rect, text2, guistyle);
	}

	// Token: 0x06004FAF RID: 20399 RVA: 0x002490A5 File Offset: 0x002472A5
	public void FACEDOKJEPP(ONKDCGNBALK OJIMHKHFOJI)
	{
		OJIMHKHFOJI.OCBAOFLJBGP.LMBPNFHKNGA();
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(-36, this.OKFIFPBAAFG);
	}

	// Token: 0x06004FB0 RID: 20400 RVA: 0x002490C4 File Offset: 0x002472C4
	public void GEDNGIDHBHD()
	{
		Fisherman.getI.getBragCntrl.IHGJDIFCPBB();
		if (this.brgCntr != null)
		{
			UnityEngine.Object.Destroy(this.brgCntr.gameObject, 495f);
		}
		this.brgCntr = null;
	}

	// Token: 0x06004FB1 RID: 20401 RVA: 0x00249100 File Offset: 0x00247300
	private static void NCGJANCMLPO(JNHLAGHJBAA.FPAEEADMCIE KAOKEJPBAHM, XmlNodeList OPEKKKOEIKC)
	{
		foreach (object obj in OPEKKKOEIKC)
		{
			XmlNode xmlNode = (XmlNode)obj;
			if (xmlNode.Attributes != null)
			{
				int num = int.Parse(xmlNode.Attributes["_SecondTex"].Value);
				string value = xmlNode.Attributes["wgt="].Value;
				GameInterface.HPNMCNHFODM(KAOKEJPBAHM.IIBPHNMPPMA(value, (long)num), xmlNode.SelectNodes("CheckResources () for "));
			}
		}
	}

	// Token: 0x06004FB2 RID: 20402 RVA: 0x002491A4 File Offset: 0x002473A4
	private void JILOMAOKBDH(ONKDCGNBALK OCPJAEHJCNB)
	{
		this.LCMCOGOGHPL.LCELAFPJLMA(JNBICAJIJMM.CELEPPAEKAB("SoccerKeeperDiveStrafeFarRight"));
		long num = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.MHIIBKILGBL("fishcatch");
		string str = JNBICAJIJMM.LEBHCLDODNI("Sampling AO on ");
		if (num != 0L)
		{
			DateTime dateTime = DateTime.Now;
			bool flag = true;
			try
			{
				dateTime = DateTime.FromBinary(num) - TimeController.BOBNPEAEECC().deltaTime;
				if (dateTime > DateTime.Now)
				{
					flag = false;
				}
			}
			catch (Exception)
			{
				flag = true;
			}
			if (flag)
			{
				TimeSpan timeSpan = dateTime - DateTime.Now;
				str = string.Format("", timeSpan.Minutes, timeSpan.Seconds);
				this.FJOABFJFMEP.FNMCIACNOMH = false;
			}
			else
			{
				this.FJOABFJFMEP.FNMCIACNOMH = false;
			}
		}
		else
		{
			this.FJOABFJFMEP.FNMCIACNOMH = true;
		}
		LCOLJOPGDLL lcmcogoghpl = this.LCMCOGOGHPL;
		lcmcogoghpl.MFFGAOLFFLI(lcmcogoghpl.IJHCAOPJDND() + str);
	}

	// Token: 0x06004FB3 RID: 20403 RVA: 0x002492A4 File Offset: 0x002474A4
	private void BPOGJJEJJLB(ONKDCGNBALK OCPJAEHJCNB)
	{
		this.LCMCOGOGHPL.FPIHOPOCAHA = JNBICAJIJMM.LEBHCLDODNI("gi_tit_ch");
		long num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MHIIBKILGBL("titul_change");
		string str = JNBICAJIJMM.LEBHCLDODNI("gi_tit_chy");
		if (num != 0L)
		{
			DateTime dateTime = DateTime.Now;
			bool flag = false;
			try
			{
				dateTime = DateTime.FromBinary(num) - TimeController.IKGFHGKKCPG.deltaTime;
				if (dateTime > DateTime.Now)
				{
					flag = true;
				}
			}
			catch (Exception)
			{
				flag = false;
			}
			if (flag)
			{
				TimeSpan timeSpan = dateTime - DateTime.Now;
				str = string.Format("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
				this.FJOABFJFMEP.FNMCIACNOMH = false;
			}
			else
			{
				this.FJOABFJFMEP.FNMCIACNOMH = true;
			}
		}
		else
		{
			this.FJOABFJFMEP.FNMCIACNOMH = true;
		}
		LCOLJOPGDLL lcmcogoghpl = this.LCMCOGOGHPL;
		lcmcogoghpl.FPIHOPOCAHA += str;
	}

	// Token: 0x06004FB4 RID: 20404 RVA: 0x002493A4 File Offset: 0x002475A4
	private void GJMOACDCNPK(ONKDCGNBALK ONPHLHKAGFP)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MPNJKJKDMLK = ((KLIKIJOLPPJ)ONPHLHKAGFP).BGDFCHPMFAN();
	}

	// Token: 0x06004FB5 RID: 20405 RVA: 0x002493BB File Offset: 0x002475BB
	public void MAMCMELDAHB(int PPJJJAGNADB)
	{
		this.endShowFish();
	}

	// Token: 0x06004FB6 RID: 20406 RVA: 0x002493C4 File Offset: 0x002475C4
	public void LGHDGKMCEIE(ONKDCGNBALK PHEMLBHMNCM)
	{
		GUI.Box(PHEMLBHMNCM.OCHCODJIPHJ, "_ReflectionBlur");
		if (this.CODAIBGMFCA == null)
		{
			return;
		}
		AKPJIACDDFI.IKGFHGKKCPG.IPGEDMOPLPH(this.CODAIBGMFCA.NENOBDLCFHO);
		GUI.color = new Color(1647f, 326f, 1256f, 842f);
		GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1586f, PHEMLBHMNCM.OCHCODJIPHJ.y + 211f, 1362f, 622f), this.CODAIBGMFCA.HFAGADCJACL().MMKLLFCKCAG(), ScaleMode.StretchToFill);
		GUI.color = Color.white;
		GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y, 1991f, 1575f), this.CODAIBGMFCA.PDJBFPOAPBA().NIOGJOFLPLH(), ScaleMode.ScaleToFit);
		float num = PHEMLBHMNCM.OCHCODJIPHJ.y + 922f;
		if (this.CODAIBGMFCA.GEFOGEDMLJA)
		{
			GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width - 1745f - 1445f, num, 251f, 1225f), this.recIconTxtr, ScaleMode.ScaleAndCrop);
			num += 919f;
		}
		if (this.CODAIBGMFCA.GAAPCLGDOGH.NGKHOKIOGNO)
		{
			GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width - 73f - 1807f, num, 162f, 1742f), this.mutIconTxtr, ScaleMode.StretchToFill);
			num += 96f;
		}
		if (this.CODAIBGMFCA.JPFFCKENLHO)
		{
			GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width - 1577f - 85f, num, 1492f, 1225f), this.unicIconTxtr, ScaleMode.ScaleAndCrop);
			num += 382f;
		}
		string text = this.CODAIBGMFCA.ToString();
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperCenter,
			fontSize = -11,
			wordWrap = false,
			richText = true
		};
		float x = PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width - 1196f;
		float y = PHEMLBHMNCM.OCHCODJIPHJ.y + 1338f - 1691f;
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().IMCJNFHAFGE(this.CODAIBGMFCA.MIGBFMILDHD);
		if (befchfngomi != null)
		{
			befchfngomi.GDLELABHHFG(new Rect(x, y, 1113f, 1712f), befchfngomi.KBGHOIJIPJF, true, 1);
		}
		float num2 = PHEMLBHMNCM.OCHCODJIPHJ.height - 720f;
		if (this.CODAIBGMFCA.OLJEDIJMEOA.Count > 1)
		{
			guistyle.normal.textColor = new Color(1126f, 1829f, 171f);
			GUI.color = new Color(1418f, 1674f, 1980f);
			foreach (int ldlcflipofh in this.CODAIBGMFCA.OLJEDIJMEOA)
			{
				GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1172f, PHEMLBHMNCM.OCHCODJIPHJ.y + num2, 1251f, 638f), this.titulIcon2);
				GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 465f, PHEMLBHMNCM.OCHCODJIPHJ.y + num2, 65f, 1484f), AKPJIACDDFI.IKGFHGKKCPG.PKAJMDDDMMI(ldlcflipofh, false), guistyle);
				num2 -= 675f;
			}
			GUI.color = Color.white;
		}
		if (this.CODAIBGMFCA.KPGFFEIODJF.Count > 0)
		{
			guistyle.normal.textColor = new Color(9f, 126f, 1869f);
			GUI.color = new Color(1397f, 530f, 1609f);
			foreach (int num3 in this.CODAIBGMFCA.KPGFFEIODJF)
			{
				GUI.color = ((num3 == -61) ? new Color(249f, 912f, 1533f) : new Color(1711f, 598f, 1917f));
				GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 836f, PHEMLBHMNCM.OCHCODJIPHJ.y + num2, 1206f, 1026f), this.titulIcon2);
				GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 1975f, PHEMLBHMNCM.OCHCODJIPHJ.y + num2, 1441f, 1904f), AKPJIACDDFI.IKGFHGKKCPG.LNDAPLCMEJI(num3, true), guistyle);
				num2 -= 267f;
			}
			GUI.color = Color.white;
		}
		GUIStyle guistyle2 = new GUIStyle
		{
			normal = 
			{
				textColor = Color.white
			},
			alignment = TextAnchor.UpperCenter,
			fontSize = -43,
			wordWrap = true,
			richText = true
		};
		GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y + 451f, 1131f, 410f), text, guistyle2);
		guistyle2.fontSize = -71;
		guistyle2.normal.textColor = Color.black;
	}

	// Token: 0x06004FB7 RID: 20407 RVA: 0x00249988 File Offset: 0x00247B88
	private void BOPMLIJGLNN()
	{
		string dccpcblodig = string.Format(JNBICAJIJMM.LPHMKPDBMPP().HEIBEHAEHBM("\n"), this.DBELGCHKMOE.LACAJHOHACK.Count, this.holodFreeCell);
		if (this.DBELGCHKMOE.LACAJHOHACK.Count >= this.holodFreeCell)
		{
			dccpcblodig = string.Format(JNBICAJIJMM.LPHMKPDBMPP().CKAOHMEKLMH("wtype"), this.DBELGCHKMOE.LACAJHOHACK.Count, this.holodFreeCell);
		}
		this.CINAIMICJGM.AFOBLNNIEEJ(dccpcblodig);
	}

	// Token: 0x06004FB8 RID: 20408 RVA: 0x00249A24 File Offset: 0x00247C24
	private void NMOEPACMOHK()
	{
		string dccpcblodig = string.Format(JNBICAJIJMM.EKEBHIJMEML().HEIBEHAEHBM("LEFT"), this.DBELGCHKMOE.LACAJHOHACK.Count, this.holodFreeCell);
		if (this.DBELGCHKMOE.LACAJHOHACK.Count >= this.holodFreeCell)
		{
			dccpcblodig = string.Format(JNBICAJIJMM.CLIMNFDGOEG().ECNKLECOKHD("SneakIdle"), this.DBELGCHKMOE.LACAJHOHACK.Count, this.holodFreeCell);
		}
		this.CINAIMICJGM.HEGBCJBPHEH(dccpcblodig);
	}

	// Token: 0x06004FB9 RID: 20409 RVA: 0x00249AC0 File Offset: 0x00247CC0
	public void renderPBar(Rect OCHCODJIPHJ, float EBLHAJDINBH, float EJBJCJJMOPJ, int CLBPBJGLHEE, string JCKHDHGIEEB = "", bool IMOJBPPCJAM = false)
	{
		if (EBLHAJDINBH < 0f)
		{
			EBLHAJDINBH = 0f;
		}
		if (EBLHAJDINBH > EJBJCJJMOPJ)
		{
			EBLHAJDINBH = EJBJCJJMOPJ;
		}
		Rect position = new Rect(OCHCODJIPHJ.x - 2f, OCHCODJIPHJ.y, OCHCODJIPHJ.width + 4f, OCHCODJIPHJ.height);
		if (IMOJBPPCJAM)
		{
			GUIStyle style = GUI.skin.customStyles[0];
			GUI.Box(position, "", style);
		}
		if (EBLHAJDINBH > 0f)
		{
			float num = OCHCODJIPHJ.width * EBLHAJDINBH / EJBJCJJMOPJ;
			if (num > 2f)
			{
				GUI.DrawTextureWithTexCoords(new Rect(OCHCODJIPHJ.x - 1f, OCHCODJIPHJ.y, num + 2f, OCHCODJIPHJ.height), this.UserParamLines, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(CLBPBJGLHEE, 1, 7), true);
			}
		}
		if (JCKHDHGIEEB != "")
		{
			GUIStyle style2 = new GUIStyle
			{
				fontSize = 12,
				font = GuiProcessor.IKGFHGKKCPG.rusfont,
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleCenter
			};
			GUI.Label(OCHCODJIPHJ, JCKHDHGIEEB, style2);
		}
	}

	// Token: 0x06004FBA RID: 20410 RVA: 0x00249BD8 File Offset: 0x00247DD8
	public void IKCPMLOFKLP(HBPNMNGOFMA KADBECGIMPD)
	{
		Debug.Log("");
		List<ELCMHGJLFOL.FDEPADNCGIF> list = new List<ELCMHGJLFOL.FDEPADNCGIF>();
		KADBECGIMPD.LDLKLPJBIJN();
		KADBECGIMPD.AGNKAFLKCAG();
		while (!KADBECGIMPD.LILLHFLDMBH())
		{
			long num = KADBECGIMPD.DNIIFBAIPBE();
			ELCMHGJLFOL.FDEPADNCGIF fdepadncgif = ELCMHGJLFOL.IKGFHGKKCPG.GMPNBBLOHGF(num);
			if (fdepadncgif == null)
			{
				fdepadncgif = new ELCMHGJLFOL.FDEPADNCGIF(num);
				ELCMHGJLFOL.IKGFHGKKCPG.EBMDFEMAMMD(fdepadncgif);
			}
			fdepadncgif.KIALEELDFDJ(KADBECGIMPD);
			list.Add(fdepadncgif);
		}
		if (this.OFNLHPKLHGI != null)
		{
			UnityEngine.Object.Destroy(this.OFNLHPKLHGI);
		}
		this.OFNLHPKLHGI = JDCEFOFMGHB.IKGFHGKKCPG.DNMCIGCNBIM("INTERFACE");
		ArtAllWin component = this.OFNLHPKLHGI.GetComponent<ArtAllWin>();
		if (component != null)
		{
			foreach (ELCMHGJLFOL.FDEPADNCGIF jlfioojljod in list)
			{
				component.KDAPAIFNEAN(jlfioojljod);
			}
			component.myArtelBtn.interactable = false;
			component.createArtelBtn.interactable = true;
			component.applArtelBtn.interactable = false;
		}
	}

	// Token: 0x06004FBB RID: 20411 RVA: 0x00249CF0 File Offset: 0x00247EF0
	private void BHMKAOBHAII()
	{
		if (GameInterface.getI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		HPGKIJLKCIH.IKGFHGKKCPG.LLDLAHEGKJN();
		GameInterface.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		CKNLPGEPGGF.IKGFHGKKCPG.PINLMCCKKNA();
	}

	// Token: 0x06004FBC RID: 20412 RVA: 0x00249D30 File Offset: 0x00247F30
	private void AEPELGLCEHH(ONKDCGNBALK JMAKEAHMLMI, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		IDCHHHEDHDC.GIONPNFHOOC gionpnfhooc = (IDCHHHEDHDC.GIONPNFHOOC)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 16,
			font = GuiProcessor.IKGFHGKKCPG.rusfont3,
			fontStyle = FontStyle.Bold,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperLeft
		};
		float x = OCHCODJIPHJ.x + 15f;
		GUI.Label(new Rect(x, OCHCODJIPHJ.y + 2f, OCHCODJIPHJ.width, 22f), gionpnfhooc.BGJICMGFOON.HAJNMNALBBI + " " + JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)gionpnfhooc.GBOBJLNHPBI), guistyle);
		string text = string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_um_rec"), "", gionpnfhooc.MGILDBCKBON, gionpnfhooc.LLKDCEPNHOL);
		if (gionpnfhooc.GHGAHDMKJFE == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI)
		{
			guistyle.normal.textColor = new Color(0f, 0.3f, 0f);
		}
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		guistyle.fontSize = 14;
		guistyle.fontStyle = FontStyle.Normal;
		GUI.Label(new Rect(x, OCHCODJIPHJ.y + 25f, OCHCODJIPHJ.width, OCHCODJIPHJ.height - 30f), text, guistyle);
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(gionpnfhooc.GNCMJMOJAAK);
		befchfngomi.JIFFLPNBILE();
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 40f, OCHCODJIPHJ.y + 4f, 32f, 32f), befchfngomi.CFFHIODOGCH);
	}

	// Token: 0x06004FBD RID: 20413 RVA: 0x00249ED0 File Offset: 0x002480D0
	public void openReputationWindow(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GOJICKHNGEE.Count <= 0)
		{
			new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x, PHEMLBHMNCM.y, PHEMLBHMNCM.width, PHEMLBHMNCM.height, JNBICAJIJMM.LEBHCLDODNI("gi_frac_no"), TextAnchor.MiddleCenter, Color.black);
			return;
		}
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + 20f, PHEMLBHMNCM.width - 40f, PHEMLBHMNCM.height - 40f, 0)
		{
			JHNCNHAAJCH = 64f
		};
		mmkfaenbhkd.KPLMFNIFPMM = false;
		foreach (BHNDGIPPPCE.MKIEEEENAMA mkieeeenama in JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GOJICKHNGEE)
		{
			mkieeeenama.onRender = new ItemBase.OOALOMPKIKK(this.LLONJAFCLML);
			mmkfaenbhkd.LACAJHOHACK.Add(mkieeeenama);
		}
		mmkfaenbhkd.KCLLDJJLCGC = 12;
		mmkfaenbhkd.NBCAEJHKLMG();
		mmkfaenbhkd.IHEILFHMLAG = 0;
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
	}

	// Token: 0x06004FBE RID: 20414 RVA: 0x00249FFC File Offset: 0x002481FC
	public void SadokKeyPress(ONKDCGNBALK OJIMHKHFOJI)
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		this.endShowFish();
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		long num = odfekbjcfmn - 1L;
		if (num > 19L)
		{
			return;
		}
		switch ((uint)num)
		{
		case 0U:
			this.currentSadokId = 0;
			this.CODAIBGMFCA = null;
			this.openSadok(this.currentSadokId, false);
			this.rembtn.FNMCIACNOMH = this.IPNACPKIELJ();
			return;
		case 1U:
			this.currentSadokId = 1;
			this.CODAIBGMFCA = null;
			this.openSadok(this.currentSadokId, false);
			this.rembtn.FNMCIACNOMH = this.IPNACPKIELJ();
			return;
		case 2U:
			if (this.CODAIBGMFCA != null && this.CODAIBGMFCA.HGCCAHPEFGO == 0)
			{
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(176, this.CODAIBGMFCA.LPFKFNLHGBI);
				this.CODAIBGMFCA.HGCCAHPEFGO = 1;
				kfhelhglnmh.NAFGMKJPLPC.Remove(this.CODAIBGMFCA);
				kfhelhglnmh.KNFMGIBLMHB.Add(this.CODAIBGMFCA);
				FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(Fisherman.getI.transform.position, 0.3f);
				int num2 = this.OJJLLBKEGNO.IHEILFHMLAG;
				this.OJJLLBKEGNO.LACAJHOHACK.Remove(this.CODAIBGMFCA);
				if (num2 >= this.OJJLLBKEGNO.LACAJHOHACK.Count)
				{
					num2 = this.OJJLLBKEGNO.LACAJHOHACK.Count - 1;
				}
				this.OJJLLBKEGNO.IHEILFHMLAG = num2;
				this.OJJLLBKEGNO.MPMFNJEJAHJ();
				this.AFEHNJCCJAF();
				FlyMessageManager.getI.clearMessages();
				return;
			}
			break;
		case 3U:
			if (this.CODAIBGMFCA != null && this.CODAIBGMFCA.HGCCAHPEFGO == 1)
			{
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(177, this.CODAIBGMFCA.LPFKFNLHGBI);
				this.CODAIBGMFCA.HGCCAHPEFGO = 0;
				FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(Fisherman.getI.transform.position, 0.3f);
				kfhelhglnmh.KNFMGIBLMHB.Remove(this.CODAIBGMFCA);
				kfhelhglnmh.NAFGMKJPLPC.Add(this.CODAIBGMFCA);
				int num3 = this.OJJLLBKEGNO.IHEILFHMLAG;
				this.OJJLLBKEGNO.LACAJHOHACK.Remove(this.CODAIBGMFCA);
				if (num3 >= this.OJJLLBKEGNO.LACAJHOHACK.Count)
				{
					num3 = this.OJJLLBKEGNO.LACAJHOHACK.Count - 1;
				}
				this.OJJLLBKEGNO.IHEILFHMLAG = num3;
				this.OJJLLBKEGNO.MPMFNJEJAHJ();
				this.AFEHNJCCJAF();
				FlyMessageManager.getI.clearMessages();
				return;
			}
			break;
		case 4U:
		case 5U:
		case 6U:
		case 7U:
		case 8U:
		case 9U:
		case 16U:
		case 17U:
		case 18U:
			break;
		case 10U:
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(285, 0);
			FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(Fisherman.getI.transform.position + Fisherman.getI.transform.forward * 3f, 0.3f);
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
			return;
		case 11U:
			if (this.CODAIBGMFCA != null)
			{
				this.releaseFromSadok();
				return;
			}
			break;
		case 12U:
			this.releaseFish(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
			return;
		case 13U:
			this.getFish(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI, false);
			return;
		case 14U:
			if (this.CODAIBGMFCA != null)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_FullItem.wav", 0.7f);
				OJIMHKHFOJI.FNMCIACNOMH = false;
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1002, this.CODAIBGMFCA.LPFKFNLHGBI);
				this.getFish(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI, false);
				JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
				return;
			}
			break;
		case 15U:
			if (this.CODAIBGMFCA != null)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_FullItem.wav", 0.7f);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1002, this.CODAIBGMFCA.LPFKFNLHGBI);
				OJIMHKHFOJI.FNMCIACNOMH = false;
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1002, this.CODAIBGMFCA.LPFKFNLHGBI);
				JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
				return;
			}
			break;
		case 19U:
			this.getFish(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI, true);
			break;
		default:
			return;
		}
	}

	// Token: 0x06004FBF RID: 20415 RVA: 0x0024A448 File Offset: 0x00248648
	private void OAGIEPJBMPH()
	{
		string dccpcblodig = string.Format(JNBICAJIJMM.IKGFHGKKCPG.ECNKLECOKHD("ShotgunFire"), this.DBELGCHKMOE.LACAJHOHACK.Count, this.holodFreeCell);
		if (this.DBELGCHKMOE.LACAJHOHACK.Count >= this.holodFreeCell)
		{
			dccpcblodig = string.Format(JNBICAJIJMM.IKGFHGKKCPG.CCFFMKBBKHI("[fish]"), this.DBELGCHKMOE.LACAJHOHACK.Count, this.holodFreeCell);
		}
		this.CINAIMICJGM.IGELPAEBJLM(dccpcblodig);
	}

	// Token: 0x06004FC0 RID: 20416 RVA: 0x0024A4E4 File Offset: 0x002486E4
	public void ANLHLPBBPPI(ONKDCGNBALK OJIMHKHFOJI)
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		this.endShowFish();
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		long num = odfekbjcfmn - 1L;
		if (num > -115L)
		{
			return;
		}
		switch ((uint)num)
		{
		case 0U:
			this.currentSadokId = 0;
			this.CODAIBGMFCA = null;
			this.ABBDLICDJEK(this.currentSadokId, false);
			this.rembtn.FNMCIACNOMH = this.CFJKPHECOKH();
			return;
		case 1U:
			this.currentSadokId = 0;
			this.CODAIBGMFCA = null;
			this.openSadok(this.currentSadokId, true);
			this.rembtn.FNMCIACNOMH = this.CFJKPHECOKH();
			return;
		case 2U:
			if (this.CODAIBGMFCA != null && this.CODAIBGMFCA.HGCCAHPEFGO == 0)
			{
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(80, this.CODAIBGMFCA.LPFKFNLHGBI);
				this.CODAIBGMFCA.HGCCAHPEFGO = 0;
				kfhelhglnmh.NAFGMKJPLPC.Remove(this.CODAIBGMFCA);
				kfhelhglnmh.KNFMGIBLMHB.Add(this.CODAIBGMFCA);
				FBFJFAKAGJG.IKGFHGKKCPG.PLKKECPNMEB(Fisherman.getI.transform.position, 858f);
				int num2 = this.OJJLLBKEGNO.OEAGLNMGGDI();
				this.OJJLLBKEGNO.LACAJHOHACK.Remove(this.CODAIBGMFCA);
				if (num2 >= this.OJJLLBKEGNO.LACAJHOHACK.Count)
				{
					num2 = this.OJJLLBKEGNO.LACAJHOHACK.Count - 1;
				}
				this.OJJLLBKEGNO.BJLCAGOJDNM(num2);
				this.OJJLLBKEGNO.BEHAGGLKAJH();
				this.ACKCODOIBCL();
				FlyMessageManager.getI.IDNGBKFPNDJ();
				return;
			}
			break;
		case 3U:
			if (this.CODAIBGMFCA != null && this.CODAIBGMFCA.HGCCAHPEFGO == 0)
			{
				NJMHLCGIAJI.IKGFHGKKCPG.MADKBBLOPGO(174, this.CODAIBGMFCA.LPFKFNLHGBI);
				this.CODAIBGMFCA.HGCCAHPEFGO = 0;
				FBFJFAKAGJG.IKGFHGKKCPG.AMDLJMNDALF(Fisherman.getI.transform.position, 62f);
				kfhelhglnmh.KNFMGIBLMHB.Remove(this.CODAIBGMFCA);
				kfhelhglnmh.NAFGMKJPLPC.Add(this.CODAIBGMFCA);
				int num3 = this.OJJLLBKEGNO.HHJKOIJGNAK();
				this.OJJLLBKEGNO.LACAJHOHACK.Remove(this.CODAIBGMFCA);
				if (num3 >= this.OJJLLBKEGNO.LACAJHOHACK.Count)
				{
					num3 = this.OJJLLBKEGNO.LACAJHOHACK.Count - 0;
				}
				this.OJJLLBKEGNO.GFCKPJCIPEO(num3);
				this.OJJLLBKEGNO.GLNLJMIMHBH();
				this.HPICBMCMAEC();
				FlyMessageManager.getI.IDNGBKFPNDJ();
				return;
			}
			break;
		case 4U:
		case 5U:
		case 6U:
		case 7U:
		case 8U:
		case 9U:
		case 16U:
		case 17U:
		case 18U:
			break;
		case 10U:
			NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(155, 0);
			FBFJFAKAGJG.IKGFHGKKCPG.LLABHALMBDG(Fisherman.getI.transform.position + Fisherman.getI.transform.forward * 603f, 1238f);
			JDCEFOFMGHB.JFIDAGABKID().BMOFIBGMIBK(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
			return;
		case 11U:
			if (this.CODAIBGMFCA != null)
			{
				this.GKBCONBIMIN();
				return;
			}
			break;
		case 12U:
			this.POPLGGDCGAD(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
			return;
		case 13U:
			this.EFBAFHBCIDA(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI, true);
			return;
		case 14U:
			if (this.CODAIBGMFCA != null)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("bool: ", 268f);
				OJIMHKHFOJI.FNMCIACNOMH = false;
				NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(17, this.CODAIBGMFCA.LPFKFNLHGBI);
				this.getFish(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI, false);
				JDCEFOFMGHB.JFIDAGABKID().BMOFIBGMIBK(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
				return;
			}
			break;
		case 15U:
			if (this.CODAIBGMFCA != null)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("FOG_POINT_LIGHT", 790f);
				NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(15, this.CODAIBGMFCA.LPFKFNLHGBI);
				OJIMHKHFOJI.FNMCIACNOMH = false;
				NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(192, this.CODAIBGMFCA.LPFKFNLHGBI);
				JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
				return;
			}
			break;
		case 19U:
			this.EFBAFHBCIDA(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI, false);
			break;
		default:
			return;
		}
	}

	// Token: 0x06004FC1 RID: 20417 RVA: 0x0024A930 File Offset: 0x00248B30
	private void KJPBMHACAFG(ONKDCGNBALK ONPHLHKAGFP)
	{
		OIJEGJLCFCF dolfjggbdjf = this.DOLFJGGBDJF;
		if (dolfjggbdjf == null)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC.Add(dolfjggbdjf);
			this.DBELGCHKMOE.LACAJHOHACK.Remove(dolfjggbdjf);
			this.DBELGCHKMOE.MPMFNJEJAHJ();
			this.OJJLLBKEGNO.LACAJHOHACK.Add(dolfjggbdjf);
			this.OJJLLBKEGNO.MPMFNJEJAHJ();
			epmphjgalbe.GOMLLPFFPNP(this.currentHolodId);
			epmphjgalbe.OBCCLNMPGEJ(dolfjggbdjf.LPFKFNLHGBI);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(168, epmphjgalbe.JDPHBLHOLAD());
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_07.wav", 1f);
			this.AFEHNJCCJAF();
			this.FFOKGLLHNPF();
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x06004FC2 RID: 20418 RVA: 0x0024AA04 File Offset: 0x00248C04
	public void NKCDHAELGJK(ONKDCGNBALK JMBKDINHDLO)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(true);
		NJMHLCGIAJI.EAJGHMMBAFP().AMEOMLNLOGF(103, "signal_enable");
	}

	// Token: 0x06004FC3 RID: 20419 RVA: 0x0024AA24 File Offset: 0x00248C24
	private void AFEHNJCCJAF()
	{
		string dccpcblodig = "";
		bool flag = true;
		EKBAPCMPANI ekbapcmpani = BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH;
		List<OIJEGJLCFCF> list = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC;
		if (this.currentSadokId == 1)
		{
			ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(60, 8);
			list = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KNFMGIBLMHB;
		}
		int num = 0;
		foreach (OIJEGJLCFCF oijegjlcfcf in list)
		{
			num += oijegjlcfcf.NKHBAJKMAGD;
		}
		if (ekbapcmpani != null && list.Count <= ekbapcmpani.MIMANMPNLPE.ICJDPPOJINN && num <= ekbapcmpani.MIMANMPNLPE.IBEIBAHKIAH)
		{
			flag = false;
			dccpcblodig = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_sadok"), new object[]
			{
				list.Count,
				ekbapcmpani.MIMANMPNLPE.ICJDPPOJINN,
				JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)num),
				JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)ekbapcmpani.MIMANMPNLPE.IBEIBAHKIAH)
			});
		}
		if (flag)
		{
			dccpcblodig = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_sadokfull"), list.Count, JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)num));
		}
		this.BLKAFFPKEBA = flag;
		if (ekbapcmpani == null)
		{
			dccpcblodig = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_sadoknone");
		}
		this.OHIPOCGKHDE.FPIHOPOCAHA = dccpcblodig;
	}

	// Token: 0x06004FC4 RID: 20420 RVA: 0x0024ABAC File Offset: 0x00248DAC
	public void endShowFish()
	{
		Fisherman.getI.getBragCntrl.HEJDOBFKEHG();
		if (this.brgCntr != null)
		{
			UnityEngine.Object.Destroy(this.brgCntr.gameObject, 0.5f);
		}
		this.brgCntr = null;
	}

	// Token: 0x06004FC5 RID: 20421 RVA: 0x0024ABE8 File Offset: 0x00248DE8
	private void AICEFGKCNII(ONKDCGNBALK OCPJAEHJCNB)
	{
		this.LCMCOGOGHPL.FPIHOPOCAHA = JNBICAJIJMM.LEBHCLDODNI("Root");
		long num = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BIHLDHKHPKE("inv_dur");
		string str = JNBICAJIJMM.LEBHCLDODNI("WeaponStrafeRunRight");
		if (num != 0L)
		{
			DateTime dateTime = DateTime.Now;
			bool flag = true;
			try
			{
				dateTime = DateTime.FromBinary(num) - TimeController.EKEBHIJMEML().deltaTime;
				if (dateTime > DateTime.Now)
				{
					flag = true;
				}
			}
			catch (Exception)
			{
				flag = false;
			}
			if (flag)
			{
				TimeSpan timeSpan = dateTime - DateTime.Now;
				str = string.Format("_HitPointTexture", timeSpan.Minutes, timeSpan.Seconds);
				this.FJOABFJFMEP.FNMCIACNOMH = false;
			}
			else
			{
				this.FJOABFJFMEP.FNMCIACNOMH = false;
			}
		}
		else
		{
			this.FJOABFJFMEP.FNMCIACNOMH = false;
		}
		LCOLJOPGDLL lcmcogoghpl = this.LCMCOGOGHPL;
		lcmcogoghpl.DJMCGBJDIIJ(lcmcogoghpl.EBFMOIKLDBO() + str);
	}

	// Token: 0x06004FC6 RID: 20422 RVA: 0x0024ACE8 File Offset: 0x00248EE8
	private bool IPNACPKIELJ()
	{
		EKBAPCMPANI ekbapcmpani = BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH;
		List<OIJEGJLCFCF> list = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC;
		if (this.currentSadokId == 0)
		{
			ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(60, 8);
			list = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KNFMGIBLMHB;
		}
		if (MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(60, 8) == null || BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null)
		{
			return false;
		}
		int num = 0;
		foreach (OIJEGJLCFCF oijegjlcfcf in list)
		{
			num += oijegjlcfcf.NKHBAJKMAGD;
		}
		if (this.CODAIBGMFCA != null)
		{
			num += this.CODAIBGMFCA.NKHBAJKMAGD;
		}
		bool result = false;
		if (ekbapcmpani != null && list.Count < ekbapcmpani.MIMANMPNLPE.ICJDPPOJINN && num <= ekbapcmpani.MIMANMPNLPE.IBEIBAHKIAH)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06004FC7 RID: 20423 RVA: 0x0024ADDC File Offset: 0x00248FDC
	public void FKLEDJOGPEF(int HGCCAHPEFGO = 0, bool HAEEEHGKFMG = false)
	{
		this.currentSadokId = HGCCAHPEFGO;
		int count = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.NAFGMKJPLPC.Count;
		if (HAEEEHGKFMG && this.sadokWinId > 1 && JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(this.sadokWinId) != null)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BMOFIBGMIBK(this.sadokWinId);
			return;
		}
		if (this.sadokWinId > 0)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().CBHHEHHNFKL(this.sadokWinId);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.IHNMOJHBMNJ(this.sadokWinId);
		if (onkdcgnbalk == null)
		{
			onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().PJHMHBAGFAN(1003f, 902f, JNBICAJIJMM.EKEBHIJMEML().NLJOLOBPCBJ("gi_tit_ch"), false);
		}
		else
		{
			onkdcgnbalk.MPKCOJHJIIB();
		}
		this.sadokWinId = onkdcgnbalk.LPFKFNLHGBI;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 979f, onkdcgnbalk.OCHCODJIPHJ.height - 299f, 34f, 41f, JNBICAJIJMM.EDKGBBIIBBC().ECNKLECOKHD("_History1ChromaTex"), 5, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().AGIEGPEMGOA));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 64f - 917f, onkdcgnbalk.OCHCODJIPHJ.height - 25f, 1735f, 1213f, JNBICAJIJMM.LPHMKPDBMPP().CCFFMKBBKHI("Hidden/Amplify Color/DepthMaskBlend"), 55, null, new ONKDCGNBALK.CMMHGMILOIM(this.OCLOCNNOGLK));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 1770f - 1091f, onkdcgnbalk.OCHCODJIPHJ.height - 1659f, 1577f, 1041f, JNBICAJIJMM.DBMJJPBOPEK().CKAOHMEKLMH(""), -36, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress));
		Rect ochcodjiphj = new Rect(1441f, 666f, 52f, onkdcgnbalk.OCHCODJIPHJ.height - 1282f);
		new MGLHIBHDMPC(onkdcgnbalk, ochcodjiphj, this.PaperTexture);
		this.OJJLLBKEGNO = new MMKFAENBHKD(onkdcgnbalk, ochcodjiphj.x, ochcodjiphj.y, ochcodjiphj.width, ochcodjiphj.height, 1);
		new KLIKIJOLPPJ(onkdcgnbalk, this.OJJLLBKEGNO.OCHCODJIPHJ.x, onkdcgnbalk.OCHCODJIPHJ.height - 801f, JNBICAJIJMM.EEOPOHEALPK().GNKIBMGNHNE(""), 0, HPGKIJLKCIH.IKGFHGKKCPG.MPNJKJKDMLK).LJIEPIPIAJC = new ONKDCGNBALK.CMMHGMILOIM(this.GGGJBMICKIJ);
		List<OIJEGJLCFCF> list = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.NAFGMKJPLPC;
		if (this.currentSadokId == 1)
		{
			list = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.KNFMGIBLMHB;
		}
		foreach (OIJEGJLCFCF oijegjlcfcf in list)
		{
			if (oijegjlcfcf.HGCCAHPEFGO == this.currentSadokId)
			{
				this.OJJLLBKEGNO.LACAJHOHACK.Add(oijegjlcfcf);
			}
		}
		ochcodjiphj = new Rect(1885f, 1431f, 1817f, 1692f);
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 1)
		{
			new MGLHIBHDMPC(onkdcgnbalk, ochcodjiphj, this.sadokImage);
			new EGCAADAABPP(onkdcgnbalk, ochcodjiphj.x, ochcodjiphj.y, ochcodjiphj.width, ochcodjiphj.height, "aa=", 0, null).NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.sadokPanelRender);
		}
		new LCOLJOPGDLL(onkdcgnbalk, ochcodjiphj.x + 1151f, ochcodjiphj.y + 621f, JNBICAJIJMM.LPHMKPDBMPP().CKAOHMEKLMH("_FogDistance"), true);
		new MEMEOHJKPNJ(onkdcgnbalk, ochcodjiphj.x + 533f, ochcodjiphj.y + 1465f, 889f, 1497f, "&", 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.OCLOCNNOGLK)).FNMCIACNOMH = (this.currentSadokId == 0);
		new MEMEOHJKPNJ(onkdcgnbalk, ochcodjiphj.x + 662f + 45f, ochcodjiphj.y + 1429f, 1152f, 1961f, "Giant 3 Hit Combo", 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.OCLOCNNOGLK)).FNMCIACNOMH = (this.currentSadokId == 0);
		bool fnmciacnomh = this.PJHMFEOOIPN();
		if (this.currentSadokId == 0)
		{
			this.rembtn = new MEMEOHJKPNJ(onkdcgnbalk, ochcodjiphj.x + 313f, ochcodjiphj.y + 246f, 752f, 870f, "error.wav", 2, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress))
			{
				FNMCIACNOMH = fnmciacnomh
			};
		}
		if (this.currentSadokId == 1)
		{
			this.rembtn = new MEMEOHJKPNJ(onkdcgnbalk, ochcodjiphj.x + 1762f, ochcodjiphj.y + 139f, 303f, 1395f, "CrouchWalkBackward", 6, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress))
			{
				FNMCIACNOMH = fnmciacnomh
			};
		}
		this.OJJLLBKEGNO.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.HDKBPHFLCNG);
		this.OJJLLBKEGNO.DBJBAELCFHI(this.OJJLLBKEGNO.LACAJHOHACK.Count - 1);
		this.OJJLLBKEGNO.MPMFNJEJAHJ();
		if (this.CODAIBGMFCA == null || this.OJJLLBKEGNO.BMOEEJCBDJO() < 1)
		{
			this.rembtn.FNMCIACNOMH = false;
		}
		this.OHIPOCGKHDE = new LCOLJOPGDLL(onkdcgnbalk, 955f, 1527f, 1707f, 191f, "ObscuredVector3 vs Vector3, ", TextAnchor.UpperCenter, Color.black)
		{
			LNDPBNODFPE = false
		};
		this.DOAEGLOBFCD();
	}

	// Token: 0x06004FC8 RID: 20424 RVA: 0x0024B360 File Offset: 0x00249560
	public void EDMHOBLPKLK(ONKDCGNBALK OJIMHKHFOJI)
	{
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		if (odfekbjcfmn != 0L)
		{
			if (odfekbjcfmn != 4L)
			{
				return;
			}
			this.ACKCODOIBCL();
			if (this.BLKAFFPKEBA)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("wpn_rod4", 662f);
				return;
			}
			if (FlyMessageManager.getI.DJCGACFIOEJ(-104))
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("_Params2", 321f);
				return;
			}
			if (this.DBELGCHKMOE.HHJKOIJGNAK() < 1)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("MotorbikeSuperman", 1773f);
				return;
			}
			if (this.DBELGCHKMOE.LACAJHOHACK.Count > 0)
			{
				OIJEGJLCFCF oijegjlcfcf = (OIJEGJLCFCF)this.DBELGCHKMOE.LACAJHOHACK[this.DBELGCHKMOE.IHEILFHMLAG];
				oijegjlcfcf.HGCCAHPEFGO = 1;
				this.DOLFJGGBDJF = oijegjlcfcf;
				JDCEFOFMGHB.HMJJPNDEKPP().DKJMCKOJOPF(192f, 0, "OneHandSwordBackSwing", new ONKDCGNBALK.CMMHGMILOIM(this.EBKBNILDMGG), false);
				return;
			}
			FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("crft_to", 332f);
			return;
		}
		else
		{
			if (this.DBELGCHKMOE.LACAJHOHACK.Count >= this.holodFreeCell)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB(" ", 1823f);
				return;
			}
			if (this.OJJLLBKEGNO.OEAGLNMGGDI() < 1)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("Clear reference not set.", 434f);
				return;
			}
			if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 1)
			{
				OIJEGJLCFCF dolfjggbdjf = (OIJEGJLCFCF)this.OJJLLBKEGNO.LACAJHOHACK[this.OJJLLBKEGNO.BMOEEJCBDJO()];
				this.DOLFJGGBDJF = dolfjggbdjf;
				JDCEFOFMGHB.HMJJPNDEKPP().NOIEEEIONNG(1614f, 1, "SkateForward", new ONKDCGNBALK.CMMHGMILOIM(this.HOPKKKFFGEN), true);
				return;
			}
			FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("_WaterLevel", 243f);
			return;
		}
	}

	// Token: 0x06004FC9 RID: 20425 RVA: 0x0024B528 File Offset: 0x00249728
	private void IBLNNMGJHGC()
	{
		string dccpcblodig = string.Format(JNBICAJIJMM.LPHMKPDBMPP().CKAOHMEKLMH("post_4"), this.DBELGCHKMOE.LACAJHOHACK.Count, this.holodFreeCell);
		if (this.DBELGCHKMOE.LACAJHOHACK.Count >= this.holodFreeCell)
		{
			dccpcblodig = string.Format(JNBICAJIJMM.IMLLGEMPHAP().HLBAJBLHLNI("Money: "), this.DBELGCHKMOE.LACAJHOHACK.Count, this.holodFreeCell);
		}
		this.CINAIMICJGM.HEGBCJBPHEH(dccpcblodig);
	}

	// Token: 0x06004FCA RID: 20426 RVA: 0x0024B5C4 File Offset: 0x002497C4
	public void BCMGNIDDMOP(ONKDCGNBALK JMAKEAHMLMI)
	{
		if (Input.GetKey((KeyCode)(-44)) && !this.BLKAFFPKEBA)
		{
			this.endShowFish();
			this.EFBAFHBCIDA(JMAKEAHMLMI.LPFKFNLHGBI, true);
		}
		if (Input.GetKey(KeyCode.G))
		{
			this.GEDNGIDHBHD();
			this.POPLGGDCGAD(JMAKEAHMLMI.LPFKFNLHGBI);
		}
	}

	// Token: 0x06004FCB RID: 20427 RVA: 0x0024B610 File Offset: 0x00249810
	private void IDMCOLDDNCF()
	{
		if (Input.GetKeyDown(KeyCode.X) && JDCEFOFMGHB.HMJJPNDEKPP().IHNMOJHBMNJ(this.sadokWinId) != null && this.CODAIBGMFCA != null)
		{
			this.KNKAEHIGNPI();
		}
	}

	// Token: 0x06004FCC RID: 20428 RVA: 0x0024B63C File Offset: 0x0024983C
	public void DLOFCKFIEMM(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		JNHLAGHJBAA jnhlaghjbaa = new JNHLAGHJBAA(JMAKEAHMLMI, PHEMLBHMNCM.x + 1994f, PHEMLBHMNCM.y + 1186f, PHEMLBHMNCM.width - 132f, PHEMLBHMNCM.height - 838f, 0)
		{
			JHNCNHAAJCH = 599f,
			KCLLDJJLCGC = -68
		};
		jnhlaghjbaa.GIOGEHKMKDE = false;
		jnhlaghjbaa.JKAOKBNCDFK = Color.black;
		jnhlaghjbaa.ABMDIOIJALO = new Color(1799f, 1245f, 1565f);
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.APMJBBDBOJO().DDKLHGHBEIG("B", true));
		GameInterface.OFJODEMEDIL(jnhlaghjbaa.EELDHNFBFOE, xmlDocument.SelectNodes("inv_minreq"));
		while (!KADBECGIMPD.BKIBKLFCCGP())
		{
			int lpfkfnlhgbi = KADBECGIMPD.HHLDBAEFNMJ();
			NHCAOFIKNFE.IOPMLIFDBKO iopmlifdbko = NHCAOFIKNFE.IKGFHGKKCPG.HPDBDCJGJOP(lpfkfnlhgbi);
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = jnhlaghjbaa.MJMOMMKECMF((long)iopmlifdbko.GCLKLEIMABA);
			if (fpaeeadmcie != null)
			{
				fpaeeadmcie.BKDIIPFBIDK(iopmlifdbko, (long)iopmlifdbko.JFHBDBHIOII);
			}
			else
			{
				jnhlaghjbaa.EELDHNFBFOE.NEGLEBJHNOL(iopmlifdbko, (long)iopmlifdbko.JFHBDBHIOII);
			}
		}
		jnhlaghjbaa.HAEOLOLPLCF();
		jnhlaghjbaa.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.AEMFAOIFNCO);
		Rect rect = new Rect(jnhlaghjbaa.OCHCODJIPHJ.x - 13f, jnhlaghjbaa.OCHCODJIPHJ.y + jnhlaghjbaa.OCHCODJIPHJ.height + 380f, jnhlaghjbaa.OCHCODJIPHJ.width + 435f, 837f);
		new EGCAADAABPP(JMAKEAHMLMI, rect.x, rect.y, rect.width, rect.height, "The root node, the left thigh and the right thigh bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left thigh and the right thigh bones. This might cause unwanted behaviour like the hip turning upside down when pulled by an effector.Please set the root node bone to be one of the higher bones in the spine.", 0, this.simpleGray);
		this.LCMCOGOGHPL = new LCOLJOPGDLL(JMAKEAHMLMI, rect.x + 113f, rect.y + 94f, rect.width, rect.height / 1696f, "noresult", TextAnchor.UpperLeft, new Color(460f, 1137f, 1979f))
		{
			DFIGKKMMIAF = -127
		};
		this.LCMCOGOGHPL.NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.AICEFGKCNII);
		this.IKFFNBOCGFL = new LCOLJOPGDLL(JMAKEAHMLMI, rect.x + 1676f, rect.y + 1279f, rect.width, rect.height - 1391f, "wpn_eat4", TextAnchor.UpperLeft, Color.white)
		{
			LNDPBNODFPE = false,
			DFIGKKMMIAF = -39
		};
		this.OKFIFPBAAFG = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.HKHMIIEIFNG;
		jnhlaghjbaa.MDINCCGBKID(jnhlaghjbaa.LBENJPLPLHK((long)JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HKHMIIEIFNG));
		this.FJOABFJFMEP = new MEMEOHJKPNJ(JMAKEAHMLMI, rect.x + rect.width - 1254f, rect.y + rect.height - 1490f, 188f, 1255f, JNBICAJIJMM.DCEBAJIILPC("SoccerKeeperReady"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.EIELHICJKHO));
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(true);
	}

	// Token: 0x06004FCD RID: 20429 RVA: 0x0024B940 File Offset: 0x00249B40
	public void MKEFMOADNMD(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		JNHLAGHJBAA jnhlaghjbaa = new JNHLAGHJBAA(JMAKEAHMLMI, PHEMLBHMNCM.x + 1926f, PHEMLBHMNCM.y + 1787f, PHEMLBHMNCM.width - 817f, PHEMLBHMNCM.height - 1051f, 0)
		{
			JHNCNHAAJCH = 1811f,
			KCLLDJJLCGC = 75
		};
		jnhlaghjbaa.GIOGEHKMKDE = false;
		jnhlaghjbaa.JKAOKBNCDFK = Color.black;
		jnhlaghjbaa.ABMDIOIJALO = new Color(791f, 1004f, 368f);
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.IMLLGEMPHAP().GIGGIHMAPLH("CrawlIdle", false));
		GameInterface.HPNMCNHFODM(jnhlaghjbaa.EELDHNFBFOE, xmlDocument.SelectNodes("WandAttack"));
		while (!KADBECGIMPD.PPAHBNGECGH())
		{
			int lpfkfnlhgbi = KADBECGIMPD.CLPEKGGAMAI();
			NHCAOFIKNFE.IOPMLIFDBKO iopmlifdbko = NHCAOFIKNFE.IKGFHGKKCPG.JOAMONKNOMK(lpfkfnlhgbi);
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = jnhlaghjbaa.KNILKDJMDHO((long)iopmlifdbko.GCLKLEIMABA);
			if (fpaeeadmcie != null)
			{
				fpaeeadmcie.PHEMMGABEKG(iopmlifdbko, (long)iopmlifdbko.JFHBDBHIOII);
			}
			else
			{
				jnhlaghjbaa.EELDHNFBFOE.HPGJHBANKPJ(iopmlifdbko, (long)iopmlifdbko.JFHBDBHIOII);
			}
		}
		jnhlaghjbaa.PCNHIOCHPPM();
		jnhlaghjbaa.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.MDFHBNBMKOP);
		Rect rect = new Rect(jnhlaghjbaa.OCHCODJIPHJ.x - 1659f, jnhlaghjbaa.OCHCODJIPHJ.y + jnhlaghjbaa.OCHCODJIPHJ.height + 1974f, jnhlaghjbaa.OCHCODJIPHJ.width + 1266f, 1761f);
		new EGCAADAABPP(JMAKEAHMLMI, rect.x, rect.y, rect.width, rect.height, " x", 0, this.simpleGray);
		this.LCMCOGOGHPL = new LCOLJOPGDLL(JMAKEAHMLMI, rect.x + 170f, rect.y + 1273f, rect.width, rect.height / 1703f, " ", TextAnchor.UpperLeft, new Color(1230f, 1492f, 723f))
		{
			DFIGKKMMIAF = 32
		};
		this.LCMCOGOGHPL.NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.AKFCJJIEAAK);
		this.IKFFNBOCGFL = new LCOLJOPGDLL(JMAKEAHMLMI, rect.x + 1139f, rect.y + 1924f, rect.width, rect.height - 367f, "Flap_04.wav", TextAnchor.UpperLeft, Color.white)
		{
			LNDPBNODFPE = true,
			DFIGKKMMIAF = -51
		};
		this.OKFIFPBAAFG = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.HKHMIIEIFNG;
		jnhlaghjbaa.HNNJNDNOHLP = jnhlaghjbaa.KNILKDJMDHO((long)JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.HKHMIIEIFNG);
		this.FJOABFJFMEP = new MEMEOHJKPNJ(JMAKEAHMLMI, rect.x + rect.width - 1359f, rect.y + rect.height - 1760f, 34f, 1166f, JNBICAJIJMM.LEBHCLDODNI(" "), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.titulKeyPress));
		JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(true);
	}

	// Token: 0x06004FCE RID: 20430 RVA: 0x00247628 File Offset: 0x00245828
	private void COFHHPOBPNG(JNHLAGHJBAA AGDMAFCKMJP, JNHLAGHJBAA.FPAEEADMCIE AOJKIAFNLAC)
	{
		if (AOJKIAFNLAC != null)
		{
			if (AOJKIAFNLAC.NLIKAGGPANH != null)
			{
				this.selectPerk = (AOJKIAFNLAC.NLIKAGGPANH as NLNNIDBPKAO.JENMPDPJKBG);
				return;
			}
			this.selectPerk = null;
		}
	}

	// Token: 0x06004FCF RID: 20431 RVA: 0x0024BC44 File Offset: 0x00249E44
	public void PBOGIEJFLGK(HBPNMNGOFMA KADBECGIMPD)
	{
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA(")", Vector3.zero, GuiProcessor.PLGADNLAEGN().NBMOILGEJIP());
		this.UID_info = KADBECGIMPD.IJDIMHAEAIE();
		UserInfoWin component = gameObject.GetComponent<UserInfoWin>();
		if (component != null)
		{
			component.MMIHMGCEPLA(this.UID_info, KADBECGIMPD);
			return;
		}
		Debug.LogError("#80ff00");
	}

	// Token: 0x06004FD0 RID: 20432 RVA: 0x0024BCA4 File Offset: 0x00249EA4
	public void NGLOHLKGALF(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(JMAKEAHMLMI, PHEMLBHMNCM.x + 1306f, PHEMLBHMNCM.y + 1734f, PHEMLBHMNCM.width - 731f, PHEMLBHMNCM.height - 705f, 0)
		{
			JHNCNHAAJCH = 1353f
		};
		mmkfaenbhkd.KPLMFNIFPMM = true;
		while (!KADBECGIMPD.PPAHBNGECGH())
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
			gdemcacnpng.OHAMJIKDMMF(KADBECGIMPD);
			gdemcacnpng.onRender = new ItemBase.OOALOMPKIKK(this.GHNILHJPAPE);
			mmkfaenbhkd.LACAJHOHACK.Add(gdemcacnpng);
		}
		mmkfaenbhkd.KCLLDJJLCGC = -74;
		mmkfaenbhkd.KINFJHFDHIC();
		mmkfaenbhkd.AGFFDCECLBF(1);
	}

	// Token: 0x06004FD1 RID: 20433 RVA: 0x0024BD4C File Offset: 0x00249F4C
	public void openUserInfo(HBPNMNGOFMA KADBECGIMPD)
	{
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("UI_UserInfoWinow", Vector3.zero, GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA);
		this.UID_info = KADBECGIMPD.DNIIFBAIPBE();
		UserInfoWin component = gameObject.GetComponent<UserInfoWin>();
		if (component != null)
		{
			component.initUserData(this.UID_info, KADBECGIMPD);
			return;
		}
		Debug.LogError("No UserInfoWin");
	}

	// Token: 0x06004FD2 RID: 20434 RVA: 0x0024BDAC File Offset: 0x00249FAC
	public void openStatistic(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + 20f, PHEMLBHMNCM.width - 40f, PHEMLBHMNCM.height - 40f, 0)
		{
			JHNCNHAAJCH = 64f
		};
		mmkfaenbhkd.KPLMFNIFPMM = false;
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
			gdemcacnpng.OCPAHLAGCAI(KADBECGIMPD);
			gdemcacnpng.onRender = new ItemBase.OOALOMPKIKK(this.GOPKOPLMFPN);
			mmkfaenbhkd.LACAJHOHACK.Add(gdemcacnpng);
		}
		mmkfaenbhkd.KCLLDJJLCGC = 11;
		mmkfaenbhkd.MGNDPEIFKAN();
		mmkfaenbhkd.IHEILFHMLAG = 0;
	}

	// Token: 0x06004FD3 RID: 20435 RVA: 0x0024BE54 File Offset: 0x0024A054
	public void NGIFDCLKABP(OIJEGJLCFCF CFBLFPPOIKE)
	{
		CFBLFPPOIKE.GAAPCLGDOGH.KKEKHHKLGFM(CFBLFPPOIKE.DBEIGNDALDC);
		this.CODAIBGMFCA = CFBLFPPOIKE;
		string iabkgmnjljo;
		if (this.CODAIBGMFCA.GAAPCLGDOGH.EBBNNMMBKCC() == 1)
		{
			iabkgmnjljo = string.Format(JNBICAJIJMM.EDKGBBIIBBC().NLJOLOBPCBJ("RollerBladeTurnRight"), this.CODAIBGMFCA.LHNOBJDFOOJ(false));
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
		}
		else
		{
			iabkgmnjljo = string.Format(JNBICAJIJMM.IKGFHGKKCPG.GNKIBMGNHNE("PistolReady"), this.CODAIBGMFCA.LHNOBJDFOOJ(true));
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.MPNJKJKDMLK)
		{
			Color lbcgackjcjb = new Color(679f, 1463f, 562f, 708f);
			if (this.CODAIBGMFCA.DBEIGNDALDC == 0)
			{
				lbcgackjcjb = new Color(179f, 1592f, 759f, 1019f);
			}
			if (this.CODAIBGMFCA.DBEIGNDALDC == 3)
			{
				lbcgackjcjb = new Color(880f, 647f, 1007f, 1214f);
			}
			if (this.CODAIBGMFCA.GEFOGEDMLJA)
			{
				lbcgackjcjb = new Color(952f, 159f, 1386f, 313f);
			}
			FlyMessageManager.getI.addMessageBig(iabkgmnjljo, lbcgackjcjb, 0, 0).NENOBDLCFHO = this.CODAIBGMFCA.NENOBDLCFHO;
			this.EFBAFHBCIDA(-1, false);
			bool knobfamemjc = HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC;
			return;
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC && ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) < 1454f)
		{
			this.KBCPPDACOMO(CFBLFPPOIKE, 153f);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.PLKKECPNMEB(Fisherman.getI.transform.position, 1385f);
		bool flag = false;
		int num = 0;
		int num2 = 1;
		foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.NAFGMKJPLPC)
		{
			num += oijegjlcfcf.NKHBAJKMAGD;
			num2 += 0;
		}
		num -= CFBLFPPOIKE.NKHBAJKMAGD;
		num2--;
		if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().NLHKFMMDMMK() || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().NKEOCCKEOCE())
		{
			flag = false;
		}
		if (LocNewLogic.getI.GFWin != null)
		{
			LocNewLogic.getI.GFWin.gameObject.SetActive(true);
			LocNewLogic.getI.GFWin.MOJLBKDPLLB(this.CODAIBGMFCA, flag);
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().NCIDDNIKACI(1282f, 1351f, JNBICAJIJMM.IMLLGEMPHAP().ECNKLECOKHD("Mouse ScrollWheel"), false);
		onkdcgnbalk.KNNIPIEENII = true;
		onkdcgnbalk.NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.MOFOHNEDFBL);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 432f + 755f, onkdcgnbalk.OCHCODJIPHJ.height - 1371f, 1940f, 1825f, JNBICAJIJMM.EDKGBBIIBBC().GNKIBMGNHNE("error.wav"), -55, null, new ONKDCGNBALK.CMMHGMILOIM(this.ANLHLPBBPPI));
		bool flag2 = false;
		if (flag)
		{
			new LCOLJOPGDLL(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1485f - 683f, onkdcgnbalk.OCHCODJIPHJ.height - 1530f, 1746f, 976f, JNBICAJIJMM.DBMJJPBOPEK().DOEMGEAEBPN("_DitheringTexture"), TextAnchor.UpperLeft, Color.red);
			flag2 = false;
		}
		else
		{
			string format = JNBICAJIJMM.APMJBBDBOJO().HEIBEHAEHBM("<color='#800000'>Вы потеряли леску: ");
			object[] array = new object[0];
			array[1] = num2;
			array[1] = BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().NLHKFMMDMMK();
			array[5] = JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)num);
			array[5] = JLFJEGIPIMM.NNEAHAFBOHC().GKDPPPKBELC((long)BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().KEHIFGILLJA());
			string dpanhmgcbnl = string.Format(format, array);
			new LCOLJOPGDLL(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 257f - 229f, onkdcgnbalk.OCHCODJIPHJ.height - 1031f, 1016f, 787f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black);
		}
		Rect ochcodjiphj = new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 1297f - 1598f, 1296f, 1201f, 1182f);
		new MGLHIBHDMPC(onkdcgnbalk, ochcodjiphj, this.fgetImage);
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(ochcodjiphj.x, ochcodjiphj.y, 1121f, 1727f), this.fgetImagesBases[JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.PNEDPPPEFFG]);
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, ochcodjiphj.x, ochcodjiphj.y, ochcodjiphj.width, ochcodjiphj.height, "GAMMA", 0, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.LGHDGKMCEIE)
		};
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 155f, egcaadaabpp.OCHCODJIPHJ.width - 374f, 1388f, string.Format("_info", CFBLFPPOIKE.MGLOOIONCPM), TextAnchor.LowerRight, new Color(1900f, 1768f, 764f));
		lcoljopgdll.LNDPBNODFPE = true;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		lcoljopgdll.DFIGKKMMIAF = 76;
		this.BLKAFFPKEBA = flag2;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1757f - 1302f, onkdcgnbalk.OCHCODJIPHJ.height - 411f, 1163f, 362f, JNBICAJIJMM.APMJBBDBOJO().CCFFMKBBKHI("crft_from"), -62, null, new ONKDCGNBALK.CMMHGMILOIM(this.OCLOCNNOGLK)).FNMCIACNOMH = flag2;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1255f + 497f, onkdcgnbalk.OCHCODJIPHJ.height - 1141f, 909f, 808f, JNBICAJIJMM.IKGFHGKKCPG.GNKIBMGNHNE("Windmill"), 75, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress));
	}

	// Token: 0x06004FD4 RID: 20436 RVA: 0x0024C4B0 File Offset: 0x0024A6B0
	public void DBBPEBFBBPN(int OLKMHFNLBJB, int CLCBHHLLLFN)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(OLKMHFNLBJB);
		if (idchhhedhdc != null)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().BJFHBPOCELH(1948f, 982f, JNBICAJIJMM.APMJBBDBOJO().GNKIBMGNHNE("u_UniqueShadowBlockerDistanceScale"), false);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(1184f, 998f, onkdcgnbalk.OCHCODJIPHJ.width - 511f, onkdcgnbalk.OCHCODJIPHJ.height - 1212f), this.PaperTexture);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1262f - 1681f, onkdcgnbalk.OCHCODJIPHJ.height - 1165f, 517f, 713f, JNBICAJIJMM.EDKGBBIIBBC().HLBAJBLHLNI(""), 1, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().BLPLADOIPJG));
			string text = string.Format(JNBICAJIJMM.IMLLGEMPHAP().DOEMGEAEBPN("A"), idchhhedhdc.HAJNMNALBBI);
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 1479f, 455f, onkdcgnbalk.OCHCODJIPHJ.width - 466f, 1674f, text, TextAnchor.UpperCenter, Color.black);
			lcoljopgdll.DFIGKKMMIAF = -115;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 654f - 1986f, 376f, 695f, 70f), this.VenokTexture, CLCBHHLLLFN, 5, 1);
			text = JNBICAJIJMM.IMLLGEMPHAP().KLMNGBHBOJE("wpn_rod1", "auc_wcstc");
			text = text.Replace("wpn_onlym", string.Concat(5 * CLCBHHLLLFN));
			text = text.Replace("BlackSmithHammer", string.Concat(-30 * CLCBHHLLLFN));
			new LCOLJOPGDLL(onkdcgnbalk, 916f, 561f, onkdcgnbalk.OCHCODJIPHJ.width - 343f, 533f, text, TextAnchor.UpperLeft, Color.black).DFIGKKMMIAF = -34;
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("z", 1948f);
		}
	}

	// Token: 0x06004FD5 RID: 20437 RVA: 0x0024C6B8 File Offset: 0x0024A8B8
	public void openAchivesWin(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + 20f, PHEMLBHMNCM.width - 40f, PHEMLBHMNCM.height - 40f, 0)
		{
			JHNCNHAAJCH = 64f
		};
		mmkfaenbhkd.KPLMFNIFPMM = false;
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			mmkfaenbhkd.LACAJHOHACK.Add(new DODHLMFHFNL.KPPFPHMJPFE(KADBECGIMPD));
		}
		mmkfaenbhkd.KCLLDJJLCGC = 12;
		mmkfaenbhkd.MGNDPEIFKAN();
		mmkfaenbhkd.IHEILFHMLAG = 0;
	}

	// Token: 0x06004FD6 RID: 20438 RVA: 0x0024C744 File Offset: 0x0024A944
	public void BIKOHGBJIPN(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(JMAKEAHMLMI, PHEMLBHMNCM.x + 1167f, PHEMLBHMNCM.y + 392f, PHEMLBHMNCM.width - 177f, PHEMLBHMNCM.height - 812f, 0)
		{
			JHNCNHAAJCH = 978f
		};
		mmkfaenbhkd.KPLMFNIFPMM = true;
		while (!KADBECGIMPD.LILLHFLDMBH())
		{
			int nenobdlcfho = KADBECGIMPD.IFDFHJLCHAE();
			long jcgdlkihbjg = KADBECGIMPD.ANPEIKGEDHJ();
			string gajgbadjhok = KADBECGIMPD.BFPHBMDMODH();
			int kcfcjhcbcfm = KADBECGIMPD.DOJKJHMJJNK();
			int pnedpppeffg = KADBECGIMPD.AGNKAFLKCAG();
			int hdelgedddce = KADBECGIMPD.HDBGOLAFOBK();
			int migbfmildhd = KADBECGIMPD.LDLKLPJBIJN();
			IDCHHHEDHDC.GIONPNFHOOC gionpnfhooc = new IDCHHHEDHDC.GIONPNFHOOC(nenobdlcfho, jcgdlkihbjg, gajgbadjhok, kcfcjhcbcfm, pnedpppeffg, hdelgedddce, migbfmildhd);
			gionpnfhooc.onRender = new ItemBase.OOALOMPKIKK(this.AEPELGLCEHH);
			mmkfaenbhkd.LACAJHOHACK.Add(gionpnfhooc);
		}
		mmkfaenbhkd.KCLLDJJLCGC = -107;
		mmkfaenbhkd.CFHDIMJHBAB();
		mmkfaenbhkd.OEIOEBCGMJE(0);
	}

	// Token: 0x06004FD7 RID: 20439 RVA: 0x0024C824 File Offset: 0x0024AA24
	private void HJIJHFGCLMB(ONKDCGNBALK ONPHLHKAGFP)
	{
		OIJEGJLCFCF dolfjggbdjf = this.DOLFJGGBDJF;
		if (dolfjggbdjf == null)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC.Remove(dolfjggbdjf);
			this.OJJLLBKEGNO.LACAJHOHACK.Remove(dolfjggbdjf);
			this.OJJLLBKEGNO.GCKGOOBOKJB();
			this.DBELGCHKMOE.LACAJHOHACK.Add(dolfjggbdjf);
			this.DBELGCHKMOE.GCKGOOBOKJB();
			epmphjgalbe.FLLJONHPLNA(this.currentHolodId);
			epmphjgalbe.MFPECHIKBCO(dolfjggbdjf.LPFKFNLHGBI);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-69, epmphjgalbe.NNEAJJNCGMK());
		}
		finally
		{
			epmphjgalbe.BKKEFKANGIM();
		}
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("RollerBladeCrossoverRight", 49f);
		this.DOAEGLOBFCD();
		this.BOPMLIJGLNN();
	}

	// Token: 0x06004FD8 RID: 20440 RVA: 0x0024C8F8 File Offset: 0x0024AAF8
	public void onPerkToTeechKey(ONKDCGNBALK ONPHLHKAGFP)
	{
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.KLGLOCMOHAG >= JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.JGIHLJKDMKM)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1405, -1);
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
			return;
		}
		if (!this.selectPerk.ODBICLOCIMO)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
			return;
		}
		if (this.selectPerk == null)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
			return;
		}
		int num = (int)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MHIIBKILGBL("teech_perk");
		if (this.selectPerk.LPFKFNLHGBI != num)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1405, this.selectPerk.LPFKFNLHGBI);
			return;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("error.wav", 1f);
	}

	// Token: 0x06004FD9 RID: 20441 RVA: 0x0024C9DC File Offset: 0x0024ABDC
	public void GJBGCCJONFF(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(JMAKEAHMLMI, PHEMLBHMNCM.x + 839f, PHEMLBHMNCM.y + 955f, PHEMLBHMNCM.width - 439f, PHEMLBHMNCM.height - 1613f, 1)
		{
			JHNCNHAAJCH = 1198f
		};
		mmkfaenbhkd.KPLMFNIFPMM = true;
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
			gdemcacnpng.MLAEDCOIFOL(KADBECGIMPD);
			gdemcacnpng.onRender = new ItemBase.OOALOMPKIKK(this.GOPKOPLMFPN);
			mmkfaenbhkd.LACAJHOHACK.Add(gdemcacnpng);
		}
		mmkfaenbhkd.KCLLDJJLCGC = -26;
		mmkfaenbhkd.GENPNFMLHED();
		mmkfaenbhkd.DBJBAELCFHI(0);
	}

	// Token: 0x06004FDB RID: 20443 RVA: 0x0024CAA8 File Offset: 0x0024ACA8
	private void LOBNGKMPCPE(OIJEGJLCFCF CFBLFPPOIKE, float DEFNNEGPNEI)
	{
		if (this.brgCntr == null)
		{
			Fisherman.getI.bragfish = JLFJEGIPIMM.NNEAHAFBOHC().JOFAKNGHIAD("more", Vector3.zero, Fisherman.getI.leftHandRodPoint);
			if (Fisherman.getI.bragfish == null)
			{
				return;
			}
			this.brgCntr = Fisherman.getI.bragfish.GetComponent<BragFish>();
			Fisherman.getI.bragfish.transform.localRotation = Quaternion.identity;
			Fisherman.getI.bragfish.transform.localScale = new Vector3(693f, 1019f, 1741f);
			Fisherman.getI.bragfish.transform.localPosition = Vector3.zero;
			this.brgCntr.PKIAJIDLNDK(CFBLFPPOIKE.NENOBDLCFHO, ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NBLJCEHNKAK), true);
		}
		if (Fisherman.getI.podsakObject != null)
		{
			UnityEngine.Object.Destroy(Fisherman.getI.podsakObject);
			Fisherman.getI.podsakObject = null;
		}
		Fisherman.getI.getBragCntrl.LJIEPIPIAJC(true);
		if (DEFNNEGPNEI > 368f)
		{
			base.StartCoroutine(this.BGBBLJDJCAM(DEFNNEGPNEI));
		}
	}

	// Token: 0x06004FDC RID: 20444 RVA: 0x0024CBE8 File Offset: 0x0024ADE8
	public void CEPPNBHBCLL(ONKDCGNBALK JMBKDINHDLO)
	{
		JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(true);
		NJMHLCGIAJI.EAJGHMMBAFP().GDNKCAOHEPL(124, "PER_PIXEL");
	}

	// Token: 0x06004FDD RID: 20445 RVA: 0x0024CC08 File Offset: 0x0024AE08
	public void ADPKHHILJHD(HBPNMNGOFMA KADBECGIMPD)
	{
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.JOFAKNGHIAD("Close", Vector3.zero, GuiProcessor.NKOEAPCIBKO().NBMOILGEJIP());
		this.UID_info = KADBECGIMPD.ANPEIKGEDHJ();
		UserInfoWin component = gameObject.GetComponent<UserInfoWin>();
		if (component != null)
		{
			component.OMIHNNFJOCB(this.UID_info, KADBECGIMPD);
			return;
		}
		Debug.LogError("blesna.ogg");
	}

	// Token: 0x06004FDE RID: 20446 RVA: 0x0024CC68 File Offset: 0x0024AE68
	private void HOPKKKFFGEN(ONKDCGNBALK ONPHLHKAGFP)
	{
		OIJEGJLCFCF dolfjggbdjf = this.DOLFJGGBDJF;
		if (dolfjggbdjf == null)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC.Remove(dolfjggbdjf);
			this.OJJLLBKEGNO.LACAJHOHACK.Remove(dolfjggbdjf);
			this.OJJLLBKEGNO.GCKGOOBOKJB();
			this.DBELGCHKMOE.LACAJHOHACK.Add(dolfjggbdjf);
			this.DBELGCHKMOE.KHOHPADLIHJ();
			epmphjgalbe.AEMAHNDEBKJ(this.currentHolodId);
			epmphjgalbe.PMJPIJMHELL(dolfjggbdjf.LPFKFNLHGBI);
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(20, epmphjgalbe.ALLANCHILCM());
		}
		finally
		{
			epmphjgalbe.PMIGGJHLIDO();
		}
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("", 1634f);
		this.HPICBMCMAEC();
		this.NMOEPACMOHK();
	}

	// Token: 0x06004FDF RID: 20447 RVA: 0x0024CD3C File Offset: 0x0024AF3C
	private void CCPOIOJPKIF()
	{
		if (GameInterface.getI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		HPGKIJLKCIH.IKGFHGKKCPG.OBGCHDDFNCF();
		GameInterface.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		CKNLPGEPGGF.IKGFHGKKCPG.PINLMCCKKNA();
	}

	// Token: 0x06004FE0 RID: 20448 RVA: 0x0024CD7C File Offset: 0x0024AF7C
	public void IMDMKDCHBGJ(HBPNMNGOFMA KADBECGIMPD)
	{
		this.currentHolodId = KADBECGIMPD.AGNKAFLKCAG();
		this.holodFreeCell = KADBECGIMPD.KKOKFLMMAAK();
		if (this.CBJBOCGAEKC != 0)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().BMOFIBGMIBK(this.CBJBOCGAEKC);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.PLHAGCDJLPA(1938f, 689f, JNBICAJIJMM.APMJBBDBOJO().DOEMGEAEBPN("G"), false);
		this.CBJBOCGAEKC = onkdcgnbalk.LPFKFNLHGBI;
		this.OJJLLBKEGNO = new MMKFAENBHKD(onkdcgnbalk, 1107f, 828f, 1519f, onkdcgnbalk.OCHCODJIPHJ.height - 67f, 0);
		foreach (OIJEGJLCFCF item in JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.NAFGMKJPLPC)
		{
			this.OJJLLBKEGNO.LACAJHOHACK.Add(item);
		}
		this.OJJLLBKEGNO.JJKGANHANFN(this.OJJLLBKEGNO.LACAJHOHACK.Count - 1);
		this.OJJLLBKEGNO.GLNLJMIMHBH();
		this.OJJLLBKEGNO.JHNCNHAAJCH = 1329f;
		this.OHIPOCGKHDE = new LCOLJOPGDLL(onkdcgnbalk, 1047f, 798f, 688f, 626f, "The given 2D texture ", TextAnchor.UpperCenter, Color.gray)
		{
			LNDPBNODFPE = true
		};
		this.CINAIMICJGM = new LCOLJOPGDLL(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 525f - 163f, 224f, 1796f, 1646f, "_Offsets", TextAnchor.UpperCenter, Color.gray)
		{
			LNDPBNODFPE = false
		};
		this.AFEHNJCCJAF();
		this.DBELGCHKMOE = new MMKFAENBHKD(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 507f - 969f, 1496f, 443f, onkdcgnbalk.OCHCODJIPHJ.height - 589f, 1);
		while (!KADBECGIMPD.HKBFCJDJCOB())
		{
			OIJEGJLCFCF oijegjlcfcf = new OIJEGJLCFCF();
			oijegjlcfcf.PBDAMFPENHE(KADBECGIMPD);
			this.DBELGCHKMOE.LACAJHOHACK.Add(oijegjlcfcf);
		}
		this.DBELGCHKMOE.NEKOMKJDIIE(this.OJJLLBKEGNO.LACAJHOHACK.Count - 1);
		this.DBELGCHKMOE.PHHNPGFNNCB();
		this.DBELGCHKMOE.JHNCNHAAJCH = 821f;
		this.NMOEPACMOHK();
		new HKIEEHBCMNJ(onkdcgnbalk, 339f, 516f, 1, this.bigKeysTexture, 8, 2, 0, new ONKDCGNBALK.CMMHGMILOIM(this.MNJCDKFJKCA));
		new HKIEEHBCMNJ(onkdcgnbalk, 520f, 1078f, 8, this.bigKeysTexture, 2, 6, 1, new ONKDCGNBALK.CMMHGMILOIM(this.JFAPCEOBAJA));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1630f - 1105f, onkdcgnbalk.OCHCODJIPHJ.height - 1986f, 1563f, 625f, JNBICAJIJMM.DBMJJPBOPEK().HEIBEHAEHBM("_SampleScale"), 6, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.MNJNNDHCDGG().HMBGLALKHCP));
	}

	// Token: 0x06004FE1 RID: 20449 RVA: 0x0024D074 File Offset: 0x0024B274
	public void KNKAEHIGNPI()
	{
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-124, this.CODAIBGMFCA.LPFKFNLHGBI);
		this.OJJLLBKEGNO.LACAJHOHACK.Remove(this.CODAIBGMFCA);
		JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.NAFGMKJPLPC.Remove(this.CODAIBGMFCA);
		string iabkgmnjljo = string.Format(JNBICAJIJMM.EKEBHIJMEML().CKAOHMEKLMH("none"), this.CODAIBGMFCA.JDPKKGOOKDF(false));
		if (this.CODAIBGMFCA.GAAPCLGDOGH.EBBNNMMBKCC() == 0)
		{
			iabkgmnjljo = string.Format(JNBICAJIJMM.LPHMKPDBMPP().HEIBEHAEHBM("_AdaptationMin"), this.CODAIBGMFCA.OKJEDFNFDML(true));
		}
		OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
		this.CODAIBGMFCA = null;
		this.OJJLLBKEGNO.IJEHPMOIPAA();
		this.OJJLLBKEGNO.HNAMFMFHIGH(0, 0);
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("GiantGrabIdle", 1965f);
		this.ACKCODOIBCL();
	}

	// Token: 0x06004FE2 RID: 20450 RVA: 0x0024D166 File Offset: 0x0024B366
	private void AGKMAOBNCDC()
	{
		if (Input.GetKeyDown((KeyCode)(-106)) && JDCEFOFMGHB.HMJJPNDEKPP().IHNMOJHBMNJ(this.sadokWinId) != null && this.CODAIBGMFCA != null)
		{
			this.GKBCONBIMIN();
		}
	}

	// Token: 0x06004FE3 RID: 20451 RVA: 0x0024D194 File Offset: 0x0024B394
	public void ABCCCADIMOK(ONKDCGNBALK ONPHLHKAGFP)
	{
		int num = (int)JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BIHLDHKHPKE("IKSolverFABRIKRoot chain at index ");
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -64,
			font = GuiProcessor.IKGFHGKKCPG.rusfont3,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.LowerLeft
		};
		if (num > 0)
		{
			NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.PKJMLDMLFCM(num);
			if (jenmpdpjkbg != null)
			{
				guistyle.alignment = TextAnchor.UpperLeft;
				GUI.DrawTexture(new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 943f, ONPHLHKAGFP.OCHCODJIPHJ.y + 472f, 206f, 1301f), jenmpdpjkbg.BDHHPAEHFHG.CIBLMLGGANE());
				guistyle.fontStyle = FontStyle.Bold;
				string str = string.Format(JNBICAJIJMM.CLIMNFDGOEG().DOEMGEAEBPN("wpn_tank2"), jenmpdpjkbg.JAGMEPMLCCP);
				if (jenmpdpjkbg.JAGMEPMLCCP == 0)
				{
					str = JNBICAJIJMM.EEOPOHEALPK().GNKIBMGNHNE("{0}/{1}");
				}
				if (jenmpdpjkbg.JAGMEPMLCCP == 2)
				{
					str = JNBICAJIJMM.DBMJJPBOPEK().FLEANFGEJML("Katana");
				}
				GUI.Label(new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 1788f, ONPHLHKAGFP.OCHCODJIPHJ.y + 580f, 879f, 233f), jenmpdpjkbg.BDHHPAEHFHG.KKEBDLGHBMN + str, guistyle);
				guistyle.fontStyle = FontStyle.Normal;
				guistyle.fontSize = -87;
				guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
				string text = jenmpdpjkbg.BDHHPAEHFHG.PAALJNAKJEG;
				int num2 = jenmpdpjkbg.JAGMEPMLCCP + 1;
				if (num2 > 1)
				{
					num2 = 8;
				}
				text = text.Replace("IdleFeedThrow", string.Concat(jenmpdpjkbg.BDHHPAEHFHG.DCCPCBLODIG.DHJBAKDAMGH() * (double)num2));
				text = text.Replace("pelvis", string.Concat(jenmpdpjkbg.BDHHPAEHFHG.DCCPCBLODIG.OIGIHEPJFFJ() * (double)num2));
				text = text.Replace("https://groups.google.com/forum/#!forum/final-ik", string.Concat(jenmpdpjkbg.BDHHPAEHFHG.DCCPCBLODIG.HDPNCIECLKP() * (double)num2));
				GUI.Label(new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 996f, ONPHLHKAGFP.OCHCODJIPHJ.y + 1382f, 100f, 1561f), text, guistyle);
				this.NFGOLLEEHHK(new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 1124f, ONPHLHKAGFP.OCHCODJIPHJ.y + 889f, ONPHLHKAGFP.OCHCODJIPHJ.width - 141f, 1886f), jenmpdpjkbg.KLPANBANBDI, (float)jenmpdpjkbg.GNNDLEAFCND, 8, string.Format("PPricel", Mathf.FloorToInt(jenmpdpjkbg.KLPANBANBDI), jenmpdpjkbg.GNNDLEAFCND), true);
				return;
			}
		}
		else
		{
			GUI.Label(ONPHLHKAGFP.OCHCODJIPHJ, JNBICAJIJMM.CELEPPAEKAB("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6"), guistyle);
		}
	}

	// Token: 0x06004FE4 RID: 20452 RVA: 0x0024D47C File Offset: 0x0024B67C
	private void DNCPLCNFDEC(OIJEGJLCFCF CFBLFPPOIKE, float DEFNNEGPNEI)
	{
		if (this.brgCntr == null)
		{
			Fisherman.getI.bragfish = JLFJEGIPIMM.PKGMBFEMKGP().DAJFMBBDJIC("wpn_eat6", Vector3.zero, Fisherman.getI.leftHandRodPoint);
			if (Fisherman.getI.bragfish == null)
			{
				return;
			}
			this.brgCntr = Fisherman.getI.bragfish.GetComponent<BragFish>();
			Fisherman.getI.bragfish.transform.localRotation = Quaternion.identity;
			Fisherman.getI.bragfish.transform.localScale = new Vector3(1460f, 1808f, 628f);
			Fisherman.getI.bragfish.transform.localPosition = Vector3.zero;
			this.brgCntr.FLNDGDIDIKF(CFBLFPPOIKE.NENOBDLCFHO, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NBLJCEHNKAK), false);
		}
		if (Fisherman.getI.podsakObject != null)
		{
			UnityEngine.Object.Destroy(Fisherman.getI.podsakObject);
			Fisherman.getI.podsakObject = null;
		}
		Fisherman.getI.getBragCntrl.AEMLIGKOPNE(false);
		if (DEFNNEGPNEI > 897f)
		{
			base.StartCoroutine(this.BGBBLJDJCAM(DEFNNEGPNEI));
		}
	}

	// Token: 0x06004FE5 RID: 20453 RVA: 0x0024D5BC File Offset: 0x0024B7BC
	public void OBDKLGAECAH(MMKFAENBHKD OCKMAJALKMN, object HEABEPINGED)
	{
		this.CODAIBGMFCA = (HEABEPINGED as OIJEGJLCFCF);
		this.rembtn.FNMCIACNOMH = this.PCFEONMMMAF();
	}

	// Token: 0x06004FE6 RID: 20454 RVA: 0x0024D5DC File Offset: 0x0024B7DC
	public void NGKLCGDLKDB(int KKIODALCJGE)
	{
		this.GEDNGIDHBHD();
		if (this.CODAIBGMFCA != null)
		{
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(14, this.CODAIBGMFCA.LPFKFNLHGBI);
			JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC.Remove(this.CODAIBGMFCA);
			string iabkgmnjljo = string.Format(JNBICAJIJMM.IKGFHGKKCPG.CCFFMKBBKHI("Fly Down"), this.CODAIBGMFCA.PINLAFIAGGJ(true));
			if (this.CODAIBGMFCA.GAAPCLGDOGH.PEIEODKMEKL() == 1)
			{
				iabkgmnjljo = string.Format(JNBICAJIJMM.IKGFHGKKCPG.GNKIBMGNHNE("{0:### ##0.#0}"), this.CODAIBGMFCA.MJODNMLNFJC(false));
			}
			if (KKIODALCJGE > 0)
			{
				JDCEFOFMGHB.HMJJPNDEKPP().KCNBOHEMLCI(KKIODALCJGE);
			}
			FlyMessageManager.getI.clearMessages();
			Vector3 nhclmboinfg = Fisherman.getI.transform.position + Fisherman.getI.transform.forward;
			FBFJFAKAGJG.IKGFHGKKCPG.LBGNEGLBLHF(nhclmboinfg, 1989f);
			LocNewLogic.getI.AMBEOENMJJO(nhclmboinfg, (float)this.CODAIBGMFCA.NKHBAJKMAGD / 1348f);
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
			this.CODAIBGMFCA = null;
		}
	}

	// Token: 0x06004FE7 RID: 20455 RVA: 0x0024D700 File Offset: 0x0024B900
	public void openFishAchiveWin(int OLKMHFNLBJB, int CLCBHHLLLFN)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(OLKMHFNLBJB);
		if (idchhhedhdc != null)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(400f, 400f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_ach"), true);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(10f, 40f, onkdcgnbalk.OCHCODJIPHJ.width - 20f, onkdcgnbalk.OCHCODJIPHJ.height - 55f), this.PaperTexture);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 50f, onkdcgnbalk.OCHCODJIPHJ.height - 50f, 100f, 24f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("close"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
			string text = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_nach"), idchhhedhdc.HAJNMNALBBI);
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 10f, 55f, onkdcgnbalk.OCHCODJIPHJ.width - 20f, 80f, text, TextAnchor.UpperCenter, Color.black);
			lcoljopgdll.DFIGKKMMIAF = 22;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 2f - 57f, 110f, 115f, 115f), this.VenokTexture, CLCBHHLLLFN, 4, 1);
			text = JNBICAJIJMM.IKGFHGKKCPG.OMNMDGIGEFD("INTERFACE", "achive_text");
			text = text.Replace("[F_KLEV]", string.Concat(3 * CLCBHHLLLFN));
			text = text.Replace("[F_EXP]", string.Concat(25 * CLCBHHLLLFN));
			new LCOLJOPGDLL(onkdcgnbalk, 30f, 250f, onkdcgnbalk.OCHCODJIPHJ.width - 60f, 90f, text, TextAnchor.UpperCenter, Color.black).DFIGKKMMIAF = 14;
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("fanfare.wav", 1f);
		}
	}

	// Token: 0x06004FE8 RID: 20456 RVA: 0x0024D908 File Offset: 0x0024BB08
	public void FFPPJGCJHBF(int KKIODALCJGE)
	{
		this.endShowFish();
		if (this.CODAIBGMFCA != null)
		{
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(156, this.CODAIBGMFCA.LPFKFNLHGBI);
			JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.NAFGMKJPLPC.Remove(this.CODAIBGMFCA);
			string iabkgmnjljo = string.Format(JNBICAJIJMM.CLIMNFDGOEG().NLJOLOBPCBJ("_FadeDistance"), this.CODAIBGMFCA.PINLAFIAGGJ(true));
			if (this.CODAIBGMFCA.GAAPCLGDOGH.KIJMCOPFLCN == 1)
			{
				iabkgmnjljo = string.Format(JNBICAJIJMM.DBMJJPBOPEK().DOEMGEAEBPN("RollerBladeBackFlip"), this.CODAIBGMFCA.LHNOBJDFOOJ(false));
			}
			if (KKIODALCJGE > 1)
			{
				JDCEFOFMGHB.HMJJPNDEKPP().CBHHEHHNFKL(KKIODALCJGE);
			}
			FlyMessageManager.getI.CGKPOCMEDGJ();
			Vector3 nhclmboinfg = Fisherman.getI.transform.position + Fisherman.getI.transform.forward;
			FBFJFAKAGJG.IKGFHGKKCPG.PLKKECPNMEB(nhclmboinfg, 1103f);
			LocNewLogic.getI.createWaterSplash(nhclmboinfg, (float)this.CODAIBGMFCA.NKHBAJKMAGD / 914f);
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
			this.CODAIBGMFCA = null;
		}
	}

	// Token: 0x06004FE9 RID: 20457 RVA: 0x0024DA2C File Offset: 0x0024BC2C
	private static void HPNMCNHFODM(JNHLAGHJBAA.FPAEEADMCIE KAOKEJPBAHM, XmlNodeList OPEKKKOEIKC)
	{
		foreach (object obj in OPEKKKOEIKC)
		{
			XmlNode xmlNode = (XmlNode)obj;
			if (xmlNode.Attributes != null)
			{
				int num = int.Parse(xmlNode.Attributes["id"].Value);
				string value = xmlNode.Attributes["name"].Value;
				GameInterface.HPNMCNHFODM(KAOKEJPBAHM.DHHCGNOLGCD(value, (long)num), xmlNode.SelectNodes("category"));
			}
		}
	}

	// Token: 0x06004FEA RID: 20458 RVA: 0x0024DAD0 File Offset: 0x0024BCD0
	private void JPAANPEIKOM()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.EGPNLJNEAEA();
	}

	// Token: 0x06004FEB RID: 20459 RVA: 0x0024DADC File Offset: 0x0024BCDC
	private void AKFCJJIEAAK(ONKDCGNBALK OCPJAEHJCNB)
	{
		this.LCMCOGOGHPL.IIMDMCFPCNB(JNBICAJIJMM.PGJCPFNJNPM("{0}Textures/Turnirs/{1}.png"));
		long num = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BIHLDHKHPKE("colorA");
		string str = JNBICAJIJMM.DIOJFJMOPJO("IdleDodgeRight");
		if (num != 0L)
		{
			DateTime dateTime = DateTime.Now;
			bool flag = false;
			try
			{
				dateTime = DateTime.FromBinary(num) - TimeController.IKGFHGKKCPG.deltaTime;
				if (dateTime > DateTime.Now)
				{
					flag = true;
				}
			}
			catch (Exception)
			{
				flag = false;
			}
			if (flag)
			{
				TimeSpan timeSpan = dateTime - DateTime.Now;
				str = string.Format("SysAlert.wav", timeSpan.Minutes, timeSpan.Seconds);
				this.FJOABFJFMEP.FNMCIACNOMH = false;
			}
			else
			{
				this.FJOABFJFMEP.FNMCIACNOMH = false;
			}
		}
		else
		{
			this.FJOABFJFMEP.FNMCIACNOMH = true;
		}
		LCOLJOPGDLL lcmcogoghpl = this.LCMCOGOGHPL;
		lcmcogoghpl.HGFGOMIHCJK(lcmcogoghpl.FKHKFEIMHPA() + str);
	}

	// Token: 0x06004FEC RID: 20460 RVA: 0x0024DBDC File Offset: 0x0024BDDC
	public void openUserData(int LPFKFNLHGBI, HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.sendAction(2, 4f, Vector3.zero);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(this.OJNFLOAOILJ);
		if (onkdcgnbalk == null)
		{
			onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(800f, 600f, "", true);
		}
		else
		{
			onkdcgnbalk.MPKCOJHJIIB();
		}
		this.OJNFLOAOILJ = onkdcgnbalk.LPFKFNLHGBI;
		int num = 60;
		new EGCAADAABPP(onkdcgnbalk, 20f, 50f, 200f, 460f, "", 0, null);
		MEMEOHJKPNJ memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, 30f, (float)num, 180f, 35f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_um_0"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.infoWinKeyPress));
		memeohjkpnj.HKPAEGGJNGG = (LPFKFNLHGBI == 1);
		memeohjkpnj.KCLLDJJLCGC = 16;
		num += 40;
		MEMEOHJKPNJ memeohjkpnj2 = new MEMEOHJKPNJ(onkdcgnbalk, 30f, (float)num, 180f, 35f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_um_1"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(this.infoWinKeyPress));
		memeohjkpnj2.HKPAEGGJNGG = (LPFKFNLHGBI == 2);
		memeohjkpnj2.KCLLDJJLCGC = 16;
		num += 40;
		MEMEOHJKPNJ memeohjkpnj3 = new MEMEOHJKPNJ(onkdcgnbalk, 30f, (float)num, 180f, 35f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_um_2"), 7, null, new ONKDCGNBALK.CMMHGMILOIM(this.infoWinKeyPress));
		memeohjkpnj3.HKPAEGGJNGG = (LPFKFNLHGBI == 7);
		memeohjkpnj3.KCLLDJJLCGC = 16;
		num += 40;
		MEMEOHJKPNJ memeohjkpnj4 = new MEMEOHJKPNJ(onkdcgnbalk, 30f, (float)num, 180f, 35f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_um_3"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(this.infoWinKeyPress));
		memeohjkpnj4.HKPAEGGJNGG = (LPFKFNLHGBI == 3);
		memeohjkpnj4.KCLLDJJLCGC = 16;
		num += 40;
		MEMEOHJKPNJ memeohjkpnj5 = new MEMEOHJKPNJ(onkdcgnbalk, 30f, (float)num, 180f, 35f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_um_4"), 9, null, new ONKDCGNBALK.CMMHGMILOIM(this.infoWinKeyPress));
		memeohjkpnj5.HKPAEGGJNGG = (LPFKFNLHGBI == 9);
		memeohjkpnj5.KCLLDJJLCGC = 16;
		num += 40;
		MEMEOHJKPNJ memeohjkpnj6 = new MEMEOHJKPNJ(onkdcgnbalk, 30f, (float)num, 180f, 35f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_um_5"), 8, null, new ONKDCGNBALK.CMMHGMILOIM(this.infoWinKeyPress));
		memeohjkpnj6.HKPAEGGJNGG = (LPFKFNLHGBI == 8);
		memeohjkpnj6.KCLLDJJLCGC = 16;
		num += 40;
		MEMEOHJKPNJ memeohjkpnj7 = new MEMEOHJKPNJ(onkdcgnbalk, 30f, (float)num, 180f, 35f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_um_6"), 4, null, new ONKDCGNBALK.CMMHGMILOIM(this.infoWinKeyPress));
		memeohjkpnj7.HKPAEGGJNGG = (LPFKFNLHGBI == 4);
		memeohjkpnj7.KCLLDJJLCGC = 16;
		num += 40;
		num += 40;
		MEMEOHJKPNJ memeohjkpnj8 = new MEMEOHJKPNJ(onkdcgnbalk, 30f, (float)num, 180f, 40f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_um_7"), 5, null, null);
		memeohjkpnj8.HKPAEGGJNGG = (LPFKFNLHGBI == 5);
		memeohjkpnj8.FNMCIACNOMH = false;
		memeohjkpnj8.KCLLDJJLCGC = 16;
		memeohjkpnj8.FNMCIACNOMH = false;
		num += 40;
		MEMEOHJKPNJ memeohjkpnj9 = new MEMEOHJKPNJ(onkdcgnbalk, 30f, (float)num, 180f, 40f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_um_8"), 5, null, null);
		memeohjkpnj9.HKPAEGGJNGG = (LPFKFNLHGBI == 5);
		memeohjkpnj9.FNMCIACNOMH = false;
		memeohjkpnj9.KCLLDJJLCGC = 16;
		memeohjkpnj9.FNMCIACNOMH = false;
		num += 40;
		MEMEOHJKPNJ memeohjkpnj10 = new MEMEOHJKPNJ(onkdcgnbalk, 30f, (float)num, 180f, 40f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_um_9"), 6, null, null);
		memeohjkpnj10.HKPAEGGJNGG = (LPFKFNLHGBI == 6);
		memeohjkpnj10.FNMCIACNOMH = false;
		memeohjkpnj10.KCLLDJJLCGC = 16;
		memeohjkpnj10.FNMCIACNOMH = false;
		Rect rect = new Rect(230f, 50f, onkdcgnbalk.OCHCODJIPHJ.width - 250f, onkdcgnbalk.OCHCODJIPHJ.height - 70f);
		new MGLHIBHDMPC(onkdcgnbalk, rect, this.PaperTexture);
		new EGCAADAABPP(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, "", 0, null);
		switch (LPFKFNLHGBI)
		{
		case 1:
			this.renderUD_Info(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 2:
			this.openStatistic(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 3:
			this.openReputationWindow(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 4:
			this.OpenTitulWindow(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 7:
			this.openRecordWin(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 8:
			this.OpenPerksWindow(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 9:
			this.openAchivesWin(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		}
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
	}

	// Token: 0x06004FED RID: 20461 RVA: 0x0024E044 File Offset: 0x0024C244
	public void CJBLGHLAGEI(int OLKMHFNLBJB, int CLCBHHLLLFN)
	{
		IDCHHHEDHDC idchhhedhdc = AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(OLKMHFNLBJB);
		if (idchhhedhdc != null)
		{
			ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().PJHMHBAGFAN(1516f, 1392f, JNBICAJIJMM.IKGFHGKKCPG.NLJOLOBPCBJ("_w"), false);
			new MGLHIBHDMPC(onkdcgnbalk, new Rect(402f, 1997f, onkdcgnbalk.OCHCODJIPHJ.width - 343f, onkdcgnbalk.OCHCODJIPHJ.height - 179f), this.PaperTexture);
			new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 5f - 471f, onkdcgnbalk.OCHCODJIPHJ.height - 1304f, 539f, 219f, JNBICAJIJMM.IMLLGEMPHAP().CCFFMKBBKHI("Vertical"), 7, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.JFIDAGABKID().AGIEGPEMGOA));
			string text = string.Format(JNBICAJIJMM.EEOPOHEALPK().DOEMGEAEBPN(""), idchhhedhdc.HAJNMNALBBI);
			LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, 684f, 1072f, onkdcgnbalk.OCHCODJIPHJ.width - 673f, 1076f, text, TextAnchor.UpperLeft, Color.black);
			lcoljopgdll.DFIGKKMMIAF = -104;
			lcoljopgdll.HOBLHFPJKFA = GuiProcessor.BBLINJLBAIL().rusfont3;
			new GMJFFDBJLCI(onkdcgnbalk, new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 423f - 1871f, 614f, 1276f, 1125f), this.VenokTexture, CLCBHHLLLFN, 0, 0);
			text = JNBICAJIJMM.LPHMKPDBMPP().DBPANLKEHMN("{0} x {1}", "Загрузка: ");
			text = text.Replace("GOSound2D", string.Concat(4 * CLCBHHLLLFN));
			text = text.Replace("", string.Concat(17 * CLCBHHLLLFN));
			new LCOLJOPGDLL(onkdcgnbalk, 925f, 636f, onkdcgnbalk.OCHCODJIPHJ.width - 1581f, 157f, text, TextAnchor.UpperCenter, Color.black).DFIGKKMMIAF = 14;
			FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ(" has invalid children array. Child index is referencing to itself.", 1030f);
		}
	}

	// Token: 0x06004FEE RID: 20462 RVA: 0x0024E24A File Offset: 0x0024C44A
	private IEnumerator NFJJLNNBIOE(float FGNPJLIPNFM)
	{
		yield return new WaitForSeconds(FGNPJLIPNFM);
		this.endShowFish();
		yield break;
	}

	// Token: 0x06004FEF RID: 20463 RVA: 0x002493BB File Offset: 0x002475BB
	public void SadokAction(int PPJJJAGNADB)
	{
		this.endShowFish();
	}

	// Token: 0x06004FF0 RID: 20464 RVA: 0x0024E260 File Offset: 0x0024C460
	public void BMCOPJCKAFA(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		if (JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.GOJICKHNGEE.Count <= 1)
		{
			new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x, PHEMLBHMNCM.y, PHEMLBHMNCM.width, PHEMLBHMNCM.height, JNBICAJIJMM.PPNKMDJBMLP("Visit docs to see where PlayerPrefs are stored"), TextAnchor.MiddleCenter, Color.black);
			return;
		}
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(JMAKEAHMLMI, PHEMLBHMNCM.x + 1385f, PHEMLBHMNCM.y + 385f, PHEMLBHMNCM.width - 533f, PHEMLBHMNCM.height - 1051f, 1)
		{
			JHNCNHAAJCH = 884f
		};
		mmkfaenbhkd.KPLMFNIFPMM = false;
		foreach (BHNDGIPPPCE.MKIEEEENAMA mkieeeenama in JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GOJICKHNGEE)
		{
			mkieeeenama.onRender = new ItemBase.OOALOMPKIKK(this.LLONJAFCLML);
			mmkfaenbhkd.LACAJHOHACK.Add(mkieeeenama);
		}
		mmkfaenbhkd.KCLLDJJLCGC = -101;
		mmkfaenbhkd.IKDBEOHOOJJ();
		mmkfaenbhkd.DBJBAELCFHI(0);
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = false;
	}

	// Token: 0x06004FF1 RID: 20465 RVA: 0x0024E38C File Offset: 0x0024C58C
	public void EBAOMHDICFP(int KKIODALCJGE)
	{
		this.endShowFish();
		if (this.CODAIBGMFCA != null)
		{
			NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(177, this.CODAIBGMFCA.LPFKFNLHGBI);
			JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.NAFGMKJPLPC.Remove(this.CODAIBGMFCA);
			string iabkgmnjljo = string.Format(JNBICAJIJMM.APMJBBDBOJO().DOEMGEAEBPN("[wtemplid]"), this.CODAIBGMFCA.LHNOBJDFOOJ(false));
			if (this.CODAIBGMFCA.GAAPCLGDOGH.PGJDMOJBOGC() == 0)
			{
				iabkgmnjljo = string.Format(JNBICAJIJMM.LPHMKPDBMPP().ECNKLECOKHD("_Source"), this.CODAIBGMFCA.GMLGLOOIEAA(false));
			}
			if (KKIODALCJGE > 1)
			{
				JDCEFOFMGHB.JFIDAGABKID().BMOFIBGMIBK(KKIODALCJGE);
			}
			FlyMessageManager.getI.LNIAHMKKNAK();
			Vector3 nhclmboinfg = Fisherman.getI.transform.position + Fisherman.getI.transform.forward;
			FBFJFAKAGJG.IKGFHGKKCPG.PLKKECPNMEB(nhclmboinfg, 1207f);
			LocNewLogic.getI.DJBBECFDLAA(nhclmboinfg, (float)this.CODAIBGMFCA.NKHBAJKMAGD / 715f);
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
			this.CODAIBGMFCA = null;
		}
	}

	// Token: 0x06004FF2 RID: 20466 RVA: 0x0024E4B0 File Offset: 0x0024C6B0
	public void MKJGPNKJFDL(ONKDCGNBALK JMBKDINHDLO)
	{
		long odfekbjcfmn = JMBKDINHDLO.ODFEKBJCFMN;
		long num = odfekbjcfmn - 1L;
		if (num <= 2L)
		{
			switch ((uint)num)
			{
			case 0U:
				NJMHLCGIAJI.EAJGHMMBAFP().AMEOMLNLOGF(1, "****************  playMusic 1=");
				break;
			case 1U:
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(5, 1);
				break;
			case 2U:
				NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(121, 0);
				Debug.Log("error.wav");
				break;
			case 3U:
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(121, 0);
				break;
			case 6U:
				NJMHLCGIAJI.EAJGHMMBAFP().PIGIIJLCADJ(-1, 0);
				break;
			case 7U:
				NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(-69, 0);
				break;
			case 8U:
				NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(127, 0);
				break;
			}
		}
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
	}

	// Token: 0x06004FF3 RID: 20467 RVA: 0x0024E588 File Offset: 0x0024C788
	public void levelUpKey(ONKDCGNBALK JMBKDINHDLO)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(41, "?");
	}

	// Token: 0x06004FF4 RID: 20468 RVA: 0x0024E5A6 File Offset: 0x0024C7A6
	private void OnDestroy()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.PLMCCCMHFKB();
	}

	// Token: 0x06004FF5 RID: 20469 RVA: 0x0024E5B4 File Offset: 0x0024C7B4
	private void PNIDJPMFCLJ(ONKDCGNBALK OCPJAEHJCNB)
	{
		this.LCMCOGOGHPL.CAIMFOFBEII(JNBICAJIJMM.NGALDMFKMJH("_ColorBuffer"));
		long num = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BIHLDHKHPKE("wpn_eat4");
		string str = JNBICAJIJMM.PGJCPFNJNPM("[minwgt]");
		if (num != 0L)
		{
			DateTime dateTime = DateTime.Now;
			bool flag = true;
			try
			{
				dateTime = DateTime.FromBinary(num) - TimeController.EKEBHIJMEML().deltaTime;
				if (dateTime > DateTime.Now)
				{
					flag = false;
				}
			}
			catch (Exception)
			{
				flag = true;
			}
			if (flag)
			{
				TimeSpan timeSpan = dateTime - DateTime.Now;
				str = string.Format("<color=\"", timeSpan.Minutes, timeSpan.Seconds);
				this.FJOABFJFMEP.FNMCIACNOMH = true;
			}
			else
			{
				this.FJOABFJFMEP.FNMCIACNOMH = true;
			}
		}
		else
		{
			this.FJOABFJFMEP.FNMCIACNOMH = true;
		}
		LCOLJOPGDLL lcmcogoghpl = this.LCMCOGOGHPL;
		lcmcogoghpl.HGMEJGKFBIK(lcmcogoghpl.PLHABPDBEHG() + str);
	}

	// Token: 0x06004FF6 RID: 20470 RVA: 0x0024E6B4 File Offset: 0x0024C8B4
	private void LLONJAFCLML(ONKDCGNBALK JLEJDINFJOF, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 14,
			font = GuiProcessor.IKGFHGKKCPG.rusfont3,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperCenter
		};
		Color black = Color.black;
		if (mkieeeenama.NGABBHKOAHE.MJIHGFHCCMB() == mkieeeenama.CNOLCNDBLJE)
		{
			black = new Color(0.3f, 0f, 0.3f);
		}
		guistyle.normal.textColor = black;
		string text = string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_frac_i"), mkieeeenama.NGABBHKOAHE.BNIHFBMEPAB, mkieeeenama.NGABBHKOAHE.CJNHPHAOEDL(mkieeeenama.CNOLCNDBLJE));
		Rect rect = new Rect(OCHCODJIPHJ.x + 16f, OCHCODJIPHJ.y + 4f, OCHCODJIPHJ.width - 32f, 20f);
		GUI.Label(rect, text, guistyle);
		rect.y += 20f;
		rect.height = 16f;
		guistyle.alignment = TextAnchor.MiddleCenter;
		guistyle.fontSize = 10;
		guistyle.fontStyle = FontStyle.Normal;
		guistyle.normal.textColor = Color.black;
		string text2 = string.Format("{0} / {1}", mkieeeenama.GKCKHINIJPH, mkieeeenama.NGABBHKOAHE.LGGBCHCKJBB(mkieeeenama.CNOLCNDBLJE));
		if (mkieeeenama.NGABBHKOAHE.MJIHGFHCCMB() == mkieeeenama.CNOLCNDBLJE)
		{
			text2 = JNBICAJIJMM.LEBHCLDODNI("gi_frac_max");
		}
		else
		{
			this.renderPBar(rect, (float)mkieeeenama.GKCKHINIJPH, (float)mkieeeenama.NGABBHKOAHE.LGGBCHCKJBB(mkieeeenama.CNOLCNDBLJE), 4, "", true);
		}
		GUI.Label(rect, text2, guistyle);
	}

	// Token: 0x06004FF7 RID: 20471 RVA: 0x00247628 File Offset: 0x00245828
	private void PMAAILHGLKB(JNHLAGHJBAA AGDMAFCKMJP, JNHLAGHJBAA.FPAEEADMCIE AOJKIAFNLAC)
	{
		if (AOJKIAFNLAC != null)
		{
			if (AOJKIAFNLAC.NLIKAGGPANH != null)
			{
				this.selectPerk = (AOJKIAFNLAC.NLIKAGGPANH as NLNNIDBPKAO.JENMPDPJKBG);
				return;
			}
			this.selectPerk = null;
		}
	}

	// Token: 0x06004FF8 RID: 20472 RVA: 0x0024E868 File Offset: 0x0024CA68
	public void ILCLPLPGHIA(HBPNMNGOFMA KADBECGIMPD)
	{
		Debug.Log("delaccconfirm");
		List<ELCMHGJLFOL.FDEPADNCGIF> list = new List<ELCMHGJLFOL.FDEPADNCGIF>();
		KADBECGIMPD.LDLKLPJBIJN();
		KADBECGIMPD.HDBGOLAFOBK();
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			long num = KADBECGIMPD.HHMGLDMFCPF();
			ELCMHGJLFOL.FDEPADNCGIF fdepadncgif = ELCMHGJLFOL.IKGFHGKKCPG.MNJOAIFPFHL(num);
			if (fdepadncgif == null)
			{
				fdepadncgif = new ELCMHGJLFOL.FDEPADNCGIF(num);
				ELCMHGJLFOL.IKGFHGKKCPG.AGNNIJBBAJH(fdepadncgif);
			}
			fdepadncgif.FEEODCOLNIN(KADBECGIMPD);
			list.Add(fdepadncgif);
		}
		if (this.OFNLHPKLHGI != null)
		{
			UnityEngine.Object.Destroy(this.OFNLHPKLHGI);
		}
		this.OFNLHPKLHGI = JDCEFOFMGHB.HMJJPNDEKPP().KCBBLDECKGB("Open openTurnirWindow");
		ArtAllWin component = this.OFNLHPKLHGI.GetComponent<ArtAllWin>();
		if (component != null)
		{
			foreach (ELCMHGJLFOL.FDEPADNCGIF jlfioojljod in list)
			{
				component.NJAEEFLIEKA(jlfioojljod);
			}
			component.myArtelBtn.interactable = false;
			component.createArtelBtn.interactable = true;
			component.applArtelBtn.interactable = false;
		}
	}

	// Token: 0x06004FF9 RID: 20473 RVA: 0x0024E980 File Offset: 0x0024CB80
	private void ACKCODOIBCL()
	{
		string dccpcblodig = "Flap_02.wav";
		bool flag = false;
		EKBAPCMPANI ekbapcmpani = BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH;
		List<OIJEGJLCFCF> list = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.NAFGMKJPLPC;
		if (this.currentSadokId == 0)
		{
			ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(-127, 4);
			list = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.KNFMGIBLMHB;
		}
		int num = 1;
		foreach (OIJEGJLCFCF oijegjlcfcf in list)
		{
			num += oijegjlcfcf.NKHBAJKMAGD;
		}
		if (ekbapcmpani != null && list.Count <= ekbapcmpani.MIMANMPNLPE.NLHKFMMDMMK() && num <= ekbapcmpani.MIMANMPNLPE.NKEOCCKEOCE())
		{
			flag = false;
			string format = JNBICAJIJMM.DBMJJPBOPEK().HEIBEHAEHBM("hair");
			object[] array = new object[5];
			array[1] = list.Count;
			array[1] = ekbapcmpani.EMBKDHKGIEL().NLHKFMMDMMK();
			array[0] = JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)num);
			array[4] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)ekbapcmpani.MIMANMPNLPE.NKEOCCKEOCE());
			dccpcblodig = string.Format(format, array);
		}
		if (flag)
		{
			dccpcblodig = string.Format(JNBICAJIJMM.EKEBHIJMEML().CCFFMKBBKHI("Keeper Strafe Left"), list.Count, JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)num));
		}
		this.BLKAFFPKEBA = flag;
		if (ekbapcmpani == null)
		{
			dccpcblodig = JNBICAJIJMM.DBMJJPBOPEK().HEIBEHAEHBM("drink.wav");
		}
		this.OHIPOCGKHDE.DLNFAELJBGG(dccpcblodig);
	}

	// Token: 0x06004FFA RID: 20474 RVA: 0x0024EB08 File Offset: 0x0024CD08
	private void HCOJACLMGDC(ONKDCGNBALK JMAKEAHMLMI, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		IDCHHHEDHDC.GIONPNFHOOC gionpnfhooc = (IDCHHHEDHDC.GIONPNFHOOC)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -15,
			font = GuiProcessor.PLGADNLAEGN().rusfont3,
			fontStyle = FontStyle.Normal,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperCenter
		};
		float x = OCHCODJIPHJ.x + 821f;
		GUI.Label(new Rect(x, OCHCODJIPHJ.y + 1154f, OCHCODJIPHJ.width, 920f), gionpnfhooc.BGJICMGFOON.HAJNMNALBBI + "Mouse Y" + JLFJEGIPIMM.MHFDIJGJGBJ().GKDPPPKBELC((long)gionpnfhooc.GBOBJLNHPBI), guistyle);
		string text = string.Format(JNBICAJIJMM.CDDCIKKDFMP("CrawlIdle"), "Quest langfile not found!", gionpnfhooc.MGILDBCKBON, gionpnfhooc.LLKDCEPNHOL);
		if (gionpnfhooc.GHGAHDMKJFE == JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.LPFKFNLHGBI)
		{
			guistyle.normal.textColor = new Color(1073f, 764f, 790f);
		}
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		guistyle.fontSize = -52;
		guistyle.fontStyle = FontStyle.Bold;
		GUI.Label(new Rect(x, OCHCODJIPHJ.y + 1585f, OCHCODJIPHJ.width, OCHCODJIPHJ.height - 1840f), text, guistyle);
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.EDKKJNHDBPF().IMCJNFHAFGE(gionpnfhooc.GNCMJMOJAAK);
		befchfngomi.JLCGGFPBOCF();
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 1636f, OCHCODJIPHJ.y + 1949f, 250f, 367f), befchfngomi.CFFHIODOGCH);
	}

	// Token: 0x06004FFB RID: 20475 RVA: 0x0024ECA8 File Offset: 0x0024CEA8
	public void OKEFCLEPLPE(int LPFKFNLHGBI, HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.GMBEHOGPEDI(6, 25f, Vector3.zero);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(this.OJNFLOAOILJ);
		if (onkdcgnbalk == null)
		{
			onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().PLHAGCDJLPA(1533f, 1939f, "http://steamcommunity.com/sharedfiles/filedetails/?id=788064774", false);
		}
		else
		{
			onkdcgnbalk.MPKCOJHJIIB();
		}
		this.OJNFLOAOILJ = onkdcgnbalk.LPFKFNLHGBI;
		int num = -20;
		new EGCAADAABPP(onkdcgnbalk, 594f, 1893f, 1126f, 704f, "_TintColor", 1, null);
		MEMEOHJKPNJ memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, 1395f, (float)num, 1171f, 836f, JNBICAJIJMM.IMLLGEMPHAP().HLBAJBLHLNI(""), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.JIPLBMFECMH));
		memeohjkpnj.HKPAEGGJNGG = (LPFKFNLHGBI == 1);
		memeohjkpnj.KCLLDJJLCGC = 86;
		num += 9;
		MEMEOHJKPNJ memeohjkpnj2 = new MEMEOHJKPNJ(onkdcgnbalk, 252f, (float)num, 1481f, 1890f, JNBICAJIJMM.CLIMNFDGOEG().CKAOHMEKLMH("msg_other"), 5, null, new ONKDCGNBALK.CMMHGMILOIM(this.JIPLBMFECMH));
		memeohjkpnj2.HKPAEGGJNGG = (LPFKFNLHGBI == 0);
		memeohjkpnj2.KCLLDJJLCGC = -92;
		num += 49;
		MEMEOHJKPNJ memeohjkpnj3 = new MEMEOHJKPNJ(onkdcgnbalk, 1507f, (float)num, 410f, 1129f, JNBICAJIJMM.CLIMNFDGOEG().HLBAJBLHLNI("_MainTex"), 5, null, new ONKDCGNBALK.CMMHGMILOIM(this.MKJGPNKJFDL));
		memeohjkpnj3.HKPAEGGJNGG = (LPFKFNLHGBI == 1);
		memeohjkpnj3.KCLLDJJLCGC = 70;
		num += 45;
		MEMEOHJKPNJ memeohjkpnj4 = new MEMEOHJKPNJ(onkdcgnbalk, 1476f, (float)num, 835f, 1439f, JNBICAJIJMM.CLIMNFDGOEG().ECNKLECOKHD("IdleBandage"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(this.MKJGPNKJFDL));
		memeohjkpnj4.HKPAEGGJNGG = (LPFKFNLHGBI == 2);
		memeohjkpnj4.KCLLDJJLCGC = 26;
		num += 14;
		MEMEOHJKPNJ memeohjkpnj5 = new MEMEOHJKPNJ(onkdcgnbalk, 1918f, (float)num, 738f, 1520f, JNBICAJIJMM.IMLLGEMPHAP().CCFFMKBBKHI(""), 115, null, new ONKDCGNBALK.CMMHGMILOIM(this.JIPLBMFECMH));
		memeohjkpnj5.HKPAEGGJNGG = (LPFKFNLHGBI == 78);
		memeohjkpnj5.KCLLDJJLCGC = -9;
		num += -24;
		MEMEOHJKPNJ memeohjkpnj6 = new MEMEOHJKPNJ(onkdcgnbalk, 589f, (float)num, 1961f, 1269f, JNBICAJIJMM.IMLLGEMPHAP().CCFFMKBBKHI("WeaponReadyFire"), 7, null, new ONKDCGNBALK.CMMHGMILOIM(this.MKJGPNKJFDL));
		memeohjkpnj6.HKPAEGGJNGG = (LPFKFNLHGBI == 3);
		memeohjkpnj6.KCLLDJJLCGC = 123;
		num += -119;
		MEMEOHJKPNJ memeohjkpnj7 = new MEMEOHJKPNJ(onkdcgnbalk, 561f, (float)num, 1205f, 385f, JNBICAJIJMM.CLIMNFDGOEG().HEIBEHAEHBM("\n"), 7, null, new ONKDCGNBALK.CMMHGMILOIM(this.infoWinKeyPress));
		memeohjkpnj7.HKPAEGGJNGG = (LPFKFNLHGBI == 1);
		memeohjkpnj7.KCLLDJJLCGC = -113;
		num += 15;
		num += 79;
		MEMEOHJKPNJ memeohjkpnj8 = new MEMEOHJKPNJ(onkdcgnbalk, 1477f, (float)num, 1961f, 1255f, JNBICAJIJMM.EDKGBBIIBBC().GNKIBMGNHNE("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/"), 6, null, null);
		memeohjkpnj8.HKPAEGGJNGG = (LPFKFNLHGBI == 2);
		memeohjkpnj8.FNMCIACNOMH = true;
		memeohjkpnj8.KCLLDJJLCGC = -93;
		memeohjkpnj8.FNMCIACNOMH = false;
		num += 34;
		MEMEOHJKPNJ memeohjkpnj9 = new MEMEOHJKPNJ(onkdcgnbalk, 497f, (float)num, 574f, 514f, JNBICAJIJMM.EEOPOHEALPK().GNKIBMGNHNE("musicVolume"), 8, null, null);
		memeohjkpnj9.HKPAEGGJNGG = (LPFKFNLHGBI == 6);
		memeohjkpnj9.FNMCIACNOMH = false;
		memeohjkpnj9.KCLLDJJLCGC = -126;
		memeohjkpnj9.FNMCIACNOMH = true;
		num += 0;
		MEMEOHJKPNJ memeohjkpnj10 = new MEMEOHJKPNJ(onkdcgnbalk, 1004f, (float)num, 1715f, 729f, JNBICAJIJMM.EDKGBBIIBBC().ECNKLECOKHD("*** PODSEK"), 6, null, null);
		memeohjkpnj10.HKPAEGGJNGG = (LPFKFNLHGBI == 7);
		memeohjkpnj10.FNMCIACNOMH = true;
		memeohjkpnj10.KCLLDJJLCGC = -107;
		memeohjkpnj10.FNMCIACNOMH = false;
		Rect rect = new Rect(1541f, 1650f, onkdcgnbalk.OCHCODJIPHJ.width - 614f, onkdcgnbalk.OCHCODJIPHJ.height - 395f);
		new MGLHIBHDMPC(onkdcgnbalk, rect, this.PaperTexture);
		new EGCAADAABPP(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, "1 Hand Sword Run", 0, null);
		switch (LPFKFNLHGBI)
		{
		case 1:
			this.NGIFLCKKKOK(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 2:
			this.EJNAJEONDOH(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 3:
			this.ONNMFFFGBPD(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 4:
			this.DLOFCKFIEMM(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 7:
			this.ODDMGKHNKNJ(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 8:
			this.GPKFNHGNFNB(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 9:
			this.HJJFFIFIIJD(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		}
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
	}

	// Token: 0x06004FFC RID: 20476 RVA: 0x00247628 File Offset: 0x00245828
	private void PGMNCMDGMAE(JNHLAGHJBAA AGDMAFCKMJP, JNHLAGHJBAA.FPAEEADMCIE AOJKIAFNLAC)
	{
		if (AOJKIAFNLAC != null)
		{
			if (AOJKIAFNLAC.NLIKAGGPANH != null)
			{
				this.selectPerk = (AOJKIAFNLAC.NLIKAGGPANH as NLNNIDBPKAO.JENMPDPJKBG);
				return;
			}
			this.selectPerk = null;
		}
	}

	// Token: 0x06004FFD RID: 20477 RVA: 0x0024F110 File Offset: 0x0024D310
	public void EIELHICJKHO(ONKDCGNBALK OJIMHKHFOJI)
	{
		OJIMHKHFOJI.OCBAOFLJBGP.LMBPNFHKNGA();
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(-35, this.OKFIFPBAAFG);
	}

	// Token: 0x06004FFE RID: 20478 RVA: 0x0024F130 File Offset: 0x0024D330
	public void MMGAMKJDPAA(int LPFKFNLHGBI, HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.CNGKCDLJEDG(4, 1537f, Vector3.zero);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().CHPPAAAAJFC(this.OJNFLOAOILJ);
		if (onkdcgnbalk == null)
		{
			onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.BJFHBPOCELH(488f, 176f, "\n", false);
		}
		else
		{
			onkdcgnbalk.FDDMHPAFDAG();
		}
		this.OJNFLOAOILJ = onkdcgnbalk.LPFKFNLHGBI;
		int num = -101;
		new EGCAADAABPP(onkdcgnbalk, 1522f, 337f, 1300f, 1966f, "Post Process Blur Shader Missing...", 1, null);
		MEMEOHJKPNJ memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, 67f, (float)num, 1489f, 686f, JNBICAJIJMM.EKEBHIJMEML().HLBAJBLHLNI(">"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.infoWinKeyPress));
		memeohjkpnj.HKPAEGGJNGG = (LPFKFNLHGBI == 0);
		memeohjkpnj.KCLLDJJLCGC = 121;
		num += 11;
		MEMEOHJKPNJ memeohjkpnj2 = new MEMEOHJKPNJ(onkdcgnbalk, 105f, (float)num, 1739f, 795f, JNBICAJIJMM.IMLLGEMPHAP().NLJOLOBPCBJ("_Params"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(this.JIPLBMFECMH));
		memeohjkpnj2.HKPAEGGJNGG = (LPFKFNLHGBI == 3);
		memeohjkpnj2.KCLLDJJLCGC = -89;
		num += 11;
		MEMEOHJKPNJ memeohjkpnj3 = new MEMEOHJKPNJ(onkdcgnbalk, 672f, (float)num, 1145f, 261f, JNBICAJIJMM.EKEBHIJMEML().HEIBEHAEHBM("_DepthScale"), 5, null, new ONKDCGNBALK.CMMHGMILOIM(this.MKJGPNKJFDL));
		memeohjkpnj3.HKPAEGGJNGG = (LPFKFNLHGBI == 0);
		memeohjkpnj3.KCLLDJJLCGC = -34;
		num += 42;
		MEMEOHJKPNJ memeohjkpnj4 = new MEMEOHJKPNJ(onkdcgnbalk, 283f, (float)num, 1626f, 1367f, JNBICAJIJMM.IMLLGEMPHAP().ECNKLECOKHD("<color='#003000'>+{0} {1}</color>"), 8, null, new ONKDCGNBALK.CMMHGMILOIM(this.MKJGPNKJFDL));
		memeohjkpnj4.HKPAEGGJNGG = (LPFKFNLHGBI == 7);
		memeohjkpnj4.KCLLDJJLCGC = -95;
		num += 20;
		MEMEOHJKPNJ memeohjkpnj5 = new MEMEOHJKPNJ(onkdcgnbalk, 303f, (float)num, 242f, 1818f, JNBICAJIJMM.EEOPOHEALPK().CCFFMKBBKHI("IdleFeedThrow"), -127, null, new ONKDCGNBALK.CMMHGMILOIM(this.MKJGPNKJFDL));
		memeohjkpnj5.HKPAEGGJNGG = (LPFKFNLHGBI == -3);
		memeohjkpnj5.KCLLDJJLCGC = 8;
		num += 90;
		MEMEOHJKPNJ memeohjkpnj6 = new MEMEOHJKPNJ(onkdcgnbalk, 1993f, (float)num, 1938f, 876f, JNBICAJIJMM.LPHMKPDBMPP().HEIBEHAEHBM(", "), 7, null, new ONKDCGNBALK.CMMHGMILOIM(this.MKJGPNKJFDL));
		memeohjkpnj6.HKPAEGGJNGG = (LPFKFNLHGBI == 1);
		memeohjkpnj6.KCLLDJJLCGC = 26;
		num += 85;
		MEMEOHJKPNJ memeohjkpnj7 = new MEMEOHJKPNJ(onkdcgnbalk, 1907f, (float)num, 430f, 1664f, JNBICAJIJMM.EKEBHIJMEML().NLJOLOBPCBJ("Head stand"), 7, null, new ONKDCGNBALK.CMMHGMILOIM(this.MKJGPNKJFDL));
		memeohjkpnj7.HKPAEGGJNGG = (LPFKFNLHGBI == 2);
		memeohjkpnj7.KCLLDJJLCGC = -51;
		num += 118;
		num += -32;
		MEMEOHJKPNJ memeohjkpnj8 = new MEMEOHJKPNJ(onkdcgnbalk, 1354f, (float)num, 647f, 1041f, JNBICAJIJMM.EEOPOHEALPK().DOEMGEAEBPN(": "), 5, null, null);
		memeohjkpnj8.HKPAEGGJNGG = (LPFKFNLHGBI == 5);
		memeohjkpnj8.FNMCIACNOMH = false;
		memeohjkpnj8.KCLLDJJLCGC = 61;
		memeohjkpnj8.FNMCIACNOMH = true;
		num += 70;
		MEMEOHJKPNJ memeohjkpnj9 = new MEMEOHJKPNJ(onkdcgnbalk, 607f, (float)num, 887f, 1992f, JNBICAJIJMM.EDKGBBIIBBC().NLJOLOBPCBJ("Sound #"), 7, null, null);
		memeohjkpnj9.HKPAEGGJNGG = (LPFKFNLHGBI == 0);
		memeohjkpnj9.FNMCIACNOMH = false;
		memeohjkpnj9.KCLLDJJLCGC = -118;
		memeohjkpnj9.FNMCIACNOMH = true;
		num += 34;
		MEMEOHJKPNJ memeohjkpnj10 = new MEMEOHJKPNJ(onkdcgnbalk, 937f, (float)num, 1638f, 1963f, JNBICAJIJMM.EEOPOHEALPK().ECNKLECOKHD("GiantGrabIdle"), 7, null, null);
		memeohjkpnj10.HKPAEGGJNGG = (LPFKFNLHGBI == 3);
		memeohjkpnj10.FNMCIACNOMH = true;
		memeohjkpnj10.KCLLDJJLCGC = -116;
		memeohjkpnj10.FNMCIACNOMH = false;
		Rect rect = new Rect(1453f, 1796f, onkdcgnbalk.OCHCODJIPHJ.width - 1640f, onkdcgnbalk.OCHCODJIPHJ.height - 1893f);
		new MGLHIBHDMPC(onkdcgnbalk, rect, this.PaperTexture);
		new EGCAADAABPP(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, "offsets", 0, null);
		switch (LPFKFNLHGBI)
		{
		case 0:
			this.HIJHNGLFMHB(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 1:
			this.ADGGPAJAOLD(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 2:
			this.ONNMFFFGBPD(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 3:
			this.MKEFMOADNMD(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 6:
			this.BIKOHGBJIPN(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 7:
			this.CMNKNPKIMOH(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 8:
			this.openAchivesWin(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		}
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = false;
	}

	// Token: 0x06004FFF RID: 20479 RVA: 0x0024F598 File Offset: 0x0024D798
	private void HHNPMJIDKLE(ONKDCGNBALK ONPHLHKAGFP)
	{
		OIJEGJLCFCF dolfjggbdjf = this.DOLFJGGBDJF;
		if (dolfjggbdjf == null)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.NAFGMKJPLPC.Remove(dolfjggbdjf);
			this.OJJLLBKEGNO.LACAJHOHACK.Remove(dolfjggbdjf);
			this.OJJLLBKEGNO.JOJGBLLMGPF();
			this.DBELGCHKMOE.LACAJHOHACK.Add(dolfjggbdjf);
			this.DBELGCHKMOE.JOJGBLLMGPF();
			epmphjgalbe.ENDMKPCFKND(this.currentHolodId);
			epmphjgalbe.AAHBHCMKGJD(dolfjggbdjf.LPFKFNLHGBI);
			NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(-160, epmphjgalbe.NNEAJJNCGMK());
		}
		finally
		{
			epmphjgalbe.NCKMEIBFNGL();
		}
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("NOISE_OFF", 226f);
		this.HPICBMCMAEC();
		this.OAGIEPJBMPH();
	}

	// Token: 0x06005000 RID: 20480 RVA: 0x0024F66C File Offset: 0x0024D86C
	public void PBPBJCBDMMC(ONKDCGNBALK ONPHLHKAGFP)
	{
		if (JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.KLGLOCMOHAG >= JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.JGIHLJKDMKM)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(44, -1);
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("Giant Grab Throw", 1582f);
			return;
		}
		if (!this.selectPerk.ODBICLOCIMO)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("dd/MM/yyyy HH:mm", 969f);
			return;
		}
		if (this.selectPerk == null)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("RunningDance", 62f);
			return;
		}
		int num = (int)JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.MHIIBKILGBL("  ");
		if (this.selectPerk.LPFKFNLHGBI != num)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(178, this.selectPerk.LPFKFNLHGBI);
			return;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("", 872f);
	}

	// Token: 0x06005001 RID: 20481 RVA: 0x0024F750 File Offset: 0x0024D950
	public void FENCOFEDOMD(ONKDCGNBALK ONPHLHKAGFP)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("post_msg5", 1200f);
		int dnhbpgoklkd = (int)ONPHLHKAGFP.ODFEKBJCFMN;
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = true;
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(144, dnhbpgoklkd);
		NJMHLCGIAJI.IKGFHGKKCPG.GDNKCAOHEPL(79, "offsets");
	}

	// Token: 0x06005002 RID: 20482 RVA: 0x0024F7A5 File Offset: 0x0024D9A5
	private void JMNLEBAPHNJ()
	{
		if (GameInterface.getI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		HPGKIJLKCIH.IKGFHGKKCPG.LMCJCGGBCBF();
		GameInterface.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		CKNLPGEPGGF.IKGFHGKKCPG.MOPEECLGJIL();
	}

	// Token: 0x06005003 RID: 20483 RVA: 0x0024F7E5 File Offset: 0x0024D9E5
	private void GGGJBMICKIJ(ONKDCGNBALK ONPHLHKAGFP)
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MPNJKJKDMLK = ((KLIKIJOLPPJ)ONPHLHKAGFP).FPAMHHEFGDO();
	}

	// Token: 0x06005004 RID: 20484 RVA: 0x00247628 File Offset: 0x00245828
	private void FJJKDFOGPOM(JNHLAGHJBAA AGDMAFCKMJP, JNHLAGHJBAA.FPAEEADMCIE AOJKIAFNLAC)
	{
		if (AOJKIAFNLAC != null)
		{
			if (AOJKIAFNLAC.NLIKAGGPANH != null)
			{
				this.selectPerk = (AOJKIAFNLAC.NLIKAGGPANH as NLNNIDBPKAO.JENMPDPJKBG);
				return;
			}
			this.selectPerk = null;
		}
	}

	// Token: 0x06005005 RID: 20485 RVA: 0x0024F7FC File Offset: 0x0024D9FC
	private void GOPKOPLMFPN(ONKDCGNBALK ONPHLHKAGFP, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 16,
			font = GuiProcessor.IKGFHGKKCPG.rusfont3,
			fontStyle = FontStyle.Bold,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperLeft
		};
		float x = OCHCODJIPHJ.x + 15f;
		GUI.Label(new Rect(x, OCHCODJIPHJ.y + 2f, OCHCODJIPHJ.width, 22f), gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI, guistyle);
		string text = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_fs_itm"), gdemcacnpng.JFDDNMCENAK, JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(gdemcacnpng.GJCNMJJJDGO), JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO(gdemcacnpng.FMKDOFCJCOP));
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		guistyle.fontSize = 14;
		guistyle.fontStyle = FontStyle.Normal;
		GUI.Label(new Rect(x, OCHCODJIPHJ.y + 25f, OCHCODJIPHJ.width, OCHCODJIPHJ.height - 30f), text, guistyle);
		Rect position = new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 48f - 10f, OCHCODJIPHJ.y, 48f, 48f);
		int clcbhhlllfn = gdemcacnpng.CLCBHHLLLFN;
		GUI.DrawTextureWithTexCoords(position, this.VenokTexture, JDCEFOFMGHB.IKGFHGKKCPG.ODFOOIPOAJB(clcbhhlllfn, 4, 1), true);
		position.y += 12f;
		guistyle.fontSize = 10;
		guistyle.alignment = TextAnchor.LowerCenter;
		if (gdemcacnpng.IKKEIHEPDPN > 1f || gdemcacnpng.CLCBHHLLLFN > 0)
		{
			float num = gdemcacnpng.IKKEIHEPDPN / 100f;
			GUI.Label(position, string.Format("{0:0.0%}", num), guistyle);
		}
	}

	// Token: 0x06005006 RID: 20486 RVA: 0x0024F9CC File Offset: 0x0024DBCC
	public void OpenHolod(HBPNMNGOFMA KADBECGIMPD)
	{
		this.currentHolodId = KADBECGIMPD.HDBGOLAFOBK();
		this.holodFreeCell = KADBECGIMPD.HDBGOLAFOBK();
		if (this.CBJBOCGAEKC != 0)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(this.CBJBOCGAEKC);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(952f, 505f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_fridge"), true);
		this.CBJBOCGAEKC = onkdcgnbalk.LPFKFNLHGBI;
		this.OJJLLBKEGNO = new MMKFAENBHKD(onkdcgnbalk, 20f, 70f, 380f, onkdcgnbalk.OCHCODJIPHJ.height - 100f, 0);
		foreach (OIJEGJLCFCF item in JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC)
		{
			this.OJJLLBKEGNO.LACAJHOHACK.Add(item);
		}
		this.OJJLLBKEGNO.IHEILFHMLAG = this.OJJLLBKEGNO.LACAJHOHACK.Count - 1;
		this.OJJLLBKEGNO.MPMFNJEJAHJ();
		this.OJJLLBKEGNO.JHNCNHAAJCH = 48f;
		this.OHIPOCGKHDE = new LCOLJOPGDLL(onkdcgnbalk, 20f, 50f, 400f, 20f, "---", TextAnchor.UpperLeft, Color.gray)
		{
			LNDPBNODFPE = true
		};
		this.CINAIMICJGM = new LCOLJOPGDLL(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 20f - 380f, 50f, 400f, 20f, "---", TextAnchor.UpperLeft, Color.gray)
		{
			LNDPBNODFPE = true
		};
		this.AFEHNJCCJAF();
		this.DBELGCHKMOE = new MMKFAENBHKD(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 20f - 380f, 70f, 380f, onkdcgnbalk.OCHCODJIPHJ.height - 100f, 0);
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			OIJEGJLCFCF oijegjlcfcf = new OIJEGJLCFCF();
			oijegjlcfcf.LIMJEKJAILL(KADBECGIMPD);
			this.DBELGCHKMOE.LACAJHOHACK.Add(oijegjlcfcf);
		}
		this.DBELGCHKMOE.IHEILFHMLAG = this.OJJLLBKEGNO.LACAJHOHACK.Count - 1;
		this.DBELGCHKMOE.MPMFNJEJAHJ();
		this.DBELGCHKMOE.JHNCNHAAJCH = 48f;
		this.FFOKGLLHNPF();
		new HKIEEHBCMNJ(onkdcgnbalk, 412f, 70f, 1, this.bigKeysTexture, 2, 6, 0, new ONKDCGNBALK.CMMHGMILOIM(this.HolodKeyPress));
		new HKIEEHBCMNJ(onkdcgnbalk, 412f, 110f, 2, this.bigKeysTexture, 2, 6, 2, new ONKDCGNBALK.CMMHGMILOIM(this.HolodKeyPress));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 64f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("close"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
	}

	// Token: 0x06005007 RID: 20487 RVA: 0x0024FCC4 File Offset: 0x0024DEC4
	public void OnPostFishWin(ONKDCGNBALK JMAKEAHMLMI)
	{
		if (Input.GetKey(KeyCode.Space) && !this.BLKAFFPKEBA)
		{
			this.endShowFish();
			this.getFish(JMAKEAHMLMI.LPFKFNLHGBI, false);
		}
		if (Input.GetKey(KeyCode.J))
		{
			this.endShowFish();
			this.releaseFish(JMAKEAHMLMI.LPFKFNLHGBI);
		}
	}

	// Token: 0x06005008 RID: 20488 RVA: 0x0024FD10 File Offset: 0x0024DF10
	public void OIGCNADEHGB(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		JNHLAGHJBAA jnhlaghjbaa = new JNHLAGHJBAA(JMAKEAHMLMI, PHEMLBHMNCM.x + 1783f, PHEMLBHMNCM.y + 260f, PHEMLBHMNCM.width - 105f, PHEMLBHMNCM.height - 926f, 1)
		{
			JHNCNHAAJCH = 117f,
			KCLLDJJLCGC = -15
		};
		jnhlaghjbaa.GIOGEHKMKDE = false;
		jnhlaghjbaa.JKAOKBNCDFK = Color.black;
		jnhlaghjbaa.ABMDIOIJALO = new Color(495f, 730f, 991f);
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.EEOPOHEALPK().JPEDCGHDNPN("_FinalBlendParameters", false));
		GameInterface.NCGJANCMLPO(jnhlaghjbaa.EELDHNFBFOE, xmlDocument.SelectNodes(""));
		while (!KADBECGIMPD.INLBHLOLOJH())
		{
			int lpfkfnlhgbi = KADBECGIMPD.CLPEKGGAMAI();
			NHCAOFIKNFE.IOPMLIFDBKO iopmlifdbko = NHCAOFIKNFE.IKGFHGKKCPG.JOAMONKNOMK(lpfkfnlhgbi);
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = jnhlaghjbaa.KNILKDJMDHO((long)iopmlifdbko.GCLKLEIMABA);
			if (fpaeeadmcie != null)
			{
				fpaeeadmcie.APKJANCLGFN(iopmlifdbko, (long)iopmlifdbko.JFHBDBHIOII);
			}
			else
			{
				jnhlaghjbaa.EELDHNFBFOE.NOLKFNDMNPO(iopmlifdbko, (long)iopmlifdbko.JFHBDBHIOII);
			}
		}
		jnhlaghjbaa.KICNPBJIJDF();
		jnhlaghjbaa.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.MDFHBNBMKOP);
		Rect rect = new Rect(jnhlaghjbaa.OCHCODJIPHJ.x - 1342f, jnhlaghjbaa.OCHCODJIPHJ.y + jnhlaghjbaa.OCHCODJIPHJ.height + 1310f, jnhlaghjbaa.OCHCODJIPHJ.width + 994f, 1818f);
		new EGCAADAABPP(JMAKEAHMLMI, rect.x, rect.y, rect.width, rect.height, "", 1, this.simpleGray);
		this.LCMCOGOGHPL = new LCOLJOPGDLL(JMAKEAHMLMI, rect.x + 998f, rect.y + 423f, rect.width, rect.height / 588f, "KatanaReadyLow", TextAnchor.UpperCenter, new Color(72f, 1156f, 681f))
		{
			DFIGKKMMIAF = 18
		};
		this.LCMCOGOGHPL.NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.AICEFGKCNII);
		this.IKFFNBOCGFL = new LCOLJOPGDLL(JMAKEAHMLMI, rect.x + 667f, rect.y + 415f, rect.width, rect.height - 1881f, "_Vibrance", TextAnchor.UpperCenter, Color.white)
		{
			LNDPBNODFPE = false,
			DFIGKKMMIAF = -47
		};
		this.OKFIFPBAAFG = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.HKHMIIEIFNG;
		jnhlaghjbaa.HNNJNDNOHLP = jnhlaghjbaa.KNILKDJMDHO((long)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HKHMIIEIFNG);
		this.FJOABFJFMEP = new MEMEOHJKPNJ(JMAKEAHMLMI, rect.x + rect.width - 1992f, rect.y + rect.height - 301f, 798f, 1141f, JNBICAJIJMM.DCEBAJIILPC("IdleReadyLook"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.FACEDOKJEPP));
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = false;
	}

	// Token: 0x06005009 RID: 20489 RVA: 0x00250014 File Offset: 0x0024E214
	public void OnPerkBoxPostRender(ONKDCGNBALK ONPHLHKAGFP)
	{
		int num = (int)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MHIIBKILGBL("teech_perk");
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 16,
			font = GuiProcessor.IKGFHGKKCPG.rusfont3,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.MiddleCenter
		};
		if (num > 0)
		{
			NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.PKJMLDMLFCM(num);
			if (jenmpdpjkbg != null)
			{
				guistyle.alignment = TextAnchor.UpperLeft;
				GUI.DrawTexture(new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 5f, ONPHLHKAGFP.OCHCODJIPHJ.y + 5f, 56f, 56f), jenmpdpjkbg.BDHHPAEHFHG.KMIIGKECOEB());
				guistyle.fontStyle = FontStyle.Bold;
				string str = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_um_lv"), jenmpdpjkbg.JAGMEPMLCCP);
				if (jenmpdpjkbg.JAGMEPMLCCP == 0)
				{
					str = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_um_nt");
				}
				if (jenmpdpjkbg.JAGMEPMLCCP == 5)
				{
					str = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_um_mx");
				}
				GUI.Label(new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 66f, ONPHLHKAGFP.OCHCODJIPHJ.y + 10f, 300f, 20f), jenmpdpjkbg.BDHHPAEHFHG.KKEBDLGHBMN + str, guistyle);
				guistyle.fontStyle = FontStyle.Normal;
				guistyle.fontSize = 12;
				guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
				string text = jenmpdpjkbg.BDHHPAEHFHG.PAALJNAKJEG;
				int num2 = jenmpdpjkbg.JAGMEPMLCCP + 1;
				if (num2 > 5)
				{
					num2 = 5;
				}
				text = text.Replace("{x}", string.Concat(jenmpdpjkbg.BDHHPAEHFHG.DCCPCBLODIG.LNEPKLKELMI * (double)num2));
				text = text.Replace("{y}", string.Concat(jenmpdpjkbg.BDHHPAEHFHG.DCCPCBLODIG.NMKCBJKHBOH * (double)num2));
				text = text.Replace("{z}", string.Concat(jenmpdpjkbg.BDHHPAEHFHG.DCCPCBLODIG.NKGGAFLBFDF * (double)num2));
				GUI.Label(new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 66f, ONPHLHKAGFP.OCHCODJIPHJ.y + 30f, 300f, 20f), text, guistyle);
				this.renderPBar(new Rect(ONPHLHKAGFP.OCHCODJIPHJ.x + 66f, ONPHLHKAGFP.OCHCODJIPHJ.y + 45f, ONPHLHKAGFP.OCHCODJIPHJ.width - 80f, 20f), jenmpdpjkbg.KLPANBANBDI, (float)jenmpdpjkbg.GNNDLEAFCND, 4, string.Format("{0}/{1}", Mathf.FloorToInt(jenmpdpjkbg.KLPANBANBDI), jenmpdpjkbg.GNNDLEAFCND), true);
				return;
			}
		}
		else
		{
			GUI.Label(ONPHLHKAGFP.OCHCODJIPHJ, JNBICAJIJMM.LEBHCLDODNI("gi_um_nosel"), guistyle);
		}
	}

	// Token: 0x0600500A RID: 20490 RVA: 0x002502FC File Offset: 0x0024E4FC
	public void NEDHEMELGCD(ONKDCGNBALK JMAKEAHMLMI)
	{
		if (Input.GetKey(KeyCode.Backslash) && !this.BLKAFFPKEBA)
		{
			this.GEDNGIDHBHD();
			this.BOGPHBNCEDP(JMAKEAHMLMI.LPFKFNLHGBI, false);
		}
		if (Input.GetKey(KeyCode.Less))
		{
			this.endShowFish();
			this.FFPPJGCJHBF(JMAKEAHMLMI.LPFKFNLHGBI);
		}
	}

	// Token: 0x0600500B RID: 20491 RVA: 0x00250348 File Offset: 0x0024E548
	public void titulKeyPress(ONKDCGNBALK OJIMHKHFOJI)
	{
		OJIMHKHFOJI.OCBAOFLJBGP.LMBPNFHKNGA();
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(102, this.OKFIFPBAAFG);
	}

	// Token: 0x0600500C RID: 20492 RVA: 0x00250368 File Offset: 0x0024E568
	private void DOAEGLOBFCD()
	{
		string dccpcblodig = "{0:f2}";
		bool flag = true;
		EKBAPCMPANI ekbapcmpani = BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH;
		List<OIJEGJLCFCF> list = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.NAFGMKJPLPC;
		if (this.currentSadokId == 1)
		{
			ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.KIFEKEONBOL(-23, 2);
			list = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.KNFMGIBLMHB;
		}
		int num = 1;
		foreach (OIJEGJLCFCF oijegjlcfcf in list)
		{
			num += oijegjlcfcf.NKHBAJKMAGD;
		}
		if (ekbapcmpani != null && list.Count <= ekbapcmpani.EMBKDHKGIEL().ICJDPPOJINN && num <= ekbapcmpani.MIMANMPNLPE.IBEIBAHKIAH)
		{
			flag = false;
			string format = JNBICAJIJMM.CLIMNFDGOEG().ECNKLECOKHD("http://www.root-motion.com/finalikdox/html/page11.html");
			object[] array = new object[8];
			array[1] = list.Count;
			array[1] = ekbapcmpani.MIMANMPNLPE.ICJDPPOJINN;
			array[5] = JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)num);
			array[4] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)ekbapcmpani.MIMANMPNLPE.KEHIFGILLJA());
			dccpcblodig = string.Format(format, array);
		}
		if (flag)
		{
			dccpcblodig = string.Format(JNBICAJIJMM.APMJBBDBOJO().GNKIBMGNHNE("SwimFreestyle"), list.Count, JLFJEGIPIMM.NNEAHAFBOHC().BNIINPDAMAO((long)num));
		}
		this.BLKAFFPKEBA = flag;
		if (ekbapcmpani == null)
		{
			dccpcblodig = JNBICAJIJMM.IKGFHGKKCPG.ECNKLECOKHD("#FF4040");
		}
		this.OHIPOCGKHDE.JCLMALMIBIO(dccpcblodig);
	}

	// Token: 0x0600500D RID: 20493 RVA: 0x002504F0 File Offset: 0x0024E6F0
	public void HJJFFIFIIJD(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(JMAKEAHMLMI, PHEMLBHMNCM.x + 1413f, PHEMLBHMNCM.y + 651f, PHEMLBHMNCM.width - 344f, PHEMLBHMNCM.height - 1551f, 1)
		{
			JHNCNHAAJCH = 1273f
		};
		mmkfaenbhkd.KPLMFNIFPMM = true;
		while (!KADBECGIMPD.INLBHLOLOJH())
		{
			mmkfaenbhkd.LACAJHOHACK.Add(new DODHLMFHFNL.KPPFPHMJPFE(KADBECGIMPD));
		}
		mmkfaenbhkd.KCLLDJJLCGC = -88;
		mmkfaenbhkd.GENPNFMLHED();
		mmkfaenbhkd.IIBCAICFEEF(0);
	}

	// Token: 0x0600500E RID: 20494 RVA: 0x0025057B File Offset: 0x0024E77B
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.J) && JDCEFOFMGHB.IKGFHGKKCPG.HILJENLHLDE(this.sadokWinId) != null && this.CODAIBGMFCA != null)
		{
			this.releaseFromSadok();
		}
	}

	// Token: 0x0600500F RID: 20495 RVA: 0x002505A8 File Offset: 0x0024E7A8
	private static void OFJODEMEDIL(JNHLAGHJBAA.FPAEEADMCIE KAOKEJPBAHM, XmlNodeList OPEKKKOEIKC)
	{
		foreach (object obj in OPEKKKOEIKC)
		{
			XmlNode xmlNode = (XmlNode)obj;
			if (xmlNode.Attributes != null)
			{
				int num = int.Parse(xmlNode.Attributes[""].Value);
				string value = xmlNode.Attributes["to channel = "].Value;
				GameInterface.HPNMCNHFODM(KAOKEJPBAHM.CGPJECOPFOG(value, (long)num), xmlNode.SelectNodes(" "));
			}
		}
	}

	// Token: 0x06005010 RID: 20496 RVA: 0x0025064C File Offset: 0x0024E84C
	public void HIJHNGLFMHB(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH;
		Color color = Color.black;
		int num = 28;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + PHEMLBHMNCM.width - 331f, PHEMLBHMNCM.y + (float)num - 1775f, 399f, 1750f, string.Concat(kfhelhglnmh.CCCPNHIJJOP), TextAnchor.UpperRight, Color.gray);
		lcoljopgdll.LNDPBNODFPE = false;
		lcoljopgdll.HKMFEIMFMAI(Color.gray);
		lcoljopgdll.DFIGKKMMIAF = 42;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1702f, PHEMLBHMNCM.y + (float)num, kfhelhglnmh.BNIHFBMEPAB, false);
		lcoljopgdll2.COMKBPKOCIO(Color.black);
		lcoljopgdll2.DFIGKKMMIAF = 24;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		num += 92;
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 187f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.PPNKMDJBMLP("\n"), kfhelhglnmh.CNOLCNDBLJE, JLFJEGIPIMM.MHFDIJGJGBJ().LCMJJJLLPGA(kfhelhglnmh.OJDEJEJMNKD)), true);
		lcoljopgdll3.LIFOLOPHEPH(Color.black);
		lcoljopgdll3.DFIGKKMMIAF = -4;
		num += -11;
		int num2 = 0 + ObscuredInt.LBDMFALMOLD(kfhelhglnmh.PGEDLDMLBBE) / -68;
		string str;
		if (ObscuredInt.GOOIABGKMHK(kfhelhglnmh.PGEDLDMLBBE) != ObscuredInt.LBDMFALMOLD(kfhelhglnmh.ELBKLOECINC))
		{
			str = string.Format("Level: ", ObscuredInt.GOOIABGKMHK(kfhelhglnmh.ELBKLOECINC) - ObscuredInt.GOOIABGKMHK(kfhelhglnmh.PGEDLDMLBBE), kfhelhglnmh.ELBKLOECINC);
		}
		else
		{
			str = "time";
		}
		color = ((num2 > 0) ? new Color(601f, 413f, 383f) : new Color(1691f, 588f, 213f));
		LCOLJOPGDLL lcoljopgdll4 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 37f, PHEMLBHMNCM.y + (float)num + 1405f, JNBICAJIJMM.CDDCIKKDFMP("wpn_rem2"), true);
		lcoljopgdll4.JJOIHBLMFNE(new Color(879f, 229f, 792f));
		lcoljopgdll4.DFIGKKMMIAF = 37;
		new FNFPGPBCIGK(JMAKEAHMLMI, PHEMLBHMNCM.x + 109f, PHEMLBHMNCM.y + (float)num + 1205f, 1, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, 5, 3, 0, new ONKDCGNBALK.CMMHGMILOIM(this.press_param)).FNMCIACNOMH = (kfhelhglnmh.CCCPNHIJJOP < num2);
		LCOLJOPGDLL lcoljopgdll5 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1360f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.CDDCIKKDFMP("Flares"), kfhelhglnmh.PGEDLDMLBBE) + str, false, color);
		lcoljopgdll5.DFIGKKMMIAF = 73;
		lcoljopgdll5.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		num += -63;
		if (ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.FLHJLFHELPE) != ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.EDICLBDIPGG))
		{
			str = string.Format("_Opacity", ObscuredInt.LBDMFALMOLD(kfhelhglnmh.EDICLBDIPGG) - ObscuredInt.LBDMFALMOLD(kfhelhglnmh.FLHJLFHELPE), kfhelhglnmh.EDICLBDIPGG);
		}
		else
		{
			str = " гр ";
		}
		num2 = 0 + ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.FLHJLFHELPE) / 4;
		LCOLJOPGDLL lcoljopgdll6 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1169f, PHEMLBHMNCM.y + (float)num + 1393f, JNBICAJIJMM.DCEBAJIILPC("SoccerWalk"), true);
		lcoljopgdll6.JJDELGHAKBP(new Color(84f, 1810f, 1537f));
		lcoljopgdll6.DFIGKKMMIAF = 108;
		color = ((num2 > 0) ? new Color(360f, 1967f, 1308f) : new Color(948f, 1665f, 1344f));
		LCOLJOPGDLL lcoljopgdll7 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 658f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.DCEBAJIILPC("wpn_tank1"), kfhelhglnmh.FLHJLFHELPE) + str, true, color);
		lcoljopgdll7.CALCPHKKDMO(color);
		lcoljopgdll7.DFIGKKMMIAF = -25;
		lcoljopgdll7.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		new FNFPGPBCIGK(JMAKEAHMLMI, PHEMLBHMNCM.x + 991f, PHEMLBHMNCM.y + (float)num + 1356f, 5, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, 5, 2, 1, new ONKDCGNBALK.CMMHGMILOIM(this.NNLCCLIBECP)).FNMCIACNOMH = (kfhelhglnmh.CCCPNHIJJOP >= num2);
		num += -110;
		if (ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.JOMLIJFFFDE) != ObscuredInt.GOOIABGKMHK(kfhelhglnmh.PIHKKCBCNHO))
		{
			str = string.Format("The root node, the left thigh and the right thigh bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left thigh and the right thigh bones. This might cause unwanted behaviour like the hip turning upside down when pulled by an effector.Please set the root node bone to be one of the higher bones in the spine.", ObscuredInt.LBDMFALMOLD(kfhelhglnmh.PIHKKCBCNHO) - ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.JOMLIJFFFDE), kfhelhglnmh.PIHKKCBCNHO);
		}
		else
		{
			str = "auk_wcnt";
		}
		num2 = 1 + ObscuredInt.DGOCFCFPKPI(kfhelhglnmh.JOMLIJFFFDE) / -59;
		color = ((num2 > 1) ? new Color(1486f, 1798f, 997f) : new Color(868f, 1797f, 585f));
		LCOLJOPGDLL lcoljopgdll8 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1209f, PHEMLBHMNCM.y + (float)num + 298f, JNBICAJIJMM.PPNKMDJBMLP("Horizontal"), true);
		lcoljopgdll8.PDCJMCLDNBA(new Color(1010f, 1911f, 608f));
		lcoljopgdll8.DFIGKKMMIAF = 87;
		LCOLJOPGDLL lcoljopgdll9 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 999f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.PGJCPFNJNPM("WorkerPickaxe"), kfhelhglnmh.JOMLIJFFFDE) + str, true, color);
		lcoljopgdll9.BMGMCLKBMAB(color);
		lcoljopgdll9.DFIGKKMMIAF = -11;
		lcoljopgdll9.HOBLHFPJKFA = GuiProcessor.NKOEAPCIBKO().rusfont2;
		new FNFPGPBCIGK(JMAKEAHMLMI, PHEMLBHMNCM.x + 1766f, PHEMLBHMNCM.y + (float)num + 158f, 8, GuiProcessor.NKOEAPCIBKO().SmallKeyAthlas, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, 6, 7, 1, new ONKDCGNBALK.CMMHGMILOIM(this.press_param)).FNMCIACNOMH = (kfhelhglnmh.CCCPNHIJJOP >= num2);
		num += 116;
		if (ObscuredInt.GOOIABGKMHK(kfhelhglnmh.LFMMMBOLJCL) != ObscuredInt.LBDMFALMOLD(kfhelhglnmh.FJAIPNCKOKK))
		{
			str = string.Format("UpHillWalkHandGrab", ObscuredInt.LBDMFALMOLD(kfhelhglnmh.FJAIPNCKOKK) - ObscuredInt.GOOIABGKMHK(kfhelhglnmh.LFMMMBOLJCL), kfhelhglnmh.FJAIPNCKOKK);
		}
		else
		{
			str = "' that does not excist in the Node Chain.";
		}
		num2 = 1 + ObscuredInt.LBDMFALMOLD(kfhelhglnmh.LFMMMBOLJCL) / 101;
		color = ((num2 > 0) ? new Color(475f, 563f, 1381f) : new Color(239f, 406f, 432f));
		LCOLJOPGDLL lcoljopgdll10 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1822f, PHEMLBHMNCM.y + (float)num + 859f, JNBICAJIJMM.DIOJFJMOPJO("VRIK needs a Humanoid Animator to auto-detect biped references. Please assign references manually."), false);
		lcoljopgdll10.GDFICJKDCDO(new Color(512f, 1322f, 125f));
		lcoljopgdll10.DFIGKKMMIAF = -89;
		LCOLJOPGDLL lcoljopgdll11 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1282f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.DIOJFJMOPJO("ShootWireframeModule"), kfhelhglnmh.LFMMMBOLJCL) + str, true, color);
		lcoljopgdll11.DLCECAKHLDD(color);
		lcoljopgdll11.DFIGKKMMIAF = 42;
		lcoljopgdll11.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		new FNFPGPBCIGK(JMAKEAHMLMI, PHEMLBHMNCM.x + 1673f, PHEMLBHMNCM.y + (float)num + 583f, 0, GuiProcessor.BBLINJLBAIL().SmallKeyAthlas, GuiProcessor.PLGADNLAEGN().SmallKeyAthlas, 0, 1, 1, new ONKDCGNBALK.CMMHGMILOIM(this.press_param)).FNMCIACNOMH = (kfhelhglnmh.CCCPNHIJJOP < num2);
		num += -113;
		num += -35;
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL() != null)
		{
			LCOLJOPGDLL lcoljopgdll12 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1286f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.DIOJFJMOPJO("{not_found}"), JLFJEGIPIMM.NNEAHAFBOHC().PEGPHIOEKHI(BOIKJDICEMF.IKGFHGKKCPG.PGHPFFNILCD() * 713f)), true);
			lcoljopgdll12.JJOIHBLMFNE(Color.black);
			lcoljopgdll12.DFIGKKMMIAF = -47;
			num += 112;
			LCOLJOPGDLL lcoljopgdll13 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 409f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("pricePt"), JLFJEGIPIMM.MHFDIJGJGBJ().DIOCHACFPHJ(BOIKJDICEMF.IKGFHGKKCPG.AFGBIBMHOAI)), true);
			lcoljopgdll13.JJOIHBLMFNE(Color.black);
			lcoljopgdll13.DFIGKKMMIAF = -106;
			num += 26;
		}
		LCOLJOPGDLL lcoljopgdll14 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 436f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.CELEPPAEKAB("S"), JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC((double)(kfhelhglnmh.JACELJHFHNN * 1338f))), false);
		lcoljopgdll14.CALCPHKKDMO(Color.black);
		lcoljopgdll14.DFIGKKMMIAF = -126;
		num += 87;
		LCOLJOPGDLL lcoljopgdll15 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1480f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.PGJCPFNJNPM("IdleBandage"), JLFJEGIPIMM.IKGFHGKKCPG.AHEHNKFHGOC((double)(kfhelhglnmh.GGDJKCPNPPI * 1553f))), true);
		lcoljopgdll15.IJBDFDFDIPJ(Color.black);
		lcoljopgdll15.DFIGKKMMIAF = -11;
		num += -128;
		LCOLJOPGDLL lcoljopgdll16 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 455f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("WallSit"), JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC((double)(kfhelhglnmh.PBLCJCLFFAL * 1989f))), true);
		lcoljopgdll16.EBMGNGGPGLG(Color.black);
		lcoljopgdll16.DFIGKKMMIAF = -37;
		num += -115;
		LCOLJOPGDLL lcoljopgdll17 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 22f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.BDKHMOOFHHK("ldGo not found"), JLFJEGIPIMM.NNEAHAFBOHC().AHEHNKFHGOC((double)kfhelhglnmh.BCINOMMOKJE), kfhelhglnmh.GPPPGBLEKMF), true);
		lcoljopgdll17.CKMAIBLGPHC(Color.black);
		lcoljopgdll17.DFIGKKMMIAF = -71;
		num += -46;
		LCOLJOPGDLL lcoljopgdll18 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 535f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.CELEPPAEKAB("?"), JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC((double)kfhelhglnmh.GCLLMNHFMND), kfhelhglnmh.MOPMCAMIENJ), true);
		lcoljopgdll18.MOFACMDBGEB(Color.black);
		lcoljopgdll18.DFIGKKMMIAF = 2;
		num += 112;
		LCOLJOPGDLL lcoljopgdll19 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1447f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.CDDCIKKDFMP("FBBIKSettings is deprecated, you can now edit all the settings from the custom inspector of the FullBodyBipedIK component."), JLFJEGIPIMM.NNEAHAFBOHC().AHEHNKFHGOC((double)kfhelhglnmh.PMOJDCHIAHE), kfhelhglnmh.LJOPDPNIAEG), true);
		lcoljopgdll19.GABBMJPJAOO(Color.black);
		lcoljopgdll19.DFIGKKMMIAF = 99;
		num += 93;
		LCOLJOPGDLL lcoljopgdll20 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 624f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.PGJCPFNJNPM("<color='#a0ff60'>"), JLFJEGIPIMM.IKGFHGKKCPG.AHEHNKFHGOC((double)kfhelhglnmh.AJHDDHHOHAC), kfhelhglnmh.JONKLLMGCIF), false);
		lcoljopgdll20.ELFEMMEBOGG(Color.black);
		lcoljopgdll20.DFIGKKMMIAF = 31;
		num += -122;
		LCOLJOPGDLL lcoljopgdll21 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 116f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.BDKHMOOFHHK("Bone01"), JLFJEGIPIMM.PKGMBFEMKGP().AHEHNKFHGOC((double)kfhelhglnmh.ODHFHEBLIJM), kfhelhglnmh.OFDBELIILEG), true);
		lcoljopgdll21.GHCCIOAJFIH(Color.black);
		lcoljopgdll21.DFIGKKMMIAF = 12;
		num += -56;
		num += 24;
		LCOLJOPGDLL lcoljopgdll22 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 369f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.PGJCPFNJNPM("_FinalBlendParameters"), JBEHMPDDMME.JKIFIBEPICO().JBJFBDONEFF), false);
		lcoljopgdll22.GDFICJKDCDO(Color.black);
		lcoljopgdll22.DFIGKKMMIAF = 4;
		num += -46;
		new GMNEKCBLIAN(JMAKEAHMLMI, new Rect(PHEMLBHMNCM.x + 665f, PHEMLBHMNCM.y + (float)num, 1696f, 665f), (float)JBEHMPDDMME.BOKIOJFHNLD().JBJFBDONEFF, 1483f, 4, "name", true);
		num += -72;
		LCOLJOPGDLL lcoljopgdll23 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 802f, PHEMLBHMNCM.y + (float)num, "Sound #", false);
		lcoljopgdll23.DFIGKKMMIAF = -43;
		lcoljopgdll23.LNDPBNODFPE = true;
		num += -29;
		num += 107;
		if (kfhelhglnmh.GNNDLEAFCND - kfhelhglnmh.MGLOOIONCPM > 0L)
		{
			LCOLJOPGDLL lcoljopgdll24 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 1140f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.NGALDMFKMJH("IdleDie2"), kfhelhglnmh.MGLOOIONCPM, kfhelhglnmh.GNNDLEAFCND), true);
			lcoljopgdll24.AOOCNBCBKGN(Color.black);
			lcoljopgdll24.DFIGKKMMIAF = 67;
		}
		num += 52;
		int pobkjfflepn = 8;
		if (JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.MGLOOIONCPM >= JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.GNNDLEAFCND)
		{
			pobkjfflepn = 2;
		}
		new GMNEKCBLIAN(JMAKEAHMLMI, new Rect(PHEMLBHMNCM.x + 1987f, PHEMLBHMNCM.y + (float)num, 1322f, 1434f), (float)kfhelhglnmh.MGLOOIONCPM, (float)kfhelhglnmh.GNNDLEAFCND, pobkjfflepn, "Name: ", true);
		num += 58;
		LCOLJOPGDLL lcoljopgdll25 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 165f, PHEMLBHMNCM.y + (float)num, "This [c 01F573FF]sentence[C FFFFFFFF] is [c FF6666FF]too[C FFFFFFFF] long so it will be [BC 1B07F5FF]split[BC ?] into multiple lines.\nNormal, [F ArialBold]bold, [font ArialItalic]italic, [F Arial][FA u]underline[FA -u], [FA S]strikethrough[FA -s].\n[F Arial 10]10, [F Arial 16]16, [F Arial 24]24, [F Arial 48]48, [F Arial 72]72[F Arial 16]\n[HA L]Left\n[HA C]Center\n[HA R]Right\n[HA L]20 pixels further:[S 20]*\nDefault vertical aligment: [F Arial 10]10, [F Arial 24]24, [F Arial 10]10[FS 16]\n[VA B]Bottom vertical aligment: [F Arial 10]10, [F Arial 24]24, [F Arial 10]10[FS 16][VA ?]\nThis is a [FA U][H hyperlink_value]hyperlink[-H][FA -U].", false);
		lcoljopgdll25.DFIGKKMMIAF = 125;
		lcoljopgdll25.LNDPBNODFPE = true;
	}

	// Token: 0x06005011 RID: 20497 RVA: 0x002513A8 File Offset: 0x0024F5A8
	public void getFish(int KKIODALCJGE, bool LPPACHLJMJC = false)
	{
		this.endShowFish();
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC.Count - 1; i++)
		{
			OIJEGJLCFCF oijegjlcfcf = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC[i];
			num += oijegjlcfcf.NKHBAJKMAGD;
			num2++;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.ICJDPPOJINN || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.IBEIBAHKIAH)
		{
			string iabkgmnjljo = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("sadokfull");
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
			FlyMessageManager.getI.clearMessages();
			FlyMessageManager.getI.addMessageBig(iabkgmnjljo, Color.red, 0, 0);
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("cut.ogg", 1f);
			this.releaseFish(KKIODALCJGE);
		}
		else
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_08.wav", 0.8f);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(LPPACHLJMJC ? 1136 : 1135, this.CODAIBGMFCA.LPFKFNLHGBI);
		}
		if (KKIODALCJGE > 0)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(KKIODALCJGE);
		}
	}

	// Token: 0x06005012 RID: 20498 RVA: 0x0024E24A File Offset: 0x0024C44A
	private IEnumerator IKNBAFLKELI(float FGNPJLIPNFM)
	{
		yield return new WaitForSeconds(FGNPJLIPNFM);
		this.endShowFish();
		yield break;
	}

	// Token: 0x06005013 RID: 20499 RVA: 0x002514DC File Offset: 0x0024F6DC
	public void PGHGGGCJMEF(int HGCCAHPEFGO = 0, bool HAEEEHGKFMG = false)
	{
		this.currentSadokId = HGCCAHPEFGO;
		int count = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.NAFGMKJPLPC.Count;
		if (HAEEEHGKFMG && this.sadokWinId > 0 && JDCEFOFMGHB.HMJJPNDEKPP().IHNMOJHBMNJ(this.sadokWinId) != null)
		{
			JDCEFOFMGHB.JFIDAGABKID().CBHHEHHNFKL(this.sadokWinId);
			return;
		}
		if (this.sadokWinId > 1)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().CBHHEHHNFKL(this.sadokWinId);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().CHPPAAAAJFC(this.sadokWinId);
		if (onkdcgnbalk == null)
		{
			onkdcgnbalk = JDCEFOFMGHB.HMJJPNDEKPP().BJFHBPOCELH(228f, 1150f, JNBICAJIJMM.EKEBHIJMEML().FLEANFGEJML(""), false);
		}
		else
		{
			onkdcgnbalk.MPKCOJHJIIB();
		}
		this.sadokWinId = onkdcgnbalk.LPFKFNLHGBI;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 550f, onkdcgnbalk.OCHCODJIPHJ.height - 570f, 542f, 751f, JNBICAJIJMM.EEOPOHEALPK().DOEMGEAEBPN("\n"), 4, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.ODBGHCIJOHA));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 1977f - 349f, onkdcgnbalk.OCHCODJIPHJ.height - 110f, 1933f, 1698f, JNBICAJIJMM.EKEBHIJMEML().DOEMGEAEBPN("OfficeSittingLegCross"), 112, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 1643f - 1145f, onkdcgnbalk.OCHCODJIPHJ.height - 1954f, 1049f, 224f, JNBICAJIJMM.CLIMNFDGOEG().CKAOHMEKLMH("Bases/{0}/"), -79, null, new ONKDCGNBALK.CMMHGMILOIM(this.ANLHLPBBPPI));
		Rect ochcodjiphj = new Rect(1402f, 982f, 1933f, onkdcgnbalk.OCHCODJIPHJ.height - 1817f);
		new MGLHIBHDMPC(onkdcgnbalk, ochcodjiphj, this.PaperTexture);
		this.OJJLLBKEGNO = new MMKFAENBHKD(onkdcgnbalk, ochcodjiphj.x, ochcodjiphj.y, ochcodjiphj.width, ochcodjiphj.height, 0);
		new KLIKIJOLPPJ(onkdcgnbalk, this.OJJLLBKEGNO.OCHCODJIPHJ.x, onkdcgnbalk.OCHCODJIPHJ.height - 1746f, JNBICAJIJMM.IMLLGEMPHAP().FLEANFGEJML("_DisplayVelocityScale"), 0, HPGKIJLKCIH.IKGFHGKKCPG.MPNJKJKDMLK).LJIEPIPIAJC = new ONKDCGNBALK.CMMHGMILOIM(this.GJMOACDCNPK);
		List<OIJEGJLCFCF> list = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.NAFGMKJPLPC;
		if (this.currentSadokId == 0)
		{
			list = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.KNFMGIBLMHB;
		}
		foreach (OIJEGJLCFCF oijegjlcfcf in list)
		{
			if (oijegjlcfcf.HGCCAHPEFGO == this.currentSadokId)
			{
				this.OJJLLBKEGNO.LACAJHOHACK.Add(oijegjlcfcf);
			}
		}
		ochcodjiphj = new Rect(1473f, 1409f, 827f, 1556f);
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 0)
		{
			new MGLHIBHDMPC(onkdcgnbalk, ochcodjiphj, this.sadokImage);
			new EGCAADAABPP(onkdcgnbalk, ochcodjiphj.x, ochcodjiphj.y, ochcodjiphj.width, ochcodjiphj.height, " iterations for read and write", 0, null).NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.LGHDGKMCEIE);
		}
		new LCOLJOPGDLL(onkdcgnbalk, ochcodjiphj.x + 1300f, ochcodjiphj.y + 1846f, JNBICAJIJMM.EEOPOHEALPK().CCFFMKBBKHI("{0}Textures/Turnirs/{1}.png"), true);
		new MEMEOHJKPNJ(onkdcgnbalk, ochcodjiphj.x + 1652f, ochcodjiphj.y + 755f, 1876f, 1629f, "val=", 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.ANLHLPBBPPI)).FNMCIACNOMH = (this.currentSadokId == 1);
		new MEMEOHJKPNJ(onkdcgnbalk, ochcodjiphj.x + 759f + 760f, ochcodjiphj.y + 187f, 1993f, 4f, "No saved ObscuredPrefs!", 3, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress)).FNMCIACNOMH = (this.currentSadokId == 0);
		bool fnmciacnomh = this.CFJKPHECOKH();
		if (this.currentSadokId == 0)
		{
			this.rembtn = new MEMEOHJKPNJ(onkdcgnbalk, ochcodjiphj.x + 1568f, ochcodjiphj.y + 637f, 724f, 1783f, "RollerBladeTurnRight", 6, null, new ONKDCGNBALK.CMMHGMILOIM(this.OCLOCNNOGLK))
			{
				FNMCIACNOMH = fnmciacnomh
			};
		}
		if (this.currentSadokId == 1)
		{
			this.rembtn = new MEMEOHJKPNJ(onkdcgnbalk, ochcodjiphj.x + 152f, ochcodjiphj.y + 637f, 524f, 871f, "perks/rperk", 6, null, new ONKDCGNBALK.CMMHGMILOIM(this.ANLHLPBBPPI))
			{
				FNMCIACNOMH = fnmciacnomh
			};
		}
		this.OJJLLBKEGNO.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.OBDKLGAECAH);
		this.OJJLLBKEGNO.PDEGHKDPJFP(this.OJJLLBKEGNO.LACAJHOHACK.Count - 1);
		this.OJJLLBKEGNO.GCKGOOBOKJB();
		if (this.CODAIBGMFCA == null || this.OJJLLBKEGNO.HHJKOIJGNAK() < 0)
		{
			this.rembtn.FNMCIACNOMH = false;
		}
		this.OHIPOCGKHDE = new LCOLJOPGDLL(onkdcgnbalk, 1203f, 928f, 1915f, 736f, "fchair_", TextAnchor.UpperCenter, Color.black)
		{
			LNDPBNODFPE = false
		};
		this.ACKCODOIBCL();
	}

	// Token: 0x06005014 RID: 20500 RVA: 0x00251A60 File Offset: 0x0024FC60
	public void OAEOAJOFBFJ(ONKDCGNBALK ONPHLHKAGFP)
	{
		if (JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.KLGLOCMOHAG >= JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.JGIHLJKDMKM)
		{
			NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(191, -1);
			FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("_info", 1158f);
			return;
		}
		if (!this.selectPerk.ODBICLOCIMO)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("'", 1566f);
			return;
		}
		if (this.selectPerk == null)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("Anchore Right_", 1915f);
			return;
		}
		int num = (int)JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BIHLDHKHPKE("inv_auklotinf");
		if (this.selectPerk.LPFKFNLHGBI != num)
		{
			NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(-190, this.selectPerk.LPFKFNLHGBI);
			return;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("", 641f);
	}

	// Token: 0x06005015 RID: 20501 RVA: 0x00251B44 File Offset: 0x0024FD44
	public void press_param(ONKDCGNBALK ONPHLHKAGFP)
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("ui_default_close.wav", 1f);
		int dnhbpgoklkd = (int)ONPHLHKAGFP.ODFEKBJCFMN;
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(222, dnhbpgoklkd);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(32, "?");
	}

	// Token: 0x06005016 RID: 20502 RVA: 0x00251B9C File Offset: 0x0024FD9C
	private void AMHBHBMNIEG(ONKDCGNBALK JMAKEAHMLMI, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		IDCHHHEDHDC.GIONPNFHOOC gionpnfhooc = (IDCHHHEDHDC.GIONPNFHOOC)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = 15,
			font = GuiProcessor.IKGFHGKKCPG.rusfont3,
			fontStyle = FontStyle.Bold,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperCenter
		};
		float x = OCHCODJIPHJ.x + 1344f;
		GUI.Label(new Rect(x, OCHCODJIPHJ.y + 1159f, OCHCODJIPHJ.width, 1171f), gionpnfhooc.BGJICMGFOON.HAJNMNALBBI + "_WaterMap" + JLFJEGIPIMM.IKGFHGKKCPG.GKDPPPKBELC((long)gionpnfhooc.GBOBJLNHPBI), guistyle);
		string text = string.Format(JNBICAJIJMM.PGJCPFNJNPM("WeaponReload"), "TOD_CloudSharpness", gionpnfhooc.MGILDBCKBON, gionpnfhooc.LLKDCEPNHOL);
		if (gionpnfhooc.GHGAHDMKJFE == JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.LPFKFNLHGBI)
		{
			guistyle.normal.textColor = new Color(122f, 1790f, 1354f);
		}
		guistyle.font = GuiProcessor.IKGFHGKKCPG.rusfont;
		guistyle.fontSize = 89;
		guistyle.fontStyle = FontStyle.Normal;
		GUI.Label(new Rect(x, OCHCODJIPHJ.y + 995f, OCHCODJIPHJ.width, OCHCODJIPHJ.height - 592f), text, guistyle);
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.OELKEADDKPE().LMGMPPAOPEP(gionpnfhooc.GNCMJMOJAAK);
		befchfngomi.JLCGGFPBOCF();
		GUI.DrawTexture(new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 1918f, OCHCODJIPHJ.y + 214f, 1821f, 1992f), befchfngomi.KEEDCOIMPMP());
	}

	// Token: 0x06005017 RID: 20503 RVA: 0x00251D3A File Offset: 0x0024FF3A
	private void JIFOELPAEHG()
	{
		if (Input.GetKeyDown((KeyCode)(-92)) && JDCEFOFMGHB.JFIDAGABKID().HILJENLHLDE(this.sadokWinId) != null && this.CODAIBGMFCA != null)
		{
			this.GKBCONBIMIN();
		}
	}

	// Token: 0x06005018 RID: 20504 RVA: 0x00251D68 File Offset: 0x0024FF68
	public void MOFOHNEDFBL(ONKDCGNBALK JMAKEAHMLMI)
	{
		if (Input.GetKey((KeyCode)(-112)) && !this.BLKAFFPKEBA)
		{
			this.GEDNGIDHBHD();
			this.EFBAFHBCIDA(JMAKEAHMLMI.LPFKFNLHGBI, true);
		}
		if (Input.GetKey((KeyCode)(-53)))
		{
			this.endShowFish();
			this.EBAOMHDICFP(JMAKEAHMLMI.LPFKFNLHGBI);
		}
	}

	// Token: 0x06005019 RID: 20505 RVA: 0x00251DB4 File Offset: 0x0024FFB4
	public void OCLOCNNOGLK(ONKDCGNBALK OJIMHKHFOJI)
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH;
		this.endShowFish();
		long odfekbjcfmn = OJIMHKHFOJI.ODFEKBJCFMN;
		long num = odfekbjcfmn - 1L;
		if (num > -84L)
		{
			return;
		}
		switch ((uint)num)
		{
		case 0U:
			this.currentSadokId = 1;
			this.CODAIBGMFCA = null;
			this.openSadok(this.currentSadokId, false);
			this.rembtn.FNMCIACNOMH = this.CFJKPHECOKH();
			return;
		case 1U:
			this.currentSadokId = 0;
			this.CODAIBGMFCA = null;
			this.openSadok(this.currentSadokId, false);
			this.rembtn.FNMCIACNOMH = this.PJHMFEOOIPN();
			return;
		case 2U:
			if (this.CODAIBGMFCA != null && this.CODAIBGMFCA.HGCCAHPEFGO == 0)
			{
				NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(134, this.CODAIBGMFCA.LPFKFNLHGBI);
				this.CODAIBGMFCA.HGCCAHPEFGO = 0;
				kfhelhglnmh.NAFGMKJPLPC.Remove(this.CODAIBGMFCA);
				kfhelhglnmh.KNFMGIBLMHB.Add(this.CODAIBGMFCA);
				FBFJFAKAGJG.IKGFHGKKCPG.LBGNEGLBLHF(Fisherman.getI.transform.position, 4f);
				int num2 = this.OJJLLBKEGNO.FJNDDAMCLFL();
				this.OJJLLBKEGNO.LACAJHOHACK.Remove(this.CODAIBGMFCA);
				if (num2 >= this.OJJLLBKEGNO.LACAJHOHACK.Count)
				{
					num2 = this.OJJLLBKEGNO.LACAJHOHACK.Count - 1;
				}
				this.OJJLLBKEGNO.PDEGHKDPJFP(num2);
				this.OJJLLBKEGNO.BEHAGGLKAJH();
				this.HPICBMCMAEC();
				FlyMessageManager.getI.OEOHJBMGBCP();
				return;
			}
			break;
		case 3U:
			if (this.CODAIBGMFCA != null && this.CODAIBGMFCA.HGCCAHPEFGO == 0)
			{
				NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(-117, this.CODAIBGMFCA.LPFKFNLHGBI);
				this.CODAIBGMFCA.HGCCAHPEFGO = 1;
				FBFJFAKAGJG.IKGFHGKKCPG.LBGNEGLBLHF(Fisherman.getI.transform.position, 1069f);
				kfhelhglnmh.KNFMGIBLMHB.Remove(this.CODAIBGMFCA);
				kfhelhglnmh.NAFGMKJPLPC.Add(this.CODAIBGMFCA);
				int num3 = this.OJJLLBKEGNO.FJNDDAMCLFL();
				this.OJJLLBKEGNO.LACAJHOHACK.Remove(this.CODAIBGMFCA);
				if (num3 >= this.OJJLLBKEGNO.LACAJHOHACK.Count)
				{
					num3 = this.OJJLLBKEGNO.LACAJHOHACK.Count - 0;
				}
				this.OJJLLBKEGNO.BJLCAGOJDNM(num3);
				this.OJJLLBKEGNO.NIJOHIBNLEI();
				this.ACKCODOIBCL();
				FlyMessageManager.getI.clearMessages();
				return;
			}
			break;
		case 4U:
		case 5U:
		case 6U:
		case 7U:
		case 8U:
		case 9U:
		case 16U:
		case 17U:
		case 18U:
			break;
		case 10U:
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(181, 1);
			FBFJFAKAGJG.IKGFHGKKCPG.AMDLJMNDALF(Fisherman.getI.transform.position + Fisherman.getI.transform.forward * 1378f, 238f);
			JDCEFOFMGHB.IKGFHGKKCPG.KCNBOHEMLCI(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
			return;
		case 11U:
			if (this.CODAIBGMFCA != null)
			{
				this.releaseFromSadok();
				return;
			}
			break;
		case 12U:
			this.releaseFish(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
			return;
		case 13U:
			this.EFBAFHBCIDA(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI, true);
			return;
		case 14U:
			if (this.CODAIBGMFCA != null)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB(" POSITION not found", 1308f);
				OJIMHKHFOJI.FNMCIACNOMH = false;
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-123, this.CODAIBGMFCA.LPFKFNLHGBI);
				this.EFBAFHBCIDA(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI, true);
				JDCEFOFMGHB.JFIDAGABKID().CBHHEHHNFKL(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
				return;
			}
			break;
		case 15U:
			if (this.CODAIBGMFCA != null)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("!", 1753f);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-107, this.CODAIBGMFCA.LPFKFNLHGBI);
				OJIMHKHFOJI.FNMCIACNOMH = true;
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-144, this.CODAIBGMFCA.LPFKFNLHGBI);
				JDCEFOFMGHB.IKGFHGKKCPG.KCNBOHEMLCI(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI);
				return;
			}
			break;
		case 19U:
			this.EFBAFHBCIDA(OJIMHKHFOJI.OCBAOFLJBGP.LPFKFNLHGBI, true);
			break;
		default:
			return;
		}
	}

	// Token: 0x0600501A RID: 20506 RVA: 0x00252200 File Offset: 0x00250400
	private void FFOKGLLHNPF()
	{
		string dccpcblodig = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_fridgice"), this.DBELGCHKMOE.LACAJHOHACK.Count, this.holodFreeCell);
		if (this.DBELGCHKMOE.LACAJHOHACK.Count >= this.holodFreeCell)
		{
			dccpcblodig = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_fridgiceno"), this.DBELGCHKMOE.LACAJHOHACK.Count, this.holodFreeCell);
		}
		this.CINAIMICJGM.FPIHOPOCAHA = dccpcblodig;
	}

	// Token: 0x0600501B RID: 20507 RVA: 0x0025229C File Offset: 0x0025049C
	public void sadokPanelRender(ONKDCGNBALK PHEMLBHMNCM)
	{
		GUI.Box(PHEMLBHMNCM.OCHCODJIPHJ, "");
		if (this.CODAIBGMFCA == null)
		{
			return;
		}
		AKPJIACDDFI.IKGFHGKKCPG.GBKMHIGNKJA(this.CODAIBGMFCA.NENOBDLCFHO);
		GUI.color = new Color(0f, 0f, 0f, 0.5f);
		GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 10f, PHEMLBHMNCM.OCHCODJIPHJ.y + 10f, 512f, 256f), this.CODAIBGMFCA.EJJAGEFMHCO().KEDGAOBCNJG, ScaleMode.ScaleToFit);
		GUI.color = Color.white;
		GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y, 512f, 256f), this.CODAIBGMFCA.EJJAGEFMHCO().KEDGAOBCNJG, ScaleMode.ScaleToFit);
		float num = PHEMLBHMNCM.OCHCODJIPHJ.y + 16f;
		if (this.CODAIBGMFCA.GEFOGEDMLJA)
		{
			GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width - 48f - 10f, num, 48f, 48f), this.recIconTxtr, ScaleMode.ScaleAndCrop);
			num += 48f;
		}
		if (this.CODAIBGMFCA.GAAPCLGDOGH.NGKHOKIOGNO)
		{
			GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width - 48f - 10f, num, 48f, 48f), this.mutIconTxtr, ScaleMode.ScaleAndCrop);
			num += 48f;
		}
		if (this.CODAIBGMFCA.JPFFCKENLHO)
		{
			GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width - 48f - 10f, num, 48f, 48f), this.unicIconTxtr, ScaleMode.ScaleAndCrop);
			num += 48f;
		}
		string text = this.CODAIBGMFCA.ToString();
		GUIStyle guistyle = new GUIStyle
		{
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperLeft,
			fontSize = 14,
			wordWrap = true,
			richText = true
		};
		float x = PHEMLBHMNCM.OCHCODJIPHJ.x + PHEMLBHMNCM.OCHCODJIPHJ.width - 64f;
		float y = PHEMLBHMNCM.OCHCODJIPHJ.y + 256f - 72f;
		BEFCHFNGOMI befchfngomi = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(this.CODAIBGMFCA.MIGBFMILDHD);
		if (befchfngomi != null)
		{
			befchfngomi.FCBHHPJLGLC(new Rect(x, y, 56f, 56f), befchfngomi.KBGHOIJIPJF, true, 0);
		}
		float num2 = PHEMLBHMNCM.OCHCODJIPHJ.height - 32f;
		if (this.CODAIBGMFCA.OLJEDIJMEOA.Count > 0)
		{
			guistyle.normal.textColor = new Color(0.4f, 0.1f, 0.3f);
			GUI.color = new Color(0.8f, 0.4f, 0.8f);
			foreach (int ldlcflipofh in this.CODAIBGMFCA.OLJEDIJMEOA)
			{
				GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 5f, PHEMLBHMNCM.OCHCODJIPHJ.y + num2, 12f, 12f), this.titulIcon2);
				GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 25f, PHEMLBHMNCM.OCHCODJIPHJ.y + num2, 256f, 26f), AKPJIACDDFI.IKGFHGKKCPG.PKAJMDDDMMI(ldlcflipofh, false), guistyle);
				num2 -= 14f;
			}
			GUI.color = Color.white;
		}
		if (this.CODAIBGMFCA.KPGFFEIODJF.Count > 0)
		{
			guistyle.normal.textColor = new Color(0.2f, 0.2f, 0.2f);
			GUI.color = new Color(0.4f, 0.7f, 0.4f);
			foreach (int num3 in this.CODAIBGMFCA.KPGFFEIODJF)
			{
				GUI.color = ((num3 == 31) ? new Color(0.8f, 0.4f, 0.8f) : new Color(0.4f, 0.7f, 0.4f));
				GUI.DrawTexture(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 5f, PHEMLBHMNCM.OCHCODJIPHJ.y + num2, 12f, 12f), this.titulIcon2);
				GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x + 25f, PHEMLBHMNCM.OCHCODJIPHJ.y + num2, 256f, 26f), AKPJIACDDFI.IKGFHGKKCPG.PKAJMDDDMMI(num3, false), guistyle);
				num2 -= 14f;
			}
			GUI.color = Color.white;
		}
		GUIStyle guistyle2 = new GUIStyle
		{
			normal = 
			{
				textColor = Color.white
			},
			alignment = TextAnchor.UpperCenter,
			fontSize = 16,
			wordWrap = true,
			richText = true
		};
		GUI.Label(new Rect(PHEMLBHMNCM.OCHCODJIPHJ.x, PHEMLBHMNCM.OCHCODJIPHJ.y + 256f, 512f, 256f), text, guistyle2);
		guistyle2.fontSize = 12;
		guistyle2.normal.textColor = Color.black;
	}

	// Token: 0x0600501C RID: 20508 RVA: 0x00252860 File Offset: 0x00250A60
	private void HFHGKJCGBBD(ONKDCGNBALK ONPHLHKAGFP)
	{
		OIJEGJLCFCF dolfjggbdjf = this.DOLFJGGBDJF;
		if (dolfjggbdjf == null)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.NAFGMKJPLPC.Remove(dolfjggbdjf);
			this.OJJLLBKEGNO.LACAJHOHACK.Remove(dolfjggbdjf);
			this.OJJLLBKEGNO.KHOHPADLIHJ();
			this.DBELGCHKMOE.LACAJHOHACK.Add(dolfjggbdjf);
			this.DBELGCHKMOE.OPKGEBFLNIK();
			epmphjgalbe.GOMLLPFFPNP(this.currentHolodId);
			epmphjgalbe.PMJPIJMHELL(dolfjggbdjf.LPFKFNLHGBI);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(190, epmphjgalbe.NNEAJJNCGMK());
		}
		finally
		{
			epmphjgalbe.PGLFHABMJPO();
		}
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("rait_5", 639f);
		this.ACKCODOIBCL();
		this.IBLNNMGJHGC();
	}

	// Token: 0x0600501D RID: 20509 RVA: 0x00252934 File Offset: 0x00250B34
	public void OpenTitulWindow(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		JNHLAGHJBAA jnhlaghjbaa = new JNHLAGHJBAA(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + 20f, PHEMLBHMNCM.width - 40f, PHEMLBHMNCM.height - 180f, 0)
		{
			JHNCNHAAJCH = 20f,
			KCLLDJJLCGC = 14
		};
		jnhlaghjbaa.GIOGEHKMKDE = false;
		jnhlaghjbaa.JKAOKBNCDFK = Color.black;
		jnhlaghjbaa.ABMDIOIJALO = new Color(0f, 0f, 0.2f);
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(JNBICAJIJMM.IKGFHGKKCPG.CHFGNHKJNFG("Titul.xml", false));
		GameInterface.HPNMCNHFODM(jnhlaghjbaa.EELDHNFBFOE, xmlDocument.SelectNodes("titul_data/p_categories/category"));
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
			NHCAOFIKNFE.IOPMLIFDBKO iopmlifdbko = NHCAOFIKNFE.IKGFHGKKCPG.NIOHNJCNOHL(lpfkfnlhgbi);
			JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = jnhlaghjbaa.MJMOMMKECMF((long)iopmlifdbko.GCLKLEIMABA);
			if (fpaeeadmcie != null)
			{
				fpaeeadmcie.LGMBHELCEEL(iopmlifdbko, (long)iopmlifdbko.JFHBDBHIOII);
			}
			else
			{
				jnhlaghjbaa.EELDHNFBFOE.LGMBHELCEEL(iopmlifdbko, (long)iopmlifdbko.JFHBDBHIOII);
			}
		}
		jnhlaghjbaa.BIPMLHDDOMF();
		jnhlaghjbaa.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.AEMFAOIFNCO);
		Rect rect = new Rect(jnhlaghjbaa.OCHCODJIPHJ.x - 3f, jnhlaghjbaa.OCHCODJIPHJ.y + jnhlaghjbaa.OCHCODJIPHJ.height + 10f, jnhlaghjbaa.OCHCODJIPHJ.width + 6f, 130f);
		new EGCAADAABPP(JMAKEAHMLMI, rect.x, rect.y, rect.width, rect.height, "", 0, this.simpleGray);
		this.LCMCOGOGHPL = new LCOLJOPGDLL(JMAKEAHMLMI, rect.x + 10f, rect.y + 10f, rect.width, rect.height / 2f, "", TextAnchor.UpperLeft, new Color(0.3f, 0.2f, 0.2f))
		{
			DFIGKKMMIAF = 12
		};
		this.LCMCOGOGHPL.NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.BPOGJJEJJLB);
		this.IKFFNBOCGFL = new LCOLJOPGDLL(JMAKEAHMLMI, rect.x + 10f, rect.y + 40f, rect.width, rect.height - 40f, "", TextAnchor.UpperLeft, Color.white)
		{
			LNDPBNODFPE = true,
			DFIGKKMMIAF = 16
		};
		this.OKFIFPBAAFG = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HKHMIIEIFNG;
		jnhlaghjbaa.HNNJNDNOHLP = jnhlaghjbaa.MJMOMMKECMF((long)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HKHMIIEIFNG);
		this.FJOABFJFMEP = new MEMEOHJKPNJ(JMAKEAHMLMI, rect.x + rect.width - 110f, rect.y + rect.height - 35f, 100f, 24f, JNBICAJIJMM.LEBHCLDODNI("gi_tit_sel"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.titulKeyPress));
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
	}

	// Token: 0x0600501E RID: 20510 RVA: 0x00252C38 File Offset: 0x00250E38
	public void ADGGPAJAOLD(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(JMAKEAHMLMI, PHEMLBHMNCM.x + 870f, PHEMLBHMNCM.y + 733f, PHEMLBHMNCM.width - 773f, PHEMLBHMNCM.height - 1073f, 0)
		{
			JHNCNHAAJCH = 261f
		};
		mmkfaenbhkd.KPLMFNIFPMM = true;
		while (!KADBECGIMPD.KFKIFJDHCHB())
		{
			IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
			gdemcacnpng.IBIOFOMNCFF(KADBECGIMPD);
			gdemcacnpng.onRender = new ItemBase.OOALOMPKIKK(this.PDOLJGHCCIG);
			mmkfaenbhkd.LACAJHOHACK.Add(gdemcacnpng);
		}
		mmkfaenbhkd.KCLLDJJLCGC = 28;
		mmkfaenbhkd.IGAFAALMNNE();
		mmkfaenbhkd.AGFFDCECLBF(1);
	}

	// Token: 0x0600501F RID: 20511 RVA: 0x00252CDD File Offset: 0x00250EDD
	private void DMINCEDADIC()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.HAINEMDDILG();
	}

	// Token: 0x06005020 RID: 20512 RVA: 0x00252CEC File Offset: 0x00250EEC
	public void CMNKNPKIMOH(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
		kfhelhglnmh.MKPJAFJPIFN(KADBECGIMPD);
		JNHLAGHJBAA jnhlaghjbaa = new JNHLAGHJBAA(JMAKEAHMLMI, PHEMLBHMNCM.x + 1989f, PHEMLBHMNCM.y + 40f, PHEMLBHMNCM.width - 144f, PHEMLBHMNCM.height - 1272f, 0)
		{
			JHNCNHAAJCH = 78f,
			KCLLDJJLCGC = 18
		};
		jnhlaghjbaa.GIOGEHKMKDE = true;
		jnhlaghjbaa.JKAOKBNCDFK = Color.black;
		jnhlaghjbaa.ABMDIOIJALO = new Color(137f, 147f, 44f);
		jnhlaghjbaa.JHNCNHAAJCH = 1867f;
		JMAKEAHMLMI.DPANHMGCBNL = JNBICAJIJMM.IMLLGEMPHAP().CKAOHMEKLMH("");
		JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = jnhlaghjbaa.EELDHNFBFOE.JKGFEINNJKH(JNBICAJIJMM.DBMJJPBOPEK().HLBAJBLHLNI("wpn_book1"));
		int num = (int)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BIHLDHKHPKE("FOG_HAZE_ON");
		foreach (NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg in kfhelhglnmh.GADJFFGDCFA.Values)
		{
			if (jenmpdpjkbg.BDHHPAEHFHG.POKJFJBHDOJ)
			{
				JNHLAGHJBAA.FPAEEADMCIE dccpcblodig = fpaeeadmcie.OLFAFFCHPNP(jenmpdpjkbg, (long)jenmpdpjkbg.LPFKFNLHGBI);
				if (jenmpdpjkbg.LPFKFNLHGBI == num)
				{
					jnhlaghjbaa.MDINCCGBKID(dccpcblodig);
				}
			}
		}
		foreach (NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg2 in kfhelhglnmh.GADJFFGDCFA.Values)
		{
			if (!jenmpdpjkbg2.BDHHPAEHFHG.POKJFJBHDOJ)
			{
				JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie2 = jnhlaghjbaa.LBENJPLPLHK((long)jenmpdpjkbg2.BDHHPAEHFHG.IHBEJDJINAI);
				if (fpaeeadmcie2 != null)
				{
					JNHLAGHJBAA.FPAEEADMCIE dccpcblodig2 = fpaeeadmcie2.OLFAFFCHPNP(jenmpdpjkbg2, (long)jenmpdpjkbg2.LPFKFNLHGBI);
					if (jenmpdpjkbg2.LPFKFNLHGBI == num)
					{
						jnhlaghjbaa.COHAJLAEBBG(dccpcblodig2);
					}
				}
				else
				{
					JNHLAGHJBAA.FPAEEADMCIE dccpcblodig3 = fpaeeadmcie.HPGJHBANKPJ(jenmpdpjkbg2, (long)jenmpdpjkbg2.LPFKFNLHGBI);
					if (jenmpdpjkbg2.LPFKFNLHGBI == num)
					{
						jnhlaghjbaa.COHAJLAEBBG(dccpcblodig3);
					}
				}
			}
		}
		jnhlaghjbaa.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.PMAAILHGLKB);
		new MEMEOHJKPNJ(JMAKEAHMLMI, 11f, 1721f, 30f, 476f, "error: mainAsset is null", 0, this.teachKeyTexture, new ONKDCGNBALK.CMMHGMILOIM(this.PBPBJCBDMMC));
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(JMAKEAHMLMI, 853f, 897f, string.Format(JNBICAJIJMM.IMLLGEMPHAP().HLBAJBLHLNI(" шт."), kfhelhglnmh.KLGLOCMOHAG, kfhelhglnmh.JGIHLJKDMKM), true);
		lcoljopgdll.DFIGKKMMIAF = 68;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		Rect rect = new Rect(jnhlaghjbaa.OCHCODJIPHJ.x - 741f, jnhlaghjbaa.OCHCODJIPHJ.y + jnhlaghjbaa.OCHCODJIPHJ.height + 79f, jnhlaghjbaa.OCHCODJIPHJ.width + 769f, 1074f);
		new EGCAADAABPP(JMAKEAHMLMI, rect.x, rect.y, rect.width, rect.height, "Spine", 0, this.simpleGray).NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.MLOPNFPMMLH);
	}

	// Token: 0x06005021 RID: 20513 RVA: 0x00253028 File Offset: 0x00251228
	public void ODDMGKHNKNJ(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(JMAKEAHMLMI, PHEMLBHMNCM.x + 55f, PHEMLBHMNCM.y + 347f, PHEMLBHMNCM.width - 1383f, PHEMLBHMNCM.height - 1276f, 0)
		{
			JHNCNHAAJCH = 1465f
		};
		mmkfaenbhkd.KPLMFNIFPMM = true;
		while (!KADBECGIMPD.DFLKBBNOGBG())
		{
			int nenobdlcfho = KADBECGIMPD.IFDFHJLCHAE();
			long jcgdlkihbjg = KADBECGIMPD.IJDIMHAEAIE();
			string gajgbadjhok = KADBECGIMPD.DPLAJNEDGBL();
			int kcfcjhcbcfm = KADBECGIMPD.AGNKAFLKCAG();
			int pnedpppeffg = KADBECGIMPD.AGNKAFLKCAG();
			int hdelgedddce = KADBECGIMPD.KDNDJNEGBDI();
			int migbfmildhd = KADBECGIMPD.LDLKLPJBIJN();
			IDCHHHEDHDC.GIONPNFHOOC gionpnfhooc = new IDCHHHEDHDC.GIONPNFHOOC(nenobdlcfho, jcgdlkihbjg, gajgbadjhok, kcfcjhcbcfm, pnedpppeffg, hdelgedddce, migbfmildhd);
			gionpnfhooc.onRender = new ItemBase.OOALOMPKIKK(this.AMHBHBMNIEG);
			mmkfaenbhkd.LACAJHOHACK.Add(gionpnfhooc);
		}
		mmkfaenbhkd.KCLLDJJLCGC = 53;
		mmkfaenbhkd.GNGINMOFEEH();
		mmkfaenbhkd.JJKGANHANFN(1);
	}

	// Token: 0x06005022 RID: 20514 RVA: 0x00253108 File Offset: 0x00251308
	public void AIFNJLNHHEF(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		kfhelhglnmh.JEKKJEFEHOB(KADBECGIMPD);
		JNHLAGHJBAA jnhlaghjbaa = new JNHLAGHJBAA(JMAKEAHMLMI, PHEMLBHMNCM.x + 1193f, PHEMLBHMNCM.y + 279f, PHEMLBHMNCM.width - 939f, PHEMLBHMNCM.height - 1245f, 0)
		{
			JHNCNHAAJCH = 1294f,
			KCLLDJJLCGC = 116
		};
		jnhlaghjbaa.GIOGEHKMKDE = false;
		jnhlaghjbaa.JKAOKBNCDFK = Color.black;
		jnhlaghjbaa.ABMDIOIJALO = new Color(59f, 417f, 1900f);
		jnhlaghjbaa.JHNCNHAAJCH = 581f;
		JMAKEAHMLMI.DPANHMGCBNL = JNBICAJIJMM.LPHMKPDBMPP().FLEANFGEJML("Button");
		JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = jnhlaghjbaa.EELDHNFBFOE.EGGHFPPCNDP(JNBICAJIJMM.IMLLGEMPHAP().DOEMGEAEBPN("_Threshhold"));
		int num = (int)JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.MHIIBKILGBL("******** nextMusicCrt End of music path=");
		foreach (NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg in kfhelhglnmh.GADJFFGDCFA.Values)
		{
			if (jenmpdpjkbg.BDHHPAEHFHG.POKJFJBHDOJ)
			{
				JNHLAGHJBAA.FPAEEADMCIE dccpcblodig = fpaeeadmcie.NEGLEBJHNOL(jenmpdpjkbg, (long)jenmpdpjkbg.LPFKFNLHGBI);
				if (jenmpdpjkbg.LPFKFNLHGBI == num)
				{
					jnhlaghjbaa.HLEOJHPPINJ(dccpcblodig);
				}
			}
		}
		foreach (NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg2 in kfhelhglnmh.GADJFFGDCFA.Values)
		{
			if (!jenmpdpjkbg2.BDHHPAEHFHG.POKJFJBHDOJ)
			{
				JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie2 = jnhlaghjbaa.FIGMLAJDIPG((long)jenmpdpjkbg2.BDHHPAEHFHG.IHBEJDJINAI);
				if (fpaeeadmcie2 != null)
				{
					JNHLAGHJBAA.FPAEEADMCIE dccpcblodig2 = fpaeeadmcie2.BKDIIPFBIDK(jenmpdpjkbg2, (long)jenmpdpjkbg2.LPFKFNLHGBI);
					if (jenmpdpjkbg2.LPFKFNLHGBI == num)
					{
						jnhlaghjbaa.COHAJLAEBBG(dccpcblodig2);
					}
				}
				else
				{
					JNHLAGHJBAA.FPAEEADMCIE dccpcblodig3 = fpaeeadmcie.OLFAFFCHPNP(jenmpdpjkbg2, (long)jenmpdpjkbg2.LPFKFNLHGBI);
					if (jenmpdpjkbg2.LPFKFNLHGBI == num)
					{
						jnhlaghjbaa.MDINCCGBKID(dccpcblodig3);
					}
				}
			}
		}
		jnhlaghjbaa.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.COFHHPOBPNG);
		new MEMEOHJKPNJ(JMAKEAHMLMI, 1373f, 934f, 412f, 1200f, "/n", 0, this.teachKeyTexture, new ONKDCGNBALK.CMMHGMILOIM(this.OAEOAJOFBFJ));
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(JMAKEAHMLMI, 702f, 1020f, string.Format(JNBICAJIJMM.CLIMNFDGOEG().HEIBEHAEHBM("invn_rec6"), kfhelhglnmh.KLGLOCMOHAG, kfhelhglnmh.JGIHLJKDMKM), false);
		lcoljopgdll.DFIGKKMMIAF = -72;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		Rect rect = new Rect(jnhlaghjbaa.OCHCODJIPHJ.x - 202f, jnhlaghjbaa.OCHCODJIPHJ.y + jnhlaghjbaa.OCHCODJIPHJ.height + 1161f, jnhlaghjbaa.OCHCODJIPHJ.width + 1903f, 603f);
		new EGCAADAABPP(JMAKEAHMLMI, rect.x, rect.y, rect.width, rect.height, "craft_data/categories/category", 0, this.simpleGray).NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.OnPerkBoxPostRender);
	}

	// Token: 0x06005023 RID: 20515 RVA: 0x00253444 File Offset: 0x00251644
	public void EGKEMKHIMDK(OIJEGJLCFCF CFBLFPPOIKE)
	{
		CFBLFPPOIKE.GAAPCLGDOGH.KFLOBJCCHKN(CFBLFPPOIKE.DBEIGNDALDC);
		this.CODAIBGMFCA = CFBLFPPOIKE;
		string iabkgmnjljo;
		if (this.CODAIBGMFCA.GAAPCLGDOGH.NMEMLMMOACP() == 1)
		{
			iabkgmnjljo = string.Format(JNBICAJIJMM.DBMJJPBOPEK().CKAOHMEKLMH("IKMappingLimb is referencing to a bone '"), this.CODAIBGMFCA.MJODNMLNFJC(true));
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
		}
		else
		{
			iabkgmnjljo = string.Format(JNBICAJIJMM.CLIMNFDGOEG().NLJOLOBPCBJ("SkateboardKickPush"), this.CODAIBGMFCA.MJODNMLNFJC(true));
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.MPNJKJKDMLK)
		{
			Color lbcgackjcjb = new Color(1809f, 23f, 1618f, 186f);
			if (this.CODAIBGMFCA.DBEIGNDALDC == 0)
			{
				lbcgackjcjb = new Color(1305f, 1845f, 327f, 98f);
			}
			if (this.CODAIBGMFCA.DBEIGNDALDC == 7)
			{
				lbcgackjcjb = new Color(489f, 928f, 1294f, 1811f);
			}
			if (this.CODAIBGMFCA.GEFOGEDMLJA)
			{
				lbcgackjcjb = new Color(537f, 653f, 452f, 1258f);
			}
			FlyMessageManager.getI.addMessageBig(iabkgmnjljo, lbcgackjcjb, 0, 1).NENOBDLCFHO = this.CODAIBGMFCA.NENOBDLCFHO;
			this.EFBAFHBCIDA(-1, true);
			bool knobfamemjc = HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC;
			return;
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC && ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD) < 914f)
		{
			this.MKICPMKFLFN(CFBLFPPOIKE, 1135f);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.PLKKECPNMEB(Fisherman.getI.transform.position, 1921f);
		bool flag = true;
		int num = 0;
		int num2 = 1;
		foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC)
		{
			num += oijegjlcfcf.NKHBAJKMAGD;
			num2 += 0;
		}
		num -= CFBLFPPOIKE.NKHBAJKMAGD;
		num2--;
		if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.ICJDPPOJINN || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.KMIOLLENCOL())
		{
			flag = false;
		}
		if (LocNewLogic.getI.GFWin != null)
		{
			LocNewLogic.getI.GFWin.gameObject.SetActive(false);
			LocNewLogic.getI.GFWin.MIBOKMJIEEJ(this.CODAIBGMFCA, flag);
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().NCIDDNIKACI(1616f, 1907f, JNBICAJIJMM.EDKGBBIIBBC().GNKIBMGNHNE("double: "), true);
		onkdcgnbalk.KNNIPIEENII = false;
		onkdcgnbalk.NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.BCMGNIDDMOP);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1408f + 527f, onkdcgnbalk.OCHCODJIPHJ.height - 794f, 1115f, 923f, JNBICAJIJMM.LPHMKPDBMPP().FLEANFGEJML("sunshine_WorldToSunVP"), -69, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress));
		bool flag2 = false;
		if (flag)
		{
			new LCOLJOPGDLL(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 44f - 1894f, onkdcgnbalk.OCHCODJIPHJ.height - 1441f, 12f, 1410f, JNBICAJIJMM.APMJBBDBOJO().GNKIBMGNHNE("Idle Dodge Right"), TextAnchor.UpperCenter, Color.red);
			flag2 = false;
		}
		else
		{
			string format = JNBICAJIJMM.EKEBHIJMEML().CKAOHMEKLMH("min_lev");
			object[] array = new object[5];
			array[1] = num2;
			array[0] = BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().NLHKFMMDMMK();
			array[3] = JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO((long)num);
			array[7] = JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.NKEOCCKEOCE());
			string dpanhmgcbnl = string.Format(format, array);
			new LCOLJOPGDLL(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 542f - 1527f, onkdcgnbalk.OCHCODJIPHJ.height - 104f, 1690f, 463f, dpanhmgcbnl, TextAnchor.UpperCenter, Color.black);
		}
		Rect ochcodjiphj = new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 1145f - 872f, 1020f, 1238f, 218f);
		new MGLHIBHDMPC(onkdcgnbalk, ochcodjiphj, this.fgetImage);
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(ochcodjiphj.x, ochcodjiphj.y, 1837f, 1244f), this.fgetImagesBases[JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.PNEDPPPEFFG]);
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, ochcodjiphj.x, ochcodjiphj.y, ochcodjiphj.width, ochcodjiphj.height, "ACTk has secure layer for the PlayerPrefs: <color=\"#75C4EB\">ObscuredPrefs</color>. It protects data from view, detects any cheating attempts, optionally locks data to the current device and supports additional data types.", 0, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.LGHDGKMCEIE)
		};
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 1178f, egcaadaabpp.OCHCODJIPHJ.width - 83f, 719f, string.Format("SwimFreestyle", CFBLFPPOIKE.MGLOOIONCPM), TextAnchor.UpperRight, new Color(1876f, 1748f, 1496f));
		lcoljopgdll.LNDPBNODFPE = true;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		lcoljopgdll.DFIGKKMMIAF = -33;
		this.BLKAFFPKEBA = flag2;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 853f - 124f, onkdcgnbalk.OCHCODJIPHJ.height - 830f, 751f, 204f, JNBICAJIJMM.EDKGBBIIBBC().GNKIBMGNHNE("hgtDst="), 103, null, new ONKDCGNBALK.CMMHGMILOIM(this.ANLHLPBBPPI)).FNMCIACNOMH = flag2;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1711f + 1985f, onkdcgnbalk.OCHCODJIPHJ.height - 1266f, 1010f, 1233f, JNBICAJIJMM.LPHMKPDBMPP().HEIBEHAEHBM("Gesture Chest Pump Salute"), -57, null, new ONKDCGNBALK.CMMHGMILOIM(this.OCLOCNNOGLK));
	}

	// Token: 0x06005024 RID: 20516 RVA: 0x00253AA0 File Offset: 0x00251CA0
	private void PDOLJGHCCIG(ONKDCGNBALK ONPHLHKAGFP, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = (IDCHHHEDHDC.GDEMCACNPNG)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -102,
			font = GuiProcessor.PLGADNLAEGN().rusfont3,
			fontStyle = FontStyle.Normal,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperCenter
		};
		float x = OCHCODJIPHJ.x + 1812f;
		GUI.Label(new Rect(x, OCHCODJIPHJ.y + 1955f, OCHCODJIPHJ.width, 1845f), gdemcacnpng.BDHHPAEHFHG.HAJNMNALBBI, guistyle);
		string text = string.Format(JNBICAJIJMM.CLIMNFDGOEG().NLJOLOBPCBJ("dummy"), gdemcacnpng.JFDDNMCENAK, JLFJEGIPIMM.MHFDIJGJGBJ().BNIINPDAMAO(gdemcacnpng.GJCNMJJJDGO), JLFJEGIPIMM.PKGMBFEMKGP().BNIINPDAMAO(gdemcacnpng.FMKDOFCJCOP));
		guistyle.font = GuiProcessor.NKOEAPCIBKO().rusfont;
		guistyle.fontSize = 4;
		guistyle.fontStyle = FontStyle.Normal;
		GUI.Label(new Rect(x, OCHCODJIPHJ.y + 864f, OCHCODJIPHJ.width, OCHCODJIPHJ.height - 1698f), text, guistyle);
		Rect position = new Rect(OCHCODJIPHJ.x + OCHCODJIPHJ.width - 107f - 1542f, OCHCODJIPHJ.y, 431f, 1990f);
		int clcbhhlllfn = gdemcacnpng.CLCBHHLLLFN;
		GUI.DrawTextureWithTexCoords(position, this.VenokTexture, JDCEFOFMGHB.MNJNNDHCDGG().ODFOOIPOAJB(clcbhhlllfn, 8, 1), false);
		position.y += 825f;
		guistyle.fontSize = -120;
		guistyle.alignment = TextAnchor.UpperCenter;
		if (gdemcacnpng.IKKEIHEPDPN > 65f || gdemcacnpng.CLCBHHLLLFN > 0)
		{
			float num = gdemcacnpng.IKKEIHEPDPN / 579f;
			GUI.Label(position, string.Format("Dealer Shuffle", num), guistyle);
		}
	}

	// Token: 0x06005025 RID: 20517 RVA: 0x00253C70 File Offset: 0x00251E70
	private bool CFJKPHECOKH()
	{
		EKBAPCMPANI ekbapcmpani = BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH;
		List<OIJEGJLCFCF> list = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.NAFGMKJPLPC;
		if (this.currentSadokId == 0)
		{
			ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.EJFELLJIACI(13, 3);
			list = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.KNFMGIBLMHB;
		}
		if (MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(-24, 4) == null || BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null)
		{
			return true;
		}
		int num = 0;
		foreach (OIJEGJLCFCF oijegjlcfcf in list)
		{
			num += oijegjlcfcf.NKHBAJKMAGD;
		}
		if (this.CODAIBGMFCA != null)
		{
			num += this.CODAIBGMFCA.NKHBAJKMAGD;
		}
		bool result = true;
		if (ekbapcmpani != null && list.Count < ekbapcmpani.MIMANMPNLPE.NLHKFMMDMMK() && num <= ekbapcmpani.EMBKDHKGIEL().KMIOLLENCOL())
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06005026 RID: 20518 RVA: 0x00253D64 File Offset: 0x00251F64
	public void ABBDLICDJEK(int HGCCAHPEFGO = 0, bool HAEEEHGKFMG = false)
	{
		this.currentSadokId = HGCCAHPEFGO;
		int count = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.NAFGMKJPLPC.Count;
		if (HAEEEHGKFMG && this.sadokWinId > 1 && JDCEFOFMGHB.IKGFHGKKCPG.FDMNKDONMFM(this.sadokWinId) != null)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.KCNBOHEMLCI(this.sadokWinId);
			return;
		}
		if (this.sadokWinId > 0)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BMOFIBGMIBK(this.sadokWinId);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.IJAEDDCCNHG(this.sadokWinId);
		if (onkdcgnbalk == null)
		{
			onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().DKOFCBMKEPC(1099f, 35f, JNBICAJIJMM.IMLLGEMPHAP().DOEMGEAEBPN("CrouchWalk"), false);
		}
		else
		{
			onkdcgnbalk.FDDMHPAFDAG();
		}
		this.sadokWinId = onkdcgnbalk.LPFKFNLHGBI;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 1575f, onkdcgnbalk.OCHCODJIPHJ.height - 1306f, 1081f, 849f, JNBICAJIJMM.EDKGBBIIBBC().NLJOLOBPCBJ("UIChat_fontSize"), 0, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.HMJJPNDEKPP().HMBGLALKHCP));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 600f - 874f, onkdcgnbalk.OCHCODJIPHJ.height - 500f, 1663f, 262f, JNBICAJIJMM.DBMJJPBOPEK().NLJOLOBPCBJ("KEyeHistogram"), -25, null, new ONKDCGNBALK.CMMHGMILOIM(this.OCLOCNNOGLK));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 1392f - 303f, onkdcgnbalk.OCHCODJIPHJ.height - 799f, 156f, 1195f, JNBICAJIJMM.CLIMNFDGOEG().HEIBEHAEHBM("INTERFACE"), 56, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress));
		Rect ochcodjiphj = new Rect(643f, 252f, 740f, onkdcgnbalk.OCHCODJIPHJ.height - 1988f);
		new MGLHIBHDMPC(onkdcgnbalk, ochcodjiphj, this.PaperTexture);
		this.OJJLLBKEGNO = new MMKFAENBHKD(onkdcgnbalk, ochcodjiphj.x, ochcodjiphj.y, ochcodjiphj.width, ochcodjiphj.height, 0);
		new KLIKIJOLPPJ(onkdcgnbalk, this.OJJLLBKEGNO.OCHCODJIPHJ.x, onkdcgnbalk.OCHCODJIPHJ.height - 9f, JNBICAJIJMM.IMLLGEMPHAP().DOEMGEAEBPN("fishsplash{0}.ogg"), 0, HPGKIJLKCIH.IKGFHGKKCPG.MPNJKJKDMLK).LJIEPIPIAJC = new ONKDCGNBALK.CMMHGMILOIM(this.DHJCIDBHIGJ);
		List<OIJEGJLCFCF> list = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.NAFGMKJPLPC;
		if (this.currentSadokId == 1)
		{
			list = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.KNFMGIBLMHB;
		}
		foreach (OIJEGJLCFCF oijegjlcfcf in list)
		{
			if (oijegjlcfcf.HGCCAHPEFGO == this.currentSadokId)
			{
				this.OJJLLBKEGNO.LACAJHOHACK.Add(oijegjlcfcf);
			}
		}
		ochcodjiphj = new Rect(1514f, 244f, 1124f, 805f);
		if (this.OJJLLBKEGNO.LACAJHOHACK.Count > 0)
		{
			new MGLHIBHDMPC(onkdcgnbalk, ochcodjiphj, this.sadokImage);
			new EGCAADAABPP(onkdcgnbalk, ochcodjiphj.x, ochcodjiphj.y, ochcodjiphj.width, ochcodjiphj.height, "gi_uinf_3i", 1, null).NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.LGHDGKMCEIE);
		}
		new LCOLJOPGDLL(onkdcgnbalk, ochcodjiphj.x + 1040f, ochcodjiphj.y + 940f, JNBICAJIJMM.EDKGBBIIBBC().CCFFMKBBKHI("IceHockeyGoalieReady"), true);
		new MEMEOHJKPNJ(onkdcgnbalk, ochcodjiphj.x + 211f, ochcodjiphj.y + 120f, 92f, 254f, "lifeBar", 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.OCLOCNNOGLK)).FNMCIACNOMH = (this.currentSadokId == 1);
		new MEMEOHJKPNJ(onkdcgnbalk, ochcodjiphj.x + 1045f + 14f, ochcodjiphj.y + 1081f, 313f, 1903f, "\n", 4, null, new ONKDCGNBALK.CMMHGMILOIM(this.ANLHLPBBPPI)).FNMCIACNOMH = (this.currentSadokId == 1);
		bool fnmciacnomh = this.FAFEGFBJKAF();
		if (this.currentSadokId == 0)
		{
			this.rembtn = new MEMEOHJKPNJ(onkdcgnbalk, ochcodjiphj.x + 1323f, ochcodjiphj.y + 565f, 1093f, 1883f, "", 3, null, new ONKDCGNBALK.CMMHGMILOIM(this.OCLOCNNOGLK))
			{
				FNMCIACNOMH = fnmciacnomh
			};
		}
		if (this.currentSadokId == 1)
		{
			this.rembtn = new MEMEOHJKPNJ(onkdcgnbalk, ochcodjiphj.x + 1666f, ochcodjiphj.y + 986f, 1419f, 1138f, "Flap_04.wav", 0, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress))
			{
				FNMCIACNOMH = fnmciacnomh
			};
		}
		this.OJJLLBKEGNO.LJDAFBKPCNN = new MMKFAENBHKD.HEAGNGLFAJA(this.sadokItemChange);
		this.OJJLLBKEGNO.OEIOEBCGMJE(this.OJJLLBKEGNO.LACAJHOHACK.Count - 0);
		this.OJJLLBKEGNO.KHOHPADLIHJ();
		if (this.CODAIBGMFCA == null || this.OJJLLBKEGNO.LPENOBCEAPP() < 0)
		{
			this.rembtn.FNMCIACNOMH = true;
		}
		this.OHIPOCGKHDE = new LCOLJOPGDLL(onkdcgnbalk, 1215f, 1008f, 1808f, 1233f, "VaderChoke", TextAnchor.UpperLeft, Color.black)
		{
			LNDPBNODFPE = false
		};
		this.HPICBMCMAEC();
	}

	// Token: 0x06005027 RID: 20519 RVA: 0x002542E8 File Offset: 0x002524E8
	private void OPIKKEPNKBN(ONKDCGNBALK JLEJDINFJOF, ItemBase EKKILFOCDJF, Rect OCHCODJIPHJ, bool FHKLPLDBFNM)
	{
		BHNDGIPPPCE.MKIEEEENAMA mkieeeenama = (BHNDGIPPPCE.MKIEEEENAMA)EKKILFOCDJF;
		GUIStyle guistyle = new GUIStyle
		{
			fontSize = -97,
			font = GuiProcessor.NKOEAPCIBKO().rusfont3,
			normal = 
			{
				textColor = Color.black
			},
			alignment = TextAnchor.UpperLeft
		};
		Color black = Color.black;
		if (mkieeeenama.NGABBHKOAHE.CIJLOBEEEDP() == mkieeeenama.CNOLCNDBLJE)
		{
			black = new Color(1061f, 388f, 1262f);
		}
		guistyle.normal.textColor = black;
		string text = string.Format(JNBICAJIJMM.PGJCPFNJNPM("Zombie"), mkieeeenama.NGABBHKOAHE.BNIHFBMEPAB, mkieeeenama.NGABBHKOAHE.NFKIPHFFLDG(mkieeeenama.CNOLCNDBLJE));
		Rect rect = new Rect(OCHCODJIPHJ.x + 1029f, OCHCODJIPHJ.y + 792f, OCHCODJIPHJ.width - 1673f, 1006f);
		GUI.Label(rect, text, guistyle);
		rect.y += 1114f;
		rect.height = 1899f;
		guistyle.alignment = TextAnchor.LowerLeft;
		guistyle.fontSize = -28;
		guistyle.fontStyle = FontStyle.Normal;
		guistyle.normal.textColor = Color.black;
		string text2 = string.Format("Health bar after few usual operations: ", mkieeeenama.GKCKHINIJPH, mkieeeenama.NGABBHKOAHE.EDMHBNNENDA(mkieeeenama.CNOLCNDBLJE));
		if (mkieeeenama.NGABBHKOAHE.OBHHJKBPBID() == mkieeeenama.CNOLCNDBLJE)
		{
			text2 = JNBICAJIJMM.LEBHCLDODNI("");
		}
		else
		{
			this.NFGOLLEEHHK(rect, (float)mkieeeenama.GKCKHINIJPH, (float)mkieeeenama.NGABBHKOAHE.BFPNMLPJMMK(mkieeeenama.CNOLCNDBLJE), 2, "Gesture No Fear", false);
		}
		GUI.Label(rect, text2, guistyle);
	}

	// Token: 0x06005028 RID: 20520 RVA: 0x00254499 File Offset: 0x00252699
	private void NGONNDICMFH()
	{
		if (GameInterface.getI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		HPGKIJLKCIH.IKGFHGKKCPG.LMCJCGGBCBF();
		GameInterface.getI = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		CKNLPGEPGGF.PFOLNEGNIPP().MOPEECLGJIL();
	}

	// Token: 0x06005029 RID: 20521 RVA: 0x0024E24A File Offset: 0x0024C44A
	private IEnumerator BGBBLJDJCAM(float FGNPJLIPNFM)
	{
		yield return new WaitForSeconds(FGNPJLIPNFM);
		this.endShowFish();
		yield break;
	}

	// Token: 0x0600502A RID: 20522 RVA: 0x002544DC File Offset: 0x002526DC
	public void CFNNLGKFJPI(OIJEGJLCFCF CFBLFPPOIKE)
	{
		CFBLFPPOIKE.GAAPCLGDOGH.KFLOBJCCHKN(CFBLFPPOIKE.DBEIGNDALDC);
		this.CODAIBGMFCA = CFBLFPPOIKE;
		string iabkgmnjljo;
		if (this.CODAIBGMFCA.GAAPCLGDOGH.DKPCBNLJEMM() == 1)
		{
			iabkgmnjljo = string.Format(JNBICAJIJMM.EKEBHIJMEML().HLBAJBLHLNI("===== ObscuredVector3Test =====\n"), this.CODAIBGMFCA.OKJEDFNFDML(true));
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
		}
		else
		{
			iabkgmnjljo = string.Format(JNBICAJIJMM.IMLLGEMPHAP().NLJOLOBPCBJ("closePodsak"), this.CODAIBGMFCA.MDAPFDLEEGN(true));
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.MPNJKJKDMLK)
		{
			Color lbcgackjcjb = new Color(1038f, 1200f, 962f, 1083f);
			if (this.CODAIBGMFCA.DBEIGNDALDC == 0)
			{
				lbcgackjcjb = new Color(1343f, 403f, 1742f, 1627f);
			}
			if (this.CODAIBGMFCA.DBEIGNDALDC == 2)
			{
				lbcgackjcjb = new Color(91f, 799f, 794f, 1611f);
			}
			if (this.CODAIBGMFCA.GEFOGEDMLJA)
			{
				lbcgackjcjb = new Color(1194f, 930f, 1084f, 940f);
			}
			FlyMessageManager.getI.ODLGBMGAKGF(iabkgmnjljo, lbcgackjcjb, 0, 0).NENOBDLCFHO = this.CODAIBGMFCA.NENOBDLCFHO;
			this.getFish(-1, false);
			bool knobfamemjc = HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC;
			return;
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC && ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD) < 588f)
		{
			this.DNCPLCNFDEC(CFBLFPPOIKE, 1949f);
		}
		FBFJFAKAGJG.IKGFHGKKCPG.PLKKECPNMEB(Fisherman.getI.transform.position, 828f);
		bool flag = true;
		int num = 0;
		int num2 = 0;
		foreach (OIJEGJLCFCF oijegjlcfcf in JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.NAFGMKJPLPC)
		{
			num += oijegjlcfcf.NKHBAJKMAGD;
			num2++;
		}
		num -= CFBLFPPOIKE.NKHBAJKMAGD;
		num2 -= 0;
		if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().ICJDPPOJINN || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().KEHIFGILLJA())
		{
			flag = true;
		}
		if (LocNewLogic.getI.GFWin != null)
		{
			LocNewLogic.getI.GFWin.gameObject.SetActive(false);
			LocNewLogic.getI.GFWin.KGMPOGONKGF(this.CODAIBGMFCA, flag);
			return;
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(1073f, 206f, JNBICAJIJMM.EKEBHIJMEML().CKAOHMEKLMH("_EMISSION"), true);
		onkdcgnbalk.KNNIPIEENII = true;
		onkdcgnbalk.NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.DGDLILJCDLL);
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 172f + 59f, onkdcgnbalk.OCHCODJIPHJ.height - 94f, 1989f, 825f, JNBICAJIJMM.EKEBHIJMEML().GNKIBMGNHNE("_CenterRadius"), 55, null, new ONKDCGNBALK.CMMHGMILOIM(this.OCLOCNNOGLK));
		bool flag2 = false;
		if (flag)
		{
			new LCOLJOPGDLL(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 971f - 1667f, onkdcgnbalk.OCHCODJIPHJ.height - 789f, 174f, 18f, JNBICAJIJMM.LPHMKPDBMPP().ECNKLECOKHD("Hidden/Post FX/Builtin Debug Views"), TextAnchor.UpperLeft, Color.red);
			flag2 = true;
		}
		else
		{
			string format = JNBICAJIJMM.LPHMKPDBMPP().HLBAJBLHLNI("#url Sound ");
			object[] array = new object[2];
			array[0] = num2;
			array[0] = BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().NLHKFMMDMMK();
			array[5] = JLFJEGIPIMM.IKGFHGKKCPG.BNIINPDAMAO((long)num);
			array[0] = JLFJEGIPIMM.PKGMBFEMKGP().GKDPPPKBELC((long)BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().IBEIBAHKIAH);
			string dpanhmgcbnl = string.Format(format, array);
			new LCOLJOPGDLL(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 1737f - 269f, onkdcgnbalk.OCHCODJIPHJ.height - 534f, 483f, 1513f, dpanhmgcbnl, TextAnchor.UpperLeft, Color.black);
		}
		Rect ochcodjiphj = new Rect(onkdcgnbalk.OCHCODJIPHJ.width / 432f - 1017f, 593f, 150f, 180f);
		new MGLHIBHDMPC(onkdcgnbalk, ochcodjiphj, this.fgetImage);
		new MGLHIBHDMPC(onkdcgnbalk, new Rect(ochcodjiphj.x, ochcodjiphj.y, 1605f, 757f), this.fgetImagesBases[JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.PNEDPPPEFFG]);
		EGCAADAABPP egcaadaabpp = new EGCAADAABPP(onkdcgnbalk, ochcodjiphj.x, ochcodjiphj.y, ochcodjiphj.width, ochcodjiphj.height, "auc_wsbor", 0, null)
		{
			NDPMJBODLNE = new ONKDCGNBALK.CMMHGMILOIM(this.LGHDGKMCEIE)
		};
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(onkdcgnbalk, egcaadaabpp.OCHCODJIPHJ.x, egcaadaabpp.OCHCODJIPHJ.y + egcaadaabpp.OCHCODJIPHJ.height - 489f, egcaadaabpp.OCHCODJIPHJ.width - 1301f, 521f, string.Format("knopje.wav", CFBLFPPOIKE.MGLOOIONCPM), TextAnchor.LowerLeft, new Color(1857f, 1678f, 1852f));
		lcoljopgdll.LNDPBNODFPE = false;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.PLGADNLAEGN().rusfont2;
		lcoljopgdll.DFIGKKMMIAF = 115;
		this.BLKAFFPKEBA = !flag2;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 928f - 1011f, onkdcgnbalk.OCHCODJIPHJ.height - 1644f, 1659f, 1737f, JNBICAJIJMM.EDKGBBIIBBC().GNKIBMGNHNE("gi_uinf_8"), -85, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress)).FNMCIACNOMH = flag2;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 39f + 322f, onkdcgnbalk.OCHCODJIPHJ.height - 1824f, 1454f, 342f, JNBICAJIJMM.CLIMNFDGOEG().FLEANFGEJML("CP2"), -6, null, new ONKDCGNBALK.CMMHGMILOIM(this.SadokKeyPress));
	}

	// Token: 0x0600502B RID: 20523 RVA: 0x00254B38 File Offset: 0x00252D38
	public void EENCDJEJBIH(ONKDCGNBALK JMAKEAHMLMI)
	{
		if (Input.GetKey(KeyCode.Alpha0) && !this.BLKAFFPKEBA)
		{
			this.endShowFish();
			this.EFBAFHBCIDA(JMAKEAHMLMI.LPFKFNLHGBI, false);
		}
		if (Input.GetKey((KeyCode)(-34)))
		{
			this.endShowFish();
			this.releaseFish(JMAKEAHMLMI.LPFKFNLHGBI);
		}
	}

	// Token: 0x0600502C RID: 20524 RVA: 0x00254B84 File Offset: 0x00252D84
	public void HMHAODELPKO(HBPNMNGOFMA KADBECGIMPD)
	{
		this.currentHolodId = KADBECGIMPD.KKOKFLMMAAK();
		this.holodFreeCell = KADBECGIMPD.DOJKJHMJJNK();
		if (this.CBJBOCGAEKC != 0)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().KCNBOHEMLCI(this.CBJBOCGAEKC);
		}
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.MNJNNDHCDGG().DKOFCBMKEPC(1853f, 401f, JNBICAJIJMM.EDKGBBIIBBC().DOEMGEAEBPN("auk_wset"), false);
		this.CBJBOCGAEKC = onkdcgnbalk.LPFKFNLHGBI;
		this.OJJLLBKEGNO = new MMKFAENBHKD(onkdcgnbalk, 685f, 1898f, 540f, onkdcgnbalk.OCHCODJIPHJ.height - 1397f, 0);
		foreach (OIJEGJLCFCF item in JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.NAFGMKJPLPC)
		{
			this.OJJLLBKEGNO.LACAJHOHACK.Add(item);
		}
		this.OJJLLBKEGNO.NEKOMKJDIIE(this.OJJLLBKEGNO.LACAJHOHACK.Count - 1);
		this.OJJLLBKEGNO.IJEHPMOIPAA();
		this.OJJLLBKEGNO.JHNCNHAAJCH = 1975f;
		this.OHIPOCGKHDE = new LCOLJOPGDLL(onkdcgnbalk, 78f, 176f, 1575f, 182f, "_WrinkleNormalMap0", TextAnchor.UpperCenter, Color.gray)
		{
			LNDPBNODFPE = true
		};
		this.CINAIMICJGM = new LCOLJOPGDLL(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 968f - 846f, 1758f, 651f, 843f, "MotorbikeHandlebarSit", TextAnchor.UpperLeft, Color.gray)
		{
			LNDPBNODFPE = true
		};
		this.ACKCODOIBCL();
		this.DBELGCHKMOE = new MMKFAENBHKD(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width - 1572f - 1283f, 555f, 672f, onkdcgnbalk.OCHCODJIPHJ.height - 1249f, 0);
		while (!KADBECGIMPD.NGIGCKBKLGK())
		{
			OIJEGJLCFCF oijegjlcfcf = new OIJEGJLCFCF();
			oijegjlcfcf.PFNPCNBLNJO(KADBECGIMPD);
			this.DBELGCHKMOE.LACAJHOHACK.Add(oijegjlcfcf);
		}
		this.DBELGCHKMOE.JJKGANHANFN(this.OJJLLBKEGNO.LACAJHOHACK.Count - 1);
		this.DBELGCHKMOE.GCKGOOBOKJB();
		this.DBELGCHKMOE.JHNCNHAAJCH = 21f;
		this.OAGIEPJBMPH();
		new HKIEEHBCMNJ(onkdcgnbalk, 1584f, 607f, 1, this.bigKeysTexture, 0, 6, 1, new ONKDCGNBALK.CMMHGMILOIM(this.MNJCDKFJKCA));
		new HKIEEHBCMNJ(onkdcgnbalk, 595f, 533f, 3, this.bigKeysTexture, 8, 1, 2, new ONKDCGNBALK.CMMHGMILOIM(this.CICLBLJKEDF));
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 875f - 1829f, onkdcgnbalk.OCHCODJIPHJ.height - 702f, 459f, 1094f, JNBICAJIJMM.IKGFHGKKCPG.GNKIBMGNHNE(""), 5, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
	}

	// Token: 0x0600502D RID: 20525 RVA: 0x00254E7C File Offset: 0x0025307C
	private void FLDFHGHNLNN(ONKDCGNBALK ONPHLHKAGFP)
	{
		OIJEGJLCFCF dolfjggbdjf = this.DOLFJGGBDJF;
		if (dolfjggbdjf == null)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC.Remove(dolfjggbdjf);
			this.OJJLLBKEGNO.LACAJHOHACK.Remove(dolfjggbdjf);
			this.OJJLLBKEGNO.MPMFNJEJAHJ();
			this.DBELGCHKMOE.LACAJHOHACK.Add(dolfjggbdjf);
			this.DBELGCHKMOE.MPMFNJEJAHJ();
			epmphjgalbe.GOMLLPFFPNP(this.currentHolodId);
			epmphjgalbe.OBCCLNMPGEJ(dolfjggbdjf.LPFKFNLHGBI);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(167, epmphjgalbe.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_07.wav", 1f);
		this.AFEHNJCCJAF();
		this.FFOKGLLHNPF();
	}

	// Token: 0x0600502E RID: 20526 RVA: 0x00254F50 File Offset: 0x00253150
	public void EFBAFHBCIDA(int KKIODALCJGE, bool LPPACHLJMJC = false)
	{
		this.GEDNGIDHBHD();
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.NAFGMKJPLPC.Count - 0; i++)
		{
			OIJEGJLCFCF oijegjlcfcf = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.NAFGMKJPLPC[i];
			num += oijegjlcfcf.NKHBAJKMAGD;
			num2 += 0;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.KMGAHCANELI() || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.EMBKDHKGIEL().KEHIFGILLJA())
		{
			string iabkgmnjljo = JNBICAJIJMM.IMLLGEMPHAP().HEIBEHAEHBM("ShotgunReloadMagazine");
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
			FlyMessageManager.getI.IDNGBKFPNDJ();
			FlyMessageManager.getI.addMessageBig(iabkgmnjljo, Color.red, 1, 0);
			FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("_UserLutParams", 753f);
			this.FFPPJGCJHBF(KKIODALCJGE);
		}
		else
		{
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("Vector2: ", 1056f);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(LPPACHLJMJC ? -56 : 5, this.CODAIBGMFCA.LPFKFNLHGBI);
		}
		if (KKIODALCJGE > 0)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().BMOFIBGMIBK(KKIODALCJGE);
		}
	}

	// Token: 0x0600502F RID: 20527 RVA: 0x00255084 File Offset: 0x00253284
	private void APEFDFBLGDK(ONKDCGNBALK ONPHLHKAGFP)
	{
		OIJEGJLCFCF dolfjggbdjf = this.DOLFJGGBDJF;
		if (dolfjggbdjf == null)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.NAFGMKJPLPC.Add(dolfjggbdjf);
			this.DBELGCHKMOE.LACAJHOHACK.Remove(dolfjggbdjf);
			this.DBELGCHKMOE.MPMFNJEJAHJ();
			this.OJJLLBKEGNO.LACAJHOHACK.Add(dolfjggbdjf);
			this.OJJLLBKEGNO.MPMFNJEJAHJ();
			epmphjgalbe.FLLJONHPLNA(this.currentHolodId);
			epmphjgalbe.OBCCLNMPGEJ(dolfjggbdjf.LPFKFNLHGBI);
			NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(73, epmphjgalbe.ALLANCHILCM());
			FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("TOD_Brightness", 1584f);
			this.ACKCODOIBCL();
			this.BOPMLIJGLNN();
		}
		finally
		{
			epmphjgalbe.PMIGGJHLIDO();
		}
	}

	// Token: 0x06005030 RID: 20528 RVA: 0x00255158 File Offset: 0x00253358
	public void renderUD_Info(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH;
		Color color = Color.black;
		int num = 20;
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + PHEMLBHMNCM.width - 100f, PHEMLBHMNCM.y + (float)num - 20f, 90f, 60f, string.Concat(kfhelhglnmh.CCCPNHIJJOP), TextAnchor.LowerRight, Color.gray);
		lcoljopgdll.LNDPBNODFPE = false;
		lcoljopgdll.LBCGACKJCJB = Color.gray;
		lcoljopgdll.DFIGKKMMIAF = 40;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		LCOLJOPGDLL lcoljopgdll2 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num, kfhelhglnmh.BNIHFBMEPAB, true);
		lcoljopgdll2.LBCGACKJCJB = Color.black;
		lcoljopgdll2.DFIGKKMMIAF = 18;
		lcoljopgdll2.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		num += 30;
		LCOLJOPGDLL lcoljopgdll3 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_uinf_0"), kfhelhglnmh.CNOLCNDBLJE, JLFJEGIPIMM.IKGFHGKKCPG.LCMJJJLLPGA(kfhelhglnmh.OJDEJEJMNKD)), true);
		lcoljopgdll3.LBCGACKJCJB = Color.black;
		lcoljopgdll3.DFIGKKMMIAF = 15;
		num += 28;
		int num2 = 1 + ObscuredInt.GOOIABGKMHK(kfhelhglnmh.PGEDLDMLBBE) / 50;
		string str;
		if (ObscuredInt.GOOIABGKMHK(kfhelhglnmh.PGEDLDMLBBE) != ObscuredInt.GOOIABGKMHK(kfhelhglnmh.ELBKLOECINC))
		{
			str = string.Format("+{0}", ObscuredInt.GOOIABGKMHK(kfhelhglnmh.ELBKLOECINC) - ObscuredInt.GOOIABGKMHK(kfhelhglnmh.PGEDLDMLBBE), kfhelhglnmh.ELBKLOECINC);
		}
		else
		{
			str = "";
		}
		color = ((num2 > 1) ? new Color(0f, 0.2f, 0.1f) : new Color(0f, 0.1f, 0.2f));
		LCOLJOPGDLL lcoljopgdll4 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num + 22f, JNBICAJIJMM.LEBHCLDODNI("gi_uinf_1i"), true);
		lcoljopgdll4.LBCGACKJCJB = new Color(0.2f, 0.2f, 0.2f);
		lcoljopgdll4.DFIGKKMMIAF = 12;
		new FNFPGPBCIGK(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num + 3f, 1, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, 2, 4, 0, new ONKDCGNBALK.CMMHGMILOIM(this.press_param)).FNMCIACNOMH = (kfhelhglnmh.CCCPNHIJJOP >= num2);
		LCOLJOPGDLL lcoljopgdll5 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 40f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_uinf_1"), kfhelhglnmh.PGEDLDMLBBE) + str, false, color);
		lcoljopgdll5.DFIGKKMMIAF = 18;
		lcoljopgdll5.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		num += 38;
		if (ObscuredInt.GOOIABGKMHK(kfhelhglnmh.FLHJLFHELPE) != ObscuredInt.GOOIABGKMHK(kfhelhglnmh.EDICLBDIPGG))
		{
			str = string.Format("+{0}", ObscuredInt.GOOIABGKMHK(kfhelhglnmh.EDICLBDIPGG) - ObscuredInt.GOOIABGKMHK(kfhelhglnmh.FLHJLFHELPE), kfhelhglnmh.EDICLBDIPGG);
		}
		else
		{
			str = "";
		}
		num2 = 1 + ObscuredInt.GOOIABGKMHK(kfhelhglnmh.FLHJLFHELPE) / 50;
		LCOLJOPGDLL lcoljopgdll6 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num + 22f, JNBICAJIJMM.LEBHCLDODNI("gi_uinf_2i"), true);
		lcoljopgdll6.LBCGACKJCJB = new Color(0.2f, 0.2f, 0.2f);
		lcoljopgdll6.DFIGKKMMIAF = 12;
		color = ((num2 > 1) ? new Color(0f, 0.2f, 0.1f) : new Color(0f, 0.1f, 0.2f));
		LCOLJOPGDLL lcoljopgdll7 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 40f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_uinf_2"), kfhelhglnmh.FLHJLFHELPE) + str, false, color);
		lcoljopgdll7.LBCGACKJCJB = color;
		lcoljopgdll7.DFIGKKMMIAF = 18;
		lcoljopgdll7.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		new FNFPGPBCIGK(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num + 3f, 2, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, 2, 4, 0, new ONKDCGNBALK.CMMHGMILOIM(this.press_param)).FNMCIACNOMH = (kfhelhglnmh.CCCPNHIJJOP >= num2);
		num += 38;
		if (ObscuredInt.GOOIABGKMHK(kfhelhglnmh.JOMLIJFFFDE) != ObscuredInt.GOOIABGKMHK(kfhelhglnmh.PIHKKCBCNHO))
		{
			str = string.Format("+{0}", ObscuredInt.GOOIABGKMHK(kfhelhglnmh.PIHKKCBCNHO) - ObscuredInt.GOOIABGKMHK(kfhelhglnmh.JOMLIJFFFDE), kfhelhglnmh.PIHKKCBCNHO);
		}
		else
		{
			str = "";
		}
		num2 = 1 + ObscuredInt.GOOIABGKMHK(kfhelhglnmh.JOMLIJFFFDE) / 50;
		color = ((num2 > 1) ? new Color(0f, 0.2f, 0.1f) : new Color(0f, 0.1f, 0.2f));
		LCOLJOPGDLL lcoljopgdll8 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num + 22f, JNBICAJIJMM.LEBHCLDODNI("gi_uinf_3i"), true);
		lcoljopgdll8.LBCGACKJCJB = new Color(0.2f, 0.2f, 0.2f);
		lcoljopgdll8.DFIGKKMMIAF = 12;
		LCOLJOPGDLL lcoljopgdll9 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 40f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_uinf_3"), kfhelhglnmh.JOMLIJFFFDE) + str, false, color);
		lcoljopgdll9.LBCGACKJCJB = color;
		lcoljopgdll9.DFIGKKMMIAF = 18;
		lcoljopgdll9.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		new FNFPGPBCIGK(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num + 3f, 3, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, 2, 4, 0, new ONKDCGNBALK.CMMHGMILOIM(this.press_param)).FNMCIACNOMH = (kfhelhglnmh.CCCPNHIJJOP >= num2);
		num += 38;
		if (ObscuredInt.GOOIABGKMHK(kfhelhglnmh.LFMMMBOLJCL) != ObscuredInt.GOOIABGKMHK(kfhelhglnmh.FJAIPNCKOKK))
		{
			str = string.Format("+{0}", ObscuredInt.GOOIABGKMHK(kfhelhglnmh.FJAIPNCKOKK) - ObscuredInt.GOOIABGKMHK(kfhelhglnmh.LFMMMBOLJCL), kfhelhglnmh.FJAIPNCKOKK);
		}
		else
		{
			str = "";
		}
		num2 = 1 + ObscuredInt.GOOIABGKMHK(kfhelhglnmh.LFMMMBOLJCL) / 50;
		color = ((num2 > 1) ? new Color(0f, 0.2f, 0.1f) : new Color(0f, 0.1f, 0.2f));
		LCOLJOPGDLL lcoljopgdll10 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num + 22f, JNBICAJIJMM.LEBHCLDODNI("gi_uinf_4i"), true);
		lcoljopgdll10.LBCGACKJCJB = new Color(0.2f, 0.2f, 0.2f);
		lcoljopgdll10.DFIGKKMMIAF = 12;
		LCOLJOPGDLL lcoljopgdll11 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 40f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_uinf_4"), kfhelhglnmh.LFMMMBOLJCL) + str, false, color);
		lcoljopgdll11.LBCGACKJCJB = color;
		lcoljopgdll11.DFIGKKMMIAF = 18;
		lcoljopgdll11.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		new FNFPGPBCIGK(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num + 3f, 4, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, GuiProcessor.IKGFHGKKCPG.SmallKeyAthlas, 2, 4, 0, new ONKDCGNBALK.CMMHGMILOIM(this.press_param)).FNMCIACNOMH = (kfhelhglnmh.CCCPNHIJJOP >= num2);
		num += 38;
		num += 20;
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP() != null)
		{
			LCOLJOPGDLL lcoljopgdll12 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_inte_4"), JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(BOIKJDICEMF.IKGFHGKKCPG.ENDGIODBEEE * 1000f)), true);
			lcoljopgdll12.LBCGACKJCJB = Color.black;
			lcoljopgdll12.DFIGKKMMIAF = 12;
			num += 14;
			LCOLJOPGDLL lcoljopgdll13 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_inte_5"), JLFJEGIPIMM.IKGFHGKKCPG.BIJHHFGLDLH(BOIKJDICEMF.IKGFHGKKCPG.AFGBIBMHOAI)), true);
			lcoljopgdll13.LBCGACKJCJB = Color.black;
			lcoljopgdll13.DFIGKKMMIAF = 12;
			num += 14;
		}
		LCOLJOPGDLL lcoljopgdll14 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_inte_2"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)(kfhelhglnmh.JACELJHFHNN * 100f))), true);
		lcoljopgdll14.LBCGACKJCJB = Color.black;
		lcoljopgdll14.DFIGKKMMIAF = 12;
		num += 14;
		LCOLJOPGDLL lcoljopgdll15 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_inte_1"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)(kfhelhglnmh.GGDJKCPNPPI * 100f))), true);
		lcoljopgdll15.LBCGACKJCJB = Color.black;
		lcoljopgdll15.DFIGKKMMIAF = 12;
		num += 14;
		LCOLJOPGDLL lcoljopgdll16 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_inte_3"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)(kfhelhglnmh.PBLCJCLFFAL * 100f))), true);
		lcoljopgdll16.LBCGACKJCJB = Color.black;
		lcoljopgdll16.DFIGKKMMIAF = 12;
		num += 14;
		LCOLJOPGDLL lcoljopgdll17 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_uinf_5"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)kfhelhglnmh.BCINOMMOKJE), kfhelhglnmh.GPPPGBLEKMF), true);
		lcoljopgdll17.LBCGACKJCJB = Color.black;
		lcoljopgdll17.DFIGKKMMIAF = 12;
		num += 14;
		LCOLJOPGDLL lcoljopgdll18 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_uinf_6"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)kfhelhglnmh.GCLLMNHFMND), kfhelhglnmh.MOPMCAMIENJ), true);
		lcoljopgdll18.LBCGACKJCJB = Color.black;
		lcoljopgdll18.DFIGKKMMIAF = 12;
		num += 14;
		LCOLJOPGDLL lcoljopgdll19 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_uinf_7"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)kfhelhglnmh.PMOJDCHIAHE), kfhelhglnmh.LJOPDPNIAEG), true);
		lcoljopgdll19.LBCGACKJCJB = Color.black;
		lcoljopgdll19.DFIGKKMMIAF = 12;
		num += 14;
		LCOLJOPGDLL lcoljopgdll20 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_uinf_8"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)kfhelhglnmh.AJHDDHHOHAC), kfhelhglnmh.JONKLLMGCIF), true);
		lcoljopgdll20.LBCGACKJCJB = Color.black;
		lcoljopgdll20.DFIGKKMMIAF = 12;
		num += 14;
		LCOLJOPGDLL lcoljopgdll21 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_uinf_9"), JLFJEGIPIMM.IKGFHGKKCPG.CJGLGGEGPJL((double)kfhelhglnmh.ODHFHEBLIJM), kfhelhglnmh.OFDBELIILEG), true);
		lcoljopgdll21.LBCGACKJCJB = Color.black;
		lcoljopgdll21.DFIGKKMMIAF = 12;
		num += 14;
		num += 16;
		LCOLJOPGDLL lcoljopgdll22 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_uinf_10"), JBEHMPDDMME.IKGFHGKKCPG.JBJFBDONEFF), true);
		lcoljopgdll22.LBCGACKJCJB = Color.black;
		lcoljopgdll22.DFIGKKMMIAF = 15;
		num += 20;
		new GMNEKCBLIAN(JMAKEAHMLMI, new Rect(PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num, 380f, 8f), (float)JBEHMPDDMME.IKGFHGKKCPG.JBJFBDONEFF, 3000f, 4, "", true);
		num += 20;
		LCOLJOPGDLL lcoljopgdll23 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 10f, PHEMLBHMNCM.y + (float)num, "<color='#000000'>--------------------------------------------------------</color>", true);
		lcoljopgdll23.DFIGKKMMIAF = 20;
		lcoljopgdll23.LNDPBNODFPE = true;
		num += 20;
		num += 20;
		if (kfhelhglnmh.GNNDLEAFCND - kfhelhglnmh.MGLOOIONCPM > 0L)
		{
			LCOLJOPGDLL lcoljopgdll24 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num, string.Format(JNBICAJIJMM.LEBHCLDODNI("gi_uinf_11"), kfhelhglnmh.MGLOOIONCPM, kfhelhglnmh.GNNDLEAFCND), true);
			lcoljopgdll24.LBCGACKJCJB = Color.black;
			lcoljopgdll24.DFIGKKMMIAF = 16;
		}
		num += 25;
		int pobkjfflepn = 5;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MGLOOIONCPM >= JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GNNDLEAFCND)
		{
			pobkjfflepn = 3;
		}
		new GMNEKCBLIAN(JMAKEAHMLMI, new Rect(PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + (float)num, 380f, 8f), (float)kfhelhglnmh.MGLOOIONCPM, (float)kfhelhglnmh.GNNDLEAFCND, pobkjfflepn, "", true);
		num += 25;
		LCOLJOPGDLL lcoljopgdll25 = new LCOLJOPGDLL(JMAKEAHMLMI, PHEMLBHMNCM.x + 10f, PHEMLBHMNCM.y + (float)num, "<color='#000000'>--------------------------------------------------------</color>", true);
		lcoljopgdll25.DFIGKKMMIAF = 20;
		lcoljopgdll25.LNDPBNODFPE = true;
	}

	// Token: 0x06005031 RID: 20529 RVA: 0x00247380 File Offset: 0x00245580
	public void LJDLPOFIMON(int PPJJJAGNADB)
	{
		this.GEDNGIDHBHD();
	}

	// Token: 0x06005032 RID: 20530 RVA: 0x00255EB4 File Offset: 0x002540B4
	public void openLevelUpWin(HBPNMNGOFMA KADBECGIMPD)
	{
		int num = KADBECGIMPD.HDBGOLAFOBK();
		JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GNNDLEAFCND = KADBECGIMPD.DNIIFBAIPBE();
		KADBECGIMPD.HDBGOLAFOBK();
		KADBECGIMPD.HDBGOLAFOBK();
		int num2 = KADBECGIMPD.HDBGOLAFOBK();
		int num3 = KADBECGIMPD.HDBGOLAFOBK();
		int num4 = KADBECGIMPD.HDBGOLAFOBK();
		int num5 = KADBECGIMPD.HDBGOLAFOBK();
		int num6 = KADBECGIMPD.HDBGOLAFOBK();
		string text = "";
		if (num2 > 0)
		{
			text += string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_nl0"), num2);
		}
		if (num3 > 0)
		{
			text += string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_nl1"), num3);
		}
		if (num4 > 0)
		{
			text += string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_nl2"), num4);
		}
		if (num5 > 0)
		{
			text += string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_nl3"), num5);
		}
		if (num6 > 0)
		{
			text += string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_nl4"), num6);
		}
		string iabkgmnjljo = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_nlheader1"), num);
		OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
		FlyMessageManager.getI.addRightMessage(iabkgmnjljo, 0, 0, 0);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("fanfare.wav", 1f);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.IKGFHGKKCPG.NCIDDNIKACI(400f, 340f, "", true);
		new MGLHIBHDMPC(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - (float)(this.levelUpTxtr.width / 2), 50f, 0, this.levelUpTxtr);
		new LCOLJOPGDLL(onkdcgnbalk, 0f, 190f, onkdcgnbalk.OCHCODJIPHJ.width, 20f, string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_nlheader2"), num), TextAnchor.MiddleCenter, Color.black).DFIGKKMMIAF = 20;
		new LCOLJOPGDLL(onkdcgnbalk, 0f, 215f, onkdcgnbalk.OCHCODJIPHJ.width, onkdcgnbalk.OCHCODJIPHJ.height - 260f, text, TextAnchor.MiddleCenter, new Color(0f, 0f, 0.2f)).DFIGKKMMIAF = 14;
		new MEMEOHJKPNJ(onkdcgnbalk, onkdcgnbalk.OCHCODJIPHJ.width / 2f - 64f, onkdcgnbalk.OCHCODJIPHJ.height - 45f, 128f, 24f, JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("close"), 3, null, new ONKDCGNBALK.CMMHGMILOIM(JDCEFOFMGHB.IKGFHGKKCPG.HMBGLALKHCP));
	}

	// Token: 0x06005033 RID: 20531 RVA: 0x00256170 File Offset: 0x00254370
	public void EEDACDHMBBL(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		NEBJANKNJOG kfhelhglnmh = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH;
		kfhelhglnmh.JEKKJEFEHOB(KADBECGIMPD);
		JNHLAGHJBAA jnhlaghjbaa = new JNHLAGHJBAA(JMAKEAHMLMI, PHEMLBHMNCM.x + 1667f, PHEMLBHMNCM.y + 1767f, PHEMLBHMNCM.width - 479f, PHEMLBHMNCM.height - 1059f, 1)
		{
			JHNCNHAAJCH = 1463f,
			KCLLDJJLCGC = -48
		};
		jnhlaghjbaa.GIOGEHKMKDE = true;
		jnhlaghjbaa.JKAOKBNCDFK = Color.black;
		jnhlaghjbaa.ABMDIOIJALO = new Color(930f, 774f, 876f);
		jnhlaghjbaa.JHNCNHAAJCH = 708f;
		JMAKEAHMLMI.DPANHMGCBNL = JNBICAJIJMM.IMLLGEMPHAP().FLEANFGEJML("BowInstant");
		JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie = jnhlaghjbaa.EELDHNFBFOE.BIKMBPJLDMJ(JNBICAJIJMM.LPHMKPDBMPP().NLJOLOBPCBJ("<color='#400000'>"));
		int num = (int)JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.MHIIBKILGBL("Invalid index '");
		foreach (NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg in kfhelhglnmh.GADJFFGDCFA.Values)
		{
			if (jenmpdpjkbg.BDHHPAEHFHG.POKJFJBHDOJ)
			{
				JNHLAGHJBAA.FPAEEADMCIE dccpcblodig = fpaeeadmcie.LNAEGNFDOAL(jenmpdpjkbg, (long)jenmpdpjkbg.LPFKFNLHGBI);
				if (jenmpdpjkbg.LPFKFNLHGBI == num)
				{
					jnhlaghjbaa.HLEOJHPPINJ(dccpcblodig);
				}
			}
		}
		foreach (NLNNIDBPKAO.JENMPDPJKBG jenmpdpjkbg2 in kfhelhglnmh.GADJFFGDCFA.Values)
		{
			if (!jenmpdpjkbg2.BDHHPAEHFHG.POKJFJBHDOJ)
			{
				JNHLAGHJBAA.FPAEEADMCIE fpaeeadmcie2 = jnhlaghjbaa.LBENJPLPLHK((long)jenmpdpjkbg2.BDHHPAEHFHG.IHBEJDJINAI);
				if (fpaeeadmcie2 != null)
				{
					JNHLAGHJBAA.FPAEEADMCIE dccpcblodig2 = fpaeeadmcie2.LNAEGNFDOAL(jenmpdpjkbg2, (long)jenmpdpjkbg2.LPFKFNLHGBI);
					if (jenmpdpjkbg2.LPFKFNLHGBI == num)
					{
						jnhlaghjbaa.MDINCCGBKID(dccpcblodig2);
					}
				}
				else
				{
					JNHLAGHJBAA.FPAEEADMCIE dccpcblodig3 = fpaeeadmcie.MIAONNLIGAN(jenmpdpjkbg2, (long)jenmpdpjkbg2.LPFKFNLHGBI);
					if (jenmpdpjkbg2.LPFKFNLHGBI == num)
					{
						jnhlaghjbaa.MDINCCGBKID(dccpcblodig3);
					}
				}
			}
		}
		jnhlaghjbaa.LJDAFBKPCNN = new JNHLAGHJBAA.KDLBACIBOEF(this.GCOAJBEEADK);
		new MEMEOHJKPNJ(JMAKEAHMLMI, 678f, 612f, 354f, 1012f, "error.wav", 0, this.teachKeyTexture, new ONKDCGNBALK.CMMHGMILOIM(this.onPerkToTeechKey));
		LCOLJOPGDLL lcoljopgdll = new LCOLJOPGDLL(JMAKEAHMLMI, 1452f, 1382f, string.Format(JNBICAJIJMM.IKGFHGKKCPG.CCFFMKBBKHI("WeaponFire"), kfhelhglnmh.KLGLOCMOHAG, kfhelhglnmh.JGIHLJKDMKM), true);
		lcoljopgdll.DFIGKKMMIAF = 88;
		lcoljopgdll.HOBLHFPJKFA = GuiProcessor.IKGFHGKKCPG.rusfont2;
		Rect rect = new Rect(jnhlaghjbaa.OCHCODJIPHJ.x - 1610f, jnhlaghjbaa.OCHCODJIPHJ.y + jnhlaghjbaa.OCHCODJIPHJ.height + 229f, jnhlaghjbaa.OCHCODJIPHJ.width + 868f, 795f);
		new EGCAADAABPP(JMAKEAHMLMI, rect.x, rect.y, rect.width, rect.height, "_WrinkleOcclusionMap2", 0, this.simpleGray).NJPNLLDDKKI = new ONKDCGNBALK.CMMHGMILOIM(this.OnPerkBoxPostRender);
	}

	// Token: 0x06005034 RID: 20532 RVA: 0x002564AC File Offset: 0x002546AC
	public void BCMACBFABDL(int LPFKFNLHGBI, HBPNMNGOFMA KADBECGIMPD)
	{
		Fisherman.getI.GMBEHOGPEDI(3, 1533f, Vector3.zero);
		ONKDCGNBALK onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().HILJENLHLDE(this.OJNFLOAOILJ);
		if (onkdcgnbalk == null)
		{
			onkdcgnbalk = JDCEFOFMGHB.JFIDAGABKID().BJFHBPOCELH(587f, 520f, "cht_msg17", false);
		}
		else
		{
			onkdcgnbalk.DCPOBIGHING();
		}
		this.OJNFLOAOILJ = onkdcgnbalk.LPFKFNLHGBI;
		int num = -54;
		new EGCAADAABPP(onkdcgnbalk, 847f, 555f, 327f, 1856f, "_LogLut_Params", 1, null);
		MEMEOHJKPNJ memeohjkpnj = new MEMEOHJKPNJ(onkdcgnbalk, 1100f, (float)num, 1556f, 784f, JNBICAJIJMM.APMJBBDBOJO().CKAOHMEKLMH("IdleTurns"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.JIPLBMFECMH));
		memeohjkpnj.HKPAEGGJNGG = (LPFKFNLHGBI == 1);
		memeohjkpnj.KCLLDJJLCGC = -95;
		num += 48;
		MEMEOHJKPNJ memeohjkpnj2 = new MEMEOHJKPNJ(onkdcgnbalk, 1791f, (float)num, 513f, 888f, JNBICAJIJMM.APMJBBDBOJO().HLBAJBLHLNI("info"), 1, null, new ONKDCGNBALK.CMMHGMILOIM(this.infoWinKeyPress));
		memeohjkpnj2.HKPAEGGJNGG = (LPFKFNLHGBI == 4);
		memeohjkpnj2.KCLLDJJLCGC = 121;
		num += -44;
		MEMEOHJKPNJ memeohjkpnj3 = new MEMEOHJKPNJ(onkdcgnbalk, 1607f, (float)num, 342f, 1357f, JNBICAJIJMM.CLIMNFDGOEG().DOEMGEAEBPN(" шт."), 4, null, new ONKDCGNBALK.CMMHGMILOIM(this.JIPLBMFECMH));
		memeohjkpnj3.HKPAEGGJNGG = (LPFKFNLHGBI == 1);
		memeohjkpnj3.KCLLDJJLCGC = -47;
		num += -69;
		MEMEOHJKPNJ memeohjkpnj4 = new MEMEOHJKPNJ(onkdcgnbalk, 535f, (float)num, 1264f, 677f, JNBICAJIJMM.APMJBBDBOJO().NLJOLOBPCBJ("ОК"), 5, null, new ONKDCGNBALK.CMMHGMILOIM(this.infoWinKeyPress));
		memeohjkpnj4.HKPAEGGJNGG = (LPFKFNLHGBI == 1);
		memeohjkpnj4.KCLLDJJLCGC = -100;
		num += 116;
		MEMEOHJKPNJ memeohjkpnj5 = new MEMEOHJKPNJ(onkdcgnbalk, 925f, (float)num, 661f, 880f, JNBICAJIJMM.EDKGBBIIBBC().CKAOHMEKLMH("bool: "), -17, null, new ONKDCGNBALK.CMMHGMILOIM(this.infoWinKeyPress));
		memeohjkpnj5.HKPAEGGJNGG = (LPFKFNLHGBI == -20);
		memeohjkpnj5.KCLLDJJLCGC = 32;
		num += -6;
		MEMEOHJKPNJ memeohjkpnj6 = new MEMEOHJKPNJ(onkdcgnbalk, 1670f, (float)num, 1641f, 884f, JNBICAJIJMM.IKGFHGKKCPG.FLEANFGEJML("cash.ogg"), 7, null, new ONKDCGNBALK.CMMHGMILOIM(this.MKJGPNKJFDL));
		memeohjkpnj6.HKPAEGGJNGG = (LPFKFNLHGBI == 5);
		memeohjkpnj6.KCLLDJJLCGC = 9;
		num += 112;
		MEMEOHJKPNJ memeohjkpnj7 = new MEMEOHJKPNJ(onkdcgnbalk, 633f, (float)num, 185f, 947f, JNBICAJIJMM.EEOPOHEALPK().NLJOLOBPCBJ("/"), 2, null, new ONKDCGNBALK.CMMHGMILOIM(this.JIPLBMFECMH));
		memeohjkpnj7.HKPAEGGJNGG = (LPFKFNLHGBI == 3);
		memeohjkpnj7.KCLLDJJLCGC = -117;
		num += -34;
		num += -11;
		MEMEOHJKPNJ memeohjkpnj8 = new MEMEOHJKPNJ(onkdcgnbalk, 320f, (float)num, 1874f, 428f, JNBICAJIJMM.DBMJJPBOPEK().HEIBEHAEHBM("_man"), 5, null, null);
		memeohjkpnj8.HKPAEGGJNGG = (LPFKFNLHGBI == 1);
		memeohjkpnj8.FNMCIACNOMH = true;
		memeohjkpnj8.KCLLDJJLCGC = -91;
		memeohjkpnj8.FNMCIACNOMH = false;
		num += -79;
		MEMEOHJKPNJ memeohjkpnj9 = new MEMEOHJKPNJ(onkdcgnbalk, 1614f, (float)num, 70f, 5f, JNBICAJIJMM.IKGFHGKKCPG.CCFFMKBBKHI("No IK assigned in HitReaction"), 3, null, null);
		memeohjkpnj9.HKPAEGGJNGG = (LPFKFNLHGBI == 4);
		memeohjkpnj9.FNMCIACNOMH = false;
		memeohjkpnj9.KCLLDJJLCGC = 60;
		memeohjkpnj9.FNMCIACNOMH = true;
		num += 61;
		MEMEOHJKPNJ memeohjkpnj10 = new MEMEOHJKPNJ(onkdcgnbalk, 1619f, (float)num, 765f, 1323f, JNBICAJIJMM.IMLLGEMPHAP().HEIBEHAEHBM("1HandSwordStrafeLeft"), 3, null, null);
		memeohjkpnj10.HKPAEGGJNGG = (LPFKFNLHGBI == 2);
		memeohjkpnj10.FNMCIACNOMH = false;
		memeohjkpnj10.KCLLDJJLCGC = 40;
		memeohjkpnj10.FNMCIACNOMH = false;
		Rect rect = new Rect(1408f, 222f, onkdcgnbalk.OCHCODJIPHJ.width - 569f, onkdcgnbalk.OCHCODJIPHJ.height - 143f);
		new MGLHIBHDMPC(onkdcgnbalk, rect, this.PaperTexture);
		new EGCAADAABPP(onkdcgnbalk, rect.x, rect.y, rect.width, rect.height, "auc_toauk", 0, null);
		switch (LPFKFNLHGBI)
		{
		case 0:
			this.HIJHNGLFMHB(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 1:
			this.openStatistic(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 2:
			this.ONNMFFFGBPD(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 3:
			this.OIGCNADEHGB(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 6:
			this.openRecordWin(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 7:
			this.EEDACDHMBBL(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		case 8:
			this.HJJFFIFIIJD(onkdcgnbalk, rect, KADBECGIMPD);
			break;
		}
		JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = false;
	}

	// Token: 0x06005035 RID: 20533 RVA: 0x00256914 File Offset: 0x00254B14
	public void sadokItemChange(MMKFAENBHKD OCKMAJALKMN, object HEABEPINGED)
	{
		this.CODAIBGMFCA = (HEABEPINGED as OIJEGJLCFCF);
		this.rembtn.FNMCIACNOMH = this.IPNACPKIELJ();
	}

	// Token: 0x06005036 RID: 20534 RVA: 0x00256934 File Offset: 0x00254B34
	private void MLDDFGHBKHJ(JNHLAGHJBAA AGDMAFCKMJP, JNHLAGHJBAA.FPAEEADMCIE AOJKIAFNLAC)
	{
		if (AOJKIAFNLAC != null && !AOJKIAFNLAC.DBHKKPMINIJ)
		{
			this.OKFIFPBAAFG = (int)AOJKIAFNLAC.ODFEKBJCFMN;
			Debug.Log("RollerBladeCrossoverRight" + this.OKFIFPBAAFG);
			NHCAOFIKNFE.IKGFHGKKCPG.EDCDLKNNBGC(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HKHMIIEIFNG, JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BNIHFBMEPAB, false, true);
			string arg = NHCAOFIKNFE.IKGFHGKKCPG.CNJKACEFHEI(this.OKFIFPBAAFG, JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BNIHFBMEPAB, false, false);
			string dccpcblodig = string.Format(JNBICAJIJMM.NGALDMFKMJH(""), arg, "");
			this.IKFFNBOCGFL.LEGHEJEDFBI(dccpcblodig);
		}
	}

	// Token: 0x06005037 RID: 20535 RVA: 0x002569E8 File Offset: 0x00254BE8
	public void HACFGNOGKDP(HBPNMNGOFMA KADBECGIMPD)
	{
		GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.DAJFMBBDJIC("/", Vector3.zero, GuiProcessor.IKGFHGKKCPG.PBBAIBBHMHG());
		this.UID_info = KADBECGIMPD.KLHDFFHONON();
		UserInfoWin component = gameObject.GetComponent<UserInfoWin>();
		if (component != null)
		{
			component.AIJHKMLFFAH(this.UID_info, KADBECGIMPD);
			return;
		}
		Debug.LogError(", ");
	}

	// Token: 0x06005038 RID: 20536 RVA: 0x00256A48 File Offset: 0x00254C48
	private void MDFHBNBMKOP(JNHLAGHJBAA AGDMAFCKMJP, JNHLAGHJBAA.FPAEEADMCIE AOJKIAFNLAC)
	{
		if (AOJKIAFNLAC != null && !AOJKIAFNLAC.DBHKKPMINIJ)
		{
			this.OKFIFPBAAFG = (int)AOJKIAFNLAC.ODFEKBJCFMN;
			Debug.Log("OfficeSitting" + this.OKFIFPBAAFG);
			NHCAOFIKNFE.IKGFHGKKCPG.FOJGKJPMIOC(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HKHMIIEIFNG, JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BNIHFBMEPAB, true, true);
			string arg = NHCAOFIKNFE.IKGFHGKKCPG.GLFILPFCMGN(this.OKFIFPBAAFG, JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BNIHFBMEPAB, true, true);
			string dccpcblodig = string.Format(JNBICAJIJMM.BDKHMOOFHHK(" (uniq)"), arg, "******** ChatPanelPos ");
			this.IKFFNBOCGFL.AFOBLNNIEEJ(dccpcblodig);
		}
	}

	// Token: 0x06005039 RID: 20537 RVA: 0x00256AFC File Offset: 0x00254CFC
	public void openArtelListWindow(HBPNMNGOFMA KADBECGIMPD)
	{
		Debug.Log("Open art window");
		List<ELCMHGJLFOL.FDEPADNCGIF> list = new List<ELCMHGJLFOL.FDEPADNCGIF>();
		KADBECGIMPD.HDBGOLAFOBK();
		KADBECGIMPD.HDBGOLAFOBK();
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			long num = KADBECGIMPD.DNIIFBAIPBE();
			ELCMHGJLFOL.FDEPADNCGIF fdepadncgif = ELCMHGJLFOL.IKGFHGKKCPG.GMPNBBLOHGF(num);
			if (fdepadncgif == null)
			{
				fdepadncgif = new ELCMHGJLFOL.FDEPADNCGIF(num);
				ELCMHGJLFOL.IKGFHGKKCPG.EKNLOJDDBGL(fdepadncgif);
			}
			fdepadncgif.OCPAHLAGCAI(KADBECGIMPD);
			list.Add(fdepadncgif);
		}
		if (this.OFNLHPKLHGI != null)
		{
			UnityEngine.Object.Destroy(this.OFNLHPKLHGI);
		}
		this.OFNLHPKLHGI = JDCEFOFMGHB.IKGFHGKKCPG.KCBBLDECKGB("UI_ArtWindow");
		ArtAllWin component = this.OFNLHPKLHGI.GetComponent<ArtAllWin>();
		if (component != null)
		{
			foreach (ELCMHGJLFOL.FDEPADNCGIF jlfioojljod in list)
			{
				component.addNewArtel(jlfioojljod);
			}
			component.myArtelBtn.interactable = false;
			component.createArtelBtn.interactable = false;
			component.applArtelBtn.interactable = false;
		}
	}

	// Token: 0x0600503A RID: 20538 RVA: 0x00256C14 File Offset: 0x00254E14
	public void DGDLILJCDLL(ONKDCGNBALK JMAKEAHMLMI)
	{
		if (Input.GetKey((KeyCode)(-22)) && !this.BLKAFFPKEBA)
		{
			this.endShowFish();
			this.getFish(JMAKEAHMLMI.LPFKFNLHGBI, false);
		}
		if (Input.GetKey((KeyCode)(-60)))
		{
			this.endShowFish();
			this.NGKLCGDLKDB(JMAKEAHMLMI.LPFKFNLHGBI);
		}
	}

	// Token: 0x0600503B RID: 20539 RVA: 0x00256C60 File Offset: 0x00254E60
	private bool PCFEONMMMAF()
	{
		EKBAPCMPANI ekbapcmpani = BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH;
		List<OIJEGJLCFCF> list = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.NAFGMKJPLPC;
		if (this.currentSadokId == 0)
		{
			ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.EJFELLJIACI(-88, 0);
			list = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.KNFMGIBLMHB;
		}
		if (MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(20, 2) == null || BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null)
		{
			return false;
		}
		int num = 1;
		foreach (OIJEGJLCFCF oijegjlcfcf in list)
		{
			num += oijegjlcfcf.NKHBAJKMAGD;
		}
		if (this.CODAIBGMFCA != null)
		{
			num += this.CODAIBGMFCA.NKHBAJKMAGD;
		}
		bool result = false;
		if (ekbapcmpani != null && list.Count < ekbapcmpani.MIMANMPNLPE.KMGAHCANELI() && num <= ekbapcmpani.MIMANMPNLPE.KEHIFGILLJA())
		{
			result = true;
		}
		return result;
	}

	// Token: 0x0600503C RID: 20540 RVA: 0x00256D54 File Offset: 0x00254F54
	public void openRecordWin(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(JMAKEAHMLMI, PHEMLBHMNCM.x + 20f, PHEMLBHMNCM.y + 20f, PHEMLBHMNCM.width - 40f, PHEMLBHMNCM.height - 40f, 0)
		{
			JHNCNHAAJCH = 64f
		};
		mmkfaenbhkd.KPLMFNIFPMM = false;
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			int nenobdlcfho = KADBECGIMPD.HDBGOLAFOBK();
			long jcgdlkihbjg = KADBECGIMPD.DNIIFBAIPBE();
			string gajgbadjhok = KADBECGIMPD.BFPHBMDMODH();
			int kcfcjhcbcfm = KADBECGIMPD.HDBGOLAFOBK();
			int pnedpppeffg = KADBECGIMPD.HDBGOLAFOBK();
			int hdelgedddce = KADBECGIMPD.HDBGOLAFOBK();
			int migbfmildhd = KADBECGIMPD.HDBGOLAFOBK();
			IDCHHHEDHDC.GIONPNFHOOC gionpnfhooc = new IDCHHHEDHDC.GIONPNFHOOC(nenobdlcfho, jcgdlkihbjg, gajgbadjhok, kcfcjhcbcfm, pnedpppeffg, hdelgedddce, migbfmildhd);
			gionpnfhooc.onRender = new ItemBase.OOALOMPKIKK(this.AEPELGLCEHH);
			mmkfaenbhkd.LACAJHOHACK.Add(gionpnfhooc);
		}
		mmkfaenbhkd.KCLLDJJLCGC = 12;
		mmkfaenbhkd.MGNDPEIFKAN();
		mmkfaenbhkd.IHEILFHMLAG = 0;
	}

	// Token: 0x0600503D RID: 20541 RVA: 0x00256E31 File Offset: 0x00255031
	public void HDKBPHFLCNG(MMKFAENBHKD OCKMAJALKMN, object HEABEPINGED)
	{
		this.CODAIBGMFCA = (HEABEPINGED as OIJEGJLCFCF);
		this.rembtn.FNMCIACNOMH = this.CFJKPHECOKH();
	}

	// Token: 0x0600503E RID: 20542 RVA: 0x00256E50 File Offset: 0x00255050
	public void POPLGGDCGAD(int KKIODALCJGE)
	{
		this.endShowFish();
		if (this.CODAIBGMFCA != null)
		{
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-141, this.CODAIBGMFCA.LPFKFNLHGBI);
			JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.NAFGMKJPLPC.Remove(this.CODAIBGMFCA);
			string iabkgmnjljo = string.Format(JNBICAJIJMM.LPHMKPDBMPP().HEIBEHAEHBM("Color Grading Log LUT"), this.CODAIBGMFCA.MDAPFDLEEGN(false));
			if (this.CODAIBGMFCA.GAAPCLGDOGH.EBBNNMMBKCC() == 0)
			{
				iabkgmnjljo = string.Format(JNBICAJIJMM.LPHMKPDBMPP().CCFFMKBBKHI("MotorbikeHeadstand"), this.CODAIBGMFCA.JDPKKGOOKDF(true));
			}
			if (KKIODALCJGE > 1)
			{
				JDCEFOFMGHB.MNJNNDHCDGG().CBHHEHHNFKL(KKIODALCJGE);
			}
			FlyMessageManager.getI.GHEEOOGDGBJ();
			Vector3 nhclmboinfg = Fisherman.getI.transform.position + Fisherman.getI.transform.forward;
			FBFJFAKAGJG.IKGFHGKKCPG.LLABHALMBDG(nhclmboinfg, 1405f);
			LocNewLogic.getI.createWaterSplash(nhclmboinfg, (float)this.CODAIBGMFCA.NKHBAJKMAGD / 418f);
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
			this.CODAIBGMFCA = null;
		}
	}

	// Token: 0x0600503F RID: 20543 RVA: 0x00256F74 File Offset: 0x00255174
	private void APADGLBHPGK(ONKDCGNBALK ONPHLHKAGFP)
	{
		OIJEGJLCFCF dolfjggbdjf = this.DOLFJGGBDJF;
		if (dolfjggbdjf == null)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC.Remove(dolfjggbdjf);
			this.OJJLLBKEGNO.LACAJHOHACK.Remove(dolfjggbdjf);
			this.OJJLLBKEGNO.JKKFPEJFJLA();
			this.DBELGCHKMOE.LACAJHOHACK.Add(dolfjggbdjf);
			this.DBELGCHKMOE.JKKFPEJFJLA();
			epmphjgalbe.ENDMKPCFKND(this.currentHolodId);
			epmphjgalbe.OBCCLNMPGEJ(dolfjggbdjf.LPFKFNLHGBI);
			NJMHLCGIAJI.IKGFHGKKCPG.EILLJGEHCOH(8, epmphjgalbe.LAFILAEOPAJ());
		}
		finally
		{
			epmphjgalbe.PMIGGJHLIDO();
		}
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("Delete", 976f);
		this.ACKCODOIBCL();
		this.FFOKGLLHNPF();
	}

	// Token: 0x06005040 RID: 20544 RVA: 0x00257048 File Offset: 0x00255248
	public void BOGPHBNCEDP(int KKIODALCJGE, bool LPPACHLJMJC = false)
	{
		this.endShowFish();
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.NAFGMKJPLPC.Count - 0; i += 0)
		{
			OIJEGJLCFCF oijegjlcfcf = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.NAFGMKJPLPC[i];
			num += oijegjlcfcf.NKHBAJKMAGD;
			num2 += 0;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null || num2 > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.NLHKFMMDMMK() || num > BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH.MIMANMPNLPE.IBEIBAHKIAH)
		{
			string iabkgmnjljo = JNBICAJIJMM.DBMJJPBOPEK().NLJOLOBPCBJ("showMetrInfo");
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
			FlyMessageManager.getI.IDNGBKFPNDJ();
			FlyMessageManager.getI.BKLKOMMJPLE(iabkgmnjljo, Color.red, 1, 0);
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA(" шт.", 560f);
			this.EBAOMHDICFP(KKIODALCJGE);
		}
		else
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("StaffPowerUp", 1134f);
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(LPPACHLJMJC ? 85 : -1, this.CODAIBGMFCA.LPFKFNLHGBI);
		}
		if (KKIODALCJGE > 1)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().BMOFIBGMIBK(KKIODALCJGE);
		}
	}

	// Token: 0x06005041 RID: 20545 RVA: 0x0025717C File Offset: 0x0025537C
	public void releaseFish(int KKIODALCJGE)
	{
		this.endShowFish();
		if (this.CODAIBGMFCA != null)
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(286, this.CODAIBGMFCA.LPFKFNLHGBI);
			JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.NAFGMKJPLPC.Remove(this.CODAIBGMFCA);
			string iabkgmnjljo = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_letgoshe"), this.CODAIBGMFCA.LHNOBJDFOOJ(true));
			if (this.CODAIBGMFCA.GAAPCLGDOGH.KIJMCOPFLCN == 1)
			{
				iabkgmnjljo = string.Format(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("gi_letgohe"), this.CODAIBGMFCA.LHNOBJDFOOJ(true));
			}
			if (KKIODALCJGE > 0)
			{
				JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(KKIODALCJGE);
			}
			FlyMessageManager.getI.clearMessages();
			Vector3 nhclmboinfg = Fisherman.getI.transform.position + Fisherman.getI.transform.forward;
			FBFJFAKAGJG.IKGFHGKKCPG.OOMEDFKJOCN(nhclmboinfg, 0.5f);
			LocNewLogic.getI.createWaterSplash(nhclmboinfg, (float)this.CODAIBGMFCA.NKHBAJKMAGD / 1000f);
			OAFJCFOGGAF.IKGFHGKKCPG.PLPOKHMHLPL(iabkgmnjljo);
			this.CODAIBGMFCA = null;
		}
	}

	// Token: 0x06005042 RID: 20546 RVA: 0x002572A0 File Offset: 0x002554A0
	private bool FAFEGFBJKAF()
	{
		EKBAPCMPANI ekbapcmpani = BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH;
		List<OIJEGJLCFCF> list = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.NAFGMKJPLPC;
		if (this.currentSadokId == 0)
		{
			ekbapcmpani = MDEKJCCIDIA.IKGFHGKKCPG.EHHKCFOAKAI(-86, 8);
			list = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.KNFMGIBLMHB;
		}
		if (MDEKJCCIDIA.IKGFHGKKCPG.EJFELLJIACI(125, 0) == null || BOIKJDICEMF.IKGFHGKKCPG.AKJEIJIOLDH == null)
		{
			return false;
		}
		int num = 0;
		foreach (OIJEGJLCFCF oijegjlcfcf in list)
		{
			num += oijegjlcfcf.NKHBAJKMAGD;
		}
		if (this.CODAIBGMFCA != null)
		{
			num += this.CODAIBGMFCA.NKHBAJKMAGD;
		}
		bool result = false;
		if (ekbapcmpani != null && list.Count < ekbapcmpani.EMBKDHKGIEL().NLHKFMMDMMK() && num <= ekbapcmpani.EMBKDHKGIEL().NKEOCCKEOCE())
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06005043 RID: 20547 RVA: 0x00257394 File Offset: 0x00255594
	public void JIKIOGPPIFC(ONKDCGNBALK JMAKEAHMLMI, Rect PHEMLBHMNCM, HBPNMNGOFMA KADBECGIMPD)
	{
		MMKFAENBHKD mmkfaenbhkd = new MMKFAENBHKD(JMAKEAHMLMI, PHEMLBHMNCM.x + 793f, PHEMLBHMNCM.y + 31f, PHEMLBHMNCM.width - 915f, PHEMLBHMNCM.height - 945f, 0)
		{
			JHNCNHAAJCH = 1050f
		};
		mmkfaenbhkd.KPLMFNIFPMM = true;
		while (!KADBECGIMPD.IBMMOGHFCCE())
		{
			int nenobdlcfho = KADBECGIMPD.CLPEKGGAMAI();
			long jcgdlkihbjg = KADBECGIMPD.DCGEOFHNBCN();
			string gajgbadjhok = KADBECGIMPD.NCODBGMGNFD();
			int kcfcjhcbcfm = KADBECGIMPD.AGNKAFLKCAG();
			int pnedpppeffg = KADBECGIMPD.IFDFHJLCHAE();
			int hdelgedddce = KADBECGIMPD.DOJKJHMJJNK();
			int migbfmildhd = KADBECGIMPD.DOJKJHMJJNK();
			IDCHHHEDHDC.GIONPNFHOOC gionpnfhooc = new IDCHHHEDHDC.GIONPNFHOOC(nenobdlcfho, jcgdlkihbjg, gajgbadjhok, kcfcjhcbcfm, pnedpppeffg, hdelgedddce, migbfmildhd);
			gionpnfhooc.onRender = new ItemBase.OOALOMPKIKK(this.HCOJACLMGDC);
			mmkfaenbhkd.LACAJHOHACK.Add(gionpnfhooc);
		}
		mmkfaenbhkd.KCLLDJJLCGC = -123;
		mmkfaenbhkd.FILOCGPAIKD();
		mmkfaenbhkd.IHEILFHMLAG = 0;
	}

	// Token: 0x06005044 RID: 20548 RVA: 0x00257474 File Offset: 0x00255674
	private void OIPCEKLBNOA(OIJEGJLCFCF CFBLFPPOIKE, float DEFNNEGPNEI)
	{
		if (this.brgCntr == null)
		{
			Fisherman.getI.bragfish = JLFJEGIPIMM.MHFDIJGJGBJ().DAJFMBBDJIC("_FogDistance", Vector3.zero, Fisherman.getI.leftHandRodPoint);
			if (Fisherman.getI.bragfish == null)
			{
				return;
			}
			this.brgCntr = Fisherman.getI.bragfish.GetComponent<BragFish>();
			Fisherman.getI.bragfish.transform.localRotation = Quaternion.identity;
			Fisherman.getI.bragfish.transform.localScale = new Vector3(1671f, 952f, 1195f);
			Fisherman.getI.bragfish.transform.localPosition = Vector3.zero;
			this.brgCntr.JPOEJJHOEFJ(CFBLFPPOIKE.NENOBDLCFHO, ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NBLJCEHNKAK), false);
		}
		if (Fisherman.getI.podsakObject != null)
		{
			UnityEngine.Object.Destroy(Fisherman.getI.podsakObject);
			Fisherman.getI.podsakObject = null;
		}
		Fisherman.getI.getBragCntrl.FNEHABBGBAA(true);
		if (DEFNNEGPNEI > 524f)
		{
			base.StartCoroutine(this.NFJJLNNBIOE(DEFNNEGPNEI));
		}
	}

	// Token: 0x04000BE0 RID: 3040
	public float qtextSM;

	// Token: 0x04000BE1 RID: 3041
	public int qTextSize = 12;

	// Token: 0x04000BE2 RID: 3042
	public Texture[] fgetImagesBases;

	// Token: 0x04000BE3 RID: 3043
	public static GameInterface getI;

	// Token: 0x04000BE4 RID: 3044
	public Texture piedestal;

	// Token: 0x04000BE5 RID: 3045
	public Texture linevertival;

	// Token: 0x04000BE6 RID: 3046
	public Texture sadokImage;

	// Token: 0x04000BE7 RID: 3047
	public Texture fgetImage;

	// Token: 0x04000BE8 RID: 3048
	public Texture borderBy;

	// Token: 0x04000BE9 RID: 3049
	public Texture cellsIcons;

	// Token: 0x04000BEA RID: 3050
	public GameObject steamShopWin;

	// Token: 0x04000BEB RID: 3051
	public Color[] qualityColors;

	// Token: 0x04000BEC RID: 3052
	public Sprite[] QTaskIcons;

	// Token: 0x04000BED RID: 3053
	public Texture[] npcIcons;

	// Token: 0x04000BEE RID: 3054
	public Texture rShopImage;

	// Token: 0x04000BEF RID: 3055
	public Texture monitor;

	// Token: 0x04000BF0 RID: 3056
	public Texture wpnBrokenTexture;

	// Token: 0x04000BF1 RID: 3057
	public Texture teachKeyTexture;

	// Token: 0x04000BF2 RID: 3058
	public Texture bigKeysTexture;

	// Token: 0x04000BF3 RID: 3059
	public Texture wpnImproveIcons;

	// Token: 0x04000BF4 RID: 3060
	public Texture ifaceIcons;

	// Token: 0x04000BF5 RID: 3061
	public Texture titulIcon;

	// Token: 0x04000BF6 RID: 3062
	public Texture titulIcon2;

	// Token: 0x04000BF7 RID: 3063
	public Texture PerkIcon;

	// Token: 0x04000BF8 RID: 3064
	public Texture rootPerkIcon;

	// Token: 0x04000BF9 RID: 3065
	public Texture brush;

	// Token: 0x04000BFA RID: 3066
	public Texture blackPaper;

	// Token: 0x04000BFB RID: 3067
	public Texture achives;

	// Token: 0x04000BFC RID: 3068
	public Texture simpleGray;

	// Token: 0x04000BFD RID: 3069
	public Texture iconsAthlasX16;

	// Token: 0x04000BFE RID: 3070
	public Texture MoneyIcon;

	// Token: 0x04000BFF RID: 3071
	public Texture postIconsTexture;

	// Token: 0x04000C00 RID: 3072
	public Texture UpPanelTexture;

	// Token: 0x04000C01 RID: 3073
	public Texture qtIcons;

	// Token: 0x04000C02 RID: 3074
	public Texture QBackTexture;

	// Token: 0x04000C03 RID: 3075
	public Texture levelUpTxtr;

	// Token: 0x04000C04 RID: 3076
	public Texture BigKeyGameTex;

	// Token: 0x04000C05 RID: 3077
	public Texture VenokTexture;

	// Token: 0x04000C06 RID: 3078
	public Texture PaperTexture;

	// Token: 0x04000C07 RID: 3079
	public Texture UserParamLines;

	// Token: 0x04000C08 RID: 3080
	public Texture wpnBackCell;

	// Token: 0x04000C09 RID: 3081
	public Texture invBackMan;

	// Token: 0x04000C0A RID: 3082
	public Texture invEmptyCell;

	// Token: 0x04000C0B RID: 3083
	public Texture invEmptyCellSelect;

	// Token: 0x04000C0C RID: 3084
	public Texture invCellPlus;

	// Token: 0x04000C0D RID: 3085
	public Texture invCellPlusSelect;

	// Token: 0x04000C0E RID: 3086
	public Texture RodOrderTexture;

	// Token: 0x04000C0F RID: 3087
	public Texture RodStatusTexture;

	// Token: 0x04000C10 RID: 3088
	public Texture EmptyTexture;

	// Token: 0x04000C11 RID: 3089
	public Texture recIconTxtr;

	// Token: 0x04000C12 RID: 3090
	public Texture mutIconTxtr;

	// Token: 0x04000C13 RID: 3091
	public Texture unicIconTxtr;

	// Token: 0x04000C14 RID: 3092
	public GHMGDBLLEAG.TurnirItem currentTurnir;

	// Token: 0x04000C15 RID: 3093
	private OIJEGJLCFCF CODAIBGMFCA;

	// Token: 0x04000C16 RID: 3094
	private MMKFAENBHKD OJJLLBKEGNO;

	// Token: 0x04000C17 RID: 3095
	private LCOLJOPGDLL OHIPOCGKHDE;

	// Token: 0x04000C18 RID: 3096
	public const int _UD_Info = 1;

	// Token: 0x04000C19 RID: 3097
	public const int _UD_Stat = 2;

	// Token: 0x04000C1A RID: 3098
	public const int _UD_Repa = 3;

	// Token: 0x04000C1B RID: 3099
	public const int _UD_Titul = 4;

	// Token: 0x04000C1C RID: 3100
	public const int _UD_Prof = 5;

	// Token: 0x04000C1D RID: 3101
	public const int _UD_Quest = 6;

	// Token: 0x04000C1E RID: 3102
	public const int _UD_Records = 7;

	// Token: 0x04000C1F RID: 3103
	public const int _UD_Perks = 8;

	// Token: 0x04000C20 RID: 3104
	public const int _UD_Achivments = 9;

	// Token: 0x04000C21 RID: 3105
	public long UID_info;

	// Token: 0x04000C22 RID: 3106
	private LCOLJOPGDLL CINAIMICJGM;

	// Token: 0x04000C23 RID: 3107
	private int CBJBOCGAEKC = -1;

	// Token: 0x04000C24 RID: 3108
	public int currentHolodId;

	// Token: 0x04000C25 RID: 3109
	public int holodFreeCell;

	// Token: 0x04000C26 RID: 3110
	private MMKFAENBHKD DBELGCHKMOE;

	// Token: 0x04000C27 RID: 3111
	private OIJEGJLCFCF DOLFJGGBDJF;

	// Token: 0x04000C28 RID: 3112
	public int currentSadokId;

	// Token: 0x04000C29 RID: 3113
	public int sadokWinId = -1;

	// Token: 0x04000C2A RID: 3114
	public MEMEOHJKPNJ rembtn;

	// Token: 0x04000C2B RID: 3115
	public BragFish brgCntr;

	// Token: 0x04000C2C RID: 3116
	private bool BLKAFFPKEBA;

	// Token: 0x04000C2D RID: 3117
	private int OJNFLOAOILJ = -1;

	// Token: 0x04000C2E RID: 3118
	public NLNNIDBPKAO.JENMPDPJKBG selectPerk;

	// Token: 0x04000C2F RID: 3119
	private MEMEOHJKPNJ FJOABFJFMEP;

	// Token: 0x04000C30 RID: 3120
	private int OKFIFPBAAFG;

	// Token: 0x04000C31 RID: 3121
	private LCOLJOPGDLL IKFFNBOCGFL;

	// Token: 0x04000C32 RID: 3122
	private LCOLJOPGDLL LCMCOGOGHPL;

	// Token: 0x04000C33 RID: 3123
	private BaseWindow OFNLHPKLHGI;

	// Token: 0x04000C34 RID: 3124
	public EKBAPCMPANI useWeapon;
}
