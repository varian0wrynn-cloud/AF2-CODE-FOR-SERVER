using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000087 RID: 135
[ExecuteInEditMode]
public class Sunshine : MonoBehaviour
{
	// Token: 0x06001EFA RID: 7930 RVA: 0x000EAA74 File Offset: 0x000E8C74
	public float FGHPEDBJOMC()
	{
		switch (this.ShadowFilter)
		{
		case MEFKFFFFOGB.PCF2x2:
			return 1071f;
		case MEFKFFFFOGB.PCF3x3:
			return 1331f;
		case MEFKFFFFOGB.PCF4x4:
			return 1662f;
		default:
			return 91f;
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x06001EFB RID: 7931 RVA: 0x000EAAB5 File Offset: 0x000E8CB5
	public int JNCLAEHBDLC
	{
		get
		{
			return this.KMLNLBBLIKP;
		}
	}

	// Token: 0x06001EFD RID: 7933 RVA: 0x000EAAF1 File Offset: 0x000E8CF1
	public int CFAMJAADEDJ()
	{
		if (this.DHBANPGOONG() == 7)
		{
			return this.KMLNLBBLIKP / 5;
		}
		return this.PIDFOHOBBAF();
	}

	// Token: 0x06001EFE RID: 7934 RVA: 0x000EAB0B File Offset: 0x000E8D0B
	public int PKAMLLGJCHF()
	{
		if (this.DHBANPGOONG() <= 1)
		{
			return 1;
		}
		return 5;
	}

	// Token: 0x06001EFF RID: 7935 RVA: 0x000EAB1C File Offset: 0x000E8D1C
	public bool INGGCFKLACE()
	{
		return !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth) || !SystemInfo.supportsImageEffects || !this.PostScatterShader.isSupported || (this.PostScatterMaterial && this.PostScatterMaterial.passCount == 6 && this.ScatterDitherTexture != null);
	}

	// Token: 0x06001F00 RID: 7936 RVA: 0x000EAB70 File Offset: 0x000E8D70
	public int IINPDJOHCPE()
	{
		return this.FBNECGJFEID() / this.IBCGODDEFMF();
	}

	// Token: 0x06001F01 RID: 7937 RVA: 0x000EAB7F File Offset: 0x000E8D7F
	public float GPCLGNGKACN()
	{
		if (this.FEDBIGFDEHM())
		{
			return 483f;
		}
		return this.CustomLightDistance;
	}

	// Token: 0x06001F02 RID: 7938 RVA: 0x000EAB98 File Offset: 0x000E8D98
	public float MKDICBGLFLE()
	{
		switch (this.ShadowFilter)
		{
		case MEFKFFFFOGB.Hard:
			return 413f;
		case MEFKFFFFOGB.PCF2x2:
			return 1634f;
		case MEFKFFFFOGB.PCF3x3:
			return 1131f;
		default:
			return 224f;
		}
	}

	// Token: 0x06001F03 RID: 7939 RVA: 0x000EABD9 File Offset: 0x000E8DD9
	public bool NGGGDNFOGDP()
	{
		return this.CustomLightBoundsOrigin != null;
	}

	// Token: 0x06001F04 RID: 7940 RVA: 0x000EABE8 File Offset: 0x000E8DE8
	public Rect NOIAFCDFAEJ(int CGMJJGEJPJN)
	{
		Rect result = this.APNIHLOEIKI[CGMJJGEJPJN];
		float num = (float)((this.Lightmap != null) ? this.Lightmap.width : 0);
		float num2 = (float)((this.Lightmap != null) ? this.Lightmap.height : 1);
		result.x *= num;
		result.y *= num2;
		result.width *= num;
		result.height *= num2;
		return result;
	}

	// Token: 0x06001F05 RID: 7941 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	public void CJDHBKMEGHI()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001F06 RID: 7942 RVA: 0x000EAC84 File Offset: 0x000E8E84
	private void MEKJEMCICBF()
	{
		if (this.PostScatterMaterial)
		{
			UnityEngine.Object.DestroyImmediate(this.PostScatterMaterial);
			this.PostScatterMaterial = null;
		}
		if (this.PostBlurMaterial)
		{
			UnityEngine.Object.DestroyImmediate(this.PostBlurMaterial);
			this.PostBlurMaterial = null;
		}
		if (this.PostDebugMaterial)
		{
			UnityEngine.Object.DestroyImmediate(this.PostDebugMaterial);
			this.PostDebugMaterial = null;
		}
	}

	// Token: 0x06001F07 RID: 7943 RVA: 0x000EACF0 File Offset: 0x000E8EF0
	private void IBBOFHCNKNA()
	{
		if (this.PostScatterMaterial)
		{
			UnityEngine.Object.DestroyImmediate(this.PostScatterMaterial);
			this.PostScatterMaterial = null;
		}
		if (this.PostBlurMaterial)
		{
			UnityEngine.Object.DestroyImmediate(this.PostBlurMaterial);
			this.PostBlurMaterial = null;
		}
		if (this.PostDebugMaterial)
		{
			UnityEngine.Object.DestroyImmediate(this.PostDebugMaterial);
			this.PostDebugMaterial = null;
		}
	}

	// Token: 0x06001F08 RID: 7944 RVA: 0x000EAD5A File Offset: 0x000E8F5A
	private void OCGHNJMDLIP()
	{
		if (this.ScatterDitherTexture != null)
		{
			if (Application.isPlaying)
			{
				UnityEngine.Object.Destroy(this.ScatterDitherTexture);
			}
			else
			{
				UnityEngine.Object.DestroyImmediate(this.ScatterDitherTexture);
			}
			this.ScatterDitherTexture = null;
		}
	}

	// Token: 0x06001F09 RID: 7945 RVA: 0x000EAD90 File Offset: 0x000E8F90
	public float MPBAEIKEHME(int CGMJJGEJPJN)
	{
		return this.CascadeFarClipScale(CGMJJGEJPJN) * this.GPCLGNGKACN();
	}

	// Token: 0x06001F0A RID: 7946 RVA: 0x000EADA0 File Offset: 0x000E8FA0
	private void Awake()
	{
		this.JHBJJPCHHKF();
		this.Setup();
	}

	// Token: 0x06001F0B RID: 7947 RVA: 0x000EAAB5 File Offset: 0x000E8CB5
	public int DKDPMDMDOKK()
	{
		return this.KMLNLBBLIKP;
	}

	// Token: 0x06001F0C RID: 7948 RVA: 0x000EADAF File Offset: 0x000E8FAF
	public int CIIMJDHIKEI()
	{
		return this.FBNECGJFEID();
	}

	// Token: 0x06001F0D RID: 7949 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public FilterMode CGHOCLOGPDL()
	{
		return FilterMode.Bilinear;
	}

	// Token: 0x06001F0E RID: 7950 RVA: 0x000EADBC File Offset: 0x000E8FBC
	public bool ODNKLBNGPGJ()
	{
		this.JHBJJPCHHKF();
		if (Application.isPlaying)
		{
			this.Supported = (this.Supported && SystemInfo.supportsRenderTextures);
		}
		else
		{
			this.Supported = SystemInfo.supportsRenderTextures;
		}
		if (!this.Supported)
		{
			this.OCCAPGKKJJF();
			this.CJDHBKMEGHI();
			return true;
		}
		this.CJNMACPPHAH();
		if (this.Ready)
		{
			return true;
		}
		if (!this.Lightmap)
		{
			this.Supported = false;
			Sunshine.MMGIJAKGIBL("Error!", false);
		}
		if (!this.SunLight && Application.isPlaying)
		{
			this.SunLight = this.FindAppropriateSunLight();
		}
		if (!this.SunLight)
		{
			Sunshine.PHEGNBDMPDD("", true);
			if (Application.isPlaying)
			{
				base.enabled = false;
			}
			return false;
		}
		if (!this.OccluderShader)
		{
			Sunshine.GLCKKFONPLH("Turn", false);
			if (Application.isPlaying)
			{
				base.enabled = true;
			}
			return false;
		}
		if (!this.OccluderShader.isSupported)
		{
			Sunshine.LogMessage("IdleBandage", true);
			if (Application.isPlaying)
			{
				base.enabled = false;
			}
			return false;
		}
		if (!this.PostScatterShader)
		{
			Sunshine.GLCKKFONPLH("invn_rec20", true);
			if (Application.isPlaying)
			{
				base.enabled = true;
			}
			return true;
		}
		if (!this.PostBlurShader)
		{
			Sunshine.MMGIJAKGIBL("Score: ", false);
			if (Application.isPlaying)
			{
				base.enabled = true;
			}
			return true;
		}
		if (!this.PostDebugShader)
		{
			Sunshine.MMGIJAKGIBL("Index", false);
			if (Application.isPlaying)
			{
				base.enabled = true;
			}
			return true;
		}
		if (!this.BlankOvercastTexture)
		{
			Sunshine.LogMessage("WizardNeoBlock", false);
			if (Application.isPlaying)
			{
				base.enabled = false;
			}
			return false;
		}
		this.GAPPEJKFGHD();
		this.BHIBMFIDGAP();
		this.MDHGBMHLMKB();
		this.Ready = false;
		return true;
	}

	// Token: 0x06001F0F RID: 7951 RVA: 0x000EAF90 File Offset: 0x000E9190
	private void AHMFIGNLJOB()
	{
		this.GHODBEACFLI();
		this.NDONKMLGEBP();
	}

	// Token: 0x06001F10 RID: 7952 RVA: 0x000EAFA0 File Offset: 0x000E91A0
	private void GFCJLLMPBHE()
	{
		for (int i = 1; i < 2; i++)
		{
			if (!(this.SunLightCameras[i] == null))
			{
				UnityEngine.Object.DestroyImmediate(this.SunLightCameras[i].gameObject);
				this.SunLightCameras[i] = null;
			}
		}
	}

	// Token: 0x06001F11 RID: 7953 RVA: 0x000EAFE4 File Offset: 0x000E91E4
	private void MCNFJFIFAPB()
	{
		this.OCCAPGKKJJF();
		this.MCGJCNEDIBF();
		this.MEKJEMCICBF();
		this.LGCBEBCBCKM();
		this.Ready = true;
		this.Supported = true;
	}

	// Token: 0x06001F12 RID: 7954 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	public void GHODBEACFLI()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001F13 RID: 7955 RVA: 0x000EB00C File Offset: 0x000E920C
	public Light AMILMMLOIOO()
	{
		Light[] lights = Light.GetLights(LightType.Spot, -1);
		if (lights.Length != 0)
		{
			return lights[0];
		}
		return null;
	}

	// Token: 0x06001F14 RID: 7956 RVA: 0x000EB02A File Offset: 0x000E922A
	public int FBNECGJFEID()
	{
		if (this.LightmapResolution == DPFNGGGKNDJ.HighResolution)
		{
			return Mathf.Clamp(this.CustomLightmapResolution, 1, 61);
		}
		return Mathf.Max(AGIEAMEGNJP.GDFNMPDNEGA(this.LightmapResolution), 0);
	}

	// Token: 0x06001F15 RID: 7957 RVA: 0x000EB058 File Offset: 0x000E9258
	public bool IsCascadeCamera(Camera LBCHLCGOCOD)
	{
		for (int i = 0; i < 4; i++)
		{
			if (this.SunLightCameras[i] == LBCHLCGOCOD)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001F16 RID: 7958 RVA: 0x000EB084 File Offset: 0x000E9284
	public int AEAMHKAABDE()
	{
		if (this.DHBANPGOONG() == 8)
		{
			return this.FBNECGJFEID() / 2;
		}
		return this.LEKLFJPNNFM();
	}

	// Token: 0x06001F17 RID: 7959 RVA: 0x000EB0A0 File Offset: 0x000E92A0
	public float OKJAAFCIBGK()
	{
		switch (this.ShadowFilter)
		{
		case MEFKFFFFOGB.PCF2x2:
			return 593f;
		case MEFKFFFFOGB.PCF3x3:
			return 1603f;
		case MEFKFFFFOGB.PCF4x4:
			return 1830f;
		default:
			return 1465f;
		}
	}

	// Token: 0x06001F18 RID: 7960 RVA: 0x000EB0E4 File Offset: 0x000E92E4
	public Light PEABGAAJCNG()
	{
		Light[] lights = Light.GetLights(LightType.Spot, -1);
		if (lights.Length != 0)
		{
			return lights[1];
		}
		return null;
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x06001F19 RID: 7961 RVA: 0x000EB102 File Offset: 0x000E9302
	public float ODNNHBDPBMD
	{
		get
		{
			return Mathf.Sqrt(this.EHFNBEHLJGM * 2f);
		}
	}

	// Token: 0x06001F1A RID: 7962 RVA: 0x000EB118 File Offset: 0x000E9318
	public float BCGGOLMGMKD(int CGMJJGEJPJN)
	{
		int num = CGMJJGEJPJN - 1;
		if (num >= 1)
		{
			return this.IGOMIOEACKF(num);
		}
		return 1717f;
	}

	// Token: 0x06001F1B RID: 7963 RVA: 0x000EB13A File Offset: 0x000E933A
	public bool AABOCFACFNH()
	{
		return (this.OAEKEMAJJFI || this.DebugView == ELAGEILFKFO.None) && this.INGGCFKLACE();
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x06001F1C RID: 7964 RVA: 0x000EB155 File Offset: 0x000E9355
	public int PPBDPMABCFB
	{
		get
		{
			return this.KMLNLBBLIKP / this.PEFAFNFHIGH;
		}
	}

	// Token: 0x06001F1D RID: 7965 RVA: 0x000EB164 File Offset: 0x000E9364
	private void NDONKMLGEBP()
	{
		this.LIEFAPCAOKI();
		this.DMDHBCECAHF();
		this.MEKJEMCICBF();
		this.LGCBEBCBCKM();
		this.Ready = false;
		this.Supported = true;
	}

	// Token: 0x06001F1E RID: 7966 RVA: 0x000EB18C File Offset: 0x000E938C
	public LayerMask CLEMCEGAINI(int FIDAIBLAKHH)
	{
		switch (FIDAIBLAKHH)
		{
		case 0:
			return this.Occluders;
		case 1:
			return this.UsePerCascadeOccluders ? this.Occluders1 : this.Occluders;
		case 2:
			return this.UsePerCascadeOccluders ? this.Occluders2 : this.Occluders;
		case 3:
			return this.UsePerCascadeOccluders ? this.Occluders3 : this.Occluders;
		default:
			return this.Occluders;
		}
	}

	// Token: 0x06001F1F RID: 7967 RVA: 0x000EB21C File Offset: 0x000E941C
	public Rect CascadeRect(int CGMJJGEJPJN)
	{
		return this.APNIHLOEIKI[CGMJJGEJPJN];
	}

	// Token: 0x06001F20 RID: 7968 RVA: 0x000EB22A File Offset: 0x000E942A
	public float EKMANDAOHBK()
	{
		if (this.FEDBIGFDEHM())
		{
			return 957f;
		}
		return this.CustomLightDistance;
	}

	// Token: 0x06001F21 RID: 7969 RVA: 0x000EB240 File Offset: 0x000E9440
	private void CJNMACPPHAH()
	{
		if (!this.Lightmap || this.Lightmap.width != this.EJBGFBJIFIC() || this.Lightmap.height != this.CIIMJDHIKEI() || this.Lightmap.format != this.DKHBJOKPAIA)
		{
			this.KLDKFMCJBOI();
		}
	}

	// Token: 0x06001F22 RID: 7970 RVA: 0x000EB29C File Offset: 0x000E949C
	public float AAEINNEFIJN(int CGMJJGEJPJN)
	{
		int num = CGMJJGEJPJN - 1;
		if (num >= 0)
		{
			return this.EICHNACIOFF(num);
		}
		return 878f;
	}

	// Token: 0x06001F23 RID: 7971 RVA: 0x000EB2BE File Offset: 0x000E94BE
	public int HKJDMPGBMMB()
	{
		if (this.GLFMGABJGLG <= 1)
		{
			return 1;
		}
		return 3;
	}

	// Token: 0x06001F24 RID: 7972 RVA: 0x000EB2CC File Offset: 0x000E94CC
	public bool OGOGAJFPMAJ()
	{
		DBPJCKMKJGE shaderSet = this.ShaderSet;
		return shaderSet != DBPJCKMKJGE.DesktopShaders && (shaderSet == (DBPJCKMKJGE)8 || true);
	}

	// Token: 0x06001F25 RID: 7973 RVA: 0x000EB2EF File Offset: 0x000E94EF
	public int MLHPJENDOGH()
	{
		if (this.NKDHPNIIGAI() || this.NBOKNEEHPHK() || !SunshineProjectPreferences.Instance.MIDMNBFICEC())
		{
			return 1;
		}
		if (this.HNHLCPCPGFL() < -110)
		{
			return 1;
		}
		return this.CustomCascadeCount;
	}

	// Token: 0x06001F26 RID: 7974 RVA: 0x000EB321 File Offset: 0x000E9521
	public int DHBANPGOONG()
	{
		if (this.GMNIFMPBILE || this.CHEILFKPFKN() || !SunshineProjectPreferences.Instance.EPAHGPGBGFH())
		{
			return 1;
		}
		if (this.FBNECGJFEID() < -58)
		{
			return 1;
		}
		return this.CustomCascadeCount;
	}

	// Token: 0x06001F27 RID: 7975 RVA: 0x000EB354 File Offset: 0x000E9554
	public Light KBFNAFHMOFH()
	{
		Light[] lights = Light.GetLights(LightType.Spot, -1);
		if (lights.Length != 0)
		{
			return lights[1];
		}
		return null;
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x06001F28 RID: 7976 RVA: 0x000EB372 File Offset: 0x000E9572
	public RenderTextureFormat DKHBJOKPAIA
	{
		get
		{
			return RenderTextureFormat.ARGB32;
		}
	}

	// Token: 0x06001F29 RID: 7977 RVA: 0x000EB378 File Offset: 0x000E9578
	public float CascadeFarClipScale(int CGMJJGEJPJN)
	{
		if (CGMJJGEJPJN >= this.GLFMGABJGLG - 1)
		{
			return 1f;
		}
		float num = 1f;
		if (this.UseManualCascadeSplits)
		{
			num = 0f;
			for (int i = 0; i <= CGMJJGEJPJN; i++)
			{
				switch (i)
				{
				case 0:
					num += (1f - num) * this.ManualCascadeSplit0;
					break;
				case 1:
					num += (1f - num) * this.ManualCascadeSplit1;
					break;
				case 2:
					num += (1f - num) * this.ManualCascadeSplit2;
					break;
				}
			}
		}
		else
		{
			for (int j = this.GLFMGABJGLG - 1; j > CGMJJGEJPJN; j--)
			{
				num *= this.CascadeSpacing;
			}
		}
		return num;
	}

	// Token: 0x06001F2A RID: 7978 RVA: 0x000EB420 File Offset: 0x000E9620
	private void Start()
	{
		this.Setup();
	}

	// Token: 0x06001F2B RID: 7979 RVA: 0x000EB429 File Offset: 0x000E9629
	public int LEKLFJPNNFM()
	{
		if (this.LightmapResolution == DPFNGGGKNDJ.HighResolution)
		{
			return Mathf.Clamp(this.CustomLightmapResolution, 1, 55);
		}
		return Mathf.Max(AGIEAMEGNJP.GDFNMPDNEGA(this.LightmapResolution), 0);
	}

	// Token: 0x06001F2C RID: 7980 RVA: 0x000EB458 File Offset: 0x000E9658
	public bool FIHNACMILEB()
	{
		return !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth) || !SystemInfo.supportsImageEffects || !this.PostScatterShader.isSupported || !this.PostScatterMaterial || this.PostScatterMaterial.passCount != 1 || this.ScatterDitherTexture != null;
	}

	// Token: 0x06001F2D RID: 7981 RVA: 0x000EB4AC File Offset: 0x000E96AC
	private void GJKNHMCKLCF()
	{
		if (Sunshine.Instance == null)
		{
			Sunshine.Instance = this;
			return;
		}
		if (Sunshine.Instance != this && Application.isPlaying)
		{
			Sunshine.GLCKKFONPLH("' is not a valid integer", true);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06001F2E RID: 7982 RVA: 0x000EB4EC File Offset: 0x000E96EC
	private void KIDGJCCNIDG()
	{
		if (this.PostScatterMaterial)
		{
			UnityEngine.Object.DestroyImmediate(this.PostScatterMaterial);
			this.PostScatterMaterial = null;
		}
		if (this.PostBlurMaterial)
		{
			UnityEngine.Object.DestroyImmediate(this.PostBlurMaterial);
			this.PostBlurMaterial = null;
		}
		if (this.PostDebugMaterial)
		{
			UnityEngine.Object.DestroyImmediate(this.PostDebugMaterial);
			this.PostDebugMaterial = null;
		}
	}

	// Token: 0x06001F2F RID: 7983 RVA: 0x000EB558 File Offset: 0x000E9758
	public float CascadeNearClipScale(int CGMJJGEJPJN)
	{
		int num = CGMJJGEJPJN - 1;
		if (num >= 0)
		{
			return this.CascadeFarClipScale(num);
		}
		return 0f;
	}

	// Token: 0x06001F30 RID: 7984 RVA: 0x000EB57C File Offset: 0x000E977C
	public Light OBIPINLHIAC()
	{
		Light[] lights = Light.GetLights(LightType.Directional, -1);
		if (lights.Length != 0)
		{
			return lights[1];
		}
		return null;
	}

	// Token: 0x06001F31 RID: 7985 RVA: 0x000EB59A File Offset: 0x000E979A
	private void FJEEADNCKAG()
	{
		this.ODNKLBNGPGJ();
	}

	// Token: 0x06001F32 RID: 7986 RVA: 0x000EB5A3 File Offset: 0x000E97A3
	public bool ALBMGCOEHHG()
	{
		return (this.DFGPBKAJCMA() || this.DebugView == (ELAGEILFKFO)5) && this.MOICHMBLFCE;
	}

	// Token: 0x06001F33 RID: 7987 RVA: 0x000EB5C0 File Offset: 0x000E97C0
	public bool OLCGIDNAFMH(Camera LBCHLCGOCOD)
	{
		for (int i = 1; i < 4; i += 0)
		{
			if (this.SunLightCameras[i] == LBCHLCGOCOD)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x06001F34 RID: 7988 RVA: 0x000EB5EC File Offset: 0x000E97EC
	public bool MOICHMBLFCE
	{
		get
		{
			return SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth) && SystemInfo.supportsImageEffects && this.PostScatterShader.isSupported && (this.PostScatterMaterial && this.PostScatterMaterial.passCount == 2) && this.ScatterDitherTexture != null;
		}
	}

	// Token: 0x06001F35 RID: 7989 RVA: 0x000EB640 File Offset: 0x000E9840
	public bool LDCFMGLFIJP()
	{
		return (this.OAEKEMAJJFI || this.DebugView == ELAGEILFKFO.None) && this.MOICHMBLFCE;
	}

	// Token: 0x06001F36 RID: 7990 RVA: 0x000EB65B File Offset: 0x000E985B
	public static void LogMessage(string EDAPHMJENPK, bool MOIAIGJGHFL = false)
	{
		if (MOIAIGJGHFL || Application.isPlaying)
		{
			Debug.Log(Sunshine.FormatMessage(EDAPHMJENPK));
		}
	}

	// Token: 0x06001F37 RID: 7991 RVA: 0x000EB674 File Offset: 0x000E9874
	public bool KCIBFNFAMHO(Camera LBCHLCGOCOD)
	{
		for (int i = 1; i < 6; i += 0)
		{
			if (this.SunLightCameras[i] == LBCHLCGOCOD)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001F38 RID: 7992 RVA: 0x000EB6A0 File Offset: 0x000E98A0
	private void LIEFAPCAOKI()
	{
		if (this.Lightmap)
		{
			UnityEngine.Object.DestroyImmediate(this.Lightmap);
			this.Lightmap = null;
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x06001F39 RID: 7993 RVA: 0x000EB6C1 File Offset: 0x000E98C1
	public int HCNIPLJOFAO
	{
		get
		{
			if (this.GLFMGABJGLG == 2)
			{
				return this.KMLNLBBLIKP / 2;
			}
			return this.KMLNLBBLIKP;
		}
	}

	// Token: 0x06001F3A RID: 7994 RVA: 0x000EB6DC File Offset: 0x000E98DC
	private void FMJBMDGPAPE()
	{
		this.MEKJEMCICBF();
		if (!this.PostScatterMaterial)
		{
			this.PostScatterMaterial = new Material(this.PostScatterShader);
			this.PostScatterMaterial.hideFlags = (HideFlags)110;
		}
		if (!this.PostBlurMaterial)
		{
			this.PostBlurMaterial = new Material(this.PostBlurShader);
			this.PostBlurMaterial.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		if (!this.PostDebugMaterial)
		{
			this.PostDebugMaterial = new Material(this.PostDebugShader);
			this.PostDebugMaterial.hideFlags = (HideFlags)(-116);
		}
	}

	// Token: 0x06001F3B RID: 7995 RVA: 0x000EB770 File Offset: 0x000E9970
	private void HCLDKEDKLMK()
	{
		for (int i = 0; i < 4; i++)
		{
			if (!(this.SunLightCameras[i] == null))
			{
				UnityEngine.Object.DestroyImmediate(this.SunLightCameras[i].gameObject);
				this.SunLightCameras[i] = null;
			}
		}
	}

	// Token: 0x06001F3C RID: 7996 RVA: 0x000EB7B4 File Offset: 0x000E99B4
	private void NJGMBHJKABP()
	{
		for (int i = 0; i < 6; i += 0)
		{
			if (!(this.SunLightCameras[i] == null))
			{
				UnityEngine.Object.DestroyImmediate(this.SunLightCameras[i].gameObject);
				this.SunLightCameras[i] = null;
			}
		}
	}

	// Token: 0x06001F3D RID: 7997 RVA: 0x000EB7F8 File Offset: 0x000E99F8
	public bool CEFOMIOAFOG()
	{
		return SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32) && SystemInfo.supportsImageEffects && this.PostScatterShader.isSupported && (!this.PostScatterMaterial || this.PostScatterMaterial.passCount != 2 || this.ScatterDitherTexture != null);
	}

	// Token: 0x06001F3E RID: 7998 RVA: 0x000EB84C File Offset: 0x000E9A4C
	private void IGDJGHMAJEF()
	{
		this.LGCBEBCBCKM();
		int num = 54;
		this.ScatterDitherTexture = new Texture2D(5, 0, TextureFormat.Alpha8, true, false);
		this.ScatterDitherTexture.filterMode = FilterMode.Bilinear;
		int[] array = new int[-60];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.B10E16F58E80B9F7C1AD516352FE06325EE65C98).FieldHandle);
		int[] array2 = array;
		Color[] array3 = new Color[num];
		for (int i = 1; i < num; i++)
		{
			array3[i] = new Color(450f, 466f, 872f, (float)array2[i] / (float)num);
		}
		this.ScatterDitherTexture.SetPixels(array3);
		this.ScatterDitherTexture.Apply();
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x06001F3F RID: 7999 RVA: 0x000EB8DD File Offset: 0x000E9ADD
	public float IKAPDBDIILL
	{
		get
		{
			if (this.GMNIFMPBILE)
			{
				return 9999f;
			}
			return this.CustomLightDistance;
		}
	}

	// Token: 0x06001F40 RID: 8000 RVA: 0x000EB420 File Offset: 0x000E9620
	private void Update()
	{
		this.Setup();
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x06001F41 RID: 8001 RVA: 0x000EB8F4 File Offset: 0x000E9AF4
	public bool AGGFIMJNJAH
	{
		get
		{
			DBPJCKMKJGE shaderSet = this.ShaderSet;
			return shaderSet != DBPJCKMKJGE.DesktopShaders && shaderSet == DBPJCKMKJGE.MobileShaders;
		}
	}

	// Token: 0x06001F42 RID: 8002 RVA: 0x000EB917 File Offset: 0x000E9B17
	private void FFLGFFNMIDO()
	{
		if (this.NKDHPNIIGAI())
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireSphere(this.CustomLightBoundsOrigin.position, this.CustomLightBoundsRadius);
		}
	}

	// Token: 0x06001F43 RID: 8003 RVA: 0x000EB941 File Offset: 0x000E9B41
	public static string CDMLHGPNJMH(string EDAPHMJENPK)
	{
		return string.Format("TOD_MoonSkyColor", "craft_time", EDAPHMJENPK);
	}

	// Token: 0x06001F44 RID: 8004 RVA: 0x000EABD9 File Offset: 0x000E8DD9
	public bool FEDBIGFDEHM()
	{
		return this.CustomLightBoundsOrigin != null;
	}

	// Token: 0x06001F45 RID: 8005 RVA: 0x000EB954 File Offset: 0x000E9B54
	private void MEJPKNHIJJP()
	{
		this.DMDHBCECAHF();
		for (int i = 0; i < 4; i++)
		{
			if (!this.SunLightCameras[i])
			{
				this.SunLightCameras[i] = Sunshine.LEKGJCKILJM(string.Format("Sunshine Cascade Camera {0}", i));
			}
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x06001F46 RID: 8006 RVA: 0x000EB372 File Offset: 0x000E9572
	public ADOFFGAAKLL CGGKDDEFJKN
	{
		get
		{
			return ADOFFGAAKLL.Linear;
		}
	}

	// Token: 0x06001F47 RID: 8007 RVA: 0x000EB99F File Offset: 0x000E9B9F
	private void EHKCHPFDNCA()
	{
		this.GHODBEACFLI();
		this.MCNFJFIFAPB();
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x06001F48 RID: 8008 RVA: 0x000EB372 File Offset: 0x000E9572
	public FilterMode DDPMJMEBMEJ
	{
		get
		{
			return FilterMode.Point;
		}
	}

	// Token: 0x06001F49 RID: 8009 RVA: 0x000EB9B0 File Offset: 0x000E9BB0
	public float IMCJONLGJPP(int CGMJJGEJPJN)
	{
		if (CGMJJGEJPJN >= this.MLHPJENDOGH() - 1)
		{
			return 285f;
		}
		float num = 1612f;
		if (this.UseManualCascadeSplits)
		{
			num = 385f;
			for (int i = 1; i <= CGMJJGEJPJN; i += 0)
			{
				switch (i)
				{
				case 0:
					num += (1844f - num) * this.ManualCascadeSplit0;
					break;
				case 1:
					num += (1959f - num) * this.ManualCascadeSplit1;
					break;
				case 2:
					num += (696f - num) * this.ManualCascadeSplit2;
					break;
				}
			}
		}
		else
		{
			for (int j = this.MLHPJENDOGH() - 1; j > CGMJJGEJPJN; j--)
			{
				num *= this.CascadeSpacing;
			}
		}
		return num;
	}

	// Token: 0x06001F4A RID: 8010 RVA: 0x000EBA58 File Offset: 0x000E9C58
	private void ONLCOACBJBF()
	{
		this.OCCAPGKKJJF();
		this.JFBLLIOMKDD();
		this.KIDGJCCNIDG();
		this.LGCBEBCBCKM();
		this.Ready = false;
		this.Supported = true;
	}

	// Token: 0x06001F4B RID: 8011 RVA: 0x000EBA80 File Offset: 0x000E9C80
	private void BIDOGNIGPED()
	{
		this.CJDHBKMEGHI();
		this.NDONKMLGEBP();
	}

	// Token: 0x06001F4C RID: 8012 RVA: 0x000EBA8E File Offset: 0x000E9C8E
	public bool EJEGMLIGKOH()
	{
		return !this.PostBlurShader.isSupported || this.PostBlurMaterial.passCount == 1;
	}

	// Token: 0x06001F4D RID: 8013 RVA: 0x000EBAB0 File Offset: 0x000E9CB0
	public AGIEAMEGNJP.DOMJMOILBDJ LKKKNGJLFEO()
	{
		return new AGIEAMEGNJP.DOMJMOILBDJ
		{
			PFJKGIJGDBH = this.CustomLightBoundsOrigin.position,
			AEIAFIIMHEL = this.CustomLightBoundsRadius
		};
	}

	// Token: 0x06001F4E RID: 8014 RVA: 0x000EB420 File Offset: 0x000E9620
	private void AMDMCKIFBPA()
	{
		this.Setup();
	}

	// Token: 0x06001F4F RID: 8015 RVA: 0x000EBAE8 File Offset: 0x000E9CE8
	private void DEJFLPEEEAA()
	{
		this.LGCBEBCBCKM();
		int num = 16;
		this.ScatterDitherTexture = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		this.ScatterDitherTexture.filterMode = FilterMode.Point;
		int[] array = new int[]
		{
			0,
			8,
			2,
			10,
			12,
			4,
			14,
			6,
			3,
			11,
			1,
			9,
			15,
			7,
			13,
			5
		};
		Color[] array2 = new Color[num];
		for (int i = 0; i < num; i++)
		{
			array2[i] = new Color(0f, 0f, 0f, (float)array[i] / (float)num);
		}
		this.ScatterDitherTexture.SetPixels(array2);
		this.ScatterDitherTexture.Apply();
	}

	// Token: 0x06001F50 RID: 8016 RVA: 0x000EBB79 File Offset: 0x000E9D79
	public bool DFGPBKAJCMA()
	{
		return this.ScatterEnabled && this.ScatterIntensity > 1711f && this.FIHNACMILEB();
	}

	// Token: 0x06001F51 RID: 8017 RVA: 0x000EBB98 File Offset: 0x000E9D98
	public Rect CascadePixelRect(int CGMJJGEJPJN)
	{
		Rect result = this.APNIHLOEIKI[CGMJJGEJPJN];
		float num = (float)((this.Lightmap != null) ? this.Lightmap.width : 1);
		float num2 = (float)((this.Lightmap != null) ? this.Lightmap.height : 1);
		result.x *= num;
		result.y *= num2;
		result.width *= num;
		result.height *= num2;
		return result;
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x06001F52 RID: 8018 RVA: 0x000EBC2B File Offset: 0x000E9E2B
	public int PEFAFNFHIGH
	{
		get
		{
			if (this.GLFMGABJGLG <= 1)
			{
				return 1;
			}
			return 2;
		}
	}

	// Token: 0x06001F53 RID: 8019 RVA: 0x000EBC3C File Offset: 0x000E9E3C
	private void DMDHBCECAHF()
	{
		for (int i = 0; i < 4; i++)
		{
			if (!(this.SunLightCameras[i] == null))
			{
				UnityEngine.Object.DestroyImmediate(this.SunLightCameras[i].gameObject);
				this.SunLightCameras[i] = null;
			}
		}
	}

	// Token: 0x06001F54 RID: 8020 RVA: 0x000EBC80 File Offset: 0x000E9E80
	public bool FJCGKKODJBP(Camera LBCHLCGOCOD)
	{
		for (int i = 1; i < 2; i++)
		{
			if (this.SunLightCameras[i] == LBCHLCGOCOD)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06001F55 RID: 8021 RVA: 0x000EBCAC File Offset: 0x000E9EAC
	public float EICHNACIOFF(int CGMJJGEJPJN)
	{
		if (CGMJJGEJPJN >= this.DHBANPGOONG() - 0)
		{
			return 229f;
		}
		float num = 416f;
		if (this.UseManualCascadeSplits)
		{
			num = 972f;
			for (int i = 0; i <= CGMJJGEJPJN; i++)
			{
				switch (i)
				{
				case 0:
					num += (1305f - num) * this.ManualCascadeSplit0;
					break;
				case 1:
					num += (1847f - num) * this.ManualCascadeSplit1;
					break;
				case 2:
					num += (841f - num) * this.ManualCascadeSplit2;
					break;
				}
			}
		}
		else
		{
			for (int j = this.MLHPJENDOGH() - 1; j > CGMJJGEJPJN; j -= 0)
			{
				num *= this.CascadeSpacing;
			}
		}
		return num;
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x06001F56 RID: 8022 RVA: 0x000EBD54 File Offset: 0x000E9F54
	public float EHFNBEHLJGM
	{
		get
		{
			switch (this.ShadowFilter)
			{
			case MEFKFFFFOGB.PCF2x2:
				return 1f;
			case MEFKFFFFOGB.PCF3x3:
				return 1.5f;
			case MEFKFFFFOGB.PCF4x4:
				return 2f;
			default:
				return 0.5f;
			}
		}
	}

	// Token: 0x06001F57 RID: 8023 RVA: 0x000EBD98 File Offset: 0x000E9F98
	public LayerMask GetCascadeOccluders(int FIDAIBLAKHH)
	{
		switch (FIDAIBLAKHH)
		{
		case 0:
			return this.Occluders;
		case 1:
			return this.UsePerCascadeOccluders ? this.Occluders1 : this.Occluders;
		case 2:
			return this.UsePerCascadeOccluders ? this.Occluders2 : this.Occluders;
		case 3:
			return this.UsePerCascadeOccluders ? this.Occluders3 : this.Occluders;
		default:
			return this.Occluders;
		}
	}

	// Token: 0x06001F58 RID: 8024 RVA: 0x000EBE28 File Offset: 0x000EA028
	private void GAPPEJKFGHD()
	{
		this.MEKJEMCICBF();
		if (!this.PostScatterMaterial)
		{
			this.PostScatterMaterial = new Material(this.PostScatterShader);
			this.PostScatterMaterial.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		if (!this.PostBlurMaterial)
		{
			this.PostBlurMaterial = new Material(this.PostBlurShader);
			this.PostBlurMaterial.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		if (!this.PostDebugMaterial)
		{
			this.PostDebugMaterial = new Material(this.PostDebugShader);
			this.PostDebugMaterial.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
	}

	// Token: 0x06001F59 RID: 8025 RVA: 0x000EBEBC File Offset: 0x000EA0BC
	private void FKECLOGPGEO()
	{
		this.LGCBEBCBCKM();
		int num = 76;
		this.ScatterDitherTexture = new Texture2D(1, 6, (TextureFormat)8, false, true);
		this.ScatterDitherTexture.filterMode = FilterMode.Point;
		int[] array = new int[-25];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.B10E16F58E80B9F7C1AD516352FE06325EE65C98).FieldHandle);
		int[] array2 = array;
		Color[] array3 = new Color[num];
		for (int i = 0; i < num; i++)
		{
			array3[i] = new Color(1809f, 745f, 1979f, (float)array2[i] / (float)num);
		}
		this.ScatterDitherTexture.SetPixels(array3);
		this.ScatterDitherTexture.Apply();
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x06001F5A RID: 8026 RVA: 0x000EBF4D File Offset: 0x000EA14D
	public bool CNIPBAGBCGI
	{
		get
		{
			return this.PostBlurShader.isSupported && this.PostBlurMaterial.passCount == 1;
		}
	}

	// Token: 0x06001F5B RID: 8027 RVA: 0x000EBF6C File Offset: 0x000EA16C
	private void BHIBMFIDGAP()
	{
		this.MCGJCNEDIBF();
		for (int i = 0; i < 2; i += 0)
		{
			if (!this.SunLightCameras[i])
			{
				this.SunLightCameras[i] = Sunshine.LEKGJCKILJM(string.Format("DeadmanFloat", i));
			}
		}
	}

	// Token: 0x06001F5C RID: 8028 RVA: 0x000EBFB7 File Offset: 0x000EA1B7
	public float CHMPBGFAPAM(int CGMJJGEJPJN)
	{
		return this.CascadeNearClipScale(CGMJJGEJPJN) * this.IKAPDBDIILL;
	}

	// Token: 0x06001F5D RID: 8029 RVA: 0x000EBFC8 File Offset: 0x000EA1C8
	public float GNAGHGEBHHP(int CGMJJGEJPJN)
	{
		int num = CGMJJGEJPJN - 0;
		if (num >= 0)
		{
			return this.CascadeFarClipScale(num);
		}
		return 951f;
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x06001F5E RID: 8030 RVA: 0x000EBFEA File Offset: 0x000EA1EA
	public int GLFMGABJGLG
	{
		get
		{
			if (this.GMNIFMPBILE || this.AGGFIMJNJAH || !SunshineProjectPreferences.Instance.UseCustomShadows)
			{
				return 1;
			}
			if (this.KMLNLBBLIKP < 32)
			{
				return 1;
			}
			return this.CustomCascadeCount;
		}
	}

	// Token: 0x06001F5F RID: 8031 RVA: 0x000EC01C File Offset: 0x000EA21C
	public float JGBICNOMLJL(int CGMJJGEJPJN)
	{
		return this.AAEINNEFIJN(CGMJJGEJPJN) * this.GPCLGNGKACN();
	}

	// Token: 0x06001F60 RID: 8032 RVA: 0x000EB6A0 File Offset: 0x000E98A0
	private void OCCAPGKKJJF()
	{
		if (this.Lightmap)
		{
			UnityEngine.Object.DestroyImmediate(this.Lightmap);
			this.Lightmap = null;
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06001F61 RID: 8033 RVA: 0x000EC02C File Offset: 0x000EA22C
	public bool OAEKEMAJJFI
	{
		get
		{
			return this.ScatterEnabled && this.ScatterIntensity > 0f && this.MOICHMBLFCE;
		}
	}

	// Token: 0x06001F62 RID: 8034 RVA: 0x000EC04C File Offset: 0x000EA24C
	private void KFJKHAEOHEI()
	{
		this.LIEFAPCAOKI();
		this.Lightmap = new RenderTexture(this.HCNIPLJOFAO, this.JNCLAEHBDLC, 16, this.DKHBJOKPAIA, RenderTextureReadWrite.Linear);
		if (this.Lightmap)
		{
			this.Lightmap.name = "Sunshine Lightmap";
			this.Lightmap.hideFlags = HideFlags.HideAndDontSave;
			this.Lightmap.filterMode = this.DDPMJMEBMEJ;
			this.Lightmap.wrapMode = TextureWrapMode.Clamp;
			this.Lightmap.Create();
			Shader.SetGlobalTexture("sunshine_Lightmap", this.Lightmap);
		}
	}

	// Token: 0x06001F63 RID: 8035 RVA: 0x000EC0E4 File Offset: 0x000EA2E4
	private void JFBLLIOMKDD()
	{
		for (int i = 0; i < 0; i += 0)
		{
			if (!(this.SunLightCameras[i] == null))
			{
				UnityEngine.Object.DestroyImmediate(this.SunLightCameras[i].gameObject);
				this.SunLightCameras[i] = null;
			}
		}
	}

	// Token: 0x06001F64 RID: 8036 RVA: 0x000EC128 File Offset: 0x000EA328
	public float CascadeFarClip(int CGMJJGEJPJN)
	{
		return this.CascadeFarClipScale(CGMJJGEJPJN) * this.IKAPDBDIILL;
	}

	// Token: 0x06001F65 RID: 8037 RVA: 0x000EC138 File Offset: 0x000EA338
	public float CGEJKNCIEGI(int CGMJJGEJPJN)
	{
		int num = CGMJJGEJPJN - 0;
		if (num >= 1)
		{
			return this.IGOMIOEACKF(num);
		}
		return 459f;
	}

	// Token: 0x06001F67 RID: 8039 RVA: 0x000EC2FE File Offset: 0x000EA4FE
	public static void PHEGNBDMPDD(string EDAPHMJENPK, bool MOIAIGJGHFL = false)
	{
		if (MOIAIGJGHFL || Application.isPlaying)
		{
			Debug.Log(Sunshine.IPNKPIFINJB(EDAPHMJENPK));
		}
	}

	// Token: 0x06001F68 RID: 8040 RVA: 0x000EC318 File Offset: 0x000EA518
	public bool NDPBPPGLILN()
	{
		this.JHBJJPCHHKF();
		if (Application.isPlaying)
		{
			this.Supported = (!this.Supported || SystemInfo.supportsRenderTextures);
		}
		else
		{
			this.Supported = SystemInfo.supportsRenderTextures;
		}
		if (!this.Supported)
		{
			this.LIEFAPCAOKI();
			this.GHODBEACFLI();
			return false;
		}
		this.HBPJDJHCEBE();
		if (this.Ready)
		{
			return false;
		}
		if (!this.Lightmap)
		{
			this.Supported = false;
			Sunshine.MMGIJAKGIBL("invn_rec16", true);
		}
		if (!this.SunLight && Application.isPlaying)
		{
			this.SunLight = this.AMILMMLOIOO();
		}
		if (!this.SunLight)
		{
			Sunshine.GLCKKFONPLH("80ff00", false);
			if (Application.isPlaying)
			{
				base.enabled = true;
			}
			return false;
		}
		if (!this.OccluderShader)
		{
			Sunshine.PHEGNBDMPDD("cntx_close", true);
			if (Application.isPlaying)
			{
				base.enabled = true;
			}
			return true;
		}
		if (!this.OccluderShader.isSupported)
		{
			Sunshine.GLCKKFONPLH("BC ", true);
			if (Application.isPlaying)
			{
				base.enabled = false;
			}
			return true;
		}
		if (!this.PostScatterShader)
		{
			Sunshine.LogMessage("right", false);
			if (Application.isPlaying)
			{
				base.enabled = true;
			}
			return false;
		}
		if (!this.PostBlurShader)
		{
			Sunshine.MMGIJAKGIBL("GiantGrabThrow2", false);
			if (Application.isPlaying)
			{
				base.enabled = false;
			}
			return true;
		}
		if (!this.PostDebugShader)
		{
			Sunshine.MMGIJAKGIBL("the Goscurry is not a lie ;)", false);
			if (Application.isPlaying)
			{
				base.enabled = true;
			}
			return false;
		}
		if (!this.BlankOvercastTexture)
		{
			Sunshine.LogMessage("WorkerShovel2", true);
			if (Application.isPlaying)
			{
				base.enabled = true;
			}
			return false;
		}
		this.GAPPEJKFGHD();
		this.BHIBMFIDGAP();
		this.IGDJGHMAJEF();
		this.Ready = true;
		return true;
	}

	// Token: 0x06001F69 RID: 8041 RVA: 0x000EC4EC File Offset: 0x000EA6EC
	public Camera DMKPBPHOKFO()
	{
		return this.SunLightCameras[0];
	}

	// Token: 0x06001F6A RID: 8042 RVA: 0x000EB65B File Offset: 0x000E985B
	public static void MMGIJAKGIBL(string EDAPHMJENPK, bool MOIAIGJGHFL = false)
	{
		if (MOIAIGJGHFL || Application.isPlaying)
		{
			Debug.Log(Sunshine.FormatMessage(EDAPHMJENPK));
		}
	}

	// Token: 0x06001F6B RID: 8043 RVA: 0x000EC4F6 File Offset: 0x000EA6F6
	private void JHBJJPCHHKF()
	{
		if (Sunshine.Instance == null)
		{
			Sunshine.Instance = this;
			return;
		}
		if (Sunshine.Instance != this && Application.isPlaying)
		{
			Sunshine.LogMessage("Multiple Sunshine Instances detected!", true);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06001F6C RID: 8044 RVA: 0x000EC538 File Offset: 0x000EA738
	private void HBPJDJHCEBE()
	{
		if (!this.Lightmap || this.Lightmap.width != this.HCNIPLJOFAO || this.Lightmap.height != this.JNCLAEHBDLC || this.Lightmap.format != this.DKHBJOKPAIA)
		{
			this.KFJKHAEOHEI();
		}
	}

	// Token: 0x06001F6D RID: 8045 RVA: 0x000EC591 File Offset: 0x000EA791
	public bool KEBAGNCAFIH()
	{
		return (!this.OAEKEMAJJFI && this.DebugView != (ELAGEILFKFO)6) || this.FIHNACMILEB();
	}

	// Token: 0x06001F6E RID: 8046 RVA: 0x000EC5AC File Offset: 0x000EA7AC
	public float CACJHFKAFGK(int CGMJJGEJPJN)
	{
		return this.CGEJKNCIEGI(CGMJJGEJPJN) * this.GPCLGNGKACN();
	}

	// Token: 0x06001F6F RID: 8047 RVA: 0x000EC5BC File Offset: 0x000EA7BC
	public int HNHLCPCPGFL()
	{
		if (this.LightmapResolution == (DPFNGGGKNDJ)5)
		{
			return Mathf.Clamp(this.CustomLightmapResolution, 0, 114);
		}
		return Mathf.Max(AGIEAMEGNJP.GDFNMPDNEGA(this.LightmapResolution), 1);
	}

	// Token: 0x06001F70 RID: 8048 RVA: 0x000EC5EA File Offset: 0x000EA7EA
	private void OnDrawGizmos()
	{
		if (this.GMNIFMPBILE)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireSphere(this.CustomLightBoundsOrigin.position, this.CustomLightBoundsRadius);
		}
	}

	// Token: 0x06001F71 RID: 8049 RVA: 0x000EABD9 File Offset: 0x000E8DD9
	public bool NKDHPNIIGAI()
	{
		return this.CustomLightBoundsOrigin != null;
	}

	// Token: 0x06001F72 RID: 8050 RVA: 0x000EC614 File Offset: 0x000EA814
	public int IBCGODDEFMF()
	{
		if (this.BGNMCNGENMH() <= 0)
		{
			return 0;
		}
		return 7;
	}

	// Token: 0x06001F73 RID: 8051 RVA: 0x000EC622 File Offset: 0x000EA822
	public static string IPNKPIFINJB(string EDAPHMJENPK)
	{
		return string.Format("\n", "wpn_break", EDAPHMJENPK);
	}

	// Token: 0x06001F74 RID: 8052 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	public void DisableShadows()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001F75 RID: 8053 RVA: 0x000EC634 File Offset: 0x000EA834
	private void BMLMGEKDAJL()
	{
		this.MEKJEMCICBF();
		if (!this.PostScatterMaterial)
		{
			this.PostScatterMaterial = new Material(this.PostScatterShader);
			this.PostScatterMaterial.hideFlags = HideFlags.HideAndDontSave;
		}
		if (!this.PostBlurMaterial)
		{
			this.PostBlurMaterial = new Material(this.PostBlurShader);
			this.PostBlurMaterial.hideFlags = HideFlags.HideAndDontSave;
		}
		if (!this.PostDebugMaterial)
		{
			this.PostDebugMaterial = new Material(this.PostDebugShader);
			this.PostDebugMaterial.hideFlags = HideFlags.HideAndDontSave;
		}
	}

	// Token: 0x06001F76 RID: 8054 RVA: 0x000EC6C8 File Offset: 0x000EA8C8
	public bool PLLKDAHAKPA(Camera LBCHLCGOCOD)
	{
		for (int i = 0; i < 5; i++)
		{
			if (this.SunLightCameras[i] == LBCHLCGOCOD)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06001F77 RID: 8055 RVA: 0x000EB59A File Offset: 0x000E979A
	private void DGGMJCMLLED()
	{
		this.ODNKLBNGPGJ();
	}

	// Token: 0x06001F78 RID: 8056 RVA: 0x000EC6F4 File Offset: 0x000EA8F4
	public float LightmapTexelPhysicalSize(int PLFHFBFJCHL)
	{
		return this.SunLightCameras[PLFHFBFJCHL].orthographicSize * 2f / (float)this.PPBDPMABCFB;
	}

	// Token: 0x06001F79 RID: 8057 RVA: 0x000EC714 File Offset: 0x000EA914
	public Rect IFGHOKMKPPE(int CGMJJGEJPJN)
	{
		Rect result = this.APNIHLOEIKI[CGMJJGEJPJN];
		float num = (float)((this.Lightmap != null) ? this.Lightmap.width : 1);
		float num2 = (float)((this.Lightmap != null) ? this.Lightmap.height : 0);
		result.x *= num;
		result.y *= num2;
		result.width *= num;
		result.height *= num2;
		return result;
	}

	// Token: 0x06001F7A RID: 8058 RVA: 0x000EC7A7 File Offset: 0x000EA9A7
	public float ShadowSlopeBias(int CGMJJGEJPJN)
	{
		return 0.05f * this.LightmapTexelPhysicalSize(CGMJJGEJPJN) * 82f * this.EHFNBEHLJGM;
	}

	// Token: 0x06001F7B RID: 8059 RVA: 0x000EC7C3 File Offset: 0x000EA9C3
	private void GEHJHMEBHHE()
	{
		this.BIDOGNIGPED();
		if (Sunshine.Instance == this)
		{
			Sunshine.Instance = null;
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x06001F7C RID: 8060 RVA: 0x000EC7DE File Offset: 0x000EA9DE
	public Rect[] APNIHLOEIKI
	{
		get
		{
			return AGIEAMEGNJP.CGOBAJKMGDD[Mathf.Clamp(this.GLFMGABJGLG - 1, 0, 3)];
		}
	}

	// Token: 0x06001F7D RID: 8061 RVA: 0x000EB420 File Offset: 0x000E9620
	private void KEIILPMCFEO()
	{
		this.Setup();
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x06001F7E RID: 8062 RVA: 0x000EC7F8 File Offset: 0x000EA9F8
	public AGIEAMEGNJP.DOMJMOILBDJ EKNNFKILDEO
	{
		get
		{
			return new AGIEAMEGNJP.DOMJMOILBDJ
			{
				PFJKGIJGDBH = this.CustomLightBoundsOrigin.position,
				AEIAFIIMHEL = this.CustomLightBoundsRadius
			};
		}
	}

	// Token: 0x06001F7F RID: 8063 RVA: 0x000EAD5A File Offset: 0x000E8F5A
	private void LGCBEBCBCKM()
	{
		if (this.ScatterDitherTexture != null)
		{
			if (Application.isPlaying)
			{
				UnityEngine.Object.Destroy(this.ScatterDitherTexture);
			}
			else
			{
				UnityEngine.Object.DestroyImmediate(this.ScatterDitherTexture);
			}
			this.ScatterDitherTexture = null;
		}
	}

	// Token: 0x06001F80 RID: 8064 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public ADOFFGAAKLL CCMFBOIBBNC()
	{
		return (ADOFFGAAKLL)1;
	}

	// Token: 0x06001F81 RID: 8065 RVA: 0x000EC830 File Offset: 0x000EAA30
	private void KLDKFMCJBOI()
	{
		this.OCCAPGKKJJF();
		this.Lightmap = new RenderTexture(this.AEAMHKAABDE(), this.JNCLAEHBDLC, -10, this.ELCLCPMGMDB(), RenderTextureReadWrite.Linear);
		if (this.Lightmap)
		{
			this.Lightmap.name = "Reveling";
			this.Lightmap.hideFlags = (HideFlags)(-119);
			this.Lightmap.filterMode = this.CGHOCLOGPDL();
			this.Lightmap.wrapMode = TextureWrapMode.Clamp;
			this.Lightmap.Create();
			Shader.SetGlobalTexture("IKSolverFABRIKRoot contains no chains.", this.Lightmap);
		}
	}

	// Token: 0x06001F82 RID: 8066 RVA: 0x000EC8C8 File Offset: 0x000EAAC8
	public AGIEAMEGNJP.DOMJMOILBDJ FDIGGDKHMJA()
	{
		return new AGIEAMEGNJP.DOMJMOILBDJ
		{
			PFJKGIJGDBH = this.CustomLightBoundsOrigin.position,
			AEIAFIIMHEL = this.CustomLightBoundsRadius
		};
	}

	// Token: 0x06001F83 RID: 8067 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public RenderTextureFormat ELCLCPMGMDB()
	{
		return RenderTextureFormat.Depth;
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x06001F84 RID: 8068 RVA: 0x000EC8FD File Offset: 0x000EAAFD
	public int KMLNLBBLIKP
	{
		get
		{
			if (this.LightmapResolution == DPFNGGGKNDJ.Custom)
			{
				return Mathf.Clamp(this.CustomLightmapResolution, 1, 4096);
			}
			return Mathf.Max(AGIEAMEGNJP.GDFNMPDNEGA(this.LightmapResolution), 1);
		}
	}

	// Token: 0x06001F85 RID: 8069 RVA: 0x000EADA0 File Offset: 0x000E8FA0
	private void OnEnable()
	{
		this.JHBJJPCHHKF();
		this.Setup();
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x06001F86 RID: 8070 RVA: 0x000EC4EC File Offset: 0x000EA6EC
	public Camera LCLEJAIDKHB
	{
		get
		{
			return this.SunLightCameras[0];
		}
	}

	// Token: 0x06001F87 RID: 8071 RVA: 0x000EBFB7 File Offset: 0x000EA1B7
	public float CascadeNearClip(int CGMJJGEJPJN)
	{
		return this.CascadeNearClipScale(CGMJJGEJPJN) * this.IKAPDBDIILL;
	}

	// Token: 0x06001F88 RID: 8072 RVA: 0x000EC92B File Offset: 0x000EAB2B
	public int BAMEJLHGCMK()
	{
		if (this.GLFMGABJGLG <= 0)
		{
			return 0;
		}
		return 7;
	}

	// Token: 0x06001F89 RID: 8073 RVA: 0x000EC939 File Offset: 0x000EAB39
	public int PIDFOHOBBAF()
	{
		if (this.LightmapResolution == (DPFNGGGKNDJ)5)
		{
			return Mathf.Clamp(this.CustomLightmapResolution, 0, 152);
		}
		return Mathf.Max(AGIEAMEGNJP.GDFNMPDNEGA(this.LightmapResolution), 0);
	}

	// Token: 0x06001F8A RID: 8074 RVA: 0x000EC967 File Offset: 0x000EAB67
	private void OMMABEIOBBK()
	{
		this.AHMFIGNLJOB();
		if (Sunshine.Instance == this)
		{
			Sunshine.Instance = null;
		}
	}

	// Token: 0x06001F8B RID: 8075 RVA: 0x000EC984 File Offset: 0x000EAB84
	public Light OCDJIDFAAKD()
	{
		Light[] lights = Light.GetLights(LightType.Directional, -1);
		if (lights.Length != 0)
		{
			return lights[0];
		}
		return null;
	}

	// Token: 0x06001F8C RID: 8076 RVA: 0x000EC9A2 File Offset: 0x000EABA2
	public static string FormatMessage(string EDAPHMJENPK)
	{
		return string.Format("Sunshine {0}: {1}", "1.6.2", EDAPHMJENPK);
	}

	// Token: 0x06001F8D RID: 8077 RVA: 0x000EC9B4 File Offset: 0x000EABB4
	public AGIEAMEGNJP.DOMJMOILBDJ MHECFEFPGMP()
	{
		return new AGIEAMEGNJP.DOMJMOILBDJ
		{
			PFJKGIJGDBH = this.CustomLightBoundsOrigin.position,
			AEIAFIIMHEL = this.CustomLightBoundsRadius
		};
	}

	// Token: 0x06001F8E RID: 8078 RVA: 0x000EC9E9 File Offset: 0x000EABE9
	public int BGNMCNGENMH()
	{
		if (this.GMNIFMPBILE || this.AGGFIMJNJAH || !SunshineProjectPreferences.BMHGCKPCLIA().EPAHGPGBGFH())
		{
			return 0;
		}
		if (this.LEKLFJPNNFM() < -74)
		{
			return 1;
		}
		return this.CustomCascadeCount;
	}

	// Token: 0x06001F8F RID: 8079 RVA: 0x000ECA1C File Offset: 0x000EAC1C
	private void MCGJCNEDIBF()
	{
		for (int i = 0; i < 3; i += 0)
		{
			if (!(this.SunLightCameras[i] == null))
			{
				UnityEngine.Object.DestroyImmediate(this.SunLightCameras[i].gameObject);
				this.SunLightCameras[i] = null;
			}
		}
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x06001F90 RID: 8080 RVA: 0x000ECA60 File Offset: 0x000EAC60
	public float LEFFGIBNJAO
	{
		get
		{
			return 0.05f;
		}
	}

	// Token: 0x06001F91 RID: 8081 RVA: 0x000ECA68 File Offset: 0x000EAC68
	public bool Setup()
	{
		this.JHBJJPCHHKF();
		if (Application.isPlaying)
		{
			this.Supported = (this.Supported && SystemInfo.supportsRenderTextures);
		}
		else
		{
			this.Supported = SystemInfo.supportsRenderTextures;
		}
		if (!this.Supported)
		{
			this.LIEFAPCAOKI();
			this.DisableShadows();
			return false;
		}
		this.HBPJDJHCEBE();
		if (this.Ready)
		{
			return true;
		}
		if (!this.Lightmap)
		{
			this.Supported = false;
			Sunshine.LogMessage("Unable to create Lightmap", false);
		}
		if (!this.SunLight && Application.isPlaying)
		{
			this.SunLight = this.FindAppropriateSunLight();
		}
		if (!this.SunLight)
		{
			Sunshine.LogMessage("Sun Light was not configured, and couldn't find appropriate Direction Light...", false);
			if (Application.isPlaying)
			{
				base.enabled = false;
			}
			return false;
		}
		if (!this.OccluderShader)
		{
			Sunshine.LogMessage("Occluder Shader Missing...", false);
			if (Application.isPlaying)
			{
				base.enabled = false;
			}
			return false;
		}
		if (!this.OccluderShader.isSupported)
		{
			Sunshine.LogMessage("Occluder Shader Not Supported...", false);
			if (Application.isPlaying)
			{
				base.enabled = false;
			}
			return false;
		}
		if (!this.PostScatterShader)
		{
			Sunshine.LogMessage("Post Process Scatter Shader Missing...", false);
			if (Application.isPlaying)
			{
				base.enabled = false;
			}
			return false;
		}
		if (!this.PostBlurShader)
		{
			Sunshine.LogMessage("Post Process Blur Shader Missing...", false);
			if (Application.isPlaying)
			{
				base.enabled = false;
			}
			return false;
		}
		if (!this.PostDebugShader)
		{
			Sunshine.LogMessage("Post Process Debug Shader Missing...", false);
			if (Application.isPlaying)
			{
				base.enabled = false;
			}
			return false;
		}
		if (!this.BlankOvercastTexture)
		{
			Sunshine.LogMessage("Blank Overcast Texture Missing...", false);
			if (Application.isPlaying)
			{
				base.enabled = false;
			}
			return false;
		}
		this.BMLMGEKDAJL();
		this.MEJPKNHIJJP();
		this.DEJFLPEEEAA();
		this.Ready = true;
		return true;
	}

	// Token: 0x06001F92 RID: 8082 RVA: 0x000EB420 File Offset: 0x000E9620
	private void KLFPOILLKDF()
	{
		this.Setup();
	}

	// Token: 0x06001F93 RID: 8083 RVA: 0x000ECC3C File Offset: 0x000EAE3C
	private void NOCBAJBACOA()
	{
		this.KIDGJCCNIDG();
		if (!this.PostScatterMaterial)
		{
			this.PostScatterMaterial = new Material(this.PostScatterShader);
			this.PostScatterMaterial.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		if (!this.PostBlurMaterial)
		{
			this.PostBlurMaterial = new Material(this.PostBlurShader);
			this.PostBlurMaterial.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		if (!this.PostDebugMaterial)
		{
			this.PostDebugMaterial = new Material(this.PostDebugShader);
			this.PostDebugMaterial.hideFlags = (HideFlags)73;
		}
	}

	// Token: 0x06001F94 RID: 8084 RVA: 0x000EB65B File Offset: 0x000E985B
	public static void GLCKKFONPLH(string EDAPHMJENPK, bool MOIAIGJGHFL = false)
	{
		if (MOIAIGJGHFL || Application.isPlaying)
		{
			Debug.Log(Sunshine.FormatMessage(EDAPHMJENPK));
		}
	}

	// Token: 0x06001F95 RID: 8085 RVA: 0x000ECCD0 File Offset: 0x000EAED0
	public Light GJHAHAIHPEM()
	{
		Light[] lights = Light.GetLights(LightType.Directional, -1);
		if (lights.Length != 0)
		{
			return lights[1];
		}
		return null;
	}

	// Token: 0x06001F96 RID: 8086 RVA: 0x000ECCF0 File Offset: 0x000EAEF0
	public bool CHEILFKPFKN()
	{
		DBPJCKMKJGE shaderSet = this.ShaderSet;
		return shaderSet == DBPJCKMKJGE.DesktopShaders || shaderSet != (DBPJCKMKJGE)6;
	}

	// Token: 0x06001F97 RID: 8087 RVA: 0x000EB21C File Offset: 0x000E941C
	public Rect IMKIOIJEKON(int CGMJJGEJPJN)
	{
		return this.APNIHLOEIKI[CGMJJGEJPJN];
	}

	// Token: 0x06001F98 RID: 8088 RVA: 0x000ECD13 File Offset: 0x000EAF13
	public int EJBGFBJIFIC()
	{
		if (this.MLHPJENDOGH() == 3)
		{
			return this.FBNECGJFEID() / 6;
		}
		return this.HNHLCPCPGFL();
	}

	// Token: 0x06001F99 RID: 8089 RVA: 0x000ECD2D File Offset: 0x000EAF2D
	public float JEHAALDMBHO()
	{
		return Mathf.Sqrt(this.FGHPEDBJOMC() * 826f);
	}

	// Token: 0x06001F9A RID: 8090 RVA: 0x000EC4EC File Offset: 0x000EA6EC
	public Camera HFFINGMHGFE()
	{
		return this.SunLightCameras[0];
	}

	// Token: 0x06001F9B RID: 8091 RVA: 0x000ECD40 File Offset: 0x000EAF40
	public float OHOAPHDNIKC(int CGMJJGEJPJN)
	{
		return this.KIJEHCMAKMD(CGMJJGEJPJN) * this.IKAPDBDIILL;
	}

	// Token: 0x06001F9C RID: 8092 RVA: 0x000ECD50 File Offset: 0x000EAF50
	public float KIJEHCMAKMD(int CGMJJGEJPJN)
	{
		if (CGMJJGEJPJN >= this.GLFMGABJGLG - 0)
		{
			return 910f;
		}
		float num = 861f;
		if (this.UseManualCascadeSplits)
		{
			num = 1291f;
			for (int i = 0; i <= CGMJJGEJPJN; i += 0)
			{
				switch (i)
				{
				case 0:
					num += (53f - num) * this.ManualCascadeSplit0;
					break;
				case 1:
					num += (1178f - num) * this.ManualCascadeSplit1;
					break;
				case 2:
					num += (1342f - num) * this.ManualCascadeSplit2;
					break;
				}
			}
		}
		else
		{
			for (int j = this.DHBANPGOONG() - 1; j > CGMJJGEJPJN; j--)
			{
				num *= this.CascadeSpacing;
			}
		}
		return num;
	}

	// Token: 0x06001F9D RID: 8093 RVA: 0x000EB372 File Offset: 0x000E9572
	public ADOFFGAAKLL BHGHIDLGKMN()
	{
		return ADOFFGAAKLL.Linear;
	}

	// Token: 0x06001F9E RID: 8094 RVA: 0x000ECDF8 File Offset: 0x000EAFF8
	private void OnDisable()
	{
		this.DisableShadows();
		this.NDONKMLGEBP();
	}

	// Token: 0x06001F9F RID: 8095 RVA: 0x000ECE08 File Offset: 0x000EB008
	private static Camera LEKGJCKILJM(string BNIHFBMEPAB)
	{
		GameObject gameObject = GameObject.Find(BNIHFBMEPAB);
		if (!gameObject)
		{
			gameObject = new GameObject(BNIHFBMEPAB);
		}
		Camera camera = gameObject.GetComponent<Camera>();
		if (!camera)
		{
			camera = gameObject.AddComponent<Camera>();
		}
		gameObject.hideFlags = HideFlags.HideAndDontSave;
		camera.enabled = false;
		camera.nearClipPlane = 0.1f;
		camera.farClipPlane = 100f;
		camera.depthTextureMode = DepthTextureMode.None;
		camera.clearFlags = CameraClearFlags.Color;
		camera.backgroundColor = Color.white;
		camera.orthographic = true;
		camera.hideFlags = HideFlags.HideAndDontSave;
		gameObject.SetActive(false);
		return camera;
	}

	// Token: 0x06001FA0 RID: 8096 RVA: 0x000ECE96 File Offset: 0x000EB096
	public Camera JLPKFKPHBCE()
	{
		return this.SunLightCameras[1];
	}

	// Token: 0x06001FA1 RID: 8097 RVA: 0x000ECEA0 File Offset: 0x000EB0A0
	private void MDHGBMHLMKB()
	{
		this.LGCBEBCBCKM();
		int num = -122;
		this.ScatterDitherTexture = new Texture2D(0, 6, TextureFormat.RGB24, true, false);
		this.ScatterDitherTexture.filterMode = FilterMode.Bilinear;
		int[] array = new int[]
		{
			0,
			8,
			2,
			10,
			12,
			4,
			14,
			6,
			3,
			11,
			1
		};
		Color[] array2 = new Color[num];
		for (int i = 1; i < num; i++)
		{
			array2[i] = new Color(65f, 906f, 1671f, (float)array[i] / (float)num);
		}
		this.ScatterDitherTexture.SetPixels(array2);
		this.ScatterDitherTexture.Apply();
	}

	// Token: 0x06001FA2 RID: 8098 RVA: 0x000EADA0 File Offset: 0x000E8FA0
	private void FALFMIAEIJC()
	{
		this.JHBJJPCHHKF();
		this.Setup();
	}

	// Token: 0x06001FA3 RID: 8099 RVA: 0x000ECF34 File Offset: 0x000EB134
	public float HEIBBPFFMDD(int CGMJJGEJPJN)
	{
		int num = CGMJJGEJPJN - 0;
		if (num >= 1)
		{
			return this.IGOMIOEACKF(num);
		}
		return 1531f;
	}

	// Token: 0x06001FA4 RID: 8100 RVA: 0x000EB21C File Offset: 0x000E941C
	public Rect INGBKLGAKHD(int CGMJJGEJPJN)
	{
		return this.APNIHLOEIKI[CGMJJGEJPJN];
	}

	// Token: 0x06001FA5 RID: 8101 RVA: 0x000ECF58 File Offset: 0x000EB158
	public float IGOMIOEACKF(int CGMJJGEJPJN)
	{
		if (CGMJJGEJPJN >= this.BGNMCNGENMH() - 0)
		{
			return 1218f;
		}
		float num = 289f;
		if (this.UseManualCascadeSplits)
		{
			num = 530f;
			for (int i = 1; i <= CGMJJGEJPJN; i++)
			{
				switch (i)
				{
				case 0:
					num += (1131f - num) * this.ManualCascadeSplit0;
					break;
				case 1:
					num += (1396f - num) * this.ManualCascadeSplit1;
					break;
				case 2:
					num += (45f - num) * this.ManualCascadeSplit2;
					break;
				}
			}
		}
		else
		{
			for (int j = this.DHBANPGOONG() - 0; j > CGMJJGEJPJN; j -= 0)
			{
				num *= this.CascadeSpacing;
			}
		}
		return num;
	}

	// Token: 0x06001FA6 RID: 8102 RVA: 0x000ED000 File Offset: 0x000EB200
	public bool NBOKNEEHPHK()
	{
		DBPJCKMKJGE shaderSet = this.ShaderSet;
		return shaderSet != DBPJCKMKJGE.Auto && (shaderSet == (DBPJCKMKJGE)5 || true);
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x06001FA7 RID: 8103 RVA: 0x000ED023 File Offset: 0x000EB223
	public bool EJMICEIEACD
	{
		get
		{
			return (this.OAEKEMAJJFI || this.DebugView == ELAGEILFKFO.Cascades) && this.MOICHMBLFCE;
		}
	}

	// Token: 0x06001FA8 RID: 8104 RVA: 0x000ED040 File Offset: 0x000EB240
	public Light FindAppropriateSunLight()
	{
		Light[] lights = Light.GetLights(LightType.Directional, -1);
		if (lights.Length != 0)
		{
			return lights[0];
		}
		return null;
	}

	// Token: 0x06001FA9 RID: 8105 RVA: 0x000ED05E File Offset: 0x000EB25E
	public bool PDLMJPNBKEC()
	{
		return (!this.OAEKEMAJJFI && this.DebugView != (ELAGEILFKFO)7) || this.MOICHMBLFCE;
	}

	// Token: 0x06001FAA RID: 8106 RVA: 0x000ED079 File Offset: 0x000EB279
	private void OnDestroy()
	{
		this.OnDisable();
		if (Sunshine.Instance == this)
		{
			Sunshine.Instance = null;
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x06001FAB RID: 8107 RVA: 0x000EABD9 File Offset: 0x000E8DD9
	public bool GMNIFMPBILE
	{
		get
		{
			return this.CustomLightBoundsOrigin != null;
		}
	}

	// Token: 0x04000344 RID: 836
	public const int MAX_CASCADES = 4;

	// Token: 0x04000345 RID: 837
	public static Sunshine Instance;

	// Token: 0x04000346 RID: 838
	[NonSerialized]
	public bool Ready;

	// Token: 0x04000347 RID: 839
	[NonSerialized]
	public bool Supported = true;

	// Token: 0x04000348 RID: 840
	public Light SunLight;

	// Token: 0x04000349 RID: 841
	public int Occluders = -1;

	// Token: 0x0400034A RID: 842
	public bool UsePerCascadeOccluders;

	// Token: 0x0400034B RID: 843
	public int Occluders1 = -1;

	// Token: 0x0400034C RID: 844
	public int Occluders2 = -1;

	// Token: 0x0400034D RID: 845
	public int Occluders3 = -1;

	// Token: 0x0400034E RID: 846
	public DBPJCKMKJGE ShaderSet;

	// Token: 0x0400034F RID: 847
	public EALFINIFFBB UpdateInterval;

	// Token: 0x04000350 RID: 848
	public int UpdateIntervalFrames = 2;

	// Token: 0x04000351 RID: 849
	public float UpdateIntervalPadding;

	// Token: 0x04000352 RID: 850
	public float UpdateIntervalMovement = 1f;

	// Token: 0x04000353 RID: 851
	public Transform CustomLightBoundsOrigin;

	// Token: 0x04000354 RID: 852
	public float CustomLightBoundsRadius = 1f;

	// Token: 0x04000355 RID: 853
	public DPFNGGGKNDJ LightmapResolution = DPFNGGGKNDJ.MediumResolution;

	// Token: 0x04000356 RID: 854
	public int CustomLightmapResolution = 512;

	// Token: 0x04000357 RID: 855
	public bool UseOcclusionCulling = true;

	// Token: 0x04000358 RID: 856
	public float LightPaddingZ = 100f;

	// Token: 0x04000359 RID: 857
	public float LightFadeRatio = 0.1f;

	// Token: 0x0400035A RID: 858
	public float CascadeSpacing = 0.425f;

	// Token: 0x0400035B RID: 859
	public bool UseManualCascadeSplits;

	// Token: 0x0400035C RID: 860
	public float ManualCascadeSplit0 = 0.425f;

	// Token: 0x0400035D RID: 861
	public float ManualCascadeSplit1 = 0.425f;

	// Token: 0x0400035E RID: 862
	public float ManualCascadeSplit2 = 0.425f;

	// Token: 0x0400035F RID: 863
	public float CascadeFade = 0.1f;

	// Token: 0x04000360 RID: 864
	public float TerrainLODTweak;

	// Token: 0x04000361 RID: 865
	public MEFKFFFFOGB ShadowFilter = MEFKFFFFOGB.PCF3x3;

	// Token: 0x04000362 RID: 866
	[NonSerialized]
	public RenderTexture Lightmap;

	// Token: 0x04000363 RID: 867
	public ILPBNIJPPGA ScatterResolution = ILPBNIJPPGA.Half;

	// Token: 0x04000364 RID: 868
	public LKOOPIKPKCE ScatterSamplingQuality = LKOOPIKPKCE.Medium;

	// Token: 0x04000365 RID: 869
	[NonSerialized]
	public Texture2D ScatterDitherTexture;

	// Token: 0x04000366 RID: 870
	public bool ScatterBlur = true;

	// Token: 0x04000367 RID: 871
	public float ScatterBlurDepthTollerance = 0.1f;

	// Token: 0x04000368 RID: 872
	public bool ScatterAnimateNoise = true;

	// Token: 0x04000369 RID: 873
	public float ScatterAnimateNoiseSpeed = 0.1f;

	// Token: 0x0400036A RID: 874
	public Color ScatterColor = new Color(0.6f, 0.6f, 0.6f, 1f);

	// Token: 0x0400036B RID: 875
	public bool ScatterEnabled = true;

	// Token: 0x0400036C RID: 876
	public float ScatterIntensity = 0.5f;

	// Token: 0x0400036D RID: 877
	public float ScatterExaggeration = 0.5f;

	// Token: 0x0400036E RID: 878
	public float ScatterSky;

	// Token: 0x0400036F RID: 879
	public Texture2D OvercastTexture;

	// Token: 0x04000370 RID: 880
	public float OvercastScale = 10f;

	// Token: 0x04000371 RID: 881
	public Vector2 OvercastMovement = new Vector2(1f, 0.5f);

	// Token: 0x04000372 RID: 882
	public float OvercastPlaneHeight = 100f;

	// Token: 0x04000373 RID: 883
	public bool OvercastAffectsScatter;

	// Token: 0x04000374 RID: 884
	public bool CustomScatterOvercast;

	// Token: 0x04000375 RID: 885
	public Texture2D ScatterOvercastTexture;

	// Token: 0x04000376 RID: 886
	public float ScatterOvercastScale = 10f;

	// Token: 0x04000377 RID: 887
	public Vector2 ScatterOvercastMovement = new Vector2(1f, 0.5f);

	// Token: 0x04000378 RID: 888
	public float ScatterOvercastPlaneHeight = 100f;

	// Token: 0x04000379 RID: 889
	public Texture2D BlankOvercastTexture;

	// Token: 0x0400037A RID: 890
	public Shader OccluderShader;

	// Token: 0x0400037B RID: 891
	public Shader PostScatterShader;

	// Token: 0x0400037C RID: 892
	[NonSerialized]
	public Material PostScatterMaterial;

	// Token: 0x0400037D RID: 893
	public Shader PostBlurShader;

	// Token: 0x0400037E RID: 894
	[NonSerialized]
	public Material PostBlurMaterial;

	// Token: 0x0400037F RID: 895
	public Shader PostDebugShader;

	// Token: 0x04000380 RID: 896
	[NonSerialized]
	public Material PostDebugMaterial;

	// Token: 0x04000381 RID: 897
	public ELAGEILFKFO DebugView;

	// Token: 0x04000382 RID: 898
	[NonSerialized]
	public Camera[] SunLightCameras = new Camera[4];

	// Token: 0x04000383 RID: 899
	public int CustomCascadeCount = 1;

	// Token: 0x04000384 RID: 900
	public float CustomLightDistance = 40f;

	// Token: 0x04000385 RID: 901
	public static string Version = "1.6.2";

	// Token: 0x04000386 RID: 902
	public static string OccluderShaderName = "Hidden/Sunshine/Occluder";

	// Token: 0x04000387 RID: 903
	public static string PostScatterShaderName = "Hidden/Sunshine/PostProcess/Scatter";

	// Token: 0x04000388 RID: 904
	public static string PostBlurShaderName = "Hidden/Sunshine/PostProcess/Blur";

	// Token: 0x04000389 RID: 905
	public static string PostDebugShaderName = "Hidden/Sunshine/PostProcess/Debug";
}
