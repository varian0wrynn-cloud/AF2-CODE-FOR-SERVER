using System;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000189 RID: 393
public class UserInfoWin : MonoBehaviour
{
	// Token: 0x0600575E RID: 22366 RVA: 0x00292490 File Offset: 0x00290690
	public void KENOJGBKNFO(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.FDIDEGHPJPF();
			int num = KADBECGIMPD.HDBGOLAFOBK();
			int pnedpppeffg = KADBECGIMPD.HDBGOLAFOBK();
			int hdelgedddce = KADBECGIMPD.IFDFHJLCHAE();
			int lpfkfnlhgbi = KADBECGIMPD.KDNDJNEGBDI();
			this.IOHHGMOMDMA.UI_data[2].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.BCDJLDLHEKP(lpfkfnlhgbi, "CratePush", false, true);
			this.IOHHGMOMDMA.UI_data[7].GetComponent<Text>().text = string.Format(JNBICAJIJMM.OOOKJHOHPNN("UpHillWalkHandGrab"), num, JNBICAJIJMM.IMLLGEMPHAP().JDMOHJGPKIC(pnedpppeffg), JNBICAJIJMM.LPHMKPDBMPP().IAODIDBLHMM(hdelgedddce, 1));
			long lpfkfnlhgbi2 = KADBECGIMPD.KLHDFFHONON();
			ELCMHGJLFOL.IKGFHGKKCPG.MNJOAIFPFHL(lpfkfnlhgbi2).MPCIALDHHKN(KADBECGIMPD);
			KADBECGIMPD.LDLKLPJBIJN();
			long num2 = KADBECGIMPD.HHMGLDMFCPF();
			KADBECGIMPD.KJIOFDCKIKO();
			string gcoibldnoim = KADBECGIMPD.BFPHBMDMODH();
			string text = KADBECGIMPD.NCODBGMGNFD();
			DateTime dateTime = KADBECGIMPD.OODOKDPIMOF();
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.EAJHPOJPPFA().MOGDIOFGLME) > 0)
			{
				text = string.Format("{0}/{1}", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[3].GetComponent<Text>().text = string.Format(JNBICAJIJMM.BDKHMOOFHHK("from friend"), text);
			this.IOHHGMOMDMA.UI_data[4].GetComponent<Text>().text = string.Format(JNBICAJIJMM.PPNKMDJBMLP("LUX_LINEAR"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.LPJBJGJJBLB(gcoibldnoim, new Action<Texture2D>(this.CBPHPEAEBCG));
			UIListBox component = this.IOHHGMOMDMA.UI_data[8].GetComponent<UIListBox>();
			while (!KADBECGIMPD.DFLKBBNOGBG())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.MCIKLDBPPFJ(KADBECGIMPD);
				component.CNNKFIDHPMK(gdemcacnpng);
			}
			component.AGDCELDJAKK();
		}
	}

	// Token: 0x0600575F RID: 22367 RVA: 0x0029268C File Offset: 0x0029088C
	private void FJBIMEEPNBK(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(999f, 1438f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(751f, 991f));
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005760 RID: 22368 RVA: 0x00292700 File Offset: 0x00290900
	public void OMIHNNFJOCB(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.KDELAFDDGJH();
			int num = KADBECGIMPD.AGNKAFLKCAG();
			int pnedpppeffg = KADBECGIMPD.KKOKFLMMAAK();
			int hdelgedddce = KADBECGIMPD.HHLDBAEFNMJ();
			int lpfkfnlhgbi = KADBECGIMPD.HHLDBAEFNMJ();
			this.IOHHGMOMDMA.UI_data[3].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.FGNOEEAHKED(lpfkfnlhgbi, "WoodCut", true, true);
			this.IOHHGMOMDMA.UI_data[8].GetComponent<Text>().text = string.Format(JNBICAJIJMM.OOOKJHOHPNN("1HandSwordChargeSwipe"), num, JNBICAJIJMM.IKGFHGKKCPG.HHOIGKJMAGP(pnedpppeffg), JNBICAJIJMM.EKEBHIJMEML().MHBMDFOHDMO(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.DNIIFBAIPBE();
			ELCMHGJLFOL.IKGFHGKKCPG.CEGLBGMFGFF(lpfkfnlhgbi2).MPMELFMBFAN(KADBECGIMPD);
			KADBECGIMPD.IFDFHJLCHAE();
			long num2 = KADBECGIMPD.KLHDFFHONON();
			KADBECGIMPD.BLNIHNKJJPJ();
			string gcoibldnoim = KADBECGIMPD.KDELAFDDGJH();
			string text = KADBECGIMPD.BFPHBMDMODH();
			DateTime dateTime = KADBECGIMPD.NIIFLPIEMFM();
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.BPPFAOOCENN().MOGDIOFGLME) > 1)
			{
				text = string.Format("sunshine_ShadowCoordDepthRayU", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = string.Format(JNBICAJIJMM.BDKHMOOFHHK(""), text);
			this.IOHHGMOMDMA.UI_data[4].GetComponent<Text>().text = string.Format(JNBICAJIJMM.LEBHCLDODNI("spawnPet"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.POELMFIMAEG(gcoibldnoim, new Action<Texture2D>(this.ALPKIHPNHIO));
			UIListBox component = this.IOHHGMOMDMA.UI_data[3].GetComponent<UIListBox>();
			while (!KADBECGIMPD.INLBHLOLOJH())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.NHHAANEMJCK(KADBECGIMPD);
				component.BEMLEDDBMNG(gdemcacnpng);
			}
			component.AGDCELDJAKK();
		}
	}

	// Token: 0x06005761 RID: 22369 RVA: 0x002928FC File Offset: 0x00290AFC
	private void OBMFNKELGHB(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(412f, 1049f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(1175f, 1010f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005762 RID: 22370 RVA: 0x00292970 File Offset: 0x00290B70
	private void IAAHCKHLNAG(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(88f, 781f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(873f, 682f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005763 RID: 22371 RVA: 0x002929E4 File Offset: 0x00290BE4
	public void DJINFPNFCNC(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.JJJJAGJCOGD();
			int num = KADBECGIMPD.LDLKLPJBIJN();
			int pnedpppeffg = KADBECGIMPD.LDLKLPJBIJN();
			int hdelgedddce = KADBECGIMPD.DOJKJHMJJNK();
			int lpfkfnlhgbi = KADBECGIMPD.DOJKJHMJJNK();
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.BCDJLDLHEKP(lpfkfnlhgbi, "invn_ver5", true, true);
			this.IOHHGMOMDMA.UI_data[7].GetComponent<Text>().text = string.Format(JNBICAJIJMM.CELEPPAEKAB("https://groups.google.com/forum/#!forum/final-ik"), num, JNBICAJIJMM.CLIMNFDGOEG().JDMOHJGPKIC(pnedpppeffg), JNBICAJIJMM.LPHMKPDBMPP().IGOOOILHFPL(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.IBKCNEICPEL();
			ELCMHGJLFOL.IKGFHGKKCPG.AIIPKFNLCKG(lpfkfnlhgbi2).HLJFBOLPOMG(KADBECGIMPD);
			KADBECGIMPD.IFDFHJLCHAE();
			long num2 = KADBECGIMPD.HHMGLDMFCPF();
			KADBECGIMPD.LAECLJFMGPE();
			string gcoibldnoim = KADBECGIMPD.NCODBGMGNFD();
			string text = KADBECGIMPD.PNBECHOLCJM();
			DateTime dateTime = KADBECGIMPD.PFKHMDDOHDN();
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.PLGADNLAEGN().MOGDIOFGLME) > 0)
			{
				text = string.Format("WizardPowerUp", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[7].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DCEBAJIILPC("FlyForward"), text);
			this.IOHHGMOMDMA.UI_data[7].GetComponent<Text>().text = string.Format(JNBICAJIJMM.CDDCIKKDFMP("[minwgt]"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.LDDNKBPKHPP(gcoibldnoim, new Action<Texture2D>(this.EPPHABNLDLK));
			UIListBox component = this.IOHHGMOMDMA.UI_data[8].GetComponent<UIListBox>();
			while (!KADBECGIMPD.HKBFCJDJCOB())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.ABKNFJOOHJL(KADBECGIMPD);
				component.CNNKFIDHPMK(gdemcacnpng);
			}
			component.NLDMMAPPJPP();
		}
	}

	// Token: 0x06005764 RID: 22372 RVA: 0x00292BE0 File Offset: 0x00290DE0
	private void JMGJCJHBGHI(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1491f, 340f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(33f, 198f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005765 RID: 22373 RVA: 0x00292C54 File Offset: 0x00290E54
	public void GPFLMEOJLNA(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.NCODBGMGNFD();
			int num = KADBECGIMPD.DOJKJHMJJNK();
			int pnedpppeffg = KADBECGIMPD.DOJKJHMJJNK();
			int hdelgedddce = KADBECGIMPD.LDLKLPJBIJN();
			int lpfkfnlhgbi = KADBECGIMPD.KKOKFLMMAAK();
			this.IOHHGMOMDMA.UI_data[5].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.HPPPPEHMEKL(lpfkfnlhgbi, "IdleStrafeRight", true, true);
			this.IOHHGMOMDMA.UI_data[2].GetComponent<Text>().text = string.Format(JNBICAJIJMM.PGJCPFNJNPM("Eyelashes"), num, JNBICAJIJMM.EEOPOHEALPK().DPIHNBEBDJF(pnedpppeffg), JNBICAJIJMM.IKGFHGKKCPG.JLDLEFLDHCM(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.HHMGLDMFCPF();
			ELCMHGJLFOL.IKGFHGKKCPG.GECBLDDOENE(lpfkfnlhgbi2).KIALEELDFDJ(KADBECGIMPD);
			KADBECGIMPD.CLPEKGGAMAI();
			long num2 = KADBECGIMPD.IBKCNEICPEL();
			KADBECGIMPD.ELDBJFLCMAJ();
			string gcoibldnoim = KADBECGIMPD.JJJJAGJCOGD();
			string text = KADBECGIMPD.JJJJAGJCOGD();
			DateTime dateTime = KADBECGIMPD.OODOKDPIMOF();
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.NPCAKEGNBHD().MOGDIOFGLME) > 0)
			{
				text = string.Format("aptek.ogg", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[5].GetComponent<Text>().text = string.Format(JNBICAJIJMM.NGALDMFKMJH(""), text);
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DIOJFJMOPJO("************ isChangedRod *********"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.LPJBJGJJBLB(gcoibldnoim, new Action<Texture2D>(this.BJECFEIPLLP));
			UIListBox component = this.IOHHGMOMDMA.UI_data[3].GetComponent<UIListBox>();
			while (!KADBECGIMPD.KFKIFJDHCHB())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.GBIFKNOMLGN(KADBECGIMPD);
				component.IPENPEOKJJF(gdemcacnpng);
			}
			component.NLDMMAPPJPP();
		}
	}

	// Token: 0x06005766 RID: 22374 RVA: 0x00292E50 File Offset: 0x00291050
	public void MMIHMGCEPLA(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.FDIDEGHPJPF();
			int num = KADBECGIMPD.LDLKLPJBIJN();
			int pnedpppeffg = KADBECGIMPD.LDLKLPJBIJN();
			int hdelgedddce = KADBECGIMPD.CLPEKGGAMAI();
			int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
			this.IOHHGMOMDMA.UI_data[6].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.HPPPPEHMEKL(lpfkfnlhgbi, "_ColorBuffer", true, true);
			this.IOHHGMOMDMA.UI_data[4].GetComponent<Text>().text = string.Format(JNBICAJIJMM.PPNKMDJBMLP("Layer"), num, JNBICAJIJMM.EDKGBBIIBBC().JDMOHJGPKIC(pnedpppeffg), JNBICAJIJMM.EEOPOHEALPK().IGOOOILHFPL(hdelgedddce, 1));
			long lpfkfnlhgbi2 = KADBECGIMPD.DCGEOFHNBCN();
			ELCMHGJLFOL.IKGFHGKKCPG.AIIPKFNLCKG(lpfkfnlhgbi2).KIALEELDFDJ(KADBECGIMPD);
			KADBECGIMPD.AGNKAFLKCAG();
			long num2 = KADBECGIMPD.ANPEIKGEDHJ();
			KADBECGIMPD.LAECLJFMGPE();
			string gcoibldnoim = KADBECGIMPD.FDIDEGHPJPF();
			string text = KADBECGIMPD.DPLAJNEDGBL();
			DateTime dateTime = KADBECGIMPD.MLFLLBPGFIJ();
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.JKIFIBEPICO().MOGDIOFGLME) > 0)
			{
				text = string.Format("KatanaReady", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[7].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DCEBAJIILPC("file://"), text);
			this.IOHHGMOMDMA.UI_data[4].GetComponent<Text>().text = string.Format(JNBICAJIJMM.PGJCPFNJNPM("OfficeSittingBack"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.LDDNKBPKHPP(gcoibldnoim, new Action<Texture2D>(this.BIGEKJALAGP));
			UIListBox component = this.IOHHGMOMDMA.UI_data[5].GetComponent<UIListBox>();
			while (!KADBECGIMPD.PPAHBNGECGH())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.IJAHENJJNCA(KADBECGIMPD);
				component.OOEOIIDOMAE(gdemcacnpng);
			}
			component.sortItemList();
		}
	}

	// Token: 0x06005767 RID: 22375 RVA: 0x0029304C File Offset: 0x0029124C
	private void BJECFEIPLLP(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(960f, 254f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(287f, 1940f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005768 RID: 22376 RVA: 0x002930C0 File Offset: 0x002912C0
	private void MKKPJKMDHOF(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(820f, 1644f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(937f, 1206f));
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005769 RID: 22377 RVA: 0x00293134 File Offset: 0x00291334
	private void MKCILFECGIN(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1606f, 1157f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(553f, 607f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x0600576A RID: 22378 RVA: 0x002931A8 File Offset: 0x002913A8
	private void LCMPOJIHKGF(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1068f, 284f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(1669f, 723f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x0600576B RID: 22379 RVA: 0x0029321C File Offset: 0x0029141C
	public void JHAAGCFDPGF(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = KADBECGIMPD.BFPHBMDMODH();
			int num = KADBECGIMPD.AGNKAFLKCAG();
			int pnedpppeffg = KADBECGIMPD.AGNKAFLKCAG();
			int hdelgedddce = KADBECGIMPD.KKOKFLMMAAK();
			int lpfkfnlhgbi = KADBECGIMPD.DOJKJHMJJNK();
			this.IOHHGMOMDMA.UI_data[8].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.MODOIHOIMBJ(lpfkfnlhgbi, "Femur", true, false);
			this.IOHHGMOMDMA.UI_data[7].GetComponent<Text>().text = string.Format(JNBICAJIJMM.BDKHMOOFHHK("ScubaSwim"), num, JNBICAJIJMM.APMJBBDBOJO().FCNFDLDHDDE(pnedpppeffg), JNBICAJIJMM.IKGFHGKKCPG.IAODIDBLHMM(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.KLHDFFHONON();
			ELCMHGJLFOL.IKGFHGKKCPG.INEIMJBBPHJ(lpfkfnlhgbi2).AGADBLDMILO(KADBECGIMPD);
			KADBECGIMPD.CLPEKGGAMAI();
			long num2 = KADBECGIMPD.DNIIFBAIPBE();
			KADBECGIMPD.LAECLJFMGPE();
			string gcoibldnoim = KADBECGIMPD.DPLAJNEDGBL();
			string text = KADBECGIMPD.FDIDEGHPJPF();
			DateTime dateTime = KADBECGIMPD.OJNFAHFAKDO();
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.BOKIOJFHNLD().MOGDIOFGLME) > 1)
			{
				text = string.Format(" ", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[3].GetComponent<Text>().text = string.Format(JNBICAJIJMM.NGALDMFKMJH("gamma"), text);
			this.IOHHGMOMDMA.UI_data[2].GetComponent<Text>().text = string.Format(JNBICAJIJMM.CDDCIKKDFMP("_FogHeightData"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.BMGICGHPAFB(gcoibldnoim, new Action<Texture2D>(this.FELKBCGHPOP));
			UIListBox component = this.IOHHGMOMDMA.UI_data[8].GetComponent<UIListBox>();
			while (!KADBECGIMPD.JEFMHDJEEJC())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.ABKNFJOOHJL(KADBECGIMPD);
				component.OOEOIIDOMAE(gdemcacnpng);
			}
			component.AGDCELDJAKK();
		}
	}

	// Token: 0x0600576D RID: 22381 RVA: 0x00293418 File Offset: 0x00291618
	public void AIJHKMLFFAH(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.KDELAFDDGJH();
			int num = KADBECGIMPD.KDNDJNEGBDI();
			int pnedpppeffg = KADBECGIMPD.HDBGOLAFOBK();
			int hdelgedddce = KADBECGIMPD.HDBGOLAFOBK();
			int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
			this.IOHHGMOMDMA.UI_data[8].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.LCILNGKKLPN(lpfkfnlhgbi, "id", false, false);
			this.IOHHGMOMDMA.UI_data[8].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DIOJFJMOPJO("FOG_SCATTERING_ON"), num, JNBICAJIJMM.IMLLGEMPHAP().DPIHNBEBDJF(pnedpppeffg), JNBICAJIJMM.IKGFHGKKCPG.JAANDJMPILF(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.DMABDIGCLKA();
			ELCMHGJLFOL.IKGFHGKKCPG.CEHGLMKOMHC(lpfkfnlhgbi2).KAOKKLLOFBE(KADBECGIMPD);
			KADBECGIMPD.KKOKFLMMAAK();
			long num2 = KADBECGIMPD.DMABDIGCLKA();
			KADBECGIMPD.JNOKJCDAPPA();
			string gcoibldnoim = KADBECGIMPD.DHCMILPKJAL();
			string text = KADBECGIMPD.JJJJAGJCOGD();
			DateTime dateTime = KADBECGIMPD.OJNFAHFAKDO();
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.NPCAKEGNBHD().MOGDIOFGLME) > 0)
			{
				text = string.Format("_UserLutTex", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[4].GetComponent<Text>().text = string.Format(JNBICAJIJMM.PGJCPFNJNPM("and 'Result' are the same."), text);
			this.IOHHGMOMDMA.UI_data[8].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DIOJFJMOPJO(" ms"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.GJPOFPKJMCE(gcoibldnoim, new Action<Texture2D>(this.FELKBCGHPOP));
			UIListBox component = this.IOHHGMOMDMA.UI_data[8].GetComponent<UIListBox>();
			while (!KADBECGIMPD.PPAHBNGECGH())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.IHONANEEDOC(KADBECGIMPD);
				component.IPENPEOKJJF(gdemcacnpng);
			}
			component.sortItemList();
		}
	}

	// Token: 0x0600576E RID: 22382 RVA: 0x00293614 File Offset: 0x00291814
	private void NBIJMIHOLMM(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1482f, 919f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(733f, 506f));
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x0600576F RID: 22383 RVA: 0x00293688 File Offset: 0x00291888
	private void MHDODJBDGGC(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1109f, 1171f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(1427f, 682f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005770 RID: 22384 RVA: 0x002936FC File Offset: 0x002918FC
	private void ALECCJFMHPL(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(573f, 269f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(338f, 348f));
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005771 RID: 22385 RVA: 0x00293770 File Offset: 0x00291970
	public void BNKCLOAFHJC(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.DHCMILPKJAL();
			int num = KADBECGIMPD.HHLDBAEFNMJ();
			int pnedpppeffg = KADBECGIMPD.AGNKAFLKCAG();
			int hdelgedddce = KADBECGIMPD.KKOKFLMMAAK();
			int lpfkfnlhgbi = KADBECGIMPD.LDLKLPJBIJN();
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.HPPPPEHMEKL(lpfkfnlhgbi, "WeaponReady", true, false);
			this.IOHHGMOMDMA.UI_data[2].GetComponent<Text>().text = string.Format(JNBICAJIJMM.PPNKMDJBMLP("3"), num, JNBICAJIJMM.CLIMNFDGOEG().KIBGNDMNMNO(pnedpppeffg), JNBICAJIJMM.EKEBHIJMEML().IGOOOILHFPL(hdelgedddce, 1));
			long lpfkfnlhgbi2 = KADBECGIMPD.HFOPFEJDJFG();
			ELCMHGJLFOL.IKGFHGKKCPG.CMMHMGFAFFI(lpfkfnlhgbi2).IHONANEEDOC(KADBECGIMPD);
			KADBECGIMPD.KDNDJNEGBDI();
			long num2 = KADBECGIMPD.IBKCNEICPEL();
			KADBECGIMPD.BEMFIFGOJBL();
			string gcoibldnoim = KADBECGIMPD.KDELAFDDGJH();
			string text = KADBECGIMPD.DPLAJNEDGBL();
			DateTime dateTime = KADBECGIMPD.IKJAOHGGCJD();
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.NPCAKEGNBHD().MOGDIOFGLME) > 1)
			{
				text = string.Format("PistolReload", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[8].GetComponent<Text>().text = string.Format(JNBICAJIJMM.NGALDMFKMJH("ClimbRight"), text);
			this.IOHHGMOMDMA.UI_data[7].GetComponent<Text>().text = string.Format(JNBICAJIJMM.OOOKJHOHPNN("H "), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.GDOENILFJFK(gcoibldnoim, new Action<Texture2D>(this.MFICLEKENDK));
			UIListBox component = this.IOHHGMOMDMA.UI_data[6].GetComponent<UIListBox>();
			while (!KADBECGIMPD.NNOJEFMEGEG())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.BIGEEOCOICN(KADBECGIMPD);
				component.OBMAFPODNJA(gdemcacnpng);
			}
			component.NLDMMAPPJPP();
		}
	}

	// Token: 0x06005772 RID: 22386 RVA: 0x0029396C File Offset: 0x00291B6C
	private void LMJMHNIALAA(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(915f, 802f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(1762f, 217f));
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005773 RID: 22387 RVA: 0x002939E0 File Offset: 0x00291BE0
	private void DDHPNOJELJB(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1572f, 1455f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(819f, 27f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005774 RID: 22388 RVA: 0x00293A54 File Offset: 0x00291C54
	private void FELKBCGHPOP(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(0f, 0f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(1f, 1f));
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005775 RID: 22389 RVA: 0x00293AC8 File Offset: 0x00291CC8
	private void EKAAHBDBPKP(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(320f, 769f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(1098f, 1550f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005776 RID: 22390 RVA: 0x00293B3C File Offset: 0x00291D3C
	public void KCHBJDDOIHG(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = KADBECGIMPD.NCODBGMGNFD();
			int num = KADBECGIMPD.HHLDBAEFNMJ();
			int pnedpppeffg = KADBECGIMPD.IFDFHJLCHAE();
			int hdelgedddce = KADBECGIMPD.AGNKAFLKCAG();
			int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.GGGFKBAAADC(lpfkfnlhgbi, "360SpinDeath", true, true);
			this.IOHHGMOMDMA.UI_data[3].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DCEBAJIILPC("IdleMeditate"), num, JNBICAJIJMM.IMLLGEMPHAP().FCNFDLDHDDE(pnedpppeffg), JNBICAJIJMM.EEOPOHEALPK().IGOOOILHFPL(hdelgedddce, 1));
			long lpfkfnlhgbi2 = KADBECGIMPD.DCGEOFHNBCN();
			ELCMHGJLFOL.IKGFHGKKCPG.BCBCICJDIEF(lpfkfnlhgbi2).LFOPENOJDIM(KADBECGIMPD);
			KADBECGIMPD.CLPEKGGAMAI();
			long num2 = KADBECGIMPD.HHMGLDMFCPF();
			KADBECGIMPD.ELDBJFLCMAJ();
			string gcoibldnoim = KADBECGIMPD.DPLAJNEDGBL();
			string text = KADBECGIMPD.KDELAFDDGJH();
			DateTime dateTime = KADBECGIMPD.MILGIGJBAJL();
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.IKGFHGKKCPG.MOGDIOFGLME) > 0)
			{
				text = string.Format("", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[3].GetComponent<Text>().text = string.Format(JNBICAJIJMM.PGJCPFNJNPM("<color='#003000'>{0} на {1}</color>"), text);
			this.IOHHGMOMDMA.UI_data[2].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DIOJFJMOPJO("_CutoutReferenceTexture"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.LPJBJGJJBLB(gcoibldnoim, new Action<Texture2D>(this.IJGMHFBGGOH));
			UIListBox component = this.IOHHGMOMDMA.UI_data[2].GetComponent<UIListBox>();
			while (!KADBECGIMPD.KFKIFJDHCHB())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.ONIJHKMCCHH(KADBECGIMPD);
				component.BEMLEDDBMNG(gdemcacnpng);
			}
			component.AGDCELDJAKK();
		}
	}

	// Token: 0x06005777 RID: 22391 RVA: 0x00293D38 File Offset: 0x00291F38
	private void ALCKAIKCOOM(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1148f, 1738f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(989f, 859f));
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005778 RID: 22392 RVA: 0x00293DAC File Offset: 0x00291FAC
	public void KIEEFEBOHEG(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = KADBECGIMPD.PNBECHOLCJM();
			int num = KADBECGIMPD.KDNDJNEGBDI();
			int pnedpppeffg = KADBECGIMPD.KKOKFLMMAAK();
			int hdelgedddce = KADBECGIMPD.IFDFHJLCHAE();
			int lpfkfnlhgbi = KADBECGIMPD.IFDFHJLCHAE();
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.CABGPFFNFPH(lpfkfnlhgbi, "_Offsets", true, true);
			this.IOHHGMOMDMA.UI_data[5].GetComponent<Text>().text = string.Format(JNBICAJIJMM.NGALDMFKMJH("Fishing"), num, JNBICAJIJMM.CLIMNFDGOEG().ECDAPHMNOMB(pnedpppeffg), JNBICAJIJMM.EDKGBBIIBBC().JAANDJMPILF(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.IBKCNEICPEL();
			ELCMHGJLFOL.IKGFHGKKCPG.BKIILLHFAKE(lpfkfnlhgbi2).OCPAHLAGCAI(KADBECGIMPD);
			KADBECGIMPD.AGNKAFLKCAG();
			long num2 = KADBECGIMPD.HHMGLDMFCPF();
			KADBECGIMPD.LAECLJFMGPE();
			string gcoibldnoim = KADBECGIMPD.PNBECHOLCJM();
			string text = KADBECGIMPD.BFPHBMDMODH();
			DateTime dateTime = KADBECGIMPD.OODOKDPIMOF();
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.NPCAKEGNBHD().MOGDIOFGLME) > 0)
			{
				text = string.Format("_DisplayVelocityScale", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[3].GetComponent<Text>().text = string.Format(JNBICAJIJMM.NGALDMFKMJH("_MainTex"), text);
			this.IOHHGMOMDMA.UI_data[2].GetComponent<Text>().text = string.Format(JNBICAJIJMM.PGJCPFNJNPM("{0:0.} fps ping:{1} pck/sec: {2}"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.GFOAKEFAGHF(gcoibldnoim, new Action<Texture2D>(this.LINBGJAFMBN));
			UIListBox component = this.IOHHGMOMDMA.UI_data[0].GetComponent<UIListBox>();
			while (!KADBECGIMPD.NLJJMKFBPBK())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.NHHAANEMJCK(KADBECGIMPD);
				component.addItem(gdemcacnpng);
			}
			component.AGDCELDJAKK();
		}
	}

	// Token: 0x06005779 RID: 22393 RVA: 0x00293FA8 File Offset: 0x002921A8
	public void IBEOHLDOOOK(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.PNBECHOLCJM();
			int num = KADBECGIMPD.AGNKAFLKCAG();
			int pnedpppeffg = KADBECGIMPD.KKOKFLMMAAK();
			int hdelgedddce = KADBECGIMPD.KKOKFLMMAAK();
			int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
			this.IOHHGMOMDMA.UI_data[4].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.BEGAIJKPDDD(lpfkfnlhgbi, "WallSit", true, true);
			this.IOHHGMOMDMA.UI_data[4].GetComponent<Text>().text = string.Format(JNBICAJIJMM.CDDCIKKDFMP("CratePull"), num, JNBICAJIJMM.APMJBBDBOJO().KIBGNDMNMNO(pnedpppeffg), JNBICAJIJMM.APMJBBDBOJO().JLDLEFLDHCM(hdelgedddce, 1));
			long lpfkfnlhgbi2 = KADBECGIMPD.ANPEIKGEDHJ();
			ELCMHGJLFOL.IKGFHGKKCPG.AHEDNDEJLJP(lpfkfnlhgbi2).ONIJHKMCCHH(KADBECGIMPD);
			KADBECGIMPD.KDNDJNEGBDI();
			long num2 = KADBECGIMPD.KLHDFFHONON();
			KADBECGIMPD.JALHMJEKMHF();
			string gcoibldnoim = KADBECGIMPD.FDIDEGHPJPF();
			string text = KADBECGIMPD.DHCMILPKJAL();
			DateTime dateTime = KADBECGIMPD.HGFHMFMNIEI();
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.JKIFIBEPICO().MOGDIOFGLME) > 0)
			{
				text = string.Format("Escaped backslash \\\nEscaped bracket [[\nClosing bracket ]\n", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[3].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DIOJFJMOPJO("Dealer Shuffle"), text);
			this.IOHHGMOMDMA.UI_data[5].GetComponent<Text>().text = string.Format(JNBICAJIJMM.OOOKJHOHPNN("WoodCut"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.LPJBJGJJBLB(gcoibldnoim, new Action<Texture2D>(this.ALPKIHPNHIO));
			UIListBox component = this.IOHHGMOMDMA.UI_data[2].GetComponent<UIListBox>();
			while (!KADBECGIMPD.LILLHFLDMBH())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.JKLHIJKGLJB(KADBECGIMPD);
				component.BEMLEDDBMNG(gdemcacnpng);
			}
			component.sortItemList();
		}
	}

	// Token: 0x0600577A RID: 22394 RVA: 0x002941A4 File Offset: 0x002923A4
	private void PJAEGPLDLGJ(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(152f, 1994f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(20f, 1547f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x0600577B RID: 22395 RVA: 0x00294218 File Offset: 0x00292418
	private void CBPHPEAEBCG(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1507f, 1829f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(378f, 1981f));
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x0600577C RID: 22396 RVA: 0x0029428C File Offset: 0x0029248C
	private void OOKDJPACLPD(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(219f, 1661f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(159f, 329f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x0600577D RID: 22397 RVA: 0x00294300 File Offset: 0x00292500
	public void GEPKOADCKHI(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = KADBECGIMPD.FDIDEGHPJPF();
			int num = KADBECGIMPD.KDNDJNEGBDI();
			int pnedpppeffg = KADBECGIMPD.HHLDBAEFNMJ();
			int hdelgedddce = KADBECGIMPD.HHLDBAEFNMJ();
			int lpfkfnlhgbi = KADBECGIMPD.LDLKLPJBIJN();
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.GGGFKBAAADC(lpfkfnlhgbi, "reflectQuality", true, true);
			this.IOHHGMOMDMA.UI_data[5].GetComponent<Text>().text = string.Format(JNBICAJIJMM.CELEPPAEKAB("FOG_SCATTERING_ON"), num, JNBICAJIJMM.IKGFHGKKCPG.LJEJINKGKAK(pnedpppeffg), JNBICAJIJMM.EKEBHIJMEML().LIPNKJMOKLI(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.HFOPFEJDJFG();
			ELCMHGJLFOL.IKGFHGKKCPG.CHKNPLNHJFO(lpfkfnlhgbi2).OCPAHLAGCAI(KADBECGIMPD);
			KADBECGIMPD.HHLDBAEFNMJ();
			long num2 = KADBECGIMPD.KLHDFFHONON();
			KADBECGIMPD.BEMFIFGOJBL();
			string gcoibldnoim = KADBECGIMPD.NCODBGMGNFD();
			string text = KADBECGIMPD.JJJJAGJCOGD();
			DateTime dateTime = KADBECGIMPD.PFKHMDDOHDN();
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.PLGADNLAEGN().MOGDIOFGLME) > 1)
			{
				text = string.Format("WoodSaw", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[4].GetComponent<Text>().text = string.Format(JNBICAJIJMM.LEBHCLDODNI("x"), text);
			this.IOHHGMOMDMA.UI_data[3].GetComponent<Text>().text = string.Format(JNBICAJIJMM.BDKHMOOFHHK("IdleStun"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.IMIKJNEDCKM(gcoibldnoim, new Action<Texture2D>(this.LCMPOJIHKGF));
			UIListBox component = this.IOHHGMOMDMA.UI_data[3].GetComponent<UIListBox>();
			while (!KADBECGIMPD.PPAHBNGECGH())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.OCPAHLAGCAI(KADBECGIMPD);
				component.IPENPEOKJJF(gdemcacnpng);
			}
			component.sortItemList();
		}
	}

	// Token: 0x0600577E RID: 22398 RVA: 0x002944FC File Offset: 0x002926FC
	public void IBLMICBKOHE(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.FDIDEGHPJPF();
			int num = KADBECGIMPD.HDBGOLAFOBK();
			int pnedpppeffg = KADBECGIMPD.IFDFHJLCHAE();
			int hdelgedddce = KADBECGIMPD.AGNKAFLKCAG();
			int lpfkfnlhgbi = KADBECGIMPD.KDNDJNEGBDI();
			this.IOHHGMOMDMA.UI_data[3].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.PKOFLNMMADN(lpfkfnlhgbi, "ok", false, true);
			this.IOHHGMOMDMA.UI_data[8].GetComponent<Text>().text = string.Format(JNBICAJIJMM.PPNKMDJBMLP("Blending "), num, JNBICAJIJMM.EEOPOHEALPK().HHOIGKJMAGP(pnedpppeffg), JNBICAJIJMM.CLIMNFDGOEG().IAODIDBLHMM(hdelgedddce, 1));
			long lpfkfnlhgbi2 = KADBECGIMPD.HHMGLDMFCPF();
			ELCMHGJLFOL.IKGFHGKKCPG.GECBLDDOENE(lpfkfnlhgbi2).KIALEELDFDJ(KADBECGIMPD);
			KADBECGIMPD.KKOKFLMMAAK();
			long num2 = KADBECGIMPD.IJDIMHAEAIE();
			KADBECGIMPD.JNOKJCDAPPA();
			string gcoibldnoim = KADBECGIMPD.KDELAFDDGJH();
			string text = KADBECGIMPD.LPKJHMGLCKA();
			DateTime dateTime = KADBECGIMPD.OJNFAHFAKDO();
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.EAJHPOJPPFA().MOGDIOFGLME) > 0)
			{
				text = string.Format("crft_crft", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[3].GetComponent<Text>().text = string.Format(JNBICAJIJMM.BDKHMOOFHHK("wpn_eat7"), text);
			this.IOHHGMOMDMA.UI_data[3].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DCEBAJIILPC("HH:mm"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.GGHIEBCHCJB(gcoibldnoim, new Action<Texture2D>(this.LMJMHNIALAA));
			UIListBox component = this.IOHHGMOMDMA.UI_data[0].GetComponent<UIListBox>();
			while (!KADBECGIMPD.PPAHBNGECGH())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.OHAMJIKDMMF(KADBECGIMPD);
				component.addItem(gdemcacnpng);
			}
			component.AGDCELDJAKK();
		}
	}

	// Token: 0x0600577F RID: 22399 RVA: 0x002946F8 File Offset: 0x002928F8
	private void GECAEANKDBB(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1544f, 1395f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(1278f, 1524f));
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005780 RID: 22400 RVA: 0x0029476C File Offset: 0x0029296C
	public void JLFFGGBMGAP(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.LPKJHMGLCKA();
			int num = KADBECGIMPD.KDNDJNEGBDI();
			int pnedpppeffg = KADBECGIMPD.LDLKLPJBIJN();
			int hdelgedddce = KADBECGIMPD.HDBGOLAFOBK();
			int lpfkfnlhgbi = KADBECGIMPD.CLPEKGGAMAI();
			this.IOHHGMOMDMA.UI_data[7].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.EDCDLKNNBGC(lpfkfnlhgbi, "", true, true);
			this.IOHHGMOMDMA.UI_data[6].GetComponent<Text>().text = string.Format(JNBICAJIJMM.CELEPPAEKAB("RunBackLeft"), num, JNBICAJIJMM.APMJBBDBOJO().KHKAOHCCPAJ(pnedpppeffg), JNBICAJIJMM.LPHMKPDBMPP().IAODIDBLHMM(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.EJPMFEJBGMN();
			ELCMHGJLFOL.IKGFHGKKCPG.IOHGFMOAJIE(lpfkfnlhgbi2).LFOPENOJDIM(KADBECGIMPD);
			KADBECGIMPD.CLPEKGGAMAI();
			long num2 = KADBECGIMPD.DNIIFBAIPBE();
			KADBECGIMPD.IOEEPNCKLJD();
			string gcoibldnoim = KADBECGIMPD.FDIDEGHPJPF();
			string text = KADBECGIMPD.FDIDEGHPJPF();
			DateTime dateTime = KADBECGIMPD.IKJAOHGGCJD();
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.BOKIOJFHNLD().MOGDIOFGLME) > 1)
			{
				text = string.Format("TOD_Sky2World", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[3].GetComponent<Text>().text = string.Format(JNBICAJIJMM.OOOKJHOHPNN(" "), text);
			this.IOHHGMOMDMA.UI_data[8].GetComponent<Text>().text = string.Format(JNBICAJIJMM.CDDCIKKDFMP("WeaponReload"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.LDDNKBPKHPP(gcoibldnoim, new Action<Texture2D>(this.LINBGJAFMBN));
			UIListBox component = this.IOHHGMOMDMA.UI_data[4].GetComponent<UIListBox>();
			while (!KADBECGIMPD.PPAHBNGECGH())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.JKLHIJKGLJB(KADBECGIMPD);
				component.addItem(gdemcacnpng);
			}
			component.NLDMMAPPJPP();
		}
	}

	// Token: 0x06005781 RID: 22401 RVA: 0x00294968 File Offset: 0x00292B68
	private void ALPKIHPNHIO(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1642f, 307f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(299f, 889f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005782 RID: 22402 RVA: 0x002949DC File Offset: 0x00292BDC
	private void NEGFEEFLFHN(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1148f, 597f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(942f, 855f));
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005783 RID: 22403 RVA: 0x00294A50 File Offset: 0x00292C50
	private void EDEMMEKOPNL(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(660f, 1451f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(1381f, 180f));
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005784 RID: 22404 RVA: 0x00294AC4 File Offset: 0x00292CC4
	private void PDEGMHNMHCH(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1812f, 1889f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(407f, 1433f));
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005785 RID: 22405 RVA: 0x00294B38 File Offset: 0x00292D38
	private void KPIFDCABOOG(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1885f, 1849f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(980f, 1520f));
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005786 RID: 22406 RVA: 0x00294BAC File Offset: 0x00292DAC
	public void CDFLBCFHHIA(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.NCODBGMGNFD();
			int num = KADBECGIMPD.CLPEKGGAMAI();
			int pnedpppeffg = KADBECGIMPD.AGNKAFLKCAG();
			int hdelgedddce = KADBECGIMPD.LDLKLPJBIJN();
			int lpfkfnlhgbi = KADBECGIMPD.HHLDBAEFNMJ();
			this.IOHHGMOMDMA.UI_data[5].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.FGNOEEAHKED(lpfkfnlhgbi, "VA ", false, true);
			this.IOHHGMOMDMA.UI_data[8].GetComponent<Text>().text = string.Format(JNBICAJIJMM.BDKHMOOFHHK("UNIQUE_SHADOW_LIGHT_COOKIE"), num, JNBICAJIJMM.IMLLGEMPHAP().KHKAOHCCPAJ(pnedpppeffg), JNBICAJIJMM.EKEBHIJMEML().JLDLEFLDHCM(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.DCGEOFHNBCN();
			ELCMHGJLFOL.IKGFHGKKCPG.OPGIDHFNIGC(lpfkfnlhgbi2).OLGEDIFBGNL(KADBECGIMPD);
			KADBECGIMPD.DOJKJHMJJNK();
			long num2 = KADBECGIMPD.DMABDIGCLKA();
			KADBECGIMPD.BLNIHNKJJPJ();
			string gcoibldnoim = KADBECGIMPD.BFPHBMDMODH();
			string text = KADBECGIMPD.LPKJHMGLCKA();
			DateTime dateTime = KADBECGIMPD.MLFLLBPGFIJ();
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.PLGADNLAEGN().MOGDIOFGLME) > 0)
			{
				text = string.Format("IdleWalk", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[7].GetComponent<Text>().text = string.Format(JNBICAJIJMM.OOOKJHOHPNN("http://www.root-motion.com/finalikdox/html/page5.html"), text);
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = string.Format(JNBICAJIJMM.PGJCPFNJNPM("ComeHere"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.GLEICAAIOBN(gcoibldnoim, new Action<Texture2D>(this.ALCKAIKCOOM));
			UIListBox component = this.IOHHGMOMDMA.UI_data[8].GetComponent<UIListBox>();
			while (!KADBECGIMPD.NNOJEFMEGEG())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.GBIFKNOMLGN(KADBECGIMPD);
				component.IPENPEOKJJF(gdemcacnpng);
			}
			component.NLDMMAPPJPP();
		}
	}

	// Token: 0x06005787 RID: 22407 RVA: 0x00294DA8 File Offset: 0x00292FA8
	public void NKFLGIOPGGI(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.BFPHBMDMODH();
			int num = KADBECGIMPD.HDBGOLAFOBK();
			int pnedpppeffg = KADBECGIMPD.KKOKFLMMAAK();
			int hdelgedddce = KADBECGIMPD.KDNDJNEGBDI();
			int lpfkfnlhgbi = KADBECGIMPD.KKOKFLMMAAK();
			this.IOHHGMOMDMA.UI_data[5].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.HHJHDLHKJDF(lpfkfnlhgbi, "ComeHere", false, true);
			this.IOHHGMOMDMA.UI_data[6].GetComponent<Text>().text = string.Format(JNBICAJIJMM.BDKHMOOFHHK("<color='#303030'><size=10>{0}</size></color>\n<size=16><b>{1}</b></size><color='#302020'>  {3}</color>{2}"), num, JNBICAJIJMM.IMLLGEMPHAP().HFDIEKGBGEN(pnedpppeffg), JNBICAJIJMM.IKGFHGKKCPG.IKGPJIMGAJL(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.DNIIFBAIPBE();
			ELCMHGJLFOL.IKGFHGKKCPG.CHKNPLNHJFO(lpfkfnlhgbi2).KIALEELDFDJ(KADBECGIMPD);
			KADBECGIMPD.LDLKLPJBIJN();
			long num2 = KADBECGIMPD.IBKCNEICPEL();
			KADBECGIMPD.BLNIHNKJJPJ();
			string gcoibldnoim = KADBECGIMPD.LPKJHMGLCKA();
			string text = KADBECGIMPD.BFPHBMDMODH();
			DateTime dateTime = KADBECGIMPD.MILGIGJBAJL();
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.JKIFIBEPICO().MOGDIOFGLME) > 0)
			{
				text = string.Format("WizardOverhead", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[2].GetComponent<Text>().text = string.Format(JNBICAJIJMM.NGALDMFKMJH("IKMappingSpine is missing the left thigh bone."), text);
			this.IOHHGMOMDMA.UI_data[6].GetComponent<Text>().text = string.Format(JNBICAJIJMM.BDKHMOOFHHK("="), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.GJPOFPKJMCE(gcoibldnoim, new Action<Texture2D>(this.JMGJCJHBGHI));
			UIListBox component = this.IOHHGMOMDMA.UI_data[2].GetComponent<UIListBox>();
			while (!KADBECGIMPD.NLJJMKFBPBK())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.EPEGCPELLCN(KADBECGIMPD);
				component.IAAGBAAMIIO(gdemcacnpng);
			}
			component.EACMONLENJE();
		}
	}

	// Token: 0x06005788 RID: 22408 RVA: 0x00294FA4 File Offset: 0x002931A4
	private void LINBGJAFMBN(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1162f, 1331f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(741f, 897f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005789 RID: 22409 RVA: 0x00295018 File Offset: 0x00293218
	public void BJFFAMDCCFH(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = KADBECGIMPD.LPKJHMGLCKA();
			int num = KADBECGIMPD.HHLDBAEFNMJ();
			int pnedpppeffg = KADBECGIMPD.CLPEKGGAMAI();
			int hdelgedddce = KADBECGIMPD.KDNDJNEGBDI();
			int lpfkfnlhgbi = KADBECGIMPD.DOJKJHMJJNK();
			this.IOHHGMOMDMA.UI_data[2].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.DGEINNMPILO(lpfkfnlhgbi, "WorkerHammer", true, false);
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DCEBAJIILPC("▮▮▯"), num, JNBICAJIJMM.LPHMKPDBMPP().LJEJINKGKAK(pnedpppeffg), JNBICAJIJMM.EDKGBBIIBBC().JAANDJMPILF(hdelgedddce, 1));
			long lpfkfnlhgbi2 = KADBECGIMPD.KLHDFFHONON();
			ELCMHGJLFOL.IKGFHGKKCPG.GECBLDDOENE(lpfkfnlhgbi2).OLGEDIFBGNL(KADBECGIMPD);
			KADBECGIMPD.HHLDBAEFNMJ();
			long num2 = KADBECGIMPD.DCGEOFHNBCN();
			KADBECGIMPD.BEMFIFGOJBL();
			string gcoibldnoim = KADBECGIMPD.NCODBGMGNFD();
			string text = KADBECGIMPD.JJJJAGJCOGD();
			DateTime dateTime = KADBECGIMPD.PFKHMDDOHDN();
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.PLGADNLAEGN().MOGDIOFGLME) > 1)
			{
				text = string.Format("Clavicle", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[8].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DCEBAJIILPC("_name"), text);
			this.IOHHGMOMDMA.UI_data[8].GetComponent<Text>().text = string.Format(JNBICAJIJMM.PGJCPFNJNPM("Tonemapper curve texture"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.LDDNKBPKHPP(gcoibldnoim, new Action<Texture2D>(this.FJBIMEEPNBK));
			UIListBox component = this.IOHHGMOMDMA.UI_data[8].GetComponent<UIListBox>();
			while (!KADBECGIMPD.BKIBKLFCCGP())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.MBLEIMCGLCE(KADBECGIMPD);
				component.OOEOIIDOMAE(gdemcacnpng);
			}
			component.EACMONLENJE();
		}
	}

	// Token: 0x0600578A RID: 22410 RVA: 0x00295214 File Offset: 0x00293414
	public void KHAEHDDAEBC(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.DHCMILPKJAL();
			int num = KADBECGIMPD.IFDFHJLCHAE();
			int pnedpppeffg = KADBECGIMPD.KDNDJNEGBDI();
			int hdelgedddce = KADBECGIMPD.KKOKFLMMAAK();
			int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.PKOFLNMMADN(lpfkfnlhgbi, "#ffffff", false, false);
			this.IOHHGMOMDMA.UI_data[4].GetComponent<Text>().text = string.Format(JNBICAJIJMM.BDKHMOOFHHK("wgt_small.dat"), num, JNBICAJIJMM.APMJBBDBOJO().KHKAOHCCPAJ(pnedpppeffg), JNBICAJIJMM.LPHMKPDBMPP().IAODIDBLHMM(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.KLHDFFHONON();
			ELCMHGJLFOL.IKGFHGKKCPG.MKNBGEHEMPB(lpfkfnlhgbi2).NHHAANEMJCK(KADBECGIMPD);
			KADBECGIMPD.CLPEKGGAMAI();
			long num2 = KADBECGIMPD.DNIIFBAIPBE();
			KADBECGIMPD.FIFNOBGEKFF();
			string gcoibldnoim = KADBECGIMPD.DPLAJNEDGBL();
			string text = KADBECGIMPD.DPLAJNEDGBL();
			DateTime dateTime = KADBECGIMPD.OODOKDPIMOF();
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.BPPFAOOCENN().MOGDIOFGLME) > 0)
			{
				text = string.Format("wpn_eat1", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = string.Format(JNBICAJIJMM.NGALDMFKMJH("_Offsets"), text);
			this.IOHHGMOMDMA.UI_data[7].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DIOJFJMOPJO("file"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.PKBDDBCGDIM(gcoibldnoim, new Action<Texture2D>(this.ALECCJFMHPL));
			UIListBox component = this.IOHHGMOMDMA.UI_data[5].GetComponent<UIListBox>();
			while (!KADBECGIMPD.JCEGOADAOOI)
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.INDMOLIMBFB(KADBECGIMPD);
				component.OOEOIIDOMAE(gdemcacnpng);
			}
			component.AGDCELDJAKK();
		}
	}

	// Token: 0x0600578B RID: 22411 RVA: 0x00295410 File Offset: 0x00293610
	public void DFOAHAPJKMD(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = KADBECGIMPD.JJJJAGJCOGD();
			int num = KADBECGIMPD.IFDFHJLCHAE();
			int pnedpppeffg = KADBECGIMPD.DOJKJHMJJNK();
			int hdelgedddce = KADBECGIMPD.IFDFHJLCHAE();
			int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.EDCDLKNNBGC(lpfkfnlhgbi, "_name", true, false);
			this.IOHHGMOMDMA.UI_data[4].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DIOJFJMOPJO("Escaped backslash \\\nEscaped bracket [[\nClosing bracket ]\n"), num, JNBICAJIJMM.EDKGBBIIBBC().HHOIGKJMAGP(pnedpppeffg), JNBICAJIJMM.IKGFHGKKCPG.JAANDJMPILF(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.KLHDFFHONON();
			ELCMHGJLFOL.IKGFHGKKCPG.BCBCICJDIEF(lpfkfnlhgbi2).LBBBADCPGOI(KADBECGIMPD);
			KADBECGIMPD.HHLDBAEFNMJ();
			long num2 = KADBECGIMPD.DMABDIGCLKA();
			KADBECGIMPD.JALHMJEKMHF();
			string gcoibldnoim = KADBECGIMPD.KDELAFDDGJH();
			string text = KADBECGIMPD.DPLAJNEDGBL();
			DateTime dateTime = KADBECGIMPD.NIIFLPIEMFM();
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.PLGADNLAEGN().MOGDIOFGLME) > 1)
			{
				text = string.Format("Vertical", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[6].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DIOJFJMOPJO("wpn_dress1"), text);
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = string.Format(JNBICAJIJMM.CELEPPAEKAB("Reveling"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.GJPOFPKJMCE(gcoibldnoim, new Action<Texture2D>(this.EDEMMEKOPNL));
			UIListBox component = this.IOHHGMOMDMA.UI_data[6].GetComponent<UIListBox>();
			while (!KADBECGIMPD.JEFMHDJEEJC())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.JKHENPBFLCD(KADBECGIMPD);
				component.OOEOIIDOMAE(gdemcacnpng);
			}
			component.NLDMMAPPJPP();
		}
	}

	// Token: 0x0600578C RID: 22412 RVA: 0x0029560C File Offset: 0x0029380C
	private void LNGFFOANLKO(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(651f, 1392f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(1052f, 131f));
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x0600578D RID: 22413 RVA: 0x00295680 File Offset: 0x00293880
	public void LPCEKPGCGAG(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = KADBECGIMPD.BFPHBMDMODH();
			int num = KADBECGIMPD.DOJKJHMJJNK();
			int pnedpppeffg = KADBECGIMPD.CLPEKGGAMAI();
			int hdelgedddce = KADBECGIMPD.LDLKLPJBIJN();
			int lpfkfnlhgbi = KADBECGIMPD.KDNDJNEGBDI();
			this.IOHHGMOMDMA.UI_data[7].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.GGGFKBAAADC(lpfkfnlhgbi, "Colors length of ", false, false);
			this.IOHHGMOMDMA.UI_data[4].GetComponent<Text>().text = string.Format(JNBICAJIJMM.CELEPPAEKAB("<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}"), num, JNBICAJIJMM.IMLLGEMPHAP().HHOIGKJMAGP(pnedpppeffg), JNBICAJIJMM.IMLLGEMPHAP().JLDLEFLDHCM(hdelgedddce, 1));
			long lpfkfnlhgbi2 = KADBECGIMPD.DNIIFBAIPBE();
			ELCMHGJLFOL.IKGFHGKKCPG.AHEDNDEJLJP(lpfkfnlhgbi2).OLGEDIFBGNL(KADBECGIMPD);
			KADBECGIMPD.KDNDJNEGBDI();
			long num2 = KADBECGIMPD.IJDIMHAEAIE();
			KADBECGIMPD.DADCGPGEHFK();
			string gcoibldnoim = KADBECGIMPD.DHCMILPKJAL();
			string text = KADBECGIMPD.PNBECHOLCJM();
			DateTime dateTime = KADBECGIMPD.HGFHMFMNIEI();
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.NPCAKEGNBHD().MOGDIOFGLME) > 0)
			{
				text = string.Format("", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = string.Format(JNBICAJIJMM.OOOKJHOHPNN("</color>"), text);
			this.IOHHGMOMDMA.UI_data[4].GetComponent<Text>().text = string.Format(JNBICAJIJMM.NGALDMFKMJH("Giant2HandSlamIdle"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.LDDNKBPKHPP(gcoibldnoim, new Action<Texture2D>(this.MPIOJOCMPHG));
			UIListBox component = this.IOHHGMOMDMA.UI_data[1].GetComponent<UIListBox>();
			while (!KADBECGIMPD.HKBFCJDJCOB())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.NHHAANEMJCK(KADBECGIMPD);
				component.CNNKFIDHPMK(gdemcacnpng);
			}
			component.sortItemList();
		}
	}

	// Token: 0x0600578E RID: 22414 RVA: 0x0029587C File Offset: 0x00293A7C
	private void KBIFFALKLAP(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1240f, 546f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(1042f, 1406f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x0600578F RID: 22415 RVA: 0x002958F0 File Offset: 0x00293AF0
	private void GECDDAHHLEL(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1764f, 599f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(871f, 171f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005790 RID: 22416 RVA: 0x00295964 File Offset: 0x00293B64
	private void MFICLEKENDK(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(351f, 580f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(453f, 1258f));
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005791 RID: 22417 RVA: 0x002959D8 File Offset: 0x00293BD8
	public void MNDNKAFHBIF(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.NCODBGMGNFD();
			int num = KADBECGIMPD.LDLKLPJBIJN();
			int pnedpppeffg = KADBECGIMPD.KDNDJNEGBDI();
			int hdelgedddce = KADBECGIMPD.HHLDBAEFNMJ();
			int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
			this.IOHHGMOMDMA.UI_data[5].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.HBMGCEMAPOK(lpfkfnlhgbi, "{0}|{1}|{2}", false, true);
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = string.Format(JNBICAJIJMM.BDKHMOOFHHK("Actor_{0}_{1}_ragula"), num, JNBICAJIJMM.IKGFHGKKCPG.KIBGNDMNMNO(pnedpppeffg), JNBICAJIJMM.EDKGBBIIBBC().IAODIDBLHMM(hdelgedddce, 1));
			long lpfkfnlhgbi2 = KADBECGIMPD.EJPMFEJBGMN();
			ELCMHGJLFOL.IKGFHGKKCPG.OPGIDHFNIGC(lpfkfnlhgbi2).KAOKKLLOFBE(KADBECGIMPD);
			KADBECGIMPD.LDLKLPJBIJN();
			long num2 = KADBECGIMPD.EJPMFEJBGMN();
			KADBECGIMPD.AJECAOJPOKA();
			string gcoibldnoim = KADBECGIMPD.DPLAJNEDGBL();
			string text = KADBECGIMPD.DHCMILPKJAL();
			DateTime dateTime = KADBECGIMPD.PFKHMDDOHDN();
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.NPCAKEGNBHD().MOGDIOFGLME) > 0)
			{
				text = string.Format("sunshine_ShadowToWorldScale", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[5].GetComponent<Text>().text = string.Format(JNBICAJIJMM.PGJCPFNJNPM("MotorbikeShootLeft"), text);
			this.IOHHGMOMDMA.UI_data[8].GetComponent<Text>().text = string.Format(JNBICAJIJMM.NGALDMFKMJH(""), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.BMGICGHPAFB(gcoibldnoim, new Action<Texture2D>(this.ALECCJFMHPL));
			UIListBox component = this.IOHHGMOMDMA.UI_data[5].GetComponent<UIListBox>();
			while (!KADBECGIMPD.DFLKBBNOGBG())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.NHHAANEMJCK(KADBECGIMPD);
				component.IPENPEOKJJF(gdemcacnpng);
			}
			component.EACMONLENJE();
		}
	}

	// Token: 0x06005792 RID: 22418 RVA: 0x00295BD4 File Offset: 0x00293DD4
	private void EPPHABNLDLK(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(940f, 322f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(760f, 1411f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005793 RID: 22419 RVA: 0x00295C48 File Offset: 0x00293E48
	private void POIMCBGHFKH(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(509f, 112f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(502f, 1549f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005794 RID: 22420 RVA: 0x00295CBC File Offset: 0x00293EBC
	public void LMICIGNMPDD(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = KADBECGIMPD.NCODBGMGNFD();
			int num = KADBECGIMPD.KDNDJNEGBDI();
			int pnedpppeffg = KADBECGIMPD.DOJKJHMJJNK();
			int hdelgedddce = KADBECGIMPD.KKOKFLMMAAK();
			int lpfkfnlhgbi = KADBECGIMPD.KKOKFLMMAAK();
			this.IOHHGMOMDMA.UI_data[7].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.CGPPLMOFBDB(lpfkfnlhgbi, "Try to change this float in memory:\n", false, false);
			this.IOHHGMOMDMA.UI_data[2].GetComponent<Text>().text = string.Format(JNBICAJIJMM.NGALDMFKMJH("_BlurParams"), num, JNBICAJIJMM.APMJBBDBOJO().JDMOHJGPKIC(pnedpppeffg), JNBICAJIJMM.LPHMKPDBMPP().IKGPJIMGAJL(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.HFOPFEJDJFG();
			ELCMHGJLFOL.IKGFHGKKCPG.AIIPKFNLCKG(lpfkfnlhgbi2).FEEODCOLNIN(KADBECGIMPD);
			KADBECGIMPD.AGNKAFLKCAG();
			long num2 = KADBECGIMPD.ANPEIKGEDHJ();
			KADBECGIMPD.JALHMJEKMHF();
			string gcoibldnoim = KADBECGIMPD.DPLAJNEDGBL();
			string text = KADBECGIMPD.LPKJHMGLCKA();
			DateTime dateTime = KADBECGIMPD.PFKHMDDOHDN();
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.JKIFIBEPICO().MOGDIOFGLME) > 1)
			{
				text = string.Format("[ACTk] Obscured Cheating Detector: can't be started since it doesn't exists in scene or not yet initialized!", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[2].GetComponent<Text>().text = string.Format(JNBICAJIJMM.PGJCPFNJNPM("SoccerKeeperStrafeLeft"), text);
			this.IOHHGMOMDMA.UI_data[4].GetComponent<Text>().text = string.Format(JNBICAJIJMM.NGALDMFKMJH("_ProjInfo"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.POELMFIMAEG(gcoibldnoim, new Action<Texture2D>(this.POIMCBGHFKH));
			UIListBox component = this.IOHHGMOMDMA.UI_data[4].GetComponent<UIListBox>();
			while (!KADBECGIMPD.JCEGOADAOOI)
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.IJAHENJJNCA(KADBECGIMPD);
				component.CNNKFIDHPMK(gdemcacnpng);
			}
			component.AGDCELDJAKK();
		}
	}

	// Token: 0x06005795 RID: 22421 RVA: 0x00295EB8 File Offset: 0x002940B8
	public void DGJGPFAGFMB(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.FDIDEGHPJPF();
			int num = KADBECGIMPD.LDLKLPJBIJN();
			int pnedpppeffg = KADBECGIMPD.LDLKLPJBIJN();
			int hdelgedddce = KADBECGIMPD.CLPEKGGAMAI();
			int lpfkfnlhgbi = KADBECGIMPD.AGNKAFLKCAG();
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.KMGADIEIJHM(lpfkfnlhgbi, "MotorbikeWheely", true, false);
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DCEBAJIILPC("SteamPay error:"), num, JNBICAJIJMM.LPHMKPDBMPP().HHOIGKJMAGP(pnedpppeffg), JNBICAJIJMM.EEOPOHEALPK().JAANDJMPILF(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.HHMGLDMFCPF();
			ELCMHGJLFOL.IKGFHGKKCPG.EAPIDPPKCMF(lpfkfnlhgbi2).MPCIALDHHKN(KADBECGIMPD);
			KADBECGIMPD.AGNKAFLKCAG();
			long num2 = KADBECGIMPD.ANPEIKGEDHJ();
			KADBECGIMPD.BEMFIFGOJBL();
			string gcoibldnoim = KADBECGIMPD.FDIDEGHPJPF();
			string text = KADBECGIMPD.PNBECHOLCJM();
			DateTime dateTime = KADBECGIMPD.FCGGODFGMCB();
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.PFOLNEGNIPP().MOGDIOFGLME) > 1)
			{
				text = string.Format("SwimFreestyle", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = string.Format(JNBICAJIJMM.LEBHCLDODNI("Hidden/Post FX/Motion Blur"), text);
			this.IOHHGMOMDMA.UI_data[5].GetComponent<Text>().text = string.Format(JNBICAJIJMM.PGJCPFNJNPM("wgt_kg"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.BMGICGHPAFB(gcoibldnoim, new Action<Texture2D>(this.LMJMHNIALAA));
			UIListBox component = this.IOHHGMOMDMA.UI_data[1].GetComponent<UIListBox>();
			while (!KADBECGIMPD.DFLKBBNOGBG())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.IHONANEEDOC(KADBECGIMPD);
				component.OBMAFPODNJA(gdemcacnpng);
			}
			component.sortItemList();
		}
	}

	// Token: 0x06005796 RID: 22422 RVA: 0x002960B4 File Offset: 0x002942B4
	public void HFELCMKCJFH(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = KADBECGIMPD.KDELAFDDGJH();
			int num = KADBECGIMPD.HHLDBAEFNMJ();
			int pnedpppeffg = KADBECGIMPD.KKOKFLMMAAK();
			int hdelgedddce = KADBECGIMPD.HHLDBAEFNMJ();
			int lpfkfnlhgbi = KADBECGIMPD.IFDFHJLCHAE();
			this.IOHHGMOMDMA.UI_data[2].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.HPPPPEHMEKL(lpfkfnlhgbi, "_Intensity", false, true);
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DCEBAJIILPC("OneHandSwordIdle"), num, JNBICAJIJMM.EDKGBBIIBBC().ECDAPHMNOMB(pnedpppeffg), JNBICAJIJMM.CLIMNFDGOEG().LIPNKJMOKLI(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.EJPMFEJBGMN();
			ELCMHGJLFOL.IKGFHGKKCPG.INEIMJBBPHJ(lpfkfnlhgbi2).FNJFCJFAJFG(KADBECGIMPD);
			KADBECGIMPD.KDNDJNEGBDI();
			long num2 = KADBECGIMPD.DCGEOFHNBCN();
			KADBECGIMPD.IJJDHHFAIPE();
			string gcoibldnoim = KADBECGIMPD.LPKJHMGLCKA();
			string text = KADBECGIMPD.DPLAJNEDGBL();
			DateTime dateTime = KADBECGIMPD.OJNFAHFAKDO();
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.IKGFHGKKCPG.MOGDIOFGLME) > 0)
			{
				text = string.Format("no assemblies", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = string.Format(JNBICAJIJMM.BDKHMOOFHHK("error.wav"), text);
			this.IOHHGMOMDMA.UI_data[5].GetComponent<Text>().text = string.Format(JNBICAJIJMM.BDKHMOOFHHK("FactoryTempTexture"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.GLEICAAIOBN(gcoibldnoim, new Action<Texture2D>(this.IAAHCKHLNAG));
			UIListBox component = this.IOHHGMOMDMA.UI_data[4].GetComponent<UIListBox>();
			while (!KADBECGIMPD.LILLHFLDMBH())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.OHAMJIKDMMF(KADBECGIMPD);
				component.IAAGBAAMIIO(gdemcacnpng);
			}
			component.sortItemList();
		}
	}

	// Token: 0x06005797 RID: 22423 RVA: 0x002962B0 File Offset: 0x002944B0
	public void KFFLHCBLODK(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = KADBECGIMPD.JJJJAGJCOGD();
			int num = KADBECGIMPD.DOJKJHMJJNK();
			int pnedpppeffg = KADBECGIMPD.LDLKLPJBIJN();
			int hdelgedddce = KADBECGIMPD.HHLDBAEFNMJ();
			int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
			this.IOHHGMOMDMA.UI_data[3].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.EBGHGKKMMGH(lpfkfnlhgbi, "TYPES", false, true);
			this.IOHHGMOMDMA.UI_data[5].GetComponent<Text>().text = string.Format(JNBICAJIJMM.CELEPPAEKAB("Mouse X"), num, JNBICAJIJMM.LPHMKPDBMPP().ECDAPHMNOMB(pnedpppeffg), JNBICAJIJMM.CLIMNFDGOEG().IGOOOILHFPL(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.IJDIMHAEAIE();
			ELCMHGJLFOL.IKGFHGKKCPG.MNJOAIFPFHL(lpfkfnlhgbi2).FNJFCJFAJFG(KADBECGIMPD);
			KADBECGIMPD.LDLKLPJBIJN();
			long num2 = KADBECGIMPD.ANPEIKGEDHJ();
			KADBECGIMPD.BLNIHNKJJPJ();
			string gcoibldnoim = KADBECGIMPD.JJJJAGJCOGD();
			string text = KADBECGIMPD.NCODBGMGNFD();
			DateTime dateTime = KADBECGIMPD.HGFHMFMNIEI();
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.NPCAKEGNBHD().MOGDIOFGLME) > 0)
			{
				text = string.Format("firsStartMovePanel", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[3].GetComponent<Text>().text = string.Format(JNBICAJIJMM.PGJCPFNJNPM(""), text);
			this.IOHHGMOMDMA.UI_data[4].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DCEBAJIILPC("recept"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.GLEICAAIOBN(gcoibldnoim, new Action<Texture2D>(this.KPIFDCABOOG));
			UIListBox component = this.IOHHGMOMDMA.UI_data[3].GetComponent<UIListBox>();
			while (!KADBECGIMPD.JEFMHDJEEJC())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.HAGJNPDIIIC(KADBECGIMPD);
				component.BEMLEDDBMNG(gdemcacnpng);
			}
			component.NLDMMAPPJPP();
		}
	}

	// Token: 0x06005798 RID: 22424 RVA: 0x002964AC File Offset: 0x002946AC
	private void BIGEKJALAGP(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1754f, 1269f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(1148f, 135f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x06005799 RID: 22425 RVA: 0x00296520 File Offset: 0x00294720
	public void initUserData(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = KADBECGIMPD.BFPHBMDMODH();
			int num = KADBECGIMPD.HDBGOLAFOBK();
			int pnedpppeffg = KADBECGIMPD.HDBGOLAFOBK();
			int hdelgedddce = KADBECGIMPD.HDBGOLAFOBK();
			int lpfkfnlhgbi = KADBECGIMPD.HDBGOLAFOBK();
			this.IOHHGMOMDMA.UI_data[2].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.HHJHDLHKJDF(lpfkfnlhgbi, "", false, true);
			this.IOHHGMOMDMA.UI_data[3].GetComponent<Text>().text = string.Format(JNBICAJIJMM.LEBHCLDODNI("usr_inf_a1"), num, JNBICAJIJMM.IKGFHGKKCPG.KHKAOHCCPAJ(pnedpppeffg), JNBICAJIJMM.IKGFHGKKCPG.IGOOOILHFPL(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.DNIIFBAIPBE();
			ELCMHGJLFOL.IKGFHGKKCPG.GMPNBBLOHGF(lpfkfnlhgbi2).OCPAHLAGCAI(KADBECGIMPD);
			KADBECGIMPD.HDBGOLAFOBK();
			long num2 = KADBECGIMPD.DNIIFBAIPBE();
			KADBECGIMPD.FIFNOBGEKFF();
			string gcoibldnoim = KADBECGIMPD.BFPHBMDMODH();
			string text = KADBECGIMPD.BFPHBMDMODH();
			DateTime dateTime = KADBECGIMPD.IKJAOHGGCJD();
			if (ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.MOGDIOFGLME) > 0)
			{
				text = string.Format("AccID:{0} PlayID:{1} StN:{2}", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[4].GetComponent<Text>().text = string.Format(JNBICAJIJMM.LEBHCLDODNI("usr_inf_a3"), text);
			this.IOHHGMOMDMA.UI_data[5].GetComponent<Text>().text = string.Format(JNBICAJIJMM.LEBHCLDODNI("usr_inf_a4"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.GJPOFPKJMCE(gcoibldnoim, new Action<Texture2D>(this.FELKBCGHPOP));
			UIListBox component = this.IOHHGMOMDMA.UI_data[8].GetComponent<UIListBox>();
			while (!KADBECGIMPD.JCEGOADAOOI)
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.OCPAHLAGCAI(KADBECGIMPD);
				component.addItem(gdemcacnpng);
			}
			component.sortItemList();
		}
	}

	// Token: 0x0600579A RID: 22426 RVA: 0x0029671C File Offset: 0x0029491C
	public void ONLLGKDHONF(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.NCODBGMGNFD();
			int num = KADBECGIMPD.KKOKFLMMAAK();
			int pnedpppeffg = KADBECGIMPD.CLPEKGGAMAI();
			int hdelgedddce = KADBECGIMPD.KKOKFLMMAAK();
			int lpfkfnlhgbi = KADBECGIMPD.AGNKAFLKCAG();
			this.IOHHGMOMDMA.UI_data[3].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.KOONNKMMCBB(lpfkfnlhgbi, "_ChannelMixerBlue", false, true);
			this.IOHHGMOMDMA.UI_data[7].GetComponent<Text>().text = string.Format(JNBICAJIJMM.PPNKMDJBMLP("bool:"), num, JNBICAJIJMM.IKGFHGKKCPG.ECDAPHMNOMB(pnedpppeffg), JNBICAJIJMM.CLIMNFDGOEG().JAANDJMPILF(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.ANPEIKGEDHJ();
			ELCMHGJLFOL.IKGFHGKKCPG.MCBGCEFDIJP(lpfkfnlhgbi2).ONIJHKMCCHH(KADBECGIMPD);
			KADBECGIMPD.LDLKLPJBIJN();
			long num2 = KADBECGIMPD.ANPEIKGEDHJ();
			KADBECGIMPD.ELDBJFLCMAJ();
			string gcoibldnoim = KADBECGIMPD.BFPHBMDMODH();
			string text = KADBECGIMPD.NCODBGMGNFD();
			DateTime dateTime = KADBECGIMPD.MLFLLBPGFIJ();
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.PLGADNLAEGN().MOGDIOFGLME) > 0)
			{
				text = string.Format("Flares", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[2].GetComponent<Text>().text = string.Format(JNBICAJIJMM.LEBHCLDODNI("u_pin"), text);
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = string.Format(JNBICAJIJMM.BDKHMOOFHHK("LeftSplashPause"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.GDOENILFJFK(gcoibldnoim, new Action<Texture2D>(this.IJGMHFBGGOH));
			UIListBox component = this.IOHHGMOMDMA.UI_data[5].GetComponent<UIListBox>();
			while (!KADBECGIMPD.ODIBHLOAGBC())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.GBIFKNOMLGN(KADBECGIMPD);
				component.addItem(gdemcacnpng);
			}
			component.NLDMMAPPJPP();
		}
	}

	// Token: 0x0600579B RID: 22427 RVA: 0x00296918 File Offset: 0x00294B18
	public void HIPBBMFBEAF(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.BFPHBMDMODH();
			int num = KADBECGIMPD.HHLDBAEFNMJ();
			int pnedpppeffg = KADBECGIMPD.AGNKAFLKCAG();
			int hdelgedddce = KADBECGIMPD.AGNKAFLKCAG();
			int lpfkfnlhgbi = KADBECGIMPD.DOJKJHMJJNK();
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.IAIPLNNKKPK(lpfkfnlhgbi, "0", false, true);
			this.IOHHGMOMDMA.UI_data[5].GetComponent<Text>().text = string.Format(JNBICAJIJMM.LEBHCLDODNI(": "), num, JNBICAJIJMM.EDKGBBIIBBC().ECDAPHMNOMB(pnedpppeffg), JNBICAJIJMM.EKEBHIJMEML().IAODIDBLHMM(hdelgedddce, 1));
			long lpfkfnlhgbi2 = KADBECGIMPD.DNIIFBAIPBE();
			ELCMHGJLFOL.IKGFHGKKCPG.BKIILLHFAKE(lpfkfnlhgbi2).FEEODCOLNIN(KADBECGIMPD);
			KADBECGIMPD.HHLDBAEFNMJ();
			long num2 = KADBECGIMPD.IBKCNEICPEL();
			KADBECGIMPD.OMCMPDMJFOJ();
			string gcoibldnoim = KADBECGIMPD.NCODBGMGNFD();
			string text = KADBECGIMPD.DPLAJNEDGBL();
			DateTime dateTime = KADBECGIMPD.NIIFLPIEMFM();
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.PLGADNLAEGN().MOGDIOFGLME) > 0)
			{
				text = string.Format("CrawlIdle", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = string.Format(JNBICAJIJMM.PGJCPFNJNPM(" is represented multiple times in the Bones."), text);
			this.IOHHGMOMDMA.UI_data[7].GetComponent<Text>().text = string.Format(JNBICAJIJMM.CELEPPAEKAB("OneHandSwordReady"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.HJPKNFEBBLO(gcoibldnoim, new Action<Texture2D>(this.MPIOJOCMPHG));
			UIListBox component = this.IOHHGMOMDMA.UI_data[7].GetComponent<UIListBox>();
			while (!KADBECGIMPD.JCEGOADAOOI)
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.IJAHENJJNCA(KADBECGIMPD);
				component.addItem(gdemcacnpng);
			}
			component.NLDMMAPPJPP();
		}
	}

	// Token: 0x0600579C RID: 22428 RVA: 0x00296B14 File Offset: 0x00294D14
	public void ONMFAFKAIAL(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.FDIDEGHPJPF();
			int num = KADBECGIMPD.DOJKJHMJJNK();
			int pnedpppeffg = KADBECGIMPD.HHLDBAEFNMJ();
			int hdelgedddce = KADBECGIMPD.HDBGOLAFOBK();
			int lpfkfnlhgbi = KADBECGIMPD.DOJKJHMJJNK();
			this.IOHHGMOMDMA.UI_data[5].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.CDFDGCAOMLM(lpfkfnlhgbi, "effects", false, false);
			this.IOHHGMOMDMA.UI_data[5].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DCEBAJIILPC("Hidden/Amplify Color/Base"), num, JNBICAJIJMM.EDKGBBIIBBC().JDMOHJGPKIC(pnedpppeffg), JNBICAJIJMM.CLIMNFDGOEG().JAANDJMPILF(hdelgedddce, 1));
			long lpfkfnlhgbi2 = KADBECGIMPD.DMABDIGCLKA();
			ELCMHGJLFOL.IKGFHGKKCPG.AIIPKFNLCKG(lpfkfnlhgbi2).LFOPENOJDIM(KADBECGIMPD);
			KADBECGIMPD.HDBGOLAFOBK();
			long num2 = KADBECGIMPD.DNIIFBAIPBE();
			KADBECGIMPD.BLNIHNKJJPJ();
			string gcoibldnoim = KADBECGIMPD.FDIDEGHPJPF();
			string text = KADBECGIMPD.JJJJAGJCOGD();
			DateTime dateTime = KADBECGIMPD.IKJAOHGGCJD();
			if (ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.IKGFHGKKCPG.MOGDIOFGLME) > 1)
			{
				text = string.Format("MotorbikeHeadstand", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[0].GetComponent<Text>().text = string.Format(JNBICAJIJMM.NGALDMFKMJH("Giant2HandSlamIdle"), text);
			this.IOHHGMOMDMA.UI_data[4].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DIOJFJMOPJO("Life bar: "), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.BMGICGHPAFB(gcoibldnoim, new Action<Texture2D>(this.JFNPDDNLIPE));
			UIListBox component = this.IOHHGMOMDMA.UI_data[2].GetComponent<UIListBox>();
			while (!KADBECGIMPD.JCEGOADAOOI)
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.JKHENPBFLCD(KADBECGIMPD);
				component.OOEOIIDOMAE(gdemcacnpng);
			}
			component.AGDCELDJAKK();
		}
	}

	// Token: 0x0600579D RID: 22429 RVA: 0x00296D10 File Offset: 0x00294F10
	private void MPIOJOCMPHG(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(1557f, 1982f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(906f, 811f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x0600579E RID: 22430 RVA: 0x00296D84 File Offset: 0x00294F84
	private void JFNPDDNLIPE(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(450f, 297f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(611f, 1042f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x0600579F RID: 22431 RVA: 0x00296DF8 File Offset: 0x00294FF8
	private void KKIDANFACAL(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(841f, 1077f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(1311f, 893f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x060057A0 RID: 22432 RVA: 0x00296E6C File Offset: 0x0029506C
	private void MMODPAEHGOC(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(694f, 1457f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(852f, 1696f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x060057A1 RID: 22433 RVA: 0x00296EE0 File Offset: 0x002950E0
	private void IJGMHFBGGOH(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[1].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(773f, 607f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(583f, 860f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x060057A2 RID: 22434 RVA: 0x00296F54 File Offset: 0x00295154
	private void PGJAICGNPCA(Texture2D NAGPDILILNL)
	{
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().sprite = Sprite.Create(NAGPDILILNL, new Rect(128f, 1520f, (float)NAGPDILILNL.width, (float)NAGPDILILNL.height), new Vector2(1065f, 1214f));
		this.IOHHGMOMDMA.UI_data[0].GetComponent<Image>().color = Color.white;
	}

	// Token: 0x060057A3 RID: 22435 RVA: 0x00296FC8 File Offset: 0x002951C8
	public void DNGEFOJHNPA(long JOCKHMHOIIA, HBPNMNGOFMA KADBECGIMPD)
	{
		this.LIEMOHDFBBL = JOCKHMHOIIA;
		this.IOHHGMOMDMA = base.GetComponent<BaseWindow>();
		if (this.IOHHGMOMDMA != null)
		{
			this.IOHHGMOMDMA.UI_data[1].GetComponent<Text>().text = KADBECGIMPD.JJJJAGJCOGD();
			int num = KADBECGIMPD.KDNDJNEGBDI();
			int pnedpppeffg = KADBECGIMPD.DOJKJHMJJNK();
			int hdelgedddce = KADBECGIMPD.KDNDJNEGBDI();
			int lpfkfnlhgbi = KADBECGIMPD.KDNDJNEGBDI();
			this.IOHHGMOMDMA.UI_data[4].GetComponent<Text>().text = NHCAOFIKNFE.IKGFHGKKCPG.HPPPPEHMEKL(lpfkfnlhgbi, "newDayTime", true, true);
			this.IOHHGMOMDMA.UI_data[2].GetComponent<Text>().text = string.Format(JNBICAJIJMM.LEBHCLDODNI("SoccerStartKick"), num, JNBICAJIJMM.APMJBBDBOJO().FCNFDLDHDDE(pnedpppeffg), JNBICAJIJMM.APMJBBDBOJO().JAANDJMPILF(hdelgedddce, 0));
			long lpfkfnlhgbi2 = KADBECGIMPD.HFOPFEJDJFG();
			ELCMHGJLFOL.IKGFHGKKCPG.GECBLDDOENE(lpfkfnlhgbi2).MPCIALDHHKN(KADBECGIMPD);
			KADBECGIMPD.LDLKLPJBIJN();
			long num2 = KADBECGIMPD.DNIIFBAIPBE();
			KADBECGIMPD.KJIOFDCKIKO();
			string gcoibldnoim = KADBECGIMPD.FDIDEGHPJPF();
			string text = KADBECGIMPD.KDELAFDDGJH();
			DateTime dateTime = KADBECGIMPD.HGFHMFMNIEI();
			if (ObscuredInt.DGOCFCFPKPI(JBEHMPDDMME.EAJHPOJPPFA().MOGDIOFGLME) > 0)
			{
				text = string.Format("RollerBladeCrossoverLeft", num2, this.LIEMOHDFBBL, text);
			}
			this.IOHHGMOMDMA.UI_data[3].GetComponent<Text>().text = string.Format(JNBICAJIJMM.DIOJFJMOPJO("PrimaryCausticsProjector"), text);
			this.IOHHGMOMDMA.UI_data[7].GetComponent<Text>().text = string.Format(JNBICAJIJMM.LEBHCLDODNI("_MainTex"), dateTime);
			GAMIMGAEFFG.IKGFHGKKCPG.GFOAKEFAGHF(gcoibldnoim, new Action<Texture2D>(this.MMODPAEHGOC));
			UIListBox component = this.IOHHGMOMDMA.UI_data[3].GetComponent<UIListBox>();
			while (!KADBECGIMPD.NLJJMKFBPBK())
			{
				IDCHHHEDHDC.GDEMCACNPNG gdemcacnpng = new IDCHHHEDHDC.GDEMCACNPNG();
				gdemcacnpng.HAGJNPDIIIC(KADBECGIMPD);
				component.CNNKFIDHPMK(gdemcacnpng);
			}
			component.AGDCELDJAKK();
		}
	}

	// Token: 0x04000D25 RID: 3365
	private BaseWindow IOHHGMOMDMA;

	// Token: 0x04000D26 RID: 3366
	private long LIEMOHDFBBL;
}
