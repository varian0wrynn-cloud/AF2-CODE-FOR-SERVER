using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x02000522 RID: 1314
public sealed class FACEDKBCABP : CFPOKEIJEAB<GrainModel>
{
	// Token: 0x060116C6 RID: 71366 RVA: 0x007C6A5E File Offset: 0x007C4C5E
	public bool NIPHEHICHLK()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.FPLLFOMFIDF().intensity > 1061f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth) && !this.AMCOGJHPPOC.ACEEFEFOCDF();
	}

	// Token: 0x060116C7 RID: 71367 RVA: 0x007C6A9C File Offset: 0x007C4C9C
	public void BMGPPNLFIGA(Material OOLNAJMJKIK)
	{
		GrainModel.Settings settings = base.BBEPCCALAFC.MOMPAGIHIIH();
		OOLNAJMJKIK.EnableKeyword("_NoiseAmount");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.LNIFCNGGOFL == null || !this.LNIFCNGGOFL.IsCreated())
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
			this.LNIFCNGGOFL = new RenderTexture(86, 57, 0, RenderTextureFormat.Depth)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 1,
				name = "Hidden/Post FX/Builtin Debug Views"
			};
			this.LNIFCNGGOFL.Create();
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NADANHHBOLO("{0:0.0%}");
		material.SetFloat(FACEDKBCABP.HOPEEJPHNIG.IIIMHIJCPID, realtimeSinceStartup / 1558f);
		Graphics.Blit(null, this.LNIFCNGGOFL, material, settings.colored ? 0 : 0);
		OOLNAJMJKIK.SetTexture(FACEDKBCABP.HOPEEJPHNIG.BEMJDDCKNCO, this.LNIFCNGGOFL);
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.AJIFMABCALL, new Vector2(settings.luminanceContribution, settings.intensity * 233f));
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.HEOOMJPIJNO, new Vector4((float)this.AMCOGJHPPOC.PAHBMDOJHKK() / (float)this.LNIFCNGGOFL.width / settings.size, (float)this.AMCOGJHPPOC.GGGEFNKEPDB() / (float)this.LNIFCNGGOFL.height / settings.size, value, value2));
	}

	// Token: 0x060116C8 RID: 71368 RVA: 0x007C6C09 File Offset: 0x007C4E09
	public void PCKEAEAHAKG()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
		this.LNIFCNGGOFL = null;
	}

	// Token: 0x060116C9 RID: 71369 RVA: 0x007C6C1D File Offset: 0x007C4E1D
	public bool GINFOAMILDE()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.JADKPIOKKMG().intensity > 129f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Default) && !this.AMCOGJHPPOC.CHJAIAPCMDC();
	}

	// Token: 0x060116CA RID: 71370 RVA: 0x007C6C5B File Offset: 0x007C4E5B
	public bool JOOIEAIMIGG()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.JADKPIOKKMG().intensity > 458f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565) && !this.AMCOGJHPPOC.ODNAHJKPHKA();
	}

	// Token: 0x060116CB RID: 71371 RVA: 0x007C6C99 File Offset: 0x007C4E99
	public bool KCMKDGLNNPM()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.ANBJGJAJBFM().intensity > 832f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth) && !this.AMCOGJHPPOC.ODNAHJKPHKA();
	}

	// Token: 0x060116CC RID: 71372 RVA: 0x007C6CD8 File Offset: 0x007C4ED8
	public void IIAJGMCJJMI(Material OOLNAJMJKIK)
	{
		GrainModel.Settings settings = base.BBEPCCALAFC.CEBNJKGGMIE();
		OOLNAJMJKIK.EnableKeyword("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_biped_i_k.html");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.LNIFCNGGOFL == null || !this.LNIFCNGGOFL.IsCreated())
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
			this.LNIFCNGGOFL = new RenderTexture(116, -188, 0, RenderTextureFormat.Shadowmap)
			{
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 0,
				name = "_DepthOfFieldCoCTex"
			};
			this.LNIFCNGGOFL.Create();
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.OFIEMCNMGHM("Left arm 'Palm To Thumb Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the palm towards the thumb. If the arrow points away from the thumb, axis must be negative.");
		material.SetFloat(FACEDKBCABP.HOPEEJPHNIG.IIIMHIJCPID, realtimeSinceStartup / 194f);
		Graphics.Blit(null, this.LNIFCNGGOFL, material, settings.colored ? 0 : 0);
		OOLNAJMJKIK.SetTexture(FACEDKBCABP.HOPEEJPHNIG.BEMJDDCKNCO, this.LNIFCNGGOFL);
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.AJIFMABCALL, new Vector2(settings.luminanceContribution, settings.intensity * 939f));
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.HEOOMJPIJNO, new Vector4((float)this.AMCOGJHPPOC.IBPMMKDPDEO() / (float)this.LNIFCNGGOFL.width / settings.size, (float)this.AMCOGJHPPOC.FHCDJOLMIMG() / (float)this.LNIFCNGGOFL.height / settings.size, value, value2));
	}

	// Token: 0x060116CD RID: 71373 RVA: 0x007C6C09 File Offset: 0x007C4E09
	public void NDHFCDEKJPC()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
		this.LNIFCNGGOFL = null;
	}

	// Token: 0x060116CE RID: 71374 RVA: 0x007C6E48 File Offset: 0x007C5048
	public void EEFJLGCLKIG(Material OOLNAJMJKIK)
	{
		GrainModel.Settings settings = base.BBEPCCALAFC.GNKPDBPBDBF();
		OOLNAJMJKIK.EnableKeyword("");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.LNIFCNGGOFL == null || !this.LNIFCNGGOFL.IsCreated())
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
			this.LNIFCNGGOFL = new RenderTexture(146, -79, 1, RenderTextureFormat.ARGB32)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 0,
				name = "Text:"
			};
			this.LNIFCNGGOFL.Create();
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.HJFNEOFMJEJ("1HandSwordChargeUp");
		material.SetFloat(FACEDKBCABP.HOPEEJPHNIG.IIIMHIJCPID, realtimeSinceStartup / 1878f);
		Graphics.Blit(null, this.LNIFCNGGOFL, material, settings.colored ? 0 : 0);
		OOLNAJMJKIK.SetTexture(FACEDKBCABP.HOPEEJPHNIG.BEMJDDCKNCO, this.LNIFCNGGOFL);
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.AJIFMABCALL, new Vector2(settings.luminanceContribution, settings.intensity * 1841f));
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.HEOOMJPIJNO, new Vector4((float)this.AMCOGJHPPOC.OJNDCCHLMNK() / (float)this.LNIFCNGGOFL.width / settings.size, (float)this.AMCOGJHPPOC.MMEMLJENMFF() / (float)this.LNIFCNGGOFL.height / settings.size, value, value2));
	}

	// Token: 0x060116CF RID: 71375 RVA: 0x007C6FB8 File Offset: 0x007C51B8
	public void AEHIJMPNBDP(Material OOLNAJMJKIK)
	{
		GrainModel.Settings settings = base.BBEPCCALAFC.FHOBFCBNPOC();
		OOLNAJMJKIK.EnableKeyword("pf2m");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.LNIFCNGGOFL == null || !this.LNIFCNGGOFL.IsCreated())
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
			this.LNIFCNGGOFL = new RenderTexture(-65, -36, 1, RenderTextureFormat.Default)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 1,
				name = "Special"
			};
			this.LNIFCNGGOFL.Create();
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.FGKNJIEOKHH("invn_rec13");
		material.SetFloat(FACEDKBCABP.HOPEEJPHNIG.IIIMHIJCPID, realtimeSinceStartup / 1967f);
		Graphics.Blit(null, this.LNIFCNGGOFL, material, settings.colored ? 0 : 0);
		OOLNAJMJKIK.SetTexture(FACEDKBCABP.HOPEEJPHNIG.BEMJDDCKNCO, this.LNIFCNGGOFL);
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.AJIFMABCALL, new Vector2(settings.luminanceContribution, settings.intensity * 118f));
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.HEOOMJPIJNO, new Vector4((float)this.AMCOGJHPPOC.PAHBMDOJHKK() / (float)this.LNIFCNGGOFL.width / settings.size, (float)this.AMCOGJHPPOC.NIEGJHLHEEB() / (float)this.LNIFCNGGOFL.height / settings.size, value, value2));
	}

	// Token: 0x060116D0 RID: 71376 RVA: 0x007C7125 File Offset: 0x007C5325
	public bool LLPDCLKLKEM()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.JJBPDCAHOJK().intensity > 1049f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf) && this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x060116D2 RID: 71378 RVA: 0x007C716C File Offset: 0x007C536C
	public override void FBBBNHPGBKC(Material OOLNAJMJKIK)
	{
		GrainModel.Settings settings = base.BBEPCCALAFC.settings;
		OOLNAJMJKIK.EnableKeyword("GRAIN");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.LNIFCNGGOFL == null || !this.LNIFCNGGOFL.IsCreated())
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
			this.LNIFCNGGOFL = new RenderTexture(192, 192, 0, RenderTextureFormat.ARGBHalf)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 0,
				name = "Grain Lookup Texture"
			};
			this.LNIFCNGGOFL.Create();
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/Grain Generator");
		material.SetFloat(FACEDKBCABP.HOPEEJPHNIG.IIIMHIJCPID, realtimeSinceStartup / 20f);
		Graphics.Blit(null, this.LNIFCNGGOFL, material, settings.colored ? 1 : 0);
		OOLNAJMJKIK.SetTexture(FACEDKBCABP.HOPEEJPHNIG.BEMJDDCKNCO, this.LNIFCNGGOFL);
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.AJIFMABCALL, new Vector2(settings.luminanceContribution, settings.intensity * 20f));
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.HEOOMJPIJNO, new Vector4((float)this.AMCOGJHPPOC.NMEBEEHCALN / (float)this.LNIFCNGGOFL.width / settings.size, (float)this.AMCOGJHPPOC.ILLKFNCFGMP / (float)this.LNIFCNGGOFL.height / settings.size, value, value2));
	}

	// Token: 0x060116D3 RID: 71379 RVA: 0x007C72DC File Offset: 0x007C54DC
	public void IGFAFJCIEFM(Material OOLNAJMJKIK)
	{
		GrainModel.Settings settings = base.BBEPCCALAFC.OOMCJEDGDLL();
		OOLNAJMJKIK.EnableKeyword("ObscuredString vs string, ");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.LNIFCNGGOFL == null || !this.LNIFCNGGOFL.IsCreated())
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
			this.LNIFCNGGOFL = new RenderTexture(117, 169, 0, RenderTextureFormat.Depth)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 1,
				name = "_camIntensive"
			};
			this.LNIFCNGGOFL.Create();
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NADANHHBOLO("BowInstant");
		material.SetFloat(FACEDKBCABP.HOPEEJPHNIG.IIIMHIJCPID, realtimeSinceStartup / 262f);
		Graphics.Blit(null, this.LNIFCNGGOFL, material, settings.colored ? 1 : 0);
		OOLNAJMJKIK.SetTexture(FACEDKBCABP.HOPEEJPHNIG.BEMJDDCKNCO, this.LNIFCNGGOFL);
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.AJIFMABCALL, new Vector2(settings.luminanceContribution, settings.intensity * 485f));
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.HEOOMJPIJNO, new Vector4((float)this.AMCOGJHPPOC.KJDPLLFIIBK() / (float)this.LNIFCNGGOFL.width / settings.size, (float)this.AMCOGJHPPOC.GHMBALIHBOH() / (float)this.LNIFCNGGOFL.height / settings.size, value, value2));
	}

	// Token: 0x060116D4 RID: 71380 RVA: 0x007C7449 File Offset: 0x007C5649
	public bool NFAOKCAPJCN()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.KHHBMADLJLH().intensity > 1287f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32) && !this.AMCOGJHPPOC.CHJAIAPCMDC();
	}

	// Token: 0x060116D5 RID: 71381 RVA: 0x007C7487 File Offset: 0x007C5687
	public bool HMAFCBLHOPA()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.GNKPDBPBDBF().intensity <= 399f || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB2101010) || !this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x170003CD RID: 973
	// (get) Token: 0x060116D6 RID: 71382 RVA: 0x007C74C5 File Offset: 0x007C56C5
	public override bool NLFEIOCKHKA
	{
		get
		{
			return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.settings.intensity > 0f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf) && !this.AMCOGJHPPOC.CFABOAAPLPI;
		}
	}

	// Token: 0x060116D7 RID: 71383 RVA: 0x007C7503 File Offset: 0x007C5703
	public bool IOPILNONBKF()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.JADKPIOKKMG().intensity > 1344f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf) && !this.AMCOGJHPPOC.MLJCADOONGI();
	}

	// Token: 0x060116D8 RID: 71384 RVA: 0x007C7544 File Offset: 0x007C5744
	public void ACLPBJPMDJD(Material OOLNAJMJKIK)
	{
		GrainModel.Settings settings = base.BBEPCCALAFC.GEKPOGFKOIB();
		OOLNAJMJKIK.EnableKeyword("CP3");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.LNIFCNGGOFL == null || !this.LNIFCNGGOFL.IsCreated())
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
			this.LNIFCNGGOFL = new RenderTexture(167, 132, 1, RenderTextureFormat.ARGB4444)
			{
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 0,
				name = "Card Player Idle"
			};
			this.LNIFCNGGOFL.Create();
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JBLDPJMMJOL("  my=");
		material.SetFloat(FACEDKBCABP.HOPEEJPHNIG.IIIMHIJCPID, realtimeSinceStartup / 1243f);
		Graphics.Blit(null, this.LNIFCNGGOFL, material, settings.colored ? 0 : 1);
		OOLNAJMJKIK.SetTexture(FACEDKBCABP.HOPEEJPHNIG.BEMJDDCKNCO, this.LNIFCNGGOFL);
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.AJIFMABCALL, new Vector2(settings.luminanceContribution, settings.intensity * 1973f));
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.HEOOMJPIJNO, new Vector4((float)this.AMCOGJHPPOC.PAHBMDOJHKK() / (float)this.LNIFCNGGOFL.width / settings.size, (float)this.AMCOGJHPPOC.LKLNPJICOHH() / (float)this.LNIFCNGGOFL.height / settings.size, value, value2));
	}

	// Token: 0x060116D9 RID: 71385 RVA: 0x007C6C09 File Offset: 0x007C4E09
	public void GMJFHNCPCBN()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
		this.LNIFCNGGOFL = null;
	}

	// Token: 0x060116DA RID: 71386 RVA: 0x007C6C09 File Offset: 0x007C4E09
	public void BABMAHFKPMO()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
		this.LNIFCNGGOFL = null;
	}

	// Token: 0x060116DB RID: 71387 RVA: 0x007C6C09 File Offset: 0x007C4E09
	public void BNOLDFLILJA()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
		this.LNIFCNGGOFL = null;
	}

	// Token: 0x060116DC RID: 71388 RVA: 0x007C76B4 File Offset: 0x007C58B4
	public void DGKIKKNDBLP(Material OOLNAJMJKIK)
	{
		GrainModel.Settings settings = base.BBEPCCALAFC.FHOBFCBNPOC();
		OOLNAJMJKIK.EnableKeyword("BowReady");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.LNIFCNGGOFL == null || !this.LNIFCNGGOFL.IsCreated())
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
			this.LNIFCNGGOFL = new RenderTexture(-10, -105, 0, RenderTextureFormat.Depth)
			{
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 0,
				name = "Clear Screen"
			};
			this.LNIFCNGGOFL.Create();
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JNKAJCFJHIP("id");
		material.SetFloat(FACEDKBCABP.HOPEEJPHNIG.IIIMHIJCPID, realtimeSinceStartup / 985f);
		Graphics.Blit(null, this.LNIFCNGGOFL, material, settings.colored ? 0 : 1);
		OOLNAJMJKIK.SetTexture(FACEDKBCABP.HOPEEJPHNIG.BEMJDDCKNCO, this.LNIFCNGGOFL);
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.AJIFMABCALL, new Vector2(settings.luminanceContribution, settings.intensity * 1724f));
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.HEOOMJPIJNO, new Vector4((float)this.AMCOGJHPPOC.GMOLEDNNPEH() / (float)this.LNIFCNGGOFL.width / settings.size, (float)this.AMCOGJHPPOC.LHPBMEDMNDO() / (float)this.LNIFCNGGOFL.height / settings.size, value, value2));
	}

	// Token: 0x060116DD RID: 71389 RVA: 0x007C7821 File Offset: 0x007C5A21
	public bool FNHNEJNNKOJ()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.OGAEBMPHAJF().intensity <= 1484f || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Default) || this.AMCOGJHPPOC.ODNAHJKPHKA();
	}

	// Token: 0x060116DE RID: 71390 RVA: 0x007C7860 File Offset: 0x007C5A60
	public void LIEFLFCANMO(Material OOLNAJMJKIK)
	{
		GrainModel.Settings settings = base.BBEPCCALAFC.BMPIBIPNMCN();
		OOLNAJMJKIK.EnableKeyword("Save");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.LNIFCNGGOFL == null || !this.LNIFCNGGOFL.IsCreated())
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
			this.LNIFCNGGOFL = new RenderTexture(83, 191, 1, RenderTextureFormat.ARGB1555)
			{
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 1,
				name = "CrouchStrafeLeft"
			};
			this.LNIFCNGGOFL.Create();
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.PIPNAHLJKKD("RollerBladeCrossoverLeft");
		material.SetFloat(FACEDKBCABP.HOPEEJPHNIG.IIIMHIJCPID, realtimeSinceStartup / 1784f);
		Graphics.Blit(null, this.LNIFCNGGOFL, material, settings.colored ? 1 : 1);
		OOLNAJMJKIK.SetTexture(FACEDKBCABP.HOPEEJPHNIG.BEMJDDCKNCO, this.LNIFCNGGOFL);
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.AJIFMABCALL, new Vector2(settings.luminanceContribution, settings.intensity * 867f));
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.HEOOMJPIJNO, new Vector4((float)this.AMCOGJHPPOC.PAHBMDOJHKK() / (float)this.LNIFCNGGOFL.width / settings.size, (float)this.AMCOGJHPPOC.KNKKIHDHBFD() / (float)this.LNIFCNGGOFL.height / settings.size, value, value2));
	}

	// Token: 0x060116DF RID: 71391 RVA: 0x007C79CD File Offset: 0x007C5BCD
	public bool EHPCNOOJFMH()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.JADKPIOKKMG().intensity > 24f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth) && this.AMCOGJHPPOC.ACEEFEFOCDF();
	}

	// Token: 0x060116E0 RID: 71392 RVA: 0x007C6C09 File Offset: 0x007C4E09
	public void IABPIBODNNG()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
		this.LNIFCNGGOFL = null;
	}

	// Token: 0x060116E1 RID: 71393 RVA: 0x007C7A0B File Offset: 0x007C5C0B
	public bool NKNNJOHNGFH()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.EANIGOKFHLF().intensity > 724f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32) && !this.AMCOGJHPPOC.CFABOAAPLPI;
	}

	// Token: 0x060116E2 RID: 71394 RVA: 0x007C6C09 File Offset: 0x007C4E09
	public override void BKFHJFNCPAA()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
		this.LNIFCNGGOFL = null;
	}

	// Token: 0x060116E3 RID: 71395 RVA: 0x007C7A4C File Offset: 0x007C5C4C
	public void HLMCKNMCOKP(Material OOLNAJMJKIK)
	{
		GrainModel.Settings settings = base.BBEPCCALAFC.MOMPAGIHIIH();
		OOLNAJMJKIK.EnableKeyword("FistPump2");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.LNIFCNGGOFL == null || !this.LNIFCNGGOFL.IsCreated())
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
			this.LNIFCNGGOFL = new RenderTexture(32, -97, 0, RenderTextureFormat.RGB565)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 1,
				name = "DISTANCE_CUTOFF_ON"
			};
			this.LNIFCNGGOFL.Create();
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JNKAJCFJHIP("The shader ");
		material.SetFloat(FACEDKBCABP.HOPEEJPHNIG.IIIMHIJCPID, realtimeSinceStartup / 1694f);
		Graphics.Blit(null, this.LNIFCNGGOFL, material, settings.colored ? 1 : 0);
		OOLNAJMJKIK.SetTexture(FACEDKBCABP.HOPEEJPHNIG.BEMJDDCKNCO, this.LNIFCNGGOFL);
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.AJIFMABCALL, new Vector2(settings.luminanceContribution, settings.intensity * 1876f));
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.HEOOMJPIJNO, new Vector4((float)this.AMCOGJHPPOC.IBPMMKDPDEO() / (float)this.LNIFCNGGOFL.width / settings.size, (float)this.AMCOGJHPPOC.GGGEFNKEPDB() / (float)this.LNIFCNGGOFL.height / settings.size, value, value2));
	}

	// Token: 0x060116E4 RID: 71396 RVA: 0x007C7BB9 File Offset: 0x007C5DB9
	public bool FCEIMAANKJJ()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.LIKDNAJFKMN().intensity > 929f && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB1555) && !this.AMCOGJHPPOC.AFIPEFLJBBM();
	}

	// Token: 0x060116E5 RID: 71397 RVA: 0x007C7BF8 File Offset: 0x007C5DF8
	public void BGMNIHGFLHI(Material OOLNAJMJKIK)
	{
		GrainModel.Settings settings = base.BBEPCCALAFC.FPLLFOMFIDF();
		OOLNAJMJKIK.EnableKeyword("https://groups.google.com/forum/#!forum/final-ik");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.LNIFCNGGOFL == null || !this.LNIFCNGGOFL.IsCreated())
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
			this.LNIFCNGGOFL = new RenderTexture(173, -65, 1, RenderTextureFormat.Depth)
			{
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 1,
				name = "MotorbikeWheelyNoHands"
			};
			this.LNIFCNGGOFL.Create();
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.LNIKJLLFLAO("_WaterLevel");
		material.SetFloat(FACEDKBCABP.HOPEEJPHNIG.IIIMHIJCPID, realtimeSinceStartup / 1240f);
		Graphics.Blit(null, this.LNIFCNGGOFL, material, settings.colored ? 0 : 1);
		OOLNAJMJKIK.SetTexture(FACEDKBCABP.HOPEEJPHNIG.BEMJDDCKNCO, this.LNIFCNGGOFL);
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.AJIFMABCALL, new Vector2(settings.luminanceContribution, settings.intensity * 56f));
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.HEOOMJPIJNO, new Vector4((float)this.AMCOGJHPPOC.OJNDCCHLMNK() / (float)this.LNIFCNGGOFL.width / settings.size, (float)this.AMCOGJHPPOC.GHMBALIHBOH() / (float)this.LNIFCNGGOFL.height / settings.size, value, value2));
	}

	// Token: 0x060116E6 RID: 71398 RVA: 0x007C7D68 File Offset: 0x007C5F68
	public void IOMALGKBDHA(Material OOLNAJMJKIK)
	{
		GrainModel.Settings settings = base.BBEPCCALAFC.BDPNPPMLHBM();
		OOLNAJMJKIK.EnableKeyword("Running Slide");
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		float value = UnityEngine.Random.value;
		float value2 = UnityEngine.Random.value;
		if (this.LNIFCNGGOFL == null || !this.LNIFCNGGOFL.IsCreated())
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.LNIFCNGGOFL);
			this.LNIFCNGGOFL = new RenderTexture(-126, -152, 0, RenderTextureFormat.ARGBHalf)
			{
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 1,
				name = "_FogWaterLevel"
			};
			this.LNIFCNGGOFL.Create();
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.EIJMKFHFKDG("_Gain");
		material.SetFloat(FACEDKBCABP.HOPEEJPHNIG.IIIMHIJCPID, realtimeSinceStartup / 197f);
		Graphics.Blit(null, this.LNIFCNGGOFL, material, settings.colored ? 1 : 0);
		OOLNAJMJKIK.SetTexture(FACEDKBCABP.HOPEEJPHNIG.BEMJDDCKNCO, this.LNIFCNGGOFL);
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.AJIFMABCALL, new Vector2(settings.luminanceContribution, settings.intensity * 462f));
		OOLNAJMJKIK.SetVector(FACEDKBCABP.HOPEEJPHNIG.HEOOMJPIJNO, new Vector4((float)this.AMCOGJHPPOC.DJGCPIEOAFC() / (float)this.LNIFCNGGOFL.width / settings.size, (float)this.AMCOGJHPPOC.LKLNPJICOHH() / (float)this.LNIFCNGGOFL.height / settings.size, value, value2));
	}

	// Token: 0x060116E7 RID: 71399 RVA: 0x007C7ED5 File Offset: 0x007C60D5
	public bool BJAIILKMCBK()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.GEKPOGFKOIB().intensity <= 1399f || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Default) || !this.AMCOGJHPPOC.AFIPEFLJBBM();
	}

	// Token: 0x0400245A RID: 9306
	private RenderTexture LNIFCNGGOFL;

	// Token: 0x02000523 RID: 1315
	private static class HOPEEJPHNIG
	{
		// Token: 0x0400245B RID: 9307
		internal static readonly int AJIFMABCALL = Shader.PropertyToID("_Grain_Params1");

		// Token: 0x0400245C RID: 9308
		internal static readonly int HEOOMJPIJNO = Shader.PropertyToID("_Grain_Params2");

		// Token: 0x0400245D RID: 9309
		internal static readonly int BEMJDDCKNCO = Shader.PropertyToID("_GrainTex");

		// Token: 0x0400245E RID: 9310
		internal static readonly int IIIMHIJCPID = Shader.PropertyToID("_Phase");
	}
}
