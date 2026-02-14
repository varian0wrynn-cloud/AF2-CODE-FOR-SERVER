using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.Rendering;

// Token: 0x02000510 RID: 1296
public sealed class MCOMBMNALNJ : AJIEADKHGJM<BuiltinDebugViewsModel>
{
	// Token: 0x06011378 RID: 70520 RVA: 0x007ADA2F File Offset: 0x007ABC2F
	public void EHKCHPFDNCA()
	{
		if (this.MEPCKFECINJ != null)
		{
			this.MEPCKFECINJ.OFKHPBDDKHJ();
		}
		this.MEPCKFECINJ = null;
	}

	// Token: 0x06011379 RID: 70521 RVA: 0x007ADA4C File Offset: 0x007ABC4C
	private void BDHPNKLFADJ(CommandBuffer ECKPLMDEJFD)
	{
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DGOMGBDLAFP("qd_week");
		BuiltinDebugViewsModel.MotionVectorsSettings motionVectors = base.BBEPCCALAFC.LMHFNCJGBMG().motionVectors;
		int nameID = MCOMBMNALNJ.HOHIFKKNBKI.HMKDKKIOIAH;
		ECKPLMDEJFD.GetTemporaryRT(nameID, this.AMCOGJHPPOC.OJNDCCHLMNK(), this.AMCOGJHPPOC.GGGEFNKEPDB(), 0, FilterMode.Point);
		ECKPLMDEJFD.SetGlobalFloat(MCOMBMNALNJ.HOHIFKKNBKI.NMMKCDDKHFJ, motionVectors.sourceOpacity);
		ECKPLMDEJFD.SetGlobalTexture(MCOMBMNALNJ.HOHIFKKNBKI.OCMLEEAPHNB, BuiltinRenderTextureType.DepthNormals);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, nameID, material, 1);
		if (motionVectors.motionImageOpacity > 1309f && motionVectors.motionImageAmplitude > 852f)
		{
			int depkbpdeikd = MCOMBMNALNJ.HOHIFKKNBKI.DEPKBPDEIKD;
			ECKPLMDEJFD.GetTemporaryRT(depkbpdeikd, this.AMCOGJHPPOC.LJJOEDIJPEM(), this.AMCOGJHPPOC.GGGEFNKEPDB(), 1, FilterMode.Point);
			ECKPLMDEJFD.SetGlobalFloat(MCOMBMNALNJ.HOHIFKKNBKI.NMMKCDDKHFJ, motionVectors.motionImageOpacity);
			ECKPLMDEJFD.SetGlobalFloat(MCOMBMNALNJ.HOHIFKKNBKI.DFHJNKDGKJM, motionVectors.motionImageAmplitude);
			ECKPLMDEJFD.SetGlobalTexture(MCOMBMNALNJ.HOHIFKKNBKI.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, depkbpdeikd, material, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
			nameID = depkbpdeikd;
		}
		if (motionVectors.motionVectorsOpacity > 55f && motionVectors.motionVectorsAmplitude > 1289f)
		{
			this.LNBBONKHEDG();
			float num = 1528f / (float)motionVectors.motionVectorsResolution;
			float x = num * (float)this.AMCOGJHPPOC.ILLKFNCFGMP / (float)this.AMCOGJHPPOC.CFDHOKHCPOJ();
			ECKPLMDEJFD.SetGlobalVector(MCOMBMNALNJ.HOHIFKKNBKI.EAPBNMMEIMK, new Vector2(x, num));
			ECKPLMDEJFD.SetGlobalFloat(MCOMBMNALNJ.HOHIFKKNBKI.NMMKCDDKHFJ, motionVectors.motionVectorsOpacity);
			ECKPLMDEJFD.SetGlobalFloat(MCOMBMNALNJ.HOHIFKKNBKI.DFHJNKDGKJM, motionVectors.motionVectorsAmplitude);
			ECKPLMDEJFD.DrawMesh(this.MEPCKFECINJ.NCOKAPIKAEP(), Matrix4x4.identity, material, 1, 8);
		}
		ECKPLMDEJFD.SetGlobalTexture(MCOMBMNALNJ.HOHIFKKNBKI.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, BuiltinRenderTextureType.DepthNormals);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x0601137A RID: 70522 RVA: 0x007ADC40 File Offset: 0x007ABE40
	public override void DNELHGGBBOO(CommandBuffer ECKPLMDEJFD)
	{
		ref BuiltinDebugViewsModel.Settings settings = base.BBEPCCALAFC.settings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/Builtin Debug Views");
		material.shaderKeywords = null;
		if (this.AMCOGJHPPOC.GLJKDPBAPKJ)
		{
			material.EnableKeyword("SOURCE_GBUFFER");
		}
		switch (settings.mode)
		{
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Depth:
			this.CEJCAHINNAC(ECKPLMDEJFD);
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Normals:
			this.NPGFFNNBLHO(ECKPLMDEJFD);
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.MotionVectors:
			this.JMKLCNAAADN(ECKPLMDEJFD);
			break;
		}
		this.AMCOGJHPPOC.FIMOHJBPLBA();
	}

	// Token: 0x0601137B RID: 70523 RVA: 0x007ADCD0 File Offset: 0x007ABED0
	private void JMKLCNAAADN(CommandBuffer ECKPLMDEJFD)
	{
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/Builtin Debug Views");
		BuiltinDebugViewsModel.MotionVectorsSettings motionVectors = base.BBEPCCALAFC.settings.motionVectors;
		int nameID = MCOMBMNALNJ.HOHIFKKNBKI.HMKDKKIOIAH;
		ECKPLMDEJFD.GetTemporaryRT(nameID, this.AMCOGJHPPOC.NMEBEEHCALN, this.AMCOGJHPPOC.ILLKFNCFGMP, 0, FilterMode.Bilinear);
		ECKPLMDEJFD.SetGlobalFloat(MCOMBMNALNJ.HOHIFKKNBKI.NMMKCDDKHFJ, motionVectors.sourceOpacity);
		ECKPLMDEJFD.SetGlobalTexture(MCOMBMNALNJ.HOHIFKKNBKI.OCMLEEAPHNB, BuiltinRenderTextureType.CameraTarget);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, nameID, material, 2);
		if (motionVectors.motionImageOpacity > 0f && motionVectors.motionImageAmplitude > 0f)
		{
			int depkbpdeikd = MCOMBMNALNJ.HOHIFKKNBKI.DEPKBPDEIKD;
			ECKPLMDEJFD.GetTemporaryRT(depkbpdeikd, this.AMCOGJHPPOC.NMEBEEHCALN, this.AMCOGJHPPOC.ILLKFNCFGMP, 0, FilterMode.Bilinear);
			ECKPLMDEJFD.SetGlobalFloat(MCOMBMNALNJ.HOHIFKKNBKI.NMMKCDDKHFJ, motionVectors.motionImageOpacity);
			ECKPLMDEJFD.SetGlobalFloat(MCOMBMNALNJ.HOHIFKKNBKI.DFHJNKDGKJM, motionVectors.motionImageAmplitude);
			ECKPLMDEJFD.SetGlobalTexture(MCOMBMNALNJ.HOHIFKKNBKI.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, depkbpdeikd, material, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
			nameID = depkbpdeikd;
		}
		if (motionVectors.motionVectorsOpacity > 0f && motionVectors.motionVectorsAmplitude > 0f)
		{
			this.LNBBONKHEDG();
			float num = 1f / (float)motionVectors.motionVectorsResolution;
			float x = num * (float)this.AMCOGJHPPOC.ILLKFNCFGMP / (float)this.AMCOGJHPPOC.NMEBEEHCALN;
			ECKPLMDEJFD.SetGlobalVector(MCOMBMNALNJ.HOHIFKKNBKI.EAPBNMMEIMK, new Vector2(x, num));
			ECKPLMDEJFD.SetGlobalFloat(MCOMBMNALNJ.HOHIFKKNBKI.NMMKCDDKHFJ, motionVectors.motionVectorsOpacity);
			ECKPLMDEJFD.SetGlobalFloat(MCOMBMNALNJ.HOHIFKKNBKI.DFHJNKDGKJM, motionVectors.motionVectorsAmplitude);
			ECKPLMDEJFD.DrawMesh(this.MEPCKFECINJ.PDBOLEGLMEL, Matrix4x4.identity, material, 0, 4);
		}
		ECKPLMDEJFD.SetGlobalTexture(MCOMBMNALNJ.HOHIFKKNBKI.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, BuiltinRenderTextureType.CameraTarget);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x0601137C RID: 70524 RVA: 0x007ADEC2 File Offset: 0x007AC0C2
	public bool HMAFCBLHOPA()
	{
		return base.BBEPCCALAFC.CLGLCBFDOKE(BuiltinDebugViewsModel.CGNLFGLJGKA.None) || base.BBEPCCALAFC.DOHGPGNMDLM(BuiltinDebugViewsModel.CGNLFGLJGKA.EyeAdaptation) || base.BBEPCCALAFC.EEFEOJIOAMA(BuiltinDebugViewsModel.CGNLFGLJGKA.FocusPlane);
	}

	// Token: 0x0601137D RID: 70525 RVA: 0x007ADEEE File Offset: 0x007AC0EE
	public void PCKEAEAHAKG()
	{
		if (this.MEPCKFECINJ != null)
		{
			this.MEPCKFECINJ.GMKJMMDMADG();
		}
		this.MEPCKFECINJ = null;
	}

	// Token: 0x0601137E RID: 70526 RVA: 0x007ADF0A File Offset: 0x007AC10A
	public string MEHDCJGDJNN()
	{
		return "fshop_ks2";
	}

	// Token: 0x0601137F RID: 70527 RVA: 0x007ADF11 File Offset: 0x007AC111
	public string ICNLIDDCFIO()
	{
		return "_BokehParams";
	}

	// Token: 0x06011380 RID: 70528 RVA: 0x007ADF18 File Offset: 0x007AC118
	public void MGJCCOCIONI(CommandBuffer ECKPLMDEJFD)
	{
		ref BuiltinDebugViewsModel.Settings ptr = base.BBEPCCALAFC.GEKPOGFKOIB();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("t_much");
		material.shaderKeywords = null;
		if (this.AMCOGJHPPOC.PJKIDHFNEKH())
		{
			material.EnableKeyword("");
		}
		switch (ptr.mode)
		{
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Depth:
			this.CEJCAHINNAC(ECKPLMDEJFD);
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Normals:
			this.HGKEDFIHPPC(ECKPLMDEJFD);
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.MotionVectors:
			this.OLAAKLMHFEO(ECKPLMDEJFD);
			break;
		}
		this.AMCOGJHPPOC.KIJDMGBODIL();
	}

	// Token: 0x06011381 RID: 70529 RVA: 0x007ADFA5 File Offset: 0x007AC1A5
	public string BCPPJILOGKJ()
	{
		return "_RayStepSize";
	}

	// Token: 0x06011382 RID: 70530 RVA: 0x007ADFAC File Offset: 0x007AC1AC
	private void PABHKBGBPFL()
	{
		int motionVectorsResolution = base.BBEPCCALAFC.HMCGGODBANJ().motionVectors.motionVectorsResolution;
		int num = motionVectorsResolution * Screen.width / Screen.height;
		if (this.MEPCKFECINJ == null)
		{
			this.MEPCKFECINJ = new MCOMBMNALNJ.NJJEAKEAPJO();
		}
		if (this.MEPCKFECINJ.PCPAJPCCNFB() != num || this.MEPCKFECINJ.LCEPMOBFKIP() != motionVectorsResolution)
		{
			this.MEPCKFECINJ.DECCJDGPNPN();
			this.MEPCKFECINJ.MBFMBDOOMJO(num, motionVectorsResolution);
		}
	}

	// Token: 0x06011383 RID: 70531 RVA: 0x007AE024 File Offset: 0x007AC224
	private void KOAMFOBFMLL(CommandBuffer ECKPLMDEJFD)
	{
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.OAJBECLLIEP("<color='#000030'>");
		BuiltinDebugViewsModel.DepthSettings depth = base.BBEPCCALAFC.LIKDNAJFKMN().depth;
		ECKPLMDEJFD.SetGlobalFloat(MCOMBMNALNJ.HOHIFKKNBKI.CPMJPKPBJOA, 687f / depth.scale);
		ECKPLMDEJFD.Blit(null, BuiltinRenderTextureType.None, mat, 0);
	}

	// Token: 0x06011384 RID: 70532 RVA: 0x007AE080 File Offset: 0x007AC280
	public void NMHNMMAHBKI(CommandBuffer ECKPLMDEJFD)
	{
		ref BuiltinDebugViewsModel.Settings ptr = base.BBEPCCALAFC.BOLPFGAMAED();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NADANHHBOLO("<color='#206060'>");
		material.shaderKeywords = null;
		if (this.AMCOGJHPPOC.HOLAOCKPNMM())
		{
			material.EnableKeyword("pricePt");
		}
		switch (ptr.mode)
		{
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Depth:
			this.CEJCAHINNAC(ECKPLMDEJFD);
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Normals:
			this.LCIOKHOABFC(ECKPLMDEJFD);
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.MotionVectors:
			this.JMKLCNAAADN(ECKPLMDEJFD);
			break;
		}
		this.AMCOGJHPPOC.HJJAHMKGEJF();
	}

	// Token: 0x06011385 RID: 70533 RVA: 0x007AE110 File Offset: 0x007AC310
	public DepthTextureMode JNEGAGOCDPG()
	{
		BuiltinDebugViewsModel.CGNLFGLJGKA mode = base.BBEPCCALAFC.HMCGGODBANJ().mode;
		DepthTextureMode depthTextureMode = DepthTextureMode.Depth;
		switch (mode)
		{
		case BuiltinDebugViewsModel.CGNLFGLJGKA.None:
			depthTextureMode |= DepthTextureMode.Depth;
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Depth:
			depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.MotionVectors);
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Normals:
			depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals);
			break;
		}
		return depthTextureMode;
	}

	// Token: 0x06011386 RID: 70534 RVA: 0x007AE157 File Offset: 0x007AC357
	public override CameraEvent POJFLMAFHEI()
	{
		if (base.BBEPCCALAFC.settings.mode != BuiltinDebugViewsModel.CGNLFGLJGKA.MotionVectors)
		{
			return CameraEvent.BeforeImageEffectsOpaque;
		}
		return CameraEvent.BeforeImageEffects;
	}

	// Token: 0x170003C2 RID: 962
	// (get) Token: 0x06011387 RID: 70535 RVA: 0x007AE171 File Offset: 0x007AC371
	public override bool NLFEIOCKHKA
	{
		get
		{
			return base.BBEPCCALAFC.CLGLCBFDOKE(BuiltinDebugViewsModel.CGNLFGLJGKA.Depth) || base.BBEPCCALAFC.CLGLCBFDOKE(BuiltinDebugViewsModel.CGNLFGLJGKA.Normals) || base.BBEPCCALAFC.CLGLCBFDOKE(BuiltinDebugViewsModel.CGNLFGLJGKA.MotionVectors);
		}
	}

	// Token: 0x06011388 RID: 70536 RVA: 0x007AE19D File Offset: 0x007AC39D
	public CameraEvent DCFFJEBCMCO()
	{
		if (base.BBEPCCALAFC.KOMEDFGKGGE().mode != BuiltinDebugViewsModel.CGNLFGLJGKA.Depth)
		{
			return (CameraEvent)97;
		}
		return CameraEvent.AfterFinalPass;
	}

	// Token: 0x06011389 RID: 70537 RVA: 0x007AE1B8 File Offset: 0x007AC3B8
	private void NPGFFNNBLHO(CommandBuffer ECKPLMDEJFD)
	{
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/Builtin Debug Views");
		ECKPLMDEJFD.Blit(null, BuiltinRenderTextureType.CameraTarget, mat, 1);
	}

	// Token: 0x0601138A RID: 70538 RVA: 0x007AE1EA File Offset: 0x007AC3EA
	public CameraEvent KLCHCBDEDKD()
	{
		if (base.BBEPCCALAFC.LIKDNAJFKMN().mode != BuiltinDebugViewsModel.CGNLFGLJGKA.LogLut)
		{
			return (CameraEvent)91;
		}
		return CameraEvent.BeforeImageEffectsOpaque;
	}

	// Token: 0x0601138B RID: 70539 RVA: 0x007AE204 File Offset: 0x007AC404
	public override string KPGFOFFHPOO()
	{
		return "Builtin Debug Views";
	}

	// Token: 0x0601138C RID: 70540 RVA: 0x007AE20B File Offset: 0x007AC40B
	public void GMJFHNCPCBN()
	{
		if (this.MEPCKFECINJ != null)
		{
			this.MEPCKFECINJ.EOECHKKIFLC();
		}
		this.MEPCKFECINJ = null;
	}

	// Token: 0x0601138D RID: 70541 RVA: 0x007AE228 File Offset: 0x007AC428
	public void JDPJILECNNO(CommandBuffer ECKPLMDEJFD)
	{
		ref BuiltinDebugViewsModel.Settings ptr = base.BBEPCCALAFC.KOMEDFGKGGE();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.CPFHLGIKEJC("-------------- capId=");
		material.shaderKeywords = null;
		if (this.AMCOGJHPPOC.MDGMGJOKFCL())
		{
			material.EnableKeyword("Fonts/");
		}
		switch (ptr.mode)
		{
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Depth:
			this.KOAMFOBFMLL(ECKPLMDEJFD);
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Normals:
			this.HGKEDFIHPPC(ECKPLMDEJFD);
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.MotionVectors:
			this.BDHPNKLFADJ(ECKPLMDEJFD);
			break;
		}
		this.AMCOGJHPPOC.CDPLIOCHOGE();
	}

	// Token: 0x0601138E RID: 70542 RVA: 0x007AE2B5 File Offset: 0x007AC4B5
	public string HJODOPFHGAL()
	{
		return "IdleReady";
	}

	// Token: 0x0601138F RID: 70543 RVA: 0x007AE2BC File Offset: 0x007AC4BC
	public void IABPIBODNNG()
	{
		if (this.MEPCKFECINJ != null)
		{
			this.MEPCKFECINJ.ONBCKNEKHNM();
		}
		this.MEPCKFECINJ = null;
	}

	// Token: 0x06011390 RID: 70544 RVA: 0x007AE2D8 File Offset: 0x007AC4D8
	private void HGKEDFIHPPC(CommandBuffer ECKPLMDEJFD)
	{
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.GNDBFKAJJCI("");
		ECKPLMDEJFD.Blit(null, BuiltinRenderTextureType.PrepassLight, mat, 0);
	}

	// Token: 0x06011392 RID: 70546 RVA: 0x007AE314 File Offset: 0x007AC514
	private void LCIOKHOABFC(CommandBuffer ECKPLMDEJFD)
	{
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.JNKAJCFJHIP("CUSTOM_COLOR_OFF");
		ECKPLMDEJFD.Blit(null, BuiltinRenderTextureType.PrepassLight, mat, 1);
	}

	// Token: 0x06011393 RID: 70547 RVA: 0x007AE348 File Offset: 0x007AC548
	public DepthTextureMode EDFAPKLAKLI()
	{
		BuiltinDebugViewsModel.CGNLFGLJGKA mode = base.BBEPCCALAFC.BIGGHOCNJNB().mode;
		DepthTextureMode depthTextureMode = DepthTextureMode.Depth;
		switch (mode)
		{
		case BuiltinDebugViewsModel.CGNLFGLJGKA.None:
			depthTextureMode |= DepthTextureMode.None;
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Depth:
			depthTextureMode |= DepthTextureMode.MotionVectors;
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Normals:
			depthTextureMode |= DepthTextureMode.DepthNormals;
			break;
		}
		return depthTextureMode;
	}

	// Token: 0x06011394 RID: 70548 RVA: 0x007AE38F File Offset: 0x007AC58F
	public void PHIACAJNNIG()
	{
		if (this.MEPCKFECINJ != null)
		{
			this.MEPCKFECINJ.PCHMGFNFIGB();
		}
		this.MEPCKFECINJ = null;
	}

	// Token: 0x06011395 RID: 70549 RVA: 0x007AE3AC File Offset: 0x007AC5AC
	public override DepthTextureMode PPAJFNGHBCF()
	{
		BuiltinDebugViewsModel.CGNLFGLJGKA mode = base.BBEPCCALAFC.settings.mode;
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		switch (mode)
		{
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Depth:
			depthTextureMode |= DepthTextureMode.Depth;
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Normals:
			depthTextureMode |= DepthTextureMode.DepthNormals;
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.MotionVectors:
			depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.MotionVectors);
			break;
		}
		return depthTextureMode;
	}

	// Token: 0x06011396 RID: 70550 RVA: 0x007AE3F4 File Offset: 0x007AC5F4
	private void CEJCAHINNAC(CommandBuffer ECKPLMDEJFD)
	{
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/Builtin Debug Views");
		BuiltinDebugViewsModel.DepthSettings depth = base.BBEPCCALAFC.settings.depth;
		ECKPLMDEJFD.SetGlobalFloat(MCOMBMNALNJ.HOHIFKKNBKI.CPMJPKPBJOA, 1f / depth.scale);
		ECKPLMDEJFD.Blit(null, BuiltinRenderTextureType.CameraTarget, mat, 0);
	}

	// Token: 0x06011397 RID: 70551 RVA: 0x007AE450 File Offset: 0x007AC650
	public DepthTextureMode CPHMEIGDBDG()
	{
		BuiltinDebugViewsModel.CGNLFGLJGKA mode = base.BBEPCCALAFC.KOMEDFGKGGE().mode;
		DepthTextureMode depthTextureMode = DepthTextureMode.Depth;
		switch (mode)
		{
		case BuiltinDebugViewsModel.CGNLFGLJGKA.None:
			depthTextureMode |= DepthTextureMode.Depth;
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Depth:
			depthTextureMode |= DepthTextureMode.MotionVectors;
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Normals:
			depthTextureMode |= DepthTextureMode.MotionVectors;
			break;
		}
		return depthTextureMode;
	}

	// Token: 0x06011398 RID: 70552 RVA: 0x007ADA2F File Offset: 0x007ABC2F
	public override void BKFHJFNCPAA()
	{
		if (this.MEPCKFECINJ != null)
		{
			this.MEPCKFECINJ.OFKHPBDDKHJ();
		}
		this.MEPCKFECINJ = null;
	}

	// Token: 0x06011399 RID: 70553 RVA: 0x000FAFC5 File Offset: 0x000F91C5
	public string OGAHKGFCKHJ()
	{
		return "Invalid IKEffector.positionOffset (contains NaN)! Please make sure not to set IKEffector.positionOffset to NaN values.";
	}

	// Token: 0x0601139A RID: 70554 RVA: 0x007AE498 File Offset: 0x007AC698
	public void OMJOJPFCAIH(CommandBuffer ECKPLMDEJFD)
	{
		ref BuiltinDebugViewsModel.Settings ptr = base.BBEPCCALAFC.KOMEDFGKGGE();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.MLAKMCAPCOJ("isFishOnRod");
		material.shaderKeywords = null;
		if (this.AMCOGJHPPOC.JLOKIEPCEGB())
		{
			material.EnableKeyword("Forward");
		}
		switch (ptr.mode)
		{
		case BuiltinDebugViewsModel.CGNLFGLJGKA.None:
			this.KOAMFOBFMLL(ECKPLMDEJFD);
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Depth:
			this.HGKEDFIHPPC(ECKPLMDEJFD);
			break;
		case BuiltinDebugViewsModel.CGNLFGLJGKA.Normals:
			this.BDHPNKLFADJ(ECKPLMDEJFD);
			break;
		}
		this.AMCOGJHPPOC.JCNEOEEHBNP();
	}

	// Token: 0x0601139B RID: 70555 RVA: 0x007AE528 File Offset: 0x007AC728
	private void LNBBONKHEDG()
	{
		int motionVectorsResolution = base.BBEPCCALAFC.settings.motionVectors.motionVectorsResolution;
		int num = motionVectorsResolution * Screen.width / Screen.height;
		if (this.MEPCKFECINJ == null)
		{
			this.MEPCKFECINJ = new MCOMBMNALNJ.NJJEAKEAPJO();
		}
		if (this.MEPCKFECINJ.DPHAGPFDEEE != num || this.MEPCKFECINJ.MNKLMJAPIDL != motionVectorsResolution)
		{
			this.MEPCKFECINJ.OFKHPBDDKHJ();
			this.MEPCKFECINJ.BEOPBNLGNDO(num, motionVectorsResolution);
		}
	}

	// Token: 0x0601139C RID: 70556 RVA: 0x007AE5A0 File Offset: 0x007AC7A0
	private void OLAAKLMHFEO(CommandBuffer ECKPLMDEJFD)
	{
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.BDHEBJJGFGB("\n");
		BuiltinDebugViewsModel.MotionVectorsSettings motionVectors = base.BBEPCCALAFC.FHOBFCBNPOC().motionVectors;
		int nameID = MCOMBMNALNJ.HOHIFKKNBKI.HMKDKKIOIAH;
		ECKPLMDEJFD.GetTemporaryRT(nameID, this.AMCOGJHPPOC.LBAMMHHGCGL(), this.AMCOGJHPPOC.FHCDJOLMIMG(), 0, FilterMode.Point);
		ECKPLMDEJFD.SetGlobalFloat(MCOMBMNALNJ.HOHIFKKNBKI.NMMKCDDKHFJ, motionVectors.sourceOpacity);
		ECKPLMDEJFD.SetGlobalTexture(MCOMBMNALNJ.HOHIFKKNBKI.OCMLEEAPHNB, BuiltinRenderTextureType.CameraTarget);
		ECKPLMDEJFD.Blit((BuiltinRenderTextureType)6, nameID, material, 3);
		if (motionVectors.motionImageOpacity > 947f && motionVectors.motionImageAmplitude > 414f)
		{
			int depkbpdeikd = MCOMBMNALNJ.HOHIFKKNBKI.DEPKBPDEIKD;
			ECKPLMDEJFD.GetTemporaryRT(depkbpdeikd, this.AMCOGJHPPOC.NMEBEEHCALN, this.AMCOGJHPPOC.LPJJBJCIELA(), 1, FilterMode.Point);
			ECKPLMDEJFD.SetGlobalFloat(MCOMBMNALNJ.HOHIFKKNBKI.NMMKCDDKHFJ, motionVectors.motionImageOpacity);
			ECKPLMDEJFD.SetGlobalFloat(MCOMBMNALNJ.HOHIFKKNBKI.DFHJNKDGKJM, motionVectors.motionImageAmplitude);
			ECKPLMDEJFD.SetGlobalTexture(MCOMBMNALNJ.HOHIFKKNBKI.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, depkbpdeikd, material, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
			nameID = depkbpdeikd;
		}
		if (motionVectors.motionVectorsOpacity > 1285f && motionVectors.motionVectorsAmplitude > 392f)
		{
			this.PABHKBGBPFL();
			float num = 1542f / (float)motionVectors.motionVectorsResolution;
			float x = num * (float)this.AMCOGJHPPOC.LKLNPJICOHH() / (float)this.AMCOGJHPPOC.LJJOEDIJPEM();
			ECKPLMDEJFD.SetGlobalVector(MCOMBMNALNJ.HOHIFKKNBKI.EAPBNMMEIMK, new Vector2(x, num));
			ECKPLMDEJFD.SetGlobalFloat(MCOMBMNALNJ.HOHIFKKNBKI.NMMKCDDKHFJ, motionVectors.motionVectorsOpacity);
			ECKPLMDEJFD.SetGlobalFloat(MCOMBMNALNJ.HOHIFKKNBKI.DFHJNKDGKJM, motionVectors.motionVectorsAmplitude);
			ECKPLMDEJFD.DrawMesh(this.MEPCKFECINJ.NCOKAPIKAEP(), Matrix4x4.identity, material, 0, 7);
		}
		ECKPLMDEJFD.SetGlobalTexture(MCOMBMNALNJ.HOHIFKKNBKI.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, BuiltinRenderTextureType.ResolvedDepth);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x04002400 RID: 9216
	private MCOMBMNALNJ.NJJEAKEAPJO MEPCKFECINJ;

	// Token: 0x04002401 RID: 9217
	private static string GOFANCALMLK = "Hidden/Post FX/Builtin Debug Views";

	// Token: 0x02000511 RID: 1297
	private static class HOHIFKKNBKI
	{
		// Token: 0x04002402 RID: 9218
		internal static readonly int CPMJPKPBJOA = Shader.PropertyToID("_DepthScale");

		// Token: 0x04002403 RID: 9219
		internal static readonly int HMKDKKIOIAH = Shader.PropertyToID("_TempRT");

		// Token: 0x04002404 RID: 9220
		internal static readonly int NMMKCDDKHFJ = Shader.PropertyToID("_Opacity");

		// Token: 0x04002405 RID: 9221
		internal static readonly int OCMLEEAPHNB = Shader.PropertyToID("_MainTex");

		// Token: 0x04002406 RID: 9222
		internal static readonly int DEPKBPDEIKD = Shader.PropertyToID("_TempRT2");

		// Token: 0x04002407 RID: 9223
		internal static readonly int DFHJNKDGKJM = Shader.PropertyToID("_Amplitude");

		// Token: 0x04002408 RID: 9224
		internal static readonly int EAPBNMMEIMK = Shader.PropertyToID("_Scale");
	}

	// Token: 0x02000512 RID: 1298
	private enum MNICFPOMEIK
	{
		// Token: 0x0400240A RID: 9226
		Depth,
		// Token: 0x0400240B RID: 9227
		Normals,
		// Token: 0x0400240C RID: 9228
		MovecOpacity,
		// Token: 0x0400240D RID: 9229
		MovecImaging,
		// Token: 0x0400240E RID: 9230
		MovecArrows
	}

	// Token: 0x02000513 RID: 1299
	private class NJJEAKEAPJO
	{
		// Token: 0x0601139F RID: 70559 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void MKFGGFOAMIO(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113A0 RID: 70560 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void OHPOOJNJMCD(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113A1 RID: 70561 RVA: 0x007AE828 File Offset: 0x007ACA28
		public int MFOEOGFGOEH()
		{
			return this.<EIMIILCPDHO>k__BackingField;
		}

		// Token: 0x060113A2 RID: 70562 RVA: 0x007AE830 File Offset: 0x007ACA30
		public void PPAACGLMEFB(int NGCIMCKPANK, int PILEMIFHCJN)
		{
			Vector3[] array = new Vector3[]
			{
				default(Vector3),
				new Vector3(1729f, 617f, 745f)
			};
			array[0] = new Vector3(751f, 1680f, 1916f);
			array[1] = new Vector3(765f, 1527f, 309f);
			array[4] = new Vector3(408f, 558f, 1861f);
			array[1] = new Vector3(325f, 763f, 1318f);
			array[2] = new Vector3(512f, 1638f, 1116f);
			Vector3[] array2 = array;
			int num = 5 * NGCIMCKPANK * PILEMIFHCJN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 1; i < PILEMIFHCJN; i++)
			{
				for (int j = 0; j < NGCIMCKPANK; j++)
				{
					Vector2 item = new Vector2((1082f + (float)j) / (float)NGCIMCKPANK, (30f + (float)i) / (float)PILEMIFHCJN);
					for (int k = 1; k < 8; k++)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 1; l < num; l++)
			{
				array3[l] = l;
			}
			this.GCBKIJJADPC(new Mesh
			{
				hideFlags = (HideFlags)(-88)
			});
			this.JFBOIHFHJAO().SetVertices(list);
			this.PDBOLEGLMEL.SetUVs(1, list2);
			this.EILFBMHIKJM().SetIndices(array3, (MeshTopology)8, 0);
			this.NCOKAPIKAEP().UploadMeshData(false);
			this.LIIKGPOGGKD(NGCIMCKPANK);
			this.MNKLMJAPIDL = PILEMIFHCJN;
		}

		// Token: 0x060113A3 RID: 70563 RVA: 0x007AE9D3 File Offset: 0x007ACBD3
		public Mesh NCOKAPIKAEP()
		{
			return this.<MDIHDANICMH>k__BackingField;
		}

		// Token: 0x060113A4 RID: 70564 RVA: 0x007AE9DC File Offset: 0x007ACBDC
		public void BEOPBNLGNDO(int NGCIMCKPANK, int PILEMIFHCJN)
		{
			Vector3[] array = new Vector3[]
			{
				new Vector3(0f, 0f, 0f),
				new Vector3(0f, 1f, 0f),
				new Vector3(0f, 1f, 0f),
				new Vector3(-1f, 1f, 0f),
				new Vector3(0f, 1f, 0f),
				new Vector3(1f, 1f, 0f)
			};
			int num = 6 * NGCIMCKPANK * PILEMIFHCJN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 0; i < PILEMIFHCJN; i++)
			{
				for (int j = 0; j < NGCIMCKPANK; j++)
				{
					Vector2 item = new Vector2((0.5f + (float)j) / (float)NGCIMCKPANK, (0.5f + (float)i) / (float)PILEMIFHCJN);
					for (int k = 0; k < 6; k++)
					{
						list.Add(array[k]);
						list2.Add(item);
					}
				}
			}
			int[] array2 = new int[num];
			for (int l = 0; l < num; l++)
			{
				array2[l] = l;
			}
			this.PDBOLEGLMEL = new Mesh
			{
				hideFlags = HideFlags.DontSave
			};
			this.PDBOLEGLMEL.SetVertices(list);
			this.PDBOLEGLMEL.SetUVs(0, list2);
			this.PDBOLEGLMEL.SetIndices(array2, MeshTopology.Lines, 0);
			this.PDBOLEGLMEL.UploadMeshData(true);
			this.DPHAGPFDEEE = NGCIMCKPANK;
			this.MNKLMJAPIDL = PILEMIFHCJN;
		}

		// Token: 0x060113A5 RID: 70565 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void PLIACEEHEEI(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113A6 RID: 70566 RVA: 0x007AEB7F File Offset: 0x007ACD7F
		public void KOMNGAMPJEF()
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.BCPNICFHNCM());
			this.MCKNEEKMEJJ(null);
		}

		// Token: 0x060113A7 RID: 70567 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int CKFGOMBIPCJ()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x060113A8 RID: 70568 RVA: 0x007AE828 File Offset: 0x007ACA28
		public int CPLLHFHNBOJ()
		{
			return this.<EIMIILCPDHO>k__BackingField;
		}

		// Token: 0x060113A9 RID: 70569 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void FIPJGELFBIP(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113AA RID: 70570 RVA: 0x007AE828 File Offset: 0x007ACA28
		public int NDHLFMKCMJP()
		{
			return this.<EIMIILCPDHO>k__BackingField;
		}

		// Token: 0x060113AB RID: 70571 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void AOMJDJKNAHH(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113AC RID: 70572 RVA: 0x007AEBA4 File Offset: 0x007ACDA4
		public void KAJMDLEBIND(int NGCIMCKPANK, int PILEMIFHCJN)
		{
			Vector3[] array = new Vector3[1];
			array[1] = new Vector3(592f, 86f, 1294f);
			array[0] = new Vector3(1117f, 649f, 105f);
			array[6] = new Vector3(1116f, 15f, 1879f);
			array[5] = new Vector3(1559f, 1884f, 1286f);
			array[2] = new Vector3(385f, 65f, 1238f);
			array[1] = new Vector3(441f, 727f, 228f);
			Vector3[] array2 = array;
			int num = 8 * NGCIMCKPANK * PILEMIFHCJN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 0; i < PILEMIFHCJN; i++)
			{
				for (int j = 1; j < NGCIMCKPANK; j += 0)
				{
					Vector2 item = new Vector2((337f + (float)j) / (float)NGCIMCKPANK, (1957f + (float)i) / (float)PILEMIFHCJN);
					for (int k = 1; k < 6; k += 0)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 1; l < num; l += 0)
			{
				array3[l] = l;
			}
			this.IIABKPOKBFH(new Mesh
			{
				hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild)
			});
			this.PKPFFNOBDPP().SetVertices(list);
			this.EBKOPJBLFEO().SetUVs(0, list2);
			this.EILFBMHIKJM().SetIndices(array3, (MeshTopology)7, 0);
			this.PDBOLEGLMEL.UploadMeshData(true);
			this.DCONPIPEMDP(NGCIMCKPANK);
			this.MLMMMGBKGGF(PILEMIFHCJN);
		}

		// Token: 0x060113AD RID: 70573 RVA: 0x007AE9D3 File Offset: 0x007ACBD3
		public Mesh LAKKDKCHKIM()
		{
			return this.<MDIHDANICMH>k__BackingField;
		}

		// Token: 0x060113AE RID: 70574 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void MCKNEEKMEJJ(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113AF RID: 70575 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void MLMMMGBKGGF(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113B0 RID: 70576 RVA: 0x007AED47 File Offset: 0x007ACF47
		public void OPAFGNJADPO()
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.APLOOOGPBPK());
			this.MOFJKFALCAN(null);
		}

		// Token: 0x060113B1 RID: 70577 RVA: 0x007AED5B File Offset: 0x007ACF5B
		public void EFHCGFLMLFP()
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.NCOKAPIKAEP());
			this.LBJCJHEEIKP(null);
		}

		// Token: 0x060113B2 RID: 70578 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int LCEPMOBFKIP()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x060113B3 RID: 70579 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void HNMMOBGJAGN(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113B4 RID: 70580 RVA: 0x007AED6F File Offset: 0x007ACF6F
		public void DNJJBEPNMPD()
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.PDBOLEGLMEL);
			this.IPOCIENIOMO(null);
		}

		// Token: 0x060113B5 RID: 70581 RVA: 0x007AE9D3 File Offset: 0x007ACBD3
		public Mesh MFPCDIFABDO()
		{
			return this.<MDIHDANICMH>k__BackingField;
		}

		// Token: 0x060113B6 RID: 70582 RVA: 0x007AE9D3 File Offset: 0x007ACBD3
		public Mesh EILFBMHIKJM()
		{
			return this.<MDIHDANICMH>k__BackingField;
		}

		// Token: 0x060113B7 RID: 70583 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void CAHGHBOGMGM(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113B8 RID: 70584 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int ICLHAMDMLLP()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x060113B9 RID: 70585 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void IGGLPPABNJD(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113BA RID: 70586 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void LIIKGPOGGKD(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113BB RID: 70587 RVA: 0x007AE9D3 File Offset: 0x007ACBD3
		public Mesh PKPFFNOBDPP()
		{
			return this.<MDIHDANICMH>k__BackingField;
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060113BC RID: 70588 RVA: 0x007AE828 File Offset: 0x007ACA28
		// (set) Token: 0x0601141F RID: 70687 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		public int DPHAGPFDEEE { get; private set; }

		// Token: 0x060113BD RID: 70589 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void NKDHGGGOKHF(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113BE RID: 70590 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void KAOHDGEGDGJ(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113BF RID: 70591 RVA: 0x007AED84 File Offset: 0x007ACF84
		public void MBFMBDOOMJO(int NGCIMCKPANK, int PILEMIFHCJN)
		{
			Vector3[] array = new Vector3[5];
			array[1] = new Vector3(1208f, 744f, 413f);
			array[0] = new Vector3(292f, 1002f, 690f);
			array[5] = new Vector3(1863f, 1234f, 79f);
			array[5] = new Vector3(1893f, 1798f, 436f);
			array[4] = new Vector3(1118f, 1504f, 736f);
			array[0] = new Vector3(1225f, 823f, 1171f);
			Vector3[] array2 = array;
			int num = 1 * NGCIMCKPANK * PILEMIFHCJN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 0; i < PILEMIFHCJN; i++)
			{
				for (int j = 0; j < NGCIMCKPANK; j++)
				{
					Vector2 item = new Vector2((1931f + (float)j) / (float)NGCIMCKPANK, (1038f + (float)i) / (float)PILEMIFHCJN);
					for (int k = 1; k < 6; k += 0)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 1; l < num; l++)
			{
				array3[l] = l;
			}
			this.DEKIMANLMGI(new Mesh
			{
				hideFlags = (HideFlags)72
			});
			this.EFDJLJOHJLP().SetVertices(list);
			this.LKLBGKGNGCC().SetUVs(1, list2);
			this.EBKOPJBLFEO().SetIndices(array3, MeshTopology.LineStrip, 1);
			this.PHMENIAGFPI().UploadMeshData(false);
			this.NKDHGGGOKHF(NGCIMCKPANK);
			this.ELEHONGPIEH(PILEMIFHCJN);
		}

		// Token: 0x060113C0 RID: 70592 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void KMCNMACLGIE(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113C1 RID: 70593 RVA: 0x007AE9D3 File Offset: 0x007ACBD3
		public Mesh HPJBGACIIJP()
		{
			return this.<MDIHDANICMH>k__BackingField;
		}

		// Token: 0x060113C2 RID: 70594 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void CCGLGGAJMHE(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113C3 RID: 70595 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int DLLGEAPCOIP()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x060113C4 RID: 70596 RVA: 0x007AEF28 File Offset: 0x007AD128
		public void GOAKHHFFAMA(int NGCIMCKPANK, int PILEMIFHCJN)
		{
			Vector3[] array = new Vector3[3];
			array[1] = new Vector3(230f, 1491f, 1946f);
			array[1] = new Vector3(1943f, 909f, 589f);
			array[1] = new Vector3(150f, 1754f, 1643f);
			array[3] = new Vector3(1477f, 1396f, 125f);
			array[8] = new Vector3(1048f, 214f, 934f);
			array[3] = new Vector3(183f, 1114f, 1476f);
			Vector3[] array2 = array;
			int num = 0 * NGCIMCKPANK * PILEMIFHCJN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 0; i < PILEMIFHCJN; i += 0)
			{
				for (int j = 0; j < NGCIMCKPANK; j += 0)
				{
					Vector2 item = new Vector2((1025f + (float)j) / (float)NGCIMCKPANK, (1303f + (float)i) / (float)PILEMIFHCJN);
					for (int k = 1; k < 7; k++)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 1; l < num; l += 0)
			{
				array3[l] = l;
			}
			this.MIFGNMAMMAE(new Mesh
			{
				hideFlags = (HideFlags)114
			});
			this.HPJBGACIIJP().SetVertices(list);
			this.EBKOPJBLFEO().SetUVs(0, list2);
			this.APLOOOGPBPK().SetIndices(array3, MeshTopology.Quads, 0);
			this.DMPIJEFGBEE().UploadMeshData(false);
			this.KJHDDPHBNHK(NGCIMCKPANK);
			this.MLMMMGBKGGF(PILEMIFHCJN);
		}

		// Token: 0x060113C5 RID: 70597 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void MDBIIFNIBBM(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113C6 RID: 70598 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void MAFKDBDGMKL(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113C7 RID: 70599 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int CGDOOLLCANJ()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x060113C8 RID: 70600 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void BJEHGEIPOGP(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113C9 RID: 70601 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int CLPMCEDECOM()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x060113CA RID: 70602 RVA: 0x007AE9D3 File Offset: 0x007ACBD3
		public Mesh LKLBGKGNGCC()
		{
			return this.<MDIHDANICMH>k__BackingField;
		}

		// Token: 0x060113CB RID: 70603 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void CCDKPGCLIAI(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113CC RID: 70604 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void DCONPIPEMDP(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060113CD RID: 70605 RVA: 0x007AE9D3 File Offset: 0x007ACBD3
		// (set) Token: 0x060113FD RID: 70653 RVA: 0x007AE816 File Offset: 0x007ACA16
		public Mesh PDBOLEGLMEL { get; private set; }

		// Token: 0x060113CE RID: 70606 RVA: 0x007AF0CB File Offset: 0x007AD2CB
		public void GJKCCHCFJNO()
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.LAKKDKCHKIM());
			this.DEKIMANLMGI(null);
		}

		// Token: 0x060113CF RID: 70607 RVA: 0x007AF0DF File Offset: 0x007AD2DF
		public void DECCJDGPNPN()
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.BCPNICFHNCM());
			this.CKKJAMHIHEM(null);
		}

		// Token: 0x060113D0 RID: 70608 RVA: 0x007AE828 File Offset: 0x007ACA28
		public int OPPCKAAJOFN()
		{
			return this.<EIMIILCPDHO>k__BackingField;
		}

		// Token: 0x060113D1 RID: 70609 RVA: 0x007AF0F4 File Offset: 0x007AD2F4
		public void BJLMOBMAPCF(int NGCIMCKPANK, int PILEMIFHCJN)
		{
			Vector3[] array = new Vector3[3];
			array[1] = new Vector3(235f, 969f, 1923f);
			array[0] = new Vector3(1584f, 1156f, 776f);
			array[7] = new Vector3(1897f, 146f, 295f);
			array[6] = new Vector3(1968f, 929f, 638f);
			array[1] = new Vector3(188f, 1641f, 1404f);
			array[6] = new Vector3(1236f, 988f, 1025f);
			Vector3[] array2 = array;
			int num = 4 * NGCIMCKPANK * PILEMIFHCJN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 1; i < PILEMIFHCJN; i++)
			{
				for (int j = 1; j < NGCIMCKPANK; j += 0)
				{
					Vector2 item = new Vector2((1006f + (float)j) / (float)NGCIMCKPANK, (1021f + (float)i) / (float)PILEMIFHCJN);
					for (int k = 1; k < 3; k++)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 1; l < num; l++)
			{
				array3[l] = l;
			}
			this.JPCJOMNHIMF(new Mesh
			{
				hideFlags = (HideFlags)(-74)
			});
			this.APLOOOGPBPK().SetVertices(list);
			this.PDBOLEGLMEL.SetUVs(1, list2);
			this.PDBOLEGLMEL.SetIndices(array3, (MeshTopology)6, 1);
			this.PDBOLEGLMEL.UploadMeshData(false);
			this.KJHDDPHBNHK(NGCIMCKPANK);
			this.NONCIJMNHOC(PILEMIFHCJN);
		}

		// Token: 0x060113D2 RID: 70610 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void IPOCIENIOMO(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113D3 RID: 70611 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void JGCFMGIPFJB(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113D4 RID: 70612 RVA: 0x007AE828 File Offset: 0x007ACA28
		public int IPCMKHIMPIK()
		{
			return this.<EIMIILCPDHO>k__BackingField;
		}

		// Token: 0x060113D5 RID: 70613 RVA: 0x007AF297 File Offset: 0x007AD497
		public void EOECHKKIFLC()
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.PKPFFNOBDPP());
			this.HMJMMHCAMEP(null);
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06011425 RID: 70693 RVA: 0x007AEB93 File Offset: 0x007ACD93
		// (set) Token: 0x060113D6 RID: 70614 RVA: 0x007AE81F File Offset: 0x007ACA1F
		public int MNKLMJAPIDL { get; private set; }

		// Token: 0x060113D7 RID: 70615 RVA: 0x007AE828 File Offset: 0x007ACA28
		public int PCPAJPCCNFB()
		{
			return this.<EIMIILCPDHO>k__BackingField;
		}

		// Token: 0x060113D8 RID: 70616 RVA: 0x007AE9D3 File Offset: 0x007ACBD3
		public Mesh EFDJLJOHJLP()
		{
			return this.<MDIHDANICMH>k__BackingField;
		}

		// Token: 0x060113D9 RID: 70617 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void DDGNOHGNCJE(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113DA RID: 70618 RVA: 0x007AE9D3 File Offset: 0x007ACBD3
		public Mesh APLOOOGPBPK()
		{
			return this.<MDIHDANICMH>k__BackingField;
		}

		// Token: 0x060113DB RID: 70619 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void MIFGNMAMMAE(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113DC RID: 70620 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void NPFJKGIDEMA(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113DD RID: 70621 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void DHGADGGCDDJ(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113DE RID: 70622 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int ANKOPELIEPA()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x060113DF RID: 70623 RVA: 0x007AF2AC File Offset: 0x007AD4AC
		public void JCGCCCIELBL(int NGCIMCKPANK, int PILEMIFHCJN)
		{
			Vector3[] array = new Vector3[1];
			array[0] = new Vector3(1383f, 207f, 455f);
			array[1] = new Vector3(1981f, 1773f, 707f);
			array[3] = new Vector3(988f, 1722f, 159f);
			array[8] = new Vector3(818f, 1191f, 1972f);
			array[6] = new Vector3(1731f, 750f, 80f);
			array[8] = new Vector3(1589f, 1662f, 773f);
			Vector3[] array2 = array;
			int num = 7 * NGCIMCKPANK * PILEMIFHCJN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 1; i < PILEMIFHCJN; i++)
			{
				for (int j = 1; j < NGCIMCKPANK; j++)
				{
					Vector2 item = new Vector2((185f + (float)j) / (float)NGCIMCKPANK, (1101f + (float)i) / (float)PILEMIFHCJN);
					for (int k = 0; k < 1; k += 0)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 0; l < num; l += 0)
			{
				array3[l] = l;
			}
			this.MCKNEEKMEJJ(new Mesh
			{
				hideFlags = (HideFlags)(-103)
			});
			this.PKPFFNOBDPP().SetVertices(list);
			this.BCPNICFHNCM().SetUVs(1, list2);
			this.MFPCDIFABDO().SetIndices(array3, MeshTopology.LineStrip, 1);
			this.NCOKAPIKAEP().UploadMeshData(true);
			this.LBHCHDHDELM(NGCIMCKPANK);
			this.CAHGHBOGMGM(PILEMIFHCJN);
		}

		// Token: 0x060113E0 RID: 70624 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void GLFBLNMGEII(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113E1 RID: 70625 RVA: 0x007AF44F File Offset: 0x007AD64F
		public void GOMJMCKINHI()
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.LAKKDKCHKIM());
			this.HMJMMHCAMEP(null);
		}

		// Token: 0x060113E2 RID: 70626 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int HBCHNKCKNLG()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x060113E3 RID: 70627 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void IKMGFBGPDAO(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113E4 RID: 70628 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void KJOGFHGLIBE(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113E5 RID: 70629 RVA: 0x007AF464 File Offset: 0x007AD664
		public void AAEEPJDMNGK(int NGCIMCKPANK, int PILEMIFHCJN)
		{
			Vector3[] array = new Vector3[5];
			array[1] = new Vector3(494f, 1038f, 1563f);
			array[1] = new Vector3(901f, 679f, 836f);
			array[5] = new Vector3(328f, 385f, 1572f);
			array[0] = new Vector3(177f, 91f, 1071f);
			array[7] = new Vector3(285f, 912f, 1790f);
			array[2] = new Vector3(1172f, 7f, 208f);
			Vector3[] array2 = array;
			int num = 3 * NGCIMCKPANK * PILEMIFHCJN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 0; i < PILEMIFHCJN; i++)
			{
				for (int j = 0; j < NGCIMCKPANK; j++)
				{
					Vector2 item = new Vector2((1898f + (float)j) / (float)NGCIMCKPANK, (440f + (float)i) / (float)PILEMIFHCJN);
					for (int k = 0; k < 6; k += 0)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 1; l < num; l++)
			{
				array3[l] = l;
			}
			this.HMJMMHCAMEP(new Mesh
			{
				hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable)
			});
			this.PDBOLEGLMEL.SetVertices(list);
			this.EFDJLJOHJLP().SetUVs(1, list2);
			this.DMPIJEFGBEE().SetIndices(array3, (MeshTopology)7, 0);
			this.EILFBMHIKJM().UploadMeshData(false);
			this.KKFBOOEKAKI(NGCIMCKPANK);
			this.MDBIIFNIBBM(PILEMIFHCJN);
		}

		// Token: 0x060113E6 RID: 70630 RVA: 0x007AF607 File Offset: 0x007AD807
		public void OGJEDFHHOAD()
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.PHMENIAGFPI());
			this.MKFGGFOAMIO(null);
		}

		// Token: 0x060113E7 RID: 70631 RVA: 0x007AF61C File Offset: 0x007AD81C
		public void OKLGFGKBDNF(int NGCIMCKPANK, int PILEMIFHCJN)
		{
			Vector3[] array = new Vector3[6];
			array[1] = new Vector3(154f, 1433f, 921f);
			array[0] = new Vector3(1533f, 451f, 1754f);
			array[0] = new Vector3(287f, 1844f, 721f);
			array[8] = new Vector3(1858f, 1341f, 1779f);
			array[6] = new Vector3(312f, 147f, 287f);
			array[0] = new Vector3(641f, 1339f, 1390f);
			Vector3[] array2 = array;
			int num = 1 * NGCIMCKPANK * PILEMIFHCJN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 1; i < PILEMIFHCJN; i++)
			{
				for (int j = 0; j < NGCIMCKPANK; j += 0)
				{
					Vector2 item = new Vector2((1999f + (float)j) / (float)NGCIMCKPANK, (814f + (float)i) / (float)PILEMIFHCJN);
					for (int k = 1; k < 0; k++)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 0; l < num; l++)
			{
				array3[l] = l;
			}
			this.CKKJAMHIHEM(new Mesh
			{
				hideFlags = ~HideFlags.HideInInspector
			});
			this.LKLBGKGNGCC().SetVertices(list);
			this.LKLBGKGNGCC().SetUVs(0, list2);
			this.MFPCDIFABDO().SetIndices(array3, (MeshTopology)7, 0);
			this.MFPCDIFABDO().UploadMeshData(false);
			this.AFMCPOOBNFK(NGCIMCKPANK);
			this.PLIACEEHEEI(PILEMIFHCJN);
		}

		// Token: 0x060113E9 RID: 70633 RVA: 0x007AF7BF File Offset: 0x007AD9BF
		public void KDGPCAOEMDL()
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.PKPFFNOBDPP());
			this.IKMGFBGPDAO(null);
		}

		// Token: 0x060113EA RID: 70634 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void IIABKPOKBFH(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113EB RID: 70635 RVA: 0x007AE828 File Offset: 0x007ACA28
		public int FPFNNCPHGHK()
		{
			return this.<EIMIILCPDHO>k__BackingField;
		}

		// Token: 0x060113EC RID: 70636 RVA: 0x007AF7D3 File Offset: 0x007AD9D3
		public void PCHMGFNFIGB()
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.PKPFFNOBDPP());
			this.MOFJKFALCAN(null);
		}

		// Token: 0x060113ED RID: 70637 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void NPKNCCLLOLN(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113EE RID: 70638 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void AFMCPOOBNFK(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113EF RID: 70639 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void DEKIMANLMGI(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113F0 RID: 70640 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void KJHDDPHBNHK(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113F1 RID: 70641 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void LBJCJHEEIKP(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113F2 RID: 70642 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void JKBJHIOJGJF(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113F3 RID: 70643 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void JGEKEOKLABP(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113F4 RID: 70644 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void ADPGBMAPIFM(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113F5 RID: 70645 RVA: 0x007AF7E7 File Offset: 0x007AD9E7
		public void OFKHPBDDKHJ()
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.PDBOLEGLMEL);
			this.PDBOLEGLMEL = null;
		}

		// Token: 0x060113F6 RID: 70646 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int EOEBGBFDIEC()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x060113F7 RID: 70647 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int NEBIMOOLHDO()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x060113F8 RID: 70648 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void GCBKIJJADPC(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113F9 RID: 70649 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int AKCMNOIAAEP()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x060113FA RID: 70650 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int GFFLLJLIOMB()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x060113FB RID: 70651 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void JEJMEIOKEIG(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x060113FC RID: 70652 RVA: 0x007AF7FB File Offset: 0x007AD9FB
		public void GMKJMMDMADG()
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.BCPNICFHNCM());
			this.LBJCJHEEIKP(null);
		}

		// Token: 0x060113FE RID: 70654 RVA: 0x007AF80F File Offset: 0x007ADA0F
		public void PHNKNPGMHEA()
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.JFBOIHFHJAO());
			this.DEKIMANLMGI(null);
		}

		// Token: 0x060113FF RID: 70655 RVA: 0x007AE9D3 File Offset: 0x007ACBD3
		public Mesh PHMENIAGFPI()
		{
			return this.<MDIHDANICMH>k__BackingField;
		}

		// Token: 0x06011400 RID: 70656 RVA: 0x007AF824 File Offset: 0x007ADA24
		public void JFBCLDBEHJO(int NGCIMCKPANK, int PILEMIFHCJN)
		{
			Vector3[] array = new Vector3[0];
			array[0] = new Vector3(830f, 1730f, 1131f);
			array[1] = new Vector3(32f, 1870f, 1704f);
			array[3] = new Vector3(852f, 1968f, 37f);
			array[8] = new Vector3(1813f, 1298f, 1242f);
			array[1] = new Vector3(1178f, 993f, 14f);
			array[1] = new Vector3(1943f, 534f, 215f);
			Vector3[] array2 = array;
			int num = 5 * NGCIMCKPANK * PILEMIFHCJN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 0; i < PILEMIFHCJN; i += 0)
			{
				for (int j = 1; j < NGCIMCKPANK; j += 0)
				{
					Vector2 item = new Vector2((1429f + (float)j) / (float)NGCIMCKPANK, (1515f + (float)i) / (float)PILEMIFHCJN);
					for (int k = 1; k < 2; k++)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 0; l < num; l += 0)
			{
				array3[l] = l;
			}
			this.MCKNEEKMEJJ(new Mesh
			{
				hideFlags = (HideFlags)93
			});
			this.JFBOIHFHJAO().SetVertices(list);
			this.EBKOPJBLFEO().SetUVs(1, list2);
			this.PHMENIAGFPI().SetIndices(array3, MeshTopology.Triangles, 1);
			this.HPJBGACIIJP().UploadMeshData(false);
			this.JKBJHIOJGJF(NGCIMCKPANK);
			this.CAHGHBOGMGM(PILEMIFHCJN);
		}

		// Token: 0x06011401 RID: 70657 RVA: 0x007AF9C8 File Offset: 0x007ADBC8
		public void EFPDNLHFHAO(int NGCIMCKPANK, int PILEMIFHCJN)
		{
			Vector3[] array = new Vector3[8];
			array[0] = new Vector3(1512f, 1542f, 798f);
			array[0] = new Vector3(688f, 1723f, 1577f);
			array[4] = new Vector3(1305f, 1086f, 1425f);
			array[8] = new Vector3(882f, 712f, 770f);
			array[4] = new Vector3(305f, 39f, 129f);
			array[7] = new Vector3(1764f, 1104f, 983f);
			Vector3[] array2 = array;
			int num = 4 * NGCIMCKPANK * PILEMIFHCJN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 0; i < PILEMIFHCJN; i += 0)
			{
				for (int j = 0; j < NGCIMCKPANK; j += 0)
				{
					Vector2 item = new Vector2((959f + (float)j) / (float)NGCIMCKPANK, (259f + (float)i) / (float)PILEMIFHCJN);
					for (int k = 0; k < 6; k += 0)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 1; l < num; l++)
			{
				array3[l] = l;
			}
			this.JPCJOMNHIMF(new Mesh
			{
				hideFlags = (HideFlags)88
			});
			this.EFDJLJOHJLP().SetVertices(list);
			this.PHMENIAGFPI().SetUVs(0, list2);
			this.JEIMGOAPMLK().SetIndices(array3, MeshTopology.Quads, 0);
			this.EBKOPJBLFEO().UploadMeshData(false);
			this.GLPDPNFEGML(NGCIMCKPANK);
			this.LJMFKIJLOFA(PILEMIFHCJN);
		}

		// Token: 0x06011402 RID: 70658 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void LJMFKIJLOFA(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011403 RID: 70659 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void OMMFAKOODHP(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011404 RID: 70660 RVA: 0x007AFB6C File Offset: 0x007ADD6C
		public void KGKHJFHGOBK(int NGCIMCKPANK, int PILEMIFHCJN)
		{
			Vector3[] array = new Vector3[]
			{
				default(Vector3),
				new Vector3(1721f, 1434f, 747f)
			};
			array[1] = new Vector3(947f, 1588f, 1605f);
			array[8] = new Vector3(888f, 1376f, 652f);
			array[8] = new Vector3(298f, 881f, 1770f);
			array[7] = new Vector3(658f, 833f, 863f);
			array[5] = new Vector3(414f, 1333f, 597f);
			Vector3[] array2 = array;
			int num = 3 * NGCIMCKPANK * PILEMIFHCJN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 1; i < PILEMIFHCJN; i++)
			{
				for (int j = 0; j < NGCIMCKPANK; j++)
				{
					Vector2 item = new Vector2((1404f + (float)j) / (float)NGCIMCKPANK, (33f + (float)i) / (float)PILEMIFHCJN);
					for (int k = 0; k < 0; k++)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 1; l < num; l += 0)
			{
				array3[l] = l;
			}
			this.IKMGFBGPDAO(new Mesh
			{
				hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild)
			});
			this.FPLOELCMFJO().SetVertices(list);
			this.MFPCDIFABDO().SetUVs(1, list2);
			this.JFBOIHFHJAO().SetIndices(array3, (MeshTopology)6, 0);
			this.PHMENIAGFPI().UploadMeshData(true);
			this.KPDPPGBDGJO(NGCIMCKPANK);
			this.KAOHDGEGDGJ(PILEMIFHCJN);
		}

		// Token: 0x06011405 RID: 70661 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int OENKOPMOJLN()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x06011406 RID: 70662 RVA: 0x007AE9D3 File Offset: 0x007ACBD3
		public Mesh FPLOELCMFJO()
		{
			return this.<MDIHDANICMH>k__BackingField;
		}

		// Token: 0x06011407 RID: 70663 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int AENEEGOJNKA()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x06011408 RID: 70664 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void HMJMMHCAMEP(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011409 RID: 70665 RVA: 0x007AE9D3 File Offset: 0x007ACBD3
		public Mesh EBKOPJBLFEO()
		{
			return this.<MDIHDANICMH>k__BackingField;
		}

		// Token: 0x0601140A RID: 70666 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void NONCIJMNHOC(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0601140B RID: 70667 RVA: 0x007AE828 File Offset: 0x007ACA28
		public int NDBDFMPPFJE()
		{
			return this.<EIMIILCPDHO>k__BackingField;
		}

		// Token: 0x0601140C RID: 70668 RVA: 0x007AFD0F File Offset: 0x007ADF0F
		public void LMLLPLLFIBG()
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.NCOKAPIKAEP());
			this.IKMGFBGPDAO(null);
		}

		// Token: 0x0601140D RID: 70669 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void ELEHONGPIEH(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0601140E RID: 70670 RVA: 0x007AFD23 File Offset: 0x007ADF23
		public void ONBCKNEKHNM()
		{
			CDBICMCJFCE.MHJKBMIOGCD(this.JFBOIHFHJAO());
			this.MCKNEEKMEJJ(null);
		}

		// Token: 0x0601140F RID: 70671 RVA: 0x007AE828 File Offset: 0x007ACA28
		public int LFMPJBMCMFL()
		{
			return this.<EIMIILCPDHO>k__BackingField;
		}

		// Token: 0x06011410 RID: 70672 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void NIHGLJDJEGF(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011411 RID: 70673 RVA: 0x007AE9D3 File Offset: 0x007ACBD3
		public Mesh JFBOIHFHJAO()
		{
			return this.<MDIHDANICMH>k__BackingField;
		}

		// Token: 0x06011412 RID: 70674 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void LBHCHDHDELM(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011413 RID: 70675 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void CKKJAMHIHEM(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011414 RID: 70676 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int GINIEEGOJHB()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x06011415 RID: 70677 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int PEGPFILGOPI()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x06011416 RID: 70678 RVA: 0x007AE9D3 File Offset: 0x007ACBD3
		public Mesh BCPNICFHNCM()
		{
			return this.<MDIHDANICMH>k__BackingField;
		}

		// Token: 0x06011417 RID: 70679 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int LKEDDGEHFOC()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x06011418 RID: 70680 RVA: 0x007AEB93 File Offset: 0x007ACD93
		public int COKEOPGMBNC()
		{
			return this.<KOJPEPFFLKK>k__BackingField;
		}

		// Token: 0x06011419 RID: 70681 RVA: 0x007AE828 File Offset: 0x007ACA28
		public int OOAPCBBCIHP()
		{
			return this.<EIMIILCPDHO>k__BackingField;
		}

		// Token: 0x0601141A RID: 70682 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void AEGFIGHHLAI(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0601141B RID: 70683 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void JPCJOMNHIMF(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0601141C RID: 70684 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void KKFBOOEKAKI(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0601141D RID: 70685 RVA: 0x007AE9D3 File Offset: 0x007ACBD3
		public Mesh DMPIJEFGBEE()
		{
			return this.<MDIHDANICMH>k__BackingField;
		}

		// Token: 0x0601141E RID: 70686 RVA: 0x007AE81F File Offset: 0x007ACA1F
		private void LJFOFCPINAN(int DCCPCBLODIG)
		{
			this.<KOJPEPFFLKK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011420 RID: 70688 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void NAOCOHOCGHE(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011421 RID: 70689 RVA: 0x007AE828 File Offset: 0x007ACA28
		public int HFCCNMOPBEJ()
		{
			return this.<EIMIILCPDHO>k__BackingField;
		}

		// Token: 0x06011422 RID: 70690 RVA: 0x007AE816 File Offset: 0x007ACA16
		private void MOFJKFALCAN(Mesh DCCPCBLODIG)
		{
			this.<MDIHDANICMH>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011423 RID: 70691 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void KPDPPGBDGJO(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011424 RID: 70692 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void PGGOFAGMNCL(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011426 RID: 70694 RVA: 0x007AFD38 File Offset: 0x007ADF38
		public void IHPLLJJMJJC(int NGCIMCKPANK, int PILEMIFHCJN)
		{
			Vector3[] array = new Vector3[5];
			array[1] = new Vector3(1852f, 741f, 1515f);
			array[1] = new Vector3(209f, 521f, 567f);
			array[7] = new Vector3(634f, 372f, 486f);
			array[3] = new Vector3(692f, 413f, 701f);
			array[3] = new Vector3(395f, 997f, 1910f);
			array[4] = new Vector3(1902f, 1021f, 1010f);
			Vector3[] array2 = array;
			int num = 1 * NGCIMCKPANK * PILEMIFHCJN;
			List<Vector3> list = new List<Vector3>(num);
			List<Vector2> list2 = new List<Vector2>(num);
			for (int i = 0; i < PILEMIFHCJN; i++)
			{
				for (int j = 0; j < NGCIMCKPANK; j += 0)
				{
					Vector2 item = new Vector2((651f + (float)j) / (float)NGCIMCKPANK, (863f + (float)i) / (float)PILEMIFHCJN);
					for (int k = 1; k < 1; k++)
					{
						list.Add(array2[k]);
						list2.Add(item);
					}
				}
			}
			int[] array3 = new int[num];
			for (int l = 0; l < num; l++)
			{
				array3[l] = l;
			}
			this.LBJCJHEEIKP(new Mesh
			{
				hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
			});
			this.EFDJLJOHJLP().SetVertices(list);
			this.JEIMGOAPMLK().SetUVs(0, list2);
			this.NCOKAPIKAEP().SetIndices(array3, MeshTopology.Points, 0);
			this.EBKOPJBLFEO().UploadMeshData(true);
			this.AFMCPOOBNFK(NGCIMCKPANK);
			this.ELEHONGPIEH(PILEMIFHCJN);
		}

		// Token: 0x06011427 RID: 70695 RVA: 0x007AEB9B File Offset: 0x007ACD9B
		private void GLPDPNFEGML(int DCCPCBLODIG)
		{
			this.<EIMIILCPDHO>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011428 RID: 70696 RVA: 0x007AE9D3 File Offset: 0x007ACBD3
		public Mesh JEIMGOAPMLK()
		{
			return this.<MDIHDANICMH>k__BackingField;
		}
	}
}
