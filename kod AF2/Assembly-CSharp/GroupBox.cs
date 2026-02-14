using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000240 RID: 576
public class GroupBox : MonoBehaviour
{
	// Token: 0x0600838C RID: 33676 RVA: 0x003DCED0 File Offset: 0x003DB0D0
	public void BPKGBMBEJGO(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 0;
		for (int i = 1; i < this.toggleList.Count; i++)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x0600838D RID: 33677 RVA: 0x003DCF18 File Offset: 0x003DB118
	public void OKAPGILLBOL(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 0;
		for (int i = 0; i < this.toggleList.Count; i++)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x170001BF RID: 447
	// (get) Token: 0x060083C4 RID: 33732 RVA: 0x003DD018 File Offset: 0x003DB218
	// (set) Token: 0x0600838E RID: 33678 RVA: 0x003DCF60 File Offset: 0x003DB160
	public int CLBPBJGLHEE
	{
		get
		{
			return this._index;
		}
		set
		{
			this._index = value;
			foreach (Toggle toggle in this.toggleList)
			{
				toggle.isOn = false;
			}
			this.toggleList[this._index].isOn = true;
		}
	}

	// Token: 0x0600838F RID: 33679 RVA: 0x003DCFD0 File Offset: 0x003DB1D0
	public void OnCheck(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 0;
		for (int i = 0; i < this.toggleList.Count; i++)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x06008390 RID: 33680 RVA: 0x003DD018 File Offset: 0x003DB218
	public int LHBENMOJFMD()
	{
		return this._index;
	}

	// Token: 0x06008391 RID: 33681 RVA: 0x003DD020 File Offset: 0x003DB220
	private void MAGJOJDOGKH()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.PGKHBMGHPJE));
		}
	}

	// Token: 0x06008392 RID: 33682 RVA: 0x003DD084 File Offset: 0x003DB284
	private void PLBDELOIINH()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.OOPCLKJJDIE));
		}
	}

	// Token: 0x06008393 RID: 33683 RVA: 0x003DD018 File Offset: 0x003DB218
	public int MFLOHEOEDPA()
	{
		return this._index;
	}

	// Token: 0x06008394 RID: 33684 RVA: 0x003DD0E8 File Offset: 0x003DB2E8
	private void DGGMJCMLLED()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.KPHHHLGIDFB));
		}
	}

	// Token: 0x06008395 RID: 33685 RVA: 0x003DD14C File Offset: 0x003DB34C
	private void DGEIACONKCJ()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.BDCPOKFPIKD));
		}
	}

	// Token: 0x06008396 RID: 33686 RVA: 0x003DD1B0 File Offset: 0x003DB3B0
	public void APCHBAMKBML(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = false;
		}
		this.toggleList[this._index].isOn = false;
	}

	// Token: 0x06008397 RID: 33687 RVA: 0x003DD220 File Offset: 0x003DB420
	public void GIIIKJGMGLN(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 1; i < this.toggleList.Count; i++)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x06008398 RID: 33688 RVA: 0x003DD268 File Offset: 0x003DB468
	private void LMEJKAEIDCO()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.BDCPOKFPIKD));
		}
	}

	// Token: 0x06008399 RID: 33689 RVA: 0x003DD2CC File Offset: 0x003DB4CC
	public void BDCPOKFPIKD(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 0;
		for (int i = 1; i < this.toggleList.Count; i++)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x0600839A RID: 33690 RVA: 0x003DD018 File Offset: 0x003DB218
	public int OECMNDMLGKO()
	{
		return this._index;
	}

	// Token: 0x0600839B RID: 33691 RVA: 0x003DD018 File Offset: 0x003DB218
	public int EFPCKGKGHKO()
	{
		return this._index;
	}

	// Token: 0x0600839C RID: 33692 RVA: 0x003DD314 File Offset: 0x003DB514
	public void JPDMOOEJNMM(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 1; i < this.toggleList.Count; i++)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x0600839D RID: 33693 RVA: 0x003DD35C File Offset: 0x003DB55C
	public void FCKPFHMAPFG(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 0; i < this.toggleList.Count; i += 0)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x0600839E RID: 33694 RVA: 0x003DD3A4 File Offset: 0x003DB5A4
	public void MLFDFMDCNEA(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = true;
		}
		this.toggleList[this._index].isOn = false;
	}

	// Token: 0x0600839F RID: 33695 RVA: 0x003DD414 File Offset: 0x003DB614
	public void PNAGIDKJJPG(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = true;
		}
		this.toggleList[this._index].isOn = false;
	}

	// Token: 0x060083A0 RID: 33696 RVA: 0x003DD484 File Offset: 0x003DB684
	private void KECMAHFJBCD()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.OKAPGILLBOL));
		}
	}

	// Token: 0x060083A1 RID: 33697 RVA: 0x003DD4E8 File Offset: 0x003DB6E8
	public void FKBLLIHDPAB(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = false;
		}
		this.toggleList[this._index].isOn = false;
	}

	// Token: 0x060083A2 RID: 33698 RVA: 0x003DD558 File Offset: 0x003DB758
	private void ELFLOPJDAKK()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.DDJGLCCHLFB));
		}
	}

	// Token: 0x060083A4 RID: 33700 RVA: 0x003DD5D0 File Offset: 0x003DB7D0
	public void ILDJDOLBEOM(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = true;
		}
		this.toggleList[this._index].isOn = true;
	}

	// Token: 0x060083A5 RID: 33701 RVA: 0x003DD018 File Offset: 0x003DB218
	public int GJBLOODIBAJ()
	{
		return this._index;
	}

	// Token: 0x060083A6 RID: 33702 RVA: 0x003DD640 File Offset: 0x003DB840
	public void LLCELDBGGHE(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = false;
		}
		this.toggleList[this._index].isOn = false;
	}

	// Token: 0x060083A7 RID: 33703 RVA: 0x003DD6B0 File Offset: 0x003DB8B0
	public void OPNDBKDNILD(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = true;
		}
		this.toggleList[this._index].isOn = true;
	}

	// Token: 0x060083A8 RID: 33704 RVA: 0x003DD720 File Offset: 0x003DB920
	public void JOIBLOCGKDH(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = false;
		}
		this.toggleList[this._index].isOn = false;
	}

	// Token: 0x060083A9 RID: 33705 RVA: 0x003DD018 File Offset: 0x003DB218
	public int HBNBOPMMJPC()
	{
		return this._index;
	}

	// Token: 0x060083AA RID: 33706 RVA: 0x003DD790 File Offset: 0x003DB990
	private void OLBDJCFPKFG()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.JPDMOOEJNMM));
		}
	}

	// Token: 0x060083AB RID: 33707 RVA: 0x003DD7F4 File Offset: 0x003DB9F4
	public void CNNHKLFECOK(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 1; i < this.toggleList.Count; i++)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083AC RID: 33708 RVA: 0x003DD83C File Offset: 0x003DBA3C
	private void JFFPLABGMNF()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.BDCPOKFPIKD));
		}
	}

	// Token: 0x060083AD RID: 33709 RVA: 0x003DD018 File Offset: 0x003DB218
	public int FMOBOOGIFEB()
	{
		return this._index;
	}

	// Token: 0x060083AE RID: 33710 RVA: 0x003DD8A0 File Offset: 0x003DBAA0
	public void FHCACNOADKO(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 0; i < this.toggleList.Count; i += 0)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083AF RID: 33711 RVA: 0x003DD8E8 File Offset: 0x003DBAE8
	public void IKGPMEKJJOL(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 0; i < this.toggleList.Count; i += 0)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083B0 RID: 33712 RVA: 0x003DD930 File Offset: 0x003DBB30
	public void GPJGGBELGCD(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 0; i < this.toggleList.Count; i += 0)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083B1 RID: 33713 RVA: 0x003DD978 File Offset: 0x003DBB78
	private void JCELICPHGEP()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.FCKPFHMAPFG));
		}
	}

	// Token: 0x060083B2 RID: 33714 RVA: 0x003DD9DC File Offset: 0x003DBBDC
	private void ECMAANIDEBA()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.BPKGBMBEJGO));
		}
	}

	// Token: 0x060083B3 RID: 33715 RVA: 0x003DDA40 File Offset: 0x003DBC40
	private void PBMPJPIMJBF()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.PGKHBMGHPJE));
		}
	}

	// Token: 0x060083B4 RID: 33716 RVA: 0x003DD018 File Offset: 0x003DB218
	public int OKKCEPFAMJE()
	{
		return this._index;
	}

	// Token: 0x060083B5 RID: 33717 RVA: 0x003DD018 File Offset: 0x003DB218
	public int DEAKHMNAKDD()
	{
		return this._index;
	}

	// Token: 0x060083B6 RID: 33718 RVA: 0x003DDAA4 File Offset: 0x003DBCA4
	private void CLHGHANANNL()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.OOPCLKJJDIE));
		}
	}

	// Token: 0x060083B7 RID: 33719 RVA: 0x003DDB08 File Offset: 0x003DBD08
	private void GGBMJFNGHMC()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.PGKHBMGHPJE));
		}
	}

	// Token: 0x060083B8 RID: 33720 RVA: 0x003DDB6C File Offset: 0x003DBD6C
	public void KPHHHLGIDFB(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 1; i < this.toggleList.Count; i++)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083B9 RID: 33721 RVA: 0x003DD018 File Offset: 0x003DB218
	public int EKICBEPMMFM()
	{
		return this._index;
	}

	// Token: 0x060083BA RID: 33722 RVA: 0x003DDBB4 File Offset: 0x003DBDB4
	public void DOCCENCJCJD(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 0;
		for (int i = 0; i < this.toggleList.Count; i += 0)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083BB RID: 33723 RVA: 0x003DDBFC File Offset: 0x003DBDFC
	public void DNMNEBBHPLC(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 1; i < this.toggleList.Count; i++)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083BC RID: 33724 RVA: 0x003DDC44 File Offset: 0x003DBE44
	private void DHJDMKLBLEF()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.EOMCNAHDNEJ));
		}
	}

	// Token: 0x060083BD RID: 33725 RVA: 0x003DDCA8 File Offset: 0x003DBEA8
	public void NFIBGIDODIM(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 0; i < this.toggleList.Count; i++)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083BE RID: 33726 RVA: 0x003DD018 File Offset: 0x003DB218
	public int LAAGKLPICID()
	{
		return this._index;
	}

	// Token: 0x060083BF RID: 33727 RVA: 0x003DDCF0 File Offset: 0x003DBEF0
	public void KIEKFHBIIKA(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = false;
		}
		this.toggleList[this._index].isOn = true;
	}

	// Token: 0x060083C0 RID: 33728 RVA: 0x003DDD60 File Offset: 0x003DBF60
	private void FFIGGPHAIBP()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.FHCACNOADKO));
		}
	}

	// Token: 0x060083C1 RID: 33729 RVA: 0x003DDDC4 File Offset: 0x003DBFC4
	private void LPNDCJKAKEA()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.GIIIKJGMGLN));
		}
	}

	// Token: 0x060083C2 RID: 33730 RVA: 0x003DDE28 File Offset: 0x003DC028
	public void LHBHGKLNFHM(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 0; i < this.toggleList.Count; i += 0)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083C3 RID: 33731 RVA: 0x003DDE70 File Offset: 0x003DC070
	public void IPOFJBNBMPM(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 0; i < this.toggleList.Count; i += 0)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083C5 RID: 33733 RVA: 0x003DD018 File Offset: 0x003DB218
	public int DDKCOKANLNB()
	{
		return this._index;
	}

	// Token: 0x060083C6 RID: 33734 RVA: 0x003DDEB8 File Offset: 0x003DC0B8
	private void HDGNIHBIEDG()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.GPJGGBELGCD));
		}
	}

	// Token: 0x060083C7 RID: 33735 RVA: 0x003DDF1C File Offset: 0x003DC11C
	public void GKGMPDHNHKI(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 1; i < this.toggleList.Count; i += 0)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083C8 RID: 33736 RVA: 0x003DDF64 File Offset: 0x003DC164
	public void AHJAFAEFLGC(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = true;
		}
		this.toggleList[this._index].isOn = true;
	}

	// Token: 0x060083C9 RID: 33737 RVA: 0x003DDFD4 File Offset: 0x003DC1D4
	public void PGKHBMGHPJE(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 0; i < this.toggleList.Count; i++)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083CA RID: 33738 RVA: 0x003DD018 File Offset: 0x003DB218
	public int HPIAIKAOBFE()
	{
		return this._index;
	}

	// Token: 0x060083CB RID: 33739 RVA: 0x003DE01C File Offset: 0x003DC21C
	public void BMAGNENCBPF(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = false;
		}
		this.toggleList[this._index].isOn = false;
	}

	// Token: 0x060083CC RID: 33740 RVA: 0x003DE08C File Offset: 0x003DC28C
	public void OOPCLKJJDIE(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 0; i < this.toggleList.Count; i++)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083CD RID: 33741 RVA: 0x003DD018 File Offset: 0x003DB218
	public int MEDKOLLJHJM()
	{
		return this._index;
	}

	// Token: 0x060083CE RID: 33742 RVA: 0x003DD018 File Offset: 0x003DB218
	public int KHMLJOKAMMM()
	{
		return this._index;
	}

	// Token: 0x060083CF RID: 33743 RVA: 0x003DE0D4 File Offset: 0x003DC2D4
	private void PFNPOHMMJDN()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.NDDEBOPAHCI));
		}
	}

	// Token: 0x060083D0 RID: 33744 RVA: 0x003DD018 File Offset: 0x003DB218
	public int AFAHMKKKHLF()
	{
		return this._index;
	}

	// Token: 0x060083D1 RID: 33745 RVA: 0x003DD018 File Offset: 0x003DB218
	public int JBFGJIMGFKB()
	{
		return this._index;
	}

	// Token: 0x060083D2 RID: 33746 RVA: 0x003DE138 File Offset: 0x003DC338
	private void ELFALPCLKIE()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.GJEEOKNAFBB));
		}
	}

	// Token: 0x060083D3 RID: 33747 RVA: 0x003DE19C File Offset: 0x003DC39C
	public void AEDNEHLKCGO(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = false;
		}
		this.toggleList[this._index].isOn = true;
	}

	// Token: 0x060083D4 RID: 33748 RVA: 0x003DE20C File Offset: 0x003DC40C
	public void IAKIFNEFBGL(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = false;
		}
		this.toggleList[this._index].isOn = true;
	}

	// Token: 0x060083D5 RID: 33749 RVA: 0x003DD018 File Offset: 0x003DB218
	public int IKLHKPBMINM()
	{
		return this._index;
	}

	// Token: 0x060083D6 RID: 33750 RVA: 0x003DD018 File Offset: 0x003DB218
	public int JGJOBKKKEJB()
	{
		return this._index;
	}

	// Token: 0x060083D7 RID: 33751 RVA: 0x003DE27C File Offset: 0x003DC47C
	public void NDDEBOPAHCI(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 0; i < this.toggleList.Count; i++)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083D8 RID: 33752 RVA: 0x003DD018 File Offset: 0x003DB218
	public int JOGKKPKIAIK()
	{
		return this._index;
	}

	// Token: 0x060083D9 RID: 33753 RVA: 0x003DE2C4 File Offset: 0x003DC4C4
	private void PMDPLLIBJAF()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.DNMNEBBHPLC));
		}
	}

	// Token: 0x060083DA RID: 33754 RVA: 0x003DE328 File Offset: 0x003DC528
	public void BBAAPKHGAME(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = false;
		}
		this.toggleList[this._index].isOn = true;
	}

	// Token: 0x060083DB RID: 33755 RVA: 0x003DE398 File Offset: 0x003DC598
	public void GJEEOKNAFBB(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 0;
		for (int i = 0; i < this.toggleList.Count; i += 0)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083DC RID: 33756 RVA: 0x003DE3E0 File Offset: 0x003DC5E0
	public void PNPCNACBFHP(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = false;
		}
		this.toggleList[this._index].isOn = false;
	}

	// Token: 0x060083DD RID: 33757 RVA: 0x003DE450 File Offset: 0x003DC650
	public void DOKBPILKOEM(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = true;
		}
		this.toggleList[this._index].isOn = false;
	}

	// Token: 0x060083DE RID: 33758 RVA: 0x003DE4C0 File Offset: 0x003DC6C0
	public void LEHNOGNLLDK(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = true;
		}
		this.toggleList[this._index].isOn = true;
	}

	// Token: 0x060083DF RID: 33759 RVA: 0x003DD018 File Offset: 0x003DB218
	public int FDJNGFHEEDO()
	{
		return this._index;
	}

	// Token: 0x060083E0 RID: 33760 RVA: 0x003DE530 File Offset: 0x003DC730
	public void DDPDDCMAJED(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = true;
		}
		this.toggleList[this._index].isOn = false;
	}

	// Token: 0x060083E1 RID: 33761 RVA: 0x003DE5A0 File Offset: 0x003DC7A0
	public void NDJLJNNFFKC(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = true;
		}
		this.toggleList[this._index].isOn = false;
	}

	// Token: 0x060083E2 RID: 33762 RVA: 0x003DE610 File Offset: 0x003DC810
	public void FOBLJHGKLDN(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = false;
		}
		this.toggleList[this._index].isOn = true;
	}

	// Token: 0x060083E3 RID: 33763 RVA: 0x003DE680 File Offset: 0x003DC880
	public void AOLPKBLGOJJ(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = false;
		}
		this.toggleList[this._index].isOn = true;
	}

	// Token: 0x060083E4 RID: 33764 RVA: 0x003DE6F0 File Offset: 0x003DC8F0
	private void ANHOOJFEJJE()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.DNMNEBBHPLC));
		}
	}

	// Token: 0x060083E5 RID: 33765 RVA: 0x003DE754 File Offset: 0x003DC954
	private void CAJLCEPLKJG()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.IKGPMEKJJOL));
		}
	}

	// Token: 0x060083E6 RID: 33766 RVA: 0x003DE7B8 File Offset: 0x003DC9B8
	private void CKIGGCAHAFD()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.GIIIKJGMGLN));
		}
	}

	// Token: 0x060083E7 RID: 33767 RVA: 0x003DE81C File Offset: 0x003DCA1C
	public void IOOBCALMHIF(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = false;
		}
		this.toggleList[this._index].isOn = false;
	}

	// Token: 0x060083E8 RID: 33768 RVA: 0x003DE88C File Offset: 0x003DCA8C
	private void CKGPEFOKKNL()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.IKGPMEKJJOL));
		}
	}

	// Token: 0x060083E9 RID: 33769 RVA: 0x003DD018 File Offset: 0x003DB218
	public int LKLEBPJMEJI()
	{
		return this._index;
	}

	// Token: 0x060083EA RID: 33770 RVA: 0x003DE8F0 File Offset: 0x003DCAF0
	private void LHKGDKLABAA()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.CNNHKLFECOK));
		}
	}

	// Token: 0x060083EB RID: 33771 RVA: 0x003DE954 File Offset: 0x003DCB54
	public void MBEBCMMHMKG(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = true;
		}
		this.toggleList[this._index].isOn = false;
	}

	// Token: 0x060083EC RID: 33772 RVA: 0x003DE9C4 File Offset: 0x003DCBC4
	public void DDJGLCCHLFB(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 0; i < this.toggleList.Count; i++)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083ED RID: 33773 RVA: 0x003DEA0C File Offset: 0x003DCC0C
	public void OCDPEINGMLG(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = true;
		}
		this.toggleList[this._index].isOn = false;
	}

	// Token: 0x060083EE RID: 33774 RVA: 0x003DEA7C File Offset: 0x003DCC7C
	private void Start()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.OnCheck));
		}
	}

	// Token: 0x060083EF RID: 33775 RVA: 0x003DEAE0 File Offset: 0x003DCCE0
	public void ODGOGPJGJNE(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = false;
		}
		this.toggleList[this._index].isOn = false;
	}

	// Token: 0x060083F0 RID: 33776 RVA: 0x003DD018 File Offset: 0x003DB218
	public int FBOPHFDGHFO()
	{
		return this._index;
	}

	// Token: 0x060083F1 RID: 33777 RVA: 0x003DEB50 File Offset: 0x003DCD50
	public void EPFHLIMMMLK(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 0;
		for (int i = 1; i < this.toggleList.Count; i++)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083F2 RID: 33778 RVA: 0x003DEB98 File Offset: 0x003DCD98
	public void KBJLCLFNJGN(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = true;
		}
		this.toggleList[this._index].isOn = true;
	}

	// Token: 0x060083F3 RID: 33779 RVA: 0x003DEC08 File Offset: 0x003DCE08
	public void EOMCNAHDNEJ(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 1;
		for (int i = 1; i < this.toggleList.Count; i++)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x060083F4 RID: 33780 RVA: 0x003DEC50 File Offset: 0x003DCE50
	private void DDEBDCGNCPC()
	{
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.onValueChanged.AddListener(new UnityAction<bool>(this.FCKPFHMAPFG));
		}
	}

	// Token: 0x060083F5 RID: 33781 RVA: 0x003DD018 File Offset: 0x003DB218
	public int OAPNFDMFJLH()
	{
		return this._index;
	}

	// Token: 0x060083F6 RID: 33782 RVA: 0x003DECB4 File Offset: 0x003DCEB4
	public void MELFKNLBDOP(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = true;
		}
		this.toggleList[this._index].isOn = true;
	}

	// Token: 0x060083F7 RID: 33783 RVA: 0x003DED24 File Offset: 0x003DCF24
	public void DHHPDLNDKDO(int DCCPCBLODIG)
	{
		this._index = DCCPCBLODIG;
		foreach (Toggle toggle in this.toggleList)
		{
			toggle.isOn = true;
		}
		this.toggleList[this._index].isOn = false;
	}

	// Token: 0x060083F8 RID: 33784 RVA: 0x003DED94 File Offset: 0x003DCF94
	public void FCLIBCGIFKN(bool JJMBNHDDKGE)
	{
		if (!JJMBNHDDKGE)
		{
			return;
		}
		this._index = 0;
		for (int i = 0; i < this.toggleList.Count; i++)
		{
			if (this.toggleList[i].isOn)
			{
				this._index = i;
			}
		}
	}

	// Token: 0x040012A6 RID: 4774
	public ToggleGroup group;

	// Token: 0x040012A7 RID: 4775
	public List<Toggle> toggleList = new List<Toggle>();

	// Token: 0x040012A8 RID: 4776
	public int _index;
}
