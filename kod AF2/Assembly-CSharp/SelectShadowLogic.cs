using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x020001D6 RID: 470
public class SelectShadowLogic : MonoBehaviour
{
	// Token: 0x06006BE8 RID: 27624 RVA: 0x0032E3F1 File Offset: 0x0032C5F1
	public void NMCOBCCLCJI()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LLKDAODBJDA(JNBICAJIJMM.DBMJJPBOPEK().NLJOLOBPCBJ("wpn_add/addoptions"), JNBICAJIJMM.EKEBHIJMEML().ECNKLECOKHD("KatanaReadyLow"), new ONKDCGNBALK.CMMHGMILOIM(this.PDLALGGDDGP), null);
	}

	// Token: 0x06006BE9 RID: 27625 RVA: 0x0032E428 File Offset: 0x0032C628
	private void PMDCDECMOOE()
	{
		this.pinPanel.gameObject.SetActive(true);
		JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(true);
		if (GuiProcessor.IKGFHGKKCPG != null)
		{
			GuiProcessor.BBLINJLBAIL().AMFFCIKGJKJ(this.mainCanvas);
		}
		this.panelNewReg.SetActive(JBEHMPDDMME.PLGADNLAEGN().BJPJPFDOKDL);
		if (JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Count > 0)
		{
			this.panelNewReg.SetActive(true);
		}
	}

	// Token: 0x06006BEA RID: 27626 RVA: 0x0032E4A1 File Offset: 0x0032C6A1
	public void HNGAEHAMAPG(ONKDCGNBALK GACACKNJKJN)
	{
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-27, this.GBGGILOHODG);
		JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(false);
		JDCEFOFMGHB.IKGFHGKKCPG.KCNBOHEMLCI(GACACKNJKJN.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006BEB RID: 27627 RVA: 0x0032E4D5 File Offset: 0x0032C6D5
	public void DNBCDJMBHIN()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("{0} {1} {2} {3}", 116f);
		this.pinPanel.gameObject.SetActive(this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006BEC RID: 27628 RVA: 0x0032E50E File Offset: 0x0032C70E
	public void steamConnectbtnClick()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		this.steamConnectBtn.SetActive(false);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(87, ObscuredString.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.IDAGBNBFHAB));
	}

	// Token: 0x06006BED RID: 27629 RVA: 0x0032E544 File Offset: 0x0032C744
	private void FODDAMMNECI()
	{
		this.BECIMDOBDCL = false;
		bool active = false;
		if (JBEHMPDDMME.NPCAKEGNBHD().KCPPGCGBKGE.Count > 0)
		{
			active = false;
		}
		if (JBEHMPDDMME.PLGADNLAEGN().KKNEKAEJLAM > 1L)
		{
			active = false;
		}
		if (!JBEHMPDDMME.PFOLNEGNIPP().PEKHEALPHLD)
		{
			active = false;
		}
		this.delAccountBtn.SetActive(active);
		SelectShadowLogic.getI = this;
		FBFJFAKAGJG.IKGFHGKKCPG.CPAJNIAMALH();
		this.JHDMMLGIDFO();
		if (JBEHMPDDMME.BPPFAOOCENN() == null)
		{
			return;
		}
		if (JBEHMPDDMME.BOKIOJFHNLD().KCPPGCGBKGE.Count <= 0)
		{
			this.BECIMDOBDCL = true;
		}
		float num = 10f;
		foreach (NEBJANKNJOG nebjanknjog in JBEHMPDDMME.EAJHPOJPPFA().KCPPGCGBKGE.Values)
		{
			SelectShadowLogic.IJHCPFGILKB ijhcpfgilkb = new SelectShadowLogic.IJHCPFGILKB();
			ijhcpfgilkb.AENJLLPLILM = this;
			ijhcpfgilkb.JCGDLKIHBJG = nebjanknjog.LPFKFNLHGBI;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.selShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (!(component == null))
			{
				component.SetParent(this.shadBtnPanel, false);
				component.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 1519f);
				SelShdBtn component2 = gameObject.GetComponent<SelShdBtn>();
				if (component2)
				{
					component2.HEPAANBOKKE(nebjanknjog);
				}
				Button component3 = gameObject.GetComponent<Button>();
				if (component3 != null)
				{
					component3.onClick.AddListener(new UnityAction(ijhcpfgilkb.PMLCKFFKPEA));
				}
				num -= component.rect.height;
			}
		}
		int num2 = 5 - JBEHMPDDMME.NPCAKEGNBHD().KCPPGCGBKGE.Count;
		for (int i = 0; i < num2; i++)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.crShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component4 = gameObject2.GetComponent<RectTransform>();
			if (!(component4 == null))
			{
				component4.SetParent(this.shadBtnPanel, true);
				component4.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 1997f);
				num -= component4.rect.height;
				Button component5 = gameObject2.GetComponent<Button>();
				if (component5 != null)
				{
					component5.onClick.AddListener(new UnityAction(this.BOFCCCNLGFC));
				}
			}
		}
		using (Dictionary<long, NEBJANKNJOG>.ValueCollection.Enumerator enumerator = JBEHMPDDMME.NPCAKEGNBHD().KCPPGCGBKGE.Values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				NEBJANKNJOG nebjanknjog2 = enumerator.Current;
				this.PMJCBNELMAN(nebjanknjog2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x06006BEE RID: 27630 RVA: 0x0032E848 File Offset: 0x0032CA48
	public void LPBLHPMEGHH()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("RunBackward", 121f);
		this.pinPanel.gameObject.SetActive(!this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006BEF RID: 27631 RVA: 0x0032E884 File Offset: 0x0032CA84
	public void LPHECPHKHDH()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("http://www.root-motion.com/finalikdox/html/page5.html", 51f);
		int dnhbpgoklkd = 1;
		try
		{
			dnhbpgoklkd = int.Parse(this.pinInput.text);
		}
		catch (Exception message)
		{
			Debug.Log(message);
		}
		NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(88, dnhbpgoklkd);
		this.pinPanel.gameObject.SetActive(false);
		FlyMessageManager.getI.MEIICCGKONL(JNBICAJIJMM.PGJCPFNJNPM("sunshine_Lightmap"), Color.green, 0, 0);
	}

	// Token: 0x06006BF0 RID: 27632 RVA: 0x0032E90C File Offset: 0x0032CB0C
	public void FMNKNEDDNDF(long LPFKFNLHGBI)
	{
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.PFOLNEGNIPP().OKFPEMCFMKN(LPFKFNLHGBI);
		if (nebjanknjog == null)
		{
			return;
		}
		this.selectShadId = LPFKFNLHGBI;
		JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH = nebjanknjog;
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.clips[0], 1103f);
		if (nebjanknjog.GDJMBFGEMFJ == 1)
		{
			this.manModel.KJILAGBDDGA(nebjanknjog.GFLKLJPFLEA);
			this.manModel.gameObject.SetActive(false);
			this.womanModel.gameObject.SetActive(false);
			this.manModel.AAHMAEIAJML(nebjanknjog.LLKDOMIDPNM);
			return;
		}
		this.womanModel.CBEBJEKBDCO(nebjanknjog.GFLKLJPFLEA);
		this.manModel.gameObject.SetActive(true);
		this.womanModel.gameObject.SetActive(true);
		this.womanModel.GMBMDKOIBNP(nebjanknjog.LLKDOMIDPNM);
	}

	// Token: 0x06006BF1 RID: 27633 RVA: 0x0032E9E4 File Offset: 0x0032CBE4
	private void BBEIKJGNAAA()
	{
		this.pinPanel.gameObject.SetActive(false);
		JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = true;
		if (GuiProcessor.BBLINJLBAIL() != null)
		{
			GuiProcessor.IKGFHGKKCPG.FJLPFLCJMPE(this.mainCanvas);
		}
		this.panelNewReg.SetActive(JBEHMPDDMME.JKIFIBEPICO().BJPJPFDOKDL);
		if (JBEHMPDDMME.EAJHPOJPPFA().KCPPGCGBKGE.Count > 0)
		{
			this.panelNewReg.SetActive(false);
		}
	}

	// Token: 0x06006BF2 RID: 27634 RVA: 0x0032EA60 File Offset: 0x0032CC60
	public void DBKGJCHBILD()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("fshop_ks1", 1095f);
		int dnhbpgoklkd = 0;
		try
		{
			dnhbpgoklkd = int.Parse(this.pinInput.text);
		}
		catch (Exception message)
		{
			Debug.Log(message);
		}
		NJMHLCGIAJI.IKGFHGKKCPG.PIGIIJLCADJ(53, dnhbpgoklkd);
		this.pinPanel.gameObject.SetActive(false);
		FlyMessageManager.getI.JBBCOOMCOII(JNBICAJIJMM.DIOJFJMOPJO(""), Color.green, 0, 1);
	}

	// Token: 0x06006BF3 RID: 27635 RVA: 0x0032EAE8 File Offset: 0x0032CCE8
	public void CLCBCIDGNAO(long LPFKFNLHGBI)
	{
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.PFOLNEGNIPP().FGKLBBPAMHP(LPFKFNLHGBI);
		if (nebjanknjog == null)
		{
			return;
		}
		this.selectShadId = LPFKFNLHGBI;
		JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH = nebjanknjog;
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clips[0], 876f);
		if (nebjanknjog.GDJMBFGEMFJ == 1)
		{
			this.manModel.HCBMGCJMCBG(nebjanknjog.GFLKLJPFLEA);
			this.manModel.gameObject.SetActive(true);
			this.womanModel.gameObject.SetActive(true);
			this.manModel.EHEBKBBAMFN(nebjanknjog.LLKDOMIDPNM);
			return;
		}
		this.womanModel.EJGLDLFLLPG(nebjanknjog.GFLKLJPFLEA);
		this.manModel.gameObject.SetActive(false);
		this.womanModel.gameObject.SetActive(true);
		this.womanModel.KFHJEMOJAHM(nebjanknjog.LLKDOMIDPNM);
	}

	// Token: 0x06006BF4 RID: 27636 RVA: 0x0032EBC0 File Offset: 0x0032CDC0
	public void EHCMGAJLHKK()
	{
		if (!SteamManager.HFCCLHMGOKA())
		{
			this.steamConnectBtn.SetActive(true);
			this.toGameKey.SetActive(false);
			return;
		}
		if (ObscuredString.BAKPLODMMOJ(JBEHMPDDMME.NPCAKEGNBHD().AMJCBLPKNCB, ObscuredString.EMFOKHGIMFM("DepthCamera")))
		{
			this.steamConnectBtn.SetActive(false);
			this.toGameKey.SetActive(false);
			return;
		}
		this.toGameKey.SetActive(true);
		this.steamConnectBtn.SetActive(true);
	}

	// Token: 0x06006BF5 RID: 27637 RVA: 0x0032EC3C File Offset: 0x0032CE3C
	public void FOALNLOLEGD()
	{
		if (!SteamManager.PJMKPOFDGCK())
		{
			this.steamConnectBtn.SetActive(false);
			this.toGameKey.SetActive(false);
			return;
		}
		if (ObscuredString.BAKPLODMMOJ(JBEHMPDDMME.BOKIOJFHNLD().AMJCBLPKNCB, ObscuredString.GOOIABGKMHK("wpn_break")))
		{
			this.steamConnectBtn.SetActive(true);
			this.toGameKey.SetActive(true);
			return;
		}
		this.toGameKey.SetActive(true);
		this.steamConnectBtn.SetActive(false);
	}

	// Token: 0x06006BF6 RID: 27638 RVA: 0x0032ECB5 File Offset: 0x0032CEB5
	private void JPOOAFAAGAN(ONKDCGNBALK ONPHLHKAGFP)
	{
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(126, JBEHMPDDMME.PFOLNEGNIPP().LPFKFNLHGBI);
		JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = false;
		JDCEFOFMGHB.JFIDAGABKID().DGFAPDDBHJB(ONPHLHKAGFP.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006BF7 RID: 27639 RVA: 0x0032ECED File Offset: 0x0032CEED
	public void HJCCMLLMNMF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("\n", 1659f);
		this.pinPanel.gameObject.SetActive(!this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006BF8 RID: 27640 RVA: 0x0032ED28 File Offset: 0x0032CF28
	private void LBKPJAJJLBH()
	{
		this.pinPanel.gameObject.SetActive(true);
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
		if (GuiProcessor.PLGADNLAEGN() != null)
		{
			GuiProcessor.BBLINJLBAIL().CGKGBPLODOJ(this.mainCanvas);
		}
		this.panelNewReg.SetActive(JBEHMPDDMME.PFOLNEGNIPP().BJPJPFDOKDL);
		if (JBEHMPDDMME.BPPFAOOCENN().KCPPGCGBKGE.Count > 1)
		{
			this.panelNewReg.SetActive(false);
		}
	}

	// Token: 0x06006BF9 RID: 27641 RVA: 0x0032EDA1 File Offset: 0x0032CFA1
	public void FNCNICPGFEF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.clips[0], 608f);
		JDCEFOFMGHB.MNJNNDHCDGG().DDAIBFBOENE();
		SceneManager.LoadScene(2);
	}

	// Token: 0x06006BFA RID: 27642 RVA: 0x0032EDCA File Offset: 0x0032CFCA
	public void BDGMMOGIHIP(ONKDCGNBALK GACACKNJKJN)
	{
		NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(-110, this.GBGGILOHODG);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		JDCEFOFMGHB.IKGFHGKKCPG.DGFAPDDBHJB(GACACKNJKJN.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006BFB RID: 27643 RVA: 0x0032EDFE File Offset: 0x0032CFFE
	public void DCLLNCELHNC()
	{
		JDCEFOFMGHB.JFIDAGABKID().LLKDAODBJDA(JNBICAJIJMM.APMJBBDBOJO().HLBAJBLHLNI("5"), JNBICAJIJMM.IMLLGEMPHAP().FLEANFGEJML("SuicideHeadShot"), new ONKDCGNBALK.CMMHGMILOIM(this.OFGGEIGJNOF), null);
	}

	// Token: 0x06006BFC RID: 27644 RVA: 0x0032EE35 File Offset: 0x0032D035
	public void GABPEJIMBMI()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.CLADNJHAABI(JNBICAJIJMM.IMLLGEMPHAP().CCFFMKBBKHI("MotorbikeIdle"), JNBICAJIJMM.EKEBHIJMEML().CKAOHMEKLMH("OnTriggerExit"), new ONKDCGNBALK.CMMHGMILOIM(this.KDOGDBFJHFA), null);
	}

	// Token: 0x06006BFD RID: 27645 RVA: 0x0032EE6C File Offset: 0x0032D06C
	public void DFKAAKIHIKB()
	{
		if (this.selectShadId <= 1L)
		{
			return;
		}
		Debug.Log("ArmFlex6");
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.BOKIOJFHNLD().JPFCACJPHGP(this.selectShadId);
		if (nebjanknjog == null)
		{
			return;
		}
		this.GBGGILOHODG = nebjanknjog.LPFKFNLHGBI;
		JDCEFOFMGHB.JFIDAGABKID().LLKDAODBJDA(JNBICAJIJMM.NGALDMFKMJH("Shotgun Fire"), string.Format(JNBICAJIJMM.NGALDMFKMJH("IceHockeyIdle"), nebjanknjog.BNIHFBMEPAB), new ONKDCGNBALK.CMMHGMILOIM(this.ELIFCAOENNK), null);
	}

	// Token: 0x06006BFE RID: 27646 RVA: 0x0032EEE8 File Offset: 0x0032D0E8
	public void DCNJMIPGMEK(long LPFKFNLHGBI)
	{
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.PLGADNLAEGN().POJIJIMHFHF(LPFKFNLHGBI);
		if (nebjanknjog == null)
		{
			return;
		}
		this.selectShadId = LPFKFNLHGBI;
		JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH = nebjanknjog;
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.clips[0], 1533f);
		if (nebjanknjog.GDJMBFGEMFJ == 1)
		{
			this.manModel.HCBMGCJMCBG(nebjanknjog.GFLKLJPFLEA);
			this.manModel.gameObject.SetActive(true);
			this.womanModel.gameObject.SetActive(false);
			this.manModel.ENABOACEALG(nebjanknjog.LLKDOMIDPNM);
			return;
		}
		this.womanModel.HCBMGCJMCBG(nebjanknjog.GFLKLJPFLEA);
		this.manModel.gameObject.SetActive(false);
		this.womanModel.gameObject.SetActive(false);
		this.womanModel.KHJMJMGFCME(nebjanknjog.LLKDOMIDPNM);
	}

	// Token: 0x06006BFF RID: 27647 RVA: 0x0032EFC0 File Offset: 0x0032D1C0
	public void LMOCAIMBGME()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clips[1], 564f);
		JDCEFOFMGHB.HMJJPNDEKPP().LCEOGOCIMMB();
		SceneManager.LoadScene(6);
	}

	// Token: 0x06006C00 RID: 27648 RVA: 0x0032EFEC File Offset: 0x0032D1EC
	public void ODNJKAJGJNO()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_Intensity", 11f);
		int dnhbpgoklkd = 0;
		try
		{
			dnhbpgoklkd = int.Parse(this.pinInput.text);
		}
		catch (Exception message)
		{
			Debug.Log(message);
		}
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(-124, dnhbpgoklkd);
		this.pinPanel.gameObject.SetActive(true);
		FlyMessageManager.getI.IDCGMMOMKPM(JNBICAJIJMM.DIOJFJMOPJO(""), Color.green, 1, 0);
	}

	// Token: 0x06006C01 RID: 27649 RVA: 0x0032F074 File Offset: 0x0032D274
	public void EIHKGEOPJDF(long LPFKFNLHGBI)
	{
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.PLGADNLAEGN().BALFGEEFKFK(LPFKFNLHGBI);
		if (nebjanknjog == null)
		{
			return;
		}
		this.selectShadId = LPFKFNLHGBI;
		JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH = nebjanknjog;
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.clips[1], 1429f);
		if (nebjanknjog.GDJMBFGEMFJ == 0)
		{
			this.manModel.CLMJPJEEEFI(nebjanknjog.GFLKLJPFLEA);
			this.manModel.gameObject.SetActive(false);
			this.womanModel.gameObject.SetActive(false);
			this.manModel.OHOGDOLLGAM(nebjanknjog.LLKDOMIDPNM);
			return;
		}
		this.womanModel.COMCNHFBFHL(nebjanknjog.GFLKLJPFLEA);
		this.manModel.gameObject.SetActive(true);
		this.womanModel.gameObject.SetActive(true);
		this.womanModel.changeCostume(nebjanknjog.LLKDOMIDPNM);
	}

	// Token: 0x06006C02 RID: 27650 RVA: 0x0032F14C File Offset: 0x0032D34C
	public void DJOHNEIDECL()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA(" has been disabled as it's not supported on the current platform.", 1662f);
		this.pinPanel.gameObject.SetActive(this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006C03 RID: 27651 RVA: 0x0032F185 File Offset: 0x0032D385
	public void createShadow()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clips[0], 1f);
		JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
		SceneManager.LoadScene(2);
	}

	// Token: 0x06006C04 RID: 27652 RVA: 0x0032F1B0 File Offset: 0x0032D3B0
	public void setPinOk()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_TrStartYou.ogg", 1f);
		int dnhbpgoklkd = 0;
		try
		{
			dnhbpgoklkd = int.Parse(this.pinInput.text);
		}
		catch (Exception message)
		{
			Debug.Log(message);
		}
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(92, dnhbpgoklkd);
		this.pinPanel.gameObject.SetActive(false);
		FlyMessageManager.getI.addMessageBig(JNBICAJIJMM.LEBHCLDODNI("pt_setok"), Color.green, 0, 0);
	}

	// Token: 0x06006C05 RID: 27653 RVA: 0x0032F238 File Offset: 0x0032D438
	public void PPOLGNFBGCB()
	{
		if (!SteamManager.FHGDEIGKKIE())
		{
			this.steamConnectBtn.SetActive(true);
			this.toGameKey.SetActive(true);
			return;
		}
		if (ObscuredString.FIMEAOKHJBF(JBEHMPDDMME.EAJHPOJPPFA().AMJCBLPKNCB, ObscuredString.DGOCFCFPKPI("DeadmanFloat")))
		{
			this.steamConnectBtn.SetActive(false);
			this.toGameKey.SetActive(true);
			return;
		}
		this.toGameKey.SetActive(true);
		this.steamConnectBtn.SetActive(false);
	}

	// Token: 0x06006C06 RID: 27654 RVA: 0x0032F2B1 File Offset: 0x0032D4B1
	public void FBPIFIFDNDD()
	{
		if (this.selectShadId > 0L)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.clips[0], 38f);
			JDCEFOFMGHB.HMJJPNDEKPP().DDAIBFBOENE();
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-49, this.selectShadId);
		}
	}

	// Token: 0x06006C07 RID: 27655 RVA: 0x0032F2F0 File Offset: 0x0032D4F0
	private void CKIGGCAHAFD()
	{
		this.BECIMDOBDCL = false;
		bool active = false;
		if (JBEHMPDDMME.PLGADNLAEGN().KCPPGCGBKGE.Count > 0)
		{
			active = true;
		}
		if (JBEHMPDDMME.PFOLNEGNIPP().KKNEKAEJLAM > 1L)
		{
			active = false;
		}
		if (!JBEHMPDDMME.BOKIOJFHNLD().PEKHEALPHLD)
		{
			active = false;
		}
		this.delAccountBtn.SetActive(active);
		SelectShadowLogic.getI = this;
		FBFJFAKAGJG.IKGFHGKKCPG.JIOAMAPJOFA();
		this.checkPriv();
		if (JBEHMPDDMME.BOKIOJFHNLD() == null)
		{
			return;
		}
		if (JBEHMPDDMME.PFOLNEGNIPP().KCPPGCGBKGE.Count <= 0)
		{
			this.BECIMDOBDCL = false;
		}
		float num = 527f;
		foreach (NEBJANKNJOG nebjanknjog in JBEHMPDDMME.BPPFAOOCENN().KCPPGCGBKGE.Values)
		{
			SelectShadowLogic.IJHCPFGILKB ijhcpfgilkb = new SelectShadowLogic.IJHCPFGILKB();
			ijhcpfgilkb.AENJLLPLILM = this;
			ijhcpfgilkb.JCGDLKIHBJG = nebjanknjog.LPFKFNLHGBI;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.selShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (!(component == null))
			{
				component.SetParent(this.shadBtnPanel, true);
				component.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 1232f);
				SelShdBtn component2 = gameObject.GetComponent<SelShdBtn>();
				if (component2)
				{
					component2.DKKIEEHMGGO(nebjanknjog);
				}
				Button component3 = gameObject.GetComponent<Button>();
				if (component3 != null)
				{
					component3.onClick.AddListener(new UnityAction(ijhcpfgilkb.BFMHBLFIBNE));
				}
				num -= component.rect.height;
			}
		}
		int num2 = 2 - JBEHMPDDMME.NPCAKEGNBHD().KCPPGCGBKGE.Count;
		for (int i = 0; i < num2; i++)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.crShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component4 = gameObject2.GetComponent<RectTransform>();
			if (!(component4 == null))
			{
				component4.SetParent(this.shadBtnPanel, true);
				component4.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 1808f);
				num -= component4.rect.height;
				Button component5 = gameObject2.GetComponent<Button>();
				if (component5 != null)
				{
					component5.onClick.AddListener(new UnityAction(this.createShadow));
				}
			}
		}
		using (Dictionary<long, NEBJANKNJOG>.ValueCollection.Enumerator enumerator = JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				NEBJANKNJOG nebjanknjog2 = enumerator.Current;
				this.FMNKNEDDNDF(nebjanknjog2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x06006C08 RID: 27656 RVA: 0x0032F5F4 File Offset: 0x0032D7F4
	private void EDGALMCHPPH()
	{
		this.BECIMDOBDCL = true;
		bool active = true;
		if (JBEHMPDDMME.BOKIOJFHNLD().KCPPGCGBKGE.Count > 0)
		{
			active = true;
		}
		if (JBEHMPDDMME.PFOLNEGNIPP().KKNEKAEJLAM > 0L)
		{
			active = false;
		}
		if (!JBEHMPDDMME.JKIFIBEPICO().PEKHEALPHLD)
		{
			active = true;
		}
		this.delAccountBtn.SetActive(active);
		SelectShadowLogic.getI = this;
		FBFJFAKAGJG.IKGFHGKKCPG.MHMEMCADNHA();
		this.EHCMGAJLHKK();
		if (JBEHMPDDMME.EAJHPOJPPFA() == null)
		{
			return;
		}
		if (JBEHMPDDMME.BOKIOJFHNLD().KCPPGCGBKGE.Count <= 0)
		{
			this.BECIMDOBDCL = true;
		}
		float num = 824f;
		foreach (NEBJANKNJOG nebjanknjog in JBEHMPDDMME.BPPFAOOCENN().KCPPGCGBKGE.Values)
		{
			SelectShadowLogic.IJHCPFGILKB ijhcpfgilkb = new SelectShadowLogic.IJHCPFGILKB();
			ijhcpfgilkb.AENJLLPLILM = this;
			ijhcpfgilkb.JCGDLKIHBJG = nebjanknjog.LPFKFNLHGBI;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.selShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (!(component == null))
			{
				component.SetParent(this.shadBtnPanel, false);
				component.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 318f);
				SelShdBtn component2 = gameObject.GetComponent<SelShdBtn>();
				if (component2)
				{
					component2.MCMALHNDCLF(nebjanknjog);
				}
				Button component3 = gameObject.GetComponent<Button>();
				if (component3 != null)
				{
					component3.onClick.AddListener(new UnityAction(ijhcpfgilkb.ACCGNEHPOGM));
				}
				num -= component.rect.height;
			}
		}
		int num2 = 3 - JBEHMPDDMME.PFOLNEGNIPP().KCPPGCGBKGE.Count;
		for (int i = 0; i < num2; i += 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.crShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component4 = gameObject2.GetComponent<RectTransform>();
			if (!(component4 == null))
			{
				component4.SetParent(this.shadBtnPanel, true);
				component4.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 135f);
				num -= component4.rect.height;
				Button component5 = gameObject2.GetComponent<Button>();
				if (component5 != null)
				{
					component5.onClick.AddListener(new UnityAction(this.POOPDJOGOHJ));
				}
			}
		}
		using (Dictionary<long, NEBJANKNJOG>.ValueCollection.Enumerator enumerator = JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				NEBJANKNJOG nebjanknjog2 = enumerator.Current;
				this.selectShadowClick(nebjanknjog2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x06006C09 RID: 27657 RVA: 0x0032F8F8 File Offset: 0x0032DAF8
	public void CKPDOLNIBNE()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.clips[0], 181f);
		JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
		SceneManager.LoadScene(8);
	}

	// Token: 0x06006C0A RID: 27658 RVA: 0x0032F924 File Offset: 0x0032DB24
	private void JCMBBMFDBAI()
	{
		this.pinPanel.gameObject.SetActive(false);
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = true;
		if (GuiProcessor.PLGADNLAEGN() != null)
		{
			GuiProcessor.NKOEAPCIBKO().EOPEPOJNLNF(this.mainCanvas);
		}
		this.panelNewReg.SetActive(JBEHMPDDMME.PFOLNEGNIPP().BJPJPFDOKDL);
		if (JBEHMPDDMME.PFOLNEGNIPP().KCPPGCGBKGE.Count > 0)
		{
			this.panelNewReg.SetActive(true);
		}
	}

	// Token: 0x06006C0B RID: 27659 RVA: 0x0032F9A0 File Offset: 0x0032DBA0
	public void JHDMMLGIDFO()
	{
		if (!SteamManager.JBKCBLGNLLG())
		{
			this.steamConnectBtn.SetActive(false);
			this.toGameKey.SetActive(true);
			return;
		}
		if (ObscuredString.PGPAOADJOLC(JBEHMPDDMME.PFOLNEGNIPP().AMJCBLPKNCB, ObscuredString.LMCJCHPGIJK("Empty Array.")))
		{
			this.steamConnectBtn.SetActive(true);
			this.toGameKey.SetActive(false);
			return;
		}
		this.toGameKey.SetActive(false);
		this.steamConnectBtn.SetActive(false);
	}

	// Token: 0x06006C0C RID: 27660 RVA: 0x0032FA19 File Offset: 0x0032DC19
	public void JEEDKHEFCFB(ONKDCGNBALK GACACKNJKJN)
	{
		NJMHLCGIAJI.IKGFHGKKCPG.MADKBBLOPGO(-44, this.GBGGILOHODG);
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = false;
		JDCEFOFMGHB.JFIDAGABKID().BMOFIBGMIBK(GACACKNJKJN.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C0D RID: 27661 RVA: 0x0032FA4D File Offset: 0x0032DC4D
	public void BBLHDLDFBBC()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.clips[0], 1223f);
		JDCEFOFMGHB.IKGFHGKKCPG.LCEOGOCIMMB();
		SceneManager.LoadScene(7);
	}

	// Token: 0x06006C0E RID: 27662 RVA: 0x0032FA78 File Offset: 0x0032DC78
	public void PCAFJKKMJJL(long LPFKFNLHGBI)
	{
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.PFOLNEGNIPP().JPFCACJPHGP(LPFKFNLHGBI);
		if (nebjanknjog == null)
		{
			return;
		}
		this.selectShadId = LPFKFNLHGBI;
		JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH = nebjanknjog;
		FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(this.clips[1], 1658f);
		if (nebjanknjog.GDJMBFGEMFJ == 1)
		{
			this.manModel.HCBMGCJMCBG(nebjanknjog.GFLKLJPFLEA);
			this.manModel.gameObject.SetActive(true);
			this.womanModel.gameObject.SetActive(false);
			this.manModel.BECOOJFPBEP(nebjanknjog.LLKDOMIDPNM);
			return;
		}
		this.womanModel.HCBMGCJMCBG(nebjanknjog.GFLKLJPFLEA);
		this.manModel.gameObject.SetActive(true);
		this.womanModel.gameObject.SetActive(false);
		this.womanModel.OHOGDOLLGAM(nebjanknjog.LLKDOMIDPNM);
	}

	// Token: 0x06006C0F RID: 27663 RVA: 0x0032FB50 File Offset: 0x0032DD50
	private void ACLJDJBJLCD()
	{
		this.BECIMDOBDCL = false;
		bool active = false;
		if (JBEHMPDDMME.EAJHPOJPPFA().KCPPGCGBKGE.Count > 0)
		{
			active = false;
		}
		if (JBEHMPDDMME.EAJHPOJPPFA().KKNEKAEJLAM > 0L)
		{
			active = true;
		}
		if (!JBEHMPDDMME.EAJHPOJPPFA().PEKHEALPHLD)
		{
			active = true;
		}
		this.delAccountBtn.SetActive(active);
		SelectShadowLogic.getI = this;
		FBFJFAKAGJG.IKGFHGKKCPG.JIOAMAPJOFA();
		this.KHLJCFCCPKF();
		if (JBEHMPDDMME.BOKIOJFHNLD() == null)
		{
			return;
		}
		if (JBEHMPDDMME.EAJHPOJPPFA().KCPPGCGBKGE.Count <= 0)
		{
			this.BECIMDOBDCL = false;
		}
		float num = 1515f;
		foreach (NEBJANKNJOG nebjanknjog in JBEHMPDDMME.NPCAKEGNBHD().KCPPGCGBKGE.Values)
		{
			SelectShadowLogic.IJHCPFGILKB ijhcpfgilkb = new SelectShadowLogic.IJHCPFGILKB();
			ijhcpfgilkb.AENJLLPLILM = this;
			ijhcpfgilkb.JCGDLKIHBJG = nebjanknjog.LPFKFNLHGBI;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.selShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (!(component == null))
			{
				component.SetParent(this.shadBtnPanel, false);
				component.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 1587f);
				SelShdBtn component2 = gameObject.GetComponent<SelShdBtn>();
				if (component2)
				{
					component2.MCMALHNDCLF(nebjanknjog);
				}
				Button component3 = gameObject.GetComponent<Button>();
				if (component3 != null)
				{
					component3.onClick.AddListener(new UnityAction(ijhcpfgilkb.ALIGDDBICIH));
				}
				num -= component.rect.height;
			}
		}
		int num2 = 1 - JBEHMPDDMME.BOKIOJFHNLD().KCPPGCGBKGE.Count;
		for (int i = 1; i < num2; i += 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.crShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component4 = gameObject2.GetComponent<RectTransform>();
			if (!(component4 == null))
			{
				component4.SetParent(this.shadBtnPanel, false);
				component4.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 917f);
				num -= component4.rect.height;
				Button component5 = gameObject2.GetComponent<Button>();
				if (component5 != null)
				{
					component5.onClick.AddListener(new UnityAction(this.GFKCMDOLJJA));
				}
			}
		}
		using (Dictionary<long, NEBJANKNJOG>.ValueCollection.Enumerator enumerator = JBEHMPDDMME.BPPFAOOCENN().KCPPGCGBKGE.Values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				NEBJANKNJOG nebjanknjog2 = enumerator.Current;
				this.ALAGLEOAAHN(nebjanknjog2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x06006C10 RID: 27664 RVA: 0x0032FE54 File Offset: 0x0032E054
	public void KBCJECFLAHN()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("-", 925f);
		this.pinPanel.gameObject.SetActive(!this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006C11 RID: 27665 RVA: 0x0032FE90 File Offset: 0x0032E090
	private void LPNDCJKAKEA()
	{
		this.BECIMDOBDCL = true;
		bool active = false;
		if (JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Count > 1)
		{
			active = true;
		}
		if (JBEHMPDDMME.PFOLNEGNIPP().KKNEKAEJLAM > 0L)
		{
			active = false;
		}
		if (!JBEHMPDDMME.NPCAKEGNBHD().PEKHEALPHLD)
		{
			active = false;
		}
		this.delAccountBtn.SetActive(active);
		SelectShadowLogic.getI = this;
		FBFJFAKAGJG.IKGFHGKKCPG.AJEIKIOHFOJ();
		this.BECGNAEFABE();
		if (JBEHMPDDMME.JKIFIBEPICO() == null)
		{
			return;
		}
		if (JBEHMPDDMME.BPPFAOOCENN().KCPPGCGBKGE.Count <= 0)
		{
			this.BECIMDOBDCL = false;
		}
		float num = 110f;
		foreach (NEBJANKNJOG nebjanknjog in JBEHMPDDMME.JKIFIBEPICO().KCPPGCGBKGE.Values)
		{
			SelectShadowLogic.IJHCPFGILKB ijhcpfgilkb = new SelectShadowLogic.IJHCPFGILKB();
			ijhcpfgilkb.AENJLLPLILM = this;
			ijhcpfgilkb.JCGDLKIHBJG = nebjanknjog.LPFKFNLHGBI;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.selShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (!(component == null))
			{
				component.SetParent(this.shadBtnPanel, false);
				component.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 1257f);
				SelShdBtn component2 = gameObject.GetComponent<SelShdBtn>();
				if (component2)
				{
					component2.setData(nebjanknjog);
				}
				Button component3 = gameObject.GetComponent<Button>();
				if (component3 != null)
				{
					component3.onClick.AddListener(new UnityAction(ijhcpfgilkb.APKDGPDDJFK));
				}
				num -= component.rect.height;
			}
		}
		int num2 = 7 - JBEHMPDDMME.EAJHPOJPPFA().KCPPGCGBKGE.Count;
		for (int i = 0; i < num2; i++)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.crShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component4 = gameObject2.GetComponent<RectTransform>();
			if (!(component4 == null))
			{
				component4.SetParent(this.shadBtnPanel, true);
				component4.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 615f);
				num -= component4.rect.height;
				Button component5 = gameObject2.GetComponent<Button>();
				if (component5 != null)
				{
					component5.onClick.AddListener(new UnityAction(this.BOFCCCNLGFC));
				}
			}
		}
		using (Dictionary<long, NEBJANKNJOG>.ValueCollection.Enumerator enumerator = JBEHMPDDMME.EAJHPOJPPFA().KCPPGCGBKGE.Values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				NEBJANKNJOG nebjanknjog2 = enumerator.Current;
				this.DCNJMIPGMEK(nebjanknjog2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x06006C12 RID: 27666 RVA: 0x00330194 File Offset: 0x0032E394
	public void GDBLHBIBHPI()
	{
		if (!SteamManager.HFCCLHMGOKA())
		{
			this.steamConnectBtn.SetActive(true);
			this.toGameKey.SetActive(true);
			return;
		}
		if (ObscuredString.BAKPLODMMOJ(JBEHMPDDMME.JKIFIBEPICO().AMJCBLPKNCB, ObscuredString.EMFOKHGIMFM("isNoShowChat")))
		{
			this.steamConnectBtn.SetActive(false);
			this.toGameKey.SetActive(true);
			return;
		}
		this.toGameKey.SetActive(false);
		this.steamConnectBtn.SetActive(true);
	}

	// Token: 0x06006C13 RID: 27667 RVA: 0x0033020D File Offset: 0x0032E40D
	public void ILKMDICEHNK()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA(" ", 82f);
		this.pinPanel.gameObject.SetActive(!this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006C14 RID: 27668 RVA: 0x00330248 File Offset: 0x0032E448
	public void BAMAFGHDIDL()
	{
		if (!SteamManager.FNNHOLIBGJH())
		{
			this.steamConnectBtn.SetActive(true);
			this.toGameKey.SetActive(false);
			return;
		}
		if (ObscuredString.BLDHBEPMKBN(JBEHMPDDMME.BOKIOJFHNLD().AMJCBLPKNCB, ObscuredString.GOOIABGKMHK("PistolLeftHandStab")))
		{
			this.steamConnectBtn.SetActive(true);
			this.toGameKey.SetActive(false);
			return;
		}
		this.toGameKey.SetActive(true);
		this.steamConnectBtn.SetActive(true);
	}

	// Token: 0x06006C15 RID: 27669 RVA: 0x003302C1 File Offset: 0x0032E4C1
	public void delShadowOk(ONKDCGNBALK GACACKNJKJN)
	{
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(125, this.GBGGILOHODG);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(GACACKNJKJN.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C16 RID: 27670 RVA: 0x003302F5 File Offset: 0x0032E4F5
	public void KHECAHKOPNN(ONKDCGNBALK GACACKNJKJN)
	{
		NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(-81, this.GBGGILOHODG);
		JDCEFOFMGHB.HMJJPNDEKPP().LHHBOOJPBPH = false;
		JDCEFOFMGHB.MNJNNDHCDGG().KCNBOHEMLCI(GACACKNJKJN.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C17 RID: 27671 RVA: 0x00330329 File Offset: 0x0032E529
	public void NDBLNCBOCPL(ONKDCGNBALK GACACKNJKJN)
	{
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(97, this.GBGGILOHODG);
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(false);
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(GACACKNJKJN.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C18 RID: 27672 RVA: 0x0033035D File Offset: 0x0032E55D
	private void DOJNNHDFEGF(ONKDCGNBALK ONPHLHKAGFP)
	{
		NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(107, JBEHMPDDMME.PFOLNEGNIPP().LPFKFNLHGBI);
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
		JDCEFOFMGHB.JFIDAGABKID().BMOFIBGMIBK(ONPHLHKAGFP.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C19 RID: 27673 RVA: 0x00330395 File Offset: 0x0032E595
	public void IILLCCPGLKG()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(true);
		this.steamConnectBtn.SetActive(true);
		NJMHLCGIAJI.IKGFHGKKCPG.GDNKCAOHEPL(28, ObscuredString.CKPPDHPJHEH(JBEHMPDDMME.EAJHPOJPPFA().IDAGBNBFHAB));
	}

	// Token: 0x06006C1A RID: 27674 RVA: 0x003303C9 File Offset: 0x0032E5C9
	private void ILPDJKAMNOD(ONKDCGNBALK ONPHLHKAGFP)
	{
		NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(121, JBEHMPDDMME.IKGFHGKKCPG.LPFKFNLHGBI);
		JDCEFOFMGHB.IKGFHGKKCPG.MDBKHKBJNAO(false);
		JDCEFOFMGHB.HMJJPNDEKPP().DGFAPDDBHJB(ONPHLHKAGFP.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C1B RID: 27675 RVA: 0x00330401 File Offset: 0x0032E601
	private void PDLALGGDDGP(ONKDCGNBALK ONPHLHKAGFP)
	{
		NJMHLCGIAJI.IKGFHGKKCPG.MADKBBLOPGO(-33, JBEHMPDDMME.EAJHPOJPPFA().LPFKFNLHGBI);
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = false;
		JDCEFOFMGHB.MNJNNDHCDGG().BMOFIBGMIBK(ONPHLHKAGFP.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C1C RID: 27676 RVA: 0x00330439 File Offset: 0x0032E639
	public void BKIACLBPCEH(ONKDCGNBALK GACACKNJKJN)
	{
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(69, this.GBGGILOHODG);
		JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(false);
		JDCEFOFMGHB.JFIDAGABKID().CBHHEHHNFKL(GACACKNJKJN.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C1D RID: 27677 RVA: 0x0033046D File Offset: 0x0032E66D
	public void PNBMPHJMGCN()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("cht_msg29", 175f);
		this.pinPanel.gameObject.SetActive(this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006C1E RID: 27678 RVA: 0x003304A8 File Offset: 0x0032E6A8
	private void FDBNPLCPFJB()
	{
		this.BECIMDOBDCL = true;
		bool active = true;
		if (JBEHMPDDMME.NPCAKEGNBHD().KCPPGCGBKGE.Count > 1)
		{
			active = true;
		}
		if (JBEHMPDDMME.PLGADNLAEGN().KKNEKAEJLAM > 1L)
		{
			active = true;
		}
		if (!JBEHMPDDMME.PFOLNEGNIPP().PEKHEALPHLD)
		{
			active = true;
		}
		this.delAccountBtn.SetActive(active);
		SelectShadowLogic.getI = this;
		FBFJFAKAGJG.IKGFHGKKCPG.LOAGNOGBOAN();
		this.KHLJCFCCPKF();
		if (JBEHMPDDMME.JKIFIBEPICO() == null)
		{
			return;
		}
		if (JBEHMPDDMME.NPCAKEGNBHD().KCPPGCGBKGE.Count <= 1)
		{
			this.BECIMDOBDCL = true;
		}
		float num = 1832f;
		foreach (NEBJANKNJOG nebjanknjog in JBEHMPDDMME.EAJHPOJPPFA().KCPPGCGBKGE.Values)
		{
			SelectShadowLogic.IJHCPFGILKB ijhcpfgilkb = new SelectShadowLogic.IJHCPFGILKB();
			ijhcpfgilkb.AENJLLPLILM = this;
			ijhcpfgilkb.JCGDLKIHBJG = nebjanknjog.LPFKFNLHGBI;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.selShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (!(component == null))
			{
				component.SetParent(this.shadBtnPanel, false);
				component.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 516f);
				SelShdBtn component2 = gameObject.GetComponent<SelShdBtn>();
				if (component2)
				{
					component2.setData(nebjanknjog);
				}
				Button component3 = gameObject.GetComponent<Button>();
				if (component3 != null)
				{
					component3.onClick.AddListener(new UnityAction(ijhcpfgilkb.ACNOKCPPPKH));
				}
				num -= component.rect.height;
			}
		}
		int num2 = 4 - JBEHMPDDMME.BPPFAOOCENN().KCPPGCGBKGE.Count;
		for (int i = 0; i < num2; i++)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.crShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component4 = gameObject2.GetComponent<RectTransform>();
			if (!(component4 == null))
			{
				component4.SetParent(this.shadBtnPanel, false);
				component4.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 119f);
				num -= component4.rect.height;
				Button component5 = gameObject2.GetComponent<Button>();
				if (component5 != null)
				{
					component5.onClick.AddListener(new UnityAction(this.JJJOCBBHPJD));
				}
			}
		}
		using (Dictionary<long, NEBJANKNJOG>.ValueCollection.Enumerator enumerator = JBEHMPDDMME.PFOLNEGNIPP().KCPPGCGBKGE.Values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				NEBJANKNJOG nebjanknjog2 = enumerator.Current;
				this.PCAFJKKMJJL(nebjanknjog2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x06006C1F RID: 27679 RVA: 0x003307AC File Offset: 0x0032E9AC
	private void MAAIHPANJPN(ONKDCGNBALK ONPHLHKAGFP)
	{
		NJMHLCGIAJI.IKGFHGKKCPG.MADKBBLOPGO(116, JBEHMPDDMME.NPCAKEGNBHD().LPFKFNLHGBI);
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(false);
		JDCEFOFMGHB.JFIDAGABKID().BMOFIBGMIBK(ONPHLHKAGFP.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C20 RID: 27680 RVA: 0x003307E4 File Offset: 0x0032E9E4
	public void ELIFCAOENNK(ONKDCGNBALK GACACKNJKJN)
	{
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-110, this.GBGGILOHODG);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		JDCEFOFMGHB.HMJJPNDEKPP().CBHHEHHNFKL(GACACKNJKJN.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C21 RID: 27681 RVA: 0x00330818 File Offset: 0x0032EA18
	public void checkPriv()
	{
		if (!SteamManager.FPAKOLIPIND)
		{
			this.steamConnectBtn.SetActive(false);
			this.toGameKey.SetActive(true);
			return;
		}
		if (ObscuredString.BAKPLODMMOJ(JBEHMPDDMME.IKGFHGKKCPG.AMJCBLPKNCB, ObscuredString.GOOIABGKMHK("")))
		{
			this.steamConnectBtn.SetActive(true);
			this.toGameKey.SetActive(false);
			return;
		}
		this.toGameKey.SetActive(true);
		this.steamConnectBtn.SetActive(false);
	}

	// Token: 0x06006C22 RID: 27682 RVA: 0x00330891 File Offset: 0x0032EA91
	public void KJJIKCMAOMF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("{0}", 953f);
		this.pinPanel.gameObject.SetActive(!this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006C23 RID: 27683 RVA: 0x003308CA File Offset: 0x0032EACA
	public void KOPDMHJPBDG()
	{
		JDCEFOFMGHB.JFIDAGABKID().IGBJKJFAGKN(JNBICAJIJMM.EEOPOHEALPK().CKAOHMEKLMH("USER ID="), JNBICAJIJMM.EEOPOHEALPK().GNKIBMGNHNE("_CurveTex"), new ONKDCGNBALK.CMMHGMILOIM(this.HLHFEGDBLOD), null);
	}

	// Token: 0x06006C24 RID: 27684 RVA: 0x00330904 File Offset: 0x0032EB04
	private void PJMCFJBFLIH()
	{
		this.pinPanel.gameObject.SetActive(true);
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = false;
		if (GuiProcessor.BBLINJLBAIL() != null)
		{
			GuiProcessor.BBLINJLBAIL().CGKGBPLODOJ(this.mainCanvas);
		}
		this.panelNewReg.SetActive(JBEHMPDDMME.IKGFHGKKCPG.BJPJPFDOKDL);
		if (JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Count > 1)
		{
			this.panelNewReg.SetActive(true);
		}
	}

	// Token: 0x06006C25 RID: 27685 RVA: 0x0033097D File Offset: 0x0032EB7D
	public void POOPDJOGOHJ()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clips[1], 784f);
		JDCEFOFMGHB.HMJJPNDEKPP().LCEOGOCIMMB();
		SceneManager.LoadScene(3);
	}

	// Token: 0x06006C26 RID: 27686 RVA: 0x003309A6 File Offset: 0x0032EBA6
	public void EGMMIIAENHJ()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("OfficeSittingReadingCoffeeSip", 1946f);
		this.pinPanel.gameObject.SetActive(!this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006C27 RID: 27687 RVA: 0x003309DF File Offset: 0x0032EBDF
	public void OLPFPHOKPKC()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(true);
		this.steamConnectBtn.SetActive(false);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-37, ObscuredString.CKPPDHPJHEH(JBEHMPDDMME.NPCAKEGNBHD().IDAGBNBFHAB));
	}

	// Token: 0x06006C28 RID: 27688 RVA: 0x00330A14 File Offset: 0x0032EC14
	public void BECGNAEFABE()
	{
		if (!SteamManager.LCKFPOLOJJH())
		{
			this.steamConnectBtn.SetActive(false);
			this.toGameKey.SetActive(false);
			return;
		}
		if (ObscuredString.PGPAOADJOLC(JBEHMPDDMME.BPPFAOOCENN().AMJCBLPKNCB, ObscuredString.GOOIABGKMHK("Mouse X")))
		{
			this.steamConnectBtn.SetActive(false);
			this.toGameKey.SetActive(true);
			return;
		}
		this.toGameKey.SetActive(false);
		this.steamConnectBtn.SetActive(true);
	}

	// Token: 0x06006C29 RID: 27689 RVA: 0x00330A90 File Offset: 0x0032EC90
	public void EPNGDFAAPPL(long LPFKFNLHGBI)
	{
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.PLGADNLAEGN().MHHJHAKJPKM(LPFKFNLHGBI);
		if (nebjanknjog == null)
		{
			return;
		}
		this.selectShadId = LPFKFNLHGBI;
		JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH = nebjanknjog;
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clips[0], 737f);
		if (nebjanknjog.GDJMBFGEMFJ == 1)
		{
			this.manModel.BOOCBLKDAPP(nebjanknjog.GFLKLJPFLEA);
			this.manModel.gameObject.SetActive(false);
			this.womanModel.gameObject.SetActive(false);
			this.manModel.AAHMAEIAJML(nebjanknjog.LLKDOMIDPNM);
			return;
		}
		this.womanModel.ILHFOHFHOLK(nebjanknjog.GFLKLJPFLEA);
		this.manModel.gameObject.SetActive(true);
		this.womanModel.gameObject.SetActive(false);
		this.womanModel.ENABOACEALG(nebjanknjog.LLKDOMIDPNM);
	}

	// Token: 0x06006C2A RID: 27690 RVA: 0x00330B68 File Offset: 0x0032ED68
	public void ECOFCLNMJKH()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("WeaponReload", 687f);
		int dnhbpgoklkd = 0;
		try
		{
			dnhbpgoklkd = int.Parse(this.pinInput.text);
		}
		catch (Exception message)
		{
			Debug.Log(message);
		}
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-44, dnhbpgoklkd);
		this.pinPanel.gameObject.SetActive(false);
		FlyMessageManager.getI.FDHDJFEIOMG(JNBICAJIJMM.PGJCPFNJNPM("_SampleScale"), Color.green, 1, 1);
	}

	// Token: 0x06006C2B RID: 27691 RVA: 0x00330BF0 File Offset: 0x0032EDF0
	public void KJPKCKHLIHL(ONKDCGNBALK GACACKNJKJN)
	{
		NJMHLCGIAJI.IKGFHGKKCPG.MADKBBLOPGO(-121, this.GBGGILOHODG);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		JDCEFOFMGHB.MNJNNDHCDGG().DGFAPDDBHJB(GACACKNJKJN.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C2C RID: 27692 RVA: 0x00330C24 File Offset: 0x0032EE24
	private void Awake()
	{
		this.pinPanel.gameObject.SetActive(false);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		if (GuiProcessor.IKGFHGKKCPG != null)
		{
			GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA = this.mainCanvas;
		}
		this.panelNewReg.SetActive(JBEHMPDDMME.IKGFHGKKCPG.BJPJPFDOKDL);
		if (JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Count > 0)
		{
			this.panelNewReg.SetActive(false);
		}
	}

	// Token: 0x06006C2D RID: 27693 RVA: 0x00330C9D File Offset: 0x0032EE9D
	public void PHHNANJNKHG()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("Wizard2HandThrow", 307f);
		this.pinPanel.gameObject.SetActive(!this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006C2E RID: 27694 RVA: 0x00330CD6 File Offset: 0x0032EED6
	public void AFCGNGDMPAO()
	{
		if (this.selectShadId > 0L)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.clips[1], 399f);
			JDCEFOFMGHB.IKGFHGKKCPG.LCEOGOCIMMB();
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-14, this.selectShadId);
		}
	}

	// Token: 0x06006C2F RID: 27695 RVA: 0x00330D18 File Offset: 0x0032EF18
	public void PMJCBNELMAN(long LPFKFNLHGBI)
	{
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.IKGFHGKKCPG.BALFGEEFKFK(LPFKFNLHGBI);
		if (nebjanknjog == null)
		{
			return;
		}
		this.selectShadId = LPFKFNLHGBI;
		JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH = nebjanknjog;
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clips[1], 1527f);
		if (nebjanknjog.GDJMBFGEMFJ == 1)
		{
			this.manModel.CEGKIIDPPEK(nebjanknjog.GFLKLJPFLEA);
			this.manModel.gameObject.SetActive(true);
			this.womanModel.gameObject.SetActive(true);
			this.manModel.NEBNFPPKJAE(nebjanknjog.LLKDOMIDPNM);
			return;
		}
		this.womanModel.BOOCBLKDAPP(nebjanknjog.GFLKLJPFLEA);
		this.manModel.gameObject.SetActive(true);
		this.womanModel.gameObject.SetActive(true);
		this.womanModel.EHEBKBBAMFN(nebjanknjog.LLKDOMIDPNM);
	}

	// Token: 0x06006C30 RID: 27696 RVA: 0x00330DF0 File Offset: 0x0032EFF0
	public void LPHKDAFHHIK()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(false);
		this.steamConnectBtn.SetActive(true);
		NJMHLCGIAJI.EAJGHMMBAFP().BNJEMPKFNLA(-83, ObscuredString.CKPPDHPJHEH(JBEHMPDDMME.EAJHPOJPPFA().IDAGBNBFHAB));
	}

	// Token: 0x06006C31 RID: 27697 RVA: 0x00330E24 File Offset: 0x0032F024
	public void JPKGMALKHJE()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(true);
		this.steamConnectBtn.SetActive(true);
		NJMHLCGIAJI.EAJGHMMBAFP().AMEOMLNLOGF(55, ObscuredString.GOOIABGKMHK(JBEHMPDDMME.JKIFIBEPICO().IDAGBNBFHAB));
	}

	// Token: 0x06006C32 RID: 27698 RVA: 0x00330E58 File Offset: 0x0032F058
	private void CGFDDFHECLJ()
	{
		this.BECIMDOBDCL = false;
		bool active = true;
		if (JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Count > 1)
		{
			active = false;
		}
		if (JBEHMPDDMME.BPPFAOOCENN().KKNEKAEJLAM > 0L)
		{
			active = true;
		}
		if (!JBEHMPDDMME.NPCAKEGNBHD().PEKHEALPHLD)
		{
			active = false;
		}
		this.delAccountBtn.SetActive(active);
		SelectShadowLogic.getI = this;
		FBFJFAKAGJG.IKGFHGKKCPG.MHMEMCADNHA();
		this.JHDMMLGIDFO();
		if (JBEHMPDDMME.NPCAKEGNBHD() == null)
		{
			return;
		}
		if (JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Count <= 1)
		{
			this.BECIMDOBDCL = true;
		}
		float num = 1494f;
		foreach (NEBJANKNJOG nebjanknjog in JBEHMPDDMME.NPCAKEGNBHD().KCPPGCGBKGE.Values)
		{
			SelectShadowLogic.IJHCPFGILKB ijhcpfgilkb = new SelectShadowLogic.IJHCPFGILKB();
			ijhcpfgilkb.AENJLLPLILM = this;
			ijhcpfgilkb.JCGDLKIHBJG = nebjanknjog.LPFKFNLHGBI;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.selShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (!(component == null))
			{
				component.SetParent(this.shadBtnPanel, false);
				component.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 1777f);
				SelShdBtn component2 = gameObject.GetComponent<SelShdBtn>();
				if (component2)
				{
					component2.INIDEJOJOON(nebjanknjog);
				}
				Button component3 = gameObject.GetComponent<Button>();
				if (component3 != null)
				{
					component3.onClick.AddListener(new UnityAction(ijhcpfgilkb.OFAFHKHBBND));
				}
				num -= component.rect.height;
			}
		}
		int num2 = 2 - JBEHMPDDMME.JKIFIBEPICO().KCPPGCGBKGE.Count;
		for (int i = 1; i < num2; i += 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.crShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component4 = gameObject2.GetComponent<RectTransform>();
			if (!(component4 == null))
			{
				component4.SetParent(this.shadBtnPanel, true);
				component4.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 310f);
				num -= component4.rect.height;
				Button component5 = gameObject2.GetComponent<Button>();
				if (component5 != null)
				{
					component5.onClick.AddListener(new UnityAction(this.LMOCAIMBGME));
				}
			}
		}
		using (Dictionary<long, NEBJANKNJOG>.ValueCollection.Enumerator enumerator = JBEHMPDDMME.PLGADNLAEGN().KCPPGCGBKGE.Values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				NEBJANKNJOG nebjanknjog2 = enumerator.Current;
				this.DCNJMIPGMEK(nebjanknjog2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x06006C33 RID: 27699 RVA: 0x0033115C File Offset: 0x0032F35C
	public void PGCEEGDLBHH()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("<color='#000000'>", 457f);
		int dnhbpgoklkd = 1;
		try
		{
			dnhbpgoklkd = int.Parse(this.pinInput.text);
		}
		catch (Exception message)
		{
			Debug.Log(message);
		}
		NJMHLCGIAJI.IKGFHGKKCPG.KCONDIDKLIB(-64, dnhbpgoklkd);
		this.pinPanel.gameObject.SetActive(true);
		FlyMessageManager.getI.MEIICCGKONL(JNBICAJIJMM.NGALDMFKMJH("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/"), Color.green, 0, 0);
	}

	// Token: 0x06006C34 RID: 27700 RVA: 0x003311E4 File Offset: 0x0032F3E4
	public void KHLJCFCCPKF()
	{
		if (!SteamManager.OIPNMDCOJMD())
		{
			this.steamConnectBtn.SetActive(true);
			this.toGameKey.SetActive(true);
			return;
		}
		if (ObscuredString.EANKOOABLMJ(JBEHMPDDMME.BPPFAOOCENN().AMJCBLPKNCB, ObscuredString.EMFOKHGIMFM("[ACTk] Injection Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?")))
		{
			this.steamConnectBtn.SetActive(true);
			this.toGameKey.SetActive(false);
			return;
		}
		this.toGameKey.SetActive(false);
		this.steamConnectBtn.SetActive(false);
	}

	// Token: 0x06006C35 RID: 27701 RVA: 0x0033125D File Offset: 0x0032F45D
	public void BEEBEFHDFJJ()
	{
		if (this.selectShadId > 0L)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.clips[1], 1036f);
			JDCEFOFMGHB.HMJJPNDEKPP().LCEOGOCIMMB();
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-62, this.selectShadId);
		}
	}

	// Token: 0x06006C36 RID: 27702 RVA: 0x0033129C File Offset: 0x0032F49C
	public void LCAKPJMOONN()
	{
		if (this.selectShadId <= 1L)
		{
			return;
		}
		Debug.Log("wpn_add/base");
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.EAJHPOJPPFA().IKIEDBCHOAO(this.selectShadId);
		if (nebjanknjog == null)
		{
			return;
		}
		this.GBGGILOHODG = nebjanknjog.LPFKFNLHGBI;
		JDCEFOFMGHB.HMJJPNDEKPP().HJJKHHHLDAJ(JNBICAJIJMM.LEBHCLDODNI("PaperTurn.wav"), string.Format(JNBICAJIJMM.BDKHMOOFHHK("#0080ff"), nebjanknjog.BNIHFBMEPAB), new ONKDCGNBALK.CMMHGMILOIM(this.KHECAHKOPNN), null);
	}

	// Token: 0x06006C37 RID: 27703 RVA: 0x00331315 File Offset: 0x0032F515
	public void AHCFCDADNIK()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("", 1235f);
		this.pinPanel.gameObject.SetActive(!this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006C38 RID: 27704 RVA: 0x0033134E File Offset: 0x0032F54E
	public void CAHBIMEJNON(ONKDCGNBALK GACACKNJKJN)
	{
		NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(3, this.GBGGILOHODG);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		JDCEFOFMGHB.JFIDAGABKID().BMOFIBGMIBK(GACACKNJKJN.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C39 RID: 27705 RVA: 0x00331382 File Offset: 0x0032F582
	public void DHIFCMJDLNF()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().MDBKHKBJNAO(false);
		this.steamConnectBtn.SetActive(true);
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-11, ObscuredString.GOOIABGKMHK(JBEHMPDDMME.BPPFAOOCENN().IDAGBNBFHAB));
	}

	// Token: 0x06006C3A RID: 27706 RVA: 0x003313B6 File Offset: 0x0032F5B6
	public void CNMLPOOEOGL()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().CLADNJHAABI(JNBICAJIJMM.EKEBHIJMEML().CCFFMKBBKHI("Hidden/Post FX/Builtin Debug Views"), JNBICAJIJMM.IMLLGEMPHAP().NLJOLOBPCBJ(""), new ONKDCGNBALK.CMMHGMILOIM(this.MAAIHPANJPN), null);
	}

	// Token: 0x06006C3B RID: 27707 RVA: 0x003313ED File Offset: 0x0032F5ED
	private void HLHFEGDBLOD(ONKDCGNBALK ONPHLHKAGFP)
	{
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-54, JBEHMPDDMME.EAJHPOJPPFA().LPFKFNLHGBI);
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(true);
		JDCEFOFMGHB.HMJJPNDEKPP().DGFAPDDBHJB(ONPHLHKAGFP.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C3C RID: 27708 RVA: 0x00331425 File Offset: 0x0032F625
	public void NHMLFEGHDLD()
	{
		if (this.selectShadId > 1L)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.clips[1], 649f);
			JDCEFOFMGHB.MNJNNDHCDGG().DDAIBFBOENE();
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(99, this.selectShadId);
		}
	}

	// Token: 0x06006C3D RID: 27709 RVA: 0x00331464 File Offset: 0x0032F664
	public void IGAAEMOELCC()
	{
		if (!SteamManager.PGAALOOPLCE())
		{
			this.steamConnectBtn.SetActive(false);
			this.toGameKey.SetActive(false);
			return;
		}
		if (ObscuredString.BAKPLODMMOJ(JBEHMPDDMME.PFOLNEGNIPP().AMJCBLPKNCB, ObscuredString.AOOBGNKCJLF("_NoiseScale")))
		{
			this.steamConnectBtn.SetActive(true);
			this.toGameKey.SetActive(false);
			return;
		}
		this.toGameKey.SetActive(false);
		this.steamConnectBtn.SetActive(false);
	}

	// Token: 0x06006C3E RID: 27710 RVA: 0x003314E0 File Offset: 0x0032F6E0
	public void EHDIEIFNCNA()
	{
		if (!SteamManager.NNFCGADDAHL())
		{
			this.steamConnectBtn.SetActive(false);
			this.toGameKey.SetActive(false);
			return;
		}
		if (ObscuredString.BLDHBEPMKBN(JBEHMPDDMME.PLGADNLAEGN().AMJCBLPKNCB, ObscuredString.AOOBGNKCJLF("SneakRight")))
		{
			this.steamConnectBtn.SetActive(true);
			this.toGameKey.SetActive(true);
			return;
		}
		this.toGameKey.SetActive(true);
		this.steamConnectBtn.SetActive(true);
	}

	// Token: 0x06006C3F RID: 27711 RVA: 0x00331559 File Offset: 0x0032F759
	public void LMDDKHCIGPA()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().HJJKHHHLDAJ(JNBICAJIJMM.EKEBHIJMEML().FLEANFGEJML("*** PODSEK"), JNBICAJIJMM.EDKGBBIIBBC().HLBAJBLHLNI("TOD_CloudDensity"), new ONKDCGNBALK.CMMHGMILOIM(this.ILPDJKAMNOD), null);
	}

	// Token: 0x06006C40 RID: 27712 RVA: 0x00331590 File Offset: 0x0032F790
	public void PBMCPGCJIID()
	{
		if (!SteamManager.KLPAEPHIOAJ())
		{
			this.steamConnectBtn.SetActive(false);
			this.toGameKey.SetActive(false);
			return;
		}
		if (ObscuredString.BLDHBEPMKBN(JBEHMPDDMME.IKGFHGKKCPG.AMJCBLPKNCB, ObscuredString.GOOIABGKMHK("SpinReel.ogg")))
		{
			this.steamConnectBtn.SetActive(false);
			this.toGameKey.SetActive(true);
			return;
		}
		this.toGameKey.SetActive(true);
		this.steamConnectBtn.SetActive(true);
	}

	// Token: 0x06006C41 RID: 27713 RVA: 0x0033160C File Offset: 0x0032F80C
	private void AOJICLCCJHF()
	{
		this.BECIMDOBDCL = false;
		bool active = true;
		if (JBEHMPDDMME.BOKIOJFHNLD().KCPPGCGBKGE.Count > 1)
		{
			active = false;
		}
		if (JBEHMPDDMME.PLGADNLAEGN().KKNEKAEJLAM > 0L)
		{
			active = true;
		}
		if (!JBEHMPDDMME.NPCAKEGNBHD().PEKHEALPHLD)
		{
			active = false;
		}
		this.delAccountBtn.SetActive(active);
		SelectShadowLogic.getI = this;
		FBFJFAKAGJG.IKGFHGKKCPG.LOAGNOGBOAN();
		this.EHDIEIFNCNA();
		if (JBEHMPDDMME.PLGADNLAEGN() == null)
		{
			return;
		}
		if (JBEHMPDDMME.BOKIOJFHNLD().KCPPGCGBKGE.Count <= 0)
		{
			this.BECIMDOBDCL = true;
		}
		float num = 1504f;
		foreach (NEBJANKNJOG nebjanknjog in JBEHMPDDMME.NPCAKEGNBHD().KCPPGCGBKGE.Values)
		{
			SelectShadowLogic.IJHCPFGILKB ijhcpfgilkb = new SelectShadowLogic.IJHCPFGILKB();
			ijhcpfgilkb.AENJLLPLILM = this;
			ijhcpfgilkb.JCGDLKIHBJG = nebjanknjog.LPFKFNLHGBI;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.selShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (!(component == null))
			{
				component.SetParent(this.shadBtnPanel, false);
				component.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 1982f);
				SelShdBtn component2 = gameObject.GetComponent<SelShdBtn>();
				if (component2)
				{
					component2.EBIGDGDMIIC(nebjanknjog);
				}
				Button component3 = gameObject.GetComponent<Button>();
				if (component3 != null)
				{
					component3.onClick.AddListener(new UnityAction(ijhcpfgilkb.OMNBJDKDCFJ));
				}
				num -= component.rect.height;
			}
		}
		int num2 = 8 - JBEHMPDDMME.BPPFAOOCENN().KCPPGCGBKGE.Count;
		for (int i = 1; i < num2; i++)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.crShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component4 = gameObject2.GetComponent<RectTransform>();
			if (!(component4 == null))
			{
				component4.SetParent(this.shadBtnPanel, true);
				component4.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 135f);
				num -= component4.rect.height;
				Button component5 = gameObject2.GetComponent<Button>();
				if (component5 != null)
				{
					component5.onClick.AddListener(new UnityAction(this.BBLHDLDFBBC));
				}
			}
		}
		using (Dictionary<long, NEBJANKNJOG>.ValueCollection.Enumerator enumerator = JBEHMPDDMME.JKIFIBEPICO().KCPPGCGBKGE.Values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				NEBJANKNJOG nebjanknjog2 = enumerator.Current;
				this.ALAGLEOAAHN(nebjanknjog2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x06006C42 RID: 27714 RVA: 0x00331910 File Offset: 0x0032FB10
	public void NPDAOBNNCJO()
	{
		if (!SteamManager.FPAKOLIPIND)
		{
			this.steamConnectBtn.SetActive(false);
			this.toGameKey.SetActive(true);
			return;
		}
		if (ObscuredString.PGPAOADJOLC(JBEHMPDDMME.EAJHPOJPPFA().AMJCBLPKNCB, ObscuredString.GOOIABGKMHK("_WrinkleOcclusionMap1")))
		{
			this.steamConnectBtn.SetActive(true);
			this.toGameKey.SetActive(true);
			return;
		}
		this.toGameKey.SetActive(true);
		this.steamConnectBtn.SetActive(false);
	}

	// Token: 0x06006C43 RID: 27715 RVA: 0x00331989 File Offset: 0x0032FB89
	public void LFBIACJBCJJ()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("[/quote]", 755f);
		this.pinPanel.gameObject.SetActive(this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006C44 RID: 27716 RVA: 0x003319C2 File Offset: 0x0032FBC2
	public void EFDDDPPKMPN()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("_History2ChromaTex", 812f);
		this.pinPanel.gameObject.SetActive(this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006C45 RID: 27717 RVA: 0x003319FC File Offset: 0x0032FBFC
	private void KDCOHILDJJO()
	{
		this.BECIMDOBDCL = false;
		bool active = false;
		if (JBEHMPDDMME.PFOLNEGNIPP().KCPPGCGBKGE.Count > 1)
		{
			active = false;
		}
		if (JBEHMPDDMME.EAJHPOJPPFA().KKNEKAEJLAM > 1L)
		{
			active = true;
		}
		if (!JBEHMPDDMME.BPPFAOOCENN().PEKHEALPHLD)
		{
			active = false;
		}
		this.delAccountBtn.SetActive(active);
		SelectShadowLogic.getI = this;
		FBFJFAKAGJG.IKGFHGKKCPG.NJJEOKEKIPG();
		this.EHDIEIFNCNA();
		if (JBEHMPDDMME.JKIFIBEPICO() == null)
		{
			return;
		}
		if (JBEHMPDDMME.BOKIOJFHNLD().KCPPGCGBKGE.Count <= 0)
		{
			this.BECIMDOBDCL = false;
		}
		float num = 700f;
		foreach (NEBJANKNJOG nebjanknjog in JBEHMPDDMME.BPPFAOOCENN().KCPPGCGBKGE.Values)
		{
			SelectShadowLogic.IJHCPFGILKB ijhcpfgilkb = new SelectShadowLogic.IJHCPFGILKB();
			ijhcpfgilkb.AENJLLPLILM = this;
			ijhcpfgilkb.JCGDLKIHBJG = nebjanknjog.LPFKFNLHGBI;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.selShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (!(component == null))
			{
				component.SetParent(this.shadBtnPanel, true);
				component.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 226f);
				SelShdBtn component2 = gameObject.GetComponent<SelShdBtn>();
				if (component2)
				{
					component2.setData(nebjanknjog);
				}
				Button component3 = gameObject.GetComponent<Button>();
				if (component3 != null)
				{
					component3.onClick.AddListener(new UnityAction(ijhcpfgilkb.JFFBOHPPGBB));
				}
				num -= component.rect.height;
			}
		}
		int num2 = 6 - JBEHMPDDMME.EAJHPOJPPFA().KCPPGCGBKGE.Count;
		for (int i = 1; i < num2; i += 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.crShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component4 = gameObject2.GetComponent<RectTransform>();
			if (!(component4 == null))
			{
				component4.SetParent(this.shadBtnPanel, false);
				component4.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 2f);
				num -= component4.rect.height;
				Button component5 = gameObject2.GetComponent<Button>();
				if (component5 != null)
				{
					component5.onClick.AddListener(new UnityAction(this.JJJOCBBHPJD));
				}
			}
		}
		using (Dictionary<long, NEBJANKNJOG>.ValueCollection.Enumerator enumerator = JBEHMPDDMME.PLGADNLAEGN().KCPPGCGBKGE.Values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				NEBJANKNJOG nebjanknjog2 = enumerator.Current;
				this.PCAFJKKMJJL(nebjanknjog2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x06006C46 RID: 27718 RVA: 0x00331D00 File Offset: 0x0032FF00
	public void EPLICMIJEOC()
	{
		if (this.selectShadId <= 0L)
		{
			return;
		}
		Debug.Log("{0}, {1}, {2}");
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.BOKIOJFHNLD().JPFCACJPHGP(this.selectShadId);
		if (nebjanknjog == null)
		{
			return;
		}
		this.GBGGILOHODG = nebjanknjog.LPFKFNLHGBI;
		JDCEFOFMGHB.HMJJPNDEKPP().LLKDAODBJDA(JNBICAJIJMM.CDDCIKKDFMP("usetime"), string.Format(JNBICAJIJMM.NGALDMFKMJH("_Offsets"), nebjanknjog.BNIHFBMEPAB), new ONKDCGNBALK.CMMHGMILOIM(this.ACCLCKLDOBJ), null);
	}

	// Token: 0x06006C47 RID: 27719 RVA: 0x00331D79 File Offset: 0x0032FF79
	private void LBOAPNCLFPD(ONKDCGNBALK ONPHLHKAGFP)
	{
		NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(36, JBEHMPDDMME.BPPFAOOCENN().LPFKFNLHGBI);
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(false);
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(ONPHLHKAGFP.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C48 RID: 27720 RVA: 0x00331DB4 File Offset: 0x0032FFB4
	private void AFALNDHNIKH()
	{
		this.pinPanel.gameObject.SetActive(true);
		JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(true);
		if (GuiProcessor.IKGFHGKKCPG != null)
		{
			GuiProcessor.NKOEAPCIBKO().CGKGBPLODOJ(this.mainCanvas);
		}
		this.panelNewReg.SetActive(JBEHMPDDMME.PFOLNEGNIPP().BJPJPFDOKDL);
		if (JBEHMPDDMME.PLGADNLAEGN().KCPPGCGBKGE.Count > 0)
		{
			this.panelNewReg.SetActive(true);
		}
	}

	// Token: 0x06006C49 RID: 27721 RVA: 0x00331E30 File Offset: 0x00330030
	public void selectShadowClick(long LPFKFNLHGBI)
	{
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.IKGFHGKKCPG.OKFPEMCFMKN(LPFKFNLHGBI);
		if (nebjanknjog == null)
		{
			return;
		}
		this.selectShadId = LPFKFNLHGBI;
		JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH = nebjanknjog;
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clips[0], 1f);
		if (nebjanknjog.GDJMBFGEMFJ == 1)
		{
			this.manModel.initShadowsParams(nebjanknjog.GFLKLJPFLEA);
			this.manModel.gameObject.SetActive(true);
			this.womanModel.gameObject.SetActive(false);
			this.manModel.changeCostume(nebjanknjog.LLKDOMIDPNM);
			return;
		}
		this.womanModel.initShadowsParams(nebjanknjog.GFLKLJPFLEA);
		this.manModel.gameObject.SetActive(false);
		this.womanModel.gameObject.SetActive(true);
		this.womanModel.changeCostume(nebjanknjog.LLKDOMIDPNM);
	}

	// Token: 0x06006C4A RID: 27722 RVA: 0x00331F08 File Offset: 0x00330108
	public void goToGame()
	{
		if (this.selectShadId > 0L)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clips[0], 1f);
			JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(100, this.selectShadId);
		}
	}

	// Token: 0x06006C4B RID: 27723 RVA: 0x00331F48 File Offset: 0x00330148
	public void EKDFFALAOHA()
	{
		if (!SteamManager.MFDPJMKMHNG())
		{
			this.steamConnectBtn.SetActive(false);
			this.toGameKey.SetActive(false);
			return;
		}
		if (ObscuredString.BAKPLODMMOJ(JBEHMPDDMME.PLGADNLAEGN().AMJCBLPKNCB, ObscuredString.LMCJCHPGIJK("_BlurCoe")))
		{
			this.steamConnectBtn.SetActive(true);
			this.toGameKey.SetActive(true);
			return;
		}
		this.toGameKey.SetActive(true);
		this.steamConnectBtn.SetActive(true);
	}

	// Token: 0x06006C4C RID: 27724 RVA: 0x00331FC1 File Offset: 0x003301C1
	public void JHKPDPOLJDK()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().CLADNJHAABI(JNBICAJIJMM.IKGFHGKKCPG.FLEANFGEJML("WeaponReadyFire"), JNBICAJIJMM.DBMJJPBOPEK().HLBAJBLHLNI("IceHockeyGoalieReady"), new ONKDCGNBALK.CMMHGMILOIM(this.PDLALGGDDGP), null);
	}

	// Token: 0x06006C4D RID: 27725 RVA: 0x00331FF8 File Offset: 0x003301F8
	private void OFGGEIGJNOF(ONKDCGNBALK ONPHLHKAGFP)
	{
		NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(-91, JBEHMPDDMME.NPCAKEGNBHD().LPFKFNLHGBI);
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = false;
		JDCEFOFMGHB.MNJNNDHCDGG().CBHHEHHNFKL(ONPHLHKAGFP.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C4E RID: 27726 RVA: 0x00332030 File Offset: 0x00330230
	public void HCEHGAFGHGH()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.CLADNJHAABI(JNBICAJIJMM.EDKGBBIIBBC().CKAOHMEKLMH("\n"), JNBICAJIJMM.IKGFHGKKCPG.GNKIBMGNHNE(""), new ONKDCGNBALK.CMMHGMILOIM(this.ILPDJKAMNOD), null);
	}

	// Token: 0x06006C4F RID: 27727 RVA: 0x00332067 File Offset: 0x00330267
	public void NJEAEDAKCEK()
	{
		if (this.selectShadId > 0L)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.clips[1], 1433f);
			JDCEFOFMGHB.MNJNNDHCDGG().DDAIBFBOENE();
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-34, this.selectShadId);
		}
	}

	// Token: 0x06006C50 RID: 27728 RVA: 0x003320A8 File Offset: 0x003302A8
	public void KABPHPNHBNE(long LPFKFNLHGBI)
	{
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.NPCAKEGNBHD().FGKLBBPAMHP(LPFKFNLHGBI);
		if (nebjanknjog == null)
		{
			return;
		}
		this.selectShadId = LPFKFNLHGBI;
		JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH = nebjanknjog;
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.clips[1], 301f);
		if (nebjanknjog.GDJMBFGEMFJ == 0)
		{
			this.manModel.MOBBHCIBIIM(nebjanknjog.GFLKLJPFLEA);
			this.manModel.gameObject.SetActive(false);
			this.womanModel.gameObject.SetActive(true);
			this.manModel.GLBOAFGFDII(nebjanknjog.LLKDOMIDPNM);
			return;
		}
		this.womanModel.CBEBJEKBDCO(nebjanknjog.GFLKLJPFLEA);
		this.manModel.gameObject.SetActive(true);
		this.womanModel.gameObject.SetActive(true);
		this.womanModel.KHJMJMGFCME(nebjanknjog.LLKDOMIDPNM);
	}

	// Token: 0x06006C51 RID: 27729 RVA: 0x00332180 File Offset: 0x00330380
	public void MGPDJJKPNNP(ONKDCGNBALK GACACKNJKJN)
	{
		NJMHLCGIAJI.IKGFHGKKCPG.MADKBBLOPGO(-51, this.GBGGILOHODG);
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(true);
		JDCEFOFMGHB.JFIDAGABKID().KCNBOHEMLCI(GACACKNJKJN.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C52 RID: 27730 RVA: 0x003321B4 File Offset: 0x003303B4
	public void GPPKHAOEILJ()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("", 352f);
		this.pinPanel.gameObject.SetActive(!this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006C53 RID: 27731 RVA: 0x003321F0 File Offset: 0x003303F0
	public void JCDGIBHCMDF()
	{
		if (this.selectShadId <= 0L)
		{
			return;
		}
		Debug.Log("Move around with WASD or cursor keys, space to jump, F key to change fog style, T to toggle fog on/off, C to toggle fog cutting, R to reset fog.");
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.PLGADNLAEGN().MHHJHAKJPKM(this.selectShadId);
		if (nebjanknjog == null)
		{
			return;
		}
		this.GBGGILOHODG = nebjanknjog.LPFKFNLHGBI;
		JDCEFOFMGHB.MNJNNDHCDGG().CLADNJHAABI(JNBICAJIJMM.PGJCPFNJNPM("OneHandSwordIdle"), string.Format(JNBICAJIJMM.OOOKJHOHPNN("MotorbikeLassoRight"), nebjanknjog.BNIHFBMEPAB), new ONKDCGNBALK.CMMHGMILOIM(this.JEEDKHEFCFB), null);
	}

	// Token: 0x06006C54 RID: 27732 RVA: 0x00332269 File Offset: 0x00330469
	public void IKEMFAKAHFP()
	{
		JDCEFOFMGHB.JFIDAGABKID().IGBJKJFAGKN(JNBICAJIJMM.LPHMKPDBMPP().CCFFMKBBKHI(""), JNBICAJIJMM.CLIMNFDGOEG().CCFFMKBBKHI("\n"), new ONKDCGNBALK.CMMHGMILOIM(this.KDOGDBFJHFA), null);
	}

	// Token: 0x06006C55 RID: 27733 RVA: 0x003322A0 File Offset: 0x003304A0
	private void MIBLGALCOGP(ONKDCGNBALK ONPHLHKAGFP)
	{
		NJMHLCGIAJI.IKGFHGKKCPG.MADKBBLOPGO(-32, JBEHMPDDMME.IKGFHGKKCPG.LPFKFNLHGBI);
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = true;
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(ONPHLHKAGFP.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C56 RID: 27734 RVA: 0x003322D8 File Offset: 0x003304D8
	public void DHDGHJMMDMM()
	{
		if (this.selectShadId <= 0L)
		{
			return;
		}
		Debug.Log("collar");
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.BOKIOJFHNLD().POJIJIMHFHF(this.selectShadId);
		if (nebjanknjog == null)
		{
			return;
		}
		this.GBGGILOHODG = nebjanknjog.LPFKFNLHGBI;
		JDCEFOFMGHB.IKGFHGKKCPG.LLKDAODBJDA(JNBICAJIJMM.DIOJFJMOPJO("distscale"), string.Format(JNBICAJIJMM.PGJCPFNJNPM("wpn_rod4"), nebjanknjog.BNIHFBMEPAB), new ONKDCGNBALK.CMMHGMILOIM(this.ELIFCAOENNK), null);
	}

	// Token: 0x06006C57 RID: 27735 RVA: 0x00332351 File Offset: 0x00330551
	public void DDNINLHIDLP()
	{
		if (this.selectShadId > 1L)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(this.clips[1], 1874f);
			JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
			NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(-70, this.selectShadId);
		}
	}

	// Token: 0x06006C58 RID: 27736 RVA: 0x00332390 File Offset: 0x00330590
	private void AIFIEAGFIMM()
	{
		this.BECIMDOBDCL = true;
		bool active = true;
		if (JBEHMPDDMME.JKIFIBEPICO().KCPPGCGBKGE.Count > 1)
		{
			active = true;
		}
		if (JBEHMPDDMME.JKIFIBEPICO().KKNEKAEJLAM > 1L)
		{
			active = true;
		}
		if (!JBEHMPDDMME.IKGFHGKKCPG.PEKHEALPHLD)
		{
			active = false;
		}
		this.delAccountBtn.SetActive(active);
		SelectShadowLogic.getI = this;
		FBFJFAKAGJG.IKGFHGKKCPG.JIOAMAPJOFA();
		this.JJGDJKFIHBO();
		if (JBEHMPDDMME.NPCAKEGNBHD() == null)
		{
			return;
		}
		if (JBEHMPDDMME.PFOLNEGNIPP().KCPPGCGBKGE.Count <= 1)
		{
			this.BECIMDOBDCL = false;
		}
		float num = 1579f;
		foreach (NEBJANKNJOG nebjanknjog in JBEHMPDDMME.BPPFAOOCENN().KCPPGCGBKGE.Values)
		{
			SelectShadowLogic.IJHCPFGILKB ijhcpfgilkb = new SelectShadowLogic.IJHCPFGILKB();
			ijhcpfgilkb.AENJLLPLILM = this;
			ijhcpfgilkb.JCGDLKIHBJG = nebjanknjog.LPFKFNLHGBI;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.selShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (!(component == null))
			{
				component.SetParent(this.shadBtnPanel, true);
				component.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 1169f);
				SelShdBtn component2 = gameObject.GetComponent<SelShdBtn>();
				if (component2)
				{
					component2.MCMALHNDCLF(nebjanknjog);
				}
				Button component3 = gameObject.GetComponent<Button>();
				if (component3 != null)
				{
					component3.onClick.AddListener(new UnityAction(ijhcpfgilkb.MLDJPPPMNNF));
				}
				num -= component.rect.height;
			}
		}
		int num2 = 5 - JBEHMPDDMME.BPPFAOOCENN().KCPPGCGBKGE.Count;
		for (int i = 0; i < num2; i++)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.crShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component4 = gameObject2.GetComponent<RectTransform>();
			if (!(component4 == null))
			{
				component4.SetParent(this.shadBtnPanel, true);
				component4.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 474f);
				num -= component4.rect.height;
				Button component5 = gameObject2.GetComponent<Button>();
				if (component5 != null)
				{
					component5.onClick.AddListener(new UnityAction(this.createShadow));
				}
			}
		}
		using (Dictionary<long, NEBJANKNJOG>.ValueCollection.Enumerator enumerator = JBEHMPDDMME.PFOLNEGNIPP().KCPPGCGBKGE.Values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				NEBJANKNJOG nebjanknjog2 = enumerator.Current;
				this.DCNJMIPGMEK(nebjanknjog2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x06006C59 RID: 27737 RVA: 0x00332694 File Offset: 0x00330894
	public void KIAMBLPJBPA()
	{
		JDCEFOFMGHB.JFIDAGABKID().LLKDAODBJDA(JNBICAJIJMM.EEOPOHEALPK().CCFFMKBBKHI("ankle"), JNBICAJIJMM.EEOPOHEALPK().HEIBEHAEHBM("RollerBladeBackFlip"), new ONKDCGNBALK.CMMHGMILOIM(this.KDOGDBFJHFA), null);
	}

	// Token: 0x06006C5A RID: 27738 RVA: 0x003326CC File Offset: 0x003308CC
	private void KKCFKEDABLB()
	{
		this.BECIMDOBDCL = true;
		bool active = false;
		if (JBEHMPDDMME.BOKIOJFHNLD().KCPPGCGBKGE.Count > 1)
		{
			active = false;
		}
		if (JBEHMPDDMME.IKGFHGKKCPG.KKNEKAEJLAM > 1L)
		{
			active = false;
		}
		if (!JBEHMPDDMME.NPCAKEGNBHD().PEKHEALPHLD)
		{
			active = true;
		}
		this.delAccountBtn.SetActive(active);
		SelectShadowLogic.getI = this;
		FBFJFAKAGJG.IKGFHGKKCPG.NJJEOKEKIPG();
		this.EKDFFALAOHA();
		if (JBEHMPDDMME.NPCAKEGNBHD() == null)
		{
			return;
		}
		if (JBEHMPDDMME.PLGADNLAEGN().KCPPGCGBKGE.Count <= 0)
		{
			this.BECIMDOBDCL = false;
		}
		float num = 346f;
		foreach (NEBJANKNJOG nebjanknjog in JBEHMPDDMME.PFOLNEGNIPP().KCPPGCGBKGE.Values)
		{
			SelectShadowLogic.IJHCPFGILKB ijhcpfgilkb = new SelectShadowLogic.IJHCPFGILKB();
			ijhcpfgilkb.AENJLLPLILM = this;
			ijhcpfgilkb.JCGDLKIHBJG = nebjanknjog.LPFKFNLHGBI;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.selShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (!(component == null))
			{
				component.SetParent(this.shadBtnPanel, false);
				component.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 1249f);
				SelShdBtn component2 = gameObject.GetComponent<SelShdBtn>();
				if (component2)
				{
					component2.INIDEJOJOON(nebjanknjog);
				}
				Button component3 = gameObject.GetComponent<Button>();
				if (component3 != null)
				{
					component3.onClick.AddListener(new UnityAction(ijhcpfgilkb.ACNOKCPPPKH));
				}
				num -= component.rect.height;
			}
		}
		int num2 = 6 - JBEHMPDDMME.BPPFAOOCENN().KCPPGCGBKGE.Count;
		for (int i = 1; i < num2; i += 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.crShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component4 = gameObject2.GetComponent<RectTransform>();
			if (!(component4 == null))
			{
				component4.SetParent(this.shadBtnPanel, true);
				component4.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 1818f);
				num -= component4.rect.height;
				Button component5 = gameObject2.GetComponent<Button>();
				if (component5 != null)
				{
					component5.onClick.AddListener(new UnityAction(this.JJJOCBBHPJD));
				}
			}
		}
		using (Dictionary<long, NEBJANKNJOG>.ValueCollection.Enumerator enumerator = JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				NEBJANKNJOG nebjanknjog2 = enumerator.Current;
				this.CLCBCIDGNAO(nebjanknjog2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x06006C5B RID: 27739 RVA: 0x003329D0 File Offset: 0x00330BD0
	public void HFIMIDBDICF()
	{
		if (this.selectShadId <= 0L)
		{
			return;
		}
		Debug.Log("ShotgunReloadMagazine");
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.PFOLNEGNIPP().FAFLANJMEBL(this.selectShadId);
		if (nebjanknjog == null)
		{
			return;
		}
		this.GBGGILOHODG = nebjanknjog.LPFKFNLHGBI;
		JDCEFOFMGHB.HMJJPNDEKPP().LLKDAODBJDA(JNBICAJIJMM.CDDCIKKDFMP("RollerBladeTurnLeft"), string.Format(JNBICAJIJMM.OOOKJHOHPNN("wpn_add/base"), nebjanknjog.BNIHFBMEPAB), new ONKDCGNBALK.CMMHGMILOIM(this.BDGMMOGIHIP), null);
	}

	// Token: 0x06006C5C RID: 27740 RVA: 0x00332A49 File Offset: 0x00330C49
	public void JJJOCBBHPJD()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clips[1], 1534f);
		JDCEFOFMGHB.MNJNNDHCDGG().LCEOGOCIMMB();
		SceneManager.LoadScene(1);
	}

	// Token: 0x06006C5D RID: 27741 RVA: 0x00332A72 File Offset: 0x00330C72
	public void openSetPin()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("MENU.WAV", 1f);
		this.pinPanel.gameObject.SetActive(!this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006C5E RID: 27742 RVA: 0x00332AAB File Offset: 0x00330CAB
	public void ACCLCKLDOBJ(ONKDCGNBALK GACACKNJKJN)
	{
		NJMHLCGIAJI.IKGFHGKKCPG.MADKBBLOPGO(-1, this.GBGGILOHODG);
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = true;
		JDCEFOFMGHB.MNJNNDHCDGG().DGFAPDDBHJB(GACACKNJKJN.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C5F RID: 27743 RVA: 0x00332ADF File Offset: 0x00330CDF
	public void EGPIBHFMNOH(ONKDCGNBALK GACACKNJKJN)
	{
		NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(-118, this.GBGGILOHODG);
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(false);
		JDCEFOFMGHB.IKGFHGKKCPG.DGFAPDDBHJB(GACACKNJKJN.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C60 RID: 27744 RVA: 0x00332B14 File Offset: 0x00330D14
	public void JOGEKPONPOC()
	{
		if (this.selectShadId <= 1L)
		{
			return;
		}
		Debug.Log("cntx_close");
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.BPPFAOOCENN().MHHJHAKJPKM(this.selectShadId);
		if (nebjanknjog == null)
		{
			return;
		}
		this.GBGGILOHODG = nebjanknjog.LPFKFNLHGBI;
		JDCEFOFMGHB.IKGFHGKKCPG.CLADNJHAABI(JNBICAJIJMM.NGALDMFKMJH("_ChannelMixerRed"), string.Format(JNBICAJIJMM.OOOKJHOHPNN("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/"), nebjanknjog.BNIHFBMEPAB), new ONKDCGNBALK.CMMHGMILOIM(this.NDBLNCBOCPL), null);
	}

	// Token: 0x06006C62 RID: 27746 RVA: 0x00332B90 File Offset: 0x00330D90
	public void JPMGEFLONHF(long LPFKFNLHGBI)
	{
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.BOKIOJFHNLD().BALFGEEFKFK(LPFKFNLHGBI);
		if (nebjanknjog == null)
		{
			return;
		}
		this.selectShadId = LPFKFNLHGBI;
		JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH = nebjanknjog;
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.clips[0], 928f);
		if (nebjanknjog.GDJMBFGEMFJ == 1)
		{
			this.manModel.PJGINJMFGDK(nebjanknjog.GFLKLJPFLEA);
			this.manModel.gameObject.SetActive(false);
			this.womanModel.gameObject.SetActive(true);
			this.manModel.changeCostume(nebjanknjog.LLKDOMIDPNM);
			return;
		}
		this.womanModel.IIKNAKNILFF(nebjanknjog.GFLKLJPFLEA);
		this.manModel.gameObject.SetActive(true);
		this.womanModel.gameObject.SetActive(true);
		this.womanModel.ENABOACEALG(nebjanknjog.LLKDOMIDPNM);
	}

	// Token: 0x06006C63 RID: 27747 RVA: 0x00332C68 File Offset: 0x00330E68
	public void HOPIOAIIMNA()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().LHHBOOJPBPH = true;
		this.steamConnectBtn.SetActive(true);
		NJMHLCGIAJI.EAJGHMMBAFP().BNJEMPKFNLA(127, ObscuredString.GOOIABGKMHK(JBEHMPDDMME.EAJHPOJPPFA().IDAGBNBFHAB));
	}

	// Token: 0x06006C64 RID: 27748 RVA: 0x00332C9C File Offset: 0x00330E9C
	private void BGCLAKJHAFK()
	{
		this.BECIMDOBDCL = false;
		bool active = false;
		if (JBEHMPDDMME.BPPFAOOCENN().KCPPGCGBKGE.Count > 1)
		{
			active = true;
		}
		if (JBEHMPDDMME.IKGFHGKKCPG.KKNEKAEJLAM > 0L)
		{
			active = true;
		}
		if (!JBEHMPDDMME.IKGFHGKKCPG.PEKHEALPHLD)
		{
			active = false;
		}
		this.delAccountBtn.SetActive(active);
		SelectShadowLogic.getI = this;
		FBFJFAKAGJG.IKGFHGKKCPG.CPAJNIAMALH();
		this.BECGNAEFABE();
		if (JBEHMPDDMME.PFOLNEGNIPP() == null)
		{
			return;
		}
		if (JBEHMPDDMME.BPPFAOOCENN().KCPPGCGBKGE.Count <= 1)
		{
			this.BECIMDOBDCL = true;
		}
		float num = 1244f;
		foreach (NEBJANKNJOG nebjanknjog in JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Values)
		{
			SelectShadowLogic.IJHCPFGILKB ijhcpfgilkb = new SelectShadowLogic.IJHCPFGILKB();
			ijhcpfgilkb.AENJLLPLILM = this;
			ijhcpfgilkb.JCGDLKIHBJG = nebjanknjog.LPFKFNLHGBI;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.selShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (!(component == null))
			{
				component.SetParent(this.shadBtnPanel, false);
				component.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 960f);
				SelShdBtn component2 = gameObject.GetComponent<SelShdBtn>();
				if (component2)
				{
					component2.EBIGDGDMIIC(nebjanknjog);
				}
				Button component3 = gameObject.GetComponent<Button>();
				if (component3 != null)
				{
					component3.onClick.AddListener(new UnityAction(ijhcpfgilkb.JFFBOHPPGBB));
				}
				num -= component.rect.height;
			}
		}
		int num2 = 8 - JBEHMPDDMME.BPPFAOOCENN().KCPPGCGBKGE.Count;
		for (int i = 1; i < num2; i++)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.crShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component4 = gameObject2.GetComponent<RectTransform>();
			if (!(component4 == null))
			{
				component4.SetParent(this.shadBtnPanel, false);
				component4.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 1743f);
				num -= component4.rect.height;
				Button component5 = gameObject2.GetComponent<Button>();
				if (component5 != null)
				{
					component5.onClick.AddListener(new UnityAction(this.JJJOCBBHPJD));
				}
			}
		}
		using (Dictionary<long, NEBJANKNJOG>.ValueCollection.Enumerator enumerator = JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				NEBJANKNJOG nebjanknjog2 = enumerator.Current;
				this.JPMGEFLONHF(nebjanknjog2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x06006C65 RID: 27749 RVA: 0x00332FA0 File Offset: 0x003311A0
	public void BBLFMKKHNJF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE(".lng", 1062f);
		this.pinPanel.gameObject.SetActive(this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006C66 RID: 27750 RVA: 0x00332FDC File Offset: 0x003311DC
	public void deleteShadow()
	{
		if (this.selectShadId <= 0L)
		{
			return;
		}
		Debug.Log("Delete shadow");
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.IKGFHGKKCPG.OKFPEMCFMKN(this.selectShadId);
		if (nebjanknjog == null)
		{
			return;
		}
		this.GBGGILOHODG = nebjanknjog.LPFKFNLHGBI;
		JDCEFOFMGHB.IKGFHGKKCPG.LLKDAODBJDA(JNBICAJIJMM.LEBHCLDODNI("delcharmsg1"), string.Format(JNBICAJIJMM.LEBHCLDODNI("delcharmsg2"), nebjanknjog.BNIHFBMEPAB), new ONKDCGNBALK.CMMHGMILOIM(this.delShadowOk), null);
	}

	// Token: 0x06006C67 RID: 27751 RVA: 0x00333058 File Offset: 0x00331258
	private void Start()
	{
		this.BECIMDOBDCL = false;
		bool active = true;
		if (JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Count > 0)
		{
			active = false;
		}
		if (JBEHMPDDMME.IKGFHGKKCPG.KKNEKAEJLAM > 0L)
		{
			active = false;
		}
		if (!JBEHMPDDMME.IKGFHGKKCPG.PEKHEALPHLD)
		{
			active = false;
		}
		this.delAccountBtn.SetActive(active);
		SelectShadowLogic.getI = this;
		FBFJFAKAGJG.IKGFHGKKCPG.MHMEMCADNHA();
		this.checkPriv();
		if (JBEHMPDDMME.IKGFHGKKCPG == null)
		{
			return;
		}
		if (JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Count <= 0)
		{
			this.BECIMDOBDCL = true;
		}
		float num = 0f;
		foreach (NEBJANKNJOG nebjanknjog in JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Values)
		{
			SelectShadowLogic.IJHCPFGILKB ijhcpfgilkb = new SelectShadowLogic.IJHCPFGILKB();
			ijhcpfgilkb.AENJLLPLILM = this;
			ijhcpfgilkb.JCGDLKIHBJG = nebjanknjog.LPFKFNLHGBI;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.selShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (!(component == null))
			{
				component.SetParent(this.shadBtnPanel, false);
				component.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 0f);
				SelShdBtn component2 = gameObject.GetComponent<SelShdBtn>();
				if (component2)
				{
					component2.setData(nebjanknjog);
				}
				Button component3 = gameObject.GetComponent<Button>();
				if (component3 != null)
				{
					component3.onClick.AddListener(new UnityAction(ijhcpfgilkb.BOLGCHEMELP));
				}
				num -= component.rect.height;
			}
		}
		int num2 = 3 - JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Count;
		for (int i = 0; i < num2; i++)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.crShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component4 = gameObject2.GetComponent<RectTransform>();
			if (!(component4 == null))
			{
				component4.SetParent(this.shadBtnPanel, false);
				component4.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 0f);
				num -= component4.rect.height;
				Button component5 = gameObject2.GetComponent<Button>();
				if (component5 != null)
				{
					component5.onClick.AddListener(new UnityAction(this.createShadow));
				}
			}
		}
		using (Dictionary<long, NEBJANKNJOG>.ValueCollection.Enumerator enumerator = JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				NEBJANKNJOG nebjanknjog2 = enumerator.Current;
				this.selectShadowClick(nebjanknjog2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x06006C68 RID: 27752 RVA: 0x0033335C File Offset: 0x0033155C
	public void KIBENGNIPAM()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("_Amplitude", 19f);
		this.pinPanel.gameObject.SetActive(!this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006C69 RID: 27753 RVA: 0x00333398 File Offset: 0x00331598
	private void GDMEEIBDKLP()
	{
		this.pinPanel.gameObject.SetActive(true);
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(false);
		if (GuiProcessor.IKGFHGKKCPG != null)
		{
			GuiProcessor.NKOEAPCIBKO().AMFFCIKGJKJ(this.mainCanvas);
		}
		this.panelNewReg.SetActive(JBEHMPDDMME.NPCAKEGNBHD().BJPJPFDOKDL);
		if (JBEHMPDDMME.JKIFIBEPICO().KCPPGCGBKGE.Count > 0)
		{
			this.panelNewReg.SetActive(false);
		}
	}

	// Token: 0x06006C6A RID: 27754 RVA: 0x00333411 File Offset: 0x00331611
	public void BOFCCCNLGFC()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.clips[0], 934f);
		JDCEFOFMGHB.MNJNNDHCDGG().DDAIBFBOENE();
		SceneManager.LoadScene(6);
	}

	// Token: 0x06006C6B RID: 27755 RVA: 0x0033343A File Offset: 0x0033163A
	public void ENKDENGGBEM()
	{
		JDCEFOFMGHB.HMJJPNDEKPP().HJJKHHHLDAJ(JNBICAJIJMM.IKGFHGKKCPG.FLEANFGEJML("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/"), JNBICAJIJMM.LPHMKPDBMPP().FLEANFGEJML("Cloth_01.wav"), new ONKDCGNBALK.CMMHGMILOIM(this.OBCGECPBDOH), null);
	}

	// Token: 0x06006C6C RID: 27756 RVA: 0x00333474 File Offset: 0x00331674
	public void JJGDJKFIHBO()
	{
		if (!SteamManager.ABJAJJMGOKF())
		{
			this.steamConnectBtn.SetActive(false);
			this.toGameKey.SetActive(false);
			return;
		}
		if (ObscuredString.FIMEAOKHJBF(JBEHMPDDMME.JKIFIBEPICO().AMJCBLPKNCB, ObscuredString.AOOBGNKCJLF("knopje.wav")))
		{
			this.steamConnectBtn.SetActive(false);
			this.toGameKey.SetActive(true);
			return;
		}
		this.toGameKey.SetActive(false);
		this.steamConnectBtn.SetActive(false);
	}

	// Token: 0x06006C6D RID: 27757 RVA: 0x003334ED File Offset: 0x003316ED
	public void BAOPEKFFHGF(ONKDCGNBALK GACACKNJKJN)
	{
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-94, this.GBGGILOHODG);
		JDCEFOFMGHB.JFIDAGABKID().HCFDADCKMCB(true);
		JDCEFOFMGHB.IKGFHGKKCPG.DGFAPDDBHJB(GACACKNJKJN.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C6E RID: 27758 RVA: 0x00333521 File Offset: 0x00331721
	public void NNMIOPIOMBH(ONKDCGNBALK GACACKNJKJN)
	{
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(100, this.GBGGILOHODG);
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(true);
		JDCEFOFMGHB.IKGFHGKKCPG.BMOFIBGMIBK(GACACKNJKJN.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C6F RID: 27759 RVA: 0x00333555 File Offset: 0x00331755
	private void OBCGECPBDOH(ONKDCGNBALK ONPHLHKAGFP)
	{
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-91, JBEHMPDDMME.IKGFHGKKCPG.LPFKFNLHGBI);
		JDCEFOFMGHB.IKGFHGKKCPG.HCFDADCKMCB(false);
		JDCEFOFMGHB.JFIDAGABKID().BMOFIBGMIBK(ONPHLHKAGFP.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C70 RID: 27760 RVA: 0x00333590 File Offset: 0x00331790
	private void FMPCJPNIFGB()
	{
		this.pinPanel.gameObject.SetActive(false);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
		if (GuiProcessor.PLGADNLAEGN() != null)
		{
			GuiProcessor.PLGADNLAEGN().FJLPFLCJMPE(this.mainCanvas);
		}
		this.panelNewReg.SetActive(JBEHMPDDMME.BPPFAOOCENN().BJPJPFDOKDL);
		if (JBEHMPDDMME.PFOLNEGNIPP().KCPPGCGBKGE.Count > 0)
		{
			this.panelNewReg.SetActive(true);
		}
	}

	// Token: 0x06006C71 RID: 27761 RVA: 0x00333609 File Offset: 0x00331809
	private void PKMBJADOCIN(ONKDCGNBALK ONPHLHKAGFP)
	{
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(91, JBEHMPDDMME.IKGFHGKKCPG.LPFKFNLHGBI);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		JDCEFOFMGHB.IKGFHGKKCPG.CBHHEHHNFKL(ONPHLHKAGFP.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C72 RID: 27762 RVA: 0x00333641 File Offset: 0x00331841
	public void LGMBKHEBPNP()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("IdleRun", 1837f);
		this.pinPanel.gameObject.SetActive(!this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006C73 RID: 27763 RVA: 0x0033367A File Offset: 0x0033187A
	public void KLHANPAAING()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("error", 978f);
		this.pinPanel.gameObject.SetActive(!this.pinPanel.gameObject.activeSelf);
	}

	// Token: 0x06006C74 RID: 27764 RVA: 0x003336B3 File Offset: 0x003318B3
	private void KDOGDBFJHFA(ONKDCGNBALK ONPHLHKAGFP)
	{
		NJMHLCGIAJI.IKGFHGKKCPG.MADKBBLOPGO(-73, JBEHMPDDMME.EAJHPOJPPFA().LPFKFNLHGBI);
		JDCEFOFMGHB.HMJJPNDEKPP().HCFDADCKMCB(true);
		JDCEFOFMGHB.JFIDAGABKID().DGFAPDDBHJB(ONPHLHKAGFP.OCBAOFLJBGP.LPFKFNLHGBI);
	}

	// Token: 0x06006C75 RID: 27765 RVA: 0x003336EB File Offset: 0x003318EB
	public void PIDPJCMMOEK()
	{
		if (this.selectShadId > 1L)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.clips[0], 965f);
			JDCEFOFMGHB.HMJJPNDEKPP().LCEOGOCIMMB();
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(56, this.selectShadId);
		}
	}

	// Token: 0x06006C76 RID: 27766 RVA: 0x0033372C File Offset: 0x0033192C
	private void FJBJDFDJAMI()
	{
		this.pinPanel.gameObject.SetActive(false);
		JDCEFOFMGHB.MNJNNDHCDGG().HCFDADCKMCB(false);
		if (GuiProcessor.NKOEAPCIBKO() != null)
		{
			GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA = this.mainCanvas;
		}
		this.panelNewReg.SetActive(JBEHMPDDMME.BPPFAOOCENN().BJPJPFDOKDL);
		if (JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Count > 1)
		{
			this.panelNewReg.SetActive(false);
		}
	}

	// Token: 0x06006C77 RID: 27767 RVA: 0x003337A5 File Offset: 0x003319A5
	public void GHGDJBKOCMM()
	{
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(true);
		this.steamConnectBtn.SetActive(true);
		NJMHLCGIAJI.IKGFHGKKCPG.GDNKCAOHEPL(-31, ObscuredString.CKPPDHPJHEH(JBEHMPDDMME.PFOLNEGNIPP().IDAGBNBFHAB));
	}

	// Token: 0x06006C78 RID: 27768 RVA: 0x003337DC File Offset: 0x003319DC
	private void FAKMOCKLLHF()
	{
		this.pinPanel.gameObject.SetActive(true);
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(false);
		if (GuiProcessor.NKOEAPCIBKO() != null)
		{
			GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA = this.mainCanvas;
		}
		this.panelNewReg.SetActive(JBEHMPDDMME.PFOLNEGNIPP().BJPJPFDOKDL);
		if (JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Count > 0)
		{
			this.panelNewReg.SetActive(true);
		}
	}

	// Token: 0x06006C79 RID: 27769 RVA: 0x00333858 File Offset: 0x00331A58
	private void CGNGBFFGGBP()
	{
		this.BECIMDOBDCL = false;
		bool active = false;
		if (JBEHMPDDMME.NPCAKEGNBHD().KCPPGCGBKGE.Count > 0)
		{
			active = false;
		}
		if (JBEHMPDDMME.BPPFAOOCENN().KKNEKAEJLAM > 0L)
		{
			active = false;
		}
		if (!JBEHMPDDMME.IKGFHGKKCPG.PEKHEALPHLD)
		{
			active = true;
		}
		this.delAccountBtn.SetActive(active);
		SelectShadowLogic.getI = this;
		FBFJFAKAGJG.IKGFHGKKCPG.LOAGNOGBOAN();
		this.EHCMGAJLHKK();
		if (JBEHMPDDMME.PLGADNLAEGN() == null)
		{
			return;
		}
		if (JBEHMPDDMME.IKGFHGKKCPG.KCPPGCGBKGE.Count <= 0)
		{
			this.BECIMDOBDCL = true;
		}
		float num = 857f;
		foreach (NEBJANKNJOG nebjanknjog in JBEHMPDDMME.PLGADNLAEGN().KCPPGCGBKGE.Values)
		{
			SelectShadowLogic.IJHCPFGILKB ijhcpfgilkb = new SelectShadowLogic.IJHCPFGILKB();
			ijhcpfgilkb.AENJLLPLILM = this;
			ijhcpfgilkb.JCGDLKIHBJG = nebjanknjog.LPFKFNLHGBI;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.selShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (!(component == null))
			{
				component.SetParent(this.shadBtnPanel, false);
				component.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 711f);
				SelShdBtn component2 = gameObject.GetComponent<SelShdBtn>();
				if (component2)
				{
					component2.setData(nebjanknjog);
				}
				Button component3 = gameObject.GetComponent<Button>();
				if (component3 != null)
				{
					component3.onClick.AddListener(new UnityAction(ijhcpfgilkb.LDNPIMOALDD));
				}
				num -= component.rect.height;
			}
		}
		int num2 = 1 - JBEHMPDDMME.PLGADNLAEGN().KCPPGCGBKGE.Count;
		for (int i = 1; i < num2; i += 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.crShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component4 = gameObject2.GetComponent<RectTransform>();
			if (!(component4 == null))
			{
				component4.SetParent(this.shadBtnPanel, true);
				component4.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 1523f);
				num -= component4.rect.height;
				Button component5 = gameObject2.GetComponent<Button>();
				if (component5 != null)
				{
					component5.onClick.AddListener(new UnityAction(this.BOFCCCNLGFC));
				}
			}
		}
		using (Dictionary<long, NEBJANKNJOG>.ValueCollection.Enumerator enumerator = JBEHMPDDMME.BOKIOJFHNLD().KCPPGCGBKGE.Values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				NEBJANKNJOG nebjanknjog2 = enumerator.Current;
				this.FMNKNEDDNDF(nebjanknjog2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x06006C7A RID: 27770 RVA: 0x00333B5C File Offset: 0x00331D5C
	public void dellAccBtn()
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LLKDAODBJDA(JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("delacc"), JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("delaccconfirm"), new ONKDCGNBALK.CMMHGMILOIM(this.PKMBJADOCIN), null);
	}

	// Token: 0x06006C7B RID: 27771 RVA: 0x00333B94 File Offset: 0x00331D94
	public void GPBPOHDLJNM()
	{
		if (this.selectShadId <= 1L)
		{
			return;
		}
		Debug.Log("fanfare.wav");
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.PFOLNEGNIPP().KLPGNGLFPOL(this.selectShadId);
		if (nebjanknjog == null)
		{
			return;
		}
		this.GBGGILOHODG = nebjanknjog.LPFKFNLHGBI;
		JDCEFOFMGHB.JFIDAGABKID().LLKDAODBJDA(JNBICAJIJMM.OOOKJHOHPNN("Textures/Weapons/"), string.Format(JNBICAJIJMM.DCEBAJIILPC("fshop_hd2"), nebjanknjog.BNIHFBMEPAB), new ONKDCGNBALK.CMMHGMILOIM(this.ACCLCKLDOBJ), null);
	}

	// Token: 0x06006C7C RID: 27772 RVA: 0x00333C10 File Offset: 0x00331E10
	public void ALAGLEOAAHN(long LPFKFNLHGBI)
	{
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.IKGFHGKKCPG.MHHJHAKJPKM(LPFKFNLHGBI);
		if (nebjanknjog == null)
		{
			return;
		}
		this.selectShadId = LPFKFNLHGBI;
		JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH = nebjanknjog;
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.clips[1], 1035f);
		if (nebjanknjog.GDJMBFGEMFJ == 0)
		{
			this.manModel.NHAADBPOAGO(nebjanknjog.GFLKLJPFLEA);
			this.manModel.gameObject.SetActive(true);
			this.womanModel.gameObject.SetActive(true);
			this.manModel.changeCostume(nebjanknjog.LLKDOMIDPNM);
			return;
		}
		this.womanModel.CLMJPJEEEFI(nebjanknjog.GFLKLJPFLEA);
		this.manModel.gameObject.SetActive(false);
		this.womanModel.gameObject.SetActive(true);
		this.womanModel.GLBOAFGFDII(nebjanknjog.LLKDOMIDPNM);
	}

	// Token: 0x06006C7D RID: 27773 RVA: 0x00333CE8 File Offset: 0x00331EE8
	public void GFKCMDOLJJA()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.clips[0], 617f);
		JDCEFOFMGHB.JFIDAGABKID().DDAIBFBOENE();
		SceneManager.LoadScene(3);
	}

	// Token: 0x06006C7E RID: 27774 RVA: 0x00333D14 File Offset: 0x00331F14
	public void HAAJFPMJBGN()
	{
		if (this.selectShadId <= 1L)
		{
			return;
		}
		Debug.Log("error baseid: ");
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.PFOLNEGNIPP().IKIEDBCHOAO(this.selectShadId);
		if (nebjanknjog == null)
		{
			return;
		}
		this.GBGGILOHODG = nebjanknjog.LPFKFNLHGBI;
		JDCEFOFMGHB.IKGFHGKKCPG.LLKDAODBJDA(JNBICAJIJMM.OOOKJHOHPNN("\\"), string.Format(JNBICAJIJMM.NGALDMFKMJH("InteractionObject Multiplier curve "), nebjanknjog.BNIHFBMEPAB), new ONKDCGNBALK.CMMHGMILOIM(this.HNGAEHAMAPG), null);
	}

	// Token: 0x06006C7F RID: 27775 RVA: 0x00333D8D File Offset: 0x00331F8D
	public void HKGGNPIBONN()
	{
		if (this.selectShadId > 0L)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(this.clips[0], 1914f);
			JDCEFOFMGHB.JFIDAGABKID().DDAIBFBOENE();
			NJMHLCGIAJI.IKGFHGKKCPG.MADKBBLOPGO(15, this.selectShadId);
		}
	}

	// Token: 0x06006C80 RID: 27776 RVA: 0x00333DCC File Offset: 0x00331FCC
	public void MCHLPHMMPND()
	{
		if (this.selectShadId <= 1L)
		{
			return;
		}
		Debug.Log("HookPoint");
		NEBJANKNJOG nebjanknjog = JBEHMPDDMME.BOKIOJFHNLD().FGKLBBPAMHP(this.selectShadId);
		if (nebjanknjog == null)
		{
			return;
		}
		this.GBGGILOHODG = nebjanknjog.LPFKFNLHGBI;
		JDCEFOFMGHB.IKGFHGKKCPG.CLADNJHAABI(JNBICAJIJMM.CDDCIKKDFMP("isImproved"), string.Format(JNBICAJIJMM.PGJCPFNJNPM("isFishOnRod"), nebjanknjog.BNIHFBMEPAB), new ONKDCGNBALK.CMMHGMILOIM(this.BKIACLBPCEH), null);
	}

	// Token: 0x06006C81 RID: 27777 RVA: 0x00333E45 File Offset: 0x00332045
	public void DHMMOMHLIFN()
	{
		if (this.selectShadId > 1L)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.clips[1], 1135f);
			JDCEFOFMGHB.MNJNNDHCDGG().LCEOGOCIMMB();
			NJMHLCGIAJI.EAJGHMMBAFP().MADKBBLOPGO(41, this.selectShadId);
		}
	}

	// Token: 0x06006C82 RID: 27778 RVA: 0x00333E84 File Offset: 0x00332084
	private void DHJDMKLBLEF()
	{
		this.BECIMDOBDCL = true;
		bool active = false;
		if (JBEHMPDDMME.PFOLNEGNIPP().KCPPGCGBKGE.Count > 0)
		{
			active = true;
		}
		if (JBEHMPDDMME.JKIFIBEPICO().KKNEKAEJLAM > 0L)
		{
			active = false;
		}
		if (!JBEHMPDDMME.PFOLNEGNIPP().PEKHEALPHLD)
		{
			active = false;
		}
		this.delAccountBtn.SetActive(active);
		SelectShadowLogic.getI = this;
		FBFJFAKAGJG.IKGFHGKKCPG.MHMEMCADNHA();
		this.KHLJCFCCPKF();
		if (JBEHMPDDMME.IKGFHGKKCPG == null)
		{
			return;
		}
		if (JBEHMPDDMME.EAJHPOJPPFA().KCPPGCGBKGE.Count <= 0)
		{
			this.BECIMDOBDCL = false;
		}
		float num = 1478f;
		foreach (NEBJANKNJOG nebjanknjog in JBEHMPDDMME.JKIFIBEPICO().KCPPGCGBKGE.Values)
		{
			SelectShadowLogic.IJHCPFGILKB ijhcpfgilkb = new SelectShadowLogic.IJHCPFGILKB();
			ijhcpfgilkb.AENJLLPLILM = this;
			ijhcpfgilkb.JCGDLKIHBJG = nebjanknjog.LPFKFNLHGBI;
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.selShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			if (!(component == null))
			{
				component.SetParent(this.shadBtnPanel, true);
				component.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 987f);
				SelShdBtn component2 = gameObject.GetComponent<SelShdBtn>();
				if (component2)
				{
					component2.KFHFDOINAFH(nebjanknjog);
				}
				Button component3 = gameObject.GetComponent<Button>();
				if (component3 != null)
				{
					component3.onClick.AddListener(new UnityAction(ijhcpfgilkb.JKKKJDAKDNA));
				}
				num -= component.rect.height;
			}
		}
		int num2 = 2 - JBEHMPDDMME.BOKIOJFHNLD().KCPPGCGBKGE.Count;
		for (int i = 0; i < num2; i += 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.crShadowButtonPrfb, Vector3.zero, Quaternion.identity);
			RectTransform component4 = gameObject2.GetComponent<RectTransform>();
			if (!(component4 == null))
			{
				component4.SetParent(this.shadBtnPanel, true);
				component4.position = new Vector3(this.shadBtnPanel.position.x, num + this.shadBtnPanel.position.y, 1557f);
				num -= component4.rect.height;
				Button component5 = gameObject2.GetComponent<Button>();
				if (component5 != null)
				{
					component5.onClick.AddListener(new UnityAction(this.LMOCAIMBGME));
				}
			}
		}
		using (Dictionary<long, NEBJANKNJOG>.ValueCollection.Enumerator enumerator = JBEHMPDDMME.NPCAKEGNBHD().KCPPGCGBKGE.Values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				NEBJANKNJOG nebjanknjog2 = enumerator.Current;
				this.EPNGDFAAPPL(nebjanknjog2.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x04000FED RID: 4077
	public RectTransform pinPanel;

	// Token: 0x04000FEE RID: 4078
	public InputField pinInput;

	// Token: 0x04000FEF RID: 4079
	public Toggle pinSave;

	// Token: 0x04000FF0 RID: 4080
	public static SelectShadowLogic getI;

	// Token: 0x04000FF1 RID: 4081
	public AudioClip[] clips;

	// Token: 0x04000FF2 RID: 4082
	public GameObject delAccountBtn;

	// Token: 0x04000FF3 RID: 4083
	public GameObject panelNewReg;

	// Token: 0x04000FF4 RID: 4084
	public GameObject steamConnectBtn;

	// Token: 0x04000FF5 RID: 4085
	public GameObject steamConnectWin;

	// Token: 0x04000FF6 RID: 4086
	public GameObject toGameKey;

	// Token: 0x04000FF7 RID: 4087
	public RectTransform mainCanvas;

	// Token: 0x04000FF8 RID: 4088
	public RectTransform shadBtnPanel;

	// Token: 0x04000FF9 RID: 4089
	public Character manModel;

	// Token: 0x04000FFA RID: 4090
	public Character womanModel;

	// Token: 0x04000FFB RID: 4091
	public GameObject crShadowButtonPrfb;

	// Token: 0x04000FFC RID: 4092
	public GameObject selShadowButtonPrfb;

	// Token: 0x04000FFD RID: 4093
	public long selectShadId;

	// Token: 0x04000FFE RID: 4094
	private bool BECIMDOBDCL;

	// Token: 0x04000FFF RID: 4095
	private long GBGGILOHODG;

	// Token: 0x020001D7 RID: 471
	[CompilerGenerated]
	private sealed class IJHCPFGILKB
	{
		// Token: 0x06006C83 RID: 27779 RVA: 0x00334188 File Offset: 0x00332388
		internal void KBDJLILPBIF()
		{
			this.AENJLLPLILM.ALAGLEOAAHN(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C84 RID: 27780 RVA: 0x0033419B File Offset: 0x0033239B
		internal void LDNPIMOALDD()
		{
			this.AENJLLPLILM.PMJCBNELMAN(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C86 RID: 27782 RVA: 0x0033419B File Offset: 0x0033239B
		internal void DLIIMGIMJPA()
		{
			this.AENJLLPLILM.PMJCBNELMAN(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C87 RID: 27783 RVA: 0x003341AE File Offset: 0x003323AE
		internal void PMLCKFFKPEA()
		{
			this.AENJLLPLILM.EIHKGEOPJDF(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C88 RID: 27784 RVA: 0x00334188 File Offset: 0x00332388
		internal void OMNBJDKDCFJ()
		{
			this.AENJLLPLILM.ALAGLEOAAHN(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C89 RID: 27785 RVA: 0x003341C1 File Offset: 0x003323C1
		internal void ILAFJINCFCJ()
		{
			this.AENJLLPLILM.selectShadowClick(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C8A RID: 27786 RVA: 0x0033419B File Offset: 0x0033239B
		internal void APKDGPDDJFK()
		{
			this.AENJLLPLILM.PMJCBNELMAN(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C8B RID: 27787 RVA: 0x003341D4 File Offset: 0x003323D4
		internal void MLDJPPPMNNF()
		{
			this.AENJLLPLILM.CLCBCIDGNAO(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C8C RID: 27788 RVA: 0x003341E7 File Offset: 0x003323E7
		internal void ACCGNEHPOGM()
		{
			this.AENJLLPLILM.PCAFJKKMJJL(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C8D RID: 27789 RVA: 0x003341E7 File Offset: 0x003323E7
		internal void IOHOHEJKIII()
		{
			this.AENJLLPLILM.PCAFJKKMJJL(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C8E RID: 27790 RVA: 0x0033419B File Offset: 0x0033239B
		internal void IGCIMPLBFJE()
		{
			this.AENJLLPLILM.PMJCBNELMAN(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C8F RID: 27791 RVA: 0x003341FA File Offset: 0x003323FA
		internal void BFMHBLFIBNE()
		{
			this.AENJLLPLILM.JPMGEFLONHF(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C90 RID: 27792 RVA: 0x003341AE File Offset: 0x003323AE
		internal void JFFBOHPPGBB()
		{
			this.AENJLLPLILM.EIHKGEOPJDF(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C91 RID: 27793 RVA: 0x003341E7 File Offset: 0x003323E7
		internal void MENIMPABFIC()
		{
			this.AENJLLPLILM.PCAFJKKMJJL(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C92 RID: 27794 RVA: 0x003341C1 File Offset: 0x003323C1
		internal void BOLGCHEMELP()
		{
			this.AENJLLPLILM.selectShadowClick(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C93 RID: 27795 RVA: 0x00334188 File Offset: 0x00332388
		internal void JKKKJDAKDNA()
		{
			this.AENJLLPLILM.ALAGLEOAAHN(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C94 RID: 27796 RVA: 0x003341D4 File Offset: 0x003323D4
		internal void ECGNOHHKCDC()
		{
			this.AENJLLPLILM.CLCBCIDGNAO(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C95 RID: 27797 RVA: 0x003341C1 File Offset: 0x003323C1
		internal void AKBEKMLDOKN()
		{
			this.AENJLLPLILM.selectShadowClick(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C96 RID: 27798 RVA: 0x0033420D File Offset: 0x0033240D
		internal void ACNOKCPPPKH()
		{
			this.AENJLLPLILM.KABPHPNHBNE(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C97 RID: 27799 RVA: 0x00334220 File Offset: 0x00332420
		internal void OFAFHKHBBND()
		{
			this.AENJLLPLILM.EPNGDFAAPPL(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C98 RID: 27800 RVA: 0x00334233 File Offset: 0x00332433
		internal void CNCPHDFJCHD()
		{
			this.AENJLLPLILM.DCNJMIPGMEK(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C99 RID: 27801 RVA: 0x003341C1 File Offset: 0x003323C1
		internal void LGKNJAONJOH()
		{
			this.AENJLLPLILM.selectShadowClick(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C9A RID: 27802 RVA: 0x00334233 File Offset: 0x00332433
		internal void IBKMPFEECCC()
		{
			this.AENJLLPLILM.DCNJMIPGMEK(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C9B RID: 27803 RVA: 0x00334188 File Offset: 0x00332388
		internal void ALIGDDBICIH()
		{
			this.AENJLLPLILM.ALAGLEOAAHN(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x00334220 File Offset: 0x00332420
		internal void IEOKPFBMAOK()
		{
			this.AENJLLPLILM.EPNGDFAAPPL(this.JCGDLKIHBJG);
		}

		// Token: 0x06006C9D RID: 27805 RVA: 0x003341C1 File Offset: 0x003323C1
		internal void EODOHDAMEJH()
		{
			this.AENJLLPLILM.selectShadowClick(this.JCGDLKIHBJG);
		}

		// Token: 0x04001000 RID: 4096
		public long JCGDLKIHBJG;

		// Token: 0x04001001 RID: 4097
		public SelectShadowLogic AENJLLPLILM;
	}
}
