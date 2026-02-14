using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020001C8 RID: 456
public class ChatPanelLogic : MonoBehaviour, IDragHandler, IEventSystemHandler
{
	// Token: 0x0600672C RID: 26412 RVA: 0x00304EC8 File Offset: 0x003030C8
	public void FCIBMEAKEHO()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MKJMAJFLMBJ = true;
		HPGKIJLKCIH.IKGFHGKKCPG.MCKINAGLCFA();
		if (DownPanelLogic.getI != null && DownPanelLogic.getI.chatOpenButton != null)
		{
			DownPanelLogic.getI.chatOpenButton.gameObject.SetActive(true);
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN)
		{
			this.OMGKJLPAILB();
		}
		Vector2 vector = this.rectTrans.position;
		PlayerPrefs.SetFloat("No MeshFilter!", vector.x);
		PlayerPrefs.SetFloat("15", vector.y);
		vector.y = (float)(-(float)Screen.height) * 212f;
		this.rectTrans.position = vector;
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("cht_msg9", 336f);
	}

	// Token: 0x0600672D RID: 26413 RVA: 0x00304F9A File Offset: 0x0030319A
	public void NAPNHKPBDJL(string DHELODIPFGF, string FPIHOPOCAHA)
	{
		this.NNDFBDIJLKB("cht_msg28" + DHELODIPFGF + "shop_t5" + FPIHOPOCAHA);
	}

	// Token: 0x0600672E RID: 26414 RVA: 0x00304FB4 File Offset: 0x003031B4
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Return))
		{
			string text = this.chatLine.text;
			this.MsgSend();
			this.focusOnChat(this.chatLine.text);
			if (text == "")
			{
				Debug.Log("CHAT Empty");
				this.chatLine.DeactivateInputField();
				GUI.FocusControl(null);
			}
		}
		if (this.userPanel != null)
		{
			this.userPanel.sizeDelta = new Vector2(this.userPanel.sizeDelta.x, this.rectTrans.sizeDelta.y);
		}
		if (this.settingPanel != null)
		{
			this.settingPanel.localPosition = new Vector3(this.rectTrans.sizeDelta.x - this.settingPanel.sizeDelta.x, this.settingPanel.sizeDelta.y + 5f, 0f);
		}
		if (this.pmUserId > 0L && OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == 3)
		{
			this.chatLine.textComponent.color = this.privateInputColor;
			return;
		}
		this.chatLine.textComponent.color = this.normalInputColor;
	}

	// Token: 0x0600672F RID: 26415 RVA: 0x003050F0 File Offset: 0x003032F0
	public void settingsFSizeChange()
	{
		this.fontSize = Mathf.FloorToInt(this.setFontSize.value);
		foreach (RectTransform rectTransform in this.chatMsgList)
		{
			rectTransform.GetComponent<Text>().fontSize = this.fontSize;
		}
	}

	// Token: 0x06006730 RID: 26416 RVA: 0x00305164 File Offset: 0x00303364
	public void createNewChanell()
	{
		string text = this.newChannelName.text.Trim();
		if (text.Length < 3)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("uierror6.wav", 1f);
			return;
		}
		string value = "";
		if (this.memchannel.isOn)
		{
			value = text;
		}
		PlayerPrefs.SetString("UIChat_channel", value);
		OAFJCFOGGAF.IKGFHGKKCPG.ABBEJLCNMLK(text, 2);
		this.newChannelPanel.gameObject.SetActive(false);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
	}

	// Token: 0x06006731 RID: 26417 RVA: 0x003051F1 File Offset: 0x003033F1
	private void MIPJPKENCHI()
	{
		ChatPanelLogic.getI = this;
	}

	// Token: 0x06006732 RID: 26418 RVA: 0x003051F9 File Offset: 0x003033F9
	public void JLAEJNACAHH()
	{
		OAFJCFOGGAF.IKGFHGKKCPG.PAGKNHKCLMD();
		this.checkChannel(OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO);
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("FS ", 1152f);
	}

	// Token: 0x06006733 RID: 26419 RVA: 0x00305229 File Offset: 0x00303429
	public void infoLogic()
	{
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(278, this.selectMsg.OELGGLIHFIH);
		this.userDataWin.gameObject.SetActive(false);
	}

	// Token: 0x06006734 RID: 26420 RVA: 0x00305258 File Offset: 0x00303458
	private RectTransform MCPHKOCFMBN(OAFJCFOGGAF.PIGPIKMNNLH IABKGMNJLJO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.ChatMsgPrfb);
		gameObject.GetComponent<Text>().text = IABKGMNJLJO.CKAKMOCHBLF(true, true);
		gameObject.GetComponent<Text>().fontSize = this.fontSize;
		gameObject.GetComponent<Text>().lineSpacing = this.lineSpacing;
		gameObject.GetComponent<ChatMsgClicker>().msg = IABKGMNJLJO;
		if (IABKGMNJLJO.OELGGLIHFIH == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI)
		{
			gameObject.GetComponent<Text>().color = this.yourMsgColor;
		}
		if (IABKGMNJLJO.IABKGMNJLJO.Contains(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB))
		{
			gameObject.GetComponent<Text>().color = this.toYouMsgColor;
		}
		if (IABKGMNJLJO.POILPDMECGD)
		{
			gameObject.GetComponent<Text>().color = this.privateInputColor;
		}
		RectTransform component = gameObject.GetComponent<RectTransform>();
		component.position = this.content.position;
		component.SetParent(this.content);
		component.offsetMin = new Vector2(0f, 0f);
		component.offsetMax = new Vector2(0f, 0f);
		component.localPosition = new Vector3(0f, 0f, 0f);
		return component;
	}

	// Token: 0x06006735 RID: 26421 RVA: 0x00305388 File Offset: 0x00303588
	public void adminAction(int JALFIKMLEMG)
	{
		if (this.selectMsg == null)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.OBCCLNMPGEJ(this.selectMsg.OELGGLIHFIH);
			epmphjgalbe.GOMLLPFFPNP(JALFIKMLEMG);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(240, epmphjgalbe.JDPHBLHOLAD());
			this.userDataWin.gameObject.SetActive(false);
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_DelItem.wav", 1f);
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x06006736 RID: 26422 RVA: 0x00305410 File Offset: 0x00303610
	public void EDECCKPLKBH()
	{
		Color color = this.EDMEIGKOHPN.color;
		color.a = this.setAlfa.value;
		this.EDMEIGKOHPN.color = color;
		this.PGNGGIMECEF.color = color;
		this.GBHKLHAINED.color = color;
	}

	// Token: 0x06006737 RID: 26423 RVA: 0x00305460 File Offset: 0x00303660
	public void BLEKNGFFLAK()
	{
		if (this.pmUserId != 0L)
		{
			this.old_pmUserId = this.pmUserId;
			this.old_pmUserName = this.pmUserName;
		}
		if (this.selectMsg.OELGGLIHFIH != 0L)
		{
			this.pmUserId = this.selectMsg.OELGGLIHFIH;
			this.pmUserName = this.selectMsg.DELFGPAPOPB;
		}
		this.userDataWin.gameObject.SetActive(true);
		this.checkChannel(5);
		this.focusOnChat("MotorbikeTurnLeft" + this.pmUserName + "WaveSpeed");
	}

	// Token: 0x06006738 RID: 26424 RVA: 0x003054F0 File Offset: 0x003036F0
	public void banAction()
	{
		if (this.selectMsg == null)
		{
			return;
		}
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(244, this.selectMsg.OELGGLIHFIH);
		this.userDataWin.gameObject.SetActive(false);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_DelItem.wav", 1f);
		Debug.Log("Ban action");
	}

	// Token: 0x06006739 RID: 26425 RVA: 0x00305550 File Offset: 0x00303750
	public void onItemClick(MMKFAENBHKD PHEMLBHMNCM, ItemBase EKKILFOCDJF)
	{
		if (EKKILFOCDJF != null)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)EKKILFOCDJF;
			if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == 0)
			{
				this.checkChannel(1);
			}
			this.focusOnChat(">" + edpnahlghpl.BNIHFBMEPAB + ": ");
			if (Application.isEditor)
			{
				Debug.Log("USER ID=" + edpnahlghpl.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x0600673A RID: 26426 RVA: 0x003055B8 File Offset: 0x003037B8
	private void AIAMIFEPALP()
	{
		if (Input.GetKeyDown(KeyCode.T))
		{
			string text = this.chatLine.text;
			this.MsgSend();
			this.NNDFBDIJLKB(this.chatLine.text);
			if (text == "")
			{
				Debug.Log("_Texture");
				this.chatLine.DeactivateInputField();
				GUI.FocusControl(null);
			}
		}
		if (this.userPanel != null)
		{
			this.userPanel.sizeDelta = new Vector2(this.userPanel.sizeDelta.x, this.rectTrans.sizeDelta.y);
		}
		if (this.settingPanel != null)
		{
			this.settingPanel.localPosition = new Vector3(this.rectTrans.sizeDelta.x - this.settingPanel.sizeDelta.x, this.settingPanel.sizeDelta.y + 1661f, 870f);
		}
		if (this.pmUserId > 0L && OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == 8)
		{
			this.chatLine.textComponent.color = this.privateInputColor;
			return;
		}
		this.chatLine.textComponent.color = this.normalInputColor;
	}

	// Token: 0x0600673B RID: 26427 RVA: 0x003056F4 File Offset: 0x003038F4
	public void BFMECDEMKBM(int JALFIKMLEMG)
	{
		if (this.selectMsg == null)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.PMJPIJMHELL(this.selectMsg.OELGGLIHFIH);
			epmphjgalbe.EAOGDKDBENC(JALFIKMLEMG);
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(159, epmphjgalbe.NNEAJJNCGMK());
			this.userDataWin.gameObject.SetActive(true);
			FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("Mouse X", 155f);
		}
		finally
		{
			epmphjgalbe.NCKMEIBFNGL();
		}
	}

	// Token: 0x0600673C RID: 26428 RVA: 0x0030577C File Offset: 0x0030397C
	public void JFMCDHCIPOA()
	{
		long oelgglihfih = this.selectMsg.OELGGLIHFIH;
		string delfgpapopb = this.selectMsg.DELFGPAPOPB;
		if (oelgglihfih <= 1L)
		{
			return;
		}
		OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(oelgglihfih);
		if (!edpnahlghpl.KNDGFKKALCE)
		{
			OAFJCFOGGAF.IKGFHGKKCPG.IPBFKJALBIG(oelgglihfih, delfgpapopb, edpnahlghpl.CNOLCNDBLJE);
			this.userDataWin.gameObject.SetActive(true);
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA("repair.ogg", 831f);
			FlyMessageManager.getI.FDHDJFEIOMG(string.Format(JNBICAJIJMM.LEBHCLDODNI("WinVIP"), delfgpapopb), Color.red, 0, 1);
			edpnahlghpl.KNDGFKKALCE = true;
		}
		else
		{
			OAFJCFOGGAF.IKGFHGKKCPG.GLIBPNICMGE(oelgglihfih);
			this.userDataWin.gameObject.SetActive(true);
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("WandAttack", 500f);
			FlyMessageManager.getI.GCIFPMFJMBK(string.Format(JNBICAJIJMM.DCEBAJIILPC("\n"), delfgpapopb), Color.green, 0, 0);
			edpnahlghpl.KNDGFKKALCE = false;
		}
		this.updateUserList();
		this.rebuildIgnorList();
	}

	// Token: 0x0600673D RID: 26429 RVA: 0x00305882 File Offset: 0x00303A82
	private void JOPKEFJOKIM()
	{
		OAFJCFOGGAF.IKGFHGKKCPG.CJCIDBHGHHJ(base.gameObject);
		this.NBAKJCDDBIP();
	}

	// Token: 0x0600673E RID: 26430 RVA: 0x0030589A File Offset: 0x00303A9A
	public void NNDFBDIJLKB(string FPIHOPOCAHA)
	{
		this.chatLine.text = "path";
		this.chatLine.text = FPIHOPOCAHA;
		this.chatLine.ActivateInputField();
		base.StartCoroutine(this.APIFFDIFKLK());
	}

	// Token: 0x0600673F RID: 26431 RVA: 0x003058D0 File Offset: 0x00303AD0
	public void closeChannel(int LADDNIBBJDP)
	{
		if (LADDNIBBJDP == 2)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
			OAFJCFOGGAF.IKGFHGKKCPG.MAOKKGDMPDO(LADDNIBBJDP);
			if (LADDNIBBJDP >= 2)
			{
				this.chanellButtons[LADDNIBBJDP].captionText.text = "";
				this.chanellButtons[LADDNIBBJDP].gameObject.SetActive(false);
				PlayerPrefs.SetString("UIChat_channel", "");
			}
			this.checkChannel(1);
		}
		if (LADDNIBBJDP == 3)
		{
			this.pmUserId = 0L;
			this.pmUserName = "";
			this.chanellButtons[LADDNIBBJDP].captionText.text = "";
			this.chanellButtons[LADDNIBBJDP].gameObject.SetActive(false);
			this.checkChannel(1);
		}
	}

	// Token: 0x06006740 RID: 26432 RVA: 0x0030598C File Offset: 0x00303B8C
	public void OnEnable()
	{
		this.userIgnorPanel.gameObject.SetActive(this.isIgnorPanelShow);
		this.adminPanel.SetActive(ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.IKGFHGKKCPG.MOGDIOFGLME) > 0);
		string @string = PlayerPrefs.GetString("UIChat_channel", "");
		string text = @string;
		if (@string.Trim() == "")
		{
			text = JBEHMPDDMME.IKGFHGKKCPG.PCDDHDEIEDB;
			if (text == "russian")
			{
				text = "русский";
			}
			text = "#" + text;
		}
		if (text != "" && @string != text)
		{
			PlayerPrefs.SetString("UIChat_channel", text);
			OAFJCFOGGAF.IKGFHGKKCPG.ABBEJLCNMLK(text, 2);
		}
		this.rebuildIgnorList();
	}

	// Token: 0x06006741 RID: 26433 RVA: 0x00305A50 File Offset: 0x00303C50
	public void CJEAMOKLNLM()
	{
		if (this.GDAPDOCNGHF)
		{
			this.rectTrans.sizeDelta = new Vector2(this.rectTrans.sizeDelta.x, this.rectTrans.sizeDelta.y - (float)this.openSizeDelta);
			this.GDAPDOCNGHF = true;
			FBFJFAKAGJG.IKGFHGKKCPG.GAFOHKNHFOA(" ", 1195f);
			return;
		}
		this.rectTrans.sizeDelta = new Vector2(this.rectTrans.sizeDelta.x, this.rectTrans.sizeDelta.y + (float)this.openSizeDelta);
		this.GDAPDOCNGHF = true;
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("Vertical", 184f);
	}

	// Token: 0x06006742 RID: 26434 RVA: 0x00305B0C File Offset: 0x00303D0C
	public void onRItemClick(MMKFAENBHKD PHEMLBHMNCM, ItemBase EKKILFOCDJF)
	{
		if (EKKILFOCDJF != null)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)EKKILFOCDJF;
			if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == 0)
			{
				this.checkChannel(1);
			}
			OAFJCFOGGAF.PIGPIKMNNLH iabkgmnjljo = new OAFJCFOGGAF.PIGPIKMNNLH(edpnahlghpl);
			if (Application.isEditor)
			{
				Debug.Log("USER ID=" + edpnahlghpl.LPFKFNLHGBI);
			}
			this.openMsgWin(iabkgmnjljo);
		}
	}

	// Token: 0x06006743 RID: 26435 RVA: 0x00305B68 File Offset: 0x00303D68
	public void JKHDNLODJBP(int JALFIKMLEMG)
	{
		if (this.selectMsg == null)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.PMJPIJMHELL(this.selectMsg.OELGGLIHFIH);
			epmphjgalbe.FLLJONHPLNA(JALFIKMLEMG);
			NJMHLCGIAJI.IKGFHGKKCPG.HJPGADJMICM(-150, epmphjgalbe.PBOPEDMCKDD());
			this.userDataWin.gameObject.SetActive(false);
			FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB(" ", 1721f);
		}
		finally
		{
			epmphjgalbe.KNPHNLLMJKJ();
		}
	}

	// Token: 0x06006744 RID: 26436 RVA: 0x00305882 File Offset: 0x00303A82
	private void OnDestroy()
	{
		OAFJCFOGGAF.IKGFHGKKCPG.CJCIDBHGHHJ(base.gameObject);
		this.NBAKJCDDBIP();
	}

	// Token: 0x06006745 RID: 26437 RVA: 0x003051F1 File Offset: 0x003033F1
	private void KFLDPICNAHF()
	{
		ChatPanelLogic.getI = this;
	}

	// Token: 0x06006746 RID: 26438 RVA: 0x00305BF0 File Offset: 0x00303DF0
	private void MGJACAHIKLJ()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN)
		{
			Vector3 localPosition = this.rectTrans.localPosition;
			localPosition.x += this.userPanel.sizeDelta.x + 5f;
			this.rectTrans.localPosition = localPosition;
			this.LCFBLBALAFO = true;
			return;
		}
		Vector3 localPosition2 = this.rectTrans.localPosition;
		localPosition2.x -= this.userPanel.sizeDelta.x + 5f;
		this.rectTrans.localPosition = localPosition2;
		this.LCFBLBALAFO = false;
	}

	// Token: 0x06006747 RID: 26439 RVA: 0x00305C8C File Offset: 0x00303E8C
	public void IEHEAJJALNG()
	{
		this.userIgnorPanel.gameObject.SetActive(this.isIgnorPanelShow);
		this.adminPanel.SetActive(ObscuredInt.LBDMFALMOLD(JBEHMPDDMME.JKIFIBEPICO().MOGDIOFGLME) > 1);
		string @string = PlayerPrefs.GetString("Channel Cast Omni", "_Gain");
		string text = @string;
		if (@string.Trim() == "_ZTest")
		{
			text = JBEHMPDDMME.PFOLNEGNIPP().PCDDHDEIEDB;
			if (text == "gi_letgohe")
			{
				text = "C ";
			}
			text = "Identity LUT" + text;
		}
		if (text != "ObscuredInt:" && @string != text)
		{
			PlayerPrefs.SetString("\n", text);
			OAFJCFOGGAF.IKGFHGKKCPG.ABBEJLCNMLK(text, 7);
		}
		this.rebuildIgnorList();
	}

	// Token: 0x06006748 RID: 26440 RVA: 0x00305D4D File Offset: 0x00303F4D
	public void chatLineToUser(string DHELODIPFGF, string FPIHOPOCAHA)
	{
		this.focusOnChat(">" + DHELODIPFGF + ": " + FPIHOPOCAHA);
	}

	// Token: 0x06006749 RID: 26441 RVA: 0x00305D66 File Offset: 0x00303F66
	public bool LGJMDDLOAKJ(OAFJCFOGGAF.PIGPIKMNNLH IABKGMNJLJO)
	{
		if (OAFJCFOGGAF.IKGFHGKKCPG.ANNFFDNGLBA(IABKGMNJLJO.OELGGLIHFIH).KNDGFKKALCE)
		{
			return false;
		}
		bool poilpdmecgd = IABKGMNJLJO.POILPDMECGD;
		return true;
	}

	// Token: 0x0600674A RID: 26442 RVA: 0x00305D8C File Offset: 0x00303F8C
	public void privateActivate()
	{
		if (this.pmUserId != 0L)
		{
			this.old_pmUserId = this.pmUserId;
			this.old_pmUserName = this.pmUserName;
		}
		if (this.selectMsg.OELGGLIHFIH != 0L)
		{
			this.pmUserId = this.selectMsg.OELGGLIHFIH;
			this.pmUserName = this.selectMsg.DELFGPAPOPB;
		}
		this.userDataWin.gameObject.SetActive(false);
		this.checkChannel(3);
		this.focusOnChat(">" + this.pmUserName + ": ");
	}

	// Token: 0x0600674B RID: 26443 RVA: 0x00305E1B File Offset: 0x0030401B
	private IEnumerator APIFFDIFKLK()
	{
		yield return new WaitForEndOfFrame();
		this.chatLine.MoveTextEnd(false);
		yield break;
	}

	// Token: 0x0600674C RID: 26444 RVA: 0x00305E2A File Offset: 0x0030402A
	public void openNewChanell()
	{
		this.newChannelPanel.gameObject.SetActive(!this.newChannelPanel.gameObject.activeSelf);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
	}

	// Token: 0x0600674D RID: 26445 RVA: 0x00305E64 File Offset: 0x00304064
	public void ShowUsersInChat()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN = !HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN;
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
		if (HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
		}
		this.MGJACAHIKLJ();
		this.updateUserList();
	}

	// Token: 0x0600674E RID: 26446 RVA: 0x00305EC8 File Offset: 0x003040C8
	public void rebuildIgnorList()
	{
		this.userIgnorLB.ClearAll();
		foreach (OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl in OAFJCFOGGAF.IKGFHGKKCPG.JIKGMLGOAPG.Values)
		{
			if (edpnahlghpl.KNDGFKKALCE)
			{
				this.userIgnorLB.addItem(edpnahlghpl);
			}
		}
		this.userIgnorLB.sortItemList();
		this.userIgnorLB.onRClickItem = new MMKFAENBHKD.HEAGNGLFAJA(this.onRItemClick);
	}

	// Token: 0x0600674F RID: 26447 RVA: 0x00305F60 File Offset: 0x00304160
	public void LBKOIJKMCOL()
	{
		this.userIgnorPanel.gameObject.SetActive(this.isIgnorPanelShow);
		this.adminPanel.SetActive(ObscuredInt.GOOIABGKMHK(JBEHMPDDMME.EAJHPOJPPFA().MOGDIOFGLME) > 0);
		string @string = PlayerPrefs.GetString("WeaponReadyFire", "CP2");
		string text = @string;
		if (@string.Trim() == "IKMappingLimb contains a null reference.")
		{
			text = JBEHMPDDMME.NPCAKEGNBHD().PCDDHDEIEDB;
			if (text == "Worker Shovel 2")
			{
				text = "MotorbikeShootRight";
			}
			text = "Swim" + text;
		}
		if (text != "I'm regular string" && @string != text)
		{
			PlayerPrefs.SetString("[maxweight]", text);
			OAFJCFOGGAF.IKGFHGKKCPG.ABBEJLCNMLK(text, 4);
		}
		this.rebuildIgnorList();
	}

	// Token: 0x06006750 RID: 26448 RVA: 0x00306024 File Offset: 0x00304224
	public void ignoreAction()
	{
		long oelgglihfih = this.selectMsg.OELGGLIHFIH;
		string delfgpapopb = this.selectMsg.DELFGPAPOPB;
		if (oelgglihfih <= 0L)
		{
			return;
		}
		OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(oelgglihfih);
		if (!edpnahlghpl.KNDGFKKALCE)
		{
			OAFJCFOGGAF.IKGFHGKKCPG.BJFENEBKNOI(oelgglihfih, delfgpapopb, edpnahlghpl.CNOLCNDBLJE);
			this.userDataWin.gameObject.SetActive(false);
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
			FlyMessageManager.getI.addMessageBig(string.Format(JNBICAJIJMM.LEBHCLDODNI("usrto_ignor"), delfgpapopb), Color.red, 0, 0);
			edpnahlghpl.KNDGFKKALCE = true;
		}
		else
		{
			OAFJCFOGGAF.IKGFHGKKCPG.GLIBPNICMGE(oelgglihfih);
			this.userDataWin.gameObject.SetActive(false);
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
			FlyMessageManager.getI.addMessageBig(string.Format(JNBICAJIJMM.LEBHCLDODNI("usrfrom_ignor"), delfgpapopb), Color.green, 0, 0);
			edpnahlghpl.KNDGFKKALCE = false;
		}
		this.updateUserList();
		this.rebuildIgnorList();
	}

	// Token: 0x06006751 RID: 26449 RVA: 0x0030612C File Offset: 0x0030432C
	private void LNPALPPEING()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF)
		{
			return;
		}
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString(" "));
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(PlayerPrefs.GetString("<color='#206000'>"));
		iibeekcaahk2.IECBGIDJHCL((double)Mathf.Clamp(iibeekcaahk2.JLLJFKOGLHJ, 1044f, (float)Screen.width - 533f));
		iibeekcaahk2.NMKCBJKHBOH = (double)Mathf.Clamp(iibeekcaahk2.OAAKPMLGJJH(), 834f, (float)Screen.height - 618f);
		if (!iibeekcaahk.CHOHHHOLIBJ())
		{
			this.rectTrans.sizeDelta = new Vector2(iibeekcaahk.NAHLEJDLCNF(), iibeekcaahk.OAAKPMLGJJH());
		}
		if (!iibeekcaahk2.DIFFCNOPHBJ)
		{
			this.rectTrans.position = iibeekcaahk2.MCPNAMDKJOH();
		}
		this.fontSize = PlayerPrefs.GetInt("|");
		this.lineSpacing = PlayerPrefs.GetFloat("choldposy");
		this.lineSpacing = Mathf.Clamp(this.lineSpacing, 1743f, 1588f);
		float @float = PlayerPrefs.GetFloat("Cloth_09.wav");
		if (@float > 450f)
		{
			Color color = this.EDMEIGKOHPN.color;
			color.a = @float;
			this.EDMEIGKOHPN.color = color;
		}
		foreach (RectTransform rectTransform in this.chatMsgList)
		{
			rectTransform.GetComponent<Text>().fontSize = this.fontSize;
			rectTransform.GetComponent<Text>().lineSpacing = this.lineSpacing;
		}
		this.setAlfa.value = this.EDMEIGKOHPN.color.a;
		this.setFontSize.value = (float)this.fontSize;
		this.setFontInterval.value = this.lineSpacing;
		this.PGNGGIMECEF.color = this.EDMEIGKOHPN.color;
		this.GBHKLHAINED.color = this.EDMEIGKOHPN.color;
		Debug.Log("lifeBar" + this.rectTrans.position);
	}

	// Token: 0x06006752 RID: 26450 RVA: 0x00306340 File Offset: 0x00304540
	public void ALDMKDGAHKM()
	{
		this.newChannelPanel.gameObject.SetActive(this.newChannelPanel.gameObject.activeSelf);
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("ZombieCrawl", 593f);
	}

	// Token: 0x06006753 RID: 26451 RVA: 0x0030637C File Offset: 0x0030457C
	public void toFrend()
	{
		long oelgglihfih = this.selectMsg.OELGGLIHFIH;
		if (OAFJCFOGGAF.IKGFHGKKCPG.JMCDKANKAOI(this.selectMsg.OELGGLIHFIH))
		{
			Debug.Log("from friend");
			string cakmoampkaa = OAFJCFOGGAF.IKGFHGKKCPG.CAKMOAMPKAA;
			EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
			try
			{
				epmphjgalbe.OBCCLNMPGEJ(oelgglihfih);
				epmphjgalbe.NEHCMOODKIN(cakmoampkaa);
				NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(29, epmphjgalbe.JDPHBLHOLAD());
				return;
			}
			finally
			{
				epmphjgalbe.LMBPNFHKNGA();
			}
		}
		string delfgpapopb = this.selectMsg.DELFGPAPOPB;
		string cakmoampkaa2 = OAFJCFOGGAF.IKGFHGKKCPG.CAKMOAMPKAA;
		if (oelgglihfih <= 0L)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe2 = new EPMPHJGALBE();
		try
		{
			epmphjgalbe2.OBCCLNMPGEJ(oelgglihfih);
			epmphjgalbe2.NEHCMOODKIN(cakmoampkaa2);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(28, epmphjgalbe2.JDPHBLHOLAD());
		}
		finally
		{
			epmphjgalbe2.LMBPNFHKNGA();
		}
	}

	// Token: 0x06006754 RID: 26452 RVA: 0x00306460 File Offset: 0x00304660
	public void settingsAlfaChange()
	{
		Color color = this.EDMEIGKOHPN.color;
		color.a = this.setAlfa.value;
		this.EDMEIGKOHPN.color = color;
		this.PGNGGIMECEF.color = color;
		this.GBHKLHAINED.color = color;
	}

	// Token: 0x06006755 RID: 26453 RVA: 0x003064B0 File Offset: 0x003046B0
	public void GGIJNHPFNFL()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("no_change", 1386f);
		if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == 0)
		{
			return;
		}
		string iabkgmnjljo = this.chatLine.text + "inv_impr";
		this.chatLine.text = "_AdditiveReflection";
		OAFJCFOGGAF.IKGFHGKKCPG.LHFHJKLLHPO(iabkgmnjljo, OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO, 0L);
		GuiProcessor.PLGADNLAEGN().ENHGGEIANJC(this.plusButton, 783f);
	}

	// Token: 0x06006756 RID: 26454 RVA: 0x00306530 File Offset: 0x00304730
	private void Start()
	{
		this.userDataWin.gameObject.SetActive(false);
		this.rectTrans = base.GetComponent<RectTransform>();
		this.EDMEIGKOHPN = base.GetComponent<Image>();
		this.PGNGGIMECEF = this.userPanel.GetComponent<Image>();
		this.GBHKLHAINED = this.settingPanel.GetComponent<Image>();
		OAFJCFOGGAF.IKGFHGKKCPG.JAJMEFBHEBH(base.gameObject);
		ChatPanelLogic.getI = this;
		this.OEDLKPKEPNA();
		if (HPGKIJLKCIH.IKGFHGKKCPG.MKJMAJFLMBJ)
		{
			Vector2 v = this.rectTrans.position;
			v.y = (float)(-(float)Screen.height) * 2f;
			this.rectTrans.position = v;
		}
		this.checkChannel(OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO);
	}

	// Token: 0x06006757 RID: 26455 RVA: 0x003065F6 File Offset: 0x003047F6
	public void GDOKBMMJAAL()
	{
		NJMHLCGIAJI.IKGFHGKKCPG.MADKBBLOPGO(146, this.selectMsg.OELGGLIHFIH);
		this.userDataWin.gameObject.SetActive(true);
	}

	// Token: 0x06006758 RID: 26456 RVA: 0x00306624 File Offset: 0x00304824
	public void LFANCGMNMEN()
	{
		string text = this.newChannelName.text.Trim();
		if (text.Length < 1)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("KatanaReadyHigh", 524f);
			return;
		}
		string value = "Block";
		if (this.memchannel.isOn)
		{
			value = text;
		}
		PlayerPrefs.SetString("KatanaReadyHigh", value);
		OAFJCFOGGAF.IKGFHGKKCPG.ABBEJLCNMLK(text, 4);
		this.newChannelPanel.gameObject.SetActive(true);
		FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("[ACTk] ", 520f);
	}

	// Token: 0x06006759 RID: 26457 RVA: 0x003066B4 File Offset: 0x003048B4
	public void JHCLJFFNAHL()
	{
		Color color = this.EDMEIGKOHPN.color;
		color.a = this.setAlfa.value;
		this.EDMEIGKOHPN.color = color;
		this.PGNGGIMECEF.color = color;
		this.GBHKLHAINED.color = color;
	}

	// Token: 0x0600675A RID: 26458 RVA: 0x00306704 File Offset: 0x00304904
	public void updateUserList()
	{
		try
		{
			this.userPanel.gameObject.SetActive(HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN);
			if (this.userPanel.gameObject.activeSelf)
			{
				int num = OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO;
				if (num == 0)
				{
					num = 1;
				}
				List<OAFJCFOGGAF.EDPNAHLGHPL> list = new List<OAFJCFOGGAF.EDPNAHLGHPL>(OAFJCFOGGAF.IKGFHGKKCPG.MJGADELHFID(num, true).JIKGMLGOAPG.Values);
				this.userLB.ClearAll();
				foreach (OAFJCFOGGAF.EDPNAHLGHPL dnhbpgoklkd in list)
				{
					this.userLB.addItem(dnhbpgoklkd);
				}
				this.userLB.sortItemList();
			}
			this.userLB.onClickItem = new MMKFAENBHKD.HEAGNGLFAJA(this.onItemClick);
			this.userLB.onRClickItem = new MMKFAENBHKD.HEAGNGLFAJA(this.onRItemClick);
			this.chanellButtons[2].captionText.text = OAFJCFOGGAF.IKGFHGKKCPG.CAKMOAMPKAA;
			this.chanellButtons[2].gameObject.SetActive(OAFJCFOGGAF.IKGFHGKKCPG.CAKMOAMPKAA != "");
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x0600675B RID: 26459 RVA: 0x00306860 File Offset: 0x00304A60
	private void GJLNFHFCAEG()
	{
		if (this.rectTrans == null)
		{
			return;
		}
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK((double)this.rectTrans.sizeDelta.x, (double)this.rectTrans.sizeDelta.y, 661.0);
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(this.rectTrans.position);
		PlayerPrefs.SetString("WeaponStrafeRunLeft", iibeekcaahk.ToString());
		PlayerPrefs.SetString("_FullResolutionFiltering", iibeekcaahk2.ToString());
		PlayerPrefs.SetFloat("Fly Right", this.EDMEIGKOHPN.color.a);
		PlayerPrefs.SetInt("error", this.fontSize);
		PlayerPrefs.SetFloat("offsets", this.lineSpacing);
	}

	// Token: 0x0600675C RID: 26460 RVA: 0x00306918 File Offset: 0x00304B18
	public void checkChannel(int NDDLLPAIHGM)
	{
		foreach (ButtonSelector buttonSelector in this.chanellButtons)
		{
		}
		if (NDDLLPAIHGM == 2)
		{
			this.chanellButtons[NDDLLPAIHGM].gameObject.SetActive(true);
			this.chanellButtons[NDDLLPAIHGM].captionText.text = OAFJCFOGGAF.IKGFHGKKCPG.CAKMOAMPKAA;
			this.chatLine.text = "";
		}
		if (NDDLLPAIHGM == 3)
		{
			this.chanellButtons[NDDLLPAIHGM].gameObject.SetActive(true);
			this.chanellButtons[NDDLLPAIHGM].captionText.text = "Приватный";
			if (this.pmUserId > 0L)
			{
				this.chanellButtons[NDDLLPAIHGM].captionText.text = this.pmUserName;
			}
			this.chatLine.text = ">" + this.pmUserName + ": ";
		}
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
		OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO = NDDLLPAIHGM;
		foreach (ButtonSelector buttonSelector2 in this.chanellButtons)
		{
			if (!(buttonSelector2 == null) && buttonSelector2.enabled)
			{
				buttonSelector2.OFGDMJJIOEB = false;
			}
		}
		this.chanellButtons[NDDLLPAIHGM].OFGDMJJIOEB = true;
		this.chanellButtons[NDDLLPAIHGM].isWarning = false;
		foreach (RectTransform rectTransform in this.chatMsgList)
		{
			UnityEngine.Object.Destroy(rectTransform.gameObject);
		}
		this.chatMsgList.Clear();
		float num = 0f;
		foreach (OAFJCFOGGAF.PIGPIKMNNLH iabkgmnjljo in OAFJCFOGGAF.IKGFHGKKCPG.MJGADELHFID(NDDLLPAIHGM, true).PNLAPCGPDDL)
		{
			if (!this.isIgnorMessage(iabkgmnjljo))
			{
				RectTransform rectTransform2 = this.MCPHKOCFMBN(iabkgmnjljo);
				this.chatMsgList.Add(rectTransform2);
				num += 25f + rectTransform2.sizeDelta.y;
			}
		}
		try
		{
			this.chatLine.interactable = false;
			if (NDDLLPAIHGM == 1)
			{
				this.chatLine.interactable = true;
			}
			if (NDDLLPAIHGM == 2)
			{
				this.chatLine.interactable = true;
			}
			if (NDDLLPAIHGM == 3)
			{
				this.chatLine.interactable = true;
			}
			if (NDDLLPAIHGM == 10)
			{
				this.chatLine.interactable = true;
			}
		}
		catch (Exception ex)
		{
			Debug.Log("Error! " + ex.Message);
		}
		this.updateUserList();
	}

	// Token: 0x0600675D RID: 26461 RVA: 0x00306BB4 File Offset: 0x00304DB4
	public void BMEBHLFBMPC(MMKFAENBHKD PHEMLBHMNCM, ItemBase EKKILFOCDJF)
	{
		if (EKKILFOCDJF != null)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)EKKILFOCDJF;
			if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == 0)
			{
				this.checkChannel(0);
			}
			OAFJCFOGGAF.PIGPIKMNNLH iabkgmnjljo = new OAFJCFOGGAF.PIGPIKMNNLH(edpnahlghpl);
			if (Application.isEditor)
			{
				Debug.Log("size" + edpnahlghpl.LPFKFNLHGBI);
			}
			this.BLCJOFHNKEC(iabkgmnjljo);
		}
	}

	// Token: 0x0600675E RID: 26462 RVA: 0x00306C10 File Offset: 0x00304E10
	private void CAMJKDLBDAL()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN)
		{
			Vector3 localPosition = this.rectTrans.localPosition;
			localPosition.x += this.userPanel.sizeDelta.x + 283f;
			this.rectTrans.localPosition = localPosition;
			this.LCFBLBALAFO = true;
			return;
		}
		Vector3 localPosition2 = this.rectTrans.localPosition;
		localPosition2.x -= this.userPanel.sizeDelta.x + 1273f;
		this.rectTrans.localPosition = localPosition2;
		this.LCFBLBALAFO = false;
	}

	// Token: 0x0600675F RID: 26463 RVA: 0x00306CAC File Offset: 0x00304EAC
	public void copyAction()
	{
		string text = "";
		if (this.selectMsg != null)
		{
			text = Regex.Replace(this.selectMsg.IABKGMNJLJO, "<.*?>", string.Empty);
		}
		TextEditor textEditor = new TextEditor();
		textEditor.content = new GUIContent(text);
		textEditor.SelectAll();
		textEditor.Copy();
		this.userDataWin.gameObject.SetActive(false);
		if (text.Trim() != "")
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
			FlyMessageManager.getI.addMessageBig("Cooбщение скопировано", Color.gray, 0, 0);
		}
	}

	// Token: 0x06006760 RID: 26464 RVA: 0x00306D4C File Offset: 0x00304F4C
	private void OEDLKPKEPNA()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.DJCBNFPFJCF)
		{
			return;
		}
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK(PlayerPrefs.GetString("UIChat_size"));
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(PlayerPrefs.GetString("UIChat_pos"));
		iibeekcaahk2.LNEPKLKELMI = (double)Mathf.Clamp(iibeekcaahk2.JLLJFKOGLHJ, 0f, (float)Screen.width - 100f);
		iibeekcaahk2.NMKCBJKHBOH = (double)Mathf.Clamp(iibeekcaahk2.OBEOJCGHOGL, 30f, (float)Screen.height - 30f);
		if (!iibeekcaahk.DIFFCNOPHBJ)
		{
			this.rectTrans.sizeDelta = new Vector2(iibeekcaahk.JLLJFKOGLHJ, iibeekcaahk.OBEOJCGHOGL);
		}
		if (!iibeekcaahk2.DIFFCNOPHBJ)
		{
			this.rectTrans.position = iibeekcaahk2.FPLDMBJEFEB();
		}
		this.fontSize = PlayerPrefs.GetInt("UIChat_fontSize");
		this.lineSpacing = PlayerPrefs.GetFloat("UIChat_fontInterval");
		this.lineSpacing = Mathf.Clamp(this.lineSpacing, 0.7f, 20f);
		float @float = PlayerPrefs.GetFloat("UIChat_alfa");
		if (@float > 0.1f)
		{
			Color color = this.EDMEIGKOHPN.color;
			color.a = @float;
			this.EDMEIGKOHPN.color = color;
		}
		foreach (RectTransform rectTransform in this.chatMsgList)
		{
			rectTransform.GetComponent<Text>().fontSize = this.fontSize;
			rectTransform.GetComponent<Text>().lineSpacing = this.lineSpacing;
		}
		this.setAlfa.value = this.EDMEIGKOHPN.color.a;
		this.setFontSize.value = (float)this.fontSize;
		this.setFontInterval.value = this.lineSpacing;
		this.PGNGGIMECEF.color = this.EDMEIGKOHPN.color;
		this.GBHKLHAINED.color = this.EDMEIGKOHPN.color;
		Debug.Log("******** ChatPanelPos " + this.rectTrans.position);
	}

	// Token: 0x06006762 RID: 26466 RVA: 0x00306F8C File Offset: 0x0030518C
	public void plusPlus()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
		if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == 0)
		{
			return;
		}
		string iabkgmnjljo = this.chatLine.text + "++++++";
		this.chatLine.text = "";
		OAFJCFOGGAF.IKGFHGKKCPG.KNMHPFAHENN(iabkgmnjljo, OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO, 0L);
		GuiProcessor.IKGFHGKKCPG.waitButtonEvent(this.plusButton, 5f);
	}

	// Token: 0x06006763 RID: 26467 RVA: 0x0030700C File Offset: 0x0030520C
	public void clearCurrentChannel()
	{
		OAFJCFOGGAF.IKGFHGKKCPG.PAGKNHKCLMD();
		this.checkChannel(OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
	}

	// Token: 0x06006764 RID: 26468 RVA: 0x0030703C File Offset: 0x0030523C
	public void FIANHDGMEJO(MMKFAENBHKD PHEMLBHMNCM, ItemBase EKKILFOCDJF)
	{
		if (EKKILFOCDJF != null)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)EKKILFOCDJF;
			if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == 0)
			{
				this.checkChannel(0);
			}
			OAFJCFOGGAF.PIGPIKMNNLH iabkgmnjljo = new OAFJCFOGGAF.PIGPIKMNNLH(edpnahlghpl);
			if (Application.isEditor)
			{
				Debug.Log("1HandSwordChargeUp" + edpnahlghpl.LPFKFNLHGBI);
			}
			this.BLCJOFHNKEC(iabkgmnjljo);
		}
	}

	// Token: 0x06006765 RID: 26469 RVA: 0x00307095 File Offset: 0x00305295
	public void HJEMLEBGHPD(string FPIHOPOCAHA)
	{
		this.chatLine.text = "WallRunLeft";
		this.chatLine.text = FPIHOPOCAHA;
		this.chatLine.ActivateInputField();
		base.StartCoroutine(this.APIFFDIFKLK());
	}

	// Token: 0x06006766 RID: 26470 RVA: 0x003070CB File Offset: 0x003052CB
	public void focusOnChat(string FPIHOPOCAHA)
	{
		this.chatLine.text = "";
		this.chatLine.text = FPIHOPOCAHA;
		this.chatLine.ActivateInputField();
		base.StartCoroutine(this.APIFFDIFKLK());
	}

	// Token: 0x06006767 RID: 26471 RVA: 0x00307104 File Offset: 0x00305304
	public void JOLDAGCHDFH()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("[X]", 1863f);
		if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == 0)
		{
			return;
		}
		string iabkgmnjljo = this.chatLine.text + " {0}";
		this.chatLine.text = "wpn_bait_typ_{0}";
		OAFJCFOGGAF.IKGFHGKKCPG.KNMHPFAHENN(iabkgmnjljo, OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO, 1L);
		GuiProcessor.BBLINJLBAIL().LHGDILAJMIE(this.plusButton, 1402f);
	}

	// Token: 0x06006768 RID: 26472 RVA: 0x00307184 File Offset: 0x00305384
	public void BLCJOFHNKEC(OAFJCFOGGAF.PIGPIKMNNLH IABKGMNJLJO)
	{
		this.selectMsg = IABKGMNJLJO;
		this.userNameTxt.text = IABKGMNJLJO.DELFGPAPOPB;
		this.toFriendBtntxt.text = JNBICAJIJMM.CLIMNFDGOEG().FLEANFGEJML("CardPlayerIdle");
		if (OAFJCFOGGAF.IKGFHGKKCPG.JMCDKANKAOI(this.selectMsg.OELGGLIHFIH))
		{
			this.toFriendBtntxt.text = JNBICAJIJMM.CLIMNFDGOEG().NLJOLOBPCBJ("_SampleScale");
		}
		this.userDataWin.gameObject.SetActive(true);
	}

	// Token: 0x06006769 RID: 26473 RVA: 0x00307208 File Offset: 0x00305408
	public void setIPanBtn()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
		this.isIgnorPanelShow = !this.isIgnorPanelShow;
		this.userIgnorPanel.gameObject.SetActive(this.isIgnorPanelShow);
		this.rebuildIgnorList();
	}

	// Token: 0x0600676A RID: 26474 RVA: 0x00307254 File Offset: 0x00305454
	public void IKKFCONNDPG(int LADDNIBBJDP)
	{
		if (LADDNIBBJDP == 3)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("Tip", 1767f);
			OAFJCFOGGAF.IKGFHGKKCPG.MAOKKGDMPDO(LADDNIBBJDP);
			if (LADDNIBBJDP >= 4)
			{
				this.chanellButtons[LADDNIBBJDP].captionText.text = "linebreak.ogg";
				this.chanellButtons[LADDNIBBJDP].gameObject.SetActive(true);
				PlayerPrefs.SetString("IdleSad", "Grounded Directional");
			}
			this.checkChannel(1);
		}
		if (LADDNIBBJDP == 6)
		{
			this.pmUserId = 1L;
			this.pmUserName = "TOD_MoonMeshColor";
			this.chanellButtons[LADDNIBBJDP].captionText.text = "How your health bar is stored in memory when obscured:\n";
			this.chanellButtons[LADDNIBBJDP].gameObject.SetActive(true);
			this.checkChannel(1);
		}
	}

	// Token: 0x0600676B RID: 26475 RVA: 0x00307310 File Offset: 0x00305510
	private void EFBNFABJAJI()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN)
		{
			Vector3 localPosition = this.rectTrans.localPosition;
			localPosition.x += this.userPanel.sizeDelta.x + 651f;
			this.rectTrans.localPosition = localPosition;
			this.LCFBLBALAFO = false;
			return;
		}
		Vector3 localPosition2 = this.rectTrans.localPosition;
		localPosition2.x -= this.userPanel.sizeDelta.x + 30f;
		this.rectTrans.localPosition = localPosition2;
		this.LCFBLBALAFO = false;
	}

	// Token: 0x0600676C RID: 26476 RVA: 0x003073AC File Offset: 0x003055AC
	private void NBAKJCDDBIP()
	{
		if (this.rectTrans == null)
		{
			return;
		}
		IIBEEKCAAHK iibeekcaahk = new IIBEEKCAAHK((double)this.rectTrans.sizeDelta.x, (double)this.rectTrans.sizeDelta.y, 0.0);
		IIBEEKCAAHK iibeekcaahk2 = new IIBEEKCAAHK(this.rectTrans.position);
		PlayerPrefs.SetString("UIChat_size", iibeekcaahk.ToString());
		PlayerPrefs.SetString("UIChat_pos", iibeekcaahk2.ToString());
		PlayerPrefs.SetFloat("UIChat_alfa", this.EDMEIGKOHPN.color.a);
		PlayerPrefs.SetInt("UIChat_fontSize", this.fontSize);
		PlayerPrefs.SetFloat("UIChat_fontInterval", this.lineSpacing);
	}

	// Token: 0x0600676D RID: 26477 RVA: 0x00307464 File Offset: 0x00305664
	public void UserOut(OAFJCFOGGAF.EDPNAHLGHPL AGHCJPAJDAD)
	{
		if (this.userPanel.gameObject.activeSelf)
		{
			this.userLB.deleteItem(AGHCJPAJDAD);
		}
	}

	// Token: 0x0600676E RID: 26478 RVA: 0x00307484 File Offset: 0x00305684
	public void HOJJPPANLGK()
	{
		this.settingPanel.gameObject.SetActive(!this.settingPanel.gameObject.activeSelf);
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("", 582f);
	}

	// Token: 0x0600676F RID: 26479 RVA: 0x003074C0 File Offset: 0x003056C0
	public void OnChatMessage(OAFJCFOGGAF.PIGPIKMNNLH IABKGMNJLJO)
	{
		if (IABKGMNJLJO.BDELNBNMOPB.OFALPEIEOJE == OAFJCFOGGAF.IKGFHGKKCPG.IJBPCCHPPKO)
		{
			if (this.isIgnorMessage(IABKGMNJLJO))
			{
				return;
			}
			RectTransform item = this.MCPHKOCFMBN(IABKGMNJLJO);
			this.chatMsgList.Add(item);
			if (this.chatMsgList.Count > 20)
			{
				Component component = this.chatMsgList[0];
				this.chatMsgList.RemoveAt(0);
				UnityEngine.Object.Destroy(component.gameObject);
				return;
			}
		}
		else if (IABKGMNJLJO.BDELNBNMOPB.OFALPEIEOJE != "sys")
		{
			ButtonSelector buttonSelector = this.chanellButtons[IABKGMNJLJO.BDELNBNMOPB.NDDLLPAIHGM];
			buttonSelector.isWarning = true;
			if (IABKGMNJLJO.IABKGMNJLJO.Contains(JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BNIHFBMEPAB) || IABKGMNJLJO.BDELNBNMOPB.NDDLLPAIHGM == 3)
			{
				if (buttonSelector != null)
				{
					buttonSelector.isFlash = true;
				}
				if (IABKGMNJLJO.BDELNBNMOPB.NDDLLPAIHGM == 3)
				{
					if (this.pmUserId == 0L)
					{
						this.pmUserId = IABKGMNJLJO.OELGGLIHFIH;
						this.pmUserName = IABKGMNJLJO.DELFGPAPOPB;
						this.chanellButtons[3].captionText.text = this.pmUserName;
					}
					this.chanellButtons[3].gameObject.SetActive(true);
				}
			}
		}
	}

	// Token: 0x06006770 RID: 26480 RVA: 0x00307603 File Offset: 0x00305803
	public bool isIgnorMessage(OAFJCFOGGAF.PIGPIKMNNLH IABKGMNJLJO)
	{
		if (OAFJCFOGGAF.IKGFHGKKCPG.ELEFJAEDJAK(IABKGMNJLJO.OELGGLIHFIH).KNDGFKKALCE)
		{
			return true;
		}
		bool poilpdmecgd = IABKGMNJLJO.POILPDMECGD;
		return false;
	}

	// Token: 0x06006771 RID: 26481 RVA: 0x00307628 File Offset: 0x00305828
	public void censorAction()
	{
		if (this.selectMsg == null)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.OBCCLNMPGEJ(this.selectMsg.OELGGLIHFIH);
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(242, epmphjgalbe.JDPHBLHOLAD());
			this.userDataWin.gameObject.SetActive(false);
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("_DelItem.wav", 1f);
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x06006772 RID: 26482 RVA: 0x003076A8 File Offset: 0x003058A8
	public void BPCOECECLHK()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN = !HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN;
		FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("[curcnt]", 0f);
		if (HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("BowFire", 7f);
		}
		this.EFBNFABJAJI();
		this.BEFBMBJDNPB();
	}

	// Token: 0x06006773 RID: 26483 RVA: 0x0030770C File Offset: 0x0030590C
	public void EMCEDNDMKFH()
	{
		this.lineSpacing = this.setFontInterval.value;
		foreach (RectTransform rectTransform in this.chatMsgList)
		{
			rectTransform.GetComponent<Text>().lineSpacing = this.lineSpacing;
		}
	}

	// Token: 0x06006774 RID: 26484 RVA: 0x00307778 File Offset: 0x00305978
	public void HFIPLEODBCP()
	{
		if (this.GDAPDOCNGHF)
		{
			this.rectTrans.sizeDelta = new Vector2(this.rectTrans.sizeDelta.x, this.rectTrans.sizeDelta.y - (float)this.openSizeDelta);
			this.GDAPDOCNGHF = true;
			FBFJFAKAGJG.IKGFHGKKCPG.DIHKGFJGMBE("</color>", 1517f);
			return;
		}
		this.rectTrans.sizeDelta = new Vector2(this.rectTrans.sizeDelta.x, this.rectTrans.sizeDelta.y + (float)this.openSizeDelta);
		this.GDAPDOCNGHF = true;
		FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ("selColor", 1399f);
	}

	// Token: 0x06006775 RID: 26485 RVA: 0x00307834 File Offset: 0x00305A34
	public bool DGGGOGNMEJL()
	{
		return this.chatLine.isFocused;
	}

	// Token: 0x06006776 RID: 26486 RVA: 0x00307846 File Offset: 0x00305A46
	public void AGLIKBHEKNP()
	{
		OAFJCFOGGAF.IKGFHGKKCPG.PAGKNHKCLMD();
		this.checkChannel(OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO);
		FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("", 242f);
	}

	// Token: 0x06006777 RID: 26487 RVA: 0x00307878 File Offset: 0x00305A78
	public void settingsFIntervalChange()
	{
		this.lineSpacing = this.setFontInterval.value;
		foreach (RectTransform rectTransform in this.chatMsgList)
		{
			rectTransform.GetComponent<Text>().lineSpacing = this.lineSpacing;
		}
	}

	// Token: 0x06006778 RID: 26488 RVA: 0x003078E4 File Offset: 0x00305AE4
	public void OnDrag(PointerEventData CAKNKPPGGIK)
	{
		this.rectTrans.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
	}

	// Token: 0x06006779 RID: 26489 RVA: 0x003078E4 File Offset: 0x00305AE4
	public void HIOFOADBBKH(PointerEventData CAKNKPPGGIK)
	{
		this.rectTrans.position += new Vector3(CAKNKPPGGIK.delta.x, CAKNKPPGGIK.delta.y);
	}

	// Token: 0x0600677A RID: 26490 RVA: 0x00307917 File Offset: 0x00305B17
	public void GCHBEAEBCFH()
	{
		this.settingPanel.gameObject.SetActive(this.settingPanel.gameObject.activeSelf);
		FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("<color='{0}'> {1} ур {2}</color>\n", 934f);
	}

	// Token: 0x0600677B RID: 26491 RVA: 0x00307950 File Offset: 0x00305B50
	public void ECCCILEAONC(MMKFAENBHKD PHEMLBHMNCM, ItemBase EKKILFOCDJF)
	{
		if (EKKILFOCDJF != null)
		{
			OAFJCFOGGAF.EDPNAHLGHPL edpnahlghpl = (OAFJCFOGGAF.EDPNAHLGHPL)EKKILFOCDJF;
			if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == 0)
			{
				this.checkChannel(1);
			}
			this.NNDFBDIJLKB("chan_head" + edpnahlghpl.BNIHFBMEPAB + "_CameraClipInfo");
			if (Application.isEditor)
			{
				Debug.Log("Lasso Back" + edpnahlghpl.LPFKFNLHGBI);
			}
		}
	}

	// Token: 0x0600677C RID: 26492 RVA: 0x003079B8 File Offset: 0x00305BB8
	public void MsgSend()
	{
		if (this.chatLine.text.Trim() == "")
		{
			this.chatLine.text = "";
			return;
		}
		long ngcjcdadlae = -1L;
		if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == 3)
		{
			if (this.pmUserId == 0L)
			{
				this.pmUserId = this.old_pmUserId;
				this.pmUserName = this.old_pmUserName;
			}
			ngcjcdadlae = this.pmUserId;
		}
		if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == 10)
		{
			OAFJCFOGGAF.IKGFHGKKCPG.KNMHPFAHENN(this.chatLine.text, 10, ngcjcdadlae);
		}
		else
		{
			OAFJCFOGGAF.IKGFHGKKCPG.KNMHPFAHENN(this.chatLine.text, -1, ngcjcdadlae);
		}
		this.chatLine.text = "";
		if (OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO == 3)
		{
			this.chatLine.text = ">" + this.pmUserName + ": ";
		}
		this.chatLine.MoveTextEnd(false);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 1f);
	}

	// Token: 0x0600677D RID: 26493 RVA: 0x00307AC8 File Offset: 0x00305CC8
	public void BKCBNICANEE(int LADDNIBBJDP)
	{
		if (LADDNIBBJDP == 3)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP(" iterations for read and write", 292f);
			OAFJCFOGGAF.IKGFHGKKCPG.MAOKKGDMPDO(LADDNIBBJDP);
			if (LADDNIBBJDP >= 2)
			{
				this.chanellButtons[LADDNIBBJDP].captionText.text = "";
				this.chanellButtons[LADDNIBBJDP].gameObject.SetActive(true);
				PlayerPrefs.SetString("_VignetteBlur", "MotorbikeLassoFwd");
			}
			this.checkChannel(1);
		}
		if (LADDNIBBJDP == 3)
		{
			this.pmUserId = 0L;
			this.pmUserName = "t_body";
			this.chanellButtons[LADDNIBBJDP].captionText.text = "_NAME";
			this.chanellButtons[LADDNIBBJDP].gameObject.SetActive(false);
			this.checkChannel(1);
		}
	}

	// Token: 0x0600677E RID: 26494 RVA: 0x00307B84 File Offset: 0x00305D84
	private RectTransform HJEHCIPMNNJ(OAFJCFOGGAF.PIGPIKMNNLH IABKGMNJLJO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.ChatMsgPrfb);
		gameObject.GetComponent<Text>().text = IABKGMNJLJO.EMGBBOOBAHI(true, false);
		gameObject.GetComponent<Text>().fontSize = this.fontSize;
		gameObject.GetComponent<Text>().lineSpacing = this.lineSpacing;
		gameObject.GetComponent<ChatMsgClicker>().msg = IABKGMNJLJO;
		if (IABKGMNJLJO.OELGGLIHFIH == JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI)
		{
			gameObject.GetComponent<Text>().color = this.yourMsgColor;
		}
		if (IABKGMNJLJO.IABKGMNJLJO.Contains(JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BNIHFBMEPAB))
		{
			gameObject.GetComponent<Text>().color = this.toYouMsgColor;
		}
		if (IABKGMNJLJO.POILPDMECGD)
		{
			gameObject.GetComponent<Text>().color = this.privateInputColor;
		}
		RectTransform component = gameObject.GetComponent<RectTransform>();
		component.position = this.content.position;
		component.SetParent(this.content);
		component.offsetMin = new Vector2(988f, 1789f);
		component.offsetMax = new Vector2(502f, 1403f);
		component.localPosition = new Vector3(1742f, 373f, 1178f);
		return component;
	}

	// Token: 0x0600677F RID: 26495 RVA: 0x00307CB3 File Offset: 0x00305EB3
	public void UserChange(OAFJCFOGGAF.EDPNAHLGHPL AGHCJPAJDAD)
	{
		if (this.userPanel.gameObject.activeSelf)
		{
			this.userLB.updateItem(AGHCJPAJDAD);
			this.userLB.sortItemList();
		}
	}

	// Token: 0x06006780 RID: 26496 RVA: 0x00307CDE File Offset: 0x00305EDE
	public void HAIEMNFCGMN()
	{
		this.newChannelPanel.gameObject.SetActive(!this.newChannelPanel.gameObject.activeSelf);
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("_HitTime", 1197f);
	}

	// Token: 0x06006781 RID: 26497 RVA: 0x00307D18 File Offset: 0x00305F18
	public void DLJIFAEBEEF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("Pointing", 1437f);
		this.isIgnorPanelShow = this.isIgnorPanelShow;
		this.userIgnorPanel.gameObject.SetActive(this.isIgnorPanelShow);
		this.rebuildIgnorList();
	}

	// Token: 0x06006782 RID: 26498 RVA: 0x00307D64 File Offset: 0x00305F64
	public void KDDOEDEFMOF()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN = !HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN;
		FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("_Intensity", 1909f);
		if (HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("", 1856f);
		}
		this.MGJACAHIKLJ();
		this.BEFBMBJDNPB();
	}

	// Token: 0x06006783 RID: 26499 RVA: 0x00307DC8 File Offset: 0x00305FC8
	private void OMGKJLPAILB()
	{
		if (HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN)
		{
			Vector3 localPosition = this.rectTrans.localPosition;
			localPosition.x += this.userPanel.sizeDelta.x + 1169f;
			this.rectTrans.localPosition = localPosition;
			this.LCFBLBALAFO = false;
			return;
		}
		Vector3 localPosition2 = this.rectTrans.localPosition;
		localPosition2.x -= this.userPanel.sizeDelta.x + 405f;
		this.rectTrans.localPosition = localPosition2;
		this.LCFBLBALAFO = true;
	}

	// Token: 0x06006784 RID: 26500 RVA: 0x00307834 File Offset: 0x00305A34
	public bool isChatEnter()
	{
		return this.chatLine.isFocused;
	}

	// Token: 0x06006785 RID: 26501 RVA: 0x00307E64 File Offset: 0x00306064
	public void KDGKANABFDD()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN = !HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN;
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Game saved with regular PlayerPrefs. Try to find and change saved data now (it's easy)!", 1821f);
		if (HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("readForeignSaves", 1579f);
		}
		this.CAMJKDLBDAL();
		this.updateUserList();
	}

	// Token: 0x06006786 RID: 26502 RVA: 0x00307EC8 File Offset: 0x003060C8
	public void ChatPanelClose()
	{
		HPGKIJLKCIH.IKGFHGKKCPG.MKJMAJFLMBJ = true;
		HPGKIJLKCIH.IKGFHGKKCPG.PLMCCCMHFKB();
		if (DownPanelLogic.getI != null && DownPanelLogic.getI.chatOpenButton != null)
		{
			DownPanelLogic.getI.chatOpenButton.gameObject.SetActive(true);
		}
		if (HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN)
		{
			this.MGJACAHIKLJ();
		}
		Vector2 vector = this.rectTrans.position;
		PlayerPrefs.SetFloat("choldposx", vector.x);
		PlayerPrefs.SetFloat("choldposy", vector.y);
		vector.y = (float)(-(float)Screen.height) * 2f;
		this.rectTrans.position = vector;
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 0.7f);
	}

	// Token: 0x06006787 RID: 26503 RVA: 0x00307F9C File Offset: 0x0030619C
	public void BEFBMBJDNPB()
	{
		try
		{
			this.userPanel.gameObject.SetActive(HPGKIJLKCIH.IKGFHGKKCPG.COCLLNFDKCN);
			if (this.userPanel.gameObject.activeSelf)
			{
				int num = OAFJCFOGGAF.IKGFHGKKCPG.BNDLJLCJCLO;
				if (num == 0)
				{
					num = 0;
				}
				List<OAFJCFOGGAF.EDPNAHLGHPL> list = new List<OAFJCFOGGAF.EDPNAHLGHPL>(OAFJCFOGGAF.IKGFHGKKCPG.MJGADELHFID(num, false).JIKGMLGOAPG.Values);
				this.userLB.ClearAll();
				foreach (OAFJCFOGGAF.EDPNAHLGHPL dnhbpgoklkd in list)
				{
					this.userLB.IPENPEOKJJF(dnhbpgoklkd);
				}
				this.userLB.AGDCELDJAKK();
			}
			this.userLB.onClickItem = new MMKFAENBHKD.HEAGNGLFAJA(this.onItemClick);
			this.userLB.onRClickItem = new MMKFAENBHKD.HEAGNGLFAJA(this.BMEBHLFBMPC);
			this.chanellButtons[7].captionText.text = OAFJCFOGGAF.IKGFHGKKCPG.CAKMOAMPKAA;
			this.chanellButtons[5].gameObject.SetActive(OAFJCFOGGAF.IKGFHGKKCPG.CAKMOAMPKAA != "wpn_add/base");
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
	}

	// Token: 0x06006788 RID: 26504 RVA: 0x003080F8 File Offset: 0x003062F8
	public bool DJEPDONBBIM()
	{
		return !this.chatLine.isFocused;
	}

	// Token: 0x06006789 RID: 26505 RVA: 0x0030810A File Offset: 0x0030630A
	public void openSettings()
	{
		this.settingPanel.gameObject.SetActive(!this.settingPanel.gameObject.activeSelf);
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("knopje.wav", 0.5f);
	}

	// Token: 0x0600678A RID: 26506 RVA: 0x00308143 File Offset: 0x00306343
	public void UserIn(OAFJCFOGGAF.EDPNAHLGHPL AGHCJPAJDAD)
	{
		if (this.userPanel.gameObject.activeSelf)
		{
			this.userLB.addItem(AGHCJPAJDAD);
			this.userLB.sortItemList();
		}
	}

	// Token: 0x0600678B RID: 26507 RVA: 0x00308170 File Offset: 0x00306370
	public void openMsgWin(OAFJCFOGGAF.PIGPIKMNNLH IABKGMNJLJO)
	{
		this.selectMsg = IABKGMNJLJO;
		this.userNameTxt.text = IABKGMNJLJO.DELFGPAPOPB;
		this.toFriendBtntxt.text = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cht_tofrend");
		if (OAFJCFOGGAF.IKGFHGKKCPG.JMCDKANKAOI(this.selectMsg.OELGGLIHFIH))
		{
			this.toFriendBtntxt.text = JNBICAJIJMM.IKGFHGKKCPG.HLBAJBLHLNI("cht_tofrendno");
		}
		this.userDataWin.gameObject.SetActive(true);
	}

	// Token: 0x0600678C RID: 26508 RVA: 0x003081F4 File Offset: 0x003063F4
	public void EAHAIGBOGHE()
	{
		if (this.GDAPDOCNGHF)
		{
			this.rectTrans.sizeDelta = new Vector2(this.rectTrans.sizeDelta.x, this.rectTrans.sizeDelta.y - (float)this.openSizeDelta);
			this.GDAPDOCNGHF = true;
			FBFJFAKAGJG.IKGFHGKKCPG.HFJOFLCNLPA("WeaponRun", 211f);
			return;
		}
		this.rectTrans.sizeDelta = new Vector2(this.rectTrans.sizeDelta.x, this.rectTrans.sizeDelta.y + (float)this.openSizeDelta);
		this.GDAPDOCNGHF = true;
		FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("", 674f);
	}

	// Token: 0x0600678D RID: 26509 RVA: 0x003082B0 File Offset: 0x003064B0
	public void OHIBOGMJAFF()
	{
		if (this.selectMsg == null)
		{
			return;
		}
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.MFPECHIKBCO(this.selectMsg.OELGGLIHFIH);
			NJMHLCGIAJI.EAJGHMMBAFP().HJPGADJMICM(-31, epmphjgalbe.ALLANCHILCM());
			this.userDataWin.gameObject.SetActive(true);
			FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI("14,15,16,36", 1235f);
		}
		finally
		{
			epmphjgalbe.LMBPNFHKNGA();
		}
	}

	// Token: 0x0600678E RID: 26510 RVA: 0x00308330 File Offset: 0x00306530
	public void resizePanel()
	{
		if (this.GDAPDOCNGHF)
		{
			this.rectTrans.sizeDelta = new Vector2(this.rectTrans.sizeDelta.x, this.rectTrans.sizeDelta.y - (float)this.openSizeDelta);
			this.GDAPDOCNGHF = false;
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("Flap_00.wav", 1f);
			return;
		}
		this.rectTrans.sizeDelta = new Vector2(this.rectTrans.sizeDelta.x, this.rectTrans.sizeDelta.y + (float)this.openSizeDelta);
		this.GDAPDOCNGHF = true;
		FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("PaperTurn.wav", 1f);
	}

	// Token: 0x0600678F RID: 26511 RVA: 0x003083EC File Offset: 0x003065EC
	public void FPKJPADBENF()
	{
		if (this.pmUserId != 0L)
		{
			this.old_pmUserId = this.pmUserId;
			this.old_pmUserName = this.pmUserName;
		}
		if (this.selectMsg.OELGGLIHFIH != 0L)
		{
			this.pmUserId = this.selectMsg.OELGGLIHFIH;
			this.pmUserName = this.selectMsg.DELFGPAPOPB;
		}
		this.userDataWin.gameObject.SetActive(false);
		this.checkChannel(2);
		this.HJEMLEBGHPD("OneHandSwordBlock" + this.pmUserName + "I LOVE MY GIRLz");
	}

	// Token: 0x04000E9E RID: 3742
	public GameObject ChatMsgPrfb;

	// Token: 0x04000E9F RID: 3743
	public GameObject adminPanel;

	// Token: 0x04000EA0 RID: 3744
	public RectTransform userPanel;

	// Token: 0x04000EA1 RID: 3745
	public RectTransform settingPanel;

	// Token: 0x04000EA2 RID: 3746
	public RectTransform newChannelPanel;

	// Token: 0x04000EA3 RID: 3747
	public InputField newChannelName;

	// Token: 0x04000EA4 RID: 3748
	public Toggle memchannel;

	// Token: 0x04000EA5 RID: 3749
	public UIListBox userLB;

	// Token: 0x04000EA6 RID: 3750
	public UIListBox userIgnorLB;

	// Token: 0x04000EA7 RID: 3751
	public RectTransform userIgnorPanel;

	// Token: 0x04000EA8 RID: 3752
	public bool isIgnorPanelShow;

	// Token: 0x04000EA9 RID: 3753
	public static ChatPanelLogic getI;

	// Token: 0x04000EAA RID: 3754
	public InputField chatLine;

	// Token: 0x04000EAB RID: 3755
	public InputField altChatText;

	// Token: 0x04000EAC RID: 3756
	public Scrollbar scroll;

	// Token: 0x04000EAD RID: 3757
	public RectTransform content;

	// Token: 0x04000EAE RID: 3758
	public ButtonSelector[] chanellButtons;

	// Token: 0x04000EAF RID: 3759
	public RectTransform rectTrans;

	// Token: 0x04000EB0 RID: 3760
	private bool GDAPDOCNGHF;

	// Token: 0x04000EB1 RID: 3761
	public int openSizeDelta = 200;

	// Token: 0x04000EB2 RID: 3762
	private Vector2 AICBIFFGBOH = Vector2.zero;

	// Token: 0x04000EB3 RID: 3763
	public Slider setAlfa;

	// Token: 0x04000EB4 RID: 3764
	public Slider setFontSize;

	// Token: 0x04000EB5 RID: 3765
	public Slider setFontInterval;

	// Token: 0x04000EB6 RID: 3766
	public Button plusButton;

	// Token: 0x04000EB7 RID: 3767
	public List<RectTransform> chatMsgList = new List<RectTransform>();

	// Token: 0x04000EB8 RID: 3768
	public RectTransform userDataWin;

	// Token: 0x04000EB9 RID: 3769
	public Text userNameTxt;

	// Token: 0x04000EBA RID: 3770
	public Text toFriendBtntxt;

	// Token: 0x04000EBB RID: 3771
	public long pmUserId;

	// Token: 0x04000EBC RID: 3772
	public string pmUserName;

	// Token: 0x04000EBD RID: 3773
	public long old_pmUserId;

	// Token: 0x04000EBE RID: 3774
	public string old_pmUserName;

	// Token: 0x04000EBF RID: 3775
	public Color normalInputColor;

	// Token: 0x04000EC0 RID: 3776
	public Color privateInputColor;

	// Token: 0x04000EC1 RID: 3777
	public Color yourMsgColor;

	// Token: 0x04000EC2 RID: 3778
	public Color toYouMsgColor;

	// Token: 0x04000EC3 RID: 3779
	public OAFJCFOGGAF.PIGPIKMNNLH selectMsg;

	// Token: 0x04000EC4 RID: 3780
	private bool LCFBLBALAFO;

	// Token: 0x04000EC5 RID: 3781
	private Image EDMEIGKOHPN;

	// Token: 0x04000EC6 RID: 3782
	private Image PGNGGIMECEF;

	// Token: 0x04000EC7 RID: 3783
	private Image GBHKLHAINED;

	// Token: 0x04000EC8 RID: 3784
	public int fontSize;

	// Token: 0x04000EC9 RID: 3785
	public float lineSpacing;
}
