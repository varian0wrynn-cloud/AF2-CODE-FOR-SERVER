using System;
using System.Collections;
using UnityEngine;

// Token: 0x020001C2 RID: 450
public class LampScript : MonoBehaviour
{
	// Token: 0x060064A7 RID: 25767 RVA: 0x002F32A4 File Offset: 0x002F14A4
	private void EACIAJMNNII()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.FEAPJOCHDIE();
				return;
			}
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064A8 RID: 25768 RVA: 0x002F3318 File Offset: 0x002F1518
	private void ONOJDNLDPOO()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.OBIGNMAOBPP();
				return;
			}
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064A9 RID: 25769 RVA: 0x002F338C File Offset: 0x002F158C
	private void OBIGNMAOBPP()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064AA RID: 25770 RVA: 0x002F33E0 File Offset: 0x002F15E0
	private void DOHJPDNKALP()
	{
		if (TimeController.EPCKOOOGNGK() == null)
		{
			return;
		}
		this.IIHOBMBFBDA();
		base.StartCoroutine(this.NCKBMFECOPG());
	}

	// Token: 0x060064AB RID: 25771 RVA: 0x002F3404 File Offset: 0x002F1604
	private void DGBGNLPMACJ()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.JACAOJCJAMG();
				return;
			}
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064AC RID: 25772 RVA: 0x002F3478 File Offset: 0x002F1678
	private IEnumerator DLAPBILAEKN()
	{
		LampScript.PDLGCOHNKCN pdlgcohnkcn = new LampScript.PDLGCOHNKCN(1);
		pdlgcohnkcn.AENJLLPLILM = this;
		return pdlgcohnkcn;
	}

	// Token: 0x060064AD RID: 25773 RVA: 0x002F3487 File Offset: 0x002F1687
	private IEnumerator CNCHJJMAMDO()
	{
		for (;;)
		{
			float time = TimeController.IKGFHGKKCPG.time;
			if (this.timeOn < this.timeOff)
			{
				if (time >= (float)this.timeOn && time < (float)this.timeOff)
				{
					this.HFGJCMLBPBC();
				}
			}
			else
			{
				bool flag = false;
				if (time < (float)this.timeOff)
				{
					flag = true;
				}
				if (time >= (float)this.timeOn)
				{
					flag = true;
				}
				if (flag)
				{
					this.HFGJCMLBPBC();
				}
				else
				{
					this.OAFOAJHNFOA();
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060064AE RID: 25774 RVA: 0x002F3496 File Offset: 0x002F1696
	private void GHCMIKGJPJD()
	{
		if (TimeController.EKEBHIJMEML() == null)
		{
			return;
		}
		this.AAONHFJGGCH();
		base.StartCoroutine(this.EMNKKFFBFJJ());
	}

	// Token: 0x060064AF RID: 25775 RVA: 0x002F34BC File Offset: 0x002F16BC
	private void DGCPMPPKOCC()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.LPLPPHKHPOE();
				return;
			}
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064B0 RID: 25776 RVA: 0x002F3530 File Offset: 0x002F1730
	private void NOKJMMDMJNO()
	{
		if (TimeController.KOJCECHBHLO() == null)
		{
			return;
		}
		this.IJCGKHLMGMD();
		base.StartCoroutine(this.KKHJALHHDBA());
	}

	// Token: 0x060064B1 RID: 25777 RVA: 0x002F3554 File Offset: 0x002F1754
	private void PIGBJPJOHON()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064B2 RID: 25778 RVA: 0x002F35A8 File Offset: 0x002F17A8
	private void OEPMHAIAEOG()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.IIHOBMBFBDA();
				return;
			}
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064B3 RID: 25779 RVA: 0x002F361C File Offset: 0x002F181C
	private void IBJPNHOIPEM()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064B4 RID: 25780 RVA: 0x002F3670 File Offset: 0x002F1870
	private void EFBLLHAFAOA()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.FEEHBNAJBDI();
				return;
			}
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064B5 RID: 25781 RVA: 0x002F3487 File Offset: 0x002F1687
	private IEnumerator NLJGLEMELEI()
	{
		for (;;)
		{
			float time = TimeController.IKGFHGKKCPG.time;
			if (this.timeOn < this.timeOff)
			{
				if (time >= (float)this.timeOn && time < (float)this.timeOff)
				{
					this.HFGJCMLBPBC();
				}
			}
			else
			{
				bool flag = false;
				if (time < (float)this.timeOff)
				{
					flag = true;
				}
				if (time >= (float)this.timeOn)
				{
					flag = true;
				}
				if (flag)
				{
					this.HFGJCMLBPBC();
				}
				else
				{
					this.OAFOAJHNFOA();
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060064B6 RID: 25782 RVA: 0x002F36E4 File Offset: 0x002F18E4
	private void LHJCHPFKGDB()
	{
		if (TimeController.EPCKOOOGNGK() == null)
		{
			return;
		}
		this.PIGBJPJOHON();
		base.StartCoroutine(this.DICCJIOBMLH());
	}

	// Token: 0x060064B7 RID: 25783 RVA: 0x002F3708 File Offset: 0x002F1908
	private void IIHOBMBFBDA()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064B8 RID: 25784 RVA: 0x002F375C File Offset: 0x002F195C
	private void POGBNJFHAPC()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064B9 RID: 25785 RVA: 0x002F37B0 File Offset: 0x002F19B0
	private void DCFEOMAEOKH()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064BA RID: 25786 RVA: 0x002F3478 File Offset: 0x002F1678
	private IEnumerator MMDDPHPFBKL()
	{
		LampScript.PDLGCOHNKCN pdlgcohnkcn = new LampScript.PDLGCOHNKCN(1);
		pdlgcohnkcn.AENJLLPLILM = this;
		return pdlgcohnkcn;
	}

	// Token: 0x060064BB RID: 25787 RVA: 0x002F3804 File Offset: 0x002F1A04
	private void EIGNGGEMIMA()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.JACAOJCJAMG();
				return;
			}
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064BC RID: 25788 RVA: 0x002F3878 File Offset: 0x002F1A78
	private void ONDKFGPPLNN()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.LPLPPHKHPOE();
				return;
			}
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064BD RID: 25789 RVA: 0x002F3487 File Offset: 0x002F1687
	private IEnumerator OHDGGAFAFFN()
	{
		for (;;)
		{
			float time = TimeController.IKGFHGKKCPG.time;
			if (this.timeOn < this.timeOff)
			{
				if (time >= (float)this.timeOn && time < (float)this.timeOff)
				{
					this.HFGJCMLBPBC();
				}
			}
			else
			{
				bool flag = false;
				if (time < (float)this.timeOff)
				{
					flag = true;
				}
				if (time >= (float)this.timeOn)
				{
					flag = true;
				}
				if (flag)
				{
					this.HFGJCMLBPBC();
				}
				else
				{
					this.OAFOAJHNFOA();
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060064BE RID: 25790 RVA: 0x002F38EC File Offset: 0x002F1AEC
	private void OPNPODKLOJK()
	{
		if (TimeController.BOBNPEAEECC() == null)
		{
			return;
		}
		this.IJCGKHLMGMD();
		base.StartCoroutine(this.ICNINIPCPKF());
	}

	// Token: 0x060064BF RID: 25791 RVA: 0x002F390F File Offset: 0x002F1B0F
	private void AOCDDBNBADJ()
	{
		if (TimeController.IKGFHGKKCPG == null)
		{
			return;
		}
		this.OBIGNMAOBPP();
		base.StartCoroutine(this.DLAPBILAEKN());
	}

	// Token: 0x060064C0 RID: 25792 RVA: 0x002F3932 File Offset: 0x002F1B32
	private void JPHBPEAMNHB()
	{
		if (TimeController.BOBNPEAEECC() == null)
		{
			return;
		}
		this.IBJPNHOIPEM();
		base.StartCoroutine(this.EBFFPBEONLO());
	}

	// Token: 0x060064C1 RID: 25793 RVA: 0x002F3958 File Offset: 0x002F1B58
	private void MFIJIMKHFKF()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064C3 RID: 25795 RVA: 0x002F36E4 File Offset: 0x002F18E4
	private void CHDJGEOFHEE()
	{
		if (TimeController.EPCKOOOGNGK() == null)
		{
			return;
		}
		this.PIGBJPJOHON();
		base.StartCoroutine(this.DICCJIOBMLH());
	}

	// Token: 0x060064C4 RID: 25796 RVA: 0x002F39D4 File Offset: 0x002F1BD4
	private void FAPJCOIHHFC()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064C5 RID: 25797 RVA: 0x002F3A28 File Offset: 0x002F1C28
	private void MKNPFMEMOJO()
	{
		if (TimeController.KOJCECHBHLO() == null)
		{
			return;
		}
		this.OAFOAJHNFOA();
		base.StartCoroutine(this.MMDDPHPFBKL());
	}

	// Token: 0x060064C6 RID: 25798 RVA: 0x002F3A4C File Offset: 0x002F1C4C
	private void AAONHFJGGCH()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064C7 RID: 25799 RVA: 0x002F3AA0 File Offset: 0x002F1CA0
	private void HNNBNEBAJOM()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.PBMGDEGFGME();
				return;
			}
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064C8 RID: 25800 RVA: 0x002F3487 File Offset: 0x002F1687
	private IEnumerator KKHJALHHDBA()
	{
		for (;;)
		{
			float time = TimeController.IKGFHGKKCPG.time;
			if (this.timeOn < this.timeOff)
			{
				if (time >= (float)this.timeOn && time < (float)this.timeOff)
				{
					this.HFGJCMLBPBC();
				}
			}
			else
			{
				bool flag = false;
				if (time < (float)this.timeOff)
				{
					flag = true;
				}
				if (time >= (float)this.timeOn)
				{
					flag = true;
				}
				if (flag)
				{
					this.HFGJCMLBPBC();
				}
				else
				{
					this.OAFOAJHNFOA();
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060064C9 RID: 25801 RVA: 0x002F3487 File Offset: 0x002F1687
	private IEnumerator BKJJPNMEABN()
	{
		for (;;)
		{
			float time = TimeController.IKGFHGKKCPG.time;
			if (this.timeOn < this.timeOff)
			{
				if (time >= (float)this.timeOn && time < (float)this.timeOff)
				{
					this.HFGJCMLBPBC();
				}
			}
			else
			{
				bool flag = false;
				if (time < (float)this.timeOff)
				{
					flag = true;
				}
				if (time >= (float)this.timeOn)
				{
					flag = true;
				}
				if (flag)
				{
					this.HFGJCMLBPBC();
				}
				else
				{
					this.OAFOAJHNFOA();
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060064CA RID: 25802 RVA: 0x002F3B14 File Offset: 0x002F1D14
	private void OHACOEMELNF()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.LPLPPHKHPOE();
				return;
			}
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064CB RID: 25803 RVA: 0x002F3B88 File Offset: 0x002F1D88
	private void Start()
	{
		if (TimeController.IKGFHGKKCPG == null)
		{
			return;
		}
		this.OAFOAJHNFOA();
		base.StartCoroutine(this.MDGIMEEMLCA());
	}

	// Token: 0x060064CC RID: 25804 RVA: 0x002F3487 File Offset: 0x002F1687
	private IEnumerator MGCBOGCEAHD()
	{
		for (;;)
		{
			float time = TimeController.IKGFHGKKCPG.time;
			if (this.timeOn < this.timeOff)
			{
				if (time >= (float)this.timeOn && time < (float)this.timeOff)
				{
					this.HFGJCMLBPBC();
				}
			}
			else
			{
				bool flag = false;
				if (time < (float)this.timeOff)
				{
					flag = true;
				}
				if (time >= (float)this.timeOn)
				{
					flag = true;
				}
				if (flag)
				{
					this.HFGJCMLBPBC();
				}
				else
				{
					this.OAFOAJHNFOA();
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060064CD RID: 25805 RVA: 0x002F3BAC File Offset: 0x002F1DAC
	private void PHMGFKKOOCM()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.EJECAHMLENL();
				return;
			}
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064CE RID: 25806 RVA: 0x002F3C20 File Offset: 0x002F1E20
	private void AIFIEAGFIMM()
	{
		if (TimeController.EKEBHIJMEML() == null)
		{
			return;
		}
		this.FEEHBNAJBDI();
		base.StartCoroutine(this.FGMPFMPLJBG());
	}

	// Token: 0x060064CF RID: 25807 RVA: 0x002F3487 File Offset: 0x002F1687
	private IEnumerator EMNKKFFBFJJ()
	{
		for (;;)
		{
			float time = TimeController.IKGFHGKKCPG.time;
			if (this.timeOn < this.timeOff)
			{
				if (time >= (float)this.timeOn && time < (float)this.timeOff)
				{
					this.HFGJCMLBPBC();
				}
			}
			else
			{
				bool flag = false;
				if (time < (float)this.timeOff)
				{
					flag = true;
				}
				if (time >= (float)this.timeOn)
				{
					flag = true;
				}
				if (flag)
				{
					this.HFGJCMLBPBC();
				}
				else
				{
					this.OAFOAJHNFOA();
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060064D0 RID: 25808 RVA: 0x002F3C44 File Offset: 0x002F1E44
	private void IJBDKLHMKIF()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.POGBNJFHAPC();
				return;
			}
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064D1 RID: 25809 RVA: 0x002F3CB8 File Offset: 0x002F1EB8
	private void BJAANJBLCNN()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064D2 RID: 25810 RVA: 0x002F3D0C File Offset: 0x002F1F0C
	private void IMABGALEMBI()
	{
		if (TimeController.KOJCECHBHLO() == null)
		{
			return;
		}
		this.CCDDJPBFJLB();
		base.StartCoroutine(this.IKPGNEANLHJ());
	}

	// Token: 0x060064D3 RID: 25811 RVA: 0x002F3D2F File Offset: 0x002F1F2F
	private void CBLGFOFHNPJ()
	{
		if (TimeController.EKEBHIJMEML() == null)
		{
			return;
		}
		this.EJECAHMLENL();
		base.StartCoroutine(this.EBFFPBEONLO());
	}

	// Token: 0x060064D4 RID: 25812 RVA: 0x002F3D54 File Offset: 0x002F1F54
	private void BFHIOGGLCLO()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064D5 RID: 25813 RVA: 0x002F3DA8 File Offset: 0x002F1FA8
	private void NECHCCECOAL()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.AAONHFJGGCH();
				return;
			}
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064D6 RID: 25814 RVA: 0x002F3E1C File Offset: 0x002F201C
	private void HFGJCMLBPBC()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.OAFOAJHNFOA();
				return;
			}
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064D7 RID: 25815 RVA: 0x002F3E90 File Offset: 0x002F2090
	private void OFGMIEJKMGC()
	{
		if (TimeController.BOBNPEAEECC() == null)
		{
			return;
		}
		this.IJCGKHLMGMD();
		base.StartCoroutine(this.CPLAGODGKMF());
	}

	// Token: 0x060064D8 RID: 25816 RVA: 0x002F3478 File Offset: 0x002F1678
	private IEnumerator ICNINIPCPKF()
	{
		LampScript.PDLGCOHNKCN pdlgcohnkcn = new LampScript.PDLGCOHNKCN(1);
		pdlgcohnkcn.AENJLLPLILM = this;
		return pdlgcohnkcn;
	}

	// Token: 0x060064D9 RID: 25817 RVA: 0x002F3EB3 File Offset: 0x002F20B3
	private void CAJLCEPLKJG()
	{
		if (TimeController.KOJCECHBHLO() == null)
		{
			return;
		}
		this.FFHJKFMDBEP();
		base.StartCoroutine(this.NGCCPNNNKOF());
	}

	// Token: 0x060064DA RID: 25818 RVA: 0x002F3478 File Offset: 0x002F1678
	private IEnumerator CPLAGODGKMF()
	{
		LampScript.PDLGCOHNKCN pdlgcohnkcn = new LampScript.PDLGCOHNKCN(1);
		pdlgcohnkcn.AENJLLPLILM = this;
		return pdlgcohnkcn;
	}

	// Token: 0x060064DB RID: 25819 RVA: 0x002F3ED8 File Offset: 0x002F20D8
	private void KLLNFHFGELP()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.FEAPJOCHDIE();
				return;
			}
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064DC RID: 25820 RVA: 0x002F3F4C File Offset: 0x002F214C
	private void FGJCIEDDFGN()
	{
		if (TimeController.IKGFHGKKCPG == null)
		{
			return;
		}
		this.OAFOAJHNFOA();
		base.StartCoroutine(this.LJNKAFCPEFG());
	}

	// Token: 0x060064DD RID: 25821 RVA: 0x002F3487 File Offset: 0x002F1687
	private IEnumerator MEKLGLCJJNA()
	{
		for (;;)
		{
			float time = TimeController.IKGFHGKKCPG.time;
			if (this.timeOn < this.timeOff)
			{
				if (time >= (float)this.timeOn && time < (float)this.timeOff)
				{
					this.HFGJCMLBPBC();
				}
			}
			else
			{
				bool flag = false;
				if (time < (float)this.timeOff)
				{
					flag = true;
				}
				if (time >= (float)this.timeOn)
				{
					flag = true;
				}
				if (flag)
				{
					this.HFGJCMLBPBC();
				}
				else
				{
					this.OAFOAJHNFOA();
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060064DE RID: 25822 RVA: 0x002F3F6F File Offset: 0x002F216F
	private void ADLHNBEDHMJ()
	{
		if (TimeController.BOBNPEAEECC() == null)
		{
			return;
		}
		this.JACAOJCJAMG();
		base.StartCoroutine(this.MDGIMEEMLCA());
	}

	// Token: 0x060064DF RID: 25823 RVA: 0x002F3478 File Offset: 0x002F1678
	private IEnumerator MCJENKCMHME()
	{
		LampScript.PDLGCOHNKCN pdlgcohnkcn = new LampScript.PDLGCOHNKCN(1);
		pdlgcohnkcn.AENJLLPLILM = this;
		return pdlgcohnkcn;
	}

	// Token: 0x060064E0 RID: 25824 RVA: 0x002F3F94 File Offset: 0x002F2194
	private void LJAODINPFMG()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.CNFEGCDMEOF();
				return;
			}
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064E1 RID: 25825 RVA: 0x002F4008 File Offset: 0x002F2208
	private void LPLPPHKHPOE()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064E2 RID: 25826 RVA: 0x002F405C File Offset: 0x002F225C
	private void CIFEBMEPBCL()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.CNFEGCDMEOF();
				return;
			}
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064E3 RID: 25827 RVA: 0x002F40D0 File Offset: 0x002F22D0
	private void KLKIGAIJOMA()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.PBMGDEGFGME();
				return;
			}
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064E4 RID: 25828 RVA: 0x002F4144 File Offset: 0x002F2344
	private void FDKKIFGJFOG()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064E5 RID: 25829 RVA: 0x002F4198 File Offset: 0x002F2398
	private void EPJFMKAMNOG()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064E6 RID: 25830 RVA: 0x002F41EC File Offset: 0x002F23EC
	private void BMNJGPIPKLL()
	{
		if (TimeController.BOBNPEAEECC() == null)
		{
			return;
		}
		this.FAPJCOIHHFC();
		base.StartCoroutine(this.KKHJALHHDBA());
	}

	// Token: 0x060064E7 RID: 25831 RVA: 0x002F3487 File Offset: 0x002F1687
	private IEnumerator HPNKKKIEPPJ()
	{
		for (;;)
		{
			float time = TimeController.IKGFHGKKCPG.time;
			if (this.timeOn < this.timeOff)
			{
				if (time >= (float)this.timeOn && time < (float)this.timeOff)
				{
					this.HFGJCMLBPBC();
				}
			}
			else
			{
				bool flag = false;
				if (time < (float)this.timeOff)
				{
					flag = true;
				}
				if (time >= (float)this.timeOn)
				{
					flag = true;
				}
				if (flag)
				{
					this.HFGJCMLBPBC();
				}
				else
				{
					this.OAFOAJHNFOA();
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060064E8 RID: 25832 RVA: 0x002F4210 File Offset: 0x002F2410
	private void CNFEGCDMEOF()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064E9 RID: 25833 RVA: 0x002F4264 File Offset: 0x002F2464
	private void PBMGDEGFGME()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064EA RID: 25834 RVA: 0x002F3487 File Offset: 0x002F1687
	private IEnumerator NCKBMFECOPG()
	{
		for (;;)
		{
			float time = TimeController.IKGFHGKKCPG.time;
			if (this.timeOn < this.timeOff)
			{
				if (time >= (float)this.timeOn && time < (float)this.timeOff)
				{
					this.HFGJCMLBPBC();
				}
			}
			else
			{
				bool flag = false;
				if (time < (float)this.timeOff)
				{
					flag = true;
				}
				if (time >= (float)this.timeOn)
				{
					flag = true;
				}
				if (flag)
				{
					this.HFGJCMLBPBC();
				}
				else
				{
					this.OAFOAJHNFOA();
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060064EB RID: 25835 RVA: 0x002F42B8 File Offset: 0x002F24B8
	private void LONGHHKJIEB()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.FDKKIFGJFOG();
				return;
			}
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064EC RID: 25836 RVA: 0x002F3487 File Offset: 0x002F1687
	private IEnumerator ANIAAELGLLA()
	{
		for (;;)
		{
			float time = TimeController.IKGFHGKKCPG.time;
			if (this.timeOn < this.timeOff)
			{
				if (time >= (float)this.timeOn && time < (float)this.timeOff)
				{
					this.HFGJCMLBPBC();
				}
			}
			else
			{
				bool flag = false;
				if (time < (float)this.timeOff)
				{
					flag = true;
				}
				if (time >= (float)this.timeOn)
				{
					flag = true;
				}
				if (flag)
				{
					this.HFGJCMLBPBC();
				}
				else
				{
					this.OAFOAJHNFOA();
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060064ED RID: 25837 RVA: 0x002F432C File Offset: 0x002F252C
	private void CCDDJPBFJLB()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064EE RID: 25838 RVA: 0x002F4380 File Offset: 0x002F2580
	private void GIJEFFFNKBF()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064EF RID: 25839 RVA: 0x002F3478 File Offset: 0x002F1678
	private IEnumerator BAHMNILDIKN()
	{
		LampScript.PDLGCOHNKCN pdlgcohnkcn = new LampScript.PDLGCOHNKCN(1);
		pdlgcohnkcn.AENJLLPLILM = this;
		return pdlgcohnkcn;
	}

	// Token: 0x060064F0 RID: 25840 RVA: 0x002F43D4 File Offset: 0x002F25D4
	private void HBIONOKPDDN()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.FEAPJOCHDIE();
				return;
			}
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064F1 RID: 25841 RVA: 0x002F4448 File Offset: 0x002F2648
	private void JACAOJCJAMG()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064F2 RID: 25842 RVA: 0x002F449C File Offset: 0x002F269C
	private void GOCDFIFJDHI()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064F3 RID: 25843 RVA: 0x002F3487 File Offset: 0x002F1687
	private IEnumerator EBFFPBEONLO()
	{
		for (;;)
		{
			float time = TimeController.IKGFHGKKCPG.time;
			if (this.timeOn < this.timeOff)
			{
				if (time >= (float)this.timeOn && time < (float)this.timeOff)
				{
					this.HFGJCMLBPBC();
				}
			}
			else
			{
				bool flag = false;
				if (time < (float)this.timeOff)
				{
					flag = true;
				}
				if (time >= (float)this.timeOn)
				{
					flag = true;
				}
				if (flag)
				{
					this.HFGJCMLBPBC();
				}
				else
				{
					this.OAFOAJHNFOA();
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060064F4 RID: 25844 RVA: 0x002F44F0 File Offset: 0x002F26F0
	private void FPJDFKBKIGH()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.FDKKIFGJFOG();
				return;
			}
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064F5 RID: 25845 RVA: 0x002F4564 File Offset: 0x002F2764
	private void FPLHODJCJDO()
	{
		if (TimeController.IKGFHGKKCPG == null)
		{
			return;
		}
		this.FDKKIFGJFOG();
		base.StartCoroutine(this.MMDDPHPFBKL());
	}

	// Token: 0x060064F6 RID: 25846 RVA: 0x002F4588 File Offset: 0x002F2788
	private void BFHIOOLIFNL()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064F7 RID: 25847 RVA: 0x002F3478 File Offset: 0x002F1678
	private IEnumerator APPPALHOLLI()
	{
		LampScript.PDLGCOHNKCN pdlgcohnkcn = new LampScript.PDLGCOHNKCN(1);
		pdlgcohnkcn.AENJLLPLILM = this;
		return pdlgcohnkcn;
	}

	// Token: 0x060064F8 RID: 25848 RVA: 0x002F45DC File Offset: 0x002F27DC
	private void HMKAEKOPIMC()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064F9 RID: 25849 RVA: 0x002F3487 File Offset: 0x002F1687
	private IEnumerator AFBKEKFJLKO()
	{
		for (;;)
		{
			float time = TimeController.IKGFHGKKCPG.time;
			if (this.timeOn < this.timeOff)
			{
				if (time >= (float)this.timeOn && time < (float)this.timeOff)
				{
					this.HFGJCMLBPBC();
				}
			}
			else
			{
				bool flag = false;
				if (time < (float)this.timeOff)
				{
					flag = true;
				}
				if (time >= (float)this.timeOn)
				{
					flag = true;
				}
				if (flag)
				{
					this.HFGJCMLBPBC();
				}
				else
				{
					this.OAFOAJHNFOA();
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060064FA RID: 25850 RVA: 0x002F3487 File Offset: 0x002F1687
	private IEnumerator MDGIMEEMLCA()
	{
		for (;;)
		{
			float time = TimeController.IKGFHGKKCPG.time;
			if (this.timeOn < this.timeOff)
			{
				if (time >= (float)this.timeOn && time < (float)this.timeOff)
				{
					this.HFGJCMLBPBC();
				}
			}
			else
			{
				bool flag = false;
				if (time < (float)this.timeOff)
				{
					flag = true;
				}
				if (time >= (float)this.timeOn)
				{
					flag = true;
				}
				if (flag)
				{
					this.HFGJCMLBPBC();
				}
				else
				{
					this.OAFOAJHNFOA();
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060064FB RID: 25851 RVA: 0x002F3487 File Offset: 0x002F1687
	private IEnumerator EPJKFNBGHFK()
	{
		for (;;)
		{
			float time = TimeController.IKGFHGKKCPG.time;
			if (this.timeOn < this.timeOff)
			{
				if (time >= (float)this.timeOn && time < (float)this.timeOff)
				{
					this.HFGJCMLBPBC();
				}
			}
			else
			{
				bool flag = false;
				if (time < (float)this.timeOff)
				{
					flag = true;
				}
				if (time >= (float)this.timeOn)
				{
					flag = true;
				}
				if (flag)
				{
					this.HFGJCMLBPBC();
				}
				else
				{
					this.OAFOAJHNFOA();
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x060064FC RID: 25852 RVA: 0x002F4630 File Offset: 0x002F2830
	private void FEEHBNAJBDI()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064FD RID: 25853 RVA: 0x002F4684 File Offset: 0x002F2884
	private void FMNMJLFEFAH()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x060064FE RID: 25854 RVA: 0x002F3478 File Offset: 0x002F1678
	private IEnumerator DICCJIOBMLH()
	{
		LampScript.PDLGCOHNKCN pdlgcohnkcn = new LampScript.PDLGCOHNKCN(1);
		pdlgcohnkcn.AENJLLPLILM = this;
		return pdlgcohnkcn;
	}

	// Token: 0x060064FF RID: 25855 RVA: 0x002F46D8 File Offset: 0x002F28D8
	private void EJECAHMLENL()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x06006500 RID: 25856 RVA: 0x002F472C File Offset: 0x002F292C
	private void ONIHHFLOJMN()
	{
		if (TimeController.IKGFHGKKCPG == null)
		{
			return;
		}
		this.FAPJCOIHHFC();
		base.StartCoroutine(this.MCJENKCMHME());
	}

	// Token: 0x06006501 RID: 25857 RVA: 0x002F474F File Offset: 0x002F294F
	private void EFCCCKGCOCB()
	{
		if (TimeController.EPCKOOOGNGK() == null)
		{
			return;
		}
		this.AAONHFJGGCH();
		base.StartCoroutine(this.BKJJPNMEABN());
	}

	// Token: 0x06006502 RID: 25858 RVA: 0x002F4774 File Offset: 0x002F2974
	private void HHGMPMBDJIH()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.BJAANJBLCNN();
				return;
			}
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x06006503 RID: 25859 RVA: 0x002F47E8 File Offset: 0x002F29E8
	private void IJCGKHLMGMD()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x06006504 RID: 25860 RVA: 0x002F483C File Offset: 0x002F2A3C
	private void OAFOAJHNFOA()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x06006505 RID: 25861 RVA: 0x002F3487 File Offset: 0x002F1687
	private IEnumerator NGCCPNNNKOF()
	{
		for (;;)
		{
			float time = TimeController.IKGFHGKKCPG.time;
			if (this.timeOn < this.timeOff)
			{
				if (time >= (float)this.timeOn && time < (float)this.timeOff)
				{
					this.HFGJCMLBPBC();
				}
			}
			else
			{
				bool flag = false;
				if (time < (float)this.timeOff)
				{
					flag = true;
				}
				if (time >= (float)this.timeOn)
				{
					flag = true;
				}
				if (flag)
				{
					this.HFGJCMLBPBC();
				}
				else
				{
					this.OAFOAJHNFOA();
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x06006506 RID: 25862 RVA: 0x002F3487 File Offset: 0x002F1687
	private IEnumerator IKPGNEANLHJ()
	{
		for (;;)
		{
			float time = TimeController.IKGFHGKKCPG.time;
			if (this.timeOn < this.timeOff)
			{
				if (time >= (float)this.timeOn && time < (float)this.timeOff)
				{
					this.HFGJCMLBPBC();
				}
			}
			else
			{
				bool flag = false;
				if (time < (float)this.timeOff)
				{
					flag = true;
				}
				if (time >= (float)this.timeOn)
				{
					flag = true;
				}
				if (flag)
				{
					this.HFGJCMLBPBC();
				}
				else
				{
					this.OAFOAJHNFOA();
				}
			}
			yield return new WaitForSeconds(1f);
		}
		yield break;
	}

	// Token: 0x06006507 RID: 25863 RVA: 0x002F4890 File Offset: 0x002F2A90
	private void GCHNDOOBJGP()
	{
		if (!this.IKKPFPJLPOL)
		{
			if (!this.isLightInBase && JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.HDELGEDDDCE == 0)
			{
				this.GIJEFFFNKBF();
				return;
			}
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x06006508 RID: 25864 RVA: 0x002F3478 File Offset: 0x002F1678
	private IEnumerator LJNKAFCPEFG()
	{
		LampScript.PDLGCOHNKCN pdlgcohnkcn = new LampScript.PDLGCOHNKCN(1);
		pdlgcohnkcn.AENJLLPLILM = this;
		return pdlgcohnkcn;
	}

	// Token: 0x06006509 RID: 25865 RVA: 0x002F4904 File Offset: 0x002F2B04
	private void FEAPJOCHDIE()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = true;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x0600650A RID: 25866 RVA: 0x002F3478 File Offset: 0x002F1678
	private IEnumerator FGMPFMPLJBG()
	{
		LampScript.PDLGCOHNKCN pdlgcohnkcn = new LampScript.PDLGCOHNKCN(1);
		pdlgcohnkcn.AENJLLPLILM = this;
		return pdlgcohnkcn;
	}

	// Token: 0x0600650B RID: 25867 RVA: 0x002F4958 File Offset: 0x002F2B58
	private void FFHJKFMDBEP()
	{
		if (this.IKKPFPJLPOL)
		{
			this.IKKPFPJLPOL = false;
			if (this.offerObject != null)
			{
				this.offerObject.SetActive(this.IKKPFPJLPOL);
			}
			if (base.GetComponent<AudioSource>() != null)
			{
				base.GetComponent<AudioSource>().Play();
			}
		}
	}

	// Token: 0x04000E75 RID: 3701
	public int timeOn = 18;

	// Token: 0x04000E76 RID: 3702
	public int timeOff = 6;

	// Token: 0x04000E77 RID: 3703
	public GameObject offerObject;

	// Token: 0x04000E78 RID: 3704
	private bool IKKPFPJLPOL = true;

	// Token: 0x04000E79 RID: 3705
	public bool isLightInBase = true;
}
