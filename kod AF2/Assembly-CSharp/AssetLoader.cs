using System;
using System.Collections;
using System.IO;
using AssetBundles;
using UnityEngine;

// Token: 0x0200025F RID: 607
public class AssetLoader : MonoBehaviour
{
	// Token: 0x06008C13 RID: 35859 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator KPLLMEFAIJP()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C14 RID: 35860 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator NCAGODCPDNL()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C15 RID: 35861 RVA: 0x00403EE3 File Offset: 0x004020E3
	public void FCLIOHBDCFD(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine(" ");
	}

	// Token: 0x06008C16 RID: 35862 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator PPAPDGACKGE()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C17 RID: 35863 RVA: 0x00403EF8 File Offset: 0x004020F8
	public void IIFABEIMJMB(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("ThisRenderer.bones[i].name is null");
	}

	// Token: 0x06008C18 RID: 35864 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator LECGEEMCOLC()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C19 RID: 35865 RVA: 0x00403F0D File Offset: 0x0040210D
	public void FOBLOPDHNMB(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("#ffffff");
	}

	// Token: 0x06008C1A RID: 35866 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator NMFLKAODCLH()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C1B RID: 35867 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator BJNPBIKHLJK()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C1C RID: 35868 RVA: 0x00403F22 File Offset: 0x00402122
	public void HMHKMPEPGNB(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("upRodState");
	}

	// Token: 0x06008C1D RID: 35869 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator PLJECAFLLFI()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C1E RID: 35870 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator KGMMBHLALPM()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		AssetBundleRequest assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C1F RID: 35871 RVA: 0x00403F46 File Offset: 0x00402146
	public void FBMHDDOFLEF(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("> ");
	}

	// Token: 0x06008C20 RID: 35872 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator EKNBCEDDAKB()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C21 RID: 35873 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator GDDOKGAMMMI()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C22 RID: 35874 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator HPACIJLKEIO()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C23 RID: 35875 RVA: 0x00403F6A File Offset: 0x0040216A
	public void DOBCNHDAHHI(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("KatanaReadyHigh");
	}

	// Token: 0x06008C24 RID: 35876 RVA: 0x00403F7F File Offset: 0x0040217F
	public void KKFDCOKFCNC(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("RenderType");
	}

	// Token: 0x06008C25 RID: 35877 RVA: 0x00403F94 File Offset: 0x00402194
	public void MJFIEONLKKP(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("CardPlayerIdle");
	}

	// Token: 0x06008C26 RID: 35878 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator NIDGKCBMOIE()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C27 RID: 35879 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator PHNDBBHNHID()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C28 RID: 35880 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator LMPLFHGNJPJ()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C29 RID: 35881 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator KFHOBOFIAEK()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C2A RID: 35882 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator IHBHPOHOEIN()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C2B RID: 35883 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator DMAJOLAOKDD()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C2C RID: 35884 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator OFMCILBLIGN()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C2D RID: 35885 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator AEPKLIMOIJF()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C2E RID: 35886 RVA: 0x00403FA9 File Offset: 0x004021A9
	public void JPCFBADKJPN(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("offsets");
	}

	// Token: 0x06008C2F RID: 35887 RVA: 0x00403FBE File Offset: 0x004021BE
	public void AJLAFEMEMJG(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.");
	}

	// Token: 0x06008C30 RID: 35888 RVA: 0x00403FD3 File Offset: 0x004021D3
	public void HMNKIBMKEDL(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("ExposureIBL");
	}

	// Token: 0x06008C31 RID: 35889 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator JKBJKHEOCCD()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C32 RID: 35890 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator HIJJDBHLPEG()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C33 RID: 35891 RVA: 0x00403FE8 File Offset: 0x004021E8
	public void JLOFJBBLIOF(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("\n");
	}

	// Token: 0x06008C34 RID: 35892 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator JAACDOADFLD()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C35 RID: 35893 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator ECLNPIKKIEK()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C36 RID: 35894 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator HPBGEFOKGNA()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C37 RID: 35895 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator LLDJDJDGNNJ()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C38 RID: 35896 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator BMFJMAIIMLB()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C39 RID: 35897 RVA: 0x00403FFD File Offset: 0x004021FD
	public void EAIJACBCOEJ(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("/n");
	}

	// Token: 0x06008C3A RID: 35898 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator OPECDIJFJJN()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C3B RID: 35899 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator GJNLOGKDECN()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C3C RID: 35900 RVA: 0x00404012 File Offset: 0x00402212
	public void MCCGOCKOANL(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("KatanaReadyLow");
	}

	// Token: 0x06008C3D RID: 35901 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator PJLFGICBHAG()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C3E RID: 35902 RVA: 0x00404027 File Offset: 0x00402227
	public void EOMOHJPLFLM(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("RollerBladeRoll");
	}

	// Token: 0x06008C3F RID: 35903 RVA: 0x0040403C File Offset: 0x0040223C
	public void IJLMBMMBFAC(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("http://www.root-motion.com/finalikdox/html/page1.html");
	}

	// Token: 0x06008C40 RID: 35904 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator BFDLAKHPINI()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C41 RID: 35905 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator LPBLJNAKOIM()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C42 RID: 35906 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator HPNAMJJHDIN()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C43 RID: 35907 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator FIOOAJBEGHP()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C44 RID: 35908 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator LFCLNDHCBFD()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C46 RID: 35910 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator PKBEJMKCFFD()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C47 RID: 35911 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator ODANGOJANEM()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C48 RID: 35912 RVA: 0x00404051 File Offset: 0x00402251
	public void GPKOJMNCOBO(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("");
	}

	// Token: 0x06008C49 RID: 35913 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator FEMHHBLLJHK()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C4A RID: 35914 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator BLACNDGBDEB()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C4B RID: 35915 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator GBFNGKOKMJB()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C4C RID: 35916 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator KFCGNIGPDEM()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C4D RID: 35917 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator OCEJEONGDPF()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C4E RID: 35918 RVA: 0x00404066 File Offset: 0x00402266
	public void MFDAPCGIBGN(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("rod.lineDistance = ");
	}

	// Token: 0x06008C4F RID: 35919 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator HFAHHINHPGI()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C50 RID: 35920 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator HGOMKJDKGJO()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C51 RID: 35921 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator AGDOMFHKAEL()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C52 RID: 35922 RVA: 0x0040407B File Offset: 0x0040227B
	public void OBCCOKCHKDA(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("costume_");
	}

	// Token: 0x06008C53 RID: 35923 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator JDFFOGBFHNB()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C54 RID: 35924 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator OJJPIIPDGOB()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C55 RID: 35925 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator MMLLKHDPALG()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C56 RID: 35926 RVA: 0x00404090 File Offset: 0x00402290
	public void AINENHLCGCN(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("langRefresh");
	}

	// Token: 0x06008C57 RID: 35927 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator LMLJNFFOLPN()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C58 RID: 35928 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator NHDPECLHHHA()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C59 RID: 35929 RVA: 0x004040A5 File Offset: 0x004022A5
	public void HOLMNGFNJON(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine(" fid=");
	}

	// Token: 0x06008C5A RID: 35930 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator MHHLNEIHKGN()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C5B RID: 35931 RVA: 0x004040BA File Offset: 0x004022BA
	public void MFMPDIOFIAF(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("1HandHeavyOverhead");
	}

	// Token: 0x06008C5C RID: 35932 RVA: 0x004040CF File Offset: 0x004022CF
	public void EMNKDANKGMO(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("WorkerPickaxe");
	}

	// Token: 0x06008C5D RID: 35933 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator PJHMGLGBCLD()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C5E RID: 35934 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator BICICLGCMFD()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C5F RID: 35935 RVA: 0x004040E4 File Offset: 0x004022E4
	public void load(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("NNGHPPOKKDK");
	}

	// Token: 0x06008C60 RID: 35936 RVA: 0x004040F9 File Offset: 0x004022F9
	public void JLJPELHCMFF(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("PistolInstant");
	}

	// Token: 0x06008C61 RID: 35937 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator AFIJNBCPJMH()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C62 RID: 35938 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator NDIEIPHCBHL()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C63 RID: 35939 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator OEPAMPPMNJN()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C64 RID: 35940 RVA: 0x0040410E File Offset: 0x0040230E
	public void AFNMNKJKOHO(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("Dealer Shuffle");
	}

	// Token: 0x06008C65 RID: 35941 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator HGEEGOFDMGI()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C66 RID: 35942 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator NEKINBOKNAK()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C67 RID: 35943 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator MFKKJNHAJAG()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C68 RID: 35944 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator JAANIGOGKGN()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C69 RID: 35945 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator AEMACAGOLPA()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C6A RID: 35946 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator PAGLMGIIOFB()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C6B RID: 35947 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator LFBKMBIJAGN()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C6C RID: 35948 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator IIPLJIIAHNC()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C6D RID: 35949 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator KONKHBDCHFO()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C6E RID: 35950 RVA: 0x00404123 File Offset: 0x00402323
	public void HPLBMOONAFF(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("vSyncCount");
	}

	// Token: 0x06008C6F RID: 35951 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator FHEDJDAAOLN()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C70 RID: 35952 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator NOFNCDHHGKL()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C71 RID: 35953 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator PHPIBOGMGHA()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C72 RID: 35954 RVA: 0x00404138 File Offset: 0x00402338
	public void ANDLDKPJOLG(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("IdleSpew");
	}

	// Token: 0x06008C73 RID: 35955 RVA: 0x0040414D File Offset: 0x0040234D
	public void MEEMAEOFGKO(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("wgt_gr");
	}

	// Token: 0x06008C74 RID: 35956 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator CFLMLNOKMFK()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C75 RID: 35957 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator EIMKKMAJPHE()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C76 RID: 35958 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator POIOBBKLGCI()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C77 RID: 35959 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator ILDJLPNHKFE()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C78 RID: 35960 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator HMHOPMNHBMK()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C79 RID: 35961 RVA: 0x00404162 File Offset: 0x00402362
	public void GHMIFDHOMJC(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("Assets/Weapons/baseLegs.unity3d");
	}

	// Token: 0x06008C7A RID: 35962 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator BGIJFICILGD()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C7B RID: 35963 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator DLCNMKPHGLP()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C7C RID: 35964 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator NHOJMMMIBPK()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C7D RID: 35965 RVA: 0x00403FE8 File Offset: 0x004021E8
	public void MLPAOFHKOMB(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("\n");
	}

	// Token: 0x06008C7E RID: 35966 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator DBAJFPCOAAG()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C7F RID: 35967 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator JDCJOKGPNMG()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C80 RID: 35968 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator AHHOHFMLLNH()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C81 RID: 35969 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator JEMMJOINAIM()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C82 RID: 35970 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator HGBCILMFPOG()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C83 RID: 35971 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator CAGHJAJMPKM()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C84 RID: 35972 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator GAFLKEHNACG()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C85 RID: 35973 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator NNGHPPOKKDK()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C86 RID: 35974 RVA: 0x00404177 File Offset: 0x00402377
	public void EPBDNKLCKKF(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("componentA=");
	}

	// Token: 0x06008C87 RID: 35975 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator FPGGMEKHGCH()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C88 RID: 35976 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator EBJDNIOPAFP()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C89 RID: 35977 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator IDIGIKOIPNG()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C8A RID: 35978 RVA: 0x0040418C File Offset: 0x0040238C
	public void GFBFHOHEHAE(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine(" rep.repa=");
	}

	// Token: 0x06008C8B RID: 35979 RVA: 0x004041A1 File Offset: 0x004023A1
	public void NBGLKKMBELN(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("Cloth_05_00.wav");
	}

	// Token: 0x06008C8C RID: 35980 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator MDLFIKLALCK()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C8D RID: 35981 RVA: 0x00403F5B File Offset: 0x0040215B
	protected IEnumerator FMHAMHGOFLH()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		AssetBundleManager.SetSourceAssetBundleURL("file:///" + Application.streamingAssetsPath + "/");
		MOOPFNDKOHI moopfndkohi = AssetBundleManager.Initialize();
		if (moopfndkohi != null)
		{
			yield return base.StartCoroutine(moopfndkohi);
		}
		yield break;
	}

	// Token: 0x06008C8E RID: 35982 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator HHJGGHIKKFJ()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C8F RID: 35983 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator KLECPEIHPCO()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C90 RID: 35984 RVA: 0x00403F37 File Offset: 0x00402137
	private IEnumerator PPHDNNOBKAL()
	{
		if (!OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM)
		{
			yield return base.StartCoroutine(this.IIPLJIIAHNC());
			OMDDGEDHHNH.IKGFHGKKCPG.LGFJMPLCGJM = true;
		}
		this.asscontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "AssetLoader: " + this.asscontainer.ALBOCLBFNNI;
		string path = Path.Combine(Application.streamingAssetsPath, "Windows/" + this.asscontainer.ALBOCLBFNNI);
		this.asscontainer.ELCDHEEBMMO = AssetBundle.LoadFromFileAsync(path);
		if (this.asscontainer.ELCDHEEBMMO == null)
		{
			Debug.LogError("No load asset " + this.asscontainer.ALBOCLBFNNI);
			yield break;
		}
		yield return this.asscontainer.ELCDHEEBMMO;
		AssetBundle assetBundle = this.asscontainer.ELCDHEEBMMO.assetBundle;
		if (assetBundle == null)
		{
			Debug.Log("Failed to load AssetBundle!");
			yield break;
		}
		assetBundleRequest = assetBundle.LoadAllAssetsAsync<GameObject>();
		yield return assetBundleRequest;
		this.asscontainer.FEDINAMCHHF = (assetBundleRequest.asset as GameObject);
		this.asscontainer.PMJIHPFGCGJ = false;
		this.asscontainer.DKDILDPNDFI = true;
		this.asscontainer.DANHCOLDBDB = true;
		this.asscontainer.IEPBHPIBMEB = null;
		try
		{
			this.asscontainer.IALKJFLJBCP();
		}
		catch (Exception message)
		{
			Debug.LogError(message);
		}
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		yield break;
	}

	// Token: 0x06008C91 RID: 35985 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator BCLDECMJIEO()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C92 RID: 35986 RVA: 0x00403ED4 File Offset: 0x004020D4
	protected IEnumerator PMIKFFHCKPO()
	{
		AssetLoader.DGFPNDDIBHL dgfpnddibhl = new AssetLoader.DGFPNDDIBHL(1);
		dgfpnddibhl.AENJLLPLILM = this;
		return dgfpnddibhl;
	}

	// Token: 0x06008C93 RID: 35987 RVA: 0x00403EC5 File Offset: 0x004020C5
	private IEnumerator DBAKHAENCGE()
	{
		AssetLoader.OOIOLNBIOMO ooiolnbiomo = new AssetLoader.OOIOLNBIOMO(1);
		ooiolnbiomo.AENJLLPLILM = this;
		return ooiolnbiomo;
	}

	// Token: 0x06008C94 RID: 35988 RVA: 0x004041B6 File Offset: 0x004023B6
	public void MPBHGKEPBIH(OMDDGEDHHNH.BCDNKAGAFBM JACEPAEHGPM)
	{
		this.asscontainer = JACEPAEHGPM;
		base.StartCoroutine("<.*?>");
	}

	// Token: 0x04001320 RID: 4896
	public OMDDGEDHHNH.BCDNKAGAFBM asscontainer;
}
