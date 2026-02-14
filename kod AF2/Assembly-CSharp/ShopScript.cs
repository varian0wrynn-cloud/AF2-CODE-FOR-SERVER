using System;
using System.Collections;
using Steamworks;
using UnityEngine;

// Token: 0x02000181 RID: 385
public class ShopScript : MonoBehaviour
{
	// Token: 0x060054FF RID: 21759 RVA: 0x0027BAFB File Offset: 0x00279CFB
	private IEnumerator CJFABPPBJMM(int BCMLHBJFCCM)
	{
		ShopScript.FPKMJFPILJC fpkmjfpiljc = new ShopScript.FPKMJFPILJC(1);
		fpkmjfpiljc.AENJLLPLILM = this;
		fpkmjfpiljc.BCMLHBJFCCM = BCMLHBJFCCM;
		return fpkmjfpiljc;
	}

	// Token: 0x06005500 RID: 21760 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AMDMCKIFBPA()
	{
	}

	// Token: 0x06005501 RID: 21761 RVA: 0x0027BB11 File Offset: 0x00279D11
	private void Start()
	{
		bool initialized = SteamManager.FPAKOLIPIND;
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005502 RID: 21762 RVA: 0x0027BB25 File Offset: 0x00279D25
	private void OALIDDIKLHK()
	{
		SteamManager.FHGDEIGKKIE();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005503 RID: 21763 RVA: 0x0027BB39 File Offset: 0x00279D39
	public void BDJKAPIPICN(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("1");
			return;
		}
		if (SteamManager.CJBDAMIDAOE() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.OIEKECLLIMO(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005504 RID: 21764 RVA: 0x0027BB66 File Offset: 0x00279D66
	private IEnumerator EMCIGMHPHLN(int BCMLHBJFCCM)
	{
		this.panelProcessing.SetActive(true);
		this.DKLAMJMFEOC = true;
		SteamApps.GetCurrentGameLanguage();
		long num = 0L;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI;
		}
		string url = string.Format("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", new object[]
		{
			SteamUser.GetSteamID(),
			BCMLHBJFCCM,
			JNBICAJIJMM.IKGFHGKKCPG.GLPAPGLHOFF.JFGKIGAACHI,
			num
		});
		WWW www = new WWW(url);
		yield return www;
		if (www.isDone)
		{
			new BNOOIOKIFJC.DIGGOHPGCNN(www.text);
			if (www.text.Trim() != "result=OK")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error:" + www.text);
			}
		}
		else
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error via request");
			Debug.LogError("Error via pay request");
		}
		this.DKLAMJMFEOC = false;
		this.panelProcessing.SetActive(false);
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06005505 RID: 21765 RVA: 0x0027BB7C File Offset: 0x00279D7C
	public void HMNCPBIMNFJ(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("startB");
			return;
		}
		if (SteamManager.NNFCGADDAHL() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.OHMDIKBBLNB(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005506 RID: 21766 RVA: 0x0027BBA9 File Offset: 0x00279DA9
	private void PMDPLLIBJAF()
	{
		SteamManager.EPDLLLGNGFO();
		this.panelProcessing.SetActive(true);
	}

	// Token: 0x06005507 RID: 21767 RVA: 0x0027BBBD File Offset: 0x00279DBD
	private void LGPJEFMIIOL()
	{
		SteamManager.PJMKPOFDGCK();
		this.panelProcessing.SetActive(true);
	}

	// Token: 0x06005508 RID: 21768 RVA: 0x00022FCC File Offset: 0x000211CC
	private void NOLKOIHEICD()
	{
	}

	// Token: 0x06005509 RID: 21769 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x0600550A RID: 21770 RVA: 0x0027BBD1 File Offset: 0x00279DD1
	public void LAFNNACBOLH(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("__b");
			return;
		}
		if (SteamManager.NNFCGADDAHL() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.GMFLMFIKFPF(JBGLPPHDMCK));
		}
	}

	// Token: 0x0600550B RID: 21771 RVA: 0x0027BB66 File Offset: 0x00279D66
	private IEnumerator EENBDDPDMCC(int BCMLHBJFCCM)
	{
		this.panelProcessing.SetActive(true);
		this.DKLAMJMFEOC = true;
		SteamApps.GetCurrentGameLanguage();
		long num = 0L;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI;
		}
		string url = string.Format("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", new object[]
		{
			SteamUser.GetSteamID(),
			BCMLHBJFCCM,
			JNBICAJIJMM.IKGFHGKKCPG.GLPAPGLHOFF.JFGKIGAACHI,
			num
		});
		www = new WWW(url);
		yield return www;
		if (www.isDone)
		{
			new BNOOIOKIFJC.DIGGOHPGCNN(www.text);
			if (www.text.Trim() != "result=OK")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error:" + www.text);
			}
		}
		else
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error via request");
			Debug.LogError("Error via pay request");
		}
		this.DKLAMJMFEOC = false;
		this.panelProcessing.SetActive(false);
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x0600550C RID: 21772 RVA: 0x0027BAFB File Offset: 0x00279CFB
	private IEnumerator OLAJJNCBGBP(int BCMLHBJFCCM)
	{
		ShopScript.FPKMJFPILJC fpkmjfpiljc = new ShopScript.FPKMJFPILJC(1);
		fpkmjfpiljc.AENJLLPLILM = this;
		fpkmjfpiljc.BCMLHBJFCCM = BCMLHBJFCCM;
		return fpkmjfpiljc;
	}

	// Token: 0x0600550D RID: 21773 RVA: 0x0027BB66 File Offset: 0x00279D66
	private IEnumerator GJMOHAEBPLL(int BCMLHBJFCCM)
	{
		this.panelProcessing.SetActive(true);
		this.DKLAMJMFEOC = true;
		SteamApps.GetCurrentGameLanguage();
		long num = 0L;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI;
		}
		string url = string.Format("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", new object[]
		{
			SteamUser.GetSteamID(),
			BCMLHBJFCCM,
			JNBICAJIJMM.IKGFHGKKCPG.GLPAPGLHOFF.JFGKIGAACHI,
			num
		});
		www = new WWW(url);
		yield return www;
		if (www.isDone)
		{
			new BNOOIOKIFJC.DIGGOHPGCNN(www.text);
			if (www.text.Trim() != "result=OK")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error:" + www.text);
			}
		}
		else
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error via request");
			Debug.LogError("Error via pay request");
		}
		this.DKLAMJMFEOC = false;
		this.panelProcessing.SetActive(false);
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x0600550E RID: 21774 RVA: 0x0027BBFE File Offset: 0x00279DFE
	public void JNLEALBOCAD(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("SUNSHINE_FOUR_CASCADES");
			return;
		}
		if (SteamManager.FPAKOLIPIND && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.FKMKMGDJCON(JBGLPPHDMCK));
		}
	}

	// Token: 0x0600550F RID: 21775 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AAEFACEGJMB()
	{
	}

	// Token: 0x06005510 RID: 21776 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OCJGBIPEELM()
	{
	}

	// Token: 0x06005511 RID: 21777 RVA: 0x0027BC2B File Offset: 0x00279E2B
	public void KPCLABOOLHH(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("ClimbIdle");
			return;
		}
		if (SteamManager.GAEJKDJCOEH() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.IKLDBOCAPIF(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005512 RID: 21778 RVA: 0x0027BC58 File Offset: 0x00279E58
	private void GMBPCGCCPDM()
	{
		SteamManager.NGEACBIHBOP();
		this.panelProcessing.SetActive(true);
	}

	// Token: 0x06005513 RID: 21779 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PMKOAHMNBBG()
	{
	}

	// Token: 0x06005514 RID: 21780 RVA: 0x0027BC6C File Offset: 0x00279E6C
	private void NCBLFNKNEDK()
	{
		SteamManager.NGEACBIHBOP();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005515 RID: 21781 RVA: 0x0027BC80 File Offset: 0x00279E80
	private void ANHOOJFEJJE()
	{
		SteamManager.NNFCGADDAHL();
		this.panelProcessing.SetActive(true);
	}

	// Token: 0x06005516 RID: 21782 RVA: 0x0027BC94 File Offset: 0x00279E94
	private void LHJCHPFKGDB()
	{
		SteamManager.FNNHOLIBGJH();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005517 RID: 21783 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OFPGMNGFLNH()
	{
	}

	// Token: 0x06005518 RID: 21784 RVA: 0x0027BCA8 File Offset: 0x00279EA8
	public void HLJEJABOLCL(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("");
			return;
		}
		if (SteamManager.EPDLLLGNGFO() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.IPOLHINDGML(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005519 RID: 21785 RVA: 0x0027BCD5 File Offset: 0x00279ED5
	public void APFADMABODK(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("360SpinDeath");
			return;
		}
		if (SteamManager.FPAKOLIPIND && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.IIEOIJJEBGE(JBGLPPHDMCK));
		}
	}

	// Token: 0x0600551A RID: 21786 RVA: 0x0027BAFB File Offset: 0x00279CFB
	private IEnumerator OIEKECLLIMO(int BCMLHBJFCCM)
	{
		ShopScript.FPKMJFPILJC fpkmjfpiljc = new ShopScript.FPKMJFPILJC(1);
		fpkmjfpiljc.AENJLLPLILM = this;
		fpkmjfpiljc.BCMLHBJFCCM = BCMLHBJFCCM;
		return fpkmjfpiljc;
	}

	// Token: 0x0600551B RID: 21787 RVA: 0x0027BD02 File Offset: 0x00279F02
	private void JHAKJAMBNAH()
	{
		SteamManager.NIAFGBPDDEA();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x0600551C RID: 21788 RVA: 0x0027BD16 File Offset: 0x00279F16
	public void LJOJBGOMFNE(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("WeaponStab");
			return;
		}
		if (SteamManager.FPAKOLIPIND && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.OPPKFDDOPGP(JBGLPPHDMCK));
		}
	}

	// Token: 0x0600551D RID: 21789 RVA: 0x0027BD43 File Offset: 0x00279F43
	private void CLHGHANANNL()
	{
		SteamManager.JBKCBLGNLLG();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x0600551E RID: 21790 RVA: 0x0027BB66 File Offset: 0x00279D66
	private IEnumerator OCJNDKMKFBM(int BCMLHBJFCCM)
	{
		this.panelProcessing.SetActive(true);
		this.DKLAMJMFEOC = true;
		SteamApps.GetCurrentGameLanguage();
		long num = 0L;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI;
		}
		string url = string.Format("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", new object[]
		{
			SteamUser.GetSteamID(),
			BCMLHBJFCCM,
			JNBICAJIJMM.IKGFHGKKCPG.GLPAPGLHOFF.JFGKIGAACHI,
			num
		});
		www = new WWW(url);
		yield return www;
		if (www.isDone)
		{
			new BNOOIOKIFJC.DIGGOHPGCNN(www.text);
			if (www.text.Trim() != "result=OK")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error:" + www.text);
			}
		}
		else
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error via request");
			Debug.LogError("Error via pay request");
		}
		this.DKLAMJMFEOC = false;
		this.panelProcessing.SetActive(false);
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x0600551F RID: 21791 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CBPPOJCGFKH()
	{
	}

	// Token: 0x06005520 RID: 21792 RVA: 0x0027BD02 File Offset: 0x00279F02
	private void HDFCIACDDEK()
	{
		SteamManager.NIAFGBPDDEA();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005521 RID: 21793 RVA: 0x0027BD57 File Offset: 0x00279F57
	public void BIJJMFFEFEB(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("CD");
			return;
		}
		if (SteamManager.GHHNBKFIFOC() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.FKMKMGDJCON(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005522 RID: 21794 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ACFEBEDDIAI()
	{
	}

	// Token: 0x06005523 RID: 21795 RVA: 0x0027BB66 File Offset: 0x00279D66
	private IEnumerator MIAHMGCOFEF(int BCMLHBJFCCM)
	{
		this.panelProcessing.SetActive(true);
		this.DKLAMJMFEOC = true;
		SteamApps.GetCurrentGameLanguage();
		long num = 0L;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI;
		}
		string url = string.Format("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", new object[]
		{
			SteamUser.GetSteamID(),
			BCMLHBJFCCM,
			JNBICAJIJMM.IKGFHGKKCPG.GLPAPGLHOFF.JFGKIGAACHI,
			num
		});
		www = new WWW(url);
		yield return www;
		if (www.isDone)
		{
			new BNOOIOKIFJC.DIGGOHPGCNN(www.text);
			if (www.text.Trim() != "result=OK")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error:" + www.text);
			}
		}
		else
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error via request");
			Debug.LogError("Error via pay request");
		}
		this.DKLAMJMFEOC = false;
		this.panelProcessing.SetActive(false);
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06005524 RID: 21796 RVA: 0x0027BD84 File Offset: 0x00279F84
	private void IAAOGAPJDID()
	{
		SteamManager.PGAALOOPLCE();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005525 RID: 21797 RVA: 0x0027BD98 File Offset: 0x00279F98
	public void EHDJGECALDO(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("RollerBladeBackFlip");
			return;
		}
		if (SteamManager.PJMKPOFDGCK() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.EMCIGMHPHLN(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005526 RID: 21798 RVA: 0x0027BDC5 File Offset: 0x00279FC5
	public void JEAMGLFPOLO(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("_");
			return;
		}
		if (SteamManager.HFCCLHMGOKA() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.NJKGHJKKECA(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005527 RID: 21799 RVA: 0x0027BB66 File Offset: 0x00279D66
	private IEnumerator EMKNHDCLONO(int BCMLHBJFCCM)
	{
		this.panelProcessing.SetActive(true);
		this.DKLAMJMFEOC = true;
		SteamApps.GetCurrentGameLanguage();
		long num = 0L;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI;
		}
		string url = string.Format("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", new object[]
		{
			SteamUser.GetSteamID(),
			BCMLHBJFCCM,
			JNBICAJIJMM.IKGFHGKKCPG.GLPAPGLHOFF.JFGKIGAACHI,
			num
		});
		www = new WWW(url);
		yield return www;
		if (www.isDone)
		{
			new BNOOIOKIFJC.DIGGOHPGCNN(www.text);
			if (www.text.Trim() != "result=OK")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error:" + www.text);
			}
		}
		else
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error via request");
			Debug.LogError("Error via pay request");
		}
		this.DKLAMJMFEOC = false;
		this.panelProcessing.SetActive(false);
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06005528 RID: 21800 RVA: 0x0027BDF2 File Offset: 0x00279FF2
	public void KNJGAAJECLF(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("SYS");
			return;
		}
		if (SteamManager.EPDLLLGNGFO() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.OCJNDKMKFBM(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005529 RID: 21801 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DAFJMNMFOON()
	{
	}

	// Token: 0x0600552A RID: 21802 RVA: 0x0027BC80 File Offset: 0x00279E80
	private void DMAOHJDKMNN()
	{
		SteamManager.NNFCGADDAHL();
		this.panelProcessing.SetActive(true);
	}

	// Token: 0x0600552B RID: 21803 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CDLDCKAHLHC()
	{
	}

	// Token: 0x0600552C RID: 21804 RVA: 0x0027BB66 File Offset: 0x00279D66
	private IEnumerator OHMDIKBBLNB(int BCMLHBJFCCM)
	{
		this.panelProcessing.SetActive(true);
		this.DKLAMJMFEOC = true;
		SteamApps.GetCurrentGameLanguage();
		long num = 0L;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI;
		}
		string url = string.Format("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", new object[]
		{
			SteamUser.GetSteamID(),
			BCMLHBJFCCM,
			JNBICAJIJMM.IKGFHGKKCPG.GLPAPGLHOFF.JFGKIGAACHI,
			num
		});
		www = new WWW(url);
		yield return www;
		if (www.isDone)
		{
			new BNOOIOKIFJC.DIGGOHPGCNN(www.text);
			if (www.text.Trim() != "result=OK")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error:" + www.text);
			}
		}
		else
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error via request");
			Debug.LogError("Error via pay request");
		}
		this.DKLAMJMFEOC = false;
		this.panelProcessing.SetActive(false);
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x0600552D RID: 21805 RVA: 0x0027BE1F File Offset: 0x0027A01F
	public void ONJNEKJNHII(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("Heart Attack");
			return;
		}
		if (SteamManager.PGAALOOPLCE() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.IPOLHINDGML(JBGLPPHDMCK));
		}
	}

	// Token: 0x0600552E RID: 21806 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PFNOEACNHON()
	{
	}

	// Token: 0x0600552F RID: 21807 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ACLNFGPOHBF()
	{
	}

	// Token: 0x06005530 RID: 21808 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AIAMIFEPALP()
	{
	}

	// Token: 0x06005531 RID: 21809 RVA: 0x0027BE4C File Offset: 0x0027A04C
	private void PNJHMJNFPLP()
	{
		SteamManager.KLPAEPHIOAJ();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005532 RID: 21810 RVA: 0x0027BE60 File Offset: 0x0027A060
	private void HDGNIHBIEDG()
	{
		SteamManager.LCKFPOLOJJH();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005533 RID: 21811 RVA: 0x0027BD84 File Offset: 0x00279F84
	private void BMNJGPIPKLL()
	{
		SteamManager.PGAALOOPLCE();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005534 RID: 21812 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FKHAKIKPFFO()
	{
	}

	// Token: 0x06005535 RID: 21813 RVA: 0x0027BE74 File Offset: 0x0027A074
	public void NLPIKEIJKID(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("WeaponRun");
			return;
		}
		if (SteamManager.OIPNMDCOJMD() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.OHMDIKBBLNB(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005536 RID: 21814 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LBBPCGCMMKF()
	{
	}

	// Token: 0x06005537 RID: 21815 RVA: 0x0027BEA1 File Offset: 0x0027A0A1
	public void DKMHJHOJEMA(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("MotorbikeShootRight");
			return;
		}
		if (SteamManager.KLPAEPHIOAJ() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.BHFPFEABMDD(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005538 RID: 21816 RVA: 0x0027BECE File Offset: 0x0027A0CE
	public void GPHMLFAIONH(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("UnityEngine.Color");
			return;
		}
		if (SteamManager.OIPNMDCOJMD() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.IIEOIJJEBGE(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005539 RID: 21817 RVA: 0x0027BEFB File Offset: 0x0027A0FB
	public void NMMDMKCNEBE(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("ShootRaycastModule");
			return;
		}
		if (SteamManager.CJBDAMIDAOE() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.IIEOIJJEBGE(JBGLPPHDMCK));
		}
	}

	// Token: 0x0600553A RID: 21818 RVA: 0x0027BAFB File Offset: 0x00279CFB
	private IEnumerator MDAGFCLKONK(int BCMLHBJFCCM)
	{
		ShopScript.FPKMJFPILJC fpkmjfpiljc = new ShopScript.FPKMJFPILJC(1);
		fpkmjfpiljc.AENJLLPLILM = this;
		fpkmjfpiljc.BCMLHBJFCCM = BCMLHBJFCCM;
		return fpkmjfpiljc;
	}

	// Token: 0x0600553B RID: 21819 RVA: 0x0027BD02 File Offset: 0x00279F02
	private void CJNBMPCNKHP()
	{
		SteamManager.NIAFGBPDDEA();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x0600553C RID: 21820 RVA: 0x0027BF28 File Offset: 0x0027A128
	private void BBFPILBIMKC()
	{
		bool initialized = SteamManager.FPAKOLIPIND;
		this.panelProcessing.SetActive(true);
	}

	// Token: 0x0600553D RID: 21821 RVA: 0x0027BD43 File Offset: 0x00279F43
	private void FGJCIEDDFGN()
	{
		SteamManager.JBKCBLGNLLG();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x0600553E RID: 21822 RVA: 0x0027BF3C File Offset: 0x0027A13C
	public void IGDNHJCBNAO(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("FrontKick");
			return;
		}
		if (SteamManager.GAEJKDJCOEH() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.EMKNHDCLONO(JBGLPPHDMCK));
		}
	}

	// Token: 0x0600553F RID: 21823 RVA: 0x0027BF69 File Offset: 0x0027A169
	public void HJAHPNMHMJD(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("_ReflectionTexture1");
			return;
		}
		if (SteamManager.FPAKOLIPIND && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.PIOMLFLOMMB(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005540 RID: 21824 RVA: 0x0027BF96 File Offset: 0x0027A196
	public void CANBBHMFFGJ(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("_TrStartYou.ogg");
			return;
		}
		if (SteamManager.GHHNBKFIFOC() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.FIEDHMBEJGM(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005541 RID: 21825 RVA: 0x0027BFC3 File Offset: 0x0027A1C3
	private void FODDAMMNECI()
	{
		SteamManager.GHHNBKFIFOC();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005542 RID: 21826 RVA: 0x0027BFD7 File Offset: 0x0027A1D7
	private void ELADFDNPOOI()
	{
		SteamManager.GAEJKDJCOEH();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005543 RID: 21827 RVA: 0x0027BFC3 File Offset: 0x0027A1C3
	private void EHDPACPIBNF()
	{
		SteamManager.GHHNBKFIFOC();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005544 RID: 21828 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AGKMAOBNCDC()
	{
	}

	// Token: 0x06005545 RID: 21829 RVA: 0x0027BAFB File Offset: 0x00279CFB
	private IEnumerator BJINBDNFKJC(int BCMLHBJFCCM)
	{
		ShopScript.FPKMJFPILJC fpkmjfpiljc = new ShopScript.FPKMJFPILJC(1);
		fpkmjfpiljc.AENJLLPLILM = this;
		fpkmjfpiljc.BCMLHBJFCCM = BCMLHBJFCCM;
		return fpkmjfpiljc;
	}

	// Token: 0x06005546 RID: 21830 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DFFOEGHGPGP()
	{
	}

	// Token: 0x06005547 RID: 21831 RVA: 0x0027BFEB File Offset: 0x0027A1EB
	private void OPNPODKLOJK()
	{
		SteamManager.OIPNMDCOJMD();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005548 RID: 21832 RVA: 0x0027BAFB File Offset: 0x00279CFB
	private IEnumerator FNEDONMBMHF(int BCMLHBJFCCM)
	{
		ShopScript.FPKMJFPILJC fpkmjfpiljc = new ShopScript.FPKMJFPILJC(1);
		fpkmjfpiljc.AENJLLPLILM = this;
		fpkmjfpiljc.BCMLHBJFCCM = BCMLHBJFCCM;
		return fpkmjfpiljc;
	}

	// Token: 0x06005549 RID: 21833 RVA: 0x0027BFFF File Offset: 0x0027A1FF
	public void tovarClick(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("http://af-2.ru/?q=store");
			return;
		}
		if (SteamManager.FPAKOLIPIND && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.GMFLMFIKFPF(JBGLPPHDMCK));
		}
	}

	// Token: 0x0600554B RID: 21835 RVA: 0x0027C02C File Offset: 0x0027A22C
	public void NFOICOKJLKJ(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("StaffAttack");
			return;
		}
		if (SteamManager.MFDPJMKMHNG() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.IIEOIJJEBGE(JBGLPPHDMCK));
		}
	}

	// Token: 0x0600554C RID: 21836 RVA: 0x0027BB66 File Offset: 0x00279D66
	private IEnumerator HPHABIPHJDE(int BCMLHBJFCCM)
	{
		this.panelProcessing.SetActive(true);
		this.DKLAMJMFEOC = true;
		SteamApps.GetCurrentGameLanguage();
		long num = 0L;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI;
		}
		string url = string.Format("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", new object[]
		{
			SteamUser.GetSteamID(),
			BCMLHBJFCCM,
			JNBICAJIJMM.IKGFHGKKCPG.GLPAPGLHOFF.JFGKIGAACHI,
			num
		});
		www = new WWW(url);
		yield return www;
		if (www.isDone)
		{
			new BNOOIOKIFJC.DIGGOHPGCNN(www.text);
			if (www.text.Trim() != "result=OK")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error:" + www.text);
			}
		}
		else
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error via request");
			Debug.LogError("Error via pay request");
		}
		this.DKLAMJMFEOC = false;
		this.panelProcessing.SetActive(false);
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x0600554D RID: 21837 RVA: 0x0027BB11 File Offset: 0x00279D11
	private void KFGKKLAKFGH()
	{
		bool initialized = SteamManager.FPAKOLIPIND;
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x0600554E RID: 21838 RVA: 0x0027C059 File Offset: 0x0027A259
	private void FNBGGJJLIGG()
	{
		SteamManager.PGAALOOPLCE();
		this.panelProcessing.SetActive(true);
	}

	// Token: 0x0600554F RID: 21839 RVA: 0x0027C06D File Offset: 0x0027A26D
	public void EHIKOBANNOG(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("");
			return;
		}
		if (SteamManager.PGAALOOPLCE() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.OHMDIKBBLNB(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005550 RID: 21840 RVA: 0x0027C09A File Offset: 0x0027A29A
	public void OEDOIMIMFFI(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("adjust");
			return;
		}
		if (SteamManager.GAEJKDJCOEH() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.CJFABPPBJMM(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005551 RID: 21841 RVA: 0x0027C0C7 File Offset: 0x0027A2C7
	public void JENFEDHMOIG(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("WATER_SIMPLE");
			return;
		}
		if (SteamManager.NNFCGADDAHL() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.NJKGHJKKECA(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005552 RID: 21842 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OKMAHGAAMHA()
	{
	}

	// Token: 0x06005553 RID: 21843 RVA: 0x0027C0F4 File Offset: 0x0027A2F4
	public void BNGIECHJNFA(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("SPECIAL");
			return;
		}
		if (SteamManager.HFCCLHMGOKA() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.KJECLBCKFBP(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005554 RID: 21844 RVA: 0x0027C121 File Offset: 0x0027A321
	private void FDBNPLCPFJB()
	{
		SteamManager.FHGDEIGKKIE();
		this.panelProcessing.SetActive(true);
	}

	// Token: 0x06005555 RID: 21845 RVA: 0x0027BC80 File Offset: 0x00279E80
	private void MAGJOJDOGKH()
	{
		SteamManager.NNFCGADDAHL();
		this.panelProcessing.SetActive(true);
	}

	// Token: 0x06005556 RID: 21846 RVA: 0x0027BB66 File Offset: 0x00279D66
	private IEnumerator IKLDBOCAPIF(int BCMLHBJFCCM)
	{
		this.panelProcessing.SetActive(true);
		this.DKLAMJMFEOC = true;
		SteamApps.GetCurrentGameLanguage();
		long num = 0L;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI;
		}
		string url = string.Format("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", new object[]
		{
			SteamUser.GetSteamID(),
			BCMLHBJFCCM,
			JNBICAJIJMM.IKGFHGKKCPG.GLPAPGLHOFF.JFGKIGAACHI,
			num
		});
		www = new WWW(url);
		yield return www;
		if (www.isDone)
		{
			new BNOOIOKIFJC.DIGGOHPGCNN(www.text);
			if (www.text.Trim() != "result=OK")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error:" + www.text);
			}
		}
		else
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error via request");
			Debug.LogError("Error via pay request");
		}
		this.DKLAMJMFEOC = false;
		this.panelProcessing.SetActive(false);
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06005557 RID: 21847 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DIAIKCBANBK()
	{
	}

	// Token: 0x06005558 RID: 21848 RVA: 0x0027BD02 File Offset: 0x00279F02
	private void FFIGGPHAIBP()
	{
		SteamManager.NIAFGBPDDEA();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005559 RID: 21849 RVA: 0x0027BAFB File Offset: 0x00279CFB
	private IEnumerator KJECLBCKFBP(int BCMLHBJFCCM)
	{
		ShopScript.FPKMJFPILJC fpkmjfpiljc = new ShopScript.FPKMJFPILJC(1);
		fpkmjfpiljc.AENJLLPLILM = this;
		fpkmjfpiljc.BCMLHBJFCCM = BCMLHBJFCCM;
		return fpkmjfpiljc;
	}

	// Token: 0x0600555A RID: 21850 RVA: 0x0027C135 File Offset: 0x0027A335
	private void GMOACLEBHAM()
	{
		SteamManager.HFCCLHMGOKA();
		this.panelProcessing.SetActive(true);
	}

	// Token: 0x0600555B RID: 21851 RVA: 0x0027C149 File Offset: 0x0027A349
	private void CKIGGCAHAFD()
	{
		SteamManager.LGPCPFGMOGJ();
		this.panelProcessing.SetActive(true);
	}

	// Token: 0x0600555C RID: 21852 RVA: 0x0027C15D File Offset: 0x0027A35D
	private void AOCDDBNBADJ()
	{
		SteamManager.EPDLLLGNGFO();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x0600555D RID: 21853 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KLFPOILLKDF()
	{
	}

	// Token: 0x0600555E RID: 21854 RVA: 0x0027BAFB File Offset: 0x00279CFB
	private IEnumerator NJKGHJKKECA(int BCMLHBJFCCM)
	{
		ShopScript.FPKMJFPILJC fpkmjfpiljc = new ShopScript.FPKMJFPILJC(1);
		fpkmjfpiljc.AENJLLPLILM = this;
		fpkmjfpiljc.BCMLHBJFCCM = BCMLHBJFCCM;
		return fpkmjfpiljc;
	}

	// Token: 0x0600555F RID: 21855 RVA: 0x0027BB66 File Offset: 0x00279D66
	private IEnumerator IIEOIJJEBGE(int BCMLHBJFCCM)
	{
		this.panelProcessing.SetActive(true);
		this.DKLAMJMFEOC = true;
		SteamApps.GetCurrentGameLanguage();
		long num = 0L;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI;
		}
		string url = string.Format("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", new object[]
		{
			SteamUser.GetSteamID(),
			BCMLHBJFCCM,
			JNBICAJIJMM.IKGFHGKKCPG.GLPAPGLHOFF.JFGKIGAACHI,
			num
		});
		www = new WWW(url);
		yield return www;
		if (www.isDone)
		{
			new BNOOIOKIFJC.DIGGOHPGCNN(www.text);
			if (www.text.Trim() != "result=OK")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error:" + www.text);
			}
		}
		else
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error via request");
			Debug.LogError("Error via pay request");
		}
		this.DKLAMJMFEOC = false;
		this.panelProcessing.SetActive(false);
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06005560 RID: 21856 RVA: 0x0027BB11 File Offset: 0x00279D11
	private void FIJKDFIMELM()
	{
		bool initialized = SteamManager.FPAKOLIPIND;
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005561 RID: 21857 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LACNPNKHCAA()
	{
	}

	// Token: 0x06005562 RID: 21858 RVA: 0x0027C149 File Offset: 0x0027A349
	private void IIKDDILLGLF()
	{
		SteamManager.LGPCPFGMOGJ();
		this.panelProcessing.SetActive(true);
	}

	// Token: 0x06005563 RID: 21859 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BIGPMMGBPJC()
	{
	}

	// Token: 0x06005564 RID: 21860 RVA: 0x0027BB66 File Offset: 0x00279D66
	private IEnumerator IPOLHINDGML(int BCMLHBJFCCM)
	{
		this.panelProcessing.SetActive(true);
		this.DKLAMJMFEOC = true;
		SteamApps.GetCurrentGameLanguage();
		long num = 0L;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI;
		}
		string url = string.Format("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", new object[]
		{
			SteamUser.GetSteamID(),
			BCMLHBJFCCM,
			JNBICAJIJMM.IKGFHGKKCPG.GLPAPGLHOFF.JFGKIGAACHI,
			num
		});
		www = new WWW(url);
		yield return www;
		if (www.isDone)
		{
			new BNOOIOKIFJC.DIGGOHPGCNN(www.text);
			if (www.text.Trim() != "result=OK")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error:" + www.text);
			}
		}
		else
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error via request");
			Debug.LogError("Error via pay request");
		}
		this.DKLAMJMFEOC = false;
		this.panelProcessing.SetActive(false);
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06005565 RID: 21861 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AKLFCMNCPKL()
	{
	}

	// Token: 0x06005566 RID: 21862 RVA: 0x0027BE4C File Offset: 0x0027A04C
	private void NMGCNEELAFM()
	{
		SteamManager.KLPAEPHIOAJ();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005567 RID: 21863 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GGGKKEAABKK()
	{
	}

	// Token: 0x06005568 RID: 21864 RVA: 0x0027BAFB File Offset: 0x00279CFB
	private IEnumerator BHFPFEABMDD(int BCMLHBJFCCM)
	{
		ShopScript.FPKMJFPILJC fpkmjfpiljc = new ShopScript.FPKMJFPILJC(1);
		fpkmjfpiljc.AENJLLPLILM = this;
		fpkmjfpiljc.BCMLHBJFCCM = BCMLHBJFCCM;
		return fpkmjfpiljc;
	}

	// Token: 0x06005569 RID: 21865 RVA: 0x0027BE4C File Offset: 0x0027A04C
	private void DGDGMFDPEHO()
	{
		SteamManager.KLPAEPHIOAJ();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x0600556A RID: 21866 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JPHLMNIMDHH()
	{
	}

	// Token: 0x0600556B RID: 21867 RVA: 0x0027C171 File Offset: 0x0027A371
	public void ELIAMLKHDPI(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("WoodSaw");
			return;
		}
		if (SteamManager.OIPNMDCOJMD() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.GMFLMFIKFPF(JBGLPPHDMCK));
		}
	}

	// Token: 0x0600556C RID: 21868 RVA: 0x0027C19E File Offset: 0x0027A39E
	public void DAADPOHFDKB(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("");
			return;
		}
		if (SteamManager.GAEJKDJCOEH() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.EMCIGMHPHLN(JBGLPPHDMCK));
		}
	}

	// Token: 0x0600556D RID: 21869 RVA: 0x0027C1CB File Offset: 0x0027A3CB
	public void BJGAKOCHIIC(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("_NoiseAmount");
			return;
		}
		if (SteamManager.FPAKOLIPIND && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.PDALFGKMFND(JBGLPPHDMCK));
		}
	}

	// Token: 0x0600556E RID: 21870 RVA: 0x0027C1F8 File Offset: 0x0027A3F8
	private void ELCNJDNCAEP()
	{
		SteamManager.OIPNMDCOJMD();
		this.panelProcessing.SetActive(true);
	}

	// Token: 0x0600556F RID: 21871 RVA: 0x0027C20C File Offset: 0x0027A40C
	public void EKADGPBBDCM(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("_Tile4RT");
			return;
		}
		if (SteamManager.FNNHOLIBGJH() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.OCJNDKMKFBM(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005570 RID: 21872 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ECCNNCMJEGJ()
	{
	}

	// Token: 0x06005571 RID: 21873 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EMHGNEMIGII()
	{
	}

	// Token: 0x06005572 RID: 21874 RVA: 0x0027C135 File Offset: 0x0027A335
	private void KDCOHILDJJO()
	{
		SteamManager.HFCCLHMGOKA();
		this.panelProcessing.SetActive(true);
	}

	// Token: 0x06005573 RID: 21875 RVA: 0x0027BC6C File Offset: 0x00279E6C
	private void DGGMJCMLLED()
	{
		SteamManager.NGEACBIHBOP();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005574 RID: 21876 RVA: 0x0027BAFB File Offset: 0x00279CFB
	private IEnumerator PDALFGKMFND(int BCMLHBJFCCM)
	{
		ShopScript.FPKMJFPILJC fpkmjfpiljc = new ShopScript.FPKMJFPILJC(1);
		fpkmjfpiljc.AENJLLPLILM = this;
		fpkmjfpiljc.BCMLHBJFCCM = BCMLHBJFCCM;
		return fpkmjfpiljc;
	}

	// Token: 0x06005575 RID: 21877 RVA: 0x0027C239 File Offset: 0x0027A439
	public void HPJPKGBBODP(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("crft_crft");
			return;
		}
		if (SteamManager.CJBDAMIDAOE() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.OIEKECLLIMO(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005576 RID: 21878 RVA: 0x0027BB66 File Offset: 0x00279D66
	private IEnumerator OPPKFDDOPGP(int BCMLHBJFCCM)
	{
		this.panelProcessing.SetActive(true);
		this.DKLAMJMFEOC = true;
		SteamApps.GetCurrentGameLanguage();
		long num = 0L;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI;
		}
		string url = string.Format("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", new object[]
		{
			SteamUser.GetSteamID(),
			BCMLHBJFCCM,
			JNBICAJIJMM.IKGFHGKKCPG.GLPAPGLHOFF.JFGKIGAACHI,
			num
		});
		www = new WWW(url);
		yield return www;
		if (www.isDone)
		{
			new BNOOIOKIFJC.DIGGOHPGCNN(www.text);
			if (www.text.Trim() != "result=OK")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error:" + www.text);
			}
		}
		else
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error via request");
			Debug.LogError("Error via pay request");
		}
		this.DKLAMJMFEOC = false;
		this.panelProcessing.SetActive(false);
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06005577 RID: 21879 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BBFCMCAFOMH()
	{
	}

	// Token: 0x06005578 RID: 21880 RVA: 0x0027BAFB File Offset: 0x00279CFB
	private IEnumerator BNICDEPHOHC(int BCMLHBJFCCM)
	{
		ShopScript.FPKMJFPILJC fpkmjfpiljc = new ShopScript.FPKMJFPILJC(1);
		fpkmjfpiljc.AENJLLPLILM = this;
		fpkmjfpiljc.BCMLHBJFCCM = BCMLHBJFCCM;
		return fpkmjfpiljc;
	}

	// Token: 0x06005579 RID: 21881 RVA: 0x0027C266 File Offset: 0x0027A466
	public void JMBPKEMNELG(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("<<");
			return;
		}
		if (SteamManager.LGPCPFGMOGJ() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.BHFPFEABMDD(JBGLPPHDMCK));
		}
	}

	// Token: 0x0600557A RID: 21882 RVA: 0x0027BAFB File Offset: 0x00279CFB
	private IEnumerator JIHBPPCBAMC(int BCMLHBJFCCM)
	{
		ShopScript.FPKMJFPILJC fpkmjfpiljc = new ShopScript.FPKMJFPILJC(1);
		fpkmjfpiljc.AENJLLPLILM = this;
		fpkmjfpiljc.BCMLHBJFCCM = BCMLHBJFCCM;
		return fpkmjfpiljc;
	}

	// Token: 0x0600557B RID: 21883 RVA: 0x0027BAFB File Offset: 0x00279CFB
	private IEnumerator AONDAOHHPKE(int BCMLHBJFCCM)
	{
		ShopScript.FPKMJFPILJC fpkmjfpiljc = new ShopScript.FPKMJFPILJC(1);
		fpkmjfpiljc.AENJLLPLILM = this;
		fpkmjfpiljc.BCMLHBJFCCM = BCMLHBJFCCM;
		return fpkmjfpiljc;
	}

	// Token: 0x0600557C RID: 21884 RVA: 0x0027C293 File Offset: 0x0027A493
	public void OGCMMGCFBNI(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("<color='#100000'>{0} {1}</color>");
			return;
		}
		if (SteamManager.FNNHOLIBGJH() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.BNICDEPHOHC(JBGLPPHDMCK));
		}
	}

	// Token: 0x0600557D RID: 21885 RVA: 0x0027BB66 File Offset: 0x00279D66
	private IEnumerator FKMKMGDJCON(int BCMLHBJFCCM)
	{
		this.panelProcessing.SetActive(true);
		this.DKLAMJMFEOC = true;
		SteamApps.GetCurrentGameLanguage();
		long num = 0L;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI;
		}
		string url = string.Format("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", new object[]
		{
			SteamUser.GetSteamID(),
			BCMLHBJFCCM,
			JNBICAJIJMM.IKGFHGKKCPG.GLPAPGLHOFF.JFGKIGAACHI,
			num
		});
		www = new WWW(url);
		yield return www;
		if (www.isDone)
		{
			new BNOOIOKIFJC.DIGGOHPGCNN(www.text);
			if (www.text.Trim() != "result=OK")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error:" + www.text);
			}
		}
		else
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error via request");
			Debug.LogError("Error via pay request");
		}
		this.DKLAMJMFEOC = false;
		this.panelProcessing.SetActive(false);
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x0600557E RID: 21886 RVA: 0x0027C2C0 File Offset: 0x0027A4C0
	public void LIAGNCFMDEL(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("WeaponRunBackward");
			return;
		}
		if (SteamManager.PJMKPOFDGCK() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.FIEDHMBEJGM(JBGLPPHDMCK));
		}
	}

	// Token: 0x0600557F RID: 21887 RVA: 0x0027BB66 File Offset: 0x00279D66
	private IEnumerator PIOMLFLOMMB(int BCMLHBJFCCM)
	{
		this.panelProcessing.SetActive(true);
		this.DKLAMJMFEOC = true;
		SteamApps.GetCurrentGameLanguage();
		long num = 0L;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI;
		}
		string url = string.Format("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", new object[]
		{
			SteamUser.GetSteamID(),
			BCMLHBJFCCM,
			JNBICAJIJMM.IKGFHGKKCPG.GLPAPGLHOFF.JFGKIGAACHI,
			num
		});
		www = new WWW(url);
		yield return www;
		if (www.isDone)
		{
			new BNOOIOKIFJC.DIGGOHPGCNN(www.text);
			if (www.text.Trim() != "result=OK")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error:" + www.text);
			}
		}
		else
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error via request");
			Debug.LogError("Error via pay request");
		}
		this.DKLAMJMFEOC = false;
		this.panelProcessing.SetActive(false);
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06005580 RID: 21888 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EDEODHDFANE()
	{
	}

	// Token: 0x06005581 RID: 21889 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LBGKAMLLACN()
	{
	}

	// Token: 0x06005582 RID: 21890 RVA: 0x0027C2ED File Offset: 0x0027A4ED
	public void HFOLACFODKA(int JBGLPPHDMCK)
	{
		if (JBGLPPHDMCK == 0)
		{
			Application.OpenURL("isRodInWater");
			return;
		}
		if (SteamManager.GAEJKDJCOEH() && !this.DKLAMJMFEOC)
		{
			base.StartCoroutine(this.FNEDONMBMHF(JBGLPPHDMCK));
		}
	}

	// Token: 0x06005583 RID: 21891 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PNBGJBMJLFM()
	{
	}

	// Token: 0x06005584 RID: 21892 RVA: 0x0027BAFB File Offset: 0x00279CFB
	private IEnumerator DJJEAJIANMO(int BCMLHBJFCCM)
	{
		ShopScript.FPKMJFPILJC fpkmjfpiljc = new ShopScript.FPKMJFPILJC(1);
		fpkmjfpiljc.AENJLLPLILM = this;
		fpkmjfpiljc.BCMLHBJFCCM = BCMLHBJFCCM;
		return fpkmjfpiljc;
	}

	// Token: 0x06005585 RID: 21893 RVA: 0x0027BB66 File Offset: 0x00279D66
	private IEnumerator GMFLMFIKFPF(int BCMLHBJFCCM)
	{
		this.panelProcessing.SetActive(true);
		this.DKLAMJMFEOC = true;
		SteamApps.GetCurrentGameLanguage();
		long num = 0L;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI;
		}
		string url = string.Format("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", new object[]
		{
			SteamUser.GetSteamID(),
			BCMLHBJFCCM,
			JNBICAJIJMM.IKGFHGKKCPG.GLPAPGLHOFF.JFGKIGAACHI,
			num
		});
		www = new WWW(url);
		yield return www;
		if (www.isDone)
		{
			new BNOOIOKIFJC.DIGGOHPGCNN(www.text);
			if (www.text.Trim() != "result=OK")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error:" + www.text);
			}
		}
		else
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error via request");
			Debug.LogError("Error via pay request");
		}
		this.DKLAMJMFEOC = false;
		this.panelProcessing.SetActive(false);
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06005586 RID: 21894 RVA: 0x0027BFEB File Offset: 0x0027A1EB
	private void EGDBNKCJOCD()
	{
		SteamManager.OIPNMDCOJMD();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005587 RID: 21895 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PJOKLGLNDHD()
	{
	}

	// Token: 0x06005588 RID: 21896 RVA: 0x0027BFD7 File Offset: 0x0027A1D7
	private void CGNGBFFGGBP()
	{
		SteamManager.GAEJKDJCOEH();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005589 RID: 21897 RVA: 0x0027BB66 File Offset: 0x00279D66
	private IEnumerator JKJHMNHAJOI(int BCMLHBJFCCM)
	{
		this.panelProcessing.SetActive(true);
		this.DKLAMJMFEOC = true;
		SteamApps.GetCurrentGameLanguage();
		long num = 0L;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI;
		}
		string url = string.Format("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", new object[]
		{
			SteamUser.GetSteamID(),
			BCMLHBJFCCM,
			JNBICAJIJMM.IKGFHGKKCPG.GLPAPGLHOFF.JFGKIGAACHI,
			num
		});
		www = new WWW(url);
		yield return www;
		if (www.isDone)
		{
			new BNOOIOKIFJC.DIGGOHPGCNN(www.text);
			if (www.text.Trim() != "result=OK")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error:" + www.text);
			}
		}
		else
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error via request");
			Debug.LogError("Error via pay request");
		}
		this.DKLAMJMFEOC = false;
		this.panelProcessing.SetActive(false);
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x0600558A RID: 21898 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LEHBKPPGHPC()
	{
	}

	// Token: 0x0600558B RID: 21899 RVA: 0x0027BC6C File Offset: 0x00279E6C
	private void JPHBPEAMNHB()
	{
		SteamManager.NGEACBIHBOP();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x0600558C RID: 21900 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OLGDMBDGLAN()
	{
	}

	// Token: 0x0600558D RID: 21901 RVA: 0x0027BFD7 File Offset: 0x0027A1D7
	private void NCALLFHEAGJ()
	{
		SteamManager.GAEJKDJCOEH();
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x0600558E RID: 21902 RVA: 0x0027BB66 File Offset: 0x00279D66
	private IEnumerator FIEDHMBEJGM(int BCMLHBJFCCM)
	{
		this.panelProcessing.SetActive(true);
		this.DKLAMJMFEOC = true;
		SteamApps.GetCurrentGameLanguage();
		long num = 0L;
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH != null)
		{
			num = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LPFKFNLHGBI;
		}
		string url = string.Format("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}", new object[]
		{
			SteamUser.GetSteamID(),
			BCMLHBJFCCM,
			JNBICAJIJMM.IKGFHGKKCPG.GLPAPGLHOFF.JFGKIGAACHI,
			num
		});
		www = new WWW(url);
		yield return www;
		if (www.isDone)
		{
			new BNOOIOKIFJC.DIGGOHPGCNN(www.text);
			if (www.text.Trim() != "result=OK")
			{
				JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error:" + www.text);
			}
		}
		else
		{
			JDCEFOFMGHB.IKGFHGKKCPG.BEIDJANKEFD("Error", "SteamPay error via request");
			Debug.LogError("Error via pay request");
		}
		this.DKLAMJMFEOC = false;
		this.panelProcessing.SetActive(false);
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x0600558F RID: 21903 RVA: 0x0027C31A File Offset: 0x0027A51A
	private void FCCAIANLEFE()
	{
		SteamManager.GHHNBKFIFOC();
		this.panelProcessing.SetActive(true);
	}

	// Token: 0x06005590 RID: 21904 RVA: 0x0027BB11 File Offset: 0x00279D11
	private void BJHGPFGBFKF()
	{
		bool initialized = SteamManager.FPAKOLIPIND;
		this.panelProcessing.SetActive(false);
	}

	// Token: 0x06005591 RID: 21905 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OJGOLGHBEPM()
	{
	}

	// Token: 0x06005592 RID: 21906 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AJCHHNKFOHO()
	{
	}

	// Token: 0x04000CCC RID: 3276
	public GameObject panelProcessing;

	// Token: 0x04000CCD RID: 3277
	private bool DKLAMJMFEOC;

	// Token: 0x04000CCE RID: 3278
	public static string baseurl = "http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}";

	// Token: 0x04000CCF RID: 3279
	public static string finalurl = "http://af-2.ru/pay/finalize.php?orderid={0}&appid={1}&metod={2}";
}
