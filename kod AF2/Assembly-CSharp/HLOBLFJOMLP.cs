using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x0200051C RID: 1308
public sealed class HLOBLFJOMLP : CFPOKEIJEAB<EyeAdaptationModel>
{
	// Token: 0x0601156C RID: 71020 RVA: 0x007BA8D4 File Offset: 0x007B8AD4
	public override void BKFHJFNCPAA()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 0; i < jehclpmcjao.Length; i++)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x0601156D RID: 71021 RVA: 0x007BA938 File Offset: 0x007B8B38
	public Texture NELEOOAGBAB(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.LPLFCDLKMLP();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("_History3LumaTex");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.GNDBFKAJJCI("_Intensity");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(72, 7);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[-67];
		}
		Vector4 vector = this.ONABIPFKBMG();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.KJOHFKLIJHE((int)vector.z, (int)vector.w, 1, JONJODLFAEN.format, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "i shrank because the inputfield was this big");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(1, 0, 0, RenderTextureFormat.ARGBHalf);
		}
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(1, 1, 1, RenderTextureFormat.BGR101010_XR);
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("KatanaReadyHigh");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "Cards", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "_TempRT", renderTexture);
		this.GLBDHAHCNCM.SetVector("Grain Lookup Texture", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 1246f), Mathf.CeilToInt((float)renderTexture.height / 1853f), 0);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.NHHNEKPKHPC(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 1241f, 957f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1254f, settings.highPercent - 218f);
		material.SetBuffer(" ", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 243f, settings.highPercent * 316f, Mathf.Exp(settings.minLuminance * 355f), Mathf.Exp(settings.maxLuminance * 1135f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("Loading ");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[0];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 1);
			Graphics.Blit(this.JEHCLPMCJAO[1], this.JEHCLPMCJAO[0]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[++num % 8];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[(num += 0) % 1];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 0) % 1;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.PNJNAECPOON(BuiltinDebugViewsModel.CGNLFGLJGKA.PreGradingLog))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(-174, -186, 0, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Repeat
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 5);
		}
		this.IJDNJLIDLJE = false;
		return this.MNLONEDGKIG;
	}

	// Token: 0x0601156E RID: 71022 RVA: 0x007BACFC File Offset: 0x007B8EFC
	public void BAAAOKJHGAO()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 0; i < jehclpmcjao.Length; i++)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x0601156F RID: 71023 RVA: 0x007BAD60 File Offset: 0x007B8F60
	public bool GDHOPOMCFPE()
	{
		return !base.BBEPCCALAFC.enabled || !SystemInfo.supportsComputeShaders || this.AMCOGJHPPOC.HALNOLGLEOJ();
	}

	// Token: 0x06011570 RID: 71024 RVA: 0x007BAD88 File Offset: 0x007B8F88
	public void NOLGBPGPBKL()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.EGDBMHIALLP().x * (float)Screen.width + 96f, 1190f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x06011571 RID: 71025 RVA: 0x007BAE00 File Offset: 0x007B9000
	public void OILPEJCKAKJ()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 1; i < jehclpmcjao.Length; i += 0)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x06011572 RID: 71026 RVA: 0x007BAE64 File Offset: 0x007B9064
	private Vector4 EIGCILBBFBC()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.OHGKBJANAKK();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1516f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.DHPPGHBNDEB() / 546f), Mathf.Floor((float)this.AMCOGJHPPOC.LKLNPJICOHH() / 702f));
	}

	// Token: 0x06011573 RID: 71027 RVA: 0x007BAED4 File Offset: 0x007B90D4
	public void KLKCKFDGMJN()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 1; i < jehclpmcjao.Length; i += 0)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x06011574 RID: 71028 RVA: 0x007BAF38 File Offset: 0x007B9138
	public void EKLDFELNMFP()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 0; i < jehclpmcjao.Length; i += 0)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x06011575 RID: 71029 RVA: 0x007BAF9C File Offset: 0x007B919C
	public Texture LPDJCNBEOIC(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.OOMCJEDGDLL();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("_CenterRadius");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NNKCNLCNDNC("TOD_MoonCloudColor");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(41, 0);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[23];
		}
		Vector4 vector = this.DHEJKJLFDAF();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.JDGIHFLNMKB((int)vector.z, (int)vector.w, 0, JONJODLFAEN.format, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "MotorbikeBackwardStand");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(0, 1, 0, RenderTextureFormat.ARGBFloat);
		}
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(1, 1, 0, (RenderTextureFormat)(-125));
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("Antares");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "GiantEat", renderTexture);
		this.GLBDHAHCNCM.SetVector("_ChannelMixerBlue", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 353f), Mathf.CeilToInt((float)renderTexture.height / 1603f), 1);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.APPMOHMABMK(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 753f, 1713f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1336f, settings.highPercent - 1401f);
		material.SetBuffer("error.wav", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 841f, settings.highPercent * 1252f, Mathf.Exp(settings.minLuminance * 1360f), Mathf.Exp(settings.maxLuminance * 112f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("paramsup=");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[0];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 0);
			Graphics.Blit(this.JEHCLPMCJAO[1], this.JEHCLPMCJAO[0]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[++num % 0];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[++num % 5];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 1) % 4;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BGKOOHLKCNJ(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(-178, -194, 0, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 0);
		}
		this.IJDNJLIDLJE = false;
		return this.MNLONEDGKIG;
	}

	// Token: 0x06011576 RID: 71030 RVA: 0x007BB360 File Offset: 0x007B9560
	public Texture HFNGLBPHNGC(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.BDCHNDFDEMN();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("WeaponReload");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NLFMCBBJHBD("_rcpFrameOpt");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(-78, 6);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[-90];
		}
		Vector4 vector = this.NJAEAGJNBFP();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.CGAACPIAKHP((int)vector.z, (int)vector.w, 1, JONJODLFAEN.format, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "IdleReadyCrouch");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(0, 1, 0, (RenderTextureFormat)39);
		}
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(0, 0, 1, (RenderTextureFormat)94);
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("{0:D2}:{1:D2}");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, " ", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "ForwardVelocity", renderTexture);
		this.GLBDHAHCNCM.SetVector("", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 334f), Mathf.CeilToInt((float)renderTexture.height / 844f), 1);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.GJKCCHCFJNO(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 186f, 1944f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 783f, settings.highPercent - 301f);
		material.SetBuffer("{0:0.} fps ping:{1} pck/sec: {2}", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 45f, settings.highPercent * 592f, Mathf.Exp(settings.minLuminance * 1182f), Mathf.Exp(settings.maxLuminance * 1066f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("WorkerHammer");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[0];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 0);
			Graphics.Blit(this.JEHCLPMCJAO[1], this.JEHCLPMCJAO[0]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[++num % 3];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[(num += 0) % 4];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 0) % 0;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.CAOCNMBBHLM(BuiltinDebugViewsModel.CGNLFGLJGKA.FocusPlane))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(-59, -14, 1, RenderTextureFormat.Depth)
				{
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Repeat
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 1);
		}
		this.IJDNJLIDLJE = true;
		return this.MNLONEDGKIG;
	}

	// Token: 0x06011577 RID: 71031 RVA: 0x007BB724 File Offset: 0x007B9924
	public void DFLLLNDKNBB()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 0; i < jehclpmcjao.Length; i++)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x06011578 RID: 71032 RVA: 0x007BB788 File Offset: 0x007B9988
	private Vector4 KMMGMFHGHEG()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.settings;
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.NMEBEEHCALN / 2f), Mathf.Floor((float)this.AMCOGJHPPOC.ILLKFNCFGMP / 2f));
	}

	// Token: 0x06011579 RID: 71033 RVA: 0x007BB7F8 File Offset: 0x007B99F8
	public Texture MPIAECGFHCN(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.DMJMEMIPKNM();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("System.Single");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.GNDBFKAJJCI("_BlurVector");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(120, 6);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[93];
		}
		Vector4 vector = this.GNBBLKLBBGF();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.EODAHPDPKJC((int)vector.z, (int)vector.w, 0, JONJODLFAEN.format, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "PLANE_REFLECTION");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(1, 0, 1, RenderTextureFormat.RG16);
		}
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(1, 0, 0, (RenderTextureFormat)32);
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("SYS");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "Mouse X", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "Закрыть", renderTexture);
		this.GLBDHAHCNCM.SetVector("cnt_energ", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 769f), Mathf.CeilToInt((float)renderTexture.height / 1417f), 0);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.APPMOHMABMK(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 170f, 1173f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1158f, settings.highPercent - 1879f);
		material.SetBuffer("cond", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 1443f, settings.highPercent * 825f, Mathf.Exp(settings.minLuminance * 738f), Mathf.Exp(settings.maxLuminance * 1771f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword(" from ");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[0];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 0);
			Graphics.Blit(this.JEHCLPMCJAO[0], this.JEHCLPMCJAO[1]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[++num % 8];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[++num % 4];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 1) % 6;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.DOHGPGNMDLM(BuiltinDebugViewsModel.CGNLFGLJGKA.None))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(-97, -57, 1, RenderTextureFormat.Depth)
				{
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Repeat
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 0);
		}
		this.IJDNJLIDLJE = false;
		return this.MNLONEDGKIG;
	}

	// Token: 0x0601157A RID: 71034 RVA: 0x007BBBBC File Offset: 0x007B9DBC
	public void LGKEFLBKIGN()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.OEDLJOEJBDH().x * (float)Screen.width + 103f, 1785f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x0601157B RID: 71035 RVA: 0x007BBC34 File Offset: 0x007B9E34
	public void IONMMKEEEBK()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 1; i < jehclpmcjao.Length; i += 0)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x0601157C RID: 71036 RVA: 0x007BBC98 File Offset: 0x007B9E98
	public void HIHJFCFNKAI()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 1; i < jehclpmcjao.Length; i += 0)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x0601157E RID: 71038 RVA: 0x007BBD18 File Offset: 0x007B9F18
	public void OGMALNDHBEE()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 0; i < jehclpmcjao.Length; i += 0)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x0601157F RID: 71039 RVA: 0x007BBD7C File Offset: 0x007B9F7C
	public void MPFBAEGNPFK()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 0; i < jehclpmcjao.Length; i += 0)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x06011580 RID: 71040 RVA: 0x007BBDE0 File Offset: 0x007B9FE0
	public void LBABEDLHAIC()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 0; i < jehclpmcjao.Length; i += 0)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x06011581 RID: 71041 RVA: 0x007BBE44 File Offset: 0x007BA044
	public void HBPAAFPALJM()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.NOCONJONFLL().x * (float)Screen.width + 1882f, 1555f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x06011582 RID: 71042 RVA: 0x007BBEBC File Offset: 0x007BA0BC
	public void HACJAOEBLFG()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 0; i < jehclpmcjao.Length; i++)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x06011583 RID: 71043 RVA: 0x007BBF20 File Offset: 0x007BA120
	private Vector4 PFPGBAMOHGC()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.GNKFCHPIOAG();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1935f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.GAIOLBJLPDL() / 1964f), Mathf.Floor((float)this.AMCOGJHPPOC.ILLKFNCFGMP / 1473f));
	}

	// Token: 0x06011584 RID: 71044 RVA: 0x007BBF90 File Offset: 0x007BA190
	private Vector4 MCGCAAAFKJG()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.CJJDODLKPFL();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1021f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.IGHJHMGOGOO() / 431f), Mathf.Floor((float)this.AMCOGJHPPOC.LPJJBJCIELA() / 6f));
	}

	// Token: 0x06011585 RID: 71045 RVA: 0x007BC000 File Offset: 0x007BA200
	public bool KEAKKLLAHFF()
	{
		return !base.BBEPCCALAFC.enabled || !SystemInfo.supportsComputeShaders || this.AMCOGJHPPOC.MLMGNHHAOHF();
	}

	// Token: 0x06011586 RID: 71046 RVA: 0x007BC028 File Offset: 0x007BA228
	public void IJKMOJONNNH()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 1; i < jehclpmcjao.Length; i += 0)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x06011587 RID: 71047 RVA: 0x007BC08C File Offset: 0x007BA28C
	private Vector4 BOMMLIAFLKM()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.CIBNPGCPGPF();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1775f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.CFDHOKHCPOJ() / 1758f), Mathf.Floor((float)this.AMCOGJHPPOC.LPJJBJCIELA() / 603f));
	}

	// Token: 0x06011588 RID: 71048 RVA: 0x007BC0FC File Offset: 0x007BA2FC
	public void CABDFNIKOOI()
	{
		this.IJDNJLIDLJE = true;
	}

	// Token: 0x06011589 RID: 71049 RVA: 0x007BC105 File Offset: 0x007BA305
	public bool KMFKAAOODGG()
	{
		return !base.BBEPCCALAFC.enabled || !SystemInfo.supportsComputeShaders || !this.AMCOGJHPPOC.GCPDMBIEAOG();
	}

	// Token: 0x0601158A RID: 71050 RVA: 0x007BC12C File Offset: 0x007BA32C
	public void NJPIOMLFAKH()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.MMAHKGNMDEF().x * (float)Screen.width + 1069f, 1219f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x0601158B RID: 71051 RVA: 0x007BC1A4 File Offset: 0x007BA3A4
	private Vector4 OOBIIFBLHIH()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.OGCJCJHFHMC();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1261f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.DJGCPIEOAFC() / 128f), Mathf.Floor((float)this.AMCOGJHPPOC.NIEGJHLHEEB() / 1751f));
	}

	// Token: 0x0601158C RID: 71052 RVA: 0x007BC214 File Offset: 0x007BA414
	public void CAKMAAJBNLK()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x0601158D RID: 71053 RVA: 0x007BC220 File Offset: 0x007BA420
	public Texture DCJJICJJCKE(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.LMHFNCJGBMG();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("<color='#003000'>{0}</color>");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.BDHEBJJGFGB("ScubaSwim");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(120, 6);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[-74];
		}
		Vector4 vector = this.AGPGOACEHHO();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.EODAHPDPKJC((int)vector.z, (int)vector.w, 1, JONJODLFAEN.format, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "sound/steps/step");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(1, 1, 0, (RenderTextureFormat)(-96));
		}
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(0, 0, 0, (RenderTextureFormat)(-72));
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("BowReady");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "UV3", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "1HandHeavySwing", renderTexture);
		this.GLBDHAHCNCM.SetVector("SwimDogPaddle", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 464f), Mathf.CeilToInt((float)renderTexture.height / 163f), 1);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OFKHPBDDKHJ(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 1408f, 51f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 776f, settings.highPercent - 665f);
		material.SetBuffer("", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 972f, settings.highPercent * 1672f, Mathf.Exp(settings.minLuminance * 1524f), Mathf.Exp(settings.maxLuminance * 397f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("PistolReload");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[1];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 0);
			Graphics.Blit(this.JEHCLPMCJAO[1], this.JEHCLPMCJAO[0]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[++num % 0];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[(num += 0) % 6];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 0) % 1;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BNJOBIPEKJD(BuiltinDebugViewsModel.CGNLFGLJGKA.FocusPlane))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(-96, 74, 1, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 4);
		}
		this.IJDNJLIDLJE = false;
		return this.MNLONEDGKIG;
	}

	// Token: 0x0601158E RID: 71054 RVA: 0x007BC5E2 File Offset: 0x007BA7E2
	public bool NHCLJOJLABJ()
	{
		return base.BBEPCCALAFC.enabled && SystemInfo.supportsComputeShaders && this.AMCOGJHPPOC.MLMGNHHAOHF();
	}

	// Token: 0x0601158F RID: 71055 RVA: 0x007BC214 File Offset: 0x007BA414
	public void FNEIKIGKDDO()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x06011590 RID: 71056 RVA: 0x007BC608 File Offset: 0x007BA808
	public bool IHDIKFHMOLC()
	{
		return base.BBEPCCALAFC.enabled && SystemInfo.supportsComputeShaders && !this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x06011591 RID: 71057 RVA: 0x007BC62E File Offset: 0x007BA82E
	public bool BGKLNGLLIHG()
	{
		return base.BBEPCCALAFC.enabled && SystemInfo.supportsComputeShaders && this.AMCOGJHPPOC.BEHHDDABAGA();
	}

	// Token: 0x06011592 RID: 71058 RVA: 0x007BC214 File Offset: 0x007BA414
	public void KKGLMJEFJOK()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x06011593 RID: 71059 RVA: 0x007BC0FC File Offset: 0x007BA2FC
	public void ONFDCFIFKDP()
	{
		this.IJDNJLIDLJE = true;
	}

	// Token: 0x06011594 RID: 71060 RVA: 0x007BC654 File Offset: 0x007BA854
	public void MHAGNPHGHIM()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.MNEDFKKLGGC().x * (float)Screen.width + 340f, 1268f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x06011595 RID: 71061 RVA: 0x007BC0FC File Offset: 0x007BA2FC
	public void CBNANODGAKP()
	{
		this.IJDNJLIDLJE = true;
	}

	// Token: 0x06011596 RID: 71062 RVA: 0x007BC6CC File Offset: 0x007BA8CC
	public Texture MJCCBMCIMFE(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.JADKPIOKKMG();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.LNIKJLLFLAO("Saves protection");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(123, 3);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[-55];
		}
		Vector4 vector = this.NCMIBJLDPIL();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.DJFOKFPMPDM((int)vector.z, (int)vector.w, 0, JONJODLFAEN.format, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "Vertical");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(1, 1, 1, (RenderTextureFormat)(-18));
		}
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(1, 0, 1, RenderTextureFormat.RG32);
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("<color='#003000'>+{0} {1}</color>");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "\n", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "currentCount=", renderTexture);
		this.GLBDHAHCNCM.SetVector(" load woman version", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 1367f), Mathf.CeilToInt((float)renderTexture.height / 969f), 1);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.NHHNEKPKHPC(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 741f, 1723f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 681f, settings.highPercent - 160f);
		material.SetBuffer("Mouse ScrollWheel", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 854f, settings.highPercent * 1922f, Mathf.Exp(settings.minLuminance * 175f), Mathf.Exp(settings.maxLuminance * 405f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("stretchWidth");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[0];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 1);
			Graphics.Blit(this.JEHCLPMCJAO[0], this.JEHCLPMCJAO[0]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[(num += 0) % 6];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[++num % 7];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 1) % 1;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.CLGLCBFDOKE(BuiltinDebugViewsModel.CGNLFGLJGKA.EyeAdaptation))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(86, -99, 1, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Repeat
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 0);
		}
		this.IJDNJLIDLJE = true;
		return this.MNLONEDGKIG;
	}

	// Token: 0x06011597 RID: 71063 RVA: 0x007BCA90 File Offset: 0x007BAC90
	public void ACJNCDAHJDE()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 1; i < jehclpmcjao.Length; i++)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x06011598 RID: 71064 RVA: 0x007BCAF4 File Offset: 0x007BACF4
	public void KMLAENJBADF()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.OKJAPMNCDLH().x * (float)Screen.width + 1308f, 1960f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x06011599 RID: 71065 RVA: 0x007BC214 File Offset: 0x007BA414
	public void GILBONCFNAN()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x0601159A RID: 71066 RVA: 0x007BCB6A File Offset: 0x007BAD6A
	public bool NKNFJAPAFIF()
	{
		return !base.BBEPCCALAFC.enabled || !SystemInfo.supportsComputeShaders || !this.AMCOGJHPPOC.HKJHMGJGNHJ();
	}

	// Token: 0x0601159B RID: 71067 RVA: 0x007BC214 File Offset: 0x007BA414
	public void LBPLMCAMFEC()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x0601159C RID: 71068 RVA: 0x007BCB90 File Offset: 0x007BAD90
	public bool IGOEANBMAIK()
	{
		return !base.BBEPCCALAFC.enabled || !SystemInfo.supportsComputeShaders || !this.AMCOGJHPPOC.FBCBNOGGGOH();
	}

	// Token: 0x0601159D RID: 71069 RVA: 0x007BCBB8 File Offset: 0x007BADB8
	public void DGLJIABJPIP()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.DACGBMKNILJ().x * (float)Screen.width + 802f, 1128f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x0601159E RID: 71070 RVA: 0x007BCC2E File Offset: 0x007BAE2E
	public bool KLOFNHGHKFC()
	{
		return base.BBEPCCALAFC.enabled && SystemInfo.supportsComputeShaders && this.AMCOGJHPPOC.HALNOLGLEOJ();
	}

	// Token: 0x0601159F RID: 71071 RVA: 0x007BCC54 File Offset: 0x007BAE54
	public Texture JCIDGLOAJBE(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.GNKFCHPIOAG();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("Failed parsing default scale values.  Using defaults.");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.MLAKMCAPCOJ("VaderChoke");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(-58, 6);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[102];
		}
		Vector4 vector = this.JGNIBEBDANK();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.PDFEEEAPMDC((int)vector.z, (int)vector.w, 1, JONJODLFAEN.format, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "demoColor");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(1, 0, 1, (RenderTextureFormat)(-80));
		}
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(0, 1, 1, (RenderTextureFormat)36);
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("isFishOnRod");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "_ReflectionTexture3", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "__a", renderTexture);
		this.GLBDHAHCNCM.SetVector("1HSwordStrafeRunLeft", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 1663f), Mathf.CeilToInt((float)renderTexture.height / 11f), 1);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OIHDKCLPEOE(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 365f, 663f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 30f, settings.highPercent - 674f);
		material.SetBuffer("post_20", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 1933f, settings.highPercent * 656f, Mathf.Exp(settings.minLuminance * 1520f), Mathf.Exp(settings.maxLuminance * 241f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("Отпущено {0} рыб, общим весом \n<color='#a000ff'>{1}</color>\nПолучено {2} опыта");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[0];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 1);
			Graphics.Blit(this.JEHCLPMCJAO[0], this.JEHCLPMCJAO[1]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[++num % 0];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[(num += 0) % 8];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 1) % 5;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.GNHGEGEPHCI(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(130, -84, 1, RenderTextureFormat.Depth)
				{
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 4);
		}
		this.IJDNJLIDLJE = true;
		return this.MNLONEDGKIG;
	}

	// Token: 0x060115A0 RID: 71072 RVA: 0x007BD018 File Offset: 0x007BB218
	public void BGJFLKLBOPK()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.MNEDFKKLGGC().x * (float)Screen.width + 1294f, 1823f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x060115A1 RID: 71073 RVA: 0x007BD090 File Offset: 0x007BB290
	public Texture GEBNGMPHOGG(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.OOMCJEDGDLL();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("auk_wmin");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JBLDPJMMJOL("WorkerHammer2");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(54, 3);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[36];
		}
		Vector4 vector = this.AFOPIHHCNCF();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.HJFNEOFMJEJ((int)vector.z, (int)vector.w, 1, JONJODLFAEN.format, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "sunshine_CameraVToSunVP");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(1, 0, 0, (RenderTextureFormat)62);
		}
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(0, 0, 0, (RenderTextureFormat)(-115));
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("final ok: ");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "ShotgunReadyFire", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "RendererD2 is init", renderTexture);
		this.GLBDHAHCNCM.SetVector("____________________________________", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 1869f), Mathf.CeilToInt((float)renderTexture.height / 1896f), 0);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OFKHPBDDKHJ(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 97f, 300f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1625f, settings.highPercent - 204f);
		material.SetBuffer("ScatterColor", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 1268f, settings.highPercent * 1555f, Mathf.Exp(settings.minLuminance * 1380f), Mathf.Exp(settings.maxLuminance * 1310f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("BackPackSearch");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[1];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 1);
			Graphics.Blit(this.JEHCLPMCJAO[0], this.JEHCLPMCJAO[0]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[(num += 0) % 3];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[(num += 0) % 7];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 1) % 1;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.PNJNAECPOON(BuiltinDebugViewsModel.CGNLFGLJGKA.PreGradingLog))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(146, -107, 1, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 5);
		}
		this.IJDNJLIDLJE = false;
		return this.MNLONEDGKIG;
	}

	// Token: 0x060115A2 RID: 71074 RVA: 0x007BC214 File Offset: 0x007BA414
	public void IBOMADDAFAO()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x060115A3 RID: 71075 RVA: 0x007BD452 File Offset: 0x007BB652
	public bool BJAIILKMCBK()
	{
		return !base.BBEPCCALAFC.enabled || !SystemInfo.supportsComputeShaders || this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x060115A4 RID: 71076 RVA: 0x007BD478 File Offset: 0x007BB678
	private Vector4 DHEJKJLFDAF()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.FHNBLOAHNPD();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1670f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.IGHJHMGOGOO() / 953f), Mathf.Floor((float)this.AMCOGJHPPOC.MMEMLJENMFF() / 1436f));
	}

	// Token: 0x060115A5 RID: 71077 RVA: 0x007BD4E8 File Offset: 0x007BB6E8
	public void LNEJPGDHJOJ()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 1; i < jehclpmcjao.Length; i += 0)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x060115A6 RID: 71078 RVA: 0x007BC0FC File Offset: 0x007BA2FC
	public void IEHEAJJALNG()
	{
		this.IJDNJLIDLJE = true;
	}

	// Token: 0x060115A7 RID: 71079 RVA: 0x007BD54C File Offset: 0x007BB74C
	private Vector4 DKMELBAMBMJ()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.MMLOJEBPMII();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 454f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.FOBPENGADNB() / 1472f), Mathf.Floor((float)this.AMCOGJHPPOC.CICDECHCDBJ() / 1833f));
	}

	// Token: 0x060115A8 RID: 71080 RVA: 0x007BD5BC File Offset: 0x007BB7BC
	private Vector4 NJAEAGJNBFP()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.BDCHNDFDEMN();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 123f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.EOMMKPDCAML() / 562f), Mathf.Floor((float)this.AMCOGJHPPOC.ILLKFNCFGMP / 666f));
	}

	// Token: 0x060115A9 RID: 71081 RVA: 0x007BD62C File Offset: 0x007BB82C
	public Texture ONKPHHNHNDH(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.CEBNJKGGMIE();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("RollerBladeGrindRoyale");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.PIPNAHLJKKD("");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(-35, 0);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[-72];
		}
		Vector4 vector = this.JGNIBEBDANK();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.EODAHPDPKJC((int)vector.z, (int)vector.w, 0, JONJODLFAEN.format, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "_PrevViewProj");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(1, 0, 1, (RenderTextureFormat)122);
		}
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(1, 1, 0, (RenderTextureFormat)(-1));
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("UNIQUE_SHADOW_LIGHT_COOKIE");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "demoDouble", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "", renderTexture);
		this.GLBDHAHCNCM.SetVector("System.Boolean", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 230f), Mathf.CeilToInt((float)renderTexture.height / 847f), 0);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.KEIICHJKHMA(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 1585f, 1620f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1947f, settings.highPercent - 1813f);
		material.SetBuffer("error.wav", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 1272f, settings.highPercent * 217f, Mathf.Exp(settings.minLuminance * 1488f), Mathf.Exp(settings.maxLuminance * 1657f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("OneHandSwordBackSwing");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[0];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 1);
			Graphics.Blit(this.JEHCLPMCJAO[0], this.JEHCLPMCJAO[0]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[++num % 2];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[(num += 0) % 2];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 0) % 5;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BNJOBIPEKJD(BuiltinDebugViewsModel.CGNLFGLJGKA.Normals))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(-68, 134, 1, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 8);
		}
		this.IJDNJLIDLJE = false;
		return this.MNLONEDGKIG;
	}

	// Token: 0x060115AA RID: 71082 RVA: 0x007BC214 File Offset: 0x007BA414
	public void EBLJKEAHIGD()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x060115AB RID: 71083 RVA: 0x007BD9F0 File Offset: 0x007BBBF0
	private Vector4 AFOPIHHCNCF()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.KHBPABICFOF();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 30f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.DJGCPIEOAFC() / 66f), Mathf.Floor((float)this.AMCOGJHPPOC.CICDECHCDBJ() / 1004f));
	}

	// Token: 0x060115AC RID: 71084 RVA: 0x007BDA60 File Offset: 0x007BBC60
	public Texture NLLIKOCNDOO(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.GNKFCHPIOAG();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.IBMKEBEEFKP("abcd");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(-25, 7);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[-70];
		}
		Vector4 vector = this.DHEJKJLFDAF();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.KJOHFKLIJHE((int)vector.z, (int)vector.w, 1, JONJODLFAEN.format, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "isFishGet");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(0, 1, 1, (RenderTextureFormat)65);
		}
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(0, 1, 1, (RenderTextureFormat)(-31));
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("MotorbikeBackwardSitting");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "isWoman", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "PistolReady", renderTexture);
		this.GLBDHAHCNCM.SetVector("inv_pcs2", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 1938f), Mathf.CeilToInt((float)renderTexture.height / 1325f), 0);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.NHHNEKPKHPC(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 272f, 1993f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 664f, settings.highPercent - 1392f);
		material.SetBuffer("CrouchStrafeRight", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 376f, settings.highPercent * 727f, Mathf.Exp(settings.minLuminance * 465f), Mathf.Exp(settings.maxLuminance * 59f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("wpn_iwgt");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[0];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 1);
			Graphics.Blit(this.JEHCLPMCJAO[1], this.JEHCLPMCJAO[0]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[++num % 1];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[(num += 0) % 1];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 1) % 8;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BNJOBIPEKJD(BuiltinDebugViewsModel.CGNLFGLJGKA.FocusPlane))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(121, -28, 0, RenderTextureFormat.Depth)
				{
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Repeat
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 5);
		}
		this.IJDNJLIDLJE = true;
		return this.MNLONEDGKIG;
	}

	// Token: 0x060115AD RID: 71085 RVA: 0x007BDE24 File Offset: 0x007BC024
	private Vector4 CNCMBICJBPL()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.OHGKBJANAKK();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1681f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.NMCCGCOKKFA() / 1587f), Mathf.Floor((float)this.AMCOGJHPPOC.HJOKFIGACEC() / 1188f));
	}

	// Token: 0x060115AE RID: 71086 RVA: 0x007BDE94 File Offset: 0x007BC094
	private Vector4 JGNIBEBDANK()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.LPLFCDLKMLP();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 721f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.NMEBEEHCALN / 841f), Mathf.Floor((float)this.AMCOGJHPPOC.LKLNPJICOHH() / 1594f));
	}

	// Token: 0x060115AF RID: 71087 RVA: 0x007BDF04 File Offset: 0x007BC104
	public bool LMPCAJNGJOI()
	{
		return base.BBEPCCALAFC.enabled && SystemInfo.supportsComputeShaders && !this.AMCOGJHPPOC.ODNAHJKPHKA();
	}

	// Token: 0x060115B0 RID: 71088 RVA: 0x007BDF2C File Offset: 0x007BC12C
	public void PNJNNNJEBGA()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.AICCPACEFOK().x * (float)Screen.width + 898f, 1652f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x060115B1 RID: 71089 RVA: 0x007BDFA4 File Offset: 0x007BC1A4
	public void EOCENEIDJKI()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.OKJAPMNCDLH().x * (float)Screen.width + 429f, 1833f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x060115B2 RID: 71090 RVA: 0x007BC214 File Offset: 0x007BA414
	public void CALDPCOLDNO()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x060115B3 RID: 71091 RVA: 0x007BE01C File Offset: 0x007BC21C
	public void PIPJPGGEFOL()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 1; i < jehclpmcjao.Length; i += 0)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x060115B4 RID: 71092 RVA: 0x007BE080 File Offset: 0x007BC280
	private Vector4 ILDGMDGCKHM()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.MEPIPLDFEJH();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1561f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.KDBADMLHBNP() / 158f), Mathf.Floor((float)this.AMCOGJHPPOC.CICDECHCDBJ() / 97f));
	}

	// Token: 0x060115B5 RID: 71093 RVA: 0x007BE0F0 File Offset: 0x007BC2F0
	public Texture BILFPDPDGHG(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.ELAENDGMHFF();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("NOISE_ON");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DLNFGMANLPN("Flap_04.wav");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(46, 4);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[10];
		}
		Vector4 vector = this.BNCPHPMCLGF();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.JDGIHFLNMKB((int)vector.z, (int)vector.w, 1, JONJODLFAEN.format, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "The object '{0}' has a ProBuilder attachment component which contains zero attached elements.");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(0, 1, 1, RenderTextureFormat.ARGB4444);
		}
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(0, 1, 1, (RenderTextureFormat)(-111));
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("Show last 128 records");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "WeaponRun", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "shop_t7", renderTexture);
		this.GLBDHAHCNCM.SetVector("MotorbikeSpecialFlip", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 1373f), Mathf.CeilToInt((float)renderTexture.height / 1643f), 0);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.KEIICHJKHMA(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 276f, 1234f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1383f, settings.highPercent - 1510f);
		material.SetBuffer("inv_impr", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 742f, settings.highPercent * 1252f, Mathf.Exp(settings.minLuminance * 880f), Mathf.Exp(settings.maxLuminance * 1755f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[0];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 1);
			Graphics.Blit(this.JEHCLPMCJAO[0], this.JEHCLPMCJAO[1]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[++num % 4];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[(num += 0) % 4];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 1) % 2;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.DAKPGCMKCJP(BuiltinDebugViewsModel.CGNLFGLJGKA.LogLut))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(136, -71, 0, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 4);
		}
		this.IJDNJLIDLJE = false;
		return this.MNLONEDGKIG;
	}

	// Token: 0x060115B6 RID: 71094 RVA: 0x007BE4B2 File Offset: 0x007BC6B2
	public bool AEAADJMKKLK()
	{
		return base.BBEPCCALAFC.enabled && SystemInfo.supportsComputeShaders && !this.AMCOGJHPPOC.NOAGCLGAJNE();
	}

	// Token: 0x060115B7 RID: 71095 RVA: 0x007BE4D8 File Offset: 0x007BC6D8
	public void EDFACHIGJGG()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.JOPDIOGMCEF().x * (float)Screen.width + 886f, 30f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x060115B8 RID: 71096 RVA: 0x007BE550 File Offset: 0x007BC750
	public void EJNHHHFOOOC()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.DACGBMKNILJ().x * (float)Screen.width + 475f, 125f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x060115B9 RID: 71097 RVA: 0x007BE5C6 File Offset: 0x007BC7C6
	public bool GINFOAMILDE()
	{
		return !base.BBEPCCALAFC.enabled || !SystemInfo.supportsComputeShaders || this.AMCOGJHPPOC.AFIPEFLJBBM();
	}

	// Token: 0x060115BA RID: 71098 RVA: 0x007BC214 File Offset: 0x007BA414
	public void AOABMLPHMME()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x060115BB RID: 71099 RVA: 0x007BE5EC File Offset: 0x007BC7EC
	private Vector4 ONEHBODHOBC()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.MMLOJEBPMII();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 834f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.CFDHOKHCPOJ() / 501f), Mathf.Floor((float)this.AMCOGJHPPOC.KNKKIHDHBFD() / 505f));
	}

	// Token: 0x170003CA RID: 970
	// (get) Token: 0x060115BC RID: 71100 RVA: 0x007BE65C File Offset: 0x007BC85C
	public override bool NLFEIOCKHKA
	{
		get
		{
			return base.BBEPCCALAFC.enabled && SystemInfo.supportsComputeShaders && !this.AMCOGJHPPOC.CFABOAAPLPI;
		}
	}

	// Token: 0x060115BD RID: 71101 RVA: 0x007BC214 File Offset: 0x007BA414
	public void MJCMLMAEAPL()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x060115BE RID: 71102 RVA: 0x007BC214 File Offset: 0x007BA414
	public void IDJOMLFLFCF()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x060115BF RID: 71103 RVA: 0x007BE684 File Offset: 0x007BC884
	private Vector4 ONABIPFKBMG()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.FHNBLOAHNPD();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1476f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.CFDHOKHCPOJ() / 1536f), Mathf.Floor((float)this.AMCOGJHPPOC.FHCDJOLMIMG() / 1690f));
	}

	// Token: 0x060115C0 RID: 71104 RVA: 0x007BE6F4 File Offset: 0x007BC8F4
	public void PEPOOEGHCMC()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 0; i < jehclpmcjao.Length; i++)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x060115C1 RID: 71105 RVA: 0x007BE758 File Offset: 0x007BC958
	public void LAOBJGDOJDH()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 0; i < jehclpmcjao.Length; i++)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x060115C2 RID: 71106 RVA: 0x007BE7BC File Offset: 0x007BC9BC
	public void BKFLIDKPDDI()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.OEDLJOEJBDH().x * (float)Screen.width + 35f, 838f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x060115C3 RID: 71107 RVA: 0x007BE834 File Offset: 0x007BCA34
	public void GMJFHNCPCBN()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 1; i < jehclpmcjao.Length; i++)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x060115C4 RID: 71108 RVA: 0x007BE898 File Offset: 0x007BCA98
	public void BEOFOEMOJAN()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.EGDBMHIALLP().x * (float)Screen.width + 828f, 146f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x060115C5 RID: 71109 RVA: 0x007BE90E File Offset: 0x007BCB0E
	public bool IJLFFLDAPDL()
	{
		return !base.BBEPCCALAFC.enabled || !SystemInfo.supportsComputeShaders || !this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x060115C6 RID: 71110 RVA: 0x007BE934 File Offset: 0x007BCB34
	private Vector4 GNBBLKLBBGF()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.CCBOEPHFGKE();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 351f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.LBAMMHHGCGL() / 1339f), Mathf.Floor((float)this.AMCOGJHPPOC.GHMBALIHBOH() / 1968f));
	}

	// Token: 0x060115C7 RID: 71111 RVA: 0x007BE9A4 File Offset: 0x007BCBA4
	public Texture KOJFFFMCCBO(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.LPLFCDLKMLP();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("Seat Stand");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NLFMCBBJHBD("offsets");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(-92, 6);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[65];
		}
		Vector4 vector = this.LPLDMDAKNNL();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.JJFELDJCAFA((int)vector.z, (int)vector.w, 1, JONJODLFAEN.format, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "Нечего отпускать!");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(0, 0, 1, (RenderTextureFormat)89);
		}
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(0, 0, 0, RenderTextureFormat.ARGBFloat);
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("WRINKLE_MAPS");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "Pick Up ", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "DeadmanFloat", renderTexture);
		this.GLBDHAHCNCM.SetVector("1 Hand Sword Jab Foot Push", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 1034f), Mathf.CeilToInt((float)renderTexture.height / 1405f), 1);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.GJKCCHCFJNO(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 1480f, 1167f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 829f, settings.highPercent - 1261f);
		material.SetBuffer("_WaveScale4", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 1682f, settings.highPercent * 1381f, Mathf.Exp(settings.minLuminance * 1342f), Mathf.Exp(settings.maxLuminance * 1078f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("The shader ");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[0];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 0);
			Graphics.Blit(this.JEHCLPMCJAO[0], this.JEHCLPMCJAO[1]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[++num % 4];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[++num % 7];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 1) % 8;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.EEFEOJIOAMA(BuiltinDebugViewsModel.CGNLFGLJGKA.Depth))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(196, 103, 1, RenderTextureFormat.Depth)
				{
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 6);
		}
		this.IJDNJLIDLJE = true;
		return this.MNLONEDGKIG;
	}

	// Token: 0x060115C8 RID: 71112 RVA: 0x007BED68 File Offset: 0x007BCF68
	private Vector4 CBOONNCEFDF()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.EFCLGKFCEMI();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 128f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.IGHJHMGOGOO() / 1251f), Mathf.Floor((float)this.AMCOGJHPPOC.GGGEFNKEPDB() / 1785f));
	}

	// Token: 0x060115C9 RID: 71113 RVA: 0x007BEDD8 File Offset: 0x007BCFD8
	private Vector4 BNCPHPMCLGF()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.JADKPIOKKMG();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 581f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.LJJOEDIJPEM() / 168f), Mathf.Floor((float)this.AMCOGJHPPOC.LHPBMEDMNDO() / 1196f));
	}

	// Token: 0x060115CA RID: 71114 RVA: 0x007BEE48 File Offset: 0x007BD048
	private Vector4 GKAFBLGJNKE()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.CCBOEPHFGKE();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 265f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.DHPPGHBNDEB() / 578f), Mathf.Floor((float)this.AMCOGJHPPOC.MMEMLJENMFF() / 1298f));
	}

	// Token: 0x060115CB RID: 71115 RVA: 0x007BC214 File Offset: 0x007BA414
	public void NFJKCBFCHBP()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x060115CC RID: 71116 RVA: 0x007BE90E File Offset: 0x007BCB0E
	public bool HEGFBNOJMOO()
	{
		return !base.BBEPCCALAFC.enabled || !SystemInfo.supportsComputeShaders || !this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x060115CD RID: 71117 RVA: 0x007BEEB8 File Offset: 0x007BD0B8
	public bool GIAKLNBJHDH()
	{
		return !base.BBEPCCALAFC.enabled || !SystemInfo.supportsComputeShaders || !this.AMCOGJHPPOC.ODNAHJKPHKA();
	}

	// Token: 0x060115CE RID: 71118 RVA: 0x007BEEE0 File Offset: 0x007BD0E0
	public Texture FHLMOMGGELB(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.KHBPABICFOF();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("The 'BackColor' command requires a color parameter of RRGGBBAA or '?'.");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.MLAKMCAPCOJ("[AmplifyColor] This image effect is not supported on this platform.");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(48, 1);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[39];
		}
		Vector4 vector = this.GNBBLKLBBGF();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.OAJBECLLIEP((int)vector.z, (int)vector.w, 1, JONJODLFAEN.format, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "wpn_book2");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(0, 1, 0, (RenderTextureFormat)59);
		}
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(1, 0, 1, (RenderTextureFormat)41);
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("Run Dive");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "ShotgunReloadMagazine", renderTexture);
		this.GLBDHAHCNCM.SetVector("invn_rec13", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 420f), Mathf.CeilToInt((float)renderTexture.height / 1275f), 0);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OFKHPBDDKHJ(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 327f, 1003f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 580f, settings.highPercent - 1631f);
		material.SetBuffer("MotorbikeShootBack", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 1815f, settings.highPercent * 1260f, Mathf.Exp(settings.minLuminance * 1647f), Mathf.Exp(settings.maxLuminance * 74f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("[");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[1];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 0);
			Graphics.Blit(this.JEHCLPMCJAO[0], this.JEHCLPMCJAO[1]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[++num % 8];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[(num += 0) % 0];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 1) % 8;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BGKOOHLKCNJ(BuiltinDebugViewsModel.CGNLFGLJGKA.MotionVectors))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(80, 88, 0, RenderTextureFormat.Depth)
				{
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Repeat
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 1);
		}
		this.IJDNJLIDLJE = true;
		return this.MNLONEDGKIG;
	}

	// Token: 0x060115CF RID: 71119 RVA: 0x007BF2A4 File Offset: 0x007BD4A4
	private Vector4 NCMIBJLDPIL()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.GNKFCHPIOAG();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 315f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.DHPPGHBNDEB() / 529f), Mathf.Floor((float)this.AMCOGJHPPOC.CICDECHCDBJ() / 297f));
	}

	// Token: 0x060115D0 RID: 71120 RVA: 0x007BC214 File Offset: 0x007BA414
	public void ELBOGKCENFA()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x060115D1 RID: 71121 RVA: 0x007BC0FC File Offset: 0x007BA2FC
	public void GGNPNBDONAI()
	{
		this.IJDNJLIDLJE = true;
	}

	// Token: 0x060115D2 RID: 71122 RVA: 0x007BF314 File Offset: 0x007BD514
	public void GHOJCADBKEK()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.LKGIPCPDFLE().x * (float)Screen.width + 360f, 560f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x060115D3 RID: 71123 RVA: 0x007BF38C File Offset: 0x007BD58C
	public void BNCAPAJOMIA()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 0; i < jehclpmcjao.Length; i += 0)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x060115D4 RID: 71124 RVA: 0x007BC214 File Offset: 0x007BA414
	public void ODCHALJHGDC()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x060115D5 RID: 71125 RVA: 0x007BF3F0 File Offset: 0x007BD5F0
	public bool EIKMLIHNIAF()
	{
		return base.BBEPCCALAFC.enabled && SystemInfo.supportsComputeShaders && !this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x060115D6 RID: 71126 RVA: 0x007BF418 File Offset: 0x007BD618
	public void ANFHJIIMJNL()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.EMBHPOAEALM.x * (float)Screen.width + 8f, 8f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x060115D7 RID: 71127 RVA: 0x007BF490 File Offset: 0x007BD690
	private Vector4 OAOIJLJCOCN()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.BKMNGCEJJOM();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1217f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.GMOLEDNNPEH() / 842f), Mathf.Floor((float)this.AMCOGJHPPOC.GHMBALIHBOH() / 1196f));
	}

	// Token: 0x060115D8 RID: 71128 RVA: 0x007BF500 File Offset: 0x007BD700
	private Vector4 LJJBHEDPIDD()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.CCBOEPHFGKE();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1193f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.DJGCPIEOAFC() / 600f), Mathf.Floor((float)this.AMCOGJHPPOC.LHPBMEDMNDO() / 632f));
	}

	// Token: 0x060115D9 RID: 71129 RVA: 0x007BF570 File Offset: 0x007BD770
	public Texture BLAIBKFMCEM(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.LPLFCDLKMLP();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("http://www.root-motion.com/finalikdox/html/page12.html");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JDGIHFLNMKB("BendGoal is deprecated, you can now a bend goal from the custom inspector of the LimbIK component.");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(-74, 0);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[13];
		}
		Vector4 vector = this.DKMELBAMBMJ();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.HJFNEOFMJEJ((int)vector.z, (int)vector.w, 0, JONJODLFAEN.format, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "author");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(0, 0, 0, (RenderTextureFormat)(-37));
		}
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(0, 0, 1, (RenderTextureFormat)75);
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("user.standFlag ok");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "LookUp", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "UnityEngine.Vector2", renderTexture);
		this.GLBDHAHCNCM.SetVector("gameComplete", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 1572f), Mathf.CeilToInt((float)renderTexture.height / 1866f), 1);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OIHDKCLPEOE(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 1745f, 1434f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 398f, settings.highPercent - 1806f);
		material.SetBuffer("rollSoundIndex", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 537f, settings.highPercent * 1612f, Mathf.Exp(settings.minLuminance * 1474f), Mathf.Exp(settings.maxLuminance * 838f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("Citates.xml");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[1];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 1);
			Graphics.Blit(this.JEHCLPMCJAO[1], this.JEHCLPMCJAO[0]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[++num % 2];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[(num += 0) % 1];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 0) % 2;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.CAOCNMBBHLM(BuiltinDebugViewsModel.CGNLFGLJGKA.None))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(66, -123, 1, RenderTextureFormat.Depth)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Repeat
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 3);
		}
		this.IJDNJLIDLJE = false;
		return this.MNLONEDGKIG;
	}

	// Token: 0x060115DA RID: 71130 RVA: 0x007BF934 File Offset: 0x007BDB34
	public Texture MCKPBNDIOJF(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.EFCLGKFCEMI();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("othermenu");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.CPFHLGIKEJC("podsek action!");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(33, 8);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[61];
		}
		Vector4 vector = this.BNCPHPMCLGF();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.AFONGIICOJG((int)vector.z, (int)vector.w, 1, JONJODLFAEN.format, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "Builtin Debug Views");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(0, 1, 1, (RenderTextureFormat)102);
		}
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(1, 0, 1, (RenderTextureFormat)77);
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("rait_5");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "isRealView", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "Hidden/TonemappingColorGrading", renderTexture);
		this.GLBDHAHCNCM.SetVector("{0:F2}, {1:F2}, {2:F2}, {3:F2}", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 1652f), Mathf.CeilToInt((float)renderTexture.height / 742f), 0);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.IKEIEMKIEKG(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 18f, 1551f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1580f, settings.highPercent - 1190f);
		material.SetBuffer("ArmFlex", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 1439f, settings.highPercent * 1040f, Mathf.Exp(settings.minLuminance * 1932f), Mathf.Exp(settings.maxLuminance * 382f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[1];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 0);
			Graphics.Blit(this.JEHCLPMCJAO[1], this.JEHCLPMCJAO[1]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[(num += 0) % 1];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[++num % 6];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 1) % 4;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.EEFEOJIOAMA(BuiltinDebugViewsModel.CGNLFGLJGKA.FocusPlane))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(-20, -5, 0, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 3);
		}
		this.IJDNJLIDLJE = true;
		return this.MNLONEDGKIG;
	}

	// Token: 0x060115DB RID: 71131 RVA: 0x007BFCF8 File Offset: 0x007BDEF8
	private Vector4 KJFMGDACEOB()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.OHGKBJANAKK();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1491f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.NMEBEEHCALN / 442f), Mathf.Floor((float)this.AMCOGJHPPOC.LHPBMEDMNDO() / 831f));
	}

	// Token: 0x060115DC RID: 71132 RVA: 0x007BC214 File Offset: 0x007BA414
	public void ADPEOCBFJGI()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x060115DD RID: 71133 RVA: 0x007BC0FC File Offset: 0x007BA2FC
	public override void ADBAOPJBGHG()
	{
		this.IJDNJLIDLJE = true;
	}

	// Token: 0x060115DE RID: 71134 RVA: 0x007BFD68 File Offset: 0x007BDF68
	public bool JHHOEHKKPEI()
	{
		return !base.BBEPCCALAFC.enabled || !SystemInfo.supportsComputeShaders || this.AMCOGJHPPOC.HFIFOAPFKBG();
	}

	// Token: 0x060115DF RID: 71135 RVA: 0x007BC0FC File Offset: 0x007BA2FC
	public void NAEMLGBBDEF()
	{
		this.IJDNJLIDLJE = true;
	}

	// Token: 0x060115E0 RID: 71136 RVA: 0x007BC214 File Offset: 0x007BA414
	public void OGDKPBNOBND()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x060115E1 RID: 71137 RVA: 0x007BFD90 File Offset: 0x007BDF90
	public Texture HDLIGPFFGKL(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.settings;
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>(" %\n");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(-22, 0);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[-74];
		}
		Vector4 vector = this.CNCMBICJBPL();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.CGAACPIAKHP((int)vector.z, (int)vector.w, 1, JONJODLFAEN.format, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(0, 1, 0, (RenderTextureFormat)105);
		}
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(1, 1, 0, (RenderTextureFormat)72);
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("Windmill");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "The object '{0}' has a ProBuilder attachment component which contains zero attached elements.", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "showUsersInChat", renderTexture);
		this.GLBDHAHCNCM.SetVector("Spine bones contains a null reference.", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 988f), Mathf.CeilToInt((float)renderTexture.height / 134f), 1);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.GJKCCHCFJNO(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 722f, 1500f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 807f, settings.highPercent - 1734f);
		material.SetBuffer("BC ", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 530f, settings.highPercent * 1913f, Mathf.Exp(settings.minLuminance * 1594f), Mathf.Exp(settings.maxLuminance * 841f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("_TintColor");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[1];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 1);
			Graphics.Blit(this.JEHCLPMCJAO[0], this.JEHCLPMCJAO[1]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[(num += 0) % 6];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[(num += 0) % 2];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 1) % 7;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BGKOOHLKCNJ(BuiltinDebugViewsModel.CGNLFGLJGKA.Depth))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(104, 65, 0, RenderTextureFormat.Depth)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 8);
		}
		this.IJDNJLIDLJE = true;
		return this.MNLONEDGKIG;
	}

	// Token: 0x060115E2 RID: 71138 RVA: 0x007C0154 File Offset: 0x007BE354
	public void HPGMKBPAFGM()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 1; i < jehclpmcjao.Length; i++)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x060115E3 RID: 71139 RVA: 0x007C01B8 File Offset: 0x007BE3B8
	public void LAFIABNCFPD()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 1; i < jehclpmcjao.Length; i++)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x060115E4 RID: 71140 RVA: 0x007C021C File Offset: 0x007BE41C
	public bool NDMDJCLKALK()
	{
		return !base.BBEPCCALAFC.enabled || !SystemInfo.supportsComputeShaders || !this.AMCOGJHPPOC.CFABOAAPLPI;
	}

	// Token: 0x060115E5 RID: 71141 RVA: 0x007BC0FC File Offset: 0x007BA2FC
	public void FJBPGBMDBBF()
	{
		this.IJDNJLIDLJE = true;
	}

	// Token: 0x060115E6 RID: 71142 RVA: 0x007BC214 File Offset: 0x007BA414
	public void IKIEPGKILKH()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x060115E7 RID: 71143 RVA: 0x007C0244 File Offset: 0x007BE444
	public Texture NDKOGFAMJEP(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.GJNMNCOFKEP();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("1");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.HJFNEOFMJEJ("/");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(-96, 8);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[32];
		}
		Vector4 vector = this.KMMGMFHGHEG();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.KJOHFKLIJHE((int)vector.z, (int)vector.w, 1, JONJODLFAEN.format, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "Fog");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(1, 0, 0, (RenderTextureFormat)(-27));
		}
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(1, 1, 0, (RenderTextureFormat)65);
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("auc_wcswcp");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, ")", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, " no woman version! ", renderTexture);
		this.GLBDHAHCNCM.SetVector("iPoint", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 535f), Mathf.CeilToInt((float)renderTexture.height / 182f), 1);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.MLIOBPENIKG(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 240f, 657f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1337f, settings.highPercent - 1706f);
		material.SetBuffer("_isSelect", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 416f, settings.highPercent * 182f, Mathf.Exp(settings.minLuminance * 61f), Mathf.Exp(settings.maxLuminance * 1684f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("Hey, you can easily change me in memory!");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[1];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 0);
			Graphics.Blit(this.JEHCLPMCJAO[1], this.JEHCLPMCJAO[0]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[++num % 7];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[++num % 0];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 0) % 1;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.DOHGPGNMDLM(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(-147, -199, 0, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Repeat
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 4);
		}
		this.IJDNJLIDLJE = true;
		return this.MNLONEDGKIG;
	}

	// Token: 0x060115E8 RID: 71144 RVA: 0x007BC214 File Offset: 0x007BA414
	public void OILLNFAJPKK()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x060115E9 RID: 71145 RVA: 0x007C0608 File Offset: 0x007BE808
	public Texture FBBBNHPGBKC(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.settings;
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("Shaders/EyeHistogram");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/Eye Adaptation");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(64, 4);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[64];
		}
		Vector4 vector = this.KMMGMFHGHEG();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.AFONGIICOJG((int)vector.z, (int)vector.w, 0, JONJODLFAEN.format, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "FactoryTempTexture");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(1, 1, 0, RenderTextureFormat.RFloat);
		}
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(1, 1, 0, RenderTextureFormat.RFloat);
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("KEyeHistogram");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "_Histogram", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "_Source", renderTexture);
		this.GLBDHAHCNCM.SetVector("_ScaleOffsetRes", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 16f), Mathf.CeilToInt((float)renderTexture.height / 16f), 1);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OFKHPBDDKHJ(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 1.01f, 99f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1f, settings.highPercent - 0.01f);
		material.SetBuffer("_Histogram", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 0.01f, settings.highPercent * 0.01f, Mathf.Exp(settings.minLuminance * 0.6931472f), Mathf.Exp(settings.maxLuminance * 0.6931472f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("AUTO_KEY_VALUE");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[0];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 1);
			Graphics.Blit(this.JEHCLPMCJAO[0], this.JEHCLPMCJAO[1]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[++num % 2];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[++num % 2];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 1) % 2;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.CLGLCBFDOKE(BuiltinDebugViewsModel.CGNLFGLJGKA.EyeAdaptation))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(256, 128, 0, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 2);
		}
		this.IJDNJLIDLJE = false;
		return this.MNLONEDGKIG;
	}

	// Token: 0x060115EA RID: 71146 RVA: 0x007C09CC File Offset: 0x007BEBCC
	public Texture CKIENEMPGLL(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.CCBOEPHFGKE();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("CratePull");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.PIPNAHLJKKD("1HandSwordRollAttack");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(64, 5);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[-91];
		}
		Vector4 vector = this.DKMELBAMBMJ();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.KJOHFKLIJHE((int)vector.z, (int)vector.w, 1, JONJODLFAEN.format, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "SatNightFever");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(0, 1, 1, (RenderTextureFormat)(-101));
		}
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(0, 1, 0, (RenderTextureFormat)84);
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("ObscuredUInt:");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "_FogDensity", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "auc_wcstc", renderTexture);
		this.GLBDHAHCNCM.SetVector("wpn_line1", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 641f), Mathf.CeilToInt((float)renderTexture.height / 1400f), 0);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.KEIICHJKHMA(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 1630f, 351f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1945f, settings.highPercent - 1547f);
		material.SetBuffer("_HighlightSuppression", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 1150f, settings.highPercent * 1183f, Mathf.Exp(settings.minLuminance * 891f), Mathf.Exp(settings.maxLuminance * 1563f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("Billboards reference not set.");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[0];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 1);
			Graphics.Blit(this.JEHCLPMCJAO[0], this.JEHCLPMCJAO[1]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[(num += 0) % 8];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[++num % 3];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 0) % 2;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.GNHGEGEPHCI(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(60, -13, 1, RenderTextureFormat.ARGB32)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 5);
		}
		this.IJDNJLIDLJE = false;
		return this.MNLONEDGKIG;
	}

	// Token: 0x060115EB RID: 71147 RVA: 0x007C0D90 File Offset: 0x007BEF90
	public void LHIPAEHDLHO()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 1; i < jehclpmcjao.Length; i += 0)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x060115EC RID: 71148 RVA: 0x007C0DF4 File Offset: 0x007BEFF4
	public void BNOLDFLILJA()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 0; i < jehclpmcjao.Length; i++)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x060115ED RID: 71149 RVA: 0x007C0E58 File Offset: 0x007BF058
	public void DAIKHLLJCPL()
	{
		RenderTexture[] jehclpmcjao = this.JEHCLPMCJAO;
		for (int i = 1; i < jehclpmcjao.Length; i++)
		{
			CDBICMCJFCE.MHJKBMIOGCD(jehclpmcjao[i]);
		}
		if (this.ANJHIIPMGGA != null)
		{
			this.ANJHIIPMGGA.Release();
		}
		this.ANJHIIPMGGA = null;
		if (this.JKNCKLMPNGM != null)
		{
			this.JKNCKLMPNGM.Release();
		}
		this.JKNCKLMPNGM = null;
	}

	// Token: 0x060115EE RID: 71150 RVA: 0x007C0EBC File Offset: 0x007BF0BC
	public bool BLNBICKCGID()
	{
		return !base.BBEPCCALAFC.enabled || !SystemInfo.supportsComputeShaders || !this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x060115EF RID: 71151 RVA: 0x007C0EE4 File Offset: 0x007BF0E4
	private Vector4 LPLDMDAKNNL()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.IHEEFJOMFKE();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1899f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.OCNEHBGMHGB() / 1786f), Mathf.Floor((float)this.AMCOGJHPPOC.LKLNPJICOHH() / 1400f));
	}

	// Token: 0x060115F0 RID: 71152 RVA: 0x007C0F54 File Offset: 0x007BF154
	public void KBAJMMCHDOC()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.GAPINPCFOFE().x * (float)Screen.width + 662f, 1393f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x060115F1 RID: 71153 RVA: 0x007C0FCC File Offset: 0x007BF1CC
	public void JADMEJAFNFO()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.NOCONJONFLL().x * (float)Screen.width + 1148f, 1352f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x060115F2 RID: 71154 RVA: 0x007BF3F0 File Offset: 0x007BD5F0
	public bool AGECDAKPEEK()
	{
		return base.BBEPCCALAFC.enabled && SystemInfo.supportsComputeShaders && !this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x060115F3 RID: 71155 RVA: 0x007C1044 File Offset: 0x007BF244
	public Texture OBCPKHIAKPP(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.ANBJGJAJBFM();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("  ");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JDGIHFLNMKB("{0}Textures/Shop/{1}.png");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(-112, 8);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[-9];
		}
		Vector4 vector = this.DKMELBAMBMJ();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.HPAJGFGNMOH((int)vector.z, (int)vector.w, 1, JONJODLFAEN.format, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "*************160 baseid=");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(1, 1, 0, (RenderTextureFormat)(-30));
		}
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(1, 1, 0, (RenderTextureFormat)72);
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("FrontKick");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "_RgbTex", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "http://j.mp/1iBK5pz", renderTexture);
		this.GLBDHAHCNCM.SetVector("?", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 1726f), Mathf.CeilToInt((float)renderTexture.height / 1789f), 0);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.IKEIEMKIEKG(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 15f, 707f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1738f, settings.highPercent - 873f);
		material.SetBuffer("Right arm 'Palm To Thumb Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the palm towards the thumb. If the arrow points away from the thumb, axis must be negative.", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 538f, settings.highPercent * 1429f, Mathf.Exp(settings.minLuminance * 1523f), Mathf.Exp(settings.maxLuminance * 403f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[1];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 0);
			Graphics.Blit(this.JEHCLPMCJAO[0], this.JEHCLPMCJAO[1]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[++num % 8];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[(num += 0) % 0];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 0) % 2;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.DAKPGCMKCJP(BuiltinDebugViewsModel.CGNLFGLJGKA.FocusPlane))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(1, -163, 0, RenderTextureFormat.Depth)
				{
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Repeat
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 6);
		}
		this.IJDNJLIDLJE = false;
		return this.MNLONEDGKIG;
	}

	// Token: 0x060115F4 RID: 71156 RVA: 0x007C1408 File Offset: 0x007BF608
	private Vector4 MMADNBLHLHF()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.BEEOHPGHOFF();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 382f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.GMOLEDNNPEH() / 919f), Mathf.Floor((float)this.AMCOGJHPPOC.GHMBALIHBOH() / 1703f));
	}

	// Token: 0x060115F5 RID: 71157 RVA: 0x007C1478 File Offset: 0x007BF678
	private Vector4 AGPGOACEHHO()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.JADKPIOKKMG();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1573f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.NMCCGCOKKFA() / 1556f), Mathf.Floor((float)this.AMCOGJHPPOC.GHMBALIHBOH() / 1980f));
	}

	// Token: 0x060115F6 RID: 71158 RVA: 0x007C14E8 File Offset: 0x007BF6E8
	private Vector4 MBKHKACLNJJ()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.ODHAGPCKILK();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 171f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.EOMMKPDCAML() / 670f), Mathf.Floor((float)this.AMCOGJHPPOC.LKLNPJICOHH() / 180f));
	}

	// Token: 0x060115F7 RID: 71159 RVA: 0x007C1558 File Offset: 0x007BF758
	public void LFCIINOHNLB()
	{
		if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
		{
			return;
		}
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.ELBPIDDFKFF().x * (float)Screen.width + 446f, 713f, (float)this.JKNCKLMPNGM.width, (float)this.JKNCKLMPNGM.height), this.JKNCKLMPNGM);
	}

	// Token: 0x060115F8 RID: 71160 RVA: 0x007C15D0 File Offset: 0x007BF7D0
	public Texture CFKFCOFAFBC(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.KHBPABICFOF();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("SatNightFever");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JBLDPJMMJOL("IdleReadyCrouch");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(-79, 4);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[5];
		}
		Vector4 vector = this.KMMGMFHGHEG();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.PDFEEEAPMDC((int)vector.z, (int)vector.w, 1, JONJODLFAEN.format, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "Battle Roar");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(1, 0, 0, (RenderTextureFormat)(-95));
		}
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(1, 0, 0, RenderTextureFormat.R8);
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("FOG_EXP2");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "Game saved using ObscuredPrefs. Try to find and change saved data now! ;)", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "****************  playMusic 1=", renderTexture);
		this.GLBDHAHCNCM.SetVector("WoodCut", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 1557f), Mathf.CeilToInt((float)renderTexture.height / 664f), 0);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.IKEIEMKIEKG(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 1196f, 1377f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1644f, settings.highPercent - 1257f);
		material.SetBuffer("KatanaUpperBlock", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 1269f, settings.highPercent * 1384f, Mathf.Exp(settings.minLuminance * 1520f), Mathf.Exp(settings.maxLuminance * 687f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[1];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 1);
			Graphics.Blit(this.JEHCLPMCJAO[1], this.JEHCLPMCJAO[1]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[(num += 0) % 2];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[++num % 8];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 0) % 6;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.CLGLCBFDOKE(BuiltinDebugViewsModel.CGNLFGLJGKA.EyeAdaptation))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(-18, 24, 1, RenderTextureFormat.Depth)
				{
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 5);
		}
		this.IJDNJLIDLJE = false;
		return this.MNLONEDGKIG;
	}

	// Token: 0x060115F9 RID: 71161 RVA: 0x007C1994 File Offset: 0x007BFB94
	private Vector4 OKJABBKPBHK()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.CCBOEPHFGKE();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 229f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.GAIOLBJLPDL() / 1838f), Mathf.Floor((float)this.AMCOGJHPPOC.KNKKIHDHBFD() / 375f));
	}

	// Token: 0x060115FA RID: 71162 RVA: 0x007C1A04 File Offset: 0x007BFC04
	private Vector4 GJAGMFNFKEK()
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.GEKPOGFKOIB();
		float num = (float)(settings.logMax - settings.logMin);
		float num2 = 1325f / num;
		float y = (float)(-(float)settings.logMin) * num2;
		return new Vector4(num2, y, Mathf.Floor((float)this.AMCOGJHPPOC.IGHJHMGOGOO() / 1353f), Mathf.Floor((float)this.AMCOGJHPPOC.GGGEFNKEPDB() / 385f));
	}

	// Token: 0x060115FB RID: 71163 RVA: 0x007BC214 File Offset: 0x007BA414
	public void JFABFKJFDOD()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x060115FC RID: 71164 RVA: 0x007C1A74 File Offset: 0x007BFC74
	public Texture KKFNHMCIGKD(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK)
	{
		EyeAdaptationModel.Settings settings = base.BBEPCCALAFC.JMEDGLJKFDK();
		if (this.GLBDHAHCNCM == null)
		{
			this.GLBDHAHCNCM = Resources.Load<ComputeShader>("");
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.CPFHLGIKEJC("demoQuaternion");
		material.shaderKeywords = null;
		if (this.ANJHIIPMGGA == null)
		{
			this.ANJHIIPMGGA = new ComputeBuffer(-8, 3);
		}
		if (HLOBLFJOMLP.PDDIBKFNJEI == null)
		{
			HLOBLFJOMLP.PDDIBKFNJEI = new uint[67];
		}
		Vector4 vector = this.MBKHKACLNJJ();
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.PDFEEEAPMDC((int)vector.z, (int)vector.w, 1, JONJODLFAEN.format, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, " iterations for read and write");
		Graphics.Blit(JONJODLFAEN, renderTexture);
		if (this.JEHCLPMCJAO[1] == null || !this.JEHCLPMCJAO[1].IsCreated())
		{
			this.JEHCLPMCJAO[0] = new RenderTexture(0, 1, 0, (RenderTextureFormat)87);
		}
		if (this.JEHCLPMCJAO[0] == null || !this.JEHCLPMCJAO[0].IsCreated())
		{
			this.JEHCLPMCJAO[1] = new RenderTexture(0, 1, 1, (RenderTextureFormat)76);
		}
		this.ANJHIIPMGGA.SetData(HLOBLFJOMLP.PDDIBKFNJEI);
		int kernelIndex = this.GLBDHAHCNCM.FindKernel("SoccerKeeperDiveStrafeCloseRight");
		this.GLBDHAHCNCM.SetBuffer(kernelIndex, "RepFractions", this.ANJHIIPMGGA);
		this.GLBDHAHCNCM.SetTexture(kernelIndex, "\n", renderTexture);
		this.GLBDHAHCNCM.SetVector("SoccerKeeperDiveStrafeCloseRight", vector);
		this.GLBDHAHCNCM.Dispatch(kernelIndex, Mathf.CeilToInt((float)renderTexture.width / 1461f), Mathf.CeilToInt((float)renderTexture.height / 1875f), 1);
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OPAFGNJADPO(renderTexture);
		settings.highPercent = Mathf.Clamp(settings.highPercent, 256f, 1093f);
		settings.lowPercent = Mathf.Clamp(settings.lowPercent, 1993f, settings.highPercent - 1473f);
		material.SetBuffer("SoccerSprint", this.ANJHIIPMGGA);
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.EJKBFMMNLHN, new Vector4(settings.lowPercent * 431f, settings.highPercent * 1584f, Mathf.Exp(settings.minLuminance * 1320f), Mathf.Exp(settings.maxLuminance * 33f)));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.NPJLFEKFLEE, new Vector2(settings.speedDown, settings.speedUp));
		material.SetVector(HLOBLFJOMLP.LJNJCNHCJFB.LKACFIEPHIM, vector);
		material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.GIBLOEDMJNF, settings.keyValue);
		if (settings.dynamicKeyValue)
		{
			material.EnableKeyword("Obscured Cheating Detector");
		}
		if (this.IJDNJLIDLJE || !Application.isPlaying)
		{
			this.MNLONEDGKIG = this.JEHCLPMCJAO[1];
			Graphics.Blit(null, this.MNLONEDGKIG, material, 0);
			Graphics.Blit(this.JEHCLPMCJAO[0], this.JEHCLPMCJAO[1]);
		}
		else
		{
			int num = this.DPBELCDLCAB;
			Texture source = this.JEHCLPMCJAO[++num % 1];
			RenderTexture renderTexture2 = this.JEHCLPMCJAO[++num % 8];
			Graphics.Blit(source, renderTexture2, material, (int)settings.adaptationType);
			this.DPBELCDLCAB = (num + 1) % 6;
			this.MNLONEDGKIG = renderTexture2;
		}
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.PNJNAECPOON(BuiltinDebugViewsModel.CGNLFGLJGKA.PreGradingLog))
		{
			if (this.JKNCKLMPNGM == null || !this.JKNCKLMPNGM.IsCreated())
			{
				this.JKNCKLMPNGM = new RenderTexture(164, -17, 0, RenderTextureFormat.Depth)
				{
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Clamp
				};
			}
			material.SetFloat(HLOBLFJOMLP.LJNJCNHCJFB.CKOBDOCIIJG, (float)this.JKNCKLMPNGM.width);
			Graphics.Blit(null, this.JKNCKLMPNGM, material, 2);
		}
		this.IJDNJLIDLJE = false;
		return this.MNLONEDGKIG;
	}

	// Token: 0x04002441 RID: 9281
	private ComputeShader GLBDHAHCNCM;

	// Token: 0x04002442 RID: 9282
	private ComputeBuffer ANJHIIPMGGA;

	// Token: 0x04002443 RID: 9283
	private readonly RenderTexture[] JEHCLPMCJAO = new RenderTexture[2];

	// Token: 0x04002444 RID: 9284
	private int DPBELCDLCAB;

	// Token: 0x04002445 RID: 9285
	private RenderTexture MNLONEDGKIG;

	// Token: 0x04002446 RID: 9286
	private RenderTexture JKNCKLMPNGM;

	// Token: 0x04002447 RID: 9287
	private static uint[] PDDIBKFNJEI;

	// Token: 0x04002448 RID: 9288
	private bool IJDNJLIDLJE = true;

	// Token: 0x04002449 RID: 9289
	private const int LECNJJHOPMA = 64;

	// Token: 0x0400244A RID: 9290
	private const int FKPGPEOGJMN = 16;

	// Token: 0x0400244B RID: 9291
	private const int ECDDCBCCGCP = 16;

	// Token: 0x0200051D RID: 1309
	private static class LJNJCNHCJFB
	{
		// Token: 0x0400244C RID: 9292
		internal static readonly int EJKBFMMNLHN = Shader.PropertyToID("_Params");

		// Token: 0x0400244D RID: 9293
		internal static readonly int NPJLFEKFLEE = Shader.PropertyToID("_Speed");

		// Token: 0x0400244E RID: 9294
		internal static readonly int LKACFIEPHIM = Shader.PropertyToID("_ScaleOffsetRes");

		// Token: 0x0400244F RID: 9295
		internal static readonly int GIBLOEDMJNF = Shader.PropertyToID("_ExposureCompensation");

		// Token: 0x04002450 RID: 9296
		internal static readonly int PELMPIFBDPG = Shader.PropertyToID("_AutoExposure");

		// Token: 0x04002451 RID: 9297
		internal static readonly int CKOBDOCIIJG = Shader.PropertyToID("_DebugWidth");
	}
}
