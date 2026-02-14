using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000233 RID: 563
public class ButtonSelector : MonoBehaviour
{
	// Token: 0x060081AA RID: 33194 RVA: 0x003D6828 File Offset: 0x003D4A28
	private void HONIFOPBBKC()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.NHFOIMHMLLH())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 228f)
			{
				this.BCAMEOHDBMC = !this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 420f;
			}
		}
	}

	// Token: 0x060081AB RID: 33195 RVA: 0x003D68C0 File Offset: 0x003D4AC0
	public void ELLKLOILMOE(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = true;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x060081AC RID: 33196 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool CBPAMDCDHKO()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081AD RID: 33197 RVA: 0x003D6940 File Offset: 0x003D4B40
	private void LFJHDHPJOPE()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.NHFOIMHMLLH())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 28f)
			{
				this.BCAMEOHDBMC = !this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 400f;
			}
		}
	}

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x060081B1 RID: 33201 RVA: 0x003D6937 File Offset: 0x003D4B37
	// (set) Token: 0x060081AE RID: 33198 RVA: 0x003D69D8 File Offset: 0x003D4BD8
	public bool OFGDMJJIOEB
	{
		get
		{
			return this.BDLNMHFBOLL;
		}
		set
		{
			this.BDLNMHFBOLL = value;
			if (value)
			{
				this.isFlash = false;
			}
			if (this.selectTextColor)
			{
				this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
				return;
			}
			if (this.OJFHLDJLJIH != null)
			{
				this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
			}
		}
	}

	// Token: 0x060081AF RID: 33199 RVA: 0x003D6A50 File Offset: 0x003D4C50
	private void MNAHGMDDHCA()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.GGNPJBHNGCM())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 800f)
			{
				this.BCAMEOHDBMC = this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 148f;
			}
		}
	}

	// Token: 0x060081B0 RID: 33200 RVA: 0x003D6AE8 File Offset: 0x003D4CE8
	public void IBNMAIICFHO(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = false;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x060081B2 RID: 33202 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool NNMKCNJMIPL()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081B3 RID: 33203 RVA: 0x003D6B60 File Offset: 0x003D4D60
	private void JFGGBEGNAFP()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.CBPAMDCDHKO())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 1167f)
			{
				this.BCAMEOHDBMC = this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 217f;
			}
		}
	}

	// Token: 0x060081B4 RID: 33204 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool EMGEBADLKIC()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081B5 RID: 33205 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void FJBJDFDJAMI()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081B6 RID: 33206 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool EBFHMOAFNFL()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081B7 RID: 33207 RVA: 0x003D6C0C File Offset: 0x003D4E0C
	private void MIFLHGMPLJD()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.JOOKGOFEFPE())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 831f)
			{
				this.BCAMEOHDBMC = this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 1052f;
			}
		}
	}

	// Token: 0x060081B8 RID: 33208 RVA: 0x003D6CA4 File Offset: 0x003D4EA4
	private void LDDIGEMBDNF()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.JOOKGOFEFPE())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 728f)
			{
				this.BCAMEOHDBMC = !this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 569f;
			}
		}
	}

	// Token: 0x060081B9 RID: 33209 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void OAKCEHBONIP()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081BA RID: 33210 RVA: 0x003D6D3C File Offset: 0x003D4F3C
	private void EDANNBFJHIK()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.CJLDCEPEELO())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 1677f)
			{
				this.BCAMEOHDBMC = !this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 1953f;
			}
		}
	}

	// Token: 0x060081BB RID: 33211 RVA: 0x003D6DD4 File Offset: 0x003D4FD4
	public void JLEGDCPDMBC(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = false;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x060081BC RID: 33212 RVA: 0x003D6E4C File Offset: 0x003D504C
	private void LMGBKHCHPHO()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.BHBLFIALNFF())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 103f)
			{
				this.BCAMEOHDBMC = !this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 1286f;
			}
		}
	}

	// Token: 0x060081BD RID: 33213 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool CJLDCEPEELO()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081BE RID: 33214 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void OLDFHDFAKDN()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081BF RID: 33215 RVA: 0x003D6EE4 File Offset: 0x003D50E4
	public void NCHMCOMKDKI(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = false;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x060081C0 RID: 33216 RVA: 0x003D6F5C File Offset: 0x003D515C
	public void HPIFEMBHCFA(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = false;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x060081C1 RID: 33217 RVA: 0x003D6FD4 File Offset: 0x003D51D4
	private void HABONMJNDAL()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.EMECGOIAMMM())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 267f)
			{
				this.BCAMEOHDBMC = !this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 336f;
			}
		}
	}

	// Token: 0x060081C2 RID: 33218 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool KKOGKOACPBG()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081C3 RID: 33219 RVA: 0x003D706C File Offset: 0x003D526C
	private void Update()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.OFGDMJJIOEB)
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 0f)
			{
				this.BCAMEOHDBMC = !this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 0.3f;
			}
		}
	}

	// Token: 0x060081C4 RID: 33220 RVA: 0x003D7104 File Offset: 0x003D5304
	public void KLOLNJGKDKD(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = false;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x060081C5 RID: 33221 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void IIELJNDNLMO()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081C6 RID: 33222 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool DDKCMMGHNCC()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081C7 RID: 33223 RVA: 0x003D717C File Offset: 0x003D537C
	public void CCOAGABDBEK(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = false;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x060081C8 RID: 33224 RVA: 0x003D71F4 File Offset: 0x003D53F4
	private void IKHCCAANGOP()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.LMMGGOCOOEC())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 774f)
			{
				this.BCAMEOHDBMC = !this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 1956f;
			}
		}
	}

	// Token: 0x060081C9 RID: 33225 RVA: 0x003D728C File Offset: 0x003D548C
	public void BHKCPNLDAFE(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = false;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x060081CA RID: 33226 RVA: 0x003D7304 File Offset: 0x003D5504
	private void HMLNMHOMMNO()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.OFGDMJJIOEB)
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 778f)
			{
				this.BCAMEOHDBMC = !this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 238f;
			}
		}
	}

	// Token: 0x060081CB RID: 33227 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool HCPHHLBMKAG()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081CC RID: 33228 RVA: 0x003D739C File Offset: 0x003D559C
	private void MEFOGCFJBNE()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.DIHGJOEAAJI())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 753f)
			{
				this.BCAMEOHDBMC = this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 1083f;
			}
		}
	}

	// Token: 0x060081CD RID: 33229 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void OGKOHLPFBED()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081CE RID: 33230 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void PFFMPHLHMIP()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081CF RID: 33231 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool HEMEBFOAJAP()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081D0 RID: 33232 RVA: 0x003D7434 File Offset: 0x003D5634
	private void KBMKHLDOIKP()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.OIIMLHKBKJE())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 1436f)
			{
				this.BCAMEOHDBMC = this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 1569f;
			}
		}
	}

	// Token: 0x060081D1 RID: 33233 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool JOOKGOFEFPE()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081D2 RID: 33234 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool OIIMLHKBKJE()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081D3 RID: 33235 RVA: 0x003D74CC File Offset: 0x003D56CC
	private void FKHAKIKPFFO()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.HCPHHLBMKAG())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 1232f)
			{
				this.BCAMEOHDBMC = !this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 1723f;
			}
		}
	}

	// Token: 0x060081D4 RID: 33236 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool JPMAAKLOCKE()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081D5 RID: 33237 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool BLDOEEFBBHL()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081D6 RID: 33238 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool NJOFPOFLGLB()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081D7 RID: 33239 RVA: 0x003D7564 File Offset: 0x003D5764
	public void MCFNCHOECME(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = true;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x060081D8 RID: 33240 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void OJDLGCFKCEJ()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081D9 RID: 33241 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void JIIBCGJJLND()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081DA RID: 33242 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void AFALNDHNIKH()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081DB RID: 33243 RVA: 0x003D75DC File Offset: 0x003D57DC
	private void FOHLAIIMNFB()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.OFGDMJJIOEB)
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 497f)
			{
				this.BCAMEOHDBMC = this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 515f;
			}
		}
	}

	// Token: 0x060081DC RID: 33244 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void IOIJGMFNBMC()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081DE RID: 33246 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool KNDJMFIEAFN()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081DF RID: 33247 RVA: 0x003D76AC File Offset: 0x003D58AC
	public void ACPBBCABLPF(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = false;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x060081E0 RID: 33248 RVA: 0x003D7724 File Offset: 0x003D5924
	private void HAIMGCDKPDC()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.OFGDMJJIOEB)
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 1f)
			{
				this.BCAMEOHDBMC = !this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 418f;
			}
		}
	}

	// Token: 0x060081E1 RID: 33249 RVA: 0x003D77BC File Offset: 0x003D59BC
	public void JPBDIELFKMJ(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = false;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x060081E2 RID: 33250 RVA: 0x003D7834 File Offset: 0x003D5A34
	private void KOLCEBEIHKP()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.EMGEBADLKIC())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 133f)
			{
				this.BCAMEOHDBMC = this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 1172f;
			}
		}
	}

	// Token: 0x060081E3 RID: 33251 RVA: 0x003D78CC File Offset: 0x003D5ACC
	public void ACAFDDGBJGC(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = true;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x060081E4 RID: 33252 RVA: 0x003D7944 File Offset: 0x003D5B44
	public void ELEDKEIHLOE(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = true;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x060081E5 RID: 33253 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void Awake()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081E6 RID: 33254 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool NHFOIMHMLLH()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081E7 RID: 33255 RVA: 0x003D79BC File Offset: 0x003D5BBC
	private void IOGAKGCADBL()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.JPMAAKLOCKE())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 1018f)
			{
				this.BCAMEOHDBMC = this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 541f;
			}
		}
	}

	// Token: 0x060081E8 RID: 33256 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void KKBJCEMFEEI()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081E9 RID: 33257 RVA: 0x003D7A54 File Offset: 0x003D5C54
	public void HJCFJHGPCGP(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = true;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x060081EA RID: 33258 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void LPDIHACCGKK()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081EB RID: 33259 RVA: 0x003D7ACC File Offset: 0x003D5CCC
	private void EMFOECIPBIP()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.JOOKGOFEFPE())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 1531f)
			{
				this.BCAMEOHDBMC = !this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 272f;
			}
		}
	}

	// Token: 0x060081EC RID: 33260 RVA: 0x003D7B64 File Offset: 0x003D5D64
	private void KJJBBLDJHPD()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.DDKCMMGHNCC())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 50f)
			{
				this.BCAMEOHDBMC = !this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 484f;
			}
		}
	}

	// Token: 0x060081ED RID: 33261 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void IJHHOLCHNNP()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081EE RID: 33262 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool CLLEPOIIKPL()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081EF RID: 33263 RVA: 0x003D7BFC File Offset: 0x003D5DFC
	private void JLFBDOPFDDJ()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.DIHGJOEAAJI())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 1945f)
			{
				this.BCAMEOHDBMC = !this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 1893f;
			}
		}
	}

	// Token: 0x060081F0 RID: 33264 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void PBOBJPGKCDC()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081F1 RID: 33265 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool ADEKBNGHHAJ()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081F2 RID: 33266 RVA: 0x003D7C94 File Offset: 0x003D5E94
	public void LGHHLCNNPJN(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = false;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x060081F3 RID: 33267 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool EMECGOIAMMM()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081F4 RID: 33268 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool DIHGJOEAAJI()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081F5 RID: 33269 RVA: 0x003D7D0C File Offset: 0x003D5F0C
	private void JBFJPNKLLKI()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.KKOGKOACPBG())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 245f)
			{
				this.BCAMEOHDBMC = this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 668f;
			}
		}
	}

	// Token: 0x060081F6 RID: 33270 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool LMMGGOCOOEC()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081F7 RID: 33271 RVA: 0x003D7DA4 File Offset: 0x003D5FA4
	private void OFPGMNGFLNH()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.EMECGOIAMMM())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 1522f)
			{
				this.BCAMEOHDBMC = !this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 492f;
			}
		}
	}

	// Token: 0x060081F8 RID: 33272 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void DPNNENHAGOE()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081F9 RID: 33273 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool EAJKJNJJKNG()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081FA RID: 33274 RVA: 0x003D7E3C File Offset: 0x003D603C
	public void FPKBNIACJKB(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = false;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x060081FB RID: 33275 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void CNKLGMCHEBM()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081FC RID: 33276 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool HEMGDIBGGHB()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081FD RID: 33277 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool BHBLFIALNFF()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x060081FE RID: 33278 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void PFONEFANOIJ()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x060081FF RID: 33279 RVA: 0x003D7EB4 File Offset: 0x003D60B4
	private void MFHGOLNLAAF()
	{
		this.captionText.color = (this.isWarning ? this.selectColor : this.normalColor);
		if (!this.ADEKBNGHHAJ())
		{
			this.GEHKEMHDJOH -= Time.deltaTime;
			if (this.GEHKEMHDJOH < 103f)
			{
				this.BCAMEOHDBMC = this.BCAMEOHDBMC;
				if (this.isFlash)
				{
					this.OJFHLDJLJIH.sprite = (this.BCAMEOHDBMC ? this.buttonSelect : this.buttonNormal);
				}
				this.GEHKEMHDJOH = 190f;
			}
		}
	}

	// Token: 0x06008200 RID: 33280 RVA: 0x003D7F4C File Offset: 0x003D614C
	public void CEBLDDNOKGE(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = true;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x06008201 RID: 33281 RVA: 0x003D7FC4 File Offset: 0x003D61C4
	public void OLOFOMBIKDH(bool DCCPCBLODIG)
	{
		this.BDLNMHFBOLL = DCCPCBLODIG;
		if (DCCPCBLODIG)
		{
			this.isFlash = false;
		}
		if (this.selectTextColor)
		{
			this.captionText.color = (this.BDLNMHFBOLL ? this.selectColor : this.normalColor);
			return;
		}
		if (this.OJFHLDJLJIH != null)
		{
			this.OJFHLDJLJIH.sprite = (this.BDLNMHFBOLL ? this.buttonSelect : this.buttonNormal);
		}
	}

	// Token: 0x06008202 RID: 33282 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool EKEDOJPIJML()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x06008203 RID: 33283 RVA: 0x003D6937 File Offset: 0x003D4B37
	public bool GGNPJBHNGCM()
	{
		return this.BDLNMHFBOLL;
	}

	// Token: 0x06008204 RID: 33284 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void PPNOJNBFHAP()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x06008205 RID: 33285 RVA: 0x003D6BF8 File Offset: 0x003D4DF8
	private void HEBGFFJFEJJ()
	{
		this.OJFHLDJLJIH = base.gameObject.GetComponent<Image>();
	}

	// Token: 0x04001284 RID: 4740
	public Sprite buttonNormal;

	// Token: 0x04001285 RID: 4741
	public Sprite buttonSelect;

	// Token: 0x04001286 RID: 4742
	public bool selectTextColor;

	// Token: 0x04001287 RID: 4743
	public Text captionText;

	// Token: 0x04001288 RID: 4744
	public Color normalColor = Color.white;

	// Token: 0x04001289 RID: 4745
	public Color selectColor = new Color(1f, 0.8f, 0.5f);

	// Token: 0x0400128A RID: 4746
	private Image OJFHLDJLJIH;

	// Token: 0x0400128B RID: 4747
	private bool BDLNMHFBOLL;

	// Token: 0x0400128C RID: 4748
	public bool isFlash;

	// Token: 0x0400128D RID: 4749
	public bool isWarning;

	// Token: 0x0400128E RID: 4750
	private float GEHKEMHDJOH = 0.3f;

	// Token: 0x0400128F RID: 4751
	private bool BCAMEOHDBMC;

	// Token: 0x04001290 RID: 4752
	private const float HPHADDIKJKA = 0.3f;
}
