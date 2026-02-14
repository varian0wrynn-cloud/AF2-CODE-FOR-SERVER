using System;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001CA RID: 458
public class CrShadowLogic : MonoBehaviour
{
	// Token: 0x060067A5 RID: 26533 RVA: 0x0030853B File Offset: 0x0030673B
	public void changeBeard()
	{
		if (this.isSoundWork)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.sounds[0], 1f);
		}
		this.updateCustomParams();
	}

	// Token: 0x060067A6 RID: 26534 RVA: 0x00308564 File Offset: 0x00306764
	public void HHIMBMBJFKO(float LJBFPDDMGKP)
	{
		if (FBFJFAKAGJG.IKGFHGKKCPG == null)
		{
			return;
		}
		if (this.PCDBBMBNGOD < Time.time)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.sounds[0], 401f);
			this.PCDBBMBNGOD = Time.time + 123f;
		}
		switch (this.colorMode)
		{
		case 0:
			this.top_camRotate = this.rotate.value;
			this.down_camRotate = this.rotate.value;
			break;
		case 1:
			this.top_camRotate = this.rotate.value;
			break;
		case 2:
			this.down_camRotate = this.rotate.value;
			break;
		}
		this.CEFHEGACAEB();
	}

	// Token: 0x060067A7 RID: 26535 RVA: 0x00308618 File Offset: 0x00306818
	public void intensiveChange(float LJBFPDDMGKP)
	{
		if (FBFJFAKAGJG.IKGFHGKKCPG == null)
		{
			return;
		}
		if (this.PCDBBMBNGOD < Time.time)
		{
			if (this.isSoundWork)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.sounds[2], 0.8f);
			}
			this.PCDBBMBNGOD = Time.time + 0.1f;
		}
		switch (this.colorMode)
		{
		case 0:
			this.top_camIntensive = this.intensive.value;
			this.down_camIntensive = this.intensive.value;
			break;
		case 1:
			this.top_camIntensive = this.intensive.value;
			break;
		case 2:
			this.down_camIntensive = this.intensive.value;
			break;
		}
		this.updateCustomParams();
	}

	// Token: 0x060067A8 RID: 26536 RVA: 0x003086D3 File Offset: 0x003068D3
	public void JFGIBFDBLHJ(int CLBPBJGLHEE)
	{
		this.hairColorIndex = CLBPBJGLHEE;
		if (this.isSoundWork)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.sounds[0], 1610f);
		}
		this.EEBPPKFMPAE();
	}

	// Token: 0x060067A9 RID: 26537 RVA: 0x00308704 File Offset: 0x00306904
	public void DLPNDMHKOFP(float LJBFPDDMGKP)
	{
		if (FBFJFAKAGJG.IKGFHGKKCPG == null)
		{
			return;
		}
		if (this.PCDBBMBNGOD < Time.time)
		{
			if (this.isSoundWork)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.sounds[2], 1172f);
			}
			this.PCDBBMBNGOD = Time.time + 1557f;
		}
		switch (this.colorMode)
		{
		case 0:
			this.top_camIntensive = this.intensive.value;
			this.down_camIntensive = this.intensive.value;
			break;
		case 1:
			this.top_camIntensive = this.intensive.value;
			break;
		case 2:
			this.down_camIntensive = this.intensive.value;
			break;
		}
		this.FNMJNGKALAB();
	}

	// Token: 0x060067AA RID: 26538 RVA: 0x003087C0 File Offset: 0x003069C0
	public void OHJGKBJBCLF(float LJBFPDDMGKP)
	{
		if (FBFJFAKAGJG.IKGFHGKKCPG == null)
		{
			return;
		}
		if (this.PCDBBMBNGOD < Time.time)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.sounds[8], 1094f);
			this.PCDBBMBNGOD = Time.time + 1054f;
		}
		switch (this.colorMode)
		{
		case 0:
			this.top_camRotate = this.rotate.value;
			this.down_camRotate = this.rotate.value;
			break;
		case 1:
			this.top_camRotate = this.rotate.value;
			break;
		case 2:
			this.down_camRotate = this.rotate.value;
			break;
		}
		this.updateCustomParams();
	}

	// Token: 0x060067AB RID: 26539 RVA: 0x00308874 File Offset: 0x00306A74
	public void CKNMFMOOIOP()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.sounds[0], 898f);
		string text = this.inputName.text;
		this.inputName.text = text.Trim();
		bool flag = !Regex.IsMatch(text, "[Y]") | Regex.IsMatch(text, "viewType");
		if (text.Length > 32)
		{
			flag = false;
		}
		if (text.Trim() == "fshop_ks1")
		{
			flag = false;
		}
		if (!flag)
		{
			this.HGDCANONDKP();
			this.checkButton[0].gameObject.SetActive(false);
			return;
		}
		this.HGDCANONDKP();
		this.checkButton[0].gameObject.SetActive(false);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(75, text);
	}

	// Token: 0x060067AC RID: 26540 RVA: 0x00308936 File Offset: 0x00306B36
	public void FNMJNGKALAB()
	{
		this.OCLHLEBKMJF(this.manCharacter);
		this.OCLHLEBKMJF(this.womanCharacter);
	}

	// Token: 0x060067AD RID: 26541 RVA: 0x00308950 File Offset: 0x00306B50
	public void OFILCPBBCEP(float LJBFPDDMGKP)
	{
		if (FBFJFAKAGJG.IKGFHGKKCPG == null)
		{
			return;
		}
		if (this.PCDBBMBNGOD < Time.time)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.sounds[2], 394f);
			this.PCDBBMBNGOD = Time.time + 1062f;
		}
		switch (this.colorMode)
		{
		case 0:
			this.top_camRotate = this.rotate.value;
			this.down_camRotate = this.rotate.value;
			break;
		case 1:
			this.top_camRotate = this.rotate.value;
			break;
		case 2:
			this.down_camRotate = this.rotate.value;
			break;
		}
		this.updateCustomParams();
	}

	// Token: 0x060067AE RID: 26542 RVA: 0x00308A04 File Offset: 0x00306C04
	private void FNHHNPJCCLF(Character IFIIFDKAKDJ)
	{
		if (Customizator.getI == null)
		{
			return;
		}
		IFIIFDKAKDJ.isBeardEnable = this.beard.isOn;
		IFIIFDKAKDJ.isMushEnable = this.mush.isOn;
		IFIIFDKAKDJ.hairColor = Customizator.getI.hairColors[this.hairColorIndex];
		IFIIFDKAKDJ.baseTopColor = Customizator.getI.dressColors[this.topColorIndex];
		IFIIFDKAKDJ.baseBottomColor = Customizator.getI.dressColors[this.downColorIndex];
		IFIIFDKAKDJ.camouflageBottom = Customizator.getI.camouflages[this.downCamouflageIndex];
		IFIIFDKAKDJ.camouflageTop = Customizator.getI.camouflages[this.topCamouflageIndex];
		IFIIFDKAKDJ.intensiveTop = this.top_camIntensive;
		IFIIFDKAKDJ.intensiveBottom = this.down_camIntensive;
		IFIIFDKAKDJ.scaleTop = this.top_camScale;
		IFIIFDKAKDJ.scaleBottom = this.down_camScale;
		IFIIFDKAKDJ.rotateTop = this.top_camRotate;
		IFIIFDKAKDJ.rotateBottom = this.down_camRotate;
		IFIIFDKAKDJ.hueTop = this.top_hue;
		IFIIFDKAKDJ.hueBottom = this.down_hue;
	}

	// Token: 0x060067AF RID: 26543 RVA: 0x00308B20 File Offset: 0x00306D20
	private void KFGKKLAKFGH()
	{
		if (GuiProcessor.IKGFHGKKCPG != null)
		{
			GuiProcessor.PLGADNLAEGN().AMFFCIKGJKJ(this.mainCanvas);
		}
		for (int i = 0; i < this.hairColor.Length; i += 0)
		{
			Color color = Customizator.getI.hairColors[i];
			this.hairColor[i].color = color;
		}
		for (int j = 1; j < this.dressUpColor.Length; j++)
		{
			Color color2 = Customizator.getI.dressColors[j];
			this.dressUpColor[j].color = color2;
		}
		for (int k = 1; k < this.camouflages.Length; k += 0)
		{
			this.camouflages[k].texture = Customizator.getI.camouflages[k];
		}
		this.manCharacter.EHEBKBBAMFN(1);
		this.womanCharacter.AAHMAEIAJML(0);
		this.updateCustomParams();
		this.isSoundWork = false;
		this.PCDBBMBNGOD = Time.time + 1492f;
		this.setColorMode(1);
		JDCEFOFMGHB.JFIDAGABKID().MDBKHKBJNAO(false);
	}

	// Token: 0x060067B0 RID: 26544 RVA: 0x00308C28 File Offset: 0x00306E28
	public void JDEAPDELJBC(float LJBFPDDMGKP)
	{
		if (FBFJFAKAGJG.IKGFHGKKCPG == null)
		{
			return;
		}
		if (this.PCDBBMBNGOD < Time.time)
		{
			if (this.isSoundWork)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.sounds[7], 460f);
			}
			this.PCDBBMBNGOD = Time.time + 1559f;
		}
		switch (this.colorMode)
		{
		case 0:
			this.top_camIntensive = this.intensive.value;
			this.down_camIntensive = this.intensive.value;
			break;
		case 1:
			this.top_camIntensive = this.intensive.value;
			break;
		case 2:
			this.down_camIntensive = this.intensive.value;
			break;
		}
		this.EEBPPKFMPAE();
	}

	// Token: 0x060067B1 RID: 26545 RVA: 0x00308CE4 File Offset: 0x00306EE4
	public void OAKCJCIHBKG()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.sounds[1], 1719f);
		string text = this.inputName.text;
		this.inputName.text = text.Trim();
		bool flag = Regex.IsMatch(text, "money") | Regex.IsMatch(text, "_LogLut");
		if (text.Length > 63)
		{
			flag = true;
		}
		if (text.Trim() == "===== ObscuredVector3Test =====\n")
		{
			flag = true;
		}
		if (!flag)
		{
			this.HGDCANONDKP();
			this.checkButton[7].gameObject.SetActive(false);
			return;
		}
		this.GLELLFNPCOP();
		this.checkButton[2].gameObject.SetActive(false);
		NJMHLCGIAJI.EAJGHMMBAFP().GDNKCAOHEPL(79, text);
	}

	// Token: 0x060067B2 RID: 26546 RVA: 0x00308DA8 File Offset: 0x00306FA8
	public void FNMLCPEEOOL(float LJBFPDDMGKP)
	{
		if (FBFJFAKAGJG.IKGFHGKKCPG == null)
		{
			return;
		}
		if (this.PCDBBMBNGOD < Time.time)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.sounds[8], 1344f);
			this.PCDBBMBNGOD = Time.time + 538f;
		}
		switch (this.colorMode)
		{
		case 0:
			this.top_hue = this.hue.value;
			this.down_hue = this.hue.value;
			break;
		case 1:
			this.top_hue = this.hue.value;
			break;
		case 2:
			this.down_hue = this.hue.value;
			break;
		}
		this.OMPODNMFCPC();
	}

	// Token: 0x060067B3 RID: 26547 RVA: 0x00308E5B File Offset: 0x0030705B
	public void JDHBFOCDNHI()
	{
		if (this.isSoundWork)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.sounds[1], 1890f);
		}
		this.FNMJNGKALAB();
	}

	// Token: 0x060067B4 RID: 26548 RVA: 0x00308936 File Offset: 0x00306B36
	public void updateCustomParams()
	{
		this.OCLHLEBKMJF(this.manCharacter);
		this.OCLHLEBKMJF(this.womanCharacter);
	}

	// Token: 0x060067B5 RID: 26549 RVA: 0x00308E82 File Offset: 0x00307082
	public void HODJDCGPPNI()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.sounds[0], 25f);
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = false;
		NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(-22, 0);
		this.isSoundWork = true;
	}

	// Token: 0x060067B6 RID: 26550 RVA: 0x00308EBC File Offset: 0x003070BC
	public void GGDHIDDKMFF()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.sounds[0], 472f);
		string text = this.inputName.text;
		this.inputName.text = text.Trim();
		bool flag = !Regex.IsMatch(text, ":") | Regex.IsMatch(text, "_Offsets");
		if (text.Length > 57)
		{
			flag = true;
		}
		if (text.Trim() == "")
		{
			flag = false;
		}
		if (!flag)
		{
			this.HGDCANONDKP();
			this.checkButton[8].gameObject.SetActive(true);
			return;
		}
		this.HGDCANONDKP();
		this.checkButton[2].gameObject.SetActive(true);
		NJMHLCGIAJI.IKGFHGKKCPG.OGHNHCDABDO(-30, text);
	}

	// Token: 0x060067B7 RID: 26551 RVA: 0x00308F80 File Offset: 0x00307180
	private void HGDCANONDKP()
	{
		Image[] array = this.checkButton;
		for (int i = 0; i < array.Length; i += 0)
		{
			array[i].gameObject.SetActive(true);
		}
	}

	// Token: 0x060067B8 RID: 26552 RVA: 0x00308FB0 File Offset: 0x003071B0
	public void CPLCIBJPOPJ(int CLBPBJGLHEE)
	{
		this.sexid = CLBPBJGLHEE;
		FBFJFAKAGJG.IKGFHGKKCPG.NILJMALGHBJ(this.sounds[0], 482f);
		if (this.sexid == 0)
		{
			this.beardPanel.gameObject.SetActive(false);
		}
		if (this.sexid == 0)
		{
			this.beardPanel.gameObject.SetActive(false);
		}
	}

	// Token: 0x060067B9 RID: 26553 RVA: 0x00309010 File Offset: 0x00307210
	public void LKJFFPGLMIN()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.sounds[1], 34f);
		string text = this.inputName.text;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.HBJIMCCCNJP(text);
			epmphjgalbe.GOMLLPFFPNP(0);
			epmphjgalbe.GOMLLPFFPNP(this.sexid);
			epmphjgalbe.DLPJFOPBFHN((byte)this.sexid);
			epmphjgalbe.NDNLBOCBCLJ((byte)this.hairColorIndex);
			epmphjgalbe.FMPCBMNCGML((byte)this.topColorIndex);
			epmphjgalbe.FMPCBMNCGML((byte)this.downColorIndex);
			epmphjgalbe.EBLJFDGACCM((byte)this.topCamouflageIndex);
			epmphjgalbe.JFBJCKCHMBC((byte)this.downCamouflageIndex);
			epmphjgalbe.EBLJFDGACCM(JLFJEGIPIMM.IKGFHGKKCPG.EHPEPBAMLBA(this.top_camIntensive));
			epmphjgalbe.HMHLPBLANND(JLFJEGIPIMM.IKGFHGKKCPG.HACAOJFKCIM(this.top_camScale / 1187f));
			epmphjgalbe.MIFHFPILAGD(JLFJEGIPIMM.MHFDIJGJGBJ().HACAOJFKCIM(this.top_camRotate / 596f));
			epmphjgalbe.BLCJKEJDGBI(JLFJEGIPIMM.PKGMBFEMKGP().GOPEIKBDBGE(this.top_hue));
			epmphjgalbe.DILDCOFOGHJ(JLFJEGIPIMM.MHFDIJGJGBJ().HACAOJFKCIM(this.down_camIntensive));
			epmphjgalbe.FMPCBMNCGML(JLFJEGIPIMM.MHFDIJGJGBJ().ADLHPNIFLEH(this.down_camScale / 1989f));
			epmphjgalbe.DILDCOFOGHJ(JLFJEGIPIMM.IKGFHGKKCPG.GOPEIKBDBGE(this.down_camRotate / 1636f));
			epmphjgalbe.BLCJKEJDGBI(JLFJEGIPIMM.PKGMBFEMKGP().EHPEPBAMLBA(this.down_hue));
			epmphjgalbe.NDNLBOCBCLJ(1);
			epmphjgalbe.MIFHFPILAGD(1);
			epmphjgalbe.HMHLPBLANND(1);
			epmphjgalbe.KJDIGAKNOAI(this.beard.isOn);
			epmphjgalbe.IECHKLACNFM(this.mush.isOn);
		}
		finally
		{
			NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(9, epmphjgalbe.HDEKHFOKCKI());
			epmphjgalbe.OGPGOEJFIBO();
		}
		this.isSoundWork = true;
	}

	// Token: 0x060067BA RID: 26554 RVA: 0x003091EC File Offset: 0x003073EC
	public void HCCJIOOPEFD(int CLBPBJGLHEE)
	{
		switch (this.colorMode)
		{
		case 0:
			this.topCamouflageIndex = CLBPBJGLHEE;
			this.downCamouflageIndex = CLBPBJGLHEE;
			break;
		case 1:
			this.topCamouflageIndex = CLBPBJGLHEE;
			break;
		case 2:
			this.downCamouflageIndex = CLBPBJGLHEE;
			break;
		}
		if (this.isSoundWork)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.sounds[1], 1314f);
		}
		this.updateCustomParams();
	}

	// Token: 0x060067BB RID: 26555 RVA: 0x0030925C File Offset: 0x0030745C
	public void LFIBIJGLNBK(int CLBPBJGLHEE)
	{
		switch (this.colorMode)
		{
		case 0:
			this.topCamouflageIndex = CLBPBJGLHEE;
			this.downCamouflageIndex = CLBPBJGLHEE;
			break;
		case 1:
			this.topCamouflageIndex = CLBPBJGLHEE;
			break;
		case 2:
			this.downCamouflageIndex = CLBPBJGLHEE;
			break;
		}
		if (this.isSoundWork)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.sounds[0], 559f);
		}
		this.CEFHEGACAEB();
	}

	// Token: 0x060067BC RID: 26556 RVA: 0x003092C9 File Offset: 0x003074C9
	public void EEBPPKFMPAE()
	{
		this.EGMMCDOLECA(this.manCharacter);
		this.FNHHNPJCCLF(this.womanCharacter);
	}

	// Token: 0x060067BD RID: 26557 RVA: 0x003092E4 File Offset: 0x003074E4
	public void confirm()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.sounds[1], 1f);
		string text = this.inputName.text;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.NEHCMOODKIN(text);
			epmphjgalbe.GOMLLPFFPNP(0);
			epmphjgalbe.GOMLLPFFPNP(this.sexid);
			epmphjgalbe.JFBJCKCHMBC((byte)this.sexid);
			epmphjgalbe.JFBJCKCHMBC((byte)this.hairColorIndex);
			epmphjgalbe.JFBJCKCHMBC((byte)this.topColorIndex);
			epmphjgalbe.JFBJCKCHMBC((byte)this.downColorIndex);
			epmphjgalbe.JFBJCKCHMBC((byte)this.topCamouflageIndex);
			epmphjgalbe.JFBJCKCHMBC((byte)this.downCamouflageIndex);
			epmphjgalbe.JFBJCKCHMBC(JLFJEGIPIMM.IKGFHGKKCPG.KJNFIFFEHDL(this.top_camIntensive));
			epmphjgalbe.JFBJCKCHMBC(JLFJEGIPIMM.IKGFHGKKCPG.KJNFIFFEHDL(this.top_camScale / 5f));
			epmphjgalbe.JFBJCKCHMBC(JLFJEGIPIMM.IKGFHGKKCPG.KJNFIFFEHDL(this.top_camRotate / 1.57f));
			epmphjgalbe.JFBJCKCHMBC(JLFJEGIPIMM.IKGFHGKKCPG.KJNFIFFEHDL(this.top_hue));
			epmphjgalbe.JFBJCKCHMBC(JLFJEGIPIMM.IKGFHGKKCPG.KJNFIFFEHDL(this.down_camIntensive));
			epmphjgalbe.JFBJCKCHMBC(JLFJEGIPIMM.IKGFHGKKCPG.KJNFIFFEHDL(this.down_camScale / 5f));
			epmphjgalbe.JFBJCKCHMBC(JLFJEGIPIMM.IKGFHGKKCPG.KJNFIFFEHDL(this.down_camRotate / 1.57f));
			epmphjgalbe.JFBJCKCHMBC(JLFJEGIPIMM.IKGFHGKKCPG.KJNFIFFEHDL(this.down_hue));
			epmphjgalbe.JFBJCKCHMBC(0);
			epmphjgalbe.JFBJCKCHMBC(0);
			epmphjgalbe.JFBJCKCHMBC(0);
			epmphjgalbe.KJDIGAKNOAI(this.beard.isOn);
			epmphjgalbe.KJDIGAKNOAI(this.mush.isOn);
		}
		finally
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(120, epmphjgalbe.JDPHBLHOLAD());
			epmphjgalbe.LMBPNFHKNGA();
		}
		this.isSoundWork = false;
	}

	// Token: 0x060067BF RID: 26559 RVA: 0x003094D0 File Offset: 0x003076D0
	public void HKLNDFIFMKF(float LJBFPDDMGKP)
	{
		if (FBFJFAKAGJG.IKGFHGKKCPG == null)
		{
			return;
		}
		if (this.PCDBBMBNGOD < Time.time)
		{
			if (this.isSoundWork)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.sounds[0], 1226f);
			}
			this.PCDBBMBNGOD = Time.time + 522f;
		}
		switch (this.colorMode)
		{
		case 0:
			this.top_camScale = this.scale.value;
			this.down_camScale = this.scale.value;
			break;
		case 1:
			this.top_camScale = this.scale.value;
			break;
		case 2:
			this.down_camScale = this.scale.value;
			break;
		}
		this.FNMJNGKALAB();
	}

	// Token: 0x060067C0 RID: 26560 RVA: 0x0030958C File Offset: 0x0030778C
	public void KELGEEJJEBB(float LJBFPDDMGKP)
	{
		if (FBFJFAKAGJG.IKGFHGKKCPG == null)
		{
			return;
		}
		if (this.PCDBBMBNGOD < Time.time)
		{
			if (this.isSoundWork)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.sounds[0], 8f);
			}
			this.PCDBBMBNGOD = Time.time + 1833f;
		}
		switch (this.colorMode)
		{
		case 0:
			this.top_camScale = this.scale.value;
			this.down_camScale = this.scale.value;
			break;
		case 1:
			this.top_camScale = this.scale.value;
			break;
		case 2:
			this.down_camScale = this.scale.value;
			break;
		}
		this.OMPODNMFCPC();
	}

	// Token: 0x060067C1 RID: 26561 RVA: 0x00309647 File Offset: 0x00307847
	private void KKFKFGPMCND()
	{
		CrShadowLogic.getI = this;
	}

	// Token: 0x060067C2 RID: 26562 RVA: 0x0030964F File Offset: 0x0030784F
	public void MPHOGCLGKNL()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.sounds[1], 466f);
		JDCEFOFMGHB.JFIDAGABKID().LHHBOOJPBPH = true;
		NJMHLCGIAJI.EAJGHMMBAFP().PIGIIJLCADJ(-119, 0);
		this.isSoundWork = true;
	}

	// Token: 0x060067C3 RID: 26563 RVA: 0x00309688 File Offset: 0x00307888
	public void EHGADFNNPGG(int CLBPBJGLHEE)
	{
		this.colorMode = CLBPBJGLHEE;
		switch (this.colorMode)
		{
		case 0:
			this.intensive.value = (this.top_camIntensive + this.down_camIntensive) / 1561f;
			this.scale.value = (this.top_camScale + this.down_camScale) / 1274f;
			this.rotate.value = (this.top_camRotate + this.down_camRotate) / 1014f;
			return;
		case 1:
			this.intensive.value = this.top_camIntensive;
			this.scale.value = this.top_camScale;
			this.rotate.value = this.top_camRotate;
			return;
		case 2:
			this.intensive.value = this.down_camIntensive;
			this.scale.value = this.down_camScale;
			this.rotate.value = this.down_camRotate;
			return;
		default:
			return;
		}
	}

	// Token: 0x060067C4 RID: 26564 RVA: 0x00309647 File Offset: 0x00307847
	private void Awake()
	{
		CrShadowLogic.getI = this;
	}

	// Token: 0x060067C5 RID: 26565 RVA: 0x00309778 File Offset: 0x00307978
	public void PIDDGPIAPGH()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.sounds[1], 1397f);
		string text = this.inputName.text;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.GHFGOOJLNJH(text);
			epmphjgalbe.DEHJNGMHGAJ(1);
			epmphjgalbe.EAOGDKDBENC(this.sexid);
			epmphjgalbe.PPNGIKFFNFP((byte)this.sexid);
			epmphjgalbe.PPNGIKFFNFP((byte)this.hairColorIndex);
			epmphjgalbe.EBLJFDGACCM((byte)this.topColorIndex);
			epmphjgalbe.DADJIBEOMAF((byte)this.downColorIndex);
			epmphjgalbe.MIFHFPILAGD((byte)this.topCamouflageIndex);
			epmphjgalbe.BGAOLJGMBOC((byte)this.downCamouflageIndex);
			epmphjgalbe.DILDCOFOGHJ(JLFJEGIPIMM.NNEAHAFBOHC().EHPEPBAMLBA(this.top_camIntensive));
			epmphjgalbe.DADJIBEOMAF(JLFJEGIPIMM.PKGMBFEMKGP().GOPEIKBDBGE(this.top_camScale / 1634f));
			epmphjgalbe.JFBJCKCHMBC(JLFJEGIPIMM.MHFDIJGJGBJ().ADLHPNIFLEH(this.top_camRotate / 1352f));
			epmphjgalbe.DADJIBEOMAF(JLFJEGIPIMM.NNEAHAFBOHC().HACAOJFKCIM(this.top_hue));
			epmphjgalbe.DADJIBEOMAF(JLFJEGIPIMM.NNEAHAFBOHC().ADLHPNIFLEH(this.down_camIntensive));
			epmphjgalbe.JFBJCKCHMBC(JLFJEGIPIMM.PKGMBFEMKGP().EHPEPBAMLBA(this.down_camScale / 1472f));
			epmphjgalbe.DILDCOFOGHJ(JLFJEGIPIMM.PKGMBFEMKGP().GOPEIKBDBGE(this.down_camRotate / 287f));
			epmphjgalbe.MKCKDEDCMOB(JLFJEGIPIMM.NNEAHAFBOHC().KJNFIFFEHDL(this.down_hue));
			epmphjgalbe.HMHLPBLANND(0);
			epmphjgalbe.OJLAPHDEGFH(0);
			epmphjgalbe.DLPJFOPBFHN(0);
			epmphjgalbe.CFIKDLDBNHI(this.beard.isOn);
			epmphjgalbe.KJDIGAKNOAI(this.mush.isOn);
		}
		finally
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(41, epmphjgalbe.LAFILAEOPAJ());
			epmphjgalbe.HDKBMLOJLLC();
		}
		this.isSoundWork = false;
	}

	// Token: 0x060067C6 RID: 26566 RVA: 0x00309954 File Offset: 0x00307B54
	public void hueChange(float LJBFPDDMGKP)
	{
		if (FBFJFAKAGJG.IKGFHGKKCPG == null)
		{
			return;
		}
		if (this.PCDBBMBNGOD < Time.time)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.sounds[2], 0.8f);
			this.PCDBBMBNGOD = Time.time + 0.1f;
		}
		switch (this.colorMode)
		{
		case 0:
			this.top_hue = this.hue.value;
			this.down_hue = this.hue.value;
			break;
		case 1:
			this.top_hue = this.hue.value;
			break;
		case 2:
			this.down_hue = this.hue.value;
			break;
		}
		this.updateCustomParams();
	}

	// Token: 0x060067C7 RID: 26567 RVA: 0x00309A08 File Offset: 0x00307C08
	private void EGMMCDOLECA(Character IFIIFDKAKDJ)
	{
		if (Customizator.getI == null)
		{
			return;
		}
		IFIIFDKAKDJ.isBeardEnable = this.beard.isOn;
		IFIIFDKAKDJ.isMushEnable = this.mush.isOn;
		IFIIFDKAKDJ.hairColor = Customizator.getI.hairColors[this.hairColorIndex];
		IFIIFDKAKDJ.baseTopColor = Customizator.getI.dressColors[this.topColorIndex];
		IFIIFDKAKDJ.baseBottomColor = Customizator.getI.dressColors[this.downColorIndex];
		IFIIFDKAKDJ.camouflageBottom = Customizator.getI.camouflages[this.downCamouflageIndex];
		IFIIFDKAKDJ.camouflageTop = Customizator.getI.camouflages[this.topCamouflageIndex];
		IFIIFDKAKDJ.intensiveTop = this.top_camIntensive;
		IFIIFDKAKDJ.intensiveBottom = this.down_camIntensive;
		IFIIFDKAKDJ.scaleTop = this.top_camScale;
		IFIIFDKAKDJ.scaleBottom = this.down_camScale;
		IFIIFDKAKDJ.rotateTop = this.top_camRotate;
		IFIIFDKAKDJ.rotateBottom = this.down_camRotate;
		IFIIFDKAKDJ.hueTop = this.top_hue;
		IFIIFDKAKDJ.hueBottom = this.down_hue;
	}

	// Token: 0x060067C8 RID: 26568 RVA: 0x00309B24 File Offset: 0x00307D24
	public void FINAMBEDAHJ(int CLBPBJGLHEE)
	{
		this.colorMode = CLBPBJGLHEE;
		switch (this.colorMode)
		{
		case 0:
			this.intensive.value = (this.top_camIntensive + this.down_camIntensive) / 408f;
			this.scale.value = (this.top_camScale + this.down_camScale) / 1647f;
			this.rotate.value = (this.top_camRotate + this.down_camRotate) / 1236f;
			return;
		case 1:
			this.intensive.value = this.top_camIntensive;
			this.scale.value = this.top_camScale;
			this.rotate.value = this.top_camRotate;
			return;
		case 2:
			this.intensive.value = this.down_camIntensive;
			this.scale.value = this.down_camScale;
			this.rotate.value = this.down_camRotate;
			return;
		default:
			return;
		}
	}

	// Token: 0x060067C9 RID: 26569 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x060067CA RID: 26570 RVA: 0x00309C14 File Offset: 0x00307E14
	public void NKOJMDOHJNJ()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.sounds[0], 982f);
		string text = this.inputName.text;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.NEHCMOODKIN(text);
			epmphjgalbe.JDOLCNDNFGP(0);
			epmphjgalbe.JDOLCNDNFGP(this.sexid);
			epmphjgalbe.MKCKDEDCMOB((byte)this.sexid);
			epmphjgalbe.ECBEPOHKLHB((byte)this.hairColorIndex);
			epmphjgalbe.BLCJKEJDGBI((byte)this.topColorIndex);
			epmphjgalbe.BGAOLJGMBOC((byte)this.downColorIndex);
			epmphjgalbe.DLPJFOPBFHN((byte)this.topCamouflageIndex);
			epmphjgalbe.DILDCOFOGHJ((byte)this.downCamouflageIndex);
			epmphjgalbe.MIFHFPILAGD(JLFJEGIPIMM.MHFDIJGJGBJ().EHPEPBAMLBA(this.top_camIntensive));
			epmphjgalbe.BLCJKEJDGBI(JLFJEGIPIMM.IKGFHGKKCPG.KJNFIFFEHDL(this.top_camScale / 1097f));
			epmphjgalbe.EBLJFDGACCM(JLFJEGIPIMM.IKGFHGKKCPG.GOPEIKBDBGE(this.top_camRotate / 799f));
			epmphjgalbe.DADJIBEOMAF(JLFJEGIPIMM.PKGMBFEMKGP().HACAOJFKCIM(this.top_hue));
			epmphjgalbe.NDNLBOCBCLJ(JLFJEGIPIMM.NNEAHAFBOHC().KJNFIFFEHDL(this.down_camIntensive));
			epmphjgalbe.DADJIBEOMAF(JLFJEGIPIMM.IKGFHGKKCPG.KJNFIFFEHDL(this.down_camScale / 1431f));
			epmphjgalbe.BGAOLJGMBOC(JLFJEGIPIMM.MHFDIJGJGBJ().GOPEIKBDBGE(this.down_camRotate / 755f));
			epmphjgalbe.BLCJKEJDGBI(JLFJEGIPIMM.NNEAHAFBOHC().ADLHPNIFLEH(this.down_hue));
			epmphjgalbe.DADJIBEOMAF(0);
			epmphjgalbe.EBLJFDGACCM(1);
			epmphjgalbe.ECBEPOHKLHB(1);
			epmphjgalbe.LNFLEDCCKKF(this.beard.isOn);
			epmphjgalbe.KJDIGAKNOAI(this.mush.isOn);
		}
		finally
		{
			NJMHLCGIAJI.EAJGHMMBAFP().AKJKNCIKBBF(118, epmphjgalbe.JDPHBLHOLAD());
			epmphjgalbe.PGLFHABMJPO();
		}
		this.isSoundWork = true;
	}

	// Token: 0x060067CB RID: 26571 RVA: 0x00309DF0 File Offset: 0x00307FF0
	public void PFBCBDGGLJI(int CLBPBJGLHEE)
	{
		switch (this.colorMode)
		{
		case 0:
			this.topColorIndex = CLBPBJGLHEE;
			this.downColorIndex = CLBPBJGLHEE;
			break;
		case 1:
			this.topColorIndex = CLBPBJGLHEE;
			break;
		case 2:
			this.downColorIndex = CLBPBJGLHEE;
			break;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.sounds[0], 142f);
		this.FNMJNGKALAB();
	}

	// Token: 0x060067CC RID: 26572 RVA: 0x00309E58 File Offset: 0x00308058
	private void Start()
	{
		if (GuiProcessor.IKGFHGKKCPG != null)
		{
			GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA = this.mainCanvas;
		}
		for (int i = 0; i < this.hairColor.Length; i++)
		{
			Color color = Customizator.getI.hairColors[i];
			this.hairColor[i].color = color;
		}
		for (int j = 0; j < this.dressUpColor.Length; j++)
		{
			Color color2 = Customizator.getI.dressColors[j];
			this.dressUpColor[j].color = color2;
		}
		for (int k = 0; k < this.camouflages.Length; k++)
		{
			this.camouflages[k].texture = Customizator.getI.camouflages[k];
		}
		this.manCharacter.changeCostume(0);
		this.womanCharacter.changeCostume(0);
		this.updateCustomParams();
		this.isSoundWork = true;
		this.PCDBBMBNGOD = Time.time + 2f;
		this.setColorMode(0);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = false;
	}

	// Token: 0x060067CD RID: 26573 RVA: 0x00309F60 File Offset: 0x00308160
	public void PJPDFACKINH(int CLBPBJGLHEE)
	{
		switch (this.colorMode)
		{
		case 0:
			this.topColorIndex = CLBPBJGLHEE;
			this.downColorIndex = CLBPBJGLHEE;
			break;
		case 1:
			this.topColorIndex = CLBPBJGLHEE;
			break;
		case 2:
			this.downColorIndex = CLBPBJGLHEE;
			break;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.sounds[1], 509f);
		this.FNMJNGKALAB();
	}

	// Token: 0x060067CE RID: 26574 RVA: 0x00309FC5 File Offset: 0x003081C5
	public void IPOLNGAPEAP(bool HKNKNGIMNPG)
	{
		this.HGDCANONDKP();
		if (HKNKNGIMNPG)
		{
			this.checkButton[0].gameObject.SetActive(true);
			return;
		}
		this.checkButton[7].gameObject.SetActive(false);
	}

	// Token: 0x060067CF RID: 26575 RVA: 0x00309FF8 File Offset: 0x003081F8
	public void PAJBECHLHBI(int CLBPBJGLHEE)
	{
		switch (this.colorMode)
		{
		case 0:
			this.topColorIndex = CLBPBJGLHEE;
			this.downColorIndex = CLBPBJGLHEE;
			break;
		case 1:
			this.topColorIndex = CLBPBJGLHEE;
			break;
		case 2:
			this.downColorIndex = CLBPBJGLHEE;
			break;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.sounds[0], 962f);
		this.EEBPPKFMPAE();
	}

	// Token: 0x060067D0 RID: 26576 RVA: 0x00309647 File Offset: 0x00307847
	private void LHHFHDNBKKC()
	{
		CrShadowLogic.getI = this;
	}

	// Token: 0x060067D1 RID: 26577 RVA: 0x0030A060 File Offset: 0x00308260
	private void OCLHLEBKMJF(Character IFIIFDKAKDJ)
	{
		if (Customizator.getI == null)
		{
			return;
		}
		IFIIFDKAKDJ.isBeardEnable = this.beard.isOn;
		IFIIFDKAKDJ.isMushEnable = this.mush.isOn;
		IFIIFDKAKDJ.hairColor = Customizator.getI.hairColors[this.hairColorIndex];
		IFIIFDKAKDJ.baseTopColor = Customizator.getI.dressColors[this.topColorIndex];
		IFIIFDKAKDJ.baseBottomColor = Customizator.getI.dressColors[this.downColorIndex];
		IFIIFDKAKDJ.camouflageBottom = Customizator.getI.camouflages[this.downCamouflageIndex];
		IFIIFDKAKDJ.camouflageTop = Customizator.getI.camouflages[this.topCamouflageIndex];
		IFIIFDKAKDJ.intensiveTop = this.top_camIntensive;
		IFIIFDKAKDJ.intensiveBottom = this.down_camIntensive;
		IFIIFDKAKDJ.scaleTop = this.top_camScale;
		IFIIFDKAKDJ.scaleBottom = this.down_camScale;
		IFIIFDKAKDJ.rotateTop = this.top_camRotate;
		IFIIFDKAKDJ.rotateBottom = this.down_camRotate;
		IFIIFDKAKDJ.hueTop = this.top_hue;
		IFIIFDKAKDJ.hueBottom = this.down_hue;
	}

	// Token: 0x060067D2 RID: 26578 RVA: 0x0030A17C File Offset: 0x0030837C
	public void setHairColor(int CLBPBJGLHEE)
	{
		this.hairColorIndex = CLBPBJGLHEE;
		if (this.isSoundWork)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.sounds[0], 1f);
		}
		this.updateCustomParams();
	}

	// Token: 0x060067D3 RID: 26579 RVA: 0x0030A1AA File Offset: 0x003083AA
	public void checkNameResult(bool HKNKNGIMNPG)
	{
		this.GLELLFNPCOP();
		if (HKNKNGIMNPG)
		{
			this.checkButton[1].gameObject.SetActive(true);
			return;
		}
		this.checkButton[2].gameObject.SetActive(true);
	}

	// Token: 0x060067D4 RID: 26580 RVA: 0x0030A1DC File Offset: 0x003083DC
	public void NDNOLEFHFDL(int CLBPBJGLHEE)
	{
		this.colorMode = CLBPBJGLHEE;
		switch (this.colorMode)
		{
		case 0:
			this.intensive.value = (this.top_camIntensive + this.down_camIntensive) / 218f;
			this.scale.value = (this.top_camScale + this.down_camScale) / 73f;
			this.rotate.value = (this.top_camRotate + this.down_camRotate) / 1938f;
			return;
		case 1:
			this.intensive.value = this.top_camIntensive;
			this.scale.value = this.top_camScale;
			this.rotate.value = this.top_camRotate;
			return;
		case 2:
			this.intensive.value = this.down_camIntensive;
			this.scale.value = this.down_camScale;
			this.rotate.value = this.down_camRotate;
			return;
		default:
			return;
		}
	}

	// Token: 0x060067D5 RID: 26581 RVA: 0x0030A2CC File Offset: 0x003084CC
	public void rotateChange(float LJBFPDDMGKP)
	{
		if (FBFJFAKAGJG.IKGFHGKKCPG == null)
		{
			return;
		}
		if (this.PCDBBMBNGOD < Time.time)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.sounds[2], 0.8f);
			this.PCDBBMBNGOD = Time.time + 0.1f;
		}
		switch (this.colorMode)
		{
		case 0:
			this.top_camRotate = this.rotate.value;
			this.down_camRotate = this.rotate.value;
			break;
		case 1:
			this.top_camRotate = this.rotate.value;
			break;
		case 2:
			this.down_camRotate = this.rotate.value;
			break;
		}
		this.updateCustomParams();
	}

	// Token: 0x060067D6 RID: 26582 RVA: 0x0030A380 File Offset: 0x00308580
	public void LBJBDPBFGJB()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.sounds[1], 1744f);
		string text = this.inputName.text;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.HGCCFFKDELO(text);
			epmphjgalbe.DEHJNGMHGAJ(1);
			epmphjgalbe.DEHJNGMHGAJ(this.sexid);
			epmphjgalbe.NDNLBOCBCLJ((byte)this.sexid);
			epmphjgalbe.MIFHFPILAGD((byte)this.hairColorIndex);
			epmphjgalbe.OJLAPHDEGFH((byte)this.topColorIndex);
			epmphjgalbe.EBLJFDGACCM((byte)this.downColorIndex);
			epmphjgalbe.NDNLBOCBCLJ((byte)this.topCamouflageIndex);
			epmphjgalbe.DMKPONFMCGH((byte)this.downCamouflageIndex);
			epmphjgalbe.ECBEPOHKLHB(JLFJEGIPIMM.PKGMBFEMKGP().EHPEPBAMLBA(this.top_camIntensive));
			epmphjgalbe.PPNGIKFFNFP(JLFJEGIPIMM.NNEAHAFBOHC().EHPEPBAMLBA(this.top_camScale / 991f));
			epmphjgalbe.EBLJFDGACCM(JLFJEGIPIMM.MHFDIJGJGBJ().GOPEIKBDBGE(this.top_camRotate / 951f));
			epmphjgalbe.DADJIBEOMAF(JLFJEGIPIMM.NNEAHAFBOHC().HACAOJFKCIM(this.top_hue));
			epmphjgalbe.HMHLPBLANND(JLFJEGIPIMM.NNEAHAFBOHC().KJNFIFFEHDL(this.down_camIntensive));
			epmphjgalbe.MIFHFPILAGD(JLFJEGIPIMM.MHFDIJGJGBJ().ADLHPNIFLEH(this.down_camScale / 401f));
			epmphjgalbe.HMHLPBLANND(JLFJEGIPIMM.PKGMBFEMKGP().GOPEIKBDBGE(this.down_camRotate / 827f));
			epmphjgalbe.EBLJFDGACCM(JLFJEGIPIMM.NNEAHAFBOHC().EHPEPBAMLBA(this.down_hue));
			epmphjgalbe.BLCJKEJDGBI(0);
			epmphjgalbe.DILDCOFOGHJ(0);
			epmphjgalbe.FMPCBMNCGML(0);
			epmphjgalbe.KJDIGAKNOAI(this.beard.isOn);
			epmphjgalbe.PJIABBIPPNH(this.mush.isOn);
		}
		finally
		{
			NJMHLCGIAJI.EAJGHMMBAFP().EILLJGEHCOH(81, epmphjgalbe.ALLANCHILCM());
			epmphjgalbe.PMIGGJHLIDO();
		}
		this.isSoundWork = true;
	}

	// Token: 0x060067D7 RID: 26583 RVA: 0x0030A55C File Offset: 0x0030875C
	public void IFLOBPLAIAK(float LJBFPDDMGKP)
	{
		if (FBFJFAKAGJG.IKGFHGKKCPG == null)
		{
			return;
		}
		if (this.PCDBBMBNGOD < Time.time)
		{
			if (this.isSoundWork)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.sounds[7], 418f);
			}
			this.PCDBBMBNGOD = Time.time + 1489f;
		}
		switch (this.colorMode)
		{
		case 0:
			this.top_camScale = this.scale.value;
			this.down_camScale = this.scale.value;
			break;
		case 1:
			this.top_camScale = this.scale.value;
			break;
		case 2:
			this.down_camScale = this.scale.value;
			break;
		}
		this.EEBPPKFMPAE();
	}

	// Token: 0x060067D8 RID: 26584 RVA: 0x0030A618 File Offset: 0x00308818
	public void BDOKPFJFCFC(int CLBPBJGLHEE)
	{
		switch (this.colorMode)
		{
		case 0:
			this.topCamouflageIndex = CLBPBJGLHEE;
			this.downCamouflageIndex = CLBPBJGLHEE;
			break;
		case 1:
			this.topCamouflageIndex = CLBPBJGLHEE;
			break;
		case 2:
			this.downCamouflageIndex = CLBPBJGLHEE;
			break;
		}
		if (this.isSoundWork)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.sounds[0], 1106f);
		}
		this.updateCustomParams();
	}

	// Token: 0x060067D9 RID: 26585 RVA: 0x0030A688 File Offset: 0x00308888
	public void setColorMode(int CLBPBJGLHEE)
	{
		this.colorMode = CLBPBJGLHEE;
		switch (this.colorMode)
		{
		case 0:
			this.intensive.value = (this.top_camIntensive + this.down_camIntensive) / 2f;
			this.scale.value = (this.top_camScale + this.down_camScale) / 2f;
			this.rotate.value = (this.top_camRotate + this.down_camRotate) / 2f;
			return;
		case 1:
			this.intensive.value = this.top_camIntensive;
			this.scale.value = this.top_camScale;
			this.rotate.value = this.top_camRotate;
			return;
		case 2:
			this.intensive.value = this.down_camIntensive;
			this.scale.value = this.down_camScale;
			this.rotate.value = this.down_camRotate;
			return;
		default:
			return;
		}
	}

	// Token: 0x060067DA RID: 26586 RVA: 0x0030A778 File Offset: 0x00308978
	public void setSexId(int CLBPBJGLHEE)
	{
		this.sexid = CLBPBJGLHEE;
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.sounds[1], 1f);
		if (this.sexid == 0)
		{
			this.beardPanel.gameObject.SetActive(false);
		}
		if (this.sexid == 1)
		{
			this.beardPanel.gameObject.SetActive(true);
		}
	}

	// Token: 0x060067DB RID: 26587 RVA: 0x0030A7D6 File Offset: 0x003089D6
	public void OMPODNMFCPC()
	{
		this.FNHHNPJCCLF(this.manCharacter);
		this.EGMMCDOLECA(this.womanCharacter);
	}

	// Token: 0x060067DC RID: 26588 RVA: 0x0030A7F0 File Offset: 0x003089F0
	public void setTopColor(int CLBPBJGLHEE)
	{
		switch (this.colorMode)
		{
		case 0:
			this.topColorIndex = CLBPBJGLHEE;
			this.downColorIndex = CLBPBJGLHEE;
			break;
		case 1:
			this.topColorIndex = CLBPBJGLHEE;
			break;
		case 2:
			this.downColorIndex = CLBPBJGLHEE;
			break;
		}
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.sounds[0], 1f);
		this.updateCustomParams();
	}

	// Token: 0x060067DD RID: 26589 RVA: 0x0030A858 File Offset: 0x00308A58
	private void GLELLFNPCOP()
	{
		Image[] array = this.checkButton;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].gameObject.SetActive(false);
		}
	}

	// Token: 0x060067DE RID: 26590 RVA: 0x0030A888 File Offset: 0x00308A88
	private void MKNPFMEMOJO()
	{
		if (GuiProcessor.IKGFHGKKCPG != null)
		{
			GuiProcessor.IKGFHGKKCPG.BJBJKLMJLCA = this.mainCanvas;
		}
		for (int i = 0; i < this.hairColor.Length; i += 0)
		{
			Color color = Customizator.getI.hairColors[i];
			this.hairColor[i].color = color;
		}
		for (int j = 1; j < this.dressUpColor.Length; j++)
		{
			Color color2 = Customizator.getI.dressColors[j];
			this.dressUpColor[j].color = color2;
		}
		for (int k = 0; k < this.camouflages.Length; k += 0)
		{
			this.camouflages[k].texture = Customizator.getI.camouflages[k];
		}
		this.manCharacter.changeCostume(0);
		this.womanCharacter.changeCostume(0);
		this.EEBPPKFMPAE();
		this.isSoundWork = true;
		this.PCDBBMBNGOD = Time.time + 1578f;
		this.FINAMBEDAHJ(0);
		JDCEFOFMGHB.MNJNNDHCDGG().MDBKHKBJNAO(false);
	}

	// Token: 0x060067DF RID: 26591 RVA: 0x0030A990 File Offset: 0x00308B90
	public void OMFOAGLGANO(bool HKNKNGIMNPG)
	{
		this.GLELLFNPCOP();
		if (HKNKNGIMNPG)
		{
			this.checkButton[1].gameObject.SetActive(false);
			return;
		}
		this.checkButton[1].gameObject.SetActive(false);
	}

	// Token: 0x060067E0 RID: 26592 RVA: 0x0030A9C4 File Offset: 0x00308BC4
	public void EAGKOKDJLCO(float LJBFPDDMGKP)
	{
		if (FBFJFAKAGJG.IKGFHGKKCPG == null)
		{
			return;
		}
		if (this.PCDBBMBNGOD < Time.time)
		{
			if (this.isSoundWork)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.sounds[8], 1493f);
			}
			this.PCDBBMBNGOD = Time.time + 321f;
		}
		switch (this.colorMode)
		{
		case 0:
			this.top_camScale = this.scale.value;
			this.down_camScale = this.scale.value;
			break;
		case 1:
			this.top_camScale = this.scale.value;
			break;
		case 2:
			this.down_camScale = this.scale.value;
			break;
		}
		this.CEFHEGACAEB();
	}

	// Token: 0x060067E1 RID: 26593 RVA: 0x0030AA80 File Offset: 0x00308C80
	public void CKMCINKKPDC(float LJBFPDDMGKP)
	{
		if (FBFJFAKAGJG.IKGFHGKKCPG == null)
		{
			return;
		}
		if (this.PCDBBMBNGOD < Time.time)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.MLFGLEOKDFB(this.sounds[8], 768f);
			this.PCDBBMBNGOD = Time.time + 1851f;
		}
		switch (this.colorMode)
		{
		case 0:
			this.top_camRotate = this.rotate.value;
			this.down_camRotate = this.rotate.value;
			break;
		case 1:
			this.top_camRotate = this.rotate.value;
			break;
		case 2:
			this.down_camRotate = this.rotate.value;
			break;
		}
		this.OMPODNMFCPC();
	}

	// Token: 0x060067E2 RID: 26594 RVA: 0x0030AB33 File Offset: 0x00308D33
	public void CEFHEGACAEB()
	{
		this.FNHHNPJCCLF(this.manCharacter);
		this.FNHHNPJCCLF(this.womanCharacter);
	}

	// Token: 0x060067E3 RID: 26595 RVA: 0x0030AB4D File Offset: 0x00308D4D
	public void INNFHNHGOKN()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.DMPNAMJAOKN(this.sounds[0], 397f);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		NJMHLCGIAJI.EAJGHMMBAFP().KCONDIDKLIB(-119, 1);
		this.isSoundWork = true;
	}

	// Token: 0x060067E4 RID: 26596 RVA: 0x0030AB88 File Offset: 0x00308D88
	public void BIHFAAKGLEE(float LJBFPDDMGKP)
	{
		if (FBFJFAKAGJG.IKGFHGKKCPG == null)
		{
			return;
		}
		if (this.PCDBBMBNGOD < Time.time)
		{
			if (this.isSoundWork)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.sounds[1], 1147f);
			}
			this.PCDBBMBNGOD = Time.time + 1163f;
		}
		switch (this.colorMode)
		{
		case 0:
			this.top_camIntensive = this.intensive.value;
			this.down_camIntensive = this.intensive.value;
			break;
		case 1:
			this.top_camIntensive = this.intensive.value;
			break;
		case 2:
			this.down_camIntensive = this.intensive.value;
			break;
		}
		this.FNMJNGKALAB();
	}

	// Token: 0x060067E5 RID: 26597 RVA: 0x0030AC44 File Offset: 0x00308E44
	public void scaleChange(float LJBFPDDMGKP)
	{
		if (FBFJFAKAGJG.IKGFHGKKCPG == null)
		{
			return;
		}
		if (this.PCDBBMBNGOD < Time.time)
		{
			if (this.isSoundWork)
			{
				FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.sounds[2], 0.8f);
			}
			this.PCDBBMBNGOD = Time.time + 0.1f;
		}
		switch (this.colorMode)
		{
		case 0:
			this.top_camScale = this.scale.value;
			this.down_camScale = this.scale.value;
			break;
		case 1:
			this.top_camScale = this.scale.value;
			break;
		case 2:
			this.down_camScale = this.scale.value;
			break;
		}
		this.updateCustomParams();
	}

	// Token: 0x060067E6 RID: 26598 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PMKOAHMNBBG()
	{
	}

	// Token: 0x060067E7 RID: 26599 RVA: 0x0030ACFF File Offset: 0x00308EFF
	public void cancel()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.sounds[0], 1f);
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(112, 0);
		this.isSoundWork = false;
	}

	// Token: 0x060067E8 RID: 26600 RVA: 0x0030AD38 File Offset: 0x00308F38
	public void MLOJIBJMAKH()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.IMNNEDBALAB(this.sounds[0], 550f);
		string text = this.inputName.text;
		EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
		try
		{
			epmphjgalbe.FINMMGHAHFI(text);
			epmphjgalbe.EAOGDKDBENC(0);
			epmphjgalbe.AEMAHNDEBKJ(this.sexid);
			epmphjgalbe.MKCKDEDCMOB((byte)this.sexid);
			epmphjgalbe.JFBJCKCHMBC((byte)this.hairColorIndex);
			epmphjgalbe.DMKPONFMCGH((byte)this.topColorIndex);
			epmphjgalbe.DADJIBEOMAF((byte)this.downColorIndex);
			epmphjgalbe.OJLAPHDEGFH((byte)this.topCamouflageIndex);
			epmphjgalbe.EBLJFDGACCM((byte)this.downCamouflageIndex);
			epmphjgalbe.NDNLBOCBCLJ(JLFJEGIPIMM.IKGFHGKKCPG.ADLHPNIFLEH(this.top_camIntensive));
			epmphjgalbe.DILDCOFOGHJ(JLFJEGIPIMM.MHFDIJGJGBJ().KJNFIFFEHDL(this.top_camScale / 1106f));
			epmphjgalbe.DILDCOFOGHJ(JLFJEGIPIMM.PKGMBFEMKGP().KJNFIFFEHDL(this.top_camRotate / 1375f));
			epmphjgalbe.BLCJKEJDGBI(JLFJEGIPIMM.NNEAHAFBOHC().KJNFIFFEHDL(this.top_hue));
			epmphjgalbe.DLPJFOPBFHN(JLFJEGIPIMM.MHFDIJGJGBJ().ADLHPNIFLEH(this.down_camIntensive));
			epmphjgalbe.MKCKDEDCMOB(JLFJEGIPIMM.PKGMBFEMKGP().GOPEIKBDBGE(this.down_camScale / 1232f));
			epmphjgalbe.MIFHFPILAGD(JLFJEGIPIMM.MHFDIJGJGBJ().KJNFIFFEHDL(this.down_camRotate / 1009f));
			epmphjgalbe.MKCKDEDCMOB(JLFJEGIPIMM.IKGFHGKKCPG.ADLHPNIFLEH(this.down_hue));
			epmphjgalbe.DLPJFOPBFHN(1);
			epmphjgalbe.DILDCOFOGHJ(0);
			epmphjgalbe.DMKPONFMCGH(1);
			epmphjgalbe.PBBCKDDLNLE(this.beard.isOn);
			epmphjgalbe.PBBCKDDLNLE(this.mush.isOn);
		}
		finally
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-55, epmphjgalbe.IEJLLFECFHF());
			epmphjgalbe.LMBPNFHKNGA();
		}
		this.isSoundWork = false;
	}

	// Token: 0x060067E9 RID: 26601 RVA: 0x0030AF14 File Offset: 0x00309114
	public void checkName()
	{
		FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.sounds[1], 1f);
		string text = this.inputName.text;
		this.inputName.text = text.Trim();
		bool flag = !Regex.IsMatch(text, "[^а-яА-Я\\d_]") | !Regex.IsMatch(text, "[^a-zA-z\\d_]");
		if (text.Length > 12)
		{
			flag = false;
		}
		if (text.Trim() == "")
		{
			flag = false;
		}
		if (!flag)
		{
			this.GLELLFNPCOP();
			this.checkButton[2].gameObject.SetActive(true);
			return;
		}
		this.GLELLFNPCOP();
		this.checkButton[3].gameObject.SetActive(true);
		NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(115, text);
	}

	// Token: 0x060067EA RID: 26602 RVA: 0x0030AFD8 File Offset: 0x003091D8
	public void setCamouflage(int CLBPBJGLHEE)
	{
		switch (this.colorMode)
		{
		case 0:
			this.topCamouflageIndex = CLBPBJGLHEE;
			this.downCamouflageIndex = CLBPBJGLHEE;
			break;
		case 1:
			this.topCamouflageIndex = CLBPBJGLHEE;
			break;
		case 2:
			this.downCamouflageIndex = CLBPBJGLHEE;
			break;
		}
		if (this.isSoundWork)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.OPLJOEMHEPG(this.sounds[0], 1f);
		}
		this.updateCustomParams();
	}

	// Token: 0x060067EB RID: 26603 RVA: 0x0030B048 File Offset: 0x00309248
	public void PBCACGJPKIE(float LJBFPDDMGKP)
	{
		if (FBFJFAKAGJG.IKGFHGKKCPG == null)
		{
			return;
		}
		if (this.PCDBBMBNGOD < Time.time)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.MKDDNDEJOEE(this.sounds[0], 50f);
			this.PCDBBMBNGOD = Time.time + 110f;
		}
		switch (this.colorMode)
		{
		case 0:
			this.top_camRotate = this.rotate.value;
			this.down_camRotate = this.rotate.value;
			break;
		case 1:
			this.top_camRotate = this.rotate.value;
			break;
		case 2:
			this.down_camRotate = this.rotate.value;
			break;
		}
		this.EEBPPKFMPAE();
	}

	// Token: 0x04000ECD RID: 3789
	public static CrShadowLogic getI;

	// Token: 0x04000ECE RID: 3790
	public InputField inputName;

	// Token: 0x04000ECF RID: 3791
	public Image[] checkButton;

	// Token: 0x04000ED0 RID: 3792
	public RectTransform beardPanel;

	// Token: 0x04000ED1 RID: 3793
	public Toggle beard;

	// Token: 0x04000ED2 RID: 3794
	public Toggle mush;

	// Token: 0x04000ED3 RID: 3795
	public AudioClip[] sounds;

	// Token: 0x04000ED4 RID: 3796
	public RectTransform mainCanvas;

	// Token: 0x04000ED5 RID: 3797
	public Image[] hairColor;

	// Token: 0x04000ED6 RID: 3798
	public Image[] dressUpColor;

	// Token: 0x04000ED7 RID: 3799
	public Image[] dressDownColor;

	// Token: 0x04000ED8 RID: 3800
	public RawImage[] camouflages;

	// Token: 0x04000ED9 RID: 3801
	public Character manCharacter;

	// Token: 0x04000EDA RID: 3802
	public Character womanCharacter;

	// Token: 0x04000EDB RID: 3803
	public Slider intensive;

	// Token: 0x04000EDC RID: 3804
	public Slider scale;

	// Token: 0x04000EDD RID: 3805
	public Slider rotate;

	// Token: 0x04000EDE RID: 3806
	public Slider hue;

	// Token: 0x04000EDF RID: 3807
	public int hairColorIndex;

	// Token: 0x04000EE0 RID: 3808
	public int sexid = 1;

	// Token: 0x04000EE1 RID: 3809
	public int topColorIndex;

	// Token: 0x04000EE2 RID: 3810
	public int downColorIndex;

	// Token: 0x04000EE3 RID: 3811
	public int topCamouflageIndex;

	// Token: 0x04000EE4 RID: 3812
	public int downCamouflageIndex;

	// Token: 0x04000EE5 RID: 3813
	public float top_camIntensive;

	// Token: 0x04000EE6 RID: 3814
	public float top_camScale;

	// Token: 0x04000EE7 RID: 3815
	public float top_camRotate;

	// Token: 0x04000EE8 RID: 3816
	public float top_hue;

	// Token: 0x04000EE9 RID: 3817
	public float down_camIntensive;

	// Token: 0x04000EEA RID: 3818
	public float down_camScale;

	// Token: 0x04000EEB RID: 3819
	public float down_camRotate;

	// Token: 0x04000EEC RID: 3820
	public float down_hue;

	// Token: 0x04000EED RID: 3821
	public int colorMode;

	// Token: 0x04000EEE RID: 3822
	private float PCDBBMBNGOD;

	// Token: 0x04000EEF RID: 3823
	private const float DDGNOMHHIGL = 0.1f;

	// Token: 0x04000EF0 RID: 3824
	public bool isSoundWork;
}
