using System;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.Rendering;

// Token: 0x0200050B RID: 1291
public sealed class AKFPCBMKBFD : AJIEADKHGJM<AmbientOcclusionModel>
{
	// Token: 0x060112B4 RID: 70324 RVA: 0x007A2E3C File Offset: 0x007A103C
	public DepthTextureMode LJCGALJCPGP()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (this.PCJDIAAPIJC() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		if (this.GBMPCIKJFGM() != AKFPCBMKBFD.OLNKFHPPMNP.GBuffer)
		{
			depthTextureMode |= DepthTextureMode.None;
		}
		return depthTextureMode;
	}

	// Token: 0x060112B5 RID: 70325 RVA: 0x007A2E65 File Offset: 0x007A1065
	public override string KPGFOFFHPOO()
	{
		return "Ambient Occlusion";
	}

	// Token: 0x060112B6 RID: 70326 RVA: 0x007A2E6C File Offset: 0x007A106C
	private bool JAMHHMDBHBB()
	{
		return this.AMCOGJHPPOC.MAIODKMOICL && base.BBEPCCALAFC.KKANBOFAFLC().ambientOnly && this.AMCOGJHPPOC.OFHANPNPEEJ() && !base.BBEPCCALAFC.MPHDFJAHKAK().forceForwardCompatibility;
	}

	// Token: 0x060112B7 RID: 70327 RVA: 0x007A2EBA File Offset: 0x007A10BA
	public string ADEEAMKJIBM()
	{
		return "cntx_close";
	}

	// Token: 0x060112B8 RID: 70328 RVA: 0x007A2EC1 File Offset: 0x007A10C1
	public string JHFINCAONGP()
	{
		return "SoccerKeeperDiveStrafeFarLeft";
	}

	// Token: 0x060112B9 RID: 70329 RVA: 0x007A2EC8 File Offset: 0x007A10C8
	public bool GPNNCNJMGNF()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.MPHDFJAHKAK().intensity > 510f && !this.AMCOGJHPPOC.MLMGNHHAOHF();
	}

	// Token: 0x060112BA RID: 70330 RVA: 0x007A2EFE File Offset: 0x007A10FE
	public CameraEvent ACPGLJEKDFH()
	{
		if (!this.JAMHHMDBHBB() || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BNJOBIPEKJD(BuiltinDebugViewsModel.CGNLFGLJGKA.LogLut))
		{
			return CameraEvent.AfterHaloAndLensFlares;
		}
		return (CameraEvent)(-90);
	}

	// Token: 0x060112BB RID: 70331 RVA: 0x007A2F25 File Offset: 0x007A1125
	public CameraEvent HGPPEOPBOGN()
	{
		if (!this.LEJDAGJNAPJ() || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.CAOCNMBBHLM(BuiltinDebugViewsModel.CGNLFGLJGKA.EyeAdaptation))
		{
			return (CameraEvent)(-61);
		}
		return (CameraEvent)56;
	}

	// Token: 0x060112BC RID: 70332 RVA: 0x007A2F4C File Offset: 0x007A114C
	public void HAEPACDOFBD(CommandBuffer ECKPLMDEJFD)
	{
		AmbientOcclusionModel.Settings settings = base.BBEPCCALAFC.KOMEDFGKGGE();
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.DGOMGBDLAFP("null");
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.ACEOHEODOMJ("u_UniqueShadowBlockerDistanceScale");
		material.shaderKeywords = null;
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.DNDCMHOCJGN, settings.intensity);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.GCFPHJFHLMP, settings.radius);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.MOKHLCPFMGA, settings.downsampling ? 189f : 1719f);
		material.SetInt(AKFPCBMKBFD.PDMBIIMGOEC.HLEEGIAIJNM, (int)settings.sampleCount);
		if (!this.AMCOGJHPPOC.JLOKIEPCEGB() && RenderSettings.fog)
		{
			material.SetVector(AKFPCBMKBFD.PDMBIIMGOEC.JOEBAGCDCAB, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			switch (RenderSettings.fogMode)
			{
			case FogMode.Linear:
				material.EnableKeyword("and 'Result' are the same.");
				break;
			case FogMode.Exponential:
				material.EnableKeyword("wdeep");
				break;
			case FogMode.ExponentialSquared:
				material.EnableKeyword("▮▮▯");
				break;
			}
		}
		else
		{
			material.EnableKeyword("Hidden/Post FX/Eye Adaptation");
		}
		int num = this.AMCOGJHPPOC.LJJOEDIJPEM();
		int num2 = this.AMCOGJHPPOC.LHPBMEDMNDO();
		int num3 = settings.downsampling ? 5 : 1;
		int nameID = AKFPCBMKBFD.PDMBIIMGOEC.DCKJIFPMBIL;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num / num3, num2 / num3, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.Blit(null, nameID, material, (int)this.HCPAOJMKBAM());
		int gfhflllnnmp = AKFPCBMKBFD.PDMBIIMGOEC.GFHFLLLNNMP;
		ECKPLMDEJFD.GetTemporaryRT(gfhflllnnmp, num, num2, 0, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, gfhflllnnmp, material, (this.EHLKMLPJAAJ() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture) ? 1 : 6);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
		nameID = AKFPCBMKBFD.PDMBIIMGOEC.CPLOKLJJNEB;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num, num2, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, gfhflllnnmp);
		ECKPLMDEJFD.Blit(gfhflllnnmp, nameID, material, 5);
		ECKPLMDEJFD.ReleaseTemporaryRT(gfhflllnnmp);
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.EEFEOJIOAMA(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
		{
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, BuiltinRenderTextureType.CurrentActive, material, 7);
			this.AMCOGJHPPOC.FIMOHJBPLBA();
		}
		else if (this.EGODCHFIGKH())
		{
			ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, BuiltinRenderTextureType.DepthNormals);
			ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, material, 1, 7);
		}
		else
		{
			RenderTextureFormat format = this.AMCOGJHPPOC.JFIIMCOAHFG() ? ((RenderTextureFormat)21) : RenderTextureFormat.ARGB4444;
			int hmkdkkioiah = AKFPCBMKBFD.PDMBIIMGOEC.HMKDKKIOIAH;
			ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.KJDPLLFIIBK(), this.AMCOGJHPPOC.LKLNPJICOHH(), 0, FilterMode.Point, format);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, hmkdkkioiah, mat, 0);
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, hmkdkkioiah);
			ECKPLMDEJFD.Blit(hmkdkkioiah, (BuiltinRenderTextureType)6, material, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x060112BD RID: 70333 RVA: 0x007A326C File Offset: 0x007A146C
	public bool AOGEEGMGAJJ()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.DOJLILFGNFM().intensity > 208f && !this.AMCOGJHPPOC.AFIPEFLJBBM();
	}

	// Token: 0x060112BE RID: 70334 RVA: 0x007A32A2 File Offset: 0x007A14A2
	public string DCHECMKFOBN()
	{
		return "DISTORT";
	}

	// Token: 0x060112BF RID: 70335 RVA: 0x007A32AC File Offset: 0x007A14AC
	public void HJMAHNKJOKF(CommandBuffer ECKPLMDEJFD)
	{
		AmbientOcclusionModel.Settings settings = base.BBEPCCALAFC.MPHDFJAHKAK();
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.OFIEMCNMGHM("");
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.HJFNEOFMJEJ("Health bar after few usual operations: ");
		material.shaderKeywords = null;
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.DNDCMHOCJGN, settings.intensity);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.GCFPHJFHLMP, settings.radius);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.MOKHLCPFMGA, settings.downsampling ? 98f : 322f);
		material.SetInt(AKFPCBMKBFD.PDMBIIMGOEC.HLEEGIAIJNM, (int)settings.sampleCount);
		if (!this.AMCOGJHPPOC.BMHMGNLEOED() && RenderSettings.fog)
		{
			material.SetVector(AKFPCBMKBFD.PDMBIIMGOEC.JOEBAGCDCAB, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			switch (RenderSettings.fogMode)
			{
			case (FogMode)0:
				material.EnableKeyword("\n");
				break;
			case FogMode.Linear:
				material.EnableKeyword("");
				break;
			case FogMode.Exponential:
				material.EnableKeyword("_FogOfWarCenterAdjusted");
				break;
			}
		}
		else
		{
			material.EnableKeyword("Femur");
		}
		int num = this.AMCOGJHPPOC.OJNDCCHLMNK();
		int num2 = this.AMCOGJHPPOC.KNKKIHDHBFD();
		int num3 = settings.downsampling ? 7 : 0;
		int nameID = AKFPCBMKBFD.PDMBIIMGOEC.DCKJIFPMBIL;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num / num3, num2 / num3, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.Blit(null, nameID, material, (int)this.GHAHNHGNNIN());
		int gfhflllnnmp = AKFPCBMKBFD.PDMBIIMGOEC.GFHFLLLNNMP;
		ECKPLMDEJFD.GetTemporaryRT(gfhflllnnmp, num, num2, 0, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, gfhflllnnmp, material, (this.LDGDNGMLFKN() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture) ? 2 : 3);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
		nameID = AKFPCBMKBFD.PDMBIIMGOEC.CPLOKLJJNEB;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num, num2, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, gfhflllnnmp);
		ECKPLMDEJFD.Blit(gfhflllnnmp, nameID, material, 6);
		ECKPLMDEJFD.ReleaseTemporaryRT(gfhflllnnmp);
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BGKOOHLKCNJ(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
		{
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, BuiltinRenderTextureType.PrepassLight, material, 8);
			this.AMCOGJHPPOC.ACOPJCLCHIL();
		}
		else if (this.GFEONPMCLNM())
		{
			ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, BuiltinRenderTextureType.CameraTarget);
			ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, material, 0, 6);
		}
		else
		{
			RenderTextureFormat format = this.AMCOGJHPPOC.ANPIAKEADME() ? ((RenderTextureFormat)121) : RenderTextureFormat.ARGBHalf;
			int hmkdkkioiah = AKFPCBMKBFD.PDMBIIMGOEC.HMKDKKIOIAH;
			ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.CFDHOKHCPOJ(), this.AMCOGJHPPOC.MMEMLJENMFF(), 1, FilterMode.Bilinear, format);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, hmkdkkioiah, mat, 0);
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, hmkdkkioiah);
			ECKPLMDEJFD.Blit(hmkdkkioiah, BuiltinRenderTextureType.PrepassLight, material, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x060112C0 RID: 70336 RVA: 0x007A35CC File Offset: 0x007A17CC
	public CameraEvent ABIICGEFFDK()
	{
		if (!this.PCPFDMLBKOC() || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BDCPIKJAMPJ(BuiltinDebugViewsModel.CGNLFGLJGKA.MotionVectors))
		{
			return (CameraEvent)74;
		}
		return CameraEvent.BeforeDepthTexture;
	}

	// Token: 0x060112C1 RID: 70337 RVA: 0x007A35F4 File Offset: 0x007A17F4
	public DepthTextureMode BOJKMDJPICN()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (this.BHPLOLOMBAC() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		if (this.IDKOMMBJNFP() != AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture)
		{
			depthTextureMode |= DepthTextureMode.MotionVectors;
		}
		return depthTextureMode;
	}

	// Token: 0x060112C2 RID: 70338 RVA: 0x007A3620 File Offset: 0x007A1820
	public DepthTextureMode LGEKJLNJMCM()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.Depth;
		if (this.AKLPCMKLFHC() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		if (this.EJDFLJCCHKO() != (AKFPCBMKBFD.OLNKFHPPMNP)8)
		{
			depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals);
		}
		return depthTextureMode;
	}

	// Token: 0x060112C3 RID: 70339 RVA: 0x007A3649 File Offset: 0x007A1849
	public string JLILFGJFHBI()
	{
		return " ";
	}

	// Token: 0x060112C4 RID: 70340 RVA: 0x007A3650 File Offset: 0x007A1850
	private AKFPCBMKBFD.OLNKFHPPMNP KKPDCKOOBAE()
	{
		if (this.AMCOGJHPPOC.KFIJMIGOJEJ() && !base.BBEPCCALAFC.DOJLILFGNFM().forceForwardCompatibility)
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		if (base.BBEPCCALAFC.EBGFGEIIDNM().highPrecision && (!this.AMCOGJHPPOC.BMHMGNLEOED() || base.BBEPCCALAFC.GEKPOGFKOIB().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
	}

	// Token: 0x060112C5 RID: 70341 RVA: 0x007A36B4 File Offset: 0x007A18B4
	private bool DLIJNFONCMP()
	{
		return this.AMCOGJHPPOC.PMBDOPMJOLD() && base.BBEPCCALAFC.AEIDMBILAPI().ambientOnly && this.AMCOGJHPPOC.BMHMGNLEOED() && !base.BBEPCCALAFC.FEJJFMHMNHK().forceForwardCompatibility;
	}

	// Token: 0x060112C7 RID: 70343 RVA: 0x007A3731 File Offset: 0x007A1931
	public CameraEvent JIFBKFJAGLL()
	{
		if (!this.CBEGLELKPAE() || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.CLGLCBFDOKE(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
		{
			return (CameraEvent)(-8);
		}
		return (CameraEvent)(-12);
	}

	// Token: 0x060112C8 RID: 70344 RVA: 0x007A3758 File Offset: 0x007A1958
	public bool LEKGGIMIPLH()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.AEIDMBILAPI().intensity <= 660f || this.AMCOGJHPPOC.GCPDMBIEAOG();
	}

	// Token: 0x060112C9 RID: 70345 RVA: 0x007A3790 File Offset: 0x007A1990
	private AKFPCBMKBFD.OLNKFHPPMNP MIEJELDBJPE()
	{
		if (this.AMCOGJHPPOC.KOIKCDLDJPD() && !base.BBEPCCALAFC.KKANBOFAFLC().forceForwardCompatibility)
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		if (base.BBEPCCALAFC.DOJLILFGNFM().highPrecision && (!this.AMCOGJHPPOC.MDGMGJOKFCL() || base.BBEPCCALAFC.KKANBOFAFLC().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
	}

	// Token: 0x060112CA RID: 70346 RVA: 0x007A37F4 File Offset: 0x007A19F4
	private bool ONELKOEJGMP()
	{
		return !this.AMCOGJHPPOC.BACMPNMDHBL() || !base.BBEPCCALAFC.ODHAGPCKILK().ambientOnly || !this.AMCOGJHPPOC.LEIJCKEIMGH() || base.BBEPCCALAFC.DDIOPCAEBEJ().forceForwardCompatibility;
	}

	// Token: 0x060112CB RID: 70347 RVA: 0x007A3842 File Offset: 0x007A1A42
	public string BMHOMDIFNIH()
	{
		return "<color='#606080'>+{0}</color>";
	}

	// Token: 0x060112CC RID: 70348 RVA: 0x007A384C File Offset: 0x007A1A4C
	private AKFPCBMKBFD.OLNKFHPPMNP LDJFHHHBHGP()
	{
		if (this.AMCOGJHPPOC.KFIJMIGOJEJ() && !base.BBEPCCALAFC.IKLNPEMCDBO().forceForwardCompatibility)
		{
			return (AKFPCBMKBFD.OLNKFHPPMNP)6;
		}
		if (base.BBEPCCALAFC.DOJLILFGNFM().highPrecision && (!this.AMCOGJHPPOC.KFIJMIGOJEJ() || base.BBEPCCALAFC.GEKPOGFKOIB().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
	}

	// Token: 0x060112CD RID: 70349 RVA: 0x007A38B0 File Offset: 0x007A1AB0
	private AKFPCBMKBFD.OLNKFHPPMNP AKLPCMKLFHC()
	{
		if (this.AMCOGJHPPOC.HGFJIBBNAAN() && !base.BBEPCCALAFC.IKLNPEMCDBO().forceForwardCompatibility)
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		if (base.BBEPCCALAFC.OJADINGIJLA().highPrecision && (!this.AMCOGJHPPOC.MDGMGJOKFCL() || base.BBEPCCALAFC.settings.forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
	}

	// Token: 0x060112CE RID: 70350 RVA: 0x007A3914 File Offset: 0x007A1B14
	public DepthTextureMode MEPHIAEOOLE()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (this.KPOFJNGHCAJ() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.None;
		}
		if (this.GBMPCIKJFGM() != AKFPCBMKBFD.OLNKFHPPMNP.GBuffer)
		{
			depthTextureMode |= DepthTextureMode.DepthNormals;
		}
		return depthTextureMode;
	}

	// Token: 0x060112CF RID: 70351 RVA: 0x007A3940 File Offset: 0x007A1B40
	private bool GDBMKIKBNAL()
	{
		return this.AMCOGJHPPOC.JFIIMCOAHFG() && base.BBEPCCALAFC.DDIOPCAEBEJ().ambientOnly && this.AMCOGJHPPOC.HGFJIBBNAAN() && !base.BBEPCCALAFC.PADLICHNALA().forceForwardCompatibility;
	}

	// Token: 0x060112D0 RID: 70352 RVA: 0x007A3990 File Offset: 0x007A1B90
	private AKFPCBMKBFD.OLNKFHPPMNP ICCBNGBCIKD()
	{
		if (this.AMCOGJHPPOC.LEIJCKEIMGH() && !base.BBEPCCALAFC.AEIDMBILAPI().forceForwardCompatibility)
		{
			return (AKFPCBMKBFD.OLNKFHPPMNP)7;
		}
		if (base.BBEPCCALAFC.IKLNPEMCDBO().highPrecision && (!this.AMCOGJHPPOC.PBKNAKJBLDD() || base.BBEPCCALAFC.DFDOFBHMALI().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
	}

	// Token: 0x060112D1 RID: 70353 RVA: 0x007A39F4 File Offset: 0x007A1BF4
	public void EFJGELPHLCE(CommandBuffer ECKPLMDEJFD)
	{
		AmbientOcclusionModel.Settings settings = base.BBEPCCALAFC.DFDOFBHMALI();
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.FGKNJIEOKHH("ArmFlex5");
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DFEMMOCHMDM("Flap_07.wav");
		material.shaderKeywords = null;
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.DNDCMHOCJGN, settings.intensity);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.GCFPHJFHLMP, settings.radius);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.MOKHLCPFMGA, settings.downsampling ? 376f : 23f);
		material.SetInt(AKFPCBMKBFD.PDMBIIMGOEC.HLEEGIAIJNM, (int)settings.sampleCount);
		if (!this.AMCOGJHPPOC.GLJKDPBAPKJ && RenderSettings.fog)
		{
			material.SetVector(AKFPCBMKBFD.PDMBIIMGOEC.JOEBAGCDCAB, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			switch (RenderSettings.fogMode)
			{
			case (FogMode)0:
				material.EnableKeyword("******** ChatPanelPos ");
				break;
			case FogMode.Linear:
				material.EnableKeyword("PistolReload");
				break;
			case FogMode.Exponential:
				material.EnableKeyword("\n");
				break;
			}
		}
		else
		{
			material.EnableKeyword("Reveling");
		}
		int num = this.AMCOGJHPPOC.CFDHOKHCPOJ();
		int num2 = this.AMCOGJHPPOC.LHPBMEDMNDO();
		int num3 = settings.downsampling ? 1 : 1;
		int nameID = AKFPCBMKBFD.PDMBIIMGOEC.DCKJIFPMBIL;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num / num3, num2 / num3, 1, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.Blit(null, nameID, material, (int)this.GAEICPHEIKE());
		int gfhflllnnmp = AKFPCBMKBFD.PDMBIIMGOEC.GFHFLLLNNMP;
		ECKPLMDEJFD.GetTemporaryRT(gfhflllnnmp, num, num2, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, gfhflllnnmp, material, (this.GKHJBOIOJEK() == (AKFPCBMKBFD.OLNKFHPPMNP)3) ? 0 : 3);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
		nameID = AKFPCBMKBFD.PDMBIIMGOEC.CPLOKLJJNEB;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num, num2, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, gfhflllnnmp);
		ECKPLMDEJFD.Blit(gfhflllnnmp, nameID, material, 2);
		ECKPLMDEJFD.ReleaseTemporaryRT(gfhflllnnmp);
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BGKOOHLKCNJ(BuiltinDebugViewsModel.CGNLFGLJGKA.EyeAdaptation))
		{
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, BuiltinRenderTextureType.PrepassNormalsSpec, material, 8);
			this.AMCOGJHPPOC.HOPBBOPNIHC();
		}
		else if (this.DJIIILLNBIN())
		{
			ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, BuiltinRenderTextureType.PrepassNormalsSpec);
			ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, material, 1, 4);
		}
		else
		{
			RenderTextureFormat format = this.AMCOGJHPPOC.BLMBFAOCMNK() ? ((RenderTextureFormat)(-91)) : RenderTextureFormat.RGB565;
			int hmkdkkioiah = AKFPCBMKBFD.PDMBIIMGOEC.HMKDKKIOIAH;
			ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.OJNDCCHLMNK(), this.AMCOGJHPPOC.LHPBMEDMNDO(), 0, FilterMode.Point, format);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, hmkdkkioiah, mat, 0);
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, hmkdkkioiah);
			ECKPLMDEJFD.Blit(hmkdkkioiah, BuiltinRenderTextureType.PrepassNormalsSpec, material, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x060112D2 RID: 70354 RVA: 0x007A3D14 File Offset: 0x007A1F14
	public string JNOCFDMCBPA()
	{
		return "ApplePick";
	}

	// Token: 0x060112D3 RID: 70355 RVA: 0x007A3D1C File Offset: 0x007A1F1C
	private bool LEBLFJHFMPJ()
	{
		return !this.AMCOGJHPPOC.BLMBFAOCMNK() || !base.BBEPCCALAFC.KKANBOFAFLC().ambientOnly || !this.AMCOGJHPPOC.HOLAOCKPNMM() || base.BBEPCCALAFC.DFDOFBHMALI().forceForwardCompatibility;
	}

	// Token: 0x060112D4 RID: 70356 RVA: 0x007A3D6C File Offset: 0x007A1F6C
	private AKFPCBMKBFD.OLNKFHPPMNP GAEICPHEIKE()
	{
		if (this.AMCOGJHPPOC.JLOKIEPCEGB() && !base.BBEPCCALAFC.BOLPFGAMAED().forceForwardCompatibility)
		{
			return (AKFPCBMKBFD.OLNKFHPPMNP)6;
		}
		if (base.BBEPCCALAFC.OJADINGIJLA().highPrecision && (!this.AMCOGJHPPOC.PJKIDHFNEKH() || base.BBEPCCALAFC.KKANBOFAFLC().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
	}

	// Token: 0x060112D5 RID: 70357 RVA: 0x007A3DCE File Offset: 0x007A1FCE
	public CameraEvent OBKOJPEKLLA()
	{
		if (!this.NAOIONJDOGF() || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.GNHGEGEPHCI(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
		{
			return (CameraEvent)(-25);
		}
		return CameraEvent.AfterImageEffects;
	}

	// Token: 0x060112D6 RID: 70358 RVA: 0x007A3DF8 File Offset: 0x007A1FF8
	public DepthTextureMode CIBMBGEBKGL()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (this.MDDBGPCKHPF == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.None;
		}
		if (this.GHAHNHGNNIN() != (AKFPCBMKBFD.OLNKFHPPMNP)3)
		{
			depthTextureMode |= (DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors);
		}
		return depthTextureMode;
	}

	// Token: 0x060112D7 RID: 70359 RVA: 0x007A3E21 File Offset: 0x007A2021
	public CameraEvent HICBBLJNLNK()
	{
		if (!this.DEJAELIEHHM() || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BNJOBIPEKJD(BuiltinDebugViewsModel.CGNLFGLJGKA.MotionVectors))
		{
			return (CameraEvent)112;
		}
		return (CameraEvent)(-29);
	}

	// Token: 0x060112D8 RID: 70360 RVA: 0x007A3E48 File Offset: 0x007A2048
	public DepthTextureMode MHPHEDDKCIP()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (this.BHPLOLOMBAC() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.None;
		}
		if (this.FDFEFAGPODC() != AKFPCBMKBFD.OLNKFHPPMNP.GBuffer)
		{
			depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors);
		}
		return depthTextureMode;
	}

	// Token: 0x060112D9 RID: 70361 RVA: 0x007A3E71 File Offset: 0x007A2071
	public CameraEvent KLCHCBDEDKD()
	{
		if (!this.FNGAPNFOOKJ() || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BGKOOHLKCNJ(BuiltinDebugViewsModel.CGNLFGLJGKA.None))
		{
			return (CameraEvent)(-39);
		}
		return (CameraEvent)(-60);
	}

	// Token: 0x060112DA RID: 70362 RVA: 0x007A3E98 File Offset: 0x007A2098
	private AKFPCBMKBFD.OLNKFHPPMNP PEEMNJKALPC()
	{
		if (this.AMCOGJHPPOC.HOLAOCKPNMM() && !base.BBEPCCALAFC.AEIDMBILAPI().forceForwardCompatibility)
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		if (base.BBEPCCALAFC.PADLICHNALA().highPrecision && (!this.AMCOGJHPPOC.GLJKDPBAPKJ || base.BBEPCCALAFC.OJADINGIJLA().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
	}

	// Token: 0x060112DB RID: 70363 RVA: 0x007A3EFA File Offset: 0x007A20FA
	public string JJGGFIOBGBE()
	{
		return "Life bar: ";
	}

	// Token: 0x060112DC RID: 70364 RVA: 0x007A3F01 File Offset: 0x007A2101
	public bool HEGFBNOJMOO()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.ANBJGJAJBFM().intensity <= 1850f || this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x060112DD RID: 70365 RVA: 0x007A3F37 File Offset: 0x007A2137
	public bool OLOKBMDHFCB()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.KOMEDFGKGGE().intensity <= 773f || this.AMCOGJHPPOC.POJLMOPEBLN();
	}

	// Token: 0x060112DE RID: 70366 RVA: 0x007A3F70 File Offset: 0x007A2170
	public override void DNELHGGBBOO(CommandBuffer ECKPLMDEJFD)
	{
		AmbientOcclusionModel.Settings settings = base.BBEPCCALAFC.settings;
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/Blit");
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/Ambient Occlusion");
		material.shaderKeywords = null;
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.DNDCMHOCJGN, settings.intensity);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.GCFPHJFHLMP, settings.radius);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.MOKHLCPFMGA, settings.downsampling ? 0.5f : 1f);
		material.SetInt(AKFPCBMKBFD.PDMBIIMGOEC.HLEEGIAIJNM, (int)settings.sampleCount);
		if (!this.AMCOGJHPPOC.GLJKDPBAPKJ && RenderSettings.fog)
		{
			material.SetVector(AKFPCBMKBFD.PDMBIIMGOEC.JOEBAGCDCAB, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			switch (RenderSettings.fogMode)
			{
			case FogMode.Linear:
				material.EnableKeyword("FOG_LINEAR");
				break;
			case FogMode.Exponential:
				material.EnableKeyword("FOG_EXP");
				break;
			case FogMode.ExponentialSquared:
				material.EnableKeyword("FOG_EXP2");
				break;
			}
		}
		else
		{
			material.EnableKeyword("FOG_OFF");
		}
		int num = this.AMCOGJHPPOC.NMEBEEHCALN;
		int num2 = this.AMCOGJHPPOC.ILLKFNCFGMP;
		int num3 = settings.downsampling ? 2 : 1;
		int nameID = AKFPCBMKBFD.PDMBIIMGOEC.DCKJIFPMBIL;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num / num3, num2 / num3, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.Blit(null, nameID, material, (int)this.MDDBGPCKHPF);
		int gfhflllnnmp = AKFPCBMKBFD.PDMBIIMGOEC.GFHFLLLNNMP;
		ECKPLMDEJFD.GetTemporaryRT(gfhflllnnmp, num, num2, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, gfhflllnnmp, material, (this.MDDBGPCKHPF == AKFPCBMKBFD.OLNKFHPPMNP.GBuffer) ? 4 : 3);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
		nameID = AKFPCBMKBFD.PDMBIIMGOEC.CPLOKLJJNEB;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num, num2, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, gfhflllnnmp);
		ECKPLMDEJFD.Blit(gfhflllnnmp, nameID, material, 5);
		ECKPLMDEJFD.ReleaseTemporaryRT(gfhflllnnmp);
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.CLGLCBFDOKE(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
		{
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, BuiltinRenderTextureType.CameraTarget, material, 8);
			this.AMCOGJHPPOC.FIMOHJBPLBA();
		}
		else if (this.IKJCKHEKJDM)
		{
			ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, BuiltinRenderTextureType.CameraTarget);
			ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, material, 0, 7);
		}
		else
		{
			RenderTextureFormat format = this.AMCOGJHPPOC.MAIODKMOICL ? RenderTextureFormat.DefaultHDR : RenderTextureFormat.Default;
			int hmkdkkioiah = AKFPCBMKBFD.PDMBIIMGOEC.HMKDKKIOIAH;
			ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.NMEBEEHCALN, this.AMCOGJHPPOC.ILLKFNCFGMP, 0, FilterMode.Bilinear, format);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, hmkdkkioiah, mat, 0);
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, hmkdkkioiah);
			ECKPLMDEJFD.Blit(hmkdkkioiah, BuiltinRenderTextureType.CameraTarget, material, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x060112DF RID: 70367 RVA: 0x007A4290 File Offset: 0x007A2490
	public DepthTextureMode LNIIANBLLPG()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (this.GAEICPHEIKE() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		if (this.IDKOMMBJNFP() != (AKFPCBMKBFD.OLNKFHPPMNP)7)
		{
			depthTextureMode |= (DepthTextureMode)8;
		}
		return depthTextureMode;
	}

	// Token: 0x060112E0 RID: 70368 RVA: 0x007A42BC File Offset: 0x007A24BC
	private AKFPCBMKBFD.OLNKFHPPMNP BHPLOLOMBAC()
	{
		if (this.AMCOGJHPPOC.HOLAOCKPNMM() && !base.BBEPCCALAFC.MPHDFJAHKAK().forceForwardCompatibility)
		{
			return (AKFPCBMKBFD.OLNKFHPPMNP)6;
		}
		if (base.BBEPCCALAFC.GOJNKFKPOKH().highPrecision && (!this.AMCOGJHPPOC.JLOKIEPCEGB() || base.BBEPCCALAFC.DOJLILFGNFM().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
	}

	// Token: 0x060112E1 RID: 70369 RVA: 0x007A4320 File Offset: 0x007A2520
	private AKFPCBMKBFD.OLNKFHPPMNP KPOFJNGHCAJ()
	{
		if (this.AMCOGJHPPOC.PBKNAKJBLDD() && !base.BBEPCCALAFC.EBGFGEIIDNM().forceForwardCompatibility)
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		if (base.BBEPCCALAFC.settings.highPrecision && (!this.AMCOGJHPPOC.KOIKCDLDJPD() || base.BBEPCCALAFC.ODHAGPCKILK().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
	}

	// Token: 0x060112E2 RID: 70370 RVA: 0x007A4382 File Offset: 0x007A2582
	public CameraEvent GKDAPLMKCII()
	{
		if (!this.APOHGHHHMJB() || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.CAOCNMBBHLM(BuiltinDebugViewsModel.CGNLFGLJGKA.None))
		{
			return (CameraEvent)(-41);
		}
		return (CameraEvent)(-103);
	}

	// Token: 0x060112E3 RID: 70371 RVA: 0x007A43AC File Offset: 0x007A25AC
	public DepthTextureMode HKFPGOAPEBL()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.Depth;
		if (this.HMBOCNBELLP() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		if (this.KKPDCKOOBAE() != (AKFPCBMKBFD.OLNKFHPPMNP)8)
		{
			depthTextureMode |= (DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors);
		}
		return depthTextureMode;
	}

	// Token: 0x060112E4 RID: 70372 RVA: 0x007A43D8 File Offset: 0x007A25D8
	private AKFPCBMKBFD.OLNKFHPPMNP GKJJLHDFEIE()
	{
		if (this.AMCOGJHPPOC.KFIJMIGOJEJ() && !base.BBEPCCALAFC.settings.forceForwardCompatibility)
		{
			return (AKFPCBMKBFD.OLNKFHPPMNP)7;
		}
		if (base.BBEPCCALAFC.ODHAGPCKILK().highPrecision && (!this.AMCOGJHPPOC.OFHANPNPEEJ() || base.BBEPCCALAFC.ANBJGJAJBFM().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
	}

	// Token: 0x060112E5 RID: 70373 RVA: 0x007A443C File Offset: 0x007A263C
	public DepthTextureMode CPHMEIGDBDG()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (this.PCJDIAAPIJC() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.None;
		}
		if (this.CMMNBIMBGJO() != AKFPCBMKBFD.OLNKFHPPMNP.GBuffer)
		{
			depthTextureMode |= (DepthTextureMode)8;
		}
		return depthTextureMode;
	}

	// Token: 0x060112E6 RID: 70374 RVA: 0x007A4468 File Offset: 0x007A2668
	private bool DJIIILLNBIN()
	{
		return !this.AMCOGJHPPOC.HCHNHOFPIFK() || !base.BBEPCCALAFC.KDHGJFOLJJF().ambientOnly || !this.AMCOGJHPPOC.OFHANPNPEEJ() || !base.BBEPCCALAFC.KDHGJFOLJJF().forceForwardCompatibility;
	}

	// Token: 0x060112E7 RID: 70375 RVA: 0x007A44B8 File Offset: 0x007A26B8
	private AKFPCBMKBFD.OLNKFHPPMNP IHDMJHOJEEH()
	{
		if (this.AMCOGJHPPOC.KFIJMIGOJEJ() && !base.BBEPCCALAFC.FEJJFMHMNHK().forceForwardCompatibility)
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		if (base.BBEPCCALAFC.ANBJGJAJBFM().highPrecision && (!this.AMCOGJHPPOC.BMHMGNLEOED() || base.BBEPCCALAFC.DDIOPCAEBEJ().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
	}

	// Token: 0x060112E8 RID: 70376 RVA: 0x007A451C File Offset: 0x007A271C
	private bool NAOIONJDOGF()
	{
		return this.AMCOGJHPPOC.DLFNPFAGPFC() && base.BBEPCCALAFC.ANBJGJAJBFM().ambientOnly && this.AMCOGJHPPOC.KOIKCDLDJPD() && !base.BBEPCCALAFC.DFDOFBHMALI().forceForwardCompatibility;
	}

	// Token: 0x060112E9 RID: 70377 RVA: 0x007A456C File Offset: 0x007A276C
	private AKFPCBMKBFD.OLNKFHPPMNP FDFEFAGPODC()
	{
		if (this.AMCOGJHPPOC.PBKNAKJBLDD() && !base.BBEPCCALAFC.IKLNPEMCDBO().forceForwardCompatibility)
		{
			return (AKFPCBMKBFD.OLNKFHPPMNP)4;
		}
		if (base.BBEPCCALAFC.DDIOPCAEBEJ().highPrecision && (!this.AMCOGJHPPOC.IBAFDCPIPBF() || base.BBEPCCALAFC.DOJLILFGNFM().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
	}

	// Token: 0x060112EA RID: 70378 RVA: 0x007A45D0 File Offset: 0x007A27D0
	private bool FLBGKJEJKDG()
	{
		return this.AMCOGJHPPOC.BLMBFAOCMNK() && base.BBEPCCALAFC.OJADINGIJLA().ambientOnly && this.AMCOGJHPPOC.LEIJCKEIMGH() && !base.BBEPCCALAFC.DOJLILFGNFM().forceForwardCompatibility;
	}

	// Token: 0x060112EB RID: 70379 RVA: 0x007A461E File Offset: 0x007A281E
	public bool FCEIMAANKJJ()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.DDIOPCAEBEJ().intensity <= 346f || this.AMCOGJHPPOC.ACEEFEFOCDF();
	}

	// Token: 0x060112EC RID: 70380 RVA: 0x007A4654 File Offset: 0x007A2854
	public string EEAOLEHBGKF()
	{
		return "_AdaptationMin";
	}

	// Token: 0x060112ED RID: 70381 RVA: 0x007A465C File Offset: 0x007A285C
	private bool EFEJJIDGPCC()
	{
		return this.AMCOGJHPPOC.ANPIAKEADME() && base.BBEPCCALAFC.DFDOFBHMALI().ambientOnly && this.AMCOGJHPPOC.MDGMGJOKFCL() && base.BBEPCCALAFC.BOLPFGAMAED().forceForwardCompatibility;
	}

	// Token: 0x060112EE RID: 70382 RVA: 0x007A46AA File Offset: 0x007A28AA
	public bool ODHOKMGJLPA()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.DDIOPCAEBEJ().intensity <= 1654f || !this.AMCOGJHPPOC.HFIFOAPFKBG();
	}

	// Token: 0x060112EF RID: 70383 RVA: 0x007A46E0 File Offset: 0x007A28E0
	public string MEHDCJGDJNN()
	{
		return "CP2";
	}

	// Token: 0x060112F0 RID: 70384 RVA: 0x007A46E8 File Offset: 0x007A28E8
	private AKFPCBMKBFD.OLNKFHPPMNP GKDCPHGBCMC()
	{
		if (this.AMCOGJHPPOC.MDGMGJOKFCL() && !base.BBEPCCALAFC.DOJLILFGNFM().forceForwardCompatibility)
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.GBuffer;
		}
		if (base.BBEPCCALAFC.FEJJFMHMNHK().highPrecision && (!this.AMCOGJHPPOC.EKDILDKALON() || base.BBEPCCALAFC.DFDOFBHMALI().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
	}

	// Token: 0x060112F1 RID: 70385 RVA: 0x007A474A File Offset: 0x007A294A
	public CameraEvent EEJFDOLLNGF()
	{
		if (!this.IKJCKHEKJDM || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.CAOCNMBBHLM(BuiltinDebugViewsModel.CGNLFGLJGKA.LogLut))
		{
			return (CameraEvent)119;
		}
		return (CameraEvent)(-18);
	}

	// Token: 0x060112F2 RID: 70386 RVA: 0x007A4774 File Offset: 0x007A2974
	private AKFPCBMKBFD.OLNKFHPPMNP GHAHNHGNNIN()
	{
		if (this.AMCOGJHPPOC.HDBIPEDBMCC() && !base.BBEPCCALAFC.AEIDMBILAPI().forceForwardCompatibility)
		{
			return (AKFPCBMKBFD.OLNKFHPPMNP)5;
		}
		if (base.BBEPCCALAFC.EBGFGEIIDNM().highPrecision && (!this.AMCOGJHPPOC.JLOKIEPCEGB() || base.BBEPCCALAFC.EBGFGEIIDNM().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
	}

	// Token: 0x060112F3 RID: 70387 RVA: 0x007A47D6 File Offset: 0x007A29D6
	public string JBJIHJFLALB()
	{
		return "rait_4";
	}

	// Token: 0x060112F4 RID: 70388 RVA: 0x007A47DD File Offset: 0x007A29DD
	public CameraEvent CCLNDIBGJPH()
	{
		if (!this.PCKAJPKEBBA() || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BDCPIKJAMPJ(BuiltinDebugViewsModel.CGNLFGLJGKA.MotionVectors))
		{
			return (CameraEvent)(-62);
		}
		return (CameraEvent)(-5);
	}

	// Token: 0x060112F5 RID: 70389 RVA: 0x007A4804 File Offset: 0x007A2A04
	public override DepthTextureMode PPAJFNGHBCF()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (this.MDDBGPCKHPF == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		if (this.MDDBGPCKHPF != AKFPCBMKBFD.OLNKFHPPMNP.GBuffer)
		{
			depthTextureMode |= DepthTextureMode.DepthNormals;
		}
		return depthTextureMode;
	}

	// Token: 0x060112F6 RID: 70390 RVA: 0x007A482D File Offset: 0x007A2A2D
	public string LMAHNMKGMFI()
	{
		return "int: ";
	}

	// Token: 0x060112F7 RID: 70391 RVA: 0x007A4834 File Offset: 0x007A2A34
	private bool CBEGLELKPAE()
	{
		return !this.AMCOGJHPPOC.PMBDOPMJOLD() || !base.BBEPCCALAFC.GOJNKFKPOKH().ambientOnly || !this.AMCOGJHPPOC.HDBIPEDBMCC() || !base.BBEPCCALAFC.GEKPOGFKOIB().forceForwardCompatibility;
	}

	// Token: 0x060112F8 RID: 70392 RVA: 0x007A4882 File Offset: 0x007A2A82
	public string JBBLJDNPJPF()
	{
		return "Failed parsing rotationPlacement.  Setting to \"Fixed\"";
	}

	// Token: 0x060112F9 RID: 70393 RVA: 0x007A4889 File Offset: 0x007A2A89
	public bool OABOCIPKDDD()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.DDIOPCAEBEJ().intensity <= 765f || this.AMCOGJHPPOC.GCPDMBIEAOG();
	}

	// Token: 0x060112FA RID: 70394 RVA: 0x007A48C0 File Offset: 0x007A2AC0
	private bool FNGAPNFOOKJ()
	{
		return this.AMCOGJHPPOC.BACMPNMDHBL() && base.BBEPCCALAFC.EBGFGEIIDNM().ambientOnly && this.AMCOGJHPPOC.GLJKDPBAPKJ && base.BBEPCCALAFC.DOJLILFGNFM().forceForwardCompatibility;
	}

	// Token: 0x060112FB RID: 70395 RVA: 0x007A4910 File Offset: 0x007A2B10
	public DepthTextureMode DOBFCJCCJJI()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (this.GKDCPHGBCMC() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		if (this.MIEJELDBJPE() != (AKFPCBMKBFD.OLNKFHPPMNP)3)
		{
			depthTextureMode |= DepthTextureMode.None;
		}
		return depthTextureMode;
	}

	// Token: 0x060112FC RID: 70396 RVA: 0x007A493C File Offset: 0x007A2B3C
	public void BOEDAGKAHHH(CommandBuffer ECKPLMDEJFD)
	{
		AmbientOcclusionModel.Settings settings = base.BBEPCCALAFC.EBGFGEIIDNM();
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.MLAKMCAPCOJ("KatanaReady");
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.LNIKJLLFLAO("Cowboy1HandDraw");
		material.shaderKeywords = null;
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.DNDCMHOCJGN, settings.intensity);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.GCFPHJFHLMP, settings.radius);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.MOKHLCPFMGA, settings.downsampling ? 1762f : 1470f);
		material.SetInt(AKFPCBMKBFD.PDMBIIMGOEC.HLEEGIAIJNM, (int)settings.sampleCount);
		if (!this.AMCOGJHPPOC.MDGMGJOKFCL() && RenderSettings.fog)
		{
			material.SetVector(AKFPCBMKBFD.PDMBIIMGOEC.JOEBAGCDCAB, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			switch (RenderSettings.fogMode)
			{
			case (FogMode)0:
				material.EnableKeyword("file:///");
				break;
			case FogMode.Linear:
				material.EnableKeyword("LDR");
				break;
			case FogMode.Exponential:
				material.EnableKeyword("RunDive");
				break;
			}
		}
		else
		{
			material.EnableKeyword("\">Saves modification detected: ");
		}
		int num = this.AMCOGJHPPOC.NMEBEEHCALN;
		int num2 = this.AMCOGJHPPOC.GGGEFNKEPDB();
		int num3 = settings.downsampling ? 0 : 0;
		int nameID = AKFPCBMKBFD.PDMBIIMGOEC.DCKJIFPMBIL;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num / num3, num2 / num3, 0, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.Blit(null, nameID, material, (int)this.GBMPCIKJFGM());
		int gfhflllnnmp = AKFPCBMKBFD.PDMBIIMGOEC.GFHFLLLNNMP;
		ECKPLMDEJFD.GetTemporaryRT(gfhflllnnmp, num, num2, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, gfhflllnnmp, material, (this.IDKOMMBJNFP() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture) ? 8 : 5);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
		nameID = AKFPCBMKBFD.PDMBIIMGOEC.CPLOKLJJNEB;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num, num2, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, gfhflllnnmp);
		ECKPLMDEJFD.Blit(gfhflllnnmp, nameID, material, 6);
		ECKPLMDEJFD.ReleaseTemporaryRT(gfhflllnnmp);
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BDCPIKJAMPJ(BuiltinDebugViewsModel.CGNLFGLJGKA.Normals))
		{
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, BuiltinRenderTextureType.None, material, 6);
			this.AMCOGJHPPOC.CDPLIOCHOGE();
		}
		else if (this.CDGMOHJNKLG())
		{
			ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, BuiltinRenderTextureType.PrepassNormalsSpec);
			ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, material, 1, 0);
		}
		else
		{
			RenderTextureFormat format = this.AMCOGJHPPOC.OEGOBDJNFOO() ? ((RenderTextureFormat)57) : RenderTextureFormat.ARGB32;
			int hmkdkkioiah = AKFPCBMKBFD.PDMBIIMGOEC.HMKDKKIOIAH;
			ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.DHPPGHBNDEB(), this.AMCOGJHPPOC.CICDECHCDBJ(), 0, FilterMode.Bilinear, format);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, hmkdkkioiah, mat, 1);
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, hmkdkkioiah);
			ECKPLMDEJFD.Blit(hmkdkkioiah, BuiltinRenderTextureType.CurrentActive, material, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x060112FD RID: 70397 RVA: 0x007A4C5C File Offset: 0x007A2E5C
	public CameraEvent BAODFKKDPOP()
	{
		if (!this.GFEONPMCLNM() || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BGKOOHLKCNJ(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
		{
			return (CameraEvent)(-14);
		}
		return (CameraEvent)31;
	}

	// Token: 0x060112FE RID: 70398 RVA: 0x007A4C84 File Offset: 0x007A2E84
	private AKFPCBMKBFD.OLNKFHPPMNP LDGDNGMLFKN()
	{
		if (this.AMCOGJHPPOC.MDGMGJOKFCL() && !base.BBEPCCALAFC.EBGFGEIIDNM().forceForwardCompatibility)
		{
			return (AKFPCBMKBFD.OLNKFHPPMNP)6;
		}
		if (base.BBEPCCALAFC.ODHAGPCKILK().highPrecision && (!this.AMCOGJHPPOC.IBAFDCPIPBF() || base.BBEPCCALAFC.settings.forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
	}

	// Token: 0x060112FF RID: 70399 RVA: 0x007A4CE8 File Offset: 0x007A2EE8
	public void JHDLNBMNMLI(CommandBuffer ECKPLMDEJFD)
	{
		AmbientOcclusionModel.Settings settings = base.BBEPCCALAFC.DDIOPCAEBEJ();
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.LNIKJLLFLAO("#004000");
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NJACPJPGJFB("[ACTk] <b>[ ObscuredString test ]</b>");
		material.shaderKeywords = null;
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.DNDCMHOCJGN, settings.intensity);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.GCFPHJFHLMP, settings.radius);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.MOKHLCPFMGA, settings.downsampling ? 486f : 1993f);
		material.SetInt(AKFPCBMKBFD.PDMBIIMGOEC.HLEEGIAIJNM, (int)settings.sampleCount);
		if (!this.AMCOGJHPPOC.HGFJIBBNAAN() && RenderSettings.fog)
		{
			material.SetVector(AKFPCBMKBFD.PDMBIIMGOEC.JOEBAGCDCAB, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			switch (RenderSettings.fogMode)
			{
			case (FogMode)0:
				material.EnableKeyword("_DelItem.wav");
				break;
			case FogMode.Linear:
				material.EnableKeyword("WallRunRight");
				break;
			case FogMode.Exponential:
				material.EnableKeyword("<b>WallHack Detector</b>");
				break;
			}
		}
		else
		{
			material.EnableKeyword("error");
		}
		int num = this.AMCOGJHPPOC.DHPPGHBNDEB();
		int num2 = this.AMCOGJHPPOC.LPJJBJCIELA();
		int num3 = settings.downsampling ? 3 : 0;
		int nameID = AKFPCBMKBFD.PDMBIIMGOEC.DCKJIFPMBIL;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num / num3, num2 / num3, 0, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.Blit(null, nameID, material, (int)this.GKHJBOIOJEK());
		int gfhflllnnmp = AKFPCBMKBFD.PDMBIIMGOEC.GFHFLLLNNMP;
		ECKPLMDEJFD.GetTemporaryRT(gfhflllnnmp, num, num2, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, gfhflllnnmp, material, (this.FDKBMPBPEFD() == (AKFPCBMKBFD.OLNKFHPPMNP)5) ? 1 : 8);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
		nameID = AKFPCBMKBFD.PDMBIIMGOEC.CPLOKLJJNEB;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num, num2, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, gfhflllnnmp);
		ECKPLMDEJFD.Blit(gfhflllnnmp, nameID, material, 4);
		ECKPLMDEJFD.ReleaseTemporaryRT(gfhflllnnmp);
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.GNHGEGEPHCI(BuiltinDebugViewsModel.CGNLFGLJGKA.Normals))
		{
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, (BuiltinRenderTextureType)6, material, 6);
			this.AMCOGJHPPOC.FIMOHJBPLBA();
		}
		else if (this.GFEONPMCLNM())
		{
			ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, BuiltinRenderTextureType.DepthNormals);
			ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, material, 1, 8);
		}
		else
		{
			RenderTextureFormat format = this.AMCOGJHPPOC.BACMPNMDHBL() ? ((RenderTextureFormat)(-76)) : RenderTextureFormat.Shadowmap;
			int hmkdkkioiah = AKFPCBMKBFD.PDMBIIMGOEC.HMKDKKIOIAH;
			ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.OCNEHBGMHGB(), this.AMCOGJHPPOC.CICDECHCDBJ(), 0, FilterMode.Bilinear, format);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, hmkdkkioiah, mat, 1);
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, hmkdkkioiah);
			ECKPLMDEJFD.Blit(hmkdkkioiah, BuiltinRenderTextureType.None, material, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x06011300 RID: 70400 RVA: 0x007A5008 File Offset: 0x007A3208
	public string BCPPJILOGKJ()
	{
		return "Perks";
	}

	// Token: 0x06011301 RID: 70401 RVA: 0x007A500F File Offset: 0x007A320F
	public bool GHDPKCBBAON()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.MPHDFJAHKAK().intensity > 185f && !this.AMCOGJHPPOC.ANFINECKHNH();
	}

	// Token: 0x06011302 RID: 70402 RVA: 0x007A5045 File Offset: 0x007A3245
	public CameraEvent BOGKGNOMJGD()
	{
		if (!this.PCPFDMLBKOC() || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.CAOCNMBBHLM(BuiltinDebugViewsModel.CGNLFGLJGKA.PreGradingLog))
		{
			return (CameraEvent)60;
		}
		return (CameraEvent)62;
	}

	// Token: 0x06011303 RID: 70403 RVA: 0x007A506C File Offset: 0x007A326C
	public DepthTextureMode PNEOEPJALCA()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.Depth;
		if (this.IDKOMMBJNFP() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.None;
		}
		if (this.FDKBMPBPEFD() != (AKFPCBMKBFD.OLNKFHPPMNP)6)
		{
			depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals);
		}
		return depthTextureMode;
	}

	// Token: 0x06011304 RID: 70404 RVA: 0x007A5095 File Offset: 0x007A3295
	public string DKDNLMFNKGK()
	{
		return "invn_rec25";
	}

	// Token: 0x06011305 RID: 70405 RVA: 0x007A509C File Offset: 0x007A329C
	public bool LNFMBNMAGMI()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.BOLPFGAMAED().intensity <= 1623f || this.AMCOGJHPPOC.ACEEFEFOCDF();
	}

	// Token: 0x06011306 RID: 70406 RVA: 0x007A50D4 File Offset: 0x007A32D4
	private AKFPCBMKBFD.OLNKFHPPMNP PCJDIAAPIJC()
	{
		if (this.AMCOGJHPPOC.KFIJMIGOJEJ() && !base.BBEPCCALAFC.KOMEDFGKGGE().forceForwardCompatibility)
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		if (base.BBEPCCALAFC.KKANBOFAFLC().highPrecision && (!this.AMCOGJHPPOC.KOIKCDLDJPD() || base.BBEPCCALAFC.DOJLILFGNFM().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
	}

	// Token: 0x06011307 RID: 70407 RVA: 0x007A5138 File Offset: 0x007A3338
	private bool PCPFDMLBKOC()
	{
		return this.AMCOGJHPPOC.MAIODKMOICL && base.BBEPCCALAFC.AEIDMBILAPI().ambientOnly && this.AMCOGJHPPOC.MDGMGJOKFCL() && !base.BBEPCCALAFC.DFDOFBHMALI().forceForwardCompatibility;
	}

	// Token: 0x06011308 RID: 70408 RVA: 0x007A5188 File Offset: 0x007A3388
	private bool GFEONPMCLNM()
	{
		return !this.AMCOGJHPPOC.NNILENLPFDO() || !base.BBEPCCALAFC.EBGFGEIIDNM().ambientOnly || !this.AMCOGJHPPOC.PJKIDHFNEKH() || base.BBEPCCALAFC.OGCJCJHFHMC().forceForwardCompatibility;
	}

	// Token: 0x06011309 RID: 70409 RVA: 0x007A51D6 File Offset: 0x007A33D6
	public bool KLOFNHGHKFC()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.OJADINGIJLA().intensity <= 1805f || !this.AMCOGJHPPOC.GCPDMBIEAOG();
	}

	// Token: 0x0601130A RID: 70410 RVA: 0x007A520C File Offset: 0x007A340C
	private AKFPCBMKBFD.OLNKFHPPMNP FDKBMPBPEFD()
	{
		if (this.AMCOGJHPPOC.JLOKIEPCEGB() && !base.BBEPCCALAFC.ODHAGPCKILK().forceForwardCompatibility)
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.GBuffer;
		}
		if (base.BBEPCCALAFC.OJADINGIJLA().highPrecision && (!this.AMCOGJHPPOC.GLJKDPBAPKJ || base.BBEPCCALAFC.BOLPFGAMAED().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
	}

	// Token: 0x0601130B RID: 70411 RVA: 0x007A526E File Offset: 0x007A346E
	public CameraEvent OABBNMMDCCO()
	{
		if (!this.EGODCHFIGKH() || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.PNJNAECPOON(BuiltinDebugViewsModel.CGNLFGLJGKA.None))
		{
			return (CameraEvent)28;
		}
		return (CameraEvent)(-44);
	}

	// Token: 0x0601130C RID: 70412 RVA: 0x007A5298 File Offset: 0x007A3498
	public void KEOMFACNFGB(CommandBuffer ECKPLMDEJFD)
	{
		AmbientOcclusionModel.Settings settings = base.BBEPCCALAFC.DOJLILFGNFM();
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.JBLDPJMMJOL("Нечего отпускать!");
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.HJFNEOFMJEJ("HitWeight");
		material.shaderKeywords = null;
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.DNDCMHOCJGN, settings.intensity);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.GCFPHJFHLMP, settings.radius);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.MOKHLCPFMGA, settings.downsampling ? 475f : 580f);
		material.SetInt(AKFPCBMKBFD.PDMBIIMGOEC.HLEEGIAIJNM, (int)settings.sampleCount);
		if (!this.AMCOGJHPPOC.HDBIPEDBMCC() && RenderSettings.fog)
		{
			material.SetVector(AKFPCBMKBFD.PDMBIIMGOEC.JOEBAGCDCAB, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			switch (RenderSettings.fogMode)
			{
			case (FogMode)0:
				material.EnableKeyword("FactoryTempTexture");
				break;
			case FogMode.Linear:
				material.EnableKeyword("error.wav");
				break;
			case FogMode.Exponential:
				material.EnableKeyword("ElvisLegsLoop");
				break;
			}
		}
		else
		{
			material.EnableKeyword("CrawlIdle");
		}
		int num = this.AMCOGJHPPOC.PAHBMDOJHKK();
		int num2 = this.AMCOGJHPPOC.CICDECHCDBJ();
		int num3 = settings.downsampling ? 3 : 1;
		int nameID = AKFPCBMKBFD.PDMBIIMGOEC.DCKJIFPMBIL;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num / num3, num2 / num3, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.Blit(null, nameID, material, (int)this.GKHJBOIOJEK());
		int gfhflllnnmp = AKFPCBMKBFD.PDMBIIMGOEC.GFHFLLLNNMP;
		ECKPLMDEJFD.GetTemporaryRT(gfhflllnnmp, num, num2, 1, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, gfhflllnnmp, material, (this.CMMNBIMBGJO() == (AKFPCBMKBFD.OLNKFHPPMNP)8) ? 3 : 8);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
		nameID = AKFPCBMKBFD.PDMBIIMGOEC.CPLOKLJJNEB;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num, num2, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, gfhflllnnmp);
		ECKPLMDEJFD.Blit(gfhflllnnmp, nameID, material, 8);
		ECKPLMDEJFD.ReleaseTemporaryRT(gfhflllnnmp);
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.PNJNAECPOON(BuiltinDebugViewsModel.CGNLFGLJGKA.EyeAdaptation))
		{
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, BuiltinRenderTextureType.Depth, material, 1);
			this.AMCOGJHPPOC.CDPLIOCHOGE();
		}
		else if (this.DLIJNFONCMP())
		{
			ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, BuiltinRenderTextureType.Depth);
			ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, material, 1, 8);
		}
		else
		{
			RenderTextureFormat format = this.AMCOGJHPPOC.PMBDOPMJOLD() ? RenderTextureFormat.ARGB64 : RenderTextureFormat.ARGB2101010;
			int hmkdkkioiah = AKFPCBMKBFD.PDMBIIMGOEC.HMKDKKIOIAH;
			ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.IGHJHMGOGOO(), this.AMCOGJHPPOC.MMEMLJENMFF(), 1, FilterMode.Bilinear, format);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, hmkdkkioiah, mat, 0);
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, hmkdkkioiah);
			ECKPLMDEJFD.Blit(hmkdkkioiah, BuiltinRenderTextureType.None, material, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x0601130D RID: 70413 RVA: 0x007A55B8 File Offset: 0x007A37B8
	public void NKKGHMHMOPH(CommandBuffer ECKPLMDEJFD)
	{
		AmbientOcclusionModel.Settings settings = base.BBEPCCALAFC.KDHGJFOLJJF();
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.GNDBFKAJJCI("__a");
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.IBMKEBEEFKP("<color='#002030'>+{0} {1}</color>");
		material.shaderKeywords = null;
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.DNDCMHOCJGN, settings.intensity);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.GCFPHJFHLMP, settings.radius);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.MOKHLCPFMGA, settings.downsampling ? 1220f : 1992f);
		material.SetInt(AKFPCBMKBFD.PDMBIIMGOEC.HLEEGIAIJNM, (int)settings.sampleCount);
		if (!this.AMCOGJHPPOC.GLJKDPBAPKJ && RenderSettings.fog)
		{
			material.SetVector(AKFPCBMKBFD.PDMBIIMGOEC.JOEBAGCDCAB, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			switch (RenderSettings.fogMode)
			{
			case FogMode.Linear:
				material.EnableKeyword("_");
				break;
			case FogMode.Exponential:
				material.EnableKeyword("Sitting Reading Coffee Sip");
				break;
			case FogMode.ExponentialSquared:
				material.EnableKeyword("BowFire");
				break;
			}
		}
		else
		{
			material.EnableKeyword("ANTI_FLICKER");
		}
		int num = this.AMCOGJHPPOC.NMEBEEHCALN;
		int num2 = this.AMCOGJHPPOC.GHMBALIHBOH();
		int num3 = settings.downsampling ? 1 : 0;
		int nameID = AKFPCBMKBFD.PDMBIIMGOEC.DCKJIFPMBIL;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num / num3, num2 / num3, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.Blit(null, nameID, material, (int)this.IDKOMMBJNFP());
		int gfhflllnnmp = AKFPCBMKBFD.PDMBIIMGOEC.GFHFLLLNNMP;
		ECKPLMDEJFD.GetTemporaryRT(gfhflllnnmp, num, num2, 1, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, gfhflllnnmp, material, (this.ICCBNGBCIKD() == (AKFPCBMKBFD.OLNKFHPPMNP)8) ? 7 : 6);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
		nameID = AKFPCBMKBFD.PDMBIIMGOEC.CPLOKLJJNEB;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num, num2, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, gfhflllnnmp);
		ECKPLMDEJFD.Blit(gfhflllnnmp, nameID, material, 5);
		ECKPLMDEJFD.ReleaseTemporaryRT(gfhflllnnmp);
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.EEFEOJIOAMA(BuiltinDebugViewsModel.CGNLFGLJGKA.Depth))
		{
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, BuiltinRenderTextureType.DepthNormals, material, 1);
			this.AMCOGJHPPOC.HJJAHMKGEJF();
		}
		else if (this.DEJAELIEHHM())
		{
			ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, BuiltinRenderTextureType.Depth);
			ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, material, 0, 7);
		}
		else
		{
			RenderTextureFormat format = this.AMCOGJHPPOC.JFIIMCOAHFG() ? ((RenderTextureFormat)101) : RenderTextureFormat.Depth;
			int hmkdkkioiah = AKFPCBMKBFD.PDMBIIMGOEC.HMKDKKIOIAH;
			ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.KDBADMLHBNP(), this.AMCOGJHPPOC.KNKKIHDHBFD(), 0, FilterMode.Bilinear, format);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, hmkdkkioiah, mat, 1);
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, hmkdkkioiah);
			ECKPLMDEJFD.Blit(hmkdkkioiah, BuiltinRenderTextureType.Depth, material, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x0601130E RID: 70414 RVA: 0x007A58D8 File Offset: 0x007A3AD8
	public void EEHCLNALFGH(CommandBuffer ECKPLMDEJFD)
	{
		AmbientOcclusionModel.Settings settings = base.BBEPCCALAFC.KOMEDFGKGGE();
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.MLFKHMPHIGN("root is null");
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.MLAKMCAPCOJ(")");
		material.shaderKeywords = null;
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.DNDCMHOCJGN, settings.intensity);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.GCFPHJFHLMP, settings.radius);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.MOKHLCPFMGA, settings.downsampling ? 483f : 835f);
		material.SetInt(AKFPCBMKBFD.PDMBIIMGOEC.HLEEGIAIJNM, (int)settings.sampleCount);
		if (!this.AMCOGJHPPOC.HDBIPEDBMCC() && RenderSettings.fog)
		{
			material.SetVector(AKFPCBMKBFD.PDMBIIMGOEC.JOEBAGCDCAB, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			switch (RenderSettings.fogMode)
			{
			case (FogMode)0:
				material.EnableKeyword("");
				break;
			case FogMode.Linear:
				material.EnableKeyword("_NeighbourMaxTex");
				break;
			case FogMode.Exponential:
				material.EnableKeyword("Crouch180");
				break;
			}
		}
		else
		{
			material.EnableKeyword("");
		}
		int num = this.AMCOGJHPPOC.KDBADMLHBNP();
		int num2 = this.AMCOGJHPPOC.FHCDJOLMIMG();
		int num3 = settings.downsampling ? 7 : 1;
		int nameID = AKFPCBMKBFD.PDMBIIMGOEC.DCKJIFPMBIL;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num / num3, num2 / num3, 1, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.Blit(null, nameID, material, (int)this.EJDFLJCCHKO());
		int gfhflllnnmp = AKFPCBMKBFD.PDMBIIMGOEC.GFHFLLLNNMP;
		ECKPLMDEJFD.GetTemporaryRT(gfhflllnnmp, num, num2, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, gfhflllnnmp, material, (this.AKLPCMKLFHC() == (AKFPCBMKBFD.OLNKFHPPMNP)5) ? 8 : 4);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
		nameID = AKFPCBMKBFD.PDMBIIMGOEC.CPLOKLJJNEB;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num, num2, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, gfhflllnnmp);
		ECKPLMDEJFD.Blit(gfhflllnnmp, nameID, material, 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(gfhflllnnmp);
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BNJOBIPEKJD(BuiltinDebugViewsModel.CGNLFGLJGKA.PreGradingLog))
		{
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, BuiltinRenderTextureType.ResolvedDepth, material, 7);
			this.AMCOGJHPPOC.JGNJIBIIANO();
		}
		else if (this.IKJCKHEKJDM)
		{
			ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, BuiltinRenderTextureType.Depth);
			ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, material, 1, 4);
		}
		else
		{
			RenderTextureFormat format = this.AMCOGJHPPOC.MAIODKMOICL ? ((RenderTextureFormat)87) : RenderTextureFormat.Default;
			int hmkdkkioiah = AKFPCBMKBFD.PDMBIIMGOEC.HMKDKKIOIAH;
			ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.KDBADMLHBNP(), this.AMCOGJHPPOC.CICDECHCDBJ(), 1, FilterMode.Bilinear, format);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, hmkdkkioiah, mat, 1);
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, hmkdkkioiah);
			ECKPLMDEJFD.Blit(hmkdkkioiah, BuiltinRenderTextureType.CameraTarget, material, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x0601130F RID: 70415 RVA: 0x007A5BF8 File Offset: 0x007A3DF8
	public bool EHPCNOOJFMH()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.KDHGJFOLJJF().intensity > 1299f && !this.AMCOGJHPPOC.HALNOLGLEOJ();
	}

	// Token: 0x06011310 RID: 70416 RVA: 0x007A5C30 File Offset: 0x007A3E30
	private bool APOHGHHHMJB()
	{
		return !this.AMCOGJHPPOC.DLFNPFAGPFC() || !base.BBEPCCALAFC.GEKPOGFKOIB().ambientOnly || !this.AMCOGJHPPOC.GNOBCFOKNME() || !base.BBEPCCALAFC.GOJNKFKPOKH().forceForwardCompatibility;
	}

	// Token: 0x170003BE RID: 958
	// (get) Token: 0x06011311 RID: 70417 RVA: 0x007A5C80 File Offset: 0x007A3E80
	private AKFPCBMKBFD.OLNKFHPPMNP MDDBGPCKHPF
	{
		get
		{
			if (this.AMCOGJHPPOC.GLJKDPBAPKJ && !base.BBEPCCALAFC.settings.forceForwardCompatibility)
			{
				return AKFPCBMKBFD.OLNKFHPPMNP.GBuffer;
			}
			if (base.BBEPCCALAFC.settings.highPrecision && (!this.AMCOGJHPPOC.GLJKDPBAPKJ || base.BBEPCCALAFC.settings.forceForwardCompatibility))
			{
				return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
			}
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
	}

	// Token: 0x06011312 RID: 70418 RVA: 0x007A5CE2 File Offset: 0x007A3EE2
	public bool HLKJBIMMJOM()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.OGCJCJHFHMC().intensity > 1154f && this.AMCOGJHPPOC.ODNAHJKPHKA();
	}

	// Token: 0x06011313 RID: 70419 RVA: 0x007A5D18 File Offset: 0x007A3F18
	public CameraEvent DLOHIALJHHN()
	{
		if (!this.PCKAJPKEBBA() || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.DOHGPGNMDLM(BuiltinDebugViewsModel.CGNLFGLJGKA.PreGradingLog))
		{
			return (CameraEvent)(-126);
		}
		return (CameraEvent)52;
	}

	// Token: 0x06011314 RID: 70420 RVA: 0x007A5D40 File Offset: 0x007A3F40
	private AKFPCBMKBFD.OLNKFHPPMNP IDKOMMBJNFP()
	{
		if (this.AMCOGJHPPOC.OFHANPNPEEJ() && !base.BBEPCCALAFC.GEKPOGFKOIB().forceForwardCompatibility)
		{
			return (AKFPCBMKBFD.OLNKFHPPMNP)6;
		}
		if (base.BBEPCCALAFC.GEKPOGFKOIB().highPrecision && (!this.AMCOGJHPPOC.OFHANPNPEEJ() || base.BBEPCCALAFC.OJADINGIJLA().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
	}

	// Token: 0x06011315 RID: 70421 RVA: 0x007A5DA4 File Offset: 0x007A3FA4
	public void JBLMKJKCNOK(CommandBuffer ECKPLMDEJFD)
	{
		AmbientOcclusionModel.Settings settings = base.BBEPCCALAFC.KDHGJFOLJJF();
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.MLFKHMPHIGN("Walk Injured");
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.LNIKJLLFLAO("_ProjInfo");
		material.shaderKeywords = null;
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.DNDCMHOCJGN, settings.intensity);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.GCFPHJFHLMP, settings.radius);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.MOKHLCPFMGA, settings.downsampling ? 1653f : 624f);
		material.SetInt(AKFPCBMKBFD.PDMBIIMGOEC.HLEEGIAIJNM, (int)settings.sampleCount);
		if (!this.AMCOGJHPPOC.HDBIPEDBMCC() && RenderSettings.fog)
		{
			material.SetVector(AKFPCBMKBFD.PDMBIIMGOEC.JOEBAGCDCAB, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			switch (RenderSettings.fogMode)
			{
			case FogMode.Linear:
				material.EnableKeyword("PistolInstant");
				break;
			case FogMode.Exponential:
				material.EnableKeyword(" ур. ");
				break;
			case FogMode.ExponentialSquared:
				material.EnableKeyword("IK Effector bone is null.");
				break;
			}
		}
		else
		{
			material.EnableKeyword("");
		}
		int num = this.AMCOGJHPPOC.PAHBMDOJHKK();
		int num2 = this.AMCOGJHPPOC.MMEMLJENMFF();
		int num3 = settings.downsampling ? 6 : 1;
		int nameID = AKFPCBMKBFD.PDMBIIMGOEC.DCKJIFPMBIL;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num / num3, num2 / num3, 0, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.Blit(null, nameID, material, (int)this.HMBOCNBELLP());
		int gfhflllnnmp = AKFPCBMKBFD.PDMBIIMGOEC.GFHFLLLNNMP;
		ECKPLMDEJFD.GetTemporaryRT(gfhflllnnmp, num, num2, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, gfhflllnnmp, material, (this.GKHJBOIOJEK() == (AKFPCBMKBFD.OLNKFHPPMNP)5) ? 6 : 8);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
		nameID = AKFPCBMKBFD.PDMBIIMGOEC.CPLOKLJJNEB;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num, num2, 1, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, gfhflllnnmp);
		ECKPLMDEJFD.Blit(gfhflllnnmp, nameID, material, 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(gfhflllnnmp);
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BGKOOHLKCNJ(BuiltinDebugViewsModel.CGNLFGLJGKA.Depth))
		{
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, BuiltinRenderTextureType.PrepassLight, material, 8);
			this.AMCOGJHPPOC.KIJDMGBODIL();
		}
		else if (this.EFEJJIDGPCC())
		{
			ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, (BuiltinRenderTextureType)6);
			ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, material, 1, 8);
		}
		else
		{
			RenderTextureFormat format = this.AMCOGJHPPOC.BLMBFAOCMNK() ? ((RenderTextureFormat)(-10)) : RenderTextureFormat.Default;
			int hmkdkkioiah = AKFPCBMKBFD.PDMBIIMGOEC.HMKDKKIOIAH;
			ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.NMEBEEHCALN, this.AMCOGJHPPOC.KNKKIHDHBFD(), 1, FilterMode.Point, format);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, hmkdkkioiah, mat, 1);
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, hmkdkkioiah);
			ECKPLMDEJFD.Blit(hmkdkkioiah, BuiltinRenderTextureType.ResolvedDepth, material, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x06011316 RID: 70422 RVA: 0x007A60C4 File Offset: 0x007A42C4
	public DepthTextureMode AGBOGNIMGII()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.Depth;
		if (this.MDDBGPCKHPF == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.None;
		}
		if (this.GHAHNHGNNIN() != (AKFPCBMKBFD.OLNKFHPPMNP)3)
		{
			depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals);
		}
		return depthTextureMode;
	}

	// Token: 0x06011317 RID: 70423 RVA: 0x007A60ED File Offset: 0x007A42ED
	public bool GFFEFDJFMJC()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.KOMEDFGKGGE().intensity <= 1830f || !this.AMCOGJHPPOC.AFIPEFLJBBM();
	}

	// Token: 0x06011318 RID: 70424 RVA: 0x007A6124 File Offset: 0x007A4324
	public void PPHOONMGPMD(CommandBuffer ECKPLMDEJFD)
	{
		AmbientOcclusionModel.Settings settings = base.BBEPCCALAFC.AEIDMBILAPI();
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.NJACPJPGJFB(" гр ");
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.MLFKHMPHIGN("Original health bar: ");
		material.shaderKeywords = null;
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.DNDCMHOCJGN, settings.intensity);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.GCFPHJFHLMP, settings.radius);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.MOKHLCPFMGA, settings.downsampling ? 483f : 526f);
		material.SetInt(AKFPCBMKBFD.PDMBIIMGOEC.HLEEGIAIJNM, (int)settings.sampleCount);
		if (!this.AMCOGJHPPOC.HGFJIBBNAAN() && RenderSettings.fog)
		{
			material.SetVector(AKFPCBMKBFD.PDMBIIMGOEC.JOEBAGCDCAB, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			switch (RenderSettings.fogMode)
			{
			case (FogMode)0:
				material.EnableKeyword("_CosPower");
				break;
			case FogMode.Linear:
				material.EnableKeyword("♼ ");
				break;
			case FogMode.Exponential:
				material.EnableKeyword("_TrStartYou.ogg");
				break;
			}
		}
		else
		{
			material.EnableKeyword("<color='#ff0000'>Вы сломали удочку</color>");
		}
		int num = this.AMCOGJHPPOC.KDBADMLHBNP();
		int num2 = this.AMCOGJHPPOC.CICDECHCDBJ();
		int num3 = settings.downsampling ? 3 : 1;
		int nameID = AKFPCBMKBFD.PDMBIIMGOEC.DCKJIFPMBIL;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num / num3, num2 / num3, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.Blit(null, nameID, material, (int)this.PCJDIAAPIJC());
		int gfhflllnnmp = AKFPCBMKBFD.PDMBIIMGOEC.GFHFLLLNNMP;
		ECKPLMDEJFD.GetTemporaryRT(gfhflllnnmp, num, num2, 1, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, gfhflllnnmp, material, (this.GAEICPHEIKE() == (AKFPCBMKBFD.OLNKFHPPMNP)8) ? 4 : 4);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
		nameID = AKFPCBMKBFD.PDMBIIMGOEC.CPLOKLJJNEB;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num, num2, 0, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, gfhflllnnmp);
		ECKPLMDEJFD.Blit(gfhflllnnmp, nameID, material, 5);
		ECKPLMDEJFD.ReleaseTemporaryRT(gfhflllnnmp);
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.EEFEOJIOAMA(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
		{
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, BuiltinRenderTextureType.PrepassNormalsSpec, material, 2);
			this.AMCOGJHPPOC.AAKGEKANKEE();
		}
		else if (this.DJIIILLNBIN())
		{
			ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, (BuiltinRenderTextureType)6);
			ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, material, 1, 3);
		}
		else
		{
			RenderTextureFormat format = this.AMCOGJHPPOC.MAIODKMOICL ? ((RenderTextureFormat)(-14)) : RenderTextureFormat.Shadowmap;
			int hmkdkkioiah = AKFPCBMKBFD.PDMBIIMGOEC.HMKDKKIOIAH;
			ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.GAIOLBJLPDL(), this.AMCOGJHPPOC.CICDECHCDBJ(), 1, FilterMode.Bilinear, format);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CurrentActive, hmkdkkioiah, mat, 1);
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, hmkdkkioiah);
			ECKPLMDEJFD.Blit(hmkdkkioiah, BuiltinRenderTextureType.Depth, material, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x06011319 RID: 70425 RVA: 0x007A6444 File Offset: 0x007A4644
	public string PJFGEOKEJHF()
	{
		return "ClimbUp";
	}

	// Token: 0x0601131A RID: 70426 RVA: 0x007A644B File Offset: 0x007A464B
	public CameraEvent NIMIDLHJBAB()
	{
		if (!this.CBEGLELKPAE() || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.DAKPGCMKCJP(BuiltinDebugViewsModel.CGNLFGLJGKA.Normals))
		{
			return (CameraEvent)33;
		}
		return (CameraEvent)65;
	}

	// Token: 0x0601131B RID: 70427 RVA: 0x007A6472 File Offset: 0x007A4672
	public bool NDNNEBKJDCD()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.OGCJCJHFHMC().intensity > 691f && this.AMCOGJHPPOC.FBCBNOGGGOH();
	}

	// Token: 0x0601131C RID: 70428 RVA: 0x007A64A8 File Offset: 0x007A46A8
	public DepthTextureMode KPDMEKCECJD()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.None;
		if (this.MIEJELDBJPE() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.None;
		}
		if (this.CMMNBIMBGJO() != (AKFPCBMKBFD.OLNKFHPPMNP)3)
		{
			depthTextureMode |= DepthTextureMode.MotionVectors;
		}
		return depthTextureMode;
	}

	// Token: 0x0601131D RID: 70429 RVA: 0x007A64D4 File Offset: 0x007A46D4
	private AKFPCBMKBFD.OLNKFHPPMNP MLBDLDEGOME()
	{
		if (this.AMCOGJHPPOC.KOIKCDLDJPD() && !base.BBEPCCALAFC.GOJNKFKPOKH().forceForwardCompatibility)
		{
			return (AKFPCBMKBFD.OLNKFHPPMNP)5;
		}
		if (base.BBEPCCALAFC.settings.highPrecision && (!this.AMCOGJHPPOC.KFIJMIGOJEJ() || base.BBEPCCALAFC.FEJJFMHMNHK().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
	}

	// Token: 0x0601131E RID: 70430 RVA: 0x007A6538 File Offset: 0x007A4738
	private AKFPCBMKBFD.OLNKFHPPMNP EHLKMLPJAAJ()
	{
		if (this.AMCOGJHPPOC.HGFJIBBNAAN() && !base.BBEPCCALAFC.OGCJCJHFHMC().forceForwardCompatibility)
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		if (base.BBEPCCALAFC.settings.highPrecision && (!this.AMCOGJHPPOC.BMHMGNLEOED() || base.BBEPCCALAFC.ANBJGJAJBFM().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
	}

	// Token: 0x0601131F RID: 70431 RVA: 0x007A659C File Offset: 0x007A479C
	private bool PCKAJPKEBBA()
	{
		return this.AMCOGJHPPOC.OEGOBDJNFOO() && base.BBEPCCALAFC.AEIDMBILAPI().ambientOnly && this.AMCOGJHPPOC.PJKIDHFNEKH() && base.BBEPCCALAFC.GOJNKFKPOKH().forceForwardCompatibility;
	}

	// Token: 0x06011320 RID: 70432 RVA: 0x007A65EA File Offset: 0x007A47EA
	public override CameraEvent POJFLMAFHEI()
	{
		if (!this.IKJCKHEKJDM || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.CLGLCBFDOKE(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
		{
			return CameraEvent.BeforeImageEffectsOpaque;
		}
		return CameraEvent.BeforeReflections;
	}

	// Token: 0x06011321 RID: 70433 RVA: 0x007A6614 File Offset: 0x007A4814
	private bool EGODCHFIGKH()
	{
		return this.AMCOGJHPPOC.PIGJFLMCLBC() && base.BBEPCCALAFC.IKLNPEMCDBO().ambientOnly && this.AMCOGJHPPOC.GNOBCFOKNME() && !base.BBEPCCALAFC.EBGFGEIIDNM().forceForwardCompatibility;
	}

	// Token: 0x06011322 RID: 70434 RVA: 0x007A6664 File Offset: 0x007A4864
	private AKFPCBMKBFD.OLNKFHPPMNP GBMPCIKJFGM()
	{
		if (this.AMCOGJHPPOC.HOLAOCKPNMM() && !base.BBEPCCALAFC.OGCJCJHFHMC().forceForwardCompatibility)
		{
			return (AKFPCBMKBFD.OLNKFHPPMNP)7;
		}
		if (base.BBEPCCALAFC.KDHGJFOLJJF().highPrecision && (!this.AMCOGJHPPOC.PJKIDHFNEKH() || base.BBEPCCALAFC.settings.forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
	}

	// Token: 0x06011323 RID: 70435 RVA: 0x007A66C8 File Offset: 0x007A48C8
	private AKFPCBMKBFD.OLNKFHPPMNP FAPONABAPNE()
	{
		if (this.AMCOGJHPPOC.HDBIPEDBMCC() && !base.BBEPCCALAFC.settings.forceForwardCompatibility)
		{
			return (AKFPCBMKBFD.OLNKFHPPMNP)7;
		}
		if (base.BBEPCCALAFC.ANBJGJAJBFM().highPrecision && (!this.AMCOGJHPPOC.EKDILDKALON() || base.BBEPCCALAFC.MPHDFJAHKAK().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
	}

	// Token: 0x06011324 RID: 70436 RVA: 0x007A672C File Offset: 0x007A492C
	public void BMPEMCPFPEF(CommandBuffer ECKPLMDEJFD)
	{
		AmbientOcclusionModel.Settings settings = base.BBEPCCALAFC.DOJLILFGNFM();
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.NLFMCBBJHBD("OneHandSwordBackSwing");
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.GNDBFKAJJCI("");
		material.shaderKeywords = null;
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.DNDCMHOCJGN, settings.intensity);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.GCFPHJFHLMP, settings.radius);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.MOKHLCPFMGA, settings.downsampling ? 1325f : 1043f);
		material.SetInt(AKFPCBMKBFD.PDMBIIMGOEC.HLEEGIAIJNM, (int)settings.sampleCount);
		if (!this.AMCOGJHPPOC.OFHANPNPEEJ() && RenderSettings.fog)
		{
			material.SetVector(AKFPCBMKBFD.PDMBIIMGOEC.JOEBAGCDCAB, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			switch (RenderSettings.fogMode)
			{
			case (FogMode)0:
				material.EnableKeyword("demoLong");
				break;
			case FogMode.Linear:
				material.EnableKeyword("WizardOverhead");
				break;
			case FogMode.Exponential:
				material.EnableKeyword("Didn't expect existing render texture: ");
				break;
			}
		}
		else
		{
			material.EnableKeyword("invn_rec27");
		}
		int num = this.AMCOGJHPPOC.GAIOLBJLPDL();
		int num2 = this.AMCOGJHPPOC.ILLKFNCFGMP;
		int num3 = settings.downsampling ? 0 : 0;
		int nameID = AKFPCBMKBFD.PDMBIIMGOEC.DCKJIFPMBIL;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num / num3, num2 / num3, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.Blit(null, nameID, material, (int)this.FDFEFAGPODC());
		int gfhflllnnmp = AKFPCBMKBFD.PDMBIIMGOEC.GFHFLLLNNMP;
		ECKPLMDEJFD.GetTemporaryRT(gfhflllnnmp, num, num2, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, gfhflllnnmp, material, (this.HCPAOJMKBAM() == (AKFPCBMKBFD.OLNKFHPPMNP)7) ? 6 : 4);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
		nameID = AKFPCBMKBFD.PDMBIIMGOEC.CPLOKLJJNEB;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num, num2, 0, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, gfhflllnnmp);
		ECKPLMDEJFD.Blit(gfhflllnnmp, nameID, material, 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(gfhflllnnmp);
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.DOHGPGNMDLM(BuiltinDebugViewsModel.CGNLFGLJGKA.PreGradingLog))
		{
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, BuiltinRenderTextureType.None, material, 2);
			this.AMCOGJHPPOC.JGNJIBIIANO();
		}
		else if (this.PDDEFPKDAFP())
		{
			ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, BuiltinRenderTextureType.PrepassNormalsSpec);
			ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, material, 0, 5);
		}
		else
		{
			RenderTextureFormat format = this.AMCOGJHPPOC.MAIODKMOICL ? ((RenderTextureFormat)(-45)) : RenderTextureFormat.Default;
			int hmkdkkioiah = AKFPCBMKBFD.PDMBIIMGOEC.HMKDKKIOIAH;
			ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.NMEBEEHCALN, this.AMCOGJHPPOC.LHPBMEDMNDO(), 0, FilterMode.Point, format);
			ECKPLMDEJFD.Blit((BuiltinRenderTextureType)6, hmkdkkioiah, mat, 0);
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, hmkdkkioiah);
			ECKPLMDEJFD.Blit(hmkdkkioiah, BuiltinRenderTextureType.CameraTarget, material, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x06011325 RID: 70437 RVA: 0x007A6A4C File Offset: 0x007A4C4C
	public string DPNPBIEDKJO()
	{
		return "OneHandSwordRun";
	}

	// Token: 0x06011326 RID: 70438 RVA: 0x007A6A54 File Offset: 0x007A4C54
	private bool GMAMLEBMGBL()
	{
		return this.AMCOGJHPPOC.OEGOBDJNFOO() && base.BBEPCCALAFC.ANBJGJAJBFM().ambientOnly && this.AMCOGJHPPOC.PJKIDHFNEKH() && base.BBEPCCALAFC.AEIDMBILAPI().forceForwardCompatibility;
	}

	// Token: 0x06011327 RID: 70439 RVA: 0x007A6AA2 File Offset: 0x007A4CA2
	public CameraEvent FENGEBDHNGB()
	{
		if (!this.DLIJNFONCMP() || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.EEFEOJIOAMA(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
		{
			return (CameraEvent)(-114);
		}
		return CameraEvent.BeforeDepthNormalsTexture;
	}

	// Token: 0x06011328 RID: 70440 RVA: 0x007A6AC9 File Offset: 0x007A4CC9
	public string GCLKCKNLKJM()
	{
		return "x{0} {1}\n";
	}

	// Token: 0x06011329 RID: 70441 RVA: 0x007A6AD0 File Offset: 0x007A4CD0
	public CameraEvent FPOMDHPNNLK()
	{
		if (!this.LEBLFJHFMPJ() || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.CLGLCBFDOKE(BuiltinDebugViewsModel.CGNLFGLJGKA.None))
		{
			return (CameraEvent)71;
		}
		return (CameraEvent)57;
	}

	// Token: 0x0601132A RID: 70442 RVA: 0x007A6AF7 File Offset: 0x007A4CF7
	public bool FENBNOPMKHF()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.GEKPOGFKOIB().intensity > 306f && !this.AMCOGJHPPOC.FBCBNOGGGOH();
	}

	// Token: 0x0601132B RID: 70443 RVA: 0x007A6B2D File Offset: 0x007A4D2D
	public bool JJJMELDCPEH()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.ODHAGPCKILK().intensity > 742f && !this.AMCOGJHPPOC.BEHHDDABAGA();
	}

	// Token: 0x0601132C RID: 70444 RVA: 0x007A6B64 File Offset: 0x007A4D64
	private AKFPCBMKBFD.OLNKFHPPMNP HCPAOJMKBAM()
	{
		if (this.AMCOGJHPPOC.HOLAOCKPNMM() && !base.BBEPCCALAFC.KKANBOFAFLC().forceForwardCompatibility)
		{
			return (AKFPCBMKBFD.OLNKFHPPMNP)3;
		}
		if (base.BBEPCCALAFC.KDHGJFOLJJF().highPrecision && (!this.AMCOGJHPPOC.HGFJIBBNAAN() || base.BBEPCCALAFC.DDIOPCAEBEJ().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
	}

	// Token: 0x0601132D RID: 70445 RVA: 0x007A6BC6 File Offset: 0x007A4DC6
	public CameraEvent KMMEEGPFLMA()
	{
		if (!this.JAMHHMDBHBB() || this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BNJOBIPEKJD(BuiltinDebugViewsModel.CGNLFGLJGKA.None))
		{
			return (CameraEvent)(-96);
		}
		return (CameraEvent)(-127);
	}

	// Token: 0x0601132E RID: 70446 RVA: 0x007A6BED File Offset: 0x007A4DED
	public string NFEDMNAPOKG()
	{
		return "_StereoToPrevViewProjCombined1";
	}

	// Token: 0x0601132F RID: 70447 RVA: 0x007A6BF4 File Offset: 0x007A4DF4
	public void PONHJLHPKMC(CommandBuffer ECKPLMDEJFD)
	{
		AmbientOcclusionModel.Settings settings = base.BBEPCCALAFC.OJADINGIJLA();
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.IBMKEBEEFKP("");
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JKBKMPBBGBA("USE_DEPTH");
		material.shaderKeywords = null;
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.DNDCMHOCJGN, settings.intensity);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.GCFPHJFHLMP, settings.radius);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.MOKHLCPFMGA, settings.downsampling ? 413f : 550f);
		material.SetInt(AKFPCBMKBFD.PDMBIIMGOEC.HLEEGIAIJNM, (int)settings.sampleCount);
		if (!this.AMCOGJHPPOC.KFIJMIGOJEJ() && RenderSettings.fog)
		{
			material.SetVector(AKFPCBMKBFD.PDMBIIMGOEC.JOEBAGCDCAB, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			switch (RenderSettings.fogMode)
			{
			case FogMode.Linear:
				material.EnableKeyword("KatanaReadyLow");
				break;
			case FogMode.Exponential:
				material.EnableKeyword("_ALPHABLEND_ON");
				break;
			case FogMode.ExponentialSquared:
				material.EnableKeyword("Pointing");
				break;
			}
		}
		else
		{
			material.EnableKeyword("</b>\n : ");
		}
		int num = this.AMCOGJHPPOC.NMEBEEHCALN;
		int num2 = this.AMCOGJHPPOC.ILLKFNCFGMP;
		int num3 = settings.downsampling ? 1 : 0;
		int nameID = AKFPCBMKBFD.PDMBIIMGOEC.DCKJIFPMBIL;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num / num3, num2 / num3, 1, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.Blit(null, nameID, material, (int)this.GAEICPHEIKE());
		int gfhflllnnmp = AKFPCBMKBFD.PDMBIIMGOEC.GFHFLLLNNMP;
		ECKPLMDEJFD.GetTemporaryRT(gfhflllnnmp, num, num2, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, gfhflllnnmp, material, (this.MIEJELDBJPE() == (AKFPCBMKBFD.OLNKFHPPMNP)6) ? 4 : 5);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
		nameID = AKFPCBMKBFD.PDMBIIMGOEC.CPLOKLJJNEB;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num, num2, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, gfhflllnnmp);
		ECKPLMDEJFD.Blit(gfhflllnnmp, nameID, material, 1);
		ECKPLMDEJFD.ReleaseTemporaryRT(gfhflllnnmp);
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.CAOCNMBBHLM(BuiltinDebugViewsModel.CGNLFGLJGKA.MotionVectors))
		{
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, (BuiltinRenderTextureType)6, material, 4);
			this.AMCOGJHPPOC.BDLOPJPLHJN();
		}
		else if (this.GDBMKIKBNAL())
		{
			ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, BuiltinRenderTextureType.ResolvedDepth);
			ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, material, 1, 3);
		}
		else
		{
			RenderTextureFormat format = this.AMCOGJHPPOC.OEGOBDJNFOO() ? ((RenderTextureFormat)(-44)) : RenderTextureFormat.RGB565;
			int hmkdkkioiah = AKFPCBMKBFD.PDMBIIMGOEC.HMKDKKIOIAH;
			ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.IGHJHMGOGOO(), this.AMCOGJHPPOC.MMEMLJENMFF(), 0, FilterMode.Bilinear, format);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, hmkdkkioiah, mat, 1);
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, hmkdkkioiah);
			ECKPLMDEJFD.Blit(hmkdkkioiah, BuiltinRenderTextureType.PrepassNormalsSpec, material, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x06011330 RID: 70448 RVA: 0x007A6F14 File Offset: 0x007A5114
	private bool LEJDAGJNAPJ()
	{
		return this.AMCOGJHPPOC.HCHNHOFPIFK() && base.BBEPCCALAFC.IKLNPEMCDBO().ambientOnly && this.AMCOGJHPPOC.GNOBCFOKNME() && !base.BBEPCCALAFC.ODHAGPCKILK().forceForwardCompatibility;
	}

	// Token: 0x06011331 RID: 70449 RVA: 0x007A6F64 File Offset: 0x007A5164
	private AKFPCBMKBFD.OLNKFHPPMNP CMMNBIMBGJO()
	{
		if (this.AMCOGJHPPOC.PJKIDHFNEKH() && !base.BBEPCCALAFC.EBGFGEIIDNM().forceForwardCompatibility)
		{
			return (AKFPCBMKBFD.OLNKFHPPMNP)6;
		}
		if (base.BBEPCCALAFC.ODHAGPCKILK().highPrecision && (!this.AMCOGJHPPOC.KFIJMIGOJEJ() || base.BBEPCCALAFC.OJADINGIJLA().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
	}

	// Token: 0x06011332 RID: 70450 RVA: 0x007A6FC8 File Offset: 0x007A51C8
	private bool PDDEFPKDAFP()
	{
		return !this.AMCOGJHPPOC.PIGJFLMCLBC() || !base.BBEPCCALAFC.OGCJCJHFHMC().ambientOnly || !this.AMCOGJHPPOC.BMHMGNLEOED() || !base.BBEPCCALAFC.KKANBOFAFLC().forceForwardCompatibility;
	}

	// Token: 0x06011333 RID: 70451 RVA: 0x007A7016 File Offset: 0x007A5216
	public bool NKNFJAPAFIF()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.MPHDFJAHKAK().intensity <= 1617f || !this.AMCOGJHPPOC.GCPDMBIEAOG();
	}

	// Token: 0x06011334 RID: 70452 RVA: 0x007A704C File Offset: 0x007A524C
	private AKFPCBMKBFD.OLNKFHPPMNP HMBOCNBELLP()
	{
		if (this.AMCOGJHPPOC.MDGMGJOKFCL() && !base.BBEPCCALAFC.FEJJFMHMNHK().forceForwardCompatibility)
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.GBuffer;
		}
		if (base.BBEPCCALAFC.KOMEDFGKGGE().highPrecision && (!this.AMCOGJHPPOC.EKDILDKALON() || base.BBEPCCALAFC.MPHDFJAHKAK().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
	}

	// Token: 0x06011335 RID: 70453 RVA: 0x007A70B0 File Offset: 0x007A52B0
	private AKFPCBMKBFD.OLNKFHPPMNP EEPCOCPHEED()
	{
		if (this.AMCOGJHPPOC.KFIJMIGOJEJ() && !base.BBEPCCALAFC.EBGFGEIIDNM().forceForwardCompatibility)
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		if (base.BBEPCCALAFC.EBGFGEIIDNM().highPrecision && (!this.AMCOGJHPPOC.GNOBCFOKNME() || base.BBEPCCALAFC.BOLPFGAMAED().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
	}

	// Token: 0x06011336 RID: 70454 RVA: 0x007A7114 File Offset: 0x007A5314
	public DepthTextureMode DPCKJICEDMB()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.Depth;
		if (this.AKLPCMKLFHC() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.None;
		}
		if (this.MLBDLDEGOME() != (AKFPCBMKBFD.OLNKFHPPMNP)6)
		{
			depthTextureMode |= (DepthTextureMode)8;
		}
		return depthTextureMode;
	}

	// Token: 0x06011337 RID: 70455 RVA: 0x007A713D File Offset: 0x007A533D
	public string DJKALGKNMFP()
	{
		return "usetime";
	}

	// Token: 0x06011338 RID: 70456 RVA: 0x007A7144 File Offset: 0x007A5344
	private AKFPCBMKBFD.OLNKFHPPMNP GKHJBOIOJEK()
	{
		if (this.AMCOGJHPPOC.GLJKDPBAPKJ && !base.BBEPCCALAFC.OJADINGIJLA().forceForwardCompatibility)
		{
			return (AKFPCBMKBFD.OLNKFHPPMNP)6;
		}
		if (base.BBEPCCALAFC.BOLPFGAMAED().highPrecision && (!this.AMCOGJHPPOC.GLJKDPBAPKJ || base.BBEPCCALAFC.ANBJGJAJBFM().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
	}

	// Token: 0x170003C0 RID: 960
	// (get) Token: 0x06011339 RID: 70457 RVA: 0x007A71A6 File Offset: 0x007A53A6
	public override bool NLFEIOCKHKA
	{
		get
		{
			return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.settings.intensity > 0f && !this.AMCOGJHPPOC.CFABOAAPLPI;
		}
	}

	// Token: 0x0601133A RID: 70458 RVA: 0x007A71DC File Offset: 0x007A53DC
	public DepthTextureMode MBCBOMLGPPO()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.Depth;
		if (this.FDKBMPBPEFD() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.None;
		}
		if (this.ICCBNGBCIKD() != (AKFPCBMKBFD.OLNKFHPPMNP)5)
		{
			depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors);
		}
		return depthTextureMode;
	}

	// Token: 0x0601133B RID: 70459 RVA: 0x007A7208 File Offset: 0x007A5408
	private AKFPCBMKBFD.OLNKFHPPMNP EJDFLJCCHKO()
	{
		if (this.AMCOGJHPPOC.MDGMGJOKFCL() && !base.BBEPCCALAFC.BOLPFGAMAED().forceForwardCompatibility)
		{
			return (AKFPCBMKBFD.OLNKFHPPMNP)6;
		}
		if (base.BBEPCCALAFC.ODHAGPCKILK().highPrecision && (!this.AMCOGJHPPOC.HGFJIBBNAAN() || base.BBEPCCALAFC.settings.forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture;
	}

	// Token: 0x0601133C RID: 70460 RVA: 0x007A726A File Offset: 0x007A546A
	public bool NHCLJOJLABJ()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.EBGFGEIIDNM().intensity > 1934f && !this.AMCOGJHPPOC.DBAMKBECNIJ();
	}

	// Token: 0x0601133D RID: 70461 RVA: 0x007A72A0 File Offset: 0x007A54A0
	private bool DEJAELIEHHM()
	{
		return !this.AMCOGJHPPOC.BACMPNMDHBL() || !base.BBEPCCALAFC.KDHGJFOLJJF().ambientOnly || !this.AMCOGJHPPOC.KOIKCDLDJPD() || base.BBEPCCALAFC.KKANBOFAFLC().forceForwardCompatibility;
	}

	// Token: 0x0601133E RID: 70462 RVA: 0x007A72F0 File Offset: 0x007A54F0
	public void JCGMBPEBIJF(CommandBuffer ECKPLMDEJFD)
	{
		AmbientOcclusionModel.Settings settings = base.BBEPCCALAFC.DOJLILFGNFM();
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.OAJBECLLIEP("OfficeSittingEyesRub");
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.EIJMKFHFKDG("CrouchStrafeLeft");
		material.shaderKeywords = null;
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.DNDCMHOCJGN, settings.intensity);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.GCFPHJFHLMP, settings.radius);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.MOKHLCPFMGA, settings.downsampling ? 1522f : 495f);
		material.SetInt(AKFPCBMKBFD.PDMBIIMGOEC.HLEEGIAIJNM, (int)settings.sampleCount);
		if (!this.AMCOGJHPPOC.LEIJCKEIMGH() && RenderSettings.fog)
		{
			material.SetVector(AKFPCBMKBFD.PDMBIIMGOEC.JOEBAGCDCAB, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			switch (RenderSettings.fogMode)
			{
			case (FogMode)0:
				material.EnableKeyword("SoccerStartKick");
				break;
			case FogMode.Linear:
				material.EnableKeyword("t_body");
				break;
			case FogMode.Exponential:
				material.EnableKeyword("cht_msg20");
				break;
			}
		}
		else
		{
			material.EnableKeyword("x");
		}
		int num = this.AMCOGJHPPOC.GMOLEDNNPEH();
		int num2 = this.AMCOGJHPPOC.CICDECHCDBJ();
		int num3 = settings.downsampling ? 3 : 0;
		int nameID = AKFPCBMKBFD.PDMBIIMGOEC.DCKJIFPMBIL;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num / num3, num2 / num3, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.Blit(null, nameID, material, (int)this.PNGGIAHLHON());
		int gfhflllnnmp = AKFPCBMKBFD.PDMBIIMGOEC.GFHFLLLNNMP;
		ECKPLMDEJFD.GetTemporaryRT(gfhflllnnmp, num, num2, 1, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, gfhflllnnmp, material, (this.BHPLOLOMBAC() == (AKFPCBMKBFD.OLNKFHPPMNP)7) ? 1 : 5);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
		nameID = AKFPCBMKBFD.PDMBIIMGOEC.CPLOKLJJNEB;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num, num2, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, gfhflllnnmp);
		ECKPLMDEJFD.Blit(gfhflllnnmp, nameID, material, 7);
		ECKPLMDEJFD.ReleaseTemporaryRT(gfhflllnnmp);
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BGKOOHLKCNJ(BuiltinDebugViewsModel.CGNLFGLJGKA.MotionVectors))
		{
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, BuiltinRenderTextureType.CameraTarget, material, 3);
			this.AMCOGJHPPOC.AAKGEKANKEE();
		}
		else if (this.EFEJJIDGPCC())
		{
			ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, BuiltinRenderTextureType.CameraTarget);
			ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, material, 0, 1);
		}
		else
		{
			RenderTextureFormat format = this.AMCOGJHPPOC.DLFNPFAGPFC() ? RenderTextureFormat.BGR101010_XR : RenderTextureFormat.ARGB2101010;
			int hmkdkkioiah = AKFPCBMKBFD.PDMBIIMGOEC.HMKDKKIOIAH;
			ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.IBPMMKDPDEO(), this.AMCOGJHPPOC.HJOKFIGACEC(), 1, FilterMode.Point, format);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, hmkdkkioiah, mat, 0);
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, hmkdkkioiah);
			ECKPLMDEJFD.Blit(hmkdkkioiah, BuiltinRenderTextureType.None, material, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x0601133F RID: 70463 RVA: 0x007A7610 File Offset: 0x007A5810
	public void KNNDBINHLDE(CommandBuffer ECKPLMDEJFD)
	{
		AmbientOcclusionModel.Settings settings = base.BBEPCCALAFC.FEJJFMHMNHK();
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.NLFMCBBJHBD("_Offsets");
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.FGKNJIEOKHH("wpn_tank1");
		material.shaderKeywords = null;
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.DNDCMHOCJGN, settings.intensity);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.GCFPHJFHLMP, settings.radius);
		material.SetFloat(AKFPCBMKBFD.PDMBIIMGOEC.MOKHLCPFMGA, settings.downsampling ? 1206f : 482f);
		material.SetInt(AKFPCBMKBFD.PDMBIIMGOEC.HLEEGIAIJNM, (int)settings.sampleCount);
		if (!this.AMCOGJHPPOC.BMHMGNLEOED() && RenderSettings.fog)
		{
			material.SetVector(AKFPCBMKBFD.PDMBIIMGOEC.JOEBAGCDCAB, new Vector3(RenderSettings.fogDensity, RenderSettings.fogStartDistance, RenderSettings.fogEndDistance));
			switch (RenderSettings.fogMode)
			{
			case FogMode.Linear:
				material.EnableKeyword("https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
				break;
			case FogMode.Exponential:
				material.EnableKeyword("txt");
				break;
			case FogMode.ExponentialSquared:
				material.EnableKeyword("");
				break;
			}
		}
		else
		{
			material.EnableKeyword("autherror");
		}
		int num = this.AMCOGJHPPOC.GMOLEDNNPEH();
		int num2 = this.AMCOGJHPPOC.LKLNPJICOHH();
		int num3 = settings.downsampling ? 5 : 1;
		int nameID = AKFPCBMKBFD.PDMBIIMGOEC.DCKJIFPMBIL;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num / num3, num2 / num3, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.Blit(null, nameID, material, (int)this.MLBDLDEGOME());
		int gfhflllnnmp = AKFPCBMKBFD.PDMBIIMGOEC.GFHFLLLNNMP;
		ECKPLMDEJFD.GetTemporaryRT(gfhflllnnmp, num, num2, 1, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
		ECKPLMDEJFD.Blit(nameID, gfhflllnnmp, material, (this.GKHJBOIOJEK() == (AKFPCBMKBFD.OLNKFHPPMNP)8) ? 8 : 7);
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
		nameID = AKFPCBMKBFD.PDMBIIMGOEC.CPLOKLJJNEB;
		ECKPLMDEJFD.GetTemporaryRT(nameID, num, num2, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, gfhflllnnmp);
		ECKPLMDEJFD.Blit(gfhflllnnmp, nameID, material, 3);
		ECKPLMDEJFD.ReleaseTemporaryRT(gfhflllnnmp);
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.PNJNAECPOON(BuiltinDebugViewsModel.CGNLFGLJGKA.PreGradingLog))
		{
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, nameID);
			ECKPLMDEJFD.Blit(nameID, BuiltinRenderTextureType.PrepassLight, material, 7);
			this.AMCOGJHPPOC.FBJPOAGDFKN();
		}
		else if (this.CBEGLELKPAE())
		{
			ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, BuiltinRenderTextureType.PrepassLight);
			ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, material, 0, 7);
		}
		else
		{
			RenderTextureFormat format = this.AMCOGJHPPOC.BACMPNMDHBL() ? ((RenderTextureFormat)(-17)) : RenderTextureFormat.RGB565;
			int hmkdkkioiah = AKFPCBMKBFD.PDMBIIMGOEC.HMKDKKIOIAH;
			ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.KJDPLLFIIBK(), this.AMCOGJHPPOC.LPJJBJCIELA(), 1, FilterMode.Point, format);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, hmkdkkioiah, mat, 1);
			ECKPLMDEJFD.SetGlobalTexture(AKFPCBMKBFD.PDMBIIMGOEC.OCMLEEAPHNB, hmkdkkioiah);
			ECKPLMDEJFD.Blit(hmkdkkioiah, BuiltinRenderTextureType.CameraTarget, material, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(nameID);
	}

	// Token: 0x06011340 RID: 70464 RVA: 0x007A7930 File Offset: 0x007A5B30
	public DepthTextureMode ADNPLACJLIE()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.Depth;
		if (this.AKLPCMKLFHC() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.None;
		}
		if (this.HCPAOJMKBAM() != (AKFPCBMKBFD.OLNKFHPPMNP)6)
		{
			depthTextureMode |= (DepthTextureMode)8;
		}
		return depthTextureMode;
	}

	// Token: 0x170003BF RID: 959
	// (get) Token: 0x06011341 RID: 70465 RVA: 0x007A795C File Offset: 0x007A5B5C
	private bool IKJCKHEKJDM
	{
		get
		{
			return this.AMCOGJHPPOC.MAIODKMOICL && base.BBEPCCALAFC.settings.ambientOnly && this.AMCOGJHPPOC.GLJKDPBAPKJ && !base.BBEPCCALAFC.settings.forceForwardCompatibility;
		}
	}

	// Token: 0x06011342 RID: 70466 RVA: 0x007A79AC File Offset: 0x007A5BAC
	private bool CDGMOHJNKLG()
	{
		return this.AMCOGJHPPOC.NNILENLPFDO() && base.BBEPCCALAFC.DDIOPCAEBEJ().ambientOnly && this.AMCOGJHPPOC.KFIJMIGOJEJ() && !base.BBEPCCALAFC.OGCJCJHFHMC().forceForwardCompatibility;
	}

	// Token: 0x06011343 RID: 70467 RVA: 0x007A79FC File Offset: 0x007A5BFC
	public DepthTextureMode GHKIMCNHIHD()
	{
		DepthTextureMode depthTextureMode = DepthTextureMode.Depth;
		if (this.GHAHNHGNNIN() == AKFPCBMKBFD.OLNKFHPPMNP.DepthTexture)
		{
			depthTextureMode |= DepthTextureMode.Depth;
		}
		if (this.PNGGIAHLHON() != (AKFPCBMKBFD.OLNKFHPPMNP)5)
		{
			depthTextureMode |= (DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors);
		}
		return depthTextureMode;
	}

	// Token: 0x06011344 RID: 70468 RVA: 0x007A7A28 File Offset: 0x007A5C28
	private AKFPCBMKBFD.OLNKFHPPMNP PNGGIAHLHON()
	{
		if (this.AMCOGJHPPOC.BMHMGNLEOED() && !base.BBEPCCALAFC.ODHAGPCKILK().forceForwardCompatibility)
		{
			return (AKFPCBMKBFD.OLNKFHPPMNP)6;
		}
		if (base.BBEPCCALAFC.KKANBOFAFLC().highPrecision && (!this.AMCOGJHPPOC.HOLAOCKPNMM() || base.BBEPCCALAFC.DFDOFBHMALI().forceForwardCompatibility))
		{
			return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
		}
		return AKFPCBMKBFD.OLNKFHPPMNP.DepthNormalsTexture;
	}

	// Token: 0x040023E2 RID: 9186
	private readonly RenderTargetIdentifier[] AKNMAGILBHJ = new RenderTargetIdentifier[]
	{
		BuiltinRenderTextureType.GBuffer0,
		BuiltinRenderTextureType.CameraTarget
	};

	// Token: 0x040023E3 RID: 9187
	private static string LANBBIMHEGN = "Hidden/Post FX/Blit";

	// Token: 0x040023E4 RID: 9188
	private static string GOFANCALMLK = "Hidden/Post FX/Ambient Occlusion";

	// Token: 0x0200050C RID: 1292
	private static class PDMBIIMGOEC
	{
		// Token: 0x040023E5 RID: 9189
		internal static readonly int DNDCMHOCJGN = Shader.PropertyToID("_Intensity");

		// Token: 0x040023E6 RID: 9190
		internal static readonly int GCFPHJFHLMP = Shader.PropertyToID("_Radius");

		// Token: 0x040023E7 RID: 9191
		internal static readonly int JOEBAGCDCAB = Shader.PropertyToID("_FogParams");

		// Token: 0x040023E8 RID: 9192
		internal static readonly int MOKHLCPFMGA = Shader.PropertyToID("_Downsample");

		// Token: 0x040023E9 RID: 9193
		internal static readonly int HLEEGIAIJNM = Shader.PropertyToID("_SampleCount");

		// Token: 0x040023EA RID: 9194
		internal static readonly int DCKJIFPMBIL = Shader.PropertyToID("_OcclusionTexture1");

		// Token: 0x040023EB RID: 9195
		internal static readonly int GFHFLLLNNMP = Shader.PropertyToID("_OcclusionTexture2");

		// Token: 0x040023EC RID: 9196
		internal static readonly int CPLOKLJJNEB = Shader.PropertyToID("_OcclusionTexture");

		// Token: 0x040023ED RID: 9197
		internal static readonly int OCMLEEAPHNB = Shader.PropertyToID("_MainTex");

		// Token: 0x040023EE RID: 9198
		internal static readonly int HMKDKKIOIAH = Shader.PropertyToID("_TempRT");
	}

	// Token: 0x0200050D RID: 1293
	private enum OLNKFHPPMNP
	{
		// Token: 0x040023F0 RID: 9200
		DepthTexture,
		// Token: 0x040023F1 RID: 9201
		DepthNormalsTexture,
		// Token: 0x040023F2 RID: 9202
		GBuffer
	}
}
