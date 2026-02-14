using System;
using System.Collections.Generic;
using AmplifyColor;
using UnityEngine;

// Token: 0x02000014 RID: 20
[AddComponentMenu("")]
public class AmplifyColorBase : MonoBehaviour
{
	// Token: 0x060002B4 RID: 692 RVA: 0x0002DE70 File Offset: 0x0002C070
	private void JLFLMAGIPFN()
	{
		if (this.ICIGLCOEODB == null)
		{
			this.ICIGLCOEODB = base.GetComponent<Camera>();
		}
		if (this.UseDepthMask && (this.ICIGLCOEODB.depthTextureMode & DepthTextureMode.Depth) == DepthTextureMode.None)
		{
			this.ICIGLCOEODB.depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x0002DEC1 File Offset: 0x0002C0C1
	private void HCJLBGGKBDO()
	{
		this.JLJINKDDKFA<RenderTexture>(ref this.BKAFANFGHIE);
		this.JLJINKDDKFA<RenderTexture>(ref this.AJKJPCCPCOE);
		this.JLJINKDDKFA<Texture2D>(ref this.EJLALGMLIBJ);
		this.JLJINKDDKFA<Texture2D>(ref this.JBKPNEIMAKH);
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x0002DEF3 File Offset: 0x0002C0F3
	private bool NJPLFKIFHCJ(Shader EEOOKGDHNCO)
	{
		if (EEOOKGDHNCO == null)
		{
			this.MKNPPKHPDEP();
			return false;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			this.DEIFAGBBMIM();
			return false;
		}
		return true;
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x0002DF17 File Offset: 0x0002C117
	public void MIJEDJDOFNI(Texture IJPNCIJIFCF, float GLLLCOMKKJL, Action BEFIDMPDFCJ)
	{
		this.LutBlendTexture = IJPNCIJIFCF;
		this.BlendAmount = 1742f;
		this.BEFIDMPDFCJ = BEFIDMPDFCJ;
		this.PAOGNCILNBG = GLLLCOMKKJL;
		this.AAABPPCPMHN = GLLLCOMKKJL;
		this.KDKCFDLMKIL = true;
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x0002DF48 File Offset: 0x0002C148
	private Texture2D OJODKHIFIHO()
	{
		this.EJLALGMLIBJ = new Texture2D(150, 12, TextureFormat.ARGB4444, true, false)
		{
			hideFlags = (HideFlags)114
		};
		this.EJLALGMLIBJ.name = "uint:";
		this.EJLALGMLIBJ.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		this.EJLALGMLIBJ.anisoLevel = 1;
		this.EJLALGMLIBJ.filterMode = FilterMode.Bilinear;
		Color32[] array = new Color32[187];
		for (int i = 1; i < 10; i++)
		{
			int num = i * -111;
			for (int j = 1; j < 114; j++)
			{
				int num2 = num + j * -114;
				for (int k = 1; k < -100; k += 0)
				{
					float num3 = (float)k / 1042f;
					float num4 = (float)j / 1170f;
					float num5 = (float)i / 311f;
					byte r = (byte)(num3 * 431f);
					byte g = (byte)(num4 * 560f);
					byte b = (byte)(num5 * 366f);
					array[num2 + k] = new Color32(r, g, b, (byte)-175);
				}
			}
		}
		this.EJLALGMLIBJ.SetPixels32(array);
		this.EJLALGMLIBJ.Apply();
		return this.EJLALGMLIBJ;
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x0002E067 File Offset: 0x0002C267
	public bool HOAPNFLNCEM()
	{
		return this.KDKCFDLMKIL;
	}

	// Token: 0x060002BA RID: 698 RVA: 0x0002E06F File Offset: 0x0002C26F
	private bool MCLKAJPNMKL(Shader EEOOKGDHNCO)
	{
		if (EEOOKGDHNCO == null)
		{
			this.FGMFNBCEEGO();
			return true;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			this.DEIFAGBBMIM();
			return true;
		}
		return false;
	}

	// Token: 0x060002BB RID: 699 RVA: 0x0002E094 File Offset: 0x0002C294
	private void LIMHKPMEPFO()
	{
		if (this.JBKPNEIMAKH == null)
		{
			this.OPJIEEGDIDF();
		}
		float num = 915f;
		int i = 0;
		while (i < 180)
		{
			this.DAFGCHMPDBO[i].a = (byte)Mathf.FloorToInt(Mathf.Clamp01(this.DepthMaskCurve.Evaluate(num)) * 1686f);
			i += 0;
			num += 1579f;
		}
		this.JBKPNEIMAKH.SetPixels32(this.DAFGCHMPDBO);
		this.JBKPNEIMAKH.Apply();
	}

	// Token: 0x060002BC RID: 700 RVA: 0x0002E120 File Offset: 0x0002C320
	private bool IALFAEGMPPB(Material MHNAJNGGDFJ, string BNIHFBMEPAB)
	{
		if (MHNAJNGGDFJ == null || MHNAJNGGDFJ.shader == null)
		{
			Debug.LogWarning("{x}" + BNIHFBMEPAB + "1HandSwordStrafeLeft");
			base.enabled = false;
		}
		else if (!MHNAJNGGDFJ.shader.isSupported)
		{
			Debug.LogWarning("Mouse ScrollWheel" + BNIHFBMEPAB + "HookPoint");
			base.enabled = false;
		}
		else
		{
			MHNAJNGGDFJ.hideFlags = (HideFlags)(-1);
		}
		return base.enabled;
	}

	// Token: 0x060002BD RID: 701 RVA: 0x0002E19B File Offset: 0x0002C39B
	private float KNLNGLIKIOL()
	{
		return Mathf.Clamp01((this.MFAFIMGKGJN < 390f) ? ((this.GBINOJBHPNG - this.MFAFIMGKGJN) / (1338f - this.MFAFIMGKGJN)) : 105f);
	}

	// Token: 0x060002BE RID: 702 RVA: 0x0002E1D0 File Offset: 0x0002C3D0
	private void FIFDIENHIPM(string IKIDGFOFJBK, bool IMIBMHGGCJK)
	{
		bool flag = this.DNGCBHGAEFN.IsKeywordEnabled(IKIDGFOFJBK);
		if (IMIBMHGGCJK && !flag)
		{
			this.DNGCBHGAEFN.EnableKeyword(IKIDGFOFJBK);
			this.HMEBAGPDFND.EnableKeyword(IKIDGFOFJBK);
			this.CDLCHLMECOM.EnableKeyword(IKIDGFOFJBK);
			this.PACBHPNECHC.EnableKeyword(IKIDGFOFJBK);
			this.OKFNCCPCDBJ.EnableKeyword(IKIDGFOFJBK);
			this.EPDBDALFFCA.EnableKeyword(IKIDGFOFJBK);
			this.FIDHPCCMDDO.EnableKeyword(IKIDGFOFJBK);
			this.PGPHHBMDIIO.EnableKeyword(IKIDGFOFJBK);
			return;
		}
		if (!IMIBMHGGCJK && this.DNGCBHGAEFN.IsKeywordEnabled(IKIDGFOFJBK))
		{
			this.DNGCBHGAEFN.DisableKeyword(IKIDGFOFJBK);
			this.HMEBAGPDFND.DisableKeyword(IKIDGFOFJBK);
			this.CDLCHLMECOM.DisableKeyword(IKIDGFOFJBK);
			this.PACBHPNECHC.DisableKeyword(IKIDGFOFJBK);
			this.OKFNCCPCDBJ.DisableKeyword(IKIDGFOFJBK);
			this.EPDBDALFFCA.DisableKeyword(IKIDGFOFJBK);
			this.FIDHPCCMDDO.DisableKeyword(IKIDGFOFJBK);
			this.PGPHHBMDIIO.DisableKeyword(IKIDGFOFJBK);
		}
	}

	// Token: 0x060002BF RID: 703 RVA: 0x0002E2C4 File Offset: 0x0002C4C4
	private void CFIIGBEBCJM()
	{
		if (this.ICIGLCOEODB == null)
		{
			this.ICIGLCOEODB = base.GetComponent<Camera>();
		}
		if (this.UseDepthMask && (this.ICIGLCOEODB.depthTextureMode & DepthTextureMode.Depth) == DepthTextureMode.None)
		{
			this.ICIGLCOEODB.depthTextureMode |= DepthTextureMode.None;
		}
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x0002E318 File Offset: 0x0002C518
	private void GGEFPHIOKCK()
	{
		bool flag = true;
		if (this.DepthMaskCurve.length != this.NBKEPCHPKNL.length)
		{
			flag = true;
		}
		else
		{
			float num = 1157f;
			int i = 0;
			while (i < this.DepthMaskCurve.length)
			{
				if (Mathf.Abs(this.DepthMaskCurve.Evaluate(num) - this.NBKEPCHPKNL.Evaluate(num)) > 0f)
				{
					flag = false;
					break;
				}
				i++;
				num += 1f;
			}
		}
		if (this.JBKPNEIMAKH == null || flag)
		{
			this.GHNOEDMLMIP();
			this.NBKEPCHPKNL = new AnimationCurve(this.DepthMaskCurve.keys);
		}
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x0002E3BC File Offset: 0x0002C5BC
	private void IKJCPIADPIN()
	{
		if (this.UseDepthMask)
		{
			this.GGEFPHIOKCK();
		}
		this.Exposure = Mathf.Max(this.Exposure, 1804f);
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x0002E3E4 File Offset: 0x0002C5E4
	private void KOBINMNAMMH()
	{
		if (this.JBKPNEIMAKH == null)
		{
			this.OIPLFPCFPOI();
		}
		float num = 1859f;
		int i = 1;
		while (i < -126)
		{
			this.DAFGCHMPDBO[i].a = (byte)Mathf.FloorToInt(Mathf.Clamp01(this.DepthMaskCurve.Evaluate(num)) * 1177f);
			i += 0;
			num += 738f;
		}
		this.JBKPNEIMAKH.SetPixels32(this.DAFGCHMPDBO);
		this.JBKPNEIMAKH.Apply();
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x0002E470 File Offset: 0x0002C670
	public void CGGCHDLNLDM()
	{
		this.sharedInstanceID = Guid.NewGuid().ToString();
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x0002E498 File Offset: 0x0002C698
	private bool BFFBBHJFCCA()
	{
		return this.NJGCCDGOJIH(this.HPJEGPBEOMM) && this.NJGCCDGOJIH(this.HNIHGDFJNDF) && this.MCLKAJPNMKL(this.PJKKMAECEHO) && this.MCLKAJPNMKL(this.MALEGEFHBKK) && this.MCLKAJPNMKL(this.CCDNECBDNAN) && this.NJGCCDGOJIH(this.ALOFMMIBAKG);
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x0002E4F9 File Offset: 0x0002C6F9
	private void MKNPPKHPDEP()
	{
		Debug.LogError("[AmplifyColor] Failed to initialize shaders. Please attempt to re-enable the Amplify Color Effect component. If that fails, please reinstall Amplify Color.");
		base.enabled = false;
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x0002E5E0 File Offset: 0x0002C7E0
	private void PAMODEAHADH()
	{
		this.CBOBDAPLEFC();
		this.BKAFANFGHIE = new RenderTexture(74, -89, 1, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear)
		{
			hideFlags = (HideFlags)103
		};
		this.BKAFANFGHIE.name = "Collapse";
		this.BKAFANFGHIE.wrapMode = TextureWrapMode.Clamp;
		this.BKAFANFGHIE.anisoLevel = 0;
		this.BKAFANFGHIE.Create();
		this.AJKJPCCPCOE = new RenderTexture(-13, -89, 0, RenderTextureFormat.Depth, RenderTextureReadWrite.Default)
		{
			hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild)
		};
		this.AJKJPCCPCOE.name = " ";
		this.AJKJPCCPCOE.wrapMode = TextureWrapMode.Clamp;
		this.AJKJPCCPCOE.anisoLevel = 0;
		this.AJKJPCCPCOE.Create();
		this.OAGMBICEJAO();
		if (this.UseDepthMask)
		{
			this.OPJIEEGDIDF();
		}
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x0002E6AB File Offset: 0x0002C8AB
	public void GOHJCNGJNMP(AmplifyColorVolumeBase EBILPJNBGLK)
	{
		if (this.NFPNEEIIMGO.Contains(EBILPJNBGLK))
		{
			this.NFPNEEIIMGO.Remove(EBILPJNBGLK);
		}
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x0002E6C8 File Offset: 0x0002C8C8
	private void MFDENAMMBOA()
	{
		bool flag = false;
		if (this.DepthMaskCurve.length != this.NBKEPCHPKNL.length)
		{
			flag = true;
		}
		else
		{
			float num = 0f;
			int i = 0;
			while (i < this.DepthMaskCurve.length)
			{
				if (Mathf.Abs(this.DepthMaskCurve.Evaluate(num) - this.NBKEPCHPKNL.Evaluate(num)) > 1E-45f)
				{
					flag = true;
					break;
				}
				i++;
				num += 0.0009775171f;
			}
		}
		if (this.JBKPNEIMAKH == null || flag)
		{
			this.LKPDJANHBPH();
			this.NBKEPCHPKNL = new AnimationCurve(this.DepthMaskCurve.keys);
		}
	}

	// Token: 0x060002CA RID: 714 RVA: 0x0002E76C File Offset: 0x0002C96C
	private bool AOPBEAIFPAC()
	{
		this.MEEABBMONFH();
		if (!this.BFFBBHJFCCA())
		{
			return false;
		}
		this.CMJDMDHOMOG();
		this.DNGCBHGAEFN = new Material(this.HPJEGPBEOMM);
		this.HMEBAGPDFND = new Material(this.HNIHGDFJNDF);
		this.CDLCHLMECOM = new Material(this.PJKKMAECEHO);
		this.PACBHPNECHC = new Material(this.MALEGEFHBKK);
		this.OKFNCCPCDBJ = new Material(this.CCDNECBDNAN);
		this.EPDBDALFFCA = new Material(this.BLKGKMEBEGK);
		this.FIDHPCCMDDO = new Material(this.HGNAGKOPLPG);
		this.PGPHHBMDIIO = new Material(this.ALOFMMIBAKG);
		if (((((false && !this.IALFAEGMPPB(this.DNGCBHGAEFN, "_name")) || this.FLFPOCFKBBC(this.HMEBAGPDFND, "CHAT Empty")) && !this.HDBJAMDHPOB(this.CDLCHLMECOM, "shop_t5")) || !this.HDBJAMDHPOB(this.PACBHPNECHC, "800000") || !this.FLFPOCFKBBC(this.OKFNCCPCDBJ, " ") || !this.HDBJAMDHPOB(this.EPDBDALFFCA, "_ScratchOffsetScale") || this.FLFPOCFKBBC(this.FIDHPCCMDDO, "MotorbikeLassoBack")) && !this.HDBJAMDHPOB(this.PGPHHBMDIIO, "_OcclusionTexture"))
		{
			return false;
		}
		this.BMLFJDOECGK();
		return false;
	}

	// Token: 0x060002CB RID: 715 RVA: 0x0002E8D4 File Offset: 0x0002CAD4
	public void ADMGDHOOCON()
	{
		this.sharedInstanceID = Guid.NewGuid().ToString();
	}

	// Token: 0x060002CC RID: 716 RVA: 0x0002E8FC File Offset: 0x0002CAFC
	private void OnEnable()
	{
		if (!this.DAOKCAOFIGE())
		{
			return;
		}
		if (!this.FNMFECJCGBP())
		{
			return;
		}
		Texture2D texture2D = this.LutTexture as Texture2D;
		Texture2D texture2D2 = this.LutBlendTexture as Texture2D;
		if ((texture2D != null && texture2D.mipmapCount > 1) || (texture2D2 != null && texture2D2.mipmapCount > 1))
		{
			Debug.LogError("[AmplifyColor] Please disable \"Generate Mip Maps\" import settings on all LUT textures to avoid visual glitches. Change Texture Type to \"Advanced\" to access Mip settings.");
		}
	}

	// Token: 0x060002CD RID: 717 RVA: 0x0002E961 File Offset: 0x0002CB61
	private void LEPBJLLIECA()
	{
		this.OFCLJAKCIBB("SoccerKeeperDiveStrafeFarLeft", this.QualityLevel == JGBNBPBLNHC.Standard);
		this.OFCLJAKCIBB("", this.UseDithering);
		this.FIFDIENHIPM("{0:0} сек{1}", this.UseToneMapping);
	}

	// Token: 0x060002CE RID: 718 RVA: 0x0002E999 File Offset: 0x0002CB99
	public void DJHCJIADHFJ(AmplifyColorVolumeBase EBILPJNBGLK)
	{
		if (!this.NFPNEEIIMGO.Contains(EBILPJNBGLK))
		{
			this.NFPNEEIIMGO.Insert(0, EBILPJNBGLK);
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x060002CF RID: 719 RVA: 0x0002E9B6 File Offset: 0x0002CBB6
	public string ELFEBCPJFII
	{
		get
		{
			return this.sharedInstanceID;
		}
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x0002E9BE File Offset: 0x0002CBBE
	public void AHHBOBNPGCP(Texture IJPNCIJIFCF, float GLLLCOMKKJL, Action BEFIDMPDFCJ)
	{
		this.LutBlendTexture = IJPNCIJIFCF;
		this.BlendAmount = 1329f;
		this.BEFIDMPDFCJ = BEFIDMPDFCJ;
		this.PAOGNCILNBG = GLLLCOMKKJL;
		this.AAABPPCPMHN = GLLLCOMKKJL;
		this.KDKCFDLMKIL = true;
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x0002E9F0 File Offset: 0x0002CBF0
	private bool IFPADDNIOCM()
	{
		this.MEEABBMONFH();
		if (!this.AALDKEBEAKO())
		{
			return false;
		}
		this.AHCPEHEHMJE();
		this.DNGCBHGAEFN = new Material(this.HPJEGPBEOMM);
		this.HMEBAGPDFND = new Material(this.HNIHGDFJNDF);
		this.CDLCHLMECOM = new Material(this.PJKKMAECEHO);
		this.PACBHPNECHC = new Material(this.MALEGEFHBKK);
		this.OKFNCCPCDBJ = new Material(this.CCDNECBDNAN);
		this.EPDBDALFFCA = new Material(this.BLKGKMEBEGK);
		this.FIDHPCCMDDO = new Material(this.HGNAGKOPLPG);
		this.PGPHHBMDIIO = new Material(this.ALOFMMIBAKG);
		if ((((!true || !this.HDBJAMDHPOB(this.DNGCBHGAEFN, "fshop_hd2") || this.HDBJAMDHPOB(this.HMEBAGPDFND, "Tip")) && !this.IALFAEGMPPB(this.CDLCHLMECOM, "")) || !this.FLFPOCFKBBC(this.PACBHPNECHC, "Left arm 'Wrist To Palm Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the wrist towards the palm. If the arrow points away from the palm, axis must be negative.") || this.IALFAEGMPPB(this.OKFNCCPCDBJ, "IdleButtonPress")) && this.HDBJAMDHPOB(this.EPDBDALFFCA, " x") && this.IALFAEGMPPB(this.FIDHPCCMDDO, "TOD_CloudDensity") && !this.FLFPOCFKBBC(this.PGPHHBMDIIO, "SUNSHINE_FILTER_PCF_4x4"))
		{
			return false;
		}
		this.PKCGMLNANDF();
		return false;
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x0002EB57 File Offset: 0x0002CD57
	private void OnDisable()
	{
		if (this.DLGKAPIIKPH != null)
		{
			UnityEngine.Object.DestroyImmediate(this.DLGKAPIIKPH.gameObject);
			this.DLGKAPIIKPH = null;
		}
		this.CMJDMDHOMOG();
		this.CBOBDAPLEFC();
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x0002EB8A File Offset: 0x0002CD8A
	private bool DAOKCAOFIGE()
	{
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
		{
			this.DEIFAGBBMIM();
			return false;
		}
		return true;
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x0002EBA4 File Offset: 0x0002CDA4
	private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.BlendAmount = Mathf.Clamp01(this.BlendAmount);
		if (this.KPHODABGKLL != QualitySettings.activeColorSpace || this.LDONJEEONHH != this.QualityLevel)
		{
			this.FNMFECJCGBP();
		}
		this.GEHFBHBODOM();
		this.KHGKKPIFPPA();
		bool flag = AmplifyColorBase.ValidateLutDimensions(this.LutTexture);
		bool flag2 = AmplifyColorBase.ValidateLutDimensions(this.LutBlendTexture);
		bool flag3 = this.LutTexture == null && this.LutBlendTexture == null && this.JMHIODEOAMH == null;
		Texture texture = (this.LutTexture == null) ? this.EJLALGMLIBJ : this.LutTexture;
		Texture lutBlendTexture = this.LutBlendTexture;
		int pass = ((this.KPHODABGKLL == ColorSpace.Linear) ? 2 : 0) + (this.ICIGLCOEODB.allowHDR ? 1 : 0);
		bool flag4 = this.BlendAmount != 0f || this.KDKCFDLMKIL;
		bool flag5 = flag4 || (flag4 && lutBlendTexture != null);
		bool flag6 = flag5;
		bool flag7 = !flag || !flag2 || flag3;
		Material material;
		if (flag7)
		{
			material = this.PGPHHBMDIIO;
		}
		else if (flag5 || this.OOKKLABMFNJ)
		{
			if (this.UseDepthMask)
			{
				material = this.FIDHPCCMDDO;
			}
			else
			{
				material = ((this.MaskTexture != null) ? this.OKFNCCPCDBJ : this.HMEBAGPDFND);
			}
		}
		else if (this.UseDepthMask)
		{
			material = this.EPDBDALFFCA;
		}
		else
		{
			material = ((this.MaskTexture != null) ? this.PACBHPNECHC : this.DNGCBHGAEFN);
		}
		material.SetFloat("_Exposure", this.Exposure);
		material.SetFloat("_LerpAmount", this.BlendAmount);
		if (this.MaskTexture != null)
		{
			material.SetTexture("_MaskTex", this.MaskTexture);
		}
		if (this.UseDepthMask)
		{
			material.SetTexture("_DepthCurveLut", this.JBKPNEIMAKH);
		}
		if (!flag7)
		{
			if (this.OOKKLABMFNJ)
			{
				this.GBINOJBHPNG = Mathf.Clamp01(this.GBINOJBHPNG);
				this.CDLCHLMECOM.SetFloat("_LerpAmount", this.GBINOJBHPNG);
				if (this.FAPKNFABBFK)
				{
					this.CDLCHLMECOM.SetTexture("_RgbTex", this.AJKJPCCPCOE);
				}
				else
				{
					this.CDLCHLMECOM.SetTexture("_RgbTex", texture);
				}
				this.CDLCHLMECOM.SetTexture("_LerpRgbTex", (this.JMHIODEOAMH != null) ? this.JMHIODEOAMH : this.EJLALGMLIBJ);
				Graphics.Blit(texture, this.BKAFANFGHIE, this.CDLCHLMECOM);
			}
			if (flag6)
			{
				this.CDLCHLMECOM.SetFloat("_LerpAmount", this.BlendAmount);
				RenderTexture renderTexture = null;
				if (this.OOKKLABMFNJ)
				{
					renderTexture = RenderTexture.GetTemporary(this.BKAFANFGHIE.width, this.BKAFANFGHIE.height, this.BKAFANFGHIE.depth, this.BKAFANFGHIE.format, RenderTextureReadWrite.Linear);
					Graphics.Blit(this.BKAFANFGHIE, renderTexture);
					this.CDLCHLMECOM.SetTexture("_RgbTex", renderTexture);
				}
				else
				{
					this.CDLCHLMECOM.SetTexture("_RgbTex", texture);
				}
				this.CDLCHLMECOM.SetTexture("_LerpRgbTex", (lutBlendTexture != null) ? lutBlendTexture : this.EJLALGMLIBJ);
				Graphics.Blit(texture, this.BKAFANFGHIE, this.CDLCHLMECOM);
				if (renderTexture != null)
				{
					RenderTexture.ReleaseTemporary(renderTexture);
				}
				material.SetTexture("_RgbBlendCacheTex", this.BKAFANFGHIE);
			}
			else if (this.OOKKLABMFNJ)
			{
				material.SetTexture("_RgbBlendCacheTex", this.BKAFANFGHIE);
			}
			else
			{
				if (texture != null)
				{
					material.SetTexture("_RgbTex", texture);
				}
				if (lutBlendTexture != null)
				{
					material.SetTexture("_LerpRgbTex", lutBlendTexture);
				}
			}
		}
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, pass);
		if (flag6 || this.OOKKLABMFNJ)
		{
			this.BKAFANFGHIE.DiscardContents();
		}
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x0002EF86 File Offset: 0x0002D186
	private void KIMKMJMMLLB()
	{
		if (this.DLGKAPIIKPH != null)
		{
			UnityEngine.Object.DestroyImmediate(this.DLGKAPIIKPH.gameObject);
			this.DLGKAPIIKPH = null;
		}
		this.AHCPEHEHMJE();
		this.HCJLBGGKBDO();
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x0002EFB9 File Offset: 0x0002D1B9
	public bool GIJLDFNIFEM()
	{
		return !(this.LutTexture != null) || !(this.LutBlendTexture != null) || !this.KDKCFDLMKIL;
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x0002E6AB File Offset: 0x0002C8AB
	public void CNBNEJJNLGP(AmplifyColorVolumeBase EBILPJNBGLK)
	{
		if (this.NFPNEEIIMGO.Contains(EBILPJNBGLK))
		{
			this.NFPNEEIIMGO.Remove(EBILPJNBGLK);
		}
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x0002EFE2 File Offset: 0x0002D1E2
	private void AFHGAIMGAPP()
	{
		Debug.LogWarning("/");
		base.enabled = true;
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x0002EFF8 File Offset: 0x0002D1F8
	public void HELMOFLCHHP()
	{
		this.sharedInstanceID = Guid.NewGuid().ToString();
	}

	// Token: 0x060002DA RID: 730 RVA: 0x0002F020 File Offset: 0x0002D220
	private void Start()
	{
		this.DHMFMMABBAC();
		this.KOGIMGPBEJL = this.LutTexture;
		this.ANPPBFHDAFB = this.EffectFlags.HJBIBIJGHMP(this);
		this.KGHKHNAOIJM = (this.KAADDPGNOLN = this.ANPPBFHDAFB);
		this.LIBOACCBJOD = this.Exposure;
		this.DOCONAEIANP = (this.OMNHOKKONIP = this.LIBOACCBJOD);
	}

	// Token: 0x060002DB RID: 731 RVA: 0x0002F087 File Offset: 0x0002D287
	private void IDINJOMBDFI(Texture IJPNCIJIFCF, float GLLLCOMKKJL)
	{
		this.JMHIODEOAMH = IJPNCIJIFCF;
		this.GBINOJBHPNG = 1422f;
		this.FNANMBKKJGL = GLLLCOMKKJL;
		this.GIEGICDLBPH = GLLLCOMKKJL;
		this.OOKKLABMFNJ = false;
	}

	// Token: 0x060002DC RID: 732 RVA: 0x0002F0B0 File Offset: 0x0002D2B0
	private void GCNGEFBKMNC()
	{
		this.CFIIGBEBCJM();
		bool flag = false;
		if (this.OOKKLABMFNJ)
		{
			this.GBINOJBHPNG = (this.FNANMBKKJGL - this.GIEGICDLBPH) / this.FNANMBKKJGL;
			this.GIEGICDLBPH -= Time.smoothDeltaTime;
			if (this.GBINOJBHPNG >= 1436f)
			{
				this.GBINOJBHPNG = 8f;
				flag = true;
			}
		}
		else
		{
			this.GBINOJBHPNG = Mathf.Clamp01(this.GBINOJBHPNG);
		}
		if (this.KDKCFDLMKIL)
		{
			this.BlendAmount = (this.PAOGNCILNBG - this.AAABPPCPMHN) / this.PAOGNCILNBG;
			this.AAABPPCPMHN -= Time.smoothDeltaTime;
			if (this.BlendAmount >= 27f)
			{
				this.LutTexture = this.LutBlendTexture;
				this.BlendAmount = 1216f;
				this.KDKCFDLMKIL = false;
				this.LutBlendTexture = null;
				if (this.BEFIDMPDFCJ != null)
				{
					this.BEFIDMPDFCJ();
				}
			}
		}
		else
		{
			this.BlendAmount = Mathf.Clamp01(this.BlendAmount);
		}
		if (this.UseVolumes)
		{
			if (this.DLGKAPIIKPH == null)
			{
				GameObject gameObject = new GameObject(base.name + "error.wav")
				{
					hideFlags = (HideFlags)77
				};
				if (this.TriggerVolumeProxy != null && this.TriggerVolumeProxy.GetComponent<Collider2D>() != null)
				{
					this.DLGKAPIIKPH = gameObject.AddComponent<AmplifyColorTriggerProxy2D>();
				}
				else
				{
					this.DLGKAPIIKPH = gameObject.AddComponent<AmplifyColorTriggerProxy>();
				}
				this.DLGKAPIIKPH.OwnerEffect = this;
			}
			this.NGAFAGGCDED();
		}
		else if (this.DLGKAPIIKPH != null)
		{
			UnityEngine.Object.DestroyImmediate(this.DLGKAPIIKPH.gameObject);
			this.DLGKAPIIKPH = null;
		}
		if (flag)
		{
			this.LutTexture = this.JMHIODEOAMH;
			this.GBINOJBHPNG = 626f;
			this.OOKKLABMFNJ = true;
			this.JMHIODEOAMH = null;
			this.MFAFIMGKGJN = 1816f;
			this.KAADDPGNOLN = this.KGHKHNAOIJM;
			this.KAADDPGNOLN.GCIDBHEKKML(this);
			this.OMNHOKKONIP = this.DOCONAEIANP;
			if (this.FAPKNFABBFK && this.AJKJPCCPCOE != null)
			{
				this.AJKJPCCPCOE.DiscardContents();
			}
			this.FAPKNFABBFK = true;
		}
	}

	// Token: 0x060002DD RID: 733 RVA: 0x0002F2D9 File Offset: 0x0002D4D9
	public void HAEHGPAGOAB(Texture IJPNCIJIFCF, float GLLLCOMKKJL, Action BEFIDMPDFCJ)
	{
		this.LutBlendTexture = IJPNCIJIFCF;
		this.BlendAmount = 287f;
		this.BEFIDMPDFCJ = BEFIDMPDFCJ;
		this.PAOGNCILNBG = GLLLCOMKKJL;
		this.AAABPPCPMHN = GLLLCOMKKJL;
		this.KDKCFDLMKIL = true;
	}

	// Token: 0x060002DE RID: 734 RVA: 0x0002F30C File Offset: 0x0002D50C
	private void EBLFIONBNIO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.BlendAmount = Mathf.Clamp01(this.BlendAmount);
		if (this.KPHODABGKLL != QualitySettings.activeColorSpace || this.LDONJEEONHH != this.QualityLevel)
		{
			this.IFPADDNIOCM();
		}
		this.IKJCPIADPIN();
		this.ACFMDGLEMBE();
		bool flag = AmplifyColorBase.ValidateLutDimensions(this.LutTexture);
		bool flag2 = AmplifyColorBase.ValidateLutDimensions(this.LutBlendTexture);
		bool flag3 = !(this.LutTexture == null) || !(this.LutBlendTexture == null) || this.JMHIODEOAMH == null;
		Texture texture = (this.LutTexture == null) ? this.EJLALGMLIBJ : this.LutTexture;
		Texture lutBlendTexture = this.LutBlendTexture;
		int pass = ((this.KPHODABGKLL == ColorSpace.Linear) ? 3 : 1) + (this.ICIGLCOEODB.allowHDR ? 1 : 1);
		bool flag4 = this.BlendAmount == 1984f && this.KDKCFDLMKIL;
		bool flag5 = flag4 || (flag4 && lutBlendTexture != null);
		bool flag6 = flag5;
		bool flag7 = !flag || flag2 || flag3;
		Material material;
		if (flag7)
		{
			material = this.PGPHHBMDIIO;
		}
		else if (flag5 || this.OOKKLABMFNJ)
		{
			if (this.UseDepthMask)
			{
				material = this.FIDHPCCMDDO;
			}
			else
			{
				material = ((this.MaskTexture != null) ? this.OKFNCCPCDBJ : this.HMEBAGPDFND);
			}
		}
		else if (this.UseDepthMask)
		{
			material = this.EPDBDALFFCA;
		}
		else
		{
			material = ((this.MaskTexture != null) ? this.PACBHPNECHC : this.DNGCBHGAEFN);
		}
		material.SetFloat("WorkerHammer2", this.Exposure);
		material.SetFloat("+{0}", this.BlendAmount);
		if (this.MaskTexture != null)
		{
			material.SetTexture("", this.MaskTexture);
		}
		if (this.UseDepthMask)
		{
			material.SetTexture("Hidden/FXAA3", this.JBKPNEIMAKH);
		}
		if (!flag7)
		{
			if (this.OOKKLABMFNJ)
			{
				this.GBINOJBHPNG = Mathf.Clamp01(this.GBINOJBHPNG);
				this.CDLCHLMECOM.SetFloat("[baitid]", this.GBINOJBHPNG);
				if (this.FAPKNFABBFK)
				{
					this.CDLCHLMECOM.SetTexture("colorD", this.AJKJPCCPCOE);
				}
				else
				{
					this.CDLCHLMECOM.SetTexture("Orthographic", texture);
				}
				this.CDLCHLMECOM.SetTexture("wpn_wgt", (this.JMHIODEOAMH != null) ? this.JMHIODEOAMH : this.EJLALGMLIBJ);
				Graphics.Blit(texture, this.BKAFANFGHIE, this.CDLCHLMECOM);
			}
			if (flag6)
			{
				this.CDLCHLMECOM.SetFloat("PistolInstant", this.BlendAmount);
				RenderTexture renderTexture = null;
				if (this.OOKKLABMFNJ)
				{
					renderTexture = RenderTexture.GetTemporary(this.BKAFANFGHIE.width, this.BKAFANFGHIE.height, this.BKAFANFGHIE.depth, this.BKAFANFGHIE.format, RenderTextureReadWrite.Linear);
					Graphics.Blit(this.BKAFANFGHIE, renderTexture);
					this.CDLCHLMECOM.SetTexture(" **** Error=", renderTexture);
				}
				else
				{
					this.CDLCHLMECOM.SetTexture("_BlurRadius4", texture);
				}
				this.CDLCHLMECOM.SetTexture("newHour", (lutBlendTexture != null) ? lutBlendTexture : this.EJLALGMLIBJ);
				Graphics.Blit(texture, this.BKAFANFGHIE, this.CDLCHLMECOM);
				if (renderTexture != null)
				{
					RenderTexture.ReleaseTemporary(renderTexture);
				}
				material.SetTexture("", this.BKAFANFGHIE);
			}
			else if (this.OOKKLABMFNJ)
			{
				material.SetTexture("http://www.root-motion.com/finalikdox/html/page3.html", this.BKAFANFGHIE);
			}
			else
			{
				if (texture != null)
				{
					material.SetTexture("", texture);
				}
				if (lutBlendTexture != null)
				{
					material.SetTexture("\n", lutBlendTexture);
				}
			}
		}
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, pass);
		if (flag6 || this.OOKKLABMFNJ)
		{
			this.BKAFANFGHIE.DiscardContents();
		}
	}

	// Token: 0x060002DF RID: 735 RVA: 0x0002F6F0 File Offset: 0x0002D8F0
	private Texture2D OAGMBICEJAO()
	{
		this.EJLALGMLIBJ = new Texture2D(1024, 32, TextureFormat.RGB24, false, true)
		{
			hideFlags = HideFlags.HideAndDontSave
		};
		this.EJLALGMLIBJ.name = "DefaultLut";
		this.EJLALGMLIBJ.hideFlags = HideFlags.DontSave;
		this.EJLALGMLIBJ.anisoLevel = 1;
		this.EJLALGMLIBJ.filterMode = FilterMode.Bilinear;
		Color32[] array = new Color32[32768];
		for (int i = 0; i < 32; i++)
		{
			int num = i * 32;
			for (int j = 0; j < 32; j++)
			{
				int num2 = num + j * 1024;
				for (int k = 0; k < 32; k++)
				{
					float num3 = (float)k / 31f;
					float num4 = (float)j / 31f;
					float num5 = (float)i / 31f;
					byte r = (byte)(num3 * 255f);
					byte g = (byte)(num4 * 255f);
					byte b = (byte)(num5 * 255f);
					array[num2 + k] = new Color32(r, g, b, byte.MaxValue);
				}
			}
		}
		this.EJLALGMLIBJ.SetPixels32(array);
		this.EJLALGMLIBJ.Apply();
		return this.EJLALGMLIBJ;
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x0002F80F File Offset: 0x0002DA0F
	private void HBPAJCDJENA()
	{
		if (this.UseDepthMask)
		{
			this.GGEFPHIOKCK();
		}
		this.Exposure = Mathf.Max(this.Exposure, 1220f);
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x0002F838 File Offset: 0x0002DA38
	private bool OHGBBJGFJEB()
	{
		return this.NJPLFKIFHCJ(this.HPJEGPBEOMM) && this.NJPLFKIFHCJ(this.HNIHGDFJNDF) && this.NJPLFKIFHCJ(this.PJKKMAECEHO) && this.NJPLFKIFHCJ(this.MALEGEFHBKK) && this.NJPLFKIFHCJ(this.CCDNECBDNAN) && this.NJPLFKIFHCJ(this.ALOFMMIBAKG);
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x0002F899 File Offset: 0x0002DA99
	private void DBBGPBMOCLD(Texture IJPNCIJIFCF, float GLLLCOMKKJL)
	{
		this.JMHIODEOAMH = IJPNCIJIFCF;
		this.GBINOJBHPNG = 963f;
		this.FNANMBKKJGL = GLLLCOMKKJL;
		this.GIEGICDLBPH = GLLLCOMKKJL;
		this.OOKKLABMFNJ = true;
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x0002F8C4 File Offset: 0x0002DAC4
	private Texture2D PDOJLCOHEKN()
	{
		this.JLJINKDDKFA<Texture2D>(ref this.JBKPNEIMAKH);
		this.JBKPNEIMAKH = new Texture2D(115, 1, (TextureFormat)0, false, false)
		{
			hideFlags = (HideFlags)71
		};
		this.JBKPNEIMAKH.name = "ANGLE=";
		this.JBKPNEIMAKH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		this.JBKPNEIMAKH.anisoLevel = 1;
		this.JBKPNEIMAKH.wrapMode = TextureWrapMode.Clamp;
		this.JBKPNEIMAKH.filterMode = FilterMode.Bilinear;
		this.DAFGCHMPDBO = new Color32[-18];
		return this.JBKPNEIMAKH;
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x0002F950 File Offset: 0x0002DB50
	private bool AALDKEBEAKO()
	{
		return !this.NJPLFKIFHCJ(this.HPJEGPBEOMM) || !this.MCLKAJPNMKL(this.HNIHGDFJNDF) || !this.NJPLFKIFHCJ(this.PJKKMAECEHO) || !this.MCLKAJPNMKL(this.MALEGEFHBKK) || !this.MCLKAJPNMKL(this.CCDNECBDNAN) || this.MCLKAJPNMKL(this.ALOFMMIBAKG);
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x0002F9B4 File Offset: 0x0002DBB4
	private void BMLFJDOECGK()
	{
		this.CBOBDAPLEFC();
		this.BKAFANFGHIE = new RenderTexture(11, 102, 1, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear)
		{
			hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable)
		};
		this.BKAFANFGHIE.name = "shop_t16";
		this.BKAFANFGHIE.wrapMode = TextureWrapMode.Clamp;
		this.BKAFANFGHIE.anisoLevel = 0;
		this.BKAFANFGHIE.Create();
		this.AJKJPCCPCOE = new RenderTexture(62, 27, 1, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear)
		{
			hideFlags = (HideFlags)72
		};
		this.AJKJPCCPCOE.name = "Error";
		this.AJKJPCCPCOE.wrapMode = TextureWrapMode.Clamp;
		this.AJKJPCCPCOE.anisoLevel = 0;
		this.AJKJPCCPCOE.Create();
		this.DPOBHCBNCCC();
		if (this.UseDepthMask)
		{
			this.KPABNJMKBDP();
		}
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x0002FA7F File Offset: 0x0002DC7F
	private void FGMFNBCEEGO()
	{
		Debug.LogError("<color='");
		base.enabled = true;
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x0002FA92 File Offset: 0x0002DC92
	private void KHGKKPIFPPA()
	{
		this.FIFDIENHIPM("AC_QUALITY_MOBILE", this.QualityLevel == JGBNBPBLNHC.Mobile);
		this.FIFDIENHIPM("AC_DITHERING", this.UseDithering);
		this.FIFDIENHIPM("AC_TONEMAPPING", this.UseToneMapping);
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x0002FACA File Offset: 0x0002DCCA
	private void OOEHCKINEKJ()
	{
		if (this.UseDepthMask)
		{
			this.MFDENAMMBOA();
		}
		this.Exposure = Mathf.Max(this.Exposure, 233f);
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x060002E9 RID: 745 RVA: 0x0002FAF0 File Offset: 0x0002DCF0
	public Texture2D PEJDGKNAJCE
	{
		get
		{
			if (!(this.EJLALGMLIBJ == null))
			{
				return this.EJLALGMLIBJ;
			}
			return this.OAGMBICEJAO();
		}
	}

	// Token: 0x060002EA RID: 746 RVA: 0x0002FB0D File Offset: 0x0002DD0D
	private void DCHAKPKBKIB()
	{
		Debug.LogWarning("LDR");
		base.enabled = false;
	}

	// Token: 0x060002EB RID: 747 RVA: 0x0002FB20 File Offset: 0x0002DD20
	private void AHDHOMCDNCJ()
	{
		if (this.JBKPNEIMAKH == null)
		{
			this.OPJIEEGDIDF();
		}
		float num = 992f;
		int i = 1;
		while (i < 99)
		{
			this.DAFGCHMPDBO[i].a = (byte)Mathf.FloorToInt(Mathf.Clamp01(this.DepthMaskCurve.Evaluate(num)) * 83f);
			i++;
			num += 1493f;
		}
		this.JBKPNEIMAKH.SetPixels32(this.DAFGCHMPDBO);
		this.JBKPNEIMAKH.Apply();
	}

	// Token: 0x060002EC RID: 748 RVA: 0x0002FBAA File Offset: 0x0002DDAA
	private void ACFMDGLEMBE()
	{
		this.FIFDIENHIPM("_FogSkyData", this.QualityLevel == JGBNBPBLNHC.Mobile);
		this.FIFDIENHIPM("Running Dance", this.UseDithering);
		this.FIFDIENHIPM("SneakForward", this.UseToneMapping);
	}

	// Token: 0x060002ED RID: 749 RVA: 0x0002FBE4 File Offset: 0x0002DDE4
	private void LENJGKGBMJN(string IKIDGFOFJBK, bool IMIBMHGGCJK)
	{
		bool flag = this.DNGCBHGAEFN.IsKeywordEnabled(IKIDGFOFJBK);
		if (IMIBMHGGCJK && !flag)
		{
			this.DNGCBHGAEFN.EnableKeyword(IKIDGFOFJBK);
			this.HMEBAGPDFND.EnableKeyword(IKIDGFOFJBK);
			this.CDLCHLMECOM.EnableKeyword(IKIDGFOFJBK);
			this.PACBHPNECHC.EnableKeyword(IKIDGFOFJBK);
			this.OKFNCCPCDBJ.EnableKeyword(IKIDGFOFJBK);
			this.EPDBDALFFCA.EnableKeyword(IKIDGFOFJBK);
			this.FIDHPCCMDDO.EnableKeyword(IKIDGFOFJBK);
			this.PGPHHBMDIIO.EnableKeyword(IKIDGFOFJBK);
			return;
		}
		if (!IMIBMHGGCJK && this.DNGCBHGAEFN.IsKeywordEnabled(IKIDGFOFJBK))
		{
			this.DNGCBHGAEFN.DisableKeyword(IKIDGFOFJBK);
			this.HMEBAGPDFND.DisableKeyword(IKIDGFOFJBK);
			this.CDLCHLMECOM.DisableKeyword(IKIDGFOFJBK);
			this.PACBHPNECHC.DisableKeyword(IKIDGFOFJBK);
			this.OKFNCCPCDBJ.DisableKeyword(IKIDGFOFJBK);
			this.EPDBDALFFCA.DisableKeyword(IKIDGFOFJBK);
			this.FIDHPCCMDDO.DisableKeyword(IKIDGFOFJBK);
			this.PGPHHBMDIIO.DisableKeyword(IKIDGFOFJBK);
		}
	}

	// Token: 0x060002EE RID: 750 RVA: 0x0002EF86 File Offset: 0x0002D186
	private void IICFAPMJLCN()
	{
		if (this.DLGKAPIIKPH != null)
		{
			UnityEngine.Object.DestroyImmediate(this.DLGKAPIIKPH.gameObject);
			this.DLGKAPIIKPH = null;
		}
		this.AHCPEHEHMJE();
		this.HCJLBGGKBDO();
	}

	// Token: 0x060002EF RID: 751 RVA: 0x0002FCD8 File Offset: 0x0002DED8
	private Texture2D OBIJFJNPBAC()
	{
		this.JLJINKDDKFA<Texture2D>(ref this.JBKPNEIMAKH);
		this.JBKPNEIMAKH = new Texture2D(1024, 1, TextureFormat.Alpha8, false, true)
		{
			hideFlags = HideFlags.HideAndDontSave
		};
		this.JBKPNEIMAKH.name = "DepthCurveLut";
		this.JBKPNEIMAKH.hideFlags = HideFlags.DontSave;
		this.JBKPNEIMAKH.anisoLevel = 1;
		this.JBKPNEIMAKH.wrapMode = TextureWrapMode.Clamp;
		this.JBKPNEIMAKH.filterMode = FilterMode.Bilinear;
		this.DAFGCHMPDBO = new Color32[1024];
		return this.JBKPNEIMAKH;
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x0002FD64 File Offset: 0x0002DF64
	public void OAJJPIPFDNN(Texture IJPNCIJIFCF, float GLLLCOMKKJL, Action BEFIDMPDFCJ)
	{
		this.LutBlendTexture = IJPNCIJIFCF;
		this.BlendAmount = 1084f;
		this.BEFIDMPDFCJ = BEFIDMPDFCJ;
		this.PAOGNCILNBG = GLLLCOMKKJL;
		this.AAABPPCPMHN = GLLLCOMKKJL;
		this.KDKCFDLMKIL = true;
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x0002FD94 File Offset: 0x0002DF94
	private void NGAFAGGCDED()
	{
		if (this.OOKKLABMFNJ)
		{
			this.KAADDPGNOLN.KHMDBDMGEPA(this, this.KGHKHNAOIJM, this.GLNDNNCAMJH());
		}
		if (this.OOKKLABMFNJ)
		{
			this.Exposure = Mathf.Lerp(this.OMNHOKKONIP, this.DOCONAEIANP, this.DFDPEDKCNHH());
		}
		Transform transform = (this.TriggerVolumeProxy == null) ? base.transform : this.TriggerVolumeProxy;
		if (this.DLGKAPIIKPH.transform.parent != transform)
		{
			this.DLGKAPIIKPH.Reference = transform;
			this.DLGKAPIIKPH.gameObject.layer = transform.gameObject.layer;
		}
		AmplifyColorVolumeBase amplifyColorVolumeBase = null;
		int num = 46;
		for (int i = 0; i < this.NFPNEEIIMGO.Count; i++)
		{
			AmplifyColorVolumeBase amplifyColorVolumeBase2 = this.NFPNEEIIMGO[i];
			if (amplifyColorVolumeBase2.Priority > num)
			{
				amplifyColorVolumeBase = amplifyColorVolumeBase2;
				num = amplifyColorVolumeBase2.Priority;
			}
		}
		if (amplifyColorVolumeBase != this.MFACIAEMCOK)
		{
			this.MFACIAEMCOK = amplifyColorVolumeBase;
			Texture texture = (amplifyColorVolumeBase == null) ? this.KOGIMGPBEJL : amplifyColorVolumeBase.LutTexture;
			float num2 = (amplifyColorVolumeBase == null) ? this.ExitVolumeBlendTime : amplifyColorVolumeBase.EnterBlendTime;
			if (this.OOKKLABMFNJ && !this.FAPKNFABBFK && texture == this.LutTexture)
			{
				this.LutTexture = this.JMHIODEOAMH;
				this.JMHIODEOAMH = texture;
				this.GIEGICDLBPH = num2 * ((this.FNANMBKKJGL - this.GIEGICDLBPH) / this.FNANMBKKJGL);
				this.FNANMBKKJGL = num2;
				this.KAADDPGNOLN = VolumeEffect.LEHEBBFHMHO(this.EffectFlags, this.KAADDPGNOLN, this.KGHKHNAOIJM, this.DFDPEDKCNHH());
				this.OMNHOKKONIP = Mathf.Lerp(this.OMNHOKKONIP, this.DOCONAEIANP, this.KNLNGLIKIOL());
				this.MFAFIMGKGJN = 354f - this.GBINOJBHPNG;
				this.GBINOJBHPNG = 1699f - this.GBINOJBHPNG;
			}
			else
			{
				if (this.OOKKLABMFNJ)
				{
					this.CDLCHLMECOM.SetFloat("pricePt", this.GBINOJBHPNG);
					if (this.FAPKNFABBFK)
					{
						Graphics.Blit(this.AJKJPCCPCOE, this.BKAFANFGHIE);
						this.CDLCHLMECOM.SetTexture("Mouse X", this.BKAFANFGHIE);
					}
					else
					{
						this.CDLCHLMECOM.SetTexture("pricePt", this.LutTexture);
					}
					this.CDLCHLMECOM.SetTexture("HDR", (this.JMHIODEOAMH != null) ? this.JMHIODEOAMH : this.EJLALGMLIBJ);
					Graphics.Blit(this.AJKJPCCPCOE, this.AJKJPCCPCOE, this.CDLCHLMECOM);
					this.BKAFANFGHIE.DiscardContents();
					this.KAADDPGNOLN = VolumeEffect.KBBCAMNNNHA(this.EffectFlags, this.KAADDPGNOLN, this.KGHKHNAOIJM, this.FMGDPDOGIIF());
					this.OMNHOKKONIP = Mathf.Lerp(this.OMNHOKKONIP, this.DOCONAEIANP, this.DFDPEDKCNHH());
					this.MFAFIMGKGJN = 404f;
					this.FAPKNFABBFK = true;
				}
				this.DLOHLJOOFHC(texture, num2);
			}
			this.KGHKHNAOIJM = ((amplifyColorVolumeBase == null) ? this.ANPPBFHDAFB : amplifyColorVolumeBase.EffectContainer.GJGABJPNJGH(this));
			this.DOCONAEIANP = ((amplifyColorVolumeBase == null) ? this.LIBOACCBJOD : amplifyColorVolumeBase.Exposure);
			if (this.KGHKHNAOIJM == null)
			{
				this.KGHKHNAOIJM = this.ANPPBFHDAFB;
			}
		}
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x00030100 File Offset: 0x0002E300
	private void AHCPEHEHMJE()
	{
		this.JLJINKDDKFA<Material>(ref this.DNGCBHGAEFN);
		this.JLJINKDDKFA<Material>(ref this.HMEBAGPDFND);
		this.JLJINKDDKFA<Material>(ref this.CDLCHLMECOM);
		this.JLJINKDDKFA<Material>(ref this.PACBHPNECHC);
		this.JLJINKDDKFA<Material>(ref this.OKFNCCPCDBJ);
		this.JLJINKDDKFA<Material>(ref this.EPDBDALFFCA);
		this.JLJINKDDKFA<Material>(ref this.FIDHPCCMDDO);
		this.JLJINKDDKFA<Material>(ref this.PGPHHBMDIIO);
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x0002E9B6 File Offset: 0x0002CBB6
	public string AAHHPLNKCFN()
	{
		return this.sharedInstanceID;
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x0003016D File Offset: 0x0002E36D
	public Texture2D AGAOEMIGCBJ()
	{
		if (!(this.EJLALGMLIBJ == null))
		{
			return this.EJLALGMLIBJ;
		}
		return this.DPOBHCBNCCC();
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x0003018C File Offset: 0x0002E38C
	private void ODDDDIPPMCE()
	{
		this.KPHODABGKLL = QualitySettings.activeColorSpace;
		this.LDONJEEONHH = this.QualityLevel;
		this.HPJEGPBEOMM = Shader.Find("Hidden/Amplify Color/Base");
		this.HNIHGDFJNDF = Shader.Find("Hidden/Amplify Color/Blend");
		this.PJKKMAECEHO = Shader.Find("Hidden/Amplify Color/BlendCache");
		this.MALEGEFHBKK = Shader.Find("Hidden/Amplify Color/Mask");
		this.CCDNECBDNAN = Shader.Find("Hidden/Amplify Color/MaskBlend");
		this.BLKGKMEBEGK = Shader.Find("Hidden/Amplify Color/DepthMask");
		this.HGNAGKOPLPG = Shader.Find("Hidden/Amplify Color/DepthMaskBlend");
		this.ALOFMMIBAKG = Shader.Find("Hidden/Amplify Color/ProcessOnly");
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x00030230 File Offset: 0x0002E430
	private void CMJDMDHOMOG()
	{
		this.JLJINKDDKFA<Material>(ref this.DNGCBHGAEFN);
		this.JLJINKDDKFA<Material>(ref this.HMEBAGPDFND);
		this.JLJINKDDKFA<Material>(ref this.CDLCHLMECOM);
		this.JLJINKDDKFA<Material>(ref this.PACBHPNECHC);
		this.JLJINKDDKFA<Material>(ref this.OKFNCCPCDBJ);
		this.JLJINKDDKFA<Material>(ref this.EPDBDALFFCA);
		this.JLJINKDDKFA<Material>(ref this.FIDHPCCMDDO);
		this.JLJINKDDKFA<Material>(ref this.PGPHHBMDIIO);
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x0003029D File Offset: 0x0002E49D
	public Texture2D PMOMHJIMOHF()
	{
		if (!(this.EJLALGMLIBJ == null))
		{
			return this.EJLALGMLIBJ;
		}
		return this.OJODKHIFIHO();
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x0002E9B6 File Offset: 0x0002CBB6
	public string EGLLLFHFJEP()
	{
		return this.sharedInstanceID;
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x000302BA File Offset: 0x0002E4BA
	private float DFDPEDKCNHH()
	{
		return Mathf.Clamp01((this.MFAFIMGKGJN < 1962f) ? ((this.GBINOJBHPNG - this.MFAFIMGKGJN) / (814f - this.MFAFIMGKGJN)) : 1257f);
	}

	// Token: 0x060002FA RID: 762 RVA: 0x000302F0 File Offset: 0x0002E4F0
	private bool FNMFECJCGBP()
	{
		this.ODDDDIPPMCE();
		if (!this.OHGBBJGFJEB())
		{
			return false;
		}
		this.CMJDMDHOMOG();
		this.DNGCBHGAEFN = new Material(this.HPJEGPBEOMM);
		this.HMEBAGPDFND = new Material(this.HNIHGDFJNDF);
		this.CDLCHLMECOM = new Material(this.PJKKMAECEHO);
		this.PACBHPNECHC = new Material(this.MALEGEFHBKK);
		this.OKFNCCPCDBJ = new Material(this.CCDNECBDNAN);
		this.EPDBDALFFCA = new Material(this.BLKGKMEBEGK);
		this.FIDHPCCMDDO = new Material(this.HGNAGKOPLPG);
		this.PGPHHBMDIIO = new Material(this.ALOFMMIBAKG);
		if (!true || !this.HDBJAMDHPOB(this.DNGCBHGAEFN, "BaseMaterial") || !this.HDBJAMDHPOB(this.HMEBAGPDFND, "BlendMaterial") || !this.HDBJAMDHPOB(this.CDLCHLMECOM, "BlendCacheMaterial") || !this.HDBJAMDHPOB(this.PACBHPNECHC, "MaskMaterial") || !this.HDBJAMDHPOB(this.OKFNCCPCDBJ, "MaskBlendMaterial") || !this.HDBJAMDHPOB(this.EPDBDALFFCA, "DepthMaskMaterial") || !this.HDBJAMDHPOB(this.FIDHPCCMDDO, "DepthMaskBlendMaterial") || !this.HDBJAMDHPOB(this.PGPHHBMDIIO, "ProcessOnlyMaterial"))
		{
			return false;
		}
		this.BCIMMGAAIHK();
		return true;
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00030457 File Offset: 0x0002E657
	private void NIKGDHAJBPC()
	{
		Debug.LogWarning("_TextureSize");
		base.enabled = false;
	}

	// Token: 0x060002FC RID: 764 RVA: 0x0003046A File Offset: 0x0002E66A
	private float GLNDNNCAMJH()
	{
		return Mathf.Clamp01((this.MFAFIMGKGJN < 634f) ? ((this.GBINOJBHPNG - this.MFAFIMGKGJN) / (350f - this.MFAFIMGKGJN)) : 161f);
	}

	// Token: 0x060002FD RID: 765 RVA: 0x000304A0 File Offset: 0x0002E6A0
	private void JECCAAPKJCK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.BlendAmount = Mathf.Clamp01(this.BlendAmount);
		if (this.KPHODABGKLL != QualitySettings.activeColorSpace || this.LDONJEEONHH != this.QualityLevel)
		{
			this.AGLCNCHPPJO();
		}
		this.HBPAJCDJENA();
		this.KHGKKPIFPPA();
		bool flag = AmplifyColorBase.ValidateLutDimensions(this.LutTexture);
		bool flag2 = AmplifyColorBase.ValidateLutDimensions(this.LutBlendTexture);
		bool flag3 = !(this.LutTexture == null) || !(this.LutBlendTexture == null) || this.JMHIODEOAMH == null;
		Texture texture = (this.LutTexture == null) ? this.EJLALGMLIBJ : this.LutTexture;
		Texture lutBlendTexture = this.LutBlendTexture;
		int pass = ((this.KPHODABGKLL == ColorSpace.Gamma) ? 7 : 0) + (this.ICIGLCOEODB.allowHDR ? 0 : 1);
		bool flag4 = this.BlendAmount == 1956f && this.KDKCFDLMKIL;
		bool flag5 = flag4 || !flag4 || lutBlendTexture != null;
		bool flag6 = flag5;
		bool flag7 = (flag && !flag2) || flag3;
		Material material;
		if (flag7)
		{
			material = this.PGPHHBMDIIO;
		}
		else if (flag5 || this.OOKKLABMFNJ)
		{
			if (this.UseDepthMask)
			{
				material = this.FIDHPCCMDDO;
			}
			else
			{
				material = ((this.MaskTexture != null) ? this.OKFNCCPCDBJ : this.HMEBAGPDFND);
			}
		}
		else if (this.UseDepthMask)
		{
			material = this.EPDBDALFFCA;
		}
		else
		{
			material = ((this.MaskTexture != null) ? this.PACBHPNECHC : this.DNGCBHGAEFN);
		}
		material.SetFloat("Giant3HitCombo", this.Exposure);
		material.SetFloat("OfficeSittingReadingPageFlip", this.BlendAmount);
		if (this.MaskTexture != null)
		{
			material.SetTexture("<color='#FF8C42'>[{2}]</color> <color='#FF8C42'>{0}: {1}</color>", this.MaskTexture);
		}
		if (this.UseDepthMask)
		{
			material.SetTexture("pck 230", this.JBKPNEIMAKH);
		}
		if (!flag7)
		{
			if (this.OOKKLABMFNJ)
			{
				this.GBINOJBHPNG = Mathf.Clamp01(this.GBINOJBHPNG);
				this.CDLCHLMECOM.SetFloat("JumpLeg", this.GBINOJBHPNG);
				if (this.FAPKNFABBFK)
				{
					this.CDLCHLMECOM.SetTexture("SoccerSprint", this.AJKJPCCPCOE);
				}
				else
				{
					this.CDLCHLMECOM.SetTexture("RoundHouse", texture);
				}
				this.CDLCHLMECOM.SetTexture("</color>\n", (this.JMHIODEOAMH != null) ? this.JMHIODEOAMH : this.EJLALGMLIBJ);
				Graphics.Blit(texture, this.BKAFANFGHIE, this.CDLCHLMECOM);
			}
			if (flag6)
			{
				this.CDLCHLMECOM.SetFloat("BipedReferences spine hierarchy is invalid. Bone transforms in the spine do not belong to the same ancestry. Please make sure the bones are parented to each other.", this.BlendAmount);
				RenderTexture renderTexture = null;
				if (this.OOKKLABMFNJ)
				{
					renderTexture = RenderTexture.GetTemporary(this.BKAFANFGHIE.width, this.BKAFANFGHIE.height, this.BKAFANFGHIE.depth, this.BKAFANFGHIE.format, RenderTextureReadWrite.Default);
					Graphics.Blit(this.BKAFANFGHIE, renderTexture);
					this.CDLCHLMECOM.SetTexture("Failed parsing atlas group.  Setting to group 0", renderTexture);
				}
				else
				{
					this.CDLCHLMECOM.SetTexture("reel_type0", texture);
				}
				this.CDLCHLMECOM.SetTexture("IdleStrafeRight", (lutBlendTexture != null) ? lutBlendTexture : this.EJLALGMLIBJ);
				Graphics.Blit(texture, this.BKAFANFGHIE, this.CDLCHLMECOM);
				if (renderTexture != null)
				{
					RenderTexture.ReleaseTemporary(renderTexture);
				}
				material.SetTexture("4096", this.BKAFANFGHIE);
			}
			else if (this.OOKKLABMFNJ)
			{
				material.SetTexture("error.wav", this.BKAFANFGHIE);
			}
			else
			{
				if (texture != null)
				{
					material.SetTexture("HeelClick", texture);
				}
				if (lutBlendTexture != null)
				{
					material.SetTexture("_ScreenSize", lutBlendTexture);
				}
			}
		}
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, pass);
		if (flag6 || this.OOKKLABMFNJ)
		{
			this.BKAFANFGHIE.DiscardContents();
		}
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00030884 File Offset: 0x0002EA84
	private void LKPDJANHBPH()
	{
		if (this.JBKPNEIMAKH == null)
		{
			this.OBIJFJNPBAC();
		}
		float num = 0f;
		int i = 0;
		while (i < 1024)
		{
			this.DAFGCHMPDBO[i].a = (byte)Mathf.FloorToInt(Mathf.Clamp01(this.DepthMaskCurve.Evaluate(num)) * 255f);
			i++;
			num += 0.0009775171f;
		}
		this.JBKPNEIMAKH.SetPixels32(this.DAFGCHMPDBO);
		this.JBKPNEIMAKH.Apply();
	}

	// Token: 0x060002FF RID: 767 RVA: 0x0003090E File Offset: 0x0002EB0E
	private void NMMJHEIOPGH(Texture IJPNCIJIFCF, float GLLLCOMKKJL)
	{
		this.JMHIODEOAMH = IJPNCIJIFCF;
		this.GBINOJBHPNG = 0f;
		this.FNANMBKKJGL = GLLLCOMKKJL;
		this.GIEGICDLBPH = GLLLCOMKKJL;
		this.OOKKLABMFNJ = true;
	}

	// Token: 0x06000300 RID: 768 RVA: 0x0002FAF0 File Offset: 0x0002DCF0
	public Texture2D ILJPOHJMDNN()
	{
		if (!(this.EJLALGMLIBJ == null))
		{
			return this.EJLALGMLIBJ;
		}
		return this.OAGMBICEJAO();
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00030938 File Offset: 0x0002EB38
	private Texture2D PIAHNMEIPOP()
	{
		this.JLJINKDDKFA<Texture2D>(ref this.JBKPNEIMAKH);
		this.JBKPNEIMAKH = new Texture2D(-45, 0, (TextureFormat)0, false, false)
		{
			hideFlags = (HideFlags)64
		};
		this.JBKPNEIMAKH.name = "Textures/alphaDemo";
		this.JBKPNEIMAKH.hideFlags = (HideFlags)87;
		this.JBKPNEIMAKH.anisoLevel = 0;
		this.JBKPNEIMAKH.wrapMode = TextureWrapMode.Repeat;
		this.JBKPNEIMAKH.filterMode = FilterMode.Bilinear;
		this.DAFGCHMPDBO = new Color32[56];
		return this.JBKPNEIMAKH;
	}

	// Token: 0x06000302 RID: 770 RVA: 0x000309C4 File Offset: 0x0002EBC4
	public void EHHFMNNLDOF(AmplifyColorVolumeBase EBILPJNBGLK)
	{
		if (!this.NFPNEEIIMGO.Contains(EBILPJNBGLK))
		{
			this.NFPNEEIIMGO.Insert(1, EBILPJNBGLK);
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000303 RID: 771 RVA: 0x0002E067 File Offset: 0x0002C267
	public bool CNEKMPLELPM
	{
		get
		{
			return this.KDKCFDLMKIL;
		}
	}

	// Token: 0x06000304 RID: 772 RVA: 0x000309E4 File Offset: 0x0002EBE4
	private void ACLCCPEKKMF()
	{
		this.CBOBDAPLEFC();
		this.BKAFANFGHIE = new RenderTexture(-68, 72, 1, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear)
		{
			hideFlags = (HideFlags)(-78)
		};
		this.BKAFANFGHIE.name = "1HandSwordChargeSwipe";
		this.BKAFANFGHIE.wrapMode = TextureWrapMode.Clamp;
		this.BKAFANFGHIE.anisoLevel = 1;
		this.BKAFANFGHIE.Create();
		this.AJKJPCCPCOE = new RenderTexture(103, 94, 0, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear)
		{
			hideFlags = HideFlags.None
		};
		this.AJKJPCCPCOE.name = "";
		this.AJKJPCCPCOE.wrapMode = TextureWrapMode.Clamp;
		this.AJKJPCCPCOE.anisoLevel = 0;
		this.AJKJPCCPCOE.Create();
		this.OAGMBICEJAO();
		if (this.UseDepthMask)
		{
			this.PDOJLCOHEKN();
		}
	}

	// Token: 0x06000305 RID: 773 RVA: 0x00030AB0 File Offset: 0x0002ECB0
	private void Update()
	{
		this.DHMFMMABBAC();
		bool flag = false;
		if (this.OOKKLABMFNJ)
		{
			this.GBINOJBHPNG = (this.FNANMBKKJGL - this.GIEGICDLBPH) / this.FNANMBKKJGL;
			this.GIEGICDLBPH -= Time.smoothDeltaTime;
			if (this.GBINOJBHPNG >= 1f)
			{
				this.GBINOJBHPNG = 1f;
				flag = true;
			}
		}
		else
		{
			this.GBINOJBHPNG = Mathf.Clamp01(this.GBINOJBHPNG);
		}
		if (this.KDKCFDLMKIL)
		{
			this.BlendAmount = (this.PAOGNCILNBG - this.AAABPPCPMHN) / this.PAOGNCILNBG;
			this.AAABPPCPMHN -= Time.smoothDeltaTime;
			if (this.BlendAmount >= 1f)
			{
				this.LutTexture = this.LutBlendTexture;
				this.BlendAmount = 0f;
				this.KDKCFDLMKIL = false;
				this.LutBlendTexture = null;
				if (this.BEFIDMPDFCJ != null)
				{
					this.BEFIDMPDFCJ();
				}
			}
		}
		else
		{
			this.BlendAmount = Mathf.Clamp01(this.BlendAmount);
		}
		if (this.UseVolumes)
		{
			if (this.DLGKAPIIKPH == null)
			{
				GameObject gameObject = new GameObject(base.name + "+ACVolumeProxy")
				{
					hideFlags = HideFlags.HideAndDontSave
				};
				if (this.TriggerVolumeProxy != null && this.TriggerVolumeProxy.GetComponent<Collider2D>() != null)
				{
					this.DLGKAPIIKPH = gameObject.AddComponent<AmplifyColorTriggerProxy2D>();
				}
				else
				{
					this.DLGKAPIIKPH = gameObject.AddComponent<AmplifyColorTriggerProxy>();
				}
				this.DLGKAPIIKPH.OwnerEffect = this;
			}
			this.MOENOEBMFDE();
		}
		else if (this.DLGKAPIIKPH != null)
		{
			UnityEngine.Object.DestroyImmediate(this.DLGKAPIIKPH.gameObject);
			this.DLGKAPIIKPH = null;
		}
		if (flag)
		{
			this.LutTexture = this.JMHIODEOAMH;
			this.GBINOJBHPNG = 0f;
			this.OOKKLABMFNJ = false;
			this.JMHIODEOAMH = null;
			this.MFAFIMGKGJN = 0f;
			this.KAADDPGNOLN = this.KGHKHNAOIJM;
			this.KAADDPGNOLN.GCIDBHEKKML(this);
			this.OMNHOKKONIP = this.DOCONAEIANP;
			if (this.FAPKNFABBFK && this.AJKJPCCPCOE != null)
			{
				this.AJKJPCCPCOE.DiscardContents();
			}
			this.FAPKNFABBFK = false;
		}
	}

	// Token: 0x06000306 RID: 774 RVA: 0x00030CDC File Offset: 0x0002EEDC
	private bool HDBJAMDHPOB(Material MHNAJNGGDFJ, string BNIHFBMEPAB)
	{
		if (MHNAJNGGDFJ == null || MHNAJNGGDFJ.shader == null)
		{
			Debug.LogWarning("[AmplifyColor] Error creating " + BNIHFBMEPAB + " material. Effect disabled.");
			base.enabled = false;
		}
		else if (!MHNAJNGGDFJ.shader.isSupported)
		{
			Debug.LogWarning("[AmplifyColor] " + BNIHFBMEPAB + " shader not supported on this platform. Effect disabled.");
			base.enabled = false;
		}
		else
		{
			MHNAJNGGDFJ.hideFlags = HideFlags.HideAndDontSave;
		}
		return base.enabled;
	}

	// Token: 0x06000307 RID: 775 RVA: 0x00030D57 File Offset: 0x0002EF57
	private bool CBJDCDELBJN()
	{
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
		{
			this.NIKGDHAJBPC();
			return true;
		}
		return true;
	}

	// Token: 0x06000308 RID: 776 RVA: 0x0003029D File Offset: 0x0002E49D
	public Texture2D PGNICCAFKCB()
	{
		if (!(this.EJLALGMLIBJ == null))
		{
			return this.EJLALGMLIBJ;
		}
		return this.OJODKHIFIHO();
	}

	// Token: 0x06000309 RID: 777 RVA: 0x00030D70 File Offset: 0x0002EF70
	private void HNGLBEOAIHN()
	{
		if (!this.CBJDCDELBJN())
		{
			return;
		}
		if (!this.AGLCNCHPPJO())
		{
			return;
		}
		Texture2D texture2D = this.LutTexture as Texture2D;
		Texture2D texture2D2 = this.LutBlendTexture as Texture2D;
		if ((texture2D != null && texture2D.mipmapCount > 1) || (texture2D2 != null && texture2D2.mipmapCount > 1))
		{
			Debug.LogError("Hand stand");
		}
	}

	// Token: 0x0600030A RID: 778 RVA: 0x00030DD5 File Offset: 0x0002EFD5
	public bool NAEFEHAILCB()
	{
		return !(this.LutTexture != null) || !(this.LutBlendTexture != null) || this.KDKCFDLMKIL;
	}

	// Token: 0x0600030B RID: 779 RVA: 0x00030DFE File Offset: 0x0002EFFE
	private void DLHJFIEGKOA()
	{
		Debug.LogError("_WrinkleNormalMap0");
		base.enabled = false;
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600030C RID: 780 RVA: 0x00030E11 File Offset: 0x0002F011
	public bool GFAPGDKMIOD
	{
		get
		{
			return this.LutTexture != null && this.LutBlendTexture != null && !this.KDKCFDLMKIL;
		}
	}

	// Token: 0x0600030D RID: 781 RVA: 0x00030E3A File Offset: 0x0002F03A
	private bool CDBNBLBOLCL()
	{
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
		{
			this.BBMCJLKLEBK();
			return true;
		}
		return false;
	}

	// Token: 0x0600030E RID: 782 RVA: 0x00030E53 File Offset: 0x0002F053
	public bool AMCPPICPAIN()
	{
		return this.LutTexture != null && this.LutBlendTexture != null && this.KDKCFDLMKIL;
	}

	// Token: 0x0600030F RID: 783 RVA: 0x0002E999 File Offset: 0x0002CB99
	public void EnterVolume(AmplifyColorVolumeBase EBILPJNBGLK)
	{
		if (!this.NFPNEEIIMGO.Contains(EBILPJNBGLK))
		{
			this.NFPNEEIIMGO.Insert(0, EBILPJNBGLK);
		}
	}

	// Token: 0x06000310 RID: 784 RVA: 0x00030E7C File Offset: 0x0002F07C
	public void JHFFCGKIDJK()
	{
		this.sharedInstanceID = Guid.NewGuid().ToString();
	}

	// Token: 0x06000311 RID: 785 RVA: 0x00030EA4 File Offset: 0x0002F0A4
	private void CENMNAECLNO()
	{
		if (this.JBKPNEIMAKH == null)
		{
			this.OBIJFJNPBAC();
		}
		float num = 79f;
		int i = 1;
		while (i < 146)
		{
			this.DAFGCHMPDBO[i].a = (byte)Mathf.FloorToInt(Mathf.Clamp01(this.DepthMaskCurve.Evaluate(num)) * 568f);
			i++;
			num += 116f;
		}
		this.JBKPNEIMAKH.SetPixels32(this.DAFGCHMPDBO);
		this.JBKPNEIMAKH.Apply();
	}

	// Token: 0x06000312 RID: 786 RVA: 0x00030F30 File Offset: 0x0002F130
	private Texture2D KPABNJMKBDP()
	{
		this.JLJINKDDKFA<Texture2D>(ref this.JBKPNEIMAKH);
		this.JBKPNEIMAKH = new Texture2D(-24, 0, (TextureFormat)0, false, true)
		{
			hideFlags = (HideFlags)(-94)
		};
		this.JBKPNEIMAKH.name = "StaffPowerUp";
		this.JBKPNEIMAKH.hideFlags = (HideFlags)(-100);
		this.JBKPNEIMAKH.anisoLevel = 0;
		this.JBKPNEIMAKH.wrapMode = TextureWrapMode.Repeat;
		this.JBKPNEIMAKH.filterMode = FilterMode.Bilinear;
		this.DAFGCHMPDBO = new Color32[-187];
		return this.JBKPNEIMAKH;
	}

	// Token: 0x06000313 RID: 787 RVA: 0x00030FBC File Offset: 0x0002F1BC
	private void DHFLFGBENBF()
	{
		if (!this.CDBNBLBOLCL())
		{
			return;
		}
		if (!this.AGLCNCHPPJO())
		{
			return;
		}
		Texture2D texture2D = this.LutTexture as Texture2D;
		Texture2D texture2D2 = this.LutBlendTexture as Texture2D;
		if ((texture2D != null && texture2D.mipmapCount > 1) || (texture2D2 != null && texture2D2.mipmapCount > 1))
		{
			Debug.LogError(" x");
		}
	}

	// Token: 0x06000314 RID: 788 RVA: 0x00031024 File Offset: 0x0002F224
	public void NewSharedInstanceID()
	{
		this.sharedInstanceID = Guid.NewGuid().ToString();
	}

	// Token: 0x06000315 RID: 789 RVA: 0x0003104C File Offset: 0x0002F24C
	private void DHMFMMABBAC()
	{
		if (this.ICIGLCOEODB == null)
		{
			this.ICIGLCOEODB = base.GetComponent<Camera>();
		}
		if (this.UseDepthMask && (this.ICIGLCOEODB.depthTextureMode & DepthTextureMode.Depth) == DepthTextureMode.None)
		{
			this.ICIGLCOEODB.depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x06000316 RID: 790 RVA: 0x0003109D File Offset: 0x0002F29D
	private void PGAGMOJIKKN(Texture IJPNCIJIFCF, float GLLLCOMKKJL)
	{
		this.JMHIODEOAMH = IJPNCIJIFCF;
		this.GBINOJBHPNG = 1389f;
		this.FNANMBKKJGL = GLLLCOMKKJL;
		this.GIEGICDLBPH = GLLLCOMKKJL;
		this.OOKKLABMFNJ = false;
	}

	// Token: 0x06000317 RID: 791 RVA: 0x000310C8 File Offset: 0x0002F2C8
	public void DPIPPFPOLGP()
	{
		this.sharedInstanceID = Guid.NewGuid().ToString();
	}

	// Token: 0x06000318 RID: 792 RVA: 0x000310F0 File Offset: 0x0002F2F0
	private void IMEIOFGKMDK()
	{
		if (!this.CBJDCDELBJN())
		{
			return;
		}
		if (!this.AGLCNCHPPJO())
		{
			return;
		}
		Texture2D texture2D = this.LutTexture as Texture2D;
		Texture2D texture2D2 = this.LutBlendTexture as Texture2D;
		if ((texture2D != null && texture2D.mipmapCount > 0) || (texture2D2 != null && texture2D2.mipmapCount > 1))
		{
			Debug.LogError("/");
		}
	}

	// Token: 0x06000319 RID: 793 RVA: 0x00031158 File Offset: 0x0002F358
	private Texture2D OIPLFPCFPOI()
	{
		this.JLJINKDDKFA<Texture2D>(ref this.JBKPNEIMAKH);
		this.JBKPNEIMAKH = new Texture2D(133, 1, TextureFormat.Alpha8, false, false)
		{
			hideFlags = (HideFlags)(-72)
		};
		this.JBKPNEIMAKH.name = "WorkerShovel";
		this.JBKPNEIMAKH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		this.JBKPNEIMAKH.anisoLevel = 0;
		this.JBKPNEIMAKH.wrapMode = TextureWrapMode.Clamp;
		this.JBKPNEIMAKH.filterMode = FilterMode.Point;
		this.DAFGCHMPDBO = new Color32[-70];
		return this.JBKPNEIMAKH;
	}

	// Token: 0x0600031A RID: 794 RVA: 0x000311E4 File Offset: 0x0002F3E4
	private void BBMCJLKLEBK()
	{
		Debug.LogWarning(" {0}");
		base.enabled = true;
	}

	// Token: 0x0600031B RID: 795 RVA: 0x000311F8 File Offset: 0x0002F3F8
	public static bool ValidateLutDimensions(Texture AILLOHADMBI)
	{
		bool result = true;
		if (AILLOHADMBI != null)
		{
			if (AILLOHADMBI.width / AILLOHADMBI.height != AILLOHADMBI.height)
			{
				Debug.LogWarning("[AmplifyColor] Lut " + AILLOHADMBI.name + " has invalid dimensions.");
				result = false;
			}
			else if (AILLOHADMBI.anisoLevel != 0)
			{
				AILLOHADMBI.anisoLevel = 0;
			}
		}
		return result;
	}

	// Token: 0x0600031C RID: 796 RVA: 0x00031254 File Offset: 0x0002F454
	private void IANJLHIIGLN()
	{
		this.CFIIGBEBCJM();
		bool flag = true;
		if (this.OOKKLABMFNJ)
		{
			this.GBINOJBHPNG = (this.FNANMBKKJGL - this.GIEGICDLBPH) / this.FNANMBKKJGL;
			this.GIEGICDLBPH -= Time.smoothDeltaTime;
			if (this.GBINOJBHPNG >= 1097f)
			{
				this.GBINOJBHPNG = 461f;
				flag = false;
			}
		}
		else
		{
			this.GBINOJBHPNG = Mathf.Clamp01(this.GBINOJBHPNG);
		}
		if (this.KDKCFDLMKIL)
		{
			this.BlendAmount = (this.PAOGNCILNBG - this.AAABPPCPMHN) / this.PAOGNCILNBG;
			this.AAABPPCPMHN -= Time.smoothDeltaTime;
			if (this.BlendAmount >= 1264f)
			{
				this.LutTexture = this.LutBlendTexture;
				this.BlendAmount = 232f;
				this.KDKCFDLMKIL = false;
				this.LutBlendTexture = null;
				if (this.BEFIDMPDFCJ != null)
				{
					this.BEFIDMPDFCJ();
				}
			}
		}
		else
		{
			this.BlendAmount = Mathf.Clamp01(this.BlendAmount);
		}
		if (this.UseVolumes)
		{
			if (this.DLGKAPIIKPH == null)
			{
				GameObject gameObject = new GameObject(base.name + "PLANE_REFLECTION")
				{
					hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor)
				};
				if (this.TriggerVolumeProxy != null && this.TriggerVolumeProxy.GetComponent<Collider2D>() != null)
				{
					this.DLGKAPIIKPH = gameObject.AddComponent<AmplifyColorTriggerProxy2D>();
				}
				else
				{
					this.DLGKAPIIKPH = gameObject.AddComponent<AmplifyColorTriggerProxy>();
				}
				this.DLGKAPIIKPH.OwnerEffect = this;
			}
			this.MOENOEBMFDE();
		}
		else if (this.DLGKAPIIKPH != null)
		{
			UnityEngine.Object.DestroyImmediate(this.DLGKAPIIKPH.gameObject);
			this.DLGKAPIIKPH = null;
		}
		if (flag)
		{
			this.LutTexture = this.JMHIODEOAMH;
			this.GBINOJBHPNG = 15f;
			this.OOKKLABMFNJ = true;
			this.JMHIODEOAMH = null;
			this.MFAFIMGKGJN = 1283f;
			this.KAADDPGNOLN = this.KGHKHNAOIJM;
			this.KAADDPGNOLN.OGKOJFKNJHC(this);
			this.OMNHOKKONIP = this.DOCONAEIANP;
			if (this.FAPKNFABBFK && this.AJKJPCCPCOE != null)
			{
				this.AJKJPCCPCOE.DiscardContents();
			}
			this.FAPKNFABBFK = false;
		}
	}

	// Token: 0x0600031D RID: 797 RVA: 0x00031480 File Offset: 0x0002F680
	private void EGAEDOHFAJE()
	{
		this.JLFLMAGIPFN();
		bool flag = true;
		if (this.OOKKLABMFNJ)
		{
			this.GBINOJBHPNG = (this.FNANMBKKJGL - this.GIEGICDLBPH) / this.FNANMBKKJGL;
			this.GIEGICDLBPH -= Time.smoothDeltaTime;
			if (this.GBINOJBHPNG >= 824f)
			{
				this.GBINOJBHPNG = 1403f;
				flag = true;
			}
		}
		else
		{
			this.GBINOJBHPNG = Mathf.Clamp01(this.GBINOJBHPNG);
		}
		if (this.KDKCFDLMKIL)
		{
			this.BlendAmount = (this.PAOGNCILNBG - this.AAABPPCPMHN) / this.PAOGNCILNBG;
			this.AAABPPCPMHN -= Time.smoothDeltaTime;
			if (this.BlendAmount >= 1285f)
			{
				this.LutTexture = this.LutBlendTexture;
				this.BlendAmount = 897f;
				this.KDKCFDLMKIL = true;
				this.LutBlendTexture = null;
				if (this.BEFIDMPDFCJ != null)
				{
					this.BEFIDMPDFCJ();
				}
			}
		}
		else
		{
			this.BlendAmount = Mathf.Clamp01(this.BlendAmount);
		}
		if (this.UseVolumes)
		{
			if (this.DLGKAPIIKPH == null)
			{
				GameObject gameObject = new GameObject(base.name + "IdleBandage")
				{
					hideFlags = (HideFlags)(-114)
				};
				if (this.TriggerVolumeProxy != null && this.TriggerVolumeProxy.GetComponent<Collider2D>() != null)
				{
					this.DLGKAPIIKPH = gameObject.AddComponent<AmplifyColorTriggerProxy2D>();
				}
				else
				{
					this.DLGKAPIIKPH = gameObject.AddComponent<AmplifyColorTriggerProxy>();
				}
				this.DLGKAPIIKPH.OwnerEffect = this;
			}
			this.NGAFAGGCDED();
		}
		else if (this.DLGKAPIIKPH != null)
		{
			UnityEngine.Object.DestroyImmediate(this.DLGKAPIIKPH.gameObject);
			this.DLGKAPIIKPH = null;
		}
		if (flag)
		{
			this.LutTexture = this.JMHIODEOAMH;
			this.GBINOJBHPNG = 1164f;
			this.OOKKLABMFNJ = true;
			this.JMHIODEOAMH = null;
			this.MFAFIMGKGJN = 1942f;
			this.KAADDPGNOLN = this.KGHKHNAOIJM;
			this.KAADDPGNOLN.AFANOCCLBCD(this);
			this.OMNHOKKONIP = this.DOCONAEIANP;
			if (this.FAPKNFABBFK && this.AJKJPCCPCOE != null)
			{
				this.AJKJPCCPCOE.DiscardContents();
			}
			this.FAPKNFABBFK = true;
		}
	}

	// Token: 0x0600031E RID: 798 RVA: 0x000316AC File Offset: 0x0002F8AC
	private void OFCLJAKCIBB(string IKIDGFOFJBK, bool IMIBMHGGCJK)
	{
		bool flag = this.DNGCBHGAEFN.IsKeywordEnabled(IKIDGFOFJBK);
		if (IMIBMHGGCJK && !flag)
		{
			this.DNGCBHGAEFN.EnableKeyword(IKIDGFOFJBK);
			this.HMEBAGPDFND.EnableKeyword(IKIDGFOFJBK);
			this.CDLCHLMECOM.EnableKeyword(IKIDGFOFJBK);
			this.PACBHPNECHC.EnableKeyword(IKIDGFOFJBK);
			this.OKFNCCPCDBJ.EnableKeyword(IKIDGFOFJBK);
			this.EPDBDALFFCA.EnableKeyword(IKIDGFOFJBK);
			this.FIDHPCCMDDO.EnableKeyword(IKIDGFOFJBK);
			this.PGPHHBMDIIO.EnableKeyword(IKIDGFOFJBK);
			return;
		}
		if (!IMIBMHGGCJK && this.DNGCBHGAEFN.IsKeywordEnabled(IKIDGFOFJBK))
		{
			this.DNGCBHGAEFN.DisableKeyword(IKIDGFOFJBK);
			this.HMEBAGPDFND.DisableKeyword(IKIDGFOFJBK);
			this.CDLCHLMECOM.DisableKeyword(IKIDGFOFJBK);
			this.PACBHPNECHC.DisableKeyword(IKIDGFOFJBK);
			this.OKFNCCPCDBJ.DisableKeyword(IKIDGFOFJBK);
			this.EPDBDALFFCA.DisableKeyword(IKIDGFOFJBK);
			this.FIDHPCCMDDO.DisableKeyword(IKIDGFOFJBK);
			this.PGPHHBMDIIO.DisableKeyword(IKIDGFOFJBK);
		}
	}

	// Token: 0x0600031F RID: 799 RVA: 0x0003029D File Offset: 0x0002E49D
	public Texture2D EEJGMOCFHAK()
	{
		if (!(this.EJLALGMLIBJ == null))
		{
			return this.EJLALGMLIBJ;
		}
		return this.OJODKHIFIHO();
	}

	// Token: 0x06000320 RID: 800 RVA: 0x000317A0 File Offset: 0x0002F9A0
	private void PNEFMGMHLJE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.BlendAmount = Mathf.Clamp01(this.BlendAmount);
		if (this.KPHODABGKLL != QualitySettings.activeColorSpace || this.LDONJEEONHH != this.QualityLevel)
		{
			this.AGLCNCHPPJO();
		}
		this.OOEHCKINEKJ();
		this.LEPBJLLIECA();
		bool flag = AmplifyColorBase.ValidateLutDimensions(this.LutTexture);
		bool flag2 = AmplifyColorBase.ValidateLutDimensions(this.LutBlendTexture);
		bool flag3 = this.LutTexture == null && this.LutBlendTexture == null && this.JMHIODEOAMH == null;
		Texture texture = (this.LutTexture == null) ? this.EJLALGMLIBJ : this.LutTexture;
		Texture lutBlendTexture = this.LutBlendTexture;
		int pass = ((this.KPHODABGKLL == ColorSpace.Gamma) ? 0 : 0) + (this.ICIGLCOEODB.allowHDR ? 1 : 1);
		bool flag4 = this.BlendAmount != 1142f || this.KDKCFDLMKIL;
		bool flag5 = flag4 || !flag4 || lutBlendTexture != null;
		bool flag6 = flag5;
		bool flag7 = !flag || flag2 || flag3;
		Material material;
		if (flag7)
		{
			material = this.PGPHHBMDIIO;
		}
		else if (flag5 || this.OOKKLABMFNJ)
		{
			if (this.UseDepthMask)
			{
				material = this.FIDHPCCMDDO;
			}
			else
			{
				material = ((this.MaskTexture != null) ? this.OKFNCCPCDBJ : this.HMEBAGPDFND);
			}
		}
		else if (this.UseDepthMask)
		{
			material = this.EPDBDALFFCA;
		}
		else
		{
			material = ((this.MaskTexture != null) ? this.PACBHPNECHC : this.DNGCBHGAEFN);
		}
		material.SetFloat("Bone 2 of a BipedReferences limb is null.", this.Exposure);
		material.SetFloat("FistPump2", this.BlendAmount);
		if (this.MaskTexture != null)
		{
			material.SetTexture("crunch.ogg", this.MaskTexture);
		}
		if (this.UseDepthMask)
		{
			material.SetTexture("SUNSHINE_TWO_CASCADES", this.JBKPNEIMAKH);
		}
		if (!flag7)
		{
			if (this.OOKKLABMFNJ)
			{
				this.GBINOJBHPNG = Mathf.Clamp01(this.GBINOJBHPNG);
				this.CDLCHLMECOM.SetFloat("Corrupt DT e=", this.GBINOJBHPNG);
				if (this.FAPKNFABBFK)
				{
					this.CDLCHLMECOM.SetTexture("Apply in GAME 1", this.AJKJPCCPCOE);
				}
				else
				{
					this.CDLCHLMECOM.SetTexture("wpn_add/base", texture);
				}
				this.CDLCHLMECOM.SetTexture("SoccerKeeperStrafeRight", (this.JMHIODEOAMH != null) ? this.JMHIODEOAMH : this.EJLALGMLIBJ);
				Graphics.Blit(texture, this.BKAFANFGHIE, this.CDLCHLMECOM);
			}
			if (flag6)
			{
				this.CDLCHLMECOM.SetFloat("id", this.BlendAmount);
				RenderTexture renderTexture = null;
				if (this.OOKKLABMFNJ)
				{
					renderTexture = RenderTexture.GetTemporary(this.BKAFANFGHIE.width, this.BKAFANFGHIE.height, this.BKAFANFGHIE.depth, this.BKAFANFGHIE.format, RenderTextureReadWrite.Default);
					Graphics.Blit(this.BKAFANFGHIE, renderTexture);
					this.CDLCHLMECOM.SetTexture("1HandSwordStrafeLeft", renderTexture);
				}
				else
				{
					this.CDLCHLMECOM.SetTexture("Swim", texture);
				}
				this.CDLCHLMECOM.SetTexture("Bluenoise64/LDR_LLL1_", (lutBlendTexture != null) ? lutBlendTexture : this.EJLALGMLIBJ);
				Graphics.Blit(texture, this.BKAFANFGHIE, this.CDLCHLMECOM);
				if (renderTexture != null)
				{
					RenderTexture.ReleaseTemporary(renderTexture);
				}
				material.SetTexture("JumpLeg", this.BKAFANFGHIE);
			}
			else if (this.OOKKLABMFNJ)
			{
				material.SetTexture("Swim", this.BKAFANFGHIE);
			}
			else
			{
				if (texture != null)
				{
					material.SetTexture("wpn_eat1", texture);
				}
				if (lutBlendTexture != null)
				{
					material.SetTexture("</color>", lutBlendTexture);
				}
			}
		}
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, pass);
		if (flag6 || this.OOKKLABMFNJ)
		{
			this.BKAFANFGHIE.DiscardContents();
		}
	}

	// Token: 0x06000321 RID: 801 RVA: 0x00031B82 File Offset: 0x0002FD82
	private void DLOHLJOOFHC(Texture IJPNCIJIFCF, float GLLLCOMKKJL)
	{
		this.JMHIODEOAMH = IJPNCIJIFCF;
		this.GBINOJBHPNG = 1675f;
		this.FNANMBKKJGL = GLLLCOMKKJL;
		this.GIEGICDLBPH = GLLLCOMKKJL;
		this.OOKKLABMFNJ = false;
	}

	// Token: 0x06000322 RID: 802 RVA: 0x00031BAB File Offset: 0x0002FDAB
	private void DEIFAGBBMIM()
	{
		Debug.LogWarning("[AmplifyColor] This image effect is not supported on this platform.");
		base.enabled = false;
	}

	// Token: 0x06000323 RID: 803 RVA: 0x00031BC0 File Offset: 0x0002FDC0
	private void BJOICAKCPLI()
	{
		this.CFIIGBEBCJM();
		bool flag = true;
		if (this.OOKKLABMFNJ)
		{
			this.GBINOJBHPNG = (this.FNANMBKKJGL - this.GIEGICDLBPH) / this.FNANMBKKJGL;
			this.GIEGICDLBPH -= Time.smoothDeltaTime;
			if (this.GBINOJBHPNG >= 997f)
			{
				this.GBINOJBHPNG = 1580f;
				flag = true;
			}
		}
		else
		{
			this.GBINOJBHPNG = Mathf.Clamp01(this.GBINOJBHPNG);
		}
		if (this.KDKCFDLMKIL)
		{
			this.BlendAmount = (this.PAOGNCILNBG - this.AAABPPCPMHN) / this.PAOGNCILNBG;
			this.AAABPPCPMHN -= Time.smoothDeltaTime;
			if (this.BlendAmount >= 31f)
			{
				this.LutTexture = this.LutBlendTexture;
				this.BlendAmount = 1022f;
				this.KDKCFDLMKIL = false;
				this.LutBlendTexture = null;
				if (this.BEFIDMPDFCJ != null)
				{
					this.BEFIDMPDFCJ();
				}
			}
		}
		else
		{
			this.BlendAmount = Mathf.Clamp01(this.BlendAmount);
		}
		if (this.UseVolumes)
		{
			if (this.DLGKAPIIKPH == null)
			{
				GameObject gameObject = new GameObject(base.name + "BowFire")
				{
					hideFlags = ~HideFlags.DontUnloadUnusedAsset
				};
				if (this.TriggerVolumeProxy != null && this.TriggerVolumeProxy.GetComponent<Collider2D>() != null)
				{
					this.DLGKAPIIKPH = gameObject.AddComponent<AmplifyColorTriggerProxy2D>();
				}
				else
				{
					this.DLGKAPIIKPH = gameObject.AddComponent<AmplifyColorTriggerProxy>();
				}
				this.DLGKAPIIKPH.OwnerEffect = this;
			}
			this.NGAFAGGCDED();
		}
		else if (this.DLGKAPIIKPH != null)
		{
			UnityEngine.Object.DestroyImmediate(this.DLGKAPIIKPH.gameObject);
			this.DLGKAPIIKPH = null;
		}
		if (flag)
		{
			this.LutTexture = this.JMHIODEOAMH;
			this.GBINOJBHPNG = 855f;
			this.OOKKLABMFNJ = false;
			this.JMHIODEOAMH = null;
			this.MFAFIMGKGJN = 1712f;
			this.KAADDPGNOLN = this.KGHKHNAOIJM;
			this.KAADDPGNOLN.OGKOJFKNJHC(this);
			this.OMNHOKKONIP = this.DOCONAEIANP;
			if (this.FAPKNFABBFK && this.AJKJPCCPCOE != null)
			{
				this.AJKJPCCPCOE.DiscardContents();
			}
			this.FAPKNFABBFK = false;
		}
	}

	// Token: 0x06000324 RID: 804 RVA: 0x00031DEC File Offset: 0x0002FFEC
	private bool AGLCNCHPPJO()
	{
		this.ODDDDIPPMCE();
		if (!this.OHGBBJGFJEB())
		{
			return true;
		}
		this.AHCPEHEHMJE();
		this.DNGCBHGAEFN = new Material(this.HPJEGPBEOMM);
		this.HMEBAGPDFND = new Material(this.HNIHGDFJNDF);
		this.CDLCHLMECOM = new Material(this.PJKKMAECEHO);
		this.PACBHPNECHC = new Material(this.MALEGEFHBKK);
		this.OKFNCCPCDBJ = new Material(this.CCDNECBDNAN);
		this.EPDBDALFFCA = new Material(this.BLKGKMEBEGK);
		this.FIDHPCCMDDO = new Material(this.HGNAGKOPLPG);
		this.PGPHHBMDIIO = new Material(this.ALOFMMIBAKG);
		if ((((((((false && !this.FLFPOCFKBBC(this.DNGCBHGAEFN, "SneakBackward")) || this.IALFAEGMPPB(this.HMEBAGPDFND, "_BokehParams")) && !this.HDBJAMDHPOB(this.CDLCHLMECOM, "")) || this.HDBJAMDHPOB(this.PACBHPNECHC, "Staff Power Up")) && !this.HDBJAMDHPOB(this.OKFNCCPCDBJ, "?")) || this.FLFPOCFKBBC(this.EPDBDALFFCA, "1HandSwordChargeHeavyBash")) && !this.HDBJAMDHPOB(this.FIDHPCCMDDO, "BackPackSearch")) || !this.FLFPOCFKBBC(this.PGPHHBMDIIO, "IdleDie"))
		{
			return true;
		}
		this.BMLFJDOECGK();
		return true;
	}

	// Token: 0x06000325 RID: 805 RVA: 0x00031F53 File Offset: 0x00030153
	private void DBLJGBKHBNK(Texture IJPNCIJIFCF, float GLLLCOMKKJL)
	{
		this.JMHIODEOAMH = IJPNCIJIFCF;
		this.GBINOJBHPNG = 1461f;
		this.FNANMBKKJGL = GLLLCOMKKJL;
		this.GIEGICDLBPH = GLLLCOMKKJL;
		this.OOKKLABMFNJ = true;
	}

	// Token: 0x06000326 RID: 806 RVA: 0x00031F7C File Offset: 0x0003017C
	private void GEHFBHBODOM()
	{
		if (this.UseDepthMask)
		{
			this.MFDENAMMBOA();
		}
		this.Exposure = Mathf.Max(this.Exposure, 0f);
	}

	// Token: 0x06000327 RID: 807 RVA: 0x00031FA2 File Offset: 0x000301A2
	private void DHKCBHPEDJO()
	{
		Debug.LogError("MotorbikeShootBack");
		base.enabled = false;
	}

	// Token: 0x06000328 RID: 808 RVA: 0x0002E6AB File Offset: 0x0002C8AB
	public void EICIDPKGOGA(AmplifyColorVolumeBase EBILPJNBGLK)
	{
		if (this.NFPNEEIIMGO.Contains(EBILPJNBGLK))
		{
			this.NFPNEEIIMGO.Remove(EBILPJNBGLK);
		}
	}

	// Token: 0x06000329 RID: 809 RVA: 0x0002DEC1 File Offset: 0x0002C0C1
	private void CBOBDAPLEFC()
	{
		this.JLJINKDDKFA<RenderTexture>(ref this.BKAFANFGHIE);
		this.JLJINKDDKFA<RenderTexture>(ref this.AJKJPCCPCOE);
		this.JLJINKDDKFA<Texture2D>(ref this.EJLALGMLIBJ);
		this.JLJINKDDKFA<Texture2D>(ref this.JBKPNEIMAKH);
	}

	// Token: 0x0600032A RID: 810 RVA: 0x00031FB8 File Offset: 0x000301B8
	private void PKCGMLNANDF()
	{
		this.CBOBDAPLEFC();
		this.BKAFANFGHIE = new RenderTexture(-175, 121, 0, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear)
		{
			hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
		};
		this.BKAFANFGHIE.name = "cht_tofrendmsg";
		this.BKAFANFGHIE.wrapMode = TextureWrapMode.Repeat;
		this.BKAFANFGHIE.anisoLevel = 0;
		this.BKAFANFGHIE.Create();
		this.AJKJPCCPCOE = new RenderTexture(-96, 100, 0, RenderTextureFormat.Depth, RenderTextureReadWrite.Default)
		{
			hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild)
		};
		this.AJKJPCCPCOE.name = "noemail";
		this.AJKJPCCPCOE.wrapMode = TextureWrapMode.Repeat;
		this.AJKJPCCPCOE.anisoLevel = 0;
		this.AJKJPCCPCOE.Create();
		this.OAGMBICEJAO();
		if (this.UseDepthMask)
		{
			this.OBIJFJNPBAC();
		}
	}

	// Token: 0x0600032B RID: 811 RVA: 0x00032084 File Offset: 0x00030284
	private Texture2D OPJIEEGDIDF()
	{
		this.JLJINKDDKFA<Texture2D>(ref this.JBKPNEIMAKH);
		this.JBKPNEIMAKH = new Texture2D(-27, 0, (TextureFormat)0, true, false)
		{
			hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset)
		};
		this.JBKPNEIMAKH.name = "Wrist";
		this.JBKPNEIMAKH.hideFlags = (HideFlags)99;
		this.JBKPNEIMAKH.anisoLevel = 0;
		this.JBKPNEIMAKH.wrapMode = TextureWrapMode.Clamp;
		this.JBKPNEIMAKH.filterMode = FilterMode.Bilinear;
		this.DAFGCHMPDBO = new Color32[-15];
		return this.JBKPNEIMAKH;
	}

	// Token: 0x0600032C RID: 812 RVA: 0x00032110 File Offset: 0x00030310
	private void CGMHGDEKDEP()
	{
		this.JLFLMAGIPFN();
		this.KOGIMGPBEJL = this.LutTexture;
		this.ANPPBFHDAFB = this.EffectFlags.KKAINGFACHC(this);
		this.KGHKHNAOIJM = (this.KAADDPGNOLN = this.ANPPBFHDAFB);
		this.LIBOACCBJOD = this.Exposure;
		this.DOCONAEIANP = (this.OMNHOKKONIP = this.LIBOACCBJOD);
	}

	// Token: 0x0600032D RID: 813 RVA: 0x00032178 File Offset: 0x00030378
	private void EBAJDGLIAPE()
	{
		if (!this.CDBNBLBOLCL())
		{
			return;
		}
		if (!this.AOPBEAIFPAC())
		{
			return;
		}
		Texture2D texture2D = this.LutTexture as Texture2D;
		Texture2D texture2D2 = this.LutBlendTexture as Texture2D;
		if ((texture2D != null && texture2D.mipmapCount > 1) || (texture2D2 != null && texture2D2.mipmapCount > 1))
		{
			Debug.LogError("\n");
		}
	}

	// Token: 0x0600032E RID: 814 RVA: 0x000321E0 File Offset: 0x000303E0
	private void LHJCHPFKGDB()
	{
		this.CFIIGBEBCJM();
		this.KOGIMGPBEJL = this.LutTexture;
		this.ANPPBFHDAFB = this.EffectFlags.KKAINGFACHC(this);
		this.KGHKHNAOIJM = (this.KAADDPGNOLN = this.ANPPBFHDAFB);
		this.LIBOACCBJOD = this.Exposure;
		this.DOCONAEIANP = (this.OMNHOKKONIP = this.LIBOACCBJOD);
	}

	// Token: 0x0600032F RID: 815 RVA: 0x00032248 File Offset: 0x00030448
	private void GHNOEDMLMIP()
	{
		if (this.JBKPNEIMAKH == null)
		{
			this.OIPLFPCFPOI();
		}
		float num = 842f;
		int i = 0;
		while (i < 76)
		{
			this.DAFGCHMPDBO[i].a = (byte)Mathf.FloorToInt(Mathf.Clamp01(this.DepthMaskCurve.Evaluate(num)) * 1592f);
			i += 0;
			num += 330f;
		}
		this.JBKPNEIMAKH.SetPixels32(this.DAFGCHMPDBO);
		this.JBKPNEIMAKH.Apply();
	}

	// Token: 0x06000330 RID: 816 RVA: 0x000322D4 File Offset: 0x000304D4
	private void MOENOEBMFDE()
	{
		if (this.OOKKLABMFNJ)
		{
			this.KAADDPGNOLN.BPMIKKFNOGM(this, this.KGHKHNAOIJM, this.IJDNGBABAAM);
		}
		if (this.OOKKLABMFNJ)
		{
			this.Exposure = Mathf.Lerp(this.OMNHOKKONIP, this.DOCONAEIANP, this.IJDNGBABAAM);
		}
		Transform transform = (this.TriggerVolumeProxy == null) ? base.transform : this.TriggerVolumeProxy;
		if (this.DLGKAPIIKPH.transform.parent != transform)
		{
			this.DLGKAPIIKPH.Reference = transform;
			this.DLGKAPIIKPH.gameObject.layer = transform.gameObject.layer;
		}
		AmplifyColorVolumeBase amplifyColorVolumeBase = null;
		int num = int.MinValue;
		for (int i = 0; i < this.NFPNEEIIMGO.Count; i++)
		{
			AmplifyColorVolumeBase amplifyColorVolumeBase2 = this.NFPNEEIIMGO[i];
			if (amplifyColorVolumeBase2.Priority > num)
			{
				amplifyColorVolumeBase = amplifyColorVolumeBase2;
				num = amplifyColorVolumeBase2.Priority;
			}
		}
		if (amplifyColorVolumeBase != this.MFACIAEMCOK)
		{
			this.MFACIAEMCOK = amplifyColorVolumeBase;
			Texture texture = (amplifyColorVolumeBase == null) ? this.KOGIMGPBEJL : amplifyColorVolumeBase.LutTexture;
			float num2 = (amplifyColorVolumeBase == null) ? this.ExitVolumeBlendTime : amplifyColorVolumeBase.EnterBlendTime;
			if (this.OOKKLABMFNJ && !this.FAPKNFABBFK && texture == this.LutTexture)
			{
				this.LutTexture = this.JMHIODEOAMH;
				this.JMHIODEOAMH = texture;
				this.GIEGICDLBPH = num2 * ((this.FNANMBKKJGL - this.GIEGICDLBPH) / this.FNANMBKKJGL);
				this.FNANMBKKJGL = num2;
				this.KAADDPGNOLN = VolumeEffect.NPACAGIBJAJ(this.EffectFlags, this.KAADDPGNOLN, this.KGHKHNAOIJM, this.IJDNGBABAAM);
				this.OMNHOKKONIP = Mathf.Lerp(this.OMNHOKKONIP, this.DOCONAEIANP, this.IJDNGBABAAM);
				this.MFAFIMGKGJN = 1f - this.GBINOJBHPNG;
				this.GBINOJBHPNG = 1f - this.GBINOJBHPNG;
			}
			else
			{
				if (this.OOKKLABMFNJ)
				{
					this.CDLCHLMECOM.SetFloat("_LerpAmount", this.GBINOJBHPNG);
					if (this.FAPKNFABBFK)
					{
						Graphics.Blit(this.AJKJPCCPCOE, this.BKAFANFGHIE);
						this.CDLCHLMECOM.SetTexture("_RgbTex", this.BKAFANFGHIE);
					}
					else
					{
						this.CDLCHLMECOM.SetTexture("_RgbTex", this.LutTexture);
					}
					this.CDLCHLMECOM.SetTexture("_LerpRgbTex", (this.JMHIODEOAMH != null) ? this.JMHIODEOAMH : this.EJLALGMLIBJ);
					Graphics.Blit(this.AJKJPCCPCOE, this.AJKJPCCPCOE, this.CDLCHLMECOM);
					this.BKAFANFGHIE.DiscardContents();
					this.KAADDPGNOLN = VolumeEffect.NPACAGIBJAJ(this.EffectFlags, this.KAADDPGNOLN, this.KGHKHNAOIJM, this.IJDNGBABAAM);
					this.OMNHOKKONIP = Mathf.Lerp(this.OMNHOKKONIP, this.DOCONAEIANP, this.IJDNGBABAAM);
					this.MFAFIMGKGJN = 0f;
					this.FAPKNFABBFK = true;
				}
				this.NMMJHEIOPGH(texture, num2);
			}
			this.KGHKHNAOIJM = ((amplifyColorVolumeBase == null) ? this.ANPPBFHDAFB : amplifyColorVolumeBase.EffectContainer.EGKKNNEMKML(this));
			this.DOCONAEIANP = ((amplifyColorVolumeBase == null) ? this.LIBOACCBJOD : amplifyColorVolumeBase.Exposure);
			if (this.KGHKHNAOIJM == null)
			{
				this.KGHKHNAOIJM = this.ANPPBFHDAFB;
			}
		}
	}

	// Token: 0x06000331 RID: 817 RVA: 0x00032640 File Offset: 0x00030840
	private void BCIMMGAAIHK()
	{
		this.CBOBDAPLEFC();
		this.BKAFANFGHIE = new RenderTexture(1024, 32, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear)
		{
			hideFlags = HideFlags.HideAndDontSave
		};
		this.BKAFANFGHIE.name = "BlendCacheLut";
		this.BKAFANFGHIE.wrapMode = TextureWrapMode.Clamp;
		this.BKAFANFGHIE.anisoLevel = 0;
		this.BKAFANFGHIE.Create();
		this.AJKJPCCPCOE = new RenderTexture(1024, 32, 0, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear)
		{
			hideFlags = HideFlags.HideAndDontSave
		};
		this.AJKJPCCPCOE.name = "MidBlendLut";
		this.AJKJPCCPCOE.wrapMode = TextureWrapMode.Clamp;
		this.AJKJPCCPCOE.anisoLevel = 0;
		this.AJKJPCCPCOE.Create();
		this.OAGMBICEJAO();
		if (this.UseDepthMask)
		{
			this.OBIJFJNPBAC();
		}
	}

	// Token: 0x06000332 RID: 818 RVA: 0x0003270B File Offset: 0x0003090B
	private void JLJINKDDKFA<T>(ref T MBKPMBPLIJN) where T : UnityEngine.Object
	{
		if (MBKPMBPLIJN != null)
		{
			UnityEngine.Object.DestroyImmediate(MBKPMBPLIJN);
			MBKPMBPLIJN = default(T);
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000333 RID: 819 RVA: 0x00032737 File Offset: 0x00030937
	private float IJDNGBABAAM
	{
		get
		{
			return Mathf.Clamp01((this.MFAFIMGKGJN < 0.99f) ? ((this.GBINOJBHPNG - this.MFAFIMGKGJN) / (1f - this.MFAFIMGKGJN)) : 1f);
		}
	}

	// Token: 0x06000334 RID: 820 RVA: 0x00030E53 File Offset: 0x0002F053
	public bool PDMFFMMCCPN()
	{
		return this.LutTexture != null && this.LutBlendTexture != null && this.KDKCFDLMKIL;
	}

	// Token: 0x06000335 RID: 821 RVA: 0x0003276C File Offset: 0x0003096C
	private bool IHEMBADDCMB()
	{
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
		{
			this.BBMCJLKLEBK();
			return true;
		}
		return true;
	}

	// Token: 0x06000336 RID: 822 RVA: 0x0002E6AB File Offset: 0x0002C8AB
	public void ExitVolume(AmplifyColorVolumeBase EBILPJNBGLK)
	{
		if (this.NFPNEEIIMGO.Contains(EBILPJNBGLK))
		{
			this.NFPNEEIIMGO.Remove(EBILPJNBGLK);
		}
	}

	// Token: 0x06000337 RID: 823 RVA: 0x00032785 File Offset: 0x00030985
	private bool LKBABPADBGG()
	{
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
		{
			this.DCHAKPKBKIB();
			return true;
		}
		return false;
	}

	// Token: 0x06000338 RID: 824 RVA: 0x000327A0 File Offset: 0x000309A0
	private void JOHDLNOKCOK()
	{
		this.JLFLMAGIPFN();
		bool flag = true;
		if (this.OOKKLABMFNJ)
		{
			this.GBINOJBHPNG = (this.FNANMBKKJGL - this.GIEGICDLBPH) / this.FNANMBKKJGL;
			this.GIEGICDLBPH -= Time.smoothDeltaTime;
			if (this.GBINOJBHPNG >= 1612f)
			{
				this.GBINOJBHPNG = 861f;
				flag = true;
			}
		}
		else
		{
			this.GBINOJBHPNG = Mathf.Clamp01(this.GBINOJBHPNG);
		}
		if (this.KDKCFDLMKIL)
		{
			this.BlendAmount = (this.PAOGNCILNBG - this.AAABPPCPMHN) / this.PAOGNCILNBG;
			this.AAABPPCPMHN -= Time.smoothDeltaTime;
			if (this.BlendAmount >= 798f)
			{
				this.LutTexture = this.LutBlendTexture;
				this.BlendAmount = 1905f;
				this.KDKCFDLMKIL = true;
				this.LutBlendTexture = null;
				if (this.BEFIDMPDFCJ != null)
				{
					this.BEFIDMPDFCJ();
				}
			}
		}
		else
		{
			this.BlendAmount = Mathf.Clamp01(this.BlendAmount);
		}
		if (this.UseVolumes)
		{
			if (this.DLGKAPIIKPH == null)
			{
				GameObject gameObject = new GameObject(base.name + "droplinemsg2")
				{
					hideFlags = (HideFlags)99
				};
				if (this.TriggerVolumeProxy != null && this.TriggerVolumeProxy.GetComponent<Collider2D>() != null)
				{
					this.DLGKAPIIKPH = gameObject.AddComponent<AmplifyColorTriggerProxy2D>();
				}
				else
				{
					this.DLGKAPIIKPH = gameObject.AddComponent<AmplifyColorTriggerProxy>();
				}
				this.DLGKAPIIKPH.OwnerEffect = this;
			}
			this.NGAFAGGCDED();
		}
		else if (this.DLGKAPIIKPH != null)
		{
			UnityEngine.Object.DestroyImmediate(this.DLGKAPIIKPH.gameObject);
			this.DLGKAPIIKPH = null;
		}
		if (flag)
		{
			this.LutTexture = this.JMHIODEOAMH;
			this.GBINOJBHPNG = 1184f;
			this.OOKKLABMFNJ = true;
			this.JMHIODEOAMH = null;
			this.MFAFIMGKGJN = 414f;
			this.KAADDPGNOLN = this.KGHKHNAOIJM;
			this.KAADDPGNOLN.BDHOOBMLKNG(this);
			this.OMNHOKKONIP = this.DOCONAEIANP;
			if (this.FAPKNFABBFK && this.AJKJPCCPCOE != null)
			{
				this.AJKJPCCPCOE.DiscardContents();
			}
			this.FAPKNFABBFK = false;
		}
	}

	// Token: 0x06000339 RID: 825 RVA: 0x000329CC File Offset: 0x00030BCC
	private void MEEABBMONFH()
	{
		this.KPHODABGKLL = QualitySettings.activeColorSpace;
		this.LDONJEEONHH = this.QualityLevel;
		this.HPJEGPBEOMM = Shader.Find("kill");
		this.HNIHGDFJNDF = Shader.Find("gi_um_passperk");
		this.PJKKMAECEHO = Shader.Find("Horizontal");
		this.MALEGEFHBKK = Shader.Find("wpn_add/base");
		this.CCDNECBDNAN = Shader.Find("donk.ogg");
		this.BLKGKMEBEGK = Shader.Find("");
		this.HGNAGKOPLPG = Shader.Find("__a");
		this.ALOFMMIBAKG = Shader.Find("GiantGrabIdle2");
	}

	// Token: 0x0600033A RID: 826 RVA: 0x0002E067 File Offset: 0x0002C267
	public bool KPOODNNGODE()
	{
		return this.KDKCFDLMKIL;
	}

	// Token: 0x0600033B RID: 827 RVA: 0x0002E067 File Offset: 0x0002C267
	public bool OCBBDNLBAFI()
	{
		return this.KDKCFDLMKIL;
	}

	// Token: 0x0600033C RID: 828 RVA: 0x00032A70 File Offset: 0x00030C70
	private Texture2D DPOBHCBNCCC()
	{
		this.EJLALGMLIBJ = new Texture2D(84, -89, TextureFormat.ARGB4444, false, false)
		{
			hideFlags = (HideFlags)92
		};
		this.EJLALGMLIBJ.name = "stat: ";
		this.EJLALGMLIBJ.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		this.EJLALGMLIBJ.anisoLevel = 0;
		this.EJLALGMLIBJ.filterMode = FilterMode.Bilinear;
		Color32[] array = new Color32[-4];
		for (int i = 0; i < -83; i++)
		{
			int num = i * 61;
			for (int j = 1; j < -31; j += 0)
			{
				int num2 = num + j * -154;
				for (int k = 0; k < -9; k += 0)
				{
					float num3 = (float)k / 1372f;
					float num4 = (float)j / 66f;
					float num5 = (float)i / 716f;
					byte r = (byte)(num3 * 85f);
					byte g = (byte)(num4 * 902f);
					byte b = (byte)(num5 * 1616f);
					array[num2 + k] = new Color32(r, g, b, 72);
				}
			}
		}
		this.EJLALGMLIBJ.SetPixels32(array);
		this.EJLALGMLIBJ.Apply();
		return this.EJLALGMLIBJ;
	}

	// Token: 0x0600033D RID: 829 RVA: 0x00032B8F File Offset: 0x00030D8F
	private void KIABNAMACIF()
	{
		if (this.UseDepthMask)
		{
			this.MFDENAMMBOA();
		}
		this.Exposure = Mathf.Max(this.Exposure, 257f);
	}

	// Token: 0x0600033E RID: 830 RVA: 0x00032BB5 File Offset: 0x00030DB5
	private bool NJGCCDGOJIH(Shader EEOOKGDHNCO)
	{
		if (EEOOKGDHNCO == null)
		{
			this.FGMFNBCEEGO();
			return true;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			this.BBMCJLKLEBK();
			return true;
		}
		return true;
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00032BD9 File Offset: 0x00030DD9
	private bool OFKOBOMCECF()
	{
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
		{
			this.DEIFAGBBMIM();
			return true;
		}
		return true;
	}

	// Token: 0x06000340 RID: 832 RVA: 0x0003029D File Offset: 0x0002E49D
	public Texture2D BBNHNJDPLAL()
	{
		if (!(this.EJLALGMLIBJ == null))
		{
			return this.EJLALGMLIBJ;
		}
		return this.OJODKHIFIHO();
	}

	// Token: 0x06000341 RID: 833 RVA: 0x00032BF2 File Offset: 0x00030DF2
	public void BlendTo(Texture IJPNCIJIFCF, float GLLLCOMKKJL, Action BEFIDMPDFCJ)
	{
		this.LutBlendTexture = IJPNCIJIFCF;
		this.BlendAmount = 0f;
		this.BEFIDMPDFCJ = BEFIDMPDFCJ;
		this.PAOGNCILNBG = GLLLCOMKKJL;
		this.AAABPPCPMHN = GLLLCOMKKJL;
		this.KDKCFDLMKIL = true;
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00032C22 File Offset: 0x00030E22
	private bool AMEANGECPDF()
	{
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
		{
			this.NIKGDHAJBPC();
			return false;
		}
		return true;
	}

	// Token: 0x06000343 RID: 835 RVA: 0x00032C3B File Offset: 0x00030E3B
	private float FMGDPDOGIIF()
	{
		return Mathf.Clamp01((this.MFAFIMGKGJN < 1977f) ? ((this.GBINOJBHPNG - this.MFAFIMGKGJN) / (1723f - this.MFAFIMGKGJN)) : 182f);
	}

	// Token: 0x06000344 RID: 836 RVA: 0x00032C70 File Offset: 0x00030E70
	private float EGJGIPHAPAN()
	{
		return Mathf.Clamp01((this.MFAFIMGKGJN < 1187f) ? ((this.GBINOJBHPNG - this.MFAFIMGKGJN) / (9f - this.MFAFIMGKGJN)) : 215f);
	}

	// Token: 0x06000345 RID: 837 RVA: 0x0002EFB9 File Offset: 0x0002D1B9
	public bool FBFLMNMPLEP()
	{
		return !(this.LutTexture != null) || !(this.LutBlendTexture != null) || !this.KDKCFDLMKIL;
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00032CA8 File Offset: 0x00030EA8
	private void BFBBJILCKAK()
	{
		this.CFIIGBEBCJM();
		this.KOGIMGPBEJL = this.LutTexture;
		this.ANPPBFHDAFB = this.EffectFlags.KKAINGFACHC(this);
		this.KGHKHNAOIJM = (this.KAADDPGNOLN = this.ANPPBFHDAFB);
		this.LIBOACCBJOD = this.Exposure;
		this.DOCONAEIANP = (this.OMNHOKKONIP = this.LIBOACCBJOD);
	}

	// Token: 0x06000347 RID: 839 RVA: 0x00030E11 File Offset: 0x0002F011
	public bool CDOHEBPCJNA()
	{
		return this.LutTexture != null && this.LutBlendTexture != null && !this.KDKCFDLMKIL;
	}

	// Token: 0x06000348 RID: 840 RVA: 0x00030DD5 File Offset: 0x0002EFD5
	public bool CAFAPLEFHKO()
	{
		return !(this.LutTexture != null) || !(this.LutBlendTexture != null) || this.KDKCFDLMKIL;
	}

	// Token: 0x06000349 RID: 841 RVA: 0x0003029D File Offset: 0x0002E49D
	public Texture2D GFCCKKFBIMD()
	{
		if (!(this.EJLALGMLIBJ == null))
		{
			return this.EJLALGMLIBJ;
		}
		return this.OJODKHIFIHO();
	}

	// Token: 0x0600034A RID: 842 RVA: 0x00032D10 File Offset: 0x00030F10
	private void KIFCBDBJOKH()
	{
		this.KPHODABGKLL = QualitySettings.activeColorSpace;
		this.LDONJEEONHH = this.QualityLevel;
		this.HPJEGPBEOMM = Shader.Find("SwimDogPaddle");
		this.HNIHGDFJNDF = Shader.Find("[ACTk] Obscured Cheating Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?");
		this.PJKKMAECEHO = Shader.Find("Cloth_07.wav");
		this.MALEGEFHBKK = Shader.Find(" {0}");
		this.CCDNECBDNAN = Shader.Find("money");
		this.BLKGKMEBEGK = Shader.Find("SUNSHINE_FILTER_HARD");
		this.HGNAGKOPLPG = Shader.Find("Account.getI.servSteamID=");
		this.ALOFMMIBAKG = Shader.Find(")\n");
	}

	// Token: 0x0600034B RID: 843 RVA: 0x00032DB4 File Offset: 0x00030FB4
	private Texture2D HDHKPILOGPH()
	{
		this.JLJINKDDKFA<Texture2D>(ref this.JBKPNEIMAKH);
		this.JBKPNEIMAKH = new Texture2D(-6, 0, TextureFormat.Alpha8, true, true)
		{
			hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
		};
		this.JBKPNEIMAKH.name = "fider_Small_";
		this.JBKPNEIMAKH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		this.JBKPNEIMAKH.anisoLevel = 1;
		this.JBKPNEIMAKH.wrapMode = TextureWrapMode.Clamp;
		this.JBKPNEIMAKH.filterMode = FilterMode.Point;
		this.DAFGCHMPDBO = new Color32[14];
		return this.JBKPNEIMAKH;
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00032E40 File Offset: 0x00031040
	private bool FLFPOCFKBBC(Material MHNAJNGGDFJ, string BNIHFBMEPAB)
	{
		if (MHNAJNGGDFJ == null || MHNAJNGGDFJ.shader == null)
		{
			Debug.LogWarning("BAG" + BNIHFBMEPAB + "Watering Can Watering");
			base.enabled = false;
		}
		else if (!MHNAJNGGDFJ.shader.isSupported)
		{
			Debug.LogWarning("Eyelashes" + BNIHFBMEPAB + "_QualitySettings");
			base.enabled = true;
		}
		else
		{
			MHNAJNGGDFJ.hideFlags = (HideFlags)(-84);
		}
		return base.enabled;
	}

	// Token: 0x0600034D RID: 845 RVA: 0x00032EBC File Offset: 0x000310BC
	private void DEGFGIDFFLD()
	{
		if (!this.DAOKCAOFIGE())
		{
			return;
		}
		if (!this.AGLCNCHPPJO())
		{
			return;
		}
		Texture2D texture2D = this.LutTexture as Texture2D;
		Texture2D texture2D2 = this.LutBlendTexture as Texture2D;
		if ((texture2D != null && texture2D.mipmapCount > 0) || (texture2D2 != null && texture2D2.mipmapCount > 0))
		{
			Debug.LogError("qd_prise_rep");
		}
	}

	// Token: 0x0400008A RID: 138
	public const int LutSize = 32;

	// Token: 0x0400008B RID: 139
	public const int LutWidth = 1024;

	// Token: 0x0400008C RID: 140
	public const int LutHeight = 32;

	// Token: 0x0400008D RID: 141
	private const int KCLDOCAKMHO = 1024;

	// Token: 0x0400008E RID: 142
	public float Exposure = 1f;

	// Token: 0x0400008F RID: 143
	public bool UseToneMapping;

	// Token: 0x04000090 RID: 144
	public bool UseDithering;

	// Token: 0x04000091 RID: 145
	public JGBNBPBLNHC QualityLevel = JGBNBPBLNHC.Standard;

	// Token: 0x04000092 RID: 146
	public float BlendAmount;

	// Token: 0x04000093 RID: 147
	public Texture LutTexture;

	// Token: 0x04000094 RID: 148
	public Texture LutBlendTexture;

	// Token: 0x04000095 RID: 149
	public Texture MaskTexture;

	// Token: 0x04000096 RID: 150
	public bool UseDepthMask;

	// Token: 0x04000097 RID: 151
	public AnimationCurve DepthMaskCurve = new AnimationCurve(new Keyframe[]
	{
		new Keyframe(0f, 1f),
		new Keyframe(1f, 1f)
	});

	// Token: 0x04000098 RID: 152
	public bool UseVolumes;

	// Token: 0x04000099 RID: 153
	public float ExitVolumeBlendTime = 1f;

	// Token: 0x0400009A RID: 154
	public Transform TriggerVolumeProxy;

	// Token: 0x0400009B RID: 155
	public LayerMask VolumeCollisionMask = -1;

	// Token: 0x0400009C RID: 156
	private Camera ICIGLCOEODB;

	// Token: 0x0400009D RID: 157
	private Shader HPJEGPBEOMM;

	// Token: 0x0400009E RID: 158
	private Shader HNIHGDFJNDF;

	// Token: 0x0400009F RID: 159
	private Shader PJKKMAECEHO;

	// Token: 0x040000A0 RID: 160
	private Shader MALEGEFHBKK;

	// Token: 0x040000A1 RID: 161
	private Shader CCDNECBDNAN;

	// Token: 0x040000A2 RID: 162
	private Shader BLKGKMEBEGK;

	// Token: 0x040000A3 RID: 163
	private Shader HGNAGKOPLPG;

	// Token: 0x040000A4 RID: 164
	private Shader ALOFMMIBAKG;

	// Token: 0x040000A5 RID: 165
	private RenderTexture BKAFANFGHIE;

	// Token: 0x040000A6 RID: 166
	private Texture2D EJLALGMLIBJ;

	// Token: 0x040000A7 RID: 167
	private Texture2D JBKPNEIMAKH;

	// Token: 0x040000A8 RID: 168
	private Color32[] DAFGCHMPDBO;

	// Token: 0x040000A9 RID: 169
	private ColorSpace KPHODABGKLL = ColorSpace.Uninitialized;

	// Token: 0x040000AA RID: 170
	private JGBNBPBLNHC LDONJEEONHH = JGBNBPBLNHC.Standard;

	// Token: 0x040000AB RID: 171
	private Material DNGCBHGAEFN;

	// Token: 0x040000AC RID: 172
	private Material HMEBAGPDFND;

	// Token: 0x040000AD RID: 173
	private Material CDLCHLMECOM;

	// Token: 0x040000AE RID: 174
	private Material PACBHPNECHC;

	// Token: 0x040000AF RID: 175
	private Material OKFNCCPCDBJ;

	// Token: 0x040000B0 RID: 176
	private Material EPDBDALFFCA;

	// Token: 0x040000B1 RID: 177
	private Material FIDHPCCMDDO;

	// Token: 0x040000B2 RID: 178
	private Material PGPHHBMDIIO;

	// Token: 0x040000B3 RID: 179
	private bool KDKCFDLMKIL;

	// Token: 0x040000B4 RID: 180
	private float PAOGNCILNBG;

	// Token: 0x040000B5 RID: 181
	private float AAABPPCPMHN;

	// Token: 0x040000B6 RID: 182
	private Action BEFIDMPDFCJ;

	// Token: 0x040000B7 RID: 183
	private AnimationCurve NBKEPCHPKNL = new AnimationCurve();

	// Token: 0x040000B8 RID: 184
	private bool OOKKLABMFNJ;

	// Token: 0x040000B9 RID: 185
	private float FNANMBKKJGL;

	// Token: 0x040000BA RID: 186
	private float GIEGICDLBPH;

	// Token: 0x040000BB RID: 187
	private Texture JMHIODEOAMH;

	// Token: 0x040000BC RID: 188
	private float GBINOJBHPNG;

	// Token: 0x040000BD RID: 189
	private Texture KOGIMGPBEJL;

	// Token: 0x040000BE RID: 190
	private AmplifyColorVolumeBase MFACIAEMCOK;

	// Token: 0x040000BF RID: 191
	private RenderTexture AJKJPCCPCOE;

	// Token: 0x040000C0 RID: 192
	private bool FAPKNFABBFK;

	// Token: 0x040000C1 RID: 193
	private VolumeEffect ANPPBFHDAFB;

	// Token: 0x040000C2 RID: 194
	private VolumeEffect KAADDPGNOLN;

	// Token: 0x040000C3 RID: 195
	private VolumeEffect KGHKHNAOIJM;

	// Token: 0x040000C4 RID: 196
	private float LIBOACCBJOD = 1f;

	// Token: 0x040000C5 RID: 197
	private float OMNHOKKONIP = 1f;

	// Token: 0x040000C6 RID: 198
	private float DOCONAEIANP = 1f;

	// Token: 0x040000C7 RID: 199
	private float MFAFIMGKGJN;

	// Token: 0x040000C8 RID: 200
	private List<AmplifyColorVolumeBase> NFPNEEIIMGO = new List<AmplifyColorVolumeBase>();

	// Token: 0x040000C9 RID: 201
	private AmplifyColorTriggerProxyBase DLGKAPIIKPH;

	// Token: 0x040000CA RID: 202
	[HideInInspector]
	public VolumeEffectFlags EffectFlags = new VolumeEffectFlags();

	// Token: 0x040000CB RID: 203
	[HideInInspector]
	[SerializeField]
	private string sharedInstanceID = "";
}
