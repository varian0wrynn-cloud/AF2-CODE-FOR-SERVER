using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x02000520 RID: 1312
public sealed class BKKAAEAHNJK : CFPOKEIJEAB<AntialiasingModel>
{
	// Token: 0x0601167B RID: 71291 RVA: 0x007C4D20 File Offset: 0x007C2F20
	public void CIKPFDFOJEA(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.JADKPIOKKMG().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.PIPNAHLJKKD("OfficeSittingEyesRub");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x0601167C RID: 71292 RVA: 0x007C4DD0 File Offset: 0x007C2FD0
	public void JEIJEHCDOJO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.DJKEIONCLCG().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.HPAJGFGNMOH("_FogAlpha");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x0601167D RID: 71293 RVA: 0x007C4E7E File Offset: 0x007C307E
	public bool DLCMLAOJBFA()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.NKJEFFLKMJA().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && !this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x0601167E RID: 71294 RVA: 0x007C4EAF File Offset: 0x007C30AF
	public bool CKDGDAGBHNF()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.JMEDGLJKFDK().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || this.AMCOGJHPPOC.NOAGCLGAJNE();
	}

	// Token: 0x0601167F RID: 71295 RVA: 0x007C4EE0 File Offset: 0x007C30E0
	public void PNLGEJEBBMJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.JADKPIOKKMG().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.EIJMKFHFKDG(" for ");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x06011680 RID: 71296 RVA: 0x007C4F8E File Offset: 0x007C318E
	public bool IJLFFLDAPDL()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.DGMJHJDFFAA().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || this.AMCOGJHPPOC.MLMGNHHAOHF();
	}

	// Token: 0x06011681 RID: 71297 RVA: 0x007C4FC0 File Offset: 0x007C31C0
	public void BHLFNCNLBHO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.settings.fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/FXAA");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x06011682 RID: 71298 RVA: 0x007C5070 File Offset: 0x007C3270
	public void FFGKLFKJNEC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.settings.fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DGOMGBDLAFP("{not_found}");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x06011683 RID: 71299 RVA: 0x007C5120 File Offset: 0x007C3320
	public void KOADMJPOIKH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.GEKPOGFKOIB().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JDGIHFLNMKB("hair");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x06011684 RID: 71300 RVA: 0x007C51CE File Offset: 0x007C33CE
	public bool LKCGDJDKBIN()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.LECLLIGLNIJ().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || this.AMCOGJHPPOC.ACEEFEFOCDF();
	}

	// Token: 0x06011685 RID: 71301 RVA: 0x007C5200 File Offset: 0x007C3400
	public void KMHHHFIFDLF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.CIBNPGCPGPF().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.HJFNEOFMJEJ(" has no HandPoser/GenericPoser attached.");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x06011686 RID: 71302 RVA: 0x007C52AE File Offset: 0x007C34AE
	public bool GMJELGIOFCI()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.HMCGGODBANJ().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && !this.AMCOGJHPPOC.GCPDMBIEAOG();
	}

	// Token: 0x06011687 RID: 71303 RVA: 0x007C52E0 File Offset: 0x007C34E0
	public void OJIBNHAPPII(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.JADKPIOKKMG().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.GNDBFKAJJCI("id");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 1);
	}

	// Token: 0x06011688 RID: 71304 RVA: 0x007C538E File Offset: 0x007C358E
	public bool BAGMDFIAKGL()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.PNNGLBOIIMH().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || !this.AMCOGJHPPOC.AFIPEFLJBBM();
	}

	// Token: 0x06011689 RID: 71305 RVA: 0x007C53C0 File Offset: 0x007C35C0
	public void LAFEPCEHGHP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.MPHDFJAHKAK().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.HPAJGFGNMOH("goSpiralCenter");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 1);
	}

	// Token: 0x0601168A RID: 71306 RVA: 0x007C546E File Offset: 0x007C366E
	public bool HKCMJIIALMC()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.LMEKEGJMPBN().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x0601168B RID: 71307 RVA: 0x007C549F File Offset: 0x007C369F
	public bool MJPDFPDEDHN()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.FNAOHMNKKMB().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && this.AMCOGJHPPOC.MLMGNHHAOHF();
	}

	// Token: 0x0601168C RID: 71308 RVA: 0x007C54D0 File Offset: 0x007C36D0
	public bool BNEAAFFAFOH()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.JADKPIOKKMG().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || !this.AMCOGJHPPOC.POJLMOPEBLN();
	}

	// Token: 0x0601168D RID: 71309 RVA: 0x007C5501 File Offset: 0x007C3701
	public bool LLPDCLKLKEM()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.LIKDNAJFKMN().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || !this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x0601168E RID: 71310 RVA: 0x007C5532 File Offset: 0x007C3732
	public bool AMGEDEPHDKI()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.LIKDNAJFKMN().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || !this.AMCOGJHPPOC.HALNOLGLEOJ();
	}

	// Token: 0x0601168F RID: 71311 RVA: 0x007C5564 File Offset: 0x007C3764
	public void ECONFPMEOPF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.MEPIPLDFEJH().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JDGIHFLNMKB("OfficeSitting");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x06011690 RID: 71312 RVA: 0x007C5612 File Offset: 0x007C3812
	public bool EABMDBKOBAF()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.KHOIICPPPOD().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x06011691 RID: 71313 RVA: 0x007C5643 File Offset: 0x007C3843
	public bool IGOEANBMAIK()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.DKGMLIFDGFF().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && !this.AMCOGJHPPOC.DBAMKBECNIJ();
	}

	// Token: 0x06011692 RID: 71314 RVA: 0x007C5674 File Offset: 0x007C3874
	public bool CAAFNKCIHFE()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.DJDJANEACGF().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && this.AMCOGJHPPOC.DBAMKBECNIJ();
	}

	// Token: 0x06011693 RID: 71315 RVA: 0x007C56A5 File Offset: 0x007C38A5
	public bool JKJAOLDEFIM()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.settings.method != AntialiasingModel.HNCLDIDKLAH.Fxaa || !this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x06011694 RID: 71316 RVA: 0x007C56D6 File Offset: 0x007C38D6
	public bool LOHCBHJCBNL()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.PNNGLBOIIMH().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && this.AMCOGJHPPOC.ANFINECKHNH();
	}

	// Token: 0x06011695 RID: 71317 RVA: 0x007C5708 File Offset: 0x007C3908
	public void CBLKGKCBBOH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.CGKPLOICANA().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JNKAJCFJHIP("move");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x06011696 RID: 71318 RVA: 0x007C57B6 File Offset: 0x007C39B6
	public bool PLHOMLDDDHI()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.PNNGLBOIIMH().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && this.AMCOGJHPPOC.CHJAIAPCMDC();
	}

	// Token: 0x06011697 RID: 71319 RVA: 0x007C57E8 File Offset: 0x007C39E8
	public void BEEFAIIKICG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.DGMJHJDFFAA().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DFEMMOCHMDM("21");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 1);
	}

	// Token: 0x06011698 RID: 71320 RVA: 0x007C5898 File Offset: 0x007C3A98
	public void NPPIHCLOCHD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.MEPIPLDFEJH().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG(" is represented multiple times in BipedReferences spine.");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 1);
	}

	// Token: 0x06011699 RID: 71321 RVA: 0x007C5948 File Offset: 0x007C3B48
	public void DBLKONFBIDF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.JADKPIOKKMG().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.GJOHODHDPDN("ArmFlex2");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 1);
	}

	// Token: 0x0601169A RID: 71322 RVA: 0x007C59F6 File Offset: 0x007C3BF6
	public bool ICGMMGHLHLK()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.BMPIBIPNMCN().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || !this.AMCOGJHPPOC.ODNAHJKPHKA();
	}

	// Token: 0x0601169B RID: 71323 RVA: 0x007C5A27 File Offset: 0x007C3C27
	public bool OFACOBCOOCG()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.FNAOHMNKKMB().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || !this.AMCOGJHPPOC.CFABOAAPLPI;
	}

	// Token: 0x170003CC RID: 972
	// (get) Token: 0x0601169C RID: 71324 RVA: 0x007C5A58 File Offset: 0x007C3C58
	public override bool NLFEIOCKHKA
	{
		get
		{
			return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.settings.method == AntialiasingModel.HNCLDIDKLAH.Fxaa && !this.AMCOGJHPPOC.CFABOAAPLPI;
		}
	}

	// Token: 0x0601169D RID: 71325 RVA: 0x007C5A89 File Offset: 0x007C3C89
	public bool BJAIILKMCBK()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.FNAOHMNKKMB().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && this.AMCOGJHPPOC.FBCBNOGGGOH();
	}

	// Token: 0x0601169E RID: 71326 RVA: 0x007C5ABA File Offset: 0x007C3CBA
	public bool HNGPGKMMDCO()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.KHOIICPPPOD().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && !this.AMCOGJHPPOC.ACEEFEFOCDF();
	}

	// Token: 0x0601169F RID: 71327 RVA: 0x007C5AEC File Offset: 0x007C3CEC
	public void OMBLMDFCKKG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.DJKEIONCLCG().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.PIPNAHLJKKD("SexyDance3");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x060116A0 RID: 71328 RVA: 0x007C5B9A File Offset: 0x007C3D9A
	public bool EHPCNOOJFMH()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.GNKFCHPIOAG().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || this.AMCOGJHPPOC.NOAGCLGAJNE();
	}

	// Token: 0x060116A1 RID: 71329 RVA: 0x007C5BCB File Offset: 0x007C3DCB
	public bool KCMKDGLNNPM()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.PNNGLBOIIMH().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || this.AMCOGJHPPOC.FBCBNOGGGOH();
	}

	// Token: 0x060116A2 RID: 71330 RVA: 0x007C5BFC File Offset: 0x007C3DFC
	public bool GIAKLNBJHDH()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.LMEKEGJMPBN().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || !this.AMCOGJHPPOC.HFIFOAPFKBG();
	}

	// Token: 0x060116A3 RID: 71331 RVA: 0x007C5C2D File Offset: 0x007C3E2D
	public bool IOPILNONBKF()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.DJKEIONCLCG().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && !this.AMCOGJHPPOC.AFIPEFLJBBM();
	}

	// Token: 0x060116A4 RID: 71332 RVA: 0x007C5C60 File Offset: 0x007C3E60
	public void EJMBCDGBGGC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.MJAFCPCECCL().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.CPFHLGIKEJC("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_polygonal.html");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 1);
	}

	// Token: 0x060116A5 RID: 71333 RVA: 0x007C5D10 File Offset: 0x007C3F10
	public void CABIFLLIPBH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.CNAAMGCNGHF().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.EIJMKFHFKDG("wpn_bait_vob_1");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x060116A6 RID: 71334 RVA: 0x007C5DC0 File Offset: 0x007C3FC0
	public void CBNFNANELLL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.JMEDGLJKFDK().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JDGIHFLNMKB("gi_um_5");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x060116A7 RID: 71335 RVA: 0x007C5E6E File Offset: 0x007C406E
	public bool JJJMELDCPEH()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.DMJMEMIPKNM().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || this.AMCOGJHPPOC.MLJCADOONGI();
	}

	// Token: 0x060116A8 RID: 71336 RVA: 0x007C5E9F File Offset: 0x007C409F
	public bool PKNNDJIIMPB()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.DJKEIONCLCG().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || this.AMCOGJHPPOC.MLJCADOONGI();
	}

	// Token: 0x060116A9 RID: 71337 RVA: 0x007C5ED0 File Offset: 0x007C40D0
	public void AAJOPJLLBFK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.EJLJKCJKJGA().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NJACPJPGJFB("_FogData");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 1);
	}

	// Token: 0x060116AA RID: 71338 RVA: 0x007C5F7E File Offset: 0x007C417E
	public bool NKAGIEFADLL()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.DKGMLIFDGFF().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && !this.AMCOGJHPPOC.HFIFOAPFKBG();
	}

	// Token: 0x060116AB RID: 71339 RVA: 0x007C5FB0 File Offset: 0x007C41B0
	public void NDCHOKBBJAG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.MEPIPLDFEJH().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DGOMGBDLAFP("WeaponReadyFire");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x060116AC RID: 71340 RVA: 0x007C605E File Offset: 0x007C425E
	public bool IHDIKFHMOLC()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.CGKPLOICANA().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && this.AMCOGJHPPOC.BEHHDDABAGA();
	}

	// Token: 0x060116AE RID: 71342 RVA: 0x007C6098 File Offset: 0x007C4298
	public void BLJDNPCLBKO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.GEKPOGFKOIB().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JDGIHFLNMKB("_FogDistance");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x060116AF RID: 71343 RVA: 0x007C6146 File Offset: 0x007C4346
	public bool GDHOPOMCFPE()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.FNAOHMNKKMB().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || !this.AMCOGJHPPOC.ANFINECKHNH();
	}

	// Token: 0x060116B0 RID: 71344 RVA: 0x007C6178 File Offset: 0x007C4378
	public void KBNKCBDHOCH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.DJDJANEACGF().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NLFMCBBJHBD("FOG_VOID_BOX");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x060116B1 RID: 71345 RVA: 0x007C6228 File Offset: 0x007C4428
	public void DPNHKGNKNDJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.CIBNPGCPGPF().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.HPAJGFGNMOH("</color>");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 1);
	}

	// Token: 0x060116B2 RID: 71346 RVA: 0x007C62D8 File Offset: 0x007C44D8
	public void NGCDOLBFODL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.IOCEJFMGBCG().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NLFMCBBJHBD("BlackSmithHammer");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 1);
	}

	// Token: 0x060116B3 RID: 71347 RVA: 0x007C6386 File Offset: 0x007C4586
	public bool IINCJJIOKML()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.DJDJANEACGF().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || !this.AMCOGJHPPOC.GCPDMBIEAOG();
	}

	// Token: 0x060116B4 RID: 71348 RVA: 0x007C63B8 File Offset: 0x007C45B8
	public void BJHFHGNPLMO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.NHIAAMIDCED().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.MLAKMCAPCOJ("H");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x060116B5 RID: 71349 RVA: 0x007C6468 File Offset: 0x007C4668
	public void IBOKCODJBGE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.MJAFCPCECCL().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DGOMGBDLAFP("The 'VAlign' command requires an alignment parameter of ? (default) or B (bottom).");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 1);
	}

	// Token: 0x060116B6 RID: 71350 RVA: 0x007C6516 File Offset: 0x007C4716
	public bool DEAIFFEHCND()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.LMEKEGJMPBN().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && this.AMCOGJHPPOC.HFIFOAPFKBG();
	}

	// Token: 0x060116B7 RID: 71351 RVA: 0x007C6548 File Offset: 0x007C4748
	public void LFCLBOOPIIP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.DKGMLIFDGFF().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JKBKMPBBGBA("_camHue");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 1);
	}

	// Token: 0x060116B8 RID: 71352 RVA: 0x007C65F6 File Offset: 0x007C47F6
	public bool FNHNEJNNKOJ()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.BMPIBIPNMCN().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && this.AMCOGJHPPOC.ODNAHJKPHKA();
	}

	// Token: 0x060116B9 RID: 71353 RVA: 0x007C6627 File Offset: 0x007C4827
	public bool NIPHEHICHLK()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.MJAFCPCECCL().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x060116BA RID: 71354 RVA: 0x007C6658 File Offset: 0x007C4858
	public bool JOOIEAIMIGG()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.MEPIPLDFEJH().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || this.AMCOGJHPPOC.HKJHMGJGNHJ();
	}

	// Token: 0x060116BB RID: 71355 RVA: 0x007C668C File Offset: 0x007C488C
	public void DLFEHGPGALE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.OJADINGIJLA().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.KPJNCIOMAGO("imgid");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 1);
	}

	// Token: 0x060116BC RID: 71356 RVA: 0x007C6516 File Offset: 0x007C4716
	public bool CFJIJJHOGAN()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.LMEKEGJMPBN().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && this.AMCOGJHPPOC.HFIFOAPFKBG();
	}

	// Token: 0x060116BD RID: 71357 RVA: 0x007C673A File Offset: 0x007C493A
	public bool MGOPKGFOEMG()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.NHIAAMIDCED().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && this.AMCOGJHPPOC.HALNOLGLEOJ();
	}

	// Token: 0x060116BE RID: 71358 RVA: 0x007C676C File Offset: 0x007C496C
	public void MFFKFBMJPPG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.KHOIICPPPOD().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.LNIKJLLFLAO("wpn_add/base");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x060116BF RID: 71359 RVA: 0x007C681C File Offset: 0x007C4A1C
	public void LCDEHLFNCED(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.MJAFCPCECCL().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.OAJBECLLIEP("WandAttack2");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 1);
	}

	// Token: 0x060116C0 RID: 71360 RVA: 0x007C68CA File Offset: 0x007C4ACA
	public bool KAANMADDCEL()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.DMJMEMIPKNM().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || !this.AMCOGJHPPOC.MLJCADOONGI();
	}

	// Token: 0x060116C1 RID: 71361 RVA: 0x007C68FB File Offset: 0x007C4AFB
	public bool FCEIMAANKJJ()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.LIKDNAJFKMN().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && !this.AMCOGJHPPOC.CFABOAAPLPI;
	}

	// Token: 0x060116C2 RID: 71362 RVA: 0x007C692C File Offset: 0x007C4B2C
	public bool INFHBOFCIBG()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.PNNGLBOIIMH().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && this.AMCOGJHPPOC.POJLMOPEBLN();
	}

	// Token: 0x060116C3 RID: 71363 RVA: 0x007C695D File Offset: 0x007C4B5D
	public bool NKNNJOHNGFH()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.DKGMLIFDGFF().method != AntialiasingModel.HNCLDIDKLAH.Fxaa || !this.AMCOGJHPPOC.ACEEFEFOCDF();
	}

	// Token: 0x060116C4 RID: 71364 RVA: 0x007C6990 File Offset: 0x007C4B90
	public void BFPEIJFLCEA(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.BBEPCCALAFC.IHEEFJOMFKE().fxaaSettings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.FGKNJIEOKHH("<color=\"");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.MFIJOOFCOOM, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(BKKAAEAHNJK.KBOGFDOFAOC.ADHDLDFGLDI, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 0);
	}

	// Token: 0x02000521 RID: 1313
	private static class KBOGFDOFAOC
	{
		// Token: 0x04002458 RID: 9304
		internal static readonly int MFIJOOFCOOM = Shader.PropertyToID("_QualitySettings");

		// Token: 0x04002459 RID: 9305
		internal static readonly int ADHDLDFGLDI = Shader.PropertyToID("_ConsoleSettings");
	}
}
