using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x020001F2 RID: 498
public class LocBaseManager : MonoBehaviour
{
	// Token: 0x06007394 RID: 29588 RVA: 0x003720FB File Offset: 0x003702FB
	private void LHHFHDNBKKC()
	{
		if (LocBaseManager.AGEHHNOKBGK != null && LocBaseManager.AGEHHNOKBGK != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		LocBaseManager.AGEHHNOKBGK = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06007395 RID: 29589 RVA: 0x00372134 File Offset: 0x00370334
	private void FDOFPMGKEDI()
	{
		if (this.CLKBDNJIBIL == null)
		{
			return;
		}
		foreach (LocBaseManager.HHIFOAIHHNC hhifoaihhnc in this.ILMOOIGAFDL)
		{
			hhifoaihhnc(this.CLKBDNJIBIL.asset as GameObject);
		}
		this.ILMOOIGAFDL.Clear();
	}

	// Token: 0x06007396 RID: 29590 RVA: 0x003721A8 File Offset: 0x003703A8
	public void getLevel(int IAOHOFAMLEF, LocBaseManager.HHIFOAIHHNC MCPJBOAKCMK)
	{
		if (MCPJBOAKCMK != null && !this.ILMOOIGAFDL.Contains(MCPJBOAKCMK))
		{
			this.ILMOOIGAFDL.Add(MCPJBOAKCMK);
		}
		bool isEditor = Application.isEditor;
		if (this.DDHPOGIOGPJ != IAOHOFAMLEF)
		{
			if (this.MKBBJLCHDPJ != null)
			{
				this.MKBBJLCHDPJ = null;
			}
			bool isEditor2 = Application.isEditor;
			this.JIPIPOLKPCF = string.Format("base_{0}", IAOHOFAMLEF);
			this.ALBOCLBFNNI = string.Format("bases/base_{0}", IAOHOFAMLEF);
			this.DDHPOGIOGPJ = IAOHOFAMLEF;
			this.isLoadDone = false;
			base.StartCoroutine(this.GDHFMBFNHEM());
			return;
		}
		if (!this.isLoadProcess)
		{
			if (this.isLoadDone)
			{
				this.AAJGHJABFPB();
				return;
			}
			Debug.LogError("Level loading error Level ID=" + IAOHOFAMLEF);
		}
	}

	// Token: 0x06007397 RID: 29591 RVA: 0x0037226A File Offset: 0x0037046A
	public LocBaseManager.JGNBBMJLDPM AKDMHOFIJMB(int MIEGPLMJJCJ)
	{
		if (!this.traveles.ContainsKey(MIEGPLMJJCJ))
		{
			return null;
		}
		return this.traveles[MIEGPLMJJCJ];
	}

	// Token: 0x06007398 RID: 29592 RVA: 0x00372288 File Offset: 0x00370488
	public static LocBaseManager NPIEJELJPIM()
	{
		return LocBaseManager.AGEHHNOKBGK;
	}

	// Token: 0x06007399 RID: 29593 RVA: 0x00372288 File Offset: 0x00370488
	public static LocBaseManager EDKKJNHDBPF()
	{
		return LocBaseManager.AGEHHNOKBGK;
	}

	// Token: 0x0600739A RID: 29594 RVA: 0x0037228F File Offset: 0x0037048F
	public void CFHPCOFFNCF(int NPHCOJCGGKN)
	{
		base.StartCoroutine(this.LGKCONLEEAA(NPHCOJCGGKN));
	}

	// Token: 0x0600739B RID: 29595 RVA: 0x003722A0 File Offset: 0x003704A0
	private void GAAKEHLFMEL()
	{
		if (this.CLKBDNJIBIL == null)
		{
			return;
		}
		foreach (LocBaseManager.HHIFOAIHHNC hhifoaihhnc in this.ILMOOIGAFDL)
		{
			hhifoaihhnc(this.CLKBDNJIBIL.asset as GameObject);
		}
		this.ILMOOIGAFDL.Clear();
	}

	// Token: 0x0600739C RID: 29596 RVA: 0x00372314 File Offset: 0x00370514
	private IEnumerator ICGKNKCCLFM(int EPGAKJIAEFM)
	{
		LocBaseManager.FDLPHKMCBIO fdlphkmcbio = new LocBaseManager.FDLPHKMCBIO(1);
		fdlphkmcbio.EPGAKJIAEFM = EPGAKJIAEFM;
		return fdlphkmcbio;
	}

	// Token: 0x0600739D RID: 29597 RVA: 0x00372323 File Offset: 0x00370523
	public void OFNNFNCBAGH(int NPHCOJCGGKN)
	{
		base.StartCoroutine(this.HAECIJLAOFK(NPHCOJCGGKN));
	}

	// Token: 0x0600739E RID: 29598 RVA: 0x00372334 File Offset: 0x00370534
	public float HNDKPIPGAML()
	{
		float num = 1900f;
		if (this.MKBBJLCHDPJ != null)
		{
			num = this.MKBBJLCHDPJ.progress;
		}
		if (this.isLoadDone)
		{
			num = 417f;
		}
		return num * 1676f;
	}

	// Token: 0x0600739F RID: 29599 RVA: 0x00372370 File Offset: 0x00370570
	private IEnumerator PJNFKEHNACE()
	{
		LocBaseManager.HCBBOMFJDJI hcbbomfjdji = new LocBaseManager.HCBBOMFJDJI(1);
		hcbbomfjdji.AENJLLPLILM = this;
		return hcbbomfjdji;
	}

	// Token: 0x060073A0 RID: 29600 RVA: 0x0037237F File Offset: 0x0037057F
	protected IEnumerator LLDJDJDGNNJ()
	{
		return new LocBaseManager.CHMLJNDOKEL(1);
	}

	// Token: 0x060073A1 RID: 29601 RVA: 0x00372288 File Offset: 0x00370488
	public static LocBaseManager FJLCHDGLMMK()
	{
		return LocBaseManager.AGEHHNOKBGK;
	}

	// Token: 0x060073A2 RID: 29602 RVA: 0x00372387 File Offset: 0x00370587
	public void BHIFHFHKHGP(int NPHCOJCGGKN)
	{
		base.StartCoroutine(this.FPIOPDDPKON(NPHCOJCGGKN));
	}

	// Token: 0x060073A3 RID: 29603 RVA: 0x0037226A File Offset: 0x0037046A
	public LocBaseManager.JGNBBMJLDPM CFLFMECOGNM(int MIEGPLMJJCJ)
	{
		if (!this.traveles.ContainsKey(MIEGPLMJJCJ))
		{
			return null;
		}
		return this.traveles[MIEGPLMJJCJ];
	}

	// Token: 0x060073A4 RID: 29604 RVA: 0x00372370 File Offset: 0x00370570
	private IEnumerator MMIGHKGJJHN()
	{
		LocBaseManager.HCBBOMFJDJI hcbbomfjdji = new LocBaseManager.HCBBOMFJDJI(1);
		hcbbomfjdji.AENJLLPLILM = this;
		return hcbbomfjdji;
	}

	// Token: 0x060073A5 RID: 29605 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FJGIBCHABIG()
	{
	}

	// Token: 0x060073A6 RID: 29606 RVA: 0x00372398 File Offset: 0x00370598
	private void CAFBLHNDLIJ()
	{
		if (this.CLKBDNJIBIL == null)
		{
			return;
		}
		foreach (LocBaseManager.HHIFOAIHHNC hhifoaihhnc in this.ILMOOIGAFDL)
		{
			hhifoaihhnc(this.CLKBDNJIBIL.asset as GameObject);
		}
		this.ILMOOIGAFDL.Clear();
	}

	// Token: 0x060073A7 RID: 29607 RVA: 0x0037240C File Offset: 0x0037060C
	private void AAJGHJABFPB()
	{
		if (this.CLKBDNJIBIL == null)
		{
			return;
		}
		foreach (LocBaseManager.HHIFOAIHHNC hhifoaihhnc in this.ILMOOIGAFDL)
		{
			hhifoaihhnc(this.CLKBDNJIBIL.asset as GameObject);
		}
		this.ILMOOIGAFDL.Clear();
	}

	// Token: 0x060073A8 RID: 29608 RVA: 0x00372480 File Offset: 0x00370680
	protected IEnumerator ECLNPIKKIEK()
	{
		yield return new WaitForSeconds(0.1f);
		yield break;
	}

	// Token: 0x060073A9 RID: 29609 RVA: 0x00372488 File Offset: 0x00370688
	public void PDMIMEDGCJK(int NPHCOJCGGKN)
	{
		base.StartCoroutine(this.OICHDCAKNFF(NPHCOJCGGKN));
	}

	// Token: 0x060073AA RID: 29610 RVA: 0x00372498 File Offset: 0x00370698
	private void JEFOKDMNAHN()
	{
		if (this.CLKBDNJIBIL == null)
		{
			return;
		}
		foreach (LocBaseManager.HHIFOAIHHNC hhifoaihhnc in this.ILMOOIGAFDL)
		{
			hhifoaihhnc(this.CLKBDNJIBIL.asset as GameObject);
		}
		this.ILMOOIGAFDL.Clear();
	}

	// Token: 0x060073AB RID: 29611 RVA: 0x0037228F File Offset: 0x0037048F
	public void LKKINMMIGCK(int NPHCOJCGGKN)
	{
		base.StartCoroutine(this.LGKCONLEEAA(NPHCOJCGGKN));
	}

	// Token: 0x060073AC RID: 29612 RVA: 0x0037250C File Offset: 0x0037070C
	public void GCADPKEAANA(HBPNMNGOFMA KADBECGIMPD)
	{
		this.traveles.Clear();
		while (!KADBECGIMPD.LILLHFLDMBH())
		{
			LocBaseManager.JGNBBMJLDPM jgnbbmjldpm = new LocBaseManager.JGNBBMJLDPM(KADBECGIMPD);
			this.traveles.Add(jgnbbmjldpm.PNEDPPPEFFG, jgnbbmjldpm);
			this.toGlobalMap.JLPFNMDEOGO((double)jgnbbmjldpm.PNEDPPPEFFG);
			this.toGlobalMap.NMKCBJKHBOH = (double)jgnbbmjldpm.OPCKECKICAI;
			this.globalMapTravel = jgnbbmjldpm.MOPJKJBPFDC;
		}
	}

	// Token: 0x060073AD RID: 29613 RVA: 0x00372577 File Offset: 0x00370777
	public void KBHGAJJLCOA(int NPHCOJCGGKN)
	{
		base.StartCoroutine(this.HGAJIKMLCJO(NPHCOJCGGKN));
	}

	// Token: 0x060073AE RID: 29614 RVA: 0x00022FCC File Offset: 0x000211CC
	private void GDIMBBBPIHI()
	{
	}

	// Token: 0x060073AF RID: 29615 RVA: 0x0037237F File Offset: 0x0037057F
	protected IEnumerator JDCJOKGPNMG()
	{
		return new LocBaseManager.CHMLJNDOKEL(1);
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x060073B0 RID: 29616 RVA: 0x00372288 File Offset: 0x00370488
	public static LocBaseManager IKGFHGKKCPG
	{
		get
		{
			return LocBaseManager.AGEHHNOKBGK;
		}
	}

	// Token: 0x060073B1 RID: 29617 RVA: 0x00372588 File Offset: 0x00370788
	private void DNKBOBCMNAJ()
	{
		if (this.CLKBDNJIBIL == null)
		{
			return;
		}
		foreach (LocBaseManager.HHIFOAIHHNC hhifoaihhnc in this.ILMOOIGAFDL)
		{
			hhifoaihhnc(this.CLKBDNJIBIL.asset as GameObject);
		}
		this.ILMOOIGAFDL.Clear();
	}

	// Token: 0x060073B2 RID: 29618 RVA: 0x003720FB File Offset: 0x003702FB
	private void KOJNOPBGPAM()
	{
		if (LocBaseManager.AGEHHNOKBGK != null && LocBaseManager.AGEHHNOKBGK != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		LocBaseManager.AGEHHNOKBGK = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060073B3 RID: 29619 RVA: 0x003725FC File Offset: 0x003707FC
	private void KFDPLLKMACB()
	{
		if (this.CLKBDNJIBIL == null)
		{
			return;
		}
		foreach (LocBaseManager.HHIFOAIHHNC hhifoaihhnc in this.ILMOOIGAFDL)
		{
			hhifoaihhnc(this.CLKBDNJIBIL.asset as GameObject);
		}
		this.ILMOOIGAFDL.Clear();
	}

	// Token: 0x060073B4 RID: 29620 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CAJLCEPLKJG()
	{
	}

	// Token: 0x060073B6 RID: 29622 RVA: 0x003720FB File Offset: 0x003702FB
	private void Awake()
	{
		if (LocBaseManager.AGEHHNOKBGK != null && LocBaseManager.AGEHHNOKBGK != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		LocBaseManager.AGEHHNOKBGK = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060073B7 RID: 29623 RVA: 0x003726B0 File Offset: 0x003708B0
	public float JCHONFBELLO()
	{
		float num = 1997f;
		if (this.MKBBJLCHDPJ != null)
		{
			num = this.MKBBJLCHDPJ.progress;
		}
		if (this.isLoadDone)
		{
			num = 382f;
		}
		return num * 934f;
	}

	// Token: 0x060073B8 RID: 29624 RVA: 0x003720FB File Offset: 0x003702FB
	private void AKGBDJDMOLC()
	{
		if (LocBaseManager.AGEHHNOKBGK != null && LocBaseManager.AGEHHNOKBGK != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		LocBaseManager.AGEHHNOKBGK = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060073B9 RID: 29625 RVA: 0x00372314 File Offset: 0x00370514
	private IEnumerator HGAJIKMLCJO(int EPGAKJIAEFM)
	{
		LocBaseManager.FDLPHKMCBIO fdlphkmcbio = new LocBaseManager.FDLPHKMCBIO(1);
		fdlphkmcbio.EPGAKJIAEFM = EPGAKJIAEFM;
		return fdlphkmcbio;
	}

	// Token: 0x060073BA RID: 29626 RVA: 0x003726EC File Offset: 0x003708EC
	public void KIOCMEBMLDC(int NPHCOJCGGKN)
	{
		base.StartCoroutine(this.EKLPOMCJOGB(NPHCOJCGGKN));
	}

	// Token: 0x060073BB RID: 29627 RVA: 0x003726FC File Offset: 0x003708FC
	private void ABDHMNGODNH()
	{
		if (this.CLKBDNJIBIL == null)
		{
			return;
		}
		foreach (LocBaseManager.HHIFOAIHHNC hhifoaihhnc in this.ILMOOIGAFDL)
		{
			hhifoaihhnc(this.CLKBDNJIBIL.asset as GameObject);
		}
		this.ILMOOIGAFDL.Clear();
	}

	// Token: 0x060073BC RID: 29628 RVA: 0x00372770 File Offset: 0x00370970
	private void MKNFNMMNCII()
	{
		if (this.CLKBDNJIBIL == null)
		{
			return;
		}
		foreach (LocBaseManager.HHIFOAIHHNC hhifoaihhnc in this.ILMOOIGAFDL)
		{
			hhifoaihhnc(this.CLKBDNJIBIL.asset as GameObject);
		}
		this.ILMOOIGAFDL.Clear();
	}

	// Token: 0x060073BD RID: 29629 RVA: 0x003727E4 File Offset: 0x003709E4
	private IEnumerator DDNDDPEKNBD()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
		}
		this.isLoadProcess = true;
		this.isLoadDone = false;
		this.isInstanceProcess = false;
		long num = (long)Environment.TickCount;
		string text = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.ALBOCLBFNNI);
		this.MKBBJLCHDPJ = AssetBundle.LoadFromFileAsync(text);
		Debug.Log("********* Start load Level " + this.JIPIPOLKPCF + " from " + text);
		yield return this.MKBBJLCHDPJ;
		AssetBundle assetBundle = this.MKBBJLCHDPJ.assetBundle;
		if (assetBundle == null)
		{
			Debug.LogError("Failed to load AssetBundle " + text);
			yield break;
		}
		this.CLKBDNJIBIL = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return this.CLKBDNJIBIL;
		NJMHLCGIAJI.IKGFHGKKCPG.NADAJMDGNAI();
		Debug.Log("********* LoadAllAssets via ASYNC loadLevelTime=" + (float)((long)Environment.TickCount - num) / 1000f);
		this.isLoadDone = true;
		num = (long)Environment.TickCount;
		try
		{
			this.AAJGHJABFPB();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		Debug.Log("********* End INSTANIATE Level  instLevelTime=" + (float)((long)Environment.TickCount - num) / 1000f);
		assetBundle.Unload(false);
		this.isLoadProcess = false;
		try
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AGABLNAAFHA();
			yield break;
		}
		catch (Exception message2)
		{
			Debug.LogError(message2);
			yield break;
		}
		yield break;
	}

	// Token: 0x060073BE RID: 29630 RVA: 0x003727E4 File Offset: 0x003709E4
	private IEnumerator GDHFMBFNHEM()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
		}
		this.isLoadProcess = true;
		this.isLoadDone = false;
		this.isInstanceProcess = false;
		num = (long)Environment.TickCount;
		text = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.ALBOCLBFNNI);
		this.MKBBJLCHDPJ = AssetBundle.LoadFromFileAsync(text);
		Debug.Log("********* Start load Level " + this.JIPIPOLKPCF + " from " + text);
		yield return this.MKBBJLCHDPJ;
		assetBundle = this.MKBBJLCHDPJ.assetBundle;
		if (assetBundle == null)
		{
			Debug.LogError("Failed to load AssetBundle " + text);
			yield break;
		}
		this.CLKBDNJIBIL = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return this.CLKBDNJIBIL;
		NJMHLCGIAJI.IKGFHGKKCPG.NADAJMDGNAI();
		Debug.Log("********* LoadAllAssets via ASYNC loadLevelTime=" + (float)((long)Environment.TickCount - num) / 1000f);
		this.isLoadDone = true;
		num = (long)Environment.TickCount;
		try
		{
			this.AAJGHJABFPB();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		Debug.Log("********* End INSTANIATE Level  instLevelTime=" + (float)((long)Environment.TickCount - num) / 1000f);
		assetBundle.Unload(false);
		this.isLoadProcess = false;
		try
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AGABLNAAFHA();
			yield break;
		}
		catch (Exception message2)
		{
			Debug.LogError(message2);
			yield break;
		}
		yield break;
	}

	// Token: 0x060073BF RID: 29631 RVA: 0x00372370 File Offset: 0x00370570
	private IEnumerator CBJIDJFAGED()
	{
		LocBaseManager.HCBBOMFJDJI hcbbomfjdji = new LocBaseManager.HCBBOMFJDJI(1);
		hcbbomfjdji.AENJLLPLILM = this;
		return hcbbomfjdji;
	}

	// Token: 0x060073C0 RID: 29632 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DPPAAIJCFLC()
	{
	}

	// Token: 0x060073C1 RID: 29633 RVA: 0x00372370 File Offset: 0x00370570
	private IEnumerator CJECKGLHPDH()
	{
		LocBaseManager.HCBBOMFJDJI hcbbomfjdji = new LocBaseManager.HCBBOMFJDJI(1);
		hcbbomfjdji.AENJLLPLILM = this;
		return hcbbomfjdji;
	}

	// Token: 0x060073C2 RID: 29634 RVA: 0x003727F4 File Offset: 0x003709F4
	public float BNBBLDJDDLP()
	{
		float num = 1954f;
		if (this.MKBBJLCHDPJ != null)
		{
			num = this.MKBBJLCHDPJ.progress;
		}
		if (this.isLoadDone)
		{
			num = 1856f;
		}
		return num * 1977f;
	}

	// Token: 0x060073C3 RID: 29635 RVA: 0x003727E4 File Offset: 0x003709E4
	private IEnumerator NCKCCAMNNII()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
		}
		this.isLoadProcess = true;
		this.isLoadDone = false;
		this.isInstanceProcess = false;
		num = (long)Environment.TickCount;
		text = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.ALBOCLBFNNI);
		this.MKBBJLCHDPJ = AssetBundle.LoadFromFileAsync(text);
		Debug.Log("********* Start load Level " + this.JIPIPOLKPCF + " from " + text);
		yield return this.MKBBJLCHDPJ;
		assetBundle = this.MKBBJLCHDPJ.assetBundle;
		if (assetBundle == null)
		{
			Debug.LogError("Failed to load AssetBundle " + text);
			yield break;
		}
		this.CLKBDNJIBIL = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return this.CLKBDNJIBIL;
		NJMHLCGIAJI.IKGFHGKKCPG.NADAJMDGNAI();
		Debug.Log("********* LoadAllAssets via ASYNC loadLevelTime=" + (float)((long)Environment.TickCount - num) / 1000f);
		this.isLoadDone = true;
		num = (long)Environment.TickCount;
		try
		{
			this.AAJGHJABFPB();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		Debug.Log("********* End INSTANIATE Level  instLevelTime=" + (float)((long)Environment.TickCount - num) / 1000f);
		assetBundle.Unload(false);
		this.isLoadProcess = false;
		try
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AGABLNAAFHA();
			yield break;
		}
		catch (Exception message2)
		{
			Debug.LogError(message2);
			yield break;
		}
		yield break;
	}

	// Token: 0x060073C4 RID: 29636 RVA: 0x003720FB File Offset: 0x003702FB
	private void HHOACKALPHC()
	{
		if (LocBaseManager.AGEHHNOKBGK != null && LocBaseManager.AGEHHNOKBGK != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		LocBaseManager.AGEHHNOKBGK = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060073C5 RID: 29637 RVA: 0x00372830 File Offset: 0x00370A30
	private void LDOKOMDACEP()
	{
		if (this.CLKBDNJIBIL == null)
		{
			return;
		}
		foreach (LocBaseManager.HHIFOAIHHNC hhifoaihhnc in this.ILMOOIGAFDL)
		{
			hhifoaihhnc(this.CLKBDNJIBIL.asset as GameObject);
		}
		this.ILMOOIGAFDL.Clear();
	}

	// Token: 0x060073C6 RID: 29638 RVA: 0x003728A4 File Offset: 0x00370AA4
	private IEnumerator EKLPOMCJOGB(int EPGAKJIAEFM)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
		yield return new WaitForSeconds(0.1f);
		SceneManager.LoadScene(EPGAKJIAEFM);
		yield break;
	}

	// Token: 0x060073C7 RID: 29639 RVA: 0x003728B4 File Offset: 0x00370AB4
	public void CIJIKBCOJBM(HBPNMNGOFMA KADBECGIMPD)
	{
		this.traveles.Clear();
		while (!KADBECGIMPD.IBMMOGHFCCE())
		{
			LocBaseManager.JGNBBMJLDPM jgnbbmjldpm = new LocBaseManager.JGNBBMJLDPM(KADBECGIMPD);
			this.traveles.Add(jgnbbmjldpm.PNEDPPPEFFG, jgnbbmjldpm);
			this.toGlobalMap.LNEPKLKELMI = (double)jgnbbmjldpm.PNEDPPPEFFG;
			this.toGlobalMap.NMKCBJKHBOH = (double)jgnbbmjldpm.OPCKECKICAI;
			this.globalMapTravel = jgnbbmjldpm.MOPJKJBPFDC;
		}
	}

	// Token: 0x060073C8 RID: 29640 RVA: 0x00372488 File Offset: 0x00370688
	public void CIHMKJHMKMK(int NPHCOJCGGKN)
	{
		base.StartCoroutine(this.OICHDCAKNFF(NPHCOJCGGKN));
	}

	// Token: 0x060073C9 RID: 29641 RVA: 0x003728A4 File Offset: 0x00370AA4
	private IEnumerator ILHGLIDHKCF(int EPGAKJIAEFM)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
		yield return new WaitForSeconds(0.1f);
		SceneManager.LoadScene(EPGAKJIAEFM);
		yield break;
	}

	// Token: 0x060073CA RID: 29642 RVA: 0x003720FB File Offset: 0x003702FB
	private void NLMBBNDHPLJ()
	{
		if (LocBaseManager.AGEHHNOKBGK != null && LocBaseManager.AGEHHNOKBGK != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		LocBaseManager.AGEHHNOKBGK = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060073CB RID: 29643 RVA: 0x003726EC File Offset: 0x003708EC
	public void loadSceneWaiter(int NPHCOJCGGKN)
	{
		base.StartCoroutine(this.EKLPOMCJOGB(NPHCOJCGGKN));
	}

	// Token: 0x060073CC RID: 29644 RVA: 0x00372920 File Offset: 0x00370B20
	private void LENKJAFEKCO()
	{
		if (this.CLKBDNJIBIL == null)
		{
			return;
		}
		foreach (LocBaseManager.HHIFOAIHHNC hhifoaihhnc in this.ILMOOIGAFDL)
		{
			hhifoaihhnc(this.CLKBDNJIBIL.asset as GameObject);
		}
		this.ILMOOIGAFDL.Clear();
	}

	// Token: 0x060073CD RID: 29645 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LGCJDIGOOFA()
	{
	}

	// Token: 0x060073CE RID: 29646 RVA: 0x00372994 File Offset: 0x00370B94
	public void LMJJIKBFDLJ(int IAOHOFAMLEF, LocBaseManager.HHIFOAIHHNC MCPJBOAKCMK)
	{
		if (MCPJBOAKCMK != null && !this.ILMOOIGAFDL.Contains(MCPJBOAKCMK))
		{
			this.ILMOOIGAFDL.Add(MCPJBOAKCMK);
		}
		bool isEditor = Application.isEditor;
		if (this.DDHPOGIOGPJ != IAOHOFAMLEF)
		{
			if (this.MKBBJLCHDPJ != null)
			{
				this.MKBBJLCHDPJ = null;
			}
			bool isEditor2 = Application.isEditor;
			this.JIPIPOLKPCF = string.Format("takeToFrend", IAOHOFAMLEF);
			this.ALBOCLBFNNI = string.Format("req_prof", IAOHOFAMLEF);
			this.DDHPOGIOGPJ = IAOHOFAMLEF;
			this.isLoadDone = false;
			base.StartCoroutine(this.DDNDDPEKNBD());
			return;
		}
		if (!this.isLoadProcess)
		{
			if (this.isLoadDone)
			{
				this.DNKBOBCMNAJ();
				return;
			}
			Debug.LogError("demoDouble" + IAOHOFAMLEF);
		}
	}

	// Token: 0x060073CF RID: 29647 RVA: 0x00372A58 File Offset: 0x00370C58
	public void IICBEJGECMI(int IAOHOFAMLEF, LocBaseManager.HHIFOAIHHNC MCPJBOAKCMK)
	{
		if (MCPJBOAKCMK != null && !this.ILMOOIGAFDL.Contains(MCPJBOAKCMK))
		{
			this.ILMOOIGAFDL.Add(MCPJBOAKCMK);
		}
		bool isEditor = Application.isEditor;
		if (this.DDHPOGIOGPJ != IAOHOFAMLEF)
		{
			if (this.MKBBJLCHDPJ != null)
			{
				this.MKBBJLCHDPJ = null;
			}
			bool isEditor2 = Application.isEditor;
			this.JIPIPOLKPCF = string.Format("/", IAOHOFAMLEF);
			this.ALBOCLBFNNI = string.Format("_PrevViewProj", IAOHOFAMLEF);
			this.DDHPOGIOGPJ = IAOHOFAMLEF;
			this.isLoadDone = true;
			base.StartCoroutine(this.PIMLBNCLMNG());
			return;
		}
		if (!this.isLoadProcess)
		{
			if (this.isLoadDone)
			{
				this.DNKBOBCMNAJ();
				return;
			}
			Debug.LogError("IdleStandingJump" + IAOHOFAMLEF);
		}
	}

	// Token: 0x060073D0 RID: 29648 RVA: 0x0037226A File Offset: 0x0037046A
	public LocBaseManager.JGNBBMJLDPM BGOJDIDMPLF(int MIEGPLMJJCJ)
	{
		if (!this.traveles.ContainsKey(MIEGPLMJJCJ))
		{
			return null;
		}
		return this.traveles[MIEGPLMJJCJ];
	}

	// Token: 0x060073D1 RID: 29649 RVA: 0x003720FB File Offset: 0x003702FB
	private void CKGJEIDEJCH()
	{
		if (LocBaseManager.AGEHHNOKBGK != null && LocBaseManager.AGEHHNOKBGK != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		LocBaseManager.AGEHHNOKBGK = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060073D2 RID: 29650 RVA: 0x00372B1C File Offset: 0x00370D1C
	public float COEBICEIOFO()
	{
		float num = 1466f;
		if (this.MKBBJLCHDPJ != null)
		{
			num = this.MKBBJLCHDPJ.progress;
		}
		if (this.isLoadDone)
		{
			num = 230f;
		}
		return num * 147f;
	}

	// Token: 0x060073D3 RID: 29651 RVA: 0x00372480 File Offset: 0x00370680
	protected IEnumerator JBPDBMDGEPK()
	{
		yield return new WaitForSeconds(0.1f);
		yield break;
	}

	// Token: 0x060073D4 RID: 29652 RVA: 0x00372B58 File Offset: 0x00370D58
	public void BKPHNBOIFPA(int IAOHOFAMLEF, LocBaseManager.HHIFOAIHHNC MCPJBOAKCMK)
	{
		if (MCPJBOAKCMK != null && !this.ILMOOIGAFDL.Contains(MCPJBOAKCMK))
		{
			this.ILMOOIGAFDL.Add(MCPJBOAKCMK);
		}
		bool isEditor = Application.isEditor;
		if (this.DDHPOGIOGPJ != IAOHOFAMLEF)
		{
			if (this.MKBBJLCHDPJ != null)
			{
				this.MKBBJLCHDPJ = null;
			}
			bool isEditor2 = Application.isEditor;
			this.JIPIPOLKPCF = string.Format("error", IAOHOFAMLEF);
			this.ALBOCLBFNNI = string.Format("cnt_energ", IAOHOFAMLEF);
			this.DDHPOGIOGPJ = IAOHOFAMLEF;
			this.isLoadDone = true;
			base.StartCoroutine(this.BJENDAGCKFO());
			return;
		}
		if (!this.isLoadProcess)
		{
			if (this.isLoadDone)
			{
				this.LDOKOMDACEP();
				return;
			}
			Debug.LogError("Katana" + IAOHOFAMLEF);
		}
	}

	// Token: 0x060073D5 RID: 29653 RVA: 0x00372480 File Offset: 0x00370680
	protected IEnumerator JALKHHMLHDM()
	{
		yield return new WaitForSeconds(0.1f);
		yield break;
	}

	// Token: 0x060073D6 RID: 29654 RVA: 0x003726EC File Offset: 0x003708EC
	public void IOPMCNFPPGL(int NPHCOJCGGKN)
	{
		base.StartCoroutine(this.EKLPOMCJOGB(NPHCOJCGGKN));
	}

	// Token: 0x060073D7 RID: 29655 RVA: 0x00372314 File Offset: 0x00370514
	private IEnumerator OICHDCAKNFF(int EPGAKJIAEFM)
	{
		LocBaseManager.FDLPHKMCBIO fdlphkmcbio = new LocBaseManager.FDLPHKMCBIO(1);
		fdlphkmcbio.EPGAKJIAEFM = EPGAKJIAEFM;
		return fdlphkmcbio;
	}

	// Token: 0x060073D8 RID: 29656 RVA: 0x00372C1C File Offset: 0x00370E1C
	public void HPFMIDDAKLE(HBPNMNGOFMA KADBECGIMPD)
	{
		this.traveles.Clear();
		while (!KADBECGIMPD.BKIBKLFCCGP())
		{
			LocBaseManager.JGNBBMJLDPM jgnbbmjldpm = new LocBaseManager.JGNBBMJLDPM(KADBECGIMPD);
			this.traveles.Add(jgnbbmjldpm.PNEDPPPEFFG, jgnbbmjldpm);
			this.toGlobalMap.LNEPKLKELMI = (double)jgnbbmjldpm.PNEDPPPEFFG;
			this.toGlobalMap.NMKCBJKHBOH = (double)jgnbbmjldpm.OPCKECKICAI;
			this.globalMapTravel = jgnbbmjldpm.MOPJKJBPFDC;
		}
	}

	// Token: 0x060073D9 RID: 29657 RVA: 0x00372C87 File Offset: 0x00370E87
	public void NGNLLBCAGLJ(int NPHCOJCGGKN)
	{
		base.StartCoroutine(this.ICGKNKCCLFM(NPHCOJCGGKN));
	}

	// Token: 0x060073DA RID: 29658 RVA: 0x003720FB File Offset: 0x003702FB
	private void OLDFHDFAKDN()
	{
		if (LocBaseManager.AGEHHNOKBGK != null && LocBaseManager.AGEHHNOKBGK != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		LocBaseManager.AGEHHNOKBGK = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060073DB RID: 29659 RVA: 0x00372C98 File Offset: 0x00370E98
	public void getTravelBaseList(HBPNMNGOFMA KADBECGIMPD)
	{
		this.traveles.Clear();
		while (!KADBECGIMPD.JCEGOADAOOI)
		{
			LocBaseManager.JGNBBMJLDPM jgnbbmjldpm = new LocBaseManager.JGNBBMJLDPM(KADBECGIMPD);
			this.traveles.Add(jgnbbmjldpm.PNEDPPPEFFG, jgnbbmjldpm);
			this.toGlobalMap.LNEPKLKELMI = (double)jgnbbmjldpm.PNEDPPPEFFG;
			this.toGlobalMap.NMKCBJKHBOH = (double)jgnbbmjldpm.OPCKECKICAI;
			this.globalMapTravel = jgnbbmjldpm.MOPJKJBPFDC;
		}
	}

	// Token: 0x060073DC RID: 29660 RVA: 0x00372370 File Offset: 0x00370570
	private IEnumerator DMEEMEAPCKA()
	{
		LocBaseManager.HCBBOMFJDJI hcbbomfjdji = new LocBaseManager.HCBBOMFJDJI(1);
		hcbbomfjdji.AENJLLPLILM = this;
		return hcbbomfjdji;
	}

	// Token: 0x060073DD RID: 29661 RVA: 0x00372D04 File Offset: 0x00370F04
	public float OFNCAJEAGEA()
	{
		float num = 1311f;
		if (this.MKBBJLCHDPJ != null)
		{
			num = this.MKBBJLCHDPJ.progress;
		}
		if (this.isLoadDone)
		{
			num = 351f;
		}
		return num * 184f;
	}

	// Token: 0x060073DE RID: 29662 RVA: 0x00372370 File Offset: 0x00370570
	private IEnumerator PHGHNMOAHKN()
	{
		LocBaseManager.HCBBOMFJDJI hcbbomfjdji = new LocBaseManager.HCBBOMFJDJI(1);
		hcbbomfjdji.AENJLLPLILM = this;
		return hcbbomfjdji;
	}

	// Token: 0x060073DF RID: 29663 RVA: 0x00372480 File Offset: 0x00370680
	protected IEnumerator IANOPLMBIPO()
	{
		yield return new WaitForSeconds(0.1f);
		yield break;
	}

	// Token: 0x060073E0 RID: 29664 RVA: 0x00372D40 File Offset: 0x00370F40
	public void CODEIJECFJO(int IAOHOFAMLEF, LocBaseManager.HHIFOAIHHNC MCPJBOAKCMK)
	{
		if (MCPJBOAKCMK != null && !this.ILMOOIGAFDL.Contains(MCPJBOAKCMK))
		{
			this.ILMOOIGAFDL.Add(MCPJBOAKCMK);
		}
		bool isEditor = Application.isEditor;
		if (this.DDHPOGIOGPJ != IAOHOFAMLEF)
		{
			if (this.MKBBJLCHDPJ != null)
			{
				this.MKBBJLCHDPJ = null;
			}
			bool isEditor2 = Application.isEditor;
			this.JIPIPOLKPCF = string.Format("Cells", IAOHOFAMLEF);
			this.ALBOCLBFNNI = string.Format("Flashlight", IAOHOFAMLEF);
			this.DDHPOGIOGPJ = IAOHOFAMLEF;
			this.isLoadDone = false;
			base.StartCoroutine(this.MMIGHKGJJHN());
			return;
		}
		if (!this.isLoadProcess)
		{
			if (this.isLoadDone)
			{
				this.KFDPLLKMACB();
				return;
			}
			Debug.LogError("Attempting to set limb orientation to Vector3.zero axis" + IAOHOFAMLEF);
		}
	}

	// Token: 0x060073E1 RID: 29665 RVA: 0x003720FB File Offset: 0x003702FB
	private void GAOCGDLONBN()
	{
		if (LocBaseManager.AGEHHNOKBGK != null && LocBaseManager.AGEHHNOKBGK != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		LocBaseManager.AGEHHNOKBGK = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060073E2 RID: 29666 RVA: 0x00372E04 File Offset: 0x00371004
	public float HOLPICGKOHJ()
	{
		float num = 302f;
		if (this.MKBBJLCHDPJ != null)
		{
			num = this.MKBBJLCHDPJ.progress;
		}
		if (this.isLoadDone)
		{
			num = 1283f;
		}
		return num * 358f;
	}

	// Token: 0x060073E3 RID: 29667 RVA: 0x00372288 File Offset: 0x00370488
	public static LocBaseManager NPCAKEGNBHD()
	{
		return LocBaseManager.AGEHHNOKBGK;
	}

	// Token: 0x060073E4 RID: 29668 RVA: 0x00372288 File Offset: 0x00370488
	public static LocBaseManager GJACINHCABC()
	{
		return LocBaseManager.AGEHHNOKBGK;
	}

	// Token: 0x060073E5 RID: 29669 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EGDBNKCJOCD()
	{
	}

	// Token: 0x060073E6 RID: 29670 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Start()
	{
	}

	// Token: 0x060073E7 RID: 29671 RVA: 0x003720FB File Offset: 0x003702FB
	private void EBNINOBOAII()
	{
		if (LocBaseManager.AGEHHNOKBGK != null && LocBaseManager.AGEHHNOKBGK != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		LocBaseManager.AGEHHNOKBGK = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060073E8 RID: 29672 RVA: 0x00372577 File Offset: 0x00370777
	public void AAMBJLICEAD(int NPHCOJCGGKN)
	{
		base.StartCoroutine(this.HGAJIKMLCJO(NPHCOJCGGKN));
	}

	// Token: 0x060073E9 RID: 29673 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CGMHGDEKDEP()
	{
	}

	// Token: 0x060073EA RID: 29674 RVA: 0x00372480 File Offset: 0x00370680
	protected IEnumerator IIPLJIIAHNC()
	{
		yield return new WaitForSeconds(0.1f);
		yield break;
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x060073EB RID: 29675 RVA: 0x00372E40 File Offset: 0x00371040
	public float CECMGBMIMLO
	{
		get
		{
			float num = 0f;
			if (this.MKBBJLCHDPJ != null)
			{
				num = this.MKBBJLCHDPJ.progress;
			}
			if (this.isLoadDone)
			{
				num = 100f;
			}
			return num * 100f;
		}
	}

	// Token: 0x060073EC RID: 29676 RVA: 0x003720FB File Offset: 0x003702FB
	private void PPNOJNBFHAP()
	{
		if (LocBaseManager.AGEHHNOKBGK != null && LocBaseManager.AGEHHNOKBGK != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		LocBaseManager.AGEHHNOKBGK = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060073ED RID: 29677 RVA: 0x0037226A File Offset: 0x0037046A
	public LocBaseManager.JGNBBMJLDPM getTravel(int MIEGPLMJJCJ)
	{
		if (!this.traveles.ContainsKey(MIEGPLMJJCJ))
		{
			return null;
		}
		return this.traveles[MIEGPLMJJCJ];
	}

	// Token: 0x060073EE RID: 29678 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MODJFGGIAHD()
	{
	}

	// Token: 0x060073EF RID: 29679 RVA: 0x00372480 File Offset: 0x00370680
	protected IEnumerator NFGLDDFCGEO()
	{
		yield return new WaitForSeconds(0.1f);
		yield break;
	}

	// Token: 0x060073F0 RID: 29680 RVA: 0x003720FB File Offset: 0x003702FB
	private void MHMOLJLFPKP()
	{
		if (LocBaseManager.AGEHHNOKBGK != null && LocBaseManager.AGEHHNOKBGK != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		LocBaseManager.AGEHHNOKBGK = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060073F1 RID: 29681 RVA: 0x003720FB File Offset: 0x003702FB
	private void PFKOLCOAPCN()
	{
		if (LocBaseManager.AGEHHNOKBGK != null && LocBaseManager.AGEHHNOKBGK != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		LocBaseManager.AGEHHNOKBGK = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060073F2 RID: 29682 RVA: 0x003728A4 File Offset: 0x00370AA4
	private IEnumerator LGKCONLEEAA(int EPGAKJIAEFM)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
		yield return new WaitForSeconds(0.1f);
		SceneManager.LoadScene(EPGAKJIAEFM);
		yield break;
	}

	// Token: 0x060073F3 RID: 29683 RVA: 0x00372314 File Offset: 0x00370514
	private IEnumerator HAECIJLAOFK(int EPGAKJIAEFM)
	{
		LocBaseManager.FDLPHKMCBIO fdlphkmcbio = new LocBaseManager.FDLPHKMCBIO(1);
		fdlphkmcbio.EPGAKJIAEFM = EPGAKJIAEFM;
		return fdlphkmcbio;
	}

	// Token: 0x060073F4 RID: 29684 RVA: 0x0037237F File Offset: 0x0037057F
	protected IEnumerator FDEDDOEMBNF()
	{
		return new LocBaseManager.CHMLJNDOKEL(1);
	}

	// Token: 0x060073F5 RID: 29685 RVA: 0x00372480 File Offset: 0x00370680
	protected IEnumerator CAGHJAJMPKM()
	{
		yield return new WaitForSeconds(0.1f);
		yield break;
	}

	// Token: 0x060073F6 RID: 29686 RVA: 0x00372314 File Offset: 0x00370514
	private IEnumerator GCCMODHLAGN(int EPGAKJIAEFM)
	{
		LocBaseManager.FDLPHKMCBIO fdlphkmcbio = new LocBaseManager.FDLPHKMCBIO(1);
		fdlphkmcbio.EPGAKJIAEFM = EPGAKJIAEFM;
		return fdlphkmcbio;
	}

	// Token: 0x060073F7 RID: 29687 RVA: 0x00372314 File Offset: 0x00370514
	private IEnumerator MLGGBCDGDGA(int EPGAKJIAEFM)
	{
		LocBaseManager.FDLPHKMCBIO fdlphkmcbio = new LocBaseManager.FDLPHKMCBIO(1);
		fdlphkmcbio.EPGAKJIAEFM = EPGAKJIAEFM;
		return fdlphkmcbio;
	}

	// Token: 0x060073F8 RID: 29688 RVA: 0x00372288 File Offset: 0x00370488
	public static LocBaseManager CHFPAOGEMEM()
	{
		return LocBaseManager.AGEHHNOKBGK;
	}

	// Token: 0x060073F9 RID: 29689 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CKGPEFOKKNL()
	{
	}

	// Token: 0x060073FA RID: 29690 RVA: 0x00022FCC File Offset: 0x000211CC
	private void CJNBMPCNKHP()
	{
	}

	// Token: 0x060073FB RID: 29691 RVA: 0x00372E7C File Offset: 0x0037107C
	public void IIBPDDDEAPD(HBPNMNGOFMA KADBECGIMPD)
	{
		this.traveles.Clear();
		while (!KADBECGIMPD.IBMMOGHFCCE())
		{
			LocBaseManager.JGNBBMJLDPM jgnbbmjldpm = new LocBaseManager.JGNBBMJLDPM(KADBECGIMPD);
			this.traveles.Add(jgnbbmjldpm.PNEDPPPEFFG, jgnbbmjldpm);
			this.toGlobalMap.IECBGIDJHCL((double)jgnbbmjldpm.PNEDPPPEFFG);
			this.toGlobalMap.NMKCBJKHBOH = (double)jgnbbmjldpm.OPCKECKICAI;
			this.globalMapTravel = jgnbbmjldpm.MOPJKJBPFDC;
		}
	}

	// Token: 0x060073FC RID: 29692 RVA: 0x00372EE8 File Offset: 0x003710E8
	private void HNDJMLEAMKJ()
	{
		if (this.CLKBDNJIBIL == null)
		{
			return;
		}
		foreach (LocBaseManager.HHIFOAIHHNC hhifoaihhnc in this.ILMOOIGAFDL)
		{
			hhifoaihhnc(this.CLKBDNJIBIL.asset as GameObject);
		}
		this.ILMOOIGAFDL.Clear();
	}

	// Token: 0x060073FD RID: 29693 RVA: 0x00022FCC File Offset: 0x000211CC
	private void APPLKMOGAMJ()
	{
	}

	// Token: 0x060073FE RID: 29694 RVA: 0x0037226A File Offset: 0x0037046A
	public LocBaseManager.JGNBBMJLDPM JLFNIGMFPCF(int MIEGPLMJJCJ)
	{
		if (!this.traveles.ContainsKey(MIEGPLMJJCJ))
		{
			return null;
		}
		return this.traveles[MIEGPLMJJCJ];
	}

	// Token: 0x060073FF RID: 29695 RVA: 0x0037237F File Offset: 0x0037057F
	protected IEnumerator GHDPGCPEAEP()
	{
		return new LocBaseManager.CHMLJNDOKEL(1);
	}

	// Token: 0x06007400 RID: 29696 RVA: 0x00372F5C File Offset: 0x0037115C
	public void KCKGOKEJKJI(int IAOHOFAMLEF, LocBaseManager.HHIFOAIHHNC MCPJBOAKCMK)
	{
		if (MCPJBOAKCMK != null && !this.ILMOOIGAFDL.Contains(MCPJBOAKCMK))
		{
			this.ILMOOIGAFDL.Add(MCPJBOAKCMK);
		}
		bool isEditor = Application.isEditor;
		if (this.DDHPOGIOGPJ != IAOHOFAMLEF)
		{
			if (this.MKBBJLCHDPJ != null)
			{
				this.MKBBJLCHDPJ = null;
			}
			bool isEditor2 = Application.isEditor;
			this.JIPIPOLKPCF = string.Format("_TraceBehindObjects", IAOHOFAMLEF);
			this.ALBOCLBFNNI = string.Format("cht_ach1", IAOHOFAMLEF);
			this.DDHPOGIOGPJ = IAOHOFAMLEF;
			this.isLoadDone = false;
			base.StartCoroutine(this.MMIGHKGJJHN());
			return;
		}
		if (!this.isLoadProcess)
		{
			if (this.isLoadDone)
			{
				this.LENKJAFEKCO();
				return;
			}
			Debug.LogError("auk_wcnt" + IAOHOFAMLEF);
		}
	}

	// Token: 0x06007401 RID: 29697 RVA: 0x0037226A File Offset: 0x0037046A
	public LocBaseManager.JGNBBMJLDPM LBDFJABNGCN(int MIEGPLMJJCJ)
	{
		if (!this.traveles.ContainsKey(MIEGPLMJJCJ))
		{
			return null;
		}
		return this.traveles[MIEGPLMJJCJ];
	}

	// Token: 0x06007402 RID: 29698 RVA: 0x0037301E File Offset: 0x0037121E
	public void FMJKCIGFAJL(int NPHCOJCGGKN)
	{
		base.StartCoroutine(this.GCCMODHLAGN(NPHCOJCGGKN));
	}

	// Token: 0x06007403 RID: 29699 RVA: 0x00373030 File Offset: 0x00371230
	public float IAKGABAMHNK()
	{
		float num = 1157f;
		if (this.MKBBJLCHDPJ != null)
		{
			num = this.MKBBJLCHDPJ.progress;
		}
		if (this.isLoadDone)
		{
			num = 679f;
		}
		return num * 1207f;
	}

	// Token: 0x06007404 RID: 29700 RVA: 0x0037306C File Offset: 0x0037126C
	public void BAEAAIPMHCO(int IAOHOFAMLEF, LocBaseManager.HHIFOAIHHNC MCPJBOAKCMK)
	{
		if (MCPJBOAKCMK != null && !this.ILMOOIGAFDL.Contains(MCPJBOAKCMK))
		{
			this.ILMOOIGAFDL.Add(MCPJBOAKCMK);
		}
		bool isEditor = Application.isEditor;
		if (this.DDHPOGIOGPJ != IAOHOFAMLEF)
		{
			if (this.MKBBJLCHDPJ != null)
			{
				this.MKBBJLCHDPJ = null;
			}
			bool isEditor2 = Application.isEditor;
			this.JIPIPOLKPCF = string.Format("+", IAOHOFAMLEF);
			this.ALBOCLBFNNI = string.Format("Can only get root and pelvis positions from IKSolverVR. GetPosition index out of range.", IAOHOFAMLEF);
			this.DDHPOGIOGPJ = IAOHOFAMLEF;
			this.isLoadDone = false;
			base.StartCoroutine(this.BJENDAGCKFO());
			return;
		}
		if (!this.isLoadProcess)
		{
			if (this.isLoadDone)
			{
				this.FDOFPMGKEDI();
				return;
			}
			Debug.LogError("gi_um_4" + IAOHOFAMLEF);
		}
	}

	// Token: 0x06007405 RID: 29701 RVA: 0x0037237F File Offset: 0x0037057F
	protected IEnumerator HPBGEFOKGNA()
	{
		return new LocBaseManager.CHMLJNDOKEL(1);
	}

	// Token: 0x06007406 RID: 29702 RVA: 0x003720FB File Offset: 0x003702FB
	private void MBNCGMLPNLD()
	{
		if (LocBaseManager.AGEHHNOKBGK != null && LocBaseManager.AGEHHNOKBGK != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		LocBaseManager.AGEHHNOKBGK = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06007407 RID: 29703 RVA: 0x00373130 File Offset: 0x00371330
	private void JDPJPKIPHLJ()
	{
		if (this.CLKBDNJIBIL == null)
		{
			return;
		}
		foreach (LocBaseManager.HHIFOAIHHNC hhifoaihhnc in this.ILMOOIGAFDL)
		{
			hhifoaihhnc(this.CLKBDNJIBIL.asset as GameObject);
		}
		this.ILMOOIGAFDL.Clear();
	}

	// Token: 0x06007408 RID: 29704 RVA: 0x0037226A File Offset: 0x0037046A
	public LocBaseManager.JGNBBMJLDPM MCIBLPMMKJF(int MIEGPLMJJCJ)
	{
		if (!this.traveles.ContainsKey(MIEGPLMJJCJ))
		{
			return null;
		}
		return this.traveles[MIEGPLMJJCJ];
	}

	// Token: 0x06007409 RID: 29705 RVA: 0x003731A4 File Offset: 0x003713A4
	public void ACNPDAAKMGD(HBPNMNGOFMA KADBECGIMPD)
	{
		this.traveles.Clear();
		while (!KADBECGIMPD.HKBFCJDJCOB())
		{
			LocBaseManager.JGNBBMJLDPM jgnbbmjldpm = new LocBaseManager.JGNBBMJLDPM(KADBECGIMPD);
			this.traveles.Add(jgnbbmjldpm.PNEDPPPEFFG, jgnbbmjldpm);
			this.toGlobalMap.LNEPKLKELMI = (double)jgnbbmjldpm.PNEDPPPEFFG;
			this.toGlobalMap.NMKCBJKHBOH = (double)jgnbbmjldpm.OPCKECKICAI;
			this.globalMapTravel = jgnbbmjldpm.MOPJKJBPFDC;
		}
	}

	// Token: 0x0600740A RID: 29706 RVA: 0x00372370 File Offset: 0x00370570
	private IEnumerator JCPJBBEEGED()
	{
		LocBaseManager.HCBBOMFJDJI hcbbomfjdji = new LocBaseManager.HCBBOMFJDJI(1);
		hcbbomfjdji.AENJLLPLILM = this;
		return hcbbomfjdji;
	}

	// Token: 0x0600740B RID: 29707 RVA: 0x003727E4 File Offset: 0x003709E4
	private IEnumerator NHHDBIHFNFK()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
		}
		this.isLoadProcess = true;
		this.isLoadDone = false;
		this.isInstanceProcess = false;
		num = (long)Environment.TickCount;
		text = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.ALBOCLBFNNI);
		this.MKBBJLCHDPJ = AssetBundle.LoadFromFileAsync(text);
		Debug.Log("********* Start load Level " + this.JIPIPOLKPCF + " from " + text);
		yield return this.MKBBJLCHDPJ;
		assetBundle = this.MKBBJLCHDPJ.assetBundle;
		if (assetBundle == null)
		{
			Debug.LogError("Failed to load AssetBundle " + text);
			yield break;
		}
		this.CLKBDNJIBIL = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return this.CLKBDNJIBIL;
		NJMHLCGIAJI.IKGFHGKKCPG.NADAJMDGNAI();
		Debug.Log("********* LoadAllAssets via ASYNC loadLevelTime=" + (float)((long)Environment.TickCount - num) / 1000f);
		this.isLoadDone = true;
		num = (long)Environment.TickCount;
		try
		{
			this.AAJGHJABFPB();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		Debug.Log("********* End INSTANIATE Level  instLevelTime=" + (float)((long)Environment.TickCount - num) / 1000f);
		assetBundle.Unload(false);
		this.isLoadProcess = false;
		try
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AGABLNAAFHA();
			yield break;
		}
		catch (Exception message2)
		{
			Debug.LogError(message2);
			yield break;
		}
		yield break;
	}

	// Token: 0x0600740C RID: 29708 RVA: 0x003727E4 File Offset: 0x003709E4
	private IEnumerator BJENDAGCKFO()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
		}
		this.isLoadProcess = true;
		this.isLoadDone = false;
		this.isInstanceProcess = false;
		num = (long)Environment.TickCount;
		text = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.ALBOCLBFNNI);
		this.MKBBJLCHDPJ = AssetBundle.LoadFromFileAsync(text);
		Debug.Log("********* Start load Level " + this.JIPIPOLKPCF + " from " + text);
		yield return this.MKBBJLCHDPJ;
		assetBundle = this.MKBBJLCHDPJ.assetBundle;
		if (assetBundle == null)
		{
			Debug.LogError("Failed to load AssetBundle " + text);
			yield break;
		}
		this.CLKBDNJIBIL = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return this.CLKBDNJIBIL;
		NJMHLCGIAJI.IKGFHGKKCPG.NADAJMDGNAI();
		Debug.Log("********* LoadAllAssets via ASYNC loadLevelTime=" + (float)((long)Environment.TickCount - num) / 1000f);
		this.isLoadDone = true;
		num = (long)Environment.TickCount;
		try
		{
			this.AAJGHJABFPB();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		Debug.Log("********* End INSTANIATE Level  instLevelTime=" + (float)((long)Environment.TickCount - num) / 1000f);
		assetBundle.Unload(false);
		this.isLoadProcess = false;
		try
		{
			NJMHLCGIAJI.IKGFHGKKCPG.AGABLNAAFHA();
			yield break;
		}
		catch (Exception message2)
		{
			Debug.LogError(message2);
			yield break;
		}
		yield break;
	}

	// Token: 0x0600740D RID: 29709 RVA: 0x00372387 File Offset: 0x00370587
	public void LFGCIKENPHK(int NPHCOJCGGKN)
	{
		base.StartCoroutine(this.FPIOPDDPKON(NPHCOJCGGKN));
	}

	// Token: 0x0600740E RID: 29710 RVA: 0x00022FCC File Offset: 0x000211CC
	private void ACLJDJBJLCD()
	{
	}

	// Token: 0x0600740F RID: 29711 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LHJCHPFKGDB()
	{
	}

	// Token: 0x06007410 RID: 29712 RVA: 0x0037226A File Offset: 0x0037046A
	public LocBaseManager.JGNBBMJLDPM BDIPCNDAABO(int MIEGPLMJJCJ)
	{
		if (!this.traveles.ContainsKey(MIEGPLMJJCJ))
		{
			return null;
		}
		return this.traveles[MIEGPLMJJCJ];
	}

	// Token: 0x06007411 RID: 29713 RVA: 0x00373210 File Offset: 0x00371410
	private void KBJHCCFNCBO()
	{
		if (this.CLKBDNJIBIL == null)
		{
			return;
		}
		foreach (LocBaseManager.HHIFOAIHHNC hhifoaihhnc in this.ILMOOIGAFDL)
		{
			hhifoaihhnc(this.CLKBDNJIBIL.asset as GameObject);
		}
		this.ILMOOIGAFDL.Clear();
	}

	// Token: 0x06007412 RID: 29714 RVA: 0x003720FB File Offset: 0x003702FB
	private void JIGAFDHOFKL()
	{
		if (LocBaseManager.AGEHHNOKBGK != null && LocBaseManager.AGEHHNOKBGK != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		LocBaseManager.AGEHHNOKBGK = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06007413 RID: 29715 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AOCDDBNBADJ()
	{
	}

	// Token: 0x06007414 RID: 29716 RVA: 0x00372370 File Offset: 0x00370570
	private IEnumerator PIMLBNCLMNG()
	{
		LocBaseManager.HCBBOMFJDJI hcbbomfjdji = new LocBaseManager.HCBBOMFJDJI(1);
		hcbbomfjdji.AENJLLPLILM = this;
		return hcbbomfjdji;
	}

	// Token: 0x06007415 RID: 29717 RVA: 0x0037301E File Offset: 0x0037121E
	public void OCLHHAEJJPM(int NPHCOJCGGKN)
	{
		base.StartCoroutine(this.GCCMODHLAGN(NPHCOJCGGKN));
	}

	// Token: 0x06007416 RID: 29718 RVA: 0x003728A4 File Offset: 0x00370AA4
	private IEnumerator FPIOPDDPKON(int EPGAKJIAEFM)
	{
		JDCEFOFMGHB.IKGFHGKKCPG.LHHBOOJPBPH = true;
		JDCEFOFMGHB.IKGFHGKKCPG.DDAIBFBOENE();
		yield return new WaitForSeconds(0.1f);
		SceneManager.LoadScene(EPGAKJIAEFM);
		yield break;
	}

	// Token: 0x06007417 RID: 29719 RVA: 0x00372288 File Offset: 0x00370488
	public static LocBaseManager AIHINNHNNIA()
	{
		return LocBaseManager.AGEHHNOKBGK;
	}

	// Token: 0x040010CB RID: 4299
	public bool isLoadDone;

	// Token: 0x040010CC RID: 4300
	public bool isLoadProcess;

	// Token: 0x040010CD RID: 4301
	public bool isInstanceProcess;

	// Token: 0x040010CE RID: 4302
	private string ALBOCLBFNNI = "";

	// Token: 0x040010CF RID: 4303
	private string JIPIPOLKPCF;

	// Token: 0x040010D0 RID: 4304
	private int DDHPOGIOGPJ;

	// Token: 0x040010D1 RID: 4305
	private readonly List<LocBaseManager.HHIFOAIHHNC> ILMOOIGAFDL = new List<LocBaseManager.HHIFOAIHHNC>();

	// Token: 0x040010D2 RID: 4306
	private AssetBundleCreateRequest MKBBJLCHDPJ;

	// Token: 0x040010D3 RID: 4307
	private AssetBundleRequest CLKBDNJIBIL;

	// Token: 0x040010D4 RID: 4308
	private static LocBaseManager AGEHHNOKBGK;

	// Token: 0x040010D5 RID: 4309
	public IIBEEKCAAHK toGlobalMap = IIBEEKCAAHK.ECOFBCMPIDO;

	// Token: 0x040010D6 RID: 4310
	public IIBEEKCAAHK globalMapTravel = IIBEEKCAAHK.ECOFBCMPIDO;

	// Token: 0x040010D7 RID: 4311
	public Vector3 reservPosition;

	// Token: 0x040010D8 RID: 4312
	public Quaternion reservRotation;

	// Token: 0x040010D9 RID: 4313
	public bool isCancelEnter;

	// Token: 0x040010DA RID: 4314
	public Dictionary<int, LocBaseManager.JGNBBMJLDPM> traveles = new Dictionary<int, LocBaseManager.JGNBBMJLDPM>();

	// Token: 0x020001F3 RID: 499
	public class JGNBBMJLDPM
	{
		// Token: 0x06007418 RID: 29720 RVA: 0x00373284 File Offset: 0x00371484
		public JGNBBMJLDPM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.PNEDPPPEFFG = KADBECGIMPD.HDBGOLAFOBK();
			this.OPCKECKICAI = KADBECGIMPD.HDBGOLAFOBK();
			this.GOEGADLBGML = KADBECGIMPD.HDBGOLAFOBK();
			this.AAKGNCOJCJO = KADBECGIMPD.HDBGOLAFOBK();
			this.MOPJKJBPFDC = KADBECGIMPD.EIMAIEJKHKF();
		}

		// Token: 0x040010DB RID: 4315
		public int AFCFHGMFCFG;

		// Token: 0x040010DC RID: 4316
		public int PNEDPPPEFFG;

		// Token: 0x040010DD RID: 4317
		public int OPCKECKICAI;

		// Token: 0x040010DE RID: 4318
		public int GOEGADLBGML;

		// Token: 0x040010DF RID: 4319
		public int AAKGNCOJCJO;

		// Token: 0x040010E0 RID: 4320
		public IIBEEKCAAHK MOPJKJBPFDC = IIBEEKCAAHK.ECOFBCMPIDO;
	}

	// Token: 0x020001F4 RID: 500
	// (Invoke) Token: 0x0600741A RID: 29722
	public delegate void HHIFOAIHHNC(GameObject CJBCLJOKCAH);
}
