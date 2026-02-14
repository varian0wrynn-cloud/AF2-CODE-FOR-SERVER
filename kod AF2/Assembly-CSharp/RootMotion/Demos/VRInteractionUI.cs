using System;
using UnityEngine;
using UnityEngine.UI;

namespace RootMotion.Demos
{
	// Token: 0x02000425 RID: 1061
	[RequireComponent(typeof(VRInteractionController))]
	public class VRInteractionUI : MonoBehaviour
	{
		// Token: 0x0600E507 RID: 58631 RVA: 0x00683B49 File Offset: 0x00681D49
		private void NCALLFHEAGJ()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E508 RID: 58632 RVA: 0x00683B68 File Offset: 0x00681D68
		private void GLKCMHPEOCD(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 1; i < hmhfilmohef.Length; i++)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E509 RID: 58633 RVA: 0x00683C30 File Offset: 0x00681E30
		private void OAAIOBFBMGL()
		{
			if (!(this.OHMDFFJJGIB.MBKGOFMFPGB() != null) || !(this.OHMDFFJJGIB.KPGNOBCIMGN().tag == "Crouch180") || !(this.OHMDFFJJGIB.NKKKJBOMCID.raycastHit.collider != null))
			{
				this.cursor.gameObject.SetActive(true);
				return;
			}
			this.cursor.gameObject.SetActive(false);
			this.cursor.transform.position = this.OHMDFFJJGIB.GAPEIEFBDLI().raycastHit.point;
		}

		// Token: 0x0600E50A RID: 58634 RVA: 0x00683B49 File Offset: 0x00681D49
		private void OBJCOJEHLBE()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E50B RID: 58635 RVA: 0x00683CD4 File Offset: 0x00681ED4
		private void LCOIGEFOHPO(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			foreach (Image image in this.HMHFILMOHEF)
			{
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E50C RID: 58636 RVA: 0x00683B49 File Offset: 0x00681D49
		private void HDFCIACDDEK()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E50D RID: 58637 RVA: 0x00683D9C File Offset: 0x00681F9C
		private void CPMDOHDLJKJ()
		{
			if (this.OHMDFFJJGIB.KJMIHEHFOLH <= 441f || this.OHMDFFJJGIB.FPKOBFGANLF() == null)
			{
				this.slider.gameObject.SetActive(true);
				return;
			}
			this.slider.gameObject.SetActive(false);
			this.slider.transform.rotation = this.OHMDFFJJGIB.KPGNOBCIMGN().transform.GetChild(0).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.MBKGOFMFPGB().transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.EHPGCHIAABB();
			this.BKPDPKFBAAO(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E50E RID: 58638 RVA: 0x00683E79 File Offset: 0x00682079
		private void KJJEEMEHGBF()
		{
			this.EMENFLALHAG();
			this.FCCMIBDAEHE();
		}

		// Token: 0x0600E50F RID: 58639 RVA: 0x00683E88 File Offset: 0x00682088
		private void BKPDPKFBAAO(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			foreach (Image image in this.HMHFILMOHEF)
			{
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E510 RID: 58640 RVA: 0x00683F50 File Offset: 0x00682150
		private void BBJFLPPJMBM(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			foreach (Image image in this.HMHFILMOHEF)
			{
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E511 RID: 58641 RVA: 0x00684018 File Offset: 0x00682218
		private void ADPPDDMEAFP()
		{
			if (this.OHMDFFJJGIB.FBNDMNHOLCC() <= 484f || this.OHMDFFJJGIB.AIJMPPDDPAJ() == null)
			{
				this.slider.gameObject.SetActive(false);
				return;
			}
			this.slider.gameObject.SetActive(false);
			this.slider.transform.rotation = this.OHMDFFJJGIB.MBKGOFMFPGB().transform.GetChild(1).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.IDBDKDPCOFP().transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.GHMILFJKOLO();
			this.KGHHPPKKOGB(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E512 RID: 58642 RVA: 0x006840F8 File Offset: 0x006822F8
		private void FAMJAPBJIJA()
		{
			if (this.OHMDFFJJGIB.GHMILFJKOLO() <= 1268f || this.OHMDFFJJGIB.KGDCNCOLMMN() == null)
			{
				this.slider.gameObject.SetActive(false);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.MJNGPLEFGCF().transform.GetChild(1).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.IAJBJGHGKBL().transform.GetChild(0).position;
			this.slider.value = this.OHMDFFJJGIB.MCOBIODLBDI();
			this.JBLFFBCKLOK(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E513 RID: 58643 RVA: 0x006841D8 File Offset: 0x006823D8
		private void NENLINJCHNI()
		{
			if (this.OHMDFFJJGIB.GHLDLEAGMEI() <= 1785f || this.OHMDFFJJGIB.MBKGOFMFPGB() == null)
			{
				this.slider.gameObject.SetActive(false);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.MJNGPLEFGCF().transform.GetChild(0).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.LFHGAGCCPJK().transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.FAGFFGONMAP();
			this.HDBHLJPBLLA(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E514 RID: 58644 RVA: 0x006842B8 File Offset: 0x006824B8
		private void HLHLLKGBEID()
		{
			if (this.OHMDFFJJGIB.EHPGCHIAABB() <= 150f || this.OHMDFFJJGIB.IAJBJGHGKBL() == null)
			{
				this.slider.gameObject.SetActive(true);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.FPKOBFGANLF().transform.GetChild(1).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.IDBDKDPCOFP().transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.DCPOBODKEOB();
			this.GLKCMHPEOCD(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E515 RID: 58645 RVA: 0x00683B49 File Offset: 0x00681D49
		private void OALIDDIKLHK()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E516 RID: 58646 RVA: 0x00684398 File Offset: 0x00682598
		private void MAHFAAIEGAN(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 1; i < hmhfilmohef.Length; i += 0)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E517 RID: 58647 RVA: 0x00684460 File Offset: 0x00682660
		private void LJOCNMINLEI(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 1; i < hmhfilmohef.Length; i += 0)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E518 RID: 58648 RVA: 0x00684528 File Offset: 0x00682728
		private void HBEKKFONDCA()
		{
			if (this.OHMDFFJJGIB.KJMIHEHFOLH <= 247f || this.OHMDFFJJGIB.KPGNOBCIMGN() == null)
			{
				this.slider.gameObject.SetActive(true);
				return;
			}
			this.slider.gameObject.SetActive(false);
			this.slider.transform.rotation = this.OHMDFFJJGIB.PBDDPMCAPKA.transform.GetChild(0).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.GIMFIMLNIEA().transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.GHMILFJKOLO();
			this.KGHHPPKKOGB(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E519 RID: 58649 RVA: 0x00684608 File Offset: 0x00682808
		private void MKPEAMKAEPM(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 0; i < hmhfilmohef.Length; i += 0)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E51A RID: 58650 RVA: 0x006846D0 File Offset: 0x006828D0
		private void DBGODKGLCJE()
		{
			if (this.OHMDFFJJGIB.LPJIKGEKOKJ() <= 1873f || this.OHMDFFJJGIB.KPGNOBCIMGN() == null)
			{
				this.slider.gameObject.SetActive(true);
				return;
			}
			this.slider.gameObject.SetActive(false);
			this.slider.transform.rotation = this.OHMDFFJJGIB.PBDDPMCAPKA.transform.GetChild(1).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.AIJMPPDDPAJ().transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.FAGFFGONMAP();
			this.HLPIDFKFOIL(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E51B RID: 58651 RVA: 0x00683B49 File Offset: 0x00681D49
		private void OLBDJCFPKFG()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E51C RID: 58652 RVA: 0x006847B0 File Offset: 0x006829B0
		private void AFMJGHICIJC(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 0; i < hmhfilmohef.Length; i += 0)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E51D RID: 58653 RVA: 0x00684878 File Offset: 0x00682A78
		private void BMMNNNGHJIO()
		{
			if (this.OHMDFFJJGIB.DLIEOAAFMHL() <= 681f || this.OHMDFFJJGIB.PBDDPMCAPKA == null)
			{
				this.slider.gameObject.SetActive(true);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.KGDCNCOLMMN().transform.GetChild(1).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.PBDDPMCAPKA.transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.FBNDMNHOLCC();
			this.KGHHPPKKOGB(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E51E RID: 58654 RVA: 0x00684958 File Offset: 0x00682B58
		private void BLBEBAPDLHL()
		{
			if (this.OHMDFFJJGIB.PKGJCDMDILP() <= 1185f || this.OHMDFFJJGIB.IDBDKDPCOFP() == null)
			{
				this.slider.gameObject.SetActive(false);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.IDBDKDPCOFP().transform.GetChild(1).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.LFHGAGCCPJK().transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.DLIEOAAFMHL();
			this.JGGFDGFFDII(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E51F RID: 58655 RVA: 0x00684A38 File Offset: 0x00682C38
		private void IBCNMJJEJLH()
		{
			if (!(this.OHMDFFJJGIB.MJNGPLEFGCF() != null) || !(this.OHMDFFJJGIB.AIJMPPDDPAJ().tag == " ") || !(this.OHMDFFJJGIB.LPJKHKHNNBC().raycastHit.collider != null))
			{
				this.cursor.gameObject.SetActive(true);
				return;
			}
			this.cursor.gameObject.SetActive(false);
			this.cursor.transform.position = this.OHMDFFJJGIB.FLLBMMPKPHD().raycastHit.point;
		}

		// Token: 0x0600E520 RID: 58656 RVA: 0x00684ADC File Offset: 0x00682CDC
		private void JMADNGKBHCK()
		{
			if (this.OHMDFFJJGIB.KJMIHEHFOLH <= 155f || this.OHMDFFJJGIB.MJNGPLEFGCF() == null)
			{
				this.slider.gameObject.SetActive(false);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.AIJMPPDDPAJ().transform.GetChild(1).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.GIMFIMLNIEA().transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.KJMIHEHFOLH;
			this.LCOIGEFOHPO(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E521 RID: 58657 RVA: 0x00683B49 File Offset: 0x00681D49
		private void ECMAANIDEBA()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E522 RID: 58658 RVA: 0x00683B49 File Offset: 0x00681D49
		private void Start()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E523 RID: 58659 RVA: 0x00683B49 File Offset: 0x00681D49
		private void OPNPODKLOJK()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E524 RID: 58660 RVA: 0x00684BB9 File Offset: 0x00682DB9
		private void PMKOAHMNBBG()
		{
			this.NENLINJCHNI();
			this.ELHFGOGNGDF();
		}

		// Token: 0x0600E525 RID: 58661 RVA: 0x00684BC8 File Offset: 0x00682DC8
		private void HCNFFCGAHKI(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			foreach (Image image in this.HMHFILMOHEF)
			{
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E526 RID: 58662 RVA: 0x00684C8D File Offset: 0x00682E8D
		private void PBFKCKCHEAC()
		{
			this.GIHJLFGLJCJ();
			this.FNIJFEGBELL();
		}

		// Token: 0x0600E527 RID: 58663 RVA: 0x00684C9C File Offset: 0x00682E9C
		private void NIMMNLCFNPI(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 1; i < hmhfilmohef.Length; i += 0)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E528 RID: 58664 RVA: 0x00683B49 File Offset: 0x00681D49
		private void CBLGFOFHNPJ()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E529 RID: 58665 RVA: 0x00683B49 File Offset: 0x00681D49
		private void KEMGOLACEHI()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E52A RID: 58666 RVA: 0x00684D64 File Offset: 0x00682F64
		private void PMCGEONKEKC(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			foreach (Image image in this.HMHFILMOHEF)
			{
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E52B RID: 58667 RVA: 0x00684E29 File Offset: 0x00683029
		private void PFPPDNHLCCA()
		{
			this.HLHLLKGBEID();
			this.OAAIOBFBMGL();
		}

		// Token: 0x0600E52C RID: 58668 RVA: 0x00684E37 File Offset: 0x00683037
		private void MFHGOLNLAAF()
		{
			this.BGHAKFFPNJH();
			this.BEOCBOINODD();
		}

		// Token: 0x0600E52D RID: 58669 RVA: 0x00684E48 File Offset: 0x00683048
		private void HDBHLJPBLLA(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 1; i < hmhfilmohef.Length; i += 0)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E52E RID: 58670 RVA: 0x00684F10 File Offset: 0x00683110
		private void GINIOCCNBCG()
		{
			if (this.OHMDFFJJGIB.KJMIHEHFOLH <= 0f || this.OHMDFFJJGIB.PBDDPMCAPKA == null)
			{
				this.slider.gameObject.SetActive(false);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.PBDDPMCAPKA.transform.GetChild(0).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.PBDDPMCAPKA.transform.GetChild(0).position;
			this.slider.value = this.OHMDFFJJGIB.KJMIHEHFOLH;
			this.PMCGEONKEKC(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E52F RID: 58671 RVA: 0x00684FF0 File Offset: 0x006831F0
		private void FKAJPFKOLCE()
		{
			if (this.OHMDFFJJGIB.GHMILFJKOLO() <= 199f || this.OHMDFFJJGIB.IDBDKDPCOFP() == null)
			{
				this.slider.gameObject.SetActive(true);
				return;
			}
			this.slider.gameObject.SetActive(false);
			this.slider.transform.rotation = this.OHMDFFJJGIB.MJNGPLEFGCF().transform.GetChild(1).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.KGDCNCOLMMN().transform.GetChild(0).position;
			this.slider.value = this.OHMDFFJJGIB.JJKGFBNMEJE();
			this.LCOIGEFOHPO(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E530 RID: 58672 RVA: 0x006850CD File Offset: 0x006832CD
		private void DPGECEOMHNM()
		{
			this.DLJDPBMFBGO();
			this.ELHFGOGNGDF();
		}

		// Token: 0x0600E531 RID: 58673 RVA: 0x006850DC File Offset: 0x006832DC
		private void BHABLIEGMFJ(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 1; i < hmhfilmohef.Length; i += 0)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E532 RID: 58674 RVA: 0x006851A4 File Offset: 0x006833A4
		private void KPIPGGGEPLE()
		{
			if (!(this.OHMDFFJJGIB.IAJBJGHGKBL() != null) || !(this.OHMDFFJJGIB.MBKGOFMFPGB().tag == "") || !(this.OHMDFFJJGIB.DGGCDPPAOFO().raycastHit.collider != null))
			{
				this.cursor.gameObject.SetActive(false);
				return;
			}
			this.cursor.gameObject.SetActive(true);
			this.cursor.transform.position = this.OHMDFFJJGIB.DOAKKNJFONO().raycastHit.point;
		}

		// Token: 0x0600E533 RID: 58675 RVA: 0x00683B49 File Offset: 0x00681D49
		private void LHJCHPFKGDB()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E534 RID: 58676 RVA: 0x00683B49 File Offset: 0x00681D49
		private void ANHOOJFEJJE()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E535 RID: 58677 RVA: 0x00685248 File Offset: 0x00683448
		private void PHEDKCCFBGH(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			foreach (Image image in this.HMHFILMOHEF)
			{
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E536 RID: 58678 RVA: 0x00683B49 File Offset: 0x00681D49
		private void MODJFGGIAHD()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E537 RID: 58679 RVA: 0x0068530D File Offset: 0x0068350D
		private void EDANNBFJHIK()
		{
			this.FEMKACJPBEK();
			this.OAAIOBFBMGL();
		}

		// Token: 0x0600E538 RID: 58680 RVA: 0x00683B49 File Offset: 0x00681D49
		private void BFBBJILCKAK()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E539 RID: 58681 RVA: 0x0068531B File Offset: 0x0068351B
		private void MEIOHFKFEME()
		{
			this.CMNENOKCKMN();
			this.KPIPGGGEPLE();
		}

		// Token: 0x0600E53A RID: 58682 RVA: 0x0068532C File Offset: 0x0068352C
		private void BOBAPICDBAB()
		{
			if (!(this.OHMDFFJJGIB.MBKGOFMFPGB() != null) || !(this.OHMDFFJJGIB.IAJBJGHGKBL().tag == "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_biped_i_k.html") || !(this.OHMDFFJJGIB.GGFPEIIGHMM().raycastHit.collider != null))
			{
				this.cursor.gameObject.SetActive(false);
				return;
			}
			this.cursor.gameObject.SetActive(true);
			this.cursor.transform.position = this.OHMDFFJJGIB.CAEMKCHHLOJ().raycastHit.point;
		}

		// Token: 0x0600E53B RID: 58683 RVA: 0x006853D0 File Offset: 0x006835D0
		private void OJHKOCKJBMP()
		{
			if (!(this.OHMDFFJJGIB.PBDDPMCAPKA != null) || !(this.OHMDFFJJGIB.PBDDPMCAPKA.tag == "ShowCursor") || !(this.OHMDFFJJGIB.NKKKJBOMCID.raycastHit.collider != null))
			{
				this.cursor.gameObject.SetActive(false);
				return;
			}
			this.cursor.gameObject.SetActive(true);
			this.cursor.transform.position = this.OHMDFFJJGIB.NKKKJBOMCID.raycastHit.point;
		}

		// Token: 0x0600E53C RID: 58684 RVA: 0x00685474 File Offset: 0x00683674
		private void LLAIOMJPCJO()
		{
			if (!(this.OHMDFFJJGIB.IAJBJGHGKBL() != null) || !(this.OHMDFFJJGIB.IDBDKDPCOFP().tag == "isPersonal") || !(this.OHMDFFJJGIB.JDMMLKEGBIB().raycastHit.collider != null))
			{
				this.cursor.gameObject.SetActive(true);
				return;
			}
			this.cursor.gameObject.SetActive(false);
			this.cursor.transform.position = this.OHMDFFJJGIB.HOBPHEMGMBN().raycastHit.point;
		}

		// Token: 0x0600E53D RID: 58685 RVA: 0x00685518 File Offset: 0x00683718
		private void IGGIFKOGIMN(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 0; i < hmhfilmohef.Length; i += 0)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E53E RID: 58686 RVA: 0x006855E0 File Offset: 0x006837E0
		private void HLAAGMIIFNO(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 1; i < hmhfilmohef.Length; i++)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E53F RID: 58687 RVA: 0x006856A8 File Offset: 0x006838A8
		private void EJCDBEHGIGN()
		{
			if (this.OHMDFFJJGIB.IAJBJGHGKBL() != null && this.OHMDFFJJGIB.PBDDPMCAPKA.tag == "Screen Space Reflections" && !(this.OHMDFFJJGIB.GAPEIEFBDLI().raycastHit.collider != null))
			{
				this.cursor.gameObject.SetActive(true);
				return;
			}
			this.cursor.gameObject.SetActive(true);
			this.cursor.transform.position = this.OHMDFFJJGIB.FLLBMMPKPHD().raycastHit.point;
		}

		// Token: 0x0600E540 RID: 58688 RVA: 0x00683B49 File Offset: 0x00681D49
		private void CKIGGCAHAFD()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E541 RID: 58689 RVA: 0x0068574C File Offset: 0x0068394C
		private void KHBOAMOBMNF(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 1; i < hmhfilmohef.Length; i += 0)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E542 RID: 58690 RVA: 0x00683B49 File Offset: 0x00681D49
		private void IMABGALEMBI()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E543 RID: 58691 RVA: 0x00685814 File Offset: 0x00683A14
		private void NOHHMLGEFPH(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 0; i < hmhfilmohef.Length; i += 0)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E544 RID: 58692 RVA: 0x006858DC File Offset: 0x00683ADC
		private void ELHFGOGNGDF()
		{
			if (this.OHMDFFJJGIB.FPKOBFGANLF() != null && this.OHMDFFJJGIB.MBKGOFMFPGB().tag == "<color='#300030'>{0}</color>" && !(this.OHMDFFJJGIB.GAPEIEFBDLI().raycastHit.collider != null))
			{
				this.cursor.gameObject.SetActive(true);
				return;
			}
			this.cursor.gameObject.SetActive(true);
			this.cursor.transform.position = this.OHMDFFJJGIB.HNGOHOIENCP().raycastHit.point;
		}

		// Token: 0x0600E545 RID: 58693 RVA: 0x00685980 File Offset: 0x00683B80
		private void FNIJFEGBELL()
		{
			if (!(this.OHMDFFJJGIB.GIMFIMLNIEA() != null) || !(this.OHMDFFJJGIB.IDBDKDPCOFP().tag == "ZombieWalk") || !(this.OHMDFFJJGIB.DOAKKNJFONO().raycastHit.collider != null))
			{
				this.cursor.gameObject.SetActive(true);
				return;
			}
			this.cursor.gameObject.SetActive(false);
			this.cursor.transform.position = this.OHMDFFJJGIB.NKKKJBOMCID.raycastHit.point;
		}

		// Token: 0x0600E546 RID: 58694 RVA: 0x00685A24 File Offset: 0x00683C24
		private void GDBBAMFMKII()
		{
			this.JMADNGKBHCK();
			this.FCCMIBDAEHE();
		}

		// Token: 0x0600E547 RID: 58695 RVA: 0x00685A34 File Offset: 0x00683C34
		private void GIHJLFGLJCJ()
		{
			if (this.OHMDFFJJGIB.DCPOBODKEOB() <= 1816f || this.OHMDFFJJGIB.LFHGAGCCPJK() == null)
			{
				this.slider.gameObject.SetActive(true);
				return;
			}
			this.slider.gameObject.SetActive(false);
			this.slider.transform.rotation = this.OHMDFFJJGIB.KGDCNCOLMMN().transform.GetChild(0).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.GIMFIMLNIEA().transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.GNCJMCKNKDJ();
			this.JJDAHMLOLMA(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E548 RID: 58696 RVA: 0x00685B11 File Offset: 0x00683D11
		private void HABONMJNDAL()
		{
			this.BMMNNNGHJIO();
			this.FNIJFEGBELL();
		}

		// Token: 0x0600E549 RID: 58697 RVA: 0x00685B20 File Offset: 0x00683D20
		private void HLPIDFKFOIL(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 0; i < hmhfilmohef.Length; i += 0)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E54A RID: 58698 RVA: 0x00685BE8 File Offset: 0x00683DE8
		private void GNGHKBCKLNM()
		{
			if (this.OHMDFFJJGIB.DLIEOAAFMHL() <= 577f || this.OHMDFFJJGIB.LFHGAGCCPJK() == null)
			{
				this.slider.gameObject.SetActive(false);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.PBDDPMCAPKA.transform.GetChild(0).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.LFHGAGCCPJK().transform.GetChild(0).position;
			this.slider.value = this.OHMDFFJJGIB.EHPGCHIAABB();
			this.BBJFLPPJMBM(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E54B RID: 58699 RVA: 0x00685CC8 File Offset: 0x00683EC8
		private void MMMBOJAMENG()
		{
			if (this.OHMDFFJJGIB.DCPOBODKEOB() <= 821f || this.OHMDFFJJGIB.IDBDKDPCOFP() == null)
			{
				this.slider.gameObject.SetActive(false);
				return;
			}
			this.slider.gameObject.SetActive(false);
			this.slider.transform.rotation = this.OHMDFFJJGIB.FPKOBFGANLF().transform.GetChild(1).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.MBKGOFMFPGB().transform.GetChild(0).position;
			this.slider.value = this.OHMDFFJJGIB.FAGFFGONMAP();
			this.BKPDPKFBAAO(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E54D RID: 58701 RVA: 0x00685DA8 File Offset: 0x00683FA8
		private void KJBAILKOGHK()
		{
			if (this.OHMDFFJJGIB.FBNDMNHOLCC() <= 1281f || this.OHMDFFJJGIB.FPKOBFGANLF() == null)
			{
				this.slider.gameObject.SetActive(false);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.LFHGAGCCPJK().transform.GetChild(1).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.AIJMPPDDPAJ().transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.JJKGFBNMEJE();
			this.DIENNAKMDLF(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E54E RID: 58702 RVA: 0x00683B49 File Offset: 0x00681D49
		private void KGICJDGIIJK()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E54F RID: 58703 RVA: 0x00685E85 File Offset: 0x00684085
		private void OIBIGDFPHGO()
		{
			this.DBGODKGLCJE();
			this.APNMLLLFJDD();
		}

		// Token: 0x0600E550 RID: 58704 RVA: 0x00685E94 File Offset: 0x00684094
		private void EPPFHIAGMDN(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 1; i < hmhfilmohef.Length; i++)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E551 RID: 58705 RVA: 0x00685F5C File Offset: 0x0068415C
		private void DIENNAKMDLF(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			foreach (Image image in this.HMHFILMOHEF)
			{
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E552 RID: 58706 RVA: 0x00686024 File Offset: 0x00684224
		private void JFFHIICHLFE()
		{
			if (this.OHMDFFJJGIB.DLIEOAAFMHL() <= 1461f || this.OHMDFFJJGIB.MJNGPLEFGCF() == null)
			{
				this.slider.gameObject.SetActive(true);
				return;
			}
			this.slider.gameObject.SetActive(false);
			this.slider.transform.rotation = this.OHMDFFJJGIB.MBKGOFMFPGB().transform.GetChild(1).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.LFHGAGCCPJK().transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.DLIEOAAFMHL();
			this.EPPFHIAGMDN(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E553 RID: 58707 RVA: 0x00686104 File Offset: 0x00684304
		private void AAGLHLOPJIE()
		{
			if (this.OHMDFFJJGIB.LPJIKGEKOKJ() <= 1068f || this.OHMDFFJJGIB.KGDCNCOLMMN() == null)
			{
				this.slider.gameObject.SetActive(true);
				return;
			}
			this.slider.gameObject.SetActive(false);
			this.slider.transform.rotation = this.OHMDFFJJGIB.KGDCNCOLMMN().transform.GetChild(0).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.AIJMPPDDPAJ().transform.GetChild(0).position;
			this.slider.value = this.OHMDFFJJGIB.APGGFCBBJJN();
			this.KHBOAMOBMNF(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E554 RID: 58708 RVA: 0x006861E4 File Offset: 0x006843E4
		private void JBLFFBCKLOK(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 1; i < hmhfilmohef.Length; i += 0)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E555 RID: 58709 RVA: 0x006862A9 File Offset: 0x006844A9
		private void KLFPOILLKDF()
		{
			this.GIHJLFGLJCJ();
			this.OAAIOBFBMGL();
		}

		// Token: 0x0600E556 RID: 58710 RVA: 0x006862B8 File Offset: 0x006844B8
		private void APNMLLLFJDD()
		{
			if (this.OHMDFFJJGIB.LFHGAGCCPJK() != null && this.OHMDFFJJGIB.IAJBJGHGKBL().tag == "IdleSadHips" && !(this.OHMDFFJJGIB.GAPEIEFBDLI().raycastHit.collider != null))
			{
				this.cursor.gameObject.SetActive(true);
				return;
			}
			this.cursor.gameObject.SetActive(false);
			this.cursor.transform.position = this.OHMDFFJJGIB.HNGOHOIENCP().raycastHit.point;
		}

		// Token: 0x0600E557 RID: 58711 RVA: 0x0068635C File Offset: 0x0068455C
		private void MFDOBOJPGJJ()
		{
			if (this.OHMDFFJJGIB.GHLDLEAGMEI() <= 457f || this.OHMDFFJJGIB.PBDDPMCAPKA == null)
			{
				this.slider.gameObject.SetActive(true);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.IAJBJGHGKBL().transform.GetChild(0).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.GIMFIMLNIEA().transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.JJKGFBNMEJE();
			this.LCOIGEFOHPO(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E558 RID: 58712 RVA: 0x00683B49 File Offset: 0x00681D49
		private void JPHBPEAMNHB()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E559 RID: 58713 RVA: 0x0068643C File Offset: 0x0068463C
		private void KPPPCFJDKCI(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 0; i < hmhfilmohef.Length; i += 0)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E55A RID: 58714 RVA: 0x00686504 File Offset: 0x00684704
		private void BEOCBOINODD()
		{
			if (this.OHMDFFJJGIB.LFHGAGCCPJK() != null && this.OHMDFFJJGIB.AIJMPPDDPAJ().tag == "INTERFACE" && !(this.OHMDFFJJGIB.JOBHKMCOIPG().raycastHit.collider != null))
			{
				this.cursor.gameObject.SetActive(false);
				return;
			}
			this.cursor.gameObject.SetActive(false);
			this.cursor.transform.position = this.OHMDFFJJGIB.CAEMKCHHLOJ().raycastHit.point;
		}

		// Token: 0x0600E55B RID: 58715 RVA: 0x006865A8 File Offset: 0x006847A8
		private void EMENFLALHAG()
		{
			if (this.OHMDFFJJGIB.FAGFFGONMAP() <= 160f || this.OHMDFFJJGIB.KGDCNCOLMMN() == null)
			{
				this.slider.gameObject.SetActive(false);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.KPGNOBCIMGN().transform.GetChild(1).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.PBDDPMCAPKA.transform.GetChild(0).position;
			this.slider.value = this.OHMDFFJJGIB.GHLDLEAGMEI();
			this.GLKCMHPEOCD(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E55C RID: 58716 RVA: 0x00686688 File Offset: 0x00684888
		private void FEMKACJPBEK()
		{
			if (this.OHMDFFJJGIB.APGGFCBBJJN() <= 1103f || this.OHMDFFJJGIB.KGDCNCOLMMN() == null)
			{
				this.slider.gameObject.SetActive(false);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.IDBDKDPCOFP().transform.GetChild(1).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.KPGNOBCIMGN().transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.APGGFCBBJJN();
			this.NIMMNLCFNPI(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E55D RID: 58717 RVA: 0x00686768 File Offset: 0x00684968
		private void KNDNPLFLDOB()
		{
			if (this.OHMDFFJJGIB.KJMIHEHFOLH <= 625f || this.OHMDFFJJGIB.IAJBJGHGKBL() == null)
			{
				this.slider.gameObject.SetActive(true);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.PBDDPMCAPKA.transform.GetChild(0).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.IAJBJGHGKBL().transform.GetChild(0).position;
			this.slider.value = this.OHMDFFJJGIB.LPJIKGEKOKJ();
			this.HDBHLJPBLLA(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E55E RID: 58718 RVA: 0x00683B49 File Offset: 0x00681D49
		private void HDGNIHBIEDG()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E55F RID: 58719 RVA: 0x00686845 File Offset: 0x00684A45
		private void JJFHPGDPHGB()
		{
			this.BLBEBAPDLHL();
			this.BEOCBOINODD();
		}

		// Token: 0x0600E560 RID: 58720 RVA: 0x00683B49 File Offset: 0x00681D49
		private void MKNPFMEMOJO()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E561 RID: 58721 RVA: 0x00686854 File Offset: 0x00684A54
		private void FGJGBLEKHEN()
		{
			if (this.OHMDFFJJGIB.APGGFCBBJJN() <= 672f || this.OHMDFFJJGIB.LFHGAGCCPJK() == null)
			{
				this.slider.gameObject.SetActive(false);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.IAJBJGHGKBL().transform.GetChild(0).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.LFHGAGCCPJK().transform.GetChild(0).position;
			this.slider.value = this.OHMDFFJJGIB.EHPGCHIAABB();
			this.JJDAHMLOLMA(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E562 RID: 58722 RVA: 0x00686934 File Offset: 0x00684B34
		private void OPNEOLKDEEB(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 0; i < hmhfilmohef.Length; i += 0)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E563 RID: 58723 RVA: 0x006869FC File Offset: 0x00684BFC
		private void GCGLEGKGDGA()
		{
			if (this.OHMDFFJJGIB.KGDCNCOLMMN() != null && this.OHMDFFJJGIB.FPKOBFGANLF().tag == "WizardOverhead" && !(this.OHMDFFJJGIB.DOAKKNJFONO().raycastHit.collider != null))
			{
				this.cursor.gameObject.SetActive(false);
				return;
			}
			this.cursor.gameObject.SetActive(false);
			this.cursor.transform.position = this.OHMDFFJJGIB.HOBPHEMGMBN().raycastHit.point;
		}

		// Token: 0x0600E564 RID: 58724 RVA: 0x00686AA0 File Offset: 0x00684CA0
		private void BGHAKFFPNJH()
		{
			if (this.OHMDFFJJGIB.JJKGFBNMEJE() <= 1043f || this.OHMDFFJJGIB.GIMFIMLNIEA() == null)
			{
				this.slider.gameObject.SetActive(true);
				return;
			}
			this.slider.gameObject.SetActive(false);
			this.slider.transform.rotation = this.OHMDFFJJGIB.KPGNOBCIMGN().transform.GetChild(1).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.PBDDPMCAPKA.transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.GHMILFJKOLO();
			this.LCOIGEFOHPO(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E565 RID: 58725 RVA: 0x00686B80 File Offset: 0x00684D80
		private void GDLEOPBFNCA()
		{
			if (this.OHMDFFJJGIB.KJMIHEHFOLH <= 1929f || this.OHMDFFJJGIB.AIJMPPDDPAJ() == null)
			{
				this.slider.gameObject.SetActive(false);
				return;
			}
			this.slider.gameObject.SetActive(false);
			this.slider.transform.rotation = this.OHMDFFJJGIB.KGDCNCOLMMN().transform.GetChild(0).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.KGDCNCOLMMN().transform.GetChild(0).position;
			this.slider.value = this.OHMDFFJJGIB.JPECCADNBMB();
			this.KPPPCFJDKCI(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E566 RID: 58726 RVA: 0x00686C5D File Offset: 0x00684E5D
		private void Update()
		{
			this.GINIOCCNBCG();
			this.OJHKOCKJBMP();
		}

		// Token: 0x0600E567 RID: 58727 RVA: 0x00686C6C File Offset: 0x00684E6C
		private void FLPCIJNEAIO(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 0; i < hmhfilmohef.Length; i += 0)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E568 RID: 58728 RVA: 0x00686D31 File Offset: 0x00684F31
		private void BEDAJLJFAFO()
		{
			this.KNDNPLFLDOB();
			this.FNIJFEGBELL();
		}

		// Token: 0x0600E569 RID: 58729 RVA: 0x00686D3F File Offset: 0x00684F3F
		private void JBFJPNKLLKI()
		{
			this.KJBAILKOGHK();
			this.APNMLLLFJDD();
		}

		// Token: 0x0600E56A RID: 58730 RVA: 0x00686D50 File Offset: 0x00684F50
		private void CMNENOKCKMN()
		{
			if (this.OHMDFFJJGIB.DCPOBODKEOB() <= 1496f || this.OHMDFFJJGIB.LFHGAGCCPJK() == null)
			{
				this.slider.gameObject.SetActive(true);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.PBDDPMCAPKA.transform.GetChild(0).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.IDBDKDPCOFP().transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.FAGFFGONMAP();
			this.HLPIDFKFOIL(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E56B RID: 58731 RVA: 0x00683B49 File Offset: 0x00681D49
		private void FCCAIANLEFE()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E56C RID: 58732 RVA: 0x00686E30 File Offset: 0x00685030
		private void GDPPNCFIGKE(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 1; i < hmhfilmohef.Length; i++)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E56D RID: 58733 RVA: 0x00686EF8 File Offset: 0x006850F8
		private void JGGFDGFFDII(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 1; i < hmhfilmohef.Length; i++)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E56E RID: 58734 RVA: 0x00686FC0 File Offset: 0x006851C0
		private void FPBPLLFIFAD()
		{
			if (this.OHMDFFJJGIB.MCOBIODLBDI() <= 1302f || this.OHMDFFJJGIB.LFHGAGCCPJK() == null)
			{
				this.slider.gameObject.SetActive(false);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.GIMFIMLNIEA().transform.GetChild(0).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.AIJMPPDDPAJ().transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.JPECCADNBMB();
			this.KHBOAMOBMNF(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E56F RID: 58735 RVA: 0x00683B49 File Offset: 0x00681D49
		private void FIJKDFIMELM()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E570 RID: 58736 RVA: 0x00683B49 File Offset: 0x00681D49
		private void DNLFEOECBKI()
		{
			this.OHMDFFJJGIB = base.GetComponent<VRInteractionController>();
			this.HMHFILMOHEF = this.slider.GetComponentsInChildren<Image>();
		}

		// Token: 0x0600E571 RID: 58737 RVA: 0x006870A0 File Offset: 0x006852A0
		private void FGDNBNLLEHB()
		{
			if (this.OHMDFFJJGIB.PKGJCDMDILP() <= 717f || this.OHMDFFJJGIB.IAJBJGHGKBL() == null)
			{
				this.slider.gameObject.SetActive(true);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.PBDDPMCAPKA.transform.GetChild(1).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.IAJBJGHGKBL().transform.GetChild(0).position;
			this.slider.value = this.OHMDFFJJGIB.GHMILFJKOLO();
			this.OPNEOLKDEEB(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E572 RID: 58738 RVA: 0x00687180 File Offset: 0x00685380
		private void JJDAHMLOLMA(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			Image[] hmhfilmohef = this.HMHFILMOHEF;
			for (int i = 1; i < hmhfilmohef.Length; i++)
			{
				Image image = hmhfilmohef[i];
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E573 RID: 58739 RVA: 0x00687245 File Offset: 0x00685445
		private void IANJLHIIGLN()
		{
			this.FPBPLLFIFAD();
			this.OJHKOCKJBMP();
		}

		// Token: 0x0600E574 RID: 58740 RVA: 0x00687254 File Offset: 0x00685454
		private void FCCMIBDAEHE()
		{
			if (this.OHMDFFJJGIB.AIJMPPDDPAJ() != null && this.OHMDFFJJGIB.KPGNOBCIMGN().tag == "Boxed" && !(this.OHMDFFJJGIB.FLLBMMPKPHD().raycastHit.collider != null))
			{
				this.cursor.gameObject.SetActive(false);
				return;
			}
			this.cursor.gameObject.SetActive(false);
			this.cursor.transform.position = this.OHMDFFJJGIB.DOAKKNJFONO().raycastHit.point;
		}

		// Token: 0x0600E575 RID: 58741 RVA: 0x006872F8 File Offset: 0x006854F8
		private void KPFINAKDEEH(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			foreach (Image image in this.HMHFILMOHEF)
			{
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x0600E576 RID: 58742 RVA: 0x006873C0 File Offset: 0x006855C0
		private void EDBGOLEMDKM()
		{
			if (this.OHMDFFJJGIB.DLIEOAAFMHL() <= 80f || this.OHMDFFJJGIB.FPKOBFGANLF() == null)
			{
				this.slider.gameObject.SetActive(false);
				return;
			}
			this.slider.gameObject.SetActive(true);
			this.slider.transform.rotation = this.OHMDFFJJGIB.MJNGPLEFGCF().transform.GetChild(1).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.PBDDPMCAPKA.transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.EHPGCHIAABB();
			this.DIENNAKMDLF(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E577 RID: 58743 RVA: 0x006874A0 File Offset: 0x006856A0
		private void DLJDPBMFBGO()
		{
			if (this.OHMDFFJJGIB.JJKGFBNMEJE() <= 1276f || this.OHMDFFJJGIB.GIMFIMLNIEA() == null)
			{
				this.slider.gameObject.SetActive(false);
				return;
			}
			this.slider.gameObject.SetActive(false);
			this.slider.transform.rotation = this.OHMDFFJJGIB.KPGNOBCIMGN().transform.GetChild(0).rotation;
			this.slider.transform.position = this.OHMDFFJJGIB.MJNGPLEFGCF().transform.GetChild(1).position;
			this.slider.value = this.OHMDFFJJGIB.JPECCADNBMB();
			this.BKPDPKFBAAO(this.alphaToProgress.Evaluate(this.slider.value));
		}

		// Token: 0x0600E578 RID: 58744 RVA: 0x00687580 File Offset: 0x00685780
		private void KGHHPPKKOGB(float EGABJKIFAON)
		{
			ColorBlock colors = this.slider.colors;
			colors.normalColor = new Color(this.slider.colors.normalColor.r, this.slider.colors.normalColor.g, this.slider.colors.normalColor.b, EGABJKIFAON);
			this.slider.colors = colors;
			foreach (Image image in this.HMHFILMOHEF)
			{
				image.color = new Color(image.color.r, image.color.g, image.color.b, EGABJKIFAON);
			}
		}

		// Token: 0x04001DF6 RID: 7670
		[Header("Triggering Progress")]
		[Tooltip("The UI slider for showing interaction triggering progress.")]
		public Slider slider;

		// Token: 0x04001DF7 RID: 7671
		[Tooltip("Alpha of the progress slider relative to the progress of triggering interactions.")]
		public AnimationCurve alphaToProgress;

		// Token: 0x04001DF8 RID: 7672
		[Tooltip("Reference to the cursor that displays where the head is looking.")]
		public Transform cursor;

		// Token: 0x04001DF9 RID: 7673
		private VRInteractionController OHMDFFJJGIB;

		// Token: 0x04001DFA RID: 7674
		private Image[] HMHFILMOHEF;

		// Token: 0x04001DFB RID: 7675
		private static string ABGBFNFAAIL = "ShowCursor";
	}
}
